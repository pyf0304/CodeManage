﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:gs_ReflectLogCRUD(界面:gs_ReflectLogCRUD)
 表名:gs_ReflectLog(01120702)
 生成代码版本:2021.06.06.1
 生成日期:2021/06/11 12:27:10
 生成者:
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
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
import { clsgs_ReflectLogEN } from "../TS/L0_Entity/GraduateEduTopic/clsgs_ReflectLogEN.js";
import { gs_ReflectLog_AddNewRecordAsync, gs_ReflectLog_Delgs_ReflectLogsAsync, gs_ReflectLog_DelRecordAsync, gs_ReflectLog_GetObjBymIdAsync, gs_ReflectLog_GetObjLstAsync, gs_ReflectLog_GetObjLstBymIdLstAsync, gs_ReflectLog_GetObjLstByPagerAsync, gs_ReflectLog_GetObjLstByPager_Cache, gs_ReflectLog_GetRecCountByCondAsync, gs_ReflectLog_GetRecCountByCond_Cache, gs_ReflectLog_GetSubObjLst_Cache, gs_ReflectLog_ReFreshCache, gs_ReflectLog_SortFun_Defa } from "../TS/L3_ForWApi/GraduateEduTopic/clsgs_ReflectLogWApi.js";
import { arrSelectedKeys, clsCommonFunc4Web } from "../TS/PubFun/clsCommonFunc4Web2.js";
import { clsDataColumn } from "../TS/PubFun/clsDataColumn.js";
import { clsOperateList } from "../TS/PubFun/clsOperateList.js";
import { Format, IsNullOrEmpty } from "../TS/PubFun/clsString.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";
 /*
* 宣布一个用于导出Excel的函数，用于调用js端的导出Excel。
*/
declare function exportSpecialExcel_pyf(arrData, strFileName): void;
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
 /* gs_ReflectLogCRUD 的摘要说明。其中Q代表查询,U代表修改
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
*/
export abstract class gs_ReflectLogCRUD implements clsOperateList
{
public static objPage_CRUD: gs_ReflectLogCRUD;
public divName4Query: string = "divQuery";  //查询区的层Id
public divName4Function: string = "divFunction";  //功能区的层Id
constructor() {
super();
gs_ReflectLogCRUD.objPage_CRUD = this;
}
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
this.SetEventFunc();
 // 为查询区绑定下拉框
const gvBindDdl = await this.BindDdl4QueryRegion();

this.hidSortgs_ReflectLogBy = "reflectLogName Asc";
if (this.bolIsInitShow == false)  //
{
this.objPager.InitShow(this.divName4Pager);
this.bolIsInitShow = true;  //
}
//2、显示无条件的表内容在GridView中
const responseBindGv = await this.BindGv_gs_ReflectLog();
}
catch (e)
{
var strMsg: string = `页面启动不成功,${e}.`;
console.error("Error: ", strMsg);
//console.trace();
alert(strMsg);
}
}





 /* 函数功能:设置事件函数
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SetEventFunc)
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


 /* 函数功能:页面导入,当页面开始运行时所发生的事件
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load_Cache)
*/
public async Page_Load_Cache()
{
// 在此处放置用户代码以初始化页面
try
{
 // 为查询区绑定下拉框
const gvBindDdl = await this.BindDdl4QueryRegion();

this.SetEventFunc();
this.hidSortgs_ReflectLogBy = "reflectLogName Asc";
if (this.bolIsInitShow == false)  //
{
this.objPager.InitShow(this.divName4Pager);
this.bolIsInitShow = true;  //
}
//2、显示无条件的表内容在GridView中
const responseBindGv = await this.BindGv_gs_ReflectLog();
}
catch (e)
{
var strMsg: string = `页面启动不成功,${e}.`;
console.error("Error: ", strMsg);
//console.trace();
alert(strMsg);
}
}


 /* 根据条件获取相应的对象列表
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
*/
public async btnQuery_Click() 
{
this.setCurrPageIndex(1, this.divName4Pager);
const responseBindGv = await this.BindGv_gs_ReflectLog();
}

 /* 合并数据
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineData)
*/
public CombineData(arrgs_ReflectLogObjLst: Array<clsgs_ReflectLogEN>, arrDataColumn: Array<clsDataColumn>) 
{
var intRowNum = arrgs_ReflectLogObjLst.length;
var intColNum = arrDataColumn.length;
var arrData: Array < Array < any >> = new Array<Array<any>>();
var arrHead: Array < any > = new Array<any>();
for (var j = 0; j < intColNum; j++)
{
arrHead.push(arrDataColumn[j].ColHeader);
}
arrData.push(arrHead);
for (var i = 0; i < intRowNum; i++)
{
var arrRow: Array < any > = new Array<any>();
var objEN: object = arrgs_ReflectLogObjLst[i];
for (var j = 0; j < intColNum; j++)
{
arrRow.push(objEN[arrDataColumn[j].FldName]);//i + "" + j;
}
arrData.push(arrRow);
}
console.log("arrData", arrData);
var strFileName = clsString.Format("反思日志({0})导出.xlsx",
 clsgs_ReflectLogEN._CurrTabName);
exportSpecialExcel_pyf(arrData, strFileName);
}

 /* 根据条件获取相应的对象列表
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ExportExcel_Cache)
*/
public async ExportExcel_gs_ReflectLog_Cache() 
{
if (this.hidSortgs_ReflectLogBy == null)
{
var strMsg = `在显示列表时，排序字段(hidSortgs_ReflectLogBy)为空，请检查！(In BindGv_gs_ReflectLog_Cache)`;
console.error(strMsg);
alert(strMsg);
return;
}
var strListDiv: string = this.mstrListDiv;
var objgs_ReflectLog_Cond = this.Combinegs_ReflectLogConditionObj4ExportExcel();
    var strWhereCond = JSON.stringify(objgs_ReflectLog_Cond);
var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
 var arrgs_ReflectLogObjLst: Array <clsgs_ReflectLogEN> = [];
try
{
this.RecCount = await gs_ReflectLog_GetRecCountByCond_Cache(objgs_ReflectLog_Cond);
if (this.RecCount == 0)
{
var lblMsg: HTMLSpanElement = < HTMLSpanElement > document.createElement("span");
lblMsg.innerHTML = clsString.Format("根据条件:[{0}]获取的对象列表数为0！", objgs_ReflectLog_Cond.whereCond);
var divDataLst: HTMLDivElement = <HTMLDivElement> document.getElementById("divDataLst");
if (divDataLst != null)
{
divDataLst.innerText = "";
divDataLst.appendChild(lblMsg);
}
var strMsg: string = `在绑定Gv_Cache过程中，根据条件:[${objgs_ReflectLog_Cond.whereCond}]获取的对象列表数为0！`;
console.error("Error: ", strMsg);
//console.trace();
alert(strMsg);
return;
}
var arrgs_ReflectLogObjLst = await gs_ReflectLog_GetSubObjLst_Cache(objgs_ReflectLog_Cond);
}
catch(e)
{
var strMsg: string = `绑定GridView不成功,${e}.`;
console.error(strMsg);
alert(strMsg);
return;
}
if (arrgs_ReflectLogObjLst.length == 0)
{
var strKey:string = `${clsgs_ReflectLogEN._CurrTabName}`;
var strMsg: string = `在BindGv_Cache过程中，根据条件对象获取的对象列表数为0！(Key=${strKey})`;
console.error("Error: ", strMsg);
//console.trace();
alert(strMsg);
return;
}
try
{
var arrDataColumn: Array < clsDataColumn > =
       [
{
FldName: "reflectLogName",
SortBy: "",
ColHeader: "标题",
Text: "",
TdClass: "text-left",
ColumnType: "Label",
orderNum: 3,
FuncName: () => { }
},
{
FldName: "reflectLogContent",
SortBy: "",
ColHeader: "内容",
Text: "",
TdClass: "text-left",
ColumnType: "Label",
orderNum: 4,
FuncName: () => { }
},
{
FldName: "updUser",
SortBy: "",
ColHeader: "修改人",
Text: "",
TdClass: "text-left",
ColumnType: "Label",
orderNum: 5,
FuncName: () => { }
},
{
FldName: "updDate",
SortBy: "",
ColHeader: "修改日期",
Text: "",
TdClass: "text-left",
ColumnType: "Label",
orderNum: 6,
FuncName: () => { }
},
{
FldName: "memo",
SortBy: "",
ColHeader: "备注",
Text: "",
TdClass: "text-left",
ColumnType: "Label",
orderNum: 7,
FuncName: () => { }
},
];
arrgs_ReflectLogObjLst = arrgs_ReflectLogObjLst.sort(this.SortFun_ExportExcel);
  this.CombineData(arrgs_ReflectLogObjLst, arrDataColumn); 
console.log("完成BindGv_gs_ReflectLog!");
}
catch(e)
{
var strMsg: string =`绑定对象列表不成功.Error Massage:${e}.`;
console.error(strMsg);
alert(strMsg);
}
}

 /* 根据条件获取相应的对象列表
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ExportExcel)
*/
public async ExportExcel_gs_ReflectLog() 
{
if (this.hidSortgs_ReflectLogBy == null)
{
var strMsg = `在显示列表时，排序字段(hidSortgs_ReflectLogBy)为空，请检查！(In BindGv_gs_ReflectLog_Cache)`;
console.error(strMsg);
alert(strMsg);
return;
}
var strListDiv: string = this.mstrListDiv;
var strWhereCond = this.Combinegs_ReflectLogCondition();
var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
 var arrgs_ReflectLogObjLst: Array <clsgs_ReflectLogEN> = [];
try
{
this.RecCount = await gs_ReflectLog_GetRecCountByCondAsync(strWhereCond);
if (this.RecCount == 0)
{
var lblMsg: HTMLSpanElement = < HTMLSpanElement > document.createElement("span");
lblMsg.innerHTML = clsString.Format("根据条件:[{0}]获取的对象列表数为0！", strWhereCond);
var divDataLst: HTMLDivElement = <HTMLDivElement> document.getElementById("divDataLst");
if (divDataLst != null)
{
divDataLst.innerText = "";
divDataLst.appendChild(lblMsg);
}
var strMsg: string = `在绑定ExportExcel过程中，根据条件:[${strWhereCond}]获取的对象列表数为0！`;
console.error("Error: ", strMsg);
//console.trace();
alert(strMsg);
return;
}
var arrgs_ReflectLogObjLst = await gs_ReflectLog_GetObjLstAsync(strWhereCond);
}
catch(e)
{
var strMsg: string = `绑定GridView不成功,${e}.`;
console.error(strMsg);
alert(strMsg);
return;
}
if (arrgs_ReflectLogObjLst.length == 0)
{
var strMsg: string = `在ExportExcel过程中，根据条件对象获取的对象列表数为0！`;
console.error("Error: ", strMsg);
//console.trace();
alert(strMsg);
return;
}
try
{
var arrDataColumn: Array < clsDataColumn > =
       [
{
FldName: "reflectLogName",
SortBy: "",
ColHeader: "标题",
Text: "",
TdClass: "text-left",
ColumnType: "Label",
orderNum: 3,
FuncName: () => { }
},
{
FldName: "reflectLogContent",
SortBy: "",
ColHeader: "内容",
Text: "",
TdClass: "text-left",
ColumnType: "Label",
orderNum: 4,
FuncName: () => { }
},
{
FldName: "updUser",
SortBy: "",
ColHeader: "修改人",
Text: "",
TdClass: "text-left",
ColumnType: "Label",
orderNum: 5,
FuncName: () => { }
},
{
FldName: "updDate",
SortBy: "",
ColHeader: "修改日期",
Text: "",
TdClass: "text-left",
ColumnType: "Label",
orderNum: 6,
FuncName: () => { }
},
{
FldName: "memo",
SortBy: "",
ColHeader: "备注",
Text: "",
TdClass: "text-left",
ColumnType: "Label",
orderNum: 7,
FuncName: () => { }
},
];
arrgs_ReflectLogObjLst = arrgs_ReflectLogObjLst.sort(this.SortFun_ExportExcel);
  this.CombineData(arrgs_ReflectLogObjLst, arrDataColumn); 
console.log("完成BindGv_gs_ReflectLog!");
}
catch(e)
{
var strMsg: string =`绑定对象列表不成功.Error Massage:${e}.`;
console.error(strMsg);
alert(strMsg);
}
}

 /* 函数功能:为查询区绑定下拉框
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4QueryRegion)
*/
public async BindDdl4QueryRegion()
{
// 在此处放置用户代码以初始化页面
}


 /*
  添加新记录
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnCopyRecord_Click)
 */
public async btnCopyRecord_Click() {
try
{
var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
alert("请选择需要克隆的记录！");
return "";
}
const responseText = await this.CopyRecord(arrKeyIds);
const responseBindGv = await this.BindGv_gs_ReflectLog();
}
catch(e)
{
var strMsg: string = `复制记录不成功,${e}.`;
console.error(strMsg);
alert(strMsg);
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
if (clsCommonFunc4Web.confirm_del(0) == false)
{
return;
}
var lngKeyId =  Number(strKeyId);
const responseText = await this.DelRecord(lngKeyId);
const responseBindGv = await this.BindGv_gs_ReflectLog();
}
catch(e)
{
var strMsg: string = `删除记录不成功. ${e}.`;
console.error(strMsg);
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
if (clsCommonFunc4Web.confirm_del(0) == false)
{
return;
}
var lngKeyId =  Number(strKeyId);
this.SelectRecord(lngKeyId);
}
catch(e)
{
var strMsg: string = `选择记录不成功. ${e}.`;
console.error(strMsg);
alert(strMsg);
}
}

 /* 
 根据关键字删除记录
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
*/
public async DelRecord(lngmId: number) {
try
{
const responseText = await gs_ReflectLog_DelRecordAsync(lngmId);
var returnInt: number = responseText;
if (returnInt > 0)
{
gs_ReflectLog_ReFreshCache();
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
var strMsg: string = `删除记录不成功. ${e}.`;
console.error(strMsg);
alert(strMsg);
}
}

 /* 
 根据关键字选择相应的记录
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SelectRecord)
  <param name = "sender">参数列表</param>
*/
public async SelectRecord(lngmId: number) 
{
try
{
const responseText = await gs_ReflectLog_GetObjBymIdAsync(lngmId);
var objgs_ReflectLogEN: clsgs_ReflectLogEN = <clsgs_ReflectLogEN>responseText;
console.log("完成SelectRecord!");
clsCommonFunc4Web.Redirect("/Index/Main_gs_ReflectLog");
}
catch(e)
{
var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
console.error("Error: ", strMsg);
//console.trace();
alert(strMsg);
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
if (clsCommonFunc4Web.confirm_del(arrKeyIds.length) == false)
{
return;
}
const responseText = await this.DelMultiRecord(arrKeyIds);
const responseBindGv = await this.BindGv_gs_ReflectLog();
}
catch(e)
{
var strMsg: string = `删除记录不成功. ${e}.`;
console.error(strMsg);
alert(strMsg);
}
}

 /* 根据条件获取相应的对象列表
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnExportExcel_Click)
*/
public async btnExportExcel_Click() 
{
const responseBindGv = await this.ExportExcel_gs_ReflectLog_Cache();
}

 /* 把所有的查询控件内容组合成一个条件串
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
  <returns>条件串(strWhereCond)</returns>
*/
 public Combinegs_ReflectLogCondition():string 
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && userName = '张三'
var strWhereCond: string = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
try
{
if ( this.ReflectLogName_q != "")
{
strWhereCond += ` And ${ clsgs_ReflectLogEN.con_ReflectLogName} like '% ${ this.ReflectLogName_q }%'`;
}
}
catch(objException)
{
var strMsg:string = `(errid:WiTsCs0009)在组合查询条件(Combinegs_ReflectLogCondition)时出错!请联系管理员!${objException}`;
throw strMsg;
}
return strWhereCond;
}

 /* 把所有的查询控件内容组合成一个条件串
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
  <returns>条件串(strWhereCond)</returns>
*/
 public Combinegs_ReflectLogConditionObj():clsgs_ReflectLogEN 
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && userName = '张三'
var strWhereCond: string = " 1 = 1 ";
var objgs_ReflectLog_Cond: clsgs_ReflectLogEN = new clsgs_ReflectLogEN();
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
try
{
if ( this.ReflectLogName_q != "")
{
strWhereCond += ` And ${ clsgs_ReflectLogEN.con_ReflectLogName} like '% ${ this.ReflectLogName_q }%'`;
objgs_ReflectLog_Cond.SetCondFldValue(clsgs_ReflectLogEN.con_ReflectLogName, this.ReflectLogName_q, "like");
}
}
catch(objException)
{
var strMsg:string = `(errid:WiTsCs0010)在组合查询条件对象(Combinegs_ReflectLogConditionObj)时出错!请联系管理员!${objException}`;
throw strMsg;
}
objgs_ReflectLog_Cond.whereCond = strWhereCond;
return objgs_ReflectLog_Cond;
}

 /* 把所有的查询控件内容组合成一个条件串
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj4ExportExcel)
  <returns>条件串(strWhereCond)</returns>
*/
 public Combinegs_ReflectLogConditionObj4ExportExcel():clsgs_ReflectLogEN 
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && userName = '张三'
var strWhereCond: string = " 1 = 1 ";
var objgs_ReflectLog_Cond: clsgs_ReflectLogEN = new clsgs_ReflectLogEN();
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
try
{
if ( this.ReflectLogName_q != "")
{
strWhereCond += ` And ${ clsgs_ReflectLogEN.con_ReflectLogName} like '% ${ this.ReflectLogName_q }%'`;
objgs_ReflectLog_Cond.SetCondFldValue(clsgs_ReflectLogEN.con_ReflectLogName, this.ReflectLogName_q, "like");
}
}
catch(objException)
{
var strMsg:string = `(errid:WiTsCs0013)在组合导出Excel条件对象(Combinegs_ReflectLogConditionObj4ExportExcel)时出错!请联系管理员!${objException}`;
throw strMsg;
}
objgs_ReflectLog_Cond.whereCond = strWhereCond;
return objgs_ReflectLog_Cond;
}

 /* 显示gs_ReflectLog对象的所有属性值
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
  <param name = "divContainer">显示容器</param>
  <param name = "arrgs_ReflectLogObjLst">需要绑定的对象列表</param>
*/
public BindTab_gs_ReflectLog(divContainer: string, arrgs_ReflectLogObjLst: Array<clsgs_ReflectLogEN>) 
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
SortBy: "",
ColHeader: "",
Text: "",
TdClass: "text-left",
ColumnType: "CheckBox",
orderNum: 1,
FuncName: () => { }
},
{
FldName: "reflectLogName",
SortBy: "reflectLogName",
ColHeader: "标题",
Text: "",
TdClass: "text-left",
ColumnType: "Label",
orderNum: 2,
FuncName: () => { }
},
{
FldName: "reflectLogContent",
SortBy: "reflectLogContent",
ColHeader: "内容",
Text: "",
TdClass: "text-left",
ColumnType: "Label",
orderNum: 3,
FuncName: () => { }
},
{
FldName: "updUser",
SortBy: "updUser",
ColHeader: "修改人",
Text: "",
TdClass: "text-left",
ColumnType: "Label",
orderNum: 4,
FuncName: () => { }
},
{
FldName: "updDate",
SortBy: "updDate",
ColHeader: "修改日期",
Text: "",
TdClass: "text-left",
ColumnType: "Label",
orderNum: 5,
FuncName: () => { }
},
];
clsCommonFunc4Web.BindTabV4(o, arrgs_ReflectLogObjLst, arrDataColumn, "mId", this); 
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
const responseBindGv = await this.BindGv_gs_ReflectLog();
}

 /* 根据条件获取相应的对象列表
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
*/
public async BindGv_gs_ReflectLog() 
{
if (this.hidSortgs_ReflectLogBy == null)
{
var strMsg = `在显示列表时，排序字段(hidSortgs_ReflectLogBy)为空，请检查！(In BindGv_gs_ReflectLog)`;
console.error(strMsg);
alert(strMsg);
return;
}
var strListDiv: string = this.mstrListDiv;
var strWhereCond = this.Combinegs_ReflectLogCondition();
var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
 var arrgs_ReflectLogObjLst: Array <clsgs_ReflectLogEN> = [];
try
{
const responseRecCount = await gs_ReflectLog_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
this.RecCount = jsonData;
});
if (this.RecCount == 0)
{
var lblMsg: HTMLSpanElement = < HTMLSpanElement > document.createElement("span");
lblMsg.innerHTML = clsString.Format("根据条件:[{0}]获取的对象列表数为0！", strWhereCond);
var divDataLst: HTMLDivElement = < HTMLDivElement > document.getElementById("divDataLst");
if (divDataLst != null)
{
divDataLst.innerText = "";
divDataLst.appendChild(lblMsg);
}
var strMsg: string = `在绑定Gv过程中，根据条件:[${strWhereCond}]获取的对象列表数为0！`;
console.error("Error: ", strMsg);
//console.trace();
alert(strMsg);
return;
}
var intPageCount = this.objPager.GetPageCount(this.RecCount, this.pageSize);
if (intCurrPageIndex == 0)
{
if (intPageCount > 1) intCurrPageIndex = intPageCount;
else intCurrPageIndex = 1;
this.setCurrPageIndex(intCurrPageIndex, this.divName4Pager);
}
else if (intCurrPageIndex > intPageCount)
{
intCurrPageIndex = intPageCount;
this.setCurrPageIndex(intCurrPageIndex, this.divName4Pager);
}
var objPagerPara: stuPagerPara = {
pageIndex: intCurrPageIndex,
pageSize: this.pageSize,
whereCond: strWhereCond,
orderBy: this.hidSortgs_ReflectLogBy,//如果该字段为空，就使用下面的排序函数
sortFun: (x, y) => { return 0;}
};
const responseObjLst = await gs_ReflectLog_GetObjLstByPagerAsync(objPagerPara).then((jsonData)=>{
arrgs_ReflectLogObjLst = < Array<clsgs_ReflectLogEN>>jsonData;
});
}
catch(e)
{
var strMsg: string = `绑定GridView不成功,${e}.`;
console.error("Error: ", strMsg);
//console.trace();
alert(strMsg);
}
var divPager: HTMLDivElement = < HTMLDivElement > document.getElementById("divPager");
if (this.RecCount <= this.pageSize)
{
if (divPager != null)
{
divPager.style.display = "none";
}
}
else
{
if (divPager != null)
{
divPager.style.display = "block";
}
}
if (arrgs_ReflectLogObjLst.length == 0)
{
var lblMsg: HTMLSpanElement = < HTMLSpanElement > document.createElement("span");
lblMsg.innerHTML = "根据条件获取的对象列表数为0！";
var divDataLst: HTMLDivElement = < HTMLDivElement > document.getElementById("divDataLst");
if (divDataLst != null)
{
divDataLst.innerText = "";
divDataLst.appendChild(lblMsg);
}
var strMsg: string = `在绑定Gv_Cache过程中，根据条件获取的对象列表数为0！`;
console.error("Error: ", strMsg);
//console.trace();
alert(strMsg);
return;
}
try
{
this.BindTab_gs_ReflectLog(strListDiv, arrgs_ReflectLogObjLst);
console.log("完成BindGv_gs_ReflectLog!");
}
catch(e)
{
//console.trace();
var strMsg: string =`绑定对象列表不成功.Error Massage:${e}.`;
console.error(strMsg);
alert(strMsg);
}
}

 /* 根据条件获取相应的对象列表
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv_Cache)
*/
public async BindGv_gs_ReflectLog_Cache() 
{
if (this.hidSortgs_ReflectLogBy == null)
{
var strMsg = `在显示列表时，排序字段(hidSortgs_ReflectLogBy)为空，请检查！(In BindGv_gs_ReflectLog_Cache)`;
console.error(strMsg);
alert(strMsg);
return;
}
var strListDiv: string = this.mstrListDiv;
var objgs_ReflectLog_Cond = this.Combinegs_ReflectLogConditionObj();

    var strWhereCond = JSON.stringify(objgs_ReflectLog_Cond);
var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
 var arrgs_ReflectLogObjLst: Array <clsgs_ReflectLogEN> = [];
try
{
this.RecCount = await gs_ReflectLog_GetRecCountByCond_Cache(objgs_ReflectLog_Cond);
if (this.RecCount == 0)
{
var lblMsg: HTMLSpanElement = < HTMLSpanElement > document.createElement("span");
lblMsg.innerHTML = clsString.Format("根据条件:[{0}]获取的对象列表数为0！", objgs_ReflectLog_Cond.whereCond);
var divDataLst: HTMLDivElement = <HTMLDivElement> document.getElementById("divDataLst");
if (divDataLst != null)
{
divDataLst.innerText = "";
divDataLst.appendChild(lblMsg);
}
var strMsg: string = `在绑定Gv_Cache过程中，根据条件:[${objgs_ReflectLog_Cond.whereCond}]获取的对象列表数为0！`;
console.error("Error: ", strMsg);
//console.trace();
alert(strMsg);
return;
}
var intPageCount = this.objPager.GetPageCount(this.RecCount, this.pageSize);
if (intCurrPageIndex == 0)
{
if (intPageCount > 1) intCurrPageIndex = intPageCount;
else intCurrPageIndex = 1;
this.setCurrPageIndex(intCurrPageIndex, this.divName4Pager);
}
else if (intCurrPageIndex > intPageCount)
{
intCurrPageIndex = intPageCount;
this.setCurrPageIndex(intCurrPageIndex, this.divName4Pager);
}
var objPagerPara: stuPagerPara = {
pageIndex: intCurrPageIndex,
pageSize: this.pageSize,
whereCond: strWhereCond,
orderBy: this.hidSortgs_ReflectLogBy,//如果该字段为空，就使用下面的排序函数
sortFun: gs_ReflectLog_SortFun_Defa
};
var arrgs_ReflectLogObjLst = await gs_ReflectLog_GetObjLstByPager_Cache(objPagerPara);
}
catch(e)
{
var strMsg: string = `绑定GridView不成功,${e}.`;
console.error(strMsg);
alert(strMsg);
return;
}
var divPager: HTMLDivElement = < HTMLDivElement > document.getElementById("divPager");
if (this.RecCount <= this.pageSize)
{
if (divPager != null)
{
divPager.style.display = "none";
}
}
else
{
if (divPager != null)
{
divPager.style.display = "block";
}
}
if (arrgs_ReflectLogObjLst.length == 0)
{
var lblMsg: HTMLSpanElement = < HTMLSpanElement > document.createElement("span");
lblMsg.innerHTML = "根据条件获取的对象列表数为0！";
var divDataLst: HTMLDivElement = < HTMLDivElement > document.getElementById("divDataLst");
if (divDataLst != null)
{
divDataLst.innerText = "";
divDataLst.appendChild(lblMsg);
}
var strKey:string = `${clsgs_ReflectLogEN._CurrTabName}`;
var strMsg: string = `在BindGv_Cache过程中，根据条件对象获取的对象列表数为0！(Key=${strKey})`;
console.error("Error: ", strMsg);
//console.trace();
alert(strMsg);
return;
}
try
{
this.BindTab_gs_ReflectLog(strListDiv, arrgs_ReflectLogObjLst);
console.log("完成BindGv_gs_ReflectLog_Cache!");
}
catch(e)
{
var strMsg: string =`绑定对象列表不成功.Error Massage:${e}.`;
console.error(strMsg);
alert(strMsg);
}
}

 /// <summary>
 /// 排序函数。根据表对象中随机两个字段的值进行比较,正常使用时，需用该类的扩展类的同名函数
 /// 作者:pyf
 /// 日期:
 /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SortFunExportExcel)
 /// </summary>
 /// <param name = "a">比较的第1个对象</param>
 /// <param name = "b">比较的第1个对象</param>
 /// <returns>返回两个对象比较的结果</returns>
public SortFun_ExportExcel(a:clsgs_ReflectLogEN , b:clsgs_ReflectLogEN): number 
{
if (a.updDate == b.updDate) return a.updUser.localeCompare(b.updUser) ;
else return a.updDate.localeCompare(b.updDate);
}

 /* 函数功能:从界面列表中根据某一个字段排序
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SortBy)
  <param name = "objAnchorElement">带有排序字段的Anchors</param>
*/
public async SortBy(objAnchorElement) {
 console.log("objAnchorElement(In SetAllCkechedKeysV2):", objAnchorElement);
//event = window.event || event;
var thisEventObj: HTMLInputElement = objAnchorElement;
var strFldName: string = thisEventObj.getAttribute("FldName") as string;
  if (clsString.IsNullOrEmpty(strFldName) == true) return;
var strSortByFld: string = strFldName;
if (this.hidSortgs_ReflectLogBy.indexOf(strSortByFld) >= 0)
{
if (this.hidSortgs_ReflectLogBy.indexOf("Asc") >= 0)
{
this.hidSortgs_ReflectLogBy = `${ strSortByFld} Desc`;
}
else
{
this.hidSortgs_ReflectLogBy = `${ strSortByFld} Asc`;
}
}
else
{
this.hidSortgs_ReflectLogBy = `${ strSortByFld} Asc`;
}
const responseBindGv = await this.BindGv_gs_ReflectLog();
}

 /* 复制记录
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CopyRecord)
*/
public async CopyRecord(arrmId: Array<string>) {
try
{
const responseText = await gs_ReflectLog_GetObjLstBymIdLstAsync(arrmId);
console.log('responseText=');
console.log(responseText);
var intCount:number = 0;
var arrgs_ReflectLogObjLst: Array <clsgs_ReflectLogEN> = <Array<clsgs_ReflectLogEN>> responseText;
for (let objInFor of arrgs_ReflectLogObjLst)
{
const responseText2 = await gs_ReflectLog_AddNewRecordAsync(objInFor);
console.log('responseText2=');
console.log(responseText2);
var returnBool: boolean = !!responseText2;
if (returnBool == true)
{
gs_ReflectLog_ReFreshCache();
var strInfo: string = `克隆记录成功!`;
intCount++;
}
else
{
var strInfo: string = `克隆记录不成功!`;
//显示信息框
alert(strInfo);
}
}
var strInfo: string = `共克隆了${ intCount}条记录!`;
alert(strInfo);
console.log('完成！');
}
catch (e)
{
var strMsg: string = `复制记录不成功,${e}.`;
console.error("Error: ", strMsg);
//console.trace();
alert(strMsg);
}
}

 /* 根据关键字列表删除记录
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelMultiRecord)
*/
public async DelMultiRecord(arrmId: Array<string>) {
try
{
const responseText = await gs_ReflectLog_Delgs_ReflectLogsAsync(arrmId);
var returnInt: number = responseText;
if (returnInt > 0)
{
gs_ReflectLog_ReFreshCache();
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
var strMsg: string = `删除记录不成功. ${e}.`;
console.error(strMsg);
alert(strMsg);
}
}

 /* 显示{0}对象的所有属性值
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ShowTabObj)
  <param name = "divContainer">显示容器</param>
  <param name = "objgs_ReflectLog">需要显示的对象</param>
*/
public Showgs_ReflectLogObj(divContainer: string, objgs_ReflectLog: clsgs_ReflectLogEN) 
{
var o = document.getElementById(divContainer);
if (o == null)
{
alert(`${divContainer}不存在！`);
return;
}
var sstrKeys = clsCommonFunc4Web.GetObjKeys(objgs_ReflectLog);
var ul: HTMLUListElement = document.createElement("ul");
for (let strKey of sstrKeys)
{
var strValue = objgs_ReflectLog[strKey];
var li: HTMLLIElement = document.createElement("li");
li.innerHTML = `${ strKey}:${ strValue}`;
ul.appendChild(li);
}
o.appendChild(ul);
}

 /* 函数功能:从界面列表中获取第一个关键字的值
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetFirstKey)
  <param name = "pobjgs_ReflectLogEN">表实体类对象</param>
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
 * 设置排序字段-相当使用ViewState功能
*/
public  set hidSortgs_ReflectLogBy(value: string) {
$("#hidSortgs_ReflectLogBy").val(value);
}
 /*
 * 设置排序字段
*/
public  get hidSortgs_ReflectLogBy():string {
return $("#hidSortgs_ReflectLogBy").val();
}
 /*
 * 标题 (Used In CombineCondition())
*/
public  get ReflectLogName_q():string {
var objDiv = $(`#${ this.divName4Query }`);
    clsCommonFunc4Web.CheckControlExist(this.divName4Query, "input", "txtReflectLogName_q");
var strId = `input[id ^= "txtReflectLogName_q"]`;
 return objDiv.find(strId).val();
}
 /*
 * 标题 (Used In CombineCondition())
*/
public  set ReflectLogName_q(value: string) {
var objDiv = $(`#${ this.divName4Query }`);
    clsCommonFunc4Web.CheckControlExist(this.divName4Query, "input", "txtReflectLogName_q");
var strId = `input[id ^= "txtReflectLogName_q"]`;
 objDiv.find(strId).val(value);
}
}