using System;
using System.Configuration;
using com.taishsoft.commdb;
using com.taishsoft.encrypt;
using com.taishsoft.common;
namespace SpecData
{
	/// <summary>
	/// clsSpecSQL ��ժҪ˵����
	/// </summary>
	public class clsSpecSQL : clsSqlEx
	{
        //private static string mstrAppType = "WEBAPP"; //Ӧ�����Ϳ����������֣�"WEBAPP","WINAPP"

        /// <summary>
        /// Ӧ�����Ϳ����������֣�"WEBAPP","WINAPP"
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
        /// Web��Ŀ¼
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
        /// ���Ӵ�
        /// </summary>
        public static string strConnectString
        {
            get { return clsSqlEx.ConnectString; }
            set {
                
                clsSqlEx.ConnectString = value;
            }
        }
        /// <summary>
        /// ���Ӵ�
        /// </summary>
        public string strConnStr;
        /// <summary>
        /// 
        /// </summary>
		public clsSpecSQL()
		{
			//
			// TODO: �ڴ˴���ӹ��캯���߼�
			//
            //p_sConnectString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString1"];		//��Ҫ��202.121.51.55
            //p_sConnectString = "server=202.121.51.55;uid=pyf;pwd=a1b2c3;database=AGC_CSV4";

            //p_sConnectString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString2"];		//��Ҫ�Ǳ�����202.121.51.50
           
			//			p_sConnectString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString4"];
            if (clsSpecSQL.strAppType == "WEBAPP")
            {

                if (string.IsNullOrEmpty(clsSpecSQL.strWebRoot) == true)
                {
                    throw new Exception("clsSpecSQL.strWebRootΪ�գ�����Global.asax�����ø�ֵ�������ڸ���Ŀ����ʼҳ�����ø�ֵ�������޷����У�����");
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
                        throw new Exception("��Web.Config��û�������ַ��������飡");
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
                            throw new Exception("���Ӵ�Ϊ�գ����飡");
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
