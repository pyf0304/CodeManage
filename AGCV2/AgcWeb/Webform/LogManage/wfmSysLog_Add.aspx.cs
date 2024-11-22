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
using CommFunc4WebForm;
using AGC.BusinessLogicEx;
using AGC.FunClass;

namespace AGC
{
	/// <summary>
	/// wfmSysLog_Add ��ժҪ˵����
	/// </summary>
	public partial class wfmSysLog_Add : System.Web.UI.Page
	{
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// �ڴ˴������û������Գ�ʼ��ҳ��
			if (!IsPostBack)
			{
				clsOperationTypeBLEx.BindDdl_OpTypeId(ddlOpTypeId);
			}
		}
        //private string PrjId
        //{
        //    get
        //    {
        //        string strPrjId;
        //        strPrjId = (string)Session["P1rjId"];
        //        if (strPrjId==null) 
        //        {
        //            strPrjId = "";
        //            clsCommForWebForm.CheckPrjId(strPrjId, this);
        //        }
        //        return strPrjId;
        //    }
        //    set
        //    {
        //        string strPrjId = value;
        //        Session.Add("PrjId", strPrjId);
        //    }
        //}
		protected void btnQuery_Click(object sender, System.EventArgs e)
		{
		    string strUserId=this.txtUserIdq.Text.Trim();
			string strUserIp=this.txtUserIpq.Text.Trim();
			string strUserName=this.txtUserNameq.Text.Trim();
			string strOperationType = this.ddlOpTypeId.SelectedValue.Trim();
			string strTableName=this.txtTableNameq.Text.Trim();
			string strTableKey=this.txtTableKeyq.Text.Trim();
			string strJournal="ִ������Ӳ���!";
			bool IsSuccesful=true;
            IsSuccesful = clsSysLogServerBLEx.AddSysLogInfo(strUserId, strUserIp, strOperationType, strTableName, strTableKey, strJournal, clsPubVar.CurrSelPrjId);
			if(IsSuccesful)
			{
                 Response.Write("<script>alert('��־��ӳɹ�!')</script>");
			}
		}

		private void Button1_Click(object sender, System.EventArgs e)
		{
			string strUserId=this.txtUserIdq.Text.Trim();
			string strUserIp=this.txtUserIpq.Text.Trim();
			string strUserName=this.txtUserNameq.Text.Trim();
			string strOperationType = this.ddlOpTypeId.SelectedValue.Trim();
			string strTableName=this.txtTableNameq.Text.Trim();
	
			bool IsSuccesful=true;
			IsSuccesful= clsSysLogServerBLEx.AddSystemBaseJournalInfo(strUserId, strUserIp,strOperationType, strTableName);
			if(IsSuccesful)
			{
				Response.Write("<script>alert('��־��ӳɹ�!')</script>");
			}
		}
	}
}
