﻿
 /**
 * 类名:clsqa_PaperExWApi
 * 表名:qa_Paper(01120643)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/05 01:04:16
 * 生成者:pyf
 * 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
 * 框架-层名:WA_访问扩展层(TS)(WA_AccessEx)
 * 编程语言:TypeScript
 * 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
   *      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 **/

 /**
 * 论文答疑表(qa_Paper)
 * (AutoGCLib.WA_AccessEx4TypeScript:GeneCode)
* Created by pyf on 2022年11月05日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
//import $ from "jquery";
import { ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { qa_Paper_GetObjLst_Cache } from "../../L3_ForWApi/InteractManage/clsqa_PaperWApi.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { GetSortExpressInfo } from "../../PubFun/clsCommFunc4Web.js";
import { IsNullOrEmpty } from "../../PubFun/clsString.js";
import { clsqa_PaperEN } from "../../L0_Entity/InteractManage/clsqa_PaperEN.js";
import { GetObjKeys } from "../../PubFun/clsCommFunc4Web.js";
import { clsqa_PaperENEx } from "../../L0_Entity/InteractManage/clsqa_PaperENEx.js";
import { qa_Paper_GetObjLstAsync } from "../../L3_ForWApi/InteractManage/clsqa_PaperWApi.js";
import { qa_Paper_SortFunByKey } from "../../L3_ForWApi/InteractManage/clsqa_PaperWApi.js";
import { Format } from "../../PubFun/clsString.js";
import { qa_Paper_FilterFunByKey } from "../../L3_ForWApi/InteractManage/clsqa_PaperWApi.js";
import { clsSysPara4WebApi } from "../../PubConfig/clsSysPara4WebApi.js";
export const qa_PaperEx_Controller = "qa_PaperExApi";
export const qa_PaperEx_ConstructorName = "qa_PaperEx";

 /**
 * 获取WebApi的地址
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
 * @returns 返回当前文件中Web服务的地址
 **/
export function qa_PaperEx_GetWebApiUrl(strController: string, strAction: string): string {
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
 * @param objqa_PaperENS:源对象
 * @returns 目标对象=>clsqa_PaperEN:objqa_PaperENT
 **/
export function qa_PaperEx_CopyToEx(objqa_PaperENS:clsqa_PaperEN ): clsqa_PaperENEx
{
const strThisFuncName  = qa_PaperEx_CopyToEx.name;
 const objqa_PaperENT = new clsqa_PaperENEx();
try
{
ObjectAssign(objqa_PaperENT, objqa_PaperENS);
 return objqa_PaperENT;
}
catch (e)
{
const strMsg = Format("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, qa_PaperEx_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
 return objqa_PaperENT;
}
}

/**
 * 根据分页条件从缓存中获取分页对象列表，只获取一页.
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
 * @param objPagerPara:分页参数结构
 * @returns 对象列表
*/
export async function qa_PaperEx_GetObjExLstByPager_Cache(objPagerPara: stuPagerPara , strid_CurrEduCls:string):Promise<Array<clsqa_PaperENEx>> {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrqa_PaperObjLst = await qa_Paper_GetObjLst_Cache(strid_CurrEduCls);
const arrqa_PaperExObjLst = arrqa_PaperObjLst.map(qa_PaperEx_CopyToEx);
 const objSortInfo = GetSortExpressInfo(objPagerPara);
 if (IsNullOrEmpty(objSortInfo.SortFld) == false)
 {
 for (const objInFor of arrqa_PaperExObjLst) {
 const conFuncMap = await qa_PaperEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
 }
 }
if (arrqa_PaperExObjLst.length == 0) return arrqa_PaperExObjLst;
let arrqa_Paper_Sel: Array < clsqa_PaperENEx > = arrqa_PaperExObjLst;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objqa_Paper_Cond = new clsqa_PaperENEx();
ObjectAssign(objqa_Paper_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsqa_PaperWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objqa_Paper_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.split(',');
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrqa_Paper_Sel.length == 0) return arrqa_Paper_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrqa_Paper_Sel = arrqa_Paper_Sel.sort(qa_PaperEx_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrqa_Paper_Sel = arrqa_Paper_Sel.sort(objPagerPara.sortFun);
}
arrqa_Paper_Sel = arrqa_Paper_Sel.slice(intStart, intEnd);     
return arrqa_Paper_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, qa_PaperEx_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsqa_PaperENEx>();
}

/**
 * 根据分页条件从缓存中获取分页对象列表，只获取一页.
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
 * @param objPagerPara:分页参数结构
 * @returns 对象列表
*/
export async function qa_PaperEx_GetObjExLstByPagerAsync(objPagerPara: stuPagerPara):Promise<Array<clsqa_PaperENEx>> {
const strThisFuncName = "GetObjExLstByPagerAsync";
const arrqa_PaperObjLst = await qa_Paper_GetObjLstAsync(objPagerPara.whereCond);
const arrqa_PaperExObjLst = arrqa_PaperObjLst.map(qa_PaperEx_CopyToEx);
 const objSortInfo = GetSortExpressInfo(objPagerPara);
 if (IsNullOrEmpty(objSortInfo.SortFld) == false)
 {
 for (const objInFor of arrqa_PaperExObjLst) {
 const conFuncMap = await qa_PaperEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
 }
 }
if (arrqa_PaperExObjLst.length == 0) return arrqa_PaperExObjLst;
let arrqa_Paper_Sel: Array < clsqa_PaperENEx > = arrqa_PaperExObjLst;
try {
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrqa_Paper_Sel = arrqa_Paper_Sel.sort(qa_PaperEx_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrqa_Paper_Sel = arrqa_Paper_Sel.sort(objPagerPara.sortFun);
}
arrqa_Paper_Sel = arrqa_Paper_Sel.slice(intStart, intEnd);     
return arrqa_Paper_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, qa_PaperEx_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsqa_PaperENEx>();
}

/**
 * 排序函数。根据关键字字段的值进行比较
 * 作者:pyf
 * 日期:2022-11-05
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
 * @param a:比较的第1个对象
 * @param  b:比较的第1个对象
 * @returns 返回两个对象比较的结果
*/
export function qa_PaperEx_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
        default:
return qa_Paper_SortFunByKey(strKey, AscOrDesc);
 }
 }
  else
 {
switch (strKey)
{
        default:
return qa_Paper_SortFunByKey(strKey, AscOrDesc);
 }
 }
}

/**
 * 根据扩展字段名去调用相应的映射函数
 * 作者:pyf
 * 日期:2022-11-05
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
 * @param strFldName:扩展字段名
 * @param  obj{0}Ex:需要转换的对象
 * @returns 针对扩展字段名对转换对象进行函数映射
*/
export function qa_PaperEx_FuncMapByFldName(strFldName: string, objqa_PaperEx: clsqa_PaperENEx)
{
const strThisFuncName = qa_PaperEx_FuncMapByFldName.name;
let strMsg = "";
//如果是本表中字段，不需要映射
const arrFldName = clsqa_PaperEN.AttributeName;
if (arrFldName.indexOf(strFldName) > -1) return;
//针对扩展字段进行映射
switch (strFldName)
{
        default:
    strMsg = Format("扩展字段:[{0}]在字段值函数映射中不存在！(in {1})", strFldName, strThisFuncName);
console.error(strMsg);
 }
}

/**
 * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
 * 作者:pyf
 * 日期:2022-11-05
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
 * @param strKey:比较的关键字段名称
 * @param value:给定值
 * @returns 返回对象的字段值是否等于给定值
*/
export async function qa_PaperEx_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
        default:
return qa_Paper_FilterFunByKey(strKey, value);
 }
}
