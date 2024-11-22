namespace AGC.Webform
{
    using System;
    using System.Data;
    using System.Drawing;
    using System.Web;
    using System.Web.UI.WebControls;
    using System.Web.UI.HtmlControls;
    using CommFunc4WebForm;
    using AGC.BusinessLogic;using AGC.FunClass;
    
    using AGC.BusinessLogicEx;

    /// <summary>
    ///		wucViewInfoQuery ��ժҪ˵����
    /// </summary>
    public partial class wucViewInfoQuery : System.Web.UI.UserControl
	{

		protected void Page_Load(object sender, System.EventArgs e)
		{
			// �ڴ˴������û������Գ�ʼ��ҳ��
			tabHidden.Visible = false;
		}
        public string ApplicationTypeId
        {
            get
            {
                if (ddlApplicationTypeId.SelectedValue == "0")
                    return "";
                return ddlApplicationTypeId.SelectedValue;
            }
            set
            {
                if (value == "")
                {
                    ddlApplicationTypeId.SelectedValue = "0";
                }
                else
                {
                    ddlApplicationTypeId.SelectedValue = value;
                    if (ddlApplicationTypeId.SelectedIndex > 0)
                    {
                        string strApplicationTypeId = ddlApplicationTypeId.SelectedValue;

                    }
                }
            }
        }

		public string FuncModuleAgcId
		{
			get
			{
				if (ddlFuncModuleId.SelectedValue == "0")
				{
					return "";
				}
				return ddlFuncModuleId.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlFuncModuleId.SelectedValue = "0";
				}
				else
				{
					ddlFuncModuleId.SelectedValue = value;
				}
			}
		}

		public string ViewName
		{
			get
			{
				return txtViewName.Text.Trim();
			}
			set
			{
				txtViewName.Text = value.ToString();
			}
		}


		
		/// <summary>
		/// �����еĲ�ѯ�ؼ�������ϳ�һ��������
		/// </summary>
		/// <returns>������(strWhereCond)</returns>
		public string CombineCondition()
		{
			//ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
			//���� 1=1 and UserName = '����'
			string strWhereCond=" 1=1 ";
			//����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
			if (this.txtViewName.Text.Trim()!="")
			{
				strWhereCond += " and ViewName like '" + this.txtViewName.Text.Trim()+"%'";
			}

			if (this.ddlFuncModuleId.SelectedValue!="" && this.ddlFuncModuleId.SelectedValue!="0")
			{
				strWhereCond += " And FuncModuleAgcId='" + this.ddlFuncModuleId.SelectedValue+"'";
			}
			if (this.txtMainTabName.Text.Trim()!="")
			{
				strWhereCond += " and MainTabName like '" + this.txtMainTabName.Text.Trim()+"%'";
			}
			if (this.txtDetailTabName.Text.Trim()!="")
			{
				strWhereCond += " and DetailTabName like '" + this.txtDetailTabName.Text.Trim()+"%'";
			}
			//			if (this.chkIsNeedSort._Checked==true)
			//				strWhereCond += " and ViewInfo.IsNeedSort='1'";
			//			else
			//				strWhereCond += " and ViewInfo.IsNeedSort='0'";
			//			if (this.chkIsNeedTransCode._Checked==true)
			//				strWhereCond += " and ViewInfo.IsNeedTransCode='1'";
			//			else
			//				strWhereCond += " and ViewInfo.IsNeedTransCode='0'";
			if (this.txtUserId.Text.Trim()!="")
			{
				strWhereCond += " and UserId='" + this.txtUserId.Text.Trim()+"'";
			}
			if (this.ddlPrjId.SelectedValue!="" && this.ddlPrjId.SelectedValue!="0")
			{
				strWhereCond += " and PrjId='" + this.ddlPrjId.SelectedValue+"'";
			}
            if (this.ddlApplicationTypeId.SelectedValue != "" && this.ddlApplicationTypeId.SelectedValue != "0")
            {
                strWhereCond += " And ApplicationTypeId='" + this.ddlApplicationTypeId.SelectedValue + "'";
            }

			return strWhereCond;
		}
		public void SetDdl_FuncModuleId(string strPrjId)
		{
			clsFuncModule_AgcBLEx.BindDdl_FuncModuleId(ddlFuncModuleId, strPrjId, clsPubVar.CurrPrjDataBaseId);
		}
		public void SetDdl_PrjId()
		{
			clsProjectsBLEx.BindDdl_PrjIdCacheEx(ddlPrjId);
		}
        protected void ddlApplicationTypeId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlApplicationTypeId.SelectedIndex > -1)
            {
                int strApplicationTypeId = int.Parse( ddlApplicationTypeId.SelectedValue);
            }

        }
}
}
