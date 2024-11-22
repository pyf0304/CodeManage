using com.taishsoft.common;
using com.taishsoft.lexicalAnalysis;
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
    public partial class frmTestSqlIn : Form
    {
        public frmTestSqlIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strSource = txtSourceStr.Text;
            try
            {
                List<clsWord_LA> arrWord = clsLexicalAnalysis4Sql.getWordLst(strSource);
                listBox1.Items.Clear();
                foreach (clsWord_LA objWord_LA in arrWord)
                {
                    listBox1.Items.Add(objWord_LA.Word);
                }
                bool strResult = clsCheckSql.CheckStrSQL_Weak(strSource);
                txtTargetStr.Text = strResult.ToString();
            }
            catch(Exception objException)
            {
                
                MessageBox.Show(objException.Message);
            }
        }
    }
}
