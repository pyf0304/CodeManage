﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:wucvDnFunction4Gv
 界面名:DnFunction_QUDI(00050300)
 生成代码版本:2020.08.04.1
 生成日期:2020/08/06 11:50:15
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.ddns.net,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:AI模块
 模块英文名:AIModule
 框架-层名:Web用户Gv控件后台(WebCtlControlCode4Gv)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
//生成与表相关的控件控制层代码
namespace AGC.Webform
{

using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
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
using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC;

 /// <summary>
 ///		wucvDnFunction4Gv 的摘要说明。
 /// (AutoGCLib.WebCtlControlCode4Gv4CSharp:GeneCode)
 /// </summary>
public partial class wucvDnFunction4Gv : System.Web.UI.UserControl
{
/// <summary>
/// 在GridView中，单击[修改]按钮时，所引发的修改事件
/// </summary>
public event OnGvUpdateClick GvUpdateClick;
        /// <summary>
/// 在GridView中，单击[删除]按钮时，所引发的修改事件
/// </summary>
public event OnGvDeleteClick GvDeleteClick;
#region 控件页面启动函数
 /// <summary>
 /// 函数功能:用户定义控件页面导入,当页面开始运行时所发生的事件
 /// (AutoGCLib.WebCtlControlCode4Gv4CSharp:GenPage_LoadCode4Wuc)
 /// </summary>
 /// <param name = "sender"></param>
 /// <param name = "e"></param>
protected void Page_Load(object sender, System.EventArgs e)
{
// 在此处放置用户代码以初始化页面

}

#endregion 控件页面启动函数
 /// <summary>
 /// 函数功能:把查询数据绑定在GridView上。根据界面上查询控件中所设置内容查询表记录,
 ///			 并显示在GridView中。
 /// (AutoGCLib.WebCtlControlCode4Gv4CSharp:Gen_Wuc4Gv_CS_BindGv)
 /// </summary>
public void BindGv_vDnFunction(string strWhereCond)
{
//操作步骤:(共5步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	4、设置GridView的数据源(DataSource)；
//	5、绑定GridView,即把DataTable的内容显示在GridView中
//	6、设置记录数的状态,
//		在本界面中是把状态显示在控件txtRecCount中。

 int intRecCount = 0;
int intPageCount = 0;
System.Data.DataTable objDT = null;
try
{
vsWhereCond = strWhereCond;
intRecCount = clsvDnFunctionBL.GetRecCountByCond(vsWhereCond);
vsRecCount = intRecCount;
intPageCount = GetPageCount(intRecCount, vsPageSize);
vsPageCount = intPageCount;
//	2、根据条件串获取该表满足条件的DataTable；
objDT = clsvDnFunctionBL.GetDataTableByPager(vsPageIndex, vsPageSize, strWhereCond, vsSortvDnFunctionBy);
}
catch (Exception objException)
{
seErrMessage = "(errid:WucL000001)获取数据表(DataTable)不成功!" + objException.Message;
seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
Response.Redirect(clsSysParaEN.ErrorPage);
}
//	4、设置GRIDView的数据源(DataSource)；
DataView objDV = objDT.DefaultView;
objDV.Sort = vsSortvDnFunctionBy; ///注意这一行代码有可能需要注释掉,目前这行仅仅在单独的查询界面中起作用
 ///设置GridView中每页的记录数
if (vsPageSize > 0)
{
int intPageSize = vsPageSize;
gvvDnFunction.PageSize = intPageSize;
}
else
{
vsPageSize = 15;
gvvDnFunction.PageSize = vsPageSize;
}
this.gvvDnFunction.DataSource = objDV;
//	5、绑定GridView,即把DataTable的内容显示在GridView中
this.gvvDnFunction.DataBind();

 ///生成专门用于BindGv中的跳页相关代码
GridViewRow pagerRow = gvvDnFunction.BottomPagerRow;
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
lblRecCount.Text = intRecCount.ToString(); 
//当前页数
lblAllPages.Text = intPageCount.ToString(); 
//当前页序数
lblCurrentPage.Text = vsPageIndex.ToString();
//当前即将跳到的页序数
txtJump2Page.Text = vsPageIndex.ToString();
//如果当前页序数为0,则<前一页>按钮无效
if(vsPageIndex == 1) 
{
btnPrevPage.Enabled = false; 
}
else 
{ 
btnPrevPage.Enabled = true; 
} 
//如果当前页序数已为最后一页,则<前一页>按钮无效
if(vsPageIndex == intPageCount) 
{ 
btnNextPage.Enabled = false; 
} 
else 
{ 
btnNextPage.Enabled = true; 
} 
//设置分页器中每页记录数的下拉框的值
if (vsPageSize>0)
{
ddlPagerRecCount.Text = vsPageSize.ToString();
}
else
{
vsPageSize = 15;
ddlPagerRecCount.Text = vsPageSize.ToString();
}
} 
gvvDnFunction.BottomPagerRow.Visible = true;
}



/// <summary>
/// 事件函数:生成与跳页的相关函数.在GridView的脚部，当单击跳转按钮时发生的事件，在这里主要处理:跳转到GridView的某一数。
 /// (AutoGCLib.WebCtlControlCode4Gv4CSharp:Gen_Wuc4Gv_CS_btnJumpPage_Click)
/// </summary>
/// <param name = "sender"></param>
/// <param name = "e"></param>
protected void btnJumpPage_Click(object sender, EventArgs e)
{
GridViewRow pagerRow = gvvDnFunction.BottomPagerRow;
TextBox txtJump2Page = (TextBox)pagerRow.FindControl("txtJump2Page");
if (txtJump2Page != null)
{
if(txtJump2Page.Text.Trim()!= "" && 
int.Parse(txtJump2Page.Text)>0 && 
int.Parse(txtJump2Page.Text)-1<this.gvvDnFunction.PageCount) 
{ 
this.gvvDnFunction.PageIndex = int.Parse(txtJump2Page.Text)-1; 
} 

BindGv_vDnFunction(vsWhereCond);
}
}


/// <summary>
/// 事件函数:在GridView的脚部，当每页记录数的下拉框发生改变时发生的事件，在这里主要处理:改变GridView的每页记录数。
 /// (AutoGCLib.WebCtlControlCode4Gv4CSharp:Gen_Wuc4Gv_CS_ddlPagerRecCount_SelectedIndexChanged)
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
vsPageSize = intPageSize;

BindGv_vDnFunction(vsWhereCond);
}
}
}

/// <summary>
/// 事件函数:在GridView中，当单击GeidView行中的命令按钮时发生的事件，在这里主要处理:在列头显示单击全选按钮时全选GridView的所有行。
 /// (AutoGCLib.WebCtlControlCode4Gv4CSharp:Gen_Wuc4Gv_CS_GridView_RowCommand)
/// </summary>
/// <param name = "sender"></param>
/// <param name = "e"></param>
protected void gvvDnFunction_RowCommand(object sender, GridViewCommandEventArgs e)
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
clsCommForWebForm.Set_GridViewAllChecked(gvvDnFunction, true);
lbSelAll.Text = "不选";
}
else if (lbSelAll.Text == "不选")
{
clsCommForWebForm.Set_GridViewAllChecked(gvvDnFunction, false);
lbSelAll.Text = "全选";
}
break;
case "NextPage":
//1、设置当前页的页索引,即把新单击的页索引赋给当前页索引
                    if (vsPageIndex < vsPageCount) vsPageIndex += 1;
//2、重新绑定GridView,使之内容更新,变化到新的页
try
{

BindGv_vDnFunction(vsWhereCond);
}
catch (Exception objException)
{
clsCommonJsFunc.Alert(this.Page, objException.Message);
}
break;
case "PrevPage":
//1、设置当前页的页索引,即把新单击的页索引赋给当前页索引
if (vsPageIndex > 1) vsPageIndex -= 1;
//2、重新绑定GridView,使之内容更新,变化到新的页

BindGv_vDnFunction(vsWhereCond);
break;
}
}
/// <summary>
/// 事件函数:在GridView中，当GeidView行建立时发生的事件，在这里主要处理:数据行中处理删除时显示提示信息，还有在列头显示排序标志。
 /// (AutoGCLib.WebCtlControlCode4Gv4CSharp:Gen_Wuc4Gv_CS_GridView_RowCreated)
/// </summary>
/// <param name = "sender"></param>
/// <param name = "e"></param>
protected void gvvDnFunction_RowCreated(object sender, GridViewRowEventArgs e)
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
if (vsSortvDnFunctionBy == "") return ;
if (e.Row.RowType == DataControlRowType.Header)//点击控件是否为页眉；
{
string strSortEx;
for(int i = 0;i<this.gvvDnFunction.Columns.Count;i++)
{
strSortEx = this.gvvDnFunction.Columns[i].SortExpression;
if (strSortEx == "") continue;
intIndex = vsSortvDnFunctionBy.IndexOf(strSortEx + " ");
if(intIndex >= 0) //视图状态的排序表达式是否为该列的字段；
{
Label lblSort = new Label();
lblSort.Font.Name = "webdings";//设置字体,在"webdings"中5是上三角,6是下三角；
intIndex = vsSortvDnFunctionBy.IndexOf("Asc");
lblSort.Text = (intIndex>0?" 5":" 6");//是否为升序,而且为string型；
e.Row.Cells[i].Controls.Add(lblSort);//被引用项的第i个单元格中增添一控件；
break;
}
}
}
}

 /// <summary>
 /// 函数功能:事件函数,在更改GridView的当前页索引时激发的函数。
 ///			 具体功能是重新显示新页(所单击页索引)的内容。
 /// (AutoGCLib.WebCtlControlCode4Gv4CSharp:Gen_Wuc4Gv_CS_GridView_PageIndexChanging)
 /// </summary>
 /// <param name = "source"></param>
 /// <param name = "e"></param>
protected void gvvDnFunction_PageIndexChanging(object sender, GridViewPageEventArgs e)
{
//操作步骤:(共2步)
//1、设置当前页的页索引,即把新单击的页索引赋给当前页索引
//2、重新绑定GridView,使之内容更新,变化到新的页

if (e.NewPageIndex != -1)
{
//1、设置当前页的页索引,即把新单击的页索引赋给当前页索引
gvvDnFunction.PageIndex = e.NewPageIndex;
//2、重新绑定GridView,使之内容更新,变化到新的页

BindGv_vDnFunction(vsWhereCond);
}
}
 ///
/// <summary>
/// 事件函数:在GridView中，当GeidView行单击修改时发生的事件，在这里主要处理:数据行中处理修改相关记录。
 /// (AutoGCLib.WebCtlControlCode4Gv4CSharp:Gen_Wuc4Gv_CS_GridView_RowUpdating)
/// </summary>
/// <param name = "sender"></param>
/// <param name = "e"></param>
protected void gvvDnFunction_RowUpdating(object sender, GridViewUpdateEventArgs e)
{
string strDnFunctionId = gvvDnFunction.DataKeys[e.RowIndex]["DnFunctionId"].ToString();
if (GvUpdateClick != null)
{             
clsEventArgs4Update objEventArgs4Update = new clsEventArgs4Update()
{
KeyId = strDnFunctionId.ToString()
};
GvUpdateClick(this, objEventArgs4Update);
}
}
/// <summary>
/// 事件函数:在GridView中，进行行删除(RowDeleting)
 /// (AutoGCLib.WebCtlControlCode4Gv4CSharp:Gen_Wuc4Gv_CS_GridView_RowDeleting)
/// </summary>
/// <param name = "sender"></param>
/// <param name = "e"></param>
protected void gvvDnFunction_RowDeleting(object sender, GridViewDeleteEventArgs e)
{
string strDnFunctionId = gvvDnFunction.DataKeys[e.RowIndex]["DnFunctionId"].ToString();
if (GvDeleteClick != null)
{             
clsEventArgs4Delete objEventArgs4Delete = new clsEventArgs4Delete()
{
KeyId = strDnFunctionId.ToString()
};
GvDeleteClick(this, objEventArgs4Delete);
}
}

 /// <summary>
 /// 专门用于记录GridView中的每页记录数
 /// (AutoGCLib.WebCtlControlCode4Gv4CSharp:Gen_Wuc4Gv_CS_vsPageSize)
 /// </summary>
public int vsPageSize
{
get
{
string strPageSize;
strPageSize = (string)ViewState["PageSize"];
if (strPageSize == null)
{
strPageSize = "";
return 15;
}
return int.Parse(strPageSize);
}
set
{
string strPageSize = value.ToString();
ViewState.Add("PageSize", strPageSize);
}
}



 /// <summary>
 /// 设置GridView中的页序号
 /// (AutoGCLib.WebCtlControlCode4Gv4CSharp:Gen_Wuc4Gv_CS_vsPageIndex)
 /// </summary>
public int vsPageIndex
{
 get
{
string strPageIndex;
strPageIndex = (string)ViewState["PageIndex"];
if (strPageIndex == null)
{
strPageIndex = "";
return 1;
}
return int.Parse(strPageIndex);
}
set
{
string strPageIndex = value.ToString();
ViewState.Add("PageIndex", strPageIndex);
}
}



 /// <summary>
 /// 设置GridView中的总页数
 /// (AutoGCLib.WebCtlControlCode4Gv4CSharp:Gen_Wuc4Gv_CS_vsPageCount)
 /// </summary>
public int vsPageCount
{
 get
{
string strPageCount;
strPageCount = (string)ViewState["PageCount"];
if (strPageCount == null)
{
strPageCount = "";
return 1;
}
return int.Parse(strPageCount);
}
set
{
string strPageCount = value.ToString();
ViewState.Add("PageCount", strPageCount);
}
}



 /// <summary>
 /// 设置GridView中的总页数
 /// (AutoGCLib.WebCtlControlCode4Gv4CSharp:Gen_Wuc4Gv_CS_vsRecCount)
 /// </summary>
public int vsRecCount
{
get
{
string strRecCount;
strRecCount = (string)ViewState["RecCount"];
if (strRecCount == null)
{
strRecCount = "";
return 1;
}
return int.Parse(strRecCount);
}
set
{
string strRecCount = value.ToString();
ViewState.Add("RecCount", strRecCount);
}
}



 /// <summary>
 /// 函数功能:计算当前页数，根据记录数和每页记录数
 /// (AutoGCLib.WebCtlControlCode4Gv4CSharp:Gen_Wuc4Gv_CS_GetPageCount)
 /// </summary>
 /// <param name = "intRecCount">总记录数</param>
 /// <param name = "intPageSize">每页记录数</param>
private int GetPageCount(int intRecCount, int intPageSize)
{
if (intRecCount == 0) return 0;
int intPageCount = intRecCount / intPageSize;
if (intRecCount % intPageSize == 0) return intPageCount;
return intPageCount + 1;
}

#region 排序相关函数
/// <summary>
/// 事件函数:在GridView中，单击列头进行排序所发生的事件
 /// (AutoGCLib.WebCtlControlCode4Gv4CSharp:Gen_Wuc4Gv_CS_GridView_Sorting)
/// </summary>
/// <param name = "sender"></param>
/// <param name = "e"></param>
protected void gvvDnFunction_Sorting(object sender, GridViewSortEventArgs e)
{
int intIndex;
//判断是否是新的排序字段
intIndex = vsSortvDnFunctionBy.IndexOf(e.SortExpression);
if (intIndex == -1)
{
vsSortvDnFunctionBy = e.SortExpression + " Asc";

BindGv_vDnFunction(vsWhereCond);
return ;
}
//检查原来是升序
intIndex = vsSortvDnFunctionBy.IndexOf(" Asc");
if (intIndex == -1)		//如果原来不是升序就设置为升序
{
vsSortvDnFunctionBy = e.SortExpression + " Asc";
}
else			///否则设置为降序
{
vsSortvDnFunctionBy = e.SortExpression + " Desc";
}

BindGv_vDnFunction(vsWhereCond);
}

 /// <summary>
 /// 用于记录GridView中的当前排序表达式,以便决定下一次是升序,还是降序排序。
 /// (AutoGCLib.WebCtlControlCode4Gv4CSharp:Gen_Wuc4Gv_CS_GridView_Sorting)
 /// </summary>
protected string vsSortvDnFunctionBy
{
get
{
string sSortvDnFunctionBy;
sSortvDnFunctionBy = (string)ViewState["SortvDnFunctionBy"];
if (sSortvDnFunctionBy == null) 
{
sSortvDnFunctionBy = "";
}
return sSortvDnFunctionBy;
}
set
{
string sSortvDnFunctionBy = value;
ViewState.Add("SortvDnFunctionBy", sSortvDnFunctionBy);
}
}
#endregion 排序相关函数
 /// <summary>
 /// 用于记录GridView中的当前排序表达式,以便决定下一次是升序,还是降序排序。
 /// (AutoGCLib.WebCtlControlCode4Gv4CSharp:Gen_Wuc4Gv_CS_vsWhereCond)
 /// </summary>
protected string vsWhereCond
{
get
{
string sWhereCond;
sWhereCond = (string)ViewState["WhereCond"];
if (sWhereCond == null) 
{
sWhereCond = "";
}
return sWhereCond;
}
set
{
string sWhereCond = value;
ViewState.Add("WhereCond", sWhereCond);
}
}

 /// <summary>
 /// Session属性:错误信息的Session属性,该Session传递给显示出错页面,显示相应的错误内容。
 /// (AutoGCLib.WebCtlControlCode4Gv4CSharp:Gen_Wuc4Gv_CS_seErrMessage)
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
 /// (AutoGCLib.WebCtlControlCode4Gv4CSharp:Gen_Wuc4Gv_CS_seBackErrPageLinkStr)
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
 /// 设置GridView字段的可见性,所有字段都显示
 /// (AutoGCLib.WebCtlControlCode4Gv4CSharp:Gen_Wuc4Gv_CS_SetGvVisibility_AllShow)
 /// </summary>
public void SetGvVisibility_AllShow()
{
clsCommForWebForm.SetGvVisibility(gvvDnFunction, convDnFunction.DnFunctionId, true);
clsCommForWebForm.SetGvVisibility(gvvDnFunction, convDnFunction.DnFunctionName, true);
clsCommForWebForm.SetGvVisibility(gvvDnFunction, convDnFunction.AssociationMappingName, true);
clsCommForWebForm.SetGvVisibility(gvvDnFunction, convDnFunction.UpdDate, true);
clsCommForWebForm.SetGvVisibility(gvvDnFunction, convDnFunction.UpdUser, true);
clsCommForWebForm.SetGvVisibility(gvvDnFunction, convDnFunction.Memo, true);
}

 /// <summary>
 /// 设置GridView字段的可见性,所有字段都隐藏
 /// (AutoGCLib.WebCtlControlCode4Gv4CSharp:Gen_Wuc4Gv_CS_SetGvVisibility_AllHide)
 /// </summary>
public void SetGvVisibility_AllHide()
{
clsCommForWebForm.SetGvVisibility(gvvDnFunction, convDnFunction.DnFunctionId, false);
clsCommForWebForm.SetGvVisibility(gvvDnFunction, convDnFunction.DnFunctionName, false);
clsCommForWebForm.SetGvVisibility(gvvDnFunction, convDnFunction.AssociationMappingName, false);
clsCommForWebForm.SetGvVisibility(gvvDnFunction, convDnFunction.UpdDate, false);
clsCommForWebForm.SetGvVisibility(gvvDnFunction, convDnFunction.UpdUser, false);
clsCommForWebForm.SetGvVisibility(gvvDnFunction, convDnFunction.Memo, false);
}

 /// <summary>
 /// 设置GridView字段的可见性
 /// (AutoGCLib.WebCtlControlCode4Gv4CSharp:Gen_Wuc4Gv_CS_SetGvVisibility)
 /// </summary>
public void SetGvVisibility(string strColumnName, bool bolIsVisible)
{
clsCommForWebForm.SetGvVisibility(gvvDnFunction, strColumnName, bolIsVisible);
}


 /// <summary>
 /// 设置GridView的可见性
 /// (AutoGCLib.WebCtlControlCode4Gv4CSharp:Gen_Wuc4Gv_CS_SetVisible)
 /// </summary>
public void SetVisible(bool bolVisible)
{
gvvDnFunction.Visible = bolVisible;
}


 /// <summary>
 ///从列表中获取所有选择的关键字
 /// (AutoGCLib.WebCtlControlCode4Gv4CSharp:Gen_Wuc4Gv_CS_GetAllCheckedKeysFromGv)
 /// </summary>/// <returns>返回所有选择的关键字列表</returns>
public List<string> GetAllCheckedKeysFromGv()
{
List<string> lstDnFunctionId = clsCommForWebForm.GetAllCheckedItemFromGv(gvvDnFunction, "chkCheckRec", conDnFunction.DnFunctionId);
if (lstDnFunctionId.Count == 0) 
{
clsCommonJsFunc.Alert(this, "(errid:WucL000002)没有选择记录,请选择有效的表记录!");
return null;
}
return lstDnFunctionId;
}


 /// <summary>
 ///从列表中获取选择的第一个关键字
 /// (AutoGCLib.WebCtlControlCode4Gv4CSharp:Gen_Wuc4Gv_CS_GetFirstCheckedKeyFromGv)
 /// </summary>/// <returns>返回选择的第一个关键字</returns>
public string GetFirstCheckedKeyFromGv()
{
List<string> lstDnFunctionId = clsCommForWebForm.GetFirstCheckedItemFromGv(gvvDnFunction,conDnFunction.DnFunctionId);
if (lstDnFunctionId.Count == 0) 
{
clsCommonJsFunc.Alert(this, "(errid:WucL000003)没有选择记录,请选择有效的表记录!");
return "";
}
//1、显示该关键字的数据让用户修改该关键字记录；
string strDnFunctionId = lstDnFunctionId[0];
 return strDnFunctionId;
}


 /// <summary>
 /// 设置在GridView中选择一个项(一条记录)
 /// (AutoGCLib.WebCtlControlCode4Gv4CSharp:Gen_Wuc4Gv_CS_SetCheckedItemForGv)
 /// </summary>
public bool SetCheckedItemForGv(string strDnFunctionId)
{
clsCommForWebForm.SetCheckedItemForGv(gvvDnFunction, 1, strDnFunctionId.ToString());
return true;
}


 /// <summary>
 /// 设置在GridView中选择多个项(多条记录)
 /// (AutoGCLib.WebCtlControlCode4Gv4CSharp:Gen_Wuc4Gv_CS_SetCheckedItemsForGv)
 /// </summary>
public bool SetCheckedItemsForGv(List<string> arrDnFunctionId)
{
clsCommForWebForm.SetCheckedItemsForGv(gvvDnFunction, 1, arrDnFunctionId);
return true;
}


 ///
/// <summary>
/// 事件函数:在Gv列表控件中，当GeidView行单击全选复选框时发生的事件。
 /// (AutoGCLib.WebCtlControlCode4Gv4CSharp:Gen_Wuc4Gv_CS_chkSelAll_CheckedChanged)
/// </summary>
/// <param name = "sender"></param>
/// <param name = "e"></param>
protected void chkSelAll_CheckedChanged(object sender, EventArgs e)
{
CheckBox chkSelAll = (CheckBox)sender;
if (chkSelAll.Checked == true)
{
clsCommForWebForm.Set_GridViewAllChecked(gvvDnFunction, true);
}
else
{
clsCommForWebForm.Set_GridViewAllChecked(gvvDnFunction, false);
}
}

 /// <summary>
 /// 设置GridView的可见性
 /// (AutoGCLib.WebCtlControlCode4Gv4CSharp:Gen_Wuc4Gv_CS_SetSortBy)
 /// </summary>
public void SetSortBy(string strSortBy)
{
 if (string.IsNullOrEmpty(vsSortvDnFunctionBy) == true)
{
vsSortvDnFunctionBy = strSortBy;
}
}

 /// <summary>
 /// 用于记录GridView中的当前条件对象。
 /// (AutoGCLib.WebCtlControlCode4Gv4CSharp:Gen_Wuc4Gv_CS_vsCondObject)
 /// </summary>
protected clsvDnFunctionEN vsobjvDnFunction_Cond
{
get
{
clsvDnFunctionEN sobjvDnFunction_Cond;
sobjvDnFunction_Cond = (clsvDnFunctionEN)ViewState["objvDnFunction_Cond"];
return sobjvDnFunction_Cond;
}
set
{
clsvDnFunctionEN sobjvDnFunction_Cond = value;
ViewState.Add("objvDnFunction_Cond", sobjvDnFunction_Cond);
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WebCtlControlCode4Gv4CSharp:Gen_Wuc4Gv_CS_CopyToEx)
 /// </summary>
 /// <param name = "objvDnFunctionENS">源对象</param>
 /// <returns>目标对象=>clsvDnFunctionEN:objvDnFunctionENT</returns>
 public clsvDnFunctionENEx CopyToEx(clsvDnFunctionEN objvDnFunctionENS)
{
try
{
 clsvDnFunctionENEx objvDnFunctionENT = new clsvDnFunctionENEx();
clsvDnFunctionBL.CopyTo(objvDnFunctionENS, objvDnFunctionENT);
 return objvDnFunctionENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:WucL000022)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}
}
}