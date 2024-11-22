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

using AGC.BusinessLogic;using AGC.FunClass;

using AGC.BusinessLogicEx;
using AGC.Entity;


using System.Collections.Generic;

using com.taishsoft.common;

namespace AGC.Webform
{
	/// <summary>
	/// wfmViewGroup_QUDI ��ժҪ˵��������Q�����ѯ��U�����޸�
	/// </summary>
	public partial class wfmViewGroup_QUDI : CommWebPageBase
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
				wucViewGroup1.SetDdl_InSqlDsTypeId();
				wucViewGroup1.SetDdl_OutSqlDsTypeId();
				strSortViewGroupBy = "ViewGroupId Asc";
				//2����ʾ�������ı�������DATAGRID��
				BindDg_ViewGroup();
				//3�����ñ�ؼ����ֿؼ���ReadOnly���ԣ�
				//   ʹֻ֮������Ϊ���޸Ĺ����йؼ����ǲ��ܱ��޸ĵġ�
				wucViewGroup1.SetKeyReadOnly(true);
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
		private string CombineViewGroupCondition()
		{
			//ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
			//���� 1=1 && UserName = '����'
            string strWhereCond = " 1=1 and PrjId = '" + clsPubVar.CurrSelPrjId + "' ";
			//����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
			if (this.txtViewGroupNameq.Text.Trim()!="")
			{
				strWhereCond += " And ViewGroupName like '%" + this.txtViewGroupNameq.Text.Trim()+"%'";
			}
			if (this.txtPrjDomainq.Text.Trim()!="")
			{
				strWhereCond += " And PrjDomain like '%" + this.txtPrjDomainq.Text.Trim()+"%'";
			}
			if (this.txtTableNameForProgq.Text.Trim()!="")
			{
				strWhereCond += " And TableNameForProg like '%" + this.txtTableNameForProgq.Text.Trim()+"%'";
			}

			return strWhereCond;
		}
		///���ɰ�DATAGRID�Ĵ���
		/// <summary>
		/// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
		///			 ����ʾ��DATAGRID�С�
		/// </summary>
		private void BindDg_ViewGroup()
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
			string strWhereCond = CombineViewGroupCondition();
			//	2��������������ȡ�ñ�����������DataTable��
			System.Data.DataTable objDT = clsvViewGroupBL.GetDataTable(strWhereCond);
			//	3�����DATAGRID�ĵ�ǰҳ���Ƿ񳬳�DATAGRID��ҳ����Χ
			//		3.1 ���ȼ���ҳ����
			//		3.2 �����ǰҳ����ҳ����Ϊ���һҳ
			int intPages = CalcPages(objDT.Rows.Count, this.dgViewGroup.PageSize);
			if (intPages==0) 
			{
				this.dgViewGroup.CurrentPageIndex = 0;
			}
			else if (this.dgViewGroup.CurrentPageIndex > intPages - 1) 
			{
				this.dgViewGroup.CurrentPageIndex = intPages - 1;
			}
			//	4������DATAGRID������Դ(DataSource)��
			DataView objDV = objDT.DefaultView;
			objDV.Sort = strSortViewGroupBy;     ///ע����һ�д����п�����Ҫע�͵���Ŀǰ���н����ڵ����Ĳ�ѯ������������
			this.dgViewGroup.DataSource=objDV;
			//	5����DATAGRID������DataTable��������ʾ��DATAGRID��
			this.dgViewGroup.DataBind();

			
			//��ǰ��¼��
			this.lblViewGroupRecCount.Text = objDT.Rows.Count.ToString(); 
			//��ǰҳ��
			this.lblViewGroupAllPages.Text = this.dgViewGroup.PageCount.ToString(); 
			//��ǰҳ����
			this.lblViewGroupCurrentPage.Text=(this.dgViewGroup.CurrentPageIndex+1).ToString();
			//��ǰ����������ҳ����
			this.txtViewGroupJump2Page.Text=(this.dgViewGroup.CurrentPageIndex+1).ToString();
			//�����ǰҳ����Ϊ0����<ǰһҳ>��ť��Ч
			if(this.dgViewGroup.CurrentPageIndex==0) 
			{
				btnViewGroupPrevPage.Enabled=false; 
			}
			else 
			{ 
				btnViewGroupPrevPage.Enabled=true; 
			} 
			//�����ǰҳ������Ϊ���һҳ����<ǰһҳ>��ť��Ч
			if(this.dgViewGroup.CurrentPageIndex==this.dgViewGroup.PageCount-1) 
			{ 
				btnViewGroupNextPage.Enabled=false; 
			} 
			else 
			{ 
				btnViewGroupNextPage.Enabled=true; 
			} 
			//7�������沿����ʾ����ʾ �������ǰDataGrid�еļ�¼��Ϊ0������ʾ��ǰ����ҳ������
			if(objDT.Rows.Count>0) 
			{ 
				this.tabViewGroupJumpPage.Visible = true; 
			} 
			else 
			{ 
				this.tabViewGroupJumpPage.Visible = false; 
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
			this.dgViewGroup.CurrentPageIndex=0;
			//�ѱ��¼��������ʾ��DATAGRID��
			BindDg_ViewGroup();
		}
		/// <summary>
		/// �������ܣ��¼��������ڸ���DATAGRID�ĵ�ǰҳ����ʱ�����ĺ�����
		///			  ���幦����������ʾ��ҳ(������ҳ����)�����ݡ�
		/// </summary>
		/// <param name="source"></param>
		/// <param name="e"></param>
		protected void dgViewGroup_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			//�������裺����2����
			//1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
			//2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ

			//1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
			this.dgViewGroup.CurrentPageIndex=e.NewPageIndex;
			//2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ
			BindDg_ViewGroup();
		}
		/// <summary>
		/// �������ܣ����Ըùؼ��ֵļ�¼������ʾ�ڽ����ϣ�
		///������     �������ǰ�ֵ������ؼ���
		/// </summary>
		/// <param name="strViewGroupId">���¼�Ĺؼ��֣���ʾ�ñ�ؼ��ֵ�����</param>
		private void ShowData(string strViewGroupId)
		{
			//�������裺
			//1�����ؼ����Ƿ�Ϊ�գ�
			//2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
			//3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
			//4����ȡ�������������ԣ�
			//5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���

			//1�����ؼ����Ƿ�Ϊ�գ�
			if (strViewGroupId == "") return ;		//����ؼ���Ϊ�վͷ����˳�
			//2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
			if (clsViewGroupBL.IsExist(strViewGroupId) == false)		//���ùؼ��ֵļ�¼�Ƿ����
			{
				string ss = "�ؼ���Ϊ��" + strViewGroupId + "�Ĳ�����!";
				clsCommonJsFunc.Alert(this, ss);
				return ;
			}
			//3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
			clsViewGroupEN objViewGroupEN = new clsViewGroupEN(strViewGroupId);
			//4����ȡ�������������ԣ�
            clsViewGroupBL.GetViewGroup(ref objViewGroupEN);
			Session.Add("objViewGroupEN", objViewGroupEN);
			//5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���
			GetDataFromViewGroupClass(objViewGroupEN);
		}
		///���ɴ��߼�������ݴ��䵽�����ĺ�������
		/// <summary>
		/// �������ܣ�������������������ʾ��������
		///ע�⣺��������������򣬲�����һ��������������ϵ�ģ�����Ϊһ��������ֵ��Ȼ����Ϊ����������ֵ
		///      ������������ݿ�ʱ����Ӧ��һ���ֶ���ǰ�������ֶ��ں�
		/// </summary>
		/// <param name="pobjViewGroup">��ʵ�������</param>
		private void GetDataFromViewGroupClass(clsViewGroupEN pobjViewGroup)
		{
			wucViewGroup1.ViewGroupId = pobjViewGroup.ViewGroupId;
			wucViewGroup1.ViewGroupName = pobjViewGroup.ViewGroupName;
			wucViewGroup1.InSqlDsTypeId = pobjViewGroup.InSqlDsTypeId;
			wucViewGroup1.InRelaTabId = pobjViewGroup.InRelaTabId;
			wucViewGroup1.OutSqlDsTypeId = pobjViewGroup.OutSqlDsTypeId;
			wucViewGroup1.OutRelaTabId = pobjViewGroup.OutRelaTabId;
			wucViewGroup1.PrjDomain = pobjViewGroup.PrjDomain;
			wucViewGroup1.ActionPath = pobjViewGroup.ActionPath;
			wucViewGroup1.TableNameForProg = pobjViewGroup.TableNameForProg;

			wucViewGroup1.Memo = pobjViewGroup.Memo;
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
			clsViewGroupEN objViewGroupEN;
			Button btnTemp;
			btnTemp = (Button) sender;
			strCommandText = btnTemp.Text;
			switch(strCommandText)
			{
				case "���":
					wucViewGroup1.SetKeyReadOnly(false);
					btnOKUpd.Text = "ȷ�����";
                    wucViewGroup1.ViewGroupId = clsViewGroupBL.GetMaxStrIdByPrefix_S(clsPubVar.CurrSelPrjId);
                    wucViewGroup1.PrjDomain = clsProjectsBL.GetObjByPrjIdCache(clsPubVar.CurrSelPrjId).PrjDomain; 

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
					if (!wucViewGroup1.IsValid(ref strResult))
					{
						lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
						return ;
					}
					//2��������󲢳�ʼ������
					//clsViewGroupEN objViewGroupEN;	//�������
					objViewGroupEN = new clsViewGroupEN(wucViewGroup1.ViewGroupId);	//��ʼ���¶���
					//3���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
                    if (clsViewGroupBL.IsExist(objViewGroupEN.ViewGroupId))	//�ж��Ƿ�����ͬ�Ĺؼ���
					{
						strMsg = "�ؼ����ֶ�������ͬ��ֵ";
						clsCommonJsFunc.Alert(this, strMsg);
						return;
					}
					//4����ֵ�ӽ���㴫���߼��������ʵ���
					PutDataToViewGroupClass(objViewGroupEN);		//�ѽ����ֵ����
					//5����鴫��ȥ�Ķ��������Ƿ�Ϸ�
                    try
                    {
                        clsViewGroupBL.CheckPropertyNew(objViewGroupEN);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
					//6��������ʵ�������ݴ��������ݿ���
                    if (clsViewGroupBL.AddNewRecordBySql2(objViewGroupEN) == false) 
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
					BindDg_ViewGroup();
					wucViewGroup1.Clear();		//��տؼ�������
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
					if (!wucViewGroup1.IsValid(ref strResult))
					{
						lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
						return ;
					}
					//2����ֵ�ӽ���㴫���߼��������ʵ���
					objViewGroupEN = (clsViewGroupEN) Session["objViewGroupEN"];
					PutDataToViewGroupClass(objViewGroupEN);		//�ѽ����ֵ����
					//3����鴫��ȥ�Ķ��������Ƿ�Ϸ�
                    try
                    {
                        clsViewGroupBL.CheckPropertyNew(objViewGroupEN);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
					//4��������ʵ���������޸�ͬ�������ݿ���
                    if (clsViewGroupBL.UpdateBySql2(objViewGroupEN) == false) 
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
					BindDg_ViewGroup();
					wucViewGroup1.Clear();//��տؼ��е�����
					//�ָ�<ȷ���޸�>���<���>
					btnOKUpd.Text = "���";
					break;
			}
		}
		
		/// <summary>
		/// �������ܣ��ѽ����ϵ��������ݴ����������
		/// </summary>
		/// <param name="pobjViewGroup">���ݴ����Ŀ�������</param>
		private void PutDataToViewGroupClass(clsViewGroupEN pobjViewGroup)
		{
			pobjViewGroup.ViewGroupId = wucViewGroup1.ViewGroupId;
			pobjViewGroup.ViewGroupName = wucViewGroup1.ViewGroupName;
			pobjViewGroup.InRelaTabId = wucViewGroup1.InRelaTabId;
			pobjViewGroup.InSqlDsTypeId = wucViewGroup1.InSqlDsTypeId;
			pobjViewGroup.OutSqlDsTypeId = wucViewGroup1.OutSqlDsTypeId;
			pobjViewGroup.OutRelaTabId = wucViewGroup1.OutRelaTabId;
			pobjViewGroup.PrjDomain = wucViewGroup1.PrjDomain;
			pobjViewGroup.ActionPath = wucViewGroup1.ActionPath;
            pobjViewGroup.PrjId = clsPubVar.CurrSelPrjId;
			pobjViewGroup.UserId = clsCommonSession.UserId;
			pobjViewGroup.UpdDate = wucViewGroup1.getTodayStr(0);
			pobjViewGroup.TableNameForProg = wucViewGroup1.TableNameForProg;
			pobjViewGroup.Memo = wucViewGroup1.Memo;
		}

		protected void dgViewGroup_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
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
			if (strSortViewGroupBy == "") return ;
			if(e.Item.ItemType==ListItemType.Header)//����ؼ��Ƿ�Ϊҳü��
			{
				string strSortEx;
				for(int i=0;i<this.dgViewGroup.Columns.Count;i++)
				{
					strSortEx = this.dgViewGroup.Columns[i].SortExpression;
					if (strSortEx == "") continue;
					intIndex = strSortViewGroupBy.IndexOf(strSortEx + " ");
					if(intIndex >=0)  //��ͼ״̬��������ʽ�Ƿ�Ϊ���е��ֶΣ�
					{
						Label lblSort=new Label();
						lblSort.Font.Name="webdings";//�������壬��"webdings"��5�������ǣ�6�������ǣ�
						intIndex = strSortViewGroupBy.IndexOf("Asc");
						lblSort.Text=(intIndex>0?" 5":" 6");//�Ƿ�Ϊ���򣬶���Ϊstring�ͣ�
						e.Item.Cells[i].Controls.Add(lblSort);//��������ĵ�i����Ԫ��������һ�ؼ���
						break;
					}
				}
			}
		}

		protected void dgViewGroup_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			string strViewGroupId;
			string strCommandName;
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.SelectedItem ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
				strCommandName = ((LinkButton)e.CommandSource).CommandName;
				strViewGroupId = e.Item.Cells[1].Text;
				switch(strCommandName)
				{
					case "Delete":
						clsViewGroupBL.DelRecord(strViewGroupId);
						BindDg_ViewGroup();
						break;
						// Add other cases here, if there are multiple ButtonColumns in 
						// the DataGrid control.
					case "Update":
						//�������裺���ܹ�2����
						//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
						//2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�

						//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
						ShowData(strViewGroupId);
						//2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
						clsPubFun.SetButtonEnabled(btnOKUpd, true);
						wucViewGroup1.SetKeyReadOnly(true);
						btnOKUpd.Text = "ȷ���޸�";
						lblMsg.Text = "";
						break;

					default:
						// Do nothing.
						break;
				}
			}
		}

		
		//��ǰ��¼��
		protected void btnAddNewRec4Dg_Click(object sender, System.EventArgs e)
		{
			wucViewGroup1.SetKeyReadOnly(false);
			btnOKUpd.Text = "ȷ�����";
            wucViewGroup1.ViewGroupId = clsViewGroupBL.GetMaxStrIdByPrefix_S(clsPubVar.CurrSelPrjId);
            wucViewGroup1.PrjDomain = clsProjectsBL.GetObjByPrjIdCache(clsPubVar.CurrSelPrjId).PrjDomain; 
		}

		
		//��ǰ��¼��
		protected void btnExportExcel4Dg_Click(object sender, System.EventArgs e)
		{
			//	1����Ͻ�����������
			string strWhereCond = CombineViewGroupCondition();
			//	2��������������ȡ�ñ�����������DataTable��
			System.Data.DataTable objDT = clsViewGroupBL.GetDataTable_ViewGroup(strWhereCond);
			List<string> arrCnName = new List<string>();
			List<string> arrColName = new List<string>();
			string strFileName = "ViewGroup��Ϣ����.xls";
			string strFolderName;
			string strDownLoadFileName;
			arrColName.Add("ViewGroupId"); arrCnName.Add("������ID");
			arrColName.Add("ViewGroupName"); arrCnName.Add("����������");
			arrColName.Add("InRelaTabId"); arrCnName.Add("��������Դ��ID");
			arrColName.Add("InSqlDsTypeId"); arrCnName.Add("��������Դ����");
			arrColName.Add("OutSqlDsTypeId"); arrCnName.Add("�������Դ����");
			arrColName.Add("OutRelaTabId"); arrCnName.Add("�������Դ��ID");
			arrColName.Add("PrjDomain"); arrCnName.Add("��/����");
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
			string strViewGroupId =(string) rd.Value;
			if (strViewGroupId == null || strViewGroupId.Trim().Length == 0) 
			{
				lblMsg.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
				return ;
			}
			lblMsg.Text = "";
			clsViewGroupBL.DelRecord(strViewGroupId);
			BindDg_ViewGroup();
		}

		
		//��ǰ��¼��
		protected void btnUpdate4Dg_Click(object sender, System.EventArgs e)
		{
			string strViewGroupId =(string) rd.Value;
			if (strViewGroupId == null || strViewGroupId.Trim().Length == 0) 
			{
				lblMsg.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
				return ;
			}
			lblMsg.Text = "";
			//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
			ShowData(strViewGroupId);
			//2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
			clsPubFun.SetButtonEnabled(btnOKUpd, true);
			wucViewGroup1.SetKeyReadOnly(true);
			btnOKUpd.Text = "ȷ���޸�";	
		}
	
		public System.Data.DataTable GetInSqlDsTypeId()
		{
			//��ȡĳѧԺ����רҵ��Ϣ
			string strSQL = "select SqlDsTypeId, SqlDsTypeName from SQLDSType ";
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}
		public void BindDdl_InSqlDsTypeId(System.Web.UI.WebControls.DropDownList objDDL)
		{
			//Ϊ����Դ�ڱ����������������
			ListItem li=new ListItem("��ѡ��...","0");
			System.Data.DataTable objDT = GetInSqlDsTypeId();
			objDDL.DataValueField="SqlDsTypeId";
			objDDL.DataTextField="SqlDsTypeName";
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
		
		protected void dgViewGroup_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
		{
			int intIndex;
			//�ж��Ƿ����µ������ֶ�
			intIndex = strSortViewGroupBy.IndexOf(e.SortExpression);
			if (intIndex == -1)
			{
				strSortViewGroupBy = e.SortExpression + " Asc";
				BindDg_ViewGroup();
				return ;
			}
			//���ԭ��������
			intIndex = strSortViewGroupBy.IndexOf(" Asc");
			if (intIndex == -1)		//���ԭ���������������Ϊ����
			{
				strSortViewGroupBy = e.SortExpression + " Asc";
			}
			else			///��������Ϊ����
			{
				strSortViewGroupBy = e.SortExpression + " Desc";
			}
			BindDg_ViewGroup();
		}

		private string strSortViewGroupBy
		{
			get
			{
				string sSortViewGroupBy;
				sSortViewGroupBy = (string)ViewState["SortViewGroupBy"];
				if (sSortViewGroupBy==null) 
				{
					sSortViewGroupBy = "";
				}
				return sSortViewGroupBy;
			}
			set
			{
				string sSortViewGroupBy = value;
				ViewState.Add("SortViewGroupBy", sSortViewGroupBy);
			}
		}

		//���ɸ������SESSION������Ժ���
		protected void btnViewGroupPrevPage_Click(object sender, System.EventArgs e)
		{
			this.dgViewGroup.CurrentPageIndex -=1; 
			this.BindDg_ViewGroup(); 
		}

		protected void btnViewGroupNextPage_Click(object sender, System.EventArgs e)
		{
			this.dgViewGroup.CurrentPageIndex +=1; 
			this.BindDg_ViewGroup(); 
		}

		protected void btnViewGroupJumpPage_Click(object sender, System.EventArgs e)
		{
			if(this.txtViewGroupJump2Page.Text.Trim()!="" && 
				int.Parse(this.txtViewGroupJump2Page.Text)>0 && 
				int.Parse(this.txtViewGroupJump2Page.Text)-1<this.dgViewGroup.PageCount) 
			{ 
				this.dgViewGroup.CurrentPageIndex=int.Parse(this.txtViewGroupJump2Page.Text)-1; 
			} 
			this.BindDg_ViewGroup();
		}

		protected void btnEditViewGroupFlds_Click(object sender, System.EventArgs e)
		{
			string strViewGroupId =(string) rd.Value;
			if (strViewGroupId == null || strViewGroupId.Trim().Length == 0) 
			{
				lblMsg.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
				return ;
			}
			lblMsg.Text = "";
			//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
			///
			clsCommonSession.seBackErrPageLinkStr  = "../View/wfmViewGroup_QUDI.aspx";
			ViewGroupId = strViewGroupId;
			Response.Redirect("../J2EE/wfmViewGroupFlds_QUDI.aspx");
		}

		protected void btnEditStrutsAction_Click(object sender, System.EventArgs e)
		{
			string strViewGroupId =(string) rd.Value;
			if (strViewGroupId == null || strViewGroupId.Trim().Length == 0) 
			{
				lblMsg.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
				return ;
			}
			lblMsg.Text = "";
			//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
			///
			clsCommonSession.seBackErrPageLinkStr  = "../View/wfmViewGroup_QUDI.aspx";
			ViewGroupId = strViewGroupId;
			Response.Redirect("../J2EE/wfmStrutsAction_QUDI.aspx");
		
		}

		protected void btnEditActionForm_Click(object sender, System.EventArgs e)
		{
			string strViewGroupId =(string) rd.Value;
			if (strViewGroupId == null || strViewGroupId.Trim().Length == 0) 
			{
				lblMsg.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
				return ;
			}
			lblMsg.Text = "";
			//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
			///
			clsCommonSession.seBackErrPageLinkStr  = "../View/wfmViewGroup_QUDI.aspx";
			ViewGroupId = strViewGroupId;
			Response.Redirect("../J2EE/wfmActionForm_QUDI.aspx");		
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