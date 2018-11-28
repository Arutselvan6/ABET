using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1

{
    public class clsUser
    {
        public static int intScore;
        public static Dictionary<string, List<string>> dicMainList = new Dictionary<string, List<string>>();
        public static Dictionary<string, List<string>> dicTempList = new Dictionary<string, List<string>>();

        public void FillUserList(string strIndex, Panel panelControl)
        {
            if (dicTempList.Keys.Contains(strIndex))
            {
                //Call function to set value in control/s
                dicTempList.Remove(strIndex);
            }
            List<string> lstTempAns = new List<string>();
            Control.ControlCollection parentColl = panelControl.Controls;
            foreach (Control parentCntrl in parentColl)
            {
                Control.ControlCollection childColl = parentCntrl.Controls;
                foreach (Control childCntrl in childColl)
                {
                    if (childCntrl is RadioButton)
                    {
                        RadioButton rdb = (RadioButton)childCntrl;
                        if (rdb.Checked)
                        {
                            string[] strArr = rdb.Name.Split('#');
                            lstTempAns.Add(strArr[1]);
                            break;
                        }
                    }
                    else if (childCntrl is CheckBox)
                    {
                        CheckBox chk = (CheckBox)childCntrl;
                        if (chk.Checked)
                        {
                            if (chk.Name.Contains('#'))
                            {
                                string[] strArr = chk.Name.Split('#');
                                lstTempAns.Add(strArr[1]);
                            }
                        }

                    }
                }
            }
            if (!dicTempList.Keys.Contains(strIndex))
            {
                dicTempList.Add(strIndex, lstTempAns);
            }
        }

        public void SetControlValue(string strIndex, Panel panelControl)
        {
            if (dicTempList.Keys.Contains(strIndex))
            {
                List<string> lstTempAns = new List<string>();
                Control.ControlCollection parentColl = panelControl.Controls;
                foreach (Control parentCntrl in parentColl)
                {
                    Control.ControlCollection childColl = parentCntrl.Controls;
                    foreach (Control childCntrl in childColl)
                    {
                        if (childCntrl is RadioButton)
                        {
                            RadioButton rdb = (RadioButton)childCntrl;
                            string[] strArr = rdb.Name.Split('#');
                            foreach (string strAnsID in dicTempList[strIndex])
                            {
                                if (strArr[1].Trim().ToUpper() == strAnsID.Trim().ToUpper())
                                {
                                    rdb.Checked = true;
                                    break;
                                }
                            }
                            
                        }
                        else if (childCntrl is CheckBox)
                        {
                            CheckBox chk = (CheckBox)childCntrl;
                            string[] strArr = chk.Name.Split('#');
                            foreach (string strAnsID in dicTempList[strIndex])
                            {
                                if (strArr[1].Trim().ToUpper() == strAnsID.Trim().ToUpper())
                                {
                                    chk.Checked = true;
                                }
                            }
                        }
                    }
                }
            }
        }

        public void CalculateScore()
        {
            intScore = 0;
            if (dicMainList.Count > 0)
            {
                foreach (string strTempIndex in dicTempList.Keys)
                {
                    foreach (string strMainIndex in dicMainList.Keys)
                    {
                        if (strTempIndex == strMainIndex)
                        {
                            if (dicTempList[strTempIndex].Count > 0)
                            {
                                bool blnAns = true;
                                foreach (string strTempAns in dicTempList[strTempIndex])
                                {
                                    if (!dicMainList[strMainIndex].Contains(strTempAns))
                                    {
                                        blnAns = false;
                                        break;
                                    }
                                }
                                if (blnAns)
                                {
                                    intScore++;
                                }

                            }
                            break;
                        }

                    }
                }
            }
        }
    }
}
 