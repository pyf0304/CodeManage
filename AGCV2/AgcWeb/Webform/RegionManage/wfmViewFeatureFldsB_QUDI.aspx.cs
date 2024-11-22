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
using AGC.Entity;

using AGC.BusinessLogic;using AGC.FunClass;

using AGC.BusinessLogicEx;


using com.taishsoft.common;
using System.Text;
using AutoGCLib;
using AGC.web.treeview;
using com.taishsoft.web.treeview;

namespace AGC.Webform
{
	/// <summary>
	/// wfmViewFeatureFlds_QUDI ��ժҪ˵��������Q�����ѯ��U�����޸�
	/// </summary>
	public partial class wfmViewFeatureFldsB_QUDI : CommWebPageBase
    {

		//�����йصı����������
		private const string ViewId4Potence="00260203";		//������

        /// <summary>
        /// �Ƿ��Զ�������򣺣��ǣ�true, ��false��
        /// </summary>
        private string qsAutoAddRegion
        {
            get
            {
                string strAutoAddRegion = Request.QueryString["AutoAddRegion"] ?? "".ToString();
                if ((strAutoAddRegion != null) && (strAutoAddRegion != ""))
                {
                    return strAutoAddRegion;//Request.QueryString["id"] ?? "";
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

				//1��Ϊ��������������Դ�����б�����
				wucViewFeatureFlds1.SetDdl_CtlTypeId(false);
                wucViewFeatureFlds1.SetDdl_FieldTypeId();
                wucViewFeatureFlds1.SetDdl_DdlItemsOptionId();
                wucViewFeatureFlds1.SetDdl_DsTabId(clsPubVar.CurrSelPrjId);
                clsViewFeatureFldsBLEx.BindDdl_FeatureIdExByViewId1(ddlFeatureId, clsCommonSession.ViewId, clsPubVar.CurrCmPrjId);
                if (string.IsNullOrEmpty(clsCommonSession.ViewId) == false)
                {
                    //trHidden.Visible = false;
                    //clsFieldTabBLEx.BindDdl_FldIDByTabIdEx(ddlFldIdq, clsCommonSession.qsTabId);
                    //wucTabFeatureFldsB1.SetDdl_FldId(clsCommonSession.qsTabId);
                    //wucTabFeatureFldsB1.HiddenTrTabId();
                    BindTv_ViewRegion_PrjFeature();
                }

                //��ʼ��������Դ���ͣ�
                
				strSortViewFeatureFldsBy = "SeqNum Asc";
				//2����ʾ�������ı�������DATAGRID��
				///
				if (string.IsNullOrEmpty( clsCommonSession.ViewId )==true)
				{
					return ;
				}
				BindGv_vViewFeatureFlds();
				//BindDg_PrjTabFld();
				
				tabEditViewFeatureFldsRegion.Visible = false;  //������Ϣά����������

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
        /// <summary>
        /// ��������ķ����ֶ�
        /// </summary>
        private string vsViewFeatureId
        {
            get
            {
                string strViewFeatureId;
                strViewFeatureId = (string)ViewState["ViewFeatureId"];
                if (strViewFeatureId == null)
                {
                    strViewFeatureId = "";
                }
                return strViewFeatureId;
            }
            set
            {
                string strViewFeatureId = value;
                ViewState.Add("ViewFeatureId", strViewFeatureId);
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
		

		///������ϲ�ѯ�����Ĵ���
		/// <summary>
		/// �����еĲ�ѯ�ؼ�������ϳ�һ��������
		/// </summary>
		/// <returns>������(strWhereCond)</returns>
		private string CombinevViewFeatureFldsCondition()
		{
            //ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
            //���� 1=1 && UserName = '����'


            var arrRegionId = clsViewRegionRelaBLEx.GetRegionIdLstByViewIdCache(clsCommonSession.ViewId,clsPubVar.CurrCmPrjId);

           
            string strWhereCond = string.Format(" 1=1 and {0} in (Select {0} From {1} Where {2} = '{3}') ",
                conViewFeatureFlds.ViewFeatureId, 
                clsvFeatureRegionFldsEN._CurrTabName, 
                convFeatureRegionFlds.RegionId, clsArray.GetSqlInStrByArray(arrRegionId, true));
            if (string.IsNullOrEmpty(vsViewFeatureId) == false)
            {
                strWhereCond += string.Format(" And {0}='{1}'",
                       conViewFeatureFlds.ViewFeatureId, vsViewFeatureId);
            }
            if (chkOnlyShowFldInUse.Checked == true)
            {
                strWhereCond += string.Format(" And {0}='1'", conViewFeatureFlds.InUse);
            }

            return strWhereCond;
		}
		///���ɰ�DATAGRID�Ĵ���
		/// <summary>
		/// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
		///			 ����ʾ��DATAGRID�С�
		/// </summary>
		private void BindGv_vViewFeatureFldsBak()
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
			string strWhereCond = CombinevViewFeatureFldsCondition();
			//	2��������������ȡ�ñ�����������DataTable��
			System.Data.DataTable objDT = clsvViewFeatureFldsBL.GetDataTable(strWhereCond + " order by SeqNum" );
			//	3�����DATAGRID�ĵ�ǰҳ���Ƿ񳬳�DATAGRID��ҳ����Χ
			//		3.1 ���ȼ���ҳ����
			//		3.2 �����ǰҳ����ҳ����Ϊ���һҳ
			//int intPages = CalcPages(objDT.Rows.Count, this.dgViewFeatureFlds.PageSize);
			//if (intPages==0) 
			//{
			//	this.dgViewFeatureFlds.CurrentPageIndex = 0;
			//}
			//else if (this.dgViewFeatureFlds.CurrentPageIndex > intPages - 1) 
			//{
			//	this.dgViewFeatureFlds.CurrentPageIndex = intPages - 1;
			//}
			////	4������DATAGRID������Դ(DataSource)��
			//DataView objDV = objDT.DefaultView;
			//objDV.Sort = strSortViewFeatureFldsBy;     ///ע����һ�д����п�����Ҫע�͵���Ŀǰ���н����ڵ����Ĳ�ѯ������������
			//this.dgViewFeatureFlds.DataSource=objDV;
			////	5����DATAGRID������DataTable��������ʾ��DATAGRID��
			//this.dgViewFeatureFlds.DataBind();

			
			////��ǰ��¼��
			//this.lblViewFeatureFldsRecCount.Text = objDT.Rows.Count.ToString(); 
			////��ǰҳ��
			//this.lblViewFeatureFldsAllPages.Text = this.dgViewFeatureFlds.PageCount.ToString(); 
			////��ǰҳ����
			//this.lblViewFeatureFldsCurrentPage.Text=(this.dgViewFeatureFlds.CurrentPageIndex+1).ToString();
			////��ǰ����������ҳ����
			//this.txtViewFeatureFldsJump2Page.Text=(this.dgViewFeatureFlds.CurrentPageIndex+1).ToString();
			////�����ǰҳ����Ϊ0����<ǰһҳ>��ť��Ч
			//if(this.dgViewFeatureFlds.CurrentPageIndex==0) 
			//{
			//	btnViewFeatureFldsPrevPage.Enabled=false; 
			//}
			//else 
			//{ 
			//	btnViewFeatureFldsPrevPage.Enabled=true; 
			//} 
			////�����ǰҳ������Ϊ���һҳ����<ǰһҳ>��ť��Ч
			//if(this.dgViewFeatureFlds.CurrentPageIndex==this.dgViewFeatureFlds.PageCount-1) 
			//{ 
			//	btnViewFeatureFldsNextPage.Enabled=false; 
			//} 
			//else 
			//{ 
			//	btnViewFeatureFldsNextPage.Enabled=true; 
			//} 
			////7�������沿����ʾ����ʾ �������ǰDataGrid�еļ�¼��Ϊ0������ʾ��ǰ����ҳ������
			//if(objDT.Rows.Count>0) 
			//{ 
			//	this.tabViewFeatureFldsJumpPage.Visible = true; 
			//} 
			//else 
			//{ 
			//	this.tabViewFeatureFldsJumpPage.Visible = false; 
			//}
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
            wucvViewFeatureFlds4Gv1.vsPageIndex = 1;
            //�ѱ��¼��������ʾ��GridView��
            BindGv_vViewFeatureFlds();
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
			if (clsViewFeatureFldsBL.IsExist(lngmId) == false)		//���ùؼ��ֵļ�¼�Ƿ����
			{
				string ss = "�ؼ���Ϊ��" + lngmId + "�Ĳ�����!";
				clsCommonJsFunc.Alert(this, ss);
				return ;
			}
			//3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
			clsViewFeatureFldsEN objViewFeatureFlds = new clsViewFeatureFldsEN(lngmId);
            //4����ȡ�������������ԣ�
            clsViewFeatureFldsBL .GetViewFeatureFlds(ref objViewFeatureFlds);
			Session.Add("objViewFeatureFlds", objViewFeatureFlds);
			//5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���
			GetDataFromViewFeatureFldsClass(objViewFeatureFlds);
			DispEditViewFeatureFldsRegion();
		}
		///���ɴ��߼�������ݴ��䵽�����ĺ�������
		/// <summary>
		/// �������ܣ�������������������ʾ��������
		///ע�⣺��������������򣬲�����һ��������������ϵ�ģ�����Ϊһ��������ֵ��Ȼ����Ϊ����������ֵ
		///      ������������ݿ�ʱ����Ӧ��һ���ֶ���ǰ�������ֶ��ں�
		/// </summary>
		/// <param name="pobjViewFeatureFlds">��ʵ�������</param>
		private void GetDataFromViewFeatureFldsClass(clsViewFeatureFldsEN pobjViewFeatureFlds)
		{
            vsViewFeatureId = pobjViewFeatureFlds.ViewFeatureId;
            clsvFeatureRegionFldsEN objFeatureRegionFlds = clsvFeatureRegionFldsBL.GetObjByViewFeatureId(pobjViewFeatureFlds.ViewFeatureId);
            wucViewFeatureFlds1.vsViewFeatureId = pobjViewFeatureFlds.ViewFeatureId;
            wucViewFeatureFlds1.ViewFeatureName = string.Format("{0}({1})", objFeatureRegionFlds.FeatureName, objFeatureRegionFlds.RegionName);
            wucViewFeatureFlds1.SetDdl_FldId(objFeatureRegionFlds.ReleTabId);
            wucViewFeatureFlds1.FldId = pobjViewFeatureFlds.ReleFldId;
            wucViewFeatureFlds1.FieldTypeId = pobjViewFeatureFlds.FieldTypeId;


            wucViewFeatureFlds1.LabelCaption = pobjViewFeatureFlds.LabelCaption;

            wucViewFeatureFlds1.CtlTypeId = pobjViewFeatureFlds.CtlTypeId;
            wucViewFeatureFlds1.CtrlId = pobjViewFeatureFlds.CtrlId;

            wucViewFeatureFlds1.SeqNum = pobjViewFeatureFlds.OrderNum ?? 0;
			wucViewFeatureFlds1.Memo = pobjViewFeatureFlds.Memo;

            wucViewFeatureFlds1.DdlItemsOptionId = pobjViewFeatureFlds.DdlItemsOptionId;
            wucViewFeatureFlds1.DsTabId = pobjViewFeatureFlds.DsTabId;

            wucViewFeatureFlds1.DsCondStr = pobjViewFeatureFlds.DsCondStr;
            wucViewFeatureFlds1.DsSqlStr = pobjViewFeatureFlds.DsSqlStr;
            wucViewFeatureFlds1.ItemsString = pobjViewFeatureFlds.ItemsString;

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
			clsViewFeatureFldsEN objViewFeatureFlds;
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
					if (!wucViewFeatureFlds1.IsValid(ref strResult))
					{
						lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
						return ;
					}
					//2��������󲢳�ʼ������
					//clsViewFeatureFldsEN objViewFeatureFlds;	//�������
					objViewFeatureFlds = new clsViewFeatureFldsEN();	//��ʼ���¶���
					//3���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
					//4����ֵ�ӽ���㴫���߼��������ʵ���
					PutDataToViewFeatureFldsClass(objViewFeatureFlds);		//�ѽ����ֵ����
					//5����鴫��ȥ�Ķ��������Ƿ�Ϸ�
                    try
                    {
                        clsViewFeatureFldsBL.CheckPropertyNew(objViewFeatureFlds);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }

					//6��������ʵ�������ݴ��������ݿ���
					if (clsViewFeatureFldsBL.AddNewRecordBySql2(objViewFeatureFlds) == false) 
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
					BindGv_vViewFeatureFlds();
					wucViewFeatureFlds1.Clear();		//��տؼ�������
					///�ָ�<ȷ�����>���<���>
					btnOKUpd.Text = "���";
                    DispViewFeatureFldsInfo();
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
					if (!wucViewFeatureFlds1.IsValid(ref strResult))
					{
						lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
						return ;
					}
					//2����ֵ�ӽ���㴫���߼��������ʵ���
					objViewFeatureFlds = (clsViewFeatureFldsEN) Session["objViewFeatureFlds"];
					PutDataToViewFeatureFldsClass(objViewFeatureFlds);		//�ѽ����ֵ����
					//3����鴫��ȥ�Ķ��������Ƿ�Ϸ�
                    try
                    {
                        clsViewFeatureFldsBL.CheckPropertyNew(objViewFeatureFlds);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }

					//4��������ʵ���������޸�ͬ�������ݿ���
					if (clsViewFeatureFldsBL .UpdateBySql2(objViewFeatureFlds) == false) 
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
					BindGv_vViewFeatureFlds();
					wucViewFeatureFlds1.Clear();//��տؼ��е�����
					//�ָ�<ȷ���޸�>���<���>
					btnOKUpd.Text = "���";
					
					DispViewFeatureFldsInfo();

					break;
			}
		}
		
		/// <summary>
		/// �������ܣ��ѽ����ϵ��������ݴ����������
		/// </summary>
		/// <param name="pobjViewFeatureFlds">���ݴ����Ŀ�������</param>
		private void PutDataToViewFeatureFldsClass(clsViewFeatureFldsEN pobjViewFeatureFlds)
		{
            pobjViewFeatureFlds.ViewFeatureId = vsViewFeatureId;
            pobjViewFeatureFlds.ReleFldId = wucViewFeatureFlds1.FldId;
            pobjViewFeatureFlds.FieldTypeId = wucViewFeatureFlds1.FieldTypeId;

            pobjViewFeatureFlds.LabelCaption = wucViewFeatureFlds1.LabelCaption;

            pobjViewFeatureFlds.CtlTypeId = wucViewFeatureFlds1.CtlTypeId;
            pobjViewFeatureFlds.CtrlId = wucViewFeatureFlds1.CtrlId;

            pobjViewFeatureFlds.OrderNum = wucViewFeatureFlds1.SeqNum;
            pobjViewFeatureFlds.InUse = true;

            pobjViewFeatureFlds.UpdDate = wucViewFeatureFlds1.UpdDate;
			pobjViewFeatureFlds.UpdUser = UserId;
			pobjViewFeatureFlds.Memo = wucViewFeatureFlds1.Memo;
            pobjViewFeatureFlds.DsTabId = wucViewFeatureFlds1.DsTabId;
            pobjViewFeatureFlds.DsCondStr = wucViewFeatureFlds1.DsCondStr;
            pobjViewFeatureFlds.DsSqlStr = wucViewFeatureFlds1.DsSqlStr;
            pobjViewFeatureFlds.ItemsString = wucViewFeatureFlds1.ItemsString;

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
            //DispPrjTabFldsInfo();
            DispEditViewFeatureFldsRegion();
            //BindDg_PrjTabFld();
            btnOKUpd.Text = "ȷ�����";
            if (string.IsNullOrEmpty(vsViewFeatureId) == true)
            {
                clsCommonJsFunc.Alert(this, "������߹���-��������ѡ��һ�����湦�ܣ�");
                return;
            }
            clsvFeatureRegionFldsEN objFeatureRegionFlds = clsvFeatureRegionFldsBL.GetObjByViewFeatureId(vsViewFeatureId);
            wucViewFeatureFlds1.SetDdl_FldId(objFeatureRegionFlds.ReleTabId);
            wucViewFeatureFlds1.ViewFeatureName = string.Format("{0}({1})", objFeatureRegionFlds.FeatureName, objFeatureRegionFlds.RegionName);

        }

		
		//��ǰ��¼��
		protected void btnExportExcel4Dg_Click(object sender, System.EventArgs e)
		{
			//	1����Ͻ�����������
			string strWhereCond = CombinevViewFeatureFldsCondition();
			//	2��������������ȡ�ñ�����������DataTable��
			System.Data.DataTable objDT = clsViewFeatureFldsBL.GetDataTable_ViewFeatureFlds(strWhereCond);
			List<string> arrCnName = new List<string>();
			List<string> arrColName = new List<string>();
			string strFileName = "ViewFeatureFlds��Ϣ����.xls";
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
            List<long> lstMId = wucvViewFeatureFlds4Gv1.GetAllCheckedKeysFromGv();
            if (lstMId == null) return;
            lblMsg1.Text = "";
            foreach (long lngmId in lstMId)
            {
                clsViewFeatureFldsBL.DelRecord(lngmId);
            }
            clsViewFeatureFldsBLEx.ReOrder(vsViewFeatureId);
			BindGv_vViewFeatureFlds();
		}

		
		//��ǰ��¼��
		protected void btnUpdate4Dg_Click(object sender, System.EventArgs e)
		{
            long lngmId = wucvViewFeatureFlds4Gv1.GetFirstCheckedKeyFromGv();
            if (lngmId == 0) return;
            lblMsg1.Text = "";
			//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
		
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
		
		private string strSortViewFeatureFldsBy
		{
			get
			{
				string sSortViewFeatureFldsBy;
				sSortViewFeatureFldsBy = (string)ViewState["SortViewFeatureFldsBy"];
				if (sSortViewFeatureFldsBy==null) 
				{
					sSortViewFeatureFldsBy = "";
				}
				return sSortViewFeatureFldsBy;
			}
			set
			{
				string sSortViewFeatureFldsBy = value;
				ViewState.Add("SortViewFeatureFldsBy", sSortViewFeatureFldsBy);
			}
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
            if (string.IsNullOrEmpty(vsViewFeatureId) == true)
            {
                //                clsCommonJsFunc.Alert(this, "�������صĹ��ܲ���Ҫ����ֶΣ�����ϵ����Ա��");
                clsCommonJsFunc.Alert(this, "��ѡ��һ���������ع���, ���������û����ع��ܣ�˵��������û�������Ҫ�ֶεĹ��ܣ�");
                ddlFeatureId.Focus();
                return;
            }

            //clsViewFeatureFldsBLEx.ImportRelaFlds(clsCommonSession.ViewId, RegionId, vsFeatureId4Classify, clsPubVar.CurrCmPrjId, clsCommonSession.UserId);
            BindGv_vViewFeatureFlds();
			///�ָ�<ȷ�����>���<���>
			//		lbDispFldList_Click(new object(), new System.EventArgs());
			Response.Write("<script>alert('�������ص������ֶ���Ϣ���Ƴɹ�����')</script>");
		}

	
		

		protected void LinkButton1_Click(object sender, System.EventArgs e)
		{
			DispViewFeatureFldsInfo();
		}

		protected void btnGoBack_Click(object sender, System.EventArgs e)
		{
			Response.Redirect(BackViewRegionLinkStr);
		}

		protected void rblSQLDSType_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			//BindDg_PrjTabFld();
		}

		private void DispViewFeatureFldsInfo()
		{
			tabViewFeatureFldsDataGrid.Visible = true;
			
			tabEditViewFeatureFldsRegion.Visible = false;
			
			tabEditRegionPreview.Visible = true;
			tabCode.Visible = true;
		}
		private void DispPrjTabFldsInfo()
		{
			
			tabEditViewFeatureFldsRegion.Visible = false;
			tabViewFeatureFldsDataGrid.Visible = false;
			
			tabEditRegionPreview.Visible = false;
			tabCode.Visible = false;
		}
		private void DispEditViewFeatureFldsRegion()
		{
			tabViewFeatureFldsDataGrid.Visible = false;
			
			tabEditViewFeatureFldsRegion.Visible = true;
			tabEditRegionPreview.Visible = false;
			tabCode.Visible = false;
		}

		protected void btnPreView_Click(object sender, System.EventArgs e)
		{
			string strMsg;			
			string strViewId = clsCommonSession.ViewId;
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
            long lngmId = wucvViewFeatureFlds4Gv1.GetFirstCheckedKeyFromGv();
            if (lngmId == 0) return;
            lblMsg1.Text = "";

			try
			{
				clsViewFeatureFldsBLEx.AdjustOrderNum("DOWN", lngmId, vsViewFeatureId);
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
			BindGv_vViewFeatureFlds();
            wucvViewFeatureFlds4Gv1.SetCheckedItemForGv(lngmId);



        }

        protected void btnUpMove_Click(object sender, System.EventArgs e)
		{
			string strMsg;
            long lngmId = wucvViewFeatureFlds4Gv1.GetFirstCheckedKeyFromGv();
            if (lngmId == 0) return;
            lblMsg1.Text = "";
			
			try
			{
				clsViewFeatureFldsBLEx.AdjustOrderNum("UP", lngmId, vsViewFeatureId);
				
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
			BindGv_vViewFeatureFlds();
            wucvViewFeatureFlds4Gv1.SetCheckedItemForGv(lngmId);

        }

        protected void btnGoFirstLine_Click(object sender, EventArgs e)
        {
            string strMsg;
            long lngmId = wucvViewFeatureFlds4Gv1.GetFirstCheckedKeyFromGv();
            if (lngmId == 0) return;
            lblMsg1.Text = "";

            try
            {
                clsViewFeatureFldsBLEx.AdjustOrderNum("FIRST", lngmId, vsViewFeatureId);
            }

            catch (Exception objException)
            {
                strMsg = objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsg1.Text = strMsg;
                //				clsCommonSession.seErrMessage = objException.Message;
                //				clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;	//"../GenCode/wfmGenViewCode_WebV5.aspx";
                //				clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_vViewFeatureFlds();
            wucvViewFeatureFlds4Gv1.SetCheckedItemForGv(lngmId);

        }

        protected void btnGoLastLine_Click(object sender, EventArgs e)
        {
            string strMsg;
            long lngmId = wucvViewFeatureFlds4Gv1.GetFirstCheckedKeyFromGv();
            if (lngmId == 0) return;
            lblMsg1.Text = "";

            try
            {
                clsViewFeatureFldsBLEx.AdjustOrderNum("LAST", lngmId, vsViewFeatureId);
            }

            catch (Exception objException)
            {
                strMsg = objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsg1.Text = strMsg;
                //				clsCommonSession.seErrMessage = objException.Message;
                //				clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;	//"../GenCode/wfmGenViewCode_WebV5.aspx";
                //				clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_vViewFeatureFlds();
            wucvViewFeatureFlds4Gv1.SetCheckedItemForGv(lngmId);
        }

		protected void btnReOrder_Click(object sender, System.EventArgs e)
		{
			clsViewFeatureFldsBLEx.ReOrder(vsViewFeatureId);
			BindGv_vViewFeatureFlds();
		}

		protected void lbDispTabList_Click(object sender, System.EventArgs e)
		{
			DispViewFeatureFldsInfo();
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


        protected void btnSetInUse_Click(object sender, EventArgs e)
        {
            List<long> lstMId = wucvViewFeatureFlds4Gv1.GetAllCheckedKeysFromGv();
            if (lstMId == null) return;
            lblMsg1.Text = "";
            try
            {
                clsViewFeatureFldsBLEx.SetInUse(lstMId, clsCommonSession.UserId);
                BindGv_vViewFeatureFlds();
            }
            catch (Exception objException)
            {
                string strMsg = objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsg1.Text = strMsg;
            }
        }

        protected void btnSetNotInUse_Click(object sender, EventArgs e)
        {
            List<long> lstMId = wucvViewFeatureFlds4Gv1.GetAllCheckedKeysFromGv();
            if (lstMId == null) return;
            lblMsg1.Text = "";
            try
            {
                clsViewFeatureFldsBLEx.SetNotInUse(lstMId, clsCommonSession.UserId);
                BindGv_vViewFeatureFlds();
            }
            catch (Exception objException)
            {
                string strMsg = objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsg1.Text = strMsg;
            }
        }

        protected void chkOnlyShowFldInUse_CheckedChanged(object sender, EventArgs e)
        {
            BindGv_vViewFeatureFlds();
        }
        /// <summary>
        /// �¼�����:��Gv�б�ؼ��У���GeidView�е����޸�ʱ�������¼���
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_Wuc4Gv_GvUpdateClick)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void wucvViewFeatureFlds4Gv1_GvUpdateClick(object sender, clsEventArgs4Update e)
        {
            long lngmId = long.Parse(e.KeyId);
            UpdateViewFeatureFldsRecord(lngmId);
        }
        /// <summary>
        /// Ϊ�޸ļ�¼��׼������,�Ѹ����ؼ��ֵļ�¼�ֶ�ֵ��ʾ���û��ؼ���
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenUpdateRecordCode)
        /// </summary>
        protected void UpdateViewFeatureFldsRecord(long lngmId)
        {
            //��������:(�ܹ�2��)
            //1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
            //2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�

            //1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
            ShowData(lngmId);
            //2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
            btnOKUpd.Enabled = true;
            btnOKUpd.Text = "ȷ���޸�";
            //btnCancelViewFeatureFldsEdit.Text = "ȡ���޸�";
            //lblMsgEdit.Text = "";
            DispEditViewFeatureFldsRegion();
        }

        ///
        /// <summary>
        /// �¼�����:��Gv�б�ؼ��У���GeidView�е���ɾ��ʱ�������¼���
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_Wuc4Gv_GvDeleteClick)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void wucvViewFeatureFlds4Gv1_GvDeleteClick(object sender, clsEventArgs4Delete e)
        {
            long lngmId = long.Parse(e.KeyId);
            DeleteViewFeatureFldsRecord(lngmId);
        }
        /// <summary>
        /// ���ݸ����ؼ���ɾ����¼
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDelRecordCode)
        /// </summary>
        /// <param name = "lngmId">�����ؼ���</param>
        protected void DeleteViewFeatureFldsRecord(long lngmId)
        {
            try
            {
                clsViewFeatureFldsBL.DelRecord(lngmId);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000022)ɾ����¼���ɹ�!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsg1.Text = strMsg;
                return;
            }
            BindGv_vViewFeatureFlds();
        }

        /// <summary>
        /// ��������:�Ѳ�ѯ���ݰ���GridView�ϡ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼,
        ///			 ����ʾ��GridView�С�
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenBindGridView4WucInPage)
        /// </summary>
        protected void BindGv_vViewFeatureFlds()
        {
            //��������:(��5��)
            //	1����Ͻ�����������
            //	2�����ÿؼ��еİ�GridView����;
            //	3������Gv�ؼ���ĳЩ�в��ɼ�;

            try
            {
                //	1����Ͻ�����������
                string strWhereCond = CombinevViewFeatureFldsCondition();
                //	2�����ÿؼ��еİ�GridView������
                wucvViewFeatureFlds4Gv1.SetSortBy_Prev(string.Format("{0} desc", convViewFeatureFlds.InUse));
                wucvViewFeatureFlds4Gv1.SetSortBy(string.Format("{0}", convViewFeatureFlds.OrderNum));

                wucvViewFeatureFlds4Gv1.BindGv_ViewFeatureFlds(strWhereCond);
                //	3������Gv�ؼ���ĳЩ�в��ɼ���
                //wucvViewFeatureFlds4Gv1.SetGvVisibility(convViewFeatureFlds.UpdDate, false);
                //wucvViewFeatureFlds4Gv1.SetGvVisibility(convViewFeatureFlds.UpdUser, false);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000019)��GridView����!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }

        }

        //protected void ddlFeatureId_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (ddlFeatureId.SelectedIndex <= 0) return;
        //    string strFeatureId = ddlFeatureId.SelectedValue;
        //    vsFeatureId4Classify = strFeatureId;
        //    BindGv_vViewFeatureFlds();
        //}
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

        private void BindTv_ViewRegion_PrjFeature()
        {
            string strViewId = clsCommonSession.ViewId;
            if (string.IsNullOrEmpty(strViewId) == true) return;
            wucTreeView4ViewFeature.tmTreeModel = TreeModel.ViewRegion_ViewFeature;
            //wucTreeView4TabFeature.DependsOn = "Table";
            wucTreeView4ViewFeature.ViewId = strViewId;
			//wucTreeView4TabFeature.IsUseJsEvent = true;
			wucTreeView4ViewFeature.PrjId = clsPubVar.CurrSelPrjId;// "0116";
			wucTreeView4ViewFeature.CmPrjId = clsPubVar.CurrCmPrjId;// "0116";

			wucTreeView4ViewFeature.BindTv();
            //wucTreeView4ViewFeature.Expand(1);
            //wucTreeView4TabFeature.afterSelect_Tz += wucTreeView4TabFeature_afterSelect_Tz;
            string strKeyId = vsKeyId;
            string strTypeName = vsTreeNodeType;
            //wucTreeView4TabFeature.CollapseAll();
            //            wucTreeView4TabFeature.SelectNodeEx(strTypeName, strKeyId);
            wucTreeView4ViewFeature.ExpandAll();

            //            wucTreeView4TabFeature.Nodes[1].Expand();
        }
        protected string vsTreeNodeType
        {
            get
            {
                string sTreeNodeType;
                sTreeNodeType = (string)ViewState["TreeNodeType"];
                if (sTreeNodeType == null)
                {
                    sTreeNodeType = "";
                }
                return sTreeNodeType;
            }
            set
            {
                string sTreeNodeType = value;
                ViewState.Add("TreeNodeType", sTreeNodeType);
            }
        }


        protected string vsKeyId
        {
            get
            {
                string sKeyId;
                sKeyId = (string)ViewState["KeyId"];
                if (sKeyId == null)
                {
                    sKeyId = "";
                }
                return sKeyId;
            }
            set
            {
                string sKeyId = value;
                ViewState.Add("KeyId", sKeyId);
            }
        }

        protected void wucTreeView4ViewFeature_afterSelect_Tz(object sender, clsEventArgs4TreeView e)
        {
            string strKeyId = e.KeyId;
            string strTypeName = e.NodeType;
            string strMsg = string.Format("strKeyId={0}, strTypeName={1}", strKeyId, strTypeName);
            //wucTreeView4TabFeature.CollapseAll();
            wucTreeView4ViewFeature.SelectNode(strTypeName, strKeyId);
            List<string> arrCurrPathNodeKeyIdLst = wucTreeView4ViewFeature.GetCurrPathNodeKeyIdLst();
            wucTreeView4ViewFeature.SelectNodeEx(arrCurrPathNodeKeyIdLst);

            if (strTypeName == clsFeatureRegionFldsEN._CurrTabName)
            {
                string strRegionId = arrCurrPathNodeKeyIdLst[0];
                ddlFeatureIdq.SelectedValue = strKeyId;
                //string strCondition = string.Format("{0}='{1}' and {2}='{3}'",
                //    clsTabFeatureEN.con_ViewId, clsCommonSession.qsTabId,
                //    clsTabFeatureEN.con_FeatureId, strKeyId);

                vsViewFeatureId = strKeyId;
                wucViewFeatureFlds1.vsViewFeatureId = vsViewFeatureId;
                BindGv_vViewFeatureFlds();
                return;
            }
            if (strTypeName != clsTabFeatureEN._CurrTabName) return;
            //string strTabFeatureId = strKeyId;
            //vsTabFeatureId = strTabFeatureId;
            BindGv_vViewFeatureFlds();
        }
        protected void btnRefreshTv_Click(object sender, EventArgs e)
        {
            BindTv_ViewRegion_PrjFeature();
        }

        protected void btnDeleteTabFeature_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(vsFeatureId) == true)
            {
                string strMsg = string.Format("��������ѡ��һ�����湦��.(In {0})", clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            try
            {
                clsTabFeatureBLEx.DelRecordEx(vsFeatureId, clsPubVar.CurrSelPrjId);
                BindTv_ViewRegion_PrjFeature();
                BindGv_vViewFeatureFlds();
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("��ɾ����¼ʱ��������{0}.(In {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
            }
        }

        protected string vsFeatureId
        {
            get
            {
                string sFeatureId;
                sFeatureId = (string)ViewState["FeatureId"];
                if (sFeatureId == null)
                {
                    sFeatureId = "";
                }
                return sFeatureId;
            }
            set
            {
                string sFeatureId = value;
                ViewState.Add("FeatureId", sFeatureId);
            }
        }

        protected void btnCancelFeatureRegionFldsEdit_Click(object sender, EventArgs e)
        {
            DispViewFeatureFldsInfo();
        }
    }
}