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
using System.Collections.Generic;
using AGC.Entity;



using com.taishsoft.common;
using System.Text;
using AutoGCLib;


namespace AGC.Webform
{
	/// <summary>
	/// wfmQryRegionFlds_QUDI ��ժҪ˵��������Q�����ѯ��U�����޸�
	/// </summary>
	public partial class wfmQryRegionFlds_QUDI : CommWebPageBase
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
				wucQryRegionFlds1.SetDdl_CtlTypeId(false);
				wucQryRegionFlds1.SetDdl_DdlItemsOptionId();
                wucQryRegionFlds1.SetDdl_DsTabId(clsPubVar.CurrSelPrjId);
	
				wucQryRegionFlds1.SetDdl_QueryOptionId();
                clsCtlTypeBLEx.BindDdl_CtlTypeIdCacheEx(ddlCtlTypeIdq);
                clsDDLItemsOptionBL.BindDdl_DdlItemsOptionIdCache(ddlDdlItemsOptionIdq);
                clsQueryOptionBL.BindDdl_QueryOptionIdCache(ddlQueryOptionIdq);
				strSortQryRegionFldsBy = "SeqNum Asc";
				//2����ʾ�������ı�������DATAGRID��
				///
				if (string.IsNullOrEmpty(RegionId )== true)
				{
					return ;
				}
				lblRegionName.Text = clsViewRegionBL.GetObjByRegionIdCache(RegionId, clsPubVar.CurrSelPrjId).RegionName;
				BindDg_QryRegionFlds();
				
				tabEditQryRegionFldsRegion.Visible = false;  //������Ϣά����������

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
				strSimpleFName = (string)Session["SimpleFName"];
				if (strSimpleFName==null) 
				{
					strSimpleFName = "";
				}
				return strSimpleFName;
			}
			set
			{
				string strSimpleFName = value;
				Session.Add("SimpleFName", strSimpleFName);
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
		

		
		/// <summary>
		/// �����еĲ�ѯ�ؼ�������ϳ�һ��������
		/// </summary>
		/// <returns>������(strWhereCond)</returns>
		private string CombineQryRegionFldsCondition()
		{
			//ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
			//���� 1=1 && UserName = '����'
			string strWhereCond=" 1=1 and RegionId = '" + RegionId + "'";
			//����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
			if (this.ddlCtlTypeIdq.SelectedValue!="" && this.ddlCtlTypeIdq.SelectedValue!="0")
			{
				strWhereCond += " And CtlTypeId='" + this.ddlCtlTypeIdq.SelectedValue+"'";
			}
			if (this.ddlDdlItemsOptionIdq.SelectedValue!="" && this.ddlDdlItemsOptionIdq.SelectedValue!="0")
			{
				strWhereCond += " And DdlItemsOptionId='" + this.ddlDdlItemsOptionIdq.SelectedValue+"'";
			}
			if (this.ddlQueryOptionIdq.SelectedValue!="" && this.ddlQueryOptionIdq.SelectedValue!="0")
			{
				strWhereCond += " And QryRegionFlds.QueryOptionId='" + this.ddlQueryOptionIdq.SelectedValue+"'";
			}

			return strWhereCond;
		}
		///���ɰ�DATAGRID�Ĵ���
		/// <summary>
		/// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
		///			 ����ʾ��DATAGRID�С�
		/// </summary>
		private void BindDg_QryRegionFlds()
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
			string strWhereCond = CombineQryRegionFldsCondition();
			//	2��������������ȡ�ñ�����������DataTable��
			System.Data.DataTable objDT = clsvQryRegionFldsBL.GetDataTable(strWhereCond  + " order by SeqNum" );
			//	3�����DATAGRID�ĵ�ǰҳ���Ƿ񳬳�DATAGRID��ҳ����Χ
			//		3.1 ���ȼ���ҳ����
			//		3.2 �����ǰҳ����ҳ����Ϊ���һҳ
			int intPages = CalcPages(objDT.Rows.Count, this.dgQryRegionFlds.PageSize);
			if (intPages==0) 
			{
				this.dgQryRegionFlds.CurrentPageIndex = 0;
			}
			else if (this.dgQryRegionFlds.CurrentPageIndex > intPages - 1) 
			{
				this.dgQryRegionFlds.CurrentPageIndex = intPages - 1;
			}
			//	4������DATAGRID������Դ(DataSource)��
			DataView objDV = objDT.DefaultView;
			objDV.Sort = strSortQryRegionFldsBy;     ///ע����һ�д����п�����Ҫע�͵���Ŀǰ���н����ڵ����Ĳ�ѯ������������
			this.dgQryRegionFlds.DataSource=objDV;
			//	5����DATAGRID������DataTable��������ʾ��DATAGRID��
			this.dgQryRegionFlds.DataBind();

			
			//��ǰ��¼��
			this.lblQryRegionFldsRecCount.Text = objDT.Rows.Count.ToString(); 
			//��ǰҳ��
			this.lblQryRegionFldsAllPages.Text = this.dgQryRegionFlds.PageCount.ToString(); 
			//��ǰҳ����
			this.lblQryRegionFldsCurrentPage.Text=(this.dgQryRegionFlds.CurrentPageIndex+1).ToString();
			//��ǰ����������ҳ����
			this.txtQryRegionFldsJump2Page.Text=(this.dgQryRegionFlds.CurrentPageIndex+1).ToString();
			//�����ǰҳ����Ϊ0����<ǰһҳ>��ť��Ч
			if(this.dgQryRegionFlds.CurrentPageIndex==0) 
			{
				btnQryRegionFldsPrevPage.Enabled=false; 
			}
			else 
			{ 
				btnQryRegionFldsPrevPage.Enabled=true; 
			} 
			//�����ǰҳ������Ϊ���һҳ����<ǰһҳ>��ť��Ч
			if(this.dgQryRegionFlds.CurrentPageIndex==this.dgQryRegionFlds.PageCount-1) 
			{ 
				btnQryRegionFldsNextPage.Enabled=false; 
			} 
			else 
			{ 
				btnQryRegionFldsNextPage.Enabled=true; 
			} 
			//7�������沿����ʾ����ʾ �������ǰDataGrid�еļ�¼��Ϊ0������ʾ��ǰ����ҳ������
			if(objDT.Rows.Count>0) 
			{ 
				this.tabQryRegionFldsJumpPage.Visible = true; 
			} 
			else 
			{ 
				this.tabQryRegionFldsJumpPage.Visible = false; 
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
			this.dgQryRegionFlds.CurrentPageIndex=0;
			//�ѱ��¼��������ʾ��DATAGRID��
			BindDg_QryRegionFlds();
		}
		/// <summary>
		/// �������ܣ��¼��������ڸ���DATAGRID�ĵ�ǰҳ����ʱ�����ĺ�����
		///			  ���幦����������ʾ��ҳ(������ҳ����)�����ݡ�
		/// </summary>
		/// <param name="source"></param>
		/// <param name="e"></param>
		protected void dgQryRegionFlds_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			//�������裺����2����
			//1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
			//2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ

			//1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
			this.dgQryRegionFlds.CurrentPageIndex=e.NewPageIndex;
			//2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ
			BindDg_QryRegionFlds();
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
			if (clsQryRegionFldsBL.IsExist(lngmId) == false)		//���ùؼ��ֵļ�¼�Ƿ����
			{
				string ss = "�ؼ���Ϊ��" + lngmId + "�Ĳ�����!";
				clsCommonJsFunc.Alert(this, ss);
				return ;
			}
			//3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
			clsQryRegionFldsEN objQryRegionFldsEN = new clsQryRegionFldsEN(lngmId);
			//4����ȡ�������������ԣ�
			clsQryRegionFldsBL.GetQryRegionFlds(ref objQryRegionFldsEN);
			Session.Add("objQryRegionFldsEN", objQryRegionFldsEN);
			//5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���
			GetDataFromQryRegionFldsClass(objQryRegionFldsEN);
			DispEditQryRegionFldsRegion();
		}
		///���ɴ��߼�������ݴ��䵽�����ĺ�������
		/// <summary>
		/// �������ܣ�������������������ʾ��������
		///ע�⣺��������������򣬲�����һ��������������ϵ�ģ�����Ϊһ��������ֵ��Ȼ����Ϊ����������ֵ
		///      ������������ݿ�ʱ����Ӧ��һ���ֶ���ǰ�������ֶ��ں�
		/// </summary>
		/// <param name="pobjQryRegionFlds">��ʵ�������</param>
		private void GetDataFromQryRegionFldsClass(clsQryRegionFldsEN pobjQryRegionFlds)
		{
			wucQryRegionFlds1.FldId = pobjQryRegionFlds.FldId;
			
			//clsvQryRegionFldsEN objvQryRegionFlds = clsvQryRegionFldsBL.GetFirstObj_S("RegionId = '" + RegionId + "' and TabFldId = " + pobjQryRegionFlds.TabFldId);
			//wucQryRegionFlds1.FldName = objvQryRegionFlds.FldName;

			wucQryRegionFlds1.CtlTypeId = pobjQryRegionFlds.CtlTypeId;
			wucQryRegionFlds1.DdlItemsOptionId = pobjQryRegionFlds.DdlItemsOptionId;
			wucQryRegionFlds1.DsTabId = pobjQryRegionFlds.DsTabId;
			wucQryRegionFlds1.DsCondStr = pobjQryRegionFlds.DsCondStr;
			wucQryRegionFlds1.DsSqlStr = pobjQryRegionFlds.DsSqlStr;
			wucQryRegionFlds1.ItemsString = pobjQryRegionFlds.ItemsString;
			wucQryRegionFlds1.SeqNum = pobjQryRegionFlds.SeqNum ?? 0;
	
			wucQryRegionFlds1.Memo = pobjQryRegionFlds.Memo;
			wucQryRegionFlds1.QueryOptionId = pobjQryRegionFlds.QueryOptionId;
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
			clsQryRegionFldsEN objQryRegionFldsEN;
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
					if (!wucQryRegionFlds1.IsValid(ref strResult))
					{
						lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
						return ;
					}
					//2��������󲢳�ʼ������
					//clsQryRegionFldsEN objQryRegionFldsEN;	//�������
					objQryRegionFldsEN = new clsQryRegionFldsEN();	//��ʼ���¶���
					//3���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
					//4����ֵ�ӽ���㴫���߼��������ʵ���
					PutDataToQryRegionFldsClass(objQryRegionFldsEN);		//�ѽ����ֵ����
					//5����鴫��ȥ�Ķ��������Ƿ�Ϸ�
                    try
                    {
                        clsQryRegionFldsBL.CheckPropertyNew(objQryRegionFldsEN);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
					//6��������ʵ�������ݴ��������ݿ���
                    if (clsQryRegionFldsBL.AddNewRecordBySql2(objQryRegionFldsEN) == false) 
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
					BindDg_QryRegionFlds();
					wucQryRegionFlds1.Clear();		//��տؼ�������
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
					if (!wucQryRegionFlds1.IsValid(ref strResult))
					{
						lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
						return ;
					}
					//2����ֵ�ӽ���㴫���߼��������ʵ���
					objQryRegionFldsEN = (clsQryRegionFldsEN) Session["objQryRegionFldsEN"];
					PutDataToQryRegionFldsClass(objQryRegionFldsEN);		//�ѽ����ֵ����
					//3����鴫��ȥ�Ķ��������Ƿ�Ϸ�
                    try
                    {
                        clsQryRegionFldsBL.CheckPropertyNew(objQryRegionFldsEN);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
					//4��������ʵ���������޸�ͬ�������ݿ���
                    if (clsQryRegionFldsBL.UpdateBySql2(objQryRegionFldsEN) == false) 
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
					BindDg_QryRegionFlds();
					wucQryRegionFlds1.Clear();//��տؼ��е�����
					//�ָ�<ȷ���޸�>���<���>
					btnOKUpd.Text = "���";
					DispQryRegionFldsInfo();
					break;
			}
		}
		
		/// <summary>
		/// �������ܣ��ѽ����ϵ��������ݴ����������
		/// </summary>
		/// <param name="pobjQryRegionFlds">���ݴ����Ŀ�������</param>
		private void PutDataToQryRegionFldsClass(clsQryRegionFldsEN pobjQryRegionFlds)
		{
			pobjQryRegionFlds.FldId = wucQryRegionFlds1.FldId;
			pobjQryRegionFlds.CtlTypeId = wucQryRegionFlds1.CtlTypeId;
			pobjQryRegionFlds.DdlItemsOptionId = wucQryRegionFlds1.DdlItemsOptionId;
			pobjQryRegionFlds.DsTabId = wucQryRegionFlds1.DsTabId;
			pobjQryRegionFlds.DsCondStr = wucQryRegionFlds1.DsCondStr;
			pobjQryRegionFlds.DsSqlStr = wucQryRegionFlds1.DsSqlStr;
			pobjQryRegionFlds.ItemsString = wucQryRegionFlds1.ItemsString;
			pobjQryRegionFlds.SeqNum = wucQryRegionFlds1.SeqNum;
			pobjQryRegionFlds.UpdDate = wucQryRegionFlds1.UpdDate;
			pobjQryRegionFlds.UpdUser = wucQryRegionFlds1.UserId;
			pobjQryRegionFlds.Memo = wucQryRegionFlds1.Memo;
			pobjQryRegionFlds.QueryOptionId = wucQryRegionFlds1.QueryOptionId;

		}

		protected void dgQryRegionFlds_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
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
			if (strSortQryRegionFldsBy == "") return ;
			if(e.Item.ItemType==ListItemType.Header)//����ؼ��Ƿ�Ϊҳü��
			{
				string strSortEx;
				for(int i=0;i<this.dgQryRegionFlds.Columns.Count;i++)
				{
					strSortEx = this.dgQryRegionFlds.Columns[i].SortExpression;
					if (strSortEx == "") continue;
					intIndex = strSortQryRegionFldsBy.IndexOf(strSortEx + " ");
					if(intIndex >=0)  //��ͼ״̬��������ʽ�Ƿ�Ϊ���е��ֶΣ�
					{
						Label lblSort=new Label();
						lblSort.Font.Name="webdings";//�������壬��"webdings"��5�������ǣ�6�������ǣ�
						intIndex = strSortQryRegionFldsBy.IndexOf("Asc");
						lblSort.Text=(intIndex>0?" 5":" 6");//�Ƿ�Ϊ���򣬶���Ϊstring�ͣ�
						e.Item.Cells[i].Controls.Add(lblSort);//��������ĵ�i����Ԫ��������һ�ؼ���
						break;
					}
				}
			}
		}

		protected void dgQryRegionFlds_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
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
						clsQryRegionFldsBL.DelRecord(lngmId);
						BindDg_QryRegionFlds();
						break;
						// Add other cases here, if there are multiple ButtonColumns in 
						// the DataGrid control.
					case "Update":
						//�������裺���ܹ�2����
						//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
						//2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�

						//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
						tabEditQryRegionFldsRegion.Visible = true;
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
					Set_DataGridAllChecked(dgQryRegionFlds, true);
					lbSelAll.Text = "��ѡ";
				}
				else if (lbSelAll.Text == "��ѡ")
				{
					Set_DataGridAllChecked(dgQryRegionFlds, false);
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
			
			
//			btnOKUpd.Text = "ȷ�����";

		}

		
		//��ǰ��¼��
		protected void btnExportExcel4Dg_Click(object sender, System.EventArgs e)
		{
			//	1����Ͻ�����������
			string strWhereCond = CombineQryRegionFldsCondition();
			//	2��������������ȡ�ñ�����������DataTable��
			System.Data.DataTable objDT = clsQryRegionFldsBL.GetDataTable_QryRegionFlds(strWhereCond);
			List<string> arrCnName = new List<string>();
			List<string> arrColName = new List<string>();
			string strFileName = "QryRegionFlds��Ϣ����.xls";
			string strFolderName;
			string strDownLoadFileName;
			arrColName.Add("mId"); arrCnName.Add("mId");
			arrColName.Add("RegionId"); arrCnName.Add("����Id");
			arrColName.Add("TabFldId"); arrCnName.Add("���ֶ�ID");
			arrColName.Add("CtlTypeId"); arrCnName.Add("�ؼ����ͺ�");
			arrColName.Add("DdlItemsOptionId"); arrCnName.Add("�������б�ѡ��ID");
			arrColName.Add("DsTabId"); arrCnName.Add("����Դ��ID");
			arrColName.Add("DsDataValueFieldId"); arrCnName.Add("����Դֵ�ֶ�Id");
			arrColName.Add("DsDataTextFieldId"); arrCnName.Add("����Դ�ı��ֶ�Id");
			arrColName.Add("DsCondStr"); arrCnName.Add("����Դ������");
			arrColName.Add("DsSqlStr"); arrCnName.Add("����ԴSQL��");
			arrColName.Add("ItemsString"); arrCnName.Add("�б��");
			arrColName.Add("SeqNum"); arrCnName.Add("�ֶ����");
			arrColName.Add("UpdDate"); arrCnName.Add("�޸�ʱ��");
			arrColName.Add("UserId"); arrCnName.Add("�û�ID");
			arrColName.Add("Memo"); arrCnName.Add("˵��");
			strFolderName = Server.MapPath("~") +  "\\TempFiles\\";
			strDownLoadFileName = strFolderName + strFileName;
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
            List<string> arrmId = clsCommForWebForm.GetAllCheckedItemFromDg2(dgQryRegionFlds, "chkCheckRec");
			if (arrmId == null || arrmId.Count == 0) 
			{
				lblMsg1.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
				return ;
			}
			lblMsg1.Text = "";
			clsQryRegionFldsBL.DelQryRegionFldss(arrmId);
			BindDg_QryRegionFlds();
		}

		
		//��ǰ��¼��
		protected void btnUpdate4Dg_Click(object sender, System.EventArgs e)
		{
			string strmId =clsCommForWebForm.GetFirstCheckedItemFromDg(dgQryRegionFlds);
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
		
		protected void dgQryRegionFlds_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
		{
			int intIndex;
			//�ж��Ƿ����µ������ֶ�
			intIndex = strSortQryRegionFldsBy.IndexOf(e.SortExpression);
			if (intIndex == -1)
			{
				strSortQryRegionFldsBy = e.SortExpression + " Asc";
				BindDg_QryRegionFlds();
				return ;
			}
			//���ԭ��������
			intIndex = strSortQryRegionFldsBy.IndexOf(" Asc");
			if (intIndex == -1)		//���ԭ���������������Ϊ����
			{
				strSortQryRegionFldsBy = e.SortExpression + " Asc";
			}
			else			///��������Ϊ����
			{
				strSortQryRegionFldsBy = e.SortExpression + " Desc";
			}
			BindDg_QryRegionFlds();
		}

		private string strSortQryRegionFldsBy
		{
			get
			{
				string sSortQryRegionFldsBy;
				sSortQryRegionFldsBy = (string)ViewState["SortQryRegionFldsBy"];
				if (sSortQryRegionFldsBy==null) 
				{
					sSortQryRegionFldsBy = "";
				}
				return sSortQryRegionFldsBy;
			}
			set
			{
				string sSortQryRegionFldsBy = value;
				ViewState.Add("SortQryRegionFldsBy", sSortQryRegionFldsBy);
			}
		}

		//���ɸ������SESSION������Ժ���
		protected void btnQryRegionFldsPrevPage_Click(object sender, System.EventArgs e)
		{
			this.dgQryRegionFlds.CurrentPageIndex -=1; 
			this.BindDg_QryRegionFlds(); 
		}

		protected void btnQryRegionFldsNextPage_Click(object sender, System.EventArgs e)
		{
			this.dgQryRegionFlds.CurrentPageIndex +=1; 
			this.BindDg_QryRegionFlds(); 
		}

		protected void btnQryRegionFldsJumpPage_Click(object sender, System.EventArgs e)
		{
			if(this.txtQryRegionFldsJump2Page.Text.Trim()!="" && 
				int.Parse(this.txtQryRegionFldsJump2Page.Text)>0 && 
				int.Parse(this.txtQryRegionFldsJump2Page.Text)-1<this.dgQryRegionFlds.PageCount) 
			{ 
				this.dgQryRegionFlds.CurrentPageIndex=int.Parse(this.txtQryRegionFldsJump2Page.Text)-1; 
			} 
			this.BindDg_QryRegionFlds();
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
            clsQryRegionFldsBLEx.ImportRelaFlds(RegionId, clsPubVar.CurrCmPrjId, UserId);
			BindDg_QryRegionFlds();
			///�ָ�<ȷ�����>���<���>
			//		lbDispFldList_Click(new object(), new System.EventArgs());
			Response.Write("<script>alert('�������ص������ֶ���Ϣ���Ƴɹ�����')</script>");
		}

		protected void LinkButton1_Click(object sender, System.EventArgs e)
		{
			DispQryRegionFldsInfo();
		}

		protected void btnGoBack_Click(object sender, System.EventArgs e)
		{
			Response.Redirect(BackViewRegionLinkStr);
		}
		private void DispQryRegionFldsInfo()
		{
			tabQryRegionFldsDataGrid.Visible = true;
			tabQryRegionFldsJumpPage.Visible = true;
			tabEditQryRegionFldsRegion.Visible = false;
			
			tabQryRegionPreview.Visible = true;
			tabCode.Visible = true;
		}
		private void DispPrjTabFldsInfo()
		{
			
			tabEditQryRegionFldsRegion.Visible = false;
			tabQryRegionFldsDataGrid.Visible = false;
			tabQryRegionFldsJumpPage.Visible = false;
			tabQryRegionPreview.Visible = false;
			tabCode.Visible = false;
		}
		private void DispEditQryRegionFldsRegion()
		{
			tabQryRegionFldsDataGrid.Visible = false;
			tabQryRegionFldsJumpPage.Visible = false;
			tabEditQryRegionFldsRegion.Visible = true;
			
			tabQryRegionPreview.Visible = false;
			tabCode.Visible = false;
		}


		protected void btnPreView_Click(object sender, System.EventArgs e)
		{
			string strMsg;
            string strViewId = clsCommonSession.ViewId;// clsViewRegionBL.GetObjByRegionIdCache(RegionId, clsPubVar.CurrSelPrjId).ViewId;
			//			tabQuery1.Visible = false;
			tabCode.Visible = true;

            clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
            clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, clsPubVar.CurrSelPrjId);
			
            //������ش���
            Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            string strRe_ClsName = "";
            string strRe_FileNameWithModuleName = "";
            try
            {
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
                if (WebViewCode4Html.DispQryRegionCtrl(phQryRegion, objViewInfoENEx) >= 0)
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

		protected void btnUpMove_Click(object sender, System.EventArgs e)
		{
			string strMsg;
			string strmId =clsCommForWebForm.GetFirstCheckedItemFromDg(dgQryRegionFlds);
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
				clsQryRegionFldsBLEx.AdjustSequenceNumber("UP", lngmId);
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
			BindDg_QryRegionFlds();
			clsCommForWebForm.SetCheckedItemForDg(dgQryRegionFlds, 1, strmId);
		}

		protected void btnDownMove_Click(object sender, System.EventArgs e)
		{
			string strMsg;
			string strmId =clsCommForWebForm.GetFirstCheckedItemFromDg(dgQryRegionFlds);
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
				clsQryRegionFldsBLEx.AdjustSequenceNumber("DOWN", lngmId);
			}
			
			catch(Exception objException)
			{
				strMsg = objException.Message;
				clsCommonJsFunc.Alert(this, strMsg);
				lblMsg1.Text = strMsg;
				//				clsCommonSession.seErrMessage = objException.Message;
				//				clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;	//"../Webform/GenCode/wfmGenViewCode_WebV5.aspx";
				//				clsPubFun4Web.AccessError(this, conCurrPageName);
			}
			BindDg_QryRegionFlds();
			clsCommForWebForm.SetCheckedItemForDg(dgQryRegionFlds, 1, strmId);

		}

		protected void btnReOrder_Click(object sender, System.EventArgs e)
		{
			clsQryRegionFldsBLEx.ReOrder(RegionId);
			BindDg_QryRegionFlds();
		}

		protected void lbDispTabList_Click(object sender, System.EventArgs e)
		{
			DispQryRegionFldsInfo();
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