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

namespace AGC.Webform
{
	/// <summary>
	/// wfmLoginBB ��ժҪ˵����
	/// </summary>
	public partial class wfmLoginBB : System.Web.UI.Page
	{
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// �ڴ˴������û������Գ�ʼ��ҳ��
		}

		protected void LinkButton1_Click(object sender, System.EventArgs e)
		{
//			Response.Redirect("http://202.121.54.152/webapps/bb-quickLogin-bb_bb60/quickLogin.jsp");
			Response.Redirect("webform1.aspx");
		}

		
        protected void lbLinkToBB_Click(object sender, EventArgs e)
        {
//			Response.Redirect("http://202.121.54.152/webapps/bb-quickLogin-bb_bb60/quickLogin.jsp?username=Administrator&password=changeme", true);
//			Session.Clear();
			string c1 = "<script language='javascript'>window.open('http://202.121.54.152/webapps/bb-quickLogin-bb_bb60/quickLogin.jsp?username=Administrator&password=changeme'); </script>";
			Response.Write(c1);

        }
}
}
