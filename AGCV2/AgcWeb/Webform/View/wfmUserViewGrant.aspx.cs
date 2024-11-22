///���ɲ�ѯ�޸ļ�¼�Ŀ��Ʋ����
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
using com.taishsoft.commdb;
using CommFunc4WebForm;

using AGC.BusinessLogic;using AGC.FunClass;
using AGC.BusinessLogicEx;
using AGC.Entity;

namespace AGC.Webform
{
    /// <summary>
    /// wfmUsers_Q ��ժҪ˵��������Q�����ѯ��U�����޸�
    /// </summary>
    public partial class wfmUserViewGrant : System.Web.UI.Page
    {

        protected void Page_Load(object sender, System.EventArgs e)
        {
            // �ڴ˴������û������Գ�ʼ��ҳ��
            if (!IsPostBack)	///����������ǳ��α����ã������ǵ�����ť�¼�������
			{
                //				PrjId = "0005";
                // �ڴ˴�����һЩ�û���ʼ������Ĵ��룬�������������������Դ��
                //wucStudent1.SetDdl_College();
                //1��Ϊ��������������Դ�����б�����
                clsDepartmentInfoBL.BindDdl_DepartmentId(ddlDepartmentIdq);
                BindDdl_UserStateId(ddlUserStateIdq);
                clsUserRolesBL.BindDdl_RoleId(ddlRoleIdq);
                //2����ʾ�������ı�������DATAGRID��
                //string strSortBy = " Asc";
                BindDg_Users();
                Table1.Visible = false;
                TableShow.Visible = false;

            }
        }

        /// <summary>
        /// ר�����ڴ洢��ǰ�����е�˽�б������û�ID
        /// �������Թ��̺�SESSION���洢�����е�˽�б�����
        ///		����һ�����ɣ�Ҳ�Ǳ���˾�ı�̹滮�ͷ�������ʱ���Թ��̵ĵ�һ����ĸ���á�p��
        /// </summary>
        private string pUserId
        {
            get
            {
                string strUserId;
                strUserId = (string)Session["pUserId"];
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
                Session.Add("pUserId", strUserId);
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
            if (this.txtUserIdq.Text.Trim() != "")
            {
                strWhereCond += " and Users.UserId='" + this.txtUserIdq.Text.Trim() + "'";
            }
            if (this.txtUserNameq.Text.Trim() != "")
            {
                strWhereCond += " and Users.UserName='" + this.txtUserNameq.Text.Trim() + "'";
            }
            if (this.ddlDepartmentIdq.SelectedValue != "" && this.ddlDepartmentIdq.SelectedValue != "0")
            {
                strWhereCond += " and Users.DepartmentId='" + this.ddlDepartmentIdq.SelectedValue + "'";
            }
            if (this.ddlUserStateIdq.SelectedValue != "" && this.ddlUserStateIdq.SelectedValue != "0")
            {
                strWhereCond += " and Users.UserStateId='" + this.ddlUserStateIdq.SelectedValue + "'";
            }
            if (this.txtPassWordq.Text.Trim() != "")
            {
                strWhereCond += " and Users.PassWord='" + this.txtPassWordq.Text.Trim() + "'";
            }
            if (this.txtMemoq.Text.Trim() != "")
            {
                strWhereCond += " and Users.Memo='" + this.txtMemoq.Text.Trim() + "'";
            }
            if (this.txtqxdjq.Text.Trim() != "")
            {
                strWhereCond += " and Users.qxdj='" + this.txtqxdjq.Text.Trim() + "'";
            }
            if (this.ddlRoleIdq.SelectedValue != "" && this.ddlRoleIdq.SelectedValue != "0")
            {
                strWhereCond += " and Users.RoleId='" + this.ddlRoleIdq.SelectedValue + "'";
            }
            return strWhereCond;
        }
        ///���ɰ�DATAGRID�Ĵ���
        /// <summary>
        /// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
        ///			 ����ʾ��DATAGRID�С�
        /// </summary>
        private void BindDg_Users()
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
            System.Data.DataTable objDT = clsvUsersBL.GetDataTable(strWhereCond);
            //	3�����DATAGRID�ĵ�ǰҳ���Ƿ񳬳�DATAGRID��ҳ����Χ
            //		3.1 ���ȼ���ҳ����
            //		3.2 �����ǰҳ����ҳ����Ϊ���һҳ
            int intPages = CalcPages(objDT.Rows.Count, this.dgUsers.PageSize);
            if (intPages == 0)
            {
                this.dgUsers.CurrentPageIndex = 0;
            }
            else if (this.dgUsers.CurrentPageIndex > intPages - 1)
            {
                this.dgUsers.CurrentPageIndex = intPages - 1;
            }
            //	4������DATAGRID������Դ(DataSource)��
            DataView objDV = objDT.DefaultView;
            this.dgUsers.DataSource = objDV;
            //	5����DATAGRID������DataTable��������ʾ��DATAGRID��
            this.dgUsers.DataBind();
            //	6�����ü�¼����״̬��
            this.txtRecCount.Text = objDT.Rows.Count.ToString();
        }

        ///���ɰ�DATAGRID�Ĵ���
        /// <summary>
        /// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
        ///			 ����ʾ��DATAGRID�С�
        /// </summary>
        private void BindDg_UserViewGrant()
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
            //string strWhereCond = CombineCondition();
            //	2��������������ȡ�ñ�����������DataTable��
            string UserID = pUserId;
            string strWhereCond = " UserViewGrant.UserId='" + UserID + "'";
            System.Data.DataTable objDT = clsUserViewGrantBL.GetDataTable(strWhereCond);
            //	3�����DATAGRID�ĵ�ǰҳ���Ƿ񳬳�DATAGRID��ҳ����Χ
            //		3.1 ���ȼ���ҳ����
            //		3.2 �����ǰҳ����ҳ����Ϊ���һҳ
            int intPages = CalcPages(objDT.Rows.Count, this.dgUserViewGrant.PageSize);
            if (intPages == 0)
            {
                this.dgUserViewGrant.CurrentPageIndex = 0;
            }
            else if (this.dgUserViewGrant.CurrentPageIndex > intPages - 1)
            {
                this.dgUserViewGrant.CurrentPageIndex = intPages - 1;
            }
            //	4������DATAGRID������Դ(DataSource)��
            DataView objDV = objDT.DefaultView;
            this.dgUserViewGrant.DataSource = objDV;
            //	5����DATAGRID������DataTable��������ʾ��DATAGRID��
            this.dgUserViewGrant.DataBind();
            //	6�����ü�¼����״̬��
            this.txtRecCount1.Text = objDT.Rows.Count.ToString();
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
            string strWhereCond = " ViewInfo.PrjId='" + clsPubVar.CurrSelPrjId + "'";
            strWhereCond += " and ViewInfo.ViewId not in (Select UserViewGrant.ViewId from";
            strWhereCond += " UserViewGrant where UserViewGrant.PrjId ='" + clsPubVar.CurrSelPrjId + "'";
            strWhereCond += " and UserViewGrant.UserId ='" + pUserId + "'" + ")";

            //	2��������������ȡ�ñ�����������DataTable��
            System.Data.DataTable objDT = clsViewInfoBL.GetDataTable_ViewInfo(strWhereCond);
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
            this.dgViewInfo.DataSource = objDV;
            //	5����DATAGRID������DataTable��������ʾ��DATAGRID��
            this.dgViewInfo.DataBind();
            //	6�����ü�¼����״̬��
            this.txtRecCount2.Text = objDT.Rows.Count.ToString();
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
            this.dgUsers.CurrentPageIndex = 0;
            //�ѱ��¼��������ʾ��DATAGRID��
            BindDg_Users();
        }
        /// <summary>
        /// �������ܣ��¼��������ڸ���DATAGRID�ĵ�ǰҳ����ʱ�����ĺ�����
        ///			  ���幦����������ʾ��ҳ(������ҳ����)�����ݡ�
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void dgUsers_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            //�������裺����2����
            //1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
            //2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ

            //1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
            this.dgUsers.CurrentPageIndex = e.NewPageIndex;
            //2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ
            BindDg_Users();
        }

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

        protected void dgUserViewGrant_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            //�������裺����2����
            //1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
            //2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ

            //1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
            this.dgUserViewGrant.CurrentPageIndex = e.NewPageIndex;
            //2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ
            BindDg_UserViewGrant();
        }

        public System.Data.DataTable GetUserStateId()
        {
            //��ȡĳѧԺ����רҵ��Ϣ
            string strSQL = "select UserStateId, UserStateName from UserState ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindDdl_UserStateId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //Ϊ����Դ�ڱ����������������
            ListItem li = new ListItem("��ѡ��...", "0");
            System.Data.DataTable objDT = GetUserStateId();
            objDDL.DataValueField = "UserStateId";
            objDDL.DataTextField = "UserStateName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }


        protected void dgUsers_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
        {
            //long lngMId;
            string strUserId;
            string strCommandName;

            if (e.Item.ItemType == ListItemType.Item ||
                e.Item.ItemType == ListItemType.SelectedItem ||
                e.Item.ItemType == ListItemType.AlternatingItem ||
                e.Item.ItemType == ListItemType.EditItem)
            {
                strCommandName = ((LinkButton)e.CommandSource).CommandName;
                //lngMId = long.Parse(e.Item.Cells[0].Text);
                strUserId = e.Item.Cells[0].Text;
                switch (strCommandName)
                {
                    case "Select":
                        pUserId = strUserId;
                        BindDg_UserViewGrant();
                        BindDg_ViewInfo();
                        TableShow.Visible = true;
                        Table1.Visible = false;
                        //dgUserViewGrant.Visible = true;
                        //Table2.Visible = true;

                        break;
                    //					case "Delete":
                    //						clsFldObjTabBL.DelRecord(lngMId);
                    //						BindDg_FldObjTab();
                    //						break;
                    //						// Add other cases here, if there are multiple ButtonColumns in 
                    //						// the DataGrid control.
                    //					case "Update":
                    //						//�������裺���ܹ�2����
                    //						//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
                    //						//2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
                    //
                    //						//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
                    //						ShowData(lngMId);
                    //						//2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
                    //						clsPubFun.SetButtonEnabled(btnOKUpd, true);
                    //						btnOKUpd.Text = "ȷ���޸�";
                    //						lblMsg.Text = "";
                    //						break;
                    //
                    default:
                        // Do nothing.
                        break;
                }
            }
        }

        private void Get_ObjectViewArrylist(DataGrid objDg, ArrayList objArr)
        {
            if (objArr == null || objDg.Items.Count == 0)
            {
                return;//�ж�DataGrid�ļ�¼�Ƿ�Ϊ�ջ��߶��еļ�¼Ϊ�գ�
            }
            else
            {
                objArr.Clear();//��ն���
                foreach (DataGridItem di in objDg.Items)
                {
                    CheckBox cb = (CheckBox)di.FindControl("ckb1");//����һ��CheckBox����ȼ���
                    if (cb != null && cb.Checked)                   //DataGrid�е�CheckBox
                    {
                        objArr.Add(di.Cells[1].Text);//���򹴵�CheckBox���ڼ�¼�Ĺؼ��ַ������
                        cb.Checked = false;         //��CheckBox��ԭ
                    }
                }

            }

        }

        private void Add_ObjectViewtoUserViewGrant(ArrayList objArr)
        {
            if (objArr.Count == 0)
            {
                return;
            }
            else
            {
                clsUserViewGrantEN objUserViewGrant;
                foreach (string ViewID in objArr)
                {
                    string strCondition = " UserViewGrant.UserId='" + pUserId + "'";
                    strCondition += " and UserViewGrant.ViewId='" + ViewID + "'";
                    if (!clsUserViewGrantBL.IsExistRecord(strCondition))
                    {
                        objUserViewGrant = new clsUserViewGrantEN();
                        objUserViewGrant.PrjId = clsPubVar.CurrSelPrjId;
                        objUserViewGrant.UserId = pUserId;
                        objUserViewGrant.ViewId = ViewID;
                        //objUserViewGrant.
                        //					objTabFld.TabId=this.TabId;
                        //					objTabFld.FldId=FldId;
                        //					objTabFld.IsPrimary=false;
                        //					objTabFld.PrimaryTypeId="00";
                        objUserViewGrant.mId = 0;
                        clsUserViewGrantBL.AddNewRecordBySql2(objUserViewGrant);
                        //					objTabFld.AddNewRecord();
                    }
                }
            }
            BindDg_UserViewGrant();


        }

        private void Btn_AddView_Click(object sender, System.EventArgs e)
        {
            ArrayList objArr = new ArrayList();//����һ������
            this.Get_ObjectViewArrylist(this.dgViewInfo, objArr);//����ȡ��ÿ��������뵽������
            this.Add_ObjectViewtoUserViewGrant(objArr);//�����е�ֵ��������ֵһ�𣩷������ݿ����
            BindDg_UserViewGrant();//���°�DataGrid
            BindDg_ViewInfo();
            Response.Write("<script>alert('��ѡ�ֶ���ӳɹ�����')</script>");

        }

        protected void dgUserViewGrant_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item ||
                e.Item.ItemType == ListItemType.AlternatingItem ||
                e.Item.ItemType == ListItemType.EditItem)
            {
                System.Web.UI.WebControls.LinkButton myDeleteButton;
                myDeleteButton = (System.Web.UI.WebControls.LinkButton)e.Item.FindControl("lbnDelete");
                myDeleteButton.Attributes.Add("onclick", "return confirm('�����Ҫɾ���� " + (e.Item.ItemIndex + 1).ToString() + " ����');");
            }
        }

        protected void dgUserViewGrant_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
        {
            long lngMId;
            string strCommandName;
            if (e.Item.ItemType == ListItemType.Item ||
                e.Item.ItemType == ListItemType.SelectedItem ||
                e.Item.ItemType == ListItemType.AlternatingItem ||
                e.Item.ItemType == ListItemType.EditItem)
            {
                strCommandName = ((LinkButton)e.CommandSource).CommandName;
                lngMId = long.Parse(e.Item.Cells[0].Text);
                switch (strCommandName)
                {
                    case "Delete":
                        clsUserViewGrantBL.DelRecord(lngMId);
                        BindDg_UserViewGrant();
                        BindDg_ViewInfo();
                        break;
                    // Add other cases here, if there are multiple ButtonColumns in 
                    // the DataGrid control.
                    //					case "Update":
                    //						//�������裺���ܹ�2����
                    //						//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
                    //						//2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
                    //
                    //						//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
                    //						ShowData(lngMId);
                    //						//2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
                    //						clsPubFun.SetButtonEnabled(btnOKUpd, true);
                    //						wucUserPrjGrant1.SetKeyReadOnly(true);
                    //						btnOKUpd.Text = "ȷ���޸�";
                    //						lblMsg.Text = "";
                    //						break;

                    default:
                        // Do nothing.
                        break;
                }
            }
        }

        private void Btn_Add_Click(object sender, System.EventArgs e)
        {
            BindDg_ViewInfo();
            Table1.Visible = true;
        }
    }
}