using System;
using System.Data.SqlClient;
using System.Reflection;
using System.IO;
using System.Collections;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Collections.Generic;

namespace GetAccessFromDataTable
{
    /// <summary>
    /// Class1 的摘要说明。
    /// </summary>
    public partial class clsGetAccessFromDataTable
    {


      
        /// <summary>
        /// 通过Odbc来导出Access,不需要安装Access，通过DataTable, 通过字段列表
        /// </summary>
        /// <param name="objDT">提供的DataTable</param>
        /// <param name="ColumnsNameInDataTable">导出的列名</param>
        /// <param name="FirstRowChineseNames">第一行的中文标题名称</param>
        /// <param name="SavePathAndName">保存的路径文件名</param>
        /// <returns></returns>
        public static bool GetAccessFromDataTableByArr4Odbc(System.Data.DataTable objDT,
            List<string> ColumnsNameInDataTable,
            List<string> FirstRowChineseNames,
            string SavePathAndName)
        {
            string strTableName = "First Sheet";//命名该sheet
            return GetAccessFromDataTableByArr4Odbc(objDT,
           ColumnsNameInDataTable,
           FirstRowChineseNames,
           SavePathAndName, strTableName);

        }


        /// <summary>
        /// 通过Odbc来导出Access,不需要安装Access，,通过DataTable, 通过字段列表
        /// 潘以锋
        /// 修改日期：2008-12-31
        /// </summary>
        /// <param name="objDT">提供的DataTable</param>
        /// <param name="ColumnsNameInDataTable">导出的列名</param>
        /// <param name="FirstRowChineseNames">第一行的中文标题名称</param>
        /// <param name="SavePathAndName">保存的路径文件名</param>
        /// <param name="strSheetName">工作表名称</param>
        /// <returns></returns>
        public static bool GetAccessFromDataTableByArr4Odbc(System.Data.DataTable objDT,
            List<string> ColumnsNameInDataTable,
             List<string> FirstRowChineseNames,
            string SavePathAndName,
            string strSheetName)
        {
            if (File.Exists(SavePathAndName) == false)
            {
                throw new Exception(string.Format("导出初始文件：{0}不存在，请与管理员联系！", SavePathAndName));
            }

            if (CheckColumnsNameIsExist(objDT, ColumnsNameInDataTable) == false)
            {
                return false;
            }
            string strTableName = strSheetName;// "First Sheet";//命名该sheet

            int intRowNum = objDT.Rows.Count;
            if (intRowNum == 0)
            {
                throw new Exception("需要导出的记录数为0，不需要导出！");
            }
            int intColumnNum = objDT.Columns.Count;
            //2 通过循环来写入Access
            StringBuilder strSQL = new StringBuilder();
            //excel 2003格式
            string connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + SavePathAndName + ";";
            //Access 2007格式
            //string connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filepath + ";Extended Properties=Access 12.0 Xml;";

            using (OleDbConnection con = new OleDbConnection(connString))
            {
                try
                {
                    con.Open();
                }
                catch (Exception objException)
                {
                    LogErrorS(objException, "clsGetAccessFromDataTable");
                    StringBuilder sbMsg = new StringBuilder();
                    sbMsg.AppendFormat("(errid:BlEx000034)打开连接出错。(clsGetAccessFromDataTable:GetAccessFromDataTableByArr4Odbc)连接串：{0}，出错信息：{1}。",
                        connString,
                        objException.Message);
                    throw new Exception(sbMsg.ToString(), objException);
                }
                try
                {

                    strSQL.Append("CREATE TABLE ").Append("[" + strTableName + "]");
                    strSQL.Append("(");
                    for (int i = 0; i < FirstRowChineseNames.Count; i++)
                    {
                        string strColName = ColumnsNameInDataTable[i].ToString();
                        if (objDT.Columns[strColName].DataType == System.Type.GetType("System.String"))
                        {
                            strSQL.Append("[" + FirstRowChineseNames[i] + "] text,");
                        }
                        else if (objDT.Columns[strColName].DataType == System.Type.GetType("System.Boolean"))
                        {
                            strSQL.Append("[" + FirstRowChineseNames[i] + "] text,");
                        }
                        else
                        {
                            strSQL.Append("[" + FirstRowChineseNames[i] + "] Int,");
                        }
                    }
                    strSQL = strSQL.Remove(strSQL.Length - 1, 1);
                    strSQL.Append(")");

                    OleDbCommand cmd = new OleDbCommand(strSQL.ToString(), con);
                    cmd.ExecuteNonQuery();

                    for (int i = 0; i < objDT.Rows.Count; i++)
                    {
                        strSQL = new StringBuilder();
                        StringBuilder strfield = new StringBuilder();
                        StringBuilder strvalue = new StringBuilder();
                        for (int j = 0; j < ColumnsNameInDataTable.Count; j++)
                        {
                            string strColName = ColumnsNameInDataTable[j].ToString();
                            string strColValue = objDT.Rows[i][strColName].ToString();
                            strColValue = strColValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"

                            strfield.Append("[" + FirstRowChineseNames[j] + "]");
                            if (objDT.Columns[strColName].DataType == System.Type.GetType("System.String"))
                            {
                                strvalue.Append("'" + strColValue + "'");
                            }
                            else if (objDT.Columns[strColName].DataType == System.Type.GetType("System.Boolean"))
                            {
                                strvalue.Append("'" + strColValue + "'");
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(strColValue) == true)
                                {
                                    strColValue = "-1";
                                }
                                strvalue.Append(strColValue);
                            }
                            if (j != ColumnsNameInDataTable.Count - 1)
                            {
                                strfield.Append(",");
                                strvalue.Append(",");
                            }
                            else
                            {
                            }
                        }
                        cmd.CommandText = strSQL.Append(" insert into [" + strTableName + "]( ")
                        .Append(strfield.ToString())
                        .Append(") values (").Append(strvalue).Append(")").ToString();
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();

                }
                catch (Exception objException)
                {
                    LogErrorS(objException, "clsGetAccessFromDataTable4Odbc");
                    StringBuilder sbMsg = new StringBuilder();
                    sbMsg.AppendFormat("SQL语句：{0}，出错信息：{1}。", strSQL.ToString(), objException.Message);
                    sbMsg.AppendFormat("(errid:BlEx000035)导出Access出错。(clsGetAccessFromDataTable:GetAccessFromDataTableByArr4Odbc)导出SQL语句：{0}，出错信息：{1}。",
                           strSQL.ToString(),
                           objException.Message);
                    throw new Exception(sbMsg.ToString(), objException);
                }
            }
            return true;
        }

    }
}
