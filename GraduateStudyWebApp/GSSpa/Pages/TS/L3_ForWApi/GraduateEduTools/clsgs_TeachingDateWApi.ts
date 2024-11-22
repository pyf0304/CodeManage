﻿
 /**
 * 类名:clsgs_TeachingDateWApi
 * 表名:gs_TeachingDate(01120684)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:47:13
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
 * 教学班日期范围(gs_TeachingDate)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clsgs_TeachingDateEN } from "../../L0_Entity/GraduateEduTools/clsgs_TeachingDateEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { tzDataType } from "../../PubFun/jsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const gs_TeachingDate_Controller = "gs_TeachingDateApi";
 export const gs_TeachingDate_ConstructorName = "gs_TeachingDate";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngmId:关键字
 * @returns 对象
 **/
export async function gs_TeachingDate_GetObjBymIdAsync(lngmId: number): Promise<clsgs_TeachingDateEN>  
{
const strThisFuncName = "GetObjBymIdAsync";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In GetObjBymIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjBymId";
const strUrl = GetWebApiUrl(gs_TeachingDate_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_TeachingDate_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objgs_TeachingDate = gs_TeachingDate_GetObjFromJsonObj(returnObj);
return objgs_TeachingDate;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TeachingDate_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TeachingDate_ConstructorName, strThisFuncName);
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
export async function gs_TeachingDate_GetObjBymId_Cache(lngmId:number,strid_CurrEduCls:string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjBymId_Cache";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In GetObjBymId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
const arrgs_TeachingDateObjLst_Cache = await gs_TeachingDate_GetObjLst_Cache(strid_CurrEduCls);
try
{
const arrgs_TeachingDate_Sel: Array <clsgs_TeachingDateEN> = arrgs_TeachingDateObjLst_Cache.filter(x => x.mId == lngmId);
let objgs_TeachingDate: clsgs_TeachingDateEN;
if (arrgs_TeachingDate_Sel.length > 0)
{
objgs_TeachingDate = arrgs_TeachingDate_Sel[0];
return objgs_TeachingDate;
}
else
{
if (bolTryAsyncOnce == true)
{
objgs_TeachingDate = await gs_TeachingDate_GetObjBymIdAsync(lngmId);
if (objgs_TeachingDate != null)
{
gs_TeachingDate_ReFreshThisCache(strid_CurrEduCls);
return objgs_TeachingDate;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, gs_TeachingDate_ConstructorName, strThisFuncName);
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
export async function gs_TeachingDate_GetObjBymId_localStorage(lngmId: number) {
const strThisFuncName = "GetObjBymId_localStorage";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In GetObjBymId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
const strKey = Format("{0}_{1}", clsgs_TeachingDateEN._CurrTabName, lngmId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objgs_TeachingDate_Cache: clsgs_TeachingDateEN = JSON.parse(strTempObj);
return objgs_TeachingDate_Cache;
}
try
{
const objgs_TeachingDate = await gs_TeachingDate_GetObjBymIdAsync(lngmId);
if (objgs_TeachingDate != null)
{
localStorage.setItem(strKey, JSON.stringify(objgs_TeachingDate));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objgs_TeachingDate;
}
return objgs_TeachingDate;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, gs_TeachingDate_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objgs_TeachingDate:所给的对象
 * @returns 对象
*/
export async function gs_TeachingDate_UpdateObjInLst_Cache(objgs_TeachingDate: clsgs_TeachingDateEN,strid_CurrEduCls: string) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrgs_TeachingDateObjLst_Cache = await gs_TeachingDate_GetObjLst_Cache(strid_CurrEduCls);
const obj = arrgs_TeachingDateObjLst_Cache.find(x => x.mId == objgs_TeachingDate.mId);
if (obj != null)
{
objgs_TeachingDate.mId = obj.mId;
ObjectAssign( obj, objgs_TeachingDate);
}
else
{
arrgs_TeachingDateObjLst_Cache.push(objgs_TeachingDate);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, gs_TeachingDate_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
}
/*该表没有名称字段，不能生成此函数！*/

/**
 * 映射函数。根据表映射把输入字段值，映射成输出字段值
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
 * @param strInFldName:输入字段名
 * @param strOutFldName:输出字段名
 * @param strInValue:输入字段值
 @param strid_CurrEduCls:缓存的分类字段
 * @returns 返回一个输出字段值
*/
export async function gs_TeachingDate_func(strInFldName:string , strOutFldName:string , strInValue:number , strid_CurrEduCls_C: string)
{
//const strThisFuncName = "func";

if (IsNullOrEmpty(strid_CurrEduCls_C) == true)
{
  const strMsg = Format("参数:[strid_CurrEduCls_C]不能为空！(In func)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_CurrEduCls_C.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！", strid_CurrEduCls_C.length);
console.error(strMsg);
throw (strMsg);
}

if (strInFldName != clsgs_TeachingDateEN.con_mId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsgs_TeachingDateEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clsgs_TeachingDateEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const lngmId = Number(strInValue);
if (lngmId == 0)
{
return "";
}
const objgs_TeachingDate = await gs_TeachingDate_GetObjBymId_Cache(lngmId , strid_CurrEduCls_C);
if (objgs_TeachingDate == null) return "";
return objgs_TeachingDate.GetFldValue(strOutFldName).toString();
}

/**
 * 排序函数。根据关键字字段的值进行比较
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
 * @param a:比较的第1个对象
 * @param  b:比较的第1个对象
 * @returns 返回两个对象比较的结果
*/
export function gs_TeachingDate_SortFun_Defa(a:clsgs_TeachingDateEN , b:clsgs_TeachingDateEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.mId-b.mId;
}
/**
 * 排序函数。根据表对象中随机两个字段的值进行比较
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
 * @param  a:比较的第1个对象
 * @param  b:比较的第1个对象
 * @returns 返回两个对象比较的结果
*/
export function gs_TeachingDate_SortFun_Defa_2Fld(a:clsgs_TeachingDateEN , b:clsgs_TeachingDateEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.id_CurrEduCls == b.id_CurrEduCls) return a.startDate.localeCompare(b.startDate);
else return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}

/**
 * 排序函数。根据关键字字段的值进行比较
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
 * @param a:比较的第1个对象
 * @param  b:比较的第1个对象
 * @returns 返回两个对象比较的结果
*/
export function gs_TeachingDate_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsgs_TeachingDateEN.con_mId:
return (a: clsgs_TeachingDateEN, b: clsgs_TeachingDateEN) => {
return a.mId-b.mId;
}
case clsgs_TeachingDateEN.con_id_CurrEduCls:
return (a: clsgs_TeachingDateEN, b: clsgs_TeachingDateEN) => {
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
case clsgs_TeachingDateEN.con_StartDate:
return (a: clsgs_TeachingDateEN, b: clsgs_TeachingDateEN) => {
return a.startDate.localeCompare(b.startDate);
}
case clsgs_TeachingDateEN.con_EndDate:
return (a: clsgs_TeachingDateEN, b: clsgs_TeachingDateEN) => {
return a.endDate.localeCompare(b.endDate);
}
case clsgs_TeachingDateEN.con_UpdDate:
return (a: clsgs_TeachingDateEN, b: clsgs_TeachingDateEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsgs_TeachingDateEN.con_UpdUser:
return (a: clsgs_TeachingDateEN, b: clsgs_TeachingDateEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsgs_TeachingDateEN.con_Memo:
return (a: clsgs_TeachingDateEN, b: clsgs_TeachingDateEN) => {
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_TeachingDate]中不存在！(in ${ gs_TeachingDate_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsgs_TeachingDateEN.con_mId:
return (a: clsgs_TeachingDateEN, b: clsgs_TeachingDateEN) => {
return b.mId-a.mId;
}
case clsgs_TeachingDateEN.con_id_CurrEduCls:
return (a: clsgs_TeachingDateEN, b: clsgs_TeachingDateEN) => {
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
case clsgs_TeachingDateEN.con_StartDate:
return (a: clsgs_TeachingDateEN, b: clsgs_TeachingDateEN) => {
return b.startDate.localeCompare(a.startDate);
}
case clsgs_TeachingDateEN.con_EndDate:
return (a: clsgs_TeachingDateEN, b: clsgs_TeachingDateEN) => {
return b.endDate.localeCompare(a.endDate);
}
case clsgs_TeachingDateEN.con_UpdDate:
return (a: clsgs_TeachingDateEN, b: clsgs_TeachingDateEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsgs_TeachingDateEN.con_UpdUser:
return (a: clsgs_TeachingDateEN, b: clsgs_TeachingDateEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsgs_TeachingDateEN.con_Memo:
return (a: clsgs_TeachingDateEN, b: clsgs_TeachingDateEN) => {
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_TeachingDate]中不存在！(in ${ gs_TeachingDate_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
}

/**
 * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
 * @param strKey:比较的关键字段名称
 * @param value:给定值
 * @returns 返回对象的字段值是否等于给定值
*/
export async function gs_TeachingDate_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsgs_TeachingDateEN.con_mId:
return (obj: clsgs_TeachingDateEN) => {
return obj.mId === value;
}
case clsgs_TeachingDateEN.con_id_CurrEduCls:
return (obj: clsgs_TeachingDateEN) => {
return obj.id_CurrEduCls === value;
}
case clsgs_TeachingDateEN.con_StartDate:
return (obj: clsgs_TeachingDateEN) => {
return obj.startDate === value;
}
case clsgs_TeachingDateEN.con_EndDate:
return (obj: clsgs_TeachingDateEN) => {
return obj.endDate === value;
}
case clsgs_TeachingDateEN.con_UpdDate:
return (obj: clsgs_TeachingDateEN) => {
return obj.updDate === value;
}
case clsgs_TeachingDateEN.con_UpdUser:
return (obj: clsgs_TeachingDateEN) => {
return obj.updUser === value;
}
case clsgs_TeachingDateEN.con_Memo:
return (obj: clsgs_TeachingDateEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_TeachingDate]中不存在！(in ${ gs_TeachingDate_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
}

 /**
 * 根据条件获取满足条件的第一条记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
 * @param strWhereCond:条件
 * @returns 返回的第一条记录的关键字值
 **/
export async function gs_TeachingDate_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(gs_TeachingDate_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TeachingDate_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TeachingDate_ConstructorName, strThisFuncName);
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
export async function gs_TeachingDate_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(gs_TeachingDate_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TeachingDate_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TeachingDate_ConstructorName, strThisFuncName);
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
export async function gs_TeachingDate_GetFirstObjAsync(strWhereCond: string): Promise<clsgs_TeachingDateEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(gs_TeachingDate_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_TeachingDate_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objgs_TeachingDate = gs_TeachingDate_GetObjFromJsonObj(returnObj);
return objgs_TeachingDate;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TeachingDate_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TeachingDate_ConstructorName, strThisFuncName);
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
export async function gs_TeachingDate_GetObjLst_ClientCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsgs_TeachingDateEN._CurrTabName, strid_CurrEduCls);
clsgs_TeachingDateEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsgs_TeachingDateEN._CurrTabName);
if (IsNullOrEmpty(clsgs_TeachingDateEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsgs_TeachingDateEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrgs_TeachingDateExObjLst_Cache: Array<clsgs_TeachingDateEN> = CacheHelper.Get(strKey);
const arrgs_TeachingDateObjLst_T = gs_TeachingDate_GetObjLstByJSONObjLst(arrgs_TeachingDateExObjLst_Cache);
return arrgs_TeachingDateObjLst_T;
}
try
{
const arrgs_TeachingDateExObjLst = await gs_TeachingDate_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrgs_TeachingDateExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_TeachingDateExObjLst.length);
console.log(strInfo);
return arrgs_TeachingDateExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, gs_TeachingDate_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_TeachingDate_GetObjLst_localStorage(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsgs_TeachingDateEN._CurrTabName, strid_CurrEduCls);
clsgs_TeachingDateEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsgs_TeachingDateEN._CurrTabName);
if (IsNullOrEmpty(clsgs_TeachingDateEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsgs_TeachingDateEN.CacheAddiCondition);
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
const arrgs_TeachingDateExObjLst_Cache: Array<clsgs_TeachingDateEN> = JSON.parse(strTempObjLst);
const arrgs_TeachingDateObjLst_T = gs_TeachingDate_GetObjLstByJSONObjLst(arrgs_TeachingDateExObjLst_Cache);
return arrgs_TeachingDateObjLst_T;
}
try
{
const arrgs_TeachingDateExObjLst = await gs_TeachingDate_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrgs_TeachingDateExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_TeachingDateExObjLst.length);
console.log(strInfo);
return arrgs_TeachingDateExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, gs_TeachingDate_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_TeachingDate_GetObjLst_localStorage_PureCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsgs_TeachingDateEN._CurrTabName, strid_CurrEduCls);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrgs_TeachingDateObjLst_Cache: Array<clsgs_TeachingDateEN> = JSON.parse(strTempObjLst);
return arrgs_TeachingDateObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function gs_TeachingDate_GetObjLstAsync(strWhereCond: string): Promise<Array<clsgs_TeachingDateEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(gs_TeachingDate_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_TeachingDate_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_TeachingDate_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TeachingDate_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TeachingDate_ConstructorName, strThisFuncName);
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
export async function gs_TeachingDate_GetObjLst_sessionStorage(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsgs_TeachingDateEN._CurrTabName, strid_CurrEduCls);
clsgs_TeachingDateEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsgs_TeachingDateEN._CurrTabName);
if (IsNullOrEmpty(clsgs_TeachingDateEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsgs_TeachingDateEN.CacheAddiCondition);
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
const arrgs_TeachingDateExObjLst_Cache: Array<clsgs_TeachingDateEN> = JSON.parse(strTempObjLst);
const arrgs_TeachingDateObjLst_T = gs_TeachingDate_GetObjLstByJSONObjLst(arrgs_TeachingDateExObjLst_Cache);
return arrgs_TeachingDateObjLst_T;
}
try
{
const arrgs_TeachingDateExObjLst = await gs_TeachingDate_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrgs_TeachingDateExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_TeachingDateExObjLst.length);
console.log(strInfo);
return arrgs_TeachingDateExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, gs_TeachingDate_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_TeachingDate_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsgs_TeachingDateEN._CurrTabName, strid_CurrEduCls);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrgs_TeachingDateObjLst_Cache: Array<clsgs_TeachingDateEN> = JSON.parse(strTempObjLst);
return arrgs_TeachingDateObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_TeachingDate_GetObjLst_Cache(strid_CurrEduCls: string): Promise<Array<clsgs_TeachingDateEN>>
{
//const strThisFuncName = "GetObjLst_Cache";

if (IsNullOrEmpty(strid_CurrEduCls) == true)
{
const strMsg = Format("缓存分类变量:[id_CurrEduCls]不能为空！");
console.error(strMsg);
throw (strMsg);
}
if (strid_CurrEduCls.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！", strid_CurrEduCls.length);
console.error(strMsg);
throw (strMsg);
}
let arrgs_TeachingDateObjLst_Cache;
switch (clsgs_TeachingDateEN.CacheModeId)
{
case "04"://sessionStorage
arrgs_TeachingDateObjLst_Cache = await gs_TeachingDate_GetObjLst_sessionStorage(strid_CurrEduCls);
break;
case "03"://localStorage
arrgs_TeachingDateObjLst_Cache = await gs_TeachingDate_GetObjLst_localStorage(strid_CurrEduCls);
break;
case "02"://ClientCache
arrgs_TeachingDateObjLst_Cache = await gs_TeachingDate_GetObjLst_ClientCache(strid_CurrEduCls);
break;
default:
arrgs_TeachingDateObjLst_Cache = await gs_TeachingDate_GetObjLst_ClientCache(strid_CurrEduCls);
break;
}
const arrgs_TeachingDateObjLst = gs_TeachingDate_GetObjLstByJSONObjLst(arrgs_TeachingDateObjLst_Cache);
return arrgs_TeachingDateObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_TeachingDate_GetObjLst_PureCache(strid_CurrEduCls: string)
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrgs_TeachingDateObjLst_Cache;
switch (clsgs_TeachingDateEN.CacheModeId)
{
case "04"://sessionStorage
arrgs_TeachingDateObjLst_Cache = await gs_TeachingDate_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls);
break;
case "03"://localStorage
arrgs_TeachingDateObjLst_Cache = await gs_TeachingDate_GetObjLst_localStorage_PureCache(strid_CurrEduCls);
break;
case "02"://ClientCache
arrgs_TeachingDateObjLst_Cache = null;
break;
default:
arrgs_TeachingDateObjLst_Cache = null;
break;
}
return arrgs_TeachingDateObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objlngmId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function gs_TeachingDate_GetSubObjLst_Cache(objgs_TeachingDate_Cond: clsgs_TeachingDateEN,strid_CurrEduCls: string) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrgs_TeachingDateObjLst_Cache = await gs_TeachingDate_GetObjLst_Cache(strid_CurrEduCls);
let arrgs_TeachingDate_Sel: Array < clsgs_TeachingDateEN > = arrgs_TeachingDateObjLst_Cache;
if (objgs_TeachingDate_Cond.sf_FldComparisonOp == null || objgs_TeachingDate_Cond.sf_FldComparisonOp == "") return arrgs_TeachingDate_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_TeachingDate_Cond.sf_FldComparisonOp);
//console.log("clsgs_TeachingDateWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objgs_TeachingDate_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrgs_TeachingDate_Sel = arrgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_TeachingDate_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_TeachingDate_Sel = arrgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_TeachingDate_Sel = arrgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_TeachingDate_Sel = arrgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_TeachingDate_Sel = arrgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_TeachingDate_Sel = arrgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_TeachingDate_Sel = arrgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_TeachingDate_Sel = arrgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_TeachingDate_Sel = arrgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrgs_TeachingDate_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objgs_TeachingDate_Cond), gs_TeachingDate_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsgs_TeachingDateEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrmId:关键字列表
 * @returns 对象列表
 **/
export async function gs_TeachingDate_GetObjLstBymIdLstAsync(arrmId: Array<string>): Promise<Array<clsgs_TeachingDateEN>>  
{
const strThisFuncName = "GetObjLstBymIdLstAsync";
const strAction = "GetObjLstBymIdLst";
const strUrl = GetWebApiUrl(gs_TeachingDate_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrmId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_TeachingDate_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_TeachingDate_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TeachingDate_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TeachingDate_ConstructorName, strThisFuncName);
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
export async function gs_TeachingDate_GetObjLstBymIdLst_Cache(arrmIdLst: Array<number>,strid_CurrEduCls: string) {
const strThisFuncName = "GetObjLstBymIdLst_Cache";
try
{
const arrgs_TeachingDateObjLst_Cache = await gs_TeachingDate_GetObjLst_Cache(strid_CurrEduCls);
const arrgs_TeachingDate_Sel: Array <clsgs_TeachingDateEN> = arrgs_TeachingDateObjLst_Cache.filter(x => arrmIdLst.indexOf(x.mId)>-1);
return arrgs_TeachingDate_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrmIdLst.join(","), gs_TeachingDate_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsgs_TeachingDateEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function gs_TeachingDate_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsgs_TeachingDateEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(gs_TeachingDate_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_TeachingDate_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_TeachingDate_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TeachingDate_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TeachingDate_ConstructorName, strThisFuncName);
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
export async function gs_TeachingDate_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsgs_TeachingDateEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(gs_TeachingDate_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_TeachingDate_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_TeachingDate_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TeachingDate_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TeachingDate_ConstructorName, strThisFuncName);
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
export async function gs_TeachingDate_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(gs_TeachingDate_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TeachingDate_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TeachingDate_ConstructorName, strThisFuncName);
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
export async function gs_TeachingDate_GetObjLstByPager_Cache(objPagerPara: stuPagerPara,strid_CurrEduCls: string) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrgs_TeachingDateObjLst_Cache = await gs_TeachingDate_GetObjLst_Cache(strid_CurrEduCls);
if (arrgs_TeachingDateObjLst_Cache.length == 0) return arrgs_TeachingDateObjLst_Cache;
let arrgs_TeachingDate_Sel = arrgs_TeachingDateObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objgs_TeachingDate_Cond = new clsgs_TeachingDateEN();
ObjectAssign(objgs_TeachingDate_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsgs_TeachingDateWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrgs_TeachingDate_Sel = arrgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_TeachingDate_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_TeachingDate_Sel = arrgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_TeachingDate_Sel = arrgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrgs_TeachingDate_Sel = arrgs_TeachingDate_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_TeachingDate_Sel = arrgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_TeachingDate_Sel = arrgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_TeachingDate_Sel = arrgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_TeachingDate_Sel = arrgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_TeachingDate_Sel = arrgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_TeachingDate_Sel = arrgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrgs_TeachingDate_Sel.length == 0) return arrgs_TeachingDate_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrgs_TeachingDate_Sel = arrgs_TeachingDate_Sel.sort(gs_TeachingDate_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrgs_TeachingDate_Sel = arrgs_TeachingDate_Sel.sort(objPagerPara.sortFun);
}
arrgs_TeachingDate_Sel = arrgs_TeachingDate_Sel.slice(intStart, intEnd);     
return arrgs_TeachingDate_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, gs_TeachingDate_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsgs_TeachingDateEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function gs_TeachingDate_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsgs_TeachingDateEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(gs_TeachingDate_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_TeachingDate_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_TeachingDate_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TeachingDate_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TeachingDate_ConstructorName, strThisFuncName);
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
export async function gs_TeachingDate_DelRecordAsync(lngmId: number): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(gs_TeachingDate_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, lngmId);
try
{
const response = await axios.delete(strUrl,
{
params: { "Id": lngmId, }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TeachingDate_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TeachingDate_ConstructorName, strThisFuncName);
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
export async function gs_TeachingDate_Delgs_TeachingDatesAsync(arrmId: Array<string>): Promise<number> 
{
const strThisFuncName = "Delgs_TeachingDatesAsync";
const strAction = "Delgs_TeachingDates";
const strUrl = GetWebApiUrl(gs_TeachingDate_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TeachingDate_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TeachingDate_ConstructorName, strThisFuncName);
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
export async function gs_TeachingDate_Delgs_TeachingDatesByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "Delgs_TeachingDatesByCondAsync";
const strAction = "Delgs_TeachingDatesByCond";
const strUrl = GetWebApiUrl(gs_TeachingDate_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TeachingDate_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TeachingDate_ConstructorName, strThisFuncName);
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
 * @param objgs_TeachingDateEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_TeachingDate_AddNewRecordAsync(objgs_TeachingDateEN: clsgs_TeachingDateEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objgs_TeachingDateEN);
const strUrl = GetWebApiUrl(gs_TeachingDate_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_TeachingDateEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TeachingDate_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TeachingDate_ConstructorName, strThisFuncName);
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
 * @param objgs_TeachingDateEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function gs_TeachingDate_AddNewRecordWithReturnKeyAsync(objgs_TeachingDateEN: clsgs_TeachingDateEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(gs_TeachingDate_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_TeachingDateEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TeachingDate_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TeachingDate_ConstructorName, strThisFuncName);
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
 * @param objgs_TeachingDateEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function gs_TeachingDate_AddNewRecordWithReturnKey(objgs_TeachingDateEN: clsgs_TeachingDateEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objgs_TeachingDateEN.mId === null || objgs_TeachingDateEN.mId === 0)
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(gs_TeachingDate_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_TeachingDateEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TeachingDate_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TeachingDate_ConstructorName, strThisFuncName);
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
 * @param objgs_TeachingDateEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function gs_TeachingDate_UpdateRecordAsync(objgs_TeachingDateEN: clsgs_TeachingDateEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objgs_TeachingDateEN.sf_UpdFldSetStr === undefined || objgs_TeachingDateEN.sf_UpdFldSetStr === null || objgs_TeachingDateEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_TeachingDateEN.mId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(gs_TeachingDate_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_TeachingDateEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TeachingDate_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TeachingDate_ConstructorName, strThisFuncName);
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
 * @param objgs_TeachingDateEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function gs_TeachingDate_UpdateWithConditionAsync(objgs_TeachingDateEN: clsgs_TeachingDateEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objgs_TeachingDateEN.sf_UpdFldSetStr === undefined || objgs_TeachingDateEN.sf_UpdFldSetStr === null || objgs_TeachingDateEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_TeachingDateEN.mId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(gs_TeachingDate_Controller, strAction);
objgs_TeachingDateEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objgs_TeachingDateEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TeachingDate_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TeachingDate_ConstructorName, strThisFuncName);
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
export async function gs_TeachingDate_IsExistRecord_Cache(objgs_TeachingDate_Cond: clsgs_TeachingDateEN,strid_CurrEduCls: string) {
const strThisFuncName = "IsExistRecord_Cache";
const arrgs_TeachingDateObjLst_Cache = await gs_TeachingDate_GetObjLst_Cache(strid_CurrEduCls);
if (arrgs_TeachingDateObjLst_Cache == null) return false;
let arrgs_TeachingDate_Sel: Array < clsgs_TeachingDateEN > = arrgs_TeachingDateObjLst_Cache;
if (objgs_TeachingDate_Cond.sf_FldComparisonOp == null || objgs_TeachingDate_Cond.sf_FldComparisonOp == "") return arrgs_TeachingDate_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_TeachingDate_Cond.sf_FldComparisonOp);
//console.log("clsgs_TeachingDateWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objgs_TeachingDate_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_TeachingDate_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_TeachingDate_Sel = arrgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_TeachingDate_Sel = arrgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_TeachingDate_Sel = arrgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_TeachingDate_Sel = arrgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_TeachingDate_Sel = arrgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_TeachingDate_Sel = arrgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_TeachingDate_Sel = arrgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_TeachingDate_Sel = arrgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrgs_TeachingDate_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objgs_TeachingDate_Cond), gs_TeachingDate_ConstructorName, strThisFuncName);
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
export async function gs_TeachingDate_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(gs_TeachingDate_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TeachingDate_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TeachingDate_ConstructorName, strThisFuncName);
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
export async function gs_TeachingDate_IsExist(lngmId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(gs_TeachingDate_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TeachingDate_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TeachingDate_ConstructorName, strThisFuncName);
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
export async function gs_TeachingDate_IsExist_Cache(lngmId:number,strid_CurrEduCls:string) {
const strThisFuncName = "IsExist_Cache";
const arrgs_TeachingDateObjLst_Cache = await gs_TeachingDate_GetObjLst_Cache(strid_CurrEduCls);
if (arrgs_TeachingDateObjLst_Cache == null) return false;
try
{
const arrgs_TeachingDate_Sel: Array <clsgs_TeachingDateEN> = arrgs_TeachingDateObjLst_Cache.filter(x => x.mId == lngmId);
if (arrgs_TeachingDate_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngmId, gs_TeachingDate_ConstructorName, strThisFuncName);
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
export async function gs_TeachingDate_IsExistAsync(lngmId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(gs_TeachingDate_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TeachingDate_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TeachingDate_ConstructorName, strThisFuncName);
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
export async function gs_TeachingDate_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(gs_TeachingDate_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TeachingDate_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TeachingDate_ConstructorName, strThisFuncName);
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
 * @param objgs_TeachingDate_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function gs_TeachingDate_GetRecCountByCond_Cache(objgs_TeachingDate_Cond: clsgs_TeachingDateEN,strid_CurrEduCls: string) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrgs_TeachingDateObjLst_Cache = await gs_TeachingDate_GetObjLst_Cache(strid_CurrEduCls);
if (arrgs_TeachingDateObjLst_Cache == null) return 0;
let arrgs_TeachingDate_Sel: Array < clsgs_TeachingDateEN > = arrgs_TeachingDateObjLst_Cache;
if (objgs_TeachingDate_Cond.sf_FldComparisonOp == null || objgs_TeachingDate_Cond.sf_FldComparisonOp == "") return arrgs_TeachingDate_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_TeachingDate_Cond.sf_FldComparisonOp);
//console.log("clsgs_TeachingDateWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objgs_TeachingDate_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrgs_TeachingDate_Sel = arrgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_TeachingDate_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_TeachingDate_Sel = arrgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_TeachingDate_Sel = arrgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrgs_TeachingDate_Sel = arrgs_TeachingDate_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_TeachingDate_Sel = arrgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_TeachingDate_Sel = arrgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_TeachingDate_Sel = arrgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_TeachingDate_Sel = arrgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_TeachingDate_Sel = arrgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_TeachingDate_Sel = arrgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrgs_TeachingDate_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objgs_TeachingDate_Cond), gs_TeachingDate_ConstructorName, strThisFuncName);
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
export async function gs_TeachingDate_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(gs_TeachingDate_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TeachingDate_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TeachingDate_ConstructorName, strThisFuncName);
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
export function gs_TeachingDate_GetWebApiUrl(strController: string, strAction: string): string {
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
export function gs_TeachingDate_ReFreshCache(strid_CurrEduCls: string):void
{
const strThisFuncName = "ReFreshCache";

if (IsNullOrEmpty(strid_CurrEduCls) == true)
{
  const strMsg = Format("参数:[strid_CurrEduCls]不能为空！(In clsgs_TeachingDateWApi.ReFreshCache)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_CurrEduCls.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！", strid_CurrEduCls.length);
console.error(strMsg);
throw (strMsg);
}

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = Format("{0}_{1}", clsgs_TeachingDateEN._CurrTabName, strid_CurrEduCls);
switch (clsgs_TeachingDateEN.CacheModeId)
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
}

 /**
 * 刷新本类中的缓存.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
 **/
export function gs_TeachingDate_ReFreshThisCache(strid_CurrEduCls: string):void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = Format("{0}_{1}", clsgs_TeachingDateEN._CurrTabName, strid_CurrEduCls);
switch (clsgs_TeachingDateEN.CacheModeId)
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
export function gs_TeachingDate_CheckPropertyNew(pobjgs_TeachingDateEN: clsgs_TeachingDateEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjgs_TeachingDateEN.id_CurrEduCls) == false && GetStrLen(pobjgs_TeachingDateEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 教学班日期范围(gs_TeachingDate))!值:$(pobjgs_TeachingDateEN.id_CurrEduCls)(clsgs_TeachingDateBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TeachingDateEN.startDate) == false && GetStrLen(pobjgs_TeachingDateEN.startDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[开始日期(startDate)]的长度不能超过20(In 教学班日期范围(gs_TeachingDate))!值:$(pobjgs_TeachingDateEN.startDate)(clsgs_TeachingDateBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TeachingDateEN.endDate) == false && GetStrLen(pobjgs_TeachingDateEN.endDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[截止日期(endDate)]的长度不能超过20(In 教学班日期范围(gs_TeachingDate))!值:$(pobjgs_TeachingDateEN.endDate)(clsgs_TeachingDateBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TeachingDateEN.updDate) == false && GetStrLen(pobjgs_TeachingDateEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 教学班日期范围(gs_TeachingDate))!值:$(pobjgs_TeachingDateEN.updDate)(clsgs_TeachingDateBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TeachingDateEN.updUser) == false && GetStrLen(pobjgs_TeachingDateEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 教学班日期范围(gs_TeachingDate))!值:$(pobjgs_TeachingDateEN.updUser)(clsgs_TeachingDateBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TeachingDateEN.memo) == false && GetStrLen(pobjgs_TeachingDateEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 教学班日期范围(gs_TeachingDate))!值:$(pobjgs_TeachingDateEN.memo)(clsgs_TeachingDateBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null != pobjgs_TeachingDateEN.mId && undefined !== pobjgs_TeachingDateEN.mId && tzDataType.isNumber(pobjgs_TeachingDateEN.mId) === false)
{
 throw new Error("(errid:Watl000060)字段[mId(mId)]的值:[$(pobjgs_TeachingDateEN.mId)], 非法，应该为数值型(In 教学班日期范围(gs_TeachingDate))!(clsgs_TeachingDateBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TeachingDateEN.id_CurrEduCls) == false && undefined !== pobjgs_TeachingDateEN.id_CurrEduCls && tzDataType.isString(pobjgs_TeachingDateEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjgs_TeachingDateEN.id_CurrEduCls)], 非法，应该为字符型(In 教学班日期范围(gs_TeachingDate))!(clsgs_TeachingDateBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TeachingDateEN.startDate) == false && undefined !== pobjgs_TeachingDateEN.startDate && tzDataType.isString(pobjgs_TeachingDateEN.startDate) === false)
{
 throw new Error("(errid:Watl000060)字段[开始日期(startDate)]的值:[$(pobjgs_TeachingDateEN.startDate)], 非法，应该为字符型(In 教学班日期范围(gs_TeachingDate))!(clsgs_TeachingDateBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TeachingDateEN.endDate) == false && undefined !== pobjgs_TeachingDateEN.endDate && tzDataType.isString(pobjgs_TeachingDateEN.endDate) === false)
{
 throw new Error("(errid:Watl000060)字段[截止日期(endDate)]的值:[$(pobjgs_TeachingDateEN.endDate)], 非法，应该为字符型(In 教学班日期范围(gs_TeachingDate))!(clsgs_TeachingDateBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TeachingDateEN.updDate) == false && undefined !== pobjgs_TeachingDateEN.updDate && tzDataType.isString(pobjgs_TeachingDateEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjgs_TeachingDateEN.updDate)], 非法，应该为字符型(In 教学班日期范围(gs_TeachingDate))!(clsgs_TeachingDateBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TeachingDateEN.updUser) == false && undefined !== pobjgs_TeachingDateEN.updUser && tzDataType.isString(pobjgs_TeachingDateEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjgs_TeachingDateEN.updUser)], 非法，应该为字符型(In 教学班日期范围(gs_TeachingDate))!(clsgs_TeachingDateBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TeachingDateEN.memo) == false && undefined !== pobjgs_TeachingDateEN.memo && tzDataType.isString(pobjgs_TeachingDateEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjgs_TeachingDateEN.memo)], 非法，应该为字符型(In 教学班日期范围(gs_TeachingDate))!(clsgs_TeachingDateBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjgs_TeachingDateEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function gs_TeachingDate_CheckProperty4Update (pobjgs_TeachingDateEN: clsgs_TeachingDateEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjgs_TeachingDateEN.id_CurrEduCls) == false && GetStrLen(pobjgs_TeachingDateEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 教学班日期范围(gs_TeachingDate))!值:$(pobjgs_TeachingDateEN.id_CurrEduCls)(clsgs_TeachingDateBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TeachingDateEN.startDate) == false && GetStrLen(pobjgs_TeachingDateEN.startDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[开始日期(startDate)]的长度不能超过20(In 教学班日期范围(gs_TeachingDate))!值:$(pobjgs_TeachingDateEN.startDate)(clsgs_TeachingDateBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TeachingDateEN.endDate) == false && GetStrLen(pobjgs_TeachingDateEN.endDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[截止日期(endDate)]的长度不能超过20(In 教学班日期范围(gs_TeachingDate))!值:$(pobjgs_TeachingDateEN.endDate)(clsgs_TeachingDateBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TeachingDateEN.updDate) == false && GetStrLen(pobjgs_TeachingDateEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 教学班日期范围(gs_TeachingDate))!值:$(pobjgs_TeachingDateEN.updDate)(clsgs_TeachingDateBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TeachingDateEN.updUser) == false && GetStrLen(pobjgs_TeachingDateEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 教学班日期范围(gs_TeachingDate))!值:$(pobjgs_TeachingDateEN.updUser)(clsgs_TeachingDateBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TeachingDateEN.memo) == false && GetStrLen(pobjgs_TeachingDateEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 教学班日期范围(gs_TeachingDate))!值:$(pobjgs_TeachingDateEN.memo)(clsgs_TeachingDateBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null != pobjgs_TeachingDateEN.mId && undefined !== pobjgs_TeachingDateEN.mId && tzDataType.isNumber(pobjgs_TeachingDateEN.mId) === false)
{
 throw new Error("(errid:Watl000063)字段[mId(mId)]的值:[$(pobjgs_TeachingDateEN.mId)], 非法，应该为数值型(In 教学班日期范围(gs_TeachingDate))!(clsgs_TeachingDateBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TeachingDateEN.id_CurrEduCls) == false && undefined !== pobjgs_TeachingDateEN.id_CurrEduCls && tzDataType.isString(pobjgs_TeachingDateEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjgs_TeachingDateEN.id_CurrEduCls)], 非法，应该为字符型(In 教学班日期范围(gs_TeachingDate))!(clsgs_TeachingDateBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TeachingDateEN.startDate) == false && undefined !== pobjgs_TeachingDateEN.startDate && tzDataType.isString(pobjgs_TeachingDateEN.startDate) === false)
{
 throw new Error("(errid:Watl000063)字段[开始日期(startDate)]的值:[$(pobjgs_TeachingDateEN.startDate)], 非法，应该为字符型(In 教学班日期范围(gs_TeachingDate))!(clsgs_TeachingDateBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TeachingDateEN.endDate) == false && undefined !== pobjgs_TeachingDateEN.endDate && tzDataType.isString(pobjgs_TeachingDateEN.endDate) === false)
{
 throw new Error("(errid:Watl000063)字段[截止日期(endDate)]的值:[$(pobjgs_TeachingDateEN.endDate)], 非法，应该为字符型(In 教学班日期范围(gs_TeachingDate))!(clsgs_TeachingDateBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TeachingDateEN.updDate) == false && undefined !== pobjgs_TeachingDateEN.updDate && tzDataType.isString(pobjgs_TeachingDateEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjgs_TeachingDateEN.updDate)], 非法，应该为字符型(In 教学班日期范围(gs_TeachingDate))!(clsgs_TeachingDateBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TeachingDateEN.updUser) == false && undefined !== pobjgs_TeachingDateEN.updUser && tzDataType.isString(pobjgs_TeachingDateEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjgs_TeachingDateEN.updUser)], 非法，应该为字符型(In 教学班日期范围(gs_TeachingDate))!(clsgs_TeachingDateBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TeachingDateEN.memo) == false && undefined !== pobjgs_TeachingDateEN.memo && tzDataType.isString(pobjgs_TeachingDateEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjgs_TeachingDateEN.memo)], 非法，应该为字符型(In 教学班日期范围(gs_TeachingDate))!(clsgs_TeachingDateBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjgs_TeachingDateEN.mId 
 || pobjgs_TeachingDateEN.mId != null && pobjgs_TeachingDateEN.mId.toString()  ===  "")
{
 throw new Error("(errid:Watl000064)字段[mId]不能为空(In 教学班日期范围)!(clsgs_TeachingDateBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjgs_TeachingDateEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function gs_TeachingDate_GetJSONStrByObj (pobjgs_TeachingDateEN: clsgs_TeachingDateEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjgs_TeachingDateEN.sf_UpdFldSetStr = pobjgs_TeachingDateEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjgs_TeachingDateEN);
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
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象列表
*/
export function gs_TeachingDate_GetObjLstByJSONStr (strJSON: string): Array<clsgs_TeachingDateEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrgs_TeachingDateObjLst = new Array<clsgs_TeachingDateEN>();
if (strJSON === "")
{
return arrgs_TeachingDateObjLst;
}
try
{
arrgs_TeachingDateObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrgs_TeachingDateObjLst;
}
return arrgs_TeachingDateObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrgs_TeachingDateObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function gs_TeachingDate_GetObjLstByJSONObjLst (arrgs_TeachingDateObjLstS: Array<clsgs_TeachingDateEN>): Array<clsgs_TeachingDateEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrgs_TeachingDateObjLst = new Array<clsgs_TeachingDateEN>();
for (const objInFor of arrgs_TeachingDateObjLstS) {
const obj1 = gs_TeachingDate_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrgs_TeachingDateObjLst.push(obj1);
}
return arrgs_TeachingDateObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function gs_TeachingDate_GetObjByJSONStr (strJSON: string): clsgs_TeachingDateEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjgs_TeachingDateEN = new clsgs_TeachingDateEN();
if (strJSON === "")
{
return pobjgs_TeachingDateEN;
}
try
{
pobjgs_TeachingDateEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjgs_TeachingDateEN;
}
return pobjgs_TeachingDateEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function gs_TeachingDate_GetCombineCondition(objgs_TeachingDate_Cond: clsgs_TeachingDateEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objgs_TeachingDate_Cond.dicFldComparisonOp, clsgs_TeachingDateEN.con_mId) == true)
{
const strComparisonOp_mId:string = objgs_TeachingDate_Cond.dicFldComparisonOp[clsgs_TeachingDateEN.con_mId];
strWhereCond += Format(" And {0} {2} {1}", clsgs_TeachingDateEN.con_mId, objgs_TeachingDate_Cond.mId, strComparisonOp_mId);
}
if (Object.prototype.hasOwnProperty.call(objgs_TeachingDate_Cond.dicFldComparisonOp, clsgs_TeachingDateEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objgs_TeachingDate_Cond.dicFldComparisonOp[clsgs_TeachingDateEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TeachingDateEN.con_id_CurrEduCls, objgs_TeachingDate_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (Object.prototype.hasOwnProperty.call(objgs_TeachingDate_Cond.dicFldComparisonOp, clsgs_TeachingDateEN.con_StartDate) == true)
{
const strComparisonOp_StartDate:string = objgs_TeachingDate_Cond.dicFldComparisonOp[clsgs_TeachingDateEN.con_StartDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TeachingDateEN.con_StartDate, objgs_TeachingDate_Cond.startDate, strComparisonOp_StartDate);
}
if (Object.prototype.hasOwnProperty.call(objgs_TeachingDate_Cond.dicFldComparisonOp, clsgs_TeachingDateEN.con_EndDate) == true)
{
const strComparisonOp_EndDate:string = objgs_TeachingDate_Cond.dicFldComparisonOp[clsgs_TeachingDateEN.con_EndDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TeachingDateEN.con_EndDate, objgs_TeachingDate_Cond.endDate, strComparisonOp_EndDate);
}
if (Object.prototype.hasOwnProperty.call(objgs_TeachingDate_Cond.dicFldComparisonOp, clsgs_TeachingDateEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objgs_TeachingDate_Cond.dicFldComparisonOp[clsgs_TeachingDateEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TeachingDateEN.con_UpdDate, objgs_TeachingDate_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objgs_TeachingDate_Cond.dicFldComparisonOp, clsgs_TeachingDateEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objgs_TeachingDate_Cond.dicFldComparisonOp[clsgs_TeachingDateEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TeachingDateEN.con_UpdUser, objgs_TeachingDate_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objgs_TeachingDate_Cond.dicFldComparisonOp, clsgs_TeachingDateEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objgs_TeachingDate_Cond.dicFldComparisonOp[clsgs_TeachingDateEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TeachingDateEN.con_Memo, objgs_TeachingDate_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--gs_TeachingDate(教学班日期范围),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param lngmId: mId(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function gs_TeachingDate_GetUniCondStr_mId(objgs_TeachingDateEN: clsgs_TeachingDateEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and mId = '{0}'", objgs_TeachingDateEN.mId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--gs_TeachingDate(教学班日期范围),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param lngmId: mId(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function gs_TeachingDate_GetUniCondStr4Update_mId(objgs_TeachingDateEN: clsgs_TeachingDateEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and mId <> '{0}'", objgs_TeachingDateEN.mId);
 strWhereCond +=  Format(" and mId = '{0}'", objgs_TeachingDateEN.mId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objgs_TeachingDateENS:源对象
 * @param objgs_TeachingDateENT:目标对象
*/
export function gs_TeachingDate_CopyObjTo(objgs_TeachingDateENS: clsgs_TeachingDateEN , objgs_TeachingDateENT: clsgs_TeachingDateEN ): void 
{
objgs_TeachingDateENT.mId = objgs_TeachingDateENS.mId; //mId
objgs_TeachingDateENT.id_CurrEduCls = objgs_TeachingDateENS.id_CurrEduCls; //教学班流水号
objgs_TeachingDateENT.startDate = objgs_TeachingDateENS.startDate; //开始日期
objgs_TeachingDateENT.endDate = objgs_TeachingDateENS.endDate; //截止日期
objgs_TeachingDateENT.updDate = objgs_TeachingDateENS.updDate; //修改日期
objgs_TeachingDateENT.updUser = objgs_TeachingDateENS.updUser; //修改人
objgs_TeachingDateENT.memo = objgs_TeachingDateENS.memo; //备注
objgs_TeachingDateENT.sf_UpdFldSetStr = objgs_TeachingDateENS.updFldString; //sf_UpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objgs_TeachingDateENS:源对象
 * @param objgs_TeachingDateENT:目标对象
*/
export function gs_TeachingDate_GetObjFromJsonObj(objgs_TeachingDateENS: clsgs_TeachingDateEN): clsgs_TeachingDateEN 
{
 const objgs_TeachingDateENT: clsgs_TeachingDateEN = new clsgs_TeachingDateEN();
ObjectAssign(objgs_TeachingDateENT, objgs_TeachingDateENS);
 return objgs_TeachingDateENT;
}