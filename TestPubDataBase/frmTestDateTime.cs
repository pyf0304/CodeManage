using com.taishsoft.common;
using com.taishsoft.datetime;
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
    public partial class frmTestDateTime : Form
    {
        public frmTestDateTime()
        {
            InitializeComponent();
        }

        private void btnInitDateTime_Click(object sender, EventArgs e)
        {
            string strInitPara = txtInitPara.Text;
            clsDateTime objDT = null;
            try
            {
                objDT = new clsDateTime(strInitPara);
            }
            catch(Exception objException)
            {
                MessageBox.Show(objException.Message);
                return;
            }
            string strMsg = objDT.getDateStr(0);
            MessageBox.Show(strMsg);
            lblResult.Text = strMsg;
        }

        private void btnGetDateTime_Sim_Click(object sender, EventArgs e)
        {
            string strDateTime19 = "2020-07-05 12:33:44";
            string strDateTime_Sim = clsDateTime.GetDateTime_Sim(strDateTime19);
            lblResult.Text = strDateTime_Sim;
        }
    }
}
