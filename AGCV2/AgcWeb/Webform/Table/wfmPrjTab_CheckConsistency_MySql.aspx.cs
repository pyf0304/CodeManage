using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using com.taishsoft.commdb;
using CommFunc4WebForm;
using com.taishsoft.sql;


using System.Collections.Generic;
using AGC.Entity;

using AGC.BusinessLogic;using AGC.FunClass;

using AGC.BusinessLogicEx;


using AutoGCLib;

using com.taishsoft.common;

namespace AGC.Webform
{
    /// <summary>
    /// wfmPrjTabFld_QUDI ��ժҪ˵��������Q�����ѯ��U�����޸�
    /// </summary>
    public partial class wfmPrjTab_CheckConsistency_MySql : CommWebPageBase
    {

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
                string strTabName = clsPrjTabBL.GetObjByTabId(TabId).TabName;
                string strTabCnName = clsPrjTabBL.GetObjByTabId(TabId).TabCnName;
                lblTabName.Text = strTabName + "(" + strTabCnName + ")";
                //1��Ϊ��������������Դ�����б�����
                strSortPrjTabFld_AgcBy = "FldName Asc";
                strSortPrjTabFld_SqlBy = "Column_Name Asc";
                //2����ʾ�������ı�������DATAGRID��
                BindGv_PrjTabFld_Agc();
                BindGv_PrjTabFld_MySql();
                //���һ����
                clsCheckConsistency.CheckConsistency(gvPrjTabFld_Agc, gvPrjTabFld_Sql, TabId, clsPubVar.CurrSelPrjId);
                //3�����ñ�ؼ����ֿؼ���ReadOnly���ԣ�
                //   ʹֻ֮������Ϊ���޸Ĺ����йؼ����ǲ��ܱ��޸ĵġ�
                ///   
                string strRoleId = clsCommonSession.RoleId;
                if (strRoleId == "00050001"
                    || strRoleId == "00050002" || strRoleId == "00050006")
                {
                }
                else
                {
                    clsPubFun.SetButtonEnabled(btnDelRec, false);
                    clsPubFun.SetButtonEnabled(btnDelField_Sql, false);
                }

            }
        }
        private string TabId
        {
            get
            {
                string strTabId;
                strTabId = (string)Session["TabId"];
                if (strTabId == null)
                {
                    strTabId = "";
                }
                return strTabId;
            }
            set
            {
                string strTabId = value;
                Session.Add("TabId", strTabId);
            }
        }
        private string FldId
        {
            get
            {
                string strFldId;
                strFldId = (string)Session["FldId"];
                if (strFldId == null)
                {
                    strFldId = "";
                }
                return strFldId;
            }
            set
            {
                string strFldId = value;
                Session.Add("FldId", strFldId);
            }
        }
        //private string PrjId
        //{
        //    get
        //    {
        //        string strPrjId;
        //        strPrjId = (string)Session["P1rjId"];
        //        if (strPrjId == null)
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


        ///���ɰ�GridView�Ĵ���
        /// <summary>
        /// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
        ///			 ����ʾ��GridView�С�
        /// </summary>
        protected void BindGv_PrjTabFld_Agc()
        {
            //�������裺(��5��)
            //	1����Ͻ�����������
            //	2��������������ȡ�ñ�����������DataTable��
            //	4������GridView������Դ(DataSource)��
            //	5����GridView������DataTable��������ʾ��DATAGRID��
            //	6�����ü�¼����״̬��
            //		�ڱ��������ǰ�״̬��ʾ�ڿؼ�txtRecCount�С�

            //	1����Ͻ�����������
            string strWhereCond = "TabId='" + TabId + "'";    // CombinePrjTabFldCondition();
            //	2��������������ȡ�ñ�����������DataTable��
            System.Data.DataTable objDT = null;
            try
            {
                objDT = clsvPrjTabFldBL.GetDataTable(strWhereCond);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "��ȡ���ݱ�(DataTable)���ɹ�!" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            //	4������GRIDView������Դ(DataSource)��
            DataView objDV = objDT.DefaultView;
            objDV.Sort = strSortPrjTabFld_AgcBy;     ///ע����һ�д����п�����Ҫע�͵���Ŀǰ���н����ڵ����Ĳ�ѯ������������
            this.gvPrjTabFld_Agc.DataSource = objDV;
            //	5����DATAGRID������DataTable��������ʾ��DATAGRID��
            this.gvPrjTabFld_Agc.DataBind();

            ///����ר������BindGv�е���ҳ��ش���
            GridViewRow pagerRow = gvPrjTabFld_Agc.BottomPagerRow;
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
            if (lblRecCount != null)
            {
                //��ǰ��¼��
                lblRecCount.Text = objDT.Rows.Count.ToString();
                //��ǰҳ��
                lblAllPages.Text = this.gvPrjTabFld_Agc.PageCount.ToString();
                //��ǰҳ����
                lblCurrentPage.Text = (this.gvPrjTabFld_Agc.PageIndex + 1).ToString();
                //��ǰ����������ҳ����
                txtJump2Page.Text = (this.gvPrjTabFld_Agc.PageIndex + 1).ToString();
                //�����ǰҳ����Ϊ0����<ǰһҳ>��ť��Ч
                if (this.gvPrjTabFld_Agc.PageIndex == 0)
                {
                    clsPubFun.SetButtonEnabled(btnPrevPage, false);
                }
                else
                {
                    clsPubFun.SetButtonEnabled(btnPrevPage, true);
                }
                //�����ǰҳ������Ϊ���һҳ����<ǰһҳ>��ť��Ч
                if (this.gvPrjTabFld_Agc.PageIndex == this.gvPrjTabFld_Agc.PageCount - 1)
                {
                    clsPubFun.SetButtonEnabled(btnNextPage, false);
                }
                else
                {
                    clsPubFun.SetButtonEnabled(btnNextPage, true);
                }
            }
        }

        ///���ɰ�GridView�Ĵ���
        /// <summary>
        /// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
        ///			 ����ʾ��GridView�С�
        /// </summary>
        protected void BindGv_PrjTabFld_MySql()
        {
            //�������裺(��5��)
            //	1����Ͻ�����������
            //	2��������������ȡ�ñ�����������DataTable��
            //	4������GridView������Դ(DataSource)��
            //	5����GridView������DataTable��������ʾ��DATAGRID��
            //	6�����ü�¼����״̬��
            //		�ڱ��������ǰ�״̬��ʾ�ڿؼ�txtRecCount�С�

            //	1����Ͻ�����������
            //            string strWhereCond = "TabId='" + TabId + "'";    // CombinePrjTabFldCondition();
            string strTabName = clsPrjTabBL.GetObjByTabId(TabId).TabName;
            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(clsPubVar.CurrPrjDataBaseId);

            //	2��������������ȡ�ñ�����������DataTable��
            System.Data.DataTable objDT = null;
            try
            {
                if (clsPubVar.CurrDataBaseTypeId == "03") //ORACLE���ݿ�
                {
                    //LogicEx.oracle.clsTablesEx objTables = new AGC.LogicEx.oracle.clsTablesEx();
                    //objTables.PrjId = clsPubVar.CurrSelPrjId;
                    //clsProjectsEN objProjects = clsProjectsBL.GetObjByPrjIdCache(clsPubVar.CurrSelPrjId);

                    //string strDatabaseOwner = objPrjDataBase.DatabaseOwner;
                    //objDT = objTables.GetColumns(strTabName, strDatabaseOwner);
                }
                else
                {
                    //clsTablesBLEx objTables = new clsTablesBLEx();
                    //objTables.PrjDataBaseId = clsPubVar.CurrPrjDataBaseId;

                    //clsProjectsEN objProjects = clsProjectsBL.GetObjByPrjIdCache(clsPubVar.CurrSelPrjId);

                    //string strDatabaseOwner = objPrjDataBase.DatabaseOwner;
                    objDT = clsTablesBLEx.GetColumns(strTabName, clsPubVar.CurrPrjDataBaseId);
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "��ȡ���ݱ�(DataTable)���ɹ�!" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            if (objDT.Rows.Count == 0)
            {
                //tabSQL.Visible = false;
                divSQL.Visible = false;
                divNewTab.Visible = true;
            }
            else
            {
                divSQL.Visible = true;
                divNewTab.Visible = false;
            }
            //	4������GRIDView������Դ(DataSource)��
            DataView objDV = objDT.DefaultView;
            objDV.Sort = strSortPrjTabFld_SqlBy;     ///ע����һ�д����п�����Ҫע�͵���Ŀǰ���н����ڵ����Ĳ�ѯ������������
            this.gvPrjTabFld_Sql.DataSource = objDV;
            //	5����DATAGRID������DataTable��������ʾ��DATAGRID��
            this.gvPrjTabFld_Sql.DataBind();

            ///����ר������BindGv�е���ҳ��ش���
            GridViewRow pagerRow = gvPrjTabFld_Sql.BottomPagerRow;
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
            if (lblRecCount != null)
            {
                //��ǰ��¼��
                lblRecCount.Text = objDT.Rows.Count.ToString();
                //��ǰҳ��
                lblAllPages.Text = this.gvPrjTabFld_Sql.PageCount.ToString();
                //��ǰҳ����
                lblCurrentPage.Text = (this.gvPrjTabFld_Sql.PageIndex + 1).ToString();
                //��ǰ����������ҳ����
                txtJump2Page.Text = (this.gvPrjTabFld_Sql.PageIndex + 1).ToString();
                //�����ǰҳ����Ϊ0����<ǰһҳ>��ť��Ч
                if (this.gvPrjTabFld_Sql.PageIndex == 0)
                {
                    clsPubFun.SetButtonEnabled(btnPrevPage, false);
                }
                else
                {
                    clsPubFun.SetButtonEnabled(btnPrevPage, true);
                }
                //�����ǰҳ������Ϊ���һҳ����<ǰһҳ>��ť��Ч
                if (this.gvPrjTabFld_Sql.PageIndex == this.gvPrjTabFld_Sql.PageCount - 1)
                {
                    clsPubFun.SetButtonEnabled(btnNextPage, false);
                }
                else
                {
                    clsPubFun.SetButtonEnabled(btnNextPage, true);
                }
            }
        }

        /// <summary>
        /// ���ܣ�����DataGrid��ҳ��
        /// </summary>
        /// <param name="intRecCount">�ܹ��ļ�¼��</param>
        /// <param name="intPageSize">ÿҳ�ļ�¼��</param>
        /// <returns>���������ҳ��</returns>
        protected int CalcPages(int intRecCount, int intPageSize)
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
            this.gvPrjTabFld_Agc.PageIndex = 0;
            //�ѱ��¼��������ʾ��DATAGRID��
            BindGv_PrjTabFld_Agc();
        }
        /// <summary>
        /// �������ܣ��¼��������ڸ���DATAGRID�ĵ�ǰҳ����ʱ�����ĺ�����
        ///			  ���幦����������ʾ��ҳ(������ҳ����)�����ݡ�
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void gvPrjTabFld_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            //�������裺����2����
            //1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
            //2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ

            //1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
            this.gvPrjTabFld_Agc.PageIndex = e.NewPageIndex;
            //2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ
            BindGv_PrjTabFld_Agc();
        }

        /// <summary>
        /// �������ܣ��¼��������ڸ���DATAGRID�ĵ�ǰҳ����ʱ�����ĺ�����
        ///			  ���幦����������ʾ��ҳ(������ҳ����)�����ݡ�
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void gvPrjTabFld_Sql_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            //�������裺����2����
            //1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
            //2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ

            //1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
            this.gvPrjTabFld_Sql.PageIndex = e.NewPageIndex;
            //2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ
            BindGv_PrjTabFld_MySql();
        }

        ///����GridView��������¼�����
        protected void gvPrjTabFld_RowCommand(object sender, GridViewCommandEventArgs e)
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
                        clsCommForWebForm.Set_GridViewAllChecked(gvPrjTabFld_Agc, true);
                        lbSelAll.Text = "��ѡ";
                    }
                    else if (lbSelAll.Text == "��ѡ")
                    {
                        clsCommForWebForm.Set_GridViewAllChecked(gvPrjTabFld_Agc, false);
                        lbSelAll.Text = "ȫѡ";
                    }
                    break;
            }
        }

        ///����GridView��������¼�����
        protected void gvPrjTabFld_Sql_RowCommand(object sender, GridViewCommandEventArgs e)
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
                        clsCommForWebForm.Set_GridViewAllChecked(gvPrjTabFld_Sql, true);
                        lbSelAll.Text = "��ѡ";
                    }
                    else if (lbSelAll.Text == "��ѡ")
                    {
                        clsCommForWebForm.Set_GridViewAllChecked(gvPrjTabFld_Sql, false);
                        lbSelAll.Text = "ȫѡ";
                    }
                    break;
            }
        }



        ///����ר������BINDgv�е���ҳ��ش���
        //��ǰ��¼��
        protected void btnAddNewRec4Gv_Click(object sender, System.EventArgs e)
        {


        }

        ///����ר������BINDgv�е���ҳ��ش���
        //��ǰ��¼��
        protected void btnExportExcel4Gv_Click(object sender, System.EventArgs e)
        {
            //	1����Ͻ�����������
            string strWhereCond = "TabId='" + TabId + "'";   // CombinePrjTabFldCondition();
            //	2��������������ȡ�ñ�����������DataTable��
            System.Data.DataTable objDT = null;
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "PrjTabFld��Ϣ����.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add("mId"); arrCnName.Add("mId");
            arrColName.Add("IsOnlyOne"); arrCnName.Add("�Ƿ�Ψһ");
            arrColName.Add("FieldTypeName"); arrCnName.Add("FieldTypeName");
            arrColName.Add("FldName"); arrCnName.Add("�ֶ���");
            arrColName.Add("DataTypeId"); arrCnName.Add("�ֶ�����");
            arrColName.Add("FldLength"); arrCnName.Add("�ֶγ���");
            arrColName.Add("Caption"); arrCnName.Add("����");
            arrColName.Add("SequenceNumber"); arrCnName.Add("˳���");
            arrColName.Add("Memo"); arrCnName.Add("˵��");
            arrColName.Add("ForeignTabName"); arrCnName.Add("ForeignTabName");
            arrColName.Add("PrimaryTypeName"); arrCnName.Add("����������");
            arrColName.Add("TabName"); arrCnName.Add("����");
            arrColName.Add("DataTypeName"); arrCnName.Add("DataTypeName");
            arrColName.Add("IsTabNullable"); arrCnName.Add("�Ƿ���пɿ�");
            arrColName.Add("DefaultValue"); arrCnName.Add("ȱʡֵ");
            strFolderName = clsSysParaEN.TempFileFolder;
            strDownLoadFileName = strFolderName + strFileName;
            try
            {
                //	2��������������ȡ�ñ�����������DataTable��
                objDT = clsvPrjTabFldBL.GetDataTable(strWhereCond);
                GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4Odbc(objDT, arrColName, arrCnName, strDownLoadFileName);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            DownLoadFile(strDownLoadFileName);
        }
        /// <summary>
        /// ���ܣ������ļ����ӷ����������ļ����ͻ��������
        /// </summary>
        /// <param name="strDownLoadFileName">��Ҫ���ص��ļ��������ļ���Ϊ��Ŀ¼���ļ�ȫ��</param>
        /// <returns></returns>
        protected bool DownLoadFile(string strDownLoadFileName)
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

        ///����ר������BINDgv�е���ҳ��ش���
        //��ǰ��¼��
        protected void btnDelete4Gv_Click(object sender, System.EventArgs e)
        {
            List<string> arrmId = clsCommForWebForm.GetAllCheckedItemFromGv(gvPrjTabFld_Agc, "chkCheckRec");
            if (arrmId == null || arrmId.Count == 0)
            {
                lblMsgList.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
                return;
            }
            lblMsgList.Text = "";
            try
            {
                clsPrjTabFldBL.DelPrjTabFlds(arrmId);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_PrjTabFld_Agc();
        }
        
     
        protected void gvPrjTabFld_Sorting(object sender, GridViewSortEventArgs e)
        {
            int intIndex;
            //�ж��Ƿ����µ������ֶ�
            intIndex = strSortPrjTabFld_AgcBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                strSortPrjTabFld_AgcBy = e.SortExpression + " Asc";
                BindGv_PrjTabFld_Agc();
                return;
            }
            //���ԭ��������
            intIndex = strSortPrjTabFld_AgcBy.IndexOf(" Asc");
            if (intIndex == -1)		//���ԭ���������������Ϊ����
            {
                strSortPrjTabFld_AgcBy = e.SortExpression + " Asc";
            }
            else			///��������Ϊ����
            {
                strSortPrjTabFld_AgcBy = e.SortExpression + " Desc";
            }
            BindGv_PrjTabFld_Agc();
        }

        protected void gvPrjTabFld_Sql_Sorting(object sender, GridViewSortEventArgs e)
        {
            int intIndex;
            //�ж��Ƿ����µ������ֶ�
            intIndex = strSortPrjTabFld_SqlBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                strSortPrjTabFld_SqlBy = e.SortExpression + " Asc";
                BindGv_PrjTabFld_MySql();
                return;
            }
            //���ԭ��������
            intIndex = strSortPrjTabFld_SqlBy.IndexOf(" Asc");
            if (intIndex == -1)		//���ԭ���������������Ϊ����
            {
                strSortPrjTabFld_SqlBy = e.SortExpression + " Asc";
            }
            else			///��������Ϊ����
            {
                strSortPrjTabFld_SqlBy = e.SortExpression + " Desc";
            }
            BindGv_PrjTabFld_MySql();
        }

        protected string strSortPrjTabFld_AgcBy
        {
            get
            {
                string sSortPrjTabFld_AgcBy;
                sSortPrjTabFld_AgcBy = (string)ViewState["SortPrjTabFld_AgcBy"];
                if (sSortPrjTabFld_AgcBy == null)
                {
                    sSortPrjTabFld_AgcBy = "";
                }
                return sSortPrjTabFld_AgcBy;
            }
            set
            {
                string sSortPrjTabFld_AgcBy = value;
                ViewState.Add("SortPrjTabFld_AgcBy", sSortPrjTabFld_AgcBy);
            }
        }
        protected string strSortPrjTabFld_SqlBy
        {
            get
            {
                string sSortPrjTabFld_SqlBy;
                sSortPrjTabFld_SqlBy = (string)ViewState["SortPrjTabFld_SqlBy"];
                if (sSortPrjTabFld_SqlBy == null)
                {
                    sSortPrjTabFld_SqlBy = "";
                }
                return sSortPrjTabFld_SqlBy;
            }
            set
            {
                string sSortPrjTabFld_SqlBy = value;
                ViewState.Add("SortPrjTabFld_SqlBy", sSortPrjTabFld_SqlBy);
            }
        }


        ///��������ҳ����غ���
        protected void btnJumpPage_Click(object sender, EventArgs e)
        {
            GridViewRow pagerRow = gvPrjTabFld_Agc.BottomPagerRow;
            TextBox txtJump2Page = (TextBox)pagerRow.FindControl("txtJump2Page");
            if (txtJump2Page != null)
            {
                if (txtJump2Page.Text.Trim() != "" &&
                int.Parse(txtJump2Page.Text) > 0 &&
                int.Parse(txtJump2Page.Text) - 1 < this.gvPrjTabFld_Agc.PageCount)
                {
                    this.gvPrjTabFld_Agc.PageIndex = int.Parse(txtJump2Page.Text) - 1;
                }
                this.BindGv_PrjTabFld_Agc();
            }
        }
        ///ɾ����¼���̴���for C#
        protected void DeletePrjTabFldRecord(long lngmId)
        {
            try
            {
                clsPrjTabFldBLEx.DelRecordEx(lngmId);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_PrjTabFld_Agc();
        }
        ///ɾ����¼���̴���for C#
        protected void gvPrjTabFld_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            if (e.NewPageIndex != -1)
            {
                gvPrjTabFld_Agc.PageIndex = e.NewPageIndex;
                this.BindGv_PrjTabFld_Agc();
            }
        }
        ///ɾ����¼���̴���for C#
        protected void gvPrjTabFld_Sql_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            if (e.NewPageIndex != -1)
            {
                gvPrjTabFld_Sql.PageIndex = e.NewPageIndex;
                this.BindGv_PrjTabFld_MySql();
            }
        }

        ///ɾ����¼���̴���for C#
        protected void gvPrjTabFld_RowCreated(object sender, GridViewRowEventArgs e)
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
            if (strSortPrjTabFld_AgcBy == "") return;
            if (e.Row.RowType == DataControlRowType.Header)//����ؼ��Ƿ�Ϊҳü��
            {
                string strSortEx;
                for (int i = 0; i < this.gvPrjTabFld_Agc.Columns.Count; i++)
                {
                    strSortEx = this.gvPrjTabFld_Agc.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = strSortPrjTabFld_AgcBy.IndexOf(strSortEx + " ");
                    if (intIndex >= 0)  //��ͼ״̬��������ʽ�Ƿ�Ϊ���е��ֶΣ�
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//�������壬��"webdings"��5�������ǣ�6�������ǣ�
                        intIndex = strSortPrjTabFld_AgcBy.IndexOf("Asc");
                        lblSort.Text = (intIndex > 0 ? " 5" : " 6");//�Ƿ�Ϊ���򣬶���Ϊstring�ͣ�
                        e.Row.Cells[i].Controls.Add(lblSort);//��������ĵ�i����Ԫ��������һ�ؼ���
                        break;
                    }
                }
            }
        }

        ///ɾ����¼���̴���for C#
        protected void gvPrjTabFld_Sql_RowCreated(object sender, GridViewRowEventArgs e)
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
            if (strSortPrjTabFld_SqlBy == "") return;
            if (e.Row.RowType == DataControlRowType.Header)//����ؼ��Ƿ�Ϊҳü��
            {
                string strSortEx;
                for (int i = 0; i < this.gvPrjTabFld_Sql.Columns.Count; i++)
                {
                    strSortEx = this.gvPrjTabFld_Sql.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = strSortPrjTabFld_SqlBy.IndexOf(strSortEx + " ");
                    if (intIndex >= 0)  //��ͼ״̬��������ʽ�Ƿ�Ϊ���е��ֶΣ�
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//�������壬��"webdings"��5�������ǣ�6�������ǣ�
                        intIndex = strSortPrjTabFld_SqlBy.IndexOf("Asc");
                        lblSort.Text = (intIndex > 0 ? " 5" : " 6");//�Ƿ�Ϊ���򣬶���Ϊstring�ͣ�
                        e.Row.Cells[i].Controls.Add(lblSort);//��������ĵ�i����Ԫ��������һ�ؼ���
                        break;
                    }
                }
            }
        }

        protected void btnReCheckConSistency_Click(object sender, EventArgs e)
        {
            BindGv_PrjTabFld_Agc();
            BindGv_PrjTabFld_MySql();
            //���һ����
            clsCheckConsistency.CheckConsistency(gvPrjTabFld_Agc, gvPrjTabFld_Sql, TabId, clsPubVar.CurrSelPrjId);

        }
        protected void lbReturn_Click(object sender, EventArgs e)
        {
            if (clsCommonSession.ParentPage == "wfmEditTabAndObjectFields")
            {
                JumpOtherPages("wfmEditTabAndObjectFields.aspx");
            }
            JumpOtherPages("wfmPrjTab_QUDI3.aspx");
          
        }
        protected void btnAddNewField_Click(object sender, EventArgs e)
        {
            //�������裺
            //1���ҵ���ѡSQL�����ֶΣ���������Ӧ�������
            //2����������б��ݵ����ֶ����У�����ӵ���Ӧ�ı�
            ///
            try
            {
                //1���ҵ���ѡSQL�����ֶΣ���������Ӧ�������
                ArrayList arrColumnsObjList = Get_GvCheckedObjArr(gvPrjTabFld_Sql);
                //2����������б��ݵ����ֶ����У�����ӵ���Ӧ�ı�
                clsPrjTabFldBLEx.ImportFieldFromColumnObjList(TabId, arrColumnsObjList, clsCommonSession.UserId);
                ///
                BindGv_PrjTabFld_Agc();
                BindGv_PrjTabFld_MySql();
                clsCheckConsistency.CheckConsistency(gvPrjTabFld_Agc, gvPrjTabFld_Sql, TabId, clsPubVar.CurrSelPrjId);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
        }
        private ArrayList Get_GvCheckedObjArr(System.Web.UI.WebControls.GridView objGv)
        {
            ArrayList arr = new ArrayList();
            if (objGv.Rows.Count == 0)
            {
                return arr;
            }
            else
            {
                int intRowNum = objGv.Rows.Count;
                for (int iRow = 0; iRow < intRowNum; iRow++)
                {
                    GridViewRow di = objGv.Rows[iRow];
                    CheckBox cb = (CheckBox)di.Cells[0].FindControl("chkCheckRec");
                    if (cb != null && cb.Checked)
                    {
                        clsColumns objColumns = new clsColumns();
                        objColumns.Column_Name = objGv.DataKeys[iRow].Value.ToString();
                        objColumns.Type_Name = di.Cells[2].Text.ToString();
                        objColumns.length = int.Parse(di.Cells[3].Text.ToString());
                        objColumns.Is_Nullable = di.Cells[4].Text.ToString();
                        arr.Add(objColumns);
                    }
                }
                return arr;
                //foreach (GridViewRow li in objGv.Rows)
                //{

                //    CheckBox cb = (CheckBox)li.Cells[0].FindControl("chkCheckRec");
                //    if (cb != null && cb.Checked)
                //    {
                //        arr.Add(li.Cells[1].Text);
                //    }
                //}
                //return arr;
            }
        }

        protected void btnGenNewTabInSQL_Click(object sender, EventArgs e)
        {

            Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);

            lblMsgList.Text = "";
            string strTabId = TabId;
            if (strTabId == null || strTabId.Trim().Length == 0)
            {
                lblMsgList.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
                return;
            }

            //if (CheckTabFieldBySqlTab(strTabId) == false)
            //{
            //    return;
            //}

            try
            {
                string strCharEncodingId = clsPubFun.GetCharEncodingIdByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                string strCodePath = "";
                string strRe_ClsName = "";

                bool strCodeText = clsPrjTabBLEx_GeneCode.GenSQLCode4CreateTab(strTabId,
                    clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId);
                //txtCode_Sim.Text = strCodeText_Sim;
                lblMsg2.Text = strCodeText.ToString();
                divSQL.Visible = true;
                //tabSQL.Visible = true;
                divNewTab.Visible = false;
                lblMsg2.Text = "�½���ɹ�!";
            }
            catch (Exception objException)
            {
                if (objException.Message.Length < 30)
                {
                    lblMsg2.Text = objException.Message;
                }
                else
                {
                    clsCommonSession.seErrMessage = objException.Message;
                    clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;	//"../GenCode/wfmGenViewCode_WebV5.aspx";
                    clsPubFun4Web.AccessError(this, conCurrPageName);
                }
            }

        }
        protected void btnSetFldProperty_Click(object sender, EventArgs e)
        {
            JumpOtherPages("FieldTab_U");
        }
        protected void btnAddFieldToSqlTable_Click(object sender, EventArgs e)
        {
            //�������裺
            //1���ҵ���ѡ���ɴ���ϵͳ�������ֶΣ���������Ӧ�Ĺؼ����б�
            //2������ѡ��ϵͳ���ֶΣ���ӵ���Ӧ��SQL����
            ///
            try
            {
                //1���ҵ���ѡ���ɴ���ϵͳ�������ֶΣ���������Ӧ�Ĺؼ����б�
                List<string> arrTabFieldObjList = clsCommForWebForm.GetAllCheckedItemFromGv(gvPrjTabFld_Agc, "chkCheckRec");
                //2������ѡ��ϵͳ���ֶΣ���ӵ���Ӧ��SQL����
                clsPrjTabBLEx.AlterTab4AddField(arrTabFieldObjList, clsPubVar.CurrPrjDataBaseId);
                //3�����¼������֮���һ����
                BindGv_PrjTabFld_Agc();
                BindGv_PrjTabFld_MySql();
                clsCheckConsistency.CheckConsistency(gvPrjTabFld_Agc, gvPrjTabFld_Sql, TabId, clsPubVar.CurrSelPrjId);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
        }
        protected void btnSynchFldInfo_Click(object sender, EventArgs e)
        {
            //�����ɴ���ϵͳ�е��ֶ���Ϣͬ����SQL���ֶ���

            //�������裺
            //1���ҵ���ѡ���ɴ���ϵͳ�������ֶΣ���������Ӧ�Ĺؼ����б�
            //2������ѡ��ϵͳ���ֶΣ���ӵ���Ӧ��SQL����
            ///
            try
            {
                //1���ҵ���ѡ���ɴ���ϵͳ�������ֶΣ���������Ӧ�Ĺؼ����б�
                List<string> arrTabFieldObjList = clsCommForWebForm.GetAllCheckedItemFromGv(gvPrjTabFld_Agc, "chkCheckRec");
                //2������ѡ��ϵͳ���ֶΣ���ӵ���Ӧ��SQL����
                clsPrjTabBLEx.AlterTab4UpdateField(arrTabFieldObjList, clsPubVar.CurrPrjDataBaseId);
                //3�����¼������֮���һ����
                BindGv_PrjTabFld_Agc();
                BindGv_PrjTabFld_MySql();
                clsCheckConsistency.CheckConsistency(gvPrjTabFld_Agc, gvPrjTabFld_Sql, TabId, clsPubVar.CurrSelPrjId);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }

        }
        protected void btnSynchFldInfoToAgc_Click(object sender, EventArgs e)
        {
            //�������裺
            //1���ҵ���ѡSQL�����ֶΣ���������Ӧ�������
            //2����������б��ݵ����ֶ����У�����ӵ���Ӧ�ı�
            ///
            try
            {
                //1���ҵ���ѡSQL�����ֶΣ���������Ӧ�������
                ArrayList arrColumnsObjList = Get_GvCheckedObjArr(gvPrjTabFld_Sql);
                //2����������б��ݵ����ֶ����У�����ӵ���Ӧ�ı�
                clsPrjTabFldBLEx.SynchFieldFromColumnObjList(TabId, arrColumnsObjList);
                ///
                BindGv_PrjTabFld_Agc();
                BindGv_PrjTabFld_MySql();
                clsCheckConsistency.CheckConsistency(gvPrjTabFld_Agc, gvPrjTabFld_Sql, TabId, clsPubVar.CurrSelPrjId);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
        }
        protected void btnDelRec_Click(object sender, EventArgs e)
        {
            //�����ɴ���ϵͳ�е��ֶ���Ϣͬ����SQL���ֶ���

            //�������裺
            //1���ҵ���ѡ���ɴ���ϵͳ�������ֶΣ���������Ӧ�Ĺؼ����б�
            //2������ѡ��ϵͳ���ֶΣ���ӵ���Ӧ��SQL����
            ///
            try
            {
                //1���ҵ���ѡ���ɴ���ϵͳ�������ֶΣ���������Ӧ�Ĺؼ����б�
                List<string> arrTabFieldObjList = clsCommForWebForm.GetAllCheckedItemFromGv(gvPrjTabFld_Agc, "chkCheckRec");
                //2������ѡ��ϵͳ���ֶΣ���ӵ���Ӧ��SQL����
                foreach (string strMid in arrTabFieldObjList)
                {
                    long lngMid = long.Parse(strMid);
                    //����ض�����ɾ�����ֶ�
                    clsPrjTabFldEN objPrjTabFld = clsPrjTabFldBL.GetObjBymId(lngMid);
                    //string strObjId = clsPrjTabBL.GetObjByTabId(objPrjTabFld.TabId).ObjId;
                    //clsFldObjTabBLEx.DelObjFld(strObjId, objPrjTabFld.FldId);

                    clsPrjTabFldBLEx.DelRecordEx(lngMid);
                }
                //3�����¼������֮���һ����
                BindGv_PrjTabFld_Agc();
                BindGv_PrjTabFld_MySql();
                clsCheckConsistency.CheckConsistency(gvPrjTabFld_Agc, gvPrjTabFld_Sql, TabId, clsPubVar.CurrSelPrjId);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }

        }
        protected void btnDelField_Sql_Click(object sender, EventArgs e)
        {
            //�������裺
            //1���ҵ���ѡSQL�����ֶΣ���������Ӧ�������
            //2����������б��ݵ����ֶ����У�����ӵ���Ӧ�ı�
            ///
            try
            {
                //1���ҵ���ѡSQL�����ֶΣ���������Ӧ�������
                ArrayList arrColumnsObjList = Get_GvCheckedObjArr(gvPrjTabFld_Sql);
                //2������ѡ��ϵͳ���ֶΣ���ӵ���Ӧ��SQL����
                clsPrjTabBLEx.AlterTab4DropColumn(TabId, arrColumnsObjList, clsPubVar.CurrPrjDataBaseId);
                ///
                BindGv_PrjTabFld_Agc();
                BindGv_PrjTabFld_MySql();
                clsCheckConsistency.CheckConsistency(gvPrjTabFld_Agc, gvPrjTabFld_Sql, TabId, clsPubVar.CurrSelPrjId);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
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

            switch (strPageName)
            {
                case "wfmEditTabAndObjectFields.aspx":
                    string strTabId = clsCommonSession.TabId;
                    if (string.IsNullOrEmpty(strTabId) == false)
                    {
                        clsPubFun4Web.JumpToEditTabAndFields(this, strTabId, strCurrPageName);
                    }
                    break;
                case "wfmPrjTab_QUDI3.aspx":

                    clsPubFun4Web.JumpToPrjTab_QUDI3(this, strCurrPageName);
                    break;
                case "FieldTab_U":
                    string strMid;
                    long lngMid;        //��ǰ��ѡ��¼�Ĺؼ���MId
                                        //1����ȡ��ǰ��ѡ�е��ֶ�ID��
                    strMid = clsCommForWebForm.GetFirstCheckedItemFromGv(gvPrjTabFld_Agc);
                    if (strMid.Trim().Length == 0)
                    {
                        lblMsgList.Text = "û��ѡ���¼����ѡ��һ����Ч���ֶμ�¼!";
                        return;
                    }
                    lngMid = long.Parse(strMid);
                    string strFldId = clsPrjTabFldBL.GetObjBymId(lngMid).FldId;
                    FldId = strFldId;
                    BackPageLinkStrFromUpdField = Page.Request.Url.AbsolutePath;
                    clsPubFun4Web.JumpToFieldTab_U(this, "", strFldId, strCurrPageName);
                    break;
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