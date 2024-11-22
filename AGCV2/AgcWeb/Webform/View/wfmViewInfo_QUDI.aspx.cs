///���ɲ�ѯ���޸ģ�ɾ������Ӽ�¼�Ŀ��Ʋ����
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AGC.BusinessLogic;
using AGC.BusinessLogicEx;

using AGC.Entity;
using AGC.FunClass;
//using SqlSv; 
using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.datetime;
using CommFunc4WebForm;


using GeneralPlatform.Entity;

namespace AGC.Webform
{
    /// <summary>
    /// wfmViewInfo_QUDI ��ժҪ˵��������Q�����ѯ��U�����޸�
    /// </summary>
    public partial class wfmViewInfo_QUDI : CommWebPageBase
    {
        /// <summary>
        /// ������ʽ������ӣ�AddRec, �޸ģ�UpdRec��
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

            //            this.RegisterStartupScript("js", js); 
            // �ڴ˴������û������Գ�ʼ��ҳ��
            if (!IsPostBack)	///����������ǳ��α����ã������ǵ�����ť�¼�������
            {
                string strCmPrjId = clsUserDefaValue_LocalBLEx.getUserDefaValue(clsPubVar.CurrPrjId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId, "Ĭ��CM����");
                vsCmPrjId = strCmPrjId;

                btnDelete.Attributes.Add("onclick", "return confirm('�����Ҫɾ����ѡ������');");
                ///����Ӧ�����صĿؼ�����
                ///
                tabHidden.Visible = false;
                //if (clsCommForWebForm.SystemStatus == "DEBUG")
                //{
                //    PrjId = "0005";
                //    txtUserIdq.Text = "pyf";
                //    clsUsersEN objUsers = new clsUsersEN("pyf", true);
                //    objUser = objUsers;
                //}
                //1��Ϊ��������������Դ�����б�����
                wucViewInfo1.SetDdl_FuncModuleId(clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId);
                wucViewInfo1.SetDdl_MainTabId(clsPubVar.CurrSelPrjId);
                wucViewInfo1.SetDdl_DetailTabId(clsPubVar.CurrSelPrjId);
                wucViewInfo1.SetDdl_PrjId();
                wucViewInfo1.SetDdl_CmPrjId(clsPubVar.CurrSelPrjId);

                wucViewInfo1.SetDdl_ApplicationTypeId();
                //				wucViewInfo1.SetDdl_ViewTypeCode();
                wucViewInfo1.SetDdl_ViewGroupId(clsPubVar.CurrSelPrjId);
                wucViewInfo1.SetDdl_InSqlDsTypeId();
                wucViewInfo1.SetDdl_OutSqlDsTypeId();
                clsCMProjectBLEx.BindDdl_CmPrjIdEx(ddlCmPrjIdq, clsPubVar.CurrSelPrjId);
                if (string.IsNullOrEmpty(vsCmPrjId) == false) ddlCmPrjIdq.SelectedValue = vsCmPrjId;
                clsCMProjectBLEx.BindDdl_CmPrjIdEx(ddlCmPrjId_Set, clsPubVar.CurrSelPrjId);

                //if (clsPubVar.objCurrSelProject.ApplicationTypeId != 3)
                //{
                //    wucViewInfo1.HideViewGroup();
                //}
                clsFuncModule_AgcBLEx.BindDdl_FuncModuleId(ddlFuncModuleIdq, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId);

                clsDropDownList.BindDdl_ApplicationTypeId(ddlApplicationTypeIdq);
                clsViewInfoBLEx.BindDdl_ApplicationTypeIdExCache(ddlApplicationTypeIdq, clsPubVar.CurrSelPrjId);
                if (seApplicationTypeId>0)
                {
                    ddlApplicationTypeIdq.SelectedValue = seApplicationTypeId.ToString();
                }
                //                clsDropDownList.BindDdl_ViewTypeCode(ddlViewTypeCodeq);
                clsProjectsBLEx.BindDdl_PrjIdCacheEx(ddlPrjIdq);
                clsViewGroupBLEx.BindDdl_ViewGroupId(ddlViewGroupIdq, clsPubVar.CurrSelPrjId);
                SetDdl_MainTabId(clsPubVar.CurrSelPrjId);
                //�ָ���һ���ڴ˽����״̬
                if (seFuncModuleAgcId != "")
                {
                    clsDropDownList.SetDdlValue(ddlFuncModuleIdq, seFuncModuleAgcId);
                }
                if (seViewTypeCode != 0)
                {
                    clsDropDownList.SetDdlValue(ddlViewTypeCodeq, seViewTypeCode.ToString());
                }
                txtViewNameq.Text = ViewName;
                //===============================
                strSortViewInfoBy = "UpdDate Desc";
                wucvViewInfo4Gv1.SetSortBy("UpdDate Desc");
                ///���õ�ǰ��¼�û���Ĭ�Ϲ���
                ddlPrjIdq.SelectedValue = clsPubVar.CurrSelPrjId;
                //2����ʾ�������ı�������DATAGRID��
                if (qsOperator == "AddRec")
                {
                    wucViewInfo1.SetKeyReadOnly(false);
                    btnOKUpd.Text = "ȷ�����";
                    wucViewInfo1.ViewId = clsViewInfoBL.GetMaxStrIdByPrefix_S(clsPubVar.CurrSelPrjId);
                    wucViewInfo1.UserId = objUser.UserId;
                    wucViewInfo1.PrjId = clsPubVar.CurrSelPrjId;
                    wucViewInfo1.FilePath = "webform/";
                    wucViewInfo1.MainTabId = clsCommonSession.qsTabId;
                    if (string.IsNullOrEmpty(strCmPrjId) == false)
                    {
                        wucViewInfo1.CmPrjId = strCmPrjId;
                        var objCMProject = clsCMProjectBL.GetObjByCmPrjIdCache(vsCmPrjId);
                        wucViewInfo1.ApplicationTypeId = objCMProject.ApplicationTypeId;

                    }
                    wucViewInfo1.DataBaseName = new clsCommonSession().PrjDataBaseName;
                    
                    tabQueryRegion.Visible = false;
                    tabEditRegion.Visible = true;
             
                    //wucViewInfo1.SetDefaValueByMainTabId4WebApp(clsCommonSession.qsTabId);
                }
                else
                {
                    BindGv_vViewInfo();
                    tabQueryRegion.Visible = true;
                    tabEditRegion.Visible = false;
                }
                //3�����ñ�ؼ����ֿؼ���ReadOnly���ԣ�
                //   ʹֻ֮������Ϊ���޸Ĺ����йؼ����ǲ��ܱ��޸ĵġ�
                wucViewInfo1.SetKeyReadOnly(true);
                if (clsCommonSession.RoleId == "00050001" || clsCommonSession.RoleId == "00050006")
                {
                    btnDelViewEx.Visible = true;
                }

             
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


        private string seFuncModuleAgcId
        {
            get
            {
                string strFuncModuleId;
                strFuncModuleId = (string)Session["FuncModuleAgcId4Qry"];
                if (strFuncModuleId == null)
                {
                    strFuncModuleId = "";
                }
                return strFuncModuleId;
            }
            set
            {
                string strFuncModuleId = value;
                Session.Add("FuncModuleAgcId4Qry", strFuncModuleId);
            }
        }

        private int seApplicationTypeId
        {
            get
            {
                if (Session["ApplicationTypeId4Qry"] == null) return 0;
                int strFuncModuleId;
                strFuncModuleId = (int)Session["ApplicationTypeId4Qry"];
                return strFuncModuleId;
            }
            set
            {
                int strFuncModuleId = value;
                Session.Add("ApplicationTypeId4Qry", strFuncModuleId);
            }
        }
        private int seViewTypeCode
        {
            get
            {
                int intViewTypeCode;
                if (Session["ViewTypeCode"] == null)
                {
                    return 0;
                }
                if (string.IsNullOrEmpty(Session["ViewTypeCode"].ToString()) == true)
                {
                    return 0;
                }
                intViewTypeCode = int.Parse(Session["ViewTypeCode"].ToString());

                return intViewTypeCode;
            }
            set
            {
                int intViewTypeCode = value;
                Session.Add("ViewTypeCode", intViewTypeCode);
            }
        }

        private string ViewName
        {
            get
            {
                string strViewName;
                strViewName = (string)Session["ViewName"];
                if (strViewName == null)
                {
                    strViewName = "";
                }
                return strViewName;
            }
            set
            {
                string strViewName = value;
                Session.Add("ViewName", strViewName);
            }
        }

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
        private clsQxUsersEN objUser
        {
            get
            {
                clsQxUsersEN pobjUser;
                pobjUser = (clsQxUsersEN)Session["objUser"];
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
                clsQxUsersEN pobjUser = value;
                Session.Add("objUser", pobjUser);
            }
        }
       
     

        private string BackViewInfoLinkStr
        {
            get
            {
                string strBackViewInfoLinkStr;
                strBackViewInfoLinkStr = (string)Session["BackViewInfoLinkStr"];
                if (strBackViewInfoLinkStr == null)
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


        
        /// <summary>
        /// �����еĲ�ѯ�ؼ�������ϳ�һ��������
        /// </summary>
        /// <returns>������(strWhereCond)</returns>
        private string CombinevViewInfoCondition()
        {
            //ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
            //���� 1=1 and UserName = '����'
            string strWhereCond =  " 1=1 ";
            //����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
            if (ddlCmPrjIdq.SelectedIndex>0)

            {
                strWhereCond += string.Format(" and ViewId in (Select ViewId from ViewInfoCmPrjIdRela where CmPrjId='{0}')", ddlCmPrjIdq.SelectedValue);
            }
            if (vsCmPrjId != ddlCmPrjIdq.SelectedValue)
            {
                var strCmPrjId = ddlCmPrjIdq.SelectedValue;
                vsCmPrjId = strCmPrjId;
                clsUserDefaValue_LocalBLEx.setUserDefaValue(clsPubVar.CurrPrjId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId, "Ĭ��CM����", strCmPrjId);
            }
            if (this.txtViewNameq.Text.Trim() != "")
            {
                strWhereCond += " and ViewName like '" + this.txtViewNameq.Text.Trim() + "%'";
            }
            if (this.ddlViewTypeCodeq.SelectedValue != "" && this.ddlViewTypeCodeq.SelectedValue != "0")
            {
                strWhereCond += " and ViewTypeCode like '" + this.ddlViewTypeCodeq.SelectedValue + "%'";
            }
            if (this.ddlFuncModuleIdq.SelectedValue != "" && this.ddlFuncModuleIdq.SelectedValue != "0")
            {
                strWhereCond += " And FuncModuleAgcId='" + this.ddlFuncModuleIdq.SelectedValue + "'";
            }

            if (this.txtUserIdq.Text.Trim() != "")
            {
                strWhereCond += " and UserId='" + this.txtUserIdq.Text.Trim() + "'";
            }
            if (this.ddlPrjIdq.SelectedValue != "" && this.ddlPrjIdq.SelectedValue != "0")
            {
                strWhereCond += " and PrjId='" + this.ddlPrjIdq.SelectedValue + "'";
            }
            if (this.ddlApplicationTypeIdq.SelectedValue != "" && this.ddlApplicationTypeIdq.SelectedValue != "0")
            {
                strWhereCond += " And ApplicationTypeId='" + this.ddlApplicationTypeIdq.SelectedValue + "'";
            }
            if (this.ddlViewGroupIdq.SelectedValue != "" && this.ddlViewGroupIdq.SelectedValue != "0")
            {
                strWhereCond += " And ViewGroupId='" + this.ddlViewGroupIdq.SelectedValue + "'";
            }
            if (this.ddlMainTabIdq.SelectedValue != "" && this.ddlMainTabIdq.SelectedValue != "0")
            {
                strWhereCond += string.Format(" And {0}='{1}'", convViewInfo.MainTabId, ddlMainTabIdq.SelectedValue);
            }

            return strWhereCond;
        }
        /// <summary>
        /// ��������:�Ѳ�ѯ���ݰ���GridView�ϡ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼,
        ///			 ����ʾ��GridView�С�
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenBindGridView4WucInPage)
        /// </summary>
        protected void BindGv_vViewInfo()
        {
            //��������:(��5��)
            //	1����Ͻ�����������
            //	2�����ÿؼ��еİ�GridView����;
            //	3������Gv�ؼ���ĳЩ�в��ɼ�;

            try
            {
                wucvViewInfo4Gv1.SetGvVisibility(convViewInfo.DgStyleName, false);
                wucvViewInfo4Gv1.SetGvVisibility(convViewInfo.TitleStyleName, false);
                //wucvViewInfo4Gv1.SetGvVisibility(convViewInfo.ViewTypeName, false);

                //wucvViewInfo4Gv1.SetGvVisibility(convViewInfo.ViewCnName, false);

                //	1����Ͻ�����������
                string strWhereCond = CombinevViewInfoCondition();
                //	2�����ÿؼ��еİ�GridView������
                wucvViewInfo4Gv1.BindGv_vViewInfo(strWhereCond);
                //	3������Gv�ؼ���ĳЩ�в��ɼ���

                //wucvViewInfo4Gv1.SetGvVisibility(convViewInfo.UpdUser, false);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000019)��GridView����!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }

        }


        /// <summary>
        /// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
        ///			 ����ʾ��GridView�С�
        /// </summary>
        protected void BindGv_ViewInfoBak()
        {
            //�������裺(��5��)
            //	1����Ͻ�����������
            //	2��������������ȡ�ñ�����������DataTable��
            //	4������GridView������Դ(DataSource)��
            //	5����GridView������DataTable��������ʾ��DATAGRID��
            //	6�����ü�¼����״̬��
            //		�ڱ��������ǰ�״̬��ʾ�ڿؼ�txtRecCount�С�

            //	1����Ͻ�����������
            string strWhereCond = CombinevViewInfoCondition();
            //	2��������������ȡ�ñ�����������DataTable��
            System.Data.DataTable objDT = null;
            try
            {
                objDT = clsvViewInfoBL.GetDataTable(strWhereCond);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "��ȡ���ݱ�(DataTable)���ɹ�!" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            //	4������GRIDView������Դ(DataSource)��
            //DataView objDV = objDT.DefaultView;
            //objDV.Sort = strSortViewInfoBy;     ///ע����һ�д����п�����Ҫע�͵���Ŀǰ���н����ڵ����Ĳ�ѯ������������
            /////����GridView��ÿҳ�ļ�¼��
            //if (string.IsNullOrEmpty(PageSize) == false)
            //{
            //    int intPageSize = int.Parse(PageSize);
            //    gvViewInfo.PageSize = intPageSize;
            //}
            //else
            //{
            //    PageSize = "10";
            //    gvViewInfo.PageSize = 10;
            //}
            //this.gvViewInfo.DataSource = objDV;
            ////	5����DATAGRID������DataTable��������ʾ��DATAGRID��
            //this.gvViewInfo.DataBind();

            /////����ר������BindGv�е���ҳ��ش���
            //GridViewRow pagerRow = gvViewInfo.BottomPagerRow;
            //if (pagerRow == null)
            //{
            //    return;
            //}
            //Label lblRecCount = (Label)pagerRow.FindControl("lblRecCount");
            //Label lblAllPages = (Label)pagerRow.FindControl("lblAllPages");
            //Label lblCurrentPage = (Label)pagerRow.FindControl("lblCurrentPage");
            //TextBox txtJump2Page = (TextBox)pagerRow.FindControl("txtJump2Page");
            //Button btnNextPage = (Button)pagerRow.FindControl("btnNextPage");
            //Button btnPrevPage = (Button)pagerRow.FindControl("btnPrevPage");
            //Button tabJumpPage = (Button)pagerRow.FindControl("tabJumpPage");
            //DropDownList ddlPagerRecCount = (DropDownList)pagerRow.FindControl("ddlPagerRecCount");
            //if (lblRecCount != null)
            //{
            //    //��ǰ��¼��
            //    lblRecCount.Text = objDT.Rows.Count.ToString();
            //    //��ǰҳ��
            //    lblAllPages.Text = this.gvViewInfo.PageCount.ToString();
            //    //��ǰҳ����
            //    lblCurrentPage.Text = (this.gvViewInfo.PageIndex + 1).ToString();
            //    //��ǰ����������ҳ����
            //    txtJump2Page.Text = (this.gvViewInfo.PageIndex + 1).ToString();
            //    //�����ǰҳ����Ϊ0����<ǰһҳ>��ť��Ч
            //    if (this.gvViewInfo.PageIndex == 0)
            //    {
            //        clsPubFun.SetButtonEnabled(btnPrevPage,  false);
            //    }
            //    else
            //    {
            //        clsPubFun.SetButtonEnabled(btnPrevPage, true);
            //    }
            //    //�����ǰҳ������Ϊ���һҳ����<ǰһҳ>��ť��Ч
            //    if (this.gvViewInfo.PageIndex == this.gvViewInfo.PageCount - 1)
            //    {
            //         clsPubFun.SetButtonEnabled(btnNextPage, false);
            //    }
            //    else
            //    {
            //        clsPubFun.SetButtonEnabled(btnNextPage, true);
            //    }
            //    //���÷�ҳ����ÿҳ��¼�����������ֵ
            //    if (string.IsNullOrEmpty(PageSize) == false)
            //    {
            //        ddlPagerRecCount.Text = PageSize;
            //    }
            //    else
            //    {
            //        PageSize = "10";
            //        ddlPagerRecCount.Text = PageSize;
            //    }
            //}
            //gvViewInfo.BottomPagerRow.Visible = true;
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
            if (intRecCount % intPageSize != 0) intPages++;
            return intPages;
        }
        public string Substring(string strSource, int intStart, int intLen)
        {
            if (strSource.Length > intStart + intLen)
            {
                return strSource.Substring(intStart, intLen);
            }
            else if (strSource.Length > intStart)
            {
                return strSource.Substring(intStart);
            }
            else
            {
                return strSource;
            }
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
            wucvViewInfo4Gv1.vsPageIndex = 1;
            //�ѱ��¼��������ʾ��DATAGRID��
            BindGv_vViewInfo();
            //������β�ѯ������Ϊ��һ�������ý������================
            seFuncModuleAgcId = ddlFuncModuleIdq.SelectedValue;
            seApplicationTypeId = int.Parse(ddlApplicationTypeIdq.SelectedValue);
            if (string.IsNullOrEmpty(ddlViewTypeCodeq.SelectedValue) == true)
            {

            }
            else
            {
                seViewTypeCode = int.Parse(ddlViewTypeCodeq.SelectedValue);
            }
            ViewName = txtViewNameq.Text;
            //=====================================================
        }
       
        /// <summary>
        /// �������ܣ����Ըùؼ��ֵļ�¼������ʾ�ڽ����ϣ�
        ///������     �������ǰ�ֵ������ؼ���
        /// </summary>
        /// <param name="strViewId">���¼�Ĺؼ��֣���ʾ�ñ�ؼ��ֵ�����</param>
        private void ShowData(string strViewId)
        {
            //�������裺
            //1�����ؼ����Ƿ�Ϊ�գ�
            //2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
            //3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
            //4����ȡ�������������ԣ�
            //5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���

            //1�����ؼ����Ƿ�Ϊ�գ�
            if (strViewId == "") return;		//����ؼ���Ϊ�վͷ����˳�
            //2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
            if (clsViewInfoBL.IsExist(strViewId) == false)		//���ùؼ��ֵļ�¼�Ƿ����
            {
                string ss = "�ؼ���Ϊ��" + strViewId + "�Ĳ�����!";
                clsCommonJsFunc.Alert(this, ss);
                return;
            }
            //3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
            clsViewInfoEN objViewInfo = new clsViewInfoEN(strViewId);
            //4����ȡ�������������ԣ�
            clsViewInfoBL .GetViewInfo(ref  objViewInfo);
            Session.Add("objViewInfo", objViewInfo);
            //5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���
            GetDataFromViewInfoClass(objViewInfo);
        }
        ///���ɴ��߼�������ݴ��䵽�����ĺ�������
        /// <summary>
        /// �������ܣ�������������������ʾ��������
        ///ע�⣺��������������򣬲�����һ��������������ϵ�ģ�����Ϊһ��������ֵ��Ȼ����Ϊ����������ֵ
        ///      ������������ݿ�ʱ����Ӧ��һ���ֶ���ǰ�������ֶ��ں�
        /// </summary>
        /// <param name="pobjViewInfo">��ʵ�������</param>
        private void GetDataFromViewInfoClass(clsViewInfoEN pobjViewInfo)
        {
            wucViewInfo1.ViewId = pobjViewInfo.ViewId;
            wucViewInfo1.ViewName = pobjViewInfo.ViewName;
            wucViewInfo1.ViewCnName = pobjViewInfo.ViewCnName;
            wucViewInfo1.FileName = pobjViewInfo.FileName;
            wucViewInfo1.FilePath = pobjViewInfo.FilePath;
            wucViewInfo1.DefaMenuName = pobjViewInfo.DefaMenuName;
            wucViewInfo1.ApplicationTypeId = pobjViewInfo.ApplicationTypeId;
            wucViewInfo1.ViewGroupId = pobjViewInfo.ViewGroupId;
            
            wucViewInfo1.FuncModuleAgcId = pobjViewInfo.FuncModuleAgcId;

            wucViewInfo1.DataBaseName = pobjViewInfo.DataBaseName;
            wucViewInfo1.MainTabId = pobjViewInfo.MainTabId;
            wucViewInfo1.DetailTabId = pobjViewInfo.DetailTabId;
            wucViewInfo1.KeyForMainTab = pobjViewInfo.KeyForMainTab;
            wucViewInfo1.KeyForDetailTab = pobjViewInfo.KeyForDetailTab;
            wucViewInfo1.IsNeedSort = pobjViewInfo.IsNeedSort;
            wucViewInfo1.IsNeedTransCode = pobjViewInfo.IsNeedTransCode;
            wucViewInfo1.UserId = pobjViewInfo.UserId;
            wucViewInfo1.PrjId = pobjViewInfo.PrjId;
            wucViewInfo1.CmPrjId = pobjViewInfo.PrjId;

            wucViewInfo1.ViewFunction = pobjViewInfo.ViewFunction;
            wucViewInfo1.ViewDetail = pobjViewInfo.ViewDetail;
            wucViewInfo1.InSqlDsTypeId = pobjViewInfo.InSqlDsTypeId;
            wucViewInfo1.InRelaTabId = pobjViewInfo.InRelaTabId;
            wucViewInfo1.OutSqlDsTypeId = pobjViewInfo.OutSqlDsTypeId;
            wucViewInfo1.OutRelaTabId = pobjViewInfo.OutRelaTabId;
            wucViewInfo1.IsNeedSetExportFld = pobjViewInfo.IsNeedSetExportFld;
            wucViewInfo1.KeyId4Test = pobjViewInfo.KeyId4Test;
            wucViewInfo1.ViewMasterId = pobjViewInfo.ViewMasterId;


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
            string strCommandText;
            clsViewInfoEN objViewInfo;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "���":
                    wucViewInfo1.SetKeyReadOnly(false);
                    btnOKUpd.Text = "ȷ�����";
                    wucViewInfo1.ViewId = clsViewInfoBL.GetMaxStrIdByPrefix_S(clsPubVar.CurrSelPrjId);
                    wucViewInfo1.UserId = objUser.UserId;
                    wucViewInfo1.PrjId = clsPubVar.CurrSelPrjId;
                    wucViewInfo1.FilePath = "webform/";
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
                    if (!wucViewInfo1.IsValid())
                    {
                        lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
                        return;
                    }
                    //2��������󲢳�ʼ������
                    //clsViewInfoEN objViewInfo;	//�������
                    wucViewInfo1.ViewId = clsViewInfoBL.GetMaxStrIdByPrefix_S(clsPubVar.CurrSelPrjId);

                    objViewInfo = new clsViewInfoEN(wucViewInfo1.ViewId);	//��ʼ���¶���
                    //3���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
                    if (clsViewInfoBL.IsExist(objViewInfo.ViewId))	//�ж��Ƿ�����ͬ�Ĺؼ���
                    {
                        strMsg = "�ؼ����ֶ�������ͬ��ֵ";
                        clsCommonJsFunc.Alert(this, strMsg);
                        return;
                    }
                    //����ڵ�ǰ�������Ƿ���ͬ����������
                    if (clsViewInfoBL.IsExistRecord("PrjId = '" + clsPubVar.CurrSelPrjId + "' and ViewName = '" + wucViewInfo1.ViewName + "'"))	//�ж��Ƿ�����ͬ�Ĺؼ���
                    {
                        strMsg = "����Ŀ���Ѵ���ͬ���Ľ�������!";
                        clsCommonJsFunc.Alert(this, strMsg);
                        return;
                    }
                    //4����ֵ�ӽ���㴫���߼��������ʵ���
                    PutDataToViewInfoClass(objViewInfo);		//�ѽ����ֵ����

                    //5����鴫��ȥ�Ķ��������Ƿ�Ϸ�

                    try
                    {
                        clsViewInfoBL .CheckPropertyNew(objViewInfo);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
                    //6��������ʵ�������ݴ��������ݿ���
                    try
                    {
                        if (clsViewInfoBL.AddNewRecordBySql2(objViewInfo) == false)
                        {
                            strMsg = "��Ӳ��ɹ�!";
                            clsCommonJsFunc.Alert(this, strMsg);
                            lblMsg.Text = "��Ӽ�¼���ɹ�!";
                        }
                        else
                        {
                            //���Ĭ�ϵĽ���ģʽ
                            clsViewInfoBLEx.AddDefaultViewStyle(clsPubVar.CurrSelPrjId, objViewInfo.ViewId);
                            strMsg = "��Ӽ�¼�ɹ�!";
                            clsCommonJsFunc.Alert(this, strMsg);
                            lblMsg.Text = "��Ӽ�¼�ɹ�!";
                            tabQueryRegion.Visible = true;
                            tabEditRegion.Visible = false;
                        }
                    }
                    catch (Exception objException)
                    {
                        clsCommonSession.seErrMessage = objException.Message;
                        clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                        clsPubFun4Web.AccessError(this, conCurrPageName);
                    }

                    //7��������ļ�¼������ʾ��DATAGRID��
                    BindGv_vViewInfo();
                    wucViewInfo1.Clear();		//��տؼ�������
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
                    if (!wucViewInfo1.IsValid())
                    {
                        lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
                        return;
                    }
                    //2����ֵ�ӽ���㴫���߼��������ʵ���
                    objViewInfo = (clsViewInfoEN)Session["objViewInfo"];
                    //����ڵ�ǰ�������Ƿ���ͬ����������
                    StringBuilder sbCondition = new StringBuilder();
                    sbCondition.AppendFormat("PrjId = '{0}'", clsPubVar.CurrSelPrjId);
                    sbCondition.AppendFormat(" and ViewName = '{0}'", wucViewInfo1.ViewName);
                    sbCondition.AppendFormat(" and ViewId <> '{0}'", wucViewInfo1.ViewId);

                    if (clsViewInfoBL.IsExistRecord(sbCondition.ToString()))	//�ж��Ƿ�����ͬ�Ĺؼ���
                    {
                        strMsg = "����Ŀ���Ѵ���ͬ���Ľ�������!";
                        clsCommonJsFunc.Alert(this, strMsg);
                        return;
                    }

                    PutDataToViewInfoClass(objViewInfo);		//�ѽ����ֵ����
                    //3����鴫��ȥ�Ķ��������Ƿ�Ϸ�
                    try
                    {
                        clsViewInfoBL .CheckPropertyNew(objViewInfo);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
                    //4��������ʵ���������޸�ͬ�������ݿ���
                    if (clsViewInfoBL .UpdateBySql2(objViewInfo) == false)
                    {
                        strMsg = "�޸ļ�¼���ɹ�!";
                        clsCommonJsFunc.Alert(this, strMsg);
                        lblMsg.Text = "�޸ļ�¼���ɹ�!";
                    }
                    else
                    {
                        //���Ĭ�ϵĽ���ģʽ
                        clsViewInfoBLEx.AddDefaultViewStyle(clsPubVar.CurrSelPrjId, objViewInfo.ViewId);
                        strMsg = "�޸ļ�¼�ɹ�!";
                        clsCommonJsFunc.Alert(this, strMsg);
                        lblMsg.Text = "�޸ļ�¼�ɹ�!";
                        tabQueryRegion.Visible = true;
                        tabEditRegion.Visible = false;
                    }
                    //5�����޸ĺ��������ʾ��DATAGRID��
                    BindGv_vViewInfo();
                    wucViewInfo1.Clear();//��տؼ��е�����
                    //�ָ�<ȷ���޸�>���<���>
                    btnOKUpd.Text = "���";
                    break;

            }
        }
        
        /// <summary>
        /// �������ܣ��ѽ����ϵ��������ݴ����������
        /// </summary>
        /// <param name="pobjViewInfo">���ݴ����Ŀ�������</param>
        private void PutDataToViewInfoClass(clsViewInfoEN pobjViewInfo)
        {
            pobjViewInfo.ViewId = wucViewInfo1.ViewId;
            pobjViewInfo.ViewName = wucViewInfo1.ViewName;
            pobjViewInfo.ViewCnName = wucViewInfo1.ViewCnName;
            pobjViewInfo.FileName = wucViewInfo1.FileName;
            pobjViewInfo.FilePath = wucViewInfo1.FilePath;
            pobjViewInfo.DefaMenuName = wucViewInfo1.DefaMenuName;
            pobjViewInfo.ApplicationTypeId = wucViewInfo1.ApplicationTypeId;
            pobjViewInfo.ViewGroupId = wucViewInfo1.ViewGroupId;

            pobjViewInfo.FuncModuleAgcId = wucViewInfo1.FuncModuleAgcId;
            pobjViewInfo.DataBaseName = wucViewInfo1.DataBaseName;
            pobjViewInfo.MainTabId = wucViewInfo1.MainTabId;
            pobjViewInfo.DetailTabId = wucViewInfo1.DetailTabId;
            pobjViewInfo.KeyForMainTab = wucViewInfo1.KeyForMainTab;
            pobjViewInfo.KeyForDetailTab = wucViewInfo1.KeyForDetailTab;
            pobjViewInfo.IsNeedSort = wucViewInfo1.IsNeedSort;
            pobjViewInfo.IsNeedTransCode = wucViewInfo1.IsNeedTransCode;
            pobjViewInfo.UserId = wucViewInfo1.UserId;
            pobjViewInfo.PrjId = wucViewInfo1.PrjId;
            pobjViewInfo.PrjId = wucViewInfo1.CmPrjId;

            pobjViewInfo.ViewFunction = wucViewInfo1.ViewFunction;
            pobjViewInfo.ViewDetail = wucViewInfo1.ViewDetail;
            pobjViewInfo.InRelaTabId = wucViewInfo1.InRelaTabId;
            pobjViewInfo.InSqlDsTypeId = wucViewInfo1.InSqlDsTypeId;
            pobjViewInfo.OutSqlDsTypeId = wucViewInfo1.OutSqlDsTypeId;
            pobjViewInfo.OutRelaTabId = wucViewInfo1.OutRelaTabId;
            pobjViewInfo.UpdDate = clsDateTime.getTodayDateTimeStr(1);
            pobjViewInfo.IsNeedSetExportFld = wucViewInfo1.IsNeedSetExportFld;
            pobjViewInfo.KeyId4Test = wucViewInfo1.KeyId4Test;

            pobjViewInfo.UpdUserId = clsCommonSession.UserId;
            pobjViewInfo.ViewMasterId = wucViewInfo1.ViewMasterId;


        }



        public System.Data.DataTable GetViewTypeCode()
        {
            //��ȡĳѧԺ����רҵ��Ϣ
            string strSQL = "select ViewTypeCode, ViewTypeName from ViewTypeCodeTab ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindDdl_ViewTypeCode(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //Ϊ����Դ�ڱ����������������
            ListItem li = new ListItem("��ѡ��...", "0");
            System.Data.DataTable objDT = GetViewTypeCode();
            objDDL.DataValueField = "ViewTypeCode";
            objDDL.DataTextField = "ViewTypeName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

      
        /// <summary>
        /// ���ܣ��޸Ľ����¼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnUpdate_Click(object sender, System.EventArgs e)
        {
            //�������裺���ܹ�2����
            //1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
            //2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
            string strViewId = wucvViewInfo4Gv1.GetFirstCheckedKeyFromGv();
            if (string.IsNullOrEmpty(strViewId) == true) return;
            lblMsgList.Text = "";
            //1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
            ShowData(strViewId);
            //2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
            clsPubFun.SetButtonEnabled(btnOKUpd, true);
            wucViewInfo1.SetKeyReadOnly(true);
            btnOKUpd.Text = "ȷ���޸�";
            lblMsg.Text = "";
            tabQueryRegion.Visible = false;
            tabEditRegion.Visible = true;
        }

        /// <summary>
        /// ���ܣ�ɾ�������¼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnDelete_Click(object sender, System.EventArgs e)
        {
            List<string> lstViewId = wucvViewInfo4Gv1.GetAllCheckedKeysFromGv();
            if (lstViewId == null) return;
            lblMsgList.Text = "";

            try
            {
                foreach (string strViewId in lstViewId)
                {
                    clsViewInfoBL.DelRecord(strViewId);
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_vViewInfo();

        }

        /// <summary>
        /// ���ܣ�Ϊ������Ӳ�������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnViewOptStep_Click(object sender, System.EventArgs e)
        {
            JumpOtherPages("wfmViewOptSteps_QUDI.aspx");
        }

        /// <summary>
        /// ���ܣ��༭�������ر�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnEditRelaTab_Click(object sender, System.EventArgs e)
        {
            JumpOtherPages("wfmViewRelaTab_QUDI.aspx");
        }

        /// <summary>
        /// ���ܣ��༭����İ�ť�������裻
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnBtnOptStep_Click(object sender, System.EventArgs e)
        {
            JumpOtherPages("wfmViewBtnOptSteps_QUDI.aspx");
        }
        /// <summary>
        /// ���ܣ��༭������ֶ���Ϣ��Ϊ������ӡ�ɾ����ά���ֶ���Ϣ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnEditViewField_Click(object sender, System.EventArgs e)
        {
            JumpOtherPages("wfmViewAddField.aspx");
           
        }
        /// <summary>
        /// ���ܣ��������������ý�����ֶ���Ϣ������ӡ�ɾ���ֶ���Ϣ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSetViewFld_Click(object sender, System.EventArgs e)
        {
            JumpOtherPages("wfmViewSetField.aspx");
          

        }

        protected void lbDispViewList_Click(object sender, System.EventArgs e)
        {
            tabQueryRegion.Visible = true;
            tabEditRegion.Visible = false;
        }

        protected void btnAddNewView_Click(object sender, System.EventArgs e)
        {
            wucViewInfo1.SetKeyReadOnly(false);
            btnOKUpd.Text = "ȷ�����";
            wucViewInfo1.ViewId = clsViewInfoBL.GetMaxStrIdByPrefix_S(clsPubVar.CurrSelPrjId);
            wucViewInfo1.UserId = objUser.UserId;
            wucViewInfo1.PrjId = clsPubVar.CurrSelPrjId;
            wucViewInfo1.CmPrjId = vsCmPrjId;
            wucViewInfo1.DataBaseName = new clsCommonSession().PrjDataBaseName;
            wucViewInfo1.FilePath = "webform/";
            tabQueryRegion.Visible = false;
            tabEditRegion.Visible = true;
        }

        /// <summary>
        /// �¼�����:�Ѳ�ѯ�����ı��¼��������Excel.
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_btnExportExcel_Click)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void btnExportExcel_Click(object sender, System.EventArgs e)
        {
            //����Excel����
            ExportExcel();
        }
        /// <summary>
        /// ����Excel�����ݲ�ѯ����ϵĲ�ѯ����,��[vViewInfo]���л�ȡ��¼��,���յ�����Excel
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_ExportExcel)
        /// </summary>
        private void ExportExcel()
        {
            //	1����Ͻ�����������
            string strWhereCond = CombinevViewInfoCondition();
            //	2��������������ȡ�ñ�����������DataTable��
            System.Data.DataTable objDT = null;
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "ViewInfo��Ϣ����.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add(convViewInfo.ViewId); arrCnName.Add("����ID");
            arrColName.Add(convViewInfo.ViewName); arrCnName.Add("��������");
            arrColName.Add(convViewInfo.ViewCnName); arrCnName.Add("��ͼ������");
            //arrColName.Add(convViewInfo.ViewTypeName); arrCnName.Add("��������");
            arrColName.Add(convViewInfo.FuncModuleName); arrCnName.Add("ģ��");
            arrColName.Add(convViewInfo.FuncModuleEnName); arrCnName.Add("ģ��Ӣ����");
            arrColName.Add(convViewInfo.PrjName); arrCnName.Add("��������");
            arrColName.Add(convViewInfo.DefaMenuName); arrCnName.Add("ȱʡ�˵���");
            arrColName.Add(convViewInfo.FileName); arrCnName.Add("�ļ���");
            arrColName.Add(convViewInfo.FilePath); arrCnName.Add("�ļ�·��");
            arrColName.Add(convViewInfo.MainTabName); arrCnName.Add("������");
            arrColName.Add(convViewInfo.DetailTabName); arrCnName.Add("��ϸ����");
            arrColName.Add(convViewInfo.UpdDate); arrCnName.Add("�޸�����");
            //arrColName.Add(convViewInfo.RegionNum); arrCnName.Add("������");
            arrColName.Add(convViewInfo.ViewFunction); arrCnName.Add("���湦��");
            strFolderName = Entity.clsSysParaEN.TempFileFolder;
            strDownLoadFileName = strFolderName + strFileName;
            //��ʼ����Ҫ������Excel�ļ�,�����Ʊ�׼Excel�ļ���Ϊĸ��,���Ʋ��ɹ������ܵ���
            if (clsPubVar.InitExcelFile(this, strFolderName, strDownLoadFileName) == false)
            {
                return;
            }
            try
            {
                //	2��������������ȡ�ñ�����������DataTable��
                objDT = clsvViewInfoBL.GetDataTable(strWhereCond);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("��ȡ���ݳ���,����ϵ����Ա������:{0}.({1})",
                objException.Message, clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            try
            {
                //�û�Odbc�ķ�ʽ������Excel,��Web����������Ҫ��װExcel,Ŀǰ��Excel2003,���ϣ��2007,���Ի�����һ����䡣
                GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4Odbc(objDT, arrColName, arrCnName, strDownLoadFileName);
            }
            catch (Exception objException)
            {
                try
                {
                    Entity.clsSysParaEN.objErrorLog.WriteDebugLog(objException.Message);
                    GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4OdbcExcel2007(objDT, arrColName, arrCnName, strDownLoadFileName);
                    //GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr(objDT, arrColName, arrCnName, strDownLoadFileName);
                }
                catch (Exception objException2)
                {
                    string strMsg = string.Format("����Excel����,����ϵ����Ա������:{0}.({1})",
                    objException2.Message, clsStackTrace.GetCurrClassFunction());
                    clsCommonJsFunc.Alert(this, strMsg);
                    return;
                }
            }
            clsCommForWebForm.DownLoadFile(strDownLoadFileName);
        }

        /// <summary>
        /// ���ܣ������ļ����ӷ����������ļ����ͻ��������
        /// </summary>
        /// <param name="strDownLoadFileName">��Ҫ���ص��ļ��������ļ���Ϊ��Ŀ¼���ļ�ȫ��</param>
        /// <returns></returns>
        private bool DownLoadFile(string strDownLoadFileName)
        {
            //			string path = "D:\\�Ŀ�����������Լ��.doc";		//WORD�ļ�����ֱ������
            ///			string path = "D:\\1000010811.JPG";	//JPG�ļ���������ʾ���һ�����
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

        protected void btnDesignView_Click(object sender, System.EventArgs e)
        {
            JumpOtherPages("wfmDesignView3.aspx");           
        }

        protected void btnSetViewStyle_Click(object sender, System.EventArgs e)
        {
            JumpOtherPages("wfmViewRegion_QUDI.aspx");
        }

        protected void btnDelViewEx_Click(object sender, System.EventArgs e)
        {
            List<string> lstViewId = wucvViewInfo4Gv1.GetAllCheckedKeysFromGv();
            if (lstViewId == null) return;
            lblMsgList.Text = "";
            try
            {
                foreach (string strViewId in lstViewId)
                {
                    clsViewInfoBLEx.DelRecordEx(strViewId);
                }
                clsViewInfoBL.ReFreshCache(clsPubVar.CurrSelPrjId);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }

            BindGv_vViewInfo();
        }

        //private string strSortBy
        //{
        //    get
        //    {
        //        string sSortBy;
        //        sSortBy = (string)ViewState["SortBy"];
        //        if (sSortBy == null)
        //        {
        //            sSortBy = "";
        //        }
        //        return sSortBy;
        //    }
        //    set
        //    {
        //        string sSortBy = value;
        //        ViewState.Add("SortBy", sSortBy);
        //    }
        //}

        //���ɴ�����Ϣ��Session����
        /// <summary>
        /// ר�����ڼ�¼GridView�е�ÿҳ��¼��
        /// </summary>
        protected string PageSize
        {
            get
            {
                string strPageSize;
                strPageSize = (string)ViewState["PageSize"];
                if (strPageSize == null)
                {
                    strPageSize = "";
                }
                return strPageSize;
            }
            set
            {
                string strPageSize = value;
                ViewState.Add("PageSize", strPageSize);
            }
        }
        /// <summary>
        /// ���ڼ�¼GridView�еĵ�ǰ������ʽ���Ա������һ�������򣬻��ǽ�������
        /// </summary>
        protected string strSortViewInfoBy
        {
            get
            {
                string sSortViewInfoBy;
                sSortViewInfoBy = (string)ViewState["SortViewInfoBy"];
                if (sSortViewInfoBy == null)
                {
                    sSortViewInfoBy = "";
                }
                return sSortViewInfoBy;
            }
            set
            {
                string sSortViewInfoBy = value;
                ViewState.Add("SortViewInfoBy", sSortViewInfoBy);
            }
        }
        protected void ddlApplicationTypeId_q_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strApplicationTypeId = ddlApplicationTypeIdq.SelectedValue;
            if (strApplicationTypeId != null && strApplicationTypeId != "")
            {
                clsViewTypeCodeTabBLEx.BindDdl_ViewTypeCodeByAppIdCache(ddlViewTypeCodeq, int.Parse( strApplicationTypeId));
            }
        }
        protected void btnGeneCode_Click(object sender, EventArgs e)
        {
            string strViewId = wucvViewInfo4Gv1.GetFirstCheckedKeyFromGv();
            if (string.IsNullOrEmpty(strViewId) == true) return;
            lblMsgList.Text = "";
            clsCommonSession.ViewId = strViewId;
            clsCommonSession.ParentPage = Page.Request.Url.AbsolutePath;
            string c1 = @"<script language='javascript'>window.open('../GenCode/wfmGenViewCodeV6.aspx','aa'); </script>";
            Response.Write(c1);
        }
        protected void btnEditViewAll_Click(object sender, EventArgs e)
        {
            JumpOtherPages("wfmViewInfo_U.aspx");
        }
        ///��������ҳ����غ���
      
    
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
            string strCurrPageName = string.Format("{0}|{1}", conCurrPageName, vsParentPage);
            string strViewId = "";
            switch (strPageName)
            {
                case "wfmViewOptSteps_QUDI.aspx":
                     strViewId = wucvViewInfo4Gv1.GetFirstCheckedKeyFromGv();
                    if (string.IsNullOrEmpty(strViewId) == true) return;
                    lblMsgList.Text = "";
                    clsCommonSession.ViewId = strViewId;
                    clsPubFun4Web.JumpToViewOptSteps_QUDI(this, strCurrPageName);
                    break;
                case "wfmViewRelaTab_QUDI.aspx":
                     strViewId = wucvViewInfo4Gv1.GetFirstCheckedKeyFromGv();
                    if (string.IsNullOrEmpty(strViewId) == true) return;
                    lblMsgList.Text = "";
                    clsCommonSession.ViewId = strViewId;
                    clsPubFun4Web.JumpToViewRelaTab_QUDI(this, strCurrPageName);
          
                    break;
                case "wfmViewBtnOptSteps_QUDI.aspx":
                     strViewId = wucvViewInfo4Gv1.GetFirstCheckedKeyFromGv();
                    if (string.IsNullOrEmpty(strViewId) == true) return;
                    lblMsgList.Text = "";
                    clsCommonSession.ViewId = strViewId;
                    clsPubFun4Web.JumpToViewBtnOptSteps_QUDI(this, strCurrPageName);
                    break;
                case "wfmViewAddField.aspx":
                     strViewId = wucvViewInfo4Gv1.GetFirstCheckedKeyFromGv();
                    if (string.IsNullOrEmpty(strViewId) == true) return;
                    lblMsgList.Text = "";
                    clsCommonSession.ViewId = strViewId;
                    clsPubFun4Web.JumpToViewAddField(this, strCurrPageName);
             
                    break;
                case "wfmViewSetField.aspx":
                     strViewId = wucvViewInfo4Gv1.GetFirstCheckedKeyFromGv();
                    if (string.IsNullOrEmpty(strViewId) == true) return;
                    lblMsgList.Text = "";
                    clsCommonSession.ViewId = strViewId;
                    clsPubFun4Web.JumpToViewSetField(this, strCurrPageName);
                    break;
                case "wfmDesignView3.aspx":
                     strViewId = wucvViewInfo4Gv1.GetFirstCheckedKeyFromGv();
                    if (string.IsNullOrEmpty(strViewId) == true) return;
                    lblMsgList.Text = "";
                    clsCommonSession.ViewId = strViewId;
                    clsPubFun4Web.JumpToDesignView3(this, strCurrPageName);
             
                    break;
                case "wfmViewRegion_QUDI.aspx":
                     strViewId = wucvViewInfo4Gv1.GetFirstCheckedKeyFromGv();
                    if (string.IsNullOrEmpty(strViewId) == true) return;
                    lblMsgList.Text = "";
                    clsCommonSession.ViewId = strViewId;
                    BackViewInfoLinkStr = "../View/wfmViewInfo_QUDI.aspx";
                    clsPubFun4Web.JumpToViewRegion_QUDI(this, strCurrPageName);
                    break;
                case "wfmViewInfo_U.aspx":
                     strViewId = wucvViewInfo4Gv1.GetFirstCheckedKeyFromGv();
                    if (string.IsNullOrEmpty(strViewId) == true) return;
                    lblMsgList.Text = "";
                    clsCommonSession.ViewId = strViewId;
                    clsCommonSession.ParentPage = Page.Request.Url.AbsolutePath;
                    clsPubFun4Web.JumpToViewInfo_U(this, strCurrPageName);

                    break;
                case "wfmViewInfo_U.aspx1":
                    //int deleteid = (int)GridView1.DataKeys[Convert.ToInt32(e.CommandArgument.ToString().Trim())].Value;  
                  //  strViewId = gvViewInfo.DataKeys[Convert.ToInt32(e.CommandArgument.ToString().Trim())].Value.ToString();
                  
                    if (string.IsNullOrEmpty( vsViewId_T) == true)
                    {
                        lblMsgList.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
                        return;
                    }
                    lblMsgList.Text = "";
                    clsCommonSession.ViewId = vsViewId_T;
                    clsCommonSession.ParentPage = Page.Request.Url.AbsolutePath;
                    clsPubFun4Web.JumpToViewInfo_U(this, strCurrPageName);

                    break;

                case "AddViewRegion":

                    if (string.IsNullOrEmpty(vsViewId_T) == true)
                    {
                        lblMsgList.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
                        return;
                    }
                    lblMsgList.Text = "";
                    clsCommonSession.ViewId = vsViewId_T;
                    clsCommonSession.ParentPage = Page.Request.Url.AbsolutePath;
                    clsPubFun4Web.JumpToAddViewRelaRegion(this, strCurrPageName);
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
                return "wfmViewInfo_QUDI.aspx";
            }
        }

        protected void btnClone_Click(object sender, EventArgs e)
        {
            string strViewId = wucvViewInfo4Gv1.GetFirstCheckedKeyFromGv();
            if (string.IsNullOrEmpty(strViewId) == true) return;
            try
            {
                clsViewInfoBLEx.Clone(strViewId, clsCommonSession.CurrSelPrjId, clsCommonSession.UserId);
                BindGv_vViewInfo();
            }
            catch(Exception objException)
            {
                string strMsg = string.Format("�ڿ�¡����ʱ��������{0}.(In {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
            }
        }

        protected void btnCheckRegion_Click(object sender, EventArgs e)
        {
            int intTotal = 0;
            //int intRegionNum = clsViewRegionRelaBLEx.GetRegionNumByViewId()
            string strCondition = string.Format("1=1");
            List<clsvViewInfoEN> arrObjLst = clsvViewInfoBL.GetObjLst(strCondition);
            foreach (clsvViewInfoEN objInFor in arrObjLst)
            {
             
                string strRegionName = "";
                List<clsViewRegionEN> arrViewRegionObjLst = clsViewRegionBLEx.GetObjLstByViewIdCache(objInFor.ViewId, clsPubVar.CurrSelPrjId);
                //var result = arrViewRegionObjLst.GroupBy(d => d.RegionName);
                //var ee = result.Where(d => d.Key == 1).FirstOrDefault() == null ? 0 : result.Where(d => d.Key == 1).FirstOrDefault().Count();
                //Console.WriteLine(ee);
                //Console.ReadLine();

                var groupList = arrViewRegionObjLst.GroupBy(m => new { m.RegionName }).
                       Select(a => new
                       {
                           RegionName = a.Key.RegionName,
                           RegionNum = a.Count()
                       }).ToList();
                foreach (var item in groupList)
                {
                    if (item.RegionNum == 1) continue;
                    strRegionName = item.RegionName;
                    break;
                    //Console.WriteLine("RegionName:{0}--RegionNum:{1}", item.RegionName, item.RegionNum);
                }
                if (string.IsNullOrEmpty(strRegionName) == true) continue;
                if (strRegionName != "�б�����") continue;
                IEnumerable<clsViewRegionEN> arrViewRegionObjLst_Sel1 =
from objViewRegionEN in arrViewRegionObjLst
where objViewRegionEN.RegionName == strRegionName
orderby objViewRegionEN.RegionId
select objViewRegionEN;
                List<clsViewRegionEN> arrViewRegionObjLst_Sel = new List<clsViewRegionEN>();
                string lngRegionId = "";
                foreach (clsViewRegionEN obj in arrViewRegionObjLst_Sel1)
                {
                    strCondition = string.Format("{0}={1}", conDGRegionFlds.RegionId , obj.RegionId);
                    int intRecNum = clsDGRegionFldsBL.GetRecCountByCond(strCondition);
                    if (intRecNum == 0)
                    {
                        lngRegionId =  obj.RegionId;
                        break;
                    }
                    arrViewRegionObjLst_Sel.Add(obj);
                }
                if (string.IsNullOrEmpty(lngRegionId ) == false)
                {
                    clsViewRegionBL.DelRecord(lngRegionId);
                    strCondition = string.Format("{0}={1}", conDGRegionFlds.RegionId, lngRegionId);
                    clsDGRegionFldsBL.DelDGRegionFldssByCond(strCondition);
                    intTotal++;
                    continue;
                }
                int intRecNum1 = 0;
                int intRecNum2 = 0;
                string lngRegionId0 = "";
                string lngRegionId1 = "";
                string lngRegionId2 = "";

                foreach (clsViewRegionEN obj in arrViewRegionObjLst_Sel1)
                {
                    if (string.IsNullOrEmpty( lngRegionId0 ) == true) lngRegionId0 = obj.RegionId;
                     strCondition = string.Format("{0}={1}", conDGRegionFlds.RegionId, obj.RegionId);
                    if (intRecNum1 == 0)
                    {
                        intRecNum1 = clsDGRegionFldsBL.GetRecCountByCond(strCondition);
                        lngRegionId1 = obj.RegionId;
                    }
                    else
                    {
                        intRecNum2 = clsDGRegionFldsBL.GetRecCountByCond(strCondition);
                        lngRegionId2 = obj.RegionId;
                    }
                    if (intRecNum1 < intRecNum2)
                    {
                        lngRegionId = lngRegionId2;
                    }
                    else if (intRecNum1 > intRecNum2)
                    {
                        lngRegionId = lngRegionId1;
                    }
                    else
                    {
                        lngRegionId = lngRegionId0;
                    }
                }
                if (string.IsNullOrEmpty(lngRegionId ) == false)
                {
                    clsViewRegionBL.DelRecord(lngRegionId);
                    strCondition = string.Format("{0}={1}", conDGRegionFlds.RegionId, lngRegionId);
                    clsDGRegionFldsBL.DelDGRegionFldssByCond(strCondition);
                    intTotal++;
                    continue;
                }
            }
            clsCommonJsFunc.Alert(this, "�����ɣ��ܹ�ɾ���ˣ�"+ intTotal.ToString());
        }

        /// <summary>
        /// �¼�����:��Gv�б�ؼ��У���GeidView�е���ɾ��ʱ�������¼���
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_Wuc4Gv_GvDeleteClick)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void wucvViewInfo4Gv1_GvAddViewRegionClick(object sender, clsEventArgs4AddViewRegion e)
        {
            string strViewId = e.KeyId;
            vsViewId_T = strViewId;
            JumpOtherPages("AddViewRegion");
            //DeleteViewInfoRecord(strViewId);
        }

        /// <summary>
        /// �¼�����:��Gv�б�ؼ��У���GeidView�е����޸�ʱ�������¼���
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_Wuc4Gv_GvUpdateClick)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void wucvViewInfo4Gv1_GvEditViewRegionClick(object sender, clsEventArgs4EditViewRegion e)
        {
            string strViewId = e.KeyId;
            vsViewId_T = strViewId;
            int intRegionNum = clsViewRegionRelaBLEx.GetRegionNumByViewId(strViewId);
            if (intRegionNum == 0)
            {
                JumpOtherPages("AddViewRegion");
            }
            else
            {
                JumpOtherPages("wfmViewInfo_U.aspx1");
            }
            //UpdateViewInfoRecord(strViewId);
        }

        public void SetDdl_MainTabId(string strPrjId)
        {
            clsPrjTabBLEx.BindDdl_TabIdEx4QueryCache(ddlMainTabIdq, strPrjId);
        }
        protected void ddlCmPrjId_q_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlCmPrjIdq.SelectedIndex <= 0) return;
            string strCmPrjId = ddlCmPrjIdq.SelectedValue;
            clsCMProjectFuncModuleBLEx.BindDdl_FuncModuleId(ddlFuncModuleIdq, strCmPrjId);
        }

        protected void btnSetCmPrjId_Click(object sender, EventArgs e)
        {
            if (ddlCmPrjId_Set.SelectedIndex <= 0)
            {
                clsCommonJsFunc.Alert(this, "��ѡ��һ��CM����");
                ddlCmPrjId_Set.Focus();
                return;
            }

            string strCmPrjId = ddlCmPrjId_Set.SelectedValue;

            List<string> lstViewId = wucvViewInfo4Gv1.GetAllCheckedKeysFromGv();
            if (lstViewId == null) return;
            try
            {
                foreach (string strViewId in lstViewId)
                {
                    clsViewInfoBLEx.SetCmPrjId(strViewId, strCmPrjId, clsCommonSession.UserId);
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_vViewInfo();
            //clsUserDefaValue_LocalBLEx.setUserDefaValue(vsPrjId_Cache, clsPubVar.CurrPrjId, clsCommonSession.UserId, "Ĭ��CM����", strCmPrjId);
            //vsCmPrjId = strCmPrjId;

        }
        protected string vsCmPrjId
        {
            get
            {
                string sCmPrjId;
                sCmPrjId = (string)ViewState["CmPrjId"];
                if (sCmPrjId == null)
                {
                    sCmPrjId = "";
                }
                return sCmPrjId;
            }
            set
            {
                string sCmPrjId = value;
                ViewState.Add("CmPrjId", sCmPrjId);
            }
        }

        protected void btnAutoGetPath4RegionFlds_Click(object sender, EventArgs e)
        {
            try
            {
                //int intCount = clsDnPathBLEx.AutoGetPath4RegionFlds(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                //string strMsg = string.Format("������:[{0}]��·����(In {1})",
                //        intCount, clsStackTrace.GetCurrClassFunction());
                //clsCommonJsFunc.Alert(this, strMsg);

            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }
        }

        protected void btnCheckRegionFlds_Click(object sender, EventArgs e)
        {
            if (ddlCmPrjIdq.SelectedIndex <= 0) return;
            string strCmPrjId = ddlCmPrjIdq.SelectedValue;
            List<string> lstViewId = wucvViewInfo4Gv1.GetAllCheckedKeysFromGv();
            if (lstViewId == null) return;
            try
            {
                foreach (string strViewId in lstViewId)
                {
                    clsViewInfoBLEx.CheckRegionFlds(strViewId, strCmPrjId, clsCommonSession.UserId);
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_vViewInfo();
        }
    }
}