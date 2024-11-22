
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:JournalSubject_Edit(界面:JournalSubjectCRUD)
 表名:JournalSubject(01120930)
 生成代码版本:2021.06.19.1
 生成日期:2021/06/20 00:53:35
 生成者:
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培论文
 模块英文名:GraduateEduPaper
 框架-层名:WA_编辑区后台_TS(WA_ViewScript_EditCS_TS)
 编程语言:TypeScript
 == == == == == == == == == == == == 
 */
///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../scripts/typings/q/q.d.ts" />
///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
//import * as $ from "jquery";
//import * as QQ from "q";
import { clsJournalSubjectCategoryEN } from "../TS/L0_Entity/GraduateEduPaper/clsJournalSubjectCategoryEN.js";
import { clsJournalSubjectEN } from "../TS/L0_Entity/GraduateEduPaper/clsJournalSubjectEN.js";
import { enumPageDispMode } from "../TS/L0_Entity/PrjMenu/clsPageDispModeEN.js";
import { JournalSubjectCategory_BindDdl_JournalSubjectCategoryIdInDiv_Cache } from "../TS/L3_ForWApi/GraduateEduPaper/clsJournalSubjectCategoryWApi.js";
import { JournalSubject_AddNewRecordAsync, JournalSubject_AddNewRecordWithMaxIdAsync, JournalSubject_CheckProperty4Update, JournalSubject_CheckPropertyNew, JournalSubject_GetMaxStrIdAsync, JournalSubject_GetObjByJournalSubjectIdAsync, JournalSubject_IsExistAsync, JournalSubject_ReFreshCache, JournalSubject_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsJournalSubjectWApi.js";
import { clsCommonFunc4Web } from "../TS/PubFun/clsCommonFunc4Web2.js";
import { Format, IsNullOrEmpty } from "../TS/PubFun/clsString.js";
 /*
* 宣布一个已经在存在的函数ShowDialog，用于显示对象框，
* strOpType：是操作类型，是三种类型之一：Add, Update, Detail
*/
declare function ShowDialog(strDialogName): void;
/*
* 宣布一个已经在存在的函数HideDialog，用于隐藏对象框，
*/
declare function HideDialog(strDialogName): void;
declare var $;
 /* JournalSubject_Edit 的摘要说明。其中Q代表查询,U代表修改
  (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:GeneCode)
*/
export abstract class JournalSubject_Edit 
{
public static strPageDispModeId = "01";//PopupBox(弹出框)
public static objPage_Edit: JournalSubject_Edit;
public objJournalSubject: clsJournalSubjectEN;
protected iShowList: IShowList;
public bolIsLoadEditRegion: boolean = false;  //记录是否导入编辑区的变量
public bolIsUseInDiv: boolean = true;  //是否使用层来处理相关的控件，否则会出现同一界面控件Id同名而不能正确处理的情况
public divName4Edit: string = "divEdit";  //编辑区的Id
constructor(objShowList: IShowList) {
this.iShowList = objShowList;
JournalSubject_Edit.objPage_Edit = this;
this.objJournalSubject = new clsJournalSubjectEN();
}


 /// <summary>
 /// 在当前界面中，导入编辑区域
 /// (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddDPV_Edit)
 /// </summary>
 /// <returns></returns>
public async AddDPV_Edit(divName4Edit) {
clsCommonFunc4Web.CheckDivExist(divName4Edit);
var strUrl:string = "./JournalSubject_Edit";
console.log("divName4Edit:(In AddDPV_Edit)" + divName4Edit);
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "GET",
dataType: "html",
data: { },
success: function(data) {
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
};

 /* 函数功能:页面导入,当页面开始运行时所发生的事件
  (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
*/
public async Page_Load()
{
// 在此处放置用户代码以初始化页面
try
{
this.SetEventFunc();
}
catch (e)
{
var strMsg: string = `页面启动不成功,${e}.`;
console.error(strMsg);
alert(strMsg);
}
}


 /* 函数功能:设置事件函数
  (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_SetEventFunc)
*/
public async SetEventFunc()
{
// 在此处放置用户代码以初始化页面
try
{
}
catch (e)
{
var strMsg: string = `页面启动不成功,${e}.`;
console.error(strMsg);
alert(strMsg);
}
}





 /*
  显示对话框
 (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_TS_ShowDialog)
 */
public ShowDialog_JournalSubject(strOp) {
//检查相关控件是否存在
clsCommonFunc4Web.CheckControlExist(this.divName4Edit, "div", "divEditDialog_JournalSubject");
clsCommonFunc4Web.CheckControlExist(this.divName4Edit, "h4", "lblDialogTitle_JournalSubject");
       if (strOp === "Add") {
           $('#lblDialogTitle_JournalSubject').html('添加记录');
//JournalSubject_EditEx.GetMaxStrId('#txtJournalSubjectId');
        }
else if (strOp === "Update")
{
            $('#lblDialogTitle_JournalSubject').html('修改记录');
}
else if (strOp === "Detail")
{
            $('#btnSubmit_JournalSubject').hide();
            $('#lblDialogTitle_JournalSubject').html('详细信息');
}
        ShowDialog('#divEditDialog_JournalSubject');
}

 /*
  隐藏对话框
 (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_TS_HideDialog)
 */
public HideDialog_JournalSubject() {
clsCommonFunc4Web.CheckControlExist(this.divName4Edit, "div", "divEditDialog_JournalSubject");
      HideDialog('#divEditDialog_JournalSubject');
}

 /* 添加新记录
 (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecord_Click)
*/
public async btnAddNewRecord_Click() {
this.OpType = "Add";
try
{
if (this.bolIsLoadEditRegion == false)  //
{
const responseBool = await this.AddDPV_Edit(this.divName4Edit);
 // 为编辑区绑定下拉框
if (this.bolIsUseInDiv == true)
{
const conBindDdl = await this.BindDdl4EditRegionInDiv();
}
else
{
const conBindDdl = await this.BindDdl4EditRegion();
}
this.SetEventFunc();
this.bolIsLoadEditRegion = true;  //
const responseText = this.AddNewRecord();
if (JournalSubject_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.ShowDialog_JournalSubject('Add');
}
}
else
{
const responseText = await this.AddNewRecord();
if (JournalSubject_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.ShowDialog_JournalSubject('Add');
}
}
}
catch(e)
{
var strMsg: string = `添加新记录初始化不成功,${e}.`;
console.error(strMsg);
alert(strMsg);
}
}

 /* 函数功能:为编辑区绑定下拉框
  (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4EditRegion)
*/
public async BindDdl4EditRegion()
{
// 在此处放置用户代码以初始化页面
const ddlJournalSubjectCategoryId = await this.SetDdl_JournalSubjectCategoryId();//编辑区域
}


 /* 添加新记录
 (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecordWithMaxId_Click)
*/
public async btnAddNewRecordWithMaxId_Click() {
this.OpType = "AddWithMaxId";
try
{
if (this.bolIsLoadEditRegion == false)  //
{
const responseBool = await this.AddDPV_Edit(this.divName4Edit);
 // 为编辑区绑定下拉框
if (this.bolIsUseInDiv == true)
{
const conBindDdl = await this.BindDdl4EditRegionInDiv();
}
else
{
const conBindDdl = await this.BindDdl4EditRegion();
}
this.SetEventFunc();
this.bolIsLoadEditRegion = true;  //
const responseText = this.AddNewRecordWithMaxId();
if (JournalSubject_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.ShowDialog_JournalSubject('Add');
}
}
else
{
const responseText = this.AddNewRecordWithMaxId();
if (JournalSubject_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.ShowDialog_JournalSubject('Add');
}
}
}
catch(e)
{
var strMsg: string = `添加新记录初始化不成功,${e}.`;
console.error(strMsg);
alert(strMsg);
}
}

/// <summary>
/// 设置绑定下拉框，针对字段:[journalSubjectCategoryId]
 /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl_TS)
/// </summary>
public async SetDdl_JournalSubjectCategoryId()
{
 var objJournalSubjectCategory_Cond: clsJournalSubjectCategoryEN = new clsJournalSubjectCategoryEN();//编辑区域
const ddlJournalSubjectCategoryId = await JournalSubjectCategory_BindDdl_JournalSubjectCategoryIdInDiv_Cache(this.divName4Edit, "ddlJournalSubjectCategoryId");//编辑区域
}

/// <summary>
/// 设置绑定下拉框，针对字段:[journalSubjectCategoryId]
 /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl_TSInDiv)
/// </summary>
public async SetDdl_JournalSubjectCategoryIdInDiv()
{
 var objJournalSubjectCategory_Cond: clsJournalSubjectCategoryEN = new clsJournalSubjectCategoryEN();//编辑区域
const ddlJournalSubjectCategoryId = await JournalSubjectCategory_BindDdl_JournalSubjectCategoryIdInDiv_Cache(this.divName4Edit, "ddlJournalSubjectCategoryId");//编辑区域
}


 /* 函数功能:为编辑区绑定下拉框
  (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4EditRegionInDiv)
*/
public async BindDdl4EditRegionInDiv()
{
// 在此处放置用户代码以初始化页面
const ddlJournalSubjectCategoryId = await this.SetDdl_JournalSubjectCategoryIdInDiv();//编辑区域
}


 /* 在数据表里修改记录
 (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecordInTab_Click)
*/
public async btnUpdateRecordInTab_Click(strKeyId:string) {
this.OpType = "Update";
    if (strKeyId == "")
{
alert("请选择需要修改的记录！");
return;
}
try {
if (this.bolIsLoadEditRegion == false)  //
{
const responseBool = await this.AddDPV_Edit(this.divName4Edit);
 // 为编辑区绑定下拉框
if (this.bolIsUseInDiv == true)
{
const conBindDdl = await this.BindDdl4EditRegionInDiv();
}
else
{
const conBindDdl = await this.BindDdl4EditRegion();
}
this.SetEventFunc();
this.bolIsLoadEditRegion = true;  //
this.UpdateRecord(strKeyId);
if (JournalSubject_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.ShowDialog_JournalSubject('Update');
}
}
else
{
this.UpdateRecord(strKeyId);
if (JournalSubject_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.ShowDialog_JournalSubject('Update');
}
}
}
catch (e)
{
var strMsg: string = `(errid: WiTsCs0034)在修改记录时出错!请联系管理员!${ e}`;
console.error(strMsg);
alert(strMsg);
}
}

 /* 修改记录
 (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecord_Click)
*/
public async btnUpdateRecord_Click(strKeyId: string) {
this.OpType = "Update";
if (clsString.IsNullOrEmpty(strKeyId) == true)
{
var strMsg = "修改记录的关键字为空，请检查！";
console.error(strMsg);
alert(strMsg);
return;
}
try {
if (this.bolIsLoadEditRegion == false)  //
{
const responseBool = await this.AddDPV_Edit(this.divName4Edit);
 // 为编辑区绑定下拉框
if (this.bolIsUseInDiv == true)
{
const conBindDdl = await this.BindDdl4EditRegionInDiv();
}
else
{
const conBindDdl = await this.BindDdl4EditRegion();
}
this.SetEventFunc();
this.bolIsLoadEditRegion = true;  //
const update = await this.UpdateRecord(strKeyId);
if (update == false)
{
var strMsg: string = `在修改记录时,显示记录数据不成功!`;
console.error(strMsg);
alert(strMsg);
return;
}
if (JournalSubject_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.ShowDialog_JournalSubject('Update');
}
}
else
{
const update = await this.UpdateRecord(strKeyId);
if (update == false)
{
var strMsg: string = `在修改记录时,显示记录数据不成功!`;
console.error(strMsg);
alert(strMsg);
return;
}
if (JournalSubject_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.ShowDialog_JournalSubject('Update');
}
}
}
catch (e)
{
var strMsg: string = `(errid: WiTsCs0034)在修改记录时出错!请联系管理员!${ e}`;
console.error(strMsg);
alert(strMsg);
}
}

 /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
  具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
  (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
*/
public async btnSubmit_Click()
{
var strCommandText: string = this.btnSubmit_JournalSubject;
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
const responseText3 = await this.AddNewRecordWithMaxIdSave().then((jsonData)=>{
var returnKeyId: string = <string>jsonData;
if (clsString.IsNullOrEmpty(returnKeyId) == false)
{
if (JournalSubject_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.HideDialog_JournalSubject();
}
    this.iShowList.BindGv_Cache(clsJournalSubjectEN._CurrTabName, "");
}
});
}
else
{
const responseText2 = await this.AddNewRecordSave().then((jsonData)=>{
var returnBool: boolean = jsonData;
if (returnBool == true)
{
if (JournalSubject_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.HideDialog_JournalSubject();
}
    this.iShowList.BindGv_Cache(clsJournalSubjectEN._CurrTabName, "");
}
});
}
break;
case "确认修改":
//这是一个单表的修改的代码,由于逻辑层太简单,
const responseText3 = await this.UpdateRecordSave().then((jsonData)=>{
var returnBool: boolean = jsonData;
var strInfo: string = returnBool ? "修改成功！" : "修改不成功！";
strInfo += "(In JournalSubject_Edit.btnSubmit_Click)";
$('#lblResult51').val(strInfo);
//显示信息框
console.log(strInfo);
alert(strInfo);
if (returnBool == true)
{
if (JournalSubject_Edit.strPageDispModeId == enumPageDispMode.PopupBox_01)
{
this.HideDialog_JournalSubject();
}
    this.iShowList.BindGv_Cache(clsJournalSubjectEN._CurrTabName, "");
}
});
break;
default:
var strMsg = `strCommandText:${strCommandText}在switch中没有处理！(In btnSubmit_Click())`
console.error(strMsg);
alert(strMsg);
break;
}
}
catch (e)
{
var strMsg: string = `(errid: WiTsCs0033)在保存记录时(${ strCommandText})时出错!请联系管理员!${ e}`;
console.error(strMsg);
alert(strMsg);
}
}

/// <summary>
/// 在用户自定义控件中，设置关键字的值，是否只读
 /// (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_SetKeyReadOnly)
/// </summary>
/// <param name = "bolReadonly">是否只读</param>
public SetKeyReadOnly(bolReadonly:boolean)
{
$('#txtJournalSubjectId').prop['ReadOnly'] = bolReadonly;
}

/// <summary>
/// 清除用户自定义控件中，所有控件的值
 /// (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_Clear)
/// </summary>	
public Clear()
{
}

 /* 为插入记录做准备工作
  (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
*/
public async AddNewRecord()
{
this.btnSubmit_JournalSubject = "确认添加";
this.btnCancel_JournalSubject = "取消添加";
this.Clear();
//wucJournalSubjectB1.journalSubjectId = clsJournalSubjectBL.GetMaxStrId_S();
try
{
const responseText = await JournalSubject_GetMaxStrIdAsync();
var returnString: string = responseText;
if (returnString == "")
{
var strInfo: string = `获取表JournalSubject的最大关键字为空，不成功，请检查!`;
//显示信息框
alert(strInfo);
}
else
{
$('#txtJournalSubjectId').val(returnString);
}
}
catch(e)
{
var strMsg: string = `获取表关键字的最大值不成功,${e}.`;
console.error(strMsg);
alert(strMsg);
}
}

 /* 为插入记录做准备工作
  (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxId)
*/
public AddNewRecordWithMaxId()
{
this.btnSubmit_JournalSubject = "确认添加";
this.btnCancel_JournalSubject = "取消添加";
this.Clear();
//wucJournalSubjectB1.journalSubjectId = clsJournalSubjectBL.GetMaxStrId_S();
}

 /* 函数功能:把界面上的属性数据传到类对象中
  (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
  <param name = "pobjJournalSubjectEN">数据传输的目的类对象</param>
*/
public PutDataToJournalSubjectClass(pobjJournalSubjectEN: clsJournalSubjectEN)
{
pobjJournalSubjectEN.journalSubjectId = this.journalSubjectId;// 学科Id
pobjJournalSubjectEN.journalSubjectCode = this.journalSubjectCode;// 学科代码
pobjJournalSubjectEN.journalSubjectName = this.journalSubjectName;// 学科名称
pobjJournalSubjectEN.journalSubjectCategoryId = this.journalSubjectCategoryId;// 学科门类
pobjJournalSubjectEN.memo = this.memo;// 备注
}


 /* 添加新记录，保存函数
 (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
*/
public async AddNewRecordSave(){
this.DivName = "divAddNewRecordSave";
var objJournalSubjectEN: clsJournalSubjectEN = new clsJournalSubjectEN();
   this.PutDataToJournalSubjectClass(objJournalSubjectEN);
try
{
JournalSubject_CheckPropertyNew(objJournalSubjectEN);
}
catch(e)
{
var strMsg: string = `检查数据不成功,${e}.`;
console.error(strMsg);
alert(strMsg);
return false;//一定要有一个返回值，否则会出错！
}
try
{
const responseText = await JournalSubject_IsExistAsync(objJournalSubjectEN.journalSubjectId);
var bolIsExist: boolean = responseText;
if (bolIsExist == true)
{
var strMsg: string = `添加记录时，关键字：${objJournalSubjectEN.journalSubjectId }已经存在！`;
console.error(strMsg);
alert(strMsg);
return responseText;//一定要有一个返回值，否则会出错！
}
const responseText2 = await JournalSubject_AddNewRecordAsync(objJournalSubjectEN);
var returnBool: boolean = !!responseText2;
if (returnBool == true)
{
JournalSubject_ReFreshCache();
var strInfo: string = `添加记录成功!`;
$('#lblResult46').val(strInfo);
//显示信息框
alert(strInfo);
}
else
{
var strInfo: string = `添加记录不成功!`;
$('#lblResult46').val(strInfo);
//显示信息框
alert(strInfo);
}
return responseText2;//一定要有一个返回值，否则会出错！
}
catch(e)
{
var strMsg: string = `添加记录不成功,${e}.`;
console.error(strMsg);
alert(strMsg);
return false;//一定要有一个返回值，否则会出错！
}
}

 /* 添加新记录，由后台自动获取最大值的关键字。保存函数
 (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxIdSave)
*/
public async AddNewRecordWithMaxIdSave(){
this.DivName = "divAddNewRecordWithMaxIdSave";
var objJournalSubjectEN: clsJournalSubjectEN = new clsJournalSubjectEN();
   this.PutDataToJournalSubjectClass(objJournalSubjectEN);
try
{
JournalSubject_CheckPropertyNew(objJournalSubjectEN);
}
catch(e)
{
var strMsg: string = `检查数据不成功,${e}.`;
console.error(strMsg);
alert(strMsg);
return false;//一定要有一个返回值，否则会出错！
}
try
{
const responseKeyId = await JournalSubject_AddNewRecordWithMaxIdAsync(objJournalSubjectEN);
var returnKeyId: string = responseKeyId;
if (clsString.IsNullOrEmpty(returnKeyId) == false)
{
JournalSubject_ReFreshCache();
var strInfo: string = `添加记录成功!`;
$('#lblResult47').val(strInfo);
//显示信息框
alert(strInfo);
}
else
{
var strInfo: string = `添加记录不成功!`;
$('#lblResult47').val(strInfo);
//显示信息框
alert(strInfo);
}
return responseKeyId;//一定要有一个返回值，否则会出错！
}
catch(e)
{
var strMsg: string = `添加记录不成功,${e}.`;
console.error(strMsg);
alert(strMsg);
return false;
}
return true;//一定要有一个返回值，否则会出错！
}

 /* 函数功能:把以该关键字的记录内容显示在界面上,
 　　　   在这里是把值传到表控件中
  (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_ShowData)
  <param name = "strJournalSubjectId">表记录的关键字,显示该表关键字的内容</param>
*/
  public async ShowData(strJournalSubjectId: string) {
        //操作步骤:
        //1、检查关键字是否为空；
        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
        //3、用提供的关键字初始化一个类对象；
        //4、获取类对象的所有属性；
        //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
        var objJournalSubjectEN: clsJournalSubjectEN = new clsJournalSubjectEN();
        try {
            const responseText = await JournalSubject_IsExistAsync(strJournalSubjectId);
            var returnBool: boolean = responseText;
            if (returnBool == false) {
                var strInfo: string = `关键字:[${ strJournalSubjectId }] 的记录不存在!`;
                //$('#lblResult1').val(strInfo);
                //显示信息框
                alert(strInfo);
            }
            else {
            }
        }
        catch (e) {
            var strMsg: string = `检查相应关键字的记录存在不成功, ${e}.`;
console.error(strMsg);
            alert(strMsg);
        }
        try {
            const responseText = await JournalSubject_GetObjByJournalSubjectIdAsync(strJournalSubjectId);
            objJournalSubjectEN = <clsJournalSubjectEN>responseText;
        }
        catch (e) {
            var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
console.error(strMsg);
            alert(strMsg);
        }
        //3、用提供的关键字初始化一个类对象；
        this.GetDataFromJournalSubjectClass(objJournalSubjectEN);
}

 /* 函数功能:把类对象的属性内容显示到界面上
 注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
  如果在设置数据库时,就应该一级字段在前,二级字段在后
  (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
  <param name = "pobjJournalSubjectEN">表实体类对象</param>
*/
public GetDataFromJournalSubjectClass(pobjJournalSubjectEN: clsJournalSubjectEN )
{
 this.journalSubjectId = pobjJournalSubjectEN.journalSubjectId;// 学科Id
 this.journalSubjectCode = pobjJournalSubjectEN.journalSubjectCode;// 学科代码
 this.journalSubjectName = pobjJournalSubjectEN.journalSubjectName;// 学科名称
 this.journalSubjectCategoryId = pobjJournalSubjectEN.journalSubjectCategoryId;// 学科门类
 this.memo = pobjJournalSubjectEN.memo;// 备注
}

 /* 根据关键字获取相应的记录的对象
  (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
  <param name = "sender">参数列表</param>
*/
public async UpdateRecord(strJournalSubjectId: string):Promise<boolean> 
{
this.btnSubmit_JournalSubject = "确认修改";
this.btnCancel_JournalSubject = "取消修改";
this.KeyId = strJournalSubjectId;
try
{
const responseText = await JournalSubject_GetObjByJournalSubjectIdAsync(strJournalSubjectId);
var objJournalSubjectEN: clsJournalSubjectEN = <clsJournalSubjectEN>responseText;
this.objJournalSubject = objJournalSubjectEN;
const conGetDataFromClass = await   this.GetDataFromJournalSubjectClass(objJournalSubjectEN);
console.log("完成UpdateRecord!");
return true;
}
catch(e)
{
var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
console.error(strMsg);
alert(strMsg);
return false;
}
}

 /* 修改记录
  (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
*/
public async UpdateRecordSave() {
this.DivName = "divUpdateRecordSave";
var objJournalSubjectEN: clsJournalSubjectEN = new clsJournalSubjectEN();
objJournalSubjectEN.journalSubjectId = this.KeyId;
   this.PutDataToJournalSubjectClass(objJournalSubjectEN);
objJournalSubjectEN.sf_UpdFldSetStr = objJournalSubjectEN.updFldString;//设置哪些字段被修改(脏字段)
if (objJournalSubjectEN.journalSubjectId == "" || objJournalSubjectEN.journalSubjectId == undefined){
console.error("关键字不能为空!");
throw "关键字不能为空!";
}
try
{
JournalSubject_CheckProperty4Update(objJournalSubjectEN);
}
catch(e)
{
var strMsg: string = `检查数据不成功,${e}.`;
console.error(strMsg);
alert(strMsg);
return false;//一定要有一个返回值，否则会出错！
}
try
{
const responseText = await JournalSubject_UpdateRecordAsync(objJournalSubjectEN);
var returnBool: boolean = !!responseText;
if (returnBool == true)
{
JournalSubject_ReFreshCache();
}
return returnBool;
}
catch(e)
{
var strMsg: string = `修改记录不成功,${e}.`;
console.error(strMsg);
alert(strMsg);
return false;
}
}
 /*
 * 设置取消按钮的标题(Used In AddNewRecord())
*/
public  set btnCancel_JournalSubject(value: string) {
$("#btnCancel_JournalSubject").html(value);
}
 /*
 * 获取按钮的标题
*/
public  get btnSubmit_JournalSubject():string {
return $("#btnSubmit_JournalSubject").html();
}
 /*
 * 设置确定按钮的标题(Used In AddNewRecord())
*/
public  set btnSubmit_JournalSubject(value: string) {
$("#btnSubmit_JournalSubject").html(value);
}
 /*
 * 添加、修改用的层名
*/
public  set DivName(value: string) {
$("#hidDivName").val(value);
}
 /*
 * 设置排序字段-相当使用ViewState功能
*/
public  set hidSortJournalSubjectBy(value: string) {
$("#hidSortJournalSubjectBy").val(value);
}
 /*
 * 设置排序字段
*/
public  get hidSortJournalSubjectBy():string {
return $("#hidSortJournalSubjectBy").val();
}
 /*
 * 期刊学科门类Id (Used In Clear())
*/
public  set journalSubjectCategoryId(value: string) {
var objDiv = $(`#${this.divName4Edit}`);
    clsCommonFunc4Web.CheckControlExist(this.divName4Edit, "select", "ddlJournalSubjectCategoryId");
var strId = `select[id ^= "ddlJournalSubjectCategoryId"]`;
 objDiv.find(strId).val(value);
}
 /*
 * 期刊学科门类Id (Used In PutDataToClass())
*/
public  get journalSubjectCategoryId():string {
var objDiv = $(`#${this.divName4Edit}`);
    clsCommonFunc4Web.CheckControlExist(this.divName4Edit, "select", "ddlJournalSubjectCategoryId");
var strId = `select[id ^= "ddlJournalSubjectCategoryId"]`;
 if (objDiv.find(strId).val() == "0") return "";
 return objDiv.find(strId).val();
}
 /*
 * 期刊学科代码 (Used In Clear())
*/
public  set journalSubjectCode(value: string) {
var objDiv = $(`#${this.divName4Edit}`);
    clsCommonFunc4Web.CheckControlExist(this.divName4Edit, "input", "txtJournalSubjectCode");
var strId = `input[id ^= "txtJournalSubjectCode"]`;
 objDiv.find(strId).val(value);
}
 /*
 * 期刊学科代码 (Used In PutDataToClass())
*/
public  get journalSubjectCode():string {
var objDiv = $(`#${this.divName4Edit}`);
    clsCommonFunc4Web.CheckControlExist(this.divName4Edit, "input", "txtJournalSubjectCode");
var strId = `input[id ^= "txtJournalSubjectCode"]`;
 return objDiv.find(strId).val();
}
 /*
 * 期刊学科Id (Used In Clear())
*/
public  set journalSubjectId(value: string) {
var objDiv = $(`#${this.divName4Edit}`);
    clsCommonFunc4Web.CheckControlExist(this.divName4Edit, "input", "txtJournalSubjectId");
var strId = `input[id ^= "txtJournalSubjectId"]`;
 objDiv.find(strId).val(value);
}
 /*
 * 期刊学科Id (Used In PutDataToClass())
*/
public  get journalSubjectId():string {
var objDiv = $(`#${this.divName4Edit}`);
    clsCommonFunc4Web.CheckControlExist(this.divName4Edit, "input", "txtJournalSubjectId");
var strId = `input[id ^= "txtJournalSubjectId"]`;
 return objDiv.find(strId).val();
}
 /*
 * 期刊学科名称 (Used In Clear())
*/
public  set journalSubjectName(value: string) {
var objDiv = $(`#${this.divName4Edit}`);
    clsCommonFunc4Web.CheckControlExist(this.divName4Edit, "input", "txtJournalSubjectName");
var strId = `input[id ^= "txtJournalSubjectName"]`;
 objDiv.find(strId).val(value);
}
 /*
 * 期刊学科名称 (Used In PutDataToClass())
*/
public  get journalSubjectName():string {
var objDiv = $(`#${this.divName4Edit}`);
    clsCommonFunc4Web.CheckControlExist(this.divName4Edit, "input", "txtJournalSubjectName");
var strId = `input[id ^= "txtJournalSubjectName"]`;
 return objDiv.find(strId).val();
}
 /*
 * 设置关键字的值(Used In UpdateRecord())
*/
public  set KeyId(value: string) {
$("#hidKeyId").val(value);
}
 /*
 * 设置关键字的值
*/
public  get KeyId():string {
return $("#hidKeyId").val();
}
 /*
 * 备注 (Used In Clear())
*/
public  set memo(value: string) {
var objDiv = $(`#${this.divName4Edit}`);
    clsCommonFunc4Web.CheckControlExist(this.divName4Edit, "input", "txtMemo");
var strId = `input[id ^= "txtMemo"]`;
 objDiv.find(strId).val(value);
}
 /*
 * 备注 (Used In PutDataToClass())
*/
public  get memo():string {
var objDiv = $(`#${this.divName4Edit}`);
    clsCommonFunc4Web.CheckControlExist(this.divName4Edit, "input", "txtMemo");
var strId = `input[id ^= "txtMemo"]`;
 return objDiv.find(strId).val();
}
 /*
 * 设置操作类型：Add||Update||Detail
*/
public  set OpType(value: string) {
$("#hidOpType").val(value);
}
 /*
 * 设置操作类型：Add||Update||Detail
*/
public  get OpType():string {
return $("#hidOpType").val();
}
}