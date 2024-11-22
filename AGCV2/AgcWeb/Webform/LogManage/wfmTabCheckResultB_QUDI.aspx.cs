
///----------------------
///���ɴ���汾��2012.01.02.1
///�������ڣ�2012/08/28
///�����ߣ����Է�
///�������ƣ�AGC
///����ID��0005
///ģ������������־����
///ģ��Ӣ������LogManage
///ע�⣺1����Ҫ���ݵײ㣨PubDataBase.dll���İ汾��2011.05.08.1
///       2����Ҫ���������㣨TzPubFunction.dll���İ汾��2011.05.08.1
///========================

using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using com.taishsoft.commdb;
using com.taishsoft.common;
using CommFunc4WebForm;
using AGC.Entity;

using AGC.BusinessLogic;using AGC.FunClass;

using AGC.BusinessLogicEx;


using com.taishsoft.datetime;


namespace AGC.Webform
{
    /// <summary>
    /// wfmTabCheckResultB_QUDI ��ժҪ˵��������Q�����ѯ��U�����޸�
    /// </summary>
    public partial class wfmTabCheckResultB_QUDI : CommWebPageBase
    {
        /// <summary>
        /// ����:��ǰҳ������
        /// </summary>
        public override string conCurrPageName
        {
            get
            {
                return "wfmTabCheckResultB_QUDI.aspx";
            }
        }

        //�����йصı����������
        protected const string ViewId4Potence = "00260203";		//������


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
                wucTabCheckResultB1.SetDdl_PrjId();
                wucTabCheckResultB1.SetDdl_TabId();
                clsProjectsBLEx.BindDdl_PrjIdCacheEx(ddlPrjIdq);
                clsTabCheckErrorTypeBL.BindDdl_TabCheckErrorTypeIdCache(ddlTabCheckErrorTypeId);

                ddlPrjIdq.SelectedValue = clsPubVar.CurrSelPrjId;
                clsPrjTabBLEx.BindDdl_TabIdExCache(ddlTabIdq, clsPubVar.CurrSelPrjId);
                clsSQLDSTypeBL.BindDdl_SqlDsTypeIdCache(ddlSqlDsTypeId);
                clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(clsPubVar.CurrPrjDataBaseId);
                clsPrjDataBaseBLEx.BindDdl_PrjDataBaseIdEx(ddlPrjDataBaseIdq, clsPubVar.CurrSelPrjId);
                ddlPrjDataBaseIdq.SelectedValue = objPrjDataBaseEN.PrjDataBaseId;
                clsFuncModule_AgcBLEx.BindDdl_FuncModuleId(ddlFuncModuleId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId);

                clsErrorLevelBL.BindDdl_ErrorLevelIdCache(ddlErrorLevelIdq);

                if (string.IsNullOrEmpty(seSqlDsTypeId) == false)
                {
                    ddlSqlDsTypeId.SelectedValue = seSqlDsTypeId;
                }


                if (string.IsNullOrEmpty(seErrorLevelId) == false)
                {
                    ddlErrorLevelIdq.SelectedValue = seErrorLevelId;
                }
                if (string.IsNullOrEmpty(seTabCheckErrorTypeId) == false)
                {
                    ddlTabCheckErrorTypeId.SelectedValue = seTabCheckErrorTypeId;
                }


                if (string.IsNullOrEmpty(vsSortTabCheckResultBy) == true)
                {
                    vsSortTabCheckResultBy = "TabName Asc";
                }
                //2����ʾ�������ı�������DATAGRID��
                BindGv_TabCheckResult();
                //3�����ñ�ؼ����ֿؼ���ReadOnly���ԣ�
                //   ʹֻ֮������Ϊ���޸Ĺ����йؼ����ǲ��ܱ��޸ĵġ�
                DispTabCheckResultListRegion();
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
            this.gvTabCheckResult.PageIndex = 0;
            //�ѱ��¼��������ʾ��DATAGRID��
            BindGv_TabCheckResult();
        }
        /// <summary>
        /// �������ܣ��¼��������ڸ���DATAGRID�ĵ�ǰҳ����ʱ�����ĺ�����
        ///			  ���幦����������ʾ��ҳ(������ҳ����)�����ݡ�
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void gvTabCheckResult_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            //�������裺����2����
            //1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
            //2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ

            //1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
            this.gvTabCheckResult.PageIndex = e.NewPageIndex;
            //2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ
            BindGv_TabCheckResult();
        }
        /// <summary>
        /// �������ܣ����Ըùؼ��ֵļ�¼������ʾ�ڽ����ϣ�
        ///������     �������ǰ�ֵ������ؼ���
        /// </summary>
        /// <param name="lngmId">���¼�Ĺؼ��֣���ʾ�ñ�ؼ��ֵ�����</param>
        /// <summary>
        /// �������ܣ��¼�������������<ȷ���޸�>ʱ�������¼�������
        ///           ���幦��Ϊ�ѽ�������ͬ�����ݿ��У��ѽ������ݱ��浽���ݿ���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOKUpd_Click(object sender, System.EventArgs e)
        {
            string strCommandText;
            clsTabCheckResultEN objTabCheckResultEN;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "���":
                    AddTabCheckResultRecord();
                    break;
                case "ȷ�����":
                    //����һ������Ĳ���Ĵ��룬�����߼���̫�򵥣�
                    //�Ͱ��߼���ϲ������Ʋ�,
                    AddTabCheckResultRecordSave();
                    break;
                case "ȷ���޸�":
                    //����һ��������޸ĵĴ��룬�����߼���̫�򵥣�
                    //�Ͱ��߼���ϲ������Ʋ�,
                    objTabCheckResultEN = (clsTabCheckResultEN)Session["objTabCheckResultEN"];
                    UpdateTabCheckResultRecordSave(objTabCheckResultEN);
                    break;
            }
        }

        ///����¼�¼���¼����̣������ڸù����е���������������Ҫ��������Ӷ��д��롣
        protected void btnAddNewRec4Gv_Click(object sender, System.EventArgs e)
        {
            AddTabCheckResultRecord();
        }

        //����ר�����ڵ���Excel����ش���
        protected void btnExportExcel4Gv_Click(object sender, System.EventArgs e)
        {
            //����Excel����
            ExportExcel();
        }

        /// <summary>
        ///ɾ����ǰ��ѡ��¼
        /// </summary>
        protected void btnDelete4Gv_Click(object sender, System.EventArgs e)
        {
            List<string> lstKeyValues = clsCommForWebForm.GetAllCheckedItemFromGv(gvTabCheckResult, "chkCheckRec", "mId");
            if (lstKeyValues.Count == 0)
            {
                lblMsgList.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
                return;
            }
            lblMsgList.Text = "";
            try
            {
                foreach (string strKeyValue in lstKeyValues)
                {
                    string[] strKeys = strKeyValue.Split(',');
                    long lngmId = long.Parse(strKeys[0]);
                    clsTabCheckResultBL.DelRecord(lngmId);
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_TabCheckResult();
        }

        /// <summary>
        ///�޸ĵ�ǰ��ѡ��¼
        /// </summary>
        protected void btnUpdate4Gv_Click(object sender, System.EventArgs e)
        {
            List<string> lstKeyValue = clsCommForWebForm.GetFirstCheckedItemFromGv(gvTabCheckResult, "mId");
            if (lstKeyValue.Count == 0)
            {
                lblMsgList.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
                return;
            }
            lblMsgList.Text = "";
            //1����ʾ�ùؼ��ֵ��������û��޸ĸùؼ��ּ�¼��
            string[] strKeys = lstKeyValue[0].Split(',');
            long lngmId = long.Parse(strKeys[0]);
            UpdateTabCheckResultRecord(lngmId);
        }
        protected void gvTabCheckResult_Sorting(object sender, GridViewSortEventArgs e)
        {
            int intIndex;
            //�ж��Ƿ����µ������ֶ�
            intIndex = vsSortTabCheckResultBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                vsSortTabCheckResultBy = e.SortExpression + " Asc";
                BindGv_TabCheckResult();
                return;
            }
            //���ԭ��������
            intIndex = vsSortTabCheckResultBy.IndexOf(" Asc");
            if (intIndex == -1)		//���ԭ���������������Ϊ����
            {
                vsSortTabCheckResultBy = e.SortExpression + " Asc";
            }
            else			///��������Ϊ����
            {
                vsSortTabCheckResultBy = e.SortExpression + " Desc";
            }
            BindGv_TabCheckResult();
        }
        /// <summary>
        /// ���ڼ�¼GridView�еĵ�ǰ������ʽ���Ա������һ�������򣬻��ǽ�������
        /// </summary>
        protected string seSqlDsTypeId
        {
            get
            {
                string sqeSqlDsTypeId;
                sqeSqlDsTypeId = (string)Session["qeSqlDsTypeId"];
                if (sqeSqlDsTypeId == null)
                {
                    sqeSqlDsTypeId = "";
                }
                return sqeSqlDsTypeId;
            }
            set
            {
                string sqeSqlDsTypeId = value;
                Session.Add("qeSqlDsTypeId", sqeSqlDsTypeId);
            }
        }

        /// <summary>
        /// ���ڼ�¼GridView�еĵ�ǰ������ʽ���Ա������һ�������򣬻��ǽ�������ddlTabCheckErrorTypeId
        /// </summary>
        protected string seErrorLevelId
        {
            get
            {
                string sqeErrorLevelId;
                sqeErrorLevelId = (string)Session["qeErrorLevelId"];
                if (sqeErrorLevelId == null)
                {
                    sqeErrorLevelId = "";
                }
                return sqeErrorLevelId;
            }
            set
            {
                string sqeErrorLevelId = value;
                Session.Add("qeErrorLevelId", sqeErrorLevelId);
            }
        }

        /// <summary>
        /// ���ڼ�¼GridView�еĵ�ǰ������ʽ���Ա������һ�������򣬻��ǽ�������
        /// </summary>
        protected string seTabCheckErrorTypeId
        {
            get
            {
                string sqeTabCheckErrorTypeId;
                sqeTabCheckErrorTypeId = (string)Session["TabCheckErrorTypeId"];
                if (sqeTabCheckErrorTypeId == null)
                {
                    sqeTabCheckErrorTypeId = "";
                }
                return sqeTabCheckErrorTypeId;
            }
            set
            {
                string sqeTabCheckErrorTypeId = value;
                Session.Add("TabCheckErrorTypeId", sqeTabCheckErrorTypeId);
            }
        }


        /// <summary>
        /// ���ڼ�¼GridView�еĵ�ǰ������ʽ���Ա������һ�������򣬻��ǽ�������
        /// </summary>
        protected string vsSortTabCheckResultBy
        {
            get
            {
                string sSortTabCheckResultBy;
                sSortTabCheckResultBy = (string)ViewState["SortTabCheckResultBy"];
                if (sSortTabCheckResultBy == null)
                {
                    sSortTabCheckResultBy = "";
                }
                return sSortTabCheckResultBy;
            }
            set
            {
                string sSortTabCheckResultBy = value;
                ViewState.Add("SortTabCheckResultBy", sSortTabCheckResultBy);
            }
        }

        ///��������ҳ����غ���
        protected void btnJumpPage_Click(object sender, EventArgs e)
        {
            GridViewRow pagerRow = gvTabCheckResult.BottomPagerRow;
            TextBox txtJump2Page = (TextBox)pagerRow.FindControl("txtJump2Page");
            if (txtJump2Page != null)
            {
                if (txtJump2Page.Text.Trim() != "" &&
                int.Parse(txtJump2Page.Text) > 0 &&
                int.Parse(txtJump2Page.Text) - 1 < this.gvTabCheckResult.PageCount)
                {
                    this.gvTabCheckResult.PageIndex = int.Parse(txtJump2Page.Text) - 1;
                }
                this.BindGv_TabCheckResult();
            }
        }


        ///���ɵĸı�GridView��ÿҳ��¼������������غ���
        protected void ddlPagerRecCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList ddlPagerRecCount = (DropDownList)sender;
            string strPageSize = ddlPagerRecCount.Text;
            if (clsDateTime.IsNumeric(strPageSize) == true)
            {
                int intPageSize = int.Parse(strPageSize);
                if (intPageSize >= 1)
                {
                    PageSize4TabCheck = intPageSize.ToString();
                    BindGv_TabCheckResult();
                }
            }
        }

        ///����GridView��������¼�����
        protected void gvTabCheckResult_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            string strCommandName = e.CommandName;
            switch (strCommandName)
            {
                case "lbSelAll":
                    System.Web.UI.WebControls.LinkButton lbSelAll;
                    lbSelAll = (LinkButton)e.CommandSource;
                    if (lbSelAll.CommandName != "lbSelAll")
                    {
                        return;
                    }
                    if (lbSelAll.Text == "ȫѡ")
                    {
                        clsCommForWebForm.Set_GridViewAllChecked(gvTabCheckResult, true);
                        lbSelAll.Text = "��ѡ";
                    }
                    else if (lbSelAll.Text == "��ѡ")
                    {
                        clsCommForWebForm.Set_GridViewAllChecked(gvTabCheckResult, false);
                        lbSelAll.Text = "ȫѡ";
                    }
                    break;
            }
        }
        ///ɾ����¼���̴���for C#
        protected void gvTabCheckResult_RowCreated(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                System.Web.UI.WebControls.LinkButton myDeleteButton;
                myDeleteButton = (System.Web.UI.WebControls.LinkButton)e.Row.FindControl("lbDelete");
                if (myDeleteButton != null)
                {
                    myDeleteButton.Attributes.Add("onclick", "return confirm('�����Ҫɾ���� " + (e.Row.RowIndex + 1).ToString() + " ����');");
                }
            }
            int intIndex;
            if (vsSortTabCheckResultBy == "") return;
            if (e.Row.RowType == DataControlRowType.Header)//����ؼ��Ƿ�Ϊҳü��
            {
                string strSortEx;
                for (int i = 0; i < this.gvTabCheckResult.Columns.Count; i++)
                {
                    strSortEx = this.gvTabCheckResult.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = vsSortTabCheckResultBy.IndexOf(strSortEx + " ");
                    if (intIndex >= 0)  //��ͼ״̬��������ʽ�Ƿ�Ϊ���е��ֶΣ�
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//�������壬��"webdings"��5�������ǣ�6�������ǣ�
                        intIndex = vsSortTabCheckResultBy.IndexOf("Asc");
                        lblSort.Text = (intIndex > 0 ? " 5" : " 6");//�Ƿ�Ϊ���򣬶���Ϊstring�ͣ�
                        e.Row.Cells[i].Controls.Add(lblSort);//��������ĵ�i����Ԫ��������һ�ؼ���
                        break;
                    }
                }
            }
        }

        ///
        protected void gvTabCheckResult_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string strmId = gvTabCheckResult.DataKeys[e.RowIndex]["mId"].ToString();
            long lngmId = long.Parse(strmId);
            DeleteTabCheckResultRecord(lngmId);
        }
        ///
        protected void gvTabCheckResult_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string strmId = gvTabCheckResult.DataKeys[e.RowIndex]["mId"].ToString();
            long lngmId = long.Parse(strmId);
            UpdateTabCheckResultRecord(lngmId);
        }
        ///ɾ����¼���̴���for C#
        protected void gvTabCheckResult_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            if (e.NewPageIndex != -1)
            {
                gvTabCheckResult.PageIndex = e.NewPageIndex;
                this.BindGv_TabCheckResult();
            }
        }
        ///
        protected void btnCancelTabCheckResultEdit_Click(object sender, EventArgs e)
        {
            DispTabCheckResultListRegion();
        }

        protected void ddlPrjId_q_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlPrjIdq.SelectedIndex > 0)
            {
                string strPrjId = ddlPrjIdq.SelectedValue;
                clsPrjTabBLEx.BindDdl_TabIdExCache(ddlTabIdq, strPrjId);
            }
        }

        protected void btnEditObjectAndTabFields_Click(object sender, EventArgs e)
        {
            JumpOtherPages("EditTabAndObjectFields");
        }

        protected void lbCheckAllTabField_Click(object sender, EventArgs e)
        {

       
            lblMsgList.Text = "";
            int intCount = 0;
            string strCurrDate14 = clsDateTime.getTodayDateTimeStr(1);
            try
            {
                clsLog objLog = new clsLog(@"D:\TaishSoft\",  "������־");
                string strMsg = string.Format("��鿪ʼʱ�䣺{0}", strCurrDate14);
                objLog.WriteDebugLog(strMsg);
                clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(clsPubVar.CurrPrjDataBaseId);
                intCount = clsTabCheckStatusBLEx.CheckAllTabField(clsPubVar.CurrSelPrjId, objPrjDataBaseEN.PrjDataBaseId, clsCommonSession.UserId);

                strCurrDate14 = clsDateTime.getTodayDateTimeStr(1);
                strMsg = string.Format("������ʱ�䣺{0}", strCurrDate14);
                objLog.WriteDebugLog(strMsg);
                objLog.WriteDebugLog("�����ֶ���ɣ����ƣ�" + intCount.ToString() + "����");
                clsCommonJsFunc.Alert(this, "�����ֶ���ɣ����ƣ�" + intCount.ToString() + "����");
     
            }
            catch (Exception objException)
            {
                clsSysParaEN.spIsUseQueue4Task = false;
                lblMsgList.Text = objException.Message;
                clsCommonJsFunc.Alert(this, objException.Message);
      
            } //��ʾ���ɴ�������

        }

        protected void lbSetNullableBySQL_Click(object sender, EventArgs e)
        {
            string strMid = clsCommForWebForm.GetFirstCheckedItemFromGv(gvTabCheckResult);
            if (strMid == null || strMid.Trim().Length == 0)
            {
                lblMsgList.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
                return;
            }
            long lngMid = long.Parse(strMid);
            lblMsgList.Text = "";
            clsTabCheckResultEN objTabCheckResultEN = new clsTabCheckResultEN(lngMid);
            clsTabCheckResultBL.GetTabCheckResult(ref objTabCheckResultEN);
            string strTabId = objTabCheckResultEN.TabId;
            List<string> arrTabIdLst = new List<string>();
            arrTabIdLst.Add(strTabId);
            //����SQL����Ϣ���ñ��ֶεĿɿ���
            clsProjectsEN objProjectsEN = new clsProjectsEN(clsPubVar.CurrSelPrjId);

            try
            {
                clsProjectsBL.GetProjects(ref objProjectsEN);
                clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(clsPubVar.CurrPrjDataBaseId);
                clsTabCheckStatusBLEx.SetPrjTabFldNullBySQLTab(strTabId, objProjectsEN, objPrjDataBaseEN.PrjDataBaseId, clsCommonSession.UserId);
                if (arrTabIdLst.Count == 0)
                {
                    lblMsgList.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
                    return;
                }
                int intCount = 0;
                intCount = clsTabCheckStatusBLEx.CheckCheckedTabField(clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, clsCommonSession.UserId, arrTabIdLst);
                clsCommonJsFunc.Alert(this, "�����ֶ���ɣ����ƣ�" + intCount.ToString() + "����");
                //��ʾ���ɴ�������
                BindGv_TabCheckResult();
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                lblMsgList.Text = ErrMessage;
                clsCommonJsFunc.Alert(this, ErrMessage);
                //clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                //clsPubFun4Web.AccessError(this, conCurrPageName);
            }
        }

        protected void ddlFuncModuleId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlFuncModuleId.SelectedIndex > 0)
            {
                string strFuncModuleId = ddlFuncModuleId.SelectedValue;
                clsPrjTabBLEx.BindDdl_TabIdExCache(ddlTabIdq, clsPubVar.CurrSelPrjId, strFuncModuleId);
            }
        }

        protected void btnSetTabWaitConsider_Click(object sender, EventArgs e)
        {
            List<string> lstKeyValues = clsCommForWebForm.GetAllCheckedItemFromGv(gvTabCheckResult, "chkCheckRec", "mId");
            if (lstKeyValues.Count == 0)
            {
                lblMsgList.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
                return;
            }
            lblMsgList.Text = "";
            try
            {
                foreach (string strKeyValue in lstKeyValues)
                {
                    string[] strKeys = strKeyValue.Split(',');
                    long lngmId = long.Parse(strKeys[0]);
                    clsTabCheckResultEN objTabCheckResultEN = new clsTabCheckResultEN(lngmId);
                    clsTabCheckResultBL.GetTabCheckResult(ref objTabCheckResultEN);
                    clsPrjTabEN objPrjTabEN = new clsPrjTabEN(objTabCheckResultEN.TabId);
                    objPrjTabEN.TabStateId = "04";
                    objPrjTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                    objPrjTabEN.UpdUserId = clsCommonSession.UserId;
                    clsPrjTabBL.UpdateBySql2(objPrjTabEN);
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_TabCheckResult();

        }

        protected void lbCheckConsistency_Click(object sender, EventArgs e)
        {
            JumpOtherPages("CheckConsistency");
                   }
        //���ɷ������Ӵ���Session����
        protected string BackPageLinkStrFromUpdField
        {
            get
            {
                string strBackPageLinkStrFromUpdField;
                strBackPageLinkStrFromUpdField = (string)Session["BackPageLinkStrFromUpdField"];
                if (strBackPageLinkStrFromUpdField == null)
                {
                    strBackPageLinkStrFromUpdField = "";
                }
                return strBackPageLinkStrFromUpdField;
            }
            set
            {
                string strBackPageLinkStrFromUpdField = value;
                Session.Add("BackPageLinkStrFromUpdField", strBackPageLinkStrFromUpdField);
            }
        }

        protected void lbCheckAllTabField4Old_Click(object sender, EventArgs e)
        {
            lblMsgList.Text = "";
            int intCount = 0;
            try
            {
                clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(clsPubVar.CurrPrjDataBaseId);

                intCount = clsTabCheckStatusBLEx.CheckAllTabField(clsPubVar.CurrSelPrjId, objPrjDataBaseEN.PrjDataBaseId, clsCommonSession.UserId);

                clsCommonJsFunc.Alert(this, "�����ֶ���ɣ����ƣ�" + intCount.ToString() + "����");
            }
            catch (Exception objException)
            {
                lblMsgList.Text = objException.Message;
                clsCommonJsFunc.Alert(this, objException.Message);
            } //��ʾ���ɴ�������
        }

        protected void lbInitCheckAllTabField_Click(object sender, EventArgs e)
        {
            try
            {               
                clsTabCheckStatusBLEx.InitCheckAllTabField(clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId);
                lblMsgList.Text = "";
                clsCommonJsFunc.Alert(this, "��ʼ����ɣ�");
            }
            catch (Exception objException)
            {
                lblMsgList.Text = objException.Message;
                clsCommonJsFunc.Alert(this, objException.Message);
            } //��ʾ���ɴ�������
        }

        protected void lbCheckCheckedTabField_Click(object sender, EventArgs e)
        {
            lblMsgList.Text = "";
            List<string> lstKeyValues = clsCommForWebForm.GetAllCheckedItemFromGv(gvTabCheckResult, "chkCheckRec", "mId");
            if (lstKeyValues.Count == 0)
            {
                lblMsgList.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
                return;
            }
            lblMsgList.Text = "";
            List<string> arrTabIdLst = new List<string>();
            try
            {
                foreach (string strKeyValue in lstKeyValues)
                {
                    string[] strKeys = strKeyValue.Split(',');
                    long lngmId = long.Parse(strKeys[0]);
                    clsTabCheckResultEN objTabCheckResultEN = new clsTabCheckResultEN(lngmId);
                    clsTabCheckResultBL.GetTabCheckResult(ref objTabCheckResultEN);
                    if (arrTabIdLst.Contains(objTabCheckResultEN.TabId) == false)
                    {
                        arrTabIdLst.Add(objTabCheckResultEN.TabId);
                    }
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            if (arrTabIdLst.Count == 0)
            {
                lblMsgList.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
                return;
            }
            int intCount = 0;
            try
            {
     
                intCount = clsTabCheckStatusBLEx.CheckCheckedTabField(clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, clsCommonSession.UserId, arrTabIdLst);
                clsCommonJsFunc.Alert(this, "�����ֶ���ɣ����ƣ�" + intCount.ToString() + "����");
            }
            catch (Exception objException)
            {
                lblMsgList.Text = objException.Message;
                clsCommonJsFunc.Alert(this, objException.Message);
            } //��ʾ���ɴ�������
            BindGv_TabCheckResult();
        }

        protected void btnCreateView4Sql_Click(object sender, EventArgs e)
        {

            List<string> lstKeyValues = clsCommForWebForm.GetAllCheckedItemFromGv(gvTabCheckResult, "chkCheckRec", "mId");
            if (lstKeyValues.Count == 0)
            {
                lblMsgList.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
                return;
            }
            lblMsgList.Text = "";
            try
            {
                foreach (string strKeyValue in lstKeyValues)
                {
                    string[] strKeys = strKeyValue.Split(',');
                    string strMId = strKeys[0];
                    long lngMid = long.Parse(strMId);
                    clsTabCheckResultEN objTabCheckResultEN = new clsTabCheckResultEN(lngMid);
                    clsTabCheckResultBL.GetTabCheckResult(ref objTabCheckResultEN);
                    if (string.IsNullOrEmpty(objTabCheckResultEN.TabId) == true)
                    {
                        continue;
                    }
                    string strCondition = string.Format("{0}='{1}'", conSqlView.RelaTabId, objTabCheckResultEN.TabId);
                    clsSqlViewEN objSqlViewEN = clsSqlViewBL.GetFirstObj_S(strCondition);
                    if (objSqlViewEN == null)
                    {
                        clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabId(objTabCheckResultEN.TabId);
                        string strMsg = string.Format("������{0}({1})û����ص�SqlView,���飡", objPrjTab.TabName, objPrjTab.TabCnName);

                        clsCommonJsFunc.Alert(this, strMsg);
                        return;
                    }
                    string strSqlViewId = objSqlViewEN.SqlViewId;



                    //���г���������ͼ������ͼ�ı��Ƿ�Ϸ�
                    clsSqlViewBLEx.CreateView4Sql(strSqlViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId, clsPubVar.CurrPrjDataBaseId, true);
                    //��ʽ��������ͼ
                    clsSqlViewBLEx.CreateView4Sql(strSqlViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId, clsPubVar.CurrPrjDataBaseId, false);
                }
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }

            BindGv_TabCheckResult();
            clsCommonJsFunc.Alert(this, "��Sql�н�����ͼ�ɹ���");
        }

        protected void btnSetOrderNum4Refer_Click(object sender, EventArgs e)
        {
            try
            {
                //  clsSqlViewBLEx.SetOrderNum4Refer(clsPubVar.CurrSelPrjId);
                int intCount = clsPrjTabBLEx.SetOrderNum4Refer(clsPubVar.CurrSelPrjId);

                //BindGv_SqlView();
                clsCommonJsFunc.Alert(this, string.Format("����������ųɹ�����������:{0}����¼��", intCount));
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonJsFunc.Alert(this, ErrMessage);
            }
        }

        protected void btnQueryReferedTabAndView_Click(object sender, EventArgs e)
        {
            if (ddlTabIdq.SelectedIndex <= 0)
            {
                clsCommonJsFunc.Alert(this, "��ѡ��һ����!");
                ddlTabIdq.Focus();
                return;
            }
            string strTabId = ddlTabIdq.SelectedValue;
            List<string> arrTabId = clsPrjTabBLEx.GetRelaParentNodeByTabId(strTabId, clsPubVar.CurrSelPrjId);
            if (arrTabId.Count == 0)
            {
                clsCommonJsFunc.Alert(this, "��ѡ��û����ظ�����");
                return;
            }
            string strCondition = string.Format("{0} in ({1})",
                conTabCheckResult.TabId, clsArray.GetSqlInStrByArray(arrTabId, true));
            BindGv_TabCheckResult(strCondition);

        }

        protected void btnQueryViewReferThisTab_Click(object sender, EventArgs e)
        {
            if (ddlTabIdq.SelectedIndex <= 0)
            {
                clsCommonJsFunc.Alert(this, "��ѡ��һ����!");
                ddlTabIdq.Focus();
                return;
            }
            string strTabId = ddlTabIdq.SelectedValue;
            List<string> arrTabId = clsPrjTabBLEx.GetRelaSubNodeByTabId(strTabId, clsPubVar.CurrSelPrjId);
            if (arrTabId.Count == 0)
            {
                clsCommonJsFunc.Alert(this, "��ѡ��û�����øñ�������ͼ��");
                return;
            }
            string strCondition = string.Format("{0} in ({1})",
                conTabCheckResult.TabId, clsArray.GetSqlInStrByArray(arrTabId, true));
            BindGv_TabCheckResult(strCondition);
        }

        protected void gvTabCheckResult_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    public partial class wfmTabCheckResultB_QUDI : CommWebPageBase
    {
        protected void ShowData(long lngmId)
        {
            //�������裺
            //1�����ؼ����Ƿ�Ϊ�գ�
            //2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
            //3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
            //4����ȡ�������������ԣ�
            //5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���

            //1�����ؼ����Ƿ�Ϊ�գ�
            if (lngmId == 0) return;		//����ؼ���Ϊ�վͷ����˳�
            //2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
            if (clsTabCheckResultBL.IsExist(lngmId) == false)		//���ùؼ��ֵļ�¼�Ƿ����
            {
                string ss = "�ؼ���Ϊ��" + lngmId + "�Ĳ�����!";
                clsCommonJsFunc.Alert(this, ss);
                return;
            }
            //3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
            clsTabCheckResultEN objTabCheckResultEN = new clsTabCheckResultEN(lngmId);
            //4����ȡ�������������ԣ�
            try
            {
                clsTabCheckResultBL.GetTabCheckResult(ref objTabCheckResultEN);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            Session.Add("objTabCheckResultEN", objTabCheckResultEN);
            //5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���
            GetDataFromTabCheckResultClass(objTabCheckResultEN);
        }

        //����Ȩ�޵ȼ�������
        protected string strPotenceLevel
        {
            get
            {
                string sPotenceLevel;
                sPotenceLevel = (string)ViewState["PotenceLevel"];
                if (sPotenceLevel == null)
                {
                    //					sPotenceLevel=new General_Platform_Dll.MenuAndPotence().Get_PotenceLevel(ViewId4Potence);
                    sPotenceLevel = "9";
                    ViewState.Add("PotenceLevel", sPotenceLevel);
                }
                return sPotenceLevel;
            }
        }


        
        /// <summary>
        /// ��¼���û�ID�����ڼ���û�Ȩ��
        /// </summary>
        protected string UserId
        {
            get
            {
                string strUserId;
                strUserId = (string)Session["UserId"];
                if (strUserId == null)
                {
                    strUserId = "";
                }
                return strUserId;
            }
            set
            {
                string strUserId = value;
                Session.Add("UserId", strUserId);
            }
        }
        ///protected clsUsersEN objUser
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




        /// <summary>
        /// ר�����ڼ�¼GridView�е�ÿҳ��¼��
        /// </summary>
        protected string PageSize4TabCheck
        {
            get
            {
                string strPageSize;
                strPageSize = (string)Session["PageSize4TabCheck"];
                if (strPageSize == null)
                {
                    strPageSize = "";
                }
                return strPageSize;
            }
            set
            {
                string strPageSize = value;
                Session.Add("PageSize4TabCheck", strPageSize);
            }
        }


        /// <summary>
        /// ������Ϣ��Session���ԣ���Session���ݸ���ʾ����ҳ�棬��ʾ��Ӧ�Ĵ������ݡ�
        /// </summary>
        protected string ErrMessage
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


        //���ɷ������Ӵ���Session����
        /// <summary>
        /// �������Ӵ���Session���ԣ���Session���ڸ��߳���ҳ�棬��һ��ҳ������Ҫ���ص�ҳ�档
        /// </summary>
        protected string BackErrPageLinkStr
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

        /// <summary>
        /// �����еĲ�ѯ�ؼ�������ϳ�һ��������
        /// </summary>
        /// <returns>������(strWhereCond)</returns>
        protected string CombineTabCheckResultCondition()
        {
            //ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
            //���� 1=1 && UserName = '����'
            string strWhereCond = string.Format(" 1=1 And TabStateId='01' And  FuncModuleAgcId in (Select FuncModuleAgcId From DataBaseModuleRela where PrjId='{0}' And PrjDataBaseId='{1}' And IsVisible='1') ", clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId);

            //����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
            if (this.ddlPrjIdq.SelectedValue != "" && this.ddlPrjIdq.SelectedValue != "0")
            {
                strWhereCond += " And PrjId='" + this.ddlPrjIdq.SelectedValue + "'";
            }
            if (this.ddlPrjDataBaseIdq.SelectedValue != "" && this.ddlPrjDataBaseIdq.SelectedValue != "0")
            {
                strWhereCond += " And PrjDataBaseId='" + this.ddlPrjDataBaseIdq.SelectedValue + "'";
            }
            if (this.ddlFuncModuleId.SelectedValue != "" && this.ddlFuncModuleId.SelectedValue != "0")
            {
                strWhereCond += " and FuncModuleAgcId='" + this.ddlFuncModuleId.SelectedValue + "'";
            }
            if (this.ddlSqlDsTypeId.SelectedValue != "" && this.ddlSqlDsTypeId.SelectedValue != "0")
            {
                seSqlDsTypeId = this.ddlSqlDsTypeId.SelectedValue;
                strWhereCond += " And SqlDsTypeId='" + this.ddlSqlDsTypeId.SelectedValue + "'";
            }
            else
            {
                seSqlDsTypeId = "";
            }
            if (this.ddlTabIdq.SelectedValue != "" && this.ddlTabIdq.SelectedValue != "0")
            {
                strWhereCond += " And TabId='" + this.ddlTabIdq.SelectedValue + "'";
            }
            if (this.txtErrorMsgq.Text.Trim() != "")
            {
                strWhereCond += " And errorMsg like '%" + this.txtErrorMsgq.Text.Trim() + "%'";
            }
            if (this.ddlErrorLevelIdq.SelectedValue != "" && this.ddlErrorLevelIdq.SelectedValue != "0")
            {
                seErrorLevelId = ddlErrorLevelIdq.SelectedValue;
                strWhereCond += " And ErrorLevelId='" + this.ddlErrorLevelIdq.SelectedValue + "'";
            }
            else
            {
                seErrorLevelId = "";
            }

            if (this.ddlTabCheckErrorTypeId.SelectedValue != "" && this.ddlTabCheckErrorTypeId.SelectedValue != "0")
            {
                seTabCheckErrorTypeId = ddlTabCheckErrorTypeId.SelectedValue;
                strWhereCond += " And TabCheckErrorTypeId='" + this.ddlTabCheckErrorTypeId.SelectedValue + "'";
            }
            else
            {
                seTabCheckErrorTypeId = "";
            }
            return strWhereCond;
        }
        ///���ɰ�GridView�Ĵ���
        /// <summary>
        /// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
        ///			 ����ʾ��GridView�С�
        /// </summary>
        protected void BindGv_TabCheckResult(params string[] args)
        {
            //�������裺(��5��)
            //	1����Ͻ�����������
            //	2��������������ȡ�ñ�����������DataTable��
            //	4������GridView������Դ(DataSource)��
            //	5����GridView������DataTable��������ʾ��DATAGRID��
            //	6�����ü�¼����״̬��
            //		�ڱ��������ǰ�״̬��ʾ�ڿؼ�txtRecCount�С�

            //	1����Ͻ�����������
            string strWhereCond = "";
            if (args.Length == 0)
            {
                strWhereCond = CombineTabCheckResultCondition();
            }
            else if (args.Length == 1)
            {
                strWhereCond = args[0];
            }
            //	2��������������ȡ�ñ�����������DataTable��
            System.Data.DataTable objDT = null;
            try
            {
                objDT = clsvTabCheckResultBL.GetDataTable(strWhereCond);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "��ȡ���ݱ�(DataTable)���ɹ�!" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            //	4������GRIDView������Դ(DataSource)��
            DataView objDV = objDT.DefaultView;
            objDV.Sort = vsSortTabCheckResultBy;     ///ע����һ�д����п�����Ҫע�͵���Ŀǰ���н����ڵ����Ĳ�ѯ������������
                                                      ///����GridView��ÿҳ�ļ�¼��
            if (string.IsNullOrEmpty(PageSize4TabCheck) == false)
            {
                int intPageSize = int.Parse(PageSize4TabCheck);
                gvTabCheckResult.PageSize = intPageSize;
            }
            else
            {
                PageSize4TabCheck = "10";
                gvTabCheckResult.PageSize = 10;
            }
            this.gvTabCheckResult.DataSource = objDV;
            //	5����DATAGRID������DataTable��������ʾ��DATAGRID��
            this.gvTabCheckResult.DataBind();

            ///����ר������BindGv�е���ҳ��ش���
            GridViewRow pagerRow = gvTabCheckResult.BottomPagerRow;
            if (pagerRow == null)
            {
                return;
            }
            Label lblRecCount = (Label)pagerRow.FindControl("lblRecCount");
            Label lblAllPages = (Label)pagerRow.FindControl("lblAllPages");
            Label lblCurrentPage = (Label)pagerRow.FindControl("lblCurrentPage");
            TextBox txtJump2Page = (TextBox)pagerRow.FindControl("txtJump2Page");
            Button btnNextPage = (Button)pagerRow.FindControl("btnNextPage");
            Button btnPrevPage = (Button)pagerRow.FindControl("btnPrevPage");
            Button tabJumpPage = (Button)pagerRow.FindControl("tabJumpPage");
            DropDownList ddlPagerRecCount = (DropDownList)pagerRow.FindControl("ddlPagerRecCount");
            if (lblRecCount != null)
            {
                //��ǰ��¼��
                lblRecCount.Text = objDT.Rows.Count.ToString();
                //��ǰҳ��
                lblAllPages.Text = this.gvTabCheckResult.PageCount.ToString();
                //��ǰҳ����
                lblCurrentPage.Text = (this.gvTabCheckResult.PageIndex + 1).ToString();
                //��ǰ����������ҳ����
                txtJump2Page.Text = (this.gvTabCheckResult.PageIndex + 1).ToString();
                //�����ǰҳ����Ϊ0����<ǰһҳ>��ť��Ч
                if (this.gvTabCheckResult.PageIndex == 0)
                {
                    clsPubFun.SetButtonEnabled(btnPrevPage, false);
                }
                else
                {
                    clsPubFun.SetButtonEnabled(btnPrevPage, true);
                }
                //�����ǰҳ������Ϊ���һҳ����<ǰһҳ>��ť��Ч
                if (this.gvTabCheckResult.PageIndex == this.gvTabCheckResult.PageCount - 1)
                {
                    clsPubFun.SetButtonEnabled(btnNextPage, false);
                }
                else
                {
                    clsPubFun.SetButtonEnabled(btnNextPage, true);
                }
                //���÷�ҳ����ÿҳ��¼�����������ֵ
                if (string.IsNullOrEmpty(PageSize4TabCheck) == false)
                {
                    ddlPagerRecCount.Text = PageSize4TabCheck;
                }
                else
                {
                    PageSize4TabCheck = "10";
                    ddlPagerRecCount.Text = PageSize4TabCheck;
                }
            }
            gvTabCheckResult.BottomPagerRow.Visible = true;
        }


        ///���ɴ��߼�������ݴ��䵽�����ĺ�������
        /// <summary>
        /// �������ܣ�������������������ʾ��������
        ///ע�⣺��������������򣬲�����һ��������������ϵ�ģ�����Ϊһ��������ֵ��Ȼ����Ϊ����������ֵ
        ///      ������������ݿ�ʱ����Ӧ��һ���ֶ���ǰ�������ֶ��ں�
        /// </summary>
        /// <param name="pobjTabCheckResultEN">��ʵ�������</param>
        protected void GetDataFromTabCheckResultClass(clsTabCheckResultEN pobjTabCheckResultEN)
        {
            wucTabCheckResultB1.PrjId = pobjTabCheckResultEN.PrjId;//    ����ID
            wucTabCheckResultB1.TabId = pobjTabCheckResultEN.TabId;//    ��ID
            wucTabCheckResultB1.FldId = pobjTabCheckResultEN.FldId;//    �ֶ�ID
            wucTabCheckResultB1.ErrorLevelId = pobjTabCheckResultEN.ErrorLevelId;//    ����ȼ�Id
            wucTabCheckResultB1.errorMsg = pobjTabCheckResultEN.ErrorMsg;//    ������Ϣ
            wucTabCheckResultB1.CheckDate = pobjTabCheckResultEN.CheckDate;//    �������
            wucTabCheckResultB1.CheckUser = pobjTabCheckResultEN.CheckUser;//    �����
            wucTabCheckResultB1.Memo = pobjTabCheckResultEN.Memo;//    ˵��
        }

        /// <summary>
        /// �������ܣ��ѽ����ϵ��������ݴ����������
        /// </summary>
        /// <param name="pobjTabCheckResultEN">���ݴ����Ŀ�������</param>
        protected void PutDataToTabCheckResultClass(clsTabCheckResultEN pobjTabCheckResultEN)
        {
            pobjTabCheckResultEN.PrjId = wucTabCheckResultB1.PrjId;//    ����ID
            pobjTabCheckResultEN.TabId = wucTabCheckResultB1.TabId;//    ��ID
            pobjTabCheckResultEN.FldId = wucTabCheckResultB1.FldId;//    �ֶ�ID
            pobjTabCheckResultEN.ErrorLevelId = wucTabCheckResultB1.ErrorLevelId;//    ����ȼ�Id
            pobjTabCheckResultEN.ErrorMsg = wucTabCheckResultB1.errorMsg;//    ������Ϣ
            pobjTabCheckResultEN.CheckDate = wucTabCheckResultB1.CheckDate;//    �������
            pobjTabCheckResultEN.CheckUser = wucTabCheckResultB1.CheckUser;//    �����
            pobjTabCheckResultEN.Memo = wucTabCheckResultB1.Memo;//    ˵��
        }


        public System.Data.DataTable GetErrorLevelId()
        {
            //��ȡĳѧԺ����רҵ��Ϣ
            string strSQL = "select ErrorLevelId, ErrorLevelName from ErrorLevel ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindDdl_ErrorLevelId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //Ϊ����Դ�ڱ����������������
            ListItem li = new ListItem("��ѡ��...", "0");
            System.Data.DataTable objDT = GetErrorLevelId();
            objDDL.DataValueField = "ErrorLevelId";
            objDDL.DataTextField = "ErrorLevelName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        ///���ɵĲ����¼׼�����̴���for C#
        protected void AddTabCheckResultRecord()
        {
            btnOKUpd.Text = "ȷ�����";
            btnCancelTabCheckResultEdit.Text = "ȡ�����";

            DispEditTabCheckResultRegion();
        }
        ///�����¼���̹��̴���for C#
        protected bool AddTabCheckResultRecordSave()
        {
            //�������裺
            //1�����ؼ����������������Ƿ���ȷ
            //2��������󲢳�ʼ������
            ///3.1���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
            ///3.2�����Ψһ��
            //4����ֵ�ӽ���㴫���߼��������ʵ���
            //5����鴫��ȥ�Ķ��������Ƿ�Ϸ�
            //6��������ʵ�������ݴ��������ݿ���
            //7��������ļ�¼������ʾ��DATAGRID��
            string strMsg;	//ר�����ڴ�����Ϣ�ı���
            string strResult = " ";	//���ڴ����ڼ����������ʱ���ֵ�ı���
            clsTabCheckResultEN objTabCheckResultEN;
            //1�����ؼ����������������Ƿ���ȷ
            if (!wucTabCheckResultB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "�ؼ��������������Ͳ���ȷ����!";
                return false;
            }
            //2��������󲢳�ʼ������
            //clsTabCheckResultEN objTabCheckResultEN;	//�������
            objTabCheckResultEN = new clsTabCheckResultEN();	//��ʼ���¶���
            ///3.1���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
            //4����ֵ�ӽ���㴫���߼��������ʵ���
            PutDataToTabCheckResultClass(objTabCheckResultEN);		//�ѽ����ֵ����
            //5.1����鴫��ȥ�Ķ��������Ƿ�Ϸ�
            try
            {
                clsTabCheckResultBL.CheckPropertyNew(objTabCheckResultEN);
                //6��������ʵ�������ݴ��������ݿ���
                clsTabCheckResultBL.AddNewRecordBySql2(objTabCheckResultEN);
            }
            catch (Exception objException)
            {
                strMsg = "��Ӽ�¼���ɹ�!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgEdit.Text = strMsg;
                return false;
            }
            strMsg = "��Ӽ�¼�ɹ�!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsgEdit.Text = "��Ӽ�¼�ɹ�!";
            //7��������ļ�¼������ʾ��DATAGRID��
            BindGv_TabCheckResult();
            DispTabCheckResultListRegion();
            wucTabCheckResultB1.Clear();		//��տؼ�������
            ///�ָ�<ȷ�����>���<���>
            btnOKUpd.Text = "���";
            btnCancelTabCheckResultEdit.Text = "ȡ���༭";
            return true;
        }
        ///�����¼���̹��̴���for C#
        protected bool AddTabCheckResultRecordSaveV5()
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
            string strResult = " ";	//���ڴ����ڼ����������ʱ���ֵ�ı���
            clsTabCheckResultEN objTabCheckResultEN;
            //1�����ؼ����������������Ƿ���ȷ
            if (!wucTabCheckResultB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "�ؼ��������������Ͳ���ȷ����!";
                return false;
            }
            //2��������󲢳�ʼ������
            //clsTabCheckResultEN objTabCheckResultEN;	//�������
            objTabCheckResultEN = new clsTabCheckResultEN();	//��ʼ���¶���
            //3���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
            //4����ֵ�ӽ���㴫���߼��������ʵ���
            PutDataToTabCheckResultClass(objTabCheckResultEN);		//�ѽ����ֵ����
            //5.1����鴫��ȥ�Ķ��������Ƿ�Ϸ�
            try
            {
                clsTabCheckResultBL.CheckPropertyNew(objTabCheckResultEN);
                //6��������ʵ�������ݴ��������ݿ���
                clsTabCheckResultBL.AddNewRecordBySql2(objTabCheckResultEN);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "��Ӽ�¼���ɹ�!" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            strMsg = "��Ӽ�¼�ɹ�!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsgEdit.Text = "��Ӽ�¼�ɹ�!";
            //7��������ļ�¼������ʾ��DATAGRID��
            BindGv_TabCheckResult();
            DispTabCheckResultListRegion();
            wucTabCheckResultB1.Clear();		//��տؼ�������
            ///�ָ�<ȷ�����>���<���>
            btnOKUpd.Text = "���";
            btnCancelTabCheckResultEdit.Text = "ȡ���༭";
            return true;
        }
        ///�����޸ļ�¼׼�����̴��� for C#
        protected void UpdateTabCheckResultRecord(long lngmId)
        {
            //�������裺���ܹ�2����
            //1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
            //2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�

            //1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
            ShowData(lngmId);
            //2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
            clsPubFun.SetButtonEnabled(btnOKUpd, true);
            btnOKUpd.Text = "ȷ���޸�";
            btnCancelTabCheckResultEdit.Text = "ȡ���޸�";
            lblMsgEdit.Text = "";
            DispEditTabCheckResultRegion();
        }
        ///�޸Ĵ���׼�����̴��� for C#
        protected bool UpdateTabCheckResultRecordSave(clsTabCheckResultEN objTabCheckResultEN)
        {
            //�������裺
            //1�����ؼ����������������Ƿ���ȷ
            //2����ֵ�ӽ���㴫���߼��������ʵ���
            ///3.1����鴫��ȥ�Ķ��������Ƿ�Ϸ�
            ///3.2�����Ψһ��
            //4��������ʵ�������ݴ��������ݿ���
            //5�����޸ĺ��������ʾ��DATAGRID��
            string strMsg;	//ר�����ڴ�����Ϣ�ı���
            string strResult = " ";	//���ڴ����ڼ����������ʱ���ֵ�ı���
            //1�����ؼ����������������Ƿ���ȷ
            if (!wucTabCheckResultB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "�ؼ��������������Ͳ���ȷ����!";
                return false;
            }
            //2����ֵ�ӽ���㴫���߼��������ʵ���
            PutDataToTabCheckResultClass(objTabCheckResultEN);		//�ѽ����ֵ����
            ///3.1����鴫��ȥ�Ķ��������Ƿ�Ϸ�
            try
            {
                clsTabCheckResultBL.CheckPropertyNew(objTabCheckResultEN);
                //4��������ʵ�������ݴ��������ݿ���
                clsTabCheckResultBL.UpdateBySql2(objTabCheckResultEN);
            }
            catch (Exception objException)
            {
                strMsg = "�޸ļ�¼���ɹ�!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgEdit.Text = strMsg;
                return false;
            }
            strMsg = "�޸ļ�¼�ɹ�!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsgEdit.Text = "�޸ļ�¼�ɹ�!";
            //5�����޸ĺ��������ʾ��DATAGRID��
            BindGv_TabCheckResult();
            DispTabCheckResultListRegion();
            wucTabCheckResultB1.Clear();//��տؼ��е�����
            //�ָ�<ȷ���޸�>���<���>
            btnOKUpd.Text = "���";
            btnCancelTabCheckResultEdit.Text = "ȡ���༭";
            return true;
        }
        ///�޸Ĵ���׼�����̴��� for C#
        protected bool UpdateTabCheckResultRecordSaveV5(clsTabCheckResultEN objTabCheckResultEN)
        {
            //�������裺
            //1�����ؼ����������������Ƿ���ȷ
            //2����ֵ�ӽ���㴫���߼��������ʵ���
            ///3.1����鴫��ȥ�Ķ��������Ƿ�Ϸ�
            //4��������ʵ�������ݴ��������ݿ���
            //5�����޸ĺ��������ʾ��DATAGRID��
            string strMsg;	//ר�����ڴ�����Ϣ�ı���
            string strResult = " ";	//���ڴ����ڼ����������ʱ���ֵ�ı���
            //1�����ؼ����������������Ƿ���ȷ
            if (!wucTabCheckResultB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "�ؼ��������������Ͳ���ȷ����!";
                return false;
            }
            //2����ֵ�ӽ���㴫���߼��������ʵ���
            PutDataToTabCheckResultClass(objTabCheckResultEN);		//�ѽ����ֵ����
            ///3.1����鴫��ȥ�Ķ��������Ƿ�Ϸ�
            try
            {
                clsTabCheckResultBL.CheckPropertyNew(objTabCheckResultEN);
                //4��������ʵ�������ݴ��������ݿ���
                clsTabCheckResultBL.UpdateBySql2(objTabCheckResultEN);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "�޸ļ�¼���ɹ�!" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            strMsg = "�޸ļ�¼�ɹ�!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsgEdit.Text = "�޸ļ�¼�ɹ�!";
            //5�����޸ĺ��������ʾ��DATAGRID��
            BindGv_TabCheckResult();
            DispTabCheckResultListRegion();
            wucTabCheckResultB1.Clear();//��տؼ��е�����
            //�ָ�<ȷ���޸�>���<���>
            btnOKUpd.Text = "���";
            btnCancelTabCheckResultEdit.Text = "ȡ���༭";
            return true;
        }
        ///ɾ����¼���̴���for C#
        protected void DeleteTabCheckResultRecord(long lngmId)
        {
            try
            {
                clsTabCheckResultBL.DelRecord(lngmId);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_TabCheckResult();
        }

        ///����ר�����ڵ���Excel����ش���
        private void ExportExcel()
        {
            //	1����Ͻ�����������
            string strWhereCond = CombineTabCheckResultCondition();
            //	2��������������ȡ�ñ�����������DataTable��
            System.Data.DataTable objDT = null;
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "TabCheckResult��Ϣ����.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add("PrjId"); arrCnName.Add("����ID");
            arrColName.Add("FldId"); arrCnName.Add("�ֶ�ID");
            arrColName.Add("PrjName"); arrCnName.Add("��������");
            arrColName.Add("TabId"); arrCnName.Add("��ID");
            arrColName.Add("TabName"); arrCnName.Add("����");
            arrColName.Add("TabCnName"); arrCnName.Add("��������");
            arrColName.Add("FldName"); arrCnName.Add("�ֶ���");
            arrColName.Add("ErrorLevelId"); arrCnName.Add("����ȼ�Id");
            arrColName.Add("ErrorLevelName"); arrCnName.Add("����ȼ���");
            arrColName.Add("errorMsg"); arrCnName.Add("������Ϣ");
            arrColName.Add("CheckDate"); arrCnName.Add("�������");
            arrColName.Add("CheckUser"); arrCnName.Add("�����");
            arrColName.Add("Memo"); arrCnName.Add("˵��");
            strFolderName = clsSysParaEN.TempFileFolder;
            strDownLoadFileName = strFolderName + strFileName;
            if (clsPubVar.InitExcelFile(this, strFolderName, strDownLoadFileName) == false)
            {
                return;
            }

            try
            {
                //	2��������������ȡ�ñ�����������DataTable��
                objDT = clsvTabCheckResultBL.GetDataTable(strWhereCond);
                GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4Odbc(objDT, arrColName, arrCnName, strDownLoadFileName);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            clsCommForWebForm.DownLoadFile(strDownLoadFileName);
        }
        private void DispEditTabCheckResultRegion()
        {
            divList.Visible = false;
            tabEditTabCheckResultRegion.Visible = true;
        }
        private void DispTabCheckResultListRegion()
        {
            divList.Visible = true;
            tabEditTabCheckResultRegion.Visible = false;
        }

        #region ����ҳ����Ϣ�Լ���ת������ҳ��
        public override void InitParentPageInfo()
        {
            switch (qsParentPage)
            {
                case "wfmPrjTab_QUDI3.aspx":
                    //                lbReturnPrjTabList.Text = "����[���̱��б�]";
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
            switch (qsParentPage)
            {
                case "wfmPrjTab_QUDI3.aspx":
                    string strCurrPageName = string.Format("{0}|{1}", conCurrPageName, vsParentPage);
                    clsPubFun4Web.JumpToPrjTab_QUDI3(this, strCurrPageName);
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
            string strMid = clsCommForWebForm.GetFirstCheckedItemFromGv(gvTabCheckResult);
            if (strMid == null || strMid.Trim().Length == 0)
            {
                lblMsgList.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
                return;
            }
            long lngMid = long.Parse(strMid);
            lblMsgList.Text = "";
            clsTabCheckResultEN objTabCheckResultEN = clsTabCheckResultBL.GetObjBymId(lngMid);
            if (objTabCheckResultEN == null)
            {
                clsCommonJsFunc.Alert(this, "û��ѡ����ؼ�¼��");
                return;
            }
            string strCurrPageName = "";
            switch (strPageName)
            {
                case "CheckConsistency":
                    strCurrPageName = string.Format("{0}|{1}", conCurrPageName, vsParentPage);

                    clsPubFun4Web.CheckConsistency(this, objTabCheckResultEN.TabId, strCurrPageName);
                    break;
                case "EditTabAndObjectFields":
                    strCurrPageName = string.Format("{0}|{1}", conCurrPageName, vsParentPage);

                    if (string.IsNullOrEmpty(objTabCheckResultEN.TabId) == false)
                    {
                        clsPubFun4Web.JumpToEditTabAndFields(this, objTabCheckResultEN.TabId, strCurrPageName);
                    }
                    else
                    {
                        lblMsgList.Text = "�ô���û�����AGC��������ѡ���¼��";
                        clsCommonJsFunc.Alert(this, "�ô���û�����AGC��������ѡ���¼��");
                    }

                    break;
                default:
                    clsCommonJsFunc.Alert(this, string.Format("��ҳ�����ƣ�[{0}]��({1})��û�д���", qsParentPage, clsStackTrace.GetCurrClassFunction()));
                    break;
            }
        }
        #endregion ����ҳ����Ϣ
    }
}