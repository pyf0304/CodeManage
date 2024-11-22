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
    public partial class frmTestSqlStatement : Form
    {
        public frmTestSqlStatement()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string strSource = txtSourceStr.Text;
                string strTarget = SqlStatementAC.DelSingleQuoteContent(strSource);
                txtTargetStr.Text = strTarget;
            }
            catch(Exception objException)
            {
                MessageBox.Show(objException.Message);
            }
        }
    }
}
