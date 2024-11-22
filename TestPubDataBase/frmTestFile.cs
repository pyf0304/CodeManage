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
using com.taishsoft.file;

namespace TestPubDataBase
{
    public partial class frmTestFile : System.Windows.Forms.Form
    {
        ArrayList arrFileLst = new ArrayList();
        private clsFTPClient _ftpClient;
        private Label label1;
        private Button btnGetFileListEx;
        private DataGridView dataGridView1;
        private Button btnGetFileListDateDescEx;
        private Button btnIsExistInDir;
        private Button btnGetFileDir;
        private Button btnGetSameSourceFileLst;
        private Button btnFindFileLstFromFolder;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnIsUpdated;
        private Button btnGetTextContentByRange;
        private TextBox txtResult;
        private FlowLayoutPanel flowLayoutPanel2;
        private string strFTPUrl = "";
        public frmTestFile()
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetFileListEx = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGetFileListDateDescEx = new System.Windows.Forms.Button();
            this.btnIsExistInDir = new System.Windows.Forms.Button();
            this.btnGetFileDir = new System.Windows.Forms.Button();
            this.btnGetSameSourceFileLst = new System.Windows.Forms.Button();
            this.btnFindFileLstFromFolder = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnIsUpdated = new System.Windows.Forms.Button();
            this.btnGetTextContentByRange = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            // 
            // btnGetFileListEx
            // 
            this.btnGetFileListEx.Location = new System.Drawing.Point(3, 3);
            this.btnGetFileListEx.Name = "btnGetFileListEx";
            this.btnGetFileListEx.Size = new System.Drawing.Size(166, 27);
            this.btnGetFileListEx.TabIndex = 23;
            this.btnGetFileListEx.Text = "获取文件列表Ex";
            this.btnGetFileListEx.UseVisualStyleBackColor = true;
            this.btnGetFileListEx.Click += new System.EventHandler(this.btnGetFileListEx_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(955, 426);
            this.dataGridView1.TabIndex = 24;
            // 
            // btnGetFileListDateDescEx
            // 
            this.btnGetFileListDateDescEx.Location = new System.Drawing.Point(175, 3);
            this.btnGetFileListDateDescEx.Name = "btnGetFileListDateDescEx";
            this.btnGetFileListDateDescEx.Size = new System.Drawing.Size(166, 27);
            this.btnGetFileListDateDescEx.TabIndex = 25;
            this.btnGetFileListDateDescEx.Text = "获取文件列表日期降序Ex";
            this.btnGetFileListDateDescEx.UseVisualStyleBackColor = true;
            this.btnGetFileListDateDescEx.Click += new System.EventHandler(this.btnGetFileListDateDescEx_Click);
            // 
            // btnIsExistInDir
            // 
            this.btnIsExistInDir.Location = new System.Drawing.Point(394, 3);
            this.btnIsExistInDir.Name = "btnIsExistInDir";
            this.btnIsExistInDir.Size = new System.Drawing.Size(132, 27);
            this.btnIsExistInDir.TabIndex = 26;
            this.btnIsExistInDir.Text = "判别文件是否存在";
            this.btnIsExistInDir.UseVisualStyleBackColor = true;
            this.btnIsExistInDir.Click += new System.EventHandler(this.btnIsExistInDir_Click);
            // 
            // btnGetFileDir
            // 
            this.btnGetFileDir.Location = new System.Drawing.Point(532, 3);
            this.btnGetFileDir.Name = "btnGetFileDir";
            this.btnGetFileDir.Size = new System.Drawing.Size(132, 27);
            this.btnGetFileDir.TabIndex = 27;
            this.btnGetFileDir.Text = "获取文件的路径";
            this.btnGetFileDir.UseVisualStyleBackColor = true;
            this.btnGetFileDir.Click += new System.EventHandler(this.btnGetFileDir_Click);
            // 
            // btnGetSameSourceFileLst
            // 
            this.btnGetSameSourceFileLst.Location = new System.Drawing.Point(670, 3);
            this.btnGetSameSourceFileLst.Name = "btnGetSameSourceFileLst";
            this.btnGetSameSourceFileLst.Size = new System.Drawing.Size(132, 27);
            this.btnGetSameSourceFileLst.TabIndex = 28;
            this.btnGetSameSourceFileLst.Text = "获取同源文件列表";
            this.btnGetSameSourceFileLst.UseVisualStyleBackColor = true;
            this.btnGetSameSourceFileLst.Click += new System.EventHandler(this.btnGetSameSourceFileLst_Click);
            // 
            // btnFindFileLstFromFolder
            // 
            this.btnFindFileLstFromFolder.Location = new System.Drawing.Point(808, 3);
            this.btnFindFileLstFromFolder.Name = "btnFindFileLstFromFolder";
            this.btnFindFileLstFromFolder.Size = new System.Drawing.Size(153, 27);
            this.btnFindFileLstFromFolder.TabIndex = 29;
            this.btnFindFileLstFromFolder.Text = "获取文件名的目录列表";
            this.btnFindFileLstFromFolder.UseVisualStyleBackColor = true;
            this.btnFindFileLstFromFolder.Click += new System.EventHandler(this.btnFindFileLstFromFolder_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnGetFileListEx);
            this.flowLayoutPanel1.Controls.Add(this.btnGetFileListDateDescEx);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.btnIsExistInDir);
            this.flowLayoutPanel1.Controls.Add(this.btnGetFileDir);
            this.flowLayoutPanel1.Controls.Add(this.btnGetSameSourceFileLst);
            this.flowLayoutPanel1.Controls.Add(this.btnFindFileLstFromFolder);
            this.flowLayoutPanel1.Controls.Add(this.btnIsUpdated);
            this.flowLayoutPanel1.Controls.Add(this.btnGetTextContentByRange);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(985, 69);
            this.flowLayoutPanel1.TabIndex = 30;
            // 
            // btnIsUpdated
            // 
            this.btnIsUpdated.Location = new System.Drawing.Point(3, 36);
            this.btnIsUpdated.Name = "btnIsUpdated";
            this.btnIsUpdated.Size = new System.Drawing.Size(132, 27);
            this.btnIsUpdated.TabIndex = 30;
            this.btnIsUpdated.Text = "获取文件是否修改";
            this.btnIsUpdated.UseVisualStyleBackColor = true;
            this.btnIsUpdated.Click += new System.EventHandler(this.btnIsUpdated_Click);
            // 
            // btnGetTextContentByRange
            // 
            this.btnGetTextContentByRange.Location = new System.Drawing.Point(141, 36);
            this.btnGetTextContentByRange.Name = "btnGetTextContentByRange";
            this.btnGetTextContentByRange.Size = new System.Drawing.Size(186, 27);
            this.btnGetTextContentByRange.TabIndex = 31;
            this.btnGetTextContentByRange.Text = "根据位置范围获取文本内容";
            this.btnGetTextContentByRange.UseVisualStyleBackColor = true;
            this.btnGetTextContentByRange.Click += new System.EventHandler(this.btnGetTextContentByRange_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(3, 435);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(966, 346);
            this.txtResult.TabIndex = 31;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.dataGridView1);
            this.flowLayoutPanel2.Controls.Add(this.txtResult);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(15, 87);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(982, 509);
            this.flowLayoutPanel2.TabIndex = 32;
            // 
            // frmTestFile
            // 
            this.ClientSize = new System.Drawing.Size(1009, 602);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "frmTestFile";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

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

        private void btnGetFileListEx_Click(object sender, EventArgs e)
        {
            FileCollection objFileColl = new FileCollection();
            string strFolder = @"E:\AspNet2011\TZ_UploadBigFileByWS\TZ_UploadBigFileByWSWeb\UploadTemp";
            clsFile.GetFileListEx(strFolder, objFileColl);
            List<UserFile> arrUserFile = objFileColl.FileLst;
            dataGridView1.DataSource = arrUserFile;
            //dataGridView1.BindData();
        }

        private void btnGetFileListDateDescEx_Click(object sender, EventArgs e)
        {
            FileCollection objFileColl = new FileCollection();
            string strFolder = @"E:\AspNet2011\TZ_UploadBigFileByWS\TZ_UploadBigFileByWSWeb\UploadTemp";
            clsFile.GetFileListByDateDescEx(strFolder, objFileColl);
            List<UserFile> arrUserFile = objFileColl.FileLst;
            dataGridView1.DataSource = arrUserFile;
        }

        private void btnIsExistInDir_Click(object sender, EventArgs e)
        {
          
            string strFolder = @"E:\AspNet2011\EduHigh";
            string strFile = "Global1.asax.cs";
            if (clsFile.IsExists(strFolder, strFile) == true)
            {
                MessageBox.Show("存在！");
            }
            else
            {
                MessageBox.Show("不存在！");
            }
        }

        private void btnGetFileDir_Click(object sender, EventArgs e)
        {
            string strFolder = @"E:\AspNet2011\EduHigh";
            string strFile = "Global.asax.cs";
            string strFullFileName = clsFile.GetFilePath(strFolder, strFile);
            string strMsg = string.Format("文件完整路径为:[{0}]", strFullFileName);
            MessageBox.Show(strMsg);

        }

        private void btnGetSameSourceFileLst_Click(object sender, EventArgs e)
        {
            string strParentFolder = @"E:\AspNet2011\EduHigh\EduHighWeb\Upload\";
            string strFile = "aa1_20171124191020.PNG";
           List< string> arrFileNameLst = clsFile.GetSameSourceFileLst(strParentFolder, strFile);

            //FileCollection objFileColl = new FileCollection();
            List<UserFile> arrUserFile = new List<UserFile>();

            foreach (string strFileName_In in arrFileNameLst)
            {
                string strFullFileName = string.Format("{0}\\{1}", strParentFolder, strFileName_In);

                UserFile objUF = new UserFile(strFullFileName);
                arrUserFile.Add(objUF);
            }
          
            dataGridView1.DataSource = arrUserFile;

          
        }

        private void btnFindFileLstFromFolder_Click(object sender, EventArgs e)
        {
            string strParentFolder = @"E:\AspNet2011\EduHigh\";
            string strFile = "clsPubClassCaseQuantitySenateDAEx.cs";
            List<string> arrFileLst = clsFile.FindFileLstFromFolder(strParentFolder, strFile);

            //FileCollection objFileColl = new FileCollection();
            List<UserFile> arrUserFile = new List<UserFile>();

            foreach (string strFileName_In in arrFileLst)
            {
                string strFullFileName = string.Format("{1}", strParentFolder, strFileName_In);

                UserFile objUF = new UserFile(strFullFileName);
                arrUserFile.Add(objUF);
            }

            dataGridView1.DataSource = arrUserFile;
        }

        private void btnIsUpdated_Click(object sender, EventArgs e)
        {
            string strFile = @"E:\pyfTest\clsCollegeENEx.cs";
          bool bolIsUpdated = clsFile.IsUpdated(strFile);
            string ss = "";
        }

        private void btnGetTextContentByRange_Click(object sender, EventArgs e)
        {
            string strFileName = @"E:\AspNetTest\csparser\sourceCode\csparser\Test program\bin\Debug\Class1.cs";
            //stuTextRange objTextRange = new stuTextRange(new stuTextPos(10, 9), new stuTextPos(15, 10));
            //stuTextRange objTextRange = new stuTextRange(new stuTextPos(16, 9), new stuTextPos(31, 10));
            stuTextRange objTextRange = new stuTextRange(new stuTextPos(32, 9), new stuTextPos(32, 39));

            string strTextContent = clsFile.GetContentFromTextFileByRange(strFileName, objTextRange);
            txtResult.Text = strTextContent;
            dataGridView1.Visible = false;
            string ss = "";
        }
    }
}