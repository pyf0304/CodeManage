using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using com.taishsoft.common;

namespace com.taishsoft.file
{
    public partial class clsFile
    {
    
     

        public static bool AppendStringToFile(string strFullFileName, string strFileContent, Encoding myEncoding)
        {
            string strFilePath = clsString.ParentDir_S(strFullFileName);
            if (Directory.Exists(strFilePath) == false)
            {
                Directory.CreateDirectory(strFilePath);
            }
            FileStream fs = new FileStream(strFullFileName, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter objStreamWriter = new StreamWriter(fs, myEncoding);    
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
        public static string GetContentFromTextFile(string strFullFileName, Encoding myEncoding)
        {
            StringBuilder sbFileContent = new StringBuilder();
            string szSrcLine = "";
            System.IO.FileStream fsInput = new FileStream(strFullFileName, FileMode.Open, FileAccess.Read);
            System.IO.StreamReader srInput = new StreamReader(fsInput, myEncoding);
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
        public static string GetContentFromTextFile_Lines(string strFullFileName, int intLine,Encoding myEncoding)
        {
            if (intLine < 0)
            {
                throw new Exception("行数不正确，行数：" + intLine.ToString()
                    + "\r\n 在函数GetContentFromTextFile_Lines in (clsFile)中。");
            }
            StringBuilder sbFileContent = new StringBuilder();
            string szSrcLine = "";
            System.IO.FileStream fsInput = new FileStream(strFullFileName, FileMode.Open, FileAccess.Read);
            System.IO.StreamReader srInput = new StreamReader(fsInput, myEncoding);
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
 
    }
}
