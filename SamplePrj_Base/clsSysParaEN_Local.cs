
using System;
using com.taishsoft.commdbforxml;
using com.taishsoft.common;


namespace SimplePrj.Entity
{

    /// <summary>
    /// clsSysParaEN 的摘要说明。
    /// </summary>
    public class clsSysParaEN_Local : clsSysParaEN
    {
        //public static clsLog objLog = new clsLog();
        public static string UpLoadFilesWebFolderCC = @"~\CourseUpload\";
        public static string UpLoadFilesFolderCC = "";	//上传文件物理目录
        public static string TeachCaseDownLoadWebFolder = @"~\Upload\Documentation\";
        public static string TeachCaseDownLoadFolder = "";	//下载文件物理目录
        public static string TopicDownLoadFolder = @"~\Upload\Topic\";	//上传下载话题附件物理目录
        public static string InvitationDownLoadFolder = @"~\Upload\Invitation\";	//上传下载话题附件物理目录

        public static string strMainJobDesc = "主要工作";
        public static string strCurrPrjConnectString = "";  //当前所选工作的连接串
        public static string strVersion = "6.3.0.0";

      
        


        public clsSysParaEN_Local()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }
    }
}
