

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
    using AGC.Entity;
    using AGC.BusinessLogic;using AGC.FunClass;using AGC.BusinessLogicEx;
    
    using com.taishsoft.datetime;

    /// <summary>
    ///		wucSqlViewRelaTabB 的摘要说明。
    /// </summary>
    public partial class wucSqlViewRelaTabB : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面

        }
        /// <summary>
        /// Sql视图Id
        /// </summary>
        public string SqlViewId
        {
            get
            {
                if (ddlSqlViewId.SelectedValue == "0")
                    return "";
                return ddlSqlViewId.SelectedValue;
            }
            set
            {
                if (ddlSqlViewId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlSqlViewId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlSqlViewId.SelectedValue = value;
                    }
                }
            }
        }

        /// <summary>
        /// 相关表Id
        /// </summary>
        public string RelaTabId
        {
            get
            {
                if (ddlRelaTabId.SelectedValue == "0")
                    return "";
                return ddlRelaTabId.SelectedValue;
            }
            set
            {
                if (ddlRelaTabId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlRelaTabId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlRelaTabId.SelectedValue = value;
                    }
                }
            }
        }

        /// <summary>
        /// 表别名
        /// </summary>
        public string TabAliases
        {
            get
            {
                return txtTabAliases.Text.Trim();
            }
            set
            {
                txtTabAliases.Text = value.ToString();
            }
        }

     

        /// <summary>
        /// Sql视图相关表类型Id
        /// </summary>
        public string SvRelaTabTypeId
        {
            get
            {
                if (ddlSvRelaTabTypeId.SelectedValue == "0")
                    return "";
                return ddlSvRelaTabTypeId.SelectedValue;
            }
            set
            {
                if (ddlSvRelaTabTypeId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlSvRelaTabTypeId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlSvRelaTabTypeId.SelectedValue = value;
                    }
                }
            }
        }


        /// <summary>
        /// 表关系类型Id
        /// </summary>
        public string TabRelationTypeId
        {
            get
            {
                if (ddlTabRelationTypeId.SelectedValue == "0")
                    return "";
                return ddlTabRelationTypeId.SelectedValue;
            }
            set
            {
                if (ddlTabRelationTypeId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlTabRelationTypeId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlTabRelationTypeId.SelectedValue = value;
                    }
                }
            }
        }

        /// <summary>
        /// 表关系文本
        /// </summary>
        public string TabRelationText
        {
            get
            {
                return txtTabRelationText.Text.Trim();
            }
            set
            {
                txtTabRelationText.Text = value.ToString();
            }
        }

        /// <summary>
        /// OrderNum
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
        /// 修改日期
        /// </summary>
        public string UpdDate
        {
            get
            {
                return clsDateTime.getTodayDateTimeStr(1);
            }
          
        }

        /// <summary>
        /// 修改用户Id
        /// </summary>
        public string UpdUserId
        {
            get
            {
                return clsCommonSession.UserId;
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


        public void Clear()
        {
            ddlSqlViewId.SelectedIndex = 0;
            ddlRelaTabId.SelectedIndex = 0;
            txtTabAliases.Text = "";
            ddlSvRelaTabTypeId.SelectedIndex = 0;
            ddlTabRelationTypeId.SelectedIndex = 0;
            txtTabRelationText.Text = "";
            txtOrderNum.Text = "0";
        
          
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
            if (clsString.IsNumeric(txtOrderNum.Text) == false)
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
            ddlSqlViewId.SelectedIndex = 0;
            ddlRelaTabId.SelectedIndex = 0;
            txtTabAliases.Text = "";
            ddlSvRelaTabTypeId.SelectedIndex = 0;
            ddlTabRelationTypeId.SelectedIndex = 0;
            txtTabRelationText.Text = "";
            txtOrderNum.Text = "0";
         
          
            txtMemo.Text = "";
        }
      
        public System.Data.DataTable GetTabRelationTypeId()
        {
            //获取某学院所有专业信息
            string strSQL = "select TabRelationTypeId, TabRelationTypeName from TabRelationType ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindDdl_TabRelationTypeId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetTabRelationTypeId();
            objDDL.DataValueField = "TabRelationTypeId";
            objDDL.DataTextField = "TabRelationTypeName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
    
        public void SetDdl_SqlViewId(string strPrjId)
        {
            clsSqlViewBLEx.BindDdl_SqlViewIdEx(ddlSqlViewId, strPrjId);
        }
        public void SetDdl_RelaTabId(string strPrjId)
        {
            clsPrjTabBLEx.BindDdl_TabIdExCache(ddlRelaTabId, strPrjId);
        }
        public void SetDdl_TabRelationTypeId()
        {
            clsTabRelationTypeBL.BindDdlTabRelationTypeId(ddlTabRelationTypeId);
        }

        public void SetDdl_SvRelaTabTypeId()
        {
            clsSV_RelaTabTypeBL.BindDdlSvRelaTabTypeId(ddlSvRelaTabTypeId);
        }
    }
}