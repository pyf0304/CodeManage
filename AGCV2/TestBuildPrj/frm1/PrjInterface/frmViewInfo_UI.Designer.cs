
///----------------------
///���ɴ���汾��2012.01.02.1
///�������ڣ�2012/10/17
///�����ߣ����Է�
///�������ƣ�AGC_CSV7
///����ID��0005
///ģ������������Ŀ�������
///ģ��Ӣ������PrjInterface
///ע�⣺1����Ҫ���ݵײ㣨PubDataBase.dll���İ汾��2011.05.08.1
///       2����Ҫ���������㣨TzPubFunction.dll���İ汾��2011.05.08.1
///========================
namespace AGC_CSV7
{
/// <summary>
///		frmViewInfo_UI ��ժҪ˵����
/// </summary>
partial class frmViewInfo_UI
{
/// <summary> 
/// ����������������
/// </summary>
private System.ComponentModel.Container components = null;

/// <summary> 
/// ������������ʹ�õ���Դ��
/// </summary>
protected override void Dispose( bool disposing )
{
if( disposing )
{
if(components != null)
{
components.Dispose();
}
}
base.Dispose( disposing );
}
#region �����������ɵĴ���
/// <summary> 
/// �����֧������ķ��� - ��Ҫʹ�ô���༭�� 
/// �޸Ĵ˷��������ݡ�
/// </summary>
private void InitializeComponent()
{
this.lblViewId = new System.Windows.Forms.Label();
this.txtViewId = new System.Windows.Forms.TextBox();
this.lblViewName = new System.Windows.Forms.Label();
this.txtViewName = new System.Windows.Forms.TextBox();
this.lblViewTypeCode = new System.Windows.Forms.Label();
this.cboViewTypeCode = new System.Windows.Forms.ComboBox();
this.lblApplicationTypeId = new System.Windows.Forms.Label();
this.cboApplicationTypeId = new System.Windows.Forms.ComboBox();
this.lblFuncModuleId = new System.Windows.Forms.Label();
this.cboFuncModuleId = new System.Windows.Forms.ComboBox();
this.lblDataBaseName = new System.Windows.Forms.Label();
this.txtDataBaseName = new System.Windows.Forms.TextBox();
this.lblKeyForMainTab = new System.Windows.Forms.Label();
this.txtKeyForMainTab = new System.Windows.Forms.TextBox();
this.lblKeyForDetailTab = new System.Windows.Forms.Label();
this.txtKeyForDetailTab = new System.Windows.Forms.TextBox();
this.lblIsNeedSort = new System.Windows.Forms.Label();
this.chkIsNeedSort = new System.Windows.Forms.CheckBox();
this.lblIsNeedTransCode = new System.Windows.Forms.Label();
this.chkIsNeedTransCode = new System.Windows.Forms.CheckBox();
this.lblUserId = new System.Windows.Forms.Label();
this.cboUserId = new System.Windows.Forms.ComboBox();
this.lblPrjId = new System.Windows.Forms.Label();
this.cboPrjId = new System.Windows.Forms.ComboBox();
this.lblViewFunction = new System.Windows.Forms.Label();
this.txtViewFunction = new System.Windows.Forms.TextBox();
this.lblViewDetail = new System.Windows.Forms.Label();
this.txtViewDetail = new System.Windows.Forms.TextBox();
this.lblDefaMenuName = new System.Windows.Forms.Label();
this.txtDefaMenuName = new System.Windows.Forms.TextBox();
this.lblDetailTabId = new System.Windows.Forms.Label();
this.cboDetailTabId = new System.Windows.Forms.ComboBox();
this.lblFileName = new System.Windows.Forms.Label();
this.txtFileName = new System.Windows.Forms.TextBox();
this.lblFilePath = new System.Windows.Forms.Label();
this.txtFilePath = new System.Windows.Forms.TextBox();
this.lblMainTabId = new System.Windows.Forms.Label();
this.txtMainTabId = new System.Windows.Forms.TextBox();
this.lblViewCnName = new System.Windows.Forms.Label();
this.txtViewCnName = new System.Windows.Forms.TextBox();
this.lblViewGroupId = new System.Windows.Forms.Label();
this.cboViewGroupId = new System.Windows.Forms.ComboBox();
this.lblINRelaTabId = new System.Windows.Forms.Label();
this.cboINRelaTabId = new System.Windows.Forms.ComboBox();
this.lblINSQLDSTypeId = new System.Windows.Forms.Label();
this.cboINSQLDSTypeId = new System.Windows.Forms.ComboBox();
this.lblOUTRelaTabId = new System.Windows.Forms.Label();
this.cboOUTRelaTabId = new System.Windows.Forms.ComboBox();
this.lblOUTSQLDSTypeId = new System.Windows.Forms.Label();
this.cboOUTSQLDSTypeId = new System.Windows.Forms.ComboBox();
this.lblDetailTabType = new System.Windows.Forms.Label();
this.txtDetailTabType = new System.Windows.Forms.TextBox();
this.lblDetailViewId = new System.Windows.Forms.Label();
this.txtDetailViewId = new System.Windows.Forms.TextBox();
this.lblMainTabType = new System.Windows.Forms.Label();
this.txtMainTabType = new System.Windows.Forms.TextBox();
this.lblMainViewId = new System.Windows.Forms.Label();
this.txtMainViewId = new System.Windows.Forms.TextBox();
this.lblUpdDate = new System.Windows.Forms.Label();
this.txtUpdDate = new System.Windows.Forms.TextBox();
this.lblMsg = new System.Windows.Forms.Label();
this.btnOKUpd = new System.Windows.Forms.Button();
this.btnClose = new System.Windows.Forms.Button();
this.SuspendLayout();
//
// lblViewId
//
this.lblViewId.Location = new System.Drawing.Point(10, 10);
this.lblViewId.Name = "lblViewId";
this.lblViewId.Size = new System.Drawing.Size(70, 18);
this.lblViewId.TabIndex = 1;
this.lblViewId.Text = "����ID";
//
// txtViewId
//
this.txtViewId.Location = new System.Drawing.Point(90, 10);
this.txtViewId.Name = "txtViewId";
this.txtViewId.Size = new System.Drawing.Size(100, 20);
this.txtViewId.TabIndex = 2;
this.txtViewId.Text = "";
//
// lblViewName
//
this.lblViewName.Location = new System.Drawing.Point(260, 10);
this.lblViewName.Name = "lblViewName";
this.lblViewName.Size = new System.Drawing.Size(70, 18);
this.lblViewName.TabIndex = 3;
this.lblViewName.Text = "��������";
//
// txtViewName
//
this.txtViewName.Location = new System.Drawing.Point(340, 10);
this.txtViewName.Name = "txtViewName";
this.txtViewName.Size = new System.Drawing.Size(100, 20);
this.txtViewName.TabIndex = 4;
this.txtViewName.Text = "";
//
// lblViewTypeCode
//
this.lblViewTypeCode.Location = new System.Drawing.Point(10, 40);
this.lblViewTypeCode.Name = "lblViewTypeCode";
this.lblViewTypeCode.Size = new System.Drawing.Size(70, 18);
this.lblViewTypeCode.TabIndex = 5;
this.lblViewTypeCode.Text = "����������";
//
// cboViewTypeCode
//
this.cboViewTypeCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
this.cboViewTypeCode.Location = new System.Drawing.Point(90, 40);
this.cboViewTypeCode.Name = "cboViewTypeCode";
this.cboViewTypeCode.Size = new System.Drawing.Size(100, 20);
this.cboViewTypeCode.TabIndex = 6;
this.cboViewTypeCode.Text = "";
//
// lblApplicationTypeId
//
this.lblApplicationTypeId.Location = new System.Drawing.Point(260, 40);
this.lblApplicationTypeId.Name = "lblApplicationTypeId";
this.lblApplicationTypeId.Size = new System.Drawing.Size(70, 18);
this.lblApplicationTypeId.TabIndex = 7;
this.lblApplicationTypeId.Text = "Ӧ�ó�������ID";
//
// cboApplicationTypeId
//
this.cboApplicationTypeId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
this.cboApplicationTypeId.Location = new System.Drawing.Point(340, 40);
this.cboApplicationTypeId.Name = "cboApplicationTypeId";
this.cboApplicationTypeId.Size = new System.Drawing.Size(100, 20);
this.cboApplicationTypeId.TabIndex = 8;
this.cboApplicationTypeId.Text = "";
//
// lblFuncModuleId
//
this.lblFuncModuleId.Location = new System.Drawing.Point(10, 70);
this.lblFuncModuleId.Name = "lblFuncModuleId";
this.lblFuncModuleId.Size = new System.Drawing.Size(70, 18);
this.lblFuncModuleId.TabIndex = 9;
this.lblFuncModuleId.Text = "����ģ��Id";
//
// cboFuncModuleId
//
this.cboFuncModuleId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
this.cboFuncModuleId.Location = new System.Drawing.Point(90, 70);
this.cboFuncModuleId.Name = "cboFuncModuleId";
this.cboFuncModuleId.Size = new System.Drawing.Size(100, 20);
this.cboFuncModuleId.TabIndex = 10;
this.cboFuncModuleId.Text = "";
//
// lblDataBaseName
//
this.lblDataBaseName.Location = new System.Drawing.Point(260, 70);
this.lblDataBaseName.Name = "lblDataBaseName";
this.lblDataBaseName.Size = new System.Drawing.Size(70, 18);
this.lblDataBaseName.TabIndex = 11;
this.lblDataBaseName.Text = "���ݿ���";
//
// txtDataBaseName
//
this.txtDataBaseName.Location = new System.Drawing.Point(340, 70);
this.txtDataBaseName.Name = "txtDataBaseName";
this.txtDataBaseName.Size = new System.Drawing.Size(100, 20);
this.txtDataBaseName.TabIndex = 12;
this.txtDataBaseName.Text = "";
//
// lblKeyForMainTab
//
this.lblKeyForMainTab.Location = new System.Drawing.Point(10, 100);
this.lblKeyForMainTab.Name = "lblKeyForMainTab";
this.lblKeyForMainTab.Size = new System.Drawing.Size(70, 18);
this.lblKeyForMainTab.TabIndex = 13;
this.lblKeyForMainTab.Text = "����ؼ���";
//
// txtKeyForMainTab
//
this.txtKeyForMainTab.Location = new System.Drawing.Point(90, 100);
this.txtKeyForMainTab.Name = "txtKeyForMainTab";
this.txtKeyForMainTab.Size = new System.Drawing.Size(100, 20);
this.txtKeyForMainTab.TabIndex = 14;
this.txtKeyForMainTab.Text = "";
//
// lblKeyForDetailTab
//
this.lblKeyForDetailTab.Location = new System.Drawing.Point(260, 100);
this.lblKeyForDetailTab.Name = "lblKeyForDetailTab";
this.lblKeyForDetailTab.Size = new System.Drawing.Size(70, 18);
this.lblKeyForDetailTab.TabIndex = 15;
this.lblKeyForDetailTab.Text = "��ϸ��ؼ���";
//
// txtKeyForDetailTab
//
this.txtKeyForDetailTab.Location = new System.Drawing.Point(340, 100);
this.txtKeyForDetailTab.Name = "txtKeyForDetailTab";
this.txtKeyForDetailTab.Size = new System.Drawing.Size(100, 20);
this.txtKeyForDetailTab.TabIndex = 16;
this.txtKeyForDetailTab.Text = "";
//
// chkIsNeedSort
//
this.chkIsNeedSort.Location = new System.Drawing.Point(10, 130);
this.chkIsNeedSort.Name = "chkIsNeedSort";
this.chkIsNeedSort.Size = new System.Drawing.Size(100, 20);
this.chkIsNeedSort.TabIndex = 17;
this.chkIsNeedSort.Text = "�Ƿ���Ҫ����";
//
// chkIsNeedTransCode
//
this.chkIsNeedTransCode.Location = new System.Drawing.Point(260, 130);
this.chkIsNeedTransCode.Name = "chkIsNeedTransCode";
this.chkIsNeedTransCode.Size = new System.Drawing.Size(100, 20);
this.chkIsNeedTransCode.TabIndex = 18;
this.chkIsNeedTransCode.Text = "�Ƿ���Ҫת������";
//
// lblUserId
//
this.lblUserId.Location = new System.Drawing.Point(10, 160);
this.lblUserId.Name = "lblUserId";
this.lblUserId.Size = new System.Drawing.Size(70, 18);
this.lblUserId.TabIndex = 19;
this.lblUserId.Text = "�û�ID";
//
// cboUserId
//
this.cboUserId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
this.cboUserId.Location = new System.Drawing.Point(90, 160);
this.cboUserId.Name = "cboUserId";
this.cboUserId.Size = new System.Drawing.Size(100, 20);
this.cboUserId.TabIndex = 20;
this.cboUserId.Text = "";
//
// lblPrjId
//
this.lblPrjId.Location = new System.Drawing.Point(260, 160);
this.lblPrjId.Name = "lblPrjId";
this.lblPrjId.Size = new System.Drawing.Size(70, 18);
this.lblPrjId.TabIndex = 21;
this.lblPrjId.Text = "����ID";
//
// cboPrjId
//
this.cboPrjId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
this.cboPrjId.Location = new System.Drawing.Point(340, 160);
this.cboPrjId.Name = "cboPrjId";
this.cboPrjId.Size = new System.Drawing.Size(100, 20);
this.cboPrjId.TabIndex = 22;
this.cboPrjId.Text = "";
//
// lblViewFunction
//
this.lblViewFunction.Location = new System.Drawing.Point(10, 190);
this.lblViewFunction.Name = "lblViewFunction";
this.lblViewFunction.Size = new System.Drawing.Size(70, 18);
this.lblViewFunction.TabIndex = 23;
this.lblViewFunction.Text = "���湦��";
//
// txtViewFunction
//
this.txtViewFunction.Location = new System.Drawing.Point(90, 190);
this.txtViewFunction.Name = "txtViewFunction";
this.txtViewFunction.Size = new System.Drawing.Size(100, 20);
this.txtViewFunction.TabIndex = 24;
this.txtViewFunction.Text = "";
//
// lblViewDetail
//
this.lblViewDetail.Location = new System.Drawing.Point(260, 190);
this.lblViewDetail.Name = "lblViewDetail";
this.lblViewDetail.Size = new System.Drawing.Size(70, 18);
this.lblViewDetail.TabIndex = 25;
this.lblViewDetail.Text = "����˵��";
//
// txtViewDetail
//
this.txtViewDetail.Location = new System.Drawing.Point(340, 190);
this.txtViewDetail.Name = "txtViewDetail";
this.txtViewDetail.Size = new System.Drawing.Size(100, 20);
this.txtViewDetail.TabIndex = 26;
this.txtViewDetail.Text = "";
//
// lblDefaMenuName
//
this.lblDefaMenuName.Location = new System.Drawing.Point(10, 220);
this.lblDefaMenuName.Name = "lblDefaMenuName";
this.lblDefaMenuName.Size = new System.Drawing.Size(70, 18);
this.lblDefaMenuName.TabIndex = 27;
this.lblDefaMenuName.Text = "ȱʡ�˵���";
//
// txtDefaMenuName
//
this.txtDefaMenuName.Location = new System.Drawing.Point(90, 220);
this.txtDefaMenuName.Name = "txtDefaMenuName";
this.txtDefaMenuName.Size = new System.Drawing.Size(100, 20);
this.txtDefaMenuName.TabIndex = 28;
this.txtDefaMenuName.Text = "";
//
// lblDetailTabId
//
this.lblDetailTabId.Location = new System.Drawing.Point(260, 220);
this.lblDetailTabId.Name = "lblDetailTabId";
this.lblDetailTabId.Size = new System.Drawing.Size(70, 18);
this.lblDetailTabId.TabIndex = 29;
this.lblDetailTabId.Text = "��ϸ��ID";
//
// cboDetailTabId
//
this.cboDetailTabId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
this.cboDetailTabId.Location = new System.Drawing.Point(340, 220);
this.cboDetailTabId.Name = "cboDetailTabId";
this.cboDetailTabId.Size = new System.Drawing.Size(100, 20);
this.cboDetailTabId.TabIndex = 30;
this.cboDetailTabId.Text = "";
//
// lblFileName
//
this.lblFileName.Location = new System.Drawing.Point(10, 250);
this.lblFileName.Name = "lblFileName";
this.lblFileName.Size = new System.Drawing.Size(70, 18);
this.lblFileName.TabIndex = 31;
this.lblFileName.Text = "�ļ���";
//
// txtFileName
//
this.txtFileName.Location = new System.Drawing.Point(90, 250);
this.txtFileName.Name = "txtFileName";
this.txtFileName.Size = new System.Drawing.Size(100, 20);
this.txtFileName.TabIndex = 32;
this.txtFileName.Text = "";
//
// lblFilePath
//
this.lblFilePath.Location = new System.Drawing.Point(260, 250);
this.lblFilePath.Name = "lblFilePath";
this.lblFilePath.Size = new System.Drawing.Size(70, 18);
this.lblFilePath.TabIndex = 33;
this.lblFilePath.Text = "�ļ�·��";
//
// txtFilePath
//
this.txtFilePath.Location = new System.Drawing.Point(340, 250);
this.txtFilePath.Name = "txtFilePath";
this.txtFilePath.Size = new System.Drawing.Size(100, 20);
this.txtFilePath.TabIndex = 34;
this.txtFilePath.Text = "";
//
// lblMainTabId
//
this.lblMainTabId.Location = new System.Drawing.Point(10, 280);
this.lblMainTabId.Name = "lblMainTabId";
this.lblMainTabId.Size = new System.Drawing.Size(70, 18);
this.lblMainTabId.TabIndex = 35;
this.lblMainTabId.Text = "����ID";
//
// txtMainTabId
//
this.txtMainTabId.Location = new System.Drawing.Point(90, 280);
this.txtMainTabId.Name = "txtMainTabId";
this.txtMainTabId.Size = new System.Drawing.Size(100, 20);
this.txtMainTabId.TabIndex = 36;
this.txtMainTabId.Text = "";
//
// lblViewCnName
//
this.lblViewCnName.Location = new System.Drawing.Point(260, 280);
this.lblViewCnName.Name = "lblViewCnName";
this.lblViewCnName.Size = new System.Drawing.Size(70, 18);
this.lblViewCnName.TabIndex = 37;
this.lblViewCnName.Text = "��ͼ������";
//
// txtViewCnName
//
this.txtViewCnName.Location = new System.Drawing.Point(340, 280);
this.txtViewCnName.Name = "txtViewCnName";
this.txtViewCnName.Size = new System.Drawing.Size(100, 20);
this.txtViewCnName.TabIndex = 38;
this.txtViewCnName.Text = "";
//
// lblViewGroupId
//
this.lblViewGroupId.Location = new System.Drawing.Point(10, 310);
this.lblViewGroupId.Name = "lblViewGroupId";
this.lblViewGroupId.Size = new System.Drawing.Size(70, 18);
this.lblViewGroupId.TabIndex = 39;
this.lblViewGroupId.Text = "������ID";
//
// cboViewGroupId
//
this.cboViewGroupId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
this.cboViewGroupId.Location = new System.Drawing.Point(90, 310);
this.cboViewGroupId.Name = "cboViewGroupId";
this.cboViewGroupId.Size = new System.Drawing.Size(100, 20);
this.cboViewGroupId.TabIndex = 40;
this.cboViewGroupId.Text = "";
//
// lblINRelaTabId
//
this.lblINRelaTabId.Location = new System.Drawing.Point(260, 310);
this.lblINRelaTabId.Name = "lblINRelaTabId";
this.lblINRelaTabId.Size = new System.Drawing.Size(70, 18);
this.lblINRelaTabId.TabIndex = 41;
this.lblINRelaTabId.Text = "��������Դ��ID";
//
// cboINRelaTabId
//
this.cboINRelaTabId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
this.cboINRelaTabId.Location = new System.Drawing.Point(340, 310);
this.cboINRelaTabId.Name = "cboINRelaTabId";
this.cboINRelaTabId.Size = new System.Drawing.Size(100, 20);
this.cboINRelaTabId.TabIndex = 42;
this.cboINRelaTabId.Text = "";
//
// lblINSQLDSTypeId
//
this.lblINSQLDSTypeId.Location = new System.Drawing.Point(10, 340);
this.lblINSQLDSTypeId.Name = "lblINSQLDSTypeId";
this.lblINSQLDSTypeId.Size = new System.Drawing.Size(70, 18);
this.lblINSQLDSTypeId.TabIndex = 43;
this.lblINSQLDSTypeId.Text = "��������Դ����";
//
// cboINSQLDSTypeId
//
this.cboINSQLDSTypeId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
this.cboINSQLDSTypeId.Location = new System.Drawing.Point(90, 340);
this.cboINSQLDSTypeId.Name = "cboINSQLDSTypeId";
this.cboINSQLDSTypeId.Size = new System.Drawing.Size(100, 20);
this.cboINSQLDSTypeId.TabIndex = 44;
this.cboINSQLDSTypeId.Text = "";
//
// lblOUTRelaTabId
//
this.lblOUTRelaTabId.Location = new System.Drawing.Point(260, 340);
this.lblOUTRelaTabId.Name = "lblOUTRelaTabId";
this.lblOUTRelaTabId.Size = new System.Drawing.Size(70, 18);
this.lblOUTRelaTabId.TabIndex = 45;
this.lblOUTRelaTabId.Text = "�������Դ��ID";
//
// cboOUTRelaTabId
//
this.cboOUTRelaTabId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
this.cboOUTRelaTabId.Location = new System.Drawing.Point(340, 340);
this.cboOUTRelaTabId.Name = "cboOUTRelaTabId";
this.cboOUTRelaTabId.Size = new System.Drawing.Size(100, 20);
this.cboOUTRelaTabId.TabIndex = 46;
this.cboOUTRelaTabId.Text = "";
//
// lblOUTSQLDSTypeId
//
this.lblOUTSQLDSTypeId.Location = new System.Drawing.Point(10, 370);
this.lblOUTSQLDSTypeId.Name = "lblOUTSQLDSTypeId";
this.lblOUTSQLDSTypeId.Size = new System.Drawing.Size(70, 18);
this.lblOUTSQLDSTypeId.TabIndex = 47;
this.lblOUTSQLDSTypeId.Text = "�������Դ����";
//
// cboOUTSQLDSTypeId
//
this.cboOUTSQLDSTypeId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
this.cboOUTSQLDSTypeId.Location = new System.Drawing.Point(90, 370);
this.cboOUTSQLDSTypeId.Name = "cboOUTSQLDSTypeId";
this.cboOUTSQLDSTypeId.Size = new System.Drawing.Size(100, 20);
this.cboOUTSQLDSTypeId.TabIndex = 48;
this.cboOUTSQLDSTypeId.Text = "";
//
// lblDetailTabType
//
this.lblDetailTabType.Location = new System.Drawing.Point(260, 370);
this.lblDetailTabType.Name = "lblDetailTabType";
this.lblDetailTabType.Size = new System.Drawing.Size(70, 18);
this.lblDetailTabType.TabIndex = 49;
this.lblDetailTabType.Text = "DetailTabType";
//
// txtDetailTabType
//
this.txtDetailTabType.Location = new System.Drawing.Point(340, 370);
this.txtDetailTabType.Name = "txtDetailTabType";
this.txtDetailTabType.Size = new System.Drawing.Size(100, 20);
this.txtDetailTabType.TabIndex = 50;
this.txtDetailTabType.Text = "";
//
// lblDetailViewId
//
this.lblDetailViewId.Location = new System.Drawing.Point(10, 400);
this.lblDetailViewId.Name = "lblDetailViewId";
this.lblDetailViewId.Size = new System.Drawing.Size(70, 18);
this.lblDetailViewId.TabIndex = 51;
this.lblDetailViewId.Text = "DetailViewId";
//
// txtDetailViewId
//
this.txtDetailViewId.Location = new System.Drawing.Point(90, 400);
this.txtDetailViewId.Name = "txtDetailViewId";
this.txtDetailViewId.Size = new System.Drawing.Size(100, 20);
this.txtDetailViewId.TabIndex = 52;
this.txtDetailViewId.Text = "";
//
// lblMainTabType
//
this.lblMainTabType.Location = new System.Drawing.Point(260, 400);
this.lblMainTabType.Name = "lblMainTabType";
this.lblMainTabType.Size = new System.Drawing.Size(70, 18);
this.lblMainTabType.TabIndex = 53;
this.lblMainTabType.Text = "MainTabType";
//
// txtMainTabType
//
this.txtMainTabType.Location = new System.Drawing.Point(340, 400);
this.txtMainTabType.Name = "txtMainTabType";
this.txtMainTabType.Size = new System.Drawing.Size(100, 20);
this.txtMainTabType.TabIndex = 54;
this.txtMainTabType.Text = "";
//
// lblMainViewId
//
this.lblMainViewId.Location = new System.Drawing.Point(10, 430);
this.lblMainViewId.Name = "lblMainViewId";
this.lblMainViewId.Size = new System.Drawing.Size(70, 18);
this.lblMainViewId.TabIndex = 55;
this.lblMainViewId.Text = "MainViewId";
//
// txtMainViewId
//
this.txtMainViewId.Location = new System.Drawing.Point(90, 430);
this.txtMainViewId.Name = "txtMainViewId";
this.txtMainViewId.Size = new System.Drawing.Size(100, 20);
this.txtMainViewId.TabIndex = 56;
this.txtMainViewId.Text = "";
//
// lblUpdDate
//
this.lblUpdDate.Location = new System.Drawing.Point(260, 430);
this.lblUpdDate.Name = "lblUpdDate";
this.lblUpdDate.Size = new System.Drawing.Size(70, 18);
this.lblUpdDate.TabIndex = 57;
this.lblUpdDate.Text = "�޸�����";
//
// txtUpdDate
//
this.txtUpdDate.Location = new System.Drawing.Point(340, 430);
this.txtUpdDate.Name = "txtUpdDate";
this.txtUpdDate.Size = new System.Drawing.Size(100, 20);
this.txtUpdDate.TabIndex = 58;
this.txtUpdDate.Text = "";
// 
// btnOKUpd
// 
this.btnOKUpd.Font = new System.Drawing.Font("����", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
this.btnOKUpd.Location = new System.Drawing.Point(125, 65);
this.btnOKUpd.Name = "btnOKUpd";
this.btnOKUpd.Size = new System.Drawing.Size(80, 30);
this.btnOKUpd.TabIndex = 59;
this.btnOKUpd.Text = "���";
this.btnOKUpd.Click += new System.EventHandler(this.btnOKUpd_Click);
// 
// btnClose
// 
this.btnClose.Font = new System.Drawing.Font("����", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
this.btnClose.Location = new System.Drawing.Point(245, 65);
this.btnClose.Name = "btnClose";
this.btnClose.Size = new System.Drawing.Size(80, 30);
this.btnClose.TabIndex = 60;
this.btnClose.Text = "�ر�";
this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
// 
// lblMsg
// 
this.lblMsg.Location = new System.Drawing.Point(125, 95);
this.lblMsg.Name = "lblMsg";
this.lblMsg.Size = new System.Drawing.Size(128, 16);
this.lblMsg.TabIndex = 61;
// 
// frmViewInfo_UI
// 
this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
this.ClientSize = new System.Drawing.Size(530, 135);
this.Controls.Add(this.lblViewId);
this.Controls.Add(this.txtViewId);
this.Controls.Add(this.lblViewName);
this.Controls.Add(this.txtViewName);
this.Controls.Add(this.lblViewTypeCode);
this.Controls.Add(this.cboViewTypeCode);
this.Controls.Add(this.lblApplicationTypeId);
this.Controls.Add(this.cboApplicationTypeId);
this.Controls.Add(this.lblFuncModuleId);
this.Controls.Add(this.cboFuncModuleId);
this.Controls.Add(this.lblDataBaseName);
this.Controls.Add(this.txtDataBaseName);
this.Controls.Add(this.lblKeyForMainTab);
this.Controls.Add(this.txtKeyForMainTab);
this.Controls.Add(this.lblKeyForDetailTab);
this.Controls.Add(this.txtKeyForDetailTab);
this.Controls.Add(this.chkIsNeedSort);
this.Controls.Add(this.chkIsNeedTransCode);
this.Controls.Add(this.lblUserId);
this.Controls.Add(this.cboUserId);
this.Controls.Add(this.lblPrjId);
this.Controls.Add(this.cboPrjId);
this.Controls.Add(this.lblViewFunction);
this.Controls.Add(this.txtViewFunction);
this.Controls.Add(this.lblViewDetail);
this.Controls.Add(this.txtViewDetail);
this.Controls.Add(this.lblDefaMenuName);
this.Controls.Add(this.txtDefaMenuName);
this.Controls.Add(this.lblDetailTabId);
this.Controls.Add(this.cboDetailTabId);
this.Controls.Add(this.lblFileName);
this.Controls.Add(this.txtFileName);
this.Controls.Add(this.lblFilePath);
this.Controls.Add(this.txtFilePath);
this.Controls.Add(this.lblMainTabId);
this.Controls.Add(this.txtMainTabId);
this.Controls.Add(this.lblViewCnName);
this.Controls.Add(this.txtViewCnName);
this.Controls.Add(this.lblViewGroupId);
this.Controls.Add(this.cboViewGroupId);
this.Controls.Add(this.lblINRelaTabId);
this.Controls.Add(this.cboINRelaTabId);
this.Controls.Add(this.lblINSQLDSTypeId);
this.Controls.Add(this.cboINSQLDSTypeId);
this.Controls.Add(this.lblOUTRelaTabId);
this.Controls.Add(this.cboOUTRelaTabId);
this.Controls.Add(this.lblOUTSQLDSTypeId);
this.Controls.Add(this.cboOUTSQLDSTypeId);
this.Controls.Add(this.lblDetailTabType);
this.Controls.Add(this.txtDetailTabType);
this.Controls.Add(this.lblDetailViewId);
this.Controls.Add(this.txtDetailViewId);
this.Controls.Add(this.lblMainTabType);
this.Controls.Add(this.txtMainTabType);
this.Controls.Add(this.lblMainViewId);
this.Controls.Add(this.txtMainViewId);
this.Controls.Add(this.lblUpdDate);
this.Controls.Add(this.txtUpdDate);
this.Controls.Add(this.btnClose);
this.Controls.Add(this.btnOKUpd);
this.Controls.Add(this.lblMsg);
this.Name = "frmViewInfo_UI";
this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
this.Font = new System.Drawing.Font("����", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
this.Text = "frmViewInfo_UI";
this.Load += new System.EventHandler(this.frmViewInfo_UI_Load);
this.ResumeLayout(false);
}
#endregion
private System.Windows.Forms.Label lblViewId;
private System.Windows.Forms.TextBox txtViewId;
private System.Windows.Forms.Label lblViewName;
private System.Windows.Forms.TextBox txtViewName;
private System.Windows.Forms.Label lblViewTypeCode;
private System.Windows.Forms.ComboBox cboViewTypeCode;
private System.Windows.Forms.Label lblApplicationTypeId;
private System.Windows.Forms.ComboBox cboApplicationTypeId;
private System.Windows.Forms.Label lblFuncModuleId;
private System.Windows.Forms.ComboBox cboFuncModuleId;
private System.Windows.Forms.Label lblDataBaseName;
private System.Windows.Forms.TextBox txtDataBaseName;
private System.Windows.Forms.Label lblKeyForMainTab;
private System.Windows.Forms.TextBox txtKeyForMainTab;
private System.Windows.Forms.Label lblKeyForDetailTab;
private System.Windows.Forms.TextBox txtKeyForDetailTab;
private System.Windows.Forms.Label lblIsNeedSort;
private System.Windows.Forms.CheckBox chkIsNeedSort;
private System.Windows.Forms.Label lblIsNeedTransCode;
private System.Windows.Forms.CheckBox chkIsNeedTransCode;
private System.Windows.Forms.Label lblUserId;
private System.Windows.Forms.ComboBox cboUserId;
private System.Windows.Forms.Label lblPrjId;
private System.Windows.Forms.ComboBox cboPrjId;
private System.Windows.Forms.Label lblViewFunction;
private System.Windows.Forms.TextBox txtViewFunction;
private System.Windows.Forms.Label lblViewDetail;
private System.Windows.Forms.TextBox txtViewDetail;
private System.Windows.Forms.Label lblDefaMenuName;
private System.Windows.Forms.TextBox txtDefaMenuName;
private System.Windows.Forms.Label lblDetailTabId;
private System.Windows.Forms.ComboBox cboDetailTabId;
private System.Windows.Forms.Label lblFileName;
private System.Windows.Forms.TextBox txtFileName;
private System.Windows.Forms.Label lblFilePath;
private System.Windows.Forms.TextBox txtFilePath;
private System.Windows.Forms.Label lblMainTabId;
private System.Windows.Forms.TextBox txtMainTabId;
private System.Windows.Forms.Label lblViewCnName;
private System.Windows.Forms.TextBox txtViewCnName;
private System.Windows.Forms.Label lblViewGroupId;
private System.Windows.Forms.ComboBox cboViewGroupId;
private System.Windows.Forms.Label lblINRelaTabId;
private System.Windows.Forms.ComboBox cboINRelaTabId;
private System.Windows.Forms.Label lblINSQLDSTypeId;
private System.Windows.Forms.ComboBox cboINSQLDSTypeId;
private System.Windows.Forms.Label lblOUTRelaTabId;
private System.Windows.Forms.ComboBox cboOUTRelaTabId;
private System.Windows.Forms.Label lblOUTSQLDSTypeId;
private System.Windows.Forms.ComboBox cboOUTSQLDSTypeId;
private System.Windows.Forms.Label lblDetailTabType;
private System.Windows.Forms.TextBox txtDetailTabType;
private System.Windows.Forms.Label lblDetailViewId;
private System.Windows.Forms.TextBox txtDetailViewId;
private System.Windows.Forms.Label lblMainTabType;
private System.Windows.Forms.TextBox txtMainTabType;
private System.Windows.Forms.Label lblMainViewId;
private System.Windows.Forms.TextBox txtMainViewId;
private System.Windows.Forms.Label lblUpdDate;
private System.Windows.Forms.TextBox txtUpdDate;
private System.Windows.Forms.Label lblMsg; 
private System.Windows.Forms.Button btnOKUpd;
private System.Windows.Forms.Button btnClose;
}
}