﻿
 /**
 * 类名:clsSchoolYearWApi
 * 表名:SchoolYear(01120134)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:45:53
 * 生成者:pyf
 * 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:系统参数(SysPara)
 * 框架-层名:WA_访问层(TS)(WA_Access)
 * 编程语言:TypeScript
 * 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
   *      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 **/

/**
 * 学年(SchoolYear)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clsSchoolYearEN } from "../../L0_Entity/SysPara/clsSchoolYearEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { tzDataType } from "../../PubFun/jsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const schoolYear_Controller = "SchoolYearApi";
 export const schoolYear_ConstructorName = "schoolYear";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strSchoolYear:关键字
 * @returns 对象
 **/
export async function SchoolYear_GetObjBySchoolYearAsync(strSchoolYear: string): Promise<clsSchoolYearEN>  
{
const strThisFuncName = "GetObjBySchoolYearAsync";

if (IsNullOrEmpty(strSchoolYear) == true)
{
  const strMsg = Format("参数:[strSchoolYear]不能为空！(In GetObjBySchoolYearAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strSchoolYear.length != 10)
{
const strMsg = Format("缓存分类变量:[strSchoolYear]的长度:[{0}]不正确！", strSchoolYear.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjBySchoolYear";
const strUrl = GetWebApiUrl(schoolYear_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strSchoolYear": strSchoolYear,
}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObj = data.returnObj;
if (returnObj == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", schoolYear_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objSchoolYear = SchoolYear_GetObjFromJsonObj(returnObj);
return objSchoolYear;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, schoolYear_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, schoolYear_ConstructorName, strThisFuncName);
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
 * @param strSchoolYear:所给的关键字
 * @returns 对象
*/
export async function SchoolYear_GetObjBySchoolYear_Cache(strSchoolYear: string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjBySchoolYear_Cache";

if (IsNullOrEmpty(strSchoolYear) == true)
{
  const strMsg = Format("参数:[strSchoolYear]不能为空！(In GetObjBySchoolYear_Cache)");
console.error(strMsg);
 throw (strMsg);
}
const arrSchoolYearObjLst_Cache = await SchoolYear_GetObjLst_Cache();
try
{
const arrSchoolYear_Sel: Array <clsSchoolYearEN> = arrSchoolYearObjLst_Cache.filter(x => x.schoolYear == strSchoolYear);
let objSchoolYear: clsSchoolYearEN;
if (arrSchoolYear_Sel.length > 0)
{
objSchoolYear = arrSchoolYear_Sel[0];
return objSchoolYear;
}
else
{
if (bolTryAsyncOnce == true)
{
objSchoolYear = await SchoolYear_GetObjBySchoolYearAsync(strSchoolYear);
if (objSchoolYear != null)
{
SchoolYear_ReFreshThisCache();
return objSchoolYear;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strSchoolYear, schoolYear_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param strSchoolYear:所给的关键字
 * @returns 对象
*/
export async function SchoolYear_GetObjBySchoolYear_localStorage(strSchoolYear: string) {
const strThisFuncName = "GetObjBySchoolYear_localStorage";

if (IsNullOrEmpty(strSchoolYear) == true)
{
  const strMsg = Format("参数:[strSchoolYear]不能为空！(In GetObjBySchoolYear_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
if (strSchoolYear.length != 10)
{
const strMsg = Format("缓存分类变量:[strSchoolYear]的长度:[{0}]不正确！", strSchoolYear.length);
console.error(strMsg);
throw (strMsg);
}
const strKey = Format("{0}_{1}", clsSchoolYearEN._CurrTabName, strSchoolYear);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objSchoolYear_Cache: clsSchoolYearEN = JSON.parse(strTempObj);
return objSchoolYear_Cache;
}
try
{
const objSchoolYear = await SchoolYear_GetObjBySchoolYearAsync(strSchoolYear);
if (objSchoolYear != null)
{
localStorage.setItem(strKey, JSON.stringify(objSchoolYear));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objSchoolYear;
}
return objSchoolYear;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strSchoolYear, schoolYear_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objSchoolYear:所给的对象
 * @returns 对象
*/
export async function SchoolYear_UpdateObjInLst_Cache(objSchoolYear: clsSchoolYearEN) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrSchoolYearObjLst_Cache = await SchoolYear_GetObjLst_Cache();
const obj = arrSchoolYearObjLst_Cache.find(x => 
x.schoolYear == objSchoolYear.schoolYear);
if (obj != null)
{
objSchoolYear.schoolYear = obj.schoolYear;
ObjectAssign( obj, objSchoolYear);
}
else
{
arrSchoolYearObjLst_Cache.push(objSchoolYear);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, schoolYear_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
}

/**
 * 根据关键字获取相关对象的名称属性, 从缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
 * @param strSchoolYear:所给的关键字
 * @returns 对象
*/
export async function SchoolYear_GetNameBySchoolYear_Cache(strSchoolYear: string) {
const strThisFuncName = "GetNameBySchoolYear_Cache";

if (IsNullOrEmpty(strSchoolYear) == true)
{
  const strMsg = Format("参数:[strSchoolYear]不能为空！(In GetNameBySchoolYear_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strSchoolYear.length != 10)
{
const strMsg = Format("缓存分类变量:[strSchoolYear]的长度:[{0}]不正确！", strSchoolYear.length);
console.error(strMsg);
throw (strMsg);
}
const arrSchoolYearObjLst_Cache = await SchoolYear_GetObjLst_Cache();
if (arrSchoolYearObjLst_Cache == null) return "";
try
{
const arrSchoolYear_Sel: Array <clsSchoolYearEN> = arrSchoolYearObjLst_Cache.filter(x => x.schoolYear == strSchoolYear);
let objSchoolYear: clsSchoolYearEN;
if (arrSchoolYear_Sel.length > 0)
{
objSchoolYear = arrSchoolYear_Sel[0];
return objSchoolYear.schoolYearName;
}
else
{
return "";
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strSchoolYear);
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
export async function SchoolYear_func(strInFldName:string , strOutFldName:string ,  strInValue: string) 
{
//const strThisFuncName = "func";

if (strInFldName != clsSchoolYearEN.con_SchoolYear)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsSchoolYearEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clsSchoolYearEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strSchoolYear = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objSchoolYear = await SchoolYear_GetObjBySchoolYear_Cache(strSchoolYear );
if (objSchoolYear == null) return "";
return objSchoolYear.GetFldValue(strOutFldName).toString();
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
export function SchoolYear_SortFun_Defa(a:clsSchoolYearEN , b:clsSchoolYearEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.schoolYear.localeCompare(b.schoolYear);
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
export function SchoolYear_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsSchoolYearEN.con_SchoolYear:
return (a: clsSchoolYearEN, b: clsSchoolYearEN) => {
return a.schoolYear.localeCompare(b.schoolYear);
}
case clsSchoolYearEN.con_SchoolYearName:
return (a: clsSchoolYearEN, b: clsSchoolYearEN) => {
return a.schoolYearName.localeCompare(b.schoolYearName);
}
case clsSchoolYearEN.con_IsCurrentSchoolYear:
return (a: clsSchoolYearEN, b: clsSchoolYearEN) => {
if (a.isCurrentSchoolYear == true) return 1;
else return -1
}
case clsSchoolYearEN.con_IsVisible:
return (a: clsSchoolYearEN, b: clsSchoolYearEN) => {
if (a.isVisible == true) return 1;
else return -1
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[SchoolYear]中不存在！(in ${ schoolYear_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsSchoolYearEN.con_SchoolYear:
return (a: clsSchoolYearEN, b: clsSchoolYearEN) => {
return b.schoolYear.localeCompare(a.schoolYear);
}
case clsSchoolYearEN.con_SchoolYearName:
return (a: clsSchoolYearEN, b: clsSchoolYearEN) => {
return b.schoolYearName.localeCompare(a.schoolYearName);
}
case clsSchoolYearEN.con_IsCurrentSchoolYear:
return (a: clsSchoolYearEN, b: clsSchoolYearEN) => {
if (b.isCurrentSchoolYear == true) return 1;
else return -1
}
case clsSchoolYearEN.con_IsVisible:
return (a: clsSchoolYearEN, b: clsSchoolYearEN) => {
if (b.isVisible == true) return 1;
else return -1
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[SchoolYear]中不存在！(in ${ schoolYear_ConstructorName}.${ strThisFuncName})`;
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
export async function SchoolYear_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsSchoolYearEN.con_SchoolYear:
return (obj: clsSchoolYearEN) => {
return obj.schoolYear === value;
}
case clsSchoolYearEN.con_SchoolYearName:
return (obj: clsSchoolYearEN) => {
return obj.schoolYearName === value;
}
case clsSchoolYearEN.con_IsCurrentSchoolYear:
return (obj: clsSchoolYearEN) => {
return obj.isCurrentSchoolYear === value;
}
case clsSchoolYearEN.con_IsVisible:
return (obj: clsSchoolYearEN) => {
return obj.isVisible === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[SchoolYear]中不存在！(in ${ schoolYear_ConstructorName}.${ strThisFuncName})`;
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
export async function SchoolYear_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(schoolYear_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, schoolYear_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, schoolYear_ConstructorName, strThisFuncName);
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
export async function SchoolYear_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(schoolYear_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, schoolYear_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, schoolYear_ConstructorName, strThisFuncName);
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
export async function SchoolYear_GetFirstObjAsync(strWhereCond: string): Promise<clsSchoolYearEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(schoolYear_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", schoolYear_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objSchoolYear = SchoolYear_GetObjFromJsonObj(returnObj);
return objSchoolYear;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, schoolYear_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, schoolYear_ConstructorName, strThisFuncName);
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
export async function SchoolYear_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsSchoolYearEN._CurrTabName;
clsSchoolYearEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsSchoolYearEN._CurrTabName);
if (IsNullOrEmpty(clsSchoolYearEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsSchoolYearEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrSchoolYearExObjLst_Cache: Array<clsSchoolYearEN> = CacheHelper.Get(strKey);
const arrSchoolYearObjLst_T = SchoolYear_GetObjLstByJSONObjLst(arrSchoolYearExObjLst_Cache);
return arrSchoolYearObjLst_T;
}
try
{
const arrSchoolYearExObjLst = await SchoolYear_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrSchoolYearExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrSchoolYearExObjLst.length);
console.log(strInfo);
return arrSchoolYearExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, schoolYear_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function SchoolYear_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsSchoolYearEN._CurrTabName;
clsSchoolYearEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsSchoolYearEN._CurrTabName);
if (IsNullOrEmpty(clsSchoolYearEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsSchoolYearEN.CacheAddiCondition);
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
const arrSchoolYearExObjLst_Cache: Array<clsSchoolYearEN> = JSON.parse(strTempObjLst);
const arrSchoolYearObjLst_T = SchoolYear_GetObjLstByJSONObjLst(arrSchoolYearExObjLst_Cache);
return arrSchoolYearObjLst_T;
}
try
{
const arrSchoolYearExObjLst = await SchoolYear_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrSchoolYearExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrSchoolYearExObjLst.length);
console.log(strInfo);
return arrSchoolYearExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, schoolYear_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function SchoolYear_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsSchoolYearEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrSchoolYearObjLst_Cache: Array<clsSchoolYearEN> = JSON.parse(strTempObjLst);
return arrSchoolYearObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function SchoolYear_GetObjLstAsync(strWhereCond: string): Promise<Array<clsSchoolYearEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(schoolYear_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", schoolYear_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = SchoolYear_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, schoolYear_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, schoolYear_ConstructorName, strThisFuncName);
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
export async function SchoolYear_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsSchoolYearEN._CurrTabName;
clsSchoolYearEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsSchoolYearEN._CurrTabName);
if (IsNullOrEmpty(clsSchoolYearEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsSchoolYearEN.CacheAddiCondition);
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
const arrSchoolYearExObjLst_Cache: Array<clsSchoolYearEN> = JSON.parse(strTempObjLst);
const arrSchoolYearObjLst_T = SchoolYear_GetObjLstByJSONObjLst(arrSchoolYearExObjLst_Cache);
return arrSchoolYearObjLst_T;
}
try
{
const arrSchoolYearExObjLst = await SchoolYear_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrSchoolYearExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrSchoolYearExObjLst.length);
console.log(strInfo);
return arrSchoolYearExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, schoolYear_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function SchoolYear_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsSchoolYearEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrSchoolYearObjLst_Cache: Array<clsSchoolYearEN> = JSON.parse(strTempObjLst);
return arrSchoolYearObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function SchoolYear_GetObjLst_Cache(): Promise<Array<clsSchoolYearEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrSchoolYearObjLst_Cache;
switch (clsSchoolYearEN.CacheModeId)
{
case "04"://sessionStorage
arrSchoolYearObjLst_Cache = await SchoolYear_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrSchoolYearObjLst_Cache = await SchoolYear_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrSchoolYearObjLst_Cache = await SchoolYear_GetObjLst_ClientCache();
break;
default:
arrSchoolYearObjLst_Cache = await SchoolYear_GetObjLst_ClientCache();
break;
}
const arrSchoolYearObjLst = SchoolYear_GetObjLstByJSONObjLst(arrSchoolYearObjLst_Cache);
return arrSchoolYearObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function SchoolYear_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrSchoolYearObjLst_Cache;
switch (clsSchoolYearEN.CacheModeId)
{
case "04"://sessionStorage
arrSchoolYearObjLst_Cache = await SchoolYear_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrSchoolYearObjLst_Cache = await SchoolYear_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrSchoolYearObjLst_Cache = null;
break;
default:
arrSchoolYearObjLst_Cache = null;
break;
}
return arrSchoolYearObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrSchoolYear_Cond:条件对象
 * @returns 对象列表子集
*/
export async function SchoolYear_GetSubObjLst_Cache(objSchoolYear_Cond: clsSchoolYearEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrSchoolYearObjLst_Cache = await SchoolYear_GetObjLst_Cache();
let arrSchoolYear_Sel: Array < clsSchoolYearEN > = arrSchoolYearObjLst_Cache;
if (objSchoolYear_Cond.sf_FldComparisonOp == null || objSchoolYear_Cond.sf_FldComparisonOp == "") return arrSchoolYear_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objSchoolYear_Cond.sf_FldComparisonOp);
//console.log("clsSchoolYearWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objSchoolYear_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrSchoolYear_Sel = arrSchoolYear_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objSchoolYear_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrSchoolYear_Sel = arrSchoolYear_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrSchoolYear_Sel = arrSchoolYear_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrSchoolYear_Sel = arrSchoolYear_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrSchoolYear_Sel = arrSchoolYear_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrSchoolYear_Sel = arrSchoolYear_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrSchoolYear_Sel = arrSchoolYear_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrSchoolYear_Sel = arrSchoolYear_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrSchoolYear_Sel = arrSchoolYear_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrSchoolYear_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objSchoolYear_Cond), schoolYear_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsSchoolYearEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrSchoolYear:关键字列表
 * @returns 对象列表
 **/
export async function SchoolYear_GetObjLstBySchoolYearLstAsync(arrSchoolYear: Array<string>): Promise<Array<clsSchoolYearEN>>  
{
const strThisFuncName = "GetObjLstBySchoolYearLstAsync";
const strAction = "GetObjLstBySchoolYearLst";
const strUrl = GetWebApiUrl(schoolYear_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrSchoolYear);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", schoolYear_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = SchoolYear_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, schoolYear_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, schoolYear_ConstructorName, strThisFuncName);
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
 * @param arrstrSchoolYearLst:关键字列表
 * @returns 对象列表
*/
export async function SchoolYear_GetObjLstBySchoolYearLst_Cache(arrSchoolYearLst: Array<string>) {
const strThisFuncName = "GetObjLstBySchoolYearLst_Cache";
try
{
const arrSchoolYearObjLst_Cache = await SchoolYear_GetObjLst_Cache();
const arrSchoolYear_Sel: Array <clsSchoolYearEN> = arrSchoolYearObjLst_Cache.filter(x => arrSchoolYearLst.indexOf(x.schoolYear)>-1);
return arrSchoolYear_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrSchoolYearLst.join(","), schoolYear_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsSchoolYearEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function SchoolYear_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsSchoolYearEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(schoolYear_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", schoolYear_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = SchoolYear_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, schoolYear_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, schoolYear_ConstructorName, strThisFuncName);
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
export async function SchoolYear_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsSchoolYearEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(schoolYear_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", schoolYear_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = SchoolYear_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, schoolYear_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, schoolYear_ConstructorName, strThisFuncName);
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
export async function SchoolYear_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(schoolYear_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, schoolYear_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, schoolYear_ConstructorName, strThisFuncName);
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
export async function SchoolYear_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrSchoolYearObjLst_Cache = await SchoolYear_GetObjLst_Cache();
if (arrSchoolYearObjLst_Cache.length == 0) return arrSchoolYearObjLst_Cache;
let arrSchoolYear_Sel = arrSchoolYearObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objSchoolYear_Cond = new clsSchoolYearEN();
ObjectAssign(objSchoolYear_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsSchoolYearWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrSchoolYear_Sel = arrSchoolYear_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objSchoolYear_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrSchoolYear_Sel = arrSchoolYear_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrSchoolYear_Sel = arrSchoolYear_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrSchoolYear_Sel = arrSchoolYear_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrSchoolYear_Sel = arrSchoolYear_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrSchoolYear_Sel = arrSchoolYear_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrSchoolYear_Sel = arrSchoolYear_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrSchoolYear_Sel = arrSchoolYear_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrSchoolYear_Sel = arrSchoolYear_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrSchoolYear_Sel = arrSchoolYear_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrSchoolYear_Sel.length == 0) return arrSchoolYear_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrSchoolYear_Sel = arrSchoolYear_Sel.sort(SchoolYear_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrSchoolYear_Sel = arrSchoolYear_Sel.sort(objPagerPara.sortFun);
}
arrSchoolYear_Sel = arrSchoolYear_Sel.slice(intStart, intEnd);     
return arrSchoolYear_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, schoolYear_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsSchoolYearEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function SchoolYear_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsSchoolYearEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(schoolYear_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", schoolYear_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = SchoolYear_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, schoolYear_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, schoolYear_ConstructorName, strThisFuncName);
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
 * @param strSchoolYear:关键字
 * @returns 获取删除的结果
 **/
export async function SchoolYear_DelRecordAsync(strSchoolYear: string): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(schoolYear_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, strSchoolYear);
try
{
const response = await axios.delete(strUrl,
{
params: { "Id": strSchoolYear, }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, schoolYear_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, schoolYear_ConstructorName, strThisFuncName);
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
 * @param arrSchoolYear:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function SchoolYear_DelSchoolYearsAsync(arrSchoolYear: Array<string>): Promise<number> 
{
const strThisFuncName = "DelSchoolYearsAsync";
const strAction = "DelSchoolYears";
const strUrl = GetWebApiUrl(schoolYear_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrSchoolYear);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, schoolYear_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, schoolYear_ConstructorName, strThisFuncName);
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
export async function SchoolYear_DelSchoolYearsByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "DelSchoolYearsByCondAsync";
const strAction = "DelSchoolYearsByCond";
const strUrl = GetWebApiUrl(schoolYear_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, schoolYear_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, schoolYear_ConstructorName, strThisFuncName);
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
 * @param objSchoolYearEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function SchoolYear_AddNewRecordAsync(objSchoolYearEN: clsSchoolYearEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
if (objSchoolYearEN.schoolYear === null || objSchoolYearEN.schoolYear === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objSchoolYearEN);
const strUrl = GetWebApiUrl(schoolYear_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSchoolYearEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, schoolYear_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, schoolYear_ConstructorName, strThisFuncName);
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
 * @param objSchoolYearEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function SchoolYear_AddNewRecordWithMaxIdAsync(objSchoolYearEN: clsSchoolYearEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithMaxIdAsync";
const strAction = "AddNewRecordWithMaxId";
const strUrl = GetWebApiUrl(schoolYear_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSchoolYearEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, schoolYear_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, schoolYear_ConstructorName, strThisFuncName);
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
 * @param objSchoolYearEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function SchoolYear_AddNewRecordWithReturnKeyAsync(objSchoolYearEN: clsSchoolYearEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(schoolYear_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSchoolYearEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, schoolYear_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, schoolYear_ConstructorName, strThisFuncName);
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
 * @param objSchoolYearEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function SchoolYear_AddNewRecordWithReturnKey(objSchoolYearEN: clsSchoolYearEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objSchoolYearEN.schoolYear === null || objSchoolYearEN.schoolYear === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(schoolYear_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSchoolYearEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, schoolYear_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, schoolYear_ConstructorName, strThisFuncName);
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
 * @param objSchoolYearEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function SchoolYear_UpdateRecordAsync(objSchoolYearEN: clsSchoolYearEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objSchoolYearEN.sf_UpdFldSetStr === undefined || objSchoolYearEN.sf_UpdFldSetStr === null || objSchoolYearEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objSchoolYearEN.schoolYear);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(schoolYear_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSchoolYearEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, schoolYear_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, schoolYear_ConstructorName, strThisFuncName);
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
 * @param objSchoolYearEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function SchoolYear_UpdateWithConditionAsync(objSchoolYearEN: clsSchoolYearEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objSchoolYearEN.sf_UpdFldSetStr === undefined || objSchoolYearEN.sf_UpdFldSetStr === null || objSchoolYearEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objSchoolYearEN.schoolYear);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(schoolYear_Controller, strAction);
objSchoolYearEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objSchoolYearEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, schoolYear_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, schoolYear_ConstructorName, strThisFuncName);
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
 * @param objstrSchoolYear_Cond:条件对象
 * @returns 对象列表子集
*/
export async function SchoolYear_IsExistRecord_Cache(objSchoolYear_Cond: clsSchoolYearEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrSchoolYearObjLst_Cache = await SchoolYear_GetObjLst_Cache();
if (arrSchoolYearObjLst_Cache == null) return false;
let arrSchoolYear_Sel: Array < clsSchoolYearEN > = arrSchoolYearObjLst_Cache;
if (objSchoolYear_Cond.sf_FldComparisonOp == null || objSchoolYear_Cond.sf_FldComparisonOp == "") return arrSchoolYear_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objSchoolYear_Cond.sf_FldComparisonOp);
//console.log("clsSchoolYearWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objSchoolYear_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objSchoolYear_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrSchoolYear_Sel = arrSchoolYear_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrSchoolYear_Sel = arrSchoolYear_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrSchoolYear_Sel = arrSchoolYear_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrSchoolYear_Sel = arrSchoolYear_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrSchoolYear_Sel = arrSchoolYear_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrSchoolYear_Sel = arrSchoolYear_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrSchoolYear_Sel = arrSchoolYear_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrSchoolYear_Sel = arrSchoolYear_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrSchoolYear_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objSchoolYear_Cond), schoolYear_ConstructorName, strThisFuncName);
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
export async function SchoolYear_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(schoolYear_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, schoolYear_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, schoolYear_ConstructorName, strThisFuncName);
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
 * @param strSchoolYear:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function SchoolYear_IsExist(strSchoolYear: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(schoolYear_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"SchoolYear": strSchoolYear,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, schoolYear_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, schoolYear_ConstructorName, strThisFuncName);
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
 * @param strSchoolYear:所给的关键字
 * @returns 对象
*/
export async function SchoolYear_IsExist_Cache(strSchoolYear:string) {
const strThisFuncName = "IsExist_Cache";
const arrSchoolYearObjLst_Cache = await SchoolYear_GetObjLst_Cache();
if (arrSchoolYearObjLst_Cache == null) return false;
try
{
const arrSchoolYear_Sel: Array <clsSchoolYearEN> = arrSchoolYearObjLst_Cache.filter(x => x.schoolYear == strSchoolYear);
if (arrSchoolYear_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strSchoolYear, schoolYear_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param strSchoolYear:关键字
 * @returns 是否存在?存在返回True
 **/
export async function SchoolYear_IsExistAsync(strSchoolYear: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(schoolYear_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strSchoolYear": strSchoolYear }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, schoolYear_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, schoolYear_ConstructorName, strThisFuncName);
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
export async function SchoolYear_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(schoolYear_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, schoolYear_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, schoolYear_ConstructorName, strThisFuncName);
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
 * @param objSchoolYear_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function SchoolYear_GetRecCountByCond_Cache(objSchoolYear_Cond: clsSchoolYearEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrSchoolYearObjLst_Cache = await SchoolYear_GetObjLst_Cache();
if (arrSchoolYearObjLst_Cache == null) return 0;
let arrSchoolYear_Sel: Array < clsSchoolYearEN > = arrSchoolYearObjLst_Cache;
if (objSchoolYear_Cond.sf_FldComparisonOp == null || objSchoolYear_Cond.sf_FldComparisonOp == "") return arrSchoolYear_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objSchoolYear_Cond.sf_FldComparisonOp);
//console.log("clsSchoolYearWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objSchoolYear_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrSchoolYear_Sel = arrSchoolYear_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objSchoolYear_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrSchoolYear_Sel = arrSchoolYear_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrSchoolYear_Sel = arrSchoolYear_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrSchoolYear_Sel = arrSchoolYear_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrSchoolYear_Sel = arrSchoolYear_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrSchoolYear_Sel = arrSchoolYear_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrSchoolYear_Sel = arrSchoolYear_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrSchoolYear_Sel = arrSchoolYear_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrSchoolYear_Sel = arrSchoolYear_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrSchoolYear_Sel = arrSchoolYear_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrSchoolYear_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objSchoolYear_Cond), schoolYear_ConstructorName, strThisFuncName);
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
export async function SchoolYear_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(schoolYear_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, schoolYear_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, schoolYear_ConstructorName, strThisFuncName);
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
export function SchoolYear_GetWebApiUrl(strController: string, strAction: string): string {
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
export function SchoolYear_ReFreshCache():void
{
const strThisFuncName = "ReFreshCache";

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = clsSchoolYearEN._CurrTabName;
switch (clsSchoolYearEN.CacheModeId)
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
export function SchoolYear_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clsSchoolYearEN._CurrTabName;
switch (clsSchoolYearEN.CacheModeId)
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
export async function SchoolYear_BindDdl_SchoolYearInDiv_Cache(strDivName: string, strDdlName: string )
{
const strThisFuncName = "BindDdl_SchoolYearInDiv_Cache";

const objDdl = document.getElementById(strDdlName);
if (objDdl == null)
{
const strMsg = Format("下拉框：{0} 不存在！(In BindDdl_SchoolYearInDiv)", strDdlName);
alert(strMsg);
console.error(strMsg);
throw (strMsg);
}
//为数据源于表的下拉框设置内容
//console.log("开始：BindDdl_SchoolYearInDiv_Cache");
const arrObjLst_Sel = await SchoolYear_GetObjLst_Cache();
if (arrObjLst_Sel == null) return;
BindDdl_ObjLstInDiv(strDivName, strDdlName, arrObjLst_Sel, clsSchoolYearEN.con_SchoolYear, clsSchoolYearEN.con_SchoolYearName, "学年");
}

/**
 * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function SchoolYear_CheckPropertyNew(pobjSchoolYearEN: clsSchoolYearEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (null === pobjSchoolYearEN.isVisible 
 || pobjSchoolYearEN.isVisible != null && pobjSchoolYearEN.isVisible.toString()  ===  "")
{
 throw new Error("(errid:Watl000058)字段[是否显示]不能为空(In 学年)!(clsSchoolYearBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjSchoolYearEN.schoolYear) == false && GetStrLen(pobjSchoolYearEN.schoolYear) > 10)
{
 throw new Error("(errid:Watl000059)字段[学年(schoolYear)]的长度不能超过10(In 学年(SchoolYear))!值:$(pobjSchoolYearEN.schoolYear)(clsSchoolYearBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSchoolYearEN.schoolYearName) == false && GetStrLen(pobjSchoolYearEN.schoolYearName) > 10)
{
 throw new Error("(errid:Watl000059)字段[学年名(schoolYearName)]的长度不能超过10(In 学年(SchoolYear))!值:$(pobjSchoolYearEN.schoolYearName)(clsSchoolYearBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjSchoolYearEN.schoolYear) == false && undefined !== pobjSchoolYearEN.schoolYear && tzDataType.isString(pobjSchoolYearEN.schoolYear) === false)
{
 throw new Error("(errid:Watl000060)字段[学年(schoolYear)]的值:[$(pobjSchoolYearEN.schoolYear)], 非法，应该为字符型(In 学年(SchoolYear))!(clsSchoolYearBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSchoolYearEN.schoolYearName) == false && undefined !== pobjSchoolYearEN.schoolYearName && tzDataType.isString(pobjSchoolYearEN.schoolYearName) === false)
{
 throw new Error("(errid:Watl000060)字段[学年名(schoolYearName)]的值:[$(pobjSchoolYearEN.schoolYearName)], 非法，应该为字符型(In 学年(SchoolYear))!(clsSchoolYearBL:CheckPropertyNew)");
}
if (null != pobjSchoolYearEN.isCurrentSchoolYear && undefined !== pobjSchoolYearEN.isCurrentSchoolYear && tzDataType.isBoolean(pobjSchoolYearEN.isCurrentSchoolYear) === false)
{
 throw new Error("(errid:Watl000060)字段[是否当前学年(isCurrentSchoolYear)]的值:[$(pobjSchoolYearEN.isCurrentSchoolYear)], 非法，应该为布尔型(In 学年(SchoolYear))!(clsSchoolYearBL:CheckPropertyNew)");
}
if (null != pobjSchoolYearEN.isVisible && undefined !== pobjSchoolYearEN.isVisible && tzDataType.isBoolean(pobjSchoolYearEN.isVisible) === false)
{
 throw new Error("(errid:Watl000060)字段[是否显示(isVisible)]的值:[$(pobjSchoolYearEN.isVisible)], 非法，应该为布尔型(In 学年(SchoolYear))!(clsSchoolYearBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjSchoolYearEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function SchoolYear_CheckProperty4Update (pobjSchoolYearEN: clsSchoolYearEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjSchoolYearEN.schoolYear) == false && GetStrLen(pobjSchoolYearEN.schoolYear) > 10)
{
 throw new Error("(errid:Watl000062)字段[学年(schoolYear)]的长度不能超过10(In 学年(SchoolYear))!值:$(pobjSchoolYearEN.schoolYear)(clsSchoolYearBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSchoolYearEN.schoolYearName) == false && GetStrLen(pobjSchoolYearEN.schoolYearName) > 10)
{
 throw new Error("(errid:Watl000062)字段[学年名(schoolYearName)]的长度不能超过10(In 学年(SchoolYear))!值:$(pobjSchoolYearEN.schoolYearName)(clsSchoolYearBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjSchoolYearEN.schoolYear) == false && undefined !== pobjSchoolYearEN.schoolYear && tzDataType.isString(pobjSchoolYearEN.schoolYear) === false)
{
 throw new Error("(errid:Watl000063)字段[学年(schoolYear)]的值:[$(pobjSchoolYearEN.schoolYear)], 非法，应该为字符型(In 学年(SchoolYear))!(clsSchoolYearBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSchoolYearEN.schoolYearName) == false && undefined !== pobjSchoolYearEN.schoolYearName && tzDataType.isString(pobjSchoolYearEN.schoolYearName) === false)
{
 throw new Error("(errid:Watl000063)字段[学年名(schoolYearName)]的值:[$(pobjSchoolYearEN.schoolYearName)], 非法，应该为字符型(In 学年(SchoolYear))!(clsSchoolYearBL:CheckProperty4Update)");
}
if (null != pobjSchoolYearEN.isCurrentSchoolYear && undefined !== pobjSchoolYearEN.isCurrentSchoolYear && tzDataType.isBoolean(pobjSchoolYearEN.isCurrentSchoolYear) === false)
{
 throw new Error("(errid:Watl000063)字段[是否当前学年(isCurrentSchoolYear)]的值:[$(pobjSchoolYearEN.isCurrentSchoolYear)], 非法，应该为布尔型(In 学年(SchoolYear))!(clsSchoolYearBL:CheckProperty4Update)");
}
if (null != pobjSchoolYearEN.isVisible && undefined !== pobjSchoolYearEN.isVisible && tzDataType.isBoolean(pobjSchoolYearEN.isVisible) === false)
{
 throw new Error("(errid:Watl000063)字段[是否显示(isVisible)]的值:[$(pobjSchoolYearEN.isVisible)], 非法，应该为布尔型(In 学年(SchoolYear))!(clsSchoolYearBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (IsNullOrEmpty(pobjSchoolYearEN.schoolYear) === true 
 || pobjSchoolYearEN.schoolYear.toString()  ===  "0" )
{
 throw new Error("(errid:Watl000064)字段[学年]不能为空(In 学年)!(clsSchoolYearBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjSchoolYearEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function SchoolYear_GetJSONStrByObj (pobjSchoolYearEN: clsSchoolYearEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjSchoolYearEN.sf_UpdFldSetStr = pobjSchoolYearEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjSchoolYearEN);
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
export function SchoolYear_GetObjLstByJSONStr (strJSON: string): Array<clsSchoolYearEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrSchoolYearObjLst = new Array<clsSchoolYearEN>();
if (strJSON === "")
{
return arrSchoolYearObjLst;
}
try
{
arrSchoolYearObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrSchoolYearObjLst;
}
return arrSchoolYearObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrSchoolYearObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function SchoolYear_GetObjLstByJSONObjLst (arrSchoolYearObjLstS: Array<clsSchoolYearEN>): Array<clsSchoolYearEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrSchoolYearObjLst = new Array<clsSchoolYearEN>();
for (const objInFor of arrSchoolYearObjLstS) {
const obj1 = SchoolYear_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrSchoolYearObjLst.push(obj1);
}
return arrSchoolYearObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function SchoolYear_GetObjByJSONStr (strJSON: string): clsSchoolYearEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjSchoolYearEN = new clsSchoolYearEN();
if (strJSON === "")
{
return pobjSchoolYearEN;
}
try
{
pobjSchoolYearEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjSchoolYearEN;
}
return pobjSchoolYearEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function SchoolYear_GetCombineCondition(objSchoolYear_Cond: clsSchoolYearEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objSchoolYear_Cond.dicFldComparisonOp, clsSchoolYearEN.con_SchoolYear) == true)
{
const strComparisonOp_SchoolYear:string = objSchoolYear_Cond.dicFldComparisonOp[clsSchoolYearEN.con_SchoolYear];
strWhereCond += Format(" And {0} {2} '{1}'", clsSchoolYearEN.con_SchoolYear, objSchoolYear_Cond.schoolYear, strComparisonOp_SchoolYear);
}
if (Object.prototype.hasOwnProperty.call(objSchoolYear_Cond.dicFldComparisonOp, clsSchoolYearEN.con_SchoolYearName) == true)
{
const strComparisonOp_SchoolYearName:string = objSchoolYear_Cond.dicFldComparisonOp[clsSchoolYearEN.con_SchoolYearName];
strWhereCond += Format(" And {0} {2} '{1}'", clsSchoolYearEN.con_SchoolYearName, objSchoolYear_Cond.schoolYearName, strComparisonOp_SchoolYearName);
}
if (Object.prototype.hasOwnProperty.call(objSchoolYear_Cond.dicFldComparisonOp, clsSchoolYearEN.con_IsCurrentSchoolYear) == true)
{
if (objSchoolYear_Cond.isCurrentSchoolYear == true)
{
strWhereCond += Format(" And {0} = '1'", clsSchoolYearEN.con_IsCurrentSchoolYear);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsSchoolYearEN.con_IsCurrentSchoolYear);
}
}
if (Object.prototype.hasOwnProperty.call(objSchoolYear_Cond.dicFldComparisonOp, clsSchoolYearEN.con_IsVisible) == true)
{
if (objSchoolYear_Cond.isVisible == true)
{
strWhereCond += Format(" And {0} = '1'", clsSchoolYearEN.con_IsVisible);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsSchoolYearEN.con_IsVisible);
}
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objSchoolYearENS:源对象
 * @param objSchoolYearENT:目标对象
*/
export function SchoolYear_CopyObjTo(objSchoolYearENS: clsSchoolYearEN , objSchoolYearENT: clsSchoolYearEN ): void 
{
objSchoolYearENT.schoolYear = objSchoolYearENS.schoolYear; //学年
objSchoolYearENT.schoolYearName = objSchoolYearENS.schoolYearName; //学年名
objSchoolYearENT.isCurrentSchoolYear = objSchoolYearENS.isCurrentSchoolYear; //是否当前学年
objSchoolYearENT.isVisible = objSchoolYearENS.isVisible; //是否显示
objSchoolYearENT.sf_UpdFldSetStr = objSchoolYearENS.updFldString; //sf_UpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objSchoolYearENS:源对象
 * @param objSchoolYearENT:目标对象
*/
export function SchoolYear_GetObjFromJsonObj(objSchoolYearENS: clsSchoolYearEN): clsSchoolYearEN 
{
 const objSchoolYearENT: clsSchoolYearEN = new clsSchoolYearEN();
ObjectAssign(objSchoolYearENT, objSchoolYearENS);
 return objSchoolYearENT;
}