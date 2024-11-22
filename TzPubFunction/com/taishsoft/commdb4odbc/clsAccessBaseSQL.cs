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
    public class clsAccessBaseSQL
    {
        /// <summary>
        /// ���Ӵ�
        /// </summary>
        protected string mstrConnectString;
        private System.Data.Odbc.OdbcConnection m_oConn;
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
        private string mstrAccessFileName = "";
        /// <summary>
        /// ���캯��
        /// </summary>
        public clsAccessBaseSQL()
        {
        }
        /// <summary>
        /// ���캯��
        /// </summary>
        /// <param name="strAccessFileName"></param>
        public clsAccessBaseSQL(string strAccessFileName)
        {
            //
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            mstrConnectString = "Driver={Microsoft Access Driver (*.xls)};DBQ=" + strAccessFileName;
            //mstrConnectString = "Driver={Microsoft Access Driver (*.xls, *.xlsx, *.xlsm, *.xlsb)};DBQ=" +strAccessFileName;// path to xls/xlsx/xlsm/xlsb file
            mstrAccessFileName = strAccessFileName;

        }
        public virtual DataTable funGetDataTable(string strSql)
        {
            DataTable objDT = null;


            return objDT;
           
        }

        /// <summary>
        /// ��ȡһ���������ݣ���������
        /// </summary>
        /// <param name="strSheetName"></param>
        /// <param name="strWhereCond"></param>
        /// <returns></returns>
        public virtual DataTable funGetDataTable(string strSheetName, string strWhereCond)
        {
            DataTable objDT = null;

            return objDT;
            
        }

        /// <summary>
        /// C#�л�ȡAccess�ļ��ĵ�һ������ 
        /// Access�ļ��е�һ��������ȱʡֵ��Sheet1$, ����ʱҲ�ᱻ�ı�Ϊ��������. �����Ҫ��C#��ʹ��OleDb��дAccess�ļ�, ����Ҫ֪�����������ʲô. ���´������ʵ��������ܵ�:
        /// </summary>
        /// <returns></returns>
        public virtual string GetAccessFirstTableName()
        {
            string tableName = null;
           
            return tableName;
        }

        /// <summary>
        /// ��ȡAccess�ı������б�
        /// </summary>
        /// <returns></returns>
        public virtual List<string> GetAccessTableNameLst()
        {
            List<string> arrtableName = new List<string>();
           
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
        public virtual DataSet importAccessToDataSet(string strAccessFileName, string strSheetName)
        {

            DataSet myDataSet = null;
            
            return myDataSet;

        }

        public virtual DataTable GetDataTable(string ssql)
        {
            DataTable dtTab = null;
            return dtTab;
          
        }

        /// <summary>
        /// ���ܣ���ȡ������ļ�¼��.
        /// </summary>
        /// <param name="strTabName">�������ı���</param>
        /// <returns>��¼����Ϊ����</returns>
        public virtual int funGetRecCount(string strTabName)
        {

            int intRecCount = 0;

            return intRecCount;
         
        }

        /// <summary>
        /// ִ��SQL���
        /// </summary>
        /// <param name="strSql">��ִ�е�SQL���</param>
        /// <returns>�Ƿ�ɹ���</returns>
        public virtual bool ExecSql(string strSql)
        {
            return true;
        }

        /// <summary>
        /// C#�л�ȡAccess�ļ��ĵ�һ������ 
        /// Access�ļ��е�һ��������ȱʡֵ��Sheet1$, ����ʱҲ�ᱻ�ı�Ϊ��������. �����Ҫ��C#��ʹ��OleDb��дAccess�ļ�, ����Ҫ֪�����������ʲô. ���´������ʵ��������ܵ�:
        /// </summary>
        /// <returns></returns>
        public virtual List<string> GetAccessTableNameLstByFileName(string strAccessFileName)
        {
            List<string> arrtableName = new List<string>();
           
            return arrtableName;
        }

    }
}
