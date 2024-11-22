using System;
using System.Collections;
using System.Data;
using System.Configuration;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using com.taishsoft.sql;
using System.Collections.Generic;

namespace com.taishsoft.syspara
{
    /// <summary>
    /// clsPubVar 的摘要说明
    /// </summary>
    public class clsPubVar_PubDataBase
    {
        /// <summary>
        /// 
        /// </summary>
        public clsPubVar_PubDataBase()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }
        //public static TzGeneralPlatformDll2.MenuAndPotence objMenuAndPotence = null;// (clsSysPara.ConfigFileName)
        /// <summary>
        /// 
        /// </summary>
        public static Hashtable htSP_ConnectString = new Hashtable();
        /// <summary>
        /// 存储过程列表
        /// </summary>
        public static List<clsSqlStoreProcedure> arrStoreProcedureList = null; //new clsCommonSession();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="strConnectString"></param>
        /// <param name="strSP_Name"></param>
        /// <returns></returns>
        public static clsSqlStoreProcedureEx getSqlStoreProcedure(string strConnectString, string strSP_Name)
        {
            List<clsSqlStoreProcedureEx> arrSPList = htSP_ConnectString[strConnectString] as List<clsSqlStoreProcedureEx>;
            if (arrSPList == null)
            {                
                arrSPList = clsSqlObject.getStoreProceduresAndParamObjList(strConnectString);
                //System.Diagnostics.EventLog.WriteEntry("clsPubVar_PubDataBase_getSqlStoreProcedure", "调用存储过程参数", System.Diagnostics.EventLogEntryType.Information);
                htSP_ConnectString.Add(strConnectString, arrSPList);
            }
            foreach (clsSqlStoreProcedureEx objSqlStoreProcedure in arrSPList)
            {
                if (objSqlStoreProcedure.SP_Name == strSP_Name)
                {
                    return objSqlStoreProcedure;
                }
            }
            StringBuilder sbMessage = new StringBuilder();
            sbMessage.AppendFormat("In SQL, StoreProcedure:{0} is not Exist! Please contact Sql DBA!", strSP_Name);
            throw new Exception(sbMessage.ToString());
        }
    }
}