
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
using com.taishsoft.util;
using CommFunc4Win;
using com.taishsoft.commdb;
using AGC_CSV7.Entity;
using AGC_CSV7.BusinessLogic;

namespace AGC_CSV7
{
/// <summary>
///		frmPrjTab_QD_LV ��ժҪ˵����
/// </summary>
public partial class frmPrjTab_QD_LV : System.Windows.Forms.Form, IBindListView
{
clsPrjTabEN objPrjTabEN = null;
private System.Data.DataTable objDTPrjTab = null;
private clsListViewSorter objvPrjTabSorter;
private int intLastSelectedvPrjTabColumIndex ;
public frmPrjTab_QD_LV()
{
// �õ����� Windows.Forms ���������������ġ�
InitializeComponent();

// TODO: �� InitializeComponent ���ú�����κγ�ʼ��
objvPrjTabSorter = new clsListViewSorter();
//ΪListViewItemSorterָ��������
this.lvvPrjTab.ListViewItemSorter = objvPrjTabSorter;
objvPrjTabSorter.SortOrder=SortOrder.Ascending;

}
private void frmPrjTab_QD_Load(object sender, System.EventArgs e)
{
// �ڴ˴������û������Գ�ʼ��ҳ��
//1��Ϊ��������������Դ�����б�����
this.SetAllComboBox();
BindLv_vPrjTab();
this.JudgebtnDelRec(); //�����ж�ɾ����ť�Ƿ����
this.JudgebtnUpdate(); //�����ж��޸İ�ť�Ƿ����

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


public void Clear()
{
txtTabName.Text = "";
cboPrjId.SelectedIndex = 0;
cboObjId.SelectedIndex = 0;
cboSQLDSTypeId.SelectedIndex = 0;
cboTabStateId.SelectedIndex = 0;
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
txtTabName.Text = "";
cboPrjId.SelectedIndex = 0;
cboObjId.SelectedIndex = 0;
cboSQLDSTypeId.SelectedIndex = 0;
cboTabStateId.SelectedIndex = 0;
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
public string CombinePrjTabCondion()
{
//ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
//���� 1=1 && UserName = '����'
string strWhereCond=" 1=1 ";
//����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
if (this.txtTabName.Text.Trim()!="")
{
strWhereCond += " And PrjTab.TabName like '%" + this.txtTabName.Text.Trim()+"%'";
}
if (this.cboPrjId.SelectedValue.ToString()!="" && this.cboPrjId.SelectedValue.ToString()!="0")
{
strWhereCond += " And PrjTab.PrjId='" + this.cboPrjId.SelectedValue+"'";
}
if (this.cboObjId.SelectedValue.ToString()!="" && this.cboObjId.SelectedValue.ToString()!="0")
{
strWhereCond += " And PrjTab.ObjId='" + this.cboObjId.SelectedValue+"'";
}
if (this.cboSQLDSTypeId.SelectedValue.ToString()!="" && this.cboSQLDSTypeId.SelectedValue.ToString()!="0")
{
strWhereCond += " And PrjTab.SQLDSTypeId='" + this.cboSQLDSTypeId.SelectedValue+"'";
}
if (this.cboTabStateId.SelectedValue.ToString()!="" && this.cboTabStateId.SelectedValue.ToString()!="0")
{
strWhereCond += " And PrjTab.TabStateId='" + this.cboTabStateId.SelectedValue+"'";
}
return strWhereCond;
}
/// <summary>
/// �����еĲ�ѯ�ؼ�������ϳ�һ��������
/// </summary>
/// <returns>������(strWhereCond)</returns>
public string CombinePrjTabCondion(bool bolIsWithTabName)
{
//ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
//���� 1=1 && UserName = '����'
string strWhereCond=" 1=1 ";
//����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
if (bolIsWithTabName == true)
{
if (this.txtTabName.Text.Trim()!="")
{
strWhereCond += " And PrjTab.TabName like '%" + this.txtTabName.Text.Trim()+"%'";
}
if (this.cboPrjId.SelectedValue.ToString()!="" && this.cboPrjId.SelectedValue.ToString()!="0")
{
strWhereCond += " And PrjTab.PrjId='" + this.cboPrjId.SelectedValue+"'";
}
if (this.cboObjId.SelectedValue.ToString()!="" && this.cboObjId.SelectedValue.ToString()!="0")
{
strWhereCond += " And PrjTab.ObjId='" + this.cboObjId.SelectedValue+"'";
}
if (this.cboSQLDSTypeId.SelectedValue.ToString()!="" && this.cboSQLDSTypeId.SelectedValue.ToString()!="0")
{
strWhereCond += " And PrjTab.SQLDSTypeId='" + this.cboSQLDSTypeId.SelectedValue+"'";
}
if (this.cboTabStateId.SelectedValue.ToString()!="" && this.cboTabStateId.SelectedValue.ToString()!="0")
{
strWhereCond += " And PrjTab.TabStateId='" + this.cboTabStateId.SelectedValue+"'";
}
}
else
{
if (this.txtTabName.Text.Trim()!="")
{
strWhereCond += " And TabName like '%" + this.txtTabName.Text.Trim()+"%'";
}
if (this.cboPrjId.SelectedValue.ToString()!="" && this.cboPrjId.SelectedValue.ToString()!="0")
{
strWhereCond += " And PrjId='" + this.cboPrjId.SelectedValue+"'";
}
if (this.cboObjId.SelectedValue.ToString()!="" && this.cboObjId.SelectedValue.ToString()!="0")
{
strWhereCond += " And ObjId='" + this.cboObjId.SelectedValue+"'";
}
if (this.cboSQLDSTypeId.SelectedValue.ToString()!="" && this.cboSQLDSTypeId.SelectedValue.ToString()!="0")
{
strWhereCond += " And SQLDSTypeId='" + this.cboSQLDSTypeId.SelectedValue+"'";
}
if (this.cboTabStateId.SelectedValue.ToString()!="" && this.cboTabStateId.SelectedValue.ToString()!="0")
{
strWhereCond += " And TabStateId='" + this.cboTabStateId.SelectedValue+"'";
}
}
return strWhereCond;
}
/// <summary>
/// �����еĲ�ѯ�ؼ�������ϳ�һ��������
/// </summary>
/// <returns>������(strWhereCond)</returns>
public string CombinePrjTabCondion(string strTabName)
{
//ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
//���� 1=1 && UserName = '����'
string strWhereCond=" 1=1 ";
//����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
if (this.txtTabName.Text.Trim()!="")
{
strWhereCond += " And " + strTabName +".TabName like '%" + this.txtTabName.Text.Trim()+"%'";
}
if (this.cboPrjId.SelectedValue.ToString()!="" && this.cboPrjId.SelectedValue.ToString()!="0")
{
strWhereCond += " And " + strTabName + ".PrjId='" + this.cboPrjId.SelectedValue+"'";
}
if (this.cboObjId.SelectedValue.ToString()!="" && this.cboObjId.SelectedValue.ToString()!="0")
{
strWhereCond += " And " + strTabName + ".ObjId='" + this.cboObjId.SelectedValue+"'";
}
if (this.cboSQLDSTypeId.SelectedValue.ToString()!="" && this.cboSQLDSTypeId.SelectedValue.ToString()!="0")
{
strWhereCond += " And " + strTabName + ".SQLDSTypeId='" + this.cboSQLDSTypeId.SelectedValue+"'";
}
if (this.cboTabStateId.SelectedValue.ToString()!="" && this.cboTabStateId.SelectedValue.ToString()!="0")
{
strWhereCond += " And " + strTabName + ".TabStateId='" + this.cboTabStateId.SelectedValue+"'";
}
return strWhereCond;
}
/// <summary>
/// �������ܣ������ж�ɾ����ť�Ƿ���á�
///			 �����LISTVIEW��ѡ�м�¼����ʾɾ����ť������Ͳ���ʾ
/// </summary>
private void JudgebtnDelRec()
{
if (this.lvvPrjTab.SelectedItems.Count >= 1)
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
if (this.lvvPrjTab.SelectedItems.Count >= 1)
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
private void BindLv_vPrjTab()
{
//�������裺(��4��)
//	1����Ͻ�����������
//	2��������������ȡ�ñ�����������DataTable��
//	3������ListView����ͷ��Ϣ
//	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��
//		�ڱ��������ǰ�״̬��ʾ�ڿؼ�lblRecCount�С�

ListViewItem lvivPrjTab; 
List<clsvPrjTabEN> arrvPrjTabObjList;
//	1����Ͻ�����������
string strWhereCond = this.CombinePrjTabCondion(false);	//  CombinePrjTabCondion();
//	2��������������ȡ�ñ�����������DataTable��
arrvPrjTabObjList = clsvPrjTabBL.GetvPrjTabObjList(strWhereCond);
//	3������ListView����ͷ��Ϣ
this.lvvPrjTab.Items.Clear();//���ԭ������Item
this.lvvPrjTab.Columns.Clear();//���ԭ��������ͷ��Ϣ
this.lvvPrjTab.Columns.Add("��ID", 100, HorizontalAlignment.Left);
this.lvvPrjTab.Columns.Add("����", 100, HorizontalAlignment.Left);
this.lvvPrjTab.Columns.Add("��������", 100, HorizontalAlignment.Left);
this.lvvPrjTab.Columns.Add("����ģ������", 100, HorizontalAlignment.Left);
this.lvvPrjTab.Columns.Add("��������", 100, HorizontalAlignment.Left);
this.lvvPrjTab.Columns.Add("��״̬����", 100, HorizontalAlignment.Left);
this.lvvPrjTab.Columns.Add("FldNum", 100, HorizontalAlignment.Left);
this.lvvPrjTab.Columns.Add("KeyFldName", 100, HorizontalAlignment.Left);
this.lvvPrjTab.Columns.Add("PrimaryTypeName", 100, HorizontalAlignment.Left);
this.lvvPrjTab.Columns.Add("Sql����Դ��", 100, HorizontalAlignment.Left);
this.lvvPrjTab.Columns.Add("������Ϣ", 100, HorizontalAlignment.Left);
this.lvvPrjTab.Columns.Add("�޸�����", 100, HorizontalAlignment.Left);
this.lvvPrjTab.View = View.Details;
//	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��
foreach (clsvPrjTabEN objvPrjTabEN in arrvPrjTabObjList)
{
lvivPrjTab = new ListViewItem();
lvivPrjTab.Tag = objvPrjTabEN.TabId;
lvivPrjTab.Text = objvPrjTabEN.TabId;
lvivPrjTab.SubItems.Add(objvPrjTabEN.TabName);
lvivPrjTab.SubItems.Add(objvPrjTabEN.TabCnName);
lvivPrjTab.SubItems.Add(objvPrjTabEN.FuncModuleName);
lvivPrjTab.SubItems.Add(objvPrjTabEN.ObjName);
lvivPrjTab.SubItems.Add(objvPrjTabEN.TabStateName);
lvivPrjTab.SubItems.Add(objvPrjTabEN.FldNum.ToString());
lvivPrjTab.SubItems.Add(objvPrjTabEN.KeyFldName);
lvivPrjTab.SubItems.Add(objvPrjTabEN.PrimaryTypeName);
lvivPrjTab.SubItems.Add(objvPrjTabEN.SqlDsTypeName);
lvivPrjTab.SubItems.Add(objvPrjTabEN.ErrMsg);
lvivPrjTab.SubItems.Add(objvPrjTabEN.UpdDate);
this.lvvPrjTab.Items.Add(lvivPrjTab);
}
//	4�����ü�¼����״̬��
//		�ڱ��������ǰ�״̬��ʾ�ڿؼ�txtRecCount�С�
this.lblRecNum.Text = "��¼����" + arrvPrjTabObjList.Count.ToString();
}
private void btnQuery_Click(object sender, System.EventArgs e)
{
//�ѱ��¼��������ʾ��ListView��
BindLv_vPrjTab();
}
/// <summary>
/// ��ȡDataGrid�е�ǰ�е�����ֵ
/// </summary>
/// <param name="objDataGrid">��������DataGrid</param>
/// <returns>��ǰ�е�����ֵ</returns>
private string GetCurrKey(DataGrid objDataGrid)
{
int intCurrRow = objDataGrid.CurrentRowIndex;
string strTabId = objDTPrjTab.Rows[intCurrRow]["TabId"].ToString();
return strTabId;
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
ListViewItem lviPrjTab;
lviPrjTab = objListView.SelectedItems[0];
string strPrjTabId = lviPrjTab.Tag.ToString();
return strPrjTabId;
}
/// <summary>
/// ��ȡListView�����������ֵ
/// </summary>
/// <param name="objListView">��������ListView��</param>
/// <returns>��ǰ�е�����ֵ</returns>
private string GetCurrKey(ListViewItem objListViewItem)
{
string strPrjTabId = objListViewItem.Tag.ToString();
return strPrjTabId;
}
private void lvvPrjTab_Click(object sender, System.EventArgs e)
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
UpdatePrjTabRecord();
}
/// <summary>
/// �������ܣ��¼�������������<ȷ���޸�>ʱ�������¼�������
///           ���幦��Ϊ�ѽ�������ͬ�����ݿ��У��ѽ������ݱ��浽���ݿ���
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
private void btnAdd_Click(object sender, System.EventArgs e)
{
frmPrjTab_UI frm = new frmPrjTab_UI();
frm.iBindListView = this;
frm.OperateType = "Add";
frm.ShowDialog();
}
private void btnDelRec_Click(object sender, System.EventArgs e)
{
DeletePrjTabRecord();
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
string strWhereCond = this.CombinePrjTabCondion(true);
//	2��������������ȡ�ñ�����������DataTable��
System.Data.DataTable objDT = clsPrjTabBL.GetDataTable_PrjTab(strWhereCond);
ArrayList arrCnName = new ArrayList();
ArrayList arrColName = new ArrayList();
//string strFileName = "PrjTab��Ϣ����.xls";
//string strFolderName;
string strDownLoadFileName;
arrColName.Add("TabId"); arrCnName.Add("��ID");
arrColName.Add("TabName"); arrCnName.Add("����");
arrColName.Add("TabCnName"); arrCnName.Add("��������");
arrColName.Add("FuncModuleId"); arrCnName.Add("����ģ��Id");
arrColName.Add("FuncModuleName"); arrCnName.Add("����ģ������");
arrColName.Add("ObjId"); arrCnName.Add("��������");
arrColName.Add("ObjName"); arrCnName.Add("��������");
arrColName.Add("TabStateId"); arrCnName.Add("��״̬ID");
arrColName.Add("TabStateName"); arrCnName.Add("��״̬����");
arrColName.Add("FldNum"); arrCnName.Add("FldNum");
arrColName.Add("KeyFldName"); arrCnName.Add("KeyFldName");
arrColName.Add("PrimaryTypeId"); arrCnName.Add("��������ID");
arrColName.Add("PrimaryTypeName"); arrCnName.Add("PrimaryTypeName");
arrColName.Add("SQLDSTypeId"); arrCnName.Add("����Դ����");
arrColName.Add("SqlDsTypeName"); arrCnName.Add("Sql����Դ��");
arrColName.Add("ErrMsg"); arrCnName.Add("������Ϣ");
arrColName.Add("IsTabPrimary"); arrCnName.Add("�Ƿ���Ϊ��������");
arrColName.Add("Owner"); arrCnName.Add("ӵ����");
arrColName.Add("RelaViewId"); arrCnName.Add("�����ͼID");
arrColName.Add("UpdDate"); arrCnName.Add("�޸�����");
arrColName.Add("UpdUserId"); arrCnName.Add("�޸��û�Id");
arrColName.Add("IsArchive"); arrCnName.Add("�Ƿ�浵");
arrColName.Add("IsChecked"); arrCnName.Add("�Ƿ��ʵ");
arrColName.Add("TabName_B"); arrCnName.Add("����_��");
arrColName.Add("IsNationStandard"); arrCnName.Add("�Ƿ����");
arrColName.Add("IsParaTab"); arrCnName.Add("�Ƿ������");
arrColName.Add("IsNeedTransCode"); arrCnName.Add("�Ƿ���Ҫת������");
arrColName.Add("FldID"); arrCnName.Add("�ֶ�ID");
arrColName.Add("FuncModuleEnName"); arrCnName.Add("����ģ��Ӣ������");
arrColName.Add("DataBaseName"); arrCnName.Add("���ݿ���");
arrColName.Add("DatabaseOwner"); arrCnName.Add("���ݿ�ӵ����");
arrColName.Add("DataBaseUserId"); arrCnName.Add("���ݿ���û�ID");
arrColName.Add("PrjId"); arrCnName.Add("����ID");
arrColName.Add("PrjName"); arrCnName.Add("��������");
arrColName.Add("Memo"); arrCnName.Add("˵��");
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
string strWhereCond = this.CombinePrjTabCondion(true);
//	2�����ñ��������ֶ������Լ����б���
ArrayList arrCnName = new ArrayList();
ArrayList arrColName = new ArrayList();
arrColName.Add("TabId"); arrCnName.Add("��ID");
arrColName.Add("TabName"); arrCnName.Add("����");
arrColName.Add("TabCnName"); arrCnName.Add("��������");
arrColName.Add("FuncModuleId"); arrCnName.Add("����ģ��Id");
arrColName.Add("FuncModuleName"); arrCnName.Add("����ģ������");
arrColName.Add("ObjId"); arrCnName.Add("��������");
arrColName.Add("ObjName"); arrCnName.Add("��������");
arrColName.Add("TabStateId"); arrCnName.Add("��״̬ID");
arrColName.Add("TabStateName"); arrCnName.Add("��״̬����");
arrColName.Add("FldNum"); arrCnName.Add("FldNum");
arrColName.Add("KeyFldName"); arrCnName.Add("KeyFldName");
arrColName.Add("PrimaryTypeId"); arrCnName.Add("��������ID");
arrColName.Add("PrimaryTypeName"); arrCnName.Add("PrimaryTypeName");
arrColName.Add("SQLDSTypeId"); arrCnName.Add("����Դ����");
arrColName.Add("SqlDsTypeName"); arrCnName.Add("Sql����Դ��");
arrColName.Add("ErrMsg"); arrCnName.Add("������Ϣ");
arrColName.Add("IsTabPrimary"); arrCnName.Add("�Ƿ���Ϊ��������");
arrColName.Add("Owner"); arrCnName.Add("ӵ����");
arrColName.Add("RelaViewId"); arrCnName.Add("�����ͼID");
arrColName.Add("UpdDate"); arrCnName.Add("�޸�����");
arrColName.Add("UpdUserId"); arrCnName.Add("�޸��û�Id");
arrColName.Add("IsArchive"); arrCnName.Add("�Ƿ�浵");
arrColName.Add("IsChecked"); arrCnName.Add("�Ƿ��ʵ");
arrColName.Add("TabName_B"); arrCnName.Add("����_��");
arrColName.Add("IsNationStandard"); arrCnName.Add("�Ƿ����");
arrColName.Add("IsParaTab"); arrCnName.Add("�Ƿ������");
arrColName.Add("IsNeedTransCode"); arrCnName.Add("�Ƿ���Ҫת������");
arrColName.Add("FldID"); arrCnName.Add("�ֶ�ID");
arrColName.Add("FuncModuleEnName"); arrCnName.Add("����ģ��Ӣ������");
arrColName.Add("DataBaseName"); arrCnName.Add("���ݿ���");
arrColName.Add("DatabaseOwner"); arrCnName.Add("���ݿ�ӵ����");
arrColName.Add("DataBaseUserId"); arrCnName.Add("���ݿ���û�ID");
arrColName.Add("PrjId"); arrCnName.Add("����ID");
arrColName.Add("PrjName"); arrCnName.Add("��������");
arrColName.Add("Memo"); arrCnName.Add("˵��");
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
frm1.strTableName = "vPrjTab";
frm1.strTableChineseName = "vPrjTab";
frm1.strViewName = "���̱�ά��";
frm1.strWhereCondition = strWhereCond;
frm1.Show();
}

/// <summary>
/// �������ܣ�LISTVIEW���е����¼�����
/// </summary>
private void lvvPrjTab_ColumnClick(object sender, System.Windows.Forms.ColumnClickEventArgs e)
{
if (e.Column == this.objvPrjTabSorter.SortColumn)
{

}
else
{
this.objvPrjTabSorter.SortColumn=e.Column;
}

if (this.objvPrjTabSorter.SortOrder==SortOrder.Ascending)
{
this.objvPrjTabSorter.SortOrder=SortOrder.Descending;
if(intLastSelectedvPrjTabColumIndex == e.Column) //���Ƿ��ظ����һ��
{
this.lvvPrjTab.Columns[e.Column].Text = this.lvvPrjTab.Columns[e.Column].Text.Trim('��','��') + "��";
intLastSelectedvPrjTabColumIndex = e.Column;
}
else //����������һ���ˣ���ôǰ������һ������ȥ��
{
this.lvvPrjTab.Columns[e.Column].Text = this.lvvPrjTab.Columns[e.Column].Text.Trim('��','��') + "��";
this.lvvPrjTab.Columns[intLastSelectedvPrjTabColumIndex].Text = this.lvvPrjTab.Columns[intLastSelectedvPrjTabColumIndex].Text.Trim('��','��');
intLastSelectedvPrjTabColumIndex = e.Column;
}
}
else if (this.objvPrjTabSorter.SortOrder==SortOrder.Descending) // �� ��
{
this.objvPrjTabSorter.SortOrder=SortOrder.Ascending;
if(intLastSelectedvPrjTabColumIndex == e.Column)
{
this.lvvPrjTab.Columns[e.Column].Text = this.lvvPrjTab.Columns[e.Column].Text.Trim('��','��') + "��";
intLastSelectedvPrjTabColumIndex = e.Column;
}
else
{
this.lvvPrjTab.Columns[e.Column].Text = this.lvvPrjTab.Columns[e.Column].Text.Trim('��','��') + "��";
this.lvvPrjTab.Columns[intLastSelectedvPrjTabColumIndex].Text = this.lvvPrjTab.Columns[intLastSelectedvPrjTabColumIndex].Text.Trim('��','��');
intLastSelectedvPrjTabColumIndex = e.Column;
}
}
else
{
return ;
}
this.lvvPrjTab.Sort();
}

/// <summary>
/// ʵ�ֽӿں�����ͨ���Ӵ�����ã���ʵ�ֱ�����(������)��LISTVIEW���°󶨹���
/// </summary>
void IBindListView.BindListView()
{
BindLv_vPrjTab();
}
///�����޸ļ�¼׼�����̴��� for C#
private void UpdatePrjTabRecord()
{
if(this.lvvPrjTab.SelectedItems.Count!=1)
{
DialogResult result;
result = MessageBox.Show("��ѡ��һ����¼��");
return;
}
frmPrjTab_UI frm = new frmPrjTab_UI();
string strKeyId = this.lvvPrjTab.SelectedItems[0].Tag.ToString();
frm.TabId_key = strKeyId;
frm.iBindListView = this;
frm.OperateType = "Update";
frm.ShowDialog();
}
 ///ɾ����¼���̴���for C#
private void DeletePrjTabRecord()
{
DialogResult result;
result = MessageBox.Show("�����Ҫɾ���ü�¼��", "ȷ��ɾ��", MessageBoxButtons.YesNo);
if (result == DialogResult.Yes)
{
foreach(ListViewItem lvi in this.lvvPrjTab.SelectedItems)
{
string strTabId = GetCurrKey(lvi);
if(clsPrjTabBL.DelRecord(strTabId)== false)
{
MessageBox.Show("ɾ����¼ʧ�ܣ�");
BindLv_vPrjTab();
return ;
}
}
MessageBox.Show("ɾ����¼�ɹ���");
BindLv_vPrjTab();
}
}
}
}