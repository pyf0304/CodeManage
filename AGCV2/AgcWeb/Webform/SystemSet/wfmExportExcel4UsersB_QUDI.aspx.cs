
///----------------------
///���ɴ���汾��2012.11.9.1
///�������ڣ�2013/04/04
///�����ߣ����Է�
///�������ƣ������ߵ�
///����ID��0042
///ģ����������ϵͳ����
///ģ��Ӣ������SysManage
///ע�⣺1����Ҫ���ݵײ㣨PubDataBase.dll���İ汾��2012.10.20.1
///       2����Ҫ���������㣨TzPubFunction.dll���İ汾��2012.10.23.1
///========================
///���ɲ�ѯ���޸ģ�ɾ������Ӽ�¼�Ŀ��Ʋ����


using System;
using System.Collections.Generic;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AGC.FunClass;
using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.datetime;
using CommFunc4WebForm;


namespace AGC.Webform
{
    /// <summary>
    /// wfmExportExcel4UsersB_QUDI ��ժҪ˵��������Q�����ѯ��U�����޸�
    /// </summary>
    public partial class wfmExportExcel4UsersB_QUDI : CommWebPageBase
    {
        /// <summary>
        /// ��������汾Id
        /// </summary>
        public string qsId_ExportExcel4Users
        {
            get
            {
                if (Request.QueryString["Id_ExportExcel4Users"] != null)
                {
                    return Request.QueryString["Id_ExportExcel4Users"].ToString().Trim();
                }
                return "";
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
                wucExportExcel4UsersB1.SetDdl_IdExportExcel4Users();
                clsDropDownList.BindDdl_TrueAndFalse(ddlIsExport);
                ddlIsExport.SelectedIndex = 1;
                clsvExportExcelSetBL.BindDdl_IdExportExcel4Users(ddlIdExportExcel4Usersq);
                strSortExportExcel4UsersBy = "OrderNum Asc";

                if (string.IsNullOrEmpty(qsId_ExportExcel4Users) == false)
                {
                    ddlIdExportExcel4Usersq.SelectedValue = qsId_ExportExcel4Users;
                    ddlIdExportExcel4Usersq.Enabled = false;
                    clsExportExcelSetEN objExportExcelSetEN = new clsExportExcelSetEN(qsId_ExportExcel4Users);
                    clsExportExcelSetBL.GetExportExcelSet(ref objExportExcelSetEN);
                    GetDataFromExportExcelSetClass(objExportExcelSetEN);
                    trPrepHidden.Visible = false;
                }
                clsPubFun.SetDgVisibilityByViewName(gvExportExcel4Users, "����Excel�û��ֶ�����");
                //2����ʾ�������ı�������DATAGRID��
                BindGv_ExportExcel4Users();
                //3�����ñ�ؼ����ֿؼ���ReadOnly���ԣ�
                //   ʹֻ֮������Ϊ���޸Ĺ����йؼ����ǲ��ܱ��޸ĵġ�
                DispExportExcel4UsersListRegion();
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
            this.gvExportExcel4Users.PageIndex = 0;
            //�ѱ��¼��������ʾ��DATAGRID��
            BindGv_ExportExcel4Users();
        }
        /// <summary>
        /// �������ܣ��¼��������ڸ���DATAGRID�ĵ�ǰҳ����ʱ�����ĺ�����
        ///			  ���幦����������ʾ��ҳ(������ҳ����)�����ݡ�
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void gvExportExcel4Users_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            //�������裺����2����
            //1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
            //2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ

            //1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
            this.gvExportExcel4Users.PageIndex = e.NewPageIndex;
            //2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ
            BindGv_ExportExcel4Users();
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
            clsExportExcel4UsersEN objExportExcel4UsersEN;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "���":
                    AddExportExcel4UsersRecord();
                    break;
                case "ȷ�����":
                    //����һ������Ĳ���Ĵ��룬�����߼���̫�򵥣�
                    //�Ͱ��߼���ϲ������Ʋ�,
                    AddExportExcel4UsersRecordSave();
                    break;
                case "ȷ���޸�":
                    //����һ��������޸ĵĴ��룬�����߼���̫�򵥣�
                    //�Ͱ��߼���ϲ������Ʋ�,
                    objExportExcel4UsersEN = (clsExportExcel4UsersEN)Session["objExportExcel4UsersEN"];
                    UpdateExportExcel4UsersRecordSave(objExportExcel4UsersEN);
                    break;
            }
        }

        ///����¼�¼���¼����̣������ڸù����е���������������Ҫ��������Ӷ��д��롣
        protected void btnAddNewRec4Gv_Click(object sender, System.EventArgs e)
        {
            AddExportExcel4UsersRecord();
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
            List<string> lstKeyValues = clsCommForWebForm.GetAllCheckedItemFromGv(gvExportExcel4Users, "chkCheckRec", "mId");
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
                    clsExportExcel4UsersBL.DelRecord(lngmId);
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_ExportExcel4Users();
        }

        /// <summary>
        ///�޸ĵ�ǰ��ѡ��¼
        /// </summary>
        protected void btnUpdate4Gv_Click(object sender, System.EventArgs e)
        {
            List<string> lstKeyValue = clsCommForWebForm.GetFirstCheckedItemFromGv(gvExportExcel4Users, "mId");
            if (lstKeyValue.Count == 0)
            {
                lblMsgList.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
                return;
            }
            lblMsgList.Text = "";
            //1����ʾ�ùؼ��ֵ��������û��޸ĸùؼ��ּ�¼��
            string[] strKeys = lstKeyValue[0].Split(',');
            long lngmId = long.Parse(strKeys[0]);
            UpdateExportExcel4UsersRecord(lngmId);
        }
        protected void gvExportExcel4Users_Sorting(object sender, GridViewSortEventArgs e)
        {
            int intIndex;
            //�ж��Ƿ����µ������ֶ�
            intIndex = strSortExportExcel4UsersBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                strSortExportExcel4UsersBy = e.SortExpression + " Asc";
                BindGv_ExportExcel4Users();
                return;
            }
            //���ԭ��������
            intIndex = strSortExportExcel4UsersBy.IndexOf(" Asc");
            if (intIndex == -1)		//���ԭ���������������Ϊ����
            {
                strSortExportExcel4UsersBy = e.SortExpression + " Asc";
            }
            else			///��������Ϊ����
            {
                strSortExportExcel4UsersBy = e.SortExpression + " Desc";
            }
            BindGv_ExportExcel4Users();
        }

        /// <summary>
        /// ���ڼ�¼GridView�еĵ�ǰ������ʽ���Ա������һ�������򣬻��ǽ�������
        /// </summary>
        protected string strSortExportExcel4UsersBy
        {
            get
            {
                string sSortExportExcel4UsersBy;
                sSortExportExcel4UsersBy = (string)ViewState["SortExportExcel4UsersBy"];
                if (sSortExportExcel4UsersBy == null)
                {
                    sSortExportExcel4UsersBy = "";
                }
                return sSortExportExcel4UsersBy;
            }
            set
            {
                string sSortExportExcel4UsersBy = value;
                ViewState.Add("SortExportExcel4UsersBy", sSortExportExcel4UsersBy);
            }
        }

        ///��������ҳ����غ���
        protected void btnJumpPage_Click(object sender, EventArgs e)
        {
            GridViewRow pagerRow = gvExportExcel4Users.BottomPagerRow;
            TextBox txtJump2Page = (TextBox)pagerRow.FindControl("txtJump2Page");
            if (txtJump2Page != null)
            {
                if (txtJump2Page.Text.Trim() != "" &&
                int.Parse(txtJump2Page.Text) > 0 &&
                int.Parse(txtJump2Page.Text) - 1 < this.gvExportExcel4Users.PageCount)
                {
                    this.gvExportExcel4Users.PageIndex = int.Parse(txtJump2Page.Text) - 1;
                }
                this.BindGv_ExportExcel4Users();
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
                    BindGv_ExportExcel4Users();
                }
            }
        }

        ///����GridView��������¼�����
        protected void gvExportExcel4Users_RowCommand(object sender, GridViewCommandEventArgs e)
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
                        clsCommForWebForm.Set_GridViewAllChecked(gvExportExcel4Users, true);
                        lbSelAll.Text = "��ѡ";
                    }
                    else if (lbSelAll.Text == "��ѡ")
                    {
                        clsCommForWebForm.Set_GridViewAllChecked(gvExportExcel4Users, false);
                        lbSelAll.Text = "ȫѡ";
                    }
                    break;
            }
        }
        ///ɾ����¼���̴���for C#
        protected void gvExportExcel4Users_RowCreated(object sender, GridViewRowEventArgs e)
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
            if (strSortExportExcel4UsersBy == "") return;
            if (e.Row.RowType == DataControlRowType.Header)//����ؼ��Ƿ�Ϊҳü��
            {
                string strSortEx;
                for (int i = 0; i < this.gvExportExcel4Users.Columns.Count; i++)
                {
                    strSortEx = this.gvExportExcel4Users.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = strSortExportExcel4UsersBy.IndexOf(strSortEx + " ");
                    if (intIndex >= 0)  //��ͼ״̬��������ʽ�Ƿ�Ϊ���е��ֶΣ�
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//�������壬��"webdings"��5�������ǣ�6�������ǣ�
                        intIndex = strSortExportExcel4UsersBy.IndexOf("Asc");
                        lblSort.Text = (intIndex > 0 ? " 5" : " 6");//�Ƿ�Ϊ���򣬶���Ϊstring�ͣ�
                        e.Row.Cells[i].Controls.Add(lblSort);//��������ĵ�i����Ԫ��������һ�ؼ���
                        break;
                    }
                }
            }
        }

        ///
        protected void gvExportExcel4Users_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string strmId = gvExportExcel4Users.DataKeys[e.RowIndex]["mId"].ToString();
            long lngmId = long.Parse(strmId);
            DeleteExportExcel4UsersRecord(lngmId);
        }
        ///
        protected void gvExportExcel4Users_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string strmId = gvExportExcel4Users.DataKeys[e.RowIndex]["mId"].ToString();
            long lngmId = long.Parse(strmId);
            UpdateExportExcel4UsersRecord(lngmId);
        }
        ///ɾ����¼���̴���for C#
        protected void gvExportExcel4Users_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            if (e.NewPageIndex != -1)
            {
                gvExportExcel4Users.PageIndex = e.NewPageIndex;
                this.BindGv_ExportExcel4Users();
            }
        }
        ///
        protected void btnCancelExportExcel4UsersEdit_Click(object sender, EventArgs e)
        {
            DispExportExcel4UsersListRegion();
        }

        protected void btnOK4ExcelFileName_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(wucExportExcelSetB_Sim1.ExportFileName) == true) return;
            clsExportExcelSetEN objExportExcelSetEN = new clsExportExcelSetEN();
            objExportExcelSetEN.IdExportExcel4Users = qsId_ExportExcel4Users;
            objExportExcelSetEN.ExportFileName = wucExportExcelSetB_Sim1.ExportFileName.Trim();
            objExportExcelSetEN.UpdUserId = clsCommonSession.UserId;
            objExportExcelSetEN.UpdDate = clsDateTime.getTodayStr(0);
            try
            {
                clsExportExcelSetBL.UpdateBySql2(objExportExcelSetEN);
            }
            catch (Exception objException)
            {
                lblMsgList.Text = objException.Message;
            }
        }

        protected void btnChangeExportStatus_Click(object sender, EventArgs e)
        {
            List<string> lstKeyValues = clsCommForWebForm.GetAllCheckedItemFromGv(gvExportExcel4Users, "chkCheckRec", "mId");
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
                    clsExportExcel4UsersBLEx.ChangeExportStatus(lngmId, clsCommonSession.UserId);
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_ExportExcel4Users();
        }

        protected void btnSynchFieldWithTab_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(qsId_ExportExcel4Users) == false)
            {
                if (string.IsNullOrEmpty(clsPubVar.strCurrPrjId4Agc) == true)
                {
                    string strMsg = string.Format("û���ṩһ�������ɴ����еĹ���Id��");
                    lblMsgList.Text = strMsg;
                }
                clsExportExcelSetBLEx.CheckAndSynchDataColumn(qsId_ExportExcel4Users, clsPubVar.strCurrPrjId4Agc, clsCommonSession.UserId, new clsTranslateFieldName());
                BindGv_ExportExcel4Users();
            }
        }

        protected void btnSynchFieldWithDefaultUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(qsId_ExportExcel4Users) == false)
            {
                try
                {
                    clsExportExcelSetBLEx.CopyExportExcelField4UsersFromDefaultUser(qsId_ExportExcel4Users);
                }
                catch (Exception objException)
                {
                    clsCommonSession.seErrMessage = objException.Message;
                    clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                    clsPubFun4Web.AccessError(this, conCurrPageName);
                }
                BindGv_ExportExcel4Users();
            }
        }

    }
    public partial class wfmExportExcel4UsersB_QUDI : CommWebPageBase
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
            if (clsExportExcel4UsersBL.IsExist(lngmId) == false)		//���ùؼ��ֵļ�¼�Ƿ����
            {
                string ss = "�ؼ���Ϊ��" + lngmId + "�Ĳ�����!";
                clsCommonJsFunc.Alert(this, ss);
                return;
            }
            //3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
            clsExportExcel4UsersEN objExportExcel4UsersEN = new clsExportExcel4UsersEN(lngmId);
            //4����ȡ�������������ԣ�
            try
            {
                clsExportExcel4UsersBL.GetExportExcel4Users(ref objExportExcel4UsersEN);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            Session.Add("objExportExcel4UsersEN", objExportExcel4UsersEN);
            //5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���
            GetDataFromExportExcel4UsersClass(objExportExcel4UsersEN);
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
        protected string CombineExportExcel4UsersCondition()
        {
            //ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
            //���� 1=1 && UserName = '����'
            string strWhereCond = " 1=1 ";
            //����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
            if (this.ddlIdExportExcel4Usersq.SelectedValue != "" && this.ddlIdExportExcel4Usersq.SelectedValue != "0")
            {
                strWhereCond += " And IdExportExcel4Users='" + this.ddlIdExportExcel4Usersq.SelectedValue + "'";
            }
            if (this.txtUserIDq.Text.Trim() != "")
            {
                strWhereCond += " And UserID like '%" + this.txtUserIDq.Text.Trim() + "%'";
            }
            if (this.txtUserNameq.Text.Trim() != "")
            {
                strWhereCond += " And UserName like '%" + this.txtUserNameq.Text.Trim() + "%'";
            }
            if (this.txtFieldNameq.Text.Trim() != "")
            {
                strWhereCond += " And FieldName like '%" + this.txtFieldNameq.Text.Trim() + "%'";
            }
            if (this.txtFieldCnNameq.Text.Trim() != "")
            {
                strWhereCond += " And FieldCnName like '%" + this.txtFieldCnNameq.Text.Trim() + "%'";
            }

            if (this.ddlIsExport.SelectedValue == "��")
            {
                strWhereCond += " and IsExport='1'";
            }
            else if (this.ddlIsExport.SelectedValue == "��")
            {
                strWhereCond += " and IsExport='0'";
            }
            return strWhereCond;
        }
        ///���ɰ�GridView�Ĵ���
        /// <summary>
        /// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
        ///			 ����ʾ��GridView�С�
        /// </summary>
        protected void BindGv_ExportExcel4Users()
        {
            //�������裺(��5��)
            //	1����Ͻ�����������
            //	2��������������ȡ�ñ�����������DataTable��
            //	4������GridView������Դ(DataSource)��
            //	5����GridView������DataTable��������ʾ��DATAGRID��
            //	6�����ü�¼����״̬��
            //		�ڱ��������ǰ�״̬��ʾ�ڿؼ�txtRecCount�С�

            //	1����Ͻ�����������
            string strWhereCond = CombineExportExcel4UsersCondition();
            //	2��������������ȡ�ñ�����������DataTable��
            System.Data.DataTable objDT = null;
            try
            {
                objDT = clsvExportExcel4UsersBL.GetDataTable(strWhereCond);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "��ȡ���ݱ�(DataTable)���ɹ�!" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            //	4������GRIDView������Դ(DataSource)��
            DataView objDV = objDT.DefaultView;
            objDV.Sort = strSortExportExcel4UsersBy;     ///ע����һ�д����п�����Ҫע�͵���Ŀǰ���н����ڵ����Ĳ�ѯ������������
            ///����GridView��ÿҳ�ļ�¼��
            if (string.IsNullOrEmpty(PageSize) == false)
            {
                int intPageSize = int.Parse(PageSize);
                gvExportExcel4Users.PageSize = intPageSize;
            }
            else
            {
                PageSize = "10";
                gvExportExcel4Users.PageSize = 10;
            }
            this.gvExportExcel4Users.DataSource = objDV;
            //	5����DATAGRID������DataTable��������ʾ��DATAGRID��
            this.gvExportExcel4Users.DataBind();

            ///����ר������BindGv�е���ҳ��ش���
            GridViewRow pagerRow = gvExportExcel4Users.BottomPagerRow;
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
                lblAllPages.Text = this.gvExportExcel4Users.PageCount.ToString();
                //��ǰҳ����
                lblCurrentPage.Text = (this.gvExportExcel4Users.PageIndex + 1).ToString();
                //��ǰ����������ҳ����
                txtJump2Page.Text = (this.gvExportExcel4Users.PageIndex + 1).ToString();
                //�����ǰҳ����Ϊ0����<ǰһҳ>��ť��Ч
                if (this.gvExportExcel4Users.PageIndex == 0)
                {
                    clsPubFun.SetButtonEnabled(btnPrevPage,  false);
                }
                else
                {
                    clsPubFun.SetButtonEnabled(btnPrevPage, true);
                }
                //�����ǰҳ������Ϊ���һҳ����<ǰһҳ>��ť��Ч
                if (this.gvExportExcel4Users.PageIndex == this.gvExportExcel4Users.PageCount - 1)
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
            gvExportExcel4Users.BottomPagerRow.Visible = true;
        }


        ///���ɴ��߼�������ݴ��䵽�����ĺ�������
        /// <summary>
        /// �������ܣ�������������������ʾ��������
        ///ע�⣺��������������򣬲�����һ��������������ϵ�ģ�����Ϊһ��������ֵ��Ȼ����Ϊ����������ֵ
        ///      ������������ݿ�ʱ����Ӧ��һ���ֶ���ǰ�������ֶ��ں�
        /// </summary>
        /// <param name="pobjExportExcel4UsersEN">��ʵ�������</param>
        protected void GetDataFromExportExcel4UsersClass(clsExportExcel4UsersEN pobjExportExcel4UsersEN)
        {
            wucExportExcel4UsersB1.IdExportExcel4Users = pobjExportExcel4UsersEN.IdExportExcel4Users;//    ����Excel�û��ֶ���ˮ��
            wucExportExcel4UsersB1.FieldName = pobjExportExcel4UsersEN.FieldName;//    �ֶ���
            wucExportExcel4UsersB1.FieldCnName = pobjExportExcel4UsersEN.FieldCnName;//    �ֶ���������
            wucExportExcel4UsersB1.IsExport = pobjExportExcel4UsersEN.IsExport;//    �Ƿ񵼳�
            wucExportExcel4UsersB1.OrderNum = pobjExportExcel4UsersEN.OrderNum;//    ���
          
            wucExportExcel4UsersB1.Memo = pobjExportExcel4UsersEN.Memo;//    ��ע
        }
        /// <summary>
        /// �������ܣ��ѽ����ϵ��������ݴ����������
        /// </summary>
        /// <param name="pobjExportExcel4UsersEN">���ݴ����Ŀ�������</param>
        protected void PutDataToExportExcel4UsersClass(clsExportExcel4UsersEN pobjExportExcel4UsersEN)
        {
            pobjExportExcel4UsersEN.IdExportExcel4Users = wucExportExcel4UsersB1.IdExportExcel4Users;//    ����Excel�û��ֶ���ˮ��
            pobjExportExcel4UsersEN.FieldName = wucExportExcel4UsersB1.FieldName;//    �ֶ���
            pobjExportExcel4UsersEN.FieldCnName = wucExportExcel4UsersB1.FieldCnName;//    �ֶ���������
            pobjExportExcel4UsersEN.IsExport = wucExportExcel4UsersB1.IsExport;//    �Ƿ񵼳�
            pobjExportExcel4UsersEN.OrderNum = wucExportExcel4UsersB1.OrderNum;//    ���
            pobjExportExcel4UsersEN.UpdDate = clsDateTime.getTodayStr(0);// wucExportExcel4UsersB1.UpdDate;//    �޸�����
            pobjExportExcel4UsersEN.UpdUserId = clsCommonSession.UserId;// wucExportExcel4UsersB1.UpdUserId;//    �޸��û�Id
            pobjExportExcel4UsersEN.Memo = wucExportExcel4UsersB1.Memo;//    ��ע
        }

        public System.Data.DataTable GetIdExportExcel4Users()
        {
            //��ȡĳѧԺ����רҵ��Ϣ
            string strSQL = "select IdExportExcel4Users, ViewTabName from vExportExcelSet ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindDdl_IdExportExcel4Users(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //Ϊ����Դ�ڱ����������������
            ListItem li = new ListItem("��ѡ��...", "0");
            System.Data.DataTable objDT = GetIdExportExcel4Users();
            objDDL.DataValueField = "IdExportExcel4Users";
            objDDL.DataTextField = "ViewTabName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        ///���ɵĲ����¼׼�����̴���for C#
        protected void AddExportExcel4UsersRecord()
        {
            btnOKUpd.Text = "ȷ�����";
            btnCancelExportExcel4UsersEdit.Text = "ȡ�����";

            DispEditExportExcel4UsersRegion();
        }
        ///�����¼���̹��̴���for C#
        protected bool AddExportExcel4UsersRecordSave()
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
            clsExportExcel4UsersEN objExportExcel4UsersEN;
            //1�����ؼ����������������Ƿ���ȷ
            if (!wucExportExcel4UsersB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "�ؼ��������������Ͳ���ȷ����!";
                return false;
            }
            //2��������󲢳�ʼ������
            //clsExportExcel4UsersEN objExportExcel4UsersEN;	//�������
            objExportExcel4UsersEN = new clsExportExcel4UsersEN();	//��ʼ���¶���
            ///3.1���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
            //4����ֵ�ӽ���㴫���߼��������ʵ���
            PutDataToExportExcel4UsersClass(objExportExcel4UsersEN);		//�ѽ����ֵ����
            //5.1����鴫��ȥ�Ķ��������Ƿ�Ϸ�
            try
            {
                clsExportExcel4UsersBL.CheckPropertyNew(objExportExcel4UsersEN);
                //6��������ʵ�������ݴ��������ݿ���
                clsExportExcel4UsersBL.AddNewRecordBySql2(objExportExcel4UsersEN);
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
            BindGv_ExportExcel4Users();
            DispExportExcel4UsersListRegion();
            wucExportExcel4UsersB1.Clear();		//��տؼ�������
            ///�ָ�<ȷ�����>���<���>
            btnOKUpd.Text = "���";
            btnCancelExportExcel4UsersEdit.Text = "ȡ���༭";
            return true;
        }
        ///�����¼���̹��̴���for C#
        protected bool AddExportExcel4UsersRecordSaveV5()
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
            clsExportExcel4UsersEN objExportExcel4UsersEN;
            //1�����ؼ����������������Ƿ���ȷ
            if (!wucExportExcel4UsersB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "�ؼ��������������Ͳ���ȷ����!";
                return false;
            }
            //2��������󲢳�ʼ������
            //clsExportExcel4UsersEN objExportExcel4UsersEN;	//�������
            objExportExcel4UsersEN = new clsExportExcel4UsersEN();	//��ʼ���¶���
            //3���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
            //4����ֵ�ӽ���㴫���߼��������ʵ���
            PutDataToExportExcel4UsersClass(objExportExcel4UsersEN);		//�ѽ����ֵ����
            //5.1����鴫��ȥ�Ķ��������Ƿ�Ϸ�
            try
            {
                clsExportExcel4UsersBL.CheckPropertyNew(objExportExcel4UsersEN);
                //6��������ʵ�������ݴ��������ݿ���
                clsExportExcel4UsersBL.AddNewRecordBySql2(objExportExcel4UsersEN);
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
            BindGv_ExportExcel4Users();
            DispExportExcel4UsersListRegion();
            wucExportExcel4UsersB1.Clear();		//��տؼ�������
            ///�ָ�<ȷ�����>���<���>
            btnOKUpd.Text = "���";
            btnCancelExportExcel4UsersEdit.Text = "ȡ���༭";
            return true;
        }
        ///�����޸ļ�¼׼�����̴��� for C#
        protected void UpdateExportExcel4UsersRecord(long lngmId)
        {
            //�������裺���ܹ�2����
            //1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
            //2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�

            //1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
            ShowData(lngmId);
            //2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
            clsPubFun.SetButtonEnabled(btnOKUpd, true);
            btnOKUpd.Text = "ȷ���޸�";
            btnCancelExportExcel4UsersEdit.Text = "ȡ���޸�";
            lblMsgEdit.Text = "";
            wucExportExcel4UsersB1.SetFieldNameEnable(false);
            DispEditExportExcel4UsersRegion();
        }
        ///�޸Ĵ���׼�����̴��� for C#
        protected bool UpdateExportExcel4UsersRecordSave(clsExportExcel4UsersEN objExportExcel4UsersEN)
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
            if (!wucExportExcel4UsersB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "�ؼ��������������Ͳ���ȷ����!";
                return false;
            }
            //2����ֵ�ӽ���㴫���߼��������ʵ���
            PutDataToExportExcel4UsersClass(objExportExcel4UsersEN);		//�ѽ����ֵ����
            ///3.1����鴫��ȥ�Ķ��������Ƿ�Ϸ�
            try
            {
                clsExportExcel4UsersBL.CheckPropertyNew(objExportExcel4UsersEN);
                //4��������ʵ�������ݴ��������ݿ���
                clsExportExcel4UsersBL.UpdateBySql2(objExportExcel4UsersEN);
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
            BindGv_ExportExcel4Users();
            DispExportExcel4UsersListRegion();
            wucExportExcel4UsersB1.Clear();//��տؼ��е�����
            //�ָ�<ȷ���޸�>���<���>
            btnOKUpd.Text = "���";
            btnCancelExportExcel4UsersEdit.Text = "ȡ���༭";
            return true;
        }
        ///�޸Ĵ���׼�����̴��� for C#
        protected bool UpdateExportExcel4UsersRecordSaveV5(clsExportExcel4UsersEN objExportExcel4UsersEN)
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
            if (!wucExportExcel4UsersB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "�ؼ��������������Ͳ���ȷ����!";
                return false;
            }
            //2����ֵ�ӽ���㴫���߼��������ʵ���
            PutDataToExportExcel4UsersClass(objExportExcel4UsersEN);		//�ѽ����ֵ����
            ///3.1����鴫��ȥ�Ķ��������Ƿ�Ϸ�
            try
            {
                clsExportExcel4UsersBL.CheckPropertyNew(objExportExcel4UsersEN);
                //4��������ʵ�������ݴ��������ݿ���
                clsExportExcel4UsersBL.UpdateBySql2(objExportExcel4UsersEN);
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
            BindGv_ExportExcel4Users();
            DispExportExcel4UsersListRegion();
            wucExportExcel4UsersB1.Clear();//��տؼ��е�����
            //�ָ�<ȷ���޸�>���<���>
            btnOKUpd.Text = "���";
            btnCancelExportExcel4UsersEdit.Text = "ȡ���༭";
            return true;
        }
        ///ɾ����¼���̴���for C#
        protected void DeleteExportExcel4UsersRecord(long lngmId)
        {
            try
            {
                clsExportExcel4UsersBL.DelRecord(lngmId);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_ExportExcel4Users();
        }

        ///����ר�����ڵ���Excel����ش���
        private void ExportExcel()
        {
            //	1����Ͻ�����������
            string strWhereCond = CombineExportExcel4UsersCondition();
            //	2��������������ȡ�ñ�����������DataTable��
            System.Data.DataTable objDT = null;
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "ExportExcel4Users��Ϣ����.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add("IdExportExcel4Users"); arrCnName.Add("����Excel�û��ֶ���ˮ��");
            arrColName.Add("ViewName"); arrCnName.Add("��������");
            arrColName.Add("TabName"); arrCnName.Add("����");
            arrColName.Add("IsDefaultUser"); arrCnName.Add("�Ƿ�ȱʡ�û�");
            arrColName.Add("UserID"); arrCnName.Add("�û�ID");
            arrColName.Add("UserName"); arrCnName.Add("�û���");
            arrColName.Add("ExportFileName"); arrCnName.Add("�����ļ���");
            arrColName.Add("FieldName"); arrCnName.Add("�ֶ���");
            arrColName.Add("FieldCnName"); arrCnName.Add("�ֶ���������");
            arrColName.Add("IsExport"); arrCnName.Add("�Ƿ񵼳�");
            arrColName.Add("OrderNum"); arrCnName.Add("���");
            arrColName.Add("UpdDate"); arrCnName.Add("�޸�����");
            arrColName.Add("UpdUserId"); arrCnName.Add("�޸��û�Id");
            arrColName.Add("Memo"); arrCnName.Add("��ע");
            strFolderName = clsSysParaEN.TempFileFolder;
            strDownLoadFileName = strFolderName + strFileName;
            if (clsPubVar.InitExcelFile(this, strFolderName, strDownLoadFileName) == false)
            {
                return;
            }
            try
            {
                //	2��������������ȡ�ñ�����������DataTable��
                objDT = clsvExportExcel4UsersBL.GetDataTable(strWhereCond);
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
        private void DispEditExportExcel4UsersRegion()
        {
            tabExportExcel4UsersGridView.Visible = false;
            tabEditExportExcel4UsersRegion.Visible = true;
        }
        private void DispExportExcel4UsersListRegion()
        {
            tabExportExcel4UsersGridView.Visible = true;
            tabEditExportExcel4UsersRegion.Visible = false;
        }
        /// <summary>
        /// �������ܣ�������������������ʾ��������
        ///ע�⣺��������������򣬲�����һ��������������ϵ�ģ�����Ϊһ��������ֵ��Ȼ����Ϊ����������ֵ
        ///      ������������ݿ�ʱ����Ӧ��һ���ֶ���ǰ�������ֶ��ں�
        /// </summary>
        /// <param name="pobjExportExcelSetEN">��ʵ�������</param>
        protected void GetDataFromExportExcelSetClass(clsExportExcelSetEN pobjExportExcelSetEN)
        {
            wucExportExcelSetB_Sim1.ViewName = pobjExportExcelSetEN.ViewName;//    ��������
            wucExportExcelSetB_Sim1.TabName = pobjExportExcelSetEN.TabName;//    ����
            wucExportExcelSetB_Sim1.UserID = pobjExportExcelSetEN.UserId;//    �û�ID
            wucExportExcelSetB_Sim1.ExportFileName = pobjExportExcelSetEN.ExportFileName;//    �����ļ���
            wucExportExcelSetB_Sim1.IsDefaultUser = pobjExportExcelSetEN.IsDefaultUser;//    �Ƿ�Ĭ���û�

        }


        protected void btnUpMove_Click(object sender, System.EventArgs e)
        {
            string strMsg;
            string strmId = clsCommForWebForm.GetFirstCheckedItemFromGv(gvExportExcel4Users);
            if (strmId == null || strmId.Trim().Length == 0)
            {
                lblMsgList.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
                return;
            }
            lblMsgList.Text = "";
            long lngMid = long.Parse(strmId);
            try
            {
                clsExportExcel4UsersBLEx.AdjustSequenceNumber("UP", lngMid);
            }
            catch (Exception objException)
            {
                strMsg = objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                //				clsCommonSession.seErrMessage = objException.Message;
                //				clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;	//"../GenCode/wfmGenViewCode_WebV5.aspx";
                //				clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_ExportExcel4Users();
            clsCommForWebForm.SetCheckedItemForGv(gvExportExcel4Users, 1, strmId);

        }

        protected void btnDownMove_Click(object sender, System.EventArgs e)
        {
            string strMsg;
            string strmId = clsCommForWebForm.GetFirstCheckedItemFromGv(gvExportExcel4Users);
            if (strmId == null || strmId.Trim().Length == 0)
            {
                lblMsgList.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
                return;
            }
            lblMsgList.Text = "";
            long lngMid = long.Parse(strmId);
            try
            {
                clsExportExcel4UsersBLEx.AdjustSequenceNumber("DOWN", lngMid);
            }

            catch (Exception objException)
            {
                strMsg = objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                //				clsCommonSession.seErrMessage = objException.Message;
                //				clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;	//"../GenCode/wfmGenViewCode_WebV5.aspx";
                //				clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_ExportExcel4Users();
            clsCommForWebForm.SetCheckedItemForGv(gvExportExcel4Users, 1, strmId);

        }

        protected void btnReOrder_Click(object sender, System.EventArgs e)
        {
            clsExportExcel4UsersBLEx.ReOrder(qsId_ExportExcel4Users);
            BindGv_ExportExcel4Users();

        }
        protected void btnGoTop_Click(object sender, EventArgs e)
        {
            List<string> arrid_SenateGaugeItem = clsCommForWebForm.GetAllCheckedItemFromGv(gvExportExcel4Users, "chkCheckRec");
            if (arrid_SenateGaugeItem == null || arrid_SenateGaugeItem.Count == 0)
            {
                lblMsgList.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
                clsCommonJsFunc.Alert(this, lblMsgList.Text);
                return;
            }
            else
            {
                lblMsgList.Text = "";


                try
                {
                    clsExportExcel4UsersBLEx.GoTop(arrid_SenateGaugeItem, qsId_ExportExcel4Users);
                }
                catch (Exception objException)
                {
                    clsCommonSession.seErrMessage = objException.Message;
                    clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                    clsPubFun4Web.AccessError(this, conCurrPageName);
                }
            }
            BindGv_ExportExcel4Users();
        }

        protected void btnGoBottum_Click(object sender, EventArgs e)
        {
            List<string> arrid_SenateGaugeItem = clsCommForWebForm.GetAllCheckedItemFromGv(gvExportExcel4Users, "chkCheckRec");
            if (arrid_SenateGaugeItem == null || arrid_SenateGaugeItem.Count == 0)
            {
                lblMsgList.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
                clsCommonJsFunc.Alert(this, lblMsgList.Text);
                return;
            }
            else
            {
                lblMsgList.Text = "";
                try
                {
                    clsExportExcel4UsersBLEx.GoBottom(arrid_SenateGaugeItem, qsId_ExportExcel4Users);
                }
                catch (Exception objException)
                {
                    clsCommonSession.seErrMessage = objException.Message;
                    clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                    clsPubFun4Web.AccessError(this, conCurrPageName);
                }
            }
            BindGv_ExportExcel4Users();
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