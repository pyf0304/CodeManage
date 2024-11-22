using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Diagnostics;
using System.Net;
using System.Text;
using System.Windows.Forms;
using GeneralPlatform4WS;
using GeneralPlatform4WS.ServiceReferencevPrjFileRela;
using com.taishsoft.net;
using com.taishsoft.common;
namespace AutoUpdate
{
    public partial class frmTestUpLoad : System.Windows.Forms.Form
    {
        ArrayList arrFileLst = new ArrayList();
        private clsFTPClient _ftpClient;
        private string strFTPUrl = "";
        public frmTestUpLoad()
        {
            InitializeComponent();
            _ftpClient = new clsFTPClient();
            strFTPUrl = "ftp://59.78.151.122/AppPath/";
            arrFileLst.Add("clsGetExcelFromDataTable.dll");
            arrFileLst.Add("CommFunc4Win.dll");
            arrFileLst.Add("Interop.Excel.dll");
            arrFileLst.Add("Interop.VBIDE.dll");
            arrFileLst.Add("MyTest2_Logic.dll");
            arrFileLst.Add("MyTest2_LogicEx.dll");
            arrFileLst.Add("PubDataBase.dll");
            arrFileLst.Add("SampleWinApp2005.exe");
            arrFileLst.Add("SampleWinApp2005.exe.config");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ss = clsApplicatoin.AppPath();
            label1.Text = ss;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ss = "";
            Form frm1 = null;
            foreach (Form frm in Application.OpenForms)
            {
                ss += frm.Name + "; ";
                if (frm.Name.Substring(0, 3) == "frm")
                {
                    frm1 = frm;
                }
            }
            if (frm1 != null)
            {
                frm1.Close();
            }
            label1.Text = ss;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ss = Application.ExecutablePath;
            label1.Text = ss;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string ss = Application.ExecutablePath;
            string ss1 = File.GetLastWriteTime(ss).ToString();
            label1.Text = ss1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //获取当前执行程序所在目录
            string strExecutablePath = Application.ExecutablePath;
            //建立临时子目录
            string strTempDir = clsApplicatoin.AppPath() + "/Temp/";
            if (Directory.Exists(strTempDir) == false)
            {
                Directory.CreateDirectory(strTempDir);
            }
            ArrayList arrFileLst = new ArrayList();
            foreach (string strFile in arrFileLst)
            {
                string strS_FileFName = clsApplicatoin.AppPath() + "/" + strFile;
                string strT_FileFName = strTempDir + strFile;
                File.Copy(strS_FileFName, strT_FileFName);

            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string strMainExeFile = "SampleWinApp2005.exe";
            string strTempDir = clsApplicatoin.AppPath() + "\\Temp\\";
            string strS_FileFName = strTempDir + "/" + strMainExeFile;
            string strT_FileFName = clsApplicatoin.AppPath() + "\\Update1.Exe";
            if (File.Exists(strT_FileFName) == true)
            {
                File.Delete(strT_FileFName);
            }
            File.Copy(strS_FileFName, strT_FileFName);
            Process.Start(strT_FileFName);
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            /// 复制源应用文件到临时目录
            CopyFilesFromSourceToTempDir();
            CopyExeMainFilesFromTemp();
        }
        /// <summary>
        /// 复制源应用文件到临时目录
        /// </summary>
        private void CopyFilesFromSourceToTempDir()
        {
            string strTempDir = clsApplicatoin.AppPath() + "\\Temp\\";
            string strSourceDir = @"E:\WinApp2005\SampleWinApp2005\SampleWinApp2005\bin\Debug";
            if (Directory.Exists(strTempDir) == false)
            {
                Directory.CreateDirectory(strTempDir);
            }
            foreach (string strFile in arrFileLst)
            {
                string strS_FileFName = strSourceDir + "/" + strFile;
                string strT_FileFName = strTempDir + strFile;
                if (File.Exists(strT_FileFName) == true)
                {
                    File.Delete(strT_FileFName);
                }
                File.Copy(strS_FileFName, strT_FileFName);
            }

        }
        /// <summary>
        /// 从临时目录复制主执行文件
        /// </summary>
        private void CopyExeMainFilesFromTemp()
        {
            string strMainExeFile = "SampleWinApp2005.exe";
            string strTempDir = clsApplicatoin.AppPath() + "\\Temp\\";
            string strS_FileFName = strTempDir + "/" + strMainExeFile;
            string strT_FileFName = clsApplicatoin.AppPath() + "\\Update1.Exe";
            if (File.Exists(strT_FileFName) == true)
            {
                File.Delete(strT_FileFName);
            }
            File.Copy(strS_FileFName, strT_FileFName);
            Process.Start(strT_FileFName);
            Application.Exit();
        }

        private void btnOpenFTP_Click(object sender, EventArgs e)
        {
            //string strFTPFile = strFTPUrl + "ChangeColor.txt";
            //string strTargetFile = @"E:\ChangeColor.txt";
            string strTempDir = @"E:\TestAutoUpdate\Temp\";
            _ftpClient.UserName = "admin";
            _ftpClient.Password = "54321";
            try
            {
                foreach (string strFile in arrFileLst)
                {

                    string strFTPFile = strFTPUrl + strFile;
                    string strTargetFile = strTempDir + strFile;
                    _ftpClient.Download(strTempDir, strFile ,strFTPFile, strFTPUrl);
                    label1.Text = "FTP下载文件完成!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error in the download\r\n" + ex.Message, "FTP Sample", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ShowFTPResult(FtpStatusCode statusCode)
        {
            MessageBox.Show("The FTP Server returned the following status: " + statusCode.ToString(), "Simple FTP Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTestUpLoad_Click(object sender, EventArgs e)
        {
            clsFTPClient _ftpClient = new clsFTPClient();

            string strUpdateState = "更新：正在下载文件...";
            //string strTempDir = @"E:\TestAutoUpdate\Temp\";            
            string strTempDir = @"C:\";   //clsSysPara.strAppPath + "\\Temp\\";

            //if (Directory.Exists(strTempDir) == false)
            //{
            //    Directory.CreateDirectory(strTempDir);
            //}
            //_ftpClient.UserName = "admin";
            //_ftpClient.Password = "54321";
            _ftpClient.UserName = "edu";
            _ftpClient.Password = "edu";
            //intMin = 1;
            //intMax = arrFileLst.Count;
            //InitUpdateState(intMin, intMax);
            int iIndex = 1;
            try
            {
                string strFile = @"Sy2.doc";

                //strAutoUpdateFileState = "正在下载：" + strFile + "                                    ";
                //setUpdateState(iIndex, intMax);
                string strFTPFile = strFTPUrl + strFile;
                string strSourceFile = strTempDir + strFile;
                //this.strEvent = "文件下载";
                //this.strFileName = strTargetFile;

                _ftpClient.UploadFile(strSourceFile, strFTPFile, strFTPUrl);
                //iIndex++;
                
                //return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("在上传过程中，有一个错误\r\n" + ex.Message);
                //return false;
            }

        }

        private void btnTestGPFileList_Click(object sender, EventArgs e)
        {
            string strCondition = string.Format("PrjId='0013'");
            ArrayList arrFileLst = clsvPrjFileRelaWS.GetvPrjFileRelaObjList(strCondition);
            MessageBox.Show(arrFileLst.Count.ToString());
            //clsvPrjFileRelaEN obj = 
        }

    }
}