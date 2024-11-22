using com.taish.media;
using com.taishsoft.common;
using com.taishsoft.datetime;
using CommFunc4WebForm;
using ExamLib.Entity;
 
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Web.UI;

using ExamLib.BusinessLogic;

namespace ExamLib.BusinessLogicEx
{
    public partial class clstz_ContentAttachmentBLEx
    {

        /// <summary>
        /// 从缓存中查找失败的次数
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_Business:A_GenBusinessLogicCode)
        /// </summary>
        private static string strLastContentTypeId = "";
        /// <summary>
        /// 从缓存中查找失败的次数
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_Business:A_GenBusinessLogicCode)
        /// </summary>
        public static List<clstz_ContentAttachmentEN> arrtz_ContentAttachmentObjLst4OneTableName_Cache = null;
        /// <summary>
        /// 获取显示扩展资源的串，把这串赋给一个控件，可以显示资源
        /// </summary>
        /// <param name="arrvtz_ContentAttachmentObjLst"></param>
        /// <param name="bolIsSupportsHtml5"></param>
        /// <param name="bolIsUseSilverLightPlay4Mp4"></param>
        /// <param name="objErrorLog"></param>
        /// <param name="bolIsOriginalSize">是否是原尺寸</param>
        /// <returns></returns>
        public static string GetShowExtResourceString(List<clsvtz_ContentAttachmentEN> arrvtz_ContentAttachmentObjLst,
              bool bolIsSupportsHtml5,
            bool bolIsUseSilverLightPlay4Mp4,
            clsLog objErrorLog, bool bolIsOriginalSize, 
            string strParantName, 
            bool bolIsIE,
            ref int intTotalContentHeight, bool bolIsShowFileName=false)
        {
            //0001	0001	视频		.mpg,.avi,.mpeg,.asf,.wmv,.mp4,.rm,.rmvb,.3gp,.3gpp,.avms,.avds,.avc	
            //0002	0002	音频		.mid,.mmf,.mp3,.wav,.midi,.wav,.amr,.avms,.avds,.avc	
            //0003	0003	动画		.swf	
            //0004	0004	图片		.jpg,.gif,.PNG	
            //0005	0005	其它		.doc,.docx,.txt,.xls,.xlsx,.ppt,.pptx,.rar,.zip,.pdf	
            //0006	0006	PPT		.ppt,.pptx	
            //0007	0007	Word文档		.doc,.docx	
            //0008	0008	Access文档	NULL	.accdb,.mdb	NULL
            //0009	0009	XPS文档	NULL	.xps,	NULL
            //0010    0010    纯文本 NULL    NULL NULL    NULL
            //0011    0011    Html文本 NULL    NULL NULL    NULL NULL
            //0012    0012    压缩文件.zip,.rar,	NULL NULL    NULL NULL
            //0013    0013    Pdf文件.pdf,	NULL NULL    NULL NULL
            //0014    0014    Excel文件.xls,.xlsx,	NULL NULL    NULL NULL
            string strExtResourceString = "";
            string strMsg = "";
            string strWebFilePath = "";
            string strFileName = "";
            string strFullFileName = "";
            string strHtml = "";
            intTotalContentHeight = 0;//总内容高
            clsPlayClass objPlayClass = null;
            clsMediaItem objMediaItem = null;
            
            //int intImgIndex = 1;
            foreach (clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN in arrvtz_ContentAttachmentObjLst)
            {
                StringBuilder sbHtml_Other = new StringBuilder();

                //string strExtResourceString_Item = "";
                string strObjId = "";// string.Format("img{0}", intImgIndex++);
                switch (objvtz_ContentAttachmentEN.IdResourceType)
                {

                    case "0001"://	0001	视频		.mpg,.avi,.mpeg,.asf,.wmv,.mp4,.rm,.rmvb,.3gp,.3gpp,.avms,.avds,.avc	
                        strObjId = string.Format("{1}_divVideo{0}", 
                            objvtz_ContentAttachmentEN.OrderNum,
                            strParantName);

                        strWebFilePath = clsSysParaEN.spVirtualRoot + "/" + objvtz_ContentAttachmentEN.FilePath;
                        strFileName = System.Web.HttpContext.Current.Server.MapPath(strWebFilePath);
                        if (File.Exists(strFileName) == false)
                        {
                            strMsg = string.Format("Web站点文件：{0}不存在，请检查该案例是否有资源！", "~/" + objvtz_ContentAttachmentEN.FilePath);
                            objErrorLog.WriteDebugLog(strMsg);

                            string strReturnValue = string.Format(" <img id=\"imgTemp4Tz\" src=\"../../img/19999.gif\" alt=\"{0}\" style=\"height:69px;width:146px;border-width:0px;\" />"
                                            , "~/" + objvtz_ContentAttachmentEN.FilePath);
                            return strReturnValue;
                            //throw new Exception(strMsg);
                        }

                        strFullFileName = clsSysParaEN.spVirtualPath + "/" + objvtz_ContentAttachmentEN.FilePath;
                        //strFullFileName = strFullFileName.Replace("//", "/");
                        //strFullFileName = strFullFileName.Replace("ExamLib/ExamLib", "ExamLib");
                        //strFullFileName = strFullFileName.Replace("ExamLib//ExamLib", "ExamLib");
                        //strFullFileName = strFullFileName.Replace("TeachingResTwo/TeachingResTwo", "TeachingResTwo");
                        //strFullFileName = strFullFileName.Replace("TeachingResTwo//TeachingResTwo", "TeachingResTwo");

                        objMediaItem = new clsMediaItem();
                        objMediaItem.Extension = objvtz_ContentAttachmentEN.Extension;
                        objMediaItem.src = strFullFileName;
                        objMediaItem.name = objvtz_ContentAttachmentEN.FileName.Replace("'", "");
                        objMediaItem.FullFileName = "";
                        objMediaItem.IsExistFile = true;
                        objMediaItem.ObjId = strObjId;
                        objMediaItem.Autoplay = false;
                        //clsMediaItem objMediaItem2 = new clsMediaItem();
                        //objMediaItem2.Extension = objvResource.ftpFileType;
                        ////objMediaItem2.src = url;
                        //objMediaItem2.src = "http://tstc.hytc.edu.cn/TestMedia/xbox.wmv";// strServer + strFile;

                        //objMediaItem2.name = strFile;
                        //objMediaItem2.FullFileName = "";
                        //objMediaItem2.IsExistFile = true;

                        objPlayClass = new clsPlayClass(objMediaItem);
                        //objPlayClass.SetSecondMediaItem(objMediaItem2);

                        objPlayClass.Height1 = 400;
                        objPlayClass.Width1 = 480;
                        //objPlayClass.Height2 = 180;
                        //objPlayClass.Width2 = 240;
                        objPlayClass.IsUseSilverLightPlay4Wmv = clsSysParaEN.bolIsUseSilverLightPlay;
                        objPlayClass.IsUseSilverLightPlay4Mp4 = bolIsUseSilverLightPlay4Mp4;

                        objPlayClass.SilverLightClientBinPath = clsSysParaEN.spVirtualRoot + "/ClientBin/TzMedia.xap";
                        objPlayClass.IsSupportsHtml5 = bolIsSupportsHtml5;
                        objPlayClass.PlayerVersion = PlayerVersionType.TZMediaPlayerV7;
                        objPlayClass.PlayerBackGround = "#FF3300";
                        objPlayClass.IsDualVideo = false;
                        objPlayClass.IsIE = bolIsIE;
                        //if (arrExerciseTimeObjLst.Count > 0)
                        //{
                        //    objPlayClass.SetExerciseTime(arrExerciseTimeObjLst);
                        //    objPlayClass.IsUseSilverLightPlay4Mp4 = true;//如果有播放中习题，就使用SilverLight来播放mp4
                        //    //最好在HTML5方式来使用【播放中习题】，等待改进。
                        //}
                        strHtml = objPlayClass.Play();
                        strExtResourceString += strHtml;
                        intTotalContentHeight += objPlayClass.Height1;
                        break;
                    case "0002"://	0002	音频		.mid,.mmf,.mp3,.wav,.midi,.wav,.amr,.avms,.avds,.avc	
                        strObjId = string.Format("{1}_divAudeo{0}",
                              objvtz_ContentAttachmentEN.OrderNum,
                               strParantName);

                        strWebFilePath = clsSysParaEN.spVirtualRoot + "/" + objvtz_ContentAttachmentEN.FilePath;
                        strFileName = System.Web.HttpContext.Current.Server.MapPath(strWebFilePath);
                        if (File.Exists(strFileName) == false)
                        {
                            strMsg = string.Format("Web站点文件：{0}不存在，请检查该案例是否有资源！", "~/" + objvtz_ContentAttachmentEN.FilePath);
                            objErrorLog.WriteDebugLog(strMsg);

                            string strReturnValue = string.Format(" <img id=\"imgTemp4Tz\" src=\"../../img/19999.gif\" alt=\"{0}\" style=\"height:69px;width:146px;border-width:0px;\" />"
                                            , "~/" + objvtz_ContentAttachmentEN.FilePath);
                            return strReturnValue;
                            //throw new Exception(strMsg);
                        }

                        strFullFileName = clsSysParaEN.spVirtualPath + "/" + objvtz_ContentAttachmentEN.FilePath;
                        //strFullFileName = strFullFileName.Replace("//", "/");
                        //strFullFileName = strFullFileName.Replace("ExamLib/ExamLib", "ExamLib");
                        //strFullFileName = strFullFileName.Replace("ExamLib//ExamLib", "ExamLib");
                        //strFullFileName = strFullFileName.Replace("TeachingResTwo/TeachingResTwo", "TeachingResTwo");
                        //strFullFileName = strFullFileName.Replace("TeachingResTwo//TeachingResTwo", "TeachingResTwo");

                        objMediaItem = new clsMediaItem();
                        objMediaItem.Extension = objvtz_ContentAttachmentEN.Extension;
                        objMediaItem.src = strFullFileName;
                        objMediaItem.name = objvtz_ContentAttachmentEN.FileName.Replace("'", "");
                        objMediaItem.FullFileName = "";
                        objMediaItem.IsExistFile = true;
                        objMediaItem.ObjId = strObjId;
                        objMediaItem.Autoplay = false;
                        objPlayClass = new clsPlayClass(objMediaItem);
                        //objPlayClass.SetSecondMediaItem(objMediaItem2);

                        objPlayClass.Height1 = 400;
                        objPlayClass.Width1 = 480;
                        //objPlayClass.Height2 = 180;
                        //objPlayClass.Width2 = 240;
                        objPlayClass.IsUseSilverLightPlay4Wmv = clsSysParaEN.bolIsUseSilverLightPlay;
                        objPlayClass.IsUseSilverLightPlay4Mp4 = bolIsUseSilverLightPlay4Mp4;

                        objPlayClass.SilverLightClientBinPath = clsSysParaEN.spVirtualRoot + "/ClientBin/TzMedia.xap";
                        objPlayClass.IsSupportsHtml5 = bolIsSupportsHtml5;
                        objPlayClass.PlayerVersion = PlayerVersionType.TZMediaPlayerV7;
                        objPlayClass.PlayerBackGround = "#FF3300";
                        objPlayClass.IsDualVideo = false;
                        objPlayClass.IsIE = bolIsIE;
                        //if (arrExerciseTimeObjLst.Count > 0)
                        //{
                        //    objPlayClass.SetExerciseTime(arrExerciseTimeObjLst);
                        //    objPlayClass.IsUseSilverLightPlay4Mp4 = true;//如果有播放中习题，就使用SilverLight来播放mp4
                        //    //最好在HTML5方式来使用【播放中习题】，等待改进。
                        //}
                        strHtml = objPlayClass.Play();
                        StringBuilder sbHtml_Audio = new StringBuilder();
                        sbHtml_Audio.AppendFormat("<div id=\"{1}_divAudio{0}\">",
                            objvtz_ContentAttachmentEN.OrderNum,
                            strParantName);
                        if (bolIsShowFileName == true)
                        {
                            sbHtml_Audio.AppendFormat("<div style=\"width:40%; float:left;\"><span>{0}({1})</span></div>",
                           objvtz_ContentAttachmentEN.AttachmentTitle, objvtz_ContentAttachmentEN.FileName);
                            if (strHtml.IndexOf("<div>") >= 0)
                            {
                                strHtml = strHtml.Replace("<div>", "<div style =\"width:59%; float:right;\">");
                            }
                            sbHtml_Audio.Append(strHtml);

                            sbHtml_Audio.Append("</div>");
                        }
                        else//不显示文件名
                        {
                            if (strHtml.IndexOf("<div>") >= 0)
                            {
                                strHtml = strHtml.Replace("<div>", "<div style =\"width:99%; float:left;\">");
                            }
                            sbHtml_Audio.Append(strHtml);

                            sbHtml_Audio.Append("</div>");
                        }
                        strExtResourceString += sbHtml_Audio.ToString();
                        if (objPlayClass.Height1 > 0)
                        {
                            intTotalContentHeight += objPlayClass.Height1;
                        }
                        else
                        {
                            intTotalContentHeight += objvtz_ContentAttachmentEN.ImageHeight ?? 0;
                        }
                        break;
                    case "0003"://	0003	动画		.swf

                        sbHtml_Other.AppendFormat("<div id=\"{1}_divAnimation{0}\" class=\"topContent4\" >",
                            objvtz_ContentAttachmentEN.OrderNum,
                            strParantName);

                        sbHtml_Other.AppendFormat("<a href=\"{0}\" style=\"cursor: pointer\">",
                            clsSysParaEN.spVirtualPath + "/" + objvtz_ContentAttachmentEN.FilePath);
                        sbHtml_Other.AppendFormat("[{1}]下载：{0}",
                            objvtz_ContentAttachmentEN.FileName,
                            objvtz_ContentAttachmentEN.ResourceTypeName);
                        sbHtml_Other.Append("</a>");
                        sbHtml_Other.Append("</div>");
                        strExtResourceString += sbHtml_Other.ToString();                    
                        break;
                    case "0004"://	0004	图片		.jpg,.gif,.PNG	
                        strObjId = string.Format("{1}_img{0}", 
                            objvtz_ContentAttachmentEN.OrderNum,
                            strParantName);

                        //          clsResourceUrlBL objResourceUrl = GetResourceUrlByResourceID(ResourceID);
                        //if (objResourceUrl == null) return "";
                        //if (objResourceUrl.IsExistFile == false)
                        //{
                        //    return objResourceUrl.ErrorResult;
                        //}
                        strWebFilePath = clsSysParaEN.spVirtualRoot + "/" + objvtz_ContentAttachmentEN.FilePath;
                        strFileName = System.Web.HttpContext.Current.Server.MapPath(strWebFilePath);
                        if (File.Exists(strFileName) == false)
                        {
                            strMsg = string.Format("源文件不存在！文件名：{1}，Web站点文件：{0}，请检查该案例是否有资源！", 
                                "~/" + objvtz_ContentAttachmentEN.FilePath,
                                strFileName);

                            objErrorLog.WriteDebugLog(strMsg);

                            string strReturnValue = string.Format(" <img id=\"imgTemp4Tz\" src=\"../../img/19999.gif\" alt=\"{0}\" style=\"height:240px;width:320px;border-width:0px;\" />"
                                            , "~/" + objvtz_ContentAttachmentEN.FilePath);
                            return strReturnValue;
                            //throw new Exception(strMsg);
                        }

                        strFullFileName = clsSysParaEN.spVirtualPath + "/" + objvtz_ContentAttachmentEN.FilePath;
                        //strFullFileName = strFullFileName.Replace("//", "/");
                        //strFullFileName = strFullFileName.Replace("ExamLib/ExamLib", "ExamLib");
                        //strFullFileName = strFullFileName.Replace("ExamLib//ExamLib", "ExamLib");
                        //strFullFileName = strFullFileName.Replace("TeachingResTwo/TeachingResTwo", "TeachingResTwo");
                        //strFullFileName = strFullFileName.Replace("TeachingResTwo//TeachingResTwo", "TeachingResTwo");

                        objMediaItem = new clsMediaItem();
                        objMediaItem.Extension = objvtz_ContentAttachmentEN.Extension;
                        objMediaItem.src = strFullFileName;
                        objMediaItem.name = objvtz_ContentAttachmentEN.FileName.Replace("'", "");
                        objMediaItem.FullFileName = "";
                        objMediaItem.IsExistFile = true;
                        objMediaItem.ObjId = strObjId;                        

                        objPlayClass = new clsPlayClass(objMediaItem);
                        //objPlayClass.SetSecondMediaItem(objMediaItem2);
                        if (bolIsOriginalSize == true)
                        {
                            objPlayClass.Height1 = 0;
                            objPlayClass.Width1 = 0;
                        }
                        else
                        {                           
                            if (objvtz_ContentAttachmentEN.ImageHeight > 180 || objvtz_ContentAttachmentEN.ImageWidth > 270)
                            {
                                try
                                {
                                    float fltRatio = (objvtz_ContentAttachmentEN.ImageWidth ?? 0 * 1.0f) / (objvtz_ContentAttachmentEN.ImageHeight ?? 0 * 1.0f);
                                    if (fltRatio>1.5)
                                    {
                                        objPlayClass.Width1 = 270;
                                        objPlayClass.Height1 = (int)(270 / fltRatio);
                                    }
                                    else
                                    {
                                        objPlayClass.Height1 = 180;
                                        objPlayClass.Width1 = (int)(180 * fltRatio);
                                        //objPlayClass.Height1 = 360;
                                        //objPlayClass.Width1 = 240;

                                    }
                                }
                                catch (Exception objException)
                                {
                                    strMsg = string.Format("在设置图片纵横比时出错，错误信息：[{0}]. ({1})",
                                       objException.Message,
                                       clsStackTrace.GetCurrClassFunction());
                                    throw new Exception(strMsg);
                                }
                                //objPlayClass.Height1 = 240;
                                //objPlayClass.Width1 = 360;
                            }
                            else
                            {
                                objPlayClass.Height1 = 0;
                                objPlayClass.Width1 = 0;
                            }
                        }
                        //objPlayClass.Height2 = 180;
                        //objPlayClass.Width2 = 240;
                        objPlayClass.IsUseSilverLightPlay4Wmv = clsSysParaEN.bolIsUseSilverLightPlay;
                        objPlayClass.IsUseSilverLightPlay4Mp4 = bolIsUseSilverLightPlay4Mp4;

                        objPlayClass.SilverLightClientBinPath = clsSysParaEN.spVirtualRoot + "/ClientBin/TzMedia.xap";
                        objPlayClass.IsSupportsHtml5 = bolIsSupportsHtml5;
                        objPlayClass.PlayerVersion = PlayerVersionType.TZMediaPlayerV7;
                        objPlayClass.PlayerBackGround = "#FF3300";
                        objPlayClass.IsDualVideo = false;
                        
                        strHtml = objPlayClass.Play();
                        StringBuilder sbHtml_SeeBig = new StringBuilder();
                        sbHtml_SeeBig.AppendFormat("<div id=\"{1}_divImg{0}\">", 
                            objvtz_ContentAttachmentEN.OrderNum,
                            strParantName);

                        sbHtml_SeeBig.AppendFormat("<a href=\"###\" onclick=\"seeBig(this)\" style=\"cursor: pointer\">");  
                        sbHtml_SeeBig.Append(strHtml);
                        sbHtml_SeeBig.Append("</a>");
                        sbHtml_SeeBig.Append("</div>");
                        sbHtml_SeeBig.AppendFormat("<div id = \"{0}_divImg{1}_Original\">", 
                            strParantName, objvtz_ContentAttachmentEN.OrderNum);
                        sbHtml_SeeBig.Append("</div>");

                         strExtResourceString += sbHtml_SeeBig.ToString();
                        if (objPlayClass.Height1 > 0)
                        {
                            intTotalContentHeight += objPlayClass.Height1;
                        }
                        else
                        {
                            intTotalContentHeight += objvtz_ContentAttachmentEN.ImageHeight ?? 0;
                        }
                        break;
                    case "0005"://	0005	其它		.doc,.docx,.txt,.xls,.xlsx,.ppt,.pptx,.rar,.zip,.pdf	

                        sbHtml_Other.AppendFormat("<div id=\"{1}_divOther{0}\" class=\"topContent4\" >",
                            objvtz_ContentAttachmentEN.OrderNum,
                            strParantName);

                        sbHtml_Other.AppendFormat("<a href=\"{0}\" style=\"cursor: pointer\">",
                            clsSysParaEN.spVirtualPath + "/" + objvtz_ContentAttachmentEN.FilePath);
                        sbHtml_Other.AppendFormat("[{1}]下载：{0}",
                            objvtz_ContentAttachmentEN.FileName,
                            objvtz_ContentAttachmentEN.ResourceTypeName);
                        sbHtml_Other.Append("</a>");
                        sbHtml_Other.Append("</div>");
                        strExtResourceString += sbHtml_Other.ToString();
                        break;
                       
                    case "0006"://	0006	PPT		.ppt,.pptx	
                        sbHtml_Other.AppendFormat("<div id=\"{1}_divPPT{0}\" class=\"topContent4\" >",
                            objvtz_ContentAttachmentEN.OrderNum,
                            strParantName);

                        sbHtml_Other.AppendFormat("<a href=\"{0}\" style=\"cursor: pointer\">",
                            clsSysParaEN.spVirtualPath + "/" + objvtz_ContentAttachmentEN.FilePath);
                        sbHtml_Other.AppendFormat("[{1}]下载：{0}",
                            objvtz_ContentAttachmentEN.FileName,
                            objvtz_ContentAttachmentEN.ResourceTypeName);
                        sbHtml_Other.Append("</a>");
                        sbHtml_Other.Append("</div>");
                        strExtResourceString += sbHtml_Other.ToString();
                        break;                       
                    case "0007"://	0007	Word文档		.doc,.docx	
                        sbHtml_Other.AppendFormat("<div id=\"{1}_divWord{0}\" class=\"topContent4\" >",
                            objvtz_ContentAttachmentEN.OrderNum,
                            strParantName);
                        sbHtml_Other.AppendFormat("<a href=\"{0}\" style=\"cursor: pointer\">",
                            clsSysParaEN.spVirtualPath + "/" + objvtz_ContentAttachmentEN.FilePath);
                        sbHtml_Other.AppendFormat("[{1}]下载：{0}",
                            objvtz_ContentAttachmentEN.FileName,
                            objvtz_ContentAttachmentEN.ResourceTypeName);
                        sbHtml_Other.Append("</a>");
                        sbHtml_Other.Append("</div>");
                        strExtResourceString += sbHtml_Other.ToString();
                        break;
                    case "0008"://	0008	Access文档	NULL	.accdb,.mdb	NULL
                        sbHtml_Other.AppendFormat("<div id=\"{1}_divAccess{0}\" class=\"topContent4\" >",
                            objvtz_ContentAttachmentEN.OrderNum,
                            strParantName);
                        sbHtml_Other.AppendFormat("<a href=\"{0}\" style=\"cursor: pointer\">",
                            clsSysParaEN.spVirtualPath + "/" + objvtz_ContentAttachmentEN.FilePath);
                        sbHtml_Other.AppendFormat("[{1}]下载：{0}",
                            objvtz_ContentAttachmentEN.FileName,
                            objvtz_ContentAttachmentEN.ResourceTypeName);
                        sbHtml_Other.Append("</a>");
                        sbHtml_Other.Append("</div>");
                        strExtResourceString += sbHtml_Other.ToString();
                        break;
                    case "0009"://	0009	XPS文档	NULL	.xps,	NULL
                        sbHtml_Other.AppendFormat("<div id=\"{1}_divXPS{0}\" class=\"topContent4\" >",
                            objvtz_ContentAttachmentEN.OrderNum,
                            strParantName);
                        sbHtml_Other.AppendFormat("<a href=\"{0}\" style=\"cursor: pointer\">",
                            clsSysParaEN.spVirtualPath + "/" + objvtz_ContentAttachmentEN.FilePath);
                        sbHtml_Other.AppendFormat("[{1}]下载：{0}",
                            objvtz_ContentAttachmentEN.FileName,
                            objvtz_ContentAttachmentEN.ResourceTypeName);
                        sbHtml_Other.Append("</a>");
                        sbHtml_Other.Append("</div>");
                        strExtResourceString += sbHtml_Other.ToString();
                        break;
                    case "0010"://	0010	纯文本
                        StringBuilder sbHtml_Text = new StringBuilder();
                        sbHtml_Text.AppendFormat("<div id=\"{1}_divText{0}\" class=\"topContent2\" >",
                            objvtz_ContentAttachmentEN.OrderNum,
                            strParantName);
                        string strHtmlContent = clsWebString.getHtmlEncodeFromTextCode(objvtz_ContentAttachmentEN.TextContent);
                        sbHtml_Text.Append(strHtmlContent);
                        sbHtml_Text.Append("</div>");

                        strExtResourceString += sbHtml_Text.ToString();

                        break;
                    case "0011"://	0011	HTML文本
                        StringBuilder sbHtml_HtmlText = new StringBuilder();
                        sbHtml_HtmlText.AppendFormat("<div id=\"{1}_divHtmlText{0}\" class=\"topContent4\" >",
                            objvtz_ContentAttachmentEN.OrderNum,
                            strParantName);
                        sbHtml_HtmlText.Append(objvtz_ContentAttachmentEN.TextContent);
                        sbHtml_HtmlText.Append("</div>");

                        strExtResourceString += sbHtml_HtmlText.ToString();

                        break;
                    case "0012"://	0012	压缩文件
                         StringBuilder sbHtml_CompressionFile = new StringBuilder();
                        sbHtml_CompressionFile.AppendFormat("<div id=\"{1}_divCompressionFile{0}\" class=\"topContent4\" >",
                            objvtz_ContentAttachmentEN.OrderNum,
                            strParantName);

                        sbHtml_CompressionFile.AppendFormat("<a href=\"{0}\" style=\"cursor: pointer\">",
                            clsSysParaEN.spVirtualPath + "/" + objvtz_ContentAttachmentEN.FilePath);
                        sbHtml_CompressionFile.AppendFormat("[{1}]下载：{0}", 
                            objvtz_ContentAttachmentEN.FileName,
                            objvtz_ContentAttachmentEN.ResourceTypeName);
                        sbHtml_CompressionFile.Append("</a>");
                        //sbHtml_CompressionFile.Append(objvtz_ContentAttachmentEN.TextContent);
                        sbHtml_CompressionFile.Append("</div>");

                        strExtResourceString += sbHtml_CompressionFile.ToString();

                        break;
                    case "0013"://	0013	pdf文件		.pdf

                        sbHtml_Other.AppendFormat("<div id=\"{1}_divPDF{0}\" class=\"topContent4\" >",
                            objvtz_ContentAttachmentEN.OrderNum,
                            strParantName);

                        sbHtml_Other.AppendFormat("<a href=\"{0}\" style=\"cursor: pointer\">",
                            clsSysParaEN.spVirtualPath + "/" + objvtz_ContentAttachmentEN.FilePath);
                        sbHtml_Other.AppendFormat("[{1}]下载：{0}",
                            objvtz_ContentAttachmentEN.FileName,
                            objvtz_ContentAttachmentEN.ResourceTypeName);
                        sbHtml_Other.Append("</a>");
                        sbHtml_Other.Append("</div>");
                        strExtResourceString += sbHtml_Other.ToString();
                        break;
                    case "0014"://	0014	Excel文件		.xls

                        sbHtml_Other.AppendFormat("<div id=\"{1}_divExcel{0}\" class=\"topContent4\" >",
                            objvtz_ContentAttachmentEN.OrderNum,
                            strParantName);

                        sbHtml_Other.AppendFormat("<a href=\"{0}\" style=\"cursor: pointer\">",
                            clsSysParaEN.spVirtualPath + "/" + objvtz_ContentAttachmentEN.FilePath);
                        sbHtml_Other.AppendFormat("[{1}]下载：{0}",
                            objvtz_ContentAttachmentEN.FileName,
                            objvtz_ContentAttachmentEN.ResourceTypeName);
                        sbHtml_Other.Append("</a>");
                        sbHtml_Other.Append("</div>");
                        strExtResourceString += sbHtml_Other.ToString();
                        break;
                    default:
                        strMsg = string.Format("资源类型:{0}没有在相关函数中没有处理.({1})",
                            objvtz_ContentAttachmentEN.IdResourceType,
                            clsStackTrace.GetCurrClassFunction());
                        objErrorLog.WriteDebugLog(strMsg);

                        //string strReturnValue = string.Format(" <img id=\"imgTemp4Tz\" src=\"../../img/19999.gif\" alt=\"{0}\" style=\"height:69px;width:146px;border-width:0px;\" />"
                        //                , "~/" + objvtz_ContentAttachmentEN.FilePath);
                        //return strReturnValue;
                        throw new Exception(strMsg);
                }
            }
            return strExtResourceString;
        }
        ///// <summary>
        ///// 上传并保存附件文件。
        ///// 作者：潘以锋
        ///// 日期：20160403
        ///// </summary>
        ///// <param name="files">多个需要上传的文件</param>
        ///// <param name="strUploadFilePhysicalDir">上传文件的物理目录</param>
        ///// <param name="strWebPath">上传文件的Web目录</param>
        ///// <param name="strTableNameKey">表关键字</param>
        ///// <param name="strContentTypeId">内容类型Id</param>
        ///// <param name="strTitle">附件主题</param>
        ///// <param name="strUserId">操作用户</param>
        ///// <returns></returns>
        //public static clstz_ContentAttachmentEN UploadAndSaveFile(System.Web.HttpFileCollection files,
        //    string strUploadFilePhysicalDir, string strWebPath, string strTableNameKey, 
        //    string strContentTypeId, string strTitle, int intRecCount, string strUserId)
        //{
        //    arrtz_ContentAttachmentObjLst4OneTableName_Cache = null;
        //    clstz_ContentAttachmentEN objtz_ContentAttachmentEN = new clstz_ContentAttachmentEN();
        //    //System.Web.HttpFileCollection files = System.Web.HttpContext.Current.Request.Files;
        //    int ifile;
        //    for (ifile = 0; ifile < files.Count; ifile++)
        //    {
        //        if (files[ifile].FileName.Length > 0)
        //        {
        //            System.Web.HttpPostedFile postedfile = files[ifile];

        //            //if (postedfile.ContentLength / 1024 > 1024)//单个文件不能大于1024k
        //            //{
        //            //   // strResult = Path.GetFileName(postedfile.FileName) + "---不能大于1024k<br>";
        //            //    return false;
        //            //}
        //            string fex = Path.GetExtension(postedfile.FileName).ToLower();

        //        }
        //    }
        //    if (System.IO.Directory.Exists(strUploadFilePhysicalDir) == false)
        //    {
        //        Directory.CreateDirectory(strUploadFilePhysicalDir);

        //    }
        //    string strCurrDate = clsDateTime.getTodayDateTimeStr(0); 
        //    Random myRandom = new Random();
        //    //int num = 0;
        //    for (int i = 0; i < files.Count; i++)
        //    {
        //        string strFileSizeUnit = "字节";
        //        double intFileSize = 0;
        //        System.Web.HttpPostedFile myFile = files[i];
        //        string strFileName = "";
 
        //        string FileExtention = "";
        //        string strFullUploadFileName = "";//带目录的上传文件名。
        //        strFileName = System.IO.Path.GetFileName(myFile.FileName);
              
        //        //                    myImage.Width
        //        //myImage.Height

        //        string strRandom = myRandom.Next(100, 100000000).ToString();//产生一个随机数用于新命名的图片
        //        if (strFileName.Length > 0)//有文件才执行上传操作再保存到数据库
        //        {
        //            try
        //            {
        //                intFileSize = myFile.ContentLength;

        //                if (intFileSize > 1024)
        //                {
        //                    intFileSize = intFileSize / 1024;
        //                    strFileSizeUnit = "KB";
        //                    if (intFileSize > 1024)
        //                    {
        //                        intFileSize = intFileSize / 1024;
        //                        strFileSizeUnit = "MB";
        //                        if (intFileSize > 1024)
        //                        {
        //                            intFileSize = intFileSize / 1024;
        //                            strFileSizeUnit = "GB";
        //                        }
        //                    }

        //                }
        //                //strPath = "UpLoadFiles\\WorkFile\\";
        //                //string strCurrDate = clsDateTime.getTodayDateTimeStr(0);
        //                //strRandom = myRandom.Next(100, 100000000).ToString();//产生一个随机数用于新命名的图片
        //                strRandom = strCurrDate.Substring(2, 10);//产生一个随机数用于新命名的图片
        //                FileExtention = System.IO.Path.GetExtension(myFile.FileName);
        //                clsResourceTypeEN objResourceType = null;
        //                List<clsResourceTypeEN>  arrResourceTypeObjLstP = clsResourceTypeBLEx.GetResourceTypeObjLstByFileExtent(FileExtention);
        //                if (arrResourceTypeObjLstP.Count == 0)
        //                {
        //                    string strMsg = string.Format("扩展名：[{0}]不能分析出相应的资源类型，请检查文件扩展名是否正确，或者联系管理员！", FileExtention);
        //                    throw new Exception(strMsg);
        //                }
        //                objResourceType = arrResourceTypeObjLstP[0];
        //                strFullUploadFileName = strUploadFilePhysicalDir + strFileName;
        //                if (File.Exists(strFullUploadFileName) == true)
        //                {
        //                    int index = strFileName.LastIndexOf(".");
        //                    string vstype = strFileName.Substring(index).ToLower();//取文件的扩展名
        //                    int length = vstype.Length ;
        //                    string strFileName_Sim = strFileName.Substring(0, strFileName.Length - length);
        //                    strFileName = strFileName_Sim + "_" + strRandom + FileExtention;
        //                    strFullUploadFileName = strUploadFilePhysicalDir + strFileName;
        //                }
        //                myFile.SaveAs(strFullUploadFileName);
        //                objtz_ContentAttachmentEN.FileName = strFileName;
        //                objtz_ContentAttachmentEN.Extension = FileExtention;
        //                objtz_ContentAttachmentEN.FileSize = intFileSize;
        //                objtz_ContentAttachmentEN.FileSizeUnit = strFileSizeUnit;
        //                objtz_ContentAttachmentEN.FilePath = strWebPath + strFileName;
        //                objtz_ContentAttachmentEN.UploadDate = strCurrDate;
        //                objtz_ContentAttachmentEN.UploadPerson = strUserId;
        //                objtz_ContentAttachmentEN.ContentTypeId = strContentTypeId;
                     
        //                objtz_ContentAttachmentEN.AttachmentTitle = strTitle;

        //                objtz_ContentAttachmentEN.IdResourceType = objResourceType.IdResourceType;
        //                if (objResourceType.ResourceTypeName == "图片")
        //                {
        //                    System.Drawing.Image myImage = System.Drawing.Image.FromFile(strFullUploadFileName);

        //                    objtz_ContentAttachmentEN.ImageHeight = myImage.Height;
        //                    objtz_ContentAttachmentEN.ImageWidth = myImage.Width;
        //                }
        //                objtz_ContentAttachmentEN.TableNameKey = strTableNameKey;
        //                if (intRecCount == 0)
        //                {
        //                    intRecCount = GetRecCountByTableNameAndKey(strContentTypeId, strTableNameKey) ;
        //                    intRecCount++;
        //                }
        //                else
        //                {
        //                    intRecCount++;
        //                }
        //                objtz_ContentAttachmentEN.OrderNum = intRecCount;
                   
        //                objtz_ContentAttachmentEN.UpdDate = strCurrDate;
        //                objtz_ContentAttachmentEN.UpdUserId = strUserId;
        //                objtz_ContentAttachmentEN.Memo = strFileName;
        //                clstz_ContentAttachmentBLEx.arrtz_ContentAttachmentObjLst4OneTableName_Cache = null;
        //           string strReturn = clstz_ContentAttachmentBL.AddNewRecordBySql2WithReturnKey(objtz_ContentAttachmentEN);
        //                objtz_ContentAttachmentEN.mId = long.Parse(strReturn);
        //                return objtz_ContentAttachmentEN;
        //            }
        //            catch (Exception objException)
        //            {
        //                string strMsg = string.Format("(errid:BlEx000038)保存附件失败!(clstz_ContentAttachmentBLEx:UploadAndSaveFile)\r\n错误信息：{0}",
        //                     objException.Message);
        //                //clsPubVar4BLEx_Local.objErrorLog.WriteDebugLog(strMsg);
        //                throw new Exception(strMsg);
                      
        //                //return false;
        //            }
        //        }
        //    }
        //    return null;
        //}

        public static string GetFileSizeUnit(int intFileSize)
        {
            return "";
        }

        public static List<clstz_ContentAttachmentEN> GetDataRowByTableNameAndKey(string strContentTypeId, 
           
            string strTableNameKey)
        {
            if (arrtz_ContentAttachmentObjLst4OneTableName_Cache == null || strContentTypeId != strLastContentTypeId)
            {
                string strCondition = string.Format(" {0}='{1}' And {2}='{3}'",
                                          contz_ContentAttachment.ContentTypeId, strContentTypeId,
                                 
                                          contz_ContentAttachment.TableNameKey, strTableNameKey);
                arrtz_ContentAttachmentObjLst4OneTableName_Cache = clstz_ContentAttachmentBL.GetObjLst(strCondition);
                strLastContentTypeId = strContentTypeId;
            }
            string strCondition2 = string.Format(" {0}='{1}'",
                                      contz_ContentAttachment.TableNameKey, strTableNameKey);

            IEnumerable<clstz_ContentAttachmentEN> arrtz_ContentAttachmentObjLst_Sel1 =
               from objtz_ContentAttachmentEN in arrtz_ContentAttachmentObjLst4OneTableName_Cache
               where objtz_ContentAttachmentEN.TableNameKey == strTableNameKey
               select objtz_ContentAttachmentEN;


            List<clstz_ContentAttachmentEN> arrtz_ContentAttachmentObjLst_Sel = new List<clstz_ContentAttachmentEN>();
            foreach (clstz_ContentAttachmentEN obj in arrtz_ContentAttachmentObjLst_Sel1)
            {
                arrtz_ContentAttachmentObjLst_Sel.Add(obj);
            }
            return arrtz_ContentAttachmentObjLst_Sel;
                      
        }

        public static int GetRecCountByTableNameAndKey(string strContentTypeId,
                  string strTableNameKey)
        {
                string strCondition = string.Format(" {0}='{1}' And {2}='{3}' ",
                                          contz_ContentAttachment.ContentTypeId, strContentTypeId,                                        
                                          contz_ContentAttachment.TableNameKey, strTableNameKey);
            int intRecCount = clstz_ContentAttachmentBL.GetRecCountByCond(strCondition);
            return intRecCount;

        }
        /// <summary>
        /// 获取内容附件的物理文件名
        /// </summary>
        /// <param name="objtz_ContentAttachmentEN"></param>
        /// <returns></returns>
        public static string GetPhysicalFileName(clstz_ContentAttachmentEN objtz_ContentAttachmentEN)
        {
            string strWebFilePath = clsSysParaEN.spVirtualRoot + "/" + objtz_ContentAttachmentEN.FilePath;
            string strFileName = System.Web.HttpContext.Current.Server.MapPath(strWebFilePath);
            return strFileName;
        }

        /// <summary>
        /// 获取内容附件的Web文件名
        /// </summary>
        /// <param name="objtz_ContentAttachmentEN"></param>
        /// <returns></returns>
        public static string GetWebFileName(clstz_ContentAttachmentEN objtz_ContentAttachmentEN)
        {
            string strWebFilePath = clsSysParaEN.spVirtualRoot + "/" + objtz_ContentAttachmentEN.FilePath;
            return strWebFilePath;
        }

        /// <summary>
        /// 获取物理文件名中除了根目录的文件名
        /// </summary>
        /// <param name="myPage"></param>
        /// <param name="strPhysicalFileName"></param>
        /// <returns></returns>
        public static string GetWebFileNameExceptVirtualRoot(Page myPage, string strPhysicalFileName)
        {
            string strVirtualRoot_Physical = myPage.MapPath(clsSysParaEN.spVirtualRoot);

            string strPhysicalFilePath_Sim = strPhysicalFileName.Replace(strVirtualRoot_Physical, "");
            strVirtualRoot_Physical = strVirtualRoot_Physical.Replace(@"\", "/");
            strVirtualRoot_Physical = strVirtualRoot_Physical.Replace(@"//", "/");
            strPhysicalFilePath_Sim = strPhysicalFilePath_Sim.Replace(strVirtualRoot_Physical, "");
            return strPhysicalFilePath_Sim;
        }

    }
}
