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
        /// ��ȡ�ı��ļ���ǰ�����ı�
        /// </summary>
        /// <param name="strFullFileName">�ļ���ʶ��</param>
        /// <param name="intLine">ǰN��</param>
        /// <returns>��ȡ���ı�</returns>
        public static string GetContentFromTextFile_Lines(string strFullFileName, int intLine,Encoding myEncoding)
        {
            if (intLine < 0)
            {
                throw new Exception("��������ȷ��������" + intLine.ToString()
                    + "\r\n �ں���GetContentFromTextFile_Lines in (clsFile)�С�");
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
