﻿namespace AGC.Webform
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
    using AGC.Entity;
    using AGC.BusinessLogic;using AGC.FunClass;


    /// <summary>
    ///		wucDepartmentInfo 的摘要说明。
    /// </summary>
    public partial class wucDepartmentInfo : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面

        }
        /// <summary>
        /// 部门Id
        /// </summary>
        public string DepartmentId
        {
            get
            {
                return txtDepartmentId.Text.Trim();
            }
            set
            {
                txtDepartmentId.Text = value.ToString();
            }
        }

        /// <summary>
        /// 部门名
        /// </summary>
        public string DepartmentName
        {
            get
            {
                return txtDepartmentName.Text.Trim();
            }
            set
            {
                txtDepartmentName.Text = value.ToString();
            }
        }

        /// <summary>
        /// 名称缩写
        /// </summary>
        public string DepartmentAbbrName
        {
            get
            {
                return txtDepartmentAbbrName.Text.Trim();
            }
            set
            {
                txtDepartmentAbbrName.Text = value.ToString();
            }
        }

        /// <summary>
        /// 排序号
        /// </summary>
        public int OrderNum
        {
            get
            {
                return int.Parse(txtOrderNum.Text.Trim());
            }
            set
            {
                txtOrderNum.Text = value.ToString();
            }
        }

        /// <summary>
        /// 所属部门号
        /// </summary>
        public string UpDepartmentId
        {
            get
            {
                if (ddlUpDepartmentId.SelectedValue == "0")
                    return "";
                return ddlUpDepartmentId.SelectedValue;
            }
            set
            {
                if (ddlUpDepartmentId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlUpDepartmentId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlUpDepartmentId.SelectedValue = value;
                    }
                }
            }
        }

        /// <summary>
        /// 部门类型ID
        /// </summary>
        public string DepartmentTypeId
        {
            get
            {
                if (ddlDepartmentTypeId.SelectedValue == "0")
                    return "";
                return ddlDepartmentTypeId.SelectedValue;
            }
            set
            {
                if (ddlDepartmentTypeId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlDepartmentTypeId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlDepartmentTypeId.SelectedValue = value;
                    }
                }
            }
        }

        ///// <summary>
        ///// 学科类型ID
        ///// </summary>
        //public string SubjectTypeId
        //{
        //    get
        //    {
        //        if (ddlSubjectTypeId.SelectedValue == "0")
        //            return "";
        //        return ddlSubjectTypeId.SelectedValue;
        //    }
        //    set
        //    {
        //        if (ddlSubjectTypeId.Items.Count > 0)
        //        {
        //            if (value == "")
        //            {
        //                ddlSubjectTypeId.SelectedValue = "0";
        //            }
        //            else
        //            {
        //                try
        //                {
        //                    ddlSubjectTypeId.SelectedValue = value;
        //                }
        //                catch (Exception objException)
        //                {
        //                    string ss = objException.Message;
        //                }
        //            }
        //        }
        //    }
        //}

        ///// <summary>
        ///// 是否参与考核
        ///// </summary>
        //public bool IsExam
        //{
        //    get
        //    {
        //        return chkIsExam.Checked;
        //    }
        //    set
        //    {
        //        chkIsExam.Checked = value;
        //    }
        //}

        /// <summary>
        /// 是否参与考核
        /// </summary>
        public bool InUse
        {
            get
            {
                return chkInUse.Checked;
            }
            set
            {
                chkInUse.Checked = value;
            }
        }

        ///// <summary>
        ///// 一卡通部门ID
        ///// </summary>
        //public string DepartmentId4Card
        //{
        //    get
        //    {
        //        return txtDepartmentId4Card.Text.Trim();
        //    }
        //    set
        //    {
        //        txtDepartmentId4Card.Text = value.ToString();
        //    }
        //}

        ///// <summary>
        ///// 是否学院
        ///// </summary>
        //public bool IsAcademy
        //{
        //    get
        //    {
        //        return chkIsAcademy.Checked;
        //    }
        //    set
        //    {
        //        chkIsAcademy.Checked = value;
        //    }
        //}

        /// <summary>
        /// 备注
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
            txtDepartmentId.ReadOnly = bolReadonly;
        }
        public void Clear()
        {
            txtDepartmentId.Text = "";
            txtDepartmentName.Text = "";
            txtDepartmentAbbrName.Text = "";
            txtOrderNum.Text = "0";
            ddlUpDepartmentId.SelectedIndex = 0;
            ddlDepartmentTypeId.SelectedIndex = 0;
            //ddlSubjectTypeId.SelectedIndex = 0;
            //chkIsExam.Checked = false;
            //txtDepartmentId4Card.Text = "";
            //chkIsAcademy.Checked = false;
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
            ComValid_OrderNum.Validate();
            if (!ComValid_OrderNum.IsValid) return false;
            if (IsNumeric(txtOrderNum.Text) == false)
            {
                strResult = "请输入正确的整型!";
                return false;
            }
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
            txtDepartmentId.Text = "";
            txtDepartmentName.Text = "";
            txtDepartmentAbbrName.Text = "";
            txtOrderNum.Text = "0";
            ddlUpDepartmentId.SelectedIndex = 0;
            ddlDepartmentTypeId.SelectedIndex = 0;
            //ddlSubjectTypeId.SelectedIndex = 0;
            //chkIsExam.Checked = false;
            //txtDepartmentId4Card.Text = "";
            //chkIsAcademy.Checked = false;
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

        public void BindDdl_UpDepartmentId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            string strCondition = string.Format("{0}='1'", conDepartmentInfo.InUse);
            System.Data.DataTable objDT = clsDepartmentInfoBL.GetDataTable_DepartmentInfo(strCondition);
            objDDL.DataValueField = "DepartmentId";
            objDDL.DataTextField = "DepartmentName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        public void BindDdl_DepartmentTypeId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = clsDepartmentTypeBL.GetDataTable_DepartmentType("1=1");
            objDDL.DataValueField = "DepartmentTypeId";
            objDDL.DataTextField = "DepartmentTypeName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        public System.Data.DataTable GetSubjectTypeId()
        {
            //获取某学院所有专业信息
            string strSQL = "select SubjectTypeId, SubjectTypeName from SubjectType ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindDdl_SubjectTypeId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetSubjectTypeId();
            objDDL.DataValueField = "SubjectTypeId";
            objDDL.DataTextField = "SubjectTypeName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        public void SetDdl_UpDepartmentId()
        {
            BindDdl_UpDepartmentId(ddlUpDepartmentId);
        }
        public void SetDdl_DepartmentTypeId()
        {
            BindDdl_DepartmentTypeId(ddlDepartmentTypeId);
        }
        //public void SetDdl_SubjectTypeId()
        //{
        //    BindDdl_SubjectTypeId(ddlSubjectTypeId);
        //}
    }
}