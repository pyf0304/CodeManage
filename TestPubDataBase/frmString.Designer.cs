namespace TestPubDataBase
{
    partial class frmString
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
            this.btnGetUniqueStrValue = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "随机字符串";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGetUniqueStrValue
            // 
            this.btnGetUniqueStrValue.Location = new System.Drawing.Point(42, 81);
            this.btnGetUniqueStrValue.Name = "btnGetUniqueStrValue";
            this.btnGetUniqueStrValue.Size = new System.Drawing.Size(115, 23);
            this.btnGetUniqueStrValue.TabIndex = 1;
            this.btnGetUniqueStrValue.Text = "获取唯一串值";
            this.btnGetUniqueStrValue.UseVisualStyleBackColor = true;
            this.btnGetUniqueStrValue.Click += new System.EventHandler(this.btnGetUniqueStrValue_Click);
            // 
            // lbResult
            // 
            this.lbResult.FormattingEnabled = true;
            this.lbResult.ItemHeight = 12;
            this.lbResult.Location = new System.Drawing.Point(238, 16);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(267, 340);
            this.lbResult.TabIndex = 2;
            // 
            // frmString
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 575);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.btnGetUniqueStrValue);
            this.Controls.Add(this.button1);
            this.Name = "frmString";
            this.Text = "字符串类测试";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGetUniqueStrValue;
        private System.Windows.Forms.ListBox lbResult;
    }
}