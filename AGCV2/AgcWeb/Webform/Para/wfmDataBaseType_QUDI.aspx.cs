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

using AGC.Entity;

using AGC.BusinessLogic;using AGC.FunClass;


using com.taishsoft.common;

namespace AGC.Webform
{
	/// <summary>
	/// wfmDataBaseType_QUDI ��ժҪ˵��������Q�����ѯ��U�����޸�
	/// </summary>
	public partial class wfmDataBaseType_QUDI : CommWebPageBase
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
                DispObjList();
				//1��Ϊ��������������Դ�����б�����
				strSortDataBaseTypeBy = "DataBaseTypeId Asc";
				//2����ʾ�������ı�������DATAGRID��
				BindDg_DataBaseType();
				//3�����ñ�ؼ����ֿؼ���ReadOnly���ԣ�
				//   ʹֻ֮������Ϊ���޸Ĺ����йؼ����ǲ��ܱ��޸ĵġ�
				wucDataBaseType1.SetKeyReadOnly(true);
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
		private string CombineDataBaseTypeCondition()
		{
			//ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
			//���� 1=1 && UserName = '����'
			string strWhereCond=" 1=1 ";
			//����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
			if (this.txtDataBaseTypeIdq.Text.Trim()!="")
			{
				strWhereCond += " And DataBaseTypeId like '%" + this.txtDataBaseTypeIdq.Text.Trim()+"%'";
			}
			if (this.txtDataBaseTypeNameq.Text.Trim()!="")
			{
				strWhereCond += " And DataBaseTypeName like '%" + this.txtDataBaseTypeNameq.Text.Trim()+"%'";
			}
			return strWhereCond;
		}
		///���ɰ�DATAGRID�Ĵ���
		/// <summary>
		/// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
		///			 ����ʾ��DATAGRID�С�
		/// </summary>
		private void BindDg_DataBaseType()
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
			string strWhereCond = CombineDataBaseTypeCondition();
			//	2��������������ȡ�ñ�����������DataTable��
			System.Data.DataTable objDT = clsDataBaseTypeBL.GetDataTable_DataBaseType(strWhereCond);
			//	3�����DATAGRID�ĵ�ǰҳ���Ƿ񳬳�DATAGRID��ҳ����Χ
			//		3.1 ���ȼ���ҳ����
			//		3.2 �����ǰҳ����ҳ����Ϊ���һҳ
			int intPages = CalcPages(objDT.Rows.Count, this.dgDataBaseType.PageSize);
			if (intPages==0) 
			{
				this.dgDataBaseType.CurrentPageIndex = 0;
			}
			else if (this.dgDataBaseType.CurrentPageIndex > intPages - 1) 
			{
				this.dgDataBaseType.CurrentPageIndex = intPages - 1;
			}
			//	4������DATAGRID������Դ(DataSource)��
			DataView objDV = objDT.DefaultView;
			objDV.Sort = strSortDataBaseTypeBy;     ///ע����һ�д����п�����Ҫע�͵���Ŀǰ���н����ڵ����Ĳ�ѯ������������
			this.dgDataBaseType.DataSource=objDV;
			//	5����DATAGRID������DataTable��������ʾ��DATAGRID��
			this.dgDataBaseType.DataBind();

			
			//��ǰ��¼��
			this.lblDataBaseTypeRecCount.Text = objDT.Rows.Count.ToString(); 
			//��ǰҳ��
			this.lblDataBaseTypeAllPages.Text = this.dgDataBaseType.PageCount.ToString(); 
			//��ǰҳ����
			this.lblDataBaseTypeCurrentPage.Text=(this.dgDataBaseType.CurrentPageIndex+1).ToString();
			//��ǰ����������ҳ����
			this.txtDataBaseTypeJump2Page.Text=(this.dgDataBaseType.CurrentPageIndex+1).ToString();
			//�����ǰҳ����Ϊ0����<ǰһҳ>��ť��Ч
			if(this.dgDataBaseType.CurrentPageIndex==0) 
			{
				btnDataBaseTypePrevPage.Enabled=false; 
			}
			else 
			{ 
				btnDataBaseTypePrevPage.Enabled=true; 
			} 
			//�����ǰҳ������Ϊ���һҳ����<ǰһҳ>��ť��Ч
			if(this.dgDataBaseType.CurrentPageIndex==this.dgDataBaseType.PageCount-1) 
			{ 
				btnDataBaseTypeNextPage.Enabled=false; 
			} 
			else 
			{ 
				btnDataBaseTypeNextPage.Enabled=true; 
			} 
			//7�������沿����ʾ����ʾ �������ǰDataGrid�еļ�¼��Ϊ0������ʾ��ǰ����ҳ������
			if(objDT.Rows.Count>0) 
			{ 
				this.tabDataBaseTypeJumpPage.Visible = true; 
			} 
			else 
			{ 
				this.tabDataBaseTypeJumpPage.Visible = false; 
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
			this.dgDataBaseType.CurrentPageIndex=0;
			//�ѱ��¼��������ʾ��DATAGRID��
			BindDg_DataBaseType();
		}
		/// <summary>
		/// �������ܣ��¼��������ڸ���DATAGRID�ĵ�ǰҳ����ʱ�����ĺ�����
		///			  ���幦����������ʾ��ҳ(������ҳ����)�����ݡ�
		/// </summary>
		/// <param name="source"></param>
		/// <param name="e"></param>
		protected void dgDataBaseType_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			//�������裺����2����
			//1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
			//2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ

			//1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
			this.dgDataBaseType.CurrentPageIndex=e.NewPageIndex;
			//2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ
			BindDg_DataBaseType();
		}
		/// <summary>
		/// �������ܣ����Ըùؼ��ֵļ�¼������ʾ�ڽ����ϣ�
		///������     �������ǰ�ֵ������ؼ���
		/// </summary>
		/// <param name="strDataBaseTypeId">���¼�Ĺؼ��֣���ʾ�ñ�ؼ��ֵ�����</param>
		private void ShowData(string strDataBaseTypeId)
		{
			//�������裺
			//1�����ؼ����Ƿ�Ϊ�գ�
			//2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
			//3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
			//4����ȡ�������������ԣ�
			//5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���

			//1�����ؼ����Ƿ�Ϊ�գ�
			if (strDataBaseTypeId == "") return ;		//����ؼ���Ϊ�վͷ����˳�
			//2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
			if (clsDataBaseTypeBL.IsExist(strDataBaseTypeId) == false)		//���ùؼ��ֵļ�¼�Ƿ����
			{
				string ss = "�ؼ���Ϊ��" + strDataBaseTypeId + "�Ĳ�����!";
				clsCommonJsFunc.Alert(this, ss);
				return ;
			}
			//3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
			clsDataBaseTypeEN objDataBaseType = new clsDataBaseTypeEN(strDataBaseTypeId);
            //4����ȡ�������������ԣ�
            clsDataBaseTypeBL .GetDataBaseType(ref objDataBaseType);
			Session.Add("objDataBaseType", objDataBaseType);
			//5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���
			GetDataFromDataBaseTypeClass(objDataBaseType);
		}
		///���ɴ��߼�������ݴ��䵽�����ĺ�������
		/// <summary>
		/// �������ܣ�������������������ʾ��������
		///ע�⣺��������������򣬲�����һ��������������ϵ�ģ�����Ϊһ��������ֵ��Ȼ����Ϊ����������ֵ
		///      ������������ݿ�ʱ����Ӧ��һ���ֶ���ǰ�������ֶ��ں�
		/// </summary>
		/// <param name="pobjDataBaseType">��ʵ�������</param>
		private void GetDataFromDataBaseTypeClass(clsDataBaseTypeEN pobjDataBaseType)
		{
			wucDataBaseType1.DataBaseTypeId = pobjDataBaseType.DataBaseTypeId;

            wucDataBaseType1.DataBaseTypeName = pobjDataBaseType.DataBaseTypeName;
			wucDataBaseType1.Memo = pobjDataBaseType.Memo;
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
			clsDataBaseTypeEN objDataBaseType;
			Button btnTemp;
			btnTemp = (Button) sender;
			strCommandText = btnTemp.Text;
			switch(strCommandText)
			{
				case "���":
					AddDataBaseTypeRecord();
					break;				
				case "ȷ�����":
					//����һ������Ĳ���Ĵ��룬�����߼���̫�򵥣�
					//�Ͱ��߼���ϲ������Ʋ�,
					AddDataBaseTypeRecordSave();
					break;
				case "ȷ���޸�":
					//����һ��������޸ĵĴ��룬�����߼���̫�򵥣�
					//�Ͱ��߼���ϲ������Ʋ�,
					objDataBaseType = (clsDataBaseTypeEN) Session["objDataBaseType"];
					UpdateDataBaseTypeRecordSave(objDataBaseType);
					break;
			}
		}
		
		/// <summary>
		/// �������ܣ��ѽ����ϵ��������ݴ����������
		/// </summary>
		/// <param name="pobjDataBaseType">���ݴ����Ŀ�������</param>
		private void PutDataToDataBaseTypeClass(clsDataBaseTypeEN pobjDataBaseType)
		{
			pobjDataBaseType.DataBaseTypeId = wucDataBaseType1.DataBaseTypeId;
			pobjDataBaseType.DataBaseTypeName = wucDataBaseType1.DataBaseTypeName;
			pobjDataBaseType.Memo = wucDataBaseType1.Memo;
		}

		protected void dgDataBaseType_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
		{
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
				System.Web.UI.WebControls.LinkButton myDeleteButton;
				myDeleteButton = (System.Web.UI.WebControls.LinkButton)e.Item.FindControl("lbnDelete");
				myDeleteButton.Attributes.Add("onclick", "return confirm('�����Ҫɾ���� " + (e.Item.ItemIndex+1).ToString() + " ����');");

                System.Web.UI.WebControls.CheckBox myCheckBox;
                myCheckBox = (System.Web.UI.WebControls.CheckBox)e.Item.FindControl("chkCheckRec");
                if (myCheckBox != null)
                {
                    myCheckBox.Attributes.Add("onclick", "return CheckClick('" + (e.Item.ItemIndex + 1).ToString() + "');");
                }
			}
			int intIndex;
			if (strSortDataBaseTypeBy == "") return ;
			if(e.Item.ItemType==ListItemType.Header)//����ؼ��Ƿ�Ϊҳü��
			{
				string strSortEx;
				for(int i=0;i<this.dgDataBaseType.Columns.Count;i++)
				{
					strSortEx = this.dgDataBaseType.Columns[i].SortExpression;
					if (strSortEx == "") continue;
					intIndex = strSortDataBaseTypeBy.IndexOf(strSortEx + " ");
					if(intIndex >=0)  //��ͼ״̬��������ʽ�Ƿ�Ϊ���е��ֶΣ�
					{
						Label lblSort=new Label();
						lblSort.Font.Name="webdings";//�������壬��"webdings"��5�������ǣ�6�������ǣ�
						intIndex = strSortDataBaseTypeBy.IndexOf("Asc");
						lblSort.Text=(intIndex>0?" 5":" 6");//�Ƿ�Ϊ���򣬶���Ϊstring�ͣ�
						e.Item.Cells[i].Controls.Add(lblSort);//��������ĵ�i����Ԫ��������һ�ؼ���
						break;
					}
				}
			}
		}

		protected void dgDataBaseType_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			string strDataBaseTypeId;
			string strCommandName;
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.SelectedItem ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
				strCommandName = ((LinkButton)e.CommandSource).CommandName;
				strDataBaseTypeId = e.Item.Cells[1].Text;
				switch(strCommandName)
				{
					case "Delete":
						DeleteDataBaseTypeRecord(strDataBaseTypeId);
						break;
						// Add other cases here, if there are multiple ButtonColumns in 
						// the DataGrid control.
					case "Update":
						UpdateDataBaseTypeRecord(strDataBaseTypeId);
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
					Set_DataGridAllChecked(dgDataBaseType, true);
					lbSelAll.Text = "��ѡ";
				}
				else if (lbSelAll.Text == "��ѡ")
				{
					Set_DataGridAllChecked(dgDataBaseType, false);
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
			wucDataBaseType1.SetKeyReadOnly(false);
			btnOKUpd.Text = "ȷ�����";
			HiddenObjList();
			wucDataBaseType1.DataBaseTypeId = clsDataBaseTypeBL.GetMaxStrId_S();
			
		}


		
		//��ǰ��¼��
		protected void btnDelete4Dg_Click(object sender, System.EventArgs e)
		{
            List<string> arrDataBaseTypeId = clsCommForWebForm.GetAllCheckedItemFromDg2(dgDataBaseType, "chkCheckRec");
			if (arrDataBaseTypeId == null || arrDataBaseTypeId.Count == 0) 
			{
				lblMsg.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
				return ;
			}
			lblMsg.Text = "";
			clsDataBaseTypeBL.DelDataBaseTypes(arrDataBaseTypeId);
			BindDg_DataBaseType();
		}

		
		//��ǰ��¼��
		protected void btnUpdate4Dg_Click(object sender, System.EventArgs e)
		{
			HiddenObjList();
			string strDataBaseTypeId =clsCommForWebForm.GetFirstCheckedItemFromDg(dgDataBaseType);
			if (strDataBaseTypeId == null || strDataBaseTypeId.Trim().Length == 0) 
			{
				lblMsg.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
				return ;
			}
			lblMsg.Text = "";
			//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
			ShowData(strDataBaseTypeId);
			//2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
			clsPubFun.SetButtonEnabled(btnOKUpd, true);
			wucDataBaseType1.SetKeyReadOnly(true);
			btnOKUpd.Text = "ȷ���޸�";	
		}
		
		
		protected void dgDataBaseType_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
		{
			int intIndex;
			//�ж��Ƿ����µ������ֶ�
			intIndex = strSortDataBaseTypeBy.IndexOf(e.SortExpression);
			if (intIndex == -1)
			{
				strSortDataBaseTypeBy = e.SortExpression + " Asc";
				BindDg_DataBaseType();
				return ;
			}
			//���ԭ��������
			intIndex = strSortDataBaseTypeBy.IndexOf(" Asc");
			if (intIndex == -1)		//���ԭ���������������Ϊ����
			{
				strSortDataBaseTypeBy = e.SortExpression + " Asc";
			}
			else			///��������Ϊ����
			{
				strSortDataBaseTypeBy = e.SortExpression + " Desc";
			}
			BindDg_DataBaseType();
		}

		private string strSortDataBaseTypeBy
		{
			get
			{
				string sSortDataBaseTypeBy;
				sSortDataBaseTypeBy = (string)ViewState["SortDataBaseTypeBy"];
				if (sSortDataBaseTypeBy==null) 
				{
					sSortDataBaseTypeBy = "";
				}
				return sSortDataBaseTypeBy;
			}
			set
			{
				string sSortDataBaseTypeBy = value;
				ViewState.Add("SortDataBaseTypeBy", sSortDataBaseTypeBy);
			}
		}

		//���ɸ������SESSION������Ժ���
		protected void btnDataBaseTypePrevPage_Click(object sender, System.EventArgs e)
		{
			this.dgDataBaseType.CurrentPageIndex -=1; 
			this.BindDg_DataBaseType(); 
		}

		protected void btnDataBaseTypeNextPage_Click(object sender, System.EventArgs e)
		{
			this.dgDataBaseType.CurrentPageIndex +=1; 
			this.BindDg_DataBaseType(); 
		}

		protected void btnDataBaseTypeJumpPage_Click(object sender, System.EventArgs e)
		{
			if(this.txtDataBaseTypeJump2Page.Text.Trim()!="" && 
				int.Parse(this.txtDataBaseTypeJump2Page.Text)>0 && 
				int.Parse(this.txtDataBaseTypeJump2Page.Text)-1<this.dgDataBaseType.PageCount) 
			{ 
				this.dgDataBaseType.CurrentPageIndex=int.Parse(this.txtDataBaseTypeJump2Page.Text)-1; 
			} 
			this.BindDg_DataBaseType();
		}

		///���ɵĲ����¼׼�����̴���for C#
		private void AddDataBaseTypeRecord()
		{
			wucDataBaseType1.SetKeyReadOnly(false);
			btnOKUpd.Text = "ȷ�����";
            //wucDataBaseType1.DataBaseTypeId = clsDataBaseType.GetMaxStrId("DataBaseType","DataBaseTypeId", 2, "");
        }
        ///�����¼���̹��̴���for C#
        private void AddDataBaseTypeRecordSave()
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
			clsDataBaseTypeEN objDataBaseType;
			//1�����ؼ����������������Ƿ���ȷ
			if (!wucDataBaseType1.IsValid(ref strResult))
			{
				lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
				return ;
			}
			//2��������󲢳�ʼ������
			//clsDataBaseTypeEN objDataBaseType;	//�������
			objDataBaseType = new clsDataBaseTypeEN();	//��ʼ���¶���
			//3���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
			//if (clsDataBaseTypeBL.IsExist())	//�ж��Ƿ�����ͬ�Ĺؼ���
			//{
			//	strMsg = "�ؼ����ֶ�������ͬ��ֵ";
			//	clsCommonJsFunc.Alert(this, strMsg);
			//	return;
			//}
			//4����ֵ�ӽ���㴫���߼��������ʵ���
			PutDataToDataBaseTypeClass(objDataBaseType);		//�ѽ����ֵ����
			//5����鴫��ȥ�Ķ��������Ƿ�Ϸ�
			try
			{
                clsDataBaseTypeBL .CheckPropertyNew(objDataBaseType);
                //6��������ʵ�������ݴ��������ݿ���
                clsDataBaseTypeBL .AddNewRecordBySql2(objDataBaseType);
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
			BindDg_DataBaseType();
			wucDataBaseType1.Clear();		//��տؼ�������
			///�ָ�<ȷ�����>���<���>
			btnOKUpd.Text = "���";
		}
		///�����¼���̹��̴���for C#
		private void AddDataBaseTypeRecordSaveV5()
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
			clsDataBaseTypeEN objDataBaseType;
			//1�����ؼ����������������Ƿ���ȷ
			if (!wucDataBaseType1.IsValid(ref strResult))
			{
				lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
				return ;
			}
			//2��������󲢳�ʼ������
			//clsDataBaseTypeEN objDataBaseType;	//�������
			objDataBaseType = new clsDataBaseTypeEN();	//��ʼ���¶���
			//3���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
			//if (objDataBaseType.IsExist())	//�ж��Ƿ�����ͬ�Ĺؼ���
			//{
			//	strMsg = "�ؼ����ֶ�������ͬ��ֵ";
			//	clsCommonJsFunc.Alert(this, strMsg);
			//	return;
			//}
			//4����ֵ�ӽ���㴫���߼��������ʵ���
			PutDataToDataBaseTypeClass(objDataBaseType);		//�ѽ����ֵ����
			//5����鴫��ȥ�Ķ��������Ƿ�Ϸ�
			try
			{
                clsDataBaseTypeBL.CheckPropertyNew(objDataBaseType);
                //6��������ʵ�������ݴ��������ݿ���
                clsDataBaseTypeBL .AddNewRecordBySql2(objDataBaseType);
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
			BindDg_DataBaseType();
			wucDataBaseType1.Clear();		//��տؼ�������
			///�ָ�<ȷ�����>���<���>
			btnOKUpd.Text = "���";
		}
		///�����޸ļ�¼׼�����̴��� for C#
		private void UpdateDataBaseTypeRecord(string strDataBaseTypeId)
		{
			//�������裺���ܹ�2����
			//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
			//2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�

			//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
			ShowData(strDataBaseTypeId);
			//2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
			clsPubFun.SetButtonEnabled(btnOKUpd, true);
			wucDataBaseType1.SetKeyReadOnly(true);
			btnOKUpd.Text = "ȷ���޸�";
			lblMsg.Text = "";
		}
		///�޸Ĵ���׼�����̴��� for C#
		private void UpdateDataBaseTypeRecordSave(clsDataBaseTypeEN objDataBaseType)
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
			if (!wucDataBaseType1.IsValid(ref strResult))
			{
				lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
				return ;
			}
			//2����ֵ�ӽ���㴫���߼��������ʵ���
			PutDataToDataBaseTypeClass(objDataBaseType);		//�ѽ����ֵ����
			//3����鴫��ȥ�Ķ��������Ƿ�Ϸ�
			try
			{
                clsDataBaseTypeBL.CheckPropertyNew(objDataBaseType);
                //6��������ʵ�������ݴ��������ݿ���
                clsDataBaseTypeBL .UpdateBySql2(objDataBaseType);
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
			BindDg_DataBaseType();
			wucDataBaseType1.Clear();//��տؼ��е�����
			//�ָ�<ȷ���޸�>���<���>
			btnOKUpd.Text = "���";
		}
		///�޸Ĵ���׼�����̴��� for C#
		private void UpdateDataBaseTypeRecordSaveV5(clsDataBaseTypeEN objDataBaseType)
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
			if (!wucDataBaseType1.IsValid(ref strResult))
			{
				lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
				return ;
			}
			//2����ֵ�ӽ���㴫���߼��������ʵ���
			PutDataToDataBaseTypeClass(objDataBaseType);		//�ѽ����ֵ����
			//3����鴫��ȥ�Ķ��������Ƿ�Ϸ�
			try
			{
                clsDataBaseTypeBL.CheckPropertyNew(objDataBaseType);
                //6��������ʵ�������ݴ��������ݿ���
                clsDataBaseTypeBL.UpdateBySql2(objDataBaseType);
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
			BindDg_DataBaseType();
			wucDataBaseType1.Clear();//��տؼ��е�����
			//�ָ�<ȷ���޸�>���<���>
			btnOKUpd.Text = "���";
		}
		///ɾ����¼���̴���for C#
		private void DeleteDataBaseTypeRecord(string strDataBaseTypeId)
		{
			clsDataBaseTypeBL.DelRecord(strDataBaseTypeId);
			BindDg_DataBaseType();
		}

		private void DispObjList()
		{
			tabDataBaseTypeDataGrid.Visible = true; 
			tabDataBaseTypeJumpPage.Visible=true;
			tabEditDataBaseTypeRegion.Visible = false;   
		}

		private void HiddenObjList()
		{
			tabDataBaseTypeDataGrid.Visible = false;
			tabDataBaseTypeJumpPage.Visible=true;
			tabEditDataBaseTypeRegion.Visible = true;
		}

		protected void lbDispObjList_Click(object sender, System.EventArgs e)
		{
			DispObjList();
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