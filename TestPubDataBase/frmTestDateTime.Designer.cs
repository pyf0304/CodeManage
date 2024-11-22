namespace TestPubDataBase
{
    partial class frmTestDateTime
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
            this.btnInitDateTime = new System.Windows.Forms.Button();
            this.txtInitPara = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnGetDateTime_Sim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInitDateTime
            // 
            this.btnInitDateTime.Location = new System.Drawing.Point(26, 84);
            this.btnInitDateTime.Name = "btnInitDateTime";
            this.btnInitDateTime.Size = new System.Drawing.Size(110, 23);
            this.btnInitDateTime.TabIndex = 0;
            this.btnInitDateTime.Text = "初始化日期类 ";
            this.btnInitDateTime.UseVisualStyleBackColor = true;
            this.btnInitDateTime.Click += new System.EventHandler(this.btnInitDateTime_Click);
            // 
            // txtInitPara
            // 
            this.txtInitPara.Location = new System.Drawing.Point(78, 42);
            this.txtInitPara.Name = "txtInitPara";
            this.txtInitPara.Size = new System.Drawing.Size(100, 21);
            this.txtInitPara.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "初始参数";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(24, 125);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(29, 12);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "结果";
            // 
            // btnGetDateTime_Sim
            // 
            this.btnGetDateTime_Sim.Location = new System.Drawing.Point(240, 84);
            this.btnGetDateTime_Sim.Name = "btnGetDateTime_Sim";
            this.btnGetDateTime_Sim.Size = new System.Drawing.Size(133, 23);
            this.btnGetDateTime_Sim.TabIndex = 4;
            this.btnGetDateTime_Sim.Text = "GetDateTime_Sim";
            this.btnGetDateTime_Sim.UseVisualStyleBackColor = true;
            this.btnGetDateTime_Sim.Click += new System.EventHandler(this.btnGetDateTime_Sim_Click);
            // 
            // frmTestDateTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 377);
            this.Controls.Add(this.btnGetDateTime_Sim);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInitPara);
            this.Controls.Add(this.btnInitDateTime);
            this.Name = "frmTestDateTime";
            this.Text = "frmTestDateTime";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInitDateTime;
        private System.Windows.Forms.TextBox txtInitPara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnGetDateTime_Sim;
    }
}