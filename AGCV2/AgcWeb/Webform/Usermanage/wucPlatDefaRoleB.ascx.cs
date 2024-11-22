

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
    using AGC.BusinessLogic;using AGC.FunClass;


    /// <summary>
    ///		wucPlatDefaRoleB ��ժҪ˵����
    /// </summary>
    public partial class wucPlatDefaRoleB : System.Web.UI.UserControl
{
protected void Page_Load(object sender, System.EventArgs e)
{
// �ڴ˴������û������Գ�ʼ��ҳ��

}
/// <summary>
/// ѧУ��ˮ��
/// </summary>
public string IdSchool
{
get
{
if (ddlIdSchool.SelectedValue == "0")
return "";
return ddlIdSchool.SelectedValue;
}
set
{
if (ddlIdSchool.Items.Count>0)
{
if (value == "")
{
ddlIdSchool.SelectedValue = "0";
}
else
{
ddlIdSchool.SelectedValue = value;
}
}
}
}

/// <summary>
/// ��Ա���
/// </summary>
public string PersonType
{
get
{
return txtPersonType.Text.Trim();
}
set
{
txtPersonType.Text = value.ToString();
}
}

/// <summary>
/// ����Id
/// </summary>
public string PrjId
{
get
{
return txtPrjId.Text.Trim();
}
set
{
txtPrjId.Text = value.ToString();
}
}

/// <summary>
/// ��ɫID
/// </summary>
public string RoleID
{
get
{
return txtRoleID.Text.Trim();
}
set
{
txtRoleID.Text = value.ToString();
}
}

/// <summary>
/// ��ע
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


public void Clear()
{
ddlIdSchool.SelectedIndex = 0;
txtPersonType.Text = "";
txtPrjId.Text = "";
txtRoleID.Text = "";
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
ddlIdSchool.SelectedIndex = 0;
txtPersonType.Text = "";
txtPrjId.Text = "";
txtRoleID.Text = "";
txtMemo.Text = "";
}
public System.Data.DataTable GetIdSchool()
{
//��ȡĳѧԺ����רҵ��Ϣ
string strSQL = "select IdSchool, SchoolName from XzSchool ";
clsSpecSQLforSql mySql=new clsSpecSQLforSql();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}
public void BindDdl_IdSchool(System.Web.UI.WebControls.DropDownList objDDL)
{
//Ϊ����Դ�ڱ����������������
ListItem li=new ListItem("��ѡ��...","0");
System.Data.DataTable objDT = GetIdSchool();
objDDL.DataValueField="IdSchool";
objDDL.DataTextField="SchoolName";
objDDL.DataSource = objDT;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}
public void SetDdl_IdSchool()
{
clsXzSchoolBL.BindDdl_IdSchool(ddlIdSchool);
}
}
}