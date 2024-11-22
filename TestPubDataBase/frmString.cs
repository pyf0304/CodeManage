using com.taishsoft.common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestPubDataBase
{
    public partial class frmString : Form
    {
        public frmString()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str1 = clsString.MakeRandom(3 , 1);
            string str2 = clsString.MakeRandom(3, 2);
            string str3 = clsString.MakeRandom(3,3);
            string str4 = clsString.MakeRandom(3,4);

            MessageBox.Show(str1 + str2 +str3+ str4);
        }

        private void btnGetUniqueStrValue_Click(object sender, EventArgs e)
        {
            List<string> arrSourceStr = new List<string>();
            arrSourceStr.Add("a");
            arrSourceStr.Add("b");
            arrSourceStr.Add("a");
            arrSourceStr.Add("b");
            arrSourceStr.Add("a");
            arrSourceStr.Add("b");
            arrSourceStr.Add("a1");
            arrSourceStr.Add("b1");
            List<string> arrValueLst = new List<string>();
            foreach (string strValue in arrSourceStr)
            {
                string strValue_New = clsString.GetUniqueStrValue_S(strValue, arrValueLst);
                lbResult.Items.Add(string.Format("{0}-->{1}", strValue, strValue_New));
                arrValueLst.Add(strValue_New);
            }
        }
    }
}
