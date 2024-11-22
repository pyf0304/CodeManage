///���ɲ�ѯ���޸ģ�ɾ������Ӽ�¼�Ŀ��Ʋ����


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
using AGC.BusinessLogic;using AGC.FunClass;

using AGC.BusinessLogicEx;
using AGC.Entity;



using com.taishsoft.common;

namespace AGC.Webform
{
	/// <summary>
	/// wfmViewRegion_QUDI ��ժҪ˵��������Q�����ѯ��U�����޸�
	/// </summary>
	public partial class wfmViewRegion_QUDIBak : CommWebPageBase
    {
		//�����йصı����������
		private const string ViewId4Potence="00260203";		//������
        /// <summary>
        /// ������ʽ������ӽ����������AddViewRelaRegion, �޸ģ�UpdRec��
        /// </summary>
        private string qsOperator
        {
            get
            {
                string strOperator = Request.QueryString["Operator"] ?? "".ToString();
                if ((strOperator != null) && (strOperator != ""))
                {
                    return strOperator;//Request.QueryString["id"] ?? "";
                }
                else
                {
                    return "";
                }
            }
        }


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
				divViewRelaRegion.Visible = false;
				//1��Ϊ��������������Դ�����б�����
                wucViewRegion1.SetDdl_ViewId(clsPubVar.CurrSelPrjId);
				wucViewRegion1.SetDdl_RegionTypeId();
				wucViewRegion1.SetDdl_INOUTTypeId();
				wucViewRegion1.SetDdl_TabId(clsPubVar.CurrSelPrjId);
				wucDGRegion1.SetDdl_DGStyleId();

				strSortViewRegionBy = "RegionId Asc";
				//2����ʾ�������ı�������DATAGRID��
				clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewId_Cache(ViewId, clsPubVar.CurrSelPrjId);
				lblViewName.Text = objViewInfo.ViewCnName + "(" + objViewInfo.ViewName + ")";
//lblViewName.Text = new clsViewInfoEN(ViewId, true).ViewCnName + new clsViewInfoEN(ViewId, true).ViewName;
				BindDg_ViewRegion();
                HideAllRegion();

                if (qsOperator == "AddViewRelaRegion")
                {
                    divViewRelaRegion.Visible = true;
                }
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



        private string ViewId
		{
			get
			{
				string strViewId;
				strViewId = (string)Session["ViewId"];
				if (strViewId==null) 
				{
					strViewId = "";
				}
				return strViewId;
			}
			set
			{
				string strViewId = value;
				Session.Add("ViewId", strViewId);
			}
		}
		private string BackViewInfoLinkStr
		{
			get
			{
				string strBackViewInfoLinkStr;
				strBackViewInfoLinkStr = (string)Session["BackViewInfoLinkStr"];
				if (strBackViewInfoLinkStr==null) 
				{
					strBackViewInfoLinkStr = "";
				}
				return strBackViewInfoLinkStr;
			}
			set
			{
				string strBackViewInfoLinkStr = value;
				Session.Add("BackViewInfoLinkStr", strBackViewInfoLinkStr);
			}
		}
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
		
		/// <summary>
		/// �����еĲ�ѯ�ؼ�������ϳ�һ��������
		/// </summary>
		/// <returns>������(strWhereCond)</returns>
		private string CombineViewRegionCondition()
		{
			//ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
			//���� 1=1 && UserName = '����'
			string strWhereCond=" 1=1 and ViewId = '" + ViewId + "'";
			//����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
			return strWhereCond;
		}
		///���ɰ�DATAGRID�Ĵ���
		/// <summary>
		/// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
		///			 ����ʾ��DATAGRID�С�
		/// </summary>
		private void BindDg_ViewRegion()
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
			string strWhereCond = CombineViewRegionCondition();
			//	2��������������ȡ�ñ�����������DataTable��
			System.Data.DataTable objDT = clsvViewRegionBL.GetDataTable(strWhereCond);
			//	3�����DATAGRID�ĵ�ǰҳ���Ƿ񳬳�DATAGRID��ҳ����Χ
			//		3.1 ���ȼ���ҳ����
			//		3.2 �����ǰҳ����ҳ����Ϊ���һҳ
			int intPages = CalcPages(objDT.Rows.Count, this.dgViewRegion.PageSize);
			if (intPages==0) 
			{
				this.dgViewRegion.CurrentPageIndex = 0;
			}
			else if (this.dgViewRegion.CurrentPageIndex > intPages - 1) 
			{
				this.dgViewRegion.CurrentPageIndex = intPages - 1;
			}
			//	4������DATAGRID������Դ(DataSource)��
			DataView objDV = objDT.DefaultView;
			objDV.Sort = strSortViewRegionBy;     ///ע����һ�д����п�����Ҫע�͵���Ŀǰ���н����ڵ����Ĳ�ѯ������������
			this.dgViewRegion.DataSource=objDV;
			//	5����DATAGRID������DataTable��������ʾ��DATAGRID��
			this.dgViewRegion.DataBind();

			
			//��ǰ��¼��
			this.lblViewRegionRecCount.Text = objDT.Rows.Count.ToString(); 
			//��ǰҳ��
			this.lblViewRegionAllPages.Text = this.dgViewRegion.PageCount.ToString(); 
			//��ǰҳ����
			this.lblViewRegionCurrentPage.Text=(this.dgViewRegion.CurrentPageIndex+1).ToString();
			//��ǰ����������ҳ����
			this.txtViewRegionJump2Page.Text=(this.dgViewRegion.CurrentPageIndex+1).ToString();
			//�����ǰҳ����Ϊ0����<ǰһҳ>��ť��Ч
			if(this.dgViewRegion.CurrentPageIndex==0) 
			{
				btnViewRegionPrevPage.Enabled=false; 
			}
			else 
			{ 
				btnViewRegionPrevPage.Enabled=true; 
			} 
			//�����ǰҳ������Ϊ���һҳ����<ǰһҳ>��ť��Ч
			if(this.dgViewRegion.CurrentPageIndex==this.dgViewRegion.PageCount-1) 
			{ 
				btnViewRegionNextPage.Enabled=false; 
			} 
			else 
			{ 
				btnViewRegionNextPage.Enabled=true; 
			} 
			//7�������沿����ʾ����ʾ �������ǰDataGrid�еļ�¼��Ϊ0������ʾ��ǰ����ҳ������
			if(objDT.Rows.Count>0) 
			{ 
				this.tabViewRegionJumpPage.Visible = true; 
			} 
			else 
			{ 
				this.tabViewRegionJumpPage.Visible = false; 
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
			this.dgViewRegion.CurrentPageIndex=0;
			//�ѱ��¼��������ʾ��DATAGRID��
			BindDg_ViewRegion();
			DispViewRegionListRegion();
            HideAllRegion();
		}
		/// <summary>
		/// �������ܣ��¼��������ڸ���DATAGRID�ĵ�ǰҳ����ʱ�����ĺ�����
		///			  ���幦����������ʾ��ҳ(������ҳ����)�����ݡ�
		/// </summary>
		/// <param name="source"></param>
		/// <param name="e"></param>
		protected void dgViewRegion_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			//�������裺����2����
			//1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
			//2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ

			//1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
			this.dgViewRegion.CurrentPageIndex=e.NewPageIndex;
			//2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ
			BindDg_ViewRegion();
		}
		/// <summary>
		/// �������ܣ����Ըùؼ��ֵļ�¼������ʾ�ڽ����ϣ�
		///������     �������ǰ�ֵ������ؼ���
		/// </summary>
		/// <param name="lngRegionId">���¼�Ĺؼ��֣���ʾ�ñ�ؼ��ֵ�����</param>
		private void ShowData(string lngRegionId)
		{
			//�������裺
			//1�����ؼ����Ƿ�Ϊ�գ�
			//2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
			//3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
			//4����ȡ�������������ԣ�
			//5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���

			//1�����ؼ����Ƿ�Ϊ�գ�
			if (string.IsNullOrEmpty( lngRegionId )== true) return ;		//����ؼ���Ϊ�վͷ����˳�
			//2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
			if (clsViewRegionBL.IsExist(lngRegionId) == false)		//���ùؼ��ֵļ�¼�Ƿ����
			{
				string ss = "�ؼ���Ϊ��" + lngRegionId + "�Ĳ�����!";
				clsCommonJsFunc.Alert(this, ss);
				return ;
			}
			//3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
			clsViewRegionEN objViewRegionEN = new clsViewRegionEN(lngRegionId);
			//4����ȡ�������������ԣ�
            clsViewRegionBL.GetViewRegion(ref objViewRegionEN);
			Session.Add("objViewRegionEN", objViewRegionEN);
			//5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���
			GetDataFromViewRegionClass(objViewRegionEN);
			if (objViewRegionEN.RegionTypeId == "0001")//�������ͣ���ѯ����
			{
				//clsQueryRegionEN objQryRegion =  clsQueryRegionBL.GetObjByRegionId_Cache(lngRegionId, clsPubVar.CurrSelPrjId);
				//Session.Add("objQryRegion", objQryRegion);
				//5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���
				wucViewRegion1.ColNum = objViewRegionEN.ColNum;
				//wucViewRegion1.IsUseCtrl = objQryRegion.IsUseCtrl;
			}
			else if (objViewRegionEN.RegionTypeId == "0003")//�������ͣ��༭����
			{
				//clsEditRegionEN objEditRegion = clsEditRegionBL.GetObjByRegionId_Cache(lngRegionId, clsPubVar.CurrSelPrjId);
				//Session.Add("objEditRegion", objEditRegion);
				//5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���
				wucViewRegion1.ColNum = objViewRegionEN.ColNum;
				//wucViewRegion1.IsUseCtrl = objEditRegion.IsUseCtrl;
			}
		}
		///���ɴ��߼�������ݴ��䵽�����ĺ�������
		/// <summary>
		/// �������ܣ�������������������ʾ��������
		///ע�⣺��������������򣬲�����һ��������������ϵ�ģ�����Ϊһ��������ֵ��Ȼ����Ϊ����������ֵ
		///      ������������ݿ�ʱ����Ӧ��һ���ֶ���ǰ�������ֶ��ں�
		/// </summary>
		/// <param name="pobjViewRegion">��ʵ�������</param>
		private void GetDataFromViewRegionClass(clsViewRegionEN pobjViewRegion)
		{
			wucViewRegion1.RegionName = pobjViewRegion.RegionName;
			//wucViewRegion1.ViewId = pobjViewRegion.ViewId;
			wucViewRegion1.RegionTypeId = pobjViewRegion.RegionTypeId;
			wucViewRegion1.RegionFunction = pobjViewRegion.RegionFunction;
		
			wucViewRegion1.INOUTTypeId = pobjViewRegion.INOUTTypeId;
			wucViewRegion1.TabId = pobjViewRegion.TabId;
			wucViewRegion1.Height = pobjViewRegion.Height;
			wucViewRegion1.Width = pobjViewRegion.Width;
			wucViewRegion1.Memo = pobjViewRegion.Memo;
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
			clsViewRegionEN objViewRegionEN;
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
					if (!wucViewRegion1.IsValid(ref strResult))
					{
						lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
						return ;
					}
					//2��������󲢳�ʼ������
					//clsViewRegionEN objViewRegionEN;	//�������
					objViewRegionEN = new clsViewRegionEN();	//��ʼ���¶���
					//3���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
					//4����ֵ�ӽ���㴫���߼��������ʵ���
					PutDataToViewRegionClass(objViewRegionEN);      //�ѽ����ֵ����

                    var strCondition = new clsViewRegionEN()
                        .SetApplicationTypeId(objViewRegionEN.ApplicationTypeId, "=")
                        .SetPrjId(objViewRegionEN.PrjId, "=")
                        .SetRegionName(objViewRegionEN.RegionName, "=")
                        .GetCombineCondition();

                    if (clsViewRegionBL.IsExistRecord(strCondition) == true)
					{
						strMsg = "�ý�������ͬ�����������Ѿ����ڣ����ܲ����ظ���¼!";
						clsCommonJsFunc.Alert(this, strMsg);
						lblMsg.Text = strMsg;
						return ;
					}
					//5����鴫��ȥ�Ķ��������Ƿ�Ϸ�
                    try
                    {
                         clsViewRegionBL.CheckPropertyNew(objViewRegionEN);
                    }
                    catch(Exception objException) 
					{
                        clsCommonJsFunc.Alert(this, objException.Message);
						return ; 
					}
					//6��������ʵ�������ݴ��������ݿ���
					if (clsViewRegionBL.AddNewRecordBySql2(objViewRegionEN) == false) 
					{
						strMsg = "��Ӳ��ɹ�!";
						clsCommonJsFunc.Alert(this, strMsg);
						lblMsg.Text = "��Ӽ�¼���ɹ�!";
					}
					else
					{
						objViewRegionEN.RegionId = clsViewRegionBL.GetFirstID_S(strCondition);
						//�洢�������ľ������
						if (objViewRegionEN.RegionTypeId == "0001")//�������ͣ���ѯ����
						{
							//SaveQryRegionData("AddNewRecord", objViewRegionEN);
						}
						else if (objViewRegionEN.RegionTypeId == "0003")//�������ͣ��༭����
						{
							//SaveEditRegionData("AddNewRecord", objViewRegionEN);
						}
						//						strMsg = "��Ӽ�¼�ɹ�!";
						//						clsCommonJsFunc.Alert(this, strMsg);
						//						lblMsg.Text = "��Ӽ�¼�ɹ�!";
					}
					//7��������ļ�¼������ʾ��DATAGRID��
					BindDg_ViewRegion();
					wucViewRegion1.Clear();		//��տؼ�������
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
					if (!wucViewRegion1.IsValid(ref strResult))
					{
						lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
						return ;
					}
					//2����ֵ�ӽ���㴫���߼��������ʵ���
					objViewRegionEN = (clsViewRegionEN) Session["objViewRegionEN"];
					PutDataToViewRegionClass(objViewRegionEN);		//�ѽ����ֵ����
					//3����鴫��ȥ�Ķ��������Ƿ�Ϸ�
                    try
                    {
                         clsViewRegionBL.CheckPropertyNew(objViewRegionEN);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
					//4��������ʵ���������޸�ͬ�������ݿ���
					if (clsViewRegionBL.UpdateBySql2(objViewRegionEN) == false) 
					{
						strMsg = "�޸ļ�¼���ɹ�!";
						clsCommonJsFunc.Alert(this, strMsg);
						lblMsg.Text = "�޸ļ�¼���ɹ�!";
					}
					else
					{
						//�洢�������ľ������
						//if (objViewRegionEN.RegionTypeId == "0001")//�������ͣ���ѯ����
						//{
						//	if ( clsQueryRegionBL.IsExistRecord("RegionId = '" + objViewRegionEN.RegionId + "'")==true)
						//	{
						//		//SaveQryRegionData("Update", objViewRegionEN);
						//	}
						//	else
						//	{
						//		//SaveQryRegionData("AddNewRecord", objViewRegionEN);
						//	}
						//}
						//else if (objViewRegionEN.RegionTypeId == "0003")//�������ͣ��༭����
						//{
						//	if ( clsEditRegionBL.IsExistRecord("RegionId = '" + objViewRegionEN.RegionId + "'")==true)
						//	{
						//		//SaveEditRegionData("Update", objViewRegionEN);
						//	}
						//	else
						//	{
						//		//SaveEditRegionData("AddNewRecord", objViewRegionEN);
						//	}
						//}
						//						strMsg = "�޸ļ�¼�ɹ�!";
						//						clsCommonJsFunc.Alert(this, strMsg);
						//						lblMsg.Text = "�޸ļ�¼�ɹ�!";
					}
					//5�����޸ĺ��������ʾ��DATAGRID��
					BindDg_ViewRegion();
					wucViewRegion1.Clear();//��տؼ��е�����
					//�ָ�<ȷ���޸�>���<���>
					btnOKUpd.Text = "���";
                    HideAllRegion();	
					DispViewRegionListRegion();
					break;
				case "��������ȷ���޸�":

					UpdateRegionRecordSave(RegionId);
					
					break;
			}
		}
		//private bool SaveQryRegionData(string strOpType, clsViewRegionEN objViewRegionEN)
		//{
		//	string strMsg;

		//	//if (strOpType == "AddNewRecord")
		//	//{
		//	//	clsQueryRegionEN objQryRegion = new clsQueryRegionEN(objViewRegionEN.RegionId);
		//	//	//objQryRegion.ColNum = wucViewRegion1.ColNum;
		//	//	objQryRegion.IsUseCtrl = wucViewRegion1.IsUseCtrl;
  // //             try
  // //             {
  // //                  clsQueryRegionBL .CheckPropertyNew(objQryRegion);
  // //             }
  // //             catch (Exception objException)
  // //             {
  // //                 clsCommonJsFunc.Alert(this, objException.Message);
  // //                 return false;
  // //             }
		//	//	//6��������ʵ�������ݴ��������ݿ���
		//	//	if (clsQueryRegionBL .AddNewRecordBySql2(objQryRegion) == false) 
		//	//	{
		//	//		strMsg = "��Ӳ��ɹ�!";
		//	//		clsCommonJsFunc.Alert(this, strMsg);
		//	//		lblMsg.Text = "��Ӽ�¼���ɹ�!";
		//	//		return false; 
		//	//	}
		//	//	else
		//	//	{
		//	//		strMsg = "��Ӽ�¼�ɹ�!";
		//	//		clsCommonJsFunc.Alert(this, strMsg);
		//	//		lblMsg.Text = "��Ӽ�¼�ɹ�!";
		//	//		return true; 
		//	//	}
		//	//}
		//	//else
		//	//{
		//	//	//2����ֵ�ӽ���㴫���߼��������ʵ���
		//	//	clsQueryRegionEN objQryRegion = (clsQueryRegionEN) Session["objQryRegion"];
		//	//	//objQryRegion.ColNum = wucViewRegion1.ColNum;
		//	//	objQryRegion.IsUseCtrl = wucViewRegion1.IsUseCtrl;
		//	//	//3����鴫��ȥ�Ķ��������Ƿ�Ϸ�
  // //             try
  // //             {
  // //                  clsQueryRegionBL .CheckPropertyNew(objQryRegion);
  // //             }
  // //             catch (Exception objException)
  // //             {
  // //                 clsCommonJsFunc.Alert(this, objException.Message);
  // //                 return false;
  // //             }
  // //             //4��������ʵ���������޸�ͬ�������ݿ���
		//	//	if (clsQueryRegionBL.UpdateBySql2(objQryRegion) == false) 
		//	//	{
		//	//		strMsg = "�޸ļ�¼���ɹ�!";
		//	//		clsCommonJsFunc.Alert(this, strMsg);
		//	//		lblMsg.Text = "�޸ļ�¼���ɹ�!";
		//	//		return false;
		//	//	}
		//	//	else
		//	//	{
		//	//		strMsg = "�޸ļ�¼�ɹ�!";
		//	//		clsCommonJsFunc.Alert(this, strMsg);
		//	//		lblMsg.Text = "�޸ļ�¼�ɹ�!";
		//	//		return true; 
		//	//	}

		//	//}
		//}
		/// <summary>
		/// ����༭������������
		/// </summary>
		/// <param name="strOpType"></param>
		/// <param name="objViewRegionEN"></param>
		/// <returns></returns>
		//private bool SaveEditRegionData(string strOpType, clsViewRegionEN objViewRegionEN)
		//{
		//	string strMsg;

		//	//if (strOpType == "AddNewRecord")
		//	//{
		//	//	clsEditRegionEN objEditRegion = new clsEditRegionEN(objViewRegionEN.RegionId);
		//	//	//objEditRegion.ColNum = wucViewRegion1.ColNum;
		//	//	objEditRegion.IsUseCtrl = wucViewRegion1.IsUseCtrl;

  // //             try
  // //             {
  // //                 clsEditRegionBL .CheckPropertyNew(objEditRegion);
  // //             }
  // //             catch (Exception objException)
  // //             {
  // //                 clsCommonJsFunc.Alert(this, objException.Message);
  // //                 return false;
  // //             }

		//	//	//6��������ʵ�������ݴ��������ݿ���
		//	//	if (clsEditRegionBL .AddNewRecordBySql2(objEditRegion) == false) 
		//	//	{
		//	//		strMsg = "��Ӳ��ɹ�!";
		//	//		clsCommonJsFunc.Alert(this, strMsg);
		//	//		lblMsg.Text = "��Ӽ�¼���ɹ�!";
		//	//		return false; 
		//	//	}
		//	//	else
		//	//	{
		//	//		strMsg = "��Ӽ�¼�ɹ�!";
		//	//		clsCommonJsFunc.Alert(this, strMsg);
		//	//		lblMsg.Text = "��Ӽ�¼�ɹ�!";
		//	//		return true; 
		//	//	}
		//	//}
		//	//else
		//	//{
		//	//	//2����ֵ�ӽ���㴫���߼��������ʵ���
		//	//	clsEditRegionEN objEditRegion = (clsEditRegionEN) Session["objEditRegion"];
		//	//	//objEditRegion.ColNum = wucViewRegion1.ColNum;
		//	//	objEditRegion.IsUseCtrl = wucViewRegion1.IsUseCtrl;
		//	//	//3����鴫��ȥ�Ķ��������Ƿ�Ϸ�
  // //             try
  // //             {
  // //                  clsEditRegionBL .CheckPropertyNew(objEditRegion);
  // //             }
  // //             catch (Exception objException)
  // //             {
  // //                 clsCommonJsFunc.Alert(this, objException.Message);
  // //                 return false;
  // //             }
		//	//	//4��������ʵ���������޸�ͬ�������ݿ���
		//	//	if (clsEditRegionBL.UpdateBySql2(objEditRegion) == false) 
		//	//	{
		//	//		strMsg = "�޸ļ�¼���ɹ�!";
		//	//		clsCommonJsFunc.Alert(this, strMsg);
		//	//		lblMsg.Text = "�޸ļ�¼���ɹ�!";
		//	//		return false;
		//	//	}
		//	//	else
		//	//	{
		//	//		strMsg = "�޸ļ�¼�ɹ�!";
		//	//		clsCommonJsFunc.Alert(this, strMsg);
		//	//		lblMsg.Text = "�޸ļ�¼�ɹ�!";
		//	//		return true; 
		//	//	}

		//	//}
		//}

		
		/// <summary>
		/// �������ܣ��ѽ����ϵ��������ݴ����������
		/// </summary>
		/// <param name="pobjViewRegion">���ݴ����Ŀ�������</param>
		private void PutDataToViewRegionClass(clsViewRegionEN pobjViewRegion)
		{
			pobjViewRegion.RegionName = wucViewRegion1.RegionName;
			pobjViewRegion.PrjId = clsPubVar.CurrSelPrjId;
			pobjViewRegion.RegionTypeId = wucViewRegion1.RegionTypeId;
			pobjViewRegion.RegionFunction = wucViewRegion1.RegionFunction;

			pobjViewRegion.INOUTTypeId = wucViewRegion1.INOUTTypeId;
			pobjViewRegion.TabId = wucViewRegion1.TabId;
			pobjViewRegion.Height = wucViewRegion1.Height;
			pobjViewRegion.Width = wucViewRegion1.Width;
            pobjViewRegion.ColNum = wucViewRegion1.ColNum;
			pobjViewRegion.Memo = wucViewRegion1.Memo;
		}

		protected void dgViewRegion_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
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
			if (strSortViewRegionBy == "") return ;
			if(e.Item.ItemType==ListItemType.Header)//����ؼ��Ƿ�Ϊҳü��
			{
				string strSortEx;
				for(int i=0;i<this.dgViewRegion.Columns.Count;i++)
				{
					strSortEx = this.dgViewRegion.Columns[i].SortExpression;
					if (strSortEx == "") continue;
					intIndex = strSortViewRegionBy.IndexOf(strSortEx + " ");
					if(intIndex >=0)  //��ͼ״̬��������ʽ�Ƿ�Ϊ���е��ֶΣ�
					{
						Label lblSort=new Label();
						lblSort.Font.Name="webdings";//�������壬��"webdings"��5�������ǣ�6�������ǣ�
						intIndex = strSortViewRegionBy.IndexOf("Asc");
						lblSort.Text=(intIndex>0?" 5":" 6");//�Ƿ�Ϊ���򣬶���Ϊstring�ͣ�
						e.Item.Cells[i].Controls.Add(lblSort);//��������ĵ�i����Ԫ��������һ�ؼ���
						break;
					}
				}
			}
		}

		protected void dgViewRegion_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			string lngRegionId;
			string strCommandName;
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.SelectedItem ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
				strCommandName = ((LinkButton)e.CommandSource).CommandName;
				lngRegionId = e.Item.Cells[1].Text;
				RegionId = lngRegionId;
				switch(strCommandName)
				{
					case "Delete":
						clsViewRegionBL.DelRecord(lngRegionId);
						BindDg_ViewRegion();
						break;
						// Add other cases here, if there are multiple ButtonColumns in 
						// the DataGrid control.
					case "Update":
						//�������裺���ܹ�2����
						//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
						//2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�

						//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
						ShowData(lngRegionId);
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
					Set_DataGridAllChecked(dgViewRegion, true);
					lbSelAll.Text = "��ѡ";
				}
				else if (lbSelAll.Text == "��ѡ")
				{
					Set_DataGridAllChecked(dgViewRegion, false);
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
			wucViewRegion1.ViewId = ViewId;
			lblErrMsg.Text = "";
			HideViewRegionListRegion();
            HideAllRegion();
			tabEditViewRegionRegion.Visible = true;
			tabViewRegion.Visible = true;
		}

		
		//��ǰ��¼��
		protected void btnExportExcel4Dg_Click(object sender, System.EventArgs e)
		{
			//	1����Ͻ�����������
			string strWhereCond = CombineViewRegionCondition();
			//	2��������������ȡ�ñ�����������DataTable��
			System.Data.DataTable objDT = clsViewRegionBL.GetDataTable_ViewRegion(strWhereCond);
			List<string> arrCnName = new List<string>();
			List<string> arrColName = new List<string>();
			string strFileName = "ViewRegion��Ϣ����.xls";
			string strFolderName;
			string strDownLoadFileName;
			arrColName.Add("RegionId"); arrCnName.Add("����Id");
			arrColName.Add("RegionName"); arrCnName.Add("��������");
			arrColName.Add("ViewId"); arrCnName.Add("����ID");
			arrColName.Add("RegionTypeId"); arrCnName.Add("��������Id");
			arrColName.Add("RegionFunction"); arrCnName.Add("������");
			arrColName.Add("SQLDSTypeId"); arrCnName.Add("����Դ����");
			arrColName.Add("RelaTabId"); arrCnName.Add("��ر�ID");
			arrColName.Add("Height"); arrCnName.Add("�߶�");
			arrColName.Add("Width"); arrCnName.Add("��");
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
            List<string> arrRegionId = clsCommForWebForm. GetAllCheckedItemFromDg2(dgViewRegion, "chkCheckRec");
			if (arrRegionId == null || arrRegionId.Count == 0) 
			{
				lblErrMsg.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
				return ;
			}
			lblErrMsg.Text = "";
			//			string lngRegionId;
			//			lngRegionId = long.Parse(strRegionId);
			//			clsViewRegionBL.DelViewRegion(arrRegionId);
			clsViewRegionBLEx.DelViewRegionsEx(arrRegionId);
			BindDg_ViewRegion();
		}

		
		//��ǰ��¼��
		protected void btnUpdate4Dg_Click(object sender, System.EventArgs e)
		{
			string strRegionId =clsCommForWebForm.GetFirstCheckedItemFromDg(dgViewRegion);
			if (strRegionId == null || strRegionId.Trim().Length == 0) 
			{
				lblErrMsg.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
				return ;
			}
			lblErrMsg.Text = "";
			//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
			string lngRegionId;
			lngRegionId = strRegionId;

			ShowData(lngRegionId);
			//2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
			clsPubFun.SetButtonEnabled(btnOKUpd, true);
			btnOKUpd.Text = "ȷ���޸�";	
			HideViewRegionListRegion();
			tabEditViewRegionRegion.Visible = true;
			tabViewRegion.Visible = true;
		}
		
		protected void dgViewRegion_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
		{
			int intIndex;
			//�ж��Ƿ����µ������ֶ�
			intIndex = strSortViewRegionBy.IndexOf(e.SortExpression);
			if (intIndex == -1)
			{
				strSortViewRegionBy = e.SortExpression + " Asc";
				BindDg_ViewRegion();
				return ;
			}
			//���ԭ��������
			intIndex = strSortViewRegionBy.IndexOf(" Asc");
			if (intIndex == -1)		//���ԭ���������������Ϊ����
			{
				strSortViewRegionBy = e.SortExpression + " Asc";
			}
			else			///��������Ϊ����
			{
				strSortViewRegionBy = e.SortExpression + " Desc";
			}
			BindDg_ViewRegion();
		}

		private string strSortViewRegionBy
		{
			get
			{
				string sSortViewRegionBy;
				sSortViewRegionBy = (string)ViewState["SortViewRegionBy"];
				if (sSortViewRegionBy==null) 
				{
					sSortViewRegionBy = "";
				}
				return sSortViewRegionBy;
			}
			set
			{
				string sSortViewRegionBy = value;
				ViewState.Add("SortViewRegionBy", sSortViewRegionBy);
			}
		}

		//���ɸ������SESSION������Ժ���
		protected void btnViewRegionPrevPage_Click(object sender, System.EventArgs e)
		{
			this.dgViewRegion.CurrentPageIndex -=1; 
			this.BindDg_ViewRegion(); 
		}

		protected void btnViewRegionNextPage_Click(object sender, System.EventArgs e)
		{
			this.dgViewRegion.CurrentPageIndex +=1; 
			this.BindDg_ViewRegion(); 
		}

		protected void btnViewRegionJumpPage_Click(object sender, System.EventArgs e)
		{
			if(this.txtViewRegionJump2Page.Text.Trim()!="" && 
				int.Parse(this.txtViewRegionJump2Page.Text)>0 && 
				int.Parse(this.txtViewRegionJump2Page.Text)-1<this.dgViewRegion.PageCount) 
			{ 
				this.dgViewRegion.CurrentPageIndex=int.Parse(this.txtViewRegionJump2Page.Text)-1; 
			} 
			this.BindDg_ViewRegion();
		}

		protected void ddlSQLDSTypeId_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		}
		//�༭�����ֶ�
		protected void btnEditRegionFld_Click(object sender, System.EventArgs e)
		{
			string strRegionId =clsCommForWebForm.GetFirstCheckedItemFromDg(dgViewRegion);
			if (strRegionId == null || strRegionId.Trim().Length == 0) 
			{
				lblErrMsg.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
				return ;
			}
			lblErrMsg.Text = "";
			//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
			string lngRegionId;
			lngRegionId = strRegionId;

			BackViewRegionLinkStr = "../View/wfmViewRegion_QUDI.aspx";
			RegionId = lngRegionId;
			string strRegionTypeId = clsViewRegionBL.GetObjByRegionId_Cache(lngRegionId, clsPubVar.CurrSelPrjId).RegionTypeId;
			if (strRegionTypeId == "0001")		//��ѯ����
			{
				Response.Redirect("../View/wfmQryRegionFlds_QUDI.aspx");
			}
			else if (strRegionTypeId == "0002")	//�б�����
			{
				Response.Redirect("../View/wfmDGRegionFlds_QUDI.aspx");
			}
			else if (strRegionTypeId == "0003")		//�༭����
			{
				Response.Redirect("../View/wfmEditRegionFlds_QUDI.aspx");
			}
			else if (strRegionTypeId == "0004")		//ListView����
			{
				Response.Redirect("../View/wfmListViewRegionFlds_QUDI.aspx");
			}
			else if (strRegionTypeId == "0005")		//��������
			{
				Response.Redirect("../View/wfmEditRegionFlds_QUDI.aspx");
			}
			else if (strRegionTypeId == clsRegionTypeENEx.EXCELEXPORT_REGION)		//��������
			{
				Response.Redirect("../View/wfmExcelExportRegionFlds_QUDI.aspx");
			}
			else if (strRegionTypeId == clsRegionTypeENEx.DETAILREGION)		//��������
			{
				Response.Redirect("../View/wfmDetailRegionFlds_QUDI.aspx");
			}

		}

		protected void chkQueryRegion_CheckedChanged(object sender, System.EventArgs e)
		{
            if (chkQueryRegion.Checked == true)
            {
                txtFileName_QueryRegion.Text = "��ѯ����";
            }
            else
            {
                txtFileName_QueryRegion.Text = "";
            }
		}

		protected void chkDGRegion_CheckedChanged(object sender, System.EventArgs e)
		{
            if (chkDGRegion.Checked == true)
            {
                txtFileName_DGRegion.Text = "�б�����";
            }
            else
            {
                txtFileName_DGRegion.Text = "";
            }
		}

		//protected void chkListViewRegion_CheckedChanged(object sender, System.EventArgs e)
		//{
  //          if (chkListViewRegion.Checked == true)
  //          {
  //              txtFileName_ListViewRegion.Text = "ListView����";
  //          }
  //          else
  //          {
  //              txtFileName_ListViewRegion.Text = "";
  //          }
		//}

		protected void chkEditRegion_CheckedChanged(object sender, System.EventArgs e)
		{
            if (chkEditRegion.Checked == true)
            {
                txtFileName_EditRegion.Text = "�༭����";
            }
            else
            {
                txtFileName_EditRegion.Text = "";
            }
		}

		protected void chkDetailRegion_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chkDetailRegion.Checked == true)
			{
				txtFileName_DetailRegion.Text = "��ϸ��Ϣ����";
			}
		}

		protected void chkTreeViewRegion_CheckedChanged(object sender, System.EventArgs e)
		{
            if (chkTreeViewRegion.Checked == true)
            {
                txtFileName_TreeViewRegion.Text = "������";
            }
            else
            {
                txtFileName_TreeViewRegion.Text = "";
            }
		}

		protected void btnStartGene_Click(object sender, System.EventArgs e)
		{
			StringBuilder sbWhereCond = new StringBuilder();
			//���ѡ���ѯ����
			try
			{
				if (chkQueryRegion.Checked == true && txtFileName_QueryRegion.Text.Trim() != "")
				{
					///������������ֶΣ��ú�����ViewInfo����غ�����
					///������������1����ͼID(ViewId)
					///				2����������()
					///				3������Դ����ID
					///				4������Դ��ID()
					///		
					clsViewInfoBLEx.ImportRegionAndFlds1(ViewId, //��ͼID(ViewId)
						clsRegionTypeENEx.QUERYREGION,				//��������
                        clsCommonSession.UserId,
                                                txtFileName_QueryRegion.Text.Trim()								//��������

                        );
				}
				//���ѡ���б�����
				if (chkDGRegion.Checked == true && txtFileName_DGRegion.Text.Trim() != "")
				{
					clsViewInfoBLEx.ImportRegionAndFlds1(ViewId, //��ͼID(ViewId)
						clsRegionTypeENEx.DGREGION,				//��������
                        clsCommonSession.UserId,
                                                txtFileName_DGRegion.Text.Trim()							//��������
                        );
				}
				////���ѡ��ListView����
				//if (chkListViewRegion.Checked == true && txtFileName_ListViewRegion.Text.Trim() != "")
				//{
				//	clsViewInfoBLEx.ImportRegionAndFlds(ViewId, //��ͼID(ViewId)
				//		clsRegionTypeENEx.LISTVIEWREGION,				//��������
				//		txtFileName_ListViewRegion.Text.Trim()								//��������
				//		);
				//}
				//���ѡ��༭����
				if (chkEditRegion.Checked == true && txtFileName_EditRegion.Text.Trim() != "")
				{
					clsViewInfoBLEx.ImportRegionAndFlds1(ViewId, //��ͼID(ViewId)
						clsRegionTypeENEx.EDITREGION,				//��������

                        clsCommonSession.UserId,
                                                txtFileName_EditRegion.Text.Trim()								//��������
                        );
				}
				//���ѡ��Excel��������
				if (chkExcelExportRegion.Checked == true && txtFileName_ExcelExportRegion.Text.Trim() != "")
				{
					clsViewInfoBLEx.ImportRegionAndFlds1(ViewId, //��ͼID(ViewId)
						clsRegionTypeENEx.EXCELEXPORT_REGION,				//��������

                        clsCommonSession.UserId,
                                                txtFileName_ExcelExportRegion.Text.Trim()								//��������
                        );
				}
				//���ѡ����ϸ��Ϣ����
				if (chkDetailRegion.Checked == true && txtFileName_DetailRegion.Text.Trim() != "")
				{
					clsViewInfoBLEx.ImportRegionAndFlds1(ViewId, //��ͼID(ViewId)
						clsRegionTypeENEx.DETAILREGION,				//��������
                        clsCommonSession.UserId,
                                                txtFileName_DetailRegion.Text.Trim()		//��������
                        );
				}
			}
			catch(Exception objException)
			{
				clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
				clsPubFun4Web.AccessError(this, conCurrPageName);
			}
			BindDg_ViewRegion();
			divViewRelaRegion.Visible = false;
		}

		protected void btnCloseDiv_Click(object sender, System.EventArgs e)
		{
			divViewRelaRegion.Visible = false;
		}

		protected void btnAddRelaJspView_Click(object sender, System.EventArgs e)
		{
			divViewRelaRegion.Visible = true;
		}

		protected void btnGoBack_Click(object sender, System.EventArgs e)
		{
			Response.Redirect(BackViewInfoLinkStr);
		}

		protected void chkExcelExportRegion_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chkExcelExportRegion.Checked == true)
			{
				txtFileName_ExcelExportRegion.Text = "Excel��������";
			}
		}

		protected void btnUpdSpecialProperty_Click(object sender, System.EventArgs e)
		{
			string strRegionId =clsCommForWebForm.GetFirstCheckedItemFromDg(dgViewRegion);
			if (strRegionId == null || strRegionId.Trim().Length == 0) 
			{
				lblErrMsg.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
				return ;
			}
			lblErrMsg.Text = "";
			//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
			string lngRegionId;
			lngRegionId = strRegionId;
			ShowSpecialData(lngRegionId);
			//2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
			clsPubFun.SetButtonEnabled(btnOKUpd, true);
			btnOKUpd.Text = "��������ȷ���޸�";	
			HideViewRegionListRegion();
		}
		private void HideAllRegion()
		{
			tabDGRegion.Visible = false;
			tabEditRegion.Visible = false;
			tabViewRegion.Visible = false;
			tabListViewRegion.Visible = false;
			tabQryRegion.Visible = false;
			tabEditViewRegionRegion.Visible = false;
		}
		/// <summary>
		/// �������ܣ����Ըùؼ��ֵļ�¼������ʾ�ڽ����ϣ�
		///������     �������ǰ�ֵ������ؼ���
		/// </summary>
		/// <param name="lngRegionId">���¼�Ĺؼ��֣���ʾ�ñ�ؼ��ֵ�����</param>
		private void ShowSpecialData(string lngRegionId)
		{
            //�������裺
            //1�����ؼ����Ƿ�Ϊ�գ�
            //2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
            //3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
            //4����ȡ�������������ԣ�
            //5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���

            HideAllRegion();
			tabEditViewRegionRegion.Visible = true;
			//1�����ؼ����Ƿ�Ϊ�գ�
			if (string.IsNullOrEmpty( lngRegionId )== true) return ;		//����ؼ���Ϊ�վͷ����˳�
			RegionId = lngRegionId;
			clsViewRegionEN objViewRegionEN = clsViewRegionBL.GetObjByRegionId_Cache(lngRegionId, clsPubVar.CurrSelPrjId);
			switch(objViewRegionEN.RegionTypeId)
			{
				case clsRegionTypeENEx.EDITREGION:	//�༭����
					tabEditRegion.Visible = true;
					//2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
					//if (clsEditRegionBL.IsExist(lngRegionId) == false)		//���ùؼ��ֵļ�¼�Ƿ����
					//{
					//	string ss = "�ؼ���Ϊ��" + lngRegionId + "�Ĳ�����!";
					//	clsCommonJsFunc.Alert(this, ss);
					//	return ;
					//}
					////3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
					//clsEditRegionEN objEditRegion = new clsEditRegionEN(lngRegionId);
     //               //4����ȡ�������������ԣ�
     //               clsEditRegionBL .GetEditRegion(ref objEditRegion);
					//Session.Add("objEditRegion", objEditRegion);
					////5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���
					//GetDataFromEditRegionClass(objEditRegion);

					break;
				case clsRegionTypeENEx.QUERYREGION:	//��ѯ����
					tabQryRegion.Visible = true;
					//2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
					//if (clsQueryRegionBL.IsExist(lngRegionId) == false)		//���ùؼ��ֵļ�¼�Ƿ����
					//{
					//	string ss = "�ؼ���Ϊ��" + lngRegionId + "�Ĳ�����!";
					//	clsCommonJsFunc.Alert(this, ss);
					//	return ;
					//}
					////3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
					//clsQueryRegionEN objQryRegion = new clsQueryRegionEN(lngRegionId);
     //               //4����ȡ�������������ԣ�
     //               clsQueryRegionBL .GetQueryRegion(ref objQryRegion);
					//Session.Add("objQryRegion", objQryRegion);
					////5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���
					//GetDataFromQueryRegionClass(objQryRegion);

					break;
				case clsRegionTypeENEx.DGREGION:		//�б�����
					tabDGRegion.Visible = true;
					//2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
					//if (clsDGRegionBL.IsExist(lngRegionId) == false)		//���ùؼ��ֵļ�¼�Ƿ����
					//{
					//	string ss = "�ؼ���Ϊ��" + lngRegionId + "�Ĳ�����!";
					//	clsCommonJsFunc.Alert(this, ss);
					//	return ;
					//}
					////3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
					//clsDGRegionEN objDGRegion = new clsDGRegionEN(lngRegionId);
     //               //4����ȡ�������������ԣ�
     //               clsDGRegionBL .GetDGRegion(ref objDGRegion);
					//Session.Add("objDGRegion", objDGRegion);
					////5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���
					//wucDGRegion1.Clear();
					//GetDataFromDGRegionClass(objDGRegion);
					break;	
				//case clsRegionTypeENEx.LISTVIEWREGION:	//LISTVIEW����
				//	tabListViewRegion.Visible = true;
				//	//2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
				//	if (clsDGRegionBL.IsExist(lngRegionId) == false)		//���ùؼ��ֵļ�¼�Ƿ����
				//	{
				//		string ss = "�ؼ���Ϊ��" + lngRegionId + "�Ĳ�����!";
				//		clsCommonJsFunc.Alert(this, ss);
				//		return ;
				//	}
				//	//3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
				//	clsDGRegionEN objListViewRegionEN = new clsDGRegionEN(lngRegionId);
				//	//4����ȡ�������������ԣ�
				//	clsDGRegionBL.GetListViewRegion(ref objListViewRegionEN);
				//	Session.Add("objListViewRegionEN", objListViewRegionEN);
				//	//5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���
				//	GetDataFromListViewRegionClass(objListViewRegionEN);

				//	break;
				case clsRegionTypeENEx.EXCELEXPORT_REGION:	//EXCEL��������
					//					//2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
					//					if (clsExcelExportRegion.IsExist(lngRegionId) == false)		//���ùؼ��ֵļ�¼�Ƿ����
					//					{
					//						string ss = "�ؼ���Ϊ��" + lngRegionId + "�Ĳ�����!";
					//						clsCommonJsFunc.Alert(this, ss);
					//						return ;
					//					}
					//					//3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
					//					clsExcelExportRegion objExcelExportRegion = new clsExcelExportRegion(lngRegionId);
					//					//4����ȡ�������������ԣ�
					//					objExcelExportRegion.GetListViewRegion();
					//					Session.Add("objExcelExportRegion", objExcelExportRegion);
					//					//5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���
					//					GetDataFromEXListViewRegionClass(objExcelExportRegion);

					break;
				case clsRegionTypeENEx.DETAILREGION:	//��ϸ����
					break;
				case clsRegionTypeENEx.TREEVIEWREGION:	//������
					break;

			}
		}
		/// <summary>
		/// �������ܣ��ѽ����ϵ��������ݴ����������
		/// </summary>
		/// <param name="pobjEditRegion">���ݴ����Ŀ�������</param>
		private void PutDataToEditRegionClass(clsEditRegionEN pobjEditRegion)
		{
			//pobjEditRegion.ColNum = wucEditRegion1.ColNum;
			pobjEditRegion.IsUseCtrl = wucEditRegion1.IsUseCtrl;
		}
		///���ɴ��߼�������ݴ��䵽�����ĺ�������
		/// <summary>
		/// �������ܣ�������������������ʾ��������
		///ע�⣺��������������򣬲�����һ��������������ϵ�ģ�����Ϊһ��������ֵ��Ȼ����Ϊ����������ֵ
		///      ������������ݿ�ʱ����Ӧ��һ���ֶ���ǰ�������ֶ��ں�
		/// </summary>
		/// <param name="pobjEditRegion">��ʵ�������</param>
		private void GetDataFromEditRegionClass(clsEditRegionEN pobjEditRegion)
		{
			//wucEditRegion1.ColNum = pobjEditRegion.ColNum;
			wucEditRegion1.IsUseCtrl = pobjEditRegion.IsUseCtrl;
		}
		///���ɴ��߼�������ݴ��䵽�����ĺ�������
		/// <summary>
		/// �������ܣ�������������������ʾ��������
		///ע�⣺��������������򣬲�����һ��������������ϵ�ģ�����Ϊһ��������ֵ��Ȼ����Ϊ����������ֵ
		///      ������������ݿ�ʱ����Ӧ��һ���ֶ���ǰ�������ֶ��ں�
		/// </summary>
		/// <param name="pobjDGRegion">��ʵ�������</param>
		private void GetDataFromDGRegionClass(clsDGRegionEN pobjDGRegion)
		{
			wucDGRegion1.DGStyleId = pobjDGRegion.DGStyleId;
			wucDGRegion1.Runat = pobjDGRegion.Runat;
			wucDGRegion1.FontSize = pobjDGRegion.FontSize;
			wucDGRegion1.FontName = pobjDGRegion.FontName;
			wucDGRegion1.AllowPaging = pobjDGRegion.AllowPaging;
			wucDGRegion1.PageSize = pobjDGRegion.PageSize;
			wucDGRegion1.AutoGenerateColumns = pobjDGRegion.AutoGenerateColumns;
			wucDGRegion1.AllowSorting = pobjDGRegion.AllowSorting;
			wucDGRegion1.IsRadio = pobjDGRegion.IsRadio;
			wucDGRegion1.IsCheck = pobjDGRegion.IsCheck;
			wucDGRegion1.IsJumpPage = pobjDGRegion.IsJumpPage;
			wucDGRegion1.IsHaveUpdBtn = pobjDGRegion.IsHaveUpdBtn;
			wucDGRegion1.IsHaveDelBtn = pobjDGRegion.IsHaveDelBtn;
			wucDGRegion1.IsHaveDetailBtn = pobjDGRegion.IsHaveDetailBtn;
			wucDGRegion1.IsInTab = pobjDGRegion.IsInTab;
			wucDGRegion1.Style_Zindex = pobjDGRegion.Style_Zindex;
			wucDGRegion1.Style_Left = pobjDGRegion.Style_Left;
			wucDGRegion1.Style_Position = pobjDGRegion.Style_Position;
			wucDGRegion1.Style_Top = pobjDGRegion.Style_Top;
			wucDGRegion1.Width = pobjDGRegion.Width;
			wucDGRegion1.Height = pobjDGRegion.Height;
			wucDGRegion1.Style = pobjDGRegion.Style;
			wucDGRegion1.ViewDgName = pobjDGRegion.ViewDgName;
			wucDGRegion1.Memo = pobjDGRegion.Memo;
		}
		
		/// <summary>
		/// �������ܣ��ѽ����ϵ��������ݴ����������
		/// </summary>
		/// <param name="pobjDGRegion">���ݴ����Ŀ�������</param>
		private void PutDataToDGRegionClass(clsDGRegionEN pobjDGRegion)
		{
			pobjDGRegion.DGStyleId = wucDGRegion1.DGStyleId;
			pobjDGRegion.Runat = wucDGRegion1.Runat;
			pobjDGRegion.FontSize = wucDGRegion1.FontSize;
			pobjDGRegion.FontName = wucDGRegion1.FontName;
			pobjDGRegion.AllowPaging = wucDGRegion1.AllowPaging;
			pobjDGRegion.PageSize = wucDGRegion1.PageSize;
			pobjDGRegion.AutoGenerateColumns = wucDGRegion1.AutoGenerateColumns;
			pobjDGRegion.AllowSorting = wucDGRegion1.AllowSorting;
			pobjDGRegion.IsRadio = wucDGRegion1.IsRadio;
			pobjDGRegion.IsCheck = wucDGRegion1.IsCheck;
			pobjDGRegion.IsJumpPage = wucDGRegion1.IsJumpPage;
			pobjDGRegion.IsHaveUpdBtn = wucDGRegion1.IsHaveUpdBtn;
			pobjDGRegion.IsHaveDelBtn = wucDGRegion1.IsHaveDelBtn;
			pobjDGRegion.IsHaveDetailBtn = wucDGRegion1.IsHaveDetailBtn;
			pobjDGRegion.IsInTab = wucDGRegion1.IsInTab;
			pobjDGRegion.Style_Zindex = wucDGRegion1.Style_Zindex;
			pobjDGRegion.Style_Left = wucDGRegion1.Style_Left;
			pobjDGRegion.Style_Position = wucDGRegion1.Style_Position;
			pobjDGRegion.Style_Top = wucDGRegion1.Style_Top;
			pobjDGRegion.Width = wucDGRegion1.Width;
			pobjDGRegion.Height = wucDGRegion1.Height;
			pobjDGRegion.Style = wucDGRegion1.Style;
			pobjDGRegion.ViewDgName = wucDGRegion1.ViewDgName;
			pobjDGRegion.Memo = wucDGRegion1.Memo;
		}
		
		/// <summary>
		/// �������ܣ��ѽ����ϵ��������ݴ����������
		/// </summary>
		/// <param name="pobjListViewRegion">���ݴ����Ŀ�������</param>
		private void PutDataToListViewRegionClass(clsDGRegionEN pobjListViewRegion)
		{
			pobjListViewRegion.FontName = wucListViewRegion1.FontName;
			pobjListViewRegion.FontSize = wucListViewRegion1.FontSize;
			pobjListViewRegion.IsCheck = wucListViewRegion1.IsCheck;
			pobjListViewRegion.Memo = wucListViewRegion1.Memo;
			pobjListViewRegion.ColNum = wucListViewRegion1.ColNum;
		}
		///���ɴ��߼�������ݴ��䵽�����ĺ�������
		/// <summary>
		/// �������ܣ�������������������ʾ��������
		///ע�⣺��������������򣬲�����һ��������������ϵ�ģ�����Ϊһ��������ֵ��Ȼ����Ϊ����������ֵ
		///      ������������ݿ�ʱ����Ӧ��һ���ֶ���ǰ�������ֶ��ں�
		/// </summary>
		/// <param name="pobjListViewRegion">��ʵ�������</param>
		private void GetDataFromListViewRegionClass(clsDGRegionEN pobjListViewRegion)
		{
			wucListViewRegion1.FontName = pobjListViewRegion.FontName;
			wucListViewRegion1.FontSize = pobjListViewRegion.FontSize;
			wucListViewRegion1.IsCheck = pobjListViewRegion.IsCheck;
			wucListViewRegion1.Memo = pobjListViewRegion.Memo;
			wucListViewRegion1.ColNum = pobjListViewRegion.ColNum;
		}
		/// <summary>
		/// �������ܣ�������������������ʾ��������
		///ע�⣺��������������򣬲�����һ��������������ϵ�ģ�����Ϊһ��������ֵ��Ȼ����Ϊ����������ֵ
		///      ������������ݿ�ʱ����Ӧ��һ���ֶ���ǰ�������ֶ��ں�
		/// </summary>
		/// <param name="pobjQueryRegion">��ʵ�������</param>
		private void GetDataFromQueryRegionClass(clsQueryRegionEN pobjQueryRegion)
		{
			//wucQryRegion1.ColNum = pobjQueryRegion.ColNum;
			wucQryRegion1.IsUseCtrl = pobjQueryRegion.IsUseCtrl;
		}
		
		/// <summary>
		/// �������ܣ��ѽ����ϵ��������ݴ����������
		/// </summary>
		/// <param name="pobjQueryRegion">���ݴ����Ŀ�������</param>
		private void PutDataToQueryRegionClass(clsQueryRegionEN pobjQueryRegion)
		{
			//pobjQueryRegion.ColNum = wucQryRegion1.ColNum;
			pobjQueryRegion.IsUseCtrl = wucQryRegion1.IsUseCtrl;
		}

		///�޸Ĵ���׼�����̴��� for C#
		private void UpdateDGRegionRecordSave(clsDGRegionEN objDGRegion)
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
			if (!wucDGRegion1.IsValid(ref strResult))
			{
				lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
				return ;
			}
			//2����ֵ�ӽ���㴫���߼��������ʵ���
			PutDataToDGRegionClass(objDGRegion);		//�ѽ����ֵ����
			//3����鴫��ȥ�Ķ��������Ƿ�Ϸ�
			try
			{
                //clsDGRegionBL .CheckPropertyNew(objDGRegion);
                ////6��������ʵ�������ݴ��������ݿ���
                //clsDGRegionBL.UpdateBySql2(objDGRegion);
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
//			BindDg_DGRegion();
			wucDGRegion1.Clear();//��տؼ��е�����
			//�ָ�<ȷ���޸�>���<���>
			btnOKUpd.Text = "���";
		}

		///�޸Ĵ���׼�����̴��� for C#
		private void UpdateDGRegionRecordSaveV5(clsDGRegionEN objDGRegion)
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
			if (!wucDGRegion1.IsValid(ref strResult))
			{
				lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
				return ;
			}
			//2����ֵ�ӽ���㴫���߼��������ʵ���
			PutDataToDGRegionClass(objDGRegion);		//�ѽ����ֵ����
			//3����鴫��ȥ�Ķ��������Ƿ�Ϸ�
			try
			{
				//clsDGRegionBL .CheckPropertyNew(objDGRegion);
    //            //6��������ʵ�������ݴ��������ݿ���
    //            clsDGRegionBL.UpdateBySql2(objDGRegion);
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
			//			BindDg_DGRegion();
			wucDGRegion1.Clear();//��տؼ��е�����
			//�ָ�<ȷ���޸�>���<���>
			btnOKUpd.Text = "���";
		}
		///�޸Ĵ���׼�����̴��� for C#
		private void UpdateEditRegionRecordSaveV5(clsEditRegionEN objEditRegion)
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
			if (!wucEditRegion1.IsValid(ref strResult))
			{
				lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
				return ;
			}
			//2����ֵ�ӽ���㴫���߼��������ʵ���
			PutDataToEditRegionClass(objEditRegion);		//�ѽ����ֵ����
			//3����鴫��ȥ�Ķ��������Ƿ�Ϸ�
			try
			{
				 //clsEditRegionBL .CheckPropertyNew(objEditRegion);
     //           //6��������ʵ�������ݴ��������ݿ���
     //           clsEditRegionBL.UpdateBySql2(objEditRegion);
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
			//			BindDg_EditRegion();
			wucEditRegion1.Clear();//��տؼ��е�����
			//�ָ�<ȷ���޸�>���<���>
			btnOKUpd.Text = "���";
		}
		///�޸Ĵ���׼�����̴��� for C#
		private void UpdateListViewRegionRecordSaveV5(clsDGRegionEN objListViewRegionEN)
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
			if (!wucListViewRegion1.IsValid(ref strResult))
			{
				lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
				return ;
			}
			//2����ֵ�ӽ���㴫���߼��������ʵ���
			PutDataToListViewRegionClass(objListViewRegionEN);		//�ѽ����ֵ����
			//3����鴫��ȥ�Ķ��������Ƿ�Ϸ�
			try
			{
				// clsDGRegionBL.CheckPropertyNew(objListViewRegionEN);
				////6��������ʵ�������ݴ��������ݿ���
    //             clsDGRegionBL.UpdateBySql2(objListViewRegionEN);
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
			//			BindDg_ListViewRegion();
			wucListViewRegion1.Clear();//��տؼ��е�����
			//�ָ�<ȷ���޸�>���<���>
			btnOKUpd.Text = "���";
		}
		///�޸Ĵ���׼�����̴��� for C#
		private void UpdateQueryRegionRecordSaveV5(clsQueryRegionEN objQueryRegion)
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
			if (!wucQryRegion1.IsValid(ref strResult))
			{
				lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
				return ;
			}
			//2����ֵ�ӽ���㴫���߼��������ʵ���
			PutDataToQueryRegionClass(objQueryRegion);		//�ѽ����ֵ����
			//3����鴫��ȥ�Ķ��������Ƿ�Ϸ�
			try
			{
                //clsQueryRegionBL .CheckPropertyNew(objQueryRegion);
                ////6��������ʵ�������ݴ��������ݿ���
                //clsQueryRegionBL.UpdateBySql2(objQueryRegion);

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
			//			BindDg_QueryRegion();
			wucQryRegion1.Clear();//��տؼ��е�����
			//�ָ�<ȷ���޸�>���<���>
			btnOKUpd.Text = "���";
		}
		private void UpdateRegionRecordSave(string lngRegionId)
		{
			//����һ��������޸ĵĴ��룬�����߼���̫�򵥣�
			//�Ͱ��߼���ϲ������Ʋ�,
			//�������裺
			//1�����ؼ����������������Ƿ���ȷ
			//2����ֵ�ӽ���㴫���߼��������ʵ���
			//3����鴫��ȥ�Ķ��������Ƿ�Ϸ�
			//4��������ʵ�������ݴ��������ݿ���
			//5�����޸ĺ��������ʾ��DATAGRID��
			//1�����ؼ����������������Ƿ���ȷ
			///
			//1�����ؼ����Ƿ�Ϊ�գ�
			if (string.IsNullOrEmpty( lngRegionId )== true) return ;		//����ؼ���Ϊ�վͷ����˳�
			clsViewRegionEN objViewRegionEN = clsViewRegionBL.GetObjByRegionId_Cache(lngRegionId, clsPubVar.CurrSelPrjId);
			switch(objViewRegionEN.RegionTypeId)
			{
				case clsRegionTypeENEx.EDITREGION:	//�༭����
					//clsEditRegionEN objEditRegion = (clsEditRegionEN) Session["objEditRegion"];
					//UpdateEditRegionRecordSaveV5(objEditRegion);		

					break;
				case clsRegionTypeENEx.QUERYREGION:	//��ѯ����
					//clsQueryRegionEN objQryRegion = new clsQueryRegionEN(lngRegionId);
					//UpdateQueryRegionRecordSaveV5(objQryRegion);
					break;
				case clsRegionTypeENEx.DGREGION:		//�б�����
					//clsDGRegionEN objDGRegion = new clsDGRegionEN(lngRegionId);
					//UpdateDGRegionRecordSave(objDGRegion);
					break;	
				//case clsRegionTypeENEx.LISTVIEWREGION:	//LISTVIEW����
				//	clsDGRegionEN objListViewRegionEN = new clsDGRegionEN(lngRegionId);
				//	UpdateListViewRegionRecordSaveV5(objListViewRegionEN);

				//	break;
				case clsRegionTypeENEx.EXCELEXPORT_REGION:	//EXCEL��������
					//					clsExcelExportRegion objExcelExportRegion = new clsExcelExportRegion(lngRegionId);
					
					break;
				case clsRegionTypeENEx.DETAILREGION:	//��ϸ����
					break;
				case clsRegionTypeENEx.TREEVIEWREGION:	//������
					break;
			}
            HideAllRegion();
			DispViewRegionListRegion();

		}

		protected void btnClear_Click(object sender, System.EventArgs e)
		{
            HideAllRegion();

			btnOKUpd.Text = "���";
			DispViewRegionListRegion();
		}
		private void DispViewRegionListRegion()
		{
            HideAllRegion();
			tabViewRegionDataGrid.Visible = true;
			tabViewRegionJumpPage.Visible = true;
		}
		private void HideViewRegionListRegion()
		{
			tabViewRegionDataGrid.Visible = false;
			tabViewRegionJumpPage.Visible = false;
		}

		protected void btnPreView_Click(object sender, System.EventArgs e)
		{
			BackViewRegionLinkStr = Page.Request.Url.AbsolutePath;
			Response.Redirect("../View/wfmPreviewViewRegion.aspx?ParentPage=ViewRegion");
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
                    clsCommonJsFunc.Alert(this, string.Format("��ҳ�����ƣ�[{0}]��({1})��û�д���",
                        qsParentPage, clsStackTrace.GetCurrClassFunction()));
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