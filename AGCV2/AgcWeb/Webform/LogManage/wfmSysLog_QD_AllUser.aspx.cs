///���ɲ�ѯ���޸ģ�ɾ������Ӽ�¼�Ŀ��Ʋ����


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
using com.taishsoft.commdb;
using CommFunc4WebForm;


using System.Collections.Generic;
using AGC.BusinessLogic;using AGC.FunClass;

using AGC.BusinessLogicEx;

using com.taishsoft.common;

namespace AGC
{
	/// <summary>
	/// wfmSysLog_QUDI ��ժҪ˵��������Q�����ѯ��U�����޸�
	/// </summary>
	public partial class wfmSysLog_QD_AllUser : CommWebPageBase
    {

		
		//�����йصı����������
		private const string ViewId4Potence="00260203";		//������


		protected void Page_Load(object sender, System.EventArgs e)
		{
			// �ڴ˴������û������Գ�ʼ��ҳ��
			if (!IsPostBack)	///����������ǳ��α����ã������ǵ�����ť�¼�������
			{

				//����Ȩ���й��ж�Ȩ�޵Ĵ���
				//���ݵȼ�Ȩ�ޱ����ȷ���û�����ʹ��ʲô���ܣ��ȼ���ŷ�ʽ��1Ϊ���2��Σ���������
				switch (strPotenceLevel)
				{
					case "0":
						clsPubFun4Web.AccessError(this, conCurrPageName);
						break;
					case "1":
						clsPubFun4Web.AccessError(this, conCurrPageName);
						break;
					case "2":
						clsPubFun4Web.AccessError(this, conCurrPageName);
						break;
					case "3":
						clsPubFun4Web.AccessError(this, conCurrPageName);
						break;
					case "4":
						clsPubFun4Web.AccessError(this, conCurrPageName);
						break;
					case "9":
						break;
					default:
						clsPubFun4Web.AccessError(this, conCurrPageName);
						break;
				}

				//1��Ϊ��������������Դ�����б�����
				clsOperationTypeBLEx.BindDdl_OpTypeId(ddlOpTypeIdq);
				clsProjectsBLEx.BindDdl_PrjIdCacheEx(ddlPrjIdq);
				strSortSysLogBy = "mId Asc";
				//2����ʾ�������ı�������DATAGRID��
				BindDg_SysLog();
				//3�����ñ�ؼ����ֿؼ���ReadOnly���ԣ�
				//   ʹֻ֮������Ϊ���޸Ĺ����йؼ����ǲ��ܱ��޸ĵġ�
				///   
				HideAdvanceQuery();
			}
		}

		//����Ȩ�޵ȼ�������
		private string  strPotenceLevel
		{
			get
			{
				string sPotenceLevel;
				sPotenceLevel = (string)ViewState["PotenceLevel"];
				if (sPotenceLevel==null) 
				{
					//					sPotenceLevel=new TzGeneralPlatformDll.MenuAndPotence(clsSysParaEN.ConfigFileName).Get_PotenceLevel(ViewId4Potence);
					sPotenceLevel = "9";
					ViewState.Add("PotenceLevel", sPotenceLevel);
				}
				return sPotenceLevel;
			}
		}


		
		private string UserId
		{
			get
			{
				string strUserId;
				strUserId = (string)Session["UserId"];
				if (strUserId==null) 
				{
					strUserId = "";
                    clsCommForWebForm.CheckUserId(strUserId, this);
                }
				return strUserId;
			}
			set
			{
				string strUserId = value;
				Session.Add("UserId", strUserId);
			}
		}
		///private clsUsersEN objUserBak
		///{
		///get
		///{
		///clsUsersEN pobjUser;
		///pobjUser = (clsUsersEN)Session["objUser"];
		///if (pobjUser==null) 
		///{
		///pobjUser = null;
		///}
		///return pobjUser;
		///}
		///set
		///{
		///clsUsersEN pobjUser = value;
		///Session.Add("objUser", pobjUser);
		///}
		///}


		

		
		/// <summary>
		/// �����еĲ�ѯ�ؼ�������ϳ�һ��������
		/// </summary>
		/// <returns>������(strWhereCond)</returns>
		private string CombineSysLogCondition()
		{
			//ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
			//���� 1=1 && UserName = '����'
			string strWhereCond=" 1=1 and PrjId in (Select PrjId from   UserPrjGrant where UserId = '" + UserId + "') " ;
			//����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
			if (this.txtUserIdq.Text.Trim()!="")
			{
				strWhereCond += " And UserId like '%" + this.txtUserIdq.Text.Trim()+"%'";
			}
			if (this.txtUserNameq.Text.Trim()!="")
			{
				strWhereCond += " And UserName like '%" + this.txtUserNameq.Text.Trim()+"%'";
			}
			if (this.txtUserIpq.Text.Trim()!="")
			{
				strWhereCond += " And UserIp like '%" + this.txtUserIpq.Text.Trim()+"%'";
			}
			if (this.txtOpDateq.Text.Trim()!="")
			{
				strWhereCond += " And OperationDate like '%" + this.txtOpDateq.Text.Trim()+"%'";
			}
			if (this.txtOpTimeq.Text.Trim()!="")
			{
				strWhereCond += " And OperationTime like '%" + this.txtOpTimeq.Text.Trim()+"%'";
			}
			if (this.ddlOpTypeIdq.SelectedValue!="" && this.ddlOpTypeIdq.SelectedValue!="0")
			{
				strWhereCond += " And OpTypeId='" + this.ddlOpTypeIdq.SelectedValue+"'";
			}
			if (this.txtTableNameq.Text.Trim()!="")
			{
				strWhereCond += " And TableName like '%" + this.txtTableNameq.Text.Trim()+"%'";
			}
			if (this.txtTableKeyq.Text.Trim()!="")
			{
				strWhereCond += " And TableKey like '%" + this.txtTableKeyq.Text.Trim()+"%'";
			}
			if (this.ddlPrjIdq.SelectedValue!="" && this.ddlPrjIdq.SelectedValue!="0")
			{
				strWhereCond += " and PrjId='" + this.ddlPrjIdq.SelectedValue+"'";
			}

			return strWhereCond;
		}
		///���ɰ�DATAGRID�Ĵ���
		/// <summary>
		/// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
		///			 ����ʾ��DATAGRID�С�
		/// </summary>
		private void BindDg_SysLog()
		{
			//�������裺(��5��)
			//	1����Ͻ�����������
			//	2��������������ȡ�ñ�����������DataTable��
			//	3���б�DATAGRID�ĵ�ǰҳ���Ƿ񳬳�DATAGRID��ҳ����Χ
			//	4������DATAGRID������Դ(DataSource)��
			//	5����DATAGRID������DataTable��������ʾ��DATAGRID��
			//	6�����ü�¼����״̬��
			//		�ڱ��������ǰ�״̬��ʾ�ڿؼ�txtRecCount�С�

			//	1����Ͻ�����������
			string strWhereCond = CombineSysLogCondition();
			//	2��������������ȡ�ñ�����������DataTable��
			System.Data.DataTable objDT = clsvSysLogBL.GetDataTable(strWhereCond);
			//	3�����DATAGRID�ĵ�ǰҳ���Ƿ񳬳�DATAGRID��ҳ����Χ
			//		3.1 ���ȼ���ҳ����
			//		3.2 �����ǰҳ����ҳ����Ϊ���һҳ
			int intPages = CalcPages(objDT.Rows.Count, this.dgSysLog.PageSize);
			if (intPages==0) 
			{
				this.dgSysLog.CurrentPageIndex = 0;
			}
			else if (this.dgSysLog.CurrentPageIndex > intPages - 1) 
			{
				this.dgSysLog.CurrentPageIndex = intPages - 1;
			}
			//	4������DATAGRID������Դ(DataSource)��
			DataView objDV = objDT.DefaultView;
			objDV.Sort = strSortSysLogBy;     ///ע����һ�д����п�����Ҫע�͵���Ŀǰ���н����ڵ����Ĳ�ѯ������������
			this.dgSysLog.DataSource=objDV;
			//	5����DATAGRID������DataTable��������ʾ��DATAGRID��
			this.dgSysLog.DataBind();

			
			//��ǰ��¼��
			this.lblSysLogRecCount.Text = objDT.Rows.Count.ToString(); 
			//��ǰҳ��
			this.lblSysLogAllPages.Text = this.dgSysLog.PageCount.ToString(); 
			//��ǰҳ����
			this.lblSysLogCurrentPage.Text=(this.dgSysLog.CurrentPageIndex+1).ToString();
			//��ǰ����������ҳ����
			this.txtSysLogJump2Page.Text=(this.dgSysLog.CurrentPageIndex+1).ToString();
			//�����ǰҳ����Ϊ0����<ǰһҳ>��ť��Ч
			if(this.dgSysLog.CurrentPageIndex==0) 
			{
				btnSysLogPrevPage.Enabled=false; 
			}
			else 
			{ 
				btnSysLogPrevPage.Enabled=true; 
			} 
			//�����ǰҳ������Ϊ���һҳ����<ǰһҳ>��ť��Ч
			if(this.dgSysLog.CurrentPageIndex==this.dgSysLog.PageCount-1) 
			{ 
				btnSysLogNextPage.Enabled=false; 
			} 
			else 
			{ 
				btnSysLogNextPage.Enabled=true; 
			} 
			//7�������沿����ʾ����ʾ �������ǰDataGrid�еļ�¼��Ϊ0������ʾ��ǰ����ҳ������
			if(objDT.Rows.Count>0) 
			{ 
				this.tabSysLogJumpPage.Visible = true; 
			} 
			else 
			{ 
				this.tabSysLogJumpPage.Visible = false; 
			}
		}

		/// <summary>
		/// ���ܣ�����DataGrid��ҳ��
		/// </summary>
		/// <param name="intRecCount">�ܹ��ļ�¼��</param>
		/// <param name="intPageSize">ÿҳ�ļ�¼��</param>
		/// <returns>���������ҳ��</returns>
		private int CalcPages(int intRecCount, int intPageSize)
		{
			int intPages;
			intPages = intRecCount / intPageSize;
			if (intRecCount % intPageSize !=0) intPages ++;
			return intPages;
		}

		/// <summary>
		/// �������ܣ��¼�������������<��ѯ>��ťʱ���������¼�
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected void btnQuery_Click(object sender, System.EventArgs e)
		{
			//��DATAGRID�ĵ�ǰҳ��������Ϊ0������1ҳ��
			//��������ѯʱ��������ʾ���Ǳ��¼���ݵĵ�һ�������ݡ�
			this.dgSysLog.CurrentPageIndex=0;
			//�ѱ��¼��������ʾ��DATAGRID��
			BindDg_SysLog();
		}
		/// <summary>
		/// �������ܣ��¼��������ڸ���DATAGRID�ĵ�ǰҳ����ʱ�����ĺ�����
		///			  ���幦����������ʾ��ҳ(������ҳ����)�����ݡ�
		/// </summary>
		/// <param name="source"></param>
		/// <param name="e"></param>
		protected void dgSysLog_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			//�������裺����2����
			//1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
			//2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ

			//1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
			this.dgSysLog.CurrentPageIndex=e.NewPageIndex;
			//2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ
			BindDg_SysLog();
		}
		protected void dgSysLog_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
		{
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
				System.Web.UI.WebControls.LinkButton myDeleteButton;
				myDeleteButton = (System.Web.UI.WebControls.LinkButton)e.Item.FindControl("lbnDelete");
				myDeleteButton.Attributes.Add("onclick", "return confirm('�����Ҫɾ���� " + (e.Item.ItemIndex+1).ToString() + " ����');");
			}
			int intIndex;
			if (strSortSysLogBy == "") return ;
			if(e.Item.ItemType==ListItemType.Header)//����ؼ��Ƿ�Ϊҳü��
			{
				string strSortEx;
				for(int i=0;i<this.dgSysLog.Columns.Count;i++)
				{
					strSortEx = this.dgSysLog.Columns[i].SortExpression;
					if (strSortEx == "") continue;
					intIndex = strSortSysLogBy.IndexOf(strSortEx + " ");
					if(intIndex >=0)  //��ͼ״̬��������ʽ�Ƿ�Ϊ���е��ֶΣ�
					{
						Label lblSort=new Label();
						lblSort.Font.Name="webdings";//�������壬��"webdings"��5�������ǣ�6�������ǣ�
						intIndex = strSortSysLogBy.IndexOf("Asc");
						lblSort.Text=(intIndex>0?" 5":" 6");//�Ƿ�Ϊ���򣬶���Ϊstring�ͣ�
						e.Item.Cells[i].Controls.Add(lblSort);//��������ĵ�i����Ԫ��������һ�ؼ���
						break;
					}
				}
			}
		}

		protected void dgSysLog_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			long lngmId;
			string strCommandName;
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.SelectedItem ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
				strCommandName = ((LinkButton)e.CommandSource).CommandName;
				lngmId = long.Parse(e.Item.Cells[0].Text);
				switch(strCommandName)
				{
					case "Delete":
						clsSysLogBL.DelRecord(lngmId);
						BindDg_SysLog();
						break;
						// Add other cases here, if there are multiple ButtonColumns in 
						// the DataGrid control.

					default:
						// Do nothing.
						break;
				}
			}
			if (e.Item.ItemType == ListItemType.Header)
			{
				System.Web.UI.WebControls.LinkButton lbSelAll;
				lbSelAll = (LinkButton)e.CommandSource;
				if (lbSelAll.CommandName != "lbSelAll")
				{
					return ;
				}
				if (lbSelAll.Text == "ȫѡ")
				{
					Set_DataGridAllChecked(dgSysLog, true);
					lbSelAll.Text = "��ѡ";
				}
				else if (lbSelAll.Text == "��ѡ")
				{
					Set_DataGridAllChecked(dgSysLog, false);
					lbSelAll.Text = "ȫѡ";
				}
			}		
		}
		private void Set_DataGridAllChecked(DataGrid objDg, bool IsSelected)
		{
			if(objDg.Items.Count==0 )
			{
				return;
			}
			else
			{
				foreach(DataGridItem di in objDg.Items)
				{
					CheckBox cb=(CheckBox)di.FindControl("chkCheckRec");
					if(cb!=null )
					{
						cb.Checked=IsSelected;
					}
				}
			}
		}

		
		protected void dgSysLog_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
		{
			int intIndex;
			//�ж��Ƿ����µ������ֶ�
			intIndex = strSortSysLogBy.IndexOf(e.SortExpression);
			if (intIndex == -1)
			{
				strSortSysLogBy = e.SortExpression + " Asc";
				BindDg_SysLog();
				return ;
			}
			//���ԭ��������
			intIndex = strSortSysLogBy.IndexOf(" Asc");
			if (intIndex == -1)		//���ԭ���������������Ϊ����
			{
				strSortSysLogBy = e.SortExpression + " Asc";
			}
			else			///��������Ϊ����
			{
				strSortSysLogBy = e.SortExpression + " Desc";
			}
			BindDg_SysLog();
		}

		private string strSortSysLogBy
		{
			get
			{
				string sSortSysLogBy;
				sSortSysLogBy = (string)ViewState["SortSysLogBy"];
				if (sSortSysLogBy==null) 
				{
					sSortSysLogBy = "";
				}
				return sSortSysLogBy;
			}
			set
			{
				string sSortSysLogBy = value;
				ViewState.Add("SortSysLogBy", sSortSysLogBy);
			}
		}

		//���ɸ������SESSION������Ժ���
		protected void btnSysLogPrevPage_Click(object sender, System.EventArgs e)
		{
			this.dgSysLog.CurrentPageIndex -=1; 
			this.BindDg_SysLog(); 
		}

		protected void btnSysLogNextPage_Click(object sender, System.EventArgs e)
		{
			this.dgSysLog.CurrentPageIndex +=1; 
			this.BindDg_SysLog(); 
		}

		protected void btnSysLogJumpPage_Click(object sender, System.EventArgs e)
		{
			if(this.txtSysLogJump2Page.Text.Trim()!="" && 
				int.Parse(this.txtSysLogJump2Page.Text)>0 && 
				int.Parse(this.txtSysLogJump2Page.Text)-1<this.dgSysLog.PageCount) 
			{ 
				this.dgSysLog.CurrentPageIndex=int.Parse(this.txtSysLogJump2Page.Text)-1; 
			} 
			this.BindDg_SysLog();
		}

		protected void btnDelete4Dg_Click(object sender, System.EventArgs e)
		{
			this.lblMsg.Text="";
            List<string> arrPicId = clsCommForWebForm.GetAllCheckedItemFromDg2(dgSysLog, "chkCheckRec");
			if (arrPicId == null || arrPicId.Count == 0) 
			{
				lblMsg.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
				return ;
			}
			//			lblMsg.Text = "";
			clsSysLogBL.DelSysLogs(arrPicId);
			BindDg_SysLog();

		}

		protected void lbAdvanceQuery_Click(object sender, System.EventArgs e)
		{
			DispAdvanceQuery();
		}
		private void DispAdvanceQuery()
		{
			divOperateInfo.Visible = true;
			divPrjTabInfo.Visible = true;
		}
		private void HideAdvanceQuery()
		{
			divOperateInfo.Visible = false;
			divPrjTabInfo.Visible = false;
		}

		protected void Linkbutton1_Click(object sender, System.EventArgs e)
		{
			HideAdvanceQuery();
		}

		protected void lbHideAdvanceQuery_Click(object sender, System.EventArgs e)
		{
			HideAdvanceQuery();
		}

        protected void btnSysLogNextPage_Click1(object sender, EventArgs e)
        {

        }
        #region ����ҳ����Ϣ�Լ���ת������ҳ��

        public override void InitParentPageInfo()
        {
            switch (qsParentPage)
            {
                case "wfmPrjTab_QUDI3.aspx":


                    break;
                case "":
                    break;
                default:
                    clsCommonJsFunc.Alert(this, string.Format("��ҳ�����ƣ�[{0}]��({1})��û�д���", qsParentPage, clsStackTrace.GetCurrClassFunction()));
                    break;
            }

        }
        public override void ReturnParentPage()
        {
            string strCurrPageName = string.Format("{0}|{1}", conCurrPageName, vsParentPage);

            switch (qsParentPage)
            {
                case "wfmPrjTab_QUDI3.aspx":

                    clsPubFun4Web.JumpToPrjTab_QUDI3(this, strCurrPageName);
                    break;
                case "wfmEditTabAndObjectFields.aspx":

                    clsPubFun4Web.JumpToPrjTab_QUDI3(this, strCurrPageName);
                    
                    
                    //{
                    
                    //}
                    break;
                case "wfmTabCheckResultB_QUDI.aspx":

                            clsPubFun4Web.JumpToTabCheckResultB_QUDI(this, strCurrPageName);
                    break;
                case "":
                    break;
                default:
                    clsCommonJsFunc.Alert(this, string.Format("��ҳ�����ƣ�[{0}]��({1})��û�д���", qsParentPage, clsStackTrace.GetCurrClassFunction()));
                    break;
            }

        }
        /// <summary>
        /// ��ת������ҳ��
        /// </summary>
        /// <param name="strPageName"></param>
        public override void JumpOtherPages(string strPageName)
        {
            switch (strPageName)
            {
                case "":
                    break;
                default:
                    clsCommonJsFunc.Alert(this, string.Format("��ҳ�����ƣ�[{0}]��({1})��û�д���", qsParentPage, clsStackTrace.GetCurrClassFunction()));
                    break;
            }
        }
        #endregion ����ҳ����Ϣ

        /// <summary>
        /// ����:��ǰҳ������
        /// </summary>
        public override string conCurrPageName
        {
            get
            {
                return "wfmPrjTab_CheckConsistency.aspx";
            }
        }
    }
}