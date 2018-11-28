using System;
using System.IO;
using System.Xml;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmAdminOperation : Form
    {
        public frmAdminOperation()
        {
            InitializeComponent();
        }

       

        //private void richTextBox2_ContentsResized(object sender, ContentsResizedEventArgs e)
        //{
        //    ((RichTextBox)sender).Height = e.NewRectangle.Height + 5;
        //    panel10.ScrollControlIntoView(panel12);
        //}

        //private void richTextBox3_ContentsResized(object sender, ContentsResizedEventArgs e)
        //{
        //    ((RichTextBox)sender).Height = e.NewRectangle.Height + 5;
        //    panel10.ScrollControlIntoView(panel12);
        //}

        //private void richTextBox4_ContentsResized(object sender, ContentsResizedEventArgs e)
        //{
        //    ((RichTextBox)sender).Height = e.NewRectangle.Height + 5;
        //    panel10.ScrollControlIntoView(panel12);
        //}

        //private void richTextBox5_ContentsResized(object sender, ContentsResizedEventArgs e)
        //{
        //    ((RichTextBox)sender).Height = e.NewRectangle.Height + 5;
        //    panel10.ScrollControlIntoView(panel12);
        //}

        //private void richTextBox6_ContentsResized(object sender, ContentsResizedEventArgs e)
        //{
        //    ((RichTextBox)sender).Height = e.NewRectangle.Height + 5;
        //    panel10.ScrollControlIntoView(panel12);
        //}

        private void richTextBox7_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            ((RichTextBox)sender).Height = e.NewRectangle.Height + 5;
            panel10.ScrollControlIntoView(label9);
        }

        private void richTextBox12_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            ((RichTextBox)sender).Height = e.NewRectangle.Height + 5;
            panel3.ScrollControlIntoView(panel13);
        }

        private void richTextBox11_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            ((RichTextBox)sender).Height = e.NewRectangle.Height + 5;
            panel3.ScrollControlIntoView(panel13);
        }

        private void richTextBox10_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            ((RichTextBox)sender).Height = e.NewRectangle.Height + 5;
            panel3.ScrollControlIntoView(panel13);
        }

        private void richTextBox9_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            ((RichTextBox)sender).Height = e.NewRectangle.Height + 5;
            panel3.ScrollControlIntoView(panel13);
        }

        private void richTextBox8_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            ((RichTextBox)sender).Height = e.NewRectangle.Height + 5;
            panel3.ScrollControlIntoView(panel13);
        }

        private void richTextBox1_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            ((RichTextBox)sender).Height = e.NewRectangle.Height + 5;
            panel3.ScrollControlIntoView(panel13);
        }

       

        Question objQuestion = new Question();
        private void AddInList()
        {
            objQuestion = new Question();
            if (rtbAddQuestion.Text.Trim() != string.Empty)
            {
                objQuestion.Text = rtbAddQuestion.Text;
            }
            //else
            //{
            //    MessageBox.Show("Enter Question text", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            if (rdbAddSingle.Checked)
            {
                objQuestion.SelectionType = "1";
            }
            else if (rdbAddMultiple.Checked)
            {
                objQuestion.SelectionType = "2";
            }
            //Adding answer
            if (rtbAddAnswer1.Text.Trim() != string.Empty)
            {
                Answer1 objAns=new Answer1 ();
                objAns.ID = "1";
                objAns.strAdminAnswer = rtbAddAnswer1.Text;
                if (chkFirstAnsSelect.Checked)
                {
                    objAns.Correct = "true";
                }
                objQuestion.lstAnswer.Add(objAns);
                
            }
            //else
            //{
            //    MessageBox.Show("Enter first answer text", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             
            //}


            if (rtbAddAnswer2.Text.Trim() != string.Empty)
            {
                Answer1 objAns = new Answer1();
                objAns.ID = "2";
                objAns.strAdminAnswer = rtbAddAnswer2.Text;
                if (chkSecondAnsSelect.Checked)
                {
                    objAns.Correct = "true";
                }
                objQuestion.lstAnswer.Add(objAns);
            }
            //else
            //{
            //    MessageBox.Show("Enter second answer text", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            //}


            if (rtbAddAnswer3.Text.Trim() != string.Empty)
            {
                Answer1 objAns = new Answer1();
                objAns.ID = "3";
                objAns.strAdminAnswer = rtbAddAnswer3.Text;

                if (chkThirdAnsSelect.Checked)
                {
                    objAns.Correct = "true";
                }
                objQuestion.lstAnswer.Add(objAns);
            }
            //else
            //{
            //    MessageBox.Show("Enter third answer text", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            //}


            if (rtbAddAnswer4.Text.Trim() != string.Empty)
            {
                Answer1 objAns = new Answer1();
                objAns.ID = "4";
                objAns.strAdminAnswer = rtbAddAnswer4.Text;

                if (chkFourthAnsSelect.Checked)
                {
                    objAns.Correct = "true";
                }
                objQuestion.lstAnswer.Add(objAns);
            }
            //else
            //{
            //    MessageBox.Show("Enter fourth answer text", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}


            if (rtbAddAnswer5.Text.Trim() != string.Empty)
            {
                Answer1 objAns = new Answer1();
                objAns.ID = "5";
                objAns.strAdminAnswer = rtbAddAnswer5.Text;

                if (chkFifthAnsSelect.Checked)
                {
                    objAns.Correct = "true";
                }
                objQuestion.lstAnswer.Add(objAns);
            }
            //else
            //{
            //    MessageBox.Show("Enter fifth answer text", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}

            clsAdminOperation.lstQuestions.Add(objQuestion);
            
        }

         

        private void button4_Click(object sender, EventArgs e)
        {
            if ((rtbAddQuestion.Text == string.Empty) || (rtbAddAnswer1.Text == string.Empty) || (rtbAddAnswer2.Text == string.Empty) || (rtbAddAnswer3.Text == string.Empty) || (rtbAddAnswer4.Text == string.Empty) || (rtbAddAnswer5.Text == string.Empty))
            {
                MessageBox.Show("Enter all the boxes properly", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else if ((rdbAddSingle.Checked == false) && (rdbAddMultiple.Checked == false))
            {
                MessageBox.Show("Slect one of the type of question as singleSelect or MultipleSelect", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else if ((chkFirstAnsSelect.Checked == false) && (chkSecondAnsSelect.Checked == false) && (chkThirdAnsSelect.Checked == false) && (chkFourthAnsSelect.Checked == false) && (chkFifthAnsSelect.Checked  == false))
            {
                MessageBox.Show("select the checkbox(es) for the appropiate answer(s) that apply", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            
            else
            {
                AddInList();
                clsAdminOperation.SaveQuestionList();
                MessageBox.Show("Question added successfully", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reset();
            }
        }

        private void chkFirstAnsSelect_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAddSingle.Checked == true)
            {
                if(chkFirstAnsSelect.Checked==true)
                {
                chkFifthAnsSelect.Checked = false;
                chkSecondAnsSelect.Checked = false;
                chkThirdAnsSelect.Checked = false;
                chkFourthAnsSelect.Checked = false;
                }
            }
        }

        private void chkSecondAnsSelect_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAddSingle.Checked == true)
            {
                if (chkSecondAnsSelect.Checked == true)
                {
                    chkFifthAnsSelect.Checked = false;
                    chkFirstAnsSelect.Checked = false;
                    chkThirdAnsSelect.Checked = false;
                    chkFourthAnsSelect.Checked = false;
                }
            }
        }

        private void chkThirdAnsSelect_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAddSingle.Checked == true)
            {
                if (chkThirdAnsSelect.Checked == true)
                {
                    chkFifthAnsSelect.Checked = false;
                    chkSecondAnsSelect.Checked = false;
                    chkFirstAnsSelect.Checked = false;
                    chkFourthAnsSelect.Checked = false;
                }
            }
        }

        private void chkFourthAnsSelect_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAddSingle.Checked == true)
            {
                if (chkFourthAnsSelect.Checked == true)
                {
                    chkFifthAnsSelect.Checked = false;
                    chkSecondAnsSelect.Checked = false;
                    chkThirdAnsSelect.Checked = false;
                    chkFirstAnsSelect.Checked = false;
                }
            }
        }

        private void chkFifthAnsSelect_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAddSingle.Checked == true)
            {
                if (chkFifthAnsSelect.Checked == true)
                {
                    chkFourthAnsSelect.Checked = false;
                    chkSecondAnsSelect.Checked = false;
                    chkThirdAnsSelect.Checked = false;
                    chkFirstAnsSelect.Checked = false;
                }
            }
        }

        private void rdbAddSingle_CheckedChanged(object sender, EventArgs e)
        {
            chkFirstAnsSelect.Checked = false;
            chkSecondAnsSelect.Checked = false;
            chkThirdAnsSelect.Checked = false;
            chkFourthAnsSelect.Checked = false;
            chkFifthAnsSelect.Checked = false;
        }

        private void rdbAddMultiple_CheckedChanged(object sender, EventArgs e)
        {
            chkFirstAnsSelect.Checked = false;
            chkSecondAnsSelect.Checked = false;
            chkThirdAnsSelect.Checked = false;
            chkFourthAnsSelect.Checked = false;
            chkFifthAnsSelect.Checked = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void reset()
        {
            rtbAddQuestion.Clear();
            rtbAddAnswer1.Clear();
            rtbAddAnswer2.Clear();
            rtbAddAnswer3.Clear();
            rtbAddAnswer4.Clear();
            rtbAddAnswer5.Clear();
            rdbAddSingle.Checked = false;
            rdbAddMultiple.Checked = false;
            chkFirstAnsSelect.Checked = false;
            chkSecondAnsSelect.Checked = false;
            chkThirdAnsSelect.Checked = false;
            chkFourthAnsSelect.Checked = false;
            chkFifthAnsSelect.Checked = false;
        }



        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (frmAdminWelcome.filetype == "Easy Questions")
            {
                string content = System.IO.File.ReadAllText("XMLEasyQuestion.xml");
                rtbUpdateQuestion.Text = content;
            }
            else if (frmAdminWelcome.filetype == "Medium Questions")
            {
                string content = System.IO.File.ReadAllText("XMLMediumQuestion.xml");
                rtbUpdateQuestion.Text = content;
            }
            else if (frmAdminWelcome.filetype == "Hard Questions")
            {
                string content = System.IO.File.ReadAllText("XMLHardQuestion.xml");
                rtbUpdateQuestion.Text = content;
            }
            else if (frmAdminWelcome.filetype == "Virtual Exam Questions")
            {
                string content = System.IO.File.ReadAllText("XMLquestion.xml");
                rtbUpdateQuestion.Text = content;
            }


            //string content = System.IO.File.ReadAllText("XMLEasyQuestion.xml");
            //rtbUpdateQuestion.Text = content;

            //rtbUpdateQuestion.LoadFile("XMLEasyQuestion.xml");
        }



        private void btnupdatesave_Click(object sender, EventArgs e)
        {

            if (rtbUpdateQuestion.Text== string.Empty)
            {
                MessageBox.Show("You cannot replace a file with empty file","admin");
                    return;
            }
            else
            {
                string content = rtbUpdateQuestion.Text;
                System.IO.File.WriteAllText("XMLEasyQuestion.xml", content);
                MessageBox.Show("The updated file has been saved", "admin");
                rtbUpdateQuestion.Clear();
            }
        }

        private void btnUpdatereset_Click(object sender, EventArgs e)
        {
            rtbUpdateQuestion.Clear();
        }

        private void rtbUpdateQuestion_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            ((RichTextBox)sender).Height = e.NewRectangle.Height + 5;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAdminWelcome adminwelcme = new frmAdminWelcome();
            adminwelcme.Show();
            frmAdminWelcome.filetype = string.Empty;
        }

        private void btnAddInstruction_Click(object sender, EventArgs e)
        {
            lblUpdateInstructions.Visible = false;
            if (lblAddInstruction.Visible == true)
            {
                lblAddInstruction.Visible = false;
            }
            else
            {
                lblAddInstruction.Visible = true;
            }
        }

        private void btnUpdateInstruction_Click(object sender, EventArgs e)
        {
            lblAddInstruction.Visible = false;
            if (lblUpdateInstructions.Visible == true)
            {
                lblUpdateInstructions.Visible = false;
            }
            else 
            {
                lblUpdateInstructions.Visible = true;
            }
        }

        
    }
}
