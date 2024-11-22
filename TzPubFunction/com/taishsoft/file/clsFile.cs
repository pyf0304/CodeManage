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
        /// 根据文件内容来建立一个文件
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
            //写文件流;
            //string strFileName2 = clsSysPara_PubDataBase.TempFileFolder + objFileTab.FtpFileName;
            //建立WebForm文本文件;
            //把生成代码写到文件中去;
            objStreamWriter.Write(strFileContent);
            //关闭文件;
            objStreamWriter.Flush();
            objStreamWriter.Close();
            fs.Close();
            return true;
        }

        /// <summary>
        /// 根据文件内容来建立一个文件
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
            //写文件流;
            //string strFileName2 = clsSysPara_PubDataBase.TempFileFolder + objFileTab.FtpFileName;
            //建立WebForm文本文件;
            //把生成代码写到文件中去;
            objStreamWriter.Write(strFileContent);
            //关闭文件;
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
            //写文件流;
            //把生成代码写到文件中去;
            objStreamWriter.BaseStream.Seek(0, SeekOrigin.End);
            objStreamWriter.WriteLine(strFileContent + "\r\n");
            //关闭文件;
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
        /// 获取文本文件的前几行文本
        /// </summary>
        /// <param name="strFullFileName">文件标识符</param>
        /// <param name="intLine">前N行</param>
        /// <returns>读取的文本</returns>
        public static string GetContentFromTextFile_Lines(string strFullFileName, int intLine)
        {
            if (intLine < 0)
            {
                throw new Exception("行数不正确，行数：" + intLine.ToString()
                    + "\r\n 在函数GetContentFromTextFile_Lines in (clsFile)中。");
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
        /// 获取文本文件的前几行文本
        /// </summary>
        /// <param name="strFullFileName">文件标识符</param>
        /// <param name="objTextRange">文本范围</param>
        /// <returns>读取的文本</returns>
        public static string GetContentFromTextFileByRange(string strFullFileName, stuTextRange objTextRange)
        {
            string strMsg = "";
            if (objTextRange.StartPos.Line <= 0 )
            {
                throw new Exception("开始行数不正确，行数：" + objTextRange.StartPos.Line.ToString()
                    + "\r\n GetContentFromTextFileByRange in (clsFile)中。");
            }
            if (objTextRange.EndPos.Line <= 0)
            {
                throw new Exception("结束行数不正确，行数：" + objTextRange.EndPos.Line.ToString()
                    + "\r\n GetContentFromTextFileByRange in (clsFile)中。");
            }
            if (objTextRange.StartPos.Col <= 0)
            {
                throw new Exception("开始列数不正确，列数：" + objTextRange.StartPos.Col.ToString()
                    + "\r\n GetContentFromTextFileByRange in (clsFile)中。");
            }
            if (objTextRange.EndPos.Col <= 0)
            {
                throw new Exception("结束列数不正确，列数：" + objTextRange.EndPos.Col.ToString()
                    + "\r\n GetContentFromTextFileByRange in (clsFile)中。");
            }
            if (objTextRange.EndPos.Line < objTextRange.StartPos.Line)
            {
                strMsg = string.Format("结束行数不能大于开始行数，不正确，开始行数:{0}, 结束行:{1}. (In {2})",
                    objTextRange.StartPos.Line, objTextRange.EndPos.Line, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            if (objTextRange.EndPos.Line == objTextRange.StartPos.Line && objTextRange.EndPos.Col < objTextRange.StartPos.Col)
            {
                strMsg = string.Format("开始结束行数一样，但开始列不能大于开始列，不正确！行:{0}, 开始列:{1}, 结束行:{2}. (In {3})",
                    objTextRange.StartPos.Line, objTextRange.StartPos.Col, objTextRange.EndPos.Col, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            List<string> arrLine = clsFile.GetContentLinesFromTextFile(strFullFileName);
            if (arrLine.Count == 0)
            {
                strMsg = string.Format("文件的内容为空，不正确！文件名:{0}. (In {1})",
                    strFullFileName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            if (arrLine.Count < objTextRange.EndPos.Line)
            {
                strMsg = string.Format("结束行数不能大于文件总行数，不正确，结束行数:{0}, 文本总行数:{1}. (In {2})",
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
        /// 从一个目录中去查询一个文件，并返回这个文件的所在目录
        /// </summary>
        /// <param name="strFileName">需要查找的文件名</param>
        /// <param name="strFilePath">查找的目录</param>
        /// <returns>返回所找到的文件目录名，如果找不到就返回空串。</returns>
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
        /// 从一个目录中去查询一个文件，并返回这个文件的所在目录
        /// </summary>
        /// <param name="strFileName">需要查找的文件名</param>
        /// <param name="objDirInfo">查找的目录（DirectoryInfo objDirInfo）</param>
        /// <returns>返回所找到的文件目录名，如果找不到就返回空串。</returns>
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
        /// 从一个目录中去查询一个文件，并返回这个文件的所在目录
        /// </summary>
        /// <param name="strSimpleFileName">需要查找的文件名</param>
        /// <param name="strFolder">查找的目录</param>
        /// <returns>返回所找到的文件目录名，如果找不到就返回空串。</returns>
        public static string FindFileFromFolder(string strFolder, string strSimpleFileName)
        {
            if (System.IO.Directory.Exists(strFolder) == false)
            {
                string strMsg = string.Format("目录：{0}不存在！请检查！", strFolder);
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
        /// 从一个目录中去查找一个文件名，并返回这个文件名的所有文件目录列表(含目录)
        /// </summary>
        /// <param name="strSimpleFileName">需要查找的文件名</param>
        /// <param name="strFolder">查找的目录</param>
        /// <returns>返回所找到的文件目录列表，如果找不到就返回空串。</returns>
        public static List<string> FindFileLstFromFolder(string strFolder, string strSimpleFileName)
        {
            if (System.IO.Directory.Exists(strFolder) == false)
            {
                string strMsg = string.Format("目录：{0}不存在！请检查！", strFolder);
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
        /// 从一个目录中去查询一个文件，并返回这个文件的所在目录
        /// </summary>
        /// <param name="strSimpleFileName">需要查找的文件名</param>
        /// <param name="objDirectoryP">查找的目录（DirectoryInfo objDirInfo）</param>
        /// <returns>返回所找到的文件目录名，如果找不到就返回空串。</returns>
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
        /// 文件备份
        /// </summary>
        /// <param name="fName">原文件</param>
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
        /// 文件备份
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
                throw new Exception("备份目录不能为空！");
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
        /// 获取当前目录的父目录
        /// </summary>
        /// <param name="strPath">给定的目录</param>
        /// <returns>返回父目录</returns>
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
        /// 获取当前目录的父目录
        /// </summary>
        /// <param name="strPath">给定的目录</param>
        /// <returns>返回父目录</returns>
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
        /// 获取当前目录的父目录
        /// </summary>
        /// <param name="strPath">给定的目录</param>
        /// <returns>返回父目录</returns>
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
        /// 添加扩展名
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
        /// 从带有目录的文件名中获取简单的文件名
        /// </summary>
        /// <param name="strFileName">带有目录的文件名</param>
        /// <returns>不带目录的简单的文件名</returns>
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
        /// 从带有目录的文件名中获取简单的文件名
        /// </summary>
        /// <param name="strFileName">带有目录的文件名</param>
        /// <returns>不带目录的简单的文件名</returns>
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
        /// 从带有目录的文件名中获取路径名
        /// </summary>
        /// <param name="strFullFileName">带有目录的文件名</param>
        /// <returns>文件的路径名</returns>
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
        /// 从多级目录中获取最后一层目录名
        /// </summary>
        /// <param name="strFilePath">带有目录的文件名</param>
        /// <returns>不带目录的简单的文件名</returns>
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
        /// 根据文件名，获取该文件的扩展名
        /// </summary>
        /// <param name="strFileName">给定的文件名</param>
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
        /// 根据文件名，获取该文件的去除扩展名的纯粹文件名
        /// </summary>
        /// <param name="strFileName">给定的文件名</param>
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
        /// 根据文件目录获取文件列表，并且以文件对象列表的方式返回
        /// </summary>
        /// <param name="strFolder">文件目录</param>
        /// <returns>返回文件对象列表</returns>
        public static FileCollection GetFileList(string strFolder)
        {
            FileCollection objFileColl = new FileCollection();
            if (Directory.Exists(strFolder) == false)
            {
                string strMsg = string.Format("路径：{0}不存在！请检查！（或者与管理员联系！）", strFolder);
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
//                    clsPubVar4LogicEx.objLog.WriteDebugLog(string.Format("删除0字节文件：{0}成功！", objFile.Name));

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
        /// 根据文件目录获取文件列表，并且以文件对象列表的方式返回, 包括下面的子目录
        /// </summary>
        /// <param name="strFolder">文件目录</param>
        /// <param name="objFileColl">文件集合</param>
        /// <returns>返回文件对象列表</returns>
        public static void GetFileListEx(string strFolder, FileCollection objFileColl)
        {
            //FileCollection objFileColl = new FileCollection();
            if (Directory.Exists(strFolder) == false)
            {
                string strMsg = string.Format("路径：{0}不存在！请检查！（或者与管理员联系！）", strFolder);
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
                    //                    clsPubVar4LogicEx.objLog.WriteDebugLog(string.Format("删除0字节文件：{0}成功！", objFile.Name));

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
        /// 根据文件目录获取下属文件夹列表，并且以文件对象列表的方式返回
        /// </summary>
        /// <param name="strFolder">文件目录</param>
        /// <returns>返回文件对象列表</returns>
        public static FileCollection GetFolderList(string strFolder)
        {
            FileCollection objDirectoryColl = new FileCollection();
            if (Directory.Exists(strFolder) == false)
            {
                string strMsg = string.Format("路径：{0}不存在！请检查！（或者与管理员联系！）", strFolder);
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
                    //                    clsPubVar4LogicEx.objLog.WriteDebugLog(string.Format("删除0字节文件：{0}成功！", objDirectory.Name));

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
        /// 差别在所给文件目录下是否存在所给文件名，并且在所给文件目录的所有子目录进行查找
        /// </summary>
        /// <param name="strFolder">文件目录</param>
        /// <param name="strFileName">文件名,不带目录</param>
        /// <returns>返回文件是否存在，存在返回True, 否则返回False</returns>
        public static bool IsExists(string strFolder, string strFileName)
        {
          
            FileCollection objDirectoryColl = new FileCollection();
            if (Directory.Exists(strFolder) == false)
            {
                string strMsg = string.Format("路径：{0}不存在！请检查！（或者与管理员联系！）", strFolder);
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
        /// 在所给父目录中获取某文件的路径，并且以文件完整路径方式返回
        /// </summary>
        /// <param name="strParentFolder">文件目录</param>
        /// <param name="strFileName">文件名,不带目录</param>
        /// <returns>如果找到某文件，返回该文件的完整路径，否则返回空串</returns>
        public static string GetFilePath(string strParentFolder, string strFileName)
        {

            FileCollection objDirectoryColl = new FileCollection();
            if (Directory.Exists(strParentFolder) == false)
            {
                string strMsg = string.Format("路径：{0}不存在！请检查！（或者与管理员联系！）", strParentFolder);
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
        /// 在所给父目录中获取某文件的同源文件列表，并且以文件列表返回
        /// </summary>
        /// <param name="strParentFolder">文件目录</param>
        /// <param name="strFileName">文件名,不带目录</param>
        /// <returns>如果找到某文件，返回该文件的完整路径，否则返回空串</returns>
        public static List<string> GetSameSourceFileLst(string strParentFolder, string strFileName)
        {

            FileCollection objDirectoryColl = new FileCollection();
            if (Directory.Exists(strParentFolder) == false)
            {
                string strMsg = string.Format("路径：{0}不存在！请检查！（或者与管理员联系！）", strParentFolder);
                throw new Exception(strMsg);
            }
            string strFullFileName = string.Format("{0}\\{1}", strParentFolder, strFileName);
            if (File.Exists(strFullFileName) == false)
            {
                string strMsg = string.Format("文件：{0}不存在！请检查！（或者与管理员联系！）",
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
        /// 根据文件目录获取文件列表，并且以文件对象列表的方式返回， 按日期降序
        /// </summary>
        /// <param name="strFolder">文件目录</param>
        /// <returns>返回文件对象列表</returns>
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
                    //                    clsPubVar4LogicEx.objLog.WriteDebugLog(string.Format("删除0字节文件：{0}成功！", objFile.Name));

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
        /// 根据文件目录获取文件列表，并且以文件对象列表的方式返回， 按日期降序
        /// </summary>
        /// <param name="strFolder">文件目录</param>
        /// <param name="objFileColl">文件集合</param>
        /// <returns>返回文件对象列表</returns>
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
                    //                    clsPubVar4LogicEx.objLog.WriteDebugLog(string.Format("删除0字节文件：{0}成功！", objFile.Name));

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
        /// 根据文件目录获取文件列表，并且以文件对象列表的方式返回
        /// </summary>
        /// <param name="strFolder">文件目录</param>
        /// <param name="strCreateDate8">建立日期（8位）</param>
        /// <returns>返回文件对象列表</returns>
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
                    //                    clsPubVar4LogicEx.objLog.WriteDebugLog(string.Format("删除0字节文件：{0}成功！", objFile.Name));

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
        /// 根据物理文件信息获取文件对象
        /// </summary>
        /// <param name="strFullFileName">物理文件名</param>
        /// <returns>返回文件对象</returns>
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
/// 文件在建立之后是否修改过？
/// </summary>
/// <param name="strFullFileName">文件全名</param>
/// <returns>返回是否修改？</returns>
        public static bool IsUpdated(string strFullFileName)
        {
            FileInfo objFile = new FileInfo(strFullFileName);
            if (objFile == null)
            {
                string strMsg = string.Format("文件不存在！{0}", strFullFileName);
                throw new Exception(strMsg);
            }
            TimeSpan ts = objFile.CreationTime.Subtract(objFile.LastWriteTime);

            if (Math.Abs( ts.TotalSeconds) < 1) return false;
            return true;

        }

    }
}
