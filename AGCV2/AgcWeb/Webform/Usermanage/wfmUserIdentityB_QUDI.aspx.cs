﻿
///----------------------
///生成代码版本:2017.02.05.1
///生成日期:2017/02/26
///生成者:
///工程名称:教育高地
///工程ID:0042
///模块中文名:用户管理
///模块英文名:UserManage
///注意:1、需要数据底层(PubDataBase.dll)的版本:2017.02.21.01
///       2、需要公共函数层(TzPubFunction.dll)的版本:2016.12.13.01
/// ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == 



using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.datetime;
using CommFunc4WebForm;
using AGC.Entity;

using AGC.BusinessLogic;using AGC.FunClass;




namespace AGC.Webform
{
    /// <summary>
    /// wfmUserIdentityB_QUDI 的摘要说明。其中Q代表查询,U代表修改
    /// </summary>
    public partial class wfmUserIdentityB_QUDI : CommWebPageBase
    {

        /// <summary>
        /// ViewState属性:当前操作的界面功能名称
        /// (AGC.BusinessLogicEx.AutoGC_Cs_CWeb_PubFun:GenPotenceRelaVar)
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
        /// (AGC.BusinessLogicEx.AutoGC_Cs_CWeb_PubFun:GenPotenceRelaVar)
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
        /// (AGC.BusinessLogicEx.AutoGC_Cs_CWeb_PubFun:GenPotenceRelaVar)
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
        /// 与权限相关的界面编号
        /// (AGC.BusinessLogicEx.AutoGC_Cs_CWeb_PubFun:GenPotenceRelaVar)
        /// </summary>
        protected const string ViewId4Potence = "00260203";     //界面编号


        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面
            if (!IsPostBack)    ///如果本界面是初次被调用,而不是单击按钮事件所调用
            {

                vsViewName = "用户权限身份表维护";
                vsTabName = string.Format("{0}", clsUserIdentityEN._CurrTabName);
                //生成权限有关判断权限的代码
                //根据等级权限编号来确定用户可以使用什么功能,等级编号方式:1为最大2其次,依此类推
                switch (vsPotenceLevel)
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


                //1、为下拉框设置数据源,绑定列表数据
                vsSortUserIdentityBy = "IdentityID Asc";
                //2、显示无条件的表内容在DATAGRID中
                BindGv_UserIdentity();
                //3、设置表控件中字控件的ReadOnly属性,
                //   使之只读,因为在修改功能中关键字是不能被修改的。
                wucUserIdentityB1.SetKeyReadOnly(true);
                DispUserIdentityListRegion();
            }
        }

        /// <summary>
        /// 函数功能:事件函数,当单击<查询>按钮时所发生的事件
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void btnQuery_Click(object sender, System.EventArgs e)
        {
            //把DATAGRID的当前页索引设置为0,即第1页。
            //当单击查询时,首先显示的是表记录内容的第一部分内容。
            this.gvUserIdentity.PageIndex = 0;
            //把表记录的内容显示在DATAGRID中
            BindGv_UserIdentity();
        }
        /// <summary>
        /// 函数功能:事件函数,在更改DATAGRID的当前页索引时激发的函数。
        ///			  具体功能是重新显示新页(所单击页索引)的内容。
        /// </summary>
        /// <param name = "source"></param>
        /// <param name = "e"></param>
        protected void gvUserIdentity_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            //操作步骤:(共2步)
            //1、设置当前页的页索引,即把新单击的页索引赋给当前页索引
            //2、重新绑定DATAGRID,使之内容更新,变化到新的页

            //1、设置当前页的页索引,即把新单击的页索引赋给当前页索引
            this.gvUserIdentity.PageIndex = e.NewPageIndex;
            //2、重新绑定DATAGRID,使之内容更新,变化到新的页
            BindGv_UserIdentity();
        }
        /// <summary>
        /// 函数功能:把以该关键字的记录内容显示在界面上,
        ///　　　     在这里是把值传到表控件中
        /// </summary>
        /// <param name = "strIdentityID">表记录的关键字,显示该表关键字的内容</param>
        /// <summary>
        /// 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
        ///           具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void btnOKUpd_Click(object sender, System.EventArgs e)
        {
            string strCommandText;
            clsUserIdentityEN objUserIdentityEN;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "添加":
                    AddUserIdentityRecord();
                    break;
                case "确认添加":
                    //这是一个单表的插入的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    AddUserIdentityRecordSave();
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    objUserIdentityEN = (clsUserIdentityEN)Session["objUserIdentityEN"];
                    UpdateUserIdentityRecordSave(objUserIdentityEN);
                    break;
            }
        }

        ///添加新记录的事件过程,建议在该过程中调用其他函数,不要在其中添加多行代码。
        protected void btnAddNewRec4Gv_Click(object sender, System.EventArgs e)
        {
            AddUserIdentityRecord();
        }

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
        ///删除当前被选记录
        /// (AGC.BusinessLogicEx.AutoGC_Cs_CWeb_PubFun:GenbtnDelete4Gv_Click4OneKeyword)
        /// </summary>
        protected void btnDelete4Gv_Click(object sender, System.EventArgs e)
        {
            List<string> lstIdentityID = clsCommForWebForm.GetAllCheckedItemFromGv(gvUserIdentity, "chkCheckRec", "IdentityID");
            if (lstIdentityID.Count == 0)
            {
                lblMsgList.Text = "(errid:WebI002397)没有选择记录,请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            try
            {
                foreach (string strIdentityID in lstIdentityID)
                {
                    clsUserIdentityBL.DelRecord(strIdentityID);
                }
            }
            catch (Exception objException)
            {
                seErrMessage = objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_UserIdentity();
        }

        /// <summary>
        ///修改当前被选记录
        /// (AGC.BusinessLogicEx.AutoGC_Cs_CWeb_PubFun:GenbtnUpdate4Gv_Click4OneKeyword)
        /// </summary>
        protected void btnUpdate4Gv_Click(object sender, System.EventArgs e)
        {
            List<string> lstIdentityID = clsCommForWebForm.GetFirstCheckedItemFromGv(gvUserIdentity, "IdentityID");
            if (lstIdentityID.Count == 0)
            {
                lblMsgList.Text = "(errid:WebI002398)没有选择记录,请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；
            string strIdentityID = lstIdentityID[0];
            UpdateUserIdentityRecord(strIdentityID);
        }
        /// <summary>
        /// 事件函数:在GridView中，单击列头进行排序所发生的事件
        /// (AGC.BusinessLogicEx.AutoGC_Cs_CWeb_PubFun:Gen_GridView_Sorting)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void gvUserIdentity_Sorting(object sender, GridViewSortEventArgs e)
        {
            int intIndex;
            //判断是否是新的排序字段
            intIndex = vsSortUserIdentityBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                vsSortUserIdentityBy = e.SortExpression + " Asc";
                BindGv_UserIdentity();
                return;
            }
            //检查原来是升序
            intIndex = vsSortUserIdentityBy.IndexOf(" Asc");
            if (intIndex == -1)     //如果原来不是升序就设置为升序
            {
                vsSortUserIdentityBy = e.SortExpression + " Asc";
            }
            else            ///否则设置为降序
            {
                vsSortUserIdentityBy = e.SortExpression + " Desc";
            }
            BindGv_UserIdentity();
        }

        /// <summary>
        /// 用于记录GridView中的当前排序表达式,以便决定下一次是升序,还是降序排序。
        /// (AGC.BusinessLogicEx.AutoGC_Cs_CWeb_PubFun:Gen_GridView_Sorting)
        /// </summary>
        protected string vsSortUserIdentityBy
        {
            get
            {
                string sSortUserIdentityBy;
                sSortUserIdentityBy = (string)ViewState["SortUserIdentityBy"];
                if (sSortUserIdentityBy == null)
                {
                    sSortUserIdentityBy = "";
                }
                return sSortUserIdentityBy;
            }
            set
            {
                string sSortUserIdentityBy = value;
                ViewState.Add("SortUserIdentityBy", sSortUserIdentityBy);
            }
        }

        /// <summary>
        /// 事件函数:生成与跳页的相关函数.在GridView的脚部，当单击跳转按钮时发生的事件，在这里主要处理:跳转到GridView的某一数。
        /// (AGC.BusinessLogicEx.AutoGC_Cs_CWeb_PubFun:GenJumpPage_RelaFunction)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void btnJumpPage_Click(object sender, EventArgs e)
        {
            GridViewRow pagerRow = gvUserIdentity.BottomPagerRow;
            TextBox txtJump2Page = (TextBox)pagerRow.FindControl("txtJump2Page");
            if (txtJump2Page != null)
            {
                if (txtJump2Page.Text.Trim() != "" &&
                int.Parse(txtJump2Page.Text) > 0 &&
                int.Parse(txtJump2Page.Text) - 1 < this.gvUserIdentity.PageCount)
                {
                    this.gvUserIdentity.PageIndex = int.Parse(txtJump2Page.Text) - 1;
                }
                this.BindGv_UserIdentity();
            }
        }


        /// <summary>
        /// 事件函数:在GridView的脚部，当每页记录数的下拉框发生改变时发生的事件，在这里主要处理:改变GridView的每页记录数。
        /// (AGC.BusinessLogicEx.AutoGC_Cs_CWeb_PubFun:GenddlPagerRecCount_SelectedIndexChanged)
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
                    BindGv_UserIdentity();
                }
            }
        }

        /// <summary>
        /// 事件函数:在GridView中，当单击GeidView行中的命令按钮时发生的事件，在这里主要处理:在列头显示单击全选按钮时全选GridView的所有行。
        /// (AGC.BusinessLogicEx.AutoGC_Cs_CWeb_PubFun:Gen_GridView_RowCommand)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void gvUserIdentity_RowCommand(object sender, GridViewCommandEventArgs e)
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
                        clsCommForWebForm.Set_GridViewAllChecked(gvUserIdentity, true);
                        lbSelAll.Text = "不选";
                    }
                    else if (lbSelAll.Text == "不选")
                    {
                        clsCommForWebForm.Set_GridViewAllChecked(gvUserIdentity, false);
                        lbSelAll.Text = "全选";
                    }
                    break;
            }
        }
        /// <summary>
        /// 事件函数:在GridView中，当GeidView行建立时发生的事件，在这里主要处理:数据行中处理删除时显示提示信息，还有在列头显示排序标志。
        /// (AGC.BusinessLogicEx.AutoGC_Cs_CWeb_PubFun:Gen_GridView_RowCreated)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void gvUserIdentity_RowCreated(object sender, GridViewRowEventArgs e)
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
            if (vsSortUserIdentityBy == "") return;
            if (e.Row.RowType == DataControlRowType.Header)//点击控件是否为页眉；
            {
                string strSortEx;
                for (int i = 0; i < this.gvUserIdentity.Columns.Count; i++)
                {
                    strSortEx = this.gvUserIdentity.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = vsSortUserIdentityBy.IndexOf(strSortEx + " ");
                    if (intIndex >= 0) //视图状态的排序表达式是否为该列的字段；
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//设置字体,在"webdings"中5是上三角,6是下三角；
                        intIndex = vsSortUserIdentityBy.IndexOf("Asc");
                        lblSort.Text = (intIndex > 0 ? " 5" : " 6");//是否为升序,而且为string型；
                        e.Row.Cells[i].Controls.Add(lblSort);//被引用项的第i个单元格中增添一控件；
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// 事件函数:在GridView中，进行行删除(RowDeleting)
        /// (AGC.BusinessLogicEx.AutoGC_Cs_CWeb_PubFun:Gen_GridView_RowDeleting)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void gvUserIdentity_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string strIdentityID = gvUserIdentity.DataKeys[e.RowIndex]["IdentityID"].ToString();
            DeleteUserIdentityRecord(strIdentityID);
        }
        ///
        protected void gvUserIdentity_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string strIdentityID = gvUserIdentity.DataKeys[e.RowIndex]["IdentityID"].ToString();
            UpdateUserIdentityRecord(strIdentityID);
        }
        /// <summary>
        /// 函数功能:事件函数,在更改GridView的当前页索引时激发的函数。
        ///			 具体功能是重新显示新页(所单击页索引)的内容。
        /// (AGC.BusinessLogicEx.AutoGC_Cs_CWeb_PubFun:Gen_GridView_PageIndexChanging)
        /// </summary>
        /// <param name = "source"></param>
        /// <param name = "e"></param>
        protected void gvUserIdentity_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            //操作步骤:(共2步)
            //1、设置当前页的页索引,即把新单击的页索引赋给当前页索引
            //2、重新绑定GridView,使之内容更新,变化到新的页

            if (e.NewPageIndex != -1)
            {
                //1、设置当前页的页索引,即把新单击的页索引赋给当前页索引
                gvUserIdentity.PageIndex = e.NewPageIndex;
                //2、重新绑定GridView,使之内容更新,变化到新的页
                this.BindGv_UserIdentity();
            }
        }
        /// <summary>
        /// 事件函数:取消编辑状态，退回到列表状态
        /// (AGC.BusinessLogicEx.AutoGC_Cs_CWeb_PubFun:Gen_btnCancelEdit_Click)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void btnCancelUserIdentityEdit_Click(object sender, EventArgs e)
        {
            DispUserIdentityListRegion();
        }

    }
    public partial class wfmUserIdentityB_QUDI : CommWebPageBase
    {

        /// <summary>
        /// 函数功能:把以该关键字的记录内容显示在界面上,
        ///　　　   在这里是把值传到表控件中
        /// (AGC.BusinessLogicEx.AutoGC_Cs_CWeb_PubFun:GenShowDataCode)
        /// </summary>
        /// <param name = "strIdentityID">表记录的关键字,显示该表关键字的内容</param>
        protected void ShowData(string strIdentityID)
        {
            //操作步骤:
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中

            //1、检查关键字是否为空；
            if (strIdentityID == "") return;        //如果关键字为空就返回退出
                                                    //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            if (clsUserIdentityBL.IsExist(strIdentityID) == false)      //检查该关键字的记录是否存在
            {
                string strMsg = "(errid:WebI002399)在表[UserIdentity]中,关键字为:[strIdentityID]的记录不存在!";
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            //3、用提供的关键字初始化一个类对象；
            clsUserIdentityEN objUserIdentityEN = new clsUserIdentityEN(strIdentityID);
            //4、获取类对象的所有属性；
            try
            {
                clsUserIdentityBL.GetUserIdentity(ref objUserIdentityEN);
            }
            catch (Exception objException)
            {
                seErrMessage = objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            Session.Add("objUserIdentityEN", objUserIdentityEN);
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
            GetDataFromUserIdentityClass(objUserIdentityEN);
        }

        /// <summary>
        /// ViewState属性:用于记录当前用户在当前界面的权限等级
        /// (AGC.BusinessLogicEx.AutoGC_Cs_CWeb_PubFun:GenPotenceLevelProperty)
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
        /// (AGC.BusinessLogicEx.AutoGC_Cs_CWeb_PubFun:GenLoginUserSession)
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




        /// <summary>
        /// 专门用于记录GridView中的每页记录数
        /// (AGC.BusinessLogicEx.AutoGC_Cs_CWeb_PubFun:GenPageSizeViewState)
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


        /// <summary>
        /// Session属性:错误信息的Session属性,该Session传递给显示出错页面,显示相应的错误内容。
        /// (AGC.BusinessLogicEx.AutoGC_Cs_CWeb_PubFun:GenErrMessageSession)
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
        /// (AGC.BusinessLogicEx.AutoGC_Cs_CWeb_PubFun:GenBackLinkStrSession)
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

        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// (AGC.BusinessLogicEx.AutoGC_Cs_CWeb_PubFun:GenCombineCondition)
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        protected string CombineUserIdentityCondition()
        {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && UserName = '张三'
            string strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try
            {
                if (this.txtIdentityIDq.Text.Trim() != "")
                {
                    strWhereCond += string.Format(" And {0} like '%{1}%'", conUserIdentity.IdentityID, this.txtIdentityIDq.Text.Trim());
                }
                if (this.txtIdentityDescq.Text.Trim() != "")
                {
                    strWhereCond += string.Format(" And {0} like '%{1}%'", conUserIdentity.IdentityDesc, this.txtIdentityDescq.Text.Trim());
                }
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:WebI002400)在组合查询条件(CombineUserIdentityCondition)时出错!请联系管理员!" + objException.Message);
                throw new Exception(strMsg);
            }
            return strWhereCond;
        }
        /// <summary>
        /// 函数功能:把查询数据绑定在GridView上。根据界面上查询控件中所设置内容查询表记录,
        ///			 并显示在GridView中。
        /// (AGC.BusinessLogicEx.AutoGC_Cs_CWeb_PubFun:GenBindGridView)
        /// </summary>
        protected void BindGv_UserIdentity()
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
                string strWhereCond = CombineUserIdentityCondition();
                //	2、根据条件串获取该表满足条件的DataTable；
                objDT = clsUserIdentityBL.GetDataTable_UserIdentity(strWhereCond);
            }
            catch (Exception objException)
            {
                seErrMessage = "(errid:WebI002401)获取数据表(DataTable)不成功!" + objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            //	4、设置GRIDView的数据源(DataSource)；
            DataView objDV = objDT.DefaultView;
            objDV.Sort = vsSortUserIdentityBy; ///注意这一行代码有可能需要注释掉,目前这行仅仅在单独的查询界面中起作用
                                               ///设置GridView中每页的记录数
            if (string.IsNullOrEmpty(PageSize) == false)
            {
                int intPageSize = int.Parse(PageSize);
                gvUserIdentity.PageSize = intPageSize;
            }
            else
            {
                PageSize = "10";
                gvUserIdentity.PageSize = 10;
            }
            this.gvUserIdentity.DataSource = objDV;
            //	5、绑定GridView,即把DataTable的内容显示在GridView中
            this.gvUserIdentity.DataBind();

            ///生成专门用于BindGv中的跳页相关代码
            GridViewRow pagerRow = gvUserIdentity.BottomPagerRow;
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
                lblAllPages.Text = this.gvUserIdentity.PageCount.ToString();
                //当前页序数
                lblCurrentPage.Text = (this.gvUserIdentity.PageIndex + 1).ToString();
                //当前即将跳到的页序数
                txtJump2Page.Text = (this.gvUserIdentity.PageIndex + 1).ToString();
                //如果当前页序数为0,则<前一页>按钮无效
                if (this.gvUserIdentity.PageIndex == 0)
                {
                    btnPrevPage.Enabled = false;
                }
                else
                {
                    btnPrevPage.Enabled = true;
                }
                //如果当前页序数已为最后一页,则<前一页>按钮无效
                if (this.gvUserIdentity.PageIndex == this.gvUserIdentity.PageCount - 1)
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
            gvUserIdentity.BottomPagerRow.Visible = true;
        }


        /// <summary>
        /// 函数功能:把类对象的属性内容显示到界面上
        ///注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
        /// 如果在设置数据库时,就应该一级字段在前,二级字段在后
        /// (AGC.BusinessLogicEx.AutoGC_Cs_CWeb_PubFun:GenGetDataFromClass)
        /// </summary>
        /// <param name = "pobjUserIdentityEN">表实体类对象</param>
        protected void GetDataFromUserIdentityClass(clsUserIdentityEN pobjUserIdentityEN)
        {
            wucUserIdentityB1.IdentityID = pobjUserIdentityEN.IdentityID;// 身份编号
            wucUserIdentityB1.IdentityDesc = pobjUserIdentityEN.IdentityDesc;// 身份描述
            wucUserIdentityB1.Memo = pobjUserIdentityEN.Memo;// 备注
        }
        /// <summary>
        /// 函数功能:把界面上的属性数据传到类对象中
        /// (AGC.BusinessLogicEx.AutoGC_Cs_CWeb_PubFun:GenPutDataToClass)
        /// </summary>
        /// <param name = "pobjUserIdentityEN">数据传输的目的类对象</param>
        protected void PutDataToUserIdentityClass(clsUserIdentityEN pobjUserIdentityEN)
        {
            pobjUserIdentityEN.IdentityID = wucUserIdentityB1.IdentityID;// 身份编号
            pobjUserIdentityEN.IdentityDesc = wucUserIdentityB1.IdentityDesc;// 身份描述
            pobjUserIdentityEN.Memo = wucUserIdentityB1.Memo;// 备注
        }

        /// <summary>
        /// 为插入记录做准备工作
        /// (AGC.BusinessLogicEx.AutoGC_Cs_CWeb_PubFun:GenAddRecordCode)
        /// </summary>
        protected void AddUserIdentityRecord()
        {
            wucUserIdentityB1.SetKeyReadOnly(false);
            btnOKUpd.Text = "确认添加";
            btnCancelUserIdentityEdit.Text = "取消添加";
            wucUserIdentityB1.IdentityID = clsUserIdentityBL.GetMaxStrId_S();
            DispEditUserIdentityRegion();
        }
        /// <summary>
        /// 插入记录存盘到数据表中
        /// (AGC.BusinessLogicEx.AutoGC_Cs_CWeb_PubFun:GenAddRecordSaveCode)
        /// </summary>
        /// <returns>插入记录是否成功？</returns>
        protected bool AddUserIdentityRecordSave()
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
            clsUserIdentityEN objUserIdentityEN;
            //1、检查控件中输入数据类型是否正确
            if (!wucUserIdentityB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI002402)控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、定义对象并初始化对象
            //clsUserIdentityEN objUserIdentityEN;	//定义对象
            objUserIdentityEN = new clsUserIdentityEN(wucUserIdentityB1.IdentityID);    //初始化新对象
                                                                                        //3.1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            if (clsUserIdentityBL.IsExist(objUserIdentityEN.IdentityID))    //判断是否有相同的关键字
            {
                strMsg = "(errid:WebI002403)关键字字段已有相同的值";
                clsCommonJsFunc.Alert(this, strMsg);
                return false;
            }
            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToUserIdentityClass(objUserIdentityEN);      //把界面的值传到
                                                                //5.1、检查传进去的对象属性是否合法
            try
            {
                clsUserIdentityBL.CheckPropertyNew(objUserIdentityEN);
                //6、把数据实体层的数据存贮到数据库中
                clsUserIdentityBL.AddNewRecordBySql2(objUserIdentityEN);
            }
            catch (Exception objException)
            {
                strMsg = "(errid:WebI002404)添加记录不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgEdit.Text = strMsg;
                return false;
            }
            strMsg = "添加记录成功!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsgEdit.Text = "添加记录成功!";
            //7、把新添的记录内容显示在GridView中
            BindGv_UserIdentity();
            DispUserIdentityListRegion();
            wucUserIdentityB1.Clear();      //清空控件中内容
                                            ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelUserIdentityEdit.Text = "取消编辑";
            return true;
        }
        /// <summary>
        /// 插入记录存盘到数据表中,V5版
        /// (AGC.BusinessLogicEx.AutoGC_Cs_CWeb_PubFun:GenAddRecordSaveCodeV5)
        /// </summary>
        /// <returns>插入记录是否成功？</returns>
        protected bool AddUserIdentityRecordSaveV5()
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
            clsUserIdentityEN objUserIdentityEN;
            //1、检查控件中输入数据类型是否正确
            if (!wucUserIdentityB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI002405)控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、定义对象并初始化对象
            //clsUserIdentityEN objUserIdentityEN;	//定义对象
            objUserIdentityEN = new clsUserIdentityEN(wucUserIdentityB1.IdentityID);    //初始化新对象
                                                                                        //3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            if (clsUserIdentityBL.IsExist(objUserIdentityEN.IdentityID))    //判断是否有相同的关键字
            {
                strMsg = "(errid:WebI002406)关键字字段已有相同的值";
                clsCommonJsFunc.Alert(this, strMsg);
                return false;
            }
            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToUserIdentityClass(objUserIdentityEN);      //把界面的值传到
                                                                //5.1、检查传进去的对象属性是否合法
            try
            {
                clsUserIdentityBL.CheckPropertyNew(objUserIdentityEN);
                //6、把数据实体层的数据存贮到数据库中
                clsUserIdentityBL.AddNewRecordBySql2(objUserIdentityEN);
            }
            catch (Exception objException)
            {
                seErrMessage = "(errid:WebI002407)添加记录不成功!" + objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            strMsg = "添加记录成功!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsgEdit.Text = "添加记录成功!";
            //7、把新添的记录内容显示在GridView中
            BindGv_UserIdentity();
            DispUserIdentityListRegion();
            wucUserIdentityB1.Clear();      //清空控件中内容
                                            ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelUserIdentityEdit.Text = "取消编辑";
            return true;
        }
        /// <summary>
        /// 为修改记录做准备过程,把给定关键字的记录字段值显示在用户控件上
        /// (AGC.BusinessLogicEx.AutoGC_Cs_CWeb_PubFun:GenUpdateRecordCode)
        /// </summary>
        protected void UpdateUserIdentityRecord(string strIdentityID)
        {
            //操作步骤:(总共2步)
            //1、显示该关键字记录的内容在界面上；
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；

            //1、显示该关键字记录的内容在界面上；
            ShowData(strIdentityID);
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；
            btnOKUpd.Enabled = true;
            wucUserIdentityB1.SetKeyReadOnly(true);
            btnOKUpd.Text = "确认修改";
            btnCancelUserIdentityEdit.Text = "取消修改";
            lblMsgEdit.Text = "";
            DispEditUserIdentityRegion();
        }
        /// <summary>
        /// 修改记录存盘到数据表中
        /// (AGC.BusinessLogicEx.AutoGC_Cs_CWeb_PubFun:GenUpdateRecordSaveCode)
        /// </summary>
        /// <param name = "objUserIdentityEN">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        protected bool UpdateUserIdentityRecordSave(clsUserIdentityEN objUserIdentityEN)
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
            if (!wucUserIdentityB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI002408)控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToUserIdentityClass(objUserIdentityEN);      //把界面的值传到
                                                                //3.1、检查传进去的对象属性是否合法
            try
            {
                clsUserIdentityBL.CheckPropertyNew(objUserIdentityEN);
                //4、把数据实体层的数据存贮到数据库中
                clsUserIdentityBL.UpdateBySql2(objUserIdentityEN);
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
            BindGv_UserIdentity();
            DispUserIdentityListRegion();
            wucUserIdentityB1.Clear();//添空控件中的内容
                                      //恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelUserIdentityEdit.Text = "取消编辑";
            //跳转到列表中刚刚的记录处,使用锚点功能。
            this.ClientScript.RegisterStartupScript(this.GetType(), "Go-Anchor", string.Format("this.location.href = '#A_UserIdentity{0}'", objUserIdentityEN.IdentityID.ToString().Trim()), true);
            return true;
        }
        /// <summary>
        /// 修改记录存盘到数据表中, V5版
        /// (AGC.BusinessLogicEx.AutoGC_Cs_CWeb_PubFun:GenUpdateRecordSaveCodeV5)
        /// </summary>
        /// <param name = "objUserIdentityEN">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        protected bool UpdateUserIdentityRecordSaveV5(clsUserIdentityEN objUserIdentityEN)
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
            if (!wucUserIdentityB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI002409)控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToUserIdentityClass(objUserIdentityEN);      //把界面的值传到
                                                                //3.1、检查传进去的对象属性是否合法
            try
            {
                clsUserIdentityBL.CheckPropertyNew(objUserIdentityEN);
                //4、把数据实体层的数据存贮到数据库中
                clsUserIdentityBL.UpdateBySql2(objUserIdentityEN);
            }
            catch (Exception objException)
            {
                seErrMessage = "修改记录不成功!" + objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            strMsg = "修改记录成功!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsgEdit.Text = "修改记录成功!";
            //5、把修改后的内容显示在GridView中
            BindGv_UserIdentity();
            DispUserIdentityListRegion();
            wucUserIdentityB1.Clear();//添空控件中的内容
                                      //恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelUserIdentityEdit.Text = "取消编辑";
            //跳转到列表中刚刚的记录处,使用锚点功能。
            this.ClientScript.RegisterStartupScript(this.GetType(), "Go-Anchor", string.Format("this.location.href = '#A_UserIdentity{0}'", objUserIdentityEN.IdentityID.ToString().Trim()), true);
            return true;
        }
        /// <summary>
        /// 根据给定关键字删除记录
        /// (AGC.BusinessLogicEx.AutoGC_Cs_CWeb_PubFun:GenDeleteRecordCode)
        /// </summary>
        /// <param name = "strIdentityID">给定关键字</param>
        protected void DeleteUserIdentityRecord(string strIdentityID)
        {
            try
            {
                clsUserIdentityBL.DelRecord(strIdentityID);
            }
            catch (Exception objException)
            {
                seErrMessage = objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_UserIdentity();
        }

        /// <summary>
        /// 导出Excel。根据查询区组合的查询条件,从[UserIdentity]表中获取记录集,最终导出到Excel
        /// (AGC.BusinessLogicEx.AutoGC_Cs_CWeb_PubFun:GenExportExcel)
        /// </summary>
        private void ExportExcel()
        {
            //	1、组合界面条件串；
            string strWhereCond = CombineUserIdentityCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "UserIdentity信息导出.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add(conUserIdentity.IdentityID); arrCnName.Add("身份编号");
            arrColName.Add(conUserIdentity.IdentityDesc); arrCnName.Add("身份描述");
            arrColName.Add(conUserIdentity.Memo); arrCnName.Add("备注");
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
                objDT = clsUserIdentityBL.GetDataTable_UserIdentity(strWhereCond);
                //用户Odbc的方式来导出Excel,在Web服务器不需要安装Excel,目前是Excel2003,如果希望2007,可以换下面一条语句。
                GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4Odbc(objDT, arrColName, arrCnName, strDownLoadFileName);
                //GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4OdbcExcel2007(objDT, arrColName, arrCnName, strDownLoadFileName);
                //GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr(objDT, arrColName, arrCnName, strDownLoadFileName);
            }
            catch (Exception objException)
            {
                seErrMessage = objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            clsCommForWebForm.DownLoadFile(strDownLoadFileName);
        }
        private void DispEditUserIdentityRegion()
        {
            tabUserIdentityGridView.Visible = false;
            tabEditUserIdentityRegion.Visible = true;
        }
        private void DispUserIdentityListRegion()
        {
            tabUserIdentityGridView.Visible = true;
            tabEditUserIdentityRegion.Visible = false;
        }
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