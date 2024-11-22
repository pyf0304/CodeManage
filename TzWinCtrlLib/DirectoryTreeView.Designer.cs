namespace TzWinCtrlLib
{
    partial class DirectoryTreeView
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tvLocalDir = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // tvLocalDir
            // 
            this.tvLocalDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvLocalDir.ImageIndex = 0;
            this.tvLocalDir.ImageList = this.imageList1;
            this.tvLocalDir.Location = new System.Drawing.Point(0, 0);
            this.tvLocalDir.Name = "tvLocalDir";
            this.tvLocalDir.SelectedImageIndex = 0;
            this.tvLocalDir.Size = new System.Drawing.Size(150, 150);
            this.tvLocalDir.TabIndex = 0;
            this.tvLocalDir.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvLocalDir_AfterCheck);
            this.tvLocalDir.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.tvLocalDir.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.tvLocalDir_AfterExpand);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // DirectoryTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tvLocalDir);
            this.Name = "DirectoryTreeView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvLocalDir;
        private System.Windows.Forms.ImageList imageList1;
    }
}
