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
using AGC.Entity;
using AGC.FunClass;

namespace AGC.Webform
{
	/// <summary>
	/// wfmPortal ��ժҪ˵����
	/// </summary>
	public partial class wfmPortal : System.Web.UI.Page
	{
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// �ڴ˴������û������Գ�ʼ��ҳ��
			if (!IsPostBack)
			{
                if (clsCommonSession.objQxUser != null)
                {
                    lblWelComeMsg.Text = clsCommonSession.objQxUser.UserName + "����ӭ��ʹ�ñ�ϵͳ!";
                }
			}

		}
				
		private clsUsersEN objUserBak
		{
			get
			{
				clsUsersEN pobjUser;
				pobjUser = (clsUsersEN)Session["objUser"];
				if (pobjUser==null) 
				{
					pobjUser = null;
				}
				return pobjUser;
			}
			set
			{
				clsUsersEN pobjUser = value;
				Session.Add("objUser", pobjUser);
			}
		}

	}
}
