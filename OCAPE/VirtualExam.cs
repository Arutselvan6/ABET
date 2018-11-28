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
    public partial class VirtualExam : Form
    {
        public VirtualExam()
        {
            InitializeComponent();
        }

       

        int sec;
        int min;
        int hr;

        public static VirtualExam objVE = new VirtualExam();

        clsQuestion objQuestion = new clsQuestion();
        private void Form1_Load(object sender, EventArgs e)
        {
            objVE = (VirtualExam)sender;

             sec = 60;
             min = 29;
             hr = 01;
            lblTimer.Text = "01:29:60";

            btnPrevious.Enabled = false;
            vexamTimer.Enabled = true;
            
                        
            string strMsg = objQuestion.LoadQuestionFromXml();

            if (clsQuestion.lstQuestion.Count > 0)
            {
                //foreach (clsQuestion objQues in clsQuestion.lstQuestion)
                //{
                //    lblQuestion.Text = objQues.strQuestion;

                //    rdb1.Text = objQues.lstAnswer[0].strAnswer;
                //    rdb2.Text = objQues.lstAnswer[1].strAnswer;
                //    rdb3.Text = objQues.lstAnswer[2].strAnswer;
                //    rdb4.Text = objQues.lstAnswer[3].strAnswer;
               

                //    break;
                //}

               

                lblIndex.Text = "1";
                lblCount.Text = "of   " + clsQuestion.lstQuestion.Count;

                
                    rdb1.Name = rdb1.Name + "#" + clsQuestion.lstQuestion[Convert.ToInt32(lblIndex.Text) - 1].lstAnswer[0].strID;
                    rdb2.Name = rdb2.Name + "#" + clsQuestion.lstQuestion[Convert.ToInt32(lblIndex.Text) - 1].lstAnswer[1].strID;
                    rdb3.Name = rdb3.Name + "#" + clsQuestion.lstQuestion[Convert.ToInt32(lblIndex.Text) - 1].lstAnswer[2].strID;
                    rdb4.Name = rdb4.Name + "#" + clsQuestion.lstQuestion[Convert.ToInt32(lblIndex.Text) - 1].lstAnswer[3].strID;
                    rdb5.Name = rdb5.Name + "#" + clsQuestion.lstQuestion[Convert.ToInt32(lblIndex.Text) - 1].lstAnswer[4].strID;
                
                    chk1.Name = chk1.Name + "#" + clsQuestion.lstQuestion[Convert.ToInt32(lblIndex.Text) - 1].lstAnswer[0].strID;
                    chk2.Name = chk2.Name + "#" + clsQuestion.lstQuestion[Convert.ToInt32(lblIndex.Text) - 1].lstAnswer[1].strID;
                    chk3.Name = chk3.Name + "#" + clsQuestion.lstQuestion[Convert.ToInt32(lblIndex.Text) - 1].lstAnswer[2].strID;
                    chk4.Name = chk4.Name + "#" + clsQuestion.lstQuestion[Convert.ToInt32(lblIndex.Text) - 1].lstAnswer[3].strID;
                    chk5.Name = chk5.Name + "#" + clsQuestion.lstQuestion[Convert.ToInt32(lblIndex.Text) - 1].lstAnswer[4].strID;
                    
                DisplayQuestion(lblIndex.Text);

                objQuestion.EnableDisable(Convert.ToInt32(lblIndex.Text)-1 , clsQuestion.lstQuestion.Count, btnNext, btnPrevious);

            }

        }

        public void DisplayQuestion(string strLabelText)
        {
            panelAnsRdb.Visible = true;
            panelAnschk.Visible = true;
            //clsQuestion objTry = new clsQuestion();

            lblQuestion.Text = clsQuestion.lstQuestion[Convert.ToInt32(strLabelText) - 1].strQuestion;

            if (clsQuestion.lstQuestion[Convert.ToInt32(strLabelText) - 1].strSelectionType == "1")
            {
                panelAnschk.Visible = false;

                rdb1.Text = clsQuestion.lstQuestion[Convert.ToInt32(strLabelText) - 1].lstAnswer[0].strAnswer;
                rdb2.Text = clsQuestion.lstQuestion[Convert.ToInt32(strLabelText) - 1].lstAnswer[1].strAnswer;
                rdb3.Text = clsQuestion.lstQuestion[Convert.ToInt32(strLabelText) - 1].lstAnswer[2].strAnswer;
                rdb4.Text = clsQuestion.lstQuestion[Convert.ToInt32(strLabelText) - 1].lstAnswer[3].strAnswer;
                rdb5.Text = clsQuestion.lstQuestion[Convert.ToInt32(strLabelText) - 1].lstAnswer[4].strAnswer;

                rdb1.Checked = false;
                rdb2.Checked = false;
                rdb3.Checked = false;
                rdb4.Checked = false;
                rdb5.Checked = false;
            }
            else
            {
                panelAnsRdb.Visible = false;

                chk1.Text = clsQuestion.lstQuestion[Convert.ToInt32(strLabelText) - 1].lstAnswer[0].strAnswer;
                chk2.Text = clsQuestion.lstQuestion[Convert.ToInt32(strLabelText) - 1].lstAnswer[1].strAnswer;
                chk3.Text = clsQuestion.lstQuestion[Convert.ToInt32(strLabelText) - 1].lstAnswer[2].strAnswer;
                chk4.Text = clsQuestion.lstQuestion[Convert.ToInt32(strLabelText) - 1].lstAnswer[3].strAnswer;
                chk5.Text = clsQuestion.lstQuestion[Convert.ToInt32(strLabelText) - 1].lstAnswer[4].strAnswer;

                chk1.Checked = false;
                chk2.Checked = false;
                chk3.Checked = false;
                chk4.Checked = false;
                chk5.Checked = false;
            }

            lblIndex.Text = (Convert.ToInt32(strLabelText)).ToString();
            this.ScrollControlIntoView(lblTimer);
        }

        clsUser objUser = new clsUser();

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            lblIndex.Text = (Convert.ToInt32(lblIndex.Text) - 1).ToString();

            objQuestion.EnableDisable(Convert.ToInt32(lblIndex.Text)-1, clsQuestion.lstQuestion.Count, btnNext, btnPrevious);
           

            if (panelAnsRdb.Visible)
            {
                objUser.FillUserList((Convert.ToInt32(lblIndex.Text) + 1).ToString(), panelAnsRdb);
            }
            else
            {
                objUser.FillUserList((Convert.ToInt32(lblIndex.Text) + 1).ToString(), panelAnschk);
            }
            



            DisplayQuestion(lblIndex.Text);
            
            //call function to set value in control/s
            SetControlValueCall();

        }

        public void SetControlValueCall()
        {
            if (panelAnsRdb.Visible)
            {
                objUser.SetControlValue(Convert.ToInt32(lblIndex.Text).ToString(), panelAnsRdb);
            }
            else
            {
                objUser.SetControlValue(Convert.ToInt32(lblIndex.Text).ToString(), panelAnschk);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            DispNextQuestion();
            this.ScrollControlIntoView(lblTimer);
           
        }

        private void DispNextQuestion()
        {
            lblIndex.Text = (Convert.ToInt32(lblIndex.Text) + 1).ToString();

            objQuestion.EnableDisable(Convert.ToInt32(lblIndex.Text) - 1, clsQuestion.lstQuestion.Count, btnNext, btnPrevious);

            //call function to set visible true for panel

            //Save previous question/Ans
            if (panelAnsRdb.Visible)
            {
                objUser.FillUserList((Convert.ToInt32(lblIndex.Text) - 1).ToString(), panelAnsRdb);
            }
            else
            {
                objUser.FillUserList((Convert.ToInt32(lblIndex.Text) - 1).ToString(), panelAnschk);
            }

            DisplayQuestion(lblIndex.Text);

            //call function to set value in control/s
            if (panelAnsRdb.Visible)
            {
                objUser.SetControlValue(Convert.ToInt32(lblIndex.Text).ToString(), panelAnsRdb);
            }
            else
            {
                objUser.SetControlValue((Convert.ToInt32(lblIndex.Text)).ToString(), panelAnschk);
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {

            if (panelAnsRdb.Visible)
            {
                objUser.FillUserList((Convert.ToInt32(lblIndex.Text)).ToString(), panelAnsRdb);
            }
            else
            {
                objUser.FillUserList((Convert.ToInt32(lblIndex.Text)).ToString(), panelAnschk);
            }


            objUser.CalculateScore();
            this.Close();

            

            Result objResult = new Result();
            objResult.Show();
            
        }

        private void rdb1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb1.Checked)
            {
                rdb2.Checked = false;
                rdb3.Checked = false;
                rdb4.Checked = false;
                rdb5.Checked = false;

            }

        }

        private void rdb2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb2.Checked)
            {
                rdb1.Checked = false;
                rdb3.Checked = false;
                rdb4.Checked = false;
                rdb5.Checked = false;

            }

        }

        private void rdb3_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb3.Checked)
            {
                rdb1.Checked = false;
                rdb2.Checked = false;
                rdb4.Checked = false;
                rdb5.Checked = false;

            }

        }

        private void rdb4_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb4.Checked)
            {
                rdb1.Checked = false;
                rdb2.Checked = false;
                rdb3.Checked = false;
                rdb5.Checked = false;

            }
        }

        private void rdb5_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb5.Checked)
            {
                rdb1.Checked = false;
                rdb2.Checked = false;
                rdb3.Checked = false;
                rdb4.Checked = false;

            }
        }

        private void vexamTimer_Tick(object sender, EventArgs e)
        {
           sec-=1;
           if(sec==0)
           {


               if (hr == 0 && min == 0)
               {
                   vexamTimer.Enabled = false;
                   //MessageBox.Show("u r out of ur time");

               }
               else
               {
                   min--;
                   sec = 60;
               }
               
               
           }
            if(min==0)
            {


                if (hr == 0)
                {
                    if (sec == 0)
                    {

                        vexamTimer.Enabled = false;
                       // MessageBox.Show("u r out of ur time");
                    }
                }
                else
                {
                    min = 60;
                    hr--;
                }
            }

            lblTimer.Text = hr.ToString("00") + ":" + min.ToString("00") + ":" + sec.ToString("00");

            if ((hr == 0) && (min == 0) && (sec == 0))
            {
                vexamTimer.Enabled = false;
                MessageBox.Show("YOU ARE OUT OF YOUR TIME","OCA PREPARATION ENVIRONMENT",MessageBoxButtons.OK,MessageBoxIcon.Warning );
               
                
                if (panelAnsRdb.Visible)
                {
                    objUser.FillUserList((Convert.ToInt32(lblIndex.Text)).ToString(), panelAnsRdb);
                }
                else
                {
                    objUser.FillUserList((Convert.ToInt32(lblIndex.Text)).ToString(), panelAnschk);
                }


                objUser.CalculateScore();
                this.Hide();
                Result objResult = new Result();
                objResult.Show();

           }

        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            if (panelAnsRdb.Visible)
            {
                objUser.FillUserList((Convert.ToInt32(lblIndex.Text)).ToString(), panelAnsRdb);
            }
            else
            {
                objUser.FillUserList((Convert.ToInt32(lblIndex.Text)).ToString(), panelAnschk);
            }
            frmReview objReview = new frmReview();
            objReview.Show();

        }


       
    }
}
