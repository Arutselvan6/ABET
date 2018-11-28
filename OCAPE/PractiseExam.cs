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
    public partial class PractiseExam : Form
    {
        public PractiseExam()
        {
            InitializeComponent();
        }

        int time;
        int sec;
        int min;
        int hr;


        clsQuestionPE objQuestion = new clsQuestionPE();

       
        private void DisplayQuestion()
        {
            panelAnsRdb.Visible = true;
            panelAnschk.Visible = true;
            //clsQuestion objTry = new clsQuestion();

            lblQuestion.Text = clsQuestionPE.lstQuestion[Convert.ToInt32(lblIndex.Text) - 1].strQuestion;

            if (clsQuestionPE.lstQuestion[Convert.ToInt32(lblIndex.Text) - 1].strSelectionType == "1")
            {
                panelAnschk.Visible = false;
                lblExplanationRdb6.Visible=false;
                
                rdb1.Text = clsQuestionPE.lstQuestion[Convert.ToInt32(lblIndex.Text) - 1].lstAnswer[0].strAnswer;
                rdb2.Text = clsQuestionPE.lstQuestion[Convert.ToInt32(lblIndex.Text) - 1].lstAnswer[1].strAnswer;
                rdb3.Text = clsQuestionPE.lstQuestion[Convert.ToInt32(lblIndex.Text) - 1].lstAnswer[2].strAnswer;
                rdb4.Text = clsQuestionPE.lstQuestion[Convert.ToInt32(lblIndex.Text) - 1].lstAnswer[3].strAnswer;
                rdb5.Text = clsQuestionPE.lstQuestion[Convert.ToInt32(lblIndex.Text) - 1].lstAnswer[4].strAnswer;
                lblExplanationRdb6.Text=clsQuestionPE.lstQuestion[Convert.ToInt32(lblIndex.Text) - 1].lstAnswer[5].strAnswer;

                rdb1.Checked = false;
                rdb2.Checked = false;
                rdb3.Checked = false;
                rdb4.Checked = false;
                rdb5.Checked = false;
            }
            else
            {
                panelAnsRdb.Visible = false;
                lblExplanationChk6.Visible=false;

                chk1.Text = clsQuestionPE.lstQuestion[Convert.ToInt32(lblIndex.Text) - 1].lstAnswer[0].strAnswer;
                chk2.Text = clsQuestionPE.lstQuestion[Convert.ToInt32(lblIndex.Text) - 1].lstAnswer[1].strAnswer;
                chk3.Text = clsQuestionPE.lstQuestion[Convert.ToInt32(lblIndex.Text) - 1].lstAnswer[2].strAnswer;
                chk4.Text = clsQuestionPE.lstQuestion[Convert.ToInt32(lblIndex.Text) - 1].lstAnswer[3].strAnswer;
                chk5.Text = clsQuestionPE.lstQuestion[Convert.ToInt32(lblIndex.Text) - 1].lstAnswer[4].strAnswer;
                lblExplanationChk6.Text=clsQuestionPE.lstQuestion[Convert.ToInt32(lblIndex.Text) - 1].lstAnswer[5].strAnswer;

                chk1.Checked = false;
                chk2.Checked = false;
                chk3.Checked = false;
                chk4.Checked = false;
                chk5.Checked = false;
            }

            this.ScrollControlIntoView(panel4);
        }


        clsUserPE objUser = new clsUserPE();

       


       

        private void PractiseExam_Load(object sender, EventArgs e)
        {
           // PractiseExamStartup objPractiseExam = new PractiseExamStartup();
          //  time=(objPractiseExam.comboboxTime.SelectedItem).ToString();
            time = PractiseExamStartup.time;
            if (time == 15)
            {
                sec = 60;
                min = 14;
                hr = 0;
                lblTimer.Text = "00:14:60";

            }

            else if (time == 30)
            {
                sec = 60;
                min = 29;
                hr = 00;
                lblTimer.Text = "00:29:60";
               
            }

            else if (time == 45)
            {
                sec = 60;
                min = 44;
                hr = 00;
                lblTimer.Text = "00:44:60";
            }

            else if (time == 60)
            {
                sec = 60;
                min = 59;
                hr = 00;
                lblTimer.Text = "00:59:60";
            }

            else if (time == 90)
            {
                sec = 60;
                min = 29;
                hr = 01;
                lblTimer.Text = "01:29:60";
            }
            
          


            btnPrevious.Enabled = false;
            pexamTimer.Enabled = true;


            string strMsg = objQuestion.LoadQuestionFromXml(PractiseExamStartup.DifficultyLevel);

            if (clsQuestionPE.lstQuestion.Count > 0)
            {
                lblIndex.Text = "1";
                lblCount.Text = "of   " + clsQuestionPE.lstQuestion.Count;


                rdb1.Name = rdb1.Name + "#" + clsQuestionPE.lstQuestion[Convert.ToInt32(lblIndex.Text) - 1].lstAnswer[0].strID;
                rdb2.Name = rdb2.Name + "#" + clsQuestionPE.lstQuestion[Convert.ToInt32(lblIndex.Text) - 1].lstAnswer[1].strID;
                rdb3.Name = rdb3.Name + "#" + clsQuestionPE.lstQuestion[Convert.ToInt32(lblIndex.Text) - 1].lstAnswer[2].strID;
                rdb4.Name = rdb4.Name + "#" + clsQuestionPE.lstQuestion[Convert.ToInt32(lblIndex.Text) - 1].lstAnswer[3].strID;
                rdb5.Name = rdb5.Name + "#" + clsQuestionPE.lstQuestion[Convert.ToInt32(lblIndex.Text) - 1].lstAnswer[4].strID;
                lblExplanationRdb6.Name = lblExplanationRdb6.Name + "#" + clsQuestionPE.lstQuestion[Convert.ToInt32(lblIndex.Text) - 1].lstAnswer[5].strID;

                chk1.Name = chk1.Name + "#" + clsQuestionPE.lstQuestion[Convert.ToInt32(lblIndex.Text) - 1].lstAnswer[0].strID;
                chk2.Name = chk2.Name + "#" + clsQuestionPE.lstQuestion[Convert.ToInt32(lblIndex.Text) - 1].lstAnswer[1].strID;
                chk3.Name = chk3.Name + "#" + clsQuestionPE.lstQuestion[Convert.ToInt32(lblIndex.Text) - 1].lstAnswer[2].strID;
                chk4.Name = chk4.Name + "#" + clsQuestionPE.lstQuestion[Convert.ToInt32(lblIndex.Text) - 1].lstAnswer[3].strID;
                chk5.Name = chk5.Name + "#" + clsQuestionPE.lstQuestion[Convert.ToInt32(lblIndex.Text) - 1].lstAnswer[4].strID;
                lblExplanationChk6.Name = lblExplanationChk6.Name + "#" + clsQuestionPE.lstQuestion[Convert.ToInt32(lblIndex.Text) - 1].lstAnswer[5].strID;
                DisplayQuestion();

                objQuestion.EnableDisable(Convert.ToInt32(lblIndex.Text) - 1, clsQuestionPE.lstQuestion.Count, btnNext, btnPrevious);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            lblIndex.Text = (Convert.ToInt32(lblIndex.Text) + 1).ToString();

            objQuestion.EnableDisable(Convert.ToInt32(lblIndex.Text) - 1, clsQuestionPE.lstQuestion.Count, btnNext, btnPrevious);

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

            DisplayQuestion();

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

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            lblIndex.Text = (Convert.ToInt32(lblIndex.Text) - 1).ToString();

            objQuestion.EnableDisable(Convert.ToInt32(lblIndex.Text) - 1, clsQuestionPE.lstQuestion.Count, btnNext, btnPrevious);


            if (panelAnsRdb.Visible)
            {
                objUser.FillUserList((Convert.ToInt32(lblIndex.Text) + 1).ToString(), panelAnsRdb);
            }
            else
            {
                objUser.FillUserList((Convert.ToInt32(lblIndex.Text) + 1).ToString(), panelAnschk);
            }




            DisplayQuestion();

            //call function to set value in control/s
            if (panelAnsRdb.Visible)
            {
                objUser.SetControlValue(Convert.ToInt32(lblIndex.Text).ToString(), panelAnsRdb);
            }
            else
            {
                objUser.SetControlValue(Convert.ToInt32(lblIndex.Text).ToString(), panelAnschk);
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (panelAnschk.Visible == true)
            {
                
                if (lblExplanationChk6.Visible == false)
                {
                    lblExplanationChk6.Visible = true;
                }
                else 
                {
                    lblExplanationChk6.Visible = false;
                }
 
            }

            if (panelAnsRdb.Visible == true)
            {
                
                if (lblExplanationRdb6.Visible == false)
                {
                    lblExplanationRdb6.Visible = true;
                    this.ScrollControlIntoView(lblExplanationRdb6);
                }
                else
                {
                    lblExplanationRdb6.Visible = false;
                }
            }
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

        private void pexamTimer_Tick(object sender, EventArgs e)
        {

            sec -= 1;
            if (sec == 0)
            {


                if (hr == 0 && min == 0)
                {
                    pexamTimer.Enabled = false;
                    //MessageBox.Show("u r out of ur time");

                }
                else
                {
                    min--;
                    sec = 60;
                }


            }
            if (min == 0)
            {


                if (hr == 0)
                {
                    if (sec == 0)
                    {

                        pexamTimer.Enabled = false;
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
                pexamTimer.Enabled = false;
                MessageBox.Show("YOU ARE OUT OF YOUR TIME", "OCA PREPARATION ENVIRONMENT", MessageBoxButtons.OK, MessageBoxIcon.Warning);


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



    }


    }
 
