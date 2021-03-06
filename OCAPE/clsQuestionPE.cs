﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Xml;
using System.Windows.Forms;

namespace WindowsFormsApplication1

{

   public class clsQuestionPE
    {

        public static List<clsQuestionPE> lstQuestion = new List<clsQuestionPE>();


        public string strQuestion = string.Empty;
        public string strSelectionType= string.Empty;


        public List<Answer> lstAnswer = new List<Answer>();


        public string LoadQuestionFromXml(string strType)
        {
            string strMsg = string.Empty;
            XmlDocument doc = new XmlDocument();

            if (strType == "VE")
            {
                doc.Load("XMLquestion.xml");
            }
            else if (strType == "Easy")
            {
                doc.Load("XMLEasyQuestion.xml");
            }
            else if (strType == "Medium")
            {
                doc.Load("XMLMediumQuestion.xml");
            }
            else if (strType == "Hard")
            {
                doc.Load("XMLHardQuestion.xml");
            }





            if (doc.ChildNodes.Count == 0)
            {
                strMsg = "No node in xml file";
                return strMsg;
            }
            lstQuestion.Clear();

            foreach (XmlNode parentNode in doc.ChildNodes)
            {
                if (parentNode.Name.Trim().ToUpper() == "QUESTIONS")
                {
                    int intQuesCounter = 0;
                    foreach (XmlNode node in parentNode.ChildNodes)
                    {
                        intQuesCounter++;
                        clsQuestionPE Quest = new clsQuestionPE();
                        //Quest.strQuestion = node.InnerText;

                        Quest.strQuestion = node.Attributes[0].Value;
                        Quest.strSelectionType = node.Attributes[1].Value;
                        //strSelectionType = node.Attributes[1].Value;

                        //Add answer in list
                        List<string> lstTempAns = new List<string>();
                        foreach (XmlNode childNode in node.ChildNodes)
                        {
                            Answer objAnswer = new Answer();
                            objAnswer.strAnswer = childNode.InnerText;

                            XmlAttributeCollection attr = childNode.Attributes;
                            if (attr != null)
                            {
                                
                                foreach (XmlAttribute xmlAttr in attr)
                                {
                                    if (xmlAttr.Name.Trim().ToUpper() == "CORRECT")
                                    {
                                        if (xmlAttr.Value.Trim().ToUpper() == "TRUE")
                                        {
                                            objAnswer.blnCorrect = true;
                                            lstTempAns.Add(attr[0].Value);
                                        }
                                    }
                                    if (xmlAttr.Name.Trim().ToUpper() == "ID")
                                    {
                                        objAnswer.strID = xmlAttr.Value;
                                    }
                                }
                                
                            }

                            Quest.lstAnswer.Add(objAnswer);
                        }

                        lstQuestion.Add(Quest);
                        clsUserPE.dicMainList.Add(intQuesCounter.ToString(), lstTempAns);
                    }
                }
            }



            return string.Empty;
        }

        public void EnableDisable(int index, int count, Button btnNext, Button btnPrevious)
        {
            if ((count - index) >= 2)
            {
                if (index == 0)
                    btnPrevious.Enabled = false;
                else
                {
                    btnPrevious.Enabled = true;
                    btnNext.Enabled = true;
                }
            }
            else
            {
                if (index == 0)
                {
                    btnPrevious.Enabled = false;
                    btnNext.Enabled = false;
                }
                else
                {
                    btnPrevious.Enabled = true;
                    btnNext.Enabled = false;
                }
            }
        }

    }

    //class Answer
    //{
    //    public string strAnswer = string.Empty;
    //    public string strID = string.Empty;
    //    public bool blnCorrect = false;

    //}

}
