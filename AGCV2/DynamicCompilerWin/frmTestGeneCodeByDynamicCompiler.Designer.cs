﻿namespace DynamicCompilerWin
{
    partial class frmTestGeneCodeByDynamicCompiler
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
            this.btnDynCompAndExec = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnTestDynamicCompilerClass = new System.Windows.Forms.Button();
            this.btnTestCalc = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTestDynCompiler4CacheInit = new System.Windows.Forms.Button();
            this.btnTestCacheInit = new System.Windows.Forms.Button();
            this.btnInvokeFunctionByStrName = new System.Windows.Forms.Button();
            this.btnAddCacheInitFunction = new System.Windows.Forms.Button();
            this.btnExecCacheInitFunction = new System.Windows.Forms.Button();
            this.btnInitGeneCodeByDynCompiler = new System.Windows.Forms.Button();
            this.btnInitGeneCode = new System.Windows.Forms.Button();
            this.btnInitGeneCode_ByGeneCode = new System.Windows.Forms.Button();
            this.btnInitGeneCodeByDynCompiler4Tab = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDynCompAndExec
            // 
            this.btnDynCompAndExec.Location = new System.Drawing.Point(12, 5);
            this.btnDynCompAndExec.Name = "btnDynCompAndExec";
            this.btnDynCompAndExec.Size = new System.Drawing.Size(155, 27);
            this.btnDynCompAndExec.TabIndex = 0;
            this.btnDynCompAndExec.Text = "动态编译并执行";
            this.btnDynCompAndExec.UseVisualStyleBackColor = true;
            this.btnDynCompAndExec.Click += new System.EventHandler(this.btnDynCompAndExec_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(44, 384);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(49, 14);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "label1";
            // 
            // btnTestDynamicCompilerClass
            // 
            this.btnTestDynamicCompilerClass.Location = new System.Drawing.Point(12, 45);
            this.btnTestDynamicCompilerClass.Name = "btnTestDynamicCompilerClass";
            this.btnTestDynamicCompilerClass.Size = new System.Drawing.Size(155, 27);
            this.btnTestDynamicCompilerClass.TabIndex = 2;
            this.btnTestDynamicCompilerClass.Text = "测试动态编译类";
            this.btnTestDynamicCompilerClass.UseVisualStyleBackColor = true;
            this.btnTestDynamicCompilerClass.Click += new System.EventHandler(this.btnTestDynamicCompilerClass_Click);
            // 
            // btnTestCalc
            // 
            this.btnTestCalc.Location = new System.Drawing.Point(12, 85);
            this.btnTestCalc.Name = "btnTestCalc";
            this.btnTestCalc.Size = new System.Drawing.Size(119, 23);
            this.btnTestCalc.TabIndex = 3;
            this.btnTestCalc.Text = "测试计算类";
            this.btnTestCalc.UseVisualStyleBackColor = true;
            this.btnTestCalc.Click += new System.EventHandler(this.btnTestCalc_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "测试动态编译类-计算类";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTestDynCompiler4CacheInit
            // 
            this.btnTestDynCompiler4CacheInit.Location = new System.Drawing.Point(12, 201);
            this.btnTestDynCompiler4CacheInit.Name = "btnTestDynCompiler4CacheInit";
            this.btnTestDynCompiler4CacheInit.Size = new System.Drawing.Size(202, 27);
            this.btnTestDynCompiler4CacheInit.TabIndex = 5;
            this.btnTestDynCompiler4CacheInit.Text = "测试动态编译类-缓存初始化";
            this.btnTestDynCompiler4CacheInit.UseVisualStyleBackColor = true;
            this.btnTestDynCompiler4CacheInit.Click += new System.EventHandler(this.btnTestDynCompiler4CacheInit_Click);
            // 
            // btnTestCacheInit
            // 
            this.btnTestCacheInit.Location = new System.Drawing.Point(12, 241);
            this.btnTestCacheInit.Name = "btnTestCacheInit";
            this.btnTestCacheInit.Size = new System.Drawing.Size(144, 27);
            this.btnTestCacheInit.TabIndex = 6;
            this.btnTestCacheInit.Text = "测试缓存初始化";
            this.btnTestCacheInit.UseVisualStyleBackColor = true;
            this.btnTestCacheInit.Click += new System.EventHandler(this.btnTestCacheInit_Click);
            // 
            // btnInvokeFunctionByStrName
            // 
            this.btnInvokeFunctionByStrName.Location = new System.Drawing.Point(12, 161);
            this.btnInvokeFunctionByStrName.Name = "btnInvokeFunctionByStrName";
            this.btnInvokeFunctionByStrName.Size = new System.Drawing.Size(240, 27);
            this.btnInvokeFunctionByStrName.TabIndex = 7;
            this.btnInvokeFunctionByStrName.Text = "测试通过字符名称调用计算函数";
            this.btnInvokeFunctionByStrName.UseVisualStyleBackColor = true;
            this.btnInvokeFunctionByStrName.Click += new System.EventHandler(this.btnInvokeFunctionByStrName_Click);
            // 
            // btnAddCacheInitFunction
            // 
            this.btnAddCacheInitFunction.Location = new System.Drawing.Point(12, 281);
            this.btnAddCacheInitFunction.Name = "btnAddCacheInitFunction";
            this.btnAddCacheInitFunction.Size = new System.Drawing.Size(176, 27);
            this.btnAddCacheInitFunction.TabIndex = 8;
            this.btnAddCacheInitFunction.Text = "添加缓存初始化函数 ";
            this.btnAddCacheInitFunction.UseVisualStyleBackColor = true;
            this.btnAddCacheInitFunction.Click += new System.EventHandler(this.btnAddCacheInitFunction_Click);
            // 
            // btnExecCacheInitFunction
            // 
            this.btnExecCacheInitFunction.Location = new System.Drawing.Point(12, 321);
            this.btnExecCacheInitFunction.Name = "btnExecCacheInitFunction";
            this.btnExecCacheInitFunction.Size = new System.Drawing.Size(176, 27);
            this.btnExecCacheInitFunction.TabIndex = 9;
            this.btnExecCacheInitFunction.Text = "执行缓存初始化函数 ";
            this.btnExecCacheInitFunction.UseVisualStyleBackColor = true;
            this.btnExecCacheInitFunction.Click += new System.EventHandler(this.btnExecCacheInitFunction_Click);
            // 
            // btnInitGeneCodeByDynCompiler
            // 
            this.btnInitGeneCodeByDynCompiler.Location = new System.Drawing.Point(318, 12);
            this.btnInitGeneCodeByDynCompiler.Name = "btnInitGeneCodeByDynCompiler";
            this.btnInitGeneCodeByDynCompiler.Size = new System.Drawing.Size(202, 27);
            this.btnInitGeneCodeByDynCompiler.TabIndex = 10;
            this.btnInitGeneCodeByDynCompiler.Text = "动态编译类-生成代码初始化";
            this.btnInitGeneCodeByDynCompiler.UseVisualStyleBackColor = true;
            this.btnInitGeneCodeByDynCompiler.Click += new System.EventHandler(this.btnInitGeneCodeByDynCompiler_Click);
            // 
            // btnInitGeneCode
            // 
            this.btnInitGeneCode.Location = new System.Drawing.Point(526, 12);
            this.btnInitGeneCode.Name = "btnInitGeneCode";
            this.btnInitGeneCode.Size = new System.Drawing.Size(147, 27);
            this.btnInitGeneCode.TabIndex = 11;
            this.btnInitGeneCode.Text = "生成代码初始化";
            this.btnInitGeneCode.UseVisualStyleBackColor = true;
            this.btnInitGeneCode.Click += new System.EventHandler(this.btnInitGeneCode_Click);
            // 
            // btnInitGeneCode_ByGeneCode
            // 
            this.btnInitGeneCode_ByGeneCode.Location = new System.Drawing.Point(605, 67);
            this.btnInitGeneCode_ByGeneCode.Name = "btnInitGeneCode_ByGeneCode";
            this.btnInitGeneCode_ByGeneCode.Size = new System.Drawing.Size(215, 27);
            this.btnInitGeneCode_ByGeneCode.TabIndex = 12;
            this.btnInitGeneCode_ByGeneCode.Text = "生成代码初始化-用生成代码";
            this.btnInitGeneCode_ByGeneCode.UseVisualStyleBackColor = true;
            this.btnInitGeneCode_ByGeneCode.Click += new System.EventHandler(this.btnInitGeneCode_ByGeneCode_Click);
            // 
            // btnInitGeneCodeByDynCompiler4Tab
            // 
            this.btnInitGeneCodeByDynCompiler4Tab.Location = new System.Drawing.Point(318, 67);
            this.btnInitGeneCodeByDynCompiler4Tab.Name = "btnInitGeneCodeByDynCompiler4Tab";
            this.btnInitGeneCodeByDynCompiler4Tab.Size = new System.Drawing.Size(281, 27);
            this.btnInitGeneCodeByDynCompiler4Tab.TabIndex = 13;
            this.btnInitGeneCodeByDynCompiler4Tab.Text = "动态编译类-生成代码初始化-调表数据";
            this.btnInitGeneCodeByDynCompiler4Tab.UseVisualStyleBackColor = true;
            this.btnInitGeneCodeByDynCompiler4Tab.Click += new System.EventHandler(this.btnInitGeneCodeByDynCompiler4Tab_Click);
            // 
            // frmTestGeneCodeByDynamicCompiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 538);
            this.Controls.Add(this.btnInitGeneCodeByDynCompiler4Tab);
            this.Controls.Add(this.btnInitGeneCode_ByGeneCode);
            this.Controls.Add(this.btnInitGeneCode);
            this.Controls.Add(this.btnInitGeneCodeByDynCompiler);
            this.Controls.Add(this.btnExecCacheInitFunction);
            this.Controls.Add(this.btnAddCacheInitFunction);
            this.Controls.Add(this.btnInvokeFunctionByStrName);
            this.Controls.Add(this.btnTestCacheInit);
            this.Controls.Add(this.btnTestDynCompiler4CacheInit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTestCalc);
            this.Controls.Add(this.btnTestDynamicCompilerClass);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnDynCompAndExec);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "frmTestGeneCodeByDynamicCompiler";
            this.Text = "frmTestDynamicCompiler2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDynCompAndExec;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnTestDynamicCompilerClass;
        private System.Windows.Forms.Button btnTestCalc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTestDynCompiler4CacheInit;
        private System.Windows.Forms.Button btnTestCacheInit;
        private System.Windows.Forms.Button btnInvokeFunctionByStrName;
        private System.Windows.Forms.Button btnAddCacheInitFunction;
        private System.Windows.Forms.Button btnExecCacheInitFunction;
        private System.Windows.Forms.Button btnInitGeneCodeByDynCompiler;
        private System.Windows.Forms.Button btnInitGeneCode;
        private System.Windows.Forms.Button btnInitGeneCode_ByGeneCode;
        private System.Windows.Forms.Button btnInitGeneCodeByDynCompiler4Tab;
    }
}