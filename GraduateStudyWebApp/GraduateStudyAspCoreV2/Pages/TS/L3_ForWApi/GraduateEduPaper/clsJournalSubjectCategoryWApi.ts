﻿
 /**
 * 类名:clsJournalSubjectCategoryWApi
 * 表名:JournalSubjectCategory(01120931)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:49:56
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
 * 期刊学科门类(JournalSubjectCategory)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2023年03月13日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { enumComparisonOp } from "../../PubFun/enumComparisonOp.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { clsJournalSubjectCategoryEN } from "../../L0_Entity/GraduateEduPaper/clsJournalSubjectCategoryEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { tzDataType } from "../../PubFun/clsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const journalSubjectCategory_Controller = "JournalSubjectCategoryApi";
 export const journalSubjectCategory_ConstructorName = "journalSubjectCategory";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strJournalSubjectCategoryId:关键字
 * @returns 对象
 **/
export async function JournalSubjectCategory_GetObjByJournalSubjectCategoryIdAsync(strJournalSubjectCategoryId: string): Promise<clsJournalSubjectCategoryEN|null>  
{
const strThisFuncName = "GetObjByJournalSubjectCategoryIdAsync";

if (IsNullOrEmpty(strJournalSubjectCategoryId) == true)
{
  const strMsg = Format("参数:[strJournalSubjectCategoryId]不能为空！(In clsJournalSubjectCategoryWApi.GetObjByJournalSubjectCategoryIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strJournalSubjectCategoryId.length != 4)
{
const strMsg = Format("缓存分类变量:[strJournalSubjectCategoryId]的长度:[{0}]不正确！(clsJournalSubjectCategoryWApi.GetObjByJournalSubjectCategoryIdAsync)", strJournalSubjectCategoryId.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByJournalSubjectCategoryId";
const strUrl = GetWebApiUrl(journalSubjectCategory_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strJournalSubjectCategoryId": strJournalSubjectCategoryId,
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
const objJournalSubjectCategory = JournalSubjectCategory_GetObjFromJsonObj(returnObj);
return objJournalSubjectCategory;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, journalSubjectCategory_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, journalSubjectCategory_ConstructorName, strThisFuncName);
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
 * @param strJournalSubjectCategoryId:所给的关键字
 * @returns 对象
*/
export async function JournalSubjectCategory_GetObjByJournalSubjectCategoryId_Cache(strJournalSubjectCategoryId: string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByJournalSubjectCategoryId_Cache";

if (IsNullOrEmpty(strJournalSubjectCategoryId) == true)
{
  const strMsg = Format("参数:[strJournalSubjectCategoryId]不能为空！(In clsJournalSubjectCategoryWApi.GetObjByJournalSubjectCategoryId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strJournalSubjectCategoryId.length != 4)
{
const strMsg = Format("缓存分类变量:[strJournalSubjectCategoryId]的长度:[{0}]不正确！(clsJournalSubjectCategoryWApi.GetObjByJournalSubjectCategoryId_Cache)", strJournalSubjectCategoryId.length);
console.error(strMsg);
throw (strMsg);
}
const arrJournalSubjectCategoryObjLst_Cache = await JournalSubjectCategory_GetObjLst_Cache();
try
{
const arrJournalSubjectCategory_Sel: Array <clsJournalSubjectCategoryEN> = arrJournalSubjectCategoryObjLst_Cache.filter(x => 
 x.journalSubjectCategoryId == strJournalSubjectCategoryId );
let objJournalSubjectCategory: clsJournalSubjectCategoryEN;
if (arrJournalSubjectCategory_Sel.length > 0)
{
objJournalSubjectCategory = arrJournalSubjectCategory_Sel[0];
return objJournalSubjectCategory;
}
else
{
if (bolTryAsyncOnce == true)
{
const objJournalSubjectCategory_Const = await JournalSubjectCategory_GetObjByJournalSubjectCategoryIdAsync(strJournalSubjectCategoryId);
if (objJournalSubjectCategory_Const != null)
{
JournalSubjectCategory_ReFreshThisCache();
return objJournalSubjectCategory_Const;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strJournalSubjectCategoryId, journalSubjectCategory_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param strJournalSubjectCategoryId:所给的关键字
 * @returns 对象
*/
export async function JournalSubjectCategory_GetObjByJournalSubjectCategoryId_localStorage(strJournalSubjectCategoryId: string) {
const strThisFuncName = "GetObjByJournalSubjectCategoryId_localStorage";

if (IsNullOrEmpty(strJournalSubjectCategoryId) == true)
{
  const strMsg = Format("参数:[strJournalSubjectCategoryId]不能为空！(In clsJournalSubjectCategoryWApi.GetObjByJournalSubjectCategoryId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
if (strJournalSubjectCategoryId.length != 4)
{
const strMsg = Format("缓存分类变量:[strJournalSubjectCategoryId]的长度:[{0}]不正确！(clsJournalSubjectCategoryWApi.GetObjByJournalSubjectCategoryId_localStorage)", strJournalSubjectCategoryId.length);
console.error(strMsg);
throw (strMsg);
}
const strKey = Format("{0}_{1}", clsJournalSubjectCategoryEN._CurrTabName, strJournalSubjectCategoryId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objJournalSubjectCategory_Cache: clsJournalSubjectCategoryEN = JSON.parse(strTempObj);
return objJournalSubjectCategory_Cache;
}
try
{
const objJournalSubjectCategory = await JournalSubjectCategory_GetObjByJournalSubjectCategoryIdAsync(strJournalSubjectCategoryId);
if (objJournalSubjectCategory != null)
{
localStorage.setItem(strKey, JSON.stringify(objJournalSubjectCategory));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objJournalSubjectCategory;
}
return objJournalSubjectCategory;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strJournalSubjectCategoryId, journalSubjectCategory_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objJournalSubjectCategory:所给的对象
 * @returns 对象
*/
export async function JournalSubjectCategory_UpdateObjInLst_Cache(objJournalSubjectCategory: clsJournalSubjectCategoryEN) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrJournalSubjectCategoryObjLst_Cache = await JournalSubjectCategory_GetObjLst_Cache();
const obj = arrJournalSubjectCategoryObjLst_Cache.find(x => x.journalSubjectCategoryName == objJournalSubjectCategory.journalSubjectCategoryName);
if (obj != null)
{
objJournalSubjectCategory.journalSubjectCategoryId = obj.journalSubjectCategoryId;
ObjectAssign( obj, objJournalSubjectCategory);
}
else
{
arrJournalSubjectCategoryObjLst_Cache.push(objJournalSubjectCategory);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, journalSubjectCategory_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
}

/**
 * 根据关键字获取相关对象的名称属性, 从缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
 * @param strJournalSubjectCategoryId:所给的关键字
 * @returns 对象
*/
export async function JournalSubjectCategory_GetNameByJournalSubjectCategoryId_Cache(strJournalSubjectCategoryId: string) {
const strThisFuncName = "GetNameByJournalSubjectCategoryId_Cache";

if (IsNullOrEmpty(strJournalSubjectCategoryId) == true)
{
  const strMsg = Format("参数:[strJournalSubjectCategoryId]不能为空！(In clsJournalSubjectCategoryWApi.GetNameByJournalSubjectCategoryId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strJournalSubjectCategoryId.length != 4)
{
const strMsg = Format("缓存分类变量:[strJournalSubjectCategoryId]的长度:[{0}]不正确！(clsJournalSubjectCategoryWApi.GetNameByJournalSubjectCategoryId_Cache)", strJournalSubjectCategoryId.length);
console.error(strMsg);
throw (strMsg);
}
const arrJournalSubjectCategoryObjLst_Cache = await JournalSubjectCategory_GetObjLst_Cache();
if (arrJournalSubjectCategoryObjLst_Cache == null) return "";
try
{
const arrJournalSubjectCategory_Sel: Array <clsJournalSubjectCategoryEN> = arrJournalSubjectCategoryObjLst_Cache.filter(x => 
 x.journalSubjectCategoryId == strJournalSubjectCategoryId );
let objJournalSubjectCategory: clsJournalSubjectCategoryEN;
if (arrJournalSubjectCategory_Sel.length > 0)
{
objJournalSubjectCategory = arrJournalSubjectCategory_Sel[0];
return objJournalSubjectCategory.journalSubjectCategoryName;
}
else
{
return "";
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strJournalSubjectCategoryId);
console.error(strMsg);
alert(strMsg);
}
return "";
}

/**
 * 映射函数。根据表映射把输入字段值，映射成输出字段值
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
 * @param strInFldName:输入字段名
 * @param strOutFldName:输出字段名
 * @param strInValue:输入字段值
 * @returns 返回一个输出字段值
*/
export async function JournalSubjectCategory_func(strInFldName:string , strOutFldName:string , strInValue:string )
{
//const strThisFuncName = "func";

if (strInFldName != clsJournalSubjectCategoryEN.con_JournalSubjectCategoryId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsJournalSubjectCategoryEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strOutFldName, clsJournalSubjectCategoryEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strJournalSubjectCategoryId = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objJournalSubjectCategory = await JournalSubjectCategory_GetObjByJournalSubjectCategoryId_Cache(strJournalSubjectCategoryId );
if (objJournalSubjectCategory == null) return "";
if (objJournalSubjectCategory.GetFldValue(strOutFldName) == null) return "";
return objJournalSubjectCategory.GetFldValue(strOutFldName).toString();
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
export function JournalSubjectCategory_SortFun_Defa(a:clsJournalSubjectCategoryEN , b:clsJournalSubjectCategoryEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.journalSubjectCategoryId.localeCompare(b.journalSubjectCategoryId);
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
export function JournalSubjectCategory_SortFun_Defa_2Fld(a:clsJournalSubjectCategoryEN , b:clsJournalSubjectCategoryEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.journalSubjectCategoryName == b.journalSubjectCategoryName) return a.updDate.localeCompare(b.updDate);
else return a.journalSubjectCategoryName.localeCompare(b.journalSubjectCategoryName);
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
export function JournalSubjectCategory_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsJournalSubjectCategoryEN.con_JournalSubjectCategoryId:
return (a: clsJournalSubjectCategoryEN, b: clsJournalSubjectCategoryEN) => {
return a.journalSubjectCategoryId.localeCompare(b.journalSubjectCategoryId);
}
case clsJournalSubjectCategoryEN.con_JournalSubjectCategoryName:
return (a: clsJournalSubjectCategoryEN, b: clsJournalSubjectCategoryEN) => {
return a.journalSubjectCategoryName.localeCompare(b.journalSubjectCategoryName);
}
case clsJournalSubjectCategoryEN.con_UpdDate:
return (a: clsJournalSubjectCategoryEN, b: clsJournalSubjectCategoryEN) => {
if (a.updDate == null) return -1;
if (b.updDate == null) return 1;
return a.updDate.localeCompare(b.updDate);
}
case clsJournalSubjectCategoryEN.con_UpdUser:
return (a: clsJournalSubjectCategoryEN, b: clsJournalSubjectCategoryEN) => {
if (a.updUser == null) return -1;
if (b.updUser == null) return 1;
return a.updUser.localeCompare(b.updUser);
}
case clsJournalSubjectCategoryEN.con_Memo:
return (a: clsJournalSubjectCategoryEN, b: clsJournalSubjectCategoryEN) => {
if (a.memo == null) return -1;
if (b.memo == null) return 1;
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[JournalSubjectCategory]中不存在！(in ${ journalSubjectCategory_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsJournalSubjectCategoryEN.con_JournalSubjectCategoryId:
return (a: clsJournalSubjectCategoryEN, b: clsJournalSubjectCategoryEN) => {
return b.journalSubjectCategoryId.localeCompare(a.journalSubjectCategoryId);
}
case clsJournalSubjectCategoryEN.con_JournalSubjectCategoryName:
return (a: clsJournalSubjectCategoryEN, b: clsJournalSubjectCategoryEN) => {
return b.journalSubjectCategoryName.localeCompare(a.journalSubjectCategoryName);
}
case clsJournalSubjectCategoryEN.con_UpdDate:
return (a: clsJournalSubjectCategoryEN, b: clsJournalSubjectCategoryEN) => {
if (b.updDate == null) return -1;
if (a.updDate == null) return 1;
return b.updDate.localeCompare(a.updDate);
}
case clsJournalSubjectCategoryEN.con_UpdUser:
return (a: clsJournalSubjectCategoryEN, b: clsJournalSubjectCategoryEN) => {
if (b.updUser == null) return -1;
if (a.updUser == null) return 1;
return b.updUser.localeCompare(a.updUser);
}
case clsJournalSubjectCategoryEN.con_Memo:
return (a: clsJournalSubjectCategoryEN, b: clsJournalSubjectCategoryEN) => {
if (b.memo == null) return -1;
if (a.memo == null) return 1;
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[JournalSubjectCategory]中不存在！(in ${ journalSubjectCategory_ConstructorName}.${ strThisFuncName})`;
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
export async function JournalSubjectCategory_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsJournalSubjectCategoryEN.con_JournalSubjectCategoryId:
return (obj: clsJournalSubjectCategoryEN) => {
return obj.journalSubjectCategoryId === value;
}
case clsJournalSubjectCategoryEN.con_JournalSubjectCategoryName:
return (obj: clsJournalSubjectCategoryEN) => {
return obj.journalSubjectCategoryName === value;
}
case clsJournalSubjectCategoryEN.con_UpdDate:
return (obj: clsJournalSubjectCategoryEN) => {
return obj.updDate === value;
}
case clsJournalSubjectCategoryEN.con_UpdUser:
return (obj: clsJournalSubjectCategoryEN) => {
return obj.updUser === value;
}
case clsJournalSubjectCategoryEN.con_Memo:
return (obj: clsJournalSubjectCategoryEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[JournalSubjectCategory]中不存在！(in ${ journalSubjectCategory_ConstructorName}.${ strThisFuncName})`;
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
 * @returns 返回一个关键字值列表
*/
export async function JournalSubjectCategory_funcKey(strInFldName:string, strInValue: any, strComparisonOp:string): Promise<Array<string>> 
{
//const strThisFuncName = "funcKey";

if (strInFldName == clsJournalSubjectCategoryEN.con_JournalSubjectCategoryId)
{
const strMsg = Format("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (IsNullOrEmpty(strInValue) == true)
{
return [];
}
const arrJournalSubjectCategory = await JournalSubjectCategory_GetObjLst_Cache();
if (arrJournalSubjectCategory == null) return [];
let arrJournalSubjectCategory_Sel = arrJournalSubjectCategory;
const strType = typeof(strInValue);
switch (strType)
{
case "string":
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01: // " = "
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
break;
case enumComparisonOp.Like_03:
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
break;
case enumComparisonOp.In_04:
const arrValues = strInValue.split(',');
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
break;
}
break;
case "boolean":
if (strInValue == null) return [];
if (strComparisonOp == enumComparisonOp.Equal_01)
{
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
}
break;
case "number":
if (Number(strInValue) == 0) return [];
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01:
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
break;
case enumComparisonOp.NotEqual_02:
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
break;
case enumComparisonOp.NotLessThan_05://" >= ":
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
break;
case enumComparisonOp.NotGreaterThan_06://" <= ":
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
case enumComparisonOp.GreaterThan_07://" > ":
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
break;
case enumComparisonOp.LessThan_08://" < ":
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
}
break;
}
if (arrJournalSubjectCategory_Sel.length == 0) return [];
return arrJournalSubjectCategory_Sel.map(x=>x.journalSubjectCategoryId);
}

 /**
 * 根据条件获取满足条件的第一条记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
 * @param strWhereCond:条件
 * @returns 返回的第一条记录的关键字值
 **/
export async function JournalSubjectCategory_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(journalSubjectCategory_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, journalSubjectCategory_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, journalSubjectCategory_ConstructorName, strThisFuncName);
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
export async function JournalSubjectCategory_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(journalSubjectCategory_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, journalSubjectCategory_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, journalSubjectCategory_ConstructorName, strThisFuncName);
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
export async function JournalSubjectCategory_GetFirstObjAsync(strWhereCond: string): Promise<clsJournalSubjectCategoryEN|null>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(journalSubjectCategory_Controller, strAction);
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
const objJournalSubjectCategory = JournalSubjectCategory_GetObjFromJsonObj(returnObj);
return objJournalSubjectCategory;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, journalSubjectCategory_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, journalSubjectCategory_ConstructorName, strThisFuncName);
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
export async function JournalSubjectCategory_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsJournalSubjectCategoryEN._CurrTabName;
if (IsNullOrEmpty(clsJournalSubjectCategoryEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsJournalSubjectCategoryEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrJournalSubjectCategoryExObjLst_Cache: Array<clsJournalSubjectCategoryEN> = CacheHelper.Get(strKey);
const arrJournalSubjectCategoryObjLst_T = JournalSubjectCategory_GetObjLstByJSONObjLst(arrJournalSubjectCategoryExObjLst_Cache);
return arrJournalSubjectCategoryObjLst_T;
}
try
{
const arrJournalSubjectCategoryExObjLst = await JournalSubjectCategory_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrJournalSubjectCategoryExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrJournalSubjectCategoryExObjLst.length);
console.log(strInfo);
return arrJournalSubjectCategoryExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, journalSubjectCategory_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function JournalSubjectCategory_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsJournalSubjectCategoryEN._CurrTabName;
if (IsNullOrEmpty(clsJournalSubjectCategoryEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsJournalSubjectCategoryEN.CacheAddiCondition);
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
const arrJournalSubjectCategoryExObjLst_Cache: Array<clsJournalSubjectCategoryEN> = JSON.parse(strTempObjLst);
const arrJournalSubjectCategoryObjLst_T = JournalSubjectCategory_GetObjLstByJSONObjLst(arrJournalSubjectCategoryExObjLst_Cache);
return arrJournalSubjectCategoryObjLst_T;
}
try
{
const arrJournalSubjectCategoryExObjLst = await JournalSubjectCategory_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrJournalSubjectCategoryExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrJournalSubjectCategoryExObjLst.length);
console.log(strInfo);
return arrJournalSubjectCategoryExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, journalSubjectCategory_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function JournalSubjectCategory_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsJournalSubjectCategoryEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrJournalSubjectCategoryObjLst_Cache: Array<clsJournalSubjectCategoryEN> = JSON.parse(strTempObjLst);
return arrJournalSubjectCategoryObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function JournalSubjectCategory_GetObjLstAsync(strWhereCond: string): Promise<Array<clsJournalSubjectCategoryEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(journalSubjectCategory_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", journalSubjectCategory_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = JournalSubjectCategory_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, journalSubjectCategory_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, journalSubjectCategory_ConstructorName, strThisFuncName);
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
export async function JournalSubjectCategory_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsJournalSubjectCategoryEN._CurrTabName;
if (IsNullOrEmpty(clsJournalSubjectCategoryEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsJournalSubjectCategoryEN.CacheAddiCondition);
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
const arrJournalSubjectCategoryExObjLst_Cache: Array<clsJournalSubjectCategoryEN> = JSON.parse(strTempObjLst);
const arrJournalSubjectCategoryObjLst_T = JournalSubjectCategory_GetObjLstByJSONObjLst(arrJournalSubjectCategoryExObjLst_Cache);
return arrJournalSubjectCategoryObjLst_T;
}
try
{
const arrJournalSubjectCategoryExObjLst = await JournalSubjectCategory_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrJournalSubjectCategoryExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrJournalSubjectCategoryExObjLst.length);
console.log(strInfo);
return arrJournalSubjectCategoryExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, journalSubjectCategory_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function JournalSubjectCategory_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsJournalSubjectCategoryEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrJournalSubjectCategoryObjLst_Cache: Array<clsJournalSubjectCategoryEN> = JSON.parse(strTempObjLst);
return arrJournalSubjectCategoryObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function JournalSubjectCategory_GetObjLst_Cache(): Promise<Array<clsJournalSubjectCategoryEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrJournalSubjectCategoryObjLst_Cache;
switch (clsJournalSubjectCategoryEN.CacheModeId)
{
case "04"://sessionStorage
arrJournalSubjectCategoryObjLst_Cache = await JournalSubjectCategory_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrJournalSubjectCategoryObjLst_Cache = await JournalSubjectCategory_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrJournalSubjectCategoryObjLst_Cache = await JournalSubjectCategory_GetObjLst_ClientCache();
break;
default:
arrJournalSubjectCategoryObjLst_Cache = await JournalSubjectCategory_GetObjLst_ClientCache();
break;
}
const arrJournalSubjectCategoryObjLst = JournalSubjectCategory_GetObjLstByJSONObjLst(arrJournalSubjectCategoryObjLst_Cache);
return arrJournalSubjectCategoryObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function JournalSubjectCategory_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrJournalSubjectCategoryObjLst_Cache;
switch (clsJournalSubjectCategoryEN.CacheModeId)
{
case "04"://sessionStorage
arrJournalSubjectCategoryObjLst_Cache = await JournalSubjectCategory_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrJournalSubjectCategoryObjLst_Cache = await JournalSubjectCategory_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrJournalSubjectCategoryObjLst_Cache = null;
break;
default:
arrJournalSubjectCategoryObjLst_Cache = null;
break;
}
return arrJournalSubjectCategoryObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrJournalSubjectCategoryId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function JournalSubjectCategory_GetSubObjLst_Cache(objJournalSubjectCategory_Cond: clsJournalSubjectCategoryEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrJournalSubjectCategoryObjLst_Cache = await JournalSubjectCategory_GetObjLst_Cache();
let arrJournalSubjectCategory_Sel: Array < clsJournalSubjectCategoryEN > = arrJournalSubjectCategoryObjLst_Cache;
if (objJournalSubjectCategory_Cond.sf_FldComparisonOp == null || objJournalSubjectCategory_Cond.sf_FldComparisonOp == "") return arrJournalSubjectCategory_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objJournalSubjectCategory_Cond.sf_FldComparisonOp);
//console.log("clsJournalSubjectCategoryWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objJournalSubjectCategory_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objJournalSubjectCategory_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrJournalSubjectCategory_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objJournalSubjectCategory_Cond), journalSubjectCategory_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsJournalSubjectCategoryEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrJournalSubjectCategoryId:关键字列表
 * @returns 对象列表
 **/
export async function JournalSubjectCategory_GetObjLstByJournalSubjectCategoryIdLstAsync(arrJournalSubjectCategoryId: Array<string>): Promise<Array<clsJournalSubjectCategoryEN>>  
{
const strThisFuncName = "GetObjLstByJournalSubjectCategoryIdLstAsync";
const strAction = "GetObjLstByJournalSubjectCategoryIdLst";
const strUrl = GetWebApiUrl(journalSubjectCategory_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrJournalSubjectCategoryId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", journalSubjectCategory_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = JournalSubjectCategory_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, journalSubjectCategory_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, journalSubjectCategory_ConstructorName, strThisFuncName);
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
 * @param arrstrJournalSubjectCategoryIdLst:关键字列表
 * @returns 对象列表
*/
export async function JournalSubjectCategory_GetObjLstByJournalSubjectCategoryIdLst_Cache(arrJournalSubjectCategoryIdLst: Array<string>) {
const strThisFuncName = "GetObjLstByJournalSubjectCategoryIdLst_Cache";
try
{
const arrJournalSubjectCategoryObjLst_Cache = await JournalSubjectCategory_GetObjLst_Cache();
const arrJournalSubjectCategory_Sel: Array <clsJournalSubjectCategoryEN> = arrJournalSubjectCategoryObjLst_Cache.filter(x => arrJournalSubjectCategoryIdLst.indexOf(x.journalSubjectCategoryId)>-1);
return arrJournalSubjectCategory_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrJournalSubjectCategoryIdLst.join(","), journalSubjectCategory_ConstructorName, strThisFuncName);
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
export async function JournalSubjectCategory_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsJournalSubjectCategoryEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(journalSubjectCategory_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", journalSubjectCategory_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = JournalSubjectCategory_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, journalSubjectCategory_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, journalSubjectCategory_ConstructorName, strThisFuncName);
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
export async function JournalSubjectCategory_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsJournalSubjectCategoryEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(journalSubjectCategory_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", journalSubjectCategory_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = JournalSubjectCategory_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, journalSubjectCategory_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, journalSubjectCategory_ConstructorName, strThisFuncName);
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
export async function JournalSubjectCategory_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(journalSubjectCategory_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, journalSubjectCategory_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, journalSubjectCategory_ConstructorName, strThisFuncName);
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
export async function JournalSubjectCategory_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
if (objPagerPara.pageIndex == 0) return new Array<clsJournalSubjectCategoryEN>();
const arrJournalSubjectCategoryObjLst_Cache = await JournalSubjectCategory_GetObjLst_Cache();
if (arrJournalSubjectCategoryObjLst_Cache.length == 0) return arrJournalSubjectCategoryObjLst_Cache;
let arrJournalSubjectCategory_Sel = arrJournalSubjectCategoryObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objJournalSubjectCategory_Cond = new clsJournalSubjectCategoryEN();
ObjectAssign(objJournalSubjectCategory_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsJournalSubjectCategoryWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objJournalSubjectCategory_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrJournalSubjectCategory_Sel.length == 0) return arrJournalSubjectCategory_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.sort(JournalSubjectCategory_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.sort(objPagerPara.sortFun);
}
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.slice(intStart, intEnd);     
return arrJournalSubjectCategory_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, journalSubjectCategory_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsJournalSubjectCategoryEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function JournalSubjectCategory_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsJournalSubjectCategoryEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
if (objPagerPara.pageIndex == 0) return new Array<clsJournalSubjectCategoryEN>();
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(journalSubjectCategory_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", journalSubjectCategory_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = JournalSubjectCategory_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, journalSubjectCategory_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, journalSubjectCategory_ConstructorName, strThisFuncName);
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
 * @param strJournalSubjectCategoryId:关键字
 * @returns 获取删除的结果
 **/
export async function JournalSubjectCategory_DelRecordAsync(strJournalSubjectCategoryId: string): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(journalSubjectCategory_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, strJournalSubjectCategoryId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, journalSubjectCategory_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, journalSubjectCategory_ConstructorName, strThisFuncName);
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
 * @param arrJournalSubjectCategoryId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function JournalSubjectCategory_DelJournalSubjectCategorysAsync(arrJournalSubjectCategoryId: Array<string>): Promise<number> 
{
const strThisFuncName = "DelJournalSubjectCategorysAsync";
const strAction = "DelJournalSubjectCategorys";
const strUrl = GetWebApiUrl(journalSubjectCategory_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrJournalSubjectCategoryId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, journalSubjectCategory_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, journalSubjectCategory_ConstructorName, strThisFuncName);
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
export async function JournalSubjectCategory_DelJournalSubjectCategorysByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "DelJournalSubjectCategorysByCondAsync";
const strAction = "DelJournalSubjectCategorysByCond";
const strUrl = GetWebApiUrl(journalSubjectCategory_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, journalSubjectCategory_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, journalSubjectCategory_ConstructorName, strThisFuncName);
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
 * @param objJournalSubjectCategoryEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function JournalSubjectCategory_AddNewRecordAsync(objJournalSubjectCategoryEN: clsJournalSubjectCategoryEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objJournalSubjectCategoryEN);
const strUrl = GetWebApiUrl(journalSubjectCategory_Controller, strAction);
try
{
const response = await axios.post(strUrl, objJournalSubjectCategoryEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, journalSubjectCategory_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, journalSubjectCategory_ConstructorName, strThisFuncName);
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
 * @param objJournalSubjectCategoryEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function JournalSubjectCategory_AddNewRecordWithMaxIdAsync(objJournalSubjectCategoryEN: clsJournalSubjectCategoryEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithMaxIdAsync";
const strAction = "AddNewRecordWithMaxId";
const strUrl = GetWebApiUrl(journalSubjectCategory_Controller, strAction);
try
{
const response = await axios.post(strUrl, objJournalSubjectCategoryEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, journalSubjectCategory_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, journalSubjectCategory_ConstructorName, strThisFuncName);
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
 * @param objJournalSubjectCategoryEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function JournalSubjectCategory_AddNewRecordWithReturnKeyAsync(objJournalSubjectCategoryEN: clsJournalSubjectCategoryEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(journalSubjectCategory_Controller, strAction);
try
{
const response = await axios.post(strUrl, objJournalSubjectCategoryEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, journalSubjectCategory_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, journalSubjectCategory_ConstructorName, strThisFuncName);
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
 * @param objJournalSubjectCategoryEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function JournalSubjectCategory_AddNewRecordWithReturnKey(objJournalSubjectCategoryEN: clsJournalSubjectCategoryEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objJournalSubjectCategoryEN.journalSubjectCategoryId === null || objJournalSubjectCategoryEN.journalSubjectCategoryId === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(journalSubjectCategory_Controller, strAction);
try
{
const response = await axios.post(strUrl, objJournalSubjectCategoryEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, journalSubjectCategory_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, journalSubjectCategory_ConstructorName, strThisFuncName);
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
 * @param objJournalSubjectCategoryEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function JournalSubjectCategory_UpdateRecordAsync(objJournalSubjectCategoryEN: clsJournalSubjectCategoryEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objJournalSubjectCategoryEN.sfUpdFldSetStr === undefined || objJournalSubjectCategoryEN.sfUpdFldSetStr === null || objJournalSubjectCategoryEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objJournalSubjectCategoryEN.journalSubjectCategoryId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(journalSubjectCategory_Controller, strAction);
try
{
const response = await axios.post(strUrl, objJournalSubjectCategoryEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, journalSubjectCategory_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, journalSubjectCategory_ConstructorName, strThisFuncName);
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
 * @param objJournalSubjectCategoryEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function JournalSubjectCategory_UpdateWithConditionAsync(objJournalSubjectCategoryEN: clsJournalSubjectCategoryEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objJournalSubjectCategoryEN.sfUpdFldSetStr === undefined || objJournalSubjectCategoryEN.sfUpdFldSetStr === null || objJournalSubjectCategoryEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objJournalSubjectCategoryEN.journalSubjectCategoryId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(journalSubjectCategory_Controller, strAction);
objJournalSubjectCategoryEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objJournalSubjectCategoryEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, journalSubjectCategory_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, journalSubjectCategory_ConstructorName, strThisFuncName);
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
 * @param objstrJournalSubjectCategoryId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function JournalSubjectCategory_IsExistRecord_Cache(objJournalSubjectCategory_Cond: clsJournalSubjectCategoryEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrJournalSubjectCategoryObjLst_Cache = await JournalSubjectCategory_GetObjLst_Cache();
if (arrJournalSubjectCategoryObjLst_Cache == null) return false;
let arrJournalSubjectCategory_Sel: Array < clsJournalSubjectCategoryEN > = arrJournalSubjectCategoryObjLst_Cache;
if (objJournalSubjectCategory_Cond.sf_FldComparisonOp == null || objJournalSubjectCategory_Cond.sf_FldComparisonOp == "") return arrJournalSubjectCategory_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objJournalSubjectCategory_Cond.sf_FldComparisonOp);
//console.log("clsJournalSubjectCategoryWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objJournalSubjectCategory_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objJournalSubjectCategory_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrJournalSubjectCategory_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objJournalSubjectCategory_Cond), journalSubjectCategory_ConstructorName, strThisFuncName);
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
export async function JournalSubjectCategory_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(journalSubjectCategory_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, journalSubjectCategory_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, journalSubjectCategory_ConstructorName, strThisFuncName);
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
 * @param strJournalSubjectCategoryId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function JournalSubjectCategory_IsExist(strJournalSubjectCategoryId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(journalSubjectCategory_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"JournalSubjectCategoryId": strJournalSubjectCategoryId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, journalSubjectCategory_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, journalSubjectCategory_ConstructorName, strThisFuncName);
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
 * @param strJournalSubjectCategoryId:所给的关键字
 * @returns 对象
*/
export async function JournalSubjectCategory_IsExist_Cache(strJournalSubjectCategoryId:string) {
const strThisFuncName = "IsExist_Cache";
const arrJournalSubjectCategoryObjLst_Cache = await JournalSubjectCategory_GetObjLst_Cache();
if (arrJournalSubjectCategoryObjLst_Cache == null) return false;
try
{
const arrJournalSubjectCategory_Sel: Array <clsJournalSubjectCategoryEN> = arrJournalSubjectCategoryObjLst_Cache.filter(x => x.journalSubjectCategoryId == strJournalSubjectCategoryId);
if (arrJournalSubjectCategory_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strJournalSubjectCategoryId, journalSubjectCategory_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param strJournalSubjectCategoryId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function JournalSubjectCategory_IsExistAsync(strJournalSubjectCategoryId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(journalSubjectCategory_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strJournalSubjectCategoryId": strJournalSubjectCategoryId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, journalSubjectCategory_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, journalSubjectCategory_ConstructorName, strThisFuncName);
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
export async function JournalSubjectCategory_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(journalSubjectCategory_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, journalSubjectCategory_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, journalSubjectCategory_ConstructorName, strThisFuncName);
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
 * @param objJournalSubjectCategory_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function JournalSubjectCategory_GetRecCountByCond_Cache(objJournalSubjectCategory_Cond: clsJournalSubjectCategoryEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrJournalSubjectCategoryObjLst_Cache = await JournalSubjectCategory_GetObjLst_Cache();
if (arrJournalSubjectCategoryObjLst_Cache == null) return 0;
let arrJournalSubjectCategory_Sel: Array < clsJournalSubjectCategoryEN > = arrJournalSubjectCategoryObjLst_Cache;
if (objJournalSubjectCategory_Cond.sf_FldComparisonOp == null || objJournalSubjectCategory_Cond.sf_FldComparisonOp == "") return arrJournalSubjectCategory_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objJournalSubjectCategory_Cond.sf_FldComparisonOp);
//console.log("clsJournalSubjectCategoryWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objJournalSubjectCategory_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objJournalSubjectCategory_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrJournalSubjectCategory_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objJournalSubjectCategory_Cond), journalSubjectCategory_ConstructorName, strThisFuncName);
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
export async function JournalSubjectCategory_GetMaxStrIdAsync(): Promise<string>  
{
const strThisFuncName = "GetMaxStrIdAsync";
const strAction = "GetMaxStrId";
const strUrl = GetWebApiUrl(journalSubjectCategory_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, journalSubjectCategory_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, journalSubjectCategory_ConstructorName, strThisFuncName);
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
export async function JournalSubjectCategory_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(journalSubjectCategory_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, journalSubjectCategory_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, journalSubjectCategory_ConstructorName, strThisFuncName);
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
export function JournalSubjectCategory_GetWebApiUrl(strController: string, strAction: string): string {
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
export function JournalSubjectCategory_ReFreshCache():void
{
const strThisFuncName = "ReFreshCache";

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = clsJournalSubjectCategoryEN._CurrTabName;
switch (clsJournalSubjectCategoryEN.CacheModeId)
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
export function JournalSubjectCategory_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clsJournalSubjectCategoryEN._CurrTabName;
switch (clsJournalSubjectCategoryEN.CacheModeId)
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
export async function JournalSubjectCategory_BindDdl_JournalSubjectCategoryIdInDiv_Cache(strDivName: string, strDdlName: string )
{
const strThisFuncName = "BindDdl_JournalSubjectCategoryIdInDiv_Cache";

const objDdl = document.getElementById(strDdlName);
if (objDdl == null)
{
const strMsg = Format("下拉框：{0} 不存在！(In BindDdl_JournalSubjectCategoryIdInDiv)", strDdlName);
alert(strMsg);
console.error(strMsg);
throw (strMsg);
}
//为数据源于表的下拉框设置内容
//console.log("开始：BindDdl_JournalSubjectCategoryIdInDiv_Cache");
const arrObjLst_Sel = await JournalSubjectCategory_GetObjLst_Cache();
if (arrObjLst_Sel == null) return;
BindDdl_ObjLstInDiv(strDivName, strDdlName, arrObjLst_Sel, clsJournalSubjectCategoryEN.con_JournalSubjectCategoryId, clsJournalSubjectCategoryEN.con_JournalSubjectCategoryName, "期刊学科门类");
}

/**
 * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function JournalSubjectCategory_CheckPropertyNew(pobjJournalSubjectCategoryEN: clsJournalSubjectCategoryEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjJournalSubjectCategoryEN.journalSubjectCategoryName) === true )
{
 throw new Error("(errid:Watl000058)字段[期刊学科门类名称]不能为空(In 期刊学科门类)!(clsJournalSubjectCategoryBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjJournalSubjectCategoryEN.journalSubjectCategoryId) == false && GetStrLen(pobjJournalSubjectCategoryEN.journalSubjectCategoryId) > 4)
{
 throw new Error("(errid:Watl000059)字段[期刊学科门类Id(journalSubjectCategoryId)]的长度不能超过4(In 期刊学科门类(JournalSubjectCategory))!值:$(pobjJournalSubjectCategoryEN.journalSubjectCategoryId)(clsJournalSubjectCategoryBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjJournalSubjectCategoryEN.journalSubjectCategoryName) == false && GetStrLen(pobjJournalSubjectCategoryEN.journalSubjectCategoryName) > 100)
{
 throw new Error("(errid:Watl000059)字段[期刊学科门类名称(journalSubjectCategoryName)]的长度不能超过100(In 期刊学科门类(JournalSubjectCategory))!值:$(pobjJournalSubjectCategoryEN.journalSubjectCategoryName)(clsJournalSubjectCategoryBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjJournalSubjectCategoryEN.updDate) == false && GetStrLen(pobjJournalSubjectCategoryEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 期刊学科门类(JournalSubjectCategory))!值:$(pobjJournalSubjectCategoryEN.updDate)(clsJournalSubjectCategoryBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjJournalSubjectCategoryEN.updUser) == false && GetStrLen(pobjJournalSubjectCategoryEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 期刊学科门类(JournalSubjectCategory))!值:$(pobjJournalSubjectCategoryEN.updUser)(clsJournalSubjectCategoryBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjJournalSubjectCategoryEN.memo) == false && GetStrLen(pobjJournalSubjectCategoryEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 期刊学科门类(JournalSubjectCategory))!值:$(pobjJournalSubjectCategoryEN.memo)(clsJournalSubjectCategoryBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjJournalSubjectCategoryEN.journalSubjectCategoryId) == false && undefined !== pobjJournalSubjectCategoryEN.journalSubjectCategoryId && tzDataType.isString(pobjJournalSubjectCategoryEN.journalSubjectCategoryId) === false)
{
 throw new Error("(errid:Watl000060)字段[期刊学科门类Id(journalSubjectCategoryId)]的值:[$(pobjJournalSubjectCategoryEN.journalSubjectCategoryId)], 非法，应该为字符型(In 期刊学科门类(JournalSubjectCategory))!(clsJournalSubjectCategoryBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjJournalSubjectCategoryEN.journalSubjectCategoryName) == false && undefined !== pobjJournalSubjectCategoryEN.journalSubjectCategoryName && tzDataType.isString(pobjJournalSubjectCategoryEN.journalSubjectCategoryName) === false)
{
 throw new Error("(errid:Watl000060)字段[期刊学科门类名称(journalSubjectCategoryName)]的值:[$(pobjJournalSubjectCategoryEN.journalSubjectCategoryName)], 非法，应该为字符型(In 期刊学科门类(JournalSubjectCategory))!(clsJournalSubjectCategoryBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjJournalSubjectCategoryEN.updDate) == false && undefined !== pobjJournalSubjectCategoryEN.updDate && tzDataType.isString(pobjJournalSubjectCategoryEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjJournalSubjectCategoryEN.updDate)], 非法，应该为字符型(In 期刊学科门类(JournalSubjectCategory))!(clsJournalSubjectCategoryBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjJournalSubjectCategoryEN.updUser) == false && undefined !== pobjJournalSubjectCategoryEN.updUser && tzDataType.isString(pobjJournalSubjectCategoryEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjJournalSubjectCategoryEN.updUser)], 非法，应该为字符型(In 期刊学科门类(JournalSubjectCategory))!(clsJournalSubjectCategoryBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjJournalSubjectCategoryEN.memo) == false && undefined !== pobjJournalSubjectCategoryEN.memo && tzDataType.isString(pobjJournalSubjectCategoryEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjJournalSubjectCategoryEN.memo)], 非法，应该为字符型(In 期刊学科门类(JournalSubjectCategory))!(clsJournalSubjectCategoryBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjJournalSubjectCategoryEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function JournalSubjectCategory_CheckProperty4Update (pobjJournalSubjectCategoryEN: clsJournalSubjectCategoryEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjJournalSubjectCategoryEN.journalSubjectCategoryId) == false && GetStrLen(pobjJournalSubjectCategoryEN.journalSubjectCategoryId) > 4)
{
 throw new Error("(errid:Watl000062)字段[期刊学科门类Id(journalSubjectCategoryId)]的长度不能超过4(In 期刊学科门类(JournalSubjectCategory))!值:$(pobjJournalSubjectCategoryEN.journalSubjectCategoryId)(clsJournalSubjectCategoryBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjJournalSubjectCategoryEN.journalSubjectCategoryName) == false && GetStrLen(pobjJournalSubjectCategoryEN.journalSubjectCategoryName) > 100)
{
 throw new Error("(errid:Watl000062)字段[期刊学科门类名称(journalSubjectCategoryName)]的长度不能超过100(In 期刊学科门类(JournalSubjectCategory))!值:$(pobjJournalSubjectCategoryEN.journalSubjectCategoryName)(clsJournalSubjectCategoryBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjJournalSubjectCategoryEN.updDate) == false && GetStrLen(pobjJournalSubjectCategoryEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 期刊学科门类(JournalSubjectCategory))!值:$(pobjJournalSubjectCategoryEN.updDate)(clsJournalSubjectCategoryBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjJournalSubjectCategoryEN.updUser) == false && GetStrLen(pobjJournalSubjectCategoryEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 期刊学科门类(JournalSubjectCategory))!值:$(pobjJournalSubjectCategoryEN.updUser)(clsJournalSubjectCategoryBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjJournalSubjectCategoryEN.memo) == false && GetStrLen(pobjJournalSubjectCategoryEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 期刊学科门类(JournalSubjectCategory))!值:$(pobjJournalSubjectCategoryEN.memo)(clsJournalSubjectCategoryBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjJournalSubjectCategoryEN.journalSubjectCategoryId) == false && undefined !== pobjJournalSubjectCategoryEN.journalSubjectCategoryId && tzDataType.isString(pobjJournalSubjectCategoryEN.journalSubjectCategoryId) === false)
{
 throw new Error("(errid:Watl000063)字段[期刊学科门类Id(journalSubjectCategoryId)]的值:[$(pobjJournalSubjectCategoryEN.journalSubjectCategoryId)], 非法，应该为字符型(In 期刊学科门类(JournalSubjectCategory))!(clsJournalSubjectCategoryBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjJournalSubjectCategoryEN.journalSubjectCategoryName) == false && undefined !== pobjJournalSubjectCategoryEN.journalSubjectCategoryName && tzDataType.isString(pobjJournalSubjectCategoryEN.journalSubjectCategoryName) === false)
{
 throw new Error("(errid:Watl000063)字段[期刊学科门类名称(journalSubjectCategoryName)]的值:[$(pobjJournalSubjectCategoryEN.journalSubjectCategoryName)], 非法，应该为字符型(In 期刊学科门类(JournalSubjectCategory))!(clsJournalSubjectCategoryBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjJournalSubjectCategoryEN.updDate) == false && undefined !== pobjJournalSubjectCategoryEN.updDate && tzDataType.isString(pobjJournalSubjectCategoryEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjJournalSubjectCategoryEN.updDate)], 非法，应该为字符型(In 期刊学科门类(JournalSubjectCategory))!(clsJournalSubjectCategoryBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjJournalSubjectCategoryEN.updUser) == false && undefined !== pobjJournalSubjectCategoryEN.updUser && tzDataType.isString(pobjJournalSubjectCategoryEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjJournalSubjectCategoryEN.updUser)], 非法，应该为字符型(In 期刊学科门类(JournalSubjectCategory))!(clsJournalSubjectCategoryBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjJournalSubjectCategoryEN.memo) == false && undefined !== pobjJournalSubjectCategoryEN.memo && tzDataType.isString(pobjJournalSubjectCategoryEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjJournalSubjectCategoryEN.memo)], 非法，应该为字符型(In 期刊学科门类(JournalSubjectCategory))!(clsJournalSubjectCategoryBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (IsNullOrEmpty(pobjJournalSubjectCategoryEN.journalSubjectCategoryId) === true 
 || pobjJournalSubjectCategoryEN.journalSubjectCategoryId.toString()  ===  "0" )
{
 throw new Error("(errid:Watl000064)字段[期刊学科门类Id]不能为空(In 期刊学科门类)!(clsJournalSubjectCategoryBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjJournalSubjectCategoryEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function JournalSubjectCategory_GetJSONStrByObj (pobjJournalSubjectCategoryEN: clsJournalSubjectCategoryEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjJournalSubjectCategoryEN.sfUpdFldSetStr = pobjJournalSubjectCategoryEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjJournalSubjectCategoryEN);
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
export function JournalSubjectCategory_GetObjLstByJSONStr (strJSON: string): Array<clsJournalSubjectCategoryEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrJournalSubjectCategoryObjLst = new Array<clsJournalSubjectCategoryEN>();
if (strJSON === "")
{
return arrJournalSubjectCategoryObjLst;
}
try
{
arrJournalSubjectCategoryObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrJournalSubjectCategoryObjLst;
}
return arrJournalSubjectCategoryObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrJournalSubjectCategoryObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function JournalSubjectCategory_GetObjLstByJSONObjLst (arrJournalSubjectCategoryObjLstS: Array<clsJournalSubjectCategoryEN>): Array<clsJournalSubjectCategoryEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrJournalSubjectCategoryObjLst = new Array<clsJournalSubjectCategoryEN>();
for (const objInFor of arrJournalSubjectCategoryObjLstS) {
const obj1 = JournalSubjectCategory_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrJournalSubjectCategoryObjLst.push(obj1);
}
return arrJournalSubjectCategoryObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function JournalSubjectCategory_GetObjByJSONStr (strJSON: string): clsJournalSubjectCategoryEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjJournalSubjectCategoryEN = new clsJournalSubjectCategoryEN();
if (strJSON === "")
{
return pobjJournalSubjectCategoryEN;
}
try
{
pobjJournalSubjectCategoryEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjJournalSubjectCategoryEN;
}
return pobjJournalSubjectCategoryEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function JournalSubjectCategory_GetCombineCondition(objJournalSubjectCategory_Cond: clsJournalSubjectCategoryEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objJournalSubjectCategory_Cond.dicFldComparisonOp, clsJournalSubjectCategoryEN.con_JournalSubjectCategoryId) == true)
{
const strComparisonOp_JournalSubjectCategoryId:string = objJournalSubjectCategory_Cond.dicFldComparisonOp[clsJournalSubjectCategoryEN.con_JournalSubjectCategoryId];
strWhereCond += Format(" And {0} {2} '{1}'", clsJournalSubjectCategoryEN.con_JournalSubjectCategoryId, objJournalSubjectCategory_Cond.journalSubjectCategoryId, strComparisonOp_JournalSubjectCategoryId);
}
if (Object.prototype.hasOwnProperty.call(objJournalSubjectCategory_Cond.dicFldComparisonOp, clsJournalSubjectCategoryEN.con_JournalSubjectCategoryName) == true)
{
const strComparisonOp_JournalSubjectCategoryName:string = objJournalSubjectCategory_Cond.dicFldComparisonOp[clsJournalSubjectCategoryEN.con_JournalSubjectCategoryName];
strWhereCond += Format(" And {0} {2} '{1}'", clsJournalSubjectCategoryEN.con_JournalSubjectCategoryName, objJournalSubjectCategory_Cond.journalSubjectCategoryName, strComparisonOp_JournalSubjectCategoryName);
}
if (Object.prototype.hasOwnProperty.call(objJournalSubjectCategory_Cond.dicFldComparisonOp, clsJournalSubjectCategoryEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objJournalSubjectCategory_Cond.dicFldComparisonOp[clsJournalSubjectCategoryEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsJournalSubjectCategoryEN.con_UpdDate, objJournalSubjectCategory_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objJournalSubjectCategory_Cond.dicFldComparisonOp, clsJournalSubjectCategoryEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objJournalSubjectCategory_Cond.dicFldComparisonOp[clsJournalSubjectCategoryEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsJournalSubjectCategoryEN.con_UpdUser, objJournalSubjectCategory_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objJournalSubjectCategory_Cond.dicFldComparisonOp, clsJournalSubjectCategoryEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objJournalSubjectCategory_Cond.dicFldComparisonOp[clsJournalSubjectCategoryEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsJournalSubjectCategoryEN.con_Memo, objJournalSubjectCategory_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--JournalSubjectCategory(期刊学科门类),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param strJournalSubjectCategoryName: 期刊学科门类名称(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function JournalSubjectCategory_GetUniCondStr_JournalSubjectCategoryName(objJournalSubjectCategoryEN: clsJournalSubjectCategoryEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and JournalSubjectCategoryName = '{0}'", objJournalSubjectCategoryEN.journalSubjectCategoryName);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--JournalSubjectCategory(期刊学科门类),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param strJournalSubjectCategoryName: 期刊学科门类名称(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function JournalSubjectCategory_GetUniCondStr4Update_JournalSubjectCategoryName(objJournalSubjectCategoryEN: clsJournalSubjectCategoryEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and JournalSubjectCategoryId <> '{0}'", objJournalSubjectCategoryEN.journalSubjectCategoryId);
 strWhereCond +=  Format(" and JournalSubjectCategoryName = '{0}'", objJournalSubjectCategoryEN.journalSubjectCategoryName);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objJournalSubjectCategoryENS:源对象
 * @param objJournalSubjectCategoryENT:目标对象
*/
export function JournalSubjectCategory_CopyObjTo(objJournalSubjectCategoryENS: clsJournalSubjectCategoryEN , objJournalSubjectCategoryENT: clsJournalSubjectCategoryEN ): void 
{
objJournalSubjectCategoryENT.journalSubjectCategoryId = objJournalSubjectCategoryENS.journalSubjectCategoryId; //期刊学科门类Id
objJournalSubjectCategoryENT.journalSubjectCategoryName = objJournalSubjectCategoryENS.journalSubjectCategoryName; //期刊学科门类名称
objJournalSubjectCategoryENT.updDate = objJournalSubjectCategoryENS.updDate; //修改日期
objJournalSubjectCategoryENT.updUser = objJournalSubjectCategoryENS.updUser; //修改人
objJournalSubjectCategoryENT.memo = objJournalSubjectCategoryENS.memo; //备注
objJournalSubjectCategoryENT.sfUpdFldSetStr = objJournalSubjectCategoryENS.updFldString; //sfUpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objJournalSubjectCategoryENS:源对象
 * @param objJournalSubjectCategoryENT:目标对象
*/
export function JournalSubjectCategory_GetObjFromJsonObj(objJournalSubjectCategoryENS: clsJournalSubjectCategoryEN): clsJournalSubjectCategoryEN 
{
 const objJournalSubjectCategoryENT: clsJournalSubjectCategoryEN = new clsJournalSubjectCategoryEN();
ObjectAssign(objJournalSubjectCategoryENT, objJournalSubjectCategoryENS);
 return objJournalSubjectCategoryENT;
}