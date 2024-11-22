
 /**
 * 类名:gs_PaperVer_Edit(界面:gs_PaperVerCRUD)
 * 表名:gs_PaperVer(01120678)
 * 版本:2023.01.12.1(服务器:WIN-SRV103-116)
 * 日期:2023/01/12 16:38:15
 * 生成者:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 * 模块中文名:研培论文(GraduateEduPaper)
 * 框架-层名:WA_编辑区后台_TS(TS)(WA_ViewScript_EditCS_TS)
 * 编程语言:TypeScript
 **/
//import $ from "jquery";
import { vPaperSimProEx_BindDdl_PaperIdByid_CurrEduClsInDiv_Cache } from "../../TS/L3_ForWApiEx/GraduateEduPaper/clsvPaperSimProExWApi.js";
import { CurrEduCls_BindDdl_id_CurrEduClsInDiv_Cache } from "../../TS/L3_ForWApi/DailyRunning_Share/clsCurrEduClsWApi.js";
import { gs_PaperVer_CheckPropertyNew } from "../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperVerWApi.js";
import { gs_PaperVer_AddNewRecordAsync } from "../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperVerWApi.js";
import { gs_PaperVer_GetUniCondStr_PaperVId } from "../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperVerWApi.js";
import { gs_PaperVer_IsExistRecordAsync } from "../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperVerWApi.js";
import { gs_PaperVer_GetUniCondStr4Update_PaperVId } from "../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperVerWApi.js";
import { gs_PaperVer_IsExistAsync } from "../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperVerWApi.js";
import { gs_PaperVer_GetObjByPaperVIdAsync } from "../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperVerWApi.js";
import { gs_PaperVer_CheckProperty4Update } from "../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperVerWApi.js";
import { gs_PaperVer_UpdateRecordAsync } from "../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperVerWApi.js";
import { clsgs_PaperVerEN } from "../../TS/L0_Entity/GraduateEduPaper/clsgs_PaperVerEN.js";
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
 /** gs_PaperVer_Edit 的摘要说明。其中Q代表查询,U代表修改
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:GeneCode)
 **/
export abstract class gs_PaperVer_Edit 
{
public opType = "";
public keyId = "";

public static id_CurrEduCls_Static = "";//定义下拉框条件变量1
public static CourseId_Static = "";//定义下拉框条件变量1
public static strPageDispModeId = "01";//PopupBox(弹出框)
public static objPage_Edit: gs_PaperVer_Edit;
public objgs_PaperVer: clsgs_PaperVerEN;
protected iShowList: IShowList;
public bolIsLoadEditRegion = false;  //记录是否导入编辑区的变量
public divName4Edit = "divEdit";  //编辑区的Id
constructor(objShowList: IShowList) {
this.iShowList = objShowList;
gs_PaperVer_Edit.objPage_Edit = this;
this.objgs_PaperVer = new clsgs_PaperVerEN();
}


 /**
 * 在当前界面中，导入编辑区域
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddDPV_Edit)
 * @returns 
 **/
public async AddDPV_Edit(divName4Edit:string) {
const strThisFuncName = this.AddDPV_Edit.name;
CheckDivExist(divName4Edit);
const strUrl = "../GraduateEduPaper/gs_PaperVer_Edit";
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
public ShowDialog_gs_PaperVer(strOp:string) {
const strThisFuncName = this.ShowDialog_gs_PaperVer.name;
//检查相关控件是否存在
CheckControlExist(this.divName4Edit, "div", "divEditDialog_gs_PaperVer");
CheckControlExist(this.divName4Edit, "h4", "lblDialogTitle_gs_PaperVer");
       if (strOp === "Add" || strOp === "AddWithMaxId") {
           $('#lblDialogTitle_gs_PaperVer').html('添加记录');
//gs_PaperVer_EditEx.GetMaxStrId('#txtPaperVId');
        }
else if (strOp === "Update")
{
            $('#lblDialogTitle_gs_PaperVer').html('修改记录');
}
else if (strOp === "Detail")
{
            $('#btnSubmit_gs_PaperVer').hide();
            $('#lblDialogTitle_gs_PaperVer').html('详细信息');
}
        ShowDialog('#divEditDialog_gs_PaperVer');
}

 /**
 * 隐藏对话框
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_TS_HideDialog)
 **/
public HideDialog_gs_PaperVer() {
const strThisFuncName = this.HideDialog_gs_PaperVer.name;
CheckControlExist(this.divName4Edit, "div", "divEditDialog_gs_PaperVer");
      HideDialog('#divEditDialog_gs_PaperVer');
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
this.btnSubmit_gs_PaperVer = "确认添加";
this.btnCancel_gs_PaperVer = "取消添加";
const responseText = this.AddNewRecord();
if (gs_PaperVer_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.ShowDialog_gs_PaperVer('Add');
}
}
else
{
this.opType = "Add";
this.btnSubmit_gs_PaperVer = "确认添加";
this.btnCancel_gs_PaperVer = "取消添加";
const responseText = await this.AddNewRecord();
if (gs_PaperVer_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.ShowDialog_gs_PaperVer('Add');
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
this.btnSubmit_gs_PaperVer = "确认添加";
this.btnCancel_gs_PaperVer = "取消添加";
const responseText = this.AddNewRecordWithMaxId();
if (gs_PaperVer_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.ShowDialog_gs_PaperVer('Add');
}
}
else
{
this.opType = "AddWithMaxId";
this.btnSubmit_gs_PaperVer = "确认添加";
this.btnCancel_gs_PaperVer = "取消添加";
const responseText = this.AddNewRecordWithMaxId();
if (gs_PaperVer_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.ShowDialog_gs_PaperVer('Add');
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
 * 设置绑定下拉框，针对字段:[PaperId]
 * (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdlInDiv_TS4TabFeature)
 **/

public async SetDdl_PaperIdInDiv(Id_CurrEduCls:string)
{
await vPaperSimProEx_BindDdl_PaperIdByid_CurrEduClsInDiv_Cache(this.divName4Edit, "ddlPaperId" , Id_CurrEduCls);//
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
const strid_CurrEduCls = gs_PaperVer_Edit.id_CurrEduCls_Static;
const strCourseId = gs_PaperVer_Edit.CourseId_Static;


await this.SetDdl_PaperIdInDiv(strid_CurrEduCls);//编辑区域

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
this.btnSubmit_gs_PaperVer = "确认修改";
this.btnCancel_gs_PaperVer = "取消修改";
const lngKeyId =  Number(strKeyId);
this.UpdateRecord(lngKeyId);
if (gs_PaperVer_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.ShowDialog_gs_PaperVer('Update');
}
}
else
{
this.opType = "Update";
this.btnSubmit_gs_PaperVer = "确认修改";
this.btnCancel_gs_PaperVer = "取消修改";
const lngKeyId =  Number(strKeyId);
this.UpdateRecord(lngKeyId);
if (gs_PaperVer_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.ShowDialog_gs_PaperVer('Update');
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
this.btnSubmit_gs_PaperVer = "确认修改";
this.btnCancel_gs_PaperVer = "取消修改";
const lngKeyId =  Number(strKeyId);
const update = await this.UpdateRecord(lngKeyId);
if (update == false)
{
const strMsg = Format("在修改记录时,显示记录数据不成功!");
console.error(strMsg);
alert(strMsg);
return;
}
if (gs_PaperVer_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.ShowDialog_gs_PaperVer('Update');
}
}
else
{
this.opType = "Update";
this.btnSubmit_gs_PaperVer = "确认修改";
this.btnCancel_gs_PaperVer = "取消修改";
const lngKeyId =  Number(strKeyId);
const update = await this.UpdateRecord(lngKeyId);
if (update == false)
{
const strMsg = Format("在修改记录时,显示记录数据不成功!");
console.error(strMsg);
alert(strMsg);
return;
}
if (gs_PaperVer_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.ShowDialog_gs_PaperVer('Update');
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
const strCommandText: string = this.btnSubmit_gs_PaperVer;
try {
let returnBool = false;
const returnKeyId = 0;
let strInfo = "";
let strMsg = "";
switch(strCommandText)
{
case "添加":
this.btnSubmit_gs_PaperVer = "确认添加";
this.btnCancel_gs_PaperVer = "取消添加";
 await this.AddNewRecord();
break;				
case "确认添加":
//这是一个单表的插入的代码,由于逻辑层太简单,
//就把逻辑层合并到控制层,
if (this.opType == "AddWithMaxId")
{
//const returnKeyId = await this.AddNewRecordWithMaxIdSave();
//if (IsNullOrEmpty(returnKeyId) == false)
//{
//HideDialog_gs_PaperVer();
//this.iShowList.BindGv_Cache(clsgs_PaperVerEN._CurrTabName, "");
//}
}
else
{
returnBool = await this.AddNewRecordSave();
if (returnBool == true)
{
if (gs_PaperVer_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.HideDialog_gs_PaperVer();
}
this.iShowList.BindGv(clsgs_PaperVerEN._CurrTabName, returnBool.toString());
}
}
break;
case "确认修改":
//这是一个单表的修改的代码,由于逻辑层太简单,
returnBool = await this.UpdateRecordSave();
strInfo = returnBool ? "修改成功！" : "修改不成功！";
strInfo += "(In gs_PaperVer_Edit.btnSubmit_Click)";
//显示信息框
//console.log(strInfo);
alert(strInfo);
if (returnBool == true)
{
if (gs_PaperVer_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.HideDialog_gs_PaperVer();
}
this.iShowList.BindGv(clsgs_PaperVerEN._CurrTabName, returnBool.toString());
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
$('#ddlPaperId option[0]').attr("selected", "true");
this.paperTitle = "";
this.paperContent = "";
this.periodical = "";
this.author = "";
this.researchQuestion = "";
this.keyword = "";
this.literatureSources = "";
this.literatureLink = "";
this.uploadfileUrl = "";
this.isQuotethesis = false;
this.isSubmit = false;
this.isChecked = false;
this.quoteId = "";
this.checker = "";
this.literatureTypeId = "";
this.updUser = "";
this.updDate = "";
$('#ddlid_CurrEduCls option[0]').attr("selected", "true");
this.paperTypeId = "";
this.paperStatusId = "";
this.memo = "";
}

 /** 为插入记录做准备工作
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
 **/
public async AddNewRecord()
{
const strThisFuncName = this.AddNewRecord.name;
this.Clear();
//wucgs_PaperVerB1.paperVId = gs_PaperVer_GetMaxStrId_S();
}

 /** 为插入记录做准备工作
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxId)
 **/
public AddNewRecordWithMaxId()
{
const strThisFuncName = this.AddNewRecordWithMaxId.name;
this.Clear();
//wucgs_PaperVerB1.paperVId = gs_PaperVer_GetMaxStrId_S();
}

 /** 函数功能:把界面上的属性数据传到类对象中
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
 * @param pobjgs_PaperVerEN">数据传输的目的类对象</param>
 **/
public async PutDataTogs_PaperVerClass(pobjgs_PaperVerEN: clsgs_PaperVerEN)
{
const strThisFuncName = this.PutDataTogs_PaperVerClass.name;
pobjgs_PaperVerEN.SetPaperId(this.paperId);// 论文Id
pobjgs_PaperVerEN.SetPaperTitle(this.paperTitle);// 论文标题
pobjgs_PaperVerEN.SetPaperContent(this.paperContent);// 主题内容
pobjgs_PaperVerEN.SetPeriodical(this.periodical);// 期刊
pobjgs_PaperVerEN.SetAuthor(this.author);// 作者
pobjgs_PaperVerEN.SetResearchQuestion(this.researchQuestion);// 研究问题
pobjgs_PaperVerEN.SetKeyword(this.keyword);// 关键字
pobjgs_PaperVerEN.SetLiteratureSources(this.literatureSources);// 文献来源
pobjgs_PaperVerEN.SetLiteratureLink(this.literatureLink);// 文献链接
pobjgs_PaperVerEN.SetUploadfileUrl(this.uploadfileUrl);// 文件地址
pobjgs_PaperVerEN.SetIsQuotethesis(this.isQuotethesis);// 是否引用论文
pobjgs_PaperVerEN.SetIsSubmit(this.isSubmit);// 是否提交
pobjgs_PaperVerEN.SetIsChecked(this.isChecked);// 是否检查
pobjgs_PaperVerEN.SetQuoteId(this.quoteId);// 引用Id
pobjgs_PaperVerEN.SetChecker(this.checker);// 审核人
pobjgs_PaperVerEN.SetLiteratureTypeId(this.literatureTypeId);// 作文类型Id
pobjgs_PaperVerEN.SetUpdUser(this.updUser);// 修改人
pobjgs_PaperVerEN.SetUpdDate(this.updDate);// 修改日期
pobjgs_PaperVerEN.Setid_CurrEduCls(this.id_CurrEduCls);// 教学班流水号
pobjgs_PaperVerEN.SetPaperTypeId(this.paperTypeId);// 论文类型Id
pobjgs_PaperVerEN.SetPaperStatusId(this.paperStatusId);// 论文状态Id
pobjgs_PaperVerEN.SetMemo(this.memo);// 备注
}


 /** 添加新记录，保存函数
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
 **/
public async AddNewRecordSave(): Promise<boolean>{
const strThisFuncName = this.AddNewRecordSave.name;
const objgs_PaperVerEN = new clsgs_PaperVerEN();
try
{
await this.PutDataTogs_PaperVerClass(objgs_PaperVerEN);
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
gs_PaperVer_CheckPropertyNew(objgs_PaperVerEN);
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
const bolIsExistCond_PaperVId = await this.CheckUniCond4Add_PaperVId(objgs_PaperVerEN);
if (bolIsExistCond_PaperVId == false)
{
return false;
}
let returnBool = false;
returnBool = await gs_PaperVer_AddNewRecordAsync(objgs_PaperVerEN);
if (returnBool == true)
{
//gs_PaperVer_ReFreshCache();
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
public async CheckUniCond4Add_PaperVId(objgs_PaperVerEN: clsgs_PaperVerEN): Promise<boolean>{
const strThisFuncName = this.CheckUniCond4Add_PaperVId.name;
const strUniquenessCondition = gs_PaperVer_GetUniCondStr_PaperVId(objgs_PaperVerEN);
const bolIsExistCondition = await gs_PaperVer_IsExistRecordAsync(strUniquenessCondition);
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
public async CheckUniCond4Update_PaperVId(objgs_PaperVerEN: clsgs_PaperVerEN): Promise<boolean>{
const strThisFuncName = this.CheckUniCond4Update_PaperVId.name;
const strUniquenessCondition = gs_PaperVer_GetUniCondStr4Update_PaperVId(objgs_PaperVerEN);
const bolIsExistCondition = await gs_PaperVer_IsExistRecordAsync(strUniquenessCondition);
if (bolIsExistCondition == true)
{
const strMsg = Format("不能满足唯一性条件。满足条件：{0}的记录已经存在！", strUniquenessCondition);
console.error(strMsg);
alert(strMsg);
return false;
}
return true;
}

 /** 函数功能:把以该关键字的记录内容显示在界面上,
* 在这里是把值传到表控件中
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_ShowData)
 * @param lngPaperVId: 表记录的关键字,显示该表关键字的内容
 **/
  public async ShowData(lngPaperVId: number) {
const strThisFuncName = this.ShowData.name;
        //操作步骤:
        //1、检查关键字是否为空；
        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
        //3、用提供的关键字初始化一个类对象；
        //4、获取类对象的所有属性；
        //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
        let objgs_PaperVerEN = new clsgs_PaperVerEN();
        try {
            const returnBool = await gs_PaperVer_IsExistAsync(lngPaperVId);
            if (returnBool == false) {
                const strInfo = Format("关键字:[{0}] 的记录不存在!", lngPaperVId);
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
const objgs_PaperVerEN_Const = await gs_PaperVer_GetObjByPaperVIdAsync(lngPaperVId);
       if (objgs_PaperVerEN_Const == null)
        {
            const strMsg = Format("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
console.error(strMsg);
            alert(strMsg);
            return;
        }
         objgs_PaperVerEN = objgs_PaperVerEN_Const; 
        }
        catch (e) {
            const strMsg = Format("根据关键字获取相应的记录的对象不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
console.error(strMsg);
            alert(strMsg);
        }
        //3、用提供的关键字初始化一个类对象；
        this.GetDataFromgs_PaperVerClass(objgs_PaperVerEN);
}

 /** 函数功能:把类对象的属性内容显示到界面上
 * 注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
 * 如果在设置数据库时,就应该一级字段在前,二级字段在后
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
 * @param pobjgs_PaperVerEN">表实体类对象</param>
 **/
public GetDataFromgs_PaperVerClass(pobjgs_PaperVerEN: clsgs_PaperVerEN )
{
const strThisFuncName = this.GetDataFromgs_PaperVerClass.name;
 this.paperId = pobjgs_PaperVerEN.paperId;// 论文Id
 this.paperTitle = pobjgs_PaperVerEN.paperTitle;// 论文标题
 this.paperContent = pobjgs_PaperVerEN.paperContent;// 主题内容
 this.periodical = pobjgs_PaperVerEN.periodical;// 期刊
 this.author = pobjgs_PaperVerEN.author;// 作者
 this.researchQuestion = pobjgs_PaperVerEN.researchQuestion;// 研究问题
 this.keyword = pobjgs_PaperVerEN.keyword;// 关键字
 this.literatureSources = pobjgs_PaperVerEN.literatureSources;// 文献来源
 this.literatureLink = pobjgs_PaperVerEN.literatureLink;// 文献链接
 this.uploadfileUrl = pobjgs_PaperVerEN.uploadfileUrl;// 文件地址
this.isQuotethesis = pobjgs_PaperVerEN.isQuotethesis;// 是否引用论文
this.isSubmit = pobjgs_PaperVerEN.isSubmit;// 是否提交
this.isChecked = pobjgs_PaperVerEN.isChecked;// 是否检查
 this.quoteId = pobjgs_PaperVerEN.quoteId;// 引用Id
 this.checker = pobjgs_PaperVerEN.checker;// 审核人
 this.literatureTypeId = pobjgs_PaperVerEN.literatureTypeId;// 作文类型Id
 this.updUser = pobjgs_PaperVerEN.updUser;// 修改人
 this.updDate = pobjgs_PaperVerEN.updDate;// 修改日期
 this.id_CurrEduCls = pobjgs_PaperVerEN.id_CurrEduCls;// 教学班流水号
 this.paperTypeId = pobjgs_PaperVerEN.paperTypeId;// 论文类型Id
 this.paperStatusId = pobjgs_PaperVerEN.paperStatusId;// 论文状态Id
 this.memo = pobjgs_PaperVerEN.memo;// 备注
}

 /** 根据关键字获取相应的记录的对象
 * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
 * @param sender">参数列表</param>
 **/
public async UpdateRecord(lngPaperVId: number):Promise<boolean> 
{
const strThisFuncName = this.UpdateRecord.name;
this.keyId = lngPaperVId.toString();
try
{
const objgs_PaperVerEN_Const = await gs_PaperVer_GetObjByPaperVIdAsync(lngPaperVId);
       if (objgs_PaperVerEN_Const == null)
        {
            const strMsg = Format("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
console.error(strMsg);
            alert(strMsg);
            return false;
        }
this.objgs_PaperVer = objgs_PaperVerEN_Const;
const conGetDataFromClass = await   this.GetDataFromgs_PaperVerClass(objgs_PaperVerEN_Const);
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
const objgs_PaperVerEN = new clsgs_PaperVerEN();
objgs_PaperVerEN.paperVId = Number(this.keyId);
await this.PutDataTogs_PaperVerClass(objgs_PaperVerEN);
objgs_PaperVerEN.sfUpdFldSetStr = objgs_PaperVerEN.updFldString;//设置哪些字段被修改(脏字段)
if (objgs_PaperVerEN.paperVId == 0 || objgs_PaperVerEN.paperVId == undefined){
console.error("关键字不能为空!");
 throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
}
try
{
gs_PaperVer_CheckProperty4Update(objgs_PaperVerEN);
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
const bolIsExistCond_PaperVId = await this.CheckUniCond4Update_PaperVId(objgs_PaperVerEN);
if (bolIsExistCond_PaperVId == false)
{
return false;
}
const returnBool = await gs_PaperVer_UpdateRecordAsync(objgs_PaperVerEN);
if (returnBool == true)
{
//gs_PaperVer_ReFreshCache();
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
 * 作者 (Used In Clear())
 **/
public  set author(value: string) {
 SetInputValueByIdInDiv(this.divName4Edit, "txtAuthor", value);
}
 /**
 * 作者 (Used In PutDataToClass())
 **/
public  get author():string {
const strValue = GetInputValueInDiv(this.divName4Edit, "txtAuthor");
if (strValue == undefined) return "";
else return strValue.toString();
}
 /**
 * 设置取消按钮的标题(Used In AddNewRecord())
 **/
public  set btnCancel_gs_PaperVer(value: string) {
 SetButtonHtmlByIdInDiv(this.divName4Edit, "btnCancel_gs_PaperVer", value);
}
 /**
 * 获取按钮的标题
 **/
public  get btnSubmit_gs_PaperVer():string {
const strValue = GetButtonHtmlInDiv(this.divName4Edit, "btnSubmit_gs_PaperVer");
return strValue;
}
 /**
 * 设置确定按钮的标题(Used In AddNewRecord())
 **/
public  set btnSubmit_gs_PaperVer(value: string) {
 SetButtonHtmlByIdInDiv(this.divName4Edit, "btnSubmit_gs_PaperVer", value);
}
 /**
 * 审核人 (Used In Clear())
 **/
public  set checker(value: string) {
 SetInputValueByIdInDiv(this.divName4Edit, "txtChecker", value);
}
 /**
 * 审核人 (Used In PutDataToClass())
 **/
public  get checker():string {
const strValue = GetInputValueInDiv(this.divName4Edit, "txtChecker");
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
 * 是否检查 (Used In Clear())
 **/
public  set isChecked(value: boolean) {
 SetCheckBoxValueByIdInDiv(this.divName4Edit, "chkIsChecked", value);
}
 /**
 * 是否检查 (Used In PutDataToClass())
 **/
public  get isChecked():boolean {
const bolValue = GetCheckBoxValueInDiv(this.divName4Edit, "chkIsChecked");
return bolValue;
}
 /**
 * 是否引用论文 (Used In Clear())
 **/
public  set isQuotethesis(value: boolean) {
 SetCheckBoxValueByIdInDiv(this.divName4Edit, "chkIsQuotethesis", value);
}
 /**
 * 是否引用论文 (Used In PutDataToClass())
 **/
public  get isQuotethesis():boolean {
const bolValue = GetCheckBoxValueInDiv(this.divName4Edit, "chkIsQuotethesis");
return bolValue;
}
 /**
 * 是否提交 (Used In Clear())
 **/
public  set isSubmit(value: boolean) {
 SetCheckBoxValueByIdInDiv(this.divName4Edit, "chkIsSubmit", value);
}
 /**
 * 是否提交 (Used In PutDataToClass())
 **/
public  get isSubmit():boolean {
const bolValue = GetCheckBoxValueInDiv(this.divName4Edit, "chkIsSubmit");
return bolValue;
}
 /**
 * 关键字 (Used In Clear())
 **/
public  set keyword(value: string) {
 SetInputValueByIdInDiv(this.divName4Edit, "txtKeyword", value);
}
 /**
 * 关键字 (Used In PutDataToClass())
 **/
public  get keyword():string {
const strValue = GetInputValueInDiv(this.divName4Edit, "txtKeyword");
if (strValue == undefined) return "";
else return strValue.toString();
}
 /**
 * 文献链接 (Used In Clear())
 **/
public  set literatureLink(value: string) {
 SetInputValueByIdInDiv(this.divName4Edit, "txtLiteratureLink", value);
}
 /**
 * 文献链接 (Used In PutDataToClass())
 **/
public  get literatureLink():string {
const strValue = GetInputValueInDiv(this.divName4Edit, "txtLiteratureLink");
if (strValue == undefined) return "";
else return strValue.toString();
}
 /**
 * 文献来源 (Used In Clear())
 **/
public  set literatureSources(value: string) {
 SetInputValueByIdInDiv(this.divName4Edit, "txtLiteratureSources", value);
}
 /**
 * 文献来源 (Used In PutDataToClass())
 **/
public  get literatureSources():string {
const strValue = GetInputValueInDiv(this.divName4Edit, "txtLiteratureSources");
if (strValue == undefined) return "";
else return strValue.toString();
}
 /**
 * 作文类型Id (Used In Clear())
 **/
public  set literatureTypeId(value: string) {
 SetInputValueByIdInDiv(this.divName4Edit, "txtLiteratureTypeId", value);
}
 /**
 * 作文类型Id (Used In PutDataToClass())
 **/
public  get literatureTypeId():string {
const strValue = GetInputValueInDiv(this.divName4Edit, "txtLiteratureTypeId");
if (strValue == undefined) return "";
else return strValue.toString();
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
public  set paperContent(value: string) {
 SetInputValueByIdInDiv(this.divName4Edit, "txtPaperContent", value);
}
 /**
 * 主题内容 (Used In PutDataToClass())
 **/
public  get paperContent():string {
const strValue = GetInputValueInDiv(this.divName4Edit, "txtPaperContent");
if (strValue == undefined) return "";
else return strValue.toString();
}
 /**
 * 论文Id (Used In Clear())
 **/
public  set paperId(value: string) {
SetSelectValueByIdInDiv(this.divName4Edit, "ddlPaperId", value);
}
 /**
 * 论文Id (Used In PutDataToClass())
 **/
public  get paperId():string {
const strValue = GetSelectValueInDiv(this.divName4Edit, "ddlPaperId");
if (strValue == undefined) return "";
else if (strValue == "0") return "";
else return strValue;
}
 /**
 * 论文状态Id (Used In Clear())
 **/
public  set paperStatusId(value: string) {
 SetInputValueByIdInDiv(this.divName4Edit, "txtPaperStatusId", value);
}
 /**
 * 论文状态Id (Used In PutDataToClass())
 **/
public  get paperStatusId():string {
const strValue = GetInputValueInDiv(this.divName4Edit, "txtPaperStatusId");
if (strValue == undefined) return "";
else return strValue.toString();
}
 /**
 * 论文标题 (Used In Clear())
 **/
public  set paperTitle(value: string) {
 SetInputValueByIdInDiv(this.divName4Edit, "txtPaperTitle", value);
}
 /**
 * 论文标题 (Used In PutDataToClass())
 **/
public  get paperTitle():string {
const strValue = GetInputValueInDiv(this.divName4Edit, "txtPaperTitle");
if (strValue == undefined) return "";
else return strValue.toString();
}
 /**
 * 论文类型Id (Used In Clear())
 **/
public  set paperTypeId(value: string) {
 SetInputValueByIdInDiv(this.divName4Edit, "txtPaperTypeId", value);
}
 /**
 * 论文类型Id (Used In PutDataToClass())
 **/
public  get paperTypeId():string {
const strValue = GetInputValueInDiv(this.divName4Edit, "txtPaperTypeId");
if (strValue == undefined) return "";
else return strValue.toString();
}
 /**
 * 期刊 (Used In Clear())
 **/
public  set periodical(value: string) {
 SetInputValueByIdInDiv(this.divName4Edit, "txtPeriodical", value);
}
 /**
 * 期刊 (Used In PutDataToClass())
 **/
public  get periodical():string {
const strValue = GetInputValueInDiv(this.divName4Edit, "txtPeriodical");
if (strValue == undefined) return "";
else return strValue.toString();
}
 /**
 * 引用Id (Used In Clear())
 **/
public  set quoteId(value: string) {
 SetInputValueByIdInDiv(this.divName4Edit, "txtQuoteId", value);
}
 /**
 * 引用Id (Used In PutDataToClass())
 **/
public  get quoteId():string {
const strValue = GetInputValueInDiv(this.divName4Edit, "txtQuoteId");
if (strValue == undefined) return "";
else return strValue.toString();
}
 /**
 * 研究问题 (Used In Clear())
 **/
public  set researchQuestion(value: string) {
 SetInputValueByIdInDiv(this.divName4Edit, "txtResearchQuestion", value);
}
 /**
 * 研究问题 (Used In PutDataToClass())
 **/
public  get researchQuestion():string {
const strValue = GetInputValueInDiv(this.divName4Edit, "txtResearchQuestion");
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
 * 文件地址 (Used In Clear())
 **/
public  set uploadfileUrl(value: string) {
 SetInputValueByIdInDiv(this.divName4Edit, "txtUploadfileUrl", value);
}
 /**
 * 文件地址 (Used In PutDataToClass())
 **/
public  get uploadfileUrl():string {
const strValue = GetInputValueInDiv(this.divName4Edit, "txtUploadfileUrl");
if (strValue == undefined) return "";
else return strValue.toString();
}
}