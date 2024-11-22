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
using AGC.BusinessLogic;using AGC.FunClass;using AGC.BusinessLogicEx;

namespace AGC.Webform
{
    /// <summary>
    /// wfmPrjTab_QUDI ��ժҪ˵��������Q�����ѯ��U�����޸�
    /// </summary>
    public partial class wfmPrjTab_Check : System.Web.UI.Page
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
            //this.RegisterStartupScript("js",js);
            ClientScript.RegisterStartupScript(this.GetType(), "js", js);


            // �ڴ˴������û������Գ�ʼ��ҳ��
            if (!IsPostBack)	///����������ǳ��α����ã������ǵ�����ť�¼�������
            {

                ///����Ӧ��Ӧ�����صĿؼ�����

                //1��Ϊ��������������Դ�����б�����
                //clsvPrjObjects4DdlBLEx.BindDdl_ObjId(ddlObjIdq, clsPubVar.CurrSelPrjId);
                clsFuncModule_AgcBLEx.BindDdl_FuncModuleId(ddlFuncModuleId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId);
                clsTabStateBL.BindDdl_TabStateIdCache(ddlTabStateIdq);

                //�ָ���һ���ڴ˽����״̬
                if (seFuncModuleAgcId != "")
                {
                    clsDropDownList.SetDdlValue(ddlFuncModuleId, seFuncModuleAgcId);
                }
                if (ObjId != "")
                {
                    clsDropDownList.SetDdlValue(ddlObjIdq, ObjId);
                }
                txtTabNameq.Text = TabName;
                txtTabCnNameq.Text = TabCnName;
                //=====================================================

                ddlTabStateIdq.SelectedValue = "01";

                //2����ʾ�������ı�������DATAGRID��
                vsSortPrjTabBy = "TabName Asc";
                BindDg_PrjTab();
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

        private string UserId
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
        private string strPotenceLevel
        {
            get
            {
                string sPotenceLevel;
                sPotenceLevel = (string)ViewState["PotenceLevel"];
                if (sPotenceLevel == null)
                {
                    //					sPotenceLevel=new General_Platform_Dll.MenuAndPotence().Get_PotenceLevel(ViewId);
                    sPotenceLevel = "9";
                    ViewState.Add("PotenceLevel", sPotenceLevel);
                }
                return sPotenceLevel;
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
        //        }
        //        return strPrjId;
        //    }
        //    set
        //    {
        //        string strPrjId = value;
        //        Session.Add("PrjId", strPrjId);
        //    }
        //}


        
        /// <summary>
        /// �����еĲ�ѯ�ؼ�������ϳ�һ��������
        /// </summary>
        /// <returns>������(strWhereCond)</returns>
        private string CombineCondition()
        {
            //ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
            //���� 1=1 and UserName = '����'
            string strWhereCond = " 1=1 and PrjId= '" + clsPubVar.CurrSelPrjId + "'";
            //����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
            if (this.txtTabCnNameq.Text.Trim() != "")
            {
                strWhereCond += " and TabCnName like '" + this.txtTabCnNameq.Text.Trim() + "%'";
            }
            if (this.txtTabNameq.Text.Trim() != "")
            {
                strWhereCond += " and TabName like '" + this.txtTabNameq.Text.Trim() + "%'";
            }
            if (this.ddlObjIdq.SelectedValue != "" && this.ddlObjIdq.SelectedValue != "0")
            {
                strWhereCond += " and ObjId='" + this.ddlObjIdq.SelectedValue + "'";
            }
            if (this.ddlFuncModuleId.SelectedValue != "" && this.ddlFuncModuleId.SelectedValue != "0")
            {
                strWhereCond += " and FuncModuleAgcId='" + this.ddlFuncModuleId.SelectedValue + "'";
            }
            if (this.ddlTabStateIdq.SelectedValue != "" && this.ddlTabStateIdq.SelectedValue != "0")
            {
                strWhereCond += " And TabStateId='" + this.ddlTabStateIdq.SelectedValue + "'";
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
            objDV.Sort = vsSortPrjTabBy;
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
            ObjId = ddlObjIdq.SelectedValue;
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


        /// <summary>
        /// ѡ��ı�������ֶΡ�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void lbAddField_Click(object sender, System.EventArgs e)
        {
            string strTabId = (string)rd.Value;
            if (strTabId.Trim().Length == 0)
            {
                lblMsg2.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
                return;
            }
            lblMsg2.Text = "";
            Session.Add("TabId", strTabId);
            string strFileFolder = Server.MapPath("~");

            clsPrjTabFldBLEx.ReNumber(strTabId);
            Response.Redirect("wfmPrjTabFld_QUDI.aspx");
        }


        protected void lbDispTabList_Click(object sender, System.EventArgs e)
        {
            tabQuery.Visible = true;
        }

        protected void dgPrjTab_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
        {
            int intIndex;
            //�ж��Ƿ����µ������ֶ�
            intIndex = vsSortPrjTabBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                vsSortPrjTabBy = e.SortExpression + " Asc";
                BindDg_PrjTab();
                return;
            }
            //���ԭ��������
            intIndex = vsSortPrjTabBy.IndexOf(" Asc");
            if (intIndex == -1)		//���ԭ���������������Ϊ����
            {
                vsSortPrjTabBy = e.SortExpression + " Asc";
            }
            else			///��������Ϊ����
            {
                vsSortPrjTabBy = e.SortExpression + " Desc";
            }
            BindDg_PrjTab();

        }

        protected void dgPrjTab_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
        {
            int intIndex;
            if (vsSortPrjTabBy == "") return;
            if (e.Item.ItemType == ListItemType.Header)//����ؼ��Ƿ�Ϊҳü��
            {
                string strSortEx;
                for (int i = 0; i < this.dgPrjTab.Columns.Count; i++)
                {
                    strSortEx = this.dgPrjTab.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = vsSortPrjTabBy.IndexOf(strSortEx + " ");
                    if (intIndex >= 0)  //��ͼ״̬��������ʽ�Ƿ�Ϊ���е��ֶΣ�
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//�������壬��"webdings"��5�������ǣ�6�������ǣ�
                        intIndex = vsSortPrjTabBy.IndexOf("Asc");
                        lblSort.Text = (intIndex > 0 ? " 5" : " 6");//�Ƿ�Ϊ���򣬶���Ϊstring�ͣ�
                        e.Item.Cells[i].Controls.Add(lblSort);//��������ĵ�i����Ԫ��������һ�ؼ���
                        break;
                    }
                }
            }
        }

        protected void lbSetChecked_Click(object sender, System.EventArgs e)
        {
            //�������裺
            //1����DG����ѭ��
            //2�����ÿһ���е�<�Ƿ�����><�Ƿ��ѯ>���ֶεı༭������д���
            //3����ѭ���г�ʼ��һ��clsPrjTabEN�������ùؼ���MID
            //4����ֵ��
            //5������
            ///
            System.Web.UI.WebControls.CheckBox chkIsChecked;
            //			System.Web.UI.WebControls.CheckBox chkIsArchive;
            string strFldId;
            bool bolIsChecked;		//, bolIsArchive;
            clsPrjTabEN objPrjTabEN;
            int intDgNum, intIndex;
            DataGridItem item;
            //1����DG����ѭ��
            intDgNum = dgPrjTab.Items.Count;
            for (intIndex = 0; intIndex < intDgNum; intIndex++)
            {
                item = dgPrjTab.Items[intIndex];
                strFldId = item.Cells[1].Text;
                //2�����ÿһ���е�<�Ƿ�����><�Ƿ��ѯ>���ֶεı༭������д���
                //3����ѭ���г�ʼ��һ��clsPrjTabEN�������ùؼ���MID
                objPrjTabEN = clsPrjTabBL.GetObjByTabId(strFldId);
                //4����ֵ��

                chkIsChecked = (System.Web.UI.WebControls.CheckBox)item.FindControl("chkIsChecked");
                bolIsChecked = chkIsChecked.Checked;

                //				chkIsArchive = (System.Web.UI.WebControls.CheckBox)item.FindControl("chkIsArchive");
                //				bolIsArchive = chkIsArchive.Checked;

                objPrjTabEN.IsChecked = bolIsChecked;
                //				objPrjTabEN.IsArchive = bolIsArchive;
                //5������
                if (clsPrjTabBL.UpdateBySql2(objPrjTabEN) == false)
                {
                    return;
                }
            }
            BindDg_PrjTab();
        }

        protected void dgPrjTab_ItemDataBound(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
        {
            System.Web.UI.WebControls.CheckBox chkIsChecked;	//, chkIsArchive;
            if (e.Item.ItemType == ListItemType.Item ||
                e.Item.ItemType == ListItemType.SelectedItem ||
                e.Item.ItemType == ListItemType.AlternatingItem ||
                e.Item.ItemType == ListItemType.EditItem)
            {
                int[] iNum = new int[20];
                iNum[0] = 10;
                //				iNum[1] = 7;
                for (int i = 0; i < 1; i++)
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
                chkIsChecked = (System.Web.UI.WebControls.CheckBox)e.Item.FindControl("chkIsChecked");
                string strIsChecked = e.Item.Cells[8].Text;
                chkIsChecked.Checked = bool.Parse(strIsChecked);
                //
                //				chkIsArchive = (System.Web.UI.WebControls.CheckBox)e.Item.FindControl("chkIsArchive");
                //				string strIsArchive = e.Item.Cells[10].Text;
                //				chkIsArchive.Checked = bool.Parse(strIsArchive);
            }
        }

        private string vsSortPrjTabBy
        {
            get
            {
                string sSortPrjTabBy;
                sSortPrjTabBy = (string)ViewState["SortPrjTabBy"];
                if (sSortPrjTabBy == null)
                {
                    sSortPrjTabBy = "";
                }
                return sSortPrjTabBy;
            }
            set
            {
                string sSortPrjTabBy = value;
                ViewState.Add("SortPrjTabBy", sSortPrjTabBy);
            }
        }


    }
}