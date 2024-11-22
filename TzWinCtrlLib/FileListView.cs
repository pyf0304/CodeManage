using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;
using TzWinCtrlLib.Properties;

namespace TzWinCtrlLib
{
    public partial class FileListView : UserControl
    {

        private bool bolIsLoadResource = false;//�Ƿ�����Դ

        public FileListView()
        {
            InitializeComponent();
        }
        public void BindLv_DirFileList(string strDir)
        {
            ListViewItem lviFile;

            if (bolIsLoadResource == false)
            {
                setImageList();
            }
            if (strDir == "�ҵĵ���")
            {
                string[] drivers = null;
                drivers = System.IO.Directory.GetLogicalDrives();

                this.listView1.Items.Clear();//���ԭ������Item
                this.listView1.Columns.Clear();//���ԭ��������ͷ��Ϣ
                this.listView1.Columns.Add("����", 100, HorizontalAlignment.Left);
                this.listView1.Columns.Add("����", 100, HorizontalAlignment.Left);
                this.listView1.Columns.Add("�ܴ�С", 100, HorizontalAlignment.Left);
                this.listView1.Columns.Add("���ÿռ�", 100, HorizontalAlignment.Left);
                this.listView1.Columns.Add("��ע", 100, HorizontalAlignment.Left);
                this.listView1.View = View.Details;

                foreach (string strDirveName in drivers)
                {

                    DriveInfo diDriveInfo = new DriveInfo(strDirveName);
                    if (diDriveInfo.IsReady)
                    {
                        lviFile = new ListViewItem();
                        lviFile.Tag = "0" + diDriveInfo.Name;
                        lviFile.Text = diDriveInfo.Name;
                        lviFile.SubItems.Add(diDriveInfo.DriveType.ToString());
                        lviFile.SubItems.Add(diDriveInfo.TotalSize.ToString());
                        lviFile.SubItems.Add(diDriveInfo.TotalFreeSpace.ToString());
                        lviFile.SubItems.Add(diDriveInfo.VolumeLabel.ToString());
                        lviFile.ImageIndex = 0;
                        this.listView1.Items.Add(lviFile);
                    }
                }
                return;
            }
            if (strDir.Substring(1, 1) == ":" && strDir.Length == 3)
            {
                DriveInfo diDriveInfo = new DriveInfo(strDir);
                if (diDriveInfo.IsReady == false)
                {
                    this.listView1.Items.Clear();//���ԭ������Item
                    this.listView1.Columns.Clear();//���ԭ��������ͷ��Ϣ

                    return;
                }
            }
            //TreeNode tnSel = treeView1.SelectedNode;
            //if (tnSel == null) return;
            //if (tnSel.Tag == null || tnSel.Tag.ToString().Length <= 1) return;
            //string strDir = tnSel.Tag.ToString().Substring(1);
            FileInfo[] fiFiles = (new DirectoryInfo(strDir)).GetFiles();
            DirectoryInfo[] diDirs = (new DirectoryInfo(strDir)).GetDirectories();
            ///	3������ListView����ͷ��Ϣ
            this.listView1.Items.Clear();//���ԭ������Item
            this.listView1.Columns.Clear();//���ԭ��������ͷ��Ϣ
            this.listView1.Columns.Add("�ļ���", 100, HorizontalAlignment.Left);
            this.listView1.Columns.Add("��չ��", 100, HorizontalAlignment.Left);
            this.listView1.Columns.Add("�ļ���С", 100, HorizontalAlignment.Left);
            this.listView1.Columns.Add("�޸�����", 100, HorizontalAlignment.Left);
            this.listView1.View = View.Details;
            foreach (DirectoryInfo di in diDirs)
            {
                lviFile = new ListViewItem();
                lviFile.Tag = "0"+ di.FullName;
                lviFile.Text = di.Name;
                lviFile.SubItems.Add(di.Extension);
                lviFile.SubItems.Add("");
                lviFile.SubItems.Add(di.LastWriteTime.ToShortDateString());
                lviFile.ImageIndex = 0;
                this.listView1.Items.Add(lviFile);
            }

            foreach (FileInfo fi in fiFiles)
            {
                lviFile = new ListViewItem();
                lviFile.Tag = "1" + fi.FullName;
                lviFile.Text = fi.Name;
                lviFile.SubItems.Add(fi.Extension);
                lviFile.SubItems.Add(fi.Length.ToString());
                lviFile.SubItems.Add(fi.LastWriteTime.ToShortDateString());
                if (fi.Extension.ToLower() == ".doc")
                {
                    lviFile.ImageIndex = 2;
                }
                else if (fi.Extension.ToLower() == ".dot")
                {
                    lviFile.ImageIndex = 4;
                }
                else if (fi.Extension.ToLower() == ".help")
                {
                    lviFile.ImageIndex = 5;
                }
                else if (fi.Extension.ToLower() == ".mdb")
                {
                    lviFile.ImageIndex = 6;
                }
                else if (fi.Extension.ToLower() == ".htm"
               || fi.Extension.ToLower() == ".html")
                {
                    lviFile.ImageIndex = 18;
                }
                else if (fi.Extension.ToLower() == ".pot")
                {
                    lviFile.ImageIndex = 9;
                }
                else if (fi.Extension.ToLower() == ".ppt")
                {
                    lviFile.ImageIndex = 10;
                }
                else if (fi.Extension.ToLower() == ".rtf")
                {
                    lviFile.ImageIndex = 12;
                }
                else if (fi.Extension.ToLower() == ".txt")
                {
                    lviFile.ImageIndex = 15;
                }
                else if (fi.Extension.ToLower() == ".xls")
                {
                    lviFile.ImageIndex = 16;
                }
                else if (fi.Extension.ToLower() == ".xlt")
                {
                    lviFile.ImageIndex = 17;
                }
                else if (fi.Extension.ToLower() == ".swf")
                {
                    lviFile.ImageIndex = 19;
                }
                else
                {
                    lviFile.ImageIndex = 20;
                }

                this.listView1.Items.Add(lviFile);
            }

        

        }
        /// <summary>
        /// ��������б���
        /// </summary>
        public void Clear()
        {
            this.listView1.Items.Clear();//���ԭ������Item
        }

        /// <summary>
        /// ��ListView�л�ȡ�ļ��б������Ŀ¼�����1λ��0���ļ�����λΪ1
        /// </summary>
        /// <param name="lvFiles">�й��ļ���ListView</param>
        /// <returns>�����ļ��б�</returns>
        public ArrayList getFileListFromListView()
        {
            ArrayList arrFiles = new ArrayList();
            foreach (ListViewItem lvi in listView1.SelectedItems)
            {
                if (lvi.Tag != null || lvi.Tag.ToString() != "")
                {
                    string strFile = lvi.Tag.ToString();
                    arrFiles.Add(strFile);
                }
            }
            return arrFiles;
        }
        public void setImageList()
        {

            imageList1.Images.Add(Resources.CLSDFOLD);  //0
            imageList1.Images.Add(Resources.OPENFOLD);//1
            imageList1.Images.Add(Resources.doc2);//2
            imageList1.Images.Add(Resources.doc1);//3
            imageList1.Images.Add(Resources.dot);//4
            imageList1.Images.Add(Resources.help);//5
            imageList1.Images.Add(Resources.mdb);//6
            imageList1.Images.Add(Resources.mhtml);//7
            imageList1.Images.Add(Resources.ok);//8
            imageList1.Images.Add(Resources.pot);//9
            imageList1.Images.Add(Resources.ppt);//10
            imageList1.Images.Add(Resources.pub);//11
            imageList1.Images.Add(Resources.rtf);//12
            imageList1.Images.Add(Resources.run);//13
            imageList1.Images.Add(Resources.texttype);//14
            imageList1.Images.Add(Resources.txt1);//15
            imageList1.Images.Add(Resources.xls1);//16
            imageList1.Images.Add(Resources.xlt);//17
            imageList1.Images.Add(Resources.htm);//18
            imageList1.Images.Add(Resources.swf);//19
            imageList1.Images.Add(Resources.doc11);//20
            bolIsLoadResource = true;

        }

    }
}
