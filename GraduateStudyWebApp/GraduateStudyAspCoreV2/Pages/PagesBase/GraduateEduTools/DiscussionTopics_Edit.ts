﻿
 /**
 * 类名:DiscussionTopics_Edit(界面:DiscussionTopicsCRUD)
 * 表名:DiscussionTopics(01120588)
 * 版本:2023.01.12.1(服务器:WIN-SRV103-116)
 * 日期:2023/01/12 16:37:44
 * 生成者:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 * 模块中文名:研培设置(GraduateEduTools)
 * 框架-层名:WA_编辑区后台_TS(TS)(WA_ViewScript_EditCS_TS)
 * 编程语言:TypeScript
 **/
//import $ from "jquery";
import { DiscussionType_BindDdl_DiscussionTypeIdInDiv_Cache } from "../../TS/L3_ForWApi/ParameterTable/clsDiscussionTypeWApi.js";
import { DiscussionTopics_CheckPropertyNew } from "../../TS/L3_ForWApi/GraduateEduTools/clsDiscussionTopicsWApi.js";
import { DiscussionTopics_IsExistAsync } from "../../TS/L3_ForWApi/GraduateEduTools/clsDiscussionTopicsWApi.js";
import { DiscussionTopics_AddNewRecordAsync } from "../../TS/L3_ForWApi/GraduateEduTools/clsDiscussionTopicsWApi.js";
import { DiscussionTopics_ReFreshCache } from "../../TS/L3_ForWApi/GraduateEduTools/clsDiscussionTopicsWApi.js";
import { clsDiscussionTopicsEN } from "../../TS/L0_Entity/GraduateEduTools/clsDiscussionTopicsEN.js";
import { DiscussionTopics_AddNewRecordWithMaxIdAsync } from "../../TS/L3_ForWApi/GraduateEduTools/clsDiscussionTopicsWApi.js";
import { DiscussionTopics_GetObjByTopicsIdAsync } from "../../TS/L3_ForWApi/GraduateEduTools/clsDiscussionTopicsWApi.js";
import { DiscussionTopics_CheckProperty4Update } from "../../TS/L3_ForWApi/GraduateEduTools/clsDiscussionTopicsWApi.js";
import { DiscussionTopics_UpdateRecordAsync } from "../../TS/L3_ForWApi/GraduateEduTools/clsDiscussionTopicsWApi.js";
import { BindDdl_TrueAndFalseInDiv } from "../../TS/PubFun/clsCommFunc4Web.js";
import {  CheckControlExist, CheckDivExist, GetButtonHtmlInDiv, GetCheckBoxValueInDiv, GetInputValueInDiv,GetTextAreaValueInDiv, GetSelectObjInDiv, GetSelectValueInDiv, SetButtonHtmlByIdInDiv, SetCheckBoxValueByIdInDiv, SetInputValueByIdInDiv, SetTextAreaValueByIdInDiv, SetSelectValueByIdInDiv   } from "../../TS/PubFun/clsCommFunc4Ctrl.js";
import { clsPubSessionStorage } from "../../TS/PubFun/clsPubSessionStorage.js";
import { Format, IsNullOrEmpty } from "../../TS/PubFun/clsString.js";
import { clsDateTime } from "../../TS/PubFun/clsDateTime.js";
import { IShowList } from "../../TS/PubFun/IShowList.js";
import { enumPageDispMode } from "../../TS/L0_Entity/PrjMenu/clsPageDispModeEN.js";
import { clsPublocalStorage } from "../../TS/PubFun/clsPublocalStorage.js";
/**
* 宣布一个已经在存在的函数ShowDialog，用于显示对象框，
* @param  strOpType：是操作类型，是三种类型之一：Add, Update, Detail
 **/
declare function ShowDialog(strDialogName:string): void;
/**
* 宣布一个已经在存在的函数HideDialog，用于隐藏对象框，
 **/
declare function HideDialog(strDialogName:string): void;
 /** DiscussionTopics_Edit 的摘要说明。其中Q代表查询,U代表修改
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:GeneCode)
 **/
export abstract class DiscussionTopics_Edit 
{
public opType = "";
public keyId = "";

public static id_CurrEduCls_Cache = "";
public static strPageDispModeId = "01";//PopupBox(弹出框)
public static objPage_Edit: DiscussionTopics_Edit;
public objDiscussionTopics: clsDiscussionTopicsEN;
protected iShowList: IShowList;
public bolIsLoadEditRegion = false;  //记录是否导入编辑区的变量
public divName4Edit = "divEdit";  //编辑区的Id
constructor(objShowList: IShowList) {
this.iShowList = objShowList;
DiscussionTopics_Edit.objPage_Edit = this;
this.objDiscussionTopics = new clsDiscussionTopicsEN();
}


 /**
 * 在当前界面中，导入编辑区域
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddDPV_Edit)
 * @returns 
 **/
public async AddDPV_Edit(divName4Edit:string) {
const strThisFuncName = this.AddDPV_Edit.name;
CheckDivExist(divName4Edit);
const strUrl = "../GraduateEduTools/DiscussionTopics_Edit";
//console.log("divName4Edit:(In AddDPV_Edit)" + divName4Edit);
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "GET",
dataType: "html",
data: { },
success: function(data:any) {
console.log("已经成功获取页面:" + strUrl + "  字节数: " + data.length.toString());
$('#' + divName4Edit).html(data);
resolve(true);
//setTimeout(() => { clsEditObj.BindTab(); }, 100);
//clsEditObj.BindTab();
},
error: (e:any) => {
console.error(e);
reject(e);
}
});
});
}

 /** 函数功能:页面导入,当页面开始运行时所发生的事件
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
 **/
public async Page_Load()
{
const strThisFuncName = this.Page_Load.name;
// 在此处放置用户代码以初始化页面
try
{
this.SetEventFunc();
}
catch (e)
{
const strMsg = Format("页面启动不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
}


 /** 函数功能:设置事件函数
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_SetEventFunc)
 **/
public async SetEventFunc()
{
const strThisFuncName = this.SetEventFunc.name;
// 在此处放置用户代码以初始化页面
try
{
//没有定义相关事件
}
catch (e)
{
const strMsg = Format("设置事件函数不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
}





 /**
 * 显示对话框
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_TS_ShowDialog)
 **/
public ShowDialog_DiscussionTopics(strOp:string) {
const strThisFuncName = this.ShowDialog_DiscussionTopics.name;
//检查相关控件是否存在
CheckControlExist(this.divName4Edit, "div", "divEditDialog_DiscussionTopics");
CheckControlExist(this.divName4Edit, "h4", "lblDialogTitle_DiscussionTopics");
       if (strOp === "Add" || strOp === "AddWithMaxId") {
           $('#lblDialogTitle_DiscussionTopics').html('添加记录');
//DiscussionTopics_EditEx.GetMaxStrId('#txtTopicsId');
        }
else if (strOp === "Update")
{
            $('#lblDialogTitle_DiscussionTopics').html('修改记录');
}
else if (strOp === "Detail")
{
            $('#btnSubmit_DiscussionTopics').hide();
            $('#lblDialogTitle_DiscussionTopics').html('详细信息');
}
        ShowDialog('#divEditDialog_DiscussionTopics');
}

 /**
 * 隐藏对话框
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_TS_HideDialog)
 **/
public HideDialog_DiscussionTopics() {
const strThisFuncName = this.HideDialog_DiscussionTopics.name;
CheckControlExist(this.divName4Edit, "div", "divEditDialog_DiscussionTopics");
      HideDialog('#divEditDialog_DiscussionTopics');
}

 /** 添加新记录
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecord_Click)
 **/
public async btnAddNewRecord_Click() {
const strThisFuncName = this.btnAddNewRecord_Click.name;
try
{
if (this.bolIsLoadEditRegion == false)  //
{
const responseBool = await this.AddDPV_Edit(this.divName4Edit);
this.opType = "Add";
 // 为编辑区绑定下拉框
const conBindDdl = await this.BindDdl4EditRegionInDiv();
this.SetEventFunc();
this.bolIsLoadEditRegion = true;  //
this.btnSubmit_DiscussionTopics = "确认添加";
this.btnCancel_DiscussionTopics = "取消添加";
const responseText = this.AddNewRecord();
if (DiscussionTopics_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.ShowDialog_DiscussionTopics('Add');
}
}
else
{
this.opType = "Add";
this.btnSubmit_DiscussionTopics = "确认添加";
this.btnCancel_DiscussionTopics = "取消添加";
const responseText = await this.AddNewRecord();
if (DiscussionTopics_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.ShowDialog_DiscussionTopics('Add');
}
}
}
catch(e)
{
const strMsg = Format("添加新记录初始化不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
}

 /** 添加新记录
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecordWithMaxId_Click)
 **/
public async btnAddNewRecordWithMaxId_Click() {
const strThisFuncName = this.btnAddNewRecordWithMaxId_Click.name;
try
{
if (this.bolIsLoadEditRegion == false)  //
{
const responseBool = await this.AddDPV_Edit(this.divName4Edit);
this.opType = "AddWithMaxId";
 // 为编辑区绑定下拉框
const conBindDdl = await this.BindDdl4EditRegionInDiv();
this.SetEventFunc();
this.bolIsLoadEditRegion = true;  //
this.btnSubmit_DiscussionTopics = "确认添加";
this.btnCancel_DiscussionTopics = "取消添加";
const responseText = this.AddNewRecordWithMaxId();
if (DiscussionTopics_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.ShowDialog_DiscussionTopics('Add');
}
}
else
{
this.opType = "AddWithMaxId";
this.btnSubmit_DiscussionTopics = "确认添加";
this.btnCancel_DiscussionTopics = "取消添加";
const responseText = this.AddNewRecordWithMaxId();
if (DiscussionTopics_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.ShowDialog_DiscussionTopics('Add');
}
}
}
catch(e)
{
const strMsg = Format("添加新记录初始化不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
}

 /**
 * 设置绑定下拉框，针对字段:[DiscussionTypeId]
 * (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdlInDiv_TS4TabFeature)
 **/

public async SetDdl_DiscussionTypeIdInDiv()
{
await DiscussionType_BindDdl_DiscussionTypeIdInDiv_Cache(this.divName4Edit, "ddlDiscussionTypeId" );//
}


 /** 函数功能:为编辑区绑定下拉框
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4EditRegionInDiv)
 **/
public async BindDdl4EditRegionInDiv()
{
const strThisFuncName = this.BindDdl4EditRegionInDiv.name;
// 在此处放置用户代码以初始化页面


await this.SetDdl_DiscussionTypeIdInDiv();//编辑区域
}


 /** 在数据表里修改记录
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecordInTab_Click)
 **/
public async btnUpdateRecordInTab_Click(strKeyId:string) {
const strThisFuncName = this.btnUpdateRecordInTab_Click.name;
    if (strKeyId == "")
{
alert("请选择需要修改的记录！");
return;
}
try {
if (this.bolIsLoadEditRegion == false)  //
{
const responseBool = await this.AddDPV_Edit(this.divName4Edit);
this.opType = "Update";
 // 为编辑区绑定下拉框
const conBindDdl = await this.BindDdl4EditRegionInDiv();
this.SetEventFunc();
this.bolIsLoadEditRegion = true;  //
this.btnSubmit_DiscussionTopics = "确认修改";
this.btnCancel_DiscussionTopics = "取消修改";
this.UpdateRecord(strKeyId);
if (DiscussionTopics_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.ShowDialog_DiscussionTopics('Update');
}
}
else
{
this.opType = "Update";
this.btnSubmit_DiscussionTopics = "确认修改";
this.btnCancel_DiscussionTopics = "取消修改";
this.UpdateRecord(strKeyId);
if (DiscussionTopics_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.ShowDialog_DiscussionTopics('Update');
}
}
}
catch (e)
{
const strMsg = Format("(errid: WiTsCs0034)在修改记录时出错!请联系管理员!{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
}

 /** 修改记录
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecord_Click)
 **/
public async btnUpdateRecord_Click(strKeyId: string) {
const strThisFuncName = this.btnUpdateRecord_Click.name;
if (IsNullOrEmpty(strKeyId) == true)
{
const strMsg = "修改记录的关键字为空，请检查！";
console.error(strMsg);
alert(strMsg);
return;
}
try {
if (this.bolIsLoadEditRegion == false)  //
{
const responseBool = await this.AddDPV_Edit(this.divName4Edit);
this.opType = "Update";
 // 为编辑区绑定下拉框
const conBindDdl = await this.BindDdl4EditRegionInDiv();
this.SetEventFunc();
this.bolIsLoadEditRegion = true;  //
this.btnSubmit_DiscussionTopics = "确认修改";
this.btnCancel_DiscussionTopics = "取消修改";
const update = await this.UpdateRecord(strKeyId);
if (update == false)
{
const strMsg = Format("在修改记录时,显示记录数据不成功!");
console.error(strMsg);
alert(strMsg);
return;
}
if (DiscussionTopics_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.ShowDialog_DiscussionTopics('Update');
}
}
else
{
this.opType = "Update";
this.btnSubmit_DiscussionTopics = "确认修改";
this.btnCancel_DiscussionTopics = "取消修改";
const update = await this.UpdateRecord(strKeyId);
if (update == false)
{
const strMsg = Format("在修改记录时,显示记录数据不成功!");
console.error(strMsg);
alert(strMsg);
return;
}
if (DiscussionTopics_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.ShowDialog_DiscussionTopics('Update');
}
}
}
catch (e)
{
const strMsg = Format("(errid: WiTsCs0034)在修改记录时出错!请联系管理员!{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
}

 /** 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
 * 具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
 **/
public async btnSubmit_Click()
{
const strThisFuncName = this.btnSubmit_Click.name;
const strCommandText: string = this.btnSubmit_DiscussionTopics;
try {
let returnBool = false;
let returnKeyId = "";
let strInfo = "";
let strMsg = "";
switch(strCommandText)
{
case "添加":
this.btnSubmit_DiscussionTopics = "确认添加";
this.btnCancel_DiscussionTopics = "取消添加";
 await this.AddNewRecord();
break;				
case "确认添加":
//这是一个单表的插入的代码,由于逻辑层太简单,
//就把逻辑层合并到控制层,
if (this.opType == "AddWithMaxId")
{
returnKeyId = await this.AddNewRecordWithMaxIdSave();
if (IsNullOrEmpty(returnKeyId) == false)
{
if (DiscussionTopics_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.HideDialog_DiscussionTopics();
}
this.iShowList.BindGv_Cache(clsDiscussionTopicsEN._CurrTabName, returnKeyId);
}
}
else
{
returnBool = await this.AddNewRecordSave();
if (returnBool == true)
{
if (DiscussionTopics_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.HideDialog_DiscussionTopics();
}
this.iShowList.BindGv_Cache(clsDiscussionTopicsEN._CurrTabName, returnBool.toString());
}
}
break;
case "确认修改":
//这是一个单表的修改的代码,由于逻辑层太简单,
returnBool = await this.UpdateRecordSave();
strInfo = returnBool ? "修改成功！" : "修改不成功！";
strInfo += "(In DiscussionTopics_Edit.btnSubmit_Click)";
//显示信息框
//console.log(strInfo);
alert(strInfo);
if (returnBool == true)
{
if (DiscussionTopics_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.HideDialog_DiscussionTopics();
}
this.iShowList.BindGv_Cache(clsDiscussionTopicsEN._CurrTabName, returnBool.toString());
}
break;
default:
strMsg = Format("strCommandText:{0}在switch中没有处理！(In btnSubmit_Click())", strCommandText);
console.error(strMsg);
alert(strMsg);
break;
}
}
catch (e)
{
const strMsg = Format("(errid: WiTsCs0033)在保存记录时({3})时出错!请联系管理员!{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName, strCommandText);
console.error(strMsg);
alert(strMsg);
}
}

/**
 * 清除用户自定义控件中，所有控件的值
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_Clear)
 **/
public Clear()
{
const strThisFuncName = this.Clear.name;
$('#ddlDiscussionTypeId option[0]').attr("selected", "true");
this.topicsTitle = "";
this.topicsContent = "";
this.isAudit = false;
this.isTop = false;
this.browseNumber = 0;
this.updDate = "";
this.updUser = "";
this.memo = "";
}

 /** 为插入记录做准备工作
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
 **/
public async AddNewRecord()
{
const strThisFuncName = this.AddNewRecord.name;
this.Clear();
//wucDiscussionTopicsB1.topicsId = DiscussionTopics_GetMaxStrId_S();
}

 /** 为插入记录做准备工作
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxId)
 **/
public AddNewRecordWithMaxId()
{
const strThisFuncName = this.AddNewRecordWithMaxId.name;
this.Clear();
//wucDiscussionTopicsB1.topicsId = DiscussionTopics_GetMaxStrId_S();
}

 /** 函数功能:把界面上的属性数据传到类对象中
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
 * @param pobjDiscussionTopicsEN">数据传输的目的类对象</param>
 **/
public async PutDataToDiscussionTopicsClass(pobjDiscussionTopicsEN: clsDiscussionTopicsEN)
{
const strThisFuncName = this.PutDataToDiscussionTopicsClass.name;
pobjDiscussionTopicsEN.SetDiscussionTypeId(this.discussionTypeId);// 讨论类型Id
pobjDiscussionTopicsEN.SetTopicsTitle(this.topicsTitle);// 主题标题
pobjDiscussionTopicsEN.SetTopicsContent(this.topicsContent);// 主题内容
pobjDiscussionTopicsEN.SetIsAudit(this.isAudit);// 是否审核
pobjDiscussionTopicsEN.SetIsTop(this.isTop);// 是否置顶
pobjDiscussionTopicsEN.SetBrowseNumber(this.browseNumber);// 浏览量
pobjDiscussionTopicsEN.SetUpdDate(clsDateTime.getTodayDateTimeStr(1));// 修改日期
pobjDiscussionTopicsEN.SetUpdUser(clsPublocalStorage.userId);// 修改人
pobjDiscussionTopicsEN.SetMemo(this.memo);// 备注
}


 /** 添加新记录，保存函数
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
 **/
public async AddNewRecordSave(): Promise<boolean>{
const strThisFuncName = this.AddNewRecordSave.name;
const objDiscussionTopicsEN = new clsDiscussionTopicsEN();
try
{
await this.PutDataToDiscussionTopicsClass(objDiscussionTopicsEN);
}
catch(e)
{
const strMsg = Format("从界面获取数据不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return false;//一定要有一个返回值，否则会出错！
}
try
{
DiscussionTopics_CheckPropertyNew(objDiscussionTopicsEN);
}
catch(e)
{
const strMsg = Format("检查数据不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return false;//一定要有一个返回值，否则会出错！
}
try
{
//检查唯一性条件
let returnBool = false;
const bolIsExist = await DiscussionTopics_IsExistAsync(objDiscussionTopicsEN.topicsId);
if (bolIsExist == true)
{
const strMsg = Format("添加记录时，关键字：{0}已经存在！", objDiscussionTopicsEN.topicsId);
console.error(strMsg);
alert(strMsg);
return false;//一定要有一个返回值，否则会出错！
}
returnBool = await DiscussionTopics_AddNewRecordAsync(objDiscussionTopicsEN);
if (returnBool == true)
{
DiscussionTopics_ReFreshCache(DiscussionTopics_Edit.id_CurrEduCls_Cache);
const strInfo = Format("添加记录成功!");
$('#lblResult46').val(strInfo);
//显示信息框
alert(strInfo);
}
else
{
const strInfo = Format("添加记录不成功!");
$('#lblResult46').val(strInfo);
//显示信息框
alert(strInfo);
}
return returnBool;//一定要有一个返回值，否则会出错！
}
catch(e)
{
const strMsg = Format("添加记录不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return false;//一定要有一个返回值，否则会出错！
}
}

 /** 添加新记录，由后台自动获取最大值的关键字。保存函数
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxIdSave)
 **/
public async AddNewRecordWithMaxIdSave(): Promise<string>{
const strThisFuncName = this.AddNewRecordWithMaxIdSave.name;
const objDiscussionTopicsEN = new clsDiscussionTopicsEN();
try
{
await this.PutDataToDiscussionTopicsClass(objDiscussionTopicsEN);
}
catch(e)
{
const strMsg = Format("从界面获取数据不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
console.error(strMsg);
alert(strMsg);
throw(strMsg);//一定要有一个返回值，否则会出错！
}
try
{
DiscussionTopics_CheckPropertyNew(objDiscussionTopicsEN);
}
catch(e)
{
const strMsg = Format("检查数据不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
console.error(strMsg);
alert(strMsg);
throw(strMsg);//一定要有一个返回值，否则会出错！
}
try
{
//检查唯一性条件
const responseKeyId = await DiscussionTopics_AddNewRecordWithMaxIdAsync(objDiscussionTopicsEN);
const returnKeyId: string = responseKeyId;
if (IsNullOrEmpty(returnKeyId) == false)
{
DiscussionTopics_ReFreshCache(DiscussionTopics_Edit.id_CurrEduCls_Cache);
const strInfo = Format("添加记录成功!");
$('#lblResult47').val(strInfo);
//显示信息框
alert(strInfo);
}
else
{
const strInfo = Format("添加记录不成功!");
$('#lblResult47').val(strInfo);
//显示信息框
alert(strInfo);
}
return responseKeyId;//一定要有一个返回值，否则会出错！
}
catch(e)
{
const strMsg = Format("添加记录不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
console.error(strMsg);
alert(strMsg);
throw(strMsg);
}
return "";//一定要有一个返回值，否则会出错！
}

 /** 函数功能:把以该关键字的记录内容显示在界面上,
* 在这里是把值传到表控件中
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_ShowData)
 * @param strTopicsId: 表记录的关键字,显示该表关键字的内容
 **/
  public async ShowData(strTopicsId: string) {
const strThisFuncName = this.ShowData.name;
        //操作步骤:
        //1、检查关键字是否为空；
        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
        //3、用提供的关键字初始化一个类对象；
        //4、获取类对象的所有属性；
        //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
        let objDiscussionTopicsEN = new clsDiscussionTopicsEN();
        try {
            const returnBool = await DiscussionTopics_IsExistAsync(strTopicsId);
            if (returnBool == false) {
                const strInfo = Format("关键字:[{0}] 的记录不存在!", strTopicsId);
                //$('#lblResult1').val(strInfo);
                //显示信息框
                alert(strInfo);
            }
        }
        catch (e) {
            const strMsg = Format("检查相应关键字的记录存在不成功, {0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
console.error(strMsg);
            alert(strMsg);
        }
        try {
const objDiscussionTopicsEN_Const = await DiscussionTopics_GetObjByTopicsIdAsync(strTopicsId);
       if (objDiscussionTopicsEN_Const == null)
        {
            const strMsg = Format("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
console.error(strMsg);
            alert(strMsg);
            return;
        }
         objDiscussionTopicsEN = objDiscussionTopicsEN_Const; 
        }
        catch (e) {
            const strMsg = Format("根据关键字获取相应的记录的对象不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
console.error(strMsg);
            alert(strMsg);
        }
        //3、用提供的关键字初始化一个类对象；
        this.GetDataFromDiscussionTopicsClass(objDiscussionTopicsEN);
}

 /** 函数功能:把类对象的属性内容显示到界面上
 * 注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
 * 如果在设置数据库时,就应该一级字段在前,二级字段在后
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
 * @param pobjDiscussionTopicsEN">表实体类对象</param>
 **/
public GetDataFromDiscussionTopicsClass(pobjDiscussionTopicsEN: clsDiscussionTopicsEN )
{
const strThisFuncName = this.GetDataFromDiscussionTopicsClass.name;
 this.discussionTypeId = pobjDiscussionTopicsEN.discussionTypeId;// 讨论类型Id
 this.topicsTitle = pobjDiscussionTopicsEN.topicsTitle;// 主题标题
 this.topicsContent = pobjDiscussionTopicsEN.topicsContent;// 主题内容
this.isAudit = pobjDiscussionTopicsEN.isAudit;// 是否审核
this.isTop = pobjDiscussionTopicsEN.isTop;// 是否置顶
 this.browseNumber = pobjDiscussionTopicsEN.browseNumber;// 浏览量
 this.updDate = pobjDiscussionTopicsEN.updDate;// 修改日期
 this.updUser = pobjDiscussionTopicsEN.updUser;// 修改人
 this.memo = pobjDiscussionTopicsEN.memo;// 备注
}

 /** 根据关键字获取相应的记录的对象
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
 * @param sender">参数列表</param>
 **/
public async UpdateRecord(strTopicsId: string):Promise<boolean> 
{
const strThisFuncName = this.UpdateRecord.name;
this.keyId = strTopicsId;
try
{
const objDiscussionTopicsEN_Const = await DiscussionTopics_GetObjByTopicsIdAsync(strTopicsId);
       if (objDiscussionTopicsEN_Const == null)
        {
            const strMsg = Format("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
console.error(strMsg);
            alert(strMsg);
            return false;
        }
this.objDiscussionTopics = objDiscussionTopicsEN_Const;
const conGetDataFromClass = await   this.GetDataFromDiscussionTopicsClass(objDiscussionTopicsEN_Const);
console.log("完成UpdateRecord!");
return true;
}
catch(e)
{
const strMsg = Format("根据关键字获取相应的记录的对象不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return false;
}
}

 /** 修改记录
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
 **/
public async UpdateRecordSave(): Promise<boolean> {
const strThisFuncName = this.UpdateRecordSave.name;
const objDiscussionTopicsEN = new clsDiscussionTopicsEN();
objDiscussionTopicsEN.topicsId = this.keyId;
await this.PutDataToDiscussionTopicsClass(objDiscussionTopicsEN);
objDiscussionTopicsEN.sfUpdFldSetStr = objDiscussionTopicsEN.updFldString;//设置哪些字段被修改(脏字段)
if (objDiscussionTopicsEN.topicsId == "" || objDiscussionTopicsEN.topicsId == undefined){
console.error("关键字不能为空!");
 throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
}
try
{
DiscussionTopics_CheckProperty4Update(objDiscussionTopicsEN);
}
catch(e)
{
const strMsg = Format("检查数据不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return false;//一定要有一个返回值，否则会出错！
}
try
{
//检查唯一性条件
const returnBool = await DiscussionTopics_UpdateRecordAsync(objDiscussionTopicsEN);
if (returnBool == true)
{
DiscussionTopics_ReFreshCache(DiscussionTopics_Edit.id_CurrEduCls_Cache);
}
return returnBool;
}
catch(e)
{
const strMsg = Format("修改记录不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return false;
}
}
 /**
 * 浏览量 (Used In Clear())
 **/
public  set browseNumber(value: number) {
 SetInputValueByIdInDiv(this.divName4Edit, "txtBrowseNumber", value.toString());
}
 /**
 * 浏览量 (Used In PutDataToClass())
 **/
public  get browseNumber():number {
const strValue = GetInputValueInDiv(this.divName4Edit, "txtBrowseNumber");
if (strValue == undefined) return 0;
else if (IsNullOrEmpty(strValue) == true) return 0;
else return Number(strValue);
}
 /**
 * 设置取消按钮的标题(Used In AddNewRecord())
 **/
public  set btnCancel_DiscussionTopics(value: string) {
 SetButtonHtmlByIdInDiv(this.divName4Edit, "btnCancel_DiscussionTopics", value);
}
 /**
 * 获取按钮的标题
 **/
public  get btnSubmit_DiscussionTopics():string {
const strValue = GetButtonHtmlInDiv(this.divName4Edit, "btnSubmit_DiscussionTopics");
return strValue;
}
 /**
 * 设置确定按钮的标题(Used In AddNewRecord())
 **/
public  set btnSubmit_DiscussionTopics(value: string) {
 SetButtonHtmlByIdInDiv(this.divName4Edit, "btnSubmit_DiscussionTopics", value);
}
 /**
 * 讨论类型Id (Used In Clear())
 **/
public  set discussionTypeId(value: string) {
SetSelectValueByIdInDiv(this.divName4Edit, "ddlDiscussionTypeId", value);
}
 /**
 * 讨论类型Id (Used In PutDataToClass())
 **/
public  get discussionTypeId():string {
const strValue = GetSelectValueInDiv(this.divName4Edit, "ddlDiscussionTypeId");
if (strValue == undefined) return "";
else if (strValue == "0") return "";
else return strValue;
}
 /**
 * 是否审核 (Used In Clear())
 **/
public  set isAudit(value: boolean) {
 SetCheckBoxValueByIdInDiv(this.divName4Edit, "chkIsAudit", value);
}
 /**
 * 是否审核 (Used In PutDataToClass())
 **/
public  get isAudit():boolean {
const bolValue = GetCheckBoxValueInDiv(this.divName4Edit, "chkIsAudit");
return bolValue;
}
 /**
 * 是否置顶 (Used In Clear())
 **/
public  set isTop(value: boolean) {
 SetCheckBoxValueByIdInDiv(this.divName4Edit, "chkIsTop", value);
}
 /**
 * 是否置顶 (Used In PutDataToClass())
 **/
public  get isTop():boolean {
const bolValue = GetCheckBoxValueInDiv(this.divName4Edit, "chkIsTop");
return bolValue;
}
 /**
 * 备注 (Used In Clear())
 **/
public  set memo(value: string) {
 SetInputValueByIdInDiv(this.divName4Edit, "txtMemo", value);
}
 /**
 * 备注 (Used In PutDataToClass())
 **/
public  get memo():string {
const strValue = GetInputValueInDiv(this.divName4Edit, "txtMemo");
if (strValue == undefined) return "";
else return strValue.toString();
}
 /**
 * 主题内容 (Used In Clear())
 **/
public  set topicsContent(value: string) {
 SetInputValueByIdInDiv(this.divName4Edit, "txtTopicsContent", value);
}
 /**
 * 主题内容 (Used In PutDataToClass())
 **/
public  get topicsContent():string {
const strValue = GetInputValueInDiv(this.divName4Edit, "txtTopicsContent");
if (strValue == undefined) return "";
else return strValue.toString();
}
 /**
 * 主题标题 (Used In Clear())
 **/
public  set topicsTitle(value: string) {
 SetInputValueByIdInDiv(this.divName4Edit, "txtTopicsTitle", value);
}
 /**
 * 主题标题 (Used In PutDataToClass())
 **/
public  get topicsTitle():string {
const strValue = GetInputValueInDiv(this.divName4Edit, "txtTopicsTitle");
if (strValue == undefined) return "";
else return strValue.toString();
}
 /**
 * 修改日期 (Used In Clear())
 **/
public  set updDate(value: string) {
 SetInputValueByIdInDiv(this.divName4Edit, "txtUpdDate", value);
}
 /**
 * 修改日期 (Used In PutDataToClass())
 **/
public  get updDate():string {
const strValue = GetInputValueInDiv(this.divName4Edit, "txtUpdDate");
if (strValue == undefined) return "";
else return strValue.toString();
}
 /**
 * 修改人 (Used In Clear())
 **/
public  set updUser(value: string) {
 SetInputValueByIdInDiv(this.divName4Edit, "txtUpdUser", value);
}
 /**
 * 修改人 (Used In PutDataToClass())
 **/
public  get updUser():string {
const strValue = GetInputValueInDiv(this.divName4Edit, "txtUpdUser");
if (strValue == undefined) return "";
else return strValue.toString();
}
}