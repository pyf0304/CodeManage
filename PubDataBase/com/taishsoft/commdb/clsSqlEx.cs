using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using com.taishsoft.encrypt;
using com.taishsoft.common;
using System.Configuration;
using com.taishsoft.comm_db_obj;
using System.Collections.Generic;
using com.taishsoft.datetime;

namespace com.taishsoft.commdb
{
    /// <summary>
    /// clsSqlEx 的摘要说明。
    /// </summary>
    public class clsSqlEx : clsSQL
    {
        private static System.Data.DataTable objDT_Object = null;
        private static string mstrGetDate_Object = "";
        private static string mstrTabName_Object = "";
        //连接串所在的文件名
        private static string mstrConnectStrFileName = "";
        private static string mstrLanguage = "CH";
        private static bool m_bolIsUseBackupConnect;

        public static string Language
        {
            get { return clsSqlEx.mstrLanguage; }
            set { clsSqlEx.mstrLanguage = value; }
        }

        ///连接串名称
        public static string strConnectStrName = "";
        /// <summary>
        /// 是否使用连接串名称
        /// </summary>
        public static bool bolIsUseConnectStrName = false;
        /// <summary>
        /// 连接串对象列表
        /// </summary>
        protected static List<clsConnectStrObj> arrConnectStrObjLst = null;
        /// <summary>
        /// 从配置文件(Web.Config)中获取连接串对象列表
        /// </summary>
        /// <returns></returns>
        public static bool GetConnectStrObjLst()
        {
            if (arrConnectStrObjLst == null)
            {
                arrConnectStrObjLst = new List<clsConnectStrObj>();
            }
            //			p_sConnectString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString4"];
            switch (clsSpecSQLforSql.strAppType)
            {
                case "WEBAPP":


                    if (string.IsNullOrEmpty(clsSpecSQLforSql.strWebRoot) == true)
                    {
                        throw new Exception("clsSpecSQLforSql.strWebRoot为空，请在Global.asax中设置该值，或者在该项目的起始页中设置该值。否则无法运行！！！");
                    }
                    if (clsSqlEx.IsUseEncrypt == true)
                    {
                        string strWebConfigFile = clsSqlEx.WebConfigFileName;
                        mstrConnectStrFileName = strWebConfigFile;
                        List<clsConnectStrObj> arrConnectStrObjLst_p = new List<clsConnectStrObj>();
                        arrConnectStrObjLst_p = new clsEncrypt().GetConnectStringForEncryptEx(
                            strWebConfigFile,
                            "connectionStrings/add");

                        foreach (clsConnectStrObj objConnectStrObj in arrConnectStrObjLst_p)
                        {
                            if (IsExistConnectStringName(objConnectStrObj.ConnectStringName) == false)
                            {
                                arrConnectStrObjLst.Add(objConnectStrObj);
                            }
                        }

                    }
                    else
                    {
                        System.Configuration.Configuration rootWebConfig =
            System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration(clsSpecSQLforSql.strWebRoot);
                        mstrConnectStrFileName = clsSpecSQLforSql.strWebRoot;
                        ConnectionStringSettingsCollection connectionStrings = rootWebConfig.ConnectionStrings.ConnectionStrings;// ConfigurationManager.ConnectionStrings;


                        int i = 0;
                        Console.WriteLine("Connection strings.");
                        //arrConnectStrObjLst = new List<clsConnectStrObj>();
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
                    break;
                case "WINAPP":

                    if (clsSqlEx.IsUseEncrypt == true)
                    {
                        string strApplicationConfigFile = clsApplicatoin.ExecutablePath + ".config";
                        mstrConnectStrFileName = strApplicationConfigFile;
                        List<clsConnectStrObj> arrConnectStrObjLst_p = new List<clsConnectStrObj>();
                        arrConnectStrObjLst_p = new clsEncrypt().GetConnectStringForEncryptEx(
                            strApplicationConfigFile,
                            "connectionStrings/add");

                        foreach (clsConnectStrObj objConnectStrObj in arrConnectStrObjLst_p)
                        {
                            if (IsExistConnectStringName(objConnectStrObj.ConnectStringName) == false)
                            {
                                arrConnectStrObjLst.Add(objConnectStrObj);
                            }
                        }

                    }
                    else
                    {
                        ConnectionStringSettingsCollection connectionStrings = ConfigurationManager.ConnectionStrings;
                        string strApplicationConfigFile = clsApplicatoin.ExecutablePath + ".config";
                        mstrConnectStrFileName = strApplicationConfigFile;
                        int i = 0;
                        Console.WriteLine("Connection strings.");
                        //arrConnectStrObjLst = new List<clsConnectStrObj>();
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
                    break;
                case "DynamicCompiler":
                    break;
                default:
                    break;
            }
            return true;
        }

        /// <summary>
        /// 添加自定义的连接串对象
        /// </summary>
        /// <param name="strConnectStringName">连接串名称</param>
        /// <param name="strConnectStringValue">连接串值</param>
        /// <param name="strConnectStringProviderName">连接提供者</param>
        /// <returns>是否成功</returns>
        public static bool AddConnectStrObj(string strConnectStringName,
            string strConnectStringValue,
            string strConnectStringProviderName)
        {
            if (arrConnectStrObjLst == null)
            {
                GetConnectStrObjLst();
                //                arrConnectStrObjLst = new List<clsConnectStrObj>();
            }
            //			p_sConnectString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString4"];

            clsConnectStrObj objConnect = new clsConnectStrObj();
            objConnect.ConnectStringName = strConnectStringName;
            objConnect.ConnectStringValue = strConnectStringValue;
            objConnect.ConnectStringProviderName = strConnectStringProviderName;
            if (IsExistConnectStringName(objConnect.ConnectStringName) == false)
            {
                arrConnectStrObjLst.Add(objConnect);
            }
            //string name = connectionStrings[i].Name;
            Console.WriteLine("Name: {0} Value: {1}",
            objConnect.ConnectStringName, objConnect.ConnectStringValue);

            return true;
        }

        /// <summary>
        /// 添加自定义的连接串对象
        /// </summary>
        /// <param name="objConnectStrObj">连接串对象</param>
        /// <returns>是否成功</returns>
        public static bool AddConnectStrObj(clsConnectStrObj objConnectStrObj)
        {
            if (arrConnectStrObjLst == null)
            {
                GetConnectStrObjLst();
                //                arrConnectStrObjLst = new List<clsConnectStrObj>();
            }
            //			p_sConnectString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString4"];

            if (IsExistConnectStringName(objConnectStrObj.ConnectStringName) == false)
            {
                arrConnectStrObjLst.Add(objConnectStrObj);
            }
            //string name = connectionStrings[i].Name;
            Console.WriteLine("Name: {0} Value: {1}",
            objConnectStrObj.ConnectStringName, objConnectStrObj.ConnectStringValue);

            return true;
        }
        /// <summary>
        /// 通过连接串的名称获取连接串对象
        /// </summary>
        /// <param name="strConnectStrName">连接串名称</param>
        /// <returns>获取的连接串对象</returns>
        public static clsConnectStrObj GetConnectStrObjByName(string strConnectStrName)
        {
            if (arrConnectStrObjLst == null)
            {
                GetConnectStrObjLst();
            }

            if (arrConnectStrObjLst == null) return null;
            if (arrConnectStrObjLst.Count == 0) return null;
            foreach (clsConnectStrObj objConnect in arrConnectStrObjLst)
            {
                if (objConnect.ConnectStringName == strConnectStrName)
                {
                    return objConnect;
                }
            }
            return null;
        }
        public static string GetConnectStrByName(string strConnectStrName)
        {
            if (arrConnectStrObjLst == null)
            {
                GetConnectStrObjLst();
            }

            if (arrConnectStrObjLst == null) return "";
            if (arrConnectStrObjLst.Count == 0) return "";
            string strCurrStrName = "";
            foreach (clsConnectStrObj objConnect in arrConnectStrObjLst)
            {
                strCurrStrName += string.Format("{0},", objConnect.ConnectStringName);
                if (objConnect.ConnectStringName == strConnectStrName)
                {
                    return objConnect.ConnectStringValue;
                }
            }
            string strMsg = string.Format("当前连接串对象列表中不存在:[{0}]的连接对象。当前连接串列表为:{1}.({2})", strConnectStrName, strCurrStrName, clsStackTrace.GetCurrClassFunction());
            throw new Exception(strMsg);
            return "";
        }
        public static string GetConnectStrByIndex(int intIndex)
        {
            if (arrConnectStrObjLst == null)
            {
                GetConnectStrObjLst();
            }

            if (arrConnectStrObjLst == null) return "";
            if (arrConnectStrObjLst.Count == 0) return "";
            if (arrConnectStrObjLst.Count < intIndex + 1) return "";
            clsConnectStrObj objConnect = arrConnectStrObjLst[intIndex] as clsConnectStrObj;
            return objConnect.ConnectStringValue;
        }
        private static string mstrAppType = "WEBAPP"; //应用类型可以设置两种："WEBAPP","WINAPP"
        public static bool IsUseBackupConnect
        {
            get { return clsSqlEx.m_bolIsUseBackupConnect; }
            set
            {
                clsSqlEx.m_bolIsUseBackupConnect = value;
            }
        }

        public static string AppType
        {
            get { return clsSqlEx.mstrAppType; }
            set
            {
                clsSqlEx.mstrAppType = value;
            }
        }

       
        private static string mstrWebRoot = "";   //@"\AGC_CSV5\ConnStr\";

        public static string WebRoot
        {
            get { return clsSqlEx.mstrWebRoot; }
            set
            {
                clsSqlEx.mstrWebRoot = value;
            }
        }

        private static string mstrWebConfigFileName;

        public static string WebConfigFileName
        {
            get { return clsSqlEx.mstrWebConfigFileName; }
            set { clsSqlEx.mstrWebConfigFileName = value; }
        }

        private static bool mbolIsUseEncrypt = false;//是否使用加密连接串

        public static bool IsUseEncrypt
        {
            get { return clsSqlEx.mbolIsUseEncrypt; }
            set { clsSqlEx.mbolIsUseEncrypt = value; }
        }

        private static string mstrConnectString = "";
        /// <summary>
        /// 主要连接
        /// </summary>
        public static string ConnectString
        {
            get { return clsSqlEx.mstrConnectString; }
            set
            {
                clsSqlEx.mstrConnectString = value;
            }
        }

        private static string mstrConnectStringBackup = "";
        /// <summary>
        /// 备用连接
        /// </summary>
        public static string ConnectStringBackup
        {
            get { return clsSqlEx.mstrConnectStringBackup; }
            set
            {
                clsSqlEx.mstrConnectStringBackup = value;
            }
        }

        private static string mstrConnectString2 = "";

        public static string ConnectString2
        {
            get { return clsSqlEx.mstrConnectString2; }
            set
            {
                clsSqlEx.mstrConnectString2 = value;
            }
        }
        //连接串名
        protected string mstrConnectStrName = "";
        /// <summary>
        /// 连接串名称
        /// </summary>
        public string ConnectStrName
        {
            get { return mstrConnectStrName; }
            set
            {
                mstrConnectStrName = value;
                if (string.IsNullOrEmpty(mstrConnectStrName) == false)
                {
                    GetConnectStringFromConfigWithConnStrName();
                }
            }
        }
        /// <summary>
        /// 连接串所在的文件名
        /// </summary>
        public static string ConnectStrFileName
        {
            get
            {
                return mstrConnectStrFileName;
            }

            set
            {
                mstrConnectStrFileName = value;
            }
        }

        /// <summary>
        /// 从Web.config配置文件获取连接串,同时使用连接串名称
        /// </summary>
        private void GetConnectStringFromConfigWithConnStrName()
        {
            //			p_sConnectString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString4"];
            if (clsSpecSQLforSql.strAppType == "WEBAPP")
            {

                if (string.IsNullOrEmpty(clsSpecSQLforSql.strWebRoot) == true)
                {
                    throw new Exception("clsSpecSQLforSql.strWebRoot为空，请在Global.asax中设置该值，或者在该项目的起始页中设置该值。否则无法运行！！！");
                }
                if (clsSqlEx.IsUseEncrypt == true)
                {
                    string strWebConfigFile = clsSqlEx.WebConfigFileName;
                    p_sConnectString = new clsEncrypt().GetConnectStringForEncrypt(
                        strWebConfigFile,
                        "connectionStrings/add",
                        mstrConnectStrName);
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
                        connString =
                            rootWebConfig.ConnectionStrings.ConnectionStrings[mstrConnectStrName];
                        if (null != connString)
                        {
                            Console.WriteLine("Local connection string = \"{0}\"",
                                connString.ConnectionString);
                            p_sConnectString = connString.ConnectionString;
                        }
                        else
                        {
                            Console.WriteLine("No Local connection string");
                            throw new Exception(string.Format("在配置文件:{1}中,连接名称:{0}所指定的连接串为空！请检查！",
                                mstrConnectStrName,
                                clsSpecSQLforSql.strWebRoot));
                        }
                    }
                }
            }
            else if (clsSpecSQLforSql.strAppType == "WINAPP")
            {
                if (clsSqlEx.IsUseEncrypt == true)
                {
                    string strApplicationConfigFile = clsApplicatoin.ExecutablePath + ".config";
                    p_sConnectString = new clsEncrypt().GetConnectStringForEncrypt(
                        strApplicationConfigFile,
                        "connectionStrings/add",
                        mstrConnectStrName);
                    List<clsConnectStrObj> arrConnectStrObjLst_p = new List<clsConnectStrObj>();
                    arrConnectStrObjLst_p = new clsEncrypt().GetConnectStringForEncryptEx(
                        strApplicationConfigFile,
                        "connectionStrings/add");
                    foreach (clsConnectStrObj objConnectStrObj in arrConnectStrObjLst_p)
                    {
                        if (IsExistConnectStringName(objConnectStrObj.ConnectStringName) == false)
                        {
                            arrConnectStrObjLst.Add(objConnectStrObj);
                        }
                    }
                }
                else
                {
                    p_sConnectString = System.Configuration.ConfigurationManager.ConnectionStrings[mstrConnectStrName].ToString();
                    ConnectionStringSettingsCollection connectionStrings = ConfigurationManager.ConnectionStrings;


                    int i = 0;
                    Console.WriteLine("Connection strings.");
                    //ArrayList arrConnectStrObjLst = new ArrayList();
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
        public clsSqlEx()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }
        public clsSqlEx(string strConnectString)
            : base(strConnectString)
        {

        }
        public clsSqlEx(string strConnectStringName, bool bolIsUseConnStrName)
        {
            if (bolIsUseConnStrName == true)
            {
                mstrConnectStrName = strConnectStringName;
                //多配置文件中获取连接串
                //GetConnectStringFromConfigWithConnStrName();
                p_sConnectString = clsSqlEx.GetConnectStrByName(mstrConnectStrName);
                //this.ConnectionString

            }
        }
        public clsSqlEx(string server, string database, string uid, string pwd)
            : base(server, database, uid, pwd)
        {

        }
        /// <summary>
        /// 获取指定服务器的所有数据库
        /// </summary>
        /// <returns>返回所有数据库的DataTable</returns>
        public System.Data.DataTable getDataBases()
        {
            System.Data.DataTable objDT;
            string strSQL;
            strSQL = "Select name from sysdatabases order by name";
            objDT = GetDataTable(strSQL);
            return objDT;

        }


        /// <summary>
        /// 获取所定的服务器和数据库中所有表名。
        /// </summary>
        /// <returns>所有表名的DataTable</returns>
        public System.Data.DataTable getTables()
        {
            System.Data.DataTable objDT;
            string strSQL;

            strSQL = "Select * from sysobjects where xtype='U'  order by name";
            objDT = GetDataTable(strSQL);
            return objDT;
        }

        /// <summary>
        /// 获取所定的服务器和数据库中所有表名。
        /// </summary>
        /// <returns>所有存储过程名的DataTable</returns>
        public System.Data.DataTable getTablesByOwner(string strOwner)
        {
            System.Data.DataTable objDT;
            string strSQL;

            //            strSQL = string .Format("Select * from sysobjects where xtype='U' and uid in (select uid from sysusers where name = '{0}') order by name", strOwner);
            strSQL = string.Format("sp_Tables null, '{0}'", strOwner);
            objDT = GetDataTable(strSQL);
            return objDT;
        }

        /// <summary>
        /// 获取所定的服务器和数据库中所有存储过程名。
        /// </summary>
        /// <returns>所有存储过程名的DataTable</returns>
        public System.Data.DataTable getStoreProcedures()
        {
            System.Data.DataTable objDT;
            string strSQL;

            strSQL = "Select * from sysobjects where xtype='P'  order by name";
            objDT = GetDataTable(strSQL);
            return objDT;
        }

        /// <summary>
        /// 获取所定的服务器和数据库中所有存储过程名。
        /// </summary>
        /// <returns>所有存储过程名的DataTable</returns>
        public System.Data.DataTable getStoreProceduresByCond(string strCondition)
        {
            System.Data.DataTable objDT;
            StringBuilder sbSQL = new StringBuilder();

            sbSQL.Append("Select * from sysobjects ");
            sbSQL.AppendFormat(" where xtype='P' and {0}", strCondition);
            sbSQL.Append("  order by name");
            objDT = GetDataTable(sbSQL.ToString());
            return objDT;
        }

        /// <summary>
        /// 获取一个表的最大标识值（Identity）
        /// 作者：潘以锋
        /// 日期：20101022
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <returns>最大标识值</returns>
        public int GetTablesMaxIdentity(string tableName)
        {
            int num = 0;
            using (DataTable table = this.GetDataTable("SELECT IDENT_CURRENT('" + tableName + "') AS Ident"))
            {
                if (table.Rows.Count == 0)
                {
                    return 0;
                }
                foreach (DataRow row in table.Rows)
                {
                    num = int.Parse(row["Ident"].ToString().Trim());
                }
            }
            return num;
        }

        /// <summary>
        /// 获取一个表的最大标识值（Identity）,用长整型返回
        /// 作者：潘以锋
        /// 日期：20101022
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <returns>最大标识值</returns>
        public long GetTablesMaxIdentity_Long(string tableName)
        {
            long lngNum = 0;
            using (DataTable table = this.GetDataTable("SELECT IDENT_CURRENT('" + tableName + "') AS Ident"))
            {
                if (table.Rows.Count == 0)
                {
                    return 0;
                }
                foreach (DataRow row in table.Rows)
                {
                    lngNum = long.Parse(row["Ident"].ToString().Trim());
                }
            }
            return lngNum;
        }

        /// <summary>
        /// 获取所定的服务器和数据库中某拥有者的所有存储过程名。
        /// </summary>
        /// <returns>所有表名的DataTable</returns>
        public System.Data.DataTable getStoreProceduresByOwner(string strOwner)
        {
            System.Data.DataTable objDT;
            string strSQL;

            strSQL = string.Format("Select * from sysobjects where xtype='P' and uid in (select uid from sysusers where name = '{0}') order by name", strOwner);
            objDT = GetDataTable(strSQL);
            return objDT;
        }

        /// <summary>
        /// 获取所定的服务器和数据库中某拥有者的所有存储过程名。
        /// </summary>
        /// <returns>所有表名的DataTable</returns>
        public System.Data.DataTable getStoreProceduresByOwnerByCond(string strOwner, string strCondition)
        {
            System.Data.DataTable objDT;
            StringBuilder sbSQL = new StringBuilder();

            sbSQL.Append("Select * from sysobjects ");
            sbSQL.AppendFormat(" where xtype='P' and {0}", strCondition);
            sbSQL.AppendFormat(" and uid in (select uid from sysusers where name = '{0}') order by name", strOwner);
            objDT = GetDataTable(sbSQL.ToString());
            return objDT;
        }
        /// <summary>
        /// 获取所定的服务器和数据库中所有存储过程参数名。
        /// </summary>
        /// <returns>所有存储过程参数名的DataTable</returns>
        public System.Data.DataTable getSp_ParaAll()
        {
            System.Data.DataTable objDT;
            StringBuilder sbSQL = new StringBuilder();

            sbSQL.Append("select ParaName=a.name ");
            sbSQL.Append(", ParaDataType=b.name ");
            sbSQL.Append(", ParaSize = a.length");
            sbSQL.Append(", ParaDirection = IsOutParam");
            sbSQL.Append(", IsNullable");
            sbSQL.Append(", a.* ");
            sbSQL.Append("from syscolumns a join systypes b on a.xtype=b.xusertype ");
            sbSQL.Append("where id in (select id from sysobjects where xtype='P')");
            sbSQL.Append(" order by id, colorder");
            objDT = GetDataTable(sbSQL.ToString());
            return objDT;
        }

        /// <summary>
        /// 获取所定的服务器和数据库中所有存储过程参数名。
        /// </summary>
        /// <param name="strCondition">给定的条件</param>
        /// <returns>所有存储过程参数名的DataTable</returns>
        public System.Data.DataTable getSp_ParaByCond(string strCondition)
        {
            System.Data.DataTable objDT;
            StringBuilder sbSQL = new StringBuilder();

            sbSQL.Append("select ParaName=a.name ");
            sbSQL.Append(", ParaDataType=b.name ");
            sbSQL.Append(", ParaSize = a.length");
            sbSQL.Append(", ParaDirection = IsOutParam");
            sbSQL.Append(", IsNullable,");
            sbSQL.Append(", a.* ");
            sbSQL.Append("from syscolumns a join systypes b on a.xtype=b.xusertype ");
            sbSQL.AppendFormat("where id in (select id from sysobjects where xtype='P' and {0})", strCondition);
            sbSQL.Append(" order by id, colorder");
            objDT = GetDataTable(sbSQL.ToString());
            return objDT;
        }

        /// <summary>
        /// 获取给定的服务器和数据库中某存储过程的所有参数名。
        /// </summary>
        /// <param name="strSP_Name">给定的存储过程名</param>
        /// <returns>给定存储过程的所有参数名的DataTable</returns>
        public System.Data.DataTable getSp_ParaByName(string strSP_Name)
        {
            System.Data.DataTable objDT;
            StringBuilder sbSQL = new StringBuilder();
            sbSQL.Append("select ParaName=a.name ");
            sbSQL.Append(", ParaDataType=b.name ");
            sbSQL.Append(", ParaSize = a.length");
            sbSQL.Append(", ParaDirection = IsOutParam");
            sbSQL.Append(", IsNullable,");
            sbSQL.Append(", a.* ");
            sbSQL.Append("from syscolumns a join systypes b on a.xtype=b.xusertype ");
            sbSQL.AppendFormat("where object_id('{0}') = id", strSP_Name);
            sbSQL.Append(" order by id, colorder");
            objDT = GetDataTable(sbSQL.ToString());
            return objDT;
        }

        /// <summary>
        /// 获取所定的服务器和数据库中所有表名。
        /// </summary>
        /// <returns>所有表名的DataTable</returns>
        public System.Data.DataTable getTables(string strSqlVesion)
        {
            System.Data.DataTable objDT;
            string strSQL;
            if (strSqlVesion == "MSSQL2000")
            {
                strSQL = "Select * from sysobjects where xtype='U'  order by name";
            }
            else if (strSqlVesion == "MSSQL2005")
            {
                strSQL = "Select * from sys.tables order by name";
            }
            else
            {
                strSQL = "Select * from sysobjects where xtype='U'  order by name";
            }
            objDT = GetDataTable(strSQL);
            return objDT;
        }

        /// <summary>
        /// 获取所定的服务器和数据库中所有表名。
        /// </summary>
        /// <returns>所有表名的DataTable</returns>
        public System.Data.DataTable getTableAndViewsByDbo()
        {
            System.Data.DataTable objDT;
            string strSQL;
            strSQL = "Select * from sysobjects where (xtype='U' or  xtype='V') order by name";
            //strSQL = "sp_tables";
            objDT = GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 获取所定的服务器和数据库中所有表名。
        /// </summary>
        /// <returns>所有表名的DataTable</returns>
        public System.Data.DataTable getTableAndViews(string strWhere)
        {
            System.Data.DataTable objDT;
            string strSQL;
            strSQL = string.Format("Select * from sysobjects where {0} and (xtype='U' or  xtype='V') order by name", strWhere);
            //strSQL = "sp_tables";
            objDT = GetDataTable(strSQL);
            return objDT;
        }

        /// <summary>
        /// 获取给定的服务器和数据库中所有满足条件和拥有者的表名（含视图）。
        /// </summary>
        /// <param name="strOwner">拥有者</param>
        /// <param name="strWhere">条件</param>
        /// <returns>获得的所有表名（含视图）的DataTable</returns>
        public System.Data.DataTable getTableAndViewsByOwnerByCondBak20130307(string strOwner, string strWhere)
        {
            System.Data.DataTable objDT;
            string strSQL;
            strSQL = string.Format("Select * from sysobjects where {0} and (xtype='U' or  xtype='V') and uid in (select uid from sysusers where name = '{1}')  order by name", strWhere, strOwner);
            //strSQL = "sp_tables";
            objDT = GetDataTable(strSQL);
            return objDT;
        }

        /// <summary>
        /// 获取给定的服务器和数据库中所有满足条件的表名（含视图）。
        /// </summary>
        /// <param name="strWhere">条件</param>
        /// <returns>获得的所有表名（含视图）的DataTable</returns>
        public System.Data.DataTable getTableAndViewsByCond(string strWhere)
        {
            System.Data.DataTable objDT;
            string strSQL;
            strSQL = string.Format("Select * from sysobjects where {0} and (xtype='U' or  xtype='V')  order by name", strWhere);
            //strSQL = "sp_tables";
            objDT = GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 获取所定的服务器和数据库中所有表名。
        /// <param name="strOwner">拥有者</param>
        /// </summary>
        /// <returns>所有表名的DataTable</returns>
        public System.Data.DataTable getTableAndViewsByOwnerBak20130307(string strOwner)
        {
            System.Data.DataTable objDT;
            string strSQL;
            strSQL = string.Format("Select * from sysobjects where (xtype='U' or  xtype='V') and uid in (select uid from sysusers where name = '{0}')  order by name", strOwner);
            //strSQL = "sp_tables";
            objDT = GetDataTable(strSQL);
            return objDT;
        }

        /// <summary>
        /// 获取所定的服务器和数据库中所有表名。
        /// </summary>
        /// <returns>所有表名的DataTable</returns>
        public System.Data.DataTable getTableAndViews()
        {
            System.Data.DataTable objDT;
            string strSQL;
            strSQL = string.Format("Select * from sysobjects where (xtype='U' or  xtype='V') order by name");
            //strSQL = "sp_tables";
            objDT = GetDataTable(strSQL);
            return objDT;
        }

        /// <summary>
        /// 获取所定的服务器和数据库中所有表名。
        /// </summary>
        /// <returns>所有表名的DataTable</returns>
        public System.Data.DataTable getTableAndViewsBySp_Tables()
        {
            System.Data.DataTable objDT;
            string strSQL;
            //strSQL = "Select * from sysobjects where xtype='U' or  xtype='V' order by name";
            strSQL = "sp_tables";
            objDT = GetDataTable(strSQL);
            return objDT;
        }

        /// <summary>
        /// 是否存在表名？
        /// </summary>
        /// <param name="strTabName">表名</param>
        /// <returns>布尔型，是或否？</returns>
        public bool IsExistTable(string strTabName)
        {
            System.Data.DataTable objDT;
            string strSQL;

            strSQL = "Select name,id from sysobjects where xtype='U' and name = '" + strTabName + "'";
            objDT = GetDataTable(strSQL);
            if (objDT.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// 是否存在视图？
        /// </summary>
        /// <param name="strViewName">视图名</param>
        /// <returns>布尔型，是或否？</returns>
        public bool IsExistView(string strViewName)
        {
            System.Data.DataTable objDT;
            string strSQL;

            strSQL = "Select name,id from sysobjects where xtype='V' and name = '" + strViewName + "'";
            objDT = GetDataTable(strSQL);
            if (objDT.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        /// <summary>
        /// 获取所定的服务器和数据库中所有表名。
        /// </summary>
        /// <returns>所有表名的DataTable</returns>
        public bool IsExistStoreProcedure(string strStoreProcedure, string strOwner)
        {
            System.Data.DataTable objDT;
            StringBuilder sbSQL = new StringBuilder();

            sbSQL.Append("select 1 from  sysobjects  ");

            sbSQL.AppendFormat(" where name = '{0}' ",
                strStoreProcedure);
            sbSQL.AppendFormat(" and uid in (select uid from sysusers where name = '{0}')",
                strOwner);

            objDT = GetDataTable(sbSQL.ToString());
            if (objDT.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }



        /// <summary>
        /// 获取所定的服务器和数据库中所有表名。
        /// </summary>
        /// <returns>所有表名的DataTable</returns>
        public bool IsExistColumnInTable(string strTabName, string strDataBaseOwner, string strColumnName)
        {
            System.Data.DataTable objDT;

            string strCurrDate = clsDateTime.getTodayDateTimeStr(0).Substring(0, 12);
            if (strTabName == mstrTabName_Object && strCurrDate == mstrGetDate_Object)
            {
                objDT = objDT_Object;
            }
            else
            {
                string strSQL;

                strSQL = "Select name,id from sysobjects where name = '" + strTabName + "'";
                objDT = GetDataTable(strSQL);
                if (objDT.Rows.Count == 0)
                {
                    throw new Exception(string.Format("数据库中不存在表：{0},请检查！", strTabName));
                }
                objDT = GetColumns(strTabName, strDataBaseOwner);
                if (objDT.Rows.Count == 0)
                {
                    throw new Exception(string.Format("数据表：{0}的字段数为0,请检查！", strTabName));
                }
                mstrTabName_Object = strTabName;
                mstrGetDate_Object = strCurrDate;
                objDT_Object = objDT;
            }
            foreach (DataRow objDataRow in objDT.Rows)
            {
                string strTemp = objDataRow["column_name"].ToString();
                if (strTemp.ToLower() == strColumnName.ToLower())
                {
                    return true;
                }
            }
            return false;

        }

        /// <summary>
        /// 获取所定的服务器和数据库中所有表名。
        /// </summary>
        /// <returns>所有表名的DataTable</returns>
        public bool IsIdentity(string strTabName, string strDataBaseOwner, string strColumnName)
        {
            System.Data.DataTable objDT;
            StringBuilder sbSQL = new StringBuilder();
            StringBuilder sbMsg = new StringBuilder();
            sbSQL.AppendFormat("SELECT COLUMNPROPERTY( OBJECT_ID('{0}.{1}'),'{2}','IsIdentity') AS 'IsIdentity'",
                        strDataBaseOwner,
                        strTabName,
                        strColumnName
                        );
            objDT = GetDataTable(sbSQL.ToString());
            if (objDT.Rows.Count == 0)
            {
                sbMsg.AppendFormat("在表{2}.{0}中，检查字段{1}是否Identity出错！",
                    strTabName, strColumnName, strDataBaseOwner);
                throw new Exception(sbMsg.ToString());
            }
            if (objDT.Rows.Count == 1)
            {
                string strTemp = objDT.Rows[0]["IsIdentity"].ToString();
                if (strTemp == "1") return true;
                else return false;
            }
            return false;

        }

        /// <summary>
        /// 获取给定的表名的记录数。
        /// </summary>
        /// <returns>返回记录数</returns>
        public int GetRecordNumOfTable(string strTabName)
        {
            System.Data.DataTable objDT;
            StringBuilder sbSQL = new StringBuilder();
            StringBuilder sbMsg = new StringBuilder();
            sbSQL.AppendFormat("SELECT count(*) from {0}", strTabName);
            objDT = GetDataTable(sbSQL.ToString());
            if (objDT.Rows.Count == 0)
            {
                sbMsg.AppendFormat("在表{0}中，获取表记录数出错！",
                    strTabName);
                throw new Exception(sbMsg.ToString());
            }
            if (objDT.Rows.Count == 1)
            {
                string strTemp = objDT.Rows[0][0].ToString();
                int intRecordNum = int.Parse(strTemp);
                return intRecordNum;
            }
            return 0;

        }



        //i.	SELECT COLUMNPROPERTY( OBJECT_ID('dbo.elecdict'),'mid','IsIdentity') AS 'Column Length';
        /// <summary>
        /// 获取所定的服务器和数据库中所有VIEW名。
        /// </summary>
        /// <returns>所有View名的DataTable</returns>
        public System.Data.DataTable getViews()
        {
            System.Data.DataTable objDT;
            string strSQL;

            strSQL = "Select * from sysobjects where xtype='V'  order by name";
            objDT = GetDataTable(strSQL);
            return objDT;
        }

        /// <summary>
        /// 获取所定的服务器和数据库中所有VIEW名。
        /// </summary>
        /// <returns>所有View名的DataTable</returns>
        public System.Data.DataTable getViewsByOwner(string strOwner)
        {
            System.Data.DataTable objDT;
            string strSQL;

            strSQL = string.Format("Select * from sysobjects where xtype='V' and uid in (select uid from sysusers where name = '{0}')  order by name", strOwner);
            objDT = GetDataTable(strSQL);
            return objDT;
        }



        //i.	SELECT COLUMNPROPERTY( OBJECT_ID('dbo.elecdict'),'mid','IsIdentity') AS 'Column Length';
        /// <summary>
        /// 获取所定的服务器和数据库中所有VIEW名。
        /// </summary>
        /// <returns>所有View名的DataTable</returns>
        public System.Data.DataTable getViews(string strSqlVesion)
        {
            System.Data.DataTable objDT;
            string strSQL;
            if (strSqlVesion == "MSSQL2000")
            {
                strSQL = "Select * from sysobjects where xtype='V'  order by name";
            }
            else if (strSqlVesion == "MSSQL2005")
            {
                strSQL = "Select * from sys.tables order by name";
            }
            else
            {
                strSQL = "Select * from sysobjects where xtype='V'  order by name";
            }
            objDT = GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 获取数据表的主键列表
        /// </summary>
        /// <param name="strTabName">表名</param>
        /// <returns>外键列表，以DataTable形式返回</returns>
        public ArrayList GetPKeys(string strTabName)
        {
            ArrayList ParaValueList = new ArrayList();
            //			string strUserType;
            DataTable objDT = null;
            mstrSPConfigXML = "<StoredProcedures><StoredProcedure name='sp_pkeys'> <Parameters> "
                + " <Parameter name='@table_name' size='128' datatype='VarChar' direction='spParamInput' isNullable='True' /> "
                + "	<Parameter name='@table_owner' size='128' datatype='VarChar' direction='spParamInput' isNullable='True' /> "
                + " </Parameters></StoredProcedure></StoredProcedures>";
            ParaValueList.Clear();
            ParaValueList.Add(strTabName);
            ParaValueList.Add("dbo");
            try
            {
                objDT = ExecSpReturnDT("sp_pkeys", ParaValueList);
                //'        objSQL = Nothing
                ParaValueList.Clear();
                foreach (DataRow objRow in objDT.Rows)
                {
                    ParaValueList.Add(objRow["column_name"]);
                }
                //objDR.Close();
                //				m_objConnection.Close();
            }
            catch (Exception objException)
            {
                //  'Log the error
                LogError(objException, "");

                //			'Close the connection
                //		'                mobjConnection.Close()

                //		'Throw a new exception
                throw objException; //throw new Exception(EXCEPTION_MSG1 + objException.Message, objException);

            }
            finally
            {
                //objDR.Close();
                //mobjConnection.Close()
            }


            return ParaValueList;
        }
        /// <summary>
        /// 获取表的外键
        /// </summary>
        /// <param name="strTabName">表名</param>
        /// <returns>外键列表，以DataTable形式返回</returns>
        public DataTable GetFKeys(string strTabName)
        {
            ArrayList ParaValueList = new ArrayList();
            //			string strUserType;
            DataTable objDT;
            mstrSPConfigXML = "<StoredProcedures><StoredProcedure name='sp_fkeys'> <Parameters> "
                + " <Parameter name='@pktable_name' size='128' datatype='VarChar' direction='spParamInput' isNullable='True' /> "
                + "	<Parameter name='@pktable_owner' size='128' datatype='VarChar' direction='spParamInput' isNullable='True' /> "
                + " </Parameters></StoredProcedure></StoredProcedures>";
            ParaValueList.Clear();
            ParaValueList.Add(strTabName);
            ParaValueList.Add("dbo");
            try
            {
                objDT = ExecSpReturnDT("sp_fkeys", ParaValueList);
                //			'        objSQL = Nothing
                ParaValueList.Clear();
                return objDT;
            }
            catch (Exception objException)
            {
                //						   'Log the error
                LogError(objException, "");
                //	'Close the connection
                //'Throw a new exception
                throw objException; //throw new Exception(EXCEPTION_MSG1 + objException.Message, objException);
            }
            finally
            {
                //'                mobjConnection.Close()
            }
        }


        /// <summary>
        /// 获取数据表的主键列表
        /// </summary>
        /// <param name="strTabName">表名</param>
        /// <param name="strDataBaseOwner">拥有者</param>
        /// <returns>主键列表，以ArrayList形式返回</returns>
        public ArrayList GetPKeys(string strTabName, string strDataBaseOwner)
        {
            ArrayList ParaValueList = new ArrayList();
            //			string strUserType;
            DataTable objDT = null;
            mstrSPConfigXML = "<StoredProcedures><StoredProcedure name='sp_pkeys'> <Parameters> "
                + " <Parameter name='@table_name' size='128' datatype='VarChar' direction='spParamInput' isNullable='True' /> "
                + "	<Parameter name='@table_owner' size='128' datatype='VarChar' direction='spParamInput' isNullable='True' /> "
                + " </Parameters></StoredProcedure></StoredProcedures>";
            ParaValueList.Clear();
            ParaValueList.Add(strTabName);
            if (strDataBaseOwner.ToLower() == "sa")
            {
                ParaValueList.Add("dbo");//可能这一行有问题，必须需要对MASTER有权限的用户才行
            }
            else
            {
                ParaValueList.Add(strDataBaseOwner);//可能这一行有问题，必须需要对MASTER有权限的用户才行
            }

            try
            {
                objDT = ExecSpReturnDT("sp_pkeys", ParaValueList);
                //'        objSQL = Nothing
                ParaValueList.Clear();
                foreach (DataRow objRow in objDT.Rows)
                {
                    ParaValueList.Add(objRow["column_name"]);
                }
                //				m_objConnection.Close();
            }
            catch (Exception objException)
            {
                //  'Log the error
                LogError(objException, "");

                //			'Close the connection
                //		'                mobjConnection.Close()

                //		'Throw a new exception
                throw objException; //throw new Exception(EXCEPTION_MSG1 + objException.Message, objException);

            }
            finally
            {
                //objDR.Close();
                //mobjConnection.Close()
            }


            return ParaValueList;
        }


        /// <summary>
        /// 获取数据表的主键列表
        /// </summary>
        /// <param name="strTabName">表名</param>
        /// <param name="strDataBaseOwner">拥有者</param>
        /// <returns>主键列表，以ArrayList形式返回</returns>
        public DataTable GetPKeysDT(string strTabName, string strDataBaseOwner)
        {
            ArrayList ParaValueList = new ArrayList();
            ArrayList arrPKeyObjList = new ArrayList();
            //			string strUserType;
            DataTable objDT = null;
            mstrSPConfigXML = "<StoredProcedures><StoredProcedure name='sp_pkeys'> <Parameters> "
                + " <Parameter name='@table_name' size='128' datatype='VarChar' direction='spParamInput' isNullable='True' /> "
                + "	<Parameter name='@table_owner' size='128' datatype='VarChar' direction='spParamInput' isNullable='True' /> "
                + " </Parameters></StoredProcedure></StoredProcedures>";
            ParaValueList.Clear();
            ParaValueList.Add(strTabName);
            if (strDataBaseOwner.ToLower() == "sa")
            {
                ParaValueList.Add("dbo");//可能这一行有问题，必须需要对MASTER有权限的用户才行
            }
            else
            {
                ParaValueList.Add(strDataBaseOwner);//可能这一行有问题，必须需要对MASTER有权限的用户才行
            }

            try
            {
                objDT = ExecSpReturnDT("sp_pkeys", ParaValueList);
                //'        objSQL = Nothing
                ParaValueList.Clear();
                return objDT;
                //				m_objConnection.Close();
            }
            catch (Exception objException)
            {
                //  'Log the error
                LogError(objException, "");

                //			'Close the connection
                //		'                mobjConnection.Close()

                //		'Throw a new exception
                throw objException; //throw new Exception(EXCEPTION_MSG1 + objException.Message, objException);

            }
            finally
            {
                //objDR.Close();
                //mobjConnection.Close()
            }
            //return objDT;
        }

        /// <summary>
        /// 获取表的外键
        /// </summary>
        /// <param name="strTabName">表名</param>        
        /// <param name="strDataBaseOwner">拥有者</param>
        /// <returns>外键列表，以DataTable形式返回</returns>
        public DataTable GetFKeys(string strTabName, string strDataBaseOwner)
        {
            ArrayList ParaValueList = new ArrayList();
            //			string strUserType;
            DataTable objDT;
            mstrSPConfigXML = "SELECT PKeyColumnID=b.rkey "
+ "    ,PKeyColumnName=(SELECT name FROM syscolumns WHERE colid=b.rkey AND id=b.rkeyid)  "
+ "    ,PKeyTabId=b.rkeyid "
    + ",PKeyTabName=object_name(b.rkeyid) "
    + ",FKeyTabID=b.fkeyid  "
    + ",FKeyTabName=object_name(b.fkeyid)  "
        + ",FKeyName=object_name(b.constid)  "
    + ",FKeyColumnID=b.fkey  "
    + ",FKeyColumnName=(SELECT name FROM syscolumns WHERE colid=b.fkey AND id=b.fkeyid)  "
    + ",Update_Action=ObjectProperty(a.id,'CnstIsUpdateCascade')  "
    + ",Delete_Action=ObjectProperty(a.id,'CnstIsDeleteCascade')  "

+ "FROM sysobjects a  "
  + "  join sysforeignkeys b on a.id=b.constid  "
  + "  join sysobjects c on a.parent_obj=c.id  "
+ "where a.xtype='f' AND c.xtype='U'  "
  + "  and object_name(b.fkeyid)='" + strTabName + "'";
            try
            {
                objDT = GetDataTable(mstrSPConfigXML);
                //			'        objSQL = Nothing

                return objDT;
            }
            catch (Exception objException)
            {
                //						   'Log the error
                LogError(objException, "");
                //	'Close the connection
                //'Throw a new exception
                throw objException; //throw new Exception(EXCEPTION_MSG1 + objException.Message, objException);
            }
            finally
            {
                //'                mobjConnection.Close()
            }
        }


        /// <summary>
        /// 功能：获取给定表的所有列信息,所有者为dbo
        /// </summary>
        /// <param name="strTabName">给定的表名</param>
        /// <returns>给定表的所有列信息，以DataTable形式</returns>
        public DataTable GetColumnsByDboBak(string strTabName)
        {
            ArrayList ParaValueList = new ArrayList();
            DataTable objDT;
            mstrSPConfigXML = "<StoredProcedures><StoredProcedure name='sp_columns'> <Parameters> "
                + " <Parameter name='@table_name' size='128' datatype='VarChar' direction='spParamInput' isNullable='True' /> "
                + "	<Parameter name='@table_owner' size='128' datatype='VarChar' direction='spParamInput' isNullable='True' /> "
                + " </Parameters></StoredProcedure></StoredProcedures>";
            ParaValueList.Clear();
            ParaValueList.Add(strTabName);
            ParaValueList.Add("dbo");//可能这一行有问题，必须需要对MASTER有权限的用户才行
            try
            {
                objDT = ExecSpReturnDT("sp_columns", ParaValueList);
                //'        objSQL = Nothing
                ParaValueList.Clear();
                return objDT;
            }
            catch (Exception objException)
            {
                //'Log the error
                LogError(objException, "");
                //'Close the connection
                //'Throw a new exception
                throw objException; //throw new Exception(EXCEPTION_MSG1 + objException.Message, objException);
            }
            finally
            {
                //'                mobjConnection.Close()
            }
        }
        /// <summary>
        /// 功能：获取给定表所有列信息
        /// </summary>
        /// <param name="strTabName">给定的表名</param>
        /// <returns>给定表的所有列信息，以DataTable形式</returns>
        public DataTable GetColumns(string strTabName)
        {
            ArrayList ParaValueList = new ArrayList();
            DataTable objDT;
            mstrSPConfigXML = "<StoredProcedures><StoredProcedure name='sp_columns'> <Parameters> "
                + " <Parameter name='@table_name' size='128' datatype='VarChar' direction='spParamInput' isNullable='True' /> "
                //+ "	<Parameter name='@table_owner' size='128' datatype='VarChar' direction='spParamInput' isNullable='True' /> "
                + " </Parameters></StoredProcedure></StoredProcedures>";
            ParaValueList.Clear();
            ParaValueList.Add(strTabName);

            try
            {
                objDT = ExecSpReturnDT("sp_columns", ParaValueList);
                //'        objSQL = Nothing
                ParaValueList.Clear();
                return objDT;
            }
            catch (Exception objException)
            {
                //'Log the error
                LogError(objException, "");
                //'Close the connection
                //'Throw a new exception
                throw objException; //throw new Exception(EXCEPTION_MSG1 + objException.Message, objException);
            }
            finally
            {
                //'                mobjConnection.Close()
            }
        }

        /// <summary>
        /// 功能：获取给定表的列数
        /// </summary>
        /// <param name="strTabName">给定的表名</param>
        /// <returns>给定表的所有列信息，以DataTable形式</returns>
        public int GetColumnsCount(string strTabName)
        {
            ArrayList ParaValueList = new ArrayList();
            DataTable objDT;
            mstrSPConfigXML = "<StoredProcedures><StoredProcedure name='sp_columns'> <Parameters> "
                + " <Parameter name='@table_name' size='128' datatype='VarChar' direction='spParamInput' isNullable='True' /> "
                //+ "	<Parameter name='@table_owner' size='128' datatype='VarChar' direction='spParamInput' isNullable='True' /> "
                + " </Parameters></StoredProcedure></StoredProcedures>";
            ParaValueList.Clear();
            ParaValueList.Add(strTabName);

            try
            {
                objDT = ExecSpReturnDT("sp_columns", ParaValueList);
                //'        objSQL = Nothing
                ParaValueList.Clear();
                return objDT.Rows.Count;
            }
            catch (Exception objException)
            {
                //'Log the error
                LogError(objException, "");
                //'Close the connection
                //'Throw a new exception
                throw objException; //throw new Exception(EXCEPTION_MSG1 + objException.Message, objException);
            }
            finally
            {
                //'                mobjConnection.Close()
            }
        }

        /// <summary>
        /// 功能：获取给定表某拥有者的所有列信息
        /// </summary>
        /// <param name="strTabName">给定的表名</param>
        /// <param name="strDataBaseOwner">给定的拥有者</param>
        /// <returns>给定表的所有列信息，以DataTable形式</returns>
        public DataTable GetColumns(string strTabName, string strDataBaseOwner)
        {
            ArrayList ParaValueList = new ArrayList();
            DataTable objDT;
            mstrSPConfigXML = "<StoredProcedures><StoredProcedure name='sp_columns'> <Parameters> "
                + " <Parameter name='@table_name' size='128' datatype='VarChar' direction='spParamInput' isNullable='True' /> "
                + "	<Parameter name='@table_owner' size='128' datatype='VarChar' direction='spParamInput' isNullable='True' /> "
                + " </Parameters></StoredProcedure></StoredProcedures>";
            ParaValueList.Clear();
            ParaValueList.Add(strTabName);
            if (strDataBaseOwner.ToLower() == "sa")
            {
                ParaValueList.Add("dbo");//可能这一行有问题，必须需要对MASTER有权限的用户才行
            }
            else
            {
                ParaValueList.Add(strDataBaseOwner);//可能这一行有问题，必须需要对MASTER有权限的用户才行
            }
            try
            {
                objDT = ExecSpReturnDT("sp_columns", ParaValueList);
                //'        objSQL = Nothing
                ParaValueList.Clear();
                return objDT;
            }
            catch (Exception objException)
            {
                //'Log the error
                LogError(objException, "");
                //'Close the connection
                //'Throw a new exception
                throw objException;
            }
            finally
            {
                //'                mobjConnection.Close()
            }
        }

        /// <summary>
        /// 功能：获取给定表某拥有者的所有列信息
        /// </summary>
        /// <param name="strTabName">给定的表名</param>
        /// <param name="strColumnName">列名</param>
        /// <param name="strDataBaseOwner">给定的拥有者</param>
        /// <returns>给定表的所有列信息，以DataTable形式</returns>
        public DataTable GetColumns(string strTabName, string strColumnName, string strDataBaseOwner)
        {
            ArrayList ParaValueList = new ArrayList();
            DataTable objDT;
            mstrSPConfigXML = "<StoredProcedures><StoredProcedure name='sp_columns'> <Parameters> "
                + " <Parameter name='@table_name' size='128' datatype='VarChar' direction='spParamInput' isNullable='True' /> "
                + "	<Parameter name='@column_name' size='128' datatype='VarChar' direction='spParamInput' isNullable='True' /> "
                + "	<Parameter name='@table_owner' size='128' datatype='VarChar' direction='spParamInput' isNullable='True' /> "
                + " </Parameters></StoredProcedure></StoredProcedures>";
            ParaValueList.Clear();
            ParaValueList.Add(strTabName);
            ParaValueList.Add(strColumnName);

            if (strDataBaseOwner.ToLower() == "sa")
            {
                ParaValueList.Add("dbo");//可能这一行有问题，必须需要对MASTER有权限的用户才行
            }
            else
            {
                ParaValueList.Add(strDataBaseOwner);//可能这一行有问题，必须需要对MASTER有权限的用户才行
            }
            try
            {
                objDT = ExecSpReturnDT("sp_columns", ParaValueList);
                //'        objSQL = Nothing
                ParaValueList.Clear();
                return objDT;
            }
            catch (Exception objException)
            {
                //'Log the error
                LogError(objException, "");
                //'Close the connection
                //'Throw a new exception
                throw objException; //throw new Exception(EXCEPTION_MSG1 + objException.Message, objException);
            }
            finally
            {
                //'                mobjConnection.Close()
            }
        }

        /// <summary>
        /// 获取约束
        /// </summary>
        /// <param name="strTabName">表名</param>
        /// <returns>约束，以DataTable形式返回</returns>
        public DataTable GetConstraint(string strTabName)
        {
            ArrayList ParaValueList = new ArrayList();
            DataTable objDT;
            mstrSPConfigXML = "<StoredProcedures><StoredProcedure name='sp_helpconstraint'> <Parameters> "
                + " <Parameter name='@objname' size='128' datatype='VarChar' direction='spParamInput' isNullable='True' /> "
                + "	<Parameter name='@nomsg' size='5' datatype='VarChar' direction='spParamInput' isNullable='True' /> "
                + " </Parameters></StoredProcedure></StoredProcedures>";
            ParaValueList.Clear();
            ParaValueList.Add(strTabName);
            ParaValueList.Add("nomsg");
            try
            {
                objDT = ExecSpReturnDT("sp_helpconstraint", ParaValueList);
                //'        objSQL = Nothing
                ParaValueList.Clear();
                return objDT;
            }
            catch (Exception objException)
            {
                //'Log the error
                LogError(objException, "");
                //'Close the connection
                //'Throw a new exception
                throw objException; //throw new Exception(EXCEPTION_MSG1 + objException.Message, objException);
            }
            finally
            {
                //'                mobjConnection.Close()
            }
        }

        //private SqlDataReader ExecSPReturnDR(string SPName, ArrayList ParamValues)
        //{
        //    SqlCommand objCommand;
        //    SqlDataReader objReader;

        //    m_oConn = getConnectObj(this.p_sConnectString);
        //    try
        //    {
        //        //'Make sure that the object has not been disposed yet
        //        if (mblnDisposed == true)
        //        {
        //            throw new ObjectDisposedException(mstrModuleName, "This object has already been disposed.");
        //        }
        //        //'Make sure we are getting a valid stored procedure name.
        //        ValidateSPName(SPName);
        //        //'Open the connection (required for the ExecuteReader method).

        //        //m_oConn = new SqlConnection(this.p_sConnectString);
        //        //m_oConn.O1pen();
        //        //'Initialize the SQLCommand object
        //        objCommand = new SqlCommand(SPName, m_oConn);
        //        objCommand.CommandType = CommandType.StoredProcedure;
        //        //'Build the parameters, if any
        //        BuildParameters(objCommand, ParamValues);
        //        //'Execute the sp and get the SqlDataReader.
        //        objReader = objCommand.ExecuteReader();
        //        //'Return the value
        //        return objReader;
        //    }
        //    catch (Exception objException)
        //    {
        //        //'Log the error
        //        LogError(objException, "");

        //        //'Close the connection
        //        //'Throw a new exception
        //        throw objException; //throw new Exception(EXCEPTION_MSG1 + objException.Message, objException);
        //    }
        //    finally
        //    {
        //        m_oConn.Close();
        //    }
        //}

        //		public DataSet ExecSPreturnDS(string sSPName,ArrayList paramValues,string stablename)
        //		{
        //			
        //			//by davidfujian 2004-3-21 NOON
        //			//Exec a SP with long parameters and return a DataSet
        //			DataSet ds=new DataSet();
        //			SqlCommand sqlCmd;
        //			
        //			
        //			m_oConn=new SqlConnection (this.p_sConnectString);
        //			m_oConn.Open();
        //			sqlCmd=new SqlCommand(sSPName,m_oConn);
        //			sqlCmd.CommandText=sSPName;
        //			sqlCmd.Connection=m_oConn;
        //			sqlCmd.CommandType = CommandType.StoredProcedure;
        //			BuildParameters(sqlCmd,paramValues);
        //			
        //			SqlDataAdapter sqlDA=new SqlDataAdapter(sqlCmd);
        //			sqlDA.Fill(ds,stablename);
        //			
        //			return ds;
        //			
        //		}

        public DataTable ExecSpReturnDT(string sSPName, ArrayList paramValues)
        {

            //by davidfujian 2004-3-21 NOON
            //Exec a SP with long parameters and return a DataSet
            DataTable dt = new DataTable();
            SqlCommand sqlCmd;
            try
            {
                m_oConn = getConnectObj(this.p_sConnectString);

                //m_oConn = new SqlConnection(this.p_sConnectString);
                //m_oConn.O1pen();
                sqlCmd = new SqlCommand(sSPName, m_oConn);
                sqlCmd.CommandText = sSPName;
                sqlCmd.Connection = m_oConn;
                sqlCmd.CommandType = CommandType.StoredProcedure;
                BuildParameters(sqlCmd, paramValues);

                SqlDataAdapter sqlDA = new SqlDataAdapter(sqlCmd);
                sqlDA.Fill(dt);

                return dt;
            }
            catch (Exception objException)
            {
                throw objException;
            }
            finally
            {
                m_oConn.Close();
            }
        }

        public DataTable ExecSpReturnDT2(string sSPName, ArrayList paramValues)
        {

            //by davidfujian 2004-3-21 NOON
            //Exec a SP with long parameters and return a DataSet
            DataTable dt = new DataTable();
            SqlCommand sqlCmd;
            try
            {
                m_oConn = getConnectObj(this.p_sConnectString);

                //m_oConn = new SqlConnection(this.p_sConnectString);
                //m_oConn.O1pen();
                sqlCmd = new SqlCommand(sSPName, m_oConn);
                sqlCmd.CommandText = sSPName;
                sqlCmd.Connection = m_oConn;
                sqlCmd.CommandType = CommandType.StoredProcedure;
                BuildParameters2(sqlCmd, sSPName, paramValues);

                SqlDataAdapter sqlDA = new SqlDataAdapter(sqlCmd);
                sqlDA.Fill(dt);

                return dt;
            }
            catch (Exception objException)
            {
                throw objException;
            }
            finally
            {
                m_oConn.Close();
            }
        }

    }
}
