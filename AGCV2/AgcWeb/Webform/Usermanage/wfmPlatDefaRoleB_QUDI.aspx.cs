
///----------------------
///���ɴ���汾��2013.04.17.1
///�������ڣ�2014/03/03
///�����ߣ����Է�
///�������ƣ������ߵ�
///����ID��0042
///ģ����������ϵͳ��������
///ģ��Ӣ������SysParameterManage
///ע�⣺1����Ҫ���ݵײ㣨PubDataBase.dll���İ汾��2013.11.06.1
///       2����Ҫ���������㣨TzPubFunction.dll���İ汾��2013.11.08.1
///========================
///���ɲ�ѯ���޸ģ�ɾ������Ӽ�¼�Ŀ��Ʋ����


using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using com.taishsoft.commdb;
using com.taishsoft.common;
using CommFunc4WebForm;

using com.taishsoft.datetime;
using AGC.Entity;

using AGC.BusinessLogic;using AGC.FunClass;



using AGC.BusinessLogicEx;


namespace AGC.Webform
{
    /// <summary>
    /// wfmPlatDefaRoleB_QUDI ��ժҪ˵��������Q�����ѯ��U�����޸�
    /// </summary>
    public partial class wfmPlatDefaRoleB_QUDI : CommWebPageBase
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
        /// <summary>
        /// ͨ��QueryString���ݹ�����UserId��������������������ҿ��Բο����������
        /// ������
        /// ���ڣ�
        /// </summary>
        private string qsUserId
        {
            get
            {
                string strUserId = Request.QueryString["UserId"] ?? "".ToString();
                if ((strUserId != null) && (strUserId != ""))
                {
                    return strUserId;
                }
                else
                {
                    return "";
                }
            }
        }
        protected const string ViewId4Potence = "00260203";		//������


        protected void Page_Load(object sender, System.EventArgs e)
        {
            // �ڴ˴������û������Գ�ʼ��ҳ��
            if (!IsPostBack)	///����������ǳ��α����ã������ǵ�����ť�¼�������
            {

                vsViewName = "ƽ̨Ĭ�Ͻ�ɫά��";
                vsTabName = "vPlatDefaRole";
                //����Ȩ���й��ж�Ȩ�޵Ĵ���
                //���ݵȼ�Ȩ�ޱ����ȷ���û�����ʹ��ʲô���ܣ��ȼ���ŷ�ʽ��1Ϊ���2��Σ���������
                switch (vsPotenceLevel)
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
                wucPlatDefaRoleB1.SetDdl_id_School();
                clsXzSchoolBL.BindDdl_id_School(ddlid_School_q);
                ddlid_School_q.SelectedValue = clsMyConfig.spId_School;
                ddlid_School_q.Enabled = false;
                strSortPlatDefaRoleBy = "mId Asc";
                //2����ʾ�������ı�������DATAGRID��
                BindGv_PlatDefaRole();
                //3�����ñ�ؼ����ֿؼ���ReadOnly���ԣ�
                // ʹֻ֮������Ϊ���޸Ĺ����йؼ����ǲ��ܱ��޸ĵġ�
                DispPlatDefaRoleListRegion();
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
            this.gvPlatDefaRole.PageIndex = 0;
            //�ѱ��¼��������ʾ��DATAGRID��
            BindGv_PlatDefaRole();
        }
        /// <summary>
        /// �������ܣ��¼��������ڸ���DATAGRID�ĵ�ǰҳ����ʱ�����ĺ�����
        ///			 ���幦����������ʾ��ҳ(������ҳ����)�����ݡ�
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void gvPlatDefaRole_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            //�������裺����2����
            //1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
            //2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ

            //1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
            this.gvPlatDefaRole.PageIndex = e.NewPageIndex;
            //2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ
            BindGv_PlatDefaRole();
        }
        /// <summary>
        /// �������ܣ����Ըùؼ��ֵļ�¼������ʾ�ڽ����ϣ�
        ///������ �������ǰ�ֵ������ؼ���
        /// </summary>
        /// <param name="lngmId">���¼�Ĺؼ��֣���ʾ�ñ�ؼ��ֵ�����</param>
        /// <summary>
        /// �������ܣ��¼�������������<ȷ���޸�>ʱ�������¼�������
        /// ���幦��Ϊ�ѽ�������ͬ�����ݿ��У��ѽ������ݱ��浽���ݿ���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOKUpd_Click(object sender, System.EventArgs e)
        {
            string strCommandText;
            clsPlatDefaRoleEN objPlatDefaRoleEN;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "���":
                    AddPlatDefaRoleRecord();
                    break;
                case "ȷ�����":
                    //����һ������Ĳ���Ĵ��룬�����߼���̫�򵥣�
                    //�Ͱ��߼���ϲ������Ʋ�,
                    AddPlatDefaRoleRecordSave();
                    break;
                case "ȷ���޸�":
                    //����һ��������޸ĵĴ��룬�����߼���̫�򵥣�
                    //�Ͱ��߼���ϲ������Ʋ�,
                    objPlatDefaRoleEN = (clsPlatDefaRoleEN)ViewState["objPlatDefaRoleEN"];
                    UpdatePlatDefaRoleRecordSave(objPlatDefaRoleEN);
                    break;
            }
        }

        ///����¼�¼���¼����̣������ڸù����е���������������Ҫ��������Ӷ��д��롣
        protected void btnAddNewRec4Gv_Click(object sender, System.EventArgs e)
        {
            AddPlatDefaRoleRecord();
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
            List<string> lstKeyValues = clsCommForWebForm.GetAllCheckedItemFromGv(gvPlatDefaRole, "chkCheckRec", "mId");
            if (lstKeyValues.Count == 0)
            {
                lblMsg_List.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
                return;
            }
            lblMsg_List.Text = "";
            try
            {
                foreach (string strKeyValue in lstKeyValues)
                {
                    string[] strKeys = strKeyValue.Split(',');
                    long lngmId = long.Parse(strKeys[0]);
                    clsPlatDefaRoleBL.DelRecord(lngmId);
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_PlatDefaRole();
        }

        /// <summary>
        ///�޸ĵ�ǰ��ѡ��¼
        /// </summary>
        protected void btnUpdate4Gv_Click(object sender, System.EventArgs e)
        {
            List<string> lstKeyValue = clsCommForWebForm.GetFirstCheckedItemFromGv(gvPlatDefaRole, "mId");
            if (lstKeyValue.Count == 0)
            {
                lblMsg_List.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
                return;
            }
            lblMsg_List.Text = "";
            //1����ʾ�ùؼ��ֵ��������û��޸ĸùؼ��ּ�¼��
            string[] strKeys = lstKeyValue[0].Split(',');
            long lngmId = long.Parse(strKeys[0]);
            UpdatePlatDefaRoleRecord(lngmId);
        }

        /// <summary>
        ///���õ�ǰ�û���Excel�����ֶ�
        /// </summary>
        protected void btnSetExportExcel4User_Click(object sender, EventArgs e)
        {
            clsExportExcelSetENEx objExportExcelSetENEx = new clsExportExcelSetENEx();
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("ViewName='{0}'", vsViewName);//��ǰ����
            sbCondition.AppendFormat(" And TabName='{0}'", vsTabName);//��ǰ������ʹ�õı�
            sbCondition.AppendFormat(" And UserId='{0}'", clsCommonSession.UserId);//��ǰ�û�
            //����������ȡExcel����Id
            string strid_ExportExcel4Users = clsExportExcelSetBL.GetFirstID_S(sbCondition.ToString());
            if (string.IsNullOrEmpty(strid_ExportExcel4Users) == true)
            {
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.AppendFormat("��ϵͳ��û�н���Ϊ'{0}'", vsViewName);
                sbMsg.AppendFormat("������='{0}'", vsTabName);
                sbMsg.AppendFormat("�����û�='{0}'�ĵ���Excel�û����ã����ȵ���һ��Excel���ٲ��п������Ա��ϵ��", clsCommonSession.UserId);
                clsCommonJsFunc.Alert(this, sbMsg.ToString());
                return;
            }
            //��������Excel�ֶν����������
            StringBuilder sbScript = new StringBuilder();
            sbScript.Append("<script language='javascript'>");
            sbScript.Append("window.open('");
            sbScript.AppendFormat("../SysManage/wfmExportExcel4UsersB_QUDI.aspx?Id_ExportExcel4Users={0}", strid_ExportExcel4Users);
            sbScript.Append("','_blank', 'left=50px,top=50px,status=no,width=920px,height=650px,scrollbars=yes'); </script>");
            Page.ClientScript.RegisterStartupScript(this.GetType(), "����Excel�ֶ�����", sbScript.ToString());
    
        }
        protected void gvPlatDefaRole_Sorting(object sender, GridViewSortEventArgs e)
        {
            int intIndex;
            //�ж��Ƿ����µ������ֶ�
            intIndex = strSortPlatDefaRoleBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                strSortPlatDefaRoleBy = e.SortExpression + " Asc";
                BindGv_PlatDefaRole();
                return;
            }
            //���ԭ��������
            intIndex = strSortPlatDefaRoleBy.IndexOf(" Asc");
            if (intIndex == -1)		//���ԭ���������������Ϊ����
            {
                strSortPlatDefaRoleBy = e.SortExpression + " Asc";
            }
            else			///��������Ϊ����
            {
                strSortPlatDefaRoleBy = e.SortExpression + " Desc";
            }
            BindGv_PlatDefaRole();
        }

        /// <summary>
        /// ���ڼ�¼GridView�еĵ�ǰ������ʽ���Ա������һ�������򣬻��ǽ�������
        /// </summary>
        protected string strSortPlatDefaRoleBy
        {
            get
            {
                string sSortPlatDefaRoleBy;
                sSortPlatDefaRoleBy = (string)ViewState["SortPlatDefaRoleBy"];
                if (sSortPlatDefaRoleBy == null)
                {
                    sSortPlatDefaRoleBy = "";
                }
                return sSortPlatDefaRoleBy;
            }
            set
            {
                string sSortPlatDefaRoleBy = value;
                ViewState.Add("SortPlatDefaRoleBy", sSortPlatDefaRoleBy);
            }
        }

        ///��������ҳ����غ���
        protected void btnJumpPage_Click(object sender, EventArgs e)
        {
            GridViewRow pagerRow = gvPlatDefaRole.BottomPagerRow;
            TextBox txtJump2Page = (TextBox)pagerRow.FindControl("txtJump2Page");
            if (txtJump2Page != null)
            {
                if (txtJump2Page.Text.Trim() != "" &&
                int.Parse(txtJump2Page.Text) > 0 &&
                int.Parse(txtJump2Page.Text) - 1 < this.gvPlatDefaRole.PageCount)
                {
                    this.gvPlatDefaRole.PageIndex = int.Parse(txtJump2Page.Text) - 1;
                }
                this.BindGv_PlatDefaRole();
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
                    BindGv_PlatDefaRole();
                }
            }
        }

        ///����GridView��������¼�����
        protected void gvPlatDefaRole_RowCommand(object sender, GridViewCommandEventArgs e)
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
                        clsCommForWebForm.Set_GridViewAllChecked(gvPlatDefaRole, true);
                        lbSelAll.Text = "��ѡ";
                    }
                    else if (lbSelAll.Text == "��ѡ")
                    {
                        clsCommForWebForm.Set_GridViewAllChecked(gvPlatDefaRole, false);
                        lbSelAll.Text = "ȫѡ";
                    }
                    break;
            }
        }
        ///ɾ����¼���̴���for C#
        protected void gvPlatDefaRole_RowCreated(object sender, GridViewRowEventArgs e)
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
            if (strSortPlatDefaRoleBy == "") return;
            if (e.Row.RowType == DataControlRowType.Header)//����ؼ��Ƿ�Ϊҳü��
            {
                string strSortEx;
                for (int i = 0; i < this.gvPlatDefaRole.Columns.Count; i++)
                {
                    strSortEx = this.gvPlatDefaRole.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = strSortPlatDefaRoleBy.IndexOf(strSortEx);
                    if (intIndex >= 0) //��ͼ״̬��������ʽ�Ƿ�Ϊ���е��ֶΣ�
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//�������壬��"webdings"��5�������ǣ�6�������ǣ�
                        intIndex = strSortPlatDefaRoleBy.IndexOf("Asc");
                        lblSort.Text = (intIndex > 0 ? " 5" : " 6");//�Ƿ�Ϊ���򣬶���Ϊstring�ͣ�
                        e.Row.Cells[i].Controls.Add(lblSort);//��������ĵ�i����Ԫ��������һ�ؼ���
                        break;
                    }
                }
            }
        }

        ///
        protected void gvPlatDefaRole_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string strmId = gvPlatDefaRole.DataKeys[e.RowIndex]["mId"].ToString();
            long lngmId = long.Parse(strmId);
            DeletePlatDefaRoleRecord(lngmId);
        }
        ///
        protected void gvPlatDefaRole_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string strmId = gvPlatDefaRole.DataKeys[e.RowIndex]["mId"].ToString();
            long lngmId = long.Parse(strmId);
            UpdatePlatDefaRoleRecord(lngmId);
        }
        ///ɾ����¼���̴���for C#
        protected void gvPlatDefaRole_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            if (e.NewPageIndex != -1)
            {
                gvPlatDefaRole.PageIndex = e.NewPageIndex;
                this.BindGv_PlatDefaRole();
            }
        }
        ///
        protected void btnCancelPlatDefaRoleEdit_Click(object sender, EventArgs e)
        {
            DispPlatDefaRoleListRegion();
        }

    }
    public partial class wfmPlatDefaRoleB_QUDI : CommWebPageBase
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
            if (clsPlatDefaRoleBL.IsExist(lngmId) == false)		//���ùؼ��ֵļ�¼�Ƿ����
            {
                string ss = "�ؼ���Ϊ��" + lngmId + "�Ĳ�����!";
                clsCommonJsFunc.Alert(this, ss);
                return;
            }
            //3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
            clsPlatDefaRoleEN objPlatDefaRoleEN = new clsPlatDefaRoleEN(lngmId);
            //4����ȡ�������������ԣ�
            try
            {
                clsPlatDefaRoleBL.GetPlatDefaRole(ref objPlatDefaRoleEN);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            ViewState.Add("objPlatDefaRoleEN", objPlatDefaRoleEN);
            //5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���
            GetDataFromPlatDefaRoleClass(objPlatDefaRoleEN);
        }

        //����Ȩ�޵ȼ�������
        protected string vsPotenceLevel
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
        /// �����еĲ�ѯ�ؼ�������ϳ�һ��������
        /// </summary>
        /// <returns>������(strWhereCond)</returns>
        protected string CombinePlatDefaRoleCondition()
        {
            //ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
            //���� 1=1 && UserName = '����'
            string strWhereCond = " 1=1 ";
            //����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
            if (this.ddlid_School_q.SelectedValue != "" && this.ddlid_School_q.SelectedValue != "0")
            {
                strWhereCond += " And id_School='" + this.ddlid_School_q.SelectedValue + "'";
            }
            if (this.txtPersonType_q.Text.Trim() != "")
            {
                strWhereCond += " And PersonType like '%" + this.txtPersonType_q.Text.Trim() + "%'";
            }
            if (this.txtPrjId_q.Text.Trim() != "")
            {
                strWhereCond += " And PrjId like '%" + this.txtPrjId_q.Text.Trim() + "%'";
            }
            return strWhereCond;
        }
        ///���ɰ�GridView�Ĵ���
        /// <summary>
        /// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
        ///			 ����ʾ��GridView�С�
        /// </summary>
        protected void BindGv_PlatDefaRole()
        {
            //�������裺(��5��)
            //	1����Ͻ�����������
            //	2��������������ȡ�ñ�����������DataTable��
            //	4������GridView������Դ(DataSource)��
            //	5����GridView������DataTable��������ʾ��DATAGRID��
            //	6�����ü�¼����״̬��
            //		�ڱ��������ǰ�״̬��ʾ�ڿؼ�txtRecCount�С�

            //	1����Ͻ�����������
            string strWhereCond = CombinePlatDefaRoleCondition();
            //	2��������������ȡ�ñ�����������DataTable��
            System.Data.DataTable objDT = null;
            try
            {
                objDT = clsvPlatDefaRoleBL.GetDataTable(strWhereCond);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "��ȡ���ݱ�(DataTable)���ɹ�!" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            //	4������GRIDView������Դ(DataSource)��
            DataView objDV = objDT.DefaultView;
            objDV.Sort = strSortPlatDefaRoleBy; ///ע����һ�д����п�����Ҫע�͵���Ŀǰ���н����ڵ����Ĳ�ѯ������������
            ///����GridView��ÿҳ�ļ�¼��
            if (string.IsNullOrEmpty(PageSize) == false)
            {
                int intPageSize = int.Parse(PageSize);
                gvPlatDefaRole.PageSize = intPageSize;
            }
            else
            {
                PageSize = "10";
                gvPlatDefaRole.PageSize = 10;
            }
            this.gvPlatDefaRole.DataSource = objDV;
            //	5����DATAGRID������DataTable��������ʾ��DATAGRID��
            this.gvPlatDefaRole.DataBind();

            ///����ר������BindGv�е���ҳ��ش���
            GridViewRow pagerRow = gvPlatDefaRole.BottomPagerRow;
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
                lblAllPages.Text = this.gvPlatDefaRole.PageCount.ToString();
                //��ǰҳ����
                lblCurrentPage.Text = (this.gvPlatDefaRole.PageIndex + 1).ToString();
                //��ǰ����������ҳ����
                txtJump2Page.Text = (this.gvPlatDefaRole.PageIndex + 1).ToString();
                //�����ǰҳ����Ϊ0����<ǰһҳ>��ť��Ч
                if (this.gvPlatDefaRole.PageIndex == 0)
                {
                     clsPubFun.SetButtonEnabledInPager(btnPrevPage, false);
                }
                else
                {
                     clsPubFun.SetButtonEnabledInPager(btnPrevPage, true);
                }
                //�����ǰҳ������Ϊ���һҳ����<ǰһҳ>��ť��Ч
                if (this.gvPlatDefaRole.PageIndex == this.gvPlatDefaRole.PageCount - 1)
                {
                     clsPubFun.SetButtonEnabledInPager(btnNextPage, false);
                }
                else
                {
                     clsPubFun.SetButtonEnabledInPager(btnNextPage, true);
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
            gvPlatDefaRole.BottomPagerRow.Visible = true;
        }


        ///���ɴ��߼�������ݴ��䵽�����ĺ�������
        /// <summary>
        /// �������ܣ�������������������ʾ��������
        ///ע�⣺��������������򣬲�����һ��������������ϵ�ģ�����Ϊһ��������ֵ��Ȼ����Ϊ����������ֵ
        /// ������������ݿ�ʱ����Ӧ��һ���ֶ���ǰ�������ֶ��ں�
        /// </summary>
        /// <param name="pobjPlatDefaRoleEN">��ʵ�������</param>
        protected void GetDataFromPlatDefaRoleClass(clsPlatDefaRoleEN pobjPlatDefaRoleEN)
        {
            wucPlatDefaRoleB1.id_School = pobjPlatDefaRoleEN.id_School;// ѧУ��ˮ��
            wucPlatDefaRoleB1.PersonType = pobjPlatDefaRoleEN.PersonType;// ��Ա���
            wucPlatDefaRoleB1.PrjId = pobjPlatDefaRoleEN.QxPrjId;// ����Id
            wucPlatDefaRoleB1.RoleID = pobjPlatDefaRoleEN.RoleId;// ��ɫID
            wucPlatDefaRoleB1.Memo = pobjPlatDefaRoleEN.Memo;// ��ע
        }
        /// <summary>
        /// �������ܣ��ѽ����ϵ��������ݴ����������
        /// </summary>
        /// <param name="pobjPlatDefaRoleEN">���ݴ����Ŀ�������</param>
        protected void PutDataToPlatDefaRoleClass(clsPlatDefaRoleEN pobjPlatDefaRoleEN)
        {
            pobjPlatDefaRoleEN.id_School = wucPlatDefaRoleB1.id_School;// ѧУ��ˮ��
            pobjPlatDefaRoleEN.PersonType = wucPlatDefaRoleB1.PersonType;// ��Ա���
            pobjPlatDefaRoleEN.QxPrjId = wucPlatDefaRoleB1.PrjId;// ����Id
            pobjPlatDefaRoleEN.RoleId = wucPlatDefaRoleB1.RoleID;// ��ɫID
            pobjPlatDefaRoleEN.Memo = wucPlatDefaRoleB1.Memo;// ��ע
        }

        public System.Data.DataTable Getid_School()
        {
            //��ȡĳѧԺ����רҵ��Ϣ
            string strSQL = "select id_School, SchoolName from XzSchool ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindDdl_id_School(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //Ϊ����Դ�ڱ����������������
            ListItem li = new ListItem("��ѡ��...", "0");
            System.Data.DataTable objDT = Getid_School();
            objDDL.DataValueField = "id_School";
            objDDL.DataTextField = "SchoolName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        ///���ɵĲ����¼׼�����̴���for C#
        protected void AddPlatDefaRoleRecord()
        {
            btnOKUpd.Text = "ȷ�����";
            btnCancelPlatDefaRoleEdit.Text = "ȡ�����";

            wucPlatDefaRoleB1.id_School = clsMyConfig.spId_School;

            DispEditPlatDefaRoleRegion();
        }
        ///�����¼���̹��̴���for C#
        protected bool AddPlatDefaRoleRecordSave()
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
            clsPlatDefaRoleEN objPlatDefaRoleEN;
            //1�����ؼ����������������Ƿ���ȷ
            if (!wucPlatDefaRoleB1.IsValid(ref strResult))
            {
                lblMsg_Edit.Text = "�ؼ��������������Ͳ���ȷ����!";
                return false;
            }
            //2��������󲢳�ʼ������
            //clsPlatDefaRoleEN objPlatDefaRoleEN;	//�������
            objPlatDefaRoleEN = new clsPlatDefaRoleEN();	//��ʼ���¶���
            ///3.1���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
            //4����ֵ�ӽ���㴫���߼��������ʵ���
            PutDataToPlatDefaRoleClass(objPlatDefaRoleEN);		//�ѽ����ֵ����
            //5.1����鴫��ȥ�Ķ��������Ƿ�Ϸ�
            try
            {
                clsPlatDefaRoleBL.CheckPropertyNew(objPlatDefaRoleEN);
                /////5.2�����Ψһ��
                //if (clsPlatDefaRoleBL.CheckPersonTypeUniqueness(objPlatDefaRoleEN) == false)
                //{
                //    strMsg = "��Ա���(PersonType)�����ظ���";
                //     clsCommonJsFunc.Alert(this, strMsg);
                //    return false;
                //}
                /////5.2�����Ψһ��
                //if (clsPlatDefaRoleBL.CheckPrjIdUniqueness(objPlatDefaRoleEN) == false)
                //{
                //    strMsg = "����Id(PrjId)�����ظ���";
                //     clsCommonJsFunc.Alert(this, strMsg);
                //    return false;
                //}
                /////5.2�����Ψһ��
                //if (clsPlatDefaRoleBL.CheckRoleIDUniqueness(objPlatDefaRoleEN) == false)
                //{
                //    strMsg = "��ɫID(RoleID)�����ظ���";
                //     clsCommonJsFunc.Alert(this, strMsg);
                //    return false;
                //}
                //6��������ʵ�������ݴ��������ݿ���
                clsPlatDefaRoleBL.AddNewRecordBySql2(objPlatDefaRoleEN);
            }
            catch (Exception objException)
            {
                strMsg = "��Ӽ�¼���ɹ�!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsg_Edit.Text = strMsg;
                return false;
            }
            strMsg = "��Ӽ�¼�ɹ�!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsg_Edit.Text = "��Ӽ�¼�ɹ�!";
            //7��������ļ�¼������ʾ��DATAGRID��
            BindGv_PlatDefaRole();
            DispPlatDefaRoleListRegion();
            wucPlatDefaRoleB1.Clear();		//��տؼ�������
            ///�ָ�<ȷ�����>���<���>
            btnOKUpd.Text = "���";
            btnCancelPlatDefaRoleEdit.Text = "ȡ���༭";
            return true;
        }
       ///�����޸ļ�¼׼�����̴��� for C#
        protected void UpdatePlatDefaRoleRecord(long lngmId)
        {
            //�������裺���ܹ�2����
            //1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
            //2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�

            //1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
            ShowData(lngmId);
            //2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
             clsPubFun.SetButtonEnabled(btnOKUpd, true);
            btnOKUpd.Text = "ȷ���޸�";
            btnCancelPlatDefaRoleEdit.Text = "ȡ���޸�";
            lblMsg_Edit.Text = "";
            DispEditPlatDefaRoleRegion();
        }
        ///�޸Ĵ���׼�����̴��� for C#
        protected bool UpdatePlatDefaRoleRecordSave(clsPlatDefaRoleEN objPlatDefaRoleEN)
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
            if (!wucPlatDefaRoleB1.IsValid(ref strResult))
            {
                lblMsg_Edit.Text = "�ؼ��������������Ͳ���ȷ����!";
                return false;
            }
            //2����ֵ�ӽ���㴫���߼��������ʵ���
            PutDataToPlatDefaRoleClass(objPlatDefaRoleEN);		//�ѽ����ֵ����
            ///3.1����鴫��ȥ�Ķ��������Ƿ�Ϸ�
            try
            {
                clsPlatDefaRoleBL.CheckPropertyNew(objPlatDefaRoleEN);
                ///3.2�����Ψһ��
                if (clsPlatDefaRoleBLEx.CheckRoleIDAndPrjIdPersonTypeUniqueness(objPlatDefaRoleEN) == false)
                {
                    strMsg = "��Ա���(PersonType),����Id(PrjId),��ɫID(RoleID)�����ظ���";
                     clsCommonJsFunc.Alert(this, strMsg);
                    return false;
                }
              
                //4��������ʵ�������ݴ��������ݿ���
                clsPlatDefaRoleBL.UpdateBySql2(objPlatDefaRoleEN);
            }
            catch (Exception objException)
            {
                strMsg = "�޸ļ�¼���ɹ�!" + objException.Message;
                 clsCommonJsFunc.Alert(this, strMsg);
                lblMsg_Edit.Text = strMsg;
                return false;
            }
            strMsg = "�޸ļ�¼�ɹ�!";
             clsCommonJsFunc.Alert(this, strMsg);
            lblMsg_Edit.Text = "�޸ļ�¼�ɹ�!";
            //5�����޸ĺ��������ʾ��DATAGRID��
            BindGv_PlatDefaRole();
            DispPlatDefaRoleListRegion();
            wucPlatDefaRoleB1.Clear();//��տؼ��е�����
            //�ָ�<ȷ���޸�>���<���>
            btnOKUpd.Text = "���";
            btnCancelPlatDefaRoleEdit.Text = "ȡ���༭";
            return true;
        }
        ///ɾ����¼���̴���for C#
        protected void DeletePlatDefaRoleRecord(long lngmId)
        {
            try
            {
                clsPlatDefaRoleBL.DelRecord(lngmId);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_PlatDefaRole();
        }

        ///����ר�����ڵ���Excel����ش���
        private void ExportExcel()
        {
            //	1����Ͻ�����������
            string strWhereCond = CombinePlatDefaRoleCondition();
            //	2��������������ȡ�ñ�����������DataTable��
            System.Data.DataTable objDT = null;
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "PlatDefaRole��Ϣ����.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add("id_School"); arrCnName.Add("ѧУ��ˮ��");
            arrColName.Add("SchoolId"); arrCnName.Add("ѧУId");
            arrColName.Add("IsCurrentUse"); arrCnName.Add("�Ƿ�ǰʹ��");
            arrColName.Add("SchoolName"); arrCnName.Add("ѧУ����");
            arrColName.Add("PersonType"); arrCnName.Add("��Ա���");
            arrColName.Add("PrjId"); arrCnName.Add("����Id");
            arrColName.Add("RoleID"); arrCnName.Add("��ɫID");
            arrColName.Add("Memo"); arrCnName.Add("��ע");
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
                string[] strTabAttributeName = clsvPlatDefaRoleEN.AttributeName;
                clsExportExcelSetBLEx.GetExportExcelSetInfo( strTabAttributeName, new clsTranslateFieldName(), ref objExportExcelSetENEx);
                strFileName = objExportExcelSetENEx.ExportFileName;//����Excel���ļ���
                arrCnName = objExportExcelSetENEx.arrCnName;//�����ֶ�����Ҳ��Excel�ļ��еı�����
                arrColName = objExportExcelSetENEx.arrColName;//���ݱ������
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
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
                objDT = clsvPlatDefaRoleBL.GetDataTable(strWhereCond);
                //�û�Odbc�ķ�ʽ������Excel,��Web����������Ҫ��װExcel,Ŀǰ��Excel2003,���ϣ��2007�����Ի�����һ����䡣
                GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4Odbc(objDT, arrColName, arrCnName, strDownLoadFileName);
                //GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4OdbcExcel2007(objDT, arrColName, arrCnName, strDownLoadFileName);
                //GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr1(objDT, arrColName, arrCnName, strDownLoadFileName);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            clsCommForWebForm.DownLoadFile(strDownLoadFileName);
        }
        private void DispEditPlatDefaRoleRegion()
        {
            tabPlatDefaRoleGridView.Visible = false;
            tabEditPlatDefaRoleRegion.Visible = true;
        }
        private void DispPlatDefaRoleListRegion()
        {
            tabPlatDefaRoleGridView.Visible = true;
            tabEditPlatDefaRoleRegion.Visible = false;
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