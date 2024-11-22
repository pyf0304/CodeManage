

namespace AGC.Webform
{
using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using com.taishsoft.common;
using com.taishsoft.commdb;
using AGC.Entity;
using AGC.BusinessLogic;using AGC.FunClass;using AGC.BusinessLogicEx;

/// <summary>
///		wucFeatureRegionB ��ժҪ˵����
/// </summary>
public partial class wucFeatureRegionB : System.Web.UI.UserControl
{
protected void Page_Load(object sender, System.EventArgs e)
{
// �ڴ˴������û������Գ�ʼ��ҳ��

}
/// <summary>
/// ����Id
/// </summary>
public string RegionId
{
get
{
return long.Parse(txtRegionId.Text.Trim());
}
set
{
txtRegionId.Text = value.ToString();
}
}

/// <summary>
/// ��ť��ʽId
/// </summary>
public string ButtonStyleId
{
get
{
if (ddlButtonStyleId.SelectedValue == "0")
return "";
return ddlButtonStyleId.SelectedValue;
}
set
{
if (ddlButtonStyleId.Items.Count>0)
{
if (value == "")
{
ddlButtonStyleId.SelectedValue = "0";
}
else
{
ddlButtonStyleId.SelectedValue = value;
}
}
}
}

/// <summary>
/// ˵��
/// </summary>
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
txtRegionId.ReadOnly = bolReadonly;
}
public void Clear()
{
txtRegionId.Text = "0";
ddlButtonStyleId.SelectedIndex = 0;
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
ComValid_RegionId.Validate();
if (!ComValid_RegionId.IsValid) return false;
if (clsString.IsNumeric(txtRegionId.Text) == false)
{
strResult = "��������ȷ������!";
return false;
}
return true;
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
txtRegionId.Text = "0";
ddlButtonStyleId.SelectedIndex = 0;
txtMemo.Text = "";
}
public System.Data.DataTable GetButtonStyleId()
{
//��ȡĳѧԺ����רҵ��Ϣ
string strSQL = "select ButtonStyleId, ButtonStyleName from ButtonStyle ";
clsSpecSQLforSql mySql=new clsSpecSQLforSql();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}
public void BindDdl_ButtonStyleId(System.Web.UI.WebControls.DropDownList objDDL)
{
//Ϊ����Դ�ڱ����������������
ListItem li=new ListItem("��ѡ��...","0");
System.Data.DataTable objDT = GetButtonStyleId();
objDDL.DataValueField="ButtonStyleId";
objDDL.DataTextField="ButtonStyleName";
objDDL.DataSource = objDT;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}
public void SetDdl_ButtonStyleId()
{
clsButtonStyleBL.BindDdl_ButtonStyleId(ddlButtonStyleId);
}
}
}