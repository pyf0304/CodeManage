using AGC.BusinessLogic;using AGC.FunClass;
using AGC.BusinessLogicEx;
using AGC.Entity;
using com.taishsoft.common;
//using SqlSv;
using CommFunc4WebForm;
///���ɲ�ѯ���޸ģ�ɾ������Ӽ�¼�Ŀ��Ʋ����
using System;
using System.Data;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AGC.Webform
{
    /// <summary>
    /// wfmPrjTab_QUDI ��ժҪ˵��������Q�����ѯ��U�����޸�
    /// </summary>
    public partial class wfmGenCode4Tab : CommWebPageBase
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

                ///����Ӧ��Ӧ�����صĿؼ�����
                tabHidden.Visible = false;

                //1��Ϊ��������������Դ�����б�����
                clsProjectsBLEx.BindDdl_PrjIdCacheEx(ddlPrjIdq);
                //clsvPrjObjects4DdlBLEx.BindDdl_ObjId(ddlObjIdq, clsPubVar.CurrSelPrjId);
                clsFuncModule_AgcBLEx.BindDdl_FuncModuleId(ddlFuncModuleId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId);
                ddlPrjIdq.SelectedValue = clsPubVar.CurrSelPrjId;
                //�ָ���һ���ڴ˽����״̬
                if (seFuncModuleAgcId != "")
                {
                    clsDropDownList.SetDdlValue(ddlFuncModuleId, seFuncModuleAgcId);
                }
                //if (ObjId != "")
                //{
                //    clsDropDownList.SetDdlValue(ddlObjIdq, ObjId);
                //}
                txtTabNameq.Text = TabName;
                txtTabCnNameq.Text = TabCnName;
                //=====================================================

                //2����ʾ�������ı�������DATAGRID��
                strSortBy = "TabName Asc";
                BindDg_PrjTab();
                //3�����ñ�ؼ����ֿؼ���ReadOnly���ԣ�
                //   ʹֻ֮������Ϊ���޸Ĺ����йؼ����ǲ��ܱ��޸ĵġ�
                tabCode.Visible = false;
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

        private string ObjId
        {
            get
            {
                string strObjId;
                strObjId = (string)Session["ObjId"];
                if (strObjId == null)
                {
                    strObjId = "";
                }
                return strObjId;
            }
            set
            {
                string strObjId = value;
                Session.Add("ObjId", strObjId);
            }
        }
        private string TabName
        {
            get
            {
                string strTabName;
                strTabName = (string)Session["TabName"];
                if (strTabName == null)
                {
                    strTabName = "";
                }
                return strTabName;
            }
            set
            {
                string strTabName = value;
                Session.Add("TabName", strTabName);
            }
        }
        private string TabCnName
        {
            get
            {
                string strTabCnName;
                strTabCnName = (string)Session["TabCnName"];
                if (strTabCnName == null)
                {
                    strTabCnName = "";
                }
                return strTabCnName;
            }
            set
            {
                string strTabCnName = value;
                Session.Add("TabCnName", strTabCnName);
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
        //        if (strPrjId==null) 
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


        
        /// <summary>
        /// �����еĲ�ѯ�ؼ�������ϳ�һ��������
        /// </summary>
        /// <returns>������(strWhereCond)</returns>
        private string CombineCondition()
        {
            //ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
            //���� 1=1 and UserName = '����'
            string strWhereCond = " 1=1 ";
            //����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
            if (this.txtTabIdq.Text.Trim() != "")
            {
                strWhereCond += " and TabId='" + this.txtTabIdq.Text.Trim() + "'";
            }
            if (this.ddlPrjIdq.SelectedValue != "" && this.ddlPrjIdq.SelectedValue != "0")
            {
                strWhereCond += " and PrjId='" + this.ddlPrjIdq.SelectedValue + "'";
            }
            if (this.txtTabCnNameq.Text.Trim() != "")
            {
                strWhereCond += " and TabCnName like '" + this.txtTabCnNameq.Text.Trim() + "%'";
            }
            if (this.txtTabNameq.Text.Trim() != "")
            {
                strWhereCond += " and TabName like '" + this.txtTabNameq.Text.Trim() + "%'";
            }
           
            if (this.ddlFuncModuleId.SelectedValue != "" && this.ddlFuncModuleId.SelectedValue != "0")
            {
                strWhereCond += " and FuncModuleAgcId='" + this.ddlFuncModuleId.SelectedValue + "'";
            }

            return strWhereCond;
        }
        ///���ɰ�DATAGRID�Ĵ���
        /// <summary>
        /// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
        ///			 ����ʾ��DATAGRID�С�
        /// </summary>
        private void BindDg_PrjTab()
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
            System.Data.DataTable objDT = clsvPrjTabBL.GetDataTable(strWhereCond);
            //	3�����DATAGRID�ĵ�ǰҳ���Ƿ񳬳�DATAGRID��ҳ����Χ
            //		3.1 ���ȼ���ҳ����
            //		3.2 �����ǰҳ����ҳ����Ϊ���һҳ
            int intPages = CalcPages(objDT.Rows.Count, this.dgPrjTab.PageSize);
            if (intPages == 0)
            {
                this.dgPrjTab.CurrentPageIndex = 0;
            }
            else if (this.dgPrjTab.CurrentPageIndex > intPages - 1)
            {
                this.dgPrjTab.CurrentPageIndex = intPages - 1;
            }
            //	4������DATAGRID������Դ(DataSource)��
            DataView objDV = objDT.DefaultView;
            objDV.Sort = strSortBy;
            this.dgPrjTab.DataSource = objDV;
            //	5����DATAGRID������DataTable��������ʾ��DATAGRID��
            this.dgPrjTab.DataBind();
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
            this.dgPrjTab.CurrentPageIndex = 0;
            //�ѱ��¼��������ʾ��DATAGRID��
            BindDg_PrjTab();
            //������β�ѯ������Ϊ��һ�������ý������
            seFuncModuleAgcId = ddlFuncModuleId.SelectedValue;
            //ObjId = ddlObjIdq.SelectedValue;
            TabName = txtTabNameq.Text;
            TabCnName = txtTabCnNameq.Text;

        }
        /// <summary>
        /// �������ܣ��¼��������ڸ���DATAGRID�ĵ�ǰҳ����ʱ�����ĺ�����
        ///			  ���幦����������ʾ��ҳ(������ҳ����)�����ݡ�
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void dgPrjTab_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            //�������裺����2����
            //1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
            //2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ

            //1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
            this.dgPrjTab.CurrentPageIndex = e.NewPageIndex;
            //2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ
            BindDg_PrjTab();
        }

        protected void dgPrjTab_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
        {
            string strTabId;
            string strCommandName;
            if (e.Item.ItemType == ListItemType.Item ||
                e.Item.ItemType == ListItemType.SelectedItem ||
                e.Item.ItemType == ListItemType.AlternatingItem ||
                e.Item.ItemType == ListItemType.EditItem)
            {
                strCommandName = ((LinkButton)e.CommandSource).CommandName;
                strTabId = e.Item.Cells[0].Text;
                switch (strCommandName)
                {
                    case "Delete":
                        break;
                    // Add other cases here, if there are multiple ButtonColumns in 
                    // the DataGrid control.
                    case "Update":
                        break;

                    default:
                        // Do nothing.
                        break;
                }
            }
        }


        protected void lbGeneLogicCode_Click(object sender, System.EventArgs e)
        {

            Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            
            string strTabId = (string)rd.Value;
            if (strTabId.Trim().Length == 0)
            {
                lblMsg2.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
                return;
            }
            if (CheckTabFieldBySqlTab(strTabId) == false)
            {
                return;
            }
    
            lblMsg2.Text = "";
            try
            {
                //AutoGC5Cs_M autoGC5Cs_M = new AutoGC5Cs_M(strTabId, clsPubVar.CurrPrjDataBaseId);
                //autoGC5Cs_M.objPrjTabENEx.FolderName = "D:\\FTP\\ClsFile\\" + clsCommonSession.UserId + "\\";
                //autoGC5Cs_M.objPrjTabENEx.CurrUserName = clsCommonSession.UserName;
                //ShowCode(autoGC5Cs_M.A_GenGeneralLogicCode(myEncoding);	//�����
            }
            catch (Exception objException)
            {
                //				clsCommonSession.seErrMessage = objException.Message;
                //				clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;	//"../GenCode/wfmGenViewCode_WebV5.aspx";
                //				clsPubFun4Web.AccessError(this, conCurrPageName);
                lblMsg2.Text = objException.Message;
            }
            tabQuery.Visible = false;
            tabCode.Visible = true;

        }

        protected void lbDispTabList_Click(object sender, System.EventArgs e)
        {
            tabQuery.Visible = true;
        }

        protected void lbGenCode4CreateTab_Click(object sender, System.EventArgs e)
        {
            
            string strTabId = (string)rd.Value;
            if (strTabId.Trim().Length == 0)
            {
                lblMsg2.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
                return;
            }
    
            lblMsg2.Text = "";
            try
            {
                //AutoGC5Cs_M autoGC5Cs_M = new AutoGC5Cs_M(strTabId, clsPubVar.CurrPrjDataBaseId);
                //autoGC5Cs_M.objPrjTabENEx.FolderName = "D:\\FTP\\ClsFile\\" + clsCommonSession.UserId + "\\";
                //autoGC5Cs_M.objPrjTabENEx.CurrUserName = clsCommonSession.UserName;
                //ShowCode(autoGC5Cs_M.A_GenSQLCode(ref strResult, clsPubVar.CurrPrjDataBaseId);	//�����
            }
            catch (Exception objException)
            {
                //				clsCommonSession.seErrMessage = objException.Message;
                //				clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;	//"../GenCode/wfmGenViewCode_WebV5.aspx";
                //				clsPubFun4Web.AccessError(this, conCurrPageName);
                lblMsg2.Text = objException.Message;
            }
            tabQuery.Visible = false;
            tabCode.Visible = true;

        }

        protected void dgPrjTab_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
        {
            int intIndex;
            //�ж��Ƿ����µ������ֶ�
            intIndex = strSortBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                strSortBy = e.SortExpression + " Asc";
                BindDg_PrjTab();
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
            BindDg_PrjTab();

        }

        protected void dgPrjTab_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
        {
            int intIndex;
            if (strSortBy == "") return;
            if (e.Item.ItemType == ListItemType.Header)//����ؼ��Ƿ�Ϊҳü��
            {
                string strSortEx;
                for (int i = 0; i < this.dgPrjTab.Columns.Count; i++)
                {
                    strSortEx = this.dgPrjTab.Columns[i].SortExpression;
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

        protected void lbGeneNewTabInSQL_Click(object sender, System.EventArgs e)
        {
            string strConnectString = clsPrjDataBaseBLEx.GetConnectString(clsPubVar.CurrPrjDataBaseId);
            //			tabQuery.Visible = false;
            //			tabCode.Visible = true;
            //string strSql;
            //string strTabName;
            string strTabId = (string)rd.Value;
            if (strTabId.Trim().Length == 0)
            {
                lblMsg2.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
                return;
            }
         
            lblMsg2.Text = "";
            try
            {
                //AutoGC5Cs_M autoGC5Cs_M = new AutoGC5Cs_M(strTabId, clsPubVar.CurrPrjDataBaseId);
                //autoGC5Cs_M.objPrjTabENEx.FolderName = "D:\\FTP\\ClsFile\\" + clsCommonSession.UserId + "\\";
                //autoGC5Cs_M.objPrjTabENEx.CurrUserName = clsCommonSession.UserName;
                //strSql = autoGC5Cs_M.A_GenSQLCode4CreateTab(clsPubVar.CurrPrjDataBaseId);	//�����
                //clsProjectsEN objProjects = clsProjectsBL.GetObjByPrjIdCache(clsPubVar.CurrSelPrjId);
                //clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
                //strTabName = clsPrjTabBL.GetObjByTabId(strTabId).TabName;
                //if (objSQL.IsExistTable(strTabName) == true)
                //{
                //    lblMsg2.Text = strTabName + "���Ѵ���!!";
                //    return;
                //}
                //if (objSQL.ExecSql(strSql) == true)
                //{
                //    lblMsg2.Text = "�½���ɹ�!";
                //};
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


        //protected void btnGenGeneLogicCode_Oracle_Click(object sender, EventArgs e)
        //{

        //    Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
        //    
        //    string strTabId = (string)rd.Value;
        //    if (strTabId.Trim().Length == 0)
        //    {
        //        lblMsg2.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
        //        return;
        //    }
        //    if (CheckTabFieldBySqlTab(strTabId) == false)
        //    {
        //        return;
        //    }

        //    lblMsg2.Text = "";
        //    try
        //    {
        //        AutoGC6Cs_M_Ora autoGC5Cs_M = new AutoGC6Cs_M_Ora(strTabId, clsPubVar.CurrPrjDataBaseId);
        //        autoGC5Cs_M.objPrjTabENEx.FolderName = "D:\\FTP\\ClsFile\\" + clsCommonSession.UserId + "\\";
        //        autoGC5Cs_M.objPrjTabENEx.CurrUserName = clsCommonSession.UserName;
        //        ShowCode(autoGC5Cs_M.A_GenGeneralLogicCodeNew(myEncoding);   //�����
        //        string strClassFName = autoGC5Cs_M.objPrjTabENEx.FolderName + autoGC5Cs_M.objPrjTabENEx.ClsName + ".cs";
        //        clsPubFun4BLEx.SaveClassContentToFile(strClassFName, txtCode.Text, autoGC5Cs_M.objPrjTabENEx.FolderName_Root,
        //            autoGC5Cs_M.objPrjTabENEx.BackupFolderName, myEncoding);

        //    }
        //    catch (Exception objException)
        //    {
        //        //				clsCommonSession.seErrMessage = objException.Message;
        //        //				clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;	//"../GenCode/wfmGenViewCode_WebV5.aspx";
        //        //				clsPubFun4Web.AccessError(this, conCurrPageName);
        //        lblMsg2.Text = objException.Message;
        //    }
        //    tabQuery.Visible = false;
        //    tabCode.Visible = true;


        //}
        //protected void btnGenGeneLogicCodeEx_Oracle_Click(object sender, EventArgs e)
        //{

        //    Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
        //    
        //    string strTabId = (string)rd.Value;
        //    if (strTabId.Trim().Length == 0)
        //    {
        //        lblMsg2.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
        //        return;
        //    }
        //    if (CheckTabFieldBySqlTab(strTabId) == false)
        //    {
        //        return;
        //    }
        
        //    lblMsg2.Text = "";
        //    try
        //    {
        //        AutoGC6Cs_M_Ora autoGC5Cs_M = new AutoGC6Cs_M_Ora(strTabId, clsPubVar.CurrPrjDataBaseId);
        //        autoGC5Cs_M.objPrjTabENEx.FolderName = "D:\\FTP\\ClsFile\\" + clsCommonSession.UserId + "\\";
        //        autoGC5Cs_M.objPrjTabENEx.CurrUserName = clsCommonSession.UserName;
        //        ShowCode(autoGC5Cs_M.A_GenGeneralExLogicCodeNew(myEncoding); //�����
        //        string strClassFName = autoGC5Cs_M.objPrjTabENEx.FolderName + autoGC5Cs_M.objPrjTabENEx.ClsName + ".cs";
        //        clsPubFun4BLEx.SaveClassContentToFile(strClassFName, txtCode.Text, autoGC5Cs_M.objPrjTabENEx.FolderName_Root,
        //            autoGC5Cs_M.objPrjTabENEx.BackupFolderName, myEncoding);
        //    }
        //    catch (Exception objException)
        //    {
        //        //				clsCommonSession.seErrMessage = objException.Message;
        //        //				clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;	//"../GenCode/wfmGenViewCode_WebV5.aspx";
        //        //				clsPubFun4Web.AccessError(this, conCurrPageName);
        //        lblMsg2.Text = objException.Message;
        //    }
        //    tabQuery.Visible = false;
        //    tabCode.Visible = true;


        //}
        protected void btnGenGeneExLogicCode_Click(object sender, EventArgs e)
        {

            Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            
            string strTabId = (string)rd.Value;
            if (strTabId.Trim().Length == 0)
            {
                lblMsg2.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
                return;
            }
            if (CheckTabFieldBySqlTab(strTabId) == false)
            {
                return;
            }

            lblMsg2.Text = "";
            try
            {
                //AutoGC5Cs_M autoGC5Cs_M = new AutoGC5Cs_M(strTabId, clsPubVar.CurrPrjDataBaseId);
                //autoGC5Cs_M.objPrjTabENEx.FolderName = "D:\\FTP\\ClsFile\\" + clsCommonSession.UserId + "\\";
                //autoGC5Cs_M.objPrjTabENEx.CurrUserName = clsCommonSession.UserName;
                //ShowCode(autoGC5Cs_M.A_GenGeneralExLogicCode(myEncoding);	//�����
            }
            catch (Exception objException)
            {
                //				clsCommonSession.seErrMessage = objException.Message;
                //				clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;	//"../GenCode/wfmGenViewCode_WebV5.aspx";
                //				clsPubFun4Web.AccessError(this, conCurrPageName);
                lblMsg2.Text = objException.Message;
            }
            tabQuery.Visible = false;
            tabCode.Visible = true;

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
                    clsCommonJsFunc.Alert(this, string.Format("��ҳ�����ƣ�[{0}]��({1})��û�д���", qsParentPage,                         
                        clsStackTrace.GetCurrClassFunction()));
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