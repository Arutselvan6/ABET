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
    public partial class frmAdminWelcome : Form
    {
        public frmAdminWelcome()
        {
            InitializeComponent();
        }

        public static string filetype = string.Empty;

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            frmAdminLogin frmadmin = new frmAdminLogin();
            frmadmin.Show();
            frmAdminWelcome.filetype = string.Empty;
            
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            
            if(cmbboxFiletype.SelectedIndex==-1)
            {
                MessageBox.Show("select the file name to be edited","Practise Exam",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                cmbboxFiletype.Focus();
                return;
            }

            filetype=cmbboxFiletype.Text;
            this.Close();
            frmAdminOperation objAdminOper = new frmAdminOperation();
            objAdminOper.Show();
        }

       
    }

        
    }

