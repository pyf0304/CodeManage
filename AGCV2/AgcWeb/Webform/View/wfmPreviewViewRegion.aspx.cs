///���ɲ�ѯ���޸ģ�ɾ������Ӽ�¼�Ŀ��Ʋ����


using System;
using System.Collections.Generic;
using System.Text;
using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AGC.FunClass;
using AutoGCLib;
using com.taishsoft.common;
using CommFunc4WebForm;

namespace AGC.Webform
{
    /// <summary>
    /// wfmQryRegionFlds_QUDI ��ժҪ˵��������Q�����ѯ��U�����޸�
    /// </summary>
    public partial class wfmPreviewViewRegion : CommWebPageBase
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
				///
				if (ViewId =="")
				{
					return ;
				}
				lblViewName.Text = clsViewInfoBL.GetObjByViewIdCache(ViewId, clsPubVar.CurrSelPrjId).ViewName;
				string strParentPage = Request.QueryString["ParentPage"].ToString();
				if (strParentPage == "ViewRegion")
				{
					clsCommonSession.seBackErrPageLinkStr  = BackViewRegionLinkStr;
				}
				else if (strParentPage == "GeneCode4Java")
				{
					clsCommonSession.seBackErrPageLinkStr  = BackGeneCode4JavaLinkStr;
				}
				else if (strParentPage == "GeneCode4WebV5")
				{
					clsCommonSession.seBackErrPageLinkStr  = BackGeneCode4WebV5LinkStr;
				}				
				else if (strParentPage == "GeneCode4WebV2005")
				{
					clsCommonSession.seBackErrPageLinkStr  = BackGeneCode4WebV2005LinkStr;
				}				
				else if (strParentPage == "GeneCode4WinV5")
				{
					clsCommonSession.seBackErrPageLinkStr  = BackGeneCode4WinV5LinkStr;
				}

				//��������Ԥ������
				HideAllPreviewRegion();	
				ViewRegionPreView(ViewId);
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
		private string BackGeneCode4JavaLinkStr
		{
			get
			{
				string strBackGeneCode4JavaLinkStr;
				strBackGeneCode4JavaLinkStr = (string)Session["BackGeneCode4JavaLinkStr"];
				if (strBackGeneCode4JavaLinkStr==null) 
				{
					strBackGeneCode4JavaLinkStr = "";
				}
				return strBackGeneCode4JavaLinkStr;
			}
			set
			{
				string strBackGeneCode4JavaLinkStr = value;
				Session.Add("BackGeneCode4JavaLinkStr", strBackGeneCode4JavaLinkStr);
			}
		}
		private string BackGeneCode4WebV5LinkStr
		{
			get
			{
				string strBackGeneCode4WebV5LinkStr;
				strBackGeneCode4WebV5LinkStr = (string)Session["BackGeneCode4WebV5LinkStr"];
				if (strBackGeneCode4WebV5LinkStr==null) 
				{
					strBackGeneCode4WebV5LinkStr = "";
				}
				return strBackGeneCode4WebV5LinkStr;
			}
			set
			{
				string strBackGeneCode4WebV5LinkStr = value;
				Session.Add("BackGeneCode4WebV5LinkStr", strBackGeneCode4WebV5LinkStr);
			}
		}
		private string BackGeneCode4WinV5LinkStr
		{
			get
			{
				string strBackGeneCode4WinV5LinkStr;
				strBackGeneCode4WinV5LinkStr = (string)Session["BackGeneCode4WinV5LinkStr"];
				if (strBackGeneCode4WinV5LinkStr==null) 
				{
					strBackGeneCode4WinV5LinkStr = "";
				}
				return strBackGeneCode4WinV5LinkStr;
			}
			set
			{
				string strBackGeneCode4WinV5LinkStr = value;
				Session.Add("BackGeneCode4WinV5LinkStr", strBackGeneCode4WinV5LinkStr);
			}
		}
		private string BackGeneCode4WebV2005LinkStr
		{
			get
			{
				string strBackGeneCode4WebV2005LinkStr;
				strBackGeneCode4WebV2005LinkStr = (string)Session["BackGeneCode4WebV2005LinkStr"];
				if (strBackGeneCode4WebV2005LinkStr==null) 
				{
					strBackGeneCode4WebV2005LinkStr = "";
				}
				return strBackGeneCode4WebV2005LinkStr;
			}
			set
			{
				string strBackGeneCode4WebV2005LinkStr = value;
				Session.Add("BackGeneCode4WebV2005LinkStr", strBackGeneCode4WebV2005LinkStr);
			}
		}

		private string BackErrPageLinkStr
		{
			get
			{
				string strBackErrPageLinkStr;
				strBackErrPageLinkStr = (string)ViewState["BackErrPageLinkStr"];
				if (strBackErrPageLinkStr==null) 
				{
					strBackErrPageLinkStr = "";
				}
				return strBackErrPageLinkStr;
			}
			set
			{
				string strBackErrPageLinkStr = value;
				ViewState.Add("BackErrPageLinkStr", strBackErrPageLinkStr);
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

	

		protected void btnGoBack_Click(object sender, System.EventArgs e)
		{
			Response.Redirect(BackErrPageLinkStr);
		}

		private void ViewRegionPreView(string strViewId)
		{
			tabCode.Visible = true;
			string strMsg = "";
			lblMsg.Text = "";
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
                List<clsViewRegionEN> arrViewRegionObjList = clsViewRegionBL.GetObjLst("ViewId = '" + strViewId + "'");
				foreach(clsViewRegionEN objViewRegionEN in arrViewRegionObjList)
				{
					switch(objViewRegionEN.RegionTypeId)
					{
						case clsRegionTypeENEx.QUERYREGION:		//��ѯ����
							tabQryRegionPreview.Visible = true;
                            WebViewCode4Html.DispQryRegionCtrl(phQryRegion, objViewInfoENEx);
							break;	
						case clsRegionTypeENEx.EDITREGION:		//�༭����
							tabEditRegionPreview.Visible = true;
                            WebViewCode4Html.DispEditRegionCtrl(phEditRegion, objViewInfoENEx);
							break;
						case clsRegionTypeENEx.DGREGION:			//�б�����
							tabDGRegionPreview.Visible = true;
                            WebViewCode4Html.DispDataGridRegionCtrl(phDataGrid, objViewInfoENEx);
							break;
						//case clsRegionTypeENEx.LISTVIEWREGION:	//LISTVIEW����
						//	tabListViewRegionPreview.Visible = true;
      //                      WebViewCode4Html.DispListViewRegionCtrl(phListView, objViewInfoENEx);
						//	break;
						case clsRegionTypeENEx.DETAILREGION:		//��ϸ��Ϣ����
							tabDetailRegionPreview.Visible = true;
                            WebViewCode4Html.DispDetailRegionCtrl(phDetailRegion, objViewInfoENEx);
							break;
						case clsRegionTypeENEx.EXCELEXPORT_REGION:	//Excel��������
							tabExcelExportRegionPreview.Visible = true;
                            WebViewCode4Html.DispExcelExportRegionCtrl(phExcelExportRegion, objViewInfoENEx);
							break;
					};
				}
			}
			catch(Exception objException)
			{
				strMsg = objException.Message;
				clsCommonJsFunc.Alert(this, strMsg);
				lblMsg.Text = strMsg;
				//				clsCommonSession.seErrMessage = objException.Message;
				//				clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;	//"../GenCode/wfmGenViewCode_WebV5.aspx";
				//				clsPubFun4Web.AccessError(this, conCurrPageName);
			}
		}

		protected void btnQuery_Click(object sender, System.EventArgs e)
		{
		
		}
		private void HideAllPreviewRegion()
		{
			tabDetailRegionPreview.Visible = false;
			tabDGRegionPreview.Visible = false;
			tabListViewRegionPreview.Visible = false;
			tabQryRegionPreview.Visible = false;
			tabEditRegionPreview.Visible = false;
			tabExcelExportRegionPreview.Visible = false;
			tabCode.Visible = false;
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