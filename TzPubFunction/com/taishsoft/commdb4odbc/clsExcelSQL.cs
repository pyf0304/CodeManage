using System;
using System.Data;
using System.Data.Odbc;
using System.IO;
using System.Data.OleDb;
using System.Collections.Generic;

namespace com.taishsoft.commdb4odbc
{
    /// <summary>
    /// clsExcelSQL ��ժҪ˵����
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
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            if (File.Exists(strExcelFileName) == false)
            {
                string strMsg = string.Format("Excel�ļ������ڣ����顣�ļ�����{0}.", strExcelFileName);
                throw new Exception(strMsg);
            }
           mstrConnectString = "Driver={Microsoft Excel Driver (*.xls)};DBQ=" + strExcelFileName;
       //mstrConnectString = "Driver={Microsoft Excel Driver (*.xls, *.xlsx, *.xlsm, *.xlsb)};DBQ=" +strExcelFileName;// path to xls/xlsx/xlsm/xlsb file
            mstrExcelFileName = strExcelFileName;

        }
        public DataTable funGetDataTable(string strSql)
        {
            DataTable objDT;

            //ִ��Stored Procedure
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
            //ִ��Stored Procedure
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
        /// C#�л�ȡExcel�ļ��ĵ�һ������ 
        /// Excel�ļ��е�һ��������ȱʡֵ��Sheet1$, ����ʱҲ�ᱻ�ı�Ϊ��������. �����Ҫ��C#��ʹ��OleDb��дExcel�ļ�, ����Ҫ֪�����������ʲô. ���´������ʵ��������ܵ�:
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
        /// C#�л�ȡExcel�ļ��ĵ�һ������ 
        /// Excel�ļ��е�һ��������ȱʡֵ��Sheet1$, ����ʱҲ�ᱻ�ı�Ϊ��������. �����Ҫ��C#��ʹ��OleDb��дExcel�ļ�, ����Ҫ֪�����������ʲô. ���´������ʵ��������ܵ�:
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
        /// C#�л�ȡExcel�ļ��ĵ�һ������ 
        /// Excel�ļ��е�һ��������ȱʡֵ��Sheet1$, ����ʱҲ�ᱻ�ı�Ϊ��������. �����Ҫ��C#��ʹ��OleDb��дExcel�ļ�, ����Ҫ֪�����������ʲô. ���´������ʵ��������ܵ�:
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

        //    2.�����ݿⷽʽ�򿪲���������
        //      �˷�ʽ��xls�ļ�����Ŀ¼�������ݿ⣬���е�xls�ļ��������ݿ���������ļ�����������չ������
        //      ����importExcelToDataSet(string FilePath,string sheet)���ܣ���xls�ж������ݵ�DataSet�У�������DataSet����


        private DataSet importExcelToDataSet(string FilePath/*���ļ�Ŀ¼��·��*/, string sheet/*�������ļ�����������չ����*/)
        {

            if (File.Exists(FilePath) == false)
            {
                string strMsg = string.Format("Excel�ļ������ڣ����顣�ļ�����{0}.", FilePath);
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

                //MessageBox.Show("��Excel�ļ��Ĺ���������ֲ���ȷ," + ex.Message);

            }

            return myDataSet;

        }

    }
}
