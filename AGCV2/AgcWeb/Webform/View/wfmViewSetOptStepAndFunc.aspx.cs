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
//using SqlSv; 
using com.taishsoft.commdb;
using CommFunc4WebForm;


using AGC.BusinessLogic;using AGC.FunClass;
using AGC.BusinessLogicEx;
using AGC.Entity;

namespace AGC.Webform
{
	/// <summary>
	/// wfmViewInfo_QUDI ��ժҪ˵��������Q�����ѯ��U�����޸�
	/// </summary>
	public partial class wfmViewSetOptStepAndFunc : System.Web.UI.Page
	{

		protected void Page_Load(object sender, System.EventArgs e)
		{
			string js = ""; 
			js += "<script>\r\r\n";
			js += "function ld(){\r\r\n";
			js += "for(i=0;i<document.getElementsByName('RadioName').length;i++)\r\r\n"; 
			js += "if(document.getElementsByName('RadioName')[i].value=="; 
			js += "document.getElementById('" + rd.ClientID + "').value) "; 
			js += "document.getElementsByName('RadioName')[i].checked=true\r\r\n"; 
			js += "}\r\r\n"; 
			js += "window.onload=ld\r\r\n"; 
			js += "</"+"script>\r\r\n";
            ClientScript.RegisterStartupScript(this.GetType(), "js", js);
//            this.RegisterStartupScript("js", js); 
			// �ڴ˴������û������Գ�ʼ��ҳ��
			if (!IsPostBack)	///����������ǳ��α����ã������ǵ�����ť�¼�������
			{
				///����Ӧ�����صĿؼ�����
				///
				tabHidden.Visible = false;
                //if (clsCommForWebForm.SystemStatus=="DEBUG")
                //{
                //    PrjId = "0005";
                //    txtUserIdq.Text = "pyf";
                //    clsUsersEN objUsers = new clsUsersEN("pyf", true);
                //    objUser = objUsers;
                //}
				//1��Ϊ��������������Դ�����б�����
//				wucViewInfo1.SetDdl_ViewTypeCode();
                //				wucViewInfo1.SetDdl_FuncModuleId(clsPubVar.CurrSelPrjId);
                //				wucViewInfo1.SetDdl_MainTabId(clsPubVar.CurrSelPrjId);
                //				wucViewInfo1.SetDdl_DetailTabId(clsPubVar.CurrSelPrjId);
//				wucViewInfo1.SetDdl_PrjId();

                clsFuncModule_AgcBLEx.BindDdl_FuncModuleId(ddlFuncModuleIdq, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId);

				BindDdl_ViewTypeCode(ddlViewTypeCodeq);
				clsProjectsBLEx.BindDdl_PrjIdCacheEx(ddlPrjIdq);

				//�ָ���һ���ڴ˽����״̬
				if (seFuncModuleAgcId != "")
				{
					clsDropDownList.SetDdlValue(ddlFuncModuleIdq, seFuncModuleAgcId);
				}
				if (ViewTypeCode !="")
				{
					clsDropDownList.SetDdlValue(ddlViewTypeCodeq, ViewTypeCode);
				}
				txtViewNameq.Text = ViewName;
				//===============================

				strSortBy = "ViewName Asc";
				///���õ�ǰ��¼�û���Ĭ�Ϲ���
                ddlPrjIdq.SelectedValue = clsPubVar.CurrSelPrjId;
				//2����ʾ�������ı�������DATAGRID��
				BindDg_ViewInfo();
				//3�����ñ�ؼ����ֿؼ���ReadOnly���ԣ�
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

		private string ViewTypeCode
		{
			get
			{
				string intViewTypeCode;
				intViewTypeCode = (string)Session["ViewTypeCode"];
				if (intViewTypeCode==null) 
				{
					intViewTypeCode = "";
				}
				return intViewTypeCode;
			}
			set
			{
				string intViewTypeCode = value;
				Session.Add("ViewTypeCode", intViewTypeCode);
			}
		}

		private string ViewName
		{
			get
			{
				string strViewName;
				strViewName = (string)Session["ViewName"];
				if (strViewName==null) 
				{
					strViewName = "";
				}
				return strViewName;
			}
			set
			{
				string strViewName = value;
				Session.Add("ViewName", strViewName);
			}
		}


		private string seUserId
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
		private clsUsersEN objUserBak
		{
			get
			{
				clsUsersEN pobjUser;
				pobjUser = (clsUsersEN)Session["objUser"];
				if (pobjUser==null) 
				{
					pobjUser = null;
				}
				return pobjUser;
			}
			set
			{
				clsUsersEN pobjUser = value;
				Session.Add("objUser", pobjUser);
			}
		}
	
		

		
		
		/// <summary>
		/// �����еĲ�ѯ�ؼ�������ϳ�һ��������
		/// </summary>
		/// <returns>������(strWhereCond)</returns>
		private string CombineCondition()
		{
			//ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
			//���� 1=1 and UserName = '����'
			string strWhereCond=" 1=1 ";
			//����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
			if (this.txtViewNameq.Text.Trim()!="")
			{
				strWhereCond += " and ViewName like '" + this.txtViewNameq.Text.Trim()+"%'";
			}
			if (this.ddlViewTypeCodeq.SelectedValue!="" && this.ddlViewTypeCodeq.SelectedValue!="0")
			{
				strWhereCond += " and ViewTypeCode like '" + this.ddlViewTypeCodeq.SelectedValue+"%'";
			}
			if (this.ddlFuncModuleIdq.SelectedValue!="" && this.ddlFuncModuleIdq.SelectedValue!="0")
			{
				strWhereCond += " And FuncModuleAgcId='" + this.ddlFuncModuleIdq.SelectedValue+"'";
			}

			if (this.txtMainTabNameq.Text.Trim()!="")
			{
				strWhereCond += " and MainTabName like '" + this.txtMainTabNameq.Text.Trim()+"%'";
			}
			if (this.txtDetailTabNameq.Text.Trim()!="")
			{
				strWhereCond += " and DetailTabName like '" + this.txtDetailTabNameq.Text.Trim()+"%'";
			}
//			if (this.chkIsNeedSort_q._Checked==true)
//				strWhereCond += " and ViewInfo.IsNeedSort='1'";
//			else
//				strWhereCond += " and ViewInfo.IsNeedSort='0'";
//			if (this.chkIsNeedTransCode_q._Checked==true)
//				strWhereCond += " and ViewInfo.IsNeedTransCode='1'";
//			else
//				strWhereCond += " and ViewInfo.IsNeedTransCode='0'";
			if (this.txtUserIdq.Text.Trim()!="")
			{
				strWhereCond += " and UserId='" + this.txtUserIdq.Text.Trim()+"'";
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
		private void BindDg_ViewInfo()
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
			System.Data.DataTable objDT = clsViewInfoBLEx.GetViewInfoTEx(strWhereCond);
			//	3�����DATAGRID�ĵ�ǰҳ���Ƿ񳬳�DATAGRID��ҳ����Χ
			//		3.1 ���ȼ���ҳ����
			//		3.2 �����ǰҳ����ҳ����Ϊ���һҳ
			int intPages = CalcPages(objDT.Rows.Count, this.dgViewInfo.PageSize);
			if (intPages==0) 
			{
				this.dgViewInfo.CurrentPageIndex = 0;
			}
			else if (this.dgViewInfo.CurrentPageIndex > intPages - 1) 
			{
				this.dgViewInfo.CurrentPageIndex = intPages - 1;
			}
			//	4������DATAGRID������Դ(DataSource)��
			DataView objDV = objDT.DefaultView;
			objDV.Sort = strSortBy;
			this.dgViewInfo.DataSource=objDV;
			//	5����DATAGRID������DataTable��������ʾ��DATAGRID��
			this.dgViewInfo.DataBind();
			//	6�����ü�¼����״̬��
			this.txtRecCount.Text= objDT.Rows.Count.ToString();
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
			this.dgViewInfo.CurrentPageIndex=0;
			//�ѱ��¼��������ʾ��DATAGRID��
			BindDg_ViewInfo();
			//������β�ѯ������Ϊ��һ�������ý������
			seFuncModuleAgcId = ddlFuncModuleIdq.SelectedValue;
			ViewTypeCode = ddlViewTypeCodeq.SelectedValue;
			ViewName = txtViewNameq.Text;

		}
		/// <summary>
		/// �������ܣ��¼��������ڸ���DATAGRID�ĵ�ǰҳ����ʱ�����ĺ�����
		///			  ���幦����������ʾ��ҳ(������ҳ����)�����ݡ�
		/// </summary>
		/// <param name="source"></param>
		/// <param name="e"></param>
		protected void dgViewInfo_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			//�������裺����2����
			//1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
			//2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ

			//1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
			this.dgViewInfo.CurrentPageIndex=e.NewPageIndex;
			//2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ
			BindDg_ViewInfo();
		}
		
		
		public System.Data.DataTable GetViewTypeCode()
		{
			//��ȡĳѧԺ����רҵ��Ϣ
			string strSQL = "select ViewTypeCode, ViewTypeName from ViewTypeCodeTab ";
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}
		public void BindDdl_ViewTypeCode(System.Web.UI.WebControls.DropDownList objDDL)
		{
			//Ϊ����Դ�ڱ����������������
			ListItem li=new ListItem("��ѡ��...","0");
			System.Data.DataTable objDT = GetViewTypeCode();
			objDDL.DataValueField="ViewTypeCode";
			objDDL.DataTextField="ViewTypeName";
			objDDL.DataSource = objDT;
			objDDL.DataBind();
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
		}


		protected void dgViewInfo_ItemDataBound(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
		{
//			System.Web.UI.WebControls.CheckBox chkIsSort, chkIsTransCode;
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.SelectedItem ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
				int [] iNum= new int[20];
				iNum[0] = 11;
				iNum[1] = 12;
				for (int i = 0; i<2; i++)
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
		

		/// <summary>
		/// ���ܣ�Ϊ������Ӳ�������
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected void btnViewOptStep_Click(object sender, System.EventArgs e)
		{
			string strViewId =(string) rd.Value;
			if (strViewId.Trim().Length == 0) 
			{
				lblMsg2.Text = "û��ѡ���¼����ѡ��һ����Ч�Ľ����¼!";
				return ;
			}
			lblMsg2.Text = "";
			Session.Add("ViewId",strViewId);
			Response.Redirect("wfmViewOptSteps_QUDI.aspx");
		}	
		
		/// <summary>
		/// ���ܣ��༭�������ر�
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected void btnEditRelaTab_Click(object sender, System.EventArgs e)
		{
			string strViewId =(string) rd.Value;
			if (strViewId.Trim().Length == 0) 
			{
				lblMsg2.Text = "û��ѡ���¼����ѡ��һ����Ч�Ľ����¼!";
				return ;
			}
			lblMsg2.Text = "";
			Session.Add("ViewId",strViewId);
			Response.Redirect("wfmViewRelaTab_QUDI.aspx");
		}

		/// <summary>
		/// ���ܣ��༭����İ�ť�������裻
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected void btnBtnOptStep_Click(object sender, System.EventArgs e)
		{
			string strViewId =(string) rd.Value;
			if (strViewId.Trim().Length == 0) 
			{
				lblMsg2.Text = "û��ѡ���¼����ѡ��һ����Ч�Ľ����¼!";
				return ;
			}
			lblMsg2.Text = "";
			Session.Add("ViewId",strViewId);
			Response.Redirect("wfmViewBtnOptSteps_QUDI.aspx");
		}
		/// <summary>
		/// ���ܣ��༭������ֶ���Ϣ��Ϊ������ӡ�ɾ����ά���ֶ���Ϣ��
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected void btnEditViewField_Click(object sender, System.EventArgs e)
		{
			string strViewId =(string) rd.Value;
			if (strViewId.Trim().Length == 0) 
			{
				lblMsg2.Text = "û��ѡ���¼����ѡ��һ����Ч�Ľ����¼!";
				return ;
			}
			lblMsg2.Text = "";
			Session.Add("ViewId",strViewId);
			Response.Redirect("wfmViewAddField.aspx");
		}
		/// <summary>
		/// ���ܣ��������������ý�����ֶ���Ϣ������ӡ�ɾ���ֶ���Ϣ��
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected void btnSetViewFld_Click(object sender, System.EventArgs e)
		{
			string strViewId =(string) rd.Value;
			if (strViewId.Trim().Length == 0) 
			{
				lblMsg2.Text = "û��ѡ���¼����ѡ��һ����Ч�Ľ����¼!";
				return ;
			}
			lblMsg2.Text = "";
			Session.Add("ViewId",strViewId);
			Response.Redirect("wfmViewSetField.aspx");
		
		}

		protected void lbDispViewList_Click(object sender, System.EventArgs e)
		{
			tabQuery1.Visible = true;
            //tabLayout.Visible = false;
		}

		

		protected void dgViewInfo_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
		{
			int intIndex;
			//�ж��Ƿ����µ������ֶ�
			intIndex = strSortBy.IndexOf(e.SortExpression);
			if (intIndex == -1)
			{
				strSortBy = e.SortExpression + " Asc";
				BindDg_ViewInfo();
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
			BindDg_ViewInfo();
		}

		protected void dgViewInfo_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
		{
			int intIndex;
			if (strSortBy == "") return ;
			if(e.Item.ItemType==ListItemType.Header)//����ؼ��Ƿ�Ϊҳü��
			{
				string strSortEx;
				for(int i=0;i<this.dgViewInfo.Columns.Count;i++)
				{
					strSortEx = this.dgViewInfo.Columns[i].SortExpression;
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

	}
}