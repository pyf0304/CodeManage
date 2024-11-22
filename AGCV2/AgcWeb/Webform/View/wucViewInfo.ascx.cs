
namespace AGC.Webform
{
    //using SqlSv;
    using AGC.BusinessLogic;using AGC.FunClass;
    using AGC.BusinessLogicEx;
    using AGC.Entity;
    using com.taishsoft.common;
    using CommFunc4WebForm;
    using System;

    /// <summary>
    ///		wucViewInfo ��ժҪ˵����
    /// </summary>
    public partial class wucViewInfo : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, System.EventArgs e)
        {
            // �ڴ˴������û������Գ�ʼ��ҳ��
            tabHidden.Visible = false;

        }
        public string ViewId
        {
            get
            {
                return txtViewId.Text.Trim();
            }
            set
            {
                txtViewId.Text = value.ToString();
            }
        }

        public string ViewName
        {
            get
            {
                return txtViewName.Text.Trim();
            }
            set
            {
                txtViewName.Text = value.ToString();
            }
        }


        public string KeyId4Test
        {
            get
            {
                return txtKeyId4Test.Text.Trim();
            }
            set
            {
                txtKeyId4Test.Text = value.ToString();
            }
        }

        /// <summary>
        /// ����ĸ��
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string ViewMasterId
        {
            get
            {
                if (ddlViewMasterId.SelectedValue == "0")
                    return "";
                return ddlViewMasterId.SelectedValue;
            }
            set
            {
                if (ddlViewMasterId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlViewMasterId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlViewMasterId.SelectedValue = value;
                    }
                }
            }
        }
        /// <summary>
        /// CM����Id
        /// </summary>
        public string CmPrjId
        {
            get
            {
                if (ddlCmPrjId.SelectedValue == "0")
                    return "";
                return ddlCmPrjId.SelectedValue;
            }
            set
            {
                if (ddlCmPrjId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlCmPrjId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlCmPrjId.SelectedValue = value;
                    }
                }
            }
        }
        public string ViewCnName
        {
            get
            {
                return txtViewCnName.Text.Trim();
            }
            set
            {
                txtViewCnName.Text = value.ToString();
            }
        }
        public int ApplicationTypeId
        {
            get
            {
                if (ddlApplicationTypeId.SelectedValue == "0")
                    return 0;
                return int.Parse( ddlApplicationTypeId.SelectedValue.ToString());
            }
            set
            {
                if (value == 0)
                {
                    ddlApplicationTypeId.SelectedValue = "0";
                }
                else
                {
                    ddlApplicationTypeId.SelectedValue = value.ToString();
                    if (ddlApplicationTypeId.SelectedIndex > 0)
                    {
                        string strApplicationTypeId = ddlApplicationTypeId.SelectedValue;

                        clsViewMasterBLEx.BindDdl_ViewMasterIdCacheEx(ddlViewMasterId, clsPubVar.CurrSelPrjId, int.Parse(strApplicationTypeId));
                        if (string.IsNullOrEmpty(MainTabId) == true) return;
                        switch (strApplicationTypeId)
                        {
                            case "1":
                                SetDefaValueByMainTabId4WinApp(MainTabId);
                                break;
                            case "2":
                                SetDefaValueByMainTabId4WebApp(MainTabId);
                                break;
                            case "5"://                        enumApplicationType.AndroidApp_5
                                SetDefaValueByMainTabId4AndroidApp(MainTabId);
                                break;
                            case "18"://                        enumApplicationType.AndroidApp_5
                                
                                SetDefaValueByMainTabId4Spa(MainTabId);
                                break;

                        }
                    }
                }
            }
        }
        public string ViewGroupId
        {
            get
            {
                if (ddlViewGroupId.SelectedValue == "0")
                    return "";
                return ddlViewGroupId.SelectedValue;
            }
            set
            {
                if (value == "")
                {
                    ddlViewGroupId.SelectedValue = "0";
                }
                else
                {
                    ddlViewGroupId.SelectedValue = value;
                }
            }
        }

        public string FileName
        {
            get
            {
                return txtFileName.Text.Trim();
            }
            set
            {
                txtFileName.Text = value.ToString();
            }
        }

        public string FilePath
        {
            get
            {
                return txtFilePath.Text.Trim();
            }
            set
            {
                txtFilePath.Text = value.ToString();
            }
        }

        public string DefaMenuName
        {
            get
            {
                return txtDefaMenuName.Text.Trim();
            }
            set
            {
                txtDefaMenuName.Text = value.ToString();
            }
        }

        public string FuncModuleAgcId
        {
            get
            {
                if (ddlFuncModuleId.SelectedValue == "0")
                {
                    return "";
                }
                return ddlFuncModuleId.SelectedValue;
            }
            set
            {
                if (value == "")
                {
                    ddlFuncModuleId.SelectedValue = "0";
                }
                else
                {
                    ddlFuncModuleId.SelectedValue = value;
                }
            }
        }

        public string DataBaseName
        {
            get
            {
                return txtDataBaseName.Text.Trim();
            }
            set
            {
                txtDataBaseName.Text = value.ToString();
            }
        }
        public string MainTabId
        {
            get
            {
                if (ddlMainTabId.SelectedValue == "0")
                {
                    return "";
                }
                return ddlMainTabId.SelectedValue;
            }
            set
            {
                if (value == "")
                {
                    ddlMainTabId.SelectedValue = "0";
                }
                else
                {
                    ddlMainTabId.SelectedValue = value;
                    vsMainTabId = value;

                }
            }
        }

        public string DetailTabId
        {
            get
            {
                if (ddlDetailTabId.SelectedValue == "0")
                {
                    return "";
                }
                return ddlDetailTabId.SelectedValue;
            }
            set
            {
                if (value == "")
                {
                    ddlDetailTabId.SelectedValue = "0";
                }
                else
                {
                    ddlDetailTabId.SelectedValue = value;
                }
            }
        }

        public string KeyForMainTab
        {
            get
            {
                return txtKeyForMainTab.Text.Trim();
            }
            set
            {
                txtKeyForMainTab.Text = value.ToString();
            }
        }

        public string KeyForDetailTab
        {
            get
            {
                return txtKeyForDetailTab.Text.Trim();
            }
            set
            {
                txtKeyForDetailTab.Text = value.ToString();
            }
        }

        public bool IsNeedSort
        {
            get
            {
                return chkIsNeedSort.Checked;
            }
            set
            {
                chkIsNeedSort.Checked = value;
            }
        }
        /// <summary>
        /// �Ƿ���Ҫ���õ����ֶ�
        /// </summary>
        public bool IsNeedSetExportFld
        {
            get
            {
                return chkIsNeedSetExportFld.Checked;
            }
            set
            {
                chkIsNeedSetExportFld.Checked = value;
            }
        }
        

        public bool IsNeedTransCode
        {
            get
            {
                return chkIsNeedTransCode.Checked;
            }
            set
            {
                chkIsNeedTransCode.Checked = value;
            }
        }

        public string UserId
        {
            get
            {
                return txtUserId.Text.Trim();
            }
            set
            {
                txtUserId.Text = value.ToString();
            }
        }

        public string PrjId
        {
            get
            {
                return ddlPrjId.SelectedValue;
            }
            set
            {
                if (value == "")
                {
                    ddlPrjId.SelectedValue = "0";
                }
                else
                {
                    ddlPrjId.SelectedValue = value;
                }
            }
        }

        public string ViewFunction
        {
            get
            {
                return txtViewFunction.Text.Trim();
            }
            set
            {
                txtViewFunction.Text = value.ToString();
            }
        }

        public string ViewDetail
        {
            get
            {
                return txtViewDetail.Text.Trim();
            }
            set
            {
                txtViewDetail.Text = value.ToString();
            }
        }

        public string InRelaTabId
        {
            get
            {
                if (ddlInRelaTabId.SelectedValue == "0")
                    return "";
                return ddlInRelaTabId.SelectedValue;
            }
            set
            {
                if (value == "")
                {
                    ddlInRelaTabId.SelectedValue = "0";
                }
                else
                {
                    ddlInRelaTabId.SelectedValue = value;
                }
            }
        }

        public string InSqlDsTypeId
        {
            get
            {
                if (ddlInSqlDsTypeId.SelectedValue == "0")
                    return "";
                return ddlInSqlDsTypeId.SelectedValue;
            }
            set
            {
                if (value == "")
                {
                    ddlInSqlDsTypeId.SelectedValue = "0";
                }
                else
                {
                    ddlInSqlDsTypeId.SelectedValue = value;
                }
                if (ddlInSqlDsTypeId.SelectedIndex != 0)
                {
                    clsDropDownList.BindDdl_RelaTabId(ddlInRelaTabId, ddlInSqlDsTypeId.SelectedValue, PrjId);
                }
            }
        }

        public string OutSqlDsTypeId
        {
            get
            {
                if (ddlOutSqlDsTypeId.SelectedValue == "0")
                    return "";
                return ddlOutSqlDsTypeId.SelectedValue;
            }
            set
            {
                if (value == "")
                {
                    ddlOutSqlDsTypeId.SelectedValue = "0";
                }
                else
                {
                    ddlOutSqlDsTypeId.SelectedValue = value;
                }
                if (ddlOutSqlDsTypeId.SelectedIndex != 0)
                {
                    clsDropDownList.BindDdl_RelaTabId(ddlOutRelaTabId, ddlOutSqlDsTypeId.SelectedValue, PrjId);
                }
            }
        }

        public string OutRelaTabId
        {
            get
            {
                if (ddlOutRelaTabId.SelectedValue == "0")
                    return "";
                return ddlOutRelaTabId.SelectedValue;
            }
            set
            {
                if (value == "")
                {
                    ddlOutRelaTabId.SelectedValue = "0";
                }
                else
                {
                    ddlOutRelaTabId.SelectedValue = value;
                }
            }
        }


        public void SetKeyReadOnly(bool bolReadonly)
        {
            txtViewId.ReadOnly = bolReadonly;
        }
        public void Clear()
        {
            txtViewId.Text = "";
            txtViewName.Text = "";
            
            ddlFuncModuleId.SelectedIndex = 0;
            ddlViewGroupId.SelectedIndex = 0;
            txtDataBaseName.Text = "";
            ddlMainTabId.SelectedIndex = 0;
            ddlDetailTabId.SelectedIndex = 0;
            txtKeyForMainTab.Text = "";
            txtKeyForDetailTab.Text = "";
            chkIsNeedSort.Checked = false;
            chkIsNeedTransCode.Checked = false;
            txtUserId.Text = "";
            ddlPrjId.SelectedIndex = 0;
            txtViewFunction.Text = "";
            txtViewDetail.Text = "";
            ddlApplicationTypeId.SelectedIndex = 0;

        }
        /// <summary>
        /// У���Զ���ؼ������ӿؼ���������ֵ�Ƿ��ǺϷ���ȷ�ġ�
        /// һ�����
        ///		1������У�����ͣ����͡������͡������͵ȣ�
        ///			��Щ�������Զ����ɴ����������
        ///		2��У����ֵ�������ֵ����Сֵ��
        ///			��Щ�������Զ����ɴ����������
        ///		��Щ�������ݿ����޸�
        /// </summary>
        /// <returns></returns>
        public bool IsValid()
        {
            return true;
        }
        /// <summary>
        /// ���øÿؼ��ڲ���״̬�µ�ȱʡֵ
        /// һ�����
        ///		1����������;�Ĭ��Ϊ0��
        ///		2������Ǹ����Ͳ�Ĭ��Ϊ0.0��
        ///		3������������;�Ĭ��Ϊ��ǰ�����ڣ�
        ///		4�������λ(bit)�;�Ĭ��ΪFalse;
        ///		��ЩĬ��ֵ���������޸�
        /// </summary>
        public void SetDefaultValue()
        {
            txtViewId.Text = "";
            txtViewName.Text = "";
            
            ddlFuncModuleId.SelectedIndex = 0;
            ddlViewGroupId.SelectedIndex = 0;
            txtDataBaseName.Text = "";
            ddlMainTabId.SelectedIndex = 0;
            ddlDetailTabId.SelectedIndex = 0;
            txtKeyForMainTab.Text = "";
            txtKeyForDetailTab.Text = "";
            chkIsNeedSort.Checked = false;
            chkIsNeedTransCode.Checked = false;
            txtUserId.Text = "";
            ddlPrjId.SelectedIndex = 0;
            txtViewFunction.Text = "";
            txtViewDetail.Text = "";
            ddlApplicationTypeId.SelectedIndex = 0;

        }
        /// <summary>
        /// ���ܣ���ȡ��ǰ���ڵ��ַ���
        /// ���ڸ�ʽ��
        ///    ���ڵ��ַ����ĸ�ʽ�����֣�
        ///		1��YYYYMMDD��	����20050120
        ///		2��YYYY-MM-DD	����2005-01-20
        ///		3��YYYY/MM/DD	����2005/01/20
        /// </summary>
        /// <param name="intFormat">���ڸ�ʽ������3�֣��������0,1��2
        ///							������ͬ����������ֵ�Ͳ�ͬ��
        ///							�μ���������ڸ�ʽ
        ///	</param>
        /// <returns>���ص�ǰ���ڵ��ַ���</returns>
        public string getTodayStr(int intFormat)
        {
            string strToday;
            string strYear, strMonth, strDay;
            int intYear, intMonth, intDay;
            intYear = System.DateTime.Today.Year;
            intMonth = System.DateTime.Today.Month;
            intDay = System.DateTime.Today.Day;
            strYear = intYear.ToString().Trim();
            if (intMonth > 9) strMonth = intMonth.ToString().Trim();
            else strMonth = "0" + intMonth.ToString().Trim();
            if (intDay > 9) strDay = intDay.ToString().Trim();
            else strDay = "0" + intDay.ToString().Trim();
            strToday = strYear + strMonth + strDay;
            switch (intFormat)
            {
                case 0:
                    strToday = strYear + strMonth + strDay;
                    break;
                case 1:
                    strToday = strYear + "-" + strMonth + "-" + strDay;
                    break;
                case 2:
                    strToday = strYear + "/" + strMonth + "/" + strDay;
                    break;
            }
            return strToday;
        }
        /// <summary>
        /// ���ܣ���ȡ��ǰ�µ��ַ���
        /// �µĸ�ʽ��
        ///    �µ��ַ����ĸ�ʽ�����֣�
        ///		1��YYYYMM��	����200501
        ///		2��YYYY-MM-DD	����2005-01
        ///		3��YYYY/MM/DD	����2005/01
        /// </summary>
        /// <param name="intFormat">�µĸ�ʽ������3�֣��������0,1��2
        ///							������ͬ����������ֵ�Ͳ�ͬ��
        ///							�μ�������µĸ�ʽ
        ///	</param>
        /// <returns>���ص�ǰ�µ��ַ���</returns>
        public string getCurrMonth(int intFormat)
        {
            string strCurrMonth;
            string strYear, strMonth;
            int intYear, intMonth;
            intYear = System.DateTime.Today.Year;
            intMonth = System.DateTime.Today.Month;
            strYear = intYear.ToString().Trim();
            if (intMonth > 9) strMonth = intMonth.ToString().Trim();
            else strMonth = "0" + intMonth.ToString().Trim();
            strCurrMonth = strYear + strMonth;
            switch (intFormat)
            {
                case 0:
                    strCurrMonth = strYear + strMonth;
                    break;
                case 1:
                    strCurrMonth = strYear + "-" + strMonth;
                    break;
                case 2:
                    strCurrMonth = strYear + "/" + strMonth;
                    break;
            }
            return strCurrMonth;
        }
        

 
        public void SetDdl_MainTabId(string strPrjId)
        {
            clsPrjTabBLEx.BindDdl_TabIdExCache(ddlMainTabId, strPrjId);
        }
        public void SetDdl_DetailTabId(string strPrjId)
        {
            clsPrjTabBLEx.BindDdl_TabIdExCache(ddlDetailTabId, strPrjId);
   
        }
        public void SetDdl_ViewGroupId(string strPrjId)
        {
            clsViewGroupBLEx.BindDdl_ViewGroupId(ddlViewGroupId, strPrjId);
        }

        public void SetDdl_PrjId()
        {
          clsProjectsBLEx.BindDdl_PrjIdCacheEx(ddlPrjId);
        }

        protected void txtViewName_TextChanged(object sender, System.EventArgs e)
        {
            int intApplicationTypeId = Convert.ToInt16(ddlApplicationTypeId.SelectedValue);
            switch (intApplicationTypeId)
            {
                case (int)enumApplicationType.WinApp_1:
                    txtFileName.Text = txtViewName.Text.Trim().ToString() + ".cs";
                    
                    break;
                case (int)enumApplicationType.WebApp_2:
                    
                    txtFileName.Text = txtViewName.Text.Trim().ToString() + ".aspx";

                    break;
                case (int)enumApplicationType.AndroidApp_5://                        enumApplicationType.AndroidApp_5
                    txtFileName.Text = txtViewName.Text.Trim().ToString() + ".xml";

                    break;
                case (int)enumApplicationType.WebApp_JS_RJ_28://                        enumApplicationType.AndroidApp_5
                    txtFileName.Text = txtViewName.Text.Trim().ToString() + ".html";

                    break;
                case (int)enumApplicationType.SpaAppInCore_TS_18://                        enumApplicationType.AndroidApp_5
                case (int)enumApplicationType.SpaInCoreUT_27://                        enumApplicationType.AndroidApp_5
                    txtFileName.Text = txtViewName.Text.Trim().ToString() + ".cshtml";

                    break;
                default:
                    string strMsg = string.Format("Ӧ��:{0}�ں�����û�б�����", clsApplicationTypeBL.GetNameByApplicationTypeIdCache(intApplicationTypeId));
                    clsCommonJsFunc.Alert(this, strMsg);
                    break;
            }
      
        }

        protected void txtViewCnName_TextChanged(object sender, System.EventArgs e)
        {
            txtDefaMenuName.Text = txtViewCnName.Text;
            txtViewFunction.Text = txtViewCnName.Text;
        }
        public void SetDdl_FuncModuleId(string strPrjId, string strCurrPrjDataBaseId)
        {
            clsFuncModule_AgcBLEx.BindDdl_FuncModuleId(ddlFuncModuleId, strPrjId, strCurrPrjDataBaseId);
        }
        public void SetDdl_ApplicationTypeId()
        {
            clsApplicationTypeBLEx.BindDdl_ApplicationTypeIdExCache(ddlApplicationTypeId);
        }

        protected void ddlApplicationTypeId_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (ddlApplicationTypeId.SelectedIndex > -1)
            {
                string strApplicationTypeId = ddlApplicationTypeId.SelectedValue;
                try
                {
                    
                    clsViewMasterBLEx.BindDdl_ViewMasterIdCacheEx(ddlViewMasterId, clsPubVar.CurrSelPrjId, int.Parse(strApplicationTypeId));

                    lblMsg4Edit.Text = "�����ޣ�";
                }
                catch(Exception objException)
                {
                    
                    string strMsg = string.Format("�󶨽������ͳ�������:[{0}].({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                    lblMsg4Edit.Text = strMsg;
                    clsCommonJsFunc.Alert(this, strMsg);
                    return;
                }
                if (string.IsNullOrEmpty(MainTabId) == true) return;
                switch(strApplicationTypeId)
                {
                    case "1":
                        SetDefaValueByMainTabId4WinApp(MainTabId);
                        break;
                    case "2":
                        SetDefaValueByMainTabId4WebApp(MainTabId);
                        break;
                    case "5"://                        enumApplicationType.AndroidApp_5
                        SetDefaValueByMainTabId4AndroidApp(MainTabId);
                        break;
                }
            }
        }

        protected void ddlOutSqlDsTypeId_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (ddlOutSqlDsTypeId.SelectedIndex != 0)
            {
                clsDropDownList.BindDdl_RelaTabId(ddlOutRelaTabId, ddlOutSqlDsTypeId.SelectedValue, PrjId);
                
            }
        }

        protected void ddlInSqlDsTypeId_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (ddlInSqlDsTypeId.SelectedIndex != 0)
            {
                clsDropDownList.BindDdl_RelaTabId(ddlInRelaTabId, ddlInSqlDsTypeId.SelectedValue, PrjId);
            }
        }
        public void SetDdl_InSqlDsTypeId()
        {
            clsSQLDSTypeBLEx.BindDdl_SqlDsTypeIdCache(ddlInSqlDsTypeId);
        }
        public void SetDdl_OutSqlDsTypeId()
        {
            clsSQLDSTypeBLEx.BindDdl_SqlDsTypeIdCache(ddlOutSqlDsTypeId);
        }

        protected void ddlMainTabId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtViewName.Text.Trim()) == false)
            {
                return;
            }
            if (ddlMainTabId.SelectedIndex != 0)
            {
                string strMainTabId = ddlMainTabId.SelectedValue;
                SetDefaValueByMainTabId4WebApp(strMainTabId);
       
            }
        }
        public bool SetDefaValueByMainTabId4WebApp(string strTabId)
        {
            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId(strTabId);
            txtViewName.Text = "wfm" + objPrjTabEN.TabName + "_QUDI";
            txtViewCnName.Text = objPrjTabEN.TabCnName + "ά��";
            txtFileName.Text = txtViewName.Text.Trim().ToString() + ".aspx";
            txtDefaMenuName.Text = txtViewCnName.Text;
            txtViewFunction.Text = txtViewCnName.Text;
            //����ģ����
            FuncModuleAgcId = objPrjTabEN.FuncModuleAgcId;
            //���ã���������Դ���� ����������Դ�� 
            InSqlDsTypeId = clsSQLDSTypeBLEx.SQLTAB;
            InRelaTabId = objPrjTabEN.TabId;
            string strRelaViewTabId = clsPrjTabBLEx.GetRelaViewTabIdByTabName(objPrjTabEN.PrjId, objPrjTabEN.TabName);
            if (string.IsNullOrEmpty(strRelaViewTabId) == true)
            {
                OutSqlDsTypeId = clsSQLDSTypeBLEx.SQLTAB;
                OutRelaTabId = objPrjTabEN.TabId;
            }
            else
            {
                OutSqlDsTypeId = clsSQLDSTypeBLEx.SQLVIEW;
                OutRelaTabId = strRelaViewTabId;
            }
            //if (clsPubVar.objCurrSelProject.ApplicationTypeId != 3)
            //{
            //    string strViewGroupId = clsViewGroupBLEx.GetFirstViewGroupId(clsPubVar.CurrSelPrjId);
            //    ViewGroupId = strViewGroupId;
            //}
            //ApplicationTypeId = clsPubVar.objCurrSelProject.ApplicationTypeId;
            
            return true;
        }
        public bool SetDefaValueByMainTabId4WinApp(string strTabId)
        {
            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId(strTabId);
            txtViewName.Text = "frm" + objPrjTabEN.TabName + "_QU_LV";
            txtViewCnName.Text = objPrjTabEN.TabCnName + "ά��";
            txtFileName.Text = txtViewName.Text.Trim().ToString() + ".cs";
            txtDefaMenuName.Text = txtViewCnName.Text;
            txtViewFunction.Text = txtViewCnName.Text;
            //����ģ����
            FuncModuleAgcId = objPrjTabEN.FuncModuleAgcId;
            //���ã���������Դ���� ����������Դ�� 
            InSqlDsTypeId = clsSQLDSTypeBLEx.SQLTAB;
            InRelaTabId = objPrjTabEN.TabId;
            string strRelaViewTabId = clsPrjTabBLEx.GetRelaViewTabIdByTabName(objPrjTabEN.PrjId, objPrjTabEN.TabName);
            if (string.IsNullOrEmpty(strRelaViewTabId) == true)
            {
                OutSqlDsTypeId = clsSQLDSTypeBLEx.SQLTAB;
                OutRelaTabId = objPrjTabEN.TabId;
            }
            else
            {
                OutSqlDsTypeId = clsSQLDSTypeBLEx.SQLVIEW;
                OutRelaTabId = strRelaViewTabId;
            }
            //if (clsPubVar.objCurrSelProject.ApplicationTypeId != 3)
            //{
            //    string strViewGroupId = clsViewGroupBLEx.GetFirstViewGroupId(clsPubVar.CurrSelPrjId);
            //    ViewGroupId = strViewGroupId;
            //}
            txtFilePath.Text = "frm/";
            //ApplicationTypeId = clsPubVar.objCurrSelProject.ApplicationTypeId;
            
            return true;
        }

        public bool SetDefaValueByMainTabId4AndroidApp(string strTabId)
        {
            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId(strTabId);
            txtViewName.Text = "ac_" + objPrjTabEN.TabName + "_QUDI";
            txtViewCnName.Text = objPrjTabEN.TabCnName + "ά��";
            txtFileName.Text = txtViewName.Text.Trim().ToString() + ".xml";
            txtDefaMenuName.Text = txtViewCnName.Text;
            txtViewFunction.Text = txtViewCnName.Text;
            //����ģ����
            FuncModuleAgcId = objPrjTabEN.FuncModuleAgcId;
            //���ã���������Դ���� ����������Դ�� 
            InSqlDsTypeId = clsSQLDSTypeBLEx.SQLTAB;
            InRelaTabId = objPrjTabEN.TabId;
            string strRelaViewTabId = clsPrjTabBLEx.GetRelaViewTabIdByTabName(objPrjTabEN.PrjId, objPrjTabEN.TabName);
            if (string.IsNullOrEmpty(strRelaViewTabId) == true)
            {
                OutSqlDsTypeId = clsSQLDSTypeBLEx.SQLTAB;
                OutRelaTabId = objPrjTabEN.TabId;
            }
            else
            {
                OutSqlDsTypeId = clsSQLDSTypeBLEx.SQLVIEW;
                OutRelaTabId = strRelaViewTabId;
            }
            //if (clsPubVar.objCurrSelProject.ApplicationTypeId != 3)
            //{
            //    string strViewGroupId = clsViewGroupBLEx.GetFirstViewGroupId(clsPubVar.CurrSelPrjId);
            //    ViewGroupId = strViewGroupId;
            //}
            txtFilePath.Text = "src/main/java|res/";
            //  ApplicationTypeId = clsPubVar.objCurrSelProject.ApplicationTypeId;
            
            return true;
        }

        public bool SetDefaValueByMainTabId4Spa(string strTabId)
        {
            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId(strTabId);
            txtViewName.Text = "" + objPrjTabEN.TabName + "CRUD";
            txtViewCnName.Text = objPrjTabEN.TabCnName + "ά��";
            txtFileName.Text = txtViewName.Text.Trim().ToString() + ".html";
            txtDefaMenuName.Text = txtViewCnName.Text;
            txtViewFunction.Text = txtViewCnName.Text;
            //����ģ����
            FuncModuleAgcId = objPrjTabEN.FuncModuleAgcId;
            //���ã���������Դ���� ����������Դ�� 
            InSqlDsTypeId = clsSQLDSTypeBLEx.SQLTAB;
            InRelaTabId = objPrjTabEN.TabId;
            string strRelaViewTabId = clsPrjTabBLEx.GetRelaViewTabIdByTabName(objPrjTabEN.PrjId, objPrjTabEN.TabName);
            if (string.IsNullOrEmpty(strRelaViewTabId) == true)
            {
                OutSqlDsTypeId = clsSQLDSTypeBLEx.SQLTAB;
                OutRelaTabId = objPrjTabEN.TabId;
            }
            else
            {
                OutSqlDsTypeId = clsSQLDSTypeBLEx.SQLVIEW;
                OutRelaTabId = strRelaViewTabId;
            }
            //if (clsPubVar.objCurrSelProject.ApplicationTypeId != 3)
            //{
            //    string strViewGroupId = clsViewGroupBLEx.GetFirstViewGroupId(clsPubVar.CurrSelPrjId);
            //    ViewGroupId = strViewGroupId;
            //}
            txtFilePath.Text = "Views/";
            //  ApplicationTypeId = clsPubVar.objCurrSelProject.ApplicationTypeId;
            
            return true;
        }

        public void HideViewGroup()
        {
            trViewGroup.Visible = false;
        }

        //protected void ddlViewTypeCode_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (ddlViewTypeCode.SelectedIndex <= 0) return;
        //    if (ddlMainTabId.SelectedIndex<=0)
        //    {
        //        clsCommonJsFunc.Alert(this, "��ѡ��һ������");
        //        return;
        //    }
        //    vsMainTabId = ddlMainTabId.SelectedValue.ToString();
        //    clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId(vsMainTabId);

        //    switch ((enumViewTypeCodeTab)ViewTypeCode)
        //    {
        //        case 0:
        //            break;
        //        case enumViewTypeCodeTab.Table_Insert_1:// "0001":	//�������
        //            txtViewName.Text = "wfm" + objPrjTabEN.TabName + "B_I";
        //            txtViewCnName.Text = objPrjTabEN.TabCnName + "-���";
        //            txtFileName.Text = txtViewName.Text.Trim().ToString() + ".aspx";
        //            txtFilePath.Text = "Webform/";
        //            break;
                    
        //        case enumViewTypeCodeTab.Table_Update_2:// "0002":	//�����޸�
        //            txtViewName.Text = "wfm" + objPrjTabEN.TabName + "B_U";
        //            txtViewCnName.Text = objPrjTabEN.TabCnName + "-�޸�";
        //            txtFileName.Text = txtViewName.Text.Trim().ToString() + ".aspx";
        //            txtFilePath.Text = "Webform/";
        //            break;
        //        case enumViewTypeCodeTab.Table_Query_3:// "0003":	//�����ѯ
        //            txtViewName.Text = "wfm" + objPrjTabEN.TabName + "B_Q";
        //            txtViewCnName.Text = objPrjTabEN.TabCnName + "-��ѯ";
        //            txtFileName.Text = txtViewName.Text.Trim().ToString() + ".aspx";
        //            txtFilePath.Text = "Webform/";
        //            break;
        //        case enumViewTypeCodeTab.Table_QUDI_4:// "0004":	//�����QUDI
        //            txtViewName.Text = "wfm" + objPrjTabEN.TabName + "B_QUDI";
        //            txtViewCnName.Text = objPrjTabEN.TabCnName + "-ά��";
        //            txtFileName.Text = txtViewName.Text.Trim().ToString() + ".aspx";
        //            txtFilePath.Text = "Webform/";
        //            break;
        //        case enumViewTypeCodeTab.Table_QI_5:// "0005":	//����Ĳ�ѯ����
        //            txtViewName.Text = "wfm" + objPrjTabEN.TabName + "B_QI";
        //            txtViewCnName.Text = objPrjTabEN.TabCnName + "-��ѯ���";
        //            txtFileName.Text = txtViewName.Text.Trim().ToString() + ".aspx";
        //            break;
        //        case enumViewTypeCodeTab.Table_QU_6:// "0006":	//����Ĳ�ѯ�޸�
        //            txtViewName.Text = "wfm" + objPrjTabEN.TabName + "B_QU";
        //            txtViewCnName.Text = objPrjTabEN.TabCnName + "-��ѯ�޸�";
        //            txtFileName.Text = txtViewName.Text.Trim().ToString() + ".aspx";
        //            break;
        //        case enumViewTypeCodeTab.Table_QD_7:// "0007":	//����Ĳ�ѯɾ��
        //            txtViewName.Text = "wfm" + objPrjTabEN.TabName + "B_QD";
        //            txtViewCnName.Text = objPrjTabEN.TabCnName + "-��ѯɾ��";
        //            txtFileName.Text = txtViewName.Text.Trim().ToString() + ".aspx";
        //            break;
        //        case enumViewTypeCodeTab.Table_UI_9:// "0009":	//������޸Ĳ���
        //            txtViewName.Text = "wfm" + objPrjTabEN.TabName + "B_UI";
        //            txtViewCnName.Text = objPrjTabEN.TabCnName + "-�޸Ĳ���";
        //            txtFileName.Text = txtViewName.Text.Trim().ToString() + ".aspx";
        //            break;
        //        case enumViewTypeCodeTab.Table_QUD_18:// "0018":	//����Ĳ�ѯ�޸�ɾ��
        //            txtViewName.Text = "wfm" + objPrjTabEN.TabName + "B_QUD";
        //            txtViewCnName.Text = objPrjTabEN.TabCnName + "-��ѯ�޸�ɾ��";
        //            txtFileName.Text = txtViewName.Text.Trim().ToString() + ".aspx";
        //            break;
        //        case enumViewTypeCodeTab.Table_QD_InvokeUI_ListView_11:// "0019":	//����Ĳ�ѯɾ��,�����޸ġ����
        //            txtViewName.Text = "frm" + objPrjTabEN.TabName + "_QU_LV";
        //            txtViewCnName.Text = objPrjTabEN.TabCnName + "-ά��";
        //            txtFileName.Text = txtViewName.Text.Trim().ToString() + ".cs";
        //            break;
        //        case enumViewTypeCodeTab.Table_QD_InvokeUI_GridView_20:// "0020":	//����Ĳ�ѯɾ��,�����޸ġ����
        //            txtViewName.Text = "frm" + objPrjTabEN.TabName + "_QU_DGV";
        //            txtViewCnName.Text = objPrjTabEN.TabCnName + "-ά��";
        //            txtFileName.Text = txtViewName.Text.Trim().ToString() + ".cs";
        //            break;
        //        case enumViewTypeCodeTab.Table_List_14:
        //            txtViewName.Text = "wfm" + objPrjTabEN.TabName + "B_Q";
        //            txtViewCnName.Text = objPrjTabEN.TabCnName + "-��ѯ";
        //            txtFileName.Text = txtViewName.Text.Trim().ToString() + ".aspx";
        //            break;
        //        case enumViewTypeCodeTab.Table_QUDI4Android_21:
        //            txtViewName.Text = "ac" + objPrjTabEN.TabName + "_QUDI";
        //            txtViewCnName.Text = objPrjTabEN.TabCnName + "_QUDI";
        //            txtFileName.Text = txtViewName.Text.Trim().ToString() + ".XML";
        //            break;
        //        case enumViewTypeCodeTab.Table_CRUD4Mvc_22:
        //            txtViewName.Text = string.Format("{0}CRUD", objPrjTabEN.TabName );
        //            txtViewCnName.Text = string.Format("{0}CRUD", objPrjTabEN.TabCnName);
        //            txtFileName.Text = txtViewName.Text.Trim().ToString() + ".XML";
        //            break;
        //        case enumViewTypeCodeTab.Table_CRUD4ISO_23:
        //            txtViewName.Text = string.Format("ac{0}CRUD", objPrjTabEN.TabName);
        //            txtViewCnName.Text = string.Format("{0}CRUD", objPrjTabEN.TabCnName);
        //            txtFileName.Text = txtViewName.Text.Trim().ToString() + ".XML";
        //            break;
        //        case enumViewTypeCodeTab.Table_CRUD4Spa_24:
        //        case enumViewTypeCodeTab.Table_CRUD4Spa_UT_30:

        //            txtViewName.Text = string.Format("spa{0}CRUD", objPrjTabEN.TabName);
        //            txtViewCnName.Text = string.Format("{0}CRUD", objPrjTabEN.TabCnName);
        //            txtFileName.Text = txtViewName.Text.Trim().ToString() + ".cshtml";
        //            txtFilePath.Text = "Pages/";
        //            break;
        //        case enumViewTypeCodeTab.Table_CRUD4MvcAjax_25:
        //            txtViewName.Text = string.Format("{0}CRUDAjax", objPrjTabEN.TabName);
        //            txtViewCnName.Text = string.Format("{0}CRUDAjax", objPrjTabEN.TabCnName);
        //            txtFileName.Text = txtViewName.Text.Trim().ToString() + ".XML";
        //            break;
        //        case enumViewTypeCodeTab.Table_CRUD4Node_27:
        //            txtViewName.Text = string.Format("Node{0}CRUD", objPrjTabEN.TabName);
        //            txtViewCnName.Text = string.Format("Node{0}CRUD", objPrjTabEN.TabCnName);
        //            txtFileName.Text = txtViewName.Text.Trim().ToString() + ".XML";
        //            break;
        //        case enumViewTypeCodeTab.Table_CRUD4Relation_28:
        //            txtViewName.Text = string.Format("Relation{0}CRUD", objPrjTabEN.TabName);
        //            txtViewCnName.Text = string.Format("Relation{0}CRUD", objPrjTabEN.TabCnName);
        //            txtFileName.Text = txtViewName.Text.Trim().ToString() + ".XML";
        //            break;
        //        case enumViewTypeCodeTab.Table_CRUD4JsRj_29:
        //            txtViewName.Text = string.Format("spa{0}CRUD", objPrjTabEN.TabName);
        //            txtViewCnName.Text = string.Format("{0}CRUD", objPrjTabEN.TabCnName);
        //            txtFileName.Text = txtViewName.Text.Trim().ToString() + ".html";
        //            txtFilePath.Text = "Views/";
        //            break;
        //        case enumViewTypeCodeTab.Table_CRUD4Vue_31:

        //            txtViewName.Text = string.Format("{0}CRUD", objPrjTabEN.TabName);
        //            txtViewCnName.Text = string.Format("{0}CRUD", objPrjTabEN.TabCnName);
        //            txtFileName.Text = txtViewName.Text.Trim().ToString() + ".vue";
        //            txtFilePath.Text = "views/";
        //            break;
        //        default:
        //            clsViewTypeCodeTabEN objViewTypeCodeTabEN = clsViewTypeCodeTabBL.GetObjByViewTypeCodeCache(ViewTypeCode);
        //            string strMsg = string.Format("�������ͣ�[{0}({1})]�ں���:[{2}]��û�б���������ϵ����Ա��",
        //                objViewTypeCodeTabEN.ViewTypeName,
        //                ViewTypeCode,
        //                clsStackTrace.GetCurrClassFunction());
        //            throw new Exception(strMsg);
        //    }
        //}


        /// <summary>
        /// ��ǰ����������Id
        /// </summary>
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

        /// <summary>
        /// ���ð�����������ֶ�:[ViewMasterId]
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
        /// </summary>
        public void SetDdl_ViewMasterId(int intApplicationTypeId, string strPrjId)
        {
            clsViewMasterBL.BindDdl_ViewMasterId(ddlViewMasterId, intApplicationTypeId, strPrjId);
        }
        public void SetDdl_CmPrjId(string strPrjId)
        {
            clsCMProjectBLEx.BindDdl_CmPrjIdEx(ddlCmPrjId, strPrjId);
        }

        protected void ddlCmPrjId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}