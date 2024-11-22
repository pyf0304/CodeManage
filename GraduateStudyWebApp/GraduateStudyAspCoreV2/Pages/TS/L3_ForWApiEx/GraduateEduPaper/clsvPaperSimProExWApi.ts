﻿
 /**
 * 类名:clsvPaperSimProExWApi
 * 表名:vPaperSimPro(01120944)
 * 版本:2023.01.09.1(服务器:WIN-SRV103-116)
 * 日期:2023/01/10 11:37:37
 * 生成者:pyf
 * 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:研培论文(GraduateEduPaper)
 * 框架-层名:WA_访问扩展层(TS)(WA_AccessEx)
 * 编程语言:TypeScript
 * 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
   *      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 **/

 /**
 * vPaperSimPro(vPaperSimPro)
 * (AutoGCLib.WA_AccessEx4TypeScript:GeneCode)
* Created by pyf on 2023年01月10日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
//import $ from "jquery";
import { BindDdl_ObjLstInDiv, BindDdl_ObjLstInDiv_V, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { vPaperSimPro_GetObjLst_Cache } from "../../L3_ForWApi/GraduateEduPaper/clsvPaperSimProWApi.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { GetSortExpressInfo } from "../../PubFun/clsCommFunc4Web.js";
import { IsNullOrEmpty } from "../../PubFun/clsString.js";
import { clsvPaperSimProEN } from "../../L0_Entity/GraduateEduPaper/clsvPaperSimProEN.js";
import { GetObjKeys } from "../../PubFun/clsCommFunc4Web.js";
import { clsvPaperSimProENEx } from "../../L0_Entity/GraduateEduPaper/clsvPaperSimProENEx.js";
import { vPaperSimPro_GetObjLstAsync } from "../../L3_ForWApi/GraduateEduPaper/clsvPaperSimProWApi.js";
import { vPaperSimPro_SortFunByKey } from "../../L3_ForWApi/GraduateEduPaper/clsvPaperSimProWApi.js";
import { Format } from "../../PubFun/clsString.js";
import { vPaperSimPro_FilterFunByKey } from "../../L3_ForWApi/GraduateEduPaper/clsvPaperSimProWApi.js";
import { clsSysPara4WebApi } from "../../PubConfig/clsSysPara4WebApi.js";
export const vPaperSimProEx_Controller = "vPaperSimProExApi";
export const vPaperSimProEx_ConstructorName = "vPaperSimProEx";

 /**
 * 获取WebApi的地址
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
 * @returns 返回当前文件中Web服务的地址
 **/
export function vPaperSimProEx_GetWebApiUrl(strController: string, strAction: string): string {
const strThisFuncName = "GetWebApiUrl";
let strServiceUrl:string;
let strCurrIPAddressAndPort = "";
if (clsSysPara4WebApi.bolIsLocalHost == false)
{
strCurrIPAddressAndPort = clsSysPara4WebApi.CurrIPAddressAndPort;
}
else
{
strCurrIPAddressAndPort = clsSysPara4WebApi.CurrIPAddressAndPort_Local;
}
if (IsNullOrEmpty(clsSysPara4WebApi.CurrPrx) == true)
{
strServiceUrl = Format("{0}/{1}/{2}", strCurrIPAddressAndPort, strController, strAction);
}
else
{
strServiceUrl = Format("{0}/{1}/{2}/{3}", strCurrIPAddressAndPort, clsSysPara4WebApi.CurrPrx, strController, strAction);
}
return strServiceUrl;
}

 /**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
 * @param objvPaperSimProENS:源对象
 * @returns 目标对象=>clsvPaperSimProEN:objvPaperSimProENT
 **/
export function vPaperSimProEx_CopyToEx(objvPaperSimProENS:clsvPaperSimProEN ): clsvPaperSimProENEx
{
const strThisFuncName  = vPaperSimProEx_CopyToEx.name;
 const objvPaperSimProENT = new clsvPaperSimProENEx();
try
{
ObjectAssign(objvPaperSimProENT, objvPaperSimProENS);
 return objvPaperSimProENT;
}
catch (e)
{
const strMsg = Format("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, vPaperSimProEx_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
 return objvPaperSimProENT;
}
}

/**
 * 根据分页条件从缓存中获取分页对象列表，只获取一页.
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
 * @param objPagerPara:分页参数结构
 * @returns 对象列表
*/
export async function vPaperSimProEx_GetObjExLstByPager_Cache(objPagerPara: stuPagerPara , strid_CurrEduCls:string):Promise<Array<clsvPaperSimProENEx>> {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrvPaperSimProObjLst = await vPaperSimPro_GetObjLst_Cache(strid_CurrEduCls);
const arrvPaperSimProExObjLst = arrvPaperSimProObjLst.map(vPaperSimProEx_CopyToEx);
 const objSortInfo = GetSortExpressInfo(objPagerPara);
 if (IsNullOrEmpty(objSortInfo.SortFld) == false)
 {
 for (const objInFor of arrvPaperSimProExObjLst) {
 const conFuncMap = await vPaperSimProEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
 }
 }
if (arrvPaperSimProExObjLst.length == 0) return arrvPaperSimProExObjLst;
let arrvPaperSimPro_Sel: Array < clsvPaperSimProENEx > = arrvPaperSimProExObjLst;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objvPaperSimPro_Cond = new clsvPaperSimProENEx();
ObjectAssign(objvPaperSimPro_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsvPaperSimProWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvPaperSimPro_Sel = arrvPaperSimPro_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvPaperSimPro_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvPaperSimPro_Sel = arrvPaperSimPro_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvPaperSimPro_Sel = arrvPaperSimPro_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.split(',');
arrvPaperSimPro_Sel = arrvPaperSimPro_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvPaperSimPro_Sel = arrvPaperSimPro_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvPaperSimPro_Sel = arrvPaperSimPro_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvPaperSimPro_Sel = arrvPaperSimPro_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvPaperSimPro_Sel = arrvPaperSimPro_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvPaperSimPro_Sel = arrvPaperSimPro_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvPaperSimPro_Sel = arrvPaperSimPro_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvPaperSimPro_Sel.length == 0) return arrvPaperSimPro_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrvPaperSimPro_Sel = arrvPaperSimPro_Sel.sort(vPaperSimProEx_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrvPaperSimPro_Sel = arrvPaperSimPro_Sel.sort(objPagerPara.sortFun);
}
arrvPaperSimPro_Sel = arrvPaperSimPro_Sel.slice(intStart, intEnd);     
return arrvPaperSimPro_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, vPaperSimProEx_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvPaperSimProENEx>();
}

/**
 * 根据分页条件从缓存中获取分页对象列表，只获取一页.
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
 * @param objPagerPara:分页参数结构
 * @returns 对象列表
*/
export async function vPaperSimProEx_GetObjExLstByPagerAsync(objPagerPara: stuPagerPara):Promise<Array<clsvPaperSimProENEx>> {
const strThisFuncName = "GetObjExLstByPagerAsync";
const arrvPaperSimProObjLst = await vPaperSimPro_GetObjLstAsync(objPagerPara.whereCond);
const arrvPaperSimProExObjLst = arrvPaperSimProObjLst.map(vPaperSimProEx_CopyToEx);
 const objSortInfo = GetSortExpressInfo(objPagerPara);
 if (IsNullOrEmpty(objSortInfo.SortFld) == false)
 {
 for (const objInFor of arrvPaperSimProExObjLst) {
 const conFuncMap = await vPaperSimProEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
 }
 }
if (arrvPaperSimProExObjLst.length == 0) return arrvPaperSimProExObjLst;
let arrvPaperSimPro_Sel: Array < clsvPaperSimProENEx > = arrvPaperSimProExObjLst;
try {
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrvPaperSimPro_Sel = arrvPaperSimPro_Sel.sort(vPaperSimProEx_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrvPaperSimPro_Sel = arrvPaperSimPro_Sel.sort(objPagerPara.sortFun);
}
arrvPaperSimPro_Sel = arrvPaperSimPro_Sel.slice(intStart, intEnd);     
return arrvPaperSimPro_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, vPaperSimProEx_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvPaperSimProENEx>();
}

/**
 * 排序函数。根据关键字字段的值进行比较
 * 作者:pyf
 * 日期:2023-01-10
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
 * @param a:比较的第1个对象
 * @param  b:比较的第1个对象
 * @returns 返回两个对象比较的结果
*/
export function vPaperSimProEx_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsvPaperSimProENEx.con_id_CurrEduCls:
return (a: clsvPaperSimProENEx, b: clsvPaperSimProENEx) => {
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
case clsvPaperSimProENEx.con_PaperTitle_Author:
return (a: clsvPaperSimProENEx, b: clsvPaperSimProENEx) => {
return a.paperTitle_Author.localeCompare(b.paperTitle_Author);
}
        default:
return vPaperSimPro_SortFunByKey(strKey, AscOrDesc);
 }
 }
  else
 {
switch (strKey)
{
case clsvPaperSimProENEx.con_id_CurrEduCls:
return (a: clsvPaperSimProENEx, b: clsvPaperSimProENEx) => {
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
case clsvPaperSimProENEx.con_PaperTitle_Author:
return (a: clsvPaperSimProENEx, b: clsvPaperSimProENEx) => {
return b.paperTitle_Author.localeCompare(a.paperTitle_Author);
}
        default:
return vPaperSimPro_SortFunByKey(strKey, AscOrDesc);
 }
 }
}

/**
 * 根据扩展字段名去调用相应的映射函数
 * 作者:pyf
 * 日期:2023-01-10
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
 * @param strFldName:扩展字段名
 * @param  obj{0}Ex:需要转换的对象
 * @returns 针对扩展字段名对转换对象进行函数映射
*/
export function vPaperSimProEx_FuncMapByFldName(strFldName: string, objvPaperSimProEx: clsvPaperSimProENEx)
{
const strThisFuncName = vPaperSimProEx_FuncMapByFldName.name;
let strMsg = "";
//如果是本表中字段，不需要映射
const arrFldName = clsvPaperSimProEN.AttributeName;
if (arrFldName.indexOf(strFldName) > -1) return;
//针对扩展字段进行映射
switch (strFldName)
{
    case clsvPaperSimProENEx.con_PaperTitle_Author:
        return vPaperSimProEx_FuncMap_PaperTitle_Author(objvPaperSimProEx);
        
        default:
    strMsg = Format("扩展字段:[{0}]在字段值函数映射中不存在！(in {1})", strFldName, strThisFuncName);
console.error(strMsg);
 }
}
/**
* 把一个扩展类的部分属性进行函数转换
* (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMap)
* @param objvPaperSimProS:源对象
**/
export async function vPaperSimProEx_FuncMap_PaperTitle_Author(objvPaperSimPro: clsvPaperSimProENEx) {
    const strThisFuncName = vPaperSimProEx_FuncMap_PaperTitle_Author.name;
    try {
        if (IsNullOrEmpty(objvPaperSimPro.paperTitle_Author) == true) {
            objvPaperSimPro.paperTitle_Author = Format("{0}_{1}", objvPaperSimPro.paperTitle, objvPaperSimPro.author);
        }
    }
    catch (e) {
        const strMsg = Format("(errid:Watl000183)函数映射表对象数据出错,{0}.(in {1}.{2})", e, vPaperSimProEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        alert(strMsg);
    }
}
/**
 * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
 * 作者:pyf
 * 日期:2023-01-10
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
 * @param strKey:比较的关键字段名称
 * @param value:给定值
 * @returns 返回对象的字段值是否等于给定值
*/
export async function vPaperSimProEx_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsvPaperSimProENEx.con_id_CurrEduCls:
return (obj: clsvPaperSimProENEx) => {
return obj.id_CurrEduCls === value;
}
case clsvPaperSimProENEx.con_PaperTitle_Author:
return (obj: clsvPaperSimProENEx) => {
return obj.paperTitle_Author === value;
}
        default:
return vPaperSimPro_FilterFunByKey(strKey, value);
 }
}

/// <summary>
/// 绑定基于Web的下拉框
/// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
/// </summary>
/// <param name = "objDDL">需要绑定当前表的下拉框</param>
export async function vPaperSimProEx_BindDdl_PaperIdByid_CurrEduClsInDiv_Cache(strDivName: string, strDdlName: string, strid_CurrEduCls: string) {

    var objDdl = document.getElementById(strDdlName);
    if (objDdl == null) {
        var strMsg = `下拉框：${strDdlName} 不存在！(In BindDdl_PaperIdInDiv_Cache)`;
        alert(strMsg);
        console.error(strMsg);
        throw (strMsg);
    }
    //为数据源于表的下拉框设置内容
    console.log("开始：BindDdl_PaperIdInDiv_Cache");
    const arrObjLst = await vPaperSimPro_GetObjLst_Cache(strid_CurrEduCls);
    const arrObjExLat = arrObjLst.map(vPaperSimProEx_CopyToEx);
    for (var objInFor of arrObjExLat) {
        vPaperSimProEx_FuncMapByFldName(clsvPaperSimProENEx.con_PaperTitle_Author, objInFor);
    }
    BindDdl_ObjLstInDiv_V(strDivName, strDdlName, arrObjExLat, clsvPaperSimProEN.con_PaperId, clsvPaperSimProENEx.con_PaperTitle_Author, "论文表");
}
