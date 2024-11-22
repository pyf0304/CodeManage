///���ɲ�ѯ���޸ģ�ɾ������Ӽ�¼�Ŀ��Ʋ����
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
//using SqlSv; 
using com.taishsoft.commdb;
using CommFunc4WebForm;


using AGC.Entity;

using AGC.BusinessLogic;using AGC.FunClass;

using AGC.BusinessLogicEx;

using com.taishsoft.datetime;
using System.Collections.Generic;

using com.taishsoft.common;

namespace AGC.Webform
{
    /// <summary>
    /// wfmSetViewStyle ��ժҪ˵��������Q�����ѯ��U�����޸�
    /// </summary>
    public partial class wfmSetViewStyle : CommWebPageBase
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
            ClientScript.RegisterStartupScript(this.GetType(), "js", js);
            //            this.RegisterStartupScript("js", js); 
            // �ڴ˴������û������Գ�ʼ��ҳ��
            if (!IsPostBack)	///����������ǳ��α����ã������ǵ�����ť�¼�������
            {
                ///����Ӧ�����صĿؼ�����
                ///
                tabHidden.Visible = false;
                //if (clsCommForWebForm.SystemStatus == "DEBUG")
                //{
                //    PrjId = "0005";
                //    txtUserIdq.Text = "pyf";
                //    clsUsersEN objUsers = new clsUsersEN("pyf", true);
                //    objUser = objUsers;
                //}
                //1��Ϊ��������������Դ�����б�����
                wucViewStyle1.SetDdl_TitleStyleId(clsPubVar.CurrSelPrjId);
                wucViewStyle1.SetDdl_DgStyleId();
                
                clsViewInfoBLEx.BindDdl_ApplicationTypeIdExCache(ddlApplicationTypeId, clsPubVar.CurrSelPrjId);
                clsFuncModule_AgcBLEx.BindDdl_FuncModuleId(ddlFuncModuleIdq, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId);
                //BindDdl_ViewTypeCode(ddlViewTypeCodeq);
              clsProjectsBLEx.BindDdl_PrjIdCacheEx(ddlPrjIdq);
                ///���õ�ǰ��¼�û���Ĭ�Ϲ���
                ddlPrjIdq.SelectedValue = clsPubVar.CurrSelPrjId;

                //�ָ���һ���ڴ˽����״̬
                if (seFuncModuleAgcId != "")
                {
                    clsDropDownList.SetDdlValue(ddlFuncModuleIdq, seFuncModuleAgcId);
                }
                if (ViewTypeCode != "")
                {
                    clsDropDownList.SetDdlValue(ddlViewTypeCodeq, ViewTypeCode);
                }
                txtViewNameq.Text = ViewName;
                //=====================================

                //2����ʾ�������ı�������DATAGRID��
                strSortViewStyleBy = "ViewName Asc";
                BindGv_ViewStyle();
                //3�����ñ�ؼ����ֿؼ���ReadOnly���ԣ�
                //   ʹֻ֮������Ϊ���޸Ĺ����йؼ����ǲ��ܱ��޸ĵġ�
                wucViewStyle1.SetKeyReadOnly(true);
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


        private string seUserId
        {
            get
            {
                string strUserId;
                strUserId = (string)Session["UserId"];
                if (strUserId == null)
                {
                    strUserId = "";
                    clsCommForWebForm.CheckUserId(strUserId, this);
                }
                return strUserId;
            }
            set
            {
                string strUserId = value;
                Session.Add("UserId", strUserId);
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
                }
                return pobjUser;
            }
            set
            {
                clsUsersEN pobjUser = value;
                Session.Add("objUser", pobjUser);
            }
        }

      
     

        
        /// <summary>
        /// �����еĲ�ѯ�ؼ�������ϳ�һ��������
        /// </summary>
        /// <returns>������(strWhereCond)</returns>
        private string CombineViewStyleCondition()
        {
            //ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
            //���� 1=1 and UserName = '����'
            string strWhereCond = " 1=1 ";
            //����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
            if (this.txtViewNameq.Text.Trim() != "")
            {
                strWhereCond += " and ViewName like '" + this.txtViewNameq.Text.Trim() + "%'";
            }
            if (this.ddlViewTypeCodeq.SelectedValue != "" && this.ddlViewTypeCodeq.SelectedValue != "0")
            {
                strWhereCond += " and ViewTypeCode='" + this.ddlViewTypeCodeq.SelectedValue + "'";
            }
            if (this.ddlFuncModuleIdq.SelectedValue != "" && this.ddlFuncModuleIdq.SelectedValue != "0")
            {
                strWhereCond += " And FuncModuleAgcId='" + this.ddlFuncModuleIdq.SelectedValue + "'";
            }
            if (this.txtMainTabNameq.Text.Trim() != "")
            {
                strWhereCond += " and MainTabName like '" + this.txtMainTabNameq.Text.Trim() + "%'";
            }
            if (this.txtUserIdq.Text.Trim() != "")
            {
                strWhereCond += " and UserId='" + this.txtUserIdq.Text.Trim() + "'";
            }
            if (this.ddlPrjIdq.SelectedValue != "" && this.ddlPrjIdq.SelectedValue != "0")
            {
                strWhereCond += " and PrjId='" + this.ddlPrjIdq.SelectedValue + "'";
            }
            if (this.ddlApplicationTypeId.SelectedValue != "" && this.ddlApplicationTypeId.SelectedValue != "0")
            {
                strWhereCond += " And ApplicationTypeId='" + this.ddlApplicationTypeId.SelectedValue + "'";
            }
            return strWhereCond;
        }
        ///���ɰ�DATAGRID�Ĵ���
        /// <summary>
        /// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
        ///			 ����ʾ��DATAGRID�С�
        /// </summary>
        protected void BindGv_ViewStyle()
        {
            //��������:(��5��)
            //	1����Ͻ�����������
            //	2��������������ȡ�ñ�����������DataTable��
            //	4������GridView������Դ(DataSource)��
            //	5����GridView,����DataTable��������ʾ��GridView��
            //	6�����ü�¼����״̬,
            //		�ڱ��������ǰ�״̬��ʾ�ڿؼ�txtRecCount�С�

            System.Data.DataTable objDT = null;
            try
            {
                //	1����Ͻ�����������
                string strWhereCond = CombineViewStyleCondition();
                //	2��������������ȡ�ñ�����������DataTable��
                objDT = clsvViewInfoBL.GetDataTable_vViewInfo(strWhereCond);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "(errid:WebI001079)��ȡ���ݱ�(DataTable)���ɹ�!" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            //	4������GRIDView������Դ(DataSource)��
            DataView objDV = objDT.DefaultView;
            objDV.Sort = strSortViewStyleBy; ///ע����һ�д����п�����Ҫע�͵�,Ŀǰ���н����ڵ����Ĳ�ѯ������������
                                             ///����GridView��ÿҳ�ļ�¼��
            if (string.IsNullOrEmpty(PageSize) == false)
            {
                int intPageSize = int.Parse(PageSize);
                gvViewStyle.PageSize = intPageSize;
            }
            else
            {
                PageSize = "10";
                gvViewStyle.PageSize = 10;
            }
            this.gvViewStyle.DataSource = objDV;
            //	5����GridView,����DataTable��������ʾ��GridView��
            this.gvViewStyle.DataBind();

            ///����ר������BindGv�е���ҳ��ش���
            GridViewRow pagerRow = gvViewStyle.BottomPagerRow;
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
                lblAllPages.Text = this.gvViewStyle.PageCount.ToString();
                //��ǰҳ����
                lblCurrentPage.Text = (this.gvViewStyle.PageIndex + 1).ToString();
                //��ǰ����������ҳ����
                txtJump2Page.Text = (this.gvViewStyle.PageIndex + 1).ToString();
                //�����ǰҳ����Ϊ0,��<ǰһҳ>��ť��Ч
                if (this.gvViewStyle.PageIndex == 0)
                {
                    btnPrevPage.Enabled = false;
                }
                else
                {
                    btnPrevPage.Enabled = true;
                }
                //�����ǰҳ������Ϊ���һҳ,��<ǰһҳ>��ť��Ч
                if (this.gvViewStyle.PageIndex == this.gvViewStyle.PageCount - 1)
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
            gvViewStyle.BottomPagerRow.Visible = true;
        }
        /// <summary>
        /// ר�����ڼ�¼GridView�е�ÿҳ��¼��
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenPageSizeViewState)
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
            this.gvViewStyle.PageIndex = 0;
            //�ѱ��¼��������ʾ��DATAGRID��
            BindGv_ViewStyle();
            //������β�ѯ������Ϊ��һ�������ý������
            seFuncModuleAgcId = ddlFuncModuleIdq.SelectedValue;
            ViewTypeCode = ddlViewTypeCodeq.SelectedValue;
            ViewName = txtViewNameq.Text;

        }
        /// <summary>
        /// �������ܣ��¼��������ڸ���DATAGRID�ĵ�ǰҳ����ʱ�����ĺ�����
        ///			  ���幦����������ʾ��ҳ(������ҳ����)�����ݡ�
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
         protected void gvViewStyle_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            //�������裺����2����
            //1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
            //2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ

            //1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
            this.gvViewStyle.PageIndex = e.NewPageIndex;
            //2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ
            BindGv_ViewStyle();
        }

        /// <summary>
        /// �������ܣ��¼�������������<ȷ���޸�>ʱ�������¼�������
        ///           ���幦��Ϊ�ѽ�������ͬ�����ݿ��У��ѽ������ݱ��浽���ݿ���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOKUpd_Click(object sender, System.EventArgs e)
        {
            string strMsg;  //ר�����ڴ�����Ϣ�ı���
            string strResult = "";
            string strCommandText;
            clsViewStyleEN objViewStyleEN;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "ȷ������":
                    //����һ������Ĳ���Ĵ��룬�����߼���̫�򵥣�
                    //�Ͱ��߼���ϲ������Ʋ�,
                    //�������裺
                    //1�����ؼ����������������Ƿ���ȷ
                    //2��������󲢳�ʼ������
                    //3���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
                    //4����ֵ�ӽ���㴫���߼��������ʵ���
                    //5����鴫��ȥ�Ķ��������Ƿ�Ϸ�
                    //6��������ʵ�������ݴ��������ݿ���
                    //7��������ļ�¼������ʾ��DATAGRID��
                    //1�����ؼ����������������Ƿ���ȷ
                    ///
                    

                    if (!wucViewStyle1.IsValid(ref strResult))
                    {
                        lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
                        return;
                    }
                    //2����ֵ�ӽ���㴫���߼��������ʵ���
                    objViewStyleEN = (clsViewStyleEN)Session["objViewStyleEN"];
                    if (objViewStyleEN == null)
                    {
                        objViewStyleEN = new clsViewStyleEN();
                    }
                    PutDataToViewStyleClass(objViewStyleEN);		//�ѽ����ֵ����
                    //3����鴫��ȥ�Ķ��������Ƿ�Ϸ�
                    try
                    {
                        clsViewStyleBL.CheckPropertyNew(objViewStyleEN);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
				
                    //4��������ʵ���������޸�ͬ�������ݿ���
                    if (clsViewStyleBL.IsExist(objViewStyleEN.ViewId) == false)
                    {
                        if (clsViewStyleBL.AddNewRecordBySql2(objViewStyleEN) == false)
                        {
                            strMsg = "�޸ļ�¼���ɹ�!";
                            clsCommonJsFunc.Alert(this, strMsg);
                            lblMsg.Text = "�޸ļ�¼���ɹ�!";
                        }
                        else
                        {
                            strMsg = "�޸ļ�¼�ɹ�!";
                            clsCommonJsFunc.Alert(this, strMsg);
                            lblMsg.Text = "�޸ļ�¼�ɹ�!";
                        }
                    }
                    else
                    {
                        if (clsViewStyleBL.UpdateBySql2(objViewStyleEN) == false)
                        {
                            strMsg = "�޸ļ�¼���ɹ�!";
                            clsCommonJsFunc.Alert(this, strMsg);
                            lblMsg.Text = "�޸ļ�¼���ɹ�!";
                        }
                        else
                        {
                            strMsg = "�޸ļ�¼�ɹ�!";
                            clsCommonJsFunc.Alert(this, strMsg);
                            lblMsg.Text = "�޸ļ�¼�ɹ�!";
                        }
                    }
                    //5�����޸ĺ��������ʾ��DATAGRID��
                    BindGv_ViewStyle();
                    wucViewStyle1.Clear();//��տؼ��е�����
                    //�ָ�<ȷ���޸�>���<���>
                    //tabLayout.Visible = false;
                    break;
            }
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
    

        protected void gvViewStyle_ItemDataBound(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
        {
            //			System.Web.UI.WebControls.CheckBox chkIsSort, chkIsTransCode;
            if (e.Item.ItemType == ListItemType.Item ||
                e.Item.ItemType == ListItemType.SelectedItem ||
                e.Item.ItemType == ListItemType.AlternatingItem ||
                e.Item.ItemType == ListItemType.EditItem)
            {
                int[] iNum = new int[20];
                iNum[0] = 11;
                iNum[1] = 12;
                for (int i = 0; i < 2; i++)
                {
                    if (e.Item.Cells[iNum[i]].Text == "True")
                    {
                        e.Item.Cells[iNum[i]].Text = "��";
                        e.Item.Cells[iNum[i]].ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        e.Item.Cells[iNum[i]].Text = "��";
                        e.Item.Cells[iNum[i]].ForeColor = System.Drawing.Color.Red;
                    };
                }
                //				chkIsSort = (System.Web.UI.WebControls.CheckBox)e.Item.FindControl("chkIsSort");
                //				string strIsSort = e.Item.Cells[11].Text;
                //				chkIsSort.Checked = bool.Parse(strIsSort);
                //
                //				chkIsTransCode = (System.Web.UI.WebControls.CheckBox)e.Item.FindControl("chkIsTransCode");
                //				string strIsTransCode = e.Item.Cells[13].Text;
                //				chkIsTransCode.Checked = bool.Parse(strIsTransCode);

            }
        }


        protected void lbDispViewList_Click(object sender, System.EventArgs e)
        {
            tabQuery1.Visible = true;
            tabLayout.Visible = false;
        }


        protected void btnSetViewStyle_Click(object sender, System.EventArgs e)
        {
            List<string> lstKeyValue = clsCommForWebForm.GetFirstCheckedItemFromGv(gvViewStyle, "ViewId");
            if (lstKeyValue.Count == 0)
            {
                lblMsg2.Text = "(errid:WebI001087)û��ѡ���¼,��ѡ��һ����Ч�ı��¼!";
                return;
            }
            lblMsg2.Text = "";
            //1����ʾ�ùؼ��ֵ��������û��޸ĸùؼ��ּ�¼��
            string[] strKeys = lstKeyValue[0].Split(',');
            string strViewId = strKeys[0];
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "û��ѡ���¼����ѡ��һ����Ч�Ľ����¼!";
                return;
            }
            lblMsg2.Text = "";
            Session.Add("ViewId", strViewId);

            ShowData(strViewId);
            //2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
            clsPubFun.SetButtonEnabled(btnOKUpd, true);
            wucViewStyle1.SetKeyReadOnly(true);
            btnOKUpd.Text = "ȷ������";
            lblMsg.Text = "";
            tabLayout.Visible = true;

        }

        /// <summary>
        /// �������ܣ����Ըùؼ��ֵļ�¼������ʾ�ڽ����ϣ�
        ///������     �������ǰ�ֵ������ؼ���
        /// </summary>
        /// <param name="strDgStyleId">���¼�Ĺؼ��֣���ʾ�ñ�ؼ��ֵ�����</param>
        private void ShowData(string strViewId)
        {
            //�������裺
            //1�����ؼ����Ƿ�Ϊ�գ�
            //2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
            //3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
            //4����ȡ�������������ԣ�
            //5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���
            clsViewStyleEN objViewStyleEN = new clsViewStyleEN(strViewId);
            //1�����ؼ����Ƿ�Ϊ�գ�
            if (strViewId == "") return;		//����ؼ���Ϊ�վͷ����˳�
            //2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
            if (clsViewStyleBL.IsExist(strViewId) == false)		//���ùؼ��ֵļ�¼�Ƿ����
            {
                objViewStyleEN.DgStyleId = "0001";
                objViewStyleEN.TitleStyleId = "0001";
                clsViewStyleBL.AddNewRecordBySql2(objViewStyleEN);
            }
            else
            {
                //3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������

                //4����ȡ�������������ԣ�
                clsViewStyleBL.GetViewStyle(ref objViewStyleEN);
                Session.Add("objViewStyleEN", objViewStyleEN);
            }
            //5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���
            GetDataFromViewStyleClass(objViewStyleEN);
        }
        ///���ɴ��߼�������ݴ��䵽�����ĺ�������
        /// <summary>
        /// �������ܣ�������������������ʾ��������
        ///ע�⣺��������������򣬲�����һ��������������ϵ�ģ�����Ϊһ��������ֵ��Ȼ����Ϊ����������ֵ
        ///      ������������ݿ�ʱ����Ӧ��һ���ֶ���ǰ�������ֶ��ں�
        /// </summary>
        /// <param name="pobjViewStyle">��ʵ�������</param>
        private void GetDataFromViewStyleClass(clsViewStyleEN pobjViewStyle)
        {
            wucViewStyle1.ViewId = pobjViewStyle.ViewId;
            wucViewStyle1.TitleStyleId = pobjViewStyle.TitleStyleId;
            wucViewStyle1.DgStyleId = pobjViewStyle.DgStyleId;
        }
        
        /// <summary>
        /// �������ܣ��ѽ����ϵ��������ݴ����������
        /// </summary>
        /// <param name="pobjViewStyle">���ݴ����Ŀ�������</param>
        private void PutDataToViewStyleClass(clsViewStyleEN pobjViewStyle)
        {
            pobjViewStyle.ViewId = wucViewStyle1.ViewId;
            pobjViewStyle.TitleStyleId = wucViewStyle1.TitleStyleId;
            pobjViewStyle.DgStyleId = wucViewStyle1.DgStyleId;
        }
        /// <summary>
        /// �¼���������GridView�У�������ͷ�����������������¼�
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:Gen_GridView_Sorting)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gvViewStyle_Sorting(object sender, GridViewSortEventArgs e)
        {
            int intIndex;
            //�ж��Ƿ����µ������ֶ�
            intIndex = strSortViewStyleBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                strSortViewStyleBy = e.SortExpression + " Asc";
                BindGv_ViewStyle();
                return;
            }
            //���ԭ��������
            intIndex = strSortViewStyleBy.IndexOf(" Asc");
            if (intIndex == -1)     //���ԭ���������������Ϊ����
            {
                strSortViewStyleBy = e.SortExpression + " Asc";
            }
            else            ///��������Ϊ����
            {
                strSortViewStyleBy = e.SortExpression + " Desc";
            }
            BindGv_ViewStyle();
        }
 
        protected void gvViewStyle_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
        {
            int intIndex;
            if (strSortViewStyleBy == "") return;
            if (e.Item.ItemType == ListItemType.Header)//����ؼ��Ƿ�Ϊҳü��
            {
                string strSortEx;
                for (int i = 0; i < this.gvViewStyle.Columns.Count; i++)
                {
                    strSortEx = this.gvViewStyle.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = strSortViewStyleBy.IndexOf(strSortEx + " ");
                    if (intIndex >= 0)  //��ͼ״̬��������ʽ�Ƿ�Ϊ���е��ֶΣ�
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//�������壬��"webdings"��5�������ǣ�6�������ǣ�
                        intIndex = strSortViewStyleBy.IndexOf("Asc");
                        lblSort.Text = (intIndex > 0 ? " 5" : " 6");//�Ƿ�Ϊ���򣬶���Ϊstring�ͣ�
                        e.Item.Cells[i].Controls.Add(lblSort);//��������ĵ�i����Ԫ��������һ�ؼ���
                        break;
                    }
                }
            }
        }

        private string strSortViewStyleBy
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
      
        protected void ddlApplicationTypeId_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strApplicationTypeId = ddlApplicationTypeId.SelectedValue;
            if (strApplicationTypeId != null && strApplicationTypeId != "")
            {
                clsViewTypeCodeTabBLEx.BindDdl_ViewTypeCodeByAppIdCache(ddlViewTypeCodeq, int.Parse( strApplicationTypeId));
            }

        }

        #region ��������

     
     

        #endregion ��������




        /// <summary>
        /// �¼���������������ҳ����غ���.��GridView�ĽŲ�����������ת��ťʱ�������¼�����������Ҫ������ת��GridView��ĳһ����
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenJumpPage_RelaFunction)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnJumpPage_Click(object sender, EventArgs e)
        {
            GridViewRow pagerRow = gvViewStyle.BottomPagerRow;
            TextBox txtJump2Page = (TextBox)pagerRow.FindControl("txtJump2Page");
            if (txtJump2Page != null)
            {
                if (txtJump2Page.Text.Trim() != "" &&
                int.Parse(txtJump2Page.Text) > 0 &&
                int.Parse(txtJump2Page.Text) - 1 < this.gvViewStyle.PageCount)
                {
                    this.gvViewStyle.PageIndex = int.Parse(txtJump2Page.Text) - 1;
                }
                this.BindGv_ViewStyle();
            }
        }


        /// <summary>
        /// �¼���������GridView�ĽŲ�����ÿҳ��¼�������������ı�ʱ�������¼�����������Ҫ�����ı�GridView��ÿҳ��¼����
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenddlPagerRecCount_SelectedIndexChanged)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    BindGv_ViewStyle();
                }
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