using System;
using System.Data;
using System.Data.Odbc;
using System.IO;

using System.Collections.Generic;

namespace com.taishsoft.commdb4odbc
{
    /// <summary>
    /// clsExcelSQL 的摘要说明。
    /// </summary>
    public class clsExcelBaseSQL
    {
        /// <summary>
        /// 连接串
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
        /// 构造函数
        /// </summary>
        public clsExcelBaseSQL()
        {
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="strExcelFileName"></param>
        public clsExcelBaseSQL(string strExcelFileName)
        {
            //
            // TODO: 在此处添加构造函数逻辑
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
        /// 获取一个表单的内容，根据条件
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
        /// C#中获取Excel文件的第一个表名 
        /// Excel文件中第一个表名的缺省值是Sheet1$, 但有时也会被改变为其他名字. 如果需要在C#中使用OleDb读写Excel文件, 就需要知道这个名字是什么. 以下代码就是实现这个功能的:
        /// </summary>
        /// <returns></returns>
        public virtual string GetExcelFirstTableName()
        {
            string tableName = null;
           
            return tableName;
        }

        /// <summary>
        /// 获取Excel的表单名称列表
        /// </summary>
        /// <returns></returns>
        public virtual List<string> GetExcelTableNameLst()
        {
            List<string> arrtableName = new List<string>();
           
            return arrtableName;
        }






        /// <summary>
        /// 2.以数据库方式打开并输入数据
        ///   此方式将xls文件所在目录看作数据库，其中的xls文件看作数据库表，表名即文件名（不加扩展名）。
        /// 函数importExcelToDataSet(string FilePath,string sheet)功能：从xls中读出数据到DataSet中，并返回DataSet对象。
        /// </summary>
        /// <param name="strExcelFileName">/*即文件目录的路径*/</param>
        /// <param name="strSheetName">/*表名即文件名（不加扩展名）*/</param>
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
        /// 功能：获取给定表的记录数.
        /// </summary>
        /// <param name="strTabName">所给定的表名</param>
        /// <returns>记录数，为整型</returns>
        public virtual int funGetRecCount(string strTabName)
        {

            int intRecCount = 0;

            return intRecCount;
         
        }

        /// <summary>
        /// 执行SQL语句
        /// </summary>
        /// <param name="strSql">被执行的SQL语句</param>
        /// <returns>是否成功？</returns>
        public virtual bool ExecSql(string strSql)
        {
            return true;
        }

        /// <summary>
        /// C#中获取Excel文件的第一个表名 
        /// Excel文件中第一个表名的缺省值是Sheet1$, 但有时也会被改变为其他名字. 如果需要在C#中使用OleDb读写Excel文件, 就需要知道这个名字是什么. 以下代码就是实现这个功能的:
        /// </summary>
        /// <returns></returns>
        public virtual List<string> GetExcelTableNameLstByFileName(string strExcelFileName)
        {
            List<string> arrtableName = new List<string>();
           
            return arrtableName;
        }

    }
}
