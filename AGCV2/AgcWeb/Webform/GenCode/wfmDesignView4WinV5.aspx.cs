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
//using SqlSv; 
using com.taishsoft.commdb;
using CommFunc4WebForm;


using System.Collections.Generic;
using com.taishsoft.common;
using System.Text;

using AGC.Entity;

using AGC.BusinessLogic;using AGC.FunClass;

using AGC.BusinessLogicEx;
using AgcCommBase;
using AutoGCLib;


namespace AGC.Webform
{
    /// <summary>
    /// wfmViewFldInfo_QUDI ��ժҪ˵��������Q�����ѯ��U�����޸�
    /// </summary>
    public partial class wfmDesignView4WinV5 : CommWebPageBase
    {

        protected void Page_Load(object sender, System.EventArgs e)
        {
            string js = "";
            js += "<script>\r\r\n";
            js += "function ld(){\r\r\n";
            js += "for(i=0;i<document.getElementsByName('RadioName').length;i++)\r\r\n";
            js += "if(document.getElementsByName('RadioName')[i].value==";
            js += "document.getElementById('" + rd.ClientID + "').value) ";
            js += "document.getElementsByName('RadioName')[i].checked=true\r\r\n";
            js += "}\r\r\n";
            js += "window.onload=ld\r\r\n";
            js += "</" + "script>\r\r\n";
            //			this.RegisterStartupScript("js",js); 
            ClientScript.RegisterStartupScript(this.GetType(), "js", js);

            // �ڴ˴������û������Գ�ʼ��ҳ��
            if (!IsPostBack)	///����������ǳ��α����ã������ǵ�����ť�¼�������
			{
                ///����Ӧ�����صĿؼ�����

                ///��ʾ������ʾ��Ϣ��----------------------
                ///��ʾ������ʾ��Ϣ��======================
                //1��Ϊ��������������Դ�����б�����
                //				clsDropDownList.BindDdl_ViewTypeCode(ddlViewTypeCode);
                string strApplicationTypeId = clsApplicationTypeBLEx.WINDOWSAPP.ToString();
                
                //3����ʾ�������ı�������DATAGRID��
                //BindDg_ViewFldInfo();		//��ʾ�����ֶα����Ϣ
                //4�����ñ�ؼ����ֿؼ���ReadOnly���ԣ�
                //   ʹֻ֮������Ϊ���޸Ĺ����йؼ����ǲ��ܱ��޸ĵġ�
                DispViewInfo(ViewId);
                //Ϊ�����б��������������
                ddlFuncList.Items.Add("������EXCEL");
                ddlFuncList.Items.Add("��ListView");
                divViewFldList.Visible = false;
                divQueryFldList.Visible = false;
                divEditCtrlFldList.Visible = false;
                divDispDataFldList.Visible = false;
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

        
        ///// <summary>
        ///// ��¼���û�ID�����ڼ���û�Ȩ��
        ///// </summary>
        //protected string vsUserId
        //{
        //    get
        //    {
        //        string strUserId;
        //        strUserId = (string)ViewState["UserId"];
        //        if (strUserId == null)
        //        {
        //            strUserId = "";
        //        }
        //        return strUserId;
        //    }
        //    set
        //    {
        //        string strUserId = value;
        //        ViewState.Add("UserId", strUserId);
        //    }
        //}

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
        //private string PrjId
        //{
        //    get
        //    {
        //        string strPrjId;
        //        strPrjId = (string)Session["P1rjId"];
        //        if (strPrjId==null) 
        //        {
        //            strPrjId = "";
        //            clsCommForWebForm.CheckPrjId(strPrjId, this);
        //        }
        //        return strPrjId;
        //    }
        //    set
        //    {
        //        string strPrjId = value;
        //        Session.Add("PrjId", strPrjId);
        //    }
        //}

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

            lblViewName.Text = objViewInfo.ViewName;
            //4����ʾ���湦��
            lblViewFunction.Text = objViewInfo.ViewFunction;

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

        ///���ɰ�DATAGRID�Ĵ���
        /// <summary>
        /// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
        ///			 ����ʾ��DATAGRID�С�
        /// </summary>
        //private void BindDg_ViewFldInfo()
        //{
        //    //�������裺(��5��)
        //    //	1����Ͻ�����������
        //    //	2��������������ȡ�ñ�����������DataTable��
        //    //	3���б�DATAGRID�ĵ�ǰҳ���Ƿ񳬳�DATAGRID��ҳ����Χ
        //    //	4������DATAGRID������Դ(DataSource)��
        //    //	5����DATAGRID������DataTable��������ʾ��DATAGRID��
        //    //	6�����ü�¼����״̬��
        //    //		�ڱ��������ǰ�״̬��ʾ�ڿؼ�txtRecCount�С�

        //    //	1����Ͻ�����������
        //    string strWhereCond = CombineCondition();
        //    //	2��������������ȡ�ñ�����������DataTable��
        //    System.Data.DataTable objDT = clsViewFldInfo.GetViewFldInfoT(strWhereCond);
        //    //	3�����DATAGRID�ĵ�ǰҳ���Ƿ񳬳�DATAGRID��ҳ����Χ
        //    //		3.1 ���ȼ���ҳ����
        //    //		3.2 �����ǰҳ����ҳ����Ϊ���һҳ
        //    int intPages = CalcPages(objDT.Rows.Count, this.dgViewFldInfo.PageSize);
        //    if (intPages==0) 
        //    {
        //        this.dgViewFldInfo.CurrentPageIndex = 0;
        //    }
        //    else if (this.dgViewFldInfo.CurrentPageIndex > intPages - 1) 
        //    {
        //        this.dgViewFldInfo.CurrentPageIndex = intPages - 1;
        //    }
        //    //	4������DATAGRID������Դ(DataSource)��
        //    DataView objDV = objDT.DefaultView;
        //    //			objDV.Sort = strSortBy;     ///ע����һ�д����п�����Ҫע�͵���Ŀǰ���н����ڵ����Ĳ�ѯ������������
        //    this.dgViewFldInfo.DataSource=objDV;
        //    //	5����DATAGRID������DataTable��������ʾ��DATAGRID��
        //    this.dgViewFldInfo.DataBind();
        //    //	6�����ü�¼����״̬��
        //    this.txtRecCount.Text= objDT.Rows.Count.ToString();
        //}

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
            if (intRecCount % intPageSize != 0) intPages++;
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
            this.dgViewFldInfo.CurrentPageIndex = 0;
            //�ѱ��¼��������ʾ��DATAGRID��
            //BindDg_ViewFldInfo();
        }
        /// <summary>
        /// �������ܣ��¼��������ڸ���DATAGRID�ĵ�ǰҳ����ʱ�����ĺ�����
        ///			  ���幦����������ʾ��ҳ(������ҳ����)�����ݡ�
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void dgViewFldInfo_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            //�������裺����2����
            //1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
            //2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ

            //			if(Request.Form["RadioName"] != null) 
            //			{ 
            //				rd.Value =  Request.Form["RadioName"].ToString(); 
            //			}

            //1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
            this.dgViewFldInfo.CurrentPageIndex = e.NewPageIndex;
            //2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ
            //BindDg_ViewFldInfo();
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
            if (lngMId == 0) return;        //����ؼ���Ϊ�վͷ����˳�
                                            //2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
                                            //if (clsViewFldInfo.IsExist(lngMId) == false)		//���ùؼ��ֵļ�¼�Ƿ����
                                            //{
                                            //    string ss = "�ؼ���Ϊ��" + lngMId + "�Ĳ�����!";
                                            //    clsCommonJsFunc.Alert(this, ss);
                                            //    return ;
                                            //}
                                            ////3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
                                            //clsViewFldInfo objViewFldInfo = new clsViewFldInfo(lngMId);
                                            //4����ȡ�������������ԣ�
                                            //objViewFldInfo.GetViewFldInfo();
                                            //Session.Add("objViewFldInfo", objViewFldInfo);
                                            //5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���
        }



        protected void ibDown_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            int intStepIndex;
            if (Request.Form["RadioName"] != null)
            {
                rd.Value = Request.Form["RadioName"].ToString();
                intStepIndex = int.Parse(rd.Value);
                //bool bolIsSuccess = (new clsViewFldInfoEx().DownOrderByOne(ViewId, intStepIndex));
                //if (bolIsSuccess == true)
                //{

                //    intNextStepIndex = intStepIndex + 1;
                //    rd.Value = intNextStepIndex.ToString();

                //    ///ͨ��intNextStepIndex���㵱ǰ������ҳ��P1
                //    ///���DATAGRID�ĵ�ǰҳ��С��P1�����ӵ�ǰ��ǰҳ��

                //    ///ͨ��intNextStepIndex���㵱ǰ������ҳ��P1
                //    int intPages = CalcPages(intNextStepIndex, this.dgViewFldInfo.PageSize);
                //    ///���DATAGRID�ĵ�ǰҳ��С��P1�����ӵ�ǰ��ǰҳ��
                //    if (this.dgViewFldInfo.CurrentPageIndex < intPages-1 ) 
                //    {
                //        this.dgViewFldInfo.CurrentPageIndex = intPages-1;
                //    }
                //BindDg_ViewFldInfo();
                //}
            }

        }

        protected void ibUp_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            int intStepIndex;
            if (Request.Form["RadioName"] != null)
            {
                rd.Value = Request.Form["RadioName"].ToString();
                intStepIndex = int.Parse(rd.Value);
                //bool bolIsSuccess = (new clsViewFldInfoEx().UpOrderByOne(ViewId, intStepIndex));
                //if (bolIsSuccess == true)
                //{
                //    intPrevStepIndex = intStepIndex - 1;
                //    rd.Value = intPrevStepIndex.ToString();
                //    ///ͨ��intNextStepIndex���㵱ǰ������ҳ��P1
                //    ///���DATAGRID�ĵ�ǰҳ��С��P1�����ӵ�ǰ��ǰҳ��

                //    ///ͨ��intNextStepIndex���㵱ǰ������ҳ��P1
                //    int intPages = CalcPages(intPrevStepIndex, this.dgViewFldInfo.PageSize);
                //    ///���DATAGRID�ĵ�ǰҳ��С��P1�����ӵ�ǰ��ǰҳ��
                //    if (this.dgViewFldInfo.CurrentPageIndex > intPages-1 ) 
                //    {
                //        this.dgViewFldInfo.CurrentPageIndex = intPages-1;
                //    }
                //    //BindDg_ViewFldInfo();
                //}
            }
        }

        protected void dgViewFldInfo_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }


        protected void btnDelStep_Click(object sender, System.EventArgs e)
        {
            List<string> arrLst = new List<string>();
            int intStepIndex;
            //long lngIdForCurrStep;
            if (Request.Form["RadioName"] == null)
            {
                return;
            }
            rd.Value = Request.Form["RadioName"].ToString();
            intStepIndex = int.Parse(rd.Value);
            //2����ȡ��ǰ��¼(���������)�Ĺؼ���(lngIdForCurrStep)��
            //arrLst = clsViewFldInfo.funGetFldValue("ViewFldInfo", "mId",  "ViewId='" + ViewId + "' and StepIndex=" + intStepIndex.ToString());
            //lngIdForCurrStep =long.Parse(arrLst[0].ToString());
            //clsViewFldInfoEx.DelRecordEx(lngIdForCurrStep);
            //BindDg_ViewFldInfo();
        }

        protected void lbReturn_Click(object sender, System.EventArgs e)
        {
            Response.Redirect(BackGeneCode4WinV5LinkStr);
        }


        protected void btnDelFld_Click(object sender, System.EventArgs e)
        {
            string strMId = (string)rd.Value;
            if (strMId.Trim().Length == 0)
            {
                lblMsg2.Text = "û��ѡ���¼����ѡ��һ����Ч���ֶμ�¼!";
                return;
            }
            long lngMId = long.Parse(strMId);
            //clsViewFldInfo.DelRecord(lngMId);
            //BindDg_ViewFldInfo();
        }


        protected void btnSetFld_Click(object sender, System.EventArgs e)
        {
            string strMId = (string)rd.Value;
            if (strMId.Trim().Length == 0)
            {
                lblMsg2.Text = "û��ѡ���¼����ѡ��һ����Ч���ֶμ�¼!";
                return;
            }
            long lngMId = long.Parse(strMId);
            //�������裺���ܹ�2����
            //1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
            //2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�

            mId = lngMId;

            Response.Redirect("wfmViewSetField_Edit.aspx");

        }

        protected void ddlViewTypeCode_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            //if (ddlViewTypeCode.SelectedValue == "0011")
            //{
            //    ddlSubViewName.Items.Add("�����棺��ѯ��ɾ������_ListView");
            //    ddlSubViewName.Items.Add("�༭���棺�޸ġ���ӽ���_ListView");
            //    ddlSubViewName.Items.Add("�����棺��ѯ��ɾ������_DataGridView");
            //    ddlSubViewName.Items.Add("�༭���棺�޸ġ���ӽ���_DataGridView");
            //}
        }

        protected void btnGenViewCode_Click(object sender, System.EventArgs e)
        {

            GenViewCode(false);
        }
        protected void btnGenViewDesignCode_Click(object sender, EventArgs e)
        {
            GenViewCode(true);
        }
        private void GenViewCode(bool bolIsDesign)
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
                clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, clsPubVar.CurrSelPrjId);
                WinViewCode_QD4CSharp autoGC5Cs_VWin = new WinViewCode_QD4CSharp(strViewId);
                if (objViewInfoENEx.ViewFldNum == 0)
                {
                    ShowCode("�������ֶ���Ϊ0���������ɽ������");
                    return;
                }
                objViewInfoENEx.FolderName = "D:\\FTP\\ClsFile\\" + clsCommonSession.UserId + "\\";
                objViewInfoENEx.CurrUserName = clsCommonSession.UserName;
                if (ddlSubViewName.SelectedIndex == 0)
                {
                    objViewInfoENEx.MainSubViewType = clsPubConst.MainSubViewType.MainView;
                }
                else if (ddlSubViewName.SelectedIndex == 1)
                {
                    objViewInfoENEx.MainSubViewType = clsPubConst.MainSubViewType.SubView;
                }
                else if (ddlSubViewName.SelectedIndex == 2)
                {
                    objViewInfoENEx.MainSubViewType = clsPubConst.MainSubViewType.MainView;
                }
                else if (ddlSubViewName.SelectedIndex == 3)
                {
                    objViewInfoENEx.MainSubViewType = clsPubConst.MainSubViewType.SubView;
                }

                objViewInfoENEx.IsDesign = bolIsDesign;
                //�Ƿ�ʹ�ÿؼ�
                objViewInfoENEx.IsUseCtl = chkIsUseCtrl.Checked;


                ShowCode(autoGC5Cs_VWin.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName));
                txtFileName4GenCode.Text = objViewInfoENEx.FileName;
                SimpleFName = clsString.GetSimpleFName_S(objViewInfoENEx.FileName);
            }
            catch (Exception objException)
            {

                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;	//"../GenCode/wfmGenViewCode_WebV5.aspx";
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
        }
        protected void lbDownLoadFile_Click(object sender, System.EventArgs e)
        {
            string strFileName = clsCommonSession.UserId + "\\" + SimpleFName;
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
                clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, clsPubVar.CurrSelPrjId);
                WinViewCode_QD4CSharp autoGC5Cs_VWin = new WinViewCode_QD4CSharp(strViewId);
                if (objViewInfoENEx.ViewFldNum == 0)
                {
                    ShowCode("�������ֶ���Ϊ0���������ɽ������");
                    return;

                }
                objViewInfoENEx.FolderName = "D:\\FTP\\ClsFile\\" + clsCommonSession.UserId + "\\";
                objViewInfoENEx.CurrUserName = clsCommonSession.UserName;
                //ShowCode(autoGC5Cs_VWin.A_GenCtlCodeforTab(myEncoding, objViewInfoENEx));
                txtFileName4GenCode.Text = objViewInfoENEx.FileName;
                SimpleFName = clsString.GetSimpleFName_S(objViewInfoENEx.FileName);
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
                clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, clsPubVar.CurrSelPrjId);
                WinViewCode_QD4CSharp autoGC5Cs_VWin = new WinViewCode_QD4CSharp(strViewId);
                if (objViewInfoENEx.ViewFldNum == 0)
                {
                    ShowCode("�������ֶ���Ϊ0���������ɽ������");
                    return;

                }
                objViewInfoENEx.FolderName = "D:\\FTP\\ClsFile\\" + clsCommonSession.UserId + "\\";
                objViewInfoENEx.CurrUserName = clsCommonSession.UserName;
                ShowCode(autoGC5Cs_VWin.A_GenCtlCodeforTab4Query(myEncoding, objViewInfoENEx));
                txtFileName4GenCode.Text = objViewInfoENEx.FileName;
                SimpleFName = clsString.GetSimpleFName_S(objViewInfoENEx.FileName);
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
                //            autoGC5Cs_M.objPrjTabENEx.FolderName = "D:\\FTP\\ClsFile\\" + clsCommonSession.UserId + "\\";
                //            autoGC5Cs_M.objPrjTabENEx.CurrUserName = clsCommonSession.UserName;
                //            ShowCode(autoGC5Cs_M.A_GenGeneralLogicCode(myEncoding);
                //            txtFileName4GenCode.Text = autoGC5Cs_M.objPrjTabENEx.FileName;
                //            SimpleFName = clsString.GetSimpleFName_S(autoGC5Cs_M.objPrjTabENEx.FileName);
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
            string strRe_ClsName = "";
            string strRe_FileNameWithModuleName = "";
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
                clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, clsPubVar.CurrSelPrjId);
                WebViewCode4Html autoGC5Cs_VWeb = new WebViewCode4Html(strViewId);
                if (objViewInfoENEx.ViewFldNum == 0)
                {
                    ShowCode("�������ֶ���Ϊ0���������ɽ������");
                    return;

                }
                objViewInfoENEx.FolderName = "D:\\FTP\\ClsFile\\" + clsCommonSession.UserId + "\\";
                objViewInfoENEx.CurrUserName = clsCommonSession.UserName;
                ShowCode(autoGC5Cs_VWeb.A_GenCtlViewCodeforTab_Disp(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName));
                txtFileName4GenCode.Text = objViewInfoENEx.FileName;
                SimpleFName = clsString.GetSimpleFName_S(objViewInfoENEx.FileName);
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

        protected void btnShowRelaFldList_Click(object sender, System.EventArgs e)
        {
            //���������ֶ��б�
            if (cbkShowMode.Items[0].Selected == true)
            {
                divViewFldList.Visible = true;
            }
            else
            {
                divViewFldList.Visible = false;
            }
            //��ѯ�ֶ��б�
            if (cbkShowMode.Items[1].Selected == true)
            {
                divQueryFldList.Visible = true;
            }
            else
            {
                divQueryFldList.Visible = false;
            }
            //��ʾ��Ϣ�ֶ��б�
            if (cbkShowMode.Items[2].Selected == true)
            {
                divDispDataFldList.Visible = true;
            }
            else
            {
                divDispDataFldList.Visible = false;
            }
            //��ʾ��Ϣ�ֶ��б�
            if (cbkShowMode.Items[3].Selected == true)
            {
                divEditCtrlFldList.Visible = true;
            }
            else
            {
                divEditCtrlFldList.Visible = false;
            }

        }

        protected void btnGenFunc_Click(object sender, System.EventArgs e)
        {
            //���������ֶ��б�
            divViewFldList.Visible = false;
            divDispDataFldList.Visible = false;
            divEditCtrlFldList.Visible = false;
            divQueryFldList.Visible = false;

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
                clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, clsPubVar.CurrSelPrjId);
                WinViewCode_QD4CSharp autoGC5Cs_VWin = new WinViewCode_QD4CSharp(strViewId);
                if (objViewInfoENEx.ViewFldNum == 0)
                {
                    ShowCode("�������ֶ���Ϊ0���������ɽ������");
                    return;
                }
                objViewInfoENEx.FolderName = "D:\\FTP\\ClsFile\\" + clsCommonSession.UserId + "\\";
                objViewInfoENEx.CurrUserName = clsCommonSession.UserName;
                if (ddlFuncList.SelectedValue == "������EXCEL")
                {
                    ShowCode(autoGC5Cs_VWin.gfunGenbtnExportExcel4Dg_Click());
                }
                else if (ddlFuncList.SelectedValue == "��ListView")
                {
                    ShowCode(autoGC5Cs_VWin.gfunGenBindListView());
                }
                txtFileName4GenCode.Text = objViewInfoENEx.FileName;
                //			SimpleFName = clsString.GetSimpleFName_S(objViewInfoENEx.FileName);
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
            //���������ֶ��б�
            divViewFldList.Visible = false;
            divDispDataFldList.Visible = false;
            divEditCtrlFldList.Visible = false;
            divQueryFldList.Visible = false;

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