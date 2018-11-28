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
    public partial class StartUp : Form
    {
        int interval = 0;
        public StartUp()
        {
            InitializeComponent();
        }

        private void StartUp_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            interval++;
            if (interval == 2)
            {
                this.Hide();
                IntroPage objIntro = new IntroPage();
                objIntro.Show();
                timer1.Enabled = false;
            }
        }

       
    }
}
