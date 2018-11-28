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
    public partial class PractiseExamStartup : Form
    {

        
        public PractiseExamStartup()
        {
            InitializeComponent();
        }
        public static int time = 0;
        public static string DifficultyLevel = string.Empty;
        public static string formType = string.Empty;
 

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStartTest_Click(object sender, EventArgs e)
        {

            formType = "PE";


            if (comboboxTime.SelectedIndex == -1)
            {
                MessageBox.Show("select your time duration plz","Practise Exam",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                comboboxTime.Focus();
                return;
            }

            if (rdbEasy.Checked)
            {
                DifficultyLevel = rdbEasy.Text;
            }
            else if (rdbMedium.Checked)
            {
                DifficultyLevel = rdbMedium.Text;
            }
            else if (rdbHard.Checked)
            {
                DifficultyLevel = rdbHard.Text;
            }
            time = Convert.ToInt32(comboboxTime.Text);
            this.Hide();
            PractiseExam objPractiseExam = new PractiseExam();
            objPractiseExam.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            HomePage objHome = new HomePage();
            objHome.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

            this.Close();
            HomePage objHome = new HomePage();
            objHome.Show();
        }

       
    }
}
