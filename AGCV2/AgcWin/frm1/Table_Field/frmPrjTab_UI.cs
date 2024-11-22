
///----------------------
///���ɴ���汾��2012.01.02.1
///�������ڣ�2012/10/17
///�����ߣ����Է�
///�������ƣ�AGC_CSV7
///����ID��0005
///ģ�����������ֶΡ���ά��
///ģ��Ӣ������Table_Field
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
///		frmPrjTab_UI ��ժҪ˵����
/// </summary>
public partial class frmPrjTab_UI : System.Windows.Forms.Form
{
clsPrjTabEN objPrjTabEN = null;
private string mstrTabId;		//���ڴ��ݹؼ���ֵ�ı���
public string OperateType;
public IBindListView iBindListView = null;
public frmPrjTab_UI()
{
// �õ����� Windows.Forms ���������������ġ�
InitializeComponent();

// TODO: �� InitializeComponent ���ú�����κγ�ʼ��

}
private void frmPrjTab_UI_Load(object sender, System.EventArgs e)
{
// �ڴ˴������û������Գ�ʼ��ҳ��
//1��Ϊ��������������Դ�����б�����
this.SetAllComboBox();
if (OperateType == "Update")
{
ShowData(mstrTabId);
btnOKUpd.Text = "ȷ���޸�";
}
else
{
AddPrjTabRecord();
}

}
/// <summary>
/// ������İ󶨺���
/// </summary>
private void SetAllComboBox()
{
this.BindCbo_PrjId(this.cboPrjId);
this.BindCbo_ObjId(this.cboObjId);
this.BindCbo_SQLDSTypeId(this.cboSQLDSTypeId);
this.BindCbo_TabStateId(this.cboTabStateId);
this.BindCbo_FuncModuleId(this.cboFuncModuleId);
}
public string TabId
{
get
{
return txtTabId.Text.Trim();
}
set
{
txtTabId.Text = value.ToString();
}
}

public string TabName
{
get
{
return txtTabName.Text.Trim();
}
set
{
txtTabName.Text = value.ToString();
}
}

public string TabCnName
{
get
{
return txtTabCnName.Text.Trim();
}
set
{
txtTabCnName.Text = value.ToString();
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

public string ObjId
{
get
{
if (cboObjId.SelectedValue.ToString() == "0")
return "";
return cboObjId.SelectedValue.ToString();
}
set
{
if (value == "")
{
cboObjId.SelectedValue = "0";
}
else
{
cboObjId.SelectedValue = value;
}
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

public string SQLDSTypeId
{
get
{
if (cboSQLDSTypeId.SelectedValue.ToString() == "0")
return "";
return cboSQLDSTypeId.SelectedValue.ToString();
}
set
{
if (value == "")
{
cboSQLDSTypeId.SelectedValue = "0";
}
else
{
cboSQLDSTypeId.SelectedValue = value;
}
}
}

public string TabStateId
{
get
{
if (cboTabStateId.SelectedValue.ToString() == "0")
return "";
return cboTabStateId.SelectedValue.ToString();
}
set
{
if (value == "")
{
cboTabStateId.SelectedValue = "0";
}
else
{
cboTabStateId.SelectedValue = value;
}
}
}

public string TabName_B
{
get
{
return txtTabName_B.Text.Trim();
}
set
{
txtTabName_B.Text = value.ToString();
}
}

public bool IsParaTab
{
get
{
return chkIsParaTab.Checked;
}
set
{
chkIsParaTab.Checked = value;
}
}

public bool IsNationStandard
{
get
{
return chkIsNationStandard.Checked;
}
set
{
chkIsNationStandard.Checked = value;
}
}

public bool IsArchive
{
get
{
return chkIsArchive.Checked;
}
set
{
chkIsArchive.Checked = value;
}
}

public bool IsChecked
{
get
{
return chkIsChecked.Checked;
}
set
{
chkIsChecked.Checked = value;
}
}

public string ErrMsg
{
get
{
return txtErrMsg.Text.Trim();
}
set
{
txtErrMsg.Text = value.ToString();
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

public string Owner
{
get
{
return txtOwner.Text.Trim();
}
set
{
txtOwner.Text = value.ToString();
}
}

public string Memo
{
get
{
return txtMemo.Text.Trim();
}
set
{
txtMemo.Text = value.ToString();
}
}


public void SetKeyReadOnly(bool bolReadonly)
{
txtTabId.ReadOnly = bolReadonly;
}
public void Clear()
{
txtTabId.Text = "";
txtTabName.Text = "";
txtTabCnName.Text = "";
cboPrjId.SelectedIndex = 0;
cboObjId.SelectedIndex = 0;
chkIsNeedTransCode.Checked = false;
cboSQLDSTypeId.SelectedIndex = 0;
cboTabStateId.SelectedIndex = 0;
txtTabName_B.Text = "";
chkIsParaTab.Checked = false;
chkIsNationStandard.Checked = false;
chkIsArchive.Checked = false;
chkIsChecked.Checked = false;
txtErrMsg.Text = "";
cboFuncModuleId.SelectedIndex = 0;
txtDataBaseName.Text = "";
txtOwner.Text = "";
txtMemo.Text = "";
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
txtTabId.Text = "";
txtTabName.Text = "";
txtTabCnName.Text = "";
cboPrjId.SelectedIndex = 0;
cboObjId.SelectedIndex = 0;
chkIsNeedTransCode.Checked = false;
cboSQLDSTypeId.SelectedIndex = 0;
cboTabStateId.SelectedIndex = 0;
txtTabName_B.Text = "";
chkIsParaTab.Checked = false;
chkIsNationStandard.Checked = false;
chkIsArchive.Checked = false;
chkIsChecked.Checked = false;
txtErrMsg.Text = "";
cboFuncModuleId.SelectedIndex = 0;
txtDataBaseName.Text = "";
txtOwner.Text = "";
txtMemo.Text = "";
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
public System.Data.DataTable GetObjId()
{
//��ȡĳѧԺ����רҵ��Ϣ
string strSQL = "select ObjId, ObjName from PrjObjects ";
clsSpecSQLforSql mySql=new clsSpecSQLforSql();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}
public void BindCbo_ObjId(System.Windows.Forms.ComboBox objComboBox)
{
//Ϊ����ԴΪ�����������������
System.Data.DataTable objDT = GetObjId();
clsPrjObjectsEN objPrjObjectsEN;
//��ʼ��һ�������б�
ArrayList PrjObjectsList = new ArrayList();
//�����0��ڵ�0���в���"��ѡ��..."��Ϊ�˷����û�����WEB��ʽ���ơ�
objPrjObjectsEN = new clsPrjObjectsEN();
objPrjObjectsEN.ObjId = "0";
objPrjObjectsEN.ObjName = "��ѡ��...";
PrjObjectsList.Add(objPrjObjectsEN);
//��DataTable�е���������ӵ������б���
foreach(DataRow objRow in objDT.Rows)
{
objPrjObjectsEN = new clsPrjObjectsEN();
objPrjObjectsEN.ObjId = objRow["ObjId"].ToString();
objPrjObjectsEN.ObjName = objRow["ObjName"].ToString();
PrjObjectsList.Add(objPrjObjectsEN);
}
//���������������Դ���Լ�����ֵ���ʾ��
objComboBox.DataSource = PrjObjectsList;
objComboBox.ValueMember="ObjId";
objComboBox.DisplayMember="ObjName";
objComboBox.SelectedIndex = 0;
}
public System.Data.DataTable GetSQLDSTypeId()
{
//��ȡĳѧԺ����רҵ��Ϣ
string strSQL = "select SQLDSTypeId, SqlDsTypeName from SQLDSType ";
clsSpecSQLforSql mySql=new clsSpecSQLforSql();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}
public void BindCbo_SQLDSTypeId(System.Windows.Forms.ComboBox objComboBox)
{
//Ϊ����ԴΪ�����������������
System.Data.DataTable objDT = GetSQLDSTypeId();
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
public System.Data.DataTable GetTabStateId()
{
//��ȡĳѧԺ����רҵ��Ϣ
string strSQL = "select TabStateId, TabStateName from TabState ";
clsSpecSQLforSql mySql=new clsSpecSQLforSql();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}
public void BindCbo_TabStateId(System.Windows.Forms.ComboBox objComboBox)
{
//Ϊ����ԴΪ�����������������
System.Data.DataTable objDT = GetTabStateId();
clsTabStateEN objTabStateEN;
//��ʼ��һ�������б�
ArrayList TabStateList = new ArrayList();
//�����0��ڵ�0���в���"��ѡ��..."��Ϊ�˷����û�����WEB��ʽ���ơ�
objTabStateEN = new clsTabStateEN();
objTabStateEN.TabStateId = "0";
objTabStateEN.TabStateName = "��ѡ��...";
TabStateList.Add(objTabStateEN);
//��DataTable�е���������ӵ������б���
foreach(DataRow objRow in objDT.Rows)
{
objTabStateEN = new clsTabStateEN();
objTabStateEN.TabStateId = objRow["TabStateId"].ToString();
objTabStateEN.TabStateName = objRow["TabStateName"].ToString();
TabStateList.Add(objTabStateEN);
}
//���������������Դ���Լ�����ֵ���ʾ��
objComboBox.DataSource = TabStateList;
objComboBox.ValueMember="TabStateId";
objComboBox.DisplayMember="TabStateName";
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
public void SetCbo_PrjId()
{
clsProjectsBL.BindCbo_PrjId(cboPrjId);
}
public void SetCbo_ObjId()
{
clsPrjObjectsBL.BindCbo_ObjId(cboObjId);
}
public void SetCbo_SQLDSTypeId()
{
clsSQLDSTypeBL.BindCbo_SQLDSTypeId(cboSQLDSTypeId);
}
public void SetCbo_TabStateId()
{
clsTabStateBL.BindCbo_TabStateId(cboTabStateId);
}
public void SetCbo_FuncModuleId()
{
clsFuncModuleBL.BindCbo_FuncModuleId(cboFuncModuleId);
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
/// <param name="strTabId">���¼�Ĺؼ��֣���ʾ�ñ�ؼ��ֵ�����</param>
private void ShowData(string strTabId)
{
//�������裺
//1�����ؼ����Ƿ�Ϊ�գ�
//2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
//3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
//4����ȡ�������������ԣ�
//5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���

//1�����ؼ����Ƿ�Ϊ�գ�
if (strTabId == "") return ;		//����ؼ���Ϊ�վͷ����˳�
//2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
if (clsPrjTabBL.IsExist(strTabId) == false)		//���ùؼ��ֵļ�¼�Ƿ����
{
string ss = "�ؼ���Ϊ��" + strTabId + "�Ĳ�����!";
MessageBox.Show(ss);
return ;
}
//3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
objPrjTabEN = new clsPrjTabEN(strTabId);
//4����ȡ�������������ԣ�
clsPrjTabBL.GetPrjTab(ref objPrjTabEN);
//5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���
GetDataFromPrjTabClass(objPrjTabEN);
}
///���ɴ��߼�������ݴ��䵽�����ĺ�������
private void GetDataFromPrjTabClass(clsPrjTabEN pobjPrjTabEN)
{
///ע�⣺��������������򣬲�����һ��������������ϵ�ģ�����Ϊһ��������ֵ��Ȼ����Ϊ����������ֵ
///      ������������ݿ�ʱ����Ӧ��һ���ֶ���ǰ�������ֶ��ں�
this.TabId = pobjPrjTabEN.TabId;
this.TabName = pobjPrjTabEN.TabName;
this.TabCnName = pobjPrjTabEN.TabCnName;
this.PrjId = pobjPrjTabEN.PrjId;
this.ObjId = pobjPrjTabEN.ObjId;
this.IsNeedTransCode = pobjPrjTabEN.IsNeedTransCode;
this.SQLDSTypeId = pobjPrjTabEN.SQLDSTypeId;
this.TabStateId = pobjPrjTabEN.TabStateId;
this.TabName_B = pobjPrjTabEN.TabName_B;
this.IsParaTab = pobjPrjTabEN.IsParaTab;
this.IsNationStandard = pobjPrjTabEN.IsNationStandard;
this.IsArchive = pobjPrjTabEN.IsArchive;
this.IsChecked = pobjPrjTabEN.IsChecked;
this.ErrMsg = pobjPrjTabEN.ErrMsg;
this.FuncModuleId = pobjPrjTabEN.FuncModuleId;
this.DataBaseName = pobjPrjTabEN.DataBaseName;
this.Owner = pobjPrjTabEN.Owner;
this.Memo = pobjPrjTabEN.Memo;
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
AddPrjTabRecord();
break;				
case "ȷ�����":
//����һ������Ĳ���Ĵ��룬�����߼���̫�򵥣�
//�Ͱ��߼���ϲ������Ʋ�,
AddPrjTabRecordSave();
break;
case "ȷ���޸�":
//����һ��������޸ĵĴ��룬�����߼���̫�򵥣�
//�Ͱ��߼���ϲ������Ʋ�,
UpdatePrjTabRecordSave(objPrjTabEN);
break;
}
}
private void PutDataToPrjTabClass(clsPrjTabEN pobjPrjTabEN)
{
pobjPrjTabEN.TabId = this.TabId;
pobjPrjTabEN.TabName = this.TabName;
pobjPrjTabEN.TabCnName = this.TabCnName;
pobjPrjTabEN.PrjId = this.PrjId;
pobjPrjTabEN.ObjId = this.ObjId;
pobjPrjTabEN.IsNeedTransCode = this.IsNeedTransCode;
pobjPrjTabEN.SQLDSTypeId = this.SQLDSTypeId;
pobjPrjTabEN.TabStateId = this.TabStateId;
pobjPrjTabEN.TabName_B = this.TabName_B;
pobjPrjTabEN.IsParaTab = this.IsParaTab;
pobjPrjTabEN.IsNationStandard = this.IsNationStandard;
pobjPrjTabEN.IsArchive = this.IsArchive;
pobjPrjTabEN.IsChecked = this.IsChecked;
pobjPrjTabEN.ErrMsg = this.ErrMsg;
pobjPrjTabEN.FuncModuleId = this.FuncModuleId;
pobjPrjTabEN.DataBaseName = this.DataBaseName;
pobjPrjTabEN.Owner = this.Owner;
pobjPrjTabEN.Memo = this.Memo;
}
private void btnClose_Click(object sender, System.EventArgs e)
{
this.Close();
}
public string TabId_key
{
get
{
return mstrTabId;
}
set
{
mstrTabId = value;
}
}
///���ɵĲ����¼׼�����̴���for C#
protected void AddPrjTabRecord()
{
this.SetKeyReadOnly(false);
btnOKUpd.Text = "ȷ�����";
//this.TabId = clsCommForWin.GetMaxStrId("PrjTab","TabId", 8, "");
//DispEditPrjTabRegion();
}
///�����¼���̹��̴���for C#
private void AddPrjTabRecordSave()
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
clsPrjTabEN objPrjTab;
//1�����ؼ����������������Ƿ���ȷ
if (!this.IsValid(ref strResult))
{
lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
return ;
}
//2����ʼ����������
objPrjTabEN = new clsPrjTabEN(this.TabId);	//��ʼ���¶���
//3���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
if (clsPrjTabBL.IsExist(TabId))	//�ж��Ƿ�����ͬ�Ĺؼ���
{
strMsg = "�ؼ����ֶ�������ͬ��ֵ";
MessageBox.Show(strMsg);
return;
}
//4����ֵ�ӽ���㴫���߼��������ʵ���
PutDataToPrjTabClass(objPrjTabEN);		//�ѽ����ֵ����
//5����鴫��ȥ�Ķ��������Ƿ�Ϸ�
try
{
clsPrjTabBL.CheckPropertyNew(objPrjTabEN);
//6��������ʵ�������ݴ��������ݿ���
clsPrjTabBL.AddNewRecordBySql2(objPrjTabEN);
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
private void UpdatePrjTabRecordSave(clsPrjTabEN objPrjTabEN)
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
PutDataToPrjTabClass(objPrjTabEN);		//�ѽ����ֵ����
//3����鴫��ȥ�Ķ��������Ƿ�Ϸ�
try
{
clsPrjTabBL.CheckPropertyNew(objPrjTabEN);
//6��������ʵ�������ݴ��������ݿ���
clsPrjTabBL.UpdateBySql2(objPrjTabEN);
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