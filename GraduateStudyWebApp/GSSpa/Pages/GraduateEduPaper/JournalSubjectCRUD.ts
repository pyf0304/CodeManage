
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:JournalSubjectCRUD(界面:JournalSubjectCRUD)
 表名:JournalSubject(01120930)
 生成代码版本:2021.06.19.1
 生成日期:2021/06/20 00:53:37
 生成者:
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培论文
 模块英文名:GraduateEduPaper
 框架-层名:WA_界面后台_TS(WA_ViewScriptCS_TS)
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
import { clsJournalSubjectENEx } from "../TS/L0_Entity/GraduateEduPaper/clsJournalSubjectENEx.js";
import { JournalSubjectCategory_BindDdl_JournalSubjectCategoryIdInDiv_Cache, JournalSubjectCategory_func } from "../TS/L3_ForWApi/GraduateEduPaper/clsJournalSubjectCategoryWApi.js";
import { JournalSubject_AddNewRecordAsync, JournalSubject_CopyObjTo, JournalSubject_DelJournalSubjectsAsync, JournalSubject_DelRecordAsync, JournalSubject_GetMaxStrIdAsync, JournalSubject_GetObjByJournalSubjectIdAsync, JournalSubject_GetObjLstByJournalSubjectIdLstAsync, JournalSubject_GetObjLstByPager_Cache, JournalSubject_GetRecCountByCond_Cache, JournalSubject_GetSubObjLst_Cache, JournalSubject_ReFreshCache } from "../TS/L3_ForWApi/GraduateEduPaper/clsJournalSubjectWApi.js";
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
 /* JournalSubjectCRUD 的摘要说明。其中Q代表查询,U代表修改
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
*/
export abstract class JournalSubjectCRUD implements clsOperateList
{
public static objPage_CRUD: JournalSubjectCRUD;
public divName4Query: string = "divQuery";  //查询区的层Id
public divName4Function: string = "divFunction";  //功能区的层Id
constructor() {
super();
JournalSubjectCRUD.objPage_CRUD = this;
}
 /*
 * 每页记录数，在扩展类可以修改
*/
public get pageSize():number {
return 5;
}
public RecCount = 0;





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
this.hidSortJournalSubjectBy = "journalSubjectId Asc";
if (this.bolIsInitShow == false)  //
{
this.objPager.InitShow(this.divName4Pager);
this.bolIsInitShow = true;  //
}
//2、显示无条件的表内容在GridView中
const responseBindGv = await this.BindGv_JournalSubject4Func();
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
const responseBindGv = await this.BindGv_JournalSubject4Func();
}

 /* 合并数据
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineData)
*/
public CombineData(arrJournalSubjectObjLst: Array<clsJournalSubjectEN>, arrDataColumn: Array<clsDataColumn>) 
{
var intRowNum = arrJournalSubjectObjLst.length;
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
var objEN: object = arrJournalSubjectObjLst[i];
for (var j = 0; j < intColNum; j++)
{
arrRow.push(objEN[arrDataColumn[j].FldName]);//i + "" + j;
}
arrData.push(arrRow);
}
console.log("arrData", arrData);
var strFileName = clsString.Format("期刊学科({0})导出.xlsx",
 clsJournalSubjectEN._CurrTabName);
exportSpecialExcel_pyf(arrData, strFileName);
}

 /* 合并数据
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineData4Func)
*/
public CombineData4Func(arrJournalSubjectExObjLst: Array<clsJournalSubjectENEx>, arrDataColumn: Array<clsDataColumn>) 
{
var intRowNum = arrJournalSubjectExObjLst.length;
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
var objEN: object = arrJournalSubjectExObjLst[i];
for (var j = 0; j < intColNum; j++)
{
arrRow.push(objEN[arrDataColumn[j].FldName]);//i + "" + j;
}
arrData.push(arrRow);
}
console.log("arrData", arrData);
var strFileName = clsString.Format("期刊学科({0})导出.xlsx",
 clsJournalSubjectEN._CurrTabName);
exportSpecialExcel_pyf(arrData, strFileName);
}

 /* 根据条件获取相应的对象列表
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ExportExcel4Func)
*/
public async ExportExcel_JournalSubject4Func() 
{
if (this.hidSortJournalSubjectBy == null)
{
var strMsg = `在显示列表时，排序字段(hidSortJournalSubjectBy)为空，请检查！(In BindGv_JournalSubject_Cache)`;
console.error(strMsg);
alert(strMsg);
return;
}
var strListDiv: string = this.mstrListDiv;
var objJournalSubject_Cond = this.CombineJournalSubjectConditionObj4ExportExcel();
    var strWhereCond = JSON.stringify(objJournalSubject_Cond);
var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
 var arrJournalSubjectObjLst: Array <clsJournalSubjectEN> = [];
 var arrJournalSubjectExObjLst: Array <clsJournalSubjectENEx> = [];
try
{
this.RecCount = await JournalSubject_GetRecCountByCond_Cache(objJournalSubject_Cond);
if (this.RecCount == 0)
{
var lblMsg: HTMLSpanElement = < HTMLSpanElement > document.createElement("span");
lblMsg.innerHTML = clsString.Format("根据条件:[{0}]获取的对象列表数为0！", objJournalSubject_Cond.whereCond);
var divDataLst: HTMLDivElement = <HTMLDivElement> document.getElementById("divDataLst");
if (divDataLst != null)
{
divDataLst.innerText = "";
divDataLst.appendChild(lblMsg);
}
var strMsg: string = `在绑定Gv_Cache过程中，根据条件:[${objJournalSubject_Cond.whereCond}]获取的对象列表数为0！`;
console.error("Error: ", strMsg);
//console.trace();
alert(strMsg);
return;
}
var arrJournalSubjectObjLst = await JournalSubject_GetSubObjLst_Cache(objJournalSubject_Cond);
arrJournalSubjectExObjLst = arrJournalSubjectObjLst.map(this.CopyToEx);
for (var objInFor of arrJournalSubjectExObjLst)
{
const conFuncMap = await this.FuncMap4ExcelExport(objInFor);
}
}
catch(e)
{
var strMsg: string = `导出Excel时获取数据不成功,${e}.`;
console.error(strMsg);
alert(strMsg);
return;
}
if (arrJournalSubjectObjLst.length == 0)
{
var strKey:string = `${clsJournalSubjectEN._CurrTabName}`;
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
FldName: "journalSubjectCategoryId",
SortBy: "",
ColHeader: "学科门类",
Text: "",
TdClass: "text-left",
ColumnType: "Label",
orderNum: 2,
FuncName: () => { }
},
{
FldName: "journalSubjectId",
SortBy: "",
ColHeader: "期刊学科Id",
Text: "",
TdClass: "text-left",
ColumnType: "Label",
orderNum: 3,
FuncName: () => { }
},
{
FldName: "journalSubjectCode",
SortBy: "",
ColHeader: "期刊学科代码",
Text: "",
TdClass: "text-left",
ColumnType: "Label",
orderNum: 4,
FuncName: () => { }
},
{
FldName: "journalSubjectName",
SortBy: "",
ColHeader: "期刊学科名称",
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
FldName: "updUser",
SortBy: "",
ColHeader: "修改人",
Text: "",
TdClass: "text-left",
ColumnType: "Label",
orderNum: 7,
FuncName: () => { }
},
{
FldName: "memo",
SortBy: "",
ColHeader: "备注",
Text: "",
TdClass: "text-left",
ColumnType: "Label",
orderNum: 8,
FuncName: () => { }
},
];
arrJournalSubjectObjLst = arrJournalSubjectObjLst.sort(this.SortFun_ExportExcel);
  this.CombineData(arrJournalSubjectObjLst, arrDataColumn); 
console.log("完成BindGv_JournalSubject!");
}
catch(e)
{
var strMsg: string =`绑定对象列表不成功.Error Massage:${e}.`;
console.error(strMsg);
alert(strMsg);
}
}

/// <summary>
/// 设置绑定下拉框，针对字段:[journalSubjectCategoryId]
 /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl_TS4QryRegion)
/// </summary>
public async SetDdl_JournalSubjectCategoryId()
{
 var objJournalSubjectCategory_Cond: clsJournalSubjectCategoryEN = new clsJournalSubjectCategoryEN();//查询区域
const ddlJournalSubjectCategoryId_q = await JournalSubjectCategory_BindDdl_JournalSubjectCategoryIdInDiv_Cache(this.divName4List, "ddlJournalSubjectCategoryId_q");//查询区域
}


 /* 函数功能:为查询区绑定下拉框
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4QueryRegion)
*/
public async BindDdl4QueryRegion()
{
// 在此处放置用户代码以初始化页面
const ddlJournalSubjectCategoryId_q = await this.SetDdl_JournalSubjectCategoryId();//查询区域
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
const responseBindGv = await this.BindGv_JournalSubject4Func();
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
const responseBindGv = await this.BindGv_JournalSubject4Func();
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
public async DelRecord(strJournalSubjectId: string) {
try
{
const responseText = await JournalSubject_DelRecordAsync(strJournalSubjectId);
var returnInt: number = responseText;
if (returnInt > 0)
{
JournalSubject_ReFreshCache();
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
public async SelectRecord(strJournalSubjectId: string) 
{
try
{
const responseText = await JournalSubject_GetObjByJournalSubjectIdAsync(strJournalSubjectId);
var objJournalSubjectEN: clsJournalSubjectEN = <clsJournalSubjectEN>responseText;
console.log("完成SelectRecord!");
clsCommonFunc4Web.Redirect("/Index/Main_JournalSubject");
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
const responseBindGv = await this.BindGv_JournalSubject4Func();
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
const responseBindGv = await this.ExportExcel_JournalSubject4Func();
}

 /* 把所有的查询控件内容组合成一个条件串
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
  <returns>条件串(strWhereCond)</returns>
*/
 public CombineJournalSubjectCondition():string 
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && userName = '张三'
var strWhereCond: string = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
try
{
if ( this.JournalSubjectId_q != "")
{
strWhereCond += ` And ${ clsJournalSubjectEN.con_JournalSubjectId} like '% ${ this.JournalSubjectId_q }%'`;
}
if ( this.JournalSubjectCode_q != "")
{
strWhereCond += ` And ${ clsJournalSubjectEN.con_JournalSubjectCode} like '% ${ this.JournalSubjectCode_q }%'`;
}
if ( this.JournalSubjectName_q != "")
{
strWhereCond += ` And ${ clsJournalSubjectEN.con_JournalSubjectName} like '% ${ this.JournalSubjectName_q }%'`;
}
if ( this.JournalSubjectCategoryId_q != "" && this.JournalSubjectCategoryId_q != "0")
{
strWhereCond += ` And ${clsJournalSubjectEN.con_JournalSubjectCategoryId } = '${ this.JournalSubjectCategoryId_q }'`;
}
}
catch(objException)
{
var strMsg:string = `(errid:WiTsCs0009)在组合查询条件(CombineJournalSubjectCondition)时出错!请联系管理员!${objException}`;
throw strMsg;
}
return strWhereCond;
}

 /* 把所有的查询控件内容组合成一个条件串
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
  <returns>条件串(strWhereCond)</returns>
*/
 public CombineJournalSubjectConditionObj():clsJournalSubjectEN 
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && userName = '张三'
var strWhereCond: string = " 1 = 1 ";
var objJournalSubject_Cond: clsJournalSubjectEN = new clsJournalSubjectEN();
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
try
{
if ( this.JournalSubjectId_q != "")
{
strWhereCond += ` And ${ clsJournalSubjectEN.con_JournalSubjectId} like '% ${ this.JournalSubjectId_q }%'`;
objJournalSubject_Cond.SetCondFldValue(clsJournalSubjectEN.con_JournalSubjectId, this.JournalSubjectId_q, "like");
}
if ( this.JournalSubjectCode_q != "")
{
strWhereCond += ` And ${ clsJournalSubjectEN.con_JournalSubjectCode} like '% ${ this.JournalSubjectCode_q }%'`;
objJournalSubject_Cond.SetCondFldValue(clsJournalSubjectEN.con_JournalSubjectCode, this.JournalSubjectCode_q, "like");
}
if ( this.JournalSubjectName_q != "")
{
strWhereCond += ` And ${ clsJournalSubjectEN.con_JournalSubjectName} like '% ${ this.JournalSubjectName_q }%'`;
objJournalSubject_Cond.SetCondFldValue(clsJournalSubjectEN.con_JournalSubjectName, this.JournalSubjectName_q, "like");
}
if ( this.JournalSubjectCategoryId_q != "" && this.JournalSubjectCategoryId_q != "0")
{
strWhereCond += ` And ${clsJournalSubjectEN.con_JournalSubjectCategoryId } = '${ this.JournalSubjectCategoryId_q }'`;
objJournalSubject_Cond.SetCondFldValue(clsJournalSubjectEN.con_JournalSubjectCategoryId, this.JournalSubjectCategoryId_q, "=");
}
}
catch(objException)
{
var strMsg:string = `(errid:WiTsCs0010)在组合查询条件对象(CombineJournalSubjectConditionObj)时出错!请联系管理员!${objException}`;
throw strMsg;
}
objJournalSubject_Cond.whereCond = strWhereCond;
return objJournalSubject_Cond;
}

 /* 把所有的查询控件内容组合成一个条件串
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj4ExportExcel)
  <returns>条件串(strWhereCond)</returns>
*/
 public CombineJournalSubjectConditionObj4ExportExcel():clsJournalSubjectEN 
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && userName = '张三'
var strWhereCond: string = " 1 = 1 ";
var objJournalSubject_Cond: clsJournalSubjectEN = new clsJournalSubjectEN();
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
try
{
if ( this.JournalSubjectId_q != "")
{
strWhereCond += ` And ${ clsJournalSubjectEN.con_JournalSubjectId} like '% ${ this.JournalSubjectId_q }%'`;
objJournalSubject_Cond.SetCondFldValue(clsJournalSubjectEN.con_JournalSubjectId, this.JournalSubjectId_q, "like");
}
if ( this.JournalSubjectCode_q != "")
{
strWhereCond += ` And ${ clsJournalSubjectEN.con_JournalSubjectCode} like '% ${ this.JournalSubjectCode_q }%'`;
objJournalSubject_Cond.SetCondFldValue(clsJournalSubjectEN.con_JournalSubjectCode, this.JournalSubjectCode_q, "like");
}
if ( this.JournalSubjectName_q != "")
{
strWhereCond += ` And ${ clsJournalSubjectEN.con_JournalSubjectName} like '% ${ this.JournalSubjectName_q }%'`;
objJournalSubject_Cond.SetCondFldValue(clsJournalSubjectEN.con_JournalSubjectName, this.JournalSubjectName_q, "like");
}
if ( this.JournalSubjectCategoryId_q != "" && this.JournalSubjectCategoryId_q != "0")
{
strWhereCond += ` And ${clsJournalSubjectEN.con_JournalSubjectCategoryId } = '${ this.JournalSubjectCategoryId_q }'`;
objJournalSubject_Cond.SetCondFldValue(clsJournalSubjectEN.con_JournalSubjectCategoryId, this.JournalSubjectCategoryId_q, "=");
}
}
catch(objException)
{
var strMsg:string = `(errid:WiTsCs0013)在组合导出Excel条件对象(CombineJournalSubjectConditionObj4ExportExcel)时出错!请联系管理员!${objException}`;
throw strMsg;
}
objJournalSubject_Cond.whereCond = strWhereCond;
return objJournalSubject_Cond;
}

 /* 显示JournalSubject对象的所有属性值
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
  <param name = "divContainer">显示容器</param>
  <param name = "arrJournalSubjectObjLst">需要绑定的对象列表</param>
*/
public BindTab_JournalSubject(divContainer: string, arrJournalSubjectObjLst: Array<clsJournalSubjectEN>) 
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
FldName: "journalSubjectCategoryId",
SortBy: "journalSubjectCategoryName",
ColHeader: "学科门类",
Text: "",
TdClass: "text-left",
ColumnType: "Label",
orderNum: 2,
FuncName: () => { }
},
{
FldName: "journalSubjectId",
SortBy: "journalSubjectId",
ColHeader: "学科Id",
Text: "",
TdClass: "text-left",
ColumnType: "Label",
orderNum: 3,
FuncName: () => { }
},
{
FldName: "journalSubjectCode",
SortBy: "journalSubjectCode",
ColHeader: "学科代码",
Text: "",
TdClass: "text-left",
ColumnType: "Label",
orderNum: 4,
FuncName: () => { }
},
{
FldName: "journalSubjectName",
SortBy: "journalSubjectName",
ColHeader: "学科名称",
Text: "",
TdClass: "text-left",
ColumnType: "Label",
orderNum: 5,
FuncName: () => { }
},
{
FldName: "updDate",
SortBy: "updDate",
ColHeader: "修改日期",
Text: "",
TdClass: "text-left",
ColumnType: "Label",
orderNum: 6,
FuncName: () => { }
},
{
FldName: "updUser",
SortBy: "updUser",
ColHeader: "修改人",
Text: "",
TdClass: "text-left",
ColumnType: "Label",
orderNum: 7,
FuncName: () => { }
},
{
FldName: "memo",
SortBy: "memo",
ColHeader: "备注",
Text: "",
TdClass: "text-left",
ColumnType: "Label",
orderNum: 8,
FuncName: () => { }
},
];
clsCommonFunc4Web.BindTabV4(o, arrJournalSubjectObjLst, arrDataColumn, "journalSubjectId", this); 
this.objPager.RecCount = this.RecCount;
this.objPager.pageSize = this.pageSize;
this.objPager.ShowPagerV2(this, this.divName4Pager);
}

 /* 显示JournalSubject对象的所有属性值
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab4Func)
  <param name = "divContainer">显示容器</param>
  <param name = "arrJournalSubjectExObjLst">需要绑定的对象列表</param>
*/
public BindTab_JournalSubject4Func(divContainer: string, arrJournalSubjectExObjLst: Array<clsJournalSubjectENEx>) 
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
FldName: "journalSubjectCategoryName",
SortBy: "journalSubjectCategoryName",
ColHeader: "学科门类",
Text: "",
TdClass: "text-left",
ColumnType: "Label",
orderNum: 2,
FuncName: () => { }
},
{
FldName: "journalSubjectId",
SortBy: "journalSubjectId",
ColHeader: "学科Id",
Text: "",
TdClass: "text-left",
ColumnType: "Label",
orderNum: 3,
FuncName: () => { }
},
{
FldName: "journalSubjectCode",
SortBy: "journalSubjectCode",
ColHeader: "学科代码",
Text: "",
TdClass: "text-left",
ColumnType: "Label",
orderNum: 4,
FuncName: () => { }
},
{
FldName: "journalSubjectName",
SortBy: "journalSubjectName",
ColHeader: "学科名称",
Text: "",
TdClass: "text-left",
ColumnType: "Label",
orderNum: 5,
FuncName: () => { }
},
{
FldName: "updDate",
SortBy: "updDate",
ColHeader: "修改日期",
Text: "",
TdClass: "text-left",
ColumnType: "Label",
orderNum: 6,
FuncName: () => { }
},
{
FldName: "updUser",
SortBy: "updUser",
ColHeader: "修改人",
Text: "",
TdClass: "text-left",
ColumnType: "Label",
orderNum: 7,
FuncName: () => { }
},
{
FldName: "memo",
SortBy: "memo",
ColHeader: "备注",
Text: "",
TdClass: "text-left",
ColumnType: "Label",
orderNum: 8,
FuncName: () => { }
},
];
clsCommonFunc4Web.BindTabV4(o, arrJournalSubjectExObjLst, arrDataColumn, "journalSubjectId", this); 
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
const responseBindGv = await this.BindGv_JournalSubject4Func();
}

 /* 根据条件获取相应的对象列表
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv4Func)
*/
public async BindGv_JournalSubject4Func() 
{
if (this.hidSortJournalSubjectBy == null)
{
var strMsg = `在显示列表时，排序字段(hidSortJournalSubjectBy)为空，请检查！(In BindGv_JournalSubject_Cache)`;
console.error(strMsg);
alert(strMsg);
return;
}
var strListDiv: string = this.mstrListDiv;
var objJournalSubject_Cond = this.CombineJournalSubjectConditionObj();
    var strWhereCond = JSON.stringify(objJournalSubject_Cond);
var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
 var arrJournalSubjectObjLst: Array <clsJournalSubjectEN> = [];
 var arrJournalSubjectExObjLst: Array <clsJournalSubjectENEx> = [];
try
{
this.RecCount = await JournalSubject_GetRecCountByCond_Cache(objJournalSubject_Cond);
var objPagerPara: stuPagerPara = {
pageIndex: intCurrPageIndex,
pageSize: this.pageSize,
whereCond: strWhereCond,
orderBy: this.hidSortJournalSubjectBy,
sortFun: (x, y) => { return 0;}
};
arrJournalSubjectObjLst = await JournalSubject_GetObjLstByPager_Cache(objPagerPara);
arrJournalSubjectExObjLst = arrJournalSubjectObjLst.map(this.CopyToEx);
for (var objInFor of arrJournalSubjectExObjLst)
{
const conFuncMap = await this.FuncMap(objInFor);
}
}
catch(e)
{
var strMsg: string = `绑定GridView不成功,${e}.`;
console.error(strMsg);
alert(strMsg);
return;
}
if (arrJournalSubjectObjLst.length == 0)
{
var strKey:string = `${clsJournalSubjectEN._CurrTabName}`;
var strMsg: string = `在BindGv_Cache过程中，根据条件对象获取的对象列表数为0！(Key=${strKey})`;
console.error("Error: ", strMsg);
//console.trace();
alert(strMsg);
return;
}
try
{
this.BindTab_JournalSubject4Func(strListDiv, arrJournalSubjectExObjLst);
console.log("完成BindGv_JournalSubject4Func!");
}
catch(e)
{
var strMsg: string =`绑定对象列表不成功.Error Massage:${e}.`;
console.error(strMsg);
alert(strMsg);
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CopyToEx)
 /// </summary>
 /// <param name = "objJournalSubjectENS">源对象</param>
 /// <returns>目标对象=>clsJournalSubjectEN:objJournalSubjectENT</returns>
 public CopyToEx(objJournalSubjectENS:clsJournalSubjectEN ): clsJournalSubjectENEx
{
 var objJournalSubjectENT = new clsJournalSubjectENEx();
try
{
JournalSubject_CopyObjTo(objJournalSubjectENS, objJournalSubjectENT);
 return objJournalSubjectENT;
}
catch (e)
{
var strMsg: string = clsString.Format("(errid:WiTsCs0011)Copy表对象数据出错,${e}.");
console.error(strMsg);
alert(strMsg);
 return objJournalSubjectENT;
}
}

 /// <summary>
 /// 把一个扩展类的部分属性进行函数转换
 /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_FuncMap)
 /// </summary>
 /// <param name = "objJournalSubjectS">源对象</param>
 public async FuncMap(objJournalSubject:clsJournalSubjectENEx )
{
try
{
{
 var JournalSubjectCategory_JournalSubjectCategoryId = objJournalSubject.journalSubjectCategoryId;
 var JournalSubjectCategory_JournalSubjectCategoryName = await JournalSubjectCategory_func(clsJournalSubjectCategoryEN.con_JournalSubjectCategoryId, clsJournalSubjectCategoryEN.con_JournalSubjectCategoryName, JournalSubjectCategory_JournalSubjectCategoryId );
 objJournalSubject.journalSubjectCategoryName = JournalSubjectCategory_JournalSubjectCategoryName;
};
}
catch (e)
{
var strMsg: string = `(errid:WiTsCs0012)函数映射表对象数据出错,${e}.`;
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
public SortFun_ExportExcel(a:clsJournalSubjectEN , b:clsJournalSubjectEN): number 
{
if (a.updDate == b.updDate) return a.updUser.localeCompare(b.updUser) ;
else return a.updDate.localeCompare(b.updDate);
}

 /// <summary>
 /// 把一个扩展类的部分属性进行函数转换
 /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_FuncMap4ExcelExport)
 /// </summary>
 /// <param name = "objJournalSubjectS">源对象</param>
 public async FuncMap4ExcelExport(objJournalSubject:clsJournalSubjectENEx )
{
try
{
{
 var JournalSubjectCategory_JournalSubjectCategoryId = objJournalSubject.journalSubjectCategoryId;
 var JournalSubjectCategory_JournalSubjectCategoryName = await JournalSubjectCategory_func(clsJournalSubjectCategoryEN.con_JournalSubjectCategoryId, clsJournalSubjectCategoryEN.con_JournalSubjectCategoryName, JournalSubjectCategory_JournalSubjectCategoryId );
 objJournalSubject.journalSubjectCategoryName = JournalSubjectCategory_JournalSubjectCategoryName;
};
}
catch (e)
{
var strMsg: string = `(errid:WiTsCs0014)函数映射4ExcelExport表对象数据出错,${e}.`;
console.error(strMsg);
alert(strMsg);
}
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
if (this.hidSortJournalSubjectBy.indexOf(strSortByFld) >= 0)
{
if (this.hidSortJournalSubjectBy.indexOf("Asc") >= 0)
{
this.hidSortJournalSubjectBy = `${ strSortByFld} Desc`;
}
else
{
this.hidSortJournalSubjectBy = `${ strSortByFld} Asc`;
}
}
else
{
this.hidSortJournalSubjectBy = `${ strSortByFld} Asc`;
}
const responseBindGv = await this.BindGv_JournalSubject4Func();
}

/// <summary>
/// 在用户自定义控件中，设置关键字的值，是否只读
 /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SetKeyReadOnly)
/// </summary>
/// <param name = "bolReadonly">是否只读</param>
public SetKeyReadOnly(bolReadonly:boolean)
{
$('#txtJournalSubjectId').prop['ReadOnly'] = bolReadonly;
}

 /* 复制记录
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CopyRecord)
*/
public async CopyRecord(arrJournalSubjectId: Array<string>) {
try
{
const responseText = await JournalSubject_GetObjLstByJournalSubjectIdLstAsync(arrJournalSubjectId);
console.log('responseText=');
console.log(responseText);
var intCount:number = 0;
var arrJournalSubjectObjLst: Array <clsJournalSubjectEN> = <Array<clsJournalSubjectEN>> responseText;
for (let objInFor of arrJournalSubjectObjLst)
{
const strMaxStrId = await JournalSubject_GetMaxStrIdAsync();
console.log('strMaxStrId=' + strMaxStrId);
objInFor.journalSubjectId = strMaxStrId;
const responseText2 = await JournalSubject_AddNewRecordAsync(objInFor);
console.log('responseText2=');
console.log(responseText2);
var returnBool: boolean = !!responseText2;
if (returnBool == true)
{
JournalSubject_ReFreshCache();
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
public async DelMultiRecord(arrJournalSubjectId: Array<string>) {
try
{
const responseText = await JournalSubject_DelJournalSubjectsAsync(arrJournalSubjectId);
var returnInt: number = responseText;
if (returnInt > 0)
{
JournalSubject_ReFreshCache();
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
  <param name = "objJournalSubject">需要显示的对象</param>
*/
public ShowJournalSubjectObj(divContainer: string, objJournalSubject: clsJournalSubjectEN) 
{
var o = document.getElementById(divContainer);
if (o == null)
{
alert(`${divContainer}不存在！`);
return;
}
var sstrKeys = clsCommonFunc4Web.GetObjKeys(objJournalSubject);
var ul: HTMLUListElement = document.createElement("ul");
for (let strKey of sstrKeys)
{
var strValue = objJournalSubject[strKey];
var li: HTMLLIElement = document.createElement("li");
li.innerHTML = `${ strKey}:${ strValue}`;
ul.appendChild(li);
}
o.appendChild(ul);
}

 /* 函数功能:从界面列表中获取第一个关键字的值
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetFirstKey)
  <param name = "pobjJournalSubjectEN">表实体类对象</param>
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
 * 期刊学科门类Id (Used In CombineCondition())
*/
public  get JournalSubjectCategoryId_q():string {
var objDiv = $(`#${ this.divName4Query }`);
    clsCommonFunc4Web.CheckControlExist(this.divName4Query, "select", "ddlJournalSubjectCategoryId_q");
var strId = `select[id ^= "ddlJournalSubjectCategoryId_q"]`;
 if (objDiv.find(strId).val() == "0") return "";
return $("#ddlJournalSubjectCategoryId_q").val();
}
 /*
 * 期刊学科门类Id (Used In CombineCondition())
*/
public  set JournalSubjectCategoryId_q(value: string) {
var objDiv = $(`#${ this.divName4Query }`);
    clsCommonFunc4Web.CheckControlExist(this.divName4Query, "select", "ddlJournalSubjectCategoryId_q");
var strId = `select[id ^= "ddlJournalSubjectCategoryId_q"]`;
 objDiv.find(strId).val(value);
}
 /*
 * 期刊学科代码 (Used In CombineCondition())
*/
public  get JournalSubjectCode_q():string {
var objDiv = $(`#${ this.divName4Query }`);
    clsCommonFunc4Web.CheckControlExist(this.divName4Query, "input", "txtJournalSubjectCode_q");
var strId = `input[id ^= "txtJournalSubjectCode_q"]`;
 return objDiv.find(strId).val();
}
 /*
 * 期刊学科代码 (Used In CombineCondition())
*/
public  set JournalSubjectCode_q(value: string) {
var objDiv = $(`#${ this.divName4Query }`);
    clsCommonFunc4Web.CheckControlExist(this.divName4Query, "input", "txtJournalSubjectCode_q");
var strId = `input[id ^= "txtJournalSubjectCode_q"]`;
 objDiv.find(strId).val(value);
}
 /*
 * 期刊学科Id (Used In CombineCondition())
*/
public  get JournalSubjectId_q():string {
var objDiv = $(`#${ this.divName4Query }`);
    clsCommonFunc4Web.CheckControlExist(this.divName4Query, "input", "txtJournalSubjectId_q");
var strId = `input[id ^= "txtJournalSubjectId_q"]`;
 return objDiv.find(strId).val();
}
 /*
 * 期刊学科Id (Used In CombineCondition())
*/
public  set JournalSubjectId_q(value: string) {
var objDiv = $(`#${ this.divName4Query }`);
    clsCommonFunc4Web.CheckControlExist(this.divName4Query, "input", "txtJournalSubjectId_q");
var strId = `input[id ^= "txtJournalSubjectId_q"]`;
 objDiv.find(strId).val(value);
}
 /*
 * 期刊学科名称 (Used In CombineCondition())
*/
public  get JournalSubjectName_q():string {
var objDiv = $(`#${ this.divName4Query }`);
    clsCommonFunc4Web.CheckControlExist(this.divName4Query, "input", "txtJournalSubjectName_q");
var strId = `input[id ^= "txtJournalSubjectName_q"]`;
 return objDiv.find(strId).val();
}
 /*
 * 期刊学科名称 (Used In CombineCondition())
*/
public  set JournalSubjectName_q(value: string) {
var objDiv = $(`#${ this.divName4Query }`);
    clsCommonFunc4Web.CheckControlExist(this.divName4Query, "input", "txtJournalSubjectName_q");
var strId = `input[id ^= "txtJournalSubjectName_q"]`;
 objDiv.find(strId).val(value);
}
}