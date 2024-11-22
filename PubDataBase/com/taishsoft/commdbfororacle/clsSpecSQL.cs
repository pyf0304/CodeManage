using System;
using System.Configuration;


namespace com.taishsoft.commdbfororacle
{
	/// <summary>
	/// clsSpecSQLforOra 的摘要说明。
	/// </summary>
	public class clsSpecSQLforOra : clsSqlEx
	{
        public static string strAppType = "WEBAPP"; //应用类型可以设置两种："WEBAPP","WINAPP"
        public static string strWebRoot = "";   //@"\AGC_CSV5\ConnStr\";
        public static string strConnectString = "";
        public string strConnStr;
		public clsSpecSQLforOra()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
//			p_sConnectString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString1"];		//主要是202.121.51.55
            //p_sConnectString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString1Oracle"];		//主要是本机：202.121.51.50
			//			p_sConnectString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString4"];
            
            //			p_sConnectString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString4"];
            if (clsSpecSQLforOra.strAppType == "WEBAPP")
            {
                if (string.IsNullOrEmpty(clsSpecSQLforOra.strWebRoot) == true)
                {
                    throw new Exception("clsSpecSQLforOra.strWebRoot为空，请在Global.asax中设置该值，或者在该项目的起始页中设置该值。否则无法运行！！！");
                }

                System.Configuration.Configuration rootWebConfig =
    System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration(clsSpecSQLforOra.strWebRoot);
                System.Configuration.ConnectionStringSettings connString;
                if (0 == rootWebConfig.ConnectionStrings.ConnectionStrings.Count)
                {
                    throw new Exception("在Web.Config中没有连接字符串！请检查！");
                }
                if (0 < rootWebConfig.ConnectionStrings.ConnectionStrings.Count)
                {
                    connString =
                        rootWebConfig.ConnectionStrings.ConnectionStrings["ConnectionStringForOracle"];
                    if (null != connString)
                    {
                        Console.WriteLine("Local connection string = \"{0}\"",
                            connString.ConnectionString);
                        p_sConnectString = connString.ConnectionString;
                    }
                    else
                    {
                        Console.WriteLine("No Local connection string");
                        throw new Exception("连接串(Oracle)为空！请检查！");
                    }
                    //AppSetting = rootWebConfig.AppSettings["ConnectionString1"];	

                }
            }
            else if (clsSpecSQLforOra.strAppType == "WINAPP")
            {
                //                p_sConnectString = new ConnectString().ConntectionString;
                //                p_sConnectString = System.Configuration.ConfigurationManager.ConnectionStrings["ImportFileToSQL.Settings1.ConnectionString"].ToString();
                p_sConnectString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionStringForOracle"].ToString();

                //                p_sConnectString = new SpecData.Properties.Settings().ConnectionString;
                strConnStr = p_sConnectString;
            }
            clsSpecSQLforOra.strConnectString = p_sConnectString;

		}
		public clsSpecSQLforOra(string sconnectString):base(sconnectString)
		{
            clsSpecSQLforOra.strConnectString = sconnectString;
		}
        public clsSpecSQLforOra(string strConnectStringName, bool bolIsUseConnStrName)
            : base(strConnectStringName, bolIsUseConnStrName)
        {

        }
        public clsSpecSQLforOra(string server, string strSID, string uid, string pwd)
            : base(server, strSID, uid, pwd)
		{
		}

	}
}
