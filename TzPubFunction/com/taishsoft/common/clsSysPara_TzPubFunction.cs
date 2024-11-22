using System;
//using com.taishsoft.commdbforxml;

namespace com.taishsoft.common
{
	/// <summary>
	/// clsSysPara 的摘要说明。
	/// </summary>
    public class clsSysPara_TzPubFunction
	{
        private static string mstrAppType = "WEBAPP"; //应用类型可以设置两种："WEBAPP","WINAPP"

        public static string AppType
        {
            get {
                return mstrAppType;
            }
            set
            {
                mstrAppType = value;
            }
        }
      
        /// <summary>
        /// 用于定义SQL存储过程的XML文件名称
        /// </summary>
        public static string strXmlSpParaFileName;	//用于定义SQL存储过程的XML文件名称。
        //public static string ConfigFileName;
        //Xml数据源
        public static string strXmlDataSourceFileName = "";
 
        public static bool bolIsUseXmlDataSource = false;

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
        public static string strVersion = "2017.12.21.01";

	}
}
