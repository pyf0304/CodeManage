using System;
using System.Configuration;
using SpecData;
namespace com.taishsoft.commdbforxml
{
	/// <summary>
	/// clsSpecSQLforSql 的摘要说明。
	/// </summary>
	public class clsSpecSQLforXml : clsSQL
	{
        public static string strAppType
        {
            get { return clsSQL.AppType; }
            set
            {
                clsSQL.AppType = value;

            }
        }
        //private static string mstrWebRoot = "";   //@"\AGC_CSV5\ConnStr\";

        public static string strWebRoot
        {
            get { return clsSQL.WebRoot; }
            set
            {
                clsSQL.WebRoot = value;

            }
        }
        //private static string mstrConnectString = "";

		public clsSpecSQLforXml()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
            //p_sConnectString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString1"];		//主要是202.121.51.55
            //p_sConnectString = "server=202.121.51.55;uid=pyf;pwd=a1b2c3;database=AGC_CSV4";

            //p_sConnectString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString2"];		//主要是本机：202.121.51.50
           
			//			p_sConnectString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString4"];
            //if (clsSpecSQLforXml.strAppType == "WEBAPP")
            //{

            //    if (string.IsNullOrEmpty(clsSpecSQLforXml.strWebRoot) == true)
            //    {
            //        throw new Exception("clsSpecSQLforXml.strWebRoot为空，请在Global.asax中设置该值，或者在该项目的起始页中设置该值。否则无法运行！！！");
            //    }

            //}
            //else if (clsSpecSQLforXml.strAppType == "WINAPP")
            //{
            //}
		}
        public clsSpecSQLforXml(string strXmlFileName)
            : base(strXmlFileName)
        {

        }
        public clsSpecSQLforXml(System.Data.DataSet objDS)
            : base(objDS)
        {

        }
	}
}
