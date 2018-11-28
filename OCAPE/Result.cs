using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing.Printing;


namespace WindowsFormsApplication1
{
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
        }

        

        private void Result_Load(object sender, EventArgs e)
        {
            if (PractiseExamStartup.formType == "PE")
            {
                lblTotalQuestion.Text = "OUT OF " + clsUserPE.dicMainList.Count + " )";
                lblCorrectAnswer.Text = "( " + clsUserPE.intScore.ToString();
                lblMarksPercent.Text = ((clsUserPE.intScore * 100) / clsUserPE.dicMainList.Count).ToString();
            }
            else
            {
                lblTotalQuestion.Text = "OUT OF " + clsUser.dicMainList.Count + " )";
                lblCorrectAnswer.Text = "( " + clsUser.intScore.ToString();
                lblMarksPercent.Text = ((clsUser.intScore * 100) / clsUser.dicMainList.Count).ToString();
            }
            if (Convert.ToInt32(lblMarksPercent.Text) > 70)
            {
                lblGrade.ForeColor = Color.Green;
                lblMarksPercent.ForeColor = Color.Green;
                lblGrade.Text = "PASS";
                pbarYourScore.Value = Convert.ToInt32( lblMarksPercent.Text);
            }
            else
            {
                lblGrade.ForeColor = Color.Red;
                lblMarksPercent.ForeColor = Color.Red;
                lblGrade.Text = "FAIL";
                pbarYourScore.Value = Convert.ToInt32(lblMarksPercent.Text);
            }
            lblMarksPercent.Text = lblMarksPercent.Text + "%";

        }

        //private void btnPrintResult_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        private void btnHome_Click(object sender, EventArgs e)
        {
            clsUser.dicMainList.Clear();
            clsUser.dicTempList.Clear();
            clsUserPE.dicMainList.Clear();
            clsUserPE.dicTempList.Clear();

            PractiseExamStartup.formType = string.Empty;

            this.Close();
            HomePage ObjHomePage = new HomePage();
            ObjHomePage.Show();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            clsUser.dicMainList.Clear();
            clsUser.dicTempList.Clear();
            clsUserPE.dicMainList.Clear();
            clsUserPE.dicTempList.Clear();

            PractiseExamStartup.formType = string.Empty;

            this.Close();
            HomePage ObjHomePage = new HomePage();
            ObjHomePage.Show();
        }

        //private void Result_FormClosing(object sender, FormClosingEventArgs e)
        //{

        //    DialogResult dr = MessageBox.Show("DO U WANT TO EXIT", "RESULT", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        //    if (dr == DialogResult.Yes)
        //    {
        //        Application.Exit();
        //    }
        //    else
        //    {
        //        e.Cancel = true;
        //    }
        //}

       

        

        
    }
}
