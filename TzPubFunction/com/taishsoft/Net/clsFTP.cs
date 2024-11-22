using System;
using System.IO;
using System.Net;
using System.Text;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Web;
using com.taishsoft.common;
//using System.Web.UI;
//using com.taishsoft.commdb;

namespace com.taishsoft.net
{
    /// <summary>
    /// 专门处理FTP的类
    /// </summary>
    public class clsFTP
    {
        //从ftp上下载文件
        private void Download(string filePath, string ImageSrc, string ImageName, string ftpServerIP, string ftpUserName, string ftpPwd)
        {
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }
            using (FileStream OutputStream = new FileStream(filePath + "\\" + ImageName, FileMode.Create))
            {
                FtpWebRequest ReqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + ftpServerIP + "/" + ImageSrc));
                ReqFTP.Method = WebRequestMethods.Ftp.DownloadFile;
                ReqFTP.UseBinary = true;
                ReqFTP.Credentials = new NetworkCredential(ftpUserName, ftpPwd);
                using (FtpWebResponse response = (FtpWebResponse)ReqFTP.GetResponse())
                {
                    using (Stream FtpStream = response.GetResponseStream())
                    {
                        long Cl = response.ContentLength;
                        int bufferSize = 2048;
                        int readCount;
                        byte[] buffer = new byte[bufferSize];
                        readCount = FtpStream.Read(buffer, 0, bufferSize);
                        while (readCount > 0)
                        {
                            OutputStream.Write(buffer, 0, readCount);
                            readCount = FtpStream.Read(buffer, 0, bufferSize);
                        }
                        FtpStream.Close();
                    }
                    response.Close();
                }
                OutputStream.Close();
            }
        }


        //从服务器上传文件到FTP上
        private void UploadSmall(string sFileDstPath, string FolderName, string ftpServerIP, string ftpUserName, string ftpPwd)
        {
            FileInfo fileInf = new FileInfo(sFileDstPath);
            FtpWebRequest reqFTP;
            reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + ftpServerIP + "/" + FolderName + "/" + fileInf.Name));
            reqFTP.Credentials = new NetworkCredential(ftpUserName, ftpPwd);
            reqFTP.KeepAlive = false;
            reqFTP.Method = WebRequestMethods.Ftp.UploadFile;
            reqFTP.UseBinary = true;
            reqFTP.ContentLength = fileInf.Length;
            int buffLength = 2048;
            byte[] buff = new byte[buffLength];
            int contentLen;
            using (FileStream fs = fileInf.OpenRead())
            {
                using (Stream strm = reqFTP.GetRequestStream())
                {
                    contentLen = fs.Read(buff, 0, buffLength);
                    while (contentLen != 0)
                    {
                        strm.Write(buff, 0, contentLen);
                        contentLen = fs.Read(buff, 0, buffLength);
                    }
                    strm.Close();
                }
                fs.Close();
            }
        }
        //删除服务器上的文件
        private void DeleteWebServerFile(string sFilePath)
        {
            if (File.Exists(sFilePath))
            {
                File.Delete(sFilePath);
            }
        }
        //删除FTP上的文件
        private void DeleteFtpFile(string[] IName, string FolderName, string ftpServerIP, string ftpUserName, string ftpPwd)
        {
            foreach (string ImageName in IName)
            {
                string[] FileList = GetFileList(FolderName, ftpServerIP, ftpUserName, ftpPwd);
                for (int i = 0; i < FileList.Length; i++)
                {
                    string Name = FileList[i].ToString();
                    if (Name == ImageName)
                    {
                        FtpWebRequest ReqFTP;
                        ReqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + ftpServerIP + "/" + FolderName + "/" + ImageName));
                        ReqFTP.Credentials = new NetworkCredential(ftpUserName, ftpPwd);
                        ReqFTP.KeepAlive = false;
                        ReqFTP.Method = WebRequestMethods.Ftp.DeleteFile;
                        ReqFTP.UseBinary = true;
                        using (FtpWebResponse Response = (FtpWebResponse)ReqFTP.GetResponse())
                        {
                            long size = Response.ContentLength;
                            using (Stream datastream = Response.GetResponseStream())
                            {
                                using (StreamReader sr = new StreamReader(datastream))
                                {
                                    sr.ReadToEnd();
                                    sr.Close();
                                }
                                datastream.Close();
                            }
                            Response.Close();
                        }
                    }
                }
            }
        }
        

        /// <summary>
        /// 检查文件是否存在
        /// </summary>
        /// <param name="FolderName"></param>
        /// <param name="ftpServerIP"></param>
        /// <param name="ftpUserName"></param>
        /// <param name="ftpPwd"></param>
        /// <returns></returns>
        public string[] GetFileList(string FolderName, string ftpServerIP, string ftpUserName, string ftpPwd)
        {
            string[] downloadFiles;
            StringBuilder result = new StringBuilder();
            FtpWebRequest reqFTP;
            try
            {
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + ftpServerIP + "/" + FolderName + "/"));
                reqFTP.UseBinary = true;
                reqFTP.Credentials = new NetworkCredential(ftpUserName, ftpPwd);
                reqFTP.Method = WebRequestMethods.Ftp.ListDirectory;
                WebResponse response = reqFTP.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string line = reader.ReadLine();
                while (line != null)
                {
                    result.Append(line);
                    result.Append("\n");
                    line = reader.ReadLine();
                }
                // to remove the trailing '\n'        
                result.Remove(result.ToString().LastIndexOf('\n'), 1);
                reader.Close();
                response.Close();
                return result.ToString().Split('\n');
            }
            catch (Exception ex)
            {
                clsLog.LogErrorS(ex, "clsFTP");
                downloadFiles = null;
                return downloadFiles;
            }
        }
        //从客户端上传文件到FTP上
        private void UploadFtp(HttpPostedFile sFilePath, string filename, string FolderName, string ftpServerIP, string ftpUserName, string ftpPwd)
        {
            //获取的服务器路径
            //FileInfo fileInf = new FileInfo(sFilePath);
            FtpWebRequest reqFTP;
            reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + ftpServerIP + "/" + FolderName + "/" + filename));
            reqFTP.Credentials = new NetworkCredential(ftpUserName, ftpPwd);
            reqFTP.KeepAlive = false;
            reqFTP.Method = WebRequestMethods.Ftp.UploadFile;
            reqFTP.UseBinary = true;
            reqFTP.ContentLength = sFilePath.ContentLength;
            //设置缓存
            int buffLength = 2048;
            byte[] buff = new byte[buffLength];
            int contentLen;
            using (Stream fs = sFilePath.InputStream)
            {
                using (Stream strm = reqFTP.GetRequestStream())
                {
                    contentLen = fs.Read(buff, 0, buffLength);
                    while (contentLen != 0)
                    {
                        strm.Write(buff, 0, contentLen);
                        contentLen = fs.Read(buff, 0, buffLength);
                    }
                    strm.Close();
                }
                fs.Close();
            }
        }
        //创建目录
        private void CreateDirectory(string FolderName, string ftpServerIP, string ftpUserName, string ftpPwd)
        {
            //创建日期目录
            try
            {
                FtpWebRequest reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + ftpServerIP + "/" + FolderName));
                reqFTP.UseBinary = true;
                reqFTP.Credentials = new NetworkCredential(ftpUserName, ftpPwd);
                reqFTP.KeepAlive = false;
                reqFTP.Method = WebRequestMethods.Ftp.MakeDirectory;
                FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
            }
            catch
            {
                //            ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('系统忙，请稍后再试！');location.href=location.href;</script>");
                throw new Exception("系统忙，请稍后再试！");
            }
        }
        //检查日期目录和文件是否存在
        private static Regex regexName = new Regex(@"[^\s]*$", RegexOptions.Compiled);
        private bool CheckFileOrPath(string FolderName, string ftpServerIP, string ftpUserName, string ftpPwd)
        {
            //检查一下日期目录是否存在
            FtpWebRequest reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + ftpServerIP + "/"));
            reqFTP.UseBinary = true;
            reqFTP.Credentials = new NetworkCredential(ftpUserName, ftpPwd);
            reqFTP.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
            Stream stream = reqFTP.GetResponse().GetResponseStream();
            using (StreamReader sr = new StreamReader(stream))
            {
                string line = sr.ReadLine();
                while (!string.IsNullOrEmpty(line))
                {
                    GroupCollection gc = regexName.Match(line).Groups;
                    if (gc.Count != 1)
                    {
                        throw new ApplicationException("FTP 返回的字串格式不正确");
                    }
                    string path = gc[0].Value;
                    if (path == FolderName)
                    {
                        return true;
                    }
                    line = sr.ReadLine();
                }
            }
            return false;
        }
    }


}