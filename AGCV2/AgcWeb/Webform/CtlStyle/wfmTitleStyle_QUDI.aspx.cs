
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


using AGC.BusinessLogic;using AGC.FunClass;
using AGC.BusinessLogicEx;

using AGC.Entity;

namespace AGC.Webform
{
	/// <summary>
	/// wfmTitleStyle_QUDI ��ժҪ˵��������Q�����ѯ��U�����޸�
	/// </summary>
	public partial class wfmTitleStyle_QUDI : System.Web.UI.Page
	{

		protected void Page_Load(object sender, System.EventArgs e)
		{
			// �ڴ˴������û������Գ�ʼ��ҳ��
			if (!IsPostBack)	///����������ǳ��α����ã������ǵ�����ť�¼�������
			{
				//1��Ϊ��������������Դ�����б�����
				wucTitleStyle1.SetDdl_TitleTypeId();
				BindDdl_TitleTypeId(ddlTitleTypeIdq);
                clsProjectsBLEx.BindDdl_PrjIdCacheEx(ddlPrjId);
				strSortBy = "TitleStyleId Asc";
				//2����ʾ�������ı�������DATAGRID��
				BindDg_TitleStyle();
				//3�����ñ�ؼ����ֿؼ���ReadOnly���ԣ�
				//   ʹֻ֮������Ϊ���޸Ĺ����йؼ����ǲ��ܱ��޸ĵġ�
				wucTitleStyle1.SetKeyReadOnly(true);
			}
		}

        //private string PrjId
        //{
        //    get
        //    {
        //        string strPrjId;
        //        strPrjId = (string)Session["P1rjId"];
        //        if (strPrjId==null) 
        //        {
        //            strPrjId = "";
        //            clsCommForWebForm.CheckPrjId(strPrjId, this);
        //        }
        //        return strPrjId;
        //    }
        //    set
        //    {
        //        string strPrjId = value;
        //        Session.Add("PrjId", strPrjId);
        //    }
        //}
		
		/// <summary>
		/// �����еĲ�ѯ�ؼ�������ϳ�һ��������
		/// </summary>
		/// <returns>������(strWhereCond)</returns>
		private string CombineCondition()
		{
			//ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
			//���� 1=1 && UserName = '����'
            string strWhereCond = " 1=1 and PrjId='" + clsPubVar.CurrSelPrjId + "'";
			//����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
			if (this.txtTitleStyleNameq.Text.Trim()!="")
			{
				strWhereCond += " And TitleStyleName='" + this.txtTitleStyleNameq.Text.Trim()+"'";
			}
			if (this.ddlTitleTypeIdq.SelectedValue!="" && this.ddlTitleTypeIdq.SelectedValue!="0")
			{
				strWhereCond += " And TitleTypeId='" + this.ddlTitleTypeIdq.SelectedValue+"'";
			}
			return strWhereCond;
		}
		///���ɰ�DATAGRID�Ĵ���
		/// <summary>
		/// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
		///			 ����ʾ��DATAGRID�С�
		/// </summary>
		private void BindDg_TitleStyle()
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
			System.Data.DataTable objDT = clsvTitleStyleBL.GetDataTable(strWhereCond);
			//	3�����DATAGRID�ĵ�ǰҳ���Ƿ񳬳�DATAGRID��ҳ����Χ
			//		3.1 ���ȼ���ҳ����
			//		3.2 �����ǰҳ����ҳ����Ϊ���һҳ
			int intPages = CalcPages(objDT.Rows.Count, this.dgTitleStyle.PageSize);
			if (intPages==0) 
			{
				this.dgTitleStyle.CurrentPageIndex = 0;
			}
			else if (this.dgTitleStyle.CurrentPageIndex > intPages - 1) 
			{
				this.dgTitleStyle.CurrentPageIndex = intPages - 1;
			}
			//	4������DATAGRID������Դ(DataSource)��
			DataView objDV = objDT.DefaultView;
			objDV.Sort = strSortBy;     ///ע����һ�д����п�����Ҫע�͵���Ŀǰ���н����ڵ����Ĳ�ѯ������������
			this.dgTitleStyle.DataSource=objDV;
			//	5����DATAGRID������DataTable��������ʾ��DATAGRID��
			this.dgTitleStyle.DataBind();

			
			//��ǰ��¼��
			this.lblTitleStyleRecCount.Text = objDT.Rows.Count.ToString(); 
			//��ǰҳ��
			this.lblTitleStyleAllPages.Text = this.dgTitleStyle.PageCount.ToString(); 
			//��ǰҳ����
			this.lblTitleStyleCurrentPage.Text=(this.dgTitleStyle.CurrentPageIndex+1).ToString();
			//��ǰ����������ҳ����
			this.txtTitleStyleJump2Page.Text=(this.dgTitleStyle.CurrentPageIndex+1).ToString();
			//�����ǰҳ����Ϊ0����<ǰһҳ>��ť��Ч
			if(this.dgTitleStyle.CurrentPageIndex==0) 
			{
				btnTitleStylePrevPage.Enabled=false; 
			}
			else 
			{ 
				btnTitleStylePrevPage.Enabled=true; 
			} 
			//�����ǰҳ������Ϊ���һҳ����<ǰһҳ>��ť��Ч
			if(this.dgTitleStyle.CurrentPageIndex==this.dgTitleStyle.PageCount-1) 
			{ 
				btnTitleStyleNextPage.Enabled=false; 
			} 
			else 
			{ 
				btnTitleStyleNextPage.Enabled=true; 
			} 
			//7�������沿����ʾ����ʾ �������ǰDataGrid�еļ�¼��Ϊ0������ʾ��ǰ����ҳ������
			if(objDT.Rows.Count>0) 
			{ 
				this.tabTitleStyleJumpPage.Visible = true; 
			} 
			else 
			{ 
				this.tabTitleStyleJumpPage.Visible = false; 
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
			this.dgTitleStyle.CurrentPageIndex=0;
			//�ѱ��¼��������ʾ��DATAGRID��
			BindDg_TitleStyle();
		}
		/// <summary>
		/// �������ܣ��¼��������ڸ���DATAGRID�ĵ�ǰҳ����ʱ�����ĺ�����
		///			  ���幦����������ʾ��ҳ(������ҳ����)�����ݡ�
		/// </summary>
		/// <param name="source"></param>
		/// <param name="e"></param>
		protected void dgTitleStyle_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			//�������裺����2����
			//1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
			//2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ

			//1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
			this.dgTitleStyle.CurrentPageIndex=e.NewPageIndex;
			//2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ
			BindDg_TitleStyle();
		}
		/// <summary>
		/// �������ܣ����Ըùؼ��ֵļ�¼������ʾ�ڽ����ϣ�
		///������     �������ǰ�ֵ������ؼ���
		/// </summary>
		/// <param name="strTitleStyleId">���¼�Ĺؼ��֣���ʾ�ñ�ؼ��ֵ�����</param>
		private void ShowData(string strTitleStyleId)
		{
			//�������裺
			//1�����ؼ����Ƿ�Ϊ�գ�
			//2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
			//3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
			//4����ȡ�������������ԣ�
			//5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���

			//1�����ؼ����Ƿ�Ϊ�գ�
			if (strTitleStyleId == "") return ;		//����ؼ���Ϊ�վͷ����˳�
			//2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
			if (clsTitleStyleBL.IsExist(strTitleStyleId) == false)		//���ùؼ��ֵļ�¼�Ƿ����
			{
				string ss = "�ؼ���Ϊ��" + strTitleStyleId + "�Ĳ�����!";
				clsCommonJsFunc.Alert(this, ss);
				return ;
			}
			//3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
			clsTitleStyleEN objTitleStyle = new clsTitleStyleEN(strTitleStyleId);
            //4����ȡ�������������ԣ�
            clsTitleStyleBL .GetTitleStyle(ref objTitleStyle);
			Session.Add("objTitleStyle", objTitleStyle);
			//5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���
			GetDataFromTitleStyleClass(objTitleStyle);
		}
		///���ɴ��߼�������ݴ��䵽�����ĺ�������
		/// <summary>
		/// �������ܣ�������������������ʾ��������
		///ע�⣺��������������򣬲�����һ��������������ϵ�ģ�����Ϊһ��������ֵ��Ȼ����Ϊ����������ֵ
		///      ������������ݿ�ʱ����Ӧ��һ���ֶ���ǰ�������ֶ��ں�
		/// </summary>
		/// <param name="pobjTitleStyle">��ʵ�������</param>
		private void GetDataFromTitleStyleClass(clsTitleStyleEN pobjTitleStyle)
		{
			wucTitleStyle1.TitleStyleId = pobjTitleStyle.TitleStyleId;
			wucTitleStyle1.TitleStyleName = pobjTitleStyle.TitleStyleName;
			wucTitleStyle1.ImgFile = pobjTitleStyle.ImgFile;
			wucTitleStyle1.TabHeight = pobjTitleStyle.TabHeight;
			wucTitleStyle1.TabWidth = pobjTitleStyle.TabWidth;
			wucTitleStyle1.TitleTypeId = pobjTitleStyle.TitleTypeId;
			wucTitleStyle1.BackColor = pobjTitleStyle.BackColor;
			wucTitleStyle1.ForeColor = pobjTitleStyle.ForeColor;
			wucTitleStyle1.FontSize = pobjTitleStyle.FontSize;
			wucTitleStyle1.FontName = pobjTitleStyle.FontName;
			wucTitleStyle1.PrjId = pobjTitleStyle.PrjId;
			wucTitleStyle1.IsDefault = pobjTitleStyle.IsDefault;

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
			clsTitleStyleEN objTitleStyle;
			Button btnTemp;
			btnTemp = (Button) sender;
			strCommandText = btnTemp.Text;
			switch(strCommandText)
			{
				case "���":
					wucTitleStyle1.SetKeyReadOnly(false);
					btnOKUpd.Text = "ȷ�����";
                    wucTitleStyle1.TitleStyleId = clsTitleStyleBL.GetMaxStrIdByPrefix_S(clsPubVar.CurrSelPrjId);
                    wucTitleStyle1.PrjId = clsPubVar.CurrSelPrjId;
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
					if (!wucTitleStyle1.IsValid())
					{
						lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
						return ;
					}
					//2��������󲢳�ʼ������
					//clsTitleStyleEN objTitleStyle;	//�������
					objTitleStyle = new clsTitleStyleEN(wucTitleStyle1.TitleStyleId);	//��ʼ���¶���
					//3���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
					if (clsTitleStyleBL.IsExist(wucTitleStyle1.TitleStyleId))	//�ж��Ƿ�����ͬ�Ĺؼ���
					{
						strMsg = "�ؼ����ֶ�������ͬ��ֵ";
						clsCommonJsFunc.Alert(this, strMsg);
						return;
					}
					//4����ֵ�ӽ���㴫���߼��������ʵ���
					PutDataToTitleStyleClass(objTitleStyle);		//�ѽ����ֵ����
					//5����鴫��ȥ�Ķ��������Ƿ�Ϸ�
                    try
                    {
                        clsTitleStyleBL .CheckPropertyNew(objTitleStyle);
                    }
                    catch(Exception objException)
					{
                        clsCommonJsFunc.Alert(this, objException.Message);
						return ; 
					}
					//6��������ʵ�������ݴ��������ݿ���
					if (clsTitleStyleBL .AddNewRecordBySql2(objTitleStyle) == false) 
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
					BindDg_TitleStyle();
					wucTitleStyle1.Clear();		//��տؼ�������
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
					if (!wucTitleStyle1.IsValid())
					{
						lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
						return ;
					}
					//2����ֵ�ӽ���㴫���߼��������ʵ���
					objTitleStyle = (clsTitleStyleEN) Session["objTitleStyle"];
					PutDataToTitleStyleClass(objTitleStyle);		//�ѽ����ֵ����
					//3����鴫��ȥ�Ķ��������Ƿ�Ϸ�
                    try
                    {
                        clsTitleStyleBL.CheckPropertyNew(objTitleStyle);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
					//4��������ʵ���������޸�ͬ�������ݿ���
					if (clsTitleStyleBL .UpdateBySql2(objTitleStyle) == false) 
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
					BindDg_TitleStyle();
					wucTitleStyle1.Clear();//��տؼ��е�����
					//�ָ�<ȷ���޸�>���<���>
					btnOKUpd.Text = "���";
					break;
			}
		}
		
		/// <summary>
		/// �������ܣ��ѽ����ϵ��������ݴ����������
		/// </summary>
		/// <param name="pobjTitleStyle">���ݴ����Ŀ�������</param>
		private void PutDataToTitleStyleClass(clsTitleStyleEN pobjTitleStyle)
		{
			pobjTitleStyle.TitleStyleId = wucTitleStyle1.TitleStyleId;
			pobjTitleStyle.TitleStyleName = wucTitleStyle1.TitleStyleName;
			pobjTitleStyle.ImgFile = wucTitleStyle1.ImgFile;
			pobjTitleStyle.TabHeight = wucTitleStyle1.TabHeight;
			pobjTitleStyle.TabWidth = wucTitleStyle1.TabWidth;
			pobjTitleStyle.TitleTypeId = wucTitleStyle1.TitleTypeId;
			pobjTitleStyle.BackColor = wucTitleStyle1.BackColor;
			pobjTitleStyle.ForeColor = wucTitleStyle1.ForeColor;
			pobjTitleStyle.FontSize = wucTitleStyle1.FontSize;
			pobjTitleStyle.FontName = wucTitleStyle1.FontName;
			pobjTitleStyle.PrjId = wucTitleStyle1.PrjId;
			pobjTitleStyle.IsDefault = wucTitleStyle1.IsDefault;
		}

		protected void dgTitleStyle_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
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
			if (strSortBy == "") return ;
			if(e.Item.ItemType==ListItemType.Header)//����ؼ��Ƿ�Ϊҳü��
			{
				string strSortEx;
				for(int i=0;i<this.dgTitleStyle.Columns.Count;i++)
				{
					strSortEx = this.dgTitleStyle.Columns[i].SortExpression;
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

		protected void dgTitleStyle_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			string strTitleStyleId;
			string strCommandName;
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.SelectedItem ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
				strCommandName = ((LinkButton)e.CommandSource).CommandName;
				strTitleStyleId = e.Item.Cells[0].Text;
				switch(strCommandName)
				{
					case "Delete":
						clsTitleStyleBL.DelRecord(strTitleStyleId);
						BindDg_TitleStyle();
						break;
						// Add other cases here, if there are multiple ButtonColumns in 
						// the DataGrid control.
					case "Update":
						//�������裺���ܹ�2����
						//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
						//2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�

						//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
						ShowData(strTitleStyleId);
						//2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
						clsPubFun.SetButtonEnabled(btnOKUpd, true);
						wucTitleStyle1.SetKeyReadOnly(true);
						btnOKUpd.Text = "ȷ���޸�";
						lblMsg.Text = "";
						break;

					default:
						// Do nothing.
						break;
				}
			}
		}
		
		public System.Data.DataTable GetTitleTypeId()
		{
			//��ȡĳѧԺ����רҵ��Ϣ
			string strSQL = "select TitleTypeId, TitleTypeName from TitleType ";
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}
		public void BindDdl_TitleTypeId(System.Web.UI.WebControls.DropDownList objDDL)
		{
			//Ϊ����Դ�ڱ����������������
			ListItem li=new ListItem("��ѡ��...","0");
			System.Data.DataTable objDT = GetTitleTypeId();
			objDDL.DataValueField="TitleTypeId";
			objDDL.DataTextField="TitleTypeName";
			objDDL.DataSource = objDT;
			objDDL.DataBind();
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
		}
		
		protected void dgTitleStyle_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
		{
			int intIndex;
			//�ж��Ƿ����µ������ֶ�
			intIndex = strSortBy.IndexOf(e.SortExpression);
			if (intIndex == -1)
			{
				strSortBy = e.SortExpression + " Asc";
				BindDg_TitleStyle();
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
			BindDg_TitleStyle();
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

		
		protected void btnTitleStylePrevPage_Click(object sender, System.EventArgs e)
		{
			this.dgTitleStyle.CurrentPageIndex -=1; 
			this.BindDg_TitleStyle(); 
		}

		protected void btnTitleStyleNextPage_Click(object sender, System.EventArgs e)
		{
			this.dgTitleStyle.CurrentPageIndex +=1; 
			this.BindDg_TitleStyle(); 
		}

		protected void btnTitleStyleJumpPage_Click(object sender, System.EventArgs e)
		{
			if(this.txtTitleStyleJump2Page.Text.Trim()!="" && 
				int.Parse(this.txtTitleStyleJump2Page.Text)>0 && 
				int.Parse(this.txtTitleStyleJump2Page.Text)-1<this.dgTitleStyle.PageCount) 
			{ 
				this.dgTitleStyle.CurrentPageIndex=int.Parse(this.txtTitleStyleJump2Page.Text)-1; 
			} 
			this.BindDg_TitleStyle();
		}

		protected void btnCopyTitleStyle_Click(object sender, System.EventArgs e)
		{
			if (ddlPrjId.SelectedValue == "0") return ;
            clsTitleStyleBLEx.CopyTitleStyle(clsPubVar.CurrSelPrjId, ddlPrjId.SelectedValue);
		}
	}
}