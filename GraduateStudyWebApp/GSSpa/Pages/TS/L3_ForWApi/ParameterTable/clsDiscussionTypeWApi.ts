﻿
 /**
 * 类名:clsDiscussionTypeWApi
 * 表名:DiscussionType(01120589)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:46:20
 * 生成者:pyf
 * 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:研培参数(ParameterTable)
 * 框架-层名:WA_访问层(TS)(WA_Access)
 * 编程语言:TypeScript
 * 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
   *      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 **/

/**
 * 讨论类型表(DiscussionType)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clsDiscussionTypeEN } from "../../L0_Entity/ParameterTable/clsDiscussionTypeEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { tzDataType } from "../../PubFun/jsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const discussionType_Controller = "DiscussionTypeApi";
 export const discussionType_ConstructorName = "discussionType";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strDiscussionTypeId:关键字
 * @returns 对象
 **/
export async function DiscussionType_GetObjByDiscussionTypeIdAsync(strDiscussionTypeId: string): Promise<clsDiscussionTypeEN>  
{
const strThisFuncName = "GetObjByDiscussionTypeIdAsync";

if (IsNullOrEmpty(strDiscussionTypeId) == true)
{
  const strMsg = Format("参数:[strDiscussionTypeId]不能为空！(In GetObjByDiscussionTypeIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strDiscussionTypeId.length != 8)
{
const strMsg = Format("缓存分类变量:[strDiscussionTypeId]的长度:[{0}]不正确！", strDiscussionTypeId.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByDiscussionTypeId";
const strUrl = GetWebApiUrl(discussionType_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strDiscussionTypeId": strDiscussionTypeId,
}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObj = data.returnObj;
if (returnObj == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", discussionType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objDiscussionType = DiscussionType_GetObjFromJsonObj(returnObj);
return objDiscussionType;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, discussionType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, discussionType_ConstructorName, strThisFuncName);
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
 * @param strDiscussionTypeId:所给的关键字
 * @returns 对象
*/
export async function DiscussionType_GetObjByDiscussionTypeId_Cache(strDiscussionTypeId: string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByDiscussionTypeId_Cache";

if (IsNullOrEmpty(strDiscussionTypeId) == true)
{
  const strMsg = Format("参数:[strDiscussionTypeId]不能为空！(In GetObjByDiscussionTypeId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strDiscussionTypeId.length != 8)
{
const strMsg = Format("缓存分类变量:[strDiscussionTypeId]的长度:[{0}]不正确！", strDiscussionTypeId.length);
console.error(strMsg);
throw (strMsg);
}
const arrDiscussionTypeObjLst_Cache = await DiscussionType_GetObjLst_Cache();
try
{
const arrDiscussionType_Sel: Array <clsDiscussionTypeEN> = arrDiscussionTypeObjLst_Cache.filter(x => x.discussionTypeId == strDiscussionTypeId);
let objDiscussionType: clsDiscussionTypeEN;
if (arrDiscussionType_Sel.length > 0)
{
objDiscussionType = arrDiscussionType_Sel[0];
return objDiscussionType;
}
else
{
if (bolTryAsyncOnce == true)
{
objDiscussionType = await DiscussionType_GetObjByDiscussionTypeIdAsync(strDiscussionTypeId);
if (objDiscussionType != null)
{
DiscussionType_ReFreshThisCache();
return objDiscussionType;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strDiscussionTypeId, discussionType_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param strDiscussionTypeId:所给的关键字
 * @returns 对象
*/
export async function DiscussionType_GetObjByDiscussionTypeId_localStorage(strDiscussionTypeId: string) {
const strThisFuncName = "GetObjByDiscussionTypeId_localStorage";

if (IsNullOrEmpty(strDiscussionTypeId) == true)
{
  const strMsg = Format("参数:[strDiscussionTypeId]不能为空！(In GetObjByDiscussionTypeId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
if (strDiscussionTypeId.length != 8)
{
const strMsg = Format("缓存分类变量:[strDiscussionTypeId]的长度:[{0}]不正确！", strDiscussionTypeId.length);
console.error(strMsg);
throw (strMsg);
}
const strKey = Format("{0}_{1}", clsDiscussionTypeEN._CurrTabName, strDiscussionTypeId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objDiscussionType_Cache: clsDiscussionTypeEN = JSON.parse(strTempObj);
return objDiscussionType_Cache;
}
try
{
const objDiscussionType = await DiscussionType_GetObjByDiscussionTypeIdAsync(strDiscussionTypeId);
if (objDiscussionType != null)
{
localStorage.setItem(strKey, JSON.stringify(objDiscussionType));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objDiscussionType;
}
return objDiscussionType;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strDiscussionTypeId, discussionType_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objDiscussionType:所给的对象
 * @returns 对象
*/
export async function DiscussionType_UpdateObjInLst_Cache(objDiscussionType: clsDiscussionTypeEN) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrDiscussionTypeObjLst_Cache = await DiscussionType_GetObjLst_Cache();
const obj = arrDiscussionTypeObjLst_Cache.find(x => 
x.discussionTypeId == objDiscussionType.discussionTypeId);
if (obj != null)
{
objDiscussionType.discussionTypeId = obj.discussionTypeId;
ObjectAssign( obj, objDiscussionType);
}
else
{
arrDiscussionTypeObjLst_Cache.push(objDiscussionType);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, discussionType_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
}

/**
 * 根据关键字获取相关对象的名称属性, 从缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
 * @param strDiscussionTypeId:所给的关键字
 * @returns 对象
*/
export async function DiscussionType_GetNameByDiscussionTypeId_Cache(strDiscussionTypeId: string) {
const strThisFuncName = "GetNameByDiscussionTypeId_Cache";

if (IsNullOrEmpty(strDiscussionTypeId) == true)
{
  const strMsg = Format("参数:[strDiscussionTypeId]不能为空！(In GetNameByDiscussionTypeId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strDiscussionTypeId.length != 8)
{
const strMsg = Format("缓存分类变量:[strDiscussionTypeId]的长度:[{0}]不正确！", strDiscussionTypeId.length);
console.error(strMsg);
throw (strMsg);
}
const arrDiscussionTypeObjLst_Cache = await DiscussionType_GetObjLst_Cache();
if (arrDiscussionTypeObjLst_Cache == null) return "";
try
{
const arrDiscussionType_Sel: Array <clsDiscussionTypeEN> = arrDiscussionTypeObjLst_Cache.filter(x => x.discussionTypeId == strDiscussionTypeId);
let objDiscussionType: clsDiscussionTypeEN;
if (arrDiscussionType_Sel.length > 0)
{
objDiscussionType = arrDiscussionType_Sel[0];
return objDiscussionType.discussionTypeName;
}
else
{
return "";
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strDiscussionTypeId);
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
export async function DiscussionType_func(strInFldName:string , strOutFldName:string ,  strInValue: string) 
{
//const strThisFuncName = "func";

if (strInFldName != clsDiscussionTypeEN.con_DiscussionTypeId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsDiscussionTypeEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clsDiscussionTypeEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strDiscussionTypeId = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objDiscussionType = await DiscussionType_GetObjByDiscussionTypeId_Cache(strDiscussionTypeId );
if (objDiscussionType == null) return "";
return objDiscussionType.GetFldValue(strOutFldName).toString();
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
export function DiscussionType_SortFun_Defa(a:clsDiscussionTypeEN , b:clsDiscussionTypeEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.discussionTypeId.localeCompare(b.discussionTypeId);
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
export function DiscussionType_SortFun_Defa_2Fld(a:clsDiscussionTypeEN , b:clsDiscussionTypeEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.discussionTypeName == b.discussionTypeName) return a.updDate.localeCompare(b.updDate);
else return a.discussionTypeName.localeCompare(b.discussionTypeName);
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
export function DiscussionType_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsDiscussionTypeEN.con_DiscussionTypeId:
return (a: clsDiscussionTypeEN, b: clsDiscussionTypeEN) => {
return a.discussionTypeId.localeCompare(b.discussionTypeId);
}
case clsDiscussionTypeEN.con_DiscussionTypeName:
return (a: clsDiscussionTypeEN, b: clsDiscussionTypeEN) => {
return a.discussionTypeName.localeCompare(b.discussionTypeName);
}
case clsDiscussionTypeEN.con_UpdDate:
return (a: clsDiscussionTypeEN, b: clsDiscussionTypeEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsDiscussionTypeEN.con_UpdUser:
return (a: clsDiscussionTypeEN, b: clsDiscussionTypeEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsDiscussionTypeEN.con_Memo:
return (a: clsDiscussionTypeEN, b: clsDiscussionTypeEN) => {
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[DiscussionType]中不存在！(in ${ discussionType_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsDiscussionTypeEN.con_DiscussionTypeId:
return (a: clsDiscussionTypeEN, b: clsDiscussionTypeEN) => {
return b.discussionTypeId.localeCompare(a.discussionTypeId);
}
case clsDiscussionTypeEN.con_DiscussionTypeName:
return (a: clsDiscussionTypeEN, b: clsDiscussionTypeEN) => {
return b.discussionTypeName.localeCompare(a.discussionTypeName);
}
case clsDiscussionTypeEN.con_UpdDate:
return (a: clsDiscussionTypeEN, b: clsDiscussionTypeEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsDiscussionTypeEN.con_UpdUser:
return (a: clsDiscussionTypeEN, b: clsDiscussionTypeEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsDiscussionTypeEN.con_Memo:
return (a: clsDiscussionTypeEN, b: clsDiscussionTypeEN) => {
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[DiscussionType]中不存在！(in ${ discussionType_ConstructorName}.${ strThisFuncName})`;
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
export async function DiscussionType_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsDiscussionTypeEN.con_DiscussionTypeId:
return (obj: clsDiscussionTypeEN) => {
return obj.discussionTypeId === value;
}
case clsDiscussionTypeEN.con_DiscussionTypeName:
return (obj: clsDiscussionTypeEN) => {
return obj.discussionTypeName === value;
}
case clsDiscussionTypeEN.con_UpdDate:
return (obj: clsDiscussionTypeEN) => {
return obj.updDate === value;
}
case clsDiscussionTypeEN.con_UpdUser:
return (obj: clsDiscussionTypeEN) => {
return obj.updUser === value;
}
case clsDiscussionTypeEN.con_Memo:
return (obj: clsDiscussionTypeEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[DiscussionType]中不存在！(in ${ discussionType_ConstructorName}.${ strThisFuncName})`;
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
export async function DiscussionType_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(discussionType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, discussionType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, discussionType_ConstructorName, strThisFuncName);
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
export async function DiscussionType_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(discussionType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, discussionType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, discussionType_ConstructorName, strThisFuncName);
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
export async function DiscussionType_GetFirstObjAsync(strWhereCond: string): Promise<clsDiscussionTypeEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(discussionType_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", discussionType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objDiscussionType = DiscussionType_GetObjFromJsonObj(returnObj);
return objDiscussionType;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, discussionType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, discussionType_ConstructorName, strThisFuncName);
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
export async function DiscussionType_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsDiscussionTypeEN._CurrTabName;
clsDiscussionTypeEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsDiscussionTypeEN._CurrTabName);
if (IsNullOrEmpty(clsDiscussionTypeEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsDiscussionTypeEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrDiscussionTypeExObjLst_Cache: Array<clsDiscussionTypeEN> = CacheHelper.Get(strKey);
const arrDiscussionTypeObjLst_T = DiscussionType_GetObjLstByJSONObjLst(arrDiscussionTypeExObjLst_Cache);
return arrDiscussionTypeObjLst_T;
}
try
{
const arrDiscussionTypeExObjLst = await DiscussionType_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrDiscussionTypeExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrDiscussionTypeExObjLst.length);
console.log(strInfo);
return arrDiscussionTypeExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, discussionType_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function DiscussionType_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsDiscussionTypeEN._CurrTabName;
clsDiscussionTypeEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsDiscussionTypeEN._CurrTabName);
if (IsNullOrEmpty(clsDiscussionTypeEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsDiscussionTypeEN.CacheAddiCondition);
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
const arrDiscussionTypeExObjLst_Cache: Array<clsDiscussionTypeEN> = JSON.parse(strTempObjLst);
const arrDiscussionTypeObjLst_T = DiscussionType_GetObjLstByJSONObjLst(arrDiscussionTypeExObjLst_Cache);
return arrDiscussionTypeObjLst_T;
}
try
{
const arrDiscussionTypeExObjLst = await DiscussionType_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrDiscussionTypeExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrDiscussionTypeExObjLst.length);
console.log(strInfo);
return arrDiscussionTypeExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, discussionType_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function DiscussionType_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsDiscussionTypeEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrDiscussionTypeObjLst_Cache: Array<clsDiscussionTypeEN> = JSON.parse(strTempObjLst);
return arrDiscussionTypeObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function DiscussionType_GetObjLstAsync(strWhereCond: string): Promise<Array<clsDiscussionTypeEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(discussionType_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", discussionType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = DiscussionType_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, discussionType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, discussionType_ConstructorName, strThisFuncName);
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
export async function DiscussionType_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsDiscussionTypeEN._CurrTabName;
clsDiscussionTypeEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsDiscussionTypeEN._CurrTabName);
if (IsNullOrEmpty(clsDiscussionTypeEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsDiscussionTypeEN.CacheAddiCondition);
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
const arrDiscussionTypeExObjLst_Cache: Array<clsDiscussionTypeEN> = JSON.parse(strTempObjLst);
const arrDiscussionTypeObjLst_T = DiscussionType_GetObjLstByJSONObjLst(arrDiscussionTypeExObjLst_Cache);
return arrDiscussionTypeObjLst_T;
}
try
{
const arrDiscussionTypeExObjLst = await DiscussionType_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrDiscussionTypeExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrDiscussionTypeExObjLst.length);
console.log(strInfo);
return arrDiscussionTypeExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, discussionType_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function DiscussionType_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsDiscussionTypeEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrDiscussionTypeObjLst_Cache: Array<clsDiscussionTypeEN> = JSON.parse(strTempObjLst);
return arrDiscussionTypeObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function DiscussionType_GetObjLst_Cache(): Promise<Array<clsDiscussionTypeEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrDiscussionTypeObjLst_Cache;
switch (clsDiscussionTypeEN.CacheModeId)
{
case "04"://sessionStorage
arrDiscussionTypeObjLst_Cache = await DiscussionType_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrDiscussionTypeObjLst_Cache = await DiscussionType_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrDiscussionTypeObjLst_Cache = await DiscussionType_GetObjLst_ClientCache();
break;
default:
arrDiscussionTypeObjLst_Cache = await DiscussionType_GetObjLst_ClientCache();
break;
}
const arrDiscussionTypeObjLst = DiscussionType_GetObjLstByJSONObjLst(arrDiscussionTypeObjLst_Cache);
return arrDiscussionTypeObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function DiscussionType_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrDiscussionTypeObjLst_Cache;
switch (clsDiscussionTypeEN.CacheModeId)
{
case "04"://sessionStorage
arrDiscussionTypeObjLst_Cache = await DiscussionType_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrDiscussionTypeObjLst_Cache = await DiscussionType_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrDiscussionTypeObjLst_Cache = null;
break;
default:
arrDiscussionTypeObjLst_Cache = null;
break;
}
return arrDiscussionTypeObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrDiscussionTypeId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function DiscussionType_GetSubObjLst_Cache(objDiscussionType_Cond: clsDiscussionTypeEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrDiscussionTypeObjLst_Cache = await DiscussionType_GetObjLst_Cache();
let arrDiscussionType_Sel: Array < clsDiscussionTypeEN > = arrDiscussionTypeObjLst_Cache;
if (objDiscussionType_Cond.sf_FldComparisonOp == null || objDiscussionType_Cond.sf_FldComparisonOp == "") return arrDiscussionType_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objDiscussionType_Cond.sf_FldComparisonOp);
//console.log("clsDiscussionTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objDiscussionType_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrDiscussionType_Sel = arrDiscussionType_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objDiscussionType_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrDiscussionType_Sel = arrDiscussionType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrDiscussionType_Sel = arrDiscussionType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrDiscussionType_Sel = arrDiscussionType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrDiscussionType_Sel = arrDiscussionType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrDiscussionType_Sel = arrDiscussionType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrDiscussionType_Sel = arrDiscussionType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrDiscussionType_Sel = arrDiscussionType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrDiscussionType_Sel = arrDiscussionType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrDiscussionType_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objDiscussionType_Cond), discussionType_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsDiscussionTypeEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrDiscussionTypeId:关键字列表
 * @returns 对象列表
 **/
export async function DiscussionType_GetObjLstByDiscussionTypeIdLstAsync(arrDiscussionTypeId: Array<string>): Promise<Array<clsDiscussionTypeEN>>  
{
const strThisFuncName = "GetObjLstByDiscussionTypeIdLstAsync";
const strAction = "GetObjLstByDiscussionTypeIdLst";
const strUrl = GetWebApiUrl(discussionType_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrDiscussionTypeId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", discussionType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = DiscussionType_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, discussionType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, discussionType_ConstructorName, strThisFuncName);
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
 * @param arrstrDiscussionTypeIdLst:关键字列表
 * @returns 对象列表
*/
export async function DiscussionType_GetObjLstByDiscussionTypeIdLst_Cache(arrDiscussionTypeIdLst: Array<string>) {
const strThisFuncName = "GetObjLstByDiscussionTypeIdLst_Cache";
try
{
const arrDiscussionTypeObjLst_Cache = await DiscussionType_GetObjLst_Cache();
const arrDiscussionType_Sel: Array <clsDiscussionTypeEN> = arrDiscussionTypeObjLst_Cache.filter(x => arrDiscussionTypeIdLst.indexOf(x.discussionTypeId)>-1);
return arrDiscussionType_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrDiscussionTypeIdLst.join(","), discussionType_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsDiscussionTypeEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function DiscussionType_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsDiscussionTypeEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(discussionType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", discussionType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = DiscussionType_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, discussionType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, discussionType_ConstructorName, strThisFuncName);
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
export async function DiscussionType_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsDiscussionTypeEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(discussionType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", discussionType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = DiscussionType_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, discussionType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, discussionType_ConstructorName, strThisFuncName);
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
export async function DiscussionType_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(discussionType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, discussionType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, discussionType_ConstructorName, strThisFuncName);
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
export async function DiscussionType_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrDiscussionTypeObjLst_Cache = await DiscussionType_GetObjLst_Cache();
if (arrDiscussionTypeObjLst_Cache.length == 0) return arrDiscussionTypeObjLst_Cache;
let arrDiscussionType_Sel = arrDiscussionTypeObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objDiscussionType_Cond = new clsDiscussionTypeEN();
ObjectAssign(objDiscussionType_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsDiscussionTypeWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrDiscussionType_Sel = arrDiscussionType_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objDiscussionType_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrDiscussionType_Sel = arrDiscussionType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrDiscussionType_Sel = arrDiscussionType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrDiscussionType_Sel = arrDiscussionType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrDiscussionType_Sel = arrDiscussionType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrDiscussionType_Sel = arrDiscussionType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrDiscussionType_Sel = arrDiscussionType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrDiscussionType_Sel = arrDiscussionType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrDiscussionType_Sel = arrDiscussionType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrDiscussionType_Sel = arrDiscussionType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrDiscussionType_Sel.length == 0) return arrDiscussionType_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrDiscussionType_Sel = arrDiscussionType_Sel.sort(DiscussionType_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrDiscussionType_Sel = arrDiscussionType_Sel.sort(objPagerPara.sortFun);
}
arrDiscussionType_Sel = arrDiscussionType_Sel.slice(intStart, intEnd);     
return arrDiscussionType_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, discussionType_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsDiscussionTypeEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function DiscussionType_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsDiscussionTypeEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(discussionType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", discussionType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = DiscussionType_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, discussionType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, discussionType_ConstructorName, strThisFuncName);
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
 * @param strDiscussionTypeId:关键字
 * @returns 获取删除的结果
 **/
export async function DiscussionType_DelRecordAsync(strDiscussionTypeId: string): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(discussionType_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, strDiscussionTypeId);
try
{
const response = await axios.delete(strUrl,
{
params: { "Id": strDiscussionTypeId, }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, discussionType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, discussionType_ConstructorName, strThisFuncName);
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
 * @param arrDiscussionTypeId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function DiscussionType_DelDiscussionTypesAsync(arrDiscussionTypeId: Array<string>): Promise<number> 
{
const strThisFuncName = "DelDiscussionTypesAsync";
const strAction = "DelDiscussionTypes";
const strUrl = GetWebApiUrl(discussionType_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrDiscussionTypeId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, discussionType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, discussionType_ConstructorName, strThisFuncName);
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
export async function DiscussionType_DelDiscussionTypesByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "DelDiscussionTypesByCondAsync";
const strAction = "DelDiscussionTypesByCond";
const strUrl = GetWebApiUrl(discussionType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, discussionType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, discussionType_ConstructorName, strThisFuncName);
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
 * @param objDiscussionTypeEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function DiscussionType_AddNewRecordAsync(objDiscussionTypeEN: clsDiscussionTypeEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
if (objDiscussionTypeEN.discussionTypeId === null || objDiscussionTypeEN.discussionTypeId === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objDiscussionTypeEN);
const strUrl = GetWebApiUrl(discussionType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objDiscussionTypeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, discussionType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, discussionType_ConstructorName, strThisFuncName);
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
 * @param objDiscussionTypeEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function DiscussionType_AddNewRecordWithMaxIdAsync(objDiscussionTypeEN: clsDiscussionTypeEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithMaxIdAsync";
const strAction = "AddNewRecordWithMaxId";
const strUrl = GetWebApiUrl(discussionType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objDiscussionTypeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, discussionType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, discussionType_ConstructorName, strThisFuncName);
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
 * @param objDiscussionTypeEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function DiscussionType_AddNewRecordWithReturnKeyAsync(objDiscussionTypeEN: clsDiscussionTypeEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(discussionType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objDiscussionTypeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, discussionType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, discussionType_ConstructorName, strThisFuncName);
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
 * @param objDiscussionTypeEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function DiscussionType_AddNewRecordWithReturnKey(objDiscussionTypeEN: clsDiscussionTypeEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objDiscussionTypeEN.discussionTypeId === null || objDiscussionTypeEN.discussionTypeId === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(discussionType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objDiscussionTypeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, discussionType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, discussionType_ConstructorName, strThisFuncName);
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
 * @param objDiscussionTypeEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function DiscussionType_UpdateRecordAsync(objDiscussionTypeEN: clsDiscussionTypeEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objDiscussionTypeEN.sf_UpdFldSetStr === undefined || objDiscussionTypeEN.sf_UpdFldSetStr === null || objDiscussionTypeEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objDiscussionTypeEN.discussionTypeId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(discussionType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objDiscussionTypeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, discussionType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, discussionType_ConstructorName, strThisFuncName);
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
 * @param objDiscussionTypeEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function DiscussionType_UpdateWithConditionAsync(objDiscussionTypeEN: clsDiscussionTypeEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objDiscussionTypeEN.sf_UpdFldSetStr === undefined || objDiscussionTypeEN.sf_UpdFldSetStr === null || objDiscussionTypeEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objDiscussionTypeEN.discussionTypeId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(discussionType_Controller, strAction);
objDiscussionTypeEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objDiscussionTypeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, discussionType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, discussionType_ConstructorName, strThisFuncName);
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
 * @param objstrDiscussionTypeId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function DiscussionType_IsExistRecord_Cache(objDiscussionType_Cond: clsDiscussionTypeEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrDiscussionTypeObjLst_Cache = await DiscussionType_GetObjLst_Cache();
if (arrDiscussionTypeObjLst_Cache == null) return false;
let arrDiscussionType_Sel: Array < clsDiscussionTypeEN > = arrDiscussionTypeObjLst_Cache;
if (objDiscussionType_Cond.sf_FldComparisonOp == null || objDiscussionType_Cond.sf_FldComparisonOp == "") return arrDiscussionType_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objDiscussionType_Cond.sf_FldComparisonOp);
//console.log("clsDiscussionTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objDiscussionType_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objDiscussionType_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrDiscussionType_Sel = arrDiscussionType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrDiscussionType_Sel = arrDiscussionType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrDiscussionType_Sel = arrDiscussionType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrDiscussionType_Sel = arrDiscussionType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrDiscussionType_Sel = arrDiscussionType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrDiscussionType_Sel = arrDiscussionType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrDiscussionType_Sel = arrDiscussionType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrDiscussionType_Sel = arrDiscussionType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrDiscussionType_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objDiscussionType_Cond), discussionType_ConstructorName, strThisFuncName);
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
export async function DiscussionType_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(discussionType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, discussionType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, discussionType_ConstructorName, strThisFuncName);
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
 * @param strDiscussionTypeId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function DiscussionType_IsExist(strDiscussionTypeId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(discussionType_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"DiscussionTypeId": strDiscussionTypeId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, discussionType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, discussionType_ConstructorName, strThisFuncName);
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
 * @param strDiscussionTypeId:所给的关键字
 * @returns 对象
*/
export async function DiscussionType_IsExist_Cache(strDiscussionTypeId:string) {
const strThisFuncName = "IsExist_Cache";
const arrDiscussionTypeObjLst_Cache = await DiscussionType_GetObjLst_Cache();
if (arrDiscussionTypeObjLst_Cache == null) return false;
try
{
const arrDiscussionType_Sel: Array <clsDiscussionTypeEN> = arrDiscussionTypeObjLst_Cache.filter(x => x.discussionTypeId == strDiscussionTypeId);
if (arrDiscussionType_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strDiscussionTypeId, discussionType_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param strDiscussionTypeId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function DiscussionType_IsExistAsync(strDiscussionTypeId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(discussionType_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strDiscussionTypeId": strDiscussionTypeId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, discussionType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, discussionType_ConstructorName, strThisFuncName);
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
export async function DiscussionType_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(discussionType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, discussionType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, discussionType_ConstructorName, strThisFuncName);
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
 * @param objDiscussionType_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function DiscussionType_GetRecCountByCond_Cache(objDiscussionType_Cond: clsDiscussionTypeEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrDiscussionTypeObjLst_Cache = await DiscussionType_GetObjLst_Cache();
if (arrDiscussionTypeObjLst_Cache == null) return 0;
let arrDiscussionType_Sel: Array < clsDiscussionTypeEN > = arrDiscussionTypeObjLst_Cache;
if (objDiscussionType_Cond.sf_FldComparisonOp == null || objDiscussionType_Cond.sf_FldComparisonOp == "") return arrDiscussionType_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objDiscussionType_Cond.sf_FldComparisonOp);
//console.log("clsDiscussionTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objDiscussionType_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrDiscussionType_Sel = arrDiscussionType_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objDiscussionType_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrDiscussionType_Sel = arrDiscussionType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrDiscussionType_Sel = arrDiscussionType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrDiscussionType_Sel = arrDiscussionType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrDiscussionType_Sel = arrDiscussionType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrDiscussionType_Sel = arrDiscussionType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrDiscussionType_Sel = arrDiscussionType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrDiscussionType_Sel = arrDiscussionType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrDiscussionType_Sel = arrDiscussionType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrDiscussionType_Sel = arrDiscussionType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrDiscussionType_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objDiscussionType_Cond), discussionType_ConstructorName, strThisFuncName);
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
export async function DiscussionType_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(discussionType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, discussionType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, discussionType_ConstructorName, strThisFuncName);
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
export function DiscussionType_GetWebApiUrl(strController: string, strAction: string): string {
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
export function DiscussionType_ReFreshCache():void
{
const strThisFuncName = "ReFreshCache";

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = clsDiscussionTypeEN._CurrTabName;
switch (clsDiscussionTypeEN.CacheModeId)
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
export function DiscussionType_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clsDiscussionTypeEN._CurrTabName;
switch (clsDiscussionTypeEN.CacheModeId)
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
export async function DiscussionType__Cache(strDivName: string, strDdlName: string )
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
const arrObjLst_Sel = await DiscussionType_GetObjLst_Cache();
if (arrObjLst_Sel == null) return;
BindDdl_ObjLstInDiv(strDivName, strDdlName, arrObjLst_Sel, clsDiscussionTypeEN.con_DiscussionTypeId, clsDiscussionTypeEN.con_DiscussionTypeName, "讨论类型表");
}

/**
 * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function DiscussionType_CheckPropertyNew(pobjDiscussionTypeEN: clsDiscussionTypeEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjDiscussionTypeEN.discussionTypeId) == false && GetStrLen(pobjDiscussionTypeEN.discussionTypeId) > 8)
{
 throw new Error("(errid:Watl000059)字段[讨论类型Id(discussionTypeId)]的长度不能超过8(In 讨论类型表(DiscussionType))!值:$(pobjDiscussionTypeEN.discussionTypeId)(clsDiscussionTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjDiscussionTypeEN.discussionTypeName) == false && GetStrLen(pobjDiscussionTypeEN.discussionTypeName) > 200)
{
 throw new Error("(errid:Watl000059)字段[讨论类型名称(discussionTypeName)]的长度不能超过200(In 讨论类型表(DiscussionType))!值:$(pobjDiscussionTypeEN.discussionTypeName)(clsDiscussionTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjDiscussionTypeEN.updDate) == false && GetStrLen(pobjDiscussionTypeEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 讨论类型表(DiscussionType))!值:$(pobjDiscussionTypeEN.updDate)(clsDiscussionTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjDiscussionTypeEN.updUser) == false && GetStrLen(pobjDiscussionTypeEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 讨论类型表(DiscussionType))!值:$(pobjDiscussionTypeEN.updUser)(clsDiscussionTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjDiscussionTypeEN.memo) == false && GetStrLen(pobjDiscussionTypeEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 讨论类型表(DiscussionType))!值:$(pobjDiscussionTypeEN.memo)(clsDiscussionTypeBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjDiscussionTypeEN.discussionTypeId) == false && undefined !== pobjDiscussionTypeEN.discussionTypeId && tzDataType.isString(pobjDiscussionTypeEN.discussionTypeId) === false)
{
 throw new Error("(errid:Watl000060)字段[讨论类型Id(discussionTypeId)]的值:[$(pobjDiscussionTypeEN.discussionTypeId)], 非法，应该为字符型(In 讨论类型表(DiscussionType))!(clsDiscussionTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjDiscussionTypeEN.discussionTypeName) == false && undefined !== pobjDiscussionTypeEN.discussionTypeName && tzDataType.isString(pobjDiscussionTypeEN.discussionTypeName) === false)
{
 throw new Error("(errid:Watl000060)字段[讨论类型名称(discussionTypeName)]的值:[$(pobjDiscussionTypeEN.discussionTypeName)], 非法，应该为字符型(In 讨论类型表(DiscussionType))!(clsDiscussionTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjDiscussionTypeEN.updDate) == false && undefined !== pobjDiscussionTypeEN.updDate && tzDataType.isString(pobjDiscussionTypeEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjDiscussionTypeEN.updDate)], 非法，应该为字符型(In 讨论类型表(DiscussionType))!(clsDiscussionTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjDiscussionTypeEN.updUser) == false && undefined !== pobjDiscussionTypeEN.updUser && tzDataType.isString(pobjDiscussionTypeEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjDiscussionTypeEN.updUser)], 非法，应该为字符型(In 讨论类型表(DiscussionType))!(clsDiscussionTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjDiscussionTypeEN.memo) == false && undefined !== pobjDiscussionTypeEN.memo && tzDataType.isString(pobjDiscussionTypeEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjDiscussionTypeEN.memo)], 非法，应该为字符型(In 讨论类型表(DiscussionType))!(clsDiscussionTypeBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjDiscussionTypeEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function DiscussionType_CheckProperty4Update (pobjDiscussionTypeEN: clsDiscussionTypeEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjDiscussionTypeEN.discussionTypeId) == false && GetStrLen(pobjDiscussionTypeEN.discussionTypeId) > 8)
{
 throw new Error("(errid:Watl000062)字段[讨论类型Id(discussionTypeId)]的长度不能超过8(In 讨论类型表(DiscussionType))!值:$(pobjDiscussionTypeEN.discussionTypeId)(clsDiscussionTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjDiscussionTypeEN.discussionTypeName) == false && GetStrLen(pobjDiscussionTypeEN.discussionTypeName) > 200)
{
 throw new Error("(errid:Watl000062)字段[讨论类型名称(discussionTypeName)]的长度不能超过200(In 讨论类型表(DiscussionType))!值:$(pobjDiscussionTypeEN.discussionTypeName)(clsDiscussionTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjDiscussionTypeEN.updDate) == false && GetStrLen(pobjDiscussionTypeEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 讨论类型表(DiscussionType))!值:$(pobjDiscussionTypeEN.updDate)(clsDiscussionTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjDiscussionTypeEN.updUser) == false && GetStrLen(pobjDiscussionTypeEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 讨论类型表(DiscussionType))!值:$(pobjDiscussionTypeEN.updUser)(clsDiscussionTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjDiscussionTypeEN.memo) == false && GetStrLen(pobjDiscussionTypeEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 讨论类型表(DiscussionType))!值:$(pobjDiscussionTypeEN.memo)(clsDiscussionTypeBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjDiscussionTypeEN.discussionTypeId) == false && undefined !== pobjDiscussionTypeEN.discussionTypeId && tzDataType.isString(pobjDiscussionTypeEN.discussionTypeId) === false)
{
 throw new Error("(errid:Watl000063)字段[讨论类型Id(discussionTypeId)]的值:[$(pobjDiscussionTypeEN.discussionTypeId)], 非法，应该为字符型(In 讨论类型表(DiscussionType))!(clsDiscussionTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjDiscussionTypeEN.discussionTypeName) == false && undefined !== pobjDiscussionTypeEN.discussionTypeName && tzDataType.isString(pobjDiscussionTypeEN.discussionTypeName) === false)
{
 throw new Error("(errid:Watl000063)字段[讨论类型名称(discussionTypeName)]的值:[$(pobjDiscussionTypeEN.discussionTypeName)], 非法，应该为字符型(In 讨论类型表(DiscussionType))!(clsDiscussionTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjDiscussionTypeEN.updDate) == false && undefined !== pobjDiscussionTypeEN.updDate && tzDataType.isString(pobjDiscussionTypeEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjDiscussionTypeEN.updDate)], 非法，应该为字符型(In 讨论类型表(DiscussionType))!(clsDiscussionTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjDiscussionTypeEN.updUser) == false && undefined !== pobjDiscussionTypeEN.updUser && tzDataType.isString(pobjDiscussionTypeEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjDiscussionTypeEN.updUser)], 非法，应该为字符型(In 讨论类型表(DiscussionType))!(clsDiscussionTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjDiscussionTypeEN.memo) == false && undefined !== pobjDiscussionTypeEN.memo && tzDataType.isString(pobjDiscussionTypeEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjDiscussionTypeEN.memo)], 非法，应该为字符型(In 讨论类型表(DiscussionType))!(clsDiscussionTypeBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (IsNullOrEmpty(pobjDiscussionTypeEN.discussionTypeId) === true 
 || pobjDiscussionTypeEN.discussionTypeId.toString()  ===  "0" )
{
 throw new Error("(errid:Watl000064)字段[讨论类型Id]不能为空(In 讨论类型表)!(clsDiscussionTypeBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjDiscussionTypeEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function DiscussionType_GetJSONStrByObj (pobjDiscussionTypeEN: clsDiscussionTypeEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjDiscussionTypeEN.sf_UpdFldSetStr = pobjDiscussionTypeEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjDiscussionTypeEN);
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
export function DiscussionType_GetObjLstByJSONStr (strJSON: string): Array<clsDiscussionTypeEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrDiscussionTypeObjLst = new Array<clsDiscussionTypeEN>();
if (strJSON === "")
{
return arrDiscussionTypeObjLst;
}
try
{
arrDiscussionTypeObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrDiscussionTypeObjLst;
}
return arrDiscussionTypeObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrDiscussionTypeObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function DiscussionType_GetObjLstByJSONObjLst (arrDiscussionTypeObjLstS: Array<clsDiscussionTypeEN>): Array<clsDiscussionTypeEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrDiscussionTypeObjLst = new Array<clsDiscussionTypeEN>();
for (const objInFor of arrDiscussionTypeObjLstS) {
const obj1 = DiscussionType_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrDiscussionTypeObjLst.push(obj1);
}
return arrDiscussionTypeObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function DiscussionType_GetObjByJSONStr (strJSON: string): clsDiscussionTypeEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjDiscussionTypeEN = new clsDiscussionTypeEN();
if (strJSON === "")
{
return pobjDiscussionTypeEN;
}
try
{
pobjDiscussionTypeEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjDiscussionTypeEN;
}
return pobjDiscussionTypeEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function DiscussionType_GetCombineCondition(objDiscussionType_Cond: clsDiscussionTypeEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objDiscussionType_Cond.dicFldComparisonOp, clsDiscussionTypeEN.con_DiscussionTypeId) == true)
{
const strComparisonOp_DiscussionTypeId:string = objDiscussionType_Cond.dicFldComparisonOp[clsDiscussionTypeEN.con_DiscussionTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsDiscussionTypeEN.con_DiscussionTypeId, objDiscussionType_Cond.discussionTypeId, strComparisonOp_DiscussionTypeId);
}
if (Object.prototype.hasOwnProperty.call(objDiscussionType_Cond.dicFldComparisonOp, clsDiscussionTypeEN.con_DiscussionTypeName) == true)
{
const strComparisonOp_DiscussionTypeName:string = objDiscussionType_Cond.dicFldComparisonOp[clsDiscussionTypeEN.con_DiscussionTypeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsDiscussionTypeEN.con_DiscussionTypeName, objDiscussionType_Cond.discussionTypeName, strComparisonOp_DiscussionTypeName);
}
if (Object.prototype.hasOwnProperty.call(objDiscussionType_Cond.dicFldComparisonOp, clsDiscussionTypeEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objDiscussionType_Cond.dicFldComparisonOp[clsDiscussionTypeEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsDiscussionTypeEN.con_UpdDate, objDiscussionType_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objDiscussionType_Cond.dicFldComparisonOp, clsDiscussionTypeEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objDiscussionType_Cond.dicFldComparisonOp[clsDiscussionTypeEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsDiscussionTypeEN.con_UpdUser, objDiscussionType_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objDiscussionType_Cond.dicFldComparisonOp, clsDiscussionTypeEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objDiscussionType_Cond.dicFldComparisonOp[clsDiscussionTypeEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsDiscussionTypeEN.con_Memo, objDiscussionType_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objDiscussionTypeENS:源对象
 * @param objDiscussionTypeENT:目标对象
*/
export function DiscussionType_CopyObjTo(objDiscussionTypeENS: clsDiscussionTypeEN , objDiscussionTypeENT: clsDiscussionTypeEN ): void 
{
objDiscussionTypeENT.discussionTypeId = objDiscussionTypeENS.discussionTypeId; //讨论类型Id
objDiscussionTypeENT.discussionTypeName = objDiscussionTypeENS.discussionTypeName; //讨论类型名称
objDiscussionTypeENT.updDate = objDiscussionTypeENS.updDate; //修改日期
objDiscussionTypeENT.updUser = objDiscussionTypeENS.updUser; //修改人
objDiscussionTypeENT.memo = objDiscussionTypeENS.memo; //备注
objDiscussionTypeENT.sf_UpdFldSetStr = objDiscussionTypeENS.updFldString; //sf_UpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objDiscussionTypeENS:源对象
 * @param objDiscussionTypeENT:目标对象
*/
export function DiscussionType_GetObjFromJsonObj(objDiscussionTypeENS: clsDiscussionTypeEN): clsDiscussionTypeEN 
{
 const objDiscussionTypeENT: clsDiscussionTypeEN = new clsDiscussionTypeEN();
ObjectAssign(objDiscussionTypeENT, objDiscussionTypeENS);
 return objDiscussionTypeENT;
}