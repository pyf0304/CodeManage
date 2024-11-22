using System;
using System.Text;
using System.Collections;
using com.taishsoft.commdbforxml;
using System.Collections.Generic;
using com.taishsoft.common;

namespace ExamLib.Entity
{
    /// <summary>
    /// clsSysPara ��ժҪ˵����
    /// </summary>
    public partial class clsSysParaEN
    {
        /// <summary>
        /// ��־��¼����
        /// </summary>
        public static clsLog objLog = null;
        /// <summary>
        /// ��־��¼����
        /// </summary>
        public static clsLog objErrorLog = null;
        /// <summary>
        /// �Ƿ�ʹ��������У���������ִ�У��Ӻ�ִ��
        /// </summary>
        public static bool spIsUseQueue4Task = false;
        /// <summary>
        /// ��������Ķ���
        /// </summary>
        public static Queue<object> arrFunctionLst4Queue = null;

        /// <summary>
        /// ϵͳ������Ӧ�ó�����
        /// </summary>
        public static string spAppName = "";
        /// <summary>
        /// ϵͳ��������ǰ���ڵ�ѧУ
        /// </summary>
        public static string spSchool;

        /// <summary>
        /// ϵͳ���������ݿ�����Ӵ�
        /// </summary>
        public static string spConnectString = "";

        ///// <summary>
        ///// ��ǰӦ������Ŀ¼,��IP��ַ��������
        ///// </summary>
        //private static string mstrspVirtualPath;		//��ǰӦ������Ŀ¼
        ///// <summary>
        ///// ��ǰӦ������Ŀ¼,����IP��ַ��������
        ///// </summary>
        //private static string mstrspVirtualRoot;		//��ǰӦ������Ŀ¼,����IP��ַ��������

        /// <summary>
        /// ϵͳ������ͳһƽ̨��WebServiceǰ׺����ҪָWebService�ļ�����Ŀ¼
        /// </summary>
        public static string spCurrPrx = "";

        /// <summary>
        /// ϵͳ������ͳһƽ̨��WebService��ַ�Ͷ˿ڡ�(���ô���http://��)
        /// </summary>
        public static string spCurrIPAddressAndPort = "";

        /// <summary>
        /// ϵͳ��������¼ģʽ�������quick���ǣ�û�е�¼ʱ����ģ�飬�Ϳ��ٵ�¼��Ȼ�������и�ģ��
        /// </summary>
        public static string spLoginMode;

        /// <summary>
        /// �û������У���У��University)����Сѧ(MiddleSchool)��ҽԺ(Hospital)����ҵ(Enterprise)
        /// /*<add key="UserType" value="Hospital"/>*/
        /// </summary>
        public static string spUserType = "University";//

        /// <summary>
        /// ϵͳ��������ǰ��¼���û�Id
        /// </summary>
        public static string spUserId;      //ϵͳ��������ǰ���ڵ�ѧУ
        /// <summary>
        /// ϵͳ��������ǰ��¼�û���״̬Id
        /// </summary>
        public static string spUserStateId;
        /// <summary>
        /// ϵͳ��������ǰ��¼���û�IP
        /// </summary>
        public static string spUserIp;

        /// <summary>
        /// ϵͳ��������ǰ��������IP
        /// </summary>
        public static string spServerIp;

        /// <summary>
        /// ϵͳ������ͳһƽ̨�ĵ�ַ
        /// </summary>
        public static string spGeneralPlatform;
        /// <summary>
        /// ϵͳ��������־Ŀ¼
        /// </summary>
        public static string spLogDir;
        /// <summary>
        /// ϵͳ��������������ˢ�»��棬Ĭ��ΪTrue��
        /// </summary>
        public static bool spSetRefreshCacheOn = true;

        /// <summary>
        /// �Ƿ�Debug
        /// </summary>
        public static bool IsDebug;		//ϵͳ�������Ƿ�Debug
        /// <summary>
        /// ������Ƶ��IP��ַ
        /// </summary>
        public static string spVedioIP;		//ϵͳ������������Ƶ��IP��ַ
        /// <summary>
        /// ������Ƶ��IP��ַ�Ƿ��벥����վ��ͬһIP��ַ
        /// </summary>
        public static bool spIsUseVedioIPInSameIP;      //ϵͳ������������Ƶ��IP��ַ�Ƿ��벥����վ��ͬһIP��ַ
        public static string spVirtualRoot;		//ϵͳ������
        public static string spVirtualPath;		//ϵͳ������
        /// <summary>
        /// Flv�ļ��Ĳ���������Ŀ¼
        /// </summary>
        private static string mstrspFlvplayerPath;       //Flv�ļ��Ĳ���������Ŀ¼


        /// <summary>
        /// ϵͳ��������Ƶ�ļ��Ĵ�ŵ�ַ
        /// </summary>
        private static string mstrspFePicSavePath;
        /// <summary>
        /// ϵͳ��������Ƶ�ļ��Ĵ�ŵ�ַ-����
        /// </summary>
        public static string spFePicSavePath_Short;
        /// <summary>
        /// ϵͳ������ͼ���ļ��Ĵ�ŵ�ַ
        /// </summary>
        public static string spImagePath;
        /// <summary>
        /// ϵͳ��������ƽ��Ƶ�ļ��Ĵ�ŵ�ַ
        /// </summary>
        public static string spHuaPingFePicSavePath;
        /// <summary>
        /// 
        /// </summary>
        public static string spPlayerBackGround = "#FF3300";


        /// <summary>
        /// Ӧ�ó�����
        /// </summary>
        public static string strAppName = "";   //Ӧ�ó�����

        /// <summary>
        /// �û������У���У��University)����Сѧ(MiddleSchool)��ҽԺ(Hospital)����ҵ(Enterprise)
        /// /*<add key="UserType" value="Hospital"/>*/
        /// </summary>
        public static string strUserType = "University";


        /// <summary>
        /// ��ǰ��¼�û�Id
        /// </summary>
        public static string strUserId = "";
        /// <summary>
        /// ��ǰ��¼�û���
        /// </summary>
        public static string strUserName = "";
        /// <summary>
        /// ��ǰ��ĿId(PrjId)
        /// </summary>
        public static string CurrPrjId = "";
        /// <summary>
        /// ��ǰ��Ŀ��ѡ���PrjId(����Id)
        /// </summary>
        public static string CurrSelPrjId = "";
        /// <summary>
        /// ��ǰ��¼���û�IP
        /// </summary>
        public static string strUserIp;
        /// <summary>
        /// ��ǰ��¼�û��Ľ�ɫId
        /// </summary>
        public static string strUserRoleId;
        /// <summary>
        /// ��ǰ��¼�û���״̬Id
        /// </summary>
        public static string strUserStateId;		//

        /// <summary>
        /// ��ǰ��¼�û��Ľ�ɫId
        /// </summary>
        public static string strRoleId = "";
        /// <summary>
        /// ��ǰ�û������н�ɫId
        /// </summary>
        public static List<string> arrUserAllRoleIds = null;
        /// <summary>
        /// ��ǰ�û�������Ȩ�������б�
        /// </summary>
        public static List<string> arrChRightName;//
        /// <summary>
        /// ��ǰ��¼�û��Ĳ���ID
        /// </summary>
        public static string strDepartmentId;

        /// <summary>
        /// ������վ��ҳ
        /// </summary>
        public static string strIndexPage = "~/WebForm/Index.aspx";

        /// <summary>
        /// ��ǰʹ�õ�ѧУ����
        /// </summary>
        public static string SchoolName = "";// System.Configuration.ConfigurationSettings.AppSettings["SchoolName"].ToString();

        public static bool bolIsNeedReloadAnswerObjLst = false;//�Ƿ���Ҫ
        public static bool bolIsNeedReloadQuestionOptionsObjLst = false;//�Ƿ���Ҫ

        /// <summary>
        /// ��ǰѧ��
        /// </summary>
        public static string CurrYear;	//��ǰѧ��
        /// <summary>
        /// ��ǰѧ��
        /// </summary>
        public static string CurrTerm;	//��ǰѧ��
        /// <summary>
        /// ��ͳһƽ̨��ʹ�õ�λ
        /// </summary>
        public static string strCompanyName = "";//
        /// <summary>
        /// XmlĿ¼
        /// </summary>
        public static string strXMLFolder = @"~\XML\";
        /// <summary>
        /// ���ڶ���SQL�洢���̵�XML�ļ�����
        /// </summary>
		public static string strXMLFileName = "";	//��
        /// <summary>
        /// ��ʱ��Xml�ļ���
        /// </summary>
        public static string strTempXMLFileName = "";
        /// <summary>
        /// ���ڶ���SQL�洢���̵�XML�ļ�����
        /// </summary>
        public static string strXmlSpParaFileName;  //���ڶ���SQL�洢���̵�XML�ļ����ơ�


        /// <summary>
        /// Xml����Դ�ļ���
        /// </summary>
        public static string strXmlDataSourceFileName = "";
        /// <summary>
        /// ���Xml��SpecSQL
        /// </summary>
        public static clsSpecSQLforXml objSpecSqlForXml = null;
        /// <summary>
        /// �Ƿ�ʹ��Xml����Դ
        /// </summary>
        public static bool bolIsUseXmlDataSource = false;
        /// <summary>
        /// ���Ӵ�����
        /// </summary>
        public static string strConnectStrName = "";
        /// <summary>
        /// �Ƿ�ʹ�����Ӵ�����
        /// </summary>
        public static bool bolIsUseConnectStrName = false;
        /// <summary>
        /// �ϴ��ļ�WebĿ¼
        /// </summary>
        public static string UpLoadFilesWebFolder = @"~/UpLoadFiles/";
        /// <summary>
        /// �ϴ��ļ�WebĿ¼
        /// </summary>
        public static string UploadWebFolder
        {
            get
            {
                return UpLoadFilesWebFolder;
            }
        }
        /// <summary>
        /// �ϴ��ļ�����Ŀ¼
        /// </summary>
        public static string UpLoadFilesFolder = "";
        /// <summary>
        /// �����ļ�WebĿ¼
        /// </summary>
        public static string DownLoadFilesWebFolder = @"~\DownLoadFiles\";
        /// <summary>
        /// �����ļ�����Ŀ¼
        /// </summary>
        public static string DownLoadFilesFolder = "";
        /// <summary>
        /// �����ļ���
        /// </summary>
        public static string ConfigFileName;

        /// <summary>
        /// Web��ʱ�ļ�Ŀ¼
        /// </summary>
        public static string TempWebFolder = @"~\TempFiles\";
        /// <summary>
        /// ��ʱ�ļ�����Ŀ¼
        /// </summary>
		public static string TempFileFolder;

        /// <summary>
        /// Web��������ʾ����
        /// </summary>
        public static string ErrorPage = "~/Webform/ErrorMsg.aspx";
        /// <summary>
        /// Web�ɹ�������ʾ����
        /// </summary>
		public static string SuccessPage = "~/Webform/success.aspx";

        /// <summary>
        /// ��ǰӦ������Ŀ¼
        /// </summary>
        public static string CurrDirectory;
        /// <summary>
        /// �Ƿ�ʹ��SilverLight������
        /// </summary>
        public static bool bolIsUseSilverLightPlay = false;//��
                                                           ///// <summary>
                                                           ///// �Ƿ�֧��ʹ��Html5
                                                           ///// </summary>
                                                           //public static bool bolIsSupportsHtml5 = false;//��

        /// <summary>
        /// ���캯��
        /// </summary>
        public clsSysParaEN()
        {
            //
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
        }
        /// <summary>
        /// ��ȡϵͳ���������ַ�������ʽ����
        /// </summary>
        /// <returns></returns>
        public static string getAllSysPara()
        {
            StringBuilder sbSysPara = new StringBuilder();
            sbSysPara.AppendFormat("ϵͳ������-ֵ��ϵ���£�");
            sbSysPara.AppendFormat("spAppName=[{0}]\r\n", spAppName);
            sbSysPara.AppendFormat("spSchool=[{0}]\r\n", spSchool);
            sbSysPara.AppendFormat("spConnectString=[{0}]\r\n", spConnectString.Length > 10 ? spConnectString.Substring(0, 10) : spConnectString);
            //sbSysPara.AppendFormat("spVirtualPath=[{0}]\r\n", spVirtualPath);
            //sbSysPara.AppendFormat("spVirtualRoot=[{0}]\r\n", spVirtualRoot);
            sbSysPara.AppendFormat("spCurrIPAddressAndPort=[{0}]\r\n", spCurrIPAddressAndPort);
            sbSysPara.AppendFormat("spCurrPrx=[{0}]\r\n", spCurrPrx);
            sbSysPara.AppendFormat("spLoginMode=[{0}]\r\n", spLoginMode);
            sbSysPara.AppendFormat("spUserType=[{0}]\r\n", spUserType);
            sbSysPara.AppendFormat("spUserId=[{0}]\r\n", spUserId);
            sbSysPara.AppendFormat("spUserStateId=[{0}]\r\n", spUserStateId);
            sbSysPara.AppendFormat("spUserIp=[{0}]\r\n", spUserIp);
            sbSysPara.AppendFormat("spGeneralPlatform=[{0}]\r\n", spGeneralPlatform);
            sbSysPara.AppendFormat("spLogDir=[{0}]\r\n", spLogDir);
            sbSysPara.AppendFormat("spSetRefreshCacheOn=[{0}]\r\n", spSetRefreshCacheOn);
            sbSysPara.AppendFormat("IsDebug=[{0}]\r\n", IsDebug);
            sbSysPara.AppendFormat("spVedioIP=[{0}]\r\n", spVedioIP);
            sbSysPara.AppendFormat("spIsUseVedioIPInSameIP=[{0}]\r\n", spIsUseVedioIPInSameIP);
            //sbSysPara.AppendFormat("spFlvplayerPath=[{0}]\r\n", spFlvplayerPath);
            //sbSysPara.AppendFormat("spFePicSavePath=[{0}]\r\n", spFePicSavePath);
            sbSysPara.AppendFormat("spImagePath=[{0}]\r\n", spImagePath);
            sbSysPara.AppendFormat("spPlayerBackGround=[{0}]\r\n", spPlayerBackGround);
            sbSysPara.AppendFormat("spHuaPingFePicSavePath=[{0}]\r\n", spHuaPingFePicSavePath);
            sbSysPara.AppendFormat("strAppName=[{0}]\r\n", strAppName);
            sbSysPara.AppendFormat("strUserType=[{0}]\r\n", strUserType);
            sbSysPara.AppendFormat("strUserId=[{0}]\r\n", strUserId);
            sbSysPara.AppendFormat("strUserName=[{0}]\r\n", strUserName);
            sbSysPara.AppendFormat("CurrPrjId=[{0}]\r\n", CurrPrjId);
            sbSysPara.AppendFormat("CurrSelPrjId=[{0}]\r\n", CurrSelPrjId);
            sbSysPara.AppendFormat("strUserIp=[{0}]\r\n", strUserIp);
            sbSysPara.AppendFormat("strUserRoleId=[{0}]\r\n", strUserRoleId);
            sbSysPara.AppendFormat("strUserStateId=[{0}]\r\n", strUserStateId);
            sbSysPara.AppendFormat("strAppName=[{0}]\r\n", strAppName);
            sbSysPara.AppendFormat("strRoleId=[{0}]\r\n", strRoleId);
            sbSysPara.AppendFormat("arrUserAllRoleIds=[{0}]\r\n", arrUserAllRoleIds);
            sbSysPara.AppendFormat("arrChRightName=[{0}]\r\n", arrChRightName);
            sbSysPara.AppendFormat("strDepartmentId=[{0}]\r\n", strDepartmentId);
            sbSysPara.AppendFormat("strIndexPage=[{0}]\r\n", strIndexPage);
            sbSysPara.AppendFormat("SchoolName=[{0}]\r\n", SchoolName);
            sbSysPara.AppendFormat("CurrYear=[{0}]\r\n", CurrYear);
            sbSysPara.AppendFormat("CurrTerm=[{0}]\r\n", CurrTerm);
            sbSysPara.AppendFormat("strCompanyName=[{0}]\r\n", strCompanyName);
            sbSysPara.AppendFormat("strXMLFolder=[{0}]\r\n", strXMLFolder);
            sbSysPara.AppendFormat("strXMLFileName=[{0}]\r\n", strXMLFileName);
            sbSysPara.AppendFormat("strTempXMLFileName=[{0}]\r\n", strTempXMLFileName);
            sbSysPara.AppendFormat("strXmlSpParaFileName=[{0}]\r\n", strXmlSpParaFileName);
            sbSysPara.AppendFormat("strXmlDataSourceFileName=[{0}]\r\n", strXmlDataSourceFileName);
            sbSysPara.AppendFormat("bolIsUseXmlDataSource=[{0}]\r\n", bolIsUseXmlDataSource);
            sbSysPara.AppendFormat("strConnectStrName=[{0}]\r\n", strConnectStrName);
            sbSysPara.AppendFormat("bolIsUseConnectStrName=[{0}]\r\n", bolIsUseConnectStrName);
            sbSysPara.AppendFormat("UpLoadFilesWebFolder=[{0}]\r\n", UpLoadFilesWebFolder);
            sbSysPara.AppendFormat("UploadWebFolder=[{0}]\r\n", UploadWebFolder);
            sbSysPara.AppendFormat("UpLoadFilesFolder=[{0}]\r\n", UpLoadFilesFolder);
            sbSysPara.AppendFormat("DownLoadFilesWebFolder=[{0}]\r\n", DownLoadFilesWebFolder);
            sbSysPara.AppendFormat("DownLoadFilesFolder=[{0}]\r\n", DownLoadFilesFolder);
            sbSysPara.AppendFormat("ConfigFileName=[{0}]\r\n", ConfigFileName);
            sbSysPara.AppendFormat("TempWebFolder=[{0}]\r\n", TempWebFolder);
            sbSysPara.AppendFormat("TempFileFolder=[{0}]\r\n", TempFileFolder);
            sbSysPara.AppendFormat("ErrorPage=[{0}]\r\n", ErrorPage);
            sbSysPara.AppendFormat("SuccessPage=[{0}]\r\n", SuccessPage);
            sbSysPara.AppendFormat("CurrDirectory=[{0}]\r\n", CurrDirectory);
            sbSysPara.AppendFormat("bolIsUseSilverLightPlay=[{0}]\r\n", bolIsUseSilverLightPlay);
            //sbSysPara.AppendFormat("bolIsSupportsHtml5=[{0}]\r\n", bolIsSupportsHtml5);
            //sbSysPara.AppendFormat("strAppName=[{0}]\r\n", strAppName);
            //sbSysPara.AppendFormat("strAppName=[{0}]\r\n", strAppName);
            //sbSysPara.AppendFormat("strAppName=[{0}]\r\n", strAppName);


            return sbSysPara.ToString();
        }
        /// <summary>
        /// ��ǰ������
        /// </summary>
        public static string strExamYear;   //
        /// <summary>
        /// ��ǰƸ��Id
        /// </summary>
        public static string strCurrEngagePeriodId; //
        /// <summary>
        /// ��ǰƸ������
        /// </summary>
        public static string strCurrEngagePeriodName;   //
        /// <summary>
        /// ��ǰƸ�����б�
        /// </summary>
        public static ArrayList arrCurrEngagePeriodYear;    //
        /// <summary>
        /// �Ƿ�ʹ�ÿ�����ʾ��Ƶ
        /// </summary>
        public static bool bolIsUseWidePage = false;//��
        /// <summary>
        /// ΢���б��Ƿ�ʹ�ÿ�����ʾ��Ƶ��
        /// </summary>
        public static bool bolIsUseWidePage4MicroList = false;//
        /// <summary>
        /// ΢���б��Ƿ�ʹ�������ࣻ
        /// </summary>
        public static bool bolIsUseAdminCls4MicroList = false;//
        /// <summary>
        /// �Ƿ�ʹ�û�ƽ��������
        /// </summary>
        public static bool bolIsUseAvconPlay = false;//
        /// <summary>
        /// �Ƿ�ѧ��ѧ�Σ�
        /// </summary>
        public static bool bolIsUseDisciplineStudyLevel = true;

        /// <summary>
        /// ��΢��༭���Ƿ�ʹ��Html�༭����
        /// </summary>
        public static bool bolIsUseHtmlEditor4MicroTeachEdit = false;
        /// <summary>
        /// ����վ�㣺�ϴ��ļ�WebĿ¼
        /// </summary>
        public static string AddiSiteUpLoadFilesWebFolder = @"~\AddiSite\UpLoadFiles\";
        /// <summary>
        /// ����վ�㣺�ϴ��ļ�����Ŀ¼
        /// </summary>
        public static string AddiSiteUpLoadFilesFolder = "";	//

        /// <summary>
        /// �Ƿ�ȥ���û����飬����ʦ���ѧ�������飬��ʦ����Ϊÿ��ѧ����֣�
        /// </summary>
        public static bool bolIsDeleteUserGroup = true;

        /// <summary>
        /// 
        /// </summary>
        public static string FileSvrFileName;
        /// <summary>
        /// 
        /// </summary>
		public static string strBasicDesc = "������Ϣ";
        /// <summary>
        /// ���ù���Ա��ɫ��RoleId
        /// </summary>
        public static string AdminRoleId
        {
            get
            {
                if (SchoolName == "����ѧԺ")
                {
                    return "01080001";
                }
                else if (SchoolName == "���ն�ʦ")
                {
                    return "01080001";
                }
                else if (SchoolName == "�Ϻ�̩��")
                {
                    return "01080001";
                }
                else
                    return "00830011";
            }
        }

        /// <summary>
        /// ���ý�ʦ��ɫ��RoleId
        /// </summary>
        public static string TeacherRoleId
        {
            get
            {
                if (SchoolName == "����ѧԺ")
                {
                    return "01080002";
                }
                else if (SchoolName == "���ն�ʦ")
                {
                    return "01080002";
                }
                else if (SchoolName == "�Ϻ�̩��")
                {
                    return "01080002";
                }
                else
                    return "00830005";
            }
        }
        /// <summary>
        /// ����ѧ����ɫ��RoleId
        /// </summary>
        public static string StudentRoleId
        {
            get
            {
                if (SchoolName == "����ѧԺ")
                {
                    return "01080003";
                }
                else if (SchoolName == "���ն�ʦ")
                {
                    return "01080003";
                }
                else if (SchoolName == "�Ϻ�̩��")
                {
                    return "01080003";
                }
                else
                    return "00830006";
            }
        }


        /// <summary>
        /// ���ù���Ա��ɫ��RoleId
        /// </summary>
        public static string MajorRoleId
        {
            get
            {
                if (SchoolName == "����ѧԺ")
                {
                    return "01080007";
                }
                else if (SchoolName == "���ն�ʦ")
                {
                    return "01080007";
                }
                else if (SchoolName == "�Ϻ�̩��")
                {
                    return "01080007";
                }
                else
                    return "";
            }
        }

        /// <summary>
        /// Flv�ļ��Ĳ���������Ŀ¼
        /// </summary>
        public static string spFlvplayerPath
        {
            get
            {
                if (string.IsNullOrEmpty(mstrspFlvplayerPath) == true)
                {
                    string strMsg = string.Format("Flv�ļ��Ĳ���������Ŀ¼Ϊ�գ�({0})",
                        clsStackTrace.GetCurrClassFunctionByLevel(3));
                    throw new Exception(strMsg);
                }
                return mstrspFlvplayerPath;
            }

            set
            {
                if (string.IsNullOrEmpty(value) == true)
                {
                    string strMsg = string.Format("Flv�ļ��Ĳ���������Ŀ¼Ϊ�գ�({0})",
                        clsStackTrace.GetCurrClassFunctionByLevel(3));
                    throw new Exception(strMsg);
                }
                mstrspFlvplayerPath = value;
            }
        }
        /// <summary>
        /// ϵͳ��������Ƶ�ļ��Ĵ�ŵ�ַ
        /// </summary>
        public static string spFePicSavePath
        {
            get
            {
                if (string.IsNullOrEmpty(mstrspFePicSavePath) == true)
                {
                    string strMsg = string.Format("ϵͳ����(spFePicSavePath)����Ƶ�ļ��Ĵ�ŵ�ַΪ�գ�({0}->{1}->{2})",
                        clsStackTrace.GetCurrClassFunctionByLevel(3), clsStackTrace.GetCurrClassFunctionByLevel(2), clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                return mstrspFePicSavePath;
            }

            set
            {
                if (string.IsNullOrEmpty(value) == true)
                {
                    string strMsg = string.Format("ϵͳ����(spFePicSavePath)����Ƶ�ļ��Ĵ�ŵ�ַΪ�գ�({0}->{1}->{2})",
                        clsStackTrace.GetCurrClassFunctionByLevel(3), clsStackTrace.GetCurrClassFunctionByLevel(2), clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                mstrspFePicSavePath = value;
            }
        }

        //public static string SpVirtualRoot
        //{
        //    get
        //    {
        //        string strMsg = string.Format("clsSysParaEN.spVirtualRoot=[{0}].In ({1}->{2}",
        //           spVirtualRoot, clsStackTrace.GetCurrClassFunctionByLevel(3), clsStackTrace.GetCurrClassFunctionByLevel(2));
        //        clsSysParaEN.objLog.WriteDebugLog(strMsg);
        //        return spVirtualRoot;
        //    }
        //    set
        //    {
        //        spVirtualRoot = value;
        //        string strMsg = string.Format("clsSysParaEN.spVirtualRoot=[{0}].In ({1}->{2}", 
        //            spVirtualRoot, clsStackTrace.GetCurrClassFunctionByLevel(3), clsStackTrace.GetCurrClassFunctionByLevel(2));
        //        clsSysParaEN.objLog.WriteDebugLog(strMsg);
        //    }
        //}
    }
}
