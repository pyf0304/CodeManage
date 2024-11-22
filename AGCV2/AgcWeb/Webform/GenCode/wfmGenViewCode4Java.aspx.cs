using AGC.BusinessLogic;using AGC.FunClass;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AgcCommBase;
using AutoGCLib;
//using SqlSv; 
using com.taishsoft.commdb;
using com.taishsoft.common;
using CommFunc4WebForm;

///���ɲ�ѯ���޸ģ�ɾ������Ӽ�¼�Ŀ��Ʋ����
using System;
using System.Data;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AGC.Webform
{
    /// <summary>
    /// wfmGenViewCode4Java ��ժҪ˵��������Q�����ѯ��U�����޸�
    /// </summary>
    public partial class wfmGenViewCode4Java : CommWebPageBase
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
                vsLangType = clsPubConst.LangType.JAVA;
                vsDataBaseType = clsPubConst.DataBaseType.MsSql;
                tabHidden.Visible = false;
                if (clsCommForWebForm.SystemStatus == "DEBUG")
                {
                    
                }
                //1��Ϊ��������������Դ�����б�����
                clsFuncModule_AgcBLEx.BindDdl_FuncModuleId(ddlFuncModuleIdq, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId);

              clsProjectsBLEx.BindDdl_PrjIdCacheEx(ddlPrjIdq);
                clsViewInfoBLEx.BindDdl_ApplicationTypeIdExCache(ddlApplicationTypeIdq, clsPubVar.CurrSelPrjId);
                clsViewGroupBLEx.BindDdl_ViewGroupId(ddlViewGroupIdq, clsPubVar.CurrSelPrjId);

                ///���õ�ǰ��¼�û���Ĭ�Ϲ���
                ddlPrjIdq.SelectedValue = clsPubVar.CurrSelPrjId;
                ddlApplicationTypeIdq.SelectedValue = clsApplicationTypeBLEx.JAVAWEBAPP.ToString();
                ddlApplicationTypeIdq.Enabled = false;

                //�ָ���һ���ڴ˽����״̬
                if (seFuncModuleAgcId != "")
                {
                    clsDropDownList.SetDdlValue(ddlFuncModuleIdq, seFuncModuleAgcId);
                }

                txtViewNameq.Text = ViewName;
                //===============================


                //2����ʾ�������ı�������DATAGRID��
                strSortBy = "ViewName Asc";
                BindDg_ViewInfo();
                //3�����ñ�ؼ����ֿؼ���ReadOnly���ԣ�
                //   ʹֻ֮������Ϊ���޸Ĺ����йؼ����ǲ��ܱ��޸ĵġ�
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

        private string ViewTypeCode
        {
            get
            {
                string intViewTypeCode;
                intViewTypeCode = (string)Session["ViewTypeCode"];
                if (intViewTypeCode == null)
                {
                    intViewTypeCode = "";
                }
                return intViewTypeCode;
            }
            set
            {
                string intViewTypeCode = value;
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


        private string SimpleFName
        {
            get
            {
                string strSimpleFName;
                strSimpleFName = (string)ViewState["SimpleFName"];
                if (strSimpleFName == null)
                {
                    strSimpleFName = "";
                }
                return strSimpleFName;
            }
            set
            {
                string strSimpleFName = value;
                ViewState.Add("SimpleFName", strSimpleFName);
            }
        }

       
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
        private string BackGeneCode4JavaLinkStr
        {
            get
            {
                string strBackGeneCode4JavaLinkStr;
                strBackGeneCode4JavaLinkStr = (string)Session["BackGeneCode4JavaLinkStr"];
                if (strBackGeneCode4JavaLinkStr == null)
                {
                    strBackGeneCode4JavaLinkStr = "";
                }
                return strBackGeneCode4JavaLinkStr;
            }
            set
            {
                string strBackGeneCode4JavaLinkStr = value;
                Session.Add("BackGeneCode4JavaLinkStr", strBackGeneCode4JavaLinkStr);
            }
        }


        
        /// <summary>
        /// �����еĲ�ѯ�ؼ�������ϳ�һ��������
        /// </summary>
        /// <returns>������(strWhereCond)</returns>
        private string CombineCondition()
        {
            //ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
            //���� 1=1 and UserName = '����'
            string strWhereCond = " 1=1 and ApplicationTypeId = '03'";
            //����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
            if (this.txtViewNameq.Text.Trim() != "")
            {
                strWhereCond += " and vViewInfo.ViewName like '" + this.txtViewNameq.Text.Trim() + "%'";
            }

            if (this.ddlFuncModuleIdq.SelectedValue != "" && this.ddlFuncModuleIdq.SelectedValue != "0")
            {
                strWhereCond += " And FuncModuleAgcId='" + this.ddlFuncModuleIdq.SelectedValue + "'";
            }

            if (this.txtMainTabNameq.Text.Trim() != "")
            {
                strWhereCond += " and vViewInfo.MainTabName like '" + this.txtMainTabNameq.Text.Trim() + "%'";
            }
            if (this.txtUserIdq.Text.Trim() != "")
            {
                strWhereCond += " and vViewInfo.UserId='" + this.txtUserIdq.Text.Trim() + "'";
            }
            if (this.ddlPrjIdq.SelectedValue != "" && this.ddlPrjIdq.SelectedValue != "0")
            {
                strWhereCond += " and vViewInfo.PrjId='" + this.ddlPrjIdq.SelectedValue + "'";
            }
            if (this.ddlApplicationTypeIdq.SelectedValue != "" && this.ddlApplicationTypeIdq.SelectedValue != "0")
            {
                strWhereCond += " And ApplicationTypeId='" + this.ddlApplicationTypeIdq.SelectedValue + "'";
            }
            if (this.ddlViewGroupIdq.SelectedValue != "" && this.ddlViewGroupIdq.SelectedValue != "0")
            {
                strWhereCond += " And ViewGroupId='" + this.ddlViewGroupIdq.SelectedValue + "'";
            }

            return strWhereCond;
        }
        ///���ɰ�DATAGRID�Ĵ���
        /// <summary>
        /// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
        ///			 ����ʾ��DATAGRID�С�
        /// </summary>
        private void BindDg_ViewInfo()
        {
            //�������裺(��5��)
            //	1����Ͻ�����������
            //	2��������������ȡ�ñ�����������DataTable��
            //	3���б�DATAGRID�ĵ�ǰҳ���Ƿ񳬳�DATAGRID��ҳ����Χ
            //	4������DATAGRID������Դ(DataSource)��
            //	5����DATAGRID������DataTable��������ʾ��DATAGRID��
            //	6�����ü�¼����״̬��
            //		�ڱ��������ǰ�״̬��ʾ�ڿؼ�txtRecCount�С�

            //	1����Ͻ�����������
            string strWhereCond = CombineCondition();
            //	2��������������ȡ�ñ�����������DataTable��
            System.Data.DataTable objDT = clsViewInfoBLEx.GetViewInfoTEx(strWhereCond);
            //	3�����DATAGRID�ĵ�ǰҳ���Ƿ񳬳�DATAGRID��ҳ����Χ
            //		3.1 ���ȼ���ҳ����
            //		3.2 �����ǰҳ����ҳ����Ϊ���һҳ
            int intPages = CalcPages(objDT.Rows.Count, this.dgViewInfo.PageSize);
            if (intPages == 0)
            {
                this.dgViewInfo.CurrentPageIndex = 0;
            }
            else if (this.dgViewInfo.CurrentPageIndex > intPages - 1)
            {
                this.dgViewInfo.CurrentPageIndex = intPages - 1;
            }
            //	4������DATAGRID������Դ(DataSource)��
            DataView objDV = objDT.DefaultView;
            objDV.Sort = strSortBy;
            this.dgViewInfo.DataSource = objDV;
            //	5����DATAGRID������DataTable��������ʾ��DATAGRID��
            this.dgViewInfo.DataBind();
            //	6�����ü�¼����״̬��
            this.txtRecCount.Text = objDT.Rows.Count.ToString();
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

        /// <summary>
        /// �������ܣ��¼�������������<��ѯ>��ťʱ���������¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnQuery_Click(object sender, System.EventArgs e)
        {
            //��DATAGRID�ĵ�ǰҳ��������Ϊ0������1ҳ��
            //��������ѯʱ��������ʾ���Ǳ��¼���ݵĵ�һ�������ݡ�
            this.dgViewInfo.CurrentPageIndex = 0;
            //�ѱ��¼��������ʾ��DATAGRID��
            BindDg_ViewInfo();
            //������β�ѯ������Ϊ��һ�������ý������================
            seFuncModuleAgcId = ddlFuncModuleIdq.SelectedValue;
            
            ViewName = txtViewNameq.Text;
            //=====================================================
        }
        /// <summary>
        /// �������ܣ��¼��������ڸ���DATAGRID�ĵ�ǰҳ����ʱ�����ĺ�����
        ///			  ���幦����������ʾ��ҳ(������ҳ����)�����ݡ�
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void dgViewInfo_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            //�������裺����2����
            //1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
            //2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ

            //1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
            this.dgViewInfo.CurrentPageIndex = e.NewPageIndex;
            //2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ
            BindDg_ViewInfo();
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
     

        protected void dgViewInfo_ItemDataBound(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
        {
            //			System.Web.UI.WebControls.CheckBox chkIsSort, chkIsTransCode;
            //			if (e.Item.ItemType == ListItemType.Item ||
            //				e.Item.ItemType == ListItemType.SelectedItem ||
            //				e.Item.ItemType == ListItemType.AlternatingItem ||
            //				e.Item.ItemType == ListItemType.EditItem)
            //			{
            //				chkIsSort = (System.Web.UI.WebControls.CheckBox)e.Item.FindControl("chkIsSort");
            //				string strIsSort = e.Item.Cells[10].Text;
            //				chkIsSort.Checked = bool.Parse(strIsSort);
            //
            //				chkIsTransCode = (System.Web.UI.WebControls.CheckBox)e.Item.FindControl("chkIsTransCode");
            //				string strIsTransCode = e.Item.Cells[12].Text;
            //				chkIsTransCode.Checked = bool.Parse(strIsTransCode);
            //
            //			}
        }

        /// <summary>
        /// ���ܣ��޸Ľ����¼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        /// <summary>
        /// ���ܣ�ɾ�������¼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnDelete_Click(object sender, System.EventArgs e)
        {
            string strViewId = (string)rd.Value;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "û��ѡ���¼����ѡ��һ����Ч�Ľ����¼!";
                return;
            }
            lblMsg2.Text = "";
            clsViewInfoBL.DelRecord(strViewId);
            BindDg_ViewInfo();
        }

        /// <summary>
        /// ���ܣ�Ϊ������Ӳ�������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnViewOptStep_Click(object sender, System.EventArgs e)
        {
            string strViewId = (string)rd.Value;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "û��ѡ���¼����ѡ��һ����Ч�Ľ����¼!";
                return;
            }
            lblMsg2.Text = "";
            Session.Add("ViewId", strViewId);
            Response.Redirect("wfmViewOptSteps_QUDI.aspx");
        }

        /// <summary>
        /// ���ܣ��༭�������ر�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnEditRelaTab_Click(object sender, System.EventArgs e)
        {
            string strViewId = (string)rd.Value;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "û��ѡ���¼����ѡ��һ����Ч�Ľ����¼!";
                return;
            }
            lblMsg2.Text = "";
            Session.Add("ViewId", strViewId);
            Response.Redirect("wfmViewRelaTab_QUDI.aspx");
        }

        /// <summary>
        /// ���ܣ��༭����İ�ť�������裻
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnBtnOptStep_Click(object sender, System.EventArgs e)
        {
            string strViewId = (string)rd.Value;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "û��ѡ���¼����ѡ��һ����Ч�Ľ����¼!";
                return;
            }
            lblMsg2.Text = "";
            Session.Add("ViewId", strViewId);
            Response.Redirect("wfmViewBtnOptSteps_QUDI.aspx");
        }
        /// <summary>
        /// ���ܣ��༭������ֶ���Ϣ��Ϊ������ӡ�ɾ����ά���ֶ���Ϣ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnEditViewField_Click(object sender, System.EventArgs e)
        {
            string strViewId = (string)rd.Value;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "û��ѡ���¼����ѡ��һ����Ч�Ľ����¼!";
                return;
            }
            lblMsg2.Text = "";
            Session.Add("ViewId", strViewId);
            Response.Redirect("wfmViewAddField.aspx");
        }
        /// <summary>
        /// ���ܣ��������������ý�����ֶ���Ϣ������ӡ�ɾ���ֶ���Ϣ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSetViewFld_Click(object sender, System.EventArgs e)
        {
            string strViewId = (string)rd.Value;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "û��ѡ���¼����ѡ��һ����Ч�Ľ����¼!";
                return;
            }
            lblMsg2.Text = "";
            Session.Add("ViewId", strViewId);
            Response.Redirect("wfmViewSetField.aspx");

        }

        protected void lbDispViewList_Click(object sender, System.EventArgs e)
        {
            tabQuery1.Visible = true;
        }


        protected void btnGenViewCode_Click(object sender, System.EventArgs e)
        {
            tabQuery1.Visible = false;
            tabCode.Visible = true;

            string strViewId = (string)rd.Value;
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
                //AutoGC5J_VWeb autoGC4J_VWeb = new AutoGC5J_VWeb(strViewId);
                ////			if (autoGC4J_VWeb.ViewFldNum == 0)
                ////			{
                ////				ShowCode("�������ֶ���Ϊ0���������ɽ������";
                ////				return ;
                ////
                ////			}
                //autoGC4J_VWeb.FolderName = "D:\\FTP\\ClsFile\\" + clsCommonSession.UserId + "\\";
                //autoGC4J_VWeb.CurrUserName = clsCommonSession.UserName;
                //ShowCode(autoGC4J_VWeb.A_GenViewCode(objViewInfoENEx);
                //txtFileName4GenCode.Text = autoGC4J_VWeb.FileName;
                //SimpleFName = clsString.GetSimpleFName_S(autoGC4J_VWeb.FileName);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
        }

        protected void btnGenControlCode_Click(object sender, System.EventArgs e)
        {

            Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            tabQuery1.Visible = false;
            tabCode.Visible = true;
            //
            string strViewId = (string)rd.Value;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "û��ѡ���¼����ѡ��һ����Ч�Ľ����¼!";
                return;
            }
            lblMsg2.Text = "";
            //��ȡ��ǰ����Ľ�����ID
            string strViewGroupId = clsViewInfoBL.GetObjByViewIdCache(strViewId, clsPubVar.CurrSelPrjId).ViewGroupId;
            if (strViewGroupId == "")
            {
                lblMsg2.Text = "��ѡ����û����Ӧ�Ľ�������Ϣ!";
                return;
            }
            //����������û����Ӧ����ӡ��޸ġ���ϸ��Ϣ���б���棬���û�У��Ͳ���������Ӧ��Manager
            if (clsViewInfoBL.IsExistRecord("ViewTypeCode = '0013'") == false)//�����ӽ���
            {
                ShowCode("������ȱ����Ӧ����ӽ���(table_add)!");
                return;
            }
            if (clsViewInfoBL.IsExistRecord("ViewTypeCode = '0016'") == false)//����޸Ľ���
            {
                ShowCode("������ȱ����Ӧ���޸Ľ���(table_update)!");
                return;
            }
            if (clsViewInfoBL.IsExistRecord("ViewTypeCode = '0015'") == false)//����ѯ����
            {
                ShowCode("������ȱ����Ӧ�Ĳ�ѯ����(table_query)!");
                return;
            }
            if (clsViewInfoBL.IsExistRecord("ViewTypeCode = '0017'") == false)//�����ϸ��Ϣ����
            {
                ShowCode("������ȱ����Ӧ����ϸ��Ϣ����(table_detail)!");
                return;
            }
            if (clsViewInfoBL.IsExistRecord("ViewTypeCode = '0014'") == false)//����б����
            {
                ShowCode("������ȱ����Ӧ���б����(table_list)!");
                return;
            }

            try
            {
                //AutoGC5J_CWeb autoGC5J_CWeb = new AutoGC5J_CWeb(strViewGroupId);
                ////			if (autoGC5J_CWeb.ViewFldNum == 0)
                ////			{
                ////				ShowCode("�������ֶ���Ϊ0���������ɽ������";
                ////				return ;
                ////
                ////			}
                ////			if (autoGC5J_CWeb.TabKeyFldNum == 0)
                ////			{
                ////				ShowCode("������ر�ı�ؼ��ֶ���Ϊ0������������ر��Ƿ��б�ؼ��ֶ�!";
                ////				return ;
                ////			}

                //autoGC5J_CWeb.FolderName = "D:\\FTP\\ClsFile\\" + clsCommonSession.UserId + "\\";
                //autoGC5J_CWeb.CurrUserName = clsCommonSession.UserName;
                //ShowCode(autoGC5J_CWeb.A_GenActionCode(myEncoding);
                //txtFileName4GenCode.Text = autoGC5J_CWeb.FileName;
                //SimpleFName = clsString.GetSimpleFName_S(autoGC5J_CWeb.FileName);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }

        }

        protected void btnGenGeneLogicCode_Click(object sender, System.EventArgs e)
        {
            tabQuery1.Visible = false;
            tabCode.Visible = true;
            //
            string strViewId = (string)rd.Value;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "û��ѡ���¼����ѡ��һ����Ч�Ľ����¼!";
                return;
            }
            lblMsg2.Text = "";
            ///����ViewId��ȡ�༭�����TabId
            try
            {
                //clsViewInfoEN objViewInfo = clsViewInfoBL.G1etViewInfoByViewId(strViewId);
                //string strTabId = objViewInfo.MainTabId;
                //if (CheckTabFieldBySqlTab(strTabId) == false)
                //{
                //    return;
                //}
                //AutoGC4J_M autoGC4J_M = new AutoGC4J_M(strTabId);
                //autoGC4J_M.FolderName = "D:\\FTP\\ClsFile\\" + clsCommonSession.UserId + "\\";
                //autoGC4J_M.CurrUserName = clsCommonSession.UserName;
                //ShowCode(autoGC4J_M.A_GenGeneralLogicCode(ref strResult);
                //txtFileName4GenCode.Text = autoGC4J_M.FileName;
                //SimpleFName = clsString.GetSimpleFName_S(autoGC4J_M.FileName);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
        }

        protected void lbDispTabList_Click(object sender, System.EventArgs e)
        {
            tabQuery1.Visible = true;
            tabCode.Visible = false;
        }

        //protected void btnCtlViewCode_Click(object sender, System.EventArgs e)
        //{
        //    tabQuery1.Visible = false;
        //    tabCode.Visible = true;

        //    string strViewId = (string)rd.Value;
        //    if (strViewId.Trim().Length == 0)
        //    {
        //        lblMsg2.Text = "û��ѡ���¼����ѡ��һ����Ч�Ľ����¼!";
        //        return;
        //    }
        //    lblMsg2.Text = "";
        //    string strTabId = "";
        //    string strRe_ClsName = "";
        //    string strRe_FileNameWithModuleName = "";
        //    clsPubConst.ClassName cnClassName = clsPubConst.ClassName.WebCtlViewCode;

        //    try
        //    {
        //        string strCodeText = AutoGC.GeneCode(cnClassName, "",
        //                       vsLangType, vsDataBaseType, strTabId, strViewId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId,
        //                       intApplicationTypeId,
        //                       clsSysParaEN.strUserId, ref strRe_ClsName, ref strRe_FileNameWithModuleName);

        //        //strCodeText = clsViewInfoBLEx_GeneCode.GeneCtlViewCode(strViewId, "Net2010",
        //        //    clsPubVar.objCurrSelProject, 
        //        //    clsCommonSession.UserId,
        //        //     clsCommonSession.UserName, "", "",
        //        //   ref strFileName4GenCode, ref strClsName, ref strCodePath);
        //        ShowCode(strCodeText);
        //        txtFileName4GenCode.Text = strRe_FileNameWithModuleName;
        //        SimpleFName = strRe_ClsName;
        //    }
        //    catch (Exception objException)
        //    {
        //        clsCommonSession.seErrMessage = objException.Message;
        //        clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
        //        clsPubFun4Web.AccessError(this, conCurrPageName);
        //    }
        //}

        //protected void btnCtlControlCode_Click(object sender, System.EventArgs e)
        //{


        //    string strCharEncodingId = clsPubFun.GetCharEncodingIdByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
          
        //    tabQuery1.Visible = false;
        //    tabCode.Visible = true;

        //    string strViewId = (string)rd.Value;
        //    if (strViewId.Trim().Length == 0)
        //    {
        //        lblMsg2.Text = "û��ѡ���¼����ѡ��һ����Ч�Ľ����¼!";
        //        return;
        //    }
        //    lblMsg2.Text = "";
        //    string strFileName4GenCode = "";
        //    string strCodeText="";   
        //    string strTabId = "";
        //    string strRe_ClsName = "";
        //    string strRe_FileNameWithModuleName = "";
        //    clsPubConst.ClassName cnClassName = clsPubConst.ClassName.WebViewControlCode;

        //    try
        //    {
         
        //        strCodeText = AutoGC.GeneCode(cnClassName, "",
        //                       vsLangType, vsDataBaseType, strTabId, strViewId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId,
        //                       clsSysParaEN.strUserId, ref strRe_ClsName, ref strRe_FileNameWithModuleName);

        //        //strCodeText = clsViewInfoBLEx_GeneCode.GeneCtlControlCode(strViewId, "Net2010",
        //        //    clsPubVar.objCurrSelProject, 
        //        //    clsCommonSession.UserId,
        //        //     clsCommonSession.UserName, "", "", strCharEncodingId, 
        //        //   ref strFileName4GenCode, ref strClsName, ref strCodePath);
        //        ShowCode(strCodeText);
        //        txtFileName4GenCode.Text = strRe_FileNameWithModuleName;
        //        SimpleFName = strRe_ClsName;
        //    }
        //    catch (Exception objException)
        //    {
        //        clsCommonSession.seErrMessage = objException.Message;
        //        clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
        //        clsPubFun4Web.AccessError(this, conCurrPageName);
        //    }
        //}

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
        private bool DownLoadFile(string strFileContent, string strFileName)
        {
            //			string path = "D:\\�Ŀ�����������Լ��.doc";		//WORD�ļ�����ֱ������
            ///			string path = "D:\\1000010811.JPG";	//JPG�ļ���������ʾ���һ�����
            Response.Clear();
            //			Response.AddHeader("Content-Disposition", "inline; filename=" + ); 
            Response.AddHeader("Content-Disposition", "attachment; filename=" + HttpUtility.UrlEncode(strFileName));
            //			Response.AddHeader("Content-Length", strFileContent.Length.ToString()); 
            Response.ContentType = "application/octet-stream";
            Response.Write(strFileContent);
            Response.Write("\r\r\n");
            Response.End();
            return true;
        }

        protected void btnPreView_Click(object sender, System.EventArgs e)
        {

            string strViewId = (string)rd.Value;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "û��ѡ���¼����ѡ��һ����Ч�Ľ����¼!";
                return;
            }
            lblMsg2.Text = "";
            ViewId = strViewId;
            BackGeneCode4JavaLinkStr = Page.Request.Url.AbsolutePath;
            Response.Redirect("../View/wfmPreviewViewRegion.aspx?ParentPage=GeneCode4Java");
        }

        protected void btnGeneStrutsConfig_Click(object sender, System.EventArgs e)
        {

            tabQuery1.Visible = false;
            tabCode.Visible = true;

            string strViewId = (string)rd.Value;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "û��ѡ���¼����ѡ��һ����Ч�Ľ����¼!";
                return;
            }
            lblMsg2.Text = "";

            string strViewGroupId =  clsViewInfoBL.GetObjByViewIdCache(strViewId, clsPubVar.CurrSelPrjId).ViewGroupId;
            if (strViewGroupId == "")
            {
                lblMsg2.Text = "��ѡ����û����Ӧ�Ľ�������Ϣ!";
                return;
            }
            //����������û����Ӧ����ӡ��޸ġ���ϸ��Ϣ���б���棬���û�У��Ͳ���������Ӧ��Manager
            if (clsViewInfoBL.IsExistRecord("ViewTypeCode = '0013'") == false)//�����ӽ���
            {
                ShowCode("������ȱ����Ӧ����ӽ���(table_add)!");
                return;
            }
            if (clsViewInfoBL.IsExistRecord("ViewTypeCode = '0016'") == false)//����޸Ľ���
            {
                ShowCode("������ȱ����Ӧ���޸Ľ���(table_update)!");
                return;
            }
            if (clsViewInfoBL.IsExistRecord("ViewTypeCode = '0015'") == false)//����ѯ����
            {
                ShowCode("������ȱ����Ӧ�Ĳ�ѯ����(table_query)!");
                return;
            }
            if (clsViewInfoBL.IsExistRecord("ViewTypeCode = '0017'") == false)//�����ϸ��Ϣ����
            {
                ShowCode("������ȱ����Ӧ����ϸ��Ϣ����(table_detail)!");
                return;
            }
            if (clsViewInfoBL.IsExistRecord("ViewTypeCode = '0014'") == false)//����б����
            {
                ShowCode("������ȱ����Ӧ���б����(table_list)!");
                return;
            }

            try
            {

                //AutoGC5J_Manager autoGC5J_Manager = new AutoGC5J_Manager(strViewGroupId);

                //autoGC5J_Manager.FolderName = "D:\\FTP\\ClsFile\\" + clsCommonSession.UserId + "\\";
                //autoGC5J_Manager.CurrUserName = clsCommonSession.UserName;
                //ShowCode(autoGC5J_Manager.A_GenStrutsConfigCode();
                //txtFileName4GenCode.Text = autoGC5J_Manager.FileName;
                //SimpleFName = clsString.GetSimpleFName_S(autoGC5J_Manager.FileName);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }


        }

        protected void btnLogicManagerCode_Click(object sender, System.EventArgs e)
        {

            Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            tabQuery1.Visible = false;
            tabCode.Visible = true;
            //
            string strViewId = (string)rd.Value;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "û��ѡ���¼����ѡ��һ����Ч�Ľ����¼!";
                return;
            }
            lblMsg2.Text = "";
            //��ȡ��ǰ����Ľ�����ID
            string strViewGroupId = clsViewInfoBL.GetObjByViewIdCache(strViewId, clsPubVar.CurrSelPrjId).ViewGroupId;
            if (strViewGroupId == "")
            {
                lblMsg2.Text = "��ѡ����û����Ӧ�Ľ�������Ϣ!";
                return;
            }
            //����������û����Ӧ����ӡ��޸ġ���ϸ��Ϣ���б���棬���û�У��Ͳ���������Ӧ��Manager
            if (clsViewInfoBL.IsExistRecord("ViewTypeCode = '0013'") == false)//�����ӽ���
            {
                ShowCode("������ȱ����Ӧ����ӽ���(table_add)!");
                return;
            }
            if (clsViewInfoBL.IsExistRecord("ViewTypeCode = '0016'") == false)//����޸Ľ���
            {
                ShowCode("������ȱ����Ӧ���޸Ľ���(table_update)!");
                return;
            }
            if (clsViewInfoBL.IsExistRecord("ViewTypeCode = '0015'") == false)//����ѯ����
            {
                ShowCode("������ȱ����Ӧ�Ĳ�ѯ����(table_query)!");
                return;
            }
            if (clsViewInfoBL.IsExistRecord("ViewTypeCode = '0017'") == false)//�����ϸ��Ϣ����
            {
                ShowCode("������ȱ����Ӧ����ϸ��Ϣ����(table_detail)!");
                return;
            }
            if (clsViewInfoBL.IsExistRecord("ViewTypeCode = '0014'") == false)//����б����
            {
                ShowCode("������ȱ����Ӧ���б����(table_list)!");
                return;
            }
            try
            {
                //AutoGC5J_Manager autoGC5J_Manager = new AutoGC5J_Manager(strViewGroupId);


                //autoGC5J_Manager.FolderName = "D:\\FTP\\ClsFile\\" + clsCommonSession.UserId + "\\";
                //autoGC5J_Manager.CurrUserName = clsCommonSession.UserName;
                //ShowCode(autoGC5J_Manager.A_GenManagerCode(myEncoding);
                //txtFileName4GenCode.Text = autoGC5J_Manager.FileName;
                //SimpleFName = clsString.GetSimpleFName_S(autoGC5J_Manager.FileName);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
        }

        protected void btnGenGeneExLogicCode_Click(object sender, System.EventArgs e)
        {


            Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            tabQuery1.Visible = false;
            tabCode.Visible = true;
            
            string strViewId = (string)rd.Value;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "û��ѡ���¼����ѡ��һ����Ч�Ľ����¼!";
                return;
            }
            lblMsg2.Text = "";
            ///����ViewId��ȡ�༭�����TabId
            try
            {
                clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, clsPubVar.CurrSelPrjId);
                string strTabId = objViewInfo.MainTabId;
                if (CheckTabFieldBySqlTab(strTabId) == false)
                {
                    return;
                }
              
                //AutoGC5Cs_M autoGC5Cs_M = new AutoGC5Cs_M(strTabId, clsPubVar.CurrPrjDataBaseId);
                //autoGC5Cs_M.objPrjTabENEx.FolderName = "D:\\FTP\\ClsFile\\" + clsCommonSession.UserId + "\\";
                //autoGC5Cs_M.objPrjTabENEx.CurrUserName = clsCommonSession.UserName;
                //ShowCode(autoGC5Cs_M.A_GenGeneralExLogicCode(myEncoding);
                //txtFileName4GenCode.Text = autoGC5Cs_M.objPrjTabENEx.FileName;
                //SimpleFName = clsString.GetSimpleFName_S(autoGC5Cs_M.objPrjTabENEx.FileName);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
        }

        protected void btnCtlViewCode4Query_Click(object sender, System.EventArgs e)
        {
            tabQuery1.Visible = false;
            tabCode.Visible = true;
            string strRe_ClsName = "";
            string strRe_FileNameWithModuleName = "";
            string strViewId = (string)rd.Value;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "û��ѡ���¼����ѡ��һ����Ч�Ľ����¼!";
                return;
            }
            lblMsg2.Text = "";

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
            ShowCode(autoGC5Cs_VWeb.A_GenCtlViewCodeforTab4Query(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName));
            txtFileName4GenCode.Text = objViewInfoENEx.FileName;
            SimpleFName = clsString.GetSimpleFName_S(objViewInfoENEx.FileName);

        }


        protected void btnCtlViewCode_Disp_Click(object sender, System.EventArgs e)
        {

            tabQuery1.Visible = false;
            tabCode.Visible = true;
            string strRe_ClsName = "";
            string strRe_FileNameWithModuleName = "";
            string strViewId = (string)rd.Value;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "û��ѡ���¼����ѡ��һ����Ч�Ľ����¼!";
                return;
            }
            lblMsg2.Text = "";

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

        protected void dgViewInfo_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
        {
            int intIndex;
            if (strSortBy == "") return;
            if (e.Item.ItemType == ListItemType.Header)//����ؼ��Ƿ�Ϊҳü��
            {
                string strSortEx;
                for (int i = 0; i < this.dgViewInfo.Columns.Count; i++)
                {
                    strSortEx = this.dgViewInfo.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = strSortBy.IndexOf(strSortEx + " ");
                    if (intIndex >= 0)  //��ͼ״̬��������ʽ�Ƿ�Ϊ���е��ֶΣ�
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//�������壬��"webdings"��5�������ǣ�6�������ǣ�
                        intIndex = strSortBy.IndexOf("Asc");
                        lblSort.Text = (intIndex > 0 ? " 5" : " 6");//�Ƿ�Ϊ���򣬶���Ϊstring�ͣ�
                        e.Item.Cells[i].Controls.Add(lblSort);//��������ĵ�i����Ԫ��������һ�ؼ���
                        break;
                    }
                }
            }
        }

        protected void dgViewInfo_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
        {
            int intIndex;
            //�ж��Ƿ����µ������ֶ�
            intIndex = strSortBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                strSortBy = e.SortExpression + " Asc";
                BindDg_ViewInfo();
                return;
            }
            //���ԭ��������
            intIndex = strSortBy.IndexOf(" Asc");
            if (intIndex == -1)		//���ԭ���������������Ϊ����
            {
                strSortBy = e.SortExpression + " Asc";
            }
            else			///��������Ϊ����
            {
                strSortBy = e.SortExpression + " Desc";
            }
            BindDg_ViewInfo();
        }
        private string strSortBy
        {
            get
            {
                string sSortBy;
                sSortBy = (string)ViewState["SortBy"];
                if (sSortBy == null)
                {
                    sSortBy = "";
                }
                return sSortBy;
            }
            set
            {
                string sSortBy = value;
                ViewState.Add("SortBy", sSortBy);
            }
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

        protected void btnGenActionCode_Click(object sender, EventArgs e)
        {



            Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            tabQuery1.Visible = false;
            tabCode.Visible = true;
        
            string strViewId = (string)rd.Value;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "û��ѡ���¼����ѡ��һ����Ч�Ľ����¼!";
                return;
            }
            lblMsg2.Text = "";
            //��ȡ��ǰ����Ľ�����ID
            string strViewGroupId = clsViewInfoBL.GetObjByViewIdCache(strViewId, clsPubVar.CurrSelPrjId).ViewGroupId;
            if (strViewGroupId == "")
            {
                lblMsg2.Text = "��ѡ����û����Ӧ�Ľ�������Ϣ!";
                return;
            }
            //����������û����Ӧ����ӡ��޸ġ���ϸ��Ϣ���б���棬���û�У��Ͳ���������Ӧ��Manager
            if (clsViewInfoBL.IsExistRecord("ViewTypeCode = '0013'") == false)//�����ӽ���
            {
                ShowCode("������ȱ����Ӧ����ӽ���(table_add)!");
                return;
            }
            if (clsViewInfoBL.IsExistRecord("ViewTypeCode = '0016'") == false)//����޸Ľ���
            {
                ShowCode("������ȱ����Ӧ���޸Ľ���(table_update)!");
                return;
            }
            if (clsViewInfoBL.IsExistRecord("ViewTypeCode = '0015'") == false)//����ѯ����
            {
                ShowCode("������ȱ����Ӧ�Ĳ�ѯ����(table_query)!");
                return;
            }
            if (clsViewInfoBL.IsExistRecord("ViewTypeCode = '0017'") == false)//�����ϸ��Ϣ����
            {
                ShowCode("������ȱ����Ӧ����ϸ��Ϣ����(table_detail)!");
                return;
            }
            if (clsViewInfoBL.IsExistRecord("ViewTypeCode = '0014'") == false)//����б����
            {
                ShowCode("������ȱ����Ӧ���б����(table_list)!");
                return;
            }

            try
            {
                //AutoGC5J_CWeb autoGC5J_CWeb = new AutoGC5J_CWeb(strViewGroupId);
                ////			if (autoGC5J_CWeb.ViewFldNum == 0)
                ////			{
                ////				ShowCode("�������ֶ���Ϊ0���������ɽ������";
                ////				return ;
                ////
                ////			}
                ////			if (autoGC5J_CWeb.TabKeyFldNum == 0)
                ////			{
                ////				ShowCode("������ر�ı�ؼ��ֶ���Ϊ0������������ر��Ƿ��б�ؼ��ֶ�!";
                ////				return ;
                ////			}

                //autoGC5J_CWeb.FolderName = "D:\\FTP\\ClsFile\\" + clsCommonSession.UserId + "\\";
                //autoGC5J_CWeb.CurrUserName = clsCommonSession.UserName;
                //ShowCode(autoGC5J_CWeb.A_GenActionCode(myEncoding);
                //txtFileName4GenCode.Text = autoGC5J_CWeb.FileName;
                //SimpleFName = clsString.GetSimpleFName_S(autoGC5J_CWeb.FileName);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }

        }
        protected void btnCtlControlCode4Query_Click(object sender, EventArgs e)
        {

        }


        private bool CheckTabFieldBySqlTab(string strTabId)
        {
            try
            {
                //�ж��Ƿ����ɾ��
                if (clsTabCheckStatusBLEx.CheckPrjTabBySQLTab4OneTab(strTabId, 
                    clsPubVar.CurrSelPrjId,
                    clsPubVar.CurrPrjDataBaseId) == false)
                {
                    lblMsg2.Text = "�����ֶβ��ɹ�!";
                    return false;
                }
            }
            catch (Exception objException)
            {
                lblMsg2.Text = objException.Message;
                clsCommonJsFunc.Alert(this.Page, objException.Message);
                return false;

            }
            return true;
        }

        /// <summary>
        /// ��ǰ��ѡ����������ͣ���Ϊ�� "C#.NET"; "Java";SqlOrOracle
        /// </summary>
        protected clsPubConst.LangType vsLangType
        {
            get
            {
                clsPubConst.LangType strLangType;
                if (ViewState["LangType"] == null)
                {
                    strLangType = clsPubConst.LangType.CSharp;//"C#.NET";
                    return strLangType;
                }
                strLangType = (clsPubConst.LangType)ViewState["LangType"];

                return strLangType;
            }
            set
            {
                clsPubConst.LangType strLangType = value;
                ViewState.Add("LangType", strLangType);
            }
        }
        /// <summary>
        /// ��ǰ��ѡ����������ͣ���Ϊ��"Ms Sql", "Oracle"; "MySql";
        /// </summary>
        protected clsPubConst.DataBaseType vsDataBaseType
        {
            get
            {
                clsPubConst.DataBaseType strDataBaseType;

                if (ViewState["DataBaseType"] == null)
                {
                    return clsPubConst.DataBaseType.MsSql;
                }
                strDataBaseType = (clsPubConst.DataBaseType)ViewState["DataBaseType"];
                return strDataBaseType;
            }
            set
            {
                clsPubConst.DataBaseType strDataBaseType = value;
                ViewState.Add("DataBaseType", strDataBaseType);
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