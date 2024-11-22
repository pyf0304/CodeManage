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
using com.taishsoft.common;


using System.Collections.Generic;

using AGC.Entity;

using AGC.BusinessLogic;using AGC.FunClass;

using AGC.BusinessLogicEx;

using com.taishsoft.datetime;
using System.Text;
using AutoGCLib;


namespace AGC.Webform
{
    /// <summary>
    /// wfmDGRegionFlds_QUDI ��ժҪ˵��������Q�����ѯ��U�����޸�
    /// </summary>
    public partial class wfmDGRegionFlds_QUDI : CommWebPageBase
    {        

        //�����йصı����������
        private const string ViewId4Potence = "00260203";		//������


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
                lblRegionName.Text = clsViewRegionBL.GetObjByRegionIdCache(RegionId, clsPubVar.CurrSelPrjId).RegionName;
                //1��Ϊ��������������Դ�����б�����
                wucDGRegionFlds1.SetDdl_CtlTypeId(false);
                wucDGRegionFlds1.SetDdl_DgFuncTypeId();
                strSortDGRegionFldsBy = "ColIndex Asc";
                //2����ʾ�������ı�������DATAGRID��
                BindDg_DGRegionFlds();
                
                tabTabFldList.Visible = false;
                tabEditDGRegionFldsRegion.Visible = false;
                //3�����ñ�ؼ����ֿؼ���ReadOnly���ԣ�
                //   ʹֻ֮������Ϊ���޸Ĺ����йؼ����ǲ��ܱ��޸ĵġ�
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
        private string BackViewRegionLinkStr
        {
            get
            {
                string strBackViewRegionLinkStr;
                strBackViewRegionLinkStr = (string)Session["BackViewRegionLinkStr"];
                if (strBackViewRegionLinkStr == null)
                {
                    strBackViewRegionLinkStr = "";
                }
                return strBackViewRegionLinkStr;
            }
            set
            {
                string strBackViewRegionLinkStr = value;
                Session.Add("BackViewRegionLinkStr", strBackViewRegionLinkStr);
            }
        }
        private string RegionId
        {
            get
            {
                string lngRegionId;
                if (Session["RegionId"] == null)
                {
                    lngRegionId = "";
                }
                else
                {
                    string strRegionId = Session["RegionId"].ToString();
                    lngRegionId = strRegionId;
                }
                return lngRegionId;
            }
            set
            {
                string lngRegionId = value;
                Session.Add("RegionId", lngRegionId);
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

        

        
        /// <summary>
        /// �����еĲ�ѯ�ؼ�������ϳ�һ��������
        /// </summary>
        /// <returns>������(strWhereCond)</returns>
        private string CombineDGRegionFldsCondition()
        {
            //ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
            //���� 1=1 && UserName = '����'
            string strWhereCond = " 1=1 ";
            //����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
            strWhereCond += " And RegionId='" + RegionId + "'";
            return strWhereCond;
        }
        ///���ɰ�DATAGRID�Ĵ���
        /// <summary>
        /// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
        ///			 ����ʾ��DATAGRID�С�
        /// </summary>
        private void BindDg_DGRegionFlds()
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
            string strWhereCond = CombineDGRegionFldsCondition();
            //	2��������������ȡ�ñ�����������DataTable��
            System.Data.DataTable objDT = clsvDGRegionFldsBL.GetDataTable(strWhereCond + " order by ColIndex");
            //	3�����DATAGRID�ĵ�ǰҳ���Ƿ񳬳�DATAGRID��ҳ����Χ
            //		3.1 ���ȼ���ҳ����
            //		3.2 �����ǰҳ����ҳ����Ϊ���һҳ
            int intPages = CalcPages(objDT.Rows.Count, this.dgDGRegionFlds.PageSize);
            if (intPages == 0)
            {
                this.dgDGRegionFlds.CurrentPageIndex = 0;
            }
            else if (this.dgDGRegionFlds.CurrentPageIndex > intPages - 1)
            {
                this.dgDGRegionFlds.CurrentPageIndex = intPages - 1;
            }
            //	4������DATAGRID������Դ(DataSource)��
            DataView objDV = objDT.DefaultView;
            objDV.Sort = strSortDGRegionFldsBy;     ///ע����һ�д����п�����Ҫע�͵���Ŀǰ���н����ڵ����Ĳ�ѯ������������
            this.dgDGRegionFlds.DataSource = objDV;
            //	5����DATAGRID������DataTable��������ʾ��DATAGRID��
            this.dgDGRegionFlds.DataBind();

            
            //��ǰ��¼��
            this.lblDGRegionFldsRecCount.Text = objDT.Rows.Count.ToString();
            //��ǰҳ��
            this.lblDGRegionFldsAllPages.Text = this.dgDGRegionFlds.PageCount.ToString();
            //��ǰҳ����
            this.lblDGRegionFldsCurrentPage.Text = (this.dgDGRegionFlds.CurrentPageIndex + 1).ToString();
            //��ǰ����������ҳ����
            this.txtDGRegionFldsJump2Page.Text = (this.dgDGRegionFlds.CurrentPageIndex + 1).ToString();
            //�����ǰҳ����Ϊ0����<ǰһҳ>��ť��Ч
            if (this.dgDGRegionFlds.CurrentPageIndex == 0)
            {
                clsPubFun.SetButtonEnabled(btnDGRegionFldsPrevPage, false);
            }
            else
            {
                clsPubFun.SetButtonEnabled(btnDGRegionFldsPrevPage, true);
            }
            //�����ǰҳ������Ϊ���һҳ����<ǰһҳ>��ť��Ч
            if (this.dgDGRegionFlds.CurrentPageIndex == this.dgDGRegionFlds.PageCount - 1)
            {
                clsPubFun.SetButtonEnabled(btnDGRegionFldsNextPage, false);
            }
            else
            {
                clsPubFun.SetButtonEnabled(btnDGRegionFldsNextPage, true);
            }
            //7�������沿����ʾ����ʾ �������ǰDataGrid�еļ�¼��Ϊ0������ʾ��ǰ����ҳ������
            if (objDT.Rows.Count > 0)
            {
                this.tabDGRegionFldsJumpPage.Visible = true;
            }
            else
            {
                this.tabDGRegionFldsJumpPage.Visible = false;
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
            this.dgDGRegionFlds.CurrentPageIndex = 0;
            //�ѱ��¼��������ʾ��DATAGRID��
            BindDg_DGRegionFlds();
        }
        /// <summary>
        /// �������ܣ��¼��������ڸ���DATAGRID�ĵ�ǰҳ����ʱ�����ĺ�����
        ///			  ���幦����������ʾ��ҳ(������ҳ����)�����ݡ�
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void dgDGRegionFlds_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            //�������裺����2����
            //1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
            //2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ

            //1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
            this.dgDGRegionFlds.CurrentPageIndex = e.NewPageIndex;
            //2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ
            BindDg_DGRegionFlds();
        }
        /// <summary>
        /// �������ܣ����Ըùؼ��ֵļ�¼������ʾ�ڽ����ϣ�
        ///������     �������ǰ�ֵ������ؼ���
        /// </summary>
        /// <param name="lngmId">���¼�Ĺؼ��֣���ʾ�ñ�ؼ��ֵ�����</param>
        private void ShowData(long lngmId)
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
            if (clsDGRegionFldsBL.IsExist(lngmId) == false)		//���ùؼ��ֵļ�¼�Ƿ����
            {
                string ss = "�ؼ���Ϊ��" + lngmId + "�Ĳ�����!";
                clsCommonJsFunc.Alert(this, ss);
                return;
            }
            //3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
            clsDGRegionFldsEN objDGRegionFldsEN = new clsDGRegionFldsEN(lngmId);
            //4����ȡ�������������ԣ�
            clsDGRegionFldsBL.GetDGRegionFlds(ref objDGRegionFldsEN);
            Session.Add("objDGRegionFldsEN", objDGRegionFldsEN);
            //5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���
            GetDataFromDGRegionFldsClass(objDGRegionFldsEN);
            DispEditDGRegionFldsRegion();
        }
        ///���ɴ��߼�������ݴ��䵽�����ĺ�������
        /// <summary>
        /// �������ܣ�������������������ʾ��������
        ///ע�⣺��������������򣬲�����һ��������������ϵ�ģ�����Ϊһ��������ֵ��Ȼ����Ϊ����������ֵ
        ///      ������������ݿ�ʱ����Ӧ��һ���ֶ���ǰ�������ֶ��ں�
        /// </summary>
        /// <param name="pobjDGRegionFlds">��ʵ�������</param>
        private void GetDataFromDGRegionFldsClass(clsDGRegionFldsEN pobjDGRegionFlds)
        {
            wucDGRegionFlds1.FldId = pobjDGRegionFlds.FldId;

            //clsvDGRegionFldsEN objvDGRegionFlds =  clsvDGRegionFldsBL.GetFirstObj_S("RegionId = '" + RegionId + "' and TabFldId = " + pobjDGRegionFlds.TabFldId);
            //wucDGRegionFlds1.FldName = objvDGRegionFlds.FldName;

            wucDGRegionFlds1.CtlTypeId = pobjDGRegionFlds.CtlTypeId;
            wucDGRegionFlds1.ColCaption = pobjDGRegionFlds.HeaderText;
            wucDGRegionFlds1.IsNeedSort = pobjDGRegionFlds.IsNeedSort;
            wucDGRegionFlds1.IsTransToChkBox = pobjDGRegionFlds.IsTransToChkBox;
            wucDGRegionFlds1.IsVisible = pobjDGRegionFlds.IsVisible;
            wucDGRegionFlds1.IsFuncFld = pobjDGRegionFlds.IsFuncFld;
            wucDGRegionFlds1.DgFuncTypeId = pobjDGRegionFlds.DgFuncTypeId;
            wucDGRegionFlds1.SeqNum = pobjDGRegionFlds.SeqNum;
            wucDGRegionFlds1.Memo = pobjDGRegionFlds.Memo;
        }
        /// <summary>
        /// �������ܣ��¼�������������<ȷ���޸�>ʱ�������¼�������
        ///           ���幦��Ϊ�ѽ�������ͬ�����ݿ��У��ѽ������ݱ��浽���ݿ���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOKUpd_Click(object sender, System.EventArgs e)
        {
            string strMsg;	//ר�����ڴ�����Ϣ�ı���
            string strResult = " ";	//���ڴ����ڼ����������ʱ���ֵ�ı���
            string strCommandText;
            clsDGRegionFldsEN objDGRegionFldsEN;
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
                    if (!wucDGRegionFlds1.IsValid(ref strResult))
                    {
                        lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
                        return;
                    }
                    //2��������󲢳�ʼ������
                    //clsDGRegionFldsEN objDGRegionFldsEN;	//�������
                    objDGRegionFldsEN = new clsDGRegionFldsEN();	//��ʼ���¶���
                    //3���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
                    //4����ֵ�ӽ���㴫���߼��������ʵ���
                    PutDataToDGRegionFldsClass(objDGRegionFldsEN);		//�ѽ����ֵ����
                    //5����鴫��ȥ�Ķ��������Ƿ�Ϸ�
                    try
                    {
                        clsDGRegionFldsBL.CheckPropertyNew(    objDGRegionFldsEN);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
                    //6��������ʵ�������ݴ��������ݿ���
                    if (clsDGRegionFldsBL.AddNewRecordBySql2(objDGRegionFldsEN) == false)
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
                    BindDg_DGRegionFlds();
                    wucDGRegionFlds1.Clear();		//��տؼ�������
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
                    if (!wucDGRegionFlds1.IsValid(ref strResult))
                    {
                        lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
                        return;
                    }
                    //2����ֵ�ӽ���㴫���߼��������ʵ���
                    objDGRegionFldsEN = (clsDGRegionFldsEN)Session["objDGRegionFldsEN"];
                    PutDataToDGRegionFldsClass(objDGRegionFldsEN);		//�ѽ����ֵ����
                    //3����鴫��ȥ�Ķ��������Ƿ�Ϸ�
                    try
                    {
                        clsDGRegionFldsBL.CheckPropertyNew(    objDGRegionFldsEN);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
                    //4��������ʵ���������޸�ͬ�������ݿ���
                    if (            clsDGRegionFldsBL.UpdateBySql2(    objDGRegionFldsEN) == false)
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
                    BindDg_DGRegionFlds();
                    wucDGRegionFlds1.Clear();//��տؼ��е�����
                    //�ָ�<ȷ���޸�>���<���>
                    btnOKUpd.Text = "���";
                    DispDGRegionFldsInfo();
                    break;
            }
        }
        
        /// <summary>
        /// �������ܣ��ѽ����ϵ��������ݴ����������
        /// </summary>
        /// <param name="pobjDGRegionFlds">���ݴ����Ŀ�������</param>
        private void PutDataToDGRegionFldsClass(clsDGRegionFldsEN pobjDGRegionFlds)
        {
            pobjDGRegionFlds.FldId = wucDGRegionFlds1.FldId;
            pobjDGRegionFlds.CtlTypeId = wucDGRegionFlds1.CtlTypeId;
            pobjDGRegionFlds.HeaderText = wucDGRegionFlds1.ColCaption;
            pobjDGRegionFlds.IsNeedSort = wucDGRegionFlds1.IsNeedSort;
            pobjDGRegionFlds.IsTransToChkBox = wucDGRegionFlds1.IsTransToChkBox;
            pobjDGRegionFlds.IsVisible = wucDGRegionFlds1.IsVisible;
            pobjDGRegionFlds.IsFuncFld = wucDGRegionFlds1.IsFuncFld;
            pobjDGRegionFlds.DgFuncTypeId = wucDGRegionFlds1.DgFuncTypeId;
            pobjDGRegionFlds.SeqNum = wucDGRegionFlds1.SeqNum;
            pobjDGRegionFlds.UpdUser = UserId;
            pobjDGRegionFlds.UpdDate = clsDateTime.getTodayStr(0);
            pobjDGRegionFlds.Memo = wucDGRegionFlds1.Memo;
        }

        protected void dgDGRegionFlds_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
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
            if (strSortDGRegionFldsBy == "") return;
            if (e.Item.ItemType == ListItemType.Header)//����ؼ��Ƿ�Ϊҳü��
            {
                string strSortEx;
                for (int i = 0; i < this.dgDGRegionFlds.Columns.Count; i++)
                {
                    strSortEx = this.dgDGRegionFlds.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = strSortDGRegionFldsBy.IndexOf(strSortEx + " ");
                    if (intIndex >= 0)  //��ͼ״̬��������ʽ�Ƿ�Ϊ���е��ֶΣ�
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//�������壬��"webdings"��5�������ǣ�6�������ǣ�
                        intIndex = strSortDGRegionFldsBy.IndexOf("Asc");
                        lblSort.Text = (intIndex > 0 ? " 5" : " 6");//�Ƿ�Ϊ���򣬶���Ϊstring�ͣ�
                        e.Item.Cells[i].Controls.Add(lblSort);//��������ĵ�i����Ԫ��������һ�ؼ���
                        break;
                    }
                }
            }
        }

        protected void dgDGRegionFlds_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
        {
            long lngmId;
            string strCommandName;
            if (e.Item.ItemType == ListItemType.Item ||
                e.Item.ItemType == ListItemType.SelectedItem ||
                e.Item.ItemType == ListItemType.AlternatingItem ||
                e.Item.ItemType == ListItemType.EditItem)
            {
                strCommandName = ((LinkButton)e.CommandSource).CommandName;
                lngmId = long.Parse(e.Item.Cells[1].Text);
                switch (strCommandName)
                {
                    case "Delete":
                        clsDGRegionFldsBL.DelRecord(lngmId);
                        BindDg_DGRegionFlds();
                        break;
                    // Add other cases here, if there are multiple ButtonColumns in 
                    // the DataGrid control.
                    case "Update":
                        //�������裺���ܹ�2����
                        //1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
                        //2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�

                        //1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
                        ShowData(lngmId);
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
                    Set_DataGridAllChecked(dgDGRegionFlds, true);
                    lbSelAll.Text = "��ѡ";
                }
                else if (lbSelAll.Text == "��ѡ")
                {
                    Set_DataGridAllChecked(dgDGRegionFlds, false);
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
            DispPrjTabFldsInfo();
            
            //			btnOKUpd.Text = "ȷ�����";

        }

        
        //��ǰ��¼��
        protected void btnExportExcel4Dg_Click(object sender, System.EventArgs e)
        {
            //	1����Ͻ�����������
            string strWhereCond = CombineDGRegionFldsCondition();
            //	2��������������ȡ�ñ�����������DataTable��
            System.Data.DataTable objDT = null;
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "DGRegionFlds��Ϣ����.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add("mId"); arrCnName.Add("mId");
            arrColName.Add("RegionId"); arrCnName.Add("����Id");
            arrColName.Add("TabFldId"); arrCnName.Add("���ֶ�ID");
            arrColName.Add("CtlTypeId"); arrCnName.Add("�ؼ����ͺ�");
            arrColName.Add("ColCaption"); arrCnName.Add("�б���");
            arrColName.Add("IsNeedSort"); arrCnName.Add("�Ƿ���Ҫ����");
            arrColName.Add("IsTransToChkBox"); arrCnName.Add("�Ƿ�ת����CheckBox");
            arrColName.Add("IsVisible"); arrCnName.Add("�Ƿ���ʾ");
            arrColName.Add("IsFuncFld"); arrCnName.Add("�Ƿ����ֶ�");
            arrColName.Add("DgFuncTypeId"); arrCnName.Add("Dg��������Id");
            arrColName.Add("ColIndex"); arrCnName.Add("�����");
            arrColName.Add("UserId"); arrCnName.Add("�û�ID");
            arrColName.Add("UpdDate"); arrCnName.Add("�޸�����");
            arrColName.Add("Memo"); arrCnName.Add("˵��");
            strFolderName = Server.MapPath("~") + "\\TempFiles\\";
            strDownLoadFileName = strFolderName + strFileName;
            try
            {
                objDT = clsDGRegionFldsBL.GetDataTable_DGRegionFlds(strWhereCond);

                GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4Odbc(objDT, arrColName, arrCnName, strDownLoadFileName);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;	//"../GenCode/wfmGenViewCode_WebV5.aspx";
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
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
            List<string> arrmId = clsCommForWebForm.GetAllCheckedItemFromDg2(dgDGRegionFlds, "chkCheckRec");
            if (arrmId == null || arrmId.Count == 0)
            {
                lblMsg1.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
                return;
            }
            lblMsg1.Text = "";
            clsDGRegionFldsBL.DelDGRegionFldss(arrmId);
            BindDg_DGRegionFlds();
        }

        
        //��ǰ��¼��
        protected void btnUpdate4Dg_Click(object sender, System.EventArgs e)
        {
            string strmId = clsCommForWebForm.GetFirstCheckedItemFromDg(dgDGRegionFlds);
            if (strmId == null || strmId.Trim().Length == 0)
            {
                lblMsg1.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
                return;
            }
            lblMsg1.Text = "";
            //1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
            long lngmId;
            lngmId = long.Parse(strmId);
            ShowData(lngmId);
            //2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
            clsPubFun.SetButtonEnabled(btnOKUpd, true);
            btnOKUpd.Text = "ȷ���޸�";
        }
        
        public System.Data.DataTable GetDgFuncTypeId()
        {
            //��ȡĳѧԺ����רҵ��Ϣ
            string strSQL = "select DgFuncTypeId, DgFuncTypeName from DgFuncType ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindDdl_DgFuncTypeId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //Ϊ����Դ�ڱ����������������
            ListItem li = new ListItem("��ѡ��...", "0");
            System.Data.DataTable objDT = GetDgFuncTypeId();
            objDDL.DataValueField = "DgFuncTypeId";
            objDDL.DataTextField = "DgFuncTypeName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        public System.Data.DataTable GetUserId()
        {
            //��ȡĳѧԺ����רҵ��Ϣ
            string strSQL = "select UserId, UserName from Users ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindDdl_UserId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //Ϊ����Դ�ڱ����������������
            ListItem li = new ListItem("��ѡ��...", "0");
            System.Data.DataTable objDT = GetUserId();
            objDDL.DataValueField = "UserId";
            objDDL.DataTextField = "UserName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        
        protected void dgDGRegionFlds_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
        {
            int intIndex;
            //�ж��Ƿ����µ������ֶ�
            intIndex = strSortDGRegionFldsBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                strSortDGRegionFldsBy = e.SortExpression + " Asc";
                BindDg_DGRegionFlds();
                return;
            }
            //���ԭ��������
            intIndex = strSortDGRegionFldsBy.IndexOf(" Asc");
            if (intIndex == -1)		//���ԭ���������������Ϊ����
            {
                strSortDGRegionFldsBy = e.SortExpression + " Asc";
            }
            else			///��������Ϊ����
            {
                strSortDGRegionFldsBy = e.SortExpression + " Desc";
            }
            BindDg_DGRegionFlds();
        }

        private string strSortDGRegionFldsBy
        {
            get
            {
                string sSortDGRegionFldsBy;
                sSortDGRegionFldsBy = (string)ViewState["SortDGRegionFldsBy"];
                if (sSortDGRegionFldsBy == null)
                {
                    sSortDGRegionFldsBy = "";
                }
                return sSortDGRegionFldsBy;
            }
            set
            {
                string sSortDGRegionFldsBy = value;
                ViewState.Add("SortDGRegionFldsBy", sSortDGRegionFldsBy);
            }
        }

        //���ɸ������SESSION������Ժ���
        protected void btnDGRegionFldsPrevPage_Click(object sender, System.EventArgs e)
        {
            this.dgDGRegionFlds.CurrentPageIndex -= 1;
            this.BindDg_DGRegionFlds();
        }

        protected void btnDGRegionFldsNextPage_Click(object sender, System.EventArgs e)
        {
            this.dgDGRegionFlds.CurrentPageIndex += 1;
            this.BindDg_DGRegionFlds();
        }

        protected void btnDGRegionFldsJumpPage_Click(object sender, System.EventArgs e)
        {
            if (this.txtDGRegionFldsJump2Page.Text.Trim() != "" &&
                int.Parse(this.txtDGRegionFldsJump2Page.Text) > 0 &&
                int.Parse(this.txtDGRegionFldsJump2Page.Text) - 1 < this.dgDGRegionFlds.PageCount)
            {
                this.dgDGRegionFlds.CurrentPageIndex = int.Parse(this.txtDGRegionFldsJump2Page.Text) - 1;
            }
            this.BindDg_DGRegionFlds();
        }

        protected void btnCopyFldFromRelaTab_Click(object sender, System.EventArgs e)
        {
            //�������裺
            //1����ȡ��ǰ����ID���������ID��
            //2����ȡ�������ID���ֶ�ID�Ķ����б�;
            //2�����ؼ����������������Ƿ���ȷ
            //2��������󲢳�ʼ������
            //3���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
            //4����ֵ�ӽ���㴫���߼��������ʵ���
            //5����鴫��ȥ�Ķ��������Ƿ�Ϸ�
            //6��������ʵ�������ݴ��������ݿ���
            //7��������ļ�¼������ʾ��DATAGRID��


            clsDGRegionFldsBLEx.ImportRelaFlds(RegionId, clsPubVar.CurrCmPrjId, UserId);
            BindDg_DGRegionFlds();
            ///�ָ�<ȷ�����>���<���>
            //		lbDispFldList_Click(new object(), new System.EventArgs());
            Response.Write("<script>alert('�������ص������ֶ���Ϣ���Ƴɹ�����')</script>");
        }
        
        protected void LinkButton1_Click(object sender, System.EventArgs e)
        {
            DispDGRegionFldsInfo();
        }

        protected void btnOKAddRec_Click(object sender, System.EventArgs e)
        {

           

        }

        protected void btnGoBack_Click(object sender, System.EventArgs e)
        {
            Response.Redirect(BackViewRegionLinkStr);
        }
                
        private void DispDGRegionFldsInfo()
        {
            tabDGRegionFldsDataGrid.Visible = true;
            tabDGRegionFldsJumpPage.Visible = true;
            tabEditDGRegionFldsRegion.Visible = false;
            tabTabFldList.Visible = false;
            tabDGRegionPreview.Visible = true;
            tabCode.Visible = true;
        }
        private void DispPrjTabFldsInfo()
        {
            tabTabFldList.Visible = true;
            tabEditDGRegionFldsRegion.Visible = false;
            tabDGRegionFldsDataGrid.Visible = false;
            tabDGRegionFldsJumpPage.Visible = false;
            tabDGRegionPreview.Visible = false;
            tabCode.Visible = false;
        }
        private void DispEditDGRegionFldsRegion()
        {
            tabDGRegionFldsDataGrid.Visible = false;
            tabDGRegionFldsJumpPage.Visible = false;
            tabEditDGRegionFldsRegion.Visible = true;
            tabTabFldList.Visible = false;
            tabDGRegionPreview.Visible = false;
            tabCode.Visible = false;
        }

        protected void btnPreView_Click(object sender, System.EventArgs e)
        {
            string strMsg;
            string strViewId = clsCommonSession.ViewId;// clsViewRegionBL.GetObjByRegionIdCache(RegionId, clsPubVar.CurrSelPrjId).ViewId;
            //			tabQuery1.Visible = false;
            tabCode.Visible = true;

            lblMsg2.Text = "";
            //������ش���
            string strRe_ClsName = "";
            string strRe_FileNameWithModuleName = "";
            Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);

            try
            {

                clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
                clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, clsPubVar.CurrSelPrjId);
                WebViewCode4Html autoGC5Cs_VWeb = new WebViewCode4Html(strViewId);
                objViewInfoENEx.FolderName = "D:\\FTP\\ClsFile\\" + UserId + "\\";
                objViewInfoENEx.CurrUserName = clsCommonSession.UserName;
                ShowCode(autoGC5Cs_VWeb.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName));
                if (objViewInfoENEx.FileName != null)
                {
                    txtFileName4GenCode.Text = objViewInfoENEx.FileName;
                    SimpleFName = clsString.GetSimpleFName_S(objViewInfoENEx.FileName);
                }
                //��ʾ��ؿؼ�
                ///
                if (WebViewCode4Html.DispDataGridRegionCtrl(phDataGrid1, objViewInfoENEx) == true)
                {
                    lblMsg2.Text = "��ʾ�ؼ��ɹ�!";
                };
            }
            catch (Exception objException)
            {
                strMsg = objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsg1.Text = strMsg;
                //				clsCommonSession.seErrMessage = objException.Message;
                //				clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;	//"../GenCode/wfmGenViewCode_WebV5.aspx";
                //				clsPubFun4Web.AccessError(this, conCurrPageName);
            }

        }

        protected void btnUpMove_Click(object sender, System.EventArgs e)
        {
            string strMsg;
            string strmId = clsCommForWebForm.GetFirstCheckedItemFromDg(dgDGRegionFlds);
            if (strmId == null || strmId.Trim().Length == 0)
            {
                lblMsg1.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
                return;
            }
            lblMsg1.Text = "";
            long lngmId;
            lngmId = long.Parse(strmId);
            try
            {
                clsDGRegionFldsBLEx.AdjustSequenceNumber("UP", lngmId);
            }
            catch (Exception objException)
            {
                strMsg = objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsg1.Text = strMsg;
                //				clsCommonSession.seErrMessage = objException.Message;
                //				clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;	//"../GenCode/wfmGenViewCode_WebV5.aspx";
                //				clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindDg_DGRegionFlds();
            clsCommForWebForm.SetCheckedItemForDg(dgDGRegionFlds, 1, strmId);

        }

        protected void btnDownMove_Click(object sender, System.EventArgs e)
        {
            string strMsg;
            string strmId = clsCommForWebForm.GetFirstCheckedItemFromDg(dgDGRegionFlds);
            if (strmId == null || strmId.Trim().Length == 0)
            {
                lblMsg1.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
                return;
            }
            lblMsg1.Text = "";
            long lngmId;
            lngmId = long.Parse(strmId);
            try
            {
                clsDGRegionFldsBLEx.AdjustSequenceNumber("DOWN", lngmId);
            }

            catch (Exception objException)
            {
                strMsg = objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsg1.Text = strMsg;
                //				clsCommonSession.seErrMessage = objException.Message;
                //				clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;	//"../GenCode/wfmGenViewCode_WebV5.aspx";
                //				clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindDg_DGRegionFlds();
            clsCommForWebForm.SetCheckedItemForDg(dgDGRegionFlds, 1, strmId);

        }

        protected void btnReOrder_Click(object sender, System.EventArgs e)
        {
            clsDGRegionFldsBLEx.ReOrder(RegionId);
            BindDg_DGRegionFlds();

        }

        protected void lbDispTabList_Click(object sender, System.EventArgs e)
        {
            DispDGRegionFldsInfo();
        }
        protected void lbDownLoadFile_Click(object sender, EventArgs e)
        {
            string strFileName = UserId + "\\" + SimpleFName;
            string strFolderName;
            string strDownLoadFileName;
            strFolderName = Server.MapPath("/ClsFile/");
            strDownLoadFileName = strFolderName + strFileName;
            DownLoadFile(strDownLoadFileName);
        }

        protected void lbDownLoadExcelFileTempolate_Click(object sender, System.EventArgs e)
        {
            string strFileName = "ͨ��SQL���ݿ����ģ��.xlt";
            string strFolderName;
            string strDownLoadFileName;
            strFolderName = Server.MapPath("/AGC_CS/RelateFile/");
            strDownLoadFileName = strFolderName + strFileName;
            DownLoadFile(strDownLoadFileName);
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