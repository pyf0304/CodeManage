namespace TestPubDataBase
{
    partial class frmTestTimeConflict
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
            this.btnTestConflict = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWeek = new System.Windows.Forms.TextBox();
            this.txtWeek_T = new System.Windows.Forms.TextBox();
            this.txtStartTime_T = new System.Windows.Forms.TextBox();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.txtEndTime_T = new System.Windows.Forms.TextBox();
            this.txtEndTime = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTestConflict
            // 
            this.btnTestConflict.Location = new System.Drawing.Point(56, 247);
            this.btnTestConflict.Name = "btnTestConflict";
            this.btnTestConflict.Size = new System.Drawing.Size(75, 23);
            this.btnTestConflict.TabIndex = 0;
            this.btnTestConflict.Text = "测试冲突";
            this.btnTestConflict.UseVisualStyleBackColor = true;
            this.btnTestConflict.Click += new System.EventHandler(this.btnTestConflict_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "原数据";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "检查数据";
            // 
            // txtWeek
            // 
            this.txtWeek.Location = new System.Drawing.Point(127, 21);
            this.txtWeek.Name = "txtWeek";
            this.txtWeek.Size = new System.Drawing.Size(59, 21);
            this.txtWeek.TabIndex = 3;
            // 
            // txtWeek_T
            // 
            this.txtWeek_T.Location = new System.Drawing.Point(127, 69);
            this.txtWeek_T.Name = "txtWeek_T";
            this.txtWeek_T.Size = new System.Drawing.Size(59, 21);
            this.txtWeek_T.TabIndex = 4;
            // 
            // txtStartTime_T
            // 
            this.txtStartTime_T.Location = new System.Drawing.Point(217, 70);
            this.txtStartTime_T.Name = "txtStartTime_T";
            this.txtStartTime_T.Size = new System.Drawing.Size(59, 21);
            this.txtStartTime_T.TabIndex = 6;
            // 
            // txtStartTime
            // 
            this.txtStartTime.Location = new System.Drawing.Point(217, 22);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(59, 21);
            this.txtStartTime.TabIndex = 5;
            // 
            // txtEndTime_T
            // 
            this.txtEndTime_T.Location = new System.Drawing.Point(306, 69);
            this.txtEndTime_T.Name = "txtEndTime_T";
            this.txtEndTime_T.Size = new System.Drawing.Size(59, 21);
            this.txtEndTime_T.TabIndex = 8;
            // 
            // txtEndTime
            // 
            this.txtEndTime.Location = new System.Drawing.Point(306, 21);
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.Size = new System.Drawing.Size(59, 21);
            this.txtEndTime.TabIndex = 7;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(97, 155);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(53, 12);
            this.lblResult.TabIndex = 9;
            this.lblResult.Text = "检查数据";
            // 
            // frmTestTimeConflict
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 351);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtEndTime_T);
            this.Controls.Add(this.txtEndTime);
            this.Controls.Add(this.txtStartTime_T);
            this.Controls.Add(this.txtStartTime);
            this.Controls.Add(this.txtWeek_T);
            this.Controls.Add(this.txtWeek);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTestConflict);
            this.Name = "frmTestTimeConflict";
            this.Text = "测试时间片冲突";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTestConflict;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWeek;
        private System.Windows.Forms.TextBox txtWeek_T;
        private System.Windows.Forms.TextBox txtStartTime_T;
        private System.Windows.Forms.TextBox txtStartTime;
        private System.Windows.Forms.TextBox txtEndTime_T;
        private System.Windows.Forms.TextBox txtEndTime;
        private System.Windows.Forms.Label lblResult;
    }
}