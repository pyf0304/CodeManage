
 /**
 * 类名:SysScoreSummaryCRUD(界面:SysScoreSummaryCRUD)
 * 表名:SysScoreSummary(01120628)
 * 版本:2023.01.12.1(服务器:WIN-SRV103-116)
 * 日期:2023/01/12 16:38:04
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
import { vSysScoreSummary_GetRecCountByCondAsync } from "../../TS/L3_ForWApi/GraduateEduTools/clsvSysScoreSummaryWApi.js";
import { vSysScoreSummary_GetObjLstAsync } from "../../TS/L3_ForWApi/GraduateEduTools/clsvSysScoreSummaryWApi.js";
import { vSysScoreSummary_GetRecCountByCond_Cache } from "../../TS/L3_ForWApi/GraduateEduTools/clsvSysScoreSummaryWApi.js";
import { vSysScoreSummary_GetSubObjLst_Cache } from "../../TS/L3_ForWApi/GraduateEduTools/clsvSysScoreSummaryWApi.js";
import { SchoolYear_BindDdl_SchoolYearInDiv_Cache } from "../../TS/L3_ForWApi/SysPara/clsSchoolYearWApi.js";
import { SysScoreType_BindDdl_ScoreTypeIdInDiv_Cache } from "../../TS/L3_ForWApi/ParameterTable/clsSysScoreTypeWApi.js";
import { SysScoreSummary_DelRecordAsync } from "../../TS/L3_ForWApi/GraduateEduTools/clsSysScoreSummaryWApi.js";
import { SysScoreSummary_GetObjBymIdAsync } from "../../TS/L3_ForWApi/GraduateEduTools/clsSysScoreSummaryWApi.js";
import { clsvSysScoreSummaryEN } from "../../TS/L0_Entity/GraduateEduTools/clsvSysScoreSummaryEN.js";
import { clsvSysScoreSummaryENEx } from "../../TS/L0_Entity/GraduateEduTools/clsvSysScoreSummaryENEx.js";
import { vSysScoreSummaryEx_FuncMapByFldName } from "../../TS/L3_ForWApiEx/GraduateEduTools/clsvSysScoreSummaryExWApi.js";
import { vSysScoreSummary_GetObjLstByPagerAsync } from "../../TS/L3_ForWApi/GraduateEduTools/clsvSysScoreSummaryWApi.js";
import { vSysScoreSummary_SortFun_Defa } from "../../TS/L3_ForWApi/GraduateEduTools/clsvSysScoreSummaryWApi.js";
import { vSysScoreSummary_GetObjLstByPager_Cache } from "../../TS/L3_ForWApi/GraduateEduTools/clsvSysScoreSummaryWApi.js";
import { SysScoreSummary_GetObjLstBymIdLstAsync } from "../../TS/L3_ForWApi/GraduateEduTools/clsSysScoreSummaryWApi.js";
import { SysScoreSummary_AddNewRecordAsync } from "../../TS/L3_ForWApi/GraduateEduTools/clsSysScoreSummaryWApi.js";
import { SysScoreSummary_DelSysScoreSummarysAsync } from "../../TS/L3_ForWApi/GraduateEduTools/clsSysScoreSummaryWApi.js";
import { clsSysScoreSummaryEN } from "../../TS/L0_Entity/GraduateEduTools/clsSysScoreSummaryEN.js";
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
 /** SysScoreSummaryCRUD 的摘要说明。其中Q代表查询,U代表修改
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
 **/
export abstract class SysScoreSummaryCRUD implements clsOperateList
{
public static objPage_CRUD: SysScoreSummaryCRUD;
public static sortFun_Static: (ascOrDesc: string) => (x: any, y: any) => number;
public static ascOrDesc4SortFun = "Asc";
public static sortvSysScoreSummaryBy = "";

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
SysScoreSummaryCRUD.objPage_CRUD = this;
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


SysScoreSummaryCRUD.sortvSysScoreSummaryBy = "schoolYear Asc";
if (this.bolIsInitShow == false)  //
{
this.objPager.InitShow(this.divName4Pager);
this.bolIsInitShow = true;  //
}
//2、显示无条件的表内容在GridView中
const responseBindGv = await this.BindGv_vSysScoreSummary();
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
SysScoreSummaryCRUD.sortvSysScoreSummaryBy = "schoolYear Asc";
if (this.bolIsInitShow == false)  //
{
this.objPager.InitShow(this.divName4Pager);
this.bolIsInitShow = true;  //
}
//2、显示无条件的表内容在GridView中
const responseBindGv = await this.BindGv_vSysScoreSummary();
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
const responseBindGv = await this.BindGv_vSysScoreSummary();
}

 /** 合并数据
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineData)
 **/
public CombineData(arrvSysScoreSummaryObjLst: Array<clsvSysScoreSummaryEN>, arrDataColumn: Array<clsDataColumn>) 
{
const strThisFuncName = this.CombineData.name;
const intRowNum = arrvSysScoreSummaryObjLst.length;
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
const objEN: clsvSysScoreSummaryEN = arrvSysScoreSummaryObjLst[i];
for (let j = 0; j < intColNum; j++)
{
arrRow.push(objEN.GetFldValue(arrDataColumn[j].fldName));//i + "" + j;
}
arrData.push(arrRow);
}
//console.log("arrData", arrData);
const strFileName = Format("系统分数汇总表({0})导出.xlsx",
 clsvSysScoreSummaryEN._CurrTabName);
exportSpecialExcel_pyf(arrData, strFileName);
}

 /** 根据条件获取相应的对象列表
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ExportExcel)
 **/
public async ExportExcel_vSysScoreSummary() 
{
const strThisFuncName = this.ExportExcel_vSysScoreSummary.name;
if (SysScoreSummaryCRUD.sortvSysScoreSummaryBy == null)
{
const strMsg = Format("在显示列表时，排序字段(sortvSysScoreSummaryBy)为空，请检查！(In BindGv_vSysScoreSummary_Cache)");
console.error(strMsg);
alert(strMsg);
return;
}
const strListDiv = this.divName4DataList;
const strWhereCond = await this.CombinevSysScoreSummaryCondition();
const intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
 let arrvSysScoreSummaryObjLst: Array <clsvSysScoreSummaryEN> = [];
try
{
this.recCount = await vSysScoreSummary_GetRecCountByCondAsync(strWhereCond);
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
arrvSysScoreSummaryObjLst = await vSysScoreSummary_GetObjLstAsync(strWhereCond);
}
catch(e)
{
const strMsg = Format("绑定GridView不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
if (arrvSysScoreSummaryObjLst.length == 0)
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
fldName: "schoolYear",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "学年",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 3,
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
orderNum: 4,
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
orderNum: 5,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "userName",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "用户名",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 6,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "id_XzCollege",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "学院流水号",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 7,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "collegeName",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "学院名称",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 8,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "id_XzMajor",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "专业流水号",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 9,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "majorName",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "专业名称",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 10,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "id_GradeBase",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "年级流水号",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 11,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "gradeBaseName",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "年级名称",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 12,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "scoreTypeName",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "分数类型名称",
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
];
arrvSysScoreSummaryObjLst = arrvSysScoreSummaryObjLst.sort(this.SortFun_ExportExcel);
  this.CombineData(arrvSysScoreSummaryObjLst, arrDataColumn); 
//console.log("完成BindGv_vSysScoreSummary!");
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
public async ExportExcel_vSysScoreSummary_Cache() 
{
const strThisFuncName = this.ExportExcel_vSysScoreSummary_Cache.name;
if (SysScoreSummaryCRUD.sortvSysScoreSummaryBy == null)
{
const strMsg = Format("在显示列表时，排序字段(sortvSysScoreSummaryBy)为空，请检查！(In BindGv_vSysScoreSummary_Cache)");
console.error(strMsg);
alert(strMsg);
return;
}
const strListDiv = this.divName4DataList;
const objvSysScoreSummary_Cond = await this.CombinevSysScoreSummaryConditionObj4ExportExcel();
objvSysScoreSummary_Cond.SetCondFldValue(clsvSysScoreSummaryEN.con_id_CurrEduCls, SysScoreSummaryCRUD.id_CurrEduCls_Cache, "=");
const strWhereCond = JSON.stringify(objvSysScoreSummary_Cond);
const intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
 let arrvSysScoreSummaryObjLst: Array <clsvSysScoreSummaryEN> = [];
try
{
this.recCount = await vSysScoreSummary_GetRecCountByCond_Cache(objvSysScoreSummary_Cond, SysScoreSummaryCRUD.id_CurrEduCls_Cache);
if (this.recCount == 0)
{
const lblMsg: HTMLSpanElement = < HTMLSpanElement > document.createElement("span");
lblMsg.innerHTML = Format("根据条件:[{0}]获取的对象列表数为0！", objvSysScoreSummary_Cond.whereCond);
const divDataLst: HTMLDivElement = <HTMLDivElement> document.getElementById("divDataLst");
if (divDataLst != null)
{
divDataLst.innerText = "";
divDataLst.appendChild(lblMsg);
}
const strMsg = Format("在绑定Gv_Cache过程中，根据条件:[{0}]获取的对象列表数为0！", objvSysScoreSummary_Cond.whereCond);
console.error("Error: ", strMsg);
//console.trace();
alert(strMsg);
return;
}
arrvSysScoreSummaryObjLst = await vSysScoreSummary_GetSubObjLst_Cache(objvSysScoreSummary_Cond, SysScoreSummaryCRUD.id_CurrEduCls_Cache);
}
catch(e)
{
const strMsg = Format("绑定GridView不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
if (arrvSysScoreSummaryObjLst.length == 0)
{
const strKey = Format("{0}_{1}", clsSysScoreSummaryEN._CurrTabName, SysScoreSummaryCRUD.id_CurrEduCls_Cache);
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
fldName: "schoolYear",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "学年",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 3,
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
orderNum: 4,
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
orderNum: 5,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "userName",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "用户名",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 6,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "id_XzCollege",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "学院流水号",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 7,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "collegeName",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "学院名称",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 8,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "id_XzMajor",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "专业流水号",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 9,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "majorName",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "专业名称",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 10,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "id_GradeBase",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "年级流水号",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 11,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "gradeBaseName",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "年级名称",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 12,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "scoreTypeName",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "分数类型名称",
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
];
arrvSysScoreSummaryObjLst = arrvSysScoreSummaryObjLst.sort(this.SortFun_ExportExcel);
  this.CombineData(arrvSysScoreSummaryObjLst, arrDataColumn); 
//console.log("完成BindGv_vSysScoreSummary!");
}
catch(e)
{
const strMsg = Format("绑定对象列表不成功, {0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
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
 * 设置绑定下拉框，针对字段:[ScoreTypeId]
 * (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl_TS4QryRegion4TabFeature1B)
 **/

public async SetDdl_ScoreTypeIdInDiv()
{
await SysScoreType_BindDdl_ScoreTypeIdInDiv_Cache(this.divName4Query, "ddlScoreTypeId_q" );//
}


 /** 函数功能:为查询区绑定下拉框
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4QueryRegion)
 **/
public async BindDdl4QueryRegion()
{
const strThisFuncName = this.BindDdl4QueryRegion.name;
// 在此处放置用户代码以初始化页面


await this.SetDdl_SchoolYearInDiv();//查询区域

await this.SetDdl_ScoreTypeIdInDiv();//查询区域
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
await this.BindGv_vSysScoreSummary();
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
 await this.BindGv_vSysScoreSummary();
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
const returnInt = await SysScoreSummary_DelRecordAsync(lngmId);
if (returnInt > 0)
{
//SysScoreSummary_ReFreshCache(SysScoreSummaryCRUD.id_CurrEduCls_Cache);
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
const objSysScoreSummaryEN = await SysScoreSummary_GetObjBymIdAsync(lngmId);
//console.log("完成SelectRecord!", objSysScoreSummaryEN);
Redirect("/Index/Main_vSysScoreSummary");
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
await this.BindGv_vSysScoreSummary();
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
const responseBindGv = await this.ExportExcel_vSysScoreSummary_Cache();
}

 /** 把所有的查询控件内容组合成一个条件串
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
 * @returns 条件串(strWhereCond)
 **/
 public async CombinevSysScoreSummaryCondition():Promise<string> 
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。

try
{
if ( this.userName_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsvSysScoreSummaryEN.con_UserName, this.userName_q);
}
if ( this.schoolYear_q != "" && this.schoolYear_q != "0")
{
strWhereCond += Format(" And {0} = '{1}'", clsvSysScoreSummaryEN.con_SchoolYear, this.schoolYear_q);
}
if ( this.scoreTypeId_q != "" && this.scoreTypeId_q != "0")
{
strWhereCond += Format(" And {0} = '{1}'", clsvSysScoreSummaryEN.con_ScoreTypeId, this.scoreTypeId_q);
}
}
catch(objException)
{
const strMsg:string = Format("(errid:WiTsCs0009)在组合查询条件(CombineSysScoreSummaryCondition)时出错!请联系管理员!{0}", objException);
throw strMsg;
}
return strWhereCond;
}

 /** 把所有的查询控件内容组合成一个条件串
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
 * @returns 条件串(strWhereCond)
 **/
 public async CombinevSysScoreSummaryConditionObj(): Promise<clsvSysScoreSummaryEN> 
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
const objvSysScoreSummary_Cond = new clsvSysScoreSummaryEN();
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
try
{
if ( this.userName_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsvSysScoreSummaryEN.con_UserName, this.userName_q);
objvSysScoreSummary_Cond.SetCondFldValue(clsvSysScoreSummaryEN.con_UserName, this.userName_q, "like");
}
if ( this.schoolYear_q != "" && this.schoolYear_q != "0")
{
strWhereCond += Format(" And {0} = '{1}'", clsvSysScoreSummaryEN.con_SchoolYear, this.schoolYear_q);
objvSysScoreSummary_Cond.SetCondFldValue(clsvSysScoreSummaryEN.con_SchoolYear, this.schoolYear_q, "=");
}
if ( this.scoreTypeId_q != "" && this.scoreTypeId_q != "0")
{
strWhereCond += Format(" And {0} = '{1}'", clsvSysScoreSummaryEN.con_ScoreTypeId, this.scoreTypeId_q);
objvSysScoreSummary_Cond.SetCondFldValue(clsvSysScoreSummaryEN.con_ScoreTypeId, this.scoreTypeId_q, "=");
}

}
catch(objException)
{
const strMsg:string = Format("(errid:WiTsCs0010)在组合查询条件对象(CombineSysScoreSummaryConditionObj)时出错!请联系管理员!{0}", objException);
throw strMsg;
}
objvSysScoreSummary_Cond.whereCond = strWhereCond;
return objvSysScoreSummary_Cond;
}

 /** 把所有的查询控件内容组合成一个条件串
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj4ExportExcel)
 * @returns 条件串(strWhereCond)
 **/
 public async CombinevSysScoreSummaryConditionObj4ExportExcel():Promise<clsvSysScoreSummaryEN> 
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
const objvSysScoreSummary_Cond = new clsvSysScoreSummaryENEx();
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
try
{
if ( this.userName_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsvSysScoreSummaryEN.con_UserName, this.userName_q);
objvSysScoreSummary_Cond.SetCondFldValue(clsvSysScoreSummaryEN.con_UserName, this.userName_q, "like");
}
if ( this.schoolYear_q != "" && this.schoolYear_q != "0")
{
strWhereCond += Format(" And {0} = '{1}'", clsvSysScoreSummaryEN.con_SchoolYear, this.schoolYear_q);
objvSysScoreSummary_Cond.SetCondFldValue(clsvSysScoreSummaryEN.con_SchoolYear, this.schoolYear_q, "=");
}
if ( this.scoreTypeId_q != "" && this.scoreTypeId_q != "0")
{
strWhereCond += Format(" And {0} = '{1}'", clsvSysScoreSummaryEN.con_ScoreTypeId, this.scoreTypeId_q);
objvSysScoreSummary_Cond.SetCondFldValue(clsvSysScoreSummaryEN.con_ScoreTypeId, this.scoreTypeId_q, "=");
}
}
catch(objException)
{
const strMsg:string = Format("(errid:WiTsCs0013)在组合导出Excel条件对象(CombineSysScoreSummaryConditionObj4ExportExcel)时出错!请联系管理员!{0}", objException);
throw strMsg;
}
objvSysScoreSummary_Cond.whereCond = strWhereCond;
return objvSysScoreSummary_Cond;
}

 /** 显示vSysScoreSummary对象的所有属性值
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
 * @param divContainer:显示容器
 * @param arrSysScoreSummaryObjLst:需要绑定的对象列表
 **/
public async BindTab_vSysScoreSummary(divContainer: string, arrvSysScoreSummaryObjLst: Array<clsvSysScoreSummaryEN>) 
{
const strThisFuncName = this.BindTab_vSysScoreSummary.name;
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
fldName: clsvSysScoreSummaryEN.con_SchoolYear,
sortBy: clsvSysScoreSummaryEN.con_SchoolYear,
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
fldName: clsvSysScoreSummaryEN.con_UserName,
sortBy: clsvSysScoreSummaryEN.con_UserName,
sortFun: SortFun,
getDataSource: "",
colHeader: "用户名",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 7,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: clsvSysScoreSummaryEN.con_CollegeName,
sortBy: clsvSysScoreSummaryEN.con_CollegeName,
sortFun: SortFun,
getDataSource: "",
colHeader: "学院名称",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 9,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: clsvSysScoreSummaryEN.con_MajorName,
sortBy: clsvSysScoreSummaryEN.con_MajorName,
sortFun: SortFun,
getDataSource: "",
colHeader: "专业名称",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 11,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: clsvSysScoreSummaryEN.con_GradeBaseName,
sortBy: clsvSysScoreSummaryEN.con_GradeBaseName,
sortFun: SortFun,
getDataSource: "",
colHeader: "年级名称",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 13,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: clsvSysScoreSummaryEN.con_ScoreTypeName,
sortBy: clsvSysScoreSummaryEN.con_ScoreTypeName,
sortFun: SortFun,
getDataSource: "",
colHeader: "分数类型名称",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 16,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
];
await BindTab_V(o, arrvSysScoreSummaryObjLst, arrDataColumn,  clsvSysScoreSummaryEN.con_mId, this); 
this.objPager.recCount = this.recCount;
this.objPager.pageSize = this.pageSize;
this.objPager.ShowPagerV2(this, this.divName4Pager);
}

 /** 扩展字段值的函数映射
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ExtendFldFuncMap)
 * @param arrvSysScoreSummaryExObjLst:需要映射的对象列表
 * @param arrDataColumn:用于绑定表的数据列信息
 **/
public async ExtendFldFuncMap(arrvSysScoreSummaryExObjLst: Array<clsvSysScoreSummaryENEx>, arrDataColumn: Array<clsDataColumn>) {
const arrFldName = clsvSysScoreSummaryEN.AttributeName;
for (const objDataColumn of arrDataColumn) {
if (IsNullOrEmpty(objDataColumn.fldName) == true) continue;
if (arrFldName.indexOf(objDataColumn.fldName) > -1) continue;
for (const objInFor of arrvSysScoreSummaryExObjLst) {
await vSysScoreSummaryEx_FuncMapByFldName(objDataColumn.fldName, objInFor);
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
const responseBindGv = await this.BindGv_vSysScoreSummary();
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
public async BindGv_vSysScoreSummary() 
{
const strThisFuncName = this.BindGv_vSysScoreSummary.name;
if (SysScoreSummaryCRUD.sortvSysScoreSummaryBy == null)
{
const strMsg = Format("在显示列表时，排序字段(sortvSysScoreSummaryBy)为空，请检查！(In BindGv_vSysScoreSummary)");
console.error(strMsg);
alert(strMsg);
return;
}
const strListDiv = this.divName4DataList;
const strWhereCond = await this.CombinevSysScoreSummaryCondition();
let intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
 let arrvSysScoreSummaryObjLst: Array <clsvSysScoreSummaryEN> = [];
try
{
this.recCount = await vSysScoreSummary_GetRecCountByCondAsync(strWhereCond);
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
orderBy: SysScoreSummaryCRUD.sortvSysScoreSummaryBy,//如果该字段为空，就使用下面的排序函数
sortFun: (x, y) => { console.log(x,y);return 0;}
}
const responseObjLst = await vSysScoreSummary_GetObjLstByPagerAsync(objPagerPara).then((jsonData)=>{
arrvSysScoreSummaryObjLst = < Array<clsvSysScoreSummaryEN>>jsonData;
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
if (arrvSysScoreSummaryObjLst.length == 0)
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
await this.BindTab_vSysScoreSummary(strListDiv, arrvSysScoreSummaryObjLst);
//console.log("完成BindGv_vSysScoreSummary!");
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
public async BindGv_vSysScoreSummary_Cache() 
{
const strThisFuncName = this.BindGv_vSysScoreSummary_Cache.name;
if (SysScoreSummaryCRUD.sortvSysScoreSummaryBy == null)
{
const strMsg = Format("在显示列表时，排序字段(sortvSysScoreSummaryBy)为空，请检查！(In BindGv_vSysScoreSummary_Cache)");
console.error(strMsg);
alert(strMsg);
return;
}
const strListDiv = this.divName4DataList;
const objvSysScoreSummary_Cond = await this.CombinevSysScoreSummaryConditionObj();
objvSysScoreSummary_Cond.SetCondFldValue(clsvSysScoreSummaryEN.con_id_CurrEduCls, SysScoreSummaryCRUD.id_CurrEduCls_Cache, "=");
const strWhereCond = JSON.stringify(objvSysScoreSummary_Cond);
let intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
 let arrvSysScoreSummaryObjLst: Array <clsvSysScoreSummaryEN> = [];
try
{
this.recCount = await vSysScoreSummary_GetRecCountByCond_Cache(objvSysScoreSummary_Cond, SysScoreSummaryCRUD.id_CurrEduCls_Cache);
if (this.recCount == 0)
{
const lblMsg: HTMLSpanElement = < HTMLSpanElement > document.createElement("span");
lblMsg.innerHTML = Format("根据条件:[{0}]获取的对象列表数为0！", objvSysScoreSummary_Cond.whereCond);
const divDataLst: HTMLDivElement = <HTMLDivElement> document.getElementById("divDataLst");
if (divDataLst != null)
{
divDataLst.innerText = "";
divDataLst.appendChild(lblMsg);
}
const strMsg = Format("在绑定Gv_Cache过程中，根据条件:[{0}]获取的对象列表数为0！", objvSysScoreSummary_Cond.whereCond);
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
orderBy: SysScoreSummaryCRUD.sortvSysScoreSummaryBy,//如果该字段为空，就使用下面的排序函数
sortFun: vSysScoreSummary_SortFun_Defa
}
arrvSysScoreSummaryObjLst = await vSysScoreSummary_GetObjLstByPager_Cache(objPagerPara, SysScoreSummaryCRUD.id_CurrEduCls_Cache);
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
if (arrvSysScoreSummaryObjLst.length == 0)
{
const lblMsg: HTMLSpanElement = < HTMLSpanElement > document.createElement("span");
lblMsg.innerHTML = "根据条件获取的对象列表数为0！";
const divDataLst: HTMLDivElement = < HTMLDivElement > document.getElementById("divDataLst");
if (divDataLst != null)
{
divDataLst.innerText = "";
divDataLst.appendChild(lblMsg);
}
const strKey = Format("{0}_{1}", clsSysScoreSummaryEN._CurrTabName, SysScoreSummaryCRUD.id_CurrEduCls_Cache);
const strMsg = Format("根据条件获取的记录数为0！(Key={0})", strKey);
console.error("Error: ", strMsg);
//console.trace();
ShowEmptyRecNumInfo(strListDiv, strMsg);
this.objPager.Hide(this.divName4Pager);
return;
}
try
{
await this.BindTab_vSysScoreSummary(strListDiv, arrvSysScoreSummaryObjLst);
//console.log("完成BindGv_vSysScoreSummary_Cache!");
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
public SortFun_ExportExcel(a:clsvSysScoreSummaryEN , b:clsvSysScoreSummaryEN): number 
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
const { sortFun, ascOrDesc4SortFun, sortBy } = GetSortBy(objAnchorElement, SysScoreSummaryCRUD.ascOrDesc4SortFun, SysScoreSummaryCRUD.sortvSysScoreSummaryBy, strSortExpress);
SysScoreSummaryCRUD.sortvSysScoreSummaryBy = sortBy;
SysScoreSummaryCRUD.ascOrDesc4SortFun = ascOrDesc4SortFun;
SysScoreSummaryCRUD.sortFun_Static = sortFun;
await this.BindGv_vSysScoreSummary();
}

 /** 复制记录
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CopyRecord)
 **/
public async CopyRecord(arrmId: Array<string>) {
const strThisFuncName = this.CopyRecord.name;
try
{
const arrSysScoreSummaryObjLst = await SysScoreSummary_GetObjLstBymIdLstAsync(arrmId);
//console.log('responseText=');
//console.log(responseText);
let intCount = 0;
for (const objInFor of arrSysScoreSummaryObjLst)
{
const returnBool = await SysScoreSummary_AddNewRecordAsync(objInFor);
//console.log('returnBool=');
//console.log(returnBool);
if (returnBool == true)
{
//SysScoreSummary_ReFreshCache(SysScoreSummaryCRUD.id_CurrEduCls_Cache);
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
const returnInt = await SysScoreSummary_DelSysScoreSummarysAsync(arrmId);
if (returnInt > 0)
{
//SysScoreSummary_ReFreshCache(SysScoreSummaryCRUD.id_CurrEduCls_Cache);
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
 * @param objSysScoreSummary:需要显示的对象
 **/
public ShowSysScoreSummaryObj(divContainer: string, objSysScoreSummary: clsSysScoreSummaryEN) 
{
const strThisFuncName = this.ShowSysScoreSummaryObj.name;
const o = document.getElementById(divContainer);
if (o == null)
{
alert(Format("{}不存在！",divContainer));
return;
}
const sstrKeys = GetObjKeys(objSysScoreSummary);
const ul: HTMLUListElement = document.createElement("ul");
for (const strKey of sstrKeys)
{
const strValue = objSysScoreSummary.GetFldValue(strKey);
const li: HTMLLIElement = document.createElement("li");
li.innerHTML = Format("{0}:{1}", strKey, strValue);
ul.appendChild(li);
}
o.appendChild(ul);
}

 /** 函数功能:从界面列表中获取第一个关键字的值
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetFirstKey)
 * @param pobjSysScoreSummaryEN:表实体类对象
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
 * 分数类型Id (Used In CombineCondition())
 **/
public  get scoreTypeId_q():string {
const strValue = GetSelectValueInDiv(this.divName4Query, "ddlScoreTypeId_q");
if (strValue == undefined) return "";
else if (strValue == "0") return "";
else return strValue;
}
 /**
 * 分数类型Id (Used In CombineCondition())
 **/
public  set scoreTypeId_q(value: string) {
SetSelectValueByIdInDiv(this.divName4Query, "ddlScoreTypeId_q", value);
}
 /**
 * 用户名 (Used In CombineCondition())
 **/
public  get userName_q():string {
const strValue = GetInputValueInDiv(this.divName4Query, "txtUserName_q");
if (strValue == undefined) return "";
else return strValue.toString();
}
 /**
 * 用户名 (Used In CombineCondition())
 **/
public  set userName_q(value: string) {
 SetInputValueByIdInDiv(this.divName4Query, "txtUserName_q", value);
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