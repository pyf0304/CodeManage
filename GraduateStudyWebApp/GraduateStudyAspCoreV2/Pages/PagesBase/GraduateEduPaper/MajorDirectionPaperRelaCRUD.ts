
 /**
 * 类名:MajorDirectionPaperRelaCRUD(界面:MajorDirectionPaperRelaCRUD)
 * 表名:MajorDirectionPaperRela(01120554)
 * 版本:2023.01.12.1(服务器:WIN-SRV103-116)
 * 日期:2023/01/12 16:38:34
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
import { vMajorDirectionPaperRela_GetRecCountByCondAsync } from "../../TS/L3_ForWApi/GraduateEduPaper/clsvMajorDirectionPaperRelaWApi.js";
import { vMajorDirectionPaperRela_GetObjLstAsync } from "../../TS/L3_ForWApi/GraduateEduPaper/clsvMajorDirectionPaperRelaWApi.js";
import { XzMajor_BindDdl_id_XzMajorInDiv_Cache } from "../../TS/L3_ForWApi/BaseInfo_Share/clsXzMajorWApi.js";
import { MajorDirectionPaperRela_DelRecordAsync } from "../../TS/L3_ForWApi/GraduateEduPaper/clsMajorDirectionPaperRelaWApi.js";
import { MajorDirectionPaperRela_GetObjBymIdAsync } from "../../TS/L3_ForWApi/GraduateEduPaper/clsMajorDirectionPaperRelaWApi.js";
import { clsvMajorDirectionPaperRelaEN } from "../../TS/L0_Entity/GraduateEduPaper/clsvMajorDirectionPaperRelaEN.js";
import { clsvMajorDirectionPaperRelaENEx } from "../../TS/L0_Entity/GraduateEduPaper/clsvMajorDirectionPaperRelaENEx.js";
import { vMajorDirectionPaperRelaEx_FuncMapByFldName } from "../../TS/L3_ForWApiEx/GraduateEduPaper/clsvMajorDirectionPaperRelaExWApi.js";
import { vMajorDirectionPaperRela_GetObjLstByPagerAsync } from "../../TS/L3_ForWApi/GraduateEduPaper/clsvMajorDirectionPaperRelaWApi.js";
import { MajorDirectionPaperRela_GetObjLstBymIdLstAsync } from "../../TS/L3_ForWApi/GraduateEduPaper/clsMajorDirectionPaperRelaWApi.js";
import { MajorDirectionPaperRela_AddNewRecordAsync } from "../../TS/L3_ForWApi/GraduateEduPaper/clsMajorDirectionPaperRelaWApi.js";
import { MajorDirectionPaperRela_DelMajorDirectionPaperRelasAsync } from "../../TS/L3_ForWApi/GraduateEduPaper/clsMajorDirectionPaperRelaWApi.js";
import { clsMajorDirectionPaperRelaEN } from "../../TS/L0_Entity/GraduateEduPaper/clsMajorDirectionPaperRelaEN.js";
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
 /** MajorDirectionPaperRelaCRUD 的摘要说明。其中Q代表查询,U代表修改
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
 **/
export abstract class MajorDirectionPaperRelaCRUD implements clsOperateList
{
public static objPage_CRUD: MajorDirectionPaperRelaCRUD;
public static sortFun_Static: (ascOrDesc: string) => (x: any, y: any) => number;
public static ascOrDesc4SortFun = "Asc";
public static sortvMajorDirectionPaperRelaBy = "";

//专门用于数据列表的界面变量，用于分页功能等
public currPageIndex = 0;
public divName4List = "divList";  //列表区的层Id
public divName4DataList = "divDataLst";  //列表中数据区的层Id
public divName4Pager = "divPager";  //列表中的分页区的层Id
public bolIsInitShow = false;  //记录是否导入分页区的变量
public bolIsTableSm = true;//是否窄行的小表，即表中加样式： table-sm
//public mstrListDiv = "divDataLst";//列表区数据列表层id
public objPager: clsPager;

public divName4Query = "divQuery";  //查询区的层Id
public divName4Function = "divFunction";  //功能区的层Id
public divName4Layout = "divLayout";  //界面布局的层Id
constructor() {
MajorDirectionPaperRelaCRUD.objPage_CRUD = this;
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


MajorDirectionPaperRelaCRUD.sortvMajorDirectionPaperRelaBy = "updDate Asc";
if (this.bolIsInitShow == false)  //
{
this.objPager.InitShow(this.divName4Pager);
this.bolIsInitShow = true;  //
}
//2、显示无条件的表内容在GridView中
const responseBindGv = await this.BindGv_vMajorDirectionPaperRela();
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
MajorDirectionPaperRelaCRUD.sortvMajorDirectionPaperRelaBy = "updDate Asc";
if (this.bolIsInitShow == false)  //
{
this.objPager.InitShow(this.divName4Pager);
this.bolIsInitShow = true;  //
}
//2、显示无条件的表内容在GridView中
const responseBindGv = await this.BindGv_vMajorDirectionPaperRela();
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
const responseBindGv = await this.BindGv_vMajorDirectionPaperRela();
}

 /** 合并数据
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineData)
 **/
public CombineData(arrvMajorDirectionPaperRelaObjLst: Array<clsvMajorDirectionPaperRelaEN>, arrDataColumn: Array<clsDataColumn>) 
{
const strThisFuncName = this.CombineData.name;
const intRowNum = arrvMajorDirectionPaperRelaObjLst.length;
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
const objEN: clsvMajorDirectionPaperRelaEN = arrvMajorDirectionPaperRelaObjLst[i];
for (let j = 0; j < intColNum; j++)
{
arrRow.push(objEN.GetFldValue(arrDataColumn[j].fldName));//i + "" + j;
}
arrData.push(arrRow);
}
//console.log("arrData", arrData);
const strFileName = Format("专业方向论文关系({0})导出.xlsx",
 clsvMajorDirectionPaperRelaEN._CurrTabName);
exportSpecialExcel_pyf(arrData, strFileName);
}

 /** 根据条件获取相应的对象列表
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ExportExcel)
 **/
public async ExportExcel_vMajorDirectionPaperRela() 
{
const strThisFuncName = this.ExportExcel_vMajorDirectionPaperRela.name;
if (MajorDirectionPaperRelaCRUD.sortvMajorDirectionPaperRelaBy == null)
{
const strMsg = Format("在显示列表时，排序字段(sortvMajorDirectionPaperRelaBy)为空，请检查！(In BindGv_vMajorDirectionPaperRela_Cache)");
console.error(strMsg);
alert(strMsg);
return;
}
const strListDiv = this.divName4DataList;
const strWhereCond = await this.CombinevMajorDirectionPaperRelaCondition();
const intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
 let arrvMajorDirectionPaperRelaObjLst: Array <clsvMajorDirectionPaperRelaEN> = [];
try
{
this.recCount = await vMajorDirectionPaperRela_GetRecCountByCondAsync(strWhereCond);
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
arrvMajorDirectionPaperRelaObjLst = await vMajorDirectionPaperRela_GetObjLstAsync(strWhereCond);
}
catch(e)
{
const strMsg = Format("绑定GridView不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
if (arrvMajorDirectionPaperRelaObjLst.length == 0)
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
fldName: "updUser",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "修改人",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 5,
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
orderNum: 6,
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
orderNum: 7,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "majorDirectionENName",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "研究方向英文名",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 8,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "majorDirectionName",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "研究方向名",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 9,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "majorDirectionExplain",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "专业方向说明",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 10,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "isVisible",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "是否显示",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 11,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: "paperTitle",
sortBy: "",
sortFun: SortFun,
getDataSource: "",
colHeader: "论文标题",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 12,
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
orderNum: 14,
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
orderNum: 15,
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
orderNum: 16,
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
orderNum: 17,
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
orderNum: 18,
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
orderNum: 19,
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
orderNum: 20,
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
orderNum: 21,
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
orderNum: 22,
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
orderNum: 23,
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
orderNum: 24,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
];
arrvMajorDirectionPaperRelaObjLst = arrvMajorDirectionPaperRelaObjLst.sort(this.SortFun_ExportExcel);
  this.CombineData(arrvMajorDirectionPaperRelaObjLst, arrDataColumn); 
//console.log("完成BindGv_vMajorDirectionPaperRela!");
}
catch(e)
{
const strMsg = Format("绑定对象列表不成功, {0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
}

 /**
 * 设置绑定下拉框，针对字段:[id_XzMajor]
 * (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl_TS4QryRegion4TabFeature1B)
 **/

public async SetDdl_id_XzMajorInDiv()
{
await XzMajor_BindDdl_id_XzMajorInDiv_Cache(this.divName4Query, "ddlid_XzMajor_q" );//
}


 /** 函数功能:为查询区绑定下拉框
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4QueryRegion)
 **/
public async BindDdl4QueryRegion()
{
const strThisFuncName = this.BindDdl4QueryRegion.name;
// 在此处放置用户代码以初始化页面


await this.SetDdl_id_XzMajorInDiv();//查询区域
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
await this.BindGv_vMajorDirectionPaperRela();
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
 await this.BindGv_vMajorDirectionPaperRela();
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
const returnInt = await MajorDirectionPaperRela_DelRecordAsync(lngmId);
if (returnInt > 0)
{
//MajorDirectionPaperRela_ReFreshCache();
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
const objMajorDirectionPaperRelaEN = await MajorDirectionPaperRela_GetObjBymIdAsync(lngmId);
//console.log("完成SelectRecord!", objMajorDirectionPaperRelaEN);
Redirect("/Index/Main_vMajorDirectionPaperRela");
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
await this.BindGv_vMajorDirectionPaperRela();
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
const responseBindGv = await this.ExportExcel_vMajorDirectionPaperRela();
}

 /** 把所有的查询控件内容组合成一个条件串
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
 * @returns 条件串(strWhereCond)
 **/
 public async CombinevMajorDirectionPaperRelaCondition():Promise<string> 
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。

try
{
if ( this.id_XzMajor_q != "" && this.id_XzMajor_q != "0")
{
strWhereCond += Format(" And {0} = '{1}'", clsvMajorDirectionPaperRelaEN.con_id_XzMajor, this.id_XzMajor_q);
}
if ( this.majorDirectionName_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsvMajorDirectionPaperRelaEN.con_MajorDirectionName, this.majorDirectionName_q);
}
if ( this.paperTitle_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsvMajorDirectionPaperRelaEN.con_PaperTitle, this.paperTitle_q);
}
if (this.isQuotethesis_q == true)
{
strWhereCond += Format(" And {0} = '1'", clsvMajorDirectionPaperRelaEN.con_IsQuotethesis);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvMajorDirectionPaperRelaEN.con_IsQuotethesis);
}
}
catch(objException)
{
const strMsg:string = Format("(errid:WiTsCs0009)在组合查询条件(CombineMajorDirectionPaperRelaCondition)时出错!请联系管理员!{0}", objException);
throw strMsg;
}
return strWhereCond;
}

 /** 把所有的查询控件内容组合成一个条件串
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
 * @returns 条件串(strWhereCond)
 **/
 public async CombinevMajorDirectionPaperRelaConditionObj(): Promise<clsvMajorDirectionPaperRelaEN> 
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
const objvMajorDirectionPaperRela_Cond = new clsvMajorDirectionPaperRelaEN();
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
try
{
if ( this.id_XzMajor_q != "" && this.id_XzMajor_q != "0")
{
strWhereCond += Format(" And {0} = '{1}'", clsvMajorDirectionPaperRelaEN.con_id_XzMajor, this.id_XzMajor_q);
objvMajorDirectionPaperRela_Cond.SetCondFldValue(clsvMajorDirectionPaperRelaEN.con_id_XzMajor, this.id_XzMajor_q, "=");
}
if ( this.majorDirectionName_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsvMajorDirectionPaperRelaEN.con_MajorDirectionName, this.majorDirectionName_q);
objvMajorDirectionPaperRela_Cond.SetCondFldValue(clsvMajorDirectionPaperRelaEN.con_MajorDirectionName, this.majorDirectionName_q, "like");
}
if ( this.paperTitle_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsvMajorDirectionPaperRelaEN.con_PaperTitle, this.paperTitle_q);
objvMajorDirectionPaperRela_Cond.SetCondFldValue(clsvMajorDirectionPaperRelaEN.con_PaperTitle, this.paperTitle_q, "like");
}
if (this.isQuotethesis_q == true)
{
strWhereCond += Format(" And {0} = '1'", clsvMajorDirectionPaperRelaEN.con_IsQuotethesis);
objvMajorDirectionPaperRela_Cond.SetCondFldValue(clsvMajorDirectionPaperRelaEN.con_IsQuotethesis, true, "=");
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvMajorDirectionPaperRelaEN.con_IsQuotethesis);
objvMajorDirectionPaperRela_Cond.SetCondFldValue(clsvMajorDirectionPaperRelaEN.con_IsQuotethesis, false, "=");
}

}
catch(objException)
{
const strMsg:string = Format("(errid:WiTsCs0010)在组合查询条件对象(CombineMajorDirectionPaperRelaConditionObj)时出错!请联系管理员!{0}", objException);
throw strMsg;
}
objvMajorDirectionPaperRela_Cond.whereCond = strWhereCond;
return objvMajorDirectionPaperRela_Cond;
}

 /** 把所有的查询控件内容组合成一个条件串
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj4ExportExcel)
 * @returns 条件串(strWhereCond)
 **/
 public async CombinevMajorDirectionPaperRelaConditionObj4ExportExcel():Promise<clsvMajorDirectionPaperRelaEN> 
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
const objvMajorDirectionPaperRela_Cond = new clsvMajorDirectionPaperRelaENEx();
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
try
{
if ( this.id_XzMajor_q != "" && this.id_XzMajor_q != "0")
{
strWhereCond += Format(" And {0} = '{1}'", clsvMajorDirectionPaperRelaEN.con_id_XzMajor, this.id_XzMajor_q);
objvMajorDirectionPaperRela_Cond.SetCondFldValue(clsvMajorDirectionPaperRelaEN.con_id_XzMajor, this.id_XzMajor_q, "=");
}
if ( this.majorDirectionName_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsvMajorDirectionPaperRelaEN.con_MajorDirectionName, this.majorDirectionName_q);
objvMajorDirectionPaperRela_Cond.SetCondFldValue(clsvMajorDirectionPaperRelaEN.con_MajorDirectionName, this.majorDirectionName_q, "like");
}
if ( this.paperTitle_q != "")
{
strWhereCond += Format(" And {0} like '% {1}%'", clsvMajorDirectionPaperRelaEN.con_PaperTitle, this.paperTitle_q);
objvMajorDirectionPaperRela_Cond.SetCondFldValue(clsvMajorDirectionPaperRelaEN.con_PaperTitle, this.paperTitle_q, "like");
}
if (this.isQuotethesis_q == true)
{
strWhereCond += Format(" And {0} = '1'", clsvMajorDirectionPaperRelaEN.con_IsQuotethesis);
objvMajorDirectionPaperRela_Cond.SetCondFldValue(clsvMajorDirectionPaperRelaEN.con_IsQuotethesis, true, "=");
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvMajorDirectionPaperRelaEN.con_IsQuotethesis);
objvMajorDirectionPaperRela_Cond.SetCondFldValue(clsvMajorDirectionPaperRelaEN.con_IsQuotethesis, false, "=");
}
}
catch(objException)
{
const strMsg:string = Format("(errid:WiTsCs0013)在组合导出Excel条件对象(CombineMajorDirectionPaperRelaConditionObj4ExportExcel)时出错!请联系管理员!{0}", objException);
throw strMsg;
}
objvMajorDirectionPaperRela_Cond.whereCond = strWhereCond;
return objvMajorDirectionPaperRela_Cond;
}

 /** 显示vMajorDirectionPaperRela对象的所有属性值
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
 * @param divContainer:显示容器
 * @param arrMajorDirectionPaperRelaObjLst:需要绑定的对象列表
 **/
public async BindTab_vMajorDirectionPaperRela(divContainer: string, arrvMajorDirectionPaperRelaObjLst: Array<clsvMajorDirectionPaperRelaEN>) 
{
const strThisFuncName = this.BindTab_vMajorDirectionPaperRela.name;
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
fldName: clsvMajorDirectionPaperRelaEN.con_MajorDirectionENName,
sortBy: clsvMajorDirectionPaperRelaEN.con_MajorDirectionENName,
sortFun: SortFun,
getDataSource: "",
colHeader: "研究方向英文名",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 7,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: clsvMajorDirectionPaperRelaEN.con_MajorDirectionName,
sortBy: clsvMajorDirectionPaperRelaEN.con_MajorDirectionName,
sortFun: SortFun,
getDataSource: "",
colHeader: "研究方向名",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 8,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: clsvMajorDirectionPaperRelaEN.con_IsVisible,
sortBy: clsvMajorDirectionPaperRelaEN.con_IsVisible,
sortFun: SortFun,
getDataSource: "",
colHeader: "是否显示",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 10,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: clsvMajorDirectionPaperRelaEN.con_PaperTitle,
sortBy: clsvMajorDirectionPaperRelaEN.con_PaperTitle,
sortFun: SortFun,
getDataSource: "",
colHeader: "论文标题",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 11,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: clsvMajorDirectionPaperRelaEN.con_ResearchQuestion,
sortBy: clsvMajorDirectionPaperRelaEN.con_ResearchQuestion,
sortFun: SortFun,
getDataSource: "",
colHeader: "研究问题",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 16,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: clsvMajorDirectionPaperRelaEN.con_Keyword,
sortBy: clsvMajorDirectionPaperRelaEN.con_Keyword,
sortFun: SortFun,
getDataSource: "",
colHeader: "关键字",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 17,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: clsvMajorDirectionPaperRelaEN.con_LiteratureSources,
sortBy: clsvMajorDirectionPaperRelaEN.con_LiteratureSources,
sortFun: SortFun,
getDataSource: "",
colHeader: "文献来源",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 18,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: clsvMajorDirectionPaperRelaEN.con_LiteratureLink,
sortBy: clsvMajorDirectionPaperRelaEN.con_LiteratureLink,
sortFun: SortFun,
getDataSource: "",
colHeader: "文献链接",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 19,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: clsvMajorDirectionPaperRelaEN.con_UploadfileUrl,
sortBy: clsvMajorDirectionPaperRelaEN.con_UploadfileUrl,
sortFun: SortFun,
getDataSource: "",
colHeader: "文件地址",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 20,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: clsvMajorDirectionPaperRelaEN.con_IsQuotethesis,
sortBy: clsvMajorDirectionPaperRelaEN.con_IsQuotethesis,
sortFun: SortFun,
getDataSource: "",
colHeader: "是否引用论文",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 21,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: clsvMajorDirectionPaperRelaEN.con_Checker,
sortBy: clsvMajorDirectionPaperRelaEN.con_Checker,
sortFun: SortFun,
getDataSource: "",
colHeader: "审核人",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 22,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: clsvMajorDirectionPaperRelaEN.con_IsChecked,
sortBy: clsvMajorDirectionPaperRelaEN.con_IsChecked,
sortFun: SortFun,
getDataSource: "",
colHeader: "是否检查",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 23,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: clsvMajorDirectionPaperRelaEN.con_UpdDate,
sortBy: clsvMajorDirectionPaperRelaEN.con_UpdDate,
sortFun: SortFun,
getDataSource: "",
colHeader: "修改日期",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 27,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
{
fldName: clsvMajorDirectionPaperRelaEN.con_UpdUser,
sortBy: clsvMajorDirectionPaperRelaEN.con_UpdUser,
sortFun: SortFun,
getDataSource: "",
colHeader: "修改人",
text: "",
tdClass: "text-left",
columnType: "Label",
orderNum: 28,
funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}
},
];
await BindTab_V(o, arrvMajorDirectionPaperRelaObjLst, arrDataColumn,  clsvMajorDirectionPaperRelaEN.con_mId, this); 
this.objPager.recCount = this.recCount;
this.objPager.pageSize = this.pageSize;
this.objPager.ShowPagerV2(this, this.divName4Pager);
}

 /** 扩展字段值的函数映射
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ExtendFldFuncMap)
 * @param arrvMajorDirectionPaperRelaExObjLst:需要映射的对象列表
 * @param arrDataColumn:用于绑定表的数据列信息
 **/
public async ExtendFldFuncMap(arrvMajorDirectionPaperRelaExObjLst: Array<clsvMajorDirectionPaperRelaENEx>, arrDataColumn: Array<clsDataColumn>) {
const arrFldName = clsvMajorDirectionPaperRelaEN.AttributeName;
for (const objDataColumn of arrDataColumn) {
if (IsNullOrEmpty(objDataColumn.fldName) == true) continue;
if (arrFldName.indexOf(objDataColumn.fldName) > -1) continue;
for (const objInFor of arrvMajorDirectionPaperRelaExObjLst) {
await vMajorDirectionPaperRelaEx_FuncMapByFldName(objDataColumn.fldName, objInFor);
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
const responseBindGv = await this.BindGv_vMajorDirectionPaperRela();
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
public async BindGv_vMajorDirectionPaperRela() 
{
const strThisFuncName = this.BindGv_vMajorDirectionPaperRela.name;
if (MajorDirectionPaperRelaCRUD.sortvMajorDirectionPaperRelaBy == null)
{
const strMsg = Format("在显示列表时，排序字段(sortvMajorDirectionPaperRelaBy)为空，请检查！(In BindGv_vMajorDirectionPaperRela)");
console.error(strMsg);
alert(strMsg);
return;
}
const strListDiv = this.divName4DataList;
const strWhereCond = await this.CombinevMajorDirectionPaperRelaCondition();
let intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
 let arrvMajorDirectionPaperRelaObjLst: Array <clsvMajorDirectionPaperRelaEN> = [];
try
{
this.recCount = await vMajorDirectionPaperRela_GetRecCountByCondAsync(strWhereCond);
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
orderBy: MajorDirectionPaperRelaCRUD.sortvMajorDirectionPaperRelaBy,//如果该字段为空，就使用下面的排序函数
sortFun: (x, y) => { console.log(x,y);return 0;}
}
const responseObjLst = await vMajorDirectionPaperRela_GetObjLstByPagerAsync(objPagerPara).then((jsonData)=>{
arrvMajorDirectionPaperRelaObjLst = < Array<clsvMajorDirectionPaperRelaEN>>jsonData;
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
if (arrvMajorDirectionPaperRelaObjLst.length == 0)
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
await this.BindTab_vMajorDirectionPaperRela(strListDiv, arrvMajorDirectionPaperRelaObjLst);
//console.log("完成BindGv_vMajorDirectionPaperRela!");
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
public SortFun_ExportExcel(a:clsvMajorDirectionPaperRelaEN , b:clsvMajorDirectionPaperRelaEN): number 
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
const { sortFun, ascOrDesc4SortFun, sortBy } = GetSortBy(objAnchorElement, MajorDirectionPaperRelaCRUD.ascOrDesc4SortFun, MajorDirectionPaperRelaCRUD.sortvMajorDirectionPaperRelaBy, strSortExpress);
MajorDirectionPaperRelaCRUD.sortvMajorDirectionPaperRelaBy = sortBy;
MajorDirectionPaperRelaCRUD.ascOrDesc4SortFun = ascOrDesc4SortFun;
MajorDirectionPaperRelaCRUD.sortFun_Static = sortFun;
await this.BindGv_vMajorDirectionPaperRela();
}

 /** 复制记录
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CopyRecord)
 **/
public async CopyRecord(arrmId: Array<string>) {
const strThisFuncName = this.CopyRecord.name;
try
{
const arrMajorDirectionPaperRelaObjLst = await MajorDirectionPaperRela_GetObjLstBymIdLstAsync(arrmId);
//console.log('responseText=');
//console.log(responseText);
let intCount = 0;
for (const objInFor of arrMajorDirectionPaperRelaObjLst)
{
const returnBool = await MajorDirectionPaperRela_AddNewRecordAsync(objInFor);
//console.log('returnBool=');
//console.log(returnBool);
if (returnBool == true)
{
//MajorDirectionPaperRela_ReFreshCache();
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
const returnInt = await MajorDirectionPaperRela_DelMajorDirectionPaperRelasAsync(arrmId);
if (returnInt > 0)
{
//MajorDirectionPaperRela_ReFreshCache();
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
 * @param objMajorDirectionPaperRela:需要显示的对象
 **/
public ShowMajorDirectionPaperRelaObj(divContainer: string, objMajorDirectionPaperRela: clsMajorDirectionPaperRelaEN) 
{
const strThisFuncName = this.ShowMajorDirectionPaperRelaObj.name;
const o = document.getElementById(divContainer);
if (o == null)
{
alert(Format("{}不存在！",divContainer));
return;
}
const sstrKeys = GetObjKeys(objMajorDirectionPaperRela);
const ul: HTMLUListElement = document.createElement("ul");
for (const strKey of sstrKeys)
{
const strValue = objMajorDirectionPaperRela.GetFldValue(strKey);
const li: HTMLLIElement = document.createElement("li");
li.innerHTML = Format("{0}:{1}", strKey, strValue);
ul.appendChild(li);
}
o.appendChild(ul);
}

 /** 函数功能:从界面列表中获取第一个关键字的值
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetFirstKey)
 * @param pobjMajorDirectionPaperRelaEN:表实体类对象
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
 * 专业流水号 (Used In CombineCondition())
 **/
public  get id_XzMajor_q():string {
const strValue = GetSelectValueInDiv(this.divName4Query, "ddlid_XzMajor_q");
if (strValue == undefined) return "";
else if (strValue == "0") return "";
else return strValue;
}
 /**
 * 专业流水号 (Used In CombineCondition())
 **/
public  set id_XzMajor_q(value: string) {
SetSelectValueByIdInDiv(this.divName4Query, "ddlid_XzMajor_q", value);
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
 * 研究方向名 (Used In CombineCondition())
 **/
public  get majorDirectionName_q():string {
const strValue = GetInputValueInDiv(this.divName4Query, "txtMajorDirectionName_q");
if (strValue == undefined) return "";
else return strValue.toString();
}
 /**
 * 研究方向名 (Used In CombineCondition())
 **/
public  set majorDirectionName_q(value: string) {
 SetInputValueByIdInDiv(this.divName4Query, "txtMajorDirectionName_q", value);
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