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
    /// ����ͻ��˵�FTP��
    /// </summary>
    public class clsFTPClient
    {
        /// <summary>
        /// ���캯��
        /// </summary>
        public clsFTPClient()
        {

        }
        /// <summary>
        /// ���غ���
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
        /// Ftp���غ���
        /// </summary>
        /// <param name="strFilePath">���ص�Ŀ¼·��</param>
        /// <param name="destinationFile">���ص�Ŀ���ļ���, ���ܴ���Ŀ¼��</param>
        /// <param name="ftpServerIP">FTP��������ַ</param>
        /// <param name="strFtpFileName">FTP�������ϵ��ļ���</param>
        /// <returns>FTP����״̬</returns>
        public FtpStatusCode Download(string strFilePath, string destinationFile, string ftpServerIP, string strFtpFileName)
        {
            try
            {
                if (destinationFile.IndexOf("/") >= 0)
                {
                    string strMsg = string.Format("���ص�Ŀ���ļ������ܴ�Ŀ¼�������а���\"/\",���飡Ŀ���ļ��ļ�����{0}", destinationFile);
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
                sbMsg.AppendFormat("����:{0}.", ex.Message);
                sbMsg.AppendFormat("���ص�Ŀ¼·��:[{0}];", strFilePath);
                sbMsg.AppendFormat("���ص�Ŀ���ļ���:[{0}];", destinationFile);
                sbMsg.AppendFormat("FTP��������ַ:[{0}];", ftpServerIP);
                sbMsg.AppendFormat("FTP�������ϵ��ļ���:[{0}];", strFtpFileName);
                throw new Exception(sbMsg.ToString());
            }
        }

        /// <summary>
        /// ����������Ŀ¼������������Ŀ¼���ļ�
        /// </summary>
        /// <param name="strFilePath">���ص�Ŀ¼·��</param>
        /// <param name="ftpServerIP">FTP��������ַ</param>
        /// <param name="strFtpFilePath">FTP�������ϵ�Ŀ¼·��</param>
        /// <returns>����״̬</returns>
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
                    "���������ļ��е����������⡣FTP�ļ�����Ϊ��" + strFtpFilePath + ". "
                    + "\r\n" + "�����ں�����DownloadDir in ��clsFTPClient�С�"
                    + "\r\n" + objException.Message
                    );
            }
            return true;
        }


        /// <summary>
        /// ���غ�������̬����
        /// </summary>
        /// <param name="strFilePath">���ص�Ŀ¼·��</param>
        /// <param name="strFtpFileName">FTP�������ϵ��ļ���</param>
        /// <param name="destinationFile">���ص�Ŀ���ļ���</param>
        /// <param name="ftpServerIP">FTP��������ַ</param>
        /// <param name="ftpUserName">FTP �û���</param>
        /// <param name="ftpPwd">FTP ����</param>
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

        //��ftp�������ļ�

        /// <summary>
        /// ���غ�����
        /// </summary>
        /// <param name="strFilePath">���ص�Ŀ¼·��</param>
        /// <param name="strFtpFileName">FTP�������ϵ��ļ���</param>
        /// <param name="destinationFile">���ص�Ŀ���ļ���</param>
        /// <param name="ftpServerIP">FTP��������ַ</param>
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
        /// �ϴ��ļ���ͬ������FTP��
        /// </summary>
        /// <param name="strSouFullFileName">���ص�Դ�ļ���������ȫĿ¼</param>
        /// <param name="strFtpFolderName">FTP��������Ŀ¼·��</param>
        /// <param name="ftpServerIP">FTP��������ַ</param>
        /// <returns>FTP״̬</returns>
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
            //��������(request)�ķ���
            ftpRequest.Method = WebRequestMethods.Ftp.UploadFile;


            //���ļ���
            stream = new FileStream(strSouFullFileName, FileMode.Open);

            //��Ҫ�Զ����Ƶķ�ʽ���ж��ļ�����.
            BinaryReader binReader_SouFile = new BinaryReader(stream);

            //fs = new FileStream(destinationFile, FileMode.Create);
            //��ȡ<����>��(Stream)
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
                //����<����>��(Stream)�Ķ����Ʒ�ʽд.
                BinaryWriter ftpBinWriter = new BinaryWriter(FtpStream);

                byte[] bb;
                //���������ж�1024���ֽ�
                bb = binReader_SouFile.ReadBytes(1024);
                //stream.Write(bb, 0, bb.Length);
                while (bb.Length > 0)
                {
                    //�����������ݳ���=��ȡ�ֽڵĳ���
                    ftpRequest.ContentLength = bb.Length;

                    //stream.Write(bb, intPosition, bb.Length);
                    //��ȡ��������д��<����>����
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
                //��ȡftp��Ӧ(ftpResponse)
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
                sbMsg.AppendFormat("����:{0}.", objException.Message);

                sbMsg.AppendFormat("���ص�Դ�ļ���������ȫĿ¼:[{0}];", strSouFullFileName);
                sbMsg.AppendFormat("FTP��������Ŀ¼·��:[{0}];", strFtpFolderName);
                sbMsg.AppendFormat("FTP��������ַ:[{0}];", ftpServerIP);
         

                sbMsg.AppendFormat("�����ں�����UpLoadDir in ��clsFTPClient�С�;");

                throw new Exception(sbMsg.ToString());
            }
        }


        /// <summary>
        /// �ϴ��ļ���ͬ������FTP��
        /// </summary>
        /// <param name="strSouFullFileName">���ص�Դ�ļ���������ȫĿ¼</param>
        /// <param name="strFtpFolderName">FTP��������Ŀ¼·��</param>
        /// <param name="newFilename">FTP�����ļ���</param>
        /// <param name="ftpServerIP">FTP��������ַ</param>
        /// <returns>FTP״̬</returns>
        public FtpStatusCode Rename(string strSouFullFileName, string strFtpFolderName, string newFilename, string ftpServerIP)
        {



            try
            {
                FileInfo fileInf = new FileInfo(strSouFullFileName);
                FtpWebRequest ftpRequest;
                ftpRequest = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + ftpServerIP + "/" + strFtpFolderName + "/" + fileInf.Name));

                ICredentials credential = new NetworkCredential(this._userName, this._password);
                ftpRequest.Credentials = credential;

                //��������(request)�ķ���
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
        /// �ϴ��ļ����ڷ������Ͽ��Ը���
        /// </summary>
        /// <param name="strSouFullFileName">���ص�Դ�ļ���������ȫĿ¼</param>
        /// <param name="strFtpFolderName">FTP��������Ŀ¼·��</param>
        /// <param name="strFtpFileName">FTP��������Ŀ���ļ���</param>
        /// <param name="ftpServerIP">FTP��������ַ</param>
        /// <returns>FTP״̬</returns>
        public FtpStatusCode UploadFile(string strSouFullFileName, string strFtpFolderName, string strFtpFileName, string ftpServerIP)
        {
            FtpWebRequest ftpRequest;
            ftpRequest = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + ftpServerIP + "/" + strFtpFolderName + "/" + strFtpFileName));

            ICredentials credential = new NetworkCredential(this._userName, this._password);
            ftpRequest.Credentials = credential;
            FileStream stream = null;
            Stream FtpStream = null;
            //��������(request)�ķ���
            ftpRequest.Method = WebRequestMethods.Ftp.UploadFile;

            try
            {
                //���ļ���
                stream = new FileStream(strSouFullFileName, FileMode.Open);

                //��Ҫ�Զ����Ƶķ�ʽ���ж��ļ�����.
                BinaryReader binReader_SouFile = new BinaryReader(stream);

                //fs = new FileStream(destinationFile, FileMode.Create);
                //��ȡ<����>��(Stream)
                FtpStream = ftpRequest.GetRequestStream();
                //����<����>��(Stream)�Ķ����Ʒ�ʽд.
                BinaryWriter ftpBinWriter = new BinaryWriter(FtpStream);

                byte[] bb;
                //���������ж�1024���ֽ�
                bb = binReader_SouFile.ReadBytes(1024);
                //stream.Write(bb, 0, bb.Length);
                while (bb.Length > 0)
                {
                    //�����������ݳ���=��ȡ�ֽڵĳ���
                    ftpRequest.ContentLength = bb.Length;

                    //stream.Write(bb, intPosition, bb.Length);
                    //��ȡ��������д��<����>����
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
                //��ȡftp��Ӧ(ftpResponse)
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
                sbMsg.AppendFormat("����:{0}.", objException.Message);
            
                sbMsg.AppendFormat("���ص�Դ�ļ���������ȫĿ¼:[{0}];", strSouFullFileName);
                sbMsg.AppendFormat("FTP��������Ŀ¼·��:[{0}];", strFtpFolderName);
                sbMsg.AppendFormat("FTP��������Ŀ���ļ���:[{0}];", strFtpFileName);
                sbMsg.AppendFormat("FTP��������ַ:[{0}];", ftpServerIP);
             
                throw new Exception(sbMsg.ToString());
            }
        }

        /// <summary>
        /// �ϴ�����Ŀ¼����̬����
        /// </summary>
        /// <param name="strFilesDir">���ص�ԴĿ¼��</param>
        /// <param name="strFtpDir">FTP��������Ŀ��·��</param>
        /// <param name="ftpServerIP">FTP��������ַ</param>
        /// <param name="ftpUserName">FTP �û���</param>
        /// <param name="ftpPwd">FTP ����</param>
        /// <returns>�ϴ��Ƿ�ɹ���</returns>
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
                sbMsg.AppendFormat("����:{0}.", objException.Message);
            
                sbMsg.AppendFormat("���ص�ԴĿ¼��:[{0}];", strFilesDir);
                sbMsg.AppendFormat("FTP��������Ŀ��·��:[{0}];", strFtpDir);
                sbMsg.AppendFormat("FTP��������ַ:[{0}];", ftpServerIP);
                sbMsg.AppendFormat("FTP �û���:[{0}];", ftpUserName);

                sbMsg.AppendFormat("�����ں�����UpLoadDir in ��clsFTPClient�С�;");

                throw new Exception(sbMsg.ToString());
            }

            return true;
        }
        //����������Ŀ¼

        /// <summary>
        /// �ϴ�����Ŀ¼
        /// </summary>
        /// <param name="strFilesDir">���ص�ԴĿ¼��</param>
        /// <param name="strFtpDir">FTP��������Ŀ��·��</param>
        /// <param name="ftpServerIP">FTP��������ַ</param>
        /// <returns>�ϴ��Ƿ�ɹ���</returns>
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
                sbMsg.AppendFormat("����:{0}.", objException.Message);
               
                
                sbMsg.AppendFormat("���ص�ԴĿ¼��:[{0}];", strFilesDir);
                sbMsg.AppendFormat("FTP��������Ŀ��·��:[{0}];", strFtpDir);
                sbMsg.AppendFormat("FTP��������ַ:[{0}];", ftpServerIP);
                sbMsg.AppendFormat("�����ں�����UpLoadDir in ��clsFTPClient�С�;");
     
                throw new Exception(sbMsg.ToString());

            }

            return true;
        }


        /// <summary>
        /// ����Ŀ¼����̬����
        /// </summary>
        /// <param name="FolderName">Ŀ¼��</param>
        /// <param name="ftpServerIP">FTP��������ַ</param>
        /// <param name="ftpUserName">FTP �û���</param>
        /// <param name="ftpPwd">FTP ����</param>
        public static void CreateDirectory(string FolderName, string ftpServerIP, string ftpUserName, string ftpPwd)
        {
            //��������Ŀ¼
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
                throw new Exception("ϵͳæ�����Ժ����ԣ�" + strNewFolderName + "\r\n" + objException.Message);
            }
        }

        /// <summary>
        /// ����Ŀ¼
        /// </summary>
        /// <param name="FolderName">Ŀ¼��</param>
        /// <param name="ftpServerIP">FTP��������ַ</param>
        public void MakeDirectory(string FolderName, string ftpServerIP)
        {
            //��������Ŀ¼
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
                throw new Exception("ϵͳæ�����Ժ����ԣ�");
            }
        }

        //�ӷ������ϴ��ļ���FTP��
        /// <summary>
        /// �ϴ��ļ�����һ�ַ�ʽ�����ļ�������С�ļ�
        /// </summary>
        /// <param name="strSouFullFileName">���ص�Դ�ļ���������ȫĿ¼</param>
        /// <param name="strFtpFolderName">FTP��������Ŀ��·��</param>
        /// <param name="ftpServerIP">FTP��������ַ</param>
        /// <param name="ftpUserName">FTP �û���</param>
        /// <param name="ftpPwd">FTP ����</param>
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
        /// ��ȡFTP������Ŀ¼�б���̬����
        /// </summary>
        /// <param name="strFolderName">FTP��������·��</param>
        /// <param name="ftpServerIP">FTP��������ַ</param>
        /// <param name="ftpUserName">FTP �û���</param>
        /// <param name="ftpPwd">FTP ����</param>
        /// <returns>���ص�Ŀ¼�б����ַ��������ʾ</returns>
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
        /// ��ȡĿ¼�ļ���ϸ�б������ļ���Ŀ¼��
        /// </summary>
        /// <param name="strFolderName">FTP��������·��</param>
        /// <param name="ftpServerIP">FTP��������ַ</param>
        /// <returns>���ص�Ŀ¼�б����ַ��������ʾ</returns>
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
                //                throw new Exception(objException.Message + "\r\n" + "Uri=" + strUri + "\r\n" + "�ں���GetFileList��");
            }

        }

        /// <summary>
        /// ��ȡFTP������Ŀ¼�б�
        /// </summary>
        /// <param name="strFolderName">FTP��������·��</param>
        /// <param name="ftpServerIP">FTP��������ַ</param>
        /// <returns>���ص�Ŀ¼�б����ַ��������ʾ</returns>
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
                //                throw new Exception(objException.Message + "\r\n" + "Uri=" + strUri + "\r\n" + "�ں���GetFileList��");
            }

        }

        //�ӿͻ����ϴ��ļ���FTP��

        /// <summary>
        /// �ϴ��ļ���ͬ������FTP��
        /// </summary>
        /// <param name="sHttpPostedFile"></param>
        /// <param name="filename">FTP��������Ŀ���ļ���</param>
        /// <param name="FolderName">FTP��������Ŀ��·��</param>
        /// <param name="ftpServerIP">FTP��������ַ</param>
        /// <param name="ftpUserName">�û���</param>
        /// <param name="ftpPwd">����</param>        
        private void UploadFtp(HttpPostedFile sHttpPostedFile, string filename, string FolderName, string ftpServerIP, string ftpUserName, string ftpPwd)
        {
            //��ȡ�ķ�����·��
            //FileInfo fileInf = new FileInfo(sFilePath);
            FtpWebRequest reqFTP;
            reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + ftpServerIP + "/" + FolderName + "/" + filename));
            reqFTP.Credentials = new NetworkCredential(ftpUserName, ftpPwd);
            reqFTP.KeepAlive = false;
            reqFTP.Method = WebRequestMethods.Ftp.UploadFile;
            reqFTP.UseBinary = true;
            reqFTP.ContentLength = sHttpPostedFile.ContentLength;
            //���û���
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

        //�������Ŀ¼���ļ��Ƿ����
        private static Regex regexName = new Regex(@"[^\s]*$", RegexOptions.Compiled);
        /// <summary>
        /// ���Ŀ¼�����ļ����Ƿ���ڣ���̬����
        /// </summary>
        /// <param name="strFolderName">�ļ�������Ŀ¼��</param>
        /// <param name="ftpServerIP">FTP��������ַ</param>
        /// <param name="ftpUserName">FTP �û���</param>
        /// <param name="ftpPwd">FTP ����</param>
        /// <returns>�Ƿ���ڣ�</returns>
        public static bool CheckFileOrPath(string strFolderName, string ftpServerIP, string ftpUserName, string ftpPwd)
        {
            if (strFolderName == @"/")
            {
                return true;
            }
            //���һ������Ŀ¼�Ƿ����
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
                        throw new ApplicationException("FTP ���ص��ִ���ʽ����ȷ");
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
        /// ���Ŀ¼�����ļ����Ƿ����
        /// </summary>
        /// <param name="strParentPath">�ļ�������Ŀ¼��</param>
        /// <param name="strFolderName">�ļ�������Ŀ¼��</param>
        /// <param name="ftpServerIP">FTP��������ַ</param>
        /// <returns>�Ƿ���ڣ�</returns>
        public bool CheckFileOrPath(string strParentPath, string strFolderName, string ftpServerIP)
        {
            string strUrl = "";
            if (strFolderName.StartsWith("/") == true)
            {
                strFolderName = strFolderName.Substring(1);
            }
            //�ṩ��Ŀ¼�����ж�㣬Ӧ�÷ֶ��ֱ��ж�
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
            //���һ������Ŀ¼�Ƿ����
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
                        throw new ApplicationException("FTP ���ص��ִ���ʽ����ȷ");
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
        /// ɾ��FTP�ϵĶ���ļ�����̬����
        /// </summary>
        /// <param name="strFileNameLst">��Ҫɾ�����ļ����б�</param>
        /// <param name="FolderName">�ļ�������Ŀ¼��</param>
        /// <param name="ftpServerIP">FTP��������ַ</param>
        /// <param name="ftpUserName">FTP �û���</param>
        /// <param name="ftpPwd">FTP ����</param>
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
        /// ɾ��FTP�ϵĶ���ļ�
        /// </summary>
        /// <param name="strFileNameLst">��Ҫɾ�����ļ����б�</param>
        /// <param name="FolderName">�ļ�������Ŀ¼��</param>
        /// <param name="ftpServerIP">FTP��������ַ</param>
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
        /// ɾ��FTP�ϵĵ����ļ�
        /// </summary>
        /// <param name="strFileName">��Ҫɾ�����ļ���</param>
        /// <param name="strFolderName">�ļ�������Ŀ¼��</param>
        /// <param name="ftpServerIP">FTP��������ַ</param>
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
        /// ɾ��FTP�ϵĵ���Ŀ¼
        /// </summary>
        /// <param name="strFolderName">�ļ�������Ŀ¼��</param>
        /// <param name="ftpServerIP">FTP��������ַ</param>    
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
                throw new Exception(objException.Message + "\r\n" + "Uri=" + strUri + "�ں���DeleteFtpFolder��");
            }
        }

        /// <summary>
        /// ftp�û���
        /// </summary>
        public string UserName
        {
            get { return this._userName; }
            set { this._userName = value; }
        }
        /// <summary>
        /// ftp����
        /// </summary>
        public string Password
        {
            get { return this._password; }
            set { this._password = value; }
        }
        /// <summary>
        /// �Ƿ�������
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
