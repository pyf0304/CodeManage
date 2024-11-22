﻿
/*-- -- -- -- -- -- -- -- -- -- --
类名:wfmWebSrvFunctionsB_QUDI
表名:WebSrvFunctions
生成代码版本:2017.05.25.1
生成日期:2017/05/25 08:58:31
生成者:
工程名称:AGC
工程ID:0005
模块中文名:项目函数管理
模块英文名:PrjFunction
框架-层名:Web界面层
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2017.05.05.01
     2、需要公共函数层(TzPubFunction.dll)的版本:2016.12.13.01
== == == == == == == == == == == == 
*/

using AGC.BusinessLogic;using AGC.FunClass;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AgcCommBase;
using AutoGCLib;
using com.taishsoft.common;
using com.taishsoft.datetime;
using CommFunc4WebForm;

using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AGC.Webform
{
    /// <summary>
    /// wfmWebSrvFunctionsB_QUDI 的摘要说明。其中Q代表查询,U代表修改
    /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenQueryUpdDelInsRecControlCode)
    /// </summary>
    public partial class wfmWebSrvFunctionsB_QUDI : System.Web.UI.Page
    {

        #region 页面启动函数
        /// <summary>
        /// 函数功能:页面导入,当页面开始运行时所发生的事件
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPage_LoadCode)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void Page_Load(object sender, System.EventArgs e)
        {
            string strFunName = Request.Form["FunName"] != null ? Request.Form["FunName"] : "";
            string strLangType = Request.Form["hidLangType"] != null ? Request.Form["hidLangType"] : "";
            string strDataBaseType = Request.Form["hidDataBaseType"] != null ? Request.Form["hidDataBaseType"] : "";
            //根据传回来的值决定调用哪个函数
            switch (strFunName)
            {
                case "ChangeLangType":
                     ChangeLangType(strLangType); //调用该函数
                    lblLangTypeName.Text = strLangType;
                    break;
                case "ChangeDataBaseType":
                    ChangeDataBaseType(strDataBaseType); //调用该函数
                    lblDataBaseType.Text = strDataBaseType;
                    break;

                case "其他":
                    //调用其他函数

                    break;
                default:
                    //调用默认函数
                    //lblMsg.Text = "调用默认函数";
                    break;
            }
            // 在此处放置用户代码以初始化页面
            if (!IsPostBack)    ///如果本界面是初次被调用,而不是单击按钮事件所调用
            {
                //常规函数：预处理QueryString和Session等身份状态信息
                rf_PretreatmentQueryString();
               
                vsViewName = "WebSrv函数维护";
                vsTabName = string.Format("{0}", clsvWebSrvFunctionsEN._CurrTabName);
                //生成权限有关判断权限的代码
                //根据等级权限编号来确定用户可以使用什么功能,等级编号方式:1为最大2其次,依此类推
                switch (vsPotenceLevel)
                {
                    case "0":
                        Response.Redirect("../error.aspx");
                        break;
                    case "1":
                        Response.Redirect("../error.aspx");
                        break;
                    case "2":
                        Response.Redirect("../error.aspx");
                        break;
                    case "3":
                        Response.Redirect("../error.aspx");
                        break;
                    case "4":
                        Response.Redirect("../error.aspx");
                        break;
                    case "9":
                        break;
                    default:
                        Response.Redirect("../error.aspx");
                        break;
                }


                //1、为下拉框设置数据源,绑定列表数据
                wucWebSrvFunctionsB1.SetDdl_WebSrvClassId(clsPubVar.CurrSelPrjId);
                wucWebSrvFunctionsB1.SetDdl_FuncTypeID();
                //clsFunctionTypeBL.BindDdl_FuncTypeIdCache(ddlFuncTypeIDq);
                clsFunctionTypeBL.BindDdl_FuncTypeIdCache(ddlFuncTypeID);
                clsDropDownList.BindDdl_TrueAndFalse(ddlIsAsyncFunc);
                ddlIsAsyncFunc.SelectedIndex = 2;
                clsWebSrvClassBLEx.BindDdl_WebSrvClassIdByPrjId(ddlWebSrvClassIdq, clsPubVar.CurrSelPrjId);
                if (string.IsNullOrEmpty(vsWebSrvClassId) == false)
                {
                    ddlWebSrvClassIdq.SelectedValue = vsWebSrvClassId;
                }
                //常规函数：初始化界面信息
                rf_InitPageInfo();
                vsSortWebSrvFunctionsBy = string.Format("{0} Asc", conWebSrvFunctions.WebSrvFunctionId);
                //2、显示无条件的表内容在GridView中
                BindGv_WebSrvFunctions();
                //3、设置表控件中字控件的ReadOnly属性,
                // 使之只读,因为在修改功能中关键字是不能被修改的。
                wucWebSrvFunctionsB1.SetKeyReadOnly(true);
                DispWebSrvFunctionsListRegion();
                //设置逻辑层的公共函数，包含：缓存刷新函数
                //clsWebSrvFunctionsBL.objCommFun4BL = new clsCommFun4BL4WebSrvFunctions();
            }
        }
        private void ChangeLangType(string strLangType)
        {
            string strNetOrJava, strSqlOrOracle;
            strNetOrJava = strLangType;
            vsLangType = clsPubConst.GetLangTypeByString(strLangType);
            strSqlOrOracle = clsPubConst.GetDataBaseTypeStrByDataBaseType(vsDataBaseType);
            //vsDataBaseType = clsPubConst.GetDataBaseTypeByString(strSqlOrOracle);
            DispDiv4Operate(strNetOrJava, strSqlOrOracle);
        }

        private void ChangeDataBaseType(string strDataBaseType)
        {
            string strNetOrJava, strSqlOrOracle;
            strNetOrJava = clsPubConst.GetLangTypeStringByLangType(vsLangType);
            //            vsLangType = clsPubConst.GetLangTypeByString(strLangType);
            strSqlOrOracle = strDataBaseType;
            vsDataBaseType = clsPubConst.GetDataBaseTypeByString(strSqlOrOracle);
            DispDiv4Operate(strNetOrJava, strSqlOrOracle);
        }
        private void DispDiv4Operate(string strNetOrJava, string strSqlOrOracle)
        {
            //string strNetOrJava, strSqlOrOracle;
            //strNetOrJava = rblNetOrJava.SelectedValue;
            //strSqlOrOracle = rblSqlOrOracle.SelectedValue;
            List<Control> arrControls = clsPubFun.GetControl4Type(this, "ImageMap");
            foreach (Control ctrl in arrControls)
            {
                ctrl.Visible = false;
            }
            vsDataBaseType = clsPubConst.GetDataBaseTypeByString(strSqlOrOracle);
            //lbGeneDALCode.Visible = true;
            //lbGeneWebServiceCode.Visible = true;
            lbGeneController.Visible = true;
            lbGeneControllerInvokeWS.Visible = true;
            if (strNetOrJava == "DotNet")
            {
                imGeneCode_CSharp.Visible = true;
                vsLangType = clsPubConst.LangType.CSharp;
                lbGeneController.Visible = false;
                lbGeneControllerInvokeWS.Visible = false;
            }
            else if (strNetOrJava == "Java")
            {
                imGeneCode_Java.Visible = true;
                vsLangType = clsPubConst.LangType.JAVA;
                //lbGeneWebServiceCode.Visible = false;

            }
            else if (strNetOrJava == "Swift" 
                || strNetOrJava == "Swift3"
                || strNetOrJava == "Swift4")
            {
                imGeneCode_Swift.Visible = true;
             //   vsLangType = clsPubConst.LangType.Swift;
                //lbGeneDALCode.Visible = false;
                //lbGeneWebServiceCode.Visible = false;
            }
            else if (strNetOrJava == "JavaScript")
            {
                imGeneCode_JavaScript.Visible = true;
                vsLangType = clsPubConst.LangType.JavaScript;
                //lbGeneDALCode.Visible = false;
                //lbGeneWebServiceCode.Visible = false;
            }
            else if (strNetOrJava == "SilverLight")
            {
                vsLangType = clsPubConst.LangType.SilverLight;
                //lbGeneDALCode.Visible = false;
                //lbGeneWebServiceCode.Visible = false;
            }
            try
            {
                clsUserDefaValue_LocalBLEx.setUserDefaValue(clsPubVar.CurrPrjId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId, "默认语言", vsLangType.ToString());
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
            }
        }

        /// <summary>
        /// 常规函数：初始化界面信息。
        /// 注释：常规函数-Regular function
        ///       初始化-Init
        ///       界面信息-PageInfo
        /// </summary>
        private void rf_InitPageInfo()
        {
            if (string.IsNullOrEmpty(vsWebSrvClassId) == true) return;
            clsWebSrvClassEN objWebSrvClassEN = clsWebSrvClassBL.GetObjByWebSrvClassIdCache(vsWebSrvClassId, clsPubVar.CurrSelPrjId);
            ddlWebSrvClassIdq.SelectedValue = vsWebSrvClassId;
            txtWebSrvUrlq.Text = objWebSrvClassEN.WebSrvUrl;
            ddlWebSrvClassIdq.Enabled = false;
            txtWebSrvUrlq.Enabled = false;
        }
        #endregion 页面启动函数


        #region 查询相关函数
        /// <summary>
        /// 函数功能:事件函数,当单击<查询>按钮时所发生的事件
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenbtnQuery_ClickCode)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void btnQuery_Click(object sender, System.EventArgs e)
        {
            //把GridView的当前页索引设置为0,即第1页。
            //当单击查询时,首先显示的是表记录内容的第一部分内容。
            this.gvWebSrvFunctions.PageIndex = 0;
            //把表记录的内容显示在GridView中
            BindGv_WebSrvFunctions();
        }
        /// <summary>
        /// 函数功能:把查询数据绑定在GridView上。根据界面上查询控件中所设置内容查询表记录,
        ///			 并显示在GridView中。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenBindGridView)
        /// </summary>
        protected void BindGv_WebSrvFunctions()
        {
            //操作步骤:(共5步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	4、设置GridView的数据源(DataSource)；
            //	5、绑定GridView,即把DataTable的内容显示在GridView中
            //	6、设置记录数的状态,
            //		在本界面中是把状态显示在控件txtRecCount中。

            System.Data.DataTable objDT = null;
            try
            {
                //	1、组合界面条件串；
                string strWhereCond = CombineWebSrvFunctionsCondition();
                //	2、根据条件串获取该表满足条件的DataTable；
                objDT = clsvWebSrvFunctionsBL.GetDataTable_vWebSrvFunctions(strWhereCond);
            }
            catch (Exception objException)
            {
                seErrMessage = "(errid:WebI002915)获取数据表(DataTable)不成功!" + objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            //	4、设置GRIDView的数据源(DataSource)；
            DataView objDV = objDT.DefaultView;
            objDV.Sort = vsSortWebSrvFunctionsBy; ///注意这一行代码有可能需要注释掉,目前这行仅仅在单独的查询界面中起作用
                                                  ///设置GridView中每页的记录数
            if (string.IsNullOrEmpty(PageSize) == false)
            {
                int intPageSize = int.Parse(PageSize);
                gvWebSrvFunctions.PageSize = intPageSize;
            }
            else
            {
                PageSize = "10";
                gvWebSrvFunctions.PageSize = 10;
            }
            this.gvWebSrvFunctions.DataSource = objDV;
            //	5、绑定GridView,即把DataTable的内容显示在GridView中
            this.gvWebSrvFunctions.DataBind();
            List<string> arrQueryFieldName = vsArrQueryFieldName;
            foreach(string strQueryFieldName in arrQueryFieldName)
            {
                clsPubFun.SetGvVisibility(gvWebSrvFunctions, strQueryFieldName, false);
            }
            ///生成专门用于BindGv中的跳页相关代码
            GridViewRow pagerRow = gvWebSrvFunctions.BottomPagerRow;
            if (pagerRow == null)
            {
                return;
            }
            Label lblRecCount = (Label)pagerRow.FindControl("lblRecCount");
            Label lblAllPages = (Label)pagerRow.FindControl("lblAllPages");
            Label lblCurrentPage = (Label)pagerRow.FindControl("lblCurrentPage");
            TextBox txtJump2Page = (TextBox)pagerRow.FindControl("txtJump2Page");
            Button btnNextPage = (Button)pagerRow.FindControl("btnNextPage");
            Button btnPrevPage = (Button)pagerRow.FindControl("btnPrevPage");
            Button tabJumpPage = (Button)pagerRow.FindControl("tabJumpPage");
            DropDownList ddlPagerRecCount = (DropDownList)pagerRow.FindControl("ddlPagerRecCount");
            if (lblRecCount != null)
            {
                //当前记录数
                lblRecCount.Text = objDT.Rows.Count.ToString();
                //当前页数
                lblAllPages.Text = this.gvWebSrvFunctions.PageCount.ToString();
                //当前页序数
                lblCurrentPage.Text = (this.gvWebSrvFunctions.PageIndex + 1).ToString();
                //当前即将跳到的页序数
                txtJump2Page.Text = (this.gvWebSrvFunctions.PageIndex + 1).ToString();
                //如果当前页序数为0,则<前一页>按钮无效
                if (this.gvWebSrvFunctions.PageIndex == 0)
                {
                    btnPrevPage.Enabled = false;
                }
                else
                {
                    btnPrevPage.Enabled = true;
                }
                //如果当前页序数已为最后一页,则<前一页>按钮无效
                if (this.gvWebSrvFunctions.PageIndex == this.gvWebSrvFunctions.PageCount - 1)
                {
                    btnNextPage.Enabled = false;
                }
                else
                {
                    btnNextPage.Enabled = true;
                }
                //设置分页器中每页记录数的下拉框的值
                if (string.IsNullOrEmpty(PageSize) == false)
                {
                    ddlPagerRecCount.Text = PageSize;
                }
                else
                {
                    PageSize = "10";
                    ddlPagerRecCount.Text = PageSize;
                }
            }
            gvWebSrvFunctions.BottomPagerRow.Visible = true;
        }



        /// <summary>
        /// 事件函数:生成与跳页的相关函数.在GridView的脚部，当单击跳转按钮时发生的事件，在这里主要处理:跳转到GridView的某一数。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenJumpPage_RelaFunction)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void btnJumpPage_Click(object sender, EventArgs e)
        {
            GridViewRow pagerRow = gvWebSrvFunctions.BottomPagerRow;
            TextBox txtJump2Page = (TextBox)pagerRow.FindControl("txtJump2Page");
            if (txtJump2Page != null)
            {
                if (txtJump2Page.Text.Trim() != "" &&
                int.Parse(txtJump2Page.Text) > 0 &&
                int.Parse(txtJump2Page.Text) - 1 < this.gvWebSrvFunctions.PageCount)
                {
                    this.gvWebSrvFunctions.PageIndex = int.Parse(txtJump2Page.Text) - 1;
                }
                this.BindGv_WebSrvFunctions();
            }
        }


        /// <summary>
        /// 事件函数:在GridView的脚部，当每页记录数的下拉框发生改变时发生的事件，在这里主要处理:改变GridView的每页记录数。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenddlPagerRecCount_SelectedIndexChanged)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void ddlPagerRecCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList ddlPagerRecCount = (DropDownList)sender;
            string strPageSize = ddlPagerRecCount.Text;
            if (clsDateTime.IsNumeric(strPageSize) == true)
            {
                int intPageSize = int.Parse(strPageSize);
                if (intPageSize >= 1)
                {
                    PageSize = intPageSize.ToString();
                    BindGv_WebSrvFunctions();
                }
            }
        }

        /// <summary>
        /// 事件函数:在GridView中，当单击GeidView行中的命令按钮时发生的事件，在这里主要处理:在列头显示单击全选按钮时全选GridView的所有行。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_GridView_RowCommand)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void gvWebSrvFunctions_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            string strCommandName = e.CommandName;
            switch (strCommandName)
            {
                case "lbSelAll":
                    System.Web.UI.WebControls.LinkButton lbSelAll;
                    lbSelAll = (LinkButton)e.CommandSource;
                    if (lbSelAll.CommandName != "lbSelAll")
                    {
                        return;
                    }
                    if (lbSelAll.Text == "全选")
                    {
                        clsCommForWebForm.Set_GridViewAllChecked(gvWebSrvFunctions, true);
                        lbSelAll.Text = "不选";
                    }
                    else if (lbSelAll.Text == "不选")
                    {
                        clsCommForWebForm.Set_GridViewAllChecked(gvWebSrvFunctions, false);
                        lbSelAll.Text = "全选";
                    }
                    break;
            }
        }
        /// <summary>
        /// 事件函数:在GridView中，当GeidView行建立时发生的事件，在这里主要处理:数据行中处理删除时显示提示信息，还有在列头显示排序标志。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_GridView_RowCreated)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void gvWebSrvFunctions_RowCreated(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                System.Web.UI.WebControls.LinkButton myDeleteButton;
                myDeleteButton = (System.Web.UI.WebControls.LinkButton)e.Row.FindControl("lbDelete");
                if (myDeleteButton != null)
                {
                    myDeleteButton.Attributes.Add("onclick", "return confirm('您真的要删除第 " + (e.Row.RowIndex + 1).ToString() + " 行吗？');");
                }
            }
            int intIndex;
            if (vsSortWebSrvFunctionsBy == "") return;
            if (e.Row.RowType == DataControlRowType.Header)//点击控件是否为页眉；
            {
                string strSortEx;
                for (int i = 0; i < this.gvWebSrvFunctions.Columns.Count; i++)
                {
                    strSortEx = this.gvWebSrvFunctions.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = vsSortWebSrvFunctionsBy.IndexOf(strSortEx + " ");
                    if (intIndex >= 0) //视图状态的排序表达式是否为该列的字段；
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//设置字体,在"webdings"中5是上三角,6是下三角；
                        intIndex = vsSortWebSrvFunctionsBy.IndexOf("Asc");
                        lblSort.Text = (intIndex > 0 ? " 5" : " 6");//是否为升序,而且为string型；
                        e.Row.Cells[i].Controls.Add(lblSort);//被引用项的第i个单元格中增添一控件；
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// 函数功能:事件函数,在更改GridView的当前页索引时激发的函数。
        ///			 具体功能是重新显示新页(所单击页索引)的内容。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_GridView_PageIndexChanging)
        /// </summary>
        /// <param name = "source"></param>
        /// <param name = "e"></param>
        protected void gvWebSrvFunctions_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            //操作步骤:(共2步)
            //1、设置当前页的页索引,即把新单击的页索引赋给当前页索引
            //2、重新绑定GridView,使之内容更新,变化到新的页

            if (e.NewPageIndex != -1)
            {
                //1、设置当前页的页索引,即把新单击的页索引赋给当前页索引
                gvWebSrvFunctions.PageIndex = e.NewPageIndex;
                //2、重新绑定GridView,使之内容更新,变化到新的页
                this.BindGv_WebSrvFunctions();
            }
        }
        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenCombineCondition)
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        protected string CombineWebSrvFunctionsCondition()
        {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && UserName = '张三'
            string strWhereCond = string.Format(" {0} = '{1}' ", convWebSrvFunctions.PrjId, clsPubVar.CurrSelPrjId); ;
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try
            {       
                List<string> arrQueryFieldName = vsArrQueryFieldName;
                foreach (string strQueryFieldName in arrQueryFieldName)
                {
                    clsPubFun.SetGvVisibility(gvWebSrvFunctions, strQueryFieldName, true);
                }
                arrQueryFieldName.Clear();
                if (this.txtFunctionNameq.Text.Trim() != "")
                {
                    strWhereCond += string.Format(" And {0} like '%{1}%'", convWebSrvFunctions.FunctionName, this.txtFunctionNameq.Text.Trim());
                    clsPubFun4Web.AddQueryFieldName(arrQueryFieldName, convWebSrvFunctions.FunctionName);
                }
                if (this.ddlIsAsyncFunc.SelectedIndex == 1)
                {
                    strWhereCond += string.Format(" And {0} = '1'", convWebSrvFunctions.IsAsyncFunc);
                    clsPubFun4Web.AddQueryFieldName(arrQueryFieldName, convWebSrvFunctions.IsAsyncFunc);
                }
                else if (this.ddlIsAsyncFunc.SelectedIndex == 2)
                {
                    strWhereCond += string.Format(" And {0} = '0'", convWebSrvFunctions.IsAsyncFunc);
                    clsPubFun4Web.AddQueryFieldName(arrQueryFieldName, convWebSrvFunctions.IsAsyncFunc);
                }
                //if (this.txtGetCustomAttributesq.Text.Trim() != "")
                //{
                //    strWhereCond += string.Format(" And {0} like '%{1}%'", convWebSrvFunctions.GetCustomAttributes, this.txtGetCustomAttributesq.Text.Trim());
                //    clsPubFun4Web.AddQueryFieldName(arrQueryFieldName, convWebSrvFunctions.GetCustomAttributes);

                //}
                //if (this.ddlFuncTypeIDq.SelectedValue != "" && this.ddlFuncTypeIDq.SelectedValue != "0")
                //{
                //    strWhereCond += string.Format(" And {0} = '{1}'", convWebSrvFunctions.FuncTypeId, this.ddlFuncTypeIDq.SelectedValue);
                //    clsPubFun4Web.AddQueryFieldName(arrQueryFieldName, convWebSrvFunctions.FuncTypeName);

                //}
                if (this.ddlWebSrvClassIdq.SelectedValue != "" && this.ddlWebSrvClassIdq.SelectedValue != "0")
                {
                    strWhereCond += string.Format(" And {0} = '{1}'", convWebSrvFunctions.WebSrvClassId, this.ddlWebSrvClassIdq.SelectedValue);
                    clsPubFun4Web.AddQueryFieldName(arrQueryFieldName, convWebSrvFunctions.ClsName);
                }
                if (this.txtWebSrvUrlq.Text.Trim() != "")
                {
                    strWhereCond += string.Format(" And {0} like '%{1}%'", convWebSrvFunctions.WebSrvUrl, this.txtWebSrvUrlq.Text.Trim());
                    clsPubFun4Web.AddQueryFieldName(arrQueryFieldName, convWebSrvFunctions.WebSrvUrl);

                }
                vsArrQueryFieldName = arrQueryFieldName;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:WebI002916)在组合查询条件(CombineWebSrvFunctionsCondition)时出错!请联系管理员!" + objException.Message);
                throw new Exception(strMsg);
            }
            return strWhereCond;
        }

        /// <summary>
        /// 专门用于记录GridView中的每页记录数
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPageSizeViewState)
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

        #endregion 查询相关函数


        #region 排序相关函数
        /// <summary>
        /// 事件函数:在GridView中，单击列头进行排序所发生的事件
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_GridView_Sorting)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void gvWebSrvFunctions_Sorting(object sender, GridViewSortEventArgs e)
        {
            int intIndex;
            //判断是否是新的排序字段
            intIndex = vsSortWebSrvFunctionsBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                vsSortWebSrvFunctionsBy = e.SortExpression + " Asc";
                BindGv_WebSrvFunctions();
                return;
            }
            //检查原来是升序
            intIndex = vsSortWebSrvFunctionsBy.IndexOf(" Asc");
            if (intIndex == -1)     //如果原来不是升序就设置为升序
            {
                vsSortWebSrvFunctionsBy = e.SortExpression + " Asc";
            }
            else            ///否则设置为降序
            {
                vsSortWebSrvFunctionsBy = e.SortExpression + " Desc";
            }
            BindGv_WebSrvFunctions();
        }

        /// <summary>
        /// 用于记录GridView中的当前排序表达式,以便决定下一次是升序,还是降序排序。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_GridView_Sorting)
        /// </summary>
        protected string vsSortWebSrvFunctionsBy
        {
            get
            {
                string sSortWebSrvFunctionsBy;
                sSortWebSrvFunctionsBy = (string)ViewState["SortWebSrvFunctionsBy"];
                if (sSortWebSrvFunctionsBy == null)
                {
                    sSortWebSrvFunctionsBy = "";
                }
                return sSortWebSrvFunctionsBy;
            }
            set
            {
                string sSortWebSrvFunctionsBy = value;
                ViewState.Add("SortWebSrvFunctionsBy", sSortWebSrvFunctionsBy);
            }
        }
        #endregion 排序相关函数


        #region 添加相关函数

        ///添加新记录的事件过程,建议在该过程中调用其他函数,不要在其中添加多行代码。
        protected void btnAddNewRec4Gv_Click(object sender, System.EventArgs e)
        {
            AddWebSrvFunctionsRecord();
        }
        /// <summary>
        /// 为插入记录做准备工作
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenAddRecordCode)
        /// </summary>
        protected void AddWebSrvFunctionsRecord()
        {
            wucWebSrvFunctionsB1.SetKeyReadOnly(false);
            btnOKUpd.Text = "确认添加";
            btnCancelWebSrvFunctionsEdit.Text = "取消添加";
            //wucWebSrvFunctionsB1.WebSrvFunctionId = clsWebSrvFunctionsBL.GetMaxStrId_S();
            DispEditWebSrvFunctionsRegion();
        }
        /// <summary>
        /// 插入记录存盘到数据表中
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenAddRecordSaveCode)
        /// </summary>
        /// <returns>插入记录是否成功？</returns>
        protected bool AddWebSrvFunctionsRecordSave()
        {
            //操作步骤:
            //1、检查控件中输入数据类型是否正确
            //2、定义对象并初始化对象
            //3.1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            //3.2、检查唯一性
            //4、把值从界面层传到逻辑层或数据实体层
            //5、检查传进去的对象属性是否合法
            //6、把数据实体层的数据存贮到数据库中
            //7、把新添的记录内容显示在GridView中
            string strMsg;  //专门用于传递信息的变量
            string strResult = " "; //用于传递在检验对象属性时结果值的变量
            clsWebSrvFunctionsEN objWebSrvFunctionsEN;
            //1、检查控件中输入数据类型是否正确
            if (!wucWebSrvFunctionsB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI002917)控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、定义对象并初始化对象
            //clsWebSrvFunctionsEN objWebSrvFunctionsEN;	//定义对象
            objWebSrvFunctionsEN = new clsWebSrvFunctionsEN(wucWebSrvFunctionsB1.WebSrvFunctionId); //初始化新对象
                                                                                                    //3.1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            if (clsWebSrvFunctionsBL.IsExist(objWebSrvFunctionsEN.WebSrvFunctionId))    //判断是否有相同的关键字
            {
                strMsg = "(errid:WebI002918)关键字字段已有相同的值";
                clsCommonJsFunc.Alert(this, strMsg);
                return false;
            }
            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToWebSrvFunctionsClass(objWebSrvFunctionsEN);        //把界面的值传到
                                                                        //5.1、检查传进去的对象属性是否合法
            try
            {
                clsWebSrvFunctionsBL.CheckPropertyNew(objWebSrvFunctionsEN);
                //6、把数据实体层的数据存贮到数据库中
                clsWebSrvFunctionsBL.AddNewRecordBySql2(objWebSrvFunctionsEN);
            }
            catch (Exception objException)
            {
                strMsg = "(errid:WebI002919)添加记录不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgEdit.Text = strMsg;
                return false;
            }
            strMsg = "添加记录成功!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsgEdit.Text = "添加记录成功!";
            //7、把新添的记录内容显示在GridView中
            BindGv_WebSrvFunctions();
            DispWebSrvFunctionsListRegion();
            wucWebSrvFunctionsB1.Clear();       //清空控件中内容
                                                ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelWebSrvFunctionsEdit.Text = "取消编辑";
            return true;
        }
        /// <summary>
        /// 插入记录存盘到数据表中,V5版
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenAddRecordSaveCodeV5)
        /// </summary>
        /// <returns>插入记录是否成功？</returns>
        protected bool AddWebSrvFunctionsRecordSaveV5()
        {
            //操作步骤:
            //1、检查控件中输入数据类型是否正确
            //2、定义对象并初始化对象
            //3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            //4、把值从界面层传到逻辑层或数据实体层
            //5、检查传进去的对象属性是否合法
            //6、把数据实体层的数据存贮到数据库中
            //7、把新添的记录内容显示在GridView中
            string strMsg;  //专门用于传递信息的变量
            string strResult = " "; //用于传递在检验对象属性时结果值的变量
            clsWebSrvFunctionsEN objWebSrvFunctionsEN;
            //1、检查控件中输入数据类型是否正确
            if (!wucWebSrvFunctionsB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI002920)控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、定义对象并初始化对象
            //clsWebSrvFunctionsEN objWebSrvFunctionsEN;	//定义对象
            objWebSrvFunctionsEN = new clsWebSrvFunctionsEN(wucWebSrvFunctionsB1.WebSrvFunctionId); //初始化新对象
                                                                                                    //3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            if (clsWebSrvFunctionsBL.IsExist(objWebSrvFunctionsEN.WebSrvFunctionId))    //判断是否有相同的关键字
            {
                strMsg = "(errid:WebI002921)关键字字段已有相同的值";
                clsCommonJsFunc.Alert(this, strMsg);
                return false;
            }
            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToWebSrvFunctionsClass(objWebSrvFunctionsEN);        //把界面的值传到
                                                                        //5.1、检查传进去的对象属性是否合法
            try
            {
                clsWebSrvFunctionsBL.CheckPropertyNew(objWebSrvFunctionsEN);
                //6、把数据实体层的数据存贮到数据库中
                clsWebSrvFunctionsBL.AddNewRecordBySql2(objWebSrvFunctionsEN);
            }
            catch (Exception objException)
            {
                seErrMessage = "(errid:WebI002922)添加记录不成功!" + objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            strMsg = "添加记录成功!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsgEdit.Text = "添加记录成功!";
            //7、把新添的记录内容显示在GridView中
            BindGv_WebSrvFunctions();
            DispWebSrvFunctionsListRegion();
            wucWebSrvFunctionsB1.Clear();       //清空控件中内容
                                                ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelWebSrvFunctionsEdit.Text = "取消编辑";
            return true;
        }
        #endregion 添加相关函数


        #region 修改相关函数

        /// <summary>
        ///修改当前被选记录
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenbtnUpdate4Gv_Click4OneKeyword)
        /// </summary>
        protected void btnUpdate4Gv_Click(object sender, System.EventArgs e)
        {
            List<string> lstWebSrvFunctionId = clsCommForWebForm.GetFirstCheckedItemFromGv(gvWebSrvFunctions, "WebSrvFunctionId");
            if (lstWebSrvFunctionId.Count == 0)
            {
                lblMsgList.Text = "(errid:WebI002923)没有选择记录,请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；
            string strWebSrvFunctionId = lstWebSrvFunctionId[0];
            UpdateWebSrvFunctionsRecord(strWebSrvFunctionId);
        }
        ///
        protected void gvWebSrvFunctions_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string strWebSrvFunctionId = gvWebSrvFunctions.DataKeys[e.RowIndex]["WebSrvFunctionId"].ToString();
            UpdateWebSrvFunctionsRecord(strWebSrvFunctionId);
        }

        /// <summary>
        /// 函数功能:把以该关键字的记录内容显示在界面上,
        ///　　　   在这里是把值传到表控件中
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenShowDataCode)
        /// </summary>
        /// <param name = "strWebSrvFunctionId">表记录的关键字,显示该表关键字的内容</param>
        protected void ShowData(string strWebSrvFunctionId)
        {
            //操作步骤:
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中

            //1、检查关键字是否为空；
            if (strWebSrvFunctionId == "") return;      //如果关键字为空就返回退出
                                                        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            if (clsWebSrvFunctionsBL.IsExist(strWebSrvFunctionId) == false)     //检查该关键字的记录是否存在
            {
                string strMsg = "(errid:WebI002924)在表[WebSrvFunctions]中,关键字为:[strWebSrvFunctionId]的记录不存在!";
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            //3、用提供的关键字初始化一个类对象；
            clsWebSrvFunctionsEN objWebSrvFunctionsEN = new clsWebSrvFunctionsEN(strWebSrvFunctionId);
            //4、获取类对象的所有属性；
            try
            {
                clsWebSrvFunctionsBL.GetWebSrvFunctions(ref objWebSrvFunctionsEN);
            }
            catch (Exception objException)
            {
                seErrMessage = objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            Session.Add("objWebSrvFunctionsEN", objWebSrvFunctionsEN);
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
            GetDataFromWebSrvFunctionsClass(objWebSrvFunctionsEN);
        }
        /// <summary>
        /// 函数功能:把类对象的属性内容显示到界面上
        ///注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
        /// 如果在设置数据库时,就应该一级字段在前,二级字段在后
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenGetDataFromClass)
        /// </summary>
        /// <param name = "pobjWebSrvFunctionsEN">表实体类对象</param>
        protected void GetDataFromWebSrvFunctionsClass(clsWebSrvFunctionsEN pobjWebSrvFunctionsEN)
        {
            wucWebSrvFunctionsB1.WebSrvFunctionId = pobjWebSrvFunctionsEN.WebSrvFunctionId;// 函数Id
            wucWebSrvFunctionsB1.WebSrvClassId = pobjWebSrvFunctionsEN.WebSrvClassId;// 类Id
            wucWebSrvFunctionsB1.FunctionName = pobjWebSrvFunctionsEN.FunctionName;// 功能名称
            wucWebSrvFunctionsB1.GetCustomAttributes = pobjWebSrvFunctionsEN.GetCustomAttributes;// GetCustomAttributes
            wucWebSrvFunctionsB1.FunctionSignature = pobjWebSrvFunctionsEN.FunctionSignature;// 函数签名
            wucWebSrvFunctionsB1.FuncTypeId = pobjWebSrvFunctionsEN.FuncTypeId;// 函数类型ID
            wucWebSrvFunctionsB1.UpdDate = pobjWebSrvFunctionsEN.UpdDate;// 修改日期
            wucWebSrvFunctionsB1.UpdUser = pobjWebSrvFunctionsEN.UpdUser;// 修改者
            wucWebSrvFunctionsB1.Memo = pobjWebSrvFunctionsEN.Memo;// 说明
        }
        /// <summary>
        /// 为修改记录做准备过程,把给定关键字的记录字段值显示在用户控件上
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenUpdateRecordCode)
        /// </summary>
        protected void UpdateWebSrvFunctionsRecord(string strWebSrvFunctionId)
        {
            //操作步骤:(总共2步)
            //1、显示该关键字记录的内容在界面上；
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；

            //1、显示该关键字记录的内容在界面上；
            ShowData(strWebSrvFunctionId);
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；
            btnOKUpd.Enabled = true;
            wucWebSrvFunctionsB1.SetKeyReadOnly(true);
            btnOKUpd.Text = "确认修改";
            btnCancelWebSrvFunctionsEdit.Text = "取消修改";
            lblMsgEdit.Text = "";
            DispEditWebSrvFunctionsRegion();
        }
        /// <summary>
        /// 修改记录存盘到数据表中
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenUpdateRecordSaveCode)
        /// </summary>
        /// <param name = "objWebSrvFunctionsEN">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        protected bool UpdateWebSrvFunctionsRecordSave(clsWebSrvFunctionsEN objWebSrvFunctionsEN)
        {
            //操作步骤:
            //1、检查控件中输入数据类型是否正确
            //2、把值从界面层传到逻辑层或数据实体层
            //3.1、检查传进去的对象属性是否合法
            //3.2、检查唯一性
            //4、把数据实体层的数据存贮到数据库中
            //5、把修改后的内容显示在GridView中
            string strMsg;  //专门用于传递信息的变量
            string strResult = " "; //用于传递在检验对象属性时结果值的变量
                                    //1、检查控件中输入数据类型是否正确
            if (!wucWebSrvFunctionsB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI002925)控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToWebSrvFunctionsClass(objWebSrvFunctionsEN);        //把界面的值传到
                                                                        //3.1、检查传进去的对象属性是否合法
            try
            {
                clsWebSrvFunctionsBL.CheckPropertyNew(objWebSrvFunctionsEN);
                //4、把数据实体层的数据存贮到数据库中
                clsWebSrvFunctionsBL.UpdateBySql2(objWebSrvFunctionsEN);
            }
            catch (Exception objException)
            {
                strMsg = "修改记录不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgEdit.Text = strMsg;
                return false;
            }
            strMsg = "修改记录成功!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsgEdit.Text = "修改记录成功!";
            //5、把修改后的内容显示在GridView中
            BindGv_WebSrvFunctions();
            DispWebSrvFunctionsListRegion();
            wucWebSrvFunctionsB1.Clear();//添空控件中的内容
                                         //恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelWebSrvFunctionsEdit.Text = "取消编辑";
            //跳转到列表中刚刚的记录处,使用锚点功能。
            this.ClientScript.RegisterStartupScript(this.GetType(), "Go-Anchor", string.Format("this.location.href = '#A_WebSrvFunctions{0}'", objWebSrvFunctionsEN.WebSrvFunctionId.ToString().Trim()), true);
            return true;
        }
        /// <summary>
        /// 修改记录存盘到数据表中, V5版
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenUpdateRecordSaveCodeV5)
        /// </summary>
        /// <param name = "objWebSrvFunctionsEN">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        protected bool UpdateWebSrvFunctionsRecordSaveV5(clsWebSrvFunctionsEN objWebSrvFunctionsEN)
        {
            //操作步骤:
            //1、检查控件中输入数据类型是否正确
            //2、把值从界面层传到逻辑层或数据实体层
            //3.1、检查传进去的对象属性是否合法
            //4、把数据实体层的数据存贮到数据库中
            //5、把修改后的内容显示在GridView中
            string strMsg;  //专门用于传递信息的变量
            string strResult = " "; //用于传递在检验对象属性时结果值的变量
                                    //1、检查控件中输入数据类型是否正确
            if (!wucWebSrvFunctionsB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI002926)控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToWebSrvFunctionsClass(objWebSrvFunctionsEN);        //把界面的值传到
                                                                        //3.1、检查传进去的对象属性是否合法
            try
            {
                clsWebSrvFunctionsBL.CheckPropertyNew(objWebSrvFunctionsEN);
                //4、把数据实体层的数据存贮到数据库中
                clsWebSrvFunctionsBL.UpdateBySql2(objWebSrvFunctionsEN);
            }
            catch (Exception objException)
            {
                seErrMessage = "修改记录不成功!" + objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            strMsg = "修改记录成功!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsgEdit.Text = "修改记录成功!";
            //5、把修改后的内容显示在GridView中
            BindGv_WebSrvFunctions();
            DispWebSrvFunctionsListRegion();
            wucWebSrvFunctionsB1.Clear();//添空控件中的内容
                                         //恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelWebSrvFunctionsEdit.Text = "取消编辑";
            //跳转到列表中刚刚的记录处,使用锚点功能。
            this.ClientScript.RegisterStartupScript(this.GetType(), "Go-Anchor", string.Format("this.location.href = '#A_WebSrvFunctions{0}'", objWebSrvFunctionsEN.WebSrvFunctionId.ToString().Trim()), true);
            return true;
        }
        #endregion 修改相关函数


        #region 添加修改共用函数
        /// <summary>
        /// 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
        /// 具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenbtnOKUpd_ClickCode)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void btnOKUpd_Click(object sender, System.EventArgs e)
        {
            string strCommandText;
            clsWebSrvFunctionsEN objWebSrvFunctionsEN;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "添加":
                    AddWebSrvFunctionsRecord();
                    break;
                case "确认添加":
                    //这是一个单表的插入的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    AddWebSrvFunctionsRecordSave();
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    objWebSrvFunctionsEN = (clsWebSrvFunctionsEN)Session["objWebSrvFunctionsEN"];
                    UpdateWebSrvFunctionsRecordSave(objWebSrvFunctionsEN);
                    break;
            }
        }
        /// <summary>
        /// 事件函数:取消编辑状态，退回到列表状态
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_btnCancelEdit_Click)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void btnCancelWebSrvFunctionsEdit_Click(object sender, EventArgs e)
        {
            DispWebSrvFunctionsListRegion();
        }
        /// <summary>
        /// 函数功能:把界面上的属性数据传到类对象中
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPutDataToClass)
        /// </summary>
        /// <param name = "pobjWebSrvFunctionsEN">数据传输的目的类对象</param>
        protected void PutDataToWebSrvFunctionsClass(clsWebSrvFunctionsEN pobjWebSrvFunctionsEN)
        {
            pobjWebSrvFunctionsEN.WebSrvFunctionId = wucWebSrvFunctionsB1.WebSrvFunctionId;// 函数Id
            pobjWebSrvFunctionsEN.WebSrvClassId = wucWebSrvFunctionsB1.WebSrvClassId;// 类Id
            pobjWebSrvFunctionsEN.FunctionName = wucWebSrvFunctionsB1.FunctionName;// 功能名称
            pobjWebSrvFunctionsEN.GetCustomAttributes = wucWebSrvFunctionsB1.GetCustomAttributes;// GetCustomAttributes
            pobjWebSrvFunctionsEN.FunctionSignature = wucWebSrvFunctionsB1.FunctionSignature;// 函数签名
            pobjWebSrvFunctionsEN.FuncTypeId = wucWebSrvFunctionsB1.FuncTypeId;// 函数类型ID
            pobjWebSrvFunctionsEN.UpdDate = wucWebSrvFunctionsB1.UpdDate;// 修改日期
            pobjWebSrvFunctionsEN.UpdUser = wucWebSrvFunctionsB1.UpdUser;// 修改者
            pobjWebSrvFunctionsEN.Memo = wucWebSrvFunctionsB1.Memo;// 说明
        }

        #endregion 添加修改共用函数


        #region 删除相关函数

        /// <summary>
        ///删除当前被选记录
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenbtnDelete4Gv_Click4OneKeyword)
        /// </summary>
        protected void btnDelete4Gv_Click(object sender, System.EventArgs e)
        {
            List<string> lstWebSrvFunctionId = clsCommForWebForm.GetAllCheckedItemFromGv(gvWebSrvFunctions, "chkCheckRec", "WebSrvFunctionId");
            if (lstWebSrvFunctionId.Count == 0)
            {
                lblMsgList.Text = "(errid:WebI002927)没有选择记录,请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            try
            {
                foreach (string strWebSrvFunctionId in lstWebSrvFunctionId)
                {
                    clsWebSrvFunctionsBL.DelRecord(strWebSrvFunctionId);
                }
            }
            catch (Exception objException)
            {
                seErrMessage = objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            BindGv_WebSrvFunctions();
        }
        /// <summary>
        /// 事件函数:在GridView中，进行行删除(RowDeleting)
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_GridView_RowDeleting)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void gvWebSrvFunctions_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string strWebSrvFunctionId = gvWebSrvFunctions.DataKeys[e.RowIndex]["WebSrvFunctionId"].ToString();
            DeleteWebSrvFunctionsRecord(strWebSrvFunctionId);
        }
        /// <summary>
        /// 根据给定关键字删除记录
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDeleteRecordCode)
        /// </summary>
        /// <param name = "strWebSrvFunctionId">给定关键字</param>
        protected void DeleteWebSrvFunctionsRecord(string strWebSrvFunctionId)
        {
            try
            {
                clsWebSrvFunctionsBL.DelRecord(strWebSrvFunctionId);
            }
            catch (Exception objException)
            {
                seErrMessage = objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            BindGv_WebSrvFunctions();
        }
        #endregion 删除相关函数


        #region 导出函数

        /// <summary>
        /// 事件函数:把查询条件的表记录，导出到Excel.
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void btnExportExcel4Gv_Click(object sender, System.EventArgs e)
        {
            //导出Excel函数
            ExportExcel();
        }


        /// <summary>
        /// 导出Excel。根据查询区组合的查询条件,从[vWebSrvFunctions]表中获取记录集,最终导出到Excel
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenExportExcel)
        /// </summary>
        private void ExportExcel()
        {
            //	1、组合界面条件串；
            string strWhereCond = CombineWebSrvFunctionsCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "WebSrvFunctions信息导出.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add(convWebSrvFunctions.WebSrvFunctionId); arrCnName.Add("函数Id");
            arrColName.Add(convWebSrvFunctions.NameSpace); arrCnName.Add("域名");
            arrColName.Add(convWebSrvFunctions.ClsName); arrCnName.Add("类名");
            arrColName.Add(convWebSrvFunctions.FunctionName); arrCnName.Add("功能名称");
            arrColName.Add(convWebSrvFunctions.GetCustomAttributes); arrCnName.Add("GetCustomAttributes");
            arrColName.Add(convWebSrvFunctions.FunctionSignature); arrCnName.Add("函数签名");
            arrColName.Add(convWebSrvFunctions.FuncTypeId); arrCnName.Add("函数类型ID");
            arrColName.Add(convWebSrvFunctions.FuncTypeName); arrCnName.Add("函数类型名");
            arrColName.Add(convWebSrvFunctions.UpdDate); arrCnName.Add("修改日期");
            arrColName.Add(convWebSrvFunctions.UpdUser); arrCnName.Add("修改者");
            arrColName.Add(convWebSrvFunctions.Memo); arrCnName.Add("说明");
            arrColName.Add(convWebSrvFunctions.WebSrvClassId); arrCnName.Add("类Id");
            arrColName.Add(convWebSrvFunctions.WebSrvUrl); arrCnName.Add("WebSrv地址");
            strFolderName = clsSysParaEN.TempFileFolder;
            strDownLoadFileName = strFolderName + strFileName;
            //初始化需要导出的Excel文件,即复制标准Excel文件作为母版,复制不成功即不能导出
            if (clsPubVar.InitExcelFile(this, strFolderName, strDownLoadFileName) == false)
            {
                return;
            }
            try
            {
                //	2、根据条件串获取该表满足条件的DataTable；
                objDT = clsvWebSrvFunctionsBL.GetDataTable(strWhereCond);
                //用户Odbc的方式来导出Excel,在Web服务器不需要安装Excel,目前是Excel2003,如果希望2007,可以换下面一条语句。
                GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4Odbc(objDT, arrColName, arrCnName, strDownLoadFileName);
                //GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4OdbcExcel2007(objDT, arrColName, arrCnName, strDownLoadFileName);
                //GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr(objDT, arrColName, arrCnName, strDownLoadFileName);
            }
            catch (Exception objException)
            {
                seErrMessage = objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            clsCommForWebForm.DownLoadFile(strDownLoadFileName);
        }
        #endregion 导出函数


        #region 布局控制函数
        /// <summary>
        /// 布局控制函数,显示用于编辑的用户控件,并隐藏数据列表区
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDispListAndEditRegion)
        /// </summary>
        private void DispEditWebSrvFunctionsRegion()
        {
            divList.Visible = false;
            tabEditWebSrvFunctionsRegion.Visible = true;
            divCode.Visible = false;
        }
        /// <summary>
        /// 布局控制函数,显示数据列表区,并隐藏用于编辑的用户控件
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDispListAndEditRegion)
        /// </summary>
        private void DispWebSrvFunctionsListRegion()
        {
            divList.Visible = true;
            tabEditWebSrvFunctionsRegion.Visible = false;
        }
        #endregion 布局控制函数


        #region 错误处理函数

        /// <summary>
        /// Session属性:错误信息的Session属性,该Session传递给显示出错页面,显示相应的错误内容。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenErrMessageSession)
        /// </summary>
        protected string seErrMessage
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


        /// <summary>
        /// Session属性:返回链接串的Session属性,该Session用于告诉出错页面,哪一个页面是需要返回的页面。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenBackLinkStrSession)
        /// </summary>
        protected string seBackErrPageLinkStr
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

        #endregion 错误处理函数


        #region 权限处理函数

        /// <summary>
        /// ViewState属性:当前操作的界面功能名称
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPotenceRelaVar)
        /// </summary>
        protected string vsViewName
        {
            get
            {
                string sViewName;
                sViewName = (string)ViewState["ViewName"];
                if (sViewName == null)
                {
                    sViewName = "";
                }
                return sViewName;
            }
            set
            {
                string sViewName = value;
                ViewState.Add("ViewName", sViewName);
            }
        }
        /// <summary>
        /// ViewState属性:当前操作的导出表名称
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPotenceRelaVar)
        /// </summary>
        protected string vsTabName
        {
            get
            {
                string sTabName;
                sTabName = (string)ViewState["TabName"];
                if (sTabName == null)
                {
                    sTabName = "";
                }
                return sTabName;
            }
            set
            {
                string sTabName = value;
                ViewState.Add("TabName", sTabName);
            }
        }
        /// <summary>
        /// QueryString属性:通过QueryString传递过来的UserId参数。这里是样例,大家可以参考这个样例。
        /// 姓名:
        /// 日期:
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPotenceRelaVar)
        /// </summary>
        private string qsUserId
        {
            get
            {
                string strUserId = Request.QueryString["UserId"] ?? "".ToString();
                if ((strUserId != null) && (strUserId != ""))
                {
                    return strUserId;
                }
                else
                {
                    return "";
                }
            }
        }
        /// <summary>
        /// WebSrv类Id
        /// </summary>
        private string qsWebSrvClassId
        {
            get
            {
                string strWebSrvClassId = Request.QueryString["WebSrvClassId"] ?? "".ToString();
                if ((strWebSrvClassId != null) && (strWebSrvClassId != ""))
                {
                    return strWebSrvClassId;
                }
                else
                {
                    return "";
                }
            }
        }

        /// <summary>
        /// 与权限相关的界面编号
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPotenceRelaVar)
        /// </summary>
        protected const string ViewId4Potence = "00260203";     //界面编号


        /// <summary>
        /// ViewState属性:用于记录当前用户在当前界面的权限等级
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPotenceLevelProperty)
        /// </summary>
        protected string vsPotenceLevel
        {
            get
            {
                string sPotenceLevel;
                sPotenceLevel = (string)ViewState["PotenceLevel"];
                if (sPotenceLevel == null)
                {
                    //					sPotenceLevel = new General_Platform_Dll.MenuAndPotence().Get_PotenceLevel(ViewId4Potence);
                    sPotenceLevel = "9";
                    ViewState.Add("PotenceLevel", sPotenceLevel);
                }
                return sPotenceLevel;
            }
        }


        /// <summary>
        /// Session属性:登录的用户ID,用于检查用户权限
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenLoginUserSession)
        /// </summary>
        protected string seUserId
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
        ///if (pobjUser == null) 
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



        #endregion 权限处理函数

        protected void btnSetFuncType_Click(object sender, EventArgs e)
        {
            List<string> lstWebSrvFunctionId = clsCommForWebForm.GetAllCheckedItemFromGv(gvWebSrvFunctions, "chkCheckRec", "WebSrvFunctionId");
            if (lstWebSrvFunctionId.Count == 0)
            {
                lblMsgList.Text = "(errid:WebI002927)没有选择记录,请选择一个有效的表记录!";
                return;
            }
            if (ddlFuncTypeID.SelectedIndex <= 0)
            {
                lblMsgList.Text = "没有选择函数类型,请选择一个有效的函数类型!";
                ddlFuncTypeID.Focus();
                return;
            }
            string strFuncTypeId = ddlFuncTypeID.SelectedValue;
            lblMsgList.Text = "";
            try
            {
                foreach (string strWebSrvFunctionId in lstWebSrvFunctionId)
                {
                    clsWebSrvFunctionsEN objWebSrvFunctionsEN = clsWebSrvFunctionsBL.GetObjByWebSrvFunctionId(strWebSrvFunctionId);
                    objWebSrvFunctionsEN.FuncTypeId = strFuncTypeId;
                    objWebSrvFunctionsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                    objWebSrvFunctionsEN.UpdUser = clsCommonSession.UserId;

                    clsWebSrvFunctionsBL.UpdateBySql2(objWebSrvFunctionsEN);
                }
            }
            catch (Exception objException)
            {
                seErrMessage = objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            BindGv_WebSrvFunctions();
        }

        #region 处理父页面信息
        /// <summary>
        /// WebSrv类Id
        /// </summary>
        protected string vsWebSrvClassId
        {
            get
            {
                string sWebSrvClassId;
                sWebSrvClassId = (string)ViewState["WebSrvClassId"];
                if (sWebSrvClassId == null)
                {
                    sWebSrvClassId = "";
                }
                return sWebSrvClassId;
            }
            set
            {
                string sWebSrvClassId = value;
                ViewState.Add("WebSrvClassId", sWebSrvClassId);
            }
        }
        /// <summary>
        /// 常规函数：预处理QueryString和Session等身份状态信息。
        /// 注释：常规函数-Regular function
        ///       预处理-Pretreatment
        /// </summary>
        private void rf_PretreatmentQueryString()
        {
            try
            {
                if (string.IsNullOrEmpty(qsWebSrvClassId) == false)
                {
                    vsWebSrvClassId = qsWebSrvClassId.ToString();
                }               

                //if (string.IsNullOrEmpty(vsWebSrvClassId) == true )
                //{
                //    clsCommonJsFunc.Alert(this, "传递过来的WebSrvClassId均为空，不正确！请联系管理员！");
                //    throw new Exception("传递过来的WebSrvClassId均为空，不正确！请联系管理员！");
                //}
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }

        }
        #endregion 处理父页面信息

        protected void GenWebServiceTransCode()
        {
            lblMsgList.Text = "";

            if (string.IsNullOrEmpty(vsWebSrvClassId) == true)
            {
                lblMsgList.Text = "没有选择一个WebService记录，请选择一个有效的表记录!";
                return;
            }

            try
            {

                string strRe_ClsName = "";
                string strRe_FileNameWithModuleName = "";
                clsPubConst.ClassName cnClassName = clsPubConst.ClassName.WS_Access;

                string strCodeText = AutoGC.GeneCode4SelfCreateWs(cnClassName, "",
                    vsLangType, vsDataBaseType, vsWebSrvClassId,
                    clsPubVar.CurrSelPrjId,
                    clsPubVar.CurrPrjDataBaseId,
                    clsCommonSession.UserId, ref strRe_ClsName,
                    ref strRe_FileNameWithModuleName);

                //string strCodeText = clsWebSrvFunctionsBLEx_GeneCode.GenWebServiceTransCode(strTabId,
                //    clsPubVar.objCurrSelProject, clsPubVar.CurrPrjDataBaseId,
                //    clsCommonSession.UserId,
                //     clsCommonSession.UserName, "", "",
                //    strCharEncodingId, vsLangType, vsDataBaseType, ref strClsName, ref strCodePath);
                ShowCode(strCodeText);
                txtFileName4GenCode.Text = strRe_ClsName;
                //显示生成代码区域
                DispGenCodeRegion();
            }
            catch (Exception objException)
            {
                //lblErrMsg4AGC.Text = objException.Message;
                ShowCode( objException.Message);
                clsCommonJsFunc.Alert(this, objException.Message);
            }

        }
        protected void lbGeneWebServiceTransCode_Click(object sender, EventArgs e)
        {
            GenWebServiceTransCode();
        }

        /// <summary>
        /// 当前所选择的语言类型：分为： "C#.NET"; "Java";SqlOrOracle
        /// </summary>
        protected clsPubConst.LangType vsLangType
        {
            get
            {
                clsPubConst.LangType strLangType;
                if (ViewState["LangType"] == null)
                {
                    strLangType = clsPubConst.LangType.CSharp;//"C#.NET";
                    return strLangType;
                }
                strLangType = (clsPubConst.LangType)ViewState["LangType"];

                return strLangType;
            }
            set
            {
                clsPubConst.LangType strLangType = value;
                ViewState.Add("LangType", strLangType);
            }
        }


        /// <summary>
        /// 当前所选择的语言类型：分为："Ms Sql", "Oracle"; "MySql";
        /// </summary>
        protected clsPubConst.DataBaseType vsDataBaseType
        {
            get
            {
                clsPubConst.DataBaseType strDataBaseType;

                if (ViewState["DataBaseType"] == null)
                {
                    return clsPubConst.DataBaseType.MsSql;
                }
                strDataBaseType = (clsPubConst.DataBaseType)ViewState["DataBaseType"];
                return strDataBaseType;
            }
            set
            {
                clsPubConst.DataBaseType strDataBaseType = value;
                ViewState.Add("DataBaseType", strDataBaseType);
            }
        }

        //private void Hide_txtCode_Sim()
        //{
        //    txtCode_Sim.Visible = false;
        //    txtCode.Height = 600;

        //}

        /// <summary>
        /// 显示生成代码区域
        /// </summary>
        private void DispGenCodeRegion()
        {
            divList.Visible = false;
            //tabQueryCondition.Visible = false;

            //            divBaseOperate.Visible = false;
            tabCode.Visible = true;
            divCode.Visible = true;
        }
        protected void GenController()
        {
            lblMsgList.Text = "";
            if (string.IsNullOrEmpty(vsWebSrvClassId) == true)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            try
            {
                //string strViewId = "";
                string strRe_ClsName = "";
                string strRe_FileNameWithModuleName = "";
                clsPubConst.ClassName cnClassName = clsPubConst.ClassName.AppController;

                string strCodeText = AutoGC.GeneCode4SelfCreateWs(cnClassName, "", vsLangType, vsDataBaseType, vsWebSrvClassId,
                    clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, clsCommonSession.UserId, ref strRe_ClsName,
                    ref strRe_FileNameWithModuleName);

                //string strCodeText = clsWebSrvFunctionsBLEx_GeneCode.GenController(strTabId,
                //    clsPubVar.objCurrSelProject, clsPubVar.CurrPrjDataBaseId,
                //    clsCommonSession.UserId,
                //     clsCommonSession.UserName, "", "",
                //    strCharEncodingId, vsLangType, vsDataBaseType, ref strClsName, ref strCodePath);
                ShowCode(strCodeText);
                txtFileName4GenCode.Text = strRe_ClsName;
                //显示生成代码区域
                DispGenCodeRegion();
            }
            catch (Exception objException)
            {          
                ShowCode( objException.Message);
                clsCommonJsFunc.Alert(this, objException.Message);
            }
        }
        protected void lbGeneController_Click(object sender, EventArgs e)
        {
            GenController();
           
        }
        protected void GenController4UTScriptCS()
        {
            lblMsgList.Text = "";
            if (string.IsNullOrEmpty(vsWebSrvClassId) == true)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            try
            {
                //string strViewId = "";
                string strRe_ClsName = "";
                string strRe_FileNameWithModuleName = "";
                clsPubConst.ClassName cnClassName = clsPubConst.ClassName.AppViewUTScriptCS;
                string strCodeText = AutoGC.GeneCode4SelfCreateWs(cnClassName, "", vsLangType, vsDataBaseType, vsWebSrvClassId,
                    clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, clsCommonSession.UserId, ref strRe_ClsName,
                    ref strRe_FileNameWithModuleName);
                ShowCode(strCodeText);
                txtFileName4GenCode.Text = strRe_ClsName;
                //显示生成代码区域
                DispGenCodeRegion();
            }
            catch (Exception objException)
            {
                //lblErrMsg4AGC.Text = objException.Message;
                ShowCode( objException.Message);
                clsCommonJsFunc.Alert(this, objException.Message);

            }
        }

        protected void GenController4UTScript()
        {
            lblMsgList.Text = "";
            if (string.IsNullOrEmpty(vsWebSrvClassId) == true)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            try
            {
                //string strViewId = "";
                string strRe_ClsName = "";
                string strRe_FileNameWithModuleName = "";
                clsPubConst.ClassName cnClassName = clsPubConst.ClassName.AppViewUTScript;
                string strCodeText = AutoGC.GeneCode4SelfCreateWs(cnClassName, "", vsLangType, vsDataBaseType, vsWebSrvClassId,
                    clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, clsCommonSession.UserId, ref strRe_ClsName,
                    ref strRe_FileNameWithModuleName);
                ShowCode(strCodeText);
                txtFileName4GenCode.Text = strRe_ClsName;
                //显示生成代码区域
                DispGenCodeRegion();
            }
            catch (Exception objException)
            {
                //lblErrMsg4AGC.Text = objException.Message;
                ShowCode( objException.Message);
                clsCommonJsFunc.Alert(this, objException.Message);

            }
        }

        protected void GenController4UnitTest()
        {
            lblMsgList.Text = "";
            if (string.IsNullOrEmpty(vsWebSrvClassId) == true)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            try
            {
                //string strViewId = "";
                string strRe_ClsName = "";
                string strRe_FileNameWithModuleName = "";
                clsPubConst.ClassName cnClassName = clsPubConst.ClassName.AppViewUnitTest;
                string strCodeText = AutoGC.GeneCode4SelfCreateWs(cnClassName, "", vsLangType, vsDataBaseType, vsWebSrvClassId,
                    clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, clsCommonSession.UserId, ref strRe_ClsName,
                    ref strRe_FileNameWithModuleName);
                ShowCode(strCodeText);
                txtFileName4GenCode.Text = strRe_ClsName;
                //显示生成代码区域
                DispGenCodeRegion();
            }
            catch (Exception objException)
            {
                //lblErrMsg4AGC.Text = objException.Message;
                ShowCode( objException.Message);
                clsCommonJsFunc.Alert(this, objException.Message);

            }
        }
        protected void lbGeneController4UnitTest_Click(object sender, EventArgs e)
        {
            GenController4UnitTest();
           
        }
        protected void GenControllerInvokeWS()
        {
            lblMsgList.Text = "";

            if (string.IsNullOrEmpty(vsWebSrvClassId) == true)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }

            //if (CheckTabFieldBySqlTab(strTabId) == false)
            //{
            //    return;
            //}
            try
            {
                string strRe_ClsName = "";
                string strRe_FileNameWithModuleName = "";
                clsPubConst.ClassName cnClassName = clsPubConst.ClassName.WS_AccessHigh;

                string strCodeText = AutoGC.GeneCode4SelfCreateWs(cnClassName, "", vsLangType, vsDataBaseType, vsWebSrvClassId,
                    clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, clsCommonSession.UserId, ref strRe_ClsName,
                    ref strRe_FileNameWithModuleName);


                //string strCodeText = clsWebSrvFunctionsBLEx_GeneCode.GenControllerInvokeWS(strTabId,
                //    clsPubVar.objCurrSelProject, clsPubVar.CurrPrjDataBaseId,
                //    clsCommonSession.UserId,
                //     clsCommonSession.UserName, "", "",
                //     strCharEncodingId, vsLangType, vsDataBaseType, ref strClsName, ref strCodePath);
                ShowCode(strCodeText);
                txtFileName4GenCode.Text = strRe_ClsName;
                //显示生成代码区域
                DispGenCodeRegion();
            }
            catch (Exception objException)
            {
                //lblErrMsg4AGC.Text = objException.Message;
                ShowCode( objException.Message);
                clsCommonJsFunc.Alert(this, objException.Message);
            }

        }
        protected void lbGeneControllerInvokeWS_Click(object sender, EventArgs e)
        {
            GenControllerInvokeWS();
        }
        protected void lbDispTabList_Click(object sender, EventArgs e)
        {
            DispWebSrvFunctionsListRegion();
        }
        /// <summary>
        /// 当前所选择的语言类型：分为： "C#.NET"; "Java";SqlOrOracle
        /// </summary>
        protected List<string> vsArrQueryFieldName
        {
            get
            {
                List<string> arrQueryFieldName;
                if (ViewState["ArrQueryFieldName"] == null)
                {
                    arrQueryFieldName = new List<string>();
                    return arrQueryFieldName;
                }
                arrQueryFieldName = (List<string>)ViewState["ArrQueryFieldName"];

                return arrQueryFieldName;
            }
            set
            {
                List<string> arrQueryFieldName = value;
                ViewState.Add("ArrQueryFieldName", arrQueryFieldName);
            }
        }

        protected void btnAddToSelfDefDataType_Click(object sender, EventArgs e)
        {
            List<string> lstWebSrvFunctionId = clsCommForWebForm.GetAllCheckedItemFromGv(gvWebSrvFunctions, "chkCheckRec", "WebSrvFunctionId");
            if (lstWebSrvFunctionId.Count == 0)
            {
                lblMsgList.Text = "(errid:WebI003130)没有选择记录,请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            try
            {
                foreach (string strWebSrvFunctionId in lstWebSrvFunctionId)
                {
                    clsWebSrvFunctionsEN objWebSrvFunctionsEN = clsWebSrvFunctionsBL.GetObjByWebSrvFunctionId(strWebSrvFunctionId);
                    clsSelfDefDataTypeBLEx.AddNewSelfDefDataType(objWebSrvFunctionsEN.ReturnType, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                }
                clsSelfDefDataTypeBLEx.p_set_KnownType4Func();
                clsSelfDefDataTypeBLEx.p_set_KnownType4Para();

            }
            catch (Exception objException)
            {
                seErrMessage = objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            BindGv_WebSrvFunctions();
        }
        protected void ImageMap1_Click(object sender, ImageMapEventArgs e)
        {
            switch (e.PostBackValue)
            {
                case "Entity":
                    //GeneEntityLayer();
                    break;
                case "DAL":
                    //GenDALCode();
                    break;

                case "DALEx":
                    //GenDALExCode();
                    break;
                case "Business":
                    //BusinessLogicCode();
                    break;
                case "BusinessEx":
                    //GeneBusinessLogicExCode();
                    break;
                case "CommFun4BL":
                    //GeneCommFun4BL();
                    break;
                case "WebService":
                    //GeneWebServiceCode();
                    break;

                case "WS_Access":
                    GenWebServiceTransCode();
                    break;
                case "WS_AccessHigh":
                    GenControllerInvokeWS();
                    break;
                case "AppController":
                    GenController();
                    break;
                case "AppViewUnitTest":
                    GenController4UnitTest();
                    break;
                case "AppViewUTScript":
                    GenController4UTScript();
                    break;
                case "AppViewUTScriptCS":
                    GenController4UTScriptCS();
                    break;
                case "Dict_PageName_Dir":
                    //GeneDict_PageName_Dir();
                    break;

                default:
                    clsCommonJsFunc.Alert(this, e.PostBackValue);
                    break;                  
            }
        }
        public void ShowCode(string strCode)
        {
            StringBuilder sbJs = new StringBuilder();
            //sbJs.Append("<script type=\"text/javascript\">");
            sbJs.AppendFormat("<textarea style=\"width: 100%; height: 720px; \">", strCode);
            sbJs.AppendFormat("{0}", strCode);
            sbJs.AppendFormat("</textarea>", strCode);
            //sbJs.Append("</script>");
            litCode.Text = sbJs.ToString();
        }
    }
}