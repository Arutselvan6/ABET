using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmAdminLogin : Form
    {
        public frmAdminLogin()
        {
            InitializeComponent();
        }

        

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            IntroPage objIntropg= new IntroPage();
            objIntropg.Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string password = "pranavpra";
            if (textBox1.Text == password)
            {
                this.Close();
                frmAdminWelcome adminwelcome = new frmAdminWelcome();
                adminwelcome.Show();
            }
            else
            {
                MessageBox.Show("Please Enter Correct Password, or contact ur administrator", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Clear();
                return;
            }
        }

        private void frmAdminLogin_Load(object sender, EventArgs e)
        {
            btnSubmit.Focus();
        }

       
    }
}
