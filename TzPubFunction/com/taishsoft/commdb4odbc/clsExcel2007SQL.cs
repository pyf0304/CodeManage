using System;
using System.Data;
using System.IO;
using System.Data.OleDb;
using System.Collections.Generic;

namespace com.taishsoft.commdb4odbc
{
    /// <summary>
    /// clsExcelSQL ��ժҪ˵����
    /// </summary>
    public class clsExcel2007SQL : clsExcelBaseSQL
    {
   
        private OleDbConnection m_oConn;

        private string mstrExcelFileName = "";
        /// <summary>
        /// ���캯��������ļ��Ƿ���ڣ�ͬʱ��������Ƿ�ɹ���
        /// </summary>
        /// <param name="strExcelFileName"></param>
        public clsExcel2007SQL(string strExcelFileName)
        {
            //
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            mstrConnectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
                                     + strExcelFileName + ";Extended Properties=Excel 12.0 Xml;";

            mstrExcelFileName = strExcelFileName;
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

            //ִ��Stored Procedure
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
            //ִ��Stored Procedure
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
        /// 
        /// </summary>
        /// <returns></returns>
        public override string GetExcelFirstTableName()
        {
            string tableName = null;
            if (File.Exists(mstrExcelFileName))
            {
                m_oConn = new OleDbConnection(mstrConnectString);
                m_oConn.Open();
                DataTable dt = m_oConn.GetSchema("Tables");
                tableName = dt.Rows[0][2].ToString().Trim();

            }
            return tableName;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override List<string> GetExcelTableNameLst()
        {
            List<string> arrtableName = new List<string>();
            string tableName = null;
            if (File.Exists(mstrExcelFileName))
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
        /// C#�л�ȡExcel�ļ��ĵ�һ������ 
        /// Excel�ļ��е�һ��������ȱʡֵ��Sheet1$, ����ʱҲ�ᱻ�ı�Ϊ��������. �����Ҫ��C#��ʹ��OleDb��дExcel�ļ�, ����Ҫ֪�����������ʲô. ���´������ʵ��������ܵ�:
        /// </summary>
        /// <returns></returns>
        public override List<string> GetExcelTableNameLstByFileName(string strExcelFileName)
        {
            List<string> arrtableName = new List<string>();
            string tableName = null;
            if (File.Exists(mstrExcelFileName))
            {
                string strConnString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
                                   + strExcelFileName + ";Extended Properties=Excel 12.0 Xml;";
                using (OleDbConnection conn = new OleDbConnection(strConnString))
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
        public static string GetExcelFirstTableNameByFileName(string strExcelFileName)
        {
            string tableName = null;
            if (File.Exists(strExcelFileName))
            {
                string strConnString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
                                     + strExcelFileName + ";Extended Properties=Excel 12.0 Xml;";
                using (OleDbConnection conn = new OleDbConnection(strConnString))
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="strExcelFileName">/*���ļ�Ŀ¼��·��*/</param>
        /// <param name="sheet">/*�������ļ�����������չ����*/</param>
        /// <returns></returns>
        public override DataSet importExcelToDataSet(string strExcelFileName, string sheet)
        {

            string getsheet;



            getsheet = "SELECT * FROM [" + sheet + "]";

            string strConnString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
                                    + strExcelFileName + ";Extended Properties=Excel 12.0 Xml;";
            OleDbConnection conn = new OleDbConnection(strConnString);

            OleDbDataAdapter myCommand = new OleDbDataAdapter(getsheet, strConnString);

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
        /// <summary>
        /// ִ��SQL���
        /// </summary>
        /// <param name="strSql">��ִ�е�SQL���</param>
        /// <returns>�Ƿ�ɹ���</returns>
        public override bool ExecSql(string strSql)
        {
            //by davidfujian(��˳��)
            //2004-3-18 8:18
            //ִ��Stored Procedure
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
        /// ���ܣ���ȡ������ļ�¼��.
        /// </summary>
        /// <param name="strTabName">�������ı���</param>
        /// <returns>��¼����Ϊ����</returns>
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
                intRecCount = int.Parse(strRecCount);//��ü�¼����
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
        public override DataTable GetDataTable(string strSql)
        {
            //by davidfujian (��˳��)
            //2004-2-28 Night
            //��ò����ر�
            OleDbCommand sqlCmd;
            OleDbDataAdapter sqlAdp;
            DataTable dtTab;
            m_oConn = new OleDbConnection(mstrConnectString);
            try
            {
                sqlCmd = new OleDbCommand();
                sqlCmd.Connection = m_oConn;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = strSql;
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
