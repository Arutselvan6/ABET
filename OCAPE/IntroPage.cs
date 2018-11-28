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
    public partial class IntroPage : Form
    {
        public IntroPage()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            HomePage objHome = new HomePage();
            objHome.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lnklblAdministrator_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            frmAdminLogin objAdminLogin = new frmAdminLogin();
            objAdminLogin.Show();
        }

        private void lnklblAboutUs_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AboutBox1 abtus = new AboutBox1();
            abtus.Show();
        }
    }
}
