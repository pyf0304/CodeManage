using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Text;
using System.Data;
using com.taishsoft.commdb4odbc;
using com.taishsoft.common;
using CommFunc4WebForm;
using System.Data.Odbc;

namespace TestExcel4O2007
{
    public partial class TestExcelExportByOdbc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnExcelExportByOdbc_Click(object sender, EventArgs e)
        {
            clsExcelSQL objSQL = new clsExcelSQL(@"D:\pyf\test3.xls");
            string strSheetName1 = objSQL.GetExcelFirstTableName1();
            List<string> strSheetNameLst2 = objSQL.GetExcelTableNameLst2();
            //strSheetName1 = strSheetName1.TrimEnd('$');
            DataTable objDT = objSQL.funGetDataTable("select * from [" + strSheetName1 + "]");
            GridView1.DataSource = objDT;
            GridView1.DataBind();
            Export(objDT, @"D:\pyf\test31.xls", strSheetNameLst2[1]);
        }
        protected void btnExcelExportByOdbc2007_Click(object sender, EventArgs e)
        {
            clsExcel2007SQL objSQL = null;
            try
            {
                objSQL = new clsExcel2007SQL(@"D:\pyf\test3.xlsx");
            }
            catch(Exception objException)
            {
                string strMsg = string.Format("打开Excel出错。错误:{0}({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            string strSheetName1 = objSQL.GetExcelFirstTableName();
            List<string> strSheetNameLst2 = objSQL.GetExcelTableNameLst();
            //strSheetName1 = strSheetName1.TrimEnd('$');
            DataTable objDT = objSQL.funGetDataTable("select * from [" + strSheetName1 + "]");
            GridView1.DataSource = objDT;
            GridView1.DataBind();
            try
            {
                Export2007(objDT, @"D:\pyf\test31_2007.xlsx", strSheetNameLst2[1]);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("导出Excel出错。错误:{0}({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
        }
        public  void Export(DataTable dt, string filepath, string tablename)
        {
            //excel 2003格式
            string connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filepath + ";Extended Properties=Excel 8.0;";
            //Excel 2007格式
            //string connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filepath + ";Extended Properties=Excel 12.0 Xml;";
            try
            {
                using (OleDbConnection con = new OleDbConnection(connString))
                {
                    con.Open();
                    StringBuilder strSQL = new StringBuilder();
                    strSQL.Append("CREATE TABLE ").Append("[" + tablename + "]");
                    strSQL.Append("(");
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        strSQL.Append("[" + dt.Columns[i].ColumnName + "] text,");
                    }
                    strSQL = strSQL.Remove(strSQL.Length - 1, 1);
                    strSQL.Append(")");

                    OleDbCommand cmd = new OleDbCommand(strSQL.ToString(), con);
                    cmd.ExecuteNonQuery();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        strSQL = new StringBuilder();
                        StringBuilder strfield = new StringBuilder();
                        StringBuilder strvalue = new StringBuilder();
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            strfield.Append("[" + dt.Columns[j].ColumnName + "]");
                            strvalue.Append("'" + dt.Rows[i][j].ToString() + "'");
                            if (j != dt.Columns.Count - 1)
                            {
                                strfield.Append(",");
                                strvalue.Append(",");
                            }
                            else
                            {
                            }
                        }
                        cmd.CommandText = strSQL.Append(" insert into [" + tablename + "]( ")
                        .Append(strfield.ToString())
                        .Append(") values (").Append(strvalue).Append(")").ToString();
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                }
                Console.WriteLine("OK");
                lblMsg.Text = "OK";
            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.Message;
                Console.WriteLine(ex.Message);
            }
        }
        public void Export2007(DataTable dt, string filepath, string tablename)
        {
            //excel 2003格式
            //string connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filepath + ";Extended Properties=Excel 8.0;";
            //Excel 2007格式
            string connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filepath + ";Extended Properties=Excel 12.0 Xml;";
            try
            {
                using (OleDbConnection con = new OleDbConnection(connString))
                {
                    con.Open();
                    StringBuilder strSQL = new StringBuilder();
                    strSQL.Append("CREATE TABLE ").Append("[" + tablename + "]");
                    strSQL.Append("(");
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        strSQL.Append("[" + dt.Columns[i].ColumnName + "] text,");
                    }
                    strSQL = strSQL.Remove(strSQL.Length - 1, 1);
                    strSQL.Append(")");

                    OleDbCommand cmd = new OleDbCommand(strSQL.ToString(), con);
                    cmd.ExecuteNonQuery();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        strSQL = new StringBuilder();
                        StringBuilder strfield = new StringBuilder();
                        StringBuilder strvalue = new StringBuilder();
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            strfield.Append("[" + dt.Columns[j].ColumnName + "]");
                            strvalue.Append("'" + dt.Rows[i][j].ToString() + "'");
                            if (j != dt.Columns.Count - 1)
                            {
                                strfield.Append(",");
                                strvalue.Append(",");
                            }
                            else
                            {
                            }
                        }
                        cmd.CommandText = strSQL.Append(" insert into [" + tablename + "]( ")
                        .Append(strfield.ToString())
                        .Append(") values (").Append(strvalue).Append(")").ToString();
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                }
                Console.WriteLine("OK");
                lblMsg.Text = "OK";
            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.Message;
                Console.WriteLine(ex.Message);
            }
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

            string      mstrExcelFileName = strExcelFileName;
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

        protected void btnTestOpenExcel2007ByOdbc_Click(object sender, EventArgs e)
        {
            try
            {
                bool bol = clsExcel2007SQL2(@"D:\pyf\test3.xlsx");
                string strMsg = string.Format("打开Excel成功。({0})", clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("打开Excel出错。错误:{0}({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
        }

        protected void btnTestOpenExcel2003ByOdbc0_Click(object sender, EventArgs e)
        {
            try
            {
                bool bol = clsExcel2003SQL_Odbc(@"D:\pyf\test3.xlsx");
                string strMsg = string.Format("打开Excel成功。({0})", clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("打开Excel出错。错误:{0}({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
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
            string mstrConnectString = "Driver={Microsoft Excel Driver (*.xls, *.xlsx, *.xlsm, *.xlsb)};DBQ=" +strExcelFileName;// path to xls/xlsx/xlsm/xlsb file
         string   mstrExcelFileName = strExcelFileName;
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
    }
}