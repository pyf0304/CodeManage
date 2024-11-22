using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using com.taishsoft.file;
using com.taishsoft.common;
using com.taishsoft.commdb4odbc;
using com.taishsoft.sql;
using com.taishsoft.commdb;
using com.taishsoft.datetime;

namespace TestPubDataBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFindFilePathByFileName_Click(object sender, EventArgs e)
        {
            string strFileName = "Image.cs";
            string strPathName = "E:\\AspNet2011\\Blog\\";
            string strResult = clsFile.FindFilePathByFileName(strFileName, strPathName);
            txtResult.Text = strResult;
        }

        private void btnGetRowColByDate_Click(object sender, EventArgs e)
        {
            string strDate = txtInput.Text;
            int intRowCol = clsDateTime.getRowColByDate(strDate);
            txtResult.Text = intRowCol.ToString();
        }

        private void btnGetFirstRowColDayOfMonth_Click(object sender, EventArgs e)
        {
            string strDate = txtInput.Text;

            string strResult = clsDateTime.GetFirstRowColDayOfMonth(strDate).ToLongDateString();
            txtResult.Text = strResult;
        }

        private void btnGetFirstDayOfWeek_Click(object sender, EventArgs e)
        {
            if (txtInput.Text != "")
            {
                string strDate = txtInput.Text;

                string strResult = clsDateTime.GetFirstDayOfWeek(strDate).ToLongDateString();
                txtResult.Text = strResult;
            }
            else
            {
                DateTime objDate = DateTime.Now;

                string strResult = clsDateTime.GetFirstDayOfWeek(objDate).ToLongDateString();
                txtResult.Text = strResult;
            }
        }

        private void btnGetWeekNoByDateObj_Click(object sender, EventArgs e)
        {
            if (txtInput.Text != "")
            {
                string strDate = txtInput.Text;

                int intWeekNo = clsDateTime.GetWeekNoByDateObj(strDate);
                txtResult.Text = intWeekNo.ToString();
            }
            else
            {
                DateTime objDate = DateTime.Now;

                int intWeekNo = clsDateTime.GetWeekNoByDateObj(objDate);
                txtResult.Text = intWeekNo.ToString();
            }
        }

        private void btnGetFirstDateByWeekNo_Click(object sender, EventArgs e)
        {
            if (txtInput.Text != "")
            {
                int intYear =int.Parse( txtInput.Text);
                int intWeekNo =int.Parse( txtInput2.Text);

                string strResult = clsDateTime.GetFirstDateByWeekNo(intYear,intWeekNo).ToLongDateString();
                txtResult.Text = strResult;
            }
            else
            {
                DateTime objDate = DateTime.Now;

                string strResult = clsDateTime.GetFirstDateByWeekNo(2012, 2).ToLongDateString();
                txtResult.Text = strResult;
            }
        }

        private void btnFileBackup_Click(object sender, EventArgs e)
        {
            string strFileName = @"E:\AspNet2011\GeneralPlatform07\GeneralPlatform_LogicEx\clsLogic\UserManage\clsUserGroupsEx.cs";
            string strPathName = @"E:\AspNet2011\GeneralPlatform07\GeneralPlatform_LogicEx\clsLogicBak\";
            bool strResult = clsFile.FileBackup(strFileName, strPathName);
            txtResult.Text = strResult.ToString();
        }

        private void btnCheckStrSQL_Weak_Click(object sender, EventArgs e)
        {
            string strCondition = txtInput.Text;
            string strExclude = txtInput2.Text;
            try
            {
                if (string.IsNullOrEmpty(strExclude) == false)
                {
                    strExclude = "[Exclude]" + strExclude + "[/Exclude]";
                }
                txtResult.Text = clsString.RemoveStringValueInSingleQuotation(strCondition);
                bool bolResult = clsCommonRegular.CheckStrSQL_Weak(strCondition + strExclude);
                if (bolResult == false)
                {
                    MessageBox.Show("检查无SQL注入！");
                }
                //txtResult.Text = strTargetStr;
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
            }
        }

        private void btnGetElementValue_Click(object sender, EventArgs e)
        {
            string strCondition = txtInput.Text;
            string strElementName = txtInput2.Text;
            try
            {
                string strTargetStr = clsString.GetElementValue(strCondition, strElementName);
                txtResult.Text = strTargetStr;
                if (string.IsNullOrEmpty(strTargetStr) == true)
                {
                    MessageBox.Show("没有发现元素值！");
                }
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
            }
        }

        private void btnRemoveElementValue_Click(object sender, EventArgs e)
        {
            string strCondition = txtInput.Text;
            string strElementName = txtInput2.Text;
            try
            {
                string strTargetStr = clsString.RemoveElementValue(strCondition, strElementName);
                txtResult.Text = strTargetStr;
                if (string.IsNullOrEmpty(strTargetStr) == true)
                {
                    MessageBox.Show("没有发现元素值！");
                }
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
            }
        }

        private void btngetFirstSheetName4Excel_Click(object sender, EventArgs e)
        {
            clsExcelSQL objSQL = new clsExcelSQL(@"E:\AA20121022\aaa.xls");
            string strSheetName1 = objSQL.GetExcelFirstTableName1();
            List<string> strSheetNameLst2 = objSQL.GetExcelTableNameLst2();
            //strSheetName1 = strSheetName1.TrimEnd('$');
            DataTable objDT = objSQL.funGetDataTable("select * from [" + strSheetName1 + "]");
            dataGridView1.DataSource = objDT;
           
            MessageBox.Show(strSheetName1 + strSheetNameLst2[1]);
        }

        private void btnGetFileLstByFolder_Click(object sender, EventArgs e)
        {

        }

        private void btnSplitWord_Click(object sender, EventArgs e)
        {
            string strSource = txtInput.Text;
            lbResult.Items.Clear();
            List<string> lstWord = clsString.SplitWord(strSource);
            foreach (string strWord in lstWord)
            {
                lbResult.Items.Add(strWord + "(" + strWord.Length.ToString() + ")");
            }
            string strCombineWord = clsString.CombineListToString(lstWord);
            txtResult.Text = strCombineWord;
        }

        private void btnCheckDate8_Click(object sender, EventArgs e)
        {
            string strDate = txtInput.Text;
            try
            {
                clsDateTime objDT = new clsDateTime(strDate);
                string strLeaveDay_EN = string.Format("{0} {1}", objDT.Month_EN, objDT.Year);
       
                clsDateTime.CheckDate8(strDate);
                MessageBox.Show("检查正确！");

            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
            }
        }

        private void btnCheckYearMonth6_Click(object sender, EventArgs e)
        {
            string strDate = txtInput.Text;
            try
            {
                clsDateTime.CheckYearMonth6(strDate);
                MessageBox.Show("检查正确！");

            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
            }
        }

        private void btnGetViewText_Click(object sender, EventArgs e)
        {
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();

            try
            {
                string strViewText = clsSqlTabViewEx.GetViewText("vAppraiseType", objSQL.ConnectionString, "dbo");
                MessageBox.Show(strViewText);
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
            }
        }

        private void btnSplitSubString_Click(object sender, EventArgs e)
        {
            string strSource = txtInput.Text;
            lbResult.Items.Clear();
            List<string> lstFlag = new List<string>();
            lstFlag.Add("LEFT OUTER JOIN");
            lstFlag.Add("RIGHT OUTER JOIN");

            List<string> lstWord = clsString.SplitStringBySplitFlagLst(strSource, lstFlag);
            foreach (string strWord in lstWord)
            {
                lbResult.Items.Add(strWord + "(" + strWord.Length.ToString() + ")");
            }
        }

        private void btnAnalysisSqlStatement_Click(object sender, EventArgs e)
        {
            string strSource = txtInput.Text;
            lbResult.Items.Clear();
            SqlStatement objSqlStatementEN = SqlStatementAC.AnalysisSqlStatement(strSource);
            string strResult = SqlStatementAC.GetSqlStatementAnalysisInfo(objSqlStatementEN, -1);
            MessageBox.Show(strResult);
            //List<string> lstWord = clsString.SplitStringBySplitFlagLst(strSource, lstFlag);
            //foreach (string strWord in lstWord)
            //{
            //    lbResult.Items.Add(strWord + "(" + strWord.Length.ToString() + ")");
            //}
        }

        private void btnCheckStrSQL_Click(object sender, EventArgs e)
        {
            string strCondition = txtInput.Text;
            string strExclude = txtInput2.Text;
            try
            {
                if (string.IsNullOrEmpty(strExclude) == false)
                {
                    strExclude = "[Exclude]" + strExclude + "[/Exclude]";
                }
                txtResult.Text = clsString.RemoveStringValueInSingleQuotation(strCondition);
                bool bolResult = clsCommonRegular.CheckStrSQL(strCondition + strExclude);
                if (bolResult == false)
                {
                    MessageBox.Show("检查无SQL注入！");
                }
                //txtResult.Text = strTargetStr;
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
            }
        }

        private void btnGetUniqueFileName_S_Click(object sender, EventArgs e)
        {

            string strSource = txtInput.Text;
           
            string strResult = clsString.GetUniqueFileName_S(strSource);
            MessageBox.Show(strResult);
        }
    }
}
