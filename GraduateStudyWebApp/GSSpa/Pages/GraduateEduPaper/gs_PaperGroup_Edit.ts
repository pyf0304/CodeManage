
 /**
 * 类名:gs_PaperGroup_Edit(界面:gs_PaperGroupCRUD)
 * 表名:gs_PaperGroup(01120749)
 * 生成代码版本:2021.10.18.1
 * 生成日期:2021/10/21 12:35:25
 * 生成者:
 * 工程名称:问卷调查
 * 工程ID:0112
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 * 模块中文名:研培论文
 * 模块英文名:GraduateEduPaper
 * 框架-层名:WA_编辑区后台_TS(WA_ViewScript_EditCS_TS)
 * 编程语言:TypeScript
 **/
// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
// <reference path="../../scripts/typings/q/q.d.ts" />
// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
//import * as $ from "jquery";
//import * as QQ from "q";
import { clsgs_PaperGroupEN } from "../TS/L0_Entity/GraduateEduPaper/clsgs_PaperGroupEN.js";
import { enumPageDispMode } from "../TS/L0_Entity/PrjMenu/clsPageDispModeEN.js";
import { gs_PaperGroup_AddNewRecordAsync, gs_PaperGroup_AddNewRecordWithMaxIdAsync, gs_PaperGroup_CheckProperty4Update, gs_PaperGroup_CheckPropertyNew, gs_PaperGroup_GetMaxStrIdAsync, gs_PaperGroup_GetObjByPaperGroupIdAsync, gs_PaperGroup_IsExistAsync, gs_PaperGroup_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperGroupWApi.js";
import { clsCommonFunc4Web } from "../TS/PubFun/clsCommonFunc4Web2.js";
import { clsDateTime } from "../TS/PubFun/clsDateTime.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { Format, IsNullOrEmpty } from "../TS/PubFun/clsString.js";
/**
* 宣布一个已经在存在的函数ShowDialog，用于显示对象框，
* @param  strOpType：是操作类型，是三种类型之一：Add, Update, Detail
 **/
declare function ShowDialog(strDialogName): void;
/**
* 宣布一个已经在存在的函数HideDialog，用于隐藏对象框，
 **/
declare function HideDialog(strDialogName): void;
declare var $;
 /** gs_PaperGroup_Edit 的摘要说明。其中Q代表查询,U代表修改
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:GeneCode)
 **/
export abstract class gs_PaperGroup_Edit 
{
public static strPageDispModeId = "01";//PopupBox(弹出框)
public static objPage_Edit: gs_PaperGroup_Edit;
public static strUpdUser_Cache = "99999999999999999991";
public objgs_PaperGroup: clsgs_PaperGroupEN;
protected iShowList: IShowList;
public bolIsLoadEditRegion = false;  //记录是否导入编辑区的变量
public divName4Edit = "divEdit";  //编辑区的Id
constructor(objShowList: IShowList) {
this.iShowList = objShowList;
gs_PaperGroup_Edit.objPage_Edit = this;
this.objgs_PaperGroup = new clsgs_PaperGroupEN();
}


 /**
 * 在当前界面中，导入编辑区域
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddDPV_Edit)
 * @returns 
 **/
public async AddDPV_Edit(divName4Edit) {
const strThisFuncName = this.AddDPV_Edit.name;
clsCommonFunc4Web.CheckDivExist(divName4Edit);
const strUrl = "./gs_PaperGroup_Edit";
console.log("divName4Edit:(In AddDPV_Edit)" + divName4Edit);
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
error: (e) => {
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
const strMsg = clsString.Format("页面启动不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
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
const strMsg = clsString.Format("页面启动不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
}





 /**
 * 显示对话框
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_TS_ShowDialog)
 **/
public ShowDialog_gs_PaperGroup(strOp:string) {
const strThisFuncName = this.ShowDialog_gs_PaperGroup.name;
console.log('strThisFuncName', strThisFuncName);
//检查相关控件是否存在
clsCommonFunc4Web.CheckControlExist(this.divName4Edit, "div", "divEditDialog_gs_PaperGroup");
clsCommonFunc4Web.CheckControlExist(this.divName4Edit, "h4", "lblDialogTitle_gs_PaperGroup");
       if (strOp === "Add") {
           $('#lblDialogTitle_gs_PaperGroup').html('添加记录');
//gs_PaperGroup_EditEx.GetMaxStrId('#txtPaperGroupId');
        }
else if (strOp === "Update")
{
            $('#lblDialogTitle_gs_PaperGroup').html('修改记录');
}
else if (strOp === "Detail")
{
            $('#btnSubmit_gs_PaperGroup').hide();
            $('#lblDialogTitle_gs_PaperGroup').html('详细信息');
}
        ShowDialog('#divEditDialog_gs_PaperGroup');
}

 /**
 * 隐藏对话框
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_TS_HideDialog)
 **/
public HideDialog_gs_PaperGroup() {
const strThisFuncName = this.HideDialog_gs_PaperGroup.name;
clsCommonFunc4Web.CheckControlExist(this.divName4Edit, "div", "divEditDialog_gs_PaperGroup");
      HideDialog('#divEditDialog_gs_PaperGroup');
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
this.OpType = "Add";
 // 为编辑区绑定下拉框
const conBindDdl = await this.BindDdl4EditRegionInDiv();
this.SetEventFunc();
this.bolIsLoadEditRegion = true;  //
const responseText = this.AddNewRecord();
if (gs_PaperGroup_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.ShowDialog_gs_PaperGroup('Add');
}
}
else
{
this.OpType = "Add";
const responseText = await this.AddNewRecord();
if (gs_PaperGroup_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.ShowDialog_gs_PaperGroup('Add');
}
}
}
catch(e)
{
const strMsg = clsString.Format("添加新记录初始化不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
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
this.OpType = "AddWithMaxId";
 // 为编辑区绑定下拉框
const conBindDdl = await this.BindDdl4EditRegionInDiv();
this.SetEventFunc();
this.bolIsLoadEditRegion = true;  //
const responseText = this.AddNewRecordWithMaxId();
if (gs_PaperGroup_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.ShowDialog_gs_PaperGroup('Add');
}
}
else
{
this.OpType = "AddWithMaxId";
const responseText = this.AddNewRecordWithMaxId();
if (gs_PaperGroup_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.ShowDialog_gs_PaperGroup('Add');
}
}
}
catch(e)
{
const strMsg = clsString.Format("添加新记录初始化不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
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
this.OpType = "Update";
 // 为编辑区绑定下拉框
const conBindDdl = await this.BindDdl4EditRegionInDiv();
this.SetEventFunc();
this.bolIsLoadEditRegion = true;  //
this.UpdateRecord(strKeyId);
if (gs_PaperGroup_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.ShowDialog_gs_PaperGroup('Update');
}
}
else
{
this.OpType = "Update";
this.UpdateRecord(strKeyId);
if (gs_PaperGroup_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.ShowDialog_gs_PaperGroup('Update');
}
}
}
catch (e)
{
const strMsg = clsString.Format("(errid: WiTsCs0034)在修改记录时出错!请联系管理员!{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
}

 /** 修改记录
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecord_Click)
 **/
public async btnUpdateRecord_Click(strKeyId: string) {
const strThisFuncName = this.btnUpdateRecord_Click.name;
if (clsString.IsNullOrEmpty(strKeyId) == true)
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
this.OpType = "Update";
 // 为编辑区绑定下拉框
const conBindDdl = await this.BindDdl4EditRegionInDiv();
this.SetEventFunc();
this.bolIsLoadEditRegion = true;  //
const update = await this.UpdateRecord(strKeyId);
if (update == false)
{
const strMsg = clsString.Format("在修改记录时,显示记录数据不成功!");
console.error(strMsg);
alert(strMsg);
return;
}
if (gs_PaperGroup_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.ShowDialog_gs_PaperGroup('Update');
}
}
else
{
this.OpType = "Update";
const update = await this.UpdateRecord(strKeyId);
if (update == false)
{
const strMsg = clsString.Format("在修改记录时,显示记录数据不成功!");
console.error(strMsg);
alert(strMsg);
return;
}
if (gs_PaperGroup_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.ShowDialog_gs_PaperGroup('Update');
}
}
}
catch (e)
{
const strMsg = clsString.Format("(errid: WiTsCs0034)在修改记录时出错!请联系管理员!{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
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
const strCommandText: string = this.btnSubmit_gs_PaperGroup;
try {
switch(strCommandText)
{
case "添加":
const responseText1 = await this.AddNewRecord();
break;				
case "确认添加":
//这是一个单表的插入的代码,由于逻辑层太简单,
//就把逻辑层合并到控制层,
if (this.OpType == "AddWithMaxId")
{
const returnKeyId = await this.AddNewRecordWithMaxIdSave();
if (clsString.IsNullOrEmpty(returnKeyId) == false)
{
if (gs_PaperGroup_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.HideDialog_gs_PaperGroup();
}
this.iShowList.BindGv(clsgs_PaperGroupEN._CurrTabName, "");
}
}
else
{
const returnBool = await this.AddNewRecordSave();
if (returnBool == true)
{
if (gs_PaperGroup_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.HideDialog_gs_PaperGroup();
}
this.iShowList.BindGv(clsgs_PaperGroupEN._CurrTabName, "");
}
}
break;
case "确认修改":
//这是一个单表的修改的代码,由于逻辑层太简单,
const returnBool = await this.UpdateRecordSave();
let strInfo: string = returnBool ? "修改成功！" : "修改不成功！";
strInfo += "(In gs_PaperGroup_Edit.btnSubmit_Click)";
//显示信息框
console.log(strInfo);
alert(strInfo);
if (returnBool == true)
{
if (gs_PaperGroup_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.HideDialog_gs_PaperGroup();
}
this.iShowList.BindGv(clsgs_PaperGroupEN._CurrTabName, "");
}
break;
default:
const strMsg = clsString.Format("strCommandText:{0}在switch中没有处理！(In btnSubmit_Click())", strCommandText);
console.error(strMsg);
alert(strMsg);
break;
}
}
catch (e)
{
const strMsg = clsString.Format("(errid: WiTsCs0033)在保存记录时(${ strCommandText})时出错!请联系管理员!{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
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
console.log('strThisFuncName', strThisFuncName);
$('#txtPaperGroupId').prop['ReadOnly'] = bolReadonly;
}

/**
 * 清除用户自定义控件中，所有控件的值
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_Clear)
 **/
public Clear()
{
const strThisFuncName = this.Clear.name;
console.log('strThisFuncName', strThisFuncName);
this.paperGroupId = "";
this.paperGroupName = "";
this.orderNum = 0;
this.meno = "";
}

 /** 为插入记录做准备工作
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
 **/
public async AddNewRecord()
{
const strThisFuncName = this.AddNewRecord.name;
console.log('strThisFuncName', strThisFuncName);
this.btnSubmit_gs_PaperGroup = "确认添加";
this.btnCancel_gs_PaperGroup = "取消添加";
this.Clear();
//wucgs_PaperGroupB1.paperGroupId = clsgs_PaperGroupBL.GetMaxStrId_S();
try
{
const responseText = await gs_PaperGroup_GetMaxStrIdAsync();
const returnString: string = responseText;
if (returnString == "")
{
const strInfo = clsString.Format("获取表gs_PaperGroup的最大关键字为空，不成功，请检查!");
//显示信息框
alert(strInfo);
}
else
{
$('#txtPaperGroupId').val(returnString);
}
}
catch(e)
{
const strMsg = clsString.Format("获取表关键字的最大值不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
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
console.log('strThisFuncName', strThisFuncName);
this.btnSubmit_gs_PaperGroup = "确认添加";
this.btnCancel_gs_PaperGroup = "取消添加";
this.Clear();
//wucgs_PaperGroupB1.paperGroupId = clsgs_PaperGroupBL.GetMaxStrId_S();
}

 /** 函数功能:把界面上的属性数据传到类对象中
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
 * @param pobjgs_PaperGroupEN">数据传输的目的类对象</param>
 **/
public async PutDataTogs_PaperGroupClass(pobjgs_PaperGroupEN: clsgs_PaperGroupEN)
{
const strThisFuncName = this.PutDataTogs_PaperGroupClass.name;
console.log('strThisFuncName', strThisFuncName);
pobjgs_PaperGroupEN.paperGroupId = this.paperGroupId;// 组Id
pobjgs_PaperGroupEN.paperGroupName = this.paperGroupName;// 组名
pobjgs_PaperGroupEN.updUser = clsPubSessionStorage.userId;// 修改人
pobjgs_PaperGroupEN.orderNum = this.orderNum;// 序号
pobjgs_PaperGroupEN.updDate = clsDateTime.getTodayDateTimeStr(1);// 修改日期
pobjgs_PaperGroupEN.meno = this.meno;// 备注
}


 /** 添加新记录，保存函数
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
 **/
public async AddNewRecordSave(): Promise<boolean>{
const strThisFuncName = this.AddNewRecordSave.name;
this.DivName = "divAddNewRecordSave";
var objgs_PaperGroupEN = new clsgs_PaperGroupEN();
try
{
await this.PutDataTogs_PaperGroupClass(objgs_PaperGroupEN);
}
catch(e)
{
const strMsg = clsString.Format("从界面获取数据不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return false;//一定要有一个返回值，否则会出错！
}
try
{
gs_PaperGroup_CheckPropertyNew(objgs_PaperGroupEN);
}
catch(e)
{
const strMsg = clsString.Format("检查数据不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return false;//一定要有一个返回值，否则会出错！
}
try
{
const responseText = await gs_PaperGroup_IsExistAsync(objgs_PaperGroupEN.paperGroupId);
const bolIsExist: boolean = responseText;
if (bolIsExist == true)
{
const strMsg = clsString.Format("添加记录时，关键字：{0}已经存在！", objgs_PaperGroupEN.paperGroupId);
console.error(strMsg);
alert(strMsg);
return responseText;//一定要有一个返回值，否则会出错！
}
const returnBool = await gs_PaperGroup_AddNewRecordAsync(objgs_PaperGroupEN);
if (returnBool == true)
{
//gs_PaperGroup_ReFreshCache(gs_PaperGroup_Edit.strUpdUser_Cache);
const strInfo = clsString.Format("添加记录成功!");
$('#lblResult46').val(strInfo);
//显示信息框
alert(strInfo);
}
else
{
const strInfo = clsString.Format("添加记录不成功!");
$('#lblResult46').val(strInfo);
//显示信息框
alert(strInfo);
}
return returnBool;//一定要有一                           个返回值，否则会出错！
}
catch(e)
{
const strMsg = clsString.Format("添加记录不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
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
this.DivName = "divAddNewRecordWithMaxIdSave";
var objgs_PaperGroupEN = new clsgs_PaperGroupEN();
try
{
await this.PutDataTogs_PaperGroupClass(objgs_PaperGroupEN);
}
catch(e)
{
const strMsg = clsString.Format("从界面获取数据不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
console.error(strMsg);
alert(strMsg);
throw(strMsg);//一定要有一个返回值，否则会出错！
}
try
{
gs_PaperGroup_CheckPropertyNew(objgs_PaperGroupEN);
}
catch(e)
{
const strMsg = clsString.Format("检查数据不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
console.error(strMsg);
alert(strMsg);
throw(strMsg);//一定要有一个返回值，否则会出错！
}
try
{
const responseKeyId = await gs_PaperGroup_AddNewRecordWithMaxIdAsync(objgs_PaperGroupEN);
const returnKeyId: string = responseKeyId;
if (clsString.IsNullOrEmpty(returnKeyId) == false)
{
//gs_PaperGroup_ReFreshCache(gs_PaperGroup_Edit.strUpdUser_Cache);
const strInfo = clsString.Format("添加记录成功!");
$('#lblResult47').val(strInfo);
//显示信息框
alert(strInfo);
}
else
{
const strInfo = clsString.Format("添加记录不成功!");
$('#lblResult47').val(strInfo);
//显示信息框
alert(strInfo);
}
return responseKeyId;//一定要有一个返回值，否则会出错！
}
catch(e)
{
const strMsg = clsString.Format("添加记录不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
console.error(strMsg);
alert(strMsg);
throw(strMsg);
}
return "";//一定要有一个返回值，否则会出错！
}

 /** 函数功能:把以该关键字的记录内容显示在界面上,
 　　* 　   在这里是把值传到表控件中
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_ShowData)
 * @param strPaperGroupId">表记录的关键字,显示该表关键字的内容</param>
 **/
  public async ShowData(strPaperGroupId: string) {
const strThisFuncName = this.ShowData.name;
        //操作步骤:
        //1、检查关键字是否为空；
        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
        //3、用提供的关键字初始化一个类对象；
        //4、获取类对象的所有属性；
        //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
        let objgs_PaperGroupEN = new clsgs_PaperGroupEN();
        try {
            const responseText = await gs_PaperGroup_IsExistAsync(strPaperGroupId);
            const returnBool: boolean = responseText;
            if (returnBool == false) {
                const strInfo = clsString.Format("关键字:[{0}] 的记录不存在!", strPaperGroupId);
                //$('#lblResult1').val(strInfo);
                //显示信息框
                alert(strInfo);
            }
            else {
            }
        }
        catch (e) {
            const strMsg = clsString.Format("检查相应关键字的记录存在不成功, {0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
console.error(strMsg);
            alert(strMsg);
        }
        try {
objgs_PaperGroupEN = await gs_PaperGroup_GetObjByPaperGroupIdAsync(strPaperGroupId);
        }
        catch (e) {
            const strMsg = clsString.Format("根据关键字获取相应的记录的对象不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
console.error(strMsg);
            alert(strMsg);
        }
        //3、用提供的关键字初始化一个类对象；
        this.GetDataFromgs_PaperGroupClass(objgs_PaperGroupEN);
}

 /** 函数功能:把类对象的属性内容显示到界面上
 * 注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
 * 如果在设置数据库时,就应该一级字段在前,二级字段在后
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
 * @param pobjgs_PaperGroupEN">表实体类对象</param>
 **/
public GetDataFromgs_PaperGroupClass(pobjgs_PaperGroupEN: clsgs_PaperGroupEN )
{
const strThisFuncName = this.GetDataFromgs_PaperGroupClass.name;
console.log('strThisFuncName', strThisFuncName);
 this.paperGroupId = pobjgs_PaperGroupEN.paperGroupId;// 组Id
 this.paperGroupName = pobjgs_PaperGroupEN.paperGroupName;// 组名
 this.orderNum = pobjgs_PaperGroupEN.orderNum;// 序号
 this.meno = pobjgs_PaperGroupEN.meno;// 备注
}

 /** 根据关键字获取相应的记录的对象
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
 * @param sender">参数列表</param>
 **/
public async UpdateRecord(strPaperGroupId: string):Promise<boolean> 
{
const strThisFuncName = this.UpdateRecord.name;
this.btnSubmit_gs_PaperGroup = "确认修改";
this.btnCancel_gs_PaperGroup = "取消修改";
this.KeyId = strPaperGroupId;
try
{
const responseText = await gs_PaperGroup_GetObjByPaperGroupIdAsync(strPaperGroupId);
const objgs_PaperGroupEN: clsgs_PaperGroupEN = <clsgs_PaperGroupEN>responseText;
this.objgs_PaperGroup = objgs_PaperGroupEN;
const conGetDataFromClass = await   this.GetDataFromgs_PaperGroupClass(objgs_PaperGroupEN);
console.log("完成UpdateRecord!");
return true;
}
catch(e)
{
const strMsg = clsString.Format("根据关键字获取相应的记录的对象不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
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
this.DivName = "divUpdateRecordSave";
var objgs_PaperGroupEN = new clsgs_PaperGroupEN();
objgs_PaperGroupEN.paperGroupId = this.KeyId;
await this.PutDataTogs_PaperGroupClass(objgs_PaperGroupEN);
objgs_PaperGroupEN.sf_UpdFldSetStr = objgs_PaperGroupEN.updFldString;//设置哪些字段被修改(脏字段)
if (objgs_PaperGroupEN.paperGroupId == "" || objgs_PaperGroupEN.paperGroupId == undefined){
console.error("关键字不能为空!");
throw "关键字不能为空!";
}
try
{
gs_PaperGroup_CheckProperty4Update(objgs_PaperGroupEN);
}
catch(e)
{
const strMsg = clsString.Format("检查数据不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return false;//一定要有一个返回值，否则会出错！
}
try
{
const responseText = await gs_PaperGroup_UpdateRecordAsync(objgs_PaperGroupEN);
const returnBool: boolean = !!responseText;
if (returnBool == true)
{
//gs_PaperGroup_ReFreshCache(gs_PaperGroup_Edit.strUpdUser_Cache);
}
return returnBool;
}
catch(e)
{
const strMsg = clsString.Format("修改记录不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return false;
}
}
 /**
 * 设置取消按钮的标题(Used In AddNewRecord())
 **/
public  set btnCancel_gs_PaperGroup(value: string) {
$("#btnCancel_gs_PaperGroup").html(value);
}
 /**
 * 获取按钮的标题
 **/
public  get btnSubmit_gs_PaperGroup():string {
return $("#btnSubmit_gs_PaperGroup").html();
}
 /**
 * 设置确定按钮的标题(Used In AddNewRecord())
 **/
public  set btnSubmit_gs_PaperGroup(value: string) {
$("#btnSubmit_gs_PaperGroup").html(value);
}
 /**
 * 添加、修改用的层名
 **/
public  set DivName(value: string) {
$("#hidDivName").val(value);
}
 /**
 * 设置排序字段-相当使用ViewState功能
 **/
public  set hidSortgs_PaperGroupBy(value: string) {
$("#hidSortgs_PaperGroupBy").val(value);
}
 /**
 * 设置排序字段
 **/
public  get hidSortgs_PaperGroupBy():string {
return $("#hidSortgs_PaperGroupBy").val();
}
 /**
 * 设置关键字的值(Used In UpdateRecord())
 **/
public  set KeyId(value: string) {
$("#hidKeyId").val(value);
}
 /**
 * 设置关键字的值
 **/
public  get KeyId():string {
return $("#hidKeyId").val();
}
 /**
 * 备注 (Used In Clear())
 **/
public  set meno(value: string) {
const objDiv = $(`#${ this.divName4Edit }`);
    clsCommonFunc4Web.CheckControlExist(this.divName4Edit, "input", "txtMeno");
const strId = clsString.Format("input[id ^= 'txtMeno']");
 objDiv.find(strId).val(value);
}
 /**
 * 备注 (Used In PutDataToClass())
 **/
public  get meno():string {
const objDiv = $(`#${ this.divName4Edit }`);
    clsCommonFunc4Web.CheckControlExist(this.divName4Edit, "input", "txtMeno");
const strId = clsString.Format("input[id ^= 'txtMeno']");
const objElem = objDiv.find(strId);
if (objElem == undefined) return "";
else
{
const strValue = objElem.val();
if (strValue == undefined) return "";
else return strValue.toString();
}
}
 /**
 * 设置操作类型：Add||Update||Detail
 **/
public  set OpType(value: string) {
const objDiv = $(`#${ this.divName4Edit }`);
    clsCommonFunc4Web.CheckControlExist(this.divName4Edit, "input", "hidOpType");
const strId = clsString.Format("input[id ^= 'hidOpType']");
 objDiv.find(strId).val(value);
}
 /**
 * 设置操作类型：Add||Update||Detail
 **/
public  get OpType():string {
const objDiv = $(`#${ this.divName4Edit }`);
    clsCommonFunc4Web.CheckControlExist(this.divName4Edit, "input", "hidOpType");
const strId = clsString.Format("input[id ^= 'hidOpType']");
const objElem = objDiv.find(strId);
if (objElem == undefined) return "";
else
{
const strValue = objElem.val();
if (strValue == undefined) return "";
else return strValue.toString();
}
}
 /**
 * 序号 (Used In Clear())
 **/
public  set orderNum(value: number) {
const objDiv = $(`#${ this.divName4Edit }`);
    clsCommonFunc4Web.CheckControlExist(this.divName4Edit, "input", "txtOrderNum");
const strId = clsString.Format("input[id ^= 'txtOrderNum']");
 objDiv.find(strId).val(value);
}
 /**
 * 序号 (Used In PutDataToClass())
 **/
public  get orderNum():number {
const objDiv = $(`#${ this.divName4Edit }`);
    clsCommonFunc4Web.CheckControlExist(this.divName4Edit, "input", "txtOrderNum");
const strId = clsString.Format("input[id ^= 'txtOrderNum']");
const objElem = objDiv.find(strId);
if (objElem == undefined) return 0;
else
{
const strValue = objElem.val();
if (strValue == undefined) return 0;
else return Number(strValue.toString());
}
}
 /**
 * 组Id (Used In Clear())
 **/
public  set paperGroupId(value: string) {
const objDiv = $(`#${ this.divName4Edit }`);
    clsCommonFunc4Web.CheckControlExist(this.divName4Edit, "input", "txtPaperGroupId");
const strId = clsString.Format("input[id ^= 'txtPaperGroupId']");
 objDiv.find(strId).val(value);
}
 /**
 * 组Id (Used In PutDataToClass())
 **/
public  get paperGroupId():string {
const objDiv = $(`#${ this.divName4Edit }`);
    clsCommonFunc4Web.CheckControlExist(this.divName4Edit, "input", "txtPaperGroupId");
const strId = clsString.Format("input[id ^= 'txtPaperGroupId']");
const objElem = objDiv.find(strId);
if (objElem == undefined) return "";
else
{
const strValue = objElem.val();
if (strValue == undefined) return "";
else return strValue.toString();
}
}
 /**
 * 组名 (Used In Clear())
 **/
public  set paperGroupName(value: string) {
const objDiv = $(`#${ this.divName4Edit }`);
    clsCommonFunc4Web.CheckControlExist(this.divName4Edit, "input", "txtPaperGroupName");
const strId = clsString.Format("input[id ^= 'txtPaperGroupName']");
 objDiv.find(strId).val(value);
}
 /**
 * 组名 (Used In PutDataToClass())
 **/
public  get paperGroupName():string {
const objDiv = $(`#${ this.divName4Edit }`);
    clsCommonFunc4Web.CheckControlExist(this.divName4Edit, "input", "txtPaperGroupName");
const strId = clsString.Format("input[id ^= 'txtPaperGroupName']");
const objElem = objDiv.find(strId);
if (objElem == undefined) return "";
else
{
const strValue = objElem.val();
if (strValue == undefined) return "";
else return strValue.toString();
}
}
 /**
 * 修改日期 (Used In PutDataToClass())
 **/
public  get updDate():string {
const objDiv = $(`#${ this.divName4Edit }`);
    clsCommonFunc4Web.CheckControlExist(this.divName4Edit, "input", "txtUpdDate");
const strId = clsString.Format("input[id ^= 'txtUpdDate']");
const objElem = objDiv.find(strId);
if (objElem == undefined) return "";
else
{
const strValue = objElem.val();
if (strValue == undefined) return "";
else return strValue.toString();
}
}
 /**
 * 修改人 (Used In PutDataToClass())
 **/
public  get updUser():string {
const objDiv = $(`#${ this.divName4Edit }`);
    clsCommonFunc4Web.CheckControlExist(this.divName4Edit, "input", "txtUpdUser");
const strId = clsString.Format("input[id ^= 'txtUpdUser']");
const objElem = objDiv.find(strId);
if (objElem == undefined) return "";
else
{
const strValue = objElem.val();
if (strValue == undefined) return "";
else return strValue.toString();
}
}
}