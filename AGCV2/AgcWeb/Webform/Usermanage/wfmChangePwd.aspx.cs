using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using CommFunc4WebForm;
using AGC.Entity;
using AGC.BusinessLogic;using AGC.FunClass;

namespace AGC.Webform
{
	/// <summary>
	/// chpwd ��ժҪ˵����
	/// </summary>
	public partial class wfmChangePassWord : System.Web.UI.Page
	{
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			//if(Session.Count==0)		Response.Redirect("welcome.html");
			
		}

		protected void btnSubmit_Click(object sender, System.EventArgs e)
		{
			//�������裺
			//1����SESSIONȡ����ǰ���û�ID(��ÿ�����������һ���û�ID�����ԣ����ÿ�ζ��������SESSION)��
			//2����鵱ǰ�û�����������Ƿ���ȷ, �������ȷ���ͷ��أ�����ȷ��ִ����һ��
			//3������û���������������Ƿ�һ�£�����һ�¾��˳�����һ�¾�ִ����һ��
			//4���ѵ�ǰ�û���UserId���ó������롣
			//5�������߼���<�޸�>���ִ���޸Ĳ�����

			string strNewPassWord;		//�µĿ���
			string strMsg;
			///��������CODEʵ�֣�
			//1����SESSIONȡ����ǰ���û�ID(��ÿ�����������һ���û�ID�����ԣ����ÿ�ζ��������SESSION)��
			clsUsersEN objUser;
			objUser = (clsUsersEN)Session["objUser"];
			if (objUser == null) 
			{
				lblMsg.Text = "��ǰ�û������ڻ�ʱ�������µ�¼!";
				return ;
			}
			//2����鵱ǰ�û�����������Ƿ���ȷ,�������ȷ���ͷ��أ�����ȷ��ִ����һ��;
			if(txtOldpwd.Text != objUser.Password )
			{
				Response.Write("<script>alert('���벻��ȷ��')</script>");
				return;
			}
			//3������û���������������Ƿ�һ�£�����һ�¾��˳�����һ�¾�ִ����һ��
			strNewPassWord = txtNewpwd.Text;
			if(strNewPassWord != txtNewpwd2.Text)
			{
				Response.Write("<script>alert('ȷ�����벻��')</script>");
				return;
			}

			//4���ѵ�ǰ�û���UserId���ó������롣
			objUser.Password = strNewPassWord;
			//5�������߼���<�޸�>���ִ���޸Ĳ�����
			if (clsUsersBL .UpdateBySql2(objUser) ==false)
			{
				strMsg = "�޸����벻�ɹ�!";
				clsCommonJsFunc.Alert(this, strMsg);
				lblMsg.Text = "�޸����벻�ɹ�!";
			}
			else
			{
				strMsg = "�޸�����ɹ�!";
				clsCommonJsFunc.Alert(this, strMsg);
				lblMsg.Text = "�޸�����ɹ�!";
			}
							
		}
        
}
}
