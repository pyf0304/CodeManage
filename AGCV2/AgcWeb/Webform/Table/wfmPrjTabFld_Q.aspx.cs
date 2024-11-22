///���ɲ�ѯ�޸ļ�¼�Ŀ��Ʋ����


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
using com.taishsoft.datetime;
using AGC.BusinessLogic;using AGC.FunClass;

using AGC.BusinessLogicEx;
using System.Collections.Generic;
using AGC.Entity;



namespace AGC.Webform
{
	/// <summary>
	/// wfmPrjTabFld_Q ��ժҪ˵��������Q�����ѯ��U�����޸�
	/// </summary>
	public partial class wfmPrjTabFld_Q : CommWebPageBase
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

                // �ڴ˴�����һЩ�û���ʼ������Ĵ��룬�������������������Դ��
                //wucStudent1.SetDdl_College();
                //1��Ϊ��������������Դ�����б�����
                clsPrjTabBLEx.BindDdl_TabIdExCache(ddlTabIdq, clsPubVar.CurrSelPrjId);
				clsProjectsBLEx.BindDdl_PrjIdCacheEx(ddlPrjIdq);
				clsDropDownList.BindDdl_PrimaryTypeId(ddlPrimaryTypeIdq);
                clsFieldTypeBLEx.BindDdl_FieldTypeIdCache(ddlFldTypeq);
                clsDataTypeAbbrBLEx.BindDdl_DataTypeIdCache(ddlDataTypeq);
                clsDataTypeAbbrBLEx.BindDdl_DataTypeIdCache(ddlDataType);
                clsFuncModule_AgcBLEx.BindDdl_FuncModuleId(ddlFuncModuleId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId);

                ddlPrjIdq.SelectedValue = clsPubVar.CurrSelPrjId;
				ddlPrjIdq.Enabled = false;
				//2����ʾ�������ı�������DATAGRID��
                strSortPrjTabFldBy = "FuncModuleName,TabName,SequenceNumber Asc";
				BindDg_PrjTabFld();
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

		
		/// <summary>
		/// �����еĲ�ѯ�ؼ�������ϳ�һ��������
		/// </summary>
		/// <returns>������(strWhereCond)</returns>
		private string CombinePrjTabFldCondition()
		{
			//ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
			//���� 1=1 && UserName = '����'
//			string strWhereCond=" 1=1 and PrjId = '" + PrjId + "'";
			string strWhereCond=" 1=1 ";
			//����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
			if (this.ddlTabIdq.SelectedValue!="" && this.ddlTabIdq.SelectedValue!="0")
			{
				strWhereCond += " And TabId='" + this.ddlTabIdq.SelectedValue+"'";
			}
			if (this.ddlPrjIdq.SelectedValue!="" && this.ddlPrjIdq.SelectedValue!="0")
			{
				strWhereCond += " And PrjId='" + this.ddlPrjIdq.SelectedValue+"'";
			}
			if (this.ddlPrimaryTypeIdq.SelectedValue!="" && this.ddlPrimaryTypeIdq.SelectedValue!="0")
			{
				strWhereCond += " And PrimaryTypeId='" + this.ddlPrimaryTypeIdq.SelectedValue+"'";
			}
			if (this.txtFldNameq.Text.Trim()!="")
			{
				strWhereCond += " And FldName like '%" + this.txtFldNameq.Text.Trim()+"%'";
			}
            if (this.txtFldName_New.Text.Trim() != "")
            {
                strWhereCond += string.Format(" and tabid not in (select tabid from vPrjTabFld where FldName = '{0}') ", this.txtFldName_New.Text.Trim());
            }
            if (this.ddlFldTypeq.SelectedValue!="" && this.ddlFldTypeq.SelectedValue!="0")
			{
                strWhereCond += string.Format(" And {0}='{1}'", 
                    conPrjTabFld.FieldTypeId,
                    this.ddlFldTypeq.SelectedValue );
			}
            if (this.ddlDataTypeq.SelectedValue != "" && this.ddlDataTypeq.SelectedValue != "0")
            {
                strWhereCond += " And DataTypeId='" + this.ddlFldTypeq.SelectedValue + "'";
            }
            if (this.ddlFuncModuleId.SelectedValue != "" && this.ddlFuncModuleId.SelectedValue != "0")
            {
                strWhereCond += " and FuncModuleAgcId='" + this.ddlFuncModuleId.SelectedValue + "'";
            }

			return strWhereCond;
		}
         ///���ɰ�DATAGRID�Ĵ���
        /// <summary>
        /// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
        ///			 ����ʾ��DATAGRID�С�
        /// </summary>
        private void BindDg_PrjTabFld()
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
			string strWhereCond = CombinePrjTabFldCondition();
			//	2��������������ȡ�ñ�����������DataTable��
			System.Data.DataTable objDT = clsvPrjTabFldBL.GetDataTable(strWhereCond);
			//	3�����DATAGRID�ĵ�ǰҳ���Ƿ񳬳�DATAGRID��ҳ����Χ
			//		3.1 ���ȼ���ҳ����
			//		3.2 �����ǰҳ����ҳ����Ϊ���һҳ
			int intPages = CalcPages(objDT.Rows.Count, this.dgPrjTabFld1.PageSize);
			if (intPages==0) 
			{
				this.dgPrjTabFld1.CurrentPageIndex = 0;
			}
			else if (this.dgPrjTabFld1.CurrentPageIndex > intPages - 1) 
			{
				this.dgPrjTabFld1.CurrentPageIndex = intPages - 1;
			}
			//	4������DATAGRID������Դ(DataSource)��
			DataView objDV = objDT.DefaultView;
			objDV.Sort = strSortPrjTabFldBy;     ///ע����һ�д����п�����Ҫע�͵���Ŀǰ���н����ڵ����Ĳ�ѯ������������

            ///����GridView��ÿҳ�ļ�¼��
            if (string.IsNullOrEmpty(PageSize4PrjTab) == false)
            {
                int intPageSize = int.Parse(PageSize4PrjTab);
                dgPrjTabFld1.PageSize = intPageSize;
            }
            else
            {
                PageSize4PrjTab = "10";
                dgPrjTabFld1.PageSize = 10;
            }
            this.dgPrjTabFld1.DataSource=objDV;
			//	5����DATAGRID������DataTable��������ʾ��DATAGRID��
			this.dgPrjTabFld1.DataBind();

			
			//��ǰ��¼��
			this.lblPrjTabFldRecCount.Text = objDT.Rows.Count.ToString(); 
			//��ǰҳ��
			this.lblPrjTabFldAllPages.Text = this.dgPrjTabFld1.PageCount.ToString(); 
			//��ǰҳ����
			this.lblPrjTabFldCurrentPage.Text=(this.dgPrjTabFld1.CurrentPageIndex+1).ToString();
			//��ǰ����������ҳ����
			this.txtPrjTabFldJump2Page.Text=(this.dgPrjTabFld1.CurrentPageIndex+1).ToString();
			//�����ǰҳ����Ϊ0����<ǰһҳ>��ť��Ч
			if(this.dgPrjTabFld1.CurrentPageIndex==0) 
			{
				btnPrjTabFldPrevPage.Enabled=false; 
			}
			else 
			{ 
				btnPrjTabFldPrevPage.Enabled=true; 
			} 
			//�����ǰҳ������Ϊ���һҳ����<ǰһҳ>��ť��Ч
			if(this.dgPrjTabFld1.CurrentPageIndex==this.dgPrjTabFld1.PageCount-1) 
			{ 
				btnPrjTabFldNextPage.Enabled=false; 
			} 
			else 
			{ 
				btnPrjTabFldNextPage.Enabled=true; 
			} 
			//7�������沿����ʾ����ʾ �������ǰDataGrid�еļ�¼��Ϊ0������ʾ��ǰ����ҳ������
			if(objDT.Rows.Count>0) 
			{ 
				this.tabPrjTabFldJumpPage.Visible = true; 
			} 
			else 
			{ 
				this.tabPrjTabFldJumpPage.Visible = false; 
			}
            //���÷�ҳ����ÿҳ��¼�����������ֵ
            if (string.IsNullOrEmpty(PageSize4PrjTab) == false)
            {
                ddlPagerRecCount.Text = PageSize4PrjTab;
            }
            else
            {
                PageSize4PrjTab = "10";
                ddlPagerRecCount.Text = PageSize4PrjTab;
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
			this.dgPrjTabFld1.CurrentPageIndex=0;
			//�ѱ��¼��������ʾ��DATAGRID��
			BindDg_PrjTabFld();
		}
		/// <summary>
		/// �������ܣ��¼��������ڸ���DATAGRID�ĵ�ǰҳ����ʱ�����ĺ�����
		///			  ���幦����������ʾ��ҳ(������ҳ����)�����ݡ�
		/// </summary>
		/// <param name="source"></param>
		/// <param name="e"></param>
		protected void dgPrjTabFld_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			//�������裺����2����
			//1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
			//2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ

			//1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
			this.dgPrjTabFld1.CurrentPageIndex=e.NewPageIndex;
			//2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ
			BindDg_PrjTabFld();
		}

		
		//��ǰ��¼��
		protected void btnExportExcel4Dg_Click(object sender, System.EventArgs e)
		{
			//	1����Ͻ�����������
			string strWhereCond = CombinePrjTabFldCondition();
            strWhereCond += string.Format(" Order By  {0}, {1}, {2}, TabName, SequenceNumber", 
                convPrjTabFld.SqlDsTypeName, convPrjTabFld.OrderNum4Refer,
                convPrjTabFld.FuncModuleName);
			//	2��������������ȡ�ñ�����������DataTable��
			System.Data.DataTable objDT = clsvPrjTabFldBL.GetDataTable(strWhereCond);
			List<string> arrCnName = new List<string>();
			List<string> arrColName = new List<string>();
			string strFileName = "PrjTabFld��Ϣ����.xls";
			string strFolderName;
			string strDownLoadFileName;
            arrColName.Add(convPrjTabFld.FuncModuleName); arrCnName.Add("ģ��");
            arrColName.Add(convPrjTabFld.TabName); arrCnName.Add("����");
            arrColName.Add(convPrjTabFld.SqlDsTypeName); arrCnName.Add("Sql������");
            arrColName.Add(convPrjTabFld.OrderNum4Refer); arrCnName.Add("���������");

            arrColName.Add(convPrjTabFld.SequenceNumber); arrCnName.Add("�ֶ����");
			arrColName.Add(convPrjTabFld.FldName); arrCnName.Add("�ֶ���");
			arrColName.Add(convPrjTabFld.Caption); arrCnName.Add("����");
			arrColName.Add(convPrjTabFld.DataTypeName); arrCnName.Add("����");
			arrColName.Add(convPrjTabFld.FldLength); arrCnName.Add("�ֶγ���");
			arrColName.Add(convPrjTabFld.IsTabNullable); arrCnName.Add("�Ƿ�ɿ�");
			arrColName.Add(convPrjTabFld.MinValue); arrCnName.Add("��Сֵ");
			arrColName.Add(convPrjTabFld.MaxValue); arrCnName.Add("���ֵ");
			arrColName.Add(convPrjTabFld.DefaultValue); arrCnName.Add("ȱʡֵ");
			arrColName.Add(convPrjTabFld.IsTabUnique); arrCnName.Add("�Ƿ�Ψһ");
			//arrColName.Add(convPrjTabFld.IsTabPrimary); arrCnName.Add("�Ƿ�����");
			arrColName.Add(convPrjTabFld.PrimaryTypeName); arrCnName.Add("��������");
			arrColName.Add(convPrjTabFld.FieldTypeName); arrCnName.Add("�ֶ�����");
			arrColName.Add(convPrjTabFld.IsParentObj); arrCnName.Add("�Ƿ񸸶���");
			arrColName.Add(convPrjTabFld.IsTabForeignKey); arrCnName.Add("�Ƿ�����");
			arrColName.Add(convPrjTabFld.ForeignTabName); arrCnName.Add("�������");
            arrColName.Add(convPrjTabFld.MemoInTab); arrCnName.Add("˵��");
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
	
		
		
		protected void dgPrjTabFld_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
		{
			int intIndex;
			//�ж��Ƿ����µ������ֶ�
			intIndex = strSortPrjTabFldBy.IndexOf(e.SortExpression);
			if (intIndex == -1)
			{
				strSortPrjTabFldBy = e.SortExpression + " Asc";
				BindDg_PrjTabFld();
				return ;
			}
			//���ԭ��������
			intIndex = strSortPrjTabFldBy.IndexOf(" Asc");
			if (intIndex == -1)		//���ԭ���������������Ϊ����
			{
				strSortPrjTabFldBy = e.SortExpression + " Asc";
			}
			else			///��������Ϊ����
			{
				strSortPrjTabFldBy = e.SortExpression + " Desc";
			}
			BindDg_PrjTabFld();
		}

		private string strSortPrjTabFldBy
		{
			get
			{
				string sSortPrjTabFldBy;
				sSortPrjTabFldBy = (string)ViewState["SortPrjTabFldBy"];
				if (sSortPrjTabFldBy==null) 
				{
					sSortPrjTabFldBy = "";
				}
				return sSortPrjTabFldBy;
			}
			set
			{
				string sSortPrjTabFldBy = value;
				ViewState.Add("SortPrjTabFldBy", sSortPrjTabFldBy);
			}
		}
		protected void dgPrjTabFld_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
		{
			int intIndex;
			if (strSortPrjTabFldBy == "") return ;
			if(e.Item.ItemType==ListItemType.Header)//����ؼ��Ƿ�Ϊҳü��
			{
				string strSortEx;
				for(int i=0;i<this.dgPrjTabFld1.Columns.Count;i++)
				{
					strSortEx = this.dgPrjTabFld1.Columns[i].SortExpression;
					if (strSortEx == "") continue;
					intIndex = strSortPrjTabFldBy.IndexOf(strSortEx + " ");
					if(intIndex >=0)  //��ͼ״̬��������ʽ�Ƿ�Ϊ���е��ֶΣ�
					{
						Label lblSort=new Label();
						lblSort.Font.Name="webdings";//�������壬��"webdings"��5�������ǣ�6�������ǣ�
						intIndex = strSortPrjTabFldBy.IndexOf("Asc");
						lblSort.Text=(intIndex>0?" 5":" 6");//�Ƿ�Ϊ���򣬶���Ϊstring�ͣ�
						e.Item.Cells[i].Controls.Add(lblSort);//��������ĵ�i����Ԫ��������һ�ؼ���
						break;
					}
				}
			}
		}

		//���ɸ������SESSION������Ժ���
		protected void btnPrjTabFldPrevPage_Click(object sender, System.EventArgs e)
		{
			this.dgPrjTabFld1.CurrentPageIndex -=1; 
			this.BindDg_PrjTabFld(); 
		}

		protected void btnPrjTabFldNextPage_Click(object sender, System.EventArgs e)
		{
			this.dgPrjTabFld1.CurrentPageIndex +=1; 
			this.BindDg_PrjTabFld(); 
		}

		protected void btnPrjTabFldJumpPage_Click(object sender, System.EventArgs e)
		{
			if(this.txtPrjTabFldJump2Page.Text.Trim()!="" && 
				int.Parse(this.txtPrjTabFldJump2Page.Text)>0 && 
				int.Parse(this.txtPrjTabFldJump2Page.Text)-1<this.dgPrjTabFld1.PageCount) 
			{ 
				this.dgPrjTabFld1.CurrentPageIndex=int.Parse(this.txtPrjTabFldJump2Page.Text)-1; 
			} 
			this.BindDg_PrjTabFld();
		}

		protected void ddlFuncModuleId_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (ddlFuncModuleId.SelectedIndex>0)
			{
				string strFuncModuleId = ddlFuncModuleId.SelectedValue;
                clsPrjTabBLEx.BindDdl_TabIdExCache(ddlTabIdq, clsPubVar.CurrSelPrjId, strFuncModuleId);
			}
		}
        protected void ddlPagerRecCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList ddlPagerRecCount = (DropDownList)sender;
            string strPageSize = ddlPagerRecCount.Text;
            if (clsDateTime.IsNumeric(strPageSize) == true)
            {
                int intPageSize = int.Parse(strPageSize);
                if (intPageSize >= 1)
                {
                    PageSize4PrjTab = intPageSize.ToString();
                    BindDg_PrjTabFld();
                }
            }
        }
        ///����ר�����ڼ�¼GridView�е�ÿҳ��¼��
        protected string PageSize4PrjTab
        {
            get
            {
                string strPageSize4PrjTab;
                strPageSize4PrjTab = (string)Session["PageSize4PrjTab"];
                if (strPageSize4PrjTab == null)
                {
                    strPageSize4PrjTab = "";
                }
                return strPageSize4PrjTab;
            }
            set
            {
                string strPageSize4PrjTab = value;
                Session.Add("PageSize4PrjTab", strPageSize4PrjTab);
            }
        }

        protected void btnAddFldNameToPrjTab_Click(object sender, EventArgs e)
        {
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
            //2��������󲢳�ʼ������
            //ErrorInformationBL.AddInformation("AA", "BB", "AAA", "AA");
            string strMsg;
            string strFldId = "";
            string strCondition = "";
            lblMsg4AddRecord.Text = "";
            //clsFieldTabEN objFieldTabEN;

            List<clsFieldTabEN> arrFieldTabObjLst = null;
            if (string.IsNullOrEmpty(DataTypeId) == true)
            {
                strCondition = string.Format("PrjId = '{0}' and FldName = '{1}' ",
                           clsPubVar.CurrSelPrjId, FldName);
                arrFieldTabObjLst = clsFieldTabBL.GetObjLst(strCondition);
                if (arrFieldTabObjLst.Count == 1)
                {
                    strFldId = arrFieldTabObjLst[0].FldId;
                }
                else if (arrFieldTabObjLst.Count > 1)
                {
                    strMsg = "��ѡ���ֶ�����!";
                    clsCommonJsFunc.Alert(this, strMsg);
                    ddlDataType.Visible = true;
                    lblFldType.Visible = true;
                    ddlDataType.Focus();
                    return;
                }
            }
            if (string.IsNullOrEmpty(strFldId) == true)
            {
                //����Ƿ������ͬ�ֶ���
                strCondition = string.Format("PrjId = '{0}' and FldName = '{1}' And DataTypeId='{2}'",
                              clsPubVar.CurrSelPrjId, FldName, DataTypeId);

                arrFieldTabObjLst = clsFieldTabBL.GetObjLst(strCondition);
                if (arrFieldTabObjLst.Count > 0)    //�ж��Ƿ�����ͬ�Ĺؼ���
                {
                    strFldId = arrFieldTabObjLst[0].FldId;
                }
            }
          List<  string> arrmIdLst = clsCommForWebForm.GetAllCheckedItemFromDg2(dgPrjTabFld1, "chkCheckRec");
            if (arrmIdLst.Count == 0)
            {
                lblMsg4AddRecord.Text = "û��ѡ����¼����ѡ��һ����Ч�ı��¼!";
                return;
            }
            lblMsg4AddRecord.Text = "";
            //1����ʾ�ùؼ��ֵ��������û��޸ĸùؼ��ּ�¼��
            strCondition = string.Format("{0} in ({1})", conPrjTabFld.mId, clsArray.GetSqlInStrByArray( arrmIdLst, false));
            List<clsPrjTabFldEN> arrPrjTabFldLst = clsPrjTabFldBL.GetObjLst(strCondition);
            List<string> arrTabIdLst = new List<string>();
            foreach (clsPrjTabFldEN objPrjTabFldEN in arrPrjTabFldLst)
            {
                if (arrTabIdLst.Contains(objPrjTabFldEN.TabId) == false)
                {
                    arrTabIdLst.Add(objPrjTabFldEN.TabId);
                }
            }
            int intCount = 0;
            if (string.IsNullOrEmpty(strFldId) == false)
            {
                foreach (string strTabId in arrTabIdLst)
                {
                    clsPrjTabFldBLEx.Add_FieldTabToPrjTabFld(strTabId, strFldId, clsCommonSession.UserId);
                    intCount++;
                }
                BindDg_PrjTabFld();
                strMsg = string.Format("�������:[{0}]����¼��", intCount);
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            

            //try
            //{
            //    //�����־
            //    string strUserId = clsCommonSession.UserId;
            //    string strUserIp = Request.UserHostAddress;
            //    string strUserName = clsUsersBL.GetObjByUserId(clsCommonSession.UserId).UserName;
            //    string strOperationType = clsOperationTypeBLEx.ADD_RECORD; //ɾ����¼;
            //    string strTableName = "FieldTab";
            //    string strTableKey = objFieldTabEN.FldId;
            //    string strJournal = "ִ������Ӳ�������ӱ�FieldTab! �ֶ�����"
            //        + objFieldTabEN.Caption + "(" + objFieldTabEN.FldName + ")";

            //    bool IsSuccesful = true;
            //    IsSuccesful = clsSysLogServerBLEx.AddSysLogInfo(strUserId,
            //        strUserIp,
            //        strOperationType,
            //        strTableName,
            //        strTableKey,
            //        strJournal,
            //        clsPubVar.CurrSelPrjId);
            //}
            //catch (Exception objException)
            //{
            //    clsCommonSession.seErrMessage = "��Ӽ�¼�������־���ɹ�!\r\n" + objException.Message;
            //    clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
            //    clsPubFun4Web.AccessError(this, conCurrPageName);
            //}
        }



        public string FldName
        {
            get
            {
                return txtFldName_New.Text.Trim();
            }
            set
            {
                txtFldName_New.Text = value.ToString();
            }
        }


        public string DataTypeId
        {
            get
            {
                if (ddlDataType.SelectedValue == "0")
                {
                    return "";
                }
                return ddlDataType.SelectedValue;
            }
            set
            {
                if (value == "")
                {
                    ddlDataType.SelectedValue = "0";
                }
                else
                {
                    ddlDataType.SelectedValue = value;
                }
            }
        }

        protected void dgPrjTabFld_ItemCommand(object source, DataGridCommandEventArgs e)
        {                  
            string strCommandName = e.CommandName;
            switch (strCommandName)
            {
                case "lbSelAll":
                    System.Web.UI.WebControls.LinkButton lbSelAll;
                    lbSelAll = (LinkButton)e.CommandSource;
                    if (lbSelAll.CommandName != "lbSelAll")
                    {
                        return;
                    }
                    if (lbSelAll.Text == "ȫѡ")
                    {
                        clsCommForWebForm.Set_AllDgCkecked(dgPrjTabFld1, true);
                        lbSelAll.Text = "��ѡ";
                    }
                    else if (lbSelAll.Text == "��ѡ")
                    {
                        clsCommForWebForm.Set_AllDgCkecked(dgPrjTabFld1, false);
                        lbSelAll.Text = "ȫѡ";
                    }
                    break;
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