﻿
 /**
 * 类名:gs_PaperVerCRUD(界面:gs_PaperVerCRUD)
 * 表名:gs_PaperVer(01120678)
 * 版本:2023.01.12.1(服务器:WIN-SRV103-116)
 * 日期:2023/01/12 16:38:16
 * 生成者:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 * 模块中文名:研培论文(GraduateEduPaper)
 * 框架-层名:WA_界面后台_TS(TS)(WA_ViewScriptCS_TS)
 * 编程语言:TypeScript
 **/
//import $ from "jquery";
import { gs_PaperVer_GetRecCountByCondAsync } from "../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperVerWApi.js";
import { gs_PaperVer_GetObjLstAsync } from "../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperVerWApi.js";
import { vPaperSimProEx_BindDdl_PaperIdByid_CurrEduClsInDiv_Cache } from "../../TS/L3_ForWApiEx/GraduateEduPaper/clsvPaperSimProExWApi.js";
import { CurrEduCls_BindDdl_id_CurrEduClsInDiv_Cache } from "../../TS/L3_ForWApi/DailyRunning_Share/clsCurrEduClsWApi.js";
import { gs_PaperVer_DelRecordAsync } from "../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperVerWApi.js";
import { gs_PaperVer_GetObjByPaperVIdAsync } from "../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperVerWApi.js";
import { clsgs_PaperVerEN } from "../../TS/L0_Entity/GraduateEduPaper/clsgs_PaperVerEN.js";
import { clsgs_PaperVerENEx } from "../../TS/L0_Entity/GraduateEduPaper/clsgs_PaperVerENEx.js";
import { gs_PaperVerEx_FuncMapByFldName } from "../../TS/L3_ForWApiEx/GraduateEduPaper/clsgs_PaperVerExWApi.js";
import { gs_PaperVer_GetObjLstByPagerAsync } from "../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperVerWApi.js";
import { gs_PaperVer_GetObjLstByPaperVIdLstAsync } from "../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperVerWApi.js";
import { gs_PaperVer_AddNewRecordAsync } from "../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperVerWApi.js";
import { gs_PaperVer_Delgs_PaperVersAsync } from "../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperVerWApi.js";
import {  arrSelectedKeys, BindDdl_TrueAndFalseInDiv, BindTab, confirm_del, GetObjKeys, Redirect, SortFun  } from "../../TS/PubFun/clsCommFunc4Web.js";
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
 /** gs_PaperVerCRUD 的摘要说明。其中Q代表查询,U代表修改
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
 **/
export abstract class gs_PaperVerCRUD implements clsOperateList
{
public static objPage_CRUD: gs_PaperVerCRUD;
public static sortFun_Static: (ascOrDesc: string) => (x: any, y: any) => number;
public static ascOrDesc4SortFun = "Asc";
public static sortgs_PaperVerBy = "";

//专门用于数据列表的界面变量，用于分页功能等
public currPageIndex = 0;
public divName4List = "divList";  //列表区的层Id
public divName4DataList = "divDataLst";  //列表中数据区的层Id
public divName4Pager = "divPager";  //列表中的分页区的层Id
public bolIsInitShow = false;  //记录是否导入分页区的变量
public bolIsTableSm = true;//是否窄行的小表，即表中加样式： table-sm
//public mstrListDiv = "divDataLst";//列表区数据列表层id
public objPager: clsPager;

public static id_CurrEduCls_Static = "";//查询区下拉框条件变量1
public static CourseId_Static = "";//查询区下拉框条件变量1
public divName4Query = "divQuery";  //查询区的层Id
public divName4Function = "divFunction";  //功能区的层Id
public divName4Layout = "divLayout";  //界面布局的层Id
constructor() {
gs_PaperVerCRUD.objPage_CRUD = this;
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


gs_PaperVerCRUD.sortgs_PaperVerBy = "paperVId Asc";
if (this.bolIsInitShow == false)  //
{
this.objPager.InitShow(this.divName4Pager);
this.bolIsInitShow = true;  //
}
//2、显示无条件的表内容在GridView中
const responseBindGv = await this.BindGv_gs_PaperVer();
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
gs_PaperVerCRUD.sortgs_PaperVerBy = "paperVId Asc";
if (this.bolIsInitShow == false)  //
{
this.objPager.InitShow(this.divName4Pager);
this.bolIsInitShow = true;  //
}
//2、显示无条件的表内容在GridView中
const responseBindGv = await this.BindGv_gs_PaperVer();
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
const responseBindGv = await this.BindGv_gs_PaperVer();
}

 /** 合并数据
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineData)
 **/
public CombineData(arrgs_PaperVerObjLst: Array<clsgs_PaperVerEN>, arrDataColumn: Array<clsDataColumn>) 
{
const strThisFuncName = this.CombineData.name;
const intRowNum = arrgs_PaperVerObjLst.length;
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
const objEN: clsgs_PaperVerEN = arrgs_PaperVerObjLst[i];
for (let j = 0; j < intColNum; j++)
{
arrRow.push(objEN.GetFldValue(arrDataColumn[j].fldName));//i + "" + j;
}
arrData.push(arrRow);
}
//console.log("arrData", arrData);
const strFileName = Format("论文历史版本表({0})导出.xlsx",
 clsgs_PaperVerEN._CurrTabName);
exportSpecialExcel_pyf(arrData, strFileName);
}

 /** 根据条件获取相应的对象列表
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ExportExcel)
 **/
public async ExportExcel_gs_PaperVer() 
{
const strThisFuncName = this.ExportExcel_gs_PaperVer.name;
if (gs_PaperVerCRUD.sortgs_PaperVerBy == null)
{
const strMsg = Format("在显示列表时，排序字段(sortgs_PaperVerBy)为空，请检查！(In BindGv_gs_PaperVer_Cache)");
console.error(strMsg);
alert(strMsg);
return;
}
const strListDiv = this.divName4DataList;
const strWhereCond = await this.Combinegs_PaperVerCondition();
const intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
 let arrgs_PaperVerObjLst: Array <clsgs_PaperVerEN> = [];
try
{
this.recCount = await gs_PaperVer_GetRecCountByCondAsync(strWhereCond);
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
arrgs_PaperVerObjLst = await gs_PaperVer_GetObjLstAsync(strWhereCond);
}
catch(e)
{
const strMsg = Format("绑定GridView不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
if (arrgs_PaperVerObjLst.length == 0)
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
fldName: "paperTitle",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "论文标题",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 3,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "paperContent",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "主题内容",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 4,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "periodical",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "期刊",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 5,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "author",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "作者",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 6,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "researchQuestion",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "研究问题",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 7,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "keyword",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "关键字",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 8,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "literatureSources",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "文献来源",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 9,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "literatureLink",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "文献链接",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 10,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "uploadfileUrl",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "文件地址",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 11,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "isQuotethesis",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "是否引用论文",
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
fldName: "isChecked",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "是否检查",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 14,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "checker",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "审核人",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 16,
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
orderNum: 18,
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
orderNum: 19,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "id_CurrEduCls",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "教学班流水号",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 20,
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
orderNum: 23,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
];
arrgs_PaperVerObjLst = arrgs_PaperVerObjLst.sort(this.SortFun_ExportExcel);
  this.CombineData(arrgs_PaperVerObjLst, arrDataColumn); 
//console.log("完成BindGv_gs_PaperVer!");
}
catch(e)
{
const strMsg = Format("绑定对象列表不成功, {0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
}

 /**
 * 设置绑定下拉框，针对字段:[PaperId]
 * (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl_TS4QryRegion4TabFeature1B)
 **/

public async SetDdl_PaperIdInDiv(Id_CurrEduCls:string)
{
await vPaperSimProEx_BindDdl_PaperIdByid_CurrEduClsInDiv_Cache(this.divName4Query, "ddlPaperId_q" , Id_CurrEduCls);//
}

 /**
 * 设置绑定下拉框，针对字段:[id_CurrEduCls]
 * (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl_TS4QryRegion4TabFeature1B)
 **/

public async SetDdl_id_CurrEduClsInDiv(courseId:string)
{
await CurrEduCls_BindDdl_id_CurrEduClsInDiv_Cache(this.divName4Query, "ddlid_CurrEduCls_q" , courseId);//
}


 /** 函数功能:为查询区绑定下拉框
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4QueryRegion)
 **/
public async BindDdl4QueryRegion()
{
const strThisFuncName = this.BindDdl4QueryRegion.name;
// 在此处放置用户代码以初始化页面
const strid_CurrEduCls = gs_PaperVerCRUD.id_CurrEduCls_Static;
const strCourseId = gs_PaperVerCRUD.CourseId_Static;


await this.SetDdl_PaperIdInDiv(strid_CurrEduCls);//查询区域

await this.SetDdl_id_CurrEduClsInDiv(strCourseId);//查询区域
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
await this.BindGv_gs_PaperVer();
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
 * "lngPaperVId": 表关键字
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
 await this.BindGv_gs_PaperVer();
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
public async btnSelectRecordInTab_Click(lngPaperVId: number) {
const strThisFuncName = this.btnSelectRecordInTab_Click.name;
try
{
if (lngPaperVId == 0)
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
this.SelectRecord(lngPaperVId);
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
public async DelRecord(lngPaperVId: number) {
const strThisFuncName = this.DelRecord.name;
try
{
const returnInt = await gs_PaperVer_DelRecordAsync(lngPaperVId);
if (returnInt > 0)
{
//gs_PaperVer_ReFreshCache();
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
public async SelectRecord(lngPaperVId: number) 
{
const strThisFuncName = this.SelectRecord.name;
try
{
const objgs_PaperVerEN = await gs_PaperVer_GetObjByPaperVIdAsync(lngPaperVId);
//console.log("完成SelectRecord!", objgs_PaperVerEN);
Redirect("/Index/Main_gs_PaperVer");
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
await this.BindGv_gs_PaperVer();
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
const responseBindGv = await this.ExportExcel_gs_PaperVer();
}

 /** 把所有的查询控件内容组合成一个条件串
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
 * @returns 条件串(strWhereCond)
 **/
 public async Combinegs_PaperVerCondition():Promise<string> 
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。

try
{
if ( this.paperId_q != "" && this.paperId_q != "0")
{
strWhereCond += Format(" And {0} = '{1}'", clsgs_PaperVerEN.con_PaperId, this.paperId_q);
}
if ( this.paperTitle_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsgs_PaperVerEN.con_PaperTitle, this.paperTitle_q);
}
if ( this.paperContent_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsgs_PaperVerEN.con_PaperContent, this.paperContent_q);
}
if ( this.periodical_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsgs_PaperVerEN.con_Periodical, this.periodical_q);
}
if ( this.author_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsgs_PaperVerEN.con_Author, this.author_q);
}
if ( this.researchQuestion_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsgs_PaperVerEN.con_ResearchQuestion, this.researchQuestion_q);
}
if ( this.keyword_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsgs_PaperVerEN.con_Keyword, this.keyword_q);
}
if ( this.literatureSources_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsgs_PaperVerEN.con_LiteratureSources, this.literatureSources_q);
}
if ( this.literatureLink_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsgs_PaperVerEN.con_LiteratureLink, this.literatureLink_q);
}
if ( this.uploadfileUrl_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsgs_PaperVerEN.con_UploadfileUrl, this.uploadfileUrl_q);
}
if (this.isQuotethesis_q == true)
{
strWhereCond += Format(" And {0} = '1'", clsgs_PaperVerEN.con_IsQuotethesis);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsgs_PaperVerEN.con_IsQuotethesis);
}
if (this.isSubmit_q == true)
{
strWhereCond += Format(" And {0} = '1'", clsgs_PaperVerEN.con_IsSubmit);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsgs_PaperVerEN.con_IsSubmit);
}
if (this.isChecked_q == true)
{
strWhereCond += Format(" And {0} = '1'", clsgs_PaperVerEN.con_IsChecked);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsgs_PaperVerEN.con_IsChecked);
}
if ( this.quoteId_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsgs_PaperVerEN.con_QuoteId, this.quoteId_q);
}
if ( this.checker_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsgs_PaperVerEN.con_Checker, this.checker_q);
}
if ( this.literatureTypeId_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsgs_PaperVerEN.con_LiteratureTypeId, this.literatureTypeId_q);
}
if ( this.id_CurrEduCls_q != "" && this.id_CurrEduCls_q != "0")
{
strWhereCond += Format(" And {0} = '{1}'", clsgs_PaperVerEN.con_id_CurrEduCls, this.id_CurrEduCls_q);
}
if ( this.paperTypeId_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsgs_PaperVerEN.con_PaperTypeId, this.paperTypeId_q);
}
if ( this.paperStatusId_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsgs_PaperVerEN.con_PaperStatusId, this.paperStatusId_q);
}
}
catch(objException)
{
const strMsg:string = Format("(errid:WiTsCs0009)在组合查询条件(Combinegs_PaperVerCondition)时出错!请联系管理员!{0}", objException);
throw strMsg;
}
return strWhereCond;
}

 /** 把所有的查询控件内容组合成一个条件串
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
 * @returns 条件串(strWhereCond)
 **/
 public async Combinegs_PaperVerConditionObj(): Promise<clsgs_PaperVerEN> 
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
const objgs_PaperVer_Cond = new clsgs_PaperVerEN();
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
try
{
if ( this.paperId_q != "" && this.paperId_q != "0")
{
strWhereCond += Format(" And {0} = '{1}'", clsgs_PaperVerEN.con_PaperId, this.paperId_q);
objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN.con_PaperId, this.paperId_q, "=");
}
if ( this.paperTitle_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsgs_PaperVerEN.con_PaperTitle, this.paperTitle_q);
objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN.con_PaperTitle, this.paperTitle_q, "like");
}
if ( this.paperContent_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsgs_PaperVerEN.con_PaperContent, this.paperContent_q);
objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN.con_PaperContent, this.paperContent_q, "like");
}
if ( this.periodical_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsgs_PaperVerEN.con_Periodical, this.periodical_q);
objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN.con_Periodical, this.periodical_q, "like");
}
if ( this.author_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsgs_PaperVerEN.con_Author, this.author_q);
objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN.con_Author, this.author_q, "like");
}
if ( this.researchQuestion_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsgs_PaperVerEN.con_ResearchQuestion, this.researchQuestion_q);
objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN.con_ResearchQuestion, this.researchQuestion_q, "like");
}
if ( this.keyword_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsgs_PaperVerEN.con_Keyword, this.keyword_q);
objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN.con_Keyword, this.keyword_q, "like");
}
if ( this.literatureSources_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsgs_PaperVerEN.con_LiteratureSources, this.literatureSources_q);
objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN.con_LiteratureSources, this.literatureSources_q, "like");
}
if ( this.literatureLink_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsgs_PaperVerEN.con_LiteratureLink, this.literatureLink_q);
objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN.con_LiteratureLink, this.literatureLink_q, "like");
}
if ( this.uploadfileUrl_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsgs_PaperVerEN.con_UploadfileUrl, this.uploadfileUrl_q);
objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN.con_UploadfileUrl, this.uploadfileUrl_q, "like");
}
if (this.isQuotethesis_q == true)
{
strWhereCond += Format(" And {0} = '1'", clsgs_PaperVerEN.con_IsQuotethesis);
objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN.con_IsQuotethesis, true, "=");
}
else
{
strWhereCond += Format(" And {0} = '0'", clsgs_PaperVerEN.con_IsQuotethesis);
objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN.con_IsQuotethesis, false, "=");
}
if (this.isSubmit_q == true)
{
strWhereCond += Format(" And {0} = '1'", clsgs_PaperVerEN.con_IsSubmit);
objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN.con_IsSubmit, true, "=");
}
else
{
strWhereCond += Format(" And {0} = '0'", clsgs_PaperVerEN.con_IsSubmit);
objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN.con_IsSubmit, false, "=");
}
if (this.isChecked_q == true)
{
strWhereCond += Format(" And {0} = '1'", clsgs_PaperVerEN.con_IsChecked);
objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN.con_IsChecked, true, "=");
}
else
{
strWhereCond += Format(" And {0} = '0'", clsgs_PaperVerEN.con_IsChecked);
objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN.con_IsChecked, false, "=");
}
if ( this.quoteId_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsgs_PaperVerEN.con_QuoteId, this.quoteId_q);
objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN.con_QuoteId, this.quoteId_q, "like");
}
if ( this.checker_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsgs_PaperVerEN.con_Checker, this.checker_q);
objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN.con_Checker, this.checker_q, "like");
}
if ( this.literatureTypeId_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsgs_PaperVerEN.con_LiteratureTypeId, this.literatureTypeId_q);
objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN.con_LiteratureTypeId, this.literatureTypeId_q, "like");
}
if ( this.id_CurrEduCls_q != "" && this.id_CurrEduCls_q != "0")
{
strWhereCond += Format(" And {0} = '{1}'", clsgs_PaperVerEN.con_id_CurrEduCls, this.id_CurrEduCls_q);
objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN.con_id_CurrEduCls, this.id_CurrEduCls_q, "=");
}
if ( this.paperTypeId_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsgs_PaperVerEN.con_PaperTypeId, this.paperTypeId_q);
objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN.con_PaperTypeId, this.paperTypeId_q, "like");
}
if ( this.paperStatusId_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsgs_PaperVerEN.con_PaperStatusId, this.paperStatusId_q);
objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN.con_PaperStatusId, this.paperStatusId_q, "like");
}

}
catch(objException)
{
const strMsg:string = Format("(errid:WiTsCs0010)在组合查询条件对象(Combinegs_PaperVerConditionObj)时出错!请联系管理员!{0}", objException);
throw strMsg;
}
objgs_PaperVer_Cond.whereCond = strWhereCond;
return objgs_PaperVer_Cond;
}

 /** 把所有的查询控件内容组合成一个条件串
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj4ExportExcel)
 * @returns 条件串(strWhereCond)
 **/
 public async Combinegs_PaperVerConditionObj4ExportExcel():Promise<clsgs_PaperVerEN> 
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
const objgs_PaperVer_Cond = new clsgs_PaperVerENEx();
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
try
{
if ( this.paperId_q != "" && this.paperId_q != "0")
{
strWhereCond += Format(" And {0} = '{1}'", clsgs_PaperVerEN.con_PaperId, this.paperId_q);
objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN.con_PaperId, this.paperId_q, "=");
}
if ( this.paperTitle_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsgs_PaperVerEN.con_PaperTitle, this.paperTitle_q);
objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN.con_PaperTitle, this.paperTitle_q, "like");
}
if ( this.paperContent_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsgs_PaperVerEN.con_PaperContent, this.paperContent_q);
objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN.con_PaperContent, this.paperContent_q, "like");
}
if ( this.periodical_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsgs_PaperVerEN.con_Periodical, this.periodical_q);
objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN.con_Periodical, this.periodical_q, "like");
}
if ( this.author_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsgs_PaperVerEN.con_Author, this.author_q);
objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN.con_Author, this.author_q, "like");
}
if ( this.researchQuestion_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsgs_PaperVerEN.con_ResearchQuestion, this.researchQuestion_q);
objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN.con_ResearchQuestion, this.researchQuestion_q, "like");
}
if ( this.keyword_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsgs_PaperVerEN.con_Keyword, this.keyword_q);
objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN.con_Keyword, this.keyword_q, "like");
}
if ( this.literatureSources_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsgs_PaperVerEN.con_LiteratureSources, this.literatureSources_q);
objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN.con_LiteratureSources, this.literatureSources_q, "like");
}
if ( this.literatureLink_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsgs_PaperVerEN.con_LiteratureLink, this.literatureLink_q);
objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN.con_LiteratureLink, this.literatureLink_q, "like");
}
if ( this.uploadfileUrl_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsgs_PaperVerEN.con_UploadfileUrl, this.uploadfileUrl_q);
objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN.con_UploadfileUrl, this.uploadfileUrl_q, "like");
}
if (this.isQuotethesis_q == true)
{
strWhereCond += Format(" And {0} = '1'", clsgs_PaperVerEN.con_IsQuotethesis);
objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN.con_IsQuotethesis, true, "=");
}
else
{
strWhereCond += Format(" And {0} = '0'", clsgs_PaperVerEN.con_IsQuotethesis);
objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN.con_IsQuotethesis, false, "=");
}
if (this.isSubmit_q == true)
{
strWhereCond += Format(" And {0} = '1'", clsgs_PaperVerEN.con_IsSubmit);
objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN.con_IsSubmit, true, "=");
}
else
{
strWhereCond += Format(" And {0} = '0'", clsgs_PaperVerEN.con_IsSubmit);
objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN.con_IsSubmit, false, "=");
}
if (this.isChecked_q == true)
{
strWhereCond += Format(" And {0} = '1'", clsgs_PaperVerEN.con_IsChecked);
objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN.con_IsChecked, true, "=");
}
else
{
strWhereCond += Format(" And {0} = '0'", clsgs_PaperVerEN.con_IsChecked);
objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN.con_IsChecked, false, "=");
}
if ( this.quoteId_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsgs_PaperVerEN.con_QuoteId, this.quoteId_q);
objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN.con_QuoteId, this.quoteId_q, "like");
}
if ( this.checker_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsgs_PaperVerEN.con_Checker, this.checker_q);
objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN.con_Checker, this.checker_q, "like");
}
if ( this.literatureTypeId_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsgs_PaperVerEN.con_LiteratureTypeId, this.literatureTypeId_q);
objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN.con_LiteratureTypeId, this.literatureTypeId_q, "like");
}
if ( this.id_CurrEduCls_q != "" && this.id_CurrEduCls_q != "0")
{
strWhereCond += Format(" And {0} = '{1}'", clsgs_PaperVerEN.con_id_CurrEduCls, this.id_CurrEduCls_q);
objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN.con_id_CurrEduCls, this.id_CurrEduCls_q, "=");
}
if ( this.paperTypeId_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsgs_PaperVerEN.con_PaperTypeId, this.paperTypeId_q);
objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN.con_PaperTypeId, this.paperTypeId_q, "like");
}
if ( this.paperStatusId_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsgs_PaperVerEN.con_PaperStatusId, this.paperStatusId_q);
objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN.con_PaperStatusId, this.paperStatusId_q, "like");
}
}
catch(objException)
{
const strMsg:string = Format("(errid:WiTsCs0013)在组合导出Excel条件对象(Combinegs_PaperVerConditionObj4ExportExcel)时出错!请联系管理员!{0}", objException);
throw strMsg;
}
objgs_PaperVer_Cond.whereCond = strWhereCond;
return objgs_PaperVer_Cond;
}

 /** 显示gs_PaperVer对象的所有属性值
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
 * @param divContainer:显示容器
 * @param arrgs_PaperVerObjLst:需要绑定的对象列表
 **/
public async BindTab_gs_PaperVer(divContainer: string, arrgs_PaperVerObjLst: Array<clsgs_PaperVerEN>) 
{
const strThisFuncName = this.BindTab_gs_PaperVer.name;
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
fldName: clsgs_PaperVerEN.con_PaperVId,
sortBy: clsgs_PaperVerEN.con_PaperVId,
sortFun: SortFun,
getDataSource: "",
colHeader: "PaperVId",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 2,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: clsgs_PaperVerEN.con_PaperTitle,
sortBy: clsgs_PaperVerEN.con_PaperTitle,
sortFun: SortFun,
getDataSource: "",
colHeader: "论文标题",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 4,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: clsgs_PaperVerEN.con_PaperContent,
sortBy: clsgs_PaperVerEN.con_PaperContent,
sortFun: SortFun,
getDataSource: "",
colHeader: "主题内容",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 5,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: clsgs_PaperVerEN.con_Periodical,
sortBy: clsgs_PaperVerEN.con_Periodical,
sortFun: SortFun,
getDataSource: "",
colHeader: "期刊",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 6,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: clsgs_PaperVerEN.con_Author,
sortBy: clsgs_PaperVerEN.con_Author,
sortFun: SortFun,
getDataSource: "",
colHeader: "作者",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 7,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: clsgs_PaperVerEN.con_ResearchQuestion,
sortBy: clsgs_PaperVerEN.con_ResearchQuestion,
sortFun: SortFun,
getDataSource: "",
colHeader: "研究问题",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 8,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: clsgs_PaperVerEN.con_Keyword,
sortBy: clsgs_PaperVerEN.con_Keyword,
sortFun: SortFun,
getDataSource: "",
colHeader: "关键字",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 9,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: clsgs_PaperVerEN.con_LiteratureSources,
sortBy: clsgs_PaperVerEN.con_LiteratureSources,
sortFun: SortFun,
getDataSource: "",
colHeader: "文献来源",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 10,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: clsgs_PaperVerEN.con_LiteratureLink,
sortBy: clsgs_PaperVerEN.con_LiteratureLink,
sortFun: SortFun,
getDataSource: "",
colHeader: "文献链接",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 11,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: clsgs_PaperVerEN.con_UploadfileUrl,
sortBy: clsgs_PaperVerEN.con_UploadfileUrl,
sortFun: SortFun,
getDataSource: "",
colHeader: "文件地址",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 12,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: clsgs_PaperVerEN.con_IsQuotethesis,
sortBy: clsgs_PaperVerEN.con_IsQuotethesis,
sortFun: SortFun,
getDataSource: "",
colHeader: "是否引用论文",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 13,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: clsgs_PaperVerEN.con_IsSubmit,
sortBy: clsgs_PaperVerEN.con_IsSubmit,
sortFun: SortFun,
getDataSource: "",
colHeader: "是否提交",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 14,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: clsgs_PaperVerEN.con_IsChecked,
sortBy: clsgs_PaperVerEN.con_IsChecked,
sortFun: SortFun,
getDataSource: "",
colHeader: "是否检查",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 15,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: clsgs_PaperVerEN.con_Checker,
sortBy: clsgs_PaperVerEN.con_Checker,
sortFun: SortFun,
getDataSource: "",
colHeader: "审核人",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 17,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: clsgs_PaperVerEN.con_UpdUser,
sortBy: clsgs_PaperVerEN.con_UpdUser,
sortFun: SortFun,
getDataSource: "",
colHeader: "修改人",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 19,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: clsgs_PaperVerEN.con_UpdDate,
sortBy: clsgs_PaperVerEN.con_UpdDate,
sortFun: SortFun,
getDataSource: "",
colHeader: "修改日期",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 20,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: clsgs_PaperVerEN.con_id_CurrEduCls,
sortBy: clsgs_PaperVerEN.con_id_CurrEduCls,
sortFun: SortFun,
getDataSource: "",
colHeader: "教学班流水号",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 21,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: clsgs_PaperVerEN.con_Memo,
sortBy: clsgs_PaperVerEN.con_Memo,
sortFun: SortFun,
getDataSource: "",
colHeader: "备注",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 24,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
];
await BindTab(o, arrgs_PaperVerObjLst, arrDataColumn,  clsgs_PaperVerEN.con_PaperVId, this); 
this.objPager.recCount = this.recCount;
this.objPager.pageSize = this.pageSize;
this.objPager.ShowPagerV2(this, this.divName4Pager);
}

 /** 扩展字段值的函数映射
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ExtendFldFuncMap)
 * @param arrgs_PaperVerExObjLst:需要映射的对象列表
 * @param arrDataColumn:用于绑定表的数据列信息
 **/
public async ExtendFldFuncMap(arrgs_PaperVerExObjLst: Array<clsgs_PaperVerENEx>, arrDataColumn: Array<clsDataColumn>) {
const arrFldName = clsgs_PaperVerEN.AttributeName;
for (const objDataColumn of arrDataColumn) {
if (IsNullOrEmpty(objDataColumn.fldName) == true) continue;
if (arrFldName.indexOf(objDataColumn.fldName) > -1) continue;
for (const objInFor of arrgs_PaperVerExObjLst) {
await gs_PaperVerEx_FuncMapByFldName(objDataColumn.fldName, objInFor);
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
const responseBindGv = await this.BindGv_gs_PaperVer();
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
public async BindGv_gs_PaperVer() 
{
const strThisFuncName = this.BindGv_gs_PaperVer.name;
if (gs_PaperVerCRUD.sortgs_PaperVerBy == null)
{
const strMsg = Format("在显示列表时，排序字段(sortgs_PaperVerBy)为空，请检查！(In BindGv_gs_PaperVer)");
console.error(strMsg);
alert(strMsg);
return;
}
const strListDiv = this.divName4DataList;
const strWhereCond = await this.Combinegs_PaperVerCondition();
let intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
 let arrgs_PaperVerObjLst: Array <clsgs_PaperVerEN> = [];
try
{
this.recCount = await gs_PaperVer_GetRecCountByCondAsync(strWhereCond);
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
orderBy: gs_PaperVerCRUD.sortgs_PaperVerBy,//如果该字段为空，就使用下面的排序函数
sortFun: (x, y) => { console.log(x,y);return 0;}
}
const responseObjLst = await gs_PaperVer_GetObjLstByPagerAsync(objPagerPara).then((jsonData)=>{
arrgs_PaperVerObjLst = < Array<clsgs_PaperVerEN>>jsonData;
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
if (arrgs_PaperVerObjLst.length == 0)
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
await this.BindTab_gs_PaperVer(strListDiv, arrgs_PaperVerObjLst);
//console.log("完成BindGv_gs_PaperVer!");
}
catch(e)
{
//console.trace();
const strMsg = Format("绑定对象列表不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
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
public SortFun_ExportExcel(a:clsgs_PaperVerEN , b:clsgs_PaperVerEN): number 
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
const { sortFun, ascOrDesc4SortFun, sortBy } = GetSortBy(objAnchorElement, gs_PaperVerCRUD.ascOrDesc4SortFun, gs_PaperVerCRUD.sortgs_PaperVerBy, strSortExpress);
gs_PaperVerCRUD.sortgs_PaperVerBy = sortBy;
gs_PaperVerCRUD.ascOrDesc4SortFun = ascOrDesc4SortFun;
gs_PaperVerCRUD.sortFun_Static = sortFun;
await this.BindGv_gs_PaperVer();
}

 /** 复制记录
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CopyRecord)
 **/
public async CopyRecord(arrPaperVId: Array<string>) {
const strThisFuncName = this.CopyRecord.name;
try
{
const arrgs_PaperVerObjLst = await gs_PaperVer_GetObjLstByPaperVIdLstAsync(arrPaperVId);
//console.log('responseText=');
//console.log(responseText);
let intCount = 0;
for (const objInFor of arrgs_PaperVerObjLst)
{
const returnBool = await gs_PaperVer_AddNewRecordAsync(objInFor);
//console.log('returnBool=');
//console.log(returnBool);
if (returnBool == true)
{
//gs_PaperVer_ReFreshCache();
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
public async DelMultiRecord(arrPaperVId: Array<string>) {
const strThisFuncName = this.DelMultiRecord.name;
try
{
const returnInt = await gs_PaperVer_Delgs_PaperVersAsync(arrPaperVId);
if (returnInt > 0)
{
//gs_PaperVer_ReFreshCache();
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
 * @param objgs_PaperVer:需要显示的对象
 **/
public Showgs_PaperVerObj(divContainer: string, objgs_PaperVer: clsgs_PaperVerEN) 
{
const strThisFuncName = this.Showgs_PaperVerObj.name;
const o = document.getElementById(divContainer);
if (o == null)
{
alert(Format("{}不存在！",divContainer));
return;
}
const sstrKeys = GetObjKeys(objgs_PaperVer);
const ul: HTMLUListElement = document.createElement("ul");
for (const strKey of sstrKeys)
{
const strValue = objgs_PaperVer.GetFldValue(strKey);
const li: HTMLLIElement = document.createElement("li");
li.innerHTML = Format("{0}:{1}", strKey, strValue);
ul.appendChild(li);
}
o.appendChild(ul);
}

 /** 函数功能:从界面列表中获取第一个关键字的值
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetFirstKey)
 * @param pobjgs_PaperVerEN:表实体类对象
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
 * 作者 (Used In CombineCondition())
 **/
public  get author_q():string {
const strValue = GetInputValueInDiv(this.divName4Query, "txtAuthor_q");
if (strValue == undefined) return "";
else return strValue.toString();
}
 /**
 * 作者 (Used In CombineCondition())
 **/
public  set author_q(value: string) {
 SetInputValueByIdInDiv(this.divName4Query, "txtAuthor_q", value);
}
 /**
 * 审核人 (Used In CombineCondition())
 **/
public  get checker_q():string {
const strValue = GetInputValueInDiv(this.divName4Query, "txtChecker_q");
if (strValue == undefined) return "";
else return strValue.toString();
}
 /**
 * 审核人 (Used In CombineCondition())
 **/
public  set checker_q(value: string) {
 SetInputValueByIdInDiv(this.divName4Query, "txtChecker_q", value);
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
 * 是否检查 (Used In CombineCondition())
 **/
public  get isChecked_q():boolean {
const bolValue = GetCheckBoxValueInDiv(this.divName4Query, "chkIsChecked_q");
return bolValue;
}
 /**
 * 是否检查 (Used In CombineCondition())
 **/
public  set isChecked_q(value: boolean) {
 SetCheckBoxValueByIdInDiv(this.divName4Query, "chkIsChecked_q", value);
}
 /**
 * 是否引用论文 (Used In CombineCondition())
 **/
public  get isQuotethesis_q():boolean {
const bolValue = GetCheckBoxValueInDiv(this.divName4Query, "chkIsQuotethesis_q");
return bolValue;
}
 /**
 * 是否引用论文 (Used In CombineCondition())
 **/
public  set isQuotethesis_q(value: boolean) {
 SetCheckBoxValueByIdInDiv(this.divName4Query, "chkIsQuotethesis_q", value);
}
 /**
 * 是否提交 (Used In CombineCondition())
 **/
public  get isSubmit_q():boolean {
const bolValue = GetCheckBoxValueInDiv(this.divName4Query, "chkIsSubmit_q");
return bolValue;
}
 /**
 * 是否提交 (Used In CombineCondition())
 **/
public  set isSubmit_q(value: boolean) {
 SetCheckBoxValueByIdInDiv(this.divName4Query, "chkIsSubmit_q", value);
}
 /**
 * 关键字 (Used In CombineCondition())
 **/
public  get keyword_q():string {
const strValue = GetInputValueInDiv(this.divName4Query, "txtKeyword_q");
if (strValue == undefined) return "";
else return strValue.toString();
}
 /**
 * 关键字 (Used In CombineCondition())
 **/
public  set keyword_q(value: string) {
 SetInputValueByIdInDiv(this.divName4Query, "txtKeyword_q", value);
}
 /**
 * 文献链接 (Used In CombineCondition())
 **/
public  get literatureLink_q():string {
const strValue = GetInputValueInDiv(this.divName4Query, "txtLiteratureLink_q");
if (strValue == undefined) return "";
else return strValue.toString();
}
 /**
 * 文献链接 (Used In CombineCondition())
 **/
public  set literatureLink_q(value: string) {
 SetInputValueByIdInDiv(this.divName4Query, "txtLiteratureLink_q", value);
}
 /**
 * 文献来源 (Used In CombineCondition())
 **/
public  get literatureSources_q():string {
const strValue = GetInputValueInDiv(this.divName4Query, "txtLiteratureSources_q");
if (strValue == undefined) return "";
else return strValue.toString();
}
 /**
 * 文献来源 (Used In CombineCondition())
 **/
public  set literatureSources_q(value: string) {
 SetInputValueByIdInDiv(this.divName4Query, "txtLiteratureSources_q", value);
}
 /**
 * 作文类型Id (Used In CombineCondition())
 **/
public  get literatureTypeId_q():string {
const strValue = GetInputValueInDiv(this.divName4Query, "txtLiteratureTypeId_q");
if (strValue == undefined) return "";
else return strValue.toString();
}
 /**
 * 作文类型Id (Used In CombineCondition())
 **/
public  set literatureTypeId_q(value: string) {
 SetInputValueByIdInDiv(this.divName4Query, "txtLiteratureTypeId_q", value);
}
 /**
 * 主题内容 (Used In CombineCondition())
 **/
public  get paperContent_q():string {
const strValue = GetInputValueInDiv(this.divName4Query, "txtPaperContent_q");
if (strValue == undefined) return "";
else return strValue.toString();
}
 /**
 * 主题内容 (Used In CombineCondition())
 **/
public  set paperContent_q(value: string) {
 SetInputValueByIdInDiv(this.divName4Query, "txtPaperContent_q", value);
}
 /**
 * 论文Id (Used In CombineCondition())
 **/
public  get paperId_q():string {
const strValue = GetSelectValueInDiv(this.divName4Query, "ddlPaperId_q");
if (strValue == undefined) return "";
else if (strValue == "0") return "";
else return strValue;
}
 /**
 * 论文Id (Used In CombineCondition())
 **/
public  set paperId_q(value: string) {
SetSelectValueByIdInDiv(this.divName4Query, "ddlPaperId_q", value);
}
 /**
 * 论文状态Id (Used In CombineCondition())
 **/
public  get paperStatusId_q():string {
const strValue = GetInputValueInDiv(this.divName4Query, "txtPaperStatusId_q");
if (strValue == undefined) return "";
else return strValue.toString();
}
 /**
 * 论文状态Id (Used In CombineCondition())
 **/
public  set paperStatusId_q(value: string) {
 SetInputValueByIdInDiv(this.divName4Query, "txtPaperStatusId_q", value);
}
 /**
 * 论文标题 (Used In CombineCondition())
 **/
public  get paperTitle_q():string {
const strValue = GetInputValueInDiv(this.divName4Query, "txtPaperTitle_q");
if (strValue == undefined) return "";
else return strValue.toString();
}
 /**
 * 论文标题 (Used In CombineCondition())
 **/
public  set paperTitle_q(value: string) {
 SetInputValueByIdInDiv(this.divName4Query, "txtPaperTitle_q", value);
}
 /**
 * 论文类型Id (Used In CombineCondition())
 **/
public  get paperTypeId_q():string {
const strValue = GetInputValueInDiv(this.divName4Query, "txtPaperTypeId_q");
if (strValue == undefined) return "";
else return strValue.toString();
}
 /**
 * 论文类型Id (Used In CombineCondition())
 **/
public  set paperTypeId_q(value: string) {
 SetInputValueByIdInDiv(this.divName4Query, "txtPaperTypeId_q", value);
}
 /**
 * 期刊 (Used In CombineCondition())
 **/
public  get periodical_q():string {
const strValue = GetInputValueInDiv(this.divName4Query, "txtPeriodical_q");
if (strValue == undefined) return "";
else return strValue.toString();
}
 /**
 * 期刊 (Used In CombineCondition())
 **/
public  set periodical_q(value: string) {
 SetInputValueByIdInDiv(this.divName4Query, "txtPeriodical_q", value);
}
 /**
 * 引用Id (Used In CombineCondition())
 **/
public  get quoteId_q():string {
const strValue = GetInputValueInDiv(this.divName4Query, "txtQuoteId_q");
if (strValue == undefined) return "";
else return strValue.toString();
}
 /**
 * 引用Id (Used In CombineCondition())
 **/
public  set quoteId_q(value: string) {
 SetInputValueByIdInDiv(this.divName4Query, "txtQuoteId_q", value);
}
 /**
 * 研究问题 (Used In CombineCondition())
 **/
public  get researchQuestion_q():string {
const strValue = GetInputValueInDiv(this.divName4Query, "txtResearchQuestion_q");
if (strValue == undefined) return "";
else return strValue.toString();
}
 /**
 * 研究问题 (Used In CombineCondition())
 **/
public  set researchQuestion_q(value: string) {
 SetInputValueByIdInDiv(this.divName4Query, "txtResearchQuestion_q", value);
}
 /**
 * 文件地址 (Used In CombineCondition())
 **/
public  get uploadfileUrl_q():string {
const strValue = GetInputValueInDiv(this.divName4Query, "txtUploadfileUrl_q");
if (strValue == undefined) return "";
else return strValue.toString();
}
 /**
 * 文件地址 (Used In CombineCondition())
 **/
public  set uploadfileUrl_q(value: string) {
 SetInputValueByIdInDiv(this.divName4Query, "txtUploadfileUrl_q", value);
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