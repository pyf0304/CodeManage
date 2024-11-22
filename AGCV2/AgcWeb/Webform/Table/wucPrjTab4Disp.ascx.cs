
namespace AGC.Webform
{
    using System;
    //using SqlSv;

    using AGC.BusinessLogic;
    using AGC.BusinessLogicEx;
    /// <summary>
    ///		wucPrjTab4Disp ��ժҪ˵����
    /// </summary>
    public partial class wucPrjTab4Disp : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, System.EventArgs e)
        {
            // �ڴ˴������û������Գ�ʼ��ҳ��

            ///����Ӧ��Ӧ�����صĿؼ�����
            tabHidden.Visible = false;


        }
        public string TabId
        {
            get
            {
                return txtTabId.Text.Trim();
            }
            set
            {
                txtTabId.Text = value.ToString();
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
        public string Owner
        {
            get
            {
                return txtOwner.Text.Trim();
            }
            set
            {
                txtOwner.Text = value.ToString();
            }
        }
        public string TabName
        {
            get
            {
                return txtTabName.Text.Trim();
            }
            set
            {
                txtTabName.Text = value.ToString();
            }
        }
        public string TabCnName
        {
            get
            {
                return txtTabCnName.Text.Trim();
            }
            set
            {
                txtTabCnName.Text = value.ToString();
            }
        }

        //public string ObjId
        //{
        //    get
        //    {
        //        if (ddlObjId.SelectedValue == "0")
        //        {
        //            return "";
        //        }
        //        return ddlObjId.SelectedValue;
        //    }
        //    set
        //    {
        //        if (value == "")
        //        {
        //            ddlObjId.SelectedValue = "0";
        //        }
        //        else
        //        {
        //            bool bolIsHasValue = false;
        //            for (int i = 0; i < ddlObjId.Items.Count; i++)
        //            {
        //                ListItem liListItem = ddlObjId.Items[i];
        //                if (liListItem.Value == value)
        //                {
        //                    ddlObjId.SelectedIndex = i;
        //                    bolIsHasValue = true;
        //                    break;
        //                }
        //            }
        //            if (bolIsHasValue == false)
        //            {
        //                ddlObjId.SelectedValue = "0";
        //            }
        //            //ddlObjId.SelectedValue = value;
        //        }
        //    }
        //}
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
                    try
                    {
                        ddlFuncModuleId.SelectedValue = value;
                    }
                    catch(Exception objException)
                    {
                        string ss = objException.Message;
                    }
                    //if (ddlFuncModuleId.SelectedIndex > 0)
                    //{
                    //    string strFuncModuleId = ddlFuncModuleId.SelectedValue;
                    //    clsvPrjObjects4DdlBLEx.BindDdl_ObjId(ddlObjId, clsPubVar.CurrSelPrjId, strFuncModuleId);
                    //}
                }
            }
        }

        public string CacheClassifyField
        {
            get
            {
                if (ddlCacheClassifyField.SelectedValue == "0")
                {
                    return "";
                }
                return ddlCacheClassifyField.SelectedValue;
            }
            set
            {
                if (value == "")
                {
                    ddlCacheClassifyField.SelectedValue = "0";
                }
                else
                {
                    try
                    {
                        ddlCacheClassifyField.SelectedValue = value;
                    }
                    catch (Exception objException)
                    {
                        string ss = objException.Message;
                    }
                    //if (ddlCacheClassifyField.SelectedIndex > 0)
                    //{
                    //    string strFuncModuleId = ddlCacheClassifyField.SelectedValue;
                    //    clsvPrjObjects4DdlBLEx.BindDdl_ObjId(ddlObjId, clsPubVar.CurrSelPrjId, strFuncModuleId);
                    //}
                }
            }
        }


        public string ParentClass
        {
            get
            {
                return txtParentClass.Text.Trim();
            }
            set
            {
                txtParentClass.Text = value.ToString();
            }
        }

        public string Memo
        {
            get
            {
                return txtMemo.Text.Trim();
            }
            set
            {
                txtMemo.Text = value.ToString();
            }
        }

        public bool IsNationStandard
        {
            get
            {
                return chkIsNationStandard.Checked;
            }
            set
            {
                chkIsNationStandard.Checked = value;
            }
        }

        /// <summary>
        /// ���̱��Ƿ�
        /// </summary>
        public bool IsReleToSqlTab
        {
            get
            {
                return chkIsReleToSqlTab.Checked;
            }
            set
            {
                chkIsReleToSqlTab.Checked = value;
            }
        }

        /// <summary>
        /// �Ƿ�֧��Cache?
        /// </summary>
        public bool IsUseCache
        {
            get
            {
                return chkIsUseCache.Checked;
            }
            set
            {
                chkIsUseCache.Checked = value;
            }
        }
        //public bool IsNeedGeneIndexer
        //{
        //    get
        //    {
        //        return chkIsNeedGeneIndexer.Checked;
        //    }
        //    set
        //    {
        //        chkIsNeedGeneIndexer.Checked = value;
        //    }
        //}
        public string TabNameB
        {
            get
            {
                return txtTabNameB.Text.Trim();
            }
            set
            {
                txtTabNameB.Text = value.ToString();
            }
        }

        public bool IsArchive
        {
            get
            {
                return chkIsArchive.Checked;
            }
            set
            {
                chkIsArchive.Checked = value;
            }
        }

        public bool IsChecked
        {
            get
            {
                return chkIsChecked.Checked;
            }
            set
            {
                chkIsChecked.Checked = value;
            }
        }

        public string TabStateId
        {
            get
            {
                if (ddlTabStateId.SelectedValue == "0")
                    return "";
                return ddlTabStateId.SelectedValue;
            }
            set
            {
                if (value == "")
                {
                    ddlTabStateId.SelectedValue = "0";
                }
                else
                {
                    ddlTabStateId.SelectedValue = value;
                }
            }
        }
        /// <summary>
        /// ������Id
        /// </summary>
        public string TabTypeId
        {
            get
            {
                if (ddlTabTypeId.SelectedValue == "0")
                    return "";
                return ddlTabTypeId.SelectedValue;
            }
            set
            {
                if (value == "")
                {
                    ddlTabTypeId.SelectedValue = "0";
                }
                else
                {
                    ddlTabTypeId.SelectedValue = value;
                }
            }
        }
        public string SqlDsTypeId
        {
            get
            {
                return ddlSqlDsTypeId.SelectedValue;
            }
            set
            {
                if (value == "")
                {
                    ddlSqlDsTypeId.SelectedValue = "0";
                }
                else
                {
                    ddlSqlDsTypeId.SelectedValue = value;
                    if (value == "02")//���SQL���������ǡ���ͼ��
                    {
                        ShowRelaTab4View();
                    }
                    else
                    {
                        HideRelaTab4View();
                    }

                }
            }
        }
      
        public string RelaTabId4View
        {
            get
            {
                return ddlRelaTabId4View.SelectedValue;
            }
            set
            {
                if (value == "")
                {
                    ddlRelaTabId4View.SelectedValue = "0";
                }
                else
                {
                    try
                    {
                        ddlRelaTabId4View.SelectedValue = value;
                    }
                    catch(Exception objException)
                    {
                        string strSS = objException.Message;
                    }
                }
            }
        }

        public void SetKeyReadOnly(bool bolReadonly)
        {
            txtTabId.ReadOnly = bolReadonly;
        }
        public void Clear()
        {
            txtTabId.Text = "";
            txtDataBaseName.Text = "";
            txtTabName.Text = "";
            txtTabCnName.Text = "";
            ddlFuncModuleId.SelectedIndex = 0;
            //ddlObjId.SelectedIndex = 0;
            txtMemo.Text = "";
            chkIsArchive.Checked = false;
            chkIsChecked.Checked = false;
            ddlTabStateId.SelectedIndex = 0;
            chkIsNationStandard.Checked = false;
            txtTabNameB.Text = "";

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
            txtTabId.Text = "";
            txtDataBaseName.Text = "";
            txtTabName.Text = "";
            txtTabCnName.Text = "";
            ddlFuncModuleId.SelectedIndex = 0;
            //ddlObjId.SelectedIndex = 0;
            txtMemo.Text = "";
            chkIsArchive.Checked = false;
            chkIsChecked.Checked = false;
            ddlTabStateId.SelectedIndex = 0;
            chkIsNationStandard.Checked = false;
            txtTabNameB.Text = "";

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
        

        //public void SetDdl_ObjId(string strPrjId)
        //{
        //    clsvPrjObjects4DdlBLEx.BindDdl_ObjId(ddlObjId, strPrjId);
        //}
        public void SetDdl_TabStateIdCache()
        {
            clsTabStateBL.BindDdl_TabStateIdCache(ddlTabStateId);
        }
        public void SetDdl_SqlDsTypeIdCache()
        {
            clsSQLDSTypeBL.BindDdl_SqlDsTypeIdCache(ddlSqlDsTypeId);
        }

        public void SetDdl_TabTypeIdCache()
        {
            clsTabTypeBL.BindDdl_TabTypeIdCache(ddlTabTypeId);
        }
        public void SetDdl_FuncModuleId(string strPrjId, string strCurrPrjDataBaseId)
        {
            clsFuncModule_AgcBLEx.BindDdl_FuncModuleId(ddlFuncModuleId, strPrjId, strCurrPrjDataBaseId);
        }

        public void SetDdl_RelaTabId4View(string strPrjId)
        {
            clsPrjTabBLEx.BindDdl_TabIdExCache(ddlRelaTabId4View, strPrjId);
        }

        public void SetDdl_CacheClassifyField(string strTabId)
        {
            clsvPrjTabFldBLEx.BindDdl_FldIDByTabId(ddlCacheClassifyField, strTabId);
        }

        protected void ddlFuncModuleId_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            //if (ddlFuncModuleId.SelectedIndex > 0)
            //{
            //    string strFuncModuleId = ddlFuncModuleId.SelectedValue;
            //    //clsvPrjObjects4DdlBLEx.BindDdl_ObjId(ddlObjId, clsPubVar.CurrSelPrjId, strFuncModuleId);
            //}
        }

        //protected void ddlObjId_SelectedIndexChanged(object sender, System.EventArgs e)
        //{
        //    if (ddlObjId.SelectedIndex > 0 && txtTabCnName.Text == "")
        //    {
        //        string strObjId = ddlObjId.SelectedValue;
        //        txtTabCnName.Text = clsPrjObjectsBL.GetPrjObjectsByObjId(strObjId).ObjName;
        //    }
        //}

        /// <summary>
        /// ������ͼ����ر�
        /// </summary>
        public void HideRelaTab4View()
        {
            lblRelaTabId4View.Visible = false;
            ddlRelaTabId4View.Visible = false;
        }

        /// <summary>
        /// ������ͼ����ر�
        /// </summary>
        public void ShowRelaTab4View()
        {
            lblRelaTabId4View.Visible = true;
            ddlRelaTabId4View.Visible = true;
        }
    }
}