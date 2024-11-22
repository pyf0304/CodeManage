using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using com.taishsoft.common;
using com.taishsoft.datetime;

namespace com.taishsoft.file
{
    public partial class clsFile
    {
        /// <summary>
        /// �����ļ�����������һ���ļ�
        /// </summary>
        /// <param name="strFullFileName"></param>
        /// <param name="strFileContent"></param>
        /// <returns></returns>
        public static bool CreateFileByString(string strFullFileName, string strFileContent)
        {
            string strFilePath = clsString.ParentDir_S(strFullFileName);
            if (Directory.Exists(strFilePath) == false)
            {
                Directory.CreateDirectory(strFilePath);
            }
            FileStream fs = new FileStream(strFullFileName, FileMode.Create);
            StreamWriter objStreamWriter = new StreamWriter(fs, Encoding.GetEncoding("gb2312"));    
            //д�ļ���;
            //string strFileName2 = clsSysPara_PubDataBase.TempFileFolder + objFileTab.FtpFileName;
            //����WebForm�ı��ļ�;
            //�����ɴ���д���ļ���ȥ;
            objStreamWriter.Write(strFileContent);
            //�ر��ļ�;
            objStreamWriter.Flush();
            objStreamWriter.Close();
            fs.Close();
            return true;
        }

        /// <summary>
        /// �����ļ�����������һ���ļ�
        /// </summary>
        /// <param name="strFullFileName"></param>
        /// <param name="strFileContent"></param>
        /// <returns></returns>
        public static bool CreateFileByString(string strFullFileName, string strFileContent, Encoding myEncoding)
        {
            string strFilePath = clsString.ParentDir_S(strFullFileName);
            if (Directory.Exists(strFilePath) == false)
            {
                Directory.CreateDirectory(strFilePath);
            }
            FileStream fs = new FileStream(strFullFileName, FileMode.Create);
            StreamWriter objStreamWriter = new StreamWriter(fs, myEncoding);    
            //д�ļ���;
            //string strFileName2 = clsSysPara_PubDataBase.TempFileFolder + objFileTab.FtpFileName;
            //����WebForm�ı��ļ�;
            //�����ɴ���д���ļ���ȥ;
            objStreamWriter.Write(strFileContent);
            //�ر��ļ�;
            objStreamWriter.Flush();
            objStreamWriter.Close();
            fs.Close();
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="strFullFileName"></param>
        /// <param name="strFileContent"></param>
        /// <returns></returns>
        public static bool AppendStringToFile(string strFullFileName, string strFileContent)
        {
            string strFilePath = clsString.ParentDir_S(strFullFileName);
            if (Directory.Exists(strFilePath) == false)
            {
                Directory.CreateDirectory(strFilePath);
            }
            FileStream fs = new FileStream(strFullFileName, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter objStreamWriter = new StreamWriter(fs, Encoding.GetEncoding("gb2312"));    
            //д�ļ���;
            //�����ɴ���д���ļ���ȥ;
            objStreamWriter.BaseStream.Seek(0, SeekOrigin.End);
            objStreamWriter.WriteLine(strFileContent + "\r\n");
            //�ر��ļ�;
            objStreamWriter.Flush();
            objStreamWriter.Close();
            fs.Close();
            return true;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strFullFileName"></param>
        /// <returns></returns>
        public static string GetContentFromTextFile(string strFullFileName)
        {
            StringBuilder sbFileContent = new StringBuilder();
            string szSrcLine = "";
            System.IO.FileStream fsInput = new FileStream(strFullFileName, FileMode.Open, FileAccess.Read);
            System.IO.StreamReader srInput = new StreamReader(fsInput, System.Text.Encoding.GetEncoding("GB2312"));
            while ((szSrcLine = srInput.ReadLine()) != null)
            {
                sbFileContent.AppendLine(szSrcLine);
            }
            srInput.Close();
            fsInput.Close();
            return sbFileContent.ToString();
        }
        /// <summary>
        /// ��ȡ�ı��ļ���ǰ�����ı�
        /// </summary>
        /// <param name="strFullFileName">�ļ���ʶ��</param>
        /// <param name="intLine">ǰN��</param>
        /// <returns>��ȡ���ı�</returns>
        public static string GetContentFromTextFile_Lines(string strFullFileName, int intLine)
        {
            if (intLine < 0)
            {
                throw new Exception("��������ȷ��������" + intLine.ToString()
                    + "\r\n �ں���GetContentFromTextFile_Lines in (clsFile)�С�");
            }
            StringBuilder sbFileContent = new StringBuilder();
            string szSrcLine = "";
            System.IO.FileStream fsInput = new FileStream(strFullFileName, FileMode.Open, FileAccess.Read);
            System.IO.StreamReader srInput = new StreamReader(fsInput, System.Text.Encoding.GetEncoding("GB2312"));
            int intIndex = 0;
            while ((szSrcLine = srInput.ReadLine()) != null)
            {
                if (intIndex >= intLine)
                {
                    break;
                }
                if (szSrcLine.Trim().Length > 0)
                {
                    sbFileContent.AppendLine(szSrcLine);
                    intIndex++;
                }
            }
            srInput.Close();
            fsInput.Close();
            return sbFileContent.ToString();
        }

        public static List<string> GetContentLinesFromTextFile(string strFullFileName)
        {
            List<string> arrLine = new List<string>();
            StringBuilder sbFileContent = new StringBuilder();
            string szSrcLine = "";
            System.IO.FileStream fsInput = new FileStream(strFullFileName, FileMode.Open, FileAccess.Read);
            System.IO.StreamReader srInput = new StreamReader(fsInput, System.Text.Encoding.GetEncoding("GB2312"));
            while ((szSrcLine = srInput.ReadLine()) != null)
            {
                arrLine.Add(szSrcLine);
            }
            srInput.Close();
            fsInput.Close();
            return arrLine;
        }


        /// <summary>
        /// ��ȡ�ı��ļ���ǰ�����ı�
        /// </summary>
        /// <param name="strFullFileName">�ļ���ʶ��</param>
        /// <param name="objTextRange">�ı���Χ</param>
        /// <returns>��ȡ���ı�</returns>
        public static string GetContentFromTextFileByRange(string strFullFileName, stuTextRange objTextRange)
        {
            string strMsg = "";
            if (objTextRange.StartPos.Line <= 0 )
            {
                throw new Exception("��ʼ��������ȷ��������" + objTextRange.StartPos.Line.ToString()
                    + "\r\n GetContentFromTextFileByRange in (clsFile)�С�");
            }
            if (objTextRange.EndPos.Line <= 0)
            {
                throw new Exception("������������ȷ��������" + objTextRange.EndPos.Line.ToString()
                    + "\r\n GetContentFromTextFileByRange in (clsFile)�С�");
            }
            if (objTextRange.StartPos.Col <= 0)
            {
                throw new Exception("��ʼ��������ȷ��������" + objTextRange.StartPos.Col.ToString()
                    + "\r\n GetContentFromTextFileByRange in (clsFile)�С�");
            }
            if (objTextRange.EndPos.Col <= 0)
            {
                throw new Exception("������������ȷ��������" + objTextRange.EndPos.Col.ToString()
                    + "\r\n GetContentFromTextFileByRange in (clsFile)�С�");
            }
            if (objTextRange.EndPos.Line < objTextRange.StartPos.Line)
            {
                strMsg = string.Format("�����������ܴ��ڿ�ʼ����������ȷ����ʼ����:{0}, ������:{1}. (In {2})",
                    objTextRange.StartPos.Line, objTextRange.EndPos.Line, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            if (objTextRange.EndPos.Line == objTextRange.StartPos.Line && objTextRange.EndPos.Col < objTextRange.StartPos.Col)
            {
                strMsg = string.Format("��ʼ��������һ��������ʼ�в��ܴ��ڿ�ʼ�У�����ȷ����:{0}, ��ʼ��:{1}, ������:{2}. (In {3})",
                    objTextRange.StartPos.Line, objTextRange.StartPos.Col, objTextRange.EndPos.Col, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            List<string> arrLine = clsFile.GetContentLinesFromTextFile(strFullFileName);
            if (arrLine.Count == 0)
            {
                strMsg = string.Format("�ļ�������Ϊ�գ�����ȷ���ļ���:{0}. (In {1})",
                    strFullFileName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            if (arrLine.Count < objTextRange.EndPos.Line)
            {
                strMsg = string.Format("�����������ܴ����ļ�������������ȷ����������:{0}, �ı�������:{1}. (In {2})",
                    objTextRange.EndPos.Line, arrLine.Count, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            StringBuilder sbContent = new StringBuilder();
            int intCurrLine = objTextRange.StartPos.Line - 1;
            if (objTextRange.StartPos.Line == objTextRange.EndPos.Line)
            {
                string strLine = arrLine[intCurrLine];
                if (objTextRange.EndPos.Col >= strLine.Length)
                {
                    sbContent.AppendLine(strLine.Substring(objTextRange.StartPos.Col - 1));
                }
                else
                {
                    sbContent.AppendLine(strLine.Substring(objTextRange.StartPos.Col - 1,
                        objTextRange.EndPos.Col - objTextRange.StartPos.Col));
                }
                return sbContent.ToString();
            }
            sbContent.AppendLine(arrLine[intCurrLine].Substring(objTextRange.StartPos.Col-1));
            intCurrLine++;
            while (intCurrLine< objTextRange.EndPos.Line-1)
            {
                sbContent.AppendLine(arrLine[intCurrLine]);
                intCurrLine++;
            }
            string strTemp = "";
            try
            {
                string strLine = arrLine[intCurrLine];
                if (objTextRange.EndPos.Col >= strLine.Length)
                {
                    sbContent.AppendLine(strLine);
                }
                else
                {
                    strTemp = strLine.Substring(0, objTextRange.EndPos.Col - 1);
                    sbContent.AppendLine(strTemp);
                }
            }
            catch(Exception objException)
            {
                string strSS = "";
            }
 

            return sbContent.ToString();
        }

        /// <summary>
        /// ��һ��Ŀ¼��ȥ��ѯһ���ļ�������������ļ�������Ŀ¼
        /// </summary>
        /// <param name="strFileName">��Ҫ���ҵ��ļ���</param>
        /// <param name="strFilePath">���ҵ�Ŀ¼</param>
        /// <returns>�������ҵ����ļ�Ŀ¼��������Ҳ����ͷ��ؿմ���</returns>
        public static string FindFilePathByFileName(string strFileName, string strFilePath)
        {
            DirectoryInfo objDirInfo = new DirectoryInfo(strFilePath);
            FileInfo[] lstFileInfo = objDirInfo.GetFiles();
            foreach (FileInfo objFileInfo in lstFileInfo)
            {
                if (objFileInfo.Name.Equals(strFileName, StringComparison.CurrentCultureIgnoreCase) == true)
                {
                    return objFileInfo.DirectoryName;
                }
               
            }
            DirectoryInfo[] lstDirectoryInfo = objDirInfo.GetDirectories();
            foreach (DirectoryInfo objDirectoryInfo in lstDirectoryInfo)
            {
                return FindFilePathByFileName(strFileName, objDirectoryInfo);
                            

            }
            return "";
        }

        /// <summary>
        /// ��һ��Ŀ¼��ȥ��ѯһ���ļ�������������ļ�������Ŀ¼
        /// </summary>
        /// <param name="strFileName">��Ҫ���ҵ��ļ���</param>
        /// <param name="objDirInfo">���ҵ�Ŀ¼��DirectoryInfo objDirInfo��</param>
        /// <returns>�������ҵ����ļ�Ŀ¼��������Ҳ����ͷ��ؿմ���</returns>
        public static string FindFilePathByFileName(string strFileName, DirectoryInfo objDirInfo)
        {
          
            FileInfo[] lstFileInfo = objDirInfo.GetFiles();
            foreach (FileInfo objFileInfo in lstFileInfo)
            {
                if (objFileInfo.Name.Equals(strFileName, StringComparison.CurrentCultureIgnoreCase) == true)
                {
                    return objFileInfo.DirectoryName;
                }
            }
            DirectoryInfo[] lstDirectoryInfo = objDirInfo.GetDirectories();
            foreach (DirectoryInfo objDirectoryInfo in lstDirectoryInfo)
            {
                return FindFilePathByFileName(strFileName, objDirectoryInfo);
            }
            return "";
        }

        /// <summary>
        /// ��һ��Ŀ¼��ȥ��ѯһ���ļ�������������ļ�������Ŀ¼
        /// </summary>
        /// <param name="strSimpleFileName">��Ҫ���ҵ��ļ���</param>
        /// <param name="strFolder">���ҵ�Ŀ¼</param>
        /// <returns>�������ҵ����ļ�Ŀ¼��������Ҳ����ͷ��ؿմ���</returns>
        public static string FindFileFromFolder(string strFolder, string strSimpleFileName)
        {
            if (System.IO.Directory.Exists(strFolder) == false)
            {
                string strMsg = string.Format("Ŀ¼��{0}�����ڣ����飡", strFolder);
                throw new Exception(strMsg);
            }
            DirectoryInfo objDirectory = new DirectoryInfo(strFolder);
            FileInfo[] arrFileInfoLst = objDirectory.GetFiles();
            foreach (FileInfo objFileInfo in arrFileInfoLst)
            {
                if (objFileInfo.Name.Equals(strSimpleFileName, StringComparison.InvariantCultureIgnoreCase) == true)
                {
                    //objFileInfo.
                    return objFileInfo.FullName;
                }

            }
            DirectoryInfo[] arrDirectoryInfoLst = objDirectory.GetDirectories();
            foreach (DirectoryInfo objDirectoryInfo in arrDirectoryInfoLst)
            {
                string strFindFile = FindFileFromFolder(objDirectoryInfo, strSimpleFileName);
                if (string.IsNullOrEmpty(strFindFile) == false)
                {
                    return strFindFile;
                }
            }
            return "";
        }

        /// <summary>
        /// ��һ��Ŀ¼��ȥ����һ���ļ���������������ļ����������ļ�Ŀ¼�б�(��Ŀ¼)
        /// </summary>
        /// <param name="strSimpleFileName">��Ҫ���ҵ��ļ���</param>
        /// <param name="strFolder">���ҵ�Ŀ¼</param>
        /// <returns>�������ҵ����ļ�Ŀ¼�б�����Ҳ����ͷ��ؿմ���</returns>
        public static List<string> FindFileLstFromFolder(string strFolder, string strSimpleFileName)
        {
            if (System.IO.Directory.Exists(strFolder) == false)
            {
                string strMsg = string.Format("Ŀ¼��{0}�����ڣ����飡", strFolder);
                throw new Exception(strMsg);
            }
            List<string> arrFileLst = new List<string>();
            Queue<string> quFolder = new Queue<string>();
            quFolder.Enqueue(strFolder);
            while (quFolder.Count > 0)
            {
                string strFolder_Top = quFolder.Dequeue();
                DirectoryInfo objDirectory = new DirectoryInfo(strFolder_Top);
                FileInfo[] arrFileInfoLst = objDirectory.GetFiles();
                foreach (FileInfo objFileInfo in arrFileInfoLst)
                {
                    if (objFileInfo.Name.Equals(strSimpleFileName, StringComparison.InvariantCultureIgnoreCase) == true)
                    {
                        //objFileInfo.
                        arrFileLst.Add( objFileInfo.FullName);
                    }
                }
                DirectoryInfo[] arrDirectoryInfoLst = objDirectory.GetDirectories();
                foreach (DirectoryInfo objDirectoryInfo in arrDirectoryInfoLst)
                {
                    quFolder.Enqueue(objDirectoryInfo.FullName);
                }
            }
            return arrFileLst;
        }

        /// <summary>
        /// ��һ��Ŀ¼��ȥ��ѯһ���ļ�������������ļ�������Ŀ¼
        /// </summary>
        /// <param name="strSimpleFileName">��Ҫ���ҵ��ļ���</param>
        /// <param name="objDirectoryP">���ҵ�Ŀ¼��DirectoryInfo objDirInfo��</param>
        /// <returns>�������ҵ����ļ�Ŀ¼��������Ҳ����ͷ��ؿմ���</returns>
        public static string FindFileFromFolder(DirectoryInfo objDirectoryP, string strSimpleFileName)
        {

            FileInfo[] arrFileInfoLst = objDirectoryP.GetFiles();
            foreach (FileInfo objFileInfo in arrFileInfoLst)
            {
                if (objFileInfo.Name.Equals(strSimpleFileName, StringComparison.InvariantCultureIgnoreCase)==true)
                {
                    //objFileInfo.
                    return objFileInfo.FullName;
                }
            }
            DirectoryInfo[] arrDirectoryInfoLst = objDirectoryP.GetDirectories();
            foreach (DirectoryInfo objDirectoryInfo in arrDirectoryInfoLst)
            {
                string strFindFile = FindFileFromFolder(objDirectoryInfo, strSimpleFileName);
                if (string.IsNullOrEmpty(strFindFile) == false)
                {
                    return strFindFile;
                }
            }
            return "";
        }
        
        /// <summary>
        /// �ļ�����
        /// </summary>
        /// <param name="fName">ԭ�ļ�</param>
        /// <returns></returns>
        public bool FileBackup(string fName)
        {
            string fNameBak;
            string NewfName;
            if (File.Exists(fName))
            {
                fNameBak = fName + "bak";
                NewfName = fName + "1";
                if (File.Exists(fNameBak)) File.Delete(fNameBak);
                if (File.Exists(NewfName)) File.Delete(NewfName);
                File.Copy(fName, fNameBak);
                File.Copy(fName, NewfName);
            }
            else
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// �ļ�����
        /// </summary>
        /// <param name="fName"></param>
        /// <param name="strBackupFolderName"></param>
        /// <returns></returns>
        public static  bool FileBackup(string fName, string strBackupFolderName)
        {
            FileInfo objFI = new FileInfo(fName);

            string strSimpleFileName = objFI.Name;
            //string strExtends = objFI.Extension;

            if (string.IsNullOrEmpty(strBackupFolderName) == true)
            {
                throw new Exception("����Ŀ¼����Ϊ�գ�");
            }
            if (System.IO.Directory.Exists(strBackupFolderName) == false)
            {
                Directory.CreateDirectory(strBackupFolderName);
            }
            string strBackupFile = strBackupFolderName + "\\" + strSimpleFileName + ".Bak";
            strBackupFile = strBackupFile.Replace("\\\\", "\\");
            int intFileIndex = 1;
            while (File.Exists(strBackupFile) == true)
            {
                strBackupFile = string.Format(strBackupFolderName + "\\" + strSimpleFileName + ".Bak{0}", intFileIndex);
                strBackupFile = strBackupFile.Replace("\\\\", "\\");
                intFileIndex++;
            }
            File.Copy(fName, strBackupFile);
            return true;
        }
        /// <summary>
        /// ��ȡ��ǰĿ¼�ĸ�Ŀ¼
        /// </summary>
        /// <param name="strPath">������Ŀ¼</param>
        /// <returns>���ظ�Ŀ¼</returns>
        public string ParentDir(string strPath)
        {
            string pDir;
            int i;
            i = strPath.LastIndexOf("\\");
            if (i == 0) return null;
            pDir = strPath.Substring(0, i);
            return pDir;
        }

        /// <summary>
        /// ��ȡ��ǰĿ¼�ĸ�Ŀ¼
        /// </summary>
        /// <param name="strPath">������Ŀ¼</param>
        /// <returns>���ظ�Ŀ¼</returns>
        public static string GetDirName_S(string strPath)
        {
            string pDir;
            int i;
            i = strPath.LastIndexOf("\\");

            if (i <= 0) return "";
            pDir = strPath.Substring(0, i);
            return pDir;
        }
        /// <summary>
        /// ��ȡ��ǰĿ¼�ĸ�Ŀ¼
        /// </summary>
        /// <param name="strPath">������Ŀ¼</param>
        /// <returns>���ظ�Ŀ¼</returns>
        public static string ParentDir_S(string strPath)
        {
            string pDir;
            int i;
            i = strPath.LastIndexOf("\\");
            if (i <= 0) return "";
            pDir = strPath.Substring(0, i);
            return pDir;
        }
        /// <summary>
        /// �����չ��
        /// </summary>
        /// <param name="strFileName"></param>
        /// <param name="strExeName"></param>
        /// <returns></returns>
        public bool AddExeName(ref string strFileName, string strExeName)
        {
            int i;
            i = strFileName.LastIndexOf(strExeName);
            if (i == 0) strFileName += strExeName;
            return true;
        }
        /// <summary>
        /// �Ӵ���Ŀ¼���ļ����л�ȡ�򵥵��ļ���
        /// </summary>
        /// <param name="strFileName">����Ŀ¼���ļ���</param>
        /// <returns>����Ŀ¼�ļ򵥵��ļ���</returns>
        public string GetSimpleFName(string strFileName)
        {
            string sFName;
            int i;
            i = strFileName.LastIndexOf("\\");
            if (i == 0) return null;
            sFName = strFileName.Substring(i + 1);
            return sFName;
        }
        /// <summary>
        /// �Ӵ���Ŀ¼���ļ����л�ȡ�򵥵��ļ���
        /// </summary>
        /// <param name="strFileName">����Ŀ¼���ļ���</param>
        /// <returns>����Ŀ¼�ļ򵥵��ļ���</returns>
        public static string GetSimpleFName_S(string strFileName)
        {
            string sFName;
            int i;
            strFileName = strFileName.Replace("/", "\\");
            i = strFileName.LastIndexOf("\\");
            if (i == 0) return null;
            sFName = strFileName.Substring(i + 1);
            return sFName;
        }

        /// <summary>
        /// �Ӵ���Ŀ¼���ļ����л�ȡ·����
        /// </summary>
        /// <param name="strFullFileName">����Ŀ¼���ļ���</param>
        /// <returns>�ļ���·����</returns>
        public static string GetFloder(string strFullFileName)
        {
            string sFoldName;
            int i;
            strFullFileName = strFullFileName.Replace("/", "\\");
            i = strFullFileName.LastIndexOf("\\");
            if (i == 0) return null;
            sFoldName = strFullFileName.Substring(0, i);
            return sFoldName;
        }

        /// <summary>
        /// �Ӷ༶Ŀ¼�л�ȡ���һ��Ŀ¼��
        /// </summary>
        /// <param name="strFilePath">����Ŀ¼���ļ���</param>
        /// <returns>����Ŀ¼�ļ򵥵��ļ���</returns>
        public static string GetSimplePath(string strFilePath)
        {
            string strSimplePath;
            int i, j;
            i = strFilePath.LastIndexOf("\\");
            j = strFilePath.LastIndexOf("/");
            int ii = i > j ? i : j;
            if (ii <= 0)
            {
                return strFilePath;
            }
            strSimplePath = strFilePath.Substring(ii + 1);
            return strSimplePath;
        }
        /// <summary>
        /// �����ļ�������ȡ���ļ�����չ��
        /// </summary>
        /// <param name="strFileName">�������ļ���</param>
        /// <returns></returns>
        public static string GetFileExtName(string strFileName)
        {
            string strFileExtName;
            int i;
            i = strFileName.LastIndexOf(".");
            if (i == 0) return null;
            strFileExtName = strFileName.Substring(i + 1);
            return strFileExtName;
        }
        /// <summary>
        /// �����ļ�������ȡ���ļ���ȥ����չ���Ĵ����ļ���
        /// </summary>
        /// <param name="strFileName">�������ļ���</param>
        /// <returns></returns>
        public static string GetPureFileName(string strFileName)
        {
            if (strFileName == "")
                return null;
            string strPureFileName;
            int i;
            i = strFileName.LastIndexOf(".");
            if (i == 0) return strFileName;
            strPureFileName = strFileName.Substring(0, i);
            return strPureFileName;
        }
        /// <summary>
        /// �����ļ�Ŀ¼��ȡ�ļ��б��������ļ������б�ķ�ʽ����
        /// </summary>
        /// <param name="strFolder">�ļ�Ŀ¼</param>
        /// <returns>�����ļ������б�</returns>
        public static FileCollection GetFileList(string strFolder)
        {
            FileCollection objFileColl = new FileCollection();
            if (Directory.Exists(strFolder) == false)
            {
                string strMsg = string.Format("·����{0}�����ڣ����飡�����������Ա��ϵ����", strFolder);
                throw new Exception(strMsg);
            }
            string[] strFiles = null;
            try
            {
                strFiles = Directory.GetFiles(strFolder);
            }
            catch(Exception objException)
            {
                throw objException;
            }
            int i = 1;
            foreach (string strFileName in strFiles)
            {
                //bool bolIsAccordofResourceType = false;
                //FileAttributes objFileAttr = File.GetAttributes(strFileName);
                FileInfo objFile = new FileInfo(strFileName);
                if (objFile.Length < 2)
                {
//                    clsPubVar4LogicEx.objLog.WriteDebugLog(string.Format("ɾ��0�ֽ��ļ���{0}�ɹ���", objFile.Name));

                    objFile.Delete();
                    continue;
                }
                UserFile objUserFile = new UserFile();
                objUserFile.OrderNum = i++;
                objUserFile.FileName = objFile.Name;
                objUserFile.FileSize = objFile.Length;
                objUserFile.Extension = objFile.Extension;
                objUserFile.LastWriteTime = objFile.LastWriteTime;
                objUserFile.CreationTime = objFile.CreationTime;

                objUserFile.FullDirName = strFolder;
               // objUserFile.ResourceTypeName = strResourceTypeLsts;
                objUserFile.UploadDate = clsDateTime.ChangeDateToDate10(clsDateTime.ChangeDateToDate8(objFile.CreationTime));
                objFileColl.Add(objUserFile);
            }
     
            return objFileColl;

        }

        /// <summary>
        /// �����ļ�Ŀ¼��ȡ�ļ��б��������ļ������б�ķ�ʽ����, �����������Ŀ¼
        /// </summary>
        /// <param name="strFolder">�ļ�Ŀ¼</param>
        /// <param name="objFileColl">�ļ�����</param>
        /// <returns>�����ļ������б�</returns>
        public static void GetFileListEx(string strFolder, FileCollection objFileColl)
        {
            //FileCollection objFileColl = new FileCollection();
            if (Directory.Exists(strFolder) == false)
            {
                string strMsg = string.Format("·����{0}�����ڣ����飡�����������Ա��ϵ����", strFolder);
                throw new Exception(strMsg);
            }
            string[] strFiles = null;
            try
            {
                strFiles = Directory.GetFiles(strFolder);
            }
            catch (Exception objException)
            {
                throw objException;
            }
            int i = 1;
            foreach (string strFileName in strFiles)
            {
                //bool bolIsAccordofResourceType = false;
                //FileAttributes objFileAttr = File.GetAttributes(strFileName);
                FileInfo objFile = new FileInfo(strFileName);
                if (objFile.Length < 2)
                {
                    //                    clsPubVar4LogicEx.objLog.WriteDebugLog(string.Format("ɾ��0�ֽ��ļ���{0}�ɹ���", objFile.Name));

                    objFile.Delete();
                    continue;
                }
                UserFile objUserFile = new UserFile();
                objUserFile.OrderNum = i++;
                objUserFile.FileName = objFile.Name;
                objUserFile.FileSize = objFile.Length;
                objUserFile.Extension = objFile.Extension;
                objUserFile.LastWriteTime = objFile.LastWriteTime;
                objUserFile.CreationTime = objFile.CreationTime;

                objUserFile.FullDirName = strFolder;
                // objUserFile.ResourceTypeName = strResourceTypeLsts;
                objUserFile.UploadDate = clsDateTime.ChangeDateToDate10(clsDateTime.ChangeDateToDate8(objFile.CreationTime));
                objFileColl.Add(objUserFile);
            }
            string[] strFolders = Directory.GetDirectories(strFolder);
            foreach (string strFolderName in strFolders)
            {
                GetFileListEx(strFolderName, objFileColl);
            }
            //return objFileColl;
        }


        /// <summary>
        /// �����ļ�Ŀ¼��ȡ�����ļ����б��������ļ������б�ķ�ʽ����
        /// </summary>
        /// <param name="strFolder">�ļ�Ŀ¼</param>
        /// <returns>�����ļ������б�</returns>
        public static FileCollection GetFolderList(string strFolder)
        {
            FileCollection objDirectoryColl = new FileCollection();
            if (Directory.Exists(strFolder) == false)
            {
                string strMsg = string.Format("·����{0}�����ڣ����飡�����������Ա��ϵ����", strFolder);
                throw new Exception(strMsg);
            }
            string[] strFolders = Directory.GetDirectories(strFolder);

            int i = 1;
            foreach (string strFolderName in strFolders)
            {
                //bool bolIsAccordofResourceType = false;
                //FileAttributes objDirectoryAttr = File.GetAttributes(strFolderName);
                DirectoryInfo objDirectory = new DirectoryInfo(strFolderName);
                if (objDirectory.FullName.Length < 2)
                {
                    //                    clsPubVar4LogicEx.objLog.WriteDebugLog(string.Format("ɾ��0�ֽ��ļ���{0}�ɹ���", objDirectory.Name));

                    objDirectory.Delete();
                    continue;
                }
                UserFile objUserFile = new UserFile();
                objUserFile.OrderNum = i++;
                objUserFile.FileName = objDirectory.Name;
                //objUserFile.FileSize = objDirectory.Length;
                objUserFile.Extension = objDirectory.Extension;
                objUserFile.LastWriteTime = objDirectory.LastWriteTime;
                objUserFile.CreationTime = objDirectory.CreationTime;

                objUserFile.FullDirName = strFolder;

                // objUserFile.ResourceTypeName = strResourceTypeLsts;
                objUserFile.UploadDate = clsDateTime.ChangeDateToDate10(clsDateTime.ChangeDateToDate8(objDirectory.CreationTime));
                objDirectoryColl.Add(objUserFile);
            }

            return objDirectoryColl;

        }



        /// <summary>
        /// ����������ļ�Ŀ¼���Ƿ���������ļ����������������ļ�Ŀ¼��������Ŀ¼���в���
        /// </summary>
        /// <param name="strFolder">�ļ�Ŀ¼</param>
        /// <param name="strFileName">�ļ���,����Ŀ¼</param>
        /// <returns>�����ļ��Ƿ���ڣ����ڷ���True, ���򷵻�False</returns>
        public static bool IsExists(string strFolder, string strFileName)
        {
          
            FileCollection objDirectoryColl = new FileCollection();
            if (Directory.Exists(strFolder) == false)
            {
                string strMsg = string.Format("·����{0}�����ڣ����飡�����������Ա��ϵ����", strFolder);
                throw new Exception(strMsg);
            }
            string strFullFileName = string.Format("{0}\\{1}", strFolder, strFileName);
            if (File.Exists(strFullFileName) == true) return true;

            string[] strFolders = Directory.GetDirectories(strFolder);
            
            foreach (string strFolderName in strFolders)
            {
                if (IsExists(strFolderName, strFileName) == true) return true;
            }

            return false;

        }

        /// <summary>
        /// ��������Ŀ¼�л�ȡĳ�ļ���·�����������ļ�����·����ʽ����
        /// </summary>
        /// <param name="strParentFolder">�ļ�Ŀ¼</param>
        /// <param name="strFileName">�ļ���,����Ŀ¼</param>
        /// <returns>����ҵ�ĳ�ļ������ظ��ļ�������·�������򷵻ؿմ�</returns>
        public static string GetFilePath(string strParentFolder, string strFileName)
        {

            FileCollection objDirectoryColl = new FileCollection();
            if (Directory.Exists(strParentFolder) == false)
            {
                string strMsg = string.Format("·����{0}�����ڣ����飡�����������Ա��ϵ����", strParentFolder);
                throw new Exception(strMsg);
            }
            string strFullFileName = string.Format("{0}\\{1}", strParentFolder, strFileName);
            if (File.Exists(strFullFileName) == true) return strFullFileName;

            string[] strFolders = Directory.GetDirectories(strParentFolder);

            foreach (string strFolderName in strFolders)
            {
                strFullFileName = GetFilePath(strFolderName, strFileName);
                if (string.IsNullOrEmpty(strFullFileName) == false) return strFullFileName;
            }

            return "";

        }

        /// <summary>
        /// ��������Ŀ¼�л�ȡĳ�ļ���ͬԴ�ļ��б��������ļ��б���
        /// </summary>
        /// <param name="strParentFolder">�ļ�Ŀ¼</param>
        /// <param name="strFileName">�ļ���,����Ŀ¼</param>
        /// <returns>����ҵ�ĳ�ļ������ظ��ļ�������·�������򷵻ؿմ�</returns>
        public static List<string> GetSameSourceFileLst(string strParentFolder, string strFileName)
        {

            FileCollection objDirectoryColl = new FileCollection();
            if (Directory.Exists(strParentFolder) == false)
            {
                string strMsg = string.Format("·����{0}�����ڣ����飡�����������Ա��ϵ����", strParentFolder);
                throw new Exception(strMsg);
            }
            string strFullFileName = string.Format("{0}\\{1}", strParentFolder, strFileName);
            if (File.Exists(strFullFileName) == false)
            {
                string strMsg = string.Format("�ļ���{0}�����ڣ����飡�����������Ա��ϵ����",
                    strFullFileName);
                throw new Exception(strMsg);
            }
            FileInfo objFileInfo = new FileInfo(strFullFileName);
         
            string[] strFiles = Directory.GetFiles(strParentFolder);
            List<string> arrSameSourceFile = new List<string>();
            foreach (string strFileName_In in strFiles)
            {
                FileInfo objFileInfo_In = new FileInfo(strFileName_In);
                if (objFileInfo.Name == objFileInfo_In.Name) continue;
                if (objFileInfo.Extension != objFileInfo_In.Extension) continue;
                if (objFileInfo.LastWriteTime != objFileInfo_In.LastWriteTime) continue;
                if (objFileInfo.Length != objFileInfo_In.Length) continue;
                arrSameSourceFile.Add(objFileInfo_In.Name);
            }

            return arrSameSourceFile;

        }
        /// <summary>
        /// �����ļ�Ŀ¼��ȡ�ļ��б��������ļ������б�ķ�ʽ���أ� �����ڽ���
        /// </summary>
        /// <param name="strFolder">�ļ�Ŀ¼</param>
        /// <returns>�����ļ������б�</returns>
        public static FileCollection GetFileListByDateDesc(string strFolder)
        {
            FileCollection objFileColl = new FileCollection();
            string[] strFiles = Directory.GetFiles(strFolder);

            int i = 1;
            foreach (string strFileName in strFiles)
            {
                //bool bolIsAccordofResourceType = false;
                //FileAttributes objFileAttr = File.GetAttributes(strFileName);
                FileInfo objFile = new FileInfo(strFileName);
                if (objFile.Length < 2)
                {
                    //                    clsPubVar4LogicEx.objLog.WriteDebugLog(string.Format("ɾ��0�ֽ��ļ���{0}�ɹ���", objFile.Name));

                    objFile.Delete();
                    continue;
                }
                UserFile objUserFile = new UserFile();
                objUserFile.OrderNum = i++;
                objUserFile.FileName = objFile.Name;
                objUserFile.FileSize = objFile.Length;
                objUserFile.Extension = objFile.Extension;
                objUserFile.LastWriteTime = objFile.LastWriteTime;
                objUserFile.CreationTime = objFile.CreationTime;
                objUserFile.FullDirName = strFolder;

                // objUserFile.ResourceTypeName = strResourceTypeLsts;
                objUserFile.UploadDate = clsDateTime.ChangeDateToDate10(clsDateTime.ChangeDateToDate8(objFile.CreationTime));
                objFileColl.AddByDateDesc(objUserFile);
            }

            return objFileColl;

        }

        /// <summary>
        /// �����ļ�Ŀ¼��ȡ�ļ��б��������ļ������б�ķ�ʽ���أ� �����ڽ���
        /// </summary>
        /// <param name="strFolder">�ļ�Ŀ¼</param>
        /// <param name="objFileColl">�ļ�����</param>
        /// <returns>�����ļ������б�</returns>
        public static void GetFileListByDateDescEx(string strFolder, FileCollection objFileColl)
        {
            //FileCollection objFileColl = new FileCollection();

            string[] strFiles = Directory.GetFiles(strFolder);

            int i = 1;
            foreach (string strFileName in strFiles)
            {
                //bool bolIsAccordofResourceType = false;
                //FileAttributes objFileAttr = File.GetAttributes(strFileName);
                FileInfo objFile = new FileInfo(strFileName);
                if (objFile.Length < 2)
                {
                    //                    clsPubVar4LogicEx.objLog.WriteDebugLog(string.Format("ɾ��0�ֽ��ļ���{0}�ɹ���", objFile.Name));

                    objFile.Delete();
                    continue;
                }
                UserFile objUserFile = new UserFile();
                objUserFile.OrderNum = i++;
                objUserFile.FileName = objFile.Name;
                objUserFile.FileSize = objFile.Length;
                objUserFile.Extension = objFile.Extension;
                objUserFile.LastWriteTime = objFile.LastWriteTime;
                objUserFile.CreationTime = objFile.CreationTime;
                objUserFile.FullDirName = strFolder;

                // objUserFile.ResourceTypeName = strResourceTypeLsts;
                objUserFile.UploadDate = clsDateTime.ChangeDateToDate10(clsDateTime.ChangeDateToDate8(objFile.CreationTime));
                objFileColl.AddByDateDesc(objUserFile);
            }
            string[] strFolders = Directory.GetDirectories(strFolder);
            foreach (string strFolderName in strFolders)
            {
                GetFileListByDateDescEx(strFolderName, objFileColl);
            }
            //return objFileColl;

        }

        /// <summary>
        /// �����ļ�Ŀ¼��ȡ�ļ��б��������ļ������б�ķ�ʽ����
        /// </summary>
        /// <param name="strFolder">�ļ�Ŀ¼</param>
        /// <param name="strCreateDate8">�������ڣ�8λ��</param>
        /// <returns>�����ļ������б�</returns>
        public static FileCollection GetFileList(string strFolder, string strCreateDate8)
        {
            FileCollection objFileColl = new FileCollection();
            string[] strFiles = Directory.GetFiles(strFolder);

            int i = 1;
            foreach (string strFileName in strFiles)
            {
                //bool bolIsAccordofResourceType = false;
                //FileAttributes objFileAttr = File.GetAttributes(strFileName);
                FileInfo objFile = new FileInfo(strFileName);
                string strDate8 = clsDateTime.ChangeDateToDate8(objFile.CreationTime);
                if (strDate8 != strCreateDate8)
                {
                    continue;
                }
                if (objFile.Length < 2)
                {
                    //                    clsPubVar4LogicEx.objLog.WriteDebugLog(string.Format("ɾ��0�ֽ��ļ���{0}�ɹ���", objFile.Name));

                    objFile.Delete();
                    continue;
                }
                UserFile objUserFile = new UserFile();
                objUserFile.OrderNum = i++;
                objUserFile.FileName = objFile.Name;
                objUserFile.FileSize = objFile.Length;
                objUserFile.Extension = objFile.Extension;
                objUserFile.FullDirName = strFolder;           
                objUserFile.LastWriteTime = objFile.LastWriteTime;
                objUserFile.CreationTime = objFile.CreationTime;

                // objUserFile.ResourceTypeName = strResourceTypeLsts;
                objUserFile.UploadDate = clsDateTime.ChangeDateToDate10(clsDateTime.ChangeDateToDate8(objFile.CreationTime));
                objFileColl.Add(objUserFile);
            }

            return objFileColl;

        }
        /// <summary>
        /// ���������ļ���Ϣ��ȡ�ļ�����
        /// </summary>
        /// <param name="strFullFileName">�����ļ���</param>
        /// <returns>�����ļ�����</returns>
        public static UserFile GetUserFileObjByFile(string strFullFileName)
        {
            FileInfo objFile = new FileInfo(strFullFileName);

            UserFile objUserFile = new UserFile();
            objUserFile.OrderNum = 0;
            objUserFile.FileName = objFile.Name;
            objUserFile.FileSize = objFile.Length;
            objUserFile.Extension = objFile.Extension;
            objUserFile.LastWriteTime = objFile.LastWriteTime;
            objUserFile.CreationTime = objFile.CreationTime;

            // objUserFile.ResourceTypeName = strResourceTypeLsts;
            objUserFile.UploadDate = clsDateTime.ChangeDateToDate10(clsDateTime.ChangeDateToDate8(objFile.CreationTime));
            return objUserFile;

        }

/// <summary>
/// �ļ��ڽ���֮���Ƿ��޸Ĺ���
/// </summary>
/// <param name="strFullFileName">�ļ�ȫ��</param>
/// <returns>�����Ƿ��޸ģ�</returns>
        public static bool IsUpdated(string strFullFileName)
        {
            FileInfo objFile = new FileInfo(strFullFileName);
            if (objFile == null)
            {
                string strMsg = string.Format("�ļ������ڣ�{0}", strFullFileName);
                throw new Exception(strMsg);
            }
            TimeSpan ts = objFile.CreationTime.Subtract(objFile.LastWriteTime);

            if (Math.Abs( ts.TotalSeconds) < 1) return false;
            return true;

        }

    }
}
