///----------------------
///���ɴ���汾��2012.01.02.1
///�������ڣ�2012/10/07
///�����ߣ����Է�
///�������ƣ�AGC
///����ID��0005
///ģ�����������������
///ģ��Ӣ������RegionManage
///ע�⣺1����Ҫ���ݵײ㣨PubDataBase.dll���İ汾��2011.05.08.1
///       2����Ҫ���������㣨TzPubFunction.dll���İ汾��2011.05.08.1
///========================
///���ɲ�ѯ���޸ģ�ɾ������Ӽ�¼�Ŀ��Ʋ����
using AGC.BusinessLogic;
using AGC.FunClass;
using AGC.BusinessLogicEx;

using AGC.Entity;
using AGC.web.treeview;
using com.taishsoft.common;
using com.taishsoft.datetime;
using com.taishsoft.web.treeview;
using CommFunc4WebForm;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using AutoGCLib;
using Agc;
using AgcCommBase;
using com.taishsoft.json;
using System.Web.UI.HtmlControls;

namespace AGC.Webform
{
    /// <summary>
    /// wfmFeatureRegionFldsB_QUDI ��ժҪ˵��������Q�����ѯ��U�����޸�
    /// </summary>
    public partial class wfmFeatureRegionFldsB_QUDI : CommWebPageBase
    {
        /// <summary>
        /// ����, �����ڽ����ڣ�LimitInInterface
        /// </summary>
        private string qsOperator
        {
            get
            {
                string strOperator = Request.QueryString["Operator"] ?? "".ToString();
                if ((strOperator != null) && (strOperator != ""))
                {
                    return strOperator;//Request.QueryString["id"] ?? "";
                }
                else
                {
                    return "";
                }
            }
        }
        //�����йصı����������
        protected const string ViewId4Potence = "00260203";		//������

        private string seRegionId_Once
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
                        Response.Redirect("./error.aspx");
                        break;
                    case "1":
                        Response.Redirect("./error.aspx");
                        break;
                    case "2":
                        Response.Redirect("./error.aspx");
                        break;
                    case "3":
                        Response.Redirect("./error.aspx");
                        break;
                    case "4":
                        Response.Redirect("./error.aspx");
                        break;
                    case "9":
                        break;
                    default:
                        Response.Redirect("./error.aspx");
                        break;
                }
                //��ʼ��������Ҫ������
                InitViewData();
                //1��Ϊ��������������Դ�����б�����
                wucFeatureRegionFldsB1.SetDdl_CtlTypeId(false);
                wucFeatureRegionFldsB1.SetDdl_ValueGivingModeId();
                wucFeatureRegionFldsB1.SetDdl_ViewImplId();
                wucFeatureRegionFldsB1.HiddenTrTabId();
                wucFeatureRegionFldsB1.SetDdl_FeatureId();
                wucFeatureRegionFldsB1.SetDdl_FieldTypeId();
                wucFeatureRegionFldsB1.SetDdl_KeyIdGetModeId();

                wucFeatureRegionFldsB1.SetDdl_FldId(vsMainTabId);
                wucViewFeatureFlds1.SetDdl_VarId(clsPubVar.CurrSelPrjId);
                //wucFeatureRegionFldsB1.SetDdl_TabFeatureId();
                clsRegionTypeBL.BindDdl_RegionTypeIdCache(ddlRegionTypeId);
                clsValueGivingModeBL.BindDdl_ValueGivingModeIdCache(ddlValueGivingModeId);
                clsCtlTypeBL.BindDdl_CtlTypeIdCache(ddlCtlTypeIdq);
                //clsPrjFeatureBLEx.BindDdl_FeatureIdExByFeatureTypeId(ddlFeatureId, 
                //    new List<string>() { enumPrjFeatureType.FrontInterface_01, enumPrjFeatureType.FrontHiddenInterface_04 });

                clsViewRegionEN objViewRegion = clsViewRegionBL.GetObjByRegionIdCache(vsRegionId, clsPubVar.CurrCmPrjId);
                chkInUse.Checked = objViewRegion.InUseInViewId(clsCommonSession.ViewId, clsPubVar.CurrCmPrjId);
                vsViewId = clsCommonSession.ViewId;
                txtWidth.Text = objViewRegion.Width.ToString();

                wucvFeatureRegionFlds4Gv1.SetSortBy("SeqNum Asc");
                //                strSortFeatureRegionFldsBy = "SeqNum Asc";
                //2����ʾ�������ı�������DATAGRID��
                BindGv_vFeatureRegionFlds();

                //BindTv_ViewFeatureRela();
                //3�����ñ�ؼ����ֿؼ���ReadOnly���ԣ�
                //   ʹֻ֮������Ϊ���޸Ĺ����йؼ����ǲ��ܱ��޸ĵġ�
                DispFeatureRegionFldsListRegion();

                if (qsOperator == "LimitInInterface")
                {
                    tabQuery.Visible = false;
                    trTitle.Visible = false;
                }
            }
            BindBtn_PrjFeature();
            ShowCodeTypeButton();
            try
            {
                //clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(vsMainTabId, clsPubVar.CurrSelPrjId);
                //if (objPrjTab != null)
                //{
                //    wucFeatureRegionButton4Visible1.ShowButton4Regoin(vsRegionId, objPrjTab.TabCnName, clsPubVar.CurrSelPrjId);

                //}
                //else
                //{
                //    wucFeatureRegionButton4Visible1.ShowButton4Regoin(vsRegionId, "����", clsPubVar.CurrSelPrjId);
                //}

                wucFeatureRegionButton4Visible1.ShowButton4View(vsViewId, SelectedRegionTypeLst, clsPubVar.CurrCmPrjId, clsPubVar.CurrSelPrjId);


                //	3������Gv�ؼ���ĳЩ�в��ɼ���

                //wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.UpdUser, false);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000319)���ӻ���ʾ����������!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
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
            wucvFeatureRegionFlds4Gv1.vsPageIndex = 1;
            //�ѱ��¼��������ʾ��DATAGRID��
            BindGv_vFeatureRegionFlds();
        }

        /// <summary>
        /// �������ܣ����Ըùؼ��ֵļ�¼������ʾ�ڽ����ϣ�
        ///������     �������ǰ�ֵ������ؼ���
        /// </summary>
        /// <param name="lngmId">���¼�Ĺؼ��֣���ʾ�ñ�ؼ��ֵ�����</param>
        /// <summary>
        /// �������ܣ��¼�������������<ȷ���޸�>ʱ�������¼�������
        ///           ���幦��Ϊ�ѽ�������ͬ�����ݿ��У��ѽ������ݱ��浽���ݿ���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOKUpd_Click(object sender, System.EventArgs e)
        {
            string strCommandText;
            clsFeatureRegionFldsEN objFeatureRegionFldsEN;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "���":
                    AddFeatureRegionFldsRecord();
                    break;
                case "ȷ�����":
                    //����һ������Ĳ���Ĵ��룬�����߼���̫�򵥣�
                    //�Ͱ��߼���ϲ������Ʋ�,
                    AddFeatureRegionFldsRecordSave();
                    break;
                case "ȷ���޸�":
                    //����һ��������޸ĵĴ��룬�����߼���̫�򵥣�
                    //�Ͱ��߼���ϲ������Ʋ�,
                    objFeatureRegionFldsEN = (clsFeatureRegionFldsEN)Session["objFeatureRegionFldsEN"];
                    UpdateFeatureRegionFldsRecordSave(objFeatureRegionFldsEN);
                    clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                    break;
            }
        }

        ///����¼�¼���¼����̣������ڸù����е���������������Ҫ��������Ӷ��д��롣
        protected void btnAddNewRec4Gv_Click(object sender, System.EventArgs e)
        {
            AddFeatureRegionFldsRecord();
        }

        //����ר�����ڵ���Excel����ش���
        protected void btnExportExcel4Gv_Click(object sender, System.EventArgs e)
        {
            //����Excel����
            ExportExcel();
        }

        /// <summary>
        ///ɾ����ǰ��ѡ��¼
        /// </summary>
        protected void btnDelete4Gv_Click(object sender, System.EventArgs e)
        {
            List<string> lstMId = wucvFeatureRegionFlds4Gv1.GetAllCheckedKeysFromGv();
            if (lstMId == null) return;
            lblMsgList.Text = "";
            try
            {
                foreach (string strViewFeatureId in lstMId)
                {

                    clsFeatureRegionFldsBLEx.DelRecordEx(strViewFeatureId, clsPubVar.CurrSelPrjId);
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_vFeatureRegionFlds();
        }

        /// <summary>
        ///�޸ĵ�ǰ��ѡ��¼
        /// </summary>
        protected void btnUpdate4Gv_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(hidCtrlId.Value) == false)
            {
                lblMsgEdit.Text = "";
                //1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�

                ShowData4CtrlId(hidCtrlId.Value);
                //2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
                clsPubFun.SetButtonEnabled(btnOKUpd, true);
                btnOKUpd.Text = "ȷ���޸�";
                return;
            }


            string strViewFeatureId = wucvFeatureRegionFlds4Gv1.GetFirstCheckedKeyFromGv();
            if (string.IsNullOrEmpty(strViewFeatureId)) return;

            UpdateFeatureRegionFldsRecord(strViewFeatureId);
        }
        protected void gvFeatureRegionFlds_Sorting(object sender, GridViewSortEventArgs e)
        {
            int intIndex;
            //�ж��Ƿ����µ������ֶ�
            intIndex = strSortFeatureRegionFldsBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                strSortFeatureRegionFldsBy = e.SortExpression + " Asc";
                BindGv_vFeatureRegionFlds();
                return;
            }
            //���ԭ��������
            intIndex = strSortFeatureRegionFldsBy.IndexOf(" Asc");
            if (intIndex == -1)		//���ԭ���������������Ϊ����
            {
                strSortFeatureRegionFldsBy = e.SortExpression + " Asc";
            }
            else			///��������Ϊ����
            {
                strSortFeatureRegionFldsBy = e.SortExpression + " Desc";
            }
            BindGv_vFeatureRegionFlds();
        }

        /// <summary>
        /// ���ڼ�¼GridView�еĵ�ǰ������ʽ���Ա������һ�������򣬻��ǽ�������
        /// </summary>
        protected string strSortFeatureRegionFldsBy
        {
            get
            {
                string sSortFeatureRegionFldsBy;
                sSortFeatureRegionFldsBy = (string)ViewState["SortFeatureRegionFldsBy"];
                if (sSortFeatureRegionFldsBy == null)
                {
                    sSortFeatureRegionFldsBy = "";
                }
                return sSortFeatureRegionFldsBy;
            }
            set
            {
                string sSortFeatureRegionFldsBy = value;
                ViewState.Add("SortFeatureRegionFldsBy", sSortFeatureRegionFldsBy);
            }
        }

        ///
        protected void btnCancelFeatureRegionFldsEdit_Click(object sender, EventArgs e)
        {
            DispFeatureRegionFldsListRegion();
        }

        protected void btnCopyFldFromTemplate_Click(object sender, EventArgs e)
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
            var objViewRegion     =  clsViewRegionBLEx.GetObjByRegionIdCacheEx(clsCommonSession.ViewId, enumRegionType.FeatureRegion_0008, clsPubVar.CurrCmPrjId);
            clsFeatureRegionFldsBLEx.ImportRelaFlds(objViewRegion.RegionId, clsPubVar.CurrCmPrjId, UserId);
            clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            BindGv_vFeatureRegionFlds();
            ///�ָ�<ȷ�����>���<���>
            //		lbDispFldList_Click(new object(), new System.EventArgs());
            Response.Write("<script>alert('�������ص������ֶ���Ϣ���Ƴɹ�����')</script>");
        }


        private void SetOperate(string strValue)
        {
            string strJs = string.Format("<script type=\"text/javascript\">strOperate='{0}';</script>", strValue);
            //this.ClientScript.RegisterStartupScript(this.GetType(), "SetOperate", strJs, true);
            litScript.Text = strJs;

        }
        protected void btnSaveSet_Click(object sender, EventArgs e)
        {
            string strRelaFldId = ddlRelaFldId.SelectedValue;
            string strValueGivingModeId = ddlValueGivingModeId.SelectedValue;
            string strDefaValue = txtDefaultValue.Text;
            string strFuncName = txtFuncName.Text;

            //var objFeatureGroup = new Tuple<string, string, string, string, string, string>(vsFeatureId, vsMainTabId, strRelaFldId, strValueGivingModeId, strFuncName, strDefaValue);
            var objFeatureRegionFlds = new clsFeatureRegionFldsEN()
            {
                FeatureId = vsFeatureId,
                ReleTabId = vsMainTabId,
                ReleFldId = strRelaFldId,
                PrjId = clsPubVar.CurrSelPrjId,
                ValueGivingModeId = strValueGivingModeId,
                FuncName = strFuncName,
                DefaultValue = strDefaValue,
                CtlTypeId = enumCtlType.Button_01,
                KeyIdGetModeId = enumGCKeyIdGetMode.ListCheckedRecord_0001
            };

            try
            {
                clsFeatureRegionFldsBLEx.AddFeatureRegionFldsRecordSave(vsRegionId, vsApplicationTypeId, vsMainTabId, objFeatureRegionFlds, clsCommonSession.UserId);

                SetOperate("Finished");
                lblErrMsg.Text = "";
            }
            catch (Exception objException)
            {
                lblErrMsg.Text = objException.Message;
                clsCommonJsFunc.Alert(this, objException.Message);
                SetOperate("Update");

            }
            //wucPrjFeature4Gv1.SetVisible(false);
            BindGv_vFeatureRegionFlds();
            BindTv_ViewFeatureRela();
        }

        protected void btnSetGroupName_Click(object sender, EventArgs e)
        {
            string strGroupName = txtGroupName.Text;
            if (string.IsNullOrEmpty(strGroupName))
            {
                txtGroupName.Focus();
                clsCommonJsFunc.Alert(this, "��������Ϊ�գ�");
                return;
            }
            List<string> lstMId = wucvFeatureRegionFlds4Gv1.GetAllCheckedKeysFromGv();
            if (lstMId == null) return;
            lblMsgList.Text = "";
            try
            {
                foreach (string lngMid in lstMId)
                {
                    K_ViewFeatureId_FeatureRegionFlds objKey = lngMid;

                    clsFeatureRegionFldsEN objInFor = objKey.GetObj().SetGroupName(strGroupName);
                    objInFor.Update();
                }

                BindGv_vFeatureRegionFlds();
            }
            catch (Exception objException)
            {
                string strMsg = objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
            }
        }

        protected void btnGetTabFeature_Click(object sender, EventArgs e)
        {
            try
            {
                List<clsFeatureRegionFldsEN> arrObjLst = clsFeatureRegionFldsBLEx.GetObjLstByViewIdEx(clsCommonSession.ViewId);
                foreach (clsFeatureRegionFldsEN objFeatureRegionFldsEN in arrObjLst)
                {
                    bool bolResult = objFeatureRegionFldsEN.CheckTabFeature(clsCommonSession.UserId);
                }
                BindGv_vFeatureRegionFlds();
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
            }
        }

        //protected void btnCancelAdd_Click(object sender, EventArgs e)
        //{
        //    wucPrjFeature4Gv1.SetVisible(false);
        //    BindGv_vFeatureRegionFlds();
        //    GvShowSet_All();
        //    //BindTv_ViewFeatureRela();
        //}

        protected void btnGeneTabFeature_Click(object sender, EventArgs e)
        {
            List<string> lstMId = wucvFeatureRegionFlds4Gv1.GetAllCheckedKeysFromGv();
            if (lstMId == null) return;
            lblMsgList.Text = "";
            try
            {
                foreach (string strViewFeatureId in lstMId)
                {
                    clsTabFeatureEN objTabFeature = clsFeatureRegionFldsBLEx.CopyToTabFeature(strViewFeatureId,
                        clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                    K_ViewFeatureId_FeatureRegionFlds objKey = strViewFeatureId;
                    objKey.GetObj().CheckTabFeature(clsCommonSession.UserId);
                    //                    clsFeatureRegionFldsBLEx.Ch
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_vFeatureRegionFlds();
        }

        protected void wucFeatureRegionButton4Visible1_selectedIndexChanged(object sender, EventArgs e)
        {
            //var arrRegionTypeLst = wucFeatureRegionButton4Visible1.SelectedRegionTypeLst;

            BindGv_vFeatureRegionFlds();
        }
    }
    public partial class wfmFeatureRegionFldsB_QUDI : CommWebPageBase
    {
        private void ShowData4CtrlId(string strCtrlId)
        {
            //�������裺
            //1�����ؼ����Ƿ�Ϊ�գ�
            //2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
            //3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
            //4����ȡ�������������ԣ�
            //5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���


            //3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
            //string strFldName = clsCtlTypeBLEx.GetFldNameByCtrlId(strCtrlId);
            //if (string.IsNullOrEmpty(strFldName) == true)
            //{
            //    string strMsg = string.Format("����[�ؼ�Id:{0}]��ȡ�ֶ���(FldName)���ɹ���", strCtrlId);
            //    clsCommonJsFunc.Alert(this, strMsg);
            //    return;
            //}

            var arrRegionId = clsViewRegionRelaBLEx.GetRegionIdLstByViewIdCache(vsViewId, clsPubVar.CurrSelPrjId);

            string strCondition = string.Format("{0}='{1}' and {2} in ({3})",
                convFeatureRegionFlds.ButtonName, strCtrlId,
                    convFeatureRegionFlds.RegionId, clsArray.GetSqlInStrByArray(arrRegionId, true));

            string strViewFeatureId = clsvFeatureRegionFldsBL.GetFirstID_S(strCondition);
            if (string.IsNullOrEmpty(strViewFeatureId) == true)
            {
                string strMsg = string.Format("��������[{0}]��ȡ�ؼ��ֲ��ɹ���", strCondition);
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            clsFeatureRegionFldsEN objFeatureRegionFlds = new clsFeatureRegionFldsEN(strViewFeatureId);
            //4����ȡ�������������ԣ�
            clsFeatureRegionFldsBL.GetFeatureRegionFlds(ref objFeatureRegionFlds);
            Session.Add("objFeatureRegionFldsEN", objFeatureRegionFlds);
            //5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���
            GetDataFromFeatureRegionFldsClass(objFeatureRegionFlds);

            clsPrjFeatureEN objPrjFeature = clsPrjFeatureBL.GetObjByFeatureIdCache(objFeatureRegionFlds.FeatureId);
            if (objPrjFeature.IsNeedField == false)
            {
                wucViewFeatureFlds1.Visible = false;
            }
            else
            {
                wucViewFeatureFlds1.Visible = true;
                if (clsViewFeatureFldsBLEx.GetRecNumByViewFeatureIdCache(objFeatureRegionFlds.ViewFeatureId, objFeatureRegionFlds.PrjId) > 0)
                {
                    wucViewFeatureFlds1.SetVisible4ViewFeatureName(false);
                    //1���󶨱༭����������
                    BindDdl4EditRegion();
                    IEnumerable<clsViewFeatureFldsEN> arrViewFeatureFlds = clsViewFeatureFldsBLEx.GetObjLstByViewFeatureIdCache(objFeatureRegionFlds.ViewFeatureId, objFeatureRegionFlds.PrjId);
                    clsViewFeatureFldsEN objViewFeatureFldsEN = arrViewFeatureFlds.First();
                    Session.Add("objViewFeatureFldsEN", objViewFeatureFldsEN);
                    //5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���
                    GetDataFromViewFeatureFldsClass(objViewFeatureFldsEN);

                }
            }
            //DispEditFeatureRegionFldsRegion();
        }



        protected void ShowData(string strViewFeatureId)
        {
            //�������裺
            //1�����ؼ����Ƿ�Ϊ�գ�
            //2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
            //3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
            //4����ȡ�������������ԣ�
            //5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���

            //1�����ؼ����Ƿ�Ϊ�գ�
            if (string.IsNullOrEmpty(strViewFeatureId)) return;		//����ؼ���Ϊ�վͷ����˳�
            //2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
            if (clsFeatureRegionFldsBL.IsExist(strViewFeatureId) == false)		//���ùؼ��ֵļ�¼�Ƿ����
            {
                string ss = "�ؼ���Ϊ��" + strViewFeatureId + "�Ĳ�����!";
                clsCommonJsFunc.Alert(this, ss);
                return;
            }
            //3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
            clsFeatureRegionFldsEN objFeatureRegionFldsEN = new clsFeatureRegionFldsEN(strViewFeatureId);
            //4����ȡ�������������ԣ�
            try
            {
                clsFeatureRegionFldsBL.GetFeatureRegionFlds(ref objFeatureRegionFldsEN);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            Session.Add("objFeatureRegionFldsEN", objFeatureRegionFldsEN);
            //5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���
            GetDataFromFeatureRegionFldsClass(objFeatureRegionFldsEN);
        }

        //����Ȩ�޵ȼ�������
        protected string strPotenceLevel
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



        /// <summary>
        /// ��¼���û�ID�����ڼ���û�Ȩ��
        /// </summary>
        protected string UserId
        {
            get
            {
                string strUserId;
                strUserId = (string)Session["UserId"];
                if (strUserId == null)
                {
                    strUserId = "";
                }
                return strUserId;
            }
            set
            {
                string strUserId = value;
                Session.Add("UserId", strUserId);
            }
        }
        ///protected clsUsersEN objUser
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
        /// �ؼ����ͺ�
        /// </summary>
        protected string CtlTypeId
        {
            get
            {
                string strCtlTypeId;
                strCtlTypeId = (string)Session["CtlTypeId"];
                if (strCtlTypeId == null)
                {
                    strCtlTypeId = "";
                }
                return strCtlTypeId;
            }
            set
            {
                string strCtlTypeId = value;
                Session.Add("CtlTypeId", strCtlTypeId);
            }
        }


        /// <summary>
        /// ר�����ڼ�¼GridView�е�ÿҳ��¼��
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
        /// ������Ϣ��Session���ԣ���Session���ݸ���ʾ����ҳ�棬��ʾ��Ӧ�Ĵ������ݡ�
        /// </summary>
        protected string ErrMessage
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
        /// <summary>
        /// �������Ӵ���Session���ԣ���Session���ڸ��߳���ҳ�棬��һ��ҳ������Ҫ���ص�ҳ�档
        /// </summary>
        protected string BackErrPageLinkStr
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
        protected string CombinevFeatureRegionFldsCondition()
        {
            //ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
            //���� 1=1 && UserName = '����'
            string strWhereCond = " 1=1 ";

            if (qsOperator == "LimitInInterface")
            {
                strWhereCond = string.Format(" 1=1 and RegionId in (Select {0} From {1} Where {2} ='{3}') ", 
                    conViewRegionRela.RegionId, conViewRegionRela._CurrTabName, conViewRegionRela.ViewId, vsViewId);
                //����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
                return strWhereCond;
            }
            //����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
            if (this.txtButtonNameq.Text.Trim() != "")
            {
                strWhereCond += " And ButtonName like '%" + this.txtButtonNameq.Text.Trim() + "%'";
            }
            if (this.txtTextq.Text.Trim() != "")
            {
                strWhereCond += " And Text like '%" + this.txtTextq.Text.Trim() + "%'";
            }
            if (this.ddlCtlTypeIdq.SelectedValue != "" && this.ddlCtlTypeIdq.SelectedValue != "0")
            {
                strWhereCond += " And CtlTypeId='" + this.ddlCtlTypeIdq.SelectedValue + "'";
            }
            if (this.txtCssClassq.Text.Trim() != "")
            {
                strWhereCond += " And CssClass like '%" + this.txtCssClassq.Text.Trim() + "%'";
            }
            return strWhereCond;
        }
        protected void BindGv_vFeatureRegionFlds()
        {
            //��������:(��5��)
            //	1����Ͻ�����������
            //	2�����ÿؼ��еİ�GridView����;
            //	3������Gv�ؼ���ĳЩ�в��ɼ�;

            try
            {
                GvShowSet_All();
                var arrRegionTypeLst = SelectedRegionTypeLst;
                if (arrRegionTypeLst.Count == 0)
                {
                    clsCommonJsFunc.Alert(this, "���ڿ��ӻ�����ѡ����Ҫ��ʾ���������ͣ�");
                    return;
                }
                if (arrRegionTypeLst.Count == 1)
                {
                    wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.RegionName, false);
                }
                //	1����Ͻ�����������
                string strWhereCond = CombinevFeatureRegionFldsCondition();
                strWhereCond += string.Format(" and {0} in ({1})", convFeatureRegionFlds.RegionTypeId, clsArray.GetSqlInStrByArray( arrRegionTypeLst, true));
                //	2�����ÿؼ��еİ�GridView������
                wucvFeatureRegionFlds4Gv1.SetSortBy_Prev(string.Format("{0} desc", convFeatureRegionFlds.InUse));
                wucvFeatureRegionFlds4Gv1.SetSortBy(string.Format("{0}", convFeatureRegionFlds.SeqNum));


                //	2�����ÿؼ��еİ�GridView������
          bool bolResult =       wucvFeatureRegionFlds4Gv1.BindGv_FeatureRegionFlds(strWhereCond);
                if (bolResult == false)
                {
                    return;
                }
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000019)��GridView����!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            try
            {
                //clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(vsMainTabId, clsPubVar.CurrSelPrjId);
                //if (objPrjTab != null)
                //{
                //    wucFeatureRegionButton4Visible1.ShowButton4Regoin(vsRegionId, objPrjTab.TabCnName, clsPubVar.CurrSelPrjId);

                //}
                //else
                //{
                //    wucFeatureRegionButton4Visible1.ShowButton4Regoin(vsRegionId, "����", clsPubVar.CurrSelPrjId);
                //}
                wucFeatureRegionButton4Visible1.ShowButton4View(vsViewId, SelectedRegionTypeLst, clsPubVar.CurrCmPrjId, clsPubVar.CurrSelPrjId);
                //	3������Gv�ؼ���ĳЩ�в��ɼ���

                //wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.UpdUser, false);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000319)���ӻ���ʾ����������!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }

        }
        private void GvShowSet_All()
        {
            wucvFeatureRegionFlds4Gv1.SetGvVisibility_AllShow();
            switch (vsApplicationTypeId)
            {
                case (int)enumApplicationType.WebApp_2:
                case (int)enumApplicationType.WebApp_JS_RJ_28:
                case (int)enumApplicationType.SpaAppInCore_TS_18:

                    wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.ButtonName, true);
                    wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.ButtonName4Mvc, false);
                    wucFeatureRegionFldsB1.SetVisible4ButtonName(true);
                    wucFeatureRegionFldsB1.SetVisible4ButtonName4Mvc(false);

                    break;
                case (int)enumApplicationType.AspMvcAjaxApp_20:
                case (int)enumApplicationType.AspMvcApp_13:


                    wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.ButtonName, false);
                    wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.ButtonName4Mvc, true);
                    wucFeatureRegionFldsB1.SetVisible4ButtonName(false);
                    wucFeatureRegionFldsB1.SetVisible4ButtonName4Mvc(true);
                    break;

            }

            wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.ViewImplName, false);
            wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.KeyWords, false);
            wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.CtlTypeName, false);
            wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.CheckTabFeature, false);
            wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.FuncName, false);
            wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.FieldTypeName, false);
            wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.InUse, false);
            wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.Text, false);
            wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.DefaultValue, false);
            wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.ValueGivingModeName, false);
            wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.TabFeatureName, false);
            wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.GroupName, false);
            wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.ButtonName, false);

            wucvFeatureRegionFlds4Gv1.SetGvVisibility("�ֶ���", false);

            wucvFeatureRegionFlds4Gv1.SetGvVisibility("�޸�", false);
            wucvFeatureRegionFlds4Gv1.SetGvVisibility("ɾ��", false);

        }
        private void GvShowSet_SimBak()
        {
            wucvFeatureRegionFlds4Gv1.SetGvVisibility_AllShow();
            wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.ViewImplName, false);
            wucvFeatureRegionFlds4Gv1.SetGvVisibility("�޸�", false);
            wucvFeatureRegionFlds4Gv1.SetGvVisibility("ɾ��", false);
            wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds_Ttl.FieldTypeName, false);
            wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.FeatureName, true);
            wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.KeyWords, false);
            wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.ButtonName, false);
            wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.Text, false);
            wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.ValueGivingModeName, false);
            wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.FuncName, false);
            wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.DefaultValue, false);
            wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.RelaTabName, false);
            wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.RelaFldName, false);
            wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.CtlTypeName, false);
            wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.CssClass, false);
            wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds_Ttl.FldNum, false);

        }
        ///���ɴ��߼�������ݴ��䵽�����ĺ�������
        /// <summary>
        /// �������ܣ�������������������ʾ��������
        ///ע�⣺��������������򣬲�����һ��������������ϵ�ģ�����Ϊһ��������ֵ��Ȼ����Ϊ����������ֵ
        ///      ������������ݿ�ʱ����Ӧ��һ���ֶ���ǰ�������ֶ��ں�
        /// </summary>
        /// <param name="pobjFeatureRegionFldsEN">��ʵ�������</param>
        protected void GetDataFromFeatureRegionFldsClass(clsFeatureRegionFldsEN pobjFeatureRegionFldsEN)
        {
            wucFeatureRegionFldsB1.SetDdl_TabFeatureId(pobjFeatureRegionFldsEN.ReleTabId, pobjFeatureRegionFldsEN.PrjId);

            wucFeatureRegionFldsB1.RegionId = pobjFeatureRegionFldsEN.RegionId;// ����Id
            wucFeatureRegionFldsB1.DefaultValue = pobjFeatureRegionFldsEN.DefaultValue;// ȱʡֵ
            wucFeatureRegionFldsB1.FieldTypeId = pobjFeatureRegionFldsEN.FieldTypeId;// ����ֶ�Id

            wucFeatureRegionFldsB1.FeatureId = pobjFeatureRegionFldsEN.FeatureId;// ����Id
            wucFeatureRegionFldsB1.KeyIdGetModeId = pobjFeatureRegionFldsEN.KeyIdGetModeId;// ����Id

            wucFeatureRegionFldsB1.GroupName = pobjFeatureRegionFldsEN.GroupName;// ��ť����

            wucFeatureRegionFldsB1.ButtonName = pobjFeatureRegionFldsEN.ButtonName;// ��ť����
            wucFeatureRegionFldsB1.ButtonName4Mvc = pobjFeatureRegionFldsEN.ButtonName4Mvc;// ��ť����
            wucFeatureRegionFldsB1.Text = pobjFeatureRegionFldsEN.Text;// �ı�
            wucFeatureRegionFldsB1.TabId = pobjFeatureRegionFldsEN.ReleTabId;// ��ر�Id
            wucFeatureRegionFldsB1.FldId = pobjFeatureRegionFldsEN.ReleFldId;// ����ֶ�Id
            wucFeatureRegionFldsB1.ValueGivingModeId = pobjFeatureRegionFldsEN.ValueGivingModeId;// ��ֵ��ʽId
            var arrFeatureId = new List<string> { enumPrjFeature.DefaultFeature_0240, enumPrjFeature.SetFieldValue_0148};
            if (arrFeatureId.Contains(pobjFeatureRegionFldsEN.FeatureId))
            {
                if (string.IsNullOrEmpty(pobjFeatureRegionFldsEN.FuncName))
                {
                    wucFeatureRegionFldsB1.FuncName = string.Format("{0}_Click()", pobjFeatureRegionFldsEN.ButtonName);// ������
                }
                else
                {
                    wucFeatureRegionFldsB1.FuncName = pobjFeatureRegionFldsEN.FuncName;// ������
                }
                //if (string.IsNullOrEmpty(pobjFeatureRegionFldsEN.EventFuncName))
                //{
                //    wucFeatureRegionFldsB1.EventFuncName = string.Format("btn_Click('{0}')", pobjFeatureRegionFldsEN.ButtonName.Substring(3));// ������
                //}
                //else
                //{
                //    wucFeatureRegionFldsB1.EventFuncName = pobjFeatureRegionFldsEN.EventFuncName;// ������
                //}
            }
            wucFeatureRegionFldsB1.ViewImplId = pobjFeatureRegionFldsEN.ViewImplId;// ����ʵ��Id
            wucFeatureRegionFldsB1.CtlTypeId = pobjFeatureRegionFldsEN.CtlTypeId;// �ؼ����ͺ�
            wucFeatureRegionFldsB1.CssClass = pobjFeatureRegionFldsEN.CssClass;// ��ʽ��
            wucFeatureRegionFldsB1.ImageUrl = pobjFeatureRegionFldsEN.ImageUrl;// ͼƬ��Դ
            wucFeatureRegionFldsB1.InUse = pobjFeatureRegionFldsEN.InUse;// �Ƿ�����
            //wucFeatureRegionFldsB1.Height = pobjFeatureRegionFldsEN.Height;// �߶�
            wucFeatureRegionFldsB1.Width = pobjFeatureRegionFldsEN.Width ?? 0;// ��
            wucFeatureRegionFldsB1.SeqNum = pobjFeatureRegionFldsEN.SeqNum ?? 0;// �ֶ����

            //wucFeatureRegionFldsB1.Memo = pobjFeatureRegionFldsEN.Memo;// ˵��
            wucFeatureRegionFldsB1.TabFeatureId = pobjFeatureRegionFldsEN.TabFeatureId;// ˵��

            clsPrjFeatureEN objPrjFeature = clsPrjFeatureBL.GetObjByFeatureIdCache(pobjFeatureRegionFldsEN.FeatureId);
            if (objPrjFeature.IsNeedField == false)
            {
                wucFeatureRegionFldsB1.SetVisible4FieldTypeId(false);
                wucFeatureRegionFldsB1.SetVisible4FldId(false);
                //wucFeatureRegionFldsB1.SetVisible4ValueGivingModeId(false);
            }
            else
            {
                wucFeatureRegionFldsB1.SetVisible4FieldTypeId(true);
                wucFeatureRegionFldsB1.SetVisible4FldId(true);
                //wucFeatureRegionFldsB1.SetVisible4ValueGivingModeId(true);
            }
        }

        /// <summary>
        /// �������ܣ��ѽ����ϵ��������ݴ����������
        /// </summary>
        /// <param name="pobjFeatureRegionFldsEN">���ݴ����Ŀ�������</param>
        protected void PutDataToFeatureRegionFldsClass(clsFeatureRegionFldsEN pobjFeatureRegionFldsEN)
        {

            pobjFeatureRegionFldsEN.SetRegionId(wucFeatureRegionFldsB1.RegionId)// ����Id
                .SetGroupName(wucFeatureRegionFldsB1.GroupName)// ��ť����
                .SetFeatureId(wucFeatureRegionFldsB1.FeatureId)
.SetButtonName(wucFeatureRegionFldsB1.ButtonName)// ��ť����
.SetButtonName4Mvc(wucFeatureRegionFldsB1.ButtonName4Mvc)// ��ť����
.SetText(wucFeatureRegionFldsB1.Text)// �ı�
.SetReleTabId(vsMainTabId)// �ı�
.SetReleFldId(wucFeatureRegionFldsB1.FldId)// �ı�
.SetFieldTypeId(wucFeatureRegionFldsB1.FieldTypeId)// �ı�
.SetKeyIdGetModeId(wucFeatureRegionFldsB1.KeyIdGetModeId)// �ı�
.SetFuncName(wucFeatureRegionFldsB1.FuncName)// �ı�
//.SetEventFuncName(wucFeatureRegionFldsB1.EventFuncName)// �ı�
.SetDefaultValue(wucFeatureRegionFldsB1.DefaultValue)// �ı�
.SetValueGivingModeId(wucFeatureRegionFldsB1.ValueGivingModeId)// �ı�

.SetViewImplId(wucFeatureRegionFldsB1.ViewImplId)// ����ʵ��Id
.SetCtlTypeId(wucFeatureRegionFldsB1.CtlTypeId)// �ؼ����ͺ�
.SetCssClass(wucFeatureRegionFldsB1.CssClass)// ��ʽ��
.SetImageUrl(wucFeatureRegionFldsB1.ImageUrl)// ͼƬ��Դ
.SetInUse(wucFeatureRegionFldsB1.InUse)// �Ƿ�����
                                       //.SetHeight(wucFeatureRegionFldsB1.Height)// �߶�
.SetWidth(wucFeatureRegionFldsB1.Width)// ��
.SetSeqNum(wucFeatureRegionFldsB1.SeqNum)// �ֶ����
.SetUpdUser(clsCommonSession.UserId)// �޸���
.SetUpdDate(clsDateTime.getTodayDateTimeStr(1));// �޸�����
//.SetMemo(wucFeatureRegionFldsB1.Memo);// ˵��
            if (string.IsNullOrEmpty(clsCommonSession.UserId) == true)
            {
                pobjFeatureRegionFldsEN.UpdUser = "pyf";//    �޸��û�

            }
            else
            {
                pobjFeatureRegionFldsEN.UpdUser = clsCommonSession.UserId;//    �޸��û�
            }
            //pobjFeatureRegionFldsEN.EventFuncName = pobjFeatureRegionFldsEN.EventFuncName.Replace("''", "'");
            pobjFeatureRegionFldsEN.FuncName = pobjFeatureRegionFldsEN.FuncName.Replace("''", "'");

        }


        ///���ɵĲ����¼׼�����̴���for C#
        protected void AddFeatureRegionFldsRecord()
        {
            btnOKUpd.Text = "ȷ�����";
            btnCancelFeatureRegionFldsEdit.Text = "ȡ�����";

            clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewId(clsCommonSession.ViewId);
            wucFeatureRegionFldsB1.SetDdl_TabFeatureId(objViewInfo.MainTabId, objViewInfo.PrjId); 

            //DispEditFeatureRegionFldsRegion();
        }
        ///�����¼���̹��̴���for C#
        protected bool AddFeatureRegionFldsRecordSave()
        {
            //�������裺
            //1�����ؼ����������������Ƿ���ȷ
            //2��������󲢳�ʼ������
            ///3.1���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
            ///3.2�����Ψһ��
            //4����ֵ�ӽ���㴫���߼��������ʵ���
            //5����鴫��ȥ�Ķ��������Ƿ�Ϸ�
            //6��������ʵ�������ݴ��������ݿ���
            //7��������ļ�¼������ʾ��DATAGRID��
            string strMsg;	//ר�����ڴ�����Ϣ�ı���
            string strResult = " ";	//���ڴ����ڼ����������ʱ���ֵ�ı���
            clsFeatureRegionFldsEN objFeatureRegionFldsEN;
            //1�����ؼ����������������Ƿ���ȷ
            if (!wucFeatureRegionFldsB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "�ؼ��������������Ͳ���ȷ����!";
                return false;
            }
            //2��������󲢳�ʼ������
            //clsFeatureRegionFldsEN objFeatureRegionFldsEN;	//�������
            objFeatureRegionFldsEN = new clsFeatureRegionFldsEN();	//��ʼ���¶���
            ///3.1���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
            //4����ֵ�ӽ���㴫���߼��������ʵ���
            PutDataToFeatureRegionFldsClass(objFeatureRegionFldsEN);		//�ѽ����ֵ����
            //5.1����鴫��ȥ�Ķ��������Ƿ�Ϸ�
            try
            {
                clsFeatureRegionFldsBL.CheckPropertyNew(objFeatureRegionFldsEN);
                //6��������ʵ�������ݴ��������ݿ���
                clsFeatureRegionFldsBL.AddNewRecordBySql2(objFeatureRegionFldsEN);
                clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                objFeatureRegionFldsEN.CheckTabFeature(clsCommonSession.UserId);
            }
            catch (Exception objException)
            {
                strMsg = "��Ӽ�¼���ɹ�!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgEdit.Text = strMsg;
                return false;
            }
            strMsg = "��Ӽ�¼�ɹ�!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsgEdit.Text = "��Ӽ�¼�ɹ�!";
            //7��������ļ�¼������ʾ��DATAGRID��
            BindGv_vFeatureRegionFlds();
            DispFeatureRegionFldsListRegion();
            wucFeatureRegionFldsB1.Clear();		//��տؼ�������
            ///�ָ�<ȷ�����>���<���>
            btnOKUpd.Text = "���";
            btnCancelFeatureRegionFldsEdit.Text = "ȡ���༭";
            return true;
        }
        ///�����¼���̹��̴���for C#
        protected bool AddFeatureRegionFldsRecordSaveV5()
        {
            //�������裺
            //1�����ؼ����������������Ƿ���ȷ
            //2��������󲢳�ʼ������
            //3���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
            //4����ֵ�ӽ���㴫���߼��������ʵ���
            //5����鴫��ȥ�Ķ��������Ƿ�Ϸ�
            //6��������ʵ�������ݴ��������ݿ���
            //7��������ļ�¼������ʾ��DATAGRID��
            string strMsg;	//ר�����ڴ�����Ϣ�ı���
            string strResult = " ";	//���ڴ����ڼ����������ʱ���ֵ�ı���
            clsFeatureRegionFldsEN objFeatureRegionFldsEN;
            //1�����ؼ����������������Ƿ���ȷ
            if (!wucFeatureRegionFldsB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "�ؼ��������������Ͳ���ȷ����!";
                return false;
            }
            //2��������󲢳�ʼ������
            //clsFeatureRegionFldsEN objFeatureRegionFldsEN;	//�������
            objFeatureRegionFldsEN = new clsFeatureRegionFldsEN();	//��ʼ���¶���
            //3���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
            //4����ֵ�ӽ���㴫���߼��������ʵ���
            PutDataToFeatureRegionFldsClass(objFeatureRegionFldsEN);		//�ѽ����ֵ����
            //5.1����鴫��ȥ�Ķ��������Ƿ�Ϸ�
            try
            {
                clsFeatureRegionFldsBL.CheckPropertyNew(objFeatureRegionFldsEN);
                //6��������ʵ�������ݴ��������ݿ���
                clsFeatureRegionFldsBL.AddNewRecordBySql2(objFeatureRegionFldsEN);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "��Ӽ�¼���ɹ�!" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            strMsg = "��Ӽ�¼�ɹ�!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsgEdit.Text = "��Ӽ�¼�ɹ�!";
            //7��������ļ�¼������ʾ��DATAGRID��
            BindGv_vFeatureRegionFlds();
            DispFeatureRegionFldsListRegion();
            wucFeatureRegionFldsB1.Clear();		//��տؼ�������
            ///�ָ�<ȷ�����>���<���>
            btnOKUpd.Text = "���";
            btnCancelFeatureRegionFldsEdit.Text = "ȡ���༭";
            return true;
        }
        ///�����޸ļ�¼׼�����̴��� for C#
        protected void UpdateFeatureRegionFldsRecord(string strViewFeatureId)
        {
            //�������裺���ܹ�2����
            //1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
            //2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�

            //1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
            ShowData(strViewFeatureId);
            //2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
            clsPubFun.SetButtonEnabled(btnOKUpd, true);
            btnOKUpd.Text = "ȷ���޸�";
            btnCancelFeatureRegionFldsEdit.Text = "ȡ���޸�";
            lblMsgEdit.Text = "";
            //DispEditFeatureRegionFldsRegion();
        }
        ///�޸Ĵ���׼�����̴��� for C#
        protected bool UpdateFeatureRegionFldsRecordSave(clsFeatureRegionFldsEN objFeatureRegionFldsEN)
        {
            //�������裺
            //1�����ؼ����������������Ƿ���ȷ
            //2����ֵ�ӽ���㴫���߼��������ʵ���
            ///3.1����鴫��ȥ�Ķ��������Ƿ�Ϸ�
            ///3.2�����Ψһ��
            //4��������ʵ�������ݴ��������ݿ���
            //5�����޸ĺ��������ʾ��DATAGRID��
            string strMsg;	//ר�����ڴ�����Ϣ�ı���
            string strResult = " ";	//���ڴ����ڼ����������ʱ���ֵ�ı���
            //1�����ؼ����������������Ƿ���ȷ
            if (!wucFeatureRegionFldsB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "�ؼ��������������Ͳ���ȷ����!";
                return false;
            }
            //2����ֵ�ӽ���㴫���߼��������ʵ���
            PutDataToFeatureRegionFldsClass(objFeatureRegionFldsEN);		//�ѽ����ֵ����
            ///3.1����鴫��ȥ�Ķ��������Ƿ�Ϸ�
            try
            {
                clsFeatureRegionFldsBL.CheckPropertyNew(objFeatureRegionFldsEN);
                //4��������ʵ�������ݴ��������ݿ���
                clsFeatureRegionFldsBL.UpdateBySql2(objFeatureRegionFldsEN);
                objFeatureRegionFldsEN.CheckTabFeature(clsCommonSession.UserId);
                if (clsViewFeatureFldsBLEx.GetRecNumByViewFeatureIdCache(objFeatureRegionFldsEN.ViewFeatureId, objFeatureRegionFldsEN.PrjId) > 0)
                {
                    clsViewFeatureFldsEN objViewFeatureFldsEN = (clsViewFeatureFldsEN)Session["objViewFeatureFldsEN"];
                    PutDataToViewFeatureFldsClass(objViewFeatureFldsEN);        //�ѽ����ֵ����

                    //3.1����鴫��ȥ�Ķ��������Ƿ�Ϸ�
                    clsViewFeatureFldsBL.CheckPropertyNew(objViewFeatureFldsEN);
                    //4��������ʵ�������ݴ��������ݿ���
                    clsViewFeatureFldsBL.UpdateBySql2(objViewFeatureFldsEN);
                }
            }
            catch (Exception objException)
            {
                strMsg = "�޸ļ�¼���ɹ�!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgEdit.Text = strMsg;
                return false;
            }
            strMsg = "�޸ļ�¼�ɹ�!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsgEdit.Text = "�޸ļ�¼�ɹ�!";
            //5�����޸ĺ��������ʾ��DATAGRID��
            BindGv_vFeatureRegionFlds();
            DispFeatureRegionFldsListRegion();
            wucFeatureRegionFldsB1.Clear();//��տؼ��е�����
            wucViewFeatureFlds1.Clear();//��տؼ��е�����

            //�ָ�<ȷ���޸�>���<���>
            btnOKUpd.Text = "���";
            btnCancelFeatureRegionFldsEdit.Text = "ȡ���༭";
            return true;
        }
        ///�޸Ĵ���׼�����̴��� for C#
        protected bool UpdateFeatureRegionFldsRecordSaveV5(clsFeatureRegionFldsEN objFeatureRegionFldsEN)
        {
            //�������裺
            //1�����ؼ����������������Ƿ���ȷ
            //2����ֵ�ӽ���㴫���߼��������ʵ���
            ///3.1����鴫��ȥ�Ķ��������Ƿ�Ϸ�
            //4��������ʵ�������ݴ��������ݿ���
            //5�����޸ĺ��������ʾ��DATAGRID��
            string strMsg;	//ר�����ڴ�����Ϣ�ı���
            string strResult = " ";	//���ڴ����ڼ����������ʱ���ֵ�ı���
            //1�����ؼ����������������Ƿ���ȷ
            if (!wucFeatureRegionFldsB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "�ؼ��������������Ͳ���ȷ����!";
                return false;
            }
            //2����ֵ�ӽ���㴫���߼��������ʵ���
            PutDataToFeatureRegionFldsClass(objFeatureRegionFldsEN);		//�ѽ����ֵ����
            ///3.1����鴫��ȥ�Ķ��������Ƿ�Ϸ�
            try
            {
                clsFeatureRegionFldsBL.CheckPropertyNew(objFeatureRegionFldsEN);
                //4��������ʵ�������ݴ��������ݿ���
                clsFeatureRegionFldsBL.UpdateBySql2(objFeatureRegionFldsEN);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "�޸ļ�¼���ɹ�!" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            strMsg = "�޸ļ�¼�ɹ�!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsgEdit.Text = "�޸ļ�¼�ɹ�!";
            //5�����޸ĺ��������ʾ��DATAGRID��
            BindGv_vFeatureRegionFlds();
            DispFeatureRegionFldsListRegion();
            wucFeatureRegionFldsB1.Clear();//��տؼ��е�����
            //�ָ�<ȷ���޸�>���<���>
            btnOKUpd.Text = "���";
            btnCancelFeatureRegionFldsEdit.Text = "ȡ���༭";
            return true;
        }
        ///ɾ����¼���̴���for C#
        protected void DeleteFeatureRegionFldsRecord(string strViewFeatureId)
        {
            try
            {
                clsFeatureRegionFldsBL.DelRecord(strViewFeatureId);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_vFeatureRegionFlds();
        }

        ///����ר�����ڵ���Excel����ش���
        private void ExportExcel()
        {
            //	1����Ͻ�����������
            string strWhereCond = CombinevFeatureRegionFldsCondition();
            //	2��������������ȡ�ñ�����������DataTable��
            System.Data.DataTable objDT = null;
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "FeatureRegionFlds��Ϣ����.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add("RegionId"); arrCnName.Add("����Id");
            arrColName.Add("ButtonName"); arrCnName.Add("��ť����");
            arrColName.Add("Text"); arrCnName.Add("�ı�����");
            arrColName.Add("CtlTypeId"); arrCnName.Add("�ؼ����ͺ�");
            arrColName.Add("CtlTypeName"); arrCnName.Add("CtlTypeName");
            arrColName.Add("Height"); arrCnName.Add("�߶�");
            arrColName.Add("Width"); arrCnName.Add("��");
            arrColName.Add("ButtonStyleId"); arrCnName.Add("��ť��ʽId");
            arrColName.Add("ButtonStyleName"); arrCnName.Add("ButtonStyleName");
            arrColName.Add("CssClass"); arrCnName.Add("��ʽ��");
            arrColName.Add("CssClassP"); arrCnName.Add("CssClassP");
            arrColName.Add("ImageUrl"); arrCnName.Add("ͼƬ��Դ");
            arrColName.Add("ViewCnName"); arrCnName.Add("��ͼ������");
            arrColName.Add("CtlCnName"); arrCnName.Add("CtlCnName");
            arrColName.Add("CtlTypeAbbr"); arrCnName.Add("CtlTypeAbbr");
            arrColName.Add("RegionTypeId"); arrCnName.Add("��������Id");
            arrColName.Add("RegionTypeName"); arrCnName.Add("������������");
            arrColName.Add("RegionName"); arrCnName.Add("��������");
            arrColName.Add("RegionFunction"); arrCnName.Add("������");
            arrColName.Add("UserId"); arrCnName.Add("�û�ID");
            arrColName.Add("UpdDate"); arrCnName.Add("�޸�����");
            arrColName.Add("Memo"); arrCnName.Add("˵��");
            arrColName.Add("ViewId"); arrCnName.Add("����ID");
            arrColName.Add("ViewName"); arrCnName.Add("��������");
            arrColName.Add("PrjId"); arrCnName.Add("����ID");
            arrColName.Add("SeqNum"); arrCnName.Add("�ֶ����");
            strFolderName = clsSysParaEN.TempFileFolder;
            strDownLoadFileName = strFolderName + strFileName;
            if (clsPubVar.InitExcelFile(this, strFolderName, strDownLoadFileName) == false)
            {
                return;
            }

            try
            {
                //	2��������������ȡ�ñ�����������DataTable��
                objDT = clsvFeatureRegionFldsBL.GetDataTable(strWhereCond);
                GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4Odbc(objDT, arrColName, arrCnName, strDownLoadFileName);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            clsCommForWebForm.DownLoadFile(strDownLoadFileName);
        }
        private void DispEditFeatureRegionFldsRegionBak()
        {
            tabFeatureRegionFldsGridView.Visible = false;
            //tabEditFeatureRegionFldsRegion.Visible = true;
        }
        private void DispFeatureRegionFldsListRegion()
        {
            tabFeatureRegionFldsGridView.Visible = true;
            //tabEditFeatureRegionFldsRegion.Visible = false;
        }

        protected void btnGoFirstLine_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(vsRegionId )== true)
            {
                clsCommonJsFunc.Alert(this, "������߽�����������ѡ��һ������");
                return;
            }
            string strMsg;
            List<string> arrViewFeatureId = wucvFeatureRegionFlds4Gv1.GetAllCheckedKeysFromGv();
            if (arrViewFeatureId.Count == 0) return;
            try
            {
                clsFeatureRegionFldsBL.GoTop(arrViewFeatureId, vsRegionId);
                clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            }
            catch (Exception objException)
            {
                strMsg = objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                //				clsCommonSession.seErrMessage = objException.Message;
                //				clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;	//"/GenCode/wfmGenViewCode_WebV5.aspx";
                //				clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_vFeatureRegionFlds();
            wucvFeatureRegionFlds4Gv1.SetCheckedItemsForGv(arrViewFeatureId);
        }

        protected void btnGoLastLine_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(vsRegionId )== true)
            {
                clsCommonJsFunc.Alert(this, "������߽�����������ѡ��һ������");
                return;
            }
            string strMsg;
            List<string> arrViewFeatureId = wucvFeatureRegionFlds4Gv1.GetAllCheckedKeysFromGv();
            if (arrViewFeatureId.Count == 0) return;
            try
            {
                clsFeatureRegionFldsBL.GoBottom(arrViewFeatureId, vsRegionId);
                clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            }

            catch (Exception objException)
            {
                strMsg = objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                //				clsCommonSession.seErrMessage = objException.Message;
                //				clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;	//"./GenCode/wfmGenViewCode_WebV5.aspx";
                //				clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_vFeatureRegionFlds();
            wucvFeatureRegionFlds4Gv1.SetCheckedItemsForGv(arrViewFeatureId);
        }
        protected void btnUpMove_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(vsRegionId )== true)
            {
                clsCommonJsFunc.Alert(this, "������߽�����������ѡ��һ������");
                return;
            }
            string strMsg;
            string strViewFeatureId = wucvFeatureRegionFlds4Gv1.GetFirstCheckedKeyFromGv();
            if (string.IsNullOrEmpty(strViewFeatureId)) return;
            try
            {
                clsFeatureRegionFldsBL.AdjustOrderNum("UP", strViewFeatureId, vsRegionId);
                clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            }

            catch (Exception objException)
            {
                strMsg = objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                //				clsCommonSession.seErrMessage = objException.Message;
                //				clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;	//"../GenCode/wfmGenViewCode_WebV5.aspx";
                //				clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_vFeatureRegionFlds();
            wucvFeatureRegionFlds4Gv1.SetCheckedItemForGv(strViewFeatureId);
        }

        protected void btnDownMove_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(vsRegionId )== true)
            {
                clsCommonJsFunc.Alert(this, "������߽�����������ѡ��һ������");
                return;
            }
            string strViewFeatureId = wucvFeatureRegionFlds4Gv1.GetFirstCheckedKeyFromGv();
            if (string.IsNullOrEmpty(strViewFeatureId)) return;
            try
            {
                clsFeatureRegionFldsBL.AdjustOrderNum("DOWN", strViewFeatureId, vsRegionId);
                clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            }
            catch (Exception objException)
            {
                string strMsg = objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                //				clsCommonSession.seErrMessage = objException.Message;
                //				clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;	//"../GenCode/wfmGenViewCode_WebV5.aspx";
                //				clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_vFeatureRegionFlds();
            wucvFeatureRegionFlds4Gv1.SetCheckedItemForGv(strViewFeatureId);

        }

        protected void btnReOrder_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(vsRegionId )== true)
            {
                clsCommonJsFunc.Alert(this, "������߽�����������ѡ��һ������");
                return;
            }
            clsFeatureRegionFldsBLEx.ReOrderEx(vsRegionId);
            clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            BindGv_vFeatureRegionFlds();
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
            List<string> lstMId = wucvFeatureRegionFlds4Gv1.GetAllCheckedKeysFromGv();
            if (lstMId == null) return;
            lblMsgList.Text = "";
            try
            {
                clsFeatureRegionFldsBLEx.SetInUse(lstMId, clsCommonSession.UserId);
                clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                //clsFeatureRegionFldsBLEx.ReOrder(RegionId);
                BindGv_vFeatureRegionFlds();
            }
            catch (Exception objException)
            {
                string strMsg = objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
            }
        }

        protected void btnSetNotInUse_Click(object sender, EventArgs e)
        {
            List<string> lstMId = wucvFeatureRegionFlds4Gv1.GetAllCheckedKeysFromGv();
            if (lstMId == null) return;
            lblMsgList.Text = "";
            try
            {

                clsFeatureRegionFldsBLEx.SetNotInUse(lstMId, clsCommonSession.UserId);
                clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                BindGv_vFeatureRegionFlds();
            }
            catch (Exception objException)
            {
                string strMsg = objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
            }
        }


        //protected void btnBatchAddFeature_Click(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrEmpty(clsCommonSession.ViewId) == true)
        //    {
        //        clsCommonJsFunc.Alert(this, "��ǰ����IdΪ�գ������µ�¼��");
        //        return;
        //    }
        //    //gvFeatureFuncRela.Visible = false
        //    wucPrjFeature4Gv1.SetVisible(true);
        //    wucPrjFeature4Gv1.SetGvVisibility("�޸�", false);
        //    wucPrjFeature4Gv1.SetGvVisibility("ɾ��", false);
        //    wucPrjFeature4Gv1.SetGvVisibility(convPrjFeature.UpdDate, false);
        //    wucPrjFeature4Gv1.SetGvVisibility(convPrjFeature.UpdUser, false);
        //    wucPrjFeature4Gv1.SetGvVisibility(convPrjFeature.FeatureTypeId, false);
        //    wucPrjFeature4Gv1.SetGvVisibility(convPrjFeature.FeatureTypeName, false);
        //    wucPrjFeature4Gv1.SetGvVisibility(convPrjFeature.FeatureDescription, false);
        //    wucPrjFeature4Gv1.SetGvVisibility(convPrjFeature.FunctionGroupId, false);
        //    wucPrjFeature4Gv1.SetGvVisibility(convPrjFeature.FunctionGroupName, false);
        //    wucPrjFeature4Gv1.SetGvVisibility(convPrjFeature.CreateUserId, false);
        //    wucPrjFeature4Gv1.SetGvVisibility(convPrjFeature.KeyWords, false);

        //    wucPrjFeature4Gv1.SetGvVisibility(convPrjFeature.Memo, false);
        //    wucPrjFeature4Gv1.SetSortBy(convPrjFeature.OrderNum);
        //    //wucPrjFeature4Gv1.SetGvVisibility(convPrjFeature.FunctionSignature, false);

        //    string strWhereCond = CombinePrjFeatureCondition();
        //    wucPrjFeature4Gv1.BindGv_PrjFeature(strWhereCond);
        //    GvShowSet_Sim();
        //}
        /// <summary>
        /// �����еĲ�ѯ�ؼ�������ϳ�һ��������
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenCombineCondition)
        /// </summary>
        /// <returns>������(strWhereCond)</returns>
        protected string CombinePrjFeatureCondition()
        {
            //ʹ�������ĳ�ֵΪ"1 = 1",�Ա��ڸô��ĺ�����"and "�����������,
            //���� 1 = 1 && UserName = '����'

            var arrRegionId = clsViewRegionRelaBLEx.GetRegionIdLstByViewIdCache(clsCommonSession.ViewId, clsPubVar.CurrSelPrjId);

            string strWhereCond = string.Format(" 1 = 1 and {0} not in (Select {0} From {1} Where {2} ='{3}') And {4}='{5}' And {6}='1' ",
                convPrjFeature.FeatureId, clsvFeatureRegionFldsEN._CurrTabName,
                convFeatureRegionFlds.RegionId, clsArray.GetSqlInStrByArray(arrRegionId, true),
                conPrjFeature.FeatureTypeId,
                enumPrjFeatureType.FrontInterface_01,
                conPrjFeature.InUse);
            //����������ؼ������ݲ�Ϊ��,�����һ����������ӵ����������С�
            //clsvPrjFeatureEN objvPrjFeatureEN = new clsvPrjFeatureEN();
            //try
            //{

            //    if (this.txtFuncName4Codeq.Text.Trim() != "")
            //    {
            //        objvPrjFeatureEN.FuncName4Code = this.txtFuncName4Codeq.Text.Trim();
            //        strWhereCond += string.Format(" And {0} like '%{1}%'", convPrjFeature.FuncName4Code, this.txtFuncName4Codeq.Text.Trim());
            //    }

            //    clsvPrjFeatureBL.CheckProperty4Condition(objvPrjFeatureEN);
            //}
            //catch (Exception objException)
            //{
            //    string strMsg = string.Format("(errid:WebI000002)����ϲ�ѯ����(CombinePrjFeatureCondition)ʱ����!����ϵ����Ա!" + objException.Message);
            //    throw new Exception(strMsg);
            //}
            return strWhereCond;

        }
        protected void btnConfirmBatchAddFeature_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(clsCommonSession.ViewId) == true)
            {
                clsCommonJsFunc.Alert(this, "��ǰ����IdΪ�գ������µ�¼��");
                return;
            }
            if (ddlRegionTypeId.SelectedIndex <= 0)
            {
                clsCommonJsFunc.Alert(this, "��ѡ����Ҫ�������ͣ�");
                ddlRegionTypeId.Focus();
                return;
            }

            string strRegionTypeId = ddlRegionTypeId.SelectedValue;

            string sstrCtrlId = hidSelCtrlId.Value;
            if (string.IsNullOrEmpty(sstrCtrlId))
            {
                clsCommonJsFunc.Alert(this, "û��ѡ���ܣ����ڹ��������ѡ���ܣ�");
                return;
            }
            List<string> lstFeatureId0 = sstrCtrlId.Split(",".ToCharArray()).ToList();//wucPrjFeature4Gv1.GetAllCheckedKeysFromGv();
            if (lstFeatureId0 == null || lstFeatureId0.Count == 0)
            {
                clsCommonJsFunc.Alert(this, "û��ѡ���ܣ����ڹ��������ѡ���ܣ�");

                return;
            }
            List<string> lstFeatureId = lstFeatureId0.Select(x => x.Substring(3)).ToList();
            lblMsgList.Text = "";
            try
            {
                foreach (string strFeatureId in lstFeatureId)
                {
                    clsPrjFeatureEN objPrjFeature = clsPrjFeatureBL.GetObjByFeatureIdCache(strFeatureId);
                    if (objPrjFeature.FeatureName.Contains("�����ֶ�ֵ") == true)
                    {

                        clsFieldTabBLEx.BindDdl_FldIDByTabIdEx(ddlRelaFldId, clsPubVar.CurrSelPrjId, vsMainTabId);

                        clsCommonJsFunc.RunJs4PageEnd(this, "ShowModal();", "btnConfirmBatchAddFeature_Click");
                        vsFeatureId = strFeatureId;
                        return;
                    }
                    else if (objPrjFeature.IsNeedField == true)
                    {

                        //clsViewFeatureFldsBLEx.ImportRelaFlds(clsCommonSession.ViewId, seRegionId, strFeatureId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);


                    }
                    //var objFeatureGroup = new Tuple<string, string, string, string>(strFeatureId,"","","");
                    var objFeatureRegionFlds = new clsFeatureRegionFldsEN()
                    {
                        ViewFeatureId = clsFeatureRegionFldsBL.GetMaxStrId_S(),
                        FeatureId = strFeatureId,
                        ReleTabId = vsMainTabId,
                        CtlTypeId = enumCtlType.Button_01,
                        PrjId = clsPubVar.CurrSelPrjId
                        //ReleFldId = strRelaFldId,
                        //ValueGivingModeId = strValueGivingModeId,
                        //FuncName = strFuncName,
                        //DefaultValue = strDefaValue
                    };

                    clsFeatureRegionFldsBLEx.AddFeatureRegionFldsRecordSave(vsRegionId, vsApplicationTypeId, vsMainTabId, objFeatureRegionFlds, clsCommonSession.UserId);
                    clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                    //clsViewFeatureFldsBLEx.
                }
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                lblMsgList.Text = objException.Message;
            }
            //wucPrjFeature4Gv1.SetVisible(false);
            BindGv_vFeatureRegionFlds();
            GvShowSet_All();
            BindTv_ViewFeatureRela();
        }
             
        private void BindTv_ViewFeatureRela()
        {
            // wucTreeView1.tmTreeModel = TreeModel.ViewInfo_PrjFeature_Function4Code;
            wucTreeView1.tmTreeModel = TreeModel.ViewInfo_PrjFeature_Function4GeneCode;
            wucTreeView1.ViewId = clsCommonSession.ViewId;
            wucTreeView1.PrjId = clsPubVar.CurrSelPrjId;

            wucTreeView1.BindTv();
            //wucTreeView1.afterSelect_Tz += WucTreeView1_afterSelect_Tz;
            string strKeyId = vsKeyId;
            string strTypeName = vsTreeNodeType;
            //wucTreeView1.ExpandLevel1();
            wucTreeView1.CollapseAll();
            wucTreeView1.Expand(1);

            wucTreeView1.SelectNodeEx(strTypeName, strKeyId);

        }

        private void BindBtn_PrjFeature()
        {
            // wucTreeView4ViewRegion.tmTreeModel = TreeModel.ViewInfo_PrjFeature_Function4Code;
            wucFeatureButtonLst1.ShowFeatureLst(0);
            //wucTreeView4ViewRegion.afterSelect_Tz += WucTreeView1_afterSelect_Tz;
            string strKeyId = vsKeyId;
            string strTypeName = vsTreeNodeType;
        }
        protected string vsTreeNodeType
        {
            get
            {
                string sTreeNodeType;
                sTreeNodeType = (string)ViewState["TreeNodeType"];
                if (sTreeNodeType == null)
                {
                    sTreeNodeType = "";
                }
                return sTreeNodeType;
            }
            set
            {
                string sTreeNodeType = value;
                ViewState.Add("TreeNodeType", sTreeNodeType);
            }
        }
        protected string vsMainTabId
        {
            get
            {
                string sMainTabId;
                sMainTabId = (string)ViewState["MainTabId"];
                if (sMainTabId == null)
                {
                    sMainTabId = "";
                }
                return sMainTabId;
            }
            set
            {
                string sMainTabId = value;
                ViewState.Add("MainTabId", sMainTabId);
            }
        }

        protected string vsViewId
        {
            get
            {
                string sViewId;
                sViewId = (string)ViewState["ViewId"];
                if (sViewId == null)
                {
                    sViewId = "";
                }
                return sViewId;
            }
            set
            {
                string sViewId = value;
                ViewState.Add("ViewId", sViewId);
            }
        }
        
        protected string vsFeatureId
        {
            get
            {
                string sFeatureId;
                sFeatureId = (string)ViewState["FeatureId"];
                if (sFeatureId == null)
                {
                    sFeatureId = "";
                }
                return sFeatureId;
            }
            set
            {
                string sFeatureId = value;
                ViewState.Add("FeatureId", sFeatureId);
            }
        }
        protected string vsKeyId
        {
            get
            {
                string sKeyId;
                sKeyId = (string)ViewState["KeyId"];
                if (sKeyId == null)
                {
                    sKeyId = "";
                }
                return sKeyId;
            }
            set
            {
                string sKeyId = value;
                ViewState.Add("KeyId", sKeyId);
            }
        }

        protected void wucTreeView1_afterSelect_Tz(object sender, clsEventArgs4TreeView e)
        {
            string strKeyId = e.KeyId;
            string strTypeName = e.NodeType;
            string strMsg = string.Format("strKeyId={0}, strTypeName={1}", strKeyId, strTypeName);
            //clsCommonJsFunc.Alert(this, strMsg);
            //string strNeedNodeType =  getNodeTypeString(TreeNodeType.EXAMBATCH);
            wucTreeView1.CollapseAll();
            wucTreeView1.SelectNodeEx(strKeyId);
            string strFeatureId = wucTreeView1.NodeData.FeatureId;//
            string strHtml = string.Format("~/Webform/PrjFunction/wfmFeatureFuncRelaB_QUDI.aspx?FeatureId={0}&ParentPage=../View/wfmViewFeatureRelaB_InMasterPage.aspx",
                strFeatureId);
            Response.Redirect(strHtml);

            //   btnGetCurrNodeRelaValue_Click(null, null);
            //throw new NotImplementedException();
        }

        /// <summary>
        ///�޸ĵ�ǰ��ѡ��¼
        /// (AutoGCLib.WebViewControlCode4CSharp:GenbtnCopyRecord_Click4OneKeyword)
        /// </summary>
        protected void btnCopyRecord_Click(object sender, System.EventArgs e)
        {
            //1����ʾ�ùؼ��ֵ��������û��޸ĸùؼ��ּ�¼��
            string lngmId = wucvFeatureRegionFlds4Gv1.GetFirstCheckedKeyFromGv();
            if (string.IsNullOrEmpty(lngmId)) return;
            CopyRecord(lngmId);
            BindGv_vFeatureRegionFlds();
        }
        /// <summary>
        /// ���Ƽ�¼,�Ѹ����ؼ��ֵļ�¼���ݸ���һ���¼�¼���������ֶ�ֵ��ǰ�����"Copy_"
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_CopyRecord)
        /// </summary>
        protected void CopyRecord(string strViewFeatureId)
        {
            try
            {
                K_ViewFeatureId_FeatureRegionFlds myKey = strViewFeatureId;
                clsFeatureRegionFldsEN objFeatureRegionFldsEN = myKey.GetObj();
                objFeatureRegionFldsEN.ButtonName = "C_" + objFeatureRegionFldsEN.ButtonName;
                objFeatureRegionFldsEN.ButtonName4Mvc = "C_" + objFeatureRegionFldsEN.ButtonName4Mvc;
                objFeatureRegionFldsEN.AddNewRecord();
                string strViewFeatureId_New = objFeatureRegionFldsEN.ViewFeatureId;
                List<clsViewFeatureFldsEN> arrViewFeatureFlds = clsViewFeatureFldsBLEx.GetObjLstByViewFeatureId(strViewFeatureId);
                foreach (clsViewFeatureFldsEN objInFor in arrViewFeatureFlds)
                {
                    objInFor.SetViewFeatureId(strViewFeatureId_New)
                       .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                       .SetUpdUser(clsCommonSession.UserId)
                        .AddNewRecord();
                }
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("�ڿ�¡��¼ʱ��������{0}.(In {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
            }
        }
        /// <summary>
        /// ��ʼ��������Ҫ����
        /// </summary>
        private void InitViewData()
        {
            if (string.IsNullOrEmpty( seRegionId_Once ) == false)
            {
                vsRegionId = seRegionId_Once;
            }
            K_ViewId_ViewInfo objKey = new K_ViewId_ViewInfo(clsCommonSession.ViewId);
            clsViewInfoEN objViewInfoEN = objKey.GetObj();
            vsMainTabId = objViewInfoEN.MainTabId;
            vsApplicationTypeId = objViewInfoEN.ApplicationTypeId;
            wucFeatureRegionFldsB1.vsMainTabId = objViewInfoEN.MainTabId;
        }
        ///
        /// <summary>
        /// �¼�����:��Gv�б�ؼ��У���GeidView�е���ɾ��ʱ�������¼���
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_Wuc4Gv_GvDeleteClick)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void wucvFeatureRegionFlds4Gv1_GvDeleteClick(object sender, clsEventArgs4Delete e)
        {
            string strViewFeatureId = e.KeyId;
            DeleteFeatureRegionFldsRecord(strViewFeatureId);
        }
        ///
        /// <summary>
        /// �¼�����:��Gv�б�ؼ��У���GeidView�е����޸�ʱ�������¼���
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_Wuc4Gv_GvUpdateClick)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void wucvFeatureRegionFlds4Gv1_GvUpdateClick(object sender, clsEventArgs4Update e)
        {
            string strViewFeatureId = e.KeyId;
            UpdateFeatureRegionFldsRecord(strViewFeatureId);
        }

        protected void btnRefreshTv_Click(object sender, EventArgs e)
        {
            BindBtn_PrjFeature();
        }

        protected void wucTreeView4ViewRegion_afterSelect_Tz(object sender, clsEventArgs4TreeView e)
        {
            string strKeyId = e.KeyId;
            string strTypeName = e.NodeType;
            string strMsg = string.Format("strKeyId={0}, strTypeName={1}", strKeyId, strTypeName);
            //wucTreeView4TabFeature.CollapseAll();
            //wucTreeView4ViewRegion.SelectNodeEx(strTypeName, strKeyId);
            //List<string> arrCurrPathNodeKeyIdLst = wucTreeView4ViewRegion.GetCurrPathNodeKeyIdLst();
            //wucTreeView4ViewRegion.SelectNodeEx(arrCurrPathNodeKeyIdLst);

            if (strTypeName == clsViewRegionEN._CurrTabName || strTypeName == clsvViewRegionEN._CurrTabName)
            {
                vsRegionId = strKeyId;
                BindGv_vFeatureRegionFlds();
                return;
            }
        }

        protected void btnDeleteTabFeature_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty( vsRegionId ) == true)
            {
                string strMsg = string.Format("��������ѡ��һ������.(In {0})", clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            try
            {
                //clsTabFeatureBLEx.DelRecordEx(vsRegionId);
                BindBtn_PrjFeature();
                BindGv_vFeatureRegionFlds();
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("��ɾ����¼ʱ��������{0}.(In {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
            }
        }


        protected string vsRegionId
        {
            get
            {
                string sRegionId;
                sRegionId = (string)ViewState["RegionId"];
                if (sRegionId == null)
                {
                    return "";
                }
                return sRegionId;
            }
            set
            {
                string sRegionId = value.ToString();
                ViewState.Add("RegionId", sRegionId);
            }
        }

        protected int vsApplicationTypeId
        {
            get
            {
                string sApplicationTypeId;
                sApplicationTypeId = (string)ViewState["ApplicationTypeId"];
                if (sApplicationTypeId == null)
                {
                    return 0;
                }
                return int.Parse(sApplicationTypeId);
            }
            set
            {
                string sApplicationTypeId = value.ToString();
                ViewState.Add("ApplicationTypeId", sApplicationTypeId);
            }
        }
        /// <summary
        /// 
        private void ShowCodeTypeButton()
        {
            pnlCodeTypeLst.Controls.Clear();
            //clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(clsCommonSession.ViewId, clsPubVar.CurrSelPrjId);
            int intAppTypeId = clsCommonSession.ApplicationTypeId;

            clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(clsCommonSession.ViewId, clsPubVar.CurrSelPrjId);


            List<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                            clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(enumFunctionTemplate.RegionFunctionSet_0004,
                            "",
                            enumRegionType.FeatureRegion_0008)
                            .OrderBy(x => x.OrderNum).ToList();

            //������-������صĺ���

            int intCount4 = arrvFunction4GeneCodeObjLst.Count();

            clsvApplicationTypeEN objvApplicationTypeEN = clsvApplicationTypeBL.GetObjByApplicationTypeIdCache(intAppTypeId);
            string strCharEncodingId = objvApplicationTypeEN.CharEncodingId;
            //cboCharEncodingId.SelectedValue = strCharEncodingId;
            //string strCondition = string.Format("{0}={1} order by {2}",
            //    clsAppCodeTypeRelaEN.con_ApplicationTypeId, intAppTypeId, clsAppCodeTypeRelaEN.con_OrderNum);
            List<clsvAppCodeTypeRelaENEx> arrObjLst = clsvAppCodeTypeRelaBLEx.GetObjExLstByApplicationTypeIdExCache(intAppTypeId)                
                .OrderBy(x => x.GroupName).ThenBy(x => x.OrderNum)
                .ToList();

            int intCount = 0;
            //string strGroupName = "";
            List<clsvAppCodeTypeRelaENEx> arrObjLst_V2 = arrObjLst.Where(x => x.DependsOn == "View").ToList();
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
                List<string> arrCodeTypeId = arrObjLst_Sel.Select(x => x.CodeTypeId).ToList();
                List<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst_Sel1 =
                   arrvFunction4GeneCodeObjLst.Where(x => arrCodeTypeId.Contains(x.FuncCodeTypeId)).ToList();

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

        protected void chkInUse_CheckedChanged(object sender, EventArgs e)
        {

            bool bolInUse = chkInUse.Checked;
            clsViewRegionRelaEN obj = clsViewRegionRelaBLEx.GetObjByViewIdAndRegionIdCache(clsCommonSession.ViewId, vsRegionId, clsPubVar.CurrCmPrjId, clsPubVar.CurrSelPrjId);
            obj.SetInUse(bolInUse)
                .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                .SetUpdUser(clsCommonSession.UserId)
                .Update();
            try
            {
                //clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(vsMainTabId, clsPubVar.CurrSelPrjId);
                //if (objPrjTab != null)
                //{
                //    wucFeatureRegionButton4Visible1.ShowButton4Regoin(vsRegionId, objPrjTab.TabCnName, clsPubVar.CurrSelPrjId);
                //}
                //else
                //{
                //    wucFeatureRegionButton4Visible1.ShowButton4Regoin(vsRegionId, "����", clsPubVar.CurrSelPrjId);
                //}
                wucFeatureRegionButton4Visible1.ShowButton4View(vsViewId, SelectedRegionTypeLst, clsPubVar.CurrCmPrjId, clsPubVar.CurrSelPrjId);
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
        /// �������ܣ��ѽ����ϵ��������ݴ����������
        /// </summary>
        /// <param name="pobjViewFeatureFlds">���ݴ����Ŀ�������</param>
        private void PutDataToViewFeatureFldsClass(clsViewFeatureFldsEN pobjViewFeatureFlds)
        {
            //pobjViewFeatureFlds.ViewFeatureId = vsViewFeatureId;
            pobjViewFeatureFlds.ReleFldId = wucViewFeatureFlds1.FldId;
            pobjViewFeatureFlds.FieldTypeId = wucViewFeatureFlds1.FieldTypeId;

            pobjViewFeatureFlds.LabelCaption = wucViewFeatureFlds1.LabelCaption;

            pobjViewFeatureFlds.CtlTypeId = wucViewFeatureFlds1.CtlTypeId;
            pobjViewFeatureFlds.CtrlId = wucViewFeatureFlds1.CtrlId;
            pobjViewFeatureFlds.VarId = wucViewFeatureFlds1.VarId;

            pobjViewFeatureFlds.OrderNum = wucViewFeatureFlds1.SeqNum;
            pobjViewFeatureFlds.InUse = true;

            pobjViewFeatureFlds.UpdDate = wucViewFeatureFlds1.UpdDate;
            pobjViewFeatureFlds.UpdUser = UserId;
            pobjViewFeatureFlds.Memo = wucViewFeatureFlds1.Memo;
            pobjViewFeatureFlds.DsTabId = wucViewFeatureFlds1.DsTabId;

            pobjViewFeatureFlds.DsCondStr = wucViewFeatureFlds1.DsCondStr;
            pobjViewFeatureFlds.DsSqlStr = wucViewFeatureFlds1.DsSqlStr;
            pobjViewFeatureFlds.ItemsString = wucViewFeatureFlds1.ItemsString;
            if (string.IsNullOrEmpty(pobjViewFeatureFlds.CtrlId) == true) pobjViewFeatureFlds.CtrlId = clsViewFeatureFldsBLEx.GetCtrlId(pobjViewFeatureFlds);
        }
        ///���ɴ��߼�������ݴ��䵽�����ĺ�������
        /// <summary>
        /// �������ܣ�������������������ʾ��������
        ///ע�⣺��������������򣬲�����һ��������������ϵ�ģ�����Ϊһ��������ֵ��Ȼ����Ϊ����������ֵ
        ///      ������������ݿ�ʱ����Ӧ��һ���ֶ���ǰ�������ֶ��ں�
        /// </summary>
        /// <param name="pobjViewFeatureFlds">��ʵ�������</param>
        private void GetDataFromViewFeatureFldsClass(clsViewFeatureFldsEN pobjViewFeatureFlds)
        {
            //vsViewFeatureId = pobjViewFeatureFlds.ViewFeatureId;
            clsvFeatureRegionFldsEN objFeatureRegionFlds = clsvFeatureRegionFldsBL.GetObjByViewFeatureId(pobjViewFeatureFlds.ViewFeatureId);
            wucViewFeatureFlds1.vsViewFeatureId = pobjViewFeatureFlds.ViewFeatureId;
            wucViewFeatureFlds1.ViewFeatureName = string.Format("{0}({1})", objFeatureRegionFlds.FeatureName, objFeatureRegionFlds.RegionName);
            wucViewFeatureFlds1.SetDdl_FldId(objFeatureRegionFlds.ReleTabId);
            wucViewFeatureFlds1.FldId = pobjViewFeatureFlds.ReleFldId;
            wucViewFeatureFlds1.FieldTypeId = pobjViewFeatureFlds.FieldTypeId;


            wucViewFeatureFlds1.LabelCaption = pobjViewFeatureFlds.LabelCaption;

            wucViewFeatureFlds1.CtlTypeId = pobjViewFeatureFlds.CtlTypeId;
            wucViewFeatureFlds1.CtrlId = pobjViewFeatureFlds.CtrlId;
            wucViewFeatureFlds1.VarId = pobjViewFeatureFlds.VarId;

            wucViewFeatureFlds1.SeqNum = pobjViewFeatureFlds.OrderNum ?? 0;
            wucViewFeatureFlds1.Memo = pobjViewFeatureFlds.Memo;

            wucViewFeatureFlds1.DdlItemsOptionId = pobjViewFeatureFlds.DdlItemsOptionId;
            wucViewFeatureFlds1.DsTabId = pobjViewFeatureFlds.DsTabId;

            wucViewFeatureFlds1.DsCondStr = pobjViewFeatureFlds.DsCondStr;
            wucViewFeatureFlds1.DsSqlStr = pobjViewFeatureFlds.DsSqlStr;
            wucViewFeatureFlds1.ItemsString = pobjViewFeatureFlds.ItemsString;

        }

        /// <summary>
        /// ר�����ڼ�¼��ǰ�����Ƿ�󶨱༭����������
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_vsIsBindDdl4Edit)
        /// </summary>
        public bool vsIsBindDdl4Edit
        {
            get
            {
                string strIsBindDdl4Edit;
                strIsBindDdl4Edit = (string)ViewState["IsBindDdl4Edit"];
                if (strIsBindDdl4Edit == null)
                {
                    return false;
                }
                return bool.Parse(strIsBindDdl4Edit);
            }
            set
            {
                string strIsBindDdl4Edit = value.ToString();
                ViewState.Add("IsBindDdl4Edit", strIsBindDdl4Edit);
            }
        }

        /// <summary>
        /// ��������:Ϊ�༭���ؼ���������
        /// (AutoGCLib.WebViewControlCode4CSharp:Gen_WebView_CS_BindDropDownLst4EditRegion)
        /// </summary>
        protected void BindDdl4EditRegion()
        {

            if (vsIsBindDdl4Edit == true) return;
            try
            {
                wucViewFeatureFlds1.SetDdl_FieldTypeId();
                wucViewFeatureFlds1.SetDdl_CtlTypeId(false);
                wucViewFeatureFlds1.SetDdl_DdlItemsOptionId();
                //wucViewFeatureFlds1.SetDdl_DsTabId();
                //wucViewFeatureFlds1.SetDdl_DsDataValueFieldId();
                //wucViewFeatureFlds1.SetDdl_DsDataTextFieldId();
                //wucViewFeatureFlds1.SetDdl_PrjId();
                //wucViewFeatureFlds1.SetDdl_ViewImplId();
                vsIsBindDdl4Edit = true;
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000043)�󶨱༭�����������!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }

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
                    clsViewRegionEN objViewRegion = clsViewRegionBL.GetObjByRegionId(vsRegionId);
                    if (string.IsNullOrEmpty(txtWidth.Text) == false)
                    {
                        objViewRegion.SetWidth(intWidth)
                                 .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                .SetUpdUser(clsCommonSession.UserId)
                .Update();
                        clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                        wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.UpdUser, false);
                    }
                }
                catch (Exception objException)
                {
                    clsPubVar.objLog.WriteDebugLog(objException.Message);
                }
            }
            //clsEditRegionEN obj = clsEditRegionBL.GetObjByRegionId(seRegionId);
            //obj.SetColNum(intColNum)
            //    .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
            //    .SetUpdUser(clsCommonSession.UserId)
            //    .Update();
            try
            {
                wucFeatureRegionButton4Visible1.ShowButton4View(vsViewId, SelectedRegionTypeLst, clsPubVar.CurrCmPrjId, clsPubVar.CurrSelPrjId);
                //	3������Gv�ؼ���ĳЩ�в��ɼ���

            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000219)���ӻ���ʾ����������!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
        }
        protected void cblRegionTypeLst_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (selectedIndexChanged != null)
            //{
            //    selectedIndexChanged(sender, e);
            //}
            BindGv_vFeatureRegionFlds();
        }

        /// <summary>
        /// �õ�CheckBoxList��ѡ���˵�ֵ
        /// </summary>
        /// <param name="checkList">CheckBoxList</param>
        /// <param name="separator">�ָ����</param>
        /// <returns></returns>
        public string GetChecked(CheckBoxList checkList, string separator)
        {
            string selval = "";
            for (int i = 0; i < checkList.Items.Count; i++)
            {
                if (checkList.Items[i].Selected)
                {
                    selval += checkList.Items[i].Value + separator;
                }
            }
            return selval;
        }
        /// <summary>
        /// ��ʼ��CheckBoxList����Щ��ѡ���˵�         /// </summary>
        /// <param name="checkList">CheckBoxList</param>
        /// <param name="selval">ѡ���˵�ֵ�����磺"0,1,1,2,1"</param>
        /// <param name="separator">ֵ����ʹ�õķָ������"0,1,1,2,1"�еĶ���</param>
        public string SetChecked(CheckBoxList checkList, string selval, string separator)
        {
            selval = separator + selval + separator;        //���磺"0,1,1,2,1"->",0,1,1,2,1,"
            for (int i = 0; i < checkList.Items.Count; i++)
            {
                checkList.Items[i].Selected = false;
                string val = separator + checkList.Items[i].Value + separator;
                if (selval.IndexOf(val) != -1)
                {
                    checkList.Items[i].Selected = true;
                    selval = selval.Replace(val, separator);        //Ȼ���ԭ����ֵ����ɾ���Ѿ�ѡ���˵�
                    if (selval == separator)        //selval�����һ��Ҳ��ѡ�еĻ�����ʱ����Replace��ֻ��ʣ��һ���ָ���
                    {
                        selval += separator;        //���һ���ָ���
                    }
                }
            }
            selval = selval.Substring(1, selval.Length - 2);        //��ȥǰ��ӵķָ����
            return selval;
        }
        public List<string> SelectedRegionTypeLst
        {
            get
            {
                var sstrCheckedLst = GetChecked(cblRegionTypeLst, ",");
                var arrRegionTypeLst = sstrCheckedLst.Split(",".ToCharArray()).ToList();
                arrRegionTypeLst = arrRegionTypeLst.Where(x => x != "").ToList();

                return arrRegionTypeLst;
            }
        }
    }
}