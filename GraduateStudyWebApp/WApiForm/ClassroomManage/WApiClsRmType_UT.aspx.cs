﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:WApiClsRmType_UT
 表名:ClsRmType(01120576)
 生成代码版本:2021.04.13.1
 生成日期:2021/04/14 11:08:54
 生成者:yy
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:教室管理
 模块英文名:ClassroomManage
 框架-层名:WA_界面UT后台(WA_ViewUTScriptCS)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
 ///生成查询删除记录的控制层代码

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
using System.Linq;
using Newtonsoft.Json;
using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.datetime;
using CommFunc4WebForm;
using ExamLib.Const;
using ExamLib.Entity;
using ExamLib.BusinessLogicEx;
using ExamLib;
using ExamLib4WApi;
namespace ExamLib.WApiForm
{
 /// <summary>
 /// WApiClsRmType_UT 的摘要说明。其中Q代表查询,U代表修改
 /// (AutoGCLib.WA_ViewUTScriptCS4CSharp:GeneCode)
 /// </summary>
public partial class WApiClsRmType_UT : System.Web.UI.Page
{

#region 页面启动函数
 /// <summary>
 /// 函数功能:页面导入,当页面开始运行时所发生的事件
 /// (AutoGCLib.WA_ViewUTScriptCS4CSharp:GenPage_LoadCode)
 /// </summary>
 /// <param name = "sender"></param>
 /// <param name = "e"></param>
protected void Page_Load(object sender, System.EventArgs e)
{
// 在此处放置用户代码以初始化页面
if (!IsPostBack)	///如果本界面是初次被调用,而不是单击按钮事件所调用
{
//设置逻辑层的公共函数，包含：缓存刷新函数
if (string.IsNullOrEmpty(hidDivName.Value) == true)
{
hidDivName.Value = "divIsExistRecord";
}
}
}

#endregion 页面启动函数

 /// <summary>
 /// 检查相应关键字的记录是否存在
 /// (AutoGCLib.WA_ViewUTScriptCS4CSharp:Gen_WApi_Cs_btnClickIsExistRecord)
 /// </summary>
 /// <param name = "sender">发送者</param>
 /// <returns>返回是否存在</returns>
protected void btnIsExistRecord_Click(object sender, EventArgs e) {
hidDivName.Value = "divIsExistRecord";
string strWhereCond = txtstrWhereCond1.Text.Trim();
try
{
bool returnBool = clsClsRmTypeWApi.IsExistRecord(strWhereCond);
if (returnBool == false)
{
strWhereCond = txtstrWhereCond1.Text.Trim();
string strInfo = string.Format("根据条件:[{0}] 不存在!", strWhereCond);
lblResult1.Text = strInfo;
//显示信息框
clsCommonJsFunc.Alert(this, strInfo);
}
else
{
strWhereCond = txtstrWhereCond1.Text.Trim();
string strInfo = string.Format("根据条件:[{0}] 存在!", strWhereCond);
lblResult1.Text = strInfo;
//显示信息框
clsCommonJsFunc.Alert(this, strInfo);
}
}
catch(Exception objException)
{
string strMsg = string.Format("检查相应关键字的记录是否存在不成功, {0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
clsCommonJsFunc.Alert(this, strMsg);
}
}

 /// <summary>
 /// 获取某一条件的记录数
 /// (AutoGCLib.WA_ViewUTScriptCS4CSharp:Gen_WApi_Cs_btnClickGetRecCountByCond)
 /// </summary>
 /// <param name = "sender">发送者</param>
 /// <returns>返回是否存在</returns>
protected void btnGetRecCountByCond_Click(object sender, EventArgs e) {
hidDivName.Value = "divGetRecCountByCond";
string strWhereCond = txtstrWhereCond2.Text.Trim();
try
{
int returnInt = clsClsRmTypeWApi.GetRecCountByCond(strWhereCond);
strWhereCond = txtstrWhereCond2.Text.Trim();
string strInfo = string.Format("根据条件:{0}的记录数:{1}!", strWhereCond, returnInt);
lblResult2.Text = strInfo;
//显示信息框
clsCommonJsFunc.Alert(this, strInfo);
}
catch(Exception objException)
{
string strMsg = string.Format("获取某一条件的记录数不成功,{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
clsCommonJsFunc.Alert(this, strMsg);
}
}

 /// <summary>
 /// 获取某一条件的字段值列表
 /// (AutoGCLib.WA_ViewUTScriptCS4CSharp:Gen_WApi_Cs_btnClickGetFldValue)
 /// </summary>
 /// <param name = "sender">发送者</param>
 /// <returns>返回是否存在</returns>
protected void btnGetFldValue_Click(object sender, EventArgs e) {
hidDivName.Value = "divGetFldValue";
string strWhereCond = txtstrWhereCond3.Text.Trim();
string strFldName = txtstrFldName3.Text.Trim();
string strTabName = txtstrTabName3.Text.Trim();
try
{
List<string> arrFldValueLst = clsClsRmTypeWApi.GetFldValue(strFldName, strWhereCond);
strWhereCond = txtstrWhereCond3.Text.Trim();
strFldName = txtstrFldName3.Text.Trim();
string strInfo = string.Format("根据条件:{0}的字段:[{1}]值列表:{2}!", strWhereCond, strFldName, string.Join(",", arrFldValueLst));
lblResult3.Text = strInfo;
//显示信息框
clsCommonJsFunc.Alert(this, strInfo);
}
catch(Exception objException)
{
string strMsg = string.Format("获取某一条件的记录数不成功,{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
clsCommonJsFunc.Alert(this, strMsg);
}
}

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.WA_ViewUTScriptCS4CSharp:Gen_WApi_Cs_btnClickAddNewRecord)
 /// </summary>
 /// <returns></returns>
protected void btnAddNewRecord_Click(object sender, EventArgs e) {
hidDivName.Value = "divAddNewRecord";
clsClsRmTypeEN objClsRmTypeEN = new clsClsRmTypeEN();
objClsRmTypeEN.id_ClassRoomType = "1111";
objClsRmTypeEN.ClassRoomTypeID = "1111";
objClsRmTypeEN.ClassRoomTypeDesc = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objClsRmTypeEN.ClassRoomTypeDescA = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objClsRmTypeEN.ModifyUserID = "111111111111111111";
objClsRmTypeEN.ModifyDate = "11111111111111111111";
objClsRmTypeEN.Memo = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
try
{
bool bolIsExist = clsClsRmTypeWApi.IsExist(objClsRmTypeEN.id_ClassRoomType);
if (bolIsExist == true)
{
string strMsg = string.Format("添加记录时，关键字：{0}已经存在！", objClsRmTypeEN.id_ClassRoomType);
clsCommonJsFunc.Alert(this, strMsg);
return;
}
bool returnBool = clsClsRmTypeWApi.AddNewRecord(objClsRmTypeEN);
if (returnBool == true)
{
string strInfo = string.Format("添加记录成功!");
lblResult4.Text = strInfo;
//显示信息框
clsCommonJsFunc.Alert(this, strInfo);
}
else
{
string strInfo = string.Format("添加记录不成功!");
lblResult4.Text = strInfo;
//显示信息框
clsCommonJsFunc.Alert(this, strInfo);
}
}
catch(Exception objException)
{
string strMsg = string.Format("添加记录不成功,{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
clsCommonJsFunc.Alert(this, strMsg);
}
}

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.WA_ViewUTScriptCS4CSharp:Gen_WApi_Cs_btnClickAddNewRecord4GetMaxStrId)
 /// </summary>
 /// <returns></returns>
protected void btnAddNewRecord4GetMaxStrId_Click(object sender, EventArgs e) {
hidDivName.Value = "divAddNewRecord4GetMaxStrId";
string returnString = clsClsRmTypeWApi.GetMaxStrId();
clsClsRmTypeEN objClsRmTypeEN = new clsClsRmTypeEN();
objClsRmTypeEN.id_ClassRoomType = returnString;
objClsRmTypeEN.ClassRoomTypeID = "1111";
objClsRmTypeEN.ClassRoomTypeDesc = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objClsRmTypeEN.ClassRoomTypeDescA = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objClsRmTypeEN.ModifyUserID = "111111111111111111";
objClsRmTypeEN.ModifyDate = "11111111111111111111";
objClsRmTypeEN.Memo = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
try
{
bool returnBool = clsClsRmTypeWApi.AddNewRecord(objClsRmTypeEN);
if (returnBool == true)
{
string strInfo = string.Format("添加记录成功!");
lblResult5.Text = strInfo;
//显示信息框
clsCommonJsFunc.Alert(this, strInfo);
}
else
{
string strInfo = string.Format("添加记录不成功!");
lblResult5.Text = strInfo;
//显示信息框
clsCommonJsFunc.Alert(this, strInfo);
}
}
catch(Exception objException)
{
string strMsg = string.Format("添加记录不成功, {0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
clsCommonJsFunc.Alert(this, strMsg);
}
}

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_ViewUTScriptCS4CSharp:Gen_WApi_Cs_btnClickGetMaxStrId)
 /// </summary>
 /// <returns></returns>
protected void btnGetMaxStrId_Click(object sender, EventArgs e) {
hidDivName.Value = "divGetMaxStrId";
try
{
string returnString = clsClsRmTypeWApi.GetMaxStrId();
if (returnString == "")
{
string strInfo = string.Format("获取表ClsRmType的最大关键字为空，不成功，请检查!");
lblResult6.Text = strInfo;
//显示信息框
clsCommonJsFunc.Alert(this, strInfo);
}
else
{
string strInfo = string.Format("获取表ClsRmType的最大关键字为：{0}!", returnString);
lblResult6.Text = strInfo;
//显示信息框
clsCommonJsFunc.Alert(this, strInfo);
}
}
catch(Exception objException)
{
string strMsg = string.Format("获取表关键字的最大值不成功,{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
clsCommonJsFunc.Alert(this, strMsg);
}
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_ViewUTScriptCS4CSharp:Gen_WApi_Cs_btnClickGetMaxStrIdByPrefix)
 /// </summary>
 /// <returns></returns>
protected void btnGetMaxStrIdByPrefix_Click(object sender, EventArgs e) {
hidDivName.Value = "divGetMaxStrIdByPrefix";
string strPrefix = txtstrPrefix7.Text.Trim();
try
{
string returnString = clsClsRmTypeWApi.GetMaxStrIdByPrefix(strPrefix);
if (returnString == "")
{
string strInfo = string.Format("获取表ClsRmType的最大关键字为空，不成功，请检查!");
lblResult7.Text = strInfo;
//显示信息框
clsCommonJsFunc.Alert(this, strInfo);
}
else
{
string strInfo = string.Format("获取表ClsRmType的最大关键字为：{0}!", returnString);
lblResult7.Text = strInfo;
//显示信息框
clsCommonJsFunc.Alert(this, strInfo);
}
}
catch(Exception objException)
{
string strMsg = string.Format("获取表关键字的最大值不成功,{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
clsCommonJsFunc.Alert(this, strMsg);
}
}

 /// <summary>
 /// 修改记录
 /// (AutoGCLib.WA_ViewUTScriptCS4CSharp:Gen_WApi_Cs_btnClickUpdateRecord)
 /// </summary>
 /// <returns></returns>
protected void btnUpdateRecord_Click(object sender, EventArgs e) {
hidDivName.Value = "divUpdateRecord";
clsClsRmTypeEN objClsRmTypeEN = new clsClsRmTypeEN();
objClsRmTypeEN.id_ClassRoomType = "1111";
objClsRmTypeEN.ClassRoomTypeID = "1111";
objClsRmTypeEN.ClassRoomTypeDesc = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objClsRmTypeEN.ClassRoomTypeDescA = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objClsRmTypeEN.ModifyUserID = "111111111111111111";
objClsRmTypeEN.ModifyDate = "11111111111111111111";
objClsRmTypeEN.Memo = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
try
{
objClsRmTypeEN.sf_UpdFldSetStr = objClsRmTypeEN.getsf_UpdFldSetStr();//设置哪些字段被修改(脏字段)
bool returnBool = clsClsRmTypeWApi.UpdateRecord(objClsRmTypeEN);
if (returnBool == true)
{
string strInfo = string.Format("修改记录成功!");
lblResult8.Text = strInfo;
//显示信息框
clsCommonJsFunc.Alert(this, strInfo);
}
else
{
string strInfo = string.Format("修改记录不成功!");
lblResult8.Text = strInfo;
//显示信息框
clsCommonJsFunc.Alert(this, strInfo);
}
}
catch(Exception objException)
{
string strMsg = string.Format("修改记录不成功,{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
clsCommonJsFunc.Alert(this, strMsg);
}
}

 /// <summary>
 /// 删除记录
 /// (AutoGCLib.WA_ViewUTScriptCS4CSharp:Gen_WApi_Cs_btnClickDelRecord)
 /// </summary>
 /// <param name = "sender">事件发送者</param>
 /// <returns></returns>
protected void btnDelRecord_Click(object sender, EventArgs e) {
hidDivName.Value = "divDelRecord";
string strKeyId = txtstrKeyId9.Text.Trim();
String strid_ClassRoomType = strKeyId;
try
{
int returnInt = clsClsRmTypeWApi.DelRecord(strid_ClassRoomType);
if (returnInt > 0)
{
string strInfo = string.Format("删除记录成功, 共删除了{0}条记录!", returnInt);
lblResult9.Text = strInfo;
//显示信息框
clsCommonJsFunc.Alert(this, strInfo);
}
else
{
string strInfo = string.Format("删除记录不成功!");
lblResult9.Text = strInfo;
//显示信息框
clsCommonJsFunc.Alert(this, strInfo);
}
}
catch(Exception objException)
{
string strMsg = string.Format("删除记录不成功, {0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
clsCommonJsFunc.Alert(this, strMsg);
}
}

 /// <summary>
 /// 删除记录
 /// (AutoGCLib.WA_ViewUTScriptCS4CSharp:Gen_WApi_Cs_btnClickDelRecords)
 /// </summary>
 /// <param name = "sender">事件发送者</param>
 /// <returns></returns>
protected void btnDelRecords_Click(object sender, EventArgs e) {
hidDivName.Value = "divDelRecords";
string strKeyIdLst = txtstrKeyIdLst10.Text.Trim();
try
{
int returnInt = clsClsRmTypeWApi.DelRecords(strKeyIdLst);
if (returnInt > 0)
{
string strInfo = string.Format("删除记录成功,共删除{0}条记录!", returnInt);
lblResult10.Text = strInfo;
//显示信息框
clsCommonJsFunc.Alert(this, strInfo);
}
else
{
string strInfo = string.Format("删除记录不成功!");
lblResult10.Text = strInfo;
//显示信息框
clsCommonJsFunc.Alert(this, strInfo);
}
}
catch(Exception objException)
{
string strMsg = string.Format("删除记录不成功, {0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
clsCommonJsFunc.Alert(this, strMsg);
}
}

 /// <summary>
 /// 根据条件获取相应的第一条记录的对象
 /// (AutoGCLib.WA_ViewUTScriptCS4CSharp:Gen_WApi_Cs_btnClickGetFirstObj)
 /// </summary>
 /// <param name = "sender">事件发送者</param>
 /// <returns></returns>
protected void btnGetFirstObj_Click(object sender, EventArgs e) {
hidDivName.Value = "divGetFirstObj";
string strWhereCond = txtstrWhereCond11.Text.Trim();
try
{
clsClsRmTypeEN objClsRmTypeEN = clsClsRmTypeWApi.GetFirstObj(strWhereCond);
strWhereCond = txtstrWhereCond11.Text.Trim();
string strInfo = string.Format("根据条件:[{0}] 获取第一个记录对象：{1}!", strWhereCond, objClsRmTypeEN.id_ClassRoomType);
lblResult11.Text = strInfo;
//显示信息框
clsCommonJsFunc.Alert(this, strInfo);
}
catch(Exception objException)
{
string strMsg = string.Format("根据条件获取相应的第一条记录的对象不成功,{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
clsCommonJsFunc.Alert(this, strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相应的记录的对象
 /// (AutoGCLib.WA_ViewUTScriptCS4CSharp:Gen_WApi_Cs_btnClickGetObjByKey)
 /// </summary>
 /// <param name = "sender">参数列表</param>
 /// <returns></returns>
protected void btnGetObjByid_ClassRoomType_Click(object sender, EventArgs e) 
{
hidDivName.Value = "divGetObjByid_ClassRoomType";
string strKeyId = txtvarKeyId12.Text.Trim();
String strid_ClassRoomType = strKeyId;
try
{
clsClsRmTypeEN objClsRmTypeEN = clsClsRmTypeWApi.GetObjByid_ClassRoomType(strid_ClassRoomType);
string strInfo = string.Format("根据关键字:[{0}]获取对象：{1}!", strKeyId, objClsRmTypeEN.id_ClassRoomType);
lblResult12.Text = strInfo;
//显示信息框
clsCommonJsFunc.Alert(this, strInfo);
}
catch(Exception objException)
{
string strMsg = string.Format("根据关键字获取相应的记录的对象不成功,{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
clsCommonJsFunc.Alert(this, strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相应的记录的对象
 /// (AutoGCLib.WA_ViewUTScriptCS4CSharp:Gen_WApi_Cs_btnClickGetObjByKey_WA_Cache)
 /// </summary>
 /// <param name = "sender">参数列表</param>
 /// <returns></returns>
protected void btnGetObjByid_ClassRoomType_WA_Cache_Click(object sender, EventArgs e) 
{
hidDivName.Value = "divGetObjByid_ClassRoomType_WA_Cache";
string strKeyId = txtvarKeyId13.Text.Trim();
String strid_ClassRoomType = strKeyId;
try
{
clsClsRmTypeEN objClsRmTypeEN = clsClsRmTypeWApi.GetObjByid_ClassRoomType_WA_Cache(strid_ClassRoomType);
string strInfo = string.Format("根据关键字:[{0}]获取对象(使用缓存)：{1}!", strKeyId, objClsRmTypeEN.id_ClassRoomType);
lblResult13.Text = strInfo;
//显示信息框
clsCommonJsFunc.Alert(this, strInfo);
}
catch(Exception objException)
{
string strMsg = string.Format("根据关键字获取相应的记录的对象不成功(使用缓存),{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
clsCommonJsFunc.Alert(this, strMsg);
}
}

 /// <summary>
 /// 根据条件获取相应的对象列表
 /// (AutoGCLib.WA_ViewUTScriptCS4CSharp:Gen_WApi_Cs_btnClickGetObjLst)
 /// </summary>
 /// <param name = "sender">事件发送者</param>
 /// <returns></returns>
protected void btnGetObjLst_Click(object sender, EventArgs e) 
{
hidDivName.Value = "divGetObjLst";
string strWhereCond = txtstrWhereCond14.Text.Trim();
try
{
List<clsClsRmTypeEN> arrClsRmTypeObjLst = clsClsRmTypeWApi.GetObjLst(strWhereCond);
string strInfo = string.Format("根据条件:[{0}]共获取对象列表数：{1}!", strWhereCond, arrClsRmTypeObjLst.Count);
lblResult14.Text = strInfo;
//显示信息框
clsCommonJsFunc.Alert(this, strInfo);
}
catch(Exception objException)
{
string strMsg = string.Format("根据条件获取相应的对象列表不成功,{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
clsCommonJsFunc.Alert(this, strMsg);
}
}

 /// <summary>
 /// 根据条件获取相应的对象列表
 /// (AutoGCLib.WA_ViewUTScriptCS4CSharp:Gen_WApi_Cs_btnClickGetObjLstByKeyLst)
 /// </summary>
 /// <param name = "sender">事件发送者</param>
 /// <returns></returns>
protected void btnGetObjLstByKeyLst_Click(object sender, EventArgs e) 
{
hidDivName.Value = "divGetObjLstByKeyLst";
List<string> arrKeyId = txtarrKeyId15.Text.Trim().Split(",".ToCharArray()).ToList();
try
{
List<clsClsRmTypeEN> arrClsRmTypeObjLst = clsClsRmTypeWApi.GetObjLstById_ClassRoomTypeLst(arrKeyId);
string strInfo = string.Format("根据关键字列表:[{0}]共获取对象列表数：{1}!", string.Join(",",arrKeyId), arrClsRmTypeObjLst.Count);
lblResult15.Text = strInfo;
//显示信息框
clsCommonJsFunc.Alert(this, strInfo);
}
catch(Exception objException)
{
string strMsg = string.Format("根据关键字列表获取相应的对象列表不成功,{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
clsCommonJsFunc.Alert(this, strMsg);
}
}

 /// <summary>
 /// 根据条件获取相应的对象列表,使用缓存
 /// (AutoGCLib.WA_ViewUTScriptCS4CSharp:Gen_WApi_Cs_btnClickGetObjLstByKeyLst_Cache)
 /// </summary>
 /// <param name = "sender">事件发送者</param>
 /// <returns></returns>
protected void btnGetObjLstByKeyLst_Cache_Click(object sender, EventArgs e) 
{
hidDivName.Value = "divGetObjLstByKeyLst_Cache";
List<string> arrKeyId = txtarrKeyId16.Text.Trim().Split(",".ToCharArray()).ToList();
try
{
IEnumerable<clsClsRmTypeEN> arrClsRmTypeObjLst = clsClsRmTypeWApi.GetObjLstByid_ClassRoomTypeLst_Cache(arrKeyId);
string strInfo = string.Format("根据关键字列表:[{0}]共获取对象列表数(使用缓存)：{1}!", string.Join(",",arrKeyId), arrClsRmTypeObjLst.Count());
lblResult16.Text = strInfo;
//显示信息框
clsCommonJsFunc.Alert(this, strInfo);
}
catch(Exception objException)
{
string strMsg = string.Format("根据关键字列表获取相应的对象列表不成功,{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
clsCommonJsFunc.Alert(this, strMsg);
}
}

 /// <summary>
 /// 根据条件获取相应的对象列表,使用缓存
 /// (AutoGCLib.WA_ViewUTScriptCS4CSharp:Gen_WApi_Cs_btnClickGetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "sender">事件发送者</param>
 /// <returns></returns>
protected void btnGetObjLstByKeyLst_WA_Cache_Click(object sender, EventArgs e) 
{
hidDivName.Value = "divGetObjLstByKeyLst_WA_Cache";
List<string> arrKeyId = txtarrKeyId17.Text.Trim().Split(",".ToCharArray()).ToList();
try
{
IEnumerable<clsClsRmTypeEN> arrClsRmTypeObjLst = clsClsRmTypeWApi.GetObjLstByid_ClassRoomTypeLst_WA_Cache(arrKeyId);
string strInfo = string.Format("根据关键字列表:[{0}]共获取对象列表数(使用缓存)：{1}!", string.Join(",",arrKeyId), arrClsRmTypeObjLst.Count());
lblResult17.Text = strInfo;
//显示信息框
clsCommonJsFunc.Alert(this, strInfo);
}
catch(Exception objException)
{
string strMsg = string.Format("根据关键字列表获取相应的对象列表不成功,{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
clsCommonJsFunc.Alert(this, strMsg);
}
}

 /// <summary>
 /// 根据条件获取相应的顶部对象列表
 /// (AutoGCLib.WA_ViewUTScriptCS4CSharp:Gen_WApi_Cs_btnClickGetTopObjLst)
 /// </summary>
 /// <param name = "sender">事件发送者</param>
 /// <returns></returns>
protected void btnGetTopObjLst_Click(object sender, EventArgs e) 
{
hidDivName.Value = "divGetTopObjLst";
int intTopSize = int.Parse(txtintTopSize18.Text.ToString());
string strOrderBy = txtstrOrderBy18.Text.Trim();
string strWhereCond = txtstrWhereCond18.Text.Trim();
        stuTopPara objTopPara = new stuTopPara()
{
WhereCond = strWhereCond,
OrderBy = strOrderBy,
TopSize = intTopSize,
IsCheckSQLAttack = "false",
Exclude = ""
};
try
{
List<clsClsRmTypeEN> arrClsRmTypeObjLst =clsClsRmTypeWApi.GetTopObjLst(objTopPara);
string strInfo = string.Format("根据条件:[{0}],顶部数:[{1}]共获取顶部对象列表数：{2}!", strWhereCond, intTopSize, arrClsRmTypeObjLst.Count);
lblResult18.Text = strInfo;
//显示信息框
clsCommonJsFunc.Alert(this, strInfo);
}
catch(Exception objException)
{
string strMsg = string.Format("根据条件获取相应的顶部对象列表不成功, {0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
clsCommonJsFunc.Alert(this, strMsg);
}
}

 /// <summary>
 /// 根据条件获取相应的分页对象列表
 /// (AutoGCLib.WA_ViewUTScriptCS4CSharp:Gen_WApi_Cs_btnClickGetObjLstByPager)
 /// </summary>
 /// <param name = "sender">事件发送者</param>
 /// <returns></returns>
protected void btnGetObjLstByPager_Click(object sender, EventArgs e) 
{
hidDivName.Value = "divGetObjLstByPager";
int intPageIndex = int.Parse(txtintPageIndex19.Text.ToString());
int intPageSize = int.Parse(txtintPageSize19.Text.ToString());
string strOrderBy = txtstrOrderBy19.Text.Trim();
string strWhereCond = txtstrWhereCond19.Text.Trim();
        stuPagerPara objPagerPara = new stuPagerPara()
{
WhereCond = strWhereCond,
OrderBy = strOrderBy,
PageIndex = intPageIndex,
PageSize = intPageSize
};
try
{
List<clsClsRmTypeEN> arrClsRmTypeObjLst = clsClsRmTypeWApi.GetObjLstByPager(objPagerPara);
string strInfo = string.Format("根据条件:[{0}],每页记录数:[{1}],第[{2}]页,共获取分页对象列表数：{3}!", strWhereCond, intPageSize, intPageIndex, arrClsRmTypeObjLst.Count);
lblResult19.Text = strInfo;
//显示信息框
clsCommonJsFunc.Alert(this, strInfo);
}
catch(Exception objException)
{
string strMsg = string.Format("根据条件获取相应的分页对象列表不成功, {0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
clsCommonJsFunc.Alert(this, strMsg);
}
}

 /// <summary>
 /// 根据条件获取相应的分页对象列表
 /// (AutoGCLib.WA_ViewUTScriptCS4CSharp:Gen_WApi_Cs_btnClickGetObjLstByPager_Cache)
 /// </summary>
 /// <param name = "sender">事件发送者</param>
 /// <returns></returns>
protected void btnGetObjLstByPager_Cache_Click(object sender, EventArgs e) 
{
hidDivName.Value = "divGetObjLstByPager_Cache";
int intPageIndex = int.Parse(txtintPageIndex20.Text.ToString());
int intPageSize = int.Parse(txtintPageSize20.Text.ToString());
string strOrderBy = txtstrOrderBy20.Text.Trim();
string strWhereCond = txtstrWhereCond20.Text.Trim();
if (string.IsNullOrEmpty(strOrderBy) == true) strOrderBy = string.Format("{0} Asc", conClsRmType.id_ClassRoomType);
clsClsRmTypeEN objClsRmType_Cond = new clsClsRmTypeEN();
//objClsRmType_Cond.Setid_ClassRoomType("101", "=");
//.SetUserStateId("01", "=");
objClsRmType_Cond.sf_UpdFldSetStr = objClsRmType_Cond.getsf_UpdFldSetStr();
string strFldComparisonOp = JsonConvert.SerializeObject(objClsRmType_Cond.dicFldComparisonOp);
objClsRmType_Cond.sf_FldComparisonOp = strFldComparisonOp;
strWhereCond = JsonConvert.SerializeObject(objClsRmType_Cond);
        stuPagerPara objPagerPara = new stuPagerPara()
{
WhereCond = strWhereCond,
OrderBy = strOrderBy,
PageIndex = intPageIndex,
PageSize = intPageSize
};
try
{
List<clsClsRmTypeEN> arrClsRmTypeObjLst = clsClsRmTypeWApi.GetObjLstByPager_Cache(objPagerPara);
string strInfo = string.Format("根据条件:[{0}],每页记录数:[{1}],第[{2}]页,共获取分页对象列表数：{3}!", strWhereCond, intPageSize, intPageIndex, arrClsRmTypeObjLst.Count);
lblResult20.Text = strInfo;
//显示信息框
clsCommonJsFunc.Alert(this, strInfo);
}
catch(Exception objException)
{
string strMsg = string.Format("根据条件获取相应的分页对象列表不成功, {0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
clsCommonJsFunc.Alert(this, strMsg);
}
}

 /// <summary>
 /// 根据条件获取范围内相应的对象列表
 /// (AutoGCLib.WA_ViewUTScriptCS4CSharp:Gen_WApi_Cs_btnClickGetObjLstByRange)
 /// </summary>
 /// <param name = "sender">事件发送者</param>
 /// <returns></returns>
protected void btnGetObjLstByRange_Click(object sender, EventArgs e) 
{
hidDivName.Value = "divGetObjLstByRange";
string strOrderBy = txtstrOrderBy21.Text.Trim();
int intMaxNum = int.Parse(txtintMaxNum21.Text.ToString());
int intMinNum = int.Parse(txtintMinNum21.Text.ToString());
string strWhereCond = txtstrWhereCond21.Text.Trim();
        stuRangePara objRangePara = new stuRangePara()
{
WhereCond = strWhereCond,
OrderBy = strOrderBy,
MinNum = intMinNum,
MaxNum = intMaxNum
};
try
{
List<clsClsRmTypeEN> arrClsRmTypeObjLst = clsClsRmTypeWApi.GetObjLstByRange(objRangePara);
string strInfo = string.Format("根据条件:[{0}],最小记录号:[{1}],最大记录号:[{2}],共获取分页对象列表数：{3}!", strWhereCond, intMinNum, intMaxNum, arrClsRmTypeObjLst.Count);
lblResult21.Text = strInfo;
//显示信息框
clsCommonJsFunc.Alert(this, strInfo);
}
catch(Exception objException)
{
string strMsg = string.Format("根据条件获取范围内相应的对象列表不成功, {0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
clsCommonJsFunc.Alert(this, strMsg);
}
}
}
}