
 /**
 * 类名:gs_TotalDataStatistics_Edit(界面:gs_TotalDataStatisticsCRUD)
 * 表名:gs_TotalDataStatistics(01120683)
 * 版本:2023.01.12.1(服务器:WIN-SRV103-116)
 * 日期:2023/01/12 16:40:18
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
import { CurrEduCls_BindDdl_id_CurrEduClsInDiv_Cache } from "../../TS/L3_ForWApi/DailyRunning_Share/clsCurrEduClsWApi.js";
import { gs_TotalDataStatistics_CheckPropertyNew } from "../../TS/L3_ForWApi/GraduateEduTools/clsgs_TotalDataStatisticsWApi.js";
import { gs_TotalDataStatistics_IsExistAsync } from "../../TS/L3_ForWApi/GraduateEduTools/clsgs_TotalDataStatisticsWApi.js";
import { gs_TotalDataStatistics_AddNewRecordAsync } from "../../TS/L3_ForWApi/GraduateEduTools/clsgs_TotalDataStatisticsWApi.js";
import { gs_TotalDataStatistics_ReFreshCache } from "../../TS/L3_ForWApi/GraduateEduTools/clsgs_TotalDataStatisticsWApi.js";
import { gs_TotalDataStatistics_GetUniCondStr_TotalDataTypeId_TableKey } from "../../TS/L3_ForWApi/GraduateEduTools/clsgs_TotalDataStatisticsWApi.js";
import { gs_TotalDataStatistics_IsExistRecordAsync } from "../../TS/L3_ForWApi/GraduateEduTools/clsgs_TotalDataStatisticsWApi.js";
import { gs_TotalDataStatistics_GetUniCondStr4Update_TotalDataTypeId_TableKey } from "../../TS/L3_ForWApi/GraduateEduTools/clsgs_TotalDataStatisticsWApi.js";
import { clsgs_TotalDataStatisticsEN } from "../../TS/L0_Entity/GraduateEduTools/clsgs_TotalDataStatisticsEN.js";
import { gs_TotalDataStatistics_AddNewRecordWithMaxIdAsync } from "../../TS/L3_ForWApi/GraduateEduTools/clsgs_TotalDataStatisticsWApi.js";
import { gs_TotalDataStatistics_GetObjByTotalDataIdAsync } from "../../TS/L3_ForWApi/GraduateEduTools/clsgs_TotalDataStatisticsWApi.js";
import { gs_TotalDataStatistics_CheckProperty4Update } from "../../TS/L3_ForWApi/GraduateEduTools/clsgs_TotalDataStatisticsWApi.js";
import { gs_TotalDataStatistics_UpdateRecordAsync } from "../../TS/L3_ForWApi/GraduateEduTools/clsgs_TotalDataStatisticsWApi.js";
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
 /** gs_TotalDataStatistics_Edit 的摘要说明。其中Q代表查询,U代表修改
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:GeneCode)
 **/
export abstract class gs_TotalDataStatistics_Edit 
{
public opType = "";
public keyId = "";

public static id_CurrEduCls_Cache = "";
public static CourseId_Static = "";//定义下拉框条件变量1
public static strPageDispModeId = "01";//PopupBox(弹出框)
public static objPage_Edit: gs_TotalDataStatistics_Edit;
public objgs_TotalDataStatistics: clsgs_TotalDataStatisticsEN;
protected iShowList: IShowList;
public bolIsLoadEditRegion = false;  //记录是否导入编辑区的变量
public divName4Edit = "divEdit";  //编辑区的Id
constructor(objShowList: IShowList) {
this.iShowList = objShowList;
gs_TotalDataStatistics_Edit.objPage_Edit = this;
this.objgs_TotalDataStatistics = new clsgs_TotalDataStatisticsEN();
}


 /**
 * 在当前界面中，导入编辑区域
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddDPV_Edit)
 * @returns 
 **/
public async AddDPV_Edit(divName4Edit:string) {
const strThisFuncName = this.AddDPV_Edit.name;
CheckDivExist(divName4Edit);
const strUrl = "../GraduateEduTools/gs_TotalDataStatistics_Edit";
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
public ShowDialog_gs_TotalDataStatistics(strOp:string) {
const strThisFuncName = this.ShowDialog_gs_TotalDataStatistics.name;
//检查相关控件是否存在
CheckControlExist(this.divName4Edit, "div", "divEditDialog_gs_TotalDataStatistics");
CheckControlExist(this.divName4Edit, "h4", "lblDialogTitle_gs_TotalDataStatistics");
       if (strOp === "Add" || strOp === "AddWithMaxId") {
           $('#lblDialogTitle_gs_TotalDataStatistics').html('添加记录');
//gs_TotalDataStatistics_EditEx.GetMaxStrId('#txtTotalDataId');
        }
else if (strOp === "Update")
{
            $('#lblDialogTitle_gs_TotalDataStatistics').html('修改记录');
}
else if (strOp === "Detail")
{
            $('#btnSubmit_gs_TotalDataStatistics').hide();
            $('#lblDialogTitle_gs_TotalDataStatistics').html('详细信息');
}
        ShowDialog('#divEditDialog_gs_TotalDataStatistics');
}

 /**
 * 隐藏对话框
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_TS_HideDialog)
 **/
public HideDialog_gs_TotalDataStatistics() {
const strThisFuncName = this.HideDialog_gs_TotalDataStatistics.name;
CheckControlExist(this.divName4Edit, "div", "divEditDialog_gs_TotalDataStatistics");
      HideDialog('#divEditDialog_gs_TotalDataStatistics');
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
this.btnSubmit_gs_TotalDataStatistics = "确认添加";
this.btnCancel_gs_TotalDataStatistics = "取消添加";
const responseText = this.AddNewRecord();
if (gs_TotalDataStatistics_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.ShowDialog_gs_TotalDataStatistics('Add');
}
}
else
{
this.opType = "Add";
this.btnSubmit_gs_TotalDataStatistics = "确认添加";
this.btnCancel_gs_TotalDataStatistics = "取消添加";
const responseText = await this.AddNewRecord();
if (gs_TotalDataStatistics_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.ShowDialog_gs_TotalDataStatistics('Add');
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
this.btnSubmit_gs_TotalDataStatistics = "确认添加";
this.btnCancel_gs_TotalDataStatistics = "取消添加";
const responseText = this.AddNewRecordWithMaxId();
if (gs_TotalDataStatistics_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.ShowDialog_gs_TotalDataStatistics('Add');
}
}
else
{
this.opType = "AddWithMaxId";
this.btnSubmit_gs_TotalDataStatistics = "确认添加";
this.btnCancel_gs_TotalDataStatistics = "取消添加";
const responseText = this.AddNewRecordWithMaxId();
if (gs_TotalDataStatistics_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.ShowDialog_gs_TotalDataStatistics('Add');
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
 * 设置绑定下拉框，针对字段:[id_CurrEduCls]
 * (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdlInDiv_TS4TabFeature)
 **/

public async SetDdl_id_CurrEduClsInDiv(courseId:string)
{
await CurrEduCls_BindDdl_id_CurrEduClsInDiv_Cache(this.divName4Edit, "ddlid_CurrEduCls" , courseId);//
}


 /** 函数功能:为编辑区绑定下拉框
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4EditRegionInDiv)
 **/
public async BindDdl4EditRegionInDiv()
{
const strThisFuncName = this.BindDdl4EditRegionInDiv.name;
// 在此处放置用户代码以初始化页面
const strCourseId = gs_TotalDataStatistics_Edit.CourseId_Static;


await this.SetDdl_id_CurrEduClsInDiv(strCourseId);//编辑区域
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
this.btnSubmit_gs_TotalDataStatistics = "确认修改";
this.btnCancel_gs_TotalDataStatistics = "取消修改";
this.UpdateRecord(strKeyId);
if (gs_TotalDataStatistics_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.ShowDialog_gs_TotalDataStatistics('Update');
}
}
else
{
this.opType = "Update";
this.btnSubmit_gs_TotalDataStatistics = "确认修改";
this.btnCancel_gs_TotalDataStatistics = "取消修改";
this.UpdateRecord(strKeyId);
if (gs_TotalDataStatistics_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.ShowDialog_gs_TotalDataStatistics('Update');
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
this.btnSubmit_gs_TotalDataStatistics = "确认修改";
this.btnCancel_gs_TotalDataStatistics = "取消修改";
const update = await this.UpdateRecord(strKeyId);
if (update == false)
{
const strMsg = Format("在修改记录时,显示记录数据不成功!");
console.error(strMsg);
alert(strMsg);
return;
}
if (gs_TotalDataStatistics_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.ShowDialog_gs_TotalDataStatistics('Update');
}
}
else
{
this.opType = "Update";
this.btnSubmit_gs_TotalDataStatistics = "确认修改";
this.btnCancel_gs_TotalDataStatistics = "取消修改";
const update = await this.UpdateRecord(strKeyId);
if (update == false)
{
const strMsg = Format("在修改记录时,显示记录数据不成功!");
console.error(strMsg);
alert(strMsg);
return;
}
if (gs_TotalDataStatistics_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.ShowDialog_gs_TotalDataStatistics('Update');
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
const strCommandText: string = this.btnSubmit_gs_TotalDataStatistics;
try {
let returnBool = false;
let returnKeyId = "";
let strInfo = "";
let strMsg = "";
switch(strCommandText)
{
case "添加":
this.btnSubmit_gs_TotalDataStatistics = "确认添加";
this.btnCancel_gs_TotalDataStatistics = "取消添加";
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
if (gs_TotalDataStatistics_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.HideDialog_gs_TotalDataStatistics();
}
this.iShowList.BindGv_Cache(clsgs_TotalDataStatisticsEN._CurrTabName, returnKeyId);
}
}
else
{
returnBool = await this.AddNewRecordSave();
if (returnBool == true)
{
if (gs_TotalDataStatistics_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.HideDialog_gs_TotalDataStatistics();
}
this.iShowList.BindGv_Cache(clsgs_TotalDataStatisticsEN._CurrTabName, returnBool.toString());
}
}
break;
case "确认修改":
//这是一个单表的修改的代码,由于逻辑层太简单,
returnBool = await this.UpdateRecordSave();
strInfo = returnBool ? "修改成功！" : "修改不成功！";
strInfo += "(In gs_TotalDataStatistics_Edit.btnSubmit_Click)";
//显示信息框
//console.log(strInfo);
alert(strInfo);
if (returnBool == true)
{
if (gs_TotalDataStatistics_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.HideDialog_gs_TotalDataStatistics();
}
this.iShowList.BindGv_Cache(clsgs_TotalDataStatisticsEN._CurrTabName, returnBool.toString());
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
$('#ddlid_CurrEduCls option[0]').attr("selected", "true");
this.totalDataTypeId = "";
this.tableKey = "";
this.dataUser = "";
this.dataAddDate = "";
this.month = 0;
this.week = 0;
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
//wucgs_TotalDataStatisticsB1.totalDataId = gs_TotalDataStatistics_GetMaxStrId_S();
}

 /** 为插入记录做准备工作
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxId)
 **/
public AddNewRecordWithMaxId()
{
const strThisFuncName = this.AddNewRecordWithMaxId.name;
this.Clear();
//wucgs_TotalDataStatisticsB1.totalDataId = gs_TotalDataStatistics_GetMaxStrId_S();
}

 /** 函数功能:把界面上的属性数据传到类对象中
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
 * @param pobjgs_TotalDataStatisticsEN">数据传输的目的类对象</param>
 **/
public async PutDataTogs_TotalDataStatisticsClass(pobjgs_TotalDataStatisticsEN: clsgs_TotalDataStatisticsEN)
{
const strThisFuncName = this.PutDataTogs_TotalDataStatisticsClass.name;
pobjgs_TotalDataStatisticsEN.Setid_CurrEduCls(this.id_CurrEduCls);// 当前教学班流水号
pobjgs_TotalDataStatisticsEN.SetTotalDataTypeId(this.totalDataTypeId);// 总数据类型Id
pobjgs_TotalDataStatisticsEN.SetTableKey(this.tableKey);// 表主键
pobjgs_TotalDataStatisticsEN.SetDataUser(this.dataUser);// 数据用户
pobjgs_TotalDataStatisticsEN.SetDataAddDate(this.dataAddDate);// 数据添加日期
pobjgs_TotalDataStatisticsEN.SetMonth(this.month);// 月
pobjgs_TotalDataStatisticsEN.SetWeek(this.week);// 周
pobjgs_TotalDataStatisticsEN.SetUpdDate(this.updDate);// 修改日期
pobjgs_TotalDataStatisticsEN.SetUpdUser(this.updUser);// 修改人
pobjgs_TotalDataStatisticsEN.SetMemo(this.memo);// 备注
}


 /** 添加新记录，保存函数
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
 **/
public async AddNewRecordSave(): Promise<boolean>{
const strThisFuncName = this.AddNewRecordSave.name;
const objgs_TotalDataStatisticsEN = new clsgs_TotalDataStatisticsEN();
try
{
await this.PutDataTogs_TotalDataStatisticsClass(objgs_TotalDataStatisticsEN);
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
gs_TotalDataStatistics_CheckPropertyNew(objgs_TotalDataStatisticsEN);
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
const bolIsExistCond_TotalDataTypeId_TableKey = await this.CheckUniCond4Add_TotalDataTypeId_TableKey(objgs_TotalDataStatisticsEN);
if (bolIsExistCond_TotalDataTypeId_TableKey == false)
{
return false;
}
let returnBool = false;
const bolIsExist = await gs_TotalDataStatistics_IsExistAsync(objgs_TotalDataStatisticsEN.totalDataId);
if (bolIsExist == true)
{
const strMsg = Format("添加记录时，关键字：{0}已经存在！", objgs_TotalDataStatisticsEN.totalDataId);
console.error(strMsg);
alert(strMsg);
return false;//一定要有一个返回值，否则会出错！
}
returnBool = await gs_TotalDataStatistics_AddNewRecordAsync(objgs_TotalDataStatisticsEN);
if (returnBool == true)
{
gs_TotalDataStatistics_ReFreshCache(gs_TotalDataStatistics_Edit.id_CurrEduCls_Cache);
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
public async CheckUniCond4Add_TotalDataTypeId_TableKey(objgs_TotalDataStatisticsEN: clsgs_TotalDataStatisticsEN): Promise<boolean>{
const strThisFuncName = this.CheckUniCond4Add_TotalDataTypeId_TableKey.name;
const strUniquenessCondition = gs_TotalDataStatistics_GetUniCondStr_TotalDataTypeId_TableKey(objgs_TotalDataStatisticsEN);
const bolIsExistCondition = await gs_TotalDataStatistics_IsExistRecordAsync(strUniquenessCondition);
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
public async CheckUniCond4Update_TotalDataTypeId_TableKey(objgs_TotalDataStatisticsEN: clsgs_TotalDataStatisticsEN): Promise<boolean>{
const strThisFuncName = this.CheckUniCond4Update_TotalDataTypeId_TableKey.name;
const strUniquenessCondition = gs_TotalDataStatistics_GetUniCondStr4Update_TotalDataTypeId_TableKey(objgs_TotalDataStatisticsEN);
const bolIsExistCondition = await gs_TotalDataStatistics_IsExistRecordAsync(strUniquenessCondition);
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
const objgs_TotalDataStatisticsEN = new clsgs_TotalDataStatisticsEN();
try
{
await this.PutDataTogs_TotalDataStatisticsClass(objgs_TotalDataStatisticsEN);
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
gs_TotalDataStatistics_CheckPropertyNew(objgs_TotalDataStatisticsEN);
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
const bolIsExistCond_TotalDataTypeId_TableKey = await this.CheckUniCond4Add_TotalDataTypeId_TableKey(objgs_TotalDataStatisticsEN);
if (bolIsExistCond_TotalDataTypeId_TableKey == false)
{
return "";
}
const responseKeyId = await gs_TotalDataStatistics_AddNewRecordWithMaxIdAsync(objgs_TotalDataStatisticsEN);
const returnKeyId: string = responseKeyId;
if (IsNullOrEmpty(returnKeyId) == false)
{
gs_TotalDataStatistics_ReFreshCache(gs_TotalDataStatistics_Edit.id_CurrEduCls_Cache);
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
 * @param strTotalDataId: 表记录的关键字,显示该表关键字的内容
 **/
  public async ShowData(strTotalDataId: string) {
const strThisFuncName = this.ShowData.name;
        //操作步骤:
        //1、检查关键字是否为空；
        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
        //3、用提供的关键字初始化一个类对象；
        //4、获取类对象的所有属性；
        //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
        let objgs_TotalDataStatisticsEN = new clsgs_TotalDataStatisticsEN();
        try {
            const returnBool = await gs_TotalDataStatistics_IsExistAsync(strTotalDataId);
            if (returnBool == false) {
                const strInfo = Format("关键字:[{0}] 的记录不存在!", strTotalDataId);
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
const objgs_TotalDataStatisticsEN_Const = await gs_TotalDataStatistics_GetObjByTotalDataIdAsync(strTotalDataId);
       if (objgs_TotalDataStatisticsEN_Const == null)
        {
            const strMsg = Format("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
console.error(strMsg);
            alert(strMsg);
            return;
        }
         objgs_TotalDataStatisticsEN = objgs_TotalDataStatisticsEN_Const; 
        }
        catch (e) {
            const strMsg = Format("根据关键字获取相应的记录的对象不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
console.error(strMsg);
            alert(strMsg);
        }
        //3、用提供的关键字初始化一个类对象；
        this.GetDataFromgs_TotalDataStatisticsClass(objgs_TotalDataStatisticsEN);
}

 /** 函数功能:把类对象的属性内容显示到界面上
 * 注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
 * 如果在设置数据库时,就应该一级字段在前,二级字段在后
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
 * @param pobjgs_TotalDataStatisticsEN">表实体类对象</param>
 **/
public GetDataFromgs_TotalDataStatisticsClass(pobjgs_TotalDataStatisticsEN: clsgs_TotalDataStatisticsEN )
{
const strThisFuncName = this.GetDataFromgs_TotalDataStatisticsClass.name;
 this.id_CurrEduCls = pobjgs_TotalDataStatisticsEN.id_CurrEduCls;// 当前教学班流水号
 this.totalDataTypeId = pobjgs_TotalDataStatisticsEN.totalDataTypeId;// 总数据类型Id
 this.tableKey = pobjgs_TotalDataStatisticsEN.tableKey;// 表主键
 this.dataUser = pobjgs_TotalDataStatisticsEN.dataUser;// 数据用户
 this.dataAddDate = pobjgs_TotalDataStatisticsEN.dataAddDate;// 数据添加日期
 this.month = pobjgs_TotalDataStatisticsEN.month;// 月
 this.week = pobjgs_TotalDataStatisticsEN.week;// 周
 this.updDate = pobjgs_TotalDataStatisticsEN.updDate;// 修改日期
 this.updUser = pobjgs_TotalDataStatisticsEN.updUser;// 修改人
 this.memo = pobjgs_TotalDataStatisticsEN.memo;// 备注
}

 /** 根据关键字获取相应的记录的对象
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
 * @param sender">参数列表</param>
 **/
public async UpdateRecord(strTotalDataId: string):Promise<boolean> 
{
const strThisFuncName = this.UpdateRecord.name;
this.keyId = strTotalDataId;
try
{
const objgs_TotalDataStatisticsEN_Const = await gs_TotalDataStatistics_GetObjByTotalDataIdAsync(strTotalDataId);
       if (objgs_TotalDataStatisticsEN_Const == null)
        {
            const strMsg = Format("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
console.error(strMsg);
            alert(strMsg);
            return false;
        }
this.objgs_TotalDataStatistics = objgs_TotalDataStatisticsEN_Const;
const conGetDataFromClass = await   this.GetDataFromgs_TotalDataStatisticsClass(objgs_TotalDataStatisticsEN_Const);
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
const objgs_TotalDataStatisticsEN = new clsgs_TotalDataStatisticsEN();
objgs_TotalDataStatisticsEN.totalDataId = this.keyId;
await this.PutDataTogs_TotalDataStatisticsClass(objgs_TotalDataStatisticsEN);
objgs_TotalDataStatisticsEN.sfUpdFldSetStr = objgs_TotalDataStatisticsEN.updFldString;//设置哪些字段被修改(脏字段)
if (objgs_TotalDataStatisticsEN.totalDataId == "" || objgs_TotalDataStatisticsEN.totalDataId == undefined){
console.error("关键字不能为空!");
 throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
}
try
{
gs_TotalDataStatistics_CheckProperty4Update(objgs_TotalDataStatisticsEN);
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
const bolIsExistCond_TotalDataTypeId_TableKey = await this.CheckUniCond4Update_TotalDataTypeId_TableKey(objgs_TotalDataStatisticsEN);
if (bolIsExistCond_TotalDataTypeId_TableKey == false)
{
return false;
}
const returnBool = await gs_TotalDataStatistics_UpdateRecordAsync(objgs_TotalDataStatisticsEN);
if (returnBool == true)
{
gs_TotalDataStatistics_ReFreshCache(gs_TotalDataStatistics_Edit.id_CurrEduCls_Cache);
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
public  set btnCancel_gs_TotalDataStatistics(value: string) {
 SetButtonHtmlByIdInDiv(this.divName4Edit, "btnCancel_gs_TotalDataStatistics", value);
}
 /**
 * 获取按钮的标题
 **/
public  get btnSubmit_gs_TotalDataStatistics():string {
const strValue = GetButtonHtmlInDiv(this.divName4Edit, "btnSubmit_gs_TotalDataStatistics");
return strValue;
}
 /**
 * 设置确定按钮的标题(Used In AddNewRecord())
 **/
public  set btnSubmit_gs_TotalDataStatistics(value: string) {
 SetButtonHtmlByIdInDiv(this.divName4Edit, "btnSubmit_gs_TotalDataStatistics", value);
}
 /**
 * 数据添加日期 (Used In Clear())
 **/
public  set dataAddDate(value: string) {
 SetInputValueByIdInDiv(this.divName4Edit, "txtDataAddDate", value);
}
 /**
 * 数据添加日期 (Used In PutDataToClass())
 **/
public  get dataAddDate():string {
const strValue = GetInputValueInDiv(this.divName4Edit, "txtDataAddDate");
if (strValue == undefined) return "";
else return strValue.toString();
}
 /**
 * 数据用户 (Used In Clear())
 **/
public  set dataUser(value: string) {
 SetInputValueByIdInDiv(this.divName4Edit, "txtDataUser", value);
}
 /**
 * 数据用户 (Used In PutDataToClass())
 **/
public  get dataUser():string {
const strValue = GetInputValueInDiv(this.divName4Edit, "txtDataUser");
if (strValue == undefined) return "";
else return strValue.toString();
}
 /**
 * 教学班流水号 (Used In Clear())
 **/
public  set id_CurrEduCls(value: string) {
SetSelectValueByIdInDiv(this.divName4Edit, "ddlid_CurrEduCls", value);
}
 /**
 * 教学班流水号 (Used In PutDataToClass())
 **/
public  get id_CurrEduCls():string {
const strValue = GetSelectValueInDiv(this.divName4Edit, "ddlid_CurrEduCls");
if (strValue == undefined) return "";
else if (strValue == "0") return "";
else return strValue;
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
 * 月 (Used In Clear())
 **/
public  set month(value: number) {
 SetInputValueByIdInDiv(this.divName4Edit, "txtMonth", value.toString());
}
 /**
 * 月 (Used In PutDataToClass())
 **/
public  get month():number {
const strValue = GetInputValueInDiv(this.divName4Edit, "txtMonth");
if (strValue == undefined) return 0;
else if (IsNullOrEmpty(strValue) == true) return 0;
else return Number(strValue);
}
 /**
 * 表主键 (Used In Clear())
 **/
public  set tableKey(value: string) {
 SetInputValueByIdInDiv(this.divName4Edit, "txtTableKey", value);
}
 /**
 * 表主键 (Used In PutDataToClass())
 **/
public  get tableKey():string {
const strValue = GetInputValueInDiv(this.divName4Edit, "txtTableKey");
if (strValue == undefined) return "";
else return strValue.toString();
}
 /**
 * 总数据类型Id (Used In Clear())
 **/
public  set totalDataTypeId(value: string) {
 SetInputValueByIdInDiv(this.divName4Edit, "txtTotalDataTypeId", value);
}
 /**
 * 总数据类型Id (Used In PutDataToClass())
 **/
public  get totalDataTypeId():string {
const strValue = GetInputValueInDiv(this.divName4Edit, "txtTotalDataTypeId");
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
 /**
 * 周 (Used In Clear())
 **/
public  set week(value: number) {
 SetInputValueByIdInDiv(this.divName4Edit, "txtWeek", value.toString());
}
 /**
 * 周 (Used In PutDataToClass())
 **/
public  get week():number {
const strValue = GetInputValueInDiv(this.divName4Edit, "txtWeek");
if (strValue == undefined) return 0;
else if (IsNullOrEmpty(strValue) == true) return 0;
else return Number(strValue);
}
}