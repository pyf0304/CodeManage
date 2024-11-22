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

using AGC.BusinessLogic;using AGC.FunClass;

using AGC.BusinessLogicEx;
using AGC.Entity;


using com.taishsoft.common;
using System.Text;
using AutoGCLib;


namespace AGC.Webform
{
	/// <summary>
	/// wfmExcelExportRegionFlds_QUDI ��ժҪ˵��������Q�����ѯ��U�����޸�
	/// </summary>
	public partial class wfmExcelExportRegionFlds_QUDI : CommWebPageBase
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
				//2����ʾ�������ı�������DATAGRID��
				strSortExcelExportRegionFldsBy = "SeqNum Asc";

				BindDg_ExcelExportRegionFlds();
				
				tabEditExcelExportRegionFldsRegion.Visible = false;  //������Ϣά����������

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
		private string SimpleFName  //�������ļ���������Ŀ¼��
		{
			get
			{
				string strSimpleFName;
				strSimpleFName = (string)ViewState["SimpleFName"];
				if (strSimpleFName==null) 
				{
					strSimpleFName = "";
				}
				return strSimpleFName;
			}
			set
			{
				string strSimpleFName = value;
				ViewState.Add("SimpleFName", strSimpleFName);
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


		//���ɷ������Ӵ���Session����
		private string BackViewRegionLinkStr
		{
			get
			{
				string strBackViewRegionLinkStr;
				strBackViewRegionLinkStr = (string)Session["BackViewRegionLinkStr"];
				if (strBackViewRegionLinkStr==null) 
				{
					strBackViewRegionLinkStr = "";
				}
				return strBackViewRegionLinkStr;
			}
			set
			{
				string strBackViewRegionLinkStr = value;
				Session.Add("BackViewRegionLinkStr", strBackViewRegionLinkStr);
			}
		}
        private string RegionId
        {
            get
            {
                string lngRegionId;
                if (Session["RegionId"] == null)
                {
                    lngRegionId = "";
                }
                else
                {
                    string strRegionId = Session["RegionId"].ToString();
                    lngRegionId = strRegionId;
                }
                return lngRegionId;
            }
            set
            {
                string lngRegionId = value;
                Session.Add("RegionId", lngRegionId);
            }
        }



        /// <summary>
        /// �����еĲ�ѯ�ؼ�������ϳ�һ��������
        /// </summary>
        /// <returns>������(strWhereCond)</returns>
        private string CombineExcelExportRegionFldsCondition()
		{
			//ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
			//���� 1=1 && UserName = '����'
			string strWhereCond=" 1=1 and RegionId = " + RegionId;
			//����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
			if (this.txtColCaptionq.Text.Trim()!="")
			{
				strWhereCond += " And ColCaption like '%" + this.txtColCaptionq.Text.Trim()+"%'";
			}
			return strWhereCond;
		}
		///���ɰ�DATAGRID�Ĵ���
		/// <summary>
		/// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
		///			 ����ʾ��DATAGRID�С�
		/// </summary>
		private void BindDg_ExcelExportRegionFlds()
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
			string strWhereCond = CombineExcelExportRegionFldsCondition();
			//	2��������������ȡ�ñ�����������DataTable��
			System.Data.DataTable objDT = clsvExcelExportRegionFldsBL.GetDataTable(strWhereCond + " order by SeqNum" );
			//	3�����DATAGRID�ĵ�ǰҳ���Ƿ񳬳�DATAGRID��ҳ����Χ
			//		3.1 ���ȼ���ҳ����
			//		3.2 �����ǰҳ����ҳ����Ϊ���һҳ
			int intPages = CalcPages(objDT.Rows.Count, this.dgExcelExportRegionFlds.PageSize);
			if (intPages==0) 
			{
				this.dgExcelExportRegionFlds.CurrentPageIndex = 0;
			}
			else if (this.dgExcelExportRegionFlds.CurrentPageIndex > intPages - 1) 
			{
				this.dgExcelExportRegionFlds.CurrentPageIndex = intPages - 1;
			}
			//	4������DATAGRID������Դ(DataSource)��
			DataView objDV = objDT.DefaultView;
			objDV.Sort = strSortExcelExportRegionFldsBy;
			this.dgExcelExportRegionFlds.DataSource=objDV;
			//	5����DATAGRID������DataTable��������ʾ��DATAGRID��
			this.dgExcelExportRegionFlds.DataBind();

			
			//��ǰ��¼��
			this.lblExcelExportRegionFldsRecCount.Text = objDT.Rows.Count.ToString(); 
			//��ǰҳ��
			this.lblExcelExportRegionFldsAllPages.Text = this.dgExcelExportRegionFlds.PageCount.ToString(); 
			//��ǰҳ����
			this.lblExcelExportRegionFldsCurrentPage.Text=(this.dgExcelExportRegionFlds.CurrentPageIndex+1).ToString();
			//��ǰ����������ҳ����
			this.txtExcelExportRegionFldsJump2Page.Text=(this.dgExcelExportRegionFlds.CurrentPageIndex+1).ToString();
			//�����ǰҳ����Ϊ0����<ǰһҳ>��ť��Ч
			if(this.dgExcelExportRegionFlds.CurrentPageIndex==0) 
			{
				btnExcelExportRegionFldsPrevPage.Enabled=false; 
			}
			else 
			{ 
				btnExcelExportRegionFldsPrevPage.Enabled=true; 
			} 
			//�����ǰҳ������Ϊ���һҳ����<ǰһҳ>��ť��Ч
			if(this.dgExcelExportRegionFlds.CurrentPageIndex==this.dgExcelExportRegionFlds.PageCount-1) 
			{ 
				btnExcelExportRegionFldsNextPage.Enabled=false; 
			} 
			else 
			{ 
				btnExcelExportRegionFldsNextPage.Enabled=true; 
			} 
			//7�������沿����ʾ����ʾ �������ǰDataGrid�еļ�¼��Ϊ0������ʾ��ǰ����ҳ������
			if(objDT.Rows.Count>0) 
			{ 
				this.tabExcelExportRegionFldsJumpPage.Visible = true; 
			} 
			else 
			{ 
				this.tabExcelExportRegionFldsJumpPage.Visible = false; 
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
			this.dgExcelExportRegionFlds.CurrentPageIndex=0;
			//�ѱ��¼��������ʾ��DATAGRID��
			BindDg_ExcelExportRegionFlds();
		}
		/// <summary>
		/// �������ܣ��¼��������ڸ���DATAGRID�ĵ�ǰҳ����ʱ�����ĺ�����
		///			  ���幦����������ʾ��ҳ(������ҳ����)�����ݡ�
		/// </summary>
		/// <param name="source"></param>
		/// <param name="e"></param>
		protected void dgExcelExportRegionFlds_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			//�������裺����2����
			//1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
			//2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ

			//1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
			this.dgExcelExportRegionFlds.CurrentPageIndex=e.NewPageIndex;
			//2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ
			BindDg_ExcelExportRegionFlds();
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
			if (clsExcelExportRegionFldsBL.IsExist(lngmId) == false)		//���ùؼ��ֵļ�¼�Ƿ����
			{
				string ss = "�ؼ���Ϊ��" + lngmId + "�Ĳ�����!";
				clsCommonJsFunc.Alert(this, ss);
				return ;
			}
			//3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
			clsExcelExportRegionFldsEN objExcelExportRegionFlds = new clsExcelExportRegionFldsEN(lngmId);
            //4����ȡ�������������ԣ�
            clsExcelExportRegionFldsBL .GetExcelExportRegionFlds(ref objExcelExportRegionFlds);
			Session.Add("objExcelExportRegionFlds", objExcelExportRegionFlds);
			//5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���
			GetDataFromExcelExportRegionFldsClass(objExcelExportRegionFlds);
			DispEditExcelExportRegionFldsRegion();
		}
		///���ɴ��߼�������ݴ��䵽�����ĺ�������
		/// <summary>
		/// �������ܣ�������������������ʾ��������
		///ע�⣺��������������򣬲�����һ��������������ϵ�ģ�����Ϊһ��������ֵ��Ȼ����Ϊ����������ֵ
		///      ������������ݿ�ʱ����Ӧ��һ���ֶ���ǰ�������ֶ��ں�
		/// </summary>
		/// <param name="pobjExcelExportRegionFlds">��ʵ�������</param>
		private void GetDataFromExcelExportRegionFldsClass(clsExcelExportRegionFldsEN pobjExcelExportRegionFlds)
		{
			wucExcelExportRegionFlds1.Memo = pobjExcelExportRegionFlds.Memo;
			wucExcelExportRegionFlds1.SeqNum = pobjExcelExportRegionFlds.SeqNum;
			wucExcelExportRegionFlds1.ColCaption = pobjExcelExportRegionFlds.ColCaption;
			wucExcelExportRegionFlds1.FldId = pobjExcelExportRegionFlds.FldId;
			//clsvExcelExportRegionFldsEN objvExcelExportRegionFlds =  clsvExcelExportRegionFldsBL.GetFirstObj_S("RegionId = '" + RegionId + "' and TabFldId = " + pobjExcelExportRegionFlds.TabFldId);
			//wucExcelExportRegionFlds1.FldName = objvExcelExportRegionFlds.FldName;

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
			clsExcelExportRegionFldsEN objExcelExportRegionFlds;
			Button btnTemp;
			btnTemp = (Button) sender;
			strCommandText = btnTemp.Text;
			switch(strCommandText)
			{
				case "���":
					AddExcelExportRegionFldsRecord();
					break;				
				case "ȷ�����":
					//����һ������Ĳ���Ĵ��룬�����߼���̫�򵥣�
					//�Ͱ��߼���ϲ������Ʋ�,
					AddExcelExportRegionFldsRecordSave();
					break;
				case "ȷ���޸�":
					//����һ��������޸ĵĴ��룬�����߼���̫�򵥣�
					//�Ͱ��߼���ϲ������Ʋ�,
					objExcelExportRegionFlds = (clsExcelExportRegionFldsEN) Session["objExcelExportRegionFlds"];
					UpdateExcelExportRegionFldsRecordSave(objExcelExportRegionFlds);
					break;
			}
		}
		
		/// <summary>
		/// �������ܣ��ѽ����ϵ��������ݴ����������
		/// </summary>
		/// <param name="pobjExcelExportRegionFlds">���ݴ����Ŀ�������</param>
		private void PutDataToExcelExportRegionFldsClass(clsExcelExportRegionFldsEN pobjExcelExportRegionFlds)
		{
			pobjExcelExportRegionFlds.Memo = wucExcelExportRegionFlds1.Memo;
			pobjExcelExportRegionFlds.SeqNum = wucExcelExportRegionFlds1.SeqNum;
			pobjExcelExportRegionFlds.ColCaption = wucExcelExportRegionFlds1.ColCaption;
			pobjExcelExportRegionFlds.FldId = wucExcelExportRegionFlds1.FldId;
		}

		protected void dgExcelExportRegionFlds_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
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
			if (strSortExcelExportRegionFldsBy == "") return ;
			if(e.Item.ItemType==ListItemType.Header)//����ؼ��Ƿ�Ϊҳü��
			{
				string strSortEx;
				for(int i=0;i<this.dgExcelExportRegionFlds.Columns.Count;i++)
				{
					strSortEx = this.dgExcelExportRegionFlds.Columns[i].SortExpression;
					if (strSortEx == "") continue;
					intIndex = strSortExcelExportRegionFldsBy.IndexOf(strSortEx + " ");
					if(intIndex >=0)  //��ͼ״̬��������ʽ�Ƿ�Ϊ���е��ֶΣ�
					{
						Label lblSort=new Label();
						lblSort.Font.Name="webdings";//�������壬��"webdings"��5�������ǣ�6�������ǣ�
						intIndex = strSortExcelExportRegionFldsBy.IndexOf("Asc");
						lblSort.Text=(intIndex>0?" 5":" 6");//�Ƿ�Ϊ���򣬶���Ϊstring�ͣ�
						e.Item.Cells[i].Controls.Add(lblSort);//��������ĵ�i����Ԫ��������һ�ؼ���
						break;
					}
				}
			}
		}

		protected void dgExcelExportRegionFlds_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
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
						DeleteExcelExportRegionFldsRecord(lngmId);
						break;
						// Add other cases here, if there are multiple ButtonColumns in 
						// the DataGrid control.
					case "Update":
						UpdateExcelExportRegionFldsRecord(lngmId);
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
					Set_DataGridAllChecked(dgExcelExportRegionFlds, true);
					lbSelAll.Text = "��ѡ";
				}
				else if (lbSelAll.Text == "��ѡ")
				{
					Set_DataGridAllChecked(dgExcelExportRegionFlds, false);
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
			DispPrjTabFldsInfo();
			
		}

		
		//��ǰ��¼��
		protected void btnExportExcel4Dg_Click(object sender, System.EventArgs e)
		{
			//	1����Ͻ�����������
			string strWhereCond = CombineExcelExportRegionFldsCondition();
			//	2��������������ȡ�ñ�����������DataTable��
			System.Data.DataTable objDT = null;
			List<string> arrCnName = new List<string>();
			List<string> arrColName = new List<string>();
			string strFileName = "ExcelExportRegionFlds��Ϣ����.xls";
			string strFolderName;
			string strDownLoadFileName;
			arrColName.Add("mId"); arrCnName.Add("mId");
			arrColName.Add("TabName"); arrCnName.Add("����");
			arrColName.Add("FldName"); arrCnName.Add("�ֶ���");
            arrColName.Add("DataTypeId"); arrCnName.Add("�ֶ�����");
			arrColName.Add("FldLength"); arrCnName.Add("�ֶγ���");
			arrColName.Add("Caption"); arrCnName.Add("����");
			arrColName.Add("IsNull"); arrCnName.Add("�Ƿ�ɿ�");
			arrColName.Add("IsTabPrimary"); arrCnName.Add("�Ƿ���Ϊ��������");
			arrColName.Add("SequenceNumber"); arrCnName.Add("˳���");
			arrColName.Add("IsParentObj"); arrCnName.Add("�Ƿ񸸶���");
			arrColName.Add("PrimaryTypeName"); arrCnName.Add("����������");
			arrColName.Add("DataTypeName"); arrCnName.Add("DataTypeName");
			arrColName.Add("RegionId"); arrCnName.Add("����Id");
			arrColName.Add("IsTabNullable"); arrCnName.Add("�Ƿ���пɿ�");
			arrColName.Add("SeqNum"); arrCnName.Add("�����");
			arrColName.Add("ColCaption"); arrCnName.Add("�б���");
			arrColName.Add("TabFldId"); arrCnName.Add("���ֶ�ID");
			strFolderName = Server.MapPath("~") +  "\\TempFiles\\";
			strDownLoadFileName = strFolderName + strFileName;
            try
            {
                objDT = clsvExcelExportRegionFldsBL.GetDataTable(strWhereCond);
                GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4Odbc(objDT, arrColName, arrCnName, strDownLoadFileName);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;	//"../GenCode/wfmGenViewCode_WebV5.aspx";
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
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
            List<string> arrmId = clsCommForWebForm.GetAllCheckedItemFromDg2(dgExcelExportRegionFlds, "chkCheckRec");
			if (arrmId == null || arrmId.Count == 0) 
			{
				lblMsg1.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
				return ;
			}
			lblMsg1.Text = "";
			clsExcelExportRegionFldsBL.DelExcelExportRegionFldss(arrmId);
			BindDg_ExcelExportRegionFlds();
		}

		
		//��ǰ��¼��
		protected void btnUpdate4Dg_Click(object sender, System.EventArgs e)
		{
			string strmId =clsCommForWebForm.GetFirstCheckedItemFromDg(dgExcelExportRegionFlds);
			if (strmId == null || strmId.Trim().Length == 0) 
			{
				lblMsg1.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
				return ;
			}
			lblMsg1.Text = "";
			//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
			long lngmId;
			lngmId = long.Parse(strmId);
			ShowData(lngmId);
			//2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
			clsPubFun.SetButtonEnabled(btnOKUpd, true);
			btnOKUpd.Text = "ȷ���޸�";	
		}
		

		//���ɸ������SESSION������Ժ���
		protected void btnExcelExportRegionFldsPrevPage_Click(object sender, System.EventArgs e)
		{
			this.dgExcelExportRegionFlds.CurrentPageIndex -=1; 
			this.BindDg_ExcelExportRegionFlds(); 
		}

		protected void btnExcelExportRegionFldsNextPage_Click(object sender, System.EventArgs e)
		{
			this.dgExcelExportRegionFlds.CurrentPageIndex +=1; 
			this.BindDg_ExcelExportRegionFlds(); 
		}

		protected void btnExcelExportRegionFldsJumpPage_Click(object sender, System.EventArgs e)
		{
			if(this.txtExcelExportRegionFldsJump2Page.Text.Trim()!="" && 
				int.Parse(this.txtExcelExportRegionFldsJump2Page.Text)>0 && 
				int.Parse(this.txtExcelExportRegionFldsJump2Page.Text)-1<this.dgExcelExportRegionFlds.PageCount) 
			{ 
				this.dgExcelExportRegionFlds.CurrentPageIndex=int.Parse(this.txtExcelExportRegionFldsJump2Page.Text)-1; 
			} 
			this.BindDg_ExcelExportRegionFlds();
		}

		///���ɵĲ����¼׼�����̴���for C#
		private void AddExcelExportRegionFldsRecord()
		{
			btnOKUpd.Text = "ȷ�����";

		}
		///�����¼���̹��̴���for C#
		private void AddExcelExportRegionFldsRecordSave()
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
			clsExcelExportRegionFldsEN objExcelExportRegionFlds;
			//1�����ؼ����������������Ƿ���ȷ
			if (!wucExcelExportRegionFlds1.IsValid(ref strResult))
			{
				lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
				return ;
			}
			//2��������󲢳�ʼ������
			//clsExcelExportRegionFldsEN objExcelExportRegionFlds;	//�������
			objExcelExportRegionFlds = new clsExcelExportRegionFldsEN();	//��ʼ���¶���
			//3���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
			//4����ֵ�ӽ���㴫���߼��������ʵ���
			PutDataToExcelExportRegionFldsClass(objExcelExportRegionFlds);		//�ѽ����ֵ����
			//5����鴫��ȥ�Ķ��������Ƿ�Ϸ�
			try
			{
                clsExcelExportRegionFldsBL .CheckPropertyNew(objExcelExportRegionFlds);
                //6��������ʵ�������ݴ��������ݿ���
                clsExcelExportRegionFldsBL .AddNewRecordBySql2(objExcelExportRegionFlds);
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
			BindDg_ExcelExportRegionFlds();
			wucExcelExportRegionFlds1.Clear();		//��տؼ�������
			///�ָ�<ȷ�����>���<���>
			btnOKUpd.Text = "���";
		}
		///�����¼���̹��̴���for C#
		private void AddExcelExportRegionFldsRecordSaveV5()
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
			clsExcelExportRegionFldsEN objExcelExportRegionFlds;
			//1�����ؼ����������������Ƿ���ȷ
			if (!wucExcelExportRegionFlds1.IsValid(ref strResult))
			{
				lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
				return ;
			}
			//2��������󲢳�ʼ������
			//clsExcelExportRegionFldsEN objExcelExportRegionFlds;	//�������
			objExcelExportRegionFlds = new clsExcelExportRegionFldsEN();	//��ʼ���¶���
			//3���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
			//4����ֵ�ӽ���㴫���߼��������ʵ���
			PutDataToExcelExportRegionFldsClass(objExcelExportRegionFlds);		//�ѽ����ֵ����
			//5����鴫��ȥ�Ķ��������Ƿ�Ϸ�
			try
			{
                clsExcelExportRegionFldsBL.CheckPropertyNew(objExcelExportRegionFlds);
                //6��������ʵ�������ݴ��������ݿ���
                clsExcelExportRegionFldsBL .AddNewRecordBySql2(objExcelExportRegionFlds);
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
			BindDg_ExcelExportRegionFlds();
			wucExcelExportRegionFlds1.Clear();		//��տؼ�������
			///�ָ�<ȷ�����>���<���>
			btnOKUpd.Text = "���";
		}
		///�����޸ļ�¼׼�����̴��� for C#
		private void UpdateExcelExportRegionFldsRecord(long lngmId)
		{
			//�������裺���ܹ�2����
			//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
			//2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�

			//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
			ShowData(lngmId);
			//2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
			clsPubFun.SetButtonEnabled(btnOKUpd, true);
			btnOKUpd.Text = "ȷ���޸�";
			lblMsg.Text = "";
		}
		///�޸Ĵ���׼�����̴��� for C#
		private void UpdateExcelExportRegionFldsRecordSave(clsExcelExportRegionFldsEN objExcelExportRegionFlds)
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
			if (!wucExcelExportRegionFlds1.IsValid(ref strResult))
			{
				lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
				return ;
			}
			//2����ֵ�ӽ���㴫���߼��������ʵ���
			PutDataToExcelExportRegionFldsClass(objExcelExportRegionFlds);		//�ѽ����ֵ����
			//3����鴫��ȥ�Ķ��������Ƿ�Ϸ�
			try
			{
                clsExcelExportRegionFldsBL.CheckPropertyNew(objExcelExportRegionFlds);
                //6��������ʵ�������ݴ��������ݿ���
                clsExcelExportRegionFldsBL .UpdateBySql2(objExcelExportRegionFlds);
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
			BindDg_ExcelExportRegionFlds();
			wucExcelExportRegionFlds1.Clear();//��տؼ��е�����
			//�ָ�<ȷ���޸�>���<���>
			btnOKUpd.Text = "���";
			DispExcelExportRegionFldsInfo();
		}
		///�޸Ĵ���׼�����̴��� for C#
		private void UpdateExcelExportRegionFldsRecordSaveV5(clsExcelExportRegionFldsEN objExcelExportRegionFlds)
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
			if (!wucExcelExportRegionFlds1.IsValid(ref strResult))
			{
				lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
				return ;
			}
			//2����ֵ�ӽ���㴫���߼��������ʵ���
			PutDataToExcelExportRegionFldsClass(objExcelExportRegionFlds);		//�ѽ����ֵ����
			//3����鴫��ȥ�Ķ��������Ƿ�Ϸ�
			try
			{
                clsExcelExportRegionFldsBL.CheckPropertyNew(objExcelExportRegionFlds);
                //6��������ʵ�������ݴ��������ݿ���
                clsExcelExportRegionFldsBL .UpdateBySql2(objExcelExportRegionFlds);
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
			BindDg_ExcelExportRegionFlds();
			wucExcelExportRegionFlds1.Clear();//��տؼ��е�����
			//�ָ�<ȷ���޸�>���<���>
			btnOKUpd.Text = "���";
		}
		///ɾ����¼���̴���for C#
		private void DeleteExcelExportRegionFldsRecord(long lngmId)
		{
			clsExcelExportRegionFldsBL.DelRecord(lngmId);
			BindDg_ExcelExportRegionFlds();
		}

		protected void btnCopyFldFromRelaTab_Click(object sender, System.EventArgs e)
		{
			//�������裺
			//1����ȡ��ǰ����ID���������ID��
			//2����ȡ�������ID���ֶ�ID�Ķ����б�;
			//2�����ؼ����������������Ƿ���ȷ
			//2��������󲢳�ʼ������
			//3���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
			//4����ֵ�ӽ���㴫���߼��������ʵ���
			//5����鴫��ȥ�Ķ��������Ƿ�Ϸ�
			//6��������ʵ�������ݴ��������ݿ���
			//7��������ļ�¼������ʾ��DATAGRID��
			
			try
			{
                clsExcelExportRegionFldsBLEx.ImportRelaFlds(RegionId, clsPubVar.CurrCmPrjId, UserId);
			}
			catch(Exception objException)
			{
				clsCommonSession.seErrMessage = "���������ֶ��б��ɹ�!" + objException.Message;
				clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
				clsPubFun4Web.AccessError(this, conCurrPageName);
			}

			BindDg_ExcelExportRegionFlds();
			///�ָ�<ȷ�����>���<���>
			//		lbDispFldList_Click(new object(), new System.EventArgs());
			Response.Write("<script>alert('�������ص������ֶ���Ϣ���Ƴɹ�����')</script>");

		}

		protected void btnGoBack_Click(object sender, System.EventArgs e)
		{
			if (BackViewRegionLinkStr !="")
			{
				Response.Redirect(BackViewRegionLinkStr);
			}
		}

		protected void dgExcelExportRegionFlds_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
		{
			int intIndex;
			//�ж��Ƿ����µ������ֶ�
			intIndex = strSortExcelExportRegionFldsBy.IndexOf(e.SortExpression);
			if (intIndex == -1)
			{
				strSortExcelExportRegionFldsBy = e.SortExpression + " Asc";
				BindDg_ExcelExportRegionFlds();
				return ;
			}
			//���ԭ��������
			intIndex = strSortExcelExportRegionFldsBy.IndexOf(" Asc");
			if (intIndex == -1)		//���ԭ���������������Ϊ����
			{
				strSortExcelExportRegionFldsBy = e.SortExpression + " Asc";
			}
			else			///��������Ϊ����
			{
				strSortExcelExportRegionFldsBy = e.SortExpression + " Desc";
			}
			BindDg_ExcelExportRegionFlds();

		}
		private void DispExcelExportRegionFldsInfo()
		{
			tabExcelExportRegionFldsDataGrid.Visible = true;
			tabExcelExportRegionFldsJumpPage.Visible = true;
			tabEditExcelExportRegionFldsRegion.Visible = false;
			
			tabExcelExportRegionPreview.Visible = true;
			tabCode.Visible = true;
		}
		private void DispPrjTabFldsInfo()
		{			
			tabEditExcelExportRegionFldsRegion.Visible = false;
			tabExcelExportRegionFldsDataGrid.Visible = false;
			tabExcelExportRegionFldsJumpPage.Visible = false;
			tabExcelExportRegionPreview.Visible = false;
			tabCode.Visible = false;
		}
		private void DispEditExcelExportRegionFldsRegion()
		{
			tabExcelExportRegionFldsDataGrid.Visible = false;
			tabExcelExportRegionFldsJumpPage.Visible = false;
			tabEditExcelExportRegionFldsRegion.Visible = true;

			tabExcelExportRegionPreview.Visible = false;
			tabCode.Visible = false;
		}


		protected void btnUpMove_Click(object sender, System.EventArgs e)
		{
			string strMsg;
			string strmId =clsCommForWebForm.GetFirstCheckedItemFromDg(dgExcelExportRegionFlds);
			if (strmId == null || strmId.Trim().Length == 0) 
			{
				lblMsg1.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
				return ;
			}
			lblMsg1.Text = "";

			long lngmId;
			lngmId = long.Parse(strmId);
			try
			{
				clsExcelExportRegionFldsBLEx.AdjustSequenceNumber("UP", lngmId);
			}
			
			catch(Exception objException)
			{
				strMsg = objException.Message;
				clsCommonJsFunc.Alert(this, strMsg);
				lblMsg1.Text = strMsg;
				//				clsCommonSession.seErrMessage = objException.Message;
				//				clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;	//"../GenCode/wfmGenViewCode_WebV5.aspx";
				//				clsPubFun4Web.AccessError(this, conCurrPageName);
			}
			BindDg_ExcelExportRegionFlds();
			clsCommForWebForm.SetCheckedItemForDg(dgExcelExportRegionFlds, 1, strmId);

		}

		protected void btnDownMove_Click(object sender, System.EventArgs e)
		{
			string strMsg;
			string strmId =clsCommForWebForm.GetFirstCheckedItemFromDg(dgExcelExportRegionFlds);
			if (strmId == null || strmId.Trim().Length == 0) 
			{
				lblMsg1.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
				return ;
			}
			lblMsg1.Text = "";

			long lngmId;
			lngmId = long.Parse(strmId);
			try
			{
				
				clsExcelExportRegionFldsBLEx.AdjustSequenceNumber("DOWN", lngmId);
			}
			
			catch(Exception objException)
			{
				strMsg = objException.Message;
				clsCommonJsFunc.Alert(this, strMsg);
				lblMsg1.Text = strMsg;
				//				clsCommonSession.seErrMessage = objException.Message;
				//				clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;	//"../GenCode/wfmGenViewCode_WebV5.aspx";
				//				clsPubFun4Web.AccessError(this, conCurrPageName);
			}
			BindDg_ExcelExportRegionFlds();
			clsCommForWebForm.SetCheckedItemForDg(dgExcelExportRegionFlds, 1, strmId);

		}

		protected void btnReOrder_Click(object sender, System.EventArgs e)
		{
			clsExcelExportRegionFldsBLEx.ReOrder(RegionId);
			BindDg_ExcelExportRegionFlds();
		}

		protected void btnPreView_Click(object sender, System.EventArgs e)
		{
			string strMsg;
            string strViewId = clsCommonSession.ViewId;// clsViewRegionBL.GetObjByRegionId(RegionId).ViewId;
			//			tabQuery1.Visible = false;
			tabCode.Visible = true;
            string strRe_ClsName = "";
            string strRe_FileNameWithModuleName = "";
            
            //������ش���
            Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);

            try
            {

                clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
                clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, clsPubVar.CurrSelPrjId);
				WebViewCode4Html autoGC5Cs_VWeb = new WebViewCode4Html(strViewId);
				objViewInfoENEx.FolderName = "D:\\FTP\\ClsFile\\" + UserId + "\\";
                objViewInfoENEx.CurrUserName = clsCommonSession.UserName;
                ShowCode(autoGC5Cs_VWeb.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName));
                if (objViewInfoENEx.FileName != null)
				{
					txtFileName4GenCode.Text = objViewInfoENEx.FileName;
					SimpleFName = clsString.GetSimpleFName_S(objViewInfoENEx.FileName);
				}
				//��ʾ��ؿؼ�
				///
				if (WebViewCode4Html.DispExcelExportRegionCtrl(phExcelExportRegion, objViewInfoENEx) == true)
				{
					
				};
			}
			catch(Exception objException)
			{
				strMsg = objException.Message;
				clsCommonJsFunc.Alert(this, strMsg);
				lblMsg1.Text = strMsg;
				//				clsCommonSession.seErrMessage = objException.Message;
				//				clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;	//"../GenCode/wfmGenViewCode_WebV5.aspx";
				//				clsPubFun4Web.AccessError(this, conCurrPageName);
			}
		}

		protected void LinkButton1_Click(object sender, System.EventArgs e)
		{
			DispExcelExportRegionFldsInfo();
		}

		protected void lbDispTabList_Click(object sender, System.EventArgs e)
		{
			DispExcelExportRegionFldsInfo();
		}

		private string strSortExcelExportRegionFldsBy
		{
			get
			{
				string sstrSortExcelExportRegionFldsBy;
				sstrSortExcelExportRegionFldsBy = (string)ViewState["strSortExcelExportRegionFldsBy"];
				if (sstrSortExcelExportRegionFldsBy==null) 
				{
					sstrSortExcelExportRegionFldsBy = "";
				}
				return sstrSortExcelExportRegionFldsBy;
			}
			set
			{
				string sstrSortExcelExportRegionFldsBy = value;
				ViewState.Add("strSortExcelExportRegionFldsBy", sstrSortExcelExportRegionFldsBy);
			}
		}
        protected void lbDownLoadFile_Click(object sender, EventArgs e)
        {

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
        public void ShowCode(string strCode)
        {
            StringBuilder sbJs = new StringBuilder();
            //sbJs.Append("<script type=\"text/javascript\">");
            sbJs.AppendFormat("<textarea style=\"width: 100%; height: 720px; \">", strCode);
            sbJs.AppendFormat("{0}", strCode);
            sbJs.AppendFormat("</textarea>", strCode);
            //sbJs.Append("</script>");
            litCode.Text = sbJs.ToString();
        }
    }
}