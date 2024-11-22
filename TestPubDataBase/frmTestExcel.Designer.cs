namespace TestPubDataBase
{
    partial class frmTestExcel
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
            this.btnTestConn4Excel2003 = new System.Windows.Forms.Button();
            this.btnTestConn4Excel2007 = new System.Windows.Forms.Button();
            this.btnGetSheetNamesExcel2003 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnGetSheetNamesExcel2007 = new System.Windows.Forms.Button();
            this.btnGetSheetContentExcel2003 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGetSheetContentExcel2007 = new System.Windows.Forms.Button();
            this.btnTestConn4Excel = new System.Windows.Forms.Button();
            this.btnGetSheetNamesExcel = new System.Windows.Forms.Button();
            this.cboExcelFileName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetSheetContentExcel = new System.Windows.Forms.Button();
            this.btnGetSheetRecCount = new System.Windows.Forms.Button();
            this.btnGetSheetContentExcel2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTestConn4Excel2003
            // 
            this.btnTestConn4Excel2003.Location = new System.Drawing.Point(12, 12);
            this.btnTestConn4Excel2003.Name = "btnTestConn4Excel2003";
            this.btnTestConn4Excel2003.Size = new System.Drawing.Size(157, 23);
            this.btnTestConn4Excel2003.TabIndex = 0;
            this.btnTestConn4Excel2003.Text = "测试连接Excel2003";
            this.btnTestConn4Excel2003.UseVisualStyleBackColor = true;
            this.btnTestConn4Excel2003.Click += new System.EventHandler(this.btnTestConn4Excel2003_Click);
            // 
            // btnTestConn4Excel2007
            // 
            this.btnTestConn4Excel2007.Location = new System.Drawing.Point(12, 51);
            this.btnTestConn4Excel2007.Name = "btnTestConn4Excel2007";
            this.btnTestConn4Excel2007.Size = new System.Drawing.Size(157, 23);
            this.btnTestConn4Excel2007.TabIndex = 1;
            this.btnTestConn4Excel2007.Text = "测试连接Excel2007";
            this.btnTestConn4Excel2007.UseVisualStyleBackColor = true;
            this.btnTestConn4Excel2007.Click += new System.EventHandler(this.btnTestConn4Excel2007_Click);
            // 
            // btnGetSheetNamesExcel2003
            // 
            this.btnGetSheetNamesExcel2003.Location = new System.Drawing.Point(175, 12);
            this.btnGetSheetNamesExcel2003.Name = "btnGetSheetNamesExcel2003";
            this.btnGetSheetNamesExcel2003.Size = new System.Drawing.Size(157, 23);
            this.btnGetSheetNamesExcel2003.TabIndex = 2;
            this.btnGetSheetNamesExcel2003.Text = "获取表单列表Excel2003";
            this.btnGetSheetNamesExcel2003.UseVisualStyleBackColor = true;
            this.btnGetSheetNamesExcel2003.Click += new System.EventHandler(this.btnGetSheetNamesExcel2003_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(118, 173);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 3;
            // 
            // btnGetSheetNamesExcel2007
            // 
            this.btnGetSheetNamesExcel2007.Location = new System.Drawing.Point(175, 51);
            this.btnGetSheetNamesExcel2007.Name = "btnGetSheetNamesExcel2007";
            this.btnGetSheetNamesExcel2007.Size = new System.Drawing.Size(157, 23);
            this.btnGetSheetNamesExcel2007.TabIndex = 4;
            this.btnGetSheetNamesExcel2007.Text = "获取表单列表Excel2007";
            this.btnGetSheetNamesExcel2007.UseVisualStyleBackColor = true;
            this.btnGetSheetNamesExcel2007.Click += new System.EventHandler(this.btnGetSheetNamesExcel2007_Click);
            // 
            // btnGetSheetContentExcel2003
            // 
            this.btnGetSheetContentExcel2003.Location = new System.Drawing.Point(338, 12);
            this.btnGetSheetContentExcel2003.Name = "btnGetSheetContentExcel2003";
            this.btnGetSheetContentExcel2003.Size = new System.Drawing.Size(157, 23);
            this.btnGetSheetContentExcel2003.TabIndex = 5;
            this.btnGetSheetContentExcel2003.Text = "获取表单内容Excel2003";
            this.btnGetSheetContentExcel2003.UseVisualStyleBackColor = true;
            this.btnGetSheetContentExcel2003.Click += new System.EventHandler(this.btnGetSheetContentExcel2003_Click);
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
            // btnGetSheetContentExcel2007
            // 
            this.btnGetSheetContentExcel2007.Location = new System.Drawing.Point(338, 51);
            this.btnGetSheetContentExcel2007.Name = "btnGetSheetContentExcel2007";
            this.btnGetSheetContentExcel2007.Size = new System.Drawing.Size(157, 23);
            this.btnGetSheetContentExcel2007.TabIndex = 7;
            this.btnGetSheetContentExcel2007.Text = "获取表单内容Excel2007";
            this.btnGetSheetContentExcel2007.UseVisualStyleBackColor = true;
            this.btnGetSheetContentExcel2007.Click += new System.EventHandler(this.btnGetSheetContentExcel2007_Click);
            // 
            // btnTestConn4Excel
            // 
            this.btnTestConn4Excel.Location = new System.Drawing.Point(12, 115);
            this.btnTestConn4Excel.Name = "btnTestConn4Excel";
            this.btnTestConn4Excel.Size = new System.Drawing.Size(119, 23);
            this.btnTestConn4Excel.TabIndex = 8;
            this.btnTestConn4Excel.Text = "测试连接Excel";
            this.btnTestConn4Excel.UseVisualStyleBackColor = true;
            this.btnTestConn4Excel.Click += new System.EventHandler(this.btnTestConn4Excel_Click);
            // 
            // btnGetSheetNamesExcel
            // 
            this.btnGetSheetNamesExcel.Location = new System.Drawing.Point(137, 115);
            this.btnGetSheetNamesExcel.Name = "btnGetSheetNamesExcel";
            this.btnGetSheetNamesExcel.Size = new System.Drawing.Size(124, 23);
            this.btnGetSheetNamesExcel.TabIndex = 9;
            this.btnGetSheetNamesExcel.Text = "获取表单列表Excel";
            this.btnGetSheetNamesExcel.UseVisualStyleBackColor = true;
            this.btnGetSheetNamesExcel.Click += new System.EventHandler(this.btnGetSheetNamesExcel_Click);
            // 
            // cboExcelFileName
            // 
            this.cboExcelFileName.FormattingEnabled = true;
            this.cboExcelFileName.Location = new System.Drawing.Point(71, 86);
            this.cboExcelFileName.Name = "cboExcelFileName";
            this.cboExcelFileName.Size = new System.Drawing.Size(424, 20);
            this.cboExcelFileName.TabIndex = 10;
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
            // btnGetSheetContentExcel
            // 
            this.btnGetSheetContentExcel.Location = new System.Drawing.Point(271, 115);
            this.btnGetSheetContentExcel.Name = "btnGetSheetContentExcel";
            this.btnGetSheetContentExcel.Size = new System.Drawing.Size(124, 23);
            this.btnGetSheetContentExcel.TabIndex = 12;
            this.btnGetSheetContentExcel.Text = "获取表单内容Excel";
            this.btnGetSheetContentExcel.UseVisualStyleBackColor = true;
            this.btnGetSheetContentExcel.Click += new System.EventHandler(this.btnGetSheetContentExcel_Click);
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
            // btnGetSheetContentExcel2
            // 
            this.btnGetSheetContentExcel2.Location = new System.Drawing.Point(401, 115);
            this.btnGetSheetContentExcel2.Name = "btnGetSheetContentExcel2";
            this.btnGetSheetContentExcel2.Size = new System.Drawing.Size(124, 23);
            this.btnGetSheetContentExcel2.TabIndex = 14;
            this.btnGetSheetContentExcel2.Text = "获取表单内容Excel2";
            this.btnGetSheetContentExcel2.UseVisualStyleBackColor = true;
            this.btnGetSheetContentExcel2.Click += new System.EventHandler(this.btnGetSheetContentExcel2_Click);
            // 
            // frmTestExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 444);
            this.Controls.Add(this.btnGetSheetContentExcel2);
            this.Controls.Add(this.btnGetSheetRecCount);
            this.Controls.Add(this.btnGetSheetContentExcel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboExcelFileName);
            this.Controls.Add(this.btnGetSheetNamesExcel);
            this.Controls.Add(this.btnTestConn4Excel);
            this.Controls.Add(this.btnGetSheetContentExcel2007);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGetSheetContentExcel2003);
            this.Controls.Add(this.btnGetSheetNamesExcel2007);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnGetSheetNamesExcel2003);
            this.Controls.Add(this.btnTestConn4Excel2007);
            this.Controls.Add(this.btnTestConn4Excel2003);
            this.Name = "frmTestExcel";
            this.Text = "frmTestExcel";
            this.Load += new System.EventHandler(this.frmTestExcel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTestConn4Excel2003;
        private System.Windows.Forms.Button btnTestConn4Excel2007;
        private System.Windows.Forms.Button btnGetSheetNamesExcel2003;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnGetSheetNamesExcel2007;
        private System.Windows.Forms.Button btnGetSheetContentExcel2003;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGetSheetContentExcel2007;
        private System.Windows.Forms.Button btnTestConn4Excel;
        private System.Windows.Forms.Button btnGetSheetNamesExcel;
        private System.Windows.Forms.ComboBox cboExcelFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetSheetContentExcel;
        private System.Windows.Forms.Button btnGetSheetRecCount;
        private System.Windows.Forms.Button btnGetSheetContentExcel2;
    }
}