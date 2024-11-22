using System;
using System.Text;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Web;

//using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.ftp;

namespace com.taishsoft.net
{
    /// <summary>
    /// 面向客户端的FTP类
    /// </summary>
    public class clsFTPClient
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public clsFTPClient()
        {

        }
        /// <summary>
        /// 下载函数
        /// </summary>
        /// <param name="destinationFile"></param>
        /// <param name="downloadUri"></param>
        /// <returns></returns>
        public FtpStatusCode DownloadBak(string destinationFile, Uri downloadUri)
        {
            try
            {
                // Check if the URI is and FTP site
                if (downloadUri.Scheme != Uri.UriSchemeFtp)
                {
                    throw new ArgumentException("URI is not an FTp site");
                }

                // Set up the request
                FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create(downloadUri);

                // use the provided credentials
                if (this._isAnonymousUser == false)
                {
                    ftpRequest.Credentials = new NetworkCredential(this._userName, this._password);
                }

                // Download a file. Look at the other methods to see all of the potential FTP features
                ftpRequest.Method = WebRequestMethods.Ftp.DownloadFile;

                // get the response object
                FtpWebResponse ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();


                Stream stream = null;


                BinaryReader reader = null;
                BinaryWriter writer = null;
                FileStream fs = null;
                byte[] bb;
                // get the file as a stream from the response object and write it as 
                // a file stream to the local PC
                try
                {
                    stream = ftpResponse.GetResponseStream();
                    //					reader = new StreamReader(stream, Encoding.UTF8);
                    reader = new BinaryReader(stream);

                    fs = new FileStream(destinationFile, FileMode.Create);

                    writer = new BinaryWriter(fs);

                    bb = reader.ReadBytes(1024);
                    while (bb.Length > 0)
                    {
                        writer.Write(bb);
                        if (reader.BaseStream.CanRead)
                        {
                            bb = reader.ReadBytes(1024);
                        }
                        else
                        {
                            break;
                        }
                    }
                    //writer.Write(reader.ReadBytes.ReadToEnd());
                    int ii = 4;
                    ii = ii * 5;
                    return ftpResponse.StatusCode;
                }
                finally
                {
                    // Allways close all streams
                    stream.Close();
                    reader.Close();
                    writer.Close();
                    fs.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Ftp下载函数
        /// </summary>
        /// <param name="strFilePath">本地的目录路径</param>
        /// <param name="destinationFile">本地的目标文件名, 不能带有目录名</param>
        /// <param name="ftpServerIP">FTP服务器地址</param>
        /// <param name="strFtpFileName">FTP服务器上的文件名</param>
        /// <returns>FTP下载状态</returns>
        public FtpStatusCode Download(string strFilePath, string destinationFile, string ftpServerIP, string strFtpFileName)
        {
            try
            {
                if (destinationFile.IndexOf("/") >= 0)
                {
                    string strMsg = string.Format("本地的目标文件名不能带目录名，其中包含\"/\",请检查！目标文件文件名：{0}", destinationFile);
                    throw new Exception(strMsg);
                }
                //// Check if the URI is and FTP site
                //if (downloadUri.Scheme != Uri.UriSchemeFtp)
                //{
                //    throw new ArgumentException("URI is not an FTp site");
                //}

                // Set up the request
                string strRequestUrl = "";
                if (ftpServerIP.Substring(ftpServerIP.Length - 1, 1) == "/")
                {
                    strRequestUrl = "ftp://" + ftpServerIP + strFtpFileName;
                }
                else
                {
                    strRequestUrl = "ftp://" + ftpServerIP + "/" + strFtpFileName;
                }
                strRequestUrl = strRequestUrl.Replace("ftp://ftp://", "ftp://");
                FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create(new Uri(strRequestUrl));

                // use the provided credentials
                if (this._isAnonymousUser == false)
                {
                    ftpRequest.Credentials = new NetworkCredential(this._userName, this._password);
                }

                // Download a file. Look at the other methods to see all of the potential FTP features
                ftpRequest.Method = WebRequestMethods.Ftp.DownloadFile;

                // get the response object
                FtpWebResponse ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();


                Stream stream = null;


                BinaryReader reader = null;
                BinaryWriter writer = null;
                FileStream fs = null;
                byte[] bb;
                // get the file as a stream from the response object and write it as 
                // a file stream to the local PC
                try
                {
                    stream = ftpResponse.GetResponseStream();
                    //					reader = new StreamReader(stream, Encoding.UTF8);
                    reader = new BinaryReader(stream);
                    if (Directory.Exists(strFilePath) == false)
                    {
                        Directory.CreateDirectory(strFilePath);
                    }
                    fs = new FileStream(strFilePath + "\\" + destinationFile, FileMode.Create);

                    writer = new BinaryWriter(fs);

                    bb = reader.ReadBytes(1024);
                    while (bb.Length > 0)
                    {
                        writer.Write(bb);
                        if (reader.BaseStream.CanRead)
                        {
                            bb = reader.ReadBytes(1024);
                        }
                        else
                        {
                            break;
                        }
                    }
                    //writer.Write(reader.ReadBytes.ReadToEnd());
                    int ii = 4;
                    ii = ii * 5;
                    return ftpResponse.StatusCode;
                }
                finally
                {
                    // Allways close all streams
                    stream.Close();
                    reader.Close();
                    writer.Close();
                    fs.Close();
                }
            }
            catch (Exception ex)
            {
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.AppendFormat("出错:{0}.", ex.Message);
                sbMsg.AppendFormat("本地的目录路径:[{0}];", strFilePath);
                sbMsg.AppendFormat("本地的目标文件名:[{0}];", destinationFile);
                sbMsg.AppendFormat("FTP服务器地址:[{0}];", ftpServerIP);
                sbMsg.AppendFormat("FTP服务器上的文件名:[{0}];", strFtpFileName);
                throw new Exception(sbMsg.ToString());
            }
        }

        /// <summary>
        /// 下载整个子目录，包括下属子目录和文件
        /// </summary>
        /// <param name="strFilePath">本地的目录路径</param>
        /// <param name="ftpServerIP">FTP服务器地址</param>
        /// <param name="strFtpFilePath">FTP服务器上的目录路径</param>
        /// <returns>下载状态</returns>
        public bool DownloadDir(string strFilePath, string ftpServerIP, string strFtpFilePath)
        {
            try
            {
                if (CheckFileOrPath("/", strFtpFilePath, ftpServerIP) == false)
                {
                    return true;
                }
                string strSimplePath = clsString.GetSimplePath(strFtpFilePath);
                string strNewFilePath = strFilePath + "/" + strSimplePath;
                if (Directory.Exists(strNewFilePath) == false)
                {
                    Directory.CreateDirectory(strNewFilePath);
                }

                FTPclient objFTP2 = new FTPclient();
                objFTP2.Hostname = "ftp://" + ftpServerIP;
                objFTP2.Username = _userName;
                objFTP2.Password = _password;

                FTPdirectory objFTPDir = objFTP2.ListDirectoryDetail(strFtpFilePath);
                for (int i = 0; i < objFTPDir.Count; i++)
                {
                    if (objFTPDir[i].FileType == FTPfileInfo.DirectoryEntryTypes.Directory)
                    {
                        string strSubFtpFilePath = objFTPDir[i].FullName;
                        DownloadDir(strNewFilePath, ftpServerIP, strSubFtpFilePath);
                    }
                    else
                    {
                        string strSimFileName = clsString.GetSimpleFName_S(objFTPDir[i].FullName);
                        Download(strNewFilePath, strSimFileName, ftpServerIP, objFTPDir[i].FullName);
                    }
                }
            }
            catch (Exception objException)
            {
                throw new Exception(
                    "下载整个文件夹到本地有问题。FTP文件夹名为：" + strFtpFilePath + ". "
                    + "\r\n" + "发生于函数：DownloadDir in 类clsFTPClient中。"
                    + "\r\n" + objException.Message
                    );
            }
            return true;
        }


        /// <summary>
        /// 下载函数，静态函数
        /// </summary>
        /// <param name="strFilePath">本地的目录路径</param>
        /// <param name="strFtpFileName">FTP服务器上的文件名</param>
        /// <param name="destinationFile">本地的目标文件名</param>
        /// <param name="ftpServerIP">FTP服务器地址</param>
        /// <param name="ftpUserName">FTP 用户名</param>
        /// <param name="ftpPwd">FTP 口令</param>
        public static void Download(string strFilePath, string strFtpFileName, string destinationFile, string ftpServerIP, string ftpUserName, string ftpPwd)
        {
            if (!Directory.Exists(strFilePath))
            {
                Directory.CreateDirectory(strFilePath);
            }
            using (FileStream OutputStream = new FileStream(strFilePath + "\\" + destinationFile, FileMode.Create))
            {
                FtpWebRequest ReqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + ftpServerIP + "/" + strFtpFileName));
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

        //从ftp上下载文件

        /// <summary>
        /// 下载函数，
        /// </summary>
        /// <param name="strFilePath">本地的目录路径</param>
        /// <param name="strFtpFileName">FTP服务器上的文件名</param>
        /// <param name="destinationFile">本地的目标文件名</param>
        /// <param name="ftpServerIP">FTP服务器地址</param>
        public void Download2(string strFilePath, string strFtpFileName, string destinationFile, string ftpServerIP)
        {
            if (!Directory.Exists(strFilePath))
            {
                Directory.CreateDirectory(strFilePath);
            }
            using (FileStream OutputStream = new FileStream(strFilePath + "\\" + destinationFile, FileMode.Create))
            {
                FtpWebRequest ReqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + ftpServerIP + "/" + strFtpFileName));
                ReqFTP.Method = WebRequestMethods.Ftp.DownloadFile;
                ReqFTP.UseBinary = true;
                ReqFTP.Credentials = new NetworkCredential(_userName, _password);
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

        /// <summary>
        /// 上传文件，同名传到FTP上
        /// </summary>
        /// <param name="strSouFullFileName">本地的源文件名，带完全目录</param>
        /// <param name="strFtpFolderName">FTP服务器上目录路径</param>
        /// <param name="ftpServerIP">FTP服务器地址</param>
        /// <returns>FTP状态</returns>
        public FtpStatusCode UploadFile(string strSouFullFileName, string strFtpFolderName, string ftpServerIP)
        {
            FileInfo fileInf = new FileInfo(strSouFullFileName);
            FtpWebRequest ftpRequest;
            string strUri =   ftpServerIP + "/" + strFtpFolderName + "/" + fileInf.Name;
            strUri = strUri.Replace("//", "/");
            strUri = strUri.Replace("//", "/");
          string strRequestUrlString = "ftp://" + strUri;
          strRequestUrlString = strRequestUrlString.Replace("ftp://ftp://", "ftp://");
          strRequestUrlString = strRequestUrlString.Replace("ftp://ftp:/", "ftp://");

            ftpRequest = (FtpWebRequest)FtpWebRequest.Create((new Uri(strRequestUrlString)));

            ICredentials credential = new NetworkCredential(this._userName, this._password);
            ftpRequest.Credentials = credential;
            FileStream stream = null;
            Stream FtpStream = null;
            //设置请求(request)的方法
            ftpRequest.Method = WebRequestMethods.Ftp.UploadFile;


            //打开文件流
            stream = new FileStream(strSouFullFileName, FileMode.Open);

            //需要以二进制的方式进行读文件内容.
            BinaryReader binReader_SouFile = new BinaryReader(stream);

            //fs = new FileStream(destinationFile, FileMode.Create);
            //获取<请求>流(Stream)
            ftpRequest.Timeout = 2400000;
            try
            {
                FtpStream = ftpRequest.GetRequestStream();
            }
            catch (Exception objException)
            {
                stream.Close();
                throw objException;
            }
            try
            {
                //建立<请求>流(Stream)的二进制方式写.
                BinaryWriter ftpBinWriter = new BinaryWriter(FtpStream);

                byte[] bb;
                //从输入流中读1024个字节
                bb = binReader_SouFile.ReadBytes(1024);
                //stream.Write(bb, 0, bb.Length);
                while (bb.Length > 0)
                {
                    //请求流的内容长度=读取字节的长度
                    ftpRequest.ContentLength = bb.Length;

                    //stream.Write(bb, intPosition, bb.Length);
                    //读取二进制流写到<请求>流中
                    ftpBinWriter.Write(bb);
                    if (binReader_SouFile.BaseStream.CanRead)
                    {
                        bb = binReader_SouFile.ReadBytes(1024);
                    }
                    else
                    {
                        break;
                    }
                }
                //byte[] fileContents = Encoding.Default.GetBytes(reader.ReadToEnd());
                ftpBinWriter.Close();
                binReader_SouFile.Close();
                FtpStream.Close();
                stream.Close();
                //获取ftp反应(ftpResponse)
                FtpWebResponse ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                //MessageBox.Show("File Upload Completed, status " + response.StatusDescription);
                ftpResponse.Close();
                return ftpResponse.StatusCode;

            }
            catch (Exception objException)
            {
                stream.Close();
                FtpStream.Close();
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.AppendFormat("出错:{0}.", objException.Message);

                sbMsg.AppendFormat("本地的源文件名，带完全目录:[{0}];", strSouFullFileName);
                sbMsg.AppendFormat("FTP服务器上目录路径:[{0}];", strFtpFolderName);
                sbMsg.AppendFormat("FTP服务器地址:[{0}];", ftpServerIP);
         

                sbMsg.AppendFormat("发生于函数：UpLoadDir in 类clsFTPClient中。;");

                throw new Exception(sbMsg.ToString());
            }
        }


        /// <summary>
        /// 上传文件，同名传到FTP上
        /// </summary>
        /// <param name="strSouFullFileName">本地的源文件名，带完全目录</param>
        /// <param name="strFtpFolderName">FTP服务器上目录路径</param>
        /// <param name="newFilename">FTP上新文件名</param>
        /// <param name="ftpServerIP">FTP服务器地址</param>
        /// <returns>FTP状态</returns>
        public FtpStatusCode Rename(string strSouFullFileName, string strFtpFolderName, string newFilename, string ftpServerIP)
        {



            try
            {
                FileInfo fileInf = new FileInfo(strSouFullFileName);
                FtpWebRequest ftpRequest;
                ftpRequest = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + ftpServerIP + "/" + strFtpFolderName + "/" + fileInf.Name));

                ICredentials credential = new NetworkCredential(this._userName, this._password);
                ftpRequest.Credentials = credential;

                //设置请求(request)的方法
                ftpRequest.Method = WebRequestMethods.Ftp.Rename;
                ftpRequest.RenameTo = newFilename;


                FtpWebResponse ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();

                //Stream ftpStream = response.GetResponseStream();

                //ftpStream.Close();

                ftpResponse.Close();

                return ftpResponse.StatusCode;

            }
            catch (Exception objException)
            {

                throw new Exception(objException.Message);
            }
        }

        /// <summary>
        /// 上传文件，在服务器上可以改名
        /// </summary>
        /// <param name="strSouFullFileName">本地的源文件名，带完全目录</param>
        /// <param name="strFtpFolderName">FTP服务器上目录路径</param>
        /// <param name="strFtpFileName">FTP服务器上目标文件名</param>
        /// <param name="ftpServerIP">FTP服务器地址</param>
        /// <returns>FTP状态</returns>
        public FtpStatusCode UploadFile(string strSouFullFileName, string strFtpFolderName, string strFtpFileName, string ftpServerIP)
        {
            FtpWebRequest ftpRequest;
            ftpRequest = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + ftpServerIP + "/" + strFtpFolderName + "/" + strFtpFileName));

            ICredentials credential = new NetworkCredential(this._userName, this._password);
            ftpRequest.Credentials = credential;
            FileStream stream = null;
            Stream FtpStream = null;
            //设置请求(request)的方法
            ftpRequest.Method = WebRequestMethods.Ftp.UploadFile;

            try
            {
                //打开文件流
                stream = new FileStream(strSouFullFileName, FileMode.Open);

                //需要以二进制的方式进行读文件内容.
                BinaryReader binReader_SouFile = new BinaryReader(stream);

                //fs = new FileStream(destinationFile, FileMode.Create);
                //获取<请求>流(Stream)
                FtpStream = ftpRequest.GetRequestStream();
                //建立<请求>流(Stream)的二进制方式写.
                BinaryWriter ftpBinWriter = new BinaryWriter(FtpStream);

                byte[] bb;
                //从输入流中读1024个字节
                bb = binReader_SouFile.ReadBytes(1024);
                //stream.Write(bb, 0, bb.Length);
                while (bb.Length > 0)
                {
                    //请求流的内容长度=读取字节的长度
                    ftpRequest.ContentLength = bb.Length;

                    //stream.Write(bb, intPosition, bb.Length);
                    //读取二进制流写到<请求>流中
                    ftpBinWriter.Write(bb);
                    if (binReader_SouFile.BaseStream.CanRead)
                    {
                        bb = binReader_SouFile.ReadBytes(1024);
                    }
                    else
                    {
                        break;
                    }
                }
                //byte[] fileContents = Encoding.Default.GetBytes(reader.ReadToEnd());
                ftpBinWriter.Close();
                binReader_SouFile.Close();
                FtpStream.Close();
                stream.Close();
                //获取ftp反应(ftpResponse)
                FtpWebResponse ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                //MessageBox.Show("File Upload Completed, status " + response.StatusDescription);
                ftpResponse.Close();
                return ftpResponse.StatusCode;

            }
            catch (Exception objException)
            {
                stream.Close();
                FtpStream.Close();
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.AppendFormat("出错:{0}.", objException.Message);
            
                sbMsg.AppendFormat("本地的源文件名，带完全目录:[{0}];", strSouFullFileName);
                sbMsg.AppendFormat("FTP服务器上目录路径:[{0}];", strFtpFolderName);
                sbMsg.AppendFormat("FTP服务器上目标文件名:[{0}];", strFtpFileName);
                sbMsg.AppendFormat("FTP服务器地址:[{0}];", ftpServerIP);
             
                throw new Exception(sbMsg.ToString());
            }
        }

        /// <summary>
        /// 上传整个目录，静态函数
        /// </summary>
        /// <param name="strFilesDir">本地的源目录名</param>
        /// <param name="strFtpDir">FTP服务器上目标路径</param>
        /// <param name="ftpServerIP">FTP服务器地址</param>
        /// <param name="ftpUserName">FTP 用户名</param>
        /// <param name="ftpPwd">FTP 口令</param>
        /// <returns>上传是否成功？</returns>
        public static bool UpLoadDir(string strFilesDir, string strFtpDir, string ftpServerIP, string ftpUserName, string ftpPwd)
        {
            try
            {
                if (Directory.Exists(strFilesDir) == true)
                {
                    clsFTPClient.CreateDirectory(strFtpDir, ftpServerIP, ftpUserName, ftpPwd);
                    DirectoryInfo dirInfo = new DirectoryInfo(strFilesDir);
                    string[] strFiles = Directory.GetFiles(strFilesDir);
                    foreach (string strFile in strFiles)
                    {
                        clsFTPClient objFTP = new clsFTPClient();
                        objFTP.UserName = ftpUserName;
                        objFTP.Password = ftpPwd;
                        objFTP.UploadFile(strFile, strFtpDir, ftpServerIP);
                    }
                }
            }
            catch (Exception objException)
            {
          
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.AppendFormat("出错:{0}.", objException.Message);
            
                sbMsg.AppendFormat("本地的源目录名:[{0}];", strFilesDir);
                sbMsg.AppendFormat("FTP服务器上目标路径:[{0}];", strFtpDir);
                sbMsg.AppendFormat("FTP服务器地址:[{0}];", ftpServerIP);
                sbMsg.AppendFormat("FTP 用户名:[{0}];", ftpUserName);

                sbMsg.AppendFormat("发生于函数：UpLoadDir in 类clsFTPClient中。;");

                throw new Exception(sbMsg.ToString());
            }

            return true;
        }
        //上载整个子目录

        /// <summary>
        /// 上传整个目录
        /// </summary>
        /// <param name="strFilesDir">本地的源目录名</param>
        /// <param name="strFtpDir">FTP服务器上目标路径</param>
        /// <param name="ftpServerIP">FTP服务器地址</param>
        /// <returns>上传是否成功？</returns>
        public bool UpLoadDir(string strFilesDir, string strFtpDir, string ftpServerIP)
        {
            try
            {
                if (Directory.Exists(strFilesDir) == true)
                {
                    CreateDirectory(strFtpDir, ftpServerIP, _userName, _password);
                    DirectoryInfo dirInfo = new DirectoryInfo(strFilesDir);
                    string[] strFiles = Directory.GetFiles(strFilesDir);
                    foreach (string strFile in strFiles)
                    {
                        UploadFile(strFile, strFtpDir, ftpServerIP);
                    }
                    string[] strDirs = Directory.GetDirectories(strFilesDir);
                    foreach (string strDir in strDirs)
                    {
                        string strSimDir = clsString.GetSimplePath(strDir);
                        string strSubFtpDir = strFtpDir + "/" + strSimDir;
                        UpLoadDir(strDir, strSubFtpDir, ftpServerIP);
                    }
                }
            }
            catch (Exception objException)
            {
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.AppendFormat("出错:{0}.", objException.Message);
               
                
                sbMsg.AppendFormat("本地的源目录名:[{0}];", strFilesDir);
                sbMsg.AppendFormat("FTP服务器上目标路径:[{0}];", strFtpDir);
                sbMsg.AppendFormat("FTP服务器地址:[{0}];", ftpServerIP);
                sbMsg.AppendFormat("发生于函数：UpLoadDir in 类clsFTPClient中。;");
     
                throw new Exception(sbMsg.ToString());

            }

            return true;
        }


        /// <summary>
        /// 创建目录，静态函数
        /// </summary>
        /// <param name="FolderName">目录名</param>
        /// <param name="ftpServerIP">FTP服务器地址</param>
        /// <param name="ftpUserName">FTP 用户名</param>
        /// <param name="ftpPwd">FTP 口令</param>
        public static void CreateDirectory(string FolderName, string ftpServerIP, string ftpUserName, string ftpPwd)
        {
            //创建日期目录
            string strNewFolderName = "";
            try
            {
                strNewFolderName = "ftp://" + ftpServerIP + "/" + FolderName;
                if (CheckFileOrPath(FolderName, ftpServerIP, ftpUserName, ftpPwd) == true)
                {
                    return;
                }
                FtpWebRequest reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(strNewFolderName));
                reqFTP.UseBinary = true;
                reqFTP.Credentials = new NetworkCredential(ftpUserName, ftpPwd);
                reqFTP.KeepAlive = false;
                reqFTP.Method = WebRequestMethods.Ftp.MakeDirectory;
                FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
            }
            catch (Exception objException)
            {
                throw new Exception("系统忙，请稍后再试！" + strNewFolderName + "\r\n" + objException.Message);
            }
        }

        /// <summary>
        /// 创建目录
        /// </summary>
        /// <param name="FolderName">目录名</param>
        /// <param name="ftpServerIP">FTP服务器地址</param>
        public void MakeDirectory(string FolderName, string ftpServerIP)
        {
            //创建日期目录
            try
            {
                FtpWebRequest reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + ftpServerIP + "/" + FolderName));
                reqFTP.UseBinary = true;
                reqFTP.Credentials = new NetworkCredential(_userName, _password);
                reqFTP.KeepAlive = false;
                reqFTP.Method = WebRequestMethods.Ftp.MakeDirectory;
                FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
            }
            catch
            {
                throw new Exception("系统忙，请稍后再试！");
            }
        }

        //从服务器上传文件到FTP上
        /// <summary>
        /// 上传文件，另一种方式。该文件可能是小文件
        /// </summary>
        /// <param name="strSouFullFileName">本地的源文件名，带完全目录</param>
        /// <param name="strFtpFolderName">FTP服务器上目标路径</param>
        /// <param name="ftpServerIP">FTP服务器地址</param>
        /// <param name="ftpUserName">FTP 用户名</param>
        /// <param name="ftpPwd">FTP 口令</param>
        public static void UploadSmall(string strSouFullFileName, string strFtpFolderName, string ftpServerIP, string ftpUserName, string ftpPwd)
        {
            FileInfo fileInf = new FileInfo(strSouFullFileName);
            FtpWebRequest reqFTP;
            reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + ftpServerIP + "/" + strFtpFolderName + "/" + fileInf.Name));
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


        /// <summary>
        /// 获取FTP服务器目录列表，静态函数
        /// </summary>
        /// <param name="strFolderName">FTP服务器上路径</param>
        /// <param name="ftpServerIP">FTP服务器地址</param>
        /// <param name="ftpUserName">FTP 用户名</param>
        /// <param name="ftpPwd">FTP 口令</param>
        /// <returns>返回的目录列表，用字符串数组表示</returns>
        public static string[] GetFileList(string strFolderName, string ftpServerIP, string ftpUserName, string ftpPwd)
        {
            string[] downloadFiles;
            StringBuilder result = new StringBuilder();
            FtpWebRequest reqFTP;
            try
            {
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + ftpServerIP + "/" + strFolderName + "/"));
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


        /// <summary>
        /// 获取目录文件详细列表（包括文件和目录）
        /// </summary>
        /// <param name="strFolderName">FTP服务器上路径</param>
        /// <param name="ftpServerIP">FTP服务器地址</param>
        /// <returns>返回的目录列表，用字符串数组表示</returns>
        public string[] GetFileListDetails(string strFolderName, string ftpServerIP)
        {
            string[] downloadFiles;
            StringBuilder result = new StringBuilder();
            string strUri = "";
            FtpWebRequest reqFTP;
            try
            {
                strUri = "ftp://" + ftpServerIP + "/" + strFolderName;
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(strUri));
                reqFTP.UseBinary = true;
                reqFTP.Credentials = new NetworkCredential(_userName, _password);
                reqFTP.Method = WebRequestMethods.Ftp.ListDirectoryDetails;

                WebResponse response = reqFTP.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding("gb2312"));
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
            catch (Exception objException)
            {
                clsLog.LogErrorS(objException, "clsFTP");
                downloadFiles = null;
                return downloadFiles;
                //                throw new Exception(objException.Message + "\r\n" + "Uri=" + strUri + "\r\n" + "在函数GetFileList中");
            }

        }

        /// <summary>
        /// 获取FTP服务器目录列表
        /// </summary>
        /// <param name="strFolderName">FTP服务器上路径</param>
        /// <param name="ftpServerIP">FTP服务器地址</param>
        /// <returns>返回的目录列表，用字符串数组表示</returns>
        public string[] GetFileList(string strFolderName, string ftpServerIP)
        {
            string[] downloadFiles;
            StringBuilder result = new StringBuilder();
            string strUri = "";
            FtpWebRequest reqFTP;
            try
            {
                strUri = "ftp://" + ftpServerIP + "/" + strFolderName;
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(strUri));
                reqFTP.UseBinary = true;
                reqFTP.Credentials = new NetworkCredential(_userName, _password);
                reqFTP.Method = WebRequestMethods.Ftp.ListDirectory;

                WebResponse response = reqFTP.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding("gb2312"));
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
            catch (Exception objException)
            {
                clsLog.LogErrorS(objException, "clsFTP");
                downloadFiles = null;
                return downloadFiles;
                //                throw new Exception(objException.Message + "\r\n" + "Uri=" + strUri + "\r\n" + "在函数GetFileList中");
            }

        }

        //从客户端上传文件到FTP上

        /// <summary>
        /// 上传文件，同名传到FTP上
        /// </summary>
        /// <param name="sHttpPostedFile"></param>
        /// <param name="filename">FTP服务器上目标文件名</param>
        /// <param name="FolderName">FTP服务器上目标路径</param>
        /// <param name="ftpServerIP">FTP服务器地址</param>
        /// <param name="ftpUserName">用户名</param>
        /// <param name="ftpPwd">口令</param>        
        private void UploadFtp(HttpPostedFile sHttpPostedFile, string filename, string FolderName, string ftpServerIP, string ftpUserName, string ftpPwd)
        {
            //获取的服务器路径
            //FileInfo fileInf = new FileInfo(sFilePath);
            FtpWebRequest reqFTP;
            reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + ftpServerIP + "/" + FolderName + "/" + filename));
            reqFTP.Credentials = new NetworkCredential(ftpUserName, ftpPwd);
            reqFTP.KeepAlive = false;
            reqFTP.Method = WebRequestMethods.Ftp.UploadFile;
            reqFTP.UseBinary = true;
            reqFTP.ContentLength = sHttpPostedFile.ContentLength;
            //设置缓存
            int buffLength = 2048;
            byte[] buff = new byte[buffLength];
            int contentLen;
            using (Stream fs = sHttpPostedFile.InputStream)
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

        //检查日期目录和文件是否存在
        private static Regex regexName = new Regex(@"[^\s]*$", RegexOptions.Compiled);
        /// <summary>
        /// 检查目录或者文件名是否存在，静态函数
        /// </summary>
        /// <param name="strFolderName">文件名或者目录名</param>
        /// <param name="ftpServerIP">FTP服务器地址</param>
        /// <param name="ftpUserName">FTP 用户名</param>
        /// <param name="ftpPwd">FTP 口令</param>
        /// <returns>是否存在？</returns>
        public static bool CheckFileOrPath(string strFolderName, string ftpServerIP, string ftpUserName, string ftpPwd)
        {
            if (strFolderName == @"/")
            {
                return true;
            }
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
                    if (path == strFolderName)
                    {
                        return true;
                    }
                    line = sr.ReadLine();
                }
            }
            return false;
        }

        /// <summary>
        /// 检查目录或者文件名是否存在
        /// </summary>
        /// <param name="strParentPath">文件名或者目录名</param>
        /// <param name="strFolderName">文件名或者目录名</param>
        /// <param name="ftpServerIP">FTP服务器地址</param>
        /// <returns>是否存在？</returns>
        public bool CheckFileOrPath(string strParentPath, string strFolderName, string ftpServerIP)
        {
            string strUrl = "";
            if (strFolderName.StartsWith("/") == true)
            {
                strFolderName = strFolderName.Substring(1);
            }
            //提供的目录可能有多层，应该分多层分别判断
            int intIndex = strFolderName.LastIndexOf("/");
            if (intIndex > 0)
            {
                string strSubParentPath = strFolderName.Substring(0, intIndex);
                if (CheckFileOrPath(strParentPath, strSubParentPath, ftpServerIP) == false)
                {
                    return false;
                }
                string strSubPath = strFolderName.Substring(intIndex);
                //strUrl = "ftp://" + ftpServerIP + "/" + strParentPath + strSubParentPath;
                return CheckFileOrPath(strParentPath + strSubParentPath, strSubPath, ftpServerIP);
            }
            else
            {
                strUrl = "ftp://" + ftpServerIP + "/" + strParentPath;
            }
            strUrl = "ftp://" + ftpServerIP + "/" + strParentPath;
            //检查一下日期目录是否存在
            FtpWebRequest reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(strUrl));
            reqFTP.UseBinary = true;
            reqFTP.Credentials = new NetworkCredential(_userName, _password);
            reqFTP.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
            Stream stream = reqFTP.GetResponse().GetResponseStream();
            using (StreamReader sr = new StreamReader(stream, Encoding.GetEncoding("gb2312")))
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
                    if (path == strFolderName)
                    {
                        return true;
                    }
                    line = sr.ReadLine();
                }
            }
            return false;
        }



        /// <summary>
        /// 删除FTP上的多个文件，静态函数
        /// </summary>
        /// <param name="strFileNameLst">需要删除的文件名列表</param>
        /// <param name="FolderName">文件名或者目录名</param>
        /// <param name="ftpServerIP">FTP服务器地址</param>
        /// <param name="ftpUserName">FTP 用户名</param>
        /// <param name="ftpPwd">FTP 口令</param>
        public static void DeleteFtpFile(string[] strFileNameLst, string FolderName, string ftpServerIP, string ftpUserName, string ftpPwd)
        {
            foreach (string ImageName in strFileNameLst)
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
        /// 删除FTP上的多个文件
        /// </summary>
        /// <param name="strFileNameLst">需要删除的文件名列表</param>
        /// <param name="FolderName">文件名或者目录名</param>
        /// <param name="ftpServerIP">FTP服务器地址</param>
        public void DeleteFtpFile(string[] strFileNameLst, string FolderName, string ftpServerIP)
        {
            foreach (string ImageName in strFileNameLst)
            {
                string[] FileList = GetFileList(FolderName, ftpServerIP);
                for (int i = 0; i < FileList.Length; i++)
                {
                    string Name = FileList[i].ToString();
                    if (Name == ImageName)
                    {
                        FtpWebRequest ReqFTP;
                        ReqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + ftpServerIP + "/" + FolderName + "/" + ImageName));
                        ReqFTP.Credentials = new NetworkCredential(_userName, _password);
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
        /// 删除FTP上的单个文件
        /// </summary>
        /// <param name="strFileName">需要删除的文件名</param>
        /// <param name="strFolderName">文件名或者目录名</param>
        /// <param name="ftpServerIP">FTP服务器地址</param>
        public void DeleteFtpFile(string strFileName, string strFolderName, string ftpServerIP)
        {
            string[] FileList = GetFileList(strFolderName, ftpServerIP);
            if (FileList == null)
            {
                return;
            }
            for (int i = 0; i < FileList.Length; i++)
            {
                string Name = FileList[i].ToString();
                if (Name.ToLower() == strFileName.ToLower())
                {
                    FtpWebRequest ReqFTP;
                    ReqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + ftpServerIP + "/" + strFolderName + "/" + strFileName));
                    ReqFTP.Credentials = new NetworkCredential(_userName, _password);
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


        /// <summary>
        /// 删除FTP上的单个目录
        /// </summary>
        /// <param name="strFolderName">文件名或者目录名</param>
        /// <param name="ftpServerIP">FTP服务器地址</param>    
        public void DeleteFtpFolder(string strFolderName, string ftpServerIP)
        {
            string strUri = "";
            FtpWebRequest ReqFTP;
            try
            {
                string[] FileList = GetFileList(strFolderName, ftpServerIP);
                if (FileList != null)
                {
                    for (int i = 0; i < FileList.Length; i++)
                    {
                        string strFileName = FileList[i].ToString();
                        strUri = "ftp://" + ftpServerIP + "/" + strFolderName + "/" + strFileName;
                        ReqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(strUri));
                        ReqFTP.Credentials = new NetworkCredential(_userName, _password);
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
                strUri = "ftp://" + ftpServerIP + "/" + strFolderName;
                ReqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(strUri));
                ReqFTP.Credentials = new NetworkCredential(_userName, _password);
                ReqFTP.KeepAlive = false;
                ReqFTP.Method = WebRequestMethods.Ftp.RemoveDirectory;
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
            catch (Exception objException)
            {
                throw new Exception(objException.Message + "\r\n" + "Uri=" + strUri + "在函数DeleteFtpFolder中");
            }
        }

        /// <summary>
        /// ftp用户名
        /// </summary>
        public string UserName
        {
            get { return this._userName; }
            set { this._userName = value; }
        }
        /// <summary>
        /// ftp口令
        /// </summary>
        public string Password
        {
            get { return this._password; }
            set { this._password = value; }
        }
        /// <summary>
        /// 是否匿名？
        /// </summary>
        public bool IsAnonymousUser
        {
            get { return this._isAnonymousUser; }
            set { this._isAnonymousUser = value; }
        }

        private string _userName;
        private string _password;
        private bool _isAnonymousUser;
    }
}
