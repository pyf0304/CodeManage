using System;
using System.Data;
using System.Data.Odbc;
using System.IO;
using System.Data.OleDb;
using System.Collections.Generic;

namespace com.taishsoft.commdb4odbc
{
    /// <summary>
    /// clsExcelSQL 的摘要说明。
    /// </summary>
    public class clsExcelSQL
    {
        /// <summary>
        /// 
        /// </summary>
        protected string mstrConnectString;
        private System.Data.Odbc.OdbcConnection m_oConn;

        private string mstrExcelFileName = "";
        public clsExcelSQL(string strExcelFileName)
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
            if (File.Exists(strExcelFileName) == false)
            {
                string strMsg = string.Format("Excel文件不存在！请检查。文件名：{0}.", strExcelFileName);
                throw new Exception(strMsg);
            }
           mstrConnectString = "Driver={Microsoft Excel Driver (*.xls)};DBQ=" + strExcelFileName;
       //mstrConnectString = "Driver={Microsoft Excel Driver (*.xls, *.xlsx, *.xlsm, *.xlsb)};DBQ=" +strExcelFileName;// path to xls/xlsx/xlsm/xlsb file
            mstrExcelFileName = strExcelFileName;

        }
        public DataTable funGetDataTable(string strSql)
        {
            DataTable objDT;

            //执行Stored Procedure
            try
            {
                OdbcCommand odbcCmd;
                OdbcDataAdapter sqlAdp;
                m_oConn = new OdbcConnection(mstrConnectString);
                m_oConn.Open();

                odbcCmd = new OdbcCommand();
                odbcCmd.CommandType = CommandType.Text;
                odbcCmd.Connection = m_oConn;
                odbcCmd.CommandText = strSql;

                objDT = new DataTable();
                sqlAdp = new OdbcDataAdapter();
                sqlAdp.SelectCommand = odbcCmd;
                sqlAdp.Fill(objDT);
                return objDT;
            }

            catch (Exception e)
            {
                throw (e);
            }

            finally
            {
                m_oConn.Close();
            }
        }
        public DataTable funGetDataTable(string strSheetName, string strWhereCond)
        {
            DataTable objDT = null;
            string strSQL = "";
            if (string.IsNullOrEmpty(strWhereCond) == true)
            {
                strSQL = "select * from " + strSheetName;
            }
            else
            {
                strSQL = "select * from " + strSheetName + " where " + strWhereCond;
            }
            //执行Stored Procedure
            try
            {
                OdbcCommand odbcCmd;
                OdbcDataAdapter sqlAdp;
                m_oConn = new OdbcConnection(mstrConnectString);
                m_oConn.Open();

                odbcCmd = new OdbcCommand();
                odbcCmd.CommandType = CommandType.Text;
                odbcCmd.Connection = m_oConn;
                odbcCmd.CommandText = strSQL;

                objDT = new DataTable();
                sqlAdp = new OdbcDataAdapter();
                sqlAdp.SelectCommand = odbcCmd;
                sqlAdp.Fill(objDT);
                return objDT;
            }

            catch (Exception e)
            {
                throw (e);
            }

            finally
            {
                m_oConn.Close();
            }
        }



        /// <summary>
        /// C#中获取Excel文件的第一个表名 
        /// Excel文件中第一个表名的缺省值是Sheet1$, 但有时也会被改变为其他名字. 如果需要在C#中使用OleDb读写Excel文件, 就需要知道这个名字是什么. 以下代码就是实现这个功能的:
        /// </summary>
        /// <param name="excelFileName"></param>
        /// <returns></returns>
        public string GetExcelFirstTableName2()
        {
            string tableName = null;
            if (File.Exists(mstrExcelFileName))
            {
                using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet." +
                  "OLEDB.4.0;Extended Properties=\"Excel 8.0\";Data Source=" + mstrExcelFileName))
                {
                    conn.Open();
                    DataTable dt = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    tableName = dt.Rows[0][2].ToString().Trim();
                }
            }
            return tableName;
        }

        public string GetExcelFirstTableName1()
        {
            string tableName = null;
            if (File.Exists(mstrExcelFileName))
            {
                m_oConn = new OdbcConnection(mstrConnectString);
                m_oConn.Open();
                DataTable dt = m_oConn.GetSchema("Tables");
                tableName = dt.Rows[0][2].ToString().Trim();

            }
            return tableName;
        }

        public List<string> GetExcelTableNameLst1()
        {
            List<string> arrtableName = new List<string>();
            string tableName = null;
            if (File.Exists(mstrExcelFileName))
            {
                m_oConn = new OdbcConnection(mstrConnectString);
                m_oConn.Open();
                DataTable dt = m_oConn.GetSchema("Tables");
                foreach (DataRow objDR in dt.Rows)
                {
                    tableName = objDR[2].ToString().Trim();
                    arrtableName.Add(tableName);
                }
            }
            return arrtableName;
        }
        /// <summary>
        /// C#中获取Excel文件的第一个表名 
        /// Excel文件中第一个表名的缺省值是Sheet1$, 但有时也会被改变为其他名字. 如果需要在C#中使用OleDb读写Excel文件, 就需要知道这个名字是什么. 以下代码就是实现这个功能的:
        /// </summary>
        /// <returns></returns>
        public List<string> GetExcelTableNameLst2()
        {
            List<string> arrtableName = new List<string>();
            string tableName = null;
            if (File.Exists(mstrExcelFileName))
            {
                using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet." +
                  "OLEDB.4.0;Extended Properties=\"Excel 8.0\";Data Source=" + mstrExcelFileName))
                {
                    conn.Open();
                    DataTable dt = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    foreach (DataRow objDR in dt.Rows)
                    {
                        tableName = objDR[2].ToString().Trim();
                        arrtableName.Add(tableName);
                    }
                }
            }
            return arrtableName;
        }
        /// <summary>
        /// C#中获取Excel文件的第一个表名 
        /// Excel文件中第一个表名的缺省值是Sheet1$, 但有时也会被改变为其他名字. 如果需要在C#中使用OleDb读写Excel文件, 就需要知道这个名字是什么. 以下代码就是实现这个功能的:
        /// </summary>
        /// <param name="excelFileName"></param>
        /// <returns></returns>
        public static string GetExcelFirstTableName1Bak(string excelFileName)
        {
            string tableName = null;
            if (File.Exists(excelFileName))
            {
                using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet." +
                  "OLEDB.4.0;Extended Properties=\"Excel 8.0\";Data Source=" + excelFileName))
                {
                    conn.Open();
                    DataTable dt = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    tableName = dt.Rows[0][2].ToString().Trim();
                }
            }
            return tableName;
        }

        //    2.以数据库方式打开并输入数据
        //      此方式将xls文件所在目录看作数据库，其中的xls文件看作数据库表，表名即文件名（不加扩展名）。
        //      函数importExcelToDataSet(string FilePath,string sheet)功能：从xls中读出数据到DataSet中，并返回DataSet对象。


        private DataSet importExcelToDataSet(string FilePath/*即文件目录的路径*/, string sheet/*表名即文件名（不加扩展名）*/)
        {

            if (File.Exists(FilePath) == false)
            {
                string strMsg = string.Format("Excel文件不存在！请检查。文件名：{0}.", FilePath);
                throw new Exception(strMsg);
            }
            string strConn;

            string getsheet;



            getsheet = "SELECT * FROM [" + sheet + "]";

            strConn = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + FilePath + ";Extended Properties=Excel 8.0;";

            OleDbConnection conn = new OleDbConnection(strConn);

            OleDbDataAdapter myCommand = new OleDbDataAdapter(getsheet, strConn);

            DataSet myDataSet = new DataSet();

            try
            {

                myCommand.Fill(myDataSet);

            }

            catch (Exception ex)
            {

                //MessageBox.Show("该Excel文件的工作表的名字不正确," + ex.Message);

            }

            return myDataSet;

        }

    }
}
