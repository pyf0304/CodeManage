using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AGC.FunClass;
using AgcCommBase;
using AutoGCLib;
//using SqlSv; 
using com.taishsoft.common;
using CommFunc4WebForm;

///���ɲ�ѯ���޸ģ�ɾ������Ӽ�¼�Ŀ��Ʋ����
using System;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AGC.Webform
{
    /// <summary>
    /// wfmViewFldInfo_QUDI ��ժҪ˵��������Q�����ѯ��U�����޸�
    /// </summary>
    public partial class wfmDesignView4WinV5_New : CommWebPageBase
    {

        protected void Page_Load(object sender, System.EventArgs e)
        {


            // �ڴ˴������û������Գ�ʼ��ҳ��
            if (!IsPostBack)	///����������ǳ��α����ã������ǵ�����ť�¼�������
            {
                ///����Ӧ�����صĿؼ�����

                ///��ʾ������ʾ��Ϣ��----------------------
                ///��ʾ������ʾ��Ϣ��======================
                //1��Ϊ��������������Դ�����б�����
                //				clsDropDownList.BindDdl_ViewTypeCode(ddlViewTypeCode);
                //string strApplicationTypeId = clsApplicationTypeBLEx.WINDOWSAPP;
                //clsDropDownList.BindDdl_ViewTypeCode(ddlViewTypeCode, strApplicationTypeId);

                //4�����ñ�ؼ����ֿؼ���ReadOnly���ԣ�
                //   ʹֻ֮������Ϊ���޸Ĺ����йؼ����ǲ��ܱ��޸ĵġ�
                DispViewInfo(ViewId);
                //Ϊ�����б��������������
                ddlFuncList.Items.Add("������EXCEL");
                ddlFuncList.Items.Add("��ListView");

                
                
                //btnGenViewCode.Attributes["onclick"] = string.Format("ClearText({0});", txtCode.ClientID);

            }
        }
        private string BackGeneCode4WinV5LinkStr
        {
            get
            {
                string strBackGeneCode4WinV5LinkStr;
                strBackGeneCode4WinV5LinkStr = (string)Session["BackGeneCode4WinV5LinkStr"];
                if (strBackGeneCode4WinV5LinkStr == null)
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
        private string BackErrPageLinkStr
        {
            get
            {
                string strBackErrPageLinkStr;
                strBackErrPageLinkStr = (string)Session["BackErrPageLinkStr"];
                if (strBackErrPageLinkStr == null)
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
                if (strErrMessage == null)
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

        //		private clsViewFldInfo objViewFldInfo
        //		{
        //			get
        //			{
        //				clsViewFldInfo pobjViewFldInfo;
        //				pobjViewFldInfo = (clsUsersEN)Session["objViewFldInfo"];
        //				if (pobjViewFldInfo==null) 
        //				{
        //					pobjViewFldInfo = null;
        //				}
        //				return pobjViewFldInfo;
        //			}
        //			set
        //			{
        //				clsViewFldInfo pobjViewFldInfo = value;
        //				Session.Add("objViewFldInfo", pobjViewFldInfo);
        //			}
        //		}

        private string UserId
        {
            get
            {
                string strUserId;
                strUserId = (string)Session["UserId"];
                if (strUserId == null)
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

        private clsUsersEN objUserBak
        {
            get
            {
                clsUsersEN pobjUser;
                pobjUser = (clsUsersEN)Session["objUser"];
                if (pobjUser == null)
                {
                    pobjUser = null;
                    string strErrMessage = "�û�����Ϊ��,���ܲ���ʱ�䳬ʱ,Session��ʧ,��Ҫ���µ�¼!";
                    Session.Add("ErrMessage", strErrMessage);
                    clsPubFun4Web.AccessError(this, conCurrPageName);
                }
                return pobjUser;
            }
            set
            {
                clsUsersEN pobjUser = value;
                Session.Add("objUser", pobjUser);
            }
        }


        private string ViewId
        {
            get
            {
                string strViewId;
                strViewId = (string)Session["ViewId"];
                if (strViewId == null)
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


        private long mId
        {
            get
            {
                long lngMId;
                if (Session["mId"] == null)
                {
                    return 0;
                }
                lngMId = long.Parse(Session["mId"].ToString());
                return lngMId;
            }
            set
            {
                long lngMId = value;
                Session.Add("mId", lngMId);
            }
        }


        private string SimpleFName
        {
            get
            {
                string strSimpleFName;
                strSimpleFName = (string)Session["SimpleFName"];
                if (strSimpleFName == null)
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


        private void DispViewInfo(string strViewId)
        {
            //1����ʾ��������
            clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, clsPubVar.CurrSelPrjId);

            //3����ʾ��������
            //ddlViewTypeCode.SelectedValue = objViewInfo.ViewTypeCode;

        }
        
        /// <summary>
        /// �����еĲ�ѯ�ؼ�������ϳ�һ��������
        /// </summary>
        /// <returns>������(strWhereCond)</returns>
        private string CombineCondition()
        {
            //ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
            //���� 1=1 and UserName = '����'
            string strWhereCond = " 1=1 and ViewFldInfo.ViewId = '" + ViewId + "'";
            //����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
            return strWhereCond;
        }

        /// <summary>
        /// �������ܣ����Ըùؼ��ֵļ�¼������ʾ�ڽ����ϣ�
        ///������     �������ǰ�ֵ������ؼ���
        /// </summary>
        /// <param name="lngMId">���¼�Ĺؼ��֣���ʾ�ñ�ؼ��ֵ�����</param>
        private void ShowData(long lngMId)
        {
            //�������裺
            //1�����ؼ����Ƿ�Ϊ�գ�
            //2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
            //3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
            //4����ȡ�������������ԣ�
            //5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���

            //1�����ؼ����Ƿ�Ϊ�գ�
            if (lngMId == 0) return;		//����ؼ���Ϊ�վͷ����˳�
            //2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
            //if (clsViewFldInfo.IsExist(lngMId) == false)		//���ùؼ��ֵļ�¼�Ƿ����
            //{
            //    string ss = "�ؼ���Ϊ��" + lngMId + "�Ĳ�����!";
            //    clsCommonJsFunc.Alert(this, ss);
            //    return;
            //}
            ////3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
            //clsViewFldInfo objViewFldInfo = new clsViewFldInfo(lngMId);
            //4����ȡ�������������ԣ�
            //objViewFldInfo.GetViewFldInfo();
            //Session.Add("objViewFldInfo", objViewFldInfo);
            //5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���
        }




        protected void lbDownLoadFile_Click(object sender, System.EventArgs e)
        {
            string strFileName = UserId + "\\" + SimpleFName;
            string strFolderName;
            string strDownLoadFileName;
            strFolderName = Server.MapPath("/ClsFile/");
            strDownLoadFileName = strFolderName + strFileName;
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
            //Response.AddHeader("Content-Disposition", "inline; filename=" + HttpUtility.UrlEncode(file.Name)); 
            Response.AddHeader("Content-Disposition", "attachment; filename=" + HttpUtility.UrlEncode(file.Name));
            Response.AddHeader("Content-Length", file.Length.ToString());
            Response.ContentType = "application/octet-stream";
            Response.WriteFile(file.FullName);
            Response.End();
            return true;
        }

        protected void btnCtlViewCode_Click(object sender, System.EventArgs e)
        {

            Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            tabCode.Visible = true;
            //tabDG.Visible = false;
            string strViewId = ViewId;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "û��ѡ���¼����ѡ��һ����Ч�Ľ����¼!";
                return;
            }
            lblMsg2.Text = "";
            try
            {

                clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
                objViewInfoENEx.PrjDataBaseId = clsPubVar.CurrPrjDataBaseId;
                clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, clsPubVar.CurrSelPrjId);
                WinViewCode_QD4CSharp autoGC5Cs_VWin = new WinViewCode_QD4CSharp(strViewId);
                if (objViewInfoENEx.ViewFldNum == 0)
                {
                   ShowCode("�������ֶ���Ϊ0���������ɽ������");
                    return;

                }
                objViewInfoENEx.FolderName = "D:\\FTP\\ClsFile\\" + UserId + "\\";
                objViewInfoENEx.CurrUserName = clsCommonSession.UserName;
                //ShowCode(autoGC5Cs_VWin.A_GenCtlCodeforTab(myEncoding, objViewInfoENEx));
                txtFileName4GenCode.Text = objViewInfoENEx.WebFormFName;
                SimpleFName = clsString.GetSimpleFName_S(objViewInfoENEx.WebFormFName);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
        }

        protected void btnCtlViewCode4Query_Click(object sender, System.EventArgs e)
        {

            Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            tabCode.Visible = true;
            //tabDG.Visible = false;
            string strViewId = ViewId;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "û��ѡ���¼����ѡ��һ����Ч�Ľ����¼!";
                return;
            }
            lblMsg2.Text = "";
            try
            {

                clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
                objViewInfoENEx.PrjDataBaseId = clsPubVar.CurrPrjDataBaseId;
                clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, clsPubVar.CurrSelPrjId);
                WinViewCode_QD4CSharp autoGC5Cs_VWin = new WinViewCode_QD4CSharp(strViewId);
                if (objViewInfoENEx.ViewFldNum == 0)
                {
                    ShowCode("�������ֶ���Ϊ0���������ɽ������");
                    return;

                }
                objViewInfoENEx.FolderName = "D:\\FTP\\ClsFile\\" + UserId + "\\";
                objViewInfoENEx.CurrUserName = clsCommonSession.UserName;
                ShowCode(autoGC5Cs_VWin.A_GenCtlCodeforTab4Query(myEncoding, objViewInfoENEx));
                txtFileName4GenCode.Text = objViewInfoENEx.WebFormFName;
                SimpleFName = clsString.GetSimpleFName_S(objViewInfoENEx.WebFormFName);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
        }

        protected void btnGenGeneLogicCode_Click(object sender, System.EventArgs e)
        {
            //			tabDG.Visible = false;

            Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            tabCode.Visible = true;

            string strViewId = ViewId;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "û��ѡ���¼����ѡ��һ����Ч�Ľ����¼!";
                return;
            }
            lblMsg2.Text = "";
            try
            {
                ///����ViewId��ȡ�༭�����TabId
                clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, clsPubVar.CurrSelPrjId);
                string strTabId = objViewInfo.MainTabId;

                //AutoGC5Cs_M autoGC5Cs_M = new AutoGC5Cs_M(strTabId, clsPubVar.CurrPrjDataBaseId);
                //autoGC5Cs_M.objPrjTabENEx.FolderName = "D:\\FTP\\ClsFile\\" + UserId + "\\";
                //autoGC5Cs_M.objPrjTabENEx.CurrUserName = clsCommonSession.UserName;
                //ShowCode(autoGC5Cs_M.A_GenGeneralLogicCode(myEncoding);
                //txtFileName4GenCode.Text = autoGC5Cs_M.objPrjTabENEx.WebFormFName;
                //SimpleFName = clsString.GetSimpleFName_S(autoGC5Cs_M.objPrjTabENEx.WebFormFName);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
        }

        protected void btnCtlViewCode_Disp_Click(object sender, System.EventArgs e)
        {
            //			tabDG.Visible = false;
            tabCode.Visible = true;

            string strViewId = ViewId;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "û��ѡ���¼����ѡ��һ����Ч�Ľ����¼!";
                return;
            }
            lblMsg2.Text = "";
            string strRe_ClsName = "";
            string strRe_FileNameWithModuleName = "";
            //string strClassFName = "";

            try
            {

                clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
                objViewInfoENEx.PrjDataBaseId = clsPubVar.CurrPrjDataBaseId;
                clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, clsPubVar.CurrSelPrjId);
                WebViewCode4Html autoGC5Cs_VWeb = new WebViewCode4Html(strViewId);
                if (objViewInfoENEx.ViewFldNum == 0)
                {
                    ShowCode("�������ֶ���Ϊ0���������ɽ������");
                    return;

                }
                objViewInfoENEx.FolderName = "D:\\FTP\\ClsFile\\" + UserId + "\\";
                objViewInfoENEx.CurrUserName = clsCommonSession.UserName;
                ShowCode(autoGC5Cs_VWeb.A_GenCtlViewCodeforTab_Disp(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName));
                txtFileName4GenCode.Text = objViewInfoENEx.WebFormFName;
                SimpleFName = clsString.GetSimpleFName_S(objViewInfoENEx.WebFormFName);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
        }

        protected void lbDispTabList_Click(object sender, System.EventArgs e)
        {
            //			tabDG.Visible = true;
        }


        protected void btnGenFunc_Click(object sender, System.EventArgs e)
        {

            tabCode.Visible = true;
            string strViewId = ViewId;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "û��ѡ���¼����ѡ��һ����Ч�Ľ����¼!";
                return;
            }
            lblMsg2.Text = "";
            try
            {

                clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
                objViewInfoENEx.PrjDataBaseId = clsPubVar.CurrPrjDataBaseId;
                clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, clsPubVar.CurrSelPrjId);
                WinViewCode_QD4CSharp autoGC5Cs_VWin = new WinViewCode_QD4CSharp(strViewId);
                if (objViewInfoENEx.ViewFldNum == 0)
                {
                    ShowCode("�������ֶ���Ϊ0���������ɽ������");
                    return;
                }
                objViewInfoENEx.FolderName = "D:\\FTP\\ClsFile\\" + UserId + "\\";
                objViewInfoENEx.CurrUserName = clsCommonSession.UserName;
                if (ddlFuncList.SelectedValue == "������EXCEL")
                {
                    ShowCode(autoGC5Cs_VWin.gfunGenbtnExportExcel4Dg_Click());
                }
                else if (ddlFuncList.SelectedValue == "��ListView")
                {
                    ShowCode(autoGC5Cs_VWin.gfunGenBindListView());
                }
                txtFileName4GenCode.Text = objViewInfoENEx.WebFormFName;
                //			SimpleFName = clsString.GetSimpleFName_S(objViewInfoENEx.WebFormFName);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
        }

        protected void btnGenGeneLogicCodeEx_Click(object sender, System.EventArgs e)
        {

            Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            tabCode.Visible = true;
            string strViewId = ViewId;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "û��ѡ���¼����ѡ��һ����Ч�Ľ����¼!";
                return;
            }
            lblMsg2.Text = "";

            try
            {
                clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, clsPubVar.CurrSelPrjId);
                string strTabId = objViewInfo.MainTabId;


            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
        }



        //protected void btnGenGeneLogicCode_Oracle_Click(object sender, EventArgs e)
        //{
        //    //			tabDG.Visible = false;

        //    Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
        //    tabCode.Visible = true;
        //    
        //    string strViewId = ViewId;
        //    if (strViewId.Trim().Length == 0)
        //    {
        //        lblMsg2.Text = "û��ѡ���¼����ѡ��һ����Ч�Ľ����¼!";
        //        return;
        //    }
        //    lblMsg2.Text = "";
        //    try
        //    {
        //        ///����ViewId��ȡ�༭�����TabId
        //        clsViewInfoEN objViewInfo = clsViewInfoBL.G1etViewInfoByViewId(strViewId);
        //        string strTabId = objViewInfo.MainTabId;

        //        AutoGC6Cs_M_Ora autoGC5Cs_M = new AutoGC6Cs_M_Ora(strTabId, clsPubVar.CurrPrjDataBaseId);
        //        autoGC5Cs_M.objPrjTabENEx.FolderName = "D:\\FTP\\ClsFile\\" + UserId + "\\";
        //        autoGC5Cs_M.objPrjTabENEx.CurrUserName = clsCommonSession.UserName;
        //        ShowCode(autoGC5Cs_M.A_GenGeneralLogicCodeNew(myEncoding);
        //        string strClassFName = autoGC5Cs_M.objPrjTabENEx.FolderName + autoGC5Cs_M.objPrjTabENEx.ClsName + ".cs";
        //        clsPubFun4BLEx.SaveClassContentToFile(strClassFName, txtCode.Text, autoGC5Cs_M.objPrjTabENEx.FolderName_Root,
        //            autoGC5Cs_M.objPrjTabENEx.BackupFolderName, myEncoding);

        //        txtFileName4GenCode.Text = autoGC5Cs_M.objPrjTabENEx.WebFormFName;
        //        SimpleFName = clsString.GetSimpleFName_S(autoGC5Cs_M.objPrjTabENEx.WebFormFName);
        //    }
        //    catch (Exception objException)
        //    {
        //        clsCommonSession.seErrMessage = objException.Message;
        //        clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
        //        clsPubFun4Web.AccessError(this, conCurrPageName);
        //    }

        //}
        //protected void btnGenGeneLogicCodeEx_Oracle_Click(object sender, EventArgs e)
        //{

        //    Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
        //    tabCode.Visible = true;
        //    string strViewId = ViewId;
        //    if (strViewId.Trim().Length == 0)
        //    {
        //        lblMsg2.Text = "û��ѡ���¼����ѡ��һ����Ч�Ľ����¼!";
        //        return;
        //    }
        //    lblMsg2.Text = "";
        //    
        //    try
        //    {
        //        clsViewInfoEN objViewInfo = clsViewInfoBL.G1etViewInfoByViewId(strViewId);
        //        string strTabId = objViewInfo.MainTabId;

        //        AutoGC6Cs_M_Ora autoGC5Cs_M = new AutoGC6Cs_M_Ora(strTabId, clsPubVar.CurrPrjDataBaseId);
        //        autoGC5Cs_M.objPrjTabENEx.FolderName = "D:\\FTP\\ClsFile\\" + UserId + "\\";
        //        autoGC5Cs_M.objPrjTabENEx.CurrUserName = clsCommonSession.UserName;

        //        ShowCode(autoGC5Cs_M.A_GenGeneralExLogicCodeNew(myEncoding);
        //        string strClassFName = autoGC5Cs_M.objPrjTabENEx.FolderName + autoGC5Cs_M.objPrjTabENEx.ClsName + ".cs";
        //        clsPubFun4BLEx.SaveClassContentToFile(strClassFName, txtCode.Text, autoGC5Cs_M.objPrjTabENEx.FolderName_Root,
        //            autoGC5Cs_M.objPrjTabENEx.BackupFolderName, myEncoding);

        //        txtFileName4GenCode.Text = autoGC5Cs_M.objPrjTabENEx.WebFormFName;
        //        SimpleFName = clsString.GetSimpleFName_S(autoGC5Cs_M.objPrjTabENEx.WebFormFName);
        //    }
        //    catch (Exception objException)
        //    {
        //        clsCommonSession.seErrMessage = objException.Message;
        //        clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
        //        clsPubFun4Web.AccessError(this, conCurrPageName);
        //    }
        //}
        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {
            //    <asp:MenuItem Text="�����QUDI_LV" Value="0"></asp:MenuItem>
            //    <asp:MenuItem Text="������Ͻ���_ListView" Value="�½���"></asp:MenuItem>
            //    <asp:MenuItem Text="������Ͻ���_GridView" Value="2"></asp:MenuItem>
            //    <asp:MenuItem Text="�������" Value="3"></asp:MenuItem>
            //    <asp:MenuItem Text="�����ѯ" Value="4"></asp:MenuItem>
            int intMenuIndex = int.Parse(e.Item.Value);
            switch (intMenuIndex)
            {
                case 0://�����QUDI_LV,0008
                    new clsCommonSession().ViewTypeCode = enumViewTypeCodeTab.Table_QD_InvokeUI_ListView_11;// "0008";
                    break;
                case 1://������Ͻ���_ListView,0011
                    new clsCommonSession().ViewTypeCode = enumViewTypeCodeTab.Table_QD_InvokeUI_ListView_11;// "0011";
                    break;
                case 2://������Ͻ���_GridView,0020
                    new clsCommonSession().ViewTypeCode = enumViewTypeCodeTab.Table_QD_InvokeUI_GridView_20;// "0020";
                    break;
                case 3://�������,0012
                    new clsCommonSession().ViewTypeCode = enumViewTypeCodeTab.Table_Insert_1;// "0012";
                    break;
                case 4://�����ѯ,
                    new clsCommonSession().ViewTypeCode = enumViewTypeCodeTab.Table_Query_3;// "0008";
                    break;
            }
            MultiView1.ActiveViewIndex = intMenuIndex;
        }
        /// <summary>
        /// �����QUDI_LV,0008
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnGenViewCode01_ClickBak(object sender, EventArgs e)
        {
            //			tabDG.Visible = false;

            Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            tabCode.Visible = true;
            string strViewId = ViewId;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "û��ѡ���¼����ѡ��һ����Ч�Ľ����¼!";
                return;
            }
            lblMsg2.Text = "";
            string strRe_ClsName = "";
            string strRe_FileNameWithModuleName = "";

            try
            {

                clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
                objViewInfoENEx.PrjDataBaseId = clsPubVar.CurrPrjDataBaseId;
                clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, clsPubVar.CurrSelPrjId);
                WinViewCode_QD4CSharp autoGC5Cs_VWin = new WinViewCode_QD4CSharp(strViewId);
                objViewInfoENEx.FolderName = "D:\\FTP\\ClsFile\\" + UserId + "\\";
                objViewInfoENEx.CurrUserName = clsCommonSession.UserName;

                objViewInfoENEx.IsDesign = false;
                //�Ƿ�ʹ�ÿؼ�
                objViewInfoENEx.IsUseCtl = chkIsUseCtrl.Checked;
                autoGC5Cs_VWin.CurrUserName = clsCommonSession.UserName;
                ShowCode(autoGC5Cs_VWin.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName));
                txtFileName4GenCode.Text = objViewInfoENEx.WebFormFName;
                SimpleFName = clsString.GetSimpleFName_S(objViewInfoENEx.WebFormFName);
            }
            catch (Exception objException)
            {

                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;	//"./Webform/GenCode/wfmGenViewCode_WebV5.aspx";
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }

        }
        protected void btnGenCode_Click(object sender, EventArgs e)
        {
            Button objButton = sender as Button;

            string strCodeTypeId = objButton.CommandArgument;

            clsCodeTypeEN objCodeTypeEN = clsCodeTypeBL.GetObjByCodeTypeIdCache(strCodeTypeId);
            if (objCodeTypeEN == null)
            {
                string strMsg = string.Format("��ť:{0}���������(CommandArgument):{1}���ò���ȷ.", objButton.Text, strCodeTypeId);
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            string strCharEncodingId = clsPubFun.GetCharEncodingIdByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);

            string strViewId = clsCommonSession.ViewId;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "û��ѡ���¼����ѡ��һ����Ч�Ľ����¼!";
                return;
            }
            lblMsg2.Text = "";

            string strCmPrjId = "";
            string strTabId = "";
            string strRe_ClsName = "";
            string strRe_FileNameWithModuleName = "";
            //clsPubConst.ClassName cnClassName = clsPubConst.ClassName.WinViewCode_QD;

            try
            {

                string strCodeText = AutoGC.GeneCode(objCodeTypeEN.CodeTypeENName, "",
                               vsLangType, vsDataBaseType, strTabId, strViewId, strCmPrjId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId,
                              clsCommonSession.ApplicationTypeId, clsSysParaEN.strUserId, ref strRe_ClsName, ref strRe_FileNameWithModuleName);

                //strCodeText = clsViewInfoBLEx_GeneCode.GeneViewCode(strViewId, rblNetVersion.SelectedValue,
                //    clsPubVar.objCurrSelProject,
                //    clsCommonSession.UserId,
                //     clsCommonSession.UserName, "", "", strCharEncodingId,
                //   ref strFileName4GenCode, ref strClsName, ref strCodePath);
                ShowCode(strCodeText);
                txtFileName4GenCode.Text = strRe_ClsName;
                vsSimpleFName = strRe_ClsName;
                txtFileName4GenCode.Text = strRe_FileNameWithModuleName;
                
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }

            //			tabDG.Visible = false;

            //Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            //tabCode.Visible = true;
            //string strViewId = ViewId;
            //if (strViewId.Trim().Length == 0)
            //{
            //    lblMsg2.Text = "û��ѡ���¼����ѡ��һ����Ч�Ľ����¼!";
            //    return;
            //}
            //lblMsg2.Text = "";
            //string strRe_ClsName = "";
            //string strRe_FileNameWithModuleName = "";

            //try
            //{

            //    clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
            //    objViewInfoENEx.PrjDataBaseId = clsPubVar.CurrPrjDataBaseId;
            //    clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, clsPubVar.CurrSelPrjId);
            //    WinViewCode_QD4CSharp autoGC5Cs_VWin = new WinViewCode_QD4CSharp(strViewId);
            //    objViewInfoENEx.FolderName = "D:\\FTP\\ClsFile\\" + UserId + "\\";
            //    objViewInfoENEx.CurrUserName = clsCommonSession.UserName;

            //    objViewInfoENEx.IsDesign = false;
            //    //�Ƿ�ʹ�ÿؼ�
            //    objViewInfoENEx.IsUseCtl = chkIsUseCtrl.Checked;
            //    autoGC5Cs_VWin.CurrUserName = clsCommonSession.UserName;
            //    ShowCode(autoGC5Cs_VWin.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName);
            //    txtFileName4GenCode.Text = objViewInfoENEx.WebFormFName;
            //    SimpleFName = clsString.GetSimpleFName_S(objViewInfoENEx.WebFormFName);
            //}
            //catch (Exception objException)
            //{

            //    clsCommonSession.seErrMessage = objException.Message;
            //    clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;	//"./Webform/GenCode/wfmGenViewCode_WebV5.aspx";
            //    clsPubFun4Web.AccessError(this, conCurrPageName);
            //}

        }
        protected void btnGenViewCode02_Click(object sender, EventArgs e)
        {

            Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            tabCode.Visible = true;
            string strViewId = ViewId;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "û��ѡ���¼����ѡ��һ����Ч�Ľ����¼!";
                return;
            }
            lblMsg2.Text = "";
            string strRe_ClsName = "";
            string strRe_FileNameWithModuleName = "";

            try
            {

                clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
                objViewInfoENEx.PrjDataBaseId = clsPubVar.CurrPrjDataBaseId;
                clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, clsPubVar.CurrSelPrjId);
                WinViewCode_QD4CSharp autoGC5Cs_VWin = new WinViewCode_QD4CSharp(strViewId);
                objViewInfoENEx.FolderName = "D:\\FTP\\ClsFile\\" + UserId + "\\";
                objViewInfoENEx.CurrUserName = clsCommonSession.UserName;
                objViewInfoENEx.MainSubViewType = clsPubConst.MainSubViewType.MainView;
                objViewInfoENEx.IsDesign = false;
                //�Ƿ�ʹ�ÿؼ�
                objViewInfoENEx.IsUseCtl = chkIsUseCtrl.Checked;

                ShowCode(autoGC5Cs_VWin.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName));
                txtFileName4GenCode.Text = objViewInfoENEx.WebFormFName;
                SimpleFName = clsString.GetSimpleFName_S(objViewInfoENEx.WebFormFName);
            }
            catch (Exception objException)
            {

                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;	//"./Webform/GenCode/wfmGenViewCode_WebV5.aspx";
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }

        }
        protected void btnGenViewDesignCode02_Click(object sender, EventArgs e)
        {

            Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            tabCode.Visible = true;
            string strViewId = ViewId;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "û��ѡ���¼����ѡ��һ����Ч�Ľ����¼!";
                return;
            }
            lblMsg2.Text = "";
            string strRe_ClsName = "";
            string strRe_FileNameWithModuleName = "";

            try
            {

                clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
                objViewInfoENEx.PrjDataBaseId = clsPubVar.CurrPrjDataBaseId;
                clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, clsPubVar.CurrSelPrjId);
                WinViewCode_QD4CSharp autoGC5Cs_VWin = new WinViewCode_QD4CSharp(strViewId);
                objViewInfoENEx.FolderName = "D:\\FTP\\ClsFile\\" + UserId + "\\";
                objViewInfoENEx.CurrUserName = clsCommonSession.UserName;
                objViewInfoENEx.MainSubViewType = clsPubConst.MainSubViewType.MainView;

                objViewInfoENEx.IsDesign = true;
                //�Ƿ�ʹ�ÿؼ�
                objViewInfoENEx.IsUseCtl = chkIsUseCtrl.Checked;

                ShowCode(autoGC5Cs_VWin.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName));
                txtFileName4GenCode.Text = objViewInfoENEx.WebFormFName;
                SimpleFName = clsString.GetSimpleFName_S(objViewInfoENEx.WebFormFName);
            }
            catch (Exception objException)
            {

                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;	//"./Webform/GenCode/wfmGenViewCode_WebV5.aspx";
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }


        }
        protected void btnGenViewCode02_Sub_Click(object sender, EventArgs e)
        {

            Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            tabCode.Visible = true;
            string strViewId = ViewId;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "û��ѡ���¼����ѡ��һ����Ч�Ľ����¼!";
                return;
            }

            clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
            objViewInfoENEx.PrjDataBaseId = clsPubVar.CurrPrjDataBaseId;
            clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, clsPubVar.CurrSelPrjId);

            lblMsg2.Text = "";
            string strRe_ClsName = "";
            string strRe_FileNameWithModuleName = "";

            try
            {
                WinViewCode_QD4CSharp autoGC5Cs_VWin = new WinViewCode_QD4CSharp(strViewId);
                objViewInfoENEx.FolderName = "D:\\FTP\\ClsFile\\" + UserId + "\\";
                objViewInfoENEx.CurrUserName = clsCommonSession.UserName;
                objViewInfoENEx.MainSubViewType = clsPubConst.MainSubViewType.SubView;

                objViewInfoENEx.IsDesign = false;
                //�Ƿ�ʹ�ÿؼ�
                objViewInfoENEx.IsUseCtl = chkIsUseCtrl.Checked;

                ShowCode(autoGC5Cs_VWin.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName));
                txtFileName4GenCode.Text = objViewInfoENEx.WebFormFName;
                SimpleFName = clsString.GetSimpleFName_S(objViewInfoENEx.WebFormFName);
            }
            catch (Exception objException)
            {

                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;	//"./Webform/GenCode/wfmGenViewCode_WebV5.aspx";
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }



        }
        protected void btnGenViewDesignCode02_Sub_Click(object sender, EventArgs e)
        {

            Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            tabCode.Visible = true;
            string strViewId = ViewId;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "û��ѡ���¼����ѡ��һ����Ч�Ľ����¼!";
                return;
            }
            lblMsg2.Text = "";
            string strRe_ClsName = "";
            string strRe_FileNameWithModuleName = "";

            try
            {

                clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
                objViewInfoENEx.PrjDataBaseId = clsPubVar.CurrPrjDataBaseId;
                clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, clsPubVar.CurrSelPrjId);
                WinViewCode_QD4CSharp autoGC5Cs_VWin = new WinViewCode_QD4CSharp(strViewId);
                objViewInfoENEx.FolderName = "D:\\FTP\\ClsFile\\" + UserId + "\\";
                objViewInfoENEx.CurrUserName = clsCommonSession.UserName;
                objViewInfoENEx.MainSubViewType = clsPubConst.MainSubViewType.SubView;

                objViewInfoENEx.IsDesign = true;
                //�Ƿ�ʹ�ÿؼ�
                objViewInfoENEx.IsUseCtl = chkIsUseCtrl.Checked;

                ShowCode(autoGC5Cs_VWin.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName));
                txtFileName4GenCode.Text = objViewInfoENEx.WebFormFName;
                SimpleFName = clsString.GetSimpleFName_S(objViewInfoENEx.WebFormFName);
            }
            catch (Exception objException)
            {

                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;	//"./Webform/GenCode/wfmGenViewCode_WebV5.aspx";
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }



        }
        protected void btnGenViewCode03_Click(object sender, EventArgs e)
        {

            Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            tabCode.Visible = true;
            string strViewId = ViewId;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "û��ѡ���¼����ѡ��һ����Ч�Ľ����¼!";
                return;
            }

            clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
            objViewInfoENEx.PrjDataBaseId = clsPubVar.CurrPrjDataBaseId;
            clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, clsPubVar.CurrSelPrjId);
            lblMsg2.Text = "";
            string strRe_ClsName = "";
            string strRe_FileNameWithModuleName = "";

            try
            {
                WinViewCode_QD4CSharp autoGC5Cs_VWin = new WinViewCode_QD4CSharp(strViewId);
                objViewInfoENEx.FolderName = "D:\\FTP\\ClsFile\\" + UserId + "\\";
                objViewInfoENEx.CurrUserName = clsCommonSession.UserName;
                objViewInfoENEx.MainSubViewType = clsPubConst.MainSubViewType.MainView;

                objViewInfoENEx.IsDesign = false;
                //�Ƿ�ʹ�ÿؼ�
                objViewInfoENEx.IsUseCtl = chkIsUseCtrl.Checked;
                enumViewTypeCodeTab intViewTypeCode = new clsCommonSession().ViewTypeCode;
                ShowCode(autoGC5Cs_VWin.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName));
                txtFileName4GenCode.Text = objViewInfoENEx.WebFormFName;
                SimpleFName = clsString.GetSimpleFName_S(objViewInfoENEx.WebFormFName);
            }
            catch (Exception objException)
            {

                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;	//"./Webform/GenCode/wfmGenViewCode_WebV5.aspx";
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }

        }
        protected void btnGenViewDesignCode03_Click(object sender, EventArgs e)
        {

            Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            tabCode.Visible = true;
            string strViewId = ViewId;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "û��ѡ���¼����ѡ��һ����Ч�Ľ����¼!";
                return;
            }

            clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
            objViewInfoENEx.PrjDataBaseId = clsPubVar.CurrPrjDataBaseId;
            clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, clsPubVar.CurrSelPrjId);
            lblMsg2.Text = "";
            string strRe_ClsName = "";
            string strRe_FileNameWithModuleName = "";

            try
            {
                WinViewCode_QD4CSharp autoGC5Cs_VWin = new WinViewCode_QD4CSharp(strViewId);
                objViewInfoENEx.FolderName = "D:\\FTP\\ClsFile\\" + UserId + "\\";
                objViewInfoENEx.CurrUserName = clsCommonSession.UserName;
                objViewInfoENEx.MainSubViewType = clsPubConst.MainSubViewType.MainView;
                //objViewInfoENEx.NetVersion = "2005";

                objViewInfoENEx.IsDesign = true;
                //�Ƿ�ʹ�ÿؼ�
                objViewInfoENEx.IsUseCtl = chkIsUseCtrl.Checked;

                ShowCode(autoGC5Cs_VWin.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName));
                txtFileName4GenCode.Text = objViewInfoENEx.WebFormFName;
                SimpleFName = clsString.GetSimpleFName_S(objViewInfoENEx.WebFormFName);
            }
            catch (Exception objException)
            {

                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;	//"./Webform/GenCode/wfmGenViewCode_WebV5.aspx";
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }

        }
        protected void btnGenViewCode03_Sub_Click(object sender, EventArgs e)
        {

            Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            tabCode.Visible = true;
            string strViewId = ViewId;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "û��ѡ���¼����ѡ��һ����Ч�Ľ����¼!";
                return;
            }
            lblMsg2.Text = "";
            string strRe_ClsName = "";
            string strRe_FileNameWithModuleName = "";

            try
            {

                clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
                objViewInfoENEx.PrjDataBaseId = clsPubVar.CurrPrjDataBaseId;
                clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, clsPubVar.CurrSelPrjId);
                WinViewCode_QD4CSharp autoGC5Cs_VWin = new WinViewCode_QD4CSharp(strViewId);
                objViewInfoENEx.FolderName = "D:\\FTP\\ClsFile\\" + UserId + "\\";
                objViewInfoENEx.CurrUserName = clsCommonSession.UserName;
                objViewInfoENEx.MainSubViewType = clsPubConst.MainSubViewType.SubView;

                objViewInfoENEx.IsDesign = false;
                //�Ƿ�ʹ�ÿؼ�
                objViewInfoENEx.IsUseCtl = chkIsUseCtrl.Checked;

                ShowCode(autoGC5Cs_VWin.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName));
                txtFileName4GenCode.Text = objViewInfoENEx.WebFormFName;
                SimpleFName = clsString.GetSimpleFName_S(objViewInfoENEx.WebFormFName);
            }
            catch (Exception objException)
            {

                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;	//"./Webform/GenCode/wfmGenViewCode_WebV5.aspx";
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }

        }
        protected void btnGenViewDesignCode03_Sub_Click(object sender, EventArgs e)
        {

            Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            tabCode.Visible = true;
            string strViewId = ViewId;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "û��ѡ���¼����ѡ��һ����Ч�Ľ����¼!";
                return;
            }

            clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
            clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, clsPubVar.CurrSelPrjId);
            lblMsg2.Text = "";
            string strRe_ClsName = "";
            string strRe_FileNameWithModuleName = "";

            try
            {
                WinViewCode_QD4CSharp autoGC5Cs_VWin = new WinViewCode_QD4CSharp(strViewId);
                objViewInfoENEx.FolderName = "D:\\FTP\\ClsFile\\" + UserId + "\\";
                objViewInfoENEx.CurrUserName = clsCommonSession.UserName;
                objViewInfoENEx.MainSubViewType = clsPubConst.MainSubViewType.SubView;

                objViewInfoENEx.IsDesign = true;
                //�Ƿ�ʹ�ÿؼ�
                objViewInfoENEx.IsUseCtl = chkIsUseCtrl.Checked;

                ShowCode(autoGC5Cs_VWin.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName));
                txtFileName4GenCode.Text = objViewInfoENEx.WebFormFName;
                SimpleFName = clsString.GetSimpleFName_S(objViewInfoENEx.WebFormFName);
            }
            catch (Exception objException)
            {

                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;	//"./Webform/GenCode/wfmGenViewCode_WebV5.aspx";
                clsPubFun4Web.AccessError(this, conCurrPageName);
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

        protected clsPubConst.LangType vsLangType
        {
            get
            {
                clsPubConst.LangType strLangType;
                if (ViewState["LangType"] == null)
                {
                    strLangType = clsPubConst.LangType.CSharp;//"C#.NET";
                    return strLangType;
                }
                strLangType = (clsPubConst.LangType)ViewState["LangType"];

                return strLangType;
            }
            set
            {
                clsPubConst.LangType strLangType = value;
                ViewState.Add("LangType", strLangType);
            }
        }

        /// <summary>
        /// ��ǰ��ѡ����������ͣ���Ϊ��"Ms Sql", "Oracle"; "MySql";
        /// </summary>
        protected clsPubConst.DataBaseType vsDataBaseType
        {
            get
            {
                clsPubConst.DataBaseType strDataBaseType;

                if (ViewState["DataBaseType"] == null)
                {
                    return clsPubConst.DataBaseType.MsSql;
                }
                strDataBaseType = (clsPubConst.DataBaseType)ViewState["DataBaseType"];
                return strDataBaseType;
            }
            set
            {
                clsPubConst.DataBaseType strDataBaseType = value;
                ViewState.Add("DataBaseType", strDataBaseType);
            }
        }

        private string vsSimpleFName
        {
            get
            {
                string strSimpleFName;
                strSimpleFName = (string)ViewState["vsSimpleFName"];
                if (strSimpleFName == null)
                {
                    strSimpleFName = "";
                }
                return strSimpleFName;
            }
            set
            {
                string strSimpleFName = value;
                ViewState.Add("vsSimpleFName", strSimpleFName);
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