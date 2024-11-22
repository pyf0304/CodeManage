
 /**
 * 类名:clsPageDispModeWApi
 * 表名:PageDispMode(01120908)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:47:17
 * 生成者:pyf
 * 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:菜单管理(PrjMenu)
 * 框架-层名:WA_访问层(TS)(WA_Access)
 * 编程语言:TypeScript
 * 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
   *      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 **/

/**
 * 页面显示模式(PageDispMode)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clsPageDispModeEN } from "../../L0_Entity/PrjMenu/clsPageDispModeEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { tzDataType } from "../../PubFun/jsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const pageDispMode_Controller = "PageDispModeApi";
 export const pageDispMode_ConstructorName = "pageDispMode";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strPageDispModeId:关键字
 * @returns 对象
 **/
export async function PageDispMode_GetObjByPageDispModeIdAsync(strPageDispModeId: string): Promise<clsPageDispModeEN>  
{
const strThisFuncName = "GetObjByPageDispModeIdAsync";

if (IsNullOrEmpty(strPageDispModeId) == true)
{
  const strMsg = Format("参数:[strPageDispModeId]不能为空！(In GetObjByPageDispModeIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strPageDispModeId.length != 2)
{
const strMsg = Format("缓存分类变量:[strPageDispModeId]的长度:[{0}]不正确！", strPageDispModeId.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByPageDispModeId";
const strUrl = GetWebApiUrl(pageDispMode_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strPageDispModeId": strPageDispModeId,
}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObj = data.returnObj;
if (returnObj == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", pageDispMode_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objPageDispMode = PageDispMode_GetObjFromJsonObj(returnObj);
return objPageDispMode;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, pageDispMode_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, pageDispMode_ConstructorName, strThisFuncName);
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
 * @param strPageDispModeId:所给的关键字
 * @returns 对象
*/
export async function PageDispMode_GetObjByPageDispModeId_Cache(strPageDispModeId: string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByPageDispModeId_Cache";

if (IsNullOrEmpty(strPageDispModeId) == true)
{
  const strMsg = Format("参数:[strPageDispModeId]不能为空！(In GetObjByPageDispModeId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strPageDispModeId.length != 2)
{
const strMsg = Format("缓存分类变量:[strPageDispModeId]的长度:[{0}]不正确！", strPageDispModeId.length);
console.error(strMsg);
throw (strMsg);
}
const arrPageDispModeObjLst_Cache = await PageDispMode_GetObjLst_Cache();
try
{
const arrPageDispMode_Sel: Array <clsPageDispModeEN> = arrPageDispModeObjLst_Cache.filter(x => x.pageDispModeId == strPageDispModeId);
let objPageDispMode: clsPageDispModeEN;
if (arrPageDispMode_Sel.length > 0)
{
objPageDispMode = arrPageDispMode_Sel[0];
return objPageDispMode;
}
else
{
if (bolTryAsyncOnce == true)
{
objPageDispMode = await PageDispMode_GetObjByPageDispModeIdAsync(strPageDispModeId);
if (objPageDispMode != null)
{
PageDispMode_ReFreshThisCache();
return objPageDispMode;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strPageDispModeId, pageDispMode_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param strPageDispModeId:所给的关键字
 * @returns 对象
*/
export async function PageDispMode_GetObjByPageDispModeId_localStorage(strPageDispModeId: string) {
const strThisFuncName = "GetObjByPageDispModeId_localStorage";

if (IsNullOrEmpty(strPageDispModeId) == true)
{
  const strMsg = Format("参数:[strPageDispModeId]不能为空！(In GetObjByPageDispModeId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
if (strPageDispModeId.length != 2)
{
const strMsg = Format("缓存分类变量:[strPageDispModeId]的长度:[{0}]不正确！", strPageDispModeId.length);
console.error(strMsg);
throw (strMsg);
}
const strKey = Format("{0}_{1}", clsPageDispModeEN._CurrTabName, strPageDispModeId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objPageDispMode_Cache: clsPageDispModeEN = JSON.parse(strTempObj);
return objPageDispMode_Cache;
}
try
{
const objPageDispMode = await PageDispMode_GetObjByPageDispModeIdAsync(strPageDispModeId);
if (objPageDispMode != null)
{
localStorage.setItem(strKey, JSON.stringify(objPageDispMode));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objPageDispMode;
}
return objPageDispMode;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strPageDispModeId, pageDispMode_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objPageDispMode:所给的对象
 * @returns 对象
*/
export async function PageDispMode_UpdateObjInLst_Cache(objPageDispMode: clsPageDispModeEN) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrPageDispModeObjLst_Cache = await PageDispMode_GetObjLst_Cache();
const obj = arrPageDispModeObjLst_Cache.find(x => x.pageDispModeName == objPageDispMode.pageDispModeName);
if (obj != null)
{
objPageDispMode.pageDispModeId = obj.pageDispModeId;
ObjectAssign( obj, objPageDispMode);
}
else
{
arrPageDispModeObjLst_Cache.push(objPageDispMode);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, pageDispMode_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
}

/**
 * 根据关键字获取相关对象的名称属性, 从缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
 * @param strPageDispModeId:所给的关键字
 * @returns 对象
*/
export async function PageDispMode_GetNameByPageDispModeId_Cache(strPageDispModeId: string) {
const strThisFuncName = "GetNameByPageDispModeId_Cache";

if (IsNullOrEmpty(strPageDispModeId) == true)
{
  const strMsg = Format("参数:[strPageDispModeId]不能为空！(In GetNameByPageDispModeId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strPageDispModeId.length != 2)
{
const strMsg = Format("缓存分类变量:[strPageDispModeId]的长度:[{0}]不正确！", strPageDispModeId.length);
console.error(strMsg);
throw (strMsg);
}
const arrPageDispModeObjLst_Cache = await PageDispMode_GetObjLst_Cache();
if (arrPageDispModeObjLst_Cache == null) return "";
try
{
const arrPageDispMode_Sel: Array <clsPageDispModeEN> = arrPageDispModeObjLst_Cache.filter(x => x.pageDispModeId == strPageDispModeId);
let objPageDispMode: clsPageDispModeEN;
if (arrPageDispMode_Sel.length > 0)
{
objPageDispMode = arrPageDispMode_Sel[0];
return objPageDispMode.pageDispModeName;
}
else
{
return "";
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strPageDispModeId);
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
export async function PageDispMode_func(strInFldName:string , strOutFldName:string ,  strInValue: string) 
{
//const strThisFuncName = "func";

if (strInFldName != clsPageDispModeEN.con_PageDispModeId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsPageDispModeEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clsPageDispModeEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strPageDispModeId = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objPageDispMode = await PageDispMode_GetObjByPageDispModeId_Cache(strPageDispModeId );
if (objPageDispMode == null) return "";
return objPageDispMode.GetFldValue(strOutFldName).toString();
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
export function PageDispMode_SortFun_Defa(a:clsPageDispModeEN , b:clsPageDispModeEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.pageDispModeId.localeCompare(b.pageDispModeId);
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
export function PageDispMode_SortFun_Defa_2Fld(a:clsPageDispModeEN , b:clsPageDispModeEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.pageDispModeName == b.pageDispModeName) return a.pageDispModeENName.localeCompare(b.pageDispModeENName);
else return a.pageDispModeName.localeCompare(b.pageDispModeName);
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
export function PageDispMode_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsPageDispModeEN.con_PageDispModeId:
return (a: clsPageDispModeEN, b: clsPageDispModeEN) => {
return a.pageDispModeId.localeCompare(b.pageDispModeId);
}
case clsPageDispModeEN.con_PageDispModeName:
return (a: clsPageDispModeEN, b: clsPageDispModeEN) => {
return a.pageDispModeName.localeCompare(b.pageDispModeName);
}
case clsPageDispModeEN.con_PageDispModeENName:
return (a: clsPageDispModeEN, b: clsPageDispModeEN) => {
return a.pageDispModeENName.localeCompare(b.pageDispModeENName);
}
case clsPageDispModeEN.con_Memo:
return (a: clsPageDispModeEN, b: clsPageDispModeEN) => {
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[PageDispMode]中不存在！(in ${ pageDispMode_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsPageDispModeEN.con_PageDispModeId:
return (a: clsPageDispModeEN, b: clsPageDispModeEN) => {
return b.pageDispModeId.localeCompare(a.pageDispModeId);
}
case clsPageDispModeEN.con_PageDispModeName:
return (a: clsPageDispModeEN, b: clsPageDispModeEN) => {
return b.pageDispModeName.localeCompare(a.pageDispModeName);
}
case clsPageDispModeEN.con_PageDispModeENName:
return (a: clsPageDispModeEN, b: clsPageDispModeEN) => {
return b.pageDispModeENName.localeCompare(a.pageDispModeENName);
}
case clsPageDispModeEN.con_Memo:
return (a: clsPageDispModeEN, b: clsPageDispModeEN) => {
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[PageDispMode]中不存在！(in ${ pageDispMode_ConstructorName}.${ strThisFuncName})`;
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
export async function PageDispMode_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsPageDispModeEN.con_PageDispModeId:
return (obj: clsPageDispModeEN) => {
return obj.pageDispModeId === value;
}
case clsPageDispModeEN.con_PageDispModeName:
return (obj: clsPageDispModeEN) => {
return obj.pageDispModeName === value;
}
case clsPageDispModeEN.con_PageDispModeENName:
return (obj: clsPageDispModeEN) => {
return obj.pageDispModeENName === value;
}
case clsPageDispModeEN.con_Memo:
return (obj: clsPageDispModeEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[PageDispMode]中不存在！(in ${ pageDispMode_ConstructorName}.${ strThisFuncName})`;
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
export async function PageDispMode_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(pageDispMode_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, pageDispMode_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, pageDispMode_ConstructorName, strThisFuncName);
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
export async function PageDispMode_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(pageDispMode_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, pageDispMode_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, pageDispMode_ConstructorName, strThisFuncName);
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
export async function PageDispMode_GetFirstObjAsync(strWhereCond: string): Promise<clsPageDispModeEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(pageDispMode_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", pageDispMode_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objPageDispMode = PageDispMode_GetObjFromJsonObj(returnObj);
return objPageDispMode;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, pageDispMode_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, pageDispMode_ConstructorName, strThisFuncName);
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
export async function PageDispMode_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsPageDispModeEN._CurrTabName;
clsPageDispModeEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsPageDispModeEN._CurrTabName);
if (IsNullOrEmpty(clsPageDispModeEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsPageDispModeEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrPageDispModeExObjLst_Cache: Array<clsPageDispModeEN> = CacheHelper.Get(strKey);
const arrPageDispModeObjLst_T = PageDispMode_GetObjLstByJSONObjLst(arrPageDispModeExObjLst_Cache);
return arrPageDispModeObjLst_T;
}
try
{
const arrPageDispModeExObjLst = await PageDispMode_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrPageDispModeExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrPageDispModeExObjLst.length);
console.log(strInfo);
return arrPageDispModeExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, pageDispMode_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function PageDispMode_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsPageDispModeEN._CurrTabName;
clsPageDispModeEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsPageDispModeEN._CurrTabName);
if (IsNullOrEmpty(clsPageDispModeEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsPageDispModeEN.CacheAddiCondition);
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
const arrPageDispModeExObjLst_Cache: Array<clsPageDispModeEN> = JSON.parse(strTempObjLst);
const arrPageDispModeObjLst_T = PageDispMode_GetObjLstByJSONObjLst(arrPageDispModeExObjLst_Cache);
return arrPageDispModeObjLst_T;
}
try
{
const arrPageDispModeExObjLst = await PageDispMode_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrPageDispModeExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrPageDispModeExObjLst.length);
console.log(strInfo);
return arrPageDispModeExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, pageDispMode_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function PageDispMode_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsPageDispModeEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrPageDispModeObjLst_Cache: Array<clsPageDispModeEN> = JSON.parse(strTempObjLst);
return arrPageDispModeObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function PageDispMode_GetObjLstAsync(strWhereCond: string): Promise<Array<clsPageDispModeEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(pageDispMode_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", pageDispMode_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = PageDispMode_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, pageDispMode_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, pageDispMode_ConstructorName, strThisFuncName);
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
export async function PageDispMode_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsPageDispModeEN._CurrTabName;
clsPageDispModeEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsPageDispModeEN._CurrTabName);
if (IsNullOrEmpty(clsPageDispModeEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsPageDispModeEN.CacheAddiCondition);
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
const arrPageDispModeExObjLst_Cache: Array<clsPageDispModeEN> = JSON.parse(strTempObjLst);
const arrPageDispModeObjLst_T = PageDispMode_GetObjLstByJSONObjLst(arrPageDispModeExObjLst_Cache);
return arrPageDispModeObjLst_T;
}
try
{
const arrPageDispModeExObjLst = await PageDispMode_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrPageDispModeExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrPageDispModeExObjLst.length);
console.log(strInfo);
return arrPageDispModeExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, pageDispMode_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function PageDispMode_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsPageDispModeEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrPageDispModeObjLst_Cache: Array<clsPageDispModeEN> = JSON.parse(strTempObjLst);
return arrPageDispModeObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function PageDispMode_GetObjLst_Cache(): Promise<Array<clsPageDispModeEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrPageDispModeObjLst_Cache;
switch (clsPageDispModeEN.CacheModeId)
{
case "04"://sessionStorage
arrPageDispModeObjLst_Cache = await PageDispMode_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrPageDispModeObjLst_Cache = await PageDispMode_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrPageDispModeObjLst_Cache = await PageDispMode_GetObjLst_ClientCache();
break;
default:
arrPageDispModeObjLst_Cache = await PageDispMode_GetObjLst_ClientCache();
break;
}
const arrPageDispModeObjLst = PageDispMode_GetObjLstByJSONObjLst(arrPageDispModeObjLst_Cache);
return arrPageDispModeObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function PageDispMode_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrPageDispModeObjLst_Cache;
switch (clsPageDispModeEN.CacheModeId)
{
case "04"://sessionStorage
arrPageDispModeObjLst_Cache = await PageDispMode_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrPageDispModeObjLst_Cache = await PageDispMode_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrPageDispModeObjLst_Cache = null;
break;
default:
arrPageDispModeObjLst_Cache = null;
break;
}
return arrPageDispModeObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrPageDispModeId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function PageDispMode_GetSubObjLst_Cache(objPageDispMode_Cond: clsPageDispModeEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrPageDispModeObjLst_Cache = await PageDispMode_GetObjLst_Cache();
let arrPageDispMode_Sel: Array < clsPageDispModeEN > = arrPageDispModeObjLst_Cache;
if (objPageDispMode_Cond.sf_FldComparisonOp == null || objPageDispMode_Cond.sf_FldComparisonOp == "") return arrPageDispMode_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objPageDispMode_Cond.sf_FldComparisonOp);
//console.log("clsPageDispModeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objPageDispMode_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objPageDispMode_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrPageDispMode_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objPageDispMode_Cond), pageDispMode_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsPageDispModeEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrPageDispModeId:关键字列表
 * @returns 对象列表
 **/
export async function PageDispMode_GetObjLstByPageDispModeIdLstAsync(arrPageDispModeId: Array<string>): Promise<Array<clsPageDispModeEN>>  
{
const strThisFuncName = "GetObjLstByPageDispModeIdLstAsync";
const strAction = "GetObjLstByPageDispModeIdLst";
const strUrl = GetWebApiUrl(pageDispMode_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrPageDispModeId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", pageDispMode_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = PageDispMode_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, pageDispMode_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, pageDispMode_ConstructorName, strThisFuncName);
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
 * @param arrstrPageDispModeIdLst:关键字列表
 * @returns 对象列表
*/
export async function PageDispMode_GetObjLstByPageDispModeIdLst_Cache(arrPageDispModeIdLst: Array<string>) {
const strThisFuncName = "GetObjLstByPageDispModeIdLst_Cache";
try
{
const arrPageDispModeObjLst_Cache = await PageDispMode_GetObjLst_Cache();
const arrPageDispMode_Sel: Array <clsPageDispModeEN> = arrPageDispModeObjLst_Cache.filter(x => arrPageDispModeIdLst.indexOf(x.pageDispModeId)>-1);
return arrPageDispMode_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrPageDispModeIdLst.join(","), pageDispMode_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsPageDispModeEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function PageDispMode_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsPageDispModeEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(pageDispMode_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", pageDispMode_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = PageDispMode_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, pageDispMode_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, pageDispMode_ConstructorName, strThisFuncName);
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
export async function PageDispMode_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsPageDispModeEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(pageDispMode_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", pageDispMode_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = PageDispMode_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, pageDispMode_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, pageDispMode_ConstructorName, strThisFuncName);
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
export async function PageDispMode_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(pageDispMode_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, pageDispMode_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, pageDispMode_ConstructorName, strThisFuncName);
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
export async function PageDispMode_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrPageDispModeObjLst_Cache = await PageDispMode_GetObjLst_Cache();
if (arrPageDispModeObjLst_Cache.length == 0) return arrPageDispModeObjLst_Cache;
let arrPageDispMode_Sel = arrPageDispModeObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objPageDispMode_Cond = new clsPageDispModeEN();
ObjectAssign(objPageDispMode_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsPageDispModeWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objPageDispMode_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrPageDispMode_Sel.length == 0) return arrPageDispMode_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrPageDispMode_Sel = arrPageDispMode_Sel.sort(PageDispMode_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrPageDispMode_Sel = arrPageDispMode_Sel.sort(objPagerPara.sortFun);
}
arrPageDispMode_Sel = arrPageDispMode_Sel.slice(intStart, intEnd);     
return arrPageDispMode_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, pageDispMode_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsPageDispModeEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function PageDispMode_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsPageDispModeEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(pageDispMode_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", pageDispMode_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = PageDispMode_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, pageDispMode_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, pageDispMode_ConstructorName, strThisFuncName);
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
 * @param strPageDispModeId:关键字
 * @returns 获取删除的结果
 **/
export async function PageDispMode_DelRecordAsync(strPageDispModeId: string): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(pageDispMode_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, strPageDispModeId);
try
{
const response = await axios.delete(strUrl,
{
params: { "Id": strPageDispModeId, }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, pageDispMode_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, pageDispMode_ConstructorName, strThisFuncName);
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
 * @param arrPageDispModeId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function PageDispMode_DelPageDispModesAsync(arrPageDispModeId: Array<string>): Promise<number> 
{
const strThisFuncName = "DelPageDispModesAsync";
const strAction = "DelPageDispModes";
const strUrl = GetWebApiUrl(pageDispMode_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrPageDispModeId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, pageDispMode_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, pageDispMode_ConstructorName, strThisFuncName);
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
export async function PageDispMode_DelPageDispModesByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "DelPageDispModesByCondAsync";
const strAction = "DelPageDispModesByCond";
const strUrl = GetWebApiUrl(pageDispMode_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, pageDispMode_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, pageDispMode_ConstructorName, strThisFuncName);
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
 * @param objPageDispModeEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function PageDispMode_AddNewRecordAsync(objPageDispModeEN: clsPageDispModeEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objPageDispModeEN);
const strUrl = GetWebApiUrl(pageDispMode_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPageDispModeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, pageDispMode_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, pageDispMode_ConstructorName, strThisFuncName);
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
 * @param objPageDispModeEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function PageDispMode_AddNewRecordWithMaxIdAsync(objPageDispModeEN: clsPageDispModeEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithMaxIdAsync";
const strAction = "AddNewRecordWithMaxId";
const strUrl = GetWebApiUrl(pageDispMode_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPageDispModeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, pageDispMode_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, pageDispMode_ConstructorName, strThisFuncName);
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
 * @param objPageDispModeEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function PageDispMode_AddNewRecordWithReturnKeyAsync(objPageDispModeEN: clsPageDispModeEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(pageDispMode_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPageDispModeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, pageDispMode_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, pageDispMode_ConstructorName, strThisFuncName);
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
 * @param objPageDispModeEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function PageDispMode_AddNewRecordWithReturnKey(objPageDispModeEN: clsPageDispModeEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objPageDispModeEN.pageDispModeId === null || objPageDispModeEN.pageDispModeId === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(pageDispMode_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPageDispModeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, pageDispMode_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, pageDispMode_ConstructorName, strThisFuncName);
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
 * @param objPageDispModeEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function PageDispMode_UpdateRecordAsync(objPageDispModeEN: clsPageDispModeEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objPageDispModeEN.sf_UpdFldSetStr === undefined || objPageDispModeEN.sf_UpdFldSetStr === null || objPageDispModeEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objPageDispModeEN.pageDispModeId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(pageDispMode_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPageDispModeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, pageDispMode_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, pageDispMode_ConstructorName, strThisFuncName);
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
 * @param objPageDispModeEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function PageDispMode_UpdateWithConditionAsync(objPageDispModeEN: clsPageDispModeEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objPageDispModeEN.sf_UpdFldSetStr === undefined || objPageDispModeEN.sf_UpdFldSetStr === null || objPageDispModeEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objPageDispModeEN.pageDispModeId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(pageDispMode_Controller, strAction);
objPageDispModeEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objPageDispModeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, pageDispMode_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, pageDispMode_ConstructorName, strThisFuncName);
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
 * @param objstrPageDispModeId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function PageDispMode_IsExistRecord_Cache(objPageDispMode_Cond: clsPageDispModeEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrPageDispModeObjLst_Cache = await PageDispMode_GetObjLst_Cache();
if (arrPageDispModeObjLst_Cache == null) return false;
let arrPageDispMode_Sel: Array < clsPageDispModeEN > = arrPageDispModeObjLst_Cache;
if (objPageDispMode_Cond.sf_FldComparisonOp == null || objPageDispMode_Cond.sf_FldComparisonOp == "") return arrPageDispMode_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objPageDispMode_Cond.sf_FldComparisonOp);
//console.log("clsPageDispModeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objPageDispMode_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objPageDispMode_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrPageDispMode_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objPageDispMode_Cond), pageDispMode_ConstructorName, strThisFuncName);
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
export async function PageDispMode_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(pageDispMode_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, pageDispMode_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, pageDispMode_ConstructorName, strThisFuncName);
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
 * @param strPageDispModeId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function PageDispMode_IsExist(strPageDispModeId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(pageDispMode_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"PageDispModeId": strPageDispModeId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, pageDispMode_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, pageDispMode_ConstructorName, strThisFuncName);
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
 * @param strPageDispModeId:所给的关键字
 * @returns 对象
*/
export async function PageDispMode_IsExist_Cache(strPageDispModeId:string) {
const strThisFuncName = "IsExist_Cache";
const arrPageDispModeObjLst_Cache = await PageDispMode_GetObjLst_Cache();
if (arrPageDispModeObjLst_Cache == null) return false;
try
{
const arrPageDispMode_Sel: Array <clsPageDispModeEN> = arrPageDispModeObjLst_Cache.filter(x => x.pageDispModeId == strPageDispModeId);
if (arrPageDispMode_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strPageDispModeId, pageDispMode_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param strPageDispModeId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function PageDispMode_IsExistAsync(strPageDispModeId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(pageDispMode_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strPageDispModeId": strPageDispModeId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, pageDispMode_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, pageDispMode_ConstructorName, strThisFuncName);
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
export async function PageDispMode_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(pageDispMode_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, pageDispMode_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, pageDispMode_ConstructorName, strThisFuncName);
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
 * @param objPageDispMode_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function PageDispMode_GetRecCountByCond_Cache(objPageDispMode_Cond: clsPageDispModeEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrPageDispModeObjLst_Cache = await PageDispMode_GetObjLst_Cache();
if (arrPageDispModeObjLst_Cache == null) return 0;
let arrPageDispMode_Sel: Array < clsPageDispModeEN > = arrPageDispModeObjLst_Cache;
if (objPageDispMode_Cond.sf_FldComparisonOp == null || objPageDispMode_Cond.sf_FldComparisonOp == "") return arrPageDispMode_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objPageDispMode_Cond.sf_FldComparisonOp);
//console.log("clsPageDispModeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objPageDispMode_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objPageDispMode_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrPageDispMode_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objPageDispMode_Cond), pageDispMode_ConstructorName, strThisFuncName);
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
export async function PageDispMode_GetMaxStrIdAsync(): Promise<string>  
{
const strThisFuncName = "GetMaxStrIdAsync";
const strAction = "GetMaxStrId";
const strUrl = GetWebApiUrl(pageDispMode_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, pageDispMode_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, pageDispMode_ConstructorName, strThisFuncName);
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
export async function PageDispMode_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(pageDispMode_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, pageDispMode_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, pageDispMode_ConstructorName, strThisFuncName);
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
export function PageDispMode_GetWebApiUrl(strController: string, strAction: string): string {
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
export function PageDispMode_ReFreshCache():void
{
const strThisFuncName = "ReFreshCache";

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = clsPageDispModeEN._CurrTabName;
switch (clsPageDispModeEN.CacheModeId)
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
export function PageDispMode_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clsPageDispModeEN._CurrTabName;
switch (clsPageDispModeEN.CacheModeId)
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
export async function PageDispMode__Cache(strDivName: string, strDdlName: string )
{
const strThisFuncName = "_Cache";

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
const arrObjLst_Sel = await PageDispMode_GetObjLst_Cache();
if (arrObjLst_Sel == null) return;
BindDdl_ObjLstInDiv(strDivName, strDdlName, arrObjLst_Sel, clsPageDispModeEN.con_PageDispModeId, clsPageDispModeEN.con_PageDispModeName, "页面显示模式");
}

/**
 * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function PageDispMode_CheckPropertyNew(pobjPageDispModeEN: clsPageDispModeEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjPageDispModeEN.pageDispModeName) === true )
{
 throw new Error("(errid:Watl000058)字段[页面显示模式名称]不能为空(In 页面显示模式)!(clsPageDispModeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPageDispModeEN.pageDispModeENName) === true )
{
 throw new Error("(errid:Watl000058)字段[页面显示模式英文名]不能为空(In 页面显示模式)!(clsPageDispModeBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjPageDispModeEN.pageDispModeId) == false && GetStrLen(pobjPageDispModeEN.pageDispModeId) > 2)
{
 throw new Error("(errid:Watl000059)字段[页面显示模式Id(pageDispModeId)]的长度不能超过2(In 页面显示模式(PageDispMode))!值:$(pobjPageDispModeEN.pageDispModeId)(clsPageDispModeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPageDispModeEN.pageDispModeName) == false && GetStrLen(pobjPageDispModeEN.pageDispModeName) > 50)
{
 throw new Error("(errid:Watl000059)字段[页面显示模式名称(pageDispModeName)]的长度不能超过50(In 页面显示模式(PageDispMode))!值:$(pobjPageDispModeEN.pageDispModeName)(clsPageDispModeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPageDispModeEN.pageDispModeENName) == false && GetStrLen(pobjPageDispModeEN.pageDispModeENName) > 50)
{
 throw new Error("(errid:Watl000059)字段[页面显示模式英文名(pageDispModeENName)]的长度不能超过50(In 页面显示模式(PageDispMode))!值:$(pobjPageDispModeEN.pageDispModeENName)(clsPageDispModeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPageDispModeEN.memo) == false && GetStrLen(pobjPageDispModeEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 页面显示模式(PageDispMode))!值:$(pobjPageDispModeEN.memo)(clsPageDispModeBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjPageDispModeEN.pageDispModeId) == false && undefined !== pobjPageDispModeEN.pageDispModeId && tzDataType.isString(pobjPageDispModeEN.pageDispModeId) === false)
{
 throw new Error("(errid:Watl000060)字段[页面显示模式Id(pageDispModeId)]的值:[$(pobjPageDispModeEN.pageDispModeId)], 非法，应该为字符型(In 页面显示模式(PageDispMode))!(clsPageDispModeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPageDispModeEN.pageDispModeName) == false && undefined !== pobjPageDispModeEN.pageDispModeName && tzDataType.isString(pobjPageDispModeEN.pageDispModeName) === false)
{
 throw new Error("(errid:Watl000060)字段[页面显示模式名称(pageDispModeName)]的值:[$(pobjPageDispModeEN.pageDispModeName)], 非法，应该为字符型(In 页面显示模式(PageDispMode))!(clsPageDispModeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPageDispModeEN.pageDispModeENName) == false && undefined !== pobjPageDispModeEN.pageDispModeENName && tzDataType.isString(pobjPageDispModeEN.pageDispModeENName) === false)
{
 throw new Error("(errid:Watl000060)字段[页面显示模式英文名(pageDispModeENName)]的值:[$(pobjPageDispModeEN.pageDispModeENName)], 非法，应该为字符型(In 页面显示模式(PageDispMode))!(clsPageDispModeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPageDispModeEN.memo) == false && undefined !== pobjPageDispModeEN.memo && tzDataType.isString(pobjPageDispModeEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjPageDispModeEN.memo)], 非法，应该为字符型(In 页面显示模式(PageDispMode))!(clsPageDispModeBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjPageDispModeEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function PageDispMode_CheckProperty4Update (pobjPageDispModeEN: clsPageDispModeEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjPageDispModeEN.pageDispModeId) == false && GetStrLen(pobjPageDispModeEN.pageDispModeId) > 2)
{
 throw new Error("(errid:Watl000062)字段[页面显示模式Id(pageDispModeId)]的长度不能超过2(In 页面显示模式(PageDispMode))!值:$(pobjPageDispModeEN.pageDispModeId)(clsPageDispModeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPageDispModeEN.pageDispModeName) == false && GetStrLen(pobjPageDispModeEN.pageDispModeName) > 50)
{
 throw new Error("(errid:Watl000062)字段[页面显示模式名称(pageDispModeName)]的长度不能超过50(In 页面显示模式(PageDispMode))!值:$(pobjPageDispModeEN.pageDispModeName)(clsPageDispModeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPageDispModeEN.pageDispModeENName) == false && GetStrLen(pobjPageDispModeEN.pageDispModeENName) > 50)
{
 throw new Error("(errid:Watl000062)字段[页面显示模式英文名(pageDispModeENName)]的长度不能超过50(In 页面显示模式(PageDispMode))!值:$(pobjPageDispModeEN.pageDispModeENName)(clsPageDispModeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPageDispModeEN.memo) == false && GetStrLen(pobjPageDispModeEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 页面显示模式(PageDispMode))!值:$(pobjPageDispModeEN.memo)(clsPageDispModeBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjPageDispModeEN.pageDispModeId) == false && undefined !== pobjPageDispModeEN.pageDispModeId && tzDataType.isString(pobjPageDispModeEN.pageDispModeId) === false)
{
 throw new Error("(errid:Watl000063)字段[页面显示模式Id(pageDispModeId)]的值:[$(pobjPageDispModeEN.pageDispModeId)], 非法，应该为字符型(In 页面显示模式(PageDispMode))!(clsPageDispModeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPageDispModeEN.pageDispModeName) == false && undefined !== pobjPageDispModeEN.pageDispModeName && tzDataType.isString(pobjPageDispModeEN.pageDispModeName) === false)
{
 throw new Error("(errid:Watl000063)字段[页面显示模式名称(pageDispModeName)]的值:[$(pobjPageDispModeEN.pageDispModeName)], 非法，应该为字符型(In 页面显示模式(PageDispMode))!(clsPageDispModeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPageDispModeEN.pageDispModeENName) == false && undefined !== pobjPageDispModeEN.pageDispModeENName && tzDataType.isString(pobjPageDispModeEN.pageDispModeENName) === false)
{
 throw new Error("(errid:Watl000063)字段[页面显示模式英文名(pageDispModeENName)]的值:[$(pobjPageDispModeEN.pageDispModeENName)], 非法，应该为字符型(In 页面显示模式(PageDispMode))!(clsPageDispModeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPageDispModeEN.memo) == false && undefined !== pobjPageDispModeEN.memo && tzDataType.isString(pobjPageDispModeEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjPageDispModeEN.memo)], 非法，应该为字符型(In 页面显示模式(PageDispMode))!(clsPageDispModeBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (IsNullOrEmpty(pobjPageDispModeEN.pageDispModeId) === true )
{
 throw new Error("(errid:Watl000064)字段[页面显示模式Id]不能为空(In 页面显示模式)!(clsPageDispModeBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjPageDispModeEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function PageDispMode_GetJSONStrByObj (pobjPageDispModeEN: clsPageDispModeEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjPageDispModeEN.sf_UpdFldSetStr = pobjPageDispModeEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjPageDispModeEN);
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
export function PageDispMode_GetObjLstByJSONStr (strJSON: string): Array<clsPageDispModeEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrPageDispModeObjLst = new Array<clsPageDispModeEN>();
if (strJSON === "")
{
return arrPageDispModeObjLst;
}
try
{
arrPageDispModeObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrPageDispModeObjLst;
}
return arrPageDispModeObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrPageDispModeObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function PageDispMode_GetObjLstByJSONObjLst (arrPageDispModeObjLstS: Array<clsPageDispModeEN>): Array<clsPageDispModeEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrPageDispModeObjLst = new Array<clsPageDispModeEN>();
for (const objInFor of arrPageDispModeObjLstS) {
const obj1 = PageDispMode_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrPageDispModeObjLst.push(obj1);
}
return arrPageDispModeObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function PageDispMode_GetObjByJSONStr (strJSON: string): clsPageDispModeEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjPageDispModeEN = new clsPageDispModeEN();
if (strJSON === "")
{
return pobjPageDispModeEN;
}
try
{
pobjPageDispModeEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjPageDispModeEN;
}
return pobjPageDispModeEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function PageDispMode_GetCombineCondition(objPageDispMode_Cond: clsPageDispModeEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objPageDispMode_Cond.dicFldComparisonOp, clsPageDispModeEN.con_PageDispModeId) == true)
{
const strComparisonOp_PageDispModeId:string = objPageDispMode_Cond.dicFldComparisonOp[clsPageDispModeEN.con_PageDispModeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsPageDispModeEN.con_PageDispModeId, objPageDispMode_Cond.pageDispModeId, strComparisonOp_PageDispModeId);
}
if (Object.prototype.hasOwnProperty.call(objPageDispMode_Cond.dicFldComparisonOp, clsPageDispModeEN.con_PageDispModeName) == true)
{
const strComparisonOp_PageDispModeName:string = objPageDispMode_Cond.dicFldComparisonOp[clsPageDispModeEN.con_PageDispModeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsPageDispModeEN.con_PageDispModeName, objPageDispMode_Cond.pageDispModeName, strComparisonOp_PageDispModeName);
}
if (Object.prototype.hasOwnProperty.call(objPageDispMode_Cond.dicFldComparisonOp, clsPageDispModeEN.con_PageDispModeENName) == true)
{
const strComparisonOp_PageDispModeENName:string = objPageDispMode_Cond.dicFldComparisonOp[clsPageDispModeEN.con_PageDispModeENName];
strWhereCond += Format(" And {0} {2} '{1}'", clsPageDispModeEN.con_PageDispModeENName, objPageDispMode_Cond.pageDispModeENName, strComparisonOp_PageDispModeENName);
}
if (Object.prototype.hasOwnProperty.call(objPageDispMode_Cond.dicFldComparisonOp, clsPageDispModeEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objPageDispMode_Cond.dicFldComparisonOp[clsPageDispModeEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsPageDispModeEN.con_Memo, objPageDispMode_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--PageDispMode(页面显示模式),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param strPageDispModeName: 页面显示模式名称(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function PageDispMode_GetUniCondStr_PageDispModeName(objPageDispModeEN: clsPageDispModeEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and PageDispModeName = '{0}'", objPageDispModeEN.pageDispModeName);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--PageDispMode(页面显示模式),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param strPageDispModeName: 页面显示模式名称(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function PageDispMode_GetUniCondStr4Update_PageDispModeName(objPageDispModeEN: clsPageDispModeEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and PageDispModeId <> '{0}'", objPageDispModeEN.pageDispModeId);
 strWhereCond +=  Format(" and PageDispModeName = '{0}'", objPageDispModeEN.pageDispModeName);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objPageDispModeENS:源对象
 * @param objPageDispModeENT:目标对象
*/
export function PageDispMode_CopyObjTo(objPageDispModeENS: clsPageDispModeEN , objPageDispModeENT: clsPageDispModeEN ): void 
{
objPageDispModeENT.pageDispModeId = objPageDispModeENS.pageDispModeId; //页面显示模式Id
objPageDispModeENT.pageDispModeName = objPageDispModeENS.pageDispModeName; //页面显示模式名称
objPageDispModeENT.pageDispModeENName = objPageDispModeENS.pageDispModeENName; //页面显示模式英文名
objPageDispModeENT.memo = objPageDispModeENS.memo; //备注
objPageDispModeENT.sf_UpdFldSetStr = objPageDispModeENS.updFldString; //sf_UpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objPageDispModeENS:源对象
 * @param objPageDispModeENT:目标对象
*/
export function PageDispMode_GetObjFromJsonObj(objPageDispModeENS: clsPageDispModeEN): clsPageDispModeEN 
{
 const objPageDispModeENT: clsPageDispModeEN = new clsPageDispModeEN();
ObjectAssign(objPageDispModeENT, objPageDispModeENS);
 return objPageDispModeENT;
}