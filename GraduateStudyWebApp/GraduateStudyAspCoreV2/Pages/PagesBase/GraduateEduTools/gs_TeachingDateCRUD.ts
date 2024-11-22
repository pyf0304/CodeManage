
 /**
 * 类名:gs_TeachingDateCRUD(界面:gs_TeachingDateCRUD)
 * 表名:gs_TeachingDate(01120684)
 * 版本:2023.01.12.1(服务器:WIN-SRV103-116)
 * 日期:2023/01/12 16:40:16
 * 生成者:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 * 模块中文名:研培设置(GraduateEduTools)
 * 框架-层名:WA_界面后台_TS(TS)(WA_ViewScriptCS_TS)
 * 编程语言:TypeScript
 **/
//import $ from "jquery";
import { gs_TeachingDate_DelRecordAsync } from "../../TS/L3_ForWApi/GraduateEduTools/clsgs_TeachingDateWApi.js";
import { gs_TeachingDate_GetObjBymIdAsync } from "../../TS/L3_ForWApi/GraduateEduTools/clsgs_TeachingDateWApi.js";
import { clsvgs_TeachingDateEN } from "../../TS/L0_Entity/GraduateEduTools/clsvgs_TeachingDateEN.js";
import { clsvgs_TeachingDateENEx } from "../../TS/L0_Entity/GraduateEduTools/clsvgs_TeachingDateENEx.js";
import { vgs_TeachingDateEx_FuncMapByFldName } from "../../TS/L3_ForWApiEx/GraduateEduTools/clsvgs_TeachingDateExWApi.js";
import { vgs_TeachingDate_GetRecCountByCondAsync } from "../../TS/L3_ForWApi/GraduateEduTools/clsvgs_TeachingDateWApi.js";
import { vgs_TeachingDate_GetObjLstByPagerAsync } from "../../TS/L3_ForWApi/GraduateEduTools/clsvgs_TeachingDateWApi.js";
import { vgs_TeachingDate_GetRecCountByCond_Cache } from "../../TS/L3_ForWApi/GraduateEduTools/clsvgs_TeachingDateWApi.js";
import { vgs_TeachingDate_SortFun_Defa } from "../../TS/L3_ForWApi/GraduateEduTools/clsvgs_TeachingDateWApi.js";
import { vgs_TeachingDate_GetObjLstByPager_Cache } from "../../TS/L3_ForWApi/GraduateEduTools/clsvgs_TeachingDateWApi.js";
import { gs_TeachingDate_GetObjLstBymIdLstAsync } from "../../TS/L3_ForWApi/GraduateEduTools/clsgs_TeachingDateWApi.js";
import { gs_TeachingDate_AddNewRecordAsync } from "../../TS/L3_ForWApi/GraduateEduTools/clsgs_TeachingDateWApi.js";
import { gs_TeachingDate_Delgs_TeachingDatesAsync } from "../../TS/L3_ForWApi/GraduateEduTools/clsgs_TeachingDateWApi.js";
import { clsgs_TeachingDateEN } from "../../TS/L0_Entity/GraduateEduTools/clsgs_TeachingDateEN.js";
import {  arrSelectedKeys, BindDdl_TrueAndFalseInDiv, BindTab_V, confirm_del, GetObjKeys, Redirect, SortFun  } from "../../TS/PubFun/clsCommFunc4Web.js";
import {  GetCheckBoxValueInDiv, GetCheckedKeyIdsInDiv, GetInputValueInDiv, GetLabelHtmlInDiv, GetSelectObjInDiv, GetSelectValueInDiv, SetCheckBoxValueByIdInDiv, SetCheckedItem4KeyId, SetInputValueByIdInDiv, SetLabelHtmlByIdInDiv, SetSelectValueByIdInDiv } from "../../TS/PubFun/clsCommFunc4Ctrl.js";
import { clsPager } from "../../TS/PubFun/clsPager.js";
import { clsOrderByData } from "../../TS/PubFun/clsOrderByData.js";
import { stuPagerPara } from "../../TS/PubFun/stuPagerPara.js";
import { clsDataColumn } from "../../TS/PubFun/clsDataColumn.js";
import { TransToBool } from "../../TS/PubFun/clsString.js";
import { clsPubSessionStorage } from "../../TS/PubFun/clsPubSessionStorage.js";
import { Format, IsNullOrEmpty } from "../../TS/PubFun/clsString.js";
import { clsOperateList, ShowEmptyRecNumInfo, GetCurrPageIndex, GetSortBy } from "../../TS/PubFun/clsOperateList.js";
 /**
* 宣布一个用于导出Excel的函数，用于调用js端的导出Excel。
 **/
declare function exportSpecialExcel_pyf(arrData:any, strFileName:string): void;
/**
* 宣布一个已经在其他地方定义存在的变量strUrl_Session_SetString，
* 用于定义处理Session-设置String函数的地址
 **/
declare var strUrl_Session_SetString:string;
declare var strUrl_Session_GetString: string;
/**
* 宣布一个已经在其他地方定义存在的变量strCurrPrjId，
* 用于定义当前工程Id
 **/
declare var strCurrPrjId: string;
 /** gs_TeachingDateCRUD 的摘要说明。其中Q代表查询,U代表修改
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
 **/
export abstract class gs_TeachingDateCRUD implements clsOperateList
{
public static objPage_CRUD: gs_TeachingDateCRUD;
public static sortFun_Static: (ascOrDesc: string) => (x: any, y: any) => number;
public static ascOrDesc4SortFun = "Asc";
public static sortvgs_TeachingDateBy = "";

//专门用于数据列表的界面变量，用于分页功能等
public currPageIndex = 0;
public divName4List = "divList";  //列表区的层Id
public divName4DataList = "divDataLst";  //列表中数据区的层Id
public divName4Pager = "divPager";  //列表中的分页区的层Id
public bolIsInitShow = false;  //记录是否导入分页区的变量
public bolIsTableSm = true;//是否窄行的小表，即表中加样式： table-sm
//public mstrListDiv = "divDataLst";//列表区数据列表层id
public objPager: clsPager;

public static id_CurrEduCls_Cache = "";//缓存分类字段
public divName4Query = "divQuery";  //查询区的层Id
public divName4Function = "divFunction";  //功能区的层Id
public divName4Layout = "divLayout";  //界面布局的层Id
constructor() {
gs_TeachingDateCRUD.objPage_CRUD = this;
this.objPager = new clsPager(this);
}
 /**
 * 每页记录数，在扩展类可以修改
 **/
public get pageSize():number {
return 5;
}
public recCount = 0;





 /** 函数功能:页面导入,当页面开始运行时所发生的事件
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
 **/
public async Page_Load()
{
const strThisFuncName = this.Page_Load.name;
// 在此处放置用户代码以初始化页面
try
{
this.SetEventFunc();
 // 为查询区绑定下拉框
const gvBindDdl = await this.BindDdl4QueryRegion();


gs_TeachingDateCRUD.sortvgs_TeachingDateBy = "startDate Asc";
if (this.bolIsInitShow == false)  //
{
this.objPager.InitShow(this.divName4Pager);
this.bolIsInitShow = true;  //
}
//2、显示无条件的表内容在GridView中
const responseBindGv = await this.BindGv_vgs_TeachingDate();
}
catch (e)
{
const strMsg = Format("页面启动不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
console.error("Error: ", strMsg);
//console.trace();
alert(strMsg);
}
}


 /** 函数功能:设置事件函数
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SetEventFunc)
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


 /** 函数功能:页面导入,当页面开始运行时所发生的事件
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load_Cache)
 **/
public async Page_Load_Cache()
{
const strThisFuncName = this.Page_Load_Cache.name;
// 在此处放置用户代码以初始化页面
try
{
 // 为查询区绑定下拉框
const gvBindDdl = await this.BindDdl4QueryRegion();


this.SetEventFunc();
gs_TeachingDateCRUD.sortvgs_TeachingDateBy = "startDate Asc";
if (this.bolIsInitShow == false)  //
{
this.objPager.InitShow(this.divName4Pager);
this.bolIsInitShow = true;  //
}
//2、显示无条件的表内容在GridView中
const responseBindGv = await this.BindGv_vgs_TeachingDate();
}
catch (e)
{
const strMsg = Format("页面启动不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
console.error("Error: ", strMsg);
//console.trace();
alert(strMsg);
}
}


 /** 根据条件获取相应的对象列表
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
 **/
public async btnQuery_Click() 
{
const strThisFuncName = this.btnQuery_Click.name;
this.SetCurrPageIndex(1);
const responseBindGv = await this.BindGv_vgs_TeachingDate();
}

 /** 函数功能:为查询区绑定下拉框
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4QueryRegion)
 **/
public async BindDdl4QueryRegion()
{
const strThisFuncName = this.BindDdl4QueryRegion.name;
// 在此处放置用户代码以初始化页面

}


 /**
 * 添加新记录
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnCopyRecord_Click)
 **/
public async btnCopyRecord_Click() {
const strThisFuncName = this.btnCopyRecord_Click.name;
try
{
const arrKeyIds = GetCheckedKeyIdsInDiv(this.divName4List);
if (arrKeyIds.length == 0)
{
alert("请选择需要克隆的记录！");
return "";
}
await this.CopyRecord(arrKeyIds);
await this.BindGv_vgs_TeachingDate();
}
catch(e)
{
const strMsg = Format("复制记录不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
}

 /** 
 * 在数据表里删除记录
 * "lngmId": 表关键字
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecordInTab_Click)
 **/
public async btnDelRecordInTab_Click(strKeyId:string) {
const strThisFuncName = this.btnDelRecordInTab_Click.name;
try
{
 if (strKeyId == "")
{
alert("请选择需要删除的记录！");
return "";
}
if (confirm_del(0) == false)
{
return;
}
const lngKeyId =  Number(strKeyId);
const responseText = await this.DelRecord(lngKeyId);
 await this.BindGv_vgs_TeachingDate();
}
catch(e)
{
const strMsg = Format("删除记录不成功. {0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
}

 /** 
 * 在数据表里选择记录
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnSelectRecordInTab_Click)
 **/
public async btnSelectRecordInTab_Click(lngmId: number) {
const strThisFuncName = this.btnSelectRecordInTab_Click.name;
try
{
if (lngmId == 0)
{
const strMsg = "请选择相关记录，请检查！";
console.error(strMsg);
alert(strMsg);
return;
}
if (confirm_del(0) == false)
{
return;
}
this.SelectRecord(lngmId);
}
catch(e)
{
const strMsg = Format("选择记录不成功. {0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
}

 /** 
 * 根据关键字删除记录
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
 **/
public async DelRecord(lngmId: number) {
const strThisFuncName = this.DelRecord.name;
try
{
const returnInt = await gs_TeachingDate_DelRecordAsync(lngmId);
if (returnInt > 0)
{
//gs_TeachingDate_ReFreshCache(gs_TeachingDateCRUD.id_CurrEduCls_Cache);
const strInfo = Format("删除记录成功,共删除{0}条记录!", returnInt);
//显示信息框
alert(strInfo);
}
else
{
const strInfo = Format("删除记录不成功!");
//显示信息框
alert(strInfo);
}
console.log("完成DelRecord!");
}
catch(e)
{
const strMsg = Format("删除记录不成功. {0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
}

 /** 
 * 根据关键字选择相应的记录
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SelectRecord)
 * @param sender:参数列表
 **/
public async SelectRecord(lngmId: number) 
{
const strThisFuncName = this.SelectRecord.name;
try
{
const objgs_TeachingDateEN = await gs_TeachingDate_GetObjBymIdAsync(lngmId);
//console.log("完成SelectRecord!", objgs_TeachingDateEN);
Redirect("/Index/Main_vgs_TeachingDate");
}
catch(e)
{
const strMsg = Format("根据关键字获取相应的记录的对象不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
console.error("Error: ", strMsg);
//console.trace();
alert(strMsg);
}
}

 /** 删除记录
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecord_Click)
 **/
public async btnDelRecord_Click() {
const strThisFuncName = this.btnDelRecord_Click.name;
try
{
const arrKeyIds = GetCheckedKeyIdsInDiv(this.divName4List);
if (arrKeyIds.length == 0)
{
alert("请选择需要删除的记录！");
return "";
}
if (confirm_del(arrKeyIds.length) == false)
{
return;
}
await this.DelMultiRecord(arrKeyIds);
await this.BindGv_vgs_TeachingDate();
}
catch(e)
{
const strMsg = Format("删除记录不成功. {0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
}

 /** 把所有的查询控件内容组合成一个条件串
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
 * @returns 条件串(strWhereCond)
 **/
 public async Combinevgs_TeachingDateCondition():Promise<string> 
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。

try
{
if ( this.startDate_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsvgs_TeachingDateEN.con_StartDate, this.startDate_q);
}
if ( this.endDate_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsvgs_TeachingDateEN.con_EndDate, this.endDate_q);
}
}
catch(objException)
{
const strMsg:string = Format("(errid:WiTsCs0009)在组合查询条件(Combinegs_TeachingDateCondition)时出错!请联系管理员!{0}", objException);
throw strMsg;
}
return strWhereCond;
}

 /** 把所有的查询控件内容组合成一个条件串
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
 * @returns 条件串(strWhereCond)
 **/
 public async Combinevgs_TeachingDateConditionObj(): Promise<clsvgs_TeachingDateEN> 
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
const objvgs_TeachingDate_Cond = new clsvgs_TeachingDateEN();
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
try
{
if ( this.startDate_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsvgs_TeachingDateEN.con_StartDate, this.startDate_q);
objvgs_TeachingDate_Cond.SetCondFldValue(clsvgs_TeachingDateEN.con_StartDate, this.startDate_q, "like");
}
if ( this.endDate_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsvgs_TeachingDateEN.con_EndDate, this.endDate_q);
objvgs_TeachingDate_Cond.SetCondFldValue(clsvgs_TeachingDateEN.con_EndDate, this.endDate_q, "like");
}

}
catch(objException)
{
const strMsg:string = Format("(errid:WiTsCs0010)在组合查询条件对象(Combinegs_TeachingDateConditionObj)时出错!请联系管理员!{0}", objException);
throw strMsg;
}
objvgs_TeachingDate_Cond.whereCond = strWhereCond;
return objvgs_TeachingDate_Cond;
}

 /** 显示vgs_TeachingDate对象的所有属性值
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
 * @param divContainer:显示容器
 * @param arrgs_TeachingDateObjLst:需要绑定的对象列表
 **/
public async BindTab_vgs_TeachingDate(divContainer: string, arrvgs_TeachingDateObjLst: Array<clsvgs_TeachingDateEN>) 
{
const strThisFuncName = this.BindTab_vgs_TeachingDate.name;
const o: HTMLDivElement = document.getElementById(divContainer) as HTMLDivElement;
if (o == null)
{
alert(Format("{0}不存在！",divContainer));
return;
}
const arrDataColumn: Array < clsDataColumn > =
       [
{
fldName: "",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "",
text: "",
tdClass: "text-left",
columnType: "CheckBox",
orderNum: 1,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: clsvgs_TeachingDateEN.con_CurrEduClsId,
sortBy: clsvgs_TeachingDateEN.con_CurrEduClsId,
sortFun: SortFun,
getDataSource: "",
colHeader: "当前教学班Id",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 2,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: clsvgs_TeachingDateEN.con_EduClsName,
sortBy: clsvgs_TeachingDateEN.con_EduClsName,
sortFun: SortFun,
getDataSource: "",
colHeader: "教学班名称",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 3,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: clsvgs_TeachingDateEN.con_StartDate,
sortBy: clsvgs_TeachingDateEN.con_StartDate,
sortFun: SortFun,
getDataSource: "",
colHeader: "开始日期",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 4,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: clsvgs_TeachingDateEN.con_EndDate,
sortBy: clsvgs_TeachingDateEN.con_EndDate,
sortFun: SortFun,
getDataSource: "",
colHeader: "截止日期",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 5,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: clsvgs_TeachingDateEN.con_UpdDate,
sortBy: clsvgs_TeachingDateEN.con_UpdDate,
sortFun: SortFun,
getDataSource: "",
colHeader: "修改日期",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 6,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: clsvgs_TeachingDateEN.con_UpdUser,
sortBy: clsvgs_TeachingDateEN.con_UpdUser,
sortFun: SortFun,
getDataSource: "",
colHeader: "修改人",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 7,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
];
await BindTab_V(o, arrvgs_TeachingDateObjLst, arrDataColumn,  clsvgs_TeachingDateEN.con_mId, this); 
this.objPager.recCount = this.recCount;
this.objPager.pageSize = this.pageSize;
this.objPager.ShowPagerV2(this, this.divName4Pager);
}

 /** 扩展字段值的函数映射
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ExtendFldFuncMap)
 * @param arrvgs_TeachingDateExObjLst:需要映射的对象列表
 * @param arrDataColumn:用于绑定表的数据列信息
 **/
public async ExtendFldFuncMap(arrvgs_TeachingDateExObjLst: Array<clsvgs_TeachingDateENEx>, arrDataColumn: Array<clsDataColumn>) {
const arrFldName = clsvgs_TeachingDateEN.AttributeName;
for (const objDataColumn of arrDataColumn) {
if (IsNullOrEmpty(objDataColumn.fldName) == true) continue;
if (arrFldName.indexOf(objDataColumn.fldName) > -1) continue;
for (const objInFor of arrvgs_TeachingDateExObjLst) {
await vgs_TeachingDateEx_FuncMapByFldName(objDataColumn.fldName, objInFor);
}
}
}

 /** 函数功能:在数据列表中跳转到前一页
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PrevPage)
 **/
public async PrevPage()
{
const strThisFuncName = this.PrevPage.name;
const intCurrPageIndex = this.objPager.currPageIndex;
const intPageIndex = Number(intCurrPageIndex) - 1;
//console.log("跳转到" + intPageIndex + "页");
this.IndexPage(intPageIndex);
}

 /** 函数功能:在数据 列表中跳转到某一页
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
 * @param intPageIndex:页序号
 **/
public async IndexPage(intPageIndex:number)
{
const strThisFuncName = this.IndexPage.name;
if (intPageIndex == 0)
{
intPageIndex = this.objPager.pageCount;
}
//console.log("跳转到" + intPageIndex + "页");
this.SetCurrPageIndex(intPageIndex);
const responseBindGv = await this.BindGv_vgs_TeachingDate();
}

 /** 函数功能:在数据列表中跳转到下一页
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_NextPage)
 **/
public async NextPage()
{
const strThisFuncName = this.NextPage.name;
const intCurrPageIndex = this.objPager.currPageIndex;
const intPageIndex = Number(intCurrPageIndex) + 1;
//console.log("跳转到" + intPageIndex + "页");
this.IndexPage(intPageIndex);
}

 /** 根据条件获取相应的对象列表
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
 **/
public async BindGv_vgs_TeachingDate() 
{
const strThisFuncName = this.BindGv_vgs_TeachingDate.name;
if (gs_TeachingDateCRUD.sortvgs_TeachingDateBy == null)
{
const strMsg = Format("在显示列表时，排序字段(sortvgs_TeachingDateBy)为空，请检查！(In BindGv_vgs_TeachingDate)");
console.error(strMsg);
alert(strMsg);
return;
}
const strListDiv = this.divName4DataList;
const strWhereCond = await this.Combinevgs_TeachingDateCondition();
let intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
 let arrvgs_TeachingDateObjLst: Array <clsvgs_TeachingDateEN> = [];
try
{
this.recCount = await vgs_TeachingDate_GetRecCountByCondAsync(strWhereCond);
if (this.recCount == 0)
{
const lblMsg: HTMLSpanElement = < HTMLSpanElement > document.createElement("span");
lblMsg.innerHTML = Format("根据条件:[{0}]获取的对象列表数为0！", strWhereCond);
const divDataLst: HTMLDivElement = < HTMLDivElement > document.getElementById("divDataLst");
if (divDataLst != null)
{
divDataLst.innerText = "";
divDataLst.appendChild(lblMsg);
}
const strMsg = Format("在绑定Gv过程中，根据条件:[{0}]获取的对象列表数为0！", strWhereCond);
console.error("Error: ", strMsg);
//console.trace();
alert(strMsg);
return;
}
const intPageCount = this.objPager.GetPageCount(this.recCount, this.pageSize);
if (intCurrPageIndex == 0)
{
if (intPageCount > 1) intCurrPageIndex = intPageCount;
else intCurrPageIndex = 1;
this.SetCurrPageIndex(intCurrPageIndex);
}
else if (intCurrPageIndex > intPageCount)
{
intCurrPageIndex = intPageCount;
this.SetCurrPageIndex(intCurrPageIndex);
}
const objPagerPara: stuPagerPara = {
pageIndex: intCurrPageIndex,
pageSize: this.pageSize,
whereCond: strWhereCond,
orderBy: gs_TeachingDateCRUD.sortvgs_TeachingDateBy,//如果该字段为空，就使用下面的排序函数
sortFun: (x, y) => { console.log(x,y);return 0;}
}
const responseObjLst = await vgs_TeachingDate_GetObjLstByPagerAsync(objPagerPara).then((jsonData)=>{
arrvgs_TeachingDateObjLst = < Array<clsvgs_TeachingDateEN>>jsonData;
});
}
catch(e)
{
const strMsg = Format("绑定GridView不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
console.error("Error: ", strMsg);
//console.trace();
alert(strMsg);
}
const divPager: HTMLDivElement = < HTMLDivElement > document.getElementById("divPager");
if (this.recCount <= this.pageSize)
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
if (arrvgs_TeachingDateObjLst.length == 0)
{
const lblMsg: HTMLSpanElement = < HTMLSpanElement > document.createElement("span");
lblMsg.innerHTML = "根据条件获取的对象列表数为0！";
const divDataLst: HTMLDivElement = < HTMLDivElement > document.getElementById("divDataLst");
if (divDataLst != null)
{
divDataLst.innerText = "";
divDataLst.appendChild(lblMsg);
}
const strMsg = Format("根据条件获取的记录数为0！");
console.error("Error: ", strMsg);
//console.trace();
ShowEmptyRecNumInfo(strListDiv, strMsg);
this.objPager.Hide(this.divName4Pager);
return;
}
try
{
await this.BindTab_vgs_TeachingDate(strListDiv, arrvgs_TeachingDateObjLst);
//console.log("完成BindGv_vgs_TeachingDate!");
}
catch(e)
{
//console.trace();
const strMsg = Format("绑定对象列表不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
}

 /** 根据条件获取相应的对象列表
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv_Cache)
 **/
public async BindGv_vgs_TeachingDate_Cache() 
{
const strThisFuncName = this.BindGv_vgs_TeachingDate_Cache.name;
if (gs_TeachingDateCRUD.sortvgs_TeachingDateBy == null)
{
const strMsg = Format("在显示列表时，排序字段(sortvgs_TeachingDateBy)为空，请检查！(In BindGv_vgs_TeachingDate_Cache)");
console.error(strMsg);
alert(strMsg);
return;
}
const strListDiv = this.divName4DataList;
const objvgs_TeachingDate_Cond = await this.Combinevgs_TeachingDateConditionObj();
objvgs_TeachingDate_Cond.SetCondFldValue(clsvgs_TeachingDateEN.con_id_CurrEduCls, gs_TeachingDateCRUD.id_CurrEduCls_Cache, "=");
const strWhereCond = JSON.stringify(objvgs_TeachingDate_Cond);
let intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
 let arrvgs_TeachingDateObjLst: Array <clsvgs_TeachingDateEN> = [];
try
{
this.recCount = await vgs_TeachingDate_GetRecCountByCond_Cache(objvgs_TeachingDate_Cond, gs_TeachingDateCRUD.id_CurrEduCls_Cache);
if (this.recCount == 0)
{
const lblMsg: HTMLSpanElement = < HTMLSpanElement > document.createElement("span");
lblMsg.innerHTML = Format("根据条件:[{0}]获取的对象列表数为0！", objvgs_TeachingDate_Cond.whereCond);
const divDataLst: HTMLDivElement = <HTMLDivElement> document.getElementById("divDataLst");
if (divDataLst != null)
{
divDataLst.innerText = "";
divDataLst.appendChild(lblMsg);
}
const strMsg = Format("在绑定Gv_Cache过程中，根据条件:[{0}]获取的对象列表数为0！", objvgs_TeachingDate_Cond.whereCond);
console.error("Error: ", strMsg);
//console.trace();
alert(strMsg);
return;
}
const intPageCount = this.objPager.GetPageCount(this.recCount, this.pageSize);
if (intCurrPageIndex == 0)
{
if (intPageCount > 1) intCurrPageIndex = intPageCount;
else intCurrPageIndex = 1;
this.SetCurrPageIndex(intCurrPageIndex);
}
else if (intCurrPageIndex > intPageCount)
{
intCurrPageIndex = intPageCount;
this.SetCurrPageIndex(intCurrPageIndex);
}
const objPagerPara: stuPagerPara = {
pageIndex: intCurrPageIndex,
pageSize: this.pageSize,
whereCond: strWhereCond,
orderBy: gs_TeachingDateCRUD.sortvgs_TeachingDateBy,//如果该字段为空，就使用下面的排序函数
sortFun: vgs_TeachingDate_SortFun_Defa
}
arrvgs_TeachingDateObjLst = await vgs_TeachingDate_GetObjLstByPager_Cache(objPagerPara, gs_TeachingDateCRUD.id_CurrEduCls_Cache);
}
catch(e)
{
const strMsg = Format("绑定GridView不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
const divPager: HTMLDivElement = < HTMLDivElement > document.getElementById("divPager");
if (this.recCount <= this.pageSize)
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
if (arrvgs_TeachingDateObjLst.length == 0)
{
const lblMsg: HTMLSpanElement = < HTMLSpanElement > document.createElement("span");
lblMsg.innerHTML = "根据条件获取的对象列表数为0！";
const divDataLst: HTMLDivElement = < HTMLDivElement > document.getElementById("divDataLst");
if (divDataLst != null)
{
divDataLst.innerText = "";
divDataLst.appendChild(lblMsg);
}
const strKey = Format("{0}_{1}", clsgs_TeachingDateEN._CurrTabName, gs_TeachingDateCRUD.id_CurrEduCls_Cache);
const strMsg = Format("根据条件获取的记录数为0！(Key={0})", strKey);
console.error("Error: ", strMsg);
//console.trace();
ShowEmptyRecNumInfo(strListDiv, strMsg);
this.objPager.Hide(this.divName4Pager);
return;
}
try
{
await this.BindTab_vgs_TeachingDate(strListDiv, arrvgs_TeachingDateObjLst);
//console.log("完成BindGv_vgs_TeachingDate_Cache!");
}
catch(e)
{
const strMsg = Format("绑定对象列表不成功, {0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
}

 /** 函数功能:从界面列表中根据某一个字段排序
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SortBy)
 * @param objAnchorElement:带有排序字段的Anchors
 **/
public async SortBy(objAnchorElement:any) {
const strThisFuncName = this.SortBy.name;
 console.log("objAnchorElement(In SetAllCkechedKeysV2):", objAnchorElement);
let strSortExpress = "";
//event = window.event || event;
if (typeof(objAnchorElement) != "function")
{
const thisEventObj: HTMLInputElement = objAnchorElement;
strSortExpress = thisEventObj.getAttribute("FldName") as string;
}
const { sortFun, ascOrDesc4SortFun, sortBy } = GetSortBy(objAnchorElement, gs_TeachingDateCRUD.ascOrDesc4SortFun, gs_TeachingDateCRUD.sortvgs_TeachingDateBy, strSortExpress);
gs_TeachingDateCRUD.sortvgs_TeachingDateBy = sortBy;
gs_TeachingDateCRUD.ascOrDesc4SortFun = ascOrDesc4SortFun;
gs_TeachingDateCRUD.sortFun_Static = sortFun;
await this.BindGv_vgs_TeachingDate();
}

 /** 复制记录
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CopyRecord)
 **/
public async CopyRecord(arrmId: Array<string>) {
const strThisFuncName = this.CopyRecord.name;
try
{
const arrgs_TeachingDateObjLst = await gs_TeachingDate_GetObjLstBymIdLstAsync(arrmId);
//console.log('responseText=');
//console.log(responseText);
let intCount = 0;
for (const objInFor of arrgs_TeachingDateObjLst)
{
const returnBool = await gs_TeachingDate_AddNewRecordAsync(objInFor);
//console.log('returnBool=');
//console.log(returnBool);
if (returnBool == true)
{
//gs_TeachingDate_ReFreshCache(gs_TeachingDateCRUD.id_CurrEduCls_Cache);
const strInfo = Format("克隆记录成功!");
intCount++;
}
else
{
const strInfo = Format("克隆记录不成功!");
//显示信息框
alert(strInfo);
}
}
const strInfo = Format("共克隆了{0}条记录!", intCount);
alert(strInfo);
//console.log('完成！');
}
catch (e)
{
const strMsg = Format("复制记录不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
console.error("Error: ", strMsg);
//console.trace();
alert(strMsg);
}
}

 /** 根据关键字列表删除记录
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelMultiRecord)
 **/
public async DelMultiRecord(arrmId: Array<string>) {
const strThisFuncName = this.DelMultiRecord.name;
try
{
const returnInt = await gs_TeachingDate_Delgs_TeachingDatesAsync(arrmId);
if (returnInt > 0)
{
//gs_TeachingDate_ReFreshCache(gs_TeachingDateCRUD.id_CurrEduCls_Cache);
const strInfo = Format("删除记录成功,共删除{0}条记录!", returnInt);
//显示信息框
alert(strInfo);
}
else
{
const strInfo = Format("删除记录不成功!");
//显示信息框
alert(strInfo);
}
console.log("完成DelMultiRecord!");
}
catch(e)
{
const strMsg = Format("删除记录不成功. {0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
}

 /** 显示{0}对象的所有属性值
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ShowTabObj)
 * @param divContainer:显示容器
 * @param objgs_TeachingDate:需要显示的对象
 **/
public Showgs_TeachingDateObj(divContainer: string, objgs_TeachingDate: clsgs_TeachingDateEN) 
{
const strThisFuncName = this.Showgs_TeachingDateObj.name;
const o = document.getElementById(divContainer);
if (o == null)
{
alert(Format("{}不存在！",divContainer));
return;
}
const sstrKeys = GetObjKeys(objgs_TeachingDate);
const ul: HTMLUListElement = document.createElement("ul");
for (const strKey of sstrKeys)
{
const strValue = objgs_TeachingDate.GetFldValue(strKey);
const li: HTMLLIElement = document.createElement("li");
li.innerHTML = Format("{0}:{1}", strKey, strValue);
ul.appendChild(li);
}
o.appendChild(ul);
}

 /** 函数功能:从界面列表中获取第一个关键字的值
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetFirstKey)
 * @param pobjgs_TeachingDateEN:表实体类对象
 * @returns 列表的第一个关键字值
 **/
public GetFirstKey(): string {
const strThisFuncName = this.GetFirstKey.name;
if (arrSelectedKeys.length == 1) {
return arrSelectedKeys[0];
}
else {
alert(`请选择一个关键字！目前选择了:${ arrSelectedKeys.length}个关键字。`);
return "";
}
}

 /** 函数功能:设置当前页序号
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SetCurrPageIndex)
 * @param value:页序号
 * @param strDivName4Pager:当前分页所在的层(div)
 **/
public SetCurrPageIndex(value: number) {
       this.objPager.currPageIndex = value;
}

 /** 函数功能:预留函数，在某一个层(div)里绑定数据
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindInDiv)
 **/
public async BindInDiv(divName4Bind: string) {
}
 /**
 * 截止日期 (Used In CombineCondition())
 **/
public  get endDate_q():string {
const strValue = GetInputValueInDiv(this.divName4Query, "txtEndDate_q");
if (strValue == undefined) return "";
else return strValue.toString();
}
 /**
 * 截止日期 (Used In CombineCondition())
 **/
public  set endDate_q(value: string) {
 SetInputValueByIdInDiv(this.divName4Query, "txtEndDate_q", value);
}
 /**
 * 开始日期 (Used In CombineCondition())
 **/
public  get startDate_q():string {
const strValue = GetInputValueInDiv(this.divName4Query, "txtStartDate_q");
if (strValue == undefined) return "";
else return strValue.toString();
}
 /**
 * 开始日期 (Used In CombineCondition())
 **/
public  set startDate_q(value: string) {
 SetInputValueByIdInDiv(this.divName4Query, "txtStartDate_q", value);
}
 /**
 * 设置界面标题-相当使用ViewState功能
 **/
public  set ViewTitle(value: string) {
 SetLabelHtmlByIdInDiv(this.divName4Layout, "lblViewTitle", value);
}
 /**
 * 设置界面标题
 **/
public  get ViewTitle():string {
const strValue = GetLabelHtmlInDiv(this.divName4Query, "lblViewTitle");
return strValue;
}
}