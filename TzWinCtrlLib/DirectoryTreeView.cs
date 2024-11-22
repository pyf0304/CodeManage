using System;
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
    public partial class DirectoryTreeView : UserControl
    {
        private string mstrSelectedDirFullName = "";
        /// <summary>
        /// 被选节点的目录名
        /// </summary>
        public string SelectedDirFullName
        {
            get 
            {
                TreeNode tnSel = tvLocalDir.SelectedNode;
                if (tnSel == null) return "";
                if (tnSel.Tag == null || tnSel.Tag.ToString().Length <= 1) return "";
                string strDir = tnSel.Tag.ToString().Substring(1);
                return strDir; 
            }
            set { mstrSelectedDirFullName = value; }
        }

        private bool bolIsLoadResource = false;//是否导入资源


        //定义各种事件
        public delegate void AfterSelect_Tz(object sender, System.Windows.Forms.TreeViewEventArgs e);
        public event AfterSelect_Tz afterSelect_Tz;

        public delegate void AfterCheck_Tz(object sender, System.Windows.Forms.TreeViewEventArgs e);
        public event AfterCheck_Tz afterCheck_Tz;

        //public delegate void MenuItemRightClick(string strMenuName);
        //public event MenuItemRightClick menuItemRightClick;

        
        public DirectoryTreeView()
        {
            InitializeComponent();
        }




        public void Bindtv_LocalDir()
        {
            if (bolIsLoadResource == false)
            {
                setImageList();
            }
            TreeNode tRoot = new TreeNode("我的电脑", 0, 0);
            tRoot.Tag = "1" + "我的电脑";
            this.tvLocalDir.Nodes.Add(tRoot);
            string[] drivers = null;
            drivers = System.IO.Directory.GetLogicalDrives();
            foreach (string s in drivers)
            {
                TreeNode NodeTemp = new TreeNode(s);
                NodeTemp.Tag = "1" + s;
                NodeTemp.ImageIndex = 0;
                NodeTemp.SelectedImageIndex = 1;

                tRoot.Nodes.Add(NodeTemp);
                DriveInfo diDriveInfo = new DriveInfo(s);
                if (diDriveInfo.DriveType != DriveType.CDRom
                    && diDriveInfo.DriveType != DriveType.Unknown
                 && diDriveInfo.DriveType != DriveType.NoRootDirectory
                    && diDriveInfo.IsReady == true)
                {
                    BindDirByDrive(s, NodeTemp);
                }
            }
            tvLocalDir.Nodes[0].Expand();
        }
        public DirectoryInfo[] getDirectories(String strDrive)
        {
            DirectoryInfo dir = new DirectoryInfo(strDrive);
            DirectoryInfo[] childDirs = dir.GetDirectories();
            return childDirs;
        }

        private void BindDirByDrive(string strDrive, TreeNode tnParent)
        {

            if (strDrive == "")
            {
                MessageBox.Show("请提供一个有效盘符");
            }

            DirectoryInfo[] ChildDirs = this.getDirectories(strDrive);

            //Get   the   Child   Directories.   
            DirectoryInfo ChildDir;
            foreach (DirectoryInfo di in ChildDirs)
            {
                if ((di.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden
                    || (di.Attributes & FileAttributes.System) == FileAttributes.System)
                {
                    continue;
                }
                ChildDir = di;
                TreeNode tn = new TreeNode(di.Name);
                tn.Tag = "0" + di.FullName;
                tn.ImageIndex = 0;
                tn.SelectedImageIndex = 1;

                tnParent.Nodes.Add(tn);
                //添加子目录到树中
                BindSubDirByDir(ChildDir, tn);

            }


        }

        private void BindSubDirByDir(DirectoryInfo diDir, TreeNode tnParent)
        {
            DirectoryInfo[] ChildDirs = null;
            try
            {

                ChildDirs = diDir.GetDirectories();
            }
            catch (Exception objEx)
            {
                MessageBox.Show(objEx.Message);
            }
            //Get   the   Child   Directories.   
            DirectoryInfo ChildDir;
            foreach (DirectoryInfo di in ChildDirs)
            {
                ChildDir = di;
                TreeNode tn = new TreeNode(di.Name);
                tn.Tag = "0" + di.FullName;
                tn.ImageIndex = 0;
                tn.SelectedImageIndex = 1;
                tnParent.Nodes.Add(tn);
                //添加子目录到树中
                //BindSubDirByDir(ChildDir, tn);
            }
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
            bolIsLoadResource = true;

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (afterSelect_Tz != null)
            {
                afterSelect_Tz(sender, e);
            }
        }

        private void tvLocalDir_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (afterCheck_Tz != null)
            {
                afterCheck_Tz(sender, e);
            }
        }

        private void tvLocalDir_AfterExpand(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag == null) return;
            if (e.Node.Tag.ToString().Substring(0, 1) == "0")
            {
                foreach (TreeNode tn in e.Node.Nodes)
                {
                    string strDirFullName = tn.Tag.ToString().Substring(1);
                    DirectoryInfo di = new DirectoryInfo(strDirFullName);
                    BindSubDirByDir(di, tn);
                }
                string strSS = e.Node.Tag.ToString().Substring(1);
                e.Node.Tag = "1" + strSS;
            }
        }
    }
}