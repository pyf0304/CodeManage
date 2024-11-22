
 /**
 * 类名:gs_TopicRole_Edit(界面:gs_TopicRoleCRUD)
 * 表名:gs_TopicRole(01120869)
 * 版本:2023.01.12.1(服务器:WIN-SRV103-116)
 * 日期:2023/01/12 16:39:12
 * 生成者:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 * 模块中文名:研培主题(GraduateEduTopic)
 * 框架-层名:WA_编辑区后台_TS(TS)(WA_ViewScript_EditCS_TS)
 * 编程语言:TypeScript
 **/
//import $ from "jquery";
import { gs_TopicRole_GetMaxStrIdAsync } from "../../TS/L3_ForWApi/GraduateEduTopic/clsgs_TopicRoleWApi.js";
import { gs_TopicRole_CheckPropertyNew } from "../../TS/L3_ForWApi/GraduateEduTopic/clsgs_TopicRoleWApi.js";
import { gs_TopicRole_AddNewRecordWithMaxIdAsync } from "../../TS/L3_ForWApi/GraduateEduTopic/clsgs_TopicRoleWApi.js";
import { gs_TopicRole_ReFreshCache } from "../../TS/L3_ForWApi/GraduateEduTopic/clsgs_TopicRoleWApi.js";
import { gs_TopicRole_GetUniCondStr_TopicRoleId } from "../../TS/L3_ForWApi/GraduateEduTopic/clsgs_TopicRoleWApi.js";
import { gs_TopicRole_IsExistRecordAsync } from "../../TS/L3_ForWApi/GraduateEduTopic/clsgs_TopicRoleWApi.js";
import { gs_TopicRole_GetUniCondStr4Update_TopicRoleId } from "../../TS/L3_ForWApi/GraduateEduTopic/clsgs_TopicRoleWApi.js";
import { clsgs_TopicRoleEN } from "../../TS/L0_Entity/GraduateEduTopic/clsgs_TopicRoleEN.js";
import { gs_TopicRole_IsExistAsync } from "../../TS/L3_ForWApi/GraduateEduTopic/clsgs_TopicRoleWApi.js";
import { gs_TopicRole_GetObjByTopicRoleIdAsync } from "../../TS/L3_ForWApi/GraduateEduTopic/clsgs_TopicRoleWApi.js";
import { gs_TopicRole_CheckProperty4Update } from "../../TS/L3_ForWApi/GraduateEduTopic/clsgs_TopicRoleWApi.js";
import { gs_TopicRole_UpdateRecordAsync } from "../../TS/L3_ForWApi/GraduateEduTopic/clsgs_TopicRoleWApi.js";
import { BindDdl_TrueAndFalseInDiv } from "../../TS/PubFun/clsCommFunc4Web.js";
import {  CheckControlExist, CheckDivExist, GetButtonHtmlInDiv, GetCheckBoxValueInDiv, GetInputValueInDiv,GetTextAreaValueInDiv, GetSelectObjInDiv, GetSelectValueInDiv, SetButtonHtmlByIdInDiv, SetCheckBoxValueByIdInDiv, SetInputValueByIdInDiv, SetTextAreaValueByIdInDiv, SetSelectValueByIdInDiv   } from "../../TS/PubFun/clsCommFunc4Ctrl.js";
import { clsPubSessionStorage } from "../../TS/PubFun/clsPubSessionStorage.js";
import { Format, IsNullOrEmpty } from "../../TS/PubFun/clsString.js";
import { clsDateTime } from "../../TS/PubFun/clsDateTime.js";
import { IShowList } from "../../TS/PubFun/IShowList.js";
import { enumPageDispMode } from "../../TS/L0_Entity/PrjMenu/clsPageDispModeEN.js";
/**
* 宣布一个已经在存在的函数ShowDialog，用于显示对象框，
* @param  strOpType：是操作类型，是三种类型之一：Add, Update, Detail
 **/
declare function ShowDialog(strDialogName:string): void;
/**
* 宣布一个已经在存在的函数HideDialog，用于隐藏对象框，
 **/
declare function HideDialog(strDialogName:string): void;
 /** gs_TopicRole_Edit 的摘要说明。其中Q代表查询,U代表修改
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:GeneCode)
 **/
export abstract class gs_TopicRole_Edit 
{
public opType = "";
public keyId = "";

public static strPageDispModeId = "01";//PopupBox(弹出框)
public static objPage_Edit: gs_TopicRole_Edit;
public objgs_TopicRole: clsgs_TopicRoleEN;
protected iShowList: IShowList;
public bolIsLoadEditRegion = false;  //记录是否导入编辑区的变量
public divName4Edit = "divEdit";  //编辑区的Id
constructor(objShowList: IShowList) {
this.iShowList = objShowList;
gs_TopicRole_Edit.objPage_Edit = this;
this.objgs_TopicRole = new clsgs_TopicRoleEN();
}


 /**
 * 在当前界面中，导入编辑区域
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddDPV_Edit)
 * @returns 
 **/
public async AddDPV_Edit(divName4Edit:string) {
const strThisFuncName = this.AddDPV_Edit.name;
CheckDivExist(divName4Edit);
const strUrl = "../GraduateEduTopic/gs_TopicRole_Edit";
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
public ShowDialog_gs_TopicRole(strOp:string) {
const strThisFuncName = this.ShowDialog_gs_TopicRole.name;
//检查相关控件是否存在
CheckControlExist(this.divName4Edit, "div", "divEditDialog_gs_TopicRole");
CheckControlExist(this.divName4Edit, "h4", "lblDialogTitle_gs_TopicRole");
       if (strOp === "Add" || strOp === "AddWithMaxId") {
           $('#lblDialogTitle_gs_TopicRole').html('添加记录');
//gs_TopicRole_EditEx.GetMaxStrId('#txtTopicRoleId');
        }
else if (strOp === "Update")
{
            $('#lblDialogTitle_gs_TopicRole').html('修改记录');
}
else if (strOp === "Detail")
{
            $('#btnSubmit_gs_TopicRole').hide();
            $('#lblDialogTitle_gs_TopicRole').html('详细信息');
}
        ShowDialog('#divEditDialog_gs_TopicRole');
}

 /**
 * 隐藏对话框
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_TS_HideDialog)
 **/
public HideDialog_gs_TopicRole() {
const strThisFuncName = this.HideDialog_gs_TopicRole.name;
CheckControlExist(this.divName4Edit, "div", "divEditDialog_gs_TopicRole");
      HideDialog('#divEditDialog_gs_TopicRole');
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
this.btnSubmit_gs_TopicRole = "确认添加";
this.btnCancel_gs_TopicRole = "取消添加";
const responseText = this.AddNewRecord();
if (gs_TopicRole_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.ShowDialog_gs_TopicRole('Add');
}
}
else
{
this.opType = "Add";
this.btnSubmit_gs_TopicRole = "确认添加";
this.btnCancel_gs_TopicRole = "取消添加";
const responseText = await this.AddNewRecord();
if (gs_TopicRole_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.ShowDialog_gs_TopicRole('Add');
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
this.btnSubmit_gs_TopicRole = "确认添加";
this.btnCancel_gs_TopicRole = "取消添加";
const responseText = this.AddNewRecordWithMaxId();
if (gs_TopicRole_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.ShowDialog_gs_TopicRole('Add');
}
}
else
{
this.opType = "AddWithMaxId";
this.btnSubmit_gs_TopicRole = "确认添加";
this.btnCancel_gs_TopicRole = "取消添加";
const responseText = this.AddNewRecordWithMaxId();
if (gs_TopicRole_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.ShowDialog_gs_TopicRole('Add');
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

 /** 函数功能:为编辑区绑定下拉框
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4EditRegionInDiv)
 **/
public async BindDdl4EditRegionInDiv()
{
const strThisFuncName = this.BindDdl4EditRegionInDiv.name;
// 在此处放置用户代码以初始化页面

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
this.btnSubmit_gs_TopicRole = "确认修改";
this.btnCancel_gs_TopicRole = "取消修改";
this.UpdateRecord(strKeyId);
if (gs_TopicRole_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.ShowDialog_gs_TopicRole('Update');
}
}
else
{
this.opType = "Update";
this.btnSubmit_gs_TopicRole = "确认修改";
this.btnCancel_gs_TopicRole = "取消修改";
this.UpdateRecord(strKeyId);
if (gs_TopicRole_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.ShowDialog_gs_TopicRole('Update');
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
this.btnSubmit_gs_TopicRole = "确认修改";
this.btnCancel_gs_TopicRole = "取消修改";
const update = await this.UpdateRecord(strKeyId);
if (update == false)
{
const strMsg = Format("在修改记录时,显示记录数据不成功!");
console.error(strMsg);
alert(strMsg);
return;
}
if (gs_TopicRole_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.ShowDialog_gs_TopicRole('Update');
}
}
else
{
this.opType = "Update";
this.btnSubmit_gs_TopicRole = "确认修改";
this.btnCancel_gs_TopicRole = "取消修改";
const update = await this.UpdateRecord(strKeyId);
if (update == false)
{
const strMsg = Format("在修改记录时,显示记录数据不成功!");
console.error(strMsg);
alert(strMsg);
return;
}
if (gs_TopicRole_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.ShowDialog_gs_TopicRole('Update');
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
const strCommandText: string = this.btnSubmit_gs_TopicRole;
try {
let returnBool = false;
let returnKeyId = "";
let strInfo = "";
let strMsg = "";
switch(strCommandText)
{
case "添加":
this.btnSubmit_gs_TopicRole = "确认添加";
this.btnCancel_gs_TopicRole = "取消添加";
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
if (gs_TopicRole_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.HideDialog_gs_TopicRole();
}
this.iShowList.BindGv(clsgs_TopicRoleEN._CurrTabName, returnKeyId);
}
}
else
{
returnBool = await this.AddNewRecordSave();
if (returnBool == true)
{
if (gs_TopicRole_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.HideDialog_gs_TopicRole();
}
this.iShowList.BindGv(clsgs_TopicRoleEN._CurrTabName, returnBool.toString());
}
}
break;
case "确认修改":
//这是一个单表的修改的代码,由于逻辑层太简单,
returnBool = await this.UpdateRecordSave();
strInfo = returnBool ? "修改成功！" : "修改不成功！";
strInfo += "(In gs_TopicRole_Edit.btnSubmit_Click)";
//显示信息框
//console.log(strInfo);
alert(strInfo);
if (returnBool == true)
{
if (gs_TopicRole_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.HideDialog_gs_TopicRole();
}
this.iShowList.BindGv(clsgs_TopicRoleEN._CurrTabName, returnBool.toString());
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
*  在用户自定义控件中，设置关键字的值，是否只读
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_SetKeyReadOnly)
 * @param bolReadonly:是否只读
 **/
public SetKeyReadOnly(bolReadonly:boolean)
{
const strThisFuncName = this.SetKeyReadOnly.name;
$('#txtTopicRoleId').attr('ReadOnly', bolReadonly.toString());
}

/**
 * 清除用户自定义控件中，所有控件的值
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_Clear)
 **/
public Clear()
{
const strThisFuncName = this.Clear.name;
this.topicRoleId = "";
this.topicId = "";
this.menuNum = "";
this.menuName = "";
this.menuIsHide = false;
this.updDate = "";
this.updUser = "";
}

 /** 为插入记录做准备工作
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
 **/
public async AddNewRecord()
{
const strThisFuncName = this.AddNewRecord.name;
this.Clear();
//wucgs_TopicRoleB1.topicRoleId = gs_TopicRole_GetMaxStrId_S();
try
{
const returnString = await gs_TopicRole_GetMaxStrIdAsync();
if (returnString == "")
{
const strInfo = Format("获取表gs_TopicRole的最大关键字为空，不成功，请检查!");
//显示信息框
alert(strInfo);
}
else
{
$('#txtTopicRoleId').val(returnString);
}
}
catch(e)
{
const strMsg = Format("获取表关键字的最大值不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
}

 /** 为插入记录做准备工作
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxId)
 **/
public AddNewRecordWithMaxId()
{
const strThisFuncName = this.AddNewRecordWithMaxId.name;
this.Clear();
//wucgs_TopicRoleB1.topicRoleId = gs_TopicRole_GetMaxStrId_S();
}

 /** 函数功能:把界面上的属性数据传到类对象中
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
 * @param pobjgs_TopicRoleEN">数据传输的目的类对象</param>
 **/
public async PutDataTogs_TopicRoleClass(pobjgs_TopicRoleEN: clsgs_TopicRoleEN)
{
const strThisFuncName = this.PutDataTogs_TopicRoleClass.name;
pobjgs_TopicRoleEN.SetTopicRoleId(this.topicRoleId);// 主题权限Id
pobjgs_TopicRoleEN.SetTopicId(this.topicId);// 主题编号
pobjgs_TopicRoleEN.SetMenuNum(this.menuNum);// 菜单编号
pobjgs_TopicRoleEN.SetMenuName(this.menuName);// 菜单名称
pobjgs_TopicRoleEN.SetMenuIsHide(this.menuIsHide);// 菜单是否隐藏
pobjgs_TopicRoleEN.SetUpdDate(this.updDate);// 修改日期
pobjgs_TopicRoleEN.SetUpdUser(this.updUser);// 修改人
}


 /** 添加新记录，保存函数
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
 **/
public async AddNewRecordSave(): Promise<boolean>{
const strThisFuncName = this.AddNewRecordSave.name;
const objgs_TopicRoleEN = new clsgs_TopicRoleEN();
try
{
await this.PutDataTogs_TopicRoleClass(objgs_TopicRoleEN);
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
gs_TopicRole_CheckPropertyNew(objgs_TopicRoleEN);
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
const bolIsExistCond_TopicRoleId = await this.CheckUniCond4Add_TopicRoleId(objgs_TopicRoleEN);
if (bolIsExistCond_TopicRoleId == false)
{
return false;
}
let returnBool = false;
const returnKeyId = await gs_TopicRole_AddNewRecordWithMaxIdAsync(objgs_TopicRoleEN);
if (IsNullOrEmpty(returnKeyId) == false)
{
returnBool = true;
}
if (returnBool == true)
{
gs_TopicRole_ReFreshCache();
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

 /** 为添加记录检查唯一性条件
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_CheckUniCondition4Add)
 **/
public async CheckUniCond4Add_TopicRoleId(objgs_TopicRoleEN: clsgs_TopicRoleEN): Promise<boolean>{
const strThisFuncName = this.CheckUniCond4Add_TopicRoleId.name;
const strUniquenessCondition = gs_TopicRole_GetUniCondStr_TopicRoleId(objgs_TopicRoleEN);
const bolIsExistCondition = await gs_TopicRole_IsExistRecordAsync(strUniquenessCondition);
if (bolIsExistCondition == true)
{
const strMsg = Format("不能满足唯一性条件。满足条件：{0}的记录已经存在！", strUniquenessCondition);
console.error(strMsg);
alert(strMsg);
return false;
}
return true;
}

 /** 为修改记录检查唯一性条件
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_CheckUniCondition4Update)
 **/
public async CheckUniCond4Update_TopicRoleId(objgs_TopicRoleEN: clsgs_TopicRoleEN): Promise<boolean>{
const strThisFuncName = this.CheckUniCond4Update_TopicRoleId.name;
const strUniquenessCondition = gs_TopicRole_GetUniCondStr4Update_TopicRoleId(objgs_TopicRoleEN);
const bolIsExistCondition = await gs_TopicRole_IsExistRecordAsync(strUniquenessCondition);
if (bolIsExistCondition == true)
{
const strMsg = Format("不能满足唯一性条件。满足条件：{0}的记录已经存在！", strUniquenessCondition);
console.error(strMsg);
alert(strMsg);
return false;
}
return true;
}

 /** 添加新记录，由后台自动获取最大值的关键字。保存函数
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxIdSave)
 **/
public async AddNewRecordWithMaxIdSave(): Promise<string>{
const strThisFuncName = this.AddNewRecordWithMaxIdSave.name;
const objgs_TopicRoleEN = new clsgs_TopicRoleEN();
try
{
await this.PutDataTogs_TopicRoleClass(objgs_TopicRoleEN);
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
gs_TopicRole_CheckPropertyNew(objgs_TopicRoleEN);
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
const bolIsExistCond_TopicRoleId = await this.CheckUniCond4Add_TopicRoleId(objgs_TopicRoleEN);
if (bolIsExistCond_TopicRoleId == false)
{
return "";
}
const responseKeyId = await gs_TopicRole_AddNewRecordWithMaxIdAsync(objgs_TopicRoleEN);
const returnKeyId: string = responseKeyId;
if (IsNullOrEmpty(returnKeyId) == false)
{
gs_TopicRole_ReFreshCache();
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
 * @param strTopicRoleId: 表记录的关键字,显示该表关键字的内容
 **/
  public async ShowData(strTopicRoleId: string) {
const strThisFuncName = this.ShowData.name;
        //操作步骤:
        //1、检查关键字是否为空；
        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
        //3、用提供的关键字初始化一个类对象；
        //4、获取类对象的所有属性；
        //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
        let objgs_TopicRoleEN = new clsgs_TopicRoleEN();
        try {
            const returnBool = await gs_TopicRole_IsExistAsync(strTopicRoleId);
            if (returnBool == false) {
                const strInfo = Format("关键字:[{0}] 的记录不存在!", strTopicRoleId);
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
const objgs_TopicRoleEN_Const = await gs_TopicRole_GetObjByTopicRoleIdAsync(strTopicRoleId);
       if (objgs_TopicRoleEN_Const == null)
        {
            const strMsg = Format("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
console.error(strMsg);
            alert(strMsg);
            return;
        }
         objgs_TopicRoleEN = objgs_TopicRoleEN_Const; 
        }
        catch (e) {
            const strMsg = Format("根据关键字获取相应的记录的对象不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
console.error(strMsg);
            alert(strMsg);
        }
        //3、用提供的关键字初始化一个类对象；
        this.GetDataFromgs_TopicRoleClass(objgs_TopicRoleEN);
}

 /** 函数功能:把类对象的属性内容显示到界面上
 * 注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
 * 如果在设置数据库时,就应该一级字段在前,二级字段在后
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
 * @param pobjgs_TopicRoleEN">表实体类对象</param>
 **/
public GetDataFromgs_TopicRoleClass(pobjgs_TopicRoleEN: clsgs_TopicRoleEN )
{
const strThisFuncName = this.GetDataFromgs_TopicRoleClass.name;
 this.topicRoleId = pobjgs_TopicRoleEN.topicRoleId;// 主题权限Id
 this.topicId = pobjgs_TopicRoleEN.topicId;// 主题编号
 this.menuNum = pobjgs_TopicRoleEN.menuNum;// 菜单编号
 this.menuName = pobjgs_TopicRoleEN.menuName;// 菜单名称
this.menuIsHide = pobjgs_TopicRoleEN.menuIsHide;// 菜单是否隐藏
 this.updDate = pobjgs_TopicRoleEN.updDate;// 修改日期
 this.updUser = pobjgs_TopicRoleEN.updUser;// 修改人
}

 /** 根据关键字获取相应的记录的对象
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
 * @param sender">参数列表</param>
 **/
public async UpdateRecord(strTopicRoleId: string):Promise<boolean> 
{
const strThisFuncName = this.UpdateRecord.name;
this.keyId = strTopicRoleId;
try
{
const objgs_TopicRoleEN_Const = await gs_TopicRole_GetObjByTopicRoleIdAsync(strTopicRoleId);
       if (objgs_TopicRoleEN_Const == null)
        {
            const strMsg = Format("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
console.error(strMsg);
            alert(strMsg);
            return false;
        }
this.objgs_TopicRole = objgs_TopicRoleEN_Const;
const conGetDataFromClass = await   this.GetDataFromgs_TopicRoleClass(objgs_TopicRoleEN_Const);
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
const objgs_TopicRoleEN = new clsgs_TopicRoleEN();
objgs_TopicRoleEN.topicRoleId = this.keyId;
await this.PutDataTogs_TopicRoleClass(objgs_TopicRoleEN);
objgs_TopicRoleEN.sfUpdFldSetStr = objgs_TopicRoleEN.updFldString;//设置哪些字段被修改(脏字段)
if (objgs_TopicRoleEN.topicRoleId == "" || objgs_TopicRoleEN.topicRoleId == undefined){
console.error("关键字不能为空!");
 throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
}
try
{
gs_TopicRole_CheckProperty4Update(objgs_TopicRoleEN);
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
const bolIsExistCond_TopicRoleId = await this.CheckUniCond4Update_TopicRoleId(objgs_TopicRoleEN);
if (bolIsExistCond_TopicRoleId == false)
{
return false;
}
const returnBool = await gs_TopicRole_UpdateRecordAsync(objgs_TopicRoleEN);
if (returnBool == true)
{
gs_TopicRole_ReFreshCache();
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
 * 设置取消按钮的标题(Used In AddNewRecord())
 **/
public  set btnCancel_gs_TopicRole(value: string) {
 SetButtonHtmlByIdInDiv(this.divName4Edit, "btnCancel_gs_TopicRole", value);
}
 /**
 * 获取按钮的标题
 **/
public  get btnSubmit_gs_TopicRole():string {
const strValue = GetButtonHtmlInDiv(this.divName4Edit, "btnSubmit_gs_TopicRole");
return strValue;
}
 /**
 * 设置确定按钮的标题(Used In AddNewRecord())
 **/
public  set btnSubmit_gs_TopicRole(value: string) {
 SetButtonHtmlByIdInDiv(this.divName4Edit, "btnSubmit_gs_TopicRole", value);
}
 /**
 * 菜单是否隐藏 (Used In Clear())
 **/
public  set menuIsHide(value: boolean) {
 SetCheckBoxValueByIdInDiv(this.divName4Edit, "chkMenuIsHide", value);
}
 /**
 * 菜单是否隐藏 (Used In PutDataToClass())
 **/
public  get menuIsHide():boolean {
const bolValue = GetCheckBoxValueInDiv(this.divName4Edit, "chkMenuIsHide");
return bolValue;
}
 /**
 * 菜单名称 (Used In Clear())
 **/
public  set menuName(value: string) {
 SetInputValueByIdInDiv(this.divName4Edit, "txtMenuName", value);
}
 /**
 * 菜单名称 (Used In PutDataToClass())
 **/
public  get menuName():string {
const strValue = GetInputValueInDiv(this.divName4Edit, "txtMenuName");
if (strValue == undefined) return "";
else return strValue.toString();
}
 /**
 * 菜单编号 (Used In Clear())
 **/
public  set menuNum(value: string) {
 SetInputValueByIdInDiv(this.divName4Edit, "txtMenuNum", value);
}
 /**
 * 菜单编号 (Used In PutDataToClass())
 **/
public  get menuNum():string {
const strValue = GetInputValueInDiv(this.divName4Edit, "txtMenuNum");
if (strValue == undefined) return "";
else return strValue.toString();
}
 /**
 * 主题Id (Used In Clear())
 **/
public  set topicId(value: string) {
 SetInputValueByIdInDiv(this.divName4Edit, "txtTopicId", value);
}
 /**
 * 主题Id (Used In PutDataToClass())
 **/
public  get topicId():string {
const strValue = GetInputValueInDiv(this.divName4Edit, "txtTopicId");
if (strValue == undefined) return "";
else return strValue.toString();
}
 /**
 * 主题权限Id (Used In Clear())
 **/
public  set topicRoleId(value: string) {
 SetInputValueByIdInDiv(this.divName4Edit, "txtTopicRoleId", value);
}
 /**
 * 主题权限Id (Used In PutDataToClass())
 **/
public  get topicRoleId():string {
const strValue = GetInputValueInDiv(this.divName4Edit, "txtTopicRoleId");
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