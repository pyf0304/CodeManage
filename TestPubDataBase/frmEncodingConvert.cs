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
    public partial class frmEncodingConvert : Form
    {
        public frmEncodingConvert()
        {
            InitializeComponent();
        }

        private void btnGb2312ToUtf8_Click(object sender, EventArgs e)
        {
            string strSource = txtSourceString.Text;
            string strTarget = clsString.GB2312TOUtf8(strSource);
            txtTargetString.Text = strTarget;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strSource = txtSourceString.Text;
          //  string strTarget = clsString.GB2312ToUtf8Bytes(strSource);
           
        }
    }
}
