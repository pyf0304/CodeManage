
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
//���������صĿؼ����Ʋ����
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using com.taishsoft.commdb;
using AGC_CSV7.Entity;
using AGC_CSV7.BusinessLogic;
using com.taishsoft.util;
using CommFunc4Win;

namespace AGC_CSV7
{
/// <summary>
///		frmViewInfo_UI ��ժҪ˵����
/// </summary>
public partial class frmViewInfo_UI : System.Windows.Forms.Form
{
clsViewInfoEN objViewInfoEN = null;
private string mstrViewId;		//���ڴ��ݹؼ���ֵ�ı���
public string OperateType;
public IBindListView iBindListView = null;
public frmViewInfo_UI()
{
// �õ����� Windows.Forms ���������������ġ�
InitializeComponent();

// TODO: �� InitializeComponent ���ú�����κγ�ʼ��

}
private void frmViewInfo_UI_Load(object sender, System.EventArgs e)
{
// �ڴ˴������û������Գ�ʼ��ҳ��
//1��Ϊ��������������Դ�����б�����
this.SetAllComboBox();
if (OperateType == "Update")
{
ShowData(mstrViewId);
btnOKUpd.Text = "ȷ���޸�";
}
else
{
AddViewInfoRecord();
}

}
/// <summary>
/// ������İ󶨺���
/// </summary>
private void SetAllComboBox()
{
this.BindCbo_ViewTypeCode(this.cboViewTypeCode);
this.BindCbo_ApplicationTypeId(this.cboApplicationTypeId);
this.BindCbo_FuncModuleId(this.cboFuncModuleId);
this.BindCbo_UserId(this.cboUserId);
this.BindCbo_PrjId(this.cboPrjId);
this.BindCbo_DetailTabId(this.cboDetailTabId);
this.BindCbo_ViewGroupId(this.cboViewGroupId);
this.BindCbo_INRelaTabId(this.cboINRelaTabId);
this.BindCbo_INSQLDSTypeId(this.cboINSQLDSTypeId);
this.BindCbo_OUTRelaTabId(this.cboOUTRelaTabId);
this.BindCbo_OUTSQLDSTypeId(this.cboOUTSQLDSTypeId);
}
public string ViewId
{
get
{
return txtViewId.Text.Trim();
}
set
{
txtViewId.Text = value.ToString();
}
}

public string ViewName
{
get
{
return txtViewName.Text.Trim();
}
set
{
txtViewName.Text = value.ToString();
}
}

public string ViewTypeCode
{
get
{
if (cboViewTypeCode.SelectedValue.ToString() == "0")
return "";
return cboViewTypeCode.SelectedValue.ToString();
}
set
{
if (value == "")
{
cboViewTypeCode.SelectedValue = "0";
}
else
{
cboViewTypeCode.SelectedValue = value;
}
}
}

public string ApplicationTypeId
{
get
{
if (cboApplicationTypeId.SelectedValue.ToString() == "0")
return "";
return cboApplicationTypeId.SelectedValue.ToString();
}
set
{
if (value == "")
{
cboApplicationTypeId.SelectedValue = "0";
}
else
{
cboApplicationTypeId.SelectedValue = value;
}
}
}

public string FuncModuleId
{
get
{
if (cboFuncModuleId.SelectedValue.ToString() == "0")
return "";
return cboFuncModuleId.SelectedValue.ToString();
}
set
{
if (value == "")
{
cboFuncModuleId.SelectedValue = "0";
}
else
{
cboFuncModuleId.SelectedValue = value;
}
}
}

public string DataBaseName
{
get
{
return txtDataBaseName.Text.Trim();
}
set
{
txtDataBaseName.Text = value.ToString();
}
}

public string KeyForMainTab
{
get
{
return txtKeyForMainTab.Text.Trim();
}
set
{
txtKeyForMainTab.Text = value.ToString();
}
}

public string KeyForDetailTab
{
get
{
return txtKeyForDetailTab.Text.Trim();
}
set
{
txtKeyForDetailTab.Text = value.ToString();
}
}

public bool IsNeedSort
{
get
{
return chkIsNeedSort.Checked;
}
set
{
chkIsNeedSort.Checked = value;
}
}

public bool IsNeedTransCode
{
get
{
return chkIsNeedTransCode.Checked;
}
set
{
chkIsNeedTransCode.Checked = value;
}
}

public string UserId
{
get
{
if (cboUserId.SelectedValue.ToString() == "0")
return "";
return cboUserId.SelectedValue.ToString();
}
set
{
if (value == "")
{
cboUserId.SelectedValue = "0";
}
else
{
cboUserId.SelectedValue = value;
}
}
}

public string PrjId
{
get
{
if (cboPrjId.SelectedValue.ToString() == "0")
return "";
return cboPrjId.SelectedValue.ToString();
}
set
{
if (value == "")
{
cboPrjId.SelectedValue = "0";
}
else
{
cboPrjId.SelectedValue = value;
}
}
}

public string ViewFunction
{
get
{
return txtViewFunction.Text.Trim();
}
set
{
txtViewFunction.Text = value.ToString();
}
}

public string ViewDetail
{
get
{
return txtViewDetail.Text.Trim();
}
set
{
txtViewDetail.Text = value.ToString();
}
}

public string DefaMenuName
{
get
{
return txtDefaMenuName.Text.Trim();
}
set
{
txtDefaMenuName.Text = value.ToString();
}
}

public string DetailTabId
{
get
{
if (cboDetailTabId.SelectedValue.ToString() == "0")
return "";
return cboDetailTabId.SelectedValue.ToString();
}
set
{
if (value == "")
{
cboDetailTabId.SelectedValue = "0";
}
else
{
cboDetailTabId.SelectedValue = value;
}
}
}

public string FileName
{
get
{
return txtFileName.Text.Trim();
}
set
{
txtFileName.Text = value.ToString();
}
}

public string FilePath
{
get
{
return txtFilePath.Text.Trim();
}
set
{
txtFilePath.Text = value.ToString();
}
}

public string MainTabId
{
get
{
return txtMainTabId.Text.Trim();
}
set
{
txtMainTabId.Text = value.ToString();
}
}

public string ViewCnName
{
get
{
return txtViewCnName.Text.Trim();
}
set
{
txtViewCnName.Text = value.ToString();
}
}

public string ViewGroupId
{
get
{
if (cboViewGroupId.SelectedValue.ToString() == "0")
return "";
return cboViewGroupId.SelectedValue.ToString();
}
set
{
if (value == "")
{
cboViewGroupId.SelectedValue = "0";
}
else
{
cboViewGroupId.SelectedValue = value;
}
}
}

public string INRelaTabId
{
get
{
if (cboINRelaTabId.SelectedValue.ToString() == "0")
return "";
return cboINRelaTabId.SelectedValue.ToString();
}
set
{
if (value == "")
{
cboINRelaTabId.SelectedValue = "0";
}
else
{
cboINRelaTabId.SelectedValue = value;
}
}
}

public string INSQLDSTypeId
{
get
{
if (cboINSQLDSTypeId.SelectedValue.ToString() == "0")
return "";
return cboINSQLDSTypeId.SelectedValue.ToString();
}
set
{
if (value == "")
{
cboINSQLDSTypeId.SelectedValue = "0";
}
else
{
cboINSQLDSTypeId.SelectedValue = value;
}
}
}

public string OUTRelaTabId
{
get
{
if (cboOUTRelaTabId.SelectedValue.ToString() == "0")
return "";
return cboOUTRelaTabId.SelectedValue.ToString();
}
set
{
if (value == "")
{
cboOUTRelaTabId.SelectedValue = "0";
}
else
{
cboOUTRelaTabId.SelectedValue = value;
}
}
}

public string OUTSQLDSTypeId
{
get
{
if (cboOUTSQLDSTypeId.SelectedValue.ToString() == "0")
return "";
return cboOUTSQLDSTypeId.SelectedValue.ToString();
}
set
{
if (value == "")
{
cboOUTSQLDSTypeId.SelectedValue = "0";
}
else
{
cboOUTSQLDSTypeId.SelectedValue = value;
}
}
}

public string DetailTabType
{
get
{
return txtDetailTabType.Text.Trim();
}
set
{
txtDetailTabType.Text = value.ToString();
}
}

public string DetailViewId
{
get
{
return txtDetailViewId.Text.Trim();
}
set
{
txtDetailViewId.Text = value.ToString();
}
}

public string MainTabType
{
get
{
return txtMainTabType.Text.Trim();
}
set
{
txtMainTabType.Text = value.ToString();
}
}

public string MainViewId
{
get
{
return txtMainViewId.Text.Trim();
}
set
{
txtMainViewId.Text = value.ToString();
}
}

public string UpdDate
{
get
{
return txtUpdDate.Text.Trim();
}
set
{
txtUpdDate.Text = value.ToString();
}
}


public void SetKeyReadOnly(bool bolReadonly)
{
txtViewId.ReadOnly = bolReadonly;
}
public void Clear()
{
txtViewId.Text = "";
txtViewName.Text = "";
cboViewTypeCode.SelectedIndex = 0;
cboApplicationTypeId.SelectedIndex = 0;
cboFuncModuleId.SelectedIndex = 0;
txtDataBaseName.Text = "";
txtKeyForMainTab.Text = "";
txtKeyForDetailTab.Text = "";
chkIsNeedSort.Checked = false;
chkIsNeedTransCode.Checked = false;
cboUserId.SelectedIndex = 0;
cboPrjId.SelectedIndex = 0;
txtViewFunction.Text = "";
txtViewDetail.Text = "";
txtDefaMenuName.Text = "";
cboDetailTabId.SelectedIndex = 0;
txtFileName.Text = "";
txtFilePath.Text = "";
txtMainTabId.Text = "";
txtViewCnName.Text = "";
cboViewGroupId.SelectedIndex = 0;
cboINRelaTabId.SelectedIndex = 0;
cboINSQLDSTypeId.SelectedIndex = 0;
cboOUTRelaTabId.SelectedIndex = 0;
cboOUTSQLDSTypeId.SelectedIndex = 0;
txtDetailTabType.Text = "";
txtDetailViewId.Text = "";
txtMainTabType.Text = "";
txtMainViewId.Text = "";
txtUpdDate.Text = "";
}
/// <summary>
/// ���øÿؼ��ڲ���״̬�µ�ȱʡֵ
/// һ�����
///		1����������;�Ĭ��Ϊ0��
///		2������Ǹ����Ͳ�Ĭ��Ϊ0.0��
///		3������������;�Ĭ��Ϊ��ǰ�����ڣ�
///		4�������λ(bit)�;�Ĭ��Ϊfalse;
///		��ЩĬ��ֵ���������޸�
/// </summary>
public void SetDefaultValue()
{
txtViewId.Text = "";
txtViewName.Text = "";
cboViewTypeCode.SelectedIndex = 0;
cboApplicationTypeId.SelectedIndex = 0;
cboFuncModuleId.SelectedIndex = 0;
txtDataBaseName.Text = "";
txtKeyForMainTab.Text = "";
txtKeyForDetailTab.Text = "";
chkIsNeedSort.Checked = false;
chkIsNeedTransCode.Checked = false;
cboUserId.SelectedIndex = 0;
cboPrjId.SelectedIndex = 0;
txtViewFunction.Text = "";
txtViewDetail.Text = "";
txtDefaMenuName.Text = "";
cboDetailTabId.SelectedIndex = 0;
txtFileName.Text = "";
txtFilePath.Text = "";
txtMainTabId.Text = "";
txtViewCnName.Text = "";
cboViewGroupId.SelectedIndex = 0;
cboINRelaTabId.SelectedIndex = 0;
cboINSQLDSTypeId.SelectedIndex = 0;
cboOUTRelaTabId.SelectedIndex = 0;
cboOUTSQLDSTypeId.SelectedIndex = 0;
txtDetailTabType.Text = "";
txtDetailViewId.Text = "";
txtMainTabType.Text = "";
txtMainViewId.Text = "";
txtUpdDate.Text = "";
}
/// <summary>
/// У���Զ���ؼ������ӿؼ���������ֵ�Ƿ��ǺϷ���ȷ�ġ�
/// һ�����
///		1������У�����ͣ����͡������͡������͵ȣ�
///			��Щ�������Զ����ɴ����������
///		2��У����ֵ�������ֵ����Сֵ��
///			��Щ�������Զ����ɴ����������
///		��Щ�������ݿ����޸�
/// </summary>
/// <returns></returns>
public bool IsValid(ref string strResult)
{
return true;
}
/// <summary>
/// ���ܣ���ȡ��ǰ�µ��ַ���
/// �µĸ�ʽ��
///    �µ��ַ����ĸ�ʽ�����֣�
///		1��YYYYMM��	����200501
///		2��YYYY-MM-DD	����2005-01
///		3��YYYY/MM/DD	����2005/01
/// </summary>
/// <param name="intFormat">�µĸ�ʽ������3�֣��������0,1��2
///							������ͬ����������ֵ�Ͳ�ͬ��
///							�μ�������µĸ�ʽ
///	</param>
/// <returns>���ص�ǰ�µ��ַ���</returns>
public string getCurrMonth(int intFormat)
{
string strCurrMonth;
string strYear, strMonth;
int intYear, intMonth;
intYear = System.DateTime.Today.Year;
intMonth = System.DateTime.Today.Month;
strYear = intYear.ToString().Trim();
if (intMonth>9) strMonth = intMonth.ToString().Trim();
else strMonth = "0" + intMonth.ToString().Trim();
strCurrMonth = strYear + strMonth;
switch(intFormat)
{
case 0:
strCurrMonth = strYear + strMonth;
break;
case 1:
strCurrMonth =strYear + "-" + strMonth;
break;
case 2:
strCurrMonth =strYear + "/" + strMonth;
break;
}
return strCurrMonth;
}
/// <summary>
/// ���ܣ���ȡ��ǰ���ڵ��ַ���
/// ���ڸ�ʽ��
///    ���ڵ��ַ����ĸ�ʽ�����֣�
///		1��YYYYMMDD��	����20050120
///		2��YYYY-MM-DD	����2005-01-20
///		3��YYYY/MM/DD	����2005/01/20
/// </summary>
/// <param name="intFormat">���ڸ�ʽ������3�֣��������0,1��2
///							������ͬ����������ֵ�Ͳ�ͬ��
///							�μ���������ڸ�ʽ
///	</param>
/// <returns>���ص�ǰ���ڵ��ַ���</returns>
public string getTodayStr(int intFormat)
{
string strToday;
string strYear, strMonth, strDay;
int intYear, intMonth, intDay;
intYear = System.DateTime.Today.Year;
intMonth = System.DateTime.Today.Month;
intDay = System.DateTime.Today.Day;
strYear = intYear.ToString().Trim();
if (intMonth>9) strMonth = intMonth.ToString().Trim();
else strMonth = "0" + intMonth.ToString().Trim();
if (intDay>9) strDay = intDay.ToString().Trim();
else strDay = "0" + intDay.ToString().Trim();
strToday = strYear + strMonth + strDay;
switch(intFormat)
{
case 0:
strToday = strYear + strMonth + strDay;
break;
case 1:
strToday =strYear + "-" + strMonth + "-" + strDay;
break;
case 2:
strToday =strYear + "/" + strMonth + "/" + strDay;
break;
}
return strToday;
}
public System.Data.DataTable GetViewTypeCode()
{
//��ȡĳѧԺ����רҵ��Ϣ
string strSQL = "select ViewTypeCode, ViewTypeName from ViewTypeCodeTab ";
clsSpecSQLforSql mySql=new clsSpecSQLforSql();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}
public void BindCbo_ViewTypeCode(System.Windows.Forms.ComboBox objComboBox)
{
//Ϊ����ԴΪ�����������������
System.Data.DataTable objDT = GetViewTypeCode();
clsViewTypeCodeTabEN objViewTypeCodeTabEN;
//��ʼ��һ�������б�
ArrayList ViewTypeCodeTabList = new ArrayList();
//�����0��ڵ�0���в���"��ѡ��..."��Ϊ�˷����û�����WEB��ʽ���ơ�
objViewTypeCodeTabEN = new clsViewTypeCodeTabEN();
objViewTypeCodeTabEN.ViewTypeCode = "0";
objViewTypeCodeTabEN.ViewTypeName = "��ѡ��...";
ViewTypeCodeTabList.Add(objViewTypeCodeTabEN);
//��DataTable�е���������ӵ������б���
foreach(DataRow objRow in objDT.Rows)
{
objViewTypeCodeTabEN = new clsViewTypeCodeTabEN();
objViewTypeCodeTabEN.ViewTypeCode = objRow["ViewTypeCode"].ToString();
objViewTypeCodeTabEN.ViewTypeName = objRow["ViewTypeName"].ToString();
ViewTypeCodeTabList.Add(objViewTypeCodeTabEN);
}
//���������������Դ���Լ�����ֵ���ʾ��
objComboBox.DataSource = ViewTypeCodeTabList;
objComboBox.ValueMember="ViewTypeCode";
objComboBox.DisplayMember="ViewTypeName";
objComboBox.SelectedIndex = 0;
}
public System.Data.DataTable GetApplicationTypeId()
{
//��ȡĳѧԺ����רҵ��Ϣ
string strSQL = "select ApplicationTypeId, ApplicationTypeName from ApplicationType ";
clsSpecSQLforSql mySql=new clsSpecSQLforSql();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}
public void BindCbo_ApplicationTypeId(System.Windows.Forms.ComboBox objComboBox)
{
//Ϊ����ԴΪ�����������������
System.Data.DataTable objDT = GetApplicationTypeId();
clsApplicationTypeEN objApplicationTypeEN;
//��ʼ��һ�������б�
ArrayList ApplicationTypeList = new ArrayList();
//�����0��ڵ�0���в���"��ѡ��..."��Ϊ�˷����û�����WEB��ʽ���ơ�
objApplicationTypeEN = new clsApplicationTypeEN();
objApplicationTypeEN.ApplicationTypeId = "0";
objApplicationTypeEN.ApplicationTypeName = "��ѡ��...";
ApplicationTypeList.Add(objApplicationTypeEN);
//��DataTable�е���������ӵ������б���
foreach(DataRow objRow in objDT.Rows)
{
objApplicationTypeEN = new clsApplicationTypeEN();
objApplicationTypeEN.ApplicationTypeId = objRow["ApplicationTypeId"].ToString();
objApplicationTypeEN.ApplicationTypeName = objRow["ApplicationTypeName"].ToString();
ApplicationTypeList.Add(objApplicationTypeEN);
}
//���������������Դ���Լ�����ֵ���ʾ��
objComboBox.DataSource = ApplicationTypeList;
objComboBox.ValueMember="ApplicationTypeId";
objComboBox.DisplayMember="ApplicationTypeName";
objComboBox.SelectedIndex = 0;
}
public System.Data.DataTable GetFuncModuleId()
{
//��ȡĳѧԺ����רҵ��Ϣ
string strSQL = "select FuncModuleId, FuncModuleName from FuncModule ";
clsSpecSQLforSql mySql=new clsSpecSQLforSql();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}
public void BindCbo_FuncModuleId(System.Windows.Forms.ComboBox objComboBox)
{
//Ϊ����ԴΪ�����������������
System.Data.DataTable objDT = GetFuncModuleId();
clsFuncModuleEN objFuncModuleEN;
//��ʼ��һ�������б�
ArrayList FuncModuleList = new ArrayList();
//�����0��ڵ�0���в���"��ѡ��..."��Ϊ�˷����û�����WEB��ʽ���ơ�
objFuncModuleEN = new clsFuncModuleEN();
objFuncModuleEN.FuncModuleId = "0";
objFuncModuleEN.FuncModuleName = "��ѡ��...";
FuncModuleList.Add(objFuncModuleEN);
//��DataTable�е���������ӵ������б���
foreach(DataRow objRow in objDT.Rows)
{
objFuncModuleEN = new clsFuncModuleEN();
objFuncModuleEN.FuncModuleId = objRow["FuncModuleId"].ToString();
objFuncModuleEN.FuncModuleName = objRow["FuncModuleName"].ToString();
FuncModuleList.Add(objFuncModuleEN);
}
//���������������Դ���Լ�����ֵ���ʾ��
objComboBox.DataSource = FuncModuleList;
objComboBox.ValueMember="FuncModuleId";
objComboBox.DisplayMember="FuncModuleName";
objComboBox.SelectedIndex = 0;
}
public System.Data.DataTable GetUserId()
{
//��ȡĳѧԺ����רҵ��Ϣ
string strSQL = "select UserId, UserName from Users ";
clsSpecSQLforSql mySql=new clsSpecSQLforSql();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}
public void BindCbo_UserId(System.Windows.Forms.ComboBox objComboBox)
{
//Ϊ����ԴΪ�����������������
System.Data.DataTable objDT = GetUserId();
clsUsersEN objUsersEN;
//��ʼ��һ�������б�
ArrayList UsersList = new ArrayList();
//�����0��ڵ�0���в���"��ѡ��..."��Ϊ�˷����û�����WEB��ʽ���ơ�
objUsersEN = new clsUsersEN();
objUsersEN.UserId = "0";
objUsersEN.UserName = "��ѡ��...";
UsersList.Add(objUsersEN);
//��DataTable�е���������ӵ������б���
foreach(DataRow objRow in objDT.Rows)
{
objUsersEN = new clsUsersEN();
objUsersEN.UserId = objRow["UserId"].ToString();
objUsersEN.UserName = objRow["UserName"].ToString();
UsersList.Add(objUsersEN);
}
//���������������Դ���Լ�����ֵ���ʾ��
objComboBox.DataSource = UsersList;
objComboBox.ValueMember="UserId";
objComboBox.DisplayMember="UserName";
objComboBox.SelectedIndex = 0;
}
public System.Data.DataTable GetPrjId()
{
//��ȡĳѧԺ����רҵ��Ϣ
string strSQL = "select PrjId, PrjName from Projects ";
clsSpecSQLforSql mySql=new clsSpecSQLforSql();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}
public void BindCbo_PrjId(System.Windows.Forms.ComboBox objComboBox)
{
//Ϊ����ԴΪ�����������������
System.Data.DataTable objDT = GetPrjId();
clsProjectsEN objProjectsEN;
//��ʼ��һ�������б�
ArrayList ProjectsList = new ArrayList();
//�����0��ڵ�0���в���"��ѡ��..."��Ϊ�˷����û�����WEB��ʽ���ơ�
objProjectsEN = new clsProjectsEN();
objProjectsEN.PrjId = "0";
objProjectsEN.PrjName = "��ѡ��...";
ProjectsList.Add(objProjectsEN);
//��DataTable�е���������ӵ������б���
foreach(DataRow objRow in objDT.Rows)
{
objProjectsEN = new clsProjectsEN();
objProjectsEN.PrjId = objRow["PrjId"].ToString();
objProjectsEN.PrjName = objRow["PrjName"].ToString();
ProjectsList.Add(objProjectsEN);
}
//���������������Դ���Լ�����ֵ���ʾ��
objComboBox.DataSource = ProjectsList;
objComboBox.ValueMember="PrjId";
objComboBox.DisplayMember="PrjName";
objComboBox.SelectedIndex = 0;
}
public System.Data.DataTable GetDetailTabId()
{
//��ȡĳѧԺ����רҵ��Ϣ
string strSQL = "select TabId, TabName from PrjTab ";
clsSpecSQLforSql mySql=new clsSpecSQLforSql();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}
public void BindCbo_DetailTabId(System.Windows.Forms.ComboBox objComboBox)
{
//Ϊ����ԴΪ�����������������
System.Data.DataTable objDT = GetDetailTabId();
clsPrjTabEN objPrjTabEN;
//��ʼ��һ�������б�
ArrayList PrjTabList = new ArrayList();
//�����0��ڵ�0���в���"��ѡ��..."��Ϊ�˷����û�����WEB��ʽ���ơ�
objPrjTabEN = new clsPrjTabEN();
objPrjTabEN.TabId = "0";
objPrjTabEN.TabName = "��ѡ��...";
PrjTabList.Add(objPrjTabEN);
//��DataTable�е���������ӵ������б���
foreach(DataRow objRow in objDT.Rows)
{
objPrjTabEN = new clsPrjTabEN();
objPrjTabEN.TabId = objRow["TabId"].ToString();
objPrjTabEN.TabName = objRow["TabName"].ToString();
PrjTabList.Add(objPrjTabEN);
}
//���������������Դ���Լ�����ֵ���ʾ��
objComboBox.DataSource = PrjTabList;
objComboBox.ValueMember="TabId";
objComboBox.DisplayMember="TabName";
objComboBox.SelectedIndex = 0;
}
public System.Data.DataTable GetViewGroupId()
{
//��ȡĳѧԺ����רҵ��Ϣ
string strSQL = "select ViewGroupId, ViewGroupName from ViewGroup ";
clsSpecSQLforSql mySql=new clsSpecSQLforSql();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}
public void BindCbo_ViewGroupId(System.Windows.Forms.ComboBox objComboBox)
{
//Ϊ����ԴΪ�����������������
System.Data.DataTable objDT = GetViewGroupId();
clsViewGroupEN objViewGroupEN;
//��ʼ��һ�������б�
ArrayList ViewGroupList = new ArrayList();
//�����0��ڵ�0���в���"��ѡ��..."��Ϊ�˷����û�����WEB��ʽ���ơ�
objViewGroupEN = new clsViewGroupEN();
objViewGroupEN.ViewGroupId = "0";
objViewGroupEN.ViewGroupName = "��ѡ��...";
ViewGroupList.Add(objViewGroupEN);
//��DataTable�е���������ӵ������б���
foreach(DataRow objRow in objDT.Rows)
{
objViewGroupEN = new clsViewGroupEN();
objViewGroupEN.ViewGroupId = objRow["ViewGroupId"].ToString();
objViewGroupEN.ViewGroupName = objRow["ViewGroupName"].ToString();
ViewGroupList.Add(objViewGroupEN);
}
//���������������Դ���Լ�����ֵ���ʾ��
objComboBox.DataSource = ViewGroupList;
objComboBox.ValueMember="ViewGroupId";
objComboBox.DisplayMember="ViewGroupName";
objComboBox.SelectedIndex = 0;
}
public System.Data.DataTable GetINRelaTabId()
{
//��ȡĳѧԺ����רҵ��Ϣ
string strSQL = "select TabId, TabName from PrjTab ";
clsSpecSQLforSql mySql=new clsSpecSQLforSql();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}
public void BindCbo_INRelaTabId(System.Windows.Forms.ComboBox objComboBox)
{
//Ϊ����ԴΪ�����������������
System.Data.DataTable objDT = GetINRelaTabId();
clsPrjTabEN objPrjTabEN;
//��ʼ��һ�������б�
ArrayList PrjTabList = new ArrayList();
//�����0��ڵ�0���в���"��ѡ��..."��Ϊ�˷����û�����WEB��ʽ���ơ�
objPrjTabEN = new clsPrjTabEN();
objPrjTabEN.TabId = "0";
objPrjTabEN.TabName = "��ѡ��...";
PrjTabList.Add(objPrjTabEN);
//��DataTable�е���������ӵ������б���
foreach(DataRow objRow in objDT.Rows)
{
objPrjTabEN = new clsPrjTabEN();
objPrjTabEN.TabId = objRow["TabId"].ToString();
objPrjTabEN.TabName = objRow["TabName"].ToString();
PrjTabList.Add(objPrjTabEN);
}
//���������������Դ���Լ�����ֵ���ʾ��
objComboBox.DataSource = PrjTabList;
objComboBox.ValueMember="TabId";
objComboBox.DisplayMember="TabName";
objComboBox.SelectedIndex = 0;
}
public System.Data.DataTable GetINSQLDSTypeId()
{
//��ȡĳѧԺ����רҵ��Ϣ
string strSQL = "select OUTSQLDSTypeId, SqlDsTypeName from SQLDSType ";
clsSpecSQLforSql mySql=new clsSpecSQLforSql();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}
public void BindCbo_INSQLDSTypeId(System.Windows.Forms.ComboBox objComboBox)
{
//Ϊ����ԴΪ�����������������
System.Data.DataTable objDT = GetINSQLDSTypeId();
clsSQLDSTypeEN objSQLDSTypeEN;
//��ʼ��һ�������б�
ArrayList SQLDSTypeList = new ArrayList();
//�����0��ڵ�0���в���"��ѡ��..."��Ϊ�˷����û�����WEB��ʽ���ơ�
objSQLDSTypeEN = new clsSQLDSTypeEN();
objSQLDSTypeEN.OUTSQLDSTypeId = "0";
objSQLDSTypeEN.SqlDsTypeName = "��ѡ��...";
SQLDSTypeList.Add(objSQLDSTypeEN);
//��DataTable�е���������ӵ������б���
foreach(DataRow objRow in objDT.Rows)
{
objSQLDSTypeEN = new clsSQLDSTypeEN();
objSQLDSTypeEN.OUTSQLDSTypeId = objRow["OUTSQLDSTypeId"].ToString();
objSQLDSTypeEN.SqlDsTypeName = objRow["SqlDsTypeName"].ToString();
SQLDSTypeList.Add(objSQLDSTypeEN);
}
//���������������Դ���Լ�����ֵ���ʾ��
objComboBox.DataSource = SQLDSTypeList;
objComboBox.ValueMember="OUTSQLDSTypeId";
objComboBox.DisplayMember="SqlDsTypeName";
objComboBox.SelectedIndex = 0;
}
public System.Data.DataTable GetOUTRelaTabId()
{
//��ȡĳѧԺ����רҵ��Ϣ
string strSQL = "select TabId, TabName from PrjTab ";
clsSpecSQLforSql mySql=new clsSpecSQLforSql();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}
public void BindCbo_OUTRelaTabId(System.Windows.Forms.ComboBox objComboBox)
{
//Ϊ����ԴΪ�����������������
System.Data.DataTable objDT = GetOUTRelaTabId();
clsPrjTabEN objPrjTabEN;
//��ʼ��һ�������б�
ArrayList PrjTabList = new ArrayList();
//�����0��ڵ�0���в���"��ѡ��..."��Ϊ�˷����û�����WEB��ʽ���ơ�
objPrjTabEN = new clsPrjTabEN();
objPrjTabEN.TabId = "0";
objPrjTabEN.TabName = "��ѡ��...";
PrjTabList.Add(objPrjTabEN);
//��DataTable�е���������ӵ������б���
foreach(DataRow objRow in objDT.Rows)
{
objPrjTabEN = new clsPrjTabEN();
objPrjTabEN.TabId = objRow["TabId"].ToString();
objPrjTabEN.TabName = objRow["TabName"].ToString();
PrjTabList.Add(objPrjTabEN);
}
//���������������Դ���Լ�����ֵ���ʾ��
objComboBox.DataSource = PrjTabList;
objComboBox.ValueMember="TabId";
objComboBox.DisplayMember="TabName";
objComboBox.SelectedIndex = 0;
}
public System.Data.DataTable GetOUTSQLDSTypeId()
{
//��ȡĳѧԺ����רҵ��Ϣ
string strSQL = "select SQLDSTypeId, SqlDsTypeName from SQLDSType ";
clsSpecSQLforSql mySql=new clsSpecSQLforSql();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}
public void BindCbo_OUTSQLDSTypeId(System.Windows.Forms.ComboBox objComboBox)
{
//Ϊ����ԴΪ�����������������
System.Data.DataTable objDT = GetOUTSQLDSTypeId();
clsSQLDSTypeEN objSQLDSTypeEN;
//��ʼ��һ�������б�
ArrayList SQLDSTypeList = new ArrayList();
//�����0��ڵ�0���в���"��ѡ��..."��Ϊ�˷����û�����WEB��ʽ���ơ�
objSQLDSTypeEN = new clsSQLDSTypeEN();
objSQLDSTypeEN.SQLDSTypeId = "0";
objSQLDSTypeEN.SqlDsTypeName = "��ѡ��...";
SQLDSTypeList.Add(objSQLDSTypeEN);
//��DataTable�е���������ӵ������б���
foreach(DataRow objRow in objDT.Rows)
{
objSQLDSTypeEN = new clsSQLDSTypeEN();
objSQLDSTypeEN.SQLDSTypeId = objRow["SQLDSTypeId"].ToString();
objSQLDSTypeEN.SqlDsTypeName = objRow["SqlDsTypeName"].ToString();
SQLDSTypeList.Add(objSQLDSTypeEN);
}
//���������������Դ���Լ�����ֵ���ʾ��
objComboBox.DataSource = SQLDSTypeList;
objComboBox.ValueMember="SQLDSTypeId";
objComboBox.DisplayMember="SqlDsTypeName";
objComboBox.SelectedIndex = 0;
}
public void SetCbo_ViewTypeCode()
{
clsViewTypeCodeTabBL.BindCbo_ViewTypeCode(cboViewTypeCode);
}
public void SetCbo_ApplicationTypeId()
{
clsApplicationTypeBL.BindCbo_ApplicationTypeId(cboApplicationTypeId);
}
public void SetCbo_FuncModuleId()
{
clsFuncModuleBL.BindCbo_FuncModuleId(cboFuncModuleId);
}
public void SetCbo_UserId()
{
clsUsersBL.BindCbo_UserId(cboUserId);
}
public void SetCbo_PrjId()
{
clsProjectsBL.BindCbo_PrjId(cboPrjId);
}
public void SetCbo_DetailTabId()
{
clsPrjTabBL.BindCbo_DetailTabId(cboDetailTabId);
}
public void SetCbo_ViewGroupId()
{
clsViewGroupBL.BindCbo_ViewGroupId(cboViewGroupId);
}
public void SetCbo_INRelaTabId()
{
clsPrjTabBL.BindCbo_INRelaTabId(cboINRelaTabId);
}
public void SetCbo_INSQLDSTypeId()
{
clsSQLDSTypeBL.BindCbo_INSQLDSTypeId(cboINSQLDSTypeId);
}
public void SetCbo_OUTRelaTabId()
{
clsPrjTabBL.BindCbo_OUTRelaTabId(cboOUTRelaTabId);
}
public void SetCbo_OUTSQLDSTypeId()
{
clsSQLDSTypeBL.BindCbo_OUTSQLDSTypeId(cboOUTSQLDSTypeId);
}
/// <summary>
/// �ж��Ƿ�������
/// </summary>
/// <param name="strValue">��Ҫ�жϵ��ַ���</param>
/// <returns>True/False</returns>
public bool IsDigit(string strValue)
{
int intLen = strValue.Length;
for(int i = 0; i<intLen; i++)
{
if (char.IsDigit(strValue, i) == false)
{
return false;
}
}
return true;
}
/// <summary>
/// �ж��Ƿ��Ǹ�������ֵ
/// </summary>
/// <param name="strValue">��Ҫ�жϵ��ַ���</param>
/// <returns>True/False</returns>
public bool IsFloat(string strValue)
{
int intPointNum = 0;
char [] arrChar = strValue.ToCharArray();
int intLen = strValue.Length;
for(int i = 0; i<intLen; i++)
{
if (char.IsDigit(strValue, i) == true || arrChar[i] == '.')
{
}
else
{
return false;
}
if (arrChar[i] == '.') intPointNum++;
}
//����ܹ��м���С���㣬����ж���1��С���㣬�Ͳ���ȷ
if (intPointNum>1) return false;
return true;
}
/// <summary>
/// �ж��Ƿ���������ֵ
/// </summary>
/// <param name="strValue">��Ҫ�жϵ��ַ���</param>
/// <returns>True/False</returns>
public bool IsNumeric(string strValue)
{
int intLen = strValue.Length;
for(int i = 0; i<intLen; i++)
{
if (char.IsDigit(strValue, i) == false)
{
return false;
}
}
return true;
}
/// <summary>
/// �������ܣ����Ըùؼ��ֵļ�¼������ʾ�ڽ����ϣ�
///������     �������ǰ�ֵ������ؼ���
/// </summary>
/// <param name="strViewId">���¼�Ĺؼ��֣���ʾ�ñ�ؼ��ֵ�����</param>
private void ShowData(string strViewId)
{
//�������裺
//1�����ؼ����Ƿ�Ϊ�գ�
//2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
//3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
//4����ȡ�������������ԣ�
//5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���

//1�����ؼ����Ƿ�Ϊ�գ�
if (strViewId == "") return ;		//����ؼ���Ϊ�վͷ����˳�
//2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
if (clsViewInfoBL.IsExist(strViewId) == false)		//���ùؼ��ֵļ�¼�Ƿ����
{
string ss = "�ؼ���Ϊ��" + strViewId + "�Ĳ�����!";
MessageBox.Show(ss);
return ;
}
//3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
objViewInfoEN = new clsViewInfoEN(strViewId);
//4����ȡ�������������ԣ�
clsViewInfoBL.GetViewInfo(ref objViewInfoEN);
//5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���
GetDataFromViewInfoClass(objViewInfoEN);
}
///���ɴ��߼�������ݴ��䵽�����ĺ�������
private void GetDataFromViewInfoClass(clsViewInfoEN pobjViewInfoEN)
{
///ע�⣺��������������򣬲�����һ��������������ϵ�ģ�����Ϊһ��������ֵ��Ȼ����Ϊ����������ֵ
///      ������������ݿ�ʱ����Ӧ��һ���ֶ���ǰ�������ֶ��ں�
this.ViewId = pobjViewInfoEN.ViewId;
this.ViewName = pobjViewInfoEN.ViewName;
this.ViewTypeCode = pobjViewInfoEN.ViewTypeCode;
this.ApplicationTypeId = pobjViewInfoEN.ApplicationTypeId;
this.FuncModuleId = pobjViewInfoEN.FuncModuleId;
this.DataBaseName = pobjViewInfoEN.DataBaseName;
this.KeyForMainTab = pobjViewInfoEN.KeyForMainTab;
this.KeyForDetailTab = pobjViewInfoEN.KeyForDetailTab;
this.IsNeedSort = pobjViewInfoEN.IsNeedSort;
this.IsNeedTransCode = pobjViewInfoEN.IsNeedTransCode;
this.UserId = pobjViewInfoEN.UserId;
this.PrjId = pobjViewInfoEN.PrjId;
this.ViewFunction = pobjViewInfoEN.ViewFunction;
this.ViewDetail = pobjViewInfoEN.ViewDetail;
this.DefaMenuName = pobjViewInfoEN.DefaMenuName;
this.DetailTabId = pobjViewInfoEN.DetailTabId;
this.FileName = pobjViewInfoEN.FileName;
this.FilePath = pobjViewInfoEN.FilePath;
this.MainTabId = pobjViewInfoEN.MainTabId;
this.ViewCnName = pobjViewInfoEN.ViewCnName;
this.ViewGroupId = pobjViewInfoEN.ViewGroupId;
this.INRelaTabId = pobjViewInfoEN.INRelaTabId;
this.INSQLDSTypeId = pobjViewInfoEN.INSQLDSTypeId;
this.OUTRelaTabId = pobjViewInfoEN.OUTRelaTabId;
this.OUTSQLDSTypeId = pobjViewInfoEN.OUTSQLDSTypeId;
this.DetailTabType = pobjViewInfoEN.DetailTabType;
this.DetailViewId = pobjViewInfoEN.DetailViewId;
this.MainTabType = pobjViewInfoEN.MainTabType;
this.MainViewId = pobjViewInfoEN.MainViewId;
this.UpdDate = pobjViewInfoEN.UpdDate;
}
/// <summary>
/// �������ܣ��¼�������������<ȷ���޸�>ʱ�������¼�������
///           ���幦��Ϊ�ѽ�������ͬ�����ݿ��У��ѽ������ݱ��浽���ݿ���
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
private void btnOKUpd_Click(object sender, System.EventArgs e)
{
string strCommandText;
Button btnTemp = (Button) sender;
strCommandText = btnTemp.Text;
switch(strCommandText)
{
case "���":
AddViewInfoRecord();
break;				
case "ȷ�����":
//����һ������Ĳ���Ĵ��룬�����߼���̫�򵥣�
//�Ͱ��߼���ϲ������Ʋ�,
AddViewInfoRecordSave();
break;
case "ȷ���޸�":
//����һ��������޸ĵĴ��룬�����߼���̫�򵥣�
//�Ͱ��߼���ϲ������Ʋ�,
UpdateViewInfoRecordSave(objViewInfoEN);
break;
}
}
private void PutDataToViewInfoClass(clsViewInfoEN pobjViewInfoEN)
{
pobjViewInfoEN.ViewId = this.ViewId;
pobjViewInfoEN.ViewName = this.ViewName;
pobjViewInfoEN.ViewTypeCode = this.ViewTypeCode;
pobjViewInfoEN.ApplicationTypeId = this.ApplicationTypeId;
pobjViewInfoEN.FuncModuleId = this.FuncModuleId;
pobjViewInfoEN.DataBaseName = this.DataBaseName;
pobjViewInfoEN.KeyForMainTab = this.KeyForMainTab;
pobjViewInfoEN.KeyForDetailTab = this.KeyForDetailTab;
pobjViewInfoEN.IsNeedSort = this.IsNeedSort;
pobjViewInfoEN.IsNeedTransCode = this.IsNeedTransCode;
pobjViewInfoEN.UserId = this.UserId;
pobjViewInfoEN.PrjId = this.PrjId;
pobjViewInfoEN.ViewFunction = this.ViewFunction;
pobjViewInfoEN.ViewDetail = this.ViewDetail;
pobjViewInfoEN.DefaMenuName = this.DefaMenuName;
pobjViewInfoEN.DetailTabId = this.DetailTabId;
pobjViewInfoEN.FileName = this.FileName;
pobjViewInfoEN.FilePath = this.FilePath;
pobjViewInfoEN.MainTabId = this.MainTabId;
pobjViewInfoEN.ViewCnName = this.ViewCnName;
pobjViewInfoEN.ViewGroupId = this.ViewGroupId;
pobjViewInfoEN.INRelaTabId = this.INRelaTabId;
pobjViewInfoEN.INSQLDSTypeId = this.INSQLDSTypeId;
pobjViewInfoEN.OUTRelaTabId = this.OUTRelaTabId;
pobjViewInfoEN.OUTSQLDSTypeId = this.OUTSQLDSTypeId;
pobjViewInfoEN.DetailTabType = this.DetailTabType;
pobjViewInfoEN.DetailViewId = this.DetailViewId;
pobjViewInfoEN.MainTabType = this.MainTabType;
pobjViewInfoEN.MainViewId = this.MainViewId;
pobjViewInfoEN.UpdDate = this.UpdDate;
}
private void btnClose_Click(object sender, System.EventArgs e)
{
this.Close();
}
public string ViewId_key
{
get
{
return mstrViewId;
}
set
{
mstrViewId = value;
}
}
///���ɵĲ����¼׼�����̴���for C#
protected void AddViewInfoRecord()
{
this.SetKeyReadOnly(false);
btnOKUpd.Text = "ȷ�����";
//this.ViewId = clsCommForWin.GetMaxStrId("ViewInfo","ViewId", 8, "");
//DispEditViewInfoRegion();
}
///�����¼���̹��̴���for C#
private void AddViewInfoRecordSave()
{
//�������裺
//1�����ؼ����������������Ƿ���ȷ
//2��������󲢳�ʼ������
//3���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
//4����ֵ�ӽ���㴫���߼��������ʵ���
//5����鴫��ȥ�Ķ��������Ƿ�Ϸ�
//6��������ʵ�������ݴ��������ݿ���
//7��������ļ�¼������ʾ��DATAGRID��
string strMsg;	//ר�����ڴ�����Ϣ�ı���
string strResult=" ";	//���ڴ����ڼ����������ʱ���ֵ�ı���
clsViewInfoEN objViewInfo;
//1�����ؼ����������������Ƿ���ȷ
if (!this.IsValid(ref strResult))
{
lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
return ;
}
//2����ʼ����������
objViewInfoEN = new clsViewInfoEN(this.ViewId);	//��ʼ���¶���
//3���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
if (clsViewInfoBL.IsExist(ViewId))	//�ж��Ƿ�����ͬ�Ĺؼ���
{
strMsg = "�ؼ����ֶ�������ͬ��ֵ";
MessageBox.Show(strMsg);
return;
}
//4����ֵ�ӽ���㴫���߼��������ʵ���
PutDataToViewInfoClass(objViewInfoEN);		//�ѽ����ֵ����
//5����鴫��ȥ�Ķ��������Ƿ�Ϸ�
try
{
clsViewInfoBL.CheckPropertyNew(objViewInfoEN);
//6��������ʵ�������ݴ��������ݿ���
clsViewInfoBL.AddNewRecordBySql2(objViewInfoEN);
}
catch(Exception objException)
{
strMsg = "��Ӽ�¼���ɹ�!" + objException.Message;
MessageBox.Show(strMsg );
lblMsg.Text = strMsg;
return;
}
strMsg = "��Ӽ�¼�ɹ�!";
MessageBox.Show(strMsg);
lblMsg.Text = "��Ӽ�¼�ɹ�!";
//7���ָ�<ȷ�����>���<���>
btnOKUpd.Text = "���";
//8�����ø������к���BINDLISTVIEW()�Ѹ������е�LISTVIEW����������ʾһ�¡�
iBindListView.BindListView();
}
    ///�޸Ĵ���׼�����̴��� for C#
private void UpdateViewInfoRecordSave(clsViewInfoEN objViewInfoEN)
{
//�������裺
//1�����ؼ����������������Ƿ���ȷ
//2����ֵ�ӽ���㴫���߼��������ʵ���
//3����鴫��ȥ�Ķ��������Ƿ�Ϸ�
//4��������ʵ�������ݴ��������ݿ���
//5�����޸ĺ��������ʾ��DATAGRID��
string strMsg;	//ר�����ڴ�����Ϣ�ı���
string strResult=" ";	//���ڴ����ڼ����������ʱ���ֵ�ı���
//1�����ؼ����������������Ƿ���ȷ
if (!this.IsValid(ref strResult))
{
lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
return ;
}
//2����ֵ�ӽ���㴫���߼��������ʵ���
PutDataToViewInfoClass(objViewInfoEN);		//�ѽ����ֵ����
//3����鴫��ȥ�Ķ��������Ƿ�Ϸ�
try
{
clsViewInfoBL.CheckPropertyNew(objViewInfoEN);
//6��������ʵ�������ݴ��������ݿ���
clsViewInfoBL.UpdateBySql2(objViewInfoEN);
}
catch(Exception objException)
{
strMsg = "�޸ļ�¼���ɹ�!" + objException.Message;
MessageBox.Show(strMsg);
lblMsg.Text = strMsg;
return ; 
}
strMsg = "�޸ļ�¼�ɹ�!";
MessageBox.Show(strMsg);
lblMsg.Text = "�޸ļ�¼�ɹ�!";
this.Close();
//5���ָ�<ȷ���޸�>���<���>
btnOKUpd.Text = "���";
//6�����ø������к���BINDLISTVIEW()�Ѹ������е�LISTVIEW����������ʾһ�¡�
iBindListView.BindListView();
}
}
}