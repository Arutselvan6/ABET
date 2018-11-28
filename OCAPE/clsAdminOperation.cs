using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    [System.Xml.Serialization.XmlRoot("Questions")]
    class clsAdminOperation
    {
       
        [System.Xml.Serialization.XmlArray]
        public static List<Question> lstQuestions = new List<Question>();


        public static string File_name = string.Empty;

        public static void LoadQuestionList(Stream stream)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(clsAdminOperation));
            clsAdminOperation objAdmin = (clsAdminOperation)xmlSerializer.Deserialize(stream);
        }

        public static void SaveQuestionList()
        {
            string FileType = string.Empty;
            FileType = frmAdminWelcome.filetype;
            

            if (FileType == "Easy Questions")
            {
                 File_name = "XMLEasyQuestion.xml";
            }
            else if (FileType == "Medium Questions")
            {
                 File_name = "XMLMediumQuestion.xml";
            }

            else if (FileType == "Hard Questions")
            {
                 File_name = "XMLHardQuestion.xml";
            }
            else if (FileType == "Virtual Exam Questions")
            {
               File_name = "XMLquestion.xml";
            }

            System.Xml.XmlDocument xmlDocument = new System.Xml.XmlDocument();
            string FileName = clsAdminOperation.File_name;

            try
            {
                xmlDocument.Load(FileName);
            }
            catch (System.IO.FileNotFoundException)
            {

                XmlTextWriter xmlWriter = new XmlTextWriter(FileName, System.Text.Encoding.UTF8);
                xmlWriter.Formatting = Formatting.Indented;
                xmlWriter.WriteProcessingInstruction("xml", "version='1.0' encoding='UTF-8'");
                xmlWriter.WriteStartElement("questions"); 
                xmlWriter.Close();
                xmlDocument.Load(FileName);
            }

            XmlNode root = xmlDocument.DocumentElement;
            XmlElement QuestionNode = xmlDocument.CreateElement("Question");
            QuestionNode.SetAttribute("Text", lstQuestions[lstQuestions.Count - 1].Text);
            QuestionNode.SetAttribute("SelectionType", lstQuestions[lstQuestions.Count - 1].SelectionType);

            root.AppendChild(QuestionNode);

            foreach (Answer1 objAns in lstQuestions[lstQuestions.Count - 1].lstAnswer)
            {
                XmlElement ElementAnswer = xmlDocument.CreateElement("Answer");
                ElementAnswer.SetAttribute("ID", objAns.ID);
                ElementAnswer.SetAttribute("Correct", objAns.Correct);

                XmlText InnerText = xmlDocument.CreateTextNode("Node");
                InnerText.Value = objAns.strAdminAnswer;

                ElementAnswer.AppendChild(InnerText);

                QuestionNode.AppendChild(ElementAnswer);
                

            }
                             
            xmlDocument.Save(FileName);
            
            
        }
    }
    class Answer1
    {
        [System.Xml.Serialization.XmlAttribute]
        public string strAdminAnswer = string.Empty;

        [System.Xml.Serialization.XmlAttribute]
        public string ID = string.Empty;

        [System.Xml.Serialization.XmlAttribute]
        public string Correct = string.Empty;

        [System.Xml.Serialization.XmlAttribute]
        public bool AnsSelect = false;

    }

    class Question
    {
        [System.Xml.Serialization.XmlAttribute]
        public string Text = string.Empty;

        [System.Xml.Serialization.XmlAttribute]
        public string SelectionType = string.Empty;

        [System.Xml.Serialization.XmlArray]
        public List<Answer1> lstAnswer = new List<Answer1>();

    }
}
