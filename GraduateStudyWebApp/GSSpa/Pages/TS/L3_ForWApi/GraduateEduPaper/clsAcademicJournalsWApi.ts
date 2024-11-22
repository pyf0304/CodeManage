﻿
 /**
 * 类名:clsAcademicJournalsWApi
 * 表名:AcademicJournals(01120929)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:46:38
 * 生成者:pyf
 * 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:研培论文(GraduateEduPaper)
 * 框架-层名:WA_访问层(TS)(WA_Access)
 * 编程语言:TypeScript
 * 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
   *      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 **/

/**
 * 学术期刊(AcademicJournals)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clsAcademicJournalsEN } from "../../L0_Entity/GraduateEduPaper/clsAcademicJournalsEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { tzDataType } from "../../PubFun/jsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const academicJournals_Controller = "AcademicJournalsApi";
 export const academicJournals_ConstructorName = "academicJournals";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strJournalId:关键字
 * @returns 对象
 **/
export async function AcademicJournals_GetObjByJournalIdAsync(strJournalId: string): Promise<clsAcademicJournalsEN>  
{
const strThisFuncName = "GetObjByJournalIdAsync";

if (IsNullOrEmpty(strJournalId) == true)
{
  const strMsg = Format("参数:[strJournalId]不能为空！(In GetObjByJournalIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strJournalId.length != 4)
{
const strMsg = Format("缓存分类变量:[strJournalId]的长度:[{0}]不正确！", strJournalId.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByJournalId";
const strUrl = GetWebApiUrl(academicJournals_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strJournalId": strJournalId,
}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObj = data.returnObj;
if (returnObj == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", academicJournals_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objAcademicJournals = AcademicJournals_GetObjFromJsonObj(returnObj);
return objAcademicJournals;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, academicJournals_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, academicJournals_ConstructorName, strThisFuncName);
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
 * @param strJournalId:所给的关键字
 * @returns 对象
*/
export async function AcademicJournals_GetObjByJournalId_Cache(strJournalId: string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByJournalId_Cache";

if (IsNullOrEmpty(strJournalId) == true)
{
  const strMsg = Format("参数:[strJournalId]不能为空！(In GetObjByJournalId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strJournalId.length != 4)
{
const strMsg = Format("缓存分类变量:[strJournalId]的长度:[{0}]不正确！", strJournalId.length);
console.error(strMsg);
throw (strMsg);
}
const arrAcademicJournalsObjLst_Cache = await AcademicJournals_GetObjLst_Cache();
try
{
const arrAcademicJournals_Sel: Array <clsAcademicJournalsEN> = arrAcademicJournalsObjLst_Cache.filter(x => x.journalId == strJournalId);
let objAcademicJournals: clsAcademicJournalsEN;
if (arrAcademicJournals_Sel.length > 0)
{
objAcademicJournals = arrAcademicJournals_Sel[0];
return objAcademicJournals;
}
else
{
if (bolTryAsyncOnce == true)
{
objAcademicJournals = await AcademicJournals_GetObjByJournalIdAsync(strJournalId);
if (objAcademicJournals != null)
{
AcademicJournals_ReFreshThisCache();
return objAcademicJournals;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strJournalId, academicJournals_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param strJournalId:所给的关键字
 * @returns 对象
*/
export async function AcademicJournals_GetObjByJournalId_localStorage(strJournalId: string) {
const strThisFuncName = "GetObjByJournalId_localStorage";

if (IsNullOrEmpty(strJournalId) == true)
{
  const strMsg = Format("参数:[strJournalId]不能为空！(In GetObjByJournalId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
if (strJournalId.length != 4)
{
const strMsg = Format("缓存分类变量:[strJournalId]的长度:[{0}]不正确！", strJournalId.length);
console.error(strMsg);
throw (strMsg);
}
const strKey = Format("{0}_{1}", clsAcademicJournalsEN._CurrTabName, strJournalId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objAcademicJournals_Cache: clsAcademicJournalsEN = JSON.parse(strTempObj);
return objAcademicJournals_Cache;
}
try
{
const objAcademicJournals = await AcademicJournals_GetObjByJournalIdAsync(strJournalId);
if (objAcademicJournals != null)
{
localStorage.setItem(strKey, JSON.stringify(objAcademicJournals));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objAcademicJournals;
}
return objAcademicJournals;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strJournalId, academicJournals_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objAcademicJournals:所给的对象
 * @returns 对象
*/
export async function AcademicJournals_UpdateObjInLst_Cache(objAcademicJournals: clsAcademicJournalsEN) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrAcademicJournalsObjLst_Cache = await AcademicJournals_GetObjLst_Cache();
const obj = arrAcademicJournalsObjLst_Cache.find(x => x.journalName == objAcademicJournals.journalName);
if (obj != null)
{
objAcademicJournals.journalId = obj.journalId;
ObjectAssign( obj, objAcademicJournals);
}
else
{
arrAcademicJournalsObjLst_Cache.push(objAcademicJournals);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, academicJournals_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
}

/**
 * 根据关键字获取相关对象的名称属性, 从缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
 * @param strJournalId:所给的关键字
 * @returns 对象
*/
export async function AcademicJournals_GetNameByJournalId_Cache(strJournalId: string) {
const strThisFuncName = "GetNameByJournalId_Cache";

if (IsNullOrEmpty(strJournalId) == true)
{
  const strMsg = Format("参数:[strJournalId]不能为空！(In GetNameByJournalId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strJournalId.length != 4)
{
const strMsg = Format("缓存分类变量:[strJournalId]的长度:[{0}]不正确！", strJournalId.length);
console.error(strMsg);
throw (strMsg);
}
const arrAcademicJournalsObjLst_Cache = await AcademicJournals_GetObjLst_Cache();
if (arrAcademicJournalsObjLst_Cache == null) return "";
try
{
const arrAcademicJournals_Sel: Array <clsAcademicJournalsEN> = arrAcademicJournalsObjLst_Cache.filter(x => x.journalId == strJournalId);
let objAcademicJournals: clsAcademicJournalsEN;
if (arrAcademicJournals_Sel.length > 0)
{
objAcademicJournals = arrAcademicJournals_Sel[0];
return objAcademicJournals.journalName;
}
else
{
return "";
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strJournalId);
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
export async function AcademicJournals_func(strInFldName:string , strOutFldName:string ,  strInValue: string) 
{
//const strThisFuncName = "func";

if (strInFldName != clsAcademicJournalsEN.con_JournalId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsAcademicJournalsEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clsAcademicJournalsEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strJournalId = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objAcademicJournals = await AcademicJournals_GetObjByJournalId_Cache(strJournalId );
if (objAcademicJournals == null) return "";
return objAcademicJournals.GetFldValue(strOutFldName).toString();
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
export function AcademicJournals_SortFun_Defa(a:clsAcademicJournalsEN , b:clsAcademicJournalsEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.journalId.localeCompare(b.journalId);
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
export function AcademicJournals_SortFun_Defa_2Fld(a:clsAcademicJournalsEN , b:clsAcademicJournalsEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.journalName == b.journalName) return a.journalSubjectCategoryId.localeCompare(b.journalSubjectCategoryId);
else return a.journalName.localeCompare(b.journalName);
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
export function AcademicJournals_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsAcademicJournalsEN.con_JournalId:
return (a: clsAcademicJournalsEN, b: clsAcademicJournalsEN) => {
return a.journalId.localeCompare(b.journalId);
}
case clsAcademicJournalsEN.con_JournalName:
return (a: clsAcademicJournalsEN, b: clsAcademicJournalsEN) => {
return a.journalName.localeCompare(b.journalName);
}
case clsAcademicJournalsEN.con_JournalSubjectCategoryId:
return (a: clsAcademicJournalsEN, b: clsAcademicJournalsEN) => {
return a.journalSubjectCategoryId.localeCompare(b.journalSubjectCategoryId);
}
case clsAcademicJournalsEN.con_JournalSubjectId:
return (a: clsAcademicJournalsEN, b: clsAcademicJournalsEN) => {
return a.journalSubjectId.localeCompare(b.journalSubjectId);
}
case clsAcademicJournalsEN.con_UpdDate:
return (a: clsAcademicJournalsEN, b: clsAcademicJournalsEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsAcademicJournalsEN.con_UpdUser:
return (a: clsAcademicJournalsEN, b: clsAcademicJournalsEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsAcademicJournalsEN.con_Memo:
return (a: clsAcademicJournalsEN, b: clsAcademicJournalsEN) => {
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[AcademicJournals]中不存在！(in ${ academicJournals_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsAcademicJournalsEN.con_JournalId:
return (a: clsAcademicJournalsEN, b: clsAcademicJournalsEN) => {
return b.journalId.localeCompare(a.journalId);
}
case clsAcademicJournalsEN.con_JournalName:
return (a: clsAcademicJournalsEN, b: clsAcademicJournalsEN) => {
return b.journalName.localeCompare(a.journalName);
}
case clsAcademicJournalsEN.con_JournalSubjectCategoryId:
return (a: clsAcademicJournalsEN, b: clsAcademicJournalsEN) => {
return b.journalSubjectCategoryId.localeCompare(a.journalSubjectCategoryId);
}
case clsAcademicJournalsEN.con_JournalSubjectId:
return (a: clsAcademicJournalsEN, b: clsAcademicJournalsEN) => {
return b.journalSubjectId.localeCompare(a.journalSubjectId);
}
case clsAcademicJournalsEN.con_UpdDate:
return (a: clsAcademicJournalsEN, b: clsAcademicJournalsEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsAcademicJournalsEN.con_UpdUser:
return (a: clsAcademicJournalsEN, b: clsAcademicJournalsEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsAcademicJournalsEN.con_Memo:
return (a: clsAcademicJournalsEN, b: clsAcademicJournalsEN) => {
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[AcademicJournals]中不存在！(in ${ academicJournals_ConstructorName}.${ strThisFuncName})`;
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
export async function AcademicJournals_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsAcademicJournalsEN.con_JournalId:
return (obj: clsAcademicJournalsEN) => {
return obj.journalId === value;
}
case clsAcademicJournalsEN.con_JournalName:
return (obj: clsAcademicJournalsEN) => {
return obj.journalName === value;
}
case clsAcademicJournalsEN.con_JournalSubjectCategoryId:
return (obj: clsAcademicJournalsEN) => {
return obj.journalSubjectCategoryId === value;
}
case clsAcademicJournalsEN.con_JournalSubjectId:
return (obj: clsAcademicJournalsEN) => {
return obj.journalSubjectId === value;
}
case clsAcademicJournalsEN.con_UpdDate:
return (obj: clsAcademicJournalsEN) => {
return obj.updDate === value;
}
case clsAcademicJournalsEN.con_UpdUser:
return (obj: clsAcademicJournalsEN) => {
return obj.updUser === value;
}
case clsAcademicJournalsEN.con_Memo:
return (obj: clsAcademicJournalsEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[AcademicJournals]中不存在！(in ${ academicJournals_ConstructorName}.${ strThisFuncName})`;
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
export async function AcademicJournals_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(academicJournals_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, academicJournals_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, academicJournals_ConstructorName, strThisFuncName);
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
export async function AcademicJournals_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(academicJournals_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, academicJournals_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, academicJournals_ConstructorName, strThisFuncName);
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
export async function AcademicJournals_GetFirstObjAsync(strWhereCond: string): Promise<clsAcademicJournalsEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(academicJournals_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", academicJournals_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objAcademicJournals = AcademicJournals_GetObjFromJsonObj(returnObj);
return objAcademicJournals;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, academicJournals_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, academicJournals_ConstructorName, strThisFuncName);
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
export async function AcademicJournals_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsAcademicJournalsEN._CurrTabName;
clsAcademicJournalsEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsAcademicJournalsEN._CurrTabName);
if (IsNullOrEmpty(clsAcademicJournalsEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsAcademicJournalsEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrAcademicJournalsExObjLst_Cache: Array<clsAcademicJournalsEN> = CacheHelper.Get(strKey);
const arrAcademicJournalsObjLst_T = AcademicJournals_GetObjLstByJSONObjLst(arrAcademicJournalsExObjLst_Cache);
return arrAcademicJournalsObjLst_T;
}
try
{
const arrAcademicJournalsExObjLst = await AcademicJournals_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrAcademicJournalsExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrAcademicJournalsExObjLst.length);
console.log(strInfo);
return arrAcademicJournalsExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, academicJournals_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function AcademicJournals_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsAcademicJournalsEN._CurrTabName;
clsAcademicJournalsEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsAcademicJournalsEN._CurrTabName);
if (IsNullOrEmpty(clsAcademicJournalsEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsAcademicJournalsEN.CacheAddiCondition);
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
const arrAcademicJournalsExObjLst_Cache: Array<clsAcademicJournalsEN> = JSON.parse(strTempObjLst);
const arrAcademicJournalsObjLst_T = AcademicJournals_GetObjLstByJSONObjLst(arrAcademicJournalsExObjLst_Cache);
return arrAcademicJournalsObjLst_T;
}
try
{
const arrAcademicJournalsExObjLst = await AcademicJournals_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrAcademicJournalsExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrAcademicJournalsExObjLst.length);
console.log(strInfo);
return arrAcademicJournalsExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, academicJournals_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function AcademicJournals_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsAcademicJournalsEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrAcademicJournalsObjLst_Cache: Array<clsAcademicJournalsEN> = JSON.parse(strTempObjLst);
return arrAcademicJournalsObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function AcademicJournals_GetObjLstAsync(strWhereCond: string): Promise<Array<clsAcademicJournalsEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(academicJournals_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", academicJournals_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = AcademicJournals_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, academicJournals_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, academicJournals_ConstructorName, strThisFuncName);
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
export async function AcademicJournals_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsAcademicJournalsEN._CurrTabName;
clsAcademicJournalsEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsAcademicJournalsEN._CurrTabName);
if (IsNullOrEmpty(clsAcademicJournalsEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsAcademicJournalsEN.CacheAddiCondition);
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
const arrAcademicJournalsExObjLst_Cache: Array<clsAcademicJournalsEN> = JSON.parse(strTempObjLst);
const arrAcademicJournalsObjLst_T = AcademicJournals_GetObjLstByJSONObjLst(arrAcademicJournalsExObjLst_Cache);
return arrAcademicJournalsObjLst_T;
}
try
{
const arrAcademicJournalsExObjLst = await AcademicJournals_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrAcademicJournalsExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrAcademicJournalsExObjLst.length);
console.log(strInfo);
return arrAcademicJournalsExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, academicJournals_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function AcademicJournals_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsAcademicJournalsEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrAcademicJournalsObjLst_Cache: Array<clsAcademicJournalsEN> = JSON.parse(strTempObjLst);
return arrAcademicJournalsObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function AcademicJournals_GetObjLst_Cache(): Promise<Array<clsAcademicJournalsEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrAcademicJournalsObjLst_Cache;
switch (clsAcademicJournalsEN.CacheModeId)
{
case "04"://sessionStorage
arrAcademicJournalsObjLst_Cache = await AcademicJournals_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrAcademicJournalsObjLst_Cache = await AcademicJournals_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrAcademicJournalsObjLst_Cache = await AcademicJournals_GetObjLst_ClientCache();
break;
default:
arrAcademicJournalsObjLst_Cache = await AcademicJournals_GetObjLst_ClientCache();
break;
}
const arrAcademicJournalsObjLst = AcademicJournals_GetObjLstByJSONObjLst(arrAcademicJournalsObjLst_Cache);
return arrAcademicJournalsObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function AcademicJournals_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrAcademicJournalsObjLst_Cache;
switch (clsAcademicJournalsEN.CacheModeId)
{
case "04"://sessionStorage
arrAcademicJournalsObjLst_Cache = await AcademicJournals_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrAcademicJournalsObjLst_Cache = await AcademicJournals_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrAcademicJournalsObjLst_Cache = null;
break;
default:
arrAcademicJournalsObjLst_Cache = null;
break;
}
return arrAcademicJournalsObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrJournalId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function AcademicJournals_GetSubObjLst_Cache(objAcademicJournals_Cond: clsAcademicJournalsEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrAcademicJournalsObjLst_Cache = await AcademicJournals_GetObjLst_Cache();
let arrAcademicJournals_Sel: Array < clsAcademicJournalsEN > = arrAcademicJournalsObjLst_Cache;
if (objAcademicJournals_Cond.sf_FldComparisonOp == null || objAcademicJournals_Cond.sf_FldComparisonOp == "") return arrAcademicJournals_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objAcademicJournals_Cond.sf_FldComparisonOp);
//console.log("clsAcademicJournalsWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objAcademicJournals_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrAcademicJournals_Sel = arrAcademicJournals_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objAcademicJournals_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrAcademicJournals_Sel = arrAcademicJournals_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrAcademicJournals_Sel = arrAcademicJournals_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrAcademicJournals_Sel = arrAcademicJournals_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrAcademicJournals_Sel = arrAcademicJournals_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrAcademicJournals_Sel = arrAcademicJournals_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrAcademicJournals_Sel = arrAcademicJournals_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrAcademicJournals_Sel = arrAcademicJournals_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrAcademicJournals_Sel = arrAcademicJournals_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrAcademicJournals_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objAcademicJournals_Cond), academicJournals_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsAcademicJournalsEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrJournalId:关键字列表
 * @returns 对象列表
 **/
export async function AcademicJournals_GetObjLstByJournalIdLstAsync(arrJournalId: Array<string>): Promise<Array<clsAcademicJournalsEN>>  
{
const strThisFuncName = "GetObjLstByJournalIdLstAsync";
const strAction = "GetObjLstByJournalIdLst";
const strUrl = GetWebApiUrl(academicJournals_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrJournalId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", academicJournals_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = AcademicJournals_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, academicJournals_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, academicJournals_ConstructorName, strThisFuncName);
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
 * @param arrstrJournalIdLst:关键字列表
 * @returns 对象列表
*/
export async function AcademicJournals_GetObjLstByJournalIdLst_Cache(arrJournalIdLst: Array<string>) {
const strThisFuncName = "GetObjLstByJournalIdLst_Cache";
try
{
const arrAcademicJournalsObjLst_Cache = await AcademicJournals_GetObjLst_Cache();
const arrAcademicJournals_Sel: Array <clsAcademicJournalsEN> = arrAcademicJournalsObjLst_Cache.filter(x => arrJournalIdLst.indexOf(x.journalId)>-1);
return arrAcademicJournals_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrJournalIdLst.join(","), academicJournals_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsAcademicJournalsEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function AcademicJournals_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsAcademicJournalsEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(academicJournals_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", academicJournals_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = AcademicJournals_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, academicJournals_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, academicJournals_ConstructorName, strThisFuncName);
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
export async function AcademicJournals_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsAcademicJournalsEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(academicJournals_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", academicJournals_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = AcademicJournals_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, academicJournals_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, academicJournals_ConstructorName, strThisFuncName);
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
export async function AcademicJournals_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(academicJournals_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, academicJournals_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, academicJournals_ConstructorName, strThisFuncName);
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
export async function AcademicJournals_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrAcademicJournalsObjLst_Cache = await AcademicJournals_GetObjLst_Cache();
if (arrAcademicJournalsObjLst_Cache.length == 0) return arrAcademicJournalsObjLst_Cache;
let arrAcademicJournals_Sel = arrAcademicJournalsObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objAcademicJournals_Cond = new clsAcademicJournalsEN();
ObjectAssign(objAcademicJournals_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsAcademicJournalsWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrAcademicJournals_Sel = arrAcademicJournals_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objAcademicJournals_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrAcademicJournals_Sel = arrAcademicJournals_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrAcademicJournals_Sel = arrAcademicJournals_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrAcademicJournals_Sel = arrAcademicJournals_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrAcademicJournals_Sel = arrAcademicJournals_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrAcademicJournals_Sel = arrAcademicJournals_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrAcademicJournals_Sel = arrAcademicJournals_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrAcademicJournals_Sel = arrAcademicJournals_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrAcademicJournals_Sel = arrAcademicJournals_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrAcademicJournals_Sel = arrAcademicJournals_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrAcademicJournals_Sel.length == 0) return arrAcademicJournals_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrAcademicJournals_Sel = arrAcademicJournals_Sel.sort(AcademicJournals_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrAcademicJournals_Sel = arrAcademicJournals_Sel.sort(objPagerPara.sortFun);
}
arrAcademicJournals_Sel = arrAcademicJournals_Sel.slice(intStart, intEnd);     
return arrAcademicJournals_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, academicJournals_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsAcademicJournalsEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function AcademicJournals_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsAcademicJournalsEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(academicJournals_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", academicJournals_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = AcademicJournals_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, academicJournals_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, academicJournals_ConstructorName, strThisFuncName);
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
 * @param strJournalId:关键字
 * @returns 获取删除的结果
 **/
export async function AcademicJournals_DelRecordAsync(strJournalId: string): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(academicJournals_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, strJournalId);
try
{
const response = await axios.delete(strUrl,
{
params: { "Id": strJournalId, }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, academicJournals_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, academicJournals_ConstructorName, strThisFuncName);
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
 * @param arrJournalId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function AcademicJournals_DelAcademicJournalssAsync(arrJournalId: Array<string>): Promise<number> 
{
const strThisFuncName = "DelAcademicJournalssAsync";
const strAction = "DelAcademicJournalss";
const strUrl = GetWebApiUrl(academicJournals_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrJournalId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, academicJournals_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, academicJournals_ConstructorName, strThisFuncName);
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
export async function AcademicJournals_DelAcademicJournalssByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "DelAcademicJournalssByCondAsync";
const strAction = "DelAcademicJournalssByCond";
const strUrl = GetWebApiUrl(academicJournals_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, academicJournals_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, academicJournals_ConstructorName, strThisFuncName);
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
 * @param objAcademicJournalsEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function AcademicJournals_AddNewRecordAsync(objAcademicJournalsEN: clsAcademicJournalsEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objAcademicJournalsEN);
const strUrl = GetWebApiUrl(academicJournals_Controller, strAction);
try
{
const response = await axios.post(strUrl, objAcademicJournalsEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, academicJournals_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, academicJournals_ConstructorName, strThisFuncName);
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
 * @param objAcademicJournalsEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function AcademicJournals_AddNewRecordWithMaxIdAsync(objAcademicJournalsEN: clsAcademicJournalsEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithMaxIdAsync";
const strAction = "AddNewRecordWithMaxId";
const strUrl = GetWebApiUrl(academicJournals_Controller, strAction);
try
{
const response = await axios.post(strUrl, objAcademicJournalsEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, academicJournals_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, academicJournals_ConstructorName, strThisFuncName);
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
 * @param objAcademicJournalsEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function AcademicJournals_AddNewRecordWithReturnKeyAsync(objAcademicJournalsEN: clsAcademicJournalsEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(academicJournals_Controller, strAction);
try
{
const response = await axios.post(strUrl, objAcademicJournalsEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, academicJournals_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, academicJournals_ConstructorName, strThisFuncName);
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
 * @param objAcademicJournalsEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function AcademicJournals_AddNewRecordWithReturnKey(objAcademicJournalsEN: clsAcademicJournalsEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objAcademicJournalsEN.journalId === null || objAcademicJournalsEN.journalId === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(academicJournals_Controller, strAction);
try
{
const response = await axios.post(strUrl, objAcademicJournalsEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, academicJournals_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, academicJournals_ConstructorName, strThisFuncName);
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
 * @param objAcademicJournalsEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function AcademicJournals_UpdateRecordAsync(objAcademicJournalsEN: clsAcademicJournalsEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objAcademicJournalsEN.sf_UpdFldSetStr === undefined || objAcademicJournalsEN.sf_UpdFldSetStr === null || objAcademicJournalsEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objAcademicJournalsEN.journalId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(academicJournals_Controller, strAction);
try
{
const response = await axios.post(strUrl, objAcademicJournalsEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, academicJournals_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, academicJournals_ConstructorName, strThisFuncName);
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
 * @param objAcademicJournalsEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function AcademicJournals_UpdateWithConditionAsync(objAcademicJournalsEN: clsAcademicJournalsEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objAcademicJournalsEN.sf_UpdFldSetStr === undefined || objAcademicJournalsEN.sf_UpdFldSetStr === null || objAcademicJournalsEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objAcademicJournalsEN.journalId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(academicJournals_Controller, strAction);
objAcademicJournalsEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objAcademicJournalsEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, academicJournals_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, academicJournals_ConstructorName, strThisFuncName);
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
 * @param objstrJournalId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function AcademicJournals_IsExistRecord_Cache(objAcademicJournals_Cond: clsAcademicJournalsEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrAcademicJournalsObjLst_Cache = await AcademicJournals_GetObjLst_Cache();
if (arrAcademicJournalsObjLst_Cache == null) return false;
let arrAcademicJournals_Sel: Array < clsAcademicJournalsEN > = arrAcademicJournalsObjLst_Cache;
if (objAcademicJournals_Cond.sf_FldComparisonOp == null || objAcademicJournals_Cond.sf_FldComparisonOp == "") return arrAcademicJournals_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objAcademicJournals_Cond.sf_FldComparisonOp);
//console.log("clsAcademicJournalsWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objAcademicJournals_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objAcademicJournals_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrAcademicJournals_Sel = arrAcademicJournals_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrAcademicJournals_Sel = arrAcademicJournals_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrAcademicJournals_Sel = arrAcademicJournals_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrAcademicJournals_Sel = arrAcademicJournals_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrAcademicJournals_Sel = arrAcademicJournals_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrAcademicJournals_Sel = arrAcademicJournals_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrAcademicJournals_Sel = arrAcademicJournals_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrAcademicJournals_Sel = arrAcademicJournals_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrAcademicJournals_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objAcademicJournals_Cond), academicJournals_ConstructorName, strThisFuncName);
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
export async function AcademicJournals_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(academicJournals_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, academicJournals_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, academicJournals_ConstructorName, strThisFuncName);
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
 * @param strJournalId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function AcademicJournals_IsExist(strJournalId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(academicJournals_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"JournalId": strJournalId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, academicJournals_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, academicJournals_ConstructorName, strThisFuncName);
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
 * @param strJournalId:所给的关键字
 * @returns 对象
*/
export async function AcademicJournals_IsExist_Cache(strJournalId:string) {
const strThisFuncName = "IsExist_Cache";
const arrAcademicJournalsObjLst_Cache = await AcademicJournals_GetObjLst_Cache();
if (arrAcademicJournalsObjLst_Cache == null) return false;
try
{
const arrAcademicJournals_Sel: Array <clsAcademicJournalsEN> = arrAcademicJournalsObjLst_Cache.filter(x => x.journalId == strJournalId);
if (arrAcademicJournals_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strJournalId, academicJournals_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param strJournalId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function AcademicJournals_IsExistAsync(strJournalId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(academicJournals_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strJournalId": strJournalId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, academicJournals_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, academicJournals_ConstructorName, strThisFuncName);
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
export async function AcademicJournals_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(academicJournals_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, academicJournals_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, academicJournals_ConstructorName, strThisFuncName);
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
 * @param objAcademicJournals_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function AcademicJournals_GetRecCountByCond_Cache(objAcademicJournals_Cond: clsAcademicJournalsEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrAcademicJournalsObjLst_Cache = await AcademicJournals_GetObjLst_Cache();
if (arrAcademicJournalsObjLst_Cache == null) return 0;
let arrAcademicJournals_Sel: Array < clsAcademicJournalsEN > = arrAcademicJournalsObjLst_Cache;
if (objAcademicJournals_Cond.sf_FldComparisonOp == null || objAcademicJournals_Cond.sf_FldComparisonOp == "") return arrAcademicJournals_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objAcademicJournals_Cond.sf_FldComparisonOp);
//console.log("clsAcademicJournalsWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objAcademicJournals_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrAcademicJournals_Sel = arrAcademicJournals_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objAcademicJournals_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrAcademicJournals_Sel = arrAcademicJournals_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrAcademicJournals_Sel = arrAcademicJournals_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrAcademicJournals_Sel = arrAcademicJournals_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrAcademicJournals_Sel = arrAcademicJournals_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrAcademicJournals_Sel = arrAcademicJournals_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrAcademicJournals_Sel = arrAcademicJournals_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrAcademicJournals_Sel = arrAcademicJournals_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrAcademicJournals_Sel = arrAcademicJournals_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrAcademicJournals_Sel = arrAcademicJournals_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrAcademicJournals_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objAcademicJournals_Cond), academicJournals_ConstructorName, strThisFuncName);
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
export async function AcademicJournals_GetMaxStrIdAsync(): Promise<string>  
{
const strThisFuncName = "GetMaxStrIdAsync";
const strAction = "GetMaxStrId";
const strUrl = GetWebApiUrl(academicJournals_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, academicJournals_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, academicJournals_ConstructorName, strThisFuncName);
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
export async function AcademicJournals_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(academicJournals_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, academicJournals_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, academicJournals_ConstructorName, strThisFuncName);
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
export function AcademicJournals_GetWebApiUrl(strController: string, strAction: string): string {
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
export function AcademicJournals_ReFreshCache():void
{
const strThisFuncName = "ReFreshCache";

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = clsAcademicJournalsEN._CurrTabName;
switch (clsAcademicJournalsEN.CacheModeId)
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
export function AcademicJournals_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clsAcademicJournalsEN._CurrTabName;
switch (clsAcademicJournalsEN.CacheModeId)
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
export async function AcademicJournals__Cache(strDivName: string, strDdlName: string )
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
const arrObjLst_Sel = await AcademicJournals_GetObjLst_Cache();
if (arrObjLst_Sel == null) return;
BindDdl_ObjLstInDiv(strDivName, strDdlName, arrObjLst_Sel, clsAcademicJournalsEN.con_JournalId, clsAcademicJournalsEN.con_JournalName, "学术期刊");
}

/**
 * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function AcademicJournals_CheckPropertyNew(pobjAcademicJournalsEN: clsAcademicJournalsEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjAcademicJournalsEN.journalName) === true )
{
 throw new Error("(errid:Watl000058)字段[期刊名称]不能为空(In 学术期刊)!(clsAcademicJournalsBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjAcademicJournalsEN.journalId) == false && GetStrLen(pobjAcademicJournalsEN.journalId) > 4)
{
 throw new Error("(errid:Watl000059)字段[期刊Id(journalId)]的长度不能超过4(In 学术期刊(AcademicJournals))!值:$(pobjAcademicJournalsEN.journalId)(clsAcademicJournalsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjAcademicJournalsEN.journalName) == false && GetStrLen(pobjAcademicJournalsEN.journalName) > 100)
{
 throw new Error("(errid:Watl000059)字段[期刊名称(journalName)]的长度不能超过100(In 学术期刊(AcademicJournals))!值:$(pobjAcademicJournalsEN.journalName)(clsAcademicJournalsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjAcademicJournalsEN.journalSubjectCategoryId) == false && GetStrLen(pobjAcademicJournalsEN.journalSubjectCategoryId) > 4)
{
 throw new Error("(errid:Watl000059)字段[期刊学科门类Id(journalSubjectCategoryId)]的长度不能超过4(In 学术期刊(AcademicJournals))!值:$(pobjAcademicJournalsEN.journalSubjectCategoryId)(clsAcademicJournalsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjAcademicJournalsEN.journalSubjectId) == false && GetStrLen(pobjAcademicJournalsEN.journalSubjectId) > 4)
{
 throw new Error("(errid:Watl000059)字段[期刊学科Id(journalSubjectId)]的长度不能超过4(In 学术期刊(AcademicJournals))!值:$(pobjAcademicJournalsEN.journalSubjectId)(clsAcademicJournalsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjAcademicJournalsEN.updDate) == false && GetStrLen(pobjAcademicJournalsEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 学术期刊(AcademicJournals))!值:$(pobjAcademicJournalsEN.updDate)(clsAcademicJournalsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjAcademicJournalsEN.updUser) == false && GetStrLen(pobjAcademicJournalsEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 学术期刊(AcademicJournals))!值:$(pobjAcademicJournalsEN.updUser)(clsAcademicJournalsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjAcademicJournalsEN.memo) == false && GetStrLen(pobjAcademicJournalsEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 学术期刊(AcademicJournals))!值:$(pobjAcademicJournalsEN.memo)(clsAcademicJournalsBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjAcademicJournalsEN.journalId) == false && undefined !== pobjAcademicJournalsEN.journalId && tzDataType.isString(pobjAcademicJournalsEN.journalId) === false)
{
 throw new Error("(errid:Watl000060)字段[期刊Id(journalId)]的值:[$(pobjAcademicJournalsEN.journalId)], 非法，应该为字符型(In 学术期刊(AcademicJournals))!(clsAcademicJournalsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjAcademicJournalsEN.journalName) == false && undefined !== pobjAcademicJournalsEN.journalName && tzDataType.isString(pobjAcademicJournalsEN.journalName) === false)
{
 throw new Error("(errid:Watl000060)字段[期刊名称(journalName)]的值:[$(pobjAcademicJournalsEN.journalName)], 非法，应该为字符型(In 学术期刊(AcademicJournals))!(clsAcademicJournalsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjAcademicJournalsEN.journalSubjectCategoryId) == false && undefined !== pobjAcademicJournalsEN.journalSubjectCategoryId && tzDataType.isString(pobjAcademicJournalsEN.journalSubjectCategoryId) === false)
{
 throw new Error("(errid:Watl000060)字段[期刊学科门类Id(journalSubjectCategoryId)]的值:[$(pobjAcademicJournalsEN.journalSubjectCategoryId)], 非法，应该为字符型(In 学术期刊(AcademicJournals))!(clsAcademicJournalsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjAcademicJournalsEN.journalSubjectId) == false && undefined !== pobjAcademicJournalsEN.journalSubjectId && tzDataType.isString(pobjAcademicJournalsEN.journalSubjectId) === false)
{
 throw new Error("(errid:Watl000060)字段[期刊学科Id(journalSubjectId)]的值:[$(pobjAcademicJournalsEN.journalSubjectId)], 非法，应该为字符型(In 学术期刊(AcademicJournals))!(clsAcademicJournalsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjAcademicJournalsEN.updDate) == false && undefined !== pobjAcademicJournalsEN.updDate && tzDataType.isString(pobjAcademicJournalsEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjAcademicJournalsEN.updDate)], 非法，应该为字符型(In 学术期刊(AcademicJournals))!(clsAcademicJournalsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjAcademicJournalsEN.updUser) == false && undefined !== pobjAcademicJournalsEN.updUser && tzDataType.isString(pobjAcademicJournalsEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjAcademicJournalsEN.updUser)], 非法，应该为字符型(In 学术期刊(AcademicJournals))!(clsAcademicJournalsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjAcademicJournalsEN.memo) == false && undefined !== pobjAcademicJournalsEN.memo && tzDataType.isString(pobjAcademicJournalsEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjAcademicJournalsEN.memo)], 非法，应该为字符型(In 学术期刊(AcademicJournals))!(clsAcademicJournalsBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjAcademicJournalsEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function AcademicJournals_CheckProperty4Update (pobjAcademicJournalsEN: clsAcademicJournalsEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjAcademicJournalsEN.journalId) == false && GetStrLen(pobjAcademicJournalsEN.journalId) > 4)
{
 throw new Error("(errid:Watl000062)字段[期刊Id(journalId)]的长度不能超过4(In 学术期刊(AcademicJournals))!值:$(pobjAcademicJournalsEN.journalId)(clsAcademicJournalsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjAcademicJournalsEN.journalName) == false && GetStrLen(pobjAcademicJournalsEN.journalName) > 100)
{
 throw new Error("(errid:Watl000062)字段[期刊名称(journalName)]的长度不能超过100(In 学术期刊(AcademicJournals))!值:$(pobjAcademicJournalsEN.journalName)(clsAcademicJournalsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjAcademicJournalsEN.journalSubjectCategoryId) == false && GetStrLen(pobjAcademicJournalsEN.journalSubjectCategoryId) > 4)
{
 throw new Error("(errid:Watl000062)字段[期刊学科门类Id(journalSubjectCategoryId)]的长度不能超过4(In 学术期刊(AcademicJournals))!值:$(pobjAcademicJournalsEN.journalSubjectCategoryId)(clsAcademicJournalsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjAcademicJournalsEN.journalSubjectId) == false && GetStrLen(pobjAcademicJournalsEN.journalSubjectId) > 4)
{
 throw new Error("(errid:Watl000062)字段[期刊学科Id(journalSubjectId)]的长度不能超过4(In 学术期刊(AcademicJournals))!值:$(pobjAcademicJournalsEN.journalSubjectId)(clsAcademicJournalsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjAcademicJournalsEN.updDate) == false && GetStrLen(pobjAcademicJournalsEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 学术期刊(AcademicJournals))!值:$(pobjAcademicJournalsEN.updDate)(clsAcademicJournalsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjAcademicJournalsEN.updUser) == false && GetStrLen(pobjAcademicJournalsEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 学术期刊(AcademicJournals))!值:$(pobjAcademicJournalsEN.updUser)(clsAcademicJournalsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjAcademicJournalsEN.memo) == false && GetStrLen(pobjAcademicJournalsEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 学术期刊(AcademicJournals))!值:$(pobjAcademicJournalsEN.memo)(clsAcademicJournalsBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjAcademicJournalsEN.journalId) == false && undefined !== pobjAcademicJournalsEN.journalId && tzDataType.isString(pobjAcademicJournalsEN.journalId) === false)
{
 throw new Error("(errid:Watl000063)字段[期刊Id(journalId)]的值:[$(pobjAcademicJournalsEN.journalId)], 非法，应该为字符型(In 学术期刊(AcademicJournals))!(clsAcademicJournalsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjAcademicJournalsEN.journalName) == false && undefined !== pobjAcademicJournalsEN.journalName && tzDataType.isString(pobjAcademicJournalsEN.journalName) === false)
{
 throw new Error("(errid:Watl000063)字段[期刊名称(journalName)]的值:[$(pobjAcademicJournalsEN.journalName)], 非法，应该为字符型(In 学术期刊(AcademicJournals))!(clsAcademicJournalsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjAcademicJournalsEN.journalSubjectCategoryId) == false && undefined !== pobjAcademicJournalsEN.journalSubjectCategoryId && tzDataType.isString(pobjAcademicJournalsEN.journalSubjectCategoryId) === false)
{
 throw new Error("(errid:Watl000063)字段[期刊学科门类Id(journalSubjectCategoryId)]的值:[$(pobjAcademicJournalsEN.journalSubjectCategoryId)], 非法，应该为字符型(In 学术期刊(AcademicJournals))!(clsAcademicJournalsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjAcademicJournalsEN.journalSubjectId) == false && undefined !== pobjAcademicJournalsEN.journalSubjectId && tzDataType.isString(pobjAcademicJournalsEN.journalSubjectId) === false)
{
 throw new Error("(errid:Watl000063)字段[期刊学科Id(journalSubjectId)]的值:[$(pobjAcademicJournalsEN.journalSubjectId)], 非法，应该为字符型(In 学术期刊(AcademicJournals))!(clsAcademicJournalsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjAcademicJournalsEN.updDate) == false && undefined !== pobjAcademicJournalsEN.updDate && tzDataType.isString(pobjAcademicJournalsEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjAcademicJournalsEN.updDate)], 非法，应该为字符型(In 学术期刊(AcademicJournals))!(clsAcademicJournalsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjAcademicJournalsEN.updUser) == false && undefined !== pobjAcademicJournalsEN.updUser && tzDataType.isString(pobjAcademicJournalsEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjAcademicJournalsEN.updUser)], 非法，应该为字符型(In 学术期刊(AcademicJournals))!(clsAcademicJournalsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjAcademicJournalsEN.memo) == false && undefined !== pobjAcademicJournalsEN.memo && tzDataType.isString(pobjAcademicJournalsEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjAcademicJournalsEN.memo)], 非法，应该为字符型(In 学术期刊(AcademicJournals))!(clsAcademicJournalsBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (IsNullOrEmpty(pobjAcademicJournalsEN.journalId) === true )
{
 throw new Error("(errid:Watl000064)字段[期刊Id]不能为空(In 学术期刊)!(clsAcademicJournalsBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjAcademicJournalsEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function AcademicJournals_GetJSONStrByObj (pobjAcademicJournalsEN: clsAcademicJournalsEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjAcademicJournalsEN.sf_UpdFldSetStr = pobjAcademicJournalsEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjAcademicJournalsEN);
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
export function AcademicJournals_GetObjLstByJSONStr (strJSON: string): Array<clsAcademicJournalsEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrAcademicJournalsObjLst = new Array<clsAcademicJournalsEN>();
if (strJSON === "")
{
return arrAcademicJournalsObjLst;
}
try
{
arrAcademicJournalsObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrAcademicJournalsObjLst;
}
return arrAcademicJournalsObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrAcademicJournalsObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function AcademicJournals_GetObjLstByJSONObjLst (arrAcademicJournalsObjLstS: Array<clsAcademicJournalsEN>): Array<clsAcademicJournalsEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrAcademicJournalsObjLst = new Array<clsAcademicJournalsEN>();
for (const objInFor of arrAcademicJournalsObjLstS) {
const obj1 = AcademicJournals_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrAcademicJournalsObjLst.push(obj1);
}
return arrAcademicJournalsObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function AcademicJournals_GetObjByJSONStr (strJSON: string): clsAcademicJournalsEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjAcademicJournalsEN = new clsAcademicJournalsEN();
if (strJSON === "")
{
return pobjAcademicJournalsEN;
}
try
{
pobjAcademicJournalsEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjAcademicJournalsEN;
}
return pobjAcademicJournalsEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function AcademicJournals_GetCombineCondition(objAcademicJournals_Cond: clsAcademicJournalsEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objAcademicJournals_Cond.dicFldComparisonOp, clsAcademicJournalsEN.con_JournalId) == true)
{
const strComparisonOp_JournalId:string = objAcademicJournals_Cond.dicFldComparisonOp[clsAcademicJournalsEN.con_JournalId];
strWhereCond += Format(" And {0} {2} '{1}'", clsAcademicJournalsEN.con_JournalId, objAcademicJournals_Cond.journalId, strComparisonOp_JournalId);
}
if (Object.prototype.hasOwnProperty.call(objAcademicJournals_Cond.dicFldComparisonOp, clsAcademicJournalsEN.con_JournalName) == true)
{
const strComparisonOp_JournalName:string = objAcademicJournals_Cond.dicFldComparisonOp[clsAcademicJournalsEN.con_JournalName];
strWhereCond += Format(" And {0} {2} '{1}'", clsAcademicJournalsEN.con_JournalName, objAcademicJournals_Cond.journalName, strComparisonOp_JournalName);
}
if (Object.prototype.hasOwnProperty.call(objAcademicJournals_Cond.dicFldComparisonOp, clsAcademicJournalsEN.con_JournalSubjectCategoryId) == true)
{
const strComparisonOp_JournalSubjectCategoryId:string = objAcademicJournals_Cond.dicFldComparisonOp[clsAcademicJournalsEN.con_JournalSubjectCategoryId];
strWhereCond += Format(" And {0} {2} '{1}'", clsAcademicJournalsEN.con_JournalSubjectCategoryId, objAcademicJournals_Cond.journalSubjectCategoryId, strComparisonOp_JournalSubjectCategoryId);
}
if (Object.prototype.hasOwnProperty.call(objAcademicJournals_Cond.dicFldComparisonOp, clsAcademicJournalsEN.con_JournalSubjectId) == true)
{
const strComparisonOp_JournalSubjectId:string = objAcademicJournals_Cond.dicFldComparisonOp[clsAcademicJournalsEN.con_JournalSubjectId];
strWhereCond += Format(" And {0} {2} '{1}'", clsAcademicJournalsEN.con_JournalSubjectId, objAcademicJournals_Cond.journalSubjectId, strComparisonOp_JournalSubjectId);
}
if (Object.prototype.hasOwnProperty.call(objAcademicJournals_Cond.dicFldComparisonOp, clsAcademicJournalsEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objAcademicJournals_Cond.dicFldComparisonOp[clsAcademicJournalsEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsAcademicJournalsEN.con_UpdDate, objAcademicJournals_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objAcademicJournals_Cond.dicFldComparisonOp, clsAcademicJournalsEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objAcademicJournals_Cond.dicFldComparisonOp[clsAcademicJournalsEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsAcademicJournalsEN.con_UpdUser, objAcademicJournals_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objAcademicJournals_Cond.dicFldComparisonOp, clsAcademicJournalsEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objAcademicJournals_Cond.dicFldComparisonOp[clsAcademicJournalsEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsAcademicJournalsEN.con_Memo, objAcademicJournals_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--AcademicJournals(学术期刊),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param strJournalName: 期刊名称(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function AcademicJournals_GetUniCondStr_JournalName(objAcademicJournalsEN: clsAcademicJournalsEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and JournalName = '{0}'", objAcademicJournalsEN.journalName);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--AcademicJournals(学术期刊),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param strJournalName: 期刊名称(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function AcademicJournals_GetUniCondStr4Update_JournalName(objAcademicJournalsEN: clsAcademicJournalsEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and JournalId <> '{0}'", objAcademicJournalsEN.journalId);
 strWhereCond +=  Format(" and JournalName = '{0}'", objAcademicJournalsEN.journalName);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objAcademicJournalsENS:源对象
 * @param objAcademicJournalsENT:目标对象
*/
export function AcademicJournals_CopyObjTo(objAcademicJournalsENS: clsAcademicJournalsEN , objAcademicJournalsENT: clsAcademicJournalsEN ): void 
{
objAcademicJournalsENT.journalId = objAcademicJournalsENS.journalId; //期刊Id
objAcademicJournalsENT.journalName = objAcademicJournalsENS.journalName; //期刊名称
objAcademicJournalsENT.journalSubjectCategoryId = objAcademicJournalsENS.journalSubjectCategoryId; //期刊学科门类Id
objAcademicJournalsENT.journalSubjectId = objAcademicJournalsENS.journalSubjectId; //期刊学科Id
objAcademicJournalsENT.updDate = objAcademicJournalsENS.updDate; //修改日期
objAcademicJournalsENT.updUser = objAcademicJournalsENS.updUser; //修改人
objAcademicJournalsENT.memo = objAcademicJournalsENS.memo; //备注
objAcademicJournalsENT.sf_UpdFldSetStr = objAcademicJournalsENS.updFldString; //sf_UpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objAcademicJournalsENS:源对象
 * @param objAcademicJournalsENT:目标对象
*/
export function AcademicJournals_GetObjFromJsonObj(objAcademicJournalsENS: clsAcademicJournalsEN): clsAcademicJournalsEN 
{
 const objAcademicJournalsENT: clsAcademicJournalsEN = new clsAcademicJournalsEN();
ObjectAssign(objAcademicJournalsENT, objAcademicJournalsENS);
 return objAcademicJournalsENT;
}