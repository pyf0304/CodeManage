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
    public partial class frmTestAccess : Form
    {
        public frmTestAccess()
        {
            InitializeComponent();
        }

        private void btnTestConn4Access2003_Click(object sender, EventArgs e)
        {
            string strFileName = @"E:\TestFile4Prog\Access2003Sam01.mdb";
            //string strFileName2007 = @"E:\TestFile4Prog\Access2007Sam01.accdb";
            try
            {
                clsAccess2003SQL_OleDb objAccess2003SQL = new clsAccess2003SQL_OleDb(strFileName);
                MessageBox.Show("打开Access2003连接成功！");
            }
            catch(Exception objException)
            {
                MessageBox.Show(objException.Message);
            }
        }

        private void btnTestConn4Access2007_Click(object sender, EventArgs e)
        {
            //string strFileName = @"E:\TestFile4Prog\Access2003Sam01.mdb";
            string strFileName2007 = @"E:\TestFile4Prog\Access2007Sam01.accdb";
            try
            {
                clsAccess2007SQL objAccess2007SQL = new clsAccess2007SQL(strFileName2007);
                MessageBox.Show("打开Access2007连接成功！");
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
            }
        }

        private void btnGetSheetNamesAccess2003_Click(object sender, EventArgs e)
        {
            string strFileName = @"E:\TestFile4Prog\Access2003Sam01.mdb";
            //string strFileName2007 = @"E:\TestFile4Prog\Access2007Sam01.accdb";
            try
            {
                clsAccess2003SQL_OleDb objAccess2003SQL = new clsAccess2003SQL_OleDb(strFileName);
                List<string> arrTableNameLst = objAccess2003SQL.GetAccessTableNameLst();
                foreach(string strName in arrTableNameLst)
                {
                    comboBox1.Items.Add(strName);
                }
                comboBox1.SelectedIndex = 0;
                    MessageBox.Show("获取Access2003表单名称成功！");
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
            }
        }

        private void btnGetSheetNamesAccess2007_Click(object sender, EventArgs e)
        {
            //string strFileName = @"E:\TestFile4Prog\Access2003Sam01.mdb";
            string strFileName2007 = @"E:\TestFile4Prog\Access2007Sam01.accdb";
            try
            {
                clsAccess2007SQL objAccess2007SQL = new clsAccess2007SQL(strFileName2007);
                List<string> arrTableNameLst = objAccess2007SQL.GetAccessTableNameLst();
                foreach (string strName in arrTableNameLst)
                {
                    comboBox1.Items.Add(strName);
                }
                comboBox1.SelectedIndex = 0;
                MessageBox.Show("获取Access2007表单名称成功！");
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
            }
        }

        private void btnGetSheetContentAccess2003_Click(object sender, EventArgs e)
        {
            string strFileName = @"E:\TestFile4Prog\Access2003Sam01.mdb";
            //string strFileName2007 = @"E:\TestFile4Prog\Access2007Sam01.accdb";
            try
            {
                clsAccess2003SQL_OleDb objAccess2003SQL = new clsAccess2003SQL_OleDb(strFileName);
                string strSheetName = comboBox1.SelectedItem.ToString();
                if (string .IsNullOrEmpty(strSheetName) == true) 
                {
                 MessageBox.Show("请选择一个表单名称！");
                    return;
                }
                string strSQL = string.Format("select * from [{0}] ", strSheetName);
               DataTable objDT  = objAccess2003SQL.funGetDataTable(strSQL);
               dataGridView1.DataSource = objDT;
               
                MessageBox.Show("获取Access2003表单内容成功！");
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
            }
        }

        private void btnGetSheetContentAccess2007_Click(object sender, EventArgs e)
        {
            //string strFileName = @"E:\TestFile4Prog\Access2003Sam01.mdb";
            string strFileName2007 = @"E:\TestFile4Prog\Access2007Sam01.accdb";
            try
            {
                clsAccess2007SQL objAccess2007SQL = new clsAccess2007SQL(strFileName2007);
                string strSheetName = comboBox1.SelectedItem.ToString();
                if (string.IsNullOrEmpty(strSheetName) == true)
                {
                    MessageBox.Show("请选择一个表单名称！");
                    return;
                }
                string strSQL = string.Format("select * from [{0}] ", strSheetName);
                DataTable objDT = objAccess2007SQL.funGetDataTable(strSQL);
                dataGridView1.DataSource = objDT;

                MessageBox.Show("获取Access2007表单内容成功！");
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
            }
        }

        private void btnTestConn4Access_Click(object sender, EventArgs e)
        {
            string strFileName = @"E:\TestFile4Prog\Access2003Sam01.mdb";
            string strFileName2007 = @"E:\TestFile4Prog\Access2007Sam01.accdb";
            strFileName = cboAccessFileName.SelectedItem.ToString();
            try
            {
                clsAccessAllVersionSQL objAccessAllVersionSQL = new clsAccessAllVersionSQL(strFileName);
              
                MessageBox.Show("打开Access连接成功！");
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
            }
        }

        private void btnGetSheetNamesAccess_Click(object sender, EventArgs e)
        {
            string strFileName = @"E:\TestFile4Prog\Access2003Sam01.mdb";
            string strFileName2007 = @"E:\TestFile4Prog\Access2007Sam01.accdb";
            strFileName = cboAccessFileName.SelectedItem.ToString();
            try
            {
                clsAccessAllVersionSQL objAccess2003SQL = new clsAccessAllVersionSQL(strFileName);
                List<string> arrTableNameLst = objAccess2003SQL.GetAccessTableNameLst();
                comboBox1.Items.Clear();
                foreach (string strName in arrTableNameLst)
                {
                    comboBox1.Items.Add( strName);
                }

               
                comboBox1.SelectedIndex = 0;
                MessageBox.Show("获取两个Access表单名称成功！");
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
            }
        }

        private void frmTestAccess_Load(object sender, EventArgs e)
        {
            string strFileName = @"E:\TestFile4Prog\Access2003Sam01.mdb";
            string strFileName2007 = @"E:\TestFile4Prog\Access2007Sam01.accdb";
            cboAccessFileName.Items.Add(strFileName);
            cboAccessFileName.Items.Add(strFileName2007);

        }

        private void btnGetSheetContentAccess_Click(object sender, EventArgs e)
        {
            string strFileName = @"E:\TestFile4Prog\Access2003Sam01.mdb";
            string strFileName2007 = @"E:\TestFile4Prog\Access2007Sam01.accdb";
            strFileName = cboAccessFileName.SelectedItem.ToString();
            try
            {
                clsAccessAllVersionSQL objAccess2007SQL = new clsAccessAllVersionSQL(strFileName);
                string strSheetName = comboBox1.SelectedItem.ToString();
                if (string.IsNullOrEmpty(strSheetName) == true)
                {
                    MessageBox.Show("请选择一个表单名称！");
                    return;
                }
                string strSQL = string.Format("select * from [{0}] ", strSheetName);
                DataTable objDT = objAccess2007SQL.funGetDataTable(strSQL);
                dataGridView1.DataSource = objDT;

                MessageBox.Show("获取Access表单内容成功！使用版本：" + objAccess2007SQL.AccessVersion);
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
            }
        }

        private void btnGetSheetRecCount_Click(object sender, EventArgs e)
        {
            string strFileName = @"E:\TestFile4Prog\Access2003Sam01.mdb";
            string strFileName2007 = @"E:\TestFile4Prog\Access2007Sam01.accdb";
            strFileName = cboAccessFileName.SelectedItem.ToString();
            try
            {
                clsAccessAllVersionSQL objAccess2007SQL = new clsAccessAllVersionSQL(strFileName);
                string strSheetName = comboBox1.SelectedItem.ToString();
                if (string.IsNullOrEmpty(strSheetName) == true)
                {
                    MessageBox.Show("请选择一个表单名称！");
                    return;
                }
                string strSQL = string.Format("select * from [{0}] ", strSheetName);
                int intRecCount = objAccess2007SQL.funGetRecCount(strSheetName);

                string strMsg = string.Format("Access表单记录数：{0}！使用版本：{1}", intRecCount, objAccess2007SQL.AccessVersion);
                MessageBox.Show(strMsg);
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
            }
        }

        private void btnGetSheetContentAccess2_Click(object sender, EventArgs e)
        {
            string strFileName = @"E:\TestFile4Prog\Access2003Sam01.mdb";
            string strFileName2007 = @"E:\TestFile4Prog\Access2007Sam01.accdb";
            strFileName = cboAccessFileName.SelectedItem.ToString();
            try
            {
                clsAccessAllVersionSQL objAccess2007SQL = new clsAccessAllVersionSQL(strFileName);
                string strSheetName = comboBox1.SelectedItem.ToString();
                if (string.IsNullOrEmpty(strSheetName) == true)
                {
                    MessageBox.Show("请选择一个表单名称！");
                    return;
                }
                string strSQL = string.Format("select * from [{0}] ", strSheetName);
                DataTable objDT = objAccess2007SQL.GetDataTable(strSQL);
                dataGridView1.DataSource = objDT;

                MessageBox.Show("获取Access表单内容成功！使用版本：" + objAccess2007SQL.AccessVersion);
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
            }
        }
    }
}
