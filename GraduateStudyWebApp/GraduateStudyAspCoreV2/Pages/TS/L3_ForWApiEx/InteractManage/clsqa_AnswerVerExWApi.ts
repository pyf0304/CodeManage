﻿
 /**
 * 类名:clsqa_AnswerVerExWApi
 * 表名:qa_AnswerVer(01120756)
 * 版本:2023.01.12.1(服务器:WIN-SRV103-116)
 * 日期:2023/01/12 16:16:11
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
 * 答疑回答历史V(qa_AnswerVer)
 * (AutoGCLib.WA_AccessEx4TypeScript:GeneCode)
* Created by pyf on 2023年01月12日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
//import $ from "jquery";
import { ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { qa_AnswerVer_GetObjLst_Cache } from "../../L3_ForWApi/InteractManage/clsqa_AnswerVerWApi.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { GetSortExpressInfo } from "../../PubFun/clsCommFunc4Web.js";
import { IsNullOrEmpty } from "../../PubFun/clsString.js";
import { clsqa_AnswerVerEN } from "../../L0_Entity/InteractManage/clsqa_AnswerVerEN.js";
import { GetObjKeys } from "../../PubFun/clsCommFunc4Web.js";
import { clsqa_AnswerVerENEx } from "../../L0_Entity/InteractManage/clsqa_AnswerVerENEx.js";
import { qa_AnswerVer_GetObjLstAsync } from "../../L3_ForWApi/InteractManage/clsqa_AnswerVerWApi.js";
import { qa_AnswerVer_SortFunByKey } from "../../L3_ForWApi/InteractManage/clsqa_AnswerVerWApi.js";
import { Format } from "../../PubFun/clsString.js";
import { qa_AnswerVer_FilterFunByKey } from "../../L3_ForWApi/InteractManage/clsqa_AnswerVerWApi.js";
import { clsSysPara4WebApi } from "../../PubConfig/clsSysPara4WebApi.js";
export const qa_AnswerVerEx_Controller = "qa_AnswerVerExApi";
export const qa_AnswerVerEx_ConstructorName = "qa_AnswerVerEx";

 /**
 * 获取WebApi的地址
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
 * @returns 返回当前文件中Web服务的地址
 **/
export function qa_AnswerVerEx_GetWebApiUrl(strController: string, strAction: string): string {
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
 * @param objqa_AnswerVerENS:源对象
 * @returns 目标对象=>clsqa_AnswerVerEN:objqa_AnswerVerENT
 **/
export function qa_AnswerVerEx_CopyToEx(objqa_AnswerVerENS:clsqa_AnswerVerEN ): clsqa_AnswerVerENEx
{
const strThisFuncName  = qa_AnswerVerEx_CopyToEx.name;
 const objqa_AnswerVerENT = new clsqa_AnswerVerENEx();
try
{
ObjectAssign(objqa_AnswerVerENT, objqa_AnswerVerENS);
 return objqa_AnswerVerENT;
}
catch (e)
{
const strMsg = Format("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, qa_AnswerVerEx_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
 return objqa_AnswerVerENT;
}
}

/**
 * 根据分页条件从缓存中获取分页对象列表，只获取一页.
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
 * @param objPagerPara:分页参数结构
 * @returns 对象列表
*/
export async function qa_AnswerVerEx_GetObjExLstByPager_Cache(objPagerPara: stuPagerPara ):Promise<Array<clsqa_AnswerVerENEx>> {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrqa_AnswerVerObjLst = await qa_AnswerVer_GetObjLst_Cache();
const arrqa_AnswerVerExObjLst = arrqa_AnswerVerObjLst.map(qa_AnswerVerEx_CopyToEx);
 const objSortInfo = GetSortExpressInfo(objPagerPara);
 if (IsNullOrEmpty(objSortInfo.SortFld) == false)
 {
 for (const objInFor of arrqa_AnswerVerExObjLst) {
 const conFuncMap = await qa_AnswerVerEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
 }
 }
if (arrqa_AnswerVerExObjLst.length == 0) return arrqa_AnswerVerExObjLst;
let arrqa_AnswerVer_Sel: Array < clsqa_AnswerVerENEx > = arrqa_AnswerVerExObjLst;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objqa_AnswerVer_Cond = new clsqa_AnswerVerENEx();
ObjectAssign(objqa_AnswerVer_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsqa_AnswerVerWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objqa_AnswerVer_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey).toString().length = Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.split(',');
arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrqa_AnswerVer_Sel.length == 0) return arrqa_AnswerVer_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.sort(qa_AnswerVerEx_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.sort(objPagerPara.sortFun);
}
arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.slice(intStart, intEnd);     
return arrqa_AnswerVer_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, qa_AnswerVerEx_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsqa_AnswerVerENEx>();
}

/**
 * 根据分页条件从缓存中获取分页对象列表，只获取一页.
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
 * @param objPagerPara:分页参数结构
 * @returns 对象列表
*/
export async function qa_AnswerVerEx_GetObjExLstByPagerAsync(objPagerPara: stuPagerPara):Promise<Array<clsqa_AnswerVerENEx>> {
const strThisFuncName = "GetObjExLstByPagerAsync";
const arrqa_AnswerVerObjLst = await qa_AnswerVer_GetObjLstAsync(objPagerPara.whereCond);
const arrqa_AnswerVerExObjLst = arrqa_AnswerVerObjLst.map(qa_AnswerVerEx_CopyToEx);
 const objSortInfo = GetSortExpressInfo(objPagerPara);
 if (IsNullOrEmpty(objSortInfo.SortFld) == false)
 {
 for (const objInFor of arrqa_AnswerVerExObjLst) {
 const conFuncMap = await qa_AnswerVerEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
 }
 }
if (arrqa_AnswerVerExObjLst.length == 0) return arrqa_AnswerVerExObjLst;
let arrqa_AnswerVer_Sel: Array < clsqa_AnswerVerENEx > = arrqa_AnswerVerExObjLst;
try {
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.sort(qa_AnswerVerEx_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.sort(objPagerPara.sortFun);
}
arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.slice(intStart, intEnd);     
return arrqa_AnswerVer_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, qa_AnswerVerEx_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsqa_AnswerVerENEx>();
}

/**
 * 排序函数。根据关键字字段的值进行比较
 * 作者:pyf
 * 日期:2023-01-12
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
 * @param a:比较的第1个对象
 * @param  b:比较的第1个对象
 * @returns 返回两个对象比较的结果
*/
export function qa_AnswerVerEx_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
        default:
return qa_AnswerVer_SortFunByKey(strKey, AscOrDesc);
 }
 }
  else
 {
switch (strKey)
{
        default:
return qa_AnswerVer_SortFunByKey(strKey, AscOrDesc);
 }
 }
}

/**
 * 根据扩展字段名去调用相应的映射函数
 * 作者:pyf
 * 日期:2023-01-12
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
 * @param strFldName:扩展字段名
 * @param  obj{0}Ex:需要转换的对象
 * @returns 针对扩展字段名对转换对象进行函数映射
*/
export function qa_AnswerVerEx_FuncMapByFldName(strFldName: string, objqa_AnswerVerEx: clsqa_AnswerVerENEx)
{
const strThisFuncName = qa_AnswerVerEx_FuncMapByFldName.name;
let strMsg = "";
//如果是本表中字段，不需要映射
const arrFldName = clsqa_AnswerVerEN.AttributeName;
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
 * 日期:2023-01-12
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
 * @param strKey:比较的关键字段名称
 * @param value:给定值
 * @returns 返回对象的字段值是否等于给定值
*/
export async function qa_AnswerVerEx_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
        default:
return qa_AnswerVer_FilterFunByKey(strKey, value);
 }
}
