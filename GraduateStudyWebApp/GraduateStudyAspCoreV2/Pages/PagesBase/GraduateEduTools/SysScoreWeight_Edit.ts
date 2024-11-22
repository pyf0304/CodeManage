
 /**
 * 类名:SysScoreWeight_Edit(界面:SysScoreWeightCRUD)
 * 表名:SysScoreWeight(01120629)
 * 版本:2023.01.12.1(服务器:WIN-SRV103-116)
 * 日期:2023/01/12 16:39:53
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
import { SysScoreType_BindDdl_ScoreTypeIdInDiv_Cache } from "../../TS/L3_ForWApi/ParameterTable/clsSysScoreTypeWApi.js";
import { CurrEduCls_BindDdl_id_CurrEduClsInDiv_Cache } from "../../TS/L3_ForWApi/DailyRunning_Share/clsCurrEduClsWApi.js";
import { SysScoreWeight_CheckPropertyNew } from "../../TS/L3_ForWApi/GraduateEduTools/clsSysScoreWeightWApi.js";
import { SysScoreWeight_IsExistAsync } from "../../TS/L3_ForWApi/GraduateEduTools/clsSysScoreWeightWApi.js";
import { SysScoreWeight_AddNewRecordAsync } from "../../TS/L3_ForWApi/GraduateEduTools/clsSysScoreWeightWApi.js";
import { clsSysScoreWeightEN } from "../../TS/L0_Entity/GraduateEduTools/clsSysScoreWeightEN.js";
import { SysScoreWeight_AddNewRecordWithMaxIdAsync } from "../../TS/L3_ForWApi/GraduateEduTools/clsSysScoreWeightWApi.js";
import { SysScoreWeight_GetObjByScoreWeightIdAsync } from "../../TS/L3_ForWApi/GraduateEduTools/clsSysScoreWeightWApi.js";
import { SysScoreWeight_CheckProperty4Update } from "../../TS/L3_ForWApi/GraduateEduTools/clsSysScoreWeightWApi.js";
import { SysScoreWeight_UpdateRecordAsync } from "../../TS/L3_ForWApi/GraduateEduTools/clsSysScoreWeightWApi.js";
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
 /** SysScoreWeight_Edit 的摘要说明。其中Q代表查询,U代表修改
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:GeneCode)
 **/
export abstract class SysScoreWeight_Edit 
{
public opType = "";
public keyId = "";

public static CourseId_Static = "";//定义下拉框条件变量1
public static strPageDispModeId = "01";//PopupBox(弹出框)
public static objPage_Edit: SysScoreWeight_Edit;
public objSysScoreWeight: clsSysScoreWeightEN;
protected iShowList: IShowList;
public bolIsLoadEditRegion = false;  //记录是否导入编辑区的变量
public divName4Edit = "divEdit";  //编辑区的Id
constructor(objShowList: IShowList) {
this.iShowList = objShowList;
SysScoreWeight_Edit.objPage_Edit = this;
this.objSysScoreWeight = new clsSysScoreWeightEN();
}


 /**
 * 在当前界面中，导入编辑区域
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddDPV_Edit)
 * @returns 
 **/
public async AddDPV_Edit(divName4Edit:string) {
const strThisFuncName = this.AddDPV_Edit.name;
CheckDivExist(divName4Edit);
const strUrl = "../GraduateEduTools/SysScoreWeight_Edit";
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
public ShowDialog_SysScoreWeight(strOp:string) {
const strThisFuncName = this.ShowDialog_SysScoreWeight.name;
//检查相关控件是否存在
CheckControlExist(this.divName4Edit, "div", "divEditDialog_SysScoreWeight");
CheckControlExist(this.divName4Edit, "h4", "lblDialogTitle_SysScoreWeight");
       if (strOp === "Add" || strOp === "AddWithMaxId") {
           $('#lblDialogTitle_SysScoreWeight').html('添加记录');
//SysScoreWeight_EditEx.GetMaxStrId('#txtScoreWeightId');
        }
else if (strOp === "Update")
{
            $('#lblDialogTitle_SysScoreWeight').html('修改记录');
}
else if (strOp === "Detail")
{
            $('#btnSubmit_SysScoreWeight').hide();
            $('#lblDialogTitle_SysScoreWeight').html('详细信息');
}
        ShowDialog('#divEditDialog_SysScoreWeight');
}

 /**
 * 隐藏对话框
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_TS_HideDialog)
 **/
public HideDialog_SysScoreWeight() {
const strThisFuncName = this.HideDialog_SysScoreWeight.name;
CheckControlExist(this.divName4Edit, "div", "divEditDialog_SysScoreWeight");
      HideDialog('#divEditDialog_SysScoreWeight');
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
this.btnSubmit_SysScoreWeight = "确认添加";
this.btnCancel_SysScoreWeight = "取消添加";
const responseText = this.AddNewRecord();
if (SysScoreWeight_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.ShowDialog_SysScoreWeight('Add');
}
}
else
{
this.opType = "Add";
this.btnSubmit_SysScoreWeight = "确认添加";
this.btnCancel_SysScoreWeight = "取消添加";
const responseText = await this.AddNewRecord();
if (SysScoreWeight_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.ShowDialog_SysScoreWeight('Add');
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
this.btnSubmit_SysScoreWeight = "确认添加";
this.btnCancel_SysScoreWeight = "取消添加";
const responseText = this.AddNewRecordWithMaxId();
if (SysScoreWeight_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.ShowDialog_SysScoreWeight('Add');
}
}
else
{
this.opType = "AddWithMaxId";
this.btnSubmit_SysScoreWeight = "确认添加";
this.btnCancel_SysScoreWeight = "取消添加";
const responseText = this.AddNewRecordWithMaxId();
if (SysScoreWeight_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.ShowDialog_SysScoreWeight('Add');
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
 * 设置绑定下拉框，针对字段:[ScoreTypeId]
 * (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdlInDiv_TS4TabFeature)
 **/

public async SetDdl_ScoreTypeIdInDiv()
{
await SysScoreType_BindDdl_ScoreTypeIdInDiv_Cache(this.divName4Edit, "ddlScoreTypeId" );//
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
const strCourseId = SysScoreWeight_Edit.CourseId_Static;


await this.SetDdl_ScoreTypeIdInDiv();//编辑区域

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
this.btnSubmit_SysScoreWeight = "确认修改";
this.btnCancel_SysScoreWeight = "取消修改";
this.UpdateRecord(strKeyId);
if (SysScoreWeight_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.ShowDialog_SysScoreWeight('Update');
}
}
else
{
this.opType = "Update";
this.btnSubmit_SysScoreWeight = "确认修改";
this.btnCancel_SysScoreWeight = "取消修改";
this.UpdateRecord(strKeyId);
if (SysScoreWeight_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.ShowDialog_SysScoreWeight('Update');
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
this.btnSubmit_SysScoreWeight = "确认修改";
this.btnCancel_SysScoreWeight = "取消修改";
const update = await this.UpdateRecord(strKeyId);
if (update == false)
{
const strMsg = Format("在修改记录时,显示记录数据不成功!");
console.error(strMsg);
alert(strMsg);
return;
}
if (SysScoreWeight_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.ShowDialog_SysScoreWeight('Update');
}
}
else
{
this.opType = "Update";
this.btnSubmit_SysScoreWeight = "确认修改";
this.btnCancel_SysScoreWeight = "取消修改";
const update = await this.UpdateRecord(strKeyId);
if (update == false)
{
const strMsg = Format("在修改记录时,显示记录数据不成功!");
console.error(strMsg);
alert(strMsg);
return;
}
if (SysScoreWeight_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.ShowDialog_SysScoreWeight('Update');
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
const strCommandText: string = this.btnSubmit_SysScoreWeight;
try {
let returnBool = false;
let returnKeyId = "";
let strInfo = "";
let strMsg = "";
switch(strCommandText)
{
case "添加":
this.btnSubmit_SysScoreWeight = "确认添加";
this.btnCancel_SysScoreWeight = "取消添加";
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
if (SysScoreWeight_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.HideDialog_SysScoreWeight();
}
this.iShowList.BindGv(clsSysScoreWeightEN._CurrTabName, returnKeyId);
}
}
else
{
returnBool = await this.AddNewRecordSave();
if (returnBool == true)
{
if (SysScoreWeight_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.HideDialog_SysScoreWeight();
}
this.iShowList.BindGv(clsSysScoreWeightEN._CurrTabName, returnBool.toString());
}
}
break;
case "确认修改":
//这是一个单表的修改的代码,由于逻辑层太简单,
returnBool = await this.UpdateRecordSave();
strInfo = returnBool ? "修改成功！" : "修改不成功！";
strInfo += "(In SysScoreWeight_Edit.btnSubmit_Click)";
//显示信息框
//console.log(strInfo);
alert(strInfo);
if (returnBool == true)
{
if (SysScoreWeight_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.HideDialog_SysScoreWeight();
}
this.iShowList.BindGv(clsSysScoreWeightEN._CurrTabName, returnBool.toString());
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
$('#txtScoreWeightId').attr('ReadOnly', bolReadonly.toString());
}

/**
 * 清除用户自定义控件中，所有控件的值
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_Clear)
 **/
public Clear()
{
const strThisFuncName = this.Clear.name;
this.scoreWeightId = "";
$('#ddlScoreTypeId option[0]').attr("selected", "true");
this.scoreWeightValue = "";
$('#ddlid_CurrEduCls option[0]').attr("selected", "true");
this.isPublic = false;
this.memo = "";
}

 /** 为插入记录做准备工作
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
 **/
public async AddNewRecord()
{
const strThisFuncName = this.AddNewRecord.name;
this.Clear();
//wucSysScoreWeightB1.scoreWeightId = SysScoreWeight_GetMaxStrId_S();
}

 /** 为插入记录做准备工作
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxId)
 **/
public AddNewRecordWithMaxId()
{
const strThisFuncName = this.AddNewRecordWithMaxId.name;
this.SetKeyReadOnly(false);
this.Clear();
//wucSysScoreWeightB1.scoreWeightId = SysScoreWeight_GetMaxStrId_S();
}

 /** 函数功能:把界面上的属性数据传到类对象中
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
 * @param pobjSysScoreWeightEN">数据传输的目的类对象</param>
 **/
public async PutDataToSysScoreWeightClass(pobjSysScoreWeightEN: clsSysScoreWeightEN)
{
const strThisFuncName = this.PutDataToSysScoreWeightClass.name;
pobjSysScoreWeightEN.SetScoreWeightId(this.scoreWeightId);// 分数权重Id
pobjSysScoreWeightEN.SetScoreTypeId(this.scoreTypeId);// 成绩类型代号
pobjSysScoreWeightEN.SetScoreWeightValue(this.scoreWeightValue);// ScoreWeightValue
pobjSysScoreWeightEN.Setid_CurrEduCls(this.id_CurrEduCls);// 当前教学班流水号
pobjSysScoreWeightEN.SetIsPublic(this.isPublic);// 是否公开
pobjSysScoreWeightEN.SetMemo(this.memo);// 备注
}


 /** 添加新记录，保存函数
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
 **/
public async AddNewRecordSave(): Promise<boolean>{
const strThisFuncName = this.AddNewRecordSave.name;
const objSysScoreWeightEN = new clsSysScoreWeightEN();
try
{
await this.PutDataToSysScoreWeightClass(objSysScoreWeightEN);
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
SysScoreWeight_CheckPropertyNew(objSysScoreWeightEN);
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
const bolIsExist = await SysScoreWeight_IsExistAsync(objSysScoreWeightEN.scoreWeightId);
if (bolIsExist == true)
{
const strMsg = Format("添加记录时，关键字：{0}已经存在！", objSysScoreWeightEN.scoreWeightId);
console.error(strMsg);
alert(strMsg);
return false;//一定要有一个返回值，否则会出错！
}
returnBool = await SysScoreWeight_AddNewRecordAsync(objSysScoreWeightEN);
if (returnBool == true)
{
//SysScoreWeight_ReFreshCache();
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
const objSysScoreWeightEN = new clsSysScoreWeightEN();
try
{
await this.PutDataToSysScoreWeightClass(objSysScoreWeightEN);
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
SysScoreWeight_CheckPropertyNew(objSysScoreWeightEN);
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
const responseKeyId = await SysScoreWeight_AddNewRecordWithMaxIdAsync(objSysScoreWeightEN);
const returnKeyId: string = responseKeyId;
if (IsNullOrEmpty(returnKeyId) == false)
{
//SysScoreWeight_ReFreshCache();
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
 * @param strScoreWeightId: 表记录的关键字,显示该表关键字的内容
 **/
  public async ShowData(strScoreWeightId: string) {
const strThisFuncName = this.ShowData.name;
        //操作步骤:
        //1、检查关键字是否为空；
        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
        //3、用提供的关键字初始化一个类对象；
        //4、获取类对象的所有属性；
        //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
        let objSysScoreWeightEN = new clsSysScoreWeightEN();
        try {
            const returnBool = await SysScoreWeight_IsExistAsync(strScoreWeightId);
            if (returnBool == false) {
                const strInfo = Format("关键字:[{0}] 的记录不存在!", strScoreWeightId);
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
const objSysScoreWeightEN_Const = await SysScoreWeight_GetObjByScoreWeightIdAsync(strScoreWeightId);
       if (objSysScoreWeightEN_Const == null)
        {
            const strMsg = Format("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
console.error(strMsg);
            alert(strMsg);
            return;
        }
         objSysScoreWeightEN = objSysScoreWeightEN_Const; 
        }
        catch (e) {
            const strMsg = Format("根据关键字获取相应的记录的对象不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
console.error(strMsg);
            alert(strMsg);
        }
        //3、用提供的关键字初始化一个类对象；
        this.GetDataFromSysScoreWeightClass(objSysScoreWeightEN);
}

 /** 函数功能:把类对象的属性内容显示到界面上
 * 注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
 * 如果在设置数据库时,就应该一级字段在前,二级字段在后
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
 * @param pobjSysScoreWeightEN">表实体类对象</param>
 **/
public GetDataFromSysScoreWeightClass(pobjSysScoreWeightEN: clsSysScoreWeightEN )
{
const strThisFuncName = this.GetDataFromSysScoreWeightClass.name;
 this.scoreWeightId = pobjSysScoreWeightEN.scoreWeightId;// 分数权重Id
 this.scoreTypeId = pobjSysScoreWeightEN.scoreTypeId;// 成绩类型代号
 this.scoreWeightValue = pobjSysScoreWeightEN.scoreWeightValue;// ScoreWeightValue
 this.id_CurrEduCls = pobjSysScoreWeightEN.id_CurrEduCls;// 当前教学班流水号
this.isPublic = pobjSysScoreWeightEN.isPublic;// 是否公开
 this.memo = pobjSysScoreWeightEN.memo;// 备注
}

 /** 根据关键字获取相应的记录的对象
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
 * @param sender">参数列表</param>
 **/
public async UpdateRecord(strScoreWeightId: string):Promise<boolean> 
{
const strThisFuncName = this.UpdateRecord.name;
this.keyId = strScoreWeightId;
try
{
const objSysScoreWeightEN_Const = await SysScoreWeight_GetObjByScoreWeightIdAsync(strScoreWeightId);
       if (objSysScoreWeightEN_Const == null)
        {
            const strMsg = Format("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
console.error(strMsg);
            alert(strMsg);
            return false;
        }
this.objSysScoreWeight = objSysScoreWeightEN_Const;
const conGetDataFromClass = await   this.GetDataFromSysScoreWeightClass(objSysScoreWeightEN_Const);
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
const objSysScoreWeightEN = new clsSysScoreWeightEN();
objSysScoreWeightEN.scoreWeightId = this.keyId;
await this.PutDataToSysScoreWeightClass(objSysScoreWeightEN);
objSysScoreWeightEN.sfUpdFldSetStr = objSysScoreWeightEN.updFldString;//设置哪些字段被修改(脏字段)
if (objSysScoreWeightEN.scoreWeightId == "" || objSysScoreWeightEN.scoreWeightId == undefined){
console.error("关键字不能为空!");
 throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
}
try
{
SysScoreWeight_CheckProperty4Update(objSysScoreWeightEN);
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
const returnBool = await SysScoreWeight_UpdateRecordAsync(objSysScoreWeightEN);
if (returnBool == true)
{
//SysScoreWeight_ReFreshCache();
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
public  set btnCancel_SysScoreWeight(value: string) {
 SetButtonHtmlByIdInDiv(this.divName4Edit, "btnCancel_SysScoreWeight", value);
}
 /**
 * 获取按钮的标题
 **/
public  get btnSubmit_SysScoreWeight():string {
const strValue = GetButtonHtmlInDiv(this.divName4Edit, "btnSubmit_SysScoreWeight");
return strValue;
}
 /**
 * 设置确定按钮的标题(Used In AddNewRecord())
 **/
public  set btnSubmit_SysScoreWeight(value: string) {
 SetButtonHtmlByIdInDiv(this.divName4Edit, "btnSubmit_SysScoreWeight", value);
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
 * 是否公开 (Used In Clear())
 **/
public  set isPublic(value: boolean) {
 SetCheckBoxValueByIdInDiv(this.divName4Edit, "chkIsPublic", value);
}
 /**
 * 是否公开 (Used In PutDataToClass())
 **/
public  get isPublic():boolean {
const bolValue = GetCheckBoxValueInDiv(this.divName4Edit, "chkIsPublic");
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
 * 分数类型Id (Used In Clear())
 **/
public  set scoreTypeId(value: string) {
SetSelectValueByIdInDiv(this.divName4Edit, "ddlScoreTypeId", value);
}
 /**
 * 分数类型Id (Used In PutDataToClass())
 **/
public  get scoreTypeId():string {
const strValue = GetSelectValueInDiv(this.divName4Edit, "ddlScoreTypeId");
if (strValue == undefined) return "";
else if (strValue == "0") return "";
else return strValue;
}
 /**
 * 分数权重Id (Used In Clear())
 **/
public  set scoreWeightId(value: string) {
 SetInputValueByIdInDiv(this.divName4Edit, "txtScoreWeightId", value);
}
 /**
 * 分数权重Id (Used In PutDataToClass())
 **/
public  get scoreWeightId():string {
const strValue = GetInputValueInDiv(this.divName4Edit, "txtScoreWeightId");
if (strValue == undefined) return "";
else return strValue.toString();
}
 /**
 * 分数权重值 (Used In Clear())
 **/
public  set scoreWeightValue(value: string) {
 SetInputValueByIdInDiv(this.divName4Edit, "txtScoreWeightValue", value);
}
 /**
 * 分数权重值 (Used In PutDataToClass())
 **/
public  get scoreWeightValue():string {
const strValue = GetInputValueInDiv(this.divName4Edit, "txtScoreWeightValue");
if (strValue == undefined) return "";
else return strValue.toString();
}
}