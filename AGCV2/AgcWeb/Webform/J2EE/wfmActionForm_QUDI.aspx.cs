
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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
using AGC.Entity;


using com.taishsoft.common;


namespace AGC.Webform
{
	/// <summary>
	/// wfmActionForm_QUDI ��ժҪ˵��������Q�����ѯ��U�����޸�
	/// </summary>
	public partial class wfmActionForm_QUDI : CommWebPageBase
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
				lblViewGroupName.Text = clsViewGroupBL.GetObjByViewGroupId(ViewGroupId).ViewGroupName;
				//1��Ϊ��������������Դ�����б�����
				wucActionForm1.SetDdl_ActionFormTypeId();
				clsActionFormTypeBL.BindDdl_ActionFormTypeId(ddlActionFormTypeId_q);

				strSortActionFormBy = "ActionFormId Asc";
				//2����ʾ�������ı�������DATAGRID��
				BindDg_ActionForm();
				//3�����ñ�ؼ����ֿؼ���ReadOnly���ԣ�
				//   ʹֻ֮������Ϊ���޸Ĺ����йؼ����ǲ��ܱ��޸ĵġ�
				wucActionForm1.SetKeyReadOnly(true);
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

		private string ActionFormId
		{
			get
			{
				string strActionFormId;
				strActionFormId = (string)Session["ActionFormId"];
				if (strActionFormId==null) 
				{
					strActionFormId = "";
				}
				return strActionFormId;
			}
			set
			{
				string strActionFormId = value;
				Session.Add("ActionFormId", strActionFormId);
			}
		}

		private string ViewGroupId
		{
			get
			{
				string strViewGroupId;
				strViewGroupId = (string)Session["ViewGroupId"];
				if (strViewGroupId==null) 
				{
					strViewGroupId = "";
				}
				return strViewGroupId;
			}
			set
			{
				string strViewGroupId = value;
				Session.Add("ViewGroupId", strViewGroupId);
			}
		}
		
		private string BackErrPageLinkStr
		{
			get
			{
				string strListViewRegion;
				strListViewRegion = (string)Session["ListViewRegion"];
				if (strListViewRegion==null) 
				{
					strListViewRegion = "";
				}
				return strListViewRegion;
			}
			set
			{
				string strListViewRegion = value;
				Session.Add("ListViewRegion", strListViewRegion);
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
///                    clsCommForWebForm.CheckObjUser(pobjUser, this);
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
		private string CombineActionFormCondition()
		{
			//ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
			//���� 1=1 && UserName = '����'
			string strWhereCond=" 1=1 ";
			//����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
			if (this.txtActionFormName_q.Text.Trim()!="")
			{
				strWhereCond += " And ActionForm.ActionFormName like '%" + this.txtActionFormName_q.Text.Trim()+"%'";
			}
			if (this.ddlActionFormTypeId_q.SelectedValue!="" && this.ddlActionFormTypeId_q.SelectedValue!="0")
			{
				strWhereCond += " And ActionForm.ActionFormTypeId='" + this.ddlActionFormTypeId_q.SelectedValue+"'";
			}

			return strWhereCond;
		}
		///���ɰ�DATAGRID�Ĵ���
		/// <summary>
		/// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
		///			 ����ʾ��DATAGRID�С�
		/// </summary>
		private void BindDg_ActionForm()
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
			string strWhereCond = CombineActionFormCondition();
			//	2��������������ȡ�ñ�����������DataTable��
			System.Data.DataTable objDT = clsActionFormBL.GetDataTable(strWhereCond);
			//	3�����DATAGRID�ĵ�ǰҳ���Ƿ񳬳�DATAGRID��ҳ����Χ
			//		3.1 ���ȼ���ҳ����
			//		3.2 �����ǰҳ����ҳ����Ϊ���һҳ
			int intPages = CalcPages(objDT.Rows.Count, this.dgActionForm.PageSize);
			if (intPages==0) 
			{
				this.dgActionForm.CurrentPageIndex = 0;
			}
			else if (this.dgActionForm.CurrentPageIndex > intPages - 1) 
			{
				this.dgActionForm.CurrentPageIndex = intPages - 1;
			}
			//	4������DATAGRID������Դ(DataSource)��
			DataView objDV = objDT.DefaultView;
			objDV.Sort = strSortActionFormBy;     ///ע����һ�д����п�����Ҫע�͵���Ŀǰ���н����ڵ����Ĳ�ѯ������������
			this.dgActionForm.DataSource=objDV;
			//	5����DATAGRID������DataTable��������ʾ��DATAGRID��
			this.dgActionForm.DataBind();

			
			//��ǰ��¼��
			this.lblActionFormRecCount.Text = objDT.Rows.Count.ToString(); 
			//��ǰҳ��
			this.lblActionFormAllPages.Text = this.dgActionForm.PageCount.ToString(); 
			//��ǰҳ����
			this.lblActionFormCurrentPage.Text=(this.dgActionForm.CurrentPageIndex+1).ToString();
			//��ǰ����������ҳ����
			this.txtActionFormJump2Page.Text=(this.dgActionForm.CurrentPageIndex+1).ToString();
			//�����ǰҳ����Ϊ0����<ǰһҳ>��ť��Ч
			if(this.dgActionForm.CurrentPageIndex==0) 
			{
				btnActionFormPrevPage.Enabled=false; 
			}
			else 
			{ 
				btnActionFormPrevPage.Enabled=true; 
			} 
			//�����ǰҳ������Ϊ���һҳ����<ǰһҳ>��ť��Ч
			if(this.dgActionForm.CurrentPageIndex==this.dgActionForm.PageCount-1) 
			{ 
				btnActionFormNextPage.Enabled=false; 
			} 
			else 
			{ 
				btnActionFormNextPage.Enabled=true; 
			} 
			//7�������沿����ʾ����ʾ �������ǰDataGrid�еļ�¼��Ϊ0������ʾ��ǰ����ҳ������
			if(objDT.Rows.Count>0) 
			{ 
				this.tabActionFormJumpPage.Visible = true; 
			} 
			else 
			{ 
				this.tabActionFormJumpPage.Visible = false; 
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
			this.dgActionForm.CurrentPageIndex=0;
			//�ѱ��¼��������ʾ��DATAGRID��
			BindDg_ActionForm();
		}
		/// <summary>
		/// �������ܣ��¼��������ڸ���DATAGRID�ĵ�ǰҳ����ʱ�����ĺ�����
		///			  ���幦����������ʾ��ҳ(������ҳ����)�����ݡ�
		/// </summary>
		/// <param name="source"></param>
		/// <param name="e"></param>
		protected void dgActionForm_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			//�������裺����2����
			//1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
			//2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ

			//1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
			this.dgActionForm.CurrentPageIndex=e.NewPageIndex;
			//2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ
			BindDg_ActionForm();
		}
		/// <summary>
		/// �������ܣ����Ըùؼ��ֵļ�¼������ʾ�ڽ����ϣ�
		///������     �������ǰ�ֵ������ؼ���
		/// </summary>
		/// <param name="strActionFormId">���¼�Ĺؼ��֣���ʾ�ñ�ؼ��ֵ�����</param>
		private void ShowData(string strActionFormId)
		{
			//�������裺
			//1�����ؼ����Ƿ�Ϊ�գ�
			//2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
			//3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
			//4����ȡ�������������ԣ�
			//5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���

			//1�����ؼ����Ƿ�Ϊ�գ�
			if (strActionFormId == "") return ;		//����ؼ���Ϊ�վͷ����˳�
			//2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
			if (clsActionFormBL.IsExist(strActionFormId) == false)		//���ùؼ��ֵļ�¼�Ƿ����
			{
				string ss = "�ؼ���Ϊ��" + strActionFormId + "�Ĳ�����!";
				clsCommonJsFunc.Alert(this, ss);
				return ;
			}
			//3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
			clsActionFormEN objActionForm = new clsActionFormEN(strActionFormId);
            //4����ȡ�������������ԣ�
            clsActionFormBL .GetActionForm(ref objActionForm);
			Session.Add("objActionForm", objActionForm);
			//5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���
			GetDataFromActionFormClass(objActionForm);
		}
		///���ɴ��߼�������ݴ��䵽�����ĺ�������
		/// <summary>
		/// �������ܣ�������������������ʾ��������
		///ע�⣺��������������򣬲�����һ��������������ϵ�ģ�����Ϊһ��������ֵ��Ȼ����Ϊ����������ֵ
		///      ������������ݿ�ʱ����Ӧ��һ���ֶ���ǰ�������ֶ��ں�
		/// </summary>
		/// <param name="pobjActionForm">��ʵ�������</param>
		private void GetDataFromActionFormClass(clsActionFormEN pobjActionForm)
		{
			wucActionForm1.ActionFormId = pobjActionForm.ActionFormId;
			wucActionForm1.ActionFormName = pobjActionForm.ActionFormName;
			wucActionForm1.ActionFormTypeId = pobjActionForm.ActionFormTypeId;
			wucActionForm1.Memo = pobjActionForm.Memo;
		}
		/// <summary>
		/// �������ܣ��¼�������������<ȷ���޸�>ʱ�������¼�������
		///           ���幦��Ϊ�ѽ�������ͬ�����ݿ��У��ѽ������ݱ��浽���ݿ���
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected void btnOKUpd_Click(object sender, System.EventArgs e)
		{
			string strMsg;	//ר�����ڴ�����Ϣ�ı���
			string strResult=" ";	//���ڴ����ڼ����������ʱ���ֵ�ı���
			string strCommandText;
			clsActionFormEN objActionForm;
			Button btnTemp;
			btnTemp = (Button) sender;
			strCommandText = btnTemp.Text;
			switch(strCommandText)
			{
				case "���":
					wucActionForm1.SetKeyReadOnly(false);
					btnOKUpd.Text = "ȷ�����";
					InitActionForm();
					break;				
				case "ȷ�����":
					//����һ������Ĳ���Ĵ��룬�����߼���̫�򵥣�
					//�Ͱ��߼���ϲ������Ʋ�,
					//�������裺
					//1�����ؼ����������������Ƿ���ȷ
					//2��������󲢳�ʼ������
					//3���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
					//4����ֵ�ӽ���㴫���߼��������ʵ���
					//5����鴫��ȥ�Ķ��������Ƿ�Ϸ�
					//6��������ʵ�������ݴ��������ݿ���
					//7��������ļ�¼������ʾ��DATAGRID��
					//1�����ؼ����������������Ƿ���ȷ
					if (!wucActionForm1.IsValid(ref strResult))
					{
						lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
						return ;
					}
					//2��������󲢳�ʼ������
					//clsActionFormEN objActionForm;	//�������
					objActionForm = new clsActionFormEN(wucActionForm1.ActionFormId);	//��ʼ���¶���
					//3���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
					if (clsActionFormBL.IsExist(wucActionForm1.ActionFormId))	//�ж��Ƿ�����ͬ�Ĺؼ���
					{
						strMsg = "�ؼ����ֶ�������ͬ��ֵ";
						clsCommonJsFunc.Alert(this, strMsg);
						return;
					}
					//4����ֵ�ӽ���㴫���߼��������ʵ���
					PutDataToActionFormClass(objActionForm);		//�ѽ����ֵ����
					//5����鴫��ȥ�Ķ��������Ƿ�Ϸ�
                    try
                    {
                        clsActionFormBL .CheckPropertyNew(objActionForm);
                    }
                    catch(Exception objException)
					{
                        clsCommonJsFunc.Alert(this, objException.Message);
						return ; 
					}
					//�����ͬһ�����������Ƿ�����ͬ��ActionForm����
					StringBuilder sbWhere = new StringBuilder();
					sbWhere.AppendFormat("ViewGroupId = '{0}'", ViewGroupId);
					sbWhere.AppendFormat(" and ActionFormName = '{0}'", objActionForm.ActionFormName);
                    if (clsActionFormBL.IsExistRecord(sbWhere.ToString()) == true)
					{
						strMsg = "��ͬһ����������������ͬ��ActionForm�������ظ����!";
						clsCommonJsFunc.Alert(this, strMsg);
						return;
					}
					//6��������ʵ�������ݴ��������ݿ���
					if (clsActionFormBL .AddNewRecordBySql2(objActionForm) == false) 
					{
						strMsg = "��Ӳ��ɹ�!";
						clsCommonJsFunc.Alert(this, strMsg);
						lblMsg.Text = "��Ӽ�¼���ɹ�!";
					}
					else
					{
						strMsg = "��Ӽ�¼�ɹ�!";
						clsCommonJsFunc.Alert(this, strMsg);
						lblMsg.Text = "��Ӽ�¼�ɹ�!";
					}
					//7��������ļ�¼������ʾ��DATAGRID��
					BindDg_ActionForm();
					wucActionForm1.Clear();		//��տؼ�������
					///�ָ�<ȷ�����>���<���>
					btnOKUpd.Text = "���";
					break;
				case "ȷ���޸�":
					//����һ��������޸ĵĴ��룬�����߼���̫�򵥣�
					//�Ͱ��߼���ϲ������Ʋ�,
					//�������裺
					//1�����ؼ����������������Ƿ���ȷ
					//2����ֵ�ӽ���㴫���߼��������ʵ���
					//3����鴫��ȥ�Ķ��������Ƿ�Ϸ�
					//4��������ʵ�������ݴ��������ݿ���
					//5�����޸ĺ��������ʾ��DATAGRID��
					//1�����ؼ����������������Ƿ���ȷ
					if (!wucActionForm1.IsValid(ref strResult))
					{
						lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
						return ;
					}
					//2����ֵ�ӽ���㴫���߼��������ʵ���
					objActionForm = (clsActionFormEN) Session["objActionForm"];
					PutDataToActionFormClass(objActionForm);		//�ѽ����ֵ����
					//3����鴫��ȥ�Ķ��������Ƿ�Ϸ�
                    try
                    {
                        clsActionFormBL.CheckPropertyNew(objActionForm);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
					//4��������ʵ���������޸�ͬ�������ݿ���
					if (clsActionFormBL .UpdateBySql2(objActionForm) == false) 
					{
						strMsg = "�޸ļ�¼���ɹ�!";
						clsCommonJsFunc.Alert(this, strMsg);
						lblMsg.Text = "�޸ļ�¼���ɹ�!";
					}
					else
					{
						strMsg = "�޸ļ�¼�ɹ�!";
						clsCommonJsFunc.Alert(this, strMsg);
						lblMsg.Text = "�޸ļ�¼�ɹ�!";
					}
					//5�����޸ĺ��������ʾ��DATAGRID��
					BindDg_ActionForm();
					wucActionForm1.Clear();//��տؼ��е�����
					//�ָ�<ȷ���޸�>���<���>
					btnOKUpd.Text = "���";
					break;
			}
		}
		
		/// <summary>
		/// �������ܣ��ѽ����ϵ��������ݴ����������
		/// </summary>
		/// <param name="pobjActionForm">���ݴ����Ŀ�������</param>
		private void PutDataToActionFormClass(clsActionFormEN pobjActionForm)
		{
			pobjActionForm.ActionFormId = wucActionForm1.ActionFormId;
			pobjActionForm.ActionFormName = wucActionForm1.ActionFormName;
			pobjActionForm.ViewGroupId = ViewGroupId;
			pobjActionForm.ActionFormTypeId = wucActionForm1.ActionFormTypeId;
			pobjActionForm.Memo = wucActionForm1.Memo;
            pobjActionForm.UserId = clsCommonSession.UserId;
			pobjActionForm.UpdDate = clsGeneralTab.getTodayStr_S(0);
		}

		protected void dgActionForm_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
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
			if (strSortActionFormBy == "") return ;
			if(e.Item.ItemType==ListItemType.Header)//����ؼ��Ƿ�Ϊҳü��
			{
				string strSortEx;
				for(int i=0;i<this.dgActionForm.Columns.Count;i++)
				{
					strSortEx = this.dgActionForm.Columns[i].SortExpression;
					if (strSortEx == "") continue;
					intIndex = strSortActionFormBy.IndexOf(strSortEx + " ");
					if(intIndex >=0)  //��ͼ״̬��������ʽ�Ƿ�Ϊ���е��ֶΣ�
					{
						Label lblSort=new Label();
						lblSort.Font.Name="webdings";//�������壬��"webdings"��5�������ǣ�6�������ǣ�
						intIndex = strSortActionFormBy.IndexOf("Asc");
						lblSort.Text=(intIndex>0?" 5":" 6");//�Ƿ�Ϊ���򣬶���Ϊstring�ͣ�
						e.Item.Cells[i].Controls.Add(lblSort);//��������ĵ�i����Ԫ��������һ�ؼ���
						break;
					}
				}
			}
		}

		protected void dgActionForm_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			string strActionFormId;
			string strCommandName;
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.SelectedItem ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
				strCommandName = ((LinkButton)e.CommandSource).CommandName;
				strActionFormId = e.Item.Cells[1].Text;
				switch(strCommandName)
				{
					case "Delete":
						clsActionFormBL.DelRecord(strActionFormId);
						BindDg_ActionForm();
						break;
						// Add other cases here, if there are multiple ButtonColumns in 
						// the DataGrid control.
					case "Update":
						//�������裺���ܹ�2����
						//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
						//2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�

						//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
						ShowData(strActionFormId);
						//2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
						clsPubFun.SetButtonEnabled(btnOKUpd, true);
						wucActionForm1.SetKeyReadOnly(true);
						btnOKUpd.Text = "ȷ���޸�";
						lblMsg.Text = "";
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
					Set_DataGridAllChecked(dgActionForm, true);
					lbSelAll.Text = "��ѡ";
				}
				else if (lbSelAll.Text == "��ѡ")
				{
					Set_DataGridAllChecked(dgActionForm, false);
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
			wucActionForm1.SetKeyReadOnly(false);
			btnOKUpd.Text = "ȷ�����";
			InitActionForm();
		}

		
		//��ǰ��¼��
		protected void btnExportExcel4Dg_Click(object sender, System.EventArgs e)
		{
			//	1����Ͻ�����������
			string strWhereCond = CombineActionFormCondition();
			//	2��������������ȡ�ñ�����������DataTable��
			System.Data.DataTable objDT = clsActionFormBL.GetDataTable_ActionForm(strWhereCond);
			List<string> arrCnName = new List<string>();
			List<string> arrColName = new List<string>();
			string strFileName = "ActionForm��Ϣ����.xls";
			string strFolderName;
			string strDownLoadFileName;
			arrColName.Add("ActionFormId"); arrCnName.Add("ActionFormId");
			arrColName.Add("ActionFormName"); arrCnName.Add("ActionForm����");
			arrColName.Add("ViewGroupId"); arrCnName.Add("������ID");
			arrColName.Add("FormBeanType"); arrCnName.Add("FormBean������");
			strFolderName = Server.MapPath("~") +  "\\TempFiles\\";
			strDownLoadFileName = strFolderName + strFileName;
            if (clsPubVar.InitExcelFile(this, strFolderName, strDownLoadFileName) == false)
            {
                return;
            }

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
            List<string> arrActionFormId = clsCommForWebForm.GetAllCheckedItemFromDg2(dgActionForm, "chkCheckRec");
			if (arrActionFormId == null || arrActionFormId.Count == 0) 
			{
				lblMsg.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
				return ;
			}
			lblMsg.Text = "";
			clsActionFormBL.DelActionForms(arrActionFormId);
			BindDg_ActionForm();
		}

		
		//��ǰ��¼��
		protected void btnUpdate4Dg_Click(object sender, System.EventArgs e)
		{
			string strActionFormId =clsCommForWebForm.GetFirstCheckedItemFromDg(dgActionForm);
			if (strActionFormId == null || strActionFormId.Trim().Length == 0) 
			{
				lblMsg.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
				return ;
			}
			lblMsg.Text = "";
			//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
			ShowData(strActionFormId);
			//2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
			clsPubFun.SetButtonEnabled(btnOKUpd, true);
			wucActionForm1.SetKeyReadOnly(true);
			btnOKUpd.Text = "ȷ���޸�";	
		}
		
		public System.Data.DataTable GetViewGroupId()
		{
			//��ȡĳѧԺ����רҵ��Ϣ
			string strSQL = "select ViewGroupId, ViewGroupName from ViewGroup ";
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}
		public void BindDdl_ViewGroupId(System.Web.UI.WebControls.DropDownList objDDL)
		{
			//Ϊ����Դ�ڱ����������������
			ListItem li=new ListItem("��ѡ��...","0");
			System.Data.DataTable objDT = GetViewGroupId();
			objDDL.DataValueField="ViewGroupId";
			objDDL.DataTextField="ViewGroupName";
			objDDL.DataSource = objDT;
			objDDL.DataBind();
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
		}
		public System.Data.DataTable GetUserId()
		{
			//��ȡĳѧԺ����רҵ��Ϣ
			string strSQL = "select UserId, UserName from Users ";
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}
		public void BindDdl_UserId(System.Web.UI.WebControls.DropDownList objDDL)
		{
			//Ϊ����Դ�ڱ����������������
			ListItem li=new ListItem("��ѡ��...","0");
			System.Data.DataTable objDT = GetUserId();
			objDDL.DataValueField="UserId";
			objDDL.DataTextField="UserName";
			objDDL.DataSource = objDT;
			objDDL.DataBind();
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
		}
		
		protected void dgActionForm_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
		{
			int intIndex;
			//�ж��Ƿ����µ������ֶ�
			intIndex = strSortActionFormBy.IndexOf(e.SortExpression);
			if (intIndex == -1)
			{
				strSortActionFormBy = e.SortExpression + " Asc";
				BindDg_ActionForm();
				return ;
			}
			//���ԭ��������
			intIndex = strSortActionFormBy.IndexOf(" Asc");
			if (intIndex == -1)		//���ԭ���������������Ϊ����
			{
				strSortActionFormBy = e.SortExpression + " Asc";
			}
			else			///��������Ϊ����
			{
				strSortActionFormBy = e.SortExpression + " Desc";
			}
			BindDg_ActionForm();
		}

		private string strSortActionFormBy
		{
			get
			{
				string sSortActionFormBy;
				sSortActionFormBy = (string)ViewState["SortActionFormBy"];
				if (sSortActionFormBy==null) 
				{
					sSortActionFormBy = "";
				}
				return sSortActionFormBy;
			}
			set
			{
				string sSortActionFormBy = value;
				ViewState.Add("SortActionFormBy", sSortActionFormBy);
			}
		}

		//���ɸ������SESSION������Ժ���
		protected void btnActionFormPrevPage_Click(object sender, System.EventArgs e)
		{
			this.dgActionForm.CurrentPageIndex -=1; 
			this.BindDg_ActionForm(); 
		}

		protected void btnActionFormNextPage_Click(object sender, System.EventArgs e)
		{
			this.dgActionForm.CurrentPageIndex +=1; 
			this.BindDg_ActionForm(); 
		}

		protected void btnActionFormJumpPage_Click(object sender, System.EventArgs e)
		{
			if(this.txtActionFormJump2Page.Text.Trim()!="" && 
				int.Parse(this.txtActionFormJump2Page.Text)>0 && 
				int.Parse(this.txtActionFormJump2Page.Text)-1<this.dgActionForm.PageCount) 
			{ 
				this.dgActionForm.CurrentPageIndex=int.Parse(this.txtActionFormJump2Page.Text)-1; 
			} 
			this.BindDg_ActionForm();
		}

		protected void btnEditActionFormProperty_Click(object sender, System.EventArgs e)
		{
			string strActionFormId =clsCommForWebForm.GetFirstCheckedItemFromDg(dgActionForm);
			if (strActionFormId == null || strActionFormId.Trim().Length == 0) 
			{
				lblMsg.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
				return ;
			}
			lblMsg.Text = "";
			ActionFormId = strActionFormId;
			Response.Redirect("../J2EE/wfmActionFormPropertys_QUDI.aspx");
		}

		protected void btnGoBack_Click(object sender, System.EventArgs e)
		{
			Response.Redirect(BackErrPageLinkStr);
		}
		private void InitActionForm()
		{
			wucActionForm1.ActionFormId = clsActionFormBL.GetMaxStrId_S();
			clsViewGroupENEx objViewGroupEN = (clsViewGroupENEx)clsViewGroupBL.GetObjByViewGroupId(ViewGroupId);
            clsViewGroupBLEx.initViewRelaTabFldSet(objViewGroupEN);
			string strTabName_FstLcase = objViewGroupEN.objINPrjTab.TabName;
			//CommProgramSet.clsComm objComm = new CommProgramSet.clsComm();
			strTabName_FstLcase = clsString.FstLcaseS(strTabName_FstLcase);

			wucActionForm1.ActionFormName = objViewGroupEN.PrjDomain + "." + strTabName_FstLcase + "Form";
			wucActionForm1.ActionFormTypeId = "04";
			wucActionForm1.Memo = "���ݽ�������������";
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