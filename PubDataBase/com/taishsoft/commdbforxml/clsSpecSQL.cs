using System;
using System.Configuration;
using SpecData;
namespace com.taishsoft.commdbforxml
{
	/// <summary>
	/// clsSpecSQLforSql ��ժҪ˵����
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
			// TODO: �ڴ˴���ӹ��캯���߼�
			//
            //p_sConnectString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString1"];		//��Ҫ��202.121.51.55
            //p_sConnectString = "server=202.121.51.55;uid=pyf;pwd=a1b2c3;database=AGC_CSV4";

            //p_sConnectString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString2"];		//��Ҫ�Ǳ�����202.121.51.50
           
			//			p_sConnectString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString4"];
            //if (clsSpecSQLforXml.strAppType == "WEBAPP")
            //{

            //    if (string.IsNullOrEmpty(clsSpecSQLforXml.strWebRoot) == true)
            //    {
            //        throw new Exception("clsSpecSQLforXml.strWebRootΪ�գ�����Global.asax�����ø�ֵ�������ڸ���Ŀ����ʼҳ�����ø�ֵ�������޷����У�����");
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
