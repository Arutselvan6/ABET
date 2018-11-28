using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApplication1
{
    public partial class StudySession : Form
    {
        public StudySession()
        {
            InitializeComponent();
        }

        Dictionary<string, string> dicBooks = new Dictionary<string, string>();
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (dicBooks.Count > 0)
            {
                if (dicBooks.Keys.Contains(e.Node.Text))
                {
                    webBrowser1.DocumentText = dicBooks[e.Node.Text]; 
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string strMsg = string.Empty;
            XmlDocument doc = new XmlDocument();

            doc.Load("XMLBook.xml");
            foreach (XmlNode node in doc.ChildNodes)
            {
                if (node.Name == "Books")
                {
                    foreach (XmlNode childNode in node.ChildNodes)
                    {
                        dicBooks.Add(childNode.Name, childNode.InnerXml);
                    }
                }
            }
            
        }

       

        

        

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage ObjHomepage = new HomePage();
            ObjHomepage.Show();
        }

        

        

        

        
    }
}
