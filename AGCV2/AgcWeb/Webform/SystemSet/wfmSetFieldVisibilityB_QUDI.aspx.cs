﻿
//----------------------
//生成代码版本：2014.10.01.2
//生成日期：2014/10/01
//生成者：潘以锋
//工程名称：AGC
//工程ID：0005
//模块中文名：系统设置
//模块英文名：SystemSet
//注意：1、需要数据底层（PubDataBase.dll）的版本：2013.11.06.1
//       2、需要公共函数层（TzPubFunction.dll）的版本：2013.11.08.1
//========================
///生成查询，修改，删除，添加记录的控制层代码


using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AGC.FunClass;
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
    /// wfmSetFieldVisibilityB_QUDI 的摘要说明。其中Q代表查询，U代表修改
    /// </summary>
    public partial class wfmSetFieldVisibilityB_QUDI : CommWebPageBase
    {

        #region 页面启动函数
        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面
            if (!IsPostBack)	///如果本界面是初次被调用，而不是单击按钮事件所调用
            {

                vsViewName = "设置字段可视性维护";
                vsTabName = "vSetFieldVisibility";
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
                wucSetFieldVisibilityB1.SetDdl_IdSchool();
                wucSetFieldVisibilityB1.SetDdl_UserId();
                clsUsersBL.BindDdl_UserIdCache(ddlUserIdq);
                clsXzSchoolBL.BindDdl_IdSchool(ddlIdSchoolq);

                ddlIdSchoolq.SelectedValue = clsXzSchoolBLEx.GetId_SchoolBySchoolId(clsMyConfig.spSchool);
                ddlIdSchoolq.Enabled = false;
                wucSetFieldVisibilityB1.IdSchool = clsXzSchoolBLEx.GetId_SchoolBySchoolId(clsMyConfig.spSchool);
                wucSetFieldVisibilityB1.SetIdSchoolEnabledFalse();

                strSortSetFieldVisibilityBy = "mId Asc";
                //2、显示无条件的表内容在GridView中
                BindGv_SetFieldVisibility();
                //3、设置表控件中字控件的ReadOnly属性，
                // 使之只读，因为在修改功能中关键字是不能被修改的。
                DispSetFieldVisibilityListRegion();
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
            this.gvSetFieldVisibility.PageIndex = 0;
            //把表记录的内容显示在GridView中
            BindGv_SetFieldVisibility();
        }
        ///生成绑定GridView的代码
        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在GridView中。
        /// </summary>
        protected void BindGv_SetFieldVisibility()
        {
            //操作步骤：(共5步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	4、设置GridView的数据源(DataSource)；
            //	5、绑定GridView，即把DataTable的内容显示在GridView中
            //	6、设置记录数的状态，
            //		在本界面中是把状态显示在控件txtRecCount中。

            //	1、组合界面条件串；
            string strWhereCond = CombineSetFieldVisibilityCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            try
            {
                objDT = clsvSetFieldVisibilityBL.GetDataTable(strWhereCond);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "获取数据表(DataTable)不成功!" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            //	4、设置GRIDView的数据源(DataSource)；
            DataView objDV = objDT.DefaultView;
            objDV.Sort = strSortSetFieldVisibilityBy; ///注意这一行代码有可能需要注释掉，目前这行仅仅在单独的查询界面中起作用
                                                      ///设置GridView中每页的记录数
            if (string.IsNullOrEmpty(PageSize) == false)
            {
                int intPageSize = int.Parse(PageSize);
                gvSetFieldVisibility.PageSize = intPageSize;
            }
            else
            {
                PageSize = "10";
                gvSetFieldVisibility.PageSize = 10;
            }
            this.gvSetFieldVisibility.DataSource = objDV;
            //	5、绑定GridView，即把DataTable的内容显示在GridView中
            this.gvSetFieldVisibility.DataBind();

            ///生成专门用于BindGv中的跳页相关代码
            GridViewRow pagerRow = gvSetFieldVisibility.BottomPagerRow;
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
                lblAllPages.Text = this.gvSetFieldVisibility.PageCount.ToString();
                //当前页序数
                lblCurrentPage.Text = (this.gvSetFieldVisibility.PageIndex + 1).ToString();
                //当前即将跳到的页序数
                txtJump2Page.Text = (this.gvSetFieldVisibility.PageIndex + 1).ToString();
                //如果当前页序数为0，则<前一页>按钮无效
                if (this.gvSetFieldVisibility.PageIndex == 0)
                {
                    clsPubFun.SetButtonEnabled(btnPrevPage, false);
                }
                else
                {
                    clsPubFun.SetButtonEnabled(btnPrevPage, true);
                }
                //如果当前页序数已为最后一页，则<前一页>按钮无效
                if (this.gvSetFieldVisibility.PageIndex == this.gvSetFieldVisibility.PageCount - 1)
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
            gvSetFieldVisibility.BottomPagerRow.Visible = true;
        }



        ///生成与跳页的相关函数
        protected void btnJumpPage_Click(object sender, EventArgs e)
        {
            GridViewRow pagerRow = gvSetFieldVisibility.BottomPagerRow;
            TextBox txtJump2Page = (TextBox)pagerRow.FindControl("txtJump2Page");
            if (txtJump2Page != null)
            {
                if (txtJump2Page.Text.Trim() != "" &&
                int.Parse(txtJump2Page.Text) > 0 &&
                int.Parse(txtJump2Page.Text) - 1 < this.gvSetFieldVisibility.PageCount)
                {
                    this.gvSetFieldVisibility.PageIndex = int.Parse(txtJump2Page.Text) - 1;
                }
                this.BindGv_SetFieldVisibility();
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
                    BindGv_SetFieldVisibility();
                }
            }
        }

        ///生成GridView行命令的事件代码
        protected void gvSetFieldVisibility_RowCommand(object sender, GridViewCommandEventArgs e)
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
                        clsCommForWebForm.Set_GridViewAllChecked(gvSetFieldVisibility, true);
                        lbSelAll.Text = "不选";
                    }
                    else if (lbSelAll.Text == "不选")
                    {
                        clsCommForWebForm.Set_GridViewAllChecked(gvSetFieldVisibility, false);
                        lbSelAll.Text = "全选";
                    }
                    break;
            }
        }
        protected void gvSetFieldVisibility_RowCreated(object sender, GridViewRowEventArgs e)
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
            if (strSortSetFieldVisibilityBy == "") return;
            if (e.Row.RowType == DataControlRowType.Header)//点击控件是否为页眉；
            {
                string strSortEx;
                for (int i = 0; i < this.gvSetFieldVisibility.Columns.Count; i++)
                {
                    strSortEx = this.gvSetFieldVisibility.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = strSortSetFieldVisibilityBy.IndexOf(strSortEx + " ");
                    if (intIndex >= 0) //视图状态的排序表达式是否为该列的字段；
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//设置字体，在"webdings"中5是上三角，6是下三角；
                        intIndex = strSortSetFieldVisibilityBy.IndexOf("Asc");
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
        protected void gvSetFieldVisibility_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            //操作步骤：（共2步）
            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            //2、重新绑定GridView，使之内容更新，变化到新的页

            if (e.NewPageIndex != -1)
            {
                //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
                gvSetFieldVisibility.PageIndex = e.NewPageIndex;
                //2、重新绑定GridView，使之内容更新，变化到新的页
                this.BindGv_SetFieldVisibility();
            }
        }
        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        protected string CombineSetFieldVisibilityCondition()
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 && UserName = '张三'
            string strWhereCond = " 1=1 ";
            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            if (this.ddlUserIdq.SelectedValue != "" && this.ddlUserIdq.SelectedValue != "0")
            {
                strWhereCond += " And UserId='" + this.ddlUserIdq.SelectedValue + "'";
            }
            if (this.txtViewNameq.Text.Trim() != "")
            {
                strWhereCond += " And ViewName like '%" + this.txtViewNameq.Text.Trim() + "%'";
            }
            if (this.txtFieldNameq.Text.Trim() != "")
            {
                strWhereCond += " And FieldName like '%" + this.txtFieldNameq.Text.Trim() + "%'";
            }
            if (this.ddlIdSchoolq.SelectedValue != "" && this.ddlIdSchoolq.SelectedValue != "0")
            {
                strWhereCond += " And IdSchool='" + this.ddlIdSchoolq.SelectedValue + "'";
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
        protected void gvSetFieldVisibility_Sorting(object sender, GridViewSortEventArgs e)
        {
            int intIndex;
            //判断是否是新的排序字段
            intIndex = strSortSetFieldVisibilityBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                strSortSetFieldVisibilityBy = e.SortExpression + " Asc";
                BindGv_SetFieldVisibility();
                return;
            }
            //检查原来是升序
            intIndex = strSortSetFieldVisibilityBy.IndexOf(" Asc");
            if (intIndex == -1)		//如果原来不是升序就设置为升序
            {
                strSortSetFieldVisibilityBy = e.SortExpression + " Asc";
            }
            else			///否则设置为降序
            {
                strSortSetFieldVisibilityBy = e.SortExpression + " Desc";
            }
            BindGv_SetFieldVisibility();
        }

        /// <summary>
        /// 用于记录GridView中的当前排序表达式，以便决定下一次是升序，还是降序排序。
        /// </summary>
        protected string strSortSetFieldVisibilityBy
        {
            get
            {
                string sSortSetFieldVisibilityBy;
                sSortSetFieldVisibilityBy = (string)ViewState["SortSetFieldVisibilityBy"];
                if (sSortSetFieldVisibilityBy == null)
                {
                    sSortSetFieldVisibilityBy = "";
                }
                return sSortSetFieldVisibilityBy;
            }
            set
            {
                string sSortSetFieldVisibilityBy = value;
                ViewState.Add("SortSetFieldVisibilityBy", sSortSetFieldVisibilityBy);
            }
        }
        #endregion 排序相关函数


        #region 添加相关函数

        ///添加新记录的事件过程，建议在该过程中调用其他函数，不要在其中添加多行代码。
        protected void btnAddNewRec4Gv_Click(object sender, System.EventArgs e)
        {
            AddSetFieldVisibilityRecord();
        }
        /// <summary>
        /// 为插入记录做准备工作
        /// </summary>
        protected void AddSetFieldVisibilityRecord()
        {
            btnOKUpd.Text = "确认添加";
            btnCancelSetFieldVisibilityEdit.Text = "取消添加";

            DispEditSetFieldVisibilityRegion();
        }
        /// <summary>
        /// 插入记录存盘到数据表中
        /// </summary>
        /// <returns>插入记录是否成功？</returns>
        protected bool AddSetFieldVisibilityRecordSave()
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
            clsSetFieldVisibilityEN objSetFieldVisibilityEN;
            //1、检查控件中输入数据类型是否正确
            if (!wucSetFieldVisibilityB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、定义对象并初始化对象
            //clsSetFieldVisibilityEN objSetFieldVisibilityEN;	//定义对象
            objSetFieldVisibilityEN = new clsSetFieldVisibilityEN();	//初始化新对象
            //3.1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToSetFieldVisibilityClass(objSetFieldVisibilityEN);		//把界面的值传到
            //5.1、检查传进去的对象属性是否合法
            try
            {
                clsSetFieldVisibilityBL.CheckPropertyNew(objSetFieldVisibilityEN);
                //6、把数据实体层的数据存贮到数据库中
                clsSetFieldVisibilityBL.AddNewRecordBySql2(objSetFieldVisibilityEN);
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
            BindGv_SetFieldVisibility();
            DispSetFieldVisibilityListRegion();
            wucSetFieldVisibilityB1.Clear();		//清空控件中内容
            ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelSetFieldVisibilityEdit.Text = "取消编辑";
            return true;
        }
        /// <summary>
        /// 插入记录存盘到数据表中，V5版
        /// </summary>
        /// <returns>插入记录是否成功？</returns>
        protected bool AddSetFieldVisibilityRecordSaveV5()
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
            clsSetFieldVisibilityEN objSetFieldVisibilityEN;
            //1、检查控件中输入数据类型是否正确
            if (!wucSetFieldVisibilityB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、定义对象并初始化对象
            //clsSetFieldVisibilityEN objSetFieldVisibilityEN;	//定义对象
            objSetFieldVisibilityEN = new clsSetFieldVisibilityEN();	//初始化新对象
            //3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToSetFieldVisibilityClass(objSetFieldVisibilityEN);		//把界面的值传到
            //5.1、检查传进去的对象属性是否合法
            try
            {
                clsSetFieldVisibilityBL.CheckPropertyNew(objSetFieldVisibilityEN);
                //6、把数据实体层的数据存贮到数据库中
                clsSetFieldVisibilityBL.AddNewRecordBySql2(objSetFieldVisibilityEN);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "添加记录不成功!" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            strMsg = "添加记录成功!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsgEdit.Text = "添加记录成功!";
            //7、把新添的记录内容显示在GridView中
            BindGv_SetFieldVisibility();
            DispSetFieldVisibilityListRegion();
            wucSetFieldVisibilityB1.Clear();		//清空控件中内容
            ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelSetFieldVisibilityEdit.Text = "取消编辑";
            return true;
        }
        #endregion 添加相关函数


        #region 修改相关函数

        /// <summary>
        ///修改当前被选记录
        /// </summary>
        protected void btnUpdate4Gv_Click(object sender, System.EventArgs e)
        {
            List<string> lstKeyValue = clsCommForWebForm.GetFirstCheckedItemFromGv(gvSetFieldVisibility, "mId");
            if (lstKeyValue.Count == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；
            string[] strKeys = lstKeyValue[0].Split(',');
            long lngmId = long.Parse(strKeys[0]);
            UpdateSetFieldVisibilityRecord(lngmId);
        }
        ///
        protected void gvSetFieldVisibility_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string strmId = gvSetFieldVisibility.DataKeys[e.RowIndex]["mId"].ToString();
            long lngmId = long.Parse(strmId);
            UpdateSetFieldVisibilityRecord(lngmId);
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
            if (clsSetFieldVisibilityBL.IsExist(lngmId) == false)		//检查该关键字的记录是否存在
            {
                string ss = "关键字为：" + lngmId + "的不存在!";
                clsCommonJsFunc.Alert(this, ss);
                return;
            }
            //3、用提供的关键字初始化一个类对象；
            clsSetFieldVisibilityEN objSetFieldVisibilityEN = new clsSetFieldVisibilityEN(lngmId);
            //4、获取类对象的所有属性；
            try
            {
                clsSetFieldVisibilityBL.GetSetFieldVisibility(ref objSetFieldVisibilityEN);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            Session.Add("objSetFieldVisibilityEN", objSetFieldVisibilityEN);
            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中
            GetDataFromSetFieldVisibilityClass(objSetFieldVisibilityEN);
        }
        /// <summary>
        /// 函数功能：把类对象的属性内容显示到界面上
        ///注意：如果有两个下拉框，并且是一级、二级连带关系的，请先为一级下拉框赋值，然后再为二级下拉框赋值
        /// 如果在设置数据库时，就应该一级字段在前，二级字段在后
        /// </summary>
        /// <param name="pobjSetFieldVisibilityEN">表实体类对象</param>
        protected void GetDataFromSetFieldVisibilityClass(clsSetFieldVisibilityEN pobjSetFieldVisibilityEN)
        {
            wucSetFieldVisibilityB1.IdSchool = pobjSetFieldVisibilityEN.IdSchool;// 学校流水号

            wucSetFieldVisibilityB1.ViewName = pobjSetFieldVisibilityEN.ViewName;// 界面名称
            wucSetFieldVisibilityB1.FieldName = pobjSetFieldVisibilityEN.FieldName;// 字段名
            wucSetFieldVisibilityB1.CtrlType = pobjSetFieldVisibilityEN.CtrlType;// 控件类型
            wucSetFieldVisibilityB1.IsVisible = pobjSetFieldVisibilityEN.IsVisible;// 是否显示
            wucSetFieldVisibilityB1.UpdDate = pobjSetFieldVisibilityEN.UpdDate;// 修改日期
            wucSetFieldVisibilityB1.UpdUserId = pobjSetFieldVisibilityEN.UpdUserId;// 修改用户Id
            wucSetFieldVisibilityB1.Memo = pobjSetFieldVisibilityEN.Memo;// 说明
        }
        /// <summary>
        /// 为修改记录做准备过程,把给定关键字的记录字段值显示在用户控件上
        /// </summary>
        protected void UpdateSetFieldVisibilityRecord(long lngmId)
        {
            //操作步骤：（总共2步）
            //1、显示该关键字记录的内容在界面上；
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；

            //1、显示该关键字记录的内容在界面上；
            ShowData(lngmId);
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；
            clsPubFun.SetButtonEnabled(btnOKUpd, true);
            btnOKUpd.Text = "确认修改";
            btnCancelSetFieldVisibilityEdit.Text = "取消修改";
            lblMsgEdit.Text = "";
            DispEditSetFieldVisibilityRegion();
        }
        /// <summary>
        /// 修改记录存盘到数据表中
        /// </summary>
        /// <param name="objSetFieldVisibilityEN">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        protected bool UpdateSetFieldVisibilityRecordSave(clsSetFieldVisibilityEN objSetFieldVisibilityEN)
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
            if (!wucSetFieldVisibilityB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToSetFieldVisibilityClass(objSetFieldVisibilityEN);		//把界面的值传到
            //3.1、检查传进去的对象属性是否合法
            try
            {
                clsSetFieldVisibilityBL.CheckPropertyNew(objSetFieldVisibilityEN);
                //4、把数据实体层的数据存贮到数据库中
                clsSetFieldVisibilityBL.UpdateBySql2(objSetFieldVisibilityEN);
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
            BindGv_SetFieldVisibility();
            DispSetFieldVisibilityListRegion();
            wucSetFieldVisibilityB1.Clear();//添空控件中的内容
            //恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelSetFieldVisibilityEdit.Text = "取消编辑";
            return true;
        }
        /// <summary>
        /// 修改记录存盘到数据表中, V5版
        /// </summary>
        /// <param name="objSetFieldVisibilityEN">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        protected bool UpdateSetFieldVisibilityRecordSaveV5(clsSetFieldVisibilityEN objSetFieldVisibilityEN)
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
            if (!wucSetFieldVisibilityB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToSetFieldVisibilityClass(objSetFieldVisibilityEN);		//把界面的值传到
            //3.1、检查传进去的对象属性是否合法
            try
            {
                clsSetFieldVisibilityBL.CheckPropertyNew(objSetFieldVisibilityEN);
                //4、把数据实体层的数据存贮到数据库中
                clsSetFieldVisibilityBL.UpdateBySql2(objSetFieldVisibilityEN);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "修改记录不成功!" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            strMsg = "修改记录成功!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsgEdit.Text = "修改记录成功!";
            //5、把修改后的内容显示在GridView中
            BindGv_SetFieldVisibility();
            DispSetFieldVisibilityListRegion();
            wucSetFieldVisibilityB1.Clear();//添空控件中的内容
            //恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelSetFieldVisibilityEdit.Text = "取消编辑";
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
            clsSetFieldVisibilityEN objSetFieldVisibilityEN;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "添加":
                    AddSetFieldVisibilityRecord();
                    break;
                case "确认添加":
                    //这是一个单表的插入的代码，由于逻辑层太简单，
                    //就把逻辑层合并到控制层,
                    AddSetFieldVisibilityRecordSave();
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码，由于逻辑层太简单，
                    //就把逻辑层合并到控制层,
                    objSetFieldVisibilityEN = (clsSetFieldVisibilityEN)Session["objSetFieldVisibilityEN"];
                    UpdateSetFieldVisibilityRecordSave(objSetFieldVisibilityEN);
                    break;
            }
        }
        ///
        protected void btnCancelSetFieldVisibilityEdit_Click(object sender, EventArgs e)
        {
            DispSetFieldVisibilityListRegion();
        }
        /// <summary>
        /// 函数功能：把界面上的属性数据传到类对象中
        /// </summary>
        /// <param name="pobjSetFieldVisibilityEN">数据传输的目的类对象</param>
        protected void PutDataToSetFieldVisibilityClass(clsSetFieldVisibilityEN pobjSetFieldVisibilityEN)
        {
            pobjSetFieldVisibilityEN.IdSchool = wucSetFieldVisibilityB1.IdSchool;// 学校流水号
            //pobjSetFieldVisibilityEN.UserId = wucSetFieldVisibilityB1.UserId;// 用户ID
            pobjSetFieldVisibilityEN.ViewName = wucSetFieldVisibilityB1.ViewName;// 界面名称
            pobjSetFieldVisibilityEN.FieldName = wucSetFieldVisibilityB1.FieldName;// 字段名
            pobjSetFieldVisibilityEN.CtrlType = wucSetFieldVisibilityB1.CtrlType;// 控件类型
            pobjSetFieldVisibilityEN.IsVisible = wucSetFieldVisibilityB1.IsVisible;// 是否显示
            pobjSetFieldVisibilityEN.UpdDate = wucSetFieldVisibilityB1.UpdDate;// 修改日期
            pobjSetFieldVisibilityEN.UpdUserId = wucSetFieldVisibilityB1.UpdUserId;// 修改用户Id
            pobjSetFieldVisibilityEN.Memo = wucSetFieldVisibilityB1.Memo;// 说明
        }

        #endregion 添加修改共用函数


        #region 删除相关函数

        /// <summary>
        ///删除当前被选记录
        /// </summary>
        protected void btnDelete4Gv_Click(object sender, System.EventArgs e)
        {
            List<string> lstKeyValues = clsCommForWebForm.GetAllCheckedItemFromGv(gvSetFieldVisibility, "chkCheckRec", "mId");
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
                    clsSetFieldVisibilityBL.DelRecord(lngmId);
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_SetFieldVisibility();
        }
        ///
        protected void gvSetFieldVisibility_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string strmId = gvSetFieldVisibility.DataKeys[e.RowIndex]["mId"].ToString();
            long lngmId = long.Parse(strmId);
            DeleteSetFieldVisibilityRecord(lngmId);
        }
        /// <summary>
        /// 根据给定关键字删除记录
        /// </summary>
        /// <param name="lngmId">给定关键字</param>
        protected void DeleteSetFieldVisibilityRecord(long lngmId)
        {
            try
            {
                clsSetFieldVisibilityBL.DelRecord(lngmId);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_SetFieldVisibility();
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
        /// 导出Excel。根据查询区组合的查询条件，从[vSetFieldVisibility]表中获取记录集，最终导出到Excel
        /// </summary>
        private void ExportExcel()
        {
            //	1、组合界面条件串；
            string strWhereCond = CombineSetFieldVisibilityCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "SetFieldVisibility信息导出.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add("IdSchool"); arrCnName.Add("学校流水号");
            arrColName.Add("UserId"); arrCnName.Add("用户ID");
            arrColName.Add("SchoolId"); arrCnName.Add("学校Id");
            arrColName.Add("SchoolName"); arrCnName.Add("学校名称");
            arrColName.Add("ViewName"); arrCnName.Add("界面名称");
            arrColName.Add("CtrlType"); arrCnName.Add("控件类型");
            arrColName.Add("FieldName"); arrCnName.Add("字段名");
            arrColName.Add("IsVisible"); arrCnName.Add("是否显示");
            arrColName.Add("UpdDate"); arrCnName.Add("修改日期");
            arrColName.Add("UpdUserId"); arrCnName.Add("修改用户Id");
            arrColName.Add("Memo"); arrCnName.Add("说明");
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
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
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
                objDT = clsvSetFieldVisibilityBL.GetDataTable(strWhereCond);
                //用户Odbc的方式来导出Excel,在Web服务器不需要安装Excel,目前是Excel2003,如果希望2007，可以换下面一条语句。
                GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4Odbc(objDT, arrColName, arrCnName, strDownLoadFileName);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            clsCommForWebForm.DownLoadFile(strDownLoadFileName);
        }
        #endregion 导出函数


        #region 布局控制函数
        /// <summary>
        /// 布局控制函数，显示用于编辑的用户控件，并隐藏数据列表区
        /// </summary>
        private void DispEditSetFieldVisibilityRegion()
        {
            divList.Visible = false;
            tabEditSetFieldVisibilityRegion.Visible = true;
        }
        /// <summary>
        /// 布局控制函数，显示数据列表区，并隐藏用于编辑的用户控件
        /// </summary>
        private void DispSetFieldVisibilityListRegion()
        {
            divList.Visible = true;
            tabEditSetFieldVisibilityRegion.Visible = false;
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

        protected void btnCloneNewRec4Gv_Click(object sender, EventArgs e)
        {
            List<string> lstKeyValue = clsCommForWebForm.GetFirstCheckedItemFromGv(gvSetFieldVisibility, "mId");
            if (lstKeyValue.Count == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；
            string[] strKeys = lstKeyValue[0].Split(',');
            long lngmId = long.Parse(strKeys[0]);
            clsSetFieldVisibilityEN obj = new clsSetFieldVisibilityEN(lngmId);
            clsSetFieldVisibilityBL.GetSetFieldVisibility(ref obj);
            obj.FieldName = "Copy_" + obj.FieldName;
            clsSetFieldVisibilityBL.AddNewRecordBySql2(obj);
            BindGv_SetFieldVisibility();
        }

        protected void btnSetIsVisible_Click(object sender, EventArgs e)
        {
            List<string> arrmIdLst = clsCommForWebForm.GetAllCheckedItemFromGv(gvSetFieldVisibility, "chkCheckRec");
            if (arrmIdLst.Count == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；
            long lngmId;
            foreach (string strmId in arrmIdLst)
            {
                lngmId = long.Parse(strmId);
                clsSetFieldVisibilityEN objSetFieldVisibility = clsSetFieldVisibilityBL.GetObjBymId(lngmId);
                objSetFieldVisibility.IsVisible = true;
                clsSetFieldVisibilityBL.UpdateBySql2(objSetFieldVisibility);

            }
            BindGv_SetFieldVisibility();
        }

        protected void btnSetIsNotVisible_Click(object sender, EventArgs e)
        {
            List<string> arrmIdLst = clsCommForWebForm.GetAllCheckedItemFromGv(gvSetFieldVisibility, "chkCheckRec");
            if (arrmIdLst.Count == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；
            long lngmId;
            foreach (string strmId in arrmIdLst)
            {
                lngmId = long.Parse(strmId);
                clsSetFieldVisibilityEN objSetFieldVisibility = clsSetFieldVisibilityBL.GetObjBymId(lngmId);
                objSetFieldVisibility.IsVisible = false;
                clsSetFieldVisibilityBL.UpdateBySql2(objSetFieldVisibility);

            }
            BindGv_SetFieldVisibility();
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