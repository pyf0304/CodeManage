
 /**
 * 类名:clsvCacheUseStateWApi
 * 表名:vCacheUseState(01120690)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 12:02:21
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
 * vCacheUseState(vCacheUseState)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clsvCacheUseStateEN } from "../../L0_Entity/SystemSet/clsvCacheUseStateEN.js";
import { BindDdl_ObjLstInDiv_V, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const vCacheUseState_Controller = "vCacheUseStateApi";
 export const vCacheUseState_ConstructorName = "vCacheUseState";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngmId:关键字
 * @returns 对象
 **/
export async function vCacheUseState_GetObjBymIdAsync(lngmId: number): Promise<clsvCacheUseStateEN>  
{
const strThisFuncName = "GetObjBymIdAsync";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In GetObjBymIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjBymId";
const strUrl = GetWebApiUrl(vCacheUseState_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vCacheUseState_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvCacheUseState = vCacheUseState_GetObjFromJsonObj(returnObj);
return objvCacheUseState;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vCacheUseState_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vCacheUseState_ConstructorName, strThisFuncName);
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
export async function vCacheUseState_GetObjBymId_Cache(lngmId:number,strUserId:string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjBymId_Cache";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In GetObjBymId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
const arrvCacheUseStateObjLst_Cache = await vCacheUseState_GetObjLst_Cache(strUserId);
try
{
const arrvCacheUseState_Sel: Array <clsvCacheUseStateEN> = arrvCacheUseStateObjLst_Cache.filter(x => x.mId == lngmId);
let objvCacheUseState: clsvCacheUseStateEN;
if (arrvCacheUseState_Sel.length > 0)
{
objvCacheUseState = arrvCacheUseState_Sel[0];
return objvCacheUseState;
}
else
{
if (bolTryAsyncOnce == true)
{
objvCacheUseState = await vCacheUseState_GetObjBymIdAsync(lngmId);
if (objvCacheUseState != null)
{
vCacheUseState_ReFreshThisCache(strUserId);
return objvCacheUseState;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, vCacheUseState_ConstructorName, strThisFuncName);
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
export async function vCacheUseState_GetObjBymId_localStorage(lngmId: number) {
const strThisFuncName = "GetObjBymId_localStorage";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In GetObjBymId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
const strKey = Format("{0}_{1}", clsvCacheUseStateEN._CurrTabName, lngmId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objvCacheUseState_Cache: clsvCacheUseStateEN = JSON.parse(strTempObj);
return objvCacheUseState_Cache;
}
try
{
const objvCacheUseState = await vCacheUseState_GetObjBymIdAsync(lngmId);
if (objvCacheUseState != null)
{
localStorage.setItem(strKey, JSON.stringify(objvCacheUseState));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objvCacheUseState;
}
return objvCacheUseState;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, vCacheUseState_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
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
 @param strUserId:缓存的分类字段
 * @returns 返回一个输出字段值
*/
export async function vCacheUseState_func(strInFldName:string , strOutFldName:string , strInValue:number , strUserId_C: string)
{
//const strThisFuncName = "func";

if (IsNullOrEmpty(strUserId_C) == true)
{
  const strMsg = Format("参数:[strUserId_C]不能为空！(In func)");
console.error(strMsg);
 throw (strMsg);
}

if (strInFldName != clsvCacheUseStateEN.con_mId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsvCacheUseStateEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clsvCacheUseStateEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const lngmId = Number(strInValue);
if (lngmId == 0)
{
return "";
}
const objvCacheUseState = await vCacheUseState_GetObjBymId_Cache(lngmId , strUserId_C);
if (objvCacheUseState == null) return "";
return objvCacheUseState.GetFldValue(strOutFldName).toString();
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
export function vCacheUseState_SortFun_Defa(a:clsvCacheUseStateEN , b:clsvCacheUseStateEN): number 
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
export function vCacheUseState_SortFun_Defa_2Fld(a:clsvCacheUseStateEN , b:clsvCacheUseStateEN): number 
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
export function vCacheUseState_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsvCacheUseStateEN.con_mId:
return (a: clsvCacheUseStateEN, b: clsvCacheUseStateEN) => {
return a.mId-b.mId;
}
case clsvCacheUseStateEN.con_UserId:
return (a: clsvCacheUseStateEN, b: clsvCacheUseStateEN) => {
return a.userId.localeCompare(b.userId);
}
case clsvCacheUseStateEN.con_CacheModeId:
return (a: clsvCacheUseStateEN, b: clsvCacheUseStateEN) => {
return a.cacheModeId.localeCompare(b.cacheModeId);
}
case clsvCacheUseStateEN.con_CacheModeName:
return (a: clsvCacheUseStateEN, b: clsvCacheUseStateEN) => {
return a.cacheModeName.localeCompare(b.cacheModeName);
}
case clsvCacheUseStateEN.con_CacheModeENName:
return (a: clsvCacheUseStateEN, b: clsvCacheUseStateEN) => {
return a.cacheModeENName.localeCompare(b.cacheModeENName);
}
case clsvCacheUseStateEN.con_CacheKey:
return (a: clsvCacheUseStateEN, b: clsvCacheUseStateEN) => {
return a.cacheKey.localeCompare(b.cacheKey);
}
case clsvCacheUseStateEN.con_CacheSize:
return (a: clsvCacheUseStateEN, b: clsvCacheUseStateEN) => {
return a.cacheSize-b.cacheSize;
}
case clsvCacheUseStateEN.con_Memo:
return (a: clsvCacheUseStateEN, b: clsvCacheUseStateEN) => {
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vCacheUseState]中不存在！(in ${ vCacheUseState_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsvCacheUseStateEN.con_mId:
return (a: clsvCacheUseStateEN, b: clsvCacheUseStateEN) => {
return b.mId-a.mId;
}
case clsvCacheUseStateEN.con_UserId:
return (a: clsvCacheUseStateEN, b: clsvCacheUseStateEN) => {
return b.userId.localeCompare(a.userId);
}
case clsvCacheUseStateEN.con_CacheModeId:
return (a: clsvCacheUseStateEN, b: clsvCacheUseStateEN) => {
return b.cacheModeId.localeCompare(a.cacheModeId);
}
case clsvCacheUseStateEN.con_CacheModeName:
return (a: clsvCacheUseStateEN, b: clsvCacheUseStateEN) => {
return b.cacheModeName.localeCompare(a.cacheModeName);
}
case clsvCacheUseStateEN.con_CacheModeENName:
return (a: clsvCacheUseStateEN, b: clsvCacheUseStateEN) => {
return b.cacheModeENName.localeCompare(a.cacheModeENName);
}
case clsvCacheUseStateEN.con_CacheKey:
return (a: clsvCacheUseStateEN, b: clsvCacheUseStateEN) => {
return b.cacheKey.localeCompare(a.cacheKey);
}
case clsvCacheUseStateEN.con_CacheSize:
return (a: clsvCacheUseStateEN, b: clsvCacheUseStateEN) => {
return b.cacheSize-a.cacheSize;
}
case clsvCacheUseStateEN.con_Memo:
return (a: clsvCacheUseStateEN, b: clsvCacheUseStateEN) => {
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vCacheUseState]中不存在！(in ${ vCacheUseState_ConstructorName}.${ strThisFuncName})`;
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
export async function vCacheUseState_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsvCacheUseStateEN.con_mId:
return (obj: clsvCacheUseStateEN) => {
return obj.mId === value;
}
case clsvCacheUseStateEN.con_UserId:
return (obj: clsvCacheUseStateEN) => {
return obj.userId === value;
}
case clsvCacheUseStateEN.con_CacheModeId:
return (obj: clsvCacheUseStateEN) => {
return obj.cacheModeId === value;
}
case clsvCacheUseStateEN.con_CacheModeName:
return (obj: clsvCacheUseStateEN) => {
return obj.cacheModeName === value;
}
case clsvCacheUseStateEN.con_CacheModeENName:
return (obj: clsvCacheUseStateEN) => {
return obj.cacheModeENName === value;
}
case clsvCacheUseStateEN.con_CacheKey:
return (obj: clsvCacheUseStateEN) => {
return obj.cacheKey === value;
}
case clsvCacheUseStateEN.con_CacheSize:
return (obj: clsvCacheUseStateEN) => {
return obj.cacheSize === value;
}
case clsvCacheUseStateEN.con_Memo:
return (obj: clsvCacheUseStateEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vCacheUseState]中不存在！(in ${ vCacheUseState_ConstructorName}.${ strThisFuncName})`;
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
export async function vCacheUseState_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vCacheUseState_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vCacheUseState_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vCacheUseState_ConstructorName, strThisFuncName);
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
export async function vCacheUseState_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vCacheUseState_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vCacheUseState_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vCacheUseState_ConstructorName, strThisFuncName);
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
export async function vCacheUseState_GetFirstObjAsync(strWhereCond: string): Promise<clsvCacheUseStateEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(vCacheUseState_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vCacheUseState_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvCacheUseState = vCacheUseState_GetObjFromJsonObj(returnObj);
return objvCacheUseState;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vCacheUseState_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vCacheUseState_ConstructorName, strThisFuncName);
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
export async function vCacheUseState_GetObjLst_ClientCache(strUserId: string)
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("UserId='{0}'", strUserId);
const strKey = Format("{0}_{1}", clsvCacheUseStateEN._CurrTabName, strUserId);
clsvCacheUseStateEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvCacheUseStateEN._CurrTabName);
if (IsNullOrEmpty(clsvCacheUseStateEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvCacheUseStateEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrvCacheUseStateExObjLst_Cache: Array<clsvCacheUseStateEN> = CacheHelper.Get(strKey);
const arrvCacheUseStateObjLst_T = vCacheUseState_GetObjLstByJSONObjLst(arrvCacheUseStateExObjLst_Cache);
return arrvCacheUseStateObjLst_T;
}
try
{
const arrvCacheUseStateExObjLst = await vCacheUseState_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrvCacheUseStateExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvCacheUseStateExObjLst.length);
console.log(strInfo);
return arrvCacheUseStateExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vCacheUseState_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vCacheUseState_GetObjLst_localStorage(strUserId: string)
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("UserId='{0}'", strUserId);
const strKey = Format("{0}_{1}", clsvCacheUseStateEN._CurrTabName, strUserId);
clsvCacheUseStateEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvCacheUseStateEN._CurrTabName);
if (IsNullOrEmpty(clsvCacheUseStateEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvCacheUseStateEN.CacheAddiCondition);
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
const arrvCacheUseStateExObjLst_Cache: Array<clsvCacheUseStateEN> = JSON.parse(strTempObjLst);
const arrvCacheUseStateObjLst_T = vCacheUseState_GetObjLstByJSONObjLst(arrvCacheUseStateExObjLst_Cache);
return arrvCacheUseStateObjLst_T;
}
try
{
const arrvCacheUseStateExObjLst = await vCacheUseState_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrvCacheUseStateExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvCacheUseStateExObjLst.length);
console.log(strInfo);
return arrvCacheUseStateExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vCacheUseState_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vCacheUseState_GetObjLst_localStorage_PureCache(strUserId: string)
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("UserId='{0}'", strUserId);
const strKey = Format("{0}_{1}", clsvCacheUseStateEN._CurrTabName, strUserId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrvCacheUseStateObjLst_Cache: Array<clsvCacheUseStateEN> = JSON.parse(strTempObjLst);
return arrvCacheUseStateObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function vCacheUseState_GetObjLstAsync(strWhereCond: string): Promise<Array<clsvCacheUseStateEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(vCacheUseState_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vCacheUseState_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vCacheUseState_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vCacheUseState_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vCacheUseState_ConstructorName, strThisFuncName);
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
export async function vCacheUseState_GetObjLst_sessionStorage(strUserId: string)
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("UserId='{0}'", strUserId);
const strKey = Format("{0}_{1}", clsvCacheUseStateEN._CurrTabName, strUserId);
clsvCacheUseStateEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvCacheUseStateEN._CurrTabName);
if (IsNullOrEmpty(clsvCacheUseStateEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvCacheUseStateEN.CacheAddiCondition);
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
const arrvCacheUseStateExObjLst_Cache: Array<clsvCacheUseStateEN> = JSON.parse(strTempObjLst);
const arrvCacheUseStateObjLst_T = vCacheUseState_GetObjLstByJSONObjLst(arrvCacheUseStateExObjLst_Cache);
return arrvCacheUseStateObjLst_T;
}
try
{
const arrvCacheUseStateExObjLst = await vCacheUseState_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrvCacheUseStateExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvCacheUseStateExObjLst.length);
console.log(strInfo);
return arrvCacheUseStateExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vCacheUseState_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vCacheUseState_GetObjLst_sessionStorage_PureCache(strUserId: string)
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("UserId='{0}'", strUserId);
const strKey = Format("{0}_{1}", clsvCacheUseStateEN._CurrTabName, strUserId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrvCacheUseStateObjLst_Cache: Array<clsvCacheUseStateEN> = JSON.parse(strTempObjLst);
return arrvCacheUseStateObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vCacheUseState_GetObjLst_Cache(strUserId: string): Promise<Array<clsvCacheUseStateEN>>
{
//const strThisFuncName = "GetObjLst_Cache";

if (IsNullOrEmpty(strUserId) == true)
{
const strMsg = Format("缓存分类变量:[UserId]不能为空！");
console.error(strMsg);
throw (strMsg);
}
let arrvCacheUseStateObjLst_Cache;
switch (clsvCacheUseStateEN.CacheModeId)
{
case "04"://sessionStorage
arrvCacheUseStateObjLst_Cache = await vCacheUseState_GetObjLst_sessionStorage(strUserId);
break;
case "03"://localStorage
arrvCacheUseStateObjLst_Cache = await vCacheUseState_GetObjLst_localStorage(strUserId);
break;
case "02"://ClientCache
arrvCacheUseStateObjLst_Cache = await vCacheUseState_GetObjLst_ClientCache(strUserId);
break;
default:
arrvCacheUseStateObjLst_Cache = await vCacheUseState_GetObjLst_ClientCache(strUserId);
break;
}
const arrvCacheUseStateObjLst = vCacheUseState_GetObjLstByJSONObjLst(arrvCacheUseStateObjLst_Cache);
return arrvCacheUseStateObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vCacheUseState_GetObjLst_PureCache(strUserId: string)
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrvCacheUseStateObjLst_Cache;
switch (clsvCacheUseStateEN.CacheModeId)
{
case "04"://sessionStorage
arrvCacheUseStateObjLst_Cache = await vCacheUseState_GetObjLst_sessionStorage_PureCache(strUserId);
break;
case "03"://localStorage
arrvCacheUseStateObjLst_Cache = await vCacheUseState_GetObjLst_localStorage_PureCache(strUserId);
break;
case "02"://ClientCache
arrvCacheUseStateObjLst_Cache = null;
break;
default:
arrvCacheUseStateObjLst_Cache = null;
break;
}
return arrvCacheUseStateObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objlngmId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vCacheUseState_GetSubObjLst_Cache(objvCacheUseState_Cond: clsvCacheUseStateEN,strUserId: string) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrvCacheUseStateObjLst_Cache = await vCacheUseState_GetObjLst_Cache(strUserId);
let arrvCacheUseState_Sel: Array < clsvCacheUseStateEN > = arrvCacheUseStateObjLst_Cache;
if (objvCacheUseState_Cond.sf_FldComparisonOp == null || objvCacheUseState_Cond.sf_FldComparisonOp == "") return arrvCacheUseState_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvCacheUseState_Cond.sf_FldComparisonOp);
//console.log("clsvCacheUseStateWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvCacheUseState_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvCacheUseState_Sel = arrvCacheUseState_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvCacheUseState_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvCacheUseState_Sel = arrvCacheUseState_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvCacheUseState_Sel = arrvCacheUseState_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvCacheUseState_Sel = arrvCacheUseState_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvCacheUseState_Sel = arrvCacheUseState_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvCacheUseState_Sel = arrvCacheUseState_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvCacheUseState_Sel = arrvCacheUseState_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvCacheUseState_Sel = arrvCacheUseState_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvCacheUseState_Sel = arrvCacheUseState_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvCacheUseState_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objvCacheUseState_Cond), vCacheUseState_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvCacheUseStateEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrmId:关键字列表
 * @returns 对象列表
 **/
export async function vCacheUseState_GetObjLstBymIdLstAsync(arrmId: Array<string>): Promise<Array<clsvCacheUseStateEN>>  
{
const strThisFuncName = "GetObjLstBymIdLstAsync";
const strAction = "GetObjLstBymIdLst";
const strUrl = GetWebApiUrl(vCacheUseState_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrmId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vCacheUseState_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vCacheUseState_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vCacheUseState_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vCacheUseState_ConstructorName, strThisFuncName);
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
export async function vCacheUseState_GetObjLstBymIdLst_Cache(arrmIdLst: Array<number>,strUserId: string) {
const strThisFuncName = "GetObjLstBymIdLst_Cache";
try
{
const arrvCacheUseStateObjLst_Cache = await vCacheUseState_GetObjLst_Cache(strUserId);
const arrvCacheUseState_Sel: Array <clsvCacheUseStateEN> = arrvCacheUseStateObjLst_Cache.filter(x => arrmIdLst.indexOf(x.mId)>-1);
return arrvCacheUseState_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrmIdLst.join(","), vCacheUseState_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvCacheUseStateEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function vCacheUseState_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsvCacheUseStateEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(vCacheUseState_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vCacheUseState_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vCacheUseState_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vCacheUseState_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vCacheUseState_ConstructorName, strThisFuncName);
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
export async function vCacheUseState_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsvCacheUseStateEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vCacheUseState_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vCacheUseState_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vCacheUseState_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vCacheUseState_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vCacheUseState_ConstructorName, strThisFuncName);
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
export async function vCacheUseState_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vCacheUseState_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vCacheUseState_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vCacheUseState_ConstructorName, strThisFuncName);
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
export async function vCacheUseState_GetObjLstByPager_Cache(objPagerPara: stuPagerPara,strUserId: string) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrvCacheUseStateObjLst_Cache = await vCacheUseState_GetObjLst_Cache(strUserId);
if (arrvCacheUseStateObjLst_Cache.length == 0) return arrvCacheUseStateObjLst_Cache;
let arrvCacheUseState_Sel = arrvCacheUseStateObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objvCacheUseState_Cond = new clsvCacheUseStateEN();
ObjectAssign(objvCacheUseState_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsvCacheUseStateWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvCacheUseState_Sel = arrvCacheUseState_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvCacheUseState_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvCacheUseState_Sel = arrvCacheUseState_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvCacheUseState_Sel = arrvCacheUseState_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvCacheUseState_Sel = arrvCacheUseState_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvCacheUseState_Sel = arrvCacheUseState_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvCacheUseState_Sel = arrvCacheUseState_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvCacheUseState_Sel = arrvCacheUseState_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvCacheUseState_Sel = arrvCacheUseState_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvCacheUseState_Sel = arrvCacheUseState_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvCacheUseState_Sel = arrvCacheUseState_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvCacheUseState_Sel.length == 0) return arrvCacheUseState_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrvCacheUseState_Sel = arrvCacheUseState_Sel.sort(vCacheUseState_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrvCacheUseState_Sel = arrvCacheUseState_Sel.sort(objPagerPara.sortFun);
}
arrvCacheUseState_Sel = arrvCacheUseState_Sel.slice(intStart, intEnd);     
return arrvCacheUseState_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, vCacheUseState_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvCacheUseStateEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function vCacheUseState_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsvCacheUseStateEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(vCacheUseState_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vCacheUseState_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vCacheUseState_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vCacheUseState_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vCacheUseState_ConstructorName, strThisFuncName);
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
export async function vCacheUseState_IsExistRecord_Cache(objvCacheUseState_Cond: clsvCacheUseStateEN,strUserId: string) {
const strThisFuncName = "IsExistRecord_Cache";
const arrvCacheUseStateObjLst_Cache = await vCacheUseState_GetObjLst_Cache(strUserId);
if (arrvCacheUseStateObjLst_Cache == null) return false;
let arrvCacheUseState_Sel: Array < clsvCacheUseStateEN > = arrvCacheUseStateObjLst_Cache;
if (objvCacheUseState_Cond.sf_FldComparisonOp == null || objvCacheUseState_Cond.sf_FldComparisonOp == "") return arrvCacheUseState_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvCacheUseState_Cond.sf_FldComparisonOp);
//console.log("clsvCacheUseStateWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvCacheUseState_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvCacheUseState_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvCacheUseState_Sel = arrvCacheUseState_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvCacheUseState_Sel = arrvCacheUseState_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvCacheUseState_Sel = arrvCacheUseState_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvCacheUseState_Sel = arrvCacheUseState_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvCacheUseState_Sel = arrvCacheUseState_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvCacheUseState_Sel = arrvCacheUseState_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvCacheUseState_Sel = arrvCacheUseState_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvCacheUseState_Sel = arrvCacheUseState_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvCacheUseState_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objvCacheUseState_Cond), vCacheUseState_ConstructorName, strThisFuncName);
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
export async function vCacheUseState_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(vCacheUseState_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vCacheUseState_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vCacheUseState_ConstructorName, strThisFuncName);
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
export async function vCacheUseState_IsExist(lngmId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vCacheUseState_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vCacheUseState_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vCacheUseState_ConstructorName, strThisFuncName);
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
export async function vCacheUseState_IsExist_Cache(lngmId:number,strUserId:string) {
const strThisFuncName = "IsExist_Cache";
const arrvCacheUseStateObjLst_Cache = await vCacheUseState_GetObjLst_Cache(strUserId);
if (arrvCacheUseStateObjLst_Cache == null) return false;
try
{
const arrvCacheUseState_Sel: Array <clsvCacheUseStateEN> = arrvCacheUseStateObjLst_Cache.filter(x => x.mId == lngmId);
if (arrvCacheUseState_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngmId, vCacheUseState_ConstructorName, strThisFuncName);
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
export async function vCacheUseState_IsExistAsync(lngmId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vCacheUseState_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vCacheUseState_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vCacheUseState_ConstructorName, strThisFuncName);
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
export async function vCacheUseState_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(vCacheUseState_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vCacheUseState_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vCacheUseState_ConstructorName, strThisFuncName);
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
 * @param objvCacheUseState_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function vCacheUseState_GetRecCountByCond_Cache(objvCacheUseState_Cond: clsvCacheUseStateEN,strUserId: string) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrvCacheUseStateObjLst_Cache = await vCacheUseState_GetObjLst_Cache(strUserId);
if (arrvCacheUseStateObjLst_Cache == null) return 0;
let arrvCacheUseState_Sel: Array < clsvCacheUseStateEN > = arrvCacheUseStateObjLst_Cache;
if (objvCacheUseState_Cond.sf_FldComparisonOp == null || objvCacheUseState_Cond.sf_FldComparisonOp == "") return arrvCacheUseState_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvCacheUseState_Cond.sf_FldComparisonOp);
//console.log("clsvCacheUseStateWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvCacheUseState_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvCacheUseState_Sel = arrvCacheUseState_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvCacheUseState_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvCacheUseState_Sel = arrvCacheUseState_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvCacheUseState_Sel = arrvCacheUseState_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvCacheUseState_Sel = arrvCacheUseState_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvCacheUseState_Sel = arrvCacheUseState_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvCacheUseState_Sel = arrvCacheUseState_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvCacheUseState_Sel = arrvCacheUseState_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvCacheUseState_Sel = arrvCacheUseState_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvCacheUseState_Sel = arrvCacheUseState_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvCacheUseState_Sel = arrvCacheUseState_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvCacheUseState_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objvCacheUseState_Cond), vCacheUseState_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return 0;
}

/**
 * 获取WebApi的地址
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
 * @returns 返回当前文件中Web服务的地址
*/
export function vCacheUseState_GetWebApiUrl(strController: string, strAction: string): string {
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
 * 刷新本类中的缓存.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
 **/
export function vCacheUseState_ReFreshThisCache(strUserId: string):void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = Format("{0}_{1}", clsvCacheUseStateEN._CurrTabName, strUserId);
switch (clsvCacheUseStateEN.CacheModeId)
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
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vCacheUseState_GetJSONStrByObj (pobjvCacheUseStateEN: clsvCacheUseStateEN): string
{
const strThisFuncName = "GetJSONStrByObj";
let strJson = "";
try
{
strJson = JSON.stringify(pobjvCacheUseStateEN);
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
export function vCacheUseState_GetObjLstByJSONStr (strJSON: string): Array<clsvCacheUseStateEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrvCacheUseStateObjLst = new Array<clsvCacheUseStateEN>();
if (strJSON === "")
{
return arrvCacheUseStateObjLst;
}
try
{
arrvCacheUseStateObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvCacheUseStateObjLst;
}
return arrvCacheUseStateObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrvCacheUseStateObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function vCacheUseState_GetObjLstByJSONObjLst (arrvCacheUseStateObjLstS: Array<clsvCacheUseStateEN>): Array<clsvCacheUseStateEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrvCacheUseStateObjLst = new Array<clsvCacheUseStateEN>();
for (const objInFor of arrvCacheUseStateObjLstS) {
const obj1 = vCacheUseState_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrvCacheUseStateObjLst.push(obj1);
}
return arrvCacheUseStateObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vCacheUseState_GetObjByJSONStr (strJSON: string): clsvCacheUseStateEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjvCacheUseStateEN = new clsvCacheUseStateEN();
if (strJSON === "")
{
return pobjvCacheUseStateEN;
}
try
{
pobjvCacheUseStateEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvCacheUseStateEN;
}
return pobjvCacheUseStateEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function vCacheUseState_GetCombineCondition(objvCacheUseState_Cond: clsvCacheUseStateEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objvCacheUseState_Cond.dicFldComparisonOp, clsvCacheUseStateEN.con_mId) == true)
{
const strComparisonOp_mId:string = objvCacheUseState_Cond.dicFldComparisonOp[clsvCacheUseStateEN.con_mId];
strWhereCond += Format(" And {0} {2} {1}", clsvCacheUseStateEN.con_mId, objvCacheUseState_Cond.mId, strComparisonOp_mId);
}
if (Object.prototype.hasOwnProperty.call(objvCacheUseState_Cond.dicFldComparisonOp, clsvCacheUseStateEN.con_UserId) == true)
{
const strComparisonOp_UserId:string = objvCacheUseState_Cond.dicFldComparisonOp[clsvCacheUseStateEN.con_UserId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCacheUseStateEN.con_UserId, objvCacheUseState_Cond.userId, strComparisonOp_UserId);
}
if (Object.prototype.hasOwnProperty.call(objvCacheUseState_Cond.dicFldComparisonOp, clsvCacheUseStateEN.con_CacheModeId) == true)
{
const strComparisonOp_CacheModeId:string = objvCacheUseState_Cond.dicFldComparisonOp[clsvCacheUseStateEN.con_CacheModeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCacheUseStateEN.con_CacheModeId, objvCacheUseState_Cond.cacheModeId, strComparisonOp_CacheModeId);
}
if (Object.prototype.hasOwnProperty.call(objvCacheUseState_Cond.dicFldComparisonOp, clsvCacheUseStateEN.con_CacheModeName) == true)
{
const strComparisonOp_CacheModeName:string = objvCacheUseState_Cond.dicFldComparisonOp[clsvCacheUseStateEN.con_CacheModeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCacheUseStateEN.con_CacheModeName, objvCacheUseState_Cond.cacheModeName, strComparisonOp_CacheModeName);
}
if (Object.prototype.hasOwnProperty.call(objvCacheUseState_Cond.dicFldComparisonOp, clsvCacheUseStateEN.con_CacheModeENName) == true)
{
const strComparisonOp_CacheModeENName:string = objvCacheUseState_Cond.dicFldComparisonOp[clsvCacheUseStateEN.con_CacheModeENName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCacheUseStateEN.con_CacheModeENName, objvCacheUseState_Cond.cacheModeENName, strComparisonOp_CacheModeENName);
}
if (Object.prototype.hasOwnProperty.call(objvCacheUseState_Cond.dicFldComparisonOp, clsvCacheUseStateEN.con_CacheKey) == true)
{
const strComparisonOp_CacheKey:string = objvCacheUseState_Cond.dicFldComparisonOp[clsvCacheUseStateEN.con_CacheKey];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCacheUseStateEN.con_CacheKey, objvCacheUseState_Cond.cacheKey, strComparisonOp_CacheKey);
}
if (Object.prototype.hasOwnProperty.call(objvCacheUseState_Cond.dicFldComparisonOp, clsvCacheUseStateEN.con_CacheSize) == true)
{
const strComparisonOp_CacheSize:string = objvCacheUseState_Cond.dicFldComparisonOp[clsvCacheUseStateEN.con_CacheSize];
strWhereCond += Format(" And {0} {2} {1}", clsvCacheUseStateEN.con_CacheSize, objvCacheUseState_Cond.cacheSize, strComparisonOp_CacheSize);
}
if (Object.prototype.hasOwnProperty.call(objvCacheUseState_Cond.dicFldComparisonOp, clsvCacheUseStateEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objvCacheUseState_Cond.dicFldComparisonOp[clsvCacheUseStateEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCacheUseStateEN.con_Memo, objvCacheUseState_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--vCacheUseState(vCacheUseState),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param lngmId: mId(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function vCacheUseState_GetUniCondStr_mId(objvCacheUseStateEN: clsvCacheUseStateEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and mId = '{0}'", objvCacheUseStateEN.mId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--vCacheUseState(vCacheUseState),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param lngmId: mId(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function vCacheUseState_GetUniCondStr4Update_mId(objvCacheUseStateEN: clsvCacheUseStateEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and mId <> '{0}'", objvCacheUseStateEN.mId);
 strWhereCond +=  Format(" and mId = '{0}'", objvCacheUseStateEN.mId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objvCacheUseStateENS:源对象
 * @param objvCacheUseStateENT:目标对象
*/
export function vCacheUseState_CopyObjTo(objvCacheUseStateENS: clsvCacheUseStateEN , objvCacheUseStateENT: clsvCacheUseStateEN ): void 
{
objvCacheUseStateENT.mId = objvCacheUseStateENS.mId; //mId
objvCacheUseStateENT.userId = objvCacheUseStateENS.userId; //用户ID
objvCacheUseStateENT.cacheModeId = objvCacheUseStateENS.cacheModeId; //缓存方式Id
objvCacheUseStateENT.cacheModeName = objvCacheUseStateENS.cacheModeName; //缓存方式名
objvCacheUseStateENT.cacheModeENName = objvCacheUseStateENS.cacheModeENName; //缓存方式英文名
objvCacheUseStateENT.cacheKey = objvCacheUseStateENS.cacheKey; //缓存关键字
objvCacheUseStateENT.cacheSize = objvCacheUseStateENS.cacheSize; //缓存大小
objvCacheUseStateENT.memo = objvCacheUseStateENS.memo; //备注
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objvCacheUseStateENS:源对象
 * @param objvCacheUseStateENT:目标对象
*/
export function vCacheUseState_GetObjFromJsonObj(objvCacheUseStateENS: clsvCacheUseStateEN): clsvCacheUseStateEN 
{
 const objvCacheUseStateENT: clsvCacheUseStateEN = new clsvCacheUseStateEN();
ObjectAssign(objvCacheUseStateENT, objvCacheUseStateENS);
 return objvCacheUseStateENT;
}