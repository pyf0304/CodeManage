
///----------------------
///���ɴ���汾��2012.11.9.1
///�������ڣ�2013/03/07
///�����ߣ����Է�
///�������ƣ�AGC
///����ID��0005
///ģ����������ϵͳ����
///ģ��Ӣ������SystemSet
///ע�⣺1����Ҫ���ݵײ㣨PubDataBase.dll���İ汾��2012.10.20.1
///       2����Ҫ���������㣨TzPubFunction.dll���İ汾��2012.10.23.1
///========================
///���ɲ�ѯ���޸ģ�ɾ������Ӽ�¼�Ŀ��Ʋ����


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
    /// wfmDataBaseModuleRelaB_QUDI ��ժҪ˵��������Q�����ѯ��U�����޸�
    /// </summary>
    public partial class wfmDataBaseModuleRelaB_QUDI : CommWebPageBase
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

                //1��Ϊ��������������Դ�����б�����
                wucDataBaseModuleRelaB1.SetDdl_PrjId();
                wucDataBaseModuleRelaB1.PrjId = clsPubVar.CurrSelPrjId;
                wucDataBaseModuleRelaB1.SetPrjIdEnabled(false);

                wucDataBaseModuleRelaB1.SetDdl_PrjDataBaseId(clsPubVar.CurrSelPrjId);
                wucDataBaseModuleRelaB1.SetDdl_FuncModuleId(clsPubVar.CurrSelPrjId);
              
                strSortDataBaseModuleRelaBy = "mId Asc";
                //2����ʾ�������ı�������DATAGRID��
                BindGv_DataBaseModuleRela();
                //3�����ñ�ؼ����ֿؼ���ReadOnly���ԣ�
                //   ʹֻ֮������Ϊ���޸Ĺ����йؼ����ǲ��ܱ��޸ĵġ�
                DispDataBaseModuleRelaListRegion();
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
            this.gvDataBaseModuleRela.PageIndex = 0;
            //�ѱ��¼��������ʾ��DATAGRID��
            BindGv_DataBaseModuleRela();
        }
        /// <summary>
        /// �������ܣ��¼��������ڸ���DATAGRID�ĵ�ǰҳ����ʱ�����ĺ�����
        ///			  ���幦����������ʾ��ҳ(������ҳ����)�����ݡ�
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void gvDataBaseModuleRela_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            //�������裺����2����
            //1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
            //2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ

            //1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
            this.gvDataBaseModuleRela.PageIndex = e.NewPageIndex;
            //2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ
            BindGv_DataBaseModuleRela();
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
            clsDataBaseModuleRelaEN objDataBaseModuleRelaEN;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "���":
                    AddDataBaseModuleRelaRecord();
                    break;
                case "ȷ�����":
                    //����һ������Ĳ���Ĵ��룬�����߼���̫�򵥣�
                    //�Ͱ��߼���ϲ������Ʋ�,
                    AddDataBaseModuleRelaRecordSave();
                    break;
                case "ȷ���޸�":
                    //����һ��������޸ĵĴ��룬�����߼���̫�򵥣�
                    //�Ͱ��߼���ϲ������Ʋ�,
                    objDataBaseModuleRelaEN = (clsDataBaseModuleRelaEN)Session["objDataBaseModuleRelaEN"];
                    UpdateDataBaseModuleRelaRecordSave(objDataBaseModuleRelaEN);
                    break;
            }
        }

        ///����¼�¼���¼����̣������ڸù����е���������������Ҫ��������Ӷ��д��롣
        protected void btnAddNewRec4Gv_Click(object sender, System.EventArgs e)
        {
            AddDataBaseModuleRelaRecord();
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
            List<string> lstKeyValues = clsCommForWebForm.GetAllCheckedItemFromGv(gvDataBaseModuleRela, "chkCheckRec", "mId");
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
                    clsDataBaseModuleRelaBL.DelRecord(lngmId);
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_DataBaseModuleRela();
        }

        /// <summary>
        ///�޸ĵ�ǰ��ѡ��¼
        /// </summary>
        protected void btnUpdate4Gv_Click(object sender, System.EventArgs e)
        {
            List<string> lstKeyValue = clsCommForWebForm.GetFirstCheckedItemFromGv(gvDataBaseModuleRela, "mId");
            if (lstKeyValue.Count == 0)
            {
                lblMsgList.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
                return;
            }
            lblMsgList.Text = "";
            //1����ʾ�ùؼ��ֵ��������û��޸ĸùؼ��ּ�¼��
            string[] strKeys = lstKeyValue[0].Split(',');
            long lngmId = long.Parse(strKeys[0]);
            UpdateDataBaseModuleRelaRecord(lngmId);
        }
        protected void gvDataBaseModuleRela_Sorting(object sender, GridViewSortEventArgs e)
        {
            int intIndex;
            //�ж��Ƿ����µ������ֶ�
            intIndex = strSortDataBaseModuleRelaBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                strSortDataBaseModuleRelaBy = e.SortExpression + " Asc";
                BindGv_DataBaseModuleRela();
                return;
            }
            //���ԭ��������
            intIndex = strSortDataBaseModuleRelaBy.IndexOf(" Asc");
            if (intIndex == -1)		//���ԭ���������������Ϊ����
            {
                strSortDataBaseModuleRelaBy = e.SortExpression + " Asc";
            }
            else			///��������Ϊ����
            {
                strSortDataBaseModuleRelaBy = e.SortExpression + " Desc";
            }
            BindGv_DataBaseModuleRela();
        }

        /// <summary>
        /// ���ڼ�¼GridView�еĵ�ǰ������ʽ���Ա������һ�������򣬻��ǽ�������
        /// </summary>
        protected string strSortDataBaseModuleRelaBy
        {
            get
            {
                string sSortDataBaseModuleRelaBy;
                sSortDataBaseModuleRelaBy = (string)ViewState["SortDataBaseModuleRelaBy"];
                if (sSortDataBaseModuleRelaBy == null)
                {
                    sSortDataBaseModuleRelaBy = "";
                }
                return sSortDataBaseModuleRelaBy;
            }
            set
            {
                string sSortDataBaseModuleRelaBy = value;
                ViewState.Add("SortDataBaseModuleRelaBy", sSortDataBaseModuleRelaBy);
            }
        }

        ///��������ҳ����غ���
        protected void btnJumpPage_Click(object sender, EventArgs e)
        {
            GridViewRow pagerRow = gvDataBaseModuleRela.BottomPagerRow;
            TextBox txtJump2Page = (TextBox)pagerRow.FindControl("txtJump2Page");
            if (txtJump2Page != null)
            {
                if (txtJump2Page.Text.Trim() != "" &&
                int.Parse(txtJump2Page.Text) > 0 &&
                int.Parse(txtJump2Page.Text) - 1 < this.gvDataBaseModuleRela.PageCount)
                {
                    this.gvDataBaseModuleRela.PageIndex = int.Parse(txtJump2Page.Text) - 1;
                }
                this.BindGv_DataBaseModuleRela();
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
                    BindGv_DataBaseModuleRela();
                }
            }
        }

        ///����GridView��������¼�����
        protected void gvDataBaseModuleRela_RowCommand(object sender, GridViewCommandEventArgs e)
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
                        clsCommForWebForm.Set_GridViewAllChecked(gvDataBaseModuleRela, true);
                        lbSelAll.Text = "��ѡ";
                    }
                    else if (lbSelAll.Text == "��ѡ")
                    {
                        clsCommForWebForm.Set_GridViewAllChecked(gvDataBaseModuleRela, false);
                        lbSelAll.Text = "ȫѡ";
                    }
                    break;
            }
        }
        ///ɾ����¼���̴���for C#
        protected void gvDataBaseModuleRela_RowCreated(object sender, GridViewRowEventArgs e)
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
            if (strSortDataBaseModuleRelaBy == "") return;
            if (e.Row.RowType == DataControlRowType.Header)//����ؼ��Ƿ�Ϊҳü��
            {
                string strSortEx;
                for (int i = 0; i < this.gvDataBaseModuleRela.Columns.Count; i++)
                {
                    strSortEx = this.gvDataBaseModuleRela.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = strSortDataBaseModuleRelaBy.IndexOf(strSortEx + " ");
                    if (intIndex >= 0)  //��ͼ״̬��������ʽ�Ƿ�Ϊ���е��ֶΣ�
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//�������壬��"webdings"��5�������ǣ�6�������ǣ�
                        intIndex = strSortDataBaseModuleRelaBy.IndexOf("Asc");
                        lblSort.Text = (intIndex > 0 ? " 5" : " 6");//�Ƿ�Ϊ���򣬶���Ϊstring�ͣ�
                        e.Row.Cells[i].Controls.Add(lblSort);//��������ĵ�i����Ԫ��������һ�ؼ���
                        break;
                    }
                }
            }
        }

        ///
        protected void gvDataBaseModuleRela_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string strmId = gvDataBaseModuleRela.DataKeys[e.RowIndex]["mId"].ToString();
            long lngmId = long.Parse(strmId);
            DeleteDataBaseModuleRelaRecord(lngmId);
        }
        ///
        protected void gvDataBaseModuleRela_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string strmId = gvDataBaseModuleRela.DataKeys[e.RowIndex]["mId"].ToString();
            long lngmId = long.Parse(strmId);
            UpdateDataBaseModuleRelaRecord(lngmId);
        }
        ///ɾ����¼���̴���for C#
        protected void gvDataBaseModuleRela_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            if (e.NewPageIndex != -1)
            {
                gvDataBaseModuleRela.PageIndex = e.NewPageIndex;
                this.BindGv_DataBaseModuleRela();
            }
        }
        ///
        protected void btnCancelDataBaseModuleRelaEdit_Click(object sender, EventArgs e)
        {
            DispDataBaseModuleRelaListRegion();
        }

        protected void btnSetVisible_Click(object sender, EventArgs e)
        {
            List<string> lstKeyValues = clsCommForWebForm.GetAllCheckedItemFromGv(gvDataBaseModuleRela, "chkCheckRec", "mId");
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
                    clsDataBaseModuleRelaBLEx.SetVisibility(lngmId, true, clsCommonSession.UserId);
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_DataBaseModuleRela();
        
        }

        protected void btnSetNotVisible_Click(object sender, EventArgs e)
        {
            List<string> lstKeyValues = clsCommForWebForm.GetAllCheckedItemFromGv(gvDataBaseModuleRela, "chkCheckRec", "mId");
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
                    clsDataBaseModuleRelaBLEx.SetVisibility(lngmId, false, clsCommonSession.UserId);
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_DataBaseModuleRela();
        
        }

        protected void btnImportAllModule_Click(object sender, EventArgs e)
        {
            try
            {
                int intRecCount = clsDataBaseModuleRelaBLEx.SetDefaDataBaseModuleRela(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                clsCommonJsFunc.Alert(this, string.Format("������ɣ��������ˣ�{0}����¼��", intRecCount));
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
            }
        }

    }
    public partial class wfmDataBaseModuleRelaB_QUDI : CommWebPageBase
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
            if (clsDataBaseModuleRelaBL.IsExist(lngmId) == false)		//���ùؼ��ֵļ�¼�Ƿ����
            {
                string ss = "�ؼ���Ϊ��" + lngmId + "�Ĳ�����!";
                clsCommonJsFunc.Alert(this, ss);
                return;
            }
            //3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
            clsDataBaseModuleRelaEN objDataBaseModuleRelaEN = new clsDataBaseModuleRelaEN(lngmId);
            //4����ȡ�������������ԣ�
            try
            {
                clsDataBaseModuleRelaBL.GetDataBaseModuleRela(ref objDataBaseModuleRelaEN);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            Session.Add("objDataBaseModuleRelaEN", objDataBaseModuleRelaEN);
            //5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���
            GetDataFromDataBaseModuleRelaClass(objDataBaseModuleRelaEN);
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
        protected string CombineDataBaseModuleRelaCondition()
        {
            //ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
            //���� 1=1 && UserName = '����'
            string strWhereCond = string.Format(" 1=1 ");
            //����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�

            strWhereCond += " And PrjId='" + clsPubVar.CurrSelPrjId + "'";

            strWhereCond += " And PrjDataBaseId='" + clsPubVar.CurrPrjDataBaseId + "'";
            return strWhereCond;
        }
        ///���ɰ�GridView�Ĵ���
        /// <summary>
        /// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
        ///			 ����ʾ��GridView�С�
        /// </summary>
        protected void BindGv_DataBaseModuleRela()
        {
            //�������裺(��5��)
            //	1����Ͻ�����������
            //	2��������������ȡ�ñ�����������DataTable��
            //	4������GridView������Դ(DataSource)��
            //	5����GridView������DataTable��������ʾ��DATAGRID��
            //	6�����ü�¼����״̬��
            //		�ڱ��������ǰ�״̬��ʾ�ڿؼ�txtRecCount�С�

            //	1����Ͻ�����������
            string strWhereCond = CombineDataBaseModuleRelaCondition();
            //	2��������������ȡ�ñ�����������DataTable��
            System.Data.DataTable objDT = null;
            try
            {
                objDT = clsvDataBaseModuleRelaBL.GetDataTable(strWhereCond);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "��ȡ���ݱ�(DataTable)���ɹ�!" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            //	4������GRIDView������Դ(DataSource)��
            DataView objDV = objDT.DefaultView;
            objDV.Sort = strSortDataBaseModuleRelaBy;     ///ע����һ�д����п�����Ҫע�͵���Ŀǰ���н����ڵ����Ĳ�ѯ������������
            ///����GridView��ÿҳ�ļ�¼��
            if (string.IsNullOrEmpty(PageSize) == false)
            {
                int intPageSize = int.Parse(PageSize);
                gvDataBaseModuleRela.PageSize = intPageSize;
            }
            else
            {
                PageSize = "10";
                gvDataBaseModuleRela.PageSize = 10;
            }
            this.gvDataBaseModuleRela.DataSource = objDV;
            //	5����DATAGRID������DataTable��������ʾ��DATAGRID��
            this.gvDataBaseModuleRela.DataBind();

            ///����ר������BindGv�е���ҳ��ش���
            GridViewRow pagerRow = gvDataBaseModuleRela.BottomPagerRow;
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
                lblAllPages.Text = this.gvDataBaseModuleRela.PageCount.ToString();
                //��ǰҳ����
                lblCurrentPage.Text = (this.gvDataBaseModuleRela.PageIndex + 1).ToString();
                //��ǰ����������ҳ����
                txtJump2Page.Text = (this.gvDataBaseModuleRela.PageIndex + 1).ToString();
                //�����ǰҳ����Ϊ0����<ǰһҳ>��ť��Ч
                if (this.gvDataBaseModuleRela.PageIndex == 0)
                {
                    clsPubFun.SetButtonEnabled(btnPrevPage,  false);
                }
                else
                {
                    clsPubFun.SetButtonEnabled(btnPrevPage, true);
                }
                //�����ǰҳ������Ϊ���һҳ����<ǰһҳ>��ť��Ч
                if (this.gvDataBaseModuleRela.PageIndex == this.gvDataBaseModuleRela.PageCount - 1)
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
            gvDataBaseModuleRela.BottomPagerRow.Visible = true;
        }


        ///���ɴ��߼�������ݴ��䵽�����ĺ�������
        /// <summary>
        /// �������ܣ�������������������ʾ��������
        ///ע�⣺��������������򣬲�����һ��������������ϵ�ģ�����Ϊһ��������ֵ��Ȼ����Ϊ����������ֵ
        ///      ������������ݿ�ʱ����Ӧ��һ���ֶ���ǰ�������ֶ��ں�
        /// </summary>
        /// <param name="pobjDataBaseModuleRelaEN">��ʵ�������</param>
        protected void GetDataFromDataBaseModuleRelaClass(clsDataBaseModuleRelaEN pobjDataBaseModuleRelaEN)
        {
            wucDataBaseModuleRelaB1.PrjId = pobjDataBaseModuleRelaEN.PrjId;//    ����ID
            wucDataBaseModuleRelaB1.PrjDataBaseId = pobjDataBaseModuleRelaEN.PrjDataBaseId;//    ��Ŀ���ݿ�Id
            wucDataBaseModuleRelaB1.FuncModuleAgcId = pobjDataBaseModuleRelaEN.FuncModuleAgcId;//    ����ģ��Id
            wucDataBaseModuleRelaB1.IsVisible = pobjDataBaseModuleRelaEN.IsVisible;//    �Ƿ���ʾ
            wucDataBaseModuleRelaB1.Memo = pobjDataBaseModuleRelaEN.Memo;//    ˵��
        }
        /// <summary>
        /// �������ܣ��ѽ����ϵ��������ݴ����������
        /// </summary>
        /// <param name="pobjDataBaseModuleRelaEN">���ݴ����Ŀ�������</param>
        protected void PutDataToDataBaseModuleRelaClass(clsDataBaseModuleRelaEN pobjDataBaseModuleRelaEN)
        {
            pobjDataBaseModuleRelaEN.PrjId = wucDataBaseModuleRelaB1.PrjId;//    ����ID
            pobjDataBaseModuleRelaEN.PrjDataBaseId = wucDataBaseModuleRelaB1.PrjDataBaseId;//    ��Ŀ���ݿ�Id
            pobjDataBaseModuleRelaEN.FuncModuleAgcId = wucDataBaseModuleRelaB1.FuncModuleAgcId;//    ����ģ��Id
            pobjDataBaseModuleRelaEN.IsVisible = wucDataBaseModuleRelaB1.IsVisible;//    �Ƿ���ʾ
            pobjDataBaseModuleRelaEN.Memo = wucDataBaseModuleRelaB1.Memo;//    ˵��
        }

     
        public System.Data.DataTable GetPrjDataBaseId()
        {
            //��ȡĳѧԺ����רҵ��Ϣ
            string strSQL = "select PrjDataBaseId, PrjDataBaseName from PrjDataBase ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindDdl_PrjDataBaseId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //Ϊ����Դ�ڱ����������������
            ListItem li = new ListItem("��ѡ��...", "0");
            System.Data.DataTable objDT = GetPrjDataBaseId();
            objDDL.DataValueField = "PrjDataBaseId";
            objDDL.DataTextField = "PrjDataBaseName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        public System.Data.DataTable GetFuncModuleId()
        {
            //��ȡĳѧԺ����רҵ��Ϣ
            string strSQL = "select FuncModuleAgcId, FuncModuleName from FuncModule_Agc ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindDdl_FuncModuleId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //Ϊ����Դ�ڱ����������������
            ListItem li = new ListItem("��ѡ��...", "0");
            System.Data.DataTable objDT = GetFuncModuleId();
            objDDL.DataValueField = "FuncModuleAgcId";
            objDDL.DataTextField = "FuncModuleName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        ///���ɵĲ����¼׼�����̴���for C#
        protected void AddDataBaseModuleRelaRecord()
        {
            btnOKUpd.Text = "ȷ�����";
            btnCancelDataBaseModuleRelaEdit.Text = "ȡ�����";

            DispEditDataBaseModuleRelaRegion();
        }
        ///�����¼���̹��̴���for C#
        protected bool AddDataBaseModuleRelaRecordSave()
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
            clsDataBaseModuleRelaEN objDataBaseModuleRelaEN;
            //1�����ؼ����������������Ƿ���ȷ
            if (!wucDataBaseModuleRelaB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "�ؼ��������������Ͳ���ȷ����!";
                return false;
            }
            //2��������󲢳�ʼ������
            //clsDataBaseModuleRelaEN objDataBaseModuleRelaEN;	//�������
            objDataBaseModuleRelaEN = new clsDataBaseModuleRelaEN();	//��ʼ���¶���
            ///3.1���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
            //4����ֵ�ӽ���㴫���߼��������ʵ���
            PutDataToDataBaseModuleRelaClass(objDataBaseModuleRelaEN);		//�ѽ����ֵ����
            //5.1����鴫��ȥ�Ķ��������Ƿ�Ϸ�
            try
            {
                clsDataBaseModuleRelaBL.CheckPropertyNew(objDataBaseModuleRelaEN);
                //6��������ʵ�������ݴ��������ݿ���
                clsDataBaseModuleRelaBL.AddNewRecordBySql2(objDataBaseModuleRelaEN);
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
            BindGv_DataBaseModuleRela();
            DispDataBaseModuleRelaListRegion();
            wucDataBaseModuleRelaB1.Clear();		//��տؼ�������
            ///�ָ�<ȷ�����>���<���>
            btnOKUpd.Text = "���";
            btnCancelDataBaseModuleRelaEdit.Text = "ȡ���༭";
            return true;
        }
        ///�����¼���̹��̴���for C#
        protected bool AddDataBaseModuleRelaRecordSaveV5()
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
            clsDataBaseModuleRelaEN objDataBaseModuleRelaEN;
            //1�����ؼ����������������Ƿ���ȷ
            if (!wucDataBaseModuleRelaB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "�ؼ��������������Ͳ���ȷ����!";
                return false;
            }
            //2��������󲢳�ʼ������
            //clsDataBaseModuleRelaEN objDataBaseModuleRelaEN;	//�������
            objDataBaseModuleRelaEN = new clsDataBaseModuleRelaEN();	//��ʼ���¶���
            //3���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
            //4����ֵ�ӽ���㴫���߼��������ʵ���
            PutDataToDataBaseModuleRelaClass(objDataBaseModuleRelaEN);		//�ѽ����ֵ����
            //5.1����鴫��ȥ�Ķ��������Ƿ�Ϸ�
            try
            {
                clsDataBaseModuleRelaBL.CheckPropertyNew(objDataBaseModuleRelaEN);
                //6��������ʵ�������ݴ��������ݿ���
                clsDataBaseModuleRelaBL.AddNewRecordBySql2(objDataBaseModuleRelaEN);
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
            BindGv_DataBaseModuleRela();
            DispDataBaseModuleRelaListRegion();
            wucDataBaseModuleRelaB1.Clear();		//��տؼ�������
            ///�ָ�<ȷ�����>���<���>
            btnOKUpd.Text = "���";
            btnCancelDataBaseModuleRelaEdit.Text = "ȡ���༭";
            return true;
        }
        ///�����޸ļ�¼׼�����̴��� for C#
        protected void UpdateDataBaseModuleRelaRecord(long lngmId)
        {
            //�������裺���ܹ�2����
            //1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
            //2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�

            //1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
            ShowData(lngmId);
            //2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
            clsPubFun.SetButtonEnabled(btnOKUpd, true);
            btnOKUpd.Text = "ȷ���޸�";
            btnCancelDataBaseModuleRelaEdit.Text = "ȡ���޸�";
            lblMsgEdit.Text = "";
            DispEditDataBaseModuleRelaRegion();
        }
        ///�޸Ĵ���׼�����̴��� for C#
        protected bool UpdateDataBaseModuleRelaRecordSave(clsDataBaseModuleRelaEN objDataBaseModuleRelaEN)
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
            if (!wucDataBaseModuleRelaB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "�ؼ��������������Ͳ���ȷ����!";
                return false;
            }
            //2����ֵ�ӽ���㴫���߼��������ʵ���
            PutDataToDataBaseModuleRelaClass(objDataBaseModuleRelaEN);		//�ѽ����ֵ����
            ///3.1����鴫��ȥ�Ķ��������Ƿ�Ϸ�
            try
            {
                clsDataBaseModuleRelaBL.CheckPropertyNew(objDataBaseModuleRelaEN);
                //4��������ʵ�������ݴ��������ݿ���
                clsDataBaseModuleRelaBL.UpdateBySql2(objDataBaseModuleRelaEN);
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
            BindGv_DataBaseModuleRela();
            DispDataBaseModuleRelaListRegion();
            wucDataBaseModuleRelaB1.Clear();//��տؼ��е�����
            //�ָ�<ȷ���޸�>���<���>
            btnOKUpd.Text = "���";
            btnCancelDataBaseModuleRelaEdit.Text = "ȡ���༭";
            return true;
        }
        ///�޸Ĵ���׼�����̴��� for C#
        protected bool UpdateDataBaseModuleRelaRecordSaveV5(clsDataBaseModuleRelaEN objDataBaseModuleRelaEN)
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
            if (!wucDataBaseModuleRelaB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "�ؼ��������������Ͳ���ȷ����!";
                return false;
            }
            //2����ֵ�ӽ���㴫���߼��������ʵ���
            PutDataToDataBaseModuleRelaClass(objDataBaseModuleRelaEN);		//�ѽ����ֵ����
            ///3.1����鴫��ȥ�Ķ��������Ƿ�Ϸ�
            try
            {
                clsDataBaseModuleRelaBL.CheckPropertyNew(objDataBaseModuleRelaEN);
                //4��������ʵ�������ݴ��������ݿ���
                clsDataBaseModuleRelaBL.UpdateBySql2(objDataBaseModuleRelaEN);
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
            BindGv_DataBaseModuleRela();
            DispDataBaseModuleRelaListRegion();
            wucDataBaseModuleRelaB1.Clear();//��տؼ��е�����
            //�ָ�<ȷ���޸�>���<���>
            btnOKUpd.Text = "���";
            btnCancelDataBaseModuleRelaEdit.Text = "ȡ���༭";
            return true;
        }
        ///ɾ����¼���̴���for C#
        protected void DeleteDataBaseModuleRelaRecord(long lngmId)
        {
            try
            {
                clsDataBaseModuleRelaBL.DelRecord(lngmId);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_DataBaseModuleRela();
        }

        ///����ר�����ڵ���Excel����ش���
        private void ExportExcel()
        {
            //	1����Ͻ�����������
            string strWhereCond = CombineDataBaseModuleRelaCondition();
            //	2��������������ȡ�ñ�����������DataTable��
            System.Data.DataTable objDT = null;
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "DataBaseModuleRela��Ϣ����.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add("PrjId"); arrCnName.Add("����ID");
            arrColName.Add("PrjName"); arrCnName.Add("��������");
            arrColName.Add("PrjDataBaseId"); arrCnName.Add("��Ŀ���ݿ�Id");
            arrColName.Add("PrjDataBaseName"); arrCnName.Add("��Ŀ���ݿ���");
            arrColName.Add("FuncModuleAgcId"); arrCnName.Add("����ģ��Id");
            arrColName.Add("FuncModuleName"); arrCnName.Add("����ģ������");
            arrColName.Add("FuncModuleEnName"); arrCnName.Add("����ģ��Ӣ������");
            arrColName.Add("OrderNum"); arrCnName.Add("OrderNum");
            arrColName.Add("IsVisible"); arrCnName.Add("�Ƿ���ʾ");
            arrColName.Add("UpdUserId"); arrCnName.Add("�޸��û�Id");
            arrColName.Add("UpdDate"); arrCnName.Add("�޸�����");
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
                objDT = clsvDataBaseModuleRelaBL.GetDataTable(strWhereCond);
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
        private void DispEditDataBaseModuleRelaRegion()
        {
            tabDataBaseModuleRelaGridView.Visible = false;
            tabEditDataBaseModuleRelaRegion.Visible = true;
        }
        private void DispDataBaseModuleRelaListRegion()
        {
            tabDataBaseModuleRelaGridView.Visible = true;
            tabEditDataBaseModuleRelaRegion.Visible = false;
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