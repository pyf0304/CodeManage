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

using com.taishsoft.common;
using com.taishsoft.net;

namespace TestPubDataBase
{
    public partial class frmTestFtpUpLoad : System.Windows.Forms.Form
    {
        ArrayList arrFileLst = new ArrayList();
        private clsFTPClient _ftpClient;
        private Button btnTestUpLoad;
        private Button btnOpenFTP;
        private Button button4;
        private Button button3;
        private Button button1;
        private Label label1;
        private string strFTPUrl = "";
        public frmTestFtpUpLoad()
        {
            InitializeComponent();
            _ftpClient = new clsFTPClient();
            strFTPUrl = "ftp://202.121.63.7/";
            arrFileLst.Add("dd1.xls");
            arrFileLst.Add("教育统计子项表.docx");
          

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ss = clsApplicatoin.AppPath();
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


        private void btnOpenFTP_Click(object sender, EventArgs e)
        {
            //string strFTPFile = strFTPUrl + "ChangeColor.txt";
            //string strTargetFile = @"E:\ChangeColor.txt";
            string strTempDir = @"E:\TestAutoUpdate\Temp\";
            _ftpClient.UserName = "pyf";
            _ftpClient.Password = "mm012345";
            try
            {
                foreach (string strFile in arrFileLst)
                {
                    _ftpClient.Download(strTempDir, strFile, strFTPUrl, strFile);
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

     

        private void btnTestGPFileList_Click(object sender, EventArgs e)
        {
            //string strCondition = string.Format("PrjId='0013'");
            //ArrayList arrFileLst = clsvPrjFileRelaWS.GetvPrjFileRelaObjList(strCondition);
            //MessageBox.Show(arrFileLst.Count.ToString());
            //clsvPrjFileRelaEN obj = 
        }

        private void InitializeComponent()
        {
            this.btnTestUpLoad = new System.Windows.Forms.Button();
            this.btnOpenFTP = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTestUpLoad
            // 
            this.btnTestUpLoad.Location = new System.Drawing.Point(247, 59);
            this.btnTestUpLoad.Name = "btnTestUpLoad";
            this.btnTestUpLoad.Size = new System.Drawing.Size(166, 27);
            this.btnTestUpLoad.TabIndex = 22;
            this.btnTestUpLoad.Text = "测试上传";
            this.btnTestUpLoad.UseVisualStyleBackColor = true;
            this.btnTestUpLoad.Click += new System.EventHandler(this.btnTestUpLoad_Click);
            // 
            // btnOpenFTP
            // 
            this.btnOpenFTP.Location = new System.Drawing.Point(73, 59);
            this.btnOpenFTP.Name = "btnOpenFTP";
            this.btnOpenFTP.Size = new System.Drawing.Size(166, 27);
            this.btnOpenFTP.TabIndex = 21;
            this.btnOpenFTP.Text = "打开FTP";
            this.btnOpenFTP.UseVisualStyleBackColor = true;
            this.btnOpenFTP.Click += new System.EventHandler(this.btnOpenFTP_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(489, 26);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 27);
            this.button4.TabIndex = 16;
            this.button4.Text = "获取文件日期";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(247, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(220, 27);
            this.button3.TabIndex = 15;
            this.button3.Text = "获取当前正在执行的应用程序名";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(73, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 27);
            this.button1.TabIndex = 13;
            this.button1.Text = "获取应用程序所在路径";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            // 
            // frmTestFtpUpLoad
            // 
            this.ClientSize = new System.Drawing.Size(708, 420);
            this.Controls.Add(this.btnTestUpLoad);
            this.Controls.Add(this.btnOpenFTP);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "frmTestFtpUpLoad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnTestUpLoad_Click(object sender, EventArgs e)
        {
            clsFTPClient _ftpClient = new clsFTPClient();

            string strUpdateState = "更新：正在下载文件...";
            //string strTempDir = @"E:\TestAutoUpdate\Temp\";            
            string strTempDir = @"D:\AA\";   //clsSysPara.strAppPath + "\\Temp\\";

            //if (Directory.Exists(strTempDir) == false)
            //{
            //    Directory.CreateDirectory(strTempDir);
            //}
            //_ftpClient.UserName = "admin";
            //_ftpClient.Password = "54321";
            _ftpClient.UserName = "pyf";
            _ftpClient.Password = "mm012345";
            //intMin = 1;
            //intMax = arrFileLst.Count;
            //InitUpdateState(intMin, intMax);
            int iIndex = 1;
            try
            {
                string strFile = @"aa1.doc";

                string strFtpFolderName = "/ExecPlan/";
                string strSourceFile = strTempDir + strFile;
           

                _ftpClient.UploadFile(strSourceFile, strFtpFolderName, strFTPUrl);
                MessageBox.Show("上传成功!");
           
                //iIndex++;

                //return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("在上传过程中，有一个错误\r\n" + ex.Message);
                //return false;
            }
        }

   
  

      
    }
}