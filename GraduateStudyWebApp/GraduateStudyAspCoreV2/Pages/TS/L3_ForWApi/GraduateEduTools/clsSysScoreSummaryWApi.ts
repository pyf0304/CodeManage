﻿
 /**
 * 类名:clsSysScoreSummaryWApi
 * 表名:SysScoreSummary(01120628)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:47:41
 * 生成者:pyf
 * 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:研培设置(GraduateEduTools)
 * 框架-层名:WA_访问层(TS)(WA_Access)
 * 编程语言:TypeScript
 * 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
   *      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 **/

/**
 * 系统分数汇总表(SysScoreSummary)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2023年03月13日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { enumComparisonOp } from "../../PubFun/enumComparisonOp.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { clsSysScoreSummaryEN } from "../../L0_Entity/GraduateEduTools/clsSysScoreSummaryEN.js";
import { vSysScoreSummary_ReFreshThisCache } from "../../L3_ForWApi/GraduateEduTools/clsvSysScoreSummaryWApi.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { tzDataType } from "../../PubFun/clsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const sysScoreSummary_Controller = "SysScoreSummaryApi";
 export const sysScoreSummary_ConstructorName = "sysScoreSummary";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngmId:关键字
 * @returns 对象
 **/
export async function SysScoreSummary_GetObjBymIdAsync(lngmId: number): Promise<clsSysScoreSummaryEN|null>  
{
const strThisFuncName = "GetObjBymIdAsync";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In clsSysScoreSummaryWApi.GetObjBymIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjBymId";
const strUrl = GetWebApiUrl(sysScoreSummary_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"lngmId": lngmId,
}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObj = data.returnObj;
if (returnObj == null)
{
return null;
}
//console.log(returnObj);
const objSysScoreSummary = SysScoreSummary_GetObjFromJsonObj(returnObj);
return objSysScoreSummary;
}
else
{
console.error(data.errorMsg);
throw(data.errorMsg);
}
} catch (error: any) {
console.error(error);
if (error.statusText == undefined)
{
throw error;
}
if (error.statusText == "error")
{
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreSummary_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreSummary_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}

/**
 * 根据关键字获取相关对象, 从缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
 * @param lngmId:所给的关键字
 * @returns 对象
*/
export async function SysScoreSummary_GetObjBymId_Cache(lngmId:number,strid_CurrEduCls:string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjBymId_Cache";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In clsSysScoreSummaryWApi.GetObjBymId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
const arrSysScoreSummaryObjLst_Cache = await SysScoreSummary_GetObjLst_Cache(strid_CurrEduCls);
try
{
const arrSysScoreSummary_Sel: Array <clsSysScoreSummaryEN> = arrSysScoreSummaryObjLst_Cache.filter(x => 
 x.mId == lngmId );
let objSysScoreSummary: clsSysScoreSummaryEN;
if (arrSysScoreSummary_Sel.length > 0)
{
objSysScoreSummary = arrSysScoreSummary_Sel[0];
return objSysScoreSummary;
}
else
{
if (bolTryAsyncOnce == true)
{
const objSysScoreSummary_Const = await SysScoreSummary_GetObjBymIdAsync(lngmId);
if (objSysScoreSummary_Const != null)
{
SysScoreSummary_ReFreshThisCache(strid_CurrEduCls);
return objSysScoreSummary_Const;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, sysScoreSummary_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param lngmId:所给的关键字
 * @returns 对象
*/
export async function SysScoreSummary_GetObjBymId_localStorage(lngmId: number) {
const strThisFuncName = "GetObjBymId_localStorage";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In clsSysScoreSummaryWApi.GetObjBymId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
const strKey = Format("{0}_{1}", clsSysScoreSummaryEN._CurrTabName, lngmId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objSysScoreSummary_Cache: clsSysScoreSummaryEN = JSON.parse(strTempObj);
return objSysScoreSummary_Cache;
}
try
{
const objSysScoreSummary = await SysScoreSummary_GetObjBymIdAsync(lngmId);
if (objSysScoreSummary != null)
{
localStorage.setItem(strKey, JSON.stringify(objSysScoreSummary));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objSysScoreSummary;
}
return objSysScoreSummary;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, sysScoreSummary_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objSysScoreSummary:所给的对象
 * @returns 对象
*/
export async function SysScoreSummary_UpdateObjInLst_Cache(objSysScoreSummary: clsSysScoreSummaryEN,strid_CurrEduCls: string) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrSysScoreSummaryObjLst_Cache = await SysScoreSummary_GetObjLst_Cache(strid_CurrEduCls);
const obj = arrSysScoreSummaryObjLst_Cache.find(x => x.mId == objSysScoreSummary.mId && x.userId == objSysScoreSummary.userId);
if (obj != null)
{
objSysScoreSummary.mId = obj.mId;
ObjectAssign( obj, objSysScoreSummary);
}
else
{
arrSysScoreSummaryObjLst_Cache.push(objSysScoreSummary);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, sysScoreSummary_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
}
/*该表没有名称字段，不能生成此函数！*/

/**
 * 映射函数。根据表映射把输入字段值，映射成输出字段值
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
 * @param strInFldName:输入字段名
 * @param strOutFldName:输出字段名
 * @param strInValue:输入字段值
 @param strid_CurrEduCls:缓存的分类字段
 * @returns 返回一个输出字段值
*/
export async function SysScoreSummary_func(strInFldName:string , strOutFldName:string , strInValue:string 
, strid_CurrEduCls_C: string)
{
//const strThisFuncName = "func";

if (IsNullOrEmpty(strid_CurrEduCls_C) == true)
{
  const strMsg = Format("参数:[strid_CurrEduCls_C]不能为空！(In clsSysScoreSummaryWApi.func)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_CurrEduCls_C.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsSysScoreSummaryWApi.func)", strid_CurrEduCls_C.length);
console.error(strMsg);
throw (strMsg);
}

if (strInFldName != clsSysScoreSummaryEN.con_mId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsSysScoreSummaryEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strOutFldName, clsSysScoreSummaryEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const lngmId = Number(strInValue);
if (lngmId == 0)
{
return "";
}
const objSysScoreSummary = await SysScoreSummary_GetObjBymId_Cache(lngmId , strid_CurrEduCls_C);
if (objSysScoreSummary == null) return "";
if (objSysScoreSummary.GetFldValue(strOutFldName) == null) return "";
return objSysScoreSummary.GetFldValue(strOutFldName).toString();
}

/**
 * 排序函数。根据关键字字段的值进行比较
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
 * @param a:比较的第1个对象
 * @param  b:比较的第1个对象
 * @returns 返回两个对象比较的结果
*/
export function SysScoreSummary_SortFun_Defa(a:clsSysScoreSummaryEN , b:clsSysScoreSummaryEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.mId-b.mId;
}
/**
 * 排序函数。根据表对象中随机两个字段的值进行比较
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
 * @param  a:比较的第1个对象
 * @param  b:比较的第1个对象
 * @returns 返回两个对象比较的结果
*/
export function SysScoreSummary_SortFun_Defa_2Fld(a:clsSysScoreSummaryEN , b:clsSysScoreSummaryEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.userId == b.userId) return a.schoolYear.localeCompare(b.schoolYear);
else return a.userId.localeCompare(b.userId);
}

/**
 * 排序函数。根据关键字字段的值进行比较
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
 * @param a:比较的第1个对象
 * @param  b:比较的第1个对象
 * @returns 返回两个对象比较的结果
*/
export function SysScoreSummary_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsSysScoreSummaryEN.con_mId:
return (a: clsSysScoreSummaryEN, b: clsSysScoreSummaryEN) => {
return a.mId-b.mId;
}
case clsSysScoreSummaryEN.con_UserId:
return (a: clsSysScoreSummaryEN, b: clsSysScoreSummaryEN) => {
return a.userId.localeCompare(b.userId);
}
case clsSysScoreSummaryEN.con_SchoolYear:
return (a: clsSysScoreSummaryEN, b: clsSysScoreSummaryEN) => {
if (a.schoolYear == null) return -1;
if (b.schoolYear == null) return 1;
return a.schoolYear.localeCompare(b.schoolYear);
}
case clsSysScoreSummaryEN.con_UpdDate:
return (a: clsSysScoreSummaryEN, b: clsSysScoreSummaryEN) => {
if (a.updDate == null) return -1;
if (b.updDate == null) return 1;
return a.updDate.localeCompare(b.updDate);
}
case clsSysScoreSummaryEN.con_Memo:
return (a: clsSysScoreSummaryEN, b: clsSysScoreSummaryEN) => {
if (a.memo == null) return -1;
if (b.memo == null) return 1;
return a.memo.localeCompare(b.memo);
}
case clsSysScoreSummaryEN.con_ScoreTypeId:
return (a: clsSysScoreSummaryEN, b: clsSysScoreSummaryEN) => {
if (a.scoreTypeId == null) return -1;
if (b.scoreTypeId == null) return 1;
return a.scoreTypeId.localeCompare(b.scoreTypeId);
}
case clsSysScoreSummaryEN.con_UpdUser:
return (a: clsSysScoreSummaryEN, b: clsSysScoreSummaryEN) => {
if (a.updUser == null) return -1;
if (b.updUser == null) return 1;
return a.updUser.localeCompare(b.updUser);
}
case clsSysScoreSummaryEN.con_Score:
return (a: clsSysScoreSummaryEN, b: clsSysScoreSummaryEN) => {
return a.score-b.score;
}
case clsSysScoreSummaryEN.con_id_CurrEduCls:
return (a: clsSysScoreSummaryEN, b: clsSysScoreSummaryEN) => {
if (a.id_CurrEduCls == null) return -1;
if (b.id_CurrEduCls == null) return 1;
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
case clsSysScoreSummaryEN.con_IsSubmit:
return (a: clsSysScoreSummaryEN, b: clsSysScoreSummaryEN) => {
if (a.isSubmit == true) return 1;
else return -1
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[SysScoreSummary]中不存在！(in ${ sysScoreSummary_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsSysScoreSummaryEN.con_mId:
return (a: clsSysScoreSummaryEN, b: clsSysScoreSummaryEN) => {
return b.mId-a.mId;
}
case clsSysScoreSummaryEN.con_UserId:
return (a: clsSysScoreSummaryEN, b: clsSysScoreSummaryEN) => {
return b.userId.localeCompare(a.userId);
}
case clsSysScoreSummaryEN.con_SchoolYear:
return (a: clsSysScoreSummaryEN, b: clsSysScoreSummaryEN) => {
if (b.schoolYear == null) return -1;
if (a.schoolYear == null) return 1;
return b.schoolYear.localeCompare(a.schoolYear);
}
case clsSysScoreSummaryEN.con_UpdDate:
return (a: clsSysScoreSummaryEN, b: clsSysScoreSummaryEN) => {
if (b.updDate == null) return -1;
if (a.updDate == null) return 1;
return b.updDate.localeCompare(a.updDate);
}
case clsSysScoreSummaryEN.con_Memo:
return (a: clsSysScoreSummaryEN, b: clsSysScoreSummaryEN) => {
if (b.memo == null) return -1;
if (a.memo == null) return 1;
return b.memo.localeCompare(a.memo);
}
case clsSysScoreSummaryEN.con_ScoreTypeId:
return (a: clsSysScoreSummaryEN, b: clsSysScoreSummaryEN) => {
if (b.scoreTypeId == null) return -1;
if (a.scoreTypeId == null) return 1;
return b.scoreTypeId.localeCompare(a.scoreTypeId);
}
case clsSysScoreSummaryEN.con_UpdUser:
return (a: clsSysScoreSummaryEN, b: clsSysScoreSummaryEN) => {
if (b.updUser == null) return -1;
if (a.updUser == null) return 1;
return b.updUser.localeCompare(a.updUser);
}
case clsSysScoreSummaryEN.con_Score:
return (a: clsSysScoreSummaryEN, b: clsSysScoreSummaryEN) => {
return b.score-a.score;
}
case clsSysScoreSummaryEN.con_id_CurrEduCls:
return (a: clsSysScoreSummaryEN, b: clsSysScoreSummaryEN) => {
if (b.id_CurrEduCls == null) return -1;
if (a.id_CurrEduCls == null) return 1;
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
case clsSysScoreSummaryEN.con_IsSubmit:
return (a: clsSysScoreSummaryEN, b: clsSysScoreSummaryEN) => {
if (b.isSubmit == true) return 1;
else return -1
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[SysScoreSummary]中不存在！(in ${ sysScoreSummary_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
}

/**
 * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
 * @param strKey:比较的关键字段名称
 * @param value:给定值
 * @returns 返回对象的字段值是否等于给定值
*/
export async function SysScoreSummary_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsSysScoreSummaryEN.con_mId:
return (obj: clsSysScoreSummaryEN) => {
return obj.mId === value;
}
case clsSysScoreSummaryEN.con_UserId:
return (obj: clsSysScoreSummaryEN) => {
return obj.userId === value;
}
case clsSysScoreSummaryEN.con_SchoolYear:
return (obj: clsSysScoreSummaryEN) => {
return obj.schoolYear === value;
}
case clsSysScoreSummaryEN.con_UpdDate:
return (obj: clsSysScoreSummaryEN) => {
return obj.updDate === value;
}
case clsSysScoreSummaryEN.con_Memo:
return (obj: clsSysScoreSummaryEN) => {
return obj.memo === value;
}
case clsSysScoreSummaryEN.con_ScoreTypeId:
return (obj: clsSysScoreSummaryEN) => {
return obj.scoreTypeId === value;
}
case clsSysScoreSummaryEN.con_UpdUser:
return (obj: clsSysScoreSummaryEN) => {
return obj.updUser === value;
}
case clsSysScoreSummaryEN.con_Score:
return (obj: clsSysScoreSummaryEN) => {
return obj.score === value;
}
case clsSysScoreSummaryEN.con_id_CurrEduCls:
return (obj: clsSysScoreSummaryEN) => {
return obj.id_CurrEduCls === value;
}
case clsSysScoreSummaryEN.con_IsSubmit:
return (obj: clsSysScoreSummaryEN) => {
return obj.isSubmit === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[SysScoreSummary]中不存在！(in ${ sysScoreSummary_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
}

/**
 * 映射函数。根据表映射把输入字段值，映射成输出字段值
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_funcKey)
 * @param strInFldName:输入字段名
 * @param strInValue:输入字段值
 * @param strComparisonOp:比较操作符
 @param strid_CurrEduCls:缓存的分类字段
 * @returns 返回一个关键字值列表
*/
export async function SysScoreSummary_funcKey(strInFldName:string, strInValue: any, strComparisonOp:string, strid_CurrEduCls_C: string): Promise<Array<number>>
{
//const strThisFuncName = "funcKey";

if (IsNullOrEmpty(strid_CurrEduCls_C) == true)
{
  const strMsg = Format("参数:[strid_CurrEduCls_C]不能为空！(In clsSysScoreSummaryWApi.funcKey)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_CurrEduCls_C.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsSysScoreSummaryWApi.funcKey)", strid_CurrEduCls_C.length);
console.error(strMsg);
throw (strMsg);
}

if (strInFldName == clsSysScoreSummaryEN.con_mId)
{
const strMsg = Format("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (Number(strInValue) == 0)
{
return [];
}
const arrSysScoreSummary = await SysScoreSummary_GetObjLst_Cache(strid_CurrEduCls_C);
if (arrSysScoreSummary == null) return [];
let arrSysScoreSummary_Sel = arrSysScoreSummary;
const strType = typeof(strInValue);
switch (strType)
{
case "string":
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01: // " = "
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
break;
case enumComparisonOp.Like_03:
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
break;
case enumComparisonOp.In_04:
const arrValues = strInValue.split(',');
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
break;
}
break;
case "boolean":
if (strInValue == null) return [];
if (strComparisonOp == enumComparisonOp.Equal_01)
{
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
}
break;
case "number":
if (Number(strInValue) == 0) return [];
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01:
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
break;
case enumComparisonOp.NotEqual_02:
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
break;
case enumComparisonOp.NotLessThan_05://" >= ":
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
break;
case enumComparisonOp.NotGreaterThan_06://" <= ":
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
case enumComparisonOp.GreaterThan_07://" > ":
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
break;
case enumComparisonOp.LessThan_08://" < ":
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
}
break;
}
if (arrSysScoreSummary_Sel.length == 0) return [];
return arrSysScoreSummary_Sel.map(x=>x.mId);
}

 /**
 * 根据条件获取满足条件的第一条记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
 * @param strWhereCond:条件
 * @returns 返回的第一条记录的关键字值
 **/
export async function SysScoreSummary_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(sysScoreSummary_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strWhereCond": strWhereCond}
});
const data = response.data;
if (data.errorId == 0)
{
return data.returnStr;
}
else
{
console.error(data.errorMsg);
throw(data.errorMsg);
}
} catch (error: any) {
console.error(error);
if (error.statusText == undefined)
{
throw error;
}
if (error.statusText == "error")
{
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreSummary_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreSummary_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}

/**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
 * @param strWhereCond:条件
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回的第一条记录的关键字值
*/
export async function SysScoreSummary_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(sysScoreSummary_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strWhereCond": strWhereCond}
});
const data = response.data;
cb(data);
} catch (error: any) {
console.error(error);
if (error.statusText == undefined)
{
throw error;
}
if (error.statusText == "error")
{
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreSummary_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreSummary_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}

 /**
 * 根据条件获取满足条件的第一条记录对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
 * @param strWhereCond:条件
 * @returns 第一条记录对象
 **/
export async function SysScoreSummary_GetFirstObjAsync(strWhereCond: string): Promise<clsSysScoreSummaryEN|null>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(sysScoreSummary_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strWhereCond": strWhereCond}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObj = data.returnObj;
if (returnObj == null)
{
return null;
}
//console.log(returnObj);
const objSysScoreSummary = SysScoreSummary_GetObjFromJsonObj(returnObj);
return objSysScoreSummary;
}
else
{
console.error(data.errorMsg);
throw(data.errorMsg);
}
} catch (error: any) {
console.error(error);
if (error.statusText == undefined)
{
throw error;
}
if (error.statusText == "error")
{
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreSummary_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreSummary_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function SysScoreSummary_GetObjLst_ClientCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
if (IsNullOrEmpty(clsSysScoreSummaryEN.WhereFormat) == false)
{
strWhereCond = Format(clsSysScoreSummaryEN.WhereFormat, strid_CurrEduCls);
}
else
{
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
}
const strKey = Format("{0}_{1}", clsSysScoreSummaryEN._CurrTabName, strid_CurrEduCls);
if (IsNullOrEmpty(clsSysScoreSummaryEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsSysScoreSummaryEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrSysScoreSummaryExObjLst_Cache: Array<clsSysScoreSummaryEN> = CacheHelper.Get(strKey);
const arrSysScoreSummaryObjLst_T = SysScoreSummary_GetObjLstByJSONObjLst(arrSysScoreSummaryExObjLst_Cache);
return arrSysScoreSummaryObjLst_T;
}
try
{
const arrSysScoreSummaryExObjLst = await SysScoreSummary_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrSysScoreSummaryExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrSysScoreSummaryExObjLst.length);
console.log(strInfo);
return arrSysScoreSummaryExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, sysScoreSummary_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function SysScoreSummary_GetObjLst_localStorage(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
if (IsNullOrEmpty(clsSysScoreSummaryEN.WhereFormat) == false)
{
strWhereCond = Format(clsSysScoreSummaryEN.WhereFormat, strid_CurrEduCls);
}
else
{
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
}
const strKey = Format("{0}_{1}", clsSysScoreSummaryEN._CurrTabName, strid_CurrEduCls);
if (IsNullOrEmpty(clsSysScoreSummaryEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsSysScoreSummaryEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrSysScoreSummaryExObjLst_Cache: Array<clsSysScoreSummaryEN> = JSON.parse(strTempObjLst);
const arrSysScoreSummaryObjLst_T = SysScoreSummary_GetObjLstByJSONObjLst(arrSysScoreSummaryExObjLst_Cache);
return arrSysScoreSummaryObjLst_T;
}
try
{
const arrSysScoreSummaryExObjLst = await SysScoreSummary_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrSysScoreSummaryExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrSysScoreSummaryExObjLst.length);
console.log(strInfo);
return arrSysScoreSummaryExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, sysScoreSummary_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function SysScoreSummary_GetObjLst_localStorage_PureCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsSysScoreSummaryEN._CurrTabName, strid_CurrEduCls);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrSysScoreSummaryObjLst_Cache: Array<clsSysScoreSummaryEN> = JSON.parse(strTempObjLst);
return arrSysScoreSummaryObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function SysScoreSummary_GetObjLstAsync(strWhereCond: string): Promise<Array<clsSysScoreSummaryEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(sysScoreSummary_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strWhereCond": strWhereCond}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sysScoreSummary_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = SysScoreSummary_GetObjLstByJSONObjLst(returnObjLst);
return (arrObjLst);
}
else
{
console.error(data.errorMsg);
throw (data.errorMsg);
}
} catch (error: any) {
console.error(error);
if (error.statusText == undefined)
{
throw error;
}
if (error.statusText == "error")
{
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreSummary_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreSummary_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}

 /**
 * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function SysScoreSummary_GetObjLst_sessionStorage(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
if (IsNullOrEmpty(clsSysScoreSummaryEN.WhereFormat) == false)
{
strWhereCond = Format(clsSysScoreSummaryEN.WhereFormat, strid_CurrEduCls);
}
else
{
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
}
const strKey = Format("{0}_{1}", clsSysScoreSummaryEN._CurrTabName, strid_CurrEduCls);
if (IsNullOrEmpty(clsSysScoreSummaryEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsSysScoreSummaryEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrSysScoreSummaryExObjLst_Cache: Array<clsSysScoreSummaryEN> = JSON.parse(strTempObjLst);
const arrSysScoreSummaryObjLst_T = SysScoreSummary_GetObjLstByJSONObjLst(arrSysScoreSummaryExObjLst_Cache);
return arrSysScoreSummaryObjLst_T;
}
try
{
const arrSysScoreSummaryExObjLst = await SysScoreSummary_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrSysScoreSummaryExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrSysScoreSummaryExObjLst.length);
console.log(strInfo);
return arrSysScoreSummaryExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, sysScoreSummary_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function SysScoreSummary_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsSysScoreSummaryEN._CurrTabName, strid_CurrEduCls);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrSysScoreSummaryObjLst_Cache: Array<clsSysScoreSummaryEN> = JSON.parse(strTempObjLst);
return arrSysScoreSummaryObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function SysScoreSummary_GetObjLst_Cache(strid_CurrEduCls: string): Promise<Array<clsSysScoreSummaryEN>>
{
//const strThisFuncName = "GetObjLst_Cache";

if (IsNullOrEmpty(strid_CurrEduCls) == true)
{
const strMsg = Format("缓存分类变量:[id_CurrEduCls]不能为空！(in clsSysScoreSummaryWApi.SysScoreSummary_GetObjLst_Cache() )");
console.error(strMsg);
throw (strMsg);
}
if (strid_CurrEduCls.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(in clsSysScoreSummaryWApi.SysScoreSummary_GetObjLst_Cache() )", strid_CurrEduCls.length);
console.error(strMsg);
throw (strMsg);
}
let arrSysScoreSummaryObjLst_Cache;
switch (clsSysScoreSummaryEN.CacheModeId)
{
case "04"://sessionStorage
arrSysScoreSummaryObjLst_Cache = await SysScoreSummary_GetObjLst_sessionStorage(strid_CurrEduCls);
break;
case "03"://localStorage
arrSysScoreSummaryObjLst_Cache = await SysScoreSummary_GetObjLst_localStorage(strid_CurrEduCls);
break;
case "02"://ClientCache
arrSysScoreSummaryObjLst_Cache = await SysScoreSummary_GetObjLst_ClientCache(strid_CurrEduCls);
break;
default:
arrSysScoreSummaryObjLst_Cache = await SysScoreSummary_GetObjLst_ClientCache(strid_CurrEduCls);
break;
}
const arrSysScoreSummaryObjLst = SysScoreSummary_GetObjLstByJSONObjLst(arrSysScoreSummaryObjLst_Cache);
return arrSysScoreSummaryObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function SysScoreSummary_GetObjLst_PureCache(strid_CurrEduCls: string)
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrSysScoreSummaryObjLst_Cache;
switch (clsSysScoreSummaryEN.CacheModeId)
{
case "04"://sessionStorage
arrSysScoreSummaryObjLst_Cache = await SysScoreSummary_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls);
break;
case "03"://localStorage
arrSysScoreSummaryObjLst_Cache = await SysScoreSummary_GetObjLst_localStorage_PureCache(strid_CurrEduCls);
break;
case "02"://ClientCache
arrSysScoreSummaryObjLst_Cache = null;
break;
default:
arrSysScoreSummaryObjLst_Cache = null;
break;
}
return arrSysScoreSummaryObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objlngmId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function SysScoreSummary_GetSubObjLst_Cache(objSysScoreSummary_Cond: clsSysScoreSummaryEN,strid_CurrEduCls: string) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrSysScoreSummaryObjLst_Cache = await SysScoreSummary_GetObjLst_Cache(strid_CurrEduCls);
let arrSysScoreSummary_Sel: Array < clsSysScoreSummaryEN > = arrSysScoreSummaryObjLst_Cache;
if (objSysScoreSummary_Cond.sf_FldComparisonOp == null || objSysScoreSummary_Cond.sf_FldComparisonOp == "") return arrSysScoreSummary_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objSysScoreSummary_Cond.sf_FldComparisonOp);
//console.log("clsSysScoreSummaryWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objSysScoreSummary_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objSysScoreSummary_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrSysScoreSummary_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objSysScoreSummary_Cond), sysScoreSummary_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsSysScoreSummaryEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrmId:关键字列表
 * @returns 对象列表
 **/
export async function SysScoreSummary_GetObjLstBymIdLstAsync(arrmId: Array<string>): Promise<Array<clsSysScoreSummaryEN>>  
{
const strThisFuncName = "GetObjLstBymIdLstAsync";
const strAction = "GetObjLstBymIdLst";
const strUrl = GetWebApiUrl(sysScoreSummary_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrmId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sysScoreSummary_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = SysScoreSummary_GetObjLstByJSONObjLst(returnObjLst);
return arrObjLst;
}
else
{
console.error(data.errorMsg);
throw(data.errorMsg);
}
} catch (error: any) {
console.error(error);
if (error.statusText == undefined)
{
throw error;
}
if (error.statusText == "error")
{
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreSummary_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreSummary_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}

/**
 * 根据关键字列表获取相关对象列表, 从缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
 * @param arrlngmIdLst:关键字列表
 * @returns 对象列表
*/
export async function SysScoreSummary_GetObjLstBymIdLst_Cache(arrmIdLst: Array<number>,strid_CurrEduCls: string) {
const strThisFuncName = "GetObjLstBymIdLst_Cache";
try
{
const arrSysScoreSummaryObjLst_Cache = await SysScoreSummary_GetObjLst_Cache(strid_CurrEduCls);
const arrSysScoreSummary_Sel: Array <clsSysScoreSummaryEN> = arrSysScoreSummaryObjLst_Cache.filter(x => arrmIdLst.indexOf(x.mId)>-1);
return arrSysScoreSummary_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrmIdLst.join(","), sysScoreSummary_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function SysScoreSummary_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsSysScoreSummaryEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(sysScoreSummary_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sysScoreSummary_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = SysScoreSummary_GetObjLstByJSONObjLst(returnObjLst);
return (arrObjLst);
}
else
{
console.error(data.errorMsg);
throw(data.errorMsg);
}
} catch (error: any) {
console.error(error);
if (error.statusText == undefined)
{
throw error;
}
if (error.statusText == "error")
{
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreSummary_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreSummary_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}

 /**
 * 根据范围条件获取相应的记录对象列表，获取某范围的记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
 * @param objRangePara:根据范围获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function SysScoreSummary_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsSysScoreSummaryEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(sysScoreSummary_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sysScoreSummary_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = SysScoreSummary_GetObjLstByJSONObjLst(returnObjLst);
return arrObjLst;
}
else
{
console.error(data.errorMsg);
throw(data.errorMsg);
}
} catch (error: any) {
console.error(error);
if (error.statusText == undefined)
{
throw error;
}
if (error.statusText == "error")
{
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreSummary_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreSummary_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}

/**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRange)
 * @param intMinNum:最小记录号
 * @param intMaxNum:最大记录号
 * @param strWhereCond:给定条件
 * @param strOrderBy:排序方式
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 获取的相应记录对象列表
*/
export async function SysScoreSummary_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(sysScoreSummary_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"intMinNum": intMinNum,
"intMaxNum": intMaxNum,
"strWhereCond": strWhereCond,
"strOrderBy": strOrderBy,
}
});
const data = response.data;
cb(data);
} catch (error: any) {
console.error(error);
if (error.statusText == undefined)
{
throw error;
}
if (error.statusText == "error")
{
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreSummary_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreSummary_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}

/**
 * 根据分页条件从缓存中获取分页对象列表，只获取一页.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
 * @param objPagerPara:分页参数结构
 * @returns 对象列表
*/
export async function SysScoreSummary_GetObjLstByPager_Cache(objPagerPara: stuPagerPara,strid_CurrEduCls: string) {
const strThisFuncName = "GetObjLstByPager_Cache";
if (objPagerPara.pageIndex == 0) return new Array<clsSysScoreSummaryEN>();
const arrSysScoreSummaryObjLst_Cache = await SysScoreSummary_GetObjLst_Cache(strid_CurrEduCls);
if (arrSysScoreSummaryObjLst_Cache.length == 0) return arrSysScoreSummaryObjLst_Cache;
let arrSysScoreSummary_Sel = arrSysScoreSummaryObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objSysScoreSummary_Cond = new clsSysScoreSummaryEN();
ObjectAssign(objSysScoreSummary_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsSysScoreSummaryWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objSysScoreSummary_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrSysScoreSummary_Sel.length == 0) return arrSysScoreSummary_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.sort(SysScoreSummary_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.sort(objPagerPara.sortFun);
}
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.slice(intStart, intEnd);     
return arrSysScoreSummary_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, sysScoreSummary_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsSysScoreSummaryEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function SysScoreSummary_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsSysScoreSummaryEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
if (objPagerPara.pageIndex == 0) return new Array<clsSysScoreSummaryEN>();
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(sysScoreSummary_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sysScoreSummary_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = SysScoreSummary_GetObjLstByJSONObjLst(returnObjLst);
return arrObjLst;
}
else
{
console.error(data.errorMsg);
throw(data.errorMsg);
}
} catch (error: any) {
console.error(error);
if (error.statusText == undefined)
{
throw error;
}
if (error.statusText == "error")
{
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreSummary_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreSummary_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}

 /**
 * 调用WebApi来删除记录，根据关键字来删除记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
 * @param lngmId:关键字
 * @returns 获取删除的结果
 **/
export async function SysScoreSummary_DelRecordAsync(lngmId: number): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(sysScoreSummary_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, lngmId);
try
{
const response = await axios.delete(strUrl);
const data = response.data;
if (data.errorId == 0)
{
return data.returnInt;
}
else
{
console.error(data.errorMsg);
throw(data.errorMsg);
}
} catch (error: any) {
console.error(error);
if (error.statusText == undefined)
{
throw error;
}
if (error.statusText == "error")
{
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreSummary_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreSummary_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}

 /**
 * 根据关键字列表删除记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
 * @param arrmId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function SysScoreSummary_DelSysScoreSummarysAsync(arrmId: Array<string>): Promise<number> 
{
const strThisFuncName = "DelSysScoreSummarysAsync";
const strAction = "DelSysScoreSummarys";
const strUrl = GetWebApiUrl(sysScoreSummary_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrmId);
const data = response.data;
if (data.errorId == 0)
{
return data.returnInt;
}
else
{
console.error(data.errorMsg);
throw data.errorMsg;
}
} catch (error: any) {
console.error(error);
if (error.statusText == undefined)
{
throw error;
}
if (error.statusText == "error")
{
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreSummary_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreSummary_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}

 /**
 * 根据条件删除记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
 * @returns 实际删除记录的个数
 **/
export async function SysScoreSummary_DelSysScoreSummarysByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "DelSysScoreSummarysByCondAsync";
const strAction = "DelSysScoreSummarysByCond";
const strUrl = GetWebApiUrl(sysScoreSummary_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strWhereCond": strWhereCond}
});
const data = response.data;
if (data.errorId == 0)
{
return data.returnInt;
}
else
{
console.error(data.errorMsg);
throw (data.errorMsg);
}
} catch (error: any) {
console.error(error);
if (error.statusText == undefined)
{
throw error;
}
if (error.statusText == "error")
{
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreSummary_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreSummary_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}

 /**
 * 调用WebApi来添加记录，数据传递使用JSON串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
 * @param objSysScoreSummaryEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function SysScoreSummary_AddNewRecordAsync(objSysScoreSummaryEN: clsSysScoreSummaryEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objSysScoreSummaryEN);
const strUrl = GetWebApiUrl(sysScoreSummary_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSysScoreSummaryEN);
const data = response.data;
if (data.errorId == 0)
{
return data.returnBool;
}
else
{
console.error(data.errorMsg);
throw(data.errorMsg);
}
} catch (error: any) {
console.error(error);
if (error.statusText == undefined)
{
throw error;
}
if (error.statusText == "error")
{
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreSummary_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreSummary_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}
/* 数据类型不是字符型，不可以最大关键字的方式添加记录。*/

 /**
 * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
 * @param objSysScoreSummaryEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function SysScoreSummary_AddNewRecordWithReturnKeyAsync(objSysScoreSummaryEN: clsSysScoreSummaryEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(sysScoreSummary_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSysScoreSummaryEN);
const data = response.data;
if (data.errorId == 0)
{
return data.returnStr;
}
else
{
console.error(data.errorMsg);
throw(data.errorMsg);
}
} catch (error: any) {
console.error(error);
if (error.statusText == undefined)
{
throw error;
}
if (error.statusText == "error")
{
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreSummary_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreSummary_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}

/**
 * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
 * @param objSysScoreSummaryEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function SysScoreSummary_AddNewRecordWithReturnKey(objSysScoreSummaryEN: clsSysScoreSummaryEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objSysScoreSummaryEN.mId === null || objSysScoreSummaryEN.mId === 0)
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(sysScoreSummary_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSysScoreSummaryEN);
const data = response.data;
cb(data);
} catch (error: any) {
console.error(error);
if (error.statusText == undefined)
{
throw error;
}
if (error.statusText == "error")
{
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreSummary_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreSummary_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}

 /**
 * 调用WebApi来修改记录，数据传递使用JSON串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
 * @param objSysScoreSummaryEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function SysScoreSummary_UpdateRecordAsync(objSysScoreSummaryEN: clsSysScoreSummaryEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objSysScoreSummaryEN.sfUpdFldSetStr === undefined || objSysScoreSummaryEN.sfUpdFldSetStr === null || objSysScoreSummaryEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objSysScoreSummaryEN.mId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(sysScoreSummary_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSysScoreSummaryEN);
const data = response.data;
if (data.errorId == 0)
{
return data.returnBool;
}
else
{
console.error(data.errorMsg);
throw(data.errorMsg);
}
} catch (error: any) {
console.error(error);
if (error.statusText == undefined)
{
throw error;
}
if (error.statusText == "error")
{
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreSummary_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreSummary_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}

 /**
 * 根据条件来修改记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
 * @param objSysScoreSummaryEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function SysScoreSummary_UpdateWithConditionAsync(objSysScoreSummaryEN: clsSysScoreSummaryEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objSysScoreSummaryEN.sfUpdFldSetStr === undefined || objSysScoreSummaryEN.sfUpdFldSetStr === null || objSysScoreSummaryEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objSysScoreSummaryEN.mId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(sysScoreSummary_Controller, strAction);
objSysScoreSummaryEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objSysScoreSummaryEN);
const data = response.data;
if (data.errorId == 0)
{
return data.returnBool;
}
else
{
console.error(data.errorMsg);
throw(data.errorMsg);
}
} catch (error: any) {
console.error(error);
if (error.statusText == undefined)
{
throw error;
}
if (error.statusText == "error")
{
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreSummary_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreSummary_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
 * @param objlngmId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function SysScoreSummary_IsExistRecord_Cache(objSysScoreSummary_Cond: clsSysScoreSummaryEN,strid_CurrEduCls: string) {
const strThisFuncName = "IsExistRecord_Cache";
const arrSysScoreSummaryObjLst_Cache = await SysScoreSummary_GetObjLst_Cache(strid_CurrEduCls);
if (arrSysScoreSummaryObjLst_Cache == null) return false;
let arrSysScoreSummary_Sel: Array < clsSysScoreSummaryEN > = arrSysScoreSummaryObjLst_Cache;
if (objSysScoreSummary_Cond.sf_FldComparisonOp == null || objSysScoreSummary_Cond.sf_FldComparisonOp == "") return arrSysScoreSummary_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objSysScoreSummary_Cond.sf_FldComparisonOp);
//console.log("clsSysScoreSummaryWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objSysScoreSummary_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objSysScoreSummary_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrSysScoreSummary_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objSysScoreSummary_Cond), sysScoreSummary_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return false;
}

 /**
 * 根据条件获取是否存在相应的记录？
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
 * @param strWhereCond:条件
 * @returns 是否存在记录？
 **/
export async function SysScoreSummary_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(sysScoreSummary_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strWhereCond": strWhereCond}
});
const data = response.data;
if (data.errorId == 0)
{
return data.returnBool;
}
else
{
console.error(data.errorMsg);
throw(data.errorMsg);
}
} catch (error: any) {
console.error(error);
if (error.statusText == undefined)
{
throw error;
}
if (error.statusText == "error")
{
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreSummary_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreSummary_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}

/**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
 * @param lngmId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function SysScoreSummary_IsExist(lngmId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(sysScoreSummary_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"mId": lngmId,
}
});
const data = response.data;
cb(data);
} catch (error: any) {
console.error(error);
if (error.statusText == undefined)
{
throw error;
}
if (error.statusText == "error")
{
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreSummary_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreSummary_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}

/**
 * 根据关键字判断是否存在记录, 从本地缓存中判断.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
 * @param lngmId:所给的关键字
 * @returns 对象
*/
export async function SysScoreSummary_IsExist_Cache(lngmId:number,strid_CurrEduCls:string) {
const strThisFuncName = "IsExist_Cache";
const arrSysScoreSummaryObjLst_Cache = await SysScoreSummary_GetObjLst_Cache(strid_CurrEduCls);
if (arrSysScoreSummaryObjLst_Cache == null) return false;
try
{
const arrSysScoreSummary_Sel: Array <clsSysScoreSummaryEN> = arrSysScoreSummaryObjLst_Cache.filter(x => x.mId == lngmId);
if (arrSysScoreSummary_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e)
{
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngmId, sysScoreSummary_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param lngmId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function SysScoreSummary_IsExistAsync(lngmId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(sysScoreSummary_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "lngmId": lngmId }
});
const data = response.data;
if (data.errorId == 0)
{
return (data.returnBool);
}
else
{
console.error(data.errorMsg);
throw(data.errorMsg);
}
} catch (error: any) {
console.error(error);
if (error.statusText == undefined)
{
throw error;
}
if (error.statusText == "error")
{
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreSummary_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreSummary_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}

 /**
 * 获取某一条件的记录数
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
 * @param strWhereCond:条件
 * @returns 获取某一条件的记录数
 **/
export async function SysScoreSummary_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(sysScoreSummary_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strWhereCond": strWhereCond}
});
const data = response.data;
if (data.errorId == 0)
{
return data.returnInt;
}
else
{
console.error(data.errorMsg);
throw(data.errorMsg);
}
} catch (error: any) {
console.error(error);
if (error.statusText == undefined)
{
throw error;
}
if (error.statusText == "error")
{
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreSummary_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreSummary_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}

/**
 * 根据条件对象, 从缓存的对象列表中获取记录数.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
 * @param objSysScoreSummary_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function SysScoreSummary_GetRecCountByCond_Cache(objSysScoreSummary_Cond: clsSysScoreSummaryEN,strid_CurrEduCls: string) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrSysScoreSummaryObjLst_Cache = await SysScoreSummary_GetObjLst_Cache(strid_CurrEduCls);
if (arrSysScoreSummaryObjLst_Cache == null) return 0;
let arrSysScoreSummary_Sel: Array < clsSysScoreSummaryEN > = arrSysScoreSummaryObjLst_Cache;
if (objSysScoreSummary_Cond.sf_FldComparisonOp == null || objSysScoreSummary_Cond.sf_FldComparisonOp == "") return arrSysScoreSummary_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objSysScoreSummary_Cond.sf_FldComparisonOp);
//console.log("clsSysScoreSummaryWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objSysScoreSummary_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objSysScoreSummary_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrSysScoreSummary_Sel = arrSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrSysScoreSummary_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objSysScoreSummary_Cond), sysScoreSummary_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return 0;
}
/*该表的关键字类型不是字符型自增，不需要生成获取最大关键字函数！*/
/*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/

/**
 * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
 * @param mapParam:参数列表
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 获取当前表关键字值的最大值
*/
export async function SysScoreSummary_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(sysScoreSummary_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strPrefix": strPrefix}
});
const data = response.data;
cb(data);
} catch (error: any) {
console.error(error);
if (error.statusText == undefined)
{
throw error;
}
if (error.statusText == "error")
{
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreSummary_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreSummary_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}

/**
 * 获取WebApi的地址
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
 * @returns 返回当前文件中Web服务的地址
*/
export function SysScoreSummary_GetWebApiUrl(strController: string, strAction: string): string {
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
 * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
 **/
export function SysScoreSummary_ReFreshCache(strid_CurrEduCls: string):void
{
const strThisFuncName = "ReFreshCache";

if (IsNullOrEmpty(strid_CurrEduCls) == true)
{
  const strMsg = Format("参数:[strid_CurrEduCls]不能为空！(In clsSysScoreSummaryWApi.clsSysScoreSummaryWApi.ReFreshCache)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_CurrEduCls.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(clsSysScoreSummaryWApi.clsSysScoreSummaryWApi.ReFreshCache)", strid_CurrEduCls.length);
console.error(strMsg);
throw (strMsg);
}

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = Format("{0}_{1}", clsSysScoreSummaryEN._CurrTabName, strid_CurrEduCls);
switch (clsSysScoreSummaryEN.CacheModeId)
{
case "04"://sessionStorage
sessionStorage.removeItem(strKey);
break;
case "03"://localStorage
localStorage.removeItem(strKey);
break;
case "02"://ClientCache
CacheHelper.Remove(strKey);
break;
default:
CacheHelper.Remove(strKey);
break;
}
vSysScoreSummary_ReFreshThisCache(strid_CurrEduCls);
}

 /**
 * 刷新本类中的缓存.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
 **/
export function SysScoreSummary_ReFreshThisCache(strid_CurrEduCls: string):void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = Format("{0}_{1}", clsSysScoreSummaryEN._CurrTabName, strid_CurrEduCls);
switch (clsSysScoreSummaryEN.CacheModeId)
{
case "04"://sessionStorage
sessionStorage.removeItem(strKey);
break;
case "03"://localStorage
localStorage.removeItem(strKey);
break;
case "02"://ClientCache
CacheHelper.Remove(strKey);
break;
default:
CacheHelper.Remove(strKey);
break;
}
const strMsg = Format("刷新缓存成功！");
console.trace(strMsg);
}
else
{
const strMsg = Format("刷新缓存已经关闭。");
console.trace(strMsg);
}
}
/* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/

/**
 * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function SysScoreSummary_CheckPropertyNew(pobjSysScoreSummaryEN: clsSysScoreSummaryEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjSysScoreSummaryEN.userId) === true )
{
 throw new Error("(errid:Watl000058)字段[用户ID]不能为空(In 系统分数汇总表)!(clsSysScoreSummaryBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjSysScoreSummaryEN.userId) == false && GetStrLen(pobjSysScoreSummaryEN.userId) > 18)
{
 throw new Error("(errid:Watl000059)字段[用户ID(userId)]的长度不能超过18(In 系统分数汇总表(SysScoreSummary))!值:$(pobjSysScoreSummaryEN.userId)(clsSysScoreSummaryBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysScoreSummaryEN.schoolYear) == false && GetStrLen(pobjSysScoreSummaryEN.schoolYear) > 10)
{
 throw new Error("(errid:Watl000059)字段[学年(schoolYear)]的长度不能超过10(In 系统分数汇总表(SysScoreSummary))!值:$(pobjSysScoreSummaryEN.schoolYear)(clsSysScoreSummaryBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysScoreSummaryEN.updDate) == false && GetStrLen(pobjSysScoreSummaryEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 系统分数汇总表(SysScoreSummary))!值:$(pobjSysScoreSummaryEN.updDate)(clsSysScoreSummaryBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysScoreSummaryEN.memo) == false && GetStrLen(pobjSysScoreSummaryEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 系统分数汇总表(SysScoreSummary))!值:$(pobjSysScoreSummaryEN.memo)(clsSysScoreSummaryBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysScoreSummaryEN.scoreTypeId) == false && GetStrLen(pobjSysScoreSummaryEN.scoreTypeId) > 4)
{
 throw new Error("(errid:Watl000059)字段[分数类型Id(scoreTypeId)]的长度不能超过4(In 系统分数汇总表(SysScoreSummary))!值:$(pobjSysScoreSummaryEN.scoreTypeId)(clsSysScoreSummaryBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysScoreSummaryEN.updUser) == false && GetStrLen(pobjSysScoreSummaryEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 系统分数汇总表(SysScoreSummary))!值:$(pobjSysScoreSummaryEN.updUser)(clsSysScoreSummaryBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysScoreSummaryEN.id_CurrEduCls) == false && GetStrLen(pobjSysScoreSummaryEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 系统分数汇总表(SysScoreSummary))!值:$(pobjSysScoreSummaryEN.id_CurrEduCls)(clsSysScoreSummaryBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null != pobjSysScoreSummaryEN.mId && undefined !== pobjSysScoreSummaryEN.mId && tzDataType.isNumber(pobjSysScoreSummaryEN.mId) === false)
{
 throw new Error("(errid:Watl000060)字段[mId(mId)]的值:[$(pobjSysScoreSummaryEN.mId)], 非法，应该为数值型(In 系统分数汇总表(SysScoreSummary))!(clsSysScoreSummaryBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysScoreSummaryEN.userId) == false && undefined !== pobjSysScoreSummaryEN.userId && tzDataType.isString(pobjSysScoreSummaryEN.userId) === false)
{
 throw new Error("(errid:Watl000060)字段[用户ID(userId)]的值:[$(pobjSysScoreSummaryEN.userId)], 非法，应该为字符型(In 系统分数汇总表(SysScoreSummary))!(clsSysScoreSummaryBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysScoreSummaryEN.schoolYear) == false && undefined !== pobjSysScoreSummaryEN.schoolYear && tzDataType.isString(pobjSysScoreSummaryEN.schoolYear) === false)
{
 throw new Error("(errid:Watl000060)字段[学年(schoolYear)]的值:[$(pobjSysScoreSummaryEN.schoolYear)], 非法，应该为字符型(In 系统分数汇总表(SysScoreSummary))!(clsSysScoreSummaryBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysScoreSummaryEN.updDate) == false && undefined !== pobjSysScoreSummaryEN.updDate && tzDataType.isString(pobjSysScoreSummaryEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjSysScoreSummaryEN.updDate)], 非法，应该为字符型(In 系统分数汇总表(SysScoreSummary))!(clsSysScoreSummaryBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysScoreSummaryEN.memo) == false && undefined !== pobjSysScoreSummaryEN.memo && tzDataType.isString(pobjSysScoreSummaryEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjSysScoreSummaryEN.memo)], 非法，应该为字符型(In 系统分数汇总表(SysScoreSummary))!(clsSysScoreSummaryBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysScoreSummaryEN.scoreTypeId) == false && undefined !== pobjSysScoreSummaryEN.scoreTypeId && tzDataType.isString(pobjSysScoreSummaryEN.scoreTypeId) === false)
{
 throw new Error("(errid:Watl000060)字段[分数类型Id(scoreTypeId)]的值:[$(pobjSysScoreSummaryEN.scoreTypeId)], 非法，应该为字符型(In 系统分数汇总表(SysScoreSummary))!(clsSysScoreSummaryBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysScoreSummaryEN.updUser) == false && undefined !== pobjSysScoreSummaryEN.updUser && tzDataType.isString(pobjSysScoreSummaryEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjSysScoreSummaryEN.updUser)], 非法，应该为字符型(In 系统分数汇总表(SysScoreSummary))!(clsSysScoreSummaryBL:CheckPropertyNew)");
}
if (null != pobjSysScoreSummaryEN.score && undefined !== pobjSysScoreSummaryEN.score && tzDataType.isNumber(pobjSysScoreSummaryEN.score) === false)
{
 throw new Error("(errid:Watl000060)字段[评分(score)]的值:[$(pobjSysScoreSummaryEN.score)], 非法，应该为数值型(In 系统分数汇总表(SysScoreSummary))!(clsSysScoreSummaryBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysScoreSummaryEN.id_CurrEduCls) == false && undefined !== pobjSysScoreSummaryEN.id_CurrEduCls && tzDataType.isString(pobjSysScoreSummaryEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjSysScoreSummaryEN.id_CurrEduCls)], 非法，应该为字符型(In 系统分数汇总表(SysScoreSummary))!(clsSysScoreSummaryBL:CheckPropertyNew)");
}
if (null != pobjSysScoreSummaryEN.isSubmit && undefined !== pobjSysScoreSummaryEN.isSubmit && tzDataType.isBoolean(pobjSysScoreSummaryEN.isSubmit) === false)
{
 throw new Error("(errid:Watl000060)字段[是否提交(isSubmit)]的值:[$(pobjSysScoreSummaryEN.isSubmit)], 非法，应该为布尔型(In 系统分数汇总表(SysScoreSummary))!(clsSysScoreSummaryBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjSysScoreSummaryEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function SysScoreSummary_CheckProperty4Update (pobjSysScoreSummaryEN: clsSysScoreSummaryEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjSysScoreSummaryEN.userId) == false && GetStrLen(pobjSysScoreSummaryEN.userId) > 18)
{
 throw new Error("(errid:Watl000062)字段[用户ID(userId)]的长度不能超过18(In 系统分数汇总表(SysScoreSummary))!值:$(pobjSysScoreSummaryEN.userId)(clsSysScoreSummaryBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysScoreSummaryEN.schoolYear) == false && GetStrLen(pobjSysScoreSummaryEN.schoolYear) > 10)
{
 throw new Error("(errid:Watl000062)字段[学年(schoolYear)]的长度不能超过10(In 系统分数汇总表(SysScoreSummary))!值:$(pobjSysScoreSummaryEN.schoolYear)(clsSysScoreSummaryBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysScoreSummaryEN.updDate) == false && GetStrLen(pobjSysScoreSummaryEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 系统分数汇总表(SysScoreSummary))!值:$(pobjSysScoreSummaryEN.updDate)(clsSysScoreSummaryBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysScoreSummaryEN.memo) == false && GetStrLen(pobjSysScoreSummaryEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 系统分数汇总表(SysScoreSummary))!值:$(pobjSysScoreSummaryEN.memo)(clsSysScoreSummaryBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysScoreSummaryEN.scoreTypeId) == false && GetStrLen(pobjSysScoreSummaryEN.scoreTypeId) > 4)
{
 throw new Error("(errid:Watl000062)字段[分数类型Id(scoreTypeId)]的长度不能超过4(In 系统分数汇总表(SysScoreSummary))!值:$(pobjSysScoreSummaryEN.scoreTypeId)(clsSysScoreSummaryBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysScoreSummaryEN.updUser) == false && GetStrLen(pobjSysScoreSummaryEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 系统分数汇总表(SysScoreSummary))!值:$(pobjSysScoreSummaryEN.updUser)(clsSysScoreSummaryBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysScoreSummaryEN.id_CurrEduCls) == false && GetStrLen(pobjSysScoreSummaryEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 系统分数汇总表(SysScoreSummary))!值:$(pobjSysScoreSummaryEN.id_CurrEduCls)(clsSysScoreSummaryBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null != pobjSysScoreSummaryEN.mId && undefined !== pobjSysScoreSummaryEN.mId && tzDataType.isNumber(pobjSysScoreSummaryEN.mId) === false)
{
 throw new Error("(errid:Watl000063)字段[mId(mId)]的值:[$(pobjSysScoreSummaryEN.mId)], 非法，应该为数值型(In 系统分数汇总表(SysScoreSummary))!(clsSysScoreSummaryBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysScoreSummaryEN.userId) == false && undefined !== pobjSysScoreSummaryEN.userId && tzDataType.isString(pobjSysScoreSummaryEN.userId) === false)
{
 throw new Error("(errid:Watl000063)字段[用户ID(userId)]的值:[$(pobjSysScoreSummaryEN.userId)], 非法，应该为字符型(In 系统分数汇总表(SysScoreSummary))!(clsSysScoreSummaryBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysScoreSummaryEN.schoolYear) == false && undefined !== pobjSysScoreSummaryEN.schoolYear && tzDataType.isString(pobjSysScoreSummaryEN.schoolYear) === false)
{
 throw new Error("(errid:Watl000063)字段[学年(schoolYear)]的值:[$(pobjSysScoreSummaryEN.schoolYear)], 非法，应该为字符型(In 系统分数汇总表(SysScoreSummary))!(clsSysScoreSummaryBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysScoreSummaryEN.updDate) == false && undefined !== pobjSysScoreSummaryEN.updDate && tzDataType.isString(pobjSysScoreSummaryEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjSysScoreSummaryEN.updDate)], 非法，应该为字符型(In 系统分数汇总表(SysScoreSummary))!(clsSysScoreSummaryBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysScoreSummaryEN.memo) == false && undefined !== pobjSysScoreSummaryEN.memo && tzDataType.isString(pobjSysScoreSummaryEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjSysScoreSummaryEN.memo)], 非法，应该为字符型(In 系统分数汇总表(SysScoreSummary))!(clsSysScoreSummaryBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysScoreSummaryEN.scoreTypeId) == false && undefined !== pobjSysScoreSummaryEN.scoreTypeId && tzDataType.isString(pobjSysScoreSummaryEN.scoreTypeId) === false)
{
 throw new Error("(errid:Watl000063)字段[分数类型Id(scoreTypeId)]的值:[$(pobjSysScoreSummaryEN.scoreTypeId)], 非法，应该为字符型(In 系统分数汇总表(SysScoreSummary))!(clsSysScoreSummaryBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysScoreSummaryEN.updUser) == false && undefined !== pobjSysScoreSummaryEN.updUser && tzDataType.isString(pobjSysScoreSummaryEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjSysScoreSummaryEN.updUser)], 非法，应该为字符型(In 系统分数汇总表(SysScoreSummary))!(clsSysScoreSummaryBL:CheckProperty4Update)");
}
if (null != pobjSysScoreSummaryEN.score && undefined !== pobjSysScoreSummaryEN.score && tzDataType.isNumber(pobjSysScoreSummaryEN.score) === false)
{
 throw new Error("(errid:Watl000063)字段[评分(score)]的值:[$(pobjSysScoreSummaryEN.score)], 非法，应该为数值型(In 系统分数汇总表(SysScoreSummary))!(clsSysScoreSummaryBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysScoreSummaryEN.id_CurrEduCls) == false && undefined !== pobjSysScoreSummaryEN.id_CurrEduCls && tzDataType.isString(pobjSysScoreSummaryEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjSysScoreSummaryEN.id_CurrEduCls)], 非法，应该为字符型(In 系统分数汇总表(SysScoreSummary))!(clsSysScoreSummaryBL:CheckProperty4Update)");
}
if (null != pobjSysScoreSummaryEN.isSubmit && undefined !== pobjSysScoreSummaryEN.isSubmit && tzDataType.isBoolean(pobjSysScoreSummaryEN.isSubmit) === false)
{
 throw new Error("(errid:Watl000063)字段[是否提交(isSubmit)]的值:[$(pobjSysScoreSummaryEN.isSubmit)], 非法，应该为布尔型(In 系统分数汇总表(SysScoreSummary))!(clsSysScoreSummaryBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjSysScoreSummaryEN.mId 
 || pobjSysScoreSummaryEN.mId != null && pobjSysScoreSummaryEN.mId.toString()  ===  "")
{
 throw new Error("(errid:Watl000064)字段[mId]不能为空(In 系统分数汇总表)!(clsSysScoreSummaryBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjSysScoreSummaryEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function SysScoreSummary_GetJSONStrByObj (pobjSysScoreSummaryEN: clsSysScoreSummaryEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjSysScoreSummaryEN.sfUpdFldSetStr = pobjSysScoreSummaryEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjSysScoreSummaryEN);
}
catch(objException)
{
const strEx = GetExceptionStr(objException);
myShowErrorMsg(strEx);
}
if (strJson == undefined) return "";
else return strJson;
}

/**
 * 把一个JSON串转化为一个对象列表
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象列表
*/
export function SysScoreSummary_GetObjLstByJSONStr (strJSON: string): Array<clsSysScoreSummaryEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrSysScoreSummaryObjLst = new Array<clsSysScoreSummaryEN>();
if (strJSON === "")
{
return arrSysScoreSummaryObjLst;
}
try
{
arrSysScoreSummaryObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrSysScoreSummaryObjLst;
}
return arrSysScoreSummaryObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrSysScoreSummaryObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function SysScoreSummary_GetObjLstByJSONObjLst (arrSysScoreSummaryObjLstS: Array<clsSysScoreSummaryEN>): Array<clsSysScoreSummaryEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrSysScoreSummaryObjLst = new Array<clsSysScoreSummaryEN>();
for (const objInFor of arrSysScoreSummaryObjLstS) {
const obj1 = SysScoreSummary_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrSysScoreSummaryObjLst.push(obj1);
}
return arrSysScoreSummaryObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function SysScoreSummary_GetObjByJSONStr (strJSON: string): clsSysScoreSummaryEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjSysScoreSummaryEN = new clsSysScoreSummaryEN();
if (strJSON === "")
{
return pobjSysScoreSummaryEN;
}
try
{
pobjSysScoreSummaryEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjSysScoreSummaryEN;
}
return pobjSysScoreSummaryEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function SysScoreSummary_GetCombineCondition(objSysScoreSummary_Cond: clsSysScoreSummaryEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objSysScoreSummary_Cond.dicFldComparisonOp, clsSysScoreSummaryEN.con_mId) == true)
{
const strComparisonOp_mId:string = objSysScoreSummary_Cond.dicFldComparisonOp[clsSysScoreSummaryEN.con_mId];
strWhereCond += Format(" And {0} {2} {1}", clsSysScoreSummaryEN.con_mId, objSysScoreSummary_Cond.mId, strComparisonOp_mId);
}
if (Object.prototype.hasOwnProperty.call(objSysScoreSummary_Cond.dicFldComparisonOp, clsSysScoreSummaryEN.con_UserId) == true)
{
const strComparisonOp_UserId:string = objSysScoreSummary_Cond.dicFldComparisonOp[clsSysScoreSummaryEN.con_UserId];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysScoreSummaryEN.con_UserId, objSysScoreSummary_Cond.userId, strComparisonOp_UserId);
}
if (Object.prototype.hasOwnProperty.call(objSysScoreSummary_Cond.dicFldComparisonOp, clsSysScoreSummaryEN.con_SchoolYear) == true)
{
const strComparisonOp_SchoolYear:string = objSysScoreSummary_Cond.dicFldComparisonOp[clsSysScoreSummaryEN.con_SchoolYear];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysScoreSummaryEN.con_SchoolYear, objSysScoreSummary_Cond.schoolYear, strComparisonOp_SchoolYear);
}
if (Object.prototype.hasOwnProperty.call(objSysScoreSummary_Cond.dicFldComparisonOp, clsSysScoreSummaryEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objSysScoreSummary_Cond.dicFldComparisonOp[clsSysScoreSummaryEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysScoreSummaryEN.con_UpdDate, objSysScoreSummary_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objSysScoreSummary_Cond.dicFldComparisonOp, clsSysScoreSummaryEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objSysScoreSummary_Cond.dicFldComparisonOp[clsSysScoreSummaryEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysScoreSummaryEN.con_Memo, objSysScoreSummary_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objSysScoreSummary_Cond.dicFldComparisonOp, clsSysScoreSummaryEN.con_ScoreTypeId) == true)
{
const strComparisonOp_ScoreTypeId:string = objSysScoreSummary_Cond.dicFldComparisonOp[clsSysScoreSummaryEN.con_ScoreTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysScoreSummaryEN.con_ScoreTypeId, objSysScoreSummary_Cond.scoreTypeId, strComparisonOp_ScoreTypeId);
}
if (Object.prototype.hasOwnProperty.call(objSysScoreSummary_Cond.dicFldComparisonOp, clsSysScoreSummaryEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objSysScoreSummary_Cond.dicFldComparisonOp[clsSysScoreSummaryEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysScoreSummaryEN.con_UpdUser, objSysScoreSummary_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objSysScoreSummary_Cond.dicFldComparisonOp, clsSysScoreSummaryEN.con_Score) == true)
{
const strComparisonOp_Score:string = objSysScoreSummary_Cond.dicFldComparisonOp[clsSysScoreSummaryEN.con_Score];
strWhereCond += Format(" And {0} {2} {1}", clsSysScoreSummaryEN.con_Score, objSysScoreSummary_Cond.score, strComparisonOp_Score);
}
if (Object.prototype.hasOwnProperty.call(objSysScoreSummary_Cond.dicFldComparisonOp, clsSysScoreSummaryEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objSysScoreSummary_Cond.dicFldComparisonOp[clsSysScoreSummaryEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysScoreSummaryEN.con_id_CurrEduCls, objSysScoreSummary_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (Object.prototype.hasOwnProperty.call(objSysScoreSummary_Cond.dicFldComparisonOp, clsSysScoreSummaryEN.con_IsSubmit) == true)
{
if (objSysScoreSummary_Cond.isSubmit == true)
{
strWhereCond += Format(" And {0} = '1'", clsSysScoreSummaryEN.con_IsSubmit);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsSysScoreSummaryEN.con_IsSubmit);
}
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--SysScoreSummary(系统分数汇总表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param lngmId: mId(要求唯一的字段)
 * @param strUserId: 用户ID(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function SysScoreSummary_GetUniCondStr_mId_UserId(objSysScoreSummaryEN: clsSysScoreSummaryEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and mId = '{0}'", objSysScoreSummaryEN.mId);
 strWhereCond +=  Format(" and UserId = '{0}'", objSysScoreSummaryEN.userId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--SysScoreSummary(系统分数汇总表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param lngmId: mId(要求唯一的字段)
 * @param strUserId: 用户ID(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function SysScoreSummary_GetUniCondStr4Update_mId_UserId(objSysScoreSummaryEN: clsSysScoreSummaryEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and mId <> '{0}'", objSysScoreSummaryEN.mId);
 strWhereCond +=  Format(" and mId = '{0}'", objSysScoreSummaryEN.mId);
 strWhereCond +=  Format(" and UserId = '{0}'", objSysScoreSummaryEN.userId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objSysScoreSummaryENS:源对象
 * @param objSysScoreSummaryENT:目标对象
*/
export function SysScoreSummary_CopyObjTo(objSysScoreSummaryENS: clsSysScoreSummaryEN , objSysScoreSummaryENT: clsSysScoreSummaryEN ): void 
{
objSysScoreSummaryENT.mId = objSysScoreSummaryENS.mId; //mId
objSysScoreSummaryENT.userId = objSysScoreSummaryENS.userId; //用户ID
objSysScoreSummaryENT.schoolYear = objSysScoreSummaryENS.schoolYear; //学年
objSysScoreSummaryENT.updDate = objSysScoreSummaryENS.updDate; //修改日期
objSysScoreSummaryENT.memo = objSysScoreSummaryENS.memo; //备注
objSysScoreSummaryENT.scoreTypeId = objSysScoreSummaryENS.scoreTypeId; //分数类型Id
objSysScoreSummaryENT.updUser = objSysScoreSummaryENS.updUser; //修改人
objSysScoreSummaryENT.score = objSysScoreSummaryENS.score; //评分
objSysScoreSummaryENT.id_CurrEduCls = objSysScoreSummaryENS.id_CurrEduCls; //教学班流水号
objSysScoreSummaryENT.isSubmit = objSysScoreSummaryENS.isSubmit; //是否提交
objSysScoreSummaryENT.sfUpdFldSetStr = objSysScoreSummaryENS.updFldString; //sfUpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objSysScoreSummaryENS:源对象
 * @param objSysScoreSummaryENT:目标对象
*/
export function SysScoreSummary_GetObjFromJsonObj(objSysScoreSummaryENS: clsSysScoreSummaryEN): clsSysScoreSummaryEN 
{
 const objSysScoreSummaryENT: clsSysScoreSummaryEN = new clsSysScoreSummaryEN();
ObjectAssign(objSysScoreSummaryENT, objSysScoreSummaryENS);
 return objSysScoreSummaryENT;
}