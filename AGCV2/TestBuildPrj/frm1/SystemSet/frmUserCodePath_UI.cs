
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
using com.taishsoft.commdb;
using AGC_CSV7.Entity;
using AGC_CSV7.BusinessLogic;
using com.taishsoft.util;
using CommFunc4Win;

namespace AGC_CSV7
{
/// <summary>
///		frmUserCodePath_UI ��ժҪ˵����
/// </summary>
public partial class frmUserCodePath_UI : System.Windows.Forms.Form
{
clsUserCodePathEN objUserCodePathEN = null;
private long mlngmId;		//���ڴ��ݹؼ���ֵ�ı���
public string OperateType;
public IBindListView iBindListView = null;
public frmUserCodePath_UI()
{
// �õ����� Windows.Forms ���������������ġ�
InitializeComponent();

// TODO: �� InitializeComponent ���ú�����κγ�ʼ��

}
private void frmUserCodePath_UI_Load(object sender, System.EventArgs e)
{
// �ڴ˴������û������Գ�ʼ��ҳ��
//1��Ϊ��������������Դ�����б�����
this.SetAllComboBox();
if (OperateType == "Update")
{
ShowData(mlngmId);
btnOKUpd.Text = "ȷ���޸�";
}
else
{
AddUserCodePathRecord();
}

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

public string CodePath
{
get
{
return txtCodePath.Text.Trim();
}
set
{
txtCodePath.Text = value.ToString();
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

public string UpdUserId
{
get
{
return txtUpdUserId.Text.Trim();
}
set
{
txtUpdUserId.Text = value.ToString();
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


public void Clear()
{
cboUserId.SelectedIndex = 0;
cboPrjId.SelectedIndex = 0;
cboCodeTypeId.SelectedIndex = 0;
txtCodePath.Text = "";
txtUpdDate.Text = "";
txtUpdUserId.Text = "";
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
cboUserId.SelectedIndex = 0;
cboPrjId.SelectedIndex = 0;
cboCodeTypeId.SelectedIndex = 0;
txtCodePath.Text = "";
txtUpdDate.Text = "";
txtUpdUserId.Text = "";
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
/// �������ܣ����Ըùؼ��ֵļ�¼������ʾ�ڽ����ϣ�
///������     �������ǰ�ֵ������ؼ���
/// </summary>
/// <param name="lngmId">���¼�Ĺؼ��֣���ʾ�ñ�ؼ��ֵ�����</param>
private void ShowData(long lngmId)
{
//�������裺
//1�����ؼ����Ƿ�Ϊ�գ�
//2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
//3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
//4����ȡ�������������ԣ�
//5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���

//1�����ؼ����Ƿ�Ϊ�գ�
if (lngmId == 0) return ;		//����ؼ���Ϊ�վͷ����˳�
//2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
if (clsUserCodePathBL.IsExist(lngmId) == false)		//���ùؼ��ֵļ�¼�Ƿ����
{
string ss = "�ؼ���Ϊ��" + lngmId + "�Ĳ�����!";
MessageBox.Show(ss);
return ;
}
//3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
objUserCodePathEN = new clsUserCodePathEN(lngmId);
//4����ȡ�������������ԣ�
clsUserCodePathBL.GetUserCodePath(ref objUserCodePathEN);
//5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���
GetDataFromUserCodePathClass(objUserCodePathEN);
}
///���ɴ��߼�������ݴ��䵽�����ĺ�������
private void GetDataFromUserCodePathClass(clsUserCodePathEN pobjUserCodePathEN)
{
///ע�⣺��������������򣬲�����һ��������������ϵ�ģ�����Ϊһ��������ֵ��Ȼ����Ϊ����������ֵ
///      ������������ݿ�ʱ����Ӧ��һ���ֶ���ǰ�������ֶ��ں�
this.UserId = pobjUserCodePathEN.UserId;
this.PrjId = pobjUserCodePathEN.PrjId;
this.CodeTypeId = pobjUserCodePathEN.CodeTypeId;
this.CodePath = pobjUserCodePathEN.CodePath;
this.UpdDate = pobjUserCodePathEN.UpdDate;
this.UpdUserId = pobjUserCodePathEN.UpdUserId;
this.Memo = pobjUserCodePathEN.Memo;
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
AddUserCodePathRecord();
break;				
case "ȷ�����":
//����һ������Ĳ���Ĵ��룬�����߼���̫�򵥣�
//�Ͱ��߼���ϲ������Ʋ�,
AddUserCodePathRecordSave();
break;
case "ȷ���޸�":
//����һ��������޸ĵĴ��룬�����߼���̫�򵥣�
//�Ͱ��߼���ϲ������Ʋ�,
UpdateUserCodePathRecordSave(objUserCodePathEN);
break;
}
}
private void PutDataToUserCodePathClass(clsUserCodePathEN pobjUserCodePathEN)
{
pobjUserCodePathEN.UserId = this.UserId;
pobjUserCodePathEN.PrjId = this.PrjId;
pobjUserCodePathEN.CodeTypeId = this.CodeTypeId;
pobjUserCodePathEN.CodePath = this.CodePath;
pobjUserCodePathEN.UpdDate = this.UpdDate;
pobjUserCodePathEN.UpdUserId = this.UpdUserId;
pobjUserCodePathEN.Memo = this.Memo;
}
private void btnClose_Click(object sender, System.EventArgs e)
{
this.Close();
}
public long mId_key
{
get
{
return mlngmId;
}
set
{
mlngmId = value;
}
}
///���ɵĲ����¼׼�����̴���for C#
protected void AddUserCodePathRecord()
{
btnOKUpd.Text = "ȷ�����";
//this.mId = clsCommForWin.GetMaxStrId("UserCodePath","mId", 8, "");
//DispEditUserCodePathRegion();
}
///�����¼���̹��̴���for C#
private void AddUserCodePathRecordSave()
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
clsUserCodePathEN objUserCodePath;
//1�����ؼ����������������Ƿ���ȷ
if (!this.IsValid(ref strResult))
{
lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
return ;
}
//2����ʼ����������
objUserCodePathEN = new clsUserCodePathEN();	//��ʼ���¶���
//3���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
//4����ֵ�ӽ���㴫���߼��������ʵ���
PutDataToUserCodePathClass(objUserCodePathEN);		//�ѽ����ֵ����
//5����鴫��ȥ�Ķ��������Ƿ�Ϸ�
try
{
clsUserCodePathBL.CheckPropertyNew(objUserCodePathEN);
//6��������ʵ�������ݴ��������ݿ���
clsUserCodePathBL.AddNewRecordBySql2(objUserCodePathEN);
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
private void UpdateUserCodePathRecordSave(clsUserCodePathEN objUserCodePathEN)
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
PutDataToUserCodePathClass(objUserCodePathEN);		//�ѽ����ֵ����
//3����鴫��ȥ�Ķ��������Ƿ�Ϸ�
try
{
clsUserCodePathBL.CheckPropertyNew(objUserCodePathEN);
//6��������ʵ�������ݴ��������ݿ���
clsUserCodePathBL.UpdateBySql2(objUserCodePathEN);
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