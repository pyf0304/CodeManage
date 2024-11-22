﻿
 /**
 * 类名:clsSysCommentTypeWApi
 * 表名:SysCommentType(01120623)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:46:21
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
 * 评论类型表(SysCommentType)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clsSysCommentTypeEN } from "../../L0_Entity/ParameterTable/clsSysCommentTypeEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { tzDataType } from "../../PubFun/jsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const sysCommentType_Controller = "SysCommentTypeApi";
 export const sysCommentType_ConstructorName = "sysCommentType";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strCommentTypeId:关键字
 * @returns 对象
 **/
export async function SysCommentType_GetObjByCommentTypeIdAsync(strCommentTypeId: string): Promise<clsSysCommentTypeEN>  
{
const strThisFuncName = "GetObjByCommentTypeIdAsync";

if (IsNullOrEmpty(strCommentTypeId) == true)
{
  const strMsg = Format("参数:[strCommentTypeId]不能为空！(In GetObjByCommentTypeIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strCommentTypeId.length != 2)
{
const strMsg = Format("缓存分类变量:[strCommentTypeId]的长度:[{0}]不正确！", strCommentTypeId.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByCommentTypeId";
const strUrl = GetWebApiUrl(sysCommentType_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strCommentTypeId": strCommentTypeId,
}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObj = data.returnObj;
if (returnObj == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sysCommentType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objSysCommentType = SysCommentType_GetObjFromJsonObj(returnObj);
return objSysCommentType;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysCommentType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysCommentType_ConstructorName, strThisFuncName);
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
 * @param strCommentTypeId:所给的关键字
 * @returns 对象
*/
export async function SysCommentType_GetObjByCommentTypeId_Cache(strCommentTypeId: string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByCommentTypeId_Cache";

if (IsNullOrEmpty(strCommentTypeId) == true)
{
  const strMsg = Format("参数:[strCommentTypeId]不能为空！(In GetObjByCommentTypeId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strCommentTypeId.length != 2)
{
const strMsg = Format("缓存分类变量:[strCommentTypeId]的长度:[{0}]不正确！", strCommentTypeId.length);
console.error(strMsg);
throw (strMsg);
}
const arrSysCommentTypeObjLst_Cache = await SysCommentType_GetObjLst_Cache();
try
{
const arrSysCommentType_Sel: Array <clsSysCommentTypeEN> = arrSysCommentTypeObjLst_Cache.filter(x => x.commentTypeId == strCommentTypeId);
let objSysCommentType: clsSysCommentTypeEN;
if (arrSysCommentType_Sel.length > 0)
{
objSysCommentType = arrSysCommentType_Sel[0];
return objSysCommentType;
}
else
{
if (bolTryAsyncOnce == true)
{
objSysCommentType = await SysCommentType_GetObjByCommentTypeIdAsync(strCommentTypeId);
if (objSysCommentType != null)
{
SysCommentType_ReFreshThisCache();
return objSysCommentType;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strCommentTypeId, sysCommentType_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param strCommentTypeId:所给的关键字
 * @returns 对象
*/
export async function SysCommentType_GetObjByCommentTypeId_localStorage(strCommentTypeId: string) {
const strThisFuncName = "GetObjByCommentTypeId_localStorage";

if (IsNullOrEmpty(strCommentTypeId) == true)
{
  const strMsg = Format("参数:[strCommentTypeId]不能为空！(In GetObjByCommentTypeId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
if (strCommentTypeId.length != 2)
{
const strMsg = Format("缓存分类变量:[strCommentTypeId]的长度:[{0}]不正确！", strCommentTypeId.length);
console.error(strMsg);
throw (strMsg);
}
const strKey = Format("{0}_{1}", clsSysCommentTypeEN._CurrTabName, strCommentTypeId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objSysCommentType_Cache: clsSysCommentTypeEN = JSON.parse(strTempObj);
return objSysCommentType_Cache;
}
try
{
const objSysCommentType = await SysCommentType_GetObjByCommentTypeIdAsync(strCommentTypeId);
if (objSysCommentType != null)
{
localStorage.setItem(strKey, JSON.stringify(objSysCommentType));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objSysCommentType;
}
return objSysCommentType;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strCommentTypeId, sysCommentType_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objSysCommentType:所给的对象
 * @returns 对象
*/
export async function SysCommentType_UpdateObjInLst_Cache(objSysCommentType: clsSysCommentTypeEN) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrSysCommentTypeObjLst_Cache = await SysCommentType_GetObjLst_Cache();
const obj = arrSysCommentTypeObjLst_Cache.find(x => 
x.commentTypeId == objSysCommentType.commentTypeId);
if (obj != null)
{
objSysCommentType.commentTypeId = obj.commentTypeId;
ObjectAssign( obj, objSysCommentType);
}
else
{
arrSysCommentTypeObjLst_Cache.push(objSysCommentType);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, sysCommentType_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
}

/**
 * 根据关键字获取相关对象的名称属性, 从缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
 * @param strCommentTypeId:所给的关键字
 * @returns 对象
*/
export async function SysCommentType_GetNameByCommentTypeId_Cache(strCommentTypeId: string) {
const strThisFuncName = "GetNameByCommentTypeId_Cache";

if (IsNullOrEmpty(strCommentTypeId) == true)
{
  const strMsg = Format("参数:[strCommentTypeId]不能为空！(In GetNameByCommentTypeId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strCommentTypeId.length != 2)
{
const strMsg = Format("缓存分类变量:[strCommentTypeId]的长度:[{0}]不正确！", strCommentTypeId.length);
console.error(strMsg);
throw (strMsg);
}
const arrSysCommentTypeObjLst_Cache = await SysCommentType_GetObjLst_Cache();
if (arrSysCommentTypeObjLst_Cache == null) return "";
try
{
const arrSysCommentType_Sel: Array <clsSysCommentTypeEN> = arrSysCommentTypeObjLst_Cache.filter(x => x.commentTypeId == strCommentTypeId);
let objSysCommentType: clsSysCommentTypeEN;
if (arrSysCommentType_Sel.length > 0)
{
objSysCommentType = arrSysCommentType_Sel[0];
return objSysCommentType.commentTypeName;
}
else
{
return "";
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strCommentTypeId);
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
export async function SysCommentType_func(strInFldName:string , strOutFldName:string ,  strInValue: string) 
{
//const strThisFuncName = "func";

if (strInFldName != clsSysCommentTypeEN.con_CommentTypeId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsSysCommentTypeEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clsSysCommentTypeEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strCommentTypeId = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objSysCommentType = await SysCommentType_GetObjByCommentTypeId_Cache(strCommentTypeId );
if (objSysCommentType == null) return "";
return objSysCommentType.GetFldValue(strOutFldName).toString();
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
export function SysCommentType_SortFun_Defa(a:clsSysCommentTypeEN , b:clsSysCommentTypeEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.commentTypeId.localeCompare(b.commentTypeId);
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
export function SysCommentType_SortFun_Defa_2Fld(a:clsSysCommentTypeEN , b:clsSysCommentTypeEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.commentTypeName == b.commentTypeName) return a.commentTable.localeCompare(b.commentTable);
else return a.commentTypeName.localeCompare(b.commentTypeName);
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
export function SysCommentType_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsSysCommentTypeEN.con_CommentTypeId:
return (a: clsSysCommentTypeEN, b: clsSysCommentTypeEN) => {
return a.commentTypeId.localeCompare(b.commentTypeId);
}
case clsSysCommentTypeEN.con_CommentTypeName:
return (a: clsSysCommentTypeEN, b: clsSysCommentTypeEN) => {
return a.commentTypeName.localeCompare(b.commentTypeName);
}
case clsSysCommentTypeEN.con_CommentTable:
return (a: clsSysCommentTypeEN, b: clsSysCommentTypeEN) => {
return a.commentTable.localeCompare(b.commentTable);
}
case clsSysCommentTypeEN.con_CommentTableId:
return (a: clsSysCommentTypeEN, b: clsSysCommentTypeEN) => {
return a.commentTableId.localeCompare(b.commentTableId);
}
case clsSysCommentTypeEN.con_Memo:
return (a: clsSysCommentTypeEN, b: clsSysCommentTypeEN) => {
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[SysCommentType]中不存在！(in ${ sysCommentType_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsSysCommentTypeEN.con_CommentTypeId:
return (a: clsSysCommentTypeEN, b: clsSysCommentTypeEN) => {
return b.commentTypeId.localeCompare(a.commentTypeId);
}
case clsSysCommentTypeEN.con_CommentTypeName:
return (a: clsSysCommentTypeEN, b: clsSysCommentTypeEN) => {
return b.commentTypeName.localeCompare(a.commentTypeName);
}
case clsSysCommentTypeEN.con_CommentTable:
return (a: clsSysCommentTypeEN, b: clsSysCommentTypeEN) => {
return b.commentTable.localeCompare(a.commentTable);
}
case clsSysCommentTypeEN.con_CommentTableId:
return (a: clsSysCommentTypeEN, b: clsSysCommentTypeEN) => {
return b.commentTableId.localeCompare(a.commentTableId);
}
case clsSysCommentTypeEN.con_Memo:
return (a: clsSysCommentTypeEN, b: clsSysCommentTypeEN) => {
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[SysCommentType]中不存在！(in ${ sysCommentType_ConstructorName}.${ strThisFuncName})`;
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
export async function SysCommentType_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsSysCommentTypeEN.con_CommentTypeId:
return (obj: clsSysCommentTypeEN) => {
return obj.commentTypeId === value;
}
case clsSysCommentTypeEN.con_CommentTypeName:
return (obj: clsSysCommentTypeEN) => {
return obj.commentTypeName === value;
}
case clsSysCommentTypeEN.con_CommentTable:
return (obj: clsSysCommentTypeEN) => {
return obj.commentTable === value;
}
case clsSysCommentTypeEN.con_CommentTableId:
return (obj: clsSysCommentTypeEN) => {
return obj.commentTableId === value;
}
case clsSysCommentTypeEN.con_Memo:
return (obj: clsSysCommentTypeEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[SysCommentType]中不存在！(in ${ sysCommentType_ConstructorName}.${ strThisFuncName})`;
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
export async function SysCommentType_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(sysCommentType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysCommentType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysCommentType_ConstructorName, strThisFuncName);
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
export async function SysCommentType_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(sysCommentType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysCommentType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysCommentType_ConstructorName, strThisFuncName);
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
export async function SysCommentType_GetFirstObjAsync(strWhereCond: string): Promise<clsSysCommentTypeEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(sysCommentType_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sysCommentType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objSysCommentType = SysCommentType_GetObjFromJsonObj(returnObj);
return objSysCommentType;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysCommentType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysCommentType_ConstructorName, strThisFuncName);
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
export async function SysCommentType_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsSysCommentTypeEN._CurrTabName;
clsSysCommentTypeEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsSysCommentTypeEN._CurrTabName);
if (IsNullOrEmpty(clsSysCommentTypeEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsSysCommentTypeEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrSysCommentTypeExObjLst_Cache: Array<clsSysCommentTypeEN> = CacheHelper.Get(strKey);
const arrSysCommentTypeObjLst_T = SysCommentType_GetObjLstByJSONObjLst(arrSysCommentTypeExObjLst_Cache);
return arrSysCommentTypeObjLst_T;
}
try
{
const arrSysCommentTypeExObjLst = await SysCommentType_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrSysCommentTypeExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrSysCommentTypeExObjLst.length);
console.log(strInfo);
return arrSysCommentTypeExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, sysCommentType_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function SysCommentType_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsSysCommentTypeEN._CurrTabName;
clsSysCommentTypeEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsSysCommentTypeEN._CurrTabName);
if (IsNullOrEmpty(clsSysCommentTypeEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsSysCommentTypeEN.CacheAddiCondition);
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
const arrSysCommentTypeExObjLst_Cache: Array<clsSysCommentTypeEN> = JSON.parse(strTempObjLst);
const arrSysCommentTypeObjLst_T = SysCommentType_GetObjLstByJSONObjLst(arrSysCommentTypeExObjLst_Cache);
return arrSysCommentTypeObjLst_T;
}
try
{
const arrSysCommentTypeExObjLst = await SysCommentType_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrSysCommentTypeExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrSysCommentTypeExObjLst.length);
console.log(strInfo);
return arrSysCommentTypeExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, sysCommentType_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function SysCommentType_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsSysCommentTypeEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrSysCommentTypeObjLst_Cache: Array<clsSysCommentTypeEN> = JSON.parse(strTempObjLst);
return arrSysCommentTypeObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function SysCommentType_GetObjLstAsync(strWhereCond: string): Promise<Array<clsSysCommentTypeEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(sysCommentType_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sysCommentType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = SysCommentType_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysCommentType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysCommentType_ConstructorName, strThisFuncName);
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
export async function SysCommentType_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsSysCommentTypeEN._CurrTabName;
clsSysCommentTypeEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsSysCommentTypeEN._CurrTabName);
if (IsNullOrEmpty(clsSysCommentTypeEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsSysCommentTypeEN.CacheAddiCondition);
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
const arrSysCommentTypeExObjLst_Cache: Array<clsSysCommentTypeEN> = JSON.parse(strTempObjLst);
const arrSysCommentTypeObjLst_T = SysCommentType_GetObjLstByJSONObjLst(arrSysCommentTypeExObjLst_Cache);
return arrSysCommentTypeObjLst_T;
}
try
{
const arrSysCommentTypeExObjLst = await SysCommentType_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrSysCommentTypeExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrSysCommentTypeExObjLst.length);
console.log(strInfo);
return arrSysCommentTypeExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, sysCommentType_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function SysCommentType_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsSysCommentTypeEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrSysCommentTypeObjLst_Cache: Array<clsSysCommentTypeEN> = JSON.parse(strTempObjLst);
return arrSysCommentTypeObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function SysCommentType_GetObjLst_Cache(): Promise<Array<clsSysCommentTypeEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrSysCommentTypeObjLst_Cache;
switch (clsSysCommentTypeEN.CacheModeId)
{
case "04"://sessionStorage
arrSysCommentTypeObjLst_Cache = await SysCommentType_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrSysCommentTypeObjLst_Cache = await SysCommentType_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrSysCommentTypeObjLst_Cache = await SysCommentType_GetObjLst_ClientCache();
break;
default:
arrSysCommentTypeObjLst_Cache = await SysCommentType_GetObjLst_ClientCache();
break;
}
const arrSysCommentTypeObjLst = SysCommentType_GetObjLstByJSONObjLst(arrSysCommentTypeObjLst_Cache);
return arrSysCommentTypeObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function SysCommentType_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrSysCommentTypeObjLst_Cache;
switch (clsSysCommentTypeEN.CacheModeId)
{
case "04"://sessionStorage
arrSysCommentTypeObjLst_Cache = await SysCommentType_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrSysCommentTypeObjLst_Cache = await SysCommentType_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrSysCommentTypeObjLst_Cache = null;
break;
default:
arrSysCommentTypeObjLst_Cache = null;
break;
}
return arrSysCommentTypeObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrCommentTypeId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function SysCommentType_GetSubObjLst_Cache(objSysCommentType_Cond: clsSysCommentTypeEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrSysCommentTypeObjLst_Cache = await SysCommentType_GetObjLst_Cache();
let arrSysCommentType_Sel: Array < clsSysCommentTypeEN > = arrSysCommentTypeObjLst_Cache;
if (objSysCommentType_Cond.sf_FldComparisonOp == null || objSysCommentType_Cond.sf_FldComparisonOp == "") return arrSysCommentType_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objSysCommentType_Cond.sf_FldComparisonOp);
//console.log("clsSysCommentTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objSysCommentType_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrSysCommentType_Sel = arrSysCommentType_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objSysCommentType_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrSysCommentType_Sel = arrSysCommentType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrSysCommentType_Sel = arrSysCommentType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrSysCommentType_Sel = arrSysCommentType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrSysCommentType_Sel = arrSysCommentType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrSysCommentType_Sel = arrSysCommentType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrSysCommentType_Sel = arrSysCommentType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrSysCommentType_Sel = arrSysCommentType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrSysCommentType_Sel = arrSysCommentType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrSysCommentType_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objSysCommentType_Cond), sysCommentType_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsSysCommentTypeEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrCommentTypeId:关键字列表
 * @returns 对象列表
 **/
export async function SysCommentType_GetObjLstByCommentTypeIdLstAsync(arrCommentTypeId: Array<string>): Promise<Array<clsSysCommentTypeEN>>  
{
const strThisFuncName = "GetObjLstByCommentTypeIdLstAsync";
const strAction = "GetObjLstByCommentTypeIdLst";
const strUrl = GetWebApiUrl(sysCommentType_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrCommentTypeId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sysCommentType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = SysCommentType_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysCommentType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysCommentType_ConstructorName, strThisFuncName);
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
 * @param arrstrCommentTypeIdLst:关键字列表
 * @returns 对象列表
*/
export async function SysCommentType_GetObjLstByCommentTypeIdLst_Cache(arrCommentTypeIdLst: Array<string>) {
const strThisFuncName = "GetObjLstByCommentTypeIdLst_Cache";
try
{
const arrSysCommentTypeObjLst_Cache = await SysCommentType_GetObjLst_Cache();
const arrSysCommentType_Sel: Array <clsSysCommentTypeEN> = arrSysCommentTypeObjLst_Cache.filter(x => arrCommentTypeIdLst.indexOf(x.commentTypeId)>-1);
return arrSysCommentType_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrCommentTypeIdLst.join(","), sysCommentType_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsSysCommentTypeEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function SysCommentType_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsSysCommentTypeEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(sysCommentType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sysCommentType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = SysCommentType_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysCommentType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysCommentType_ConstructorName, strThisFuncName);
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
export async function SysCommentType_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsSysCommentTypeEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(sysCommentType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sysCommentType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = SysCommentType_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysCommentType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysCommentType_ConstructorName, strThisFuncName);
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
export async function SysCommentType_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(sysCommentType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysCommentType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysCommentType_ConstructorName, strThisFuncName);
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
export async function SysCommentType_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrSysCommentTypeObjLst_Cache = await SysCommentType_GetObjLst_Cache();
if (arrSysCommentTypeObjLst_Cache.length == 0) return arrSysCommentTypeObjLst_Cache;
let arrSysCommentType_Sel = arrSysCommentTypeObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objSysCommentType_Cond = new clsSysCommentTypeEN();
ObjectAssign(objSysCommentType_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsSysCommentTypeWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrSysCommentType_Sel = arrSysCommentType_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objSysCommentType_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrSysCommentType_Sel = arrSysCommentType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrSysCommentType_Sel = arrSysCommentType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrSysCommentType_Sel = arrSysCommentType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrSysCommentType_Sel = arrSysCommentType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrSysCommentType_Sel = arrSysCommentType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrSysCommentType_Sel = arrSysCommentType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrSysCommentType_Sel = arrSysCommentType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrSysCommentType_Sel = arrSysCommentType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrSysCommentType_Sel = arrSysCommentType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrSysCommentType_Sel.length == 0) return arrSysCommentType_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrSysCommentType_Sel = arrSysCommentType_Sel.sort(SysCommentType_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrSysCommentType_Sel = arrSysCommentType_Sel.sort(objPagerPara.sortFun);
}
arrSysCommentType_Sel = arrSysCommentType_Sel.slice(intStart, intEnd);     
return arrSysCommentType_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, sysCommentType_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsSysCommentTypeEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function SysCommentType_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsSysCommentTypeEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(sysCommentType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sysCommentType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = SysCommentType_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysCommentType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysCommentType_ConstructorName, strThisFuncName);
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
 * @param strCommentTypeId:关键字
 * @returns 获取删除的结果
 **/
export async function SysCommentType_DelRecordAsync(strCommentTypeId: string): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(sysCommentType_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, strCommentTypeId);
try
{
const response = await axios.delete(strUrl,
{
params: { "Id": strCommentTypeId, }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysCommentType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysCommentType_ConstructorName, strThisFuncName);
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
 * @param arrCommentTypeId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function SysCommentType_DelSysCommentTypesAsync(arrCommentTypeId: Array<string>): Promise<number> 
{
const strThisFuncName = "DelSysCommentTypesAsync";
const strAction = "DelSysCommentTypes";
const strUrl = GetWebApiUrl(sysCommentType_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrCommentTypeId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysCommentType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysCommentType_ConstructorName, strThisFuncName);
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
export async function SysCommentType_DelSysCommentTypesByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "DelSysCommentTypesByCondAsync";
const strAction = "DelSysCommentTypesByCond";
const strUrl = GetWebApiUrl(sysCommentType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysCommentType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysCommentType_ConstructorName, strThisFuncName);
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
 * @param objSysCommentTypeEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function SysCommentType_AddNewRecordAsync(objSysCommentTypeEN: clsSysCommentTypeEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
if (objSysCommentTypeEN.commentTypeId === null || objSysCommentTypeEN.commentTypeId === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objSysCommentTypeEN);
const strUrl = GetWebApiUrl(sysCommentType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSysCommentTypeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysCommentType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysCommentType_ConstructorName, strThisFuncName);
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
 * @param objSysCommentTypeEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function SysCommentType_AddNewRecordWithMaxIdAsync(objSysCommentTypeEN: clsSysCommentTypeEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithMaxIdAsync";
const strAction = "AddNewRecordWithMaxId";
const strUrl = GetWebApiUrl(sysCommentType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSysCommentTypeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysCommentType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysCommentType_ConstructorName, strThisFuncName);
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
 * @param objSysCommentTypeEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function SysCommentType_AddNewRecordWithReturnKeyAsync(objSysCommentTypeEN: clsSysCommentTypeEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(sysCommentType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSysCommentTypeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysCommentType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysCommentType_ConstructorName, strThisFuncName);
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
 * @param objSysCommentTypeEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function SysCommentType_AddNewRecordWithReturnKey(objSysCommentTypeEN: clsSysCommentTypeEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objSysCommentTypeEN.commentTypeId === null || objSysCommentTypeEN.commentTypeId === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(sysCommentType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSysCommentTypeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysCommentType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysCommentType_ConstructorName, strThisFuncName);
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
 * @param objSysCommentTypeEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function SysCommentType_UpdateRecordAsync(objSysCommentTypeEN: clsSysCommentTypeEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objSysCommentTypeEN.sf_UpdFldSetStr === undefined || objSysCommentTypeEN.sf_UpdFldSetStr === null || objSysCommentTypeEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objSysCommentTypeEN.commentTypeId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(sysCommentType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSysCommentTypeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysCommentType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysCommentType_ConstructorName, strThisFuncName);
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
 * @param objSysCommentTypeEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function SysCommentType_UpdateWithConditionAsync(objSysCommentTypeEN: clsSysCommentTypeEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objSysCommentTypeEN.sf_UpdFldSetStr === undefined || objSysCommentTypeEN.sf_UpdFldSetStr === null || objSysCommentTypeEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objSysCommentTypeEN.commentTypeId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(sysCommentType_Controller, strAction);
objSysCommentTypeEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objSysCommentTypeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysCommentType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysCommentType_ConstructorName, strThisFuncName);
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
 * @param objstrCommentTypeId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function SysCommentType_IsExistRecord_Cache(objSysCommentType_Cond: clsSysCommentTypeEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrSysCommentTypeObjLst_Cache = await SysCommentType_GetObjLst_Cache();
if (arrSysCommentTypeObjLst_Cache == null) return false;
let arrSysCommentType_Sel: Array < clsSysCommentTypeEN > = arrSysCommentTypeObjLst_Cache;
if (objSysCommentType_Cond.sf_FldComparisonOp == null || objSysCommentType_Cond.sf_FldComparisonOp == "") return arrSysCommentType_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objSysCommentType_Cond.sf_FldComparisonOp);
//console.log("clsSysCommentTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objSysCommentType_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objSysCommentType_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrSysCommentType_Sel = arrSysCommentType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrSysCommentType_Sel = arrSysCommentType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrSysCommentType_Sel = arrSysCommentType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrSysCommentType_Sel = arrSysCommentType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrSysCommentType_Sel = arrSysCommentType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrSysCommentType_Sel = arrSysCommentType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrSysCommentType_Sel = arrSysCommentType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrSysCommentType_Sel = arrSysCommentType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrSysCommentType_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objSysCommentType_Cond), sysCommentType_ConstructorName, strThisFuncName);
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
export async function SysCommentType_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(sysCommentType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysCommentType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysCommentType_ConstructorName, strThisFuncName);
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
 * @param strCommentTypeId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function SysCommentType_IsExist(strCommentTypeId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(sysCommentType_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"CommentTypeId": strCommentTypeId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysCommentType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysCommentType_ConstructorName, strThisFuncName);
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
 * @param strCommentTypeId:所给的关键字
 * @returns 对象
*/
export async function SysCommentType_IsExist_Cache(strCommentTypeId:string) {
const strThisFuncName = "IsExist_Cache";
const arrSysCommentTypeObjLst_Cache = await SysCommentType_GetObjLst_Cache();
if (arrSysCommentTypeObjLst_Cache == null) return false;
try
{
const arrSysCommentType_Sel: Array <clsSysCommentTypeEN> = arrSysCommentTypeObjLst_Cache.filter(x => x.commentTypeId == strCommentTypeId);
if (arrSysCommentType_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strCommentTypeId, sysCommentType_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param strCommentTypeId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function SysCommentType_IsExistAsync(strCommentTypeId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(sysCommentType_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strCommentTypeId": strCommentTypeId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysCommentType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysCommentType_ConstructorName, strThisFuncName);
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
export async function SysCommentType_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(sysCommentType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysCommentType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysCommentType_ConstructorName, strThisFuncName);
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
 * @param objSysCommentType_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function SysCommentType_GetRecCountByCond_Cache(objSysCommentType_Cond: clsSysCommentTypeEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrSysCommentTypeObjLst_Cache = await SysCommentType_GetObjLst_Cache();
if (arrSysCommentTypeObjLst_Cache == null) return 0;
let arrSysCommentType_Sel: Array < clsSysCommentTypeEN > = arrSysCommentTypeObjLst_Cache;
if (objSysCommentType_Cond.sf_FldComparisonOp == null || objSysCommentType_Cond.sf_FldComparisonOp == "") return arrSysCommentType_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objSysCommentType_Cond.sf_FldComparisonOp);
//console.log("clsSysCommentTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objSysCommentType_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrSysCommentType_Sel = arrSysCommentType_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objSysCommentType_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrSysCommentType_Sel = arrSysCommentType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrSysCommentType_Sel = arrSysCommentType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrSysCommentType_Sel = arrSysCommentType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrSysCommentType_Sel = arrSysCommentType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrSysCommentType_Sel = arrSysCommentType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrSysCommentType_Sel = arrSysCommentType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrSysCommentType_Sel = arrSysCommentType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrSysCommentType_Sel = arrSysCommentType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrSysCommentType_Sel = arrSysCommentType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrSysCommentType_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objSysCommentType_Cond), sysCommentType_ConstructorName, strThisFuncName);
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
export async function SysCommentType_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(sysCommentType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysCommentType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysCommentType_ConstructorName, strThisFuncName);
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
export function SysCommentType_GetWebApiUrl(strController: string, strAction: string): string {
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
export function SysCommentType_ReFreshCache():void
{
const strThisFuncName = "ReFreshCache";

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = clsSysCommentTypeEN._CurrTabName;
switch (clsSysCommentTypeEN.CacheModeId)
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
export function SysCommentType_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clsSysCommentTypeEN._CurrTabName;
switch (clsSysCommentTypeEN.CacheModeId)
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
export async function SysCommentType__Cache(strDivName: string, strDdlName: string )
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
const arrObjLst_Sel = await SysCommentType_GetObjLst_Cache();
if (arrObjLst_Sel == null) return;
BindDdl_ObjLstInDiv(strDivName, strDdlName, arrObjLst_Sel, clsSysCommentTypeEN.con_CommentTypeId, clsSysCommentTypeEN.con_CommentTypeName, "评论类型表");
}

/**
 * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function SysCommentType_CheckPropertyNew(pobjSysCommentTypeEN: clsSysCommentTypeEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjSysCommentTypeEN.commentTypeId) == false && GetStrLen(pobjSysCommentTypeEN.commentTypeId) > 2)
{
 throw new Error("(errid:Watl000059)字段[评论类型Id(commentTypeId)]的长度不能超过2(In 评论类型表(SysCommentType))!值:$(pobjSysCommentTypeEN.commentTypeId)(clsSysCommentTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysCommentTypeEN.commentTypeName) == false && GetStrLen(pobjSysCommentTypeEN.commentTypeName) > 50)
{
 throw new Error("(errid:Watl000059)字段[评论类型名(commentTypeName)]的长度不能超过50(In 评论类型表(SysCommentType))!值:$(pobjSysCommentTypeEN.commentTypeName)(clsSysCommentTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysCommentTypeEN.commentTable) == false && GetStrLen(pobjSysCommentTypeEN.commentTable) > 50)
{
 throw new Error("(errid:Watl000059)字段[评论表(commentTable)]的长度不能超过50(In 评论类型表(SysCommentType))!值:$(pobjSysCommentTypeEN.commentTable)(clsSysCommentTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysCommentTypeEN.commentTableId) == false && GetStrLen(pobjSysCommentTypeEN.commentTableId) > 50)
{
 throw new Error("(errid:Watl000059)字段[评论表Id(commentTableId)]的长度不能超过50(In 评论类型表(SysCommentType))!值:$(pobjSysCommentTypeEN.commentTableId)(clsSysCommentTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysCommentTypeEN.memo) == false && GetStrLen(pobjSysCommentTypeEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 评论类型表(SysCommentType))!值:$(pobjSysCommentTypeEN.memo)(clsSysCommentTypeBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjSysCommentTypeEN.commentTypeId) == false && undefined !== pobjSysCommentTypeEN.commentTypeId && tzDataType.isString(pobjSysCommentTypeEN.commentTypeId) === false)
{
 throw new Error("(errid:Watl000060)字段[评论类型Id(commentTypeId)]的值:[$(pobjSysCommentTypeEN.commentTypeId)], 非法，应该为字符型(In 评论类型表(SysCommentType))!(clsSysCommentTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysCommentTypeEN.commentTypeName) == false && undefined !== pobjSysCommentTypeEN.commentTypeName && tzDataType.isString(pobjSysCommentTypeEN.commentTypeName) === false)
{
 throw new Error("(errid:Watl000060)字段[评论类型名(commentTypeName)]的值:[$(pobjSysCommentTypeEN.commentTypeName)], 非法，应该为字符型(In 评论类型表(SysCommentType))!(clsSysCommentTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysCommentTypeEN.commentTable) == false && undefined !== pobjSysCommentTypeEN.commentTable && tzDataType.isString(pobjSysCommentTypeEN.commentTable) === false)
{
 throw new Error("(errid:Watl000060)字段[评论表(commentTable)]的值:[$(pobjSysCommentTypeEN.commentTable)], 非法，应该为字符型(In 评论类型表(SysCommentType))!(clsSysCommentTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysCommentTypeEN.commentTableId) == false && undefined !== pobjSysCommentTypeEN.commentTableId && tzDataType.isString(pobjSysCommentTypeEN.commentTableId) === false)
{
 throw new Error("(errid:Watl000060)字段[评论表Id(commentTableId)]的值:[$(pobjSysCommentTypeEN.commentTableId)], 非法，应该为字符型(In 评论类型表(SysCommentType))!(clsSysCommentTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysCommentTypeEN.memo) == false && undefined !== pobjSysCommentTypeEN.memo && tzDataType.isString(pobjSysCommentTypeEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjSysCommentTypeEN.memo)], 非法，应该为字符型(In 评论类型表(SysCommentType))!(clsSysCommentTypeBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjSysCommentTypeEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function SysCommentType_CheckProperty4Update (pobjSysCommentTypeEN: clsSysCommentTypeEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjSysCommentTypeEN.commentTypeId) == false && GetStrLen(pobjSysCommentTypeEN.commentTypeId) > 2)
{
 throw new Error("(errid:Watl000062)字段[评论类型Id(commentTypeId)]的长度不能超过2(In 评论类型表(SysCommentType))!值:$(pobjSysCommentTypeEN.commentTypeId)(clsSysCommentTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysCommentTypeEN.commentTypeName) == false && GetStrLen(pobjSysCommentTypeEN.commentTypeName) > 50)
{
 throw new Error("(errid:Watl000062)字段[评论类型名(commentTypeName)]的长度不能超过50(In 评论类型表(SysCommentType))!值:$(pobjSysCommentTypeEN.commentTypeName)(clsSysCommentTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysCommentTypeEN.commentTable) == false && GetStrLen(pobjSysCommentTypeEN.commentTable) > 50)
{
 throw new Error("(errid:Watl000062)字段[评论表(commentTable)]的长度不能超过50(In 评论类型表(SysCommentType))!值:$(pobjSysCommentTypeEN.commentTable)(clsSysCommentTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysCommentTypeEN.commentTableId) == false && GetStrLen(pobjSysCommentTypeEN.commentTableId) > 50)
{
 throw new Error("(errid:Watl000062)字段[评论表Id(commentTableId)]的长度不能超过50(In 评论类型表(SysCommentType))!值:$(pobjSysCommentTypeEN.commentTableId)(clsSysCommentTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysCommentTypeEN.memo) == false && GetStrLen(pobjSysCommentTypeEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 评论类型表(SysCommentType))!值:$(pobjSysCommentTypeEN.memo)(clsSysCommentTypeBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjSysCommentTypeEN.commentTypeId) == false && undefined !== pobjSysCommentTypeEN.commentTypeId && tzDataType.isString(pobjSysCommentTypeEN.commentTypeId) === false)
{
 throw new Error("(errid:Watl000063)字段[评论类型Id(commentTypeId)]的值:[$(pobjSysCommentTypeEN.commentTypeId)], 非法，应该为字符型(In 评论类型表(SysCommentType))!(clsSysCommentTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysCommentTypeEN.commentTypeName) == false && undefined !== pobjSysCommentTypeEN.commentTypeName && tzDataType.isString(pobjSysCommentTypeEN.commentTypeName) === false)
{
 throw new Error("(errid:Watl000063)字段[评论类型名(commentTypeName)]的值:[$(pobjSysCommentTypeEN.commentTypeName)], 非法，应该为字符型(In 评论类型表(SysCommentType))!(clsSysCommentTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysCommentTypeEN.commentTable) == false && undefined !== pobjSysCommentTypeEN.commentTable && tzDataType.isString(pobjSysCommentTypeEN.commentTable) === false)
{
 throw new Error("(errid:Watl000063)字段[评论表(commentTable)]的值:[$(pobjSysCommentTypeEN.commentTable)], 非法，应该为字符型(In 评论类型表(SysCommentType))!(clsSysCommentTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysCommentTypeEN.commentTableId) == false && undefined !== pobjSysCommentTypeEN.commentTableId && tzDataType.isString(pobjSysCommentTypeEN.commentTableId) === false)
{
 throw new Error("(errid:Watl000063)字段[评论表Id(commentTableId)]的值:[$(pobjSysCommentTypeEN.commentTableId)], 非法，应该为字符型(In 评论类型表(SysCommentType))!(clsSysCommentTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysCommentTypeEN.memo) == false && undefined !== pobjSysCommentTypeEN.memo && tzDataType.isString(pobjSysCommentTypeEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjSysCommentTypeEN.memo)], 非法，应该为字符型(In 评论类型表(SysCommentType))!(clsSysCommentTypeBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (IsNullOrEmpty(pobjSysCommentTypeEN.commentTypeId) === true )
{
 throw new Error("(errid:Watl000064)字段[评论类型Id]不能为空(In 评论类型表)!(clsSysCommentTypeBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjSysCommentTypeEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function SysCommentType_GetJSONStrByObj (pobjSysCommentTypeEN: clsSysCommentTypeEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjSysCommentTypeEN.sf_UpdFldSetStr = pobjSysCommentTypeEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjSysCommentTypeEN);
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
export function SysCommentType_GetObjLstByJSONStr (strJSON: string): Array<clsSysCommentTypeEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrSysCommentTypeObjLst = new Array<clsSysCommentTypeEN>();
if (strJSON === "")
{
return arrSysCommentTypeObjLst;
}
try
{
arrSysCommentTypeObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrSysCommentTypeObjLst;
}
return arrSysCommentTypeObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrSysCommentTypeObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function SysCommentType_GetObjLstByJSONObjLst (arrSysCommentTypeObjLstS: Array<clsSysCommentTypeEN>): Array<clsSysCommentTypeEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrSysCommentTypeObjLst = new Array<clsSysCommentTypeEN>();
for (const objInFor of arrSysCommentTypeObjLstS) {
const obj1 = SysCommentType_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrSysCommentTypeObjLst.push(obj1);
}
return arrSysCommentTypeObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function SysCommentType_GetObjByJSONStr (strJSON: string): clsSysCommentTypeEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjSysCommentTypeEN = new clsSysCommentTypeEN();
if (strJSON === "")
{
return pobjSysCommentTypeEN;
}
try
{
pobjSysCommentTypeEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjSysCommentTypeEN;
}
return pobjSysCommentTypeEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function SysCommentType_GetCombineCondition(objSysCommentType_Cond: clsSysCommentTypeEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objSysCommentType_Cond.dicFldComparisonOp, clsSysCommentTypeEN.con_CommentTypeId) == true)
{
const strComparisonOp_CommentTypeId:string = objSysCommentType_Cond.dicFldComparisonOp[clsSysCommentTypeEN.con_CommentTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysCommentTypeEN.con_CommentTypeId, objSysCommentType_Cond.commentTypeId, strComparisonOp_CommentTypeId);
}
if (Object.prototype.hasOwnProperty.call(objSysCommentType_Cond.dicFldComparisonOp, clsSysCommentTypeEN.con_CommentTypeName) == true)
{
const strComparisonOp_CommentTypeName:string = objSysCommentType_Cond.dicFldComparisonOp[clsSysCommentTypeEN.con_CommentTypeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysCommentTypeEN.con_CommentTypeName, objSysCommentType_Cond.commentTypeName, strComparisonOp_CommentTypeName);
}
if (Object.prototype.hasOwnProperty.call(objSysCommentType_Cond.dicFldComparisonOp, clsSysCommentTypeEN.con_CommentTable) == true)
{
const strComparisonOp_CommentTable:string = objSysCommentType_Cond.dicFldComparisonOp[clsSysCommentTypeEN.con_CommentTable];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysCommentTypeEN.con_CommentTable, objSysCommentType_Cond.commentTable, strComparisonOp_CommentTable);
}
if (Object.prototype.hasOwnProperty.call(objSysCommentType_Cond.dicFldComparisonOp, clsSysCommentTypeEN.con_CommentTableId) == true)
{
const strComparisonOp_CommentTableId:string = objSysCommentType_Cond.dicFldComparisonOp[clsSysCommentTypeEN.con_CommentTableId];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysCommentTypeEN.con_CommentTableId, objSysCommentType_Cond.commentTableId, strComparisonOp_CommentTableId);
}
if (Object.prototype.hasOwnProperty.call(objSysCommentType_Cond.dicFldComparisonOp, clsSysCommentTypeEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objSysCommentType_Cond.dicFldComparisonOp[clsSysCommentTypeEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysCommentTypeEN.con_Memo, objSysCommentType_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objSysCommentTypeENS:源对象
 * @param objSysCommentTypeENT:目标对象
*/
export function SysCommentType_CopyObjTo(objSysCommentTypeENS: clsSysCommentTypeEN , objSysCommentTypeENT: clsSysCommentTypeEN ): void 
{
objSysCommentTypeENT.commentTypeId = objSysCommentTypeENS.commentTypeId; //评论类型Id
objSysCommentTypeENT.commentTypeName = objSysCommentTypeENS.commentTypeName; //评论类型名
objSysCommentTypeENT.commentTable = objSysCommentTypeENS.commentTable; //评论表
objSysCommentTypeENT.commentTableId = objSysCommentTypeENS.commentTableId; //评论表Id
objSysCommentTypeENT.memo = objSysCommentTypeENS.memo; //备注
objSysCommentTypeENT.sf_UpdFldSetStr = objSysCommentTypeENS.updFldString; //sf_UpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objSysCommentTypeENS:源对象
 * @param objSysCommentTypeENT:目标对象
*/
export function SysCommentType_GetObjFromJsonObj(objSysCommentTypeENS: clsSysCommentTypeEN): clsSysCommentTypeEN 
{
 const objSysCommentTypeENT: clsSysCommentTypeEN = new clsSysCommentTypeEN();
ObjectAssign(objSysCommentTypeENT, objSysCommentTypeENS);
 return objSysCommentTypeENT;
}