using System;
using System.Configuration;
using com.taishsoft.commdb;
using com.taishsoft.encrypt;
using com.taishsoft.common;
namespace SpecData
{
	/// <summary>
	/// clsSpecSQL 的摘要说明。
	/// </summary>
	public class clsSpecSQL : clsSqlEx
	{
        //private static string mstrAppType = "WEBAPP"; //应用类型可以设置两种："WEBAPP","WINAPP"

        /// <summary>
        /// 应用类型可以设置两种："WEBAPP","WINAPP"
        /// </summary>
        public static string strAppType
        {
            get { return clsSqlEx.AppType; }
            set {
                clsSqlEx.AppType = value;
      
            }
        }
        //private static string mstrWebRoot = "";   //@"\AGC_CSV5\ConnStr\";
        /// <summary>
        /// Web根目录
        /// </summary>
        public static string strWebRoot
        {
            get { return clsSqlEx.WebRoot; }
            set {
                clsSqlEx.WebRoot = value;               
            }
        }
        

        //private static string mstrConnectString = "";
        /// <summary>
        /// 连接串
        /// </summary>
        public static string strConnectString
        {
            get { return clsSqlEx.ConnectString; }
            set {
                
                clsSqlEx.ConnectString = value;
            }
        }
        /// <summary>
        /// 连接串
        /// </summary>
        public string strConnStr;
        /// <summary>
        /// 
        /// </summary>
		public clsSpecSQL()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
            //p_sConnectString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString1"];		//主要是202.121.51.55
            //p_sConnectString = "server=202.121.51.55;uid=pyf;pwd=a1b2c3;database=AGC_CSV4";

            //p_sConnectString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString2"];		//主要是本机：202.121.51.50
           
			//			p_sConnectString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString4"];
            if (clsSpecSQL.strAppType == "WEBAPP")
            {

                if (string.IsNullOrEmpty(clsSpecSQL.strWebRoot) == true)
                {
                    throw new Exception("clsSpecSQL.strWebRoot为空，请在Global.asax中设置该值，或者在该项目的起始页中设置该值。否则无法运行！！！");
                }
                if (clsSqlEx.IsUseEncrypt == true)
                {
                    string strWebConfigFile = clsSqlEx.WebConfigFileName;
                    p_sConnectString = new clsEncrypt().GetConnectStringForEncrypt(strWebConfigFile, "connectionStrings/add");
                }
                else
                {

                    System.Configuration.Configuration rootWebConfig =
        System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration(clsSpecSQL.strWebRoot);
                    System.Configuration.ConnectionStringSettings connString;
                    if (0 == rootWebConfig.ConnectionStrings.ConnectionStrings.Count)
                    {
                        throw new Exception("在Web.Config中没有连接字符串！请检查！");
                    }
                    if (0 < rootWebConfig.ConnectionStrings.ConnectionStrings.Count)
                    {
                        connString =
                            rootWebConfig.ConnectionStrings.ConnectionStrings["ConnectionString"];
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
            else if (clsSpecSQL.strAppType == "WINAPP")
            {
                //                p_sConnectString = new ConnectString().ConntectionString;
                //                p_sConnectString = System.Configuration.ConfigurationManager.ConnectionStrings["ImportFileToSQL.Settings1.ConnectionString"].ToString();

                if (clsSqlEx.IsUseEncrypt == true)
                {
                    string strApplicationConfigFile = clsApplicatoin.ExecutablePath + ".config";
                    p_sConnectString = new clsEncrypt().GetConnectStringForEncrypt(strApplicationConfigFile, "connectionStrings/add");
                }
                else
                {
                    p_sConnectString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
                }
                //                p_sConnectString = new SpecData.Properties.Settings().ConnectionString;
                strConnStr = p_sConnectString;
            }
            else if (clsSpecSQL.strAppType == "NetCoreWebApi")
            {
                //                p_sConnectString = new ConnectString().ConntectionString;
                //                p_sConnectString = System.Configuration.ConfigurationManager.ConnectionStrings["ImportFileToSQL.Settings1.ConnectionString"].ToString();

                //if (clsSqlEx.IsUseEncrypt == true)
                //{
                //    string strApplicationConfigFile = clsApplicatoin.ExecutablePath + ".config";
                //    p_sConnectString = new clsEncrypt().GetConnectStringForEncrypt(strApplicationConfigFile, "connectionStrings/add");
                //}
                //else
                //{
                //    p_sConnectString = Configuration["ConnectionString"];
                //}
                ////                p_sConnectString = new SpecData.Properties.Settings().ConnectionString;
                //strConnStr = p_sConnectString;
                p_sConnectString = clsSpecSQL.strConnectString;
            }
            clsSpecSQL.strConnectString = p_sConnectString;
           
        

		}
        /// <summary>
        /// 
        /// </summary>
        /// <param name="server"></param>
        /// <param name="database"></param>
        /// <param name="uid"></param>
        /// <param name="pwd"></param>
		public clsSpecSQL(string server,string database,string uid,string pwd):base(server, database, uid,pwd)
		{
           
		}
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strConnectString"></param>
        public clsSpecSQL(string strConnectString)
            : base(strConnectString)
        {

        }
       
	}
}
