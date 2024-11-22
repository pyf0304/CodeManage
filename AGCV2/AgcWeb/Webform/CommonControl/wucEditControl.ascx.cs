
namespace AGC.Webform
{
    using System;
    using System.Data;
    using System.Drawing;
    using System.Collections;
    using System.Web;
    using System.Web.UI.WebControls;
    using System.Web.UI.HtmlControls;
    using com.taishsoft.commdb;
    using CommFunc4WebForm;
    using AGC.BusinessLogic;
    using AGC.FunClass;
    using AGC.BusinessLogicEx;
    using AGC.Entity;
    public delegate void CtlTypeIdChanged(object sender, EventArgs e);
    /// <summary>
    ///		wucEditRegionFlds ��ժҪ˵����
    /// </summary>
    public partial class wucEditControl : System.Web.UI.UserControl
    {
        public event CtlTypeIdChanged ctlTypeIdChanged;
        protected void Page_Load(object sender, System.EventArgs e)
        {
            // �ڴ˴������û������Գ�ʼ��ҳ��


        }



        public string CtlTypeId
        {
            get
            {
                if (ddlCtlTypeId.SelectedValue == "0")
                    return "";
                return ddlCtlTypeId.SelectedValue;
            }
            set
            {
                if (value == "")
                {
                    ddlCtlTypeId.SelectedValue = "0";
                }
                else
                {
                    ddlCtlTypeId.SelectedValue = value;
                    SetPropVisibleByCtlTypeId(value);

                }
            }
        }

        public string CallTabFeatureId
        {
            get
            {
                if (ddlCallTabFeatureId.SelectedValue == "0")
                    return "";
                return ddlCallTabFeatureId.SelectedValue;
            }
            set
            {
                if (value == "")
                {
                    ddlCallTabFeatureId.SelectedValue = "0";
                }
                else
                {
                    ddlCallTabFeatureId.SelectedValue = value;
                    //SetPropVisibleByCtlTypeId(value);

                }
            }
        }


        public string VarId
        {
            get
            {
                if (ddlVarId.SelectedValue == "0")
                    return "";
                return ddlVarId.SelectedValue;
            }
            set
            {
                if (value == "")
                {
                    ddlVarId.SelectedValue = "0";
                }
                else
                {
                    ddlVarId.SelectedValue = value;
                }
            }
        }

        public string DdlItemsOptionId
        {
            get
            {
                if (ddlDdlItemsOptionId.SelectedValue == "0")
                    return "";
                return ddlDdlItemsOptionId.SelectedValue;
            }
            set
            {
                if (value == "")
                {
                    ddlDdlItemsOptionId.SelectedValue = "0";
                }
                else
                {
                    ddlDdlItemsOptionId.SelectedValue = value;
                    ddlDdlItemsOptionId_SelectedIndexChanged(new object(), new System.EventArgs());
                }
            }
        }

        public string DsTabId
        {
            get
            {
                if (ddlDsTabId.SelectedValue == "0")
                    return "";
                return ddlDsTabId.SelectedValue;
            }
            set
            {
                if (value == "")
                {
                    ddlDsTabId.SelectedValue = "0";
                }
                else
                {
                    ddlDsTabId.SelectedValue = value;
                    ddlDsTabId_SelectedIndexChanged(new object(), new System.EventArgs());
                }
            }
        }

        public string DsDataValueFieldId
        {
            get
            {
                if (ddlDsDataValueFieldId.SelectedValue == "0")
                    return "";
                return ddlDsDataValueFieldId.SelectedValue;
            }
            set
            {
                if (value == "")
                {
                    ddlDsDataValueFieldId.SelectedValue = "0";
                }
                else
                {
                    try
                    {
                        ddlDsDataValueFieldId.SelectedValue = value;
                    }
                    catch (Exception objException)
                    {
                        clsPubVar.objLog.WriteDebugLog(objException.Message);

                    }
                }
            }
        }

        public string DsDataTextFieldId
        {
            get
            {
                if (ddlDsDataTextFieldId.SelectedValue == "0")
                    return "";
                return ddlDsDataTextFieldId.SelectedValue;
            }
            set
            {
                if (value == "")
                {
                    ddlDsDataTextFieldId.SelectedValue = "0";
                }
                else
                {
                    try
                    {
                        ddlDsDataTextFieldId.SelectedValue = value;
                    }
                    catch(Exception objException)
                    {
                        clsPubVar.objLog.WriteDebugLog(objException.Message);
                    }
                }
            }
        }

        public string Ds_CondFieldId
        {
            get
            {
                if (ddlDs_CondFieldId.SelectedValue == "0")
                    return "";
                return ddlDs_CondFieldId.SelectedValue;
            }
            set
            {
                if (value == "")
                {
                    ddlDs_CondFieldId.SelectedValue = "0";
                }
                else
                {
                    ddlDs_CondFieldId.SelectedValue = value;
                }
            }
        }

        public string Ds_SortFieldId
        {
            get
            {
                if (ddlDs_SortFieldId.SelectedValue == "0")
                    return "";
                return ddlDs_SortFieldId.SelectedValue;
            }
            set
            {
                if (value == "")
                {
                    ddlDs_SortFieldId.SelectedValue = "0";
                }
                else
                {
                    ddlDs_SortFieldId.SelectedValue = value;
                }
            }
        }

        public string DsCondStr
        {
            get
            {
                return txtDsCondStr.Text.Trim();
            }
            set
            {
                txtDsCondStr.Text = value.ToString();
            }
        }

        public string DsSqlStr
        {
            get
            {
                return txtDsSqlStr.Text.Trim();
            }
            set
            {
                txtDsSqlStr.Text = value.ToString();
            }
        }

        public string DefaultValue
        {
            get
            {
                return txtDefaultValue.Text.Trim();
            }
            set
            {
                txtDefaultValue.Text = value.ToString();
            }
        }

        public string ItemsString
        {
            get
            {
                return txtItemsString.Text.Trim();
            }
            set
            {
                txtItemsString.Text = value.ToString();
            }
        }




        public void Clear()
        {
            ddlCtlTypeId.SelectedIndex = 0;
            ddlDdlItemsOptionId.SelectedIndex = 0;
            ddlDsTabId.SelectedIndex = 0;
            try
            {
                ddlDsDataValueFieldId.SelectedIndex = 0;
                ddlDsDataTextFieldId.SelectedIndex = 0;
            }
            catch (Exception objException)
            {
                clsPubVar.objLog.WriteDebugLog(objException.Message);

            }
            txtDsCondStr.Text = "";
            txtDsSqlStr.Text = "";
            txtItemsString.Text = "";

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
        public bool IsValid(ref string strResult)
        {

            return true;
        }
        /// <summary>
        /// ���øÿؼ��ڲ���״̬�µ�ȱʡֵ
        /// һ�����
        ///		1����������;�Ĭ��Ϊ0��
        ///		2������Ǹ����Ͳ�Ĭ��Ϊ0.0��
        ///		3������������;�Ĭ��Ϊ��ǰ�����ڣ�
        ///		4�������λ(bit)�;�Ĭ��Ϊfalse;
        ///		��ЩĬ��ֵ���������޸�
        /// </summary>
        public void SetDefaultValue()
        {

            ddlCtlTypeId.SelectedIndex = 0;
            ddlDdlItemsOptionId.SelectedIndex = 0;
            ddlDsTabId.SelectedIndex = 0;
            ddlDsDataValueFieldId.SelectedIndex = 0;
            ddlDsDataTextFieldId.SelectedIndex = 0;
            txtDsCondStr.Text = "";
            txtDsSqlStr.Text = "";
            txtItemsString.Text = "";

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
        /// <summary>
        /// �ж��Ƿ�������
        /// </summary>
        /// <param name="strValue">��Ҫ�жϵ��ַ���</param>
        /// <returns>True/False</returns>
        public bool IsDigit(string strValue)
        {
            int intLen = strValue.Length;
            for (int i = 0; i < intLen; i++)
            {
                if (char.IsDigit(strValue, i) == false)
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// �ж��Ƿ��Ǹ�������ֵ
        /// </summary>
        /// <param name="strValue">��Ҫ�жϵ��ַ���</param>
        /// <returns>True/False</returns>
        public bool IsFloat(string strValue)
        {
            int intPointNum = 0;
            char[] arrChar = strValue.ToCharArray();
            int intLen = strValue.Length;
            for (int i = 0; i < intLen; i++)
            {
                if (char.IsDigit(strValue, i) == true || arrChar[i] == '.')
                {
                }
                else
                {
                    return false;
                }
                if (arrChar[i] == '.') intPointNum++;
            }
            //����ܹ��м���С���㣬����ж���1��С���㣬�Ͳ���ȷ
            if (intPointNum > 1) return false;
            return true;
        }
        /// <summary>
        /// �ж��Ƿ���������ֵ
        /// </summary>
        /// <param name="strValue">��Ҫ�жϵ��ַ���</param>
        /// <returns>True/False</returns>
        public bool IsNumeric(string strValue)
        {
            int intLen = strValue.Length;
            for (int i = 0; i < intLen; i++)
            {
                if (char.IsDigit(strValue, i) == false)
                {
                    return false;
                }
            }
            return true;
        }


        //public void SetDdl_CtlTypeId(1)
        //{
        //    clsCtlTypeBLEx.BindDdl_CtlTypeIdCacheEx(ddlCtlTypeId);
        //}
        public void SetDdl_CtlTypeId(bool bolIsForApple)
        {
            clsCtlTypeBLEx.BindDdl_CtlTypeIdCacheEx(ddlCtlTypeId, bolIsForApple);
        }
        public void SetDdl_DdlItemsOptionId()
        {
            clsDDLItemsOptionBL.BindDdl_DdlItemsOptionIdCache(ddlDdlItemsOptionId);
        }
        public void SetDdl_DsTabId(string strPrjId)
        {
            clsPrjTabBLEx.BindDdl_TabIdExCache(ddlDsTabId, strPrjId);
            //			BindDdl_DsTabId(ddlDsTabId);
        }
        public void SetDdl_CallTabFeatureId(string strFldId, string strPrjId)
        {
            clsTabFeatureBLEx.BindDdl_TabFeatureIdExByFldId(ddlCallTabFeatureId, strFldId, strPrjId);
            //			BindDdl_DsTabId(ddlDsTabId);
        }
        public void SetDdl_VarId(string strPrjId)
        {
            clsGCVariableBLEx.BindDdl_VarIdCacheEx(ddlVarId, strPrjId);
            //			BindDdl_DsTabId(ddlDsTabId);
        }
        public void SetDdl_DsDataValueFieldId(string strTabId)
        {
            clsDropDownList.BindDdl_DsDataPrjTabFld(ddlDsDataValueFieldId, strTabId);
        }

        public void SetDdl_Ds_CondFieldId(string strTabId)
        {
            clsDropDownList.BindDdl_DsDataPrjTabFld(ddlDs_CondFieldId, strTabId);
        }
        public void SetDdl_Ds_SortFieldId(string strTabId)
        {
            clsDropDownList.BindDdl_DsDataPrjTabFld(ddlDs_SortFieldId, strTabId);
        }

        public void SetDdl_DsDataTextFieldId(string strTabId)
        {
            clsDropDownList.BindDdl_DsDataPrjTabFld(ddlDsDataTextFieldId, strTabId);
        }

        protected void ddlDsTabId_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            SetDdl_DsDataTextFieldId(ddlDsTabId.SelectedValue);
            SetDdl_DsDataValueFieldId(ddlDsTabId.SelectedValue);
            SetDdl_Ds_CondFieldId(ddlDsTabId.SelectedValue);
            SetDdl_Ds_SortFieldId(ddlDsTabId.SelectedValue);

        }

        protected void ddlDdlItemsOptionId_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (ddlDdlItemsOptionId.SelectedIndex <= 0) return;
            string strDdlItemsOptionId = DdlItemsOptionId;
            trDsTabId.Visible = false;
            trDsCondStr.Visible = false;
            trDsSqlStr.Visible = false;
            trItemsString.Visible = false;
            switch (DdlItemsOptionId)
            {
                case enumDDLItemsOption.DataSourceTable_02:
                    trDsTabId.Visible = true;
                    trDsCondStr.Visible = true;
                    SetDdl_DsTabId(clsPubVar.CurrSelPrjId);
                    break;
                case enumDDLItemsOption.ListItemString_01:
                    trItemsString.Visible = true;
                    break;
                case enumDDLItemsOption.SQLString_03:
                    trDsSqlStr.Visible = true;
                    break;
                case enumDDLItemsOption.TrueAndFalseList_04:
                    //trDsSqlStr.Visible = true;
                    break;
            }
        }

        protected void ddlCtlTypeId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlCtlTypeId.SelectedIndex <= 0) return;


            string strCtlTypeId = ddlCtlTypeId.SelectedValue;
            //clsCtlTypeEN objCtlTypeAbbr = clsCtlTypeBL.GetObjByCtlTypeIdCache(strCtlTypeId);
            SetPropVisibleByCtlTypeId(strCtlTypeId);
            if (ctlTypeIdChanged != null)
            {
                ctlTypeIdChanged(sender, e);
            }
        }
        public void SetPropVisibleByCtlTypeId(string strCtlTypeId)
        {
            trDdlItemsOptionId.Visible = false;
            trDsTabId.Visible = false;
            trDsCondStr.Visible = false;
            trDsSqlStr.Visible = false;
            trItemsString.Visible = false;
            trVar.Visible = false;
            trDefaValue.Visible = false;
            switch (strCtlTypeId)
            {
                case enumCtlType.ViewVariable_38:
                    trVar.Visible = true;
                    break;
                case enumCtlType.DefaultValue_36:
                    trDefaValue.Visible = true;
                    break;
                case enumCtlType.DropDownList_06:
                    trDdlItemsOptionId.Visible = true;
                    trDsTabId.Visible = true;
                    trDsCondStr.Visible = true;
                    trDsSqlStr.Visible = true;
                    trItemsString.Visible = true;
                    break;
                case enumCtlType.DropDownList_Bool_18:
                    trDdlItemsOptionId.Visible = true;
                    ddlDdlItemsOptionId.SelectedValue = enumDDLItemsOption.TrueAndFalseList_04;
                    break;
                case enumCtlType.GivenValue_35:
                    trDdlItemsOptionId.Visible = false;
                    break;
                default:
                    break;
            }
        }
    }
}