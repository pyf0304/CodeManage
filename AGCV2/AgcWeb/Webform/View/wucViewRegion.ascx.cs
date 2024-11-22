
namespace AGC.Webform
{
    using System;
    using System.Data;
    using System.Drawing;
    using System.Web;
    using System.Web.UI.WebControls;
    using System.Web.UI.HtmlControls;
    using com.taishsoft.commdb;
    using CommFunc4WebForm;
    using AGC.BusinessLogicEx;
    using AGC.FunClass;
    using AGC.BusinessLogic;

    /// <summary>
    ///		wucViewRegion ��ժҪ˵����
    /// </summary>
    public partial class wucViewRegion : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, System.EventArgs e)
        {
            // �ڴ˴������û������Գ�ʼ��ҳ��
            tabHidden.Visible = false;

        }

        public string RegionName
        {
            get
            {
                return txtRegionName.Text.Trim();
            }
            set
            {
                txtRegionName.Text = value.ToString();
            }
        }

        public string ViewId
        {
            get
            {
                if (ddlViewId.SelectedValue == "0")
                    return "";
                return ddlViewId.SelectedValue;
            }
            set
            {
                if (value == "")
                {
                    ddlViewId.SelectedValue = "0";
                }
                else
                {
                    ddlViewId.SelectedValue = value;
                }
            }
        }

        public string RegionTypeId
        {
            get
            {
                if (ddlRegionTypeId.SelectedValue == "0")
                    return "";
                return ddlRegionTypeId.SelectedValue;
            }
            set
            {
                if (value == "")
                {
                    ddlRegionTypeId.SelectedValue = "0";
                }
                else
                {
                    ddlRegionTypeId.SelectedValue = value;
                }
            }
        }

        public string RegionFunction
        {
            get
            {
                return txtRegionFunction.Text.Trim();
            }
            set
            {
                txtRegionFunction.Text = value.ToString();
            }
        }

  

        public string InOutTypeId
        {
            get
            {
                if (ddlInOutTypeId.SelectedValue == "0")
                    return "";
                return ddlInOutTypeId.SelectedValue;
            }
            set
            {
                if (value == "")
                {
                    ddlInOutTypeId.SelectedValue = "0";
                }
                else
                {
                    ddlInOutTypeId.SelectedValue = value;
                }
            }
        }

        public string TabId
        {
            get
            {
                if (ddlTabId.SelectedValue == "0")
                    return "";
                return ddlTabId.SelectedValue;
            }
            set
            {
                if (value == "")
                {
                    ddlTabId.SelectedValue = "0";
                }
                else
                {
                    try
                    {
                        ddlTabId.SelectedValue = value;
                    }
                    catch(Exception objException)
                    {
                        string ss = objException.Message;
                    }
                }
            }
        }

        public int Height
        {
            get
            {
                return int.Parse(txtHeight.Text.Trim());
            }
            set
            {
                txtHeight.Text = value.ToString();
            }
        }

        public int Width
        {
            get
            {
                return int.Parse(txtWidth.Text.Trim());
            }
            set
            {
                txtWidth.Text = value.ToString();
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
        public int ColNum
        {
            get
            {
                return int.Parse(txtColNum.Text.Trim());
            }
            set
            {
                txtColNum.Text = value.ToString();
            }
        }

        public bool IsUseCtrl
        {
            get
            {
                return chkIsUseCtrl.Checked;
            }
            set
            {
                chkIsUseCtrl.Checked = value;
            }
        }


        public void Clear()
        {
            txtRegionName.Text = "";
            ddlViewId.SelectedIndex = 0;
            ddlRegionTypeId.SelectedIndex = 0;
            txtRegionFunction.Text = "";
      
            ddlInOutTypeId.SelectedIndex = 0;
            ddlTabId.SelectedIndex = 0;
            txtHeight.Text = "0";
            txtWidth.Text = "0";
            txtMemo.Text = "";
            txtColNum.Text = "0";
            chkIsUseCtrl.Checked = false;

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
            ComValid_Height.Validate();
            if (!ComValid_Height.IsValid) return false;
            ComValid_Width.Validate();
            if (!ComValid_Width.IsValid) return false;
            if (IsNumeric(txtHeight.Text) == false)
            {
                strResult = "��������ȷ������!";
                return false;
            }
            if (IsNumeric(txtWidth.Text) == false)
            {
                strResult = "��������ȷ������!";
                return false;
            }
            ComValid_ColNum.Validate();
            if (!ComValid_ColNum.IsValid) return false;
            if (IsNumeric(txtColNum.Text) == false)
            {
                strResult = "��������ȷ������!";
                return false;
            }

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
            txtRegionName.Text = "";
            ddlViewId.SelectedIndex = 0;
            ddlRegionTypeId.SelectedIndex = 0;
            txtRegionFunction.Text = "";
   
            ddlInOutTypeId.SelectedIndex = 0;
            ddlTabId.SelectedIndex = 0;
            txtHeight.Text = "0";
            txtWidth.Text = "0";
            txtMemo.Text = "";
            txtColNum.Text = "0";
            chkIsUseCtrl.Checked = false;

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


     
       
        public void SetDdl_ViewId(string strPrjId)
        {
            clsViewInfoBLEx.  BindDdl_ViewIdEx(ddlViewId, strPrjId);
        }
        public void SetDdl_RegionTypeId()
        {
            clsDropDownList.BindDdl_RegionTypeId(ddlRegionTypeId);
        }
      
        public void SetDdl_InOutTypeId()
        {
            clsInOutTypeBL.BindDdl_InOutTypeIdCache(ddlInOutTypeId);
        }
        public void SetDdl_TabId(string strPrjId, string strCmPrjId)
        {
            clsPrjTabBLEx.BindDdl_TabIdByCmPrjIdExCacheNoPureClass(ddlTabId, strPrjId, strCmPrjId);
        }

        protected void ddlInSqlDsTypeId_SelectedIndexChanged1(object sender, EventArgs e)
        {
            if (ddlInOutTypeId.SelectedIndex != 0)
            {
                string strInOutTypeId = ddlInOutTypeId.SelectedValue;

                if (strInOutTypeId == enumInOutType.IN_02)
                {
                    clsDropDownList.BindDdl_RelaTabId(ddlTabId, enumSQLDSType.SqlTab_01, clsPubVar.CurrSelPrjId);
                }
                else if (strInOutTypeId == enumInOutType.OUT_03)
                {
                    clsDropDownList.BindDdl_RelaTabId(ddlTabId, enumSQLDSType.SqlView_02, clsPubVar.CurrSelPrjId);
                }
            }
        }
    }
}