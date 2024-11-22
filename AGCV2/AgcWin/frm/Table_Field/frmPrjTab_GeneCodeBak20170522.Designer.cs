﻿
namespace AGC
{
    /// <summary>
    ///		frmPrjTab_QD_LV 的摘要说明。
    /// </summary>
    partial class frmPrjTab_GeneCodeBak20180524
    {

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        #region 组件设计器生成的代码
        /// <summary> 
        /// 设计器支持所需的方法 - 不要使用代码编辑器 
        /// 修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTabName = new System.Windows.Forms.Label();
            this.txtTabName = new System.Windows.Forms.TextBox();
            this.lblPrjId = new System.Windows.Forms.Label();
            this.cboPrjId = new System.Windows.Forms.ComboBox();
            this.lblObjId = new System.Windows.Forms.Label();
            this.cboFuncModuleId = new System.Windows.Forms.ComboBox();
            this.lblSQLDSTypeId = new System.Windows.Forms.Label();
            this.cboSQLDSTypeId = new System.Windows.Forms.ComboBox();
            this.lblTabStateId = new System.Windows.Forms.Label();
            this.cboTabStateId = new System.Windows.Forms.ComboBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnDelRec = new System.Windows.Forms.Button();
            this.btnExportExcel4Dg = new System.Windows.Forms.Button();
            this.lblRecNum = new System.Windows.Forms.Label();
            this.lvvPrjTab = new System.Windows.Forms.ListView();
            this.gbQueryCondition = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblErrNum = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.flpClassNameButtonList = new System.Windows.Forms.FlowLayoutPanel();
            this.btnGeneEntityLayer = new System.Windows.Forms.Button();
            this.btnGenDALCode = new System.Windows.Forms.Button();
            this.btnGenDALExCode = new System.Windows.Forms.Button();
            this.btnBusinessLogicCode = new System.Windows.Forms.Button();
            this.btnBusinessLogicExCode = new System.Windows.Forms.Button();
            this.btnGeneCommFun4BL = new System.Windows.Forms.Button();
            this.btnGenWebServiceCode = new System.Windows.Forms.Button();
            this.btnGenWS_Access = new System.Windows.Forms.Button();
            this.btnGeneWS_AccessHigh = new System.Windows.Forms.Button();
            this.btnGeneAppController = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.rbMsSql = new System.Windows.Forms.RadioButton();
            this.rbOracle = new System.Windows.Forms.RadioButton();
            this.rbMySql = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.rbDotNet = new System.Windows.Forms.RadioButton();
            this.rbJava = new System.Windows.Forms.RadioButton();
            this.rbSwift = new System.Windows.Forms.RadioButton();
            this.rbJavaScript = new System.Windows.Forms.RadioButton();
            this.rbSilverLight = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCharEncodingId = new System.Windows.Forms.ComboBox();
            this.btnClearCache = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnGeneAllCheckedTableThreeLayer = new System.Windows.Forms.Button();
            this.btnCheckCheckedTabField = new System.Windows.Forms.Button();
            this.btnCheckAllTabField = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chkDispAllErrMsg = new System.Windows.Forms.CheckBox();
            this.btnQueryNoTimelyGeneTabs = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtFileName4GenCode = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtCodePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.gbQueryCondition.SuspendLayout();
            this.flpClassNameButtonList.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTabName
            // 
            this.lblTabName.Location = new System.Drawing.Point(3, 0);
            this.lblTabName.Name = "lblTabName";
            this.lblTabName.Size = new System.Drawing.Size(36, 18);
            this.lblTabName.TabIndex = 1;
            this.lblTabName.Text = "表名";
            // 
            // txtTabName
            // 
            this.txtTabName.Location = new System.Drawing.Point(45, 3);
            this.txtTabName.Name = "txtTabName";
            this.txtTabName.Size = new System.Drawing.Size(273, 23);
            this.txtTabName.TabIndex = 2;
            // 
            // lblPrjId
            // 
            this.lblPrjId.Location = new System.Drawing.Point(553, 0);
            this.lblPrjId.Name = "lblPrjId";
            this.lblPrjId.Size = new System.Drawing.Size(53, 18);
            this.lblPrjId.TabIndex = 3;
            this.lblPrjId.Text = "工程";
            // 
            // cboPrjId
            // 
            this.cboPrjId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPrjId.Location = new System.Drawing.Point(678, 3);
            this.cboPrjId.Name = "cboPrjId";
            this.cboPrjId.Size = new System.Drawing.Size(130, 22);
            this.cboPrjId.TabIndex = 4;
            // 
            // lblObjId
            // 
            this.lblObjId.Location = new System.Drawing.Point(3, 31);
            this.lblObjId.Name = "lblObjId";
            this.lblObjId.Size = new System.Drawing.Size(36, 18);
            this.lblObjId.TabIndex = 5;
            this.lblObjId.Text = "模块";
            // 
            // cboFuncModuleId
            // 
            this.cboFuncModuleId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFuncModuleId.Location = new System.Drawing.Point(45, 34);
            this.cboFuncModuleId.Name = "cboFuncModuleId";
            this.cboFuncModuleId.Size = new System.Drawing.Size(273, 22);
            this.cboFuncModuleId.TabIndex = 6;
            // 
            // lblSQLDSTypeId
            // 
            this.lblSQLDSTypeId.Location = new System.Drawing.Point(332, 0);
            this.lblSQLDSTypeId.Name = "lblSQLDSTypeId";
            this.lblSQLDSTypeId.Size = new System.Drawing.Size(77, 18);
            this.lblSQLDSTypeId.TabIndex = 7;
            this.lblSQLDSTypeId.Text = "数据源类型";
            // 
            // cboSQLDSTypeId
            // 
            this.cboSQLDSTypeId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSQLDSTypeId.Location = new System.Drawing.Point(415, 3);
            this.cboSQLDSTypeId.Name = "cboSQLDSTypeId";
            this.cboSQLDSTypeId.Size = new System.Drawing.Size(125, 22);
            this.cboSQLDSTypeId.TabIndex = 8;
            // 
            // lblTabStateId
            // 
            this.lblTabStateId.Location = new System.Drawing.Point(332, 31);
            this.lblTabStateId.Name = "lblTabStateId";
            this.lblTabStateId.Size = new System.Drawing.Size(70, 18);
            this.lblTabStateId.TabIndex = 9;
            this.lblTabStateId.Text = "表状态";
            // 
            // cboTabStateId
            // 
            this.cboTabStateId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTabStateId.Location = new System.Drawing.Point(415, 34);
            this.cboTabStateId.Name = "cboTabStateId";
            this.cboTabStateId.Size = new System.Drawing.Size(125, 22);
            this.cboTabStateId.TabIndex = 10;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(843, 34);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(63, 26);
            this.btnQuery.TabIndex = 16;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.Location = new System.Drawing.Point(12, 85);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(373, 41);
            this.lblMsg.TabIndex = 11;
            // 
            // btnDelRec
            // 
            this.btnDelRec.Location = new System.Drawing.Point(576, 57);
            this.btnDelRec.Name = "btnDelRec";
            this.btnDelRec.Size = new System.Drawing.Size(80, 26);
            this.btnDelRec.TabIndex = 14;
            this.btnDelRec.Text = "删除记录";
            this.btnDelRec.Click += new System.EventHandler(this.btnDelRec_Click);
            // 
            // btnExportExcel4Dg
            // 
            this.btnExportExcel4Dg.Location = new System.Drawing.Point(912, 3);
            this.btnExportExcel4Dg.Name = "btnExportExcel4Dg";
            this.btnExportExcel4Dg.Size = new System.Drawing.Size(80, 25);
            this.btnExportExcel4Dg.TabIndex = 15;
            this.btnExportExcel4Dg.Text = "导出Excel";
            this.btnExportExcel4Dg.Click += new System.EventHandler(this.btnExportExcel4Dg_Click);
            // 
            // lblRecNum
            // 
            this.lblRecNum.Location = new System.Drawing.Point(912, 31);
            this.lblRecNum.Name = "lblRecNum";
            this.lblRecNum.Size = new System.Drawing.Size(89, 16);
            this.lblRecNum.TabIndex = 17;
            this.lblRecNum.Text = "记录数：";
            // 
            // lvvPrjTab
            // 
            this.lvvPrjTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvvPrjTab.FullRowSelect = true;
            this.lvvPrjTab.Location = new System.Drawing.Point(3, 3);
            this.lvvPrjTab.Name = "lvvPrjTab";
            this.lvvPrjTab.Size = new System.Drawing.Size(1174, 448);
            this.lvvPrjTab.TabIndex = 18;
            this.lvvPrjTab.UseCompatibleStateImageBehavior = false;
            this.lvvPrjTab.View = System.Windows.Forms.View.Details;
            this.lvvPrjTab.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvvPrjTab_ColumnClick);
            this.lvvPrjTab.SelectedIndexChanged += new System.EventHandler(this.lvvPrjTab_SelectedIndexChanged);
            this.lvvPrjTab.Click += new System.EventHandler(this.lvvPrjTab_Click);
            // 
            // gbQueryCondition
            // 
            this.gbQueryCondition.Controls.Add(this.label4);
            this.gbQueryCondition.Controls.Add(this.lblStatus);
            this.gbQueryCondition.Controls.Add(this.lblErrNum);
            this.gbQueryCondition.Controls.Add(this.progressBar2);
            this.gbQueryCondition.Controls.Add(this.progressBar1);
            this.gbQueryCondition.Controls.Add(this.flpClassNameButtonList);
            this.gbQueryCondition.Controls.Add(this.flowLayoutPanel2);
            this.gbQueryCondition.Controls.Add(this.flowLayoutPanel1);
            this.gbQueryCondition.Controls.Add(this.label3);
            this.gbQueryCondition.Controls.Add(this.cboCharEncodingId);
            this.gbQueryCondition.Controls.Add(this.btnClearCache);
            this.gbQueryCondition.Controls.Add(this.flowLayoutPanel3);
            this.gbQueryCondition.Controls.Add(this.btnCheckCheckedTabField);
            this.gbQueryCondition.Controls.Add(this.btnCheckAllTabField);
            this.gbQueryCondition.Controls.Add(this.tableLayoutPanel1);
            this.gbQueryCondition.Controls.Add(this.btnDelRec);
            this.gbQueryCondition.Controls.Add(this.lblMsg);
            this.gbQueryCondition.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbQueryCondition.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbQueryCondition.Location = new System.Drawing.Point(0, 0);
            this.gbQueryCondition.Name = "gbQueryCondition";
            this.gbQueryCondition.Size = new System.Drawing.Size(1200, 207);
            this.gbQueryCondition.TabIndex = 19;
            this.gbQueryCondition.TabStop = false;
            this.gbQueryCondition.Text = "查询条件";
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(567, 177);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(321, 18);
            this.lblStatus.TabIndex = 44;
            this.lblStatus.Text = "生成状态";
            // 
            // lblErrNum
            // 
            this.lblErrNum.Location = new System.Drawing.Point(894, 180);
            this.lblErrNum.Name = "lblErrNum";
            this.lblErrNum.Size = new System.Drawing.Size(123, 18);
            this.lblErrNum.TabIndex = 43;
            this.lblErrNum.Text = "出错数";
            // 
            // progressBar2
            // 
            this.progressBar2.ForeColor = System.Drawing.Color.Red;
            this.progressBar2.Location = new System.Drawing.Point(1025, 177);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(117, 23);
            this.progressBar2.TabIndex = 42;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(183, 178);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(370, 23);
            this.progressBar1.TabIndex = 41;
            // 
            // flpClassNameButtonList
            // 
            this.flpClassNameButtonList.Controls.Add(this.btnGeneEntityLayer);
            this.flpClassNameButtonList.Controls.Add(this.btnGenDALCode);
            this.flpClassNameButtonList.Controls.Add(this.btnGenDALExCode);
            this.flpClassNameButtonList.Controls.Add(this.btnBusinessLogicCode);
            this.flpClassNameButtonList.Controls.Add(this.btnBusinessLogicExCode);
            this.flpClassNameButtonList.Controls.Add(this.btnGeneCommFun4BL);
            this.flpClassNameButtonList.Controls.Add(this.btnGenWebServiceCode);
            this.flpClassNameButtonList.Controls.Add(this.btnGenWS_Access);
            this.flpClassNameButtonList.Controls.Add(this.btnGeneWS_AccessHigh);
            this.flpClassNameButtonList.Controls.Add(this.btnGeneAppController);
            this.flpClassNameButtonList.Location = new System.Drawing.Point(18, 145);
            this.flpClassNameButtonList.Name = "flpClassNameButtonList";
            this.flpClassNameButtonList.Size = new System.Drawing.Size(1017, 28);
            this.flpClassNameButtonList.TabIndex = 39;
            // 
            // btnGeneEntityLayer
            // 
            this.btnGeneEntityLayer.Location = new System.Drawing.Point(3, 3);
            this.btnGeneEntityLayer.Name = "btnGeneEntityLayer";
            this.btnGeneEntityLayer.Size = new System.Drawing.Size(73, 26);
            this.btnGeneEntityLayer.TabIndex = 18;
            this.btnGeneEntityLayer.Text = "生成实体";
            this.btnGeneEntityLayer.Click += new System.EventHandler(this.btnGeneEntityLayer_Click);
            // 
            // btnGenDALCode
            // 
            this.btnGenDALCode.Location = new System.Drawing.Point(82, 3);
            this.btnGenDALCode.Name = "btnGenDALCode";
            this.btnGenDALCode.Size = new System.Drawing.Size(74, 26);
            this.btnGenDALCode.TabIndex = 20;
            this.btnGenDALCode.Text = "数据处理";
            this.btnGenDALCode.Click += new System.EventHandler(this.btnGenDALCode_Click);
            // 
            // btnGenDALExCode
            // 
            this.btnGenDALExCode.Location = new System.Drawing.Point(162, 3);
            this.btnGenDALExCode.Name = "btnGenDALExCode";
            this.btnGenDALExCode.Size = new System.Drawing.Size(102, 26);
            this.btnGenDALExCode.TabIndex = 41;
            this.btnGenDALExCode.Text = "数据处理扩展";
            this.btnGenDALExCode.Click += new System.EventHandler(this.btnGenDALExCode_Click);
            // 
            // btnBusinessLogicCode
            // 
            this.btnBusinessLogicCode.Location = new System.Drawing.Point(270, 3);
            this.btnBusinessLogicCode.Name = "btnBusinessLogicCode";
            this.btnBusinessLogicCode.Size = new System.Drawing.Size(76, 26);
            this.btnBusinessLogicCode.TabIndex = 21;
            this.btnBusinessLogicCode.Text = "业务逻辑";
            this.btnBusinessLogicCode.Click += new System.EventHandler(this.btnBusinessLogicCode_Click);
            // 
            // btnBusinessLogicExCode
            // 
            this.btnBusinessLogicExCode.Location = new System.Drawing.Point(352, 3);
            this.btnBusinessLogicExCode.Name = "btnBusinessLogicExCode";
            this.btnBusinessLogicExCode.Size = new System.Drawing.Size(103, 26);
            this.btnBusinessLogicExCode.TabIndex = 41;
            this.btnBusinessLogicExCode.Text = "业务逻辑扩展";
            this.btnBusinessLogicExCode.Click += new System.EventHandler(this.btnBusinessLogicExCode_Click);
            // 
            // btnGeneCommFun4BL
            // 
            this.btnGeneCommFun4BL.Location = new System.Drawing.Point(461, 3);
            this.btnGeneCommFun4BL.Name = "btnGeneCommFun4BL";
            this.btnGeneCommFun4BL.Size = new System.Drawing.Size(114, 26);
            this.btnGeneCommFun4BL.TabIndex = 41;
            this.btnGeneCommFun4BL.Text = "逻辑层公共函数";
            this.btnGeneCommFun4BL.Click += new System.EventHandler(this.btnGeneCommFun4BL_Click);
            // 
            // btnGenWebServiceCode
            // 
            this.btnGenWebServiceCode.Location = new System.Drawing.Point(581, 3);
            this.btnGenWebServiceCode.Name = "btnGenWebServiceCode";
            this.btnGenWebServiceCode.Size = new System.Drawing.Size(64, 26);
            this.btnGenWebServiceCode.TabIndex = 30;
            this.btnGenWebServiceCode.Text = "WEB服务";
            this.btnGenWebServiceCode.Click += new System.EventHandler(this.btnGenWebServiceCode_Click);
            // 
            // btnGenWS_Access
            // 
            this.btnGenWS_Access.Location = new System.Drawing.Point(651, 3);
            this.btnGenWS_Access.Name = "btnGenWS_Access";
            this.btnGenWS_Access.Size = new System.Drawing.Size(98, 26);
            this.btnGenWS_Access.TabIndex = 31;
            this.btnGenWS_Access.Text = "WEB服务访问";
            this.btnGenWS_Access.Click += new System.EventHandler(this.btnGenWS_Access_Click);
            // 
            // btnGeneWS_AccessHigh
            // 
            this.btnGeneWS_AccessHigh.Location = new System.Drawing.Point(755, 3);
            this.btnGeneWS_AccessHigh.Name = "btnGeneWS_AccessHigh";
            this.btnGeneWS_AccessHigh.Size = new System.Drawing.Size(126, 26);
            this.btnGeneWS_AccessHigh.TabIndex = 32;
            this.btnGeneWS_AccessHigh.Text = "Web服务单表控制";
            this.btnGeneWS_AccessHigh.UseVisualStyleBackColor = true;
            this.btnGeneWS_AccessHigh.Click += new System.EventHandler(this.btnGeneWS_AccessHigh_Click);
            // 
            // btnGeneAppController
            // 
            this.btnGeneAppController.Location = new System.Drawing.Point(887, 3);
            this.btnGeneAppController.Name = "btnGeneAppController";
            this.btnGeneAppController.Size = new System.Drawing.Size(99, 26);
            this.btnGeneAppController.TabIndex = 33;
            this.btnGeneAppController.Text = "Web服务控制";
            this.btnGeneAppController.UseVisualStyleBackColor = true;
            this.btnGeneAppController.Click += new System.EventHandler(this.btnGeneAppController_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.rbMsSql);
            this.flowLayoutPanel2.Controls.Add(this.rbOracle);
            this.flowLayoutPanel2.Controls.Add(this.rbMySql);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(547, 116);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(220, 26);
            this.flowLayoutPanel2.TabIndex = 38;
            // 
            // rbMsSql
            // 
            this.rbMsSql.AutoSize = true;
            this.rbMsSql.Checked = true;
            this.rbMsSql.Location = new System.Drawing.Point(3, 3);
            this.rbMsSql.Name = "rbMsSql";
            this.rbMsSql.Size = new System.Drawing.Size(67, 18);
            this.rbMsSql.TabIndex = 0;
            this.rbMsSql.TabStop = true;
            this.rbMsSql.Text = "Ms Sql";
            this.rbMsSql.UseVisualStyleBackColor = true;
            this.rbMsSql.CheckedChanged += new System.EventHandler(this.rbMsSql_CheckedChanged);
            // 
            // rbOracle
            // 
            this.rbOracle.AutoSize = true;
            this.rbOracle.Location = new System.Drawing.Point(76, 3);
            this.rbOracle.Name = "rbOracle";
            this.rbOracle.Size = new System.Drawing.Size(67, 18);
            this.rbOracle.TabIndex = 1;
            this.rbOracle.Text = "Oracle";
            this.rbOracle.UseVisualStyleBackColor = true;
            this.rbOracle.CheckedChanged += new System.EventHandler(this.rbOracle_CheckedChanged);
            // 
            // rbMySql
            // 
            this.rbMySql.AutoSize = true;
            this.rbMySql.Location = new System.Drawing.Point(149, 3);
            this.rbMySql.Name = "rbMySql";
            this.rbMySql.Size = new System.Drawing.Size(60, 18);
            this.rbMySql.TabIndex = 2;
            this.rbMySql.Text = "MySql";
            this.rbMySql.UseVisualStyleBackColor = true;
            this.rbMySql.CheckedChanged += new System.EventHandler(this.rbMySql_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.rbDotNet);
            this.flowLayoutPanel1.Controls.Add(this.rbJava);
            this.flowLayoutPanel1.Controls.Add(this.rbSwift);
            this.flowLayoutPanel1.Controls.Add(this.rbJavaScript);
            this.flowLayoutPanel1.Controls.Add(this.rbSilverLight);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(131, 117);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(411, 26);
            this.flowLayoutPanel1.TabIndex = 37;
            // 
            // rbDotNet
            // 
            this.rbDotNet.AutoSize = true;
            this.rbDotNet.Checked = true;
            this.rbDotNet.Location = new System.Drawing.Point(3, 3);
            this.rbDotNet.Name = "rbDotNet";
            this.rbDotNet.Size = new System.Drawing.Size(67, 18);
            this.rbDotNet.TabIndex = 0;
            this.rbDotNet.TabStop = true;
            this.rbDotNet.Text = "DotNet";
            this.rbDotNet.UseVisualStyleBackColor = true;
            this.rbDotNet.CheckedChanged += new System.EventHandler(this.rbDotNet_CheckedChanged);
            // 
            // rbJava
            // 
            this.rbJava.AutoSize = true;
            this.rbJava.Location = new System.Drawing.Point(76, 3);
            this.rbJava.Name = "rbJava";
            this.rbJava.Size = new System.Drawing.Size(53, 18);
            this.rbJava.TabIndex = 1;
            this.rbJava.Text = "Java";
            this.rbJava.UseVisualStyleBackColor = true;
            this.rbJava.CheckedChanged += new System.EventHandler(this.rbJava_CheckedChanged);
            // 
            // rbSwift
            // 
            this.rbSwift.AutoSize = true;
            this.rbSwift.Location = new System.Drawing.Point(135, 3);
            this.rbSwift.Name = "rbSwift";
            this.rbSwift.Size = new System.Drawing.Size(60, 18);
            this.rbSwift.TabIndex = 2;
            this.rbSwift.Text = "Swift";
            this.rbSwift.UseVisualStyleBackColor = true;
            this.rbSwift.CheckedChanged += new System.EventHandler(this.rbSwift_CheckedChanged);
            // 
            // rbJavaScript
            // 
            this.rbJavaScript.AutoSize = true;
            this.rbJavaScript.Location = new System.Drawing.Point(201, 3);
            this.rbJavaScript.Name = "rbJavaScript";
            this.rbJavaScript.Size = new System.Drawing.Size(95, 18);
            this.rbJavaScript.TabIndex = 3;
            this.rbJavaScript.Text = "JavaScript";
            this.rbJavaScript.UseVisualStyleBackColor = true;
            this.rbJavaScript.CheckedChanged += new System.EventHandler(this.rbJavaScript_CheckedChanged);
            // 
            // rbSilverLight
            // 
            this.rbSilverLight.AutoSize = true;
            this.rbSilverLight.Location = new System.Drawing.Point(302, 3);
            this.rbSilverLight.Name = "rbSilverLight";
            this.rbSilverLight.Size = new System.Drawing.Size(102, 18);
            this.rbSilverLight.TabIndex = 4;
            this.rbSilverLight.Text = "SilverLight";
            this.rbSilverLight.UseVisualStyleBackColor = true;
            this.rbSilverLight.CheckedChanged += new System.EventHandler(this.rbSilverLight_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(766, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 18);
            this.label3.TabIndex = 34;
            this.label3.Text = "生成文件字符编码";
            // 
            // cboCharEncodingId
            // 
            this.cboCharEncodingId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCharEncodingId.Location = new System.Drawing.Point(895, 88);
            this.cboCharEncodingId.Name = "cboCharEncodingId";
            this.cboCharEncodingId.Size = new System.Drawing.Size(273, 22);
            this.cboCharEncodingId.TabIndex = 33;
            // 
            // btnClearCache
            // 
            this.btnClearCache.Location = new System.Drawing.Point(641, 86);
            this.btnClearCache.Name = "btnClearCache";
            this.btnClearCache.Size = new System.Drawing.Size(119, 26);
            this.btnClearCache.TabIndex = 29;
            this.btnClearCache.Text = "清除缓存";
            this.btnClearCache.Click += new System.EventHandler(this.btnClearCache_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.btnGeneAllCheckedTableThreeLayer);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(1051, 144);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(144, 30);
            this.flowLayoutPanel3.TabIndex = 40;
            // 
            // btnGeneAllCheckedTableThreeLayer
            // 
            this.btnGeneAllCheckedTableThreeLayer.Location = new System.Drawing.Point(3, 3);
            this.btnGeneAllCheckedTableThreeLayer.Name = "btnGeneAllCheckedTableThreeLayer";
            this.btnGeneAllCheckedTableThreeLayer.Size = new System.Drawing.Size(119, 26);
            this.btnGeneAllCheckedTableThreeLayer.TabIndex = 25;
            this.btnGeneAllCheckedTableThreeLayer.Text = "生成所选表三层";
            this.btnGeneAllCheckedTableThreeLayer.Click += new System.EventHandler(this.btnGeneAllCheckedTableThreeLayer_Click);
            // 
            // btnCheckCheckedTabField
            // 
            this.btnCheckCheckedTabField.Location = new System.Drawing.Point(516, 85);
            this.btnCheckCheckedTabField.Name = "btnCheckCheckedTabField";
            this.btnCheckCheckedTabField.Size = new System.Drawing.Size(119, 26);
            this.btnCheckCheckedTabField.TabIndex = 28;
            this.btnCheckCheckedTabField.Text = "检查所选表字段";
            this.btnCheckCheckedTabField.Click += new System.EventHandler(this.btnCheckCheckedTabField_Click);
            // 
            // btnCheckAllTabField
            // 
            this.btnCheckAllTabField.Location = new System.Drawing.Point(391, 85);
            this.btnCheckAllTabField.Name = "btnCheckAllTabField";
            this.btnCheckAllTabField.Size = new System.Drawing.Size(119, 26);
            this.btnCheckAllTabField.TabIndex = 27;
            this.btnCheckAllTabField.Text = "检查所有表字段";
            this.btnCheckAllTabField.Click += new System.EventHandler(this.btnCheckAllTabField_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.84635F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.15366F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableLayoutPanel1.Controls.Add(this.chkDispAllErrMsg, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.cboPrjId, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPrjId, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboSQLDSTypeId, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSQLDSTypeId, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboTabStateId, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTabStateId, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.cboFuncModuleId, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblObjId, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTabName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtTabName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnExportExcel4Dg, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblRecNum, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnQueryNoTimelyGeneTabs, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnQuery, 6, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1013, 63);
            this.tableLayoutPanel1.TabIndex = 26;
            // 
            // chkDispAllErrMsg
            // 
            this.chkDispAllErrMsg.AutoSize = true;
            this.chkDispAllErrMsg.Checked = true;
            this.chkDispAllErrMsg.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDispAllErrMsg.Location = new System.Drawing.Point(553, 34);
            this.chkDispAllErrMsg.Name = "chkDispAllErrMsg";
            this.chkDispAllErrMsg.Size = new System.Drawing.Size(110, 18);
            this.chkDispAllErrMsg.TabIndex = 20;
            this.chkDispAllErrMsg.Text = "显示所有错误";
            this.chkDispAllErrMsg.UseVisualStyleBackColor = true;
            this.chkDispAllErrMsg.CheckedChanged += new System.EventHandler(this.chkDispAllErrMsg_CheckedChanged);
            // 
            // btnQueryNoTimelyGeneTabs
            // 
            this.btnQueryNoTimelyGeneTabs.Location = new System.Drawing.Point(678, 34);
            this.btnQueryNoTimelyGeneTabs.Name = "btnQueryNoTimelyGeneTabs";
            this.btnQueryNoTimelyGeneTabs.Size = new System.Drawing.Size(152, 26);
            this.btnQueryNoTimelyGeneTabs.TabIndex = 32;
            this.btnQueryNoTimelyGeneTabs.Text = "查询未及时生成表";
            this.toolTip1.SetToolTip(this.btnQueryNoTimelyGeneTabs, "显示所有已经修改过表属性，但是没有及时生成相关代码的表");
            this.btnQueryNoTimelyGeneTabs.Click += new System.EventHandler(this.btnQueryNoTimelyGeneTabs_Click);
            // 
            // txtCode
            // 
            this.txtCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCode.Location = new System.Drawing.Point(0, 0);
            this.txtCode.Multiline = true;
            this.txtCode.Name = "txtCode";
            this.txtCode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCode.Size = new System.Drawing.Size(1174, 417);
            this.txtCode.TabIndex = 20;
            this.txtCode.Click += new System.EventHandler(this.txtCode_Click);
            // 
            // txtFileName4GenCode
            // 
            this.txtFileName4GenCode.Location = new System.Drawing.Point(73, 3);
            this.txtFileName4GenCode.Name = "txtFileName4GenCode";
            this.txtFileName4GenCode.Size = new System.Drawing.Size(194, 23);
            this.txtFileName4GenCode.TabIndex = 21;
            this.txtFileName4GenCode.Click += new System.EventHandler(this.txtFileName4GenCode_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 213);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1188, 482);
            this.tabControl1.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lvvPrjTab);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1180, 454);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "工程表列表";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1180, 456);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "代码生成区";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtCodePath);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txtFileName4GenCode);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtCode);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(1174, 450);
            this.splitContainer1.SplitterDistance = 29;
            this.splitContainer1.TabIndex = 21;
            // 
            // txtCodePath
            // 
            this.txtCodePath.Location = new System.Drawing.Point(326, 6);
            this.txtCodePath.Name = "txtCodePath";
            this.txtCodePath.Size = new System.Drawing.Size(644, 23);
            this.txtCodePath.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(273, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "目录：";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "文件名：";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "提示信息：";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 14);
            this.label4.TabIndex = 45;
            this.label4.Text = "生成进度：";
            // 
            // frmPrjTab_GeneCodeBak20180524Bak20180524
            // 
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.gbQueryCondition);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "frmPrjTab_GeneCodeBak20180524Bak20180524";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "项目表－代码生成20170427";
            this.Load += new System.EventHandler(this.frmPrjTab_QD_Load);
            this.gbQueryCondition.ResumeLayout(false);
            this.gbQueryCondition.PerformLayout();
            this.flpClassNameButtonList.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.Label lblTabName;
        private System.Windows.Forms.TextBox txtTabName;
        private System.Windows.Forms.Label lblPrjId;
        private System.Windows.Forms.ComboBox cboPrjId;
        private System.Windows.Forms.Label lblObjId;
        private System.Windows.Forms.ComboBox cboFuncModuleId;
        private System.Windows.Forms.Label lblSQLDSTypeId;
        private System.Windows.Forms.ComboBox cboSQLDSTypeId;
        private System.Windows.Forms.Label lblTabStateId;
        private System.Windows.Forms.ComboBox cboTabStateId;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label lblMsg;


        private System.Windows.Forms.Button btnDelRec;
        private System.Windows.Forms.Button btnExportExcel4Dg;
        private System.Windows.Forms.Label lblRecNum;
        private System.Windows.Forms.GroupBox gbQueryCondition;
        private System.Windows.Forms.ListView lvvPrjTab;
        private System.Windows.Forms.Button btnGeneEntityLayer;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtFileName4GenCode;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBusinessLogicCode;
        private System.Windows.Forms.Button btnGenDALCode;
        private System.Windows.Forms.Button btnGeneAllCheckedTableThreeLayer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox chkDispAllErrMsg;
        private System.Windows.Forms.TextBox txtCodePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCheckAllTabField;
        private System.Windows.Forms.Button btnCheckCheckedTabField;
        private System.Windows.Forms.Button btnClearCache;
        private System.Windows.Forms.Button btnGenWebServiceCode;
        private System.Windows.Forms.Button btnGenWS_Access;
        private System.Windows.Forms.Button btnQueryNoTimelyGeneTabs;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCharEncodingId;
        private System.Windows.Forms.RadioButton rbMsSql;
        private System.Windows.Forms.RadioButton rbOracle;
        private System.Windows.Forms.RadioButton rbMySql;
        private System.Windows.Forms.RadioButton rbJava;
        private System.Windows.Forms.RadioButton rbDotNet;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton rbSwift;
        private System.Windows.Forms.RadioButton rbJavaScript;
        private System.Windows.Forms.RadioButton rbSilverLight;
        private System.Windows.Forms.FlowLayoutPanel flpClassNameButtonList;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button btnGeneWS_AccessHigh;
        private System.Windows.Forms.Button btnGeneAppController;
        private System.Windows.Forms.Button btnGeneCommFun4BL;
        private System.Windows.Forms.Button btnGenDALExCode;
        private System.Windows.Forms.Button btnBusinessLogicExCode;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label lblErrNum;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label4;
    }
}