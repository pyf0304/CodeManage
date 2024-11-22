
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
using AGC.Entity;

using AGC.BusinessLogic;using AGC.FunClass;

using AGC.BusinessLogicEx;

using com.taishsoft.datetime;

using com.taishsoft.common;

namespace AGC.Webform
{
	/// <summary>
	/// wfmViewGroupFlds_QUDI ��ժҪ˵��������Q�����ѯ��U�����޸�
	/// </summary>
	public partial class wfmViewGroupFlds_QUDI : CommWebPageBase
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
				if (ViewGroupId != "")
				{
					lblViewGroupName.Text = clsViewGroupBL.GetObjByViewGroupId(ViewGroupId).ViewGroupName;
				}
				divJspRelaView.Visible = false;
				//1��Ϊ��������������Դ�����б�����
				wucViewGroupFlds1.SetDdl_ViewGroupId();
				wucViewGroupFlds1.SetDdl_CtlTypeId(false);
				wucViewGroupFlds1.SetDdl_DdlItemsOptionId();
				wucViewGroupFlds1.SetDdl_Ds_DataTextFieldId(clsPubVar.CurrSelPrjId);
				wucViewGroupFlds1.SetDdl_Ds_DataValueFieldId(clsPubVar.CurrSelPrjId);
				wucViewGroupFlds1.SetDdl_Ds_TabId(clsPubVar.CurrSelPrjId);
                clsCtlTypeAbbrBLEx.BindDdl_CtlTypeId_CacheEx(ddlCtlTypeId_q);
				strSortViewGroupFldsBy = "mId Asc";
				//2����ʾ�������ı�������DATAGRID��
				BindDg_ViewGroupFlds();
				BindDg_ViewInfo();
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

		
		private string ViewGroupId
		{
			get
			{
				string strViewGroupId;
				strViewGroupId = (string)Session["ViewGroupId"];
				if (strViewGroupId==null) 
				{
					strViewGroupId = "";
				}
				return strViewGroupId;
			}
			set
			{
				string strViewGroupId = value;
				Session.Add("ViewGroupId", strViewGroupId);
			}
		}

		
		private string BackErrPageLinkStr
		{
			get
			{
				string strListViewRegion;
				strListViewRegion = (string)Session["ListViewRegion"];
				if (strListViewRegion==null) 
				{
					strListViewRegion = "";
				}
				return strListViewRegion;
			}
			set
			{
				string strListViewRegion = value;
				Session.Add("ListViewRegion", strListViewRegion);
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
		private string CombineViewGroupFldsCondition()
		{
			//ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
			//���� 1=1 && UserName = '����'
			string strWhereCond=" 1=1 and ViewGroupId = '" + ViewGroupId + "'";
			//����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
			if (this.ddlCtlTypeId_q.SelectedValue!="" && this.ddlCtlTypeId_q.SelectedValue!="0")
			{
				strWhereCond += " And ViewGroupFlds.CtlTypeId='" + this.ddlCtlTypeId_q.SelectedValue+"'";
			}
			return strWhereCond;
		}
		///���ɰ�DATAGRID�Ĵ���
		/// <summary>
		/// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
		///			 ����ʾ��DATAGRID�С�
		/// </summary>
		private void BindDg_ViewGroupFlds()
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
			string strWhereCond = CombineViewGroupFldsCondition();
			//	2��������������ȡ�ñ�����������DataTable��
			System.Data.DataTable objDT = clsvViewGroupFldsBL.GetDataTable(strWhereCond);
			//	3�����DATAGRID�ĵ�ǰҳ���Ƿ񳬳�DATAGRID��ҳ����Χ
			//		3.1 ���ȼ���ҳ����
			//		3.2 �����ǰҳ����ҳ����Ϊ���һҳ
			int intPages = CalcPages(objDT.Rows.Count, this.dgViewGroupFlds.PageSize);
			if (intPages==0) 
			{
				this.dgViewGroupFlds.CurrentPageIndex = 0;
			}
			else if (this.dgViewGroupFlds.CurrentPageIndex > intPages - 1) 
			{
				this.dgViewGroupFlds.CurrentPageIndex = intPages - 1;
			}
			//	4������DATAGRID������Դ(DataSource)��
			DataView objDV = objDT.DefaultView;
			objDV.Sort = strSortViewGroupFldsBy;     ///ע����һ�д����п�����Ҫע�͵���Ŀǰ���н����ڵ����Ĳ�ѯ������������
			this.dgViewGroupFlds.DataSource=objDV;
			//	5����DATAGRID������DataTable��������ʾ��DATAGRID��
			this.dgViewGroupFlds.DataBind();

			
			//��ǰ��¼��
			this.lblViewGroupFldsRecCount.Text = objDT.Rows.Count.ToString(); 
			//��ǰҳ��
			this.lblViewGroupFldsAllPages.Text = this.dgViewGroupFlds.PageCount.ToString(); 
			//��ǰҳ����
			this.lblViewGroupFldsCurrentPage.Text=(this.dgViewGroupFlds.CurrentPageIndex+1).ToString();
			//��ǰ����������ҳ����
			this.txtViewGroupFldsJump2Page.Text=(this.dgViewGroupFlds.CurrentPageIndex+1).ToString();
			//�����ǰҳ����Ϊ0����<ǰһҳ>��ť��Ч
			if(this.dgViewGroupFlds.CurrentPageIndex==0) 
			{
				btnViewGroupFldsPrevPage.Enabled=false; 
			}
			else 
			{ 
				btnViewGroupFldsPrevPage.Enabled=true; 
			} 
			//�����ǰҳ������Ϊ���һҳ����<ǰһҳ>��ť��Ч
			if(this.dgViewGroupFlds.CurrentPageIndex==this.dgViewGroupFlds.PageCount-1) 
			{ 
				btnViewGroupFldsNextPage.Enabled=false; 
			} 
			else 
			{ 
				btnViewGroupFldsNextPage.Enabled=true; 
			} 
			//7�������沿����ʾ����ʾ �������ǰDataGrid�еļ�¼��Ϊ0������ʾ��ǰ����ҳ������
			if(objDT.Rows.Count>0) 
			{ 
				this.tabViewGroupFldsJumpPage.Visible = true; 
			} 
			else 
			{ 
				this.tabViewGroupFldsJumpPage.Visible = false; 
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
			this.dgViewGroupFlds.CurrentPageIndex=0;
			//�ѱ��¼��������ʾ��DATAGRID��
			BindDg_ViewGroupFlds();
		}
		/// <summary>
		/// �������ܣ��¼��������ڸ���DATAGRID�ĵ�ǰҳ����ʱ�����ĺ�����
		///			  ���幦����������ʾ��ҳ(������ҳ����)�����ݡ�
		/// </summary>
		/// <param name="source"></param>
		/// <param name="e"></param>
		protected void dgViewGroupFlds_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			//�������裺����2����
			//1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
			//2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ

			//1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
			this.dgViewGroupFlds.CurrentPageIndex=e.NewPageIndex;
			//2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ
			BindDg_ViewGroupFlds();
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
			if (clsViewGroupFldsBL.IsExist(lngmId) == false)		//���ùؼ��ֵļ�¼�Ƿ����
			{
				string ss = "�ؼ���Ϊ��" + lngmId + "�Ĳ�����!";
				clsCommonJsFunc.Alert(this, ss);
				return ;
			}
			//3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
			clsViewGroupFldsEN objViewGroupFlds = new clsViewGroupFldsEN(lngmId);
            //4����ȡ�������������ԣ�
            clsViewGroupFldsBL .GetViewGroupFlds(ref objViewGroupFlds);
			Session.Add("objViewGroupFlds", objViewGroupFlds);
			//5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���
			GetDataFromViewGroupFldsClass(objViewGroupFlds);
		}
		///���ɴ��߼�������ݴ��䵽�����ĺ�������
		/// <summary>
		/// �������ܣ�������������������ʾ��������
		///ע�⣺��������������򣬲�����һ��������������ϵ�ģ�����Ϊһ��������ֵ��Ȼ����Ϊ����������ֵ
		///      ������������ݿ�ʱ����Ӧ��һ���ֶ���ǰ�������ֶ��ں�
		/// </summary>
		/// <param name="pobjViewGroupFlds">��ʵ�������</param>
		private void GetDataFromViewGroupFldsClass(clsViewGroupFldsEN pobjViewGroupFlds)
		{
			wucViewGroupFlds1.ViewGroupId = pobjViewGroupFlds.ViewGroupId;
			wucViewGroupFlds1.TabFldId = pobjViewGroupFlds.TabFldId;
			wucViewGroupFlds1.CtlTypeId = pobjViewGroupFlds.CtlTypeId;
			wucViewGroupFlds1.DdlItemsOptionId = pobjViewGroupFlds.DdlItemsOptionId;
			wucViewGroupFlds1.Ds_CondStr = pobjViewGroupFlds.Ds_CondStr;
			wucViewGroupFlds1.Ds_DataTextFieldId = pobjViewGroupFlds.Ds_DataTextFieldId;
			wucViewGroupFlds1.Ds_DataValueFieldId = pobjViewGroupFlds.Ds_DataValueFieldId;
			wucViewGroupFlds1.Ds_SQLStr = pobjViewGroupFlds.Ds_SQLStr;
			wucViewGroupFlds1.Ds_TabId = pobjViewGroupFlds.Ds_TabId;
			wucViewGroupFlds1.ItemsString = pobjViewGroupFlds.ItemsString;
			wucViewGroupFlds1.SeqNum = pobjViewGroupFlds.SeqNum;
			wucViewGroupFlds1.Memo = pobjViewGroupFlds.Memo;
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
			clsViewGroupFldsEN objViewGroupFlds;
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
					if (!wucViewGroupFlds1.IsValid(ref strResult))
					{
						lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
						return ;
					}
					//2��������󲢳�ʼ������
					//clsViewGroupFldsEN objViewGroupFlds;	//�������
					objViewGroupFlds = new clsViewGroupFldsEN();	//��ʼ���¶���
					//3���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
					//4����ֵ�ӽ���㴫���߼��������ʵ���
					PutDataToViewGroupFldsClass(objViewGroupFlds);		//�ѽ����ֵ����
					//5����鴫��ȥ�Ķ��������Ƿ�Ϸ�
				
                    try
                    {
                        clsViewGroupFldsBL .CheckPropertyNew(objViewGroupFlds);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
					//6��������ʵ�������ݴ��������ݿ���
					if (clsViewGroupFldsBL .AddNewRecordBySql2(objViewGroupFlds) == false) 
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
					BindDg_ViewGroupFlds();
					wucViewGroupFlds1.Clear();		//��տؼ�������
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
					if (!wucViewGroupFlds1.IsValid(ref strResult))
					{
						lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
						return ;
					}
					//2����ֵ�ӽ���㴫���߼��������ʵ���
					objViewGroupFlds = (clsViewGroupFldsEN) Session["objViewGroupFlds"];
					PutDataToViewGroupFldsClass(objViewGroupFlds);		//�ѽ����ֵ����
					//3����鴫��ȥ�Ķ��������Ƿ�Ϸ�
					

                    try
                    {
                        clsViewGroupFldsBL.CheckPropertyNew(objViewGroupFlds);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
					//4��������ʵ���������޸�ͬ�������ݿ���
					if (clsViewGroupFldsBL .UpdateBySql2(objViewGroupFlds) == false) 
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
					BindDg_ViewGroupFlds();
					wucViewGroupFlds1.Clear();//��տؼ��е�����
					//�ָ�<ȷ���޸�>���<���>
					btnOKUpd.Text = "���";
					break;
			}
		}
		
		/// <summary>
		/// �������ܣ��ѽ����ϵ��������ݴ����������
		/// </summary>
		/// <param name="pobjViewGroupFlds">���ݴ����Ŀ�������</param>
		private void PutDataToViewGroupFldsClass(clsViewGroupFldsEN pobjViewGroupFlds)
		{
			pobjViewGroupFlds.ViewGroupId = wucViewGroupFlds1.ViewGroupId;
			pobjViewGroupFlds.TabFldId = wucViewGroupFlds1.TabFldId;
			pobjViewGroupFlds.CtlTypeId = wucViewGroupFlds1.CtlTypeId;
			pobjViewGroupFlds.DdlItemsOptionId = wucViewGroupFlds1.DdlItemsOptionId;
			pobjViewGroupFlds.Ds_CondStr = wucViewGroupFlds1.Ds_CondStr;
			pobjViewGroupFlds.Ds_DataTextFieldId = wucViewGroupFlds1.Ds_DataTextFieldId;
			pobjViewGroupFlds.Ds_DataValueFieldId = wucViewGroupFlds1.Ds_DataValueFieldId;
			pobjViewGroupFlds.Ds_SQLStr = wucViewGroupFlds1.Ds_SQLStr;
			pobjViewGroupFlds.Ds_TabId = wucViewGroupFlds1.Ds_TabId;
			pobjViewGroupFlds.ItemsString = wucViewGroupFlds1.ItemsString;
			pobjViewGroupFlds.SeqNum = wucViewGroupFlds1.SeqNum;
			pobjViewGroupFlds.Memo = wucViewGroupFlds1.Memo;
		}

		protected void dgViewGroupFlds_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
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
			if (strSortViewGroupFldsBy == "") return ;
			if(e.Item.ItemType==ListItemType.Header)//����ؼ��Ƿ�Ϊҳü��
			{
				string strSortEx;
				for(int i=0;i<this.dgViewGroupFlds.Columns.Count;i++)
				{
					strSortEx = this.dgViewGroupFlds.Columns[i].SortExpression;
					if (strSortEx == "") continue;
					intIndex = strSortViewGroupFldsBy.IndexOf(strSortEx + " ");
					if(intIndex >=0)  //��ͼ״̬��������ʽ�Ƿ�Ϊ���е��ֶΣ�
					{
						Label lblSort=new Label();
						lblSort.Font.Name="webdings";//�������壬��"webdings"��5�������ǣ�6�������ǣ�
						intIndex = strSortViewGroupFldsBy.IndexOf("Asc");
						lblSort.Text=(intIndex>0?" 5":" 6");//�Ƿ�Ϊ���򣬶���Ϊstring�ͣ�
						e.Item.Cells[i].Controls.Add(lblSort);//��������ĵ�i����Ԫ��������һ�ؼ���
						break;
					}
				}
			}
		}

		protected void dgViewGroupFlds_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
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
						clsViewGroupFldsBL.DelRecord(lngmId);
						BindDg_ViewGroupFlds();
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
					Set_DataGridAllChecked(dgViewGroupFlds, true);
					lbSelAll.Text = "��ѡ";
				}
				else if (lbSelAll.Text == "��ѡ")
				{
					Set_DataGridAllChecked(dgViewGroupFlds, false);
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
			string strWhereCond = CombineViewGroupFldsCondition();
			//	2��������������ȡ�ñ�����������DataTable��
			System.Data.DataTable objDT = clsViewGroupFldsBL.GetDataTable_ViewGroupFlds(strWhereCond);
			List<string> arrCnName = new List<string>();
			List<string> arrColName = new List<string>();
			string strFileName = "ViewGroupFlds��Ϣ����.xls";
			string strFolderName;
			string strDownLoadFileName;
			arrColName.Add("mId"); arrCnName.Add("mId");
			arrColName.Add("ViewGroupId"); arrCnName.Add("������ID");
			arrColName.Add("TabFldId"); arrCnName.Add("���ֶ�ID");
			arrColName.Add("CtlTypeId"); arrCnName.Add("�ؼ����ͺ�");
			arrColName.Add("DdlItemsOptionId"); arrCnName.Add("�������б�ѡ��ID");
			arrColName.Add("Ds_CondStr"); arrCnName.Add("����Դ������");
			arrColName.Add("Ds_DataTextFieldId"); arrCnName.Add("����Դ�ı��ֶ�Id");
			arrColName.Add("Ds_DataValueFieldId"); arrCnName.Add("����Դֵ�ֶ�Id");
			arrColName.Add("Ds_SQLStr"); arrCnName.Add("����ԴSQL��");
			arrColName.Add("Ds_TabId"); arrCnName.Add("����Դ��ID");
			arrColName.Add("ItemsString"); arrCnName.Add("�б��");
			arrColName.Add("SeqNum"); arrCnName.Add("�ֶ����");
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
            List<string> arrmId = clsCommForWebForm.GetAllCheckedItemFromDg2(dgViewGroupFlds, "chkCheckRec");
			if (arrmId == null || arrmId.Count == 0) 
			{
				lblMsg.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
				return ;
			}
			lblMsg.Text = "";
			clsViewGroupFldsBL.DelViewGroupFldss(arrmId);
			BindDg_ViewGroupFlds();
		}

		
		//��ǰ��¼��
		protected void btnUpdate4Dg_Click(object sender, System.EventArgs e)
		{
			string strmId =clsCommForWebForm.GetFirstCheckedItemFromDg(dgViewGroupFlds);
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
		
		public System.Data.DataTable GetViewGroupId()
		{
			//��ȡĳѧԺ����רҵ��Ϣ
			string strSQL = "select ViewGroupId, ViewGroupName from ViewGroup ";
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}
		public void BindDdl_ViewGroupId(System.Web.UI.WebControls.DropDownList objDDL)
		{
			//Ϊ����Դ�ڱ����������������
			ListItem li=new ListItem("��ѡ��...","0");
			System.Data.DataTable objDT = GetViewGroupId();
			objDDL.DataValueField="ViewGroupId";
			objDDL.DataTextField="ViewGroupName";
			objDDL.DataSource = objDT;
			objDDL.DataBind();
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
		}
		
		
		
		public System.Data.DataTable GetUserId()
		{
			//��ȡĳѧԺ����רҵ��Ϣ
			string strSQL = "select UserId, UserName from Users ";
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}
		public void BindDdl_UserId(System.Web.UI.WebControls.DropDownList objDDL)
		{
			//Ϊ����Դ�ڱ����������������
			ListItem li=new ListItem("��ѡ��...","0");
			System.Data.DataTable objDT = GetUserId();
			objDDL.DataValueField="UserId";
			objDDL.DataTextField="UserName";
			objDDL.DataSource = objDT;
			objDDL.DataBind();
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
		}
		
		protected void dgViewGroupFlds_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
		{
			int intIndex;
			//�ж��Ƿ����µ������ֶ�
			intIndex = strSortViewGroupFldsBy.IndexOf(e.SortExpression);
			if (intIndex == -1)
			{
				strSortViewGroupFldsBy = e.SortExpression + " Asc";
				BindDg_ViewGroupFlds();
				return ;
			}
			//���ԭ��������
			intIndex = strSortViewGroupFldsBy.IndexOf(" Asc");
			if (intIndex == -1)		//���ԭ���������������Ϊ����
			{
				strSortViewGroupFldsBy = e.SortExpression + " Asc";
			}
			else			///��������Ϊ����
			{
				strSortViewGroupFldsBy = e.SortExpression + " Desc";
			}
			BindDg_ViewGroupFlds();
		}

		private string strSortViewGroupFldsBy
		{
			get
			{
				string sSortViewGroupFldsBy;
				sSortViewGroupFldsBy = (string)ViewState["SortViewGroupFldsBy"];
				if (sSortViewGroupFldsBy==null) 
				{
					sSortViewGroupFldsBy = "";
				}
				return sSortViewGroupFldsBy;
			}
			set
			{
				string sSortViewGroupFldsBy = value;
				ViewState.Add("SortViewGroupFldsBy", sSortViewGroupFldsBy);
			}
		}

		//���ɸ������SESSION������Ժ���
		protected void btnViewGroupFldsPrevPage_Click(object sender, System.EventArgs e)
		{
			this.dgViewGroupFlds.CurrentPageIndex -=1; 
			this.BindDg_ViewGroupFlds(); 
		}

		protected void btnViewGroupFldsNextPage_Click(object sender, System.EventArgs e)
		{
			this.dgViewGroupFlds.CurrentPageIndex +=1; 
			this.BindDg_ViewGroupFlds(); 
		}

		protected void btnViewGroupFldsJumpPage_Click(object sender, System.EventArgs e)
		{
			if(this.txtViewGroupFldsJump2Page.Text.Trim()!="" && 
				int.Parse(this.txtViewGroupFldsJump2Page.Text)>0 && 
				int.Parse(this.txtViewGroupFldsJump2Page.Text)-1<this.dgViewGroupFlds.PageCount) 
			{ 
				this.dgViewGroupFlds.CurrentPageIndex=int.Parse(this.txtViewGroupFldsJump2Page.Text)-1; 
			} 
			this.BindDg_ViewGroupFlds();
		}

		protected void btnGoBack_Click(object sender, System.EventArgs e)
		{
			Response.Redirect(BackErrPageLinkStr);
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
			StringBuilder sbWhereCond = new StringBuilder();
			sbWhereCond.Append("RegionId in (");
			sbWhereCond.Append("select RegionId from viewregion where regiontypeid = '0003' ");
			sbWhereCond.AppendFormat("and viewid in (select viewid from viewinfo where viewgroupid = '{0}'))",
				ViewGroupId);
			//��ʼ����ӽ���༭�����ֶ��б�
			clsViewGroupFldsEN objViewGroupFlds = new clsViewGroupFldsEN();
            List<clsEditRegionFldsEN> arrEditRegionFldSet_AddorUpdate = 
				 clsEditRegionFldsBL.GetObjLst(sbWhereCond.ToString());
			foreach(clsEditRegionFldsEN objEditRegionFlds in arrEditRegionFldSet_AddorUpdate)
			{
				objViewGroupFlds.ViewGroupId = ViewGroupId;
				//objViewGroupFlds.FldId = objEditRegionFlds.FldId;
				objViewGroupFlds.CtlTypeId = objEditRegionFlds.CtlTypeId;
				objViewGroupFlds.DdlItemsOptionId = objEditRegionFlds.DdlItemsOptionId;
				objViewGroupFlds.Ds_CondStr = objEditRegionFlds.Ds_CondStr;
				objViewGroupFlds.Ds_DataTextFieldId = objEditRegionFlds.Ds_DataTextFieldId;
				objViewGroupFlds.Ds_DataValueFieldId = objEditRegionFlds.Ds_DataValueFieldId;
				objViewGroupFlds.Ds_SQLStr = objEditRegionFlds.Ds_SQLStr;
				objViewGroupFlds.Ds_TabId = objEditRegionFlds.Ds_TabId;
				objViewGroupFlds.ItemsString = objEditRegionFlds.ItemsString;
				objViewGroupFlds.SeqNum = objEditRegionFlds.SeqNum;
				objViewGroupFlds.Memo = objEditRegionFlds.Memo;
				objViewGroupFlds.UserId = UserId;
				objViewGroupFlds.UpdDate = clsDateTime.getTodayStr(0);
                if (clsViewGroupFldsBL.IsExistRecord("ViewGroupId = '" + ViewGroupId + "' and TabFldId = " + objViewGroupFlds.TabFldId + " and CtlTypeId = '" + objViewGroupFlds.CtlTypeId + "'") == false)
				{
                    clsViewGroupFldsBL .AddNewRecordBySql2(objViewGroupFlds);
				}
			}
			BindDg_ViewGroupFlds();
			Response.Write("<script>alert('�������صı༭�����ֶ���Ϣ���Ƴɹ�����')</script>");

		}

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
			string strWhereCond = "ViewGroupId = '" + ViewGroupId + "'";
			//	2��������������ȡ�ñ�����������DataTable��
			System.Data.DataTable objDT = clsvViewInfoBL.GetDataTable(strWhereCond);
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
			//			objDV.Sort = strSortBy;
			this.dgViewInfo.DataSource=objDV;
			//	5����DATAGRID������DataTable��������ʾ��DATAGRID��
			this.dgViewInfo.DataBind();
		}

		protected void btnAddRelaJspView_Click(object sender, System.EventArgs e)
		{
			divJspRelaView.Visible = true;
		}
		private void CopyCommInfoFromGroupToView(clsViewGroupEN objViewGroupEN, clsViewInfoEN objViewInfo)
		{
            objViewInfo.ViewId = clsViewInfoBL.GetMaxStrIdByPrefix_S(clsPubVar.CurrSelPrjId);
			objViewInfo.UserId = UserId;
            objViewInfo.PrjId = clsPubVar.CurrSelPrjId;
            objViewInfo.DataBaseName = new clsCommonSession().PrjDataBaseName;
			objViewInfo.FilePath = "webform/";
//			objViewInfo.ViewName = txtFileName_Add.Text;
//			objViewInfo.ViewCnName = getRelaTabCnName() + "���";
//			objViewInfo.FileName = txtFileName_Add.Text + ".jsp";
//			objViewInfo.DefaMenuName = objViewInfo.ViewCnName; 
//			objViewInfo.ApplicationTypeId = clsApplicationTypeBLEx.JAVAWEBAPP;
			objViewInfo.ViewGroupId = objViewGroupEN.ViewGroupId;
//			objViewInfo.ViewTypeCode = clsViewTypeCodeTabBLEx.JAVA_ADD;
            objViewInfo.FuncModuleAgcId =  clsFuncModule_AgcBL.GetFirstID_S("PrjId = '" + clsPubVar.CurrSelPrjId + "'");
            objViewInfo.DataBaseName = new clsCommonSession().PrjDataBaseName;
			objViewInfo.MainTabId = getRelaTabId();
			objViewInfo.DetailTabId = "";
			objViewInfo.KeyForMainTab = "";
			objViewInfo.KeyForDetailTab = "";
			objViewInfo.IsNeedSort = true;
			objViewInfo.IsNeedTransCode = true;
			objViewInfo.ViewFunction = "";
			objViewInfo.ViewDetail = "";
			objViewInfo.OutSqlDsTypeId = objViewGroupEN.OutSqlDsTypeId;
			objViewInfo.OutRelaTabId = objViewGroupEN.OutRelaTabId;
			objViewInfo.InSqlDsTypeId = objViewGroupEN.InSqlDsTypeId;
			objViewInfo.InRelaTabId = objViewGroupEN.InRelaTabId;
		}
		protected void btnStartGene_Click(object sender, System.EventArgs e)
		{
			StringBuilder sbWhereCond = new StringBuilder();
			clsViewInfoEN objViewInfo = new clsViewInfoEN();
			clsViewGroupEN objViewGroupEN = clsViewGroupBL.GetObjByViewGroupId(ViewGroupId);
			//���ѡ����ӽ���
			if (chkJsp_Add.Checked == true && txtFileName_Add.Text.Trim() != "")
			{
				//�����������Ƿ����
				sbWhereCond.AppendFormat("ViewGroupId = '{0}' and ViewName = '{1}'",
					ViewGroupId,
					txtFileName_Add.Text);

				if (clsViewInfoBL.IsExistRecord(sbWhereCond.ToString()))
				{
					lblMsg2.Text = "�ڸý����������ͬ��<���>��������!";
					return ;
				}
				CopyCommInfoFromGroupToView(objViewGroupEN, objViewInfo);
				objViewInfo.ViewName = txtFileName_Add.Text;
				objViewInfo.ViewCnName = getRelaTabCnName() + "���";
				objViewInfo.FileName = txtFileName_Add.Text + ".jsp";
				objViewInfo.DefaMenuName = objViewInfo.ViewCnName; 
				objViewInfo.ApplicationTypeId = (int)clsApplicationTypeBLEx.JAVAWEBAPP;
				objViewInfo.ViewTypeCode = (int)clsViewTypeCodeTabBLEx.JAVA_ADD;
				clsViewInfoBL .AddNewRecordBySql2(objViewInfo);
                ///������������ֶΣ��ú�����ViewInfo����غ�����
                ///������������1����ͼID(ViewId)
                ///				2����������()
                ///				3������Դ����ID
                ///				4������Դ��ID()
                ///		

                clsViewInfoBLEx.ImportRegionAndFlds(objViewInfo.ViewId,
                    clsRegionTypeENEx.EDITREGION,
                    objViewGroupEN.InSqlDsTypeId,
                    objViewGroupEN.InRelaTabId, clsCommonSession.UserId);

			}
			//�޸Ľ���
			if (chkJsp_Update.Checked == true && txtFileName_Update.Text.Trim() != "")
			{
				//�����������Ƿ����
				sbWhereCond = new StringBuilder();
				sbWhereCond.AppendFormat("ViewGroupId = '{0}' and ViewName = '{1}'",
					ViewGroupId,
					txtFileName_Update.Text);

				if (clsViewInfoBL.IsExistRecord(sbWhereCond.ToString()))
				{
					lblMsg2.Text = "�ڸý����������ͬ��<�޸�>��������!";
					return ;
				}
				CopyCommInfoFromGroupToView(objViewGroupEN, objViewInfo);
				objViewInfo.ViewName = txtFileName_Update.Text;
				objViewInfo.ViewCnName = getRelaTabCnName() + "�޸�";
				objViewInfo.FileName = txtFileName_Update.Text + ".jsp";
				objViewInfo.DefaMenuName = objViewInfo.ViewCnName; 
				objViewInfo.ApplicationTypeId = (int)clsApplicationTypeBLEx.JAVAWEBAPP;
				objViewInfo.ViewTypeCode = (int)clsViewTypeCodeTabBLEx.JAVA_UPDATE;
				clsViewInfoBL .AddNewRecordBySql2(objViewInfo);

				///������������ֶΣ��ú�����ViewInfo����غ�����
				///������������1����ͼID(ViewId)
				///				2����������()
				///				3������Դ����ID
				///				4������Դ��ID()
				///		
				
				clsViewInfoBLEx.ImportRegionAndFlds(objViewInfo.ViewId, 
					clsRegionTypeENEx.EDITREGION, 
					objViewGroupEN.InSqlDsTypeId, 
					objViewGroupEN.InRelaTabId, clsCommonSession.UserId);

			}
			//��ϸ��Ϣ����
			if (chkJsp_Detail.Checked == true && txtFileName_Detail.Text.Trim() != "")
			{
				//�����������Ƿ����
				sbWhereCond = new StringBuilder();
				sbWhereCond.AppendFormat("ViewGroupId = '{0}' and ViewName = '{1}'",
					ViewGroupId,
					txtFileName_Detail.Text);

				if (clsViewInfoBL.IsExistRecord(sbWhereCond.ToString()))
				{
					lblMsg2.Text = "�ڸý����������ͬ��<��ϸ��Ϣ>��������!";
					return ;
				}
				CopyCommInfoFromGroupToView(objViewGroupEN, objViewInfo);
				objViewInfo.ViewName = txtFileName_Detail.Text;
				objViewInfo.ViewCnName = getRelaTabCnName() + "��ϸ��Ϣ";
				objViewInfo.FileName = txtFileName_Detail.Text + ".jsp";
				objViewInfo.DefaMenuName = objViewInfo.ViewCnName;
                objViewInfo.ApplicationTypeId = (int) clsApplicationTypeBLEx.JAVAWEBAPP;
				objViewInfo.ViewTypeCode = (int)clsViewTypeCodeTabBLEx.JAVA_DETAIL;
                clsViewInfoBL .AddNewRecordBySql2(objViewInfo);
				///������������ֶΣ��ú�����ViewInfo����غ�����
				///������������1����ͼID(ViewId)
				///				2����������()
				///				3������Դ����ID
				///				4������Դ��ID()
				///		
				
				clsViewInfoBLEx.ImportRegionAndFlds(objViewInfo.ViewId, 
					clsRegionTypeENEx.DETAILREGION, 
					objViewGroupEN.OutSqlDsTypeId, 
					objViewGroupEN.OutRelaTabId, clsCommonSession.UserId);

			}
			//�б����
			if (chkJsp_List.Checked == true && txtFileName_List.Text.Trim() != "")
			{
				//�����������Ƿ����
				sbWhereCond = new StringBuilder();
				sbWhereCond.AppendFormat("ViewGroupId = '{0}' and ViewName = '{1}'",
					ViewGroupId,
					txtFileName_List.Text);

				if (clsViewInfoBL.IsExistRecord(sbWhereCond.ToString()))
				{
					lblMsg2.Text = "�ڸý����������ͬ��<�б�>��������!";
					return ;
				}
				CopyCommInfoFromGroupToView(objViewGroupEN, objViewInfo);
				objViewInfo.ViewName = txtFileName_List.Text;
				objViewInfo.ViewCnName = getRelaTabCnName() + "�б�";
				objViewInfo.FileName = txtFileName_List.Text + ".jsp";
				objViewInfo.DefaMenuName = objViewInfo.ViewCnName; 
				objViewInfo.ApplicationTypeId = (int)clsApplicationTypeBLEx.JAVAWEBAPP;
				objViewInfo.ViewTypeCode = (int)clsViewTypeCodeTabBLEx.JAVA_LIST;
				clsViewInfoBL .AddNewRecordBySql2(objViewInfo);

				///������������ֶΣ��ú�����ViewInfo����غ�����
				///������������1����ͼID(ViewId)
				///				2����������()
				///				3������Դ����ID
				///				4������Դ��ID()
				///		
				
				clsViewInfoBLEx.ImportRegionAndFlds(objViewInfo.ViewId, 
					clsRegionTypeENEx.DGREGION, 
					objViewGroupEN.OutSqlDsTypeId, 
					objViewGroupEN.OutRelaTabId, clsCommonSession.UserId);

			}
			//��ѯ����
			if (chkJsp_Query.Checked == true && txtFileName_Query.Text.Trim() != "")
			{
				//�����������Ƿ����
				sbWhereCond = new StringBuilder();
				sbWhereCond.AppendFormat("ViewGroupId = '{0}' and ViewName = '{1}'",
					ViewGroupId,
					txtFileName_Query.Text);

				if (clsViewInfoBL.IsExistRecord(sbWhereCond.ToString()))
				{
					lblMsg2.Text = "�ڸý����������ͬ��<��ѯ>��������!";
					return ;
				}
				CopyCommInfoFromGroupToView(objViewGroupEN, objViewInfo);
				objViewInfo.ViewName = txtFileName_Query.Text;
				objViewInfo.ViewCnName = getRelaTabCnName() + "��ѯ";
				objViewInfo.FileName = txtFileName_Query.Text + ".jsp";
				objViewInfo.DefaMenuName = objViewInfo.ViewCnName; 
				objViewInfo.ApplicationTypeId = (int)clsApplicationTypeBLEx.JAVAWEBAPP;
				objViewInfo.ViewTypeCode = (int)clsViewTypeCodeTabBLEx.JAVA_QUERY;
				clsViewInfoBL .AddNewRecordBySql2(objViewInfo);
				///������������ֶΣ��ú�����ViewInfo����غ�����
				///������������1����ͼID(ViewId)
				///				2����������()
				///				3������Դ����ID
				///				4������Դ��ID()
				///		
				
				clsViewInfoBLEx.ImportRegionAndFlds(objViewInfo.ViewId, 
					clsRegionTypeENEx.QUERYREGION, 
					objViewGroupEN.InSqlDsTypeId, 
					objViewGroupEN.InRelaTabId, clsCommonSession.UserId);

			}
			BindDg_ViewInfo();
			divJspRelaView.Visible = false;
		}

		protected void chkJsp_Add_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chkJsp_Add.Checked == true)
			{
                string strRelaTabName = getRelaTabName();
                if (string.IsNullOrEmpty(strRelaTabName) == false)
                {
                    txtFileName_Add.Text = strRelaTabName + "_add";
                }
			}
		}
		private string getRelaTabName()
		{
			clsViewGroupENEx objViewGroupENEx = (clsViewGroupENEx)clsViewGroupBL.GetObjByViewGroupId(ViewGroupId);
            try
            {
                clsViewGroupBLEx.initViewRelaTabFldSet(objViewGroupENEx);;
            }
            catch (Exception objException)
            {
                lblMsg2.Text = objException.Message;
                return "";
            }
			if (objViewGroupENEx.objINPrjTab != null)
			{
				return objViewGroupENEx.objINPrjTab.TabName;
			}
			else
			{
				return objViewGroupENEx.objOUTPrjTab.TabName;
			}	
		}
		private string getRelaTabCnName()
		{
			clsViewGroupENEx objViewGroupENEx = (clsViewGroupENEx)clsViewGroupBL.GetObjByViewGroupId(ViewGroupId);
            clsViewGroupBLEx.initViewRelaTabFldSet(objViewGroupENEx);
			if (objViewGroupENEx.objINPrjTab != null)
			{
				return objViewGroupENEx.objINPrjTab.TabCnName;
			}
			else
			{
				return objViewGroupENEx.objOUTPrjTab.TabCnName;
			}	
		}
		private string getRelaTabId()
		{
            clsViewGroupENEx objViewGroupENEx = (clsViewGroupENEx)clsViewGroupBL.GetObjByViewGroupId(ViewGroupId);
			clsViewGroupBLEx.initViewRelaTabFldSet(objViewGroupENEx);;
			if (objViewGroupENEx.objINPrjTab != null)
			{
				return objViewGroupENEx.objINPrjTab.TabId;
			}
			else
			{
				return objViewGroupENEx.objOUTPrjTab.TabId;
			}	
		}

		protected void chkJsp_Update_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chkJsp_Update.Checked == true)
			{
				txtFileName_Update.Text = getRelaTabName() + "_update";
			}
		
		}

		protected void chkJsp_Query_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chkJsp_Query.Checked == true)
			{
				txtFileName_Query.Text = getRelaTabName() + "_query";
			}
		}

		protected void chkJsp_Detail_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chkJsp_Detail.Checked == true)
			{
				txtFileName_Detail.Text = getRelaTabName() + "_detail";
			}
		}

		protected void chkJsp_List_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chkJsp_List.Checked == true)
			{
				txtFileName_List.Text = getRelaTabName() + "_list";
			}
		}

		protected void btnCloseDiv_Click(object sender, System.EventArgs e)
		{
			divJspRelaView.Visible = false;
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