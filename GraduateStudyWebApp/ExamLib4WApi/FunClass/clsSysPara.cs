using System;

namespace ExamLib4WApi
{
    /// <summary>
    /// clsSysPara��
    /// </summary>
    class clsSysPara
    {
        /// <summary>
        /// ��ǰ����ID
        /// </summary>
        public static string CurrPrjId = "0005";
        /// <summary>
        /// 
        /// </summary>
        public static string CurrSelPrjId = "";
        /// <summary>
        /// 
        /// </summary>
        public static string strUserId = "";
        /// <summary>
        /// 
        /// </summary>
        public static string strXMLFolder = @"~\XML\";
        ///// <summary>
        ///// 
        ///// </summary>
        //public static string strXMLFileName;	//���ڶ���SQL�洢���̵�XML�ļ����ơ�
        /// <summary>
        /// 
        /// </summary>
        public static string strXMLDirectory = @"D:\tempFile\";
        ///// <summary>
        ///// ���ڶ���SQL�洢���̵�XML�ļ�����
        ///// </summary>
        //public static string strXmlSpParaFileName;	//���ڶ���SQL�洢���̵�XML�ļ����ơ�
        ///// <summary>
        ///// 
        ///// </summary>
        //public static string ConfigFileName;

        /// <summary>
        /// Xml����Դ
        /// </summary>
        public static string strXmlDataSourceFileName = "";
        /// <summary>
        /// 
        /// </summary>
        public static bool bolIsUseXmlDataSource = false;

        ///���Ӵ�����
        public static string strConnectStrName = "";
        /// <summary>
        /// 
        /// </summary>
        public static bool bolIsUseConnectStrName = false;

        /// <summary>
        /// ��ʱ�ļ�Ŀ¼FOR WEB
        /// </summary>
        public static string TempWebFolder = @"~\TempFiles\";
        ///// <summary>
        ///// 
        ///// </summary>
        //public static string TempFileFolder;	//��ʱ�ļ�����Ŀ¼
        /// <summary>
        /// 
        /// </summary>
        public static string UpLoadFilesWebFolder = @"~\UpLoadFiles\";
        /// <summary>
        /// 
        /// </summary>
        public static string UpLoadFilesFolder = "";	//�ϴ��ļ�����Ŀ¼
        /// <summary>
        /// 
        /// </summary>
        public static string DownLoadFilesWebFolder = @"~\DownLoadFiles\";
        /// <summary>
        /// 
        /// </summary>
        public static string DownLoadFilesFolder = "";	//�����ļ�����Ŀ¼
        ///// <summary>
        ///// 
        ///// </summary>
        //public static string FileSvrFileName;
        /// <summary>
        /// 
        /// </summary>
        public static string ErrorPage = @"~/Webform/Index/wfmError.htm";
        /// <summary>
        /// 
        /// </summary>
        public static string SuccessPage = @"~/Webform/success.aspx";

        /// <summary>
        /// ��ǰ������IPAddress
        /// </summary>
        private static String strCurrIPAddressAndPort = "202.121.48.247";//"127.0.0.1";String.Empty;

        public static String CurrIPAddressAndPort
        {
            get { 
                if (bolIsUseBackupIpAddressAndCurrPrx == true)
                {
                    return clsSysPara.strCurrIPAddressAndPort2;
                }
                else
                {
                    return clsSysPara.strCurrIPAddressAndPort; 
                }
            }
            set { clsSysPara.strCurrIPAddressAndPort = value; }
        }

        /// <summary>
        /// ��ǰ������IPAddress(����)
        /// </summary>
        public static String strCurrIPAddressAndPort2 = "202.121.48.246";//"127.0.0.1";String.Empty;


        /// <summary>
        /// �Ƿ�ʹ�ñ��õ�ͳһƽ̨�����ַ
        /// </summary>
        public static bool bolIsUseBackupIpAddressAndCurrPrx = false;//�Ƿ�ʹ�ñ��õ�ͳһƽ̨�����ַ;
    
        /// <summary>
        /// 
        /// </summary>
        public static String strCurrIPAddressAndPort_Local = "localhost:9259";//"127.0.0.1";String.Empty;

        /// <summary>
        /// ��ǰ�����Ķ˿ں�
        /// </summary>
        private static String strCurrPrx = "Jwc_GP_WS";// String.Empty;

        public static String CurrPrx
        {
            get
            {
                if (bolIsUseBackupIpAddressAndCurrPrx == true)
                {
                    return clsSysPara.strCurrPrx2;
                }
                else
                {
                    return clsSysPara.strCurrPrx;
                }
            }
            set { clsSysPara.strCurrPrx = value; }
        }

        /// <summary>
        /// ��ǰ�����Ķ˿ںţ����ã�
        /// </summary>
        public static String strCurrPrx2 = "Jwc_GP_WS";// String.Empty;

        /// <summary>
        /// �Ƿ񱾻�����״̬
        /// </summary>
        public static bool bolIsLocalHost = false;
    }
}
