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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btnStudysession_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudySession objStudySession = new StudySession();            
            objStudySession.Show();
        }

        private void btnExam_Click(object sender, EventArgs e)
        {
            this.Close();
            frmVirtualExamIntro objVEIntro = new frmVirtualExamIntro();
            objVEIntro.Show();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            IntroPage ObjIntroPage = new IntroPage();
            ObjIntroPage.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnPractise_Click(object sender, EventArgs e)
        {
            this.Hide();
            PractiseExamStartup objPractiseStartup = new PractiseExamStartup();
            objPractiseStartup.Show();
        }

        

        
    }
}
