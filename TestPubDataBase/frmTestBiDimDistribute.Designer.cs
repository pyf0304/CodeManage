namespace TestPubDataBase
{
    partial class frmTestBiDimDistribute
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
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnCalcColWidth = new System.Windows.Forms.Button();
            this.btnCalcPosition = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(46, 70);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(111, 23);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "开始行高计算";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnCalcColWidth
            // 
            this.btnCalcColWidth.Location = new System.Drawing.Point(46, 127);
            this.btnCalcColWidth.Name = "btnCalcColWidth";
            this.btnCalcColWidth.Size = new System.Drawing.Size(111, 23);
            this.btnCalcColWidth.TabIndex = 1;
            this.btnCalcColWidth.Text = "开始列宽计算";
            this.btnCalcColWidth.UseVisualStyleBackColor = true;
            this.btnCalcColWidth.Click += new System.EventHandler(this.btnCalcColWidth_Click);
            // 
            // btnCalcPosition
            // 
            this.btnCalcPosition.Location = new System.Drawing.Point(46, 186);
            this.btnCalcPosition.Name = "btnCalcPosition";
            this.btnCalcPosition.Size = new System.Drawing.Size(111, 23);
            this.btnCalcPosition.TabIndex = 2;
            this.btnCalcPosition.Text = "开始位置计算";
            this.btnCalcPosition.UseVisualStyleBackColor = true;
            this.btnCalcPosition.Click += new System.EventHandler(this.btnCalcPosition_Click);
            // 
            // frmTestBiDimDistribute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 431);
            this.Controls.Add(this.btnCalcPosition);
            this.Controls.Add(this.btnCalcColWidth);
            this.Controls.Add(this.btnCalc);
            this.Name = "frmTestBiDimDistribute";
            this.Text = "frmTestBiDimDistribute";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnCalcColWidth;
        private System.Windows.Forms.Button btnCalcPosition;
    }
}