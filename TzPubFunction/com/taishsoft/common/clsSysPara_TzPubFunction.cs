using System;
//using com.taishsoft.commdbforxml;

namespace com.taishsoft.common
{
	/// <summary>
	/// clsSysPara ��ժҪ˵����
	/// </summary>
    public class clsSysPara_TzPubFunction
	{
        private static string mstrAppType = "WEBAPP"; //Ӧ�����Ϳ����������֣�"WEBAPP","WINAPP"

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
        /// ���ڶ���SQL�洢���̵�XML�ļ�����
        /// </summary>
        public static string strXmlSpParaFileName;	//���ڶ���SQL�洢���̵�XML�ļ����ơ�
        //public static string ConfigFileName;
        //Xml����Դ
        public static string strXmlDataSourceFileName = "";
 
        public static bool bolIsUseXmlDataSource = false;

        ///���Ӵ�����
        public static string strConnectStrName = "";
        /// <summary>
        /// �Ƿ�ʹ�����Ӵ���
        /// </summary>
        public static bool bolIsUseConnectStrName = false;


      
        /// <summary>
        /// �û�ID
        /// </summary>
        public static string strUserId = "";
        /// <summary>
        /// ���Ӵ�
        /// </summary>
        public static string strConnectString = "";
        /// <summary>
        /// PubDataBase�İ汾
        /// </summary>
        public static string strVersion = "2017.12.21.01";

	}
}
