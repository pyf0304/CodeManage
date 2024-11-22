namespace TestExcelWin
{
    partial class Form1
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTestOpenExcel2007ByOdbc = new System.Windows.Forms.Button();
            this.btnTestOpenExcel2003ByOdbc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTestOpenExcel2007ByOdbc
            // 
            this.btnTestOpenExcel2007ByOdbc.Location = new System.Drawing.Point(46, 67);
            this.btnTestOpenExcel2007ByOdbc.Name = "btnTestOpenExcel2007ByOdbc";
            this.btnTestOpenExcel2007ByOdbc.Size = new System.Drawing.Size(219, 23);
            this.btnTestOpenExcel2007ByOdbc.TabIndex = 0;
            this.btnTestOpenExcel2007ByOdbc.Text = "测试打开Excel2007－ByOdbc";
            this.btnTestOpenExcel2007ByOdbc.UseVisualStyleBackColor = true;
            this.btnTestOpenExcel2007ByOdbc.Click += new System.EventHandler(this.btnTestOpenExcel2007ByOdbc_Click);
            // 
            // btnTestOpenExcel2003ByOdbc
            // 
            this.btnTestOpenExcel2003ByOdbc.Location = new System.Drawing.Point(46, 110);
            this.btnTestOpenExcel2003ByOdbc.Name = "btnTestOpenExcel2003ByOdbc";
            this.btnTestOpenExcel2003ByOdbc.Size = new System.Drawing.Size(219, 23);
            this.btnTestOpenExcel2003ByOdbc.TabIndex = 1;
            this.btnTestOpenExcel2003ByOdbc.Text = "测试打开Excel2003－ByOdbc";
            this.btnTestOpenExcel2003ByOdbc.UseVisualStyleBackColor = true;
            this.btnTestOpenExcel2003ByOdbc.Click += new System.EventHandler(this.btnTestOpenExcel2003ByOdbc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 436);
            this.Controls.Add(this.btnTestOpenExcel2003ByOdbc);
            this.Controls.Add(this.btnTestOpenExcel2007ByOdbc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTestOpenExcel2007ByOdbc;
        private System.Windows.Forms.Button btnTestOpenExcel2003ByOdbc;
    }
}

