

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
///		wucTabCheckErrorTypeB ��ժҪ˵����
/// </summary>
public partial class wucTabCheckErrorTypeB : System.Web.UI.UserControl
{
protected void Page_Load(object sender, System.EventArgs e)
{
// �ڴ˴������û������Գ�ʼ��ҳ��

}
/// <summary>
/// �����������Id
/// </summary>
public string TabCheckErrorTypeId
{
get
{
return txtTabCheckErrorTypeId.Text.Trim();
}
set
{
txtTabCheckErrorTypeId.Text = value.ToString();
}
}

/// <summary>
/// �������������
/// </summary>
public string TabCheckErrorTypeName
{
get
{
return txtTabCheckErrorTypeName.Text.Trim();
}
set
{
txtTabCheckErrorTypeName.Text = value.ToString();
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
txtTabCheckErrorTypeId.ReadOnly = bolReadonly;
}
public void Clear()
{
txtTabCheckErrorTypeId.Text = "";
txtTabCheckErrorTypeName.Text = "";
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
txtTabCheckErrorTypeId.Text = "";
txtTabCheckErrorTypeName.Text = "";
txtMemo.Text = "";
}
}
}