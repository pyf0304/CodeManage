using System;
using System.Data;
using System.IO;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Text;

namespace com.taishsoft.commdb4odbc
{
    /// <summary>
    /// clsExcelSQL 的摘要说明。
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
        /// 构造函数，检查文件是否存在，同时检查连接是否成功？
        ///          同时检查不同版本的Excel文件
        /// </summary>
        /// <param name="strExcelFileName"></param>
        public clsExcelAllVersionSQL(string strExcelFileName)
        {
            //
            // TODO: 在此处添加构造函数逻辑
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
                sbErrMsg.AppendFormat("文件:[{0}]不是Excel2003（Odbc）格式。\r\n", strExcelFileName);
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
                sbErrMsg.Append("也不是Excel2003（OldDb）格式。\r\n");
      
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
                sbErrMsg.Append("也不是Excel2007格式。\r\n");
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

            DataTable dtTab = objExcelBaseSQL.GetDataTable(strSql);

            return dtTab;

        }

        /// <summary>
        /// 根据给定Sql语句获取表单内容
        /// </summary>
        /// <param name="strSql">给定Sql语句</param>
        /// <returns>返回的表单内容，用DataTable表示</returns>
        public DataTable funGetDataTable(string strSql)
        {
            DataTable objDT = objExcelBaseSQL.funGetDataTable(strSql);
            return objDT;
        }

        /// <summary>
        /// 获取Excel文件给定表单、给定条件的表内容
        /// </summary>
        /// <param name="strSheetName">表单名称</param>
        /// <param name="strWhereCond">给定条件</param>
        /// <returns>表单内容</returns>
        public DataTable funGetDataTable(string strSheetName, string strWhereCond)
        {
            DataTable objDT = objExcelBaseSQL.funGetDataTable(strSheetName, strWhereCond);

            return objDT;

        }


        /// <summary>
        /// 获取Excel文件中第一个表单名称
        /// </summary>
        /// <returns>第一个表单名称</returns>
        public string GetExcelFirstTableName()
        {
            string tableName = objExcelBaseSQL.GetExcelFirstTableName();
            return tableName;
        }
        /// <summary>
        /// 获取Excel文件中表单名称列表
        /// </summary>
        /// <returns>表单名称列表</returns>
        public List<string> GetExcelTableNameLst()
        {
            List<string> arrtableName = objExcelBaseSQL.GetExcelTableNameLst();
            return arrtableName;
        }
        /// <summary>
        /// C#中获取Excel文件的第一个表名 
        /// Excel文件中第一个表名的缺省值是Sheet1$, 但有时也会被改变为其他名字. 如果需要在C#中使用OleDb读写Excel文件, 就需要知道这个名字是什么. 以下代码就是实现这个功能的:
        /// </summary>
        /// <returns></returns>
        public List<string> GetExcelTableNameLstByFileName(string strExcelFileName)
        {
            List<string> arrtableName = objExcelBaseSQL.GetExcelTableNameLstByFileName(strExcelFileName);
            return arrtableName;
        }
        /// <summary>
        /// C#中获取Excel文件的第一个表名 
        /// Excel文件中第一个表名的缺省值是Sheet1$, 但有时也会被改变为其他名字. 如果需要在C#中使用OleDb读写Excel文件, 就需要知道这个名字是什么. 以下代码就是实现这个功能的:
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
                sbErrMsg.AppendFormat("文件:[{0}]不是Excel2007格式。\r\n", strExcelFileName);
            }
            try
            {
                tableName = clsExcel2003SQL_OleDb.GetExcelFirstTableNameByFileName(strExcelFileName);
                return tableName;
            }
            catch (Exception objException)
            {
                sbErrMsg.Append("也不是Excel2003格式。\r\n");

            }
            try
            {
                tableName = clsExcel2003SQL_Odbc.GetExcelFirstTableNameByFileName(strExcelFileName);
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
        /// 函数importExcelToDataSet(string FilePath,string sheet)功能：从xls中读出数据到DataSet中，并返回DataSet对象。
        /// </summary>
        /// <param name="strExcelFileName">/*即文件目录的路径*/</param>
        /// <param name="sheet">/*表名即文件名（不加扩展名）*/</param>
        /// <returns></returns>
        public DataSet importExcelToDataSet(string strExcelFileName, string sheet)
        {


            DataSet myDataSet = objExcelBaseSQL.importExcelToDataSet(strExcelFileName, sheet);

            return myDataSet;

        }
        /// <summary>
        /// 执行SQL语句
        /// </summary>
        /// <param name="strSql">被执行的SQL语句</param>
        /// <returns>是否成功？</returns>
        public bool ExecSql(string strSql)
        {

            return objExcelBaseSQL.ExecSql(strSql);

        }

        /// <summary>
        /// 功能：获取给定表的记录数.
        /// </summary>
        /// <param name="strTabName">所给定的表名</param>
        /// <returns>记录数，为整型</returns>
        public int funGetRecCount(string strTabName)
        {

            int intRecCount = objExcelBaseSQL.funGetRecCount(strTabName);

            return intRecCount;

        }
       
    }
}
