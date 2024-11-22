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
	/// wfmEditRegionFlds_QUDI ��ժҪ˵��������Q�����ѯ��U�����޸�
	/// </summary>
	public partial class wfmEditRegionFlds_QUDI : CommWebPageBase
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
				wucEditRegionFlds1.SetDdl_CtlTypeId(false);
				wucEditRegionFlds1.SetDdl_DdlItemsOptionId();
                wucEditRegionFlds1.SetDdl_DsTabId(clsPubVar.CurrSelPrjId);
				wucEditRegionFlds1.SetDdl_InOutTypeId();
                clsCtlTypeBLEx.BindDdl_CtlTypeIdCacheEx(ddlCtlTypeIdq);
                
                clsDDLItemsOptionBL.BindDdl_DdlItemsOptionIdCache(ddlDdlItemsOptionIdq);
				clsDropDownList.BindDdl_InOutTypeId(ddlInOutTypeId);
				//��ʼ��������Դ���ͣ�
				
				strSortEditRegionFldsBy = "SeqNum Asc";
				//2����ʾ�������ı�������DATAGRID��
				///
				if (string.IsNullOrEmpty(RegionId )== true)
				{
					return ;
				}
				lblRegionName.Text = clsViewRegionBL.GetObjByRegionIdCache(RegionId, clsPubVar.CurrSelPrjId).RegionName;
				BindDg_EditRegionFlds();
                tabEditEditRegionFldsRegion.Visible = false;  //������Ϣά����������

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

        private string SimpleFName
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
		private string CombineEditRegionFldsCondition()
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
			return strWhereCond;
		}
		///���ɰ�DATAGRID�Ĵ���
		/// <summary>
		/// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
		///			 ����ʾ��DATAGRID�С�
		/// </summary>
		private void BindDg_EditRegionFlds()
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
			string strWhereCond = CombineEditRegionFldsCondition();
			//	2��������������ȡ�ñ�����������DataTable��
			System.Data.DataTable objDT = clsvEditRegionFldsBL.GetDataTable(strWhereCond + " order by SeqNum" );
			//	3�����DATAGRID�ĵ�ǰҳ���Ƿ񳬳�DATAGRID��ҳ����Χ
			//		3.1 ���ȼ���ҳ����
			//		3.2 �����ǰҳ����ҳ����Ϊ���һҳ
			int intPages = CalcPages(objDT.Rows.Count, this.dgEditRegionFlds.PageSize);
			if (intPages==0) 
			{
				this.dgEditRegionFlds.CurrentPageIndex = 0;
			}
			else if (this.dgEditRegionFlds.CurrentPageIndex > intPages - 1) 
			{
				this.dgEditRegionFlds.CurrentPageIndex = intPages - 1;
			}
			//	4������DATAGRID������Դ(DataSource)��
			DataView objDV = objDT.DefaultView;
			objDV.Sort = strSortEditRegionFldsBy;     ///ע����һ�д����п�����Ҫע�͵���Ŀǰ���н����ڵ����Ĳ�ѯ������������
			this.dgEditRegionFlds.DataSource=objDV;
			//	5����DATAGRID������DataTable��������ʾ��DATAGRID��
			this.dgEditRegionFlds.DataBind();

			
			//��ǰ��¼��
			this.lblEditRegionFldsRecCount.Text = objDT.Rows.Count.ToString(); 
			//��ǰҳ��
			this.lblEditRegionFldsAllPages.Text = this.dgEditRegionFlds.PageCount.ToString(); 
			//��ǰҳ����
			this.lblEditRegionFldsCurrentPage.Text=(this.dgEditRegionFlds.CurrentPageIndex+1).ToString();
			//��ǰ����������ҳ����
			this.txtEditRegionFldsJump2Page.Text=(this.dgEditRegionFlds.CurrentPageIndex+1).ToString();
			//�����ǰҳ����Ϊ0����<ǰһҳ>��ť��Ч
			if(this.dgEditRegionFlds.CurrentPageIndex==0) 
			{
				btnEditRegionFldsPrevPage.Enabled=false; 
			}
			else 
			{ 
				btnEditRegionFldsPrevPage.Enabled=true; 
			} 
			//�����ǰҳ������Ϊ���һҳ����<ǰһҳ>��ť��Ч
			if(this.dgEditRegionFlds.CurrentPageIndex==this.dgEditRegionFlds.PageCount-1) 
			{ 
				btnEditRegionFldsNextPage.Enabled=false; 
			} 
			else 
			{ 
				btnEditRegionFldsNextPage.Enabled=true; 
			} 
			//7�������沿����ʾ����ʾ �������ǰDataGrid�еļ�¼��Ϊ0������ʾ��ǰ����ҳ������
			if(objDT.Rows.Count>0) 
			{ 
				this.tabEditRegionFldsJumpPage.Visible = true; 
			} 
			else 
			{ 
				this.tabEditRegionFldsJumpPage.Visible = false; 
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
			this.dgEditRegionFlds.CurrentPageIndex=0;
			//�ѱ��¼��������ʾ��DATAGRID��
			BindDg_EditRegionFlds();
		}
		/// <summary>
		/// �������ܣ��¼��������ڸ���DATAGRID�ĵ�ǰҳ����ʱ�����ĺ�����
		///			  ���幦����������ʾ��ҳ(������ҳ����)�����ݡ�
		/// </summary>
		/// <param name="source"></param>
		/// <param name="e"></param>
		protected void dgEditRegionFlds_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			//�������裺����2����
			//1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
			//2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ

			//1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
			this.dgEditRegionFlds.CurrentPageIndex=e.NewPageIndex;
			//2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ
			BindDg_EditRegionFlds();
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
			if (clsEditRegionFldsBL.IsExist(lngmId) == false)		//���ùؼ��ֵļ�¼�Ƿ����
			{
				string ss = "�ؼ���Ϊ��" + lngmId + "�Ĳ�����!";
				clsCommonJsFunc.Alert(this, ss);
				return ;
			}
			//3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
			clsEditRegionFldsEN objEditRegionFlds = new clsEditRegionFldsEN(lngmId);
            //4����ȡ�������������ԣ�
            clsEditRegionFldsBL .GetEditRegionFlds(ref objEditRegionFlds);
			Session.Add("objEditRegionFlds", objEditRegionFlds);
			//5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���
			GetDataFromEditRegionFldsClass(objEditRegionFlds);
			DispEditEditRegionFldsRegion();
		}
		///���ɴ��߼�������ݴ��䵽�����ĺ�������
		/// <summary>
		/// �������ܣ�������������������ʾ��������
		///ע�⣺��������������򣬲�����һ��������������ϵ�ģ�����Ϊһ��������ֵ��Ȼ����Ϊ����������ֵ
		///      ������������ݿ�ʱ����Ӧ��һ���ֶ���ǰ�������ֶ��ں�
		/// </summary>
		/// <param name="pobjEditRegionFlds">��ʵ�������</param>
		private void GetDataFromEditRegionFldsClass(clsEditRegionFldsEN pobjEditRegionFlds)
		{
			wucEditRegionFlds1.FldId = pobjEditRegionFlds.FldId;
			
			//clsvEditRegionFldsEN objvEditRegionFlds =  clsvEditRegionFldsBL.GetFirstObj_S("RegionId = '" + RegionId + "' and TabFldId = " + pobjEditRegionFlds.TabFldId);
			//wucEditRegionFlds1.FldName = objvEditRegionFlds.FldName;

			wucEditRegionFlds1.CtlTypeId = pobjEditRegionFlds.CtlTypeId;
			wucEditRegionFlds1.DdlItemsOptionId = pobjEditRegionFlds.DdlItemsOptionId;
			wucEditRegionFlds1.DsTabId = pobjEditRegionFlds.DsTabId;
			wucEditRegionFlds1.DsCondStr = pobjEditRegionFlds.DsCondStr;
			wucEditRegionFlds1.DsSqlStr = pobjEditRegionFlds.DsSqlStr;
			wucEditRegionFlds1.ItemsString = pobjEditRegionFlds.ItemsString;
			wucEditRegionFlds1.InOutTypeId = pobjEditRegionFlds.InOutTypeId;
			wucEditRegionFlds1.SeqNum = pobjEditRegionFlds.SeqNum ?? 0;
			wucEditRegionFlds1.UpdDate = pobjEditRegionFlds.UpdDate;
			wucEditRegionFlds1.Memo = pobjEditRegionFlds.Memo;
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
			clsEditRegionFldsEN objEditRegionFlds;
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
					if (!wucEditRegionFlds1.IsValid(ref strResult))
					{
						lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
						return ;
					}
					//2��������󲢳�ʼ������
					//clsEditRegionFldsEN objEditRegionFlds;	//�������
					objEditRegionFlds = new clsEditRegionFldsEN();	//��ʼ���¶���
					//3���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
					//4����ֵ�ӽ���㴫���߼��������ʵ���
					PutDataToEditRegionFldsClass(objEditRegionFlds);		//�ѽ����ֵ����
					//5����鴫��ȥ�Ķ��������Ƿ�Ϸ�
                    try
                    {
                        clsEditRegionFldsBL.CheckPropertyNew(objEditRegionFlds);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }

					//6��������ʵ�������ݴ��������ݿ���
					if (clsEditRegionFldsBL .AddNewRecordBySql2(objEditRegionFlds) == false) 
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
					BindDg_EditRegionFlds();
					wucEditRegionFlds1.Clear();		//��տؼ�������
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
					if (!wucEditRegionFlds1.IsValid(ref strResult))
					{
						lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
						return ;
					}
					//2����ֵ�ӽ���㴫���߼��������ʵ���
					objEditRegionFlds = (clsEditRegionFldsEN) Session["objEditRegionFlds"];
					PutDataToEditRegionFldsClass(objEditRegionFlds);		//�ѽ����ֵ����
					//3����鴫��ȥ�Ķ��������Ƿ�Ϸ�
                    try
                    {
                        clsEditRegionFldsBL.CheckPropertyNew(objEditRegionFlds);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }

					//4��������ʵ���������޸�ͬ�������ݿ���
					if (clsEditRegionFldsBL .UpdateBySql2(objEditRegionFlds) == false) 
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
					BindDg_EditRegionFlds();
					wucEditRegionFlds1.Clear();//��տؼ��е�����
					//�ָ�<ȷ���޸�>���<���>
					btnOKUpd.Text = "���";
					
					DispEditRegionFldsInfo();

					break;
			}
		}
		
		/// <summary>
		/// �������ܣ��ѽ����ϵ��������ݴ����������
		/// </summary>
		/// <param name="pobjEditRegionFlds">���ݴ����Ŀ�������</param>
		private void PutDataToEditRegionFldsClass(clsEditRegionFldsEN pobjEditRegionFlds)
		{
			pobjEditRegionFlds.FldId = wucEditRegionFlds1.FldId;
			pobjEditRegionFlds.CtlTypeId = wucEditRegionFlds1.CtlTypeId;
			pobjEditRegionFlds.DdlItemsOptionId = wucEditRegionFlds1.DdlItemsOptionId;
			pobjEditRegionFlds.DsTabId = wucEditRegionFlds1.DsTabId;
			pobjEditRegionFlds.DsCondStr = wucEditRegionFlds1.DsCondStr;
			pobjEditRegionFlds.DsSqlStr = wucEditRegionFlds1.DsSqlStr;
			pobjEditRegionFlds.ItemsString = wucEditRegionFlds1.ItemsString;
			pobjEditRegionFlds.InOutTypeId = wucEditRegionFlds1.InOutTypeId;
			pobjEditRegionFlds.SeqNum = wucEditRegionFlds1.SeqNum;
			pobjEditRegionFlds.UpdDate = wucEditRegionFlds1.UpdDate;
			pobjEditRegionFlds.UpdUser = UserId;
			pobjEditRegionFlds.Memo = wucEditRegionFlds1.Memo;
		}

		protected void dgEditRegionFlds_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
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
			if (strSortEditRegionFldsBy == "") return ;
			if(e.Item.ItemType==ListItemType.Header)//����ؼ��Ƿ�Ϊҳü��
			{
				string strSortEx;
				for(int i=0;i<this.dgEditRegionFlds.Columns.Count;i++)
				{
					strSortEx = this.dgEditRegionFlds.Columns[i].SortExpression;
					if (strSortEx == "") continue;
					intIndex = strSortEditRegionFldsBy.IndexOf(strSortEx + " ");
					if(intIndex >=0)  //��ͼ״̬��������ʽ�Ƿ�Ϊ���е��ֶΣ�
					{
						Label lblSort=new Label();
						lblSort.Font.Name="webdings";//�������壬��"webdings"��5�������ǣ�6�������ǣ�
						intIndex = strSortEditRegionFldsBy.IndexOf("Asc");
						lblSort.Text=(intIndex>0?" 5":" 6");//�Ƿ�Ϊ���򣬶���Ϊstring�ͣ�
						e.Item.Cells[i].Controls.Add(lblSort);//��������ĵ�i����Ԫ��������һ�ؼ���
						break;
					}
				}
			}
		}

		protected void dgEditRegionFlds_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
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
						clsEditRegionFldsBL.DelRecord(lngmId);
						BindDg_EditRegionFlds();
						break;
						// Add other cases here, if there are multiple ButtonColumns in 
						// the DataGrid control.
					case "Update":
						//�������裺���ܹ�2����
						//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
						//2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�

						//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
						tabEditEditRegionFldsRegion.Visible = true;
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
					Set_DataGridAllChecked(dgEditRegionFlds, true);
					lbSelAll.Text = "��ѡ";
				}
				else if (lbSelAll.Text == "��ѡ")
				{
					Set_DataGridAllChecked(dgEditRegionFlds, false);
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
	
		private bool SetCheckedItemForDg(DataGrid objDg, int intColIndex, string strValue)
		{
			if(objDg.Items.Count==0)
			{
				return false;
			}
			else
			{
				foreach(DataGridItem di in objDg.Items)
				{
					if (di.Cells[intColIndex].Text == strValue)
					{
						CheckBox chkCheckRec=(CheckBox)di.FindControl("chkCheckRec");
					    chkCheckRec.Checked = true;
						return true;
					}
				}
			}
			return false;
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
			string strWhereCond = CombineEditRegionFldsCondition();
			//	2��������������ȡ�ñ�����������DataTable��
			System.Data.DataTable objDT = clsEditRegionFldsBL.GetDataTable_EditRegionFlds(strWhereCond);
			List<string> arrCnName = new List<string>();
			List<string> arrColName = new List<string>();
			string strFileName = "EditRegionFlds��Ϣ����.xls";
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
            List<string> arrmId = clsCommForWebForm.GetAllCheckedItemFromDg2(dgEditRegionFlds, "chkCheckRec");
			if (arrmId == null || arrmId.Count == 0) 
			{
				lblMsg1.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
				return ;
			}
			lblMsg1.Text = "";
			clsEditRegionFldsBL.DelEditRegionFldss(arrmId);
			BindDg_EditRegionFlds();
		}

		
		//��ǰ��¼��
		protected void btnUpdate4Dg_Click(object sender, System.EventArgs e)
		{
			string strmId =clsCommForWebForm.GetFirstCheckedItemFromDg(dgEditRegionFlds);
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
		
		protected void dgEditRegionFlds_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
		{
			int intIndex;
			//�ж��Ƿ����µ������ֶ�
			intIndex = strSortEditRegionFldsBy.IndexOf(e.SortExpression);
			if (intIndex == -1)
			{
				strSortEditRegionFldsBy = e.SortExpression + " Asc";
				BindDg_EditRegionFlds();
				return ;
			}
			//���ԭ��������
			intIndex = strSortEditRegionFldsBy.IndexOf(" Asc");
			if (intIndex == -1)		//���ԭ���������������Ϊ����
			{
				strSortEditRegionFldsBy = e.SortExpression + " Asc";
			}
			else			///��������Ϊ����
			{
				strSortEditRegionFldsBy = e.SortExpression + " Desc";
			}
			BindDg_EditRegionFlds();
		}

		private string strSortEditRegionFldsBy
		{
			get
			{
				string sSortEditRegionFldsBy;
				sSortEditRegionFldsBy = (string)ViewState["SortEditRegionFldsBy"];
				if (sSortEditRegionFldsBy==null) 
				{
					sSortEditRegionFldsBy = "";
				}
				return sSortEditRegionFldsBy;
			}
			set
			{
				string sSortEditRegionFldsBy = value;
				ViewState.Add("SortEditRegionFldsBy", sSortEditRegionFldsBy);
			}
		}

		//���ɸ������SESSION������Ժ���
		protected void btnEditRegionFldsPrevPage_Click(object sender, System.EventArgs e)
		{
			this.dgEditRegionFlds.CurrentPageIndex -=1; 
			this.BindDg_EditRegionFlds(); 
		}

		protected void btnEditRegionFldsNextPage_Click(object sender, System.EventArgs e)
		{
			this.dgEditRegionFlds.CurrentPageIndex +=1; 
			this.BindDg_EditRegionFlds(); 
		}

		protected void btnEditRegionFldsJumpPage_Click(object sender, System.EventArgs e)
		{
			if(this.txtEditRegionFldsJump2Page.Text.Trim()!="" && 
				int.Parse(this.txtEditRegionFldsJump2Page.Text)>0 && 
				int.Parse(this.txtEditRegionFldsJump2Page.Text)-1<this.dgEditRegionFlds.PageCount) 
			{ 
				this.dgEditRegionFlds.CurrentPageIndex=int.Parse(this.txtEditRegionFldsJump2Page.Text)-1; 
			} 
			this.BindDg_EditRegionFlds();
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

            clsEditRegionFldsBLEx.ImportRelaFlds(RegionId, clsPubVar.CurrCmPrjId, UserId);
			BindDg_EditRegionFlds();
			///�ָ�<ȷ�����>���<���>
			//		lbDispFldList_Click(new object(), new System.EventArgs());
			Response.Write("<script>alert('�������ص������ֶ���Ϣ���Ƴɹ�����')</script>");
		}

		protected void btnOKAddRec_Click(object sender, System.EventArgs e)
		{
			
		}
		
		protected void LinkButton1_Click(object sender, System.EventArgs e)
		{
			DispEditRegionFldsInfo();
		}

		protected void btnGoBack_Click(object sender, System.EventArgs e)
		{
			Response.Redirect(BackViewRegionLinkStr);
		}

		

		private void DispEditRegionFldsInfo()
		{
			tabEditRegionFldsDataGrid.Visible = true;
			tabEditRegionFldsJumpPage.Visible = true;
			tabEditEditRegionFldsRegion.Visible = false;
		
			tabEditRegionPreview.Visible = true;
			tabCode.Visible = true;
		}
		private void DispPrjTabFldsInfo()
		{
			
			tabEditEditRegionFldsRegion.Visible = false;
			tabEditRegionFldsDataGrid.Visible = false;
			tabEditRegionFldsJumpPage.Visible = false;
			tabEditRegionPreview.Visible = false;
			tabCode.Visible = false;
		}
		private void DispEditEditRegionFldsRegion()
		{
			tabEditRegionFldsDataGrid.Visible = false;
			tabEditRegionFldsJumpPage.Visible = false;
			tabEditEditRegionFldsRegion.Visible = true;
			
			tabEditRegionPreview.Visible = false;
			tabCode.Visible = false;
		}

		protected void btnPreView_Click(object sender, System.EventArgs e)
		{
			string strMsg;
            string strViewId = clsCommonSession.ViewId;// clsViewRegionBL.GetObjByRegionIdCache(RegionId, clsPubVar.CurrSelPrjId).ViewId;
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
                if (WebViewCode4Html.DispEditRegionCtrl(phEditRegion, objViewInfoENEx) == true)
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

		protected void btnDownMove_Click(object sender, System.EventArgs e)
		{
			string strMsg;
			string strmId =clsCommForWebForm.GetFirstCheckedItemFromDg(dgEditRegionFlds);
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
				clsEditRegionFldsBLEx.AdjustSequenceNumber("DOWN", lngmId);
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
			BindDg_EditRegionFlds();
			clsCommForWebForm.SetCheckedItemForDg(dgEditRegionFlds, 1, strmId);


		}

		protected void btnUpMove_Click(object sender, System.EventArgs e)
		{
			string strMsg;
			string strmId =clsCommForWebForm.GetFirstCheckedItemFromDg(dgEditRegionFlds);
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
				clsEditRegionFldsBLEx.AdjustSequenceNumber("UP", lngmId);
				
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
			BindDg_EditRegionFlds();
clsCommForWebForm.SetCheckedItemForDg(dgEditRegionFlds, 1, strmId);
		}

		protected void btnReOrder_Click(object sender, System.EventArgs e)
		{
			clsEditRegionFldsBLEx.ReOrder(RegionId);
			BindDg_EditRegionFlds();
		}

		protected void lbDispTabList_Click(object sender, System.EventArgs e)
		{
			DispEditRegionFldsInfo();
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