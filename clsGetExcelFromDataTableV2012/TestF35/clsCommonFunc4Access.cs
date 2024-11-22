using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace GetAccessFromDataTable
{
    /// <summary>
    /// Class1 的摘要说明。
    /// </summary>
    public partial class clsGetAccessFromDataTable
    {
        /// <summary>
        /// 检查字段名列表是否在DATATABLE中是否存在
        /// </summary>
        /// <param name="objDT">DataTable对象</param>
        /// <param name="ColumnsNameInDataTable">需要检查</param>
        /// <returns></returns>
        public static bool CheckColumnsNameIsExist(System.Data.DataTable objDT,
            List<string> ColumnsNameInDataTable)
        {
            int intColNum = objDT.Columns.Count;
            int iCol;
            bool bolIsExist = false;
            foreach (string strColName in ColumnsNameInDataTable)
            {
                //						tt = ss[i,j];
                bolIsExist = false;
                for (iCol = 0; iCol < intColNum; iCol++)
                {
                    if (objDT.Columns[iCol].ColumnName.ToLower() == strColName.ToLower().Trim())
                    {
                        bolIsExist = true;
                    }
                }
                if (bolIsExist == false)
                {
                    StringBuilder sbMessage = new StringBuilder();
                    sbMessage.AppendFormat("字段：{0}不存在!请检查!", strColName);
                    throw new Exception(sbMessage.ToString());
                }
            }
            return true;
        }


        /// <summary>
        /// 检查字段名列表是否在DATATABLE中是否存在
        /// </summary>
        /// <param name="objDT">DataTable对象</param>
        /// <param name="ColumnsNameInDataTable">需要检查</param>
        /// <returns></returns>
        public static bool CheckColumnsNameIsExist(System.Data.DataTable objDT,
            ArrayList ColumnsNameInDataTable)
        {
            int intColNum = objDT.Columns.Count;
            int iCol;
            bool bolIsExist = false;
            foreach (string strColName in ColumnsNameInDataTable)
            {
                //						tt = ss[i,j];
                bolIsExist = false;
                for (iCol = 0; iCol < intColNum; iCol++)
                {
                    if (objDT.Columns[iCol].ColumnName.ToLower() == strColName.ToLower().Trim())
                    {
                        bolIsExist = true;
                    }
                }
                if (bolIsExist == false)
                {
                    StringBuilder sbMessage = new StringBuilder();
                    sbMessage.AppendFormat("字段：{0}不存在!请检查!", strColName);
                    throw new Exception(sbMessage.ToString());
                }
            }
            return true;
        }

        //静态的处理错误日志的函数
        public static void LogErrorS(Exception objException, string strModuleName)
        {
            //Log the error information to the Application Log
            string strLogMsg;
            try
            {
                strLogMsg = "An error occurred in the following module: "
                    + strModuleName + "Source: " + objException.Source

                    + "Message: " + objException.Message
                    + "Stack Trace:  " + objException.StackTrace

                    + "Target Site:  " + objException.TargetSite.ToString();

                //Write error to event log
                System.Diagnostics.EventLog.WriteEntry(strModuleName, strLogMsg, System.Diagnostics.EventLogEntryType.Error);
            }
            catch
            {
            }
        }

    }
}
