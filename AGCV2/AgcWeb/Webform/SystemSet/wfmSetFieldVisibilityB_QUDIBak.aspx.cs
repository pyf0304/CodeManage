
///----------------------
///���ɴ���汾��2012.11.9.1
///�������ڣ�2013/03/25
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
using CommonTable.Entity;
using AGC.BusinessLogic;using AGC.FunClass;
using CommonTable.BusinessLogic;
using AGC.BusinessLogicEx;

using com.taishsoft.datetime;


namespace AGC.Webform
{
    /// <summary>
    /// wfmSetFieldVisibilityB_QUDI ��ժҪ˵��������Q�����ѯ��U�����޸�
    /// </summary>
    public partial class wfmSetFieldVisibilityB_QUDIBak : CommWebPageBase
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
                wucSetFieldVisibilityB1.SetDdl_id_School();

                clsXzSchoolBL.BindDdl_id_School(ddlid_School_q);

                ddlid_School_q.SelectedValue = clsXzSchoolBLEx.GetId_SchoolBySchoolId(clsMyConfig.spSchool);
                ddlid_School_q.Enabled = false;
                wucSetFieldVisibilityB1.id_School = clsXzSchoolBLEx.GetId_SchoolBySchoolId(clsMyConfig.spSchool);
                wucSetFieldVisibilityB1.Setid_SchoolEnabledFalse();

                strSortSetFieldVisibilityBy = "mId Asc";
                //2����ʾ�������ı�������DATAGRID��
                BindGv_SetFieldVisibility();
                //3�����ñ�ؼ����ֿؼ���ReadOnly���ԣ�
                //   ʹֻ֮������Ϊ���޸Ĺ����йؼ����ǲ��ܱ��޸ĵġ�
                DispSetFieldVisibilityListRegion();
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
            this.gvSetFieldVisibility.PageIndex = 0;
            //�ѱ��¼��������ʾ��DATAGRID��
            BindGv_SetFieldVisibility();
        }
        /// <summary>
        /// �������ܣ��¼��������ڸ���DATAGRID�ĵ�ǰҳ����ʱ�����ĺ�����
        ///			  ���幦����������ʾ��ҳ(������ҳ����)�����ݡ�
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void gvSetFieldVisibility_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            //�������裺����2����
            //1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
            //2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ

            //1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
            this.gvSetFieldVisibility.PageIndex = e.NewPageIndex;
            //2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ
            BindGv_SetFieldVisibility();
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
            clsSetFieldVisibilityEN objSetFieldVisibilityEN;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "���":
                    AddSetFieldVisibilityRecord();
                    break;
                case "ȷ�����":
                    //����һ������Ĳ���Ĵ��룬�����߼���̫�򵥣�
                    //�Ͱ��߼���ϲ������Ʋ�,
                    AddSetFieldVisibilityRecordSave();
                    break;
                case "ȷ���޸�":
                    //����һ��������޸ĵĴ��룬�����߼���̫�򵥣�
                    //�Ͱ��߼���ϲ������Ʋ�,
                    objSetFieldVisibilityEN = (clsSetFieldVisibilityEN)Session["objSetFieldVisibilityEN"];
                    UpdateSetFieldVisibilityRecordSave(objSetFieldVisibilityEN);
                    break;
            }
        }

        ///����¼�¼���¼����̣������ڸù����е���������������Ҫ��������Ӷ��д��롣
        protected void btnAddNewRec4Gv_Click(object sender, System.EventArgs e)
        {
            AddSetFieldVisibilityRecord();
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
            List<string> lstKeyValues = clsCommForWebForm.GetAllCheckedItemFromGv(gvSetFieldVisibility, "chkCheckRec", "mId");
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
                    clsSetFieldVisibilityBL.DelRecord(lngmId);
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_SetFieldVisibility();
        }

        /// <summary>
        ///�޸ĵ�ǰ��ѡ��¼
        /// </summary>
        protected void btnUpdate4Gv_Click(object sender, System.EventArgs e)
        {
            List<string> lstKeyValue = clsCommForWebForm.GetFirstCheckedItemFromGv(gvSetFieldVisibility, "mId");
            if (lstKeyValue.Count == 0)
            {
                lblMsg_List.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
                return;
            }
            lblMsg_List.Text = "";
            //1����ʾ�ùؼ��ֵ��������û��޸ĸùؼ��ּ�¼��
            string[] strKeys = lstKeyValue[0].Split(',');
            long lngmId = long.Parse(strKeys[0]);
            UpdateSetFieldVisibilityRecord(lngmId);
        }
        protected void gvSetFieldVisibility_Sorting(object sender, GridViewSortEventArgs e)
        {
            int intIndex;
            //�ж��Ƿ����µ������ֶ�
            intIndex = strSortSetFieldVisibilityBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                strSortSetFieldVisibilityBy = e.SortExpression + " Asc";
                BindGv_SetFieldVisibility();
                return;
            }
            //���ԭ��������
            intIndex = strSortSetFieldVisibilityBy.IndexOf(" Asc");
            if (intIndex == -1)		//���ԭ���������������Ϊ����
            {
                strSortSetFieldVisibilityBy = e.SortExpression + " Asc";
            }
            else			///��������Ϊ����
            {
                strSortSetFieldVisibilityBy = e.SortExpression + " Desc";
            }
            BindGv_SetFieldVisibility();
        }

        /// <summary>
        /// ���ڼ�¼GridView�еĵ�ǰ������ʽ���Ա������һ�������򣬻��ǽ�������
        /// </summary>
        protected string strSortSetFieldVisibilityBy
        {
            get
            {
                string sSortSetFieldVisibilityBy;
                sSortSetFieldVisibilityBy = (string)ViewState["SortSetFieldVisibilityBy"];
                if (sSortSetFieldVisibilityBy == null)
                {
                    sSortSetFieldVisibilityBy = "";
                }
                return sSortSetFieldVisibilityBy;
            }
            set
            {
                string sSortSetFieldVisibilityBy = value;
                ViewState.Add("SortSetFieldVisibilityBy", sSortSetFieldVisibilityBy);
            }
        }

        ///��������ҳ����غ���
        protected void btnJumpPage_Click(object sender, EventArgs e)
        {
            GridViewRow pagerRow = gvSetFieldVisibility.BottomPagerRow;
            TextBox txtJump2Page = (TextBox)pagerRow.FindControl("txtJump2Page");
            if (txtJump2Page != null)
            {
                if (txtJump2Page.Text.Trim() != "" &&
                int.Parse(txtJump2Page.Text) > 0 &&
                int.Parse(txtJump2Page.Text) - 1 < this.gvSetFieldVisibility.PageCount)
                {
                    this.gvSetFieldVisibility.PageIndex = int.Parse(txtJump2Page.Text) - 1;
                }
                this.BindGv_SetFieldVisibility();
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
                    BindGv_SetFieldVisibility();
                }
            }
        }

        ///����GridView��������¼�����
        protected void gvSetFieldVisibility_RowCommand(object sender, GridViewCommandEventArgs e)
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
                        clsCommForWebForm.Set_GridViewAllChecked(gvSetFieldVisibility, true);
                        lbSelAll.Text = "��ѡ";
                    }
                    else if (lbSelAll.Text == "��ѡ")
                    {
                        clsCommForWebForm.Set_GridViewAllChecked(gvSetFieldVisibility, false);
                        lbSelAll.Text = "ȫѡ";
                    }
                    break;
            }
        }
        ///ɾ����¼���̴���for C#
        protected void gvSetFieldVisibility_RowCreated(object sender, GridViewRowEventArgs e)
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
            if (strSortSetFieldVisibilityBy == "") return;
            if (e.Row.RowType == DataControlRowType.Header)//����ؼ��Ƿ�Ϊҳü��
            {
                string strSortEx;
                for (int i = 0; i < this.gvSetFieldVisibility.Columns.Count; i++)
                {
                    strSortEx = this.gvSetFieldVisibility.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = strSortSetFieldVisibilityBy.IndexOf(strSortEx + " ");
                    if (intIndex >= 0)  //��ͼ״̬��������ʽ�Ƿ�Ϊ���е��ֶΣ�
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//�������壬��"webdings"��5�������ǣ�6�������ǣ�
                        intIndex = strSortSetFieldVisibilityBy.IndexOf("Asc");
                        lblSort.Text = (intIndex > 0 ? " 5" : " 6");//�Ƿ�Ϊ���򣬶���Ϊstring�ͣ�
                        e.Row.Cells[i].Controls.Add(lblSort);//��������ĵ�i����Ԫ��������һ�ؼ���
                        break;
                    }
                }
            }
        }

        ///
        protected void gvSetFieldVisibility_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string strmId = gvSetFieldVisibility.DataKeys[e.RowIndex]["mId"].ToString();
            long lngmId = long.Parse(strmId);
            DeleteSetFieldVisibilityRecord(lngmId);
        }
        ///
        protected void gvSetFieldVisibility_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string strmId = gvSetFieldVisibility.DataKeys[e.RowIndex]["mId"].ToString();
            long lngmId = long.Parse(strmId);
            UpdateSetFieldVisibilityRecord(lngmId);
        }
        ///ɾ����¼���̴���for C#
        protected void gvSetFieldVisibility_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            if (e.NewPageIndex != -1)
            {
                gvSetFieldVisibility.PageIndex = e.NewPageIndex;
                this.BindGv_SetFieldVisibility();
            }
        }
        ///
        protected void btnCancelSetFieldVisibilityEdit_Click(object sender, EventArgs e)
        {
            DispSetFieldVisibilityListRegion();
        }

        protected void btnCloneNewRec4Gv_Click(object sender, EventArgs e)
        {
            List<string> lstKeyValue = clsCommForWebForm.GetFirstCheckedItemFromGv(gvSetFieldVisibility, "mId");
            if (lstKeyValue.Count == 0)
            {
                lblMsg_List.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
                return;
            }
            lblMsg_List.Text = "";
            //1����ʾ�ùؼ��ֵ��������û��޸ĸùؼ��ּ�¼��
            string[] strKeys = lstKeyValue[0].Split(',');
            long lngmId = long.Parse(strKeys[0]);
            clsSetFieldVisibilityEN obj = new clsSetFieldVisibilityEN(lngmId);
            clsSetFieldVisibilityBL.GetSetFieldVisibility(ref obj);
            obj.FieldName = "Copy_" + obj.FieldName;
            clsSetFieldVisibilityBL.AddNewRecordBySql2(obj);
            BindGv_SetFieldVisibility();
        }

        protected void btnSetIsVisible_Click(object sender, EventArgs e)
        {
            List<string> arrmIdLst = clsCommForWebForm.GetAllCheckedItemFromGv(gvSetFieldVisibility, "chkCheckRec");
            if (arrmIdLst.Count == 0)
            {
                lblMsg_List.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
                return;
            }
            lblMsg_List.Text = "";
            //1����ʾ�ùؼ��ֵ��������û��޸ĸùؼ��ּ�¼��
            long lngmId;
            foreach (string strmId in arrmIdLst)
            {
                lngmId = long.Parse(strmId);
                clsSetFieldVisibilityEN objSetFieldVisibility = clsSetFieldVisibilityBL.GetObjBymId(lngmId);
                objSetFieldVisibility.IsVisible = true;
                clsSetFieldVisibilityBL.UpdateBySql2(objSetFieldVisibility);
    
            }
            BindGv_SetFieldVisibility();
        }

        protected void btnSetIsNotVisible_Click(object sender, EventArgs e)
        {
            List<string> arrmIdLst = clsCommForWebForm.GetAllCheckedItemFromGv(gvSetFieldVisibility, "chkCheckRec");
            if (arrmIdLst.Count == 0)
            {
                lblMsg_List.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
                return;
            }
            lblMsg_List.Text = "";
            //1����ʾ�ùؼ��ֵ��������û��޸ĸùؼ��ּ�¼��
            long lngmId;
            foreach (string strmId in arrmIdLst)
            {
                lngmId = long.Parse(strmId);
                clsSetFieldVisibilityEN objSetFieldVisibility = clsSetFieldVisibilityBL.GetObjBymId(lngmId);
                objSetFieldVisibility.IsVisible = false;
                clsSetFieldVisibilityBL.UpdateBySql2(objSetFieldVisibility);

            }
            BindGv_SetFieldVisibility();
        }

    }
    public partial class wfmSetFieldVisibilityB_QUDIBak : CommWebPageBase
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
            if (clsSetFieldVisibilityBL.IsExist(lngmId) == false)		//���ùؼ��ֵļ�¼�Ƿ����
            {
                string ss = "�ؼ���Ϊ��" + lngmId + "�Ĳ�����!";
                clsCommonJsFunc.Alert(this, ss);
                return;
            }
            //3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
            clsSetFieldVisibilityEN objSetFieldVisibilityEN = new clsSetFieldVisibilityEN(lngmId);
            //4����ȡ�������������ԣ�
            try
            {
                clsSetFieldVisibilityBL.GetSetFieldVisibility(ref objSetFieldVisibilityEN);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            Session.Add("objSetFieldVisibilityEN", objSetFieldVisibilityEN);
            //5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���
            GetDataFromSetFieldVisibilityClass(objSetFieldVisibilityEN);
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
        protected string CombineSetFieldVisibilityCondition()
        {
            //ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
            //���� 1=1 && UserName = '����'
            string strWhereCond = " 1=1 ";
            //����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
            if (this.ddlid_School_q.SelectedValue != "" && this.ddlid_School_q.SelectedValue != "0")
            {
                strWhereCond += " And id_School='" + this.ddlid_School_q.SelectedValue + "'";
            }
            if (this.txtViewName_q.Text.Trim() != "")
            {
                strWhereCond += " And ViewName like '%" + this.txtViewName_q.Text.Trim() + "%'";
            }
            if (this.txtCtrlType_q.Text.Trim() != "")
            {
                strWhereCond += " And CtrlType like '%" + this.txtCtrlType_q.Text.Trim() + "%'";
            }
            if (this.txtFieldName_q.Text.Trim() != "")
            {
                strWhereCond += " And FieldName like '%" + this.txtFieldName_q.Text.Trim() + "%'";
            }
            return strWhereCond;
        }
        ///���ɰ�GridView�Ĵ���
        /// <summary>
        /// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
        ///			 ����ʾ��GridView�С�
        /// </summary>
        protected void BindGv_SetFieldVisibility()
        {
            //�������裺(��5��)
            //	1����Ͻ�����������
            //	2��������������ȡ�ñ�����������DataTable��
            //	4������GridView������Դ(DataSource)��
            //	5����GridView������DataTable��������ʾ��DATAGRID��
            //	6�����ü�¼����״̬��
            //		�ڱ��������ǰ�״̬��ʾ�ڿؼ�txtRecCount�С�

            //	1����Ͻ�����������
            string strWhereCond = CombineSetFieldVisibilityCondition();
            //	2��������������ȡ�ñ�����������DataTable��
            System.Data.DataTable objDT = null;
            try
            {
                objDT = clsSetFieldVisibilityBL.GetDataTable_SetFieldVisibilityV(strWhereCond);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "��ȡ���ݱ�(DataTable)���ɹ�!" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            //	4������GRIDView������Դ(DataSource)��
            DataView objDV = objDT.DefaultView;
            objDV.Sort = strSortSetFieldVisibilityBy;     ///ע����һ�д����п�����Ҫע�͵���Ŀǰ���н����ڵ����Ĳ�ѯ������������
            ///����GridView��ÿҳ�ļ�¼��
            if (string.IsNullOrEmpty(PageSize) == false)
            {
                int intPageSize = int.Parse(PageSize);
                gvSetFieldVisibility.PageSize = intPageSize;
            }
            else
            {
                PageSize = "10";
                gvSetFieldVisibility.PageSize = 10;
            }
            this.gvSetFieldVisibility.DataSource = objDV;
            //	5����DATAGRID������DataTable��������ʾ��DATAGRID��
            this.gvSetFieldVisibility.DataBind();

            ///����ר������BindGv�е���ҳ��ش���
            GridViewRow pagerRow = gvSetFieldVisibility.BottomPagerRow;
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
                lblAllPages.Text = this.gvSetFieldVisibility.PageCount.ToString();
                //��ǰҳ����
                lblCurrentPage.Text = (this.gvSetFieldVisibility.PageIndex + 1).ToString();
                //��ǰ����������ҳ����
                txtJump2Page.Text = (this.gvSetFieldVisibility.PageIndex + 1).ToString();
                //�����ǰҳ����Ϊ0����<ǰһҳ>��ť��Ч
                if (this.gvSetFieldVisibility.PageIndex == 0)
                {
                    clsPubFun.SetButtonEnabled(btnPrevPage,  false);
                }
                else
                {
                    clsPubFun.SetButtonEnabled(btnPrevPage, true);
                }
                //�����ǰҳ������Ϊ���һҳ����<ǰһҳ>��ť��Ч
                if (this.gvSetFieldVisibility.PageIndex == this.gvSetFieldVisibility.PageCount - 1)
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
            gvSetFieldVisibility.BottomPagerRow.Visible = true;
        }


        ///���ɴ��߼�������ݴ��䵽�����ĺ�������
        /// <summary>
        /// �������ܣ�������������������ʾ��������
        ///ע�⣺��������������򣬲�����һ��������������ϵ�ģ�����Ϊһ��������ֵ��Ȼ����Ϊ����������ֵ
        ///      ������������ݿ�ʱ����Ӧ��һ���ֶ���ǰ�������ֶ��ں�
        /// </summary>
        /// <param name="pobjSetFieldVisibilityEN">��ʵ�������</param>
        protected void GetDataFromSetFieldVisibilityClass(clsSetFieldVisibilityEN pobjSetFieldVisibilityEN)
        {
            wucSetFieldVisibilityB1.id_School = pobjSetFieldVisibilityEN.id_School;//    ѧУ��ˮ��
            wucSetFieldVisibilityB1.ViewName = pobjSetFieldVisibilityEN.ViewName;//    ��������
            wucSetFieldVisibilityB1.FieldName = pobjSetFieldVisibilityEN.FieldName;//    �ֶ���
            wucSetFieldVisibilityB1.CtrlType = pobjSetFieldVisibilityEN.CtrlType;//    �ؼ�����
            wucSetFieldVisibilityB1.IsVisible = pobjSetFieldVisibilityEN.IsVisible;//    �Ƿ���ʾ
            wucSetFieldVisibilityB1.Memo = pobjSetFieldVisibilityEN.Memo;//    ��ע
        }
        /// <summary>
        /// �������ܣ��ѽ����ϵ��������ݴ����������
        /// </summary>
        /// <param name="pobjSetFieldVisibilityEN">���ݴ����Ŀ�������</param>
        protected void PutDataToSetFieldVisibilityClass(clsSetFieldVisibilityEN pobjSetFieldVisibilityEN)
        {
            pobjSetFieldVisibilityEN.id_School = wucSetFieldVisibilityB1.id_School;//    ѧУ��ˮ��
            pobjSetFieldVisibilityEN.ViewName = wucSetFieldVisibilityB1.ViewName;//    ��������
            pobjSetFieldVisibilityEN.FieldName = wucSetFieldVisibilityB1.FieldName;//    �ֶ���
            pobjSetFieldVisibilityEN.CtrlType = wucSetFieldVisibilityB1.CtrlType;//    �ؼ�����
            pobjSetFieldVisibilityEN.IsVisible = wucSetFieldVisibilityB1.IsVisible;//    �Ƿ���ʾ
            pobjSetFieldVisibilityEN.Memo = wucSetFieldVisibilityB1.Memo;//    ��ע
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
        protected void AddSetFieldVisibilityRecord()
        {
            btnOKUpd.Text = "ȷ�����";
            btnCancelSetFieldVisibilityEdit.Text = "ȡ�����";

            wucSetFieldVisibilityB1.id_School = clsXzSchoolBLEx.GetId_SchoolBySchoolId(clsMyConfig.spSchool);
            wucSetFieldVisibilityB1.Setid_SchoolEnabledFalse();

            DispEditSetFieldVisibilityRegion();
        }
        ///�����¼���̹��̴���for C#
        protected bool AddSetFieldVisibilityRecordSave()
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
            clsSetFieldVisibilityEN objSetFieldVisibilityEN;
            //1�����ؼ����������������Ƿ���ȷ
            if (!wucSetFieldVisibilityB1.IsValid(ref strResult))
            {
                lblMsg_Edit.Text = "�ؼ��������������Ͳ���ȷ����!";
                return false;
            }
            //2��������󲢳�ʼ������
            //clsSetFieldVisibilityEN objSetFieldVisibilityEN;	//�������
            objSetFieldVisibilityEN = new clsSetFieldVisibilityEN();	//��ʼ���¶���
            ///3.1���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
            //4����ֵ�ӽ���㴫���߼��������ʵ���
            PutDataToSetFieldVisibilityClass(objSetFieldVisibilityEN);		//�ѽ����ֵ����
            //5.1����鴫��ȥ�Ķ��������Ƿ�Ϸ�
            try
            {
                clsSetFieldVisibilityBL.CheckPropertyNew(objSetFieldVisibilityEN);
                //6��������ʵ�������ݴ��������ݿ���
                clsSetFieldVisibilityBL.AddNewRecordBySql2(objSetFieldVisibilityEN);
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
            BindGv_SetFieldVisibility();
            DispSetFieldVisibilityListRegion();
            wucSetFieldVisibilityB1.Clear();		//��տؼ�������
            ///�ָ�<ȷ�����>���<���>
            btnOKUpd.Text = "���";
            btnCancelSetFieldVisibilityEdit.Text = "ȡ���༭";

            clsvSetFieldVisibilityBL.ReFreshThisCache();
            return true;
        }
        ///�����¼���̹��̴���for C#
        protected bool AddSetFieldVisibilityRecordSaveV5()
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
            clsSetFieldVisibilityEN objSetFieldVisibilityEN;
            //1�����ؼ����������������Ƿ���ȷ
            if (!wucSetFieldVisibilityB1.IsValid(ref strResult))
            {
                lblMsg_Edit.Text = "�ؼ��������������Ͳ���ȷ����!";
                return false;
            }
            //2��������󲢳�ʼ������
            //clsSetFieldVisibilityEN objSetFieldVisibilityEN;	//�������
            objSetFieldVisibilityEN = new clsSetFieldVisibilityEN();	//��ʼ���¶���
            //3���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
            //4����ֵ�ӽ���㴫���߼��������ʵ���
            PutDataToSetFieldVisibilityClass(objSetFieldVisibilityEN);		//�ѽ����ֵ����
            //5.1����鴫��ȥ�Ķ��������Ƿ�Ϸ�
            try
            {
                clsSetFieldVisibilityBL.CheckPropertyNew(objSetFieldVisibilityEN);
                //6��������ʵ�������ݴ��������ݿ���
                clsSetFieldVisibilityBL.AddNewRecordBySql2(objSetFieldVisibilityEN);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "��Ӽ�¼���ɹ�!" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            strMsg = "��Ӽ�¼�ɹ�!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsg_Edit.Text = "��Ӽ�¼�ɹ�!";
            //7��������ļ�¼������ʾ��DATAGRID��
            BindGv_SetFieldVisibility();
            DispSetFieldVisibilityListRegion();
            wucSetFieldVisibilityB1.Clear();		//��տؼ�������
            ///�ָ�<ȷ�����>���<���>
            btnOKUpd.Text = "���";
            btnCancelSetFieldVisibilityEdit.Text = "ȡ���༭";

            clsvSetFieldVisibilityBL.ReFreshThisCache();
            return true;
        }
        ///�����޸ļ�¼׼�����̴��� for C#
        protected void UpdateSetFieldVisibilityRecord(long lngmId)
        {
            //�������裺���ܹ�2����
            //1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
            //2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�

            //1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
            ShowData(lngmId);
            //2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
            clsPubFun.SetButtonEnabled(btnOKUpd, true);
            btnOKUpd.Text = "ȷ���޸�";
            btnCancelSetFieldVisibilityEdit.Text = "ȡ���޸�";
            lblMsg_Edit.Text = "";
            DispEditSetFieldVisibilityRegion();
        }
        ///�޸Ĵ���׼�����̴��� for C#
        protected bool UpdateSetFieldVisibilityRecordSave(clsSetFieldVisibilityEN objSetFieldVisibilityEN)
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
            if (!wucSetFieldVisibilityB1.IsValid(ref strResult))
            {
                lblMsg_Edit.Text = "�ؼ��������������Ͳ���ȷ����!";
                return false;
            }
            //2����ֵ�ӽ���㴫���߼��������ʵ���
            PutDataToSetFieldVisibilityClass(objSetFieldVisibilityEN);		//�ѽ����ֵ����
            ///3.1����鴫��ȥ�Ķ��������Ƿ�Ϸ�
            try
            {
                clsSetFieldVisibilityBL.CheckPropertyNew(objSetFieldVisibilityEN);
                //4��������ʵ�������ݴ��������ݿ���
                clsSetFieldVisibilityBL.UpdateBySql2(objSetFieldVisibilityEN);
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
            BindGv_SetFieldVisibility();
            DispSetFieldVisibilityListRegion();
            wucSetFieldVisibilityB1.Clear();//��տؼ��е�����
            //�ָ�<ȷ���޸�>���<���>
            btnOKUpd.Text = "���";
            btnCancelSetFieldVisibilityEdit.Text = "ȡ���༭";
            clsvSetFieldVisibilityBL.ReFreshThisCache();
            return true;
        }
        ///�޸Ĵ���׼�����̴��� for C#
        protected bool UpdateSetFieldVisibilityRecordSaveV5(clsSetFieldVisibilityEN objSetFieldVisibilityEN)
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
            if (!wucSetFieldVisibilityB1.IsValid(ref strResult))
            {
                lblMsg_Edit.Text = "�ؼ��������������Ͳ���ȷ����!";
                return false;
            }
            //2����ֵ�ӽ���㴫���߼��������ʵ���
            PutDataToSetFieldVisibilityClass(objSetFieldVisibilityEN);		//�ѽ����ֵ����
            ///3.1����鴫��ȥ�Ķ��������Ƿ�Ϸ�
            try
            {
                clsSetFieldVisibilityBL.CheckPropertyNew(objSetFieldVisibilityEN);
                //4��������ʵ�������ݴ��������ݿ���
                clsSetFieldVisibilityBL.UpdateBySql2(objSetFieldVisibilityEN);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "�޸ļ�¼���ɹ�!" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            strMsg = "�޸ļ�¼�ɹ�!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsg_Edit.Text = "�޸ļ�¼�ɹ�!";
            //5�����޸ĺ��������ʾ��DATAGRID��
            BindGv_SetFieldVisibility();
            DispSetFieldVisibilityListRegion();
            wucSetFieldVisibilityB1.Clear();//��տؼ��е�����
            //�ָ�<ȷ���޸�>���<���>
            btnOKUpd.Text = "���";
            btnCancelSetFieldVisibilityEdit.Text = "ȡ���༭";

            clsvSetFieldVisibilityBL.ReFreshThisCache();
            return true;
        }
        ///ɾ����¼���̴���for C#
        protected void DeleteSetFieldVisibilityRecord(long lngmId)
        {
            try
            {
                clsSetFieldVisibilityBL.DelRecord(lngmId);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_SetFieldVisibility();
        }

        ///����ר�����ڵ���Excel����ش���
        private void ExportExcel()
        {
            //	1����Ͻ�����������
            string strWhereCond = CombineSetFieldVisibilityCondition();
            //	2��������������ȡ�ñ�����������DataTable��
            System.Data.DataTable objDT = null;
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "SetFieldVisibility��Ϣ����.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add("id_School"); arrCnName.Add("ѧУ��ˮ��");
            arrColName.Add("SchoolId"); arrCnName.Add("ѧУId");
            arrColName.Add("SchoolName"); arrCnName.Add("ѧУ����");
            arrColName.Add("ViewName"); arrCnName.Add("��������");
            arrColName.Add("CtrlType"); arrCnName.Add("�ؼ�����");
            arrColName.Add("FieldName"); arrCnName.Add("�ֶ���");
            arrColName.Add("IsVisible"); arrCnName.Add("�Ƿ���ʾ");
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
                objDT = clsSetFieldVisibilityBL.GetDataTable_SetFieldVisibilityV(strWhereCond);
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
        private void DispEditSetFieldVisibilityRegion()
        {
            tabSetFieldVisibilityGridView.Visible = false;
            tabEditSetFieldVisibilityRegion.Visible = true;
        }
        private void DispSetFieldVisibilityListRegion()
        {
            tabSetFieldVisibilityGridView.Visible = true;
            tabEditSetFieldVisibilityRegion.Visible = false;
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