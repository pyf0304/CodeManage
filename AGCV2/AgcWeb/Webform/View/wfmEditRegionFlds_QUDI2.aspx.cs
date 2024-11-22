///���ɲ�ѯ���޸ģ�ɾ������Ӽ�¼�Ŀ��Ʋ����


using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Services;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Agc;
using AGC.BusinessLogic;
using AGC.BusinessLogicEx;

using AGC.Entity;
using AGC.FunClass;
using AgcCommBase;
using AutoGCLib;
using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.datetime;
using com.taishsoft.json;
using CommFunc4WebForm;


namespace AGC.Webform
{
    /// <summary>
    /// wfmEditRegionFlds_QUDI ��ժҪ˵��������Q�����ѯ��U�����޸�
    /// </summary>
    public partial class wfmEditRegionFlds_QUDI2 : CommWebPageBase
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
				if (clsCommonSession.ApplicationTypeId == (int)enumApplicationType.IOSApp_6
               || clsCommonSession.ApplicationTypeId == (int)enumApplicationType.IOSApp_WA_22)
                {
                    wucEditRegionFlds1.SetDdl_CtlTypeId(true);
                }
                else
                {
                    wucEditRegionFlds1.SetDdl_CtlTypeId(false);
                }
                wucEditRegionFlds1.SetDdl_DdlItemsOptionId();
                wucEditRegionFlds1.SetDdl_DsTabId(clsPubVar.CurrSelPrjId);
				wucEditRegionFlds1.SetDdl_InOutTypeId();
                wucEditRegionFlds1.SetDdl_VarId(clsPubVar.CurrSelPrjId);

                clsPageDispModeBL.BindDdl_PageDispModeIdCache(ddlPageDispModeId);
                clsGCContainerTypeBL.BindDdl_ContainerTypeIdCache(ddlContainerTypeId);

                //��ʼ��������Դ���ͣ�
                
				strSortEditRegionFldsBy = "SeqNum Asc";
				//2����ʾ�������ı�������DATAGRID��
				///
				if (string.IsNullOrEmpty(seRegionId )== true)
				{
					return ;
				}
          
                clsvViewRegionEN objvViewRegion = clsvViewRegionBL.GetObjByRegionIdCache(seRegionId, clsPubVar.CurrCmPrjId);
                wucEditRegionFlds1.SetDdl_FldId(objvViewRegion.TabId);

                vsIsDisp = objvViewRegion.IsDispInViewId(clsCommonSession.ViewId, clsPubVar.CurrCmPrjId);
                vsInUse = objvViewRegion.InUseInViewId(clsCommonSession.ViewId, clsPubVar.CurrCmPrjId);

                vsViewId = clsCommonSession.ViewId;
                txtColNum.Text = objvViewRegion.ColNum.ToString();
                ddlPageDispModeId.SelectedValue = objvViewRegion.PageDispModeId;
                ddlContainerTypeId.SelectedValue = objvViewRegion.ContainerTypeId;

                txtWidth.Text = objvViewRegion.Width.ToString(); 
                chkInUse.Checked = objvViewRegion.InUseInViewId(clsCommonSession.ViewId, clsPubVar.CurrCmPrjId);
                chkIsDisp.Checked = objvViewRegion.IsDispInViewId(clsCommonSession.ViewId, clsPubVar.CurrCmPrjId);
                if (string.IsNullOrEmpty( objvViewRegion.ClsName) == true)
                {
                    clsViewRegionBLEx.SetClassName(seRegionId, 0);
                    objvViewRegion = clsvViewRegionBL.GetObjByRegionIdCache(seRegionId, clsPubVar.CurrCmPrjId);
                }
                txtClassName.Text = objvViewRegion.ClsName;
                txtFileName.Text = objvViewRegion.FileName;

                vsApplicationTypeId = objvViewRegion.ApplicationTypeId ?? 0;
                clsViewInfoBLEx.BindDdl_ViewIdByTabIdEx(ddlViewId, clsPubVar.CurrSelPrjId, objvViewRegion.TabId, vsViewId);

                BindGv_vEditRegionFlds();
				//BindDg_PrjTabFld();
				
				//tabEditEditRegionFldsRegion.Visible = false;  //������Ϣά����������
                //wucGenViewCode1.vsRegionId = 17097;
                //wucGenViewCode1.ShowCodeTypeButton();
				//3�����ñ�ؼ����ֿؼ���ReadOnly���ԣ�
                //   ʹֻ֮������Ϊ���޸Ĺ����йؼ����ǲ��ܱ��޸ĵġ�
            }
            ShowCodeTypeButton();
            try
            {
          
                wucEditRegion4Preview1.ShowControl4Regoin(seRegionId, clsPubVar.CurrSelPrjId, chkInUse.Checked, chkIsDisp.Checked);
                //	3������Gv�ؼ���ĳЩ�в��ɼ���

                //wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.UpdUser, false);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000119)���ӻ���ʾ����������!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
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


        private string seRegionId
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
		private string CombinevEditRegionFldsCondition()
		{
			//ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
			//���� 1=1 && UserName = '����'
			string strWhereCond=" 1=1 and RegionId = '" + seRegionId + "'";
            if (chkOnlyShowFldInUse.Checked == true)
            {
                strWhereCond += string.Format(" And {0}='1'", conEditRegionFlds.InUse);
            }

            return strWhereCond;
		}
		///���ɰ�DATAGRID�Ĵ���
		/// <summary>
		/// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
		///			 ����ʾ��DATAGRID�С�
		/// </summary>
		private void BindGv_vEditRegionFldsBak()
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
			string strWhereCond = CombinevEditRegionFldsCondition();
			//	2��������������ȡ�ñ�����������DataTable��
			System.Data.DataTable objDT = clsvEditRegionFldsBL.GetDataTable(strWhereCond + " order by SeqNum" );
			//	3�����DATAGRID�ĵ�ǰҳ���Ƿ񳬳�DATAGRID��ҳ����Χ
			//		3.1 ���ȼ���ҳ����
			//		3.2 �����ǰҳ����ҳ����Ϊ���һҳ
			//int intPages = CalcPages(objDT.Rows.Count, this.dgEditRegionFlds.PageSize);
			//if (intPages==0) 
			//{
			//	this.dgEditRegionFlds.CurrentPageIndex = 0;
			//}
			//else if (this.dgEditRegionFlds.CurrentPageIndex > intPages - 1) 
			//{
			//	this.dgEditRegionFlds.CurrentPageIndex = intPages - 1;
			//}
			////	4������DATAGRID������Դ(DataSource)��
			//DataView objDV = objDT.DefaultView;
			//objDV.Sort = strSortEditRegionFldsBy;     ///ע����һ�д����п�����Ҫע�͵���Ŀǰ���н����ڵ����Ĳ�ѯ������������
			//this.dgEditRegionFlds.DataSource=objDV;
			////	5����DATAGRID������DataTable��������ʾ��DATAGRID��
			//this.dgEditRegionFlds.DataBind();

			
			////��ǰ��¼��
			//this.lblEditRegionFldsRecCount.Text = objDT.Rows.Count.ToString(); 
			////��ǰҳ��
			//this.lblEditRegionFldsAllPages.Text = this.dgEditRegionFlds.PageCount.ToString(); 
			////��ǰҳ����
			//this.lblEditRegionFldsCurrentPage.Text=(this.dgEditRegionFlds.CurrentPageIndex+1).ToString();
			////��ǰ����������ҳ����
			//this.txtEditRegionFldsJump2Page.Text=(this.dgEditRegionFlds.CurrentPageIndex+1).ToString();
			////�����ǰҳ����Ϊ0����<ǰһҳ>��ť��Ч
			//if(this.dgEditRegionFlds.CurrentPageIndex==0) 
			//{
			//	btnEditRegionFldsPrevPage.Enabled=false; 
			//}
			//else 
			//{ 
			//	btnEditRegionFldsPrevPage.Enabled=true; 
			//} 
			////�����ǰҳ������Ϊ���һҳ����<ǰһҳ>��ť��Ч
			//if(this.dgEditRegionFlds.CurrentPageIndex==this.dgEditRegionFlds.PageCount-1) 
			//{ 
			//	btnEditRegionFldsNextPage.Enabled=false; 
			//} 
			//else 
			//{ 
			//	btnEditRegionFldsNextPage.Enabled=true; 
			//} 
			////7�������沿����ʾ����ʾ �������ǰDataGrid�еļ�¼��Ϊ0������ʾ��ǰ����ҳ������
			//if(objDT.Rows.Count>0) 
			//{ 
			//	this.tabEditRegionFldsJumpPage.Visible = true; 
			//} 
			//else 
			//{ 
			//	this.tabEditRegionFldsJumpPage.Visible = false; 
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
            wucvEditRegionFlds4Gv1.vsPageIndex = 1;
            //�ѱ��¼��������ʾ��GridView��
            BindGv_vEditRegionFlds();
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
			//DispEditEditRegionFldsRegion();
		}

        private void ShowData(string strCtrlId)
        {
            //�������裺
            //1�����ؼ����Ƿ�Ϊ�գ�
            //2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
            //3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
            //4����ȡ�������������ԣ�
            //5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���

            //1�����ؼ����Ƿ�Ϊ�գ�
            //if (lngmId == 0) return;        //����ؼ���Ϊ�վͷ����˳�
            //2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��

            //if (clsEditRegionFldsBL.IsExist(lngmId) == false)       //���ùؼ��ֵļ�¼�Ƿ����
            //{
            //    string ss = "�ؼ���Ϊ��" + lngmId + "�Ĳ�����!";
            //    clsCommonJsFunc.Alert(this, ss);
            //    return;
            //}
            //3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
            string strFldName = clsCtlTypeBLEx.GetFldNameByCtrlId(strCtrlId);
            if (string.IsNullOrEmpty(strFldName) == true)
            {
                string strMsg = string.Format("����[�ؼ�Id:{0}]��ȡ�ֶ���(FldName)���ɹ���", strCtrlId);
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }

            string strCondition = new clsvEditRegionFldsEN()
                .SetFldName(strFldName, "=")
                .SetRegionId(seRegionId, "=")
                .GetCombineCondition();
            long lngMid = clsvEditRegionFldsBL.GetFirstID_S(strCondition);
            if (lngMid == 0)
            {
                string strMsg = string.Format("��������[{0}]��ȡ�ؼ��ֲ��ɹ���", strCondition);
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            clsEditRegionFldsEN objEditRegionFlds = new clsEditRegionFldsEN(lngMid);
            //4����ȡ�������������ԣ�
            clsEditRegionFldsBL.GetEditRegionFlds(ref objEditRegionFlds);
            Session.Add("objEditRegionFlds", objEditRegionFlds);
            //5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���
            GetDataFromEditRegionFldsClass(objEditRegionFlds);
            //DispEditEditRegionFldsRegion();
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


            clsvEditRegionFldsEN objvEditRegionFlds = clsvEditRegionFldsBL.GetFirstObj_S("RegionId = '" + seRegionId + "' and FldId = '" + pobjEditRegionFlds.FldId+"'");
            //         wucEditRegionFlds1.FldName = objvEditRegionFlds.FldName;
            wucEditRegionFlds1.LabelCaption = pobjEditRegionFlds.LabelCaption;

            wucEditRegionFlds1.CtlTypeId = pobjEditRegionFlds.CtlTypeId;
            if (pobjEditRegionFlds.CtlTypeId == enumCtlType.DropDownList_06)
            {
                wucEditRegionFlds1.SetDdl_CallTabFeatureId(pobjEditRegionFlds.FldId, pobjEditRegionFlds.PrjId);
                wucEditRegionFlds1.CallTabFeatureId = pobjEditRegionFlds.CallTabFeatureId;
            }
            wucEditRegionFlds1.VarId = pobjEditRegionFlds.VarId;
            wucEditRegionFlds1.DefaultValue = pobjEditRegionFlds.DefaultValue;

            wucEditRegionFlds1.DdlItemsOptionId = pobjEditRegionFlds.DdlItemsOptionId;
			wucEditRegionFlds1.DsTabId = pobjEditRegionFlds.DsTabId;

            wucEditRegionFlds1.DsCondStr = pobjEditRegionFlds.DsCondStr;
			wucEditRegionFlds1.DsSqlStr = pobjEditRegionFlds.DsSqlStr;
			wucEditRegionFlds1.ItemsString = pobjEditRegionFlds.ItemsString;
			wucEditRegionFlds1.InOutTypeId = pobjEditRegionFlds.InOutTypeId;
            wucEditRegionFlds1.SeqNum = pobjEditRegionFlds.SeqNum ?? 0;
            wucEditRegionFlds1.Width = pobjEditRegionFlds.Width ?? 0;
            wucEditRegionFlds1.ColSpan = pobjEditRegionFlds.ColSpan ?? 0;
            wucEditRegionFlds1.ClickEvent = pobjEditRegionFlds.ClickEvent;
            wucEditRegionFlds1.ChangeEvent = pobjEditRegionFlds.ChangeEvent;

            string strCtrlId = clsCtlTypeBLEx.GetCtrlId(pobjEditRegionFlds.CtlTypeId, objvEditRegionFlds.FldName);
            wucEditRegionFlds1.SetDefaEventName(strCtrlId);
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
					if (clsEditRegionFldsBL.AddNewRecordBySql2(objEditRegionFlds) == false) 
					{
						strMsg = "��Ӳ��ɹ�!";
						clsCommonJsFunc.Alert(this, strMsg);
						lblMsg.Text = "��Ӽ�¼���ɹ�!";
					}
					else
					{
                        clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                        strMsg = "��Ӽ�¼�ɹ�!";
						clsCommonJsFunc.Alert(this, strMsg);
						lblMsg.Text = "��Ӽ�¼�ɹ�!";
					}
					//7��������ļ�¼������ʾ��DATAGRID��
					BindGv_vEditRegionFlds();
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
                        clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                        strMsg = "�޸ļ�¼�ɹ�!";
						clsCommonJsFunc.Alert(this, strMsg);
						lblMsg.Text = "�޸ļ�¼�ɹ�!";
                        hidCtrlId.Value = "";
					}
					//5�����޸ĺ��������ʾ��DATAGRID��
					BindGv_vEditRegionFlds();
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
            pobjEditRegionFlds.LabelCaption = wucEditRegionFlds1.LabelCaption;

            pobjEditRegionFlds.CtlTypeId = wucEditRegionFlds1.CtlTypeId;
            pobjEditRegionFlds.CallTabFeatureId = wucEditRegionFlds1.CallTabFeatureId;

            pobjEditRegionFlds.VarId = wucEditRegionFlds1.VarId;
            pobjEditRegionFlds.DefaultValue = wucEditRegionFlds1.DefaultValue;

            pobjEditRegionFlds.DdlItemsOptionId = wucEditRegionFlds1.DdlItemsOptionId;
			pobjEditRegionFlds.DsTabId = wucEditRegionFlds1.DsTabId;

            pobjEditRegionFlds.DsCondStr = wucEditRegionFlds1.DsCondStr;
			pobjEditRegionFlds.DsSqlStr = wucEditRegionFlds1.DsSqlStr;
			pobjEditRegionFlds.ItemsString = wucEditRegionFlds1.ItemsString;
			pobjEditRegionFlds.InOutTypeId = wucEditRegionFlds1.InOutTypeId;
            pobjEditRegionFlds.SeqNum = wucEditRegionFlds1.SeqNum;
            pobjEditRegionFlds.Width = wucEditRegionFlds1.Width;
            pobjEditRegionFlds.ColSpan = wucEditRegionFlds1.ColSpan;
            pobjEditRegionFlds.ClickEvent = wucEditRegionFlds1.ClickEvent;
            pobjEditRegionFlds.ChangeEvent = wucEditRegionFlds1.ChangeEvent;

            pobjEditRegionFlds.UpdDate = wucEditRegionFlds1.UpdDate;
			pobjEditRegionFlds.UpdUser = UserId;
			pobjEditRegionFlds.Memo = wucEditRegionFlds1.Memo;
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
		protected void btnExportExcel4Dg_Click(object sender, System.EventArgs e)
		{
			//	1����Ͻ�����������
			string strWhereCond = CombinevEditRegionFldsCondition();
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
            List<long> lstMId = wucvEditRegionFlds4Gv1.GetAllCheckedKeysFromGv();
            if (lstMId == null) return;
            lblMsg1.Text = "";
            foreach (long lngmId in lstMId)
            {
                clsEditRegionFldsBL.DelRecord(lngmId);
            }
            clsEditRegionFldsBLEx.ReOrder(seRegionId);
            //clsViewRegionBLEx.SetFldCount(seRegionId);
            //clsViewRegionBLEx.SetFldCountInUse(seRegionId);

            clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            BindGv_vEditRegionFlds();
		}

		
		//��ǰ��¼��
		protected void btnUpdate4Dg_Click(object sender, System.EventArgs e)
		{
            if (string.IsNullOrEmpty( hidCtrlId.Value) == false)
            {
                lblMsg1.Text = "";
                //1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�

                ShowData(hidCtrlId.Value);
                //2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
                clsPubFun.SetButtonEnabled(btnOKUpd, true);
                btnOKUpd.Text = "ȷ���޸�";
                return;
            }
            long lngmId = wucvEditRegionFlds4Gv1.GetFirstCheckedKeyFromGv();
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
            //clsEditRegionFldsBLEx.
            clsEditRegionFldsBLEx.ImportRelaFlds(seRegionId, clsPubVar.CurrCmPrjId, UserId);
            //clsViewRegionBLEx.SetFldCount(seRegionId);
            //clsViewRegionBLEx.SetFldCountInUse(seRegionId);

            clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            BindGv_vEditRegionFlds();
			///�ָ�<ȷ�����>���<���>
			//		lbDispFldList_Click(new object(), new System.EventArgs());
			Response.Write("<script>alert('�������ص������ֶ���Ϣ���Ƴɹ�����')</script>");
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
		
		
		}
		private void DispPrjTabFldsInfo()
		{		
			//tabEditEditRegionFldsRegion.Visible = false;
			tabEditRegionFldsDataGrid.Visible = false;
			
	
			//tabCode.Visible = false;
		}
		private void DispEditEditRegionFldsRegionBak()
		{
			tabEditRegionFldsDataGrid.Visible = false;
			
			//tabEditEditRegionFldsRegion.Visible = true;
			
		}
        	
		protected void btnDownMove_Click(object sender, System.EventArgs e)
		{
			string strMsg;
            long lngmId = wucvEditRegionFlds4Gv1.GetFirstCheckedKeyFromGv();
            if (lngmId == 0) return;
            lblMsg1.Text = "";

			try
			{
				clsEditRegionFldsBLEx.AdjustSequenceNumber("DOWN", lngmId);
                clsEditRegionFldsBL.ReFreshCache(clsPubVar.CurrSelPrjId);
                clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
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
			BindGv_vEditRegionFlds();
            wucvEditRegionFlds4Gv1.SetCheckedItemForGv(lngmId);



        }

        protected void btnUpMove_Click(object sender, System.EventArgs e)
		{
			string strMsg;
            long lngmId = wucvEditRegionFlds4Gv1.GetFirstCheckedKeyFromGv();
            if (lngmId == 0) return;
            lblMsg1.Text = "";
			
			try
			{
				clsEditRegionFldsBLEx.AdjustSequenceNumber("UP", lngmId);
                clsEditRegionFldsBL.ReFreshCache(clsPubVar.CurrSelPrjId);
                clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
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
			BindGv_vEditRegionFlds();
            wucvEditRegionFlds4Gv1.SetCheckedItemForGv(lngmId);

        }

        protected void btnGoFirstLine_Click(object sender, EventArgs e)
        {
            string strMsg;
            long lngmId = wucvEditRegionFlds4Gv1.GetFirstCheckedKeyFromGv();
            if (lngmId == 0) return;
            lblMsg1.Text = "";

            try
            {
                clsEditRegionFldsBLEx.AdjustSequenceNumber("FIRST", lngmId);
                clsEditRegionFldsBL.ReFreshCache(clsPubVar.CurrSelPrjId);
                clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
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
            BindGv_vEditRegionFlds();
            wucvEditRegionFlds4Gv1.SetCheckedItemForGv(lngmId);

        }

        protected void btnGoLastLine_Click(object sender, EventArgs e)
        {
            string strMsg;
            long lngmId = wucvEditRegionFlds4Gv1.GetFirstCheckedKeyFromGv();
            if (lngmId == 0) return;
            lblMsg1.Text = "";

            try
            {
                clsEditRegionFldsBLEx.AdjustSequenceNumber("LAST", lngmId);
                clsEditRegionFldsBL.ReFreshCache(clsPubVar.CurrSelPrjId);
                clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
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
            BindGv_vEditRegionFlds();
            wucvEditRegionFlds4Gv1.SetCheckedItemForGv(lngmId);
        }

		protected void btnReOrder_Click(object sender, System.EventArgs e)
		{
			clsEditRegionFldsBLEx.ReOrder(seRegionId);
            clsEditRegionFldsBL.ReFreshCache(clsPubVar.CurrSelPrjId);
            clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            BindGv_vEditRegionFlds();
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


        protected void btnSetInUse_Click(object sender, EventArgs e)
        {
            List<long> lstMId = wucvEditRegionFlds4Gv1.GetAllCheckedKeysFromGv();
            if (lstMId == null) return;
            lblMsg1.Text = "";
            try
            {
                clsEditRegionFldsBLEx.SetInUse(lstMId, clsCommonSession.UserId);
                clsEditRegionFldsBLEx.ReOrder(seRegionId);
                //clsViewRegionBLEx.SetFldCount(seRegionId);
                //clsViewRegionBLEx.SetFldCountInUse(seRegionId);

                clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                BindGv_vEditRegionFlds();
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
            List<long> lstMId = wucvEditRegionFlds4Gv1.GetAllCheckedKeysFromGv();
            if (lstMId == null) return;
            lblMsg1.Text = "";
            try
            {
                clsEditRegionFldsBLEx.SetNotInUse(lstMId, clsCommonSession.UserId);
                clsEditRegionFldsBLEx.ReOrder(seRegionId);
                //clsViewRegionBLEx.SetFldCount(seRegionId);
                //clsViewRegionBLEx.SetFldCountInUse(seRegionId);

                clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                BindGv_vEditRegionFlds();
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
            BindGv_vEditRegionFlds();
        }
        /// <summary>
        /// �¼�����:��Gv�б�ؼ��У���GeidView�е����޸�ʱ�������¼���
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_Wuc4Gv_GvUpdateClick)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void wucvEditRegionFlds4Gv1_GvUpdateClick(object sender, clsEventArgs4Update e)
        {
            long lngmId = long.Parse(e.KeyId);
            UpdateEditRegionFldsRecord(lngmId);
        }
        /// <summary>
        /// Ϊ�޸ļ�¼��׼������,�Ѹ����ؼ��ֵļ�¼�ֶ�ֵ��ʾ���û��ؼ���
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenUpdateRecordCode)
        /// </summary>
        protected void UpdateEditRegionFldsRecord(long lngmId)
        {
            //��������:(�ܹ�2��)
            //1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
            //2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�

            //1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
            ShowData(lngmId);
            //2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
            btnOKUpd.Enabled = true;
            btnOKUpd.Text = "ȷ���޸�";
            //btnCancelEditRegionFldsEdit.Text = "ȡ���޸�";
            //lblMsgEdit.Text = "";
            //DispEditEditRegionFldsRegion();
        }

        ///
        /// <summary>
        /// �¼�����:��Gv�б�ؼ��У���GeidView�е���ɾ��ʱ�������¼���
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_Wuc4Gv_GvDeleteClick)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void wucvEditRegionFlds4Gv1_GvDeleteClick(object sender, clsEventArgs4Delete e)
        {
            long lngmId = long.Parse(e.KeyId);
            DeleteEditRegionFldsRecord(lngmId);
        }
        /// <summary>
        /// ���ݸ����ؼ���ɾ����¼
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDelRecordCode)
        /// </summary>
        /// <param name = "lngmId">�����ؼ���</param>
        protected void DeleteEditRegionFldsRecord(long lngmId)
        {
            try
            {
                clsEditRegionFldsBL.DelRecord(lngmId);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000022)ɾ����¼���ɹ�!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsg1.Text = strMsg;
                return;
            }
            BindGv_vEditRegionFlds();
        }

        /// <summary>
        /// ��������:�Ѳ�ѯ���ݰ���GridView�ϡ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼,
        ///			 ����ʾ��GridView�С�
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenBindGridView4WucInPage)
        /// </summary>
        protected void BindGv_vEditRegionFlds()
        {
            try
            {
                wucEditRegion4Preview1.ShowControl4Regoin(seRegionId, clsPubVar.CurrSelPrjId, chkInUse.Checked, chkIsDisp.Checked);
                //	3������Gv�ؼ���ĳЩ�в��ɼ���

                //wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.UpdUser, false);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000119)���ӻ���ʾ����������!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            //��������:(��5��)
            //	1����Ͻ�����������
            //	2�����ÿؼ��еİ�GridView����;
            //	3������Gv�ؼ���ĳЩ�в��ɼ�;

            try
            {
                //	1����Ͻ�����������
                string strWhereCond = CombinevEditRegionFldsCondition();
                //	2�����ÿؼ��еİ�GridView������
                wucvEditRegionFlds4Gv1.SetSortBy_Prev(string.Format("{0} desc", convEditRegionFlds.InUse));
                wucvEditRegionFlds4Gv1.SetSortBy(string.Format("{0}", convEditRegionFlds.SeqNum));

                wucvEditRegionFlds4Gv1.BindGv_EditRegionFlds(strWhereCond);
                //	3������Gv�ؼ���ĳЩ�в��ɼ���
                wucvEditRegionFlds4Gv1.SetGvVisibility(convEditRegionFlds.TabName, false);
                wucvEditRegionFlds4Gv1.SetGvVisibility(convEditRegionFlds.CtlTypeName, true);
                wucvEditRegionFlds4Gv1.SetGvVisibility(convEditRegionFlds.LabelCaption, false);
                wucvEditRegionFlds4Gv1.SetGvVisibility(convEditRegionFlds.ColIndex, false);
                wucvEditRegionFlds4Gv1.SetGvVisibility(convEditRegionFlds.SeqNum, true);

                wucvEditRegionFlds4Gv1.SetGvVisibility(convEditRegionFlds.TabName, false);
                wucvEditRegionFlds4Gv1.SetGvVisibility("�޸�", false);
                wucvEditRegionFlds4Gv1.SetGvVisibility("ɾ��", false);
                wucvEditRegionFlds4Gv1.SetGvVisibility(convEditRegionFlds.InUse, false);

                //wucvEditRegionFlds4Gv1.SetGvVisibility(convEditRegionFlds.UpdUser, false);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000019)��GridView����!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
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
            //litCode.Text = sbJs.ToString();
        }

        protected void btnCancelEditRegionFldsEdit_Click(object sender, EventArgs e)
        {
            DispEditRegionFldsInfo();
        }
                
        protected void btnSetColNum_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtColNum.Text) == true)
            {
                clsCommonJsFunc.Alert(this, "������������");
                txtColNum.Focus();
                return;
            }
            int intColNum = int.Parse(txtColNum.Text);
            if (ddlPageDispModeId.SelectedIndex <= 0)
            {
                clsCommonJsFunc.Alert(this, "������ҳ����ʾģʽ��");
                ddlPageDispModeId.Focus();
                return;
            }
            string strPageDispModeId = ddlPageDispModeId.SelectedValue;
            if (ddlContainerTypeId.SelectedIndex <= 0)
            {
                clsCommonJsFunc.Alert(this, "������ؼ��������ͣ�");
                ddlContainerTypeId.Focus();
                return;
            }
            string strContainerTypeId = ddlContainerTypeId.SelectedValue;



            if (string.IsNullOrEmpty(txtWidth.Text) == false)
            {
                try
                {
                    int intWidth = int.Parse(txtWidth.Text);
                    clsViewRegionEN objViewRegion = clsViewRegionBL.GetObjByRegionId(seRegionId);
                    if (string.IsNullOrEmpty(txtWidth.Text) == false)
                    {
                        objViewRegion.SetWidth(intWidth)
                                    .SetColNum(intColNum)
                                .SetPageDispModeId(strPageDispModeId)
                                      .SetContainerTypeId(strContainerTypeId)
                                 .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                .SetUpdUser(clsCommonSession.UserId)
                .Update();
                        clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                    }
                }
                catch (Exception objException)
                {
                    clsPubVar.objLog.WriteDebugLog(objException.Message);

                }
            }
       
            try
            {
                wucEditRegion4Preview1.ShowControl4Regoin(seRegionId, clsPubVar.CurrSelPrjId, chkInUse.Checked, chkIsDisp.Checked);
                //	3������Gv�ؼ���ĳЩ�в��ɼ���

                //wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.UpdUser, false);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000219)���ӻ���ʾ����������!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
        }

        protected void btnSetColSpan_Click(object sender, EventArgs e)
        {
            List<long> lstMId = wucvEditRegionFlds4Gv1.GetAllCheckedKeysFromGv();
            if (lstMId == null) return;
            if (string.IsNullOrEmpty(txtColSpan.Text) == true)
            {
                clsCommonJsFunc.Alert(this, "�������������");
                txtColSpan.Focus();
                return;
            }
            int intColSpan = int.Parse(txtColSpan.Text);

            lblMsg1.Text = "";
            try
            {
                clsEditRegionFldsBLEx.SetColSpan(lstMId, intColSpan, clsCommonSession.UserId);
                clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                BindGv_vEditRegionFlds();
            }
            catch (Exception objException)
            {
                string strMsg = objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsg1.Text = strMsg;
            }
            try
            {
                wucEditRegion4Preview1.ShowControl4Regoin(seRegionId, clsPubVar.CurrSelPrjId, chkInUse.Checked, chkIsDisp.Checked);
                //	3������Gv�ؼ���ĳЩ�в��ɼ���
                //wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.UpdUser, false);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000219)���ӻ���ʾ����������!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
        }

        protected void btnSetMultiLine_Click(object sender, EventArgs e)
        {
            List<long> lstMId = wucvEditRegionFlds4Gv1.GetAllCheckedKeysFromGv();
            if (lstMId == null) return;
            lblMsg1.Text = "";
            try
            {
                clsEditRegionFldsBLEx.SetInUse(lstMId, clsCommonSession.UserId);
                clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                BindGv_vEditRegionFlds();
            }
            catch (Exception objException)
            {
                string strMsg = objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsg1.Text = strMsg;
            }
        }

        protected void btnSetWidth_Click(object sender, EventArgs e)
        {
            List<long> lstMId = wucvEditRegionFlds4Gv1.GetAllCheckedKeysFromGv();
            if (lstMId == null) return;
            if (string.IsNullOrEmpty(txtCtrlWidth.Text) == true)
            {
                clsCommonJsFunc.Alert(this, "������ؼ���ȣ�");
                txtColSpan.Focus();
            }
            int intWidth = int.Parse(txtCtrlWidth.Text);

            lblMsg1.Text = "";
            try
            {
                clsEditRegionFldsBLEx.SetWidth(lstMId, intWidth, clsCommonSession.UserId);
                clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                BindGv_vEditRegionFlds();
            }
            catch (Exception objException)
            {
                string strMsg = objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsg1.Text = strMsg;
            }
            try
            {
                wucEditRegion4Preview1.ShowControl4Regoin(seRegionId, clsPubVar.CurrSelPrjId, chkInUse.Checked, chkIsDisp.Checked);
                //	3������Gv�ؼ���ĳЩ�в��ɼ���
                //wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.UpdUser, false);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000219)���ӻ���ʾ����������!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
        }
        private void ShowCodeTypeButton()
        {
            pnlCodeTypeLst.Controls.Clear();
            //clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(clsCommonSession.ViewId, clsPubVar.CurrSelPrjId);
            int intAppTypeId = clsCommonSession.ApplicationTypeId;

            clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(clsCommonSession.ViewId, clsPubVar.CurrSelPrjId);


            List<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                            clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(enumFunctionTemplate.RegionFunctionSet_0004,
                            "",
                            enumRegionType.EditRegion_0003)
                            .OrderBy(x => x.OrderNum).ToList();

            //������-������صĺ���

            int intCount4 = arrvFunction4GeneCodeObjLst.Count();

            clsvApplicationTypeEN objvApplicationTypeEN = clsvApplicationTypeBL.GetObjByApplicationTypeIdCache(intAppTypeId);
            string strCharEncodingId = objvApplicationTypeEN.CharEncodingId;
            //cboCharEncodingId.SelectedValue = strCharEncodingId;
            //string strCondition = string.Format("{0}={1} order by {2}",
            //    clsAppCodeTypeRelaEN.con_ApplicationTypeId, intAppTypeId, clsAppCodeTypeRelaEN.con_OrderNum);
            List<clsvAppCodeTypeRelaENEx> arrObjLst = clsvAppCodeTypeRelaBLEx.GetObjExLstByApplicationTypeIdExCache(intAppTypeId)
                .OrderBy(x => x.GroupName).ThenBy(x => x.OrderNum)
                .ToList();

            int intCount = 0;
            //string strGroupName = "";
            IEnumerable<clsvAppCodeTypeRelaENEx> arrObjLst_V2 = arrObjLst.Where(x => x.DependsOn == "View");
            //if (vsvViewRegion != null)
            //{
            //    arrObjLst_V2 = arrObjLst_V2.Where(x => x.RegionTypeId == vsvViewRegion.RegionTypeId).OrderBy(x => x.OrderNum);
            //}
            List<string> arrGroupName = arrObjLst_V2.Select(x => x.GroupName).Distinct().ToList();
            bool bolIsFirst = true;
            Label objLabel = null;
            foreach (string strGroupName in arrGroupName)
            {
                IEnumerable<clsvAppCodeTypeRelaENEx> arrObjLst_Sel =
                    arrObjLst_V2.Where(x => x.GroupName == strGroupName);
                IEnumerable<string> arrCodeTypeId = arrObjLst_Sel.Select(x => x.CodeTypeId);
                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst_Sel1 =
                   arrvFunction4GeneCodeObjLst.Where(x => arrCodeTypeId.Contains(x.FuncCodeTypeId));

                if (arrvFunction4GeneCodeObjLst_Sel1.Count() == 0)
                {
                    continue;
                }
                if (string.IsNullOrEmpty(strGroupName) == false)
                {
                    if (bolIsFirst == false)
                    {
                        Label objLabel_Br = new Label();
                        objLabel_Br.Text = string.Format("<br/>", strGroupName);
                        //objLabel.AutoSize = true;
                        pnlCodeTypeLst.Controls.Add(objLabel_Br);
                    }
                    else
                    {
                        bolIsFirst = false;
                    }
                    objLabel = new Label();
                    objLabel.Text = string.Format("{0}: ", strGroupName);
                    //objLabel.AutoSize = true;
                    objLabel.ID = string.Format("lbl{0}", strGroupName);
                    //string strToolTip = string.Format("���ɣ�[{0}({1})({2})]�Ĵ��롣", objInFor.CodeTypeName, objInFor.CodeTypeId, objInFor.ProgLangTypeId4CodeType);
                    //toolTip1.SetToolTip(objLabel, strToolTip);                    
                    objLabel.CssClass = "text-secondary font-weight-bold";
                    objLabel.Attributes["Style"] = "margin-right:10px;margin-top:35px;left:0px;min-width:150px;";
                    pnlCodeTypeLst.Controls.Add(objLabel);
                }
                foreach (clsvAppCodeTypeRelaENEx objInFor in arrObjLst_V2)
                {
                    if (objInFor.GroupName != strGroupName) continue;
                    List<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst_Sel =
                        arrvFunction4GeneCodeObjLst.Where(x => x.FuncCodeTypeId == objInFor.CodeTypeId).ToList();
           
                    foreach (clsvFunction4GeneCodeEN objvFunction4GeneCode in arrvFunction4GeneCodeObjLst_Sel)
                    {
                        HtmlInputButton objHtmlInputButton = new HtmlInputButton();
                        objHtmlInputButton.ID = string.Format("btn{0}_{1}", objInFor.CodeTypeId, objvFunction4GeneCode.FuncId4GC);

                        objHtmlInputButton.Name = string.Format("btn{0}_{1}", objInFor.CodeTypeId, objvFunction4GeneCode.FuncId4GC);
                        objHtmlInputButton.Attributes["class"] = "btn btn-outline-primary btn-sm";
                        objHtmlInputButton.Value = string.Format("{0}-{1}({2})",
                            objInFor.CodeTypeName, objvFunction4GeneCode.FuncCHName4Code,
                            objInFor.ProgLangTypeName);

                        objHtmlInputButton.Attributes.Add("onclick", string.Format("GeneCode4Func('{0}','{1}','{2}','{3}')",
                            objInFor.CodeTypeId, clsCommonSession.ViewId, objvFunction4GeneCode.FuncId4GC, intAppTypeId));

                        //objButton.Attributes["Style"] = "margin-right:10px;margin-top:5px;left:0px;";

                        //objButton.Command += new CommandEventHandler(this.btnCodeType_Click);
                        pnlCodeTypeLst.Controls.Add(objHtmlInputButton);
                        intCount++;
                    }
                }

            }
            if (intCount == 0)
            {
                string strMsg = string.Format("Ӧ��:{0}({1})û������[View]��Ӧ�Ĵ�������.(In {2})",
                    objvApplicationTypeEN.ApplicationTypeName, objvApplicationTypeEN.ApplicationTypeId, clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
        }

        [WebMethod]
        public static string GeneCode4Func(string strCodeTypeId, string strTabId, string strFuncId, string strViewId, string strCmPrjId, int intApplicationTypeId)
        {

            if (strCodeTypeId.StartsWith("C"))
            {
                strCodeTypeId = strCodeTypeId.Substring(1);
            }
            //clsPubVar.CurrSelPrjId = "0116";
            //clsPubVar.CurrPrjDataBaseId = "0111";

            clsCodeTypeEN objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(strCodeTypeId);
            //clsPubConst.ClassName cnClassName = clsPubConst.GetClassNameByString(objCodeType.CodeTypeENName);
            ////clsProgLangTypeEN objProgLangType = clsProgLangTypeBL.GetObjByProgLangTypeIdCache(strProgLangTypeId);
            //clsPubConst.LangType ltLangType = clsPubConst.GetLangTypeByString(clsProgLangTypeBL.GetNameByProgLangTypeIdCache(objCodeType.ProgLangTypeId));
            try
            {
                //   string strCharEncodingId = clsPubFun.GetCharEncodingIdByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);

                //string strViewId = "";
                string strRe_ClsName = "";

                string strRe_FileNameWithModuleName = "";

                //string strCodeText1 = AutoGC.GeneCode4Func(strCodeTypeId, strFuncId4GC, clsPubConst.DataBaseType.MsSql, strTabId,
                //    strViewId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, intApplicationTypeId, clsCommonSession.UserId, ref strRe_ClsName,
                //    ref strRe_FileNameWithModuleName);
                //string str
                var Re_objFunction4Code = new clsFunction4CodeEN();
                string strCodeText = AutoGC.GeneCode4Func(strCodeTypeId, strFuncId, clsPubConst.DataBaseType.MsSql, strTabId,
               strViewId, strCmPrjId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, clsCommonSession.UserId, ref strRe_ClsName,
               ref strRe_FileNameWithModuleName, ref Re_objFunction4Code);

                //txtFileName4GenCode.Text = strRe_ClsName;
                //ShowCode(strCodeText);
                clsGCType objGCType = new clsGCType();
                objGCType.Code = strCodeText;
                objGCType.ClsName = strRe_ClsName;
                objGCType.FileName = strRe_FileNameWithModuleName;
                return clsJSON.GetJsonFromObj(objGCType);
                //                return strCodeText;
            }
            catch (Exception objException)
            {
                //lblMsg.Text = objException.Message;
                //clsCommonJsFunc.Alert(this, objException.Message);
                return objException.Message;
                //clsCommonJsFunc.Alert(this, objException.Message);
            }
            //return strCodeText;
        }

        protected void chkInUse_CheckedChanged(object sender, EventArgs e)
        {
           
            bool bolInUse = chkInUse.Checked;
            clsViewRegionRelaEN obj = clsViewRegionRelaBLEx.GetObjByViewIdAndRegionIdCache(clsCommonSession.ViewId, seRegionId, clsPubVar.CurrCmPrjId, clsPubVar.CurrSelPrjId);
            obj.SetInUse(bolInUse)
                .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                .SetUpdUser(clsCommonSession.UserId)
                .Update();
            try
            {
                wucEditRegion4Preview1.ShowControl4Regoin(seRegionId, clsPubVar.CurrSelPrjId, chkInUse.Checked, chkIsDisp.Checked);
                //	3������Gv�ؼ���ĳЩ�в��ɼ���

                //wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.UpdUser, false);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000219)���ӻ���ʾ����������!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
        }

        protected void btnSetClassName_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClassName.Text) == true)
            {
                clsCommonJsFunc.Alert(this, "������������");
                txtClassName.Focus();
            }
            if (string.IsNullOrEmpty(txtFileName.Text) == true)
            {
                clsCommonJsFunc.Alert(this, "�������ļ�����");
                txtFileName.Focus();
            }
            string strClassName = txtClassName.Text;
            string strFileName = txtFileName.Text;
            try
            {
                clsViewRegionEN obj = clsViewRegionBL.GetObjByRegionId(seRegionId);
            obj.SetClsName(strClassName)
                //.SetFileName(strFileName)
                .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                .SetUpdUser(clsCommonSession.UserId)
                .Update();
                clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                //wucViewRegion4Preview1.ShowControl4Regoin(seRegionId, clsPubVar.CurrSelPrjId);
                //	3������Gv�ؼ���ĳЩ�в��ɼ���

                //wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.UpdUser, false);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000219)���ӻ���ʾ����������!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
        }

        protected void txtClassName_TextChanged(object sender, EventArgs e)
        {
            
            int intApplicationTypeId = vsApplicationTypeId;
            switch (intApplicationTypeId)
            {
                case (int)enumApplicationType.WinApp_1:
                    txtFileName.Text = txtClassName.Text.Trim().ToString() + ".cs";

                    break;
                case (int)enumApplicationType.WebApp_2:

                    txtFileName.Text = txtClassName.Text.Trim().ToString() + ".aspx";

                    break;
                case (int)enumApplicationType.AndroidApp_5://                        enumApplicationType.AndroidApp_5
                    txtFileName.Text = txtClassName.Text.Trim().ToString() + ".xml";

                    break;
                case (int)enumApplicationType.WebApp_JS_RJ_28://                        enumApplicationType.AndroidApp_5
                    txtFileName.Text = txtClassName.Text.Trim().ToString() + ".html";

                    break;
                case (int)enumApplicationType.SpaAppInCore_TS_18://                        enumApplicationType.AndroidApp_5
                    txtFileName.Text = txtClassName.Text.Trim().ToString() + ".cshtml";

                    break;
                case (int)enumApplicationType.VueAppInCore_TS_30://                        enumApplicationType.AndroidApp_5
                    txtFileName.Text = txtClassName.Text.Trim().ToString() + ".vue";

                    break;
                default:
                    string strMsg = string.Format("Ӧ��:{0}�ں�����û�б�����", clsApplicationTypeBL.GetNameByApplicationTypeIdCache(intApplicationTypeId));
                    clsCommonJsFunc.Alert(this, strMsg);
                    break;
            }
            try
            {
                wucEditRegion4Preview1.ShowControl4Regoin(seRegionId, clsPubVar.CurrSelPrjId, chkInUse.Checked, chkIsDisp.Checked);
                //	3������Gv�ؼ���ĳЩ�в��ɼ���

                //wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.UpdUser, false);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000219)���ӻ���ʾ����������!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
        }
        /// <summary>
        /// Sql��������Id�� ������01����02:��ͼ��
        /// </summary>
        public int vsApplicationTypeId
        {
            get
            {
                string strApplicationTypeId;
                strApplicationTypeId = (string)ViewState["ApplicationTypeId"];
                if (strApplicationTypeId == null)
                {
                    return 0;
                }
                return int.Parse( strApplicationTypeId);
            }
            set
            {
                string strApplicationTypeId = value.ToString();
                ViewState.Add("ApplicationTypeId", strApplicationTypeId);
            }
        }
        protected string vsViewId
        {
            get
            {
                string sViewId;
                sViewId = (string)ViewState["ViewId"];
                if (sViewId == null)
                {
                    sViewId = "";
                }
                return sViewId;
            }
            set
            {
                string sViewId = value;
                ViewState.Add("ViewId", sViewId);
            }
        }

        protected bool vsInUse
        {
            get
            {
                string sInUse;
                sInUse = (string)ViewState["InUse"];
                if (sInUse == null)
                {
                  return false;
                }
                return bool.Parse( sInUse);
            }
            set
            {
                string sInUse = value.ToString();
                ViewState.Add("InUse", sInUse);
            }
        }

        protected bool vsIsDisp
        {
            get
            {
                string sIsDisp;
                sIsDisp = (string)ViewState["IsDisp"];
                if (sIsDisp == null)
                {
                    return false;
                }
                return bool.Parse(sIsDisp);
            }
            set
            {
                string sIsDisp = value.ToString();
                ViewState.Add("IsDisp", sIsDisp);
            }
        }

        protected void btnCopyFromOtherView_Click(object sender, EventArgs e)
        {
            if (ddlViewId.SelectedIndex <= 0)
            {
                clsCommonJsFunc.Alert(this, "��ѡ��һ��Ҫ���Ƶ�ҳ�棡");
                ddlViewId.Focus();
                return;
            }
            string strViewId_S = ddlViewId.SelectedValue;
            List<clsViewRegionEN> arrViewRegionObjLst = clsViewRegionBLEx.GetObjLstByViewIdCache(strViewId_S, clsPubVar.CurrSelPrjId);
            List<string> arrRegionId = arrViewRegionObjLst
                .Where(x=>x.RegionTypeId == enumRegionType.EditRegion_0003)
                .Select(x => x.RegionId).ToList();
            if (arrRegionId.Count ==0)
            {
                var objViewInfoEN = clsViewInfoBL.GetObjByViewIdCache(strViewId_S, clsPubVar.CurrSelPrjId);
                clsCommonJsFunc.Alert(this, string.Format("��ѡ���棺[{0}]û�б༭����", objViewInfoEN.ViewName));
                ddlViewId.Focus();
                return;
            }
            clsEditRegionFldsBLEx.CopyTo1(arrRegionId[0], seRegionId, clsPubVar.CurrCmPrjId, clsCommonSession.UserId);
            BindGv_vEditRegionFlds();
        }
        protected void chkIsDisp_CheckedChanged(object sender, EventArgs e)
        {

            bool bolIsDisp = chkIsDisp.Checked;
            clsViewRegionRelaEN obj = clsViewRegionRelaBLEx.GetObjByViewIdAndRegionIdCache(clsCommonSession.ViewId, seRegionId, clsPubVar.CurrCmPrjId, clsPubVar.CurrSelPrjId);
            obj.SetIsDisp(bolIsDisp)
                .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                .SetUpdUser(clsCommonSession.UserId)
                .Update();
            try
            {
                wucEditRegion4Preview1.ShowControl4Regoin(seRegionId, clsPubVar.CurrSelPrjId, chkInUse.Checked, chkIsDisp.Checked);
                //	3������Gv�ؼ���ĳЩ�в��ɼ���

                //wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.UpdUser, false);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000219)���ӻ���ʾ����������!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
        }
    }
}