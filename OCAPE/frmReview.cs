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
    public partial class frmReview : Form
    {
        public frmReview()
        {
            InitializeComponent();
        }

        private void frmReview_Load(object sender, EventArgs e)
        {
            funReview();
        }


        private void funReview()
        {
            int ycoordinate = 10;
            for (int intIndex = 0; intIndex < clsQuestion.lstQuestion.Count; intIndex++)
            {
                foreach (KeyValuePair<string, List<string>> keyValue in clsUser.dicTempList)
                {
                    if ((intIndex + 1).ToString() == keyValue.Key)
                    {
                        LinkLabel lnklblQuestiontext = new LinkLabel();
                        lnklblQuestiontext.Text = clsQuestion.lstQuestion[intIndex].strQuestion ;
                        lnklblQuestiontext.Name = intIndex.ToString();
                        lnklblQuestiontext.Width = 500;
                        lnklblQuestiontext.Height = 40;
                        panelReview.Controls.Add(lnklblQuestiontext);
                        lnklblQuestiontext.Click += new EventHandler(lnklblQuestiontext_Click);
                        lnklblQuestiontext.Location = new Point(panelReview.Location.X + 20, panelReview.Location.Y + ycoordinate);
                        ycoordinate = ycoordinate + lnklblQuestiontext.Height  + 15;
                        Label lblAnswer = new Label();
                        foreach (string keyValAnswer in keyValue.Value)
                        {
                            if (lblAnswer.Text == string.Empty)
                            {
                                lblAnswer.Text = showAnswertext(keyValAnswer);

                            }
                            else
                            {
                                lblAnswer.Text = lblAnswer.Text + "," + showAnswertext(keyValAnswer);

                            }
                        }
                        lblAnswer.ForeColor = Color.Green ;
                        

                        if (lblAnswer.Text == string.Empty)
                        {
                            lblAnswer.Text = "NOT ATTEMPTED";
                            lblAnswer.ForeColor  = Color.Red ;
                        }
                        panelReview.Controls.Add(lblAnswer);
                        lblAnswer.Location = new Point(lnklblQuestiontext.Location.X + lnklblQuestiontext.Width, lnklblQuestiontext.Location.Y);
                       // lblAnswer.Font.Bold;

                    }

                }
            }

        }

        void lnklblQuestiontext_Click(object sender, EventArgs e)
        {
            LinkLabel lnkLbl=(LinkLabel)sender;
            VirtualExam.objVE.DisplayQuestion((Convert.ToInt32(lnkLbl.Name) + 1).ToString());
            VirtualExam.objVE.SetControlValueCall();
            VirtualExam.objVE.Show();
            this.Close();

            //throw new NotImplementedException();

        }
        private string showAnswertext(string  Answer)
    {
        string strTempAnswer = string.Empty;
        
        
           // Convert.ToInt32(Answer);
            
            switch (Answer )
            {
                case "1":
                    strTempAnswer = "A";
                    break;
                case "2":
                    strTempAnswer = "B";
                    break;
                case "3":
                    strTempAnswer = "C";
                    break;
                case "4":
                    strTempAnswer = "D";
                    break;
                case "5":
                    strTempAnswer = "E";
                    break;
                default:
                    strTempAnswer = "NOT ATTEMPTED";
                    break;
          
        }
        return (strTempAnswer);
        
    }
    
    
    }

}
