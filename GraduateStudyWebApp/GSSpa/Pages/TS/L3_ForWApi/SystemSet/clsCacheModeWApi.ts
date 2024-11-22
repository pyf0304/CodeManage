
 /**
 * 类名:clsCacheModeWApi
 * 表名:CacheMode(01120688)
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
 * 缓存方式(CacheMode)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clsCacheModeEN } from "../../L0_Entity/SystemSet/clsCacheModeEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { tzDataType } from "../../PubFun/jsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const cacheMode_Controller = "CacheModeApi";
 export const cacheMode_ConstructorName = "cacheMode";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strCacheModeId:关键字
 * @returns 对象
 **/
export async function CacheMode_GetObjByCacheModeIdAsync(strCacheModeId: string): Promise<clsCacheModeEN>  
{
const strThisFuncName = "GetObjByCacheModeIdAsync";

if (IsNullOrEmpty(strCacheModeId) == true)
{
  const strMsg = Format("参数:[strCacheModeId]不能为空！(In GetObjByCacheModeIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strCacheModeId.length != 2)
{
const strMsg = Format("缓存分类变量:[strCacheModeId]的长度:[{0}]不正确！", strCacheModeId.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByCacheModeId";
const strUrl = GetWebApiUrl(cacheMode_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strCacheModeId": strCacheModeId,
}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObj = data.returnObj;
if (returnObj == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", cacheMode_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objCacheMode = CacheMode_GetObjFromJsonObj(returnObj);
return objCacheMode;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cacheMode_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cacheMode_ConstructorName, strThisFuncName);
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
 * @param strCacheModeId:所给的关键字
 * @returns 对象
*/
export async function CacheMode_GetObjByCacheModeId_Cache(strCacheModeId: string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByCacheModeId_Cache";

if (IsNullOrEmpty(strCacheModeId) == true)
{
  const strMsg = Format("参数:[strCacheModeId]不能为空！(In GetObjByCacheModeId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strCacheModeId.length != 2)
{
const strMsg = Format("缓存分类变量:[strCacheModeId]的长度:[{0}]不正确！", strCacheModeId.length);
console.error(strMsg);
throw (strMsg);
}
const arrCacheModeObjLst_Cache = await CacheMode_GetObjLst_Cache();
try
{
const arrCacheMode_Sel: Array <clsCacheModeEN> = arrCacheModeObjLst_Cache.filter(x => x.cacheModeId == strCacheModeId);
let objCacheMode: clsCacheModeEN;
if (arrCacheMode_Sel.length > 0)
{
objCacheMode = arrCacheMode_Sel[0];
return objCacheMode;
}
else
{
if (bolTryAsyncOnce == true)
{
objCacheMode = await CacheMode_GetObjByCacheModeIdAsync(strCacheModeId);
if (objCacheMode != null)
{
CacheMode_ReFreshThisCache();
return objCacheMode;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strCacheModeId, cacheMode_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param strCacheModeId:所给的关键字
 * @returns 对象
*/
export async function CacheMode_GetObjByCacheModeId_localStorage(strCacheModeId: string) {
const strThisFuncName = "GetObjByCacheModeId_localStorage";

if (IsNullOrEmpty(strCacheModeId) == true)
{
  const strMsg = Format("参数:[strCacheModeId]不能为空！(In GetObjByCacheModeId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
if (strCacheModeId.length != 2)
{
const strMsg = Format("缓存分类变量:[strCacheModeId]的长度:[{0}]不正确！", strCacheModeId.length);
console.error(strMsg);
throw (strMsg);
}
const strKey = Format("{0}_{1}", clsCacheModeEN._CurrTabName, strCacheModeId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objCacheMode_Cache: clsCacheModeEN = JSON.parse(strTempObj);
return objCacheMode_Cache;
}
try
{
const objCacheMode = await CacheMode_GetObjByCacheModeIdAsync(strCacheModeId);
if (objCacheMode != null)
{
localStorage.setItem(strKey, JSON.stringify(objCacheMode));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objCacheMode;
}
return objCacheMode;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strCacheModeId, cacheMode_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objCacheMode:所给的对象
 * @returns 对象
*/
export async function CacheMode_UpdateObjInLst_Cache(objCacheMode: clsCacheModeEN) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrCacheModeObjLst_Cache = await CacheMode_GetObjLst_Cache();
const obj = arrCacheModeObjLst_Cache.find(x => x.cacheModeId == objCacheMode.cacheModeId);
if (obj != null)
{
objCacheMode.cacheModeId = obj.cacheModeId;
ObjectAssign( obj, objCacheMode);
}
else
{
arrCacheModeObjLst_Cache.push(objCacheMode);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, cacheMode_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
}

/**
 * 根据关键字获取相关对象的名称属性, 从缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
 * @param strCacheModeId:所给的关键字
 * @returns 对象
*/
export async function CacheMode_GetNameByCacheModeId_Cache(strCacheModeId: string) {
const strThisFuncName = "GetNameByCacheModeId_Cache";

if (IsNullOrEmpty(strCacheModeId) == true)
{
  const strMsg = Format("参数:[strCacheModeId]不能为空！(In GetNameByCacheModeId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strCacheModeId.length != 2)
{
const strMsg = Format("缓存分类变量:[strCacheModeId]的长度:[{0}]不正确！", strCacheModeId.length);
console.error(strMsg);
throw (strMsg);
}
const arrCacheModeObjLst_Cache = await CacheMode_GetObjLst_Cache();
if (arrCacheModeObjLst_Cache == null) return "";
try
{
const arrCacheMode_Sel: Array <clsCacheModeEN> = arrCacheModeObjLst_Cache.filter(x => x.cacheModeId == strCacheModeId);
let objCacheMode: clsCacheModeEN;
if (arrCacheMode_Sel.length > 0)
{
objCacheMode = arrCacheMode_Sel[0];
return objCacheMode.cacheModeName;
}
else
{
return "";
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strCacheModeId);
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
 * @returns 返回一个输出字段值
*/
export async function CacheMode_func(strInFldName:string , strOutFldName:string ,  strInValue: string) 
{
//const strThisFuncName = "func";

if (strInFldName != clsCacheModeEN.con_CacheModeId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsCacheModeEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clsCacheModeEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strCacheModeId = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objCacheMode = await CacheMode_GetObjByCacheModeId_Cache(strCacheModeId );
if (objCacheMode == null) return "";
return objCacheMode.GetFldValue(strOutFldName).toString();
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
export function CacheMode_SortFun_Defa(a:clsCacheModeEN , b:clsCacheModeEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.cacheModeId.localeCompare(b.cacheModeId);
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
export function CacheMode_SortFun_Defa_2Fld(a:clsCacheModeEN , b:clsCacheModeEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.cacheModeName == b.cacheModeName) return a.cacheModeENName.localeCompare(b.cacheModeENName);
else return a.cacheModeName.localeCompare(b.cacheModeName);
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
export function CacheMode_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsCacheModeEN.con_CacheModeId:
return (a: clsCacheModeEN, b: clsCacheModeEN) => {
return a.cacheModeId.localeCompare(b.cacheModeId);
}
case clsCacheModeEN.con_CacheModeName:
return (a: clsCacheModeEN, b: clsCacheModeEN) => {
return a.cacheModeName.localeCompare(b.cacheModeName);
}
case clsCacheModeEN.con_CacheModeENName:
return (a: clsCacheModeEN, b: clsCacheModeEN) => {
return a.cacheModeENName.localeCompare(b.cacheModeENName);
}
case clsCacheModeEN.con_Memo:
return (a: clsCacheModeEN, b: clsCacheModeEN) => {
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[CacheMode]中不存在！(in ${ cacheMode_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsCacheModeEN.con_CacheModeId:
return (a: clsCacheModeEN, b: clsCacheModeEN) => {
return b.cacheModeId.localeCompare(a.cacheModeId);
}
case clsCacheModeEN.con_CacheModeName:
return (a: clsCacheModeEN, b: clsCacheModeEN) => {
return b.cacheModeName.localeCompare(a.cacheModeName);
}
case clsCacheModeEN.con_CacheModeENName:
return (a: clsCacheModeEN, b: clsCacheModeEN) => {
return b.cacheModeENName.localeCompare(a.cacheModeENName);
}
case clsCacheModeEN.con_Memo:
return (a: clsCacheModeEN, b: clsCacheModeEN) => {
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[CacheMode]中不存在！(in ${ cacheMode_ConstructorName}.${ strThisFuncName})`;
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
export async function CacheMode_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsCacheModeEN.con_CacheModeId:
return (obj: clsCacheModeEN) => {
return obj.cacheModeId === value;
}
case clsCacheModeEN.con_CacheModeName:
return (obj: clsCacheModeEN) => {
return obj.cacheModeName === value;
}
case clsCacheModeEN.con_CacheModeENName:
return (obj: clsCacheModeEN) => {
return obj.cacheModeENName === value;
}
case clsCacheModeEN.con_Memo:
return (obj: clsCacheModeEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[CacheMode]中不存在！(in ${ cacheMode_ConstructorName}.${ strThisFuncName})`;
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
export async function CacheMode_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(cacheMode_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cacheMode_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cacheMode_ConstructorName, strThisFuncName);
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
export async function CacheMode_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(cacheMode_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cacheMode_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cacheMode_ConstructorName, strThisFuncName);
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
export async function CacheMode_GetFirstObjAsync(strWhereCond: string): Promise<clsCacheModeEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(cacheMode_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", cacheMode_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objCacheMode = CacheMode_GetObjFromJsonObj(returnObj);
return objCacheMode;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cacheMode_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cacheMode_ConstructorName, strThisFuncName);
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
export async function CacheMode_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsCacheModeEN._CurrTabName;
clsCacheModeEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsCacheModeEN._CurrTabName);
if (IsNullOrEmpty(clsCacheModeEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsCacheModeEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrCacheModeExObjLst_Cache: Array<clsCacheModeEN> = CacheHelper.Get(strKey);
const arrCacheModeObjLst_T = CacheMode_GetObjLstByJSONObjLst(arrCacheModeExObjLst_Cache);
return arrCacheModeObjLst_T;
}
try
{
const arrCacheModeExObjLst = await CacheMode_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrCacheModeExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrCacheModeExObjLst.length);
console.log(strInfo);
return arrCacheModeExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, cacheMode_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function CacheMode_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsCacheModeEN._CurrTabName;
clsCacheModeEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsCacheModeEN._CurrTabName);
if (IsNullOrEmpty(clsCacheModeEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsCacheModeEN.CacheAddiCondition);
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
const arrCacheModeExObjLst_Cache: Array<clsCacheModeEN> = JSON.parse(strTempObjLst);
const arrCacheModeObjLst_T = CacheMode_GetObjLstByJSONObjLst(arrCacheModeExObjLst_Cache);
return arrCacheModeObjLst_T;
}
try
{
const arrCacheModeExObjLst = await CacheMode_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrCacheModeExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrCacheModeExObjLst.length);
console.log(strInfo);
return arrCacheModeExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, cacheMode_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function CacheMode_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsCacheModeEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrCacheModeObjLst_Cache: Array<clsCacheModeEN> = JSON.parse(strTempObjLst);
return arrCacheModeObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function CacheMode_GetObjLstAsync(strWhereCond: string): Promise<Array<clsCacheModeEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(cacheMode_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", cacheMode_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = CacheMode_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cacheMode_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cacheMode_ConstructorName, strThisFuncName);
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
export async function CacheMode_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsCacheModeEN._CurrTabName;
clsCacheModeEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsCacheModeEN._CurrTabName);
if (IsNullOrEmpty(clsCacheModeEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsCacheModeEN.CacheAddiCondition);
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
const arrCacheModeExObjLst_Cache: Array<clsCacheModeEN> = JSON.parse(strTempObjLst);
const arrCacheModeObjLst_T = CacheMode_GetObjLstByJSONObjLst(arrCacheModeExObjLst_Cache);
return arrCacheModeObjLst_T;
}
try
{
const arrCacheModeExObjLst = await CacheMode_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrCacheModeExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrCacheModeExObjLst.length);
console.log(strInfo);
return arrCacheModeExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, cacheMode_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function CacheMode_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsCacheModeEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrCacheModeObjLst_Cache: Array<clsCacheModeEN> = JSON.parse(strTempObjLst);
return arrCacheModeObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function CacheMode_GetObjLst_Cache(): Promise<Array<clsCacheModeEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrCacheModeObjLst_Cache;
switch (clsCacheModeEN.CacheModeId)
{
case "04"://sessionStorage
arrCacheModeObjLst_Cache = await CacheMode_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrCacheModeObjLst_Cache = await CacheMode_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrCacheModeObjLst_Cache = await CacheMode_GetObjLst_ClientCache();
break;
default:
arrCacheModeObjLst_Cache = await CacheMode_GetObjLst_ClientCache();
break;
}
const arrCacheModeObjLst = CacheMode_GetObjLstByJSONObjLst(arrCacheModeObjLst_Cache);
return arrCacheModeObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function CacheMode_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrCacheModeObjLst_Cache;
switch (clsCacheModeEN.CacheModeId)
{
case "04"://sessionStorage
arrCacheModeObjLst_Cache = await CacheMode_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrCacheModeObjLst_Cache = await CacheMode_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrCacheModeObjLst_Cache = null;
break;
default:
arrCacheModeObjLst_Cache = null;
break;
}
return arrCacheModeObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrCacheModeId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function CacheMode_GetSubObjLst_Cache(objCacheMode_Cond: clsCacheModeEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrCacheModeObjLst_Cache = await CacheMode_GetObjLst_Cache();
let arrCacheMode_Sel: Array < clsCacheModeEN > = arrCacheModeObjLst_Cache;
if (objCacheMode_Cond.sf_FldComparisonOp == null || objCacheMode_Cond.sf_FldComparisonOp == "") return arrCacheMode_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objCacheMode_Cond.sf_FldComparisonOp);
//console.log("clsCacheModeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objCacheMode_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objCacheMode_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrCacheMode_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objCacheMode_Cond), cacheMode_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsCacheModeEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrCacheModeId:关键字列表
 * @returns 对象列表
 **/
export async function CacheMode_GetObjLstByCacheModeIdLstAsync(arrCacheModeId: Array<string>): Promise<Array<clsCacheModeEN>>  
{
const strThisFuncName = "GetObjLstByCacheModeIdLstAsync";
const strAction = "GetObjLstByCacheModeIdLst";
const strUrl = GetWebApiUrl(cacheMode_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrCacheModeId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", cacheMode_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = CacheMode_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cacheMode_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cacheMode_ConstructorName, strThisFuncName);
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
 * @param arrstrCacheModeIdLst:关键字列表
 * @returns 对象列表
*/
export async function CacheMode_GetObjLstByCacheModeIdLst_Cache(arrCacheModeIdLst: Array<string>) {
const strThisFuncName = "GetObjLstByCacheModeIdLst_Cache";
try
{
const arrCacheModeObjLst_Cache = await CacheMode_GetObjLst_Cache();
const arrCacheMode_Sel: Array <clsCacheModeEN> = arrCacheModeObjLst_Cache.filter(x => arrCacheModeIdLst.indexOf(x.cacheModeId)>-1);
return arrCacheMode_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrCacheModeIdLst.join(","), cacheMode_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsCacheModeEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function CacheMode_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsCacheModeEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(cacheMode_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", cacheMode_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = CacheMode_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cacheMode_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cacheMode_ConstructorName, strThisFuncName);
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
export async function CacheMode_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsCacheModeEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(cacheMode_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", cacheMode_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = CacheMode_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cacheMode_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cacheMode_ConstructorName, strThisFuncName);
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
export async function CacheMode_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(cacheMode_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cacheMode_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cacheMode_ConstructorName, strThisFuncName);
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
export async function CacheMode_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrCacheModeObjLst_Cache = await CacheMode_GetObjLst_Cache();
if (arrCacheModeObjLst_Cache.length == 0) return arrCacheModeObjLst_Cache;
let arrCacheMode_Sel = arrCacheModeObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objCacheMode_Cond = new clsCacheModeEN();
ObjectAssign(objCacheMode_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsCacheModeWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objCacheMode_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrCacheMode_Sel = arrCacheMode_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrCacheMode_Sel.length == 0) return arrCacheMode_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrCacheMode_Sel = arrCacheMode_Sel.sort(CacheMode_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrCacheMode_Sel = arrCacheMode_Sel.sort(objPagerPara.sortFun);
}
arrCacheMode_Sel = arrCacheMode_Sel.slice(intStart, intEnd);     
return arrCacheMode_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, cacheMode_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsCacheModeEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function CacheMode_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsCacheModeEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(cacheMode_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", cacheMode_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = CacheMode_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cacheMode_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cacheMode_ConstructorName, strThisFuncName);
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
 * @param strCacheModeId:关键字
 * @returns 获取删除的结果
 **/
export async function CacheMode_DelRecordAsync(strCacheModeId: string): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(cacheMode_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, strCacheModeId);
try
{
const response = await axios.delete(strUrl,
{
params: { "Id": strCacheModeId, }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cacheMode_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cacheMode_ConstructorName, strThisFuncName);
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
 * @param arrCacheModeId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function CacheMode_DelCacheModesAsync(arrCacheModeId: Array<string>): Promise<number> 
{
const strThisFuncName = "DelCacheModesAsync";
const strAction = "DelCacheModes";
const strUrl = GetWebApiUrl(cacheMode_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrCacheModeId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cacheMode_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cacheMode_ConstructorName, strThisFuncName);
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
export async function CacheMode_DelCacheModesByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "DelCacheModesByCondAsync";
const strAction = "DelCacheModesByCond";
const strUrl = GetWebApiUrl(cacheMode_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cacheMode_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cacheMode_ConstructorName, strThisFuncName);
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
 * @param objCacheModeEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function CacheMode_AddNewRecordAsync(objCacheModeEN: clsCacheModeEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objCacheModeEN);
const strUrl = GetWebApiUrl(cacheMode_Controller, strAction);
try
{
const response = await axios.post(strUrl, objCacheModeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cacheMode_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cacheMode_ConstructorName, strThisFuncName);
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
 * @param objCacheModeEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function CacheMode_AddNewRecordWithMaxIdAsync(objCacheModeEN: clsCacheModeEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithMaxIdAsync";
const strAction = "AddNewRecordWithMaxId";
const strUrl = GetWebApiUrl(cacheMode_Controller, strAction);
try
{
const response = await axios.post(strUrl, objCacheModeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cacheMode_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cacheMode_ConstructorName, strThisFuncName);
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
 * @param objCacheModeEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function CacheMode_AddNewRecordWithReturnKeyAsync(objCacheModeEN: clsCacheModeEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(cacheMode_Controller, strAction);
try
{
const response = await axios.post(strUrl, objCacheModeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cacheMode_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cacheMode_ConstructorName, strThisFuncName);
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
 * @param objCacheModeEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function CacheMode_AddNewRecordWithReturnKey(objCacheModeEN: clsCacheModeEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objCacheModeEN.cacheModeId === null || objCacheModeEN.cacheModeId === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(cacheMode_Controller, strAction);
try
{
const response = await axios.post(strUrl, objCacheModeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cacheMode_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cacheMode_ConstructorName, strThisFuncName);
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
 * @param objCacheModeEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function CacheMode_UpdateRecordAsync(objCacheModeEN: clsCacheModeEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objCacheModeEN.sf_UpdFldSetStr === undefined || objCacheModeEN.sf_UpdFldSetStr === null || objCacheModeEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objCacheModeEN.cacheModeId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(cacheMode_Controller, strAction);
try
{
const response = await axios.post(strUrl, objCacheModeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cacheMode_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cacheMode_ConstructorName, strThisFuncName);
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
 * @param objCacheModeEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function CacheMode_UpdateWithConditionAsync(objCacheModeEN: clsCacheModeEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objCacheModeEN.sf_UpdFldSetStr === undefined || objCacheModeEN.sf_UpdFldSetStr === null || objCacheModeEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objCacheModeEN.cacheModeId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(cacheMode_Controller, strAction);
objCacheModeEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objCacheModeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cacheMode_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cacheMode_ConstructorName, strThisFuncName);
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
 * @param objstrCacheModeId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function CacheMode_IsExistRecord_Cache(objCacheMode_Cond: clsCacheModeEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrCacheModeObjLst_Cache = await CacheMode_GetObjLst_Cache();
if (arrCacheModeObjLst_Cache == null) return false;
let arrCacheMode_Sel: Array < clsCacheModeEN > = arrCacheModeObjLst_Cache;
if (objCacheMode_Cond.sf_FldComparisonOp == null || objCacheMode_Cond.sf_FldComparisonOp == "") return arrCacheMode_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objCacheMode_Cond.sf_FldComparisonOp);
//console.log("clsCacheModeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objCacheMode_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objCacheMode_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrCacheMode_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objCacheMode_Cond), cacheMode_ConstructorName, strThisFuncName);
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
export async function CacheMode_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(cacheMode_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cacheMode_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cacheMode_ConstructorName, strThisFuncName);
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
 * @param strCacheModeId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function CacheMode_IsExist(strCacheModeId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(cacheMode_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"CacheModeId": strCacheModeId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cacheMode_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cacheMode_ConstructorName, strThisFuncName);
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
 * @param strCacheModeId:所给的关键字
 * @returns 对象
*/
export async function CacheMode_IsExist_Cache(strCacheModeId:string) {
const strThisFuncName = "IsExist_Cache";
const arrCacheModeObjLst_Cache = await CacheMode_GetObjLst_Cache();
if (arrCacheModeObjLst_Cache == null) return false;
try
{
const arrCacheMode_Sel: Array <clsCacheModeEN> = arrCacheModeObjLst_Cache.filter(x => x.cacheModeId == strCacheModeId);
if (arrCacheMode_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strCacheModeId, cacheMode_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param strCacheModeId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function CacheMode_IsExistAsync(strCacheModeId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(cacheMode_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strCacheModeId": strCacheModeId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cacheMode_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cacheMode_ConstructorName, strThisFuncName);
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
export async function CacheMode_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(cacheMode_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cacheMode_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cacheMode_ConstructorName, strThisFuncName);
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
 * @param objCacheMode_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function CacheMode_GetRecCountByCond_Cache(objCacheMode_Cond: clsCacheModeEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrCacheModeObjLst_Cache = await CacheMode_GetObjLst_Cache();
if (arrCacheModeObjLst_Cache == null) return 0;
let arrCacheMode_Sel: Array < clsCacheModeEN > = arrCacheModeObjLst_Cache;
if (objCacheMode_Cond.sf_FldComparisonOp == null || objCacheMode_Cond.sf_FldComparisonOp == "") return arrCacheMode_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objCacheMode_Cond.sf_FldComparisonOp);
//console.log("clsCacheModeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objCacheMode_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objCacheMode_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrCacheMode_Sel = arrCacheMode_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrCacheMode_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objCacheMode_Cond), cacheMode_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return 0;
}

 /**
 * 获取表的最大关键字
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdAsync)
 * @returns 获取表的最大关键字
 **/
export async function CacheMode_GetMaxStrIdAsync(): Promise<string>  
{
const strThisFuncName = "GetMaxStrIdAsync";
const strAction = "GetMaxStrId";
const strUrl = GetWebApiUrl(cacheMode_Controller, strAction);
try
{
const response = await axios.get(strUrl);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cacheMode_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cacheMode_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}
/*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/

/**
 * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
 * @param mapParam:参数列表
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 获取当前表关键字值的最大值
*/
export async function CacheMode_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(cacheMode_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cacheMode_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cacheMode_ConstructorName, strThisFuncName);
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
export function CacheMode_GetWebApiUrl(strController: string, strAction: string): string {
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
export function CacheMode_ReFreshCache():void
{
const strThisFuncName = "ReFreshCache";

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = clsCacheModeEN._CurrTabName;
switch (clsCacheModeEN.CacheModeId)
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
export function CacheMode_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clsCacheModeEN._CurrTabName;
switch (clsCacheModeEN.CacheModeId)
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
export async function CacheMode_BindDdl_CacheModeIdInDiv_Cache(strDivName: string, strDdlName: string )
{
const strThisFuncName = "BindDdl_CacheModeIdInDiv_Cache";

const objDdl = document.getElementById(strDdlName);
if (objDdl == null)
{
const strMsg = Format("下拉框：{0} 不存在！(In BindDdl_CacheModeIdInDiv)", strDdlName);
alert(strMsg);
console.error(strMsg);
throw (strMsg);
}
//为数据源于表的下拉框设置内容
//console.log("开始：BindDdl_CacheModeIdInDiv_Cache");
const arrObjLst_Sel = await CacheMode_GetObjLst_Cache();
if (arrObjLst_Sel == null) return;
BindDdl_ObjLstInDiv(strDivName, strDdlName, arrObjLst_Sel, clsCacheModeEN.con_CacheModeId, clsCacheModeEN.con_CacheModeName, "缓存方式");
}

/**
 * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function CacheMode_CheckPropertyNew(pobjCacheModeEN: clsCacheModeEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjCacheModeEN.cacheModeName) === true )
{
 throw new Error("(errid:Watl000058)字段[缓存方式名]不能为空(In 缓存方式)!(clsCacheModeBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjCacheModeEN.cacheModeId) == false && GetStrLen(pobjCacheModeEN.cacheModeId) > 2)
{
 throw new Error("(errid:Watl000059)字段[缓存方式Id(cacheModeId)]的长度不能超过2(In 缓存方式(CacheMode))!值:$(pobjCacheModeEN.cacheModeId)(clsCacheModeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCacheModeEN.cacheModeName) == false && GetStrLen(pobjCacheModeEN.cacheModeName) > 50)
{
 throw new Error("(errid:Watl000059)字段[缓存方式名(cacheModeName)]的长度不能超过50(In 缓存方式(CacheMode))!值:$(pobjCacheModeEN.cacheModeName)(clsCacheModeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCacheModeEN.cacheModeENName) == false && GetStrLen(pobjCacheModeEN.cacheModeENName) > 50)
{
 throw new Error("(errid:Watl000059)字段[缓存方式英文名(cacheModeENName)]的长度不能超过50(In 缓存方式(CacheMode))!值:$(pobjCacheModeEN.cacheModeENName)(clsCacheModeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCacheModeEN.memo) == false && GetStrLen(pobjCacheModeEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 缓存方式(CacheMode))!值:$(pobjCacheModeEN.memo)(clsCacheModeBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjCacheModeEN.cacheModeId) == false && undefined !== pobjCacheModeEN.cacheModeId && tzDataType.isString(pobjCacheModeEN.cacheModeId) === false)
{
 throw new Error("(errid:Watl000060)字段[缓存方式Id(cacheModeId)]的值:[$(pobjCacheModeEN.cacheModeId)], 非法，应该为字符型(In 缓存方式(CacheMode))!(clsCacheModeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCacheModeEN.cacheModeName) == false && undefined !== pobjCacheModeEN.cacheModeName && tzDataType.isString(pobjCacheModeEN.cacheModeName) === false)
{
 throw new Error("(errid:Watl000060)字段[缓存方式名(cacheModeName)]的值:[$(pobjCacheModeEN.cacheModeName)], 非法，应该为字符型(In 缓存方式(CacheMode))!(clsCacheModeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCacheModeEN.cacheModeENName) == false && undefined !== pobjCacheModeEN.cacheModeENName && tzDataType.isString(pobjCacheModeEN.cacheModeENName) === false)
{
 throw new Error("(errid:Watl000060)字段[缓存方式英文名(cacheModeENName)]的值:[$(pobjCacheModeEN.cacheModeENName)], 非法，应该为字符型(In 缓存方式(CacheMode))!(clsCacheModeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCacheModeEN.memo) == false && undefined !== pobjCacheModeEN.memo && tzDataType.isString(pobjCacheModeEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjCacheModeEN.memo)], 非法，应该为字符型(In 缓存方式(CacheMode))!(clsCacheModeBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjCacheModeEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function CacheMode_CheckProperty4Update (pobjCacheModeEN: clsCacheModeEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjCacheModeEN.cacheModeId) == false && GetStrLen(pobjCacheModeEN.cacheModeId) > 2)
{
 throw new Error("(errid:Watl000062)字段[缓存方式Id(cacheModeId)]的长度不能超过2(In 缓存方式(CacheMode))!值:$(pobjCacheModeEN.cacheModeId)(clsCacheModeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCacheModeEN.cacheModeName) == false && GetStrLen(pobjCacheModeEN.cacheModeName) > 50)
{
 throw new Error("(errid:Watl000062)字段[缓存方式名(cacheModeName)]的长度不能超过50(In 缓存方式(CacheMode))!值:$(pobjCacheModeEN.cacheModeName)(clsCacheModeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCacheModeEN.cacheModeENName) == false && GetStrLen(pobjCacheModeEN.cacheModeENName) > 50)
{
 throw new Error("(errid:Watl000062)字段[缓存方式英文名(cacheModeENName)]的长度不能超过50(In 缓存方式(CacheMode))!值:$(pobjCacheModeEN.cacheModeENName)(clsCacheModeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCacheModeEN.memo) == false && GetStrLen(pobjCacheModeEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 缓存方式(CacheMode))!值:$(pobjCacheModeEN.memo)(clsCacheModeBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjCacheModeEN.cacheModeId) == false && undefined !== pobjCacheModeEN.cacheModeId && tzDataType.isString(pobjCacheModeEN.cacheModeId) === false)
{
 throw new Error("(errid:Watl000063)字段[缓存方式Id(cacheModeId)]的值:[$(pobjCacheModeEN.cacheModeId)], 非法，应该为字符型(In 缓存方式(CacheMode))!(clsCacheModeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCacheModeEN.cacheModeName) == false && undefined !== pobjCacheModeEN.cacheModeName && tzDataType.isString(pobjCacheModeEN.cacheModeName) === false)
{
 throw new Error("(errid:Watl000063)字段[缓存方式名(cacheModeName)]的值:[$(pobjCacheModeEN.cacheModeName)], 非法，应该为字符型(In 缓存方式(CacheMode))!(clsCacheModeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCacheModeEN.cacheModeENName) == false && undefined !== pobjCacheModeEN.cacheModeENName && tzDataType.isString(pobjCacheModeEN.cacheModeENName) === false)
{
 throw new Error("(errid:Watl000063)字段[缓存方式英文名(cacheModeENName)]的值:[$(pobjCacheModeEN.cacheModeENName)], 非法，应该为字符型(In 缓存方式(CacheMode))!(clsCacheModeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCacheModeEN.memo) == false && undefined !== pobjCacheModeEN.memo && tzDataType.isString(pobjCacheModeEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjCacheModeEN.memo)], 非法，应该为字符型(In 缓存方式(CacheMode))!(clsCacheModeBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (IsNullOrEmpty(pobjCacheModeEN.cacheModeId) === true )
{
 throw new Error("(errid:Watl000064)字段[缓存方式Id]不能为空(In 缓存方式)!(clsCacheModeBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjCacheModeEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function CacheMode_GetJSONStrByObj (pobjCacheModeEN: clsCacheModeEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjCacheModeEN.sf_UpdFldSetStr = pobjCacheModeEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjCacheModeEN);
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
export function CacheMode_GetObjLstByJSONStr (strJSON: string): Array<clsCacheModeEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrCacheModeObjLst = new Array<clsCacheModeEN>();
if (strJSON === "")
{
return arrCacheModeObjLst;
}
try
{
arrCacheModeObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrCacheModeObjLst;
}
return arrCacheModeObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrCacheModeObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function CacheMode_GetObjLstByJSONObjLst (arrCacheModeObjLstS: Array<clsCacheModeEN>): Array<clsCacheModeEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrCacheModeObjLst = new Array<clsCacheModeEN>();
for (const objInFor of arrCacheModeObjLstS) {
const obj1 = CacheMode_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrCacheModeObjLst.push(obj1);
}
return arrCacheModeObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function CacheMode_GetObjByJSONStr (strJSON: string): clsCacheModeEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjCacheModeEN = new clsCacheModeEN();
if (strJSON === "")
{
return pobjCacheModeEN;
}
try
{
pobjCacheModeEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjCacheModeEN;
}
return pobjCacheModeEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function CacheMode_GetCombineCondition(objCacheMode_Cond: clsCacheModeEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objCacheMode_Cond.dicFldComparisonOp, clsCacheModeEN.con_CacheModeId) == true)
{
const strComparisonOp_CacheModeId:string = objCacheMode_Cond.dicFldComparisonOp[clsCacheModeEN.con_CacheModeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsCacheModeEN.con_CacheModeId, objCacheMode_Cond.cacheModeId, strComparisonOp_CacheModeId);
}
if (Object.prototype.hasOwnProperty.call(objCacheMode_Cond.dicFldComparisonOp, clsCacheModeEN.con_CacheModeName) == true)
{
const strComparisonOp_CacheModeName:string = objCacheMode_Cond.dicFldComparisonOp[clsCacheModeEN.con_CacheModeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsCacheModeEN.con_CacheModeName, objCacheMode_Cond.cacheModeName, strComparisonOp_CacheModeName);
}
if (Object.prototype.hasOwnProperty.call(objCacheMode_Cond.dicFldComparisonOp, clsCacheModeEN.con_CacheModeENName) == true)
{
const strComparisonOp_CacheModeENName:string = objCacheMode_Cond.dicFldComparisonOp[clsCacheModeEN.con_CacheModeENName];
strWhereCond += Format(" And {0} {2} '{1}'", clsCacheModeEN.con_CacheModeENName, objCacheMode_Cond.cacheModeENName, strComparisonOp_CacheModeENName);
}
if (Object.prototype.hasOwnProperty.call(objCacheMode_Cond.dicFldComparisonOp, clsCacheModeEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objCacheMode_Cond.dicFldComparisonOp[clsCacheModeEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsCacheModeEN.con_Memo, objCacheMode_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--CacheMode(缓存方式),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param strCacheModeId: 缓存方式Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function CacheMode_GetUniCondStr_CacheModeId(objCacheModeEN: clsCacheModeEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and CacheModeId = '{0}'", objCacheModeEN.cacheModeId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--CacheMode(缓存方式),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param strCacheModeId: 缓存方式Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function CacheMode_GetUniCondStr4Update_CacheModeId(objCacheModeEN: clsCacheModeEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and CacheModeId <> '{0}'", objCacheModeEN.cacheModeId);
 strWhereCond +=  Format(" and CacheModeId = '{0}'", objCacheModeEN.cacheModeId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objCacheModeENS:源对象
 * @param objCacheModeENT:目标对象
*/
export function CacheMode_CopyObjTo(objCacheModeENS: clsCacheModeEN , objCacheModeENT: clsCacheModeEN ): void 
{
objCacheModeENT.cacheModeId = objCacheModeENS.cacheModeId; //缓存方式Id
objCacheModeENT.cacheModeName = objCacheModeENS.cacheModeName; //缓存方式名
objCacheModeENT.cacheModeENName = objCacheModeENS.cacheModeENName; //缓存方式英文名
objCacheModeENT.memo = objCacheModeENS.memo; //备注
objCacheModeENT.sf_UpdFldSetStr = objCacheModeENS.updFldString; //sf_UpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objCacheModeENS:源对象
 * @param objCacheModeENT:目标对象
*/
export function CacheMode_GetObjFromJsonObj(objCacheModeENS: clsCacheModeEN): clsCacheModeEN 
{
 const objCacheModeENT: clsCacheModeEN = new clsCacheModeEN();
ObjectAssign(objCacheModeENT, objCacheModeENS);
 return objCacheModeENT;
}