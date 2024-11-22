

using AGC.BusinessLogic;using AGC.FunClass;
using AGC.BusinessLogicEx;
using AGC.Entity;
using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.datetime;
using CommFunc4WebForm;


using System;
using System.Collections.Generic;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace AGC.Webform
{
    /// <summary>
    /// wfmProjects_QUDI ��ժҪ˵��������Q�����ѯ��U�����޸�
    /// </summary>
    public partial class wfmProjects_QUDI : CommWebPageBase
    {

        //�����йصı����������
        /// <summary>
        /// ��ǰ�����Ľ��湦������
        /// </summary>
        protected string vsViewName
        {
            get
            {
                string sViewName;
                sViewName = (string)ViewState["ViewName"];
                if (sViewName == null)
                {
                    sViewName = "";
                }
                return sViewName;
            }
            set
            {
                string sViewName = value;
                ViewState.Add("ViewName", sViewName);
            }
        }
        /// <summary>
        /// ��ǰ�����ĵ���������
        /// </summary>
        protected string vsTabName
        {
            get
            {
                string sTabName;
                sTabName = (string)ViewState["TabName"];
                if (sTabName == null)
                {
                    sTabName = "";
                }
                return sTabName;
            }
            set
            {
                string sTabName = value;
                ViewState.Add("TabName", sTabName);
            }
        }

        //�����йصı����������
        protected const string ViewId4Potence = "00260203";		//������
        //��������洫����ObjId(����ID)

        /// <summary>
        /// ��ǰ��Ҫ�����Ĺ���Id
        /// </summary>
        private string qsPrjId
        {
            get
            {
                string strPrjId = Request.QueryString["PrjId"] ?? "".ToString();
                if ((strPrjId != null) && (strPrjId != ""))
                {
                    return strPrjId;//Request.QueryString["id"] ?? "";
                }
                else
                {
                    return "";
                }
            }
        }

        /// <summary>
        /// ����
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
                vsViewName = "���̱�ά��";
                vsTabName = "vProjects";
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
                wucProjects1.SetDdl_DataBaseTypeId();
                wucProjects1.SetDdl_ApplicationTypeId();
                wucProjects1.SetDdl_SoftStructureId();
          
                wucProjects1.SetDdl_UseStateId();

                clsUseStateBL.BindDdl_UseStateId(ddlUseStateId);
                ddlUseStateId.SelectedValue = "0001";
                strSortProjectsBy = "PrjId Asc";
                if (qsOperator == "SelectDataBase")
                {
                    DispEditProjectsRegion();
                    wucProjects1.SetDdl_PrjDataBaseId(clsPubVar.CurrSelPrjId);
                    UpdateProjectsRecord(clsPubVar.CurrSelPrjId);
                    tabQuery.Visible = false;
                    wucProjects1.SetState4SelectDataBase();
                }
                else
                {
                    wucProjects1.SetDdl_PrjDataBaseId();
                    //2����ʾ�������ı�������DATAGRID��
                    BindGv_Projects();
                    DispProjectsListRegion();
                }
                //3�����ñ�ؼ����ֿؼ���ReadOnly���ԣ�
                //   ʹֻ֮������Ϊ���޸Ĺ����йؼ����ǲ��ܱ��޸ĵġ�
                wucProjects1.SetKeyReadOnly(true);
           
            }
        }
        protected override void OnPreRender(EventArgs e)
        {
            this.Page.RegisterRequiresViewStateEncryption();
            base.OnPreRender(e);
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
            this.gvProjects.PageIndex = 0;
            //�ѱ��¼��������ʾ��DATAGRID��
            BindGv_Projects();
        }
        /// <summary>
        /// �������ܣ��¼��������ڸ���DATAGRID�ĵ�ǰҳ����ʱ�����ĺ�����
        ///			  ���幦����������ʾ��ҳ(������ҳ����)�����ݡ�
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void gvProjects_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            //�������裺����2����
            //1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
            //2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ

            //1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
            this.gvProjects.PageIndex = e.NewPageIndex;
            //2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ
            BindGv_Projects();
        }
        /// <summary>
        /// �������ܣ����Ըùؼ��ֵļ�¼������ʾ�ڽ����ϣ�
        ///������     �������ǰ�ֵ������ؼ���
        /// </summary>
        /// <param name="strPrjId">���¼�Ĺؼ��֣���ʾ�ñ�ؼ��ֵ�����</param>
        /// <summary>
        /// �������ܣ��¼�������������<ȷ���޸�>ʱ�������¼�������
        ///           ���幦��Ϊ�ѽ�������ͬ�����ݿ��У��ѽ������ݱ��浽���ݿ���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOKUpd_Click(object sender, System.EventArgs e)
        {
            string strCommandText;
            clsProjectsEN objProjects;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "���":
                    AddProjectsRecord();
                    break;
                case "ȷ�����":
                    //����һ������Ĳ���Ĵ��룬�����߼���̫�򵥣�
                    //�Ͱ��߼���ϲ������Ʋ�,
                    AddProjectsRecordSave();
                    break;
                case "ȷ���޸�":
                    //����һ��������޸ĵĴ��룬�����߼���̫�򵥣�
                    //�Ͱ��߼���ϲ������Ʋ�,
                    objProjects = (clsProjectsEN)Session["objProjects"];
                    UpdateProjectsRecordSave(objProjects);
                    break;
            }
        }

        ///����ר������BINDgv�е���ҳ��ش���
        //��ǰ��¼��
        protected void btnAddNewRec4Gv_Click(object sender, System.EventArgs e)
        {
            wucProjects1.SetKeyReadOnly(false);
            btnOKUpd.Text = "ȷ�����";
            lblMsgEdit.Text = "";
            wucProjects1.PrjId = clsProjectsBL.GetMaxStrId_S();
            wucProjects1.UseStateId = "0001";
            DispEditProjectsRegion();
        }

        //����ר�����ڵ���Excel����ش���
        protected void btnExportExcel4Gv_Click(object sender, System.EventArgs e)
        {
            //����Excel����
            ExportExcel();
        }

        ///����ר������BINDgv�е���ҳ��ش���
        //��ǰ��¼��
        protected void btnDelete4Gv_Click(object sender, System.EventArgs e)
        {
            List<string> arrPrjId = clsCommForWebForm.GetAllCheckedItemFromGv(gvProjects, "chkCheckRec");
            if (arrPrjId == null || arrPrjId.Count == 0)
            {
                lblMsgList.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
                return;
            }
            lblMsgList.Text = "";
            try
            {
                foreach (string strPrjId in arrPrjId)
                {

                    clsProjectsBLEx.p_Del_Projects(strPrjId);
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_Projects();
        }

        ///����ר������BINDgv�е���ҳ��ش���
        //��ǰ��¼��
        protected void btnUpdate4Gv_Click(object sender, System.EventArgs e)
        {
            string strPrjId = clsCommForWebForm.GetFirstCheckedItemFromGv(gvProjects);
            if (strPrjId == null || strPrjId.Trim().Length == 0)
            {
                lblMsgList.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
                return;
            }
            lblMsgList.Text = "";
            //1����ʾ�ùؼ��ֵ��������û��޸ĸùؼ��ּ�¼��
            UpdateProjectsRecord(strPrjId);
        }
        
        protected void gvProjects_Sorting(object sender, GridViewSortEventArgs e)
        {
            int intIndex;
            //�ж��Ƿ����µ������ֶ�
            intIndex = strSortProjectsBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                strSortProjectsBy = e.SortExpression + " Asc";
                BindGv_Projects();
                return;
            }
            //���ԭ��������
            intIndex = strSortProjectsBy.IndexOf(" Asc");
            if (intIndex == -1)		//���ԭ���������������Ϊ����
            {
                strSortProjectsBy = e.SortExpression + " Asc";
            }
            else			///��������Ϊ����
            {
                strSortProjectsBy = e.SortExpression + " Desc";
            }
            BindGv_Projects();
        }

        /// <summary>
        /// ���ڼ�¼GridView�еĵ�ǰ������ʽ���Ա������һ�������򣬻��ǽ�������
        /// </summary>
        protected string strSortProjectsBy
        {
            get
            {
                string sSortProjectsBy;
                sSortProjectsBy = (string)ViewState["SortProjectsBy"];
                if (sSortProjectsBy == null)
                {
                    sSortProjectsBy = "";
                }
                return sSortProjectsBy;
            }
            set
            {
                string sSortProjectsBy = value;
                ViewState.Add("SortProjectsBy", sSortProjectsBy);
            }
        }

        ///��������ҳ����غ���
        protected void btnJumpPage_Click(object sender, EventArgs e)
        {
            GridViewRow pagerRow = gvProjects.BottomPagerRow;
            TextBox txtJump2Page = (TextBox)pagerRow.FindControl("txtJump2Page");
            if (txtJump2Page != null)
            {
                if (txtJump2Page.Text.Trim() != "" &&
                int.Parse(txtJump2Page.Text) > 0 &&
                int.Parse(txtJump2Page.Text) - 1 < this.gvProjects.PageCount)
                {
                    this.gvProjects.PageIndex = int.Parse(txtJump2Page.Text) - 1;
                }
                this.BindGv_Projects();
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
                    PageSize = intPageSize.ToString();
                    BindGv_Projects();
                }
            }
        }

        ///����GridView��������¼�����
        protected void gvProjects_RowCommand(object sender, GridViewCommandEventArgs e)
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
                        clsCommForWebForm.Set_GridViewAllChecked(gvProjects, true);
                        lbSelAll.Text = "��ѡ";
                    }
                    else if (lbSelAll.Text == "��ѡ")
                    {
                        clsCommForWebForm.Set_GridViewAllChecked(gvProjects, false);
                        lbSelAll.Text = "ȫѡ";
                    }
                    break;
            }
        }
        ///ɾ����¼���̴���for C#
        protected void gvProjects_RowCreated(object sender, GridViewRowEventArgs e)
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
            if (strSortProjectsBy == "") return;
            if (e.Row.RowType == DataControlRowType.Header)//����ؼ��Ƿ�Ϊҳü��
            {
                string strSortEx;
                for (int i = 0; i < this.gvProjects.Columns.Count; i++)
                {
                    strSortEx = this.gvProjects.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = strSortProjectsBy.IndexOf(strSortEx + " ");
                    if (intIndex >= 0)  //��ͼ״̬��������ʽ�Ƿ�Ϊ���е��ֶΣ�
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//�������壬��"webdings"��5�������ǣ�6�������ǣ�
                        intIndex = strSortProjectsBy.IndexOf("Asc");
                        lblSort.Text = (intIndex > 0 ? " 5" : " 6");//�Ƿ�Ϊ���򣬶���Ϊstring�ͣ�
                        e.Row.Cells[i].Controls.Add(lblSort);//��������ĵ�i����Ԫ��������һ�ؼ���
                        break;
                    }
                }
            }
        }

        ///
        protected void gvProjects_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string strPrjId = gvProjects.DataKeys[e.RowIndex].Value.ToString();
            DeleteProjectsRecord(strPrjId);
        }
        ///
        protected void gvProjects_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string strPrjId = gvProjects.DataKeys[e.RowIndex].Value.ToString();
            UpdateProjectsRecord(strPrjId);
        }
        ///ɾ����¼���̴���for C#
        protected void gvProjects_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            if (e.NewPageIndex != -1)
            {
                gvProjects.PageIndex = e.NewPageIndex;
                this.BindGv_Projects();
            }
        }
        ///
        protected void btnCancelProjectsEdit_Click(object sender, EventArgs e)
        {
            if (qsOperator == "SelectDataBase")
            {
                Response.Redirect("../wfmPortal.aspx");
            }
            DispProjectsListRegion();
        }

        protected void btnTestConnect_Click(object sender, EventArgs e)
        {


            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(wucProjects1.IpAddress,
                wucProjects1.PrjDataBaseName,
                wucProjects1.DataBaseUserId,
                wucProjects1.DataBasePwd);
            try
            {
                if (objSQL.TestConnect() == true)
                {
                    string strMsg = "�������ӳɹ�!";
                    clsCommonJsFunc.Alert(this, strMsg);
                    return ;
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
        }

        protected void btnCloneTab_Click(object sender, EventArgs e)
        {
            string strProjectsId = clsCommForWebForm.GetFirstCheckedItemFromGv(gvProjects);
            if (strProjectsId == null || strProjectsId.Trim().Length == 0)
            {
                lblMsgList.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
                return;
            }
            lblMsgList.Text = "";
            //string strNewProjectsId = "";
            try
            {
                clsProjectsEN objProjectsEN_S = new clsProjectsEN(strProjectsId);
                clsProjectsBL.GetProjects(ref objProjectsEN_S);
                clsProjectsEN objProjectsEN_T = new clsProjectsEN();
                clsProjectsBL.CopyTo(objProjectsEN_S, objProjectsEN_T);
                objProjectsEN_T.PrjId = clsProjectsBL.GetMaxStrId_S();
                objProjectsEN_T.PrjName = "Copy_" + objProjectsEN_S.PrjName;
                clsProjectsBL.AddNewRecordBySql2(objProjectsEN_T);
                BindGv_Projects();
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "��¡���ɹ�!\r\n" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
        }

        protected void btnAutoSet_Click(object sender, EventArgs e)
        {
            List<clsProjectsEN> lstProjectsObj = clsProjectsBL.GetObjLst("UseStateId='0001'");
            List<clsPrjDataBaseEN> lstPrjDataBaseObj = clsPrjDataBaseBL.GetObjLst("UseStateId='0001'");
            int intCount = 0;
            foreach (clsProjectsEN objProjectsEN in lstProjectsObj)
            {
                bool bolIsSuccess = false;
                //string strPrjDataBaseId = "";
                foreach (clsPrjDataBaseEN objPrjDataBaseEN in lstPrjDataBaseObj)
                {
                    //if (objProjectsEN.PrjDataBaseName == objPrjDataBaseEN.DataBaseName
                    //    && objProjectsEN.IpAddress == objPrjDataBaseEN.IpAddress
                    //    && objProjectsEN.DataBaseUserId == objPrjDataBaseEN.DataBaseUserId)
                    //{
                    //    bolIsSuccess = true;
                    //    strPrjDataBaseId = objPrjDataBaseEN.PrjDataBaseId;
                    //    intCount++;
                    //}
                }
                if (bolIsSuccess)
                {
                    //objProjectsEN.PrjDataBaseId = strPrjDataBaseId;
                    objProjectsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                    clsProjectsBL.UpdateBySql2(objProjectsEN);
                }
            }
            clsCommonJsFunc.Alert(this, "������ɣ����ƣ�" + intCount.ToString() + "����Ŀ��");

        }

        protected void btnRefreshBuffer_Click(object sender, EventArgs e)
        {
            //clsPrjDataBaseBL.arrPrjDataBaseObjLst_Cache = null;
            //clsProjectsBL.arrProjectsObjLst_Cache = null;

        }

        protected void btnSetInUse_Click(object sender, EventArgs e)
        {
            List<string> arrPrjId = clsCommForWebForm.GetAllCheckedItemFromGv(gvProjects, "chkCheckRec");
            if (arrPrjId == null || arrPrjId.Count == 0)
            {
                lblMsgList.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
                return;
            }
            lblMsgList.Text = "";
            try
            {
                foreach (string strPrjId in arrPrjId)
                {
                    clsProjectsBLEx.SetInUse(strPrjId);
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_Projects();
        }

        protected void btnSetNotInUse_Click(object sender, EventArgs e)
        {
            List<string> arrPrjId = clsCommForWebForm.GetAllCheckedItemFromGv(gvProjects, "chkCheckRec");
            if (arrPrjId == null || arrPrjId.Count == 0)
            {
                lblMsgList.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
                return;
            }
            lblMsgList.Text = "";
            try
            {
                foreach (string strPrjId in arrPrjId)
                {
                    clsProjectsBLEx.SetNotInUse(strPrjId);
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_Projects();
        }
    }
    public partial class wfmProjects_QUDI : CommWebPageBase
    {
        protected void ShowData(string strPrjId)
        {
            //�������裺
            //1�����ؼ����Ƿ�Ϊ�գ�
            //2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
            //3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
            //4����ȡ�������������ԣ�
            //5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���

            //1�����ؼ����Ƿ�Ϊ�գ�
            if (strPrjId == "") return;		//����ؼ���Ϊ�վͷ����˳�
            //2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
            if (clsProjectsBL.IsExist(strPrjId) == false)		//���ùؼ��ֵļ�¼�Ƿ����
            {
                string ss = "�ؼ���Ϊ��" + strPrjId + "�Ĳ�����!";
                clsCommonJsFunc.Alert(this, ss);
                return;
            }
            //3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
            clsProjectsEN objProjects = null;// new clsProjectsEN(strPrjId);
            //4����ȡ�������������ԣ�
            try
            {
                objProjects = clsProjectsBL.GetObjByPrjId(strPrjId);
                if (objProjects == null)
                {
                    clsCommonJsFunc.Alert(this, string.Format("���ݹ���Id:{0}����ȡ�Ķ���Ϊ�ա�", strPrjId));
                    return;
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
                //clsPubFun4Web.AccessError(this, conCurrPageName);
            }

            Session.Add("objProjects", objProjects);
            //5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���
            GetDataFromProjectsClass(objProjects);
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


        ///����ר������BINDgv�е���ҳ��ش���


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


        //���ɴ�����Ϣ��Session����
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
        protected string CombineProjectsCondition()
        {
            //ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
            //���� 1=1 && UserName = '����'
            string strWhereCond = " 1=1 ";
            //����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
            if (this.txtPrjNameq.Text.Trim() != "")
            {
                strWhereCond += " And PrjName like '%" + this.txtPrjNameq.Text.Trim() + "%'";
            }
            if (this.txtPrjDomainq.Text.Trim() != "")
            {
                strWhereCond += " And PrjDomain like '%" + this.txtPrjDomainq.Text.Trim() + "%'";
            }
         
           
            if (this.ddlUseStateId.SelectedValue != "" && this.ddlUseStateId.SelectedValue != "0")
            {
                strWhereCond += " And UseStateId='" + this.ddlUseStateId.SelectedValue + "'";
            }
            return strWhereCond;
        }
        ///���ɰ�GridView�Ĵ���
        /// <summary>
        /// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
        ///			 ����ʾ��GridView�С�
        /// </summary>
        protected void BindGv_Projects()
        {
            //�������裺(��5��)
            //	1����Ͻ�����������
            //	2��������������ȡ�ñ�����������DataTable��
            //	4������GridView������Դ(DataSource)��
            //	5����GridView������DataTable��������ʾ��DATAGRID��
            //	6�����ü�¼����״̬��
            //		�ڱ��������ǰ�״̬��ʾ�ڿؼ�txtRecCount�С�

            //	1����Ͻ�����������
            string strWhereCond = CombineProjectsCondition();
            //	2��������������ȡ�ñ�����������DataTable��
            System.Data.DataTable objDT = null;
            try
            {
                objDT = clsvProjectsBL.GetDataTable(strWhereCond);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "��ȡ���ݱ�(DataTable)���ɹ�!" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            //	4������GRIDView������Դ(DataSource)��
            DataView objDV = objDT.DefaultView;
            objDV.Sort = strSortProjectsBy;     ///ע����һ�д����п�����Ҫע�͵���Ŀǰ���н����ڵ����Ĳ�ѯ������������
            ///����GridView��ÿҳ�ļ�¼��
            if (string.IsNullOrEmpty(PageSize) == false)
            {
                int intPageSize = int.Parse(PageSize);
                gvProjects.PageSize = intPageSize;
            }
            else
            {
                PageSize = "10";
                gvProjects.PageSize = 10;
            }
            this.gvProjects.DataSource = objDV;
            //	5����DATAGRID������DataTable��������ʾ��DATAGRID��
            this.gvProjects.DataBind();

            ///����ר������BindGv�е���ҳ��ش���
            GridViewRow pagerRow = gvProjects.BottomPagerRow;
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
                lblAllPages.Text = this.gvProjects.PageCount.ToString();
                //��ǰҳ����
                lblCurrentPage.Text = (this.gvProjects.PageIndex + 1).ToString();
                //��ǰ����������ҳ����
                txtJump2Page.Text = (this.gvProjects.PageIndex + 1).ToString();
                //�����ǰҳ����Ϊ0����<ǰһҳ>��ť��Ч
                if (this.gvProjects.PageIndex == 0)
                {
                    clsPubFun.SetButtonEnabled(btnPrevPage,  false);
                }
                else
                {
                    clsPubFun.SetButtonEnabled(btnPrevPage, true);
                }
                //�����ǰҳ������Ϊ���һҳ����<ǰһҳ>��ť��Ч
                if (this.gvProjects.PageIndex == this.gvProjects.PageCount - 1)
                {
                     clsPubFun.SetButtonEnabled(btnNextPage, false);
                }
                else
                {
                    clsPubFun.SetButtonEnabled(btnNextPage, true);
                }
                //���÷�ҳ����ÿҳ��¼�����������ֵ
                if (string.IsNullOrEmpty(PageSize) == false)
                {
                    ddlPagerRecCount.Text = PageSize;
                }
                else
                {
                    PageSize = "10";
                    ddlPagerRecCount.Text = PageSize;
                }
            }
            gvProjects.BottomPagerRow.Visible = true;
        }


        ///���ɴ��߼�������ݴ��䵽�����ĺ�������
        /// <summary>
        /// �������ܣ�������������������ʾ��������
        ///ע�⣺��������������򣬲�����һ��������������ϵ�ģ�����Ϊһ��������ֵ��Ȼ����Ϊ����������ֵ
        ///      ������������ݿ�ʱ����Ӧ��һ���ֶ���ǰ�������ֶ��ں�
        /// </summary>
        /// <param name="pobjProjects">��ʵ�������</param>
        protected void GetDataFromProjectsClass(clsProjectsEN pobjProjects)
        {
            wucProjects1.PrjId = pobjProjects.PrjId;//    ����ID
            wucProjects1.PrjName = pobjProjects.PrjName;//    ��������
            wucProjects1.PrjDomain = pobjProjects.PrjDomain;//    ��/����
            wucProjects1.JavaPackageName = pobjProjects.JavaPackageName;//    Java����
            wucProjects1.IsoPrjName = pobjProjects.IsoPrjName;//    Java����
            //wucProjects1.DataBaseTypeId = pobjProjects.DataBaseTypeId;//    ���ݿ�����ID
            //wucProjects1.IpAddress = pobjProjects.IpAddress;//    ������
            //wucProjects1.PrjDataBaseName = pobjProjects.PrjDataBaseName;//    �����ݿ�
            //wucProjects1.DatabaseOwner = pobjProjects.objPrjDataBase.DatabaseOwner;//    ���ݿ�ӵ����
            //wucProjects1.Sid = pobjProjects.Sid;//    Sid
            //wucProjects1.TableSpace = pobjProjects.TableSpace;//    ��ռ�
            //wucProjects1.DataBaseUserId = pobjProjects.DataBaseUserId;//    ���ݿ���û�ID
            //wucProjects1.DataBasePwd = pobjProjects.DataBasePwd;//    ���ݿ���û�����
            //wucProjects1.ApplicationTypeId = pobjProjects.ApplicationTypeId;//    �޸�����
            //wucProjects1.SoftStructureId = pobjProjects.SoftStructureId;//    �û�ID
            string strPrjDataBaseId_CurrUserId = clsUserDefaPrjDataBaseBLEx.GetPrjDataBaseIdByPrjIdAndUserId(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            if (string.IsNullOrEmpty(strPrjDataBaseId_CurrUserId) == true)
            {
                //wucProjects1.PrjDataBaseId = pobjProjects.PrjDataBaseId;//    �û�ID
            }
            else
            {
                wucProjects1.PrjDataBaseId = strPrjDataBaseId_CurrUserId;
            }
            //wucProjects1.VirtualDirectory = pobjProjects.VirtualDirectory;//    ����Ŀ¼
            //wucProjects1.PrjRootDirectory = pobjProjects.PrjRootDirectory;//    ���̸�Ŀ¼
            wucProjects1.Memo = pobjProjects.Memo;//    ˵��
            wucProjects1.IsRelaDataBase = pobjProjects.IsRelaDataBase;//    �Ƿ���������ݿ�
            wucProjects1.UseStateId = pobjProjects.UseStateId;//    ʹ��״̬
            wucProjects1.IsSupportMvc = pobjProjects.IsSupportMvc;//    �Ƿ�֧��Mvc           

        }

        /// <summary>
        /// �������ܣ��ѽ����ϵ��������ݴ����������
        /// </summary>
        /// <param name="pobjProjects">���ݴ����Ŀ�������</param>
        protected void PutDataToProjectsClass(clsProjectsEN pobjProjects)
        {
            pobjProjects.PrjId = wucProjects1.PrjId;//    ����ID
            pobjProjects.PrjName = wucProjects1.PrjName;//    ��������
            pobjProjects.PrjDomain = wucProjects1.PrjDomain;//    ��/����
            pobjProjects.JavaPackageName = wucProjects1.JavaPackageName;//    Java����
            pobjProjects.IsoPrjName = wucProjects1.IsoPrjName;//    Java����
            //pobjProjects.DataBaseTypeId = wucProjects1.DataBaseTypeId;//    ���ݿ�����ID
            //pobjProjects.IpAddress = wucProjects1.IpAddress;//    ������
            //pobjProjects.PrjDataBaseName = wucProjects1.PrjDataBaseName;//    �����ݿ�
            //pobjProjects.DatabaseOwner = wucProjects1.DatabaseOwner;//    ���ݿ�ӵ����
            //pobjProjects.Sid = wucProjects1.Sid;//    Sid
            //pobjProjects.TableSpace = wucProjects1.TableSpace;//    ��ռ�
            //pobjProjects.DataBaseUserId = wucProjects1.DataBaseUserId;//    ���ݿ���û�ID
            //pobjProjects.DataBasePwd = wucProjects1.DataBasePwd;//    ���ݿ���û�����
            pobjProjects.UpdDate = clsDateTime.getTodayStr(0);//    �޸�����
            pobjProjects.UserId =clsCommonSession.UserId;//    �û�ID
            //pobjProjects.ApplicationTypeId = wucProjects1.ApplicationTypeId;//    ˵��
            //pobjProjects.SoftStructureId = wucProjects1.SoftStructureId;//    ˵��
            //pobjProjects.PrjDataBaseId = wucProjects1.PrjDataBaseId;//    ˵��
            pobjProjects.Memo = wucProjects1.Memo;//    ˵��
            //pobjProjects.VirtualDirectory = wucProjects1.VirtualDirectory;//    ����Ŀ¼
            //pobjProjects.PrjRootDirectory = wucProjects1.PrjRootDirectory;//    ���̸�Ŀ¼
            pobjProjects.IsRelaDataBase = wucProjects1.IsRelaDataBase;//    �Ƿ���������ݿ�           
            pobjProjects.IsSupportMvc = wucProjects1.IsSupportMvc;//    �Ƿ�֧��Mvc           
            pobjProjects.UseStateId = wucProjects1.UseStateId;//    �Ƿ���������ݿ�
        }

        
        public System.Data.DataTable GetDataBaseTypeId()
        {
            //��ȡĳѧԺ����רҵ��Ϣ
            string strSQL = "select DataBaseTypeId, DataBaseTypeName from DataBaseType ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindDdl_DataBaseTypeId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //Ϊ����Դ�ڱ����������������
            ListItem li = new ListItem("��ѡ��...", "0");
            System.Data.DataTable objDT = GetDataBaseTypeId();
            objDDL.DataValueField = "DataBaseTypeId";
            objDDL.DataTextField = "DataBaseTypeName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        ///���ɵĲ����¼׼�����̴���for C#
        protected void AddProjectsRecord()
        {
            wucProjects1.SetKeyReadOnly(false);
            btnOKUpd.Text = "ȷ�����";
            btnCancelProjectsEdit.Text = "ȡ�����";
            wucProjects1.PrjId = clsProjectsBL.GetMaxStrId_S();
            wucProjects1.UseStateId = "0001";
        }
        ///�����¼���̹��̴���for C#
        protected bool AddProjectsRecordSave()
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
            clsProjectsEN objProjects;
            //1�����ؼ����������������Ƿ���ȷ
            if (!wucProjects1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "�ؼ��������������Ͳ���ȷ����!";
                return false;
            }
            //2��������󲢳�ʼ������
            //clsProjectsEN objProjects;	//�������
            objProjects = new clsProjectsEN(wucProjects1.PrjId);	//��ʼ���¶���
            ///3.1���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
            if (clsProjectsBL.IsExist(objProjects.PrjId))	//�ж��Ƿ�����ͬ�Ĺؼ���
            {
                strMsg = "�ؼ����ֶ�������ͬ��ֵ";
                clsCommonJsFunc.Alert(this, strMsg);
                return false;
            }
            //4����ֵ�ӽ���㴫���߼��������ʵ���
            PutDataToProjectsClass(objProjects);		//�ѽ����ֵ����
            ///3.1���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
            if (objProjects.CheckUniqueness() == false)	//�ж��Ƿ�����ͬ�Ĺؼ���
            {
                strMsg = string.Format("��������{0}������ͬ��ֵ�������»�һ����", wucProjects1.PrjName);
                clsCommonJsFunc.Alert(this, strMsg);
                return false;
            }
          
            //5����鴫��ȥ�Ķ��������Ƿ�Ϸ�
            try
            {
                clsProjectsBL.CheckPropertyNew(objProjects);
                //6��������ʵ�������ݴ��������ݿ���
                clsProjectsBL.AddNewRecordBySql2(objProjects);
                //clsTitleStyleBLEx.CopyTitleStyle(objProjects.PrjId, "0005");
                string strCondition = string.Format("TitleStyleName='������' And PrjId='{0}'", objProjects.PrjId);
                clsTitleStyleEN objTitleStyle =  clsTitleStyleBL.GetFirstObj_S(strCondition);
                if (objTitleStyle != null)
                {
                    objTitleStyle.IsDefault = true;
                    clsTitleStyleBL .UpdateBySql2(objTitleStyle);
                }
                //if (objProjects.ApplicationTypeId == 2)
                //{
                //    clsFuncModule_AgcBLEx.CopyFuncModule("0001", objProjects.PrjId, clsCommonSession.UserId);
                //}
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
            BindGv_Projects();
            DispProjectsListRegion();
            wucProjects1.Clear();		//��տؼ�������
            ///�ָ�<ȷ�����>���<���>
            btnOKUpd.Text = "���";
            btnCancelProjectsEdit.Text = "ȡ���༭";
            return true;
        }
        ///�����¼���̹��̴���for C#
        protected bool AddProjectsRecordSaveV5()
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
            clsProjectsEN objProjects;
            //1�����ؼ����������������Ƿ���ȷ
            if (!wucProjects1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "�ؼ��������������Ͳ���ȷ����!";
                return false;
            }
            //2��������󲢳�ʼ������
            //clsProjectsEN objProjects;	//�������
            objProjects = new clsProjectsEN(wucProjects1.PrjId);	//��ʼ���¶���
            //3���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
            if (clsProjectsBL.IsExist(objProjects.PrjId))	//�ж��Ƿ�����ͬ�Ĺؼ���
            {
                strMsg = "�ؼ����ֶ�������ͬ��ֵ";
                clsCommonJsFunc.Alert(this, strMsg);
                return false;
            }
            //4����ֵ�ӽ���㴫���߼��������ʵ���
            PutDataToProjectsClass(objProjects);		//�ѽ����ֵ����
            //5����鴫��ȥ�Ķ��������Ƿ�Ϸ�
            try
            {
                clsProjectsBL.CheckPropertyNew(objProjects);
                //6��������ʵ�������ݴ��������ݿ���
                clsProjectsBL.AddNewRecordBySql2(objProjects);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "��Ӽ�¼���ɹ�!" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            strMsg = "��Ӽ�¼�ɹ�!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsgEdit.Text = "��Ӽ�¼�ɹ�!";
            //7��������ļ�¼������ʾ��DATAGRID��
            BindGv_Projects();
            DispProjectsListRegion();
            wucProjects1.Clear();		//��տؼ�������
            ///�ָ�<ȷ�����>���<���>
            btnOKUpd.Text = "���";
            btnCancelProjectsEdit.Text = "ȡ���༭";
            return true;
        }
        ///�����޸ļ�¼׼�����̴��� for C#
        protected void UpdateProjectsRecord(string strPrjId)
        {
            //�������裺���ܹ�2����
            //1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
            //2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�

            //1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
            ShowData(strPrjId);
            //2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
            clsPubFun.SetButtonEnabled(btnOKUpd, true);
            wucProjects1.SetKeyReadOnly(true);
            btnOKUpd.Text = "ȷ���޸�";
            btnCancelProjectsEdit.Text = "ȡ���޸�";
            lblMsgEdit.Text = "";
            DispEditProjectsRegion();
        }
        ///�޸Ĵ���׼�����̴��� for C#
        protected bool UpdateProjectsRecordSave(clsProjectsEN objProjects)
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
            if (!wucProjects1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "�ؼ��������������Ͳ���ȷ����!";
                return false;
            }
            //2����ֵ�ӽ���㴫���߼��������ʵ���
            PutDataToProjectsClass(objProjects);		//�ѽ����ֵ����
            if (objProjects.CheckUniqueness() == false)	//�ж��Ƿ�����ͬ�Ĺؼ���
            {
                strMsg = string.Format("��������{0}������ͬ��ֵ�������»�һ����", wucProjects1.PrjName);
                clsCommonJsFunc.Alert(this, strMsg);
                return false;
            }
            ///3.1����鴫��ȥ�Ķ��������Ƿ�Ϸ�
            try
            {
                clsProjectsBL.CheckPropertyNew(objProjects);
                //4��������ʵ�������ݴ��������ݿ���
                clsProjectsBL.UpdateBySql2(objProjects);
                string strPrjDataBaseId_CurrUserId = wucProjects1.PrjDataBaseId;
                clsUserDefaPrjDataBaseBLEx.SetPrjDataBaseIdByPrjIdAndUserId(clsPubVar.CurrSelPrjId, clsCommonSession.UserId, strPrjDataBaseId_CurrUserId);
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

            if (qsOperator == "SelectDataBase")
            {
                Response.Redirect("~/Webform/wfmPortal.aspx");
            }
            else
            {
                lblMsgEdit.Text = "�޸ļ�¼�ɹ�!";
                //5�����޸ĺ��������ʾ��DATAGRID��
                BindGv_Projects();
                DispProjectsListRegion();
                wucProjects1.Clear();//��տؼ��е�����
                //�ָ�<ȷ���޸�>���<���>
                btnOKUpd.Text = "���";
                btnCancelProjectsEdit.Text = "ȡ���༭";
            }
            return true;
        }
        ///�޸Ĵ���׼�����̴��� for C#
        protected bool UpdateProjectsRecordSaveV5(clsProjectsEN objProjects)
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
            if (!wucProjects1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "�ؼ��������������Ͳ���ȷ����!";
                return false;
            }
            //2����ֵ�ӽ���㴫���߼��������ʵ���
            PutDataToProjectsClass(objProjects);		//�ѽ����ֵ����
            ///3.1����鴫��ȥ�Ķ��������Ƿ�Ϸ�
            try
            {
                clsProjectsBL.CheckPropertyNew(objProjects);
                //4��������ʵ�������ݴ��������ݿ���
                clsProjectsBL.UpdateBySql2(objProjects);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "�޸ļ�¼���ɹ�!" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            strMsg = "�޸ļ�¼�ɹ�!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsgEdit.Text = "�޸ļ�¼�ɹ�!";
            //5�����޸ĺ��������ʾ��DATAGRID��
            BindGv_Projects();
            DispProjectsListRegion();
            wucProjects1.Clear();//��տؼ��е�����
            //�ָ�<ȷ���޸�>���<���>
            btnOKUpd.Text = "���";
            btnCancelProjectsEdit.Text = "ȡ���༭";
            return true;
        }
        ///ɾ����¼���̴���for C#
        protected void DeleteProjectsRecord(string strPrjId)
        {
            try
            {
                clsProjectsBL.DelRecord(strPrjId);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_Projects();
        }

        ///����ר�����ڵ���Excel����ش���
        private void ExportExcel()
        {
            //	1����Ͻ�����������
            string strWhereCond = CombineProjectsCondition();
            //	2��������������ȡ�ñ�����������DataTable��
            System.Data.DataTable objDT = null;
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "Projects��Ϣ����.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add("PrjId"); arrCnName.Add("����ID");
            arrColName.Add("PrjName"); arrCnName.Add("��������");
            arrColName.Add("PrjDomain"); arrCnName.Add("��/����");
            //arrColName.Add("IpAddress"); arrCnName.Add("������");
            //arrColName.Add("DataBaseTypeId"); arrCnName.Add("���ݿ�����ID");
            //arrColName.Add("DataBaseTypeName"); arrCnName.Add("���ݿ�������");
            //arrColName.Add("PrjDataBaseName"); arrCnName.Add("�����ݿ�");
            //arrColName.Add("DatabaseOwner"); arrCnName.Add("���ݿ�ӵ����");
            //arrColName.Add("Sid"); arrCnName.Add("Sid");
            //arrColName.Add("TableSpace"); arrCnName.Add("��ռ�");
            //arrColName.Add("DataBaseUserId"); arrCnName.Add("���ݿ���û�ID");
            arrColName.Add("UpdDate"); arrCnName.Add("�޸�����");
            arrColName.Add("UserId"); arrCnName.Add("�û�ID");
            arrColName.Add("Memo"); arrCnName.Add("˵��");
            clsExportExcelSetENEx objExportExcelSetENEx = new clsExportExcelSetENEx();
            objExportExcelSetENEx.ViewName = vsViewName;//��ǰ����
            objExportExcelSetENEx.TabName = vsTabName;//����Excel���õı������ͼ
            objExportExcelSetENEx.ExportFileName = strFileName;//����Excel���ļ���
            objExportExcelSetENEx.UserId = clsCommonSession.UserId;//��ǰ�û�Id
            objExportExcelSetENEx.UpdUserId = clsCommonSession.UserId;
            objExportExcelSetENEx.UpdDate = clsDateTime.getTodayStr(0);//��ǰ����
            objExportExcelSetENEx.strPrjId = clsPubVar.strCurrPrjId4Agc;//��ǰ���������ɴ���ϵͳ�����õĹ���Id��Ϊ�˷����ֶ�����������
            objExportExcelSetENEx.arrCnName = arrCnName;//�����ֶ�����Ҳ��Excel�ļ��еı�����
            objExportExcelSetENEx.arrColName = arrColName;//���ݱ������
            try
            {
                clsExportExcelSetBLEx.GetExportExcelSetInfo(ref objExportExcelSetENEx, new clsTranslateFieldName());
                strFileName = objExportExcelSetENEx.ExportFileName;//����Excel���ļ���
                arrCnName = objExportExcelSetENEx.arrCnName;//�����ֶ�����Ҳ��Excel�ļ��еı�����
                arrColName = objExportExcelSetENEx.arrColName;//���ݱ������
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            strFolderName = clsSysParaEN.TempFileFolder;
            strDownLoadFileName = strFolderName + strFileName;
            //��ʼ����Ҫ������Excel�ļ�,�����Ʊ�׼Excel�ļ���Ϊĸ�棬���Ʋ��ɹ������ܵ���
            if (clsPubVar.InitExcelFile(this, strFolderName, strDownLoadFileName) == false)
            {
                return;
            }
            try
            {
                //	2��������������ȡ�ñ�����������DataTable��
                objDT = clsvProjectsBL.GetDataTable(strWhereCond);
                //�û�Odbc�ķ�ʽ������Excel,��Web����������Ҫ��װExcel,Ŀǰ��Excel2003,���ϣ��2007�����Ի�����һ����䡣
                GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4Odbc(objDT, arrColName, arrCnName, strDownLoadFileName);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            clsCommForWebForm.DownLoadFile(strDownLoadFileName);
        }
        private void DispEditProjectsRegion()
        {
            tabProjectsGridView.Visible = false;
            tabEditProjectsRegion.Visible = true;
        }
        private void DispProjectsListRegion()
        {
            tabProjectsGridView.Visible = true;
            tabEditProjectsRegion.Visible = false;
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
    }
}