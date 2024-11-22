
using AGC.BusinessLogic;using AGC.FunClass;
using AGC.Entity;
using com.taishsoft.commdb;
using com.taishsoft.common;
using CommFunc4WebForm;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Web;
using System.Web.UI.WebControls;

namespace AGC
{
    /// <summary>
    /// wfmActionFormPropertys_QUDI ��ժҪ˵��������Q�����ѯ��U�����޸�
    /// </summary>
    public partial class wfmActionFormPropertys_QUDI : CommWebPageBase
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
				lblActionFormName.Text = clsActionFormBL.GetObjByActionFormId(ActionFormId).ActionFormName;
				//1��Ϊ��������������Դ�����б�����
				wucActionFormPropertys1.SetDdl_JavaTypeId();
				BindDdl_JavaTypeId(ddlJavaTypeId_q);
				strSortActionFormPropertysBy = "mId Asc";
				//2����ʾ�������ı�������DATAGRID��
				BindDg_ActionFormPropertys();
				//3�����ñ�ؼ����ֿؼ���ReadOnly���ԣ�
				//   ʹֻ֮������Ϊ���޸Ĺ����йؼ����ǲ��ܱ��޸ĵġ�
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
		private string CombineActionFormPropertysCondition()
		{
			//ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
			//���� 1=1 && UserName = '����'
			string strWhereCond=" 1=1 ";
			//����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
			if (this.txtPropertyName_q.Text.Trim()!="")
			{
				strWhereCond += " And PropertyName like '%" + this.txtPropertyName_q.Text.Trim()+"%'";
			}
			if (this.ddlJavaTypeId_q.SelectedValue!="" && this.ddlJavaTypeId_q.SelectedValue!="0")
			{
				strWhereCond += " And JavaTypeId='" + this.ddlJavaTypeId_q.SelectedValue+"'";
			}
			return strWhereCond;
		}
		///���ɰ�DATAGRID�Ĵ���
		/// <summary>
		/// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
		///			 ����ʾ��DATAGRID�С�
		/// </summary>
		private void BindDg_ActionFormPropertys()
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
			string strWhereCond = CombineActionFormPropertysCondition();
			//	2��������������ȡ�ñ�����������DataTable��
			System.Data.DataTable objDT = clsActionFormPropertysBL.GetDataTable(strWhereCond);
			//	3�����DATAGRID�ĵ�ǰҳ���Ƿ񳬳�DATAGRID��ҳ����Χ
			//		3.1 ���ȼ���ҳ����
			//		3.2 �����ǰҳ����ҳ����Ϊ���һҳ
			int intPages = CalcPages(objDT.Rows.Count, this.dgActionFormPropertys.PageSize);
			if (intPages==0) 
			{
				this.dgActionFormPropertys.CurrentPageIndex = 0;
			}
			else if (this.dgActionFormPropertys.CurrentPageIndex > intPages - 1) 
			{
				this.dgActionFormPropertys.CurrentPageIndex = intPages - 1;
			}
			//	4������DATAGRID������Դ(DataSource)��
			DataView objDV = objDT.DefaultView;
			objDV.Sort = strSortActionFormPropertysBy;     ///ע����һ�д����п�����Ҫע�͵���Ŀǰ���н����ڵ����Ĳ�ѯ������������
			this.dgActionFormPropertys.DataSource=objDV;
			//	5����DATAGRID������DataTable��������ʾ��DATAGRID��
			this.dgActionFormPropertys.DataBind();

			
			//��ǰ��¼��
			this.lblActionFormPropertysRecCount.Text = objDT.Rows.Count.ToString(); 
			//��ǰҳ��
			this.lblActionFormPropertysAllPages.Text = this.dgActionFormPropertys.PageCount.ToString(); 
			//��ǰҳ����
			this.lblActionFormPropertysCurrentPage.Text=(this.dgActionFormPropertys.CurrentPageIndex+1).ToString();
			//��ǰ����������ҳ����
			this.txtActionFormPropertysJump2Page.Text=(this.dgActionFormPropertys.CurrentPageIndex+1).ToString();
			//�����ǰҳ����Ϊ0����<ǰһҳ>��ť��Ч
			if(this.dgActionFormPropertys.CurrentPageIndex==0) 
			{
				btnActionFormPropertysPrevPage.Enabled=false; 
			}
			else 
			{ 
				btnActionFormPropertysPrevPage.Enabled=true; 
			} 
			//�����ǰҳ������Ϊ���һҳ����<ǰһҳ>��ť��Ч
			if(this.dgActionFormPropertys.CurrentPageIndex==this.dgActionFormPropertys.PageCount-1) 
			{ 
				btnActionFormPropertysNextPage.Enabled=false; 
			} 
			else 
			{ 
				btnActionFormPropertysNextPage.Enabled=true; 
			} 
			//7�������沿����ʾ����ʾ �������ǰDataGrid�еļ�¼��Ϊ0������ʾ��ǰ����ҳ������
			if(objDT.Rows.Count>0) 
			{ 
				this.tabActionFormPropertysJumpPage.Visible = true; 
			} 
			else 
			{ 
				this.tabActionFormPropertysJumpPage.Visible = false; 
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
			this.dgActionFormPropertys.CurrentPageIndex=0;
			//�ѱ��¼��������ʾ��DATAGRID��
			BindDg_ActionFormPropertys();
		}
		/// <summary>
		/// �������ܣ��¼��������ڸ���DATAGRID�ĵ�ǰҳ����ʱ�����ĺ�����
		///			  ���幦����������ʾ��ҳ(������ҳ����)�����ݡ�
		/// </summary>
		/// <param name="source"></param>
		/// <param name="e"></param>
		protected void dgActionFormPropertys_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			//�������裺����2����
			//1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
			//2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ

			//1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
			this.dgActionFormPropertys.CurrentPageIndex=e.NewPageIndex;
			//2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ
			BindDg_ActionFormPropertys();
		}
		/// <summary>
		/// �������ܣ����Ըùؼ��ֵļ�¼������ʾ�ڽ����ϣ�
		///������     �������ǰ�ֵ������ؼ���
		/// </summary>
		/// <param name="lngmId">���¼�Ĺؼ��֣���ʾ�ñ�ؼ��ֵ�����</param>
		private void ShowData(long lngmId)
		{
			//�������裺
			//1�����ؼ����Ƿ�Ϊ�գ�
			//2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
			//3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
			//4����ȡ�������������ԣ�
			//5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���

			//1�����ؼ����Ƿ�Ϊ�գ�
			if (lngmId == 0) return ;		//����ؼ���Ϊ�վͷ����˳�
			//2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
			if (clsActionFormPropertysBL.IsExist(lngmId) == false)		//���ùؼ��ֵļ�¼�Ƿ����
			{
				string ss = "�ؼ���Ϊ��" + lngmId + "�Ĳ�����!";
				clsCommonJsFunc.Alert(this, ss);
				return ;
			}
			//3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
			clsActionFormPropertysEN objActionFormPropertys = new clsActionFormPropertysEN(lngmId);
            //4����ȡ�������������ԣ�
            clsActionFormPropertysBL .GetActionFormPropertys(ref objActionFormPropertys);
			Session.Add("objActionFormPropertys", objActionFormPropertys);
			//5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���
			GetDataFromActionFormPropertysClass(objActionFormPropertys);
		}
		///���ɴ��߼�������ݴ��䵽�����ĺ�������
		/// <summary>
		/// �������ܣ�������������������ʾ��������
		///ע�⣺��������������򣬲�����һ��������������ϵ�ģ�����Ϊһ��������ֵ��Ȼ����Ϊ����������ֵ
		///      ������������ݿ�ʱ����Ӧ��һ���ֶ���ǰ�������ֶ��ں�
		/// </summary>
		/// <param name="pobjActionFormPropertys">��ʵ�������</param>
		private void GetDataFromActionFormPropertysClass(clsActionFormPropertysEN pobjActionFormPropertys)
		{
			wucActionFormPropertys1.PropertyName = pobjActionFormPropertys.PropertyName;
			wucActionFormPropertys1.JavaTypeId = pobjActionFormPropertys.JavaTypeId;
			wucActionFormPropertys1.Memo = pobjActionFormPropertys.Memo;
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
			clsActionFormPropertysEN objActionFormPropertys;
			Button btnTemp;
			btnTemp = (Button) sender;
			strCommandText = btnTemp.Text;
			switch(strCommandText)
			{
				case "���":
					btnOKUpd.Text = "ȷ�����";

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
					if (!wucActionFormPropertys1.IsValid(ref strResult))
					{
						lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
						return ;
					}
					//2��������󲢳�ʼ������
					//clsActionFormPropertysEN objActionFormPropertys;	//�������
					objActionFormPropertys = new clsActionFormPropertysEN();	//��ʼ���¶���
					//3���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
					//4����ֵ�ӽ���㴫���߼��������ʵ���
					PutDataToActionFormPropertysClass(objActionFormPropertys);		//�ѽ����ֵ����
					//5����鴫��ȥ�Ķ��������Ƿ�Ϸ�
					
                    try
                    {
                        clsActionFormPropertysBL .CheckPropertyNew(objActionFormPropertys);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
					if (CheckDuplicate(objActionFormPropertys)==true)
					{
						strMsg = "��ͬһ��ActionForm��������ͬ�����ԣ������ظ����!";
						clsCommonJsFunc.Alert(this, strMsg);
						return;
					}
					//6��������ʵ�������ݴ��������ݿ���
					if (clsActionFormPropertysBL.AddNewRecordBySql2(objActionFormPropertys) == false) 
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
					BindDg_ActionFormPropertys();
					wucActionFormPropertys1.Clear();		//��տؼ�������
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
					if (!wucActionFormPropertys1.IsValid(ref strResult))
					{
						lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
						return ;
					}
					//2����ֵ�ӽ���㴫���߼��������ʵ���
					objActionFormPropertys = (clsActionFormPropertysEN) Session["objActionFormPropertys"];
					PutDataToActionFormPropertysClass(objActionFormPropertys);		//�ѽ����ֵ����
					//3����鴫��ȥ�Ķ��������Ƿ�Ϸ�
				
                    try
                    {
                        clsActionFormPropertysBL.CheckPropertyNew(objActionFormPropertys);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
					//4��������ʵ���������޸�ͬ�������ݿ���
					if (clsActionFormPropertysBL .UpdateBySql2(objActionFormPropertys) == false) 
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
					BindDg_ActionFormPropertys();
					wucActionFormPropertys1.Clear();//��տؼ��е�����
					//�ָ�<ȷ���޸�>���<���>
					btnOKUpd.Text = "���";
					break;
			}
		}
		
		/// <summary>
		/// �������ܣ��ѽ����ϵ��������ݴ����������
		/// </summary>
		/// <param name="pobjActionFormPropertys">���ݴ����Ŀ�������</param>
		private void PutDataToActionFormPropertysClass(clsActionFormPropertysEN pobjActionFormPropertys)
		{
			pobjActionFormPropertys.ActionFormId = ActionFormId;
            pobjActionFormPropertys.UserId = clsCommonSession.UserId;
			pobjActionFormPropertys.UpdDate = clsGeneralTab.getTodayStr_S(0);
			pobjActionFormPropertys.PropertyName = wucActionFormPropertys1.PropertyName;
			pobjActionFormPropertys.JavaTypeId = wucActionFormPropertys1.JavaTypeId;
			pobjActionFormPropertys.Memo = wucActionFormPropertys1.Memo;
		}

		protected void dgActionFormPropertys_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
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
			if (strSortActionFormPropertysBy == "") return ;
			if(e.Item.ItemType==ListItemType.Header)//����ؼ��Ƿ�Ϊҳü��
			{
				string strSortEx;
				for(int i=0;i<this.dgActionFormPropertys.Columns.Count;i++)
				{
					strSortEx = this.dgActionFormPropertys.Columns[i].SortExpression;
					if (strSortEx == "") continue;
					intIndex = strSortActionFormPropertysBy.IndexOf(strSortEx + " ");
					if(intIndex >=0)  //��ͼ״̬��������ʽ�Ƿ�Ϊ���е��ֶΣ�
					{
						Label lblSort=new Label();
						lblSort.Font.Name="webdings";//�������壬��"webdings"��5�������ǣ�6�������ǣ�
						intIndex = strSortActionFormPropertysBy.IndexOf("Asc");
						lblSort.Text=(intIndex>0?" 5":" 6");//�Ƿ�Ϊ���򣬶���Ϊstring�ͣ�
						e.Item.Cells[i].Controls.Add(lblSort);//��������ĵ�i����Ԫ��������һ�ؼ���
						break;
					}
				}
			}
		}

		protected void dgActionFormPropertys_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			long lngmId;
			string strCommandName;
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.SelectedItem ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
				strCommandName = ((LinkButton)e.CommandSource).CommandName;
				lngmId = long.Parse(e.Item.Cells[1].Text);
				switch(strCommandName)
				{
					case "Delete":
						clsActionFormPropertysBL.DelRecord(lngmId);
						BindDg_ActionFormPropertys();
						break;
						// Add other cases here, if there are multiple ButtonColumns in 
						// the DataGrid control.
					case "Update":
						//�������裺���ܹ�2����
						//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
						//2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�

						//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
						ShowData(lngmId);
						//2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
						clsPubFun.SetButtonEnabled(btnOKUpd, true);
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
					Set_DataGridAllChecked(dgActionFormPropertys, true);
					lbSelAll.Text = "��ѡ";
				}
				else if (lbSelAll.Text == "��ѡ")
				{
					Set_DataGridAllChecked(dgActionFormPropertys, false);
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
			btnOKUpd.Text = "ȷ�����";

        }


        //��ǰ��¼��
        protected void btnExportExcel4Dg_Click(object sender, System.EventArgs e)
		{
			//	1����Ͻ�����������
			string strWhereCond = CombineActionFormPropertysCondition();
			//	2��������������ȡ�ñ�����������DataTable��
			System.Data.DataTable objDT = clsActionFormPropertysBL.GetDataTable_ActionFormPropertys(strWhereCond);
			List<string> arrCnName = new List<string>();
			List<string> arrColName = new List<string>();
			string strFileName = "ActionFormPropertys��Ϣ����.xls";
			string strFolderName;
			string strDownLoadFileName;
			arrColName.Add("mId"); arrCnName.Add("mId");
			arrColName.Add("ActionFormId"); arrCnName.Add("ActionFormId");
			arrColName.Add("PropertyName"); arrCnName.Add("��������");
			arrColName.Add("JavaTypeId"); arrCnName.Add("Java����Id");
			arrColName.Add("UpdDate"); arrCnName.Add("UpdDate");
			arrColName.Add("UserId"); arrCnName.Add("�û�ID");
			arrColName.Add("Memo"); arrCnName.Add("˵��");
			strFolderName = Server.MapPath("/com.taishsoft.shnu.humansys") +  "\\TempFiles\\";
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
            List<string> arrmId = clsCommForWebForm.GetAllCheckedItemFromDg2(dgActionFormPropertys, "chkCheckRec");
			if (arrmId == null || arrmId.Count == 0) 
			{
				lblMsg.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
				return ;
			}
			lblMsg.Text = "";
			clsActionFormPropertysBL.DelActionFormPropertyss(arrmId);
			BindDg_ActionFormPropertys();
		}

		
		//��ǰ��¼��
		protected void btnUpdate4Dg_Click(object sender, System.EventArgs e)
		{
			string strmId =clsCommForWebForm.GetFirstCheckedItemFromDg(dgActionFormPropertys);
			long lngmId;
			lngmId = long.Parse(strmId);
			if (strmId == null || strmId.Trim().Length == 0) 
			{
				lblMsg.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
				return ;
			}
			lblMsg.Text = "";
			//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
			ShowData(lngmId);
			//2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
			clsPubFun.SetButtonEnabled(btnOKUpd, true);
			btnOKUpd.Text = "ȷ���޸�";	
		}
		
		public System.Data.DataTable GetJavaTypeId()
		{
			//��ȡĳѧԺ����רҵ��Ϣ
			string strSQL = "select JavaTypeId, JavaTypeName from JavaType ";
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}
		public void BindDdl_JavaTypeId(System.Web.UI.WebControls.DropDownList objDDL)
		{
			//Ϊ����Դ�ڱ����������������
			ListItem li=new ListItem("��ѡ��...","0");
			System.Data.DataTable objDT = GetJavaTypeId();
			objDDL.DataValueField="JavaTypeId";
			objDDL.DataTextField="JavaTypeName";
			objDDL.DataSource = objDT;
			objDDL.DataBind();
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
		}
		
		protected void dgActionFormPropertys_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
		{
			int intIndex;
			//�ж��Ƿ����µ������ֶ�
			intIndex = strSortActionFormPropertysBy.IndexOf(e.SortExpression);
			if (intIndex == -1)
			{
				strSortActionFormPropertysBy = e.SortExpression + " Asc";
				BindDg_ActionFormPropertys();
				return ;
			}
			//���ԭ��������
			intIndex = strSortActionFormPropertysBy.IndexOf(" Asc");
			if (intIndex == -1)		//���ԭ���������������Ϊ����
			{
				strSortActionFormPropertysBy = e.SortExpression + " Asc";
			}
			else			///��������Ϊ����
			{
				strSortActionFormPropertysBy = e.SortExpression + " Desc";
			}
			BindDg_ActionFormPropertys();
		}

		private string strSortActionFormPropertysBy
		{
			get
			{
				string sSortActionFormPropertysBy;
				sSortActionFormPropertysBy = (string)ViewState["SortActionFormPropertysBy"];
				if (sSortActionFormPropertysBy==null) 
				{
					sSortActionFormPropertysBy = "";
				}
				return sSortActionFormPropertysBy;
			}
			set
			{
				string sSortActionFormPropertysBy = value;
				ViewState.Add("SortActionFormPropertysBy", sSortActionFormPropertysBy);
			}
		}

		//���ɸ������SESSION������Ժ���
		protected void btnActionFormPropertysPrevPage_Click(object sender, System.EventArgs e)
		{
			this.dgActionFormPropertys.CurrentPageIndex -=1; 
			this.BindDg_ActionFormPropertys(); 
		}

		protected void btnActionFormPropertysNextPage_Click(object sender, System.EventArgs e)
		{
			this.dgActionFormPropertys.CurrentPageIndex +=1; 
			this.BindDg_ActionFormPropertys(); 
		}

		protected void btnActionFormPropertysJumpPage_Click(object sender, System.EventArgs e)
		{
			if(this.txtActionFormPropertysJump2Page.Text.Trim()!="" && 
				int.Parse(this.txtActionFormPropertysJump2Page.Text)>0 && 
				int.Parse(this.txtActionFormPropertysJump2Page.Text)-1<this.dgActionFormPropertys.PageCount) 
			{ 
				this.dgActionFormPropertys.CurrentPageIndex=int.Parse(this.txtActionFormPropertysJump2Page.Text)-1; 
			} 
			this.BindDg_ActionFormPropertys();
		}

		protected void btnCopyRelaFldProp_Click(object sender, System.EventArgs e)
		{
			StringBuilder sbWhereCond = new StringBuilder();
			string strViewGroupId = clsActionFormBL.GetObjByActionFormId(ActionFormId).ViewGroupId;
			try
			{
                clsViewGroupENEx objViewGroupENEx = (clsViewGroupENEx)clsViewGroupBL.GetObjByViewGroupId(strViewGroupId);
				//			objViewGroupENEx.initEditRegionFldSet();
				clsActionFormPropertysEN objActionFormPropertys = new clsActionFormPropertysEN();
				foreach(clsEditRegionFldsENEx objEditRegionFldsEx in objViewGroupENEx.arrDetailFldSet)
				{
					objActionFormPropertys.ActionFormId = ActionFormId;
                    objActionFormPropertys.UserId = clsCommonSession.UserId;
					objActionFormPropertys.UpdDate = clsGeneralTab.getTodayStr_S(0);
					objActionFormPropertys.PropertyName = objEditRegionFldsEx.ObjFieldTabENEx.FldName.ToLower();
					objActionFormPropertys.JavaTypeId = "01";
					objActionFormPropertys.Memo = "����ؽ����ֶ��и��ƹ���!";
					if (CheckDuplicate(objActionFormPropertys) == false)
					{
                        clsActionFormPropertysBL .AddNewRecordBySql2(objActionFormPropertys);
					}

				}
				BindDg_ActionFormPropertys();
			}
			catch (Exception objException)
			{
				string strMsg = objException.Message;
				LogError(objException);
				clsCommonJsFunc.Alert(this, strMsg);
				return;
			}

		}
		private bool CheckDuplicate(clsActionFormPropertysEN objActionFormPropertys)
		{
			StringBuilder sbWhereCond = new StringBuilder();
			sbWhereCond.AppendFormat("ActionFormId = '{0}'", objActionFormPropertys.ActionFormId);
			sbWhereCond.AppendFormat("And PropertyName = '{0}'", objActionFormPropertys.PropertyName);
            return clsActionFormPropertysBL.IsExistRecord(sbWhereCond.ToString());
		}
		protected void LogError(Exception  objException  )
		{
			//Log the error information to the Application Log
			string strLogMsg ;
			string strModuleName = this.GetType().ToString();
			try
			{
 
				strLogMsg = "An error occurred in the following module: "
					+ strModuleName +  "\r\nSource: " + objException.Source 

					+ "Message: " + objException.Message + "\r\n" 
					+ "Stack Trace:  " + objException.StackTrace 

					+ "Target Site:  " + objException.TargetSite.ToString();
        
				//Write error to event log
				System.Diagnostics.EventLog.WriteEntry(strModuleName, strLogMsg, System.Diagnostics.EventLogEntryType.Error);
			}
			catch
			{
			}
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