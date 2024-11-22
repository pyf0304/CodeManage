namespace TestPubDataBase
{
    partial class frmTestAccess
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTestConn4Access2003 = new System.Windows.Forms.Button();
            this.btnTestConn4Access2007 = new System.Windows.Forms.Button();
            this.btnGetSheetNamesAccess2003 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnGetSheetNamesAccess2007 = new System.Windows.Forms.Button();
            this.btnGetSheetContentAccess2003 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGetSheetContentAccess2007 = new System.Windows.Forms.Button();
            this.btnTestConn4Access = new System.Windows.Forms.Button();
            this.btnGetSheetNamesAccess = new System.Windows.Forms.Button();
            this.cboAccessFileName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetSheetContentAccess = new System.Windows.Forms.Button();
            this.btnGetSheetRecCount = new System.Windows.Forms.Button();
            this.btnGetSheetContentAccess2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTestConn4Access2003
            // 
            this.btnTestConn4Access2003.Location = new System.Drawing.Point(12, 12);
            this.btnTestConn4Access2003.Name = "btnTestConn4Access2003";
            this.btnTestConn4Access2003.Size = new System.Drawing.Size(157, 23);
            this.btnTestConn4Access2003.TabIndex = 0;
            this.btnTestConn4Access2003.Text = "测试连接Access2003";
            this.btnTestConn4Access2003.UseVisualStyleBackColor = true;
            this.btnTestConn4Access2003.Click += new System.EventHandler(this.btnTestConn4Access2003_Click);
            // 
            // btnTestConn4Access2007
            // 
            this.btnTestConn4Access2007.Location = new System.Drawing.Point(12, 51);
            this.btnTestConn4Access2007.Name = "btnTestConn4Access2007";
            this.btnTestConn4Access2007.Size = new System.Drawing.Size(157, 23);
            this.btnTestConn4Access2007.TabIndex = 1;
            this.btnTestConn4Access2007.Text = "测试连接Access2007";
            this.btnTestConn4Access2007.UseVisualStyleBackColor = true;
            this.btnTestConn4Access2007.Click += new System.EventHandler(this.btnTestConn4Access2007_Click);
            // 
            // btnGetSheetNamesAccess2003
            // 
            this.btnGetSheetNamesAccess2003.Location = new System.Drawing.Point(175, 12);
            this.btnGetSheetNamesAccess2003.Name = "btnGetSheetNamesAccess2003";
            this.btnGetSheetNamesAccess2003.Size = new System.Drawing.Size(157, 23);
            this.btnGetSheetNamesAccess2003.TabIndex = 2;
            this.btnGetSheetNamesAccess2003.Text = "获取表单列表Access2003";
            this.btnGetSheetNamesAccess2003.UseVisualStyleBackColor = true;
            this.btnGetSheetNamesAccess2003.Click += new System.EventHandler(this.btnGetSheetNamesAccess2003_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(71, 173);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 20);
            this.comboBox1.TabIndex = 3;
            // 
            // btnGetSheetNamesAccess2007
            // 
            this.btnGetSheetNamesAccess2007.Location = new System.Drawing.Point(175, 51);
            this.btnGetSheetNamesAccess2007.Name = "btnGetSheetNamesAccess2007";
            this.btnGetSheetNamesAccess2007.Size = new System.Drawing.Size(157, 23);
            this.btnGetSheetNamesAccess2007.TabIndex = 4;
            this.btnGetSheetNamesAccess2007.Text = "获取表单列表Access2007";
            this.btnGetSheetNamesAccess2007.UseVisualStyleBackColor = true;
            this.btnGetSheetNamesAccess2007.Click += new System.EventHandler(this.btnGetSheetNamesAccess2007_Click);
            // 
            // btnGetSheetContentAccess2003
            // 
            this.btnGetSheetContentAccess2003.Location = new System.Drawing.Point(338, 12);
            this.btnGetSheetContentAccess2003.Name = "btnGetSheetContentAccess2003";
            this.btnGetSheetContentAccess2003.Size = new System.Drawing.Size(157, 23);
            this.btnGetSheetContentAccess2003.TabIndex = 5;
            this.btnGetSheetContentAccess2003.Text = "获取表单内容Access2003";
            this.btnGetSheetContentAccess2003.UseVisualStyleBackColor = true;
            this.btnGetSheetContentAccess2003.Click += new System.EventHandler(this.btnGetSheetContentAccess2003_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(271, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(423, 207);
            this.dataGridView1.TabIndex = 6;
            // 
            // btnGetSheetContentAccess2007
            // 
            this.btnGetSheetContentAccess2007.Location = new System.Drawing.Point(338, 51);
            this.btnGetSheetContentAccess2007.Name = "btnGetSheetContentAccess2007";
            this.btnGetSheetContentAccess2007.Size = new System.Drawing.Size(157, 23);
            this.btnGetSheetContentAccess2007.TabIndex = 7;
            this.btnGetSheetContentAccess2007.Text = "获取表单内容Access2007";
            this.btnGetSheetContentAccess2007.UseVisualStyleBackColor = true;
            this.btnGetSheetContentAccess2007.Click += new System.EventHandler(this.btnGetSheetContentAccess2007_Click);
            // 
            // btnTestConn4Access
            // 
            this.btnTestConn4Access.Location = new System.Drawing.Point(12, 115);
            this.btnTestConn4Access.Name = "btnTestConn4Access";
            this.btnTestConn4Access.Size = new System.Drawing.Size(119, 23);
            this.btnTestConn4Access.TabIndex = 8;
            this.btnTestConn4Access.Text = "测试连接Access";
            this.btnTestConn4Access.UseVisualStyleBackColor = true;
            this.btnTestConn4Access.Click += new System.EventHandler(this.btnTestConn4Access_Click);
            // 
            // btnGetSheetNamesAccess
            // 
            this.btnGetSheetNamesAccess.Location = new System.Drawing.Point(137, 115);
            this.btnGetSheetNamesAccess.Name = "btnGetSheetNamesAccess";
            this.btnGetSheetNamesAccess.Size = new System.Drawing.Size(124, 23);
            this.btnGetSheetNamesAccess.TabIndex = 9;
            this.btnGetSheetNamesAccess.Text = "获取表单列表Access";
            this.btnGetSheetNamesAccess.UseVisualStyleBackColor = true;
            this.btnGetSheetNamesAccess.Click += new System.EventHandler(this.btnGetSheetNamesAccess_Click);
            // 
            // cboAccessFileName
            // 
            this.cboAccessFileName.FormattingEnabled = true;
            this.cboAccessFileName.Location = new System.Drawing.Point(71, 86);
            this.cboAccessFileName.Name = "cboAccessFileName";
            this.cboAccessFileName.Size = new System.Drawing.Size(424, 20);
            this.cboAccessFileName.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "文件名";
            // 
            // btnGetSheetContentAccess
            // 
            this.btnGetSheetContentAccess.Location = new System.Drawing.Point(271, 115);
            this.btnGetSheetContentAccess.Name = "btnGetSheetContentAccess";
            this.btnGetSheetContentAccess.Size = new System.Drawing.Size(124, 23);
            this.btnGetSheetContentAccess.TabIndex = 12;
            this.btnGetSheetContentAccess.Text = "获取表单内容Access";
            this.btnGetSheetContentAccess.UseVisualStyleBackColor = true;
            this.btnGetSheetContentAccess.Click += new System.EventHandler(this.btnGetSheetContentAccess_Click);
            // 
            // btnGetSheetRecCount
            // 
            this.btnGetSheetRecCount.Location = new System.Drawing.Point(532, 115);
            this.btnGetSheetRecCount.Name = "btnGetSheetRecCount";
            this.btnGetSheetRecCount.Size = new System.Drawing.Size(105, 23);
            this.btnGetSheetRecCount.TabIndex = 13;
            this.btnGetSheetRecCount.Text = "获取表单记录数";
            this.btnGetSheetRecCount.UseVisualStyleBackColor = true;
            this.btnGetSheetRecCount.Click += new System.EventHandler(this.btnGetSheetRecCount_Click);
            // 
            // btnGetSheetContentAccess2
            // 
            this.btnGetSheetContentAccess2.Location = new System.Drawing.Point(401, 115);
            this.btnGetSheetContentAccess2.Name = "btnGetSheetContentAccess2";
            this.btnGetSheetContentAccess2.Size = new System.Drawing.Size(124, 23);
            this.btnGetSheetContentAccess2.TabIndex = 14;
            this.btnGetSheetContentAccess2.Text = "获取表单内容Access2";
            this.btnGetSheetContentAccess2.UseVisualStyleBackColor = true;
            this.btnGetSheetContentAccess2.Click += new System.EventHandler(this.btnGetSheetContentAccess2_Click);
            // 
            // frmTestAccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 444);
            this.Controls.Add(this.btnGetSheetContentAccess2);
            this.Controls.Add(this.btnGetSheetRecCount);
            this.Controls.Add(this.btnGetSheetContentAccess);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboAccessFileName);
            this.Controls.Add(this.btnGetSheetNamesAccess);
            this.Controls.Add(this.btnTestConn4Access);
            this.Controls.Add(this.btnGetSheetContentAccess2007);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGetSheetContentAccess2003);
            this.Controls.Add(this.btnGetSheetNamesAccess2007);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnGetSheetNamesAccess2003);
            this.Controls.Add(this.btnTestConn4Access2007);
            this.Controls.Add(this.btnTestConn4Access2003);
            this.Name = "frmTestAccess";
            this.Text = "测试Access功能";
            this.Load += new System.EventHandler(this.frmTestAccess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTestConn4Access2003;
        private System.Windows.Forms.Button btnTestConn4Access2007;
        private System.Windows.Forms.Button btnGetSheetNamesAccess2003;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnGetSheetNamesAccess2007;
        private System.Windows.Forms.Button btnGetSheetContentAccess2003;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGetSheetContentAccess2007;
        private System.Windows.Forms.Button btnTestConn4Access;
        private System.Windows.Forms.Button btnGetSheetNamesAccess;
        private System.Windows.Forms.ComboBox cboAccessFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetSheetContentAccess;
        private System.Windows.Forms.Button btnGetSheetRecCount;
        private System.Windows.Forms.Button btnGetSheetContentAccess2;
    }
}