﻿
//----------------------
//生成代码版本：2015.10.01.1
//生成日期：2016/01/01
//生成者：潘以锋
//工程名称：AGC
//工程ID：0005
//模块中文名：系统设置
//模块英文名：SystemSet
//注意：1、需要数据底层（PubDataBase.dll）的版本：2015.11.26.01
//       2、需要公共函数层（TzPubFunction.dll）的版本：2015.11.26.01
//========================
using AGC.BusinessLogic;using AGC.FunClass;
using AGC.BusinessLogicEx;
using AGC.Entity;
using com.taishsoft.common;
using com.taishsoft.datetime;
using CommFunc4WebForm;


///生成查询，修改，删除，添加记录的控制层代码


using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AGC.Webform
{
    /// <summary>
    /// wfmErrorIdManageB_QUDI 的摘要说明。其中Q代表查询，U代表修改
    /// </summary>
    public partial class wfmErrorIdManageB_QUDI : CommWebPageBase
    {

        #region 页面启动函数
        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面
            if (!IsPostBack)	///如果本界面是初次被调用，而不是单击按钮事件所调用
            {

                vsViewName = "错误Id管理维护";
                vsTabName = "vErrorIdManage";
                //生成权限有关判断权限的代码
                //根据等级权限编号来确定用户可以使用什么功能，等级编号方式：1为最大2其次，依此类推
                switch (strPotenceLevel)
                {
                    case "0":
                        clsPubFun4Web.AccessError(this, conCurrPageName);
                        break;
                    case "1":
                        clsPubFun4Web.AccessError(this, conCurrPageName);
                        break;
                    case "2":
                        clsPubFun4Web.AccessError(this, conCurrPageName);
                        break;
                    case "3":
                        clsPubFun4Web.AccessError(this, conCurrPageName);
                        break;
                    case "4":
                        clsPubFun4Web.AccessError(this, conCurrPageName);
                        break;
                    case "9":
                        break;
                    default:
                        clsPubFun4Web.AccessError(this, conCurrPageName);
                        break;
                }

                //1、为下拉框设置数据源，绑定列表数据
                wucErrorIdManageB1.SetDdl_PrjId();
                wucErrorIdManageB1.SetDdl_CodeTypeId();
                clsCodeTypeBLEx.BindDdl_CodeTypeIdWithLangTypeidEx(ddlCodeTypeIdq);
               
                strSortErrorIdManageBy = "mId Asc";
                //2、显示无条件的表内容在GridView中
                BindGv_ErrorIdManage();
                //3、设置表控件中字控件的ReadOnly属性，
                // 使之只读，因为在修改功能中关键字是不能被修改的。
                DispErrorIdManageListRegion();
            }
        }

        #endregion 页面启动函数


        #region 查询相关函数
        /// <summary>
        /// 函数功能：事件函数，当单击<查询>按钮时所发生的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnQuery_Click(object sender, System.EventArgs e)
        {
            //把GridView的当前页索引设置为0，即第1页。
            //当单击查询时，首先显示的是表记录内容的第一部分内容。
            this.gvErrorIdManage.PageIndex = 0;
            //把表记录的内容显示在GridView中
            BindGv_ErrorIdManage();
        }
        ///生成绑定GridView的代码
        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在GridView中。
        /// </summary>
        protected void BindGv_ErrorIdManage()
        {
            //操作步骤：(共5步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	4、设置GridView的数据源(DataSource)；
            //	5、绑定GridView，即把DataTable的内容显示在GridView中
            //	6、设置记录数的状态，
            //		在本界面中是把状态显示在控件txtRecCount中。

            System.Data.DataTable objDT = null;
            try
            {
                //	1、组合界面条件串；
                string strWhereCond = CombineErrorIdManageCondition();
                //	2、根据条件串获取该表满足条件的DataTable；
                objDT = clsvErrorIdManageBL.GetDataTable(strWhereCond);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "获取数据表(DataTable)不成功!" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            //	4、设置GRIDView的数据源(DataSource)；
            DataView objDV = objDT.DefaultView;
            objDV.Sort = strSortErrorIdManageBy; ///注意这一行代码有可能需要注释掉，目前这行仅仅在单独的查询界面中起作用
            ///设置GridView中每页的记录数
            if (string.IsNullOrEmpty(PageSize) == false)
            {
                int intPageSize = int.Parse(PageSize);
                gvErrorIdManage.PageSize = intPageSize;
            }
            else
            {
                PageSize = "10";
                gvErrorIdManage.PageSize = 10;
            }
            this.gvErrorIdManage.DataSource = objDV;
            //	5、绑定GridView，即把DataTable的内容显示在GridView中
            this.gvErrorIdManage.DataBind();

            ///生成专门用于BindGv中的跳页相关代码
            GridViewRow pagerRow = gvErrorIdManage.BottomPagerRow;
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
                lblAllPages.Text = this.gvErrorIdManage.PageCount.ToString();
                //当前页序数
                lblCurrentPage.Text = (this.gvErrorIdManage.PageIndex + 1).ToString();
                //当前即将跳到的页序数
                txtJump2Page.Text = (this.gvErrorIdManage.PageIndex + 1).ToString();
                //如果当前页序数为0，则<前一页>按钮无效
                if (this.gvErrorIdManage.PageIndex == 0)
                {
                    clsPubFun.SetButtonEnabled(btnPrevPage, false);
                }
                else
                {
                    clsPubFun.SetButtonEnabled(btnPrevPage, true);
                }
                //如果当前页序数已为最后一页，则<前一页>按钮无效
                if (this.gvErrorIdManage.PageIndex == this.gvErrorIdManage.PageCount - 1)
                {
                    clsPubFun.SetButtonEnabled(btnNextPage, false);
                }
                else
                {
                    clsPubFun.SetButtonEnabled(btnNextPage, true);
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
            gvErrorIdManage.BottomPagerRow.Visible = true;
        }



        ///生成与跳页的相关函数
        protected void btnJumpPage_Click(object sender, EventArgs e)
        {
            GridViewRow pagerRow = gvErrorIdManage.BottomPagerRow;
            TextBox txtJump2Page = (TextBox)pagerRow.FindControl("txtJump2Page");
            if (txtJump2Page != null)
            {
                if (txtJump2Page.Text.Trim() != "" &&
                int.Parse(txtJump2Page.Text) > 0 &&
                int.Parse(txtJump2Page.Text) - 1 < this.gvErrorIdManage.PageCount)
                {
                    this.gvErrorIdManage.PageIndex = int.Parse(txtJump2Page.Text) - 1;
                }
                this.BindGv_ErrorIdManage();
            }
        }


        ///生成的改变GridView中每页记录数的下拉框相关函数
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
                    BindGv_ErrorIdManage();
                }
            }
        }

        ///生成GridView行命令的事件代码
        protected void gvErrorIdManage_RowCommand(object sender, GridViewCommandEventArgs e)
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
                        clsCommForWebForm.Set_GridViewAllChecked(gvErrorIdManage, true);
                        lbSelAll.Text = "不选";
                    }
                    else if (lbSelAll.Text == "不选")
                    {
                        clsCommForWebForm.Set_GridViewAllChecked(gvErrorIdManage, false);
                        lbSelAll.Text = "全选";
                    }
                    break;
            }
        }
        protected void gvErrorIdManage_RowCreated(object sender, GridViewRowEventArgs e)
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
            if (strSortErrorIdManageBy == "") return;
            if (e.Row.RowType == DataControlRowType.Header)//点击控件是否为页眉；
            {
                string strSortEx;
                for (int i = 0; i < this.gvErrorIdManage.Columns.Count; i++)
                {
                    strSortEx = this.gvErrorIdManage.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = strSortErrorIdManageBy.IndexOf(strSortEx + " ");
                    if (intIndex >= 0) //视图状态的排序表达式是否为该列的字段；
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//设置字体，在"webdings"中5是上三角，6是下三角；
                        intIndex = strSortErrorIdManageBy.IndexOf("Asc");
                        lblSort.Text = (intIndex > 0 ? " 5" : " 6");//是否为升序，而且为string型；
                        e.Row.Cells[i].Controls.Add(lblSort);//被引用项的第i个单元格中增添一控件；
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// 函数功能：事件函数，在更改GridView的当前页索引时激发的函数。
        ///			 具体功能是重新显示新页(所单击页索引)的内容。
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void gvErrorIdManage_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            //操作步骤：（共2步）
            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            //2、重新绑定GridView，使之内容更新，变化到新的页

            if (e.NewPageIndex != -1)
            {
                //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
                gvErrorIdManage.PageIndex = e.NewPageIndex;
                //2、重新绑定GridView，使之内容更新，变化到新的页
                this.BindGv_ErrorIdManage();
            }
        }
        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        protected string CombineErrorIdManageCondition()
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 && UserName = '张三'
            string strWhereCond = " 1=1 ";
            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            try
            {
                if (this.txtErrIDq.Text.Trim() != "")
                {
                    strWhereCond += string.Format(" And {0} like '%{1}%'", convErrorIdManage.ErrID, this.txtErrIDq.Text.Trim());
                }
               
                if (this.ddlCodeTypeIdq.SelectedValue != "" && this.ddlCodeTypeIdq.SelectedValue != "0")
                {
                    strWhereCond += string.Format(" And {0}='{1}'", convErrorIdManage.CodeTypeId, this.ddlCodeTypeIdq.SelectedValue);
                }
                if (this.txtPrefixq.Text.Trim() != "")
                {
                    strWhereCond += string.Format(" And {0} like '%{1}%'", convErrorIdManage.Prefix, this.txtPrefixq.Text.Trim());
                }
               
                if (this.txtFunctionNameq.Text.Trim() != "")
                {
                    strWhereCond += string.Format(" And {0} like '%{1}%'", convErrorIdManage.FunctionName, this.txtFunctionNameq.Text.Trim());
                }
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("在组合查询条件(CombineErrorIdManageCondition)时出错！请联系管理员！" + objException.Message);
                throw new Exception(strMsg);
            }
            return strWhereCond;
        }

        /// <summary>
        /// 专门用于记录GridView中的每页记录数
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
        protected void gvErrorIdManage_Sorting(object sender, GridViewSortEventArgs e)
        {
            int intIndex;
            //判断是否是新的排序字段
            intIndex = strSortErrorIdManageBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                strSortErrorIdManageBy = e.SortExpression + " Asc";
                BindGv_ErrorIdManage();
                return;
            }
            //检查原来是升序
            intIndex = strSortErrorIdManageBy.IndexOf(" Asc");
            if (intIndex == -1)		//如果原来不是升序就设置为升序
            {
                strSortErrorIdManageBy = e.SortExpression + " Asc";
            }
            else			///否则设置为降序
            {
                strSortErrorIdManageBy = e.SortExpression + " Desc";
            }
            BindGv_ErrorIdManage();
        }

        /// <summary>
        /// 用于记录GridView中的当前排序表达式，以便决定下一次是升序，还是降序排序。
        /// </summary>
        protected string strSortErrorIdManageBy
        {
            get
            {
                string sSortErrorIdManageBy;
                sSortErrorIdManageBy = (string)ViewState["SortErrorIdManageBy"];
                if (sSortErrorIdManageBy == null)
                {
                    sSortErrorIdManageBy = "";
                }
                return sSortErrorIdManageBy;
            }
            set
            {
                string sSortErrorIdManageBy = value;
                ViewState.Add("SortErrorIdManageBy", sSortErrorIdManageBy);
            }
        }
        #endregion 排序相关函数


        #region 添加相关函数

        ///添加新记录的事件过程，建议在该过程中调用其他函数，不要在其中添加多行代码。
        protected void btnAddNewRec4Gv_Click(object sender, System.EventArgs e)
        {
            AddErrorIdManageRecord();
        }
        /// <summary>
        /// 为插入记录做准备工作
        /// </summary>
        protected void AddErrorIdManageRecord()
        {
            btnOKUpd.Text = "确认添加";
            btnCancelErrorIdManageEdit.Text = "取消添加";
            wucErrorIdManageB1.PrjId = clsPubVar.CurrSelPrjId;
            //wucErrorIdManageB1.mId = clsErrorIdManageBL.GetMaxStrId_S();
            DispEditErrorIdManageRegion();
        }
        /// <summary>
        /// 插入记录存盘到数据表中
        /// </summary>
        /// <returns>插入记录是否成功？</returns>
        protected bool AddErrorIdManageRecordSave()
        {
            //操作步骤：
            //1、检查控件中输入数据类型是否正确
            //2、定义对象并初始化对象
            //3.1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            //3.2、检查唯一性
            //4、把值从界面层传到逻辑层或数据实体层
            //5、检查传进去的对象属性是否合法
            //6、把数据实体层的数据存贮到数据库中
            //7、把新添的记录内容显示在GridView中
            string strMsg;	//专门用于传递信息的变量
            string strResult = " ";	//用于传递在检验对象属性时结果值的变量
            clsErrorIdManageEN objErrorIdManageEN;
            //1、检查控件中输入数据类型是否正确
            if (!wucErrorIdManageB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、定义对象并初始化对象
            //clsErrorIdManageEN objErrorIdManageEN;	//定义对象
            objErrorIdManageEN = new clsErrorIdManageEN();	//初始化新对象
            //3.1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToErrorIdManageClass(objErrorIdManageEN);		//把界面的值传到
            //5.1、检查传进去的对象属性是否合法
            try
            {

                clsErrorIdManageBL.CheckPropertyNew(objErrorIdManageEN);
                ///5.2、检查唯一性
                if (objErrorIdManageEN.CheckUniqueness() == false)
                {
                    strMsg = "(错误Id(ErrID))不能重复！";
                    clsCommonJsFunc.Alert(this, strMsg);
                    return false;
                }
                StringBuilder sbCondition = new StringBuilder();
                //sbCondition.AppendFormat("{0}='{1}'", conErrorIdManage.PrjId, objErrorIdManageEN.PrjId);
                sbCondition.AppendFormat(" {0}='{1}'", conErrorIdManage.CodeTypeId, objErrorIdManageEN.CodeTypeId);
                //sbCondition.AppendFormat(" And {0}='{1}'", conErrorIdManage.ClsName, objErrorIdManageEN.ClsName);
                sbCondition.AppendFormat(" And {0}='{1}'", conErrorIdManage.FunctionName, objErrorIdManageEN.FunctionName);
                sbCondition.AppendFormat(" And {0}='{1}'", conErrorIdManage.Explanation, objErrorIdManageEN.Explanation);
                if (clsErrorIdManageBL.IsExistRecord(sbCondition.ToString()) == true)
                {
                    strMsg = "(errid:WebI000053)高度相似的记录已经存在，不能添加该记录！";
                    clsCommonJsFunc.Alert(this, strMsg);
                    return false;
                }
                //6、把数据实体层的数据存贮到数据库中
                clsErrorIdManageBL.AddNewRecordBySql2(objErrorIdManageEN);
            }
            catch (Exception objException)
            {
                strMsg = "添加记录不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgEdit.Text = strMsg;
                return false;
            }
            strMsg = "添加记录成功!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsgEdit.Text = "添加记录成功!";
            //7、把新添的记录内容显示在GridView中
            BindGv_ErrorIdManage();
            DispErrorIdManageListRegion();
            wucErrorIdManageB1.Clear();		//清空控件中内容
            ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelErrorIdManageEdit.Text = "取消编辑";
            return true;
        }
        /// <summary>
        /// 插入记录存盘到数据表中，V5版
        /// </summary>
        /// <returns>插入记录是否成功？</returns>
        protected bool AddErrorIdManageRecordSaveV5()
        {
            //操作步骤：
            //1、检查控件中输入数据类型是否正确
            //2、定义对象并初始化对象
            //3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            //4、把值从界面层传到逻辑层或数据实体层
            //5、检查传进去的对象属性是否合法
            //6、把数据实体层的数据存贮到数据库中
            //7、把新添的记录内容显示在GridView中
            string strMsg;	//专门用于传递信息的变量
            string strResult = " ";	//用于传递在检验对象属性时结果值的变量
            clsErrorIdManageEN objErrorIdManageEN;
            //1、检查控件中输入数据类型是否正确
            if (!wucErrorIdManageB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、定义对象并初始化对象
            //clsErrorIdManageEN objErrorIdManageEN;	//定义对象
            objErrorIdManageEN = new clsErrorIdManageEN();	//初始化新对象
            //3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToErrorIdManageClass(objErrorIdManageEN);		//把界面的值传到
            //5.1、检查传进去的对象属性是否合法
            try
            {
                clsErrorIdManageBL.CheckPropertyNew(objErrorIdManageEN);
                ///5.2、检查唯一性
                if (objErrorIdManageEN.CheckUniqueness() == false)
                {
                    strMsg = "错误Id(ErrID)不能重复！";
                    clsCommonJsFunc.Alert(this, strMsg);
                    return false;
                }
                //6、把数据实体层的数据存贮到数据库中
                clsErrorIdManageBL.AddNewRecordBySql2(objErrorIdManageEN);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "添加记录不成功!" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            strMsg = "添加记录成功!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsgEdit.Text = "添加记录成功!";
            //7、把新添的记录内容显示在GridView中
            BindGv_ErrorIdManage();
            DispErrorIdManageListRegion();
            wucErrorIdManageB1.Clear();		//清空控件中内容
            ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelErrorIdManageEdit.Text = "取消编辑";
            return true;
        }
        #endregion 添加相关函数


        #region 修改相关函数

        /// <summary>
        ///修改当前被选记录
        /// </summary>
        protected void btnUpdate4Gv_Click(object sender, System.EventArgs e)
        {
            List<string> lstKeyValue = clsCommForWebForm.GetFirstCheckedItemFromGv(gvErrorIdManage, "mId");
            if (lstKeyValue.Count == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；
            string[] strKeys = lstKeyValue[0].Split(',');
            long lngmId = long.Parse(strKeys[0]);
            UpdateErrorIdManageRecord(lngmId);
        }
        ///
        protected void gvErrorIdManage_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string strmId = gvErrorIdManage.DataKeys[e.RowIndex]["mId"].ToString();
            long lngmId = long.Parse(strmId);
            UpdateErrorIdManageRecord(lngmId);
        }

        /// <summary>
        /// 函数功能：把以该关键字的记录内容显示在界面上，
        ///　　　     在这里是把值传到表控件中
        /// </summary>
        /// <param name="lngmId">表记录的关键字，显示该表关键字的内容</param>
        protected void ShowData(long lngmId)
        {
            //操作步骤：
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在，如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中

            //1、检查关键字是否为空；
            if (lngmId == 0) return;		//如果关键字为空就返回退出
            //2、检查该关键字的记录是否存在，如果不存在就返回不显示；
            if (clsErrorIdManageBL.IsExist(lngmId) == false)		//检查该关键字的记录是否存在
            {
                string ss = "在表【ErrorIdManage】中，关键字为：" + lngmId.ToString() + "的不存在!";
                clsCommonJsFunc.Alert(this, ss);
                return;
            }
            //3、用提供的关键字初始化一个类对象；
            clsErrorIdManageEN objErrorIdManageEN = new clsErrorIdManageEN(lngmId);
            //4、获取类对象的所有属性；
            try
            {
                clsErrorIdManageBL.GetErrorIdManage(ref objErrorIdManageEN);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            Session.Add("objErrorIdManageEN", objErrorIdManageEN);
            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中
            GetDataFromErrorIdManageClass(objErrorIdManageEN);
        }
        /// <summary>
        /// 函数功能：把类对象的属性内容显示到界面上
        ///注意：如果有两个下拉框，并且是一级、二级连带关系的，请先为一级下拉框赋值，然后再为二级下拉框赋值
        /// 如果在设置数据库时，就应该一级字段在前，二级字段在后
        /// </summary>
        /// <param name="pobjErrorIdManageEN">表实体类对象</param>
        protected void GetDataFromErrorIdManageClass(clsErrorIdManageEN pobjErrorIdManageEN)
        {
            wucErrorIdManageB1.ErrID = pobjErrorIdManageEN.ErrID;// 错误Id
            //wucErrorIdManageB1.PrjId = pobjErrorIdManageEN.PrjId;// 工程ID
            wucErrorIdManageB1.CodeTypeId = pobjErrorIdManageEN.CodeTypeId;// 程序分层类型
            //wucErrorIdManageB1.ClsName = pobjErrorIdManageEN.ClsName;// 类名
            wucErrorIdManageB1.FunctionName = pobjErrorIdManageEN.FunctionName;// 功能名称
            wucErrorIdManageB1.Explanation = pobjErrorIdManageEN.Explanation;// 说明
          
            wucErrorIdManageB1.Memo = pobjErrorIdManageEN.Memo;// 说明
        }
        /// <summary>
        /// 为修改记录做准备过程,把给定关键字的记录字段值显示在用户控件上
        /// </summary>
        protected void UpdateErrorIdManageRecord(long lngmId)
        {
            //操作步骤：（总共2步）
            //1、显示该关键字记录的内容在界面上；
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；

            //1、显示该关键字记录的内容在界面上；
            ShowData(lngmId);
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；
            clsPubFun.SetButtonEnabled(btnOKUpd, true);
            btnOKUpd.Text = "确认修改";
            btnCancelErrorIdManageEdit.Text = "取消修改";
            lblMsgEdit.Text = "";
            DispEditErrorIdManageRegion();
        }
        /// <summary>
        /// 为修改记录做准备过程,把给定关键字的记录字段值显示在用户控件上
        /// </summary>
        protected void RefAddErrorIdManageRecord(long lngmId)
        {
            //操作步骤：（总共2步）
            //1、显示该关键字记录的内容在界面上；
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；

            //1、显示该关键字记录的内容在界面上；
            ShowData(lngmId);
            string strCodeTypeId = wucErrorIdManageB1.CodeTypeId;
            string strErrId = clsErrorIdManageBLEx.GetMaxErrId(strCodeTypeId);
            wucErrorIdManageB1.ErrID = strErrId;
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；
            clsPubFun.SetButtonEnabled(btnOKUpd, true);
            btnOKUpd.Text = "确认添加";
            btnCancelErrorIdManageEdit.Text = "取消添加";
            lblMsgEdit.Text = "";
            DispEditErrorIdManageRegion();
        }
        /// <summary>
        /// 修改记录存盘到数据表中
        /// </summary>
        /// <param name="objErrorIdManageEN">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        protected bool UpdateErrorIdManageRecordSave(clsErrorIdManageEN objErrorIdManageEN)
        {
            //操作步骤：
            //1、检查控件中输入数据类型是否正确
            //2、把值从界面层传到逻辑层或数据实体层
            //3.1、检查传进去的对象属性是否合法
            //3.2、检查唯一性
            //4、把数据实体层的数据存贮到数据库中
            //5、把修改后的内容显示在GridView中
            string strMsg;	//专门用于传递信息的变量
            string strResult = " ";	//用于传递在检验对象属性时结果值的变量
            //1、检查控件中输入数据类型是否正确
            if (!wucErrorIdManageB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToErrorIdManageClass(objErrorIdManageEN);		//把界面的值传到
            //3.1、检查传进去的对象属性是否合法
            try
            {
                clsErrorIdManageBL.CheckPropertyNew(objErrorIdManageEN);
                //3.2、检查唯一性
                if (objErrorIdManageEN.CheckUniqueness() == false)
                {
                    strMsg = "(错误Id(ErrID))不能重复！";
                    clsCommonJsFunc.Alert(this, strMsg);
                    return false;
                }
                StringBuilder sbCondition = new StringBuilder();
                //sbCondition.AppendFormat("{0}='{1}'", conErrorIdManage.PrjId, objErrorIdManageEN.PrjId);
                sbCondition.AppendFormat(" {0}='{1}'", conErrorIdManage.CodeTypeId, objErrorIdManageEN.CodeTypeId);
                //sbCondition.AppendFormat(" And {0}='{1}'", conErrorIdManage.ClsName, objErrorIdManageEN.ClsName);
                sbCondition.AppendFormat(" And {0}='{1}'", conErrorIdManage.FunctionName, objErrorIdManageEN.FunctionName);
                sbCondition.AppendFormat(" And {0}='{1}'", conErrorIdManage.Explanation, objErrorIdManageEN.Explanation);
                sbCondition.AppendFormat(" And {0}!={1}", conErrorIdManage.mId, objErrorIdManageEN.mId);
                if (clsErrorIdManageBL.IsExistRecord(sbCondition.ToString()) == true)
                {
                    strMsg = "(errid:WebI000054)高度相似的记录已经存在，不能修改该记录！";
                    clsCommonJsFunc.Alert(this, strMsg);
                    return false;
                }
                //4、把数据实体层的数据存贮到数据库中
                clsErrorIdManageBL.UpdateBySql2(objErrorIdManageEN);
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
            BindGv_ErrorIdManage();
            DispErrorIdManageListRegion();
            wucErrorIdManageB1.Clear();//添空控件中的内容
            //恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelErrorIdManageEdit.Text = "取消编辑";
            //跳转到列表中刚刚的记录处，使用锚点功能。
            this.ClientScript.RegisterStartupScript(this.GetType(), "Go-Anchor", string.Format("this.location.href='#A_ErrorIdManage{0}'", objErrorIdManageEN.mId.ToString().Trim()), true);
            return true;
        }
        /// <summary>
        /// 修改记录存盘到数据表中, V5版
        /// </summary>
        /// <param name="objErrorIdManageEN">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        protected bool UpdateErrorIdManageRecordSaveV5(clsErrorIdManageEN objErrorIdManageEN)
        {
            //操作步骤：
            //1、检查控件中输入数据类型是否正确
            //2、把值从界面层传到逻辑层或数据实体层
            //3.1、检查传进去的对象属性是否合法
            //4、把数据实体层的数据存贮到数据库中
            //5、把修改后的内容显示在GridView中
            string strMsg;	//专门用于传递信息的变量
            string strResult = " ";	//用于传递在检验对象属性时结果值的变量
            //1、检查控件中输入数据类型是否正确
            if (!wucErrorIdManageB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToErrorIdManageClass(objErrorIdManageEN);		//把界面的值传到
            //3.1、检查传进去的对象属性是否合法
            try
            {
                clsErrorIdManageBL.CheckPropertyNew(objErrorIdManageEN);
                //3.2、检查唯一性
                if (objErrorIdManageEN.CheckUniqueness() == false)
                {
                    strMsg = "错误Id(ErrID)不能重复！";
                    clsCommonJsFunc.Alert(this, strMsg);
                    return false;
                }
                //4、把数据实体层的数据存贮到数据库中
                clsErrorIdManageBL.UpdateBySql2(objErrorIdManageEN);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "修改记录不成功!" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            strMsg = "修改记录成功!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsgEdit.Text = "修改记录成功!";
            //5、把修改后的内容显示在GridView中
            BindGv_ErrorIdManage();
            DispErrorIdManageListRegion();
            wucErrorIdManageB1.Clear();//添空控件中的内容
            //恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelErrorIdManageEdit.Text = "取消编辑";
            //跳转到列表中刚刚的记录处，使用锚点功能。
            this.ClientScript.RegisterStartupScript(this.GetType(), "Go-Anchor", string.Format("this.location.href='#A_ErrorIdManage{0}'", objErrorIdManageEN.mId.ToString().Trim()), true);
            return true;
        }
        #endregion 修改相关函数


        #region 添加修改共用函数
        /// <summary>
        /// 函数功能：事件函数，当单击<确定修改>时发生的事件函数，
        /// 具体功能为把界面内容同步数据库中，把界面内容保存到数据库中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOKUpd_Click(object sender, System.EventArgs e)
        {
            string strCommandText;
            clsErrorIdManageEN objErrorIdManageEN;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "添加":
                    AddErrorIdManageRecord();
                    break;
                case "确认添加":
                    //这是一个单表的插入的代码，由于逻辑层太简单，
                    //就把逻辑层合并到控制层,
                    AddErrorIdManageRecordSave();
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码，由于逻辑层太简单，
                    //就把逻辑层合并到控制层,
                    objErrorIdManageEN = (clsErrorIdManageEN)Session["objErrorIdManageEN"];
                    UpdateErrorIdManageRecordSave(objErrorIdManageEN);
                    break;
            }
        }
        ///
        protected void btnCancelErrorIdManageEdit_Click(object sender, EventArgs e)
        {
            DispErrorIdManageListRegion();
        }
        /// <summary>
        /// 函数功能：把界面上的属性数据传到类对象中
        /// </summary>
        /// <param name="pobjErrorIdManageEN">数据传输的目的类对象</param>
        protected void PutDataToErrorIdManageClass(clsErrorIdManageEN pobjErrorIdManageEN)
        {
            pobjErrorIdManageEN.ErrID = wucErrorIdManageB1.ErrID;// 错误Id
            //pobjErrorIdManageEN.PrjId = wucErrorIdManageB1.PrjId;// 工程ID
            pobjErrorIdManageEN.CodeTypeId = wucErrorIdManageB1.CodeTypeId;// 程序分层类型
            //pobjErrorIdManageEN.ClsName = wucErrorIdManageB1.ClsName;// 类名
            pobjErrorIdManageEN.FunctionName = wucErrorIdManageB1.FunctionName;// 功能名称
            pobjErrorIdManageEN.Explanation = wucErrorIdManageB1.Explanation;// 说明
            pobjErrorIdManageEN.UpdDate = wucErrorIdManageB1.UpdDate;// 修改日期
            pobjErrorIdManageEN.UpdUserId = wucErrorIdManageB1.UpdUserId;// 修改用户Id
            pobjErrorIdManageEN.Memo = wucErrorIdManageB1.Memo;// 说明
        }

        #endregion 添加修改共用函数


        #region 删除相关函数

        /// <summary>
        ///删除当前被选记录
        /// </summary>
        protected void btnDelete4Gv_Click(object sender, System.EventArgs e)
        {
            List<string> lstKeyValues = clsCommForWebForm.GetAllCheckedItemFromGv(gvErrorIdManage, "chkCheckRec", "mId");
            if (lstKeyValues.Count == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            try
            {
                foreach (string strKeyValue in lstKeyValues)
                {
                    string[] strKeys = strKeyValue.Split(',');
                    long lngmId = long.Parse(strKeys[0]);
                    clsErrorIdManageBL.DelRecord(lngmId);
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_ErrorIdManage();
        }
        ///
        protected void gvErrorIdManage_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string strmId = gvErrorIdManage.DataKeys[e.RowIndex]["mId"].ToString();
            long lngmId = long.Parse(strmId);
            DeleteErrorIdManageRecord(lngmId);
        }
        /// <summary>
        /// 根据给定关键字删除记录
        /// </summary>
        /// <param name="lngmId">给定关键字</param>
        protected void DeleteErrorIdManageRecord(long lngmId)
        {
            try
            {
                clsErrorIdManageBL.DelRecord(lngmId);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_ErrorIdManage();
        }
        #endregion 删除相关函数


        #region 导出函数

        //生成专门用于导出Excel的相关代码
        protected void btnExportExcel4Gv_Click(object sender, System.EventArgs e)
        {
            //导出Excel函数
            ExportExcel();
        }

        /// <summary>
        ///设置当前用户的Excel导出字段
        /// </summary>
        protected void btnSetExportExcel4User_Click(object sender, EventArgs e)
        {
            clsExportExcelSetENEx objExportExcelSetENEx = new clsExportExcelSetENEx();
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("ViewName='{0}'", vsViewName);//当前界面
            sbCondition.AppendFormat(" And TabName='{0}'", vsTabName);//当前导出的使用的表
            sbCondition.AppendFormat(" And UserId='{0}'", clsCommonSession.UserId);//当前用户
            //根据条件获取Excel设置Id
            string strIdExportExcel4Users = clsExportExcelSetBL.GetFirstID_S(sbCondition.ToString());
            if (string.IsNullOrEmpty(strIdExportExcel4Users) == true)
            {
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.AppendFormat("在系统中没有界面为'{0}'", vsViewName);
                sbMsg.AppendFormat("，表名='{0}'", vsTabName);
                sbMsg.AppendFormat("并且用户='{0}'的导出Excel用户设置，请先导出一次Excel，再不行可与管理员联系！", clsCommonSession.UserId);
                clsCommonJsFunc.Alert(this, sbMsg.ToString());
                return;
            }
            //弹出导出Excel字段界面进行设置
            StringBuilder sbScript = new StringBuilder();
            sbScript.Append("<script language='javascript'>");
            sbScript.Append("window.open('");
            sbScript.AppendFormat("../SysManage/wfmExportExcel4UsersB_QUDI.aspx?Id_ExportExcel4Users={0}", strIdExportExcel4Users);
            sbScript.Append("','_blank', 'left=50px,top=50px,status=no,width=920px,height=650px,scrollbars=yes'); </script>");
            Page.ClientScript.RegisterStartupScript(this.GetType(), "导出Excel字段设置", sbScript.ToString());
            // Response.Write(sbScript.ToString());
        }

        /// <summary>
        /// 导出Excel。根据查询区组合的查询条件，从[vErrorIdManage]表中获取记录集，最终导出到Excel
        /// </summary>
        private void ExportExcel()
        {
            //	1、组合界面条件串；
            string strWhereCond = CombineErrorIdManageCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "ErrorIdManage信息导出.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add(convErrorIdManage.ErrID); arrCnName.Add("错误Id");
            arrColName.Add(convErrorIdManage.CodeTypeId); arrCnName.Add("程序分层类型");
            arrColName.Add(convErrorIdManage.CodeTypeName); arrCnName.Add("程序分层类型名称");
            arrColName.Add(convErrorIdManage.CodeTypeENName); arrCnName.Add("程序分层类型英文名称");
            arrColName.Add(convErrorIdManage.Prefix); arrCnName.Add("前缀");
            arrColName.Add(convErrorIdManage.FunctionName); arrCnName.Add("功能名称");
            arrColName.Add(convErrorIdManage.Explanation); arrCnName.Add("说明");
            arrColName.Add(convErrorIdManage.UpdDate); arrCnName.Add("修改日期");
            arrColName.Add(convErrorIdManage.UpdUserId); arrCnName.Add("修改用户Id");
            arrColName.Add(convErrorIdManage.Memo); arrCnName.Add("说明");
            clsExportExcelSetENEx objExportExcelSetENEx = new clsExportExcelSetENEx();
            objExportExcelSetENEx.ViewName = vsViewName;//当前界面
            objExportExcelSetENEx.TabName = vsTabName;//导出Excel所用的表或者视图
            objExportExcelSetENEx.ExportFileName = strFileName;//导出Excel的文件名
            objExportExcelSetENEx.UserId = clsCommonSession.UserId;//当前用户Id
            objExportExcelSetENEx.UpdUserId = clsCommonSession.UserId;
            objExportExcelSetENEx.UpdDate = clsDateTime.getTodayStr(0);//当前日期
            objExportExcelSetENEx.strPrjId = clsPubVar.strCurrPrjId4Agc;//当前工程在生成代码系统中所用的工程Id，为了翻译字段名的中文名
            objExportExcelSetENEx.arrCnName = arrCnName;//中文字段名，也是Excel文件中的标题名
            objExportExcelSetENEx.arrColName = arrColName;//数据表的列名
            try
            {
                clsExportExcelSetBLEx.GetExportExcelSetInfo(ref objExportExcelSetENEx, new clsTranslateFieldName());
                strFileName = objExportExcelSetENEx.ExportFileName;//导出Excel的文件名
                arrCnName = objExportExcelSetENEx.arrCnName;//中文字段名，也是Excel文件中的标题名
                arrColName = objExportExcelSetENEx.arrColName;//数据表的列名
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            strFolderName = clsSysParaEN.TempFileFolder;
            strDownLoadFileName = strFolderName + strFileName;
            //初始化需要导出的Excel文件,即复制标准Excel文件作为母版，复制不成功即不能导出
            if (clsPubVar.InitExcelFile(this, strFolderName, strDownLoadFileName) == false)
            {
                return;
            }
            try
            {
                //	2、根据条件串获取该表满足条件的DataTable；
                objDT = clsvErrorIdManageBL.GetDataTable(strWhereCond);
                //用户Odbc的方式来导出Excel,在Web服务器不需要安装Excel,目前是Excel2003,如果希望2007，可以换下面一条语句。
                GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4Odbc(objDT, arrColName, arrCnName, strDownLoadFileName);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            clsCommForWebForm.DownLoadFile(strDownLoadFileName);
        }
        #endregion 导出函数


        #region 布局控制函数
        /// <summary>
        /// 布局控制函数，显示用于编辑的用户控件，并隐藏数据列表区
        /// </summary>
        private void DispEditErrorIdManageRegion()
        {
            divList.Visible = false;
            tabEditErrorIdManageRegion.Visible = true;
        }
        /// <summary>
        /// 布局控制函数，显示数据列表区，并隐藏用于编辑的用户控件
        /// </summary>
        private void DispErrorIdManageListRegion()
        {
            divList.Visible = true;
            tabEditErrorIdManageRegion.Visible = false;
        }
        #endregion 布局控制函数


        #region 错误处理函数

        /// <summary>
        /// 错误信息的Session属性，该Session传递给显示出错页面，显示相应的错误内容。
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


        //生成返回链接串的Session属性
        /// <summary>
        /// 返回链接串的Session属性，该Session用于告诉出错页面，哪一个页面是需要返回的页面。
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

        #endregion 错误处理函数


        #region 权限处理函数

        //生成有关的变量定义代码
        /// <summary>
        /// 当前操作的界面功能名称
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
        /// 当前操作的导出表名称
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
        /// 通过QueryString传递过来的UserId参数。这里是样例，大家可以参考这个样例。
        /// 姓名：
        /// 日期：
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
        protected const string ViewId4Potence = "00260203";		//界面编号


        //生成权限等级的属性
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
        /// 登录的用户ID，用于检查用户权限
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

        protected void btnRefAddNewRec4Gv_Click(object sender, EventArgs e)
        {
            List<string> lstKeyValue = clsCommForWebForm.GetFirstCheckedItemFromGv(gvErrorIdManage, "mId");
            if (lstKeyValue.Count == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；
            string[] strKeys = lstKeyValue[0].Split(',');
            long lngmId = long.Parse(strKeys[0]);
            RefAddErrorIdManageRecord(lngmId);
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



        #endregion 权限处理函数
        #region 处理父页面信息以及跳转到其他页面

        public override void InitParentPageInfo()
        {
            switch (qsParentPage)
            {
                case "wfmPrjTab_QUDI3.aspx":


                    break;
                case "":
                    break;
                default:
                    clsCommonJsFunc.Alert(this, string.Format("父页面名称：[{0}]在({1})中没有处理！", qsParentPage, clsStackTrace.GetCurrClassFunction()));
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
                    clsCommonJsFunc.Alert(this, string.Format("父页面名称：[{0}]在({1})中没有处理！", qsParentPage, clsStackTrace.GetCurrClassFunction()));
                    break;
            }

        }
        /// <summary>
        /// 跳转到其他页面
        /// </summary>
        /// <param name="strPageName"></param>
        public override void JumpOtherPages(string strPageName)
        {
            switch (strPageName)
            {
                case "":
                    break;
                default:
                    clsCommonJsFunc.Alert(this, string.Format("父页面名称：[{0}]在({1})中没有处理！", qsParentPage, clsStackTrace.GetCurrClassFunction()));
                    break;
            }
        }
        #endregion 处理父页面信息

        /// <summary>
        /// 常量:当前页面名称
        /// </summary>
        public override string conCurrPageName
        {
            get
            {
                return "wfmPrjTab_CheckConsistency.aspx";
            }
        }
    }
}