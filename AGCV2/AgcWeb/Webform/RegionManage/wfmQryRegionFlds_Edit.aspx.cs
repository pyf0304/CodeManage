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

namespace AGC.Webform
{
    /// <summary>
    /// wfmQryRegionFlds_QUDI ��ժҪ˵��������Q�����ѯ��U�����޸�
    /// </summary>
    public partial class wfmQryRegionFlds_Edit : CommWebPageBase
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
                try
                {
                    clsGCContainerTypeBL.BindDdl_ContainerTypeIdCache(ddlContainerTypeId);
                }
                catch (Exception objException)
                {
                    string strSS = objException.Message;
                }
                if (string.IsNullOrEmpty(getRegionId) == true)
                {
                    return;
                }
                clsViewRegionEN objViewRegionEN = clsViewRegionBL.GetObjByRegionIdCache(getRegionId, clsPubVar.CurrSelPrjId);
                if (objViewRegionEN != null)
                {
                    vsApplicationTypeId = 0;// objViewRegionEN.ApplicationTypeId;
                    vsInOutTypeId = objViewRegionEN.InOutTypeId;
                    ddlContainerTypeId.SelectedValue = objViewRegionEN.ContainerTypeId;
                    wucQryRegionFlds1.SetDdl_FldId(objViewRegionEN.TabId);


                }
                //1��Ϊ��������������Դ�����б�����
                if (vsApplicationTypeId == (int)enumApplicationType.IOSApp_6 
                    || vsApplicationTypeId == (int)enumApplicationType.IOSApp_WA_22)
                {
                    wucQryRegionFlds1.SetDdl_CtlTypeId(true);
                }
                else
                {
                    wucQryRegionFlds1.SetDdl_CtlTypeId(false);
                }
                wucQryRegionFlds1.SetDdl_DdlItemsOptionId();
                wucQryRegionFlds1.SetDdl_DsTabId(clsPubVar.CurrSelPrjId);
                wucQryRegionFlds1.SetDdl_QueryOptionId();
                wucQryRegionFlds1.SetDdl_VarId(clsPubVar.CurrSelPrjId);
               
                strSortQryRegionFldsBy = "SeqNum Asc";
           
            


                //2����ʾ�������ı�������DATAGRID��
                ///
             

                txtColNum.Text = objViewRegionEN.ColNum.ToString();

                txtWidth.Text = objViewRegionEN.Width.ToString();
                
                BindGv_vQryRegionFlds();
					
				//3�����ñ�ؼ����ֿؼ���ReadOnly���ԣ�
				//   ʹֻ֮������Ϊ���޸Ĺ����йؼ����ǲ��ܱ��޸ĵġ�
			}
            try
            {
                wucQryRegion4Preview1.ShowControl4Regoin(getRegionId, clsPubVar.CurrSelPrjId, true,true);
                //	3������Gv�ؼ���ĳЩ�в��ɼ���

                //wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.UpdUser, false);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000219)���ӻ���ʾ����������!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            ShowCodeTypeButton();
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
		private string CombinevQryRegionFldsCondition()
		{
			//ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
			//���� 1=1 && UserName = '����'
            string strWhereCond = " 1=1 and RegionId = '" + getRegionId + "'";
            if (chkOnlyShowFldInUse.Checked == true)
            {
                strWhereCond += string.Format(" And {0}='1'", conQryRegionFlds.InUse);
            }

            return strWhereCond;
		}
		///���ɰ�DATAGRID�Ĵ���
		/// <summary>
		/// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
		///			 ����ʾ��DATAGRID�С�
		/// </summary>
		private void BindDg_QryRegionFldsBak()
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
			string strWhereCond = CombinevQryRegionFldsCondition();
			//	2��������������ȡ�ñ�����������DataTable��
			System.Data.DataTable objDT = clsvQryRegionFldsBL.GetDataTable(strWhereCond  + " order by SeqNum" );

            if (vsInOutTypeId == "02")//��ͼ
            {
                clsQryRegionFldsBLEx.AddColumn_SourceTabName(ref objDT);
            }
            else
            {
                objDT.Columns.Add("SourceTabName");
            }
            //	3�����DATAGRID�ĵ�ǰҳ���Ƿ񳬳�DATAGRID��ҳ����Χ
			//		3.1 ���ȼ���ҳ����
			//		3.2 �����ǰҳ����ҳ����Ϊ���һҳ
			//int intPages = CalcPages(objDT.Rows.Count, this.dgQryRegionFlds.PageSize);
			//if (intPages==0) 
			//{
			//	this.dgQryRegionFlds.CurrentPageIndex = 0;
			//}
			//else if (this.dgQryRegionFlds.CurrentPageIndex > intPages - 1) 
			//{
			//	this.dgQryRegionFlds.CurrentPageIndex = intPages - 1;
			//}
			////	4������DATAGRID������Դ(DataSource)��
			//DataView objDV = objDT.DefaultView;
			//objDV.Sort = strSortQryRegionFldsBy;     ///ע����һ�д����п�����Ҫע�͵���Ŀǰ���н����ڵ����Ĳ�ѯ������������
			//this.dgQryRegionFlds.DataSource=objDV;
			////	5����DATAGRID������DataTable��������ʾ��DATAGRID��
			//this.dgQryRegionFlds.DataBind();

			
			////��ǰ��¼��
			//this.lblQryRegionFldsRecCount.Text = objDT.Rows.Count.ToString(); 
			////��ǰҳ��
			//this.lblQryRegionFldsAllPages.Text = this.dgQryRegionFlds.PageCount.ToString(); 
			////��ǰҳ����
			//this.lblQryRegionFldsCurrentPage.Text=(this.dgQryRegionFlds.CurrentPageIndex+1).ToString();
			////��ǰ����������ҳ����
			//this.txtQryRegionFldsJump2Page.Text=(this.dgQryRegionFlds.CurrentPageIndex+1).ToString();
			////�����ǰҳ����Ϊ0����<ǰһҳ>��ť��Ч
			//if(this.dgQryRegionFlds.CurrentPageIndex==0) 
			//{
			//	btnQryRegionFldsPrevPage.Enabled=false; 
			//}
			//else 
			//{ 
			//	btnQryRegionFldsPrevPage.Enabled=true; 
			//} 
			////�����ǰҳ������Ϊ���һҳ����<ǰһҳ>��ť��Ч
			//if(this.dgQryRegionFlds.CurrentPageIndex==this.dgQryRegionFlds.PageCount-1) 
			//{ 
			//	btnQryRegionFldsNextPage.Enabled=false; 
			//} 
			//else 
			//{ 
			//	btnQryRegionFldsNextPage.Enabled=true; 
			//} 
			////7�������沿����ʾ����ʾ �������ǰDataGrid�еļ�¼��Ϊ0������ʾ��ǰ����ҳ������
			//if(objDT.Rows.Count>0) 
			//{ 
			//	this.tabQryRegionFldsJumpPage.Visible = true; 
			//} 
			//else 
			//{ 
			//	this.tabQryRegionFldsJumpPage.Visible = false; 
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

            //��GridView�ĵ�ǰҳ��������Ϊ0,����1ҳ��
            //��������ѯʱ,������ʾ���Ǳ��¼���ݵĵ�һ�������ݡ�
            wucvQryRegionFlds4Gv1.vsPageIndex = 1;
            //�ѱ��¼��������ʾ��GridView��
            BindGv_vQryRegionFlds();
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
			//DispEditQryRegionFldsRegion();
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

            clsvQryRegionFldsEN objvQryRegionFlds = clsvQryRegionFldsBL.GetFirstObj_S("RegionId = '" + getRegionId + "' and FldId = '" + pobjQryRegionFlds.FldId+"'");
            //wucQryRegionFlds1.FldName = objvQryRegionFlds.FldName;

            wucQryRegionFlds1.LabelCaption = pobjQryRegionFlds.LabelCaption;
            wucQryRegionFlds1.CtlTypeId = pobjQryRegionFlds.CtlTypeId;
            wucQryRegionFlds1.VarId = pobjQryRegionFlds.VarId;
            wucQryRegionFlds1.DdlItemsOptionId = pobjQryRegionFlds.DdlItemsOptionId;
			wucQryRegionFlds1.DsTabId = pobjQryRegionFlds.DsTabId;

            wucQryRegionFlds1.DsCondStr = pobjQryRegionFlds.DsCondStr;
			wucQryRegionFlds1.DsSqlStr = pobjQryRegionFlds.DsSqlStr;
			wucQryRegionFlds1.ItemsString = pobjQryRegionFlds.ItemsString;
            wucQryRegionFlds1.SeqNum = pobjQryRegionFlds.SeqNum ?? 0;
            wucQryRegionFlds1.Width = pobjQryRegionFlds.Width ?? 0;
            wucQryRegionFlds1.ColSpan = pobjQryRegionFlds.ColSpan ?? 0;
            wucQryRegionFlds1.ClickEvent = pobjQryRegionFlds.ClickEvent;
            wucQryRegionFlds1.ChangeEvent = pobjQryRegionFlds.ChangeEvent;

            wucQryRegionFlds1.Memo = pobjQryRegionFlds.Memo;
			wucQryRegionFlds1.QueryOptionId = pobjQryRegionFlds.QueryOptionId;
            string strCtrlId = clsCtlTypeBLEx.GetCtrlId(pobjQryRegionFlds.CtlTypeId, objvQryRegionFlds.FldName);
            wucQryRegionFlds1.SetDefaEventName(strCtrlId);
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
					BindGv_vQryRegionFlds();
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
					BindGv_vQryRegionFlds();
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

            pobjQryRegionFlds.LabelCaption = wucQryRegionFlds1.LabelCaption;
            pobjQryRegionFlds.CtlTypeId = wucQryRegionFlds1.CtlTypeId;
            pobjQryRegionFlds.VarId = wucQryRegionFlds1.VarId;
            pobjQryRegionFlds.DdlItemsOptionId = wucQryRegionFlds1.DdlItemsOptionId;
			pobjQryRegionFlds.DsTabId = wucQryRegionFlds1.DsTabId;

            pobjQryRegionFlds.DsCondStr = wucQryRegionFlds1.DsCondStr;
			pobjQryRegionFlds.DsSqlStr = wucQryRegionFlds1.DsSqlStr;
			pobjQryRegionFlds.ItemsString = wucQryRegionFlds1.ItemsString;
            pobjQryRegionFlds.SeqNum = wucQryRegionFlds1.SeqNum;
            pobjQryRegionFlds.Width = wucQryRegionFlds1.Width;
            pobjQryRegionFlds.ColSpan = wucQryRegionFlds1.ColSpan;
            pobjQryRegionFlds.InUse = true;
            pobjQryRegionFlds.RegionId = qsRegionId;
            pobjQryRegionFlds.PrjId = clsPubVar.CurrSelPrjId;

            pobjQryRegionFlds.UpdDate = wucQryRegionFlds1.UpdDate;
			pobjQryRegionFlds.UpdUser = wucQryRegionFlds1.UserId;
			pobjQryRegionFlds.Memo = wucQryRegionFlds1.Memo;
			pobjQryRegionFlds.QueryOptionId = wucQryRegionFlds1.QueryOptionId;
            pobjQryRegionFlds.ClickEvent = wucQryRegionFlds1.ClickEvent;
            pobjQryRegionFlds.ChangeEvent = wucQryRegionFlds1.ChangeEvent;
        }

	
		//protected void dgQryRegionFlds_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		//{
		//	long lngmId;
		//	string strCommandName;
		//	if (e.Item.ItemType == ListItemType.Item ||
		//		e.Item.ItemType == ListItemType.SelectedItem ||
		//		e.Item.ItemType == ListItemType.AlternatingItem ||
		//		e.Item.ItemType == ListItemType.EditItem)
		//	{
		//		strCommandName = ((LinkButton)e.CommandSource).CommandName;
		//		lngmId = long.Parse(e.Item.Cells[1].Text);
		//		switch(strCommandName)
		//		{
		//			case "Delete":
		//				clsQryRegionFldsBL.DelRecord(lngmId);
		//				BindGv_vQryRegionFlds();
		//				break;
		//				// Add other cases here, if there are multiple ButtonColumns in 
		//				// the DataGrid control.
		//			case "Update":
		//				//�������裺���ܹ�2����
		//				//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
		//				//2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�

		//				//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
		//				tabEditQryRegionFldsRegion.Visible = true;
		//				ShowData(lngmId);
		//				//2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
		//				clsPubFun.SetButtonEnabled(btnOKUpd, true);
		//				btnOKUpd.Text = "ȷ���޸�";
		//				lblMsg.Text = "";
		//				break;

		//			default:
		//				// Do nothing.
		//				break;
		//		}
		//	}
		//	if (e.Item.ItemType == ListItemType.Header)
		//	{
		//		System.Web.UI.WebControls.LinkButton lbSelAll;
		//		lbSelAll = (LinkButton)e.CommandSource;
		//		if (lbSelAll.CommandName != "lbSelAll")
		//		{
		//			return ;
		//		}
		//		if (lbSelAll.Text == "ȫѡ")
		//		{
		//			Set_DataGridAllChecked(dgQryRegionFlds, true);
		//			lbSelAll.Text = "��ѡ";
		//		}
		//		else if (lbSelAll.Text == "��ѡ")
		//		{
		//			Set_DataGridAllChecked(dgQryRegionFlds, false);
		//			lbSelAll.Text = "ȫѡ";
		//		}
		//	}
		//}
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
			string strWhereCond = CombinevQryRegionFldsCondition();
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
            List<long> lstMId = wucvQryRegionFlds4Gv1.GetAllCheckedKeysFromGv();
            if (lstMId == null) return;
            lblMsg1.Text = "";
            try
            {
                foreach (long lngmId in lstMId)
                {
                    clsQryRegionFldsBL.DelRecord(lngmId);
                }

            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000021)ɾ����¼���ɹ�!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsg1.Text = strMsg;
                return;
            }
            clsQryRegionFldsBLEx.ReOrder(getRegionId);
            //clsViewRegionBLEx.SetFldCount(getRegionId);
            //clsViewRegionBLEx.SetFldCountInUse(getRegionId);

            BindGv_vQryRegionFlds();
		}

		
		//��ǰ��¼��
		protected void btnUpdate4Dg_Click(object sender, System.EventArgs e)
		{
            if (string.IsNullOrEmpty(hidCtrlId.Value) == false)
            {
                lblMsg1.Text = "";
                //1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�

                ShowData(hidCtrlId.Value);
                //2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
                clsPubFun.SetButtonEnabled(btnOKUpd, true);
                btnOKUpd.Text = "ȷ���޸�";
                return;
            }

            long lngmId = wucvQryRegionFlds4Gv1.GetFirstCheckedKeyFromGv();
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
		
		protected void dgQryRegionFlds_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
		{
			int intIndex;
			//�ж��Ƿ����µ������ֶ�
			intIndex = strSortQryRegionFldsBy.IndexOf(e.SortExpression);
			if (intIndex == -1)
			{
				strSortQryRegionFldsBy = e.SortExpression + " Asc";
				BindGv_vQryRegionFlds();
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
			BindGv_vQryRegionFlds();
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
                clsQryRegionFldsBLEx.ImportRelaFlds(getRegionId, clsPubVar.CurrCmPrjId, UserId);
                //clsViewRegionBLEx.SetFldCount(getRegionId);
                //clsViewRegionBLEx.SetFldCountInUse(getRegionId);

                BindGv_vQryRegionFlds();
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }
            ///�ָ�<ȷ�����>���<���>
            //		lbDispFldList_Click(new object(), new System.EventArgs());
            Response.Write("<script>alert('�������ص������ֶ���Ϣ���Ƴɹ�����')</script>");
		}


        protected void BindGv_vQryRegionFlds()
        {
            //��������:(��5��)
            //	1����Ͻ�����������
            //	2�����ÿؼ��еİ�GridView����;
            //	3������Gv�ؼ���ĳЩ�в��ɼ�;

            try
            {
                //	3������Gv�ؼ���ĳЩ�в��ɼ���
                //wucvQryRegionFlds4Gv1.SetGvVisibility(convQryRegionFlds.DsDataValueFieldName, false);
                //wucvQryRegionFlds4Gv1.SetGvVisibility(convQryRegionFlds.DsDataTextFieldName, false);
                wucvQryRegionFlds4Gv1.SetGvVisibility(convQryRegionFlds.DsSqlStr, false);
                wucvQryRegionFlds4Gv1.SetGvVisibility(convQryRegionFlds.DsCondStr, false);
                wucvQryRegionFlds4Gv1.SetGvVisibility(convQryRegionFlds.LabelCaption, false);
                wucvQryRegionFlds4Gv1.SetGvVisibility("�޸�", false);
                wucvQryRegionFlds4Gv1.SetGvVisibility("ɾ��", false);

                //	1����Ͻ�����������
                string strWhereCond = CombinevQryRegionFldsCondition();
                //strWhereCond += string.Format(" order by {0}", convQryRegionFlds.SeqNum);
                //	2�����ÿؼ��еİ�GridView������
                wucvQryRegionFlds4Gv1.SetSortBy_Prev(string.Format("{0} desc", convQryRegionFlds.InUse, convQryRegionFlds.SeqNum));
                wucvQryRegionFlds4Gv1.SetSortBy(string.Format("{0}", convQryRegionFlds.SeqNum));
                wucvQryRegionFlds4Gv1.BindGv_QryRegionFlds(strWhereCond);
       

            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000019)��GridView����!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            try
            {
                wucQryRegion4Preview1.ShowControl4Regoin(getRegionId, clsPubVar.CurrSelPrjId, true, true);
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
			//tabQryRegionFldsJumpPage.Visible = true;
			//tabEditQryRegionFldsRegion.Visible = false;
	
		}
		private void DispPrjTabFldsInfo()
		{
			
			//tabEditQryRegionFldsRegion.Visible = false;
			tabQryRegionFldsDataGrid.Visible = false;
			//tabQryRegionFldsJumpPage.Visible = false;
		}
		private void DispEditQryRegionFldsRegionBak()
		{
			tabQryRegionFldsDataGrid.Visible = false;
			//tabQryRegionFldsJumpPage.Visible = false;
			//tabEditQryRegionFldsRegion.Visible = true;
	
			
		}


	
		protected void btnUpMove_Click(object sender, System.EventArgs e)
		{
			string strMsg;
            long lngmId = wucvQryRegionFlds4Gv1.GetFirstCheckedKeyFromGv();
            if (lngmId == 0) return;
     
			try
			{
				clsQryRegionFldsBLEx.AdjustSequenceNumber("UP", lngmId);

            }			
			catch(Exception objException)
			{
				strMsg = objException.Message;
				clsCommonJsFunc.Alert(this, strMsg);
				lblMsg1.Text = strMsg;
				//				clsPubFun4Web.AccessError(this, conCurrPageName);
			}
			BindGv_vQryRegionFlds();
            wucvQryRegionFlds4Gv1.SetCheckedItemForGv(lngmId);

            //clsCommForWebForm.SetCheckedItemForDg(dgQryRegionFlds, 1, strmId);
		}

		protected void btnDownMove_Click(object sender, System.EventArgs e)
		{
			string strMsg;
            long lngmId = wucvQryRegionFlds4Gv1.GetFirstCheckedKeyFromGv();
            if (lngmId == 0) return;
            try
			{
				clsQryRegionFldsBLEx.AdjustSequenceNumber("DOWN", lngmId);
            }
			
			catch(Exception objException)
			{
				strMsg = objException.Message;
				clsCommonJsFunc.Alert(this, strMsg);
				lblMsg1.Text = strMsg;
				//				clsPubFun4Web.AccessError(this, conCurrPageName);
			}
			BindGv_vQryRegionFlds();
            wucvQryRegionFlds4Gv1.SetCheckedItemForGv(lngmId);

            //clsCommForWebForm.SetCheckedItemForDg(dgQryRegionFlds, 1, strmId);

		}

		protected void btnReOrder_Click(object sender, System.EventArgs e)
		{
            clsQryRegionFldsBLEx.ReOrder(getRegionId);

            BindGv_vQryRegionFlds();
		}

		protected void lbDispTabList_Click(object sender, System.EventArgs e)
		{
			DispQryRegionFldsInfo();
		}

        protected void lbDownLoadFile_Click(object sender, EventArgs e)
        {

        }


        protected void btnGoFirstLine_Click(object sender, EventArgs e)
        {
            string strMsg;
            long lngmId = wucvQryRegionFlds4Gv1.GetFirstCheckedKeyFromGv();
            if (lngmId == 0) return;
            try
            {
                clsQryRegionFldsBLEx.AdjustSequenceNumber("FIRST", lngmId);
            }

            catch (Exception objException)
            {
                strMsg = objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsg1.Text = strMsg;
                //				clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_vQryRegionFlds();
            wucvQryRegionFlds4Gv1.SetCheckedItemForGv(lngmId);
        }

        protected void btnGoLastLine_Click(object sender, EventArgs e)
        {
            string strMsg;
            long lngmId = wucvQryRegionFlds4Gv1.GetFirstCheckedKeyFromGv();
            if (lngmId == 0) return;
            try
            {
                clsQryRegionFldsBLEx.AdjustSequenceNumber("LAST", lngmId);
            }
            catch (Exception objException)
            {
                strMsg = objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsg1.Text = strMsg;
                //				clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_vQryRegionFlds();
            wucvQryRegionFlds4Gv1.SetCheckedItemForGv(lngmId);

        }

        /// <summary>
        /// Sql��������Id�� ������01����02:��ͼ��
        /// </summary>
        public string vsInOutTypeId
        {
            get
            {
                string strInOutTypeId;
                strInOutTypeId = (string)ViewState["InOutTypeId"];
                if (strInOutTypeId == null)
                {
                    strInOutTypeId = "";
                }
                return strInOutTypeId;
            }
            set
            {
                string strInOutTypeId = value;
                ViewState.Add("InOutTypeId", strInOutTypeId);
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
            List<long> lstMId = wucvQryRegionFlds4Gv1.GetAllCheckedKeysFromGv();
            if (lstMId == null) return;
            //lblMsgList.Text = "";
            //List<string> arrmId = clsCommForWebForm.GetAllCheckedItemFromDg2(dgQryRegionFlds, "chkCheckRec");
            //if (arrmId == null || arrmId.Count == 0)
            //{
            //    lblMsg1.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
            //    return;
            //}
            lblMsg1.Text = "";
            try
            {
                clsQryRegionFldsBLEx.SetInUse(lstMId, clsCommonSession.UserId);
                clsQryRegionFldsBLEx.ReOrder(getRegionId);
                //clsViewRegionBLEx.SetFldCount(getRegionId);
                //clsViewRegionBLEx.SetFldCountInUse(getRegionId);

                BindGv_vQryRegionFlds();
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
            List<long> lstMId = wucvQryRegionFlds4Gv1.GetAllCheckedKeysFromGv();
            if (lstMId == null) return;
            lblMsg1.Text = "";
            try
            {
                clsQryRegionFldsBLEx.SetNotInUse(lstMId, clsCommonSession.UserId);
                clsQryRegionFldsBLEx.ReOrder(getRegionId);
                //clsViewRegionBLEx.SetFldCount(getRegionId);
                //clsViewRegionBLEx.SetFldCountInUse(getRegionId);

                BindGv_vQryRegionFlds();
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
            BindGv_vQryRegionFlds();
        }

        protected void dgQryRegionFlds_ItemDataBound(object sender, DataGridItemEventArgs e)
        {
            //if (e.Row.RowType == DataControlRowType.DataRow) //�ж��Ƿ�������;

            //{

            //    DataRowView drv = (DataRowView)e.Row.DataItem;


            //    //DataRow objDR = (DataRow)e.Row.DataItem ;
            //    clsvViewFeatureRelaEN objCurr = clsvViewFeatureRelaBL.GetObjByDataRow_S(drv);//.DataItem
            //    int intIndex4FuncCount = clsCommForWebForm.GetIndexByDataField4GridView(gvViewFeatureRela,
            //        clsvViewFeatureRelaEN.con_FuncCount);
            //    clsvPrjFeatureEN objvPrjFeatureEN = clsvPrjFeatureBLEx.GetObjByFeatureIdCacheEx(vsvPrjFeatureObjLst, objCurr.FeatureId);
            //    if (objvPrjFeatureEN == null) return;

            //    e.Row.Cells[intIndex4FuncCount].Text = objvPrjFeatureEN.FuncCount.ToString();// drv["id_ScoreKind"]

            //    //drv["ExamDate"] = "32222222";
            //    //objCurr.ExamDate = "444";
            //    //drv[clsvPrjFeatureEN.con_IsSubmit] = true; //"��";
            //    //e.Row.DataItem = drv;
            //    //e.Row.DataBind();

            //}
        }
        ///
        /// <summary>
        /// �¼�����:��Gv�б�ؼ��У���GeidView�е���ɾ��ʱ�������¼���
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_Wuc4Gv_GvDeleteClick)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void wucvQryRegionFlds4Gv1_GvDeleteClick(object sender, clsEventArgs4Delete e)
        {
            long lngmId = long.Parse(e.KeyId);
            DeleteQryRegionFldsRecord(lngmId);
        }

        /// <summary>
        /// ���ݸ����ؼ���ɾ����¼
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDelRecordCode)
        /// </summary>
        /// <param name = "lngmId">�����ؼ���</param>
        protected void DeleteQryRegionFldsRecord(long lngmId)
        {
            try
            {
                clsQryRegionFldsBL.DelRecord(lngmId);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000022)ɾ����¼���ɹ�!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                //lblMsgList.Text = strMsg;
                return;
            }
            BindGv_vQryRegionFlds();
        }

        ///
        /// <summary>
        /// �¼�����:��Gv�б�ؼ��У���GeidView�е����޸�ʱ�������¼���
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_Wuc4Gv_GvUpdateClick)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void wucvQryRegionFlds4Gv1_GvUpdateClick(object sender, clsEventArgs4Update e)
        {
            long lngmId = long.Parse(e.KeyId);
            UpdateQryRegionFldsRecord(lngmId);
        }
        /// <summary>
        /// Ϊ�޸ļ�¼��׼������,�Ѹ����ؼ��ֵļ�¼�ֶ�ֵ��ʾ���û��ؼ���
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenUpdateRecordCode)
        /// </summary>
        protected void UpdateQryRegionFldsRecord(long lngmId)
        {
            //��������:(�ܹ�2��)
            //1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
            //2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�

            //1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
            ShowData(lngmId);
            //2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
            btnOKUpd.Enabled = true;
            btnOKUpd.Text = "ȷ���޸�";
            //btnCancelQryRegionFldsEdit.Text = "ȡ���޸�";
            //lblMsgEdit.Text = "";
            //DispEditQryRegionFldsRegion();
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
            DispQryRegionFldsInfo();
        }

        protected void btnSetColNum_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty( txtColNum.Text ) == true)
            {
                clsCommonJsFunc.Alert(this, "������������");
                txtColNum.Focus();
            }
            int intColNum = int.Parse(txtColNum.Text);

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
                    clsViewRegionEN objViewRegion = clsViewRegionBL.GetObjByRegionId(getRegionId);
                    if (string.IsNullOrEmpty(txtWidth.Text) == false)
                    {
                        objViewRegion.SetWidth(intWidth)
                            .SetColNum(intColNum)
                                  .SetContainerTypeId(strContainerTypeId)
                                 .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                                  .SetUpdUser(clsCommonSession.UserId)
                                .Update();
                    }
                }
                catch (Exception objException)
                {
                    clsPubVar4BLEx.objLog4Error.WriteDebugLog(objException.Message);

                }
            }


            try
            {
                wucQryRegion4Preview1.ShowControl4Regoin(getRegionId, clsPubVar.CurrSelPrjId, true, true);
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
            List<long> lstMId = wucvQryRegionFlds4Gv1.GetAllCheckedKeysFromGv();
            if (lstMId == null) return;
            if (string.IsNullOrEmpty(txtColSpan.Text) == true)
            {
                clsCommonJsFunc.Alert(this, "�������������");
                txtColSpan.Focus();
            }
            int intColSpan = int.Parse(txtColSpan.Text);

            lblMsg1.Text = "";
            try
            {
                clsQryRegionFldsBLEx.SetColSpan(lstMId, intColSpan, clsCommonSession.UserId);
                BindGv_vQryRegionFlds();
            }
            catch (Exception objException)
            {
                string strMsg = objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsg1.Text = strMsg;
            }
            try
            {
                wucQryRegion4Preview1.ShowControl4Regoin(getRegionId, clsPubVar.CurrSelPrjId, true, true);
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
        protected void btnSetWidth_Click(object sender, EventArgs e)
        {
            List<long> lstMId = wucvQryRegionFlds4Gv1.GetAllCheckedKeysFromGv();
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
                clsQryRegionFldsBLEx.SetWidth(lstMId, intWidth, clsCommonSession.UserId);
                BindGv_vQryRegionFlds();
            }
            catch (Exception objException)
            {
                string strMsg = objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsg1.Text = strMsg;
            }
            try
            {
                wucQryRegion4Preview1.ShowControl4Regoin(getRegionId, clsPubVar.CurrSelPrjId, true, true);
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
        public string CurrTabClass(int intTabIndex)
        {
            if (vsCurrTabIndex == intTabIndex)
            {
                return "nav-item active";
            }
            else
            {
                return "nav-item";
            }

        }
        public string TabClass
        {
            get
            {
                return ".myRed";
            }

        }
        public int vsCurrTabIndex
        {
            get
            {
                string sCurrTabIndex;
                sCurrTabIndex = (string)ViewState["CurrTabIndex"];
                if (sCurrTabIndex == null)
                {
                    return 0;
                }
                return int.Parse(sCurrTabIndex);
            }
            set
            {
                string sCurrTabIndex = value.ToString();
                ViewState.Add("CurrTabIndex", sCurrTabIndex);
            }
        }

        [WebMethod]
        public static string GeneCode4Func(string strCodeTypeId, string strTabId, string strFuncId, string strViewId, string strCmPrjId,  int intApplicationTypeId)
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

                //string strViewId = "";
                string strRe_ClsName = "";
                var Re_objFunction4Code = new clsFunction4CodeEN();
                string strRe_FileNameWithModuleName = "";
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
        private void ShowCodeTypeButton()
        {
            pnlCodeTypeLst.Controls.Clear();
            int intAppTypeId = vsApplicationTypeId;
                   
                     


          
            List<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                            clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(enumFunctionTemplate.RegionFunctionSet_0004,
                            "",
                            enumRegionType.QueryRegion_0001)
                            .OrderBy(x => x.OrderNum).ToList();

            //������-������صĺ���
           
            int intCount4 = arrvFunction4GeneCodeObjLst.Count();


            clsvApplicationTypeEN objvApplicationTypeEN = clsvApplicationTypeBL.GetObjByApplicationTypeIdCache(intAppTypeId);
            string strCharEncodingId = objvApplicationTypeEN.CharEncodingId;
            //cboCharEncodingId.SelectedValue = strCharEncodingId;
            //string strCondition = string.Format("{0}={1} order by {2}",
            //    clsAppCodeTypeRelaEN.con_ApplicationTypeId, intAppTypeId, clsAppCodeTypeRelaEN.con_OrderNum);
            List<clsvAppCodeTypeRelaENEx> arrObjLst = clsvAppCodeTypeRelaBLEx.GetObjExLstByApplicationTypeIdExCache(intAppTypeId)
                .Where(x => x.ViewTypeCode>0 )
                .OrderBy(x => x.GroupName).ThenBy(x => x.OrderNum)
                .ToList();

            int intCount = 0;
            //string strGroupName = "";
            IEnumerable<clsvAppCodeTypeRelaENEx> arrObjLst_V2 = arrObjLst.Where(x => x.DependsOn == "View");
            if (vsvViewRegion != null)
            {
                arrObjLst_V2 = arrObjLst_V2.Where(x => x.RegionTypeId == vsvViewRegion.RegionTypeId).OrderBy(x => x.OrderNum);
            }
            List<string> arrGroupName = arrObjLst_V2.Select(x => x.GroupName).Distinct().ToList();
            bool bolIsFirst = true;
            Label objLabel = null;
            foreach (string strGroupName in arrGroupName)
            {
                IEnumerable<clsvAppCodeTypeRelaENEx> arrObjLst_Sel =
                    arrObjLst_V2.Where(x=>x.GroupName == strGroupName);
                IEnumerable<string> arrCodeTypeId = arrObjLst_Sel.Select(x=>x.CodeTypeId);
                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst_Sel1 =
                   arrvFunction4GeneCodeObjLst.Where(x => arrCodeTypeId.Contains( x.FuncCodeTypeId));

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
                        arrvFunction4GeneCodeObjLst.Where(x=>x.FuncCodeTypeId == objInFor.CodeTypeId).ToList();
            
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
        protected clsvViewRegionEN vsvViewRegion
        {
            get
            {
                clsvViewRegionEN objvViewRegion;

                if (ViewState["vViewRegion"] == null)
                {
                    return null;
                }
                objvViewRegion = (clsvViewRegionEN)ViewState["vViewRegion"];
                return objvViewRegion;
            }
            set
            {
                clsvViewRegionEN objvViewRegion = value;
                ViewState.Add("vViewRegion", objvViewRegion);
            }
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

            //if (clsQryRegionFldsBL.IsExist(lngmId) == false)       //���ùؼ��ֵļ�¼�Ƿ����
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

            string strCondition = new clsvQryRegionFldsEN()
                .SetFldName(strFldName, "=")
                .SetRegionId(getRegionId, "=")
                .GetCombineCondition();
            long lngMid = clsvQryRegionFldsBL.GetFirstID_S(strCondition);
            if (lngMid == 0)
            {
                string strMsg = string.Format("��������[{0}]��ȡ�ؼ��ֲ��ɹ���", strCondition);
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            clsQryRegionFldsEN objQryRegionFlds = new clsQryRegionFldsEN(lngMid);
            //4����ȡ�������������ԣ�
            clsQryRegionFldsBL.GetQryRegionFlds(ref objQryRegionFlds);
            Session.Add("objQryRegionFldsEN", objQryRegionFlds);
            //5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���
            GetDataFromQryRegionFldsClass(objQryRegionFlds);
   
        }


        protected string getRegionId
        {
            get
            {
                if (string.IsNullOrEmpty(qsRegionId) == false) return qsRegionId;
                return "";
            }

        }
        private string qsRegionId
        {
            get
            {
                string strRegionId = Request.QueryString["RegionId"] ?? "".ToString();
                if ((strRegionId != null) && (strRegionId != ""))
                {
                    return strRegionId;//Request.QueryString["id"] ?? "";
                }
                else
                {
                    return "";
                }
            }
        }

        //protected string vsViewId
        //{
        //    get
        //    {
        //        string sViewId;
        //        sViewId = (string)ViewState["ViewId"];
        //        if (sViewId == null)
        //        {
        //            sViewId = "";
        //        }
        //        return sViewId;
        //    }
        //    set
        //    {
        //        string sViewId = value;
        //        ViewState.Add("ViewId", sViewId);
        //    }
        //}
            
    
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
                return int.Parse(strApplicationTypeId);
            }
            set
            {
                string strApplicationTypeId = value.ToString();
                ViewState.Add("ApplicationTypeId", strApplicationTypeId);
            }
        }

    }
}