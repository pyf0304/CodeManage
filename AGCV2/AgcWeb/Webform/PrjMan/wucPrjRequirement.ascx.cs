
namespace AGC
{
    using System;
    using System.Data;
    using System.Drawing;
    using System.Web;
    using System.Web.UI.WebControls;
    using System.Web.UI.HtmlControls;
    using com.taishsoft.common;
    using com.taishsoft.commdb;
    using AGC.BusinessLogic;using AGC.FunClass;
    
    using AGC.BusinessLogicEx;

    /// <summary>
    ///		wucPrjRequirement ��ժҪ˵����
    /// </summary>
    public partial class wucPrjRequirement : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, System.EventArgs e)
        {
            // �ڴ˴������û������Գ�ʼ��ҳ��

        }
        public string ReqId
        {
            get
            {
                return txtReqId.Text.Trim();
            }
            set
            {
                txtReqId.Text = value.ToString();
            }
        }

        public string Requirement
        {
            get
            {
                return txtRequirement.Text.Trim();
            }
            set
            {
                txtRequirement.Text = value.ToString();
            }
        }

        public string PrjId
        {
            get
            {
                if (ddlPrjId.SelectedValue == "0")
                    return "";
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

        public string UpReqId
        {
            get
            {
                if (ddlUpReqId.SelectedValue == "0")
                    return "";
                return ddlUpReqId.SelectedValue;
            }
            set
            {
                if (value == "")
                {
                    ddlUpReqId.SelectedValue = "0";
                }
                else
                {
                    ddlUpReqId.SelectedValue = value;
                }
            }
        }

        public string ReqTypeId
        {
            get
            {
                if (ddlReqTypeId.SelectedValue == "0")
                    return "";
                return ddlReqTypeId.SelectedValue;
            }
            set
            {
                if (value == "")
                {
                    ddlReqTypeId.SelectedValue = "0";
                }
                else
                {
                    ddlReqTypeId.SelectedValue = value;
                }
            }
        }

        public string FuncModuleAgcId
        {
            get
            {
                if (ddlFuncModuleId.SelectedValue == "0")
                    return "";
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

        public bool IsFinished
        {
            get
            {
                return bool.Parse(txtIsFinished.Text.Trim());
            }
            set
            {
                txtIsFinished.Text = value.ToString();
            }
        }

        public string ReqContent
        {
            get
            {
                return txtReqContent.Text.Trim();
            }
            set
            {
                txtReqContent.Text = value.ToString();
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


        public void SetKeyReadOnly(bool bolReadonly)
        {
            txtReqId.ReadOnly = bolReadonly;
        }
        public void Clear()
        {
            txtReqId.Text = "";
            txtRequirement.Text = "";
            ddlPrjId.SelectedIndex = 0;
            ddlUpReqId.SelectedIndex = 0;
            ddlReqTypeId.SelectedIndex = 0;
            ddlFuncModuleId.SelectedIndex = 0;
            txtIsFinished.Text = "false";
            txtReqContent.Text = "";
            txtMemo.Text = "";
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
            txtReqId.Text = "";
            txtRequirement.Text = "";
            ddlPrjId.SelectedIndex = 0;
            ddlUpReqId.SelectedIndex = 0;
            ddlReqTypeId.SelectedIndex = 0;
            ddlFuncModuleId.SelectedIndex = 0;
            txtIsFinished.Text = "false";
            txtReqContent.Text = "";
            txtMemo.Text = "";
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

     
        public System.Data.DataTable GetUpReqId()
        {
            //��ȡĳѧԺ����רҵ��Ϣ
            string strSQL = "select ReqId, Requirement from PrjRequirement ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindDdl_UpReqId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //Ϊ����Դ�ڱ����������������
            ListItem li = new ListItem("��ѡ��...", "0");
            System.Data.DataTable objDT = GetUpReqId();
            objDDL.DataValueField = "ReqId";
            objDDL.DataTextField = "Requirement";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        public System.Data.DataTable GetReqTypeId()
        {
            //��ȡĳѧԺ����רҵ��Ϣ
            string strSQL = "select RequirementTypeId, RequirementTypeName from RequirementType ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindDdl_ReqTypeId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //Ϊ����Դ�ڱ����������������
            ListItem li = new ListItem("��ѡ��...", "0");
            System.Data.DataTable objDT = GetReqTypeId();
            objDDL.DataValueField = "RequirementTypeId";
            objDDL.DataTextField = "RequirementTypeName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        public System.Data.DataTable GetFuncModuleId()
        {
            //��ȡĳѧԺ����רҵ��Ϣ
            string strSQL = "select FuncModuleAgcId, FuncModuleName from FuncModule_Agc ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindDdl_FuncModuleId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //Ϊ����Դ�ڱ����������������
            ListItem li = new ListItem("��ѡ��...", "0");
            System.Data.DataTable objDT = GetFuncModuleId();
            objDDL.DataValueField = "FuncModuleAgcId";
            objDDL.DataTextField = "FuncModuleName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        public void SetDdl_PrjId()
        {
          clsProjectsBLEx.BindDdl_PrjIdCacheEx(ddlPrjId);
        }
        public void SetDdl_UpReqId()
        {
            BindDdl_UpReqId(ddlUpReqId);
        }
        public void SetDdl_ReqTypeId()
        {
            BindDdl_ReqTypeId(ddlReqTypeId);
        }
        public void SetDdl_FuncModuleId()
        {
            BindDdl_FuncModuleId(ddlFuncModuleId);
        }

        public void TabHidden()
        {
            tabHidden.Visible = false;
        }
    }
}