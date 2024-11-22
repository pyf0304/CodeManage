
using AGC.BusinessLogic;using AGC.FunClass;
using AGC.Entity;
using com.taishsoft.common;
using CommFunc4WebForm;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI.WebControls;

namespace AGC.Webform
{
    /// <summary>
    /// wfmDataGridStyle_QUDI ��ժҪ˵��������Q�����ѯ��U�����޸�
    /// </summary>
    public partial class wfmDataGridStyle_QUDI : CommWebPageBase
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
				strSortDataGridStyleBy = "DGStyleId Asc";
				//2����ʾ�������ı�������DATAGRID��
				BindDg_DataGridStyle();
				//3�����ñ�ؼ����ֿؼ���ReadOnly���ԣ�
				//   ʹֻ֮������Ϊ���޸Ĺ����йؼ����ǲ��ܱ��޸ĵġ�
				wucDataGridStyle1.SetKeyReadOnly(true);
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


        
        ///// <summary>
        ///// ��¼���û�ID�����ڼ���û�Ȩ��
        ///// </summary>
        //protected string vsUserId
        //{
        //    get
        //    {
        //        string strUserId;
        //        strUserId = (string)ViewState["UserId"];
        //        if (strUserId == null)
        //        {
        //            strUserId = "";
        //        }
        //        return strUserId;
        //    }
        //    set
        //    {
        //        string strUserId = value;
        //        ViewState.Add("UserId", strUserId);
        //    }
        //}
	

		
		/// <summary>
		/// �����еĲ�ѯ�ؼ�������ϳ�һ��������
		/// </summary>
		/// <returns>������(strWhereCond)</returns>
		private string CombineDataGridStyleCondition()
		{
			//ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
			//���� 1=1 && UserName = '����'
			string strWhereCond=" 1=1 ";
			//����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
			if (this.txtDGStyleName_q.Text.Trim()!="")
			{
				strWhereCond += " And DataGridStyle.DGStyleName='" + this.txtDGStyleName_q.Text.Trim()+"'";
			}
			return strWhereCond;
		}
		///���ɰ�DATAGRID�Ĵ���
		/// <summary>
		/// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
		///			 ����ʾ��DATAGRID�С�
		/// </summary>
		private void BindDg_DataGridStyle()
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
			string strWhereCond = CombineDataGridStyleCondition();
			//	2��������������ȡ�ñ�����������DataTable��
			System.Data.DataTable objDT = clsDataGridStyleBL.GetDataTable_DataGridStyle(strWhereCond);
			//	3�����DATAGRID�ĵ�ǰҳ���Ƿ񳬳�DATAGRID��ҳ����Χ
			//		3.1 ���ȼ���ҳ����
			//		3.2 �����ǰҳ����ҳ����Ϊ���һҳ
			int intPages = CalcPages(objDT.Rows.Count, this.dgDataGridStyle.PageSize);
			if (intPages==0) 
			{
				this.dgDataGridStyle.CurrentPageIndex = 0;
			}
			else if (this.dgDataGridStyle.CurrentPageIndex > intPages - 1) 
			{
				this.dgDataGridStyle.CurrentPageIndex = intPages - 1;
			}
			//	4������DATAGRID������Դ(DataSource)��
			DataView objDV = objDT.DefaultView;
			objDV.Sort = strSortDataGridStyleBy;     ///ע����һ�д����п�����Ҫע�͵���Ŀǰ���н����ڵ����Ĳ�ѯ������������
			this.dgDataGridStyle.DataSource=objDV;
			//	5����DATAGRID������DataTable��������ʾ��DATAGRID��
			this.dgDataGridStyle.DataBind();

			
			//��ǰ��¼��
			this.lblDataGridStyleRecCount.Text = objDT.Rows.Count.ToString(); 
			//��ǰҳ��
			this.lblDataGridStyleAllPages.Text = this.dgDataGridStyle.PageCount.ToString(); 
			//��ǰҳ����
			this.lblDataGridStyleCurrentPage.Text=(this.dgDataGridStyle.CurrentPageIndex+1).ToString();
			//��ǰ����������ҳ����
			this.txtDataGridStyleJump2Page.Text=(this.dgDataGridStyle.CurrentPageIndex+1).ToString();
			//�����ǰҳ����Ϊ0����<ǰһҳ>��ť��Ч
			if(this.dgDataGridStyle.CurrentPageIndex==0) 
			{
				btnDataGridStylePrevPage.Enabled=false; 
			}
			else 
			{ 
				btnDataGridStylePrevPage.Enabled=true; 
			} 
			//�����ǰҳ������Ϊ���һҳ����<ǰһҳ>��ť��Ч
			if(this.dgDataGridStyle.CurrentPageIndex==this.dgDataGridStyle.PageCount-1) 
			{ 
				btnDataGridStyleNextPage.Enabled=false; 
			} 
			else 
			{ 
				btnDataGridStyleNextPage.Enabled=true; 
			} 
			//7�������沿����ʾ����ʾ �������ǰDataGrid�еļ�¼��Ϊ0������ʾ��ǰ����ҳ������
			if(objDT.Rows.Count>0) 
			{ 
				this.tabDataGridStyleJumpPage.Visible = true; 
			} 
			else 
			{ 
				this.tabDataGridStyleJumpPage.Visible = false; 
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
			this.dgDataGridStyle.CurrentPageIndex=0;
			//�ѱ��¼��������ʾ��DATAGRID��
			BindDg_DataGridStyle();
		}
		/// <summary>
		/// �������ܣ��¼��������ڸ���DATAGRID�ĵ�ǰҳ����ʱ�����ĺ�����
		///			  ���幦����������ʾ��ҳ(������ҳ����)�����ݡ�
		/// </summary>
		/// <param name="source"></param>
		/// <param name="e"></param>
		protected void dgDataGridStyle_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			//�������裺����2����
			//1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
			//2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ

			//1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
			this.dgDataGridStyle.CurrentPageIndex=e.NewPageIndex;
			//2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ
			BindDg_DataGridStyle();
		}
		/// <summary>
		/// �������ܣ����Ըùؼ��ֵļ�¼������ʾ�ڽ����ϣ�
		///������     �������ǰ�ֵ������ؼ���
		/// </summary>
		/// <param name="strDGStyleId">���¼�Ĺؼ��֣���ʾ�ñ�ؼ��ֵ�����</param>
		private void ShowData(string strDGStyleId)
		{
			//�������裺
			//1�����ؼ����Ƿ�Ϊ�գ�
			//2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
			//3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
			//4����ȡ�������������ԣ�
			//5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���

			//1�����ؼ����Ƿ�Ϊ�գ�
			if (strDGStyleId == "") return ;		//����ؼ���Ϊ�վͷ����˳�
			//2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
			if (clsDataGridStyleBL.IsExist(strDGStyleId) == false)		//���ùؼ��ֵļ�¼�Ƿ����
			{
				string ss = "�ؼ���Ϊ��" + strDGStyleId + "�Ĳ�����!";
				clsCommonJsFunc.Alert(this, ss);
				return ;
			}
			//3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
			clsDataGridStyleEN objDataGridStyle = new clsDataGridStyleEN(strDGStyleId);
            //4����ȡ�������������ԣ�
            clsDataGridStyleBL .GetDataGridStyle(ref objDataGridStyle);
			Session.Add("objDataGridStyle", objDataGridStyle);
			//5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���
			GetDataFromDataGridStyleClass(objDataGridStyle);
		}
		///���ɴ��߼�������ݴ��䵽�����ĺ�������
		/// <summary>
		/// �������ܣ�������������������ʾ��������
		///ע�⣺��������������򣬲�����һ��������������ϵ�ģ�����Ϊһ��������ֵ��Ȼ����Ϊ����������ֵ
		///      ������������ݿ�ʱ����Ӧ��һ���ֶ���ǰ�������ֶ��ں�
		/// </summary>
		/// <param name="pobjDataGridStyle">��ʵ�������</param>
		private void GetDataFromDataGridStyleClass(clsDataGridStyleEN pobjDataGridStyle)
		{
			wucDataGridStyle1.DGStyleId = pobjDataGridStyle.DGStyleId;
			wucDataGridStyle1.DGStyleName = pobjDataGridStyle.DGStyleName;
			wucDataGridStyle1.Runat = pobjDataGridStyle.Runat;
			wucDataGridStyle1.FontSize = pobjDataGridStyle.FontSize;
			wucDataGridStyle1.FontName = pobjDataGridStyle.FontName;
			wucDataGridStyle1.AllowPaging = pobjDataGridStyle.AllowPaging;
			wucDataGridStyle1.PageSize = pobjDataGridStyle.PageSize;
			wucDataGridStyle1.AutoGenerateColumns = pobjDataGridStyle.AutoGenerateColumns;
			wucDataGridStyle1.AllowSorting = pobjDataGridStyle.AllowSorting;
			wucDataGridStyle1.IsRadio = pobjDataGridStyle.IsRadio;
			wucDataGridStyle1.IsCheck = pobjDataGridStyle.IsCheck;
			wucDataGridStyle1.IsJumpPage = pobjDataGridStyle.IsJumpPage;
			wucDataGridStyle1.IsHaveUpdBtn = pobjDataGridStyle.IsHaveUpdBtn;
			wucDataGridStyle1.IsHaveDelBtn = pobjDataGridStyle.IsHaveDelBtn;
			wucDataGridStyle1.IsHaveDetailBtn = pobjDataGridStyle.IsHaveDetailBtn;
			wucDataGridStyle1.IsInTab = pobjDataGridStyle.IsInTab;
			wucDataGridStyle1.Style_Zindex = pobjDataGridStyle.Style_Zindex;
			wucDataGridStyle1.Style_Left = pobjDataGridStyle.Style_Left;
			wucDataGridStyle1.Style_Position = pobjDataGridStyle.Style_Position;
			wucDataGridStyle1.Style_Top = pobjDataGridStyle.Style_Top;
			wucDataGridStyle1.Width = pobjDataGridStyle.Width;
			wucDataGridStyle1.Height = pobjDataGridStyle.Height;
			wucDataGridStyle1.Style = pobjDataGridStyle.Style;
			wucDataGridStyle1.IsDefault = pobjDataGridStyle.IsDefault;
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
			
			string strCommandText;
			clsDataGridStyleEN objDataGridStyle;
			Button btnTemp;
			btnTemp = (Button) sender;
			strCommandText = btnTemp.Text;
			switch(strCommandText)
			{
				case "���":
					wucDataGridStyle1.SetKeyReadOnly(false);
					btnOKUpd.Text = "ȷ�����";
                    //wucDataGridStyle1.DGStyleId = clsDataGridStyle.GetMaxStrId("DataGridStyle","DGStyleId", 4, "");
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
					if (!wucDataGridStyle1.IsValid())
					{
						lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
						return ;
					}
					//2��������󲢳�ʼ������
					//clsDataGridStyleEN objDataGridStyle;	//�������
					objDataGridStyle = new clsDataGridStyleEN(wucDataGridStyle1.DGStyleId);	//��ʼ���¶���
					//3���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
					if (clsDataGridStyleBL.IsExist(wucDataGridStyle1.DGStyleId))	//�ж��Ƿ�����ͬ�Ĺؼ���
					{
						strMsg = "�ؼ����ֶ�������ͬ��ֵ";
						clsCommonJsFunc.Alert(this, strMsg);
						return;
					}
					//4����ֵ�ӽ���㴫���߼��������ʵ���
					PutDataToDataGridStyleClass(objDataGridStyle);		//�ѽ����ֵ����
					//5����鴫��ȥ�Ķ��������Ƿ�Ϸ�
					
                    try
                    {
                        clsDataGridStyleBL .CheckPropertyNew(objDataGridStyle);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
					//6��������ʵ�������ݴ��������ݿ���
					if (clsDataGridStyleBL .AddNewRecordBySql2(objDataGridStyle) == false) 
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
					BindDg_DataGridStyle();
					wucDataGridStyle1.Clear();		//��տؼ�������
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
					if (!wucDataGridStyle1.IsValid())
					{
						lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
						return ;
					}
					//2����ֵ�ӽ���㴫���߼��������ʵ���
					objDataGridStyle = (clsDataGridStyleEN) Session["objDataGridStyle"];
					PutDataToDataGridStyleClass(objDataGridStyle);		//�ѽ����ֵ����
					//3����鴫��ȥ�Ķ��������Ƿ�Ϸ�
					
                    try
                    {
                        clsDataGridStyleBL.CheckPropertyNew(objDataGridStyle);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
					
					//4��������ʵ���������޸�ͬ�������ݿ���
					if (clsDataGridStyleBL .UpdateBySql2(objDataGridStyle) == false) 
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
					BindDg_DataGridStyle();
					wucDataGridStyle1.Clear();//��տؼ��е�����
					//�ָ�<ȷ���޸�>���<���>
					btnOKUpd.Text = "���";
					break;
			}
		}
		
		/// <summary>
		/// �������ܣ��ѽ����ϵ��������ݴ����������
		/// </summary>
		/// <param name="pobjDataGridStyle">���ݴ����Ŀ�������</param>
		private void PutDataToDataGridStyleClass(clsDataGridStyleEN pobjDataGridStyle)
		{
			pobjDataGridStyle.DGStyleId = wucDataGridStyle1.DGStyleId;
			pobjDataGridStyle.DGStyleName = wucDataGridStyle1.DGStyleName;
			pobjDataGridStyle.Runat = wucDataGridStyle1.Runat;
			pobjDataGridStyle.FontSize = wucDataGridStyle1.FontSize;
			pobjDataGridStyle.FontName = wucDataGridStyle1.FontName;
			pobjDataGridStyle.AllowPaging = wucDataGridStyle1.AllowPaging;
			pobjDataGridStyle.PageSize = wucDataGridStyle1.PageSize;
			pobjDataGridStyle.AutoGenerateColumns = wucDataGridStyle1.AutoGenerateColumns;
			pobjDataGridStyle.AllowSorting = wucDataGridStyle1.AllowSorting;
			pobjDataGridStyle.IsRadio = wucDataGridStyle1.IsRadio;
			pobjDataGridStyle.IsCheck = wucDataGridStyle1.IsCheck;
			pobjDataGridStyle.IsJumpPage = wucDataGridStyle1.IsJumpPage;
			pobjDataGridStyle.IsHaveUpdBtn = wucDataGridStyle1.IsHaveUpdBtn;
			pobjDataGridStyle.IsHaveDelBtn = wucDataGridStyle1.IsHaveDelBtn;
			pobjDataGridStyle.IsHaveDetailBtn = wucDataGridStyle1.IsHaveDetailBtn;
			pobjDataGridStyle.IsInTab = wucDataGridStyle1.IsInTab;
			pobjDataGridStyle.Style_Zindex = wucDataGridStyle1.Style_Zindex;
			pobjDataGridStyle.Style_Left = wucDataGridStyle1.Style_Left;
			pobjDataGridStyle.Style_Position = wucDataGridStyle1.Style_Position;
			pobjDataGridStyle.Style_Top = wucDataGridStyle1.Style_Top;
			pobjDataGridStyle.Width = wucDataGridStyle1.Width;
			pobjDataGridStyle.Height = wucDataGridStyle1.Height;
			pobjDataGridStyle.Style = wucDataGridStyle1.Style;
			pobjDataGridStyle.IsDefault = wucDataGridStyle1.IsDefault;

		}

		protected void dgDataGridStyle_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
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
			if (strSortDataGridStyleBy == "") return ;
			if(e.Item.ItemType==ListItemType.Header)//����ؼ��Ƿ�Ϊҳü��
			{
				string strSortEx;
				for(int i=0;i<this.dgDataGridStyle.Columns.Count;i++)
				{
					strSortEx = this.dgDataGridStyle.Columns[i].SortExpression;
					if (strSortEx == "") continue;
					intIndex = strSortDataGridStyleBy.IndexOf(strSortEx + " ");
					if(intIndex >=0)  //��ͼ״̬��������ʽ�Ƿ�Ϊ���е��ֶΣ�
					{
						Label lblSort=new Label();
						lblSort.Font.Name="webdings";//�������壬��"webdings"��5�������ǣ�6�������ǣ�
						intIndex = strSortDataGridStyleBy.IndexOf("Asc");
						lblSort.Text=(intIndex>0?" 5":" 6");//�Ƿ�Ϊ���򣬶���Ϊstring�ͣ�
						e.Item.Cells[i].Controls.Add(lblSort);//��������ĵ�i����Ԫ��������һ�ؼ���
						break;
					}
				}
			}
		}

		protected void dgDataGridStyle_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			string strDGStyleId;
			string strCommandName;
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.SelectedItem ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
				strCommandName = ((LinkButton)e.CommandSource).CommandName;
				strDGStyleId = e.Item.Cells[1].Text;
				switch(strCommandName)
				{
					case "Delete":
						clsDataGridStyleBL.DelRecord(strDGStyleId);
						BindDg_DataGridStyle();
						break;
						// Add other cases here, if there are multiple ButtonColumns in 
						// the DataGrid control.
					case "Update":
						//�������裺���ܹ�2����
						//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
						//2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�

						//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
						ShowData(strDGStyleId);
						//2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
						clsPubFun.SetButtonEnabled(btnOKUpd, true);
						wucDataGridStyle1.SetKeyReadOnly(true);
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
					Set_DataGridAllChecked(dgDataGridStyle, true);
					lbSelAll.Text = "��ѡ";
				}
				else if (lbSelAll.Text == "��ѡ")
				{
					Set_DataGridAllChecked(dgDataGridStyle, false);
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
			wucDataGridStyle1.SetKeyReadOnly(false);
			btnOKUpd.Text = "ȷ�����";
			wucDataGridStyle1.DGStyleId = clsDataGridStyleBL.GetMaxStrId_S();
			tabDataGridStyleDataGrid.Visible = false;
			tabLayout.Visible = true;
		}

		
		//��ǰ��¼��
		protected void btnExportExcel4Dg_Click(object sender, System.EventArgs e)
		{
			//	1����Ͻ�����������
			string strWhereCond = CombineDataGridStyleCondition();
			//	2��������������ȡ�ñ�����������DataTable��
			System.Data.DataTable objDT = clsDataGridStyleBL.GetDataTable_DataGridStyle(strWhereCond);
			List<string> arrCnName = new List<string>();
			List<string> arrColName = new List<string>();
			string strFileName = "DataGridStyle��Ϣ����.xls";
			string strFolderName;
			string strDownLoadFileName;
			arrColName.Add("DGStyleId"); arrCnName.Add("DGģʽID");
			arrColName.Add("DGStyleName"); arrCnName.Add("DGģʽ��");
			arrColName.Add("FontSize"); arrCnName.Add("�ֺ�");
			arrColName.Add("IsRadio"); arrCnName.Add("�Ƿ�ѡ��");
			arrColName.Add("IsCheck"); arrCnName.Add("�Ƿ�ѡ��");
			arrColName.Add("IsJumpPage"); arrCnName.Add("�Ƿ���ҳ");
			arrColName.Add("IsHaveUpdBtn"); arrCnName.Add("�Ƿ����޸İ�ť");
			arrColName.Add("IsHaveDelBtn"); arrCnName.Add("�Ƿ���ɾ����ť");
			arrColName.Add("IsHaveDetailBtn"); arrCnName.Add("�Ƿ�����ϸ��ť");
			arrColName.Add("IsInTab"); arrCnName.Add("�Ƿ�����DG�ڱ���");
			arrColName.Add("Width"); arrCnName.Add("��");
			arrColName.Add("Height"); arrCnName.Add("�߶�");
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
            List<string> arrDGStyleId = clsCommForWebForm.GetAllCheckedItemFromDg2(dgDataGridStyle, "chkCheckRec");
			if (arrDGStyleId == null || arrDGStyleId.Count == 0) 
			{
				lblMsg.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
				return ;
			}
			lblMsg.Text = "";
			clsDataGridStyleBL.DelDataGridStyles(arrDGStyleId);
			BindDg_DataGridStyle();
		}

		
		//��ǰ��¼��
		protected void btnUpdate4Dg_Click(object sender, System.EventArgs e)
		{
			string strDGStyleId = clsCommForWebForm.GetFirstCheckedItemFromDg(dgDataGridStyle);
			if (strDGStyleId == null || strDGStyleId.Trim().Length == 0) 
			{
				lblMsg.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
				return ;
			}
			lblMsg.Text = "";
			//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
			ShowData(strDGStyleId);
			//2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
			clsPubFun.SetButtonEnabled(btnOKUpd, true);
			wucDataGridStyle1.SetKeyReadOnly(true);
			btnOKUpd.Text = "ȷ���޸�";	
		}
		
		
		protected void dgDataGridStyle_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
		{
			int intIndex;
			//�ж��Ƿ����µ������ֶ�
			intIndex = strSortDataGridStyleBy.IndexOf(e.SortExpression);
			if (intIndex == -1)
			{
				strSortDataGridStyleBy = e.SortExpression + " Asc";
				BindDg_DataGridStyle();
				return ;
			}
			//���ԭ��������
			intIndex = strSortDataGridStyleBy.IndexOf(" Asc");
			if (intIndex == -1)		//���ԭ���������������Ϊ����
			{
				strSortDataGridStyleBy = e.SortExpression + " Asc";
			}
			else			///��������Ϊ����
			{
				strSortDataGridStyleBy = e.SortExpression + " Desc";
			}
			BindDg_DataGridStyle();
		}

		private string strSortDataGridStyleBy
		{
			get
			{
				string sSortDataGridStyleBy;
				sSortDataGridStyleBy = (string)ViewState["SortDataGridStyleBy"];
				if (sSortDataGridStyleBy==null) 
				{
					sSortDataGridStyleBy = "";
				}
				return sSortDataGridStyleBy;
			}
			set
			{
				string sSortDataGridStyleBy = value;
				ViewState.Add("SortDataGridStyleBy", sSortDataGridStyleBy);
			}
		}

		//���ɸ������SESSION������Ժ���
		protected void btnDataGridStylePrevPage_Click(object sender, System.EventArgs e)
		{
			this.dgDataGridStyle.CurrentPageIndex -=1; 
			this.BindDg_DataGridStyle(); 
		}

		protected void btnDataGridStyleNextPage_Click(object sender, System.EventArgs e)
		{
			this.dgDataGridStyle.CurrentPageIndex +=1; 
			this.BindDg_DataGridStyle(); 
		}

		protected void btnDataGridStyleJumpPage_Click(object sender, System.EventArgs e)
		{
			if(this.txtDataGridStyleJump2Page.Text.Trim()!="" && 
				int.Parse(this.txtDataGridStyleJump2Page.Text)>0 && 
				int.Parse(this.txtDataGridStyleJump2Page.Text)-1<this.dgDataGridStyle.PageCount) 
			{ 
				this.dgDataGridStyle.CurrentPageIndex=int.Parse(this.txtDataGridStyleJump2Page.Text)-1; 
			} 
			this.BindDg_DataGridStyle();
		}

		protected void lbDispDataGridList_Click(object sender, System.EventArgs e)
		{
			tabLayout.Visible = false;
			tabDataGridStyleDataGrid.Visible = true;
		}

		protected void btnAddNewrecByCopy_Click(object sender, System.EventArgs e)
		{
			string strDGStyleId =clsCommForWebForm.GetFirstCheckedItemFromDg(dgDataGridStyle);
			if (strDGStyleId == null || strDGStyleId.Trim().Length == 0) 
			{
				lblMsg.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
				return ;
			}
			lblMsg.Text = "";
			//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
			ShowData(strDGStyleId);
			//2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
			clsPubFun.SetButtonEnabled(btnOKUpd, true);
			wucDataGridStyle1.SetKeyReadOnly(true);
			btnOKUpd.Text = "ȷ�����";
			wucDataGridStyle1.DGStyleId = clsDataGridStyleBL.GetMaxStrId_S();
			tabDataGridStyleDataGrid.Visible = false;
			tabLayout.Visible = true;
		}

		protected void dgDataGridStyle_ItemDataBound(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
		{
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.SelectedItem ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
				int [] iNum= new int[20];
				iNum[0] = 4;
				iNum[1] = 5;
				iNum[2] = 6;
				iNum[3] = 7;
				iNum[4] = 8;
				iNum[5] = 9;
				iNum[6] = 10;
				for (int i = 0; i<7; i++)
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