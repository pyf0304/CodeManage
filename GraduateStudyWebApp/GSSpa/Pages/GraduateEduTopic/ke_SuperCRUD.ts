﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:ke_SuperCRUD
 表名:ke_Super(01120661)
 生成代码版本:2020.06.05.2
 生成日期:2020/06/08 16:47:08
 生成者:
 工程名称:问卷调查
 工程ID:0112
 相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
 PrjDataBaseId:0122
 模块中文名:研培主题
 模块英文名:GraduateEduTopic
 框架-层名:WA_界面后台_TS(WA_ViewScriptCS_TS)
 编程语言:TypeScript
 == == == == == == == == == == == == 
 */
///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../scripts/typings/q/q.d.ts" />
///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
//import * as $ from "jquery";
//import * as QQ from "q";
import { clske_SuperEN } from "../TS/L0_Entity/GraduateEduTopic/clske_SuperEN.js";
import { arrSelectedKeys, clsCommonFunc4Web } from "../TS/PubFun/clsCommonFunc4Web2.js";
import { clsDataColumn } from "../TS/PubFun/clsDataColumn.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";
//import { clsPubFun } from "../TS/PubFun/clsPubFun.js";
import { clsPubFun4Web } from "../TS/FunClass/clsPubFun4Web.js";
import { clsOperateList } from "../TS/PubFun/clsOperateList.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { Format, IsNullOrEmpty } from "../TS/PubFun/clsString.js";
import { ke_Super_AddNewRecordAsync, ke_Super_AddNewRecordWithMaxIdAsync, ke_Super_Delke_SupersAsync, ke_Super_DelRecordAsync, ke_Super_GetObjByke_SuperIdAsync, ke_Super_GetObjLstAsync, ke_Super_GetObjLstByPagerAsync, ke_Super_GetObjLstByPager_Cache, ke_Super_GetRecCountByCondAsync, ke_Super_GetRecCountByCond_Cache, ke_Super_IsExistAsync, ke_Super_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clske_SuperWApi.js";
 /*
* 宣布一个已经在存在的函数ShowDialog，用于显示对象框，
* strOpType：是操作类型，是三种类型之一：Add, Update, Detail
*/
declare function ShowDialog(strOpType): void;
/*
* 宣布一个已经在存在的函数HideDialog，用于隐藏对象框，
*/
declare function HideDialog(): void;
/*
* 宣布一个已经在其他地方定义存在的变量strUrl_Session_SetString，
* 用于定义处理Session-设置String函数的地址
*/
declare var strUrl_Session_SetString;
declare var strUrl_Session_GetString;
/*
* 宣布一个已经在其他地方定义存在的变量strCurrPrjId，
* 用于定义当前工程Id
*/
declare var strCurrPrjId;
declare var $;
declare var window;
 /* ke_SuperCRUD 的摘要说明。其中Q代表查询,U代表修改
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
*/
export class ke_SuperCRUD implements clsOperateList
{
public mstrListDiv: string = "divDataLst";
public bolIsLoadEditRegion: boolean = false;  //记录是否导入编辑区的变量
public bolIsLoadDetailRegion: boolean = false;  //记录是否导入详细信息区的变量
public divName4Edit: string = "divEdit";  //编辑区的Id
public divName4Detail: string = "divDetail";  //详细信息区的Id

 /*
 * 每页记录数，在扩展类可以修改
*/
public get pageSize():number {
return 5;
}
public RecCount = 0;


 /* 函数功能:页面导入,当页面开始运行时所发生的事件
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
*/
public async Page_Load()
{
// 在此处放置用户代码以初始化页面
try
{
//建立缓存
//
 // 为查询区绑定下拉框
const gvBindDdl = await this.BindDdl4QueryRegion();

    this.hidSortke_SuperBy = "ke_SuperId Asc";
    if (this.bolIsInitShow == false)  //
    {
        this.objPager.InitShow(this.divName4Pager);
        this.bolIsInitShow = true;  //
    }
//2、显示无条件的表内容在GridView中
const gvResult = await this.BindGv_ke_Super();
}
catch (e)
{
var strMsg: string = `页面启动不成功,${e}.`;
alert(strMsg);
}
}


 /// <summary>
 /// 在当前界面中，导入编辑区域
 /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddDPV_Edit)
 /// </summary>
 /// <returns></returns>
public async AddDPV_Edit(divName4Edit) {
var strUrl:string = "./ke_Super_Edit/";
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

 /// <summary>
 /// 在当前界面中，导入编辑区域
 /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddDPV_Detail)
 /// </summary>
 /// <returns></returns>
public async AddDPV_Detail(divName4Detail) {
var strUrl:string = "./ke_Super_Detail/";
console.log("divName4Detail:(In AddDPV_Detail)" + divName4Detail);
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "GET",
dataType: "html",
data: { },
success: function(data) {
console.log("已经成功获取页面:" + strUrl + "  字节数: " + data.length.toString());
$('#' + divName4Detail).html(data);
resolve(true);
//setTimeout(() => { clsDetailObj.BindTab(); }, 100);
//clsDetailObj.BindTab();
},
error: (e) => {
console.error(e);
reject(e);
}
});
});
};

 /* 函数功能:页面导入,当页面开始运行时所发生的事件
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load_Cache)
*/
public async Page_Load_Cache()
{
// 在此处放置用户代码以初始化页面
try
{

this.hidSortke_SuperBy = "ke_SuperId Asc";
//2、显示无条件的表内容在GridView中
const gvResult = await this.BindGv_ke_Super_Cache();
}
catch (e)
{
var strMsg: string = `页面启动不成功,${e}.`;
alert(strMsg);
}
}


 /* 根据条件获取相应的对象列表
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
*/
public async btnQuery_Click() 
{
var strWhereCond = this.Combineke_SuperCondition();
try
{
const responseRecCount = await ke_Super_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
this.RecCount = jsonData;
});
var objPagerPara: stuPagerPara = {
pageIndex: 1,
pageSize: this.pageSize,
whereCond: strWhereCond,
    orderBy: this.hidSortke_SuperBy,
    sortFun: (x, y) => { return 0; }
};
const responseObjLst = await ke_Super_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
var arrke_SuperObjLst : Array<clske_SuperEN> = < Array<clske_SuperEN>>jsonData;
this.BindTab_ke_Super(this.mstrListDiv, arrke_SuperObjLst);
});
}
catch(e)
{
console.error('catch(e)=');
console.error(e);
var strMsg: string = `查询不成功,${e}.`;
alert(strMsg);
}
}

 /* 添加新记录
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecord_Click)
*/
public async btnAddNewRecord_Click() {
this.OpType = "Add";
try
{
if (this.bolIsLoadEditRegion == false)  //
{
const responseBool = await this.AddDPV_Edit(this.divName4Edit);
 // 为编辑区绑定下拉框
const conBindDdl = await this.BindDdl4EditRegion();
ShowDialog('Add');
this.bolIsLoadEditRegion = true;  //
const responseText = this.AddNewRecord();
}
else
{
ShowDialog('Add');
const responseText = await this.AddNewRecord();
}
}
catch(e)
{
console.error('catch(e)=');
console.error(e);
var strMsg: string = `添加新记录初始化不成功,${e}.`;
alert(strMsg);
}
}

 /* 函数功能:为编辑区绑定下拉框
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4EditRegion)
*/
public async BindDdl4EditRegion()
{
// 在此处放置用户代码以初始化页面
}


 /* 添加新记录
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecordWithMaxId_Click)
*/
public async btnAddNewRecordWithMaxId_Click() {
this.OpType = "AddWithMaxId";
try
{
if (this.bolIsLoadEditRegion == false)  //
{
const responseBool = await this.AddDPV_Edit(this.divName4Edit);
 // 为编辑区绑定下拉框
const conBindDdl = await this.BindDdl4EditRegion();
ShowDialog('Add');
this.bolIsLoadEditRegion = true;  //
const responseText = this.AddNewRecordWithMaxId();
}
else
{
ShowDialog('Add');
const responseText = this.AddNewRecordWithMaxId();
}
}
catch(e)
{
console.error('catch(e)=');
console.error(e);
var strMsg: string = `添加新记录初始化不成功,${e}.`;
alert(strMsg);
}
}

 /* 函数功能:为查询区绑定下拉框
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Js_BindDdl4QueryRegion)
*/
public async BindDdl4QueryRegion()
{
// 在此处放置用户代码以初始化页面
}


 /* 在数据表里修改记录
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecordInTab_Click)
*/
public async btnUpdateRecordInTab_Click(strKeyId:string) {
this.OpType = "Update";
    if (strKeyId == "")
{
alert("请选择需要修改的记录！");
return;
}
if (this.bolIsLoadEditRegion == false)  //
{
const responseBool = await this.AddDPV_Edit(this.divName4Edit);
 // 为编辑区绑定下拉框
const conBindDdl = await this.BindDdl4EditRegion();
ShowDialog('Update');
this.bolIsLoadEditRegion = true;  //
this.UpdateRecord(strKeyId);
}
else
{
ShowDialog('Update');
this.UpdateRecord(strKeyId);
}
}

 /* 
 在数据表里删除记录
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecordInTab_Click)
*/
public async btnDelRecordInTab_Click(strKeyId:string) {
try
{
 if (strKeyId == "")
{
alert("请选择需要删除的记录！");
return "";
}
const responseText = await this.DelRecord(strKeyId);
const responseBindGv = await this.BindGv_ke_Super();
}
catch(e)
{
console.error('catch(e)=');
console.error(e);
var strMsg: string = `删除记录不成功. ${e}.`;
alert(strMsg);
}
}

 /* 
 在数据表里选择记录
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnSelectRecordInTab_Click)
*/
public async btnSelectRecordInTab_Click(strKeyId:string) {
try
{
 if (strKeyId == "")
{
alert("请选择需要删除的记录！");
return "";
}
this.SelectRecord(strKeyId);
}
catch(e)
{
console.error('catch(e)=');
console.error(e);
var strMsg: string = `选择记录不成功. ${e}.`;
alert(strMsg);
}
}

 /* 
 根据关键字删除记录
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
*/
public async DelRecord(strke_SuperId: string) {
try
{
const responseText = await ke_Super_DelRecordAsync(strke_SuperId);
var returnInt: number = responseText;
if (returnInt > 0)
{
var strInfo: string = `删除记录成功,共删除${returnInt}条记录!`;
//显示信息框
alert(strInfo);
}
else
{
var strInfo: string = `删除记录不成功!`;
//显示信息框
alert(strInfo);
}
console.log("完成DelRecord!");
}
catch(e)
{
console.error('catch(e)=');
console.error(e);
var strMsg: string = `删除记录不成功. ${e}.`;
alert(strMsg);
}
}

 /* 
 根据关键字选择相应的记录
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SelectRecord)
  <param name = "sender">参数列表</param>
*/
public async SelectRecord(strke_SuperId: string) 
{
try
{
const responseText = await ke_Super_GetObjByke_SuperIdAsync(strke_SuperId);
var objke_SuperEN: clske_SuperEN = <clske_SuperEN>responseText;
console.log("完成SelectRecord!");
clsCommonFunc4Web.Redirect("/Index/Main_ke_Super");
}
catch(e)
{
console.error(e);
var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
alert(strMsg);
}
}

 /* 修改记录
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecord_Click)
*/
    public async btnUpdateRecord_Click(strKeyId: string) {
this.OpType = "Update";
//var strKeyId = clsCommonFunc4Web.GetFirstCheckedKeyId();
    if (strKeyId == "")
{
alert("请选择需要修改的记录！");
return;
}
if (this.bolIsLoadEditRegion == false)  //
{
const responseBool = await this.AddDPV_Edit(this.divName4Edit);
 // 为编辑区绑定下拉框
const conBindDdl = await this.BindDdl4EditRegion();
ShowDialog('Update');
this.bolIsLoadEditRegion = true;  //
this.UpdateRecord(strKeyId);
}
else
{
ShowDialog('Update');
this.UpdateRecord(strKeyId);
}
}

 /* 删除记录
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecord_Click)
*/
public async btnDelRecord_Click() {
try
{
var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
alert("请选择需要删除的记录！");
return "";
}
const responseText = await this.DelMultiRecord(arrKeyIds);
const responseBindGv = await this.BindGv_ke_Super();
}
catch(e)
{
console.error('catch(e)=');
console.error(e);
var strMsg: string = `删除记录不成功. ${e}.`;
alert(strMsg);
}
}

 /* 根据条件获取相应的对象列表
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnExportExcel_Click)
*/
public async btnExportExcel_Click() 
{
var strWhereCond =" 1=1 ";
try
{
const responseText = await ke_Super_GetObjLstAsync(strWhereCond).then((jsonData)=>{
var arrke_SuperObjLst : Array<clske_SuperEN> = < Array<clske_SuperEN>>jsonData;
this.BindTab_ke_Super(this.mstrListDiv, arrke_SuperObjLst);
});
}
catch(e)
{
console.error('catch(e)=');
console.error(e);
var strMsg: string = `导出Excel不成功,${e}.`;
alert(strMsg);
}
}

 /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
  具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
*/
public async btnOKUpd_Click()
{
var strCommandText: string = this.btnOKUpd;
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
    const responseText3 = await this.AddNewRecordWithMaxIdSave().then((jsonData) => {
        var returnKeyId: string = <string>jsonData;
        if (clsString.IsNullOrEmpty(returnKeyId) == false) {
HideDialog();
this.BindGv_ke_Super();
}
});
}
else
{
const responseText2 = await this.AddNewRecordSave().then((jsonData)=>{
var returnBool: boolean = jsonData;
if (returnBool == true)
{
HideDialog();
this.BindGv_ke_Super();
}
});
}
break;
case "确认修改":
//这是一个单表的修改的代码,由于逻辑层太简单,
const responseText3 = await this.UpdateRecordSave().then((jsonData)=>{
var returnBool: boolean = jsonData;
var strInfo: string = returnBool ? "修改成功！" : "修改不成功！";
strInfo += "(In ke_SuperCRUD.btnOKUpd_Click)";
$('#lblResult51').val(strInfo);
//显示信息框
console.log(strInfo);
alert(strInfo);
if (returnBool == true)
{
HideDialog();
this.BindGv_ke_Super();
}
});
break;
default:
var strMsg = `strCommandText:${strCommandText}在switch中没有处理！(In btnOKUpd_Click())`
alert(strMsg);
break;
}
}
catch (e)
{
var strMsg: string = `(errid: WiTsCs0033)在保存记录时(${ strCommandText})时出错!请联系管理员!${ e}`;
alert(strMsg);
}
}

 /* 把所有的查询控件内容组合成一个条件串
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
  <returns>条件串(strWhereCond)</returns>
*/
 public Combineke_SuperCondition():string 
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && userName = '张三'
var strWhereCond: string = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
try
{
}
catch(objException)
{
var strMsg:string = `(errid:WiTsCs0002)在组合查询条件(Combineke_SuperCondition)时出错!请联系管理员!${objException}`;
throw strMsg;
}
return strWhereCond;
}

 /* 把所有的查询控件内容组合成一个条件串
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
  <returns>条件串(strWhereCond)</returns>
*/
 public Combineke_SuperConditionObj():clske_SuperEN 
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && userName = '张三'
var strWhereCond: string = " 1 = 1 ";
var objke_Super_Cond: clske_SuperEN = new clske_SuperEN();
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
try
{
}
catch(objException)
{
var strMsg:string = `(errid:WiTsCs0008)在组合查询条件对象(Combineke_SuperConditionObj)时出错!请联系管理员!${objException}`;
throw strMsg;
}
return objke_Super_Cond;
}

 /* 显示ke_Super对象的所有属性值
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
  <param name = "divContainer">显示容器</param>
  <param name = "arrke_SuperObjLst">需要绑定的对象列表</param>
*/
public BindTab_ke_Super(divContainer: string, arrke_SuperObjLst: Array<clske_SuperEN>) 
{
var o: HTMLDivElement = document.getElementById(divContainer) as HTMLDivElement;
if (o == null)
{
alert(`${divContainer}不存在！`);
return;
}
var arrDataColumn: Array < clsDataColumn > =
       [
{
FldName: "",
ColHeader: "",
Text: "",TdClass: "text-left",SortBy: "",
ColumnType: "CheckBox",
orderNum: 1,
FuncName: () => { }
},
{
FldName: "ke_SuperId",
ColHeader: "知识经济父类Id",
Text: "",TdClass: "text-left",SortBy: "",
ColumnType: "Label",
orderNum: 1,
FuncName: () => { }
},
{
FldName: "ke_SuperName_cn",
ColHeader: "知识经济父类名称cn",
Text: "",TdClass: "text-left",SortBy: "",
ColumnType: "Label",
orderNum: 1,
FuncName: () => { }
},
{
FldName: "ke_SuperName_en",
ColHeader: "知识经济父类名称en",
Text: "",TdClass: "text-left",SortBy: "",
ColumnType: "Label",
orderNum: 1,
FuncName: () => { }
},
{
FldName: "ke_SuperDescribe_cn",
ColHeader: "知识经济父类描述cn",
Text: "",TdClass: "text-left",SortBy: "",
ColumnType: "Label",
orderNum: 1,
FuncName: () => { }
},
{
FldName: "ke_SuperDescribe_en",
ColHeader: "知识经济父类描述en",
Text: "",TdClass: "text-left",SortBy: "",
ColumnType: "Label",
orderNum: 1,
FuncName: () => { }
},
{
FldName: "updDate",
ColHeader: "修改日期",
Text: "",TdClass: "text-left",SortBy: "",
ColumnType: "Label",
orderNum: 1,
FuncName: () => { }
},
{
FldName: "updUser",
ColHeader: "修改人",
Text: "",TdClass: "text-left",SortBy: "",
ColumnType: "Label",
orderNum: 1,
FuncName: () => { }
},
{
FldName: "",
ColHeader: "修改",
Text: "修改",TdClass: "text-left",SortBy: "",
ColumnType: "Button",
orderNum: 1,
FuncName: (strKeyId: string, strText: string) => { 
var btn1: HTMLElement = document.createElement("button");
btn1.innerText = strText;
btn1.className = "btn btn-outline-info btn-sm";
btn1.setAttribute("onclick", `btnUpdateRecordInTab_Click('${strKeyId}');`);
return btn1;
}
},
{
FldName: "",
ColHeader: "删除",
Text: "删除",TdClass: "text-left",SortBy: "",
ColumnType: "Button",
orderNum: 1,
FuncName: (strKeyId: string, strText: string) => { 
var btn1: HTMLElement = document.createElement("button");
btn1.innerText = strText;
btn1.className = "btn btn-outline-info btn-sm";
btn1.setAttribute("onclick", `btnDelRecordInTab_Click('${strKeyId}');`);
return btn1;
}
},
];
clsCommonFunc4Web.BindTabV2(o, arrke_SuperObjLst, arrDataColumn, "ke_SuperId"); 
this.objPager.RecCount = this.RecCount;
this.objPager.pageSize = this.pageSize;
    this.objPager.ShowPagerV2(this, this.divName4Pager);
}

 /* 函数功能:在数据 列表中跳转到某一页
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
  <param name = "intPageIndex">页序号</param>
*/
public async IndexPage(intPageIndex)
{
if (intPageIndex == 0)
{
intPageIndex = this.objPager.PageCount;
}
console.log("跳转到" + intPageIndex + "页");
this.setCurrPageIndex(intPageIndex, this.divName4Pager);
this.BindGv_ke_Super();
}

 /* 根据条件获取相应的对象列表
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
*/
public async BindGv_ke_Super() 
{
var strListDiv: string = this.mstrListDiv;
var strWhereCond = this.Combineke_SuperCondition();
var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
 var arrke_SuperObjLst: Array <clske_SuperEN> = [];
try
{
const responseRecCount = await ke_Super_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
this.RecCount = jsonData;
});
var objPagerPara: stuPagerPara = {
pageIndex: intCurrPageIndex,
pageSize: this.pageSize,
whereCond: strWhereCond,
    orderBy: this.hidSortke_SuperBy,
    sortFun: (x, y) => { return 0; }
};
const responseObjLst = await ke_Super_GetObjLstByPagerAsync(objPagerPara).then((jsonData)=>{
arrke_SuperObjLst = < Array<clske_SuperEN>>jsonData;
});
}
catch(e)
{
console.error('catch(e)=');
console.error(e);
var strMsg: string = `绑定GridView不成功,${e}.`;
alert(strMsg);
}
if (arrke_SuperObjLst.length == 0)
{
var strMsg: string = `在绑定Gv_Cache过程中，根据条件获取的对象列表数为0！`;
alert(strMsg);
return;
}
try
{
this.BindTab_ke_Super(strListDiv, arrke_SuperObjLst);
console.log("完成BindGv_ke_Super!");
}
catch(e)
{
console.error('catch(e)=');
console.error(e);
var strMsg: string =`绑定对象列表不成功.Error Massage:${e}.`;
alert(strMsg);
}
}

 /* 根据条件获取相应的对象列表
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv_Cache)
*/
public async BindGv_ke_Super_Cache() 
{
var strListDiv: string = this.mstrListDiv;
var objke_Super_Cond = this.Combineke_SuperConditionObj();
    var strWhereCond = JSON.stringify(objke_Super_Cond);
var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
 var arrke_SuperObjLst: Array <clske_SuperEN> = [];
try
{
this.RecCount = await ke_Super_GetRecCountByCond_Cache(objke_Super_Cond);
var objPagerPara: stuPagerPara = {
pageIndex: intCurrPageIndex,
pageSize: this.pageSize,
whereCond: strWhereCond,
    orderBy: this.hidSortke_SuperBy,
    sortFun: (x, y) => { return 0; }
};
var arrke_SuperObjLst = await ke_Super_GetObjLstByPager_Cache(objPagerPara);
}
catch(e)
{
console.error('catch(e)=');
console.error(e);
var strMsg: string = `绑定GridView不成功,${e}.`;
alert(strMsg);
return;
}
if (arrke_SuperObjLst.length == 0)
{
var strMsg: string = `在BindGv_Cache过程中，根据条件对象获取的对象列表数为0！(Key=ke_Super)`;
alert(strMsg);
return;
}
try
{
this.BindTab_ke_Super(strListDiv, arrke_SuperObjLst);
console.log("完成BindGv_ke_Super!");
}
catch(e)
{
console.error('catch(e)=');
console.error(e);
var strMsg: string =`绑定对象列表不成功.Error Massage:${e}.`;
alert(strMsg);
}
}

 /* 函数功能:从界面列表中根据某一个字段排序
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SortBy)
  <param name = "strSortByFld">排序的字段</param>
*/
public async SortBy(strSortByFld: string) {
if (this.hidSortke_SuperBy.indexOf(strSortByFld) >= 0)
{
if (this.hidSortke_SuperBy.indexOf("Asc") >= 0)
{
this.hidSortke_SuperBy = `${ strSortByFld} Desc`;
}
else
{
this.hidSortke_SuperBy = `${ strSortByFld} Asc`;
}
}
else
{
this.hidSortke_SuperBy = `${ strSortByFld} Asc`;
}
const responseBindGv = await this.BindGv_ke_Super();
}

/// <summary>
/// 在用户自定义控件中，设置关键字的值，是否只读
 /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SetKeyReadOnly)
/// </summary>
/// <param name = "bolReadonly">是否只读</param>
public SetKeyReadOnly(bolReadonly:boolean)
{
$('#txtke_SuperId').prop['ReadOnly'] = bolReadonly;
}

/// <summary>
/// 清除用户自定义控件中，所有控件的值
 /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Clear)
/// </summary>	
public Clear()
{
}

// /* 获取当前表关键字值的最大值,再加1,避免重复
//  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetMaxStrId)
//*/
//public async GetMaxStrId(strKeyCtrlName) {
//this.DivName = "divGetMaxStrId";
//try
//{
//const responseText = await ke_Super_GetMaxStrIdAsync();
//var returnString: string = responseText.toString();
//if (returnString == "")
//{
//var strInfo: string = `获取表ke_Super的最大关键字为空，不成功，请检查!`;
//$('#lblResult40').val(strInfo);
////显示信息框
//alert(strInfo);
// $(strKeyCtrlName).val(returnString);
//}
//else
//{
//var strInfo: string = `获取表ke_Super的最大关键字为：${returnString}!`;
//$('#lblResult40').val(strInfo);
////显示信息框
//alert(strInfo);
// $(strKeyCtrlName).val(returnString);
//}
//}
//catch(e)
//{
//console.error('catch(e)=');
//console.error(e);
//var strMsg: string = `获取表关键字的最大值不成功,${e}.`;
//alert(strMsg);
//}
//}

 /* 为插入记录做准备工作
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
*/
public async AddNewRecord()
{
this.SetKeyReadOnly(false);
this.btnOKUpd = "确认添加";
this.btnCancel = "取消添加";
this.Clear();
//wucke_SuperB1.ke_SuperId = clske_SuperBL.GetMaxStrId_S();
}

 /* 为插入记录做准备工作
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxId)
*/
public AddNewRecordWithMaxId()
{
this.SetKeyReadOnly(false);
this.btnOKUpd = "确认添加";
this.btnCancel = "取消添加";
this.Clear();
//wucke_SuperB1.ke_SuperId = clske_SuperBL.GetMaxStrId_S();
}

 /* 函数功能:把界面上的属性数据传到类对象中
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
  <param name = "pobjke_SuperEN">数据传输的目的类对象</param>
*/
public PutDataToke_SuperClass(pobjke_SuperEN: clske_SuperEN)
{
pobjke_SuperEN.ke_SuperId = this.ke_SuperId;// 知识经济父类Id
pobjke_SuperEN.ke_SuperName_cn = this.ke_SuperName_cn;// 知识经济父类名称cn
pobjke_SuperEN.ke_SuperName_en = this.ke_SuperName_en;// 知识经济父类名称en
pobjke_SuperEN.ke_SuperDescribe_cn = this.ke_SuperDescribe_cn;// 知识经济父类描述cn
pobjke_SuperEN.ke_SuperDescribe_en = this.ke_SuperDescribe_en;// 知识经济父类描述en
pobjke_SuperEN.memo = this.memo;// 备注
    pobjke_SuperEN.updUser = clsPubSessionStorage.GetSession_UserId();// 修改人
    pobjke_SuperEN.updDate = clsPubFun4Web.getNowDate();// 修改日期
}


 /* 添加新记录，保存函数
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
*/
public async AddNewRecordSave(){
this.DivName = "divAddNewRecordSave";
var objke_SuperEN: clske_SuperEN = new clske_SuperEN();
   this.PutDataToke_SuperClass(objke_SuperEN);
try
{
const responseText = await ke_Super_IsExistAsync(objke_SuperEN.ke_SuperId);
var bolIsExist: boolean = responseText;
if (bolIsExist == true)
{
var strMsg: string = `添加记录时，关键字：${objke_SuperEN.ke_SuperId }已经存在！`;
alert(strMsg);
return responseText;//一定要有一个返回值，否则会出错！
}
const responseText2 = await ke_Super_AddNewRecordAsync(objke_SuperEN);
var returnBool: boolean = !!responseText2;
if (returnBool == true)
{
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
console.error('catch(e)=');
console.error(e);
var strMsg: string = `添加记录不成功,${e}.`;
alert(strMsg);
return false;//一定要有一个返回值，否则会出错！
}
}

 /* 添加新记录，由后台自动获取最大值的关键字。保存函数
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxIdSave)
*/
public async AddNewRecordWithMaxIdSave(){
this.DivName = "divAddNewRecordWithMaxIdSave";
var objke_SuperEN: clske_SuperEN = new clske_SuperEN();
   this.PutDataToke_SuperClass(objke_SuperEN);
try
{
const responseText2 = await ke_Super_AddNewRecordWithMaxIdAsync(objke_SuperEN);
var returnBool: boolean = !!responseText2;
if (returnBool == true)
{
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
return responseText2;//一定要有一个返回值，否则会出错！
}
catch(e)
{
console.error('catch(e)=');
console.error(e);
var strMsg: string = `添加记录不成功,${e}.`;
alert(strMsg);
return false;
}
return true;//一定要有一个返回值，否则会出错！
}

 /* 函数功能:把以该关键字的记录内容显示在界面上,
 　　　   在这里是把值传到表控件中
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ShowData)
  <param name = "strke_SuperId">表记录的关键字,显示该表关键字的内容</param>
*/
  public async ShowData(strke_SuperId: string) {
        //操作步骤:
        //1、检查关键字是否为空；
        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
        //3、用提供的关键字初始化一个类对象；
        //4、获取类对象的所有属性；
        //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
        var objke_SuperEN: clske_SuperEN = new clske_SuperEN();
        try {
            const responseText = await ke_Super_IsExistAsync(strke_SuperId);
            var returnBool: boolean = responseText;
            if (returnBool == false) {
                var strInfo: string = `关键字:[${ strke_SuperId }] 的记录不存在!`;
                //$('#lblResult1').val(strInfo);
                //显示信息框
                alert(strInfo);
            }
            else {
            }
        }
        catch (e) {
            var strMsg: string = `检查相应关键字的记录存在不成功, ${e}.`;
            alert(strMsg);
        }
        try {
            const responseText = await ke_Super_GetObjByke_SuperIdAsync(strke_SuperId);
            objke_SuperEN = <clske_SuperEN>responseText;
        }
        catch (e) {
            var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
            alert(strMsg);
        }
        //3、用提供的关键字初始化一个类对象；
        this.GetDataFromke_SuperClass(objke_SuperEN);
}

 /* 函数功能:把类对象的属性内容显示到界面上
 注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
  如果在设置数据库时,就应该一级字段在前,二级字段在后
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
  <param name = "pobjke_SuperEN">表实体类对象</param>
*/
public GetDataFromke_SuperClass(pobjke_SuperEN: clske_SuperEN )
{
 this.ke_SuperId = pobjke_SuperEN.ke_SuperId;// 知识经济父类Id
 this.ke_SuperName_cn = pobjke_SuperEN.ke_SuperName_cn;// 知识经济父类名称cn
 this.ke_SuperName_en = pobjke_SuperEN.ke_SuperName_en;// 知识经济父类名称en
 this.ke_SuperDescribe_cn = pobjke_SuperEN.ke_SuperDescribe_cn;// 知识经济父类描述cn
 this.ke_SuperDescribe_en = pobjke_SuperEN.ke_SuperDescribe_en;// 知识经济父类描述en
 this.memo = pobjke_SuperEN.memo;// 备注
}

 /* 根据关键字获取相应的记录的对象
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
  <param name = "sender">参数列表</param>
*/
public async UpdateRecord(strke_SuperId: string) 
{
this.btnOKUpd = "确认修改";
this.btnCancel = "取消修改";
this.KeyId = strke_SuperId;
try
{
const responseText = await ke_Super_GetObjByke_SuperIdAsync(strke_SuperId);
var objke_SuperEN: clske_SuperEN = <clske_SuperEN>responseText;
this.GetDataFromke_SuperClass(objke_SuperEN);
console.log("完成UpdateRecord!");
}
catch(e)
{
console.error(e);
var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
alert(strMsg);
}
}

 /* 修改记录
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
*/
public async UpdateRecordSave() {
this.DivName = "divUpdateRecordSave";
var objke_SuperEN: clske_SuperEN = new clske_SuperEN();
objke_SuperEN.ke_SuperId = this.KeyId;
   this.PutDataToke_SuperClass(objke_SuperEN);
objke_SuperEN.sf_UpdFldSetStr = objke_SuperEN.updFldString;//设置哪些字段被修改(脏字段)
if (objke_SuperEN.ke_SuperId == "" || objke_SuperEN.ke_SuperId == undefined){
throw "关键字不能为空!";
}
try
{
const responseText = await ke_Super_UpdateRecordAsync(objke_SuperEN);
var returnBool: boolean = !!responseText;
if (returnBool == true)
{
}
return returnBool;
}
catch(e)
{
console.error('catch(e)=');
console.error(e);
var strMsg: string = `修改记录不成功,${e}.`;
alert(strMsg);
return false;
}
}

 /* 根据关键字列表删除记录
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelMultiRecord)
*/
public async DelMultiRecord(arrke_SuperId: Array<string>) {
try
{
const responseText = await ke_Super_Delke_SupersAsync(arrke_SuperId);
var returnInt: number = responseText;
if (returnInt > 0)
{
var strInfo: string = `删除记录成功,共删除${returnInt}条记录!`;
//显示信息框
alert(strInfo);
}
else
{
var strInfo: string = `删除记录不成功!`;
//显示信息框
alert(strInfo);
}
console.log("完成DelMultiRecord!");
}
catch(e)
{
console.error('catch(e)=');
console.error(e);
var strMsg: string = `删除记录不成功. ${e}.`;
alert(strMsg);
}
}

 /* 显示{0}对象的所有属性值
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ShowTabObj)
  <param name = "divContainer">显示容器</param>
  <param name = "objke_Super">需要显示的对象</param>
*/
public Showke_SuperObj(divContainer: string, objke_Super: clske_SuperEN) 
{
var o = document.getElementById(divContainer);
if (o == null)
{
alert(`${divContainer}不存在！`);
return;
}
var sstrKeys = clsCommonFunc4Web.GetObjKeys(objke_Super);
var ul: HTMLUListElement = document.createElement("ul");
for (let strKey of sstrKeys)
{
var strValue = objke_Super[strKey];
var li: HTMLLIElement = document.createElement("li");
li.innerHTML = `${ strKey}:${ strValue}`;
ul.appendChild(li);
}
o.appendChild(ul);
}

 /* 函数功能:从界面列表中获取第一个关键字的值
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetFirstKey)
  <param name = "pobjke_SuperEN">表实体类对象</param>
 <returns>列表的第一个关键字值</returns>
*/
public GetFirstKey(): string {
if (arrSelectedKeys.length == 1) {
return arrSelectedKeys[0];
}
else {
alert(`请选择一个关键字！目前选择了:${ arrSelectedKeys.length}个关键字。`);
return "";
}
}

/*
演示Session 操作
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Demo_Session)
*/
public async Demo_Session()
{
try
{
//设置Session
var strUserId = "TestUserId";
await this.SetSessionAsync("userId", strUserId);
//获取Session
var strUserId_Value1 = await this.GetSessionAsync("userId");
console.log('strUserId_Value1:' + strUserId_Value1);
//获取Session方法2：直接读取页面中的hidUserId
var strUserId_Value2 = this.hidUserId;
console.log('strUserId_Value2:' + strUserId_Value2);
}
catch (e)
{
var strMsg: string = `演示Session不成功,${e}.`;
alert(strMsg);
}
}

/*
设置Session
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SetSessionAsync)
<param name = "Key">关键字</param>
<param name = "Value">值</param>
*/
public SetSessionAsync(Key: string, Value: string): Promise<void> {
return new Promise(function(resolve, reject) {
            $.ajax({
url: strUrl_Session_SetString,
cache: false,
async: false,
type: 'get',
dataType: "json",
data: {
Key: Key,
Value: Value
},
success: function (data) {
var strKey = data.key;
var strValue = data.value;
console.log('strKey, strValue=' + strKey + strValue);
}
});
});
}

/*
获取Session 关键字的值
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetSessionAsync)
<param name = "Key">关键字</param>
 <return>值</return>
*/
public GetSessionAsync(Key: string): Promise<string> {
return new Promise(function(resolve, reject) {
            $.ajax({
url: strUrl_Session_GetString,
cache: false,
async: false,
type: 'get',
dataType: "json",
data: {
Key: Key,
},
success: function (data) {
var strKey = data.key;
var strValue = data.value;
console.log('strKey, strValue=' + strKey + strValue);
resolve(data);
},
error: function(result) {
console.log(result);
console.log(JSON.stringify(result));
if (result.statusText == "error")
{
var strInfo = `网络错误！访问网络不成功！`;
reject(strInfo);
}
else
{
reject(result.statusText);
}
}
});
});
}
 /*
 * 设置取消按钮的标题
*/
public set btnCancel(value: string) {
$("#btnCancel").html(value);
}
 /*
 * 获取按钮的标题
*/
public get btnOKUpd():string {
return $("#btnOKUpd").html();
}
 /*
 * 设置确定按钮的标题
*/
public set btnOKUpd(value: string) {
$("#btnOKUpd").html(value);
}

 /*
 * 添加、修改用的层名
*/
public set DivName(value: string) {
$("#hidDivName").val(value);
}
 /*
 * 设置排序字段-相当使用ViewState功能
*/
public set hidSortke_SuperBy(value: string) {
$("#hidSortke_SuperBy").val(value);
}
 /*
 * 设置排序字段
*/
public get hidSortke_SuperBy():string {
return $("#hidSortke_SuperBy").val();
}
 /*
 * 用户Id
*/
public get hidUserId():string {
return $("#hidUserId").val();
}
 /*
 * 知识经济父类描述cn
*/
public set ke_SuperDescribe_cn(value: string) {
$("#txtke_SuperDescribe_cn").val(value);
}
 /*
 * 知识经济父类描述cn
*/
public get ke_SuperDescribe_cn():string {
return $("#txtke_SuperDescribe_cn").val();
}
 /*
 * 知识经济父类描述en
*/
public set ke_SuperDescribe_en(value: string) {
$("#txtke_SuperDescribe_en").val(value);
}
 /*
 * 知识经济父类描述en
*/
public get ke_SuperDescribe_en():string {
return $("#txtke_SuperDescribe_en").val();
}
 /*
 * 知识经济父类Id
*/
public set ke_SuperId(value: string) {
$("#txtke_SuperId").val(value);
}
 /*
 * 知识经济父类Id
*/
public get ke_SuperId():string {
return $("#txtke_SuperId").val();
}
 /*
 * 知识经济父类名称cn
*/
public set ke_SuperName_cn(value: string) {
$("#txtke_SuperName_cn").val(value);
}
 /*
 * 知识经济父类名称cn
*/
public get ke_SuperName_cn():string {
return $("#txtke_SuperName_cn").val();
}
 /*
 * 知识经济父类名称en
*/
public set ke_SuperName_en(value: string) {
$("#txtke_SuperName_en").val(value);
}
 /*
 * 知识经济父类名称en
*/
public get ke_SuperName_en():string {
return $("#txtke_SuperName_en").val();
}
 /*
 * 设置关键字的值
*/
public set KeyId(value: string) {
$("#hidKeyId").val(value);
}
 /*
 * 设置关键字的值
*/
public get KeyId():string {
return $("#hidKeyId").val();
}
 /*
 * 备注
*/
public set memo(value: string) {
$("#txtMemo").val(value);
}
 /*
 * 备注
*/
public get memo():string {
return $("#txtMemo").val();
}
 /*
 * 设置操作类型：Add||Update||Detail
*/
public set OpType(value: string) {
$("#hidOpType").val(value);
}
 /*
 * 设置操作类型：Add||Update||Detail
*/
public get OpType():string {
return $("#hidOpType").val();
}
 /*
 * 修改人
*/
public get updUser():string {
return $("#txtUpdUser").val();
}
}