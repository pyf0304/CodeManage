using System;
using System.Data;
using System.Data.Odbc;
using System.IO;

using System.Collections.Generic;

namespace com.taishsoft.commdb4odbc
{
    /// <summary>
    /// clsExcelSQL ��ժҪ˵����
    /// </summary>
    public class clsExcelBaseSQL
    {
        /// <summary>
        /// ���Ӵ�
        /// </summary>
        protected string mstrConnectString;
        private System.Data.Odbc.OdbcConnection m_oConn;
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
        private string mstrExcelFileName = "";
        /// <summary>
        /// ���캯��
        /// </summary>
        public clsExcelBaseSQL()
        {
        }
        /// <summary>
        /// ���캯��
        /// </summary>
        /// <param name="strExcelFileName"></param>
        public clsExcelBaseSQL(string strExcelFileName)
        {
            //
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            mstrConnectString = "Driver={Microsoft Excel Driver (*.xls)};DBQ=" + strExcelFileName;
            //mstrConnectString = "Driver={Microsoft Excel Driver (*.xls, *.xlsx, *.xlsm, *.xlsb)};DBQ=" +strExcelFileName;// path to xls/xlsx/xlsm/xlsb file
            mstrExcelFileName = strExcelFileName;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strSql"></param>
        /// <returns></returns>
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
        /// C#�л�ȡExcel�ļ��ĵ�һ������ 
        /// Excel�ļ��е�һ��������ȱʡֵ��Sheet1$, ����ʱҲ�ᱻ�ı�Ϊ��������. �����Ҫ��C#��ʹ��OleDb��дExcel�ļ�, ����Ҫ֪�����������ʲô. ���´������ʵ��������ܵ�:
        /// </summary>
        /// <returns></returns>
        public virtual string GetExcelFirstTableName()
        {
            string tableName = null;
           
            return tableName;
        }

        /// <summary>
        /// ��ȡExcel�ı������б�
        /// </summary>
        /// <returns></returns>
        public virtual List<string> GetExcelTableNameLst()
        {
            List<string> arrtableName = new List<string>();
           
            return arrtableName;
        }






        /// <summary>
        /// 2.�����ݿⷽʽ�򿪲���������
        ///   �˷�ʽ��xls�ļ�����Ŀ¼�������ݿ⣬���е�xls�ļ��������ݿ���������ļ�����������չ������
        /// ����importExcelToDataSet(string FilePath,string sheet)���ܣ���xls�ж������ݵ�DataSet�У�������DataSet����
        /// </summary>
        /// <param name="strExcelFileName">/*���ļ�Ŀ¼��·��*/</param>
        /// <param name="strSheetName">/*�������ļ�����������չ����*/</param>
        /// <returns></returns>
        public virtual DataSet importExcelToDataSet(string strExcelFileName, string strSheetName)
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
        /// C#�л�ȡExcel�ļ��ĵ�һ������ 
        /// Excel�ļ��е�һ��������ȱʡֵ��Sheet1$, ����ʱҲ�ᱻ�ı�Ϊ��������. �����Ҫ��C#��ʹ��OleDb��дExcel�ļ�, ����Ҫ֪�����������ʲô. ���´������ʵ��������ܵ�:
        /// </summary>
        /// <returns></returns>
        public virtual List<string> GetExcelTableNameLstByFileName(string strExcelFileName)
        {
            List<string> arrtableName = new List<string>();
           
            return arrtableName;
        }

    }
}
