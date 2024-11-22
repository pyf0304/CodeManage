namespace TestPubDataBase
{
    partial class frmTestSqlStatement
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
            this.txtSourceStr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTargetStr = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSourceStr
            // 
            this.txtSourceStr.Location = new System.Drawing.Point(100, 34);
            this.txtSourceStr.Multiline = true;
            this.txtSourceStr.Name = "txtSourceStr";
            this.txtSourceStr.Size = new System.Drawing.Size(727, 199);
            this.txtSourceStr.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "源串";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "目标串";
            // 
            // txtTargetStr
            // 
            this.txtTargetStr.Location = new System.Drawing.Point(100, 255);
            this.txtTargetStr.Multiline = true;
            this.txtTargetStr.Name = "txtTargetStr";
            this.txtTargetStr.Size = new System.Drawing.Size(727, 199);
            this.txtTargetStr.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 473);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "去除单撇中的内容";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmTestSqlStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 590);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTargetStr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSourceStr);
            this.Name = "frmTestSqlStatement";
            this.Text = "测试Sql语句分析";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSourceStr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTargetStr;
        private System.Windows.Forms.Button button1;
    }
}