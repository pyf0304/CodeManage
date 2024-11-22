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
using com.taishsoft.commdb;
using CommFunc4WebForm;

using System.Collections.Generic;

using AGC.Entity;

using AGC.BusinessLogic;using AGC.FunClass;


using com.taishsoft.common;

namespace AGC
{
    /// <summary>
    /// wfmUserLinkRela_QUDI ��ժҪ˵��������Q�����ѯ��U�����޸�
    /// </summary>
    public partial class wfmUserLinkRela_QUDI : CommWebPageBase
    {



        //�����йصı����������
        private const string ViewId4Potence = "00260203";       //������


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
                UserId = "aaa";
                //1��Ϊ��������������Դ�����б�����
                wucUserLinkRela1.SetDdl_DataBaseTypeId();
                BindDdl_DataBaseTypeId(ddlDataBaseTypeIdq);
                strSortUserLinkRelaBy = "Memo Asc";
                //2����ʾ�������ı�������DATAGRID��
                BindDg_UserLinkRela();
                DispUserLinkRelaList();
                //3�����ñ�ؼ����ֿؼ���ReadOnly���ԣ�
                //   ʹֻ֮������Ϊ���޸Ĺ����йؼ����ǲ��ܱ��޸ĵġ�
            }
        }

        //����Ȩ�޵ȼ�������
        private string strPotenceLevel
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
        ///private clsUsersEN objUserBak
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





        //���ɴ�����Ϣ��Session����
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


        //���ɷ������Ӵ���Session����
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

        
        /// <summary>
        /// �����еĲ�ѯ�ؼ�������ϳ�һ��������
        /// </summary>
        /// <returns>������(strWhereCond)</returns>
        private string CombineUserLinkRelaCondition()
        {
            //ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
            //���� 1=1 && UserName = '����'
            string strWhereCond = " 1=1 ";
            //����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
            if (this.txtUserIdq.Text.Trim() != "")
            {
                strWhereCond += " And UserId like '%" + this.txtUserIdq.Text.Trim() + "%'";
            }
            if (this.ddlDataBaseTypeIdq.SelectedValue != "" && this.ddlDataBaseTypeIdq.SelectedValue != "0")
            {
                strWhereCond += " And DataBaseTypeId='" + this.ddlDataBaseTypeIdq.SelectedValue + "'";
            }
            if (this.txtIpAddressq.Text.Trim() != "")
            {
                strWhereCond += " And IpAddress like '%" + this.txtIpAddressq.Text.Trim() + "%'";
            }
            if (this.txtSidq.Text.Trim() != "")
            {
                strWhereCond += " And Sid like '%" + this.txtSidq.Text.Trim() + "%'";
            }
            if (this.txtLinkNameq.Text.Trim() != "")
            {
                strWhereCond += " And LinkName like '%" + this.txtLinkNameq.Text.Trim() + "%'";
            }
            return strWhereCond;
        }
        ///���ɰ�DATAGRID�Ĵ���
        /// <summary>
        /// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
        ///			 ����ʾ��DATAGRID�С�
        /// </summary>
        private void BindDg_UserLinkRela()
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
            string strWhereCond = CombineUserLinkRelaCondition();
            //	2��������������ȡ�ñ�����������DataTable��
            System.Data.DataTable objDT = clsvUserLinkRelaBL.GetDataTable(strWhereCond);
            //	3�����DATAGRID�ĵ�ǰҳ���Ƿ񳬳�DATAGRID��ҳ����Χ
            //		3.1 ���ȼ���ҳ����
            //		3.2 �����ǰҳ����ҳ����Ϊ���һҳ
            int intPages = CalcPages(objDT.Rows.Count, this.dgUserLinkRela.PageSize);
            if (intPages == 0)
            {
                this.dgUserLinkRela.CurrentPageIndex = 0;
            }
            else if (this.dgUserLinkRela.CurrentPageIndex > intPages - 1)
            {
                this.dgUserLinkRela.CurrentPageIndex = intPages - 1;
            }
            //	4������DATAGRID������Դ(DataSource)��
            DataView objDV = objDT.DefaultView;
            objDV.Sort = strSortUserLinkRelaBy;     ///ע����һ�д����п�����Ҫע�͵���Ŀǰ���н����ڵ����Ĳ�ѯ������������
			this.dgUserLinkRela.DataSource = objDV;
            //	5����DATAGRID������DataTable��������ʾ��DATAGRID��
            this.dgUserLinkRela.DataBind();


            //��ǰ��¼��
            this.lblUserLinkRelaRecCount.Text = objDT.Rows.Count.ToString();
            //��ǰҳ��
            this.lblUserLinkRelaAllPages.Text = this.dgUserLinkRela.PageCount.ToString();
            //��ǰҳ����
            this.lblUserLinkRelaCurrentPage.Text = (this.dgUserLinkRela.CurrentPageIndex + 1).ToString();
            //��ǰ����������ҳ����
            this.txtUserLinkRelaJump2Page.Text = (this.dgUserLinkRela.CurrentPageIndex + 1).ToString();
            //�����ǰҳ����Ϊ0����<ǰһҳ>��ť��Ч
            if (this.dgUserLinkRela.CurrentPageIndex == 0)
            {
                btnUserLinkRelaPrevPage.Enabled = false;
            }
            else
            {
                btnUserLinkRelaPrevPage.Enabled = true;
            }
            //�����ǰҳ������Ϊ���һҳ����<ǰһҳ>��ť��Ч
            if (this.dgUserLinkRela.CurrentPageIndex == this.dgUserLinkRela.PageCount - 1)
            {
                btnUserLinkRelaNextPage.Enabled = false;
            }
            else
            {
                btnUserLinkRelaNextPage.Enabled = true;
            }
            //7�������沿����ʾ����ʾ �������ǰDataGrid�еļ�¼��Ϊ0������ʾ��ǰ����ҳ������
            if (objDT.Rows.Count > 0)
            {
                this.tabUserLinkRelaJumpPage.Visible = true;
            }
            else
            {
                this.tabUserLinkRelaJumpPage.Visible = false;
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
            this.dgUserLinkRela.CurrentPageIndex = 0;
            //�ѱ��¼��������ʾ��DATAGRID��
            BindDg_UserLinkRela();
        }
        /// <summary>
        /// �������ܣ��¼��������ڸ���DATAGRID�ĵ�ǰҳ����ʱ�����ĺ�����
        ///			  ���幦����������ʾ��ҳ(������ҳ����)�����ݡ�
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void dgUserLinkRela_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            //�������裺����2����
            //1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
            //2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ

            //1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
            this.dgUserLinkRela.CurrentPageIndex = e.NewPageIndex;
            //2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ
            BindDg_UserLinkRela();
        }
        /// <summary>
        /// �������ܣ����Ըùؼ��ֵļ�¼������ʾ�ڽ����ϣ�
        ///������     �������ǰ�ֵ������ؼ���
        /// </summary>
        /// <param name="lngmID">���¼�Ĺؼ��֣���ʾ�ñ�ؼ��ֵ�����</param>
        private void ShowData(long lngmID)
        {
            //�������裺
            //1�����ؼ����Ƿ�Ϊ�գ�
            //2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
            //3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
            //4����ȡ�������������ԣ�
            //5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���

            //1�����ؼ����Ƿ�Ϊ�գ�
            if (lngmID == 0) return;        //����ؼ���Ϊ�վͷ����˳�
                                            //2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
            if (clsUserLinkRelaBL.IsExist(lngmID) == false)     //���ùؼ��ֵļ�¼�Ƿ����
            {
                string ss = "�ؼ���Ϊ��" + lngmID + "�Ĳ�����!";
                clsCommonJsFunc.Alert(this, ss);
                return;
            }
            //3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
            clsUserLinkRelaEN objUserLinkRela = new clsUserLinkRelaEN(lngmID);
            //4����ȡ�������������ԣ�
            clsUserLinkRelaBL.GetUserLinkRela(ref objUserLinkRela);
            Session.Add("objUserLinkRela", objUserLinkRela);
            //5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���
            GetDataFromUserLinkRelaClass(objUserLinkRela);
        }
        ///���ɴ��߼�������ݴ��䵽�����ĺ�������
        /// <summary>
        /// �������ܣ�������������������ʾ��������
        ///ע�⣺��������������򣬲�����һ��������������ϵ�ģ�����Ϊһ��������ֵ��Ȼ����Ϊ����������ֵ
        ///      ������������ݿ�ʱ����Ӧ��һ���ֶ���ǰ�������ֶ��ں�
        /// </summary>
        /// <param name="pobjUserLinkRela">��ʵ�������</param>
        private void GetDataFromUserLinkRelaClass(clsUserLinkRelaEN pobjUserLinkRela)
        {
            wucUserLinkRela1.DataBaseTypeId = pobjUserLinkRela.DataBaseTypeId;
            wucUserLinkRela1.Memo = pobjUserLinkRela.Memo;
            wucUserLinkRela1.IpAddress = pobjUserLinkRela.IpAddress;
            wucUserLinkRela1.DataBasePwd = pobjUserLinkRela.DataBasePwd;
            wucUserLinkRela1.DataBaseUserId = pobjUserLinkRela.DataBaseUserId;
            wucUserLinkRela1.DataBaseName = pobjUserLinkRela.DataBaseName;
            wucUserLinkRela1.Sid = pobjUserLinkRela.Sid;
            wucUserLinkRela1.ConnectionString = pobjUserLinkRela.ConnectionString;
            wucUserLinkRela1.LinkName = pobjUserLinkRela.LinkName;
        }
        /// <summary>
        /// �������ܣ��¼�������������<ȷ���޸�>ʱ�������¼�������
        ///           ���幦��Ϊ�ѽ�������ͬ�����ݿ��У��ѽ������ݱ��浽���ݿ���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOKUpd_Click(object sender, System.EventArgs e)
        {

            string strCommandText;
            clsUserLinkRelaEN objUserLinkRela;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "���":
                    AddUserLinkRelaRecord();
                    break;
                case "ȷ�����":
                    //����һ������Ĳ���Ĵ��룬�����߼���̫�򵥣�
                    //�Ͱ��߼���ϲ������Ʋ�,
                    AddUserLinkRelaRecordSave();
                    break;
                case "ȷ���޸�":
                    //����һ��������޸ĵĴ��룬�����߼���̫�򵥣�
                    //�Ͱ��߼���ϲ������Ʋ�,
                    objUserLinkRela = (clsUserLinkRelaEN)Session["objUserLinkRela"];
                    UpdateUserLinkRelaRecordSave(objUserLinkRela);
                    break;
            }
        }

        /// <summary>
        /// �������ܣ��ѽ����ϵ��������ݴ����������
        /// </summary>
        /// <param name="pobjUserLinkRela">���ݴ����Ŀ�������</param>
        private void PutDataToUserLinkRelaClass(clsUserLinkRelaEN pobjUserLinkRela)
        {
            pobjUserLinkRela.DataBaseTypeId = wucUserLinkRela1.DataBaseTypeId;
            pobjUserLinkRela.Memo = wucUserLinkRela1.Memo;
            pobjUserLinkRela.IpAddress = wucUserLinkRela1.IpAddress;
            pobjUserLinkRela.DataBasePwd = wucUserLinkRela1.DataBasePwd;
            pobjUserLinkRela.DataBaseUserId = wucUserLinkRela1.DataBaseUserId;
            pobjUserLinkRela.DataBaseName = wucUserLinkRela1.DataBaseName;
            pobjUserLinkRela.Sid = wucUserLinkRela1.Sid;
            pobjUserLinkRela.ConnectionString = wucUserLinkRela1.ConnectionString;
            pobjUserLinkRela.LinkName = wucUserLinkRela1.LinkName;
            pobjUserLinkRela.UserId = UserId;
        }

        protected void dgUserLinkRela_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item ||
                e.Item.ItemType == ListItemType.AlternatingItem ||
                e.Item.ItemType == ListItemType.EditItem)
            {
                System.Web.UI.WebControls.LinkButton myDeleteButton;
                myDeleteButton = (System.Web.UI.WebControls.LinkButton)e.Item.FindControl("lbnDelete");
                myDeleteButton.Attributes.Add("onclick", "return confirm('�����Ҫɾ���� " + (e.Item.ItemIndex + 1).ToString() + " ����');");
            }
            int intIndex;
            if (strSortUserLinkRelaBy == "") return;
            if (e.Item.ItemType == ListItemType.Header)//����ؼ��Ƿ�Ϊҳü��
            {
                string strSortEx;
                for (int i = 0; i < this.dgUserLinkRela.Columns.Count; i++)
                {
                    strSortEx = this.dgUserLinkRela.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = strSortUserLinkRelaBy.IndexOf(strSortEx + " ");
                    if (intIndex >= 0)  //��ͼ״̬��������ʽ�Ƿ�Ϊ���е��ֶΣ�
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//�������壬��"webdings"��5�������ǣ�6�������ǣ�
                        intIndex = strSortUserLinkRelaBy.IndexOf("Asc");
                        lblSort.Text = (intIndex > 0 ? " 5" : " 6");//�Ƿ�Ϊ���򣬶���Ϊstring�ͣ�
                        e.Item.Cells[i].Controls.Add(lblSort);//��������ĵ�i����Ԫ��������һ�ؼ���
                        break;
                    }
                }
            }
        }

        protected void dgUserLinkRela_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
        {
            long lngmID;
            string strCommandName;
            if (e.Item.ItemType == ListItemType.Item ||
                e.Item.ItemType == ListItemType.SelectedItem ||
                e.Item.ItemType == ListItemType.AlternatingItem ||
                e.Item.ItemType == ListItemType.EditItem)
            {
                strCommandName = ((LinkButton)e.CommandSource).CommandName;
                lngmID = long.Parse(e.Item.Cells[1].Text);
                switch (strCommandName)
                {
                    case "Delete":
                        DeleteUserLinkRelaRecord(lngmID);
                        break;
                    // Add other cases here, if there are multiple ButtonColumns in 
                    // the DataGrid control.
                    case "Update":
                        UpdateUserLinkRelaRecord(lngmID);
                        break;

                    default:
                        // Do nothing.
                        break;
                }
            }
            if (e.Item.ItemType == ListItemType.Header)
            {
                System.Web.UI.WebControls.LinkButton lbSelAll;
                lbSelAll = (LinkButton)e.CommandSource;
                if (lbSelAll.CommandName != "lbSelAll")
                {
                    return;
                }
                if (lbSelAll.Text == "ȫѡ")
                {
                    Set_DataGridAllChecked(dgUserLinkRela, true);
                    lbSelAll.Text = "��ѡ";
                }
                else if (lbSelAll.Text == "��ѡ")
                {
                    Set_DataGridAllChecked(dgUserLinkRela, false);
                    lbSelAll.Text = "ȫѡ";
                }
            }
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


        //��ǰ��¼��
        protected void btnAddNewRec4Dg_Click(object sender, System.EventArgs e)
        {
            btnOKUpd.Text = "ȷ�����";
            HideUserLinkRelaList();

        }


        //��ǰ��¼��
        protected void btnExportExcel4Dg_Click(object sender, System.EventArgs e)
        {
            //	1����Ͻ�����������
            string strWhereCond = CombineUserLinkRelaCondition();
            //	2��������������ȡ�ñ�����������DataTable��
            System.Data.DataTable objDT = clsvUserLinkRelaBL.GetDataTable(strWhereCond);
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "UserLinkRela��Ϣ����.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add("Memo"); arrCnName.Add("˵��");
            arrColName.Add("UserId"); arrCnName.Add("�û�ID");
            arrColName.Add("IpAddress"); arrCnName.Add("������");
            arrColName.Add("DataBasePwd"); arrCnName.Add("���ݿ���û�����");
            arrColName.Add("DataBaseUserId"); arrCnName.Add("���ݿ���û�ID");
            arrColName.Add("DataBaseName"); arrCnName.Add("���ݿ���");
            arrColName.Add("Sid"); arrCnName.Add("Sid");
            arrColName.Add("ConnectionString"); arrCnName.Add("���Ӵ�");
            arrColName.Add("DataBaseTypeName"); arrCnName.Add("���ݿ�������");
            arrColName.Add("LinkName"); arrCnName.Add("��������");
            strFolderName = Server.MapPath("~") + "\\TempFiles\\";
            strDownLoadFileName = strFolderName + strFileName;
            if (clsPubVar.InitExcelFile(this, strFolderName, strDownLoadFileName) == false)
            {
                return;
            }

            GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4Odbc(objDT, arrColName, arrCnName, strDownLoadFileName);
            DownLoadFile(strDownLoadFileName);
        }
        /// <summary>
        /// ���ܣ������ļ����ӷ����������ļ����ͻ��������
        /// </summary>
        /// <param name="strDownLoadFileName">��Ҫ���ص��ļ��������ļ���Ϊ��Ŀ¼���ļ�ȫ��</param>
        /// <returns></returns>
        private bool DownLoadFile(string strDownLoadFileName)
        {
            System.IO.FileInfo file = new System.IO.FileInfo(strDownLoadFileName);
            Response.Clear();
            Response.AddHeader("Content-Disposition", "attachment; filename=" + HttpUtility.UrlEncode(file.Name));
            Response.AddHeader("Content-Length", file.Length.ToString());
            Response.ContentType = "application/octet-stream";
            Response.WriteFile(file.FullName);
            Response.End();
            return true;
        }


        //��ǰ��¼��
        protected void btnDelete4Dg_Click(object sender, System.EventArgs e)
        {
            List<string> arrmID = clsCommForWebForm.GetAllCheckedItemFromDg2(dgUserLinkRela, "chkCheckRec");
            if (arrmID == null || arrmID.Count == 0)
            {
                lblMsg.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
                return;
            }
            lblMsg.Text = "";

            clsUserLinkRelaBL.DelUserLinkRelas(arrmID);
            BindDg_UserLinkRela();
        }


        //��ǰ��¼��
        protected void btnUpdate4Dg_Click(object sender, System.EventArgs e)
        {
            string strmID = clsCommForWebForm.GetFirstCheckedItemFromDg(dgUserLinkRela);
            if (strmID == null || strmID.Trim().Length == 0)
            {
                lblMsg.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
                return;
            }
            lblMsg.Text = "";
            //1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
            long lngmID;
            lngmID = long.Parse(strmID);
            ShowData(lngmID);
            //2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
            clsPubFun.SetButtonEnabled(btnOKUpd, true);
            btnOKUpd.Text = "ȷ���޸�";
            HideUserLinkRelaList();
        }

        public System.Data.DataTable GetDataBaseTypeId()
        {
            //��ȡĳѧԺ����רҵ��Ϣ
            string strSQL = "select DataBaseTypeId, DataBaseTypeName from DataBaseType ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindDdl_DataBaseTypeId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //Ϊ����Դ�ڱ����������������
            ListItem li = new ListItem("��ѡ��...", "0");
            System.Data.DataTable objDT = GetDataBaseTypeId();
            objDDL.DataValueField = "DataBaseTypeId";
            objDDL.DataTextField = "DataBaseTypeName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        
        protected void dgUserLinkRela_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
        {
            int intIndex;
            //�ж��Ƿ����µ������ֶ�
            intIndex = strSortUserLinkRelaBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                strSortUserLinkRelaBy = e.SortExpression + " Asc";
                BindDg_UserLinkRela();
                return;
            }
            //���ԭ��������
            intIndex = strSortUserLinkRelaBy.IndexOf(" Asc");
            if (intIndex == -1)     //���ԭ���������������Ϊ����
            {
                strSortUserLinkRelaBy = e.SortExpression + " Asc";
            }
            else			///��������Ϊ����
			{
                strSortUserLinkRelaBy = e.SortExpression + " Desc";
            }
            BindDg_UserLinkRela();
        }

        private string strSortUserLinkRelaBy
        {
            get
            {
                string sSortUserLinkRelaBy;
                sSortUserLinkRelaBy = (string)ViewState["SortUserLinkRelaBy"];
                if (sSortUserLinkRelaBy == null)
                {
                    sSortUserLinkRelaBy = "";
                }
                return sSortUserLinkRelaBy;
            }
            set
            {
                string sSortUserLinkRelaBy = value;
                ViewState.Add("SortUserLinkRelaBy", sSortUserLinkRelaBy);
            }
        }

        //���ɸ������SESSION������Ժ���
        protected void btnUserLinkRelaPrevPage_Click(object sender, System.EventArgs e)
        {
            this.dgUserLinkRela.CurrentPageIndex -= 1;
            this.BindDg_UserLinkRela();
        }

        protected void btnUserLinkRelaNextPage_Click(object sender, System.EventArgs e)
        {
            this.dgUserLinkRela.CurrentPageIndex += 1;
            this.BindDg_UserLinkRela();
        }

        protected void btnUserLinkRelaJumpPage_Click(object sender, System.EventArgs e)
        {
            if (this.txtUserLinkRelaJump2Page.Text.Trim() != "" &&
                int.Parse(this.txtUserLinkRelaJump2Page.Text) > 0 &&
                int.Parse(this.txtUserLinkRelaJump2Page.Text) - 1 < this.dgUserLinkRela.PageCount)
            {
                this.dgUserLinkRela.CurrentPageIndex = int.Parse(this.txtUserLinkRelaJump2Page.Text) - 1;
            }
            this.BindDg_UserLinkRela();
        }

        ///���ɵĲ����¼׼�����̴���for C#
        private void AddUserLinkRelaRecord()
        {
            btnOKUpd.Text = "ȷ�����";

        }
        ///�����¼���̹��̴���for C#
        private void AddUserLinkRelaRecordSave()
        {
            //�������裺
            //1�����ؼ����������������Ƿ���ȷ
            //2��������󲢳�ʼ������
            //3���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
            //4����ֵ�ӽ���㴫���߼��������ʵ���
            //5����鴫��ȥ�Ķ��������Ƿ�Ϸ�
            //6��������ʵ�������ݴ��������ݿ���
            //7��������ļ�¼������ʾ��DATAGRID��
            string strMsg;  //ר�����ڴ�����Ϣ�ı���
            string strResult = " "; //���ڴ����ڼ����������ʱ���ֵ�ı���
            clsUserLinkRelaEN objUserLinkRela;
            //1�����ؼ����������������Ƿ���ȷ
            if (!wucUserLinkRela1.IsValid(ref strResult))
            {
                lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
                return;
            }
            //2��������󲢳�ʼ������
            //clsUserLinkRelaEN objUserLinkRela;	//�������
            objUserLinkRela = new clsUserLinkRelaEN();  //��ʼ���¶���
                                                        //3���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
                                                        //4����ֵ�ӽ���㴫���߼��������ʵ���
            PutDataToUserLinkRelaClass(objUserLinkRela);        //�ѽ����ֵ����
                                                                //5����鴫��ȥ�Ķ��������Ƿ�Ϸ�
            try
            {
                clsUserLinkRelaBL.CheckPropertyNew(objUserLinkRela);
                //6��������ʵ�������ݴ��������ݿ���
                clsUserLinkRelaBL.AddNewRecordBySql2(objUserLinkRela);
            }
            catch (Exception objException)
            {
                strMsg = "��Ӽ�¼���ɹ�!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsg.Text = strMsg;
                return;
            }
            strMsg = "��Ӽ�¼�ɹ�!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsg.Text = "��Ӽ�¼�ɹ�!";
            //7��������ļ�¼������ʾ��DATAGRID��
            BindDg_UserLinkRela();
            wucUserLinkRela1.Clear();       //��տؼ�������
                                            ///�ָ�<ȷ�����>���<���>
            btnOKUpd.Text = "���";
            DispUserLinkRelaList();
        }
        ///�����¼���̹��̴���for C#
        private void AddUserLinkRelaRecordSaveV5()
        {
            //�������裺
            //1�����ؼ����������������Ƿ���ȷ
            //2��������󲢳�ʼ������
            //3���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
            //4����ֵ�ӽ���㴫���߼��������ʵ���
            //5����鴫��ȥ�Ķ��������Ƿ�Ϸ�
            //6��������ʵ�������ݴ��������ݿ���
            //7��������ļ�¼������ʾ��DATAGRID��
            string strMsg;  //ר�����ڴ�����Ϣ�ı���
            string strResult = " "; //���ڴ����ڼ����������ʱ���ֵ�ı���
            clsUserLinkRelaEN objUserLinkRela;
            //1�����ؼ����������������Ƿ���ȷ
            if (!wucUserLinkRela1.IsValid(ref strResult))
            {
                lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
                return;
            }
            //2��������󲢳�ʼ������
            //clsUserLinkRelaEN objUserLinkRela;	//�������
            objUserLinkRela = new clsUserLinkRelaEN();  //��ʼ���¶���
                                                        //3���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
                                                        //4����ֵ�ӽ���㴫���߼��������ʵ���
            PutDataToUserLinkRelaClass(objUserLinkRela);        //�ѽ����ֵ����
                                                                //5����鴫��ȥ�Ķ��������Ƿ�Ϸ�
            try
            {
                clsUserLinkRelaBL.CheckPropertyNew(objUserLinkRela);
                //6��������ʵ�������ݴ��������ݿ���
                clsUserLinkRelaBL.AddNewRecordBySql2(objUserLinkRela);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "��Ӽ�¼���ɹ�!" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            strMsg = "��Ӽ�¼�ɹ�!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsg.Text = "��Ӽ�¼�ɹ�!";
            //7��������ļ�¼������ʾ��DATAGRID��
            BindDg_UserLinkRela();
            wucUserLinkRela1.Clear();       //��տؼ�������
                                            ///�ָ�<ȷ�����>���<���>
            btnOKUpd.Text = "���";
        }
        ///�����޸ļ�¼׼�����̴��� for C#
        private void UpdateUserLinkRelaRecord(long lngmID)
        {
            //�������裺���ܹ�2����
            //1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
            //2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�

            //1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
            ShowData(lngmID);
            //2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
            clsPubFun.SetButtonEnabled(btnOKUpd, true);
            btnOKUpd.Text = "ȷ���޸�";
            lblMsg.Text = "";
        }
        ///�޸Ĵ���׼�����̴��� for C#
        private void UpdateUserLinkRelaRecordSave(clsUserLinkRelaEN objUserLinkRela)
        {
            //�������裺
            //1�����ؼ����������������Ƿ���ȷ
            //2����ֵ�ӽ���㴫���߼��������ʵ���
            //3����鴫��ȥ�Ķ��������Ƿ�Ϸ�
            //4��������ʵ�������ݴ��������ݿ���
            //5�����޸ĺ��������ʾ��DATAGRID��
            string strMsg;  //ר�����ڴ�����Ϣ�ı���
            string strResult = " "; //���ڴ����ڼ����������ʱ���ֵ�ı���
                                    //1�����ؼ����������������Ƿ���ȷ
            if (!wucUserLinkRela1.IsValid(ref strResult))
            {
                lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
                return;
            }
            //2����ֵ�ӽ���㴫���߼��������ʵ���
            PutDataToUserLinkRelaClass(objUserLinkRela);        //�ѽ����ֵ����
                                                                //3����鴫��ȥ�Ķ��������Ƿ�Ϸ�
            try
            {
                clsUserLinkRelaBL.CheckPropertyNew(objUserLinkRela);
                //6��������ʵ�������ݴ��������ݿ���
                clsUserLinkRelaBL.Update(objUserLinkRela);
            }
            catch (Exception objException)
            {
                strMsg = "�޸ļ�¼���ɹ�!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsg.Text = strMsg;
                return;
            }
            strMsg = "�޸ļ�¼�ɹ�!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsg.Text = "�޸ļ�¼�ɹ�!";
            //5�����޸ĺ��������ʾ��DATAGRID��
            BindDg_UserLinkRela();
            wucUserLinkRela1.Clear();//��տؼ��е�����
                                     //�ָ�<ȷ���޸�>���<���>
            btnOKUpd.Text = "���";
        }
        ///�޸Ĵ���׼�����̴��� for C#
        private void UpdateUserLinkRelaRecordSaveV5(clsUserLinkRelaEN objUserLinkRela)
        {
            //�������裺
            //1�����ؼ����������������Ƿ���ȷ
            //2����ֵ�ӽ���㴫���߼��������ʵ���
            //3����鴫��ȥ�Ķ��������Ƿ�Ϸ�
            //4��������ʵ�������ݴ��������ݿ���
            //5�����޸ĺ��������ʾ��DATAGRID��
            string strMsg;  //ר�����ڴ�����Ϣ�ı���
            string strResult = " "; //���ڴ����ڼ����������ʱ���ֵ�ı���
                                    //1�����ؼ����������������Ƿ���ȷ
            if (!wucUserLinkRela1.IsValid(ref strResult))
            {
                lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
                return;
            }
            //2����ֵ�ӽ���㴫���߼��������ʵ���
            PutDataToUserLinkRelaClass(objUserLinkRela);        //�ѽ����ֵ����
                                                                //3����鴫��ȥ�Ķ��������Ƿ�Ϸ�
            try
            {
                clsUserLinkRelaBL.CheckPropertyNew(objUserLinkRela);
                //6��������ʵ�������ݴ��������ݿ���
                clsUserLinkRelaBL.UpdateBySql2(objUserLinkRela);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "�޸ļ�¼���ɹ�!" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            strMsg = "�޸ļ�¼�ɹ�!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsg.Text = "�޸ļ�¼�ɹ�!";
            //5�����޸ĺ��������ʾ��DATAGRID��
            BindDg_UserLinkRela();
            wucUserLinkRela1.Clear();//��տؼ��е�����
                                     //�ָ�<ȷ���޸�>���<���>
            btnOKUpd.Text = "���";
        }
        ///ɾ����¼���̴���for C#
        private void DeleteUserLinkRelaRecord(long lngmID)
        {
            clsUserLinkRelaBL.DelRecord(lngmID);
            BindDg_UserLinkRela();
        }
        private void DispUserLinkRelaList()
        {
            tabUserLinkRelaDataGrid.Visible = true;
            tabUserLinkRelaJumpPage.Visible = true;
            tabUserLinkRelaTable.Visible = true;
            tabEditUserLinkRela.Visible = false;
        }

        private void HideUserLinkRelaList()
        {
            tabUserLinkRelaDataGrid.Visible = false;
            tabUserLinkRelaTable.Visible = false;
            tabUserLinkRelaJumpPage.Visible = false;
            tabEditUserLinkRela.Visible = true;
        }

        protected void lbDispObjList_Click(object sender, System.EventArgs e)
        {
            DispUserLinkRelaList();
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