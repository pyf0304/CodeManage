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
using System.Text;
using com.taishsoft.commdb;
using com.taishsoft.common;
using CommFunc4WebForm;


using AGC.Entity;

using AGC.BusinessLogic;using AGC.FunClass;

using AGC.BusinessLogicEx;
using System.Collections.Generic;

using com.taishsoft.datetime;



//public class ObjStruct
//{
//    public string strObjId;
//    public string strObjName;
//}

namespace AGC.Webform
{
    /// <summary>
    /// wfmFieldTab_QUDI ��ժҪ˵��������Q�����ѯ��U�����޸�
    /// </summary>
    public partial class wfmFieldTab_ReplaceField : CommWebPageBase
    {

        protected void Page_Load(object sender, System.EventArgs e)
        {
            // �ڴ˴������û������Գ�ʼ��ҳ��
            if (!IsPostBack)	///����������ǳ��α����ã������ǵ�����ť�¼�������
            {
              

                clsFuncModule_AgcBLEx.BindDdl_FuncModuleId(ddlFuncModuleIdq, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId);

                vsSortFieldTabBy = "FldName Asc";
                //2����ʾ�������ı�������DATAGRID��
                BindGv_FieldTab();
                //3�����ñ�ؼ����ֿؼ���ReadOnly���ԣ�
                //   ʹֻ֮������Ϊ���޸Ĺ����йؼ����ǲ��ܱ��޸ĵġ�
                tabQuery.Visible = false;
                tabPrjTab.Visible = false;
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
        ///����ר�����ڼ�¼GridView�е�ÿҳ��¼��
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
        private string CombineFieldTabCondition()
        {
            //ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
            //���� 1=1 and UserName = '����'
            string strWhereCond = string.Format(" 1=1 And PrjId='{0}'", clsPubVar.CurrSelPrjId);
            //����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�

            if (this.txtFldNameq.Text.Trim() != "")
            {
                strWhereCond += " and FldName like '" + this.txtFldNameq.Text.Trim() + "%'";
            }
        
            if (this.ddlTabIdq.SelectedValue != "" && this.ddlTabIdq.SelectedValue != "0")
            {
                strWhereCond += " and Fldid in (select fldid from FldObjTab where ObjId='" + this.ddlTabIdq.SelectedValue + "')";
            }
           
          

            return strWhereCond;
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
            this.gvFieldTab.PageIndex = 0;
            //�ѱ��¼��������ʾ��DATAGRID��
            BindGv_FieldTab();
        }

       

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
                    BindGv_FieldTab();
                }
            }
        }
     


        private void DeleteRecord(string strFldId)
        {
            if (clsFieldTabBLEx.IsCanDelUpd(strFldId) == false) return;
            try
            {
                clsFieldTabBL.DelRecord(strFldId);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "ɾ����¼���ɹ�!\r\n" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_FieldTab();

        }
        private void Set_DataGridAllChecked(DataGrid objDg, bool IsSelected)
        {
            if (objDg.Items.Count == 0)
            {
                return;
            }
            else
            {
                foreach (DataGridItem di in objDg.Items)
                {
                    CheckBox cb = (CheckBox)di.FindControl("chkCheckRec");
                    if (cb != null)
                    {
                        cb.Checked = IsSelected;
                    }
                }

            }
        }


        public void BindDdl_IsNull(System.Web.UI.WebControls.DropDownList objDDL)
        {
            ListItem li = new ListItem("��ѡ��...", "0");
            objDDL.Items.Add("��");
            objDDL.Items.Add("��");
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
            //Ϊ�������������ݵ�����������������б�����ֱ����ӵ�
            ///objDDL.Items.Add("��");
            ///objDDL.Items.Add("Ů");
        }
        public void BindDdl_IsPrimaryKey(System.Web.UI.WebControls.DropDownList objDDL)
        {
            ListItem li = new ListItem("��ѡ��...", "0");
            objDDL.Items.Add("��");
            objDDL.Items.Add("��");
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
            //Ϊ�������������ݵ�����������������б�����ֱ����ӵ�
            ///objDDL.Items.Add("��");
            ///objDDL.Items.Add("Ů");
        }

        protected void gvFieldTab_ItemDataBound(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
        {
            //			System.Web.UI.WebControls.CheckBox chkIsNull, chkIsPrimaryKey;
            if (e.Item.ItemType == ListItemType.Item ||
                e.Item.ItemType == ListItemType.SelectedItem ||
                e.Item.ItemType == ListItemType.AlternatingItem ||
                e.Item.ItemType == ListItemType.EditItem)
            {
                int[] iNum = new int[20];
                iNum[0] = clsCommForWebForm.GetIndexByDataField4GridView(gvFieldTab, convFieldTab.IsNull); //8;
                iNum[1] = clsCommForWebForm.GetIndexByDataField4GridView(gvFieldTab, convFieldTab.IsPrimaryKey); //9;
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
            }
        }
        /// <summary>
        /// ����Excel�ļ����ֶ�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void lbImportExcelFld_Click(object sender, System.EventArgs e)
        {
            Response.Redirect("wfmImportFldInfoFromExcel.aspx");
        }


        protected void lbImportSQLFld_Click(object sender, System.EventArgs e)
        {
            Response.Redirect("wfmImportFldInfoFromSQL.aspx");

        }

  
    

        protected void lbDelFld_Click(object sender, System.EventArgs e)
        {
            ArrayList objArr = new ArrayList();
            objArr = clsCommForWebForm.Get_GvCheckedArr(this.gvFieldTab);
            try
            {
                //�����־
                string strUserId = clsCommonSession.UserId;
                string strUserIp = Request.UserHostAddress;
                string strUserName = clsUsersBL.GetObjByUserId(clsCommonSession.UserId).UserName;
                string strOperationType = clsOperationTypeBLEx.DELETE_RECORD; //ɾ����¼;
                string strTableName = "FieldTab";
                clsFieldTabEN objFieldTabEN = null;
                foreach (string strFldId in objArr)
                {
                    string strTableKey = strFldId;
                    objFieldTabEN = clsFieldTabBL.GetObjByFldId(strFldId);
                    string strJournal = "ִ����ɾ��������ɾ����FieldTab! �ֶ�����"
                        + objFieldTabEN.Caption + "(" + objFieldTabEN.FldName + ")";
                    
                    bool IsSuccesful = true;
                    IsSuccesful = clsSysLogServerBLEx.AddSysLogInfo(strUserId,
                        strUserIp,
                        strOperationType,
                        strTableName,
                        strTableKey,
                        strJournal,
                        clsPubVar.CurrSelPrjId);
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "ɾ����¼�����־���ɹ�!\r\n" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            try
            {
                string strObjId = ddlTabIdq.SelectedValue;
                if (ddlTabIdq.SelectedIndex >= 1)
                {
                    foreach (string strFldId in objArr)
                    {
                        clsFieldTabBLEx.DelFieldTabBySp(strFldId, strObjId);
                    }
                    //string strMsg = "��ѡ��һ�����ʵĶ�����!";
                    //clsCommonJsFunc.Alert(this, strMsg);
                    //return;
                }
                else
                {
                    foreach (string strFldId in objArr)
                    {
                        clsFieldTabBL.DelRecord(strFldId);
                    }
                }
                //clsFieldTabBLEx.DelFieldTabEx(objArr);

            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "ɾ����¼���ɹ�!\r\n" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }

            BindGv_FieldTab();

            //			Response.Write("<script>alert('��ѡ�ֶ��Ѿ�ɾ����')</script>");
        }

        protected void ddlObjId_q_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            string strObjId = ddlTabIdq.SelectedValue;
            List<string> arrLst = new List<string>();
            arrLst = clsGeneralTab2.funGetFldValue("PrjTab", "TabName", "ObjId = '" + strObjId + "'");
            if (arrLst == null || arrLst.Count == 0)
                return;
         
        }
        /// <summary>
        /// ����ѡ����������ֶΣ����Ƶ���ر��У�ͬʱɾ��������û�е��ֶ�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void lbSynchWithTab_Click(object sender, System.EventArgs e)
        {
            //�������裺
            //1����ȡ��ǰ��ID����ض���ID��
            //2����ȡ��ض���ID���ֶ�ID��DataTable;
            //3���Ըñ����ѭ�������ֶ���Ϣ���뵽һ��ArrayList
            //4���ڲ�������У�Ҫע���ֶ�ID���ظ������ܲ����ظ�
            //			string strWhereCond;
            string strObjId;
            //1����ȡ��ǰ��ID����ض���ID��
            strObjId = ddlTabIdq.SelectedValue;
            if (strObjId == null || strObjId.Length == 0)
            {
                return;
            }
            //if (clsPrjObjectsBLEx.SynchWithTab(strObjId, clsCommonSession.UserId, clsPubVar.CurrSelPrjId) == true)
            //{
            //    Response.Write("<script>alert('����ض������ֶ���Ϣ�ɹ�����')</script>");
            //}
            //else
            //{
            //    Response.Write("<script>alert('�ö���������ر�ͬ��������������ԣ����߸ö���û����ص��ֶΣ���')</script>");
            //}



        }

        protected void btnQueryForAdvanced_Click(object sender, System.EventArgs e)
        {
            //��DATAGRID�ĵ�ǰҳ��������Ϊ0������1ҳ��
            //��������ѯʱ��������ʾ���Ǳ��¼���ݵĵ�һ�������ݡ�
            this.gvFieldTab.PageIndex = 0;
            //�ѱ��¼��������ʾ��DATAGRID��
            BindGv_FieldTab();
        }
       


        protected void ddlFuncModuleId_q_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (ddlFuncModuleIdq.SelectedIndex > 0)
            {
                string strFuncModuleId = ddlFuncModuleIdq.SelectedValue;
                clsPrjTabBLEx.BindDdl_TabIdExCache(ddlTabIdq, clsPubVar.CurrSelPrjId, strFuncModuleId);
            }
        }

        protected void lbDelFieldTabEx_Click(object sender, System.EventArgs e)
        {
            string strUserIp = Request.UserHostAddress;
            ArrayList objArr = new ArrayList();
            objArr = clsCommForWebForm.Get_GvCheckedArr(this.gvFieldTab);
            List<string> objArr2 = clsArray.CopyArrayListToList_String(objArr);
            try
            {
                //�����־
                string strUserId = clsCommonSession.UserId;
                //				string strUserIp = Request.UserHostAddress;
                string strUserName = clsUsersBL.GetObjByUserId(clsCommonSession.UserId).UserName;
                string strOperationType = clsOperationTypeBLEx.DELETE_RECORD; //ɾ����¼;
                string strTableName = "FieldTab";
                clsFieldTabEN objFieldTabEN = null;
                foreach (string strFldId in objArr)
                {
                    string strTableKey = strFldId;
                    objFieldTabEN = new clsFieldTabEN(strFldId);
                    clsFieldTabBL.GetFieldTab(ref objFieldTabEN);
                    string strJournal = "ִ����ɾ��������ɾ����FieldTab! �ֶ�����"
                        + objFieldTabEN.Caption + "(" + objFieldTabEN.FldName + ")";
                    
                    bool IsSuccesful = true;
                    IsSuccesful = clsSysLogServerBLEx.AddSysLogInfo(strUserId,
                        strUserIp,
                        strOperationType,
                        strTableName,
                        strTableKey,
                        strJournal,
                        clsPubVar.CurrSelPrjId);
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "ɾ����¼�����־���ɹ�!\r\n" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            try
            {
                if (strUserIp == "127.0.0.1" || strUserIp == "59.78.151.114" || strUserIp == "59.78.151.116")
                {
                    clsFieldTabBLEx.DelFieldTabEx2(objArr2);
                }
                else
                {
                    clsCommonJsFunc.Alert(this, "ɾ�����ֶ�Ӧ�����ض���IP��ַ�������ڣ�" + strUserIp);
                    return;
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "ɾ����¼���ɹ�!\r\n" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }

            BindGv_FieldTab();

            //			Response.Write("<script>alert('��ѡ�ֶ��Ѿ�ɾ����')</script>");

        }

     
        protected void lbUpdate_Click(object sender, EventArgs e)
        {
            string strFldID = GetFirstCheckedItemFromGv(gvFieldTab);
            if (strFldID == null || strFldID.Trim().Length == 0)
            {
                lblMsgList.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
                return;
            }
            lblMsgList.Text = "";
            //1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
         
            //2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
   
            DispEditFieldTabRegion();
        }
       
      
        private void DispFieldTabListRegion()
        {
            tabQuery.Visible = true;
          
        }
        private void DispEditFieldTabRegion()
        {
            tabQuery.Visible = false;
           
        }
        /// <summary>
        /// �������ܣ��¼��������ڸ���DATAGRID�ĵ�ǰҳ����ʱ�����ĺ�����
        ///			  ���幦����������ʾ��ҳ(������ҳ����)�����ݡ�
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void gvFieldTab_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            //�������裺����2����
            //1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
            //2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ

            //1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
            this.gvFieldTab.PageIndex = e.NewPageIndex;
            //2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ
            BindGv_FieldTab();
        }
        ///ɾ����¼���̴���for C#
        protected void gvFieldTab_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            if (e.NewPageIndex != -1)
            {
                gvFieldTab.PageIndex = e.NewPageIndex;
                this.BindGv_FieldTab();
            }
        }
        ///ɾ����¼���̴���for C#
        protected void gvFieldTab_RowCreated(object sender, GridViewRowEventArgs e)
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
            if (vsSortFieldTabBy == "") return;
            if (e.Row.RowType == DataControlRowType.Header)//����ؼ��Ƿ�Ϊҳü��
            {
                string strSortEx;
                for (int i = 0; i < this.gvFieldTab.Columns.Count; i++)
                {
                    strSortEx = this.gvFieldTab.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = vsSortFieldTabBy.IndexOf(strSortEx + " ");
                    if (intIndex >= 0)  //��ͼ״̬��������ʽ�Ƿ�Ϊ���е��ֶΣ�
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//�������壬��"webdings"��5�������ǣ�6�������ǣ�
                        intIndex = vsSortFieldTabBy.IndexOf("Asc");
                        lblSort.Text = (intIndex > 0 ? " 5" : " 6");//�Ƿ�Ϊ���򣬶���Ϊstring�ͣ�
                        e.Row.Cells[i].Controls.Add(lblSort);//��������ĵ�i����Ԫ��������һ�ؼ���
                        break;
                    }
                }
            }
        }

        ///
        protected void gvFieldTab_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string strFldID;    // = gvFieldTab.Rows[e.RowIndex].Cells[1].Text.Trim();
            strFldID = gvFieldTab.DataKeys[e.RowIndex].Value.ToString();
            DeleteFieldTabRecord(strFldID);
        }
        ///
        protected void gvFieldTab_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string strFldID;    // = gvFieldTab.Rows[e.RowIndex].Cells[1].Text.Trim();
            strFldID = gvFieldTab.DataKeys[e.RowIndex].Value.ToString();
     
        }
        ///���ɰ�GridView�Ĵ���
        /// <summary>
        /// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
        ///			 ����ʾ��GridView�С�
        /// </summary>
        protected void BindGv_FieldTab()
        {
            //�������裺(��5��)
            //	1����Ͻ�����������
            //	2��������������ȡ�ñ�����������DataTable��
            //	4������GridView������Դ(DataSource)��
            //	5����GridView������DataTable��������ʾ��DATAGRID��
            //	6�����ü�¼����״̬��
            //		�ڱ��������ǰ�״̬��ʾ�ڿؼ�txtRecCount�С�

            //	1����Ͻ�����������
            string strWhereCond = CombineFieldTabCondition();
            //	2��������������ȡ�ñ�����������DataTable��
            System.Data.DataTable objDT = null;
            try
            {
                objDT = clsvFieldTabBL.GetDataTable(strWhereCond);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "��ȡ���ݱ�(DataTable)���ɹ�!" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            //	4������GRIDView������Դ(DataSource)��
            DataView objDV = objDT.DefaultView;
            objDV.Sort = vsSortFieldTabBy;     ///ע����һ�д����п�����Ҫע�͵���Ŀǰ���н����ڵ����Ĳ�ѯ������������
            //////����GridView��ÿҳ�ļ�¼��
            if (string.IsNullOrEmpty(PageSize) == false)
            {
                int intPageSize = int.Parse(PageSize);
                gvFieldTab.PageSize = intPageSize;
            }
            else
            {
                PageSize = "10";
                gvFieldTab.PageSize = 10;
            }
            this.gvFieldTab.DataSource = objDV;
            //	5����DATAGRID������DataTable��������ʾ��DATAGRID��
            this.gvFieldTab.DataBind();

            ///����ר������BindGv�е���ҳ��ش���
            GridViewRow pagerRow = gvFieldTab.BottomPagerRow;
            if (pagerRow == null) return;
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
                lblAllPages.Text = this.gvFieldTab.PageCount.ToString();
                //��ǰҳ����
                lblCurrentPage.Text = (this.gvFieldTab.PageIndex + 1).ToString();
                //��ǰ����������ҳ����
                txtJump2Page.Text = (this.gvFieldTab.PageIndex + 1).ToString();
                //�����ǰҳ����Ϊ0����<ǰһҳ>��ť��Ч
                if (this.gvFieldTab.PageIndex == 0)
                {
                    clsPubFun.SetButtonEnabled(btnPrevPage,  false);
                }
                else
                {
                    clsPubFun.SetButtonEnabled(btnPrevPage, true);
                }
                //�����ǰҳ������Ϊ���һҳ����<ǰһҳ>��ť��Ч
                if (this.gvFieldTab.PageIndex == this.gvFieldTab.PageCount - 1)
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
        }

        protected string vsSortFieldTabBy
        {
            get
            {
                string sSortFieldTabBy;
                sSortFieldTabBy = (string)ViewState["SortFieldTabBy"];
                if (sSortFieldTabBy == null)
                {
                    sSortFieldTabBy = "";
                }
                return sSortFieldTabBy;
            }
            set
            {
                string sSortFieldTabBy = value;
                ViewState.Add("SortFieldTabBy", sSortFieldTabBy);
            }
        }
        ///����GridView��������¼�����
        protected void gvFieldTab_RowCommand(object sender, GridViewCommandEventArgs e)
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
                        Set_GridViewAllChecked(gvFieldTab, true);
                        lbSelAll.Text = "��ѡ";
                    }
                    else if (lbSelAll.Text == "��ѡ")
                    {
                        Set_GridViewAllChecked(gvFieldTab, false);
                        lbSelAll.Text = "ȫѡ";
                    }
                    break;
            }
        }
        protected void Set_GridViewAllChecked(GridView objGv, bool IsSelected)
        {
            if (objGv.Rows.Count == 0)
            {
                return;
            }
            else
            {
                foreach (GridViewRow di in objGv.Rows)
                {
                    CheckBox cb = (CheckBox)di.FindControl("chkCheckRec");
                    if (cb != null)
                    {
                        cb.Checked = IsSelected;
                    }
                }
            }
        }
        protected string GetFirstCheckedItemFromGv(GridView objGv)
        {
            if (objGv.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                //foreach (GridViewRow di in objGv.Rows)
                //{
                //    CheckBox chkCheckRec = (CheckBox)di.FindControl("chkCheckRec");
                //    if (chkCheckRec != null && chkCheckRec.Checked)
                //    {
                //        return di.Cells[1].Text;

                //    }
                //}
                int intRowNum = objGv.Rows.Count;
                for (int iRow = 0; iRow < intRowNum; iRow++)
                {
                    GridViewRow di = objGv.Rows[iRow];
                    CheckBox chkCheckRec = (CheckBox)di.FindControl("chkCheckRec");
                    if (chkCheckRec != null && chkCheckRec.Checked)
                    {
                        return objGv.DataKeys[iRow].Value.ToString();
                    }
                }
            }
            return "";
        }
        protected ArrayList GetAllCheckedItemFromGv1(System.Web.UI.WebControls.GridView objGv, string strChkName)
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
                    CheckBox cb = (CheckBox)di.Cells[0].FindControl(strChkName);
                    if (cb != null && cb.Checked)
                    {
                        arr.Add(objGv.DataKeys[iRow].Value.ToString());
                    }
                }
                return arr;
            }
        }
        ///ɾ����¼���̴���for C#
        protected void DeleteFieldTabRecord(string strFldId)
        {
            if (clsFieldTabBLEx.IsCanDelUpd(strFldId) == false) return;
            try
            {
                //�ж��Ƿ���ѡ�еĶ���ID
                string strObjId = ddlTabIdq.SelectedValue;
                if (ddlTabIdq.SelectedIndex < 1)
                {
                    string strMsg = "��ѡ��һ�����ʵĶ�����!";
                    clsCommonJsFunc.Alert(this, strMsg);
                    return;
                }
                clsFieldTabBLEx.DelFieldTabBySp(strFldId, strObjId);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "ɾ����¼���ɹ�!\r\n" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_FieldTab();
        }
        ///��������ҳ����غ���
        protected void btnJumpPage_Click(object sender, EventArgs e)
        {
            GridViewRow pagerRow = gvFieldTab.BottomPagerRow;
            TextBox txtJump2Page = (TextBox)pagerRow.FindControl("txtJump2Page");
            if (txtJump2Page != null)
            {
                if (txtJump2Page.Text.Trim() != "" &&
                int.Parse(txtJump2Page.Text) > 0 &&
                int.Parse(txtJump2Page.Text) - 1 < this.gvFieldTab.PageCount)
                {
                    this.gvFieldTab.PageIndex = int.Parse(txtJump2Page.Text) - 1;
                }
                this.BindGv_FieldTab();
            }
        }
        
        protected void gvFieldTab_Sorting(object sender, GridViewSortEventArgs e)
        {
            int intIndex;
            //�ж��Ƿ����µ������ֶ�
            intIndex = vsSortFieldTabBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                vsSortFieldTabBy = e.SortExpression + " Asc";
                BindGv_FieldTab();
                return;
            }
            //���ԭ��������
            intIndex = vsSortFieldTabBy.IndexOf(" Asc");
            if (intIndex == -1)		//���ԭ���������������Ϊ����
            {
                vsSortFieldTabBy = e.SortExpression + " Asc";
            }
            else			///��������Ϊ����
            {
                vsSortFieldTabBy = e.SortExpression + " Desc";
            }
            BindGv_FieldTab();
        }
        protected void lbCheckField_Click(object sender, EventArgs e)
        {
            CheckField();
            BindGv_FieldTab();
        }
        protected void lbCopyField_Click(object sender, EventArgs e)
        {
            //�����ֶ�
            CopyField();
        }

        protected void btnExportExcel4Gv_Click(object sender, EventArgs e)
        {
            //����Excel����
            ExportExcel();
        }

        ///����ר�����ڵ���Excel����ش���
        private void ExportExcel()
        {
            //	1����Ͻ�����������
            string strWhereCond = CombineFieldTabCondition();
            //	2��������������ȡ�ñ�����������DataTable��
            System.Data.DataTable objDT = null;
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "FieldTab��Ϣ����.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add("FldId"); arrCnName.Add("�ֶ�ID");
            arrColName.Add("FldName"); arrCnName.Add("�ֶ���");
            arrColName.Add("Caption"); arrCnName.Add("����");
            arrColName.Add("DataTypeName"); arrCnName.Add("DataTypeName");
            arrColName.Add("FldLength"); arrCnName.Add("�ֶγ���");
            arrColName.Add("IsNull"); arrCnName.Add("�Ƿ�ɿ�");
            arrColName.Add("IsPrimaryKey"); arrCnName.Add("�Ƿ�����");
            arrColName.Add("IsIdentity"); arrCnName.Add("�Ƿ�Identity");
            arrColName.Add("IsOnlyOne"); arrCnName.Add("�Ƿ�Ψһ");
            arrColName.Add("TabNum"); arrCnName.Add("����");

            arrColName.Add("MaxValue"); arrCnName.Add("���ֵ");
            arrColName.Add("MinValue"); arrCnName.Add("��Сֵ");
            arrColName.Add("DefaultValue"); arrCnName.Add("ȱʡֵ");
            arrColName.Add("FldName_G"); arrCnName.Add("�ֶ���_����");
            arrColName.Add("FldName_B"); arrCnName.Add("�ֶ���_��");
            arrColName.Add("IsNationStandard"); arrCnName.Add("�Ƿ����");

            arrColName.Add("IsNeedTransCode"); arrCnName.Add("�Ƿ���Ҫת������");
            arrColName.Add("CodeTab"); arrCnName.Add("�����");
            arrColName.Add("CodeTabName"); arrCnName.Add("�����_����");
            arrColName.Add("CodeTabCode"); arrCnName.Add("�����_����");
            arrColName.Add("AppliedScope"); arrCnName.Add("Ӧ�÷�Χ");
            arrColName.Add("UserId"); arrCnName.Add("�û�ID");
            arrColName.Add("IsArchive"); arrCnName.Add("�Ƿ�浵");
            arrColName.Add("OraDbType"); arrCnName.Add("Ora��������");
            arrColName.Add("FldBName_B"); arrCnName.Add("FldBName_B");
            arrColName.Add("FldInfo"); arrCnName.Add("�ֶ���Ϣ");
            
            arrColName.Add("UpdDate"); arrCnName.Add("�޸�����");
            arrColName.Add("IsChecked"); arrCnName.Add("�Ƿ��ʵ");
            arrColName.Add("Memo"); arrCnName.Add("˵��");
            arrColName.Add("PrjId"); arrCnName.Add("����ID");
            arrColName.Add("PrjName"); arrCnName.Add("��������");
            strFolderName = clsSysParaEN.TempFileFolder;
            strDownLoadFileName = strFolderName + strFileName;
            if (clsPubVar.InitExcelFile(this, strFolderName, strDownLoadFileName) == false)
            {
                return;
            }

            try
            {
                //	2��������������ȡ�ñ�����������DataTable��
                objDT = clsvFieldTabBL.GetDataTable(strWhereCond);
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

        protected void btnSetSourceField_Click(object sender, EventArgs e)
        {
            lbSetField.Text = "����Դ�ֶ���Ϣ";
            tabQuery.Visible = true;
        }

        protected void btnSetTargetField_Click(object sender, EventArgs e)
        {
            lbSetField.Text = "����Ŀ¼�ֶ���Ϣ";
            tabQuery.Visible = true;
        }

        protected void lbSetField_Click(object sender, EventArgs e)
        {
            string strFldID = GetFirstCheckedItemFromGv(gvFieldTab);
            if (strFldID == null || strFldID.Trim().Length == 0)
            {
                lblMsgList.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
                return;
            }
            lblMsgList.Text = "";
            clsFieldTabEN objFieldTabEN = new clsFieldTabEN(strFldID);
            clsFieldTabBL.GetFieldTab(ref objFieldTabEN);
            StringBuilder sbFieldMsg = new StringBuilder();
            sbFieldMsg.AppendFormat("{0},{1}({2}),", objFieldTabEN.FldId, objFieldTabEN.FldName, objFieldTabEN.Caption);
            sbFieldMsg.AppendFormat("{0},{1}", clsDataTypeAbbrBL.GetDataTypeNameByDataTypeIdCache( objFieldTabEN.DataTypeId),
                                            objFieldTabEN.FldLength);
            if (lbSetField.Text == "����Դ�ֶ���Ϣ")
            {
                lblSourceField.Text = sbFieldMsg.ToString();
                hfSourceFieldId.Value = objFieldTabEN.FldId;
            }
            else
            {
                lblTargetField.Text = sbFieldMsg.ToString();
                hfTargetFieldId.Value = objFieldTabEN.FldId;
            }
            tabQuery.Visible = false;
        }

        protected void btnSumbitReplace_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(hfTargetFieldId.Value) == true)
            {
                clsCommonJsFunc.Alert(this, "Ŀ���ֶ�û�����ã�");
                lblTargetField.CssClass = "ErrMsg";
                return;
            }
            if (string.IsNullOrEmpty(hfSourceFieldId.Value) == true)
            {
                clsCommonJsFunc.Alert(this, "Դ�ֶ�û�����ã�");
                lblSourceField.CssClass = "ErrMsg";
                return;
            } 
            try
            {
                DataTable objDT = clsPrjTabFldBLEx.GetvPrjTab4IncludeSouTarField(hfSourceFieldId.Value, hfTargetFieldId.Value);
                if (objDT != null)
                {
                    tabPrjTab.Visible = true;
                    gvPrjTab.DataSource = objDT;
                    gvPrjTab.DataBind();
                }
                else
                {
                    //clsFldObjTabBLEx.ReplaceField(clsPubVar.CurrSelPrjId, hfSourceFieldId.Value, hfTargetFieldId.Value, clsCommonSession.UserId);
                    clsPrjTabFldBLEx.ReplaceField(clsPubVar.CurrSelPrjId, hfSourceFieldId.Value, hfTargetFieldId.Value, clsCommonSession.UserId);
                    clsSqlViewFldBLEx.ReplaceField(clsPubVar.CurrSelPrjId, hfSourceFieldId.Value, hfTargetFieldId.Value);
                    clsCommonJsFunc.Alert(this, "�滻�ֶι�����ɣ�");
                }
            }
            catch(Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
            }
        }

    }
    public partial class wfmFieldTab_ReplaceField : CommWebPageBase
    {
        private void CheckField()
        {
            string strWhereCond = CombineFieldTabCondition();
            //	2��������������ȡ�ñ�����������DataTable��
            List<clsFieldTabEN> arrFieldTabObjList = clsFieldTabBL.GetObjLst(strWhereCond);
            foreach (clsFieldTabEN objFieldTabEN in arrFieldTabObjList)
            {
                clsFieldTabBLEx.CheckFieldTab(objFieldTabEN.FldId, clsPubVar.CurrSelPrjId);
            }
        }
        /// <summary>
        /// �����ֶ�
        /// </summary>
        private void CopyField()
        {
            string strMsg;
            //�ж��Ƿ���ѡ�еĶ���ID
            string strObjId = ddlTabIdq.SelectedValue;
            if (ddlTabIdq.SelectedIndex < 1)
            {
                strMsg = "��ѡ��һ�����ʵĶ�����!";
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            ArrayList objArr = new ArrayList();
            objArr = clsCommForWebForm.Get_GvCheckedArr(this.gvFieldTab);
            try
            {
                //�����־
                string strUserId = clsCommonSession.UserId;
                //				string strUserIp = Request.UserHostAddress;
                //string strUserName = clsUsersBL.GetObjByUserId(UserId).UserName;
                foreach (string strFldId in objArr)
                {
                    clsFieldTabEN objFieldTabEN = new clsFieldTabEN(strFldId);
                    clsFieldTabBL.GetFieldTab(ref objFieldTabEN);
                    //clsFieldTabBLEx.CopyField2Bak20170705(clsPubVar.CurrSelPrjId, strFldId,
                    //    objFieldTabEN.FldName + "_Copy", strObjId, clsCommonSession.UserId);
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "�����ֶβ��ɹ�!\r\n" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }

            BindGv_FieldTab();

            //			Response.Write("<script>alert('��ѡ�ֶ��Ѿ�ɾ����')</script>");

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