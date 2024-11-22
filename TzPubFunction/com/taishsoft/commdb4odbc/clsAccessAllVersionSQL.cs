using System;
using System.Data;
using System.IO;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Text;

namespace com.taishsoft.commdb4odbc
{
    /// <summary>
    /// clsAccessSQL ��ժҪ˵����
    /// </summary>
    public class clsAccessAllVersionSQL
    {
        private clsAccessBaseSQL objAccessBaseSQL = null;
        protected string mstrAccessVersion;
        public string AccessVersion
        {
            get
            {
                return mstrAccessVersion;
            }
            set
            {
                mstrAccessVersion = value;
            }
        }
        //protected string mstrConnectString;
        //private OleDbConnection m_oConn;

        //private string mstrAccessFileName = "";
        /// <summary>
        /// ���캯��������ļ��Ƿ���ڣ�ͬʱ��������Ƿ�ɹ���
        ///          ͬʱ��鲻ͬ�汾��Access�ļ�
        /// </summary>
        /// <param name="strAccessFileName"></param>
        public clsAccessAllVersionSQL(string strAccessFileName)
        {
            //
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            StringBuilder sbErrMsg = new StringBuilder();

            try
            {
                clsAccess2003SQL_Odbc objAccess2003SQL = new clsAccess2003SQL_Odbc(strAccessFileName);
                objAccessBaseSQL = objAccess2003SQL;
                objAccessBaseSQL.AccessVersion = "2003";
                this.AccessVersion = "2003";
                return;
            }
            catch (Exception objException)
            {
                //throw objException;
                sbErrMsg.AppendFormat("�ļ�:[{0}]����Access2003��Odbc����ʽ��\r\n", strAccessFileName);
            }

            try
            {
                clsAccess2003SQL_OleDb objAccess2003SQL = new clsAccess2003SQL_OleDb(strAccessFileName);
                objAccessBaseSQL = objAccess2003SQL;
                objAccessBaseSQL.AccessVersion = "2003";
                this.AccessVersion = "2003";
                return;
            }
            catch (Exception objException)
            {
                //throw objException;
                sbErrMsg.Append("Ҳ����Access2003��OldDb����ʽ��\r\n");
      
            }
            try
            {
                clsAccess2007SQL objAccess2007SQL = new clsAccess2007SQL(strAccessFileName);

                objAccessBaseSQL = objAccess2007SQL;
                objAccessBaseSQL.AccessVersion = "2007";
                this.AccessVersion = "2007";
                return;
            }
            catch (Exception objException)
            {
                //throw objException;
                sbErrMsg.Append("Ҳ����Access2007��ʽ��\r\n");
                sbErrMsg.Append("�����ļ��ĸ�ʽ��\r\n");
                throw new Exception(sbErrMsg.ToString());
          
            }
        }
        /// <summary>
        /// ���ݸ���Sql����ȡ������
        /// </summary>
        /// <param name="strSql">����Sql���</param>
        /// <returns>���صı����ݣ���DataTable��ʾ</returns>
        public DataTable GetDataTable(string strSql)
        {

            DataTable dtTab = objAccessBaseSQL.GetDataTable(strSql);

            return dtTab;

        }

        /// <summary>
        /// ���ݸ���Sql����ȡ������
        /// </summary>
        /// <param name="strSql">����Sql���</param>
        /// <returns>���صı����ݣ���DataTable��ʾ</returns>
        public DataTable funGetDataTable(string strSql)
        {
            DataTable objDT = objAccessBaseSQL.funGetDataTable(strSql);
            return objDT;
        }

        /// <summary>
        /// ��ȡAccess�ļ������������������ı�����
        /// </summary>
        /// <param name="strSheetName">������</param>
        /// <param name="strWhereCond">��������</param>
        /// <returns>������</returns>
        public DataTable funGetDataTable(string strSheetName, string strWhereCond)
        {
            DataTable objDT = objAccessBaseSQL.funGetDataTable(strSheetName, strWhereCond);

            return objDT;

        }


        /// <summary>
        /// ��ȡAccess�ļ��е�һ��������
        /// </summary>
        /// <returns>��һ��������</returns>
        public string GetAccessFirstTableName()
        {
            string tableName = objAccessBaseSQL.GetAccessFirstTableName();
            return tableName;
        }
        /// <summary>
        /// ��ȡAccess�ļ��б������б�
        /// </summary>
        /// <returns>�������б�</returns>
        public List<string> GetAccessTableNameLst()
        {
            List<string> arrtableName = objAccessBaseSQL.GetAccessTableNameLst();
            return arrtableName;
        }
        /// <summary>
        /// C#�л�ȡAccess�ļ��ĵ�һ������ 
        /// Access�ļ��е�һ��������ȱʡֵ��Sheet1$, ����ʱҲ�ᱻ�ı�Ϊ��������. �����Ҫ��C#��ʹ��OleDb��дAccess�ļ�, ����Ҫ֪�����������ʲô. ���´������ʵ��������ܵ�:
        /// </summary>
        /// <returns></returns>
        public List<string> GetAccessTableNameLstByFileName(string strAccessFileName)
        {
            List<string> arrtableName = objAccessBaseSQL.GetAccessTableNameLstByFileName(strAccessFileName);
            return arrtableName;
        }
        /// <summary>
        /// C#�л�ȡAccess�ļ��ĵ�һ������ 
        /// Access�ļ��е�һ��������ȱʡֵ��Sheet1$, ����ʱҲ�ᱻ�ı�Ϊ��������. �����Ҫ��C#��ʹ��OleDb��дAccess�ļ�, ����Ҫ֪�����������ʲô. ���´������ʵ��������ܵ�:
        /// </summary>
        /// <param name="strAccessFileName"></param>
        /// <returns></returns>
        public static string GetAccessFirstTableNameByFileName(string strAccessFileName)
        {
            StringBuilder sbErrMsg = new StringBuilder();
            string tableName = "";
            try
            {
                tableName = clsAccess2007SQL.GetAccessFirstTableNameByFileName(strAccessFileName);
                return tableName;
            }
            catch (Exception objException)
            {
                sbErrMsg.AppendFormat("�ļ�:[{0}]����Access2007��ʽ��\r\n", strAccessFileName);
            }
            try
            {
                tableName = clsAccess2003SQL_OleDb.GetAccessFirstTableNameByFileName(strAccessFileName);
                return tableName;
            }
            catch (Exception objException)
            {
                sbErrMsg.Append("Ҳ����Access2003��ʽ��\r\n");

            }
            try
            {
                tableName = clsAccess2003SQL_Odbc.GetAccessFirstTableNameByFileName(strAccessFileName);
                return tableName;
            }
            catch (Exception objException)
            {
                sbErrMsg.Append("�����ļ��ĸ�ʽ��\r\n");
                throw new Exception(sbErrMsg.ToString());
            }

            return tableName;
        }




        /// <summary>
        /// �����ݿⷽʽ�򿪲���������
        /// �˷�ʽ��xls�ļ�����Ŀ¼�������ݿ⣬���е�xls�ļ��������ݿ���������ļ�����������չ������
        /// ����importAccessToDataSet(string FilePath,string sheet)���ܣ���xls�ж������ݵ�DataSet�У�������DataSet����
        /// </summary>
        /// <param name="strAccessFileName">/*���ļ�Ŀ¼��·��*/</param>
        /// <param name="sheet">/*�������ļ�����������չ����*/</param>
        /// <returns></returns>
        public DataSet importAccessToDataSet(string strAccessFileName, string sheet)
        {


            DataSet myDataSet = objAccessBaseSQL.importAccessToDataSet(strAccessFileName, sheet);

            return myDataSet;

        }
        /// <summary>
        /// ִ��SQL���
        /// </summary>
        /// <param name="strSql">��ִ�е�SQL���</param>
        /// <returns>�Ƿ�ɹ���</returns>
        public bool ExecSql(string strSql)
        {

            return objAccessBaseSQL.ExecSql(strSql);

        }

        /// <summary>
        /// ���ܣ���ȡ������ļ�¼��.
        /// </summary>
        /// <param name="strTabName">�������ı���</param>
        /// <returns>��¼����Ϊ����</returns>
        public int funGetRecCount(string strTabName)
        {

            int intRecCount = objAccessBaseSQL.funGetRecCount(strTabName);

            return intRecCount;

        }
       
    }
}
