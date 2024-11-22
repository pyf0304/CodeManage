using com.taishsoft.common;
using com.taishsoft.math;
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
    public partial class frmMath_Edu : Form
    {
        public frmMath_Edu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strFullScore = txtFulleScore.Text;
            int intFullScore = int.Parse(strFullScore);
            string strMinScore = txtMinScore.Text;
            if (string.IsNullOrEmpty(strMinScore) == true) strMinScore = "0";
            int intMinScore = int.Parse(strMinScore);

            double dblRandNum;
            string strData = "";
            Random rnd = new Random();
            for (int i = 0; i < 30; i++)
            {
                dblRandNum = rnd.Next(intMinScore, intFullScore);
                strData += string.Format("{0},", dblRandNum);
            }
            txtData.Text = strData;
        }

        private void btnStandardDeviation_Click(object sender, EventArgs e)
        {
            double[] dblData = new double[30];
            string sstrData = txtData.Text ;
            sstrData = sstrData.TrimEnd(',');
            string[] arrData = sstrData.Split(',');
            int intIndex = 0;
            foreach(string strData in arrData)
            {
                if (string.IsNullOrEmpty(strData) == true) continue;
                double dblNum = double.Parse(strData);
                dblData[intIndex++] = dblNum;
            }
            double dblStandardDeviation = clsMath_Edu.StandardDeviation(dblData, intIndex);
            txtStandardDeviation.Text = dblStandardDeviation.ToString();
        }

        private void frmMath_Edu_Load(object sender, EventArgs e)
        {
            txtFulleScore.Text = "100";
            txtData.Text = "95,85,75,65,55,45";
        }
    }
}
