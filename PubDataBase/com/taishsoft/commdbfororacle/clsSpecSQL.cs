using System;
using System.Configuration;


namespace com.taishsoft.commdbfororacle
{
	/// <summary>
	/// clsSpecSQLforOra ��ժҪ˵����
	/// </summary>
	public class clsSpecSQLforOra : clsSqlEx
	{
        public static string strAppType = "WEBAPP"; //Ӧ�����Ϳ����������֣�"WEBAPP","WINAPP"
        public static string strWebRoot = "";   //@"\AGC_CSV5\ConnStr\";
        public static string strConnectString = "";
        public string strConnStr;
		public clsSpecSQLforOra()
		{
			//
			// TODO: �ڴ˴���ӹ��캯���߼�
			//
//			p_sConnectString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString1"];		//��Ҫ��202.121.51.55
            //p_sConnectString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString1Oracle"];		//��Ҫ�Ǳ�����202.121.51.50
			//			p_sConnectString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString4"];
            
            //			p_sConnectString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString4"];
            if (clsSpecSQLforOra.strAppType == "WEBAPP")
            {
                if (string.IsNullOrEmpty(clsSpecSQLforOra.strWebRoot) == true)
                {
                    throw new Exception("clsSpecSQLforOra.strWebRootΪ�գ�����Global.asax�����ø�ֵ�������ڸ���Ŀ����ʼҳ�����ø�ֵ�������޷����У�����");
                }

                System.Configuration.Configuration rootWebConfig =
    System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration(clsSpecSQLforOra.strWebRoot);
                System.Configuration.ConnectionStringSettings connString;
                if (0 == rootWebConfig.ConnectionStrings.ConnectionStrings.Count)
                {
                    throw new Exception("��Web.Config��û�������ַ��������飡");
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
                        throw new Exception("���Ӵ�(Oracle)Ϊ�գ����飡");
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
