﻿
namespace AGC.Webform
{
    using System;
    using System.Data;
    using System.Configuration;
    using System.Collections;
    using System.Web;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    using System.Web.UI.WebControls.WebParts;
    using System.Web.UI.HtmlControls;
    using com.taishsoft.common;
    using com.taishsoft.commdb;
    using AGC.BusinessLogic;using AGC.FunClass;using AGC.BusinessLogicEx;

    /// <summary>
    ///		wucPrjDataBase 的摘要说明。
    /// </summary>
    public partial class wucPrjDataBase : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面

        }
        /// <summary>
        /// 项目数据库Id
        /// </summary>
        public string PrjDataBaseId
        {
            get
            {
                return txtPrjDataBaseId.Text.Trim();
            }
            set
            {
                txtPrjDataBaseId.Text = value.ToString();
            }
        }

        /// <summary>
        /// 项目数据库名
        /// </summary>
        public string PrjDataBaseName
        {
            get
            {
                return txtPrjDataBaseName.Text.Trim();
            }
            set
            {
                txtPrjDataBaseName.Text = value.ToString();
            }
        }

        /// <summary>
        /// 数据库名
        /// </summary>
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

        /// <summary>
        /// 数据库拥有者
        /// </summary>
        public string DatabaseOwner
        {
            get
            {
                return txtDatabaseOwner.Text.Trim();
            }
            set
            {
                txtDatabaseOwner.Text = value.ToString();
            }
        }

        /// <summary>
        /// 数据库的用户口令
        /// </summary>
        public string DataBasePwd
        {
            get
            {
                if (string.IsNullOrEmpty(txtDataBasePwd.Text) == false)
                {
                    return txtDataBasePwd.Text.Trim();
                }
                else if (string.IsNullOrEmpty(vsDataBasePwd) == false)
                {
                    return vsDataBasePwd;
                }
                else
                {
                    return "";
                }
            }
            set
            {
                txtDataBasePwd.Text = value.ToString();
                vsDataBasePwd = value.ToString();
            }
        }

        /// <summary>
        /// 数据库类型ID
        /// </summary>
        public string DataBaseTypeId
        {
            get
            {
                if (ddlDataBaseTypeId.SelectedValue == "0")
                    return "";
                return ddlDataBaseTypeId.SelectedValue;
            }
            set
            {
                if (ddlDataBaseTypeId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlDataBaseTypeId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlDataBaseTypeId.SelectedValue = value;
                    }
                }
            }
        }


        /// <summary>
        /// 使用状态ID
        /// </summary>
        public string UseStateId
        {
            get
            {
                if (ddlUseStateId.SelectedValue == "0")
                    return "";
                return ddlUseStateId.SelectedValue;
            }
            set
            {
                if (ddlUseStateId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlUseStateId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlUseStateId.SelectedValue = value;
                    }
                }
            }
        }

        /// <summary>
        /// 数据库的用户ID
        /// </summary>
        public string DataBaseUserId
        {
            get
            {
                return txtDataBaseUserId.Text.Trim();
            }
            set
            {
                txtDataBaseUserId.Text = value.ToString();
            }
        }

        /// <summary>
        /// 服务器
        /// </summary>
        public string IpAddress
        {
            get
            {
                return txtIpAddress.Text.Trim();
            }
            set
            {
                txtIpAddress.Text = value.ToString();
            }
        }

        /// <summary>
        /// Sid
        /// </summary>
        public string Sid
        {
            get
            {
                return txtSid.Text.Trim();
            }
            set
            {
                txtSid.Text = value.ToString();
            }
        }

        /// <summary>
        /// 表空间
        /// </summary>
        public string TableSpace
        {
            get
            {
                return txtTableSpace.Text.Trim();
            }
            set
            {
                txtTableSpace.Text = value.ToString();
            }
        }



        /// <summary>
        /// 说明
        /// </summary>
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


        public void SetKeyReadOnly(bool bolReadonly)
        {
            txtPrjDataBaseId.ReadOnly = bolReadonly;
        }
        public void Clear()
        {
            txtPrjDataBaseId.Text = "";
            txtPrjDataBaseName.Text = "";
            txtDataBaseName.Text = "";
            txtDatabaseOwner.Text = "";
            txtDataBasePwd.Text = "";
            ddlDataBaseTypeId.SelectedIndex = 0;
            txtDataBaseUserId.Text = "";
            txtIpAddress.Text = "";
            txtSid.Text = "";
            txtTableSpace.Text = "";
            txtMemo.Text = "";
        }
        /// <summary>
        /// 校验自定义控件中自子控件的类型数值是否是合法正确的。
        /// 一般规则：
        ///		1、首先校验类型：整型、浮点型、日期型等，
        ///			这些代码由自动生成代码帮助生成
        ///		2、校验最值，即最大值和最小值等
        ///			这些代码由自动生成代码帮助生成
        ///		这些生成内容可以修改
        /// </summary>
        /// <returns></returns>
        public bool IsValid(ref string strResult)
        {
            return true;
        }
        /// <summary>
        /// 设置该控件在插入状态下的缺省值
        /// 一般规则：
        ///		1、如果是整型就默认为0；
        ///		2、如果是浮点型不默认为0.0；
        ///		3、如果是日期型就默认为当前的日期；
        ///		4、如果是位(bit)型就默认为false;
        ///		这些默认值可以再行修改
        /// </summary>
        public void SetDefaultValue()
        {
            txtPrjDataBaseId.Text = "";
            txtPrjDataBaseName.Text = "";
            txtDataBaseName.Text = "";
            txtDatabaseOwner.Text = "";
            txtDataBasePwd.Text = "";
            ddlDataBaseTypeId.SelectedIndex = 0;
            txtDataBaseUserId.Text = "";
            txtIpAddress.Text = "";
            txtSid.Text = "";
            txtTableSpace.Text = "";
            txtMemo.Text = "";
        }
        /// <summary>
        /// 功能：获取当前日期的字符串
        /// 日期格式：
        ///    日期的字符串的格式有三种：
        ///		1、YYYYMMDD。	例如20050120
        ///		2、YYYY-MM-DD	例如2005-01-20
        ///		3、YYYY/MM/DD	例如2005/01/20
        /// </summary>
        /// <param name="intFormat">日期格式，共有3种，传入参数0,1，2
        ///							参数不同，函数返回值就不同，
        ///							参见上面的日期格式
        ///	</param>
        /// <returns>返回当前日期的字符串</returns>
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
        /// 功能：获取当前月的字符串
        /// 月的格式：
        ///    月的字符串的格式有三种：
        ///		1、YYYYMM。	例如200501
        ///		2、YYYY-MM-DD	例如2005-01
        ///		3、YYYY/MM/DD	例如2005/01
        /// </summary>
        /// <param name="intFormat">月的格式，共有3种，传入参数0,1，2
        ///							参数不同，函数返回值就不同，
        ///							参见上面的月的格式
        ///	</param>
        /// <returns>返回当前月的字符串</returns>
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
        /// 判断是否是数字
        /// </summary>
        /// <param name="strValue">需要判断的字符串</param>
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
        /// 判断是否是浮点型数值
        /// </summary>
        /// <param name="strValue">需要判断的字符串</param>
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
            //检查总共有几个小数点，如果有多于1个小数点，就不正确
            if (intPointNum > 1) return false;
            return true;
        }
        /// <summary>
        /// 判断是否是整型数值
        /// </summary>
        /// <param name="strValue">需要判断的字符串</param>
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
        
        public System.Data.DataTable GetDataBaseTypeId()
        {
            //获取某学院所有专业信息
            string strSQL = "select DataBaseTypeId, DataBaseTypeName from DataBaseType ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindDdl_DataBaseTypeId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetDataBaseTypeId();
            objDDL.DataValueField = "DataBaseTypeId";
            objDDL.DataTextField = "DataBaseTypeName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        public System.Data.DataTable GetUserId()
        {
            //获取某学院所有专业信息
            string strSQL = "select UserId, UserName from Users ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindDdl_UserId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetUserId();
            objDDL.DataValueField = "UserId";
            objDDL.DataTextField = "UserName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        public void SetDdl_UseStateId()
        {
            clsUseStateBL.BindDdl_UseStateId(ddlUseStateId);
        }

        public void SetDdl_DataBaseTypeId()
        {
            BindDdl_DataBaseTypeId(ddlDataBaseTypeId);
        }


        protected void ddlDataBaseTypeId_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strDataBaseTypeId = this.DataBaseTypeId;
            if (string.IsNullOrEmpty(strDataBaseTypeId) == true) return;
            if (strDataBaseTypeId == "01" || strDataBaseTypeId == "02")
            {
                trOracle.Visible = false;
            }
            else
            {
                trOracle.Visible = true;
            }
        }

        /// <summary>
        /// 父页面。
        /// </summary>
        protected string vsDataBasePwd
        {
            get
            {
                string sDataBasePwd;
                sDataBasePwd = (string)ViewState["DataBasePwd"];
                if (sDataBasePwd == null)
                {
                    sDataBasePwd = "";
                }
                return sDataBasePwd;
            }
            set
            {
                string sDataBasePwd = value;
                ViewState.Add("DataBasePwd", sDataBasePwd);
            }
        }
    }
}