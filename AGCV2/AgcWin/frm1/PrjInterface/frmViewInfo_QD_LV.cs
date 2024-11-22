
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
using com.taishsoft.util;
using CommFunc4Win;
using com.taishsoft.commdb;
using AGC_CSV7.Entity;
using AGC_CSV7.BusinessLogic;

namespace AGC_CSV7
{
/// <summary>
///		frmViewInfo_QD_LV ��ժҪ˵����
/// </summary>
public partial class frmViewInfo_QD_LV : System.Windows.Forms.Form, IBindListView
{
clsViewInfoEN objViewInfoEN = null;
private System.Data.DataTable objDTViewInfo = null;
private clsListViewSorter objvViewInfoSorter;
private int intLastSelectedvViewInfoColumIndex ;
public frmViewInfo_QD_LV()
{
// �õ����� Windows.Forms ���������������ġ�
InitializeComponent();

// TODO: �� InitializeComponent ���ú�����κγ�ʼ��
objvViewInfoSorter = new clsListViewSorter();
//ΪListViewItemSorterָ��������
this.lvvViewInfo.ListViewItemSorter = objvViewInfoSorter;
objvViewInfoSorter.SortOrder=SortOrder.Ascending;

}
private void frmViewInfo_QD_Load(object sender, System.EventArgs e)
{
// �ڴ˴������û������Գ�ʼ��ҳ��
//1��Ϊ��������������Դ�����б�����
this.SetAllComboBox();
BindLv_vViewInfo();
this.JudgebtnDelRec(); //�����ж�ɾ����ť�Ƿ����
this.JudgebtnUpdate(); //�����ж��޸İ�ť�Ƿ����

}
/// <summary>
/// ������İ󶨺���
/// </summary>
private void SetAllComboBox()
{
this.BindCbo_ViewTypeCode(this.cboViewTypeCode);
this.BindCbo_ApplicationTypeId(this.cboApplicationTypeId);
this.BindCbo_FuncModuleId(this.cboFuncModuleId);
this.BindCbo_PrjId(this.cboPrjId);
this.BindCbo_MainTabId(this.cboMainTabId);
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

public string MainTabId
{
get
{
if (cboMainTabId.SelectedValue.ToString() == "0")
return "";
return cboMainTabId.SelectedValue.ToString();
}
set
{
if (value == "")
{
cboMainTabId.SelectedValue = "0";
}
else
{
cboMainTabId.SelectedValue = value;
}
}
}


public void Clear()
{
txtViewName.Text = "";
cboViewTypeCode.SelectedIndex = 0;
cboApplicationTypeId.SelectedIndex = 0;
cboFuncModuleId.SelectedIndex = 0;
cboPrjId.SelectedIndex = 0;
cboMainTabId.SelectedIndex = 0;
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
txtViewName.Text = "";
cboViewTypeCode.SelectedIndex = 0;
cboApplicationTypeId.SelectedIndex = 0;
cboFuncModuleId.SelectedIndex = 0;
cboPrjId.SelectedIndex = 0;
cboMainTabId.SelectedIndex = 0;
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
public void SetCbo_PrjId()
{
clsProjectsBL.BindCbo_PrjId(cboPrjId);
}
public void SetCbo_MainTabId()
{
clsPrjTabBL.BindCbo_MainTabId(cboMainTabId);
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
/// �����еĲ�ѯ�ؼ�������ϳ�һ��������
/// </summary>
/// <returns>������(strWhereCond)</returns>
public string CombineViewInfoCondion()
{
//ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
//���� 1=1 && UserName = '����'
string strWhereCond=" 1=1 ";
//����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
if (this.txtViewName.Text.Trim()!="")
{
strWhereCond += " And ViewInfo.ViewName like '%" + this.txtViewName.Text.Trim()+"%'";
}
if (this.cboViewTypeCode.SelectedValue.ToString()!="" && this.cboViewTypeCode.SelectedValue.ToString()!="0")
{
strWhereCond += " And ViewInfo.ViewTypeCode='" + this.cboViewTypeCode.SelectedValue+"'";
}
if (this.cboApplicationTypeId.SelectedValue.ToString()!="" && this.cboApplicationTypeId.SelectedValue.ToString()!="0")
{
strWhereCond += " And ViewInfo.ApplicationTypeId='" + this.cboApplicationTypeId.SelectedValue+"'";
}
if (this.cboFuncModuleId.SelectedValue.ToString()!="" && this.cboFuncModuleId.SelectedValue.ToString()!="0")
{
strWhereCond += " And ViewInfo.FuncModuleId='" + this.cboFuncModuleId.SelectedValue+"'";
}
if (this.cboPrjId.SelectedValue.ToString()!="" && this.cboPrjId.SelectedValue.ToString()!="0")
{
strWhereCond += " And ViewInfo.PrjId='" + this.cboPrjId.SelectedValue+"'";
}
if (this.cboMainTabId.SelectedValue.ToString()!="" && this.cboMainTabId.SelectedValue.ToString()!="0")
{
strWhereCond += " And ViewInfo.MainTabId='" + this.cboMainTabId.SelectedValue+"'";
}
return strWhereCond;
}
/// <summary>
/// �����еĲ�ѯ�ؼ�������ϳ�һ��������
/// </summary>
/// <returns>������(strWhereCond)</returns>
public string CombineViewInfoCondion(bool bolIsWithTabName)
{
//ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
//���� 1=1 && UserName = '����'
string strWhereCond=" 1=1 ";
//����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
if (bolIsWithTabName == true)
{
if (this.txtViewName.Text.Trim()!="")
{
strWhereCond += " And ViewInfo.ViewName like '%" + this.txtViewName.Text.Trim()+"%'";
}
if (this.cboViewTypeCode.SelectedValue.ToString()!="" && this.cboViewTypeCode.SelectedValue.ToString()!="0")
{
strWhereCond += " And ViewInfo.ViewTypeCode='" + this.cboViewTypeCode.SelectedValue+"'";
}
if (this.cboApplicationTypeId.SelectedValue.ToString()!="" && this.cboApplicationTypeId.SelectedValue.ToString()!="0")
{
strWhereCond += " And ViewInfo.ApplicationTypeId='" + this.cboApplicationTypeId.SelectedValue+"'";
}
if (this.cboFuncModuleId.SelectedValue.ToString()!="" && this.cboFuncModuleId.SelectedValue.ToString()!="0")
{
strWhereCond += " And ViewInfo.FuncModuleId='" + this.cboFuncModuleId.SelectedValue+"'";
}
if (this.cboPrjId.SelectedValue.ToString()!="" && this.cboPrjId.SelectedValue.ToString()!="0")
{
strWhereCond += " And ViewInfo.PrjId='" + this.cboPrjId.SelectedValue+"'";
}
if (this.cboMainTabId.SelectedValue.ToString()!="" && this.cboMainTabId.SelectedValue.ToString()!="0")
{
strWhereCond += " And ViewInfo.MainTabId='" + this.cboMainTabId.SelectedValue+"'";
}
}
else
{
if (this.txtViewName.Text.Trim()!="")
{
strWhereCond += " And ViewName like '%" + this.txtViewName.Text.Trim()+"%'";
}
if (this.cboViewTypeCode.SelectedValue.ToString()!="" && this.cboViewTypeCode.SelectedValue.ToString()!="0")
{
strWhereCond += " And ViewTypeCode='" + this.cboViewTypeCode.SelectedValue+"'";
}
if (this.cboApplicationTypeId.SelectedValue.ToString()!="" && this.cboApplicationTypeId.SelectedValue.ToString()!="0")
{
strWhereCond += " And ApplicationTypeId='" + this.cboApplicationTypeId.SelectedValue+"'";
}
if (this.cboFuncModuleId.SelectedValue.ToString()!="" && this.cboFuncModuleId.SelectedValue.ToString()!="0")
{
strWhereCond += " And FuncModuleId='" + this.cboFuncModuleId.SelectedValue+"'";
}
if (this.cboPrjId.SelectedValue.ToString()!="" && this.cboPrjId.SelectedValue.ToString()!="0")
{
strWhereCond += " And PrjId='" + this.cboPrjId.SelectedValue+"'";
}
if (this.cboMainTabId.SelectedValue.ToString()!="" && this.cboMainTabId.SelectedValue.ToString()!="0")
{
strWhereCond += " And MainTabId='" + this.cboMainTabId.SelectedValue+"'";
}
}
return strWhereCond;
}
/// <summary>
/// �����еĲ�ѯ�ؼ�������ϳ�һ��������
/// </summary>
/// <returns>������(strWhereCond)</returns>
public string CombineViewInfoCondion(string strTabName)
{
//ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
//���� 1=1 && UserName = '����'
string strWhereCond=" 1=1 ";
//����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
if (this.txtViewName.Text.Trim()!="")
{
strWhereCond += " And " + strTabName +".ViewName like '%" + this.txtViewName.Text.Trim()+"%'";
}
if (this.cboViewTypeCode.SelectedValue.ToString()!="" && this.cboViewTypeCode.SelectedValue.ToString()!="0")
{
strWhereCond += " And " + strTabName + ".ViewTypeCode='" + this.cboViewTypeCode.SelectedValue+"'";
}
if (this.cboApplicationTypeId.SelectedValue.ToString()!="" && this.cboApplicationTypeId.SelectedValue.ToString()!="0")
{
strWhereCond += " And " + strTabName + ".ApplicationTypeId='" + this.cboApplicationTypeId.SelectedValue+"'";
}
if (this.cboFuncModuleId.SelectedValue.ToString()!="" && this.cboFuncModuleId.SelectedValue.ToString()!="0")
{
strWhereCond += " And " + strTabName + ".FuncModuleId='" + this.cboFuncModuleId.SelectedValue+"'";
}
if (this.cboPrjId.SelectedValue.ToString()!="" && this.cboPrjId.SelectedValue.ToString()!="0")
{
strWhereCond += " And " + strTabName + ".PrjId='" + this.cboPrjId.SelectedValue+"'";
}
if (this.cboMainTabId.SelectedValue.ToString()!="" && this.cboMainTabId.SelectedValue.ToString()!="0")
{
strWhereCond += " And " + strTabName + ".MainTabId='" + this.cboMainTabId.SelectedValue+"'";
}
return strWhereCond;
}
/// <summary>
/// �������ܣ������ж�ɾ����ť�Ƿ���á�
///			 �����LISTVIEW��ѡ�м�¼����ʾɾ����ť������Ͳ���ʾ
/// </summary>
private void JudgebtnDelRec()
{
if (this.lvvViewInfo.SelectedItems.Count >= 1)
{
this.btnDelRec.Enabled = true;
}
else
{             
this.btnDelRec.Enabled = false;
}
}
/// <summary>
/// �������ܣ������ж�ɾ����ť�Ƿ���á�
///			 �����LISTVIEW��ѡ�м�¼����ʾɾ����ť������Ͳ���ʾ
/// </summary>
private void JudgebtnUpdate()
{
if (this.lvvViewInfo.SelectedItems.Count >= 1)
{
this.btnUpdate.Enabled = true;
}
else
{             
this.btnUpdate.Enabled = false;
}
}
///���ɰ�ListView�Ĵ���
/// <summary>
/// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
///			 ����ʾ��ListView�С�
/// </summary>
private void BindLv_vViewInfo()
{
//�������裺(��4��)
//	1����Ͻ�����������
//	2��������������ȡ�ñ�����������DataTable��
//	3������ListView����ͷ��Ϣ
//	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��
//		�ڱ��������ǰ�״̬��ʾ�ڿؼ�lblRecCount�С�

ListViewItem lvivViewInfo; 
List<clsvViewInfoEN> arrvViewInfoObjList;
//	1����Ͻ�����������
string strWhereCond = this.CombineViewInfoCondion(false);	//  CombineViewInfoCondion();
//	2��������������ȡ�ñ�����������DataTable��
arrvViewInfoObjList = clsvViewInfoBL.GetvViewInfoObjList(strWhereCond);
//	3������ListView����ͷ��Ϣ
this.lvvViewInfo.Items.Clear();//���ԭ������Item
this.lvvViewInfo.Columns.Clear();//���ԭ��������ͷ��Ϣ
this.lvvViewInfo.Columns.Add("����ID", 100, HorizontalAlignment.Left);
this.lvvViewInfo.Columns.Add("��������", 100, HorizontalAlignment.Left);
this.lvvViewInfo.Columns.Add("������������", 100, HorizontalAlignment.Left);
this.lvvViewInfo.Columns.Add("����ģ������", 100, HorizontalAlignment.Left);
this.lvvViewInfo.Columns.Add("MainTabName", 100, HorizontalAlignment.Left);
this.lvvViewInfo.Columns.Add("����ؼ���", 100, HorizontalAlignment.Left);
this.lvvViewInfo.Columns.Add("Ӧ�ó�����������", 100, HorizontalAlignment.Left);
this.lvvViewInfo.Columns.Add("��������", 100, HorizontalAlignment.Left);
this.lvvViewInfo.Columns.Add("����������", 100, HorizontalAlignment.Left);
this.lvvViewInfo.Columns.Add("���ݿ���", 100, HorizontalAlignment.Left);
this.lvvViewInfo.View = View.Details;
//	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��
foreach (clsvViewInfoEN objvViewInfoEN in arrvViewInfoObjList)
{
lvivViewInfo = new ListViewItem();
lvivViewInfo.Tag = objvViewInfoEN.ViewId;
lvivViewInfo.Text = objvViewInfoEN.ViewId;
lvivViewInfo.SubItems.Add(objvViewInfoEN.ViewName);
lvivViewInfo.SubItems.Add(objvViewInfoEN.ViewTypeName);
lvivViewInfo.SubItems.Add(objvViewInfoEN.FuncModuleName);
lvivViewInfo.SubItems.Add(objvViewInfoEN.MainTabName);
lvivViewInfo.SubItems.Add(objvViewInfoEN.KeyForMainTab);
lvivViewInfo.SubItems.Add(objvViewInfoEN.ApplicationTypeName);
lvivViewInfo.SubItems.Add(objvViewInfoEN.PrjName);
lvivViewInfo.SubItems.Add(objvViewInfoEN.ViewGroupName);
lvivViewInfo.SubItems.Add(objvViewInfoEN.DataBaseName);
this.lvvViewInfo.Items.Add(lvivViewInfo);
}
//	4�����ü�¼����״̬��
//		�ڱ��������ǰ�״̬��ʾ�ڿؼ�txtRecCount�С�
this.lblRecNum.Text = "��¼����" + arrvViewInfoObjList.Count.ToString();
}
private void btnQuery_Click(object sender, System.EventArgs e)
{
//�ѱ��¼��������ʾ��ListView��
BindLv_vViewInfo();
}
/// <summary>
/// ��ȡDataGrid�е�ǰ�е�����ֵ
/// </summary>
/// <param name="objDataGrid">��������DataGrid</param>
/// <returns>��ǰ�е�����ֵ</returns>
private string GetCurrKey(DataGrid objDataGrid)
{
int intCurrRow = objDataGrid.CurrentRowIndex;
string strViewId = objDTViewInfo.Rows[intCurrRow]["ViewId"].ToString();
return strViewId;
}
/// <summary>
/// ��ȡListView�е�ǰ�е�����ֵ
/// </summary>
/// <param name="objListView">��������ListView</param>
/// <returns>��ǰ�е�����ֵ</returns>
private string GetCurrKey(ListView objListView)
{
if (objListView.SelectedItems.Count == 0)
{
return "";
}
ListViewItem lviViewInfo;
lviViewInfo = objListView.SelectedItems[0];
string strViewInfoId = lviViewInfo.Tag.ToString();
return strViewInfoId;
}
/// <summary>
/// ��ȡListView�����������ֵ
/// </summary>
/// <param name="objListView">��������ListView��</param>
/// <returns>��ǰ�е�����ֵ</returns>
private string GetCurrKey(ListViewItem objListViewItem)
{
string strViewInfoId = objListViewItem.Tag.ToString();
return strViewInfoId;
}
private void lvvViewInfo_Click(object sender, System.EventArgs e)
{
this.JudgebtnDelRec(); //�����ж�ɾ����ť�Ƿ����
this.JudgebtnUpdate(); //�����ж��޸İ�ť�Ƿ����
}
/// <summary>
/// �������ܣ��¼�������������<ȷ���޸�>ʱ�������¼�������
///           ���幦��Ϊ�ѽ�������ͬ�����ݿ��У��ѽ������ݱ��浽���ݿ���
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
private void btnUpdate_Click(object sender, System.EventArgs e)
{
UpdateViewInfoRecord();
}
/// <summary>
/// �������ܣ��¼�������������<ȷ���޸�>ʱ�������¼�������
///           ���幦��Ϊ�ѽ�������ͬ�����ݿ��У��ѽ������ݱ��浽���ݿ���
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
private void btnAdd_Click(object sender, System.EventArgs e)
{
frmViewInfo_UI frm = new frmViewInfo_UI();
frm.iBindListView = this;
frm.OperateType = "Add";
frm.ShowDialog();
}
private void btnDelRec_Click(object sender, System.EventArgs e)
{
DeleteViewInfoRecord();
}
private void btnExportExcel4Dg_Click(object sender, System.EventArgs e)
{
ExportExcel_SelColumns();	//�µĵ���EXCEL��ʽ���û�����ѡ�񵼳��ֶ���
//ExportExcel();	//ԭ���ķ�ʽ����EXCEL���û�����ѡ�񵼳��ֶ���
}
/// <summary>
/// ����EXCEL�ĺ���
/// </summary>
private void ExportExcel()
{
//	1����Ͻ�����������
string strWhereCond = this.CombineViewInfoCondion(true);
//	2��������������ȡ�ñ�����������DataTable��
System.Data.DataTable objDT = clsViewInfoBL.GetDataTable_ViewInfo(strWhereCond);
ArrayList arrCnName = new ArrayList();
ArrayList arrColName = new ArrayList();
//string strFileName = "ViewInfo��Ϣ����.xls";
//string strFolderName;
string strDownLoadFileName;
arrColName.Add("ViewId"); arrCnName.Add("����ID");
arrColName.Add("ApplicationTypeName"); arrCnName.Add("Ӧ�ó�����������");
arrColName.Add("ViewGroupName"); arrCnName.Add("����������");
arrColName.Add("ViewName"); arrCnName.Add("��������");
arrColName.Add("ViewCnName"); arrCnName.Add("��ͼ������");
arrColName.Add("ViewTypeName"); arrCnName.Add("������������");
arrColName.Add("FuncModuleName"); arrCnName.Add("����ģ������");
arrColName.Add("MainTabName"); arrCnName.Add("MainTabName");
arrColName.Add("DetailTabName"); arrCnName.Add("DetailTabName");
arrColName.Add("TitleStyleName"); arrCnName.Add("����������");
arrColName.Add("DGStyleName"); arrCnName.Add("DGģʽ��");
arrColName.Add("ViewTypeCode"); arrCnName.Add("����������");
arrColName.Add("DataBaseName"); arrCnName.Add("���ݿ���");
arrColName.Add("KeyForMainTab"); arrCnName.Add("����ؼ���");
arrColName.Add("KeyForDetailTab"); arrCnName.Add("��ϸ��ؼ���");
arrColName.Add("IsNeedSort"); arrCnName.Add("�Ƿ���Ҫ����");
arrColName.Add("IsNeedTransCode"); arrCnName.Add("�Ƿ���Ҫת������");
arrColName.Add("UserId"); arrCnName.Add("�û�ID");
arrColName.Add("PrjId"); arrCnName.Add("����ID");
arrColName.Add("ViewFunction"); arrCnName.Add("���湦��");
arrColName.Add("ViewDetail"); arrCnName.Add("����˵��");
arrColName.Add("PrjName"); arrCnName.Add("��������");
arrColName.Add("FuncModuleId"); arrCnName.Add("����ģ��Id");
arrColName.Add("FileName"); arrCnName.Add("�ļ���");
arrColName.Add("FilePath"); arrCnName.Add("�ļ�·��");
arrColName.Add("DefaMenuName"); arrCnName.Add("ȱʡ�˵���");
arrColName.Add("MainTabId"); arrCnName.Add("����ID");
arrColName.Add("DetailTabId"); arrCnName.Add("��ϸ��ID");
arrColName.Add("ApplicationTypeId"); arrCnName.Add("Ӧ�ó�������ID");
arrColName.Add("ViewGroupId"); arrCnName.Add("������ID");
arrColName.Add("MainTabKeyFld"); arrCnName.Add("MainTabKeyFld");
arrColName.Add("DetailTabKeyFld"); arrCnName.Add("DetailTabKeyFld");
arrColName.Add("FuncModuleEnName"); arrCnName.Add("����ģ��Ӣ������");
//strFolderName = Application.StartupPath + "\\TempFiles";
//if (Directory.Exists(strFolderName) == false)
//{
//Directory.CreateDirectory(strFolderName);
//}
//strDownLoadFileName = strFolderName + "\\" + strFileName;
System.Windows.Forms.SaveFileDialog objSaveFileDialog = new SaveFileDialog();
objSaveFileDialog.DefaultExt = "xls";
objSaveFileDialog.Filter = "Excle�ļ�(*.xls)|*.xls|�����ļ�(*.*)|*.*";
objSaveFileDialog.ShowDialog();
strDownLoadFileName = objSaveFileDialog.FileName;
if (strDownLoadFileName=="")
{
return ;
}
GetExcelFromDataTable.clsGetExcelFromDataTable objExcel = new GetExcelFromDataTable.clsGetExcelFromDataTable();
objExcel.GetExcelFromDataTableByArrAndArray(objDT, arrColName, arrCnName, strDownLoadFileName);
MessageBox.Show("����Excel�ɹ�!���ļ�����ڣ�" + strDownLoadFileName);
}
/// <summary>
/// ����EXCEL�ĺ���, ����EXCELʱ����ѡ����
/// </summary>
private void ExportExcel_SelColumns()
{
//	1����Ͻ�����������
string strWhereCond = this.CombineViewInfoCondion(true);
//	2�����ñ��������ֶ������Լ����б���
ArrayList arrCnName = new ArrayList();
ArrayList arrColName = new ArrayList();
arrColName.Add("ViewId"); arrCnName.Add("����ID");
arrColName.Add("ApplicationTypeName"); arrCnName.Add("Ӧ�ó�����������");
arrColName.Add("ViewGroupName"); arrCnName.Add("����������");
arrColName.Add("ViewName"); arrCnName.Add("��������");
arrColName.Add("ViewCnName"); arrCnName.Add("��ͼ������");
arrColName.Add("ViewTypeName"); arrCnName.Add("������������");
arrColName.Add("FuncModuleName"); arrCnName.Add("����ģ������");
arrColName.Add("MainTabName"); arrCnName.Add("MainTabName");
arrColName.Add("DetailTabName"); arrCnName.Add("DetailTabName");
arrColName.Add("TitleStyleName"); arrCnName.Add("����������");
arrColName.Add("DGStyleName"); arrCnName.Add("DGģʽ��");
arrColName.Add("ViewTypeCode"); arrCnName.Add("����������");
arrColName.Add("DataBaseName"); arrCnName.Add("���ݿ���");
arrColName.Add("KeyForMainTab"); arrCnName.Add("����ؼ���");
arrColName.Add("KeyForDetailTab"); arrCnName.Add("��ϸ��ؼ���");
arrColName.Add("IsNeedSort"); arrCnName.Add("�Ƿ���Ҫ����");
arrColName.Add("IsNeedTransCode"); arrCnName.Add("�Ƿ���Ҫת������");
arrColName.Add("UserId"); arrCnName.Add("�û�ID");
arrColName.Add("PrjId"); arrCnName.Add("����ID");
arrColName.Add("ViewFunction"); arrCnName.Add("���湦��");
arrColName.Add("ViewDetail"); arrCnName.Add("����˵��");
arrColName.Add("PrjName"); arrCnName.Add("��������");
arrColName.Add("FuncModuleId"); arrCnName.Add("����ģ��Id");
arrColName.Add("FileName"); arrCnName.Add("�ļ���");
arrColName.Add("FilePath"); arrCnName.Add("�ļ�·��");
arrColName.Add("DefaMenuName"); arrCnName.Add("ȱʡ�˵���");
arrColName.Add("MainTabId"); arrCnName.Add("����ID");
arrColName.Add("DetailTabId"); arrCnName.Add("��ϸ��ID");
arrColName.Add("ApplicationTypeId"); arrCnName.Add("Ӧ�ó�������ID");
arrColName.Add("ViewGroupId"); arrCnName.Add("������ID");
arrColName.Add("MainTabKeyFld"); arrCnName.Add("MainTabKeyFld");
arrColName.Add("DetailTabKeyFld"); arrCnName.Add("DetailTabKeyFld");
arrColName.Add("FuncModuleEnName"); arrCnName.Add("����ģ��Ӣ������");
ArrayList arrExportExcelList = new ArrayList();
clsExportField objExportField = null;
int intColNum = arrColName.Count;
for(int i = 0; i<intColNum; i++)
{
objExportField = new clsExportField();
objExportField.FieldEnglishName = arrColName[i].ToString();
objExportField.FieldChineseName = arrCnName[i].ToString();
arrExportExcelList.Add(objExportField);
}
/// 3�����ù��õĵ���EXCEL�Ľ��棬ѡ���к��ٵ���
frmExportExcel frm1 = new frmExportExcel();
frm1.arrExportExcelList = arrExportExcelList;
frm1.strTableName = "vViewInfo";
frm1.strTableChineseName = "vViewInfo";
frm1.strViewName = "������Ϣά��";
frm1.strWhereCondition = strWhereCond;
frm1.Show();
}

/// <summary>
/// �������ܣ�LISTVIEW���е����¼�����
/// </summary>
private void lvvViewInfo_ColumnClick(object sender, System.Windows.Forms.ColumnClickEventArgs e)
{
if (e.Column == this.objvViewInfoSorter.SortColumn)
{

}
else
{
this.objvViewInfoSorter.SortColumn=e.Column;
}

if (this.objvViewInfoSorter.SortOrder==SortOrder.Ascending)
{
this.objvViewInfoSorter.SortOrder=SortOrder.Descending;
if(intLastSelectedvViewInfoColumIndex == e.Column) //���Ƿ��ظ����һ��
{
this.lvvViewInfo.Columns[e.Column].Text = this.lvvViewInfo.Columns[e.Column].Text.Trim('��','��') + "��";
intLastSelectedvViewInfoColumIndex = e.Column;
}
else //����������һ���ˣ���ôǰ������һ������ȥ��
{
this.lvvViewInfo.Columns[e.Column].Text = this.lvvViewInfo.Columns[e.Column].Text.Trim('��','��') + "��";
this.lvvViewInfo.Columns[intLastSelectedvViewInfoColumIndex].Text = this.lvvViewInfo.Columns[intLastSelectedvViewInfoColumIndex].Text.Trim('��','��');
intLastSelectedvViewInfoColumIndex = e.Column;
}
}
else if (this.objvViewInfoSorter.SortOrder==SortOrder.Descending) // �� ��
{
this.objvViewInfoSorter.SortOrder=SortOrder.Ascending;
if(intLastSelectedvViewInfoColumIndex == e.Column)
{
this.lvvViewInfo.Columns[e.Column].Text = this.lvvViewInfo.Columns[e.Column].Text.Trim('��','��') + "��";
intLastSelectedvViewInfoColumIndex = e.Column;
}
else
{
this.lvvViewInfo.Columns[e.Column].Text = this.lvvViewInfo.Columns[e.Column].Text.Trim('��','��') + "��";
this.lvvViewInfo.Columns[intLastSelectedvViewInfoColumIndex].Text = this.lvvViewInfo.Columns[intLastSelectedvViewInfoColumIndex].Text.Trim('��','��');
intLastSelectedvViewInfoColumIndex = e.Column;
}
}
else
{
return ;
}
this.lvvViewInfo.Sort();
}

/// <summary>
/// ʵ�ֽӿں�����ͨ���Ӵ�����ã���ʵ�ֱ�����(������)��LISTVIEW���°󶨹���
/// </summary>
void IBindListView.BindListView()
{
BindLv_vViewInfo();
}
///�����޸ļ�¼׼�����̴��� for C#
private void UpdateViewInfoRecord()
{
if(this.lvvViewInfo.SelectedItems.Count!=1)
{
DialogResult result;
result = MessageBox.Show("��ѡ��һ����¼��");
return;
}
frmViewInfo_UI frm = new frmViewInfo_UI();
string strKeyId = this.lvvViewInfo.SelectedItems[0].Tag.ToString();
frm.ViewId_key = strKeyId;
frm.iBindListView = this;
frm.OperateType = "Update";
frm.ShowDialog();
}
 ///ɾ����¼���̴���for C#
private void DeleteViewInfoRecord()
{
DialogResult result;
result = MessageBox.Show("�����Ҫɾ���ü�¼��", "ȷ��ɾ��", MessageBoxButtons.YesNo);
if (result == DialogResult.Yes)
{
foreach(ListViewItem lvi in this.lvvViewInfo.SelectedItems)
{
string strViewId = GetCurrKey(lvi);
if(clsViewInfoBL.DelRecord(strViewId)== false)
{
MessageBox.Show("ɾ����¼ʧ�ܣ�");
BindLv_vViewInfo();
return ;
}
}
MessageBox.Show("ɾ����¼�ɹ���");
BindLv_vViewInfo();
}
}
}
}