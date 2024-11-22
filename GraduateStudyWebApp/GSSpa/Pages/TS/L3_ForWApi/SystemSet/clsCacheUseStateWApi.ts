
 /**
 * 类名:clsCacheUseStateWApi
 * 表名:CacheUseState(01120689)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:45:56
 * 生成者:pyf
 * 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:系统设置(SystemSet)
 * 框架-层名:WA_访问层(TS)(WA_Access)
 * 编程语言:TypeScript
 * 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
   *      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 **/

/**
 * 缓存使用状态(CacheUseState)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clsCacheUseStateEN } from "../../L0_Entity/SystemSet/clsCacheUseStateEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { tzDataType } from "../../PubFun/jsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const cacheUseState_Controller = "CacheUseStateApi";
 export const cacheUseState_ConstructorName = "cacheUseState";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngmId:关键字
 * @returns 对象
 **/
export async function CacheUseState_GetObjBymIdAsync(lngmId: number): Promise<clsCacheUseStateEN>  
{
const strThisFuncName = "GetObjBymIdAsync";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In GetObjBymIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjBymId";
const strUrl = GetWebApiUrl(cacheUseState_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", cacheUseState_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objCacheUseState = CacheUseState_GetObjFromJsonObj(returnObj);
return objCacheUseState;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cacheUseState_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cacheUseState_ConstructorName, strThisFuncName);
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
export async function CacheUseState_GetObjBymId_Cache(lngmId:number,strUserId:string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjBymId_Cache";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In GetObjBymId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
const arrCacheUseStateObjLst_Cache = await CacheUseState_GetObjLst_Cache(strUserId);
try
{
const arrCacheUseState_Sel: Array <clsCacheUseStateEN> = arrCacheUseStateObjLst_Cache.filter(x => x.mId == lngmId);
let objCacheUseState: clsCacheUseStateEN;
if (arrCacheUseState_Sel.length > 0)
{
objCacheUseState = arrCacheUseState_Sel[0];
return objCacheUseState;
}
else
{
if (bolTryAsyncOnce == true)
{
objCacheUseState = await CacheUseState_GetObjBymIdAsync(lngmId);
if (objCacheUseState != null)
{
CacheUseState_ReFreshThisCache(strUserId);
return objCacheUseState;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, cacheUseState_ConstructorName, strThisFuncName);
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
export async function CacheUseState_GetObjBymId_localStorage(lngmId: number) {
const strThisFuncName = "GetObjBymId_localStorage";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In GetObjBymId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
const strKey = Format("{0}_{1}", clsCacheUseStateEN._CurrTabName, lngmId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objCacheUseState_Cache: clsCacheUseStateEN = JSON.parse(strTempObj);
return objCacheUseState_Cache;
}
try
{
const objCacheUseState = await CacheUseState_GetObjBymIdAsync(lngmId);
if (objCacheUseState != null)
{
localStorage.setItem(strKey, JSON.stringify(objCacheUseState));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objCacheUseState;
}
return objCacheUseState;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, cacheUseState_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objCacheUseState:所给的对象
 * @returns 对象
*/
export async function CacheUseState_UpdateObjInLst_Cache(objCacheUseState: clsCacheUseStateEN,strUserId: string) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrCacheUseStateObjLst_Cache = await CacheUseState_GetObjLst_Cache(strUserId);
const obj = arrCacheUseStateObjLst_Cache.find(x => x.mId == objCacheUseState.mId);
if (obj != null)
{
objCacheUseState.mId = obj.mId;
ObjectAssign( obj, objCacheUseState);
}
else
{
arrCacheUseStateObjLst_Cache.push(objCacheUseState);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, cacheUseState_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
}

/**
 * 根据关键字获取相关对象的名称属性, 从缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
 * @param lngmId:所给的关键字
 * @returns 对象
*/
export async function CacheUseState_GetNameBymId_Cache(lngmId: number,strUserId: string) {
const strThisFuncName = "GetNameBymId_Cache";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In GetNameBymId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
const arrCacheUseStateObjLst_Cache = await CacheUseState_GetObjLst_Cache(strUserId);
if (arrCacheUseStateObjLst_Cache == null) return "";
try
{
const arrCacheUseState_Sel: Array <clsCacheUseStateEN> = arrCacheUseStateObjLst_Cache.filter(x => x.mId == lngmId);
let objCacheUseState: clsCacheUseStateEN;
if (arrCacheUseState_Sel.length > 0)
{
objCacheUseState = arrCacheUseState_Sel[0];
return objCacheUseState.userId;
}
else
{
return "";
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, lngmId);
console.error(strMsg);
alert(strMsg);
}
return "";
}

/**
 * 映射函数。根据表映射把输入字段值，映射成输出字段值
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
 * @param strInFldName:输入字段名
 * @param strOutFldName:输出字段名
 * @param strInValue:输入字段值
 @param strUserId:缓存的分类字段
 * @returns 返回一个输出字段值
*/
export async function CacheUseState_func(strInFldName:string , strOutFldName:string , strInValue:number , strUserId_C: string)
{
//const strThisFuncName = "func";

if (IsNullOrEmpty(strUserId_C) == true)
{
  const strMsg = Format("参数:[strUserId_C]不能为空！(In func)");
console.error(strMsg);
 throw (strMsg);
}

if (strInFldName != clsCacheUseStateEN.con_mId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsCacheUseStateEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clsCacheUseStateEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const lngmId = Number(strInValue);
if (lngmId == 0)
{
return "";
}
const objCacheUseState = await CacheUseState_GetObjBymId_Cache(lngmId , strUserId_C);
if (objCacheUseState == null) return "";
return objCacheUseState.GetFldValue(strOutFldName).toString();
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
export function CacheUseState_SortFun_Defa(a:clsCacheUseStateEN , b:clsCacheUseStateEN): number 
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
export function CacheUseState_SortFun_Defa_2Fld(a:clsCacheUseStateEN , b:clsCacheUseStateEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.userId == b.userId) return a.cacheModeId.localeCompare(b.cacheModeId);
else return a.userId.localeCompare(b.userId);
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
export function CacheUseState_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsCacheUseStateEN.con_mId:
return (a: clsCacheUseStateEN, b: clsCacheUseStateEN) => {
return a.mId-b.mId;
}
case clsCacheUseStateEN.con_UserId:
return (a: clsCacheUseStateEN, b: clsCacheUseStateEN) => {
return a.userId.localeCompare(b.userId);
}
case clsCacheUseStateEN.con_CacheModeId:
return (a: clsCacheUseStateEN, b: clsCacheUseStateEN) => {
return a.cacheModeId.localeCompare(b.cacheModeId);
}
case clsCacheUseStateEN.con_CacheKey:
return (a: clsCacheUseStateEN, b: clsCacheUseStateEN) => {
return a.cacheKey.localeCompare(b.cacheKey);
}
case clsCacheUseStateEN.con_CacheSize:
return (a: clsCacheUseStateEN, b: clsCacheUseStateEN) => {
return a.cacheSize-b.cacheSize;
}
case clsCacheUseStateEN.con_Memo:
return (a: clsCacheUseStateEN, b: clsCacheUseStateEN) => {
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[CacheUseState]中不存在！(in ${ cacheUseState_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsCacheUseStateEN.con_mId:
return (a: clsCacheUseStateEN, b: clsCacheUseStateEN) => {
return b.mId-a.mId;
}
case clsCacheUseStateEN.con_UserId:
return (a: clsCacheUseStateEN, b: clsCacheUseStateEN) => {
return b.userId.localeCompare(a.userId);
}
case clsCacheUseStateEN.con_CacheModeId:
return (a: clsCacheUseStateEN, b: clsCacheUseStateEN) => {
return b.cacheModeId.localeCompare(a.cacheModeId);
}
case clsCacheUseStateEN.con_CacheKey:
return (a: clsCacheUseStateEN, b: clsCacheUseStateEN) => {
return b.cacheKey.localeCompare(a.cacheKey);
}
case clsCacheUseStateEN.con_CacheSize:
return (a: clsCacheUseStateEN, b: clsCacheUseStateEN) => {
return b.cacheSize-a.cacheSize;
}
case clsCacheUseStateEN.con_Memo:
return (a: clsCacheUseStateEN, b: clsCacheUseStateEN) => {
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[CacheUseState]中不存在！(in ${ cacheUseState_ConstructorName}.${ strThisFuncName})`;
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
export async function CacheUseState_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsCacheUseStateEN.con_mId:
return (obj: clsCacheUseStateEN) => {
return obj.mId === value;
}
case clsCacheUseStateEN.con_UserId:
return (obj: clsCacheUseStateEN) => {
return obj.userId === value;
}
case clsCacheUseStateEN.con_CacheModeId:
return (obj: clsCacheUseStateEN) => {
return obj.cacheModeId === value;
}
case clsCacheUseStateEN.con_CacheKey:
return (obj: clsCacheUseStateEN) => {
return obj.cacheKey === value;
}
case clsCacheUseStateEN.con_CacheSize:
return (obj: clsCacheUseStateEN) => {
return obj.cacheSize === value;
}
case clsCacheUseStateEN.con_Memo:
return (obj: clsCacheUseStateEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[CacheUseState]中不存在！(in ${ cacheUseState_ConstructorName}.${ strThisFuncName})`;
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
export async function CacheUseState_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(cacheUseState_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cacheUseState_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cacheUseState_ConstructorName, strThisFuncName);
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
export async function CacheUseState_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(cacheUseState_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cacheUseState_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cacheUseState_ConstructorName, strThisFuncName);
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
export async function CacheUseState_GetFirstObjAsync(strWhereCond: string): Promise<clsCacheUseStateEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(cacheUseState_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", cacheUseState_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objCacheUseState = CacheUseState_GetObjFromJsonObj(returnObj);
return objCacheUseState;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cacheUseState_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cacheUseState_ConstructorName, strThisFuncName);
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
export async function CacheUseState_GetObjLst_ClientCache(strUserId: string)
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("UserId='{0}'", strUserId);
const strKey = Format("{0}_{1}", clsCacheUseStateEN._CurrTabName, strUserId);
clsCacheUseStateEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsCacheUseStateEN._CurrTabName);
if (IsNullOrEmpty(clsCacheUseStateEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsCacheUseStateEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrCacheUseStateExObjLst_Cache: Array<clsCacheUseStateEN> = CacheHelper.Get(strKey);
const arrCacheUseStateObjLst_T = CacheUseState_GetObjLstByJSONObjLst(arrCacheUseStateExObjLst_Cache);
return arrCacheUseStateObjLst_T;
}
try
{
const arrCacheUseStateExObjLst = await CacheUseState_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrCacheUseStateExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrCacheUseStateExObjLst.length);
console.log(strInfo);
return arrCacheUseStateExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, cacheUseState_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function CacheUseState_GetObjLst_localStorage(strUserId: string)
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("UserId='{0}'", strUserId);
const strKey = Format("{0}_{1}", clsCacheUseStateEN._CurrTabName, strUserId);
clsCacheUseStateEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsCacheUseStateEN._CurrTabName);
if (IsNullOrEmpty(clsCacheUseStateEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsCacheUseStateEN.CacheAddiCondition);
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
const arrCacheUseStateExObjLst_Cache: Array<clsCacheUseStateEN> = JSON.parse(strTempObjLst);
const arrCacheUseStateObjLst_T = CacheUseState_GetObjLstByJSONObjLst(arrCacheUseStateExObjLst_Cache);
return arrCacheUseStateObjLst_T;
}
try
{
const arrCacheUseStateExObjLst = await CacheUseState_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrCacheUseStateExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrCacheUseStateExObjLst.length);
console.log(strInfo);
return arrCacheUseStateExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, cacheUseState_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function CacheUseState_GetObjLst_localStorage_PureCache(strUserId: string)
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("UserId='{0}'", strUserId);
const strKey = Format("{0}_{1}", clsCacheUseStateEN._CurrTabName, strUserId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrCacheUseStateObjLst_Cache: Array<clsCacheUseStateEN> = JSON.parse(strTempObjLst);
return arrCacheUseStateObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function CacheUseState_GetObjLstAsync(strWhereCond: string): Promise<Array<clsCacheUseStateEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(cacheUseState_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", cacheUseState_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = CacheUseState_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cacheUseState_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cacheUseState_ConstructorName, strThisFuncName);
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
export async function CacheUseState_GetObjLst_sessionStorage(strUserId: string)
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("UserId='{0}'", strUserId);
const strKey = Format("{0}_{1}", clsCacheUseStateEN._CurrTabName, strUserId);
clsCacheUseStateEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsCacheUseStateEN._CurrTabName);
if (IsNullOrEmpty(clsCacheUseStateEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsCacheUseStateEN.CacheAddiCondition);
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
const arrCacheUseStateExObjLst_Cache: Array<clsCacheUseStateEN> = JSON.parse(strTempObjLst);
const arrCacheUseStateObjLst_T = CacheUseState_GetObjLstByJSONObjLst(arrCacheUseStateExObjLst_Cache);
return arrCacheUseStateObjLst_T;
}
try
{
const arrCacheUseStateExObjLst = await CacheUseState_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrCacheUseStateExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrCacheUseStateExObjLst.length);
console.log(strInfo);
return arrCacheUseStateExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, cacheUseState_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function CacheUseState_GetObjLst_sessionStorage_PureCache(strUserId: string)
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("UserId='{0}'", strUserId);
const strKey = Format("{0}_{1}", clsCacheUseStateEN._CurrTabName, strUserId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrCacheUseStateObjLst_Cache: Array<clsCacheUseStateEN> = JSON.parse(strTempObjLst);
return arrCacheUseStateObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function CacheUseState_GetObjLst_Cache(strUserId: string): Promise<Array<clsCacheUseStateEN>>
{
//const strThisFuncName = "GetObjLst_Cache";

if (IsNullOrEmpty(strUserId) == true)
{
const strMsg = Format("缓存分类变量:[UserId]不能为空！");
console.error(strMsg);
throw (strMsg);
}
let arrCacheUseStateObjLst_Cache;
switch (clsCacheUseStateEN.CacheModeId)
{
case "04"://sessionStorage
arrCacheUseStateObjLst_Cache = await CacheUseState_GetObjLst_sessionStorage(strUserId);
break;
case "03"://localStorage
arrCacheUseStateObjLst_Cache = await CacheUseState_GetObjLst_localStorage(strUserId);
break;
case "02"://ClientCache
arrCacheUseStateObjLst_Cache = await CacheUseState_GetObjLst_ClientCache(strUserId);
break;
default:
arrCacheUseStateObjLst_Cache = await CacheUseState_GetObjLst_ClientCache(strUserId);
break;
}
const arrCacheUseStateObjLst = CacheUseState_GetObjLstByJSONObjLst(arrCacheUseStateObjLst_Cache);
return arrCacheUseStateObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function CacheUseState_GetObjLst_PureCache(strUserId: string)
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrCacheUseStateObjLst_Cache;
switch (clsCacheUseStateEN.CacheModeId)
{
case "04"://sessionStorage
arrCacheUseStateObjLst_Cache = await CacheUseState_GetObjLst_sessionStorage_PureCache(strUserId);
break;
case "03"://localStorage
arrCacheUseStateObjLst_Cache = await CacheUseState_GetObjLst_localStorage_PureCache(strUserId);
break;
case "02"://ClientCache
arrCacheUseStateObjLst_Cache = null;
break;
default:
arrCacheUseStateObjLst_Cache = null;
break;
}
return arrCacheUseStateObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objlngmId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function CacheUseState_GetSubObjLst_Cache(objCacheUseState_Cond: clsCacheUseStateEN,strUserId: string) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrCacheUseStateObjLst_Cache = await CacheUseState_GetObjLst_Cache(strUserId);
let arrCacheUseState_Sel: Array < clsCacheUseStateEN > = arrCacheUseStateObjLst_Cache;
if (objCacheUseState_Cond.sf_FldComparisonOp == null || objCacheUseState_Cond.sf_FldComparisonOp == "") return arrCacheUseState_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objCacheUseState_Cond.sf_FldComparisonOp);
//console.log("clsCacheUseStateWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objCacheUseState_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objCacheUseState_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrCacheUseState_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objCacheUseState_Cond), cacheUseState_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsCacheUseStateEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrmId:关键字列表
 * @returns 对象列表
 **/
export async function CacheUseState_GetObjLstBymIdLstAsync(arrmId: Array<string>): Promise<Array<clsCacheUseStateEN>>  
{
const strThisFuncName = "GetObjLstBymIdLstAsync";
const strAction = "GetObjLstBymIdLst";
const strUrl = GetWebApiUrl(cacheUseState_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrmId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", cacheUseState_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = CacheUseState_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cacheUseState_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cacheUseState_ConstructorName, strThisFuncName);
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
export async function CacheUseState_GetObjLstBymIdLst_Cache(arrmIdLst: Array<number>,strUserId: string) {
const strThisFuncName = "GetObjLstBymIdLst_Cache";
try
{
const arrCacheUseStateObjLst_Cache = await CacheUseState_GetObjLst_Cache(strUserId);
const arrCacheUseState_Sel: Array <clsCacheUseStateEN> = arrCacheUseStateObjLst_Cache.filter(x => arrmIdLst.indexOf(x.mId)>-1);
return arrCacheUseState_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrmIdLst.join(","), cacheUseState_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsCacheUseStateEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function CacheUseState_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsCacheUseStateEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(cacheUseState_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", cacheUseState_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = CacheUseState_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cacheUseState_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cacheUseState_ConstructorName, strThisFuncName);
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
export async function CacheUseState_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsCacheUseStateEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(cacheUseState_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", cacheUseState_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = CacheUseState_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cacheUseState_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cacheUseState_ConstructorName, strThisFuncName);
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
export async function CacheUseState_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(cacheUseState_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cacheUseState_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cacheUseState_ConstructorName, strThisFuncName);
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
export async function CacheUseState_GetObjLstByPager_Cache(objPagerPara: stuPagerPara,strUserId: string) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrCacheUseStateObjLst_Cache = await CacheUseState_GetObjLst_Cache(strUserId);
if (arrCacheUseStateObjLst_Cache.length == 0) return arrCacheUseStateObjLst_Cache;
let arrCacheUseState_Sel = arrCacheUseStateObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objCacheUseState_Cond = new clsCacheUseStateEN();
ObjectAssign(objCacheUseState_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsCacheUseStateWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objCacheUseState_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrCacheUseState_Sel.length == 0) return arrCacheUseState_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrCacheUseState_Sel = arrCacheUseState_Sel.sort(CacheUseState_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrCacheUseState_Sel = arrCacheUseState_Sel.sort(objPagerPara.sortFun);
}
arrCacheUseState_Sel = arrCacheUseState_Sel.slice(intStart, intEnd);     
return arrCacheUseState_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, cacheUseState_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsCacheUseStateEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function CacheUseState_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsCacheUseStateEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(cacheUseState_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", cacheUseState_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = CacheUseState_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cacheUseState_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cacheUseState_ConstructorName, strThisFuncName);
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
export async function CacheUseState_DelRecordAsync(lngmId: number): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(cacheUseState_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cacheUseState_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cacheUseState_ConstructorName, strThisFuncName);
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
export async function CacheUseState_DelCacheUseStatesAsync(arrmId: Array<string>): Promise<number> 
{
const strThisFuncName = "DelCacheUseStatesAsync";
const strAction = "DelCacheUseStates";
const strUrl = GetWebApiUrl(cacheUseState_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cacheUseState_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cacheUseState_ConstructorName, strThisFuncName);
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
export async function CacheUseState_DelCacheUseStatesByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "DelCacheUseStatesByCondAsync";
const strAction = "DelCacheUseStatesByCond";
const strUrl = GetWebApiUrl(cacheUseState_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cacheUseState_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cacheUseState_ConstructorName, strThisFuncName);
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
 * @param objCacheUseStateEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function CacheUseState_AddNewRecordAsync(objCacheUseStateEN: clsCacheUseStateEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objCacheUseStateEN);
const strUrl = GetWebApiUrl(cacheUseState_Controller, strAction);
try
{
const response = await axios.post(strUrl, objCacheUseStateEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cacheUseState_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cacheUseState_ConstructorName, strThisFuncName);
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
 * @param objCacheUseStateEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function CacheUseState_AddNewRecordWithReturnKeyAsync(objCacheUseStateEN: clsCacheUseStateEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(cacheUseState_Controller, strAction);
try
{
const response = await axios.post(strUrl, objCacheUseStateEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cacheUseState_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cacheUseState_ConstructorName, strThisFuncName);
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
 * @param objCacheUseStateEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function CacheUseState_AddNewRecordWithReturnKey(objCacheUseStateEN: clsCacheUseStateEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objCacheUseStateEN.mId === null || objCacheUseStateEN.mId === 0)
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(cacheUseState_Controller, strAction);
try
{
const response = await axios.post(strUrl, objCacheUseStateEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cacheUseState_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cacheUseState_ConstructorName, strThisFuncName);
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
 * @param objCacheUseStateEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function CacheUseState_UpdateRecordAsync(objCacheUseStateEN: clsCacheUseStateEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objCacheUseStateEN.sf_UpdFldSetStr === undefined || objCacheUseStateEN.sf_UpdFldSetStr === null || objCacheUseStateEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objCacheUseStateEN.mId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(cacheUseState_Controller, strAction);
try
{
const response = await axios.post(strUrl, objCacheUseStateEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cacheUseState_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cacheUseState_ConstructorName, strThisFuncName);
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
 * @param objCacheUseStateEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function CacheUseState_UpdateWithConditionAsync(objCacheUseStateEN: clsCacheUseStateEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objCacheUseStateEN.sf_UpdFldSetStr === undefined || objCacheUseStateEN.sf_UpdFldSetStr === null || objCacheUseStateEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objCacheUseStateEN.mId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(cacheUseState_Controller, strAction);
objCacheUseStateEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objCacheUseStateEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cacheUseState_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cacheUseState_ConstructorName, strThisFuncName);
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
export async function CacheUseState_IsExistRecord_Cache(objCacheUseState_Cond: clsCacheUseStateEN,strUserId: string) {
const strThisFuncName = "IsExistRecord_Cache";
const arrCacheUseStateObjLst_Cache = await CacheUseState_GetObjLst_Cache(strUserId);
if (arrCacheUseStateObjLst_Cache == null) return false;
let arrCacheUseState_Sel: Array < clsCacheUseStateEN > = arrCacheUseStateObjLst_Cache;
if (objCacheUseState_Cond.sf_FldComparisonOp == null || objCacheUseState_Cond.sf_FldComparisonOp == "") return arrCacheUseState_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objCacheUseState_Cond.sf_FldComparisonOp);
//console.log("clsCacheUseStateWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objCacheUseState_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objCacheUseState_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrCacheUseState_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objCacheUseState_Cond), cacheUseState_ConstructorName, strThisFuncName);
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
export async function CacheUseState_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(cacheUseState_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cacheUseState_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cacheUseState_ConstructorName, strThisFuncName);
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
export async function CacheUseState_IsExist(lngmId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(cacheUseState_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cacheUseState_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cacheUseState_ConstructorName, strThisFuncName);
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
export async function CacheUseState_IsExist_Cache(lngmId:number,strUserId:string) {
const strThisFuncName = "IsExist_Cache";
const arrCacheUseStateObjLst_Cache = await CacheUseState_GetObjLst_Cache(strUserId);
if (arrCacheUseStateObjLst_Cache == null) return false;
try
{
const arrCacheUseState_Sel: Array <clsCacheUseStateEN> = arrCacheUseStateObjLst_Cache.filter(x => x.mId == lngmId);
if (arrCacheUseState_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngmId, cacheUseState_ConstructorName, strThisFuncName);
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
export async function CacheUseState_IsExistAsync(lngmId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(cacheUseState_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cacheUseState_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cacheUseState_ConstructorName, strThisFuncName);
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
export async function CacheUseState_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(cacheUseState_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cacheUseState_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cacheUseState_ConstructorName, strThisFuncName);
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
 * @param objCacheUseState_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function CacheUseState_GetRecCountByCond_Cache(objCacheUseState_Cond: clsCacheUseStateEN,strUserId: string) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrCacheUseStateObjLst_Cache = await CacheUseState_GetObjLst_Cache(strUserId);
if (arrCacheUseStateObjLst_Cache == null) return 0;
let arrCacheUseState_Sel: Array < clsCacheUseStateEN > = arrCacheUseStateObjLst_Cache;
if (objCacheUseState_Cond.sf_FldComparisonOp == null || objCacheUseState_Cond.sf_FldComparisonOp == "") return arrCacheUseState_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objCacheUseState_Cond.sf_FldComparisonOp);
//console.log("clsCacheUseStateWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objCacheUseState_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objCacheUseState_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrCacheUseState_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objCacheUseState_Cond), cacheUseState_ConstructorName, strThisFuncName);
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
export async function CacheUseState_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(cacheUseState_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cacheUseState_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cacheUseState_ConstructorName, strThisFuncName);
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
export function CacheUseState_GetWebApiUrl(strController: string, strAction: string): string {
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
export function CacheUseState_ReFreshCache(strUserId: string):void
{
const strThisFuncName = "ReFreshCache";

if (IsNullOrEmpty(strUserId) == true)
{
  const strMsg = Format("参数:[strUserId]不能为空！(In clsCacheUseStateWApi.ReFreshCache)");
console.error(strMsg);
 throw (strMsg);
}

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = Format("{0}_{1}", clsCacheUseStateEN._CurrTabName, strUserId);
switch (clsCacheUseStateEN.CacheModeId)
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
export function CacheUseState_ReFreshThisCache(strUserId: string):void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = Format("{0}_{1}", clsCacheUseStateEN._CurrTabName, strUserId);
switch (clsCacheUseStateEN.CacheModeId)
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

/**
 * 绑定基于Web的下拉框,在某一层下的下拉框
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
 * @param objDDL:需要绑定当前表的下拉框
*/
export async function CacheUseState__Cache(strDivName: string, strDdlName: string , strUserId: string)
{
const strThisFuncName = "_Cache";

if (IsNullOrEmpty(strUserId) == true)
{
  const strMsg = Format("参数:[strUserId]不能为空！(In )");
console.error(strMsg);
 throw (strMsg);
}

const objDdl = document.getElementById(strDdlName);
if (objDdl == null)
{
const strMsg = Format("下拉框：{0} 不存在！(In )", strDdlName);
alert(strMsg);
console.error(strMsg);
throw (strMsg);
}
//为数据源于表的下拉框设置内容
//console.log("开始：_Cache");
const arrObjLst_Sel = await CacheUseState_GetObjLst_Cache(strUserId);
if (arrObjLst_Sel == null) return;
BindDdl_ObjLstInDiv(strDivName, strDdlName, arrObjLst_Sel, clsCacheUseStateEN.con_mId, clsCacheUseStateEN.con_UserId, "缓存使用状态");
}

/**
 * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function CacheUseState_CheckPropertyNew(pobjCacheUseStateEN: clsCacheUseStateEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjCacheUseStateEN.userId) === true )
{
 throw new Error("(errid:Watl000058)字段[用户ID]不能为空(In 缓存使用状态)!(clsCacheUseStateBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCacheUseStateEN.cacheModeId) === true )
{
 throw new Error("(errid:Watl000058)字段[缓存方式Id]不能为空(In 缓存使用状态)!(clsCacheUseStateBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCacheUseStateEN.cacheKey) === true )
{
 throw new Error("(errid:Watl000058)字段[缓存关键字]不能为空(In 缓存使用状态)!(clsCacheUseStateBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjCacheUseStateEN.userId) == false && GetStrLen(pobjCacheUseStateEN.userId) > 20)
{
 throw new Error("(errid:Watl000059)字段[用户ID(userId)]的长度不能超过20(In 缓存使用状态(CacheUseState))!值:$(pobjCacheUseStateEN.userId)(clsCacheUseStateBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCacheUseStateEN.cacheModeId) == false && GetStrLen(pobjCacheUseStateEN.cacheModeId) > 2)
{
 throw new Error("(errid:Watl000059)字段[缓存方式Id(cacheModeId)]的长度不能超过2(In 缓存使用状态(CacheUseState))!值:$(pobjCacheUseStateEN.cacheModeId)(clsCacheUseStateBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCacheUseStateEN.cacheKey) == false && GetStrLen(pobjCacheUseStateEN.cacheKey) > 50)
{
 throw new Error("(errid:Watl000059)字段[缓存关键字(cacheKey)]的长度不能超过50(In 缓存使用状态(CacheUseState))!值:$(pobjCacheUseStateEN.cacheKey)(clsCacheUseStateBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCacheUseStateEN.memo) == false && GetStrLen(pobjCacheUseStateEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 缓存使用状态(CacheUseState))!值:$(pobjCacheUseStateEN.memo)(clsCacheUseStateBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null != pobjCacheUseStateEN.mId && undefined !== pobjCacheUseStateEN.mId && tzDataType.isNumber(pobjCacheUseStateEN.mId) === false)
{
 throw new Error("(errid:Watl000060)字段[mId(mId)]的值:[$(pobjCacheUseStateEN.mId)], 非法，应该为数值型(In 缓存使用状态(CacheUseState))!(clsCacheUseStateBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCacheUseStateEN.userId) == false && undefined !== pobjCacheUseStateEN.userId && tzDataType.isString(pobjCacheUseStateEN.userId) === false)
{
 throw new Error("(errid:Watl000060)字段[用户ID(userId)]的值:[$(pobjCacheUseStateEN.userId)], 非法，应该为字符型(In 缓存使用状态(CacheUseState))!(clsCacheUseStateBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCacheUseStateEN.cacheModeId) == false && undefined !== pobjCacheUseStateEN.cacheModeId && tzDataType.isString(pobjCacheUseStateEN.cacheModeId) === false)
{
 throw new Error("(errid:Watl000060)字段[缓存方式Id(cacheModeId)]的值:[$(pobjCacheUseStateEN.cacheModeId)], 非法，应该为字符型(In 缓存使用状态(CacheUseState))!(clsCacheUseStateBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCacheUseStateEN.cacheKey) == false && undefined !== pobjCacheUseStateEN.cacheKey && tzDataType.isString(pobjCacheUseStateEN.cacheKey) === false)
{
 throw new Error("(errid:Watl000060)字段[缓存关键字(cacheKey)]的值:[$(pobjCacheUseStateEN.cacheKey)], 非法，应该为字符型(In 缓存使用状态(CacheUseState))!(clsCacheUseStateBL:CheckPropertyNew)");
}
if (null != pobjCacheUseStateEN.cacheSize && undefined !== pobjCacheUseStateEN.cacheSize && tzDataType.isNumber(pobjCacheUseStateEN.cacheSize) === false)
{
 throw new Error("(errid:Watl000060)字段[缓存大小(cacheSize)]的值:[$(pobjCacheUseStateEN.cacheSize)], 非法，应该为数值型(In 缓存使用状态(CacheUseState))!(clsCacheUseStateBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCacheUseStateEN.memo) == false && undefined !== pobjCacheUseStateEN.memo && tzDataType.isString(pobjCacheUseStateEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjCacheUseStateEN.memo)], 非法，应该为字符型(In 缓存使用状态(CacheUseState))!(clsCacheUseStateBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjCacheUseStateEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function CacheUseState_CheckProperty4Update (pobjCacheUseStateEN: clsCacheUseStateEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjCacheUseStateEN.userId) == false && GetStrLen(pobjCacheUseStateEN.userId) > 20)
{
 throw new Error("(errid:Watl000062)字段[用户ID(userId)]的长度不能超过20(In 缓存使用状态(CacheUseState))!值:$(pobjCacheUseStateEN.userId)(clsCacheUseStateBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCacheUseStateEN.cacheModeId) == false && GetStrLen(pobjCacheUseStateEN.cacheModeId) > 2)
{
 throw new Error("(errid:Watl000062)字段[缓存方式Id(cacheModeId)]的长度不能超过2(In 缓存使用状态(CacheUseState))!值:$(pobjCacheUseStateEN.cacheModeId)(clsCacheUseStateBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCacheUseStateEN.cacheKey) == false && GetStrLen(pobjCacheUseStateEN.cacheKey) > 50)
{
 throw new Error("(errid:Watl000062)字段[缓存关键字(cacheKey)]的长度不能超过50(In 缓存使用状态(CacheUseState))!值:$(pobjCacheUseStateEN.cacheKey)(clsCacheUseStateBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCacheUseStateEN.memo) == false && GetStrLen(pobjCacheUseStateEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 缓存使用状态(CacheUseState))!值:$(pobjCacheUseStateEN.memo)(clsCacheUseStateBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null != pobjCacheUseStateEN.mId && undefined !== pobjCacheUseStateEN.mId && tzDataType.isNumber(pobjCacheUseStateEN.mId) === false)
{
 throw new Error("(errid:Watl000063)字段[mId(mId)]的值:[$(pobjCacheUseStateEN.mId)], 非法，应该为数值型(In 缓存使用状态(CacheUseState))!(clsCacheUseStateBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCacheUseStateEN.userId) == false && undefined !== pobjCacheUseStateEN.userId && tzDataType.isString(pobjCacheUseStateEN.userId) === false)
{
 throw new Error("(errid:Watl000063)字段[用户ID(userId)]的值:[$(pobjCacheUseStateEN.userId)], 非法，应该为字符型(In 缓存使用状态(CacheUseState))!(clsCacheUseStateBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCacheUseStateEN.cacheModeId) == false && undefined !== pobjCacheUseStateEN.cacheModeId && tzDataType.isString(pobjCacheUseStateEN.cacheModeId) === false)
{
 throw new Error("(errid:Watl000063)字段[缓存方式Id(cacheModeId)]的值:[$(pobjCacheUseStateEN.cacheModeId)], 非法，应该为字符型(In 缓存使用状态(CacheUseState))!(clsCacheUseStateBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCacheUseStateEN.cacheKey) == false && undefined !== pobjCacheUseStateEN.cacheKey && tzDataType.isString(pobjCacheUseStateEN.cacheKey) === false)
{
 throw new Error("(errid:Watl000063)字段[缓存关键字(cacheKey)]的值:[$(pobjCacheUseStateEN.cacheKey)], 非法，应该为字符型(In 缓存使用状态(CacheUseState))!(clsCacheUseStateBL:CheckProperty4Update)");
}
if (null != pobjCacheUseStateEN.cacheSize && undefined !== pobjCacheUseStateEN.cacheSize && tzDataType.isNumber(pobjCacheUseStateEN.cacheSize) === false)
{
 throw new Error("(errid:Watl000063)字段[缓存大小(cacheSize)]的值:[$(pobjCacheUseStateEN.cacheSize)], 非法，应该为数值型(In 缓存使用状态(CacheUseState))!(clsCacheUseStateBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCacheUseStateEN.memo) == false && undefined !== pobjCacheUseStateEN.memo && tzDataType.isString(pobjCacheUseStateEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjCacheUseStateEN.memo)], 非法，应该为字符型(In 缓存使用状态(CacheUseState))!(clsCacheUseStateBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjCacheUseStateEN.mId 
 || pobjCacheUseStateEN.mId != null && pobjCacheUseStateEN.mId.toString()  ===  "")
{
 throw new Error("(errid:Watl000064)字段[mId]不能为空(In 缓存使用状态)!(clsCacheUseStateBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjCacheUseStateEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function CacheUseState_GetJSONStrByObj (pobjCacheUseStateEN: clsCacheUseStateEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjCacheUseStateEN.sf_UpdFldSetStr = pobjCacheUseStateEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjCacheUseStateEN);
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
export function CacheUseState_GetObjLstByJSONStr (strJSON: string): Array<clsCacheUseStateEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrCacheUseStateObjLst = new Array<clsCacheUseStateEN>();
if (strJSON === "")
{
return arrCacheUseStateObjLst;
}
try
{
arrCacheUseStateObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrCacheUseStateObjLst;
}
return arrCacheUseStateObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrCacheUseStateObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function CacheUseState_GetObjLstByJSONObjLst (arrCacheUseStateObjLstS: Array<clsCacheUseStateEN>): Array<clsCacheUseStateEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrCacheUseStateObjLst = new Array<clsCacheUseStateEN>();
for (const objInFor of arrCacheUseStateObjLstS) {
const obj1 = CacheUseState_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrCacheUseStateObjLst.push(obj1);
}
return arrCacheUseStateObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function CacheUseState_GetObjByJSONStr (strJSON: string): clsCacheUseStateEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjCacheUseStateEN = new clsCacheUseStateEN();
if (strJSON === "")
{
return pobjCacheUseStateEN;
}
try
{
pobjCacheUseStateEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjCacheUseStateEN;
}
return pobjCacheUseStateEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function CacheUseState_GetCombineCondition(objCacheUseState_Cond: clsCacheUseStateEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objCacheUseState_Cond.dicFldComparisonOp, clsCacheUseStateEN.con_mId) == true)
{
const strComparisonOp_mId:string = objCacheUseState_Cond.dicFldComparisonOp[clsCacheUseStateEN.con_mId];
strWhereCond += Format(" And {0} {2} {1}", clsCacheUseStateEN.con_mId, objCacheUseState_Cond.mId, strComparisonOp_mId);
}
if (Object.prototype.hasOwnProperty.call(objCacheUseState_Cond.dicFldComparisonOp, clsCacheUseStateEN.con_UserId) == true)
{
const strComparisonOp_UserId:string = objCacheUseState_Cond.dicFldComparisonOp[clsCacheUseStateEN.con_UserId];
strWhereCond += Format(" And {0} {2} '{1}'", clsCacheUseStateEN.con_UserId, objCacheUseState_Cond.userId, strComparisonOp_UserId);
}
if (Object.prototype.hasOwnProperty.call(objCacheUseState_Cond.dicFldComparisonOp, clsCacheUseStateEN.con_CacheModeId) == true)
{
const strComparisonOp_CacheModeId:string = objCacheUseState_Cond.dicFldComparisonOp[clsCacheUseStateEN.con_CacheModeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsCacheUseStateEN.con_CacheModeId, objCacheUseState_Cond.cacheModeId, strComparisonOp_CacheModeId);
}
if (Object.prototype.hasOwnProperty.call(objCacheUseState_Cond.dicFldComparisonOp, clsCacheUseStateEN.con_CacheKey) == true)
{
const strComparisonOp_CacheKey:string = objCacheUseState_Cond.dicFldComparisonOp[clsCacheUseStateEN.con_CacheKey];
strWhereCond += Format(" And {0} {2} '{1}'", clsCacheUseStateEN.con_CacheKey, objCacheUseState_Cond.cacheKey, strComparisonOp_CacheKey);
}
if (Object.prototype.hasOwnProperty.call(objCacheUseState_Cond.dicFldComparisonOp, clsCacheUseStateEN.con_CacheSize) == true)
{
const strComparisonOp_CacheSize:string = objCacheUseState_Cond.dicFldComparisonOp[clsCacheUseStateEN.con_CacheSize];
strWhereCond += Format(" And {0} {2} {1}", clsCacheUseStateEN.con_CacheSize, objCacheUseState_Cond.cacheSize, strComparisonOp_CacheSize);
}
if (Object.prototype.hasOwnProperty.call(objCacheUseState_Cond.dicFldComparisonOp, clsCacheUseStateEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objCacheUseState_Cond.dicFldComparisonOp[clsCacheUseStateEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsCacheUseStateEN.con_Memo, objCacheUseState_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--CacheUseState(缓存使用状态),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param lngmId: mId(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function CacheUseState_GetUniCondStr_mId(objCacheUseStateEN: clsCacheUseStateEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and mId = '{0}'", objCacheUseStateEN.mId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--CacheUseState(缓存使用状态),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param lngmId: mId(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function CacheUseState_GetUniCondStr4Update_mId(objCacheUseStateEN: clsCacheUseStateEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and mId <> '{0}'", objCacheUseStateEN.mId);
 strWhereCond +=  Format(" and mId = '{0}'", objCacheUseStateEN.mId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objCacheUseStateENS:源对象
 * @param objCacheUseStateENT:目标对象
*/
export function CacheUseState_CopyObjTo(objCacheUseStateENS: clsCacheUseStateEN , objCacheUseStateENT: clsCacheUseStateEN ): void 
{
objCacheUseStateENT.mId = objCacheUseStateENS.mId; //mId
objCacheUseStateENT.userId = objCacheUseStateENS.userId; //用户ID
objCacheUseStateENT.cacheModeId = objCacheUseStateENS.cacheModeId; //缓存方式Id
objCacheUseStateENT.cacheKey = objCacheUseStateENS.cacheKey; //缓存关键字
objCacheUseStateENT.cacheSize = objCacheUseStateENS.cacheSize; //缓存大小
objCacheUseStateENT.memo = objCacheUseStateENS.memo; //备注
objCacheUseStateENT.sf_UpdFldSetStr = objCacheUseStateENS.updFldString; //sf_UpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objCacheUseStateENS:源对象
 * @param objCacheUseStateENT:目标对象
*/
export function CacheUseState_GetObjFromJsonObj(objCacheUseStateENS: clsCacheUseStateEN): clsCacheUseStateEN 
{
 const objCacheUseStateENT: clsCacheUseStateEN = new clsCacheUseStateEN();
ObjectAssign(objCacheUseStateENT, objCacheUseStateENS);
 return objCacheUseStateENT;
}