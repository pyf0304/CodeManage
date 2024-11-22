namespace TestPubDataBase
{
    partial class frmTestTableData
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDispSourceData = new System.Windows.Forms.Button();
            this.tableLayoutPanel_New = new System.Windows.Forms.TableLayoutPanel();
            this.btnTestTableIndex = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 84);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(415, 219);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnDispSourceData
            // 
            this.btnDispSourceData.Location = new System.Drawing.Point(337, 12);
            this.btnDispSourceData.Name = "btnDispSourceData";
            this.btnDispSourceData.Size = new System.Drawing.Size(111, 23);
            this.btnDispSourceData.TabIndex = 1;
            this.btnDispSourceData.Text = "显示表数据";
            this.btnDispSourceData.UseVisualStyleBackColor = true;
            this.btnDispSourceData.Click += new System.EventHandler(this.btnDispSourceData_Click);
            // 
            // tableLayoutPanel_New
            // 
            this.tableLayoutPanel_New.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel_New.ColumnCount = 7;
            this.tableLayoutPanel_New.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_New.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_New.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_New.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_New.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_New.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_New.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_New.Location = new System.Drawing.Point(486, 84);
            this.tableLayoutPanel_New.Name = "tableLayoutPanel_New";
            this.tableLayoutPanel_New.RowCount = 7;
            this.tableLayoutPanel_New.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_New.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_New.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_New.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_New.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_New.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_New.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_New.Size = new System.Drawing.Size(400, 219);
            this.tableLayoutPanel_New.TabIndex = 2;
            // 
            // btnTestTableIndex
            // 
            this.btnTestTableIndex.Location = new System.Drawing.Point(486, 12);
            this.btnTestTableIndex.Name = "btnTestTableIndex";
            this.btnTestTableIndex.Size = new System.Drawing.Size(170, 23);
            this.btnTestTableIndex.TabIndex = 3;
            this.btnTestTableIndex.Text = "检查单元格序号函数";
            this.btnTestTableIndex.UseVisualStyleBackColor = true;
            this.btnTestTableIndex.Click += new System.EventHandler(this.btnTestTableIndex_Click);
            // 
            // frmTestTableData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 427);
            this.Controls.Add(this.btnTestTableIndex);
            this.Controls.Add(this.tableLayoutPanel_New);
            this.Controls.Add(this.btnDispSourceData);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmTestTableData";
            this.Text = "测试表数据";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnDispSourceData;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_New;
        private System.Windows.Forms.Button btnTestTableIndex;

    }
}