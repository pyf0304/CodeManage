
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:WApiRTPaperRela_QUDI_TS
 表名:RTPaperRela(01120581)
 生成代码版本:2020.02.19.1
 生成日期:2020/02/20 17:58:52
 生成者:
 工程名称:问卷调查
 工程ID:0112
 相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
 PrjDataBaseId:0122
 模块中文名:研究生培养
 模块英文名:GraduateEdu
 框架-层名:WA_界面脚本后台_TS(WA_ViewScriptCS_TS)
 编程语言:TypeScript
 == == == == == == == == == == == == 
 */
///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../scripts/typings/q/q.d.ts" />
///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
//import * as $ from "jquery";
//import * as QQ from "q";
import { clsRTPaperRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsRTPaperRelaEN.js";

import { clsPaperEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js";
import { clsResearchTopicEN } from "../TS/L0_Entity/GraduateEduTopic/clsResearchTopicEN.js";
import { clsvRTPaperRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsvRTPaperRelaEN.js";
import { arrSelectedKeys, clsCommonFunc4Web } from "../TS/PubFun/clsCommonFunc4Web2.js";
import { clsDataColumn } from "../TS/PubFun/clsDataColumn.js";
import { clsOperateList } from "../TS/PubFun/clsOperateList.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";
import { RTPaperRela_AddNewRecordAsync, RTPaperRela_DelRecordAsync, RTPaperRela_DelRTPaperRelasAsync, RTPaperRela_GetObjBymIdAsync, RTPaperRela_IsExistAsync, RTPaperRela_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsRTPaperRelaWApi.js";
import { Paper_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js";
import { vRTPaperRela_GetObjLstAsync, vRTPaperRela_GetObjLstByPagerAsync, vRTPaperRela_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvRTPaperRelaWApi.js";
import { ResearchTopic_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsResearchTopicWApi.js";
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
 /* WApiRTPaperRela_QUDI_TS 的摘要说明。其中Q代表查询,U代表修改
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
*/
export class RTPaperRela_QUDI implements clsOperateList
{
public mstrListDiv: string = "divDataLst";

 /*
 * 每页记录数，在扩展类可以修改
*/
public get pageSize():number {
return 5;
}
public RecCount = 0;


 /* 为插入记录做准备工作
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
*/
public AddNewRecord()
{
this.btnOKUpd = "确认添加";
this.btnCancel = "取消添加";
this.Clear();
//wucRTPaperRelaB1.mId = clsRTPaperRelaBL.GetMaxStrId_S();
}

 /* 添加新记录，保存函数
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
*/
public async AddNewRecordSave(){
this.DivName = "divAddNewRecordSave";
var objRTPaperRelaEN: clsRTPaperRelaEN = new clsRTPaperRelaEN();
   this.PutDataToRTPaperRelaClass(objRTPaperRelaEN);
try
{
const responseText2 = await RTPaperRela_AddNewRecordAsync(objRTPaperRelaEN);
var returnBool: boolean = !!responseText2;
if (returnBool == true)
{
var strInfo: string = `添加记录成功!`;
$('#lblResult43').val(strInfo);
//显示信息框
alert(strInfo);
}
else
{
var strInfo: string = `添加记录不成功!`;
$('#lblResult43').val(strInfo);
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

 /* 为插入记录做准备工作
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxId)
*/
public AddNewRecordWithMaxId()
{
this.btnOKUpd = "确认添加";
this.btnCancel = "取消添加";
this.Clear();
//wucRTPaperRelaB1.mId = clsRTPaperRelaBL.GetMaxStrId_S();
}

 /* 根据条件获取相应的记录对象的列表
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
*/
public async BindGv_vRTPaperRela() 
{
var strListDiv: string = this.mstrListDiv;
var strWhereCond = this.CombinevRTPaperRelaCondition();
var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
 var arrvRTPaperRelaObjLst: Array <clsvRTPaperRelaEN> = [];
try
{
const responseRecCount = await vRTPaperRela_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
this.RecCount = jsonData;
});
var objPagerPara: stuPagerPara = {
pageIndex: intCurrPageIndex,
pageSize: this.pageSize,
whereCond: strWhereCond,
    orderBy: this.hidSortvRTPaperRelaBy,
    sortFun: (x, y) => { return 0; }
};
const responseObjLst = await vRTPaperRela_GetObjLstByPagerAsync(objPagerPara).then((jsonData)=>{
arrvRTPaperRelaObjLst = < Array<clsvRTPaperRelaEN>>jsonData;
});
}
catch(e)
{
console.error('catch(e)=');
console.error(e);
var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
alert(strMsg);
}
if (arrvRTPaperRelaObjLst.length == 0)
{
var strMsg: string = `根据条件获取的对象列表数为空！`;
alert(strMsg);
return;
}
try
{
this.BindTab_vRTPaperRela(strListDiv, arrvRTPaperRelaObjLst);
console.log("完成BindGv_vRTPaperRela!");
}
catch(e)
{
console.error('catch(e)=');
console.error(e);
var strMsg: string =`绑定对象列表不成功.Error Massage:${e}.`;
alert(strMsg);
}
}

 /* 显示vRTPaperRela对象的所有属性值
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
  <param name = "divContainer">显示容器</param>
  <param name = "arrRTPaperRelaObjLst">需要绑定的对象列表</param>
*/
public BindTab_vRTPaperRela(divContainer: string, arrvRTPaperRelaObjLst: Array<clsvRTPaperRelaEN>) 
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
FldName: "topicName",
ColHeader: "栏目主题",
Text: "",TdClass: "text-left",SortBy: "",
ColumnType: "Label",
orderNum: 1,
FuncName: () => { }
},
{
FldName: "topicProposePeople",
ColHeader: "主题提出人",
Text: "",TdClass: "text-left",SortBy: "",
ColumnType: "Label",
orderNum: 1,
FuncName: () => { }
},
{
FldName: "paperTitle",
ColHeader: "论文标题",
Text: "",TdClass: "text-left",SortBy: "",
ColumnType: "Label",
orderNum: 1,
FuncName: () => { }
},
{
FldName: "paperTitle",
ColHeader: "主题名称",
Text: "",TdClass: "text-left",SortBy: "",
ColumnType: "Label",
orderNum: 1,
FuncName: () => { }
},
{
FldName: "author",
ColHeader: "作者",
Text: "",TdClass: "text-left",SortBy: "",
ColumnType: "Label",
orderNum: 1,
FuncName: () => { }
},
{
FldName: "periodical",
ColHeader: "期刊",
Text: "",TdClass: "text-left",SortBy: "",
ColumnType: "Label",
orderNum: 1,
FuncName: () => { }
},
{
FldName: "userName",
ColHeader: "用户名",
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
btn1.className = "btn btn-outline-info";
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
btn1.className = "btn btn-outline-info";
btn1.setAttribute("onclick", `btnDelRecordInTab_Click('${strKeyId}');`);
return btn1;
}
},
];
clsCommonFunc4Web.BindTabV2(o, arrvRTPaperRelaObjLst, arrDataColumn, "mId"); 
this.objPager.RecCount = this.RecCount;
this.objPager.pageSize = this.pageSize;
    this.objPager.ShowPagerV2(this, this.divName4Pager);
}

 /* 添加新记录
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecord_Click)
*/
public async btnAddNewRecord_Click() {
this.OpType = "Add";
try
{
const responseText = await this.AddNewRecord();
}
catch(e)
{
console.error('catch(e)=');
console.error(e);
var strMsg: string = `添加新记录初始化不成功,${e}.`;
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
const responseText = await this.DelMultiRecord(arrKeyIds);
const responseText2 = await this.BindGv_vRTPaperRela();
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
var lngKeyId =  Number(strKeyId);
const responseText = await this.DelRecord(lngKeyId);
const responseText2 = await this.BindGv_vRTPaperRela();
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
 在数据表里详细信息记录
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDetailRecordInTab_Click)
*/
public async btnDetailRecordInTab_Click(strKeyId:string) {
this.OpType = "Detail";
try
{
 if (strKeyId == "")
{
alert("请选择需要详细信息的记录！");
return "";
}
var lngKeyId =  Number(strKeyId);
this.DetailRecord(lngKeyId);
}
catch(e)
{
console.error('catch(e)=');
console.error(e);
var strMsg: string = `详细信息记录不成功. ${e}.`;
alert(strMsg);
}
}

 /* 根据条件获取相应的记录对象的列表
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnExportExcel_Click)
*/
public async btnExportExcel_Click() 
{
var strWhereCond =" 1=1 ";
try
{
const responseText = await vRTPaperRela_GetObjLstAsync(strWhereCond).then((jsonData)=>{
var arrvRTPaperRelaObjLst : Array<clsvRTPaperRelaEN> = < Array<clsvRTPaperRelaEN>>jsonData;
this.BindTab_vRTPaperRela(this.mstrListDiv, arrvRTPaperRelaObjLst);
});
}
catch(e)
{
console.error('catch(e)=');
console.error(e);
var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
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
//const responseText3 = await this.AddNewRecordWithMaxIdSave().then((jsonData)=>{
//var returnBool2: boolean = jsonData;
//if (returnBool2 == true)
//{
//HideDialog();
//this.BindGv_vRTPaperRela();
//}
//});
}
else
{
const responseText2 = await this.AddNewRecordSave().then((jsonData)=>{
var returnBool: boolean = jsonData;
if (returnBool == true)
{
HideDialog();
this.BindGv_vRTPaperRela();
}
});
}
break;
case "确认修改":
//这是一个单表的修改的代码,由于逻辑层太简单,
const responseText3 = await this.UpdateRecordSave().then((jsonData)=>{
var returnBool: boolean = jsonData;
if (returnBool == true)
{
HideDialog();
this.BindGv_vRTPaperRela();
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

 /* 根据条件获取相应的记录对象的列表
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
*/
public async btnQuery_Click(strListDiv:string) 
{
var strWhereCond = this.CombinevRTPaperRelaCondition();
try
{
const responseRecCount = await vRTPaperRela_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
this.RecCount = jsonData;
});
var objPagerPara: stuPagerPara = {
pageIndex: 1,
pageSize: this.pageSize,
whereCond: strWhereCond,
    orderBy: this.hidSortvRTPaperRelaBy,
    sortFun: (x, y) => { return 0; }
};
const responseObjLst = await vRTPaperRela_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
var arrvRTPaperRelaObjLst : Array<clsvRTPaperRelaEN> = < Array<clsvRTPaperRelaEN>>jsonData;
this.BindTab_vRTPaperRela(this.mstrListDiv, arrvRTPaperRelaObjLst);
});
}
catch(e)
{
console.error('catch(e)=');
console.error(e);
var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
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
var lngKeyId =  Number(strKeyId);
this.SelectRecord(lngKeyId);
}
catch(e)
{
console.error('catch(e)=');
console.error(e);
var strMsg: string = `选择记录不成功. ${e}.`;
alert(strMsg);
}
}

 /* 修改记录
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecord_Click)
*/
    public btnUpdateRecord_Click(strKeyId:string) {
this.OpType = "Update";
//var strKeyId = clsCommonFunc4Web.GetFirstCheckedKeyId();
    if (strKeyId == "")
{
alert("请选择需要修改的记录！");
return;
}
var lngKeyId =  Number(strKeyId);
this.UpdateRecord(lngKeyId);
}

 /* 在数据表里修改记录
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecordInTab_Click)
*/
public btnUpdateRecordInTab_Click(strKeyId:string) {
this.OpType = "Update";
    if (strKeyId == "")
{
alert("请选择需要修改的记录！");
return;
}
var lngKeyId =  Number(strKeyId);
this.UpdateRecord(lngKeyId);
}

/// <summary>
/// 清除用户自定义控件中，所有控件的值
 /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Clear)
/// </summary>	
public Clear()
{
}

 /* 把所有的查询控件内容组合成一个条件串
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
  <returns>条件串(strWhereCond)</returns>
*/
 public CombinevRTPaperRelaCondition():string 
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && userName = '张三'
var strWhereCond: string = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
try
{
if ( this.TopicName_q != "")
{
strWhereCond += ` And ${ clsvRTPaperRelaEN.con_TopicName} like '% ${ this.TopicName_q }%'`;
}
if ( this.PaperTitle_q != "")
{
strWhereCond += ` And ${ clsvRTPaperRelaEN.con_PaperTitle} like '% ${ this.PaperTitle_q }%'`;
}

}
catch(objException)
{
var strMsg:string = `(errid:WiTsCs0002)在组合查询条件(CombineRTPaperRelaCondition)时出错!请联系管理员!${objException}`;
throw strMsg;
}
return strWhereCond;
}

/// <summary>
/// 为下拉框获取数据,从表:[ResearchTopic]中获取
 /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DdlBind)
/// </summary>
/// <returns>获取主键字段、名称字段两列的所有记录记录的dataTable</returns>
public BindDdl_TopicId(ddlTopicId: string, strWhereCond: string = "1 =1") {
//var strWhereCond = " 1 =1 ";
var objDdl = document.getElementById(ddlTopicId);
if (objDdl == null)
{
var strMsg = `下拉框：${ ddlTopicId } 不存在！`;
alert(strMsg);
throw (strMsg);
}
return new Promise((resolve, reject) => {
try
{
const responseText = ResearchTopic_GetObjLstAsync(strWhereCond).then((jsonData)=>{
var arrResearchTopicObjLst: Array < clsResearchTopicEN > = <Array<clsResearchTopicEN>> jsonData;
clsCommonFunc4Web.BindDdl_ObjLst(ddlTopicId, arrResearchTopicObjLst, clsResearchTopicEN.con_TopicId, clsResearchTopicEN.con_TopicName, "研究主题");
console.log("完成BindDdl_TopicId!");
resolve(jsonData);
});
}
catch (e)
{
var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
alert(strMsg);
}
});
}
/// <summary>
/// 为下拉框获取数据,从表:[Paper]中获取
 /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DdlBind)
/// </summary>
/// <returns>获取主键字段、名称字段两列的所有记录记录的dataTable</returns>
public BindDdl_PaperId(ddlPaperId: string, strWhereCond: string = "1 =1") {
//var strWhereCond = " 1 =1 ";
var objDdl = document.getElementById(ddlPaperId);
if (objDdl == null)
{
var strMsg = `下拉框：${ ddlPaperId } 不存在！`;
alert(strMsg);
throw (strMsg);
}
return new Promise((resolve, reject) => {
try
{
const responseText = Paper_GetObjLstAsync(strWhereCond).then((jsonData)=>{
var arrPaperObjLst: Array < clsPaperEN > = <Array<clsPaperEN>> jsonData;
    clsCommonFunc4Web.BindDdl_ObjLst(ddlPaperId, arrPaperObjLst, clsPaperEN.con_PaperId, clsPaperEN.con_PaperTitle, "论文表");
console.log("完成BindDdl_PaperId!");
resolve(jsonData);
});
}
catch (e)
{
var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
alert(strMsg);
}
});
}

 /* 根据关键字列表删除记录
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelMultiRecord)
*/
public DelMultiRecord(arrmId: Array<string>) {
return new Promise((resolve, reject) => {
try
{
const responseText = RTPaperRela_DelRTPaperRelasAsync(arrmId).then((jsonData)=>{
var returnInt: number = jsonData;
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
resolve(jsonData);
});
}
catch(e)
{
console.error('catch(e)=');
console.error(e);
var strMsg: string = `删除记录不成功. ${e}.`;
alert(strMsg);
}
});
}

 /* 
 根据关键字删除记录
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
*/
public DelRecord(lngmId: number) {
return new Promise((resolve, reject) => {
try
{
const responseText = RTPaperRela_DelRecordAsync(lngmId).then((jsonData)=>{
var returnInt: number = jsonData;
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
resolve(jsonData);
});
}
catch(e)
{
console.error('catch(e)=');
console.error(e);
var strMsg: string = `删除记录不成功. ${e}.`;
alert(strMsg);
}
});
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
 根据关键字详细信息记录
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DetailRecord)
  <param name = "sender">参数列表</param>
*/
public DetailRecord(lngmId: number) 
{
this.btnOKUpd = "";
this.btnCancel = "关闭";
return new Promise((resolve, reject) => {
try
{
const responseText = RTPaperRela_GetObjBymIdAsync(lngmId).then((jsonData)=>{
var objRTPaperRelaEN: clsRTPaperRelaEN = <clsRTPaperRelaEN>jsonData;
this.GetDataFromRTPaperRelaClass(objRTPaperRelaEN);
console.log("完成DetailRecord!");
resolve(jsonData);
});
}
catch(e)
{
console.error(e);
var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
alert(strMsg);
}
});
}

 /* 函数功能:把类对象的属性内容显示到界面上
 注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
  如果在设置数据库时,就应该一级字段在前,二级字段在后
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
  <param name = "pobjRTPaperRelaEN">表实体类对象</param>
*/
public GetDataFromRTPaperRelaClass(pobjRTPaperRelaEN: clsRTPaperRelaEN )
{
 this.topicId = pobjRTPaperRelaEN.topicId;// 主题编号
 this.paperId = pobjRTPaperRelaEN.paperId;// 论文Id
 this.updDate = pobjRTPaperRelaEN.updDate;// 修改日期
 this.updUser = pobjRTPaperRelaEN.updUser;// 修改人
 this.memo = pobjRTPaperRelaEN.memo;// 备注
}

 /* 函数功能:从界面列表中获取第一个关键字的值
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetFirstKey)
  <param name = "pobjRTPaperRelaEN">表实体类对象</param>
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
error: (e) => {
var strErrMsg = decodeURIComponent(e.responseText)
reject(e);
}
});
});
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
this.BindGv_vRTPaperRela();
}

 /* 函数功能:页面导入,当页面开始运行时所发生的事件
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
*/
public async Page_Load()
{
// 在此处放置用户代码以初始化页面
try
{

//1、为下拉框设置数据源,绑定列表数据
const ddl_TopicId = await this.BindDdl_TopicId("ddlTopicId");
const ddl_PaperId = await this.BindDdl_PaperId("ddlPaperId");
this.hidSortvRTPaperRelaBy = "updDate Asc";
var strWhereCond = this.CombinevRTPaperRelaCondition();
const responseText = await vRTPaperRela_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
this.RecCount = jsonData;
});
//2、显示无条件的表内容在GridView中
const gvResult = await this.BindGv_vRTPaperRela();
}
catch (e)
{
var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
alert(strMsg);
}
}


 /* 函数功能:把界面上的属性数据传到类对象中
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
  <param name = "pobjRTPaperRelaEN">数据传输的目的类对象</param>
*/
public PutDataToRTPaperRelaClass(pobjRTPaperRelaEN: clsRTPaperRelaEN)
{
pobjRTPaperRelaEN.topicId = this.topicId;// 主题编号
pobjRTPaperRelaEN.paperId = this.paperId;// 论文Id
pobjRTPaperRelaEN.updDate = this.updDate;// 修改日期
pobjRTPaperRelaEN.updUser = this.updUser;// 修改人
pobjRTPaperRelaEN.memo = this.memo;// 备注
}


 /* 根据条件获取相应的记录对象的列表
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_QueryLst)
*/
public QueryvRTPaperRelaLst(strListDiv:string) 
{
var strWhereCond = this.CombinevRTPaperRelaCondition();
var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
return new Promise((resolve, reject) => {
try
{
var objPagerPara: stuPagerPara = {
pageIndex: intCurrPageIndex,
pageSize: this.pageSize,
whereCond: strWhereCond,
    orderBy: this.hidSortvRTPaperRelaBy,
    sortFun: (x, y) => { return 0; }
};
const responseText = vRTPaperRela_GetObjLstByPagerAsync(objPagerPara).then((jsonData)=>{
var arrvRTPaperRelaObjLst : Array<clsvRTPaperRelaEN> = < Array<clsvRTPaperRelaEN>>jsonData;
this.BindTab_vRTPaperRela(strListDiv, arrvRTPaperRelaObjLst);
console.log("完成QueryvRTPaperRelaLst!");
resolve(jsonData);
});
}
catch(e)
{
console.error('catch(e)=');
console.error(e);
var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
alert(strMsg);
}
});
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
const responseText = await RTPaperRela_GetObjBymIdAsync(lngmId);
var objRTPaperRelaEN: clsRTPaperRelaEN = <clsRTPaperRelaEN>responseText;
console.log("完成SelectRecord!");
clsCommonFunc4Web.Redirect("/Index/Main_vRTPaperRela");
}
catch(e)
{
console.error(e);
var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
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

 /* 函数功能:把以该关键字的记录内容显示在界面上,
 　　　   在这里是把值传到表控件中
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ShowData)
  <param name = "lngmId">表记录的关键字,显示该表关键字的内容</param>
*/
  public async ShowData(lngmId: number) {
        //操作步骤:
        //1、检查关键字是否为空；
        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
        //3、用提供的关键字初始化一个类对象；
        //4、获取类对象的所有属性；
        //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
        var objRTPaperRelaEN: clsRTPaperRelaEN = new clsRTPaperRelaEN();
        try {
            const responseText = await RTPaperRela_IsExistAsync(lngmId);
            var returnBool: boolean = responseText;
            if (returnBool == false) {
                var strInfo: string = `关键字:[${ lngmId }] 的记录不存在!`;
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
            const responseText = await RTPaperRela_GetObjBymIdAsync(lngmId);
            objRTPaperRelaEN = <clsRTPaperRelaEN>responseText;
        }
        catch (e) {
            var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
            alert(strMsg);
        }
        //3、用提供的关键字初始化一个类对象；
        this.GetDataFromRTPaperRelaClass(objRTPaperRelaEN);
}

 /* 显示{0}对象的所有属性值
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ShowTabObj)
  <param name = "divContainer">显示容器</param>
  <param name = "objRTPaperRela">需要显示的对象</param>
*/
public ShowRTPaperRelaObj(divContainer: string, objRTPaperRela: clsRTPaperRelaEN) 
{
var o = document.getElementById(divContainer);
if (o == null)
{
alert(`${divContainer}不存在！`);
return;
}
var sstrKeys = clsCommonFunc4Web.GetObjKeys(objRTPaperRela);
var ul: HTMLUListElement = document.createElement("ul");
for (let strKey of sstrKeys)
{
var strValue = objRTPaperRela[strKey];
var li: HTMLLIElement = document.createElement("li");
li.innerHTML = `${ strKey}:${ strValue}`;
ul.appendChild(li);
}
o.appendChild(ul);
}

 /* 函数功能:从界面列表中根据某一个字段排序
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SortBy)
  <param name = "strSortByFld">排序的字段</param>
*/
public async SortBy(strSortByFld: string) {
if (this.hidSortvRTPaperRelaBy.indexOf(strSortByFld) >= 0)
{
if (this.hidSortvRTPaperRelaBy.indexOf("Asc") >= 0)
{
this.hidSortvRTPaperRelaBy = `${ strSortByFld} Desc`;
}
else
{
this.hidSortvRTPaperRelaBy = `${ strSortByFld} Asc`;
}
}
else
{
this.hidSortvRTPaperRelaBy = `${ strSortByFld} Asc`;
}
const responseText2 = await this.BindGv_vRTPaperRela();
}

 /* 根据关键字获取相应的记录的对象
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
  <param name = "sender">参数列表</param>
*/
public UpdateRecord(lngmId: number) 
{
this.btnOKUpd = "确认修改";
this.btnCancel = "取消修改";
this.KeyId = lngmId.toString();
return new Promise((resolve, reject) => {
try
{
const responseText = RTPaperRela_GetObjBymIdAsync(lngmId).then((jsonData)=>{
var objRTPaperRelaEN: clsRTPaperRelaEN = <clsRTPaperRelaEN>jsonData;
this.GetDataFromRTPaperRelaClass(objRTPaperRelaEN);
console.log("完成UpdateRecord!");
resolve(jsonData);
});
}
catch(e)
{
console.error(e);
var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
alert(strMsg);
}
});
}

 /* 修改记录
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
*/
public UpdateRecordSave(): Promise<boolean> {
this.DivName = "divUpdateRecordSave";
var objRTPaperRelaEN: clsRTPaperRelaEN = new clsRTPaperRelaEN();
objRTPaperRelaEN.mId = Number(this.KeyId);
   this.PutDataToRTPaperRelaClass(objRTPaperRelaEN);
objRTPaperRelaEN.sf_UpdFldSetStr = objRTPaperRelaEN.updFldString;//设置哪些字段被修改(脏字段)
if (objRTPaperRelaEN.mId == 0 || objRTPaperRelaEN.mId == undefined){
throw "关键字不能为空!";
}
return new Promise((resolve, reject) => {
try
{
const responseText = RTPaperRela_UpdateRecordAsync(objRTPaperRelaEN).then((jsonData)=>{
var returnBool: boolean = jsonData;
if (returnBool == true)
{
var strInfo: string = `修改记录成功!`;
$('#lblResult48').val(strInfo);
//显示信息框
alert(strInfo);
}
else
{
var strInfo: string = `修改记录不成功!`;
$('#lblResult48').val(strInfo);
//显示信息框
alert(strInfo);
console.log("完成UpdateRecordSave");
}
resolve(jsonData);
});
}
catch(e)
{
console.error('catch(e)=');
console.error(e);
var strMsg: string = `修改记录不成功,${e}.`;
    alert(strMsg);
    return false;
}
});
}
 /*
 * 设置取消按钮的标题
*/
public set btnCancel(value: string) {
$("#btnCancel").html(value);
}
 /*
 * 设置确定按钮的标题
*/
public set btnOKUpd(value: string) {
$("#btnOKUpd").html(value);
}
 /*
 * 获取按钮的标题
*/
public get btnOKUpd():string {
return $("#btnOKUpd").html();
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
public set hidSortvRTPaperRelaBy(value: string) {
$("#hidSortvRTPaperRelaBy").val(value);
}
 /*
 * 设置排序字段
*/
public get hidSortvRTPaperRelaBy():string {
return $("#hidSortvRTPaperRelaBy").val();
}
 /*
 * 用户Id
*/
public get hidUserId():string {
return $("#hidUserId").val();
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
 * 论文Id
*/
public set paperId(value: string) {
$("#ddlPaperId").val(value);
}
 /*
 * 论文Id
*/
public get paperId():string {
return $("#ddlPaperId").val();
}

 /*
 * 论文标题
*/
public get PaperTitle_q():string {
return $("#txtPaperTitle_q").val();
}
 /*
 * 主题编号
*/
public set topicId(value: string) {
$("#ddlTopicId").val(value);
}
 /*
 * 主题编号
*/
public get topicId():string {
return $("#ddlTopicId").val();
}
 /*
 * 栏目主题
*/
public get TopicName_q():string {
return $("#txtTopicName_q").val();
}
 /*
 * 修改日期
*/
public set updDate(value: string) {
$("#txtUpdDate").val(value);
}
 /*
 * 修改日期
*/
public get updDate():string {
return $("#txtUpdDate").val();
}
 /*
 * 修改人
*/
public set updUser(value: string) {
$("#txtUpdUser").val(value);
}
 /*
 * 修改人
*/
public get updUser():string {
return $("#txtUpdUser").val();
}
}