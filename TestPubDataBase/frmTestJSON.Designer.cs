namespace TestPubDataBase
{
    partial class frmTestJSON
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
            this.btnTransObjJSON = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.lblMsg2 = new System.Windows.Forms.Label();
            this.btnTransObjLstJSON = new System.Windows.Forms.Button();
            this.btnGetTestCode = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnTransObjJSON
            // 
            this.btnTransObjJSON.Location = new System.Drawing.Point(27, 22);
            this.btnTransObjJSON.Name = "btnTransObjJSON";
            this.btnTransObjJSON.Size = new System.Drawing.Size(115, 23);
            this.btnTransObjJSON.TabIndex = 0;
            this.btnTransObjJSON.Text = "对象转换JSON";
            this.btnTransObjJSON.UseVisualStyleBackColor = true;
            this.btnTransObjJSON.Click += new System.EventHandler(this.btnTransObjJSON_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(165, 22);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(41, 12);
            this.lblMsg.TabIndex = 1;
            this.lblMsg.Text = "label1";
            // 
            // lblMsg2
            // 
            this.lblMsg2.AutoSize = true;
            this.lblMsg2.Location = new System.Drawing.Point(165, 50);
            this.lblMsg2.Name = "lblMsg2";
            this.lblMsg2.Size = new System.Drawing.Size(41, 12);
            this.lblMsg2.TabIndex = 2;
            this.lblMsg2.Text = "label1";
            // 
            // btnTransObjLstJSON
            // 
            this.btnTransObjLstJSON.Location = new System.Drawing.Point(27, 102);
            this.btnTransObjLstJSON.Name = "btnTransObjLstJSON";
            this.btnTransObjLstJSON.Size = new System.Drawing.Size(115, 23);
            this.btnTransObjLstJSON.TabIndex = 3;
            this.btnTransObjLstJSON.Text = "对象列表转换JSON";
            this.btnTransObjLstJSON.UseVisualStyleBackColor = true;
            this.btnTransObjLstJSON.Click += new System.EventHandler(this.btnTransObjLstJSON_Click);
            // 
            // btnGetTestCode
            // 
            this.btnGetTestCode.Location = new System.Drawing.Point(27, 144);
            this.btnGetTestCode.Name = "btnGetTestCode";
            this.btnGetTestCode.Size = new System.Drawing.Size(115, 23);
            this.btnGetTestCode.TabIndex = 4;
            this.btnGetTestCode.Text = "生成测试代码";
            this.btnGetTestCode.UseVisualStyleBackColor = true;
            this.btnGetTestCode.Click += new System.EventHandler(this.btnGetTestCode_Click);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(148, 144);
            this.txtCode.Multiline = true;
            this.txtCode.Name = "txtCode";
            this.txtCode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCode.Size = new System.Drawing.Size(709, 414);
            this.txtCode.TabIndex = 5;
            // 
            // frmTestJSON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 570);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.btnGetTestCode);
            this.Controls.Add(this.btnTransObjLstJSON);
            this.Controls.Add(this.lblMsg2);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnTransObjJSON);
            this.Name = "frmTestJSON";
            this.Text = "frmTestJSON";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTransObjJSON;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label lblMsg2;
        private System.Windows.Forms.Button btnTransObjLstJSON;
        private System.Windows.Forms.Button btnGetTestCode;
        private System.Windows.Forms.TextBox txtCode;
    }
}