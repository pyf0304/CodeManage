﻿
 /**
 * 类名:clsgs_TotalDataStatisticsWApi
 * 表名:gs_TotalDataStatistics(01120683)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:47:33
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
 * 总数据统计(gs_TotalDataStatistics)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2023年03月13日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { enumComparisonOp } from "../../PubFun/enumComparisonOp.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { clsgs_TotalDataStatisticsEN } from "../../L0_Entity/GraduateEduTools/clsgs_TotalDataStatisticsEN.js";
import { vgs_TotalDataStatistics_ReFreshThisCache } from "../../L3_ForWApi/GraduateEduTools/clsvgs_TotalDataStatisticsWApi.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { tzDataType } from "../../PubFun/clsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const gs_TotalDataStatistics_Controller = "gs_TotalDataStatisticsApi";
 export const gs_TotalDataStatistics_ConstructorName = "gs_TotalDataStatistics";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strTotalDataId:关键字
 * @returns 对象
 **/
export async function gs_TotalDataStatistics_GetObjByTotalDataIdAsync(strTotalDataId: string): Promise<clsgs_TotalDataStatisticsEN|null>  
{
const strThisFuncName = "GetObjByTotalDataIdAsync";

if (IsNullOrEmpty(strTotalDataId) == true)
{
  const strMsg = Format("参数:[strTotalDataId]不能为空！(In clsgs_TotalDataStatisticsWApi.GetObjByTotalDataIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strTotalDataId.length != 12)
{
const strMsg = Format("缓存分类变量:[strTotalDataId]的长度:[{0}]不正确！(clsgs_TotalDataStatisticsWApi.GetObjByTotalDataIdAsync)", strTotalDataId.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByTotalDataId";
const strUrl = GetWebApiUrl(gs_TotalDataStatistics_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strTotalDataId": strTotalDataId,
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
const objgs_TotalDataStatistics = gs_TotalDataStatistics_GetObjFromJsonObj(returnObj);
return objgs_TotalDataStatistics;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TotalDataStatistics_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TotalDataStatistics_ConstructorName, strThisFuncName);
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
 * @param strTotalDataId:所给的关键字
 * @returns 对象
*/
export async function gs_TotalDataStatistics_GetObjByTotalDataId_Cache(strTotalDataId:string,strid_CurrEduCls:string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByTotalDataId_Cache";

if (IsNullOrEmpty(strTotalDataId) == true)
{
  const strMsg = Format("参数:[strTotalDataId]不能为空！(In clsgs_TotalDataStatisticsWApi.GetObjByTotalDataId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strTotalDataId.length != 12)
{
const strMsg = Format("缓存分类变量:[strTotalDataId]的长度:[{0}]不正确！(clsgs_TotalDataStatisticsWApi.GetObjByTotalDataId_Cache)", strTotalDataId.length);
console.error(strMsg);
throw (strMsg);
}
const arrgs_TotalDataStatisticsObjLst_Cache = await gs_TotalDataStatistics_GetObjLst_Cache(strid_CurrEduCls);
try
{
const arrgs_TotalDataStatistics_Sel: Array <clsgs_TotalDataStatisticsEN> = arrgs_TotalDataStatisticsObjLst_Cache.filter(x => 
 x.totalDataId == strTotalDataId );
let objgs_TotalDataStatistics: clsgs_TotalDataStatisticsEN;
if (arrgs_TotalDataStatistics_Sel.length > 0)
{
objgs_TotalDataStatistics = arrgs_TotalDataStatistics_Sel[0];
return objgs_TotalDataStatistics;
}
else
{
if (bolTryAsyncOnce == true)
{
const objgs_TotalDataStatistics_Const = await gs_TotalDataStatistics_GetObjByTotalDataIdAsync(strTotalDataId);
if (objgs_TotalDataStatistics_Const != null)
{
gs_TotalDataStatistics_ReFreshThisCache(strid_CurrEduCls);
return objgs_TotalDataStatistics_Const;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strTotalDataId, gs_TotalDataStatistics_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param strTotalDataId:所给的关键字
 * @returns 对象
*/
export async function gs_TotalDataStatistics_GetObjByTotalDataId_localStorage(strTotalDataId: string) {
const strThisFuncName = "GetObjByTotalDataId_localStorage";

if (IsNullOrEmpty(strTotalDataId) == true)
{
  const strMsg = Format("参数:[strTotalDataId]不能为空！(In clsgs_TotalDataStatisticsWApi.GetObjByTotalDataId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
if (strTotalDataId.length != 12)
{
const strMsg = Format("缓存分类变量:[strTotalDataId]的长度:[{0}]不正确！(clsgs_TotalDataStatisticsWApi.GetObjByTotalDataId_localStorage)", strTotalDataId.length);
console.error(strMsg);
throw (strMsg);
}
const strKey = Format("{0}_{1}", clsgs_TotalDataStatisticsEN._CurrTabName, strTotalDataId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objgs_TotalDataStatistics_Cache: clsgs_TotalDataStatisticsEN = JSON.parse(strTempObj);
return objgs_TotalDataStatistics_Cache;
}
try
{
const objgs_TotalDataStatistics = await gs_TotalDataStatistics_GetObjByTotalDataIdAsync(strTotalDataId);
if (objgs_TotalDataStatistics != null)
{
localStorage.setItem(strKey, JSON.stringify(objgs_TotalDataStatistics));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objgs_TotalDataStatistics;
}
return objgs_TotalDataStatistics;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strTotalDataId, gs_TotalDataStatistics_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objgs_TotalDataStatistics:所给的对象
 * @returns 对象
*/
export async function gs_TotalDataStatistics_UpdateObjInLst_Cache(objgs_TotalDataStatistics: clsgs_TotalDataStatisticsEN,strid_CurrEduCls: string) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrgs_TotalDataStatisticsObjLst_Cache = await gs_TotalDataStatistics_GetObjLst_Cache(strid_CurrEduCls);
const obj = arrgs_TotalDataStatisticsObjLst_Cache.find(x => x.totalDataTypeId == objgs_TotalDataStatistics.totalDataTypeId && x.tableKey == objgs_TotalDataStatistics.tableKey);
if (obj != null)
{
objgs_TotalDataStatistics.totalDataId = obj.totalDataId;
ObjectAssign( obj, objgs_TotalDataStatistics);
}
else
{
arrgs_TotalDataStatisticsObjLst_Cache.push(objgs_TotalDataStatistics);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, gs_TotalDataStatistics_ConstructorName, strThisFuncName);
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
export async function gs_TotalDataStatistics_func(strInFldName:string , strOutFldName:string , strInValue:string 
, strid_CurrEduCls_C: string)
{
//const strThisFuncName = "func";

if (IsNullOrEmpty(strid_CurrEduCls_C) == true)
{
  const strMsg = Format("参数:[strid_CurrEduCls_C]不能为空！(In clsgs_TotalDataStatisticsWApi.func)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_CurrEduCls_C.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsgs_TotalDataStatisticsWApi.func)", strid_CurrEduCls_C.length);
console.error(strMsg);
throw (strMsg);
}

if (strInFldName != clsgs_TotalDataStatisticsEN.con_TotalDataId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsgs_TotalDataStatisticsEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strOutFldName, clsgs_TotalDataStatisticsEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strTotalDataId = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objgs_TotalDataStatistics = await gs_TotalDataStatistics_GetObjByTotalDataId_Cache(strTotalDataId , strid_CurrEduCls_C);
if (objgs_TotalDataStatistics == null) return "";
if (objgs_TotalDataStatistics.GetFldValue(strOutFldName) == null) return "";
return objgs_TotalDataStatistics.GetFldValue(strOutFldName).toString();
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
export function gs_TotalDataStatistics_SortFun_Defa(a:clsgs_TotalDataStatisticsEN , b:clsgs_TotalDataStatisticsEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.totalDataId.localeCompare(b.totalDataId);
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
export function gs_TotalDataStatistics_SortFun_Defa_2Fld(a:clsgs_TotalDataStatisticsEN , b:clsgs_TotalDataStatisticsEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.id_CurrEduCls == b.id_CurrEduCls) return a.totalDataTypeId.localeCompare(b.totalDataTypeId);
else return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
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
export function gs_TotalDataStatistics_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsgs_TotalDataStatisticsEN.con_TotalDataId:
return (a: clsgs_TotalDataStatisticsEN, b: clsgs_TotalDataStatisticsEN) => {
return a.totalDataId.localeCompare(b.totalDataId);
}
case clsgs_TotalDataStatisticsEN.con_id_CurrEduCls:
return (a: clsgs_TotalDataStatisticsEN, b: clsgs_TotalDataStatisticsEN) => {
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
case clsgs_TotalDataStatisticsEN.con_TotalDataTypeId:
return (a: clsgs_TotalDataStatisticsEN, b: clsgs_TotalDataStatisticsEN) => {
return a.totalDataTypeId.localeCompare(b.totalDataTypeId);
}
case clsgs_TotalDataStatisticsEN.con_TableKey:
return (a: clsgs_TotalDataStatisticsEN, b: clsgs_TotalDataStatisticsEN) => {
if (a.tableKey == null) return -1;
if (b.tableKey == null) return 1;
return a.tableKey.localeCompare(b.tableKey);
}
case clsgs_TotalDataStatisticsEN.con_DataUser:
return (a: clsgs_TotalDataStatisticsEN, b: clsgs_TotalDataStatisticsEN) => {
if (a.dataUser == null) return -1;
if (b.dataUser == null) return 1;
return a.dataUser.localeCompare(b.dataUser);
}
case clsgs_TotalDataStatisticsEN.con_DataAddDate:
return (a: clsgs_TotalDataStatisticsEN, b: clsgs_TotalDataStatisticsEN) => {
if (a.dataAddDate == null) return -1;
if (b.dataAddDate == null) return 1;
return a.dataAddDate.localeCompare(b.dataAddDate);
}
case clsgs_TotalDataStatisticsEN.con_Month:
return (a: clsgs_TotalDataStatisticsEN, b: clsgs_TotalDataStatisticsEN) => {
return a.month-b.month;
}
case clsgs_TotalDataStatisticsEN.con_Week:
return (a: clsgs_TotalDataStatisticsEN, b: clsgs_TotalDataStatisticsEN) => {
return a.week-b.week;
}
case clsgs_TotalDataStatisticsEN.con_UpdDate:
return (a: clsgs_TotalDataStatisticsEN, b: clsgs_TotalDataStatisticsEN) => {
if (a.updDate == null) return -1;
if (b.updDate == null) return 1;
return a.updDate.localeCompare(b.updDate);
}
case clsgs_TotalDataStatisticsEN.con_UpdUser:
return (a: clsgs_TotalDataStatisticsEN, b: clsgs_TotalDataStatisticsEN) => {
if (a.updUser == null) return -1;
if (b.updUser == null) return 1;
return a.updUser.localeCompare(b.updUser);
}
case clsgs_TotalDataStatisticsEN.con_Memo:
return (a: clsgs_TotalDataStatisticsEN, b: clsgs_TotalDataStatisticsEN) => {
if (a.memo == null) return -1;
if (b.memo == null) return 1;
return a.memo.localeCompare(b.memo);
}
case clsgs_TotalDataStatisticsEN.con_Score:
return (a: clsgs_TotalDataStatisticsEN, b: clsgs_TotalDataStatisticsEN) => {
return a.score-b.score;
}
case clsgs_TotalDataStatisticsEN.con_TeaScore:
return (a: clsgs_TotalDataStatisticsEN, b: clsgs_TotalDataStatisticsEN) => {
return a.teaScore-b.teaScore;
}
case clsgs_TotalDataStatisticsEN.con_WeekTimeRange:
return (a: clsgs_TotalDataStatisticsEN, b: clsgs_TotalDataStatisticsEN) => {
if (a.weekTimeRange == null) return -1;
if (b.weekTimeRange == null) return 1;
return a.weekTimeRange.localeCompare(b.weekTimeRange);
}
case clsgs_TotalDataStatisticsEN.con_StuScore:
return (a: clsgs_TotalDataStatisticsEN, b: clsgs_TotalDataStatisticsEN) => {
return a.stuScore-b.stuScore;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_TotalDataStatistics]中不存在！(in ${ gs_TotalDataStatistics_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsgs_TotalDataStatisticsEN.con_TotalDataId:
return (a: clsgs_TotalDataStatisticsEN, b: clsgs_TotalDataStatisticsEN) => {
return b.totalDataId.localeCompare(a.totalDataId);
}
case clsgs_TotalDataStatisticsEN.con_id_CurrEduCls:
return (a: clsgs_TotalDataStatisticsEN, b: clsgs_TotalDataStatisticsEN) => {
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
case clsgs_TotalDataStatisticsEN.con_TotalDataTypeId:
return (a: clsgs_TotalDataStatisticsEN, b: clsgs_TotalDataStatisticsEN) => {
return b.totalDataTypeId.localeCompare(a.totalDataTypeId);
}
case clsgs_TotalDataStatisticsEN.con_TableKey:
return (a: clsgs_TotalDataStatisticsEN, b: clsgs_TotalDataStatisticsEN) => {
if (b.tableKey == null) return -1;
if (a.tableKey == null) return 1;
return b.tableKey.localeCompare(a.tableKey);
}
case clsgs_TotalDataStatisticsEN.con_DataUser:
return (a: clsgs_TotalDataStatisticsEN, b: clsgs_TotalDataStatisticsEN) => {
if (b.dataUser == null) return -1;
if (a.dataUser == null) return 1;
return b.dataUser.localeCompare(a.dataUser);
}
case clsgs_TotalDataStatisticsEN.con_DataAddDate:
return (a: clsgs_TotalDataStatisticsEN, b: clsgs_TotalDataStatisticsEN) => {
if (b.dataAddDate == null) return -1;
if (a.dataAddDate == null) return 1;
return b.dataAddDate.localeCompare(a.dataAddDate);
}
case clsgs_TotalDataStatisticsEN.con_Month:
return (a: clsgs_TotalDataStatisticsEN, b: clsgs_TotalDataStatisticsEN) => {
return b.month-a.month;
}
case clsgs_TotalDataStatisticsEN.con_Week:
return (a: clsgs_TotalDataStatisticsEN, b: clsgs_TotalDataStatisticsEN) => {
return b.week-a.week;
}
case clsgs_TotalDataStatisticsEN.con_UpdDate:
return (a: clsgs_TotalDataStatisticsEN, b: clsgs_TotalDataStatisticsEN) => {
if (b.updDate == null) return -1;
if (a.updDate == null) return 1;
return b.updDate.localeCompare(a.updDate);
}
case clsgs_TotalDataStatisticsEN.con_UpdUser:
return (a: clsgs_TotalDataStatisticsEN, b: clsgs_TotalDataStatisticsEN) => {
if (b.updUser == null) return -1;
if (a.updUser == null) return 1;
return b.updUser.localeCompare(a.updUser);
}
case clsgs_TotalDataStatisticsEN.con_Memo:
return (a: clsgs_TotalDataStatisticsEN, b: clsgs_TotalDataStatisticsEN) => {
if (b.memo == null) return -1;
if (a.memo == null) return 1;
return b.memo.localeCompare(a.memo);
}
case clsgs_TotalDataStatisticsEN.con_Score:
return (a: clsgs_TotalDataStatisticsEN, b: clsgs_TotalDataStatisticsEN) => {
return b.score-a.score;
}
case clsgs_TotalDataStatisticsEN.con_TeaScore:
return (a: clsgs_TotalDataStatisticsEN, b: clsgs_TotalDataStatisticsEN) => {
return b.teaScore-a.teaScore;
}
case clsgs_TotalDataStatisticsEN.con_WeekTimeRange:
return (a: clsgs_TotalDataStatisticsEN, b: clsgs_TotalDataStatisticsEN) => {
if (b.weekTimeRange == null) return -1;
if (a.weekTimeRange == null) return 1;
return b.weekTimeRange.localeCompare(a.weekTimeRange);
}
case clsgs_TotalDataStatisticsEN.con_StuScore:
return (a: clsgs_TotalDataStatisticsEN, b: clsgs_TotalDataStatisticsEN) => {
return b.stuScore-a.stuScore;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_TotalDataStatistics]中不存在！(in ${ gs_TotalDataStatistics_ConstructorName}.${ strThisFuncName})`;
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
export async function gs_TotalDataStatistics_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsgs_TotalDataStatisticsEN.con_TotalDataId:
return (obj: clsgs_TotalDataStatisticsEN) => {
return obj.totalDataId === value;
}
case clsgs_TotalDataStatisticsEN.con_id_CurrEduCls:
return (obj: clsgs_TotalDataStatisticsEN) => {
return obj.id_CurrEduCls === value;
}
case clsgs_TotalDataStatisticsEN.con_TotalDataTypeId:
return (obj: clsgs_TotalDataStatisticsEN) => {
return obj.totalDataTypeId === value;
}
case clsgs_TotalDataStatisticsEN.con_TableKey:
return (obj: clsgs_TotalDataStatisticsEN) => {
return obj.tableKey === value;
}
case clsgs_TotalDataStatisticsEN.con_DataUser:
return (obj: clsgs_TotalDataStatisticsEN) => {
return obj.dataUser === value;
}
case clsgs_TotalDataStatisticsEN.con_DataAddDate:
return (obj: clsgs_TotalDataStatisticsEN) => {
return obj.dataAddDate === value;
}
case clsgs_TotalDataStatisticsEN.con_Month:
return (obj: clsgs_TotalDataStatisticsEN) => {
return obj.month === value;
}
case clsgs_TotalDataStatisticsEN.con_Week:
return (obj: clsgs_TotalDataStatisticsEN) => {
return obj.week === value;
}
case clsgs_TotalDataStatisticsEN.con_UpdDate:
return (obj: clsgs_TotalDataStatisticsEN) => {
return obj.updDate === value;
}
case clsgs_TotalDataStatisticsEN.con_UpdUser:
return (obj: clsgs_TotalDataStatisticsEN) => {
return obj.updUser === value;
}
case clsgs_TotalDataStatisticsEN.con_Memo:
return (obj: clsgs_TotalDataStatisticsEN) => {
return obj.memo === value;
}
case clsgs_TotalDataStatisticsEN.con_Score:
return (obj: clsgs_TotalDataStatisticsEN) => {
return obj.score === value;
}
case clsgs_TotalDataStatisticsEN.con_TeaScore:
return (obj: clsgs_TotalDataStatisticsEN) => {
return obj.teaScore === value;
}
case clsgs_TotalDataStatisticsEN.con_WeekTimeRange:
return (obj: clsgs_TotalDataStatisticsEN) => {
return obj.weekTimeRange === value;
}
case clsgs_TotalDataStatisticsEN.con_StuScore:
return (obj: clsgs_TotalDataStatisticsEN) => {
return obj.stuScore === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_TotalDataStatistics]中不存在！(in ${ gs_TotalDataStatistics_ConstructorName}.${ strThisFuncName})`;
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
export async function gs_TotalDataStatistics_funcKey(strInFldName:string, strInValue: any, strComparisonOp:string, strid_CurrEduCls_C: string): Promise<Array<string>>
{
//const strThisFuncName = "funcKey";

if (IsNullOrEmpty(strid_CurrEduCls_C) == true)
{
  const strMsg = Format("参数:[strid_CurrEduCls_C]不能为空！(In clsgs_TotalDataStatisticsWApi.funcKey)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_CurrEduCls_C.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsgs_TotalDataStatisticsWApi.funcKey)", strid_CurrEduCls_C.length);
console.error(strMsg);
throw (strMsg);
}

if (strInFldName == clsgs_TotalDataStatisticsEN.con_TotalDataId)
{
const strMsg = Format("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (IsNullOrEmpty(strInValue) == true)
{
return [];
}
const arrgs_TotalDataStatistics = await gs_TotalDataStatistics_GetObjLst_Cache(strid_CurrEduCls_C);
if (arrgs_TotalDataStatistics == null) return [];
let arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics;
const strType = typeof(strInValue);
switch (strType)
{
case "string":
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01: // " = "
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
break;
case enumComparisonOp.Like_03:
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
break;
case enumComparisonOp.In_04:
const arrValues = strInValue.split(',');
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
break;
}
break;
case "boolean":
if (strInValue == null) return [];
if (strComparisonOp == enumComparisonOp.Equal_01)
{
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
}
break;
case "number":
if (Number(strInValue) == 0) return [];
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01:
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
break;
case enumComparisonOp.NotEqual_02:
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
break;
case enumComparisonOp.NotLessThan_05://" >= ":
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
break;
case enumComparisonOp.NotGreaterThan_06://" <= ":
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
case enumComparisonOp.GreaterThan_07://" > ":
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
break;
case enumComparisonOp.LessThan_08://" < ":
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
}
break;
}
if (arrgs_TotalDataStatistics_Sel.length == 0) return [];
return arrgs_TotalDataStatistics_Sel.map(x=>x.totalDataId);
}

 /**
 * 根据条件获取满足条件的第一条记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
 * @param strWhereCond:条件
 * @returns 返回的第一条记录的关键字值
 **/
export async function gs_TotalDataStatistics_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(gs_TotalDataStatistics_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TotalDataStatistics_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TotalDataStatistics_ConstructorName, strThisFuncName);
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
export async function gs_TotalDataStatistics_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(gs_TotalDataStatistics_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TotalDataStatistics_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TotalDataStatistics_ConstructorName, strThisFuncName);
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
export async function gs_TotalDataStatistics_GetFirstObjAsync(strWhereCond: string): Promise<clsgs_TotalDataStatisticsEN|null>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(gs_TotalDataStatistics_Controller, strAction);
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
const objgs_TotalDataStatistics = gs_TotalDataStatistics_GetObjFromJsonObj(returnObj);
return objgs_TotalDataStatistics;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TotalDataStatistics_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TotalDataStatistics_ConstructorName, strThisFuncName);
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
export async function gs_TotalDataStatistics_GetObjLst_ClientCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
if (IsNullOrEmpty(clsgs_TotalDataStatisticsEN.WhereFormat) == false)
{
strWhereCond = Format(clsgs_TotalDataStatisticsEN.WhereFormat, strid_CurrEduCls);
}
else
{
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
}
const strKey = Format("{0}_{1}", clsgs_TotalDataStatisticsEN._CurrTabName, strid_CurrEduCls);
if (IsNullOrEmpty(clsgs_TotalDataStatisticsEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsgs_TotalDataStatisticsEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrgs_TotalDataStatisticsExObjLst_Cache: Array<clsgs_TotalDataStatisticsEN> = CacheHelper.Get(strKey);
const arrgs_TotalDataStatisticsObjLst_T = gs_TotalDataStatistics_GetObjLstByJSONObjLst(arrgs_TotalDataStatisticsExObjLst_Cache);
return arrgs_TotalDataStatisticsObjLst_T;
}
try
{
const arrgs_TotalDataStatisticsExObjLst = await gs_TotalDataStatistics_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrgs_TotalDataStatisticsExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_TotalDataStatisticsExObjLst.length);
console.log(strInfo);
return arrgs_TotalDataStatisticsExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, gs_TotalDataStatistics_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_TotalDataStatistics_GetObjLst_localStorage(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
if (IsNullOrEmpty(clsgs_TotalDataStatisticsEN.WhereFormat) == false)
{
strWhereCond = Format(clsgs_TotalDataStatisticsEN.WhereFormat, strid_CurrEduCls);
}
else
{
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
}
const strKey = Format("{0}_{1}", clsgs_TotalDataStatisticsEN._CurrTabName, strid_CurrEduCls);
if (IsNullOrEmpty(clsgs_TotalDataStatisticsEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsgs_TotalDataStatisticsEN.CacheAddiCondition);
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
const arrgs_TotalDataStatisticsExObjLst_Cache: Array<clsgs_TotalDataStatisticsEN> = JSON.parse(strTempObjLst);
const arrgs_TotalDataStatisticsObjLst_T = gs_TotalDataStatistics_GetObjLstByJSONObjLst(arrgs_TotalDataStatisticsExObjLst_Cache);
return arrgs_TotalDataStatisticsObjLst_T;
}
try
{
const arrgs_TotalDataStatisticsExObjLst = await gs_TotalDataStatistics_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrgs_TotalDataStatisticsExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_TotalDataStatisticsExObjLst.length);
console.log(strInfo);
return arrgs_TotalDataStatisticsExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, gs_TotalDataStatistics_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_TotalDataStatistics_GetObjLst_localStorage_PureCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsgs_TotalDataStatisticsEN._CurrTabName, strid_CurrEduCls);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrgs_TotalDataStatisticsObjLst_Cache: Array<clsgs_TotalDataStatisticsEN> = JSON.parse(strTempObjLst);
return arrgs_TotalDataStatisticsObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function gs_TotalDataStatistics_GetObjLstAsync(strWhereCond: string): Promise<Array<clsgs_TotalDataStatisticsEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(gs_TotalDataStatistics_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_TotalDataStatistics_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_TotalDataStatistics_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TotalDataStatistics_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TotalDataStatistics_ConstructorName, strThisFuncName);
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
export async function gs_TotalDataStatistics_GetObjLst_sessionStorage(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
if (IsNullOrEmpty(clsgs_TotalDataStatisticsEN.WhereFormat) == false)
{
strWhereCond = Format(clsgs_TotalDataStatisticsEN.WhereFormat, strid_CurrEduCls);
}
else
{
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
}
const strKey = Format("{0}_{1}", clsgs_TotalDataStatisticsEN._CurrTabName, strid_CurrEduCls);
if (IsNullOrEmpty(clsgs_TotalDataStatisticsEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsgs_TotalDataStatisticsEN.CacheAddiCondition);
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
const arrgs_TotalDataStatisticsExObjLst_Cache: Array<clsgs_TotalDataStatisticsEN> = JSON.parse(strTempObjLst);
const arrgs_TotalDataStatisticsObjLst_T = gs_TotalDataStatistics_GetObjLstByJSONObjLst(arrgs_TotalDataStatisticsExObjLst_Cache);
return arrgs_TotalDataStatisticsObjLst_T;
}
try
{
const arrgs_TotalDataStatisticsExObjLst = await gs_TotalDataStatistics_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrgs_TotalDataStatisticsExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_TotalDataStatisticsExObjLst.length);
console.log(strInfo);
return arrgs_TotalDataStatisticsExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, gs_TotalDataStatistics_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_TotalDataStatistics_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsgs_TotalDataStatisticsEN._CurrTabName, strid_CurrEduCls);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrgs_TotalDataStatisticsObjLst_Cache: Array<clsgs_TotalDataStatisticsEN> = JSON.parse(strTempObjLst);
return arrgs_TotalDataStatisticsObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_TotalDataStatistics_GetObjLst_Cache(strid_CurrEduCls: string): Promise<Array<clsgs_TotalDataStatisticsEN>>
{
//const strThisFuncName = "GetObjLst_Cache";

if (IsNullOrEmpty(strid_CurrEduCls) == true)
{
const strMsg = Format("缓存分类变量:[id_CurrEduCls]不能为空！(in clsgs_TotalDataStatisticsWApi.gs_TotalDataStatistics_GetObjLst_Cache() )");
console.error(strMsg);
throw (strMsg);
}
if (strid_CurrEduCls.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(in clsgs_TotalDataStatisticsWApi.gs_TotalDataStatistics_GetObjLst_Cache() )", strid_CurrEduCls.length);
console.error(strMsg);
throw (strMsg);
}
let arrgs_TotalDataStatisticsObjLst_Cache;
switch (clsgs_TotalDataStatisticsEN.CacheModeId)
{
case "04"://sessionStorage
arrgs_TotalDataStatisticsObjLst_Cache = await gs_TotalDataStatistics_GetObjLst_sessionStorage(strid_CurrEduCls);
break;
case "03"://localStorage
arrgs_TotalDataStatisticsObjLst_Cache = await gs_TotalDataStatistics_GetObjLst_localStorage(strid_CurrEduCls);
break;
case "02"://ClientCache
arrgs_TotalDataStatisticsObjLst_Cache = await gs_TotalDataStatistics_GetObjLst_ClientCache(strid_CurrEduCls);
break;
default:
arrgs_TotalDataStatisticsObjLst_Cache = await gs_TotalDataStatistics_GetObjLst_ClientCache(strid_CurrEduCls);
break;
}
const arrgs_TotalDataStatisticsObjLst = gs_TotalDataStatistics_GetObjLstByJSONObjLst(arrgs_TotalDataStatisticsObjLst_Cache);
return arrgs_TotalDataStatisticsObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_TotalDataStatistics_GetObjLst_PureCache(strid_CurrEduCls: string)
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrgs_TotalDataStatisticsObjLst_Cache;
switch (clsgs_TotalDataStatisticsEN.CacheModeId)
{
case "04"://sessionStorage
arrgs_TotalDataStatisticsObjLst_Cache = await gs_TotalDataStatistics_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls);
break;
case "03"://localStorage
arrgs_TotalDataStatisticsObjLst_Cache = await gs_TotalDataStatistics_GetObjLst_localStorage_PureCache(strid_CurrEduCls);
break;
case "02"://ClientCache
arrgs_TotalDataStatisticsObjLst_Cache = null;
break;
default:
arrgs_TotalDataStatisticsObjLst_Cache = null;
break;
}
return arrgs_TotalDataStatisticsObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrTotalDataId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function gs_TotalDataStatistics_GetSubObjLst_Cache(objgs_TotalDataStatistics_Cond: clsgs_TotalDataStatisticsEN,strid_CurrEduCls: string) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrgs_TotalDataStatisticsObjLst_Cache = await gs_TotalDataStatistics_GetObjLst_Cache(strid_CurrEduCls);
let arrgs_TotalDataStatistics_Sel: Array < clsgs_TotalDataStatisticsEN > = arrgs_TotalDataStatisticsObjLst_Cache;
if (objgs_TotalDataStatistics_Cond.sf_FldComparisonOp == null || objgs_TotalDataStatistics_Cond.sf_FldComparisonOp == "") return arrgs_TotalDataStatistics_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_TotalDataStatistics_Cond.sf_FldComparisonOp);
//console.log("clsgs_TotalDataStatisticsWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objgs_TotalDataStatistics_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_TotalDataStatistics_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrgs_TotalDataStatistics_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objgs_TotalDataStatistics_Cond), gs_TotalDataStatistics_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsgs_TotalDataStatisticsEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrTotalDataId:关键字列表
 * @returns 对象列表
 **/
export async function gs_TotalDataStatistics_GetObjLstByTotalDataIdLstAsync(arrTotalDataId: Array<string>): Promise<Array<clsgs_TotalDataStatisticsEN>>  
{
const strThisFuncName = "GetObjLstByTotalDataIdLstAsync";
const strAction = "GetObjLstByTotalDataIdLst";
const strUrl = GetWebApiUrl(gs_TotalDataStatistics_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrTotalDataId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_TotalDataStatistics_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_TotalDataStatistics_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TotalDataStatistics_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TotalDataStatistics_ConstructorName, strThisFuncName);
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
 * @param arrstrTotalDataIdLst:关键字列表
 * @returns 对象列表
*/
export async function gs_TotalDataStatistics_GetObjLstByTotalDataIdLst_Cache(arrTotalDataIdLst: Array<string>,strid_CurrEduCls: string) {
const strThisFuncName = "GetObjLstByTotalDataIdLst_Cache";
try
{
const arrgs_TotalDataStatisticsObjLst_Cache = await gs_TotalDataStatistics_GetObjLst_Cache(strid_CurrEduCls);
const arrgs_TotalDataStatistics_Sel: Array <clsgs_TotalDataStatisticsEN> = arrgs_TotalDataStatisticsObjLst_Cache.filter(x => arrTotalDataIdLst.indexOf(x.totalDataId)>-1);
return arrgs_TotalDataStatistics_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrTotalDataIdLst.join(","), gs_TotalDataStatistics_ConstructorName, strThisFuncName);
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
export async function gs_TotalDataStatistics_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsgs_TotalDataStatisticsEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(gs_TotalDataStatistics_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_TotalDataStatistics_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_TotalDataStatistics_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TotalDataStatistics_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TotalDataStatistics_ConstructorName, strThisFuncName);
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
export async function gs_TotalDataStatistics_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsgs_TotalDataStatisticsEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(gs_TotalDataStatistics_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_TotalDataStatistics_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_TotalDataStatistics_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TotalDataStatistics_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TotalDataStatistics_ConstructorName, strThisFuncName);
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
export async function gs_TotalDataStatistics_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(gs_TotalDataStatistics_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TotalDataStatistics_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TotalDataStatistics_ConstructorName, strThisFuncName);
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
export async function gs_TotalDataStatistics_GetObjLstByPager_Cache(objPagerPara: stuPagerPara,strid_CurrEduCls: string) {
const strThisFuncName = "GetObjLstByPager_Cache";
if (objPagerPara.pageIndex == 0) return new Array<clsgs_TotalDataStatisticsEN>();
const arrgs_TotalDataStatisticsObjLst_Cache = await gs_TotalDataStatistics_GetObjLst_Cache(strid_CurrEduCls);
if (arrgs_TotalDataStatisticsObjLst_Cache.length == 0) return arrgs_TotalDataStatisticsObjLst_Cache;
let arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatisticsObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objgs_TotalDataStatistics_Cond = new clsgs_TotalDataStatisticsEN();
ObjectAssign(objgs_TotalDataStatistics_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsgs_TotalDataStatisticsWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_TotalDataStatistics_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrgs_TotalDataStatistics_Sel.length == 0) return arrgs_TotalDataStatistics_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.sort(gs_TotalDataStatistics_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.sort(objPagerPara.sortFun);
}
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.slice(intStart, intEnd);     
return arrgs_TotalDataStatistics_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, gs_TotalDataStatistics_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsgs_TotalDataStatisticsEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function gs_TotalDataStatistics_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsgs_TotalDataStatisticsEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
if (objPagerPara.pageIndex == 0) return new Array<clsgs_TotalDataStatisticsEN>();
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(gs_TotalDataStatistics_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_TotalDataStatistics_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_TotalDataStatistics_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TotalDataStatistics_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TotalDataStatistics_ConstructorName, strThisFuncName);
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
 * @param strTotalDataId:关键字
 * @returns 获取删除的结果
 **/
export async function gs_TotalDataStatistics_DelRecordAsync(strTotalDataId: string): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(gs_TotalDataStatistics_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, strTotalDataId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TotalDataStatistics_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TotalDataStatistics_ConstructorName, strThisFuncName);
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
 * @param arrTotalDataId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function gs_TotalDataStatistics_Delgs_TotalDataStatisticssAsync(arrTotalDataId: Array<string>): Promise<number> 
{
const strThisFuncName = "Delgs_TotalDataStatisticssAsync";
const strAction = "Delgs_TotalDataStatisticss";
const strUrl = GetWebApiUrl(gs_TotalDataStatistics_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrTotalDataId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TotalDataStatistics_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TotalDataStatistics_ConstructorName, strThisFuncName);
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
export async function gs_TotalDataStatistics_Delgs_TotalDataStatisticssByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "Delgs_TotalDataStatisticssByCondAsync";
const strAction = "Delgs_TotalDataStatisticssByCond";
const strUrl = GetWebApiUrl(gs_TotalDataStatistics_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TotalDataStatistics_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TotalDataStatistics_ConstructorName, strThisFuncName);
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
 * @param objgs_TotalDataStatisticsEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_TotalDataStatistics_AddNewRecordAsync(objgs_TotalDataStatisticsEN: clsgs_TotalDataStatisticsEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
if (objgs_TotalDataStatisticsEN.totalDataId === null || objgs_TotalDataStatisticsEN.totalDataId === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objgs_TotalDataStatisticsEN);
const strUrl = GetWebApiUrl(gs_TotalDataStatistics_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_TotalDataStatisticsEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TotalDataStatistics_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TotalDataStatistics_ConstructorName, strThisFuncName);
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
 * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
 * @param objgs_TotalDataStatisticsEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_TotalDataStatistics_AddNewRecordWithMaxIdAsync(objgs_TotalDataStatisticsEN: clsgs_TotalDataStatisticsEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithMaxIdAsync";
const strAction = "AddNewRecordWithMaxId";
const strUrl = GetWebApiUrl(gs_TotalDataStatistics_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_TotalDataStatisticsEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TotalDataStatistics_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TotalDataStatistics_ConstructorName, strThisFuncName);
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
 * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
 * @param objgs_TotalDataStatisticsEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function gs_TotalDataStatistics_AddNewRecordWithReturnKeyAsync(objgs_TotalDataStatisticsEN: clsgs_TotalDataStatisticsEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(gs_TotalDataStatistics_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_TotalDataStatisticsEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TotalDataStatistics_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TotalDataStatistics_ConstructorName, strThisFuncName);
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
 * @param objgs_TotalDataStatisticsEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function gs_TotalDataStatistics_AddNewRecordWithReturnKey(objgs_TotalDataStatisticsEN: clsgs_TotalDataStatisticsEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objgs_TotalDataStatisticsEN.totalDataId === null || objgs_TotalDataStatisticsEN.totalDataId === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(gs_TotalDataStatistics_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_TotalDataStatisticsEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TotalDataStatistics_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TotalDataStatistics_ConstructorName, strThisFuncName);
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
 * @param objgs_TotalDataStatisticsEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function gs_TotalDataStatistics_UpdateRecordAsync(objgs_TotalDataStatisticsEN: clsgs_TotalDataStatisticsEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objgs_TotalDataStatisticsEN.sfUpdFldSetStr === undefined || objgs_TotalDataStatisticsEN.sfUpdFldSetStr === null || objgs_TotalDataStatisticsEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_TotalDataStatisticsEN.totalDataId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(gs_TotalDataStatistics_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_TotalDataStatisticsEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TotalDataStatistics_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TotalDataStatistics_ConstructorName, strThisFuncName);
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
 * @param objgs_TotalDataStatisticsEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function gs_TotalDataStatistics_UpdateWithConditionAsync(objgs_TotalDataStatisticsEN: clsgs_TotalDataStatisticsEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objgs_TotalDataStatisticsEN.sfUpdFldSetStr === undefined || objgs_TotalDataStatisticsEN.sfUpdFldSetStr === null || objgs_TotalDataStatisticsEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_TotalDataStatisticsEN.totalDataId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(gs_TotalDataStatistics_Controller, strAction);
objgs_TotalDataStatisticsEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objgs_TotalDataStatisticsEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TotalDataStatistics_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TotalDataStatistics_ConstructorName, strThisFuncName);
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
 * @param objstrTotalDataId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function gs_TotalDataStatistics_IsExistRecord_Cache(objgs_TotalDataStatistics_Cond: clsgs_TotalDataStatisticsEN,strid_CurrEduCls: string) {
const strThisFuncName = "IsExistRecord_Cache";
const arrgs_TotalDataStatisticsObjLst_Cache = await gs_TotalDataStatistics_GetObjLst_Cache(strid_CurrEduCls);
if (arrgs_TotalDataStatisticsObjLst_Cache == null) return false;
let arrgs_TotalDataStatistics_Sel: Array < clsgs_TotalDataStatisticsEN > = arrgs_TotalDataStatisticsObjLst_Cache;
if (objgs_TotalDataStatistics_Cond.sf_FldComparisonOp == null || objgs_TotalDataStatistics_Cond.sf_FldComparisonOp == "") return arrgs_TotalDataStatistics_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_TotalDataStatistics_Cond.sf_FldComparisonOp);
//console.log("clsgs_TotalDataStatisticsWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objgs_TotalDataStatistics_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_TotalDataStatistics_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrgs_TotalDataStatistics_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objgs_TotalDataStatistics_Cond), gs_TotalDataStatistics_ConstructorName, strThisFuncName);
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
export async function gs_TotalDataStatistics_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(gs_TotalDataStatistics_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TotalDataStatistics_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TotalDataStatistics_ConstructorName, strThisFuncName);
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
 * @param strTotalDataId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function gs_TotalDataStatistics_IsExist(strTotalDataId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(gs_TotalDataStatistics_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"TotalDataId": strTotalDataId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TotalDataStatistics_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TotalDataStatistics_ConstructorName, strThisFuncName);
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
 * @param strTotalDataId:所给的关键字
 * @returns 对象
*/
export async function gs_TotalDataStatistics_IsExist_Cache(strTotalDataId:string,strid_CurrEduCls:string) {
const strThisFuncName = "IsExist_Cache";
const arrgs_TotalDataStatisticsObjLst_Cache = await gs_TotalDataStatistics_GetObjLst_Cache(strid_CurrEduCls);
if (arrgs_TotalDataStatisticsObjLst_Cache == null) return false;
try
{
const arrgs_TotalDataStatistics_Sel: Array <clsgs_TotalDataStatisticsEN> = arrgs_TotalDataStatisticsObjLst_Cache.filter(x => x.totalDataId == strTotalDataId);
if (arrgs_TotalDataStatistics_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strTotalDataId, gs_TotalDataStatistics_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param strTotalDataId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function gs_TotalDataStatistics_IsExistAsync(strTotalDataId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(gs_TotalDataStatistics_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strTotalDataId": strTotalDataId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TotalDataStatistics_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TotalDataStatistics_ConstructorName, strThisFuncName);
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
export async function gs_TotalDataStatistics_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(gs_TotalDataStatistics_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TotalDataStatistics_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TotalDataStatistics_ConstructorName, strThisFuncName);
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
 * @param objgs_TotalDataStatistics_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function gs_TotalDataStatistics_GetRecCountByCond_Cache(objgs_TotalDataStatistics_Cond: clsgs_TotalDataStatisticsEN,strid_CurrEduCls: string) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrgs_TotalDataStatisticsObjLst_Cache = await gs_TotalDataStatistics_GetObjLst_Cache(strid_CurrEduCls);
if (arrgs_TotalDataStatisticsObjLst_Cache == null) return 0;
let arrgs_TotalDataStatistics_Sel: Array < clsgs_TotalDataStatisticsEN > = arrgs_TotalDataStatisticsObjLst_Cache;
if (objgs_TotalDataStatistics_Cond.sf_FldComparisonOp == null || objgs_TotalDataStatistics_Cond.sf_FldComparisonOp == "") return arrgs_TotalDataStatistics_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_TotalDataStatistics_Cond.sf_FldComparisonOp);
//console.log("clsgs_TotalDataStatisticsWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objgs_TotalDataStatistics_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_TotalDataStatistics_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrgs_TotalDataStatistics_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objgs_TotalDataStatistics_Cond), gs_TotalDataStatistics_ConstructorName, strThisFuncName);
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
export async function gs_TotalDataStatistics_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(gs_TotalDataStatistics_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TotalDataStatistics_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TotalDataStatistics_ConstructorName, strThisFuncName);
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
export function gs_TotalDataStatistics_GetWebApiUrl(strController: string, strAction: string): string {
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
export function gs_TotalDataStatistics_ReFreshCache(strid_CurrEduCls: string):void
{
const strThisFuncName = "ReFreshCache";

if (IsNullOrEmpty(strid_CurrEduCls) == true)
{
  const strMsg = Format("参数:[strid_CurrEduCls]不能为空！(In clsgs_TotalDataStatisticsWApi.clsgs_TotalDataStatisticsWApi.ReFreshCache)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_CurrEduCls.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(clsgs_TotalDataStatisticsWApi.clsgs_TotalDataStatisticsWApi.ReFreshCache)", strid_CurrEduCls.length);
console.error(strMsg);
throw (strMsg);
}

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = Format("{0}_{1}", clsgs_TotalDataStatisticsEN._CurrTabName, strid_CurrEduCls);
switch (clsgs_TotalDataStatisticsEN.CacheModeId)
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
vgs_TotalDataStatistics_ReFreshThisCache(strid_CurrEduCls);
}

 /**
 * 刷新本类中的缓存.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
 **/
export function gs_TotalDataStatistics_ReFreshThisCache(strid_CurrEduCls: string):void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = Format("{0}_{1}", clsgs_TotalDataStatisticsEN._CurrTabName, strid_CurrEduCls);
switch (clsgs_TotalDataStatisticsEN.CacheModeId)
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
export function gs_TotalDataStatistics_CheckPropertyNew(pobjgs_TotalDataStatisticsEN: clsgs_TotalDataStatisticsEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjgs_TotalDataStatisticsEN.id_CurrEduCls) === true 
 || pobjgs_TotalDataStatisticsEN.id_CurrEduCls.toString()  ===  "0" )
{
 throw new Error("(errid:Watl000058)字段[教学班流水号]不能为空(In 总数据统计)!(clsgs_TotalDataStatisticsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TotalDataStatisticsEN.totalDataTypeId) === true )
{
 throw new Error("(errid:Watl000058)字段[总数据类型Id]不能为空(In 总数据统计)!(clsgs_TotalDataStatisticsBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjgs_TotalDataStatisticsEN.totalDataId) == false && GetStrLen(pobjgs_TotalDataStatisticsEN.totalDataId) > 12)
{
 throw new Error("(errid:Watl000059)字段[TotalDataId(totalDataId)]的长度不能超过12(In 总数据统计(gs_TotalDataStatistics))!值:$(pobjgs_TotalDataStatisticsEN.totalDataId)(clsgs_TotalDataStatisticsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TotalDataStatisticsEN.id_CurrEduCls) == false && GetStrLen(pobjgs_TotalDataStatisticsEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 总数据统计(gs_TotalDataStatistics))!值:$(pobjgs_TotalDataStatisticsEN.id_CurrEduCls)(clsgs_TotalDataStatisticsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TotalDataStatisticsEN.totalDataTypeId) == false && GetStrLen(pobjgs_TotalDataStatisticsEN.totalDataTypeId) > 2)
{
 throw new Error("(errid:Watl000059)字段[总数据类型Id(totalDataTypeId)]的长度不能超过2(In 总数据统计(gs_TotalDataStatistics))!值:$(pobjgs_TotalDataStatisticsEN.totalDataTypeId)(clsgs_TotalDataStatisticsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TotalDataStatisticsEN.tableKey) == false && GetStrLen(pobjgs_TotalDataStatisticsEN.tableKey) > 20)
{
 throw new Error("(errid:Watl000059)字段[表主键(tableKey)]的长度不能超过20(In 总数据统计(gs_TotalDataStatistics))!值:$(pobjgs_TotalDataStatisticsEN.tableKey)(clsgs_TotalDataStatisticsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TotalDataStatisticsEN.dataUser) == false && GetStrLen(pobjgs_TotalDataStatisticsEN.dataUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[数据用户(dataUser)]的长度不能超过20(In 总数据统计(gs_TotalDataStatistics))!值:$(pobjgs_TotalDataStatisticsEN.dataUser)(clsgs_TotalDataStatisticsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TotalDataStatisticsEN.dataAddDate) == false && GetStrLen(pobjgs_TotalDataStatisticsEN.dataAddDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[数据添加日期(dataAddDate)]的长度不能超过20(In 总数据统计(gs_TotalDataStatistics))!值:$(pobjgs_TotalDataStatisticsEN.dataAddDate)(clsgs_TotalDataStatisticsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TotalDataStatisticsEN.updDate) == false && GetStrLen(pobjgs_TotalDataStatisticsEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 总数据统计(gs_TotalDataStatistics))!值:$(pobjgs_TotalDataStatisticsEN.updDate)(clsgs_TotalDataStatisticsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TotalDataStatisticsEN.updUser) == false && GetStrLen(pobjgs_TotalDataStatisticsEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 总数据统计(gs_TotalDataStatistics))!值:$(pobjgs_TotalDataStatisticsEN.updUser)(clsgs_TotalDataStatisticsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TotalDataStatisticsEN.memo) == false && GetStrLen(pobjgs_TotalDataStatisticsEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 总数据统计(gs_TotalDataStatistics))!值:$(pobjgs_TotalDataStatisticsEN.memo)(clsgs_TotalDataStatisticsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TotalDataStatisticsEN.weekTimeRange) == false && GetStrLen(pobjgs_TotalDataStatisticsEN.weekTimeRange) > 100)
{
 throw new Error("(errid:Watl000059)字段[WeekTimeRange(weekTimeRange)]的长度不能超过100(In 总数据统计(gs_TotalDataStatistics))!值:$(pobjgs_TotalDataStatisticsEN.weekTimeRange)(clsgs_TotalDataStatisticsBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjgs_TotalDataStatisticsEN.totalDataId) == false && undefined !== pobjgs_TotalDataStatisticsEN.totalDataId && tzDataType.isString(pobjgs_TotalDataStatisticsEN.totalDataId) === false)
{
 throw new Error("(errid:Watl000060)字段[TotalDataId(totalDataId)]的值:[$(pobjgs_TotalDataStatisticsEN.totalDataId)], 非法，应该为字符型(In 总数据统计(gs_TotalDataStatistics))!(clsgs_TotalDataStatisticsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TotalDataStatisticsEN.id_CurrEduCls) == false && undefined !== pobjgs_TotalDataStatisticsEN.id_CurrEduCls && tzDataType.isString(pobjgs_TotalDataStatisticsEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjgs_TotalDataStatisticsEN.id_CurrEduCls)], 非法，应该为字符型(In 总数据统计(gs_TotalDataStatistics))!(clsgs_TotalDataStatisticsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TotalDataStatisticsEN.totalDataTypeId) == false && undefined !== pobjgs_TotalDataStatisticsEN.totalDataTypeId && tzDataType.isString(pobjgs_TotalDataStatisticsEN.totalDataTypeId) === false)
{
 throw new Error("(errid:Watl000060)字段[总数据类型Id(totalDataTypeId)]的值:[$(pobjgs_TotalDataStatisticsEN.totalDataTypeId)], 非法，应该为字符型(In 总数据统计(gs_TotalDataStatistics))!(clsgs_TotalDataStatisticsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TotalDataStatisticsEN.tableKey) == false && undefined !== pobjgs_TotalDataStatisticsEN.tableKey && tzDataType.isString(pobjgs_TotalDataStatisticsEN.tableKey) === false)
{
 throw new Error("(errid:Watl000060)字段[表主键(tableKey)]的值:[$(pobjgs_TotalDataStatisticsEN.tableKey)], 非法，应该为字符型(In 总数据统计(gs_TotalDataStatistics))!(clsgs_TotalDataStatisticsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TotalDataStatisticsEN.dataUser) == false && undefined !== pobjgs_TotalDataStatisticsEN.dataUser && tzDataType.isString(pobjgs_TotalDataStatisticsEN.dataUser) === false)
{
 throw new Error("(errid:Watl000060)字段[数据用户(dataUser)]的值:[$(pobjgs_TotalDataStatisticsEN.dataUser)], 非法，应该为字符型(In 总数据统计(gs_TotalDataStatistics))!(clsgs_TotalDataStatisticsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TotalDataStatisticsEN.dataAddDate) == false && undefined !== pobjgs_TotalDataStatisticsEN.dataAddDate && tzDataType.isString(pobjgs_TotalDataStatisticsEN.dataAddDate) === false)
{
 throw new Error("(errid:Watl000060)字段[数据添加日期(dataAddDate)]的值:[$(pobjgs_TotalDataStatisticsEN.dataAddDate)], 非法，应该为字符型(In 总数据统计(gs_TotalDataStatistics))!(clsgs_TotalDataStatisticsBL:CheckPropertyNew)");
}
if (null != pobjgs_TotalDataStatisticsEN.month && undefined !== pobjgs_TotalDataStatisticsEN.month && tzDataType.isNumber(pobjgs_TotalDataStatisticsEN.month) === false)
{
 throw new Error("(errid:Watl000060)字段[月(month)]的值:[$(pobjgs_TotalDataStatisticsEN.month)], 非法，应该为数值型(In 总数据统计(gs_TotalDataStatistics))!(clsgs_TotalDataStatisticsBL:CheckPropertyNew)");
}
if (null != pobjgs_TotalDataStatisticsEN.week && undefined !== pobjgs_TotalDataStatisticsEN.week && tzDataType.isNumber(pobjgs_TotalDataStatisticsEN.week) === false)
{
 throw new Error("(errid:Watl000060)字段[周(week)]的值:[$(pobjgs_TotalDataStatisticsEN.week)], 非法，应该为数值型(In 总数据统计(gs_TotalDataStatistics))!(clsgs_TotalDataStatisticsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TotalDataStatisticsEN.updDate) == false && undefined !== pobjgs_TotalDataStatisticsEN.updDate && tzDataType.isString(pobjgs_TotalDataStatisticsEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjgs_TotalDataStatisticsEN.updDate)], 非法，应该为字符型(In 总数据统计(gs_TotalDataStatistics))!(clsgs_TotalDataStatisticsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TotalDataStatisticsEN.updUser) == false && undefined !== pobjgs_TotalDataStatisticsEN.updUser && tzDataType.isString(pobjgs_TotalDataStatisticsEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjgs_TotalDataStatisticsEN.updUser)], 非法，应该为字符型(In 总数据统计(gs_TotalDataStatistics))!(clsgs_TotalDataStatisticsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TotalDataStatisticsEN.memo) == false && undefined !== pobjgs_TotalDataStatisticsEN.memo && tzDataType.isString(pobjgs_TotalDataStatisticsEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjgs_TotalDataStatisticsEN.memo)], 非法，应该为字符型(In 总数据统计(gs_TotalDataStatistics))!(clsgs_TotalDataStatisticsBL:CheckPropertyNew)");
}
if (null != pobjgs_TotalDataStatisticsEN.score && undefined !== pobjgs_TotalDataStatisticsEN.score && tzDataType.isNumber(pobjgs_TotalDataStatisticsEN.score) === false)
{
 throw new Error("(errid:Watl000060)字段[评分(score)]的值:[$(pobjgs_TotalDataStatisticsEN.score)], 非法，应该为数值型(In 总数据统计(gs_TotalDataStatistics))!(clsgs_TotalDataStatisticsBL:CheckPropertyNew)");
}
if (null != pobjgs_TotalDataStatisticsEN.teaScore && undefined !== pobjgs_TotalDataStatisticsEN.teaScore && tzDataType.isNumber(pobjgs_TotalDataStatisticsEN.teaScore) === false)
{
 throw new Error("(errid:Watl000060)字段[教师评分(teaScore)]的值:[$(pobjgs_TotalDataStatisticsEN.teaScore)], 非法，应该为数值型(In 总数据统计(gs_TotalDataStatistics))!(clsgs_TotalDataStatisticsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TotalDataStatisticsEN.weekTimeRange) == false && undefined !== pobjgs_TotalDataStatisticsEN.weekTimeRange && tzDataType.isString(pobjgs_TotalDataStatisticsEN.weekTimeRange) === false)
{
 throw new Error("(errid:Watl000060)字段[WeekTimeRange(weekTimeRange)]的值:[$(pobjgs_TotalDataStatisticsEN.weekTimeRange)], 非法，应该为字符型(In 总数据统计(gs_TotalDataStatistics))!(clsgs_TotalDataStatisticsBL:CheckPropertyNew)");
}
if (null != pobjgs_TotalDataStatisticsEN.stuScore && undefined !== pobjgs_TotalDataStatisticsEN.stuScore && tzDataType.isNumber(pobjgs_TotalDataStatisticsEN.stuScore) === false)
{
 throw new Error("(errid:Watl000060)字段[学生平均分(stuScore)]的值:[$(pobjgs_TotalDataStatisticsEN.stuScore)], 非法，应该为数值型(In 总数据统计(gs_TotalDataStatistics))!(clsgs_TotalDataStatisticsBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjgs_TotalDataStatisticsEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function gs_TotalDataStatistics_CheckProperty4Update (pobjgs_TotalDataStatisticsEN: clsgs_TotalDataStatisticsEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjgs_TotalDataStatisticsEN.totalDataId) == false && GetStrLen(pobjgs_TotalDataStatisticsEN.totalDataId) > 12)
{
 throw new Error("(errid:Watl000062)字段[TotalDataId(totalDataId)]的长度不能超过12(In 总数据统计(gs_TotalDataStatistics))!值:$(pobjgs_TotalDataStatisticsEN.totalDataId)(clsgs_TotalDataStatisticsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TotalDataStatisticsEN.id_CurrEduCls) == false && GetStrLen(pobjgs_TotalDataStatisticsEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 总数据统计(gs_TotalDataStatistics))!值:$(pobjgs_TotalDataStatisticsEN.id_CurrEduCls)(clsgs_TotalDataStatisticsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TotalDataStatisticsEN.totalDataTypeId) == false && GetStrLen(pobjgs_TotalDataStatisticsEN.totalDataTypeId) > 2)
{
 throw new Error("(errid:Watl000062)字段[总数据类型Id(totalDataTypeId)]的长度不能超过2(In 总数据统计(gs_TotalDataStatistics))!值:$(pobjgs_TotalDataStatisticsEN.totalDataTypeId)(clsgs_TotalDataStatisticsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TotalDataStatisticsEN.tableKey) == false && GetStrLen(pobjgs_TotalDataStatisticsEN.tableKey) > 20)
{
 throw new Error("(errid:Watl000062)字段[表主键(tableKey)]的长度不能超过20(In 总数据统计(gs_TotalDataStatistics))!值:$(pobjgs_TotalDataStatisticsEN.tableKey)(clsgs_TotalDataStatisticsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TotalDataStatisticsEN.dataUser) == false && GetStrLen(pobjgs_TotalDataStatisticsEN.dataUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[数据用户(dataUser)]的长度不能超过20(In 总数据统计(gs_TotalDataStatistics))!值:$(pobjgs_TotalDataStatisticsEN.dataUser)(clsgs_TotalDataStatisticsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TotalDataStatisticsEN.dataAddDate) == false && GetStrLen(pobjgs_TotalDataStatisticsEN.dataAddDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[数据添加日期(dataAddDate)]的长度不能超过20(In 总数据统计(gs_TotalDataStatistics))!值:$(pobjgs_TotalDataStatisticsEN.dataAddDate)(clsgs_TotalDataStatisticsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TotalDataStatisticsEN.updDate) == false && GetStrLen(pobjgs_TotalDataStatisticsEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 总数据统计(gs_TotalDataStatistics))!值:$(pobjgs_TotalDataStatisticsEN.updDate)(clsgs_TotalDataStatisticsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TotalDataStatisticsEN.updUser) == false && GetStrLen(pobjgs_TotalDataStatisticsEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 总数据统计(gs_TotalDataStatistics))!值:$(pobjgs_TotalDataStatisticsEN.updUser)(clsgs_TotalDataStatisticsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TotalDataStatisticsEN.memo) == false && GetStrLen(pobjgs_TotalDataStatisticsEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 总数据统计(gs_TotalDataStatistics))!值:$(pobjgs_TotalDataStatisticsEN.memo)(clsgs_TotalDataStatisticsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TotalDataStatisticsEN.weekTimeRange) == false && GetStrLen(pobjgs_TotalDataStatisticsEN.weekTimeRange) > 100)
{
 throw new Error("(errid:Watl000062)字段[WeekTimeRange(weekTimeRange)]的长度不能超过100(In 总数据统计(gs_TotalDataStatistics))!值:$(pobjgs_TotalDataStatisticsEN.weekTimeRange)(clsgs_TotalDataStatisticsBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjgs_TotalDataStatisticsEN.totalDataId) == false && undefined !== pobjgs_TotalDataStatisticsEN.totalDataId && tzDataType.isString(pobjgs_TotalDataStatisticsEN.totalDataId) === false)
{
 throw new Error("(errid:Watl000063)字段[TotalDataId(totalDataId)]的值:[$(pobjgs_TotalDataStatisticsEN.totalDataId)], 非法，应该为字符型(In 总数据统计(gs_TotalDataStatistics))!(clsgs_TotalDataStatisticsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TotalDataStatisticsEN.id_CurrEduCls) == false && undefined !== pobjgs_TotalDataStatisticsEN.id_CurrEduCls && tzDataType.isString(pobjgs_TotalDataStatisticsEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjgs_TotalDataStatisticsEN.id_CurrEduCls)], 非法，应该为字符型(In 总数据统计(gs_TotalDataStatistics))!(clsgs_TotalDataStatisticsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TotalDataStatisticsEN.totalDataTypeId) == false && undefined !== pobjgs_TotalDataStatisticsEN.totalDataTypeId && tzDataType.isString(pobjgs_TotalDataStatisticsEN.totalDataTypeId) === false)
{
 throw new Error("(errid:Watl000063)字段[总数据类型Id(totalDataTypeId)]的值:[$(pobjgs_TotalDataStatisticsEN.totalDataTypeId)], 非法，应该为字符型(In 总数据统计(gs_TotalDataStatistics))!(clsgs_TotalDataStatisticsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TotalDataStatisticsEN.tableKey) == false && undefined !== pobjgs_TotalDataStatisticsEN.tableKey && tzDataType.isString(pobjgs_TotalDataStatisticsEN.tableKey) === false)
{
 throw new Error("(errid:Watl000063)字段[表主键(tableKey)]的值:[$(pobjgs_TotalDataStatisticsEN.tableKey)], 非法，应该为字符型(In 总数据统计(gs_TotalDataStatistics))!(clsgs_TotalDataStatisticsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TotalDataStatisticsEN.dataUser) == false && undefined !== pobjgs_TotalDataStatisticsEN.dataUser && tzDataType.isString(pobjgs_TotalDataStatisticsEN.dataUser) === false)
{
 throw new Error("(errid:Watl000063)字段[数据用户(dataUser)]的值:[$(pobjgs_TotalDataStatisticsEN.dataUser)], 非法，应该为字符型(In 总数据统计(gs_TotalDataStatistics))!(clsgs_TotalDataStatisticsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TotalDataStatisticsEN.dataAddDate) == false && undefined !== pobjgs_TotalDataStatisticsEN.dataAddDate && tzDataType.isString(pobjgs_TotalDataStatisticsEN.dataAddDate) === false)
{
 throw new Error("(errid:Watl000063)字段[数据添加日期(dataAddDate)]的值:[$(pobjgs_TotalDataStatisticsEN.dataAddDate)], 非法，应该为字符型(In 总数据统计(gs_TotalDataStatistics))!(clsgs_TotalDataStatisticsBL:CheckProperty4Update)");
}
if (null != pobjgs_TotalDataStatisticsEN.month && undefined !== pobjgs_TotalDataStatisticsEN.month && tzDataType.isNumber(pobjgs_TotalDataStatisticsEN.month) === false)
{
 throw new Error("(errid:Watl000063)字段[月(month)]的值:[$(pobjgs_TotalDataStatisticsEN.month)], 非法，应该为数值型(In 总数据统计(gs_TotalDataStatistics))!(clsgs_TotalDataStatisticsBL:CheckProperty4Update)");
}
if (null != pobjgs_TotalDataStatisticsEN.week && undefined !== pobjgs_TotalDataStatisticsEN.week && tzDataType.isNumber(pobjgs_TotalDataStatisticsEN.week) === false)
{
 throw new Error("(errid:Watl000063)字段[周(week)]的值:[$(pobjgs_TotalDataStatisticsEN.week)], 非法，应该为数值型(In 总数据统计(gs_TotalDataStatistics))!(clsgs_TotalDataStatisticsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TotalDataStatisticsEN.updDate) == false && undefined !== pobjgs_TotalDataStatisticsEN.updDate && tzDataType.isString(pobjgs_TotalDataStatisticsEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjgs_TotalDataStatisticsEN.updDate)], 非法，应该为字符型(In 总数据统计(gs_TotalDataStatistics))!(clsgs_TotalDataStatisticsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TotalDataStatisticsEN.updUser) == false && undefined !== pobjgs_TotalDataStatisticsEN.updUser && tzDataType.isString(pobjgs_TotalDataStatisticsEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjgs_TotalDataStatisticsEN.updUser)], 非法，应该为字符型(In 总数据统计(gs_TotalDataStatistics))!(clsgs_TotalDataStatisticsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TotalDataStatisticsEN.memo) == false && undefined !== pobjgs_TotalDataStatisticsEN.memo && tzDataType.isString(pobjgs_TotalDataStatisticsEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjgs_TotalDataStatisticsEN.memo)], 非法，应该为字符型(In 总数据统计(gs_TotalDataStatistics))!(clsgs_TotalDataStatisticsBL:CheckProperty4Update)");
}
if (null != pobjgs_TotalDataStatisticsEN.score && undefined !== pobjgs_TotalDataStatisticsEN.score && tzDataType.isNumber(pobjgs_TotalDataStatisticsEN.score) === false)
{
 throw new Error("(errid:Watl000063)字段[评分(score)]的值:[$(pobjgs_TotalDataStatisticsEN.score)], 非法，应该为数值型(In 总数据统计(gs_TotalDataStatistics))!(clsgs_TotalDataStatisticsBL:CheckProperty4Update)");
}
if (null != pobjgs_TotalDataStatisticsEN.teaScore && undefined !== pobjgs_TotalDataStatisticsEN.teaScore && tzDataType.isNumber(pobjgs_TotalDataStatisticsEN.teaScore) === false)
{
 throw new Error("(errid:Watl000063)字段[教师评分(teaScore)]的值:[$(pobjgs_TotalDataStatisticsEN.teaScore)], 非法，应该为数值型(In 总数据统计(gs_TotalDataStatistics))!(clsgs_TotalDataStatisticsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TotalDataStatisticsEN.weekTimeRange) == false && undefined !== pobjgs_TotalDataStatisticsEN.weekTimeRange && tzDataType.isString(pobjgs_TotalDataStatisticsEN.weekTimeRange) === false)
{
 throw new Error("(errid:Watl000063)字段[WeekTimeRange(weekTimeRange)]的值:[$(pobjgs_TotalDataStatisticsEN.weekTimeRange)], 非法，应该为字符型(In 总数据统计(gs_TotalDataStatistics))!(clsgs_TotalDataStatisticsBL:CheckProperty4Update)");
}
if (null != pobjgs_TotalDataStatisticsEN.stuScore && undefined !== pobjgs_TotalDataStatisticsEN.stuScore && tzDataType.isNumber(pobjgs_TotalDataStatisticsEN.stuScore) === false)
{
 throw new Error("(errid:Watl000063)字段[学生平均分(stuScore)]的值:[$(pobjgs_TotalDataStatisticsEN.stuScore)], 非法，应该为数值型(In 总数据统计(gs_TotalDataStatistics))!(clsgs_TotalDataStatisticsBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (IsNullOrEmpty(pobjgs_TotalDataStatisticsEN.totalDataId) === true )
{
 throw new Error("(errid:Watl000064)字段[TotalDataId]不能为空(In 总数据统计)!(clsgs_TotalDataStatisticsBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjgs_TotalDataStatisticsEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function gs_TotalDataStatistics_GetJSONStrByObj (pobjgs_TotalDataStatisticsEN: clsgs_TotalDataStatisticsEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjgs_TotalDataStatisticsEN.sfUpdFldSetStr = pobjgs_TotalDataStatisticsEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjgs_TotalDataStatisticsEN);
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
export function gs_TotalDataStatistics_GetObjLstByJSONStr (strJSON: string): Array<clsgs_TotalDataStatisticsEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrgs_TotalDataStatisticsObjLst = new Array<clsgs_TotalDataStatisticsEN>();
if (strJSON === "")
{
return arrgs_TotalDataStatisticsObjLst;
}
try
{
arrgs_TotalDataStatisticsObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrgs_TotalDataStatisticsObjLst;
}
return arrgs_TotalDataStatisticsObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrgs_TotalDataStatisticsObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function gs_TotalDataStatistics_GetObjLstByJSONObjLst (arrgs_TotalDataStatisticsObjLstS: Array<clsgs_TotalDataStatisticsEN>): Array<clsgs_TotalDataStatisticsEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrgs_TotalDataStatisticsObjLst = new Array<clsgs_TotalDataStatisticsEN>();
for (const objInFor of arrgs_TotalDataStatisticsObjLstS) {
const obj1 = gs_TotalDataStatistics_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrgs_TotalDataStatisticsObjLst.push(obj1);
}
return arrgs_TotalDataStatisticsObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function gs_TotalDataStatistics_GetObjByJSONStr (strJSON: string): clsgs_TotalDataStatisticsEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjgs_TotalDataStatisticsEN = new clsgs_TotalDataStatisticsEN();
if (strJSON === "")
{
return pobjgs_TotalDataStatisticsEN;
}
try
{
pobjgs_TotalDataStatisticsEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjgs_TotalDataStatisticsEN;
}
return pobjgs_TotalDataStatisticsEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function gs_TotalDataStatistics_GetCombineCondition(objgs_TotalDataStatistics_Cond: clsgs_TotalDataStatisticsEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objgs_TotalDataStatistics_Cond.dicFldComparisonOp, clsgs_TotalDataStatisticsEN.con_TotalDataId) == true)
{
const strComparisonOp_TotalDataId:string = objgs_TotalDataStatistics_Cond.dicFldComparisonOp[clsgs_TotalDataStatisticsEN.con_TotalDataId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TotalDataStatisticsEN.con_TotalDataId, objgs_TotalDataStatistics_Cond.totalDataId, strComparisonOp_TotalDataId);
}
if (Object.prototype.hasOwnProperty.call(objgs_TotalDataStatistics_Cond.dicFldComparisonOp, clsgs_TotalDataStatisticsEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objgs_TotalDataStatistics_Cond.dicFldComparisonOp[clsgs_TotalDataStatisticsEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TotalDataStatisticsEN.con_id_CurrEduCls, objgs_TotalDataStatistics_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (Object.prototype.hasOwnProperty.call(objgs_TotalDataStatistics_Cond.dicFldComparisonOp, clsgs_TotalDataStatisticsEN.con_TotalDataTypeId) == true)
{
const strComparisonOp_TotalDataTypeId:string = objgs_TotalDataStatistics_Cond.dicFldComparisonOp[clsgs_TotalDataStatisticsEN.con_TotalDataTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TotalDataStatisticsEN.con_TotalDataTypeId, objgs_TotalDataStatistics_Cond.totalDataTypeId, strComparisonOp_TotalDataTypeId);
}
if (Object.prototype.hasOwnProperty.call(objgs_TotalDataStatistics_Cond.dicFldComparisonOp, clsgs_TotalDataStatisticsEN.con_TableKey) == true)
{
const strComparisonOp_TableKey:string = objgs_TotalDataStatistics_Cond.dicFldComparisonOp[clsgs_TotalDataStatisticsEN.con_TableKey];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TotalDataStatisticsEN.con_TableKey, objgs_TotalDataStatistics_Cond.tableKey, strComparisonOp_TableKey);
}
if (Object.prototype.hasOwnProperty.call(objgs_TotalDataStatistics_Cond.dicFldComparisonOp, clsgs_TotalDataStatisticsEN.con_DataUser) == true)
{
const strComparisonOp_DataUser:string = objgs_TotalDataStatistics_Cond.dicFldComparisonOp[clsgs_TotalDataStatisticsEN.con_DataUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TotalDataStatisticsEN.con_DataUser, objgs_TotalDataStatistics_Cond.dataUser, strComparisonOp_DataUser);
}
if (Object.prototype.hasOwnProperty.call(objgs_TotalDataStatistics_Cond.dicFldComparisonOp, clsgs_TotalDataStatisticsEN.con_DataAddDate) == true)
{
const strComparisonOp_DataAddDate:string = objgs_TotalDataStatistics_Cond.dicFldComparisonOp[clsgs_TotalDataStatisticsEN.con_DataAddDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TotalDataStatisticsEN.con_DataAddDate, objgs_TotalDataStatistics_Cond.dataAddDate, strComparisonOp_DataAddDate);
}
if (Object.prototype.hasOwnProperty.call(objgs_TotalDataStatistics_Cond.dicFldComparisonOp, clsgs_TotalDataStatisticsEN.con_Month) == true)
{
const strComparisonOp_Month:string = objgs_TotalDataStatistics_Cond.dicFldComparisonOp[clsgs_TotalDataStatisticsEN.con_Month];
strWhereCond += Format(" And {0} {2} {1}", clsgs_TotalDataStatisticsEN.con_Month, objgs_TotalDataStatistics_Cond.month, strComparisonOp_Month);
}
if (Object.prototype.hasOwnProperty.call(objgs_TotalDataStatistics_Cond.dicFldComparisonOp, clsgs_TotalDataStatisticsEN.con_Week) == true)
{
const strComparisonOp_Week:string = objgs_TotalDataStatistics_Cond.dicFldComparisonOp[clsgs_TotalDataStatisticsEN.con_Week];
strWhereCond += Format(" And {0} {2} {1}", clsgs_TotalDataStatisticsEN.con_Week, objgs_TotalDataStatistics_Cond.week, strComparisonOp_Week);
}
if (Object.prototype.hasOwnProperty.call(objgs_TotalDataStatistics_Cond.dicFldComparisonOp, clsgs_TotalDataStatisticsEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objgs_TotalDataStatistics_Cond.dicFldComparisonOp[clsgs_TotalDataStatisticsEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TotalDataStatisticsEN.con_UpdDate, objgs_TotalDataStatistics_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objgs_TotalDataStatistics_Cond.dicFldComparisonOp, clsgs_TotalDataStatisticsEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objgs_TotalDataStatistics_Cond.dicFldComparisonOp[clsgs_TotalDataStatisticsEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TotalDataStatisticsEN.con_UpdUser, objgs_TotalDataStatistics_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objgs_TotalDataStatistics_Cond.dicFldComparisonOp, clsgs_TotalDataStatisticsEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objgs_TotalDataStatistics_Cond.dicFldComparisonOp[clsgs_TotalDataStatisticsEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TotalDataStatisticsEN.con_Memo, objgs_TotalDataStatistics_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objgs_TotalDataStatistics_Cond.dicFldComparisonOp, clsgs_TotalDataStatisticsEN.con_Score) == true)
{
const strComparisonOp_Score:string = objgs_TotalDataStatistics_Cond.dicFldComparisonOp[clsgs_TotalDataStatisticsEN.con_Score];
strWhereCond += Format(" And {0} {2} {1}", clsgs_TotalDataStatisticsEN.con_Score, objgs_TotalDataStatistics_Cond.score, strComparisonOp_Score);
}
if (Object.prototype.hasOwnProperty.call(objgs_TotalDataStatistics_Cond.dicFldComparisonOp, clsgs_TotalDataStatisticsEN.con_TeaScore) == true)
{
const strComparisonOp_TeaScore:string = objgs_TotalDataStatistics_Cond.dicFldComparisonOp[clsgs_TotalDataStatisticsEN.con_TeaScore];
strWhereCond += Format(" And {0} {2} {1}", clsgs_TotalDataStatisticsEN.con_TeaScore, objgs_TotalDataStatistics_Cond.teaScore, strComparisonOp_TeaScore);
}
if (Object.prototype.hasOwnProperty.call(objgs_TotalDataStatistics_Cond.dicFldComparisonOp, clsgs_TotalDataStatisticsEN.con_WeekTimeRange) == true)
{
const strComparisonOp_WeekTimeRange:string = objgs_TotalDataStatistics_Cond.dicFldComparisonOp[clsgs_TotalDataStatisticsEN.con_WeekTimeRange];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TotalDataStatisticsEN.con_WeekTimeRange, objgs_TotalDataStatistics_Cond.weekTimeRange, strComparisonOp_WeekTimeRange);
}
if (Object.prototype.hasOwnProperty.call(objgs_TotalDataStatistics_Cond.dicFldComparisonOp, clsgs_TotalDataStatisticsEN.con_StuScore) == true)
{
const strComparisonOp_StuScore:string = objgs_TotalDataStatistics_Cond.dicFldComparisonOp[clsgs_TotalDataStatisticsEN.con_StuScore];
strWhereCond += Format(" And {0} {2} {1}", clsgs_TotalDataStatisticsEN.con_StuScore, objgs_TotalDataStatistics_Cond.stuScore, strComparisonOp_StuScore);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--gs_TotalDataStatistics(总数据统计),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param strTotalDataTypeId: 总数据类型Id(要求唯一的字段)
 * @param strTableKey: 表主键(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function gs_TotalDataStatistics_GetUniCondStr_TotalDataTypeId_TableKey(objgs_TotalDataStatisticsEN: clsgs_TotalDataStatisticsEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and TotalDataTypeId = '{0}'", objgs_TotalDataStatisticsEN.totalDataTypeId);
 strWhereCond +=  Format(" and TableKey = '{0}'", objgs_TotalDataStatisticsEN.tableKey);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--gs_TotalDataStatistics(总数据统计),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param strTotalDataTypeId: 总数据类型Id(要求唯一的字段)
 * @param strTableKey: 表主键(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function gs_TotalDataStatistics_GetUniCondStr4Update_TotalDataTypeId_TableKey(objgs_TotalDataStatisticsEN: clsgs_TotalDataStatisticsEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and TotalDataId <> '{0}'", objgs_TotalDataStatisticsEN.totalDataId);
 strWhereCond +=  Format(" and TotalDataTypeId = '{0}'", objgs_TotalDataStatisticsEN.totalDataTypeId);
 strWhereCond +=  Format(" and TableKey = '{0}'", objgs_TotalDataStatisticsEN.tableKey);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objgs_TotalDataStatisticsENS:源对象
 * @param objgs_TotalDataStatisticsENT:目标对象
*/
export function gs_TotalDataStatistics_CopyObjTo(objgs_TotalDataStatisticsENS: clsgs_TotalDataStatisticsEN , objgs_TotalDataStatisticsENT: clsgs_TotalDataStatisticsEN ): void 
{
objgs_TotalDataStatisticsENT.totalDataId = objgs_TotalDataStatisticsENS.totalDataId; //TotalDataId
objgs_TotalDataStatisticsENT.id_CurrEduCls = objgs_TotalDataStatisticsENS.id_CurrEduCls; //教学班流水号
objgs_TotalDataStatisticsENT.totalDataTypeId = objgs_TotalDataStatisticsENS.totalDataTypeId; //总数据类型Id
objgs_TotalDataStatisticsENT.tableKey = objgs_TotalDataStatisticsENS.tableKey; //表主键
objgs_TotalDataStatisticsENT.dataUser = objgs_TotalDataStatisticsENS.dataUser; //数据用户
objgs_TotalDataStatisticsENT.dataAddDate = objgs_TotalDataStatisticsENS.dataAddDate; //数据添加日期
objgs_TotalDataStatisticsENT.month = objgs_TotalDataStatisticsENS.month; //月
objgs_TotalDataStatisticsENT.week = objgs_TotalDataStatisticsENS.week; //周
objgs_TotalDataStatisticsENT.updDate = objgs_TotalDataStatisticsENS.updDate; //修改日期
objgs_TotalDataStatisticsENT.updUser = objgs_TotalDataStatisticsENS.updUser; //修改人
objgs_TotalDataStatisticsENT.memo = objgs_TotalDataStatisticsENS.memo; //备注
objgs_TotalDataStatisticsENT.score = objgs_TotalDataStatisticsENS.score; //评分
objgs_TotalDataStatisticsENT.teaScore = objgs_TotalDataStatisticsENS.teaScore; //教师评分
objgs_TotalDataStatisticsENT.weekTimeRange = objgs_TotalDataStatisticsENS.weekTimeRange; //WeekTimeRange
objgs_TotalDataStatisticsENT.stuScore = objgs_TotalDataStatisticsENS.stuScore; //学生平均分
objgs_TotalDataStatisticsENT.sfUpdFldSetStr = objgs_TotalDataStatisticsENS.updFldString; //sfUpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objgs_TotalDataStatisticsENS:源对象
 * @param objgs_TotalDataStatisticsENT:目标对象
*/
export function gs_TotalDataStatistics_GetObjFromJsonObj(objgs_TotalDataStatisticsENS: clsgs_TotalDataStatisticsEN): clsgs_TotalDataStatisticsEN 
{
 const objgs_TotalDataStatisticsENT: clsgs_TotalDataStatisticsEN = new clsgs_TotalDataStatisticsEN();
ObjectAssign(objgs_TotalDataStatisticsENT, objgs_TotalDataStatisticsENS);
 return objgs_TotalDataStatisticsENT;
}