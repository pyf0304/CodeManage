using com.taishsoft.common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestExcelWin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTestOpenExcel2007ByOdbc_Click(object sender, EventArgs e)
        {
            try
            {
                bool bol = clsExcel2007SQL2(@"D:\pyf\test3.xlsx");
                string strMsg = string.Format("打开Excel(test3.xlsx)成功。({0})", clsStackTrace.GetCurrClassFunction());
                MessageBox.Show(strMsg);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("打开Excel出错。错误:{0}({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                MessageBox.Show(strMsg);
                return;
            }
        }

        private void btnTestOpenExcel2003ByOdbc_Click(object sender, EventArgs e)
        {
            try
            {
                bool bol = clsExcel2003SQL_Odbc(@"D:\pyf\test3.xls");
                string strMsg = string.Format("打开Excel(test3.xls)成功。({0})", clsStackTrace.GetCurrClassFunction());
                MessageBox.Show(strMsg);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("打开Excel出错。错误:{0}({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                MessageBox.Show(strMsg);
                return;
            }
        }

        public bool clsExcel2003SQL_Odbc(string strExcelFileName)
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
            OdbcConnection m_oConn = null;
            //string  mstrConnectString = "Driver={Microsoft Excel Driver (*.xls)};DBQ=" + strExcelFileName;
            string mstrConnectString = "Driver={Microsoft Excel Driver (*.xls, *.xlsx, *.xlsm, *.xlsb)};DBQ=" + strExcelFileName;// path to xls/xlsx/xlsm/xlsb file
            string mstrExcelFileName = strExcelFileName;
            try
            {
                m_oConn = new OdbcConnection(mstrConnectString);
                m_oConn.Open();
            }
            catch (Exception objException)
            {
                throw objException;
            }
            finally
            {
                m_oConn.Close();
                m_oConn = null;
            }
            return true;
        }
        /// <summary>
        /// 构造函数，检查文件是否存在，同时检查连接是否成功？
        /// </summary>
        /// <param name="strExcelFileName"></param>
        public bool clsExcel2007SQL2(string strExcelFileName)
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
            OleDbConnection m_oConn = null;
            //string mstrConnectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
            //                         + strExcelFileName + ";Extended Properties=Excel 12.0 Xml;";
            string mstrConnectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
                                     + strExcelFileName + ";Extended Properties='Excel 12.0;HDR=Yes;IMEX=1;'";

            string mstrExcelFileName = strExcelFileName;
            try
            {
                m_oConn = new OleDbConnection(mstrConnectString);
                m_oConn.Open();
            }
            catch (Exception objException)
            {
                throw objException;
            }
            finally
            {
                m_oConn.Close();
                m_oConn = null;
            }
            return true;
        }
    }
}
