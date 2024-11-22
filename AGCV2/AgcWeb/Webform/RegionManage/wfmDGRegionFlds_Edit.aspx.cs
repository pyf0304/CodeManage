///���ɲ�ѯ���޸ģ�ɾ������Ӽ�¼�Ŀ��Ʋ����


using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Agc;
using AGC.BusinessLogic;
using AGC.BusinessLogicEx;

using AGC.Entity;
using AGC.FunClass;
using AgcCommBase;
using AutoGCLib;
using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.datetime;
using com.taishsoft.json;
using CommFunc4WebForm;


namespace AGC.Webform
{
    /// <summary>
    /// wfmDGRegionFlds_QUDI ��ժҪ˵��������Q�����ѯ��U�����޸�
    /// </summary>
    public partial class wfmDGRegionFlds_Edit : CommWebPageBase
    {



        //�����йصı����������
        private const string ViewId4Potence = "00260203";		//������


        protected void Page_Load(object sender, System.EventArgs e)
        {
            vsIsDisp = false;
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
                clsvViewRegionEN objvViewRegion = clsvViewRegionBL.GetObjByRegionIdCache(getRegionId, clsPubVar.CurrSelPrjId);


                //1��Ϊ��������������Դ�����б�����
                wucDGRegionFlds1.SetDdl_CtlTypeId(false);
                wucDGRegionFlds1.SetDdl_DgFuncTypeId();
                wucDGRegionFlds1.SetDdl_FldId(objvViewRegion.TabId);
                wucDGRegionFlds1.vsTabId = objvViewRegion.TabId;
                wucDGRegionFlds1.SetDdl_DataNodeIdByTabId(objvViewRegion.TabId, objvViewRegion.PrjId);

                strSortDGRegionFldsBy = "SeqNum Asc";
               
                vsInOutTypeId = objvViewRegion.InOutTypeId;
                
                txtWidth.Text = objvViewRegion.Width.ToString();
                if (string.IsNullOrEmpty(objvViewRegion.ClsName) == true)
                {
                    clsViewRegionBLEx.SetClassName(getRegionId,0);
                    objvViewRegion = clsvViewRegionBL.GetObjByRegionIdCache(getRegionId, clsPubVar.CurrSelPrjId);
                }
                txtClassName.Text = objvViewRegion.ClsName;
                txtFileName.Text = objvViewRegion.FileName;
                vsApplicationTypeId = objvViewRegion.ApplicationTypeId ?? 0;
                //2����ʾ�������ı�������DATAGRID��
                BindGv_vDGRegionFlds();
                
                //tabEditDGRegionFldsRegion.Visible = false;
                //3�����ñ�ؼ����ֿؼ���ReadOnly���ԣ�
                //   ʹֻ֮������Ϊ���޸Ĺ����йؼ����ǲ��ܱ��޸ĵġ�
            }
            ShowCodeTypeButton();
            if (vsIsDisp == false)
            {
                try
                {
                    wucListRegion4Preview1.ShowControl4Regoin(getRegionId, clsPubVar.CurrSelPrjId, 5, true, clsPubVar.CurrCmPrjId);
                    //	3������Gv�ؼ���ĳЩ�в��ɼ���

                    //wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.UpdUser, false);
                }
                catch (Exception objException)
                {
                    string strMsg = "(errid:WebI000119)���ӻ���ʾ����������!" + objException.Message;
                    clsCommonJsFunc.Alert(this, strMsg);
                    return;
                }
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
        private string CombinevDGRegionFldsCondition()
        {
            //ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
            //���� 1=1 && UserName = '����'
            string strWhereCond = " 1=1 ";
            //����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
            strWhereCond += " And RegionId='" + getRegionId + "'";
            if (chkOnlyShowFldInUse.Checked == true)
            {
                strWhereCond += string.Format(" And {0}='1'", conDGRegionFlds.InUse);
            }

            return strWhereCond;
        }

        /// <summary>
        /// ��������:�Ѳ�ѯ���ݰ���GridView�ϡ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼,
        ///			 ����ʾ��GridView�С�
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenBindGridView4WucInPage)
        /// </summary>
        protected void BindGv_vDGRegionFlds()
        {
            //��������:(��5��)
            //	1����Ͻ�����������
            //	2�����ÿؼ��еİ�GridView����;
            //	3������Gv�ؼ���ĳЩ�в��ɼ�;

            try
            {
                wucvDGRegionFlds4Gv1.SetGvVisibility(convDGRegionFlds.HeaderText, false);
                wucvDGRegionFlds4Gv1.SetGvVisibility(convDGRegionFlds.InUse, false);
                wucvDGRegionFlds4Gv1.SetGvVisibility(convDGRegionFlds.DgFuncTypeName, false);
                wucvDGRegionFlds4Gv1.SetGvVisibility(convDGRegionFlds.IsFuncFld, false);
                wucvDGRegionFlds4Gv1.SetGvVisibility(convDGRegionFlds.IsVisible, false);
                //	1����Ͻ�����������
                string strWhereCond = CombinevDGRegionFldsCondition();
                //	2�����ÿؼ��еİ�GridView������
                wucvDGRegionFlds4Gv1.SetSortBy_Prev(string.Format("{0} desc", convDGRegionFlds.InUse));
                wucvDGRegionFlds4Gv1.SetSortBy(string.Format("{0}", convDGRegionFlds.SeqNum));
                wucvDGRegionFlds4Gv1.BindGv_DGRegionFlds(strWhereCond);
                //	3������Gv�ؼ���ĳЩ�в��ɼ���
           
                wucvDGRegionFlds4Gv1.SetGvVisibility("�޸�", false);
                wucvDGRegionFlds4Gv1.SetGvVisibility("ɾ��", false);
                //wucvDGRegionFlds4Gv1.SetGvVisibility(convDGRegionFlds.UpdUser, false);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000019)��GridView����!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            try
            {
                wucListRegion4Preview1.ShowControl4Regoin(getRegionId, clsPubVar.CurrSelPrjId, 5,true, clsPubVar.CurrCmPrjId);
                vsIsDisp = true;
                //	3������Gv�ؼ���ĳЩ�в��ɼ���

                //wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.UpdUser, false);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000119)���ӻ���ʾ����������!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
        }


        /// <summary>
        /// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
        ///			 ����ʾ��DATAGRID�С�
        /// </summary>
        private void BindDg_DGRegionFldsBak()
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
            string strWhereCond = CombinevDGRegionFldsCondition();
            //	2��������������ȡ�ñ�����������DataTable��
            System.Data.DataTable objDT = clsvDGRegionFldsBL.GetDataTable(strWhereCond + " order by SeqNum");

            if (vsInOutTypeId == "02")//��ͼ
            {
                clsDGRegionFldsBLEx.AddColumn_SourceTabName(ref objDT);
            }
            else
            {
                objDT.Columns.Add("SourceTabName");
            }

            //	3�����DATAGRID�ĵ�ǰҳ���Ƿ񳬳�DATAGRID��ҳ����Χ
            //		3.1 ���ȼ���ҳ����
            //		3.2 �����ǰҳ����ҳ����Ϊ���һҳ
            //int intPages = CalcPages(objDT.Rows.Count, this.dgDGRegionFlds.PageSize);
            //if (intPages == 0)
            //{
            //    this.dgDGRegionFlds.CurrentPageIndex = 0;
            //}
            //else if (this.dgDGRegionFlds.CurrentPageIndex > intPages - 1)
            //{
            //    this.dgDGRegionFlds.CurrentPageIndex = intPages - 1;
            //}
            ////	4������DATAGRID������Դ(DataSource)��
            //DataView objDV = objDT.DefaultView;
            //objDV.Sort = strSortDGRegionFldsBy;     ///ע����һ�д����п�����Ҫע�͵���Ŀǰ���н����ڵ����Ĳ�ѯ������������
            //this.dgDGRegionFlds.DataSource = objDV;
            ////	5����DATAGRID������DataTable��������ʾ��DATAGRID��
            //this.dgDGRegionFlds.DataBind();


            ////��ǰ��¼��
            //this.lblDGRegionFldsRecCount.Text = objDT.Rows.Count.ToString();
            ////��ǰҳ��
            //this.lblDGRegionFldsAllPages.Text = this.dgDGRegionFlds.PageCount.ToString();
            ////��ǰҳ����
            //this.lblDGRegionFldsCurrentPage.Text = (this.dgDGRegionFlds.CurrentPageIndex + 1).ToString();
            ////��ǰ����������ҳ����
            //this.txtDGRegionFldsJump2Page.Text = (this.dgDGRegionFlds.CurrentPageIndex + 1).ToString();
            ////�����ǰҳ����Ϊ0����<ǰһҳ>��ť��Ч
            //if (this.dgDGRegionFlds.CurrentPageIndex == 0)
            //{
            //    clsPubFun.SetButtonEnabled(btnDGRegionFldsPrevPage, false);
            //}
            //else
            //{
            //    clsPubFun.SetButtonEnabled(btnDGRegionFldsPrevPage, true);
            //}
            ////�����ǰҳ������Ϊ���һҳ����<ǰһҳ>��ť��Ч
            //if (this.dgDGRegionFlds.CurrentPageIndex == this.dgDGRegionFlds.PageCount - 1)
            //{
            //    clsPubFun.SetButtonEnabled(btnDGRegionFldsNextPage, false);
            //}
            //else
            //{
            //    clsPubFun.SetButtonEnabled(btnDGRegionFldsNextPage, true);
            //}
            ////7�������沿����ʾ����ʾ �������ǰDataGrid�еļ�¼��Ϊ0������ʾ��ǰ����ҳ������
            //if (objDT.Rows.Count > 0)
            //{
            //    this.tabDGRegionFldsJumpPage.Visible = true;
            //}
            //else
            //{
            //    this.tabDGRegionFldsJumpPage.Visible = false;
            //}
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
            wucvDGRegionFlds4Gv1.vsPageIndex = 1;
            //�ѱ��¼��������ʾ��GridView��
            BindGv_vDGRegionFlds();
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
            clsDGRegionFldsEN objDGRegionFldsEN = clsDGRegionFldsBL.GetObjBymId(lngmId);
            //4����ȡ�������������ԣ�
            //clsDGRegionFldsBL.GetDGRegionFlds();
            Session.Add("objDGRegionFlds", objDGRegionFldsEN);
            //5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���
            GetDataFromDGRegionFldsClass(objDGRegionFldsEN);
            //DispEditDGRegionFldsRegion();
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
            //if (string.IsNullOrEmpty(pobjDGRegionFlds.OutDataNodeId) == false)
            //{
            //    wucDGRegionFlds1.SetDdl_DataNodeId(pobjDGRegionFlds.FldId);
            try
            {
                var objViewRegion = clsViewRegionBL.GetObjByRegionIdCache(pobjDGRegionFlds.RegionId, clsPubVar.CurrSelPrjId);
                wucDGRegionFlds1.vsCmPrjId = objViewRegion.PrjId;
                //wucDGRegionFlds1.DataNodeId = pobjDGRegionFlds.OutDataNodeId;
            }
            catch(Exception objException)
            {

                clsPubVar.objLog.WriteDebugLog(objException.Message);
                //string ss = "";
            }
            //wucDGRegionFlds1.DataPropertyName = pobjDGRegionFlds.DataPropertyName;
            wucDGRegionFlds1.SortExpression = pobjDGRegionFlds.SortExpression;

            //}
            //clsvDGRegionFldsEN objvDGRegionFlds = clsvDGRegionFldsBL.GetFirstObj_S("RegionId = '" + getRegionId + "' and TabFldId = " + pobjDGRegionFlds.TabFldId);
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
                    wucDGRegionFlds1.SeqNum = 1;
                    wucDGRegionFlds1.CtlTypeId = enumCtlType.Label_10;
                    wucDGRegionFlds1.DgFuncTypeId = enumDgFuncType.Unknown_0000;
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
                        clsDGRegionFldsBL.CheckPropertyNew(objDGRegionFldsEN);
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
                        //clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                        strMsg = "��Ӽ�¼�ɹ�!";
                        clsCommonJsFunc.Alert(this, strMsg);
                        lblMsg.Text = "��Ӽ�¼�ɹ�!";
                    }
                    //7��������ļ�¼������ʾ��DATAGRID��
                    BindGv_vDGRegionFlds();
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
                    objDGRegionFldsEN = (clsDGRegionFldsEN)Session["objDGRegionFlds"];
                    PutDataToDGRegionFldsClass(objDGRegionFldsEN);		//�ѽ����ֵ����
                    //3����鴫��ȥ�Ķ��������Ƿ�Ϸ�
                    try
                    {
                        clsDGRegionFldsBL.CheckPropertyNew(objDGRegionFldsEN);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
                    //4��������ʵ���������޸�ͬ�������ݿ���
                    if (clsDGRegionFldsBL.UpdateBySql2(objDGRegionFldsEN) == false)
                    {
                        strMsg = "�޸ļ�¼���ɹ�!";
                        clsCommonJsFunc.Alert(this, strMsg);
                        lblMsg.Text = "�޸ļ�¼���ɹ�!";
                    }
                    else
                    {
                        //clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                        strMsg = "�޸ļ�¼�ɹ�!";
                        clsCommonJsFunc.Alert(this, strMsg);
                        lblMsg.Text = "�޸ļ�¼�ɹ�!";
                    }
                    //5�����޸ĺ��������ʾ��DATAGRID��
                    BindGv_vDGRegionFlds();
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
            //pobjDGRegionFlds.OutDataNodeId = wucDGRegionFlds1.DataNodeId;

            //if (string.IsNullOrEmpty(pobjDGRegionFlds.OutDataNodeId) == false)
            //{
            //    pobjDGRegionFlds.IsUseFunc = true;
            //}
            //else
            //{
            //    pobjDGRegionFlds.IsUseFunc = false;
            //}
            //pobjDGRegionFlds.DataPropertyName = wucDGRegionFlds1.DataPropertyName;
            pobjDGRegionFlds.SortExpression = wucDGRegionFlds1.SortExpression;
            if (string.IsNullOrEmpty(pobjDGRegionFlds.SortExpression) == true)
            {
                //if (string.IsNullOrEmpty(pobjDGRegionFlds.DataPropertyName) == false)
                //{
                //    pobjDGRegionFlds.SortExpression = pobjDGRegionFlds.DataPropertyName;
                //}
                //else
                //{
                //    var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(pobjDGRegionFlds.FldId, pobjDGRegionFlds.PrjId);
                //    if (objFieldTab != null)
                //    {
                //        pobjDGRegionFlds.SortExpression = objFieldTab.FldName;
                //    }
                //}
            }
            pobjDGRegionFlds.CtlTypeId = wucDGRegionFlds1.CtlTypeId;
            pobjDGRegionFlds.HeaderText = wucDGRegionFlds1.ColCaption;
            pobjDGRegionFlds.IsNeedSort = wucDGRegionFlds1.IsNeedSort;
            pobjDGRegionFlds.IsTransToChkBox = wucDGRegionFlds1.IsTransToChkBox;
            pobjDGRegionFlds.IsVisible = wucDGRegionFlds1.IsVisible;
            pobjDGRegionFlds.IsFuncFld = wucDGRegionFlds1.IsFuncFld;
            pobjDGRegionFlds.DgFuncTypeId = wucDGRegionFlds1.DgFuncTypeId;
            pobjDGRegionFlds.SeqNum = wucDGRegionFlds1.SeqNum;
            pobjDGRegionFlds.InUse = true;
            pobjDGRegionFlds.UpdUser = UserId;
            pobjDGRegionFlds.UpdDate = clsDateTime.getTodayStr(0);
            pobjDGRegionFlds.Memo = wucDGRegionFlds1.Memo;
            pobjDGRegionFlds.RegionId = qsRegionId;
            pobjDGRegionFlds.PrjId = clsPubVar.CurrCmPrjId;


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
            string strWhereCond = CombinevDGRegionFldsCondition();
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
            arrColName.Add("SeqNum"); arrCnName.Add("�����");
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
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;	//"../GenCode/wfmGenViewCode_WebV5.aspx";
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
            List<long> lstMId = wucvDGRegionFlds4Gv1.GetAllCheckedKeysFromGv();
            if (lstMId == null) return;
            //lblMsgList.Text = "";
            lblMsg1.Text = "";
            foreach (long lngmId in lstMId)
            {
                clsDGRegionFldsBLEx.DelRecordEx(lngmId, clsPubVar.CurrSelPrjId);
            }
            //clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            clsDGRegionFldsBLEx.ReOrder(getRegionId);
            //clsViewRegionBLEx.SetFldCount(getRegionId);
            //clsViewRegionBLEx.SetFldCountInUse(getRegionId);

            BindGv_vDGRegionFlds();
        }


        //��ǰ��¼��
        protected void btnUpdate4Dg_Click(object sender, System.EventArgs e)
        {

            long lngmId = 0;
            try
            {
                if (string.IsNullOrEmpty(hidCtrlId.Value) == false)
                {

                    lblMsg1.Text = "";
                    //1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�

                    ShowData(hidCtrlId.Value);
                    //2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
                    clsPubFun.SetButtonEnabled(btnOKUpd, true);
                    btnOKUpd.Text = "ȷ���޸�";
                    return;
                }
            }
            catch(Exception objException)
            {

                clsPubVar.objLog.WriteDebugLog(objException.Message);

                lngmId = wucvDGRegionFlds4Gv1.GetFirstCheckedKeyFromGv();
                if (lngmId == 0) return;
                UpdateDGRegionFldsRecord(lngmId);
                return;
            }
            lngmId = wucvDGRegionFlds4Gv1.GetFirstCheckedKeyFromGv();
            if (lngmId == 0) return;
            UpdateDGRegionFldsRecord(lngmId);
        }
        /// <summary>
        /// Ϊ�޸ļ�¼��׼������,�Ѹ����ؼ��ֵļ�¼�ֶ�ֵ��ʾ���û��ؼ���
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenUpdateRecordCode)
        /// </summary>
        protected void UpdateDGRegionFldsRecord(long lngmId)
        {
            //��������:(�ܹ�2��)
            //1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
            //2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�

            //1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
            ShowData(lngmId);
            //2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
            btnOKUpd.Enabled = true;
            btnOKUpd.Text = "ȷ���޸�";
            //btnCancelDGRegionFldsEdit.Text = "ȡ���޸�";
            lblMsg1.Text = "";
            //DispEditDGRegionFldsRegion();
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


            clsDGRegionFldsBLEx.ImportRelaFlds(getRegionId, clsPubVar.CurrCmPrjId, UserId);
            //clsViewRegionBLEx.SetFldCount(getRegionId);
            //clsViewRegionBLEx.SetFldCountInUse(getRegionId);

            //clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            BindGv_vDGRegionFlds();
            ///�ָ�<ȷ�����>���<���>
            //		lbDispFldList_Click(new object(), new System.EventArgs());
            Response.Write("<script>alert('�������ص������ֶ���Ϣ���Ƴɹ�����')</script>");
        }

     
        protected void LinkButton1_Click(object sender, System.EventArgs e)
        {
            DispDGRegionFldsInfo();
        }

      
        protected void btnGoBack_Click(object sender, System.EventArgs e)
        {
            Response.Redirect(BackViewRegionLinkStr);
        }

      
        private void DispDGRegionFldsInfo()
        {
            tabDGRegionFldsDataGrid.Visible = true;
            //tabDGRegionFldsJumpPage.Visible = true;
            //tabEditDGRegionFldsRegion.Visible = false;
      

            //tabCode.Visible = true;
        }
        private void DispPrjTabFldsInfo()
        {
            
            //tabEditDGRegionFldsRegion.Visible = false;
            tabDGRegionFldsDataGrid.Visible = false;
            //tabDGRegionFldsJumpPage.Visible = false;
            //tabCode.Visible = false;
        }
        private void DispEditDGRegionFldsRegionBak()
        {
            tabDGRegionFldsDataGrid.Visible = false;
            //tabDGRegionFldsJumpPage.Visible = false;
            //tabEditDGRegionFldsRegion.Visible = true;
            
        }


        protected void btnUpMove_Click(object sender, System.EventArgs e)
        {
            string strMsg;
            long lngmId = wucvDGRegionFlds4Gv1.GetFirstCheckedKeyFromGv();
            if (lngmId == 0) return;
            lblMsg1.Text = "";

            try
            {
                clsDGRegionFldsBLEx.AdjustSequenceNumber("UP", lngmId);
                //clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
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
            BindGv_vDGRegionFlds();
            wucvDGRegionFlds4Gv1.SetCheckedItemForGv(lngmId);

        }

        protected void btnDownMove_Click(object sender, System.EventArgs e)
        {
            string strMsg;
            long lngmId = wucvDGRegionFlds4Gv1.GetFirstCheckedKeyFromGv();
            if (lngmId == 0) return;
            lblMsg1.Text = "";

            try
            {
                clsDGRegionFldsBLEx.AdjustSequenceNumber("DOWN", lngmId);
                //clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
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
            BindGv_vDGRegionFlds();
            wucvDGRegionFlds4Gv1.SetCheckedItemForGv(lngmId);

        }

        protected void btnReOrder_Click(object sender, System.EventArgs e)
        {
            clsDGRegionFldsBLEx.ReOrder(getRegionId);
            //clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            BindGv_vDGRegionFlds();

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

        protected void btnGoFirstLine_Click(object sender, EventArgs e)
        {
            string strMsg;
            long lngmId = wucvDGRegionFlds4Gv1.GetFirstCheckedKeyFromGv();
            if (lngmId == 0) return;
            lblMsg1.Text = "";

            try
            {
                clsDGRegionFldsBLEx.AdjustSequenceNumber("FIRST", lngmId);
                //clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
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
            BindGv_vDGRegionFlds();
            wucvDGRegionFlds4Gv1.SetCheckedItemForGv(lngmId);
        }

        protected void btnGoLastLine_Click(object sender, EventArgs e)
        {
            string strMsg;
            long lngmId = wucvDGRegionFlds4Gv1.GetFirstCheckedKeyFromGv();
            if (lngmId == 0) return;
            lblMsg1.Text = "";

            try
            {
                clsDGRegionFldsBLEx.AdjustSequenceNumber("LAST", lngmId);
                //clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
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
            BindGv_vDGRegionFlds();
            wucvDGRegionFlds4Gv1.SetCheckedItemForGv(lngmId);
        }

        /// <summary>
        /// Sql��������Id�� ������01����02:��ͼ��
        /// </summary>
        public string vsInOutTypeId
        {
            get
            {
                string strInOutTypeId;
                strInOutTypeId = (string)ViewState["InOutTypeId"];
                if (strInOutTypeId == null)
                {
                    strInOutTypeId = "";
                }
                return strInOutTypeId;
            }
            set
            {
                string strInOutTypeId = value;
                ViewState.Add("InOutTypeId", strInOutTypeId);
            }
        }

        public bool vsIsDisp
        {
            get
            {
                string strIsDisp;
                strIsDisp = (string)ViewState["IsDisp"];
                if (strIsDisp == null)
                {
                    return false;
                }
                return bool.Parse(strIsDisp);
            }
            set
            {
                string strIsDisp = value.ToString();
                ViewState.Add("IsDisp", strIsDisp);
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


        protected void btnSetInUse_Click(object sender, EventArgs e)
        {
            List<long> lstMId = wucvDGRegionFlds4Gv1.GetAllCheckedKeysFromGv();
            if (lstMId == null) return;
            lblMsg1.Text = "";
            try
            {
                clsDGRegionFldsBLEx.SetInUse(lstMId, clsCommonSession.UserId);
                clsDGRegionFldsBLEx.ReOrder(getRegionId);
                //clsViewRegionBLEx.SetFldCount(getRegionId);
                //clsViewRegionBLEx.SetFldCountInUse(getRegionId);

                //clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                BindGv_vDGRegionFlds();
            }
            catch (Exception objException)
            {
                string strMsg = objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsg1.Text = strMsg;
            }
        }

        protected void btnSetNotInUse_Click(object sender, EventArgs e)
        {
            List<long> lstMId = wucvDGRegionFlds4Gv1.GetAllCheckedKeysFromGv();
            if (lstMId == null) return;
            lblMsg1.Text = "";
            try
            {
                clsDGRegionFldsBLEx.SetNotInUse(lstMId, clsCommonSession.UserId);
                clsDGRegionFldsBLEx.ReOrder(getRegionId);
                //clsViewRegionBLEx.SetFldCount(getRegionId);
                //clsViewRegionBLEx.SetFldCountInUse(getRegionId);

                //clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                BindGv_vDGRegionFlds();
            }
            catch (Exception objException)
            {
                string strMsg = objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsg1.Text = strMsg;
            }
        }

        protected void chkOnlyShowFldInUse_CheckedChanged(object sender, EventArgs e)
        {
            BindGv_vDGRegionFlds();
        }

        ///
        /// <summary>
        /// �¼�����:��Gv�б�ؼ��У���GeidView�е���ɾ��ʱ�������¼���
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_Wuc4Gv_GvDeleteClick)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void wucvDGRegionFlds4Gv1_GvDeleteClick(object sender, clsEventArgs4Delete e)
        {
            long lngmId = long.Parse(e.KeyId);
            DeleteDGRegionFldsRecord(lngmId);
        }
        /// <summary>
        /// ���ݸ����ؼ���ɾ����¼
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDelRecordCode)
        /// </summary>
        /// <param name = "lngmId">�����ؼ���</param>
        protected void DeleteDGRegionFldsRecord(long lngmId)
        {
            try
            {
                clsDGRegionFldsBL.DelRecord(lngmId);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000022)ɾ����¼���ɹ�!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsg1.Text = strMsg;
                return;
            }
            BindGv_vDGRegionFlds();
        }
        ///
        /// <summary>
        /// �¼�����:��Gv�б�ؼ��У���GeidView�е����޸�ʱ�������¼���
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_Wuc4Gv_GvUpdateClick)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void wucvDGRegionFlds4Gv1_GvUpdateClick(object sender, clsEventArgs4Update e)
        {
            long lngmId = long.Parse(e.KeyId);
            UpdateDGRegionFldsRecord(lngmId);
        }
        public void ShowCode(string strCode)
        {
            StringBuilder sbJs = new StringBuilder();
            //sbJs.Append("<script type=\"text/javascript\">");
            sbJs.AppendFormat("<textarea style=\"width: 100%; height: 720px; \">", strCode);
            sbJs.AppendFormat("{0}", strCode);
            sbJs.AppendFormat("</textarea>", strCode);
            //sbJs.Append("</script>");
            //litCode.Text = sbJs.ToString();
        }

        private void ShowCodeTypeButton()
        {
            pnlCodeTypeLst.Controls.Clear();
            
            int intAppTypeId = vsApplicationTypeId;
                       

            List<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                            clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(enumFunctionTemplate.RegionFunctionSet_0004,
                            "",
                            enumRegionType.ListRegion_0002)
                            .OrderBy(x => x.OrderNum).ToList();

            //������-������صĺ���

            int intCount4 = arrvFunction4GeneCodeObjLst.Count();

            clsvApplicationTypeEN objvApplicationTypeEN = clsvApplicationTypeBL.GetObjByApplicationTypeIdCache(intAppTypeId);
            string strCharEncodingId = objvApplicationTypeEN.CharEncodingId;
            //cboCharEncodingId.SelectedValue = strCharEncodingId;
            //string strCondition = string.Format("{0}={1} order by {2}",
            //    clsAppCodeTypeRelaEN.con_ApplicationTypeId, intAppTypeId, clsAppCodeTypeRelaEN.con_OrderNum);
            List<clsvAppCodeTypeRelaENEx> arrObjLst = clsvAppCodeTypeRelaBLEx.GetObjExLstByApplicationTypeIdExCache(intAppTypeId)
                .Where(x => x.ViewTypeCode > 0 )
                .OrderBy(x => x.GroupName).ThenBy(x => x.OrderNum)
                .ToList();

            int intCount = 0;
            //string strGroupName = "";
            IEnumerable<clsvAppCodeTypeRelaENEx> arrObjLst_V2 = arrObjLst.Where(x => x.DependsOn == "View");
            //if (vsvViewRegion != null)
            //{
            //    arrObjLst_V2 = arrObjLst_V2.Where(x => x.RegionTypeId == vsvViewRegion.RegionTypeId).OrderBy(x => x.OrderNum);
            //}
            List<string> arrGroupName = arrObjLst_V2.Select(x => x.GroupName).Distinct().ToList();
            bool bolIsFirst = true;
            Label objLabel = null;
            foreach (string strGroupName in arrGroupName)
            {
                IEnumerable<clsvAppCodeTypeRelaENEx> arrObjLst_Sel =
                    arrObjLst_V2.Where(x => x.GroupName == strGroupName);
                IEnumerable<string> arrCodeTypeId = arrObjLst_Sel.Select(x => x.CodeTypeId);
                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst_Sel1 =
                   arrvFunction4GeneCodeObjLst.Where(x => arrCodeTypeId.Contains(x.FuncCodeTypeId));

                if (arrvFunction4GeneCodeObjLst_Sel1.Count() == 0)
                {
                    continue;
                }
                if (string.IsNullOrEmpty(strGroupName) == false)
                {
                    if (bolIsFirst == false)
                    {
                        Label objLabel_Br = new Label();
                        objLabel_Br.Text = string.Format("<br/>", strGroupName);
                        //objLabel.AutoSize = true;
                        pnlCodeTypeLst.Controls.Add(objLabel_Br);
                    }
                    else
                    {
                        bolIsFirst = false;
                    }
                    objLabel = new Label();
                    objLabel.Text = string.Format("{0}: ", strGroupName);
                    //objLabel.AutoSize = true;
                    objLabel.ID = string.Format("lbl{0}", strGroupName);
                    //string strToolTip = string.Format("���ɣ�[{0}({1})({2})]�Ĵ��롣", objInFor.CodeTypeName, objInFor.CodeTypeId, objInFor.ProgLangTypeId4CodeType);
                    //toolTip1.SetToolTip(objLabel, strToolTip);                    
                    objLabel.CssClass = "text-secondary font-weight-bold";
                    objLabel.Attributes["Style"] = "margin-right:10px;margin-top:35px;left:0px;min-width:150px;";
                    pnlCodeTypeLst.Controls.Add(objLabel);
                }
                foreach (clsvAppCodeTypeRelaENEx objInFor in arrObjLst_V2)
                {
                    if (objInFor.GroupName != strGroupName) continue;
                    List<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst_Sel =
                        arrvFunction4GeneCodeObjLst.Where(x => x.FuncCodeTypeId == objInFor.CodeTypeId).ToList();

                    foreach (clsvFunction4GeneCodeEN objvFunction4GeneCode in arrvFunction4GeneCodeObjLst_Sel)
                    {
                        HtmlInputButton objHtmlInputButton = new HtmlInputButton();
                        objHtmlInputButton.ID = string.Format("btn{0}_{1}", objInFor.CodeTypeId, objvFunction4GeneCode.FuncId4GC);

                        objHtmlInputButton.Name = string.Format("btn{0}_{1}", objInFor.CodeTypeId, objvFunction4GeneCode.FuncId4GC);
                        objHtmlInputButton.Attributes["class"] = "btn btn-outline-primary btn-sm";
                        objHtmlInputButton.Value = string.Format("{0}-{1}({2})",
                            objInFor.CodeTypeName, objvFunction4GeneCode.FuncCHName4Code,
                            objInFor.ProgLangTypeName);

                        objHtmlInputButton.Attributes.Add("onclick", string.Format("GeneCode4Func('{0}','{1}','{2}','{3}')",
                            objInFor.CodeTypeId, clsCommonSession.ViewId, objvFunction4GeneCode.FuncId4GC, intAppTypeId));

                        //objButton.Attributes["Style"] = "margin-right:10px;margin-top:5px;left:0px;";

                        //objButton.Command += new CommandEventHandler(this.btnCodeType_Click);
                        pnlCodeTypeLst.Controls.Add(objHtmlInputButton);
                        intCount++;
                    }
                }

            }
            if (intCount == 0)
            {
                string strMsg = string.Format("Ӧ��:{0}({1})û������[View]��Ӧ�Ĵ�������.(In {2})",
                    objvApplicationTypeEN.ApplicationTypeName, objvApplicationTypeEN.ApplicationTypeId, clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
        }

        [WebMethod]
        public static string GeneCode4Func(string strCodeTypeId, string strTabId, string strFuncId, string strViewId, string strCmPrjId, int intApplicationTypeId)
        {

            if (strCodeTypeId.StartsWith("C"))
            {
                strCodeTypeId = strCodeTypeId.Substring(1);
            }
            //clsPubVar.CurrSelPrjId = "0116";
            //clsPubVar.CurrPrjDataBaseId = "0111";

            clsCodeTypeEN objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(strCodeTypeId);
            //clsPubConst.ClassName cnClassName = clsPubConst.GetClassNameByString(objCodeType.CodeTypeENName);
            ////clsProgLangTypeEN objProgLangType = clsProgLangTypeBL.GetObjByProgLangTypeIdCache(strProgLangTypeId);
            //clsPubConst.LangType ltLangType = clsPubConst.GetLangTypeByString(clsProgLangTypeBL.GetNameByProgLangTypeIdCache(objCodeType.ProgLangTypeId));
            try
            {
                //   string strCharEncodingId = clsPubFun.GetCharEncodingIdByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);

                //string strViewId = "";
                string strRe_ClsName = "";

                string strRe_FileNameWithModuleName = "";

                //string strCodeText1 = AutoGC.GeneCode4Func(strCodeTypeId, strFuncId4GC, clsPubConst.DataBaseType.MsSql, strTabId,
                //    strViewId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, intApplicationTypeId, clsCommonSession.UserId, ref strRe_ClsName,
                //    ref strRe_FileNameWithModuleName);
                //string str
                var Re_objFunction4Code = new clsFunction4CodeEN();
                string strCodeText = AutoGC.GeneCode4Func(strCodeTypeId, strFuncId, clsPubConst.DataBaseType.MsSql, strTabId,
               strViewId, strCmPrjId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, clsCommonSession.UserId, ref strRe_ClsName,
               ref strRe_FileNameWithModuleName, ref Re_objFunction4Code);

                //txtFileName4GenCode.Text = strRe_ClsName;
                //ShowCode(strCodeText);
                clsGCType objGCType = new clsGCType();
                objGCType.Code = strCodeText;
                objGCType.ClsName = strRe_ClsName;
                objGCType.FileName = strRe_FileNameWithModuleName;
                return clsJSON.GetJsonFromObj(objGCType);
                //                return strCodeText;
            }
            catch (Exception objException)
            {
                //lblMsg.Text = objException.Message;
                //clsCommonJsFunc.Alert(this, objException.Message);
                return objException.Message;
                //clsCommonJsFunc.Alert(this, objException.Message);
            }
            //return strCodeText;
        }



        private void ShowData(string strCtrlId)
        {
            //�������裺
            //1�����ؼ����Ƿ�Ϊ�գ�
            //2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
            //3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
            //4����ȡ�������������ԣ�
            //5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���

            //1�����ؼ����Ƿ�Ϊ�գ�
            //if (lngmId == 0) return;        //����ؼ���Ϊ�վͷ����˳�
            //2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��

            //if (clsDGRegionFldsBL.IsExist(lngmId) == false)       //���ùؼ��ֵļ�¼�Ƿ����
            //{
            //    string ss = "�ؼ���Ϊ��" + lngmId + "�Ĳ�����!";
            //    clsCommonJsFunc.Alert(this, ss);
            //    return;
            //}
            //3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
            string strFldName = "";
            string strDataNodeName = "";
            long lngMid = 0;
            string strCondition = "";
            if (strCtrlId.Substring(0, 3) == "dn_")
            {
                string strCtrlId4DataNode = strCtrlId.Substring(3);


                strDataNodeName = clsCtlTypeBLEx.GetFldNameByCtrlId(strCtrlId4DataNode);
                if (string.IsNullOrEmpty(strDataNodeName) == true)
                {
                    string strMsg = string.Format("����[���ؼ�Id:{0}]��ȡ�����(strDataNodeName)���ɹ���", strCtrlId4DataNode);
                    clsCommonJsFunc.Alert(this, strMsg);
                    return;
                }
                if (strCtrlId4DataNode.Substring(0, 3) == "btn") return;

                strCondition = new clsvDGRegionFldsEN()
          //.SetDataNodeName(strDataNodeName, "=")
          .SetRegionId(getRegionId, "=")
          .GetCombineCondition();
                 lngMid = clsvDGRegionFldsBL.GetFirstID_S(strCondition);
            }
            else
            {
                strFldName = clsCtlTypeBLEx.GetFldNameByCtrlId(strCtrlId);
                if (string.IsNullOrEmpty(strFldName) == true)
                {
                    string strMsg = string.Format("����[�ؼ�Id:{0}]��ȡ�ֶ���(FldName)���ɹ���", strCtrlId);
                    throw new Exception(strMsg);
                }
                if (strCtrlId.Substring(0, 3) == "btn") return;
                strCondition = new clsvDGRegionFldsEN()
          .SetFldName(strFldName, "=")
          .SetRegionId(getRegionId, "=")
          .GetCombineCondition();
                lngMid = clsvDGRegionFldsBL.GetFirstID_S(strCondition);
            }

      
            if (lngMid == 0)
            {
                string strMsg = string.Format("��������[{0}]��ȡ�ؼ��ֲ��ɹ���", strCondition);
                throw new Exception(strMsg);
            }
            clsDGRegionFldsEN objDGRegionFlds = new clsDGRegionFldsEN(lngMid);
            //4����ȡ�������������ԣ�
            clsDGRegionFldsBL.GetDGRegionFlds(ref objDGRegionFlds);
            Session.Add("objDGRegionFlds", objDGRegionFlds);
            //5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���
            GetDataFromDGRegionFldsClass(objDGRegionFlds);

        }

        protected void btnSetColNum_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(txtColNum.Text) == true)
            //{
            //    clsCommonJsFunc.Alert(this, "������������");
            //    txtColNum.Focus();
            //}
            //int intColNum = int.Parse(txtColNum.Text);

            if (string.IsNullOrEmpty(txtWidth.Text) == false)
            {
                try
                {
                    int intWidth = int.Parse(txtWidth.Text);
                    clsViewRegionEN objViewRegion = clsViewRegionBL.GetObjByRegionId(getRegionId);
                    if (string.IsNullOrEmpty(txtWidth.Text) == false)
                    {
                        objViewRegion.SetWidth(intWidth)
                                 .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                .SetUpdUser(clsCommonSession.UserId)
                .Update();
                        //clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                    }
                }
                catch (Exception objException)
                {
                    clsPubVar.objLog.WriteDebugLog(objException.Message);

                }
            }
            //clsEditRegionEN obj = clsEditRegionBL.GetObjByRegionId(getRegionId);
            //obj.SetColNum(intColNum)
            //    .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
            //    .SetUpdUser(clsCommonSession.UserId)
            //    .Update();
            try
            {
                wucListRegion4Preview1.ShowControl4Regoin(getRegionId, clsPubVar.CurrSelPrjId, 5, true, clsPubVar.CurrCmPrjId);
                //	3������Gv�ؼ���ĳЩ�в��ɼ���

                //wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.UpdUser, false);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000219)���ӻ���ʾ����������!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
        }
        //protected string vsViewId
        //{
        //    get
        //    {
        //        string sViewId;
        //        sViewId = (string)ViewState["ViewId"];
        //        if (sViewId == null)
        //        {
        //            sViewId = "";
        //        }
        //        return sViewId;
        //    }
        //    set
        //    {
        //        string sViewId = value;
        //        ViewState.Add("ViewId", sViewId);
        //    }
        //}

        protected void btnSetDefaSort_Click(object sender, EventArgs e)
        {
            long lngmId = wucvDGRegionFlds4Gv1.GetFirstCheckedKeyFromGv();
            if (lngmId == 0) return;
            
            lblMsg1.Text = "";
            try
            {
                List<clsDGRegionFldsEN> arrDGRegionFlds = clsDGRegionFldsBLEx.GetObjLstByRegionId4InUseExCache1(getRegionId, clsPubVar.CurrCmPrjId);
                foreach(clsDGRegionFldsEN objInFor in arrDGRegionFlds)
                {
                    if (objInFor.mId == lngmId)
                    {
                        if (objInFor.IsDefaultSort == false)
                        {
                            objInFor.IsDefaultSort = true;
                            objInFor.UpdateRecordEx();
                        }
                    }
                    else
                    {
                        if (objInFor.IsDefaultSort == true)
                        {
                            objInFor.IsDefaultSort = false;
                            objInFor.UpdateRecordEx();
                        }
                    }
                }

                //clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                BindGv_vDGRegionFlds();
            }
            catch (Exception objException)
            {
                string strMsg = objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsg1.Text = strMsg;
            }
        }

        protected void txtClassName_TextChanged(object sender, EventArgs e)
        {

            int intApplicationTypeId = vsApplicationTypeId;
            switch (intApplicationTypeId)
            {
                case (int)enumApplicationType.WinApp_1:
                    txtFileName.Text = txtClassName.Text.Trim().ToString() + ".cs";

                    break;
                case (int)enumApplicationType.WebApp_2:

                    txtFileName.Text = txtClassName.Text.Trim().ToString() + ".aspx";

                    break;
                case (int)enumApplicationType.AndroidApp_5://                        enumApplicationType.AndroidApp_5
                    txtFileName.Text = txtClassName.Text.Trim().ToString() + ".xml";

                    break;
                case (int)enumApplicationType.WebApp_JS_RJ_28://                        enumApplicationType.AndroidApp_5
                    txtFileName.Text = txtClassName.Text.Trim().ToString() + ".html";

                    break;
                case (int)enumApplicationType.SpaAppInCore_TS_18://                        enumApplicationType.AndroidApp_5
                case (int)enumApplicationType.SpaInCoreUT_27://                        enumApplicationType.AndroidApp_5
                    txtFileName.Text = txtClassName.Text.Trim().ToString() + ".cshtml";

                    break;
                case (int)enumApplicationType.VueAppInCore_TS_30://                        enumApplicationType.AndroidApp_5
                    txtFileName.Text = txtClassName.Text.Trim().ToString() + ".vue";

                    break;
                default:
                    string strMsg = string.Format("Ӧ��:{0}�ں�����û�б�����", clsApplicationTypeBL.GetNameByApplicationTypeIdCache(intApplicationTypeId));
                    clsCommonJsFunc.Alert(this, strMsg);
                    break;
            }
            try
            {
                wucListRegion4Preview1.ShowControl4Regoin(getRegionId, clsPubVar.CurrSelPrjId, 5, true, clsPubVar.CurrCmPrjId);
                //	3������Gv�ؼ���ĳЩ�в��ɼ���

                //wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.UpdUser, false);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000219)���ӻ���ʾ����������!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
        }

        protected void btnSetClassName_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClassName.Text) == true)
            {
                clsCommonJsFunc.Alert(this, "������������");
                txtClassName.Focus();
            }
            if (string.IsNullOrEmpty(txtFileName.Text) == true)
            {
                clsCommonJsFunc.Alert(this, "�������ļ�����");
                txtFileName.Focus();
            }
            string strClassName = txtClassName.Text;
            string strFileName = txtFileName.Text;
            try
            {
                clsViewRegionEN obj = clsViewRegionBL.GetObjByRegionId(getRegionId);
                obj.SetClsName(strClassName)
                    //.SetFileName(strFileName)
                    .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                    .SetUpdUser(clsCommonSession.UserId)
                    .Update();
                //clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                //wucViewRegion4Preview1.ShowControl4Regoin(getRegionId, clsPubVar.CurrSelPrjId);
                //	3������Gv�ؼ���ĳЩ�в��ɼ���

                //wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.UpdUser, false);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000219)���ӻ���ʾ����������!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
        }
        /// <summary>
        /// Sql��������Id�� ������01����02:��ͼ��
        /// </summary>
        public int vsApplicationTypeId
        {
            get
            {
                string strApplicationTypeId;
                strApplicationTypeId = (string)ViewState["ApplicationTypeId"];
                if (strApplicationTypeId == null)
                {
                    return 0;
                }
                return int.Parse(strApplicationTypeId);
            }
            set
            {
                string strApplicationTypeId = value.ToString();
                ViewState.Add("ApplicationTypeId", strApplicationTypeId);
            }
        }
        protected string getRegionId
        {
            get
            {
                if (string.IsNullOrEmpty(qsRegionId) == false) return qsRegionId;
                return "";
            }

        }
        private string qsRegionId
        {
            get
            {
                string strRegionId = Request.QueryString["RegionId"] ?? "".ToString();
                if ((strRegionId != null) && (strRegionId != ""))
                {
                    return strRegionId;//Request.QueryString["id"] ?? "";
                }
                else
                {
                    return "";
                }
            }
        }
        /// <summa
    }
}