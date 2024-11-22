
 /**
 * 类名:SysSocialRelationsCRUD(界面:SysSocialRelationsCRUD)
 * 表名:SysSocialRelations(01120644)
 * 版本:2023.01.12.1(服务器:WIN-SRV103-116)
 * 日期:2023/01/12 16:40:08
 * 生成者:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 * 模块中文名:研培主题(GraduateEduTopic)
 * 框架-层名:WA_界面后台_TS(TS)(WA_ViewScriptCS_TS)
 * 编程语言:TypeScript
 **/
//import $ from "jquery";
import { vSysSocialRelations_GetRecCountByCondAsync } from "../../TS/L3_ForWApi/GraduateEduTopic/clsvSysSocialRelationsWApi.js";
import { vSysSocialRelations_GetObjLstAsync } from "../../TS/L3_ForWApi/GraduateEduTopic/clsvSysSocialRelationsWApi.js";
import { vSysSocialRelations_GetRecCountByCond_Cache } from "../../TS/L3_ForWApi/GraduateEduTopic/clsvSysSocialRelationsWApi.js";
import { vSysSocialRelations_GetSubObjLst_Cache } from "../../TS/L3_ForWApi/GraduateEduTopic/clsvSysSocialRelationsWApi.js";
import { SysSecurityLevel_BindDdl_LevelIdInDiv_Cache } from "../../TS/L3_ForWApi/ParameterTable/clsSysSecurityLevelWApi.js";
import { SysSocialRelations_DelRecordAsync } from "../../TS/L3_ForWApi/GraduateEduTopic/clsSysSocialRelationsWApi.js";
import { SysSocialRelations_GetObjBySocialIdAsync } from "../../TS/L3_ForWApi/GraduateEduTopic/clsSysSocialRelationsWApi.js";
import { clsvSysSocialRelationsEN } from "../../TS/L0_Entity/GraduateEduTopic/clsvSysSocialRelationsEN.js";
import { clsvSysSocialRelationsENEx } from "../../TS/L0_Entity/GraduateEduTopic/clsvSysSocialRelationsENEx.js";
import { vSysSocialRelationsEx_FuncMapByFldName } from "../../TS/L3_ForWApiEx/GraduateEduTopic/clsvSysSocialRelationsExWApi.js";
import { vSysSocialRelations_GetObjLstByPagerAsync } from "../../TS/L3_ForWApi/GraduateEduTopic/clsvSysSocialRelationsWApi.js";
import { vSysSocialRelations_SortFun_Defa } from "../../TS/L3_ForWApi/GraduateEduTopic/clsvSysSocialRelationsWApi.js";
import { vSysSocialRelations_GetObjLstByPager_Cache } from "../../TS/L3_ForWApi/GraduateEduTopic/clsvSysSocialRelationsWApi.js";
import { SysSocialRelations_GetObjLstBySocialIdLstAsync } from "../../TS/L3_ForWApi/GraduateEduTopic/clsSysSocialRelationsWApi.js";
import { SysSocialRelations_GetMaxStrIdAsync } from "../../TS/L3_ForWApi/GraduateEduTopic/clsSysSocialRelationsWApi.js";
import { SysSocialRelations_AddNewRecordAsync } from "../../TS/L3_ForWApi/GraduateEduTopic/clsSysSocialRelationsWApi.js";
import { SysSocialRelations_DelSysSocialRelationssAsync } from "../../TS/L3_ForWApi/GraduateEduTopic/clsSysSocialRelationsWApi.js";
import { clsSysSocialRelationsEN } from "../../TS/L0_Entity/GraduateEduTopic/clsSysSocialRelationsEN.js";
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
 /** SysSocialRelationsCRUD 的摘要说明。其中Q代表查询,U代表修改
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
 **/
export abstract class SysSocialRelationsCRUD implements clsOperateList
{
public static objPage_CRUD: SysSocialRelationsCRUD;
public static sortFun_Static: (ascOrDesc: string) => (x: any, y: any) => number;
public static ascOrDesc4SortFun = "Asc";
public static sortvSysSocialRelationsBy = "";

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
SysSocialRelationsCRUD.objPage_CRUD = this;
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


SysSocialRelationsCRUD.sortvSysSocialRelationsBy = "fullName Asc";
if (this.bolIsInitShow == false)  //
{
this.objPager.InitShow(this.divName4Pager);
this.bolIsInitShow = true;  //
}
//2、显示无条件的表内容在GridView中
const responseBindGv = await this.BindGv_vSysSocialRelations();
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
SysSocialRelationsCRUD.sortvSysSocialRelationsBy = "fullName Asc";
if (this.bolIsInitShow == false)  //
{
this.objPager.InitShow(this.divName4Pager);
this.bolIsInitShow = true;  //
}
//2、显示无条件的表内容在GridView中
const responseBindGv = await this.BindGv_vSysSocialRelations();
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
const responseBindGv = await this.BindGv_vSysSocialRelations();
}

 /** 合并数据
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineData)
 **/
public CombineData(arrvSysSocialRelationsObjLst: Array<clsvSysSocialRelationsEN>, arrDataColumn: Array<clsDataColumn>) 
{
const strThisFuncName = this.CombineData.name;
const intRowNum = arrvSysSocialRelationsObjLst.length;
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
const objEN: clsvSysSocialRelationsEN = arrvSysSocialRelationsObjLst[i];
for (let j = 0; j < intColNum; j++)
{
arrRow.push(objEN.GetFldValue(arrDataColumn[j].fldName));//i + "" + j;
}
arrData.push(arrRow);
}
//console.log("arrData", arrData);
const strFileName = Format("社会关系表({0})导出.xlsx",
 clsvSysSocialRelationsEN._CurrTabName);
exportSpecialExcel_pyf(arrData, strFileName);
}

 /** 根据条件获取相应的对象列表
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ExportExcel)
 **/
public async ExportExcel_vSysSocialRelations() 
{
const strThisFuncName = this.ExportExcel_vSysSocialRelations.name;
if (SysSocialRelationsCRUD.sortvSysSocialRelationsBy == null)
{
const strMsg = Format("在显示列表时，排序字段(sortvSysSocialRelationsBy)为空，请检查！(In BindGv_vSysSocialRelations_Cache)");
console.error(strMsg);
alert(strMsg);
return;
}
const strListDiv = this.divName4DataList;
const strWhereCond = await this.CombinevSysSocialRelationsCondition();
const intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
 let arrvSysSocialRelationsObjLst: Array <clsvSysSocialRelationsEN> = [];
try
{
this.recCount = await vSysSocialRelations_GetRecCountByCondAsync(strWhereCond);
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
arrvSysSocialRelationsObjLst = await vSysSocialRelations_GetObjLstAsync(strWhereCond);
}
catch(e)
{
const strMsg = Format("绑定GridView不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
if (arrvSysSocialRelationsObjLst.length == 0)
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
fldName: "socialId",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "社会Id",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 2,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "fullName",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "姓名",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 3,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "nationality",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "国籍",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 4,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "workUnit",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "工作单位",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 5,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "major",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "专业",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 6,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "achievement",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "成就",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 7,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "detailedDescription",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "详细说明",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 8,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "levelName",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "级别名称",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 10,
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
orderNum: 11,
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
orderNum: 12,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "isSubmit",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "是否提交",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 13,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "okCount",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "点赞统计",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 14,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "citationCount",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "引用统计",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 15,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "versionCount",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "版本统计",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 16,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "id_CurrEduCls",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "当前教学班流水号",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 17,
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
orderNum: 18,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
];
arrvSysSocialRelationsObjLst = arrvSysSocialRelationsObjLst.sort(this.SortFun_ExportExcel);
  this.CombineData(arrvSysSocialRelationsObjLst, arrDataColumn); 
//console.log("完成BindGv_vSysSocialRelations!");
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
public async ExportExcel_vSysSocialRelations_Cache() 
{
const strThisFuncName = this.ExportExcel_vSysSocialRelations_Cache.name;
if (SysSocialRelationsCRUD.sortvSysSocialRelationsBy == null)
{
const strMsg = Format("在显示列表时，排序字段(sortvSysSocialRelationsBy)为空，请检查！(In BindGv_vSysSocialRelations_Cache)");
console.error(strMsg);
alert(strMsg);
return;
}
const strListDiv = this.divName4DataList;
const objvSysSocialRelations_Cond = await this.CombinevSysSocialRelationsConditionObj4ExportExcel();
objvSysSocialRelations_Cond.SetCondFldValue(clsvSysSocialRelationsEN.con_id_CurrEduCls, SysSocialRelationsCRUD.id_CurrEduCls_Cache, "=");
const strWhereCond = JSON.stringify(objvSysSocialRelations_Cond);
const intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
 let arrvSysSocialRelationsObjLst: Array <clsvSysSocialRelationsEN> = [];
try
{
this.recCount = await vSysSocialRelations_GetRecCountByCond_Cache(objvSysSocialRelations_Cond, SysSocialRelationsCRUD.id_CurrEduCls_Cache);
if (this.recCount == 0)
{
const lblMsg: HTMLSpanElement = < HTMLSpanElement > document.createElement("span");
lblMsg.innerHTML = Format("根据条件:[{0}]获取的对象列表数为0！", objvSysSocialRelations_Cond.whereCond);
const divDataLst: HTMLDivElement = <HTMLDivElement> document.getElementById("divDataLst");
if (divDataLst != null)
{
divDataLst.innerText = "";
divDataLst.appendChild(lblMsg);
}
const strMsg = Format("在绑定Gv_Cache过程中，根据条件:[{0}]获取的对象列表数为0！", objvSysSocialRelations_Cond.whereCond);
console.error("Error: ", strMsg);
//console.trace();
alert(strMsg);
return;
}
arrvSysSocialRelationsObjLst = await vSysSocialRelations_GetSubObjLst_Cache(objvSysSocialRelations_Cond, SysSocialRelationsCRUD.id_CurrEduCls_Cache);
}
catch(e)
{
const strMsg = Format("绑定GridView不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
if (arrvSysSocialRelationsObjLst.length == 0)
{
const strKey = Format("{0}_{1}", clsSysSocialRelationsEN._CurrTabName, SysSocialRelationsCRUD.id_CurrEduCls_Cache);
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
fldName: "socialId",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "社会Id",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 2,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "fullName",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "姓名",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 3,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "nationality",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "国籍",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 4,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "workUnit",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "工作单位",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 5,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "major",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "专业",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 6,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "achievement",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "成就",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 7,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "detailedDescription",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "详细说明",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 8,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "levelName",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "级别名称",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 10,
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
orderNum: 11,
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
orderNum: 12,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "isSubmit",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "是否提交",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 13,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "okCount",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "点赞统计",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 14,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "citationCount",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "引用统计",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 15,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "versionCount",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "版本统计",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 16,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "id_CurrEduCls",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "当前教学班流水号",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 17,
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
orderNum: 18,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
];
arrvSysSocialRelationsObjLst = arrvSysSocialRelationsObjLst.sort(this.SortFun_ExportExcel);
  this.CombineData(arrvSysSocialRelationsObjLst, arrDataColumn); 
//console.log("完成BindGv_vSysSocialRelations!");
}
catch(e)
{
const strMsg = Format("绑定对象列表不成功, {0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
}

 /**
 * 设置绑定下拉框，针对字段:[LevelId]
 * (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl_TS4QryRegion4TabFeature1B)
 **/

public async SetDdl_LevelIdInDiv()
{
await SysSecurityLevel_BindDdl_LevelIdInDiv_Cache(this.divName4Query, "ddlLevelId_q" );//
}


 /** 函数功能:为查询区绑定下拉框
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4QueryRegion)
 **/
public async BindDdl4QueryRegion()
{
const strThisFuncName = this.BindDdl4QueryRegion.name;
// 在此处放置用户代码以初始化页面


await this.SetDdl_LevelIdInDiv();//查询区域
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
await this.BindGv_vSysSocialRelations();
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
 * "strSocialId": 表关键字
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
 await this.BindGv_vSysSocialRelations();
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
public async btnSelectRecordInTab_Click(strSocialId: string) {
const strThisFuncName = this.btnSelectRecordInTab_Click.name;
try
{
if (IsNullOrEmpty(strSocialId) == true)
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
this.SelectRecord(strSocialId);
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
public async DelRecord(strSocialId: string) {
const strThisFuncName = this.DelRecord.name;
try
{
const returnInt = await SysSocialRelations_DelRecordAsync(strSocialId);
if (returnInt > 0)
{
//SysSocialRelations_ReFreshCache(SysSocialRelationsCRUD.id_CurrEduCls_Cache);
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
public async SelectRecord(strSocialId: string) 
{
const strThisFuncName = this.SelectRecord.name;
try
{
const objSysSocialRelationsEN = await SysSocialRelations_GetObjBySocialIdAsync(strSocialId);
//console.log("完成SelectRecord!", objSysSocialRelationsEN);
Redirect("/Index/Main_vSysSocialRelations");
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
await this.BindGv_vSysSocialRelations();
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
const responseBindGv = await this.ExportExcel_vSysSocialRelations_Cache();
}

 /** 把所有的查询控件内容组合成一个条件串
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
 * @returns 条件串(strWhereCond)
 **/
 public async CombinevSysSocialRelationsCondition():Promise<string> 
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。

try
{
if ( this.fullName_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsvSysSocialRelationsEN.con_FullName, this.fullName_q);
}
if ( this.achievement_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsvSysSocialRelationsEN.con_Achievement, this.achievement_q);
}
if ( this.levelId_q != "" && this.levelId_q != "0")
{
strWhereCond += Format(" And {0} = '{1}'", clsvSysSocialRelationsEN.con_LevelId, this.levelId_q);
}
}
catch(objException)
{
const strMsg:string = Format("(errid:WiTsCs0009)在组合查询条件(CombineSysSocialRelationsCondition)时出错!请联系管理员!{0}", objException);
throw strMsg;
}
return strWhereCond;
}

 /** 把所有的查询控件内容组合成一个条件串
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
 * @returns 条件串(strWhereCond)
 **/
 public async CombinevSysSocialRelationsConditionObj(): Promise<clsvSysSocialRelationsEN> 
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
const objvSysSocialRelations_Cond = new clsvSysSocialRelationsEN();
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
try
{
if ( this.fullName_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsvSysSocialRelationsEN.con_FullName, this.fullName_q);
objvSysSocialRelations_Cond.SetCondFldValue(clsvSysSocialRelationsEN.con_FullName, this.fullName_q, "like");
}
if ( this.achievement_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsvSysSocialRelationsEN.con_Achievement, this.achievement_q);
objvSysSocialRelations_Cond.SetCondFldValue(clsvSysSocialRelationsEN.con_Achievement, this.achievement_q, "like");
}
if ( this.levelId_q != "" && this.levelId_q != "0")
{
strWhereCond += Format(" And {0} = '{1}'", clsvSysSocialRelationsEN.con_LevelId, this.levelId_q);
objvSysSocialRelations_Cond.SetCondFldValue(clsvSysSocialRelationsEN.con_LevelId, this.levelId_q, "=");
}

}
catch(objException)
{
const strMsg:string = Format("(errid:WiTsCs0010)在组合查询条件对象(CombineSysSocialRelationsConditionObj)时出错!请联系管理员!{0}", objException);
throw strMsg;
}
objvSysSocialRelations_Cond.whereCond = strWhereCond;
return objvSysSocialRelations_Cond;
}

 /** 把所有的查询控件内容组合成一个条件串
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj4ExportExcel)
 * @returns 条件串(strWhereCond)
 **/
 public async CombinevSysSocialRelationsConditionObj4ExportExcel():Promise<clsvSysSocialRelationsEN> 
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
const objvSysSocialRelations_Cond = new clsvSysSocialRelationsENEx();
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
try
{
if ( this.fullName_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsvSysSocialRelationsEN.con_FullName, this.fullName_q);
objvSysSocialRelations_Cond.SetCondFldValue(clsvSysSocialRelationsEN.con_FullName, this.fullName_q, "like");
}
if ( this.achievement_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsvSysSocialRelationsEN.con_Achievement, this.achievement_q);
objvSysSocialRelations_Cond.SetCondFldValue(clsvSysSocialRelationsEN.con_Achievement, this.achievement_q, "like");
}
if ( this.levelId_q != "" && this.levelId_q != "0")
{
strWhereCond += Format(" And {0} = '{1}'", clsvSysSocialRelationsEN.con_LevelId, this.levelId_q);
objvSysSocialRelations_Cond.SetCondFldValue(clsvSysSocialRelationsEN.con_LevelId, this.levelId_q, "=");
}
}
catch(objException)
{
const strMsg:string = Format("(errid:WiTsCs0013)在组合导出Excel条件对象(CombineSysSocialRelationsConditionObj4ExportExcel)时出错!请联系管理员!{0}", objException);
throw strMsg;
}
objvSysSocialRelations_Cond.whereCond = strWhereCond;
return objvSysSocialRelations_Cond;
}

 /** 显示vSysSocialRelations对象的所有属性值
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
 * @param divContainer:显示容器
 * @param arrSysSocialRelationsObjLst:需要绑定的对象列表
 **/
public async BindTab_vSysSocialRelations(divContainer: string, arrvSysSocialRelationsObjLst: Array<clsvSysSocialRelationsEN>) 
{
const strThisFuncName = this.BindTab_vSysSocialRelations.name;
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
fldName: clsvSysSocialRelationsEN.con_FullName,
sortBy: clsvSysSocialRelationsEN.con_FullName,
sortFun: SortFun,
getDataSource: "",
colHeader: "姓名",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 2,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: clsvSysSocialRelationsEN.con_Nationality,
sortBy: clsvSysSocialRelationsEN.con_Nationality,
sortFun: SortFun,
getDataSource: "",
colHeader: "国籍",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 3,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: clsvSysSocialRelationsEN.con_WorkUnit,
sortBy: clsvSysSocialRelationsEN.con_WorkUnit,
sortFun: SortFun,
getDataSource: "",
colHeader: "工作单位",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 4,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: clsvSysSocialRelationsEN.con_Major,
sortBy: clsvSysSocialRelationsEN.con_Major,
sortFun: SortFun,
getDataSource: "",
colHeader: "专业",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 5,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: clsvSysSocialRelationsEN.con_Achievement,
sortBy: clsvSysSocialRelationsEN.con_Achievement,
sortFun: SortFun,
getDataSource: "",
colHeader: "成就",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 6,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: clsvSysSocialRelationsEN.con_DetailedDescription,
sortBy: clsvSysSocialRelationsEN.con_DetailedDescription,
sortFun: SortFun,
getDataSource: "",
colHeader: "详细说明",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 7,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: clsvSysSocialRelationsEN.con_LevelName,
sortBy: clsvSysSocialRelationsEN.con_LevelName,
sortFun: SortFun,
getDataSource: "",
colHeader: "级别名称",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 8,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: clsvSysSocialRelationsEN.con_UpdUser,
sortBy: clsvSysSocialRelationsEN.con_UpdUser,
sortFun: SortFun,
getDataSource: "",
colHeader: "修改人",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 9,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: clsvSysSocialRelationsEN.con_UpdDate,
sortBy: clsvSysSocialRelationsEN.con_UpdDate,
sortFun: SortFun,
getDataSource: "",
colHeader: "修改日期",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 10,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: clsvSysSocialRelationsEN.con_IsSubmit,
sortBy: clsvSysSocialRelationsEN.con_IsSubmit,
sortFun: SortFun,
getDataSource: "",
colHeader: "是否提交",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 11,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
];
await BindTab_V(o, arrvSysSocialRelationsObjLst, arrDataColumn,  clsvSysSocialRelationsEN.con_SocialId, this); 
this.objPager.recCount = this.recCount;
this.objPager.pageSize = this.pageSize;
this.objPager.ShowPagerV2(this, this.divName4Pager);
}

 /** 扩展字段值的函数映射
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ExtendFldFuncMap)
 * @param arrvSysSocialRelationsExObjLst:需要映射的对象列表
 * @param arrDataColumn:用于绑定表的数据列信息
 **/
public async ExtendFldFuncMap(arrvSysSocialRelationsExObjLst: Array<clsvSysSocialRelationsENEx>, arrDataColumn: Array<clsDataColumn>) {
const arrFldName = clsvSysSocialRelationsEN.AttributeName;
for (const objDataColumn of arrDataColumn) {
if (IsNullOrEmpty(objDataColumn.fldName) == true) continue;
if (arrFldName.indexOf(objDataColumn.fldName) > -1) continue;
for (const objInFor of arrvSysSocialRelationsExObjLst) {
await vSysSocialRelationsEx_FuncMapByFldName(objDataColumn.fldName, objInFor);
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
const responseBindGv = await this.BindGv_vSysSocialRelations();
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
public async BindGv_vSysSocialRelations() 
{
const strThisFuncName = this.BindGv_vSysSocialRelations.name;
if (SysSocialRelationsCRUD.sortvSysSocialRelationsBy == null)
{
const strMsg = Format("在显示列表时，排序字段(sortvSysSocialRelationsBy)为空，请检查！(In BindGv_vSysSocialRelations)");
console.error(strMsg);
alert(strMsg);
return;
}
const strListDiv = this.divName4DataList;
const strWhereCond = await this.CombinevSysSocialRelationsCondition();
let intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
 let arrvSysSocialRelationsObjLst: Array <clsvSysSocialRelationsEN> = [];
try
{
this.recCount = await vSysSocialRelations_GetRecCountByCondAsync(strWhereCond);
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
orderBy: SysSocialRelationsCRUD.sortvSysSocialRelationsBy,//如果该字段为空，就使用下面的排序函数
sortFun: (x, y) => { console.log(x,y);return 0;}
}
const responseObjLst = await vSysSocialRelations_GetObjLstByPagerAsync(objPagerPara).then((jsonData)=>{
arrvSysSocialRelationsObjLst = < Array<clsvSysSocialRelationsEN>>jsonData;
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
if (arrvSysSocialRelationsObjLst.length == 0)
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
await this.BindTab_vSysSocialRelations(strListDiv, arrvSysSocialRelationsObjLst);
//console.log("完成BindGv_vSysSocialRelations!");
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
public async BindGv_vSysSocialRelations_Cache() 
{
const strThisFuncName = this.BindGv_vSysSocialRelations_Cache.name;
if (SysSocialRelationsCRUD.sortvSysSocialRelationsBy == null)
{
const strMsg = Format("在显示列表时，排序字段(sortvSysSocialRelationsBy)为空，请检查！(In BindGv_vSysSocialRelations_Cache)");
console.error(strMsg);
alert(strMsg);
return;
}
const strListDiv = this.divName4DataList;
const objvSysSocialRelations_Cond = await this.CombinevSysSocialRelationsConditionObj();
objvSysSocialRelations_Cond.SetCondFldValue(clsvSysSocialRelationsEN.con_id_CurrEduCls, SysSocialRelationsCRUD.id_CurrEduCls_Cache, "=");
const strWhereCond = JSON.stringify(objvSysSocialRelations_Cond);
let intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
 let arrvSysSocialRelationsObjLst: Array <clsvSysSocialRelationsEN> = [];
try
{
this.recCount = await vSysSocialRelations_GetRecCountByCond_Cache(objvSysSocialRelations_Cond, SysSocialRelationsCRUD.id_CurrEduCls_Cache);
if (this.recCount == 0)
{
const lblMsg: HTMLSpanElement = < HTMLSpanElement > document.createElement("span");
lblMsg.innerHTML = Format("根据条件:[{0}]获取的对象列表数为0！", objvSysSocialRelations_Cond.whereCond);
const divDataLst: HTMLDivElement = <HTMLDivElement> document.getElementById("divDataLst");
if (divDataLst != null)
{
divDataLst.innerText = "";
divDataLst.appendChild(lblMsg);
}
const strMsg = Format("在绑定Gv_Cache过程中，根据条件:[{0}]获取的对象列表数为0！", objvSysSocialRelations_Cond.whereCond);
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
orderBy: SysSocialRelationsCRUD.sortvSysSocialRelationsBy,//如果该字段为空，就使用下面的排序函数
sortFun: vSysSocialRelations_SortFun_Defa
}
arrvSysSocialRelationsObjLst = await vSysSocialRelations_GetObjLstByPager_Cache(objPagerPara, SysSocialRelationsCRUD.id_CurrEduCls_Cache);
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
if (arrvSysSocialRelationsObjLst.length == 0)
{
const lblMsg: HTMLSpanElement = < HTMLSpanElement > document.createElement("span");
lblMsg.innerHTML = "根据条件获取的对象列表数为0！";
const divDataLst: HTMLDivElement = < HTMLDivElement > document.getElementById("divDataLst");
if (divDataLst != null)
{
divDataLst.innerText = "";
divDataLst.appendChild(lblMsg);
}
const strKey = Format("{0}_{1}", clsSysSocialRelationsEN._CurrTabName, SysSocialRelationsCRUD.id_CurrEduCls_Cache);
const strMsg = Format("根据条件获取的记录数为0！(Key={0})", strKey);
console.error("Error: ", strMsg);
//console.trace();
ShowEmptyRecNumInfo(strListDiv, strMsg);
this.objPager.Hide(this.divName4Pager);
return;
}
try
{
await this.BindTab_vSysSocialRelations(strListDiv, arrvSysSocialRelationsObjLst);
//console.log("完成BindGv_vSysSocialRelations_Cache!");
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
public SortFun_ExportExcel(a:clsvSysSocialRelationsEN , b:clsvSysSocialRelationsEN): number 
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
const { sortFun, ascOrDesc4SortFun, sortBy } = GetSortBy(objAnchorElement, SysSocialRelationsCRUD.ascOrDesc4SortFun, SysSocialRelationsCRUD.sortvSysSocialRelationsBy, strSortExpress);
SysSocialRelationsCRUD.sortvSysSocialRelationsBy = sortBy;
SysSocialRelationsCRUD.ascOrDesc4SortFun = ascOrDesc4SortFun;
SysSocialRelationsCRUD.sortFun_Static = sortFun;
await this.BindGv_vSysSocialRelations();
}

 /** 复制记录
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CopyRecord)
 **/
public async CopyRecord(arrSocialId: Array<string>) {
const strThisFuncName = this.CopyRecord.name;
try
{
const arrSysSocialRelationsObjLst = await SysSocialRelations_GetObjLstBySocialIdLstAsync(arrSocialId);
//console.log('responseText=');
//console.log(responseText);
let intCount = 0;
for (const objInFor of arrSysSocialRelationsObjLst)
{
const strMaxStrId = await SysSocialRelations_GetMaxStrIdAsync();
//console.log('strMaxStrId=' + strMaxStrId);
objInFor.socialId = strMaxStrId;
const returnBool = await SysSocialRelations_AddNewRecordAsync(objInFor);
//console.log('returnBool=');
//console.log(returnBool);
if (returnBool == true)
{
//SysSocialRelations_ReFreshCache(SysSocialRelationsCRUD.id_CurrEduCls_Cache);
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
public async DelMultiRecord(arrSocialId: Array<string>) {
const strThisFuncName = this.DelMultiRecord.name;
try
{
const returnInt = await SysSocialRelations_DelSysSocialRelationssAsync(arrSocialId);
if (returnInt > 0)
{
//SysSocialRelations_ReFreshCache(SysSocialRelationsCRUD.id_CurrEduCls_Cache);
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
 * @param objSysSocialRelations:需要显示的对象
 **/
public ShowSysSocialRelationsObj(divContainer: string, objSysSocialRelations: clsSysSocialRelationsEN) 
{
const strThisFuncName = this.ShowSysSocialRelationsObj.name;
const o = document.getElementById(divContainer);
if (o == null)
{
alert(Format("{}不存在！",divContainer));
return;
}
const sstrKeys = GetObjKeys(objSysSocialRelations);
const ul: HTMLUListElement = document.createElement("ul");
for (const strKey of sstrKeys)
{
const strValue = objSysSocialRelations.GetFldValue(strKey);
const li: HTMLLIElement = document.createElement("li");
li.innerHTML = Format("{0}:{1}", strKey, strValue);
ul.appendChild(li);
}
o.appendChild(ul);
}

 /** 函数功能:从界面列表中获取第一个关键字的值
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetFirstKey)
 * @param pobjSysSocialRelationsEN:表实体类对象
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
 * 成就 (Used In CombineCondition())
 **/
public  get achievement_q():string {
const strValue = GetInputValueInDiv(this.divName4Query, "txtAchievement_q");
if (strValue == undefined) return "";
else return strValue.toString();
}
 /**
 * 成就 (Used In CombineCondition())
 **/
public  set achievement_q(value: string) {
 SetInputValueByIdInDiv(this.divName4Query, "txtAchievement_q", value);
}
 /**
 * 姓名 (Used In CombineCondition())
 **/
public  get fullName_q():string {
const strValue = GetInputValueInDiv(this.divName4Query, "txtFullName_q");
if (strValue == undefined) return "";
else return strValue.toString();
}
 /**
 * 姓名 (Used In CombineCondition())
 **/
public  set fullName_q(value: string) {
 SetInputValueByIdInDiv(this.divName4Query, "txtFullName_q", value);
}
 /**
 * 级别Id (Used In CombineCondition())
 **/
public  get levelId_q():string {
const strValue = GetSelectValueInDiv(this.divName4Query, "ddlLevelId_q");
if (strValue == undefined) return "";
else if (strValue == "0") return "";
else return strValue;
}
 /**
 * 级别Id (Used In CombineCondition())
 **/
public  set levelId_q(value: string) {
SetSelectValueByIdInDiv(this.divName4Query, "ddlLevelId_q", value);
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