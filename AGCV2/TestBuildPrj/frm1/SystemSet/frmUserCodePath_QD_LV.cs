
///----------------------
///���ɴ���汾��2012.01.02.1
///�������ڣ�2012/10/17
///�����ߣ����Է�
///�������ƣ�AGC_CSV7
///����ID��0005
///ģ����������ϵͳ����
///ģ��Ӣ������SystemSet
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
///		frmUserCodePath_QD_LV ��ժҪ˵����
/// </summary>
public partial class frmUserCodePath_QD_LV : System.Windows.Forms.Form, IBindListView
{
clsUserCodePathEN objUserCodePathEN = null;
private System.Data.DataTable objDTUserCodePath = null;
private clsListViewSorter objvUserCodePathSorter;
private int intLastSelectedvUserCodePathColumIndex ;
public frmUserCodePath_QD_LV()
{
// �õ����� Windows.Forms ���������������ġ�
InitializeComponent();

// TODO: �� InitializeComponent ���ú�����κγ�ʼ��
objvUserCodePathSorter = new clsListViewSorter();
//ΪListViewItemSorterָ��������
this.lvvUserCodePath.ListViewItemSorter = objvUserCodePathSorter;
objvUserCodePathSorter.SortOrder=SortOrder.Ascending;

}
private void frmUserCodePath_QD_Load(object sender, System.EventArgs e)
{
// �ڴ˴������û������Գ�ʼ��ҳ��
//1��Ϊ��������������Դ�����б�����
this.SetAllComboBox();
BindLv_vUserCodePath();
this.JudgebtnDelRec(); //�����ж�ɾ����ť�Ƿ����
this.JudgebtnUpdate(); //�����ж��޸İ�ť�Ƿ����

}
/// <summary>
/// ������İ󶨺���
/// </summary>
private void SetAllComboBox()
{
this.BindCbo_UserId(this.cboUserId);
this.BindCbo_PrjId(this.cboPrjId);
this.BindCbo_CodeTypeId(this.cboCodeTypeId);
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

public string CodeTypeId
{
get
{
if (cboCodeTypeId.SelectedValue.ToString() == "0")
return "";
return cboCodeTypeId.SelectedValue.ToString();
}
set
{
if (value == "")
{
cboCodeTypeId.SelectedValue = "0";
}
else
{
cboCodeTypeId.SelectedValue = value;
}
}
}


public void Clear()
{
cboUserId.SelectedIndex = 0;
cboPrjId.SelectedIndex = 0;
cboCodeTypeId.SelectedIndex = 0;
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
cboUserId.SelectedIndex = 0;
cboPrjId.SelectedIndex = 0;
cboCodeTypeId.SelectedIndex = 0;
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
public System.Data.DataTable GetCodeTypeId()
{
//��ȡĳѧԺ����רҵ��Ϣ
string strSQL = "select CodeTypeId, CodeTypeName from CodeType ";
clsSpecSQLforSql mySql=new clsSpecSQLforSql();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}
public void BindCbo_CodeTypeId(System.Windows.Forms.ComboBox objComboBox)
{
//Ϊ����ԴΪ�����������������
System.Data.DataTable objDT = GetCodeTypeId();
clsCodeTypeEN objCodeTypeEN;
//��ʼ��һ�������б�
ArrayList CodeTypeList = new ArrayList();
//�����0��ڵ�0���в���"��ѡ��..."��Ϊ�˷����û�����WEB��ʽ���ơ�
objCodeTypeEN = new clsCodeTypeEN();
objCodeTypeEN.CodeTypeId = "0";
objCodeTypeEN.CodeTypeName = "��ѡ��...";
CodeTypeList.Add(objCodeTypeEN);
//��DataTable�е���������ӵ������б���
foreach(DataRow objRow in objDT.Rows)
{
objCodeTypeEN = new clsCodeTypeEN();
objCodeTypeEN.CodeTypeId = objRow["CodeTypeId"].ToString();
objCodeTypeEN.CodeTypeName = objRow["CodeTypeName"].ToString();
CodeTypeList.Add(objCodeTypeEN);
}
//���������������Դ���Լ�����ֵ���ʾ��
objComboBox.DataSource = CodeTypeList;
objComboBox.ValueMember="CodeTypeId";
objComboBox.DisplayMember="CodeTypeName";
objComboBox.SelectedIndex = 0;
}
public void SetCbo_UserId()
{
clsUsersBL.BindCbo_UserId(cboUserId);
}
public void SetCbo_PrjId()
{
clsProjectsBL.BindCbo_PrjId(cboPrjId);
}
public void SetCbo_CodeTypeId()
{
clsCodeTypeBL.BindCbo_CodeTypeId(cboCodeTypeId);
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
public string CombineUserCodePathCondion()
{
//ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
//���� 1=1 && UserName = '����'
string strWhereCond=" 1=1 ";
//����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
if (this.cboUserId.SelectedValue.ToString()!="" && this.cboUserId.SelectedValue.ToString()!="0")
{
strWhereCond += " And UserCodePath.UserId='" + this.cboUserId.SelectedValue+"'";
}
if (this.cboPrjId.SelectedValue.ToString()!="" && this.cboPrjId.SelectedValue.ToString()!="0")
{
strWhereCond += " And UserCodePath.PrjId='" + this.cboPrjId.SelectedValue+"'";
}
if (this.cboCodeTypeId.SelectedValue.ToString()!="" && this.cboCodeTypeId.SelectedValue.ToString()!="0")
{
strWhereCond += " And UserCodePath.CodeTypeId='" + this.cboCodeTypeId.SelectedValue+"'";
}
return strWhereCond;
}
/// <summary>
/// �����еĲ�ѯ�ؼ�������ϳ�һ��������
/// </summary>
/// <returns>������(strWhereCond)</returns>
public string CombineUserCodePathCondion(bool bolIsWithTabName)
{
//ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
//���� 1=1 && UserName = '����'
string strWhereCond=" 1=1 ";
//����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
if (bolIsWithTabName == true)
{
if (this.cboUserId.SelectedValue.ToString()!="" && this.cboUserId.SelectedValue.ToString()!="0")
{
strWhereCond += " And UserCodePath.UserId='" + this.cboUserId.SelectedValue+"'";
}
if (this.cboPrjId.SelectedValue.ToString()!="" && this.cboPrjId.SelectedValue.ToString()!="0")
{
strWhereCond += " And UserCodePath.PrjId='" + this.cboPrjId.SelectedValue+"'";
}
if (this.cboCodeTypeId.SelectedValue.ToString()!="" && this.cboCodeTypeId.SelectedValue.ToString()!="0")
{
strWhereCond += " And UserCodePath.CodeTypeId='" + this.cboCodeTypeId.SelectedValue+"'";
}
}
else
{
if (this.cboUserId.SelectedValue.ToString()!="" && this.cboUserId.SelectedValue.ToString()!="0")
{
strWhereCond += " And UserId='" + this.cboUserId.SelectedValue+"'";
}
if (this.cboPrjId.SelectedValue.ToString()!="" && this.cboPrjId.SelectedValue.ToString()!="0")
{
strWhereCond += " And PrjId='" + this.cboPrjId.SelectedValue+"'";
}
if (this.cboCodeTypeId.SelectedValue.ToString()!="" && this.cboCodeTypeId.SelectedValue.ToString()!="0")
{
strWhereCond += " And CodeTypeId='" + this.cboCodeTypeId.SelectedValue+"'";
}
}
return strWhereCond;
}
/// <summary>
/// �����еĲ�ѯ�ؼ�������ϳ�һ��������
/// </summary>
/// <returns>������(strWhereCond)</returns>
public string CombineUserCodePathCondion(string strTabName)
{
//ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
//���� 1=1 && UserName = '����'
string strWhereCond=" 1=1 ";
//����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
if (this.cboUserId.SelectedValue.ToString()!="" && this.cboUserId.SelectedValue.ToString()!="0")
{
strWhereCond += " And " + strTabName + ".UserId='" + this.cboUserId.SelectedValue+"'";
}
if (this.cboPrjId.SelectedValue.ToString()!="" && this.cboPrjId.SelectedValue.ToString()!="0")
{
strWhereCond += " And " + strTabName + ".PrjId='" + this.cboPrjId.SelectedValue+"'";
}
if (this.cboCodeTypeId.SelectedValue.ToString()!="" && this.cboCodeTypeId.SelectedValue.ToString()!="0")
{
strWhereCond += " And " + strTabName + ".CodeTypeId='" + this.cboCodeTypeId.SelectedValue+"'";
}
return strWhereCond;
}
/// <summary>
/// �������ܣ������ж�ɾ����ť�Ƿ���á�
///			 �����LISTVIEW��ѡ�м�¼����ʾɾ����ť������Ͳ���ʾ
/// </summary>
private void JudgebtnDelRec()
{
if (this.lvvUserCodePath.SelectedItems.Count >= 1)
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
if (this.lvvUserCodePath.SelectedItems.Count >= 1)
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
private void BindLv_vUserCodePath()
{
//�������裺(��4��)
//	1����Ͻ�����������
//	2��������������ȡ�ñ�����������DataTable��
//	3������ListView����ͷ��Ϣ
//	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��
//		�ڱ��������ǰ�״̬��ʾ�ڿؼ�lblRecCount�С�

ListViewItem lvivUserCodePath; 
List<clsvUserCodePathEN> arrvUserCodePathObjList;
//	1����Ͻ�����������
string strWhereCond = this.CombineUserCodePathCondion(false);	//  CombineUserCodePathCondion();
//	2��������������ȡ�ñ�����������DataTable��
arrvUserCodePathObjList = clsvUserCodePathBL.GetvUserCodePathObjList(strWhereCond);
//	3������ListView����ͷ��Ϣ
this.lvvUserCodePath.Items.Clear();//���ԭ������Item
this.lvvUserCodePath.Columns.Clear();//���ԭ��������ͷ��Ϣ
this.lvvUserCodePath.Columns.Add("mId", 100, HorizontalAlignment.Left);
this.lvvUserCodePath.Columns.Add("�û�ID", 100, HorizontalAlignment.Left);
this.lvvUserCodePath.Columns.Add("�û���", 100, HorizontalAlignment.Left);
this.lvvUserCodePath.Columns.Add("����ID", 100, HorizontalAlignment.Left);
this.lvvUserCodePath.Columns.Add("��������", 100, HorizontalAlignment.Left);
this.lvvUserCodePath.Columns.Add("����������", 100, HorizontalAlignment.Left);
this.lvvUserCodePath.Columns.Add("����·��", 100, HorizontalAlignment.Left);
this.lvvUserCodePath.Columns.Add("�û�״̬��", 100, HorizontalAlignment.Left);
this.lvvUserCodePath.Columns.Add("����ID", 100, HorizontalAlignment.Left);
this.lvvUserCodePath.Columns.Add("��������", 100, HorizontalAlignment.Left);
this.lvvUserCodePath.Columns.Add("�޸�����", 100, HorizontalAlignment.Left);
this.lvvUserCodePath.Columns.Add("�޸��û�Id", 100, HorizontalAlignment.Left);
this.lvvUserCodePath.Columns.Add("˵��", 100, HorizontalAlignment.Left);
this.lvvUserCodePath.View = View.Details;
//	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��
foreach (clsvUserCodePathEN objvUserCodePathEN in arrvUserCodePathObjList)
{
lvivUserCodePath = new ListViewItem();
lvivUserCodePath.Tag = objvUserCodePathEN.mId;
lvivUserCodePath.Text = objvUserCodePathEN.mId.ToString();
lvivUserCodePath.SubItems.Add(objvUserCodePathEN.UserId);
lvivUserCodePath.SubItems.Add(objvUserCodePathEN.UserName);
lvivUserCodePath.SubItems.Add(objvUserCodePathEN.PrjId);
lvivUserCodePath.SubItems.Add(objvUserCodePathEN.PrjName);
lvivUserCodePath.SubItems.Add(objvUserCodePathEN.CodeTypeName);
lvivUserCodePath.SubItems.Add(objvUserCodePathEN.CodePath);
lvivUserCodePath.SubItems.Add(objvUserCodePathEN.UserStateName);
lvivUserCodePath.SubItems.Add(objvUserCodePathEN.DepartmentId);
lvivUserCodePath.SubItems.Add(objvUserCodePathEN.DepartmentName);
lvivUserCodePath.SubItems.Add(objvUserCodePathEN.UpdDate);
lvivUserCodePath.SubItems.Add(objvUserCodePathEN.UpdUserId);
lvivUserCodePath.SubItems.Add(objvUserCodePathEN.Memo);
this.lvvUserCodePath.Items.Add(lvivUserCodePath);
}
//	4�����ü�¼����״̬��
//		�ڱ��������ǰ�״̬��ʾ�ڿؼ�txtRecCount�С�
this.lblRecNum.Text = "��¼����" + arrvUserCodePathObjList.Count.ToString();
}
private void btnQuery_Click(object sender, System.EventArgs e)
{
//�ѱ��¼��������ʾ��ListView��
BindLv_vUserCodePath();
}
/// <summary>
/// ��ȡDataGrid�е�ǰ�е�����ֵ
/// </summary>
/// <param name="objDataGrid">��������DataGrid</param>
/// <returns>��ǰ�е�����ֵ</returns>
private long GetCurrKey(DataGrid objDataGrid)
{
int intCurrRow = objDataGrid.CurrentRowIndex;
string strmId = objDTUserCodePath.Rows[intCurrRow]["mId"].ToString();
long lngmId = long.Parse(strmId);
return lngmId;
}
/// <summary>
/// ��ȡListView�е�ǰ�е�����ֵ
/// </summary>
/// <param name="objListView">��������ListView</param>
/// <returns>��ǰ�е�����ֵ</returns>
private long GetCurrKey(ListView objListView)
{
if (objListView.SelectedItems.Count == 0)
{
return 0;
}
ListViewItem lviUserCodePath;
lviUserCodePath = objListView.SelectedItems[0];
string strUserCodePathId = lviUserCodePath.Tag.ToString();
long lngmId = long.Parse(strUserCodePathId);
return lngmId;
}
/// <summary>
/// ��ȡListView�����������ֵ
/// </summary>
/// <param name="objListView">��������ListView��</param>
/// <returns>��ǰ�е�����ֵ</returns>
private long GetCurrKey(ListViewItem objListViewItem)
{
string strUserCodePathId = objListViewItem.Tag.ToString();
long lngmId = long.Parse(strUserCodePathId);
return lngmId;
}
private void lvvUserCodePath_Click(object sender, System.EventArgs e)
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
UpdateUserCodePathRecord();
}
/// <summary>
/// �������ܣ��¼�������������<ȷ���޸�>ʱ�������¼�������
///           ���幦��Ϊ�ѽ�������ͬ�����ݿ��У��ѽ������ݱ��浽���ݿ���
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
private void btnAdd_Click(object sender, System.EventArgs e)
{
frmUserCodePath_UI frm = new frmUserCodePath_UI();
frm.iBindListView = this;
frm.OperateType = "Add";
frm.ShowDialog();
}
private void btnDelRec_Click(object sender, System.EventArgs e)
{
DeleteUserCodePathRecord();
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
string strWhereCond = this.CombineUserCodePathCondion(true);
//	2��������������ȡ�ñ�����������DataTable��
System.Data.DataTable objDT = clsUserCodePathBL.GetDataTable_UserCodePath(strWhereCond);
ArrayList arrCnName = new ArrayList();
ArrayList arrColName = new ArrayList();
//string strFileName = "UserCodePath��Ϣ����.xls";
//string strFolderName;
string strDownLoadFileName;
arrColName.Add("UserId"); arrCnName.Add("�û�ID");
arrColName.Add("UserName"); arrCnName.Add("�û���");
arrColName.Add("PrjId"); arrCnName.Add("����ID");
arrColName.Add("PrjName"); arrCnName.Add("��������");
arrColName.Add("CodeTypeId"); arrCnName.Add("��������Id");
arrColName.Add("CodeTypeName"); arrCnName.Add("����������");
arrColName.Add("CodePath"); arrCnName.Add("����·��");
arrColName.Add("UserStateId"); arrCnName.Add("�û�״̬��");
arrColName.Add("UserStateName"); arrCnName.Add("�û�״̬��");
arrColName.Add("DepartmentId"); arrCnName.Add("����ID");
arrColName.Add("DepartmentName"); arrCnName.Add("��������");
arrColName.Add("UpdDate"); arrCnName.Add("�޸�����");
arrColName.Add("UpdUserId"); arrCnName.Add("�޸��û�Id");
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
string strWhereCond = this.CombineUserCodePathCondion(true);
//	2�����ñ��������ֶ������Լ����б���
ArrayList arrCnName = new ArrayList();
ArrayList arrColName = new ArrayList();
arrColName.Add("UserId"); arrCnName.Add("�û�ID");
arrColName.Add("UserName"); arrCnName.Add("�û���");
arrColName.Add("PrjId"); arrCnName.Add("����ID");
arrColName.Add("PrjName"); arrCnName.Add("��������");
arrColName.Add("CodeTypeId"); arrCnName.Add("��������Id");
arrColName.Add("CodeTypeName"); arrCnName.Add("����������");
arrColName.Add("CodePath"); arrCnName.Add("����·��");
arrColName.Add("UserStateId"); arrCnName.Add("�û�״̬��");
arrColName.Add("UserStateName"); arrCnName.Add("�û�״̬��");
arrColName.Add("DepartmentId"); arrCnName.Add("����ID");
arrColName.Add("DepartmentName"); arrCnName.Add("��������");
arrColName.Add("UpdDate"); arrCnName.Add("�޸�����");
arrColName.Add("UpdUserId"); arrCnName.Add("�޸��û�Id");
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
frm1.strTableName = "vUserCodePath";
frm1.strTableChineseName = "vUserCodePath";
frm1.strViewName = "�û�����·��ά��";
frm1.strWhereCondition = strWhereCond;
frm1.Show();
}

/// <summary>
/// �������ܣ�LISTVIEW���е����¼�����
/// </summary>
private void lvvUserCodePath_ColumnClick(object sender, System.Windows.Forms.ColumnClickEventArgs e)
{
if (e.Column == this.objvUserCodePathSorter.SortColumn)
{

}
else
{
this.objvUserCodePathSorter.SortColumn=e.Column;
}

if (this.objvUserCodePathSorter.SortOrder==SortOrder.Ascending)
{
this.objvUserCodePathSorter.SortOrder=SortOrder.Descending;
if(intLastSelectedvUserCodePathColumIndex == e.Column) //���Ƿ��ظ����һ��
{
this.lvvUserCodePath.Columns[e.Column].Text = this.lvvUserCodePath.Columns[e.Column].Text.Trim('��','��') + "��";
intLastSelectedvUserCodePathColumIndex = e.Column;
}
else //����������һ���ˣ���ôǰ������һ������ȥ��
{
this.lvvUserCodePath.Columns[e.Column].Text = this.lvvUserCodePath.Columns[e.Column].Text.Trim('��','��') + "��";
this.lvvUserCodePath.Columns[intLastSelectedvUserCodePathColumIndex].Text = this.lvvUserCodePath.Columns[intLastSelectedvUserCodePathColumIndex].Text.Trim('��','��');
intLastSelectedvUserCodePathColumIndex = e.Column;
}
}
else if (this.objvUserCodePathSorter.SortOrder==SortOrder.Descending) // �� ��
{
this.objvUserCodePathSorter.SortOrder=SortOrder.Ascending;
if(intLastSelectedvUserCodePathColumIndex == e.Column)
{
this.lvvUserCodePath.Columns[e.Column].Text = this.lvvUserCodePath.Columns[e.Column].Text.Trim('��','��') + "��";
intLastSelectedvUserCodePathColumIndex = e.Column;
}
else
{
this.lvvUserCodePath.Columns[e.Column].Text = this.lvvUserCodePath.Columns[e.Column].Text.Trim('��','��') + "��";
this.lvvUserCodePath.Columns[intLastSelectedvUserCodePathColumIndex].Text = this.lvvUserCodePath.Columns[intLastSelectedvUserCodePathColumIndex].Text.Trim('��','��');
intLastSelectedvUserCodePathColumIndex = e.Column;
}
}
else
{
return ;
}
this.lvvUserCodePath.Sort();
}

/// <summary>
/// ʵ�ֽӿں�����ͨ���Ӵ�����ã���ʵ�ֱ�����(������)��LISTVIEW���°󶨹���
/// </summary>
void IBindListView.BindListView()
{
BindLv_vUserCodePath();
}
///�����޸ļ�¼׼�����̴��� for C#
private void UpdateUserCodePathRecord()
{
if(this.lvvUserCodePath.SelectedItems.Count!=1)
{
DialogResult result;
result = MessageBox.Show("��ѡ��һ����¼��");
return;
}
frmUserCodePath_UI frm = new frmUserCodePath_UI();
string strKeyId = this.lvvUserCodePath.SelectedItems[0].Tag.ToString();
frm.mId_key = long.Parse(strKeyId);
frm.iBindListView = this;
frm.OperateType = "Update";
frm.ShowDialog();
}
 ///ɾ����¼���̴���for C#
private void DeleteUserCodePathRecord()
{
DialogResult result;
result = MessageBox.Show("�����Ҫɾ���ü�¼��", "ȷ��ɾ��", MessageBoxButtons.YesNo);
if (result == DialogResult.Yes)
{
foreach(ListViewItem lvi in this.lvvUserCodePath.SelectedItems)
{
long lngmId = GetCurrKey(lvi);
if(clsUserCodePathBL.DelRecord(lngmId)== false)
{
MessageBox.Show("ɾ����¼ʧ�ܣ�");
BindLv_vUserCodePath();
return ;
}
}
MessageBox.Show("ɾ����¼�ɹ���");
BindLv_vUserCodePath();
}
}
}
}