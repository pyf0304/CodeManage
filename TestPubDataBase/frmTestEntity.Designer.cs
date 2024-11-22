namespace TestPubDataBase
{
    partial class frmTestEntity
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
            this.btnTestEntity = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTestEntity
            // 
            this.btnTestEntity.Location = new System.Drawing.Point(84, 40);
            this.btnTestEntity.Name = "btnTestEntity";
            this.btnTestEntity.Size = new System.Drawing.Size(75, 23);
            this.btnTestEntity.TabIndex = 0;
            this.btnTestEntity.Text = "测试实体层";
            this.btnTestEntity.UseVisualStyleBackColor = true;
            this.btnTestEntity.Click += new System.EventHandler(this.btnTestEntity_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(191, 40);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(41, 12);
            this.lblMsg.TabIndex = 1;
            this.lblMsg.Text = "label1";
            // 
            // frmTestEntity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 485);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnTestEntity);
            this.Name = "frmTestEntity";
            this.Text = "frmTestEntity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTestEntity;
        private System.Windows.Forms.Label lblMsg;
    }
}