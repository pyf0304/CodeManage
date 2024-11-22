﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:wfmProgLangTypeB_QUDI
 表名:ProgLangType
 生成代码版本:2018.04.29.1
 生成日期:2018/04/29 11:48:03
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:101.251.68.133,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统参数
 模块英文名:SysPara
 框架-层名:Web界面层
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2017.11.28.01
      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */

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
 /// wfmProgLangTypeB_QUDI 的摘要说明。其中Q代表查询,U代表修改
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenQueryUpdDelInsRecControlCodeWithWuc4Gv)
 /// </summary>
public partial class wfmProgLangTypeB_QUDI : System.Web.UI.Page
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
// 在此处放置用户代码以初始化页面
if (!IsPostBack)	///如果本界面是初次被调用,而不是单击按钮事件所调用
{

vsViewName = "编程语言类型维护";
vsTabName = string.Format("{0}", clsvProgLangTypeEN._CurrTabName);
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
wucProgLangTypeB1.SetDdl_CharEncodingId();
clsCharEncodingBL.BindDdl_CharEncodingId(ddlCharEncodingIdq);
wucvProgLangType4Gv1.SetSortBy(string.Format("{0} Asc", convProgLangType.ProgLangTypeId));
//2、显示无条件的表内容在GridView中
BindGv_vProgLangType();
//3、设置表控件中字控件的ReadOnly属性,
// 使之只读,因为在修改功能中关键字是不能被修改的。
wucProgLangTypeB1.SetKeyReadOnly(true);
DispProgLangTypeListRegion();
//设置逻辑层的公共函数，包含：缓存刷新函数
//clsProgLangTypeBL.objCommFun4BL = new clsCommFun4BL4ProgLangType();
}
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
 wucvProgLangType4Gv1.PageIndex = 0;
//把表记录的内容显示在GridView中
BindGv_vProgLangType();
}
 /// <summary>
 /// 函数功能:把查询数据绑定在GridView上。根据界面上查询控件中所设置内容查询表记录,
 ///			 并显示在GridView中。
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenBindGridView4WucInPage)
 /// </summary>
protected void BindGv_vProgLangType()
{
//操作步骤:(共5步)
//	1、组合界面条件串；
//	2、调用控件中的绑定GridView函数;
//	3、设置Gv控件的某些列不可见;

try
{
//	1、组合界面条件串；
string strWhereCond = CombinevProgLangTypeCondition();
//	2、调用控件中的绑定GridView函数；
 wucvProgLangType4Gv1.BindGv_ProgLangType(strWhereCond);
//	3、设置Gv控件的某些列不可见；
//wucvProgLangType4Gv1.SetGvVisibility(constwucvProgLangType4Gv.UpdDate, false);
//wucvProgLangType4Gv1.SetGvVisibility(conProgLangType.UpdUser, false);
}
catch (Exception objException)
{
string strMsg = "(errid:WebI000019)绑定GridView出错!" + objException.Message;
clsCommonJsFunc.Alert(this, strMsg);
return;
}

}

 /// <summary>
 /// 把所有的查询控件内容组合成一个条件串
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenCombineCondition)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
protected string CombinevProgLangTypeCondition()
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
clsvProgLangTypeEN objvProgLangTypeEN = new clsvProgLangTypeEN();
try
{
if (this.txtProgLangTypeIdq.Text.Trim()!= "")
{
objvProgLangTypeEN.ProgLangTypeId = this.txtProgLangTypeIdq.Text.Trim();
strWhereCond += string.Format(" And {0} like '%{1}%'", convProgLangType.ProgLangTypeId, this.txtProgLangTypeIdq.Text.Trim());
}
if (this.txtProgLangTypeNameq.Text.Trim()!= "")
{
objvProgLangTypeEN.ProgLangTypeName = this.txtProgLangTypeNameq.Text.Trim();
strWhereCond += string.Format(" And {0} like '%{1}%'", convProgLangType.ProgLangTypeName, this.txtProgLangTypeNameq.Text.Trim());
}
if (this.ddlCharEncodingIdq.SelectedValue!= "" && this.ddlCharEncodingIdq.SelectedValue!= "0")
{
objvProgLangTypeEN.CharEncodingId = this.ddlCharEncodingIdq.SelectedValue;
strWhereCond += string.Format(" And {0} = '{1}'", convProgLangType.CharEncodingId, this.ddlCharEncodingIdq.SelectedValue);
}
clsvProgLangTypeBL.CheckProperty4Condition(objvProgLangTypeEN);
}
catch(Exception objException)
{
string strMsg = string.Format("(errid:WebI000002)在组合查询条件(CombineProgLangTypeCondition)时出错!请联系管理员!" + objException.Message);
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



#region 添加相关函数

 ///添加新记录的事件过程,建议在该过程中调用其他函数,不要在其中添加多行代码。
protected void btnAddNewRec4Gv_Click(object sender, System.EventArgs e)
{
AddProgLangTypeRecord();
}
 /// <summary>
 /// 为插入记录做准备工作
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenAddRecordCode)
 /// </summary>
protected void AddProgLangTypeRecord()
{
wucProgLangTypeB1.SetKeyReadOnly(false);
btnOKUpd.Text = "确认添加";
btnCancelProgLangTypeEdit.Text = "取消添加";
//wucProgLangTypeB1.ProgLangTypeId = clsProgLangTypeBL.GetMaxStrId_S();
DispEditProgLangTypeRegion();
}
 /// <summary>
 /// 插入记录存盘到数据表中
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenAddRecordSaveCode)
 /// </summary>
 /// <returns>插入记录是否成功？</returns>
protected bool AddProgLangTypeRecordSave()
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
string strMsg;	//专门用于传递信息的变量
string strResult = " ";	//用于传递在检验对象属性时结果值的变量
clsProgLangTypeEN objProgLangTypeEN;
//1、检查控件中输入数据类型是否正确
if (!wucProgLangTypeB1.IsValid(ref strResult))
{
lblMsgEdit.Text = "(errid:WebI000003)控件中输入数据类型不正确请检查!";
return false;
}
//2、定义对象并初始化对象
//clsProgLangTypeEN objProgLangTypeEN;	//定义对象
objProgLangTypeEN = new clsProgLangTypeEN(wucProgLangTypeB1.ProgLangTypeId);	//初始化新对象
//3.1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsProgLangTypeBL.IsExist(objProgLangTypeEN.ProgLangTypeId))	//判断是否有相同的关键字
{
strMsg = "(errid:WebI000004)关键字字段已有相同的值";
clsCommonJsFunc.Alert(this, strMsg);
return false;
}
//4、把值从界面层传到逻辑层或数据实体层
PutDataToProgLangTypeClass(objProgLangTypeEN);		//把界面的值传到
 //5.1、检查传进去的对象属性是否合法
try
{
clsProgLangTypeBL.CheckPropertyNew(objProgLangTypeEN);
//6、把数据实体层的数据存贮到数据库中
clsProgLangTypeBL.AddNewRecordBySql2(objProgLangTypeEN);
}
catch(Exception objException)
{
strMsg = "(errid:WebI000005)添加记录不成功!" + objException.Message;
clsCommonJsFunc.Alert(this, strMsg);
lblMsgEdit.Text = strMsg;
return false;
}
strMsg = "添加记录成功!";
clsCommonJsFunc.Alert(this, strMsg);
lblMsgEdit.Text = "添加记录成功!";
//7、把新添的记录内容显示在GridView中
BindGv_vProgLangType();
DispProgLangTypeListRegion();
wucProgLangTypeB1.Clear();		//清空控件中内容
 ///恢复<确认添加>变成<添加>
btnOKUpd.Text = "添加";
btnCancelProgLangTypeEdit.Text = "取消编辑";
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
//1、显示该关键字的数据让用户修改该关键字记录；
string strProgLangTypeId = wucvProgLangType4Gv1.GetFirstCheckedKeyFromGv();
if (string.IsNullOrEmpty(strProgLangTypeId) == true) return;
UpdateProgLangTypeRecord(strProgLangTypeId);
}

 /// <summary>
 /// 函数功能:把以该关键字的记录内容显示在界面上,
 ///　　　   在这里是把值传到表控件中
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenShowDataCode)
 /// </summary>
 /// <param name = "strProgLangTypeId">表记录的关键字,显示该表关键字的内容</param>
protected void ShowData(string strProgLangTypeId)
{
//操作步骤:
//1、检查关键字是否为空；
//2、检查该关键字的记录是否存在,如果不存在就返回不显示；
//3、用提供的关键字初始化一个类对象；
//4、获取类对象的所有属性；
//5、把该对象的所有属性显示在界面上,在这里显示在表控件中

//1、检查关键字是否为空；
if (strProgLangTypeId == "") return ;		//如果关键字为空就返回退出
//2、检查该关键字的记录是否存在,如果不存在就返回不显示；
if (clsProgLangTypeBL.IsExist(strProgLangTypeId) == false)		//检查该关键字的记录是否存在
{
string strMsg = "(errid:WebI000010)在表[ProgLangType]中,关键字为:[strProgLangTypeId]的记录不存在!";
clsCommonJsFunc.Alert(this, strMsg);
return ;
}
//3、用提供的关键字初始化一个类对象；
clsProgLangTypeEN objProgLangTypeEN = new clsProgLangTypeEN(strProgLangTypeId);
//4、获取类对象的所有属性；
try
{
clsProgLangTypeBL.GetProgLangType(ref objProgLangTypeEN);
}
catch (Exception objException)
{
seErrMessage = objException.Message;
seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
Response.Redirect(clsSysParaEN.ErrorPage);
}
Session.Add("objProgLangTypeEN", objProgLangTypeEN);
//5、把该对象的所有属性显示在界面上,在这里显示在表控件中
GetDataFromProgLangTypeClass(objProgLangTypeEN);
}
 /// <summary>
 /// 函数功能:把类对象的属性内容显示到界面上
 ///注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
 /// 如果在设置数据库时,就应该一级字段在前,二级字段在后
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenGetDataFromClass)
 /// </summary>
 /// <param name = "pobjProgLangTypeEN">表实体类对象</param>
protected void GetDataFromProgLangTypeClass(clsProgLangTypeEN pobjProgLangTypeEN)
{
wucProgLangTypeB1.ProgLangTypeId = pobjProgLangTypeEN.ProgLangTypeId;// 编程语言类型Id
wucProgLangTypeB1.ProgLangTypeName = pobjProgLangTypeEN.ProgLangTypeName;// 编程语言类型名
wucProgLangTypeB1.ProgLangTypeENName = pobjProgLangTypeEN.ProgLangTypeENName;// 编程语言类型英文名
wucProgLangTypeB1.CharEncodingId = pobjProgLangTypeEN.CharEncodingId;// 字符编码
wucProgLangTypeB1.IsVisible = pobjProgLangTypeEN.IsVisible;// 是否显示
wucProgLangTypeB1.OrderNum = pobjProgLangTypeEN.OrderNum;// 序号
wucProgLangTypeB1.UpdDate = pobjProgLangTypeEN.UpdDate;// 修改日期
wucProgLangTypeB1.UpdUserId = pobjProgLangTypeEN.UpdUserId;// 修改用户Id
wucProgLangTypeB1.Memo = pobjProgLangTypeEN.Memo;// 说明
}
 ///
/// <summary>
/// 事件函数:在Gv列表控件中，当GeidView行单击修改时发生的事件。
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_Wuc4Gv_GvUpdateClick)
/// </summary>
/// <param name = "sender"></param>
/// <param name = "e"></param>
protected void wucvProgLangType4Gv1_GvUpdateClick(object sender, clsEventArgs4Update e)
{
string strProgLangTypeId = e.KeyId;
  UpdateProgLangTypeRecord(strProgLangTypeId);
}
 /// <summary>
 /// 为修改记录做准备过程,把给定关键字的记录字段值显示在用户控件上
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenUpdateRecordCode)
 /// </summary>
protected void UpdateProgLangTypeRecord(string strProgLangTypeId)
{
//操作步骤:(总共2步)
//1、显示该关键字记录的内容在界面上；
//2、清空提示信息的内容,同时使<确定修改>按钮可用；

//1、显示该关键字记录的内容在界面上；
ShowData(strProgLangTypeId);
//2、清空提示信息的内容,同时使<确定修改>按钮可用；
btnOKUpd.Enabled = true;
wucProgLangTypeB1.SetKeyReadOnly(true);
btnOKUpd.Text = "确认修改";
btnCancelProgLangTypeEdit.Text = "取消修改";
lblMsgEdit.Text = "";
DispEditProgLangTypeRegion();
}
 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenUpdateRecordSaveCode)
 /// </summary>
 /// <param name = "objProgLangTypeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
protected bool UpdateProgLangTypeRecordSave(clsProgLangTypeEN objProgLangTypeEN)
{
//操作步骤:
//1、检查控件中输入数据类型是否正确
//2、把值从界面层传到逻辑层或数据实体层
//3.1、检查传进去的对象属性是否合法
//3.2、检查唯一性
//4、把数据实体层的数据存贮到数据库中
//5、把修改后的内容显示在GridView中
string strMsg;	//专门用于传递信息的变量
string strResult = " ";	//用于传递在检验对象属性时结果值的变量
//1、检查控件中输入数据类型是否正确
if (!wucProgLangTypeB1.IsValid(ref strResult))
{
lblMsgEdit.Text = "(errid:WebI000011)控件中输入数据类型不正确请检查!";
return false;
}
//2、把值从界面层传到逻辑层或数据实体层
PutDataToProgLangTypeClass(objProgLangTypeEN);		//把界面的值传到
//3.1、检查传进去的对象属性是否合法
try
{
clsProgLangTypeBL.CheckPropertyNew(objProgLangTypeEN);
//4、把数据实体层的数据存贮到数据库中
clsProgLangTypeBL.UpdateBySql2(objProgLangTypeEN);
}
catch(Exception objException)
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
BindGv_vProgLangType();
DispProgLangTypeListRegion();
wucProgLangTypeB1.Clear();//添空控件中的内容
//恢复<确认修改>变成<添加>
btnOKUpd.Text = "添加";
btnCancelProgLangTypeEdit.Text = "取消编辑";
//跳转到列表中刚刚的记录处,使用锚点功能。
this.ClientScript.RegisterStartupScript(this.GetType(), "Go-Anchor", string.Format("this.location.href = '#A_ProgLangType{0}'", objProgLangTypeEN.ProgLangTypeId.ToString().Trim()), true);
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
clsProgLangTypeEN objProgLangTypeEN;
Button btnTemp;
btnTemp = (Button) sender;
strCommandText = btnTemp.Text;
switch(strCommandText)
{
case "添加":
AddProgLangTypeRecord();
break;				
case "确认添加":
//这是一个单表的插入的代码,由于逻辑层太简单,
//就把逻辑层合并到控制层,
AddProgLangTypeRecordSave();
break;
case "确认修改":
//这是一个单表的修改的代码,由于逻辑层太简单,
//就把逻辑层合并到控制层,
objProgLangTypeEN = (clsProgLangTypeEN) Session["objProgLangTypeEN"];
UpdateProgLangTypeRecordSave(objProgLangTypeEN);
break;
}
}
/// <summary>
/// 事件函数:取消编辑状态，退回到列表状态
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_btnCancelEdit_Click)
/// </summary>
/// <param name = "sender"></param>
/// <param name = "e"></param>
protected void btnCancelProgLangTypeEdit_Click(object sender, EventArgs e)
{
DispProgLangTypeListRegion();
}
 /// <summary>
 /// 函数功能:把界面上的属性数据传到类对象中
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPutDataToClass)
 /// </summary>
 /// <param name = "pobjProgLangTypeEN">数据传输的目的类对象</param>
protected void PutDataToProgLangTypeClass(clsProgLangTypeEN pobjProgLangTypeEN)
{
pobjProgLangTypeEN.ProgLangTypeId = wucProgLangTypeB1.ProgLangTypeId;// 编程语言类型Id
pobjProgLangTypeEN.ProgLangTypeName = wucProgLangTypeB1.ProgLangTypeName;// 编程语言类型名
pobjProgLangTypeEN.ProgLangTypeENName = wucProgLangTypeB1.ProgLangTypeENName;// 编程语言类型英文名
pobjProgLangTypeEN.CharEncodingId = wucProgLangTypeB1.CharEncodingId;// 字符编码
pobjProgLangTypeEN.IsVisible = wucProgLangTypeB1.IsVisible;// 是否显示
pobjProgLangTypeEN.OrderNum = wucProgLangTypeB1.OrderNum;// 序号
pobjProgLangTypeEN.UpdDate = wucProgLangTypeB1.UpdDate;// 修改日期
pobjProgLangTypeEN.UpdUserId = wucProgLangTypeB1.UpdUserId;// 修改用户Id
pobjProgLangTypeEN.Memo = wucProgLangTypeB1.Memo;// 说明
}

#endregion 添加修改共用函数


#region 删除相关函数

 /// <summary>
 ///删除当前被选记录
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenbtnDelete4Gv_Click4OneKeyword)
 /// </summary>
protected void btnDelete4Gv_Click(object sender, System.EventArgs e)
{
List<string> lstProgLangTypeId = wucvProgLangType4Gv1.GetAllCheckedKeysFromGv();
if (lstProgLangTypeId == null) return;
lblMsgList.Text = "";
try
{
foreach (string strProgLangTypeId in lstProgLangTypeId)
{
clsProgLangTypeBL.DelRecord(strProgLangTypeId);
}
}
catch (Exception objException)
{
seErrMessage = objException.Message;
seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
Response.Redirect(clsSysParaEN.ErrorPage);
}
BindGv_vProgLangType();
}
 ///
/// <summary>
/// 事件函数:在Gv列表控件中，当GeidView行单击删除时发生的事件。
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_Wuc4Gv_GvDeleteClick)
/// </summary>
/// <param name = "sender"></param>
/// <param name = "e"></param>
protected void wucvProgLangType4Gv1_GvDeleteClick(object sender, clsEventArgs4Delete e)
{
string strProgLangTypeId = e.KeyId;
  DeleteProgLangTypeRecord(strProgLangTypeId);
}
 /// <summary>
 /// 根据给定关键字删除记录
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDelRecordCode)
 /// </summary>
 /// <param name = "strProgLangTypeId">给定关键字</param>
protected void DeleteProgLangTypeRecord(string strProgLangTypeId)
{
try
{
clsProgLangTypeBL.DelRecord(strProgLangTypeId);
}
catch (Exception objException)
{
seErrMessage = objException.Message;
seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
Response.Redirect(clsSysParaEN.ErrorPage);
}
BindGv_vProgLangType();
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
 /// 导出Excel。根据查询区组合的查询条件,从[vProgLangType]表中获取记录集,最终导出到Excel
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenExportExcel)
 /// </summary>
private void ExportExcel()
{
//	1、组合界面条件串；
string strWhereCond = CombinevProgLangTypeCondition();
//	2、根据条件串获取该表满足条件的DataTable；
System.Data.DataTable objDT = null;
List<string> arrCnName = new List<string>();
List<string> arrColName = new List<string>();
string strFileName = "ProgLangType信息导出.xls";
string strFolderName;
string strDownLoadFileName;
arrColName.Add(convProgLangType.ProgLangTypeId); arrCnName.Add("编程语言类型Id");
arrColName.Add(convProgLangType.ProgLangTypeName); arrCnName.Add("编程语言类型名");
arrColName.Add(convProgLangType.ProgLangTypeENName); arrCnName.Add("编程语言类型英文名");
arrColName.Add(convProgLangType.CharEncodingId); arrCnName.Add("字符编码");
arrColName.Add(convProgLangType.CharEncodingName); arrCnName.Add("字符编码名称");
arrColName.Add(convProgLangType.IsVisible); arrCnName.Add("是否显示");
arrColName.Add(convProgLangType.OrderNum); arrCnName.Add("序号");
arrColName.Add(convProgLangType.UpdDate); arrCnName.Add("修改日期");
arrColName.Add(convProgLangType.UpdUserId); arrCnName.Add("修改用户Id");
arrColName.Add(convProgLangType.Memo); arrCnName.Add("说明");
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
objDT = clsvProgLangTypeBL.GetDataTable(strWhereCond);
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
private void DispEditProgLangTypeRegion()
{
divList.Visible = false;
tabEditProgLangTypeRegion.Visible = true;
}
 /// <summary>
 /// 布局控制函数,显示数据列表区,并隐藏用于编辑的用户控件
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDispListAndEditRegion)
 /// </summary>
private void DispProgLangTypeListRegion()
{
divList.Visible = true;
tabEditProgLangTypeRegion.Visible = false;
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
string strUserId = Request.QueryString[ "UserId"] ?? "".ToString();
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
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPotenceRelaVar)
/// </summary>
protected const string ViewId4Potence = "00260203";		//界面编号


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

}
}