using System;
using System.Data;
using System.Data.Odbc;
using System.IO;

using System.Collections.Generic;

namespace com.taishsoft.commdb4odbc
{
    /// <summary>
    /// clsAccessSQL ��ժҪ˵����
    /// </summary>
    public class clsAccess2003SQL_Odbc : clsAccessBaseSQL
    {
  
        private System.Data.Odbc.OdbcConnection m_oConn;

        private string mstrAccessFileName = "";
        public clsAccess2003SQL_Odbc(string strAccessFileName):base(strAccessFileName)
        {
            //
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            mstrConnectString = "Driver={Microsoft Access Driver (*.xls)};DBQ=" + strAccessFileName;
            //mstrConnectString = "Driver={Microsoft Access Driver (*.xls, *.xlsx, *.xlsm, *.xlsb)};DBQ=" +strAccessFileName;// path to xls/xlsx/xlsm/xlsb file
            mstrAccessFileName = strAccessFileName;
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
        }
        public override DataTable funGetDataTable(string strSql)
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
        /// C#�л�ȡAccess�ļ��ĵ�һ������ 
        /// Access�ļ��е�һ��������ȱʡֵ��Sheet1$, ����ʱҲ�ᱻ�ı�Ϊ��������. �����Ҫ��C#��ʹ��OleDb��дAccess�ļ�, ����Ҫ֪�����������ʲô. ���´������ʵ��������ܵ�:
        /// </summary>
        /// <param name="AccessFileName"></param>
        /// <returns></returns>
        public override string GetAccessFirstTableName()
        {
            string tableName = null;
            if (File.Exists(mstrAccessFileName))
            {
                m_oConn = new OdbcConnection(mstrConnectString);
                m_oConn.Open();
                DataTable dt = m_oConn.GetSchema("Tables");
                tableName = dt.Rows[0][2].ToString().Trim();

            }
            return tableName;
        }

        public override List<string> GetAccessTableNameLst()
        {
            List<string> arrtableName = new List<string>();
            string tableName = null;
            if (File.Exists(mstrAccessFileName))
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
        /// 2.�����ݿⷽʽ�򿪲���������
        ///   �˷�ʽ��xls�ļ�����Ŀ¼�������ݿ⣬���е�xls�ļ��������ݿ���������ļ�����������չ������
        /// ����importAccessToDataSet(string FilePath,string sheet)���ܣ���xls�ж������ݵ�DataSet�У�������DataSet����
        /// </summary>
        /// <param name="strAccessFileName">/*���ļ�Ŀ¼��·��*/</param>
        /// <param name="strSheetName">/*�������ļ�����������չ����*/</param>
        /// <returns></returns>
        public override DataSet importAccessToDataSet(string strAccessFileName, string strSheetName)
        {

            string strConn;
            string strSQL;
            strSQL = "SELECT * FROM [" + strSheetName + "]";
            strConn = "Driver={Microsoft Access Driver (*.xls)};DBQ=" + strAccessFileName;

            OdbcConnection conn = new OdbcConnection(strConn);

            OdbcDataAdapter myCommand = new OdbcDataAdapter(strSQL, strConn);

            DataSet myDataSet = new DataSet();
            try
            {
                myCommand.Fill(myDataSet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return myDataSet;

        }


        /// <summary>
        /// C#�л�ȡAccess�ļ��ĵ�һ������ 
        /// Access�ļ��е�һ��������ȱʡֵ��Sheet1$, ����ʱҲ�ᱻ�ı�Ϊ��������. �����Ҫ��C#��ʹ��OleDb��дAccess�ļ�, ����Ҫ֪�����������ʲô. ���´������ʵ��������ܵ�:
        /// </summary>
        /// <param name="AccessFileName"></param>
        /// <returns></returns>
        public static string GetAccessFirstTableNameByFileName(string strAccessFileName)
        {
            string tableName = null;
            if (File.Exists(strAccessFileName))
            {
                string strConnectString = "Driver={Microsoft Access Driver (*.xls)};DBQ=" + strAccessFileName;

                using (OdbcConnection conn = new OdbcConnection(strConnectString))
                {
                    conn.Open();
                    DataTable dt = conn.GetSchema("Tables");
                    tableName = dt.Rows[0][2].ToString().Trim();
                }
            }
            return tableName;
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
            m_oConn = new OdbcConnection(mstrConnectString);

            try
            {
                OdbcCommand sqlCmd;
                sqlCmd = new OdbcCommand();
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
          
            OdbcCommand sqlCmd;
            int intRecCount;
            string strSQL;
            strSQL = string.Format("select count(*) from [{0}]", strTabName);
            m_oConn = new OdbcConnection(mstrConnectString);
            try
            {
                sqlCmd = new OdbcCommand();
                sqlCmd.Connection = m_oConn;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = strSQL;
                OdbcDataAdapter objDataAdapter = new OdbcDataAdapter();
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
        public override DataTable GetDataTable(string ssql)
        {
            //by davidfujian (��˳��)
            //2004-2-28 Night
            //��ò����ر�
            OdbcCommand sqlCmd;
            OdbcDataAdapter sqlAdp;
            DataTable dtTab;
            m_oConn = new OdbcConnection(mstrConnectString);
            try
            {
                sqlCmd = new OdbcCommand();
                sqlCmd.Connection = m_oConn;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = ssql;
                sqlCmd.CommandTimeout = 2400;
                sqlAdp = new OdbcDataAdapter();
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
