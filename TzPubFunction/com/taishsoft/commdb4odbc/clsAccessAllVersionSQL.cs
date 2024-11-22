using System;
using System.Data;
using System.IO;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Text;

namespace com.taishsoft.commdb4odbc
{
    /// <summary>
    /// clsAccessSQL 的摘要说明。
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
        /// 构造函数，检查文件是否存在，同时检查连接是否成功？
        ///          同时检查不同版本的Access文件
        /// </summary>
        /// <param name="strAccessFileName"></param>
        public clsAccessAllVersionSQL(string strAccessFileName)
        {
            //
            // TODO: 在此处添加构造函数逻辑
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
                sbErrMsg.AppendFormat("文件:[{0}]不是Access2003（Odbc）格式。\r\n", strAccessFileName);
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
                sbErrMsg.Append("也不是Access2003（OldDb）格式。\r\n");
      
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
                sbErrMsg.Append("也不是Access2007格式。\r\n");
                sbErrMsg.Append("请检查文件的格式。\r\n");
                throw new Exception(sbErrMsg.ToString());
          
            }
        }
        /// <summary>
        /// 根据给定Sql语句获取表单内容
        /// </summary>
        /// <param name="strSql">给定Sql语句</param>
        /// <returns>返回的表单内容，用DataTable表示</returns>
        public DataTable GetDataTable(string strSql)
        {

            DataTable dtTab = objAccessBaseSQL.GetDataTable(strSql);

            return dtTab;

        }

        /// <summary>
        /// 根据给定Sql语句获取表单内容
        /// </summary>
        /// <param name="strSql">给定Sql语句</param>
        /// <returns>返回的表单内容，用DataTable表示</returns>
        public DataTable funGetDataTable(string strSql)
        {
            DataTable objDT = objAccessBaseSQL.funGetDataTable(strSql);
            return objDT;
        }

        /// <summary>
        /// 获取Access文件给定表单、给定条件的表内容
        /// </summary>
        /// <param name="strSheetName">表单名称</param>
        /// <param name="strWhereCond">给定条件</param>
        /// <returns>表单内容</returns>
        public DataTable funGetDataTable(string strSheetName, string strWhereCond)
        {
            DataTable objDT = objAccessBaseSQL.funGetDataTable(strSheetName, strWhereCond);

            return objDT;

        }


        /// <summary>
        /// 获取Access文件中第一个表单名称
        /// </summary>
        /// <returns>第一个表单名称</returns>
        public string GetAccessFirstTableName()
        {
            string tableName = objAccessBaseSQL.GetAccessFirstTableName();
            return tableName;
        }
        /// <summary>
        /// 获取Access文件中表单名称列表
        /// </summary>
        /// <returns>表单名称列表</returns>
        public List<string> GetAccessTableNameLst()
        {
            List<string> arrtableName = objAccessBaseSQL.GetAccessTableNameLst();
            return arrtableName;
        }
        /// <summary>
        /// C#中获取Access文件的第一个表名 
        /// Access文件中第一个表名的缺省值是Sheet1$, 但有时也会被改变为其他名字. 如果需要在C#中使用OleDb读写Access文件, 就需要知道这个名字是什么. 以下代码就是实现这个功能的:
        /// </summary>
        /// <returns></returns>
        public List<string> GetAccessTableNameLstByFileName(string strAccessFileName)
        {
            List<string> arrtableName = objAccessBaseSQL.GetAccessTableNameLstByFileName(strAccessFileName);
            return arrtableName;
        }
        /// <summary>
        /// C#中获取Access文件的第一个表名 
        /// Access文件中第一个表名的缺省值是Sheet1$, 但有时也会被改变为其他名字. 如果需要在C#中使用OleDb读写Access文件, 就需要知道这个名字是什么. 以下代码就是实现这个功能的:
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
                sbErrMsg.AppendFormat("文件:[{0}]不是Access2007格式。\r\n", strAccessFileName);
            }
            try
            {
                tableName = clsAccess2003SQL_OleDb.GetAccessFirstTableNameByFileName(strAccessFileName);
                return tableName;
            }
            catch (Exception objException)
            {
                sbErrMsg.Append("也不是Access2003格式。\r\n");

            }
            try
            {
                tableName = clsAccess2003SQL_Odbc.GetAccessFirstTableNameByFileName(strAccessFileName);
                return tableName;
            }
            catch (Exception objException)
            {
                sbErrMsg.Append("请检查文件的格式。\r\n");
                throw new Exception(sbErrMsg.ToString());
            }

            return tableName;
        }




        /// <summary>
        /// 以数据库方式打开并输入数据
        /// 此方式将xls文件所在目录看作数据库，其中的xls文件看作数据库表，表名即文件名（不加扩展名）。
        /// 函数importAccessToDataSet(string FilePath,string sheet)功能：从xls中读出数据到DataSet中，并返回DataSet对象。
        /// </summary>
        /// <param name="strAccessFileName">/*即文件目录的路径*/</param>
        /// <param name="sheet">/*表名即文件名（不加扩展名）*/</param>
        /// <returns></returns>
        public DataSet importAccessToDataSet(string strAccessFileName, string sheet)
        {


            DataSet myDataSet = objAccessBaseSQL.importAccessToDataSet(strAccessFileName, sheet);

            return myDataSet;

        }
        /// <summary>
        /// 执行SQL语句
        /// </summary>
        /// <param name="strSql">被执行的SQL语句</param>
        /// <returns>是否成功？</returns>
        public bool ExecSql(string strSql)
        {

            return objAccessBaseSQL.ExecSql(strSql);

        }

        /// <summary>
        /// 功能：获取给定表的记录数.
        /// </summary>
        /// <param name="strTabName">所给定的表名</param>
        /// <returns>记录数，为整型</returns>
        public int funGetRecCount(string strTabName)
        {

            int intRecCount = objAccessBaseSQL.funGetRecCount(strTabName);

            return intRecCount;

        }
       
    }
}
