using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using ExamLib.BusinessLogic;


namespace ExamLib.BusinessLogicEx
{
    /// <summary>
    /// clsMyConfig 的摘要说明
    /// </summary>
    /// jkkk
    public class clsMyConfig
    {
        public static string strWebConfigPath = @"~\ConnStr\";

        public clsMyConfig()
        {
            //ptf
            //lyl
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }
        ///// <summary>
        ///// 视频文件的存放地址
        ///// </summary>
        //public static string spFePicSavePath_TS
        //{
        //    get
        //    {
        //        string strFePicSavePath = clsTSysParaBLEx.GetParaValueObjByParaNameAndId_School("FePicSavePath", clsMyConfig.spId_School);
        //        return strFePicSavePath;
        //        //return ConfigurationManager.AppSettings["F~ePicSavePath"].ToString().Trim();
        //    }
        //}
        ///// <summary>
        ///// 统一平台的地址
        ///// </summary>
        //public static string spGeneralPlatform
        //{
        //    get
        //    {
        //        string strGeneralPlatform = clsTSysParaBLEx.GetParaValueObjByParaNameAndId_School("GeneralPlatform", clsMyConfig.spId_School);
        //        return strGeneralPlatform;
        //        //if (System.Configuration.ConfigurationManager.AppSettings["GeneralPlatform"] != null)
        //        //{
        //        //    return System.Configuration.ConfigurationManager.AppSettings["GeneralPlatform"].ToString();
        //        //}
        //        //else
        //        //{
        //        //    return "";
        //        //}
        //    }
        //}

        public static long lngMaxFileSize
        {
            get
            {
                System.Configuration.Configuration rootWebConfig =
    System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration(clsMyConfig.strWebConfigPath);

                AppSettingsSection appSettings =
        rootWebConfig.AppSettings as AppSettingsSection;
                Console.WriteLine("Section name: {0}",
                       appSettings.SectionInformation.SectionName);
                string strMaxFileSize = appSettings.Settings["lngMaxFileSize"].Value;
                return long.Parse(strMaxFileSize);
            }
        }
        public static string strWebFileDir
        {
            get
            {
                System.Configuration.Configuration rootWebConfig =
    System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration(clsMyConfig.strWebConfigPath);

                AppSettingsSection appSettings =
        rootWebConfig.AppSettings as AppSettingsSection;
                Console.WriteLine("Section name: {0}",
                       appSettings.SectionInformation.SectionName);
                string strWebFileDir = appSettings.Settings["strWebFileDir"].Value;
                return strWebFileDir;
            }
        }
        public static string CurrPrjId
        {
            get
            {
                System.Configuration.Configuration rootWebConfig =
    System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration(clsMyConfig.strWebConfigPath);

                AppSettingsSection appSettings =
        rootWebConfig.AppSettings as AppSettingsSection;
                Console.WriteLine("Section name: {0}",
                       appSettings.SectionInformation.SectionName);
                string strCurrPrjId = appSettings.Settings["CurrPrjId"].Value;
                return strCurrPrjId;
            }
        }
        public static string strUploadFileDir
        {
            get
            {
                System.Configuration.Configuration rootWebConfig =
    System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration(clsMyConfig.strWebConfigPath);

                AppSettingsSection appSettings =
        rootWebConfig.AppSettings as AppSettingsSection;
                Console.WriteLine("Section name: {0}",
                       appSettings.SectionInformation.SectionName);
                string strUploadFileDir = appSettings.Settings["strUploadFileDir"].Value;
                return strUploadFileDir;
            }
        }
        public static string strDownloadFileDir
        {
            get
            {
                System.Configuration.Configuration rootWebConfig =
    System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration(clsMyConfig.strWebConfigPath);

                AppSettingsSection appSettings =
        rootWebConfig.AppSettings as AppSettingsSection;
                Console.WriteLine("Section name: {0}",
                       appSettings.SectionInformation.SectionName);
                string strDownloadFileDir = appSettings.Settings["strDownloadFileDir"].Value;
                return strDownloadFileDir;
            }
        }

        public static bool IsUseSameUserId
        {
            get
            {
                System.Configuration.Configuration rootWebConfig =
    System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration(clsMyConfig.strWebConfigPath);

                AppSettingsSection appSettings =
        rootWebConfig.AppSettings as AppSettingsSection;
                Console.WriteLine("Section name: {0}",
                       appSettings.SectionInformation.SectionName);
                string strIsUseSameUserId = appSettings.Settings["IsUseSameUserId"].Value;
                if (string.IsNullOrEmpty(strIsUseSameUserId) == true)
                {
                    return false;
                }
                return bool.Parse(strIsUseSameUserId);
            }
        }
        public static string SiteName
        {
            get
            {
                if (System.Configuration.ConfigurationManager.AppSettings["sitename"] != null)
                {
                    return System.Configuration.ConfigurationManager.AppSettings["sitename"].ToString();
                }
                else
                {
                    return "上海师范大学";
                }
            }
        }
        /// <summary>
        /// 当前的IP地址和端口，用于用户统一平台
        /// </summary>
        public static string CurrIPAddressAndPort
        {
            get
            {
                System.Configuration.Configuration rootWebConfig =
    System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration(clsMyConfig.strWebConfigPath);

                AppSettingsSection appSettings =
        rootWebConfig.AppSettings as AppSettingsSection;
                Console.WriteLine("Section name: {0}",
                       appSettings.SectionInformation.SectionName);
                string strCurrIPAddressAndPort = appSettings.Settings["CurrIPAddressAndPort"].Value;
                return strCurrIPAddressAndPort;
            }
        }
        /// <summary>
        /// 当前的虚拟目录，用于用户统一平台
        /// </summary>
        public static string CurrPrx
        {
            get
            {
                System.Configuration.Configuration rootWebConfig =
    System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration(clsMyConfig.strWebConfigPath);

                AppSettingsSection appSettings =
        rootWebConfig.AppSettings as AppSettingsSection;
                Console.WriteLine("Section name: {0}",
                       appSettings.SectionInformation.SectionName);
                string strCurrPrx = appSettings.Settings["CurrPrx"].Value;
                return strCurrPrx;
            }
        }
        public static string CurrPrxWA
        {
            get
            {
                System.Configuration.Configuration rootWebConfig =
    System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration(clsMyConfig.strWebConfigPath);

                AppSettingsSection appSettings =
        rootWebConfig.AppSettings as AppSettingsSection;
                Console.WriteLine("Section name: {0}",
                       appSettings.SectionInformation.SectionName);
                string strCurrPrxWA = appSettings.Settings["CurrPrxWA"].Value;
                return strCurrPrxWA;
            }
        }
        /// <summary>
        /// 发布的虚拟目录
        /// </summary>
        public static string spVirtualRoot
        {
            get
            {
                //string strLoginMode = clsTSysParaBLEx.GetParaValueObjByParaName("VirtualRoot", spSchool);
                //if (strLoginMode == "empty")
                //{
                //    return "";
                //}
                //return strLoginMode;

                if (System.Configuration.ConfigurationManager.AppSettings["VirtualRoot"] != null)
                {
                    return System.Configuration.ConfigurationManager.AppSettings["VirtualRoot"].ToString();
                }
                else
                {
                    return "";
                }
            }
        }
        ///// <summary>
        ///// 学校流水号
        ///// </summary>
        //public static string spId_School
        //{
        //    get
        //    {
        //        string strId_School = clsXzSchoolBLEx.GetId_SchoolBySchoolId(clsMyConfig.spSchool);
        //        return strId_School;

        //    }
        //}

        /// <summary>
        /// 学校名称
        /// </summary>
        public static string spSchool
        {
            get
            {
                //string strLoginMode = clsTSysParaBLEx.GetCurrSchool();
                //return strLoginMode;
                if (System.Configuration.ConfigurationManager.AppSettings["School"] != null)
                {
                    return System.Configuration.ConfigurationManager.AppSettings["School"].ToString();
                }
                else
                {
                    return "SHNU";
                }
            }
        }

        /// <summary>
        /// 当前的虚拟目录，用于用户统一平台LogDir4Debug
        /// </summary>
        public static bool IsDebug4PubDatabase
        {
            get
            {
                if (System.Configuration.ConfigurationManager.AppSettings["IsDebug4PubDatabase"] != null)
                {
                    return bool.Parse(System.Configuration.ConfigurationManager.AppSettings["IsDebug4PubDatabase"].ToString());
                }
                else
                {
                    return false;
                }

            }
        }

        /// <summary>
        /// Debug的日志目录，用于用户统一平台
        /// </summary>
        public static string LogDir4Debug
        {
            get
            {
                if (System.Configuration.ConfigurationManager.AppSettings["LogDir4Debug"] != null)
                {
                    return System.Configuration.ConfigurationManager.AppSettings["LogDir4Debug"].ToString();
                }
                else
                {
                    return "";
                }

            }
        }
        

        /// <summary>
        /// Debug的日志目录，用于用户统一平台
        /// </summary>
        public static string LogDir4Debug_WebApi
        {
            get
            {
                if (System.Configuration.ConfigurationManager.AppSettings["LogDir4Debug_WebApi"] != null)
                {
                    return System.Configuration.ConfigurationManager.AppSettings["LogDir4Debug_WebApi"].ToString();
                }
                else
                {
                    return "";
                }

            }
        }

        /// <summary>
        /// Debug的日志目录，用于用户统一平台
        /// </summary>
        public static string LogDir4Debug_WS
        {
            get
            {
                if (System.Configuration.ConfigurationManager.AppSettings["LogDir4Debug_WS"] != null)
                {
                    return System.Configuration.ConfigurationManager.AppSettings["LogDir4Debug_WS"].ToString();
                }
                else
                {
                    return "";
                }

            }
        }
        /// <summary>
        /// 发布的机名称
        /// </summary>
        public static string VirtualPath
        {
            get
            {
                if (System.Configuration.ConfigurationManager.AppSettings["VirtualPath"] != null)
                {
                    return System.Configuration.ConfigurationManager.AppSettings["VirtualPath"].ToString();
                }
                else
                {
                    return "";
                }
            }
        }
        /// <summary>
        /// 样例Xls文件名，用于复制生成XLS用，用于ODBC的Excel导出
        /// </summary>
        public static string SamXlsFileName
        {
            get
            {
                System.Configuration.Configuration rootWebConfig =
    System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration(clsMyConfig.strWebConfigPath);

                AppSettingsSection appSettings =
        rootWebConfig.AppSettings as AppSettingsSection;
                Console.WriteLine("Section name: {0}",
                       appSettings.SectionInformation.SectionName);
                string SamXlsFileName = appSettings.Settings["SamXlsFileName"].Value;
                return SamXlsFileName;
            }
        }


        /// <summary>
        /// 学校名称
        /// </summary>
        public static string spSiteName
        {
            get
            {
                //string strLoginMode = clsTSysParaBLEx.GetCurrSiteName();
                //return strLoginMode;
                if (System.Configuration.ConfigurationManager.AppSettings["SiteName"] != null)
                {
                    return System.Configuration.ConfigurationManager.AppSettings["SiteName"].ToString();
                }
                else
                {
                    return "自动生成代码";
                }
            }
        }
        ///// <summary>
        ///// 日志目录
        ///// </summary>
        //public static string spLogDir
        //{
        //    get
        //    {
        //        string strLogDir = clsTSysParaBLEx.GetParaValueObjByParaNameAndId_School("LogDir", clsMyConfig.spId_School);
        //        return strLogDir;
        //        //if (System.Configuration.ConfigurationManager.AppSettings["LogDir"] != null)
        //        //{
        //        //    return System.Configuration.ConfigurationManager.AppSettings["LogDir"].ToString();
        //        //}
        //        //else
        //        //{
        //        //    return "";
        //        //}
        //    }
        //}
        ///// <summary>
        ///// 上传大文件在同一个IP地址
        ///// </summary>
        //public static bool spUploadBigFileInSameIP
        //{
        //    get
        //    {
        //        string strUploadBigFileInSameIP = clsTSysParaBLEx.GetParaValueObjByParaNameAndId_School("UploadBigFileInSameIP", clsMyConfig.spId_School);
        //        if (string.IsNullOrEmpty(strUploadBigFileInSameIP) == true) return false;
        //        return bool.Parse(strUploadBigFileInSameIP);

        //    }
        //}
        ///// <summary>
        ///// 在同一IP地址下,上传大文件的域名。
        ///// </summary>
        //public static string spUploadBigFileBySameIP
        //{
        //    get
        //    {
        //        string strUploadBigFileBySameIP = clsTSysParaBLEx.GetParaValueObjByParaNameAndId_School("UploadBigFileBySameIP", clsMyConfig.spId_School);
        //        if (string.IsNullOrEmpty(strUploadBigFileBySameIP) == true) return "";
        //        return strUploadBigFileBySameIP;

        //    }
        //}
        /// <summary>
        /// 播放器记录日志的WebService的地址
        /// </summary>
        public static string CurrIPAddressAndPort_VideoPlayer
        {
            get
            {
                if (System.Configuration.ConfigurationManager.AppSettings["CurrIPAddressAndPort_VideoPlayer"] != null)
                {
                    return System.Configuration.ConfigurationManager.AppSettings["CurrIPAddressAndPort_VideoPlayer"].ToString();
                }
                else
                {
                    return "";
                }
            }
        }

        /// <summary>
        /// 播放器记录日志的WebService的目录
        /// </summary>
        public static string CurrPrx_VideoPlayer
        {
            get
            {
                if (System.Configuration.ConfigurationManager.AppSettings["CurrPrx_VideoPlayer"] != null)
                {
                    return System.Configuration.ConfigurationManager.AppSettings["CurrPrx_VideoPlayer"].ToString();
                }
                else
                {
                    return "";
                }
            }
        }
        ///// <summary>
        ///// 是否使用SilverLight播放视频
        ///// </summary>
        ///// <returns></returns>
        //public static string getIsUseSilverLightPlay4Mp4B(string strId_School)
        //{
        //    try
        //    {
        //        return clsTSysParaBLEx.GetParaValueObjByParaNameAndId_School("IsUseSilverLightPlay4Mp4", strId_School); //new clsTSysParaBL.GetFirstTSysPara("SysParaName='IsUseSilverLightPlay4Mp4' And SchoolId='" + strSchoolId + "'").SysParaValue;
        //    }
        //    catch (Exception objException)
        //    {
        //        ErrorInformationBL.AddInformation("clsTSysParaEx", "getIsUseSilverLightPlay4Mp4", objException.Message, "pyf");
        //        return "False";
        //    }
        //}
        /// <summary>
        /// 首页
        /// </summary>
        public static string IndexPage
        {
            get
            {
                string strIndexPage = System.Configuration.ConfigurationManager.AppSettings["IndexPage"].ToString();
                ErrorInformationBL.AddInformation("clsMyConfig", "IndexPage", strIndexPage, "pyf");
                if (System.Configuration.ConfigurationManager.AppSettings["IndexPage"] != null)
                {
                    return strIndexPage;
                }
                else
                {
                    return "Index.aspx";
                }
            }
        }
        ///// <summary>
        ///// 视频文件的存放地址
        ///// </summary>
        //public static string spFePicSavePath
        //{
        //    get
        //    {
        //        string strFePicSavePath = clsTSysParaBLEx.GetParaValueObjByParaNameAndId_School("FePicSavePath", clsMyConfig.spId_School);
        //        return strFePicSavePath;
        //        //return ConfigurationManager.AppSettings["F~ePicSavePath"].ToString().Trim();
        //    }
        //}
        ///// <summary>
        ///// 题库的站点地址
        ///// </summary>
        //public static string spExamLibWebSite
        //{
        //    get
        //    {
        //        string strExamLibWebSite = clsTSysParaBLEx.GetParaValueObjByParaNameAndId_School("ExamLibWebSite", clsMyConfig.spId_School);
        //        return strExamLibWebSite;

        //    }
        //}
        ///// <summary>
        ///// 获取缺省教学班流水号
        ///// </summary>
        //public static string spDefaIdCurrEduCls
        //{
        //    get
        //    {
        //        string strExamLibWebSite = clsTSysParaBLEx.GetParaValueObjByParaNameAndId_School("DefaIdCurrEduCls", clsMyConfig.spId_School);
        //        return strExamLibWebSite;

        //    }
        //}
        ///// <summary>
        ///// 播放视频的IP地址是否与播放网站在同一IP地址
        ///// </summary>
        //public static bool spIsUseVedioIPInSameIP
        //{
        //    get
        //    {
        //        string strIsUseVedioIPInSameIP = clsTSysParaBLEx.GetParaValueObjByParaNameAndId_School("IsUseVedioIPInSameIP", clsMyConfig.spId_School);
        //        if (string.IsNullOrEmpty(strIsUseVedioIPInSameIP) == true) return false;
        //        return bool.Parse(strIsUseVedioIPInSameIP);

        //    }
        //}

        ///// <summary>
        ///// 是否自动审核注册用户，即注册好马上就可以使用
        ///// </summary>
        //public static bool spIsAutoAudit4Register
        //{
        //    get
        //    {
        //        string strIsAutoAudit4Register = clsTSysParaBLEx.GetParaValueObjByParaNameAndId_School("IsAutoAudit4Register", clsMyConfig.spId_School);
        //        if (string.IsNullOrEmpty(strIsAutoAudit4Register) == true) return false;
        //        return bool.Parse(strIsAutoAudit4Register);

        //    }
        //}
        ///// <summary>
        ///// 图像目录
        ///// </summary>
        //public static string spImagePath
        //{
        //    get
        //    {
        //        string strImagePath = clsTSysParaBLEx.GetParaValueObjByParaNameAndId_School("ImagePath", clsMyConfig.spId_School);
        //        if (strImagePath == "empty")
        //        {
        //            return "";
        //        }
        //        return strImagePath;

        //        //if (System.Configuration.ConfigurationManager.AppSettings["ImagePath"] != null)
        //        //{
        //        //    return System.Configuration.ConfigurationManager.AppSettings["ImagePath"].ToString();
        //        //}
        //        //else
        //        //{
        //        //    return "";
        //        //}
        //    }
        //}
        ///// <summary>
        ///// 华平视频文件的存放地址
        ///// </summary>
        //public static string spHuaPingHuaPingFePicSavePath
        //{
        //    get
        //    {
        //        string strHuaPingFePicSavePath = clsTSysParaBLEx.GetParaValueObjByParaNameAndId_School("HuaPingFePicSavePath", clsMyConfig.spId_School);
        //        return strHuaPingFePicSavePath;
        //        //return ConfigurationManager.AppSettings["F~ePicSavePath"].ToString().Trim();
        //    }
        //}
        ///// <summary>
        ///// 是否使用SilverLight播放视频
        ///// </summary>
        ///// <returns></returns>
        //public static string getIsUseSilverLightPlay4Mp4(string strId_School)
        //{
        //    try
        //    {
        //        return clsTSysParaBLEx.GetParaValueObjByParaNameAndId_School("IsUseSilverLightPlay4Mp4", strId_School); //new clsTSysParaBL.GetFirstTSysPara("SysParaName='IsUseSilverLightPlay4Mp4' And SchoolId='" + strSchoolId + "'").SysParaValue;
        //    }
        //    catch (Exception objException)
        //    {
        //        ErrorInformationBL.AddInformation("clsTSysParaEx", "getIsUseSilverLightPlay4Mp4", objException.Message, "pyf");
        //        return "False";
        //    }
        //}
        ///// <summary>
        ///// 在课程学习中是否使用学院专业
        ///// </summary>
        //public static bool spIsUseCollegeMajor4CourseLeanring
        //{
        //    get
        //    {
        //        string strIsUseCollegeMajor4CourseLeanring = clsTSysParaBLEx.GetParaValueObjByParaNameAndId_School("IsUseCollegeMajor4CourseLeanring",
        //            clsMyConfig.spId_School);
        //        if (string.IsNullOrEmpty(strIsUseCollegeMajor4CourseLeanring) == true) return false;
        //        return bool.Parse(strIsUseCollegeMajor4CourseLeanring);

        //    }
        //}

        ///// <summary>
        ///// 当前的系统标题,如果不存在,
        ///// </summary>
        //public static string spPageTitle
        //{
        //    get
        //    {
        //        string strPageTitle = clsTSysParaBLEx.GetParaValueObjByParaNameAndId_School("PageTitle", clsMyConfig.spId_School);
        //        if (string.IsNullOrEmpty(strPageTitle) == true)
        //        {
        //            strPageTitle = "教师教育网络平台";
        //        }
        //        return strPageTitle;

        //    }
        //}
        /// <summary>
        /// 是否测试
        /// </summary>
        public static bool IsDebug
        {
            get
            {
                string strIsDebug = System.Configuration.ConfigurationManager.AppSettings["IsDebug"].ToString();
                //ErrorInformationBL.AddInformation("clsMyConfig", "IsDebug", strIsDebug, clsCommonSession.UserId);
                if (System.Configuration.ConfigurationManager.AppSettings["IsDebug"] != null)
                {
                    return bool.Parse(strIsDebug);
                }
                else
                {
                    return false;
                }
            }
        }
        ///// <summary>
        ///// 是否使用宽屏（WidePage)
        ///// </summary>
        ///// <returns></returns>
        //public static string getIsUseWidePageBak(string strId_School)
        //{
        //    try
        //    {
        //        return clsTSysParaBLEx.GetParaValueObjByParaNameAndId_School("IsUseWidePage", strId_School); //new clsTSysParaBL.GetFirstTSysPara("SysParaName='IsUseWidePage' And SchoolId='" + strSchoolId + "'").SysParaValue;
        //    }
        //    catch (Exception objException)
        //    {
        //        ErrorInformationBL.AddInformation("clsTSysParaEx", "getIsUseWidePage", objException.Message, "pyf");
        //        return "True";
        //    }
        //}
        ///// <summary>
        ///// 微格列表－是否使用宽屏（WidePage)
        ///// </summary>
        ///// <returns></returns>
        //public static string getIsUseWidePage4MicroListBak(string strId_School)
        //{
        //    try
        //    {
        //        return clsTSysParaBLEx.GetParaValueObjByParaNameAndId_School("IsUseWidePage4MicroList", strId_School); //new clsTSysParaBL.GetFirstTSysPara("SysParaName='IsUseWidePage4MicroList' And SchoolId='" + strSchoolId + "'").SysParaValue;
        //    }
        //    catch (Exception objException)
        //    {
        //        ErrorInformationBL.AddInformation("clsTSysParaEx", "getIsUseWidePage4MicroList", objException.Message, "pyf");
        //        return "True";
        //    }
        //}
        ///// <summary>
        ///// 微格列表－是否使用行政班（AdminCls)
        ///// </summary>
        ///// <returns></returns>
        //public static string getIsUseAdminCls4MicroListBak(string strId_School)
        //{
        //    try
        //    {

        //        return clsTSysParaBLEx.GetParaValueObjByParaNameAndId_School("IsUseAdminCls4MicroList", strId_School); //new clsTSysParaBL.GetFirstTSysPara("SysParaName='IsUseAdminCls4MicroList' And SchoolId='" + strSchoolId + "'").SysParaValue;
        //    }
        //    catch (Exception objException)
        //    {
        //        ErrorInformationBL.AddInformation("clsTSysParaEx", "getIsUseAdminCls4MicroList", objException.Message, "pyf");
        //        return "True";
        //    }
        //}

        //public static string getIsUseAvconPlayBak(string strId_School)
        //{

        //    try
        //    {
        //        return clsTSysParaBLEx.GetParaValueObjByParaNameAndId_School("IsUseAvconPlay", strId_School); //new clsTSysParaBL.GetFirstTSysPara("SysParaName='IsUseAvconPlay'").SysParaValue;
        //    }
        //    catch (Exception objException)
        //    {
        //        ErrorInformationBL.AddInformation("clsTSysParaEx", "getIsUseAvconPlay", objException.Message, "pyf");
        //        return "False";
        //    }

        //}

        ///// <summary>
        ///// 是否使用学科学段
        ///// </summary>
        ///// <returns></returns>
        //public static string getIsUseDisciplineStudyLevelBak(string strId_School)
        //{
        //    try
        //    {
        //        return clsTSysParaBLEx.GetParaValueObjByParaNameAndId_School("IsUseDisciplineStudyLevel", strId_School); //new clsTSysParaBL.GetFirstTSysPara("SysParaName='IsUseDisciplineStudyLevel' And SchoolId='" + strSchoolId + "'").SysParaValue;
        //    }
        //    catch (Exception objException)
        //    {
        //        ErrorInformationBL.AddInformation("clsTSysParaEx", "getIsUseDisciplineStudyLevel", objException.Message, "pyf");
        //        return "True";
        //    }

        //}

        ///// <summary>
        ///// 在微格编辑中是否使用Html编辑器
        ///// </summary>
        ///// <returns></returns>
        //public static string getIsUseHtmlEditor4MicroTeachEditBak(string strId_School)
        //{
        //    try
        //    {
        //        return clsTSysParaBLEx.GetParaValueObjByParaNameAndId_School("IsUseHtmlEditor4MicroTeachEdit", strId_School); //new clsTSysParaBL.GetFirstTSysPara("SysParaName='IsUseHtmlEditor4MicroTeachEdit' And SchoolId='" + strSchoolId + "'").SysParaValue;
        //    }
        //    catch (Exception objException)
        //    {
        //        ErrorInformationBL.AddInformation("clsTSysParaEx", "getIsUseHtmlEditor4MicroTeachEdit", objException.Message, "pyf");
        //        return "False";
        //    }
        //}
        ///// <summary>
        ///// 是否使用SilverLight播放视频
        ///// </summary>
        ///// <returns></returns>
        //public static string getIsUseSilverLightPlayBak(string strId_School)
        //{
        //    try
        //    {
        //        return clsSysParaBLEx.GetParaValueObjByParaNameAndId_School("IsUseSilverLightPlay", strId_School); //new clsTSysParaBL.GetFirstTSysPara("SysParaName='IsUseSilverLightPlay' And SchoolId='" + strSchoolId + "'").SysParaValue;
        //    }
        //    catch (Exception objException)
        //    {
        //        ErrorInformationBL.AddInformation("clsTSysParaEx", "getIsUseSilverLightPlay", objException.Message, "pyf");
        //        return "False";
        //    }
        //}
    }
}