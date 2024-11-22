using System;
using System.Net;
using System.Collections;
using com.taishsoft.commdbforxml;

namespace EcardDataClass
{
	/// <summary>
	/// clsSysPara ��ժҪ˵����
	/// </summary>
	public class clsSysPara
	{
        public static string CurrPrjId = "0002";
        public static string CurrSelPrjId = "";
        public static string CurrDirectory;
        public static string strXMLFolder = @"\EduAdmin_Web\XML\";
		public static string strXMLFileName;	//���ڶ���SQL�洢���̵�XML�ļ����ơ�        
        /// <summary>
        /// ���ڶ���SQL�洢���̵�XML�ļ�����
        /// </summary>
        public static string strXmlSpParaFileName;	//���ڶ���SQL�洢���̵�XML�ļ����ơ�
        public static string ConfigFileName;
        //Xml����Դ
        public static string strXmlDataSourceFileName = "";
        public static clsSpecSQLforXml objSpecSqlForXml = null;
        public static bool bolIsUseXmlDataSource = false;

        ///���Ӵ�����
        public static string strConnectStrName = "";
        public static bool bolIsUseConnectStrName = false;


		//��ʱ�ļ�Ŀ¼FOR WEB
        public static string TempWebFolder = @"\EduAdmin_Web\TempFiles\";
		public static string TempFileFolder;	//��ʱ�ļ�����Ŀ¼
		public static string FileSvrFileName;
		public static int intRecommendNum = 20;

		//���������
        public static string ErrorPage = "/EduAdmin_Web/Webform/error.aspx";
        public static string SuccessPage = "/EduAdmin_Web/Webform/success.aspx";
        //��ʱ�ļ�Ŀ¼FOR WEB
        public static string CurrYear;	//��ǰѧ��
        public static string CurrTerm;	//��ǰѧ��
        public static string strUserId;		//��ǰ��¼���û�
        public static string strUserRoleId; //��ǰ��¼�û��Ľ�ɫ�������һ����ɫʱ��
        public static string strUserIp;		//��ǰ��¼���û�IP
        public static string strUserStateId;		//��ǰ��¼�û���״̬ID
        public static string strDepartmentId;//��ǰ��¼�û��Ĳ���ID
        public static ArrayList arrChRightName;
        public static ArrayList arrUserAllRoleIds;

        public static ArrayList arrobjRights;
        public static ArrayList arrRoleRightId;
        public static Hashtable htRightDict = new Hashtable();
        //public static string strExcelFullFileName;	//��ǰ��ѡ��EXCEL�ļ���
        public static string strConnectString4SnCrp1 = "";	//ԭ�������ϵͳ�����Ӵ�
        public static string strConnectString4EduAdmin = "";	//�½������ϵͳ�����Ӵ�
        public static string strAppName = "";	//Ӧ�ó�����
        
		public clsSysPara()
		{
			//
			// TODO: �ڴ˴���ӹ��캯���߼�
			//
		}
        public static string GetAddressIP()
        {
            string server = Dns.GetHostName();
            IPHostEntry heserver = Dns.GetHostEntry(server);
            return heserver.AddressList[0].ToString();
        }

	}
}
