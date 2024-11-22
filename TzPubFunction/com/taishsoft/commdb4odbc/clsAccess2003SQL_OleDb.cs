using System;
using System.Data;
using System.IO;
using System.Data.OleDb;
using System.Collections.Generic;

namespace com.taishsoft.commdb4odbc
{
    /// <summary>
    /// clsAccessSQL 的摘要说明。
    /// </summary>
    public class clsAccess2003SQL_OleDb : clsAccessBaseSQL
    {
       
        private OleDbConnection m_oConn;

        private string mstrAccessFileName = "";
        /// <summary>
        /// clsAccessSQL 的摘要说明。
        /// </summary>
        /// <param name="strAccessFileName"></param>
        public clsAccess2003SQL_OleDb(string strAccessFileName)
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
            mstrConnectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + strAccessFileName + ";";
            //objConn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="
            //                        + Server.MapPath("Student1.mdb");  ///设置连接串，说明连接使用的驱动程序，
           //mstrConnectString = "Driver={Microsoft Access Driver (*.xls)};DBQ=" + strAccessFileName;
       //mstrConnectString = "Driver={Microsoft Access Driver (*.xls, *.xlsx, *.xlsm, *.xlsb)};DBQ=" +strAccessFileName;// path to xls/xlsx/xlsm/xlsb file
            mstrAccessFileName = strAccessFileName;
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
        }
        public override DataTable funGetDataTable(string strSql)
        {
            DataTable objDT;

            //执行Stored Procedure
            try
            {
                OleDbCommand OleDbCmd;
                OleDbDataAdapter sqlAdp;
                m_oConn = new OleDbConnection(mstrConnectString);
                m_oConn.Open();

                OleDbCmd = new OleDbCommand();
                OleDbCmd.CommandType = CommandType.Text;
                OleDbCmd.Connection = m_oConn;
                OleDbCmd.CommandText = strSql;

                objDT = new DataTable();
                sqlAdp = new OleDbDataAdapter();
                sqlAdp.SelectCommand = OleDbCmd;
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
        public override DataTable funGetDataTable(string strSheetName, string strWhereCond)
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
                OleDbCommand OleDbCmd;
                OleDbDataAdapter sqlAdp;
                m_oConn = new OleDbConnection(mstrConnectString);
                m_oConn.Open();

                OleDbCmd = new OleDbCommand();
                OleDbCmd.CommandType = CommandType.Text;
                OleDbCmd.Connection = m_oConn;
                OleDbCmd.CommandText = strSQL;

                objDT = new DataTable();
                sqlAdp = new OleDbDataAdapter();
                sqlAdp.SelectCommand = OleDbCmd;
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
        /// C#中获取Access文件的第一个表名 
        /// Access文件中第一个表名的缺省值是Sheet1$, 但有时也会被改变为其他名字. 如果需要在C#中使用OleDb读写Access文件, 就需要知道这个名字是什么. 以下代码就是实现这个功能的:
        /// </summary>
        /// <returns></returns>
        public override string GetAccessFirstTableName()
        {
            string tableName = null;
            if (File.Exists(mstrAccessFileName))
            {
                m_oConn = new OleDbConnection(mstrConnectString);
                m_oConn.Open();
                DataTable dt = m_oConn.GetSchema("Tables");
                tableName = dt.Rows[0][2].ToString().Trim();

            }
            return tableName;
        }

        /// <summary>
        /// C#中获取Access文件的表单列表 
        /// Access文件中第一个表名的缺省值是Sheet1$, 但有时也会被改变为其他名字. 如果需要在C#中使用OleDb读写Access文件, 就需要知道这个名字是什么. 以下代码就是实现这个功能的:
        /// </summary>
        /// <returns>Access文件的表单列表</returns>
        public override List<string> GetAccessTableNameLst()
        {
            List<string> arrtableName = new List<string>();
            string tableName = null;
            if (File.Exists(mstrAccessFileName))
            {
                m_oConn = new OleDbConnection(mstrConnectString);
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
        /// C#中获取Access文件的第一个表名 
        /// Access文件中第一个表名的缺省值是Sheet1$, 但有时也会被改变为其他名字. 如果需要在C#中使用OleDb读写Access文件, 就需要知道这个名字是什么. 以下代码就是实现这个功能的:
        /// </summary>
        /// <returns></returns>
        public override List<string> GetAccessTableNameLstByFileName(string strAccessFileName)
        {
            List<string> arrtableName = new List<string>();
            string tableName = null;
            if (File.Exists(mstrAccessFileName))
            {
                using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet." +
                  "OLEDB.4.0;Extended Properties=\"Access 8.0\";Data Source=" + strAccessFileName))
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
        /// C#中获取Access文件的第一个表名 
        /// Access文件中第一个表名的缺省值是Sheet1$, 但有时也会被改变为其他名字. 如果需要在C#中使用OleDb读写Access文件, 就需要知道这个名字是什么. 以下代码就是实现这个功能的:
        /// </summary>
        /// <param name="AccessFileName"></param>
        /// <returns></returns>
        public static string GetAccessFirstTableNameByFileName(string AccessFileName)
        {
            string tableName = null;
            if (File.Exists(AccessFileName))
            {
                using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet." +
                  "OLEDB.4.0;Extended Properties=\"Access 8.0\";Data Source=" + AccessFileName))
                {
                    conn.Open();
                    DataTable dt = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    tableName = dt.Rows[0][2].ToString().Trim();
                }
            }
            return tableName;
        }
       



        /// <summary>
        /// 2.以数据库方式打开并输入数据
        /// 此方式将xls文件所在目录看作数据库，其中的xls文件看作数据库表，表名即文件名（不加扩展名）。
        /// 函数importAccessToDataSet(string FilePath,string sheet)功能：从xls中读出数据到DataSet中，并返回DataSet对象。
        /// </summary>
        /// <param name="FilePath">/*即文件目录的路径*/</param>
        /// <param name="sheet">/*表名即文件名（不加扩展名）*/</param>
        /// <returns></returns>
        public override DataSet importAccessToDataSet(string FilePath, string sheet)
        {

            string strConn;

            string getsheet;

            
            getsheet = "SELECT * FROM [" + sheet + "]";

            strConn = "Provider=Microsoft.Jet.OleDb.4.0;" + "Data Source=" + FilePath + ";Extended Properties=Access 8.0;";

            OleDbConnection conn = new OleDbConnection(strConn);

            OleDbDataAdapter myCommand = new OleDbDataAdapter(getsheet, strConn);

            DataSet myDataSet = new DataSet();

            try
            {

                myCommand.Fill(myDataSet);

            }

            catch (Exception ex)
            {
                throw ex;
                //MessageBox.Show("该Access文件的工作表的名字不正确," + ex.Message);

            }

            return myDataSet;

        }
        /// <summary>
        /// 执行SQL语句
        /// </summary>
        /// <param name="strSql">被执行的SQL语句</param>
        /// <returns>是否成功？</returns>
        public override bool ExecSql(string strSql)
        {
            //by davidfujian(李顺道)
            //2004-3-18 8:18
            //执行Stored Procedure
            m_oConn = new OleDbConnection(mstrConnectString);

            try
            {
                OleDbCommand sqlCmd;
                sqlCmd = new OleDbCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Connection = m_oConn;
                sqlCmd.CommandText = strSql;
                int intRecCount = sqlCmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception objException)
            {
                throw objException;
            }
            finally
            {
                m_oConn.Close();
            }
        }

        /// <summary>
        /// 功能：获取给定表的记录数.
        /// </summary>
        /// <param name="strTabName">所给定的表名</param>
        /// <returns>记录数，为整型</returns>
        public override int funGetRecCount(string strTabName)
        {
            OleDbCommand sqlCmd;
            int intRecCount;
            string strSQL;
            strSQL = string.Format("select count(*) from [{0}]", strTabName);
            m_oConn = new OleDbConnection(mstrConnectString);
            try
            {
                sqlCmd = new OleDbCommand();
                sqlCmd.Connection = m_oConn;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = strSQL;
                OleDbDataAdapter objDataAdapter = new OleDbDataAdapter();
                objDataAdapter.SelectCommand = sqlCmd;
                DataTable objDT = new DataTable();
                objDataAdapter.Fill(objDT);
                string strRecCount = objDT.Rows[0][0].ToString();
                intRecCount = int.Parse(strRecCount);//获得记录总数
                //				m_oConn.CloseB();		
                return intRecCount;
            }
            catch (Exception objException)
            {
                throw objException;
            }
            finally
            {
                m_oConn.Close();
            }

        }
        public override DataTable GetDataTable(string ssql)
        {
            //by davidfujian (李顺道)
            //2004-2-28 Night
            //获得并返回表
            OleDbCommand sqlCmd;
            OleDbDataAdapter sqlAdp;
            DataTable dtTab;
            m_oConn = new OleDbConnection(mstrConnectString);
            try
            {
                sqlCmd = new OleDbCommand();
                sqlCmd.Connection = m_oConn;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = ssql;
                sqlCmd.CommandTimeout = 2400;
                sqlAdp = new OleDbDataAdapter();
                sqlAdp.SelectCommand = sqlCmd;
                dtTab = new DataTable();
                sqlAdp.Fill(dtTab);

                //m_oConn.CloseB();
                return dtTab;
            }
            catch (Exception objException)
            {
                throw objException;
            }
            finally
            {
                m_oConn.Close();
            }
        }

    }
}
