
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
	/// wfmActionForward_QUDI ��ժҪ˵��������Q�����ѯ��U�����޸�
	/// </summary>
	public partial class wfmActionForward_QUDI : CommWebPageBase
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
				lblActionName.Text=  clsStrutsActionBL.GetObjByActionId(ActionId).ActionName;
				//1��Ϊ��������������Դ�����б�����
				strSortActionForwardBy = "ActionForwardId Asc";
				//2����ʾ�������ı�������DATAGRID��
				BindDg_ActionForward();
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



		private string ActionId
		{
			get
			{
				string strActionId;
				strActionId = (string)Session["ActionId"];
				if (strActionId==null) 
				{
					strActionId = "";
				}
				return strActionId;
			}
			set
			{
				string strActionId = value;
				Session.Add("ActionId", strActionId);
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
		private string CombineActionForwardCondition()
		{
			//ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
			//���� 1=1 && UserName = '����'
			
			string strWhereCond=" 1=1 ";
			strWhereCond +=" And ActionId = '"+ ActionId + "'";
			//����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
			if (this.txtForwardName_q.Text.Trim()!="")
			{
				strWhereCond += " And ForwardName like '%" + this.txtForwardName_q.Text.Trim()+"%'";
			}
			if (this.txtForwardPath_q.Text.Trim()!="")
			{
				strWhereCond += " And ForwardPath like '%" + this.txtForwardPath_q.Text.Trim()+"%'";
			}
			return strWhereCond;
		}
		///���ɰ�DATAGRID�Ĵ���
		/// <summary>
		/// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
		///			 ����ʾ��DATAGRID�С�
		/// </summary>
		private void BindDg_ActionForward()
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
			string strWhereCond = CombineActionForwardCondition();
			//	2��������������ȡ�ñ�����������DataTable��
			System.Data.DataTable objDT = clsActionForwardBL.GetDataTable(strWhereCond);
			//	3�����DATAGRID�ĵ�ǰҳ���Ƿ񳬳�DATAGRID��ҳ����Χ
			//		3.1 ���ȼ���ҳ����
			//		3.2 �����ǰҳ����ҳ����Ϊ���һҳ
			int intPages = CalcPages(objDT.Rows.Count, this.dgActionForward.PageSize);
			if (intPages==0) 
			{
				this.dgActionForward.CurrentPageIndex = 0;
			}
			else if (this.dgActionForward.CurrentPageIndex > intPages - 1) 
			{
				this.dgActionForward.CurrentPageIndex = intPages - 1;
			}
			//	4������DATAGRID������Դ(DataSource)��
			DataView objDV = objDT.DefaultView;
			objDV.Sort = strSortActionForwardBy;     ///ע����һ�д����п�����Ҫע�͵���Ŀǰ���н����ڵ����Ĳ�ѯ������������
			this.dgActionForward.DataSource=objDV;
			//	5����DATAGRID������DataTable��������ʾ��DATAGRID��
			this.dgActionForward.DataBind();

			
			//��ǰ��¼��
			this.lblActionForwardRecCount.Text = objDT.Rows.Count.ToString(); 
			//��ǰҳ��
			this.lblActionForwardAllPages.Text = this.dgActionForward.PageCount.ToString(); 
			//��ǰҳ����
			this.lblActionForwardCurrentPage.Text=(this.dgActionForward.CurrentPageIndex+1).ToString();
			//��ǰ����������ҳ����
			this.txtActionForwardJump2Page.Text=(this.dgActionForward.CurrentPageIndex+1).ToString();
			//�����ǰҳ����Ϊ0����<ǰһҳ>��ť��Ч
			if(this.dgActionForward.CurrentPageIndex==0) 
			{
				btnActionForwardPrevPage.Enabled=false; 
			}
			else 
			{ 
				btnActionForwardPrevPage.Enabled=true; 
			} 
			//�����ǰҳ������Ϊ���һҳ����<ǰһҳ>��ť��Ч
			if(this.dgActionForward.CurrentPageIndex==this.dgActionForward.PageCount-1) 
			{ 
				btnActionForwardNextPage.Enabled=false; 
			} 
			else 
			{ 
				btnActionForwardNextPage.Enabled=true; 
			} 
			//7�������沿����ʾ����ʾ �������ǰDataGrid�еļ�¼��Ϊ0������ʾ��ǰ����ҳ������
			if(objDT.Rows.Count>0) 
			{ 
				this.tabActionForwardJumpPage.Visible = true; 
			} 
			else 
			{ 
				this.tabActionForwardJumpPage.Visible = false; 
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
			this.dgActionForward.CurrentPageIndex=0;
			//�ѱ��¼��������ʾ��DATAGRID��
			BindDg_ActionForward();
		}
		/// <summary>
		/// �������ܣ��¼��������ڸ���DATAGRID�ĵ�ǰҳ����ʱ�����ĺ�����
		///			  ���幦����������ʾ��ҳ(������ҳ����)�����ݡ�
		/// </summary>
		/// <param name="source"></param>
		/// <param name="e"></param>
		protected void dgActionForward_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			//�������裺����2����
			//1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
			//2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ

			//1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
			this.dgActionForward.CurrentPageIndex=e.NewPageIndex;
			//2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ
			BindDg_ActionForward();
		}
		/// <summary>
		/// �������ܣ����Ըùؼ��ֵļ�¼������ʾ�ڽ����ϣ�
		///������     �������ǰ�ֵ������ؼ���
		/// </summary>
		/// <param name="lngActionForwardId">���¼�Ĺؼ��֣���ʾ�ñ�ؼ��ֵ�����</param>
		private void ShowData(long lngActionForwardId)
		{
			//�������裺
			//1�����ؼ����Ƿ�Ϊ�գ�
			//2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
			//3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
			//4����ȡ�������������ԣ�
			//5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���

			//1�����ؼ����Ƿ�Ϊ�գ�
			if (lngActionForwardId == 0) return ;		//����ؼ���Ϊ�վͷ����˳�
			//2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
			if (clsActionForwardBL.IsExist(lngActionForwardId) == false)		//���ùؼ��ֵļ�¼�Ƿ����
			{
				string ss = "�ؼ���Ϊ��" + lngActionForwardId + "�Ĳ�����!";
				clsCommonJsFunc.Alert(this, ss);
				return ;
			}
			//3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
			clsActionForwardEN objActionForward = new clsActionForwardEN(lngActionForwardId);
            //4����ȡ�������������ԣ�
            clsActionForwardBL .GetActionForward(ref objActionForward);
			Session.Add("objActionForward", objActionForward);
			//5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���
			GetDataFromActionForwardClass(objActionForward);
		}
		///���ɴ��߼�������ݴ��䵽�����ĺ�������
		/// <summary>
		/// �������ܣ�������������������ʾ��������
		///ע�⣺��������������򣬲�����һ��������������ϵ�ģ�����Ϊһ��������ֵ��Ȼ����Ϊ����������ֵ
		///      ������������ݿ�ʱ����Ӧ��һ���ֶ���ǰ�������ֶ��ں�
		/// </summary>
		/// <param name="pobjActionForward">��ʵ�������</param>
		private void GetDataFromActionForwardClass(clsActionForwardEN pobjActionForward)
		{
//			wucActionForward1.ActionId = pobjActionForward.ActionId;
			wucActionForward1.ForwardName = pobjActionForward.ForwardName;
			wucActionForward1.ForwardPath = pobjActionForward.ForwardPath;
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
			clsActionForwardEN objActionForward;
			Button btnTemp;
			btnTemp = (Button) sender;
			strCommandText = btnTemp.Text;
			switch(strCommandText)
			{
				case "���":
					btnOKUpd.Text = "ȷ�����";
                    //wucActionForward1.ActionForwardId = clsActionForward.GetMaxStrId("ActionForward","ActionForwardId", 8, "");
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
					if (!wucActionForward1.IsValid(ref strResult))
					{
						lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
						return ;
					}
					//2��������󲢳�ʼ������
					//clsActionForwardEN objActionForward;	//�������
					objActionForward = new clsActionForwardEN();	//��ʼ���¶���
					//3���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
					//4����ֵ�ӽ���㴫���߼��������ʵ���
					PutDataToActionForwardClass(objActionForward);		//�ѽ����ֵ����
					//5����鴫��ȥ�Ķ��������Ƿ�Ϸ�
					
                    try
                    {
                        clsActionForwardBL .CheckPropertyNew(objActionForward);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
				
					//6��������ʵ�������ݴ��������ݿ���
					if (clsActionForwardBL .AddNewRecordBySql2(objActionForward) == false) 
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
					BindDg_ActionForward();
					wucActionForward1.Clear();		//��տؼ�������
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
					if (!wucActionForward1.IsValid(ref strResult))
					{
						lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
						return ;
					}
					//2����ֵ�ӽ���㴫���߼��������ʵ���
					objActionForward = (clsActionForwardEN) Session["objActionForward"];
					PutDataToActionForwardClass(objActionForward);		//�ѽ����ֵ����
					//3����鴫��ȥ�Ķ��������Ƿ�Ϸ�
					

                    try
                    {
                        clsActionForwardBL.CheckPropertyNew(objActionForward);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
				
					//4��������ʵ���������޸�ͬ�������ݿ���
					if (clsActionForwardBL .UpdateBySql2(objActionForward) == false) 
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
					BindDg_ActionForward();
					wucActionForward1.Clear();//��տؼ��е�����
					//�ָ�<ȷ���޸�>���<���>
					btnOKUpd.Text = "���";
					break;
			}
		}
		
		/// <summary>
		/// �������ܣ��ѽ����ϵ��������ݴ����������
		/// </summary>
		/// <param name="pobjActionForward">���ݴ����Ŀ�������</param>
		private void PutDataToActionForwardClass(clsActionForwardEN pobjActionForward)
		{
     		pobjActionForward.ActionId = (string)Session["ActionId"];
			pobjActionForward.ForwardName = wucActionForward1.ForwardName;
			pobjActionForward.ForwardPath = wucActionForward1.ForwardPath;
		}

		protected void dgActionForward_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
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
			if (strSortActionForwardBy == "") return ;
			if(e.Item.ItemType==ListItemType.Header)//����ؼ��Ƿ�Ϊҳü��
			{
				string strSortEx;
				for(int i=0;i<this.dgActionForward.Columns.Count;i++)
				{
					strSortEx = this.dgActionForward.Columns[i].SortExpression;
					if (strSortEx == "") continue;
					intIndex = strSortActionForwardBy.IndexOf(strSortEx + " ");
					if(intIndex >=0)  //��ͼ״̬��������ʽ�Ƿ�Ϊ���е��ֶΣ�
					{
						Label lblSort=new Label();
						lblSort.Font.Name="webdings";//�������壬��"webdings"��5�������ǣ�6�������ǣ�
						intIndex = strSortActionForwardBy.IndexOf("Asc");
						lblSort.Text=(intIndex>0?" 5":" 6");//�Ƿ�Ϊ���򣬶���Ϊstring�ͣ�
						e.Item.Cells[i].Controls.Add(lblSort);//��������ĵ�i����Ԫ��������һ�ؼ���
						break;
					}
				}
			}
		}

		protected void dgActionForward_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			long lngActionForwardId;
			string strCommandName;
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.SelectedItem ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
				strCommandName = ((LinkButton)e.CommandSource).CommandName;
				lngActionForwardId = long.Parse(e.Item.Cells[1].Text);
				switch(strCommandName)
				{
					case "Delete":
						clsActionForwardBL.DelRecord(lngActionForwardId);
						BindDg_ActionForward();
						break;
						// Add other cases here, if there are multiple ButtonColumns in 
						// the DataGrid control.
					case "Update":
						//�������裺���ܹ�2����
						//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
						//2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�

						//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
						ShowData(lngActionForwardId);
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
					Set_DataGridAllChecked(dgActionForward, true);
					lbSelAll.Text = "��ѡ";
				}
				else if (lbSelAll.Text == "��ѡ")
				{
					Set_DataGridAllChecked(dgActionForward, false);
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
            //wucActionForward1.ActionForwardId = clsActionForward.GetMaxStrId("ActionForward","ActionForwardId", 8, "");
        }


        //��ǰ��¼��
        protected void btnExportExcel4Dg_Click(object sender, System.EventArgs e)
		{
			//	1����Ͻ�����������
			string strWhereCond = CombineActionForwardCondition();
			//	2��������������ȡ�ñ�����������DataTable��
			System.Data.DataTable objDT = clsActionForwardBL.GetDataTable_ActionForward(strWhereCond);
			List<string> arrCnName = new List<string>();
			List<string> arrColName = new List<string>();
			string strFileName = "ActionForward��Ϣ����.xls";
			string strFolderName;
			string strDownLoadFileName;
			arrColName.Add("ActionForwardId"); arrCnName.Add("ActionForwardId");
			arrColName.Add("ActionId"); arrCnName.Add("ActionId");
			arrColName.Add("ForwardName"); arrCnName.Add("Forward����");
			arrColName.Add("ForwardPath"); arrCnName.Add("Forward·��");
			strFolderName = Server.MapPath("~") +  "\\TempFiles\\";
			strDownLoadFileName = strFolderName + strFileName;
            if (clsPubVar.InitExcelFile(this, strFolderName, strDownLoadFileName) == false)
            {
                return;
            }

            //GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4Odbc(objDT, arrColName, arrCnName, strDownLoadFileName);
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
			List<string> arrActionForwardId =clsCommForWebForm. GetAllCheckedItemFromDg2(dgActionForward, "chkCheckRec");
			if (arrActionForwardId == null || arrActionForwardId.Count == 0) 
			{
				lblMsg.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
				return ;
			}
			lblMsg.Text = "";
			//long lngActionForwardId;
			//lngActionForwardId = long.Parse(strActionForwardId);
			clsActionForwardBL.DelActionForwards(arrActionForwardId);
			BindDg_ActionForward();
		}

		
		//��ǰ��¼��
		protected void btnUpdate4Dg_Click(object sender, System.EventArgs e)
		{
			string strActionForwardId =clsCommForWebForm.GetFirstCheckedItemFromDg(dgActionForward);
			long lngActionForwardId;
			lngActionForwardId = long.Parse(strActionForwardId);
			if (strActionForwardId == null || strActionForwardId.Trim().Length == 0) 
			{
				lblMsg.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
				return ;
			}
			lblMsg.Text = "";
			//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
			ShowData(lngActionForwardId);
			//2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
			clsPubFun.SetButtonEnabled(btnOKUpd, true);
			btnOKUpd.Text = "ȷ���޸�";	
		}
		
		public System.Data.DataTable GetActionId()
		{
			//��ȡĳѧԺ����רҵ��Ϣ
			string strSQL = "select ActionId, ActionName from StrutsAction ";
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}
		public void BindDdl_ActionId(System.Web.UI.WebControls.DropDownList objDDL)
		{
			//Ϊ����Դ�ڱ����������������
			ListItem li=new ListItem("��ѡ��...","0");
			System.Data.DataTable objDT = GetActionId();
			objDDL.DataValueField="ActionId";
			objDDL.DataTextField="ActionName";
			objDDL.DataSource = objDT;
			objDDL.DataBind();
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
		}
		
		protected void dgActionForward_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
		{
			int intIndex;
			//�ж��Ƿ����µ������ֶ�
			intIndex = strSortActionForwardBy.IndexOf(e.SortExpression);
			if (intIndex == -1)
			{
				strSortActionForwardBy = e.SortExpression + " Asc";
				BindDg_ActionForward();
				return ;
			}
			//���ԭ��������
			intIndex = strSortActionForwardBy.IndexOf(" Asc");
			if (intIndex == -1)		//���ԭ���������������Ϊ����
			{
				strSortActionForwardBy = e.SortExpression + " Asc";
			}
			else			///��������Ϊ����
			{
				strSortActionForwardBy = e.SortExpression + " Desc";
			}
			BindDg_ActionForward();
		}

		private string strSortActionForwardBy
		{
			get
			{
				string sSortActionForwardBy;
				sSortActionForwardBy = (string)ViewState["SortActionForwardBy"];
				if (sSortActionForwardBy==null) 
				{
					sSortActionForwardBy = "";
				}
				return sSortActionForwardBy;
			}
			set
			{
				string sSortActionForwardBy = value;
				ViewState.Add("SortActionForwardBy", sSortActionForwardBy);
			}
		}

		//���ɸ������SESSION������Ժ���
		protected void btnActionForwardPrevPage_Click(object sender, System.EventArgs e)
		{
			this.dgActionForward.CurrentPageIndex -=1; 
			this.BindDg_ActionForward(); 
		}

		protected void btnActionForwardNextPage_Click(object sender, System.EventArgs e)
		{
			this.dgActionForward.CurrentPageIndex +=1; 
			this.BindDg_ActionForward(); 
		}

		protected void btnActionForwardJumpPage_Click(object sender, System.EventArgs e)
		{
			if(this.txtActionForwardJump2Page.Text.Trim()!="" && 
				int.Parse(this.txtActionForwardJump2Page.Text)>0 && 
				int.Parse(this.txtActionForwardJump2Page.Text)-1<this.dgActionForward.PageCount) 
			{ 
				this.dgActionForward.CurrentPageIndex=int.Parse(this.txtActionForwardJump2Page.Text)-1; 
			} 
			this.BindDg_ActionForward();
		}

		protected void btnGetRelaForward_Click(object sender, System.EventArgs e)
		{
			StringBuilder sbWhereCond = new StringBuilder();
			string strViewGroupId = clsStrutsActionBL.GetObjByActionId(ActionId).ViewGroupId;

            clsViewGroupENEx objViewGroupENEx = (clsViewGroupENEx)clsViewGroupBL.GetObjByViewGroupId(strViewGroupId);
            clsViewGroupBLEx.initViewRelaTabFldSet(objViewGroupENEx);
			string strTabName_FstLCase = objViewGroupENEx.objINPrjTab.TabName;
			strTabName_FstLCase = clsString.FstLcaseS(strTabName_FstLCase);
			clsActionForwardEN objActionForward = new clsActionForwardEN();
			//��ӽ���
			objActionForward.ActionId = ActionId;
			objActionForward.ForwardName = "add"  + objViewGroupENEx.objINPrjTab.TabName;
			objActionForward.ForwardPath = objViewGroupENEx.ActionPath + "/" + strTabName_FstLCase + "_add.jsp";
			
			sbWhereCond.AppendFormat("ActionId = '{0}'", ActionId);
			sbWhereCond.AppendFormat("And ForwardName = '{0}'", objActionForward.ForwardName);
            if (clsActionForwardBL.IsExistRecord(sbWhereCond.ToString()) == false)
			{
				clsActionForwardBL .AddNewRecordBySql2(objActionForward);
			}
			//�б����
			objActionForward.ActionId = ActionId;
			objActionForward.ForwardName = "list"  + objViewGroupENEx.objINPrjTab.TabName;
			objActionForward.ForwardPath = objViewGroupENEx.ActionPath + "/" + strTabName_FstLCase + "_list.jsp";
			sbWhereCond = new StringBuilder();
			sbWhereCond.AppendFormat("ActionId = '{0}'", ActionId);
			sbWhereCond.AppendFormat("And ForwardName = '{0}'", objActionForward.ForwardName);
            if (clsActionForwardBL.IsExistRecord(sbWhereCond.ToString()) == false)
			{
                clsActionForwardBL .AddNewRecordBySql2(objActionForward);
			}

			//��ϸ��Ϣ����
			objActionForward.ActionId = ActionId;
			objActionForward.ForwardName = "detail"  + objViewGroupENEx.objINPrjTab.TabName;
			objActionForward.ForwardPath = objViewGroupENEx.ActionPath + "/" + strTabName_FstLCase + "_detail.jsp";
			sbWhereCond = new StringBuilder();
			sbWhereCond.AppendFormat("ActionId = '{0}'", ActionId);
			sbWhereCond.AppendFormat("And ForwardName = '{0}'", objActionForward.ForwardName);
            if (clsActionForwardBL.IsExistRecord(sbWhereCond.ToString()) == false)
			{
				clsActionForwardBL .AddNewRecordBySql2(objActionForward);
			}
			//�޸Ľ���
			objActionForward.ActionId = ActionId;
			objActionForward.ForwardName = "update"  + objViewGroupENEx.objINPrjTab.TabName;
			objActionForward.ForwardPath = objViewGroupENEx.ActionPath + "/" + strTabName_FstLCase + "_update.jsp";
			sbWhereCond = new StringBuilder();
			sbWhereCond.AppendFormat("ActionId = '{0}'", ActionId);
			sbWhereCond.AppendFormat("And ForwardName = '{0}'", objActionForward.ForwardName);
			if (clsActionForwardBL.IsExistRecord(sbWhereCond.ToString()) == false)
			{
				clsActionForwardBL .AddNewRecordBySql2(objActionForward);
			}

			//��ѯ����
			objActionForward.ActionId = ActionId;
			objActionForward.ForwardName = "query"  + objViewGroupENEx.objINPrjTab.TabName;
			objActionForward.ForwardPath = objViewGroupENEx.ActionPath + "/" + strTabName_FstLCase + "_query.jsp";
			sbWhereCond = new StringBuilder();
			sbWhereCond.AppendFormat("ActionId = '{0}'", ActionId);
			sbWhereCond.AppendFormat("And ForwardName = '{0}'", objActionForward.ForwardName);
            if (clsActionForwardBL.IsExistRecord(sbWhereCond.ToString()) == false)
			{
				clsActionForwardBL .AddNewRecordBySql2(objActionForward);
			}
			//�������
			objActionForward.ActionId = ActionId;
			objActionForward.ForwardName = "error";
			objActionForward.ForwardPath = "/myerror.jsp";
			sbWhereCond = new StringBuilder();
			sbWhereCond.AppendFormat("ActionId = '{0}'", ActionId);
			sbWhereCond.AppendFormat("And ForwardName = '{0}'", objActionForward.ForwardName);
            if (clsActionForwardBL.IsExistRecord(sbWhereCond.ToString()) == false)
			{
				clsActionForwardBL .AddNewRecordBySql2(objActionForward);
			}
			BindDg_ActionForward();
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