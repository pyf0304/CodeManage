using System;
using System.Configuration;
using com.taishsoft.common;
using com.taishsoft.comm_db_obj;
using com.taishsoft.encrypt;
using SpecData;
using System.Collections;
namespace com.taishsoft.commdb
{
    /// <summary>
    /// clsSpecSQLforSql 的摘要说明。
    /// </summary>
    public class clsSpecSQLforSql : clsSqlEx
    {
        public static bool IsUseBackupConnect
        {
            get { return clsSqlEx.IsUseBackupConnect; }
            set
            {
                clsSqlEx.IsUseBackupConnect = value;

            }
        }

        public static string strAppType
        {
            get { return clsSqlEx.AppType; }
            set
            {
                clsSqlEx.AppType = value;

            }
        }
        
        //private static string mstrWebRoot = "";   //@"\AGC_CSV5\ConnStr\";

        public static string strWebRoot
        {
            get { return clsSqlEx.WebRoot; }
            set
            {
                clsSqlEx.WebRoot = value;

            }
        }


        //private static string mstrConnectString = "";

        public static string strConnectString
        {
            get { return clsSqlEx.ConnectString; }
            set
            {

                clsSqlEx.ConnectString = value;
            }
        }

        public static string strConnectString2
        {
            get { return clsSqlEx.ConnectString2; }
            set
            {

                clsSqlEx.ConnectString2 = value;
            }
        }
        public string strConnStr;
        public string strConnStr2;

        public clsSpecSQLforSql()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
            //p_sConnectString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString1"];		//主要是202.121.51.55
            //p_sConnectString = "server=202.121.51.55;uid=pyf;pwd=a1b2c3;database=AGC_CSV4";

            //p_sConnectString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString2"];		//主要是本机：202.121.51.50

            //获取连接串
            if (clsSpecSQLforSql.strAppType == clsAppType.NetCoreWebApi)
            {
                if (clsSpecSQLforSql.IsUseBackupConnect == true)
                {
                    p_sConnectString = clsSpecSQLforSql.ConnectStringBackup;
                }
                else
                {
                    p_sConnectString = clsSpecSQLforSql.ConnectString;
                }
                return;
            }
            else
            {
                GetConnectStringFromConfig();
            }
        }
        public clsSpecSQLforSql(string server, string database, string uid, string pwd)
            : base(server, database, uid, pwd)
        {

        }
        public clsSpecSQLforSql(string strConnectString)
            : base(strConnectString)
        {

        }
        public clsSpecSQLforSql(string strConnectStringName, bool bolIsUseConnStrName)
            : base(strConnectStringName, bolIsUseConnStrName)
        {

        }
        private void GetConnectStringFromConfig()
        {
            //			p_sConnectString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString4"];
            if (clsSpecSQLforSql.strAppType == clsAppType.NetCoreWebApi)
            {
                if (clsSpecSQLforSql.IsUseBackupConnect == true)
                {
                    p_sConnectString = clsSpecSQLforSql.ConnectStringBackup;
                }
                else
                {
                    p_sConnectString = clsSpecSQLforSql.ConnectString;
                }
                return;
            }
            else if (clsSpecSQLforSql.strAppType == clsAppType.CONTROL)
            {
                if (clsSpecSQLforSql.IsUseBackupConnect == true)
                {
                    p_sConnectString = clsSpecSQLforSql.ConnectStringBackup;
                }
                else
                {
                    p_sConnectString = clsSpecSQLforSql.ConnectString;
                }
                return;
            }
            else if (clsSpecSQLforSql.strAppType == clsAppType.WEBAPP)
            {

                if (string.IsNullOrEmpty(clsSpecSQLforSql.strWebRoot) == true)
                {
                    throw new Exception("clsSpecSQLforSql.strWebRoot为空，请在Global.asax中设置该值，或者在该项目的起始页中设置该值。否则无法运行！！！");
                }
                if (clsSqlEx.IsUseEncrypt == true)
                {
                    string strWebConfigFile = clsSqlEx.WebConfigFileName;
                    p_sConnectString = new clsEncrypt().GetConnectStringForEncrypt(strWebConfigFile, "connectionStrings/add");
                    //p_sConnectString2 = new clsEncrypt().GetConnectStringForEncrypt(strWebConfigFile, "connectionStrings2/add");
                }
                else
                {
                    System.Configuration.Configuration rootWebConfig =
        System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration(clsSpecSQLforSql.strWebRoot);
                    System.Configuration.ConnectionStringSettings connString;
                    if (0 == rootWebConfig.ConnectionStrings.ConnectionStrings.Count)
                    {
                        throw new Exception("在Web.Config中没有连接字符串！请检查！");
                    }
                    if (0 < rootWebConfig.ConnectionStrings.ConnectionStrings.Count)
                    {
                        if (string.IsNullOrEmpty(mstrConnectStrName) == true)
                        {
                            if (clsSpecSQLforSql.IsUseBackupConnect == true)
                            {
                                connString =
                        rootWebConfig.ConnectionStrings.ConnectionStrings["ConnectionStringBackup"];
                            }
                            else
                            {
                                connString =
                                rootWebConfig.ConnectionStrings.ConnectionStrings["ConnectionString"];
                            }
                        }
                        else
                        {
                            connString =
                                rootWebConfig.ConnectionStrings.ConnectionStrings[mstrConnectStrName];
                        }
                        if (null != connString)
                        {
                            Console.WriteLine("Local connection string = \"{0}\"",
                                connString.ConnectionString);
                            p_sConnectString = connString.ConnectionString;
                        }
                        else
                        {
                            Console.WriteLine("No Local connection string");
                            throw new Exception("连接串为空！请检查！");
                        }

                        //AppSetting = rootWebConfig.AppSettings["ConnectionString1"];	
                    }
                }
            }
            else if (clsSpecSQLforSql.strAppType == clsAppType.WINAPP)
            {
                //                p_sConnectString = new ConnectString().ConntectionString;
                //                p_sConnectString = System.Configuration.ConfigurationManager.ConnectionStrings["ImportFileToSQL.Settings1.ConnectionString"].ToString();
                if (clsSqlEx.IsUseEncrypt == true)
                {
                    string strApplicationConfigFile = clsApplicatoin.ExecutablePath + ".config";
                    p_sConnectString = new clsEncrypt().GetConnectStringForEncrypt(strApplicationConfigFile, "connectionStrings/add");
                    //p_sConnectString2 = new clsEncrypt().GetConnectStringForEncrypt(strApplicationConfigFile, "connectionStrings2/add");
                }
                else
                {
                    if (clsSpecSQLforSql.IsUseBackupConnect == true)
                    {
                        //p_sConnectString = clsSpecSQLforSql.ConnectStringBackup;
                        p_sConnectString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionStringBackup"].ToString();
                    }
                    else
                    {
                        p_sConnectString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
                    }
                    //p_sConnectString2 = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString2"].ToString();

                    ConnectionStringSettingsCollection connectionStrings = ConfigurationManager.ConnectionStrings;


                    int i = 0;
                    Console.WriteLine("Connection strings.");
                    if (arrConnectStrObjLst == null)
                    {
                        arrConnectStrObjLst = new System.Collections.Generic.List<clsConnectStrObj>();
                    }
                    while (i < connectionStrings.Count)
                    {
                        clsConnectStrObj objConnect = new clsConnectStrObj();
                        objConnect.ConnectStringName = connectionStrings[i].Name;
                        objConnect.ConnectStringValue = connectionStrings[i].ConnectionString;
                        objConnect.ConnectStringProviderName = connectionStrings[i].ProviderName;
                        if (IsExistConnectStringName(objConnect.ConnectStringName) == false)
                        {
                            arrConnectStrObjLst.Add(objConnect);
                        }
                        //string name = connectionStrings[i].Name;
                        Console.WriteLine("Name: {0} Value: {1}",
                        objConnect.ConnectStringName, objConnect.ConnectStringValue);
                        i += 1;
                    }
                }

                //                p_sConnectString = new SpecData.Properties.Settings().ConnectionString;
                strConnStr = p_sConnectString;
                //strConnStr2 = p_sConnectString2;
            }
            else if (clsSpecSQLforSql.strAppType == "WEBWPF")
            {
                //                p_sConnectString = new ConnectString().ConntectionString;
                //                p_sConnectString = System.Configuration.ConfigurationManager.ConnectionStrings["ImportFileToSQL.Settings1.ConnectionString"].ToString();
                if (clsSqlEx.IsUseEncrypt == true)
                {
                    string strApplicationConfigFile = clsApplicatoin.ExecutablePath + ".config";
                    p_sConnectString = new clsEncrypt().GetConnectStringForEncrypt(strApplicationConfigFile, "connectionStrings/add");
                    //p_sConnectString2 = new clsEncrypt().GetConnectStringForEncrypt(strApplicationConfigFile, "connectionStrings2/add");
                }
                else
                {
                    p_sConnectString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
                    //p_sConnectString2 = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString2"].ToString();

                    ConnectionStringSettingsCollection connectionStrings = ConfigurationManager.ConnectionStrings;


                    int i = 0;
                    Console.WriteLine("Connection strings.");
                    if (arrConnectStrObjLst == null)
                    {
                        arrConnectStrObjLst = new System.Collections.Generic.List<clsConnectStrObj>();
                    }
                    while (i < connectionStrings.Count)
                    {
                        clsConnectStrObj objConnect = new clsConnectStrObj();
                        objConnect.ConnectStringName = connectionStrings[i].Name;
                        objConnect.ConnectStringValue = connectionStrings[i].ConnectionString;
                        objConnect.ConnectStringProviderName = connectionStrings[i].ProviderName;
                        if (IsExistConnectStringName(objConnect.ConnectStringName) == false)
                        {
                            arrConnectStrObjLst.Add(objConnect);
                        }
                        //string name = connectionStrings[i].Name;
                        Console.WriteLine("Name: {0} Value: {1}",
                        objConnect.ConnectStringName, objConnect.ConnectStringValue);
                        i += 1;
                    }
                }

                //                p_sConnectString = new SpecData.Properties.Settings().ConnectionString;
                strConnStr = p_sConnectString;
                //strConnStr2 = p_sConnectString2;
            }

            clsSpecSQLforSql.strConnectString = p_sConnectString;
            //clsSpecSQLforSql.strConnectString2 = p_sConnectString2;

        }
        public static bool IsExistConnectStringName(string strConnectStringName)
        {
            foreach (clsConnectStrObj objConnectStrObj in arrConnectStrObjLst)
            {
                if (objConnectStrObj.ConnectStringName == strConnectStringName)
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// 获取Web.Config文件中的连接串
        /// </summary>
        /// <param name="strConnectStrName">连接串名，如果为空就获取默认的连接串</param>
        /// <returns>获取的连接串</returns>
        public static string GetConnectStringFromConfig(string strConnectStrName)
        {
            string strConnectString = "";
            if (clsSpecSQLforSql.strAppType == clsAppType.CONTROL)
            {
                return clsSpecSQLforSql.ConnectString;
            }
            else if (clsSpecSQLforSql.strAppType == clsAppType.WEBAPP)
            {

                if (string.IsNullOrEmpty(clsSpecSQLforSql.strWebRoot) == true)
                {
                    throw new Exception("clsSpecSQLforSql.strWebRoot为空，请在Global.asax中设置该值，或者在该项目的起始页中设置该值。否则无法运行！！！");
                }
                if (clsSqlEx.IsUseEncrypt == true)
                {
                    string strWebConfigFile = clsSqlEx.WebConfigFileName;
                    strConnectString = new clsEncrypt().GetConnectStringForEncrypt(strWebConfigFile, "connectionStrings/add");
                    //p_sConnectString2 = new clsEncrypt().GetConnectStringForEncrypt(strWebConfigFile, "connectionStrings2/add");
                }
                else
                {
                    System.Configuration.Configuration rootWebConfig =
        System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration(clsSpecSQLforSql.strWebRoot);
                    System.Configuration.ConnectionStringSettings connString;
                    if (0 == rootWebConfig.ConnectionStrings.ConnectionStrings.Count)
                    {
                        throw new Exception("在Web.Config中没有连接字符串！请检查！");
                    }
                    if (0 < rootWebConfig.ConnectionStrings.ConnectionStrings.Count)
                    {
                        if (string.IsNullOrEmpty(strConnectStrName) == true)
                        {
                            connString =
                                rootWebConfig.ConnectionStrings.ConnectionStrings["ConnectionString"];
                        }
                        else
                        {
                            connString =
                                rootWebConfig.ConnectionStrings.ConnectionStrings[strConnectStrName];
                        }
                        if (null != connString)
                        {
                            Console.WriteLine("Local connection string = \"{0}\"",
                                connString.ConnectionString);
                            strConnectString = connString.ConnectionString;
                        }
                        else
                        {
                            Console.WriteLine("No Local connection string");
                            throw new Exception("连接串为空！请检查！");
                        }


                    }
                }
            }
            else if (clsSpecSQLforSql.strAppType == clsAppType.WINAPP)
            {
                if (clsSqlEx.IsUseEncrypt == true)
                {
                    string strApplicationConfigFile = clsApplicatoin.ExecutablePath + ".config";
                    strConnectString = new clsEncrypt().GetConnectStringForEncrypt(strApplicationConfigFile, "connectionStrings/add");
                }
                else
                {
                    strConnectString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();

                    ConnectionStringSettingsCollection connectionStrings = ConfigurationManager.ConnectionStrings;


                    int i = 0;
                    Console.WriteLine("Connection strings.");
                    if (arrConnectStrObjLst == null)
                    {
                        arrConnectStrObjLst = new System.Collections.Generic.List<clsConnectStrObj>();
                    }
                    while (i < connectionStrings.Count)
                    {
                        clsConnectStrObj objConnect = new clsConnectStrObj();
                        objConnect.ConnectStringName = connectionStrings[i].Name;
                        objConnect.ConnectStringValue = connectionStrings[i].ConnectionString;
                        objConnect.ConnectStringProviderName = connectionStrings[i].ProviderName;
                        if (IsExistConnectStringName(objConnect.ConnectStringName) == false)
                        {
                            arrConnectStrObjLst.Add(objConnect);
                        }

                        Console.WriteLine("Name: {0} Value: {1}",
                        objConnect.ConnectStringName, objConnect.ConnectStringValue);
                        i += 1;
                    }
                }

            }
            else if (clsSpecSQLforSql.strAppType == "WEBWPF")
            {
                if (clsSqlEx.IsUseEncrypt == true)
                {
                    string strApplicationConfigFile = clsApplicatoin.ExecutablePath + ".config";
                    strConnectString = new clsEncrypt().GetConnectStringForEncrypt(strApplicationConfigFile, "connectionStrings/add");
                }
                else
                {
                    strConnectString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();

                    ConnectionStringSettingsCollection connectionStrings = ConfigurationManager.ConnectionStrings;


                    int i = 0;
                    Console.WriteLine("Connection strings.");
                    if (arrConnectStrObjLst == null)
                    {
                        arrConnectStrObjLst = new System.Collections.Generic.List<clsConnectStrObj>();
                    } 
                    while (i < connectionStrings.Count)
                    {
                        clsConnectStrObj objConnect = new clsConnectStrObj();
                        objConnect.ConnectStringName = connectionStrings[i].Name;
                        objConnect.ConnectStringValue = connectionStrings[i].ConnectionString;
                        objConnect.ConnectStringProviderName = connectionStrings[i].ProviderName;
                        if (IsExistConnectStringName(objConnect.ConnectStringName) == false)
                        {
                            arrConnectStrObjLst.Add(objConnect);
                        }
                        //string name = connectionStrings[i].Name;
                        Console.WriteLine("Name: {0} Value: {1}",
                        objConnect.ConnectStringName, objConnect.ConnectStringValue);
                        i += 1;
                    }
                }
            }
            return strConnectString;
        }

    }
}
