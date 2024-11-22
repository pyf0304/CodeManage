using com.taishsoft.commdb4odbc;
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
    public partial class frmTestExcel : Form
    {
        public frmTestExcel()
        {
            InitializeComponent();
        }

        private void btnTestConn4Excel2003_Click(object sender, EventArgs e)
        {
            string strFileName = @"E:\TestFile4Prog\Excel2003Sam01.xls";
            //string strFileName2007 = @"E:\TestFile4Prog\Excel2007Sam01.xlsx";
            try
            {
                clsExcel2003SQL_OleDb objExcel2003SQL = new clsExcel2003SQL_OleDb(strFileName);
                MessageBox.Show("打开Excel2003连接成功！");
            }
            catch(Exception objException)
            {
                MessageBox.Show(objException.Message);
            }
        }

        private void btnTestConn4Excel2007_Click(object sender, EventArgs e)
        {
            //string strFileName = @"E:\TestFile4Prog\Excel2003Sam01.xls";
            string strFileName2007 = @"E:\TestFile4Prog\Excel2007Sam01.xlsx";
            try
            {
                clsExcel2007SQL objExcel2007SQL = new clsExcel2007SQL(strFileName2007);
                MessageBox.Show("打开Excel2007连接成功！");
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
            }
        }

        private void btnGetSheetNamesExcel2003_Click(object sender, EventArgs e)
        {
            string strFileName = @"E:\TestFile4Prog\Excel2003Sam01.xls";
            //string strFileName2007 = @"E:\TestFile4Prog\Excel2007Sam01.xlsx";
            try
            {
                clsExcel2003SQL_OleDb objExcel2003SQL = new clsExcel2003SQL_OleDb(strFileName);
                List<string> arrTableNameLst = objExcel2003SQL.GetExcelTableNameLst();
                foreach(string strName in arrTableNameLst)
                {
                    comboBox1.Items.Add(strName);
                }
                comboBox1.SelectedIndex = 0;
                    MessageBox.Show("获取Excel2003表单名称成功！");
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
            }
        }

        private void btnGetSheetNamesExcel2007_Click(object sender, EventArgs e)
        {
            //string strFileName = @"E:\TestFile4Prog\Excel2003Sam01.xls";
            string strFileName2007 = @"E:\TestFile4Prog\Excel2007Sam01.xlsx";
            try
            {
                clsExcel2007SQL objExcel2007SQL = new clsExcel2007SQL(strFileName2007);
                List<string> arrTableNameLst = objExcel2007SQL.GetExcelTableNameLst();
                foreach (string strName in arrTableNameLst)
                {
                    comboBox1.Items.Add(strName);
                }
                comboBox1.SelectedIndex = 0;
                MessageBox.Show("获取Excel2007表单名称成功！");
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
            }
        }

        private void btnGetSheetContentExcel2003_Click(object sender, EventArgs e)
        {
            string strFileName = @"E:\TestFile4Prog\Excel2003Sam01.xls";
            //string strFileName2007 = @"E:\TestFile4Prog\Excel2007Sam01.xlsx";
            try
            {
                clsExcel2003SQL_OleDb objExcel2003SQL = new clsExcel2003SQL_OleDb(strFileName);
                string strSheetName = comboBox1.SelectedItem.ToString();
                if (string .IsNullOrEmpty(strSheetName) == true) 
                {
                 MessageBox.Show("请选择一个表单名称！");
                    return;
                }
                string strSQL = string.Format("select * from [{0}] ", strSheetName);
               DataTable objDT  = objExcel2003SQL.funGetDataTable(strSQL);
               dataGridView1.DataSource = objDT;
               
                MessageBox.Show("获取Excel2003表单内容成功！");
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
            }
        }

        private void btnGetSheetContentExcel2007_Click(object sender, EventArgs e)
        {
            //string strFileName = @"E:\TestFile4Prog\Excel2003Sam01.xls";
            string strFileName2007 = @"E:\TestFile4Prog\Excel2007Sam01.xlsx";
            try
            {
                clsExcel2007SQL objExcel2007SQL = new clsExcel2007SQL(strFileName2007);
                string strSheetName = comboBox1.SelectedItem.ToString();
                if (string.IsNullOrEmpty(strSheetName) == true)
                {
                    MessageBox.Show("请选择一个表单名称！");
                    return;
                }
                string strSQL = string.Format("select * from [{0}] ", strSheetName);
                DataTable objDT = objExcel2007SQL.funGetDataTable(strSQL);
                dataGridView1.DataSource = objDT;

                MessageBox.Show("获取Excel2007表单内容成功！");
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
            }
        }

        private void btnTestConn4Excel_Click(object sender, EventArgs e)
        {
            string strFileName = @"E:\TestFile4Prog\Excel2003Sam01.xls";
            string strFileName2007 = @"E:\TestFile4Prog\Excel2007Sam01.xlsx";
            strFileName = cboExcelFileName.SelectedItem.ToString();
            try
            {
                clsExcelAllVersionSQL objExcelAllVersionSQL = new clsExcelAllVersionSQL(strFileName);
              
                MessageBox.Show("打开Excel连接成功！");
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
            }
        }

        private void btnGetSheetNamesExcel_Click(object sender, EventArgs e)
        {
            string strFileName = @"E:\TestFile4Prog\Excel2003Sam01.xls";
            string strFileName2007 = @"E:\TestFile4Prog\Excel2007Sam01.xlsx";
            strFileName = cboExcelFileName.SelectedItem.ToString();
            try
            {
                clsExcelAllVersionSQL objExcel2003SQL = new clsExcelAllVersionSQL(strFileName);
                List<string> arrTableNameLst = objExcel2003SQL.GetExcelTableNameLst();
                comboBox1.Items.Clear();
                foreach (string strName in arrTableNameLst)
                {
                    comboBox1.Items.Add( strName);
                }

               
                comboBox1.SelectedIndex = 0;
                MessageBox.Show("获取两个Excel表单名称成功！");
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
            }
        }

        private void frmTestExcel_Load(object sender, EventArgs e)
        {
            string strFileName = @"E:\TestFile4Prog\Excel2003Sam01.xls";
            string strFileName2007 = @"E:\TestFile4Prog\Excel2007Sam01.xlsx";
            cboExcelFileName.Items.Add(strFileName);
            cboExcelFileName.Items.Add(strFileName2007);

        }

        private void btnGetSheetContentExcel_Click(object sender, EventArgs e)
        {
            string strFileName = @"E:\TestFile4Prog\Excel2003Sam01.xls";
            string strFileName2007 = @"E:\TestFile4Prog\Excel2007Sam01.xlsx";
            strFileName = cboExcelFileName.SelectedItem.ToString();
            try
            {
                clsExcelAllVersionSQL objExcel2007SQL = new clsExcelAllVersionSQL(strFileName);
                string strSheetName = comboBox1.SelectedItem.ToString();
                if (string.IsNullOrEmpty(strSheetName) == true)
                {
                    MessageBox.Show("请选择一个表单名称！");
                    return;
                }
                string strSQL = string.Format("select * from [{0}] ", strSheetName);
                DataTable objDT = objExcel2007SQL.funGetDataTable(strSQL);
                dataGridView1.DataSource = objDT;

                MessageBox.Show("获取Excel表单内容成功！使用版本：" + objExcel2007SQL.ExcelVersion);
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
            }
        }

        private void btnGetSheetRecCount_Click(object sender, EventArgs e)
        {
            string strFileName = @"E:\TestFile4Prog\Excel2003Sam01.xls";
            string strFileName2007 = @"E:\TestFile4Prog\Excel2007Sam01.xlsx";
            strFileName = cboExcelFileName.SelectedItem.ToString();
            try
            {
                clsExcelAllVersionSQL objExcel2007SQL = new clsExcelAllVersionSQL(strFileName);
                string strSheetName = comboBox1.SelectedItem.ToString();
                if (string.IsNullOrEmpty(strSheetName) == true)
                {
                    MessageBox.Show("请选择一个表单名称！");
                    return;
                }
                string strSQL = string.Format("select * from [{0}] ", strSheetName);
                int intRecCount = objExcel2007SQL.funGetRecCount(strSheetName);

                string strMsg = string.Format("Excel表单记录数：{0}！使用版本：{1}", intRecCount, objExcel2007SQL.ExcelVersion);
                MessageBox.Show(strMsg);
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
            }
        }

        private void btnGetSheetContentExcel2_Click(object sender, EventArgs e)
        {
            string strFileName = @"E:\TestFile4Prog\Excel2003Sam01.xls";
            string strFileName2007 = @"E:\TestFile4Prog\Excel2007Sam01.xlsx";
            strFileName = cboExcelFileName.SelectedItem.ToString();
            try
            {
                clsExcelAllVersionSQL objExcel2007SQL = new clsExcelAllVersionSQL(strFileName);
                string strSheetName = comboBox1.SelectedItem.ToString();
                if (string.IsNullOrEmpty(strSheetName) == true)
                {
                    MessageBox.Show("请选择一个表单名称！");
                    return;
                }
                string strSQL = string.Format("select * from [{0}] ", strSheetName);
                DataTable objDT = objExcel2007SQL.GetDataTable(strSQL);
                dataGridView1.DataSource = objDT;

                MessageBox.Show("获取Excel表单内容成功！使用版本：" + objExcel2007SQL.ExcelVersion);
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
            }
        }
    }
}
