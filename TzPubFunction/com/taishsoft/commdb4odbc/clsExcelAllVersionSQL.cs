using System;
using System.Data;
using System.IO;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Text;

namespace com.taishsoft.commdb4odbc
{
    /// <summary>
    /// clsExcelSQL ��ժҪ˵����
    /// </summary>
    public class clsExcelAllVersionSQL
    {
        private clsExcelBaseSQL objExcelBaseSQL = null;
        protected string mstrExcelVersion;
        public string ExcelVersion
        {
            get
            {
                return mstrExcelVersion;
            }
            set
            {
                mstrExcelVersion = value;
            }
        }
        //protected string mstrConnectString;
        //private OleDbConnection m_oConn;

        //private string mstrExcelFileName = "";
        /// <summary>
        /// ���캯��������ļ��Ƿ���ڣ�ͬʱ��������Ƿ�ɹ���
        ///          ͬʱ��鲻ͬ�汾��Excel�ļ�
        /// </summary>
        /// <param name="strExcelFileName"></param>
        public clsExcelAllVersionSQL(string strExcelFileName)
        {
            //
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            StringBuilder sbErrMsg = new StringBuilder();

            try
            {
                clsExcel2003SQL_Odbc objExcel2003SQL = new clsExcel2003SQL_Odbc(strExcelFileName);
                objExcelBaseSQL = objExcel2003SQL;
                objExcelBaseSQL.ExcelVersion = "2003";
                this.ExcelVersion = "2003";
                return;
            }
            catch (Exception objException)
            {
                //throw objException;
                sbErrMsg.AppendFormat("�ļ�:[{0}]����Excel2003��Odbc����ʽ��\r\n", strExcelFileName);
            }

            try
            {
                clsExcel2003SQL_OleDb objExcel2003SQL = new clsExcel2003SQL_OleDb(strExcelFileName);
                objExcelBaseSQL = objExcel2003SQL;
                objExcelBaseSQL.ExcelVersion = "2003";
                this.ExcelVersion = "2003";
                return;
            }
            catch (Exception objException)
            {
                //throw objException;
                sbErrMsg.Append("Ҳ����Excel2003��OldDb����ʽ��\r\n");
      
            }
            try
            {
                clsExcel2007SQL objExcel2007SQL = new clsExcel2007SQL(strExcelFileName);

                objExcelBaseSQL = objExcel2007SQL;
                objExcelBaseSQL.ExcelVersion = "2007";
                this.ExcelVersion = "2007";
                return;
            }
            catch (Exception objException)
            {
                //throw objException;
                sbErrMsg.Append("Ҳ����Excel2007��ʽ��\r\n");
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

            DataTable dtTab = objExcelBaseSQL.GetDataTable(strSql);

            return dtTab;

        }

        /// <summary>
        /// ���ݸ���Sql����ȡ������
        /// </summary>
        /// <param name="strSql">����Sql���</param>
        /// <returns>���صı����ݣ���DataTable��ʾ</returns>
        public DataTable funGetDataTable(string strSql)
        {
            DataTable objDT = objExcelBaseSQL.funGetDataTable(strSql);
            return objDT;
        }

        /// <summary>
        /// ��ȡExcel�ļ������������������ı�����
        /// </summary>
        /// <param name="strSheetName">������</param>
        /// <param name="strWhereCond">��������</param>
        /// <returns>������</returns>
        public DataTable funGetDataTable(string strSheetName, string strWhereCond)
        {
            DataTable objDT = objExcelBaseSQL.funGetDataTable(strSheetName, strWhereCond);

            return objDT;

        }


        /// <summary>
        /// ��ȡExcel�ļ��е�һ��������
        /// </summary>
        /// <returns>��һ��������</returns>
        public string GetExcelFirstTableName()
        {
            string tableName = objExcelBaseSQL.GetExcelFirstTableName();
            return tableName;
        }
        /// <summary>
        /// ��ȡExcel�ļ��б������б�
        /// </summary>
        /// <returns>�������б�</returns>
        public List<string> GetExcelTableNameLst()
        {
            List<string> arrtableName = objExcelBaseSQL.GetExcelTableNameLst();
            return arrtableName;
        }
        /// <summary>
        /// C#�л�ȡExcel�ļ��ĵ�һ������ 
        /// Excel�ļ��е�һ��������ȱʡֵ��Sheet1$, ����ʱҲ�ᱻ�ı�Ϊ��������. �����Ҫ��C#��ʹ��OleDb��дExcel�ļ�, ����Ҫ֪�����������ʲô. ���´������ʵ��������ܵ�:
        /// </summary>
        /// <returns></returns>
        public List<string> GetExcelTableNameLstByFileName(string strExcelFileName)
        {
            List<string> arrtableName = objExcelBaseSQL.GetExcelTableNameLstByFileName(strExcelFileName);
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
            StringBuilder sbErrMsg = new StringBuilder();
            string tableName = "";
            try
            {
                tableName = clsExcel2007SQL.GetExcelFirstTableNameByFileName(strExcelFileName);
                return tableName;
            }
            catch (Exception objException)
            {
                sbErrMsg.AppendFormat("�ļ�:[{0}]����Excel2007��ʽ��\r\n", strExcelFileName);
            }
            try
            {
                tableName = clsExcel2003SQL_OleDb.GetExcelFirstTableNameByFileName(strExcelFileName);
                return tableName;
            }
            catch (Exception objException)
            {
                sbErrMsg.Append("Ҳ����Excel2003��ʽ��\r\n");

            }
            try
            {
                tableName = clsExcel2003SQL_Odbc.GetExcelFirstTableNameByFileName(strExcelFileName);
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
        /// ����importExcelToDataSet(string FilePath,string sheet)���ܣ���xls�ж������ݵ�DataSet�У�������DataSet����
        /// </summary>
        /// <param name="strExcelFileName">/*���ļ�Ŀ¼��·��*/</param>
        /// <param name="sheet">/*�������ļ�����������չ����*/</param>
        /// <returns></returns>
        public DataSet importExcelToDataSet(string strExcelFileName, string sheet)
        {


            DataSet myDataSet = objExcelBaseSQL.importExcelToDataSet(strExcelFileName, sheet);

            return myDataSet;

        }
        /// <summary>
        /// ִ��SQL���
        /// </summary>
        /// <param name="strSql">��ִ�е�SQL���</param>
        /// <returns>�Ƿ�ɹ���</returns>
        public bool ExecSql(string strSql)
        {

            return objExcelBaseSQL.ExecSql(strSql);

        }

        /// <summary>
        /// ���ܣ���ȡ������ļ�¼��.
        /// </summary>
        /// <param name="strTabName">�������ı���</param>
        /// <returns>��¼����Ϊ����</returns>
        public int funGetRecCount(string strTabName)
        {

            int intRecCount = objExcelBaseSQL.funGetRecCount(strTabName);

            return intRecCount;

        }
       
    }
}
