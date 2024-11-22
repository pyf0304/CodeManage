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
using com.taishsoft.common;

using System.Collections.Generic;
using com.taishsoft.datetime;

using AGC.Entity;
using CommonTable.Entity;
using AGC.BusinessLogic;using AGC.FunClass;
using CommonTable.BusinessLogic;


namespace AGC
{
	/// <summary>
	/// wfmPrjRequirement_QUDI ��ժҪ˵��������Q�����ѯ��U�����޸�
	/// </summary>
	public partial class wfmPrjRequirement_QUDI : CommWebPageBase
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
                wucPrjRequirement1.TabHidden();
				wucPrjRequirement1.SetDdl_PrjId();
				wucPrjRequirement1.SetDdl_UpReqId();
				wucPrjRequirement1.SetDdl_ReqTypeId();
				wucPrjRequirement1.SetDdl_FuncModuleId();
				BindDdl_UpReqId(ddlUpReqId_q);
				BindDdl_ReqTypeId(ddlReqTypeId_q);
				BindDdl_FuncModuleId(ddlFuncModuleId_q);

				

				strSortPrjRequirementBy = "ReqId Asc";
				//2����ʾ�������ı�������DATAGRID��
				BindDg_PrjRequirement();
				//3�����ñ�ؼ����ֿؼ���ReadOnly���ԣ�
				//   ʹֻ֮������Ϊ���޸Ĺ����йؼ����ǲ��ܱ��޸ĵġ�
				wucPrjRequirement1.SetKeyReadOnly(true);
				tabEditPrjRequirementRegion.Visible=false;
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
					//					sPotenceLevel=new General_Platform_Dll.MenuAndPotence().Get_PotenceLevel(ViewId4Potence);
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


		


		//���ɴ�����Ϣ��Session����
		private string ErrMessage
		{
			get
			{
				string strErrMessage;
				strErrMessage = (string)Session["ErrMessage"];
				if (strErrMessage==null) 
				{
					strErrMessage = "";
				}
				return strErrMessage;
			}
			set
			{
				string strErrMessage = value;
				Session.Add("ErrMessage", strErrMessage);
			}
		}


		//���ɷ������Ӵ���Session����
		private string BackErrPageLinkStr
		{
			get
			{
				string strBackErrPageLinkStr;
				strBackErrPageLinkStr = (string)Session["BackErrPageLinkStr"];
				if (strBackErrPageLinkStr==null) 
				{
					strBackErrPageLinkStr = "";
				}
				return strBackErrPageLinkStr;
			}
			set
			{
				string strBackErrPageLinkStr = value;
				Session.Add("BackErrPageLinkStr", strBackErrPageLinkStr);
			}
		}

		
		/// <summary>
		/// �����еĲ�ѯ�ؼ�������ϳ�һ��������
		/// </summary>
		/// <returns>������(strWhereCond)</returns>
		private string CombinePrjRequirementCondition()
		{
			//ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
			//���� 1=1 && UserName = '����'
            string strWhereCond = " 1=1 and PrjId = '" + clsPubVar.CurrSelPrjId + "'";
			//����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
			if (this.txtReqId_q.Text.Trim()!="")
			{
				strWhereCond += " And ReqId like '%" + this.txtReqId_q.Text.Trim()+"%'";
			}
			if (this.txtRequirement_q.Text.Trim()!="")
			{
				strWhereCond += " And Requirement like '%" + this.txtRequirement_q.Text.Trim()+"%'";
			}
			
			if (this.ddlUpReqId_q.SelectedValue!="" && this.ddlUpReqId_q.SelectedValue!="0")
			{
				strWhereCond += " And UpReqId='" + this.ddlUpReqId_q.SelectedValue+"'";
			}
			if (this.ddlReqTypeId_q.SelectedValue!="" && this.ddlReqTypeId_q.SelectedValue!="0")
			{
				strWhereCond += " And ReqTypeId='" + this.ddlReqTypeId_q.SelectedValue+"'";
			}
			if (this.ddlFuncModuleId_q.SelectedValue!="" && this.ddlFuncModuleId_q.SelectedValue!="0")
			{
				strWhereCond += " And FuncModuleAgcId='" + this.ddlFuncModuleId_q.SelectedValue+"'";
			}
			if (this.txtIsFinished_q.Text.Trim()!="")
			{
				strWhereCond += " And IsFinished like '%" + this.txtIsFinished_q.Text.Trim()+"%'";
			}
			return strWhereCond;
		}
		///���ɰ�DATAGRID�Ĵ���
		/// <summary>
		/// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
		///			 ����ʾ��DATAGRID�С�
		/// </summary>
		private void BindDg_PrjRequirement()
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
			string strWhereCond = CombinePrjRequirementCondition();
			//	2��������������ȡ�ñ�����������DataTable��
			System.Data.DataTable objDT = clsPrjRequirementBL.GetDataTable_PrjRequirementV(strWhereCond);
			//	3�����DATAGRID�ĵ�ǰҳ���Ƿ񳬳�DATAGRID��ҳ����Χ
			//		3.1 ���ȼ���ҳ����
			//		3.2 �����ǰҳ����ҳ����Ϊ���һҳ
			int intPages = CalcPages(objDT.Rows.Count, this.dgPrjRequirement.PageSize);
			if (intPages==0) 
			{
				this.dgPrjRequirement.CurrentPageIndex = 0;
			}
			else if (this.dgPrjRequirement.CurrentPageIndex > intPages - 1) 
			{
				this.dgPrjRequirement.CurrentPageIndex = intPages - 1;
			}
			//	4������DATAGRID������Դ(DataSource)��
			DataView objDV = objDT.DefaultView;
			objDV.Sort = strSortPrjRequirementBy;     ///ע����һ�д����п�����Ҫע�͵���Ŀǰ���н����ڵ����Ĳ�ѯ������������
			this.dgPrjRequirement.DataSource=objDV;
			//	5����DATAGRID������DataTable��������ʾ��DATAGRID��
			this.dgPrjRequirement.DataBind();

			
			//��ǰ��¼��
			this.lblPrjRequirementRecCount.Text = objDT.Rows.Count.ToString(); 
			//��ǰҳ��
			this.lblPrjRequirementAllPages.Text = this.dgPrjRequirement.PageCount.ToString(); 
			//��ǰҳ����
			this.lblPrjRequirementCurrentPage.Text=(this.dgPrjRequirement.CurrentPageIndex+1).ToString();
			//��ǰ����������ҳ����
			this.txtPrjRequirementJump2Page.Text=(this.dgPrjRequirement.CurrentPageIndex+1).ToString();
			//�����ǰҳ����Ϊ0����<ǰһҳ>��ť��Ч
			if(this.dgPrjRequirement.CurrentPageIndex==0) 
			{
				btnPrjRequirementPrevPage.Enabled=false; 
			}
			else 
			{ 
				btnPrjRequirementPrevPage.Enabled=true; 
			} 
			//�����ǰҳ������Ϊ���һҳ����<ǰһҳ>��ť��Ч
			if(this.dgPrjRequirement.CurrentPageIndex==this.dgPrjRequirement.PageCount-1) 
			{ 
				btnPrjRequirementNextPage.Enabled=false; 
			} 
			else 
			{ 
				btnPrjRequirementNextPage.Enabled=true; 
			} 
			//7�������沿����ʾ����ʾ �������ǰDataGrid�еļ�¼��Ϊ0������ʾ��ǰ����ҳ������
			if(objDT.Rows.Count>0) 
			{ 
				this.tabPrjRequirementJumpPage.Visible = true; 
			} 
			else 
			{ 
				this.tabPrjRequirementJumpPage.Visible = false; 
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
			this.dgPrjRequirement.CurrentPageIndex=0;
			//�ѱ��¼��������ʾ��DATAGRID��
			BindDg_PrjRequirement();
		}
		/// <summary>
		/// �������ܣ��¼��������ڸ���DATAGRID�ĵ�ǰҳ����ʱ�����ĺ�����
		///			  ���幦����������ʾ��ҳ(������ҳ����)�����ݡ�
		/// </summary>
		/// <param name="source"></param>
		/// <param name="e"></param>
		protected void dgPrjRequirement_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			//�������裺����2����
			//1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
			//2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ

			//1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
			this.dgPrjRequirement.CurrentPageIndex=e.NewPageIndex;
			//2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ
			BindDg_PrjRequirement();
		}
		/// <summary>
		/// �������ܣ����Ըùؼ��ֵļ�¼������ʾ�ڽ����ϣ�
		///������     �������ǰ�ֵ������ؼ���
		/// </summary>
		/// <param name="strReqId">���¼�Ĺؼ��֣���ʾ�ñ�ؼ��ֵ�����</param>
		private void ShowData(string strReqId)
		{
			//�������裺
			//1�����ؼ����Ƿ�Ϊ�գ�
			//2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
			//3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
			//4����ȡ�������������ԣ�
			//5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���

			//1�����ؼ����Ƿ�Ϊ�գ�
			if (strReqId == "") return ;		//����ؼ���Ϊ�վͷ����˳�
			//2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
			if (clsPrjRequirementBL.IsExist(strReqId) == false)		//���ùؼ��ֵļ�¼�Ƿ����
			{
				string ss = "�ؼ���Ϊ��" + strReqId + "�Ĳ�����!";
				clsCommonJsFunc.Alert(this, ss);
				return ;
			}
			//3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
			clsPrjRequirementEN objPrjRequirement = new clsPrjRequirementEN(strReqId);
            //4����ȡ�������������ԣ�
            clsPrjRequirementBL .GetPrjRequirement(ref objPrjRequirement);
			Session.Add("objPrjRequirement", objPrjRequirement);
			//5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���
			GetDataFromPrjRequirementClass(objPrjRequirement);
		}
		///���ɴ��߼�������ݴ��䵽�����ĺ�������
		/// <summary>
		/// �������ܣ�������������������ʾ��������
		///ע�⣺��������������򣬲�����һ��������������ϵ�ģ�����Ϊһ��������ֵ��Ȼ����Ϊ����������ֵ
		///      ������������ݿ�ʱ����Ӧ��һ���ֶ���ǰ�������ֶ��ں�
		/// </summary>
		/// <param name="pobjPrjRequirement">��ʵ�������</param>
		private void GetDataFromPrjRequirementClass(clsPrjRequirementEN pobjPrjRequirement)
		{
			wucPrjRequirement1.ReqId = pobjPrjRequirement.ReqId;
			wucPrjRequirement1.Requirement = pobjPrjRequirement.Requirement;
			wucPrjRequirement1.PrjId = pobjPrjRequirement.PrjId;
			wucPrjRequirement1.UpReqId = pobjPrjRequirement.UpReqId;
			wucPrjRequirement1.ReqTypeId = pobjPrjRequirement.ReqTypeId;
			wucPrjRequirement1.FuncModuleAgcId = pobjPrjRequirement.FuncModuleAgcId;
			wucPrjRequirement1.IsFinished = pobjPrjRequirement.IsFinished;
			wucPrjRequirement1.ReqContent = pobjPrjRequirement.ReqContent;
			wucPrjRequirement1.Memo = pobjPrjRequirement.Memo;
		}
		/// <summary>
		/// �������ܣ��¼�������������<ȷ���޸�>ʱ�������¼�������
		///           ���幦��Ϊ�ѽ�������ͬ�����ݿ��У��ѽ������ݱ��浽���ݿ���
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected void btnOKUpd_Click(object sender, System.EventArgs e)
		{
			string strCommandText;
			clsPrjRequirementEN objPrjRequirement;
			Button btnTemp;
			btnTemp = (Button) sender;
			strCommandText = btnTemp.Text;
			switch(strCommandText)
			{
				case "���":
					AddPrjRequirementRecord();
					break;				
				case "ȷ�����":
					//����һ������Ĳ���Ĵ��룬�����߼���̫�򵥣�
					//�Ͱ��߼���ϲ������Ʋ�,
					AddPrjRequirementRecordSave();
					break;
				case "ȷ���޸�":
					//����һ��������޸ĵĴ��룬�����߼���̫�򵥣�
					//�Ͱ��߼���ϲ������Ʋ�,
					objPrjRequirement = (clsPrjRequirementEN) Session["objPrjRequirement"];
					UpdatePrjRequirementRecordSave(objPrjRequirement);
					break;
			}
		}
		
		/// <summary>
		/// �������ܣ��ѽ����ϵ��������ݴ����������
		/// </summary>
		/// <param name="pobjPrjRequirement">���ݴ����Ŀ�������</param>
		private void PutDataToPrjRequirementClass(clsPrjRequirementEN pobjPrjRequirement)
		{
			pobjPrjRequirement.ReqId = wucPrjRequirement1.ReqId;
			pobjPrjRequirement.Requirement = wucPrjRequirement1.Requirement;
			pobjPrjRequirement.PrjId = wucPrjRequirement1.PrjId;
			pobjPrjRequirement.UpReqId = wucPrjRequirement1.UpReqId;
			pobjPrjRequirement.ReqTypeId = wucPrjRequirement1.ReqTypeId;
			pobjPrjRequirement.FuncModuleAgcId = wucPrjRequirement1.FuncModuleAgcId;
			pobjPrjRequirement.IsFinished = wucPrjRequirement1.IsFinished;
			pobjPrjRequirement.ReqContent = wucPrjRequirement1.ReqContent;
			pobjPrjRequirement.Memo = wucPrjRequirement1.Memo;
            pobjPrjRequirement.UserId= UserId;
			pobjPrjRequirement.UpdDate= clsDateTime.getTodayStr(0);
		}

		protected void dgPrjRequirement_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
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
			if (strSortPrjRequirementBy == "") return ;
			if(e.Item.ItemType==ListItemType.Header)//����ؼ��Ƿ�Ϊҳü��
			{
				string strSortEx;
				for(int i=0;i<this.dgPrjRequirement.Columns.Count;i++)
				{
					strSortEx = this.dgPrjRequirement.Columns[i].SortExpression;
					if (strSortEx == "") continue;
					intIndex = strSortPrjRequirementBy.IndexOf(strSortEx + " ");
					if(intIndex >=0)  //��ͼ״̬��������ʽ�Ƿ�Ϊ���е��ֶΣ�
					{
						Label lblSort=new Label();
						lblSort.Font.Name="webdings";//�������壬��"webdings"��5�������ǣ�6�������ǣ�
						intIndex = strSortPrjRequirementBy.IndexOf("Asc");
						lblSort.Text=(intIndex>0?" 5":" 6");//�Ƿ�Ϊ���򣬶���Ϊstring�ͣ�
						e.Item.Cells[i].Controls.Add(lblSort);//��������ĵ�i����Ԫ��������һ�ؼ���
						break;
					}
				}
			}
		}

		protected void dgPrjRequirement_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			string strReqId;
			string strCommandName;
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.SelectedItem ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
				strCommandName = ((LinkButton)e.CommandSource).CommandName;
				strReqId = e.Item.Cells[1].Text;
				switch(strCommandName)
				{
					case "Delete":
						DeletePrjRequirementRecord(strReqId);
						break;
						// Add other cases here, if there are multiple ButtonColumns in 
						// the DataGrid control.
					case "Update":
						UpdatePrjRequirementRecord(strReqId);
						break;

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
					Set_DataGridAllChecked(dgPrjRequirement, true);
					lbSelAll.Text = "��ѡ";
				}
				else if (lbSelAll.Text == "��ѡ")
				{
					Set_DataGridAllChecked(dgPrjRequirement, false);
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
	
		
		//��ǰ��¼��
		protected void btnAddNewRec4Dg_Click(object sender, System.EventArgs e)
		{
			tabEditPrjRequirementRegion.Visible=true;
			AddPrjRequirementRecord();
		}


		
		//��ǰ��¼��
		protected void btnDelete4Dg_Click(object sender, System.EventArgs e)
		{
            List<string> arrReqId = clsCommForWebForm.GetAllCheckedItemFromDg2(dgPrjRequirement, "chkCheckRec");
			if (arrReqId == null || arrReqId.Count == 0) 
			{
				lblMsg.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
				return ;
			}
			lblMsg.Text = "";
			clsPrjRequirementBL.DelPrjRequirements(arrReqId);
			BindDg_PrjRequirement();
		}

		
		//��ǰ��¼��
		protected void btnUpdate4Dg_Click(object sender, System.EventArgs e)
		{
			string strReqId =clsCommForWebForm.GetFirstCheckedItemFromDg(dgPrjRequirement);
			if (strReqId == null || strReqId.Trim().Length == 0) 
			{
				lblMsg.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
				return ;
			}
			lblMsg.Text = "";
			//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
			//��ǰ��ѡ��¼
			UpdatePrjRequirementRecord(strReqId);
		}
	
		public System.Data.DataTable GetUpReqId()
		{
			//��ȡĳѧԺ����רҵ��Ϣ
			string strSQL = "select ReqId, Requirement from PrjRequirement ";
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}
		public void BindDdl_UpReqId(System.Web.UI.WebControls.DropDownList objDDL)
		{
			//Ϊ����Դ�ڱ����������������
			ListItem li=new ListItem("��ѡ��...","0");
			System.Data.DataTable objDT = GetUpReqId();
			objDDL.DataValueField="ReqId";
			objDDL.DataTextField="Requirement";
			objDDL.DataSource = objDT;
			objDDL.DataBind();
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
		}
		public System.Data.DataTable GetReqTypeId()
		{
			//��ȡĳѧԺ����רҵ��Ϣ
            string strSQL = "select RequirementTypeId, RequirementTypeName from RequirementType ";
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}
		public void BindDdl_ReqTypeId(System.Web.UI.WebControls.DropDownList objDDL)
		{
			//Ϊ����Դ�ڱ����������������
			ListItem li=new ListItem("��ѡ��...","0");
			System.Data.DataTable objDT = GetReqTypeId();
			objDDL.DataValueField="RequirementTypeId";
            objDDL.DataTextField = "RequirementTypeName";
			objDDL.DataSource = objDT;
			objDDL.DataBind();
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
		}
		public System.Data.DataTable GetFuncModuleId()
		{
			//��ȡĳѧԺ����רҵ��Ϣ
			string strSQL = "select FuncModuleAgcId, FuncModuleName from FuncModule_Agc ";
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}
		public void BindDdl_FuncModuleId(System.Web.UI.WebControls.DropDownList objDDL)
		{
			//Ϊ����Դ�ڱ����������������
			ListItem li=new ListItem("��ѡ��...","0");
			System.Data.DataTable objDT = GetFuncModuleId();
			objDDL.DataValueField="FuncModuleAgcId";
			objDDL.DataTextField="FuncModuleName";
			objDDL.DataSource = objDT;
			objDDL.DataBind();
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
		}
		
		protected void dgPrjRequirement_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
		{
			int intIndex;
			//�ж��Ƿ����µ������ֶ�
			intIndex = strSortPrjRequirementBy.IndexOf(e.SortExpression);
			if (intIndex == -1)
			{
				strSortPrjRequirementBy = e.SortExpression + " Asc";
				BindDg_PrjRequirement();
				return ;
			}
			//���ԭ��������
			intIndex = strSortPrjRequirementBy.IndexOf(" Asc");
			if (intIndex == -1)		//���ԭ���������������Ϊ����
			{
				strSortPrjRequirementBy = e.SortExpression + " Asc";
			}
			else			///��������Ϊ����
			{
				strSortPrjRequirementBy = e.SortExpression + " Desc";
			}
			BindDg_PrjRequirement();
		}

		private string strSortPrjRequirementBy
		{
			get
			{
				string sSortPrjRequirementBy;
				sSortPrjRequirementBy = (string)ViewState["SortPrjRequirementBy"];
				if (sSortPrjRequirementBy==null) 
				{
					sSortPrjRequirementBy = "";
				}
				return sSortPrjRequirementBy;
			}
			set
			{
				string sSortPrjRequirementBy = value;
				ViewState.Add("SortPrjRequirementBy", sSortPrjRequirementBy);
			}
		}

		//���ɸ������SESSION������Ժ���
		protected void btnPrjRequirementPrevPage_Click(object sender, System.EventArgs e)
		{
			this.dgPrjRequirement.CurrentPageIndex -=1; 
			this.BindDg_PrjRequirement(); 
		}

		protected void btnPrjRequirementNextPage_Click(object sender, System.EventArgs e)
		{
			this.dgPrjRequirement.CurrentPageIndex +=1; 
			this.BindDg_PrjRequirement(); 
		}

		protected void btnPrjRequirementJumpPage_Click(object sender, System.EventArgs e)
		{
			if(this.txtPrjRequirementJump2Page.Text.Trim()!="" && 
				int.Parse(this.txtPrjRequirementJump2Page.Text)>0 && 
				int.Parse(this.txtPrjRequirementJump2Page.Text)-1<this.dgPrjRequirement.PageCount) 
			{ 
				this.dgPrjRequirement.CurrentPageIndex=int.Parse(this.txtPrjRequirementJump2Page.Text)-1; 
			} 
			this.BindDg_PrjRequirement();
		}

		///���ɵĲ����¼׼�����̴���for C#
		private void AddPrjRequirementRecord()
		{
			wucPrjRequirement1.SetKeyReadOnly(false);
			btnOKUpd.Text = "ȷ�����";
			wucPrjRequirement1.SetDefaultValue();
            wucPrjRequirement1.ReqId = clsPrjRequirementBL.GetMaxStrIdByPrefix_S(clsPubVar.CurrSelPrjId);
			wucPrjRequirement1.UserId = UserId;
            wucPrjRequirement1.PrjId = clsPubVar.CurrSelPrjId;
			DispEditPrjRequirementRegion();
		}
		///�����¼���̹��̴���for C#
		private void AddPrjRequirementRecordSave()
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
			clsPrjRequirementEN objPrjRequirement;
			//1�����ؼ����������������Ƿ���ȷ
			if (!wucPrjRequirement1.IsValid(ref strResult))
			{
				lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
				return ;
			}
			//2��������󲢳�ʼ������
			//clsPrjRequirementEN objPrjRequirement;	//�������
			objPrjRequirement = new clsPrjRequirementEN();	//��ʼ���¶���
			//3���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
			//if (clsPrjRequirementBL.IsExist())	//�ж��Ƿ�����ͬ�Ĺؼ���
			//{
			//	strMsg = "�ؼ����ֶ�������ͬ��ֵ";
			//	clsCommonJsFunc.Alert(this, strMsg);
			//	return;
			//}
			//4����ֵ�ӽ���㴫���߼��������ʵ���
			PutDataToPrjRequirementClass(objPrjRequirement);		//�ѽ����ֵ����
			//5����鴫��ȥ�Ķ��������Ƿ�Ϸ�
			try
			{
                clsPrjRequirementBL .CheckPropertyNew(objPrjRequirement);
                //6��������ʵ�������ݴ��������ݿ���
                clsPrjRequirementBL .AddNewRecordBySql2(objPrjRequirement);
			}
			catch(Exception objException)
			{
				strMsg = "��Ӽ�¼���ɹ�!" + objException.Message;
				clsCommonJsFunc.Alert(this, strMsg);
				lblMsg.Text = strMsg;
				return;
			}
			strMsg = "��Ӽ�¼�ɹ�!";
			clsCommonJsFunc.Alert(this, strMsg);
			lblMsg.Text = "��Ӽ�¼�ɹ�!";
			//7��������ļ�¼������ʾ��DATAGRID��
			BindDg_PrjRequirement();
			wucPrjRequirement1.Clear();		//��տؼ�������
			///�ָ�<ȷ�����>���<���>
			btnOKUpd.Text = "���";
			DispPrjRequirementListRegion();
		}
		///�����¼���̹��̴���for C#
		private void AddPrjRequirementRecordSaveV5()
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
			clsPrjRequirementEN objPrjRequirement;
			//1�����ؼ����������������Ƿ���ȷ
			if (!wucPrjRequirement1.IsValid(ref strResult))
			{
				lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
				return ;
			}
			//2��������󲢳�ʼ������
			//clsPrjRequirementEN objPrjRequirement;	//�������
			objPrjRequirement = new clsPrjRequirementEN();	//��ʼ���¶���
			//3���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
			//if (clsPrjRequirementBL.IsExist())	//�ж��Ƿ�����ͬ�Ĺؼ���
			//{
			//	strMsg = "�ؼ����ֶ�������ͬ��ֵ";
			//	clsCommonJsFunc.Alert(this, strMsg);
			//	return;
			//}
			//4����ֵ�ӽ���㴫���߼��������ʵ���
			PutDataToPrjRequirementClass(objPrjRequirement);		//�ѽ����ֵ����
			//5����鴫��ȥ�Ķ��������Ƿ�Ϸ�
			try
			{
				clsPrjRequirementBL .CheckPropertyNew(objPrjRequirement);
                //6��������ʵ�������ݴ��������ݿ���
                clsPrjRequirementBL.AddNewRecordBySql2(objPrjRequirement);
            }
			catch(Exception objException)
			{
				clsCommonSession.seErrMessage = "��Ӽ�¼���ɹ�!" + objException.Message;
				clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
				clsPubFun4Web.AccessError(this, conCurrPageName);
			}
			strMsg = "��Ӽ�¼�ɹ�!";
			clsCommonJsFunc.Alert(this, strMsg);
			lblMsg.Text = "��Ӽ�¼�ɹ�!";
			//7��������ļ�¼������ʾ��DATAGRID��
			BindDg_PrjRequirement();
			wucPrjRequirement1.Clear();		//��տؼ�������
			///�ָ�<ȷ�����>���<���>
			btnOKUpd.Text = "���";
			DispPrjRequirementListRegion();
		}
		///�����޸ļ�¼׼�����̴��� for C#
		private void UpdatePrjRequirementRecord(string strReqId)
		{
			//�������裺���ܹ�2����
			//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
			//2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�

			//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
			ShowData(strReqId);
			//2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
			clsPubFun.SetButtonEnabled(btnOKUpd, true);
			wucPrjRequirement1.SetKeyReadOnly(true);
			btnOKUpd.Text = "ȷ���޸�";
			lblMsg.Text = "";
			DispEditPrjRequirementRegion();
		}
		///�޸Ĵ���׼�����̴��� for C#
		private void UpdatePrjRequirementRecordSave(clsPrjRequirementEN objPrjRequirement)
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
			if (!wucPrjRequirement1.IsValid(ref strResult))
			{
				lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
				return ;
			}
			//2����ֵ�ӽ���㴫���߼��������ʵ���
			PutDataToPrjRequirementClass(objPrjRequirement);		//�ѽ����ֵ����
			//3����鴫��ȥ�Ķ��������Ƿ�Ϸ�
			try
			{
				clsPrjRequirementBL .CheckPropertyNew(objPrjRequirement);
                //6��������ʵ�������ݴ��������ݿ���
                clsPrjRequirementBL .UpdateBySql2(objPrjRequirement);
			}
			catch(Exception objException)
			{
				strMsg = "�޸ļ�¼���ɹ�!" + objException.Message;
				clsCommonJsFunc.Alert(this, strMsg);
				lblMsg.Text = strMsg;
				return ; 
			}
			strMsg = "�޸ļ�¼�ɹ�!";
			clsCommonJsFunc.Alert(this, strMsg);
			lblMsg.Text = "�޸ļ�¼�ɹ�!";
			//5�����޸ĺ��������ʾ��DATAGRID��
			BindDg_PrjRequirement();
			wucPrjRequirement1.Clear();//��տؼ��е�����
			//�ָ�<ȷ���޸�>���<���>
			btnOKUpd.Text = "���";
			DispPrjRequirementListRegion();
		}
		///�޸Ĵ���׼�����̴��� for C#
		private void UpdatePrjRequirementRecordSaveV5(clsPrjRequirementEN objPrjRequirement)
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
			if (!wucPrjRequirement1.IsValid(ref strResult))
			{
				lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
				return ;
			}
			//2����ֵ�ӽ���㴫���߼��������ʵ���
			PutDataToPrjRequirementClass(objPrjRequirement);		//�ѽ����ֵ����
			//3����鴫��ȥ�Ķ��������Ƿ�Ϸ�
			try
			{
				clsPrjRequirementBL .CheckPropertyNew(objPrjRequirement);
                //6��������ʵ�������ݴ��������ݿ���
                clsPrjRequirementBL.UpdateBySql2(objPrjRequirement);
            }
			catch(Exception objException)
			{
				clsCommonSession.seErrMessage = "�޸ļ�¼���ɹ�!" + objException.Message;
				clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
				clsPubFun4Web.AccessError(this, conCurrPageName);
			}
			strMsg = "�޸ļ�¼�ɹ�!";
			clsCommonJsFunc.Alert(this, strMsg);
			lblMsg.Text = "�޸ļ�¼�ɹ�!";
			//5�����޸ĺ��������ʾ��DATAGRID��
			BindDg_PrjRequirement();
			wucPrjRequirement1.Clear();//��տؼ��е�����
			//�ָ�<ȷ���޸�>���<���>
			btnOKUpd.Text = "���";
			DispPrjRequirementListRegion();
		}
		///ɾ����¼���̴���for C#
		private void DeletePrjRequirementRecord(string strReqId)
		{
			clsPrjRequirementBL.DelRecord(strReqId);
			BindDg_PrjRequirement();
		}
		private void DispEditPrjRequirementRegion()
		{
			tabPrjRequirementDataGrid.Visible = false;
			tabEditPrjRequirementRegion.Visible = true;
		}
		private void DispPrjRequirementListRegion()
		{
			tabPrjRequirementDataGrid.Visible = true;
			tabEditPrjRequirementRegion.Visible = false;
		}
		
		//��ǰ��¼��
		protected void lbDispPrjRequirementList_Click(object sender, System.EventArgs e)
		{
			DispPrjRequirementListRegion();
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