
 /**
 * 类名:gs_TotalDataStatisticsCRUD(界面:gs_TotalDataStatisticsCRUD)
 * 表名:gs_TotalDataStatistics(01120683)
 * 版本:2023.01.12.1(服务器:WIN-SRV103-116)
 * 日期:2023/01/12 16:40:19
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
import { vgs_TotalDataStatistics_GetRecCountByCondAsync } from "../../TS/L3_ForWApi/GraduateEduTools/clsvgs_TotalDataStatisticsWApi.js";
import { vgs_TotalDataStatistics_GetObjLstAsync } from "../../TS/L3_ForWApi/GraduateEduTools/clsvgs_TotalDataStatisticsWApi.js";
import { vgs_TotalDataStatistics_GetRecCountByCond_Cache } from "../../TS/L3_ForWApi/GraduateEduTools/clsvgs_TotalDataStatisticsWApi.js";
import { vgs_TotalDataStatistics_GetSubObjLst_Cache } from "../../TS/L3_ForWApi/GraduateEduTools/clsvgs_TotalDataStatisticsWApi.js";
import { CurrEduCls_BindDdl_id_CurrEduClsInDiv_Cache } from "../../TS/L3_ForWApi/DailyRunning_Share/clsCurrEduClsWApi.js";
import { SchoolYear_BindDdl_SchoolYearInDiv_Cache } from "../../TS/L3_ForWApi/SysPara/clsSchoolYearWApi.js";
import { SchoolTerm_BindDdl_SchoolTermInDiv_Cache } from "../../TS/L3_ForWApi/SysPara/clsSchoolTermWApi.js";
import { gs_TotalDataStatistics_DelRecordAsync } from "../../TS/L3_ForWApi/GraduateEduTools/clsgs_TotalDataStatisticsWApi.js";
import { gs_TotalDataStatistics_ReFreshCache } from "../../TS/L3_ForWApi/GraduateEduTools/clsgs_TotalDataStatisticsWApi.js";
import { gs_TotalDataStatistics_GetObjByTotalDataIdAsync } from "../../TS/L3_ForWApi/GraduateEduTools/clsgs_TotalDataStatisticsWApi.js";
import { clsvgs_TotalDataStatisticsEN } from "../../TS/L0_Entity/GraduateEduTools/clsvgs_TotalDataStatisticsEN.js";
import { clsvgs_TotalDataStatisticsENEx } from "../../TS/L0_Entity/GraduateEduTools/clsvgs_TotalDataStatisticsENEx.js";
import { vgs_TotalDataStatisticsEx_FuncMapByFldName } from "../../TS/L3_ForWApiEx/GraduateEduTools/clsvgs_TotalDataStatisticsExWApi.js";
import { vgs_TotalDataStatistics_SortFun_Defa } from "../../TS/L3_ForWApi/GraduateEduTools/clsvgs_TotalDataStatisticsWApi.js";
import { vgs_TotalDataStatistics_GetObjLstByPager_Cache } from "../../TS/L3_ForWApi/GraduateEduTools/clsvgs_TotalDataStatisticsWApi.js";
import { gs_TotalDataStatistics_GetObjLstByTotalDataIdLstAsync } from "../../TS/L3_ForWApi/GraduateEduTools/clsgs_TotalDataStatisticsWApi.js";
import { gs_TotalDataStatistics_AddNewRecordAsync } from "../../TS/L3_ForWApi/GraduateEduTools/clsgs_TotalDataStatisticsWApi.js";
import { gs_TotalDataStatistics_Delgs_TotalDataStatisticssAsync } from "../../TS/L3_ForWApi/GraduateEduTools/clsgs_TotalDataStatisticsWApi.js";
import { clsgs_TotalDataStatisticsEN } from "../../TS/L0_Entity/GraduateEduTools/clsgs_TotalDataStatisticsEN.js";
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
 /** gs_TotalDataStatisticsCRUD 的摘要说明。其中Q代表查询,U代表修改
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
 **/
export abstract class gs_TotalDataStatisticsCRUD implements clsOperateList
{
public static objPage_CRUD: gs_TotalDataStatisticsCRUD;
public static sortFun_Static: (ascOrDesc: string) => (x: any, y: any) => number;
public static ascOrDesc4SortFun = "Asc";
public static sortvgs_TotalDataStatisticsBy = "";

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
public static CourseId_Static = "";//查询区下拉框条件变量1
public divName4Query = "divQuery";  //查询区的层Id
public divName4Function = "divFunction";  //功能区的层Id
public divName4Layout = "divLayout";  //界面布局的层Id
constructor() {
gs_TotalDataStatisticsCRUD.objPage_CRUD = this;
this.objPager = new clsPager(this);
}
 /**
 * 每页记录数，在扩展类可以修改
 **/
public get pageSize():number {
return 5;
}
public recCount = 0;





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
gs_TotalDataStatisticsCRUD.sortvgs_TotalDataStatisticsBy = "id_CurrEduCls Asc";
if (this.bolIsInitShow == false)  //
{
this.objPager.InitShow(this.divName4Pager);
this.bolIsInitShow = true;  //
}
//2、显示无条件的表内容在GridView中
const responseBindGv = await this.BindGv_vgs_TotalDataStatistics_Cache();
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
const responseBindGv = await this.BindGv_vgs_TotalDataStatistics_Cache();
}

 /** 合并数据
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineData)
 **/
public CombineData(arrvgs_TotalDataStatisticsObjLst: Array<clsvgs_TotalDataStatisticsEN>, arrDataColumn: Array<clsDataColumn>) 
{
const strThisFuncName = this.CombineData.name;
const intRowNum = arrvgs_TotalDataStatisticsObjLst.length;
const intColNum = arrDataColumn.length;
const arrData: Array < Array < any >> = new Array<Array<any>>();
const arrHead: Array < any > = new Array<any>();
for (let j = 0; j < intColNum; j++)
{
arrHead.push(arrDataColumn[j].colHeader);
}
arrData.push(arrHead);
for (let i = 0; i < intRowNum; i++)
{
const arrRow: Array < any > = new Array<any>();
const objEN: clsvgs_TotalDataStatisticsEN = arrvgs_TotalDataStatisticsObjLst[i];
for (let j = 0; j < intColNum; j++)
{
arrRow.push(objEN.GetFldValue(arrDataColumn[j].fldName));//i + "" + j;
}
arrData.push(arrRow);
}
//console.log("arrData", arrData);
const strFileName = Format("总数据统计({0})导出.xlsx",
 clsvgs_TotalDataStatisticsEN._CurrTabName);
exportSpecialExcel_pyf(arrData, strFileName);
}

 /** 根据条件获取相应的对象列表
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ExportExcel)
 **/
public async ExportExcel_vgs_TotalDataStatistics() 
{
const strThisFuncName = this.ExportExcel_vgs_TotalDataStatistics.name;
if (gs_TotalDataStatisticsCRUD.sortvgs_TotalDataStatisticsBy == null)
{
const strMsg = Format("在显示列表时，排序字段(sortvgs_TotalDataStatisticsBy)为空，请检查！(In BindGv_vgs_TotalDataStatistics_Cache)");
console.error(strMsg);
alert(strMsg);
return;
}
const strListDiv = this.divName4DataList;
const strWhereCond = await this.Combinevgs_TotalDataStatisticsCondition();
const intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
 let arrvgs_TotalDataStatisticsObjLst: Array <clsvgs_TotalDataStatisticsEN> = [];
try
{
this.recCount = await vgs_TotalDataStatistics_GetRecCountByCondAsync(strWhereCond);
if (this.recCount == 0)
{
const lblMsg: HTMLSpanElement = < HTMLSpanElement > document.createElement("span");
lblMsg.innerHTML = Format("根据条件:[{0}]获取的对象列表数为0！", strWhereCond);
const divDataLst: HTMLDivElement = <HTMLDivElement> document.getElementById("divDataLst");
if (divDataLst != null)
{
divDataLst.innerText = "";
divDataLst.appendChild(lblMsg);
}
const strMsg = Format("在绑定ExportExcel过程中，根据条件:[{0}]获取的对象列表数为0！", strWhereCond);
console.error("Error: ", strMsg);
//console.trace();
alert(strMsg);
return;
}
arrvgs_TotalDataStatisticsObjLst = await vgs_TotalDataStatistics_GetObjLstAsync(strWhereCond);
}
catch(e)
{
const strMsg = Format("绑定GridView不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
if (arrvgs_TotalDataStatisticsObjLst.length == 0)
{
const strMsg = Format("在ExportExcel过程中，根据条件获取的记录数为0！");
console.error("Error: ", strMsg);
//console.trace();
alert(strMsg);
return;
}
try
{
const arrDataColumn: Array < clsDataColumn > =
       [
{
fldName: "id_CurrEduCls",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "当前教学班流水号",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 2,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "eduClsName",
sortBy: "",
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
fldName: "schoolYear",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "学年",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 4,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "schoolTerm",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "学期",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 5,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "totalDataTypeName",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "总数据类型名称",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 7,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "dataTable",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "数据表",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 8,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "tableKey",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "表主键",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 10,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "dataUser",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "数据用户",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 11,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "dataAddDate",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "数据添加日期",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 12,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "month",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "月",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 13,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "week",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "周",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 14,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "updDate",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "修改日期",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 15,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "updUser",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "修改人",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 16,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "memo",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "备注",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 17,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
];
arrvgs_TotalDataStatisticsObjLst = arrvgs_TotalDataStatisticsObjLst.sort(this.SortFun_ExportExcel);
  this.CombineData(arrvgs_TotalDataStatisticsObjLst, arrDataColumn); 
//console.log("完成BindGv_vgs_TotalDataStatistics!");
}
catch(e)
{
const strMsg = Format("绑定对象列表不成功, {0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
}

 /** 根据条件获取相应的对象列表
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ExportExcel_Cache)
 **/
public async ExportExcel_vgs_TotalDataStatistics_Cache() 
{
const strThisFuncName = this.ExportExcel_vgs_TotalDataStatistics_Cache.name;
if (gs_TotalDataStatisticsCRUD.sortvgs_TotalDataStatisticsBy == null)
{
const strMsg = Format("在显示列表时，排序字段(sortvgs_TotalDataStatisticsBy)为空，请检查！(In BindGv_vgs_TotalDataStatistics_Cache)");
console.error(strMsg);
alert(strMsg);
return;
}
const strListDiv = this.divName4DataList;
const objvgs_TotalDataStatistics_Cond = await this.Combinevgs_TotalDataStatisticsConditionObj4ExportExcel();
objvgs_TotalDataStatistics_Cond.SetCondFldValue(clsvgs_TotalDataStatisticsEN.con_id_CurrEduCls, gs_TotalDataStatisticsCRUD.id_CurrEduCls_Cache, "=");
const strWhereCond = JSON.stringify(objvgs_TotalDataStatistics_Cond);
const intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
 let arrvgs_TotalDataStatisticsObjLst: Array <clsvgs_TotalDataStatisticsEN> = [];
try
{
this.recCount = await vgs_TotalDataStatistics_GetRecCountByCond_Cache(objvgs_TotalDataStatistics_Cond, gs_TotalDataStatisticsCRUD.id_CurrEduCls_Cache);
if (this.recCount == 0)
{
const lblMsg: HTMLSpanElement = < HTMLSpanElement > document.createElement("span");
lblMsg.innerHTML = Format("根据条件:[{0}]获取的对象列表数为0！", objvgs_TotalDataStatistics_Cond.whereCond);
const divDataLst: HTMLDivElement = <HTMLDivElement> document.getElementById("divDataLst");
if (divDataLst != null)
{
divDataLst.innerText = "";
divDataLst.appendChild(lblMsg);
}
const strMsg = Format("在绑定Gv_Cache过程中，根据条件:[{0}]获取的对象列表数为0！", objvgs_TotalDataStatistics_Cond.whereCond);
console.error("Error: ", strMsg);
//console.trace();
alert(strMsg);
return;
}
arrvgs_TotalDataStatisticsObjLst = await vgs_TotalDataStatistics_GetSubObjLst_Cache(objvgs_TotalDataStatistics_Cond, gs_TotalDataStatisticsCRUD.id_CurrEduCls_Cache);
}
catch(e)
{
const strMsg = Format("绑定GridView不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
if (arrvgs_TotalDataStatisticsObjLst.length == 0)
{
const strKey = Format("{0}_{1}", clsgs_TotalDataStatisticsEN._CurrTabName, gs_TotalDataStatisticsCRUD.id_CurrEduCls_Cache);
const strMsg = Format("根据条件获取的记录数为0！(Key={0})", strKey);
console.error("Error: ", strMsg);
//console.trace();
ShowEmptyRecNumInfo(strListDiv, strMsg);
this.objPager.Hide(this.divName4Pager);
return;
}
try
{
const arrDataColumn: Array < clsDataColumn > =
       [
{
fldName: "id_CurrEduCls",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "当前教学班流水号",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 2,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "eduClsName",
sortBy: "",
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
fldName: "schoolYear",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "学年",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 4,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "schoolTerm",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "学期",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 5,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "totalDataTypeName",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "总数据类型名称",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 7,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "dataTable",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "数据表",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 8,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "tableKey",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "表主键",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 10,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "dataUser",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "数据用户",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 11,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "dataAddDate",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "数据添加日期",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 12,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "month",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "月",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 13,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "week",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "周",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 14,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "updDate",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "修改日期",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 15,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "updUser",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "修改人",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 16,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "memo",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "备注",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 17,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
];
arrvgs_TotalDataStatisticsObjLst = arrvgs_TotalDataStatisticsObjLst.sort(this.SortFun_ExportExcel);
  this.CombineData(arrvgs_TotalDataStatisticsObjLst, arrDataColumn); 
//console.log("完成BindGv_vgs_TotalDataStatistics!");
}
catch(e)
{
const strMsg = Format("绑定对象列表不成功, {0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
}

 /**
 * 设置绑定下拉框，针对字段:[id_CurrEduCls]
 * (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl_TS4QryRegion4TabFeature1B)
 **/

public async SetDdl_id_CurrEduClsInDiv(courseId:string)
{
await CurrEduCls_BindDdl_id_CurrEduClsInDiv_Cache(this.divName4Query, "ddlid_CurrEduCls_q" , courseId);//
}

 /**
 * 设置绑定下拉框，针对字段:[SchoolYear]
 * (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl_TS4QryRegion4TabFeature1B)
 **/

public async SetDdl_SchoolYearInDiv()
{
await SchoolYear_BindDdl_SchoolYearInDiv_Cache(this.divName4Query, "ddlSchoolYear_q" );//
}

 /**
 * 设置绑定下拉框，针对字段:[SchoolTerm]
 * (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl_TS4QryRegion4TabFeature1B)
 **/

public async SetDdl_SchoolTermInDiv()
{
await SchoolTerm_BindDdl_SchoolTermInDiv_Cache(this.divName4Query, "ddlSchoolTerm_q" );//
}


 /** 函数功能:为查询区绑定下拉框
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4QueryRegion)
 **/
public async BindDdl4QueryRegion()
{
const strThisFuncName = this.BindDdl4QueryRegion.name;
// 在此处放置用户代码以初始化页面
const strCourseId = gs_TotalDataStatisticsCRUD.CourseId_Static;


await this.SetDdl_id_CurrEduClsInDiv(strCourseId);//查询区域

await this.SetDdl_SchoolYearInDiv();//查询区域

await this.SetDdl_SchoolTermInDiv();//查询区域
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
await this.BindGv_vgs_TotalDataStatistics_Cache();
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
 * "strTotalDataId": 表关键字
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
const responseText = await this.DelRecord(strKeyId);
 await this.BindGv_vgs_TotalDataStatistics_Cache();
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
public async btnSelectRecordInTab_Click(strTotalDataId: string) {
const strThisFuncName = this.btnSelectRecordInTab_Click.name;
try
{
if (IsNullOrEmpty(strTotalDataId) == true)
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
this.SelectRecord(strTotalDataId);
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
public async DelRecord(strTotalDataId: string) {
const strThisFuncName = this.DelRecord.name;
try
{
const returnInt = await gs_TotalDataStatistics_DelRecordAsync(strTotalDataId);
if (returnInt > 0)
{
gs_TotalDataStatistics_ReFreshCache(gs_TotalDataStatisticsCRUD.id_CurrEduCls_Cache);
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
public async SelectRecord(strTotalDataId: string) 
{
const strThisFuncName = this.SelectRecord.name;
try
{
const objgs_TotalDataStatisticsEN = await gs_TotalDataStatistics_GetObjByTotalDataIdAsync(strTotalDataId);
//console.log("完成SelectRecord!", objgs_TotalDataStatisticsEN);
Redirect("/Index/Main_vgs_TotalDataStatistics");
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
await this.BindGv_vgs_TotalDataStatistics_Cache();
}
catch(e)
{
const strMsg = Format("删除记录不成功. {0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
}

 /** 根据条件获取相应的对象列表
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnExportExcel_Click)
 **/
public async btnExportExcel_Click() 
{
const strThisFuncName = this.btnExportExcel_Click.name;
const responseBindGv = await this.ExportExcel_vgs_TotalDataStatistics_Cache();
}

 /** 把所有的查询控件内容组合成一个条件串
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
 * @returns 条件串(strWhereCond)
 **/
 public async Combinevgs_TotalDataStatisticsCondition():Promise<string> 
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。

try
{
if ( this.id_CurrEduCls_q != "" && this.id_CurrEduCls_q != "0")
{
strWhereCond += Format(" And {0} = '{1}'", clsvgs_TotalDataStatisticsEN.con_id_CurrEduCls, this.id_CurrEduCls_q);
}
if ( this.eduClsName_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsvgs_TotalDataStatisticsEN.con_EduClsName, this.eduClsName_q);
}
if ( this.schoolYear_q != "" && this.schoolYear_q != "0")
{
strWhereCond += Format(" And {0} = '{1}'", clsvgs_TotalDataStatisticsEN.con_SchoolYear, this.schoolYear_q);
}
if ( this.schoolTerm_q != "" && this.schoolTerm_q != "0")
{
strWhereCond += Format(" And {0} = '{1}'", clsvgs_TotalDataStatisticsEN.con_SchoolTerm, this.schoolTerm_q);
}
if ( this.totalDataTypeId_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsvgs_TotalDataStatisticsEN.con_TotalDataTypeId, this.totalDataTypeId_q);
}
if ( this.totalDataTypeName_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsvgs_TotalDataStatisticsEN.con_TotalDataTypeName, this.totalDataTypeName_q);
}
if ( this.dataTable_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsvgs_TotalDataStatisticsEN.con_DataTable, this.dataTable_q);
}
if ( this.dataTableId_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsvgs_TotalDataStatisticsEN.con_DataTableId, this.dataTableId_q);
}
if ( this.tableKey_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsvgs_TotalDataStatisticsEN.con_TableKey, this.tableKey_q);
}
if ( this.dataUser_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsvgs_TotalDataStatisticsEN.con_DataUser, this.dataUser_q);
}
if ( this.dataAddDate_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsvgs_TotalDataStatisticsEN.con_DataAddDate, this.dataAddDate_q);
}
if (this.month_q != 0)
{
strWhereCond += Format(" And {0} = {1}", clsvgs_TotalDataStatisticsEN.con_Month, this.month_q);
}
if (this.week_q != 0)
{
strWhereCond += Format(" And {0} = {1}", clsvgs_TotalDataStatisticsEN.con_Week, this.week_q);
}
}
catch(objException)
{
const strMsg:string = Format("(errid:WiTsCs0009)在组合查询条件(Combinegs_TotalDataStatisticsCondition)时出错!请联系管理员!{0}", objException);
throw strMsg;
}
return strWhereCond;
}

 /** 把所有的查询控件内容组合成一个条件串
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
 * @returns 条件串(strWhereCond)
 **/
 public async Combinevgs_TotalDataStatisticsConditionObj(): Promise<clsvgs_TotalDataStatisticsEN> 
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
const objvgs_TotalDataStatistics_Cond = new clsvgs_TotalDataStatisticsEN();
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
try
{
if ( this.id_CurrEduCls_q != "" && this.id_CurrEduCls_q != "0")
{
strWhereCond += Format(" And {0} = '{1}'", clsvgs_TotalDataStatisticsEN.con_id_CurrEduCls, this.id_CurrEduCls_q);
objvgs_TotalDataStatistics_Cond.SetCondFldValue(clsvgs_TotalDataStatisticsEN.con_id_CurrEduCls, this.id_CurrEduCls_q, "=");
}
if ( this.eduClsName_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsvgs_TotalDataStatisticsEN.con_EduClsName, this.eduClsName_q);
objvgs_TotalDataStatistics_Cond.SetCondFldValue(clsvgs_TotalDataStatisticsEN.con_EduClsName, this.eduClsName_q, "like");
}
if ( this.schoolYear_q != "" && this.schoolYear_q != "0")
{
strWhereCond += Format(" And {0} = '{1}'", clsvgs_TotalDataStatisticsEN.con_SchoolYear, this.schoolYear_q);
objvgs_TotalDataStatistics_Cond.SetCondFldValue(clsvgs_TotalDataStatisticsEN.con_SchoolYear, this.schoolYear_q, "=");
}
if ( this.schoolTerm_q != "" && this.schoolTerm_q != "0")
{
strWhereCond += Format(" And {0} = '{1}'", clsvgs_TotalDataStatisticsEN.con_SchoolTerm, this.schoolTerm_q);
objvgs_TotalDataStatistics_Cond.SetCondFldValue(clsvgs_TotalDataStatisticsEN.con_SchoolTerm, this.schoolTerm_q, "=");
}
if ( this.totalDataTypeId_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsvgs_TotalDataStatisticsEN.con_TotalDataTypeId, this.totalDataTypeId_q);
objvgs_TotalDataStatistics_Cond.SetCondFldValue(clsvgs_TotalDataStatisticsEN.con_TotalDataTypeId, this.totalDataTypeId_q, "like");
}
if ( this.totalDataTypeName_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsvgs_TotalDataStatisticsEN.con_TotalDataTypeName, this.totalDataTypeName_q);
objvgs_TotalDataStatistics_Cond.SetCondFldValue(clsvgs_TotalDataStatisticsEN.con_TotalDataTypeName, this.totalDataTypeName_q, "like");
}
if ( this.dataTable_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsvgs_TotalDataStatisticsEN.con_DataTable, this.dataTable_q);
objvgs_TotalDataStatistics_Cond.SetCondFldValue(clsvgs_TotalDataStatisticsEN.con_DataTable, this.dataTable_q, "like");
}
if ( this.dataTableId_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsvgs_TotalDataStatisticsEN.con_DataTableId, this.dataTableId_q);
objvgs_TotalDataStatistics_Cond.SetCondFldValue(clsvgs_TotalDataStatisticsEN.con_DataTableId, this.dataTableId_q, "like");
}
if ( this.tableKey_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsvgs_TotalDataStatisticsEN.con_TableKey, this.tableKey_q);
objvgs_TotalDataStatistics_Cond.SetCondFldValue(clsvgs_TotalDataStatisticsEN.con_TableKey, this.tableKey_q, "like");
}
if ( this.dataUser_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsvgs_TotalDataStatisticsEN.con_DataUser, this.dataUser_q);
objvgs_TotalDataStatistics_Cond.SetCondFldValue(clsvgs_TotalDataStatisticsEN.con_DataUser, this.dataUser_q, "like");
}
if ( this.dataAddDate_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsvgs_TotalDataStatisticsEN.con_DataAddDate, this.dataAddDate_q);
objvgs_TotalDataStatistics_Cond.SetCondFldValue(clsvgs_TotalDataStatisticsEN.con_DataAddDate, this.dataAddDate_q, "like");
}
if (this.month_q != 0)
{
strWhereCond += Format(" And {0} = {1}", clsvgs_TotalDataStatisticsEN.con_Month, this.month_q);
objvgs_TotalDataStatistics_Cond.SetCondFldValue(clsvgs_TotalDataStatisticsEN.con_Month, this.month_q, "=");
}
if (this.week_q != 0)
{
strWhereCond += Format(" And {0} = {1}", clsvgs_TotalDataStatisticsEN.con_Week, this.week_q);
objvgs_TotalDataStatistics_Cond.SetCondFldValue(clsvgs_TotalDataStatisticsEN.con_Week, this.week_q, "=");
}

}
catch(objException)
{
const strMsg:string = Format("(errid:WiTsCs0010)在组合查询条件对象(Combinegs_TotalDataStatisticsConditionObj)时出错!请联系管理员!{0}", objException);
throw strMsg;
}
objvgs_TotalDataStatistics_Cond.whereCond = strWhereCond;
return objvgs_TotalDataStatistics_Cond;
}

 /** 把所有的查询控件内容组合成一个条件串
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj4ExportExcel)
 * @returns 条件串(strWhereCond)
 **/
 public async Combinevgs_TotalDataStatisticsConditionObj4ExportExcel():Promise<clsvgs_TotalDataStatisticsEN> 
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
const objvgs_TotalDataStatistics_Cond = new clsvgs_TotalDataStatisticsENEx();
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
try
{
if ( this.id_CurrEduCls_q != "" && this.id_CurrEduCls_q != "0")
{
strWhereCond += Format(" And {0} = '{1}'", clsvgs_TotalDataStatisticsEN.con_id_CurrEduCls, this.id_CurrEduCls_q);
objvgs_TotalDataStatistics_Cond.SetCondFldValue(clsvgs_TotalDataStatisticsEN.con_id_CurrEduCls, this.id_CurrEduCls_q, "=");
}
if ( this.eduClsName_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsvgs_TotalDataStatisticsEN.con_EduClsName, this.eduClsName_q);
objvgs_TotalDataStatistics_Cond.SetCondFldValue(clsvgs_TotalDataStatisticsEN.con_EduClsName, this.eduClsName_q, "like");
}
if ( this.schoolYear_q != "" && this.schoolYear_q != "0")
{
strWhereCond += Format(" And {0} = '{1}'", clsvgs_TotalDataStatisticsEN.con_SchoolYear, this.schoolYear_q);
objvgs_TotalDataStatistics_Cond.SetCondFldValue(clsvgs_TotalDataStatisticsEN.con_SchoolYear, this.schoolYear_q, "=");
}
if ( this.schoolTerm_q != "" && this.schoolTerm_q != "0")
{
strWhereCond += Format(" And {0} = '{1}'", clsvgs_TotalDataStatisticsEN.con_SchoolTerm, this.schoolTerm_q);
objvgs_TotalDataStatistics_Cond.SetCondFldValue(clsvgs_TotalDataStatisticsEN.con_SchoolTerm, this.schoolTerm_q, "=");
}
if ( this.totalDataTypeId_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsvgs_TotalDataStatisticsEN.con_TotalDataTypeId, this.totalDataTypeId_q);
objvgs_TotalDataStatistics_Cond.SetCondFldValue(clsvgs_TotalDataStatisticsEN.con_TotalDataTypeId, this.totalDataTypeId_q, "like");
}
if ( this.totalDataTypeName_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsvgs_TotalDataStatisticsEN.con_TotalDataTypeName, this.totalDataTypeName_q);
objvgs_TotalDataStatistics_Cond.SetCondFldValue(clsvgs_TotalDataStatisticsEN.con_TotalDataTypeName, this.totalDataTypeName_q, "like");
}
if ( this.dataTable_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsvgs_TotalDataStatisticsEN.con_DataTable, this.dataTable_q);
objvgs_TotalDataStatistics_Cond.SetCondFldValue(clsvgs_TotalDataStatisticsEN.con_DataTable, this.dataTable_q, "like");
}
if ( this.dataTableId_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsvgs_TotalDataStatisticsEN.con_DataTableId, this.dataTableId_q);
objvgs_TotalDataStatistics_Cond.SetCondFldValue(clsvgs_TotalDataStatisticsEN.con_DataTableId, this.dataTableId_q, "like");
}
if ( this.tableKey_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsvgs_TotalDataStatisticsEN.con_TableKey, this.tableKey_q);
objvgs_TotalDataStatistics_Cond.SetCondFldValue(clsvgs_TotalDataStatisticsEN.con_TableKey, this.tableKey_q, "like");
}
if ( this.dataUser_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsvgs_TotalDataStatisticsEN.con_DataUser, this.dataUser_q);
objvgs_TotalDataStatistics_Cond.SetCondFldValue(clsvgs_TotalDataStatisticsEN.con_DataUser, this.dataUser_q, "like");
}
if ( this.dataAddDate_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsvgs_TotalDataStatisticsEN.con_DataAddDate, this.dataAddDate_q);
objvgs_TotalDataStatistics_Cond.SetCondFldValue(clsvgs_TotalDataStatisticsEN.con_DataAddDate, this.dataAddDate_q, "like");
}
if (this.month_q != 0)
{
strWhereCond += Format(" And {0} = {1}", clsvgs_TotalDataStatisticsEN.con_Month, this.month_q);
objvgs_TotalDataStatistics_Cond.SetCondFldValue(clsvgs_TotalDataStatisticsEN.con_Month, this.month_q, "=");
}
if (this.week_q != 0)
{
strWhereCond += Format(" And {0} = {1}", clsvgs_TotalDataStatisticsEN.con_Week, this.week_q);
objvgs_TotalDataStatistics_Cond.SetCondFldValue(clsvgs_TotalDataStatisticsEN.con_Week, this.week_q, "=");
}
}
catch(objException)
{
const strMsg:string = Format("(errid:WiTsCs0013)在组合导出Excel条件对象(Combinegs_TotalDataStatisticsConditionObj4ExportExcel)时出错!请联系管理员!{0}", objException);
throw strMsg;
}
objvgs_TotalDataStatistics_Cond.whereCond = strWhereCond;
return objvgs_TotalDataStatistics_Cond;
}

 /** 显示vgs_TotalDataStatistics对象的所有属性值
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
 * @param divContainer:显示容器
 * @param arrgs_TotalDataStatisticsObjLst:需要绑定的对象列表
 **/
public async BindTab_vgs_TotalDataStatistics(divContainer: string, arrvgs_TotalDataStatisticsObjLst: Array<clsvgs_TotalDataStatisticsEN>) 
{
const strThisFuncName = this.BindTab_vgs_TotalDataStatistics.name;
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
fldName: clsvgs_TotalDataStatisticsEN.con_id_CurrEduCls,
sortBy: clsvgs_TotalDataStatisticsEN.con_id_CurrEduCls,
sortFun: SortFun,
getDataSource: "",
colHeader: "当前教学班流水号",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 3,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: clsvgs_TotalDataStatisticsEN.con_EduClsName,
sortBy: clsvgs_TotalDataStatisticsEN.con_EduClsName,
sortFun: SortFun,
getDataSource: "",
colHeader: "教学班名称",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 4,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: clsvgs_TotalDataStatisticsEN.con_SchoolYear,
sortBy: clsvgs_TotalDataStatisticsEN.con_SchoolYear,
sortFun: SortFun,
getDataSource: "",
colHeader: "学年",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 5,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: clsvgs_TotalDataStatisticsEN.con_SchoolTerm,
sortBy: clsvgs_TotalDataStatisticsEN.con_SchoolTerm,
sortFun: SortFun,
getDataSource: "",
colHeader: "学期",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 6,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: clsvgs_TotalDataStatisticsEN.con_TotalDataTypeName,
sortBy: clsvgs_TotalDataStatisticsEN.con_TotalDataTypeName,
sortFun: SortFun,
getDataSource: "",
colHeader: "总数据类型名称",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 8,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: clsvgs_TotalDataStatisticsEN.con_DataTable,
sortBy: clsvgs_TotalDataStatisticsEN.con_DataTable,
sortFun: SortFun,
getDataSource: "",
colHeader: "数据表",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 9,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: clsvgs_TotalDataStatisticsEN.con_TableKey,
sortBy: clsvgs_TotalDataStatisticsEN.con_TableKey,
sortFun: SortFun,
getDataSource: "",
colHeader: "表主键",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 11,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: clsvgs_TotalDataStatisticsEN.con_DataUser,
sortBy: clsvgs_TotalDataStatisticsEN.con_DataUser,
sortFun: SortFun,
getDataSource: "",
colHeader: "数据用户",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 12,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: clsvgs_TotalDataStatisticsEN.con_DataAddDate,
sortBy: clsvgs_TotalDataStatisticsEN.con_DataAddDate,
sortFun: SortFun,
getDataSource: "",
colHeader: "数据添加日期",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 13,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: clsvgs_TotalDataStatisticsEN.con_Month,
sortBy: clsvgs_TotalDataStatisticsEN.con_Month,
sortFun: SortFun,
getDataSource: "",
colHeader: "月",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 14,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: clsvgs_TotalDataStatisticsEN.con_Week,
sortBy: clsvgs_TotalDataStatisticsEN.con_Week,
sortFun: SortFun,
getDataSource: "",
colHeader: "周",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 15,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: clsvgs_TotalDataStatisticsEN.con_UpdDate,
sortBy: clsvgs_TotalDataStatisticsEN.con_UpdDate,
sortFun: SortFun,
getDataSource: "",
colHeader: "修改日期",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 16,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: clsvgs_TotalDataStatisticsEN.con_UpdUser,
sortBy: clsvgs_TotalDataStatisticsEN.con_UpdUser,
sortFun: SortFun,
getDataSource: "",
colHeader: "修改人",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 17,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: clsvgs_TotalDataStatisticsEN.con_Memo,
sortBy: clsvgs_TotalDataStatisticsEN.con_Memo,
sortFun: SortFun,
getDataSource: "",
colHeader: "备注",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 18,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
];
await BindTab_V(o, arrvgs_TotalDataStatisticsObjLst, arrDataColumn,  clsvgs_TotalDataStatisticsEN.con_TotalDataId, this); 
this.objPager.recCount = this.recCount;
this.objPager.pageSize = this.pageSize;
this.objPager.ShowPagerV2(this, this.divName4Pager);
}

 /** 扩展字段值的函数映射
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ExtendFldFuncMap)
 * @param arrvgs_TotalDataStatisticsExObjLst:需要映射的对象列表
 * @param arrDataColumn:用于绑定表的数据列信息
 **/
public async ExtendFldFuncMap(arrvgs_TotalDataStatisticsExObjLst: Array<clsvgs_TotalDataStatisticsENEx>, arrDataColumn: Array<clsDataColumn>) {
const arrFldName = clsvgs_TotalDataStatisticsEN.AttributeName;
for (const objDataColumn of arrDataColumn) {
if (IsNullOrEmpty(objDataColumn.fldName) == true) continue;
if (arrFldName.indexOf(objDataColumn.fldName) > -1) continue;
for (const objInFor of arrvgs_TotalDataStatisticsExObjLst) {
await vgs_TotalDataStatisticsEx_FuncMapByFldName(objDataColumn.fldName, objInFor);
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
const responseBindGv = await this.BindGv_vgs_TotalDataStatistics_Cache();
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
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv_Cache)
 **/
public async BindGv_vgs_TotalDataStatistics_Cache() 
{
const strThisFuncName = this.BindGv_vgs_TotalDataStatistics_Cache.name;
if (gs_TotalDataStatisticsCRUD.sortvgs_TotalDataStatisticsBy == null)
{
const strMsg = Format("在显示列表时，排序字段(sortvgs_TotalDataStatisticsBy)为空，请检查！(In BindGv_vgs_TotalDataStatistics_Cache)");
console.error(strMsg);
alert(strMsg);
return;
}
const strListDiv = this.divName4DataList;
const objvgs_TotalDataStatistics_Cond = await this.Combinevgs_TotalDataStatisticsConditionObj();
objvgs_TotalDataStatistics_Cond.SetCondFldValue(clsvgs_TotalDataStatisticsEN.con_id_CurrEduCls, gs_TotalDataStatisticsCRUD.id_CurrEduCls_Cache, "=");
const strWhereCond = JSON.stringify(objvgs_TotalDataStatistics_Cond);
let intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
 let arrvgs_TotalDataStatisticsObjLst: Array <clsvgs_TotalDataStatisticsEN> = [];
try
{
this.recCount = await vgs_TotalDataStatistics_GetRecCountByCond_Cache(objvgs_TotalDataStatistics_Cond, gs_TotalDataStatisticsCRUD.id_CurrEduCls_Cache);
if (this.recCount == 0)
{
const lblMsg: HTMLSpanElement = < HTMLSpanElement > document.createElement("span");
lblMsg.innerHTML = Format("根据条件:[{0}]获取的对象列表数为0！", objvgs_TotalDataStatistics_Cond.whereCond);
const divDataLst: HTMLDivElement = <HTMLDivElement> document.getElementById("divDataLst");
if (divDataLst != null)
{
divDataLst.innerText = "";
divDataLst.appendChild(lblMsg);
}
const strMsg = Format("在绑定Gv_Cache过程中，根据条件:[{0}]获取的对象列表数为0！", objvgs_TotalDataStatistics_Cond.whereCond);
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
orderBy: gs_TotalDataStatisticsCRUD.sortvgs_TotalDataStatisticsBy,//如果该字段为空，就使用下面的排序函数
sortFun: vgs_TotalDataStatistics_SortFun_Defa
}
arrvgs_TotalDataStatisticsObjLst = await vgs_TotalDataStatistics_GetObjLstByPager_Cache(objPagerPara, gs_TotalDataStatisticsCRUD.id_CurrEduCls_Cache);
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
if (arrvgs_TotalDataStatisticsObjLst.length == 0)
{
const lblMsg: HTMLSpanElement = < HTMLSpanElement > document.createElement("span");
lblMsg.innerHTML = "根据条件获取的对象列表数为0！";
const divDataLst: HTMLDivElement = < HTMLDivElement > document.getElementById("divDataLst");
if (divDataLst != null)
{
divDataLst.innerText = "";
divDataLst.appendChild(lblMsg);
}
const strKey = Format("{0}_{1}", clsgs_TotalDataStatisticsEN._CurrTabName, gs_TotalDataStatisticsCRUD.id_CurrEduCls_Cache);
const strMsg = Format("根据条件获取的记录数为0！(Key={0})", strKey);
console.error("Error: ", strMsg);
//console.trace();
ShowEmptyRecNumInfo(strListDiv, strMsg);
this.objPager.Hide(this.divName4Pager);
return;
}
try
{
await this.BindTab_vgs_TotalDataStatistics(strListDiv, arrvgs_TotalDataStatisticsObjLst);
//console.log("完成BindGv_vgs_TotalDataStatistics_Cache!");
}
catch(e)
{
const strMsg = Format("绑定对象列表不成功, {0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
}

 /**
 * 排序函数。根据表对象中随机两个字段的值进行比较,正常使用时，需用该类的扩展类的同名函数
 * 作者:pyf
 * 日期:
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SortFunExportExcel)
 * @param a:比较的第1个对象
 * @param b:比较的第1个对象
 * @returns 返回两个对象比较的结果
 **/
public SortFun_ExportExcel(a:clsvgs_TotalDataStatisticsEN , b:clsvgs_TotalDataStatisticsEN): number 
{
const strThisFuncName = this.SortFun_ExportExcel.name;
if (a.updUser == b.updUser) return a.updUser.localeCompare(b.updUser) ;
else return a.updDate.localeCompare(b.updDate);
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
const { sortFun, ascOrDesc4SortFun, sortBy } = GetSortBy(objAnchorElement, gs_TotalDataStatisticsCRUD.ascOrDesc4SortFun, gs_TotalDataStatisticsCRUD.sortvgs_TotalDataStatisticsBy, strSortExpress);
gs_TotalDataStatisticsCRUD.sortvgs_TotalDataStatisticsBy = sortBy;
gs_TotalDataStatisticsCRUD.ascOrDesc4SortFun = ascOrDesc4SortFun;
gs_TotalDataStatisticsCRUD.sortFun_Static = sortFun;
await this.BindGv_vgs_TotalDataStatistics_Cache();
}

 /** 复制记录
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CopyRecord)
 **/
public async CopyRecord(arrTotalDataId: Array<string>) {
const strThisFuncName = this.CopyRecord.name;
try
{
const arrgs_TotalDataStatisticsObjLst = await gs_TotalDataStatistics_GetObjLstByTotalDataIdLstAsync(arrTotalDataId);
//console.log('responseText=');
//console.log(responseText);
let intCount = 0;
for (const objInFor of arrgs_TotalDataStatisticsObjLst)
{
const returnBool = await gs_TotalDataStatistics_AddNewRecordAsync(objInFor);
//console.log('returnBool=');
//console.log(returnBool);
if (returnBool == true)
{
gs_TotalDataStatistics_ReFreshCache(gs_TotalDataStatisticsCRUD.id_CurrEduCls_Cache);
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
public async DelMultiRecord(arrTotalDataId: Array<string>) {
const strThisFuncName = this.DelMultiRecord.name;
try
{
const returnInt = await gs_TotalDataStatistics_Delgs_TotalDataStatisticssAsync(arrTotalDataId);
if (returnInt > 0)
{
gs_TotalDataStatistics_ReFreshCache(gs_TotalDataStatisticsCRUD.id_CurrEduCls_Cache);
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
 * @param objgs_TotalDataStatistics:需要显示的对象
 **/
public Showgs_TotalDataStatisticsObj(divContainer: string, objgs_TotalDataStatistics: clsgs_TotalDataStatisticsEN) 
{
const strThisFuncName = this.Showgs_TotalDataStatisticsObj.name;
const o = document.getElementById(divContainer);
if (o == null)
{
alert(Format("{}不存在！",divContainer));
return;
}
const sstrKeys = GetObjKeys(objgs_TotalDataStatistics);
const ul: HTMLUListElement = document.createElement("ul");
for (const strKey of sstrKeys)
{
const strValue = objgs_TotalDataStatistics.GetFldValue(strKey);
const li: HTMLLIElement = document.createElement("li");
li.innerHTML = Format("{0}:{1}", strKey, strValue);
ul.appendChild(li);
}
o.appendChild(ul);
}

 /** 函数功能:从界面列表中获取第一个关键字的值
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetFirstKey)
 * @param pobjgs_TotalDataStatisticsEN:表实体类对象
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
 * 数据添加日期 (Used In CombineCondition())
 **/
public  get dataAddDate_q():string {
const strValue = GetInputValueInDiv(this.divName4Query, "txtDataAddDate_q");
if (strValue == undefined) return "";
else return strValue.toString();
}
 /**
 * 数据添加日期 (Used In CombineCondition())
 **/
public  set dataAddDate_q(value: string) {
 SetInputValueByIdInDiv(this.divName4Query, "txtDataAddDate_q", value);
}
 /**
 * 数据表 (Used In CombineCondition())
 **/
public  get dataTable_q():string {
const strValue = GetInputValueInDiv(this.divName4Query, "txtDataTable_q");
if (strValue == undefined) return "";
else return strValue.toString();
}
 /**
 * 数据表 (Used In CombineCondition())
 **/
public  set dataTable_q(value: string) {
 SetInputValueByIdInDiv(this.divName4Query, "txtDataTable_q", value);
}
 /**
 * 数据表Id (Used In CombineCondition())
 **/
public  get dataTableId_q():string {
const strValue = GetInputValueInDiv(this.divName4Query, "txtDataTableId_q");
if (strValue == undefined) return "";
else return strValue.toString();
}
 /**
 * 数据表Id (Used In CombineCondition())
 **/
public  set dataTableId_q(value: string) {
 SetInputValueByIdInDiv(this.divName4Query, "txtDataTableId_q", value);
}
 /**
 * 数据用户 (Used In CombineCondition())
 **/
public  get dataUser_q():string {
const strValue = GetInputValueInDiv(this.divName4Query, "txtDataUser_q");
if (strValue == undefined) return "";
else return strValue.toString();
}
 /**
 * 数据用户 (Used In CombineCondition())
 **/
public  set dataUser_q(value: string) {
 SetInputValueByIdInDiv(this.divName4Query, "txtDataUser_q", value);
}
 /**
 * 教学班名 (Used In CombineCondition())
 **/
public  get eduClsName_q():string {
const strValue = GetInputValueInDiv(this.divName4Query, "txtEduClsName_q");
if (strValue == undefined) return "";
else return strValue.toString();
}
 /**
 * 教学班名 (Used In CombineCondition())
 **/
public  set eduClsName_q(value: string) {
 SetInputValueByIdInDiv(this.divName4Query, "txtEduClsName_q", value);
}
 /**
 * 教学班流水号 (Used In CombineCondition())
 **/
public  get id_CurrEduCls_q():string {
const strValue = GetSelectValueInDiv(this.divName4Query, "ddlid_CurrEduCls_q");
if (strValue == undefined) return "";
else if (strValue == "0") return "";
else return strValue;
}
 /**
 * 教学班流水号 (Used In CombineCondition())
 **/
public  set id_CurrEduCls_q(value: string) {
SetSelectValueByIdInDiv(this.divName4Query, "ddlid_CurrEduCls_q", value);
}
 /**
 * 月 (Used In CombineCondition())
 **/
public  get month_q():number {
const strValue = GetInputValueInDiv(this.divName4Query, "txtMonth_q");
if (strValue == undefined) return 0;
else if (IsNullOrEmpty(strValue) == true) return 0;
else return Number(strValue);
}
 /**
 * 月 (Used In CombineCondition())
 **/
public  set month_q(value: number) {
 SetInputValueByIdInDiv(this.divName4Query, "txtMonth_q", value.toString());
}
 /**
 * 学期 (Used In CombineCondition())
 **/
public  get schoolTerm_q():string {
const strValue = GetSelectValueInDiv(this.divName4Query, "ddlSchoolTerm_q");
if (strValue == undefined) return "";
else if (strValue == "0") return "";
else return strValue;
}
 /**
 * 学期 (Used In CombineCondition())
 **/
public  set schoolTerm_q(value: string) {
SetSelectValueByIdInDiv(this.divName4Query, "ddlSchoolTerm_q", value);
}
 /**
 * 学年 (Used In CombineCondition())
 **/
public  get schoolYear_q():string {
const strValue = GetSelectValueInDiv(this.divName4Query, "ddlSchoolYear_q");
if (strValue == undefined) return "";
else if (strValue == "0") return "";
else return strValue;
}
 /**
 * 学年 (Used In CombineCondition())
 **/
public  set schoolYear_q(value: string) {
SetSelectValueByIdInDiv(this.divName4Query, "ddlSchoolYear_q", value);
}
 /**
 * 表主键 (Used In CombineCondition())
 **/
public  get tableKey_q():string {
const strValue = GetInputValueInDiv(this.divName4Query, "txtTableKey_q");
if (strValue == undefined) return "";
else return strValue.toString();
}
 /**
 * 表主键 (Used In CombineCondition())
 **/
public  set tableKey_q(value: string) {
 SetInputValueByIdInDiv(this.divName4Query, "txtTableKey_q", value);
}
 /**
 * 总数据类型Id (Used In CombineCondition())
 **/
public  get totalDataTypeId_q():string {
const strValue = GetInputValueInDiv(this.divName4Query, "txtTotalDataTypeId_q");
if (strValue == undefined) return "";
else return strValue.toString();
}
 /**
 * 总数据类型Id (Used In CombineCondition())
 **/
public  set totalDataTypeId_q(value: string) {
 SetInputValueByIdInDiv(this.divName4Query, "txtTotalDataTypeId_q", value);
}
 /**
 * 总数据类型名称 (Used In CombineCondition())
 **/
public  get totalDataTypeName_q():string {
const strValue = GetInputValueInDiv(this.divName4Query, "txtTotalDataTypeName_q");
if (strValue == undefined) return "";
else return strValue.toString();
}
 /**
 * 总数据类型名称 (Used In CombineCondition())
 **/
public  set totalDataTypeName_q(value: string) {
 SetInputValueByIdInDiv(this.divName4Query, "txtTotalDataTypeName_q", value);
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
 /**
 * 周 (Used In CombineCondition())
 **/
public  get week_q():number {
const strValue = GetInputValueInDiv(this.divName4Query, "txtWeek_q");
if (strValue == undefined) return 0;
else if (IsNullOrEmpty(strValue) == true) return 0;
else return Number(strValue);
}
 /**
 * 周 (Used In CombineCondition())
 **/
public  set week_q(value: number) {
 SetInputValueByIdInDiv(this.divName4Query, "txtWeek_q", value.toString());
}
}