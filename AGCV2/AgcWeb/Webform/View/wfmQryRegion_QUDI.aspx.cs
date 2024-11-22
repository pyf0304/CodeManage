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

namespace AGC.Webform
{
    /// <summary>
    /// wfmQryRegion_QUDI ��ժҪ˵��������Q�����ѯ��U�����޸�
    /// </summary>
    public partial class wfmQryRegion_QUDI : CommWebPageBase
    {

        /// <summary>
        /// �������Զ���ؼ���������Ķ��壬��Ҫ�˹���ӵģ�
        ///     �������ؼ���������Ķ�����ϵͳ�Զ���ӵġ�
        /// </summary>

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

                //1��Ϊ��������������Դ�����б�����
                strSortQryRegionBy = "RegionId Asc";
                //2����ʾ�������ı�������DATAGRID��
                BindDg_QryRegion();
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




        
        /// <summary>
        /// �����еĲ�ѯ�ؼ�������ϳ�һ��������
        /// </summary>
        /// <returns>������(strWhereCond)</returns>
        private string CombineQryRegionCondition()
        {
            //ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
            //���� 1=1 && UserName = '����'
            string strWhereCond = " 1=1 ";
            //����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
            if (this.txtRegionId_q.Text.Trim() != "")
            {
                strWhereCond += " And RegionId='" + this.txtRegionId_q.Text.Trim() + "'";
            }
            if (this.txtColNum_q.Text.Trim() != "")
            {
                strWhereCond += " And ColNum='" + this.txtColNum_q.Text.Trim() + "'";
            }
            if (this.chkIsUseCtrl_q.Checked == true)
                strWhereCond += " And IsUseCtrl='1'";
            else
                strWhereCond += " And IsUseCtrl='0'";
            return strWhereCond;
        }
        ///���ɰ�DATAGRID�Ĵ���
        /// <summary>
        /// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
        ///			 ����ʾ��DATAGRID�С�
        /// </summary>
        private void BindDg_QryRegion()
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
            string strWhereCond = CombineQryRegionCondition();
            //	2��������������ȡ�ñ�����������DataTable��
            System.Data.DataTable objDT = clsQueryRegionBL.GetDataTable_QueryRegion(strWhereCond);
            //	3�����DATAGRID�ĵ�ǰҳ���Ƿ񳬳�DATAGRID��ҳ����Χ
            //		3.1 ���ȼ���ҳ����
            //		3.2 �����ǰҳ����ҳ����Ϊ���һҳ
            int intPages = CalcPages(objDT.Rows.Count, this.dgQryRegion.PageSize);
            if (intPages == 0)
            {
                this.dgQryRegion.CurrentPageIndex = 0;
            }
            else if (this.dgQryRegion.CurrentPageIndex > intPages - 1)
            {
                this.dgQryRegion.CurrentPageIndex = intPages - 1;
            }
            //	4������DATAGRID������Դ(DataSource)��
            DataView objDV = objDT.DefaultView;
            objDV.Sort = strSortQryRegionBy;     ///ע����һ�д����п�����Ҫע�͵���Ŀǰ���н����ڵ����Ĳ�ѯ������������
			this.dgQryRegion.DataSource = objDV;
            //	5����DATAGRID������DataTable��������ʾ��DATAGRID��
            this.dgQryRegion.DataBind();


            //��ǰ��¼��
            this.lblQryRegionRecCount.Text = objDT.Rows.Count.ToString();
            //��ǰҳ��
            this.lblQryRegionAllPages.Text = this.dgQryRegion.PageCount.ToString();
            //��ǰҳ����
            this.lblQryRegionCurrentPage.Text = (this.dgQryRegion.CurrentPageIndex + 1).ToString();
            //��ǰ����������ҳ����
            this.txtQryRegionJump2Page.Text = (this.dgQryRegion.CurrentPageIndex + 1).ToString();
            //�����ǰҳ����Ϊ0����<ǰһҳ>��ť��Ч
            if (this.dgQryRegion.CurrentPageIndex == 0)
            {
                btnQryRegionPrevPage.Enabled = false;
            }
            else
            {
                btnQryRegionPrevPage.Enabled = true;
            }
            //�����ǰҳ������Ϊ���һҳ����<ǰһҳ>��ť��Ч
            if (this.dgQryRegion.CurrentPageIndex == this.dgQryRegion.PageCount - 1)
            {
                btnQryRegionNextPage.Enabled = false;
            }
            else
            {
                btnQryRegionNextPage.Enabled = true;
            }
            //7�������沿����ʾ����ʾ �������ǰDataGrid�еļ�¼��Ϊ0������ʾ��ǰ����ҳ������
            if (objDT.Rows.Count > 0)
            {
                this.tabQryRegionJumpPage.Visible = true;
            }
            else
            {
                this.tabQryRegionJumpPage.Visible = false;
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
            this.dgQryRegion.CurrentPageIndex = 0;
            //�ѱ��¼��������ʾ��DATAGRID��
            BindDg_QryRegion();
        }
        /// <summary>
        /// �������ܣ��¼��������ڸ���DATAGRID�ĵ�ǰҳ����ʱ�����ĺ�����
        ///			  ���幦����������ʾ��ҳ(������ҳ����)�����ݡ�
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void dgQryRegion_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            //�������裺����2����
            //1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
            //2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ

            //1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
            this.dgQryRegion.CurrentPageIndex = e.NewPageIndex;
            //2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ
            BindDg_QryRegion();
        }
        /// <summary>
        /// �������ܣ����Ըùؼ��ֵļ�¼������ʾ�ڽ����ϣ�
        ///������     �������ǰ�ֵ������ؼ���
        /// </summary>
        /// <param name="lngRegionId">���¼�Ĺؼ��֣���ʾ�ñ�ؼ��ֵ�����</param>
        private void ShowData(string lngRegionId)
        {
            //�������裺
            //1�����ؼ����Ƿ�Ϊ�գ�
            //2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
            //3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
            //4����ȡ�������������ԣ�
            //5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���

            //1�����ؼ����Ƿ�Ϊ�գ�
            if (string.IsNullOrEmpty( lngRegionId )== true) return;       //����ؼ���Ϊ�վͷ����˳�
                                                //2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
            if (clsQueryRegionBL.IsExist(lngRegionId) == false)     //���ùؼ��ֵļ�¼�Ƿ����
            {
                string ss = "�ؼ���Ϊ��" + lngRegionId + "�Ĳ�����!";
                clsCommonJsFunc.Alert(this, ss);
                return;
            }
            //3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
            clsQueryRegionEN objQryRegion = new clsQueryRegionEN(lngRegionId);
            //4����ȡ�������������ԣ�
            clsQueryRegionBL.GetQueryRegion(ref objQryRegion);
            Session.Add("objQryRegion", objQryRegion);
            //5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���
            GetDataFromQryRegionClass(objQryRegion);
        }
        ///���ɴ��߼�������ݴ��䵽�����ĺ�������
        /// <summary>
        /// �������ܣ�������������������ʾ��������
        ///ע�⣺��������������򣬲�����һ��������������ϵ�ģ�����Ϊһ��������ֵ��Ȼ����Ϊ����������ֵ
        ///      ������������ݿ�ʱ����Ӧ��һ���ֶ���ǰ�������ֶ��ں�
        /// </summary>
        /// <param name="pobjQryRegion">��ʵ�������</param>
        private void GetDataFromQryRegionClass(clsQueryRegionEN pobjQryRegion)
        {
            //wucQryRegion1.ColNum = pobjQryRegion.ColNum;
            wucQryRegion1.IsUseCtrl = pobjQryRegion.IsUseCtrl;
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
            string strResult = " "; //���ڴ����ڼ����������ʱ���ֵ�ı���
            string strCommandText;
            clsQueryRegionEN objQryRegion;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "���":
                    btnOKUpd.Text = "ȷ�����";

                    break;
                case "ȷ�����":
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
                    if (!wucQryRegion1.IsValid(ref strResult))
                    {
                        lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
                        return;
                    }
                    //2��������󲢳�ʼ������
                    //clsQueryRegionEN objQryRegion;	//�������
                    objQryRegion = new clsQueryRegionEN();  //��ʼ���¶���
                                                            //3���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
                                                            //4����ֵ�ӽ���㴫���߼��������ʵ���
                    PutDataToQryRegionClass(objQryRegion);      //�ѽ����ֵ����
                                                                //5����鴫��ȥ�Ķ��������Ƿ�Ϸ�
                    try
                    {
                        clsQueryRegionBL.CheckPropertyNew(objQryRegion);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
                    //6��������ʵ�������ݴ��������ݿ���
                    if (clsQueryRegionBL.AddNewRecordBySql2(objQryRegion) == false)
                    {
                        strMsg = "��Ӳ��ɹ�!";
                        clsCommonJsFunc.Alert(this, strMsg);
                        lblMsg.Text = "��Ӽ�¼���ɹ�!";
                    }
                    else
                    {
                        strMsg = "��Ӽ�¼�ɹ�!";
                        clsCommonJsFunc.Alert(this, strMsg);
                        lblMsg.Text = "��Ӽ�¼�ɹ�!";
                    }
                    //7��������ļ�¼������ʾ��DATAGRID��
                    BindDg_QryRegion();
                    wucQryRegion1.Clear();      //��տؼ�������
                                                ///�ָ�<ȷ�����>���<���>
                    btnOKUpd.Text = "���";
                    break;
                case "ȷ���޸�":
                    //����һ��������޸ĵĴ��룬�����߼���̫�򵥣�
                    //�Ͱ��߼���ϲ������Ʋ�,
                    //�������裺
                    //1�����ؼ����������������Ƿ���ȷ
                    //2����ֵ�ӽ���㴫���߼��������ʵ���
                    //3����鴫��ȥ�Ķ��������Ƿ�Ϸ�
                    //4��������ʵ�������ݴ��������ݿ���
                    //5�����޸ĺ��������ʾ��DATAGRID��
                    //1�����ؼ����������������Ƿ���ȷ
                    if (!wucQryRegion1.IsValid(ref strResult))
                    {
                        lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
                        return;
                    }
                    //2����ֵ�ӽ���㴫���߼��������ʵ���
                    objQryRegion = (clsQueryRegionEN)Session["objQryRegion"];
                    PutDataToQryRegionClass(objQryRegion);      //�ѽ����ֵ����
                                                                //3����鴫��ȥ�Ķ��������Ƿ�Ϸ�
                    try
                    {
                        clsQueryRegionBL.CheckPropertyNew(objQryRegion);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }                   //4��������ʵ���������޸�ͬ�������ݿ���
                    if (clsQueryRegionBL.UpdateBySql2(objQryRegion) == false)
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
                    //5�����޸ĺ��������ʾ��DATAGRID��
                    BindDg_QryRegion();
                    wucQryRegion1.Clear();//��տؼ��е�����
                                          //�ָ�<ȷ���޸�>���<���>
                    btnOKUpd.Text = "���";
                    break;
            }
        }

        /// <summary>
        /// �������ܣ��ѽ����ϵ��������ݴ����������
        /// </summary>
        /// <param name="pobjQryRegion">���ݴ����Ŀ�������</param>
        private void PutDataToQryRegionClass(clsQueryRegionEN pobjQryRegion)
        {
            //pobjQryRegion.ColNum = wucQryRegion1.ColNum;
            pobjQryRegion.IsUseCtrl = wucQryRegion1.IsUseCtrl;
        }

        protected void dgQryRegion_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
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
            if (strSortQryRegionBy == "") return;
            if (e.Item.ItemType == ListItemType.Header)//����ؼ��Ƿ�Ϊҳü��
            {
                string strSortEx;
                for (int i = 0; i < this.dgQryRegion.Columns.Count; i++)
                {
                    strSortEx = this.dgQryRegion.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = strSortQryRegionBy.IndexOf(strSortEx + " ");
                    if (intIndex >= 0)  //��ͼ״̬��������ʽ�Ƿ�Ϊ���е��ֶΣ�
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//�������壬��"webdings"��5�������ǣ�6�������ǣ�
                        intIndex = strSortQryRegionBy.IndexOf("Asc");
                        lblSort.Text = (intIndex > 0 ? " 5" : " 6");//�Ƿ�Ϊ���򣬶���Ϊstring�ͣ�
                        e.Item.Cells[i].Controls.Add(lblSort);//��������ĵ�i����Ԫ��������һ�ؼ���
                        break;
                    }
                }
            }
        }

        protected void dgQryRegion_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
        {
            string lngRegionId;
            string strCommandName;
            if (e.Item.ItemType == ListItemType.Item ||
                e.Item.ItemType == ListItemType.SelectedItem ||
                e.Item.ItemType == ListItemType.AlternatingItem ||
                e.Item.ItemType == ListItemType.EditItem)
            {
                strCommandName = ((LinkButton)e.CommandSource).CommandName;
                lngRegionId = long.Parse(e.Item.Cells[1].Text);
                switch (strCommandName)
                {
                    case "Delete":
                        clsQueryRegionBL.DelRecord(lngRegionId);
                        BindDg_QryRegion();
                        break;
                    // Add other cases here, if there are multiple ButtonColumns in 
                    // the DataGrid control.
                    case "Update":
                        //�������裺���ܹ�2����
                        //1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
                        //2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�

                        //1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
                        ShowData(lngRegionId);
                        //2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
                        clsPubFun.SetButtonEnabled(btnOKUpd, true);
                        btnOKUpd.Text = "ȷ���޸�";
                        lblMsg.Text = "";
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
                    Set_DataGridAllChecked(dgQryRegion, true);
                    lbSelAll.Text = "��ѡ";
                }
                else if (lbSelAll.Text == "��ѡ")
                {
                    Set_DataGridAllChecked(dgQryRegion, false);
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

        }


        //��ǰ��¼��
        protected void btnExportExcel4Dg_Click(object sender, System.EventArgs e)
        {
            //	1����Ͻ�����������
            string strWhereCond = CombineQryRegionCondition();
            //	2��������������ȡ�ñ�����������DataTable��
            System.Data.DataTable objDT = clsQueryRegionBL.GetDataTable_QueryRegion(strWhereCond);
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "QueryRegion��Ϣ����.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add("RegionId"); arrCnName.Add("����Id");
            arrColName.Add("ColNum"); arrCnName.Add("����");
            arrColName.Add("IsUseCtrl"); arrCnName.Add("�Ƿ�ʹ�ÿؼ�");
            strFolderName = Server.MapPath("~") + "\\TempFiles\\";
            strDownLoadFileName = strFolderName + strFileName;
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
            List<string> arrRegionId = clsCommForWebForm.GetAllCheckedItemFromDg2(dgQryRegion, "chkCheckRec");
            if (arrRegionId == null || arrRegionId.Count == 0)
            {
                lblMsg.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
                return;
            }
            lblMsg.Text = "";
            clsQueryRegionBL.DelQueryRegions(arrRegionId);
            BindDg_QryRegion();
        }


        //��ǰ��¼��
        protected void btnUpdate4Dg_Click(object sender, System.EventArgs e)
        {
            string strRegionId = clsCommForWebForm.GetFirstCheckedItemFromDg(dgQryRegion);
            string lngRegionId;
            lngRegionId = long.Parse(strRegionId);
            if (strRegionId == null || strRegionId.Trim().Length == 0)
            {
                lblMsg.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
                return;
            }
            lblMsg.Text = "";
            //1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
            ShowData(lngRegionId);
            //2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
            clsPubFun.SetButtonEnabled(btnOKUpd, true);
            btnOKUpd.Text = "ȷ���޸�";
        }

        
        protected void dgQryRegion_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
        {
            int intIndex;
            //�ж��Ƿ����µ������ֶ�
            intIndex = strSortQryRegionBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                strSortQryRegionBy = e.SortExpression + " Asc";
                BindDg_QryRegion();
                return;
            }
            //���ԭ��������
            intIndex = strSortQryRegionBy.IndexOf(" Asc");
            if (intIndex == -1)     //���ԭ���������������Ϊ����
            {
                strSortQryRegionBy = e.SortExpression + " Asc";
            }
            else			///��������Ϊ����
			{
                strSortQryRegionBy = e.SortExpression + " Desc";
            }
            BindDg_QryRegion();
        }

        private string strSortQryRegionBy
        {
            get
            {
                string sSortQryRegionBy;
                sSortQryRegionBy = (string)ViewState["SortQryRegionBy"];
                if (sSortQryRegionBy == null)
                {
                    sSortQryRegionBy = "";
                }
                return sSortQryRegionBy;
            }
            set
            {
                string sSortQryRegionBy = value;
                ViewState.Add("SortQryRegionBy", sSortQryRegionBy);
            }
        }

        //���ɸ������SESSION������Ժ���
        protected void btnQryRegionPrevPage_Click(object sender, System.EventArgs e)
        {
            this.dgQryRegion.CurrentPageIndex -= 1;
            this.BindDg_QryRegion();
        }

        protected void btnQryRegionNextPage_Click(object sender, System.EventArgs e)
        {
            this.dgQryRegion.CurrentPageIndex += 1;
            this.BindDg_QryRegion();
        }

        protected void btnQryRegionJumpPage_Click(object sender, System.EventArgs e)
        {
            if (this.txtQryRegionJump2Page.Text.Trim() != "" &&
                int.Parse(this.txtQryRegionJump2Page.Text) > 0 &&
                int.Parse(this.txtQryRegionJump2Page.Text) - 1 < this.dgQryRegion.PageCount)
            {
                this.dgQryRegion.CurrentPageIndex = int.Parse(this.txtQryRegionJump2Page.Text) - 1;
            }
            this.BindDg_QryRegion();
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