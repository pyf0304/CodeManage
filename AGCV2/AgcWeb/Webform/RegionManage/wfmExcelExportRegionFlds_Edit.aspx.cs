///���ɲ�ѯ���޸ģ�ɾ������Ӽ�¼�Ŀ��Ʋ����


using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Agc;
using AGC.BusinessLogic;
using AGC.BusinessLogicEx;

using AGC.Entity;
using AGC.FunClass;
using AgcCommBase;
using AutoGCLib;
using com.taishsoft.common;
using com.taishsoft.datetime;
using com.taishsoft.json;
using CommFunc4WebForm;


namespace AGC.Webform
{
    /// <summary>
    /// wfmExcelExportRegionFlds_QUDI ��ժҪ˵��������Q�����ѯ��U�����޸�
    /// </summary>
    public partial class wfmExcelExportRegionFlds_Edit : CommWebPageBase
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
				//2����ʾ�������ı�������DATAGRID��
				strSortExcelExportRegionFldsBy = "SeqNum Asc";
                clsViewRegionEN objViewRegionEN = clsViewRegionBL.GetObjByRegionIdCache(getRegionId, clsPubVar.CurrSelPrjId);
                if (objViewRegionEN != null)
                {
                    wucExcelExportRegionFlds1.SetDdl_FldId(objViewRegionEN.TabId);
                    wucExcelExportRegionFlds1.vsTabId = objViewRegionEN.TabId;
                    wucExcelExportRegionFlds1.SetDdl_DataNodeIdByTabId(objViewRegionEN.TabId, objViewRegionEN.PrjId);

                    vsApplicationTypeId = 0;// objViewRegionEN.ApplicationTypeId;
                    vsInOutTypeId = objViewRegionEN.InOutTypeId;
                    //chkInUse.Checked = objViewRegionEN.InUseInViewId(clsCommonSession.ViewId, clsPubVar.CurrSelPrjId);
                    txtWidth.Text = objViewRegionEN.Width.ToString();
                    //vsViewId = objViewRegionEN.ViewId;
                }
                BindGv_vExcelExportRegionFlds();
							
				

				//3�����ñ�ؼ����ֿؼ���ReadOnly���ԣ�
				//   ʹֻ֮������Ϊ���޸Ĺ����йؼ����ǲ��ܱ��޸ĵġ�
			}
            ShowCodeTypeButton();
            try
            {
                wucExcelExportRegion4Preview1.ShowControl4Regoin(getRegionId, clsPubVar.CurrSelPrjId, 5, true);
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
		private string SimpleFName  //�������ļ���������Ŀ¼��
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


		


		//���ɴ�����Ϣ��Session����
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


		//���ɷ������Ӵ���Session����
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
        //      private string getRegionId
        //{
        //	get
        //	{
        //		string lngRegionId;
        //		if (Session["RegionId"]==null) 
        //		{
        //			lngRegionId = "";
        //		}
        //		else
        //		{
        //			string strRegionId = Session["RegionId"].ToString();
        //			lngRegionId = strRegionId;
        //		}
        //		return lngRegionId;
        //	}
        //	set
        //	{
        //		string lngRegionId = value;
        //		Session.Add("RegionId", lngRegionId);
        //	}
        //}	

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
        /// <summary>
        /// �����еĲ�ѯ�ؼ�������ϳ�һ��������
        /// </summary>
        /// <returns>������(strWhereCond)</returns>
        private string CombinevExcelExportRegionFldsCondition()
		{
			//ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
			//���� 1=1 && UserName = '����'
            string strWhereCond = " 1=1 and RegionId = " + getRegionId;
            if (chkOnlyShowFldInUse.Checked == true)
            {
                strWhereCond += string.Format(" And {0}='1'", conExcelExportRegionFlds.InUse);
            }
            return strWhereCond;
		}
		///���ɰ�DATAGRID�Ĵ���
		/// <summary>
		/// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
		///			 ����ʾ��DATAGRID�С�
		/// </summary>
		private void BindGv_vExcelExportRegionFldsBak()
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
			string strWhereCond = CombinevExcelExportRegionFldsCondition();
			//	2��������������ȡ�ñ�����������DataTable��
			System.Data.DataTable objDT = clsvExcelExportRegionFldsBL.GetDataTable(strWhereCond + " order by SeqNum" );

            if (vsInOutTypeId == "02")//��ͼ
            {
                clsExcelExportRegionFldsBLEx.AddColumn_SourceTabName(ref objDT);
            }
            else
            {
                objDT.Columns.Add("SourceTabName");
            }
            
            //	3�����DATAGRID�ĵ�ǰҳ���Ƿ񳬳�DATAGRID��ҳ����Χ
			//		3.1 ���ȼ���ҳ����
			//		3.2 �����ǰҳ����ҳ����Ϊ���һҳ
			//int intPages = CalcPages(objDT.Rows.Count, this.dgExcelExportRegionFlds.PageSize);
			//if (intPages==0) 
			//{
			//	this.dgExcelExportRegionFlds.CurrentPageIndex = 0;
			//}
			//else if (this.dgExcelExportRegionFlds.CurrentPageIndex > intPages - 1) 
			//{
			//	this.dgExcelExportRegionFlds.CurrentPageIndex = intPages - 1;
			//}
			////	4������DATAGRID������Դ(DataSource)��
			//DataView objDV = objDT.DefaultView;
			//objDV.Sort = strSortExcelExportRegionFldsBy;
			//this.dgExcelExportRegionFlds.DataSource=objDV;
			////	5����DATAGRID������DataTable��������ʾ��DATAGRID��
			//this.dgExcelExportRegionFlds.DataBind();

			
			////��ǰ��¼��
			//this.lblExcelExportRegionFldsRecCount.Text = objDT.Rows.Count.ToString(); 
			////��ǰҳ��
			//this.lblExcelExportRegionFldsAllPages.Text = this.dgExcelExportRegionFlds.PageCount.ToString(); 
			////��ǰҳ����
			//this.lblExcelExportRegionFldsCurrentPage.Text=(this.dgExcelExportRegionFlds.CurrentPageIndex+1).ToString();
			////��ǰ����������ҳ����
			//this.txtExcelExportRegionFldsJump2Page.Text=(this.dgExcelExportRegionFlds.CurrentPageIndex+1).ToString();
			////�����ǰҳ����Ϊ0����<ǰһҳ>��ť��Ч
			//if(this.dgExcelExportRegionFlds.CurrentPageIndex==0) 
			//{
			//	btnExcelExportRegionFldsPrevPage.Enabled=false; 
			//}
			//else 
			//{ 
			//	btnExcelExportRegionFldsPrevPage.Enabled=true; 
			//} 
			////�����ǰҳ������Ϊ���һҳ����<ǰһҳ>��ť��Ч
			//if(this.dgExcelExportRegionFlds.CurrentPageIndex==this.dgExcelExportRegionFlds.PageCount-1) 
			//{ 
			//	btnExcelExportRegionFldsNextPage.Enabled=false; 
			//} 
			//else 
			//{ 
			//	btnExcelExportRegionFldsNextPage.Enabled=true; 
			//} 
			////7�������沿����ʾ����ʾ �������ǰDataGrid�еļ�¼��Ϊ0������ʾ��ǰ����ҳ������
			//if(objDT.Rows.Count>0) 
			//{ 
			//	this.tabExcelExportRegionFldsJumpPage.Visible = true; 
			//} 
			//else 
			//{ 
			//	this.tabExcelExportRegionFldsJumpPage.Visible = false; 
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
            wucvExcelExportRegionFlds4Gv1.vsPageIndex = 1;
            //�ѱ��¼��������ʾ��GridView��
            BindGv_vExcelExportRegionFlds();
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
			if (clsExcelExportRegionFldsBL.IsExist(lngmId) == false)		//���ùؼ��ֵļ�¼�Ƿ����
			{
				string ss = "�ؼ���Ϊ��" + lngmId + "�Ĳ�����!";
				clsCommonJsFunc.Alert(this, ss);
				return ;
			}
			//3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
			clsExcelExportRegionFldsEN objExcelExportRegionFlds = new clsExcelExportRegionFldsEN(lngmId);
            //4����ȡ�������������ԣ�
            clsExcelExportRegionFldsBL .GetExcelExportRegionFlds(ref objExcelExportRegionFlds);
			Session.Add("objExcelExportRegionFlds", objExcelExportRegionFlds);
			//5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���
			GetDataFromExcelExportRegionFldsClass(objExcelExportRegionFlds);
			//DispEditExcelExportRegionFldsRegion();
		}

        //private void ShowData(string strCtrlId)
        //{
        //    //�������裺
        //    //1�����ؼ����Ƿ�Ϊ�գ�
        //    //2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
        //    //3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
        //    //4����ȡ�������������ԣ�
        //    //5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���

        //    //1�����ؼ����Ƿ�Ϊ�գ�
        //    //if (lngmId == 0) return;        //����ؼ���Ϊ�վͷ����˳�
        //    //2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��

        //    //if (clsExcelExportRegionFldsBL.IsExist(lngmId) == false)       //���ùؼ��ֵļ�¼�Ƿ����
        //    //{
        //    //    string ss = "�ؼ���Ϊ��" + lngmId + "�Ĳ�����!";
        //    //    clsCommonJsFunc.Alert(this, ss);
        //    //    return;
        //    //}
        //    //3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
        //    string strFldName = clsCtlTypeBLEx.GetFldNameByCtrlId(strCtrlId);
        //    if (string.IsNullOrEmpty(strFldName) == true)
        //    {
        //        string strMsg = string.Format("����[�ؼ�Id:{0}]��ȡ�ֶ���(FldName)���ɹ���", strCtrlId);
        //        clsCommonJsFunc.Alert(this, strMsg);
        //        return;
        //    }

        //    string strCondition = new clsvExcelExportRegionFldsEN()
        //        .SetFldName(strFldName, "=")
        //        .SetRegionId(getRegionId, "=")
        //        .GetCombineCondition();
        //    long lngMid = clsvExcelExportRegionFldsBL.GetFirstID_S(strCondition);
        //    if (lngMid == 0)
        //    {
        //        string strMsg = string.Format("��������[{0}]��ȡ�ؼ��ֲ��ɹ���", strCondition);
        //        clsCommonJsFunc.Alert(this, strMsg);
        //        return;
        //    }
        //    clsExcelExportRegionFldsEN objExcelExportRegionFlds = new clsExcelExportRegionFldsEN(lngMid);
        //    //4����ȡ�������������ԣ�
        //    clsExcelExportRegionFldsBL.GetExcelExportRegionFlds(ref objExcelExportRegionFlds);
        //    Session.Add("objExcelExportRegionFlds", objExcelExportRegionFlds);
        //    //5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���
        //    GetDataFromExcelExportRegionFldsClass(objExcelExportRegionFlds);

        //}


        ///���ɴ��߼�������ݴ��䵽�����ĺ�������
        /// <summary>
        /// �������ܣ�������������������ʾ��������
        ///ע�⣺��������������򣬲�����һ��������������ϵ�ģ�����Ϊһ��������ֵ��Ȼ����Ϊ����������ֵ
        ///      ������������ݿ�ʱ����Ӧ��һ���ֶ���ǰ�������ֶ��ں�
        /// </summary>
        /// <param name="pobjExcelExportRegionFlds">��ʵ�������</param>
        private void GetDataFromExcelExportRegionFldsClass(clsExcelExportRegionFldsEN pobjExcelExportRegionFlds)
		{
            wucExcelExportRegionFlds1.FldId = pobjExcelExportRegionFlds.FldId;
            try
            {
                var objViewRegion = clsViewRegionBL.GetObjByRegionIdCache(pobjExcelExportRegionFlds.RegionId, clsPubVar.CurrSelPrjId);
                wucExcelExportRegionFlds1.vsCmPrjId = objViewRegion.PrjId;
                //wucExcelExportRegionFlds1.DataNodeId = pobjExcelExportRegionFlds.OutDataNodeId;
            }
            catch (Exception objException)
            {
                clsPubVar.objLog.WriteDebugLog(objException.Message);
                //string ss = "";
            }
            //wucExcelExportRegionFlds1.DataPropertyName = pobjExcelExportRegionFlds.DataPropertyName;
            //wucDetailRegionFlds1.SortExpression = objvDetailRegionFlds.SortExpression;

            wucExcelExportRegionFlds1.Memo = pobjExcelExportRegionFlds.Memo;
			wucExcelExportRegionFlds1.SeqNum = pobjExcelExportRegionFlds.SeqNum;
			wucExcelExportRegionFlds1.ColCaption = pobjExcelExportRegionFlds.ColCaption;
   //         clsvExcelExportRegionFldsEN objvExcelExportRegionFlds = clsvExcelExportRegionFldsBL.GetFirstObj_S("RegionId = '" + getRegionId + "' and TabFldId = " + pobjExcelExportRegionFlds.TabFldId);
			//wucExcelExportRegionFlds1.FldName = objvExcelExportRegionFlds.FldName;

		}
		/// <summary>
		/// �������ܣ��¼�������������<ȷ���޸�>ʱ�������¼�������
		///           ���幦��Ϊ�ѽ�������ͬ�����ݿ��У��ѽ������ݱ��浽���ݿ���
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected void btnOKUpd_Click(object sender, System.EventArgs e)
		{
			string strCommandText;
			clsExcelExportRegionFldsEN objExcelExportRegionFlds;
			Button btnTemp;
			btnTemp = (Button) sender;
			strCommandText = btnTemp.Text;
			switch(strCommandText)
			{
				case "���":
					AddExcelExportRegionFldsRecord();
					break;				
				case "ȷ�����":
					//����һ������Ĳ���Ĵ��룬�����߼���̫�򵥣�
					//�Ͱ��߼���ϲ������Ʋ�,
					AddExcelExportRegionFldsRecordSave();
					break;
				case "ȷ���޸�":
					//����һ��������޸ĵĴ��룬�����߼���̫�򵥣�
					//�Ͱ��߼���ϲ������Ʋ�,
					objExcelExportRegionFlds = (clsExcelExportRegionFldsEN) Session["objExcelExportRegionFlds"];
					UpdateExcelExportRegionFldsRecordSave(objExcelExportRegionFlds);
					break;
			}
		}
		
		/// <summary>
		/// �������ܣ��ѽ����ϵ��������ݴ����������
		/// </summary>
		/// <param name="pobjExcelExportRegionFlds">���ݴ����Ŀ�������</param>
		private void PutDataToExcelExportRegionFldsClass(clsExcelExportRegionFldsEN pobjExcelExportRegionFlds)
		{
            pobjExcelExportRegionFlds.FldId = wucExcelExportRegionFlds1.FldId;
            //pobjExcelExportRegionFlds.OutDataNodeId = wucExcelExportRegionFlds1.DataNodeId;

            //if (string.IsNullOrEmpty(pobjExcelExportRegionFlds.OutDataNodeId) == false)
            //{
            //    pobjExcelExportRegionFlds.IsUseFunc = true;
            //}
            //else
            //{
            //    pobjExcelExportRegionFlds.IsUseFunc = false;
            //}
            //pobjExcelExportRegionFlds.DataPropertyName = wucExcelExportRegionFlds1.DataPropertyName;

            pobjExcelExportRegionFlds.Memo = wucExcelExportRegionFlds1.Memo;
			pobjExcelExportRegionFlds.SeqNum = wucExcelExportRegionFlds1.SeqNum;
			pobjExcelExportRegionFlds.ColCaption = wucExcelExportRegionFlds1.ColCaption;
            pobjExcelExportRegionFlds.InUse = true;
            pobjExcelExportRegionFlds.RegionId = qsRegionId;
            pobjExcelExportRegionFlds.PrjId = clsPubVar.CurrCmPrjId;
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
			
		}

		
		//��ǰ��¼��
		protected void btnExportExcel4Dg_Click(object sender, System.EventArgs e)
		{
			//	1����Ͻ�����������
			string strWhereCond = CombinevExcelExportRegionFldsCondition();
			//	2��������������ȡ�ñ�����������DataTable��
			System.Data.DataTable objDT = null;
			List<string> arrCnName = new List<string>();
			List<string> arrColName = new List<string>();
			string strFileName = "ExcelExportRegionFlds��Ϣ����.xls";
			string strFolderName;
			string strDownLoadFileName;
			arrColName.Add("mId"); arrCnName.Add("mId");
			arrColName.Add("TabName"); arrCnName.Add("����");
			arrColName.Add("FldName"); arrCnName.Add("�ֶ���");
            arrColName.Add("DataTypeId"); arrCnName.Add("�ֶ�����");
			arrColName.Add("FldLength"); arrCnName.Add("�ֶγ���");
			arrColName.Add("Caption"); arrCnName.Add("����");
			arrColName.Add("IsNull"); arrCnName.Add("�Ƿ�ɿ�");
			arrColName.Add("SequenceNumber"); arrCnName.Add("˳���");
			arrColName.Add("IsParentObj"); arrCnName.Add("�Ƿ񸸶���");
			arrColName.Add("PrimaryTypeName"); arrCnName.Add("����������");
			arrColName.Add("DataTypeName"); arrCnName.Add("DataTypeName");
			arrColName.Add("RegionId"); arrCnName.Add("����Id");
			arrColName.Add("IsTabNullable"); arrCnName.Add("�Ƿ���пɿ�");
			arrColName.Add("SeqNum"); arrCnName.Add("�����");
			arrColName.Add("ColCaption"); arrCnName.Add("�б���");
			arrColName.Add("TabFldId"); arrCnName.Add("���ֶ�ID");
			strFolderName = Server.MapPath("~") +  "\\TempFiles\\";
			strDownLoadFileName = strFolderName + strFileName;
            try
            {
                objDT = clsvExcelExportRegionFldsBL.GetDataTable(strWhereCond);
                GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4Odbc(objDT, arrColName, arrCnName, strDownLoadFileName);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;	//"../GenCode/wfmGenViewCode_WebV5.aspx";
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
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
            List<long> lstMId = wucvExcelExportRegionFlds4Gv1.GetAllCheckedKeysFromGv();
            if (lstMId == null) return;
            lblMsg1.Text = "";
            foreach (long lngmId in lstMId)
            {
                clsExcelExportRegionFldsBL.DelRecord(lngmId);
            }
            clsExcelExportRegionFldsBLEx.ReOrder(getRegionId);
            //clsViewRegionBLEx.SetFldCount(getRegionId);
            //clsViewRegionBLEx.SetFldCountInUse(getRegionId);

            BindGv_vExcelExportRegionFlds();
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

            long lngmId = wucvExcelExportRegionFlds4Gv1.GetFirstCheckedKeyFromGv();
            if (lngmId == 0) return;
            lblMsg1.Text = "";
			//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
		
			ShowData(lngmId);
			//2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
			clsPubFun.SetButtonEnabled(btnOKUpd, true);
			btnOKUpd.Text = "ȷ���޸�";	
		}
		

		///���ɵĲ����¼׼�����̴���for C#
		private void AddExcelExportRegionFldsRecord()
		{
			btnOKUpd.Text = "ȷ�����";
            wucExcelExportRegionFlds1.SeqNum = 1;

		}
		///�����¼���̹��̴���for C#
		private void AddExcelExportRegionFldsRecordSave()
		{
			//�������裺
			//1�����ؼ����������������Ƿ���ȷ
			//2��������󲢳�ʼ������
			//3���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
			//4����ֵ�ӽ���㴫���߼��������ʵ���
			//5����鴫��ȥ�Ķ��������Ƿ�Ϸ�
			//6��������ʵ�������ݴ��������ݿ���
			//7��������ļ�¼������ʾ��DATAGRID��
			string strMsg;	//ר�����ڴ�����Ϣ�ı���
			string strResult=" ";	//���ڴ����ڼ����������ʱ���ֵ�ı���
			clsExcelExportRegionFldsEN objExcelExportRegionFlds;
			//1�����ؼ����������������Ƿ���ȷ
			if (!wucExcelExportRegionFlds1.IsValid(ref strResult))
			{
				lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
				return ;
			}
			//2��������󲢳�ʼ������
			//clsExcelExportRegionFldsEN objExcelExportRegionFlds;	//�������
			objExcelExportRegionFlds = new clsExcelExportRegionFldsEN();	//��ʼ���¶���
			//3���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
			//4����ֵ�ӽ���㴫���߼��������ʵ���
			PutDataToExcelExportRegionFldsClass(objExcelExportRegionFlds);      //�ѽ����ֵ����

            if (string.IsNullOrEmpty(objExcelExportRegionFlds.RegionId) == true)
            {
                objExcelExportRegionFlds.RegionId = qsRegionId;
            }
            objExcelExportRegionFlds.PrjId = clsPubVar.CurrCmPrjId;
            objExcelExportRegionFlds.InUse = true;
            objExcelExportRegionFlds.UpdUser = clsCommonSession.UserId;
            objExcelExportRegionFlds.UpdDate = clsDateTime.getTodayDateTimeStr(1);

            //5����鴫��ȥ�Ķ��������Ƿ�Ϸ�
            try
            {
                clsExcelExportRegionFldsBL.CheckPropertyNew(objExcelExportRegionFlds);
                //6��������ʵ�������ݴ��������ݿ���
                clsExcelExportRegionFldsBL .AddNewRecordBySql2(objExcelExportRegionFlds);
			}
			catch(Exception objException)
			{
				strMsg = "��Ӽ�¼���ɹ�!" + objException.Message;
				clsCommonJsFunc.Alert(this, strMsg);
				lblMsg.Text = strMsg;
				return;
			}
			strMsg = "��Ӽ�¼�ɹ�!";
			clsCommonJsFunc.Alert(this, strMsg);
			lblMsg.Text = "��Ӽ�¼�ɹ�!";
			//7��������ļ�¼������ʾ��DATAGRID��
			BindGv_vExcelExportRegionFlds();
			wucExcelExportRegionFlds1.Clear();		//��տؼ�������
			///�ָ�<ȷ�����>���<���>
			btnOKUpd.Text = "���";
		}
		///�����¼���̹��̴���for C#
		private void AddExcelExportRegionFldsRecordSaveV5()
		{
			//�������裺
			//1�����ؼ����������������Ƿ���ȷ
			//2��������󲢳�ʼ������
			//3���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
			//4����ֵ�ӽ���㴫���߼��������ʵ���
			//5����鴫��ȥ�Ķ��������Ƿ�Ϸ�
			//6��������ʵ�������ݴ��������ݿ���
			//7��������ļ�¼������ʾ��DATAGRID��
			string strMsg;	//ר�����ڴ�����Ϣ�ı���
			string strResult=" ";	//���ڴ����ڼ����������ʱ���ֵ�ı���
			clsExcelExportRegionFldsEN objExcelExportRegionFlds;
			//1�����ؼ����������������Ƿ���ȷ
			if (!wucExcelExportRegionFlds1.IsValid(ref strResult))
			{
				lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
				return ;
			}
			//2��������󲢳�ʼ������
			//clsExcelExportRegionFldsEN objExcelExportRegionFlds;	//�������
			objExcelExportRegionFlds = new clsExcelExportRegionFldsEN();	//��ʼ���¶���
			//3���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
			//4����ֵ�ӽ���㴫���߼��������ʵ���
			PutDataToExcelExportRegionFldsClass(objExcelExportRegionFlds);		//�ѽ����ֵ����
			//5����鴫��ȥ�Ķ��������Ƿ�Ϸ�
			try
			{
                clsExcelExportRegionFldsBL.CheckPropertyNew(objExcelExportRegionFlds);
                //6��������ʵ�������ݴ��������ݿ���
                clsExcelExportRegionFldsBL .AddNewRecordBySql2(objExcelExportRegionFlds);
			}
			catch(Exception objException)
			{
				clsCommonSession.seErrMessage = "��Ӽ�¼���ɹ�!" + objException.Message;
				clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
				clsPubFun4Web.AccessError(this, conCurrPageName);
			}
			strMsg = "��Ӽ�¼�ɹ�!";
			clsCommonJsFunc.Alert(this, strMsg);
			lblMsg.Text = "��Ӽ�¼�ɹ�!";
			//7��������ļ�¼������ʾ��DATAGRID��
			BindGv_vExcelExportRegionFlds();
			wucExcelExportRegionFlds1.Clear();		//��տؼ�������
			///�ָ�<ȷ�����>���<���>
			btnOKUpd.Text = "���";
		}
		///�����޸ļ�¼׼�����̴��� for C#
		private void UpdateExcelExportRegionFldsRecord(long lngmId)
		{
			//�������裺���ܹ�2����
			//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
			//2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�

			//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
			ShowData(lngmId);
			//2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
			clsPubFun.SetButtonEnabled(btnOKUpd, true);
			btnOKUpd.Text = "ȷ���޸�";
			lblMsg.Text = "";
		}
		///�޸Ĵ���׼�����̴��� for C#
		private void UpdateExcelExportRegionFldsRecordSave(clsExcelExportRegionFldsEN objExcelExportRegionFlds)
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
			if (!wucExcelExportRegionFlds1.IsValid(ref strResult))
			{
				lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
				return ;
			}
			//2����ֵ�ӽ���㴫���߼��������ʵ���
			PutDataToExcelExportRegionFldsClass(objExcelExportRegionFlds);		//�ѽ����ֵ����
			//3����鴫��ȥ�Ķ��������Ƿ�Ϸ�
			try
			{
                clsExcelExportRegionFldsBL.CheckPropertyNew(objExcelExportRegionFlds);
                //6��������ʵ�������ݴ��������ݿ���
                clsExcelExportRegionFldsBL .UpdateBySql2(objExcelExportRegionFlds);
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
			BindGv_vExcelExportRegionFlds();
			wucExcelExportRegionFlds1.Clear();//��տؼ��е�����
			//�ָ�<ȷ���޸�>���<���>
			btnOKUpd.Text = "���";
			DispExcelExportRegionFldsInfo();
		}
		///�޸Ĵ���׼�����̴��� for C#
		private void UpdateExcelExportRegionFldsRecordSaveV5(clsExcelExportRegionFldsEN objExcelExportRegionFlds)
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
			if (!wucExcelExportRegionFlds1.IsValid(ref strResult))
			{
				lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
				return ;
			}
			//2����ֵ�ӽ���㴫���߼��������ʵ���
			PutDataToExcelExportRegionFldsClass(objExcelExportRegionFlds);		//�ѽ����ֵ����
			//3����鴫��ȥ�Ķ��������Ƿ�Ϸ�
			try
			{
                clsExcelExportRegionFldsBL.CheckPropertyNew(objExcelExportRegionFlds);
                //6��������ʵ�������ݴ��������ݿ���
                clsExcelExportRegionFldsBL .UpdateBySql2(objExcelExportRegionFlds);
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
			BindGv_vExcelExportRegionFlds();
			wucExcelExportRegionFlds1.Clear();//��տؼ��е�����
			//�ָ�<ȷ���޸�>���<���>
			btnOKUpd.Text = "���";
		}
		///ɾ����¼���̴���for C#
		private void DeleteExcelExportRegionFldsRecord(long lngmId)
		{
			clsExcelExportRegionFldsBL.DelRecord(lngmId);
			BindGv_vExcelExportRegionFlds();
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
                clsExcelExportRegionFldsBLEx.ImportRelaFlds(getRegionId, clsPubVar.CurrCmPrjId, UserId);
                //clsViewRegionBLEx.SetFldCount(getRegionId);
                //clsViewRegionBLEx.SetFldCountInUse(getRegionId);

            }
            catch (Exception objException)
			{
				clsCommonSession.seErrMessage = "���������ֶ��б��ɹ�!" + objException.Message;
				clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
				clsPubFun4Web.AccessError(this, conCurrPageName);
			}

			BindGv_vExcelExportRegionFlds();
			///�ָ�<ȷ�����>���<���>
			//		lbDispFldList_Click(new object(), new System.EventArgs());
			Response.Write("<script>alert('�������ص������ֶ���Ϣ���Ƴɹ�����')</script>");

		}

		protected void btnGoBack_Click(object sender, System.EventArgs e)
		{
			if (BackViewRegionLinkStr !="")
			{
				Response.Redirect(BackViewRegionLinkStr);
			}
		}
		private void DispExcelExportRegionFldsInfo()
		{
			tabExcelExportRegionFldsDataGrid.Visible = true;
			
			
			
			//tabCode.Visible = true;
		}
		private void DispPrjTabFldsInfo()
		{
			
			//tabEditExcelExportRegionFldsRegion.Visible = false;
			tabExcelExportRegionFldsDataGrid.Visible = false;
			
			//tabCode.Visible = false;
		}
		private void DispEditExcelExportRegionFldsRegionBak()
		{
			tabExcelExportRegionFldsDataGrid.Visible = false;
			
			
			
			//tabCode.Visible = false;
		}

	
		///���ɰ�DATAGRID�Ĵ���
		/// <summary>
		/// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
		///			 ����ʾ��DATAGRID�С�
		/// </summary>
		
		
		protected void btnUpMove_Click(object sender, System.EventArgs e)
		{
			string strMsg;
            long lngmId = wucvExcelExportRegionFlds4Gv1.GetFirstCheckedKeyFromGv();
            if (lngmId == 0) return;
            lblMsg1.Text = "";

			try
			{
				clsExcelExportRegionFldsBLEx.AdjustSequenceNumber("UP", lngmId);
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
			BindGv_vExcelExportRegionFlds();
            wucvExcelExportRegionFlds4Gv1.SetCheckedItemForGv(lngmId);

		}

		protected void btnDownMove_Click(object sender, System.EventArgs e)
		{
			string strMsg;
            long lngmId = wucvExcelExportRegionFlds4Gv1.GetFirstCheckedKeyFromGv();
            if (lngmId == 0) return;
            lblMsg1.Text = "";

	
			try
			{
				
				clsExcelExportRegionFldsBLEx.AdjustSequenceNumber("DOWN", lngmId);
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
			BindGv_vExcelExportRegionFlds();
            wucvExcelExportRegionFlds4Gv1.SetCheckedItemForGv(lngmId);


        }
        protected void btnGoFirstLine_Click(object sender, EventArgs e)
        {
            string strMsg;
            long lngmId = wucvExcelExportRegionFlds4Gv1.GetFirstCheckedKeyFromGv();
            if (lngmId == 0) return;
            lblMsg1.Text = "";

            try
            {
                clsExcelExportRegionFldsBLEx.AdjustSequenceNumber("FIRST", lngmId);
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
            BindGv_vExcelExportRegionFlds();
            wucvExcelExportRegionFlds4Gv1.SetCheckedItemForGv(lngmId);

        }

        protected void btnGoLastLine_Click(object sender, EventArgs e)
        {
            string strMsg;
            long lngmId = wucvExcelExportRegionFlds4Gv1.GetFirstCheckedKeyFromGv();
            if (lngmId == 0) return;
            lblMsg1.Text = "";
    
            try
            {
                clsExcelExportRegionFldsBLEx.AdjustSequenceNumber("LAST", lngmId);
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
            BindGv_vExcelExportRegionFlds();
            wucvExcelExportRegionFlds4Gv1.SetCheckedItemForGv(lngmId);

        }

        protected void btnReOrder_Click(object sender, System.EventArgs e)
		{
            clsExcelExportRegionFldsBLEx.ReOrder(getRegionId);
			BindGv_vExcelExportRegionFlds();
		}

		protected void LinkButton1_Click(object sender, System.EventArgs e)
		{
			DispExcelExportRegionFldsInfo();
		}

		protected void lbDispTabList_Click(object sender, System.EventArgs e)
		{
			DispExcelExportRegionFldsInfo();
		}

		private string strSortExcelExportRegionFldsBy
		{
			get
			{
				string sstrSortExcelExportRegionFldsBy;
				sstrSortExcelExportRegionFldsBy = (string)ViewState["strSortExcelExportRegionFldsBy"];
				if (sstrSortExcelExportRegionFldsBy==null) 
				{
					sstrSortExcelExportRegionFldsBy = "";
				}
				return sstrSortExcelExportRegionFldsBy;
			}
			set
			{
				string sstrSortExcelExportRegionFldsBy = value;
				ViewState.Add("strSortExcelExportRegionFldsBy", sstrSortExcelExportRegionFldsBy);
			}
		}
        protected void lbDownLoadFile_Click(object sender, EventArgs e)
        {

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
            List<long> lstMId = wucvExcelExportRegionFlds4Gv1.GetAllCheckedKeysFromGv();
            if (lstMId == null) return;
            lblMsg1.Text = "";
            try
            {
                clsExcelExportRegionFldsBLEx.SetInUse(lstMId, clsCommonSession.UserId);
                clsExcelExportRegionFldsBLEx.ReOrder(getRegionId);
                //clsViewRegionBLEx.SetFldCount(getRegionId);
                //clsViewRegionBLEx.SetFldCountInUse(getRegionId);

                BindGv_vExcelExportRegionFlds();
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
            List<long> lstMId = wucvExcelExportRegionFlds4Gv1.GetAllCheckedKeysFromGv();
            if (lstMId == null) return;
            lblMsg1.Text = "";
            try
            {
                clsExcelExportRegionFldsBLEx.SetNotInUse(lstMId, clsCommonSession.UserId);
                clsExcelExportRegionFldsBLEx.ReOrder(getRegionId);
                //clsViewRegionBLEx.SetFldCount(getRegionId);
                //clsViewRegionBLEx.SetFldCountInUse(getRegionId);

                BindGv_vExcelExportRegionFlds();
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
            BindGv_vExcelExportRegionFlds();
        }
        /// <summary>
        /// �¼�����:��Gv�б�ؼ��У���GeidView�е���ɾ��ʱ�������¼���
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_Wuc4Gv_GvDeleteClick)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void wucvExcelExportRegionFlds4Gv1_GvDeleteClick(object sender, clsEventArgs4Delete e)
        {
            long lngmId = long.Parse(e.KeyId);
            DeleteExcelExportRegionFldsRecord(lngmId);
        }
        

        /// <summary>
        /// �¼�����:��Gv�б�ؼ��У���GeidView�е����޸�ʱ�������¼���
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_Wuc4Gv_GvUpdateClick)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void wucvExcelExportRegionFlds4Gv1_GvUpdateClick(object sender, clsEventArgs4Update e)
        {
            long lngmId = long.Parse(e.KeyId);
            UpdateExcelExportRegionFldsRecord(lngmId);
        }
        /// <summary>
        /// ��������:�Ѳ�ѯ���ݰ���GridView�ϡ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼,
        ///			 ����ʾ��GridView�С�
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenBindGridView4WucInPage)
        /// </summary>
        protected void BindGv_vExcelExportRegionFlds()
        {
            //��������:(��5��)
            //	1����Ͻ�����������
            //	2�����ÿؼ��еİ�GridView����;
            //	3������Gv�ؼ���ĳЩ�в��ɼ�;

            try
            {
                //	1����Ͻ�����������
                string strWhereCond = CombinevExcelExportRegionFldsCondition();
                //	2�����ÿؼ��еİ�GridView������
                wucvExcelExportRegionFlds4Gv1.SetSortBy_Prev(string.Format("{0} desc", convExcelExportRegionFlds.InUse));
                wucvExcelExportRegionFlds4Gv1.SetSortBy(string.Format("{0}", convExcelExportRegionFlds.SeqNum));

                wucvExcelExportRegionFlds4Gv1.BindGv_ExcelExportRegionFlds(strWhereCond);
                //	3������Gv�ؼ���ĳЩ�в��ɼ���
                //wucvExcelExportRegionFlds4Gv1.SetGvVisibility(convExcelExportRegionFlds.Caption, false);
                wucvExcelExportRegionFlds4Gv1.SetGvVisibility(convExcelExportRegionFlds.ColCaption, false);
                wucvExcelExportRegionFlds4Gv1.SetGvVisibility(convExcelExportRegionFlds.UpdDate, false);
                wucvExcelExportRegionFlds4Gv1.SetGvVisibility("�޸�", false);
                wucvExcelExportRegionFlds4Gv1.SetGvVisibility("ɾ��", false);

                //wucvExcelExportRegionFlds4Gv1.SetGvVisibility(convExcelExportRegionFlds.UpdUser, false);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000019)��GridView����!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            try
            {
                wucExcelExportRegion4Preview1.ShowControl4Regoin(getRegionId, clsPubVar.CurrSelPrjId, 5, true);
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

        private void ShowCodeTypeButton()
        {
            pnlCodeTypeLst.Controls.Clear();
            //clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(clsCommonSession.ViewId, clsPubVar.CurrSelPrjId);
            int intAppTypeId = vsApplicationTypeId;
            
            List<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                            clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(enumFunctionTemplate.RegionFunctionSet_0004,
                            "",
                            enumRegionType.ExcelExportRegion_0007)
                            .OrderBy(x => x.OrderNum).ToList();

            //������-������صĺ���

            int intCount4 = arrvFunction4GeneCodeObjLst.Count();

            clsvApplicationTypeEN objvApplicationTypeEN = clsvApplicationTypeBL.GetObjByApplicationTypeIdCache(intAppTypeId);
            string strCharEncodingId = objvApplicationTypeEN.CharEncodingId;
            //cboCharEncodingId.SelectedValue = strCharEncodingId;
            //string strCondition = string.Format("{0}={1} order by {2}",
            //    clsAppCodeTypeRelaEN.con_ApplicationTypeId, intAppTypeId, clsAppCodeTypeRelaEN.con_OrderNum);
            List<clsvAppCodeTypeRelaENEx> arrObjLst = clsvAppCodeTypeRelaBLEx.GetObjExLstByApplicationTypeIdExCache(intAppTypeId)
                .Where(x => x.ViewTypeCode>0)
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


        //protected void chkInUse_CheckedChanged(object sender, EventArgs e)
        //{

        //    bool bolInUse = chkInUse.Checked;
        //    clsViewRegionRelaEN obj = clsViewRegionRelaBLEx.GetObjByViewIdAndRegionIdCache(clsCommonSession.ViewId, getRegionId, clsPubVar.CurrSelPrjId);
        //    obj.SetInUse(bolInUse)
        //        .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
        //        .SetUpdUser(clsCommonSession.UserId)
        //        .Update();
        //    try
        //    {
        //        wucExcelExportRegion4Preview1.ShowControl4Regoin(getRegionId, clsPubVar.CurrSelPrjId, 5);
        //        //	3������Gv�ؼ���ĳЩ�в��ɼ���

        //        //wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.UpdUser, false);
        //    }
        //    catch (Exception objException)
        //    {
        //        string strMsg = "(errid:WebI000219)���ӻ���ʾ����������!" + objException.Message;
        //        clsCommonJsFunc.Alert(this, strMsg);
        //        return;
        //    }
        //}
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

            //if (clsExcelExportRegionFldsBL.IsExist(lngmId) == false)       //���ùؼ��ֵļ�¼�Ƿ����
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

            string strCondition = new clsvExcelExportRegionFldsEN()
                .SetFldName(strFldName, "=")
                .SetRegionId(getRegionId, "=")
                .GetCombineCondition();
            long lngMid = clsvExcelExportRegionFldsBL.GetFirstID_S(strCondition);
            if (lngMid == 0)
            {
                string strMsg = string.Format("��������[{0}]��ȡ�ؼ��ֲ��ɹ���", strCondition);
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            clsExcelExportRegionFldsEN objExcelExportRegionFlds = new clsExcelExportRegionFldsEN(lngMid);
            //4����ȡ�������������ԣ�
            clsExcelExportRegionFldsBL.GetExcelExportRegionFlds(ref objExcelExportRegionFlds);
            Session.Add("objExcelExportRegionFlds", objExcelExportRegionFlds);
            //5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���
            GetDataFromExcelExportRegionFldsClass(objExcelExportRegionFlds);

        }
        protected void btnSetColNum_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(txtColNum.Text) == true)
            //{
            //    clsCommonJsFunc.Alert(this, "������������");
            //    txtColNum.Focus();
            //}
            //int intColNum = int.Parse(txtColNum.Text);

            if (string.IsNullOrEmpty(txtWidth.Text) == false)
            {
                try
                {
                    int intWidth = int.Parse(txtWidth.Text);
                    clsViewRegionEN objViewRegion = clsViewRegionBL.GetObjByRegionId(getRegionId);
                    if (string.IsNullOrEmpty(txtWidth.Text) == false)
                    {
                        objViewRegion.SetWidth(intWidth)
                                 .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                .SetUpdUser(clsCommonSession.UserId)
                .Update();
                        //clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                    }
                }
                catch (Exception objException)
                {

                    clsPubVar.objLog.WriteDebugLog(objException.Message);
                }
            }
            //clsEditRegionEN obj = clsEditRegionBL.GetObjByRegionId(getRegionId);
            //obj.SetColNum(intColNum)
            //    .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
            //    .SetUpdUser(clsCommonSession.UserId)
            //    .Update();
            try
            {
                wucExcelExportRegion4Preview1.ShowControl4Regoin(getRegionId, clsPubVar.CurrSelPrjId,5, true);
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