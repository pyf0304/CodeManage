
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

using AGC.Entity;

using AGC.BusinessLogic;using AGC.FunClass;


using com.taishsoft.common;

namespace AGC.Webform
{
	/// <summary>
	/// wfmActionFormType_QUDI ��ժҪ˵��������Q�����ѯ��U�����޸�
	/// </summary>
	public partial class wfmActionFormType_QUDI : CommWebPageBase
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
				strSortActionFormTypeBy = "ActionFormTypeId Asc";
				//2����ʾ�������ı�������DATAGRID��
				BindDg_ActionFormType();
				//3�����ñ�ؼ����ֿؼ���ReadOnly���ԣ�
				//   ʹֻ֮������Ϊ���޸Ĺ����йؼ����ǲ��ܱ��޸ĵġ�
				wucActionFormType1.SetKeyReadOnly(true);
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
		private string CombineActionFormTypeCondition()
		{
			//ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
			//���� 1=1 && UserName = '����'
			string strWhereCond=" 1=1 ";
			//����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
			if (this.txtActionFormTypeName_q.Text.Trim()!="")
			{
				strWhereCond += " And ActionFormTypeName like '%" + this.txtActionFormTypeName_q.Text.Trim()+"%'";
			}
			if (this.txtFormBeanClass_q.Text.Trim()!="")
			{
				strWhereCond += " And FormBeanClass like '%" + this.txtFormBeanClass_q.Text.Trim()+"%'";
			}
			return strWhereCond;
		}
		///���ɰ�DATAGRID�Ĵ���
		/// <summary>
		/// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
		///			 ����ʾ��DATAGRID�С�
		/// </summary>
		private void BindDg_ActionFormType()
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
			string strWhereCond = CombineActionFormTypeCondition();
			//	2��������������ȡ�ñ�����������DataTable��
			System.Data.DataTable objDT = clsActionFormTypeBL.GetDataTable_ActionFormType(strWhereCond);
			//	3�����DATAGRID�ĵ�ǰҳ���Ƿ񳬳�DATAGRID��ҳ����Χ
			//		3.1 ���ȼ���ҳ����
			//		3.2 �����ǰҳ����ҳ����Ϊ���һҳ
			int intPages = CalcPages(objDT.Rows.Count, this.dgActionFormType.PageSize);
			if (intPages==0) 
			{
				this.dgActionFormType.CurrentPageIndex = 0;
			}
			else if (this.dgActionFormType.CurrentPageIndex > intPages - 1) 
			{
				this.dgActionFormType.CurrentPageIndex = intPages - 1;
			}
			//	4������DATAGRID������Դ(DataSource)��
			DataView objDV = objDT.DefaultView;
			objDV.Sort = strSortActionFormTypeBy;     ///ע����һ�д����п�����Ҫע�͵���Ŀǰ���н����ڵ����Ĳ�ѯ������������
			this.dgActionFormType.DataSource=objDV;
			//	5����DATAGRID������DataTable��������ʾ��DATAGRID��
			this.dgActionFormType.DataBind();

			
			//��ǰ��¼��
			this.lblActionFormTypeRecCount.Text = objDT.Rows.Count.ToString(); 
			//��ǰҳ��
			this.lblActionFormTypeAllPages.Text = this.dgActionFormType.PageCount.ToString(); 
			//��ǰҳ����
			this.lblActionFormTypeCurrentPage.Text=(this.dgActionFormType.CurrentPageIndex+1).ToString();
			//��ǰ����������ҳ����
			this.txtActionFormTypeJump2Page.Text=(this.dgActionFormType.CurrentPageIndex+1).ToString();
			//�����ǰҳ����Ϊ0����<ǰһҳ>��ť��Ч
			if(this.dgActionFormType.CurrentPageIndex==0) 
			{
				btnActionFormTypePrevPage.Enabled=false; 
			}
			else 
			{ 
				btnActionFormTypePrevPage.Enabled=true; 
			} 
			//�����ǰҳ������Ϊ���һҳ����<ǰһҳ>��ť��Ч
			if(this.dgActionFormType.CurrentPageIndex==this.dgActionFormType.PageCount-1) 
			{ 
				btnActionFormTypeNextPage.Enabled=false; 
			} 
			else 
			{ 
				btnActionFormTypeNextPage.Enabled=true; 
			} 
			//7�������沿����ʾ����ʾ �������ǰDataGrid�еļ�¼��Ϊ0������ʾ��ǰ����ҳ������
			if(objDT.Rows.Count>0) 
			{ 
				this.tabActionFormTypeJumpPage.Visible = true; 
			} 
			else 
			{ 
				this.tabActionFormTypeJumpPage.Visible = false; 
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
			this.dgActionFormType.CurrentPageIndex=0;
			//�ѱ��¼��������ʾ��DATAGRID��
			BindDg_ActionFormType();
		}
		/// <summary>
		/// �������ܣ��¼��������ڸ���DATAGRID�ĵ�ǰҳ����ʱ�����ĺ�����
		///			  ���幦����������ʾ��ҳ(������ҳ����)�����ݡ�
		/// </summary>
		/// <param name="source"></param>
		/// <param name="e"></param>
		protected void dgActionFormType_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			//�������裺����2����
			//1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
			//2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ

			//1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
			this.dgActionFormType.CurrentPageIndex=e.NewPageIndex;
			//2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ
			BindDg_ActionFormType();
		}
		/// <summary>
		/// �������ܣ����Ըùؼ��ֵļ�¼������ʾ�ڽ����ϣ�
		///������     �������ǰ�ֵ������ؼ���
		/// </summary>
		/// <param name="strActionFormTypeId">���¼�Ĺؼ��֣���ʾ�ñ�ؼ��ֵ�����</param>
		private void ShowData(string strActionFormTypeId)
		{
			//�������裺
			//1�����ؼ����Ƿ�Ϊ�գ�
			//2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
			//3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
			//4����ȡ�������������ԣ�
			//5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���

			//1�����ؼ����Ƿ�Ϊ�գ�
			if (strActionFormTypeId == "") return ;		//����ؼ���Ϊ�վͷ����˳�
			//2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
			if (clsActionFormTypeBL.IsExist(strActionFormTypeId) == false)		//���ùؼ��ֵļ�¼�Ƿ����
			{
				string ss = "�ؼ���Ϊ��" + strActionFormTypeId + "�Ĳ�����!";
				clsCommonJsFunc.Alert(this, ss);
				return ;
			}
			//3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
			clsActionFormTypeEN objActionFormType = new clsActionFormTypeEN(strActionFormTypeId);
            //4����ȡ�������������ԣ�
            clsActionFormTypeBL .GetActionFormType(ref objActionFormType);
			Session.Add("objActionFormType", objActionFormType);
			//5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���
			GetDataFromActionFormTypeClass(objActionFormType);
		}
		///���ɴ��߼�������ݴ��䵽�����ĺ�������
		/// <summary>
		/// �������ܣ�������������������ʾ��������
		///ע�⣺��������������򣬲�����һ��������������ϵ�ģ�����Ϊһ��������ֵ��Ȼ����Ϊ����������ֵ
		///      ������������ݿ�ʱ����Ӧ��һ���ֶ���ǰ�������ֶ��ں�
		/// </summary>
		/// <param name="pobjActionFormType">��ʵ�������</param>
		private void GetDataFromActionFormTypeClass(clsActionFormTypeEN pobjActionFormType)
		{
			wucActionFormType1.ActionFormTypeId = pobjActionFormType.ActionFormTypeId;
			wucActionFormType1.ActionFormTypeName = pobjActionFormType.ActionFormTypeName;
			wucActionFormType1.FormBeanClass = pobjActionFormType.FormBeanClass;
			wucActionFormType1.Memo = pobjActionFormType.Memo;
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
			clsActionFormTypeEN objActionFormType;
			Button btnTemp;
			btnTemp = (Button) sender;
			strCommandText = btnTemp.Text;
			switch(strCommandText)
			{
				case "���":
					wucActionFormType1.SetKeyReadOnly(false);
					btnOKUpd.Text = "ȷ�����";
                    //wucActionFormType1.ActionFormTypeId = clsActionFormType.GetMaxStrId("ActionFormType","ActionFormTypeId", 2, "");
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
					if (!wucActionFormType1.IsValid(ref strResult))
					{
						lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
						return ;
					}
					//2��������󲢳�ʼ������
					//clsActionFormTypeEN objActionFormType;	//�������
					objActionFormType = new clsActionFormTypeEN(wucActionFormType1.ActionFormTypeId);	//��ʼ���¶���
					//3���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
					if (clsActionFormTypeBL.IsExist(wucActionFormType1.ActionFormTypeId))	//�ж��Ƿ�����ͬ�Ĺؼ���
					{
						strMsg = "�ؼ����ֶ�������ͬ��ֵ";
						clsCommonJsFunc.Alert(this, strMsg);
						return;
					}
					//4����ֵ�ӽ���㴫���߼��������ʵ���
					PutDataToActionFormTypeClass(objActionFormType);		//�ѽ����ֵ����
					//5����鴫��ȥ�Ķ��������Ƿ�Ϸ�
				
                    try
                    {
                        clsActionFormTypeBL .CheckPropertyNew(objActionFormType);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
					//6��������ʵ�������ݴ��������ݿ���
					if (clsActionFormTypeBL .AddNewRecordBySql2(objActionFormType) == false) 
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
					BindDg_ActionFormType();
					wucActionFormType1.Clear();		//��տؼ�������
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
					if (!wucActionFormType1.IsValid(ref strResult))
					{
						lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
						return ;
					}
					//2����ֵ�ӽ���㴫���߼��������ʵ���
					objActionFormType = (clsActionFormTypeEN) Session["objActionFormType"];
					PutDataToActionFormTypeClass(objActionFormType);		//�ѽ����ֵ����
					//3����鴫��ȥ�Ķ��������Ƿ�Ϸ�
					

                    try
                    {
                        clsActionFormTypeBL.CheckPropertyNew(objActionFormType);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
					//4��������ʵ���������޸�ͬ�������ݿ���
					if (clsActionFormTypeBL .UpdateBySql2(objActionFormType) == false) 
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
					BindDg_ActionFormType();
					wucActionFormType1.Clear();//��տؼ��е�����
					//�ָ�<ȷ���޸�>���<���>
					btnOKUpd.Text = "���";
					break;
			}
		}
		
		/// <summary>
		/// �������ܣ��ѽ����ϵ��������ݴ����������
		/// </summary>
		/// <param name="pobjActionFormType">���ݴ����Ŀ�������</param>
		private void PutDataToActionFormTypeClass(clsActionFormTypeEN pobjActionFormType)
		{
			pobjActionFormType.ActionFormTypeId = wucActionFormType1.ActionFormTypeId;
			pobjActionFormType.ActionFormTypeName = wucActionFormType1.ActionFormTypeName;
			pobjActionFormType.FormBeanClass = wucActionFormType1.FormBeanClass;
			pobjActionFormType.Memo = wucActionFormType1.Memo;
		}

		protected void dgActionFormType_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
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
			if (strSortActionFormTypeBy == "") return ;
			if(e.Item.ItemType==ListItemType.Header)//����ؼ��Ƿ�Ϊҳü��
			{
				string strSortEx;
				for(int i=0;i<this.dgActionFormType.Columns.Count;i++)
				{
					strSortEx = this.dgActionFormType.Columns[i].SortExpression;
					if (strSortEx == "") continue;
					intIndex = strSortActionFormTypeBy.IndexOf(strSortEx + " ");
					if(intIndex >=0)  //��ͼ״̬��������ʽ�Ƿ�Ϊ���е��ֶΣ�
					{
						Label lblSort=new Label();
						lblSort.Font.Name="webdings";//�������壬��"webdings"��5�������ǣ�6�������ǣ�
						intIndex = strSortActionFormTypeBy.IndexOf("Asc");
						lblSort.Text=(intIndex>0?" 5":" 6");//�Ƿ�Ϊ���򣬶���Ϊstring�ͣ�
						e.Item.Cells[i].Controls.Add(lblSort);//��������ĵ�i����Ԫ��������һ�ؼ���
						break;
					}
				}
			}
		}

		protected void dgActionFormType_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			string strActionFormTypeId;
			string strCommandName;
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.SelectedItem ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
				strCommandName = ((LinkButton)e.CommandSource).CommandName;
				strActionFormTypeId = e.Item.Cells[1].Text;
				switch(strCommandName)
				{
					case "Delete":
						clsActionFormTypeBL.DelRecord(strActionFormTypeId);
						BindDg_ActionFormType();
						break;
						// Add other cases here, if there are multiple ButtonColumns in 
						// the DataGrid control.
					case "Update":
						//�������裺���ܹ�2����
						//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
						//2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�

						//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
						ShowData(strActionFormTypeId);
						//2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
						clsPubFun.SetButtonEnabled(btnOKUpd, true);
						wucActionFormType1.SetKeyReadOnly(true);
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
					Set_DataGridAllChecked(dgActionFormType, true);
					lbSelAll.Text = "��ѡ";
				}
				else if (lbSelAll.Text == "��ѡ")
				{
					Set_DataGridAllChecked(dgActionFormType, false);
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
			wucActionFormType1.SetKeyReadOnly(false);
			btnOKUpd.Text = "ȷ�����";
            //wucActionFormType1.ActionFormTypeId = clsActionFormType.GetMaxStrId("ActionFormType","ActionFormTypeId", 2, "");
        }


        //��ǰ��¼��
        protected void btnExportExcel4Dg_Click(object sender, System.EventArgs e)
		{
			//	1����Ͻ�����������
			string strWhereCond = CombineActionFormTypeCondition();
			//	2��������������ȡ�ñ�����������DataTable��
			System.Data.DataTable objDT = clsActionFormTypeBL.GetDataTable_ActionFormType(strWhereCond);
			List<string> arrCnName = new List<string>();
			List<string> arrColName = new List<string>();
			string strFileName = "ActionFormType��Ϣ����.xls";
			string strFolderName;
			string strDownLoadFileName;
			arrColName.Add("ActionFormTypeId"); arrCnName.Add("ActionForm����ID");
			arrColName.Add("ActionFormTypeName"); arrCnName.Add("ActionForm��������");
			arrColName.Add("FormBeanClass"); arrCnName.Add("FormBean����");
			arrColName.Add("Memo"); arrCnName.Add("˵��");
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
			List<string > arrActionFormTypeId =clsCommForWebForm. GetAllCheckedItemFromDg2(dgActionFormType, "chkCheckRec");
			if (arrActionFormTypeId == null || arrActionFormTypeId.Count == 0) 
			{
				lblMsg.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
				return ;
			}
			lblMsg.Text = "";
			clsActionFormTypeBL.DelActionFormTypes(arrActionFormTypeId);
			BindDg_ActionFormType();
		}

		
		//��ǰ��¼��
		protected void btnUpdate4Dg_Click(object sender, System.EventArgs e)
		{
			string strActionFormTypeId =clsCommForWebForm.GetFirstCheckedItemFromDg(dgActionFormType);
			if (strActionFormTypeId == null || strActionFormTypeId.Trim().Length == 0) 
			{
				lblMsg.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
				return ;
			}
			lblMsg.Text = "";
			//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
			ShowData(strActionFormTypeId);
			//2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
			clsPubFun.SetButtonEnabled(btnOKUpd, true);
			wucActionFormType1.SetKeyReadOnly(true);
			btnOKUpd.Text = "ȷ���޸�";	
		}
		
		
		protected void dgActionFormType_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
		{
			int intIndex;
			//�ж��Ƿ����µ������ֶ�
			intIndex = strSortActionFormTypeBy.IndexOf(e.SortExpression);
			if (intIndex == -1)
			{
				strSortActionFormTypeBy = e.SortExpression + " Asc";
				BindDg_ActionFormType();
				return ;
			}
			//���ԭ��������
			intIndex = strSortActionFormTypeBy.IndexOf(" Asc");
			if (intIndex == -1)		//���ԭ���������������Ϊ����
			{
				strSortActionFormTypeBy = e.SortExpression + " Asc";
			}
			else			///��������Ϊ����
			{
				strSortActionFormTypeBy = e.SortExpression + " Desc";
			}
			BindDg_ActionFormType();
		}

		private string strSortActionFormTypeBy
		{
			get
			{
				string sSortActionFormTypeBy;
				sSortActionFormTypeBy = (string)ViewState["SortActionFormTypeBy"];
				if (sSortActionFormTypeBy==null) 
				{
					sSortActionFormTypeBy = "";
				}
				return sSortActionFormTypeBy;
			}
			set
			{
				string sSortActionFormTypeBy = value;
				ViewState.Add("SortActionFormTypeBy", sSortActionFormTypeBy);
			}
		}

		//���ɸ������SESSION������Ժ���
		protected void btnActionFormTypePrevPage_Click(object sender, System.EventArgs e)
		{
			this.dgActionFormType.CurrentPageIndex -=1; 
			this.BindDg_ActionFormType(); 
		}

		protected void btnActionFormTypeNextPage_Click(object sender, System.EventArgs e)
		{
			this.dgActionFormType.CurrentPageIndex +=1; 
			this.BindDg_ActionFormType(); 
		}

		protected void btnActionFormTypeJumpPage_Click(object sender, System.EventArgs e)
		{
			if(this.txtActionFormTypeJump2Page.Text.Trim()!="" && 
				int.Parse(this.txtActionFormTypeJump2Page.Text)>0 && 
				int.Parse(this.txtActionFormTypeJump2Page.Text)-1<this.dgActionFormType.PageCount) 
			{ 
				this.dgActionFormType.CurrentPageIndex=int.Parse(this.txtActionFormTypeJump2Page.Text)-1; 
			} 
			this.BindDg_ActionFormType();
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