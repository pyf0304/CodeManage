using System;
using com.taishsoft.commdbforxml;

namespace com.taishsoft.syspara
{
	/// <summary>
	/// clsSysPara 的摘要说明。
	/// </summary>
	public class clsSysPara_PubDataBase
	{
        /// <summary>
        /// 用于定义SQL存储过程的XML文件名称
        /// </summary>
        public static string strXmlSpParaFileName;	//用于定义SQL存储过程的XML文件名称。
       
        public static clsSpecSQLforXml objSpecSqlForXml = null;

        ///连接串名称
        public static string strConnectStrName = "";
        /// <summary>
        /// 是否使用连接串名
        /// </summary>
        public static bool bolIsUseConnectStrName = false;

        /// <summary>
        /// 用户ID
        /// </summary>
        public static string strUserId = "";
        /// <summary>
        /// 连接串
        /// </summary>
        public static string strConnectString = "";
        /// <summary>
        /// PubDataBase的版本
        /// </summary>
        public static string strVersion = "2019.03.07.01";

	}
}
