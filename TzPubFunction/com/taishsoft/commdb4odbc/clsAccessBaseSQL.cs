using System;
using System.Data;
using System.Data.Odbc;
using System.IO;

using System.Collections.Generic;

namespace com.taishsoft.commdb4odbc
{
    /// <summary>
    /// clsAccessSQL 的摘要说明。
    /// </summary>
    public class clsAccessBaseSQL
    {
        /// <summary>
        /// 连接串
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
        /// 构造函数
        /// </summary>
        public clsAccessBaseSQL()
        {
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="strAccessFileName"></param>
        public clsAccessBaseSQL(string strAccessFileName)
        {
            //
            // TODO: 在此处添加构造函数逻辑
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
        /// C#中获取Access文件的第一个表名 
        /// Access文件中第一个表名的缺省值是Sheet1$, 但有时也会被改变为其他名字. 如果需要在C#中使用OleDb读写Access文件, 就需要知道这个名字是什么. 以下代码就是实现这个功能的:
        /// </summary>
        /// <returns></returns>
        public virtual string GetAccessFirstTableName()
        {
            string tableName = null;
           
            return tableName;
        }

        /// <summary>
        /// 获取Access的表单名称列表
        /// </summary>
        /// <returns></returns>
        public virtual List<string> GetAccessTableNameLst()
        {
            List<string> arrtableName = new List<string>();
           
            return arrtableName;
        }






        /// <summary>
        /// 2.以数据库方式打开并输入数据
        ///   此方式将xls文件所在目录看作数据库，其中的xls文件看作数据库表，表名即文件名（不加扩展名）。
        /// 函数importAccessToDataSet(string FilePath,string sheet)功能：从xls中读出数据到DataSet中，并返回DataSet对象。
        /// </summary>
        /// <param name="strAccessFileName">/*即文件目录的路径*/</param>
        /// <param name="strSheetName">/*表名即文件名（不加扩展名）*/</param>
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
        /// C#中获取Access文件的第一个表名 
        /// Access文件中第一个表名的缺省值是Sheet1$, 但有时也会被改变为其他名字. 如果需要在C#中使用OleDb读写Access文件, 就需要知道这个名字是什么. 以下代码就是实现这个功能的:
        /// </summary>
        /// <returns></returns>
        public virtual List<string> GetAccessTableNameLstByFileName(string strAccessFileName)
        {
            List<string> arrtableName = new List<string>();
           
            return arrtableName;
        }

    }
}
