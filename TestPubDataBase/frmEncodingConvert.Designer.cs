namespace TestPubDataBase
{
    partial class frmEncodingConvert
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSourceString = new System.Windows.Forms.TextBox();
            this.txtTargetString = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGb2312ToUtf8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "源字符串";
            // 
            // txtSourceString
            // 
            this.txtSourceString.Location = new System.Drawing.Point(132, 45);
            this.txtSourceString.Name = "txtSourceString";
            this.txtSourceString.Size = new System.Drawing.Size(501, 21);
            this.txtSourceString.TabIndex = 1;
            // 
            // txtTargetString
            // 
            this.txtTargetString.Location = new System.Drawing.Point(132, 105);
            this.txtTargetString.Name = "txtTargetString";
            this.txtTargetString.Size = new System.Drawing.Size(501, 21);
            this.txtTargetString.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "目标字符串";
            // 
            // btnGb2312ToUtf8
            // 
            this.btnGb2312ToUtf8.Location = new System.Drawing.Point(132, 192);
            this.btnGb2312ToUtf8.Name = "btnGb2312ToUtf8";
            this.btnGb2312ToUtf8.Size = new System.Drawing.Size(121, 23);
            this.btnGb2312ToUtf8.TabIndex = 4;
            this.btnGb2312ToUtf8.Text = "gb2312转Utf8";
            this.btnGb2312ToUtf8.UseVisualStyleBackColor = true;
            this.btnGb2312ToUtf8.Click += new System.EventHandler(this.btnGb2312ToUtf8_Click);
            // 
            // frmEncodingConvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 411);
            this.Controls.Add(this.btnGb2312ToUtf8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTargetString);
            this.Controls.Add(this.txtSourceString);
            this.Controls.Add(this.label1);
            this.Name = "frmEncodingConvert";
            this.Text = "编码转换";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSourceString;
        private System.Windows.Forms.TextBox txtTargetString;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGb2312ToUtf8;
    }
}