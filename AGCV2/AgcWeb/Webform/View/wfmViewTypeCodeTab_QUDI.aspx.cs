using AGC.BusinessLogic;using AGC.FunClass;
using AGC.BusinessLogicEx;
using AGC.Entity;
using com.taishsoft.common;
using CommFunc4WebForm;
///���ɲ�ѯ���޸ģ�ɾ������Ӽ�¼�Ŀ��Ʋ����


using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace AGC.Webform
{
    /// <summary>
    /// wfmViewTypeCodeTab_QUDI ��ժҪ˵��������Q�����ѯ��U�����޸�
    /// </summary>
    public partial class wfmViewTypeCodeTab_QUDI : CommWebPageBase
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
				wucViewTypeCodeTab1.SetDdl_ApplicationTypeId();
                
                clsViewInfoBLEx.BindDdl_ApplicationTypeIdExCache(ddlApplicationTypeIdq, clsPubVar.CurrSelPrjId);
                clsCommForWebForm.BindDdl_TrueAndFalse(ddlIsWebq);
                clsCommForWebForm.BindDdl_TrueAndFalse(ddlIsWinq);
                clsCommForWebForm.BindDdl_TrueAndFalse(ddlIsMobileAppq);
                strSortViewTypeCodeTabBy = "ViewTypeCode Asc";
				//2����ʾ�������ı�������DATAGRID��
				BindDg_ViewTypeCodeTab();
				//3�����ñ�ؼ����ֿؼ���ReadOnly���ԣ�
				//   ʹֻ֮������Ϊ���޸Ĺ����йؼ����ǲ��ܱ��޸ĵġ�
				wucViewTypeCodeTab1.SetKeyReadOnly(true);
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
		private string CombineViewTypeCodeTabCondition()
		{
			//ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
			//���� 1=1 && UserName = '����'
			string strWhereCond= string.Format(" 1=1 and {0} in (Select {0} From {1} where {2}='1')", 
                conApplicationType.ApplicationTypeId, conApplicationType._CurrTabName, conApplicationType.IsVisible);
			//����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
			if (this.txtViewTypeCodeq.Text.Trim()!="")
			{
				strWhereCond += " And ViewTypeCode like '%" + this.txtViewTypeCodeq.Text.Trim()+"%'";
			}
			if (this.txtViewTypeNameq.Text.Trim()!="")
			{
				strWhereCond += " And ViewTypeName like '%" + this.txtViewTypeNameq.Text.Trim()+"%'";
			}
			if (this.ddlApplicationTypeIdq.SelectedValue!="" && this.ddlApplicationTypeIdq.SelectedValue!="0")
			{
				strWhereCond += " And ApplicationTypeId='" + this.ddlApplicationTypeIdq.SelectedValue+"'";
			}
            if (this.ddlIsWebq.SelectedIndex == 1)
            {
                strWhereCond += string.Format(" And {0} = '1'", conViewTypeCodeTab.IsWebApp);
            }
            else if (this.ddlIsWebq.SelectedIndex == 2)
            {
                strWhereCond += string.Format(" And {0} = '0'", conViewTypeCodeTab.IsWebApp);
            }
            if (this.ddlIsWinq.SelectedIndex == 1)
            {
                strWhereCond += string.Format(" And {0} = '1'", conViewTypeCodeTab.IsWinApp);
            }
            else if (this.ddlIsWinq.SelectedIndex == 2)
            {
                strWhereCond += string.Format(" And {0} = '0'", conViewTypeCodeTab.IsWinApp);
            }
            if (this.ddlIsMobileAppq.SelectedIndex == 1)
            {
                strWhereCond += string.Format(" And {0} = '1'", conViewTypeCodeTab.IsMobileApp);
            }
            else if (this.ddlIsMobileAppq.SelectedIndex == 2)
            {
                strWhereCond += string.Format(" And {0} = '0'", conViewTypeCodeTab.IsMobileApp);
            }

            return strWhereCond;
		}
		///���ɰ�DATAGRID�Ĵ���
		/// <summary>
		/// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
		///			 ����ʾ��DATAGRID�С�
		/// </summary>
		private void BindDg_ViewTypeCodeTab()
		{
            //�������裺(��5��)
            //	1����Ͻ�����������
            //	2��������������ȡ�ñ�����������DataTable��
            //	3���б�DATAGRID�ĵ�ǰҳ���Ƿ񳬳�DATAGRID��ҳ����Χ
            //	4������DATAGRID������Դ(DataSource)��
            //	5����DATAGRID������DataTable��������ʾ��DATAGRID��
            //	6�����ü�¼����״̬��
            //		�ڱ��������ǰ�״̬��ʾ�ڿؼ�txtRecCount�С�
            //clsCommForWebForm.SetGvVisibility(dgViewTypeCodeTab, strColumnName, bolIsVisible);
            //	1����Ͻ�����������
            string strWhereCond = CombineViewTypeCodeTabCondition();
			//	2��������������ȡ�ñ�����������DataTable��
			System.Data.DataTable objDT = clsvViewTypeCodeTabBL.GetDataTable(strWhereCond);
			//	3�����DATAGRID�ĵ�ǰҳ���Ƿ񳬳�DATAGRID��ҳ����Χ
			//		3.1 ���ȼ���ҳ����
			//		3.2 �����ǰҳ����ҳ����Ϊ���һҳ
			int intPages = CalcPages(objDT.Rows.Count, this.dgViewTypeCodeTab.PageSize);
			if (intPages==0) 
			{
				this.dgViewTypeCodeTab.CurrentPageIndex = 0;
			}
			else if (this.dgViewTypeCodeTab.CurrentPageIndex > intPages - 1) 
			{
				this.dgViewTypeCodeTab.CurrentPageIndex = intPages - 1;
			}
			//	4������DATAGRID������Դ(DataSource)��
			DataView objDV = objDT.DefaultView;
			objDV.Sort = strSortViewTypeCodeTabBy;     ///ע����һ�д����п�����Ҫע�͵���Ŀǰ���н����ڵ����Ĳ�ѯ������������
			this.dgViewTypeCodeTab.DataSource=objDV;
			//	5����DATAGRID������DataTable��������ʾ��DATAGRID��
			this.dgViewTypeCodeTab.DataBind();

			
			//��ǰ��¼��
			this.lblViewTypeCodeTabRecCount.Text = objDT.Rows.Count.ToString(); 
			//��ǰҳ��
			this.lblViewTypeCodeTabAllPages.Text = this.dgViewTypeCodeTab.PageCount.ToString(); 
			//��ǰҳ����
			this.lblViewTypeCodeTabCurrentPage.Text=(this.dgViewTypeCodeTab.CurrentPageIndex+1).ToString();
			//��ǰ����������ҳ����
			this.txtViewTypeCodeTabJump2Page.Text=(this.dgViewTypeCodeTab.CurrentPageIndex+1).ToString();
			//�����ǰҳ����Ϊ0����<ǰһҳ>��ť��Ч
			if(this.dgViewTypeCodeTab.CurrentPageIndex==0) 
			{
				btnViewTypeCodeTabPrevPage.Enabled=false; 
			}
			else 
			{ 
				btnViewTypeCodeTabPrevPage.Enabled=true; 
			} 
			//�����ǰҳ������Ϊ���һҳ����<ǰһҳ>��ť��Ч
			if(this.dgViewTypeCodeTab.CurrentPageIndex==this.dgViewTypeCodeTab.PageCount-1) 
			{ 
				btnViewTypeCodeTabNextPage.Enabled=false; 
			} 
			else 
			{ 
				btnViewTypeCodeTabNextPage.Enabled=true; 
			} 
			//7�������沿����ʾ����ʾ �������ǰDataGrid�еļ�¼��Ϊ0������ʾ��ǰ����ҳ������
			if(objDT.Rows.Count>0) 
			{ 
				this.tabViewTypeCodeTabJumpPage.Visible = true; 
			} 
			else 
			{ 
				this.tabViewTypeCodeTabJumpPage.Visible = false; 
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
			this.dgViewTypeCodeTab.CurrentPageIndex=0;
			//�ѱ��¼��������ʾ��DATAGRID��
			BindDg_ViewTypeCodeTab();
		}
		/// <summary>
		/// �������ܣ��¼��������ڸ���DATAGRID�ĵ�ǰҳ����ʱ�����ĺ�����
		///			  ���幦����������ʾ��ҳ(������ҳ����)�����ݡ�
		/// </summary>
		/// <param name="source"></param>
		/// <param name="e"></param>
		protected void dgViewTypeCodeTab_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			//�������裺����2����
			//1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
			//2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ

			//1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
			this.dgViewTypeCodeTab.CurrentPageIndex=e.NewPageIndex;
			//2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ
			BindDg_ViewTypeCodeTab();
		}
		/// <summary>
		/// �������ܣ����Ըùؼ��ֵļ�¼������ʾ�ڽ����ϣ�
		///������     �������ǰ�ֵ������ؼ���
		/// </summary>
		/// <param name="intViewTypeCode">���¼�Ĺؼ��֣���ʾ�ñ�ؼ��ֵ�����</param>
		private void ShowData(int intViewTypeCode)
		{
			//�������裺
			//1�����ؼ����Ƿ�Ϊ�գ�
			//2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
			//3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
			//4����ȡ�������������ԣ�
			//5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���

			//1�����ؼ����Ƿ�Ϊ�գ�
			if (intViewTypeCode == 0) return ;		//����ؼ���Ϊ�վͷ����˳�
			//2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
			if (clsViewTypeCodeTabBL.IsExist(intViewTypeCode) == false)		//���ùؼ��ֵļ�¼�Ƿ����
			{
				string ss = "�ؼ���Ϊ��" + intViewTypeCode + "�Ĳ�����!";
				clsCommonJsFunc.Alert(this, ss);
				return ;
			}
			//3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
			clsViewTypeCodeTabEN objViewTypeCodeTab = new clsViewTypeCodeTabEN(intViewTypeCode);
            //4����ȡ�������������ԣ�
            clsViewTypeCodeTabBL .GetViewTypeCodeTab(ref objViewTypeCodeTab);
			Session.Add("objViewTypeCodeTab", objViewTypeCodeTab);
			//5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���
			GetDataFromViewTypeCodeTabClass(objViewTypeCodeTab);
		}
		///���ɴ��߼�������ݴ��䵽�����ĺ�������
		/// <summary>
		/// �������ܣ�������������������ʾ��������
		///ע�⣺��������������򣬲�����һ��������������ϵ�ģ�����Ϊһ��������ֵ��Ȼ����Ϊ����������ֵ
		///      ������������ݿ�ʱ����Ӧ��һ���ֶ���ǰ�������ֶ��ں�
		/// </summary>
		/// <param name="pobjViewTypeCodeTab">��ʵ�������</param>
		private void GetDataFromViewTypeCodeTabClass(clsViewTypeCodeTabEN pobjViewTypeCodeTab)
		{
			wucViewTypeCodeTab1.ViewTypeCode = pobjViewTypeCodeTab.ViewTypeCode;
			wucViewTypeCodeTab1.ViewTypeName = pobjViewTypeCodeTab.ViewTypeName;
			wucViewTypeCodeTab1.ViewFunction = pobjViewTypeCodeTab.ViewFunction;
			wucViewTypeCodeTab1.OptProcess = pobjViewTypeCodeTab.OptProcess;
			wucViewTypeCodeTab1.ViewDetail = pobjViewTypeCodeTab.ViewDetail;
			wucViewTypeCodeTab1.ApplicationTypeId = pobjViewTypeCodeTab.ApplicationTypeId;
            wucViewTypeCodeTab1.IsHaveAdd = pobjViewTypeCodeTab.IsHaveAdd;
            wucViewTypeCodeTab1.IsHaveUpdate = pobjViewTypeCodeTab.IsHaveUpdate;
            wucViewTypeCodeTab1.IsHaveExeAdd = pobjViewTypeCodeTab.IsHaveExeAdd;
            wucViewTypeCodeTab1.IsHaveExeUpdate = pobjViewTypeCodeTab.IsHaveExeUpdate;
            wucViewTypeCodeTab1.IsHaveDel = pobjViewTypeCodeTab.IsHaveDel;
			wucViewTypeCodeTab1.IsHaveQuery = pobjViewTypeCodeTab.IsHaveQuery;
            wucViewTypeCodeTab1.IsHaveExcelExport = pobjViewTypeCodeTab.IsHaveExcelExport;
            wucViewTypeCodeTab1.IsHaveSetExportExcel = pobjViewTypeCodeTab.IsHaveSetExportExcel;

            wucViewTypeCodeTab1.IsHaveDetail = pobjViewTypeCodeTab.IsHaveDetail;
            wucViewTypeCodeTab1.IsHaveMainView = pobjViewTypeCodeTab.IsHaveMainView;
            wucViewTypeCodeTab1.IsHaveSubView = pobjViewTypeCodeTab.IsHaveSubView;
            wucViewTypeCodeTab1.IsWebApp = pobjViewTypeCodeTab.IsWebApp;// �Ƿ�WebӦ��
            wucViewTypeCodeTab1.IsWinApp = pobjViewTypeCodeTab.IsWinApp;// �Ƿ�WinӦ��
            wucViewTypeCodeTab1.IsMobileApp = pobjViewTypeCodeTab.IsMobileApp;// �Ƿ��ƶ��ն�Ӧ��

        }
        /// <summary>
        /// �������ܣ��¼�������������<ȷ���޸�>ʱ�������¼�������
        ///           ���幦��Ϊ�ѽ�������ͬ�����ݿ��У��ѽ������ݱ��浽���ݿ���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOKUpd_Click(object sender, System.EventArgs e)
		{
//			string strMsg;	//ר�����ڴ�����Ϣ�ı���
//			string strResult=" ";	//���ڴ����ڼ����������ʱ���ֵ�ı���
			string strCommandText;
			clsViewTypeCodeTabEN objViewTypeCodeTab;
			Button btnTemp;
			btnTemp = (Button) sender;
			strCommandText = btnTemp.Text;
			switch(strCommandText)
			{
				case "���":
					AddViewTypeCodeTabRecord();
					break;				
				case "ȷ�����":
					//����һ������Ĳ���Ĵ��룬�����߼���̫�򵥣�
					//�Ͱ��߼���ϲ������Ʋ�,
					AddViewTypeCodeTabRecordSave();
					break;
				case "ȷ���޸�":
					//����һ��������޸ĵĴ��룬�����߼���̫�򵥣�
					//�Ͱ��߼���ϲ������Ʋ�,
					objViewTypeCodeTab = (clsViewTypeCodeTabEN) Session["objViewTypeCodeTab"];
					UpdateViewTypeCodeTabRecordSave(objViewTypeCodeTab);
					break;
			}
		}
		
		/// <summary>
		/// �������ܣ��ѽ����ϵ��������ݴ����������
		/// </summary>
		/// <param name="pobjViewTypeCodeTab">���ݴ����Ŀ�������</param>
		private void PutDataToViewTypeCodeTabClass(clsViewTypeCodeTabEN pobjViewTypeCodeTab)
		{
			pobjViewTypeCodeTab.ViewTypeCode = wucViewTypeCodeTab1.ViewTypeCode;
			pobjViewTypeCodeTab.ViewTypeName = wucViewTypeCodeTab1.ViewTypeName;
			pobjViewTypeCodeTab.ViewFunction = wucViewTypeCodeTab1.ViewFunction;
			pobjViewTypeCodeTab.OptProcess = wucViewTypeCodeTab1.OptProcess;
			pobjViewTypeCodeTab.ViewDetail = wucViewTypeCodeTab1.ViewDetail;
			pobjViewTypeCodeTab.ApplicationTypeId = wucViewTypeCodeTab1.ApplicationTypeId;
            pobjViewTypeCodeTab.IsHaveAdd = wucViewTypeCodeTab1.IsHaveAdd;
            pobjViewTypeCodeTab.IsHaveUpdate = wucViewTypeCodeTab1.IsHaveUpdate;
            pobjViewTypeCodeTab.IsHaveExeAdd = wucViewTypeCodeTab1.IsHaveExeAdd;
            pobjViewTypeCodeTab.IsHaveExeUpdate = wucViewTypeCodeTab1.IsHaveExeUpdate;
            pobjViewTypeCodeTab.IsHaveDel = wucViewTypeCodeTab1.IsHaveDel;
			pobjViewTypeCodeTab.IsHaveQuery = wucViewTypeCodeTab1.IsHaveQuery;
            pobjViewTypeCodeTab.IsHaveExcelExport = wucViewTypeCodeTab1.IsHaveExcelExport;
            pobjViewTypeCodeTab.IsHaveSetExportExcel = wucViewTypeCodeTab1.IsHaveSetExportExcel;

			pobjViewTypeCodeTab.IsHaveDetail = wucViewTypeCodeTab1.IsHaveDetail;
            pobjViewTypeCodeTab.IsHaveMainView = wucViewTypeCodeTab1.IsHaveMainView;
            pobjViewTypeCodeTab.IsHaveSubView = wucViewTypeCodeTab1.IsHaveSubView;

            pobjViewTypeCodeTab.IsWebApp = wucViewTypeCodeTab1.IsWebApp;// �Ƿ�WebӦ��
            pobjViewTypeCodeTab.IsWinApp = wucViewTypeCodeTab1.IsWinApp;// �Ƿ�WinӦ��
            pobjViewTypeCodeTab.IsMobileApp = wucViewTypeCodeTab1.IsMobileApp;// �Ƿ��ƶ��ն�Ӧ��


        }

        protected void dgViewTypeCodeTab_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
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
			if (strSortViewTypeCodeTabBy == "") return ;
			if(e.Item.ItemType==ListItemType.Header)//����ؼ��Ƿ�Ϊҳü��
			{
				string strSortEx;
				for(int i=0;i<this.dgViewTypeCodeTab.Columns.Count;i++)
				{
					strSortEx = this.dgViewTypeCodeTab.Columns[i].SortExpression;
					if (strSortEx == "") continue;
					intIndex = strSortViewTypeCodeTabBy.IndexOf(strSortEx + " ");
					if(intIndex >=0)  //��ͼ״̬��������ʽ�Ƿ�Ϊ���е��ֶΣ�
					{
						Label lblSort=new Label();
						lblSort.Font.Name="webdings";//�������壬��"webdings"��5�������ǣ�6�������ǣ�
						intIndex = strSortViewTypeCodeTabBy.IndexOf("Asc");
						lblSort.Text=(intIndex>0?" 5":" 6");//�Ƿ�Ϊ���򣬶���Ϊstring�ͣ�
						e.Item.Cells[i].Controls.Add(lblSort);//��������ĵ�i����Ԫ��������һ�ؼ���
						break;
					}
				}
			}
		}

		protected void dgViewTypeCodeTab_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			int intViewTypeCode;
			string strCommandName;
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.SelectedItem ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
				strCommandName = ((LinkButton)e.CommandSource).CommandName;
				intViewTypeCode = int.Parse( e.Item.Cells[1].Text);
				switch(strCommandName)
				{
					case "Delete":
						DeleteViewTypeCodeTabRecord(intViewTypeCode);
						break;
						// Add other cases here, if there are multiple ButtonColumns in 
						// the DataGrid control.
					case "Update":
						UpdateViewTypeCodeTabRecord(intViewTypeCode);
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
					Set_DataGridAllChecked(dgViewTypeCodeTab, true);
					lbSelAll.Text = "��ѡ";
				}
				else if (lbSelAll.Text == "��ѡ")
				{
					Set_DataGridAllChecked(dgViewTypeCodeTab, false);
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
			AddViewTypeCodeTabRecord();
		}

		
		//��ǰ��¼��
		protected void btnExportExcel4Dg_Click(object sender, System.EventArgs e)
		{
			//	1����Ͻ�����������
			string strWhereCond = CombineViewTypeCodeTabCondition();
			//	2��������������ȡ�ñ�����������DataTable��
			System.Data.DataTable objDT = clsvViewTypeCodeTabBL.GetDataTable(strWhereCond);
			List<string> arrCnName = new List<string>();
			List<string> arrColName = new List<string>();
			string strFileName = "ViewTypeCodeTab��Ϣ����.xls";
			string strFolderName;
			string strDownLoadFileName;
			arrColName.Add("ViewTypeCode"); arrCnName.Add("����������");
			arrColName.Add("ViewFunction"); arrCnName.Add("���湦��");
			arrColName.Add("ViewDetail"); arrCnName.Add("����˵��");
			arrColName.Add("ViewTypeName"); arrCnName.Add("������������");
			arrColName.Add("OptProcess"); arrCnName.Add("��������");
			arrColName.Add("ApplicationTypeName"); arrCnName.Add("Ӧ�ó�����������");
			arrColName.Add("IsHaveAdd"); arrCnName.Add("�Ƿ������");
			arrColName.Add("IsHaveUpdate"); arrCnName.Add("�Ƿ����޸�");
			arrColName.Add("IsHaveDel"); arrCnName.Add("�Ƿ���ɾ��");
			arrColName.Add("IsHaveQuery"); arrCnName.Add("�Ƿ��в�ѯ");
			arrColName.Add("IsHaveDetail"); arrCnName.Add("�Ƿ�����ϸ");
			arrColName.Add("IsHaveExcelExport"); arrCnName.Add("�Ƿ�EXCEL����");
			strFolderName = Server.MapPath("~") +  "\\TempFiles\\";
			strDownLoadFileName = strFolderName + strFileName;
			GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4Odbc(objDT, arrColName, arrCnName, strDownLoadFileName);
			DownLoadFile(strDownLoadFileName);
		}
		/// <summary>
		/// ���ܣ������ļ����ӷ����������ļ����ͻ��������
		/// </summary>
		/// <param name="strDownLoadFileName">��Ҫ���ص��ļ��������ļ���Ϊ��Ŀ¼���ļ�ȫ��</param>
		/// <returns></returns>
		private bool DownLoadFile(string strDownLoadFileName)
		{
			System.IO.FileInfo file = new System.IO.FileInfo(strDownLoadFileName); 
			Response.Clear(); 
			Response.AddHeader("Content-Disposition", "attachment; filename=" + HttpUtility.UrlEncode(file.Name)); 
			Response.AddHeader("Content-Length", file.Length.ToString()); 
			Response.ContentType = "application/octet-stream"; 
			Response.WriteFile(file.FullName); 
			Response.End();
			return true;
		}

		
		//��ǰ��¼��
		protected void btnDelete4Dg_Click(object sender, System.EventArgs e)
		{
			List<string> arrViewTypeCode =clsCommForWebForm. GetAllCheckedItemFromDg2(dgViewTypeCodeTab, "chkCheckRec");
			if (arrViewTypeCode == null || arrViewTypeCode.Count == 0) 
			{
				lblMsg.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
				return ;
			}
			lblMsg.Text = "";
			clsViewTypeCodeTabBL.DelViewTypeCodeTabs(arrViewTypeCode);
			BindDg_ViewTypeCodeTab();
		}

		
		//��ǰ��¼��
		protected void btnUpdate4Dg_Click(object sender, System.EventArgs e)
		{
			string strViewTypeCode = clsCommForWebForm.GetFirstCheckedItemFromDg(dgViewTypeCodeTab);

            if (string.IsNullOrEmpty(strViewTypeCode) == true) 
			{
				lblMsg.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
				return ;
			}
            int intViewTypeCode = int.Parse(strViewTypeCode);
            lblMsg.Text = "";
			//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
			//��ǰ��ѡ��¼
			UpdateViewTypeCodeTabRecord(intViewTypeCode);
		}
		
		
		protected void dgViewTypeCodeTab_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
		{
			int intIndex;
			//�ж��Ƿ����µ������ֶ�
			intIndex = strSortViewTypeCodeTabBy.IndexOf(e.SortExpression);
			if (intIndex == -1)
			{
				strSortViewTypeCodeTabBy = e.SortExpression + " Asc";
				BindDg_ViewTypeCodeTab();
				return ;
			}
			//���ԭ��������
			intIndex = strSortViewTypeCodeTabBy.IndexOf(" Asc");
			if (intIndex == -1)		//���ԭ���������������Ϊ����
			{
				strSortViewTypeCodeTabBy = e.SortExpression + " Asc";
			}
			else			///��������Ϊ����
			{
				strSortViewTypeCodeTabBy = e.SortExpression + " Desc";
			}
			BindDg_ViewTypeCodeTab();
		}

		private string strSortViewTypeCodeTabBy
		{
			get
			{
				string sSortViewTypeCodeTabBy;
				sSortViewTypeCodeTabBy = (string)ViewState["SortViewTypeCodeTabBy"];
				if (sSortViewTypeCodeTabBy==null) 
				{
					sSortViewTypeCodeTabBy = "";
				}
				return sSortViewTypeCodeTabBy;
			}
			set
			{
				string sSortViewTypeCodeTabBy = value;
				ViewState.Add("SortViewTypeCodeTabBy", sSortViewTypeCodeTabBy);
			}
		}

		//���ɸ������SESSION������Ժ���
		protected void btnViewTypeCodeTabPrevPage_Click(object sender, System.EventArgs e)
		{
			this.dgViewTypeCodeTab.CurrentPageIndex -=1; 
			this.BindDg_ViewTypeCodeTab(); 
		}

		protected void btnViewTypeCodeTabNextPage_Click(object sender, System.EventArgs e)
		{
			this.dgViewTypeCodeTab.CurrentPageIndex +=1; 
			this.BindDg_ViewTypeCodeTab(); 
		}

		protected void btnViewTypeCodeTabJumpPage_Click(object sender, System.EventArgs e)
		{
			if(this.txtViewTypeCodeTabJump2Page.Text.Trim()!="" && 
				int.Parse(this.txtViewTypeCodeTabJump2Page.Text)>0 && 
				int.Parse(this.txtViewTypeCodeTabJump2Page.Text)-1<this.dgViewTypeCodeTab.PageCount) 
			{ 
				this.dgViewTypeCodeTab.CurrentPageIndex=int.Parse(this.txtViewTypeCodeTabJump2Page.Text)-1; 
			} 
			this.BindDg_ViewTypeCodeTab();
		}

		///���ɵĲ����¼׼�����̴���for C#
		private void AddViewTypeCodeTabRecord()
		{
			wucViewTypeCodeTab1.SetKeyReadOnly(false);
			btnOKUpd.Text = "ȷ�����";
            //wucViewTypeCodeTab1.ViewTypeCode = clsViewTypeCodeTab.GetMaxStrId("ViewTypeCodeTab","ViewTypeCode", 4, "");
            DispEditViewTypeCodeTabRegion();
		}
		///�����¼���̹��̴���for C#
		private void AddViewTypeCodeTabRecordSave()
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
			clsViewTypeCodeTabEN objViewTypeCodeTab;
			//1�����ؼ����������������Ƿ���ȷ
			if (!wucViewTypeCodeTab1.IsValid(ref strResult))
			{
				lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
				return ;
			}
			//2��������󲢳�ʼ������
			//clsViewTypeCodeTabEN objViewTypeCodeTab;	//�������
			objViewTypeCodeTab = new clsViewTypeCodeTabEN(wucViewTypeCodeTab1.ViewTypeCode);	//��ʼ���¶���
			//3���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
			if (clsViewTypeCodeTabBL.IsExist(wucViewTypeCodeTab1.ViewTypeCode))	//�ж��Ƿ�����ͬ�Ĺؼ���
			{
				strMsg = "�ؼ����ֶ�������ͬ��ֵ";
				clsCommonJsFunc.Alert(this, strMsg);
				return;
			}
			//4����ֵ�ӽ���㴫���߼��������ʵ���
			PutDataToViewTypeCodeTabClass(objViewTypeCodeTab);		//�ѽ����ֵ����
			//5����鴫��ȥ�Ķ��������Ƿ�Ϸ�
			try
			{
                clsViewTypeCodeTabBL .CheckPropertyNew(objViewTypeCodeTab);
                //6��������ʵ�������ݴ��������ݿ���
                clsViewTypeCodeTabBL .AddNewRecordBySql2(objViewTypeCodeTab);
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
			BindDg_ViewTypeCodeTab();
			wucViewTypeCodeTab1.Clear();		//��տؼ�������
			///�ָ�<ȷ�����>���<���>
			btnOKUpd.Text = "���";
			DispViewTypeCodeTabListRegion();
		}
		///�����¼���̹��̴���for C#
		private void AddViewTypeCodeTabRecordSaveV5()
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
			clsViewTypeCodeTabEN objViewTypeCodeTab;
			//1�����ؼ����������������Ƿ���ȷ
			if (!wucViewTypeCodeTab1.IsValid(ref strResult))
			{
				lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
				return ;
			}
			//2��������󲢳�ʼ������
			//clsViewTypeCodeTabEN objViewTypeCodeTab;	//�������
			objViewTypeCodeTab = new clsViewTypeCodeTabEN(wucViewTypeCodeTab1.ViewTypeCode);	//��ʼ���¶���
			//3���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
			if (clsViewTypeCodeTabBL.IsExist(wucViewTypeCodeTab1.ViewTypeCode))	//�ж��Ƿ�����ͬ�Ĺؼ���
			{
				strMsg = "�ؼ����ֶ�������ͬ��ֵ";
				clsCommonJsFunc.Alert(this, strMsg);
				return;
			}
			//4����ֵ�ӽ���㴫���߼��������ʵ���
			PutDataToViewTypeCodeTabClass(objViewTypeCodeTab);		//�ѽ����ֵ����
			//5����鴫��ȥ�Ķ��������Ƿ�Ϸ�
			try
			{
				  clsViewTypeCodeTabBL .CheckPropertyNew(objViewTypeCodeTab);
                //6��������ʵ�������ݴ��������ݿ���
                clsViewTypeCodeTabBL.AddNewRecordBySql2(objViewTypeCodeTab);
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
			BindDg_ViewTypeCodeTab();
			wucViewTypeCodeTab1.Clear();		//��տؼ�������
			///�ָ�<ȷ�����>���<���>
			btnOKUpd.Text = "���";
			DispViewTypeCodeTabListRegion();
		}
		///�����޸ļ�¼׼�����̴��� for C#
		private void UpdateViewTypeCodeTabRecord(int intViewTypeCode)
		{
			//�������裺���ܹ�2����
			//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
			//2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�

			//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
			ShowData(intViewTypeCode);
			//2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
			clsPubFun.SetButtonEnabled(btnOKUpd, true);
			wucViewTypeCodeTab1.SetKeyReadOnly(true);
			btnOKUpd.Text = "ȷ���޸�";
			lblMsg.Text = "";
			DispEditViewTypeCodeTabRegion();
		}
		///�޸Ĵ���׼�����̴��� for C#
		private void UpdateViewTypeCodeTabRecordSave(clsViewTypeCodeTabEN objViewTypeCodeTab)
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
			if (!wucViewTypeCodeTab1.IsValid(ref strResult))
			{
				lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
				return ;
			}
			//2����ֵ�ӽ���㴫���߼��������ʵ���
			PutDataToViewTypeCodeTabClass(objViewTypeCodeTab);		//�ѽ����ֵ����
			//3����鴫��ȥ�Ķ��������Ƿ�Ϸ�
			try
			{
				  clsViewTypeCodeTabBL .CheckPropertyNew(objViewTypeCodeTab);
                //6��������ʵ�������ݴ��������ݿ���
                clsViewTypeCodeTabBL .UpdateBySql2(objViewTypeCodeTab);
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
			BindDg_ViewTypeCodeTab();
			wucViewTypeCodeTab1.Clear();//��տؼ��е�����
			//�ָ�<ȷ���޸�>���<���>
			btnOKUpd.Text = "���";
			DispViewTypeCodeTabListRegion();
		}
		///�޸Ĵ���׼�����̴��� for C#
		private void UpdateViewTypeCodeTabRecordSaveV5(clsViewTypeCodeTabEN objViewTypeCodeTab)
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
			if (!wucViewTypeCodeTab1.IsValid(ref strResult))
			{
				lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
				return ;
			}
			//2����ֵ�ӽ���㴫���߼��������ʵ���
			PutDataToViewTypeCodeTabClass(objViewTypeCodeTab);		//�ѽ����ֵ����
			//3����鴫��ȥ�Ķ��������Ƿ�Ϸ�
			try
			{
				  clsViewTypeCodeTabBL .CheckPropertyNew(objViewTypeCodeTab);
                //6��������ʵ�������ݴ��������ݿ���
                clsViewTypeCodeTabBL .UpdateBySql2(objViewTypeCodeTab);
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
			BindDg_ViewTypeCodeTab();
			wucViewTypeCodeTab1.Clear();//��տؼ��е�����
			//�ָ�<ȷ���޸�>���<���>
			btnOKUpd.Text = "���";
			DispViewTypeCodeTabListRegion();
		}
		///ɾ����¼���̴���for C#
		private void DeleteViewTypeCodeTabRecord(int intViewTypeCode)
		{
			clsViewTypeCodeTabBL.DelRecord(intViewTypeCode);
			BindDg_ViewTypeCodeTab();
		}
		private void DispEditViewTypeCodeTabRegion()
		{
			tabViewTypeCodeTabDataGrid.Visible = false;
			tabEditViewTypeCodeTabRegion.Visible = true;
		}
		private void DispViewTypeCodeTabListRegion()
		{
			tabViewTypeCodeTabDataGrid.Visible = true;
			tabEditViewTypeCodeTabRegion.Visible = false;
		}
		
		//��ǰ��¼��
		protected void lbDispViewTypeCodeTabList_Click(object sender, System.EventArgs e)
		{
			DispViewTypeCodeTabListRegion();
		}

		protected void dgViewTypeCodeTab_ItemDataBound(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
		{
			//			System.Web.UI.WebControls.CheckBox chkIsNull, chkIsPrimaryKey;
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.SelectedItem ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
				int [] iNum= new int[20];
				iNum[0] = 7;
				iNum[1] = 8;
				iNum[2] = 9;
				iNum[3] = 10;
				iNum[4] = 11;
				iNum[5] = 12;
                iNum[6] = 13;
                iNum[7] = 14;
                iNum[8] = 15;

				for (int i = 0; i<9; i++)
				{
					if (e.Item.Cells[iNum[i]].Text == "True")
					{
						e.Item.Cells[iNum[i]].Text = "��";
						e.Item.Cells[iNum[i]].ForeColor = System.Drawing.Color.Green;
					}
					else
					{
						e.Item.Cells[iNum[i]].Text = "��";
						e.Item.Cells[iNum[i]].ForeColor = System.Drawing.Color.Red;
					};
				}
			}

		}

        protected void btnUpMove_Click(object sender, System.EventArgs e)
        {
            string strMsg;
            string strViewTypeCode = clsCommForWebForm.GetFirstCheckedItemFromDg(dgViewTypeCodeTab);
            if (strViewTypeCode == null || strViewTypeCode.Trim().Length == 0)
            {
                lblMsgList.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
                return;
            }
            lblMsgList.Text = "";
            int intViewTypeCode = int.Parse(strViewTypeCode);

            try
            {
                clsViewTypeCodeTabBLEx.AdjustSequenceNumber("UP", intViewTypeCode);
            }
            catch (Exception objException)
            {
                strMsg = objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                //				clsCommonSession.seErrMessage = objException.Message;
                //				clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;	//"../GenCode/wfmGenViewCode_WebV5.aspx";
                //				clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindDg_ViewTypeCodeTab();
            clsCommForWebForm.SetCheckedItemForDg(dgViewTypeCodeTab, 1, intViewTypeCode.ToString());

        }

        protected void btnDownMove_Click(object sender, System.EventArgs e)
        {
            string strMsg;
            string strViewTypeCode = clsCommForWebForm.GetFirstCheckedItemFromDg(dgViewTypeCodeTab);
            if (strViewTypeCode == null || strViewTypeCode.Trim().Length == 0)
            {
                lblMsgList.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
                return;
            }
            lblMsgList.Text = "";

            int intViewTypeCode = int.Parse(strViewTypeCode);
            try
            {
                clsViewTypeCodeTabBLEx.AdjustSequenceNumber("DOWN", intViewTypeCode);
            }

            catch (Exception objException)
            {
                strMsg = objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                //				clsCommonSession.seErrMessage = objException.Message;
                //				clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;	//"../GenCode/wfmGenViewCode_WebV5.aspx";
                //				clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindDg_ViewTypeCodeTab();
            clsCommForWebForm.SetCheckedItemForDg(dgViewTypeCodeTab, 1, intViewTypeCode.ToString());

        }

        protected void btnReOrder_Click(object sender, System.EventArgs e)
        {
            clsViewTypeCodeTabBLEx.ReOrder();
            BindDg_ViewTypeCodeTab();

        }


        protected void btnGoTop_Click(object sender, EventArgs e)
        {
            List<string> arrViewTypeCodeTabId = clsCommForWebForm.GetAllCheckedItemFromDg2(dgViewTypeCodeTab, "chkCheckRec");
            if (arrViewTypeCodeTabId == null || arrViewTypeCodeTabId.Count == 0)
            {
                lblMsgList.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
                clsCommonJsFunc.Alert(this, lblMsgList.Text);
                return;
            }
            else
            {
                lblMsgList.Text = "";


                try
                {
                    clsViewTypeCodeTabBLEx.GoTop(arrViewTypeCodeTabId);
                }
                catch (Exception objException)
                {
                    clsCommonSession.seErrMessage = objException.Message;
                    clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                    clsPubFun4Web.AccessError(this, conCurrPageName);
                }
            }
            BindDg_ViewTypeCodeTab();
        }

        protected void btnGoBottum_Click(object sender, EventArgs e)
        {
            List<string> arrViewTypeCodeTabId = clsCommForWebForm.GetAllCheckedItemFromDg2(dgViewTypeCodeTab, "chkCheckRec");
            if (arrViewTypeCodeTabId == null || arrViewTypeCodeTabId.Count == 0)
            {
                lblMsgList.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
                clsCommonJsFunc.Alert(this, lblMsgList.Text);
                return;
            }
            else
            {
                lblMsgList.Text = "";
                try
                {
                    clsViewTypeCodeTabBLEx.GoBottom(arrViewTypeCodeTabId);
                }
                catch (Exception objException)
                {
                    clsCommonSession.seErrMessage = objException.Message;
                    clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                    clsPubFun4Web.AccessError(this, conCurrPageName);
                }
            }
            BindDg_ViewTypeCodeTab();
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

        protected void btnClone_Click(object sender, EventArgs e)
        {
            string strViewTypeCode = clsCommForWebForm.GetFirstCheckedItemFromDg(dgViewTypeCodeTab);

            if (string.IsNullOrEmpty(strViewTypeCode) == true)
            {
                lblMsg.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
                return;
            }
            int intViewTypeCode = int.Parse(strViewTypeCode);
            lblMsgList.Text = "";
            clsViewTypeCodeTabEN objViewTypeCodeTabEN = clsViewTypeCodeTabBL.GetObjByViewTypeCode(intViewTypeCode);
            objViewTypeCodeTabEN.ViewTypeName = "Copy_" + objViewTypeCodeTabEN.ViewTypeName;

            try
            {
                clsViewTypeCodeTabBL.AddNewRecordBySql2(objViewTypeCodeTabEN);

            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
            }

            BindDg_ViewTypeCodeTab();
        }
    }
}