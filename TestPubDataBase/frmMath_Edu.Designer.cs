namespace TestPubDataBase
{
    partial class frmMath_Edu
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnStandardDeviation = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.ListBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtFulleScore = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStandardDeviation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMinScore = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "模拟30个分数";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStandardDeviation
            // 
            this.btnStandardDeviation.Location = new System.Drawing.Point(164, 168);
            this.btnStandardDeviation.Name = "btnStandardDeviation";
            this.btnStandardDeviation.Size = new System.Drawing.Size(134, 27);
            this.btnStandardDeviation.TabIndex = 1;
            this.btnStandardDeviation.Text = "计算:标准差";
            this.btnStandardDeviation.UseVisualStyleBackColor = true;
            this.btnStandardDeviation.Click += new System.EventHandler(this.btnStandardDeviation_Click);
            // 
            // lbResult
            // 
            this.lbResult.FormattingEnabled = true;
            this.lbResult.ItemHeight = 14;
            this.lbResult.Location = new System.Drawing.Point(407, 230);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(311, 396);
            this.lbResult.TabIndex = 2;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(163, 31);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(752, 46);
            this.txtData.TabIndex = 3;
            // 
            // txtFulleScore
            // 
            this.txtFulleScore.Location = new System.Drawing.Point(397, 103);
            this.txtFulleScore.Name = "txtFulleScore";
            this.txtFulleScore.Size = new System.Drawing.Size(116, 23);
            this.txtFulleScore.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "总分";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "标准差为：";
            // 
            // txtStandardDeviation
            // 
            this.txtStandardDeviation.Location = new System.Drawing.Point(407, 174);
            this.txtStandardDeviation.Name = "txtStandardDeviation";
            this.txtStandardDeviation.Size = new System.Drawing.Size(266, 23);
            this.txtStandardDeviation.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(538, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 14);
            this.label3.TabIndex = 9;
            this.label3.Text = "最低分";
            // 
            // txtMinScore
            // 
            this.txtMinScore.Location = new System.Drawing.Point(611, 104);
            this.txtMinScore.Name = "txtMinScore";
            this.txtMinScore.Size = new System.Drawing.Size(116, 23);
            this.txtMinScore.TabIndex = 8;
            // 
            // frmMath_Edu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 671);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMinScore);
            this.Controls.Add(this.txtStandardDeviation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFulleScore);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.btnStandardDeviation);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "frmMath_Edu";
            this.Text = "字符串类测试";
            this.Load += new System.EventHandler(this.frmMath_Edu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnStandardDeviation;
        private System.Windows.Forms.ListBox lbResult;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtFulleScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStandardDeviation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMinScore;
    }
}