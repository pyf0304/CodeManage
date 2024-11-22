
///----------------------
///���ɴ���汾��2013.04.17.1
///�������ڣ�2013/05/30
///�����ߣ�������
///�������ƣ�̩��˾��ҳ
///����ID��0025
///ģ����������̩�����
///ģ��Ӣ������tzedu
///ע�⣺1����Ҫ���ݵײ㣨PubDataBase.dll���İ汾��2013.04.05.3
///       2����Ҫ���������㣨TzPubFunction.dll���İ汾��2013.03.18.1
///========================
///���ɲ�ѯ���޸ģ�ɾ������Ӽ�¼�Ŀ��Ʋ����

///���ɿ��Ʋ�Ŀؼ��������б�
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


using AGC.Entity;
using AGC.BusinessLogic;

using com.taishsoft.datetime;
using AGC.FunClass;
using AGC.BusinessLogicEx;

namespace CompanyPage.Webform
{
    /// <summary>
    /// wfmNewsB_QUDI ��ժҪ˵��������Q�����ѯ��U�����޸�
    /// </summary>
    public partial class wfmNewsB_QUDI : System.Web.UI.Page
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

                vsViewName = "��ѯ��ά��";
                vsTabName = "vNews";
                //����Ȩ���й��ж�Ȩ�޵Ĵ���
                //���ݵȼ�Ȩ�ޱ����ȷ���û�����ʹ��ʲô���ܣ��ȼ���ŷ�ʽ��1Ϊ���2��Σ���������
                switch (strPotenceLevel)
                {
                    case "0":
                        Response.Redirect("../error.aspx");
                        break;
                    case "1":
                        Response.Redirect("../error.aspx");
                        break;
                    case "2":
                        Response.Redirect("../error.aspx");
                        break;
                    case "3":
                        Response.Redirect("../error.aspx");
                        break;
                    case "4":
                        Response.Redirect("../error.aspx");
                        break;
                    case "9":
                        break;
                    default:
                        Response.Redirect("../error.aspx");
                        break;
                }
                //clsCommonSession.UserId = "lyl";
                //clsCommonSession.UserName = "������";
                clsCommonSession.UserRightsId = "3";

                CheckLoginWorking();

                //1��Ϊ��������������Դ�����б�����
                wucNewsB1.SetDdl_NewsTypeId();
                BindDdl_NewsTypeId(ddlNewsTypeIdq);
                //strSortNewsBy = "NewsTitle Asc";
                //2����ʾ�������ı�������DATAGRID��
                BindGv_News();
                //3�����ñ�ؼ����ֿؼ���ReadOnly���ԣ�
                //   ʹֻ֮������Ϊ���޸Ĺ����йؼ����ǲ��ܱ��޸ĵġ�
                DispNewsListRegion();
            }
        }


        /// <summary>
        /// Ȩ�޹���
        /// </summary>
        protected void CheckLoginWorking()
        {
            if (clsCommonSession.UserId == "")
            {
                clsCommonSession.seErrMessage = "1";
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            else
            {
                //clsCommonSession clsCommonSession = new clsCommonSession();
                if (!string.IsNullOrEmpty(clsCommonSession.UserRightsId))
                {
                    //����Ա
                    if (clsCommonSession.UserRightsId == "1")
                    {
                        this.btnDelete4Gv.Visible = false;
                        //this.btnSetExportExcel4User.Visible = false;
                        this.btnUpdate4Gv.Visible = false;
                        //this.delete.Visible = false;
                        //this.edit.Visible = false;
                        //this.tool.Visible = false;
                    }
                    //����Ա
                    else if (clsCommonSession.UserRightsId == "2")
                    {
                        this.btnDelete4Gv.Visible = false;
                        //this.delete.Visible = false;
                    }
                    //��������Ա
                    else if (clsCommonSession.UserRightsId == "3")
                    {
                        
                    }
                }
              
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
            this.gvNews.PageIndex = 0;
            //�ѱ��¼��������ʾ��DATAGRID��
            BindGv_News();
        }
        /// <summary>
        /// �������ܣ��¼��������ڸ���DATAGRID�ĵ�ǰҳ����ʱ�����ĺ�����
        ///			  ���幦����������ʾ��ҳ(������ҳ����)�����ݡ�
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void gvNews_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            //�������裺����2����
            //1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
            //2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ

            //1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
            this.gvNews.PageIndex = e.NewPageIndex;
            //2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ
            BindGv_News();
        }
        /// <summary>
        /// �������ܣ����Ըùؼ��ֵļ�¼������ʾ�ڽ����ϣ�
        ///������     �������ǰ�ֵ������ؼ���
        /// </summary>
        /// <param name="intId_News">���¼�Ĺؼ��֣���ʾ�ñ�ؼ��ֵ�����</param>
        /// <summary>
        /// �������ܣ��¼�������������<ȷ���޸�>ʱ�������¼�������
        ///           ���幦��Ϊ�ѽ�������ͬ�����ݿ��У��ѽ������ݱ��浽���ݿ���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOKUpd_Click(object sender, System.EventArgs e)
        {
            string strCommandText;
            clsNewsEN objNewsEN;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "���":
                    AddNewsRecord();
                    break;
                case "ȷ�����":
                    //����һ������Ĳ���Ĵ��룬�����߼���̫�򵥣�
                    //�Ͱ��߼���ϲ������Ʋ�,
                    AddNewsRecordSave();
                    break;
                case "ȷ���޸�":
                    //����һ��������޸ĵĴ��룬�����߼���̫�򵥣�
                    //�Ͱ��߼���ϲ������Ʋ�,
                    objNewsEN = (clsNewsEN)Session["objNewsEN"];
                    UpdateNewsRecordSave(objNewsEN);
                    break;
            }
        }

        ///����¼�¼���¼����̣������ڸù����е���������������Ҫ��������Ӷ��д��롣
        protected void btnAddNewRec4Gv_Click(object sender, System.EventArgs e)
        {
            AddNewsRecord();
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
            List<string> lstKeyValues = clsCommForWebForm.GetAllCheckedItemFromGv(gvNews, "chkCheckRec", "Id_News");
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
                    int intId_News = int.Parse(strKeys[0]);
                    clsNewsBL.DelRecord(intId_News);
                }
            }
            catch (Exception objException)
            {
                ErrMessage = objException.Message;
                BackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            BindGv_News();
        }

        /// <summary>
        ///�޸ĵ�ǰ��ѡ��¼
        /// </summary>
        protected void btnUpdate4Gv_Click(object sender, System.EventArgs e)
        {
            List<string> lstKeyValue = clsCommForWebForm.GetFirstCheckedItemFromGv(gvNews, "Id_News");
            if (lstKeyValue.Count == 0)
            {
                lblMsgList.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
                return;
            }
            lblMsgList.Text = "";
            //1����ʾ�ùؼ��ֵ��������û��޸ĸùؼ��ּ�¼��
            string[] strKeys = lstKeyValue[0].Split(',');
            int intId_News = int.Parse(strKeys[0]);
            UpdateNewsRecord(intId_News);
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
            string strIdExportExcel4Users = clsExportExcelSetBL.GetFirstID_S(sbCondition.ToString());
            if (string.IsNullOrEmpty(strIdExportExcel4Users) == true)
            {
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.AppendFormat("��ϵͳ��û�н���Ϊ'{0}'", vsViewName);
                sbMsg.AppendFormat("������='{0}'", vsTabName);
                sbMsg.AppendFormat("�����û�='{0}'�ĵ���Excel�û����ã��������Ա��ϵ��", clsCommonSession.UserId);
                clsCommonJsFunc.Alert(this, sbMsg.ToString());
                return;
            }
            //��������Excel�ֶν����������
            StringBuilder sbScript = new StringBuilder();
            sbScript.Append("<script language='javascript'>");
            sbScript.Append("window.open('");
            sbScript.AppendFormat("../SysManage/wfmExportExcel4UsersB_QUDI.aspx?Id_ExportExcel4Users={0}", strIdExportExcel4Users);
            sbScript.Append("','_blank', 'left=50px,top=50px,status=no,width=920px,height=650px,scrollbars=yes'); </script>");
            Page.ClientScript.RegisterStartupScript(this.GetType(), "����Excel�ֶ�����", sbScript.ToString());
            //            Response.Write(sbScript.ToString());
        }
        protected void gvNews_Sorting(object sender, GridViewSortEventArgs e)
        {
            int intIndex;
            //�ж��Ƿ����µ������ֶ�
            intIndex = strSortNewsBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                strSortNewsBy = e.SortExpression + " Asc";
                BindGv_News();
                return;
            }
            //���ԭ��������
            intIndex = strSortNewsBy.IndexOf(" Asc");
            if (intIndex == -1)		//���ԭ���������������Ϊ����
            {
                strSortNewsBy = e.SortExpression + " Asc";
            }
            else			///��������Ϊ����
            {
                strSortNewsBy = e.SortExpression + " Desc";
            }
            BindGv_News();
        }

        /// <summary>
        /// ���ڼ�¼GridView�еĵ�ǰ������ʽ���Ա������һ�������򣬻��ǽ�������
        /// </summary>
        protected string strSortNewsBy
        {
            get
            {
                string sSortNewsBy;
                sSortNewsBy = (string)ViewState["SortNewsBy"];
                if (sSortNewsBy == null)
                {
                    sSortNewsBy = "";
                }
                return sSortNewsBy;
            }
            set
            {
                string sSortNewsBy = value;
                ViewState.Add("SortNewsBy", sSortNewsBy);
            }
        }

        ///��������ҳ����غ���
        protected void btnJumpPage_Click(object sender, EventArgs e)
        {
            GridViewRow pagerRow = gvNews.BottomPagerRow;
            TextBox txtJump2Page = (TextBox)pagerRow.FindControl("txtJump2Page");
            if (txtJump2Page != null)
            {
                if (txtJump2Page.Text.Trim() != "" &&
                int.Parse(txtJump2Page.Text) > 0 &&
                int.Parse(txtJump2Page.Text) - 1 < this.gvNews.PageCount)
                {
                    this.gvNews.PageIndex = int.Parse(txtJump2Page.Text) - 1;
                }
                this.BindGv_News();
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
                    BindGv_News();
                }
            }
        }

        ///����GridView��������¼�����
        protected void gvNews_RowCommand(object sender, GridViewCommandEventArgs e)
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
                        clsCommForWebForm.Set_GridViewAllChecked(gvNews, true);
                        lbSelAll.Text = "��ѡ";
                    }
                    else if (lbSelAll.Text == "��ѡ")
                    {
                        clsCommForWebForm.Set_GridViewAllChecked(gvNews, false);
                        lbSelAll.Text = "ȫѡ";
                    }
                    break;
            }

            if (e.CommandName == "ibtnTop")
            {
                GridViewRow drv = ((GridViewRow)(((ImageButton)(e.CommandSource)).Parent.Parent)); //�˵ó���ֵ�Ǳ�ʾ���б�ѡ�е�����ֵ
                int intid_New = Convert.ToInt32(gvNews.DataKeys[drv.RowIndex].Value); //�˻�ȡ��ֵΪGridView�а����ݿ��е�����ֵ
                clsNewsEN objNews = new clsNewsEN();
                objNews.Id_News = intid_New;
                clsNewsBL.GetNews(ref objNews);
                bool isTop = objNews.IsTop;

                if (isTop == true)
                {
                    clsNewsBL.UpdateBySql2(GetNewsEN((int)intid_New, false));
                }
                else
                {
                    clsNewsBL.UpdateBySql2(GetNewsEN((int)intid_New, true));
                }
                BindGv_News();
            }

        }


        private static clsNewsEN GetNewsEN(int intid_New, bool IsTop)
        {
            clsNewsEN objNews = new clsNewsEN();
            objNews.Id_News = intid_New;
            objNews.IsTop = IsTop;
            return objNews;
        }
        ///ɾ����¼���̴���for C#
        protected void gvNews_RowCreated(object sender, GridViewRowEventArgs e)
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
            if (strSortNewsBy == "") return;
            if (e.Row.RowType == DataControlRowType.Header)//����ؼ��Ƿ�Ϊҳü��
            {
                string strSortEx;
                for (int i = 0; i < this.gvNews.Columns.Count; i++)
                {
                    strSortEx = this.gvNews.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = strSortNewsBy.IndexOf(strSortEx);
                    if (intIndex >= 0)  //��ͼ״̬��������ʽ�Ƿ�Ϊ���е��ֶΣ�
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//�������壬��"webdings"��5�������ǣ�6�������ǣ�
                        intIndex = strSortNewsBy.IndexOf("Asc");
                        lblSort.Text = (intIndex > 0 ? " 5" : " 6");//�Ƿ�Ϊ���򣬶���Ϊstring�ͣ�
                        e.Row.Cells[i].Controls.Add(lblSort);//��������ĵ�i����Ԫ��������һ�ؼ���
                        break;
                    }
                }
            }
        }

        ///
        protected void gvNews_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string strid_News = gvNews.DataKeys[e.RowIndex]["Id_News"].ToString();
            int intId_News = int.Parse(strid_News);
            DeleteNewsRecord(intId_News);
        }
        ///
        protected void gvNews_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string strid_News = gvNews.DataKeys[e.RowIndex]["Id_News"].ToString();
            int intId_News = int.Parse(strid_News);
            UpdateNewsRecord(intId_News);
        }
        ///ɾ����¼���̴���for C#
        protected void gvNews_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            if (e.NewPageIndex != -1)
            {
                gvNews.PageIndex = e.NewPageIndex;
                this.BindGv_News();
            }
        }
        ///
        protected void btnCancelNewsEdit_Click(object sender, EventArgs e)
        {
            DispNewsListRegion();
        }

    }
    public partial class wfmNewsB_QUDI : System.Web.UI.Page
    {
        protected void ShowData(int intId_News)
        {
            //�������裺
            //1�����ؼ����Ƿ�Ϊ�գ�
            //2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
            //3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
            //4����ȡ�������������ԣ�
            //5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���

            //1�����ؼ����Ƿ�Ϊ�գ�
            if (intId_News == 0) return;		//����ؼ���Ϊ�վͷ����˳�
            //2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
            if (clsNewsBL.IsExist(intId_News) == false)		//���ùؼ��ֵļ�¼�Ƿ����
            {
                string ss = "�ؼ���Ϊ��" + intId_News + "�Ĳ�����!";
                Response.Write("<script>alert('" + ss + "')</script>");
                return;
            }
            //3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
            clsNewsEN objNewsEN = new clsNewsEN(intId_News);
            //4����ȡ�������������ԣ�
            try
            {
                clsNewsBL.GetNews(ref objNewsEN);
            }
            catch (Exception objException)
            {
                ErrMessage = objException.Message;
                BackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            Session.Add("objNewsEN", objNewsEN);
            //5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���
            GetDataFromNewsClass(objNewsEN);
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


        //���ɵ�¼�û����û���Session
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
        ///protected clsUsers objUser
        ///{
        ///get
        ///{
        ///clsUsers pobjUser;
        ///pobjUser = (clsUsers)Session["objUser"];
        ///if (pobjUser==null) 
        ///{
        ///pobjUser = null;
        ///}
        ///return pobjUser;
        ///}
        ///set
        ///{
        ///clsUsers pobjUser = value;
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
        protected string CombineNewsCondition()
        {
            //ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
            //���� 1=1 && UserName = '����'
            string strWhereCond = " 1=1 ";
            //����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
            if (this.txtNewsTitleq.Text.Trim() != "")
            {
                strWhereCond += " And NewsTitle like '%" + this.txtNewsTitleq.Text.Trim() + "%'";
            }
            if (this.ddlNewsTypeIdq.SelectedValue != "" && this.ddlNewsTypeIdq.SelectedValue != "0")
            {
                strWhereCond += " And NewsTypeId='" + this.ddlNewsTypeIdq.SelectedValue + "'";
            }
            if (this.txtEditPeopleq.Text.Trim() != "")
            {
                strWhereCond += " And EditPeople like '%" + this.txtEditPeopleq.Text.Trim() + "%'";
            }
            if (this.txtEditTimeq.Text.Trim() != "")
            {
                strWhereCond += " And EditTime like '%" + this.txtEditTimeq.Text.Trim() + "%'";
            }
            strWhereCond += " order by IsTop desc,  EditTime desc";
            
            return strWhereCond;
        }
        ///���ɰ�GridView�Ĵ���
        /// <summary>
        /// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
        ///			 ����ʾ��GridView�С�
        /// </summary>
        protected void BindGv_News()
        {
            //�������裺(��5��)
            //	1����Ͻ�����������
            //	2��������������ȡ�ñ�����������DataTable��
            //	4������GridView������Դ(DataSource)��
            //	5����GridView������DataTable��������ʾ��DATAGRID��
            //	6�����ü�¼����״̬��
            //		�ڱ��������ǰ�״̬��ʾ�ڿؼ�txtRecCount�С�

            //	1����Ͻ�����������
            string strWhereCond = CombineNewsCondition();
            //	2��������������ȡ�ñ�����������DataTable��
            System.Data.DataTable objDT = null;
            try
            {
                objDT = clsvNewsBL.GetDataTable(strWhereCond);
            }
            catch (Exception objException)
            {
                ErrMessage = "��ȡ���ݱ�(DataTable)���ɹ�!" + objException.Message;
                BackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            //	4������GRIDView������Դ(DataSource)��
            DataView objDV = objDT.DefaultView;
            objDV.Sort = strSortNewsBy;     ///ע����һ�д����п�����Ҫע�͵���Ŀǰ���н����ڵ����Ĳ�ѯ������������
            ///����GridView��ÿҳ�ļ�¼��
            if (string.IsNullOrEmpty(PageSize) == false)
            {
                int intPageSize = int.Parse(PageSize);
                gvNews.PageSize = intPageSize;
            }
            else
            {
                PageSize = "10";
                gvNews.PageSize = 10;
            }
            this.gvNews.DataSource = objDV;
            //	5����DATAGRID������DataTable��������ʾ��DATAGRID��
            this.gvNews.DataBind();

            ///����ר������BindGv�е���ҳ��ش���
            GridViewRow pagerRow = gvNews.BottomPagerRow;
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
                lblAllPages.Text = this.gvNews.PageCount.ToString();
                //��ǰҳ����
                lblCurrentPage.Text = (this.gvNews.PageIndex + 1).ToString();
                //��ǰ����������ҳ����
                txtJump2Page.Text = (this.gvNews.PageIndex + 1).ToString();
                //�����ǰҳ����Ϊ0����<ǰһҳ>��ť��Ч
                if (this.gvNews.PageIndex == 0)
                {
                    btnPrevPage.Enabled = false;
                }
                else
                {
                    btnPrevPage.Enabled = true;
                }
                //�����ǰҳ������Ϊ���һҳ����<ǰһҳ>��ť��Ч
                if (this.gvNews.PageIndex == this.gvNews.PageCount - 1)
                {
                    btnNextPage.Enabled = false;
                }
                else
                {
                    btnNextPage.Enabled = true;
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
            gvNews.BottomPagerRow.Visible = true;
        }


        ///���ɴ��߼�������ݴ��䵽�����ĺ�������
        /// <summary>
        /// �������ܣ�������������������ʾ��������
        ///ע�⣺��������������򣬲�����һ��������������ϵ�ģ�����Ϊһ��������ֵ��Ȼ����Ϊ����������ֵ
        ///      ������������ݿ�ʱ����Ӧ��һ���ֶ���ǰ�������ֶ��ں�
        /// </summary>
        /// <param name="pobjNewsEN">��ʵ�������</param>
        protected void GetDataFromNewsClass(clsNewsEN pobjNewsEN)
        {
            wucNewsB1.NewsTitle = pobjNewsEN.NewsTitle;//    ����
            wucNewsB1.NewsTypeId = pobjNewsEN.NewsTypeId;//    ��Ѷ����
            wucNewsB1.IsTop = pobjNewsEN.IsTop;//    �Ƿ��ö�
            wucNewsB1.ImgPath = pobjNewsEN.ImgPath;//    ͼƬ·��
            wucNewsB1.NewsContent = pobjNewsEN.NewsContent;//    ����
            wucNewsB1.EditPeople = clsCommonSession.UserId;//    �༭��Ա
            wucNewsB1.EditTime = DateTime.Now.ToString("yyyy-MM-dd"); //    �༭ʱ��
            wucNewsB1.Source = pobjNewsEN.Source;//    ��Դ
            wucNewsB1.Views = pobjNewsEN.Views ?? 0;//    �����
            wucNewsB1.Memo = pobjNewsEN.Memo;//    ��ע
        }
        /// <summary>
        /// �������ܣ��ѽ����ϵ��������ݴ����������
        /// </summary>
        /// <param name="pobjNewsEN">���ݴ����Ŀ�������</param>
        protected void PutDataToNewsClass(clsNewsEN pobjNewsEN)
        {
            pobjNewsEN.NewsTitle = wucNewsB1.NewsTitle;//    ����
            pobjNewsEN.NewsTypeId = wucNewsB1.NewsTypeId;//    ��Ѷ����
            pobjNewsEN.IsTop = wucNewsB1.IsTop;//    �Ƿ��ö�
            pobjNewsEN.ImgPath = wucNewsB1.ImgPath;//    ͼƬ·��
            pobjNewsEN.NewsContent = wucNewsB1.NewsContent;//    ����
            pobjNewsEN.EditPeople = wucNewsB1.EditPeople;//    �༭��Ա
            pobjNewsEN.EditTime = wucNewsB1.EditTime;//    �༭ʱ��
            pobjNewsEN.Source = wucNewsB1.Source;//    ��Դ
            pobjNewsEN.Views = wucNewsB1.Views;//    �����
            pobjNewsEN.Memo = wucNewsB1.Memo;//    ��ע



            pobjNewsEN.Memo = wucNewsB1.Memo;//    ��ע
            pobjNewsEN.Memo += clsCommonSession.UserName;
            pobjNewsEN.Memo += DateTime.Now.ToString(); //    ����
        }

        public System.Data.DataTable GetNewsTypeId()
        {
            //��ȡĳѧԺ����רҵ��Ϣ
            string strSQL = "select NewsTypeId, NewsTypeName from NewsType ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindDdl_NewsTypeId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //Ϊ����Դ�ڱ����������������
            ListItem li = new ListItem("��ѡ��...", "0");
            System.Data.DataTable objDT = GetNewsTypeId();
            objDDL.DataValueField = "NewsTypeId";
            objDDL.DataTextField = "NewsTypeName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        ///���ɵĲ����¼׼�����̴���for C#
        protected void AddNewsRecord()
        {
            btnOKUpd.Text = "ȷ�����";
            btnCancelNewsEdit.Text = "ȡ�����";

            wucNewsB1.EditTime = DateTime.Now.ToString("yyyy-MM-dd");
            wucNewsB1.EditPeople = clsCommonSession.UserId;

            //string strMemo +=DateTime.Now.ToString();
            wucNewsB1.Memo = clsCommonSession.UserName;
            wucNewsB1.Memo += DateTime.Now.ToString(); //    ��ע

            DispEditNewsRegion();
        }
        ///�����¼���̹��̴���for C#
        protected bool AddNewsRecordSave()
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
            //string strResult = " ";	//���ڴ����ڼ����������ʱ���ֵ�ı���
            clsNewsEN objNewsEN;
            //1�����ؼ����������������Ƿ���ȷ
          
            //2��������󲢳�ʼ������
            //clsNewsEN objNewsEN;	//�������
            objNewsEN = new clsNewsEN();	//��ʼ���¶���
            ///3.1���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
            //4����ֵ�ӽ���㴫���߼��������ʵ���
            PutDataToNewsClass(objNewsEN);		//�ѽ����ֵ����
            //5.1����鴫��ȥ�Ķ��������Ƿ�Ϸ�
            try
            {
                clsNewsBL.CheckPropertyNew(objNewsEN);
                //6��������ʵ�������ݴ��������ݿ���
                clsNewsBL.AddNewRecordBySql2(objNewsEN);
            }
            catch (Exception objException)
            {
                strMsg = "��Ӽ�¼���ɹ�!" + objException.Message;
                Response.Write("<script>alert('" + strMsg + "')</script>");
                lblMsgEdit.Text = strMsg;
                return false;
            }
            strMsg = "��Ӽ�¼�ɹ�!";
            Response.Write("<script>alert('" + strMsg + "')</script>");
            lblMsgEdit.Text = "��Ӽ�¼�ɹ�!";
            //7��������ļ�¼������ʾ��DATAGRID��
            BindGv_News();
            DispNewsListRegion();
            wucNewsB1.Clear();		//��տؼ�������
            ///�ָ�<ȷ�����>���<���>
            btnOKUpd.Text = "���";
            btnCancelNewsEdit.Text = "ȡ���༭";
            return true;
        }
        ///�����¼���̹��̴���for C#
        protected bool AddNewsRecordSaveV5()
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

            clsNewsEN objNewsEN;
            //1�����ؼ����������������Ƿ���ȷ
            
            //2��������󲢳�ʼ������
            //clsNewsEN objNewsEN;	//�������
            objNewsEN = new clsNewsEN();	//��ʼ���¶���
            //3���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
            //4����ֵ�ӽ���㴫���߼��������ʵ���
            PutDataToNewsClass(objNewsEN);		//�ѽ����ֵ����
            //5.1����鴫��ȥ�Ķ��������Ƿ�Ϸ�
            try
            {
                clsNewsBL.CheckPropertyNew(objNewsEN);
                //6��������ʵ�������ݴ��������ݿ���
                clsNewsBL.AddNewRecordBySql2(objNewsEN);
            }
            catch (Exception objException)
            {
                ErrMessage = "��Ӽ�¼���ɹ�!" + objException.Message;
                BackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            strMsg = "��Ӽ�¼�ɹ�!";
            Response.Write("<script>alert('" + strMsg + "')</script>");
            lblMsgEdit.Text = "��Ӽ�¼�ɹ�!";
            //7��������ļ�¼������ʾ��DATAGRID��
            BindGv_News();
            DispNewsListRegion();
            wucNewsB1.Clear();		//��տؼ�������
            ///�ָ�<ȷ�����>���<���>
            btnOKUpd.Text = "���";
            btnCancelNewsEdit.Text = "ȡ���༭";
            return true;
        }
        ///�����޸ļ�¼׼�����̴��� for C#
        protected void UpdateNewsRecord(int intId_News)
        {
            //�������裺���ܹ�2����
            //1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
            //2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�

            //1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
            ShowData(intId_News);
            //2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
            btnOKUpd.Enabled = true;
            btnOKUpd.Text = "ȷ���޸�";
            btnCancelNewsEdit.Text = "ȡ���޸�";
            lblMsgEdit.Text = "";
            DispEditNewsRegion();
        }
        ///�޸Ĵ���׼�����̴��� for C#
        protected bool UpdateNewsRecordSave(clsNewsEN objNewsEN)
        {
            //�������裺
            //1�����ؼ����������������Ƿ���ȷ
            //2����ֵ�ӽ���㴫���߼��������ʵ���
            ///3.1����鴫��ȥ�Ķ��������Ƿ�Ϸ�
            ///3.2�����Ψһ��
            //4��������ʵ�������ݴ��������ݿ���
            //5�����޸ĺ��������ʾ��DATAGRID��
            string strMsg;	//ר�����ڴ�����Ϣ�ı���
            //string strResult = " ";	//���ڴ����ڼ����������ʱ���ֵ�ı���
            //1�����ؼ����������������Ƿ���ȷ
           
            //2����ֵ�ӽ���㴫���߼��������ʵ���
            PutDataToNewsClass(objNewsEN);		//�ѽ����ֵ����
            ///3.1����鴫��ȥ�Ķ��������Ƿ�Ϸ�
            try
            {
                clsNewsBL.CheckPropertyNew(objNewsEN);
                //4��������ʵ�������ݴ��������ݿ���
                clsNewsBL.UpdateBySql2(objNewsEN);
            }
            catch (Exception objException)
            {
                strMsg = "�޸ļ�¼���ɹ�!" + objException.Message;
                Response.Write("<script>alert('" + strMsg + "')</script>");
                lblMsgEdit.Text = strMsg;
                return false;
            }
            strMsg = "�޸ļ�¼�ɹ�!";
            Response.Write("<script>alert('" + strMsg + "')</script>");
            lblMsgEdit.Text = "�޸ļ�¼�ɹ�!";
            //5�����޸ĺ��������ʾ��DATAGRID��
            BindGv_News();
            DispNewsListRegion();
            wucNewsB1.Clear();//��տؼ��е�����
            //�ָ�<ȷ���޸�>���<���>
            btnOKUpd.Text = "���";
            btnCancelNewsEdit.Text = "ȡ���༭";
            return true;
        }
        ///�޸Ĵ���׼�����̴��� for C#
        protected bool UpdateNewsRecordSaveV5(clsNewsEN objNewsEN)
        {
            //�������裺
            //1�����ؼ����������������Ƿ���ȷ
            //2����ֵ�ӽ���㴫���߼��������ʵ���
            ///3.1����鴫��ȥ�Ķ��������Ƿ�Ϸ�
            //4��������ʵ�������ݴ��������ݿ���
            //5�����޸ĺ��������ʾ��DATAGRID��
            string strMsg;	//ר�����ڴ�����Ϣ�ı���
            //string strResult = " ";	//���ڴ����ڼ����������ʱ���ֵ�ı���
            //1�����ؼ����������������Ƿ���ȷ
            
            //2����ֵ�ӽ���㴫���߼��������ʵ���
            PutDataToNewsClass(objNewsEN);		//�ѽ����ֵ����
            ///3.1����鴫��ȥ�Ķ��������Ƿ�Ϸ�
            try
            {
                clsNewsBL.CheckPropertyNew(objNewsEN);
                //4��������ʵ�������ݴ��������ݿ���
                clsNewsBL.UpdateBySql2(objNewsEN);
            }
            catch (Exception objException)
            {
                ErrMessage = "�޸ļ�¼���ɹ�!" + objException.Message;
                BackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            strMsg = "�޸ļ�¼�ɹ�!";
            Response.Write("<script>alert('" + strMsg + "')</script>");
            lblMsgEdit.Text = "�޸ļ�¼�ɹ�!";
            //5�����޸ĺ��������ʾ��DATAGRID��
            BindGv_News();
            DispNewsListRegion();
            wucNewsB1.Clear();//��տؼ��е�����
            //�ָ�<ȷ���޸�>���<���>
            btnOKUpd.Text = "���";
            btnCancelNewsEdit.Text = "ȡ���༭";
            return true;
        }
        ///ɾ����¼���̴���for C#
        protected void DeleteNewsRecord(int intId_News)
        {
            try
            {
                clsNewsBL.DelRecord(intId_News);
            }
            catch (Exception objException)
            {
                ErrMessage = objException.Message;
                BackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            BindGv_News();
        }

        ///����ר�����ڵ���Excel����ش���
        private void ExportExcel()
        {
            //	1����Ͻ�����������
            string strWhereCond = CombineNewsCondition();
            //	2��������������ȡ�ñ�����������DataTable��
            System.Data.DataTable objDT = null;
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "News��Ϣ����.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add("NewsTitle"); arrCnName.Add("����");
            arrColName.Add("NewsTypeName"); arrCnName.Add("��Ѷ��������");
            arrColName.Add("ImgPath"); arrCnName.Add("ͼƬ·��");
            arrColName.Add("EditPeople"); arrCnName.Add("�༭��Ա");
            arrColName.Add("EditTime"); arrCnName.Add("�༭ʱ��");
            arrColName.Add("NewsTypeId"); arrCnName.Add("��Ѷ����");
            arrColName.Add("NewsContent"); arrCnName.Add("����");
            arrColName.Add("Source"); arrCnName.Add("��Դ");
            arrColName.Add("IsTop"); arrCnName.Add("�Ƿ��ö�");
            arrColName.Add("Views"); arrCnName.Add("�����");
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
                clsExportExcelSetBLEx.GetExportExcelSetInfo(ref objExportExcelSetENEx, new clsTranslateFieldName());
                strFileName = objExportExcelSetENEx.ExportFileName;//����Excel���ļ���
                arrCnName = objExportExcelSetENEx.arrCnName;//�����ֶ�����Ҳ��Excel�ļ��еı�����
                arrColName = objExportExcelSetENEx.arrColName;//���ݱ������
            }
            catch (Exception objException)
            {
                ErrMessage = objException.Message;
                BackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
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
                objDT = clsvNewsBL.GetDataTable(strWhereCond);
                //�û�Odbc�ķ�ʽ������Excel,��Web����������Ҫ��װExcel,Ŀǰ��Excel2003,���ϣ��2007�����Ի�����һ����䡣
                GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4Odbc(objDT, arrColName, arrCnName, strDownLoadFileName);
                //GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4OdbcExcel2007(objDT, arrColName, arrCnName, strDownLoadFileName);
                //GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr(objDT, arrColName, arrCnName, strDownLoadFileName);
            }
            catch (Exception objException)
            {
                ErrMessage = objException.Message;
                BackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            clsCommForWebForm.DownLoadFile(strDownLoadFileName);
        }
        private void DispEditNewsRegion()
        {
            
            //add.Visible = false;
            //delete.Visible = false;
            //edit.Visible = false;
            //export.Visible = false;
            //tool.Visible = false;

            back.Visible = true;

            trSelect.Visible = false;
            trShow.Visible = false;
            trEdit.Visible = true;
        }
        private void DispNewsListRegion()
        {
            //add.Visible = true;
            //delete.Visible = true;
            //edit.Visible = true;
            //export.Visible = true;
            //tool.Visible = true;

            back.Visible = false;

            trSelect.Visible = true;
            trShow.Visible = true;
            trEdit.Visible = false;

            wucNewsB1.Clear();//��տؼ��е�����
        }
    }
}