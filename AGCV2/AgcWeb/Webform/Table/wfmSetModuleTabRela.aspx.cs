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

using AGC.Entity;
using AGC.BusinessLogic;using AGC.FunClass;using AGC.BusinessLogicEx;

namespace AGC.Webform
{
	/// <summary>
	/// wfmFuncModule_QUDI ��ժҪ˵��������Q�����ѯ��U�����޸�
	/// </summary>
	public partial class wfmSetModuleTabRela : System.Web.UI.Page
	{

		
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// �ڴ˴������û������Գ�ʼ��ҳ��
			if (!IsPostBack)	///����������ǳ��α����ã������ǵ�����ť�¼�������
			{
                //1��Ϊ��������������Դ�����б�����
                //clsvPrjObjects4DdlBLEx.BindDdl_ObjId(ddlObjIdq, clsPubVar.CurrSelPrjId);

				strSortBy = "FuncModuleAgcId Asc";
				//2����ʾ�������ı�������DATAGRID��
				BindDg_FuncModule();
				BindDg_PrjTab4Sel();
				tabPrjTab4Sel.Visible = false;
				tabPrjTab.Visible = false;
			}
		}

		

		private string seFuncModuleAgcId
		{
			get
			{
				string strFuncModuleId;
				strFuncModuleId = (string)Session["FuncModuleAgcId4Qry"];
				if (strFuncModuleId==null) 
				{
					strFuncModuleId = "";
				}
				return strFuncModuleId;
			}
			set
			{
				string strFuncModuleId = value;
				Session.Add("FuncModuleAgcId4Qry", strFuncModuleId);
			}
		}

		
		/// <summary>
		/// �����еĲ�ѯ�ؼ�������ϳ�һ��������
		/// </summary>
		/// <returns>������(strWhereCond)</returns>
		private string CombineCondition()
		{
			//ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
			//���� 1=1 && UserName = '����'
            string strWhereCond = " 1=1 and PrjId = '" + clsPubVar.CurrSelPrjId + "'";
			//����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
			if (this.txtFuncModuleNameq.Text.Trim()!="")
			{
				strWhereCond += " And FuncModuleName='" + this.txtFuncModuleNameq.Text.Trim()+"'";
			}
			return strWhereCond;
		}
		///���ɰ�DATAGRID�Ĵ���
		/// <summary>
		/// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
		///			 ����ʾ��DATAGRID�С�
		/// </summary>
		private void BindDg_FuncModule()
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
			string strWhereCond = CombineCondition();
			//	2��������������ȡ�ñ�����������DataTable��
			System.Data.DataTable objDT = clsvFuncModule_AgcBL.GetDataTable(strWhereCond);
			//	3�����DATAGRID�ĵ�ǰҳ���Ƿ񳬳�DATAGRID��ҳ����Χ
			//		3.1 ���ȼ���ҳ����
			//		3.2 �����ǰҳ����ҳ����Ϊ���һҳ
			int intPages = CalcPages(objDT.Rows.Count, this.dgFuncModule.PageSize);
			if (intPages==0) 
			{
				this.dgFuncModule.CurrentPageIndex = 0;
			}
			else if (this.dgFuncModule.CurrentPageIndex > intPages - 1) 
			{
				this.dgFuncModule.CurrentPageIndex = intPages - 1;
			}
			//	4������DATAGRID������Դ(DataSource)��
			DataView objDV = objDT.DefaultView;
			objDV.Sort = strSortBy;     ///ע����һ�д����п�����Ҫע�͵���Ŀǰ���н����ڵ����Ĳ�ѯ������������
			this.dgFuncModule.DataSource=objDV;
			//	5����DATAGRID������DataTable��������ʾ��DATAGRID��
			this.dgFuncModule.DataBind();

			
			//��ǰ��¼��
			this.lblFuncModuleRecCount.Text = objDT.Rows.Count.ToString(); 
			//��ǰҳ��
			this.lblFuncModuleAllPages.Text = this.dgFuncModule.PageCount.ToString(); 
			//��ǰҳ����
			this.lblFuncModuleCurrentPage.Text=(this.dgFuncModule.CurrentPageIndex+1).ToString();
			//��ǰ����������ҳ����
			this.txtFuncModuleJump2Page.Text=(this.dgFuncModule.CurrentPageIndex+1).ToString();
			//�����ǰҳ����Ϊ0����<ǰһҳ>��ť��Ч
			if(this.dgFuncModule.CurrentPageIndex==0) 
			{
				btnFuncModulePrevPage.Enabled=false; 
			}
			else 
			{ 
				btnFuncModulePrevPage.Enabled=true; 
			} 
			//�����ǰҳ������Ϊ���һҳ����<ǰһҳ>��ť��Ч
			if(this.dgFuncModule.CurrentPageIndex==this.dgFuncModule.PageCount-1) 
			{ 
				btnFuncModuleNextPage.Enabled=false; 
			} 
			else 
			{ 
				btnFuncModuleNextPage.Enabled=true; 
			} 
			//7�������沿����ʾ����ʾ �������ǰDataGrid�еļ�¼��Ϊ0������ʾ��ǰ����ҳ������
			if(objDT.Rows.Count>0) 
			{ 
				this.tabFuncModuleJumpPage.Visible = true; 
			} 
			else 
			{ 
				this.tabFuncModuleJumpPage.Visible = false; 
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
			this.dgFuncModule.CurrentPageIndex=0;
			//�ѱ��¼��������ʾ��DATAGRID��
			BindDg_FuncModule();
		}
		/// <summary>
		/// �������ܣ��¼��������ڸ���DATAGRID�ĵ�ǰҳ����ʱ�����ĺ�����
		///			  ���幦����������ʾ��ҳ(������ҳ����)�����ݡ�
		/// </summary>
		/// <param name="source"></param>
		/// <param name="e"></param>
		protected void dgFuncModule_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			//�������裺����2����
			//1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
			//2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ

			//1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
			this.dgFuncModule.CurrentPageIndex=e.NewPageIndex;
			//2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ
			BindDg_FuncModule();
		}
		protected void dgFuncModule_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
		{
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
//				System.Web.UI.WebControls.LinkButton myDeleteButton;
//				myDeleteButton = (System.Web.UI.WebControls.LinkButton)e.Item.FindControl("lbnDelete");
//				myDeleteButton.Attributes.Add("onclick", "return confirm('�����Ҫɾ���� " + (e.Item.ItemIndex+1).ToString() + " ����');");
			}
			int intIndex;
			if (strSortBy == "") return ;
			if(e.Item.ItemType==ListItemType.Header)//����ؼ��Ƿ�Ϊҳü��
			{
				string strSortEx;
				for(int i=0;i<this.dgFuncModule.Columns.Count;i++)
				{
					strSortEx = this.dgFuncModule.Columns[i].SortExpression;
					if (strSortEx == "") continue;
					intIndex = strSortBy.IndexOf(strSortEx + " ");
					if(intIndex >=0)  //��ͼ״̬��������ʽ�Ƿ�Ϊ���е��ֶΣ�
					{
						Label lblSort=new Label();
						lblSort.Font.Name="webdings";//�������壬��"webdings"��5�������ǣ�6�������ǣ�
						intIndex = strSortBy.IndexOf("Asc");
						lblSort.Text=(intIndex>0?" 5":" 6");//�Ƿ�Ϊ���򣬶���Ϊstring�ͣ�
						e.Item.Cells[i].Controls.Add(lblSort);//��������ĵ�i����Ԫ��������һ�ؼ���
						break;
					}
				}
			}
		}

		protected void dgFuncModule_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			string strFuncModuleId;
			string strCommandName;
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.SelectedItem ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
				strCommandName = ((LinkButton)e.CommandSource).CommandName;
				strFuncModuleId = e.Item.Cells[0].Text;
				switch(strCommandName)
				{
					case "Delete":
						clsFuncModule_AgcBL.DelRecord(strFuncModuleId);
						BindDg_FuncModule();
						break;
						// Add other cases here, if there are multiple ButtonColumns in 
						// the DataGrid control.
					case "Update":
						break;

					default:
						// Do nothing.
						break;
				}
			}
		}
		
	
		
		protected void dgFuncModule_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
		{
			int intIndex;
			//�ж��Ƿ����µ������ֶ�
			intIndex = strSortBy.IndexOf(e.SortExpression);
			if (intIndex == -1)
			{
				strSortBy = e.SortExpression + " Asc";
				BindDg_FuncModule();
				return ;
			}
			//���ԭ��������
			intIndex = strSortBy.IndexOf(" Asc");
			if (intIndex == -1)		//���ԭ���������������Ϊ����
			{
				strSortBy = e.SortExpression + " Asc";
			}
			else			///��������Ϊ����
			{
				strSortBy = e.SortExpression + " Desc";
			}
			BindDg_FuncModule();
		}

		private string strSortBy
		{
			get
			{
				string sSortBy;
				sSortBy = (string)ViewState["SortBy"];
				if (sSortBy==null) 
				{
					sSortBy = "";
				}
				return sSortBy;
			}
			set
			{
				string sSortBy = value;
				ViewState.Add("SortBy", sSortBy);
			}
		}

		
		protected void btnFuncModulePrevPage_Click(object sender, System.EventArgs e)
		{
			this.dgFuncModule.CurrentPageIndex -=1; 
			this.BindDg_FuncModule(); 
		}

		protected void btnFuncModuleNextPage_Click(object sender, System.EventArgs e)
		{
			this.dgFuncModule.CurrentPageIndex +=1; 
			this.BindDg_FuncModule(); 
		}

		protected void btnFuncModuleJumpPage_Click(object sender, System.EventArgs e)
		{
			if(this.txtFuncModuleJump2Page.Text.Trim()!="" && 
				int.Parse(this.txtFuncModuleJump2Page.Text)>0 && 
				int.Parse(this.txtFuncModuleJump2Page.Text)-1<this.dgFuncModule.PageCount) 
			{ 
				this.dgFuncModule.CurrentPageIndex=int.Parse(this.txtFuncModuleJump2Page.Text)-1; 
			} 
			this.BindDg_FuncModule();
		}
		///���ɰ�DATAGRID�Ĵ���
		/// <summary>
		/// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
		///			 ����ʾ��DATAGRID�С�
		/// </summary>
		private void BindDg_PrjTab()
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
			string strWhereCond = CombineCondition4PrjTab();
			//	2��������������ȡ�ñ�����������DataTable��
            System.Data.DataTable objDT = null; // clsModuleTabRelaEx.GetModuleTabRelaV(strWhereCond);
			//	3�����DATAGRID�ĵ�ǰҳ���Ƿ񳬳�DATAGRID��ҳ����Χ
			//		3.1 ���ȼ���ҳ����
			//		3.2 �����ǰҳ����ҳ����Ϊ���һҳ
			int intPages = CalcPages(objDT.Rows.Count, this.dgPrjTab.PageSize);
			if (intPages==0) 
			{
				this.dgPrjTab.CurrentPageIndex = 0;
			}
			else if (this.dgPrjTab.CurrentPageIndex > intPages - 1) 
			{
				this.dgPrjTab.CurrentPageIndex = intPages - 1;
			}
			//	4������DATAGRID������Դ(DataSource)��
			DataView objDV = objDT.DefaultView;
//			objDV.Sort = strSortBy;
			this.dgPrjTab.DataSource=objDV;
			//	5����DATAGRID������DataTable��������ʾ��DATAGRID��
			this.dgPrjTab.DataBind();
			//	6�����ü�¼����״̬��
			this.txtRecCount4PrjTab.Text= objDT.Rows.Count.ToString();
		}

		protected void dgFuncModule_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			tabFuncModuleDataGrid.Visible = false;
			seFuncModuleAgcId = dgFuncModule.SelectedItem.Cells[0].Text;
			string strFuncModuleName = dgFuncModule.SelectedItem.Cells[1].Text;
			divObjName.InnerText = "<" + strFuncModuleName + ">ģ������б���Ϣ:";
			BindDg_PrjTab();
//			BindDg_FieldTab();
			tabPrjTab.Visible = true;
		}

		protected void lbAddFld_Click(object sender, System.EventArgs e)
		{
			tabPrjTab4Sel.Visible = true;
		}
		
		/// <summary>
		/// �����еĲ�ѯ�ؼ�������ϳ�һ��������
		/// </summary>
		/// <returns>������(strWhereCond)</returns>
		private string CombineCondition4PrjTab()
		{
			//ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
			//���� 1=1 and UserName = '����'
			string strWhereCond=" 1=1 and FuncModuleAgcId = '" + seFuncModuleAgcId + "'";
			//����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
			return strWhereCond;
		}
		
		/// <summary>
		/// �����еĲ�ѯ�ؼ�������ϳ�һ��������
		/// </summary>
		/// <returns>������(strWhereCond)</returns>
		private string CombineCondition4PrjTab4Sel()
		{
			//ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
			//���� 1=1 and UserName = '����'
            string strWhereCond = " 1=1 and PrjId = '" + clsPubVar.CurrSelPrjId + "'";
			//����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
			if (this.txtTabCnNameq.Text.Trim()!="")
			{
				strWhereCond += " and TabCnName like '" + this.txtTabCnNameq.Text.Trim()+"%'";
			}
			if (this.txtTabNameq.Text.Trim()!="")
			{
				strWhereCond += " and TabName like '" + this.txtTabNameq.Text.Trim()+"%'";
			}
			if (this.ddlObjIdq.SelectedValue!="" && this.ddlObjIdq.SelectedValue!="0")
			{
				strWhereCond += " and ObjId='" + this.ddlObjIdq.SelectedValue+"'";
			}
			return strWhereCond;
		}

		///���ɰ�DATAGRID�Ĵ���
		/// <summary>
		/// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
		///			 ����ʾ��DATAGRID�С�
		/// </summary>
		private void BindDg_PrjTab4Sel()
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
			string strWhereCond = CombineCondition4PrjTab4Sel();
			//	2��������������ȡ�ñ�����������DataTable��
			System.Data.DataTable objDT = clsvPrjTabBL.GetDataTable(strWhereCond);
			//	3�����DATAGRID�ĵ�ǰҳ���Ƿ񳬳�DATAGRID��ҳ����Χ
			//		3.1 ���ȼ���ҳ����
			//		3.2 �����ǰҳ����ҳ����Ϊ���һҳ
			int intPages = CalcPages(objDT.Rows.Count, this.dgPrjTab4Sel.PageSize);
			if (intPages==0) 
			{
				this.dgPrjTab.CurrentPageIndex = 0;
			}
			else if (this.dgPrjTab4Sel.CurrentPageIndex > intPages - 1) 
			{
				this.dgPrjTab4Sel.CurrentPageIndex = intPages - 1;
			}
			//	4������DATAGRID������Դ(DataSource)��
			DataView objDV = objDT.DefaultView;
			//			objDV.Sort = strSortBy;
			this.dgPrjTab4Sel.DataSource=objDV;
			//	5����DATAGRID������DataTable��������ʾ��DATAGRID��
			this.dgPrjTab4Sel.DataBind();
			//	6�����ü�¼����״̬��
			this.txtRecCount4Sel.Text= objDT.Rows.Count.ToString();
		}

		protected void btnQuery_PrjTab_Click(object sender, System.EventArgs e)
		{
			//��DATAGRID�ĵ�ǰҳ��������Ϊ0������1ҳ��
			//��������ѯʱ��������ʾ���Ǳ��¼���ݵĵ�һ�������ݡ�
			this.dgPrjTab4Sel.CurrentPageIndex=0;
			//�ѱ��¼��������ʾ��DATAGRID��
			BindDg_PrjTab4Sel();
		}

		protected void btnOKAdd_Click(object sender, System.EventArgs e)
		{
			string strWhereCond;
			string strTabId;
			System.Data.DataTable objDT;
			ArrayList objArr=new ArrayList();
			if (chkSelAll.Checked == true)
			{
				//	1����Ͻ�����������
				strWhereCond = CombineCondition4PrjTab4Sel();
				//	2��������������ȡ�ñ�����������DataTable��
                objDT = clsvPrjTabBL.GetDataTable(strWhereCond);
				foreach(DataRow objRow in objDT.Rows)
				{
					strTabId = objRow["TabId"].ToString();
					objArr.Add(strTabId);
				}
			}
			else
			{
				this.Get_PrjTabArrylist(this.dgPrjTab4Sel,objArr);
			}
			this.Add_PrjTabtoModuleTabRela(objArr);
			BindDg_PrjTab();
			tabPrjTab4Sel.Visible = false;
			Response.Write("<script>alert('��ѡ�ֶ���ӳɹ�����')</script>");

		}

		private void Add_PrjTabtoModuleTabRela(ArrayList objArr)
		{

			if(objArr.Count==0)
			{
				return;
			}
            //else
            //{
            //    if (FuncModuleAgcId.Length == 0) 
            //    {
            //        lblMsg.Text = "��ѡ����ʵ�ģ����";
            //        return ;
            //    }
            //    clsModuleTabRela objModuleTabRela;
            //    foreach(string strTabId in objArr)
            //    {
            //        objModuleTabRela=new clsModuleTabRela();
            //        //					objFldObjTab.TabId=this.TabId;
            //        objModuleTabRela.TabId=strTabId;
            //        objModuleTabRela.FuncModuleAgcId=FuncModuleAgcId;
            //        ///3.1���ж��Ƿ�����ͬ���ֶδ��ڡ�					
            //        if (clsModuleTabRelaEx.IsExistSameTabId(FuncModuleAgcId, strTabId))	//�ж��Ƿ�����ͬ�Ĺؼ���
            //        {
            //        }
            //        else
            //        {
            //            objModuleTabRela.AddNewRecord();
            //        }
            //    }
            //}
		}

		private void Get_PrjTabArrylist(DataGrid objDg, ArrayList objArr)
		{
			if(objArr==null || objDg.Items.Count==0)
			{
				return;
			}
			else 
			{
				objArr.Clear();
				foreach(DataGridItem di in objDg.Items)
				{
					CheckBox cb=(CheckBox)di.FindControl("ckb1");
					if(cb!=null && cb.Checked)
					{
						objArr.Add(di.Cells[1].Text);
					}
				}
			}
		}

		protected void dgPrjTab_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			long lngMId;
			string strCommandName;
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.SelectedItem ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
				strCommandName = ((LinkButton)e.CommandSource).CommandName;
				lngMId = long.Parse(e.Item.Cells[0].Text);
				switch(strCommandName)
				{
					case "Delete":
                       
						BindDg_PrjTab();
						break;
						// Add other cases here, if there are multiple ButtonColumns in 
						// the DataGrid control.

					default:
						// Do nothing.
						break;
				}
			}

		}

		protected void lbDispObjList_Click(object sender, System.EventArgs e)
		{
			tabFuncModuleDataGrid.Visible = true;
		}

		protected void chkSelAll_CheckedChanged(object sender, System.EventArgs e)
		{
			this.Set_DataGridAllChecked(this.dgPrjTab4Sel,this.chkSelAll);		
		}

		private void Set_DataGridAllChecked(DataGrid objDg,CheckBox objCkb)
		{
			if(objCkb==null || objDg.Items.Count==0 )
			{
				return;
			}
			else 
			{
				foreach(DataGridItem di in objDg.Items)
				{
					CheckBox cb=(CheckBox)di.FindControl("ckb1");
					if(cb!=null )
					{
						cb.Checked=objCkb.Checked;
					}
				}
			}
		}

		protected void dgPrjTab_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			//�������裺����2����
			//1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
			//2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ

			//1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
			this.dgPrjTab.CurrentPageIndex=e.NewPageIndex;
			//2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ
			BindDg_PrjTab();

		}

		protected void dgPrjTab4Sel_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			//�������裺����2����
			//1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
			//2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ

			//1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
			this.dgPrjTab4Sel.CurrentPageIndex=e.NewPageIndex;
			//2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ
			BindDg_PrjTab4Sel();
		}


	}
}