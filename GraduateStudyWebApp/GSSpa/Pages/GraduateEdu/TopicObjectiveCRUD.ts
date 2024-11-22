
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:TopicObjectiveCRUD(界面:TopicObjectiveCRUD)
 表名:TopicObjective(01120613)
 生成代码版本:2021.06.06.1
 生成日期:2021/06/11 11:15:34
 生成者:
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研究生培养
 模块英文名:GraduateEdu
 框架-层名:WA_界面后台_TS(WA_ViewScriptCS_TS)
 编程语言:TypeScript
 == == == == == == == == == == == == 
 */
///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../scripts/typings/q/q.d.ts" />
///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
//import * as $ from "jquery";
//import * as QQ from "q";

import { clsTopicObjectiveEN } from "../TS/L0_Entity/GraduateEduTopic/clsTopicObjectiveEN.js";
import { clsvTopicObjectiveEN } from "../TS/L0_Entity/GraduateEduTopic/clsvTopicObjectiveEN.js";
import { TopicObjective_AddNewRecordAsync, TopicObjective_DelRecordAsync, TopicObjective_DelTopicObjectivesAsync, TopicObjective_GetObjByTopicObjectiveIdAsync, TopicObjective_GetObjLstByTopicObjectiveIdLstAsync, TopicObjective_ReFreshCache } from "../TS/L3_ForWApi/GraduateEduTopic/clsTopicObjectiveWApi.js";
import { vTopicObjective_GetObjLstAsync, vTopicObjective_GetObjLstByPagerAsync, vTopicObjective_GetObjLstByPager_Cache, vTopicObjective_GetRecCountByCondAsync, vTopicObjective_GetRecCountByCond_Cache, vTopicObjective_GetSubObjLst_Cache, vTopicObjective_SortFun_Defa } from "../TS/L3_ForWApi/GraduateEduTopic/clsvTopicObjectiveWApi.js";
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
 /* TopicObjectiveCRUD 的摘要说明。其中Q代表查询,U代表修改
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
*/
export abstract class TopicObjectiveCRUD implements clsOperateList
{
public static objPage_CRUD: TopicObjectiveCRUD;
public static strid_CurrEduCls_Cache: string = "99999991";//缓存分类字段
public divName4Query: string = "divQuery";  //查询区的层Id
public divName4Function: string = "divFunction";  //功能区的层Id
constructor() {
super();
TopicObjectiveCRUD.objPage_CRUD = this;
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

this.hidSortvTopicObjectiveBy = "paperTitle Asc";
if (this.bolIsInitShow == false)  //
{
this.objPager.InitShow(this.divName4Pager);
this.bolIsInitShow = true;  //
}
//2、显示无条件的表内容在GridView中
const responseBindGv = await this.BindGv_vTopicObjective();
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

this.SetEventFunc();
this.hidSortvTopicObjectiveBy = "paperTitle Asc";
if (this.bolIsInitShow == false)  //
{
this.objPager.InitShow(this.divName4Pager);
this.bolIsInitShow = true;  //
}
//2、显示无条件的表内容在GridView中
const responseBindGv = await this.BindGv_vTopicObjective();
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
const responseBindGv = await this.BindGv_vTopicObjective();
}

 /* 合并数据
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineData)
*/
public CombineData(arrvTopicObjectiveObjLst: Array<clsvTopicObjectiveEN>, arrDataColumn: Array<clsDataColumn>) 
{
var intRowNum = arrvTopicObjectiveObjLst.length;
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
var objEN: object = arrvTopicObjectiveObjLst[i];
for (var j = 0; j < intColNum; j++)
{
arrRow.push(objEN[arrDataColumn[j].FldName]);//i + "" + j;
}
arrData.push(arrRow);
}
console.log("arrData", arrData);
var strFileName = clsString.Format("主题客观表({0})导出.xlsx",
 clsvTopicObjectiveEN._CurrTabName);
exportSpecialExcel_pyf(arrData, strFileName);
}

 /* 根据条件获取相应的对象列表
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ExportExcel_Cache)
*/
public async ExportExcel_vTopicObjective_Cache() 
{
if (this.hidSortvTopicObjectiveBy == null)
{
var strMsg = `在显示列表时，排序字段(hidSortvTopicObjectiveBy)为空，请检查！(In BindGv_vTopicObjective_Cache)`;
console.error(strMsg);
alert(strMsg);
return;
}
var strListDiv: string = this.mstrListDiv;
var objvTopicObjective_Cond = this.CombinevTopicObjectiveConditionObj4ExportExcel();
objvTopicObjective_Cond.SetCondFldValue(clsvTopicObjectiveEN.con_id_CurrEduCls, TopicObjectiveCRUD.strid_CurrEduCls_Cache, "=");
    var strWhereCond = JSON.stringify(objvTopicObjective_Cond);
var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
 var arrvTopicObjectiveObjLst: Array <clsvTopicObjectiveEN> = [];
try
{
this.RecCount = await vTopicObjective_GetRecCountByCond_Cache(objvTopicObjective_Cond, TopicObjectiveCRUD.strid_CurrEduCls_Cache);
if (this.RecCount == 0)
{
var lblMsg: HTMLSpanElement = < HTMLSpanElement > document.createElement("span");
lblMsg.innerHTML = clsString.Format("根据条件:[{0}]获取的对象列表数为0！", objvTopicObjective_Cond.whereCond);
var divDataLst: HTMLDivElement = <HTMLDivElement> document.getElementById("divDataLst");
if (divDataLst != null)
{
divDataLst.innerText = "";
divDataLst.appendChild(lblMsg);
}
var strMsg: string = `在绑定Gv_Cache过程中，根据条件:[${objvTopicObjective_Cond.whereCond}]获取的对象列表数为0！`;
console.error("Error: ", strMsg);
//console.trace();
alert(strMsg);
return;
}
var arrvTopicObjectiveObjLst = await vTopicObjective_GetSubObjLst_Cache(objvTopicObjective_Cond, TopicObjectiveCRUD.strid_CurrEduCls_Cache);
}
catch(e)
{
var strMsg: string = `绑定GridView不成功,${e}.`;
console.error(strMsg);
alert(strMsg);
return;
}
if (arrvTopicObjectiveObjLst.length == 0)
{
var strKey:string = `${clsTopicObjectiveEN._CurrTabName}_${ TopicObjectiveCRUD.strid_CurrEduCls_Cache }`;
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
FldName: "paperTitle",
SortBy: "",
ColHeader: "论文标题",
Text: "",
TdClass: "text-left",
ColumnType: "Label",
orderNum: 2,
FuncName: () => { }
},
{
FldName: "paperContent",
SortBy: "",
ColHeader: "主题内容",
Text: "",
TdClass: "text-left",
ColumnType: "Label",
orderNum: 4,
FuncName: () => { }
},
{
FldName: "author",
SortBy: "",
ColHeader: "作者",
Text: "",
TdClass: "text-left",
ColumnType: "Label",
orderNum: 5,
FuncName: () => { }
},
{
FldName: "keyword",
SortBy: "",
ColHeader: "关键字",
Text: "",
TdClass: "text-left",
ColumnType: "Label",
orderNum: 6,
FuncName: () => { }
},
{
FldName: "topicObjectiveId",
SortBy: "",
ColHeader: "客观Id",
Text: "",
TdClass: "text-left",
ColumnType: "Label",
orderNum: 7,
FuncName: () => { }
},
{
FldName: "objectiveName",
SortBy: "",
ColHeader: "客观名称",
Text: "",
TdClass: "text-left",
ColumnType: "Label",
orderNum: 8,
FuncName: () => { }
},
{
FldName: "objectiveContent",
SortBy: "",
ColHeader: "客观内容",
Text: "",
TdClass: "text-left",
ColumnType: "Label",
orderNum: 9,
FuncName: () => { }
},
{
FldName: "objectiveType",
SortBy: "",
ColHeader: "客观类型",
Text: "",
TdClass: "text-left",
ColumnType: "Label",
orderNum: 10,
FuncName: () => { }
},
{
FldName: "conclusion",
SortBy: "",
ColHeader: "结论",
Text: "",
TdClass: "text-left",
ColumnType: "Label",
orderNum: 12,
FuncName: () => { }
},
{
FldName: "isSubmit",
SortBy: "",
ColHeader: "是否提交",
Text: "",
TdClass: "text-left",
ColumnType: "Label",
orderNum: 13,
FuncName: () => { }
},
{
FldName: "updDate",
SortBy: "",
ColHeader: "修改日期",
Text: "",
TdClass: "text-left",
ColumnType: "Label",
orderNum: 14,
FuncName: () => { }
},
{
FldName: "memo",
SortBy: "",
ColHeader: "备注",
Text: "",
TdClass: "text-left",
ColumnType: "Label",
orderNum: 16,
FuncName: () => { }
},
{
FldName: "objectiveTypeName",
SortBy: "",
ColHeader: "objectiveTypeName",
Text: "",
TdClass: "text-left",
ColumnType: "Label",
orderNum: 17,
FuncName: () => { }
},
];
arrvTopicObjectiveObjLst = arrvTopicObjectiveObjLst.sort(this.SortFun_ExportExcel);
  this.CombineData(arrvTopicObjectiveObjLst, arrDataColumn); 
console.log("完成BindGv_vTopicObjective!");
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
public async ExportExcel_vTopicObjective() 
{
if (this.hidSortvTopicObjectiveBy == null)
{
var strMsg = `在显示列表时，排序字段(hidSortvTopicObjectiveBy)为空，请检查！(In BindGv_vTopicObjective_Cache)`;
console.error(strMsg);
alert(strMsg);
return;
}
var strListDiv: string = this.mstrListDiv;
var strWhereCond = this.CombinevTopicObjectiveCondition();
var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
 var arrvTopicObjectiveObjLst: Array <clsvTopicObjectiveEN> = [];
try
{
this.RecCount = await vTopicObjective_GetRecCountByCondAsync(strWhereCond);
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
var arrvTopicObjectiveObjLst = await vTopicObjective_GetObjLstAsync(strWhereCond);
}
catch(e)
{
var strMsg: string = `绑定GridView不成功,${e}.`;
console.error(strMsg);
alert(strMsg);
return;
}
if (arrvTopicObjectiveObjLst.length == 0)
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
FldName: "paperTitle",
SortBy: "",
ColHeader: "论文标题",
Text: "",
TdClass: "text-left",
ColumnType: "Label",
orderNum: 2,
FuncName: () => { }
},
{
FldName: "paperContent",
SortBy: "",
ColHeader: "主题内容",
Text: "",
TdClass: "text-left",
ColumnType: "Label",
orderNum: 4,
FuncName: () => { }
},
{
FldName: "author",
SortBy: "",
ColHeader: "作者",
Text: "",
TdClass: "text-left",
ColumnType: "Label",
orderNum: 5,
FuncName: () => { }
},
{
FldName: "keyword",
SortBy: "",
ColHeader: "关键字",
Text: "",
TdClass: "text-left",
ColumnType: "Label",
orderNum: 6,
FuncName: () => { }
},
{
FldName: "topicObjectiveId",
SortBy: "",
ColHeader: "客观Id",
Text: "",
TdClass: "text-left",
ColumnType: "Label",
orderNum: 7,
FuncName: () => { }
},
{
FldName: "objectiveName",
SortBy: "",
ColHeader: "客观名称",
Text: "",
TdClass: "text-left",
ColumnType: "Label",
orderNum: 8,
FuncName: () => { }
},
{
FldName: "objectiveContent",
SortBy: "",
ColHeader: "客观内容",
Text: "",
TdClass: "text-left",
ColumnType: "Label",
orderNum: 9,
FuncName: () => { }
},
{
FldName: "objectiveType",
SortBy: "",
ColHeader: "客观类型",
Text: "",
TdClass: "text-left",
ColumnType: "Label",
orderNum: 10,
FuncName: () => { }
},
{
FldName: "conclusion",
SortBy: "",
ColHeader: "结论",
Text: "",
TdClass: "text-left",
ColumnType: "Label",
orderNum: 12,
FuncName: () => { }
},
{
FldName: "isSubmit",
SortBy: "",
ColHeader: "是否提交",
Text: "",
TdClass: "text-left",
ColumnType: "Label",
orderNum: 13,
FuncName: () => { }
},
{
FldName: "updDate",
SortBy: "",
ColHeader: "修改日期",
Text: "",
TdClass: "text-left",
ColumnType: "Label",
orderNum: 14,
FuncName: () => { }
},
{
FldName: "memo",
SortBy: "",
ColHeader: "备注",
Text: "",
TdClass: "text-left",
ColumnType: "Label",
orderNum: 16,
FuncName: () => { }
},
{
FldName: "objectiveTypeName",
SortBy: "",
ColHeader: "objectiveTypeName",
Text: "",
TdClass: "text-left",
ColumnType: "Label",
orderNum: 17,
FuncName: () => { }
},
];
arrvTopicObjectiveObjLst = arrvTopicObjectiveObjLst.sort(this.SortFun_ExportExcel);
  this.CombineData(arrvTopicObjectiveObjLst, arrDataColumn); 
console.log("完成BindGv_vTopicObjective!");
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
const responseBindGv = await this.BindGv_vTopicObjective();
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
const responseText = await this.DelRecord(strKeyId);
const responseBindGv = await this.BindGv_vTopicObjective();
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
this.SelectRecord(strKeyId);
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
public async DelRecord(strTopicObjectiveId: string) {
try
{
const responseText = await TopicObjective_DelRecordAsync(strTopicObjectiveId);
var returnInt: number = responseText;
if (returnInt > 0)
{
TopicObjective_ReFreshCache(TopicObjectiveCRUD.strid_CurrEduCls_Cache);
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
public async SelectRecord(strTopicObjectiveId: string) 
{
try
{
const responseText = await TopicObjective_GetObjByTopicObjectiveIdAsync(strTopicObjectiveId);
var objTopicObjectiveEN: clsTopicObjectiveEN = <clsTopicObjectiveEN>responseText;
console.log("完成SelectRecord!");
clsCommonFunc4Web.Redirect("/Index/Main_vTopicObjective");
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
const responseBindGv = await this.BindGv_vTopicObjective();
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
const responseBindGv = await this.ExportExcel_vTopicObjective_Cache();
}

 /* 把所有的查询控件内容组合成一个条件串
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
  <returns>条件串(strWhereCond)</returns>
*/
 public CombinevTopicObjectiveCondition():string 
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
var strMsg:string = `(errid:WiTsCs0009)在组合查询条件(CombineTopicObjectiveCondition)时出错!请联系管理员!${objException}`;
throw strMsg;
}
return strWhereCond;
}

 /* 把所有的查询控件内容组合成一个条件串
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
  <returns>条件串(strWhereCond)</returns>
*/
 public CombinevTopicObjectiveConditionObj():clsvTopicObjectiveEN 
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && userName = '张三'
var strWhereCond: string = " 1 = 1 ";
var objvTopicObjective_Cond: clsvTopicObjectiveEN = new clsvTopicObjectiveEN();
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
try
{
}
catch(objException)
{
var strMsg:string = `(errid:WiTsCs0010)在组合查询条件对象(CombineTopicObjectiveConditionObj)时出错!请联系管理员!${objException}`;
throw strMsg;
}
objvTopicObjective_Cond.whereCond = strWhereCond;
return objvTopicObjective_Cond;
}

 /* 把所有的查询控件内容组合成一个条件串
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj4ExportExcel)
  <returns>条件串(strWhereCond)</returns>
*/
 public CombinevTopicObjectiveConditionObj4ExportExcel():clsvTopicObjectiveEN 
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && userName = '张三'
var strWhereCond: string = " 1 = 1 ";
var objvTopicObjective_Cond: clsvTopicObjectiveEN = new clsvTopicObjectiveEN();
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
try
{
}
catch(objException)
{
var strMsg:string = `(errid:WiTsCs0013)在组合导出Excel条件对象(CombineTopicObjectiveConditionObj4ExportExcel)时出错!请联系管理员!${objException}`;
throw strMsg;
}
objvTopicObjective_Cond.whereCond = strWhereCond;
return objvTopicObjective_Cond;
}

 /* 显示vTopicObjective对象的所有属性值
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
  <param name = "divContainer">显示容器</param>
  <param name = "arrTopicObjectiveObjLst">需要绑定的对象列表</param>
*/
public BindTab_vTopicObjective(divContainer: string, arrvTopicObjectiveObjLst: Array<clsvTopicObjectiveEN>) 
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
FldName: "paperTitle",
SortBy: "paperTitle",
ColHeader: "论文标题",
Text: "",
TdClass: "text-left",
ColumnType: "Label",
orderNum: 2,
FuncName: () => { }
},
{
FldName: "objectiveName",
SortBy: "objectiveName",
ColHeader: "客观名称",
Text: "",
TdClass: "text-left",
ColumnType: "Label",
orderNum: 8,
FuncName: () => { }
},
{
FldName: "objectiveType",
SortBy: "objectiveType",
ColHeader: "客观类型",
Text: "",
TdClass: "text-left",
ColumnType: "Label",
orderNum: 10,
FuncName: () => { }
},
{
FldName: "objectiveTypeName",
SortBy: "objectiveTypeName",
ColHeader: "objectiveTypeName",
Text: "",
TdClass: "text-left",
ColumnType: "Label",
orderNum: 12,
FuncName: () => { }
},
{
FldName: "isSubmit",
SortBy: "isSubmit",
ColHeader: "是否提交",
Text: "",
TdClass: "text-left",
ColumnType: "Label",
orderNum: 14,
FuncName: () => { }
},
{
FldName: "updDate",
SortBy: "updDate",
ColHeader: "修改日期",
Text: "",
TdClass: "text-left",
ColumnType: "Label",
orderNum: 15,
FuncName: () => { }
},
];
clsCommonFunc4Web.BindTabV4(o, arrvTopicObjectiveObjLst, arrDataColumn, "topicObjectiveId", this); 
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
const responseBindGv = await this.BindGv_vTopicObjective();
}

 /* 根据条件获取相应的对象列表
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
*/
public async BindGv_vTopicObjective() 
{
if (this.hidSortvTopicObjectiveBy == null)
{
var strMsg = `在显示列表时，排序字段(hidSortvTopicObjectiveBy)为空，请检查！(In BindGv_vTopicObjective)`;
console.error(strMsg);
alert(strMsg);
return;
}
var strListDiv: string = this.mstrListDiv;
var strWhereCond = this.CombinevTopicObjectiveCondition();
var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
 var arrvTopicObjectiveObjLst: Array <clsvTopicObjectiveEN> = [];
try
{
const responseRecCount = await vTopicObjective_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
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
orderBy: this.hidSortvTopicObjectiveBy,//如果该字段为空，就使用下面的排序函数
sortFun: (x, y) => { return 0;}
};
const responseObjLst = await vTopicObjective_GetObjLstByPagerAsync(objPagerPara).then((jsonData)=>{
arrvTopicObjectiveObjLst = < Array<clsvTopicObjectiveEN>>jsonData;
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
if (arrvTopicObjectiveObjLst.length == 0)
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
this.BindTab_vTopicObjective(strListDiv, arrvTopicObjectiveObjLst);
console.log("完成BindGv_vTopicObjective!");
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
public async BindGv_vTopicObjective_Cache() 
{
if (this.hidSortvTopicObjectiveBy == null)
{
var strMsg = `在显示列表时，排序字段(hidSortvTopicObjectiveBy)为空，请检查！(In BindGv_vTopicObjective_Cache)`;
console.error(strMsg);
alert(strMsg);
return;
}
var strListDiv: string = this.mstrListDiv;
var objvTopicObjective_Cond = this.CombinevTopicObjectiveConditionObj();
objvTopicObjective_Cond.SetCondFldValue(clsvTopicObjectiveEN.con_id_CurrEduCls, TopicObjectiveCRUD.strid_CurrEduCls_Cache, "=");
    var strWhereCond = JSON.stringify(objvTopicObjective_Cond);
var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
 var arrvTopicObjectiveObjLst: Array <clsvTopicObjectiveEN> = [];
try
{
this.RecCount = await vTopicObjective_GetRecCountByCond_Cache(objvTopicObjective_Cond, TopicObjectiveCRUD.strid_CurrEduCls_Cache);
if (this.RecCount == 0)
{
var lblMsg: HTMLSpanElement = < HTMLSpanElement > document.createElement("span");
lblMsg.innerHTML = clsString.Format("根据条件:[{0}]获取的对象列表数为0！", objvTopicObjective_Cond.whereCond);
var divDataLst: HTMLDivElement = <HTMLDivElement> document.getElementById("divDataLst");
if (divDataLst != null)
{
divDataLst.innerText = "";
divDataLst.appendChild(lblMsg);
}
var strMsg: string = `在绑定Gv_Cache过程中，根据条件:[${objvTopicObjective_Cond.whereCond}]获取的对象列表数为0！`;
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
orderBy: this.hidSortvTopicObjectiveBy,//如果该字段为空，就使用下面的排序函数
sortFun: vTopicObjective_SortFun_Defa
};
var arrvTopicObjectiveObjLst = await vTopicObjective_GetObjLstByPager_Cache(objPagerPara, TopicObjectiveCRUD.strid_CurrEduCls_Cache);
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
if (arrvTopicObjectiveObjLst.length == 0)
{
var lblMsg: HTMLSpanElement = < HTMLSpanElement > document.createElement("span");
lblMsg.innerHTML = "根据条件获取的对象列表数为0！";
var divDataLst: HTMLDivElement = < HTMLDivElement > document.getElementById("divDataLst");
if (divDataLst != null)
{
divDataLst.innerText = "";
divDataLst.appendChild(lblMsg);
}
var strKey:string = `${clsTopicObjectiveEN._CurrTabName}_${ TopicObjectiveCRUD.strid_CurrEduCls_Cache }`;
var strMsg: string = `在BindGv_Cache过程中，根据条件对象获取的对象列表数为0！(Key=${strKey})`;
console.error("Error: ", strMsg);
//console.trace();
alert(strMsg);
return;
}
try
{
this.BindTab_vTopicObjective(strListDiv, arrvTopicObjectiveObjLst);
console.log("完成BindGv_vTopicObjective_Cache!");
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
public SortFun_ExportExcel(a:clsvTopicObjectiveEN , b:clsvTopicObjectiveEN): number 
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
if (this.hidSortvTopicObjectiveBy.indexOf(strSortByFld) >= 0)
{
if (this.hidSortvTopicObjectiveBy.indexOf("Asc") >= 0)
{
this.hidSortvTopicObjectiveBy = `${ strSortByFld} Desc`;
}
else
{
this.hidSortvTopicObjectiveBy = `${ strSortByFld} Asc`;
}
}
else
{
this.hidSortvTopicObjectiveBy = `${ strSortByFld} Asc`;
}
const responseBindGv = await this.BindGv_vTopicObjective();
}

/// <summary>
/// 在用户自定义控件中，设置关键字的值，是否只读
 /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SetKeyReadOnly)
/// </summary>
/// <param name = "bolReadonly">是否只读</param>
public SetKeyReadOnly(bolReadonly:boolean)
{
$('#txtTopicObjectiveId').prop['ReadOnly'] = bolReadonly;
}

 /* 复制记录
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CopyRecord)
*/
public async CopyRecord(arrTopicObjectiveId: Array<string>) {
try
{
const responseText = await TopicObjective_GetObjLstByTopicObjectiveIdLstAsync(arrTopicObjectiveId);
console.log('responseText=');
console.log(responseText);
var intCount:number = 0;
var arrTopicObjectiveObjLst: Array <clsTopicObjectiveEN> = <Array<clsTopicObjectiveEN>> responseText;
for (let objInFor of arrTopicObjectiveObjLst)
{
const responseText2 = await TopicObjective_AddNewRecordAsync(objInFor);
console.log('responseText2=');
console.log(responseText2);
var returnBool: boolean = !!responseText2;
if (returnBool == true)
{
TopicObjective_ReFreshCache(TopicObjectiveCRUD.strid_CurrEduCls_Cache);
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
public async DelMultiRecord(arrTopicObjectiveId: Array<string>) {
try
{
const responseText = await TopicObjective_DelTopicObjectivesAsync(arrTopicObjectiveId);
var returnInt: number = responseText;
if (returnInt > 0)
{
TopicObjective_ReFreshCache(TopicObjectiveCRUD.strid_CurrEduCls_Cache);
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
  <param name = "objTopicObjective">需要显示的对象</param>
*/
public ShowTopicObjectiveObj(divContainer: string, objTopicObjective: clsTopicObjectiveEN) 
{
var o = document.getElementById(divContainer);
if (o == null)
{
alert(`${divContainer}不存在！`);
return;
}
var sstrKeys = clsCommonFunc4Web.GetObjKeys(objTopicObjective);
var ul: HTMLUListElement = document.createElement("ul");
for (let strKey of sstrKeys)
{
var strValue = objTopicObjective[strKey];
var li: HTMLLIElement = document.createElement("li");
li.innerHTML = `${ strKey}:${ strValue}`;
ul.appendChild(li);
}
o.appendChild(ul);
}

 /* 函数功能:从界面列表中获取第一个关键字的值
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetFirstKey)
  <param name = "pobjTopicObjectiveEN">表实体类对象</param>
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
public  set hidSortvTopicObjectiveBy(value: string) {
$("#hidSortvTopicObjectiveBy").val(value);
}
 /*
 * 设置排序字段
*/
public  get hidSortvTopicObjectiveBy():string {
return $("#hidSortvTopicObjectiveBy").val();
}
}