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
    /// wfmDGRegion_QUDI ��ժҪ˵��������Q�����ѯ��U�����޸�
    /// </summary>
    public partial class wfmDGRegion_QUDI : CommWebPageBase
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

                //1��Ϊ��������������Դ�����б�����
                wucDGRegion1.SetDdl_DGStyleId();
                BindDdl_DGStyleId(ddlDGStyleId_q);
                strSortDGRegionBy = "RegionId Asc";
                //2����ʾ�������ı�������DATAGRID��
                BindDg_DGRegion();
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
        private string CombineDGRegionCondition()
        {
            //ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
            //���� 1=1 && UserName = '����'
            string strWhereCond = " 1=1 ";
            //����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
            if (this.txtRegionId_q.Text.Trim() != "")
            {
                strWhereCond += " And DGRegion.RegionId='" + this.txtRegionId_q.Text.Trim() + "'";
            }
            if (this.txtViewDgName_q.Text.Trim() != "")
            {
                strWhereCond += " And DGRegion.ViewDgName like '%" + this.txtViewDgName_q.Text.Trim() + "%'";
            }
            if (this.ddlDGStyleId_q.SelectedValue != "" && this.ddlDGStyleId_q.SelectedValue != "0")
            {
                strWhereCond += " And DGRegion.DGStyleId='" + this.ddlDGStyleId_q.SelectedValue + "'";
            }
            if (this.txtRunat_q.Text.Trim() != "")
            {
                strWhereCond += " And DGRegion.Runat like '%" + this.txtRunat_q.Text.Trim() + "%'";
            }
            if (this.txtFontSize_q.Text.Trim() != "")
            {
                strWhereCond += " And DGRegion.FontSize like '%" + this.txtFontSize_q.Text.Trim() + "%'";
            }
            if (this.txtFontName_q.Text.Trim() != "")
            {
                strWhereCond += " And DGRegion.FontName like '%" + this.txtFontName_q.Text.Trim() + "%'";
            }
            if (this.chkAllowPaging_q.Checked == true)
                strWhereCond += " And DGRegion.AllowPaging='1'";
            else
                strWhereCond += " And DGRegion.AllowPaging='0'";
            if (this.txtPageSize_q.Text.Trim() != "")
            {
                strWhereCond += " And DGRegion.PageSize='" + this.txtPageSize_q.Text.Trim() + "'";
            }
            if (this.chkAutoGenerateColumns_q.Checked == true)
                strWhereCond += " And DGRegion.AutoGenerateColumns='1'";
            else
                strWhereCond += " And DGRegion.AutoGenerateColumns='0'";
            if (this.chkAllowSorting_q.Checked == true)
                strWhereCond += " And DGRegion.AllowSorting='1'";
            else
                strWhereCond += " And DGRegion.AllowSorting='0'";
            if (this.chkIsRadio_q.Checked == true)
                strWhereCond += " And DGRegion.IsRadio='1'";
            else
                strWhereCond += " And DGRegion.IsRadio='0'";
            if (this.chkIsCheck_q.Checked == true)
                strWhereCond += " And DGRegion.IsCheck='1'";
            else
                strWhereCond += " And DGRegion.IsCheck='0'";
            if (this.chkIsJumpPage_q.Checked == true)
                strWhereCond += " And DGRegion.IsJumpPage='1'";
            else
                strWhereCond += " And DGRegion.IsJumpPage='0'";
            if (this.chkIsHaveUpdBtn_q.Checked == true)
                strWhereCond += " And DGRegion.IsHaveUpdBtn='1'";
            else
                strWhereCond += " And DGRegion.IsHaveUpdBtn='0'";
            if (this.chkIsHaveDelBtn_q.Checked == true)
                strWhereCond += " And DGRegion.IsHaveDelBtn='1'";
            else
                strWhereCond += " And DGRegion.IsHaveDelBtn='0'";
            if (this.chkIsHaveDetailBtn_q.Checked == true)
                strWhereCond += " And DGRegion.IsHaveDetailBtn='1'";
            else
                strWhereCond += " And DGRegion.IsHaveDetailBtn='0'";
            if (this.chkIsInTab_q.Checked == true)
                strWhereCond += " And DGRegion.IsInTab='1'";
            else
                strWhereCond += " And DGRegion.IsInTab='0'";
            if (this.txtStyle_Zindex_q.Text.Trim() != "")
            {
                strWhereCond += " And DGRegion.Style_Zindex='" + this.txtStyle_Zindex_q.Text.Trim() + "'";
            }
            if (this.txtStyle_Left_q.Text.Trim() != "")
            {
                strWhereCond += " And DGRegion.Style_Left='" + this.txtStyle_Left_q.Text.Trim() + "'";
            }
            if (this.txtStyle_Position_q.Text.Trim() != "")
            {
                strWhereCond += " And DGRegion.Style_Position like '%" + this.txtStyle_Position_q.Text.Trim() + "%'";
            }
            if (this.txtStyle_Top_q.Text.Trim() != "")
            {
                strWhereCond += " And DGRegion.Style_Top='" + this.txtStyle_Top_q.Text.Trim() + "'";
            }
            if (this.txtWidth_q.Text.Trim() != "")
            {
                strWhereCond += " And DGRegion.Width='" + this.txtWidth_q.Text.Trim() + "'";
            }
            if (this.txtHeight_q.Text.Trim() != "")
            {
                strWhereCond += " And DGRegion.Height='" + this.txtHeight_q.Text.Trim() + "'";
            }
            if (this.txtStyle_q.Text.Trim() != "")
            {
                strWhereCond += " And DGRegion.Style like '%" + this.txtStyle_q.Text.Trim() + "%'";
            }
            if (this.txtMemo_q.Text.Trim() != "")
            {
                strWhereCond += " And DGRegion.Memo like '%" + this.txtMemo_q.Text.Trim() + "%'";
            }
            return strWhereCond;
        }
        ///���ɰ�DATAGRID�Ĵ���
        /// <summary>
        /// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
        ///			 ����ʾ��DATAGRID�С�
        /// </summary>
        private void BindDg_DGRegion()
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
            string strWhereCond = CombineDGRegionCondition();
            //	2��������������ȡ�ñ�����������DataTable��
            System.Data.DataTable objDT = clsvDGRegionBL.GetDataTable(strWhereCond);
            //	3�����DATAGRID�ĵ�ǰҳ���Ƿ񳬳�DATAGRID��ҳ����Χ
            //		3.1 ���ȼ���ҳ����
            //		3.2 �����ǰҳ����ҳ����Ϊ���һҳ
            int intPages = CalcPages(objDT.Rows.Count, this.dgDGRegion.PageSize);
            if (intPages == 0)
            {
                this.dgDGRegion.CurrentPageIndex = 0;
            }
            else if (this.dgDGRegion.CurrentPageIndex > intPages - 1)
            {
                this.dgDGRegion.CurrentPageIndex = intPages - 1;
            }
            //	4������DATAGRID������Դ(DataSource)��
            DataView objDV = objDT.DefaultView;
            objDV.Sort = strSortDGRegionBy;     ///ע����һ�д����п�����Ҫע�͵���Ŀǰ���н����ڵ����Ĳ�ѯ������������
			this.dgDGRegion.DataSource = objDV;
            //	5����DATAGRID������DataTable��������ʾ��DATAGRID��
            this.dgDGRegion.DataBind();


            //��ǰ��¼��
            this.lblDGRegionRecCount.Text = objDT.Rows.Count.ToString();
            //��ǰҳ��
            this.lblDGRegionAllPages.Text = this.dgDGRegion.PageCount.ToString();
            //��ǰҳ����
            this.lblDGRegionCurrentPage.Text = (this.dgDGRegion.CurrentPageIndex + 1).ToString();
            //��ǰ����������ҳ����
            this.txtDGRegionJump2Page.Text = (this.dgDGRegion.CurrentPageIndex + 1).ToString();
            //�����ǰҳ����Ϊ0����<ǰһҳ>��ť��Ч
            if (this.dgDGRegion.CurrentPageIndex == 0)
            {
                btnDGRegionPrevPage.Enabled = false;
            }
            else
            {
                btnDGRegionPrevPage.Enabled = true;
            }
            //�����ǰҳ������Ϊ���һҳ����<ǰһҳ>��ť��Ч
            if (this.dgDGRegion.CurrentPageIndex == this.dgDGRegion.PageCount - 1)
            {
                btnDGRegionNextPage.Enabled = false;
            }
            else
            {
                btnDGRegionNextPage.Enabled = true;
            }
            //7�������沿����ʾ����ʾ �������ǰDataGrid�еļ�¼��Ϊ0������ʾ��ǰ����ҳ������
            if (objDT.Rows.Count > 0)
            {
                this.tabDGRegionJumpPage.Visible = true;
            }
            else
            {
                this.tabDGRegionJumpPage.Visible = false;
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
            this.dgDGRegion.CurrentPageIndex = 0;
            //�ѱ��¼��������ʾ��DATAGRID��
            BindDg_DGRegion();
        }
        /// <summary>
        /// �������ܣ��¼��������ڸ���DATAGRID�ĵ�ǰҳ����ʱ�����ĺ�����
        ///			  ���幦����������ʾ��ҳ(������ҳ����)�����ݡ�
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void dgDGRegion_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            //�������裺����2����
            //1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
            //2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ

            //1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
            this.dgDGRegion.CurrentPageIndex = e.NewPageIndex;
            //2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ
            BindDg_DGRegion();
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
            if (clsDGRegionBL.IsExist(lngRegionId) == false)        //���ùؼ��ֵļ�¼�Ƿ����
            {
                string ss = "�ؼ���Ϊ��" + lngRegionId + "�Ĳ�����!";
                clsCommonJsFunc.Alert(this, ss);
                return;
            }
            //3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
            clsDGRegionEN objDGRegion = new clsDGRegionEN(lngRegionId);
            //4����ȡ�������������ԣ�
            clsDGRegionBL.GetDGRegion(ref objDGRegion);
            Session.Add("objDGRegion", objDGRegion);
            //5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���
            GetDataFromDGRegionClass(objDGRegion);
        }
        ///���ɴ��߼�������ݴ��䵽�����ĺ�������
        /// <summary>
        /// �������ܣ�������������������ʾ��������
        ///ע�⣺��������������򣬲�����һ��������������ϵ�ģ�����Ϊһ��������ֵ��Ȼ����Ϊ����������ֵ
        ///      ������������ݿ�ʱ����Ӧ��һ���ֶ���ǰ�������ֶ��ں�
        /// </summary>
        /// <param name="pobjDGRegion">��ʵ�������</param>
        private void GetDataFromDGRegionClass(clsDGRegionEN pobjDGRegion)
        {
            wucDGRegion1.ViewDgName = pobjDGRegion.ViewDgName;
            wucDGRegion1.DGStyleId = pobjDGRegion.DGStyleId;
            wucDGRegion1.Runat = pobjDGRegion.Runat;
            wucDGRegion1.FontSize = pobjDGRegion.FontSize;
            wucDGRegion1.FontName = pobjDGRegion.FontName;
            wucDGRegion1.AllowPaging = pobjDGRegion.AllowPaging;
            wucDGRegion1.PageSize = pobjDGRegion.PageSize;
            wucDGRegion1.AutoGenerateColumns = pobjDGRegion.AutoGenerateColumns;
            wucDGRegion1.AllowSorting = pobjDGRegion.AllowSorting;
            wucDGRegion1.IsRadio = pobjDGRegion.IsRadio;
            wucDGRegion1.IsCheck = pobjDGRegion.IsCheck;
            wucDGRegion1.IsJumpPage = pobjDGRegion.IsJumpPage;
            wucDGRegion1.IsHaveUpdBtn = pobjDGRegion.IsHaveUpdBtn;
            wucDGRegion1.IsHaveDelBtn = pobjDGRegion.IsHaveDelBtn;
            wucDGRegion1.IsHaveDetailBtn = pobjDGRegion.IsHaveDetailBtn;
            wucDGRegion1.IsInTab = pobjDGRegion.IsInTab;
            wucDGRegion1.Style_Zindex = pobjDGRegion.Style_Zindex;
            wucDGRegion1.Style_Left = pobjDGRegion.Style_Left;
            wucDGRegion1.Style_Position = pobjDGRegion.Style_Position;
            wucDGRegion1.Style_Top = pobjDGRegion.Style_Top;
            wucDGRegion1.Width = pobjDGRegion.Width;
            wucDGRegion1.Height = pobjDGRegion.Height;
            wucDGRegion1.Style = pobjDGRegion.Style;
            wucDGRegion1.Memo = pobjDGRegion.Memo;
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
            clsDGRegionEN objDGRegion;
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
                    if (!wucDGRegion1.IsValid(ref strResult))
                    {
                        lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
                        return;
                    }
                    //2��������󲢳�ʼ������
                    //clsDGRegionEN objDGRegion;	//�������
                    objDGRegion = new clsDGRegionEN();  //��ʼ���¶���
                                                        //3���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
                                                        //4����ֵ�ӽ���㴫���߼��������ʵ���
                    PutDataToDGRegionClass(objDGRegion);        //�ѽ����ֵ����
                                                                //5����鴫��ȥ�Ķ��������Ƿ�Ϸ�
                    try
                    {
                        clsDGRegionBL.CheckPropertyNew(objDGRegion);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
                    //6��������ʵ�������ݴ��������ݿ���
                    if (clsDGRegionBL.AddNewRecordBySql2(objDGRegion) == false)
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
                    BindDg_DGRegion();
                    wucDGRegion1.Clear();       //��տؼ�������
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
                    if (!wucDGRegion1.IsValid(ref strResult))
                    {
                        lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
                        return;
                    }
                    //2����ֵ�ӽ���㴫���߼��������ʵ���
                    objDGRegion = (clsDGRegionEN)Session["objDGRegion"];
                    PutDataToDGRegionClass(objDGRegion);        //�ѽ����ֵ����
                                                                //3����鴫��ȥ�Ķ��������Ƿ�Ϸ�
                    try
                    {
                        clsDGRegionBL.CheckPropertyNew(objDGRegion);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }

                    //4��������ʵ���������޸�ͬ�������ݿ���
                    if (clsDGRegionBL.UpdateBySql2(objDGRegion) == false)
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
                    BindDg_DGRegion();
                    wucDGRegion1.Clear();//��տؼ��е�����
                                         //�ָ�<ȷ���޸�>���<���>
                    btnOKUpd.Text = "���";
                    break;
            }
        }

        /// <summary>
        /// �������ܣ��ѽ����ϵ��������ݴ����������
        /// </summary>
        /// <param name="pobjDGRegion">���ݴ����Ŀ�������</param>
        private void PutDataToDGRegionClass(clsDGRegionEN pobjDGRegion)
        {
            pobjDGRegion.ViewDgName = wucDGRegion1.ViewDgName;
            pobjDGRegion.DGStyleId = wucDGRegion1.DGStyleId;
            pobjDGRegion.Runat = wucDGRegion1.Runat;
            pobjDGRegion.FontSize = wucDGRegion1.FontSize;
            pobjDGRegion.FontName = wucDGRegion1.FontName;
            pobjDGRegion.AllowPaging = wucDGRegion1.AllowPaging;
            pobjDGRegion.PageSize = wucDGRegion1.PageSize;
            pobjDGRegion.AutoGenerateColumns = wucDGRegion1.AutoGenerateColumns;
            pobjDGRegion.AllowSorting = wucDGRegion1.AllowSorting;
            pobjDGRegion.IsRadio = wucDGRegion1.IsRadio;
            pobjDGRegion.IsCheck = wucDGRegion1.IsCheck;
            pobjDGRegion.IsJumpPage = wucDGRegion1.IsJumpPage;
            pobjDGRegion.IsHaveUpdBtn = wucDGRegion1.IsHaveUpdBtn;
            pobjDGRegion.IsHaveDelBtn = wucDGRegion1.IsHaveDelBtn;
            pobjDGRegion.IsHaveDetailBtn = wucDGRegion1.IsHaveDetailBtn;
            pobjDGRegion.IsInTab = wucDGRegion1.IsInTab;
            pobjDGRegion.Style_Zindex = wucDGRegion1.Style_Zindex;
            pobjDGRegion.Style_Left = wucDGRegion1.Style_Left;
            pobjDGRegion.Style_Position = wucDGRegion1.Style_Position;
            pobjDGRegion.Style_Top = wucDGRegion1.Style_Top;
            pobjDGRegion.Width = wucDGRegion1.Width;
            pobjDGRegion.Height = wucDGRegion1.Height;
            pobjDGRegion.Style = wucDGRegion1.Style;
            pobjDGRegion.Memo = wucDGRegion1.Memo;
            pobjDGRegion.PrjId = clsPubVar.CurrSelPrjId;

        }

        protected void dgDGRegion_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
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
            if (strSortDGRegionBy == "") return;
            if (e.Item.ItemType == ListItemType.Header)//����ؼ��Ƿ�Ϊҳü��
            {
                string strSortEx;
                for (int i = 0; i < this.dgDGRegion.Columns.Count; i++)
                {
                    strSortEx = this.dgDGRegion.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = strSortDGRegionBy.IndexOf(strSortEx + " ");
                    if (intIndex >= 0)  //��ͼ״̬��������ʽ�Ƿ�Ϊ���е��ֶΣ�
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//�������壬��"webdings"��5�������ǣ�6�������ǣ�
                        intIndex = strSortDGRegionBy.IndexOf("Asc");
                        lblSort.Text = (intIndex > 0 ? " 5" : " 6");//�Ƿ�Ϊ���򣬶���Ϊstring�ͣ�
                        e.Item.Cells[i].Controls.Add(lblSort);//��������ĵ�i����Ԫ��������һ�ؼ���
                        break;
                    }
                }
            }
        }

        protected void dgDGRegion_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
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
                        clsDGRegionBL.DelRecord(lngRegionId);
                        BindDg_DGRegion();
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
                    Set_DataGridAllChecked(dgDGRegion, true);
                    lbSelAll.Text = "��ѡ";
                }
                else if (lbSelAll.Text == "��ѡ")
                {
                    Set_DataGridAllChecked(dgDGRegion, false);
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
            string strWhereCond = CombineDGRegionCondition();
            //	2��������������ȡ�ñ�����������DataTable��
            System.Data.DataTable objDT = clsDGRegionBL.GetDataTable_DGRegion(strWhereCond);
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "DGRegion��Ϣ����.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add("RegionId"); arrCnName.Add("����Id");
            arrColName.Add("ViewDgName"); arrCnName.Add("����Dg����");
            arrColName.Add("DGStyleId"); arrCnName.Add("DGģʽID");
            arrColName.Add("Runat"); arrCnName.Add("������");
            arrColName.Add("FontSize"); arrCnName.Add("�ֺ�");
            arrColName.Add("FontName"); arrCnName.Add("����");
            arrColName.Add("AllowPaging"); arrCnName.Add("�����ҳ");
            arrColName.Add("PageSize"); arrCnName.Add("ҳ��С");
            arrColName.Add("AutoGenerateColumns"); arrCnName.Add("�Զ�������");
            arrColName.Add("AllowSorting"); arrCnName.Add("��������");
            arrColName.Add("IsRadio"); arrCnName.Add("�Ƿ�ѡ��");
            arrColName.Add("IsCheck"); arrCnName.Add("�Ƿ�ѡ��");
            arrColName.Add("IsJumpPage"); arrCnName.Add("�Ƿ���ҳ");
            arrColName.Add("IsHaveUpdBtn"); arrCnName.Add("�Ƿ����޸İ�ť");
            arrColName.Add("IsHaveDelBtn"); arrCnName.Add("�Ƿ���ɾ����ť");
            arrColName.Add("IsHaveDetailBtn"); arrCnName.Add("�Ƿ�����ϸ��ť");
            arrColName.Add("IsInTab"); arrCnName.Add("�Ƿ�����DG�ڱ���");
            arrColName.Add("Style_Zindex"); arrCnName.Add("Style_Zindex");
            arrColName.Add("Style_Left"); arrCnName.Add("Style_Left");
            arrColName.Add("Style_Position"); arrCnName.Add("Style_Position");
            arrColName.Add("Style_Top"); arrCnName.Add("Style_Top");
            arrColName.Add("Width"); arrCnName.Add("��");
            arrColName.Add("Height"); arrCnName.Add("�߶�");
            arrColName.Add("Style"); arrCnName.Add("����");
            arrColName.Add("Memo"); arrCnName.Add("˵��");
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
            List<string> arrRegionId = clsCommForWebForm.GetAllCheckedItemFromDg2(dgDGRegion, "chkCheckRec");
            if (arrRegionId == null || arrRegionId.Count == 0)
            {
                lblMsg.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
                return;
            }
            lblMsg.Text = "";
            clsDGRegionBL.DelDGRegions(arrRegionId);
            BindDg_DGRegion();
        }


        //��ǰ��¼��
        protected void btnUpdate4Dg_Click(object sender, System.EventArgs e)
        {
            string strRegionId = clsCommForWebForm.GetFirstCheckedItemFromDg(dgDGRegion);
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

        public System.Data.DataTable GetDGStyleId()
        {
            //��ȡĳѧԺ����רҵ��Ϣ
            string strSQL = "select DGStyleId, DGStyleName from DataGridStyle ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindDdl_DGStyleId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //Ϊ����Դ�ڱ����������������
            ListItem li = new ListItem("��ѡ��...", "0");
            System.Data.DataTable objDT = GetDGStyleId();
            objDDL.DataValueField = "DGStyleId";
            objDDL.DataTextField = "DGStyleName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        
        protected void dgDGRegion_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
        {
            int intIndex;
            //�ж��Ƿ����µ������ֶ�
            intIndex = strSortDGRegionBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                strSortDGRegionBy = e.SortExpression + " Asc";
                BindDg_DGRegion();
                return;
            }
            //���ԭ��������
            intIndex = strSortDGRegionBy.IndexOf(" Asc");
            if (intIndex == -1)     //���ԭ���������������Ϊ����
            {
                strSortDGRegionBy = e.SortExpression + " Asc";
            }
            else			///��������Ϊ����
			{
                strSortDGRegionBy = e.SortExpression + " Desc";
            }
            BindDg_DGRegion();
        }

        private string strSortDGRegionBy
        {
            get
            {
                string sSortDGRegionBy;
                sSortDGRegionBy = (string)ViewState["SortDGRegionBy"];
                if (sSortDGRegionBy == null)
                {
                    sSortDGRegionBy = "";
                }
                return sSortDGRegionBy;
            }
            set
            {
                string sSortDGRegionBy = value;
                ViewState.Add("SortDGRegionBy", sSortDGRegionBy);
            }
        }

        //���ɸ������SESSION������Ժ���
        protected void btnDGRegionPrevPage_Click(object sender, System.EventArgs e)
        {
            this.dgDGRegion.CurrentPageIndex -= 1;
            this.BindDg_DGRegion();
        }

        protected void btnDGRegionNextPage_Click(object sender, System.EventArgs e)
        {
            this.dgDGRegion.CurrentPageIndex += 1;
            this.BindDg_DGRegion();
        }

        protected void btnDGRegionJumpPage_Click(object sender, System.EventArgs e)
        {
            if (this.txtDGRegionJump2Page.Text.Trim() != "" &&
                int.Parse(this.txtDGRegionJump2Page.Text) > 0 &&
                int.Parse(this.txtDGRegionJump2Page.Text) - 1 < this.dgDGRegion.PageCount)
            {
                this.dgDGRegion.CurrentPageIndex = int.Parse(this.txtDGRegionJump2Page.Text) - 1;
            }
            this.BindDg_DGRegion();
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