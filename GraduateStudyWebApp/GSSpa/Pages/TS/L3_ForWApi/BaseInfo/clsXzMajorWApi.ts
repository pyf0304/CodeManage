﻿
 /**
 * 类名:clsXzMajorWApi
 * 表名:XzMajor(01120065)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:46:07
 * 生成者:pyf
 * 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:基本信息维护(BaseInfo)
 * 框架-层名:WA_访问层(TS)(WA_Access)
 * 编程语言:TypeScript
 * 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
   *      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 **/

/**
 * 专业(XzMajor)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clsXzMajorEN } from "../../L0_Entity/BaseInfo/clsXzMajorEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { tzDataType } from "../../PubFun/jsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const xzMajor_Controller = "XzMajorApi";
 export const xzMajor_ConstructorName = "xzMajor";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strid_XzMajor:关键字
 * @returns 对象
 **/
export async function XzMajor_GetObjByid_XzMajorAsync(strid_XzMajor: string): Promise<clsXzMajorEN>  
{
const strThisFuncName = "GetObjByid_XzMajorAsync";

if (IsNullOrEmpty(strid_XzMajor) == true)
{
  const strMsg = Format("参数:[strid_XzMajor]不能为空！(In GetObjByid_XzMajorAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_XzMajor.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_XzMajor]的长度:[{0}]不正确！", strid_XzMajor.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByid_XzMajor";
const strUrl = GetWebApiUrl(xzMajor_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strid_XzMajor": strid_XzMajor,
}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObj = data.returnObj;
if (returnObj == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", xzMajor_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objXzMajor = XzMajor_GetObjFromJsonObj(returnObj);
return objXzMajor;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzMajor_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzMajor_ConstructorName, strThisFuncName);
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
 * @param strid_XzMajor:所给的关键字
 * @returns 对象
*/
export async function XzMajor_GetObjByid_XzMajor_Cache(strid_XzMajor: string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByid_XzMajor_Cache";

if (IsNullOrEmpty(strid_XzMajor) == true)
{
  const strMsg = Format("参数:[strid_XzMajor]不能为空！(In GetObjByid_XzMajor_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_XzMajor.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_XzMajor]的长度:[{0}]不正确！", strid_XzMajor.length);
console.error(strMsg);
throw (strMsg);
}
const arrXzMajorObjLst_Cache = await XzMajor_GetObjLst_Cache();
try
{
const arrXzMajor_Sel: Array <clsXzMajorEN> = arrXzMajorObjLst_Cache.filter(x => x.id_XzMajor == strid_XzMajor);
let objXzMajor: clsXzMajorEN;
if (arrXzMajor_Sel.length > 0)
{
objXzMajor = arrXzMajor_Sel[0];
return objXzMajor;
}
else
{
if (bolTryAsyncOnce == true)
{
objXzMajor = await XzMajor_GetObjByid_XzMajorAsync(strid_XzMajor);
if (objXzMajor != null)
{
XzMajor_ReFreshThisCache();
return objXzMajor;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strid_XzMajor, xzMajor_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param strid_XzMajor:所给的关键字
 * @returns 对象
*/
export async function XzMajor_GetObjByid_XzMajor_localStorage(strid_XzMajor: string) {
const strThisFuncName = "GetObjByid_XzMajor_localStorage";

if (IsNullOrEmpty(strid_XzMajor) == true)
{
  const strMsg = Format("参数:[strid_XzMajor]不能为空！(In GetObjByid_XzMajor_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_XzMajor.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_XzMajor]的长度:[{0}]不正确！", strid_XzMajor.length);
console.error(strMsg);
throw (strMsg);
}
const strKey = Format("{0}_{1}", clsXzMajorEN._CurrTabName, strid_XzMajor);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objXzMajor_Cache: clsXzMajorEN = JSON.parse(strTempObj);
return objXzMajor_Cache;
}
try
{
const objXzMajor = await XzMajor_GetObjByid_XzMajorAsync(strid_XzMajor);
if (objXzMajor != null)
{
localStorage.setItem(strKey, JSON.stringify(objXzMajor));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objXzMajor;
}
return objXzMajor;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strid_XzMajor, xzMajor_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objXzMajor:所给的对象
 * @returns 对象
*/
export async function XzMajor_UpdateObjInLst_Cache(objXzMajor: clsXzMajorEN) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrXzMajorObjLst_Cache = await XzMajor_GetObjLst_Cache();
const obj = arrXzMajorObjLst_Cache.find(x => x.id_XzMajor == objXzMajor.id_XzMajor);
if (obj != null)
{
objXzMajor.id_XzMajor = obj.id_XzMajor;
ObjectAssign( obj, objXzMajor);
}
else
{
arrXzMajorObjLst_Cache.push(objXzMajor);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, xzMajor_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
}

/**
 * 根据关键字获取相关对象的名称属性, 从缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
 * @param strid_XzMajor:所给的关键字
 * @returns 对象
*/
export async function XzMajor_GetNameByid_XzMajor_Cache(strid_XzMajor: string) {
const strThisFuncName = "GetNameByid_XzMajor_Cache";

if (IsNullOrEmpty(strid_XzMajor) == true)
{
  const strMsg = Format("参数:[strid_XzMajor]不能为空！(In GetNameByid_XzMajor_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_XzMajor.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_XzMajor]的长度:[{0}]不正确！", strid_XzMajor.length);
console.error(strMsg);
throw (strMsg);
}
const arrXzMajorObjLst_Cache = await XzMajor_GetObjLst_Cache();
if (arrXzMajorObjLst_Cache == null) return "";
try
{
const arrXzMajor_Sel: Array <clsXzMajorEN> = arrXzMajorObjLst_Cache.filter(x => x.id_XzMajor == strid_XzMajor);
let objXzMajor: clsXzMajorEN;
if (arrXzMajor_Sel.length > 0)
{
objXzMajor = arrXzMajor_Sel[0];
return objXzMajor.majorName;
}
else
{
return "";
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strid_XzMajor);
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
export async function XzMajor_func(strInFldName:string , strOutFldName:string ,  strInValue: string) 
{
//const strThisFuncName = "func";

if (strInFldName != clsXzMajorEN.con_id_XzMajor)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsXzMajorEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clsXzMajorEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strid_XzMajor = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objXzMajor = await XzMajor_GetObjByid_XzMajor_Cache(strid_XzMajor );
if (objXzMajor == null) return "";
return objXzMajor.GetFldValue(strOutFldName).toString();
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
export function XzMajor_SortFun_Defa(a:clsXzMajorEN , b:clsXzMajorEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.id_XzMajor.localeCompare(b.id_XzMajor);
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
export function XzMajor_SortFun_Defa_2Fld(a:clsXzMajorEN , b:clsXzMajorEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.majorID == b.majorID) return a.majorName.localeCompare(b.majorName);
else return a.majorID.localeCompare(b.majorID);
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
export function XzMajor_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsXzMajorEN.con_id_XzMajor:
return (a: clsXzMajorEN, b: clsXzMajorEN) => {
return a.id_XzMajor.localeCompare(b.id_XzMajor);
}
case clsXzMajorEN.con_MajorID:
return (a: clsXzMajorEN, b: clsXzMajorEN) => {
return a.majorID.localeCompare(b.majorID);
}
case clsXzMajorEN.con_MajorName:
return (a: clsXzMajorEN, b: clsXzMajorEN) => {
return a.majorName.localeCompare(b.majorName);
}
case clsXzMajorEN.con_MajorEnglishName:
return (a: clsXzMajorEN, b: clsXzMajorEN) => {
return a.majorEnglishName.localeCompare(b.majorEnglishName);
}
case clsXzMajorEN.con_MajorExplain:
return (a: clsXzMajorEN, b: clsXzMajorEN) => {
return a.majorExplain.localeCompare(b.majorExplain);
}
case clsXzMajorEN.con_MajorNationalID:
return (a: clsXzMajorEN, b: clsXzMajorEN) => {
return a.majorNationalID.localeCompare(b.majorNationalID);
}
case clsXzMajorEN.con_id_XzCollege:
return (a: clsXzMajorEN, b: clsXzMajorEN) => {
return a.id_XzCollege.localeCompare(b.id_XzCollege);
}
case clsXzMajorEN.con_id_MajorType:
return (a: clsXzMajorEN, b: clsXzMajorEN) => {
return a.id_MajorType.localeCompare(b.id_MajorType);
}
case clsXzMajorEN.con_id_DegreeType:
return (a: clsXzMajorEN, b: clsXzMajorEN) => {
return a.id_DegreeType.localeCompare(b.id_DegreeType);
}
case clsXzMajorEN.con_IsMainMajor:
return (a: clsXzMajorEN, b: clsXzMajorEN) => {
if (a.isMainMajor == true) return 1;
else return -1
}
case clsXzMajorEN.con_MajorDirection:
return (a: clsXzMajorEN, b: clsXzMajorEN) => {
return a.majorDirection.localeCompare(b.majorDirection);
}
case clsXzMajorEN.con_IsVisible:
return (a: clsXzMajorEN, b: clsXzMajorEN) => {
if (a.isVisible == true) return 1;
else return -1
}
case clsXzMajorEN.con_IsNormal:
return (a: clsXzMajorEN, b: clsXzMajorEN) => {
if (a.isNormal == true) return 1;
else return -1
}
case clsXzMajorEN.con_ModifyDate:
return (a: clsXzMajorEN, b: clsXzMajorEN) => {
return a.modifyDate.localeCompare(b.modifyDate);
}
case clsXzMajorEN.con_ModifyUserID:
return (a: clsXzMajorEN, b: clsXzMajorEN) => {
return a.modifyUserID.localeCompare(b.modifyUserID);
}
case clsXzMajorEN.con_Memo:
return (a: clsXzMajorEN, b: clsXzMajorEN) => {
return a.memo.localeCompare(b.memo);
}
case clsXzMajorEN.con_id_XzMajorShoolType:
return (a: clsXzMajorEN, b: clsXzMajorEN) => {
return a.id_XzMajorShoolType.localeCompare(b.id_XzMajorShoolType);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[XzMajor]中不存在！(in ${ xzMajor_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsXzMajorEN.con_id_XzMajor:
return (a: clsXzMajorEN, b: clsXzMajorEN) => {
return b.id_XzMajor.localeCompare(a.id_XzMajor);
}
case clsXzMajorEN.con_MajorID:
return (a: clsXzMajorEN, b: clsXzMajorEN) => {
return b.majorID.localeCompare(a.majorID);
}
case clsXzMajorEN.con_MajorName:
return (a: clsXzMajorEN, b: clsXzMajorEN) => {
return b.majorName.localeCompare(a.majorName);
}
case clsXzMajorEN.con_MajorEnglishName:
return (a: clsXzMajorEN, b: clsXzMajorEN) => {
return b.majorEnglishName.localeCompare(a.majorEnglishName);
}
case clsXzMajorEN.con_MajorExplain:
return (a: clsXzMajorEN, b: clsXzMajorEN) => {
return b.majorExplain.localeCompare(a.majorExplain);
}
case clsXzMajorEN.con_MajorNationalID:
return (a: clsXzMajorEN, b: clsXzMajorEN) => {
return b.majorNationalID.localeCompare(a.majorNationalID);
}
case clsXzMajorEN.con_id_XzCollege:
return (a: clsXzMajorEN, b: clsXzMajorEN) => {
return b.id_XzCollege.localeCompare(a.id_XzCollege);
}
case clsXzMajorEN.con_id_MajorType:
return (a: clsXzMajorEN, b: clsXzMajorEN) => {
return b.id_MajorType.localeCompare(a.id_MajorType);
}
case clsXzMajorEN.con_id_DegreeType:
return (a: clsXzMajorEN, b: clsXzMajorEN) => {
return b.id_DegreeType.localeCompare(a.id_DegreeType);
}
case clsXzMajorEN.con_IsMainMajor:
return (a: clsXzMajorEN, b: clsXzMajorEN) => {
if (b.isMainMajor == true) return 1;
else return -1
}
case clsXzMajorEN.con_MajorDirection:
return (a: clsXzMajorEN, b: clsXzMajorEN) => {
return b.majorDirection.localeCompare(a.majorDirection);
}
case clsXzMajorEN.con_IsVisible:
return (a: clsXzMajorEN, b: clsXzMajorEN) => {
if (b.isVisible == true) return 1;
else return -1
}
case clsXzMajorEN.con_IsNormal:
return (a: clsXzMajorEN, b: clsXzMajorEN) => {
if (b.isNormal == true) return 1;
else return -1
}
case clsXzMajorEN.con_ModifyDate:
return (a: clsXzMajorEN, b: clsXzMajorEN) => {
return b.modifyDate.localeCompare(a.modifyDate);
}
case clsXzMajorEN.con_ModifyUserID:
return (a: clsXzMajorEN, b: clsXzMajorEN) => {
return b.modifyUserID.localeCompare(a.modifyUserID);
}
case clsXzMajorEN.con_Memo:
return (a: clsXzMajorEN, b: clsXzMajorEN) => {
return b.memo.localeCompare(a.memo);
}
case clsXzMajorEN.con_id_XzMajorShoolType:
return (a: clsXzMajorEN, b: clsXzMajorEN) => {
return b.id_XzMajorShoolType.localeCompare(a.id_XzMajorShoolType);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[XzMajor]中不存在！(in ${ xzMajor_ConstructorName}.${ strThisFuncName})`;
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
export async function XzMajor_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsXzMajorEN.con_id_XzMajor:
return (obj: clsXzMajorEN) => {
return obj.id_XzMajor === value;
}
case clsXzMajorEN.con_MajorID:
return (obj: clsXzMajorEN) => {
return obj.majorID === value;
}
case clsXzMajorEN.con_MajorName:
return (obj: clsXzMajorEN) => {
return obj.majorName === value;
}
case clsXzMajorEN.con_MajorEnglishName:
return (obj: clsXzMajorEN) => {
return obj.majorEnglishName === value;
}
case clsXzMajorEN.con_MajorExplain:
return (obj: clsXzMajorEN) => {
return obj.majorExplain === value;
}
case clsXzMajorEN.con_MajorNationalID:
return (obj: clsXzMajorEN) => {
return obj.majorNationalID === value;
}
case clsXzMajorEN.con_id_XzCollege:
return (obj: clsXzMajorEN) => {
return obj.id_XzCollege === value;
}
case clsXzMajorEN.con_id_MajorType:
return (obj: clsXzMajorEN) => {
return obj.id_MajorType === value;
}
case clsXzMajorEN.con_id_DegreeType:
return (obj: clsXzMajorEN) => {
return obj.id_DegreeType === value;
}
case clsXzMajorEN.con_IsMainMajor:
return (obj: clsXzMajorEN) => {
return obj.isMainMajor === value;
}
case clsXzMajorEN.con_MajorDirection:
return (obj: clsXzMajorEN) => {
return obj.majorDirection === value;
}
case clsXzMajorEN.con_IsVisible:
return (obj: clsXzMajorEN) => {
return obj.isVisible === value;
}
case clsXzMajorEN.con_IsNormal:
return (obj: clsXzMajorEN) => {
return obj.isNormal === value;
}
case clsXzMajorEN.con_ModifyDate:
return (obj: clsXzMajorEN) => {
return obj.modifyDate === value;
}
case clsXzMajorEN.con_ModifyUserID:
return (obj: clsXzMajorEN) => {
return obj.modifyUserID === value;
}
case clsXzMajorEN.con_Memo:
return (obj: clsXzMajorEN) => {
return obj.memo === value;
}
case clsXzMajorEN.con_id_XzMajorShoolType:
return (obj: clsXzMajorEN) => {
return obj.id_XzMajorShoolType === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[XzMajor]中不存在！(in ${ xzMajor_ConstructorName}.${ strThisFuncName})`;
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
export async function XzMajor_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(xzMajor_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzMajor_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzMajor_ConstructorName, strThisFuncName);
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
export async function XzMajor_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(xzMajor_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzMajor_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzMajor_ConstructorName, strThisFuncName);
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
export async function XzMajor_GetFirstObjAsync(strWhereCond: string): Promise<clsXzMajorEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(xzMajor_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", xzMajor_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objXzMajor = XzMajor_GetObjFromJsonObj(returnObj);
return objXzMajor;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzMajor_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzMajor_ConstructorName, strThisFuncName);
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
export async function XzMajor_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsXzMajorEN._CurrTabName;
clsXzMajorEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsXzMajorEN._CurrTabName);
if (IsNullOrEmpty(clsXzMajorEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsXzMajorEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrXzMajorExObjLst_Cache: Array<clsXzMajorEN> = CacheHelper.Get(strKey);
const arrXzMajorObjLst_T = XzMajor_GetObjLstByJSONObjLst(arrXzMajorExObjLst_Cache);
return arrXzMajorObjLst_T;
}
try
{
const arrXzMajorExObjLst = await XzMajor_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrXzMajorExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrXzMajorExObjLst.length);
console.log(strInfo);
return arrXzMajorExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, xzMajor_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function XzMajor_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsXzMajorEN._CurrTabName;
clsXzMajorEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsXzMajorEN._CurrTabName);
if (IsNullOrEmpty(clsXzMajorEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsXzMajorEN.CacheAddiCondition);
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
const arrXzMajorExObjLst_Cache: Array<clsXzMajorEN> = JSON.parse(strTempObjLst);
const arrXzMajorObjLst_T = XzMajor_GetObjLstByJSONObjLst(arrXzMajorExObjLst_Cache);
return arrXzMajorObjLst_T;
}
try
{
const arrXzMajorExObjLst = await XzMajor_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrXzMajorExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrXzMajorExObjLst.length);
console.log(strInfo);
return arrXzMajorExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, xzMajor_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function XzMajor_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsXzMajorEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrXzMajorObjLst_Cache: Array<clsXzMajorEN> = JSON.parse(strTempObjLst);
return arrXzMajorObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function XzMajor_GetObjLstAsync(strWhereCond: string): Promise<Array<clsXzMajorEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(xzMajor_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", xzMajor_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = XzMajor_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzMajor_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzMajor_ConstructorName, strThisFuncName);
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
export async function XzMajor_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsXzMajorEN._CurrTabName;
clsXzMajorEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsXzMajorEN._CurrTabName);
if (IsNullOrEmpty(clsXzMajorEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsXzMajorEN.CacheAddiCondition);
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
const arrXzMajorExObjLst_Cache: Array<clsXzMajorEN> = JSON.parse(strTempObjLst);
const arrXzMajorObjLst_T = XzMajor_GetObjLstByJSONObjLst(arrXzMajorExObjLst_Cache);
return arrXzMajorObjLst_T;
}
try
{
const arrXzMajorExObjLst = await XzMajor_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrXzMajorExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrXzMajorExObjLst.length);
console.log(strInfo);
return arrXzMajorExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, xzMajor_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function XzMajor_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsXzMajorEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrXzMajorObjLst_Cache: Array<clsXzMajorEN> = JSON.parse(strTempObjLst);
return arrXzMajorObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function XzMajor_GetObjLst_Cache(): Promise<Array<clsXzMajorEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrXzMajorObjLst_Cache;
switch (clsXzMajorEN.CacheModeId)
{
case "04"://sessionStorage
arrXzMajorObjLst_Cache = await XzMajor_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrXzMajorObjLst_Cache = await XzMajor_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrXzMajorObjLst_Cache = await XzMajor_GetObjLst_ClientCache();
break;
default:
arrXzMajorObjLst_Cache = await XzMajor_GetObjLst_ClientCache();
break;
}
const arrXzMajorObjLst = XzMajor_GetObjLstByJSONObjLst(arrXzMajorObjLst_Cache);
return arrXzMajorObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function XzMajor_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrXzMajorObjLst_Cache;
switch (clsXzMajorEN.CacheModeId)
{
case "04"://sessionStorage
arrXzMajorObjLst_Cache = await XzMajor_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrXzMajorObjLst_Cache = await XzMajor_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrXzMajorObjLst_Cache = null;
break;
default:
arrXzMajorObjLst_Cache = null;
break;
}
return arrXzMajorObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrid_XzMajor_Cond:条件对象
 * @returns 对象列表子集
*/
export async function XzMajor_GetSubObjLst_Cache(objXzMajor_Cond: clsXzMajorEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrXzMajorObjLst_Cache = await XzMajor_GetObjLst_Cache();
let arrXzMajor_Sel: Array < clsXzMajorEN > = arrXzMajorObjLst_Cache;
if (objXzMajor_Cond.sf_FldComparisonOp == null || objXzMajor_Cond.sf_FldComparisonOp == "") return arrXzMajor_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objXzMajor_Cond.sf_FldComparisonOp);
//console.log("clsXzMajorWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objXzMajor_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objXzMajor_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrXzMajor_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objXzMajor_Cond), xzMajor_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsXzMajorEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrid_XzMajor:关键字列表
 * @returns 对象列表
 **/
export async function XzMajor_GetObjLstByid_XzMajorLstAsync(arrid_XzMajor: Array<string>): Promise<Array<clsXzMajorEN>>  
{
const strThisFuncName = "GetObjLstByid_XzMajorLstAsync";
const strAction = "GetObjLstByid_XzMajorLst";
const strUrl = GetWebApiUrl(xzMajor_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrid_XzMajor);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", xzMajor_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = XzMajor_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzMajor_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzMajor_ConstructorName, strThisFuncName);
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
 * @param arrstrid_XzMajorLst:关键字列表
 * @returns 对象列表
*/
export async function XzMajor_GetObjLstByid_XzMajorLst_Cache(arrid_XzMajorLst: Array<string>) {
const strThisFuncName = "GetObjLstByid_XzMajorLst_Cache";
try
{
const arrXzMajorObjLst_Cache = await XzMajor_GetObjLst_Cache();
const arrXzMajor_Sel: Array <clsXzMajorEN> = arrXzMajorObjLst_Cache.filter(x => arrid_XzMajorLst.indexOf(x.id_XzMajor)>-1);
return arrXzMajor_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrid_XzMajorLst.join(","), xzMajor_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsXzMajorEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function XzMajor_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsXzMajorEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(xzMajor_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", xzMajor_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = XzMajor_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzMajor_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzMajor_ConstructorName, strThisFuncName);
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
export async function XzMajor_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsXzMajorEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(xzMajor_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", xzMajor_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = XzMajor_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzMajor_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzMajor_ConstructorName, strThisFuncName);
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
export async function XzMajor_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(xzMajor_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzMajor_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzMajor_ConstructorName, strThisFuncName);
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
export async function XzMajor_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrXzMajorObjLst_Cache = await XzMajor_GetObjLst_Cache();
if (arrXzMajorObjLst_Cache.length == 0) return arrXzMajorObjLst_Cache;
let arrXzMajor_Sel = arrXzMajorObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objXzMajor_Cond = new clsXzMajorEN();
ObjectAssign(objXzMajor_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsXzMajorWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objXzMajor_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrXzMajor_Sel = arrXzMajor_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrXzMajor_Sel.length == 0) return arrXzMajor_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrXzMajor_Sel = arrXzMajor_Sel.sort(XzMajor_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrXzMajor_Sel = arrXzMajor_Sel.sort(objPagerPara.sortFun);
}
arrXzMajor_Sel = arrXzMajor_Sel.slice(intStart, intEnd);     
return arrXzMajor_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, xzMajor_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsXzMajorEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function XzMajor_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsXzMajorEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(xzMajor_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", xzMajor_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = XzMajor_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzMajor_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzMajor_ConstructorName, strThisFuncName);
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
 * @param strid_XzMajor:关键字
 * @returns 获取删除的结果
 **/
export async function XzMajor_DelRecordAsync(strid_XzMajor: string): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(xzMajor_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, strid_XzMajor);
try
{
const response = await axios.delete(strUrl,
{
params: { "Id": strid_XzMajor, }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzMajor_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzMajor_ConstructorName, strThisFuncName);
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
 * @param arrid_XzMajor:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function XzMajor_DelXzMajorsAsync(arrid_XzMajor: Array<string>): Promise<number> 
{
const strThisFuncName = "DelXzMajorsAsync";
const strAction = "DelXzMajors";
const strUrl = GetWebApiUrl(xzMajor_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrid_XzMajor);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzMajor_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzMajor_ConstructorName, strThisFuncName);
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
export async function XzMajor_DelXzMajorsByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "DelXzMajorsByCondAsync";
const strAction = "DelXzMajorsByCond";
const strUrl = GetWebApiUrl(xzMajor_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzMajor_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzMajor_ConstructorName, strThisFuncName);
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
 * @param objXzMajorEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function XzMajor_AddNewRecordAsync(objXzMajorEN: clsXzMajorEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objXzMajorEN);
const strUrl = GetWebApiUrl(xzMajor_Controller, strAction);
try
{
const response = await axios.post(strUrl, objXzMajorEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzMajor_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzMajor_ConstructorName, strThisFuncName);
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
 * @param objXzMajorEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function XzMajor_AddNewRecordWithMaxIdAsync(objXzMajorEN: clsXzMajorEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithMaxIdAsync";
const strAction = "AddNewRecordWithMaxId";
const strUrl = GetWebApiUrl(xzMajor_Controller, strAction);
try
{
const response = await axios.post(strUrl, objXzMajorEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzMajor_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzMajor_ConstructorName, strThisFuncName);
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
 * @param objXzMajorEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function XzMajor_AddNewRecordWithReturnKeyAsync(objXzMajorEN: clsXzMajorEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(xzMajor_Controller, strAction);
try
{
const response = await axios.post(strUrl, objXzMajorEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzMajor_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzMajor_ConstructorName, strThisFuncName);
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
 * @param objXzMajorEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function XzMajor_AddNewRecordWithReturnKey(objXzMajorEN: clsXzMajorEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objXzMajorEN.id_XzMajor === null || objXzMajorEN.id_XzMajor === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(xzMajor_Controller, strAction);
try
{
const response = await axios.post(strUrl, objXzMajorEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzMajor_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzMajor_ConstructorName, strThisFuncName);
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
 * @param objXzMajorEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function XzMajor_UpdateRecordAsync(objXzMajorEN: clsXzMajorEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objXzMajorEN.sf_UpdFldSetStr === undefined || objXzMajorEN.sf_UpdFldSetStr === null || objXzMajorEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objXzMajorEN.id_XzMajor);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(xzMajor_Controller, strAction);
try
{
const response = await axios.post(strUrl, objXzMajorEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzMajor_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzMajor_ConstructorName, strThisFuncName);
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
 * @param objXzMajorEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function XzMajor_UpdateWithConditionAsync(objXzMajorEN: clsXzMajorEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objXzMajorEN.sf_UpdFldSetStr === undefined || objXzMajorEN.sf_UpdFldSetStr === null || objXzMajorEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objXzMajorEN.id_XzMajor);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(xzMajor_Controller, strAction);
objXzMajorEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objXzMajorEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzMajor_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzMajor_ConstructorName, strThisFuncName);
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
 * @param objstrid_XzMajor_Cond:条件对象
 * @returns 对象列表子集
*/
export async function XzMajor_IsExistRecord_Cache(objXzMajor_Cond: clsXzMajorEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrXzMajorObjLst_Cache = await XzMajor_GetObjLst_Cache();
if (arrXzMajorObjLst_Cache == null) return false;
let arrXzMajor_Sel: Array < clsXzMajorEN > = arrXzMajorObjLst_Cache;
if (objXzMajor_Cond.sf_FldComparisonOp == null || objXzMajor_Cond.sf_FldComparisonOp == "") return arrXzMajor_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objXzMajor_Cond.sf_FldComparisonOp);
//console.log("clsXzMajorWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objXzMajor_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objXzMajor_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrXzMajor_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objXzMajor_Cond), xzMajor_ConstructorName, strThisFuncName);
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
export async function XzMajor_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(xzMajor_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzMajor_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzMajor_ConstructorName, strThisFuncName);
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
 * @param strid_XzMajor:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function XzMajor_IsExist(strid_XzMajor: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(xzMajor_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"id_XzMajor": strid_XzMajor,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzMajor_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzMajor_ConstructorName, strThisFuncName);
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
 * @param strid_XzMajor:所给的关键字
 * @returns 对象
*/
export async function XzMajor_IsExist_Cache(strid_XzMajor:string) {
const strThisFuncName = "IsExist_Cache";
const arrXzMajorObjLst_Cache = await XzMajor_GetObjLst_Cache();
if (arrXzMajorObjLst_Cache == null) return false;
try
{
const arrXzMajor_Sel: Array <clsXzMajorEN> = arrXzMajorObjLst_Cache.filter(x => x.id_XzMajor == strid_XzMajor);
if (arrXzMajor_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strid_XzMajor, xzMajor_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param strid_XzMajor:关键字
 * @returns 是否存在?存在返回True
 **/
export async function XzMajor_IsExistAsync(strid_XzMajor: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(xzMajor_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strid_XzMajor": strid_XzMajor }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzMajor_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzMajor_ConstructorName, strThisFuncName);
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
export async function XzMajor_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(xzMajor_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzMajor_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzMajor_ConstructorName, strThisFuncName);
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
 * @param objXzMajor_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function XzMajor_GetRecCountByCond_Cache(objXzMajor_Cond: clsXzMajorEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrXzMajorObjLst_Cache = await XzMajor_GetObjLst_Cache();
if (arrXzMajorObjLst_Cache == null) return 0;
let arrXzMajor_Sel: Array < clsXzMajorEN > = arrXzMajorObjLst_Cache;
if (objXzMajor_Cond.sf_FldComparisonOp == null || objXzMajor_Cond.sf_FldComparisonOp == "") return arrXzMajor_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objXzMajor_Cond.sf_FldComparisonOp);
//console.log("clsXzMajorWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objXzMajor_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objXzMajor_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrXzMajor_Sel = arrXzMajor_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrXzMajor_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objXzMajor_Cond), xzMajor_ConstructorName, strThisFuncName);
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
export async function XzMajor_GetMaxStrIdAsync(): Promise<string>  
{
const strThisFuncName = "GetMaxStrIdAsync";
const strAction = "GetMaxStrId";
const strUrl = GetWebApiUrl(xzMajor_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzMajor_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzMajor_ConstructorName, strThisFuncName);
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
export async function XzMajor_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(xzMajor_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzMajor_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzMajor_ConstructorName, strThisFuncName);
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
export function XzMajor_GetWebApiUrl(strController: string, strAction: string): string {
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
export function XzMajor_ReFreshCache():void
{
const strThisFuncName = "ReFreshCache";

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = clsXzMajorEN._CurrTabName;
switch (clsXzMajorEN.CacheModeId)
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
export function XzMajor_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clsXzMajorEN._CurrTabName;
switch (clsXzMajorEN.CacheModeId)
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
 * @param strid_XzMajorShoolType:专业学校类型流水号
*/
export async function XzMajor_BindDdl_id_XzMajorByid_XzMajorShoolTypeInDiv_Cache(strDivName: string, strDdlName: string , strid_XzMajorShoolType: string)
{
const strThisFuncName = "BindDdl_id_XzMajorByid_XzMajorShoolTypeInDiv_Cache";

if (IsNullOrEmpty(strid_XzMajorShoolType) == true)
{
  const strMsg = Format("参数:[strid_XzMajorShoolType]不能为空！(In BindDdl_id_XzMajorByid_XzMajorShoolTypeInDiv)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_XzMajorShoolType.length != 4)
{
const strMsg = Format("缓存分类变量:[strid_XzMajorShoolType]的长度:[{0}]不正确！", strid_XzMajorShoolType.length);
console.error(strMsg);
throw (strMsg);
}

const objDdl = document.getElementById(strDdlName);
if (objDdl == null)
{
const strMsg = Format("下拉框：{0} 不存在！(In BindDdl_id_XzMajorByid_XzMajorShoolTypeInDiv)", strDdlName);
alert(strMsg);
console.error(strMsg);
throw (strMsg);
}
//为数据源于表的下拉框设置内容
//console.log("开始：BindDdl_id_XzMajorByid_XzMajorShoolTypeInDiv_Cache");
let arrObjLst_Sel = await XzMajor_GetObjLst_Cache();
if (arrObjLst_Sel == null) return;
arrObjLst_Sel = arrObjLst_Sel.filter(x=>x.id_XzMajorShoolType == strid_XzMajorShoolType);
BindDdl_ObjLstInDiv(strDivName, strDdlName, arrObjLst_Sel, clsXzMajorEN.con_id_XzMajor, clsXzMajorEN.con_MajorName, "专业");
}
/**
 * 绑定基于Web的下拉框,在某一层下的下拉框
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
 * @param objDDL:需要绑定当前表的下拉框
*/
export async function XzMajor_BindDdl_id_XzMajor_Cache(strDivName: string, strDdlName: string )
{
const strThisFuncName = "BindDdl_id_XzMajor_Cache";

const objDdl = document.getElementById(strDdlName);
if (objDdl == null)
{
const strMsg = Format("下拉框：{0} 不存在！(In BindDdl_id_XzMajor)", strDdlName);
alert(strMsg);
console.error(strMsg);
throw (strMsg);
}
//为数据源于表的下拉框设置内容
//console.log("开始：BindDdl_id_XzMajor_Cache");
const arrObjLst_Sel = await XzMajor_GetObjLst_Cache();
if (arrObjLst_Sel == null) return;
BindDdl_ObjLstInDiv(strDivName, strDdlName, arrObjLst_Sel, clsXzMajorEN.con_id_XzMajor, clsXzMajorEN.con_MajorName, "专业");
}

/**
 * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function XzMajor_CheckPropertyNew(pobjXzMajorEN: clsXzMajorEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjXzMajorEN.majorID) === true )
{
 throw new Error("(errid:Watl000058)字段[专业ID]不能为空(In 专业)!(clsXzMajorBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzMajorEN.majorName) === true )
{
 throw new Error("(errid:Watl000058)字段[专业名称]不能为空(In 专业)!(clsXzMajorBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzMajorEN.id_XzCollege) === true 
 || pobjXzMajorEN.id_XzCollege.toString()  ===  "0" )
{
 throw new Error("(errid:Watl000058)字段[学院流水号]不能为空(In 专业)!(clsXzMajorBL:CheckPropertyNew)");
}
if (null === pobjXzMajorEN.isVisible 
 || pobjXzMajorEN.isVisible != null && pobjXzMajorEN.isVisible.toString()  ===  "")
{
 throw new Error("(errid:Watl000058)字段[是否显示]不能为空(In 专业)!(clsXzMajorBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjXzMajorEN.id_XzMajor) == false && GetStrLen(pobjXzMajorEN.id_XzMajor) > 8)
{
 throw new Error("(errid:Watl000059)字段[专业流水号(id_XzMajor)]的长度不能超过8(In 专业(XzMajor))!值:$(pobjXzMajorEN.id_XzMajor)(clsXzMajorBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzMajorEN.majorID) == false && GetStrLen(pobjXzMajorEN.majorID) > 4)
{
 throw new Error("(errid:Watl000059)字段[专业ID(majorID)]的长度不能超过4(In 专业(XzMajor))!值:$(pobjXzMajorEN.majorID)(clsXzMajorBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzMajorEN.majorName) == false && GetStrLen(pobjXzMajorEN.majorName) > 100)
{
 throw new Error("(errid:Watl000059)字段[专业名称(majorName)]的长度不能超过100(In 专业(XzMajor))!值:$(pobjXzMajorEN.majorName)(clsXzMajorBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzMajorEN.majorEnglishName) == false && GetStrLen(pobjXzMajorEN.majorEnglishName) > 200)
{
 throw new Error("(errid:Watl000059)字段[专业英文名称(majorEnglishName)]的长度不能超过200(In 专业(XzMajor))!值:$(pobjXzMajorEN.majorEnglishName)(clsXzMajorBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzMajorEN.majorExplain) == false && GetStrLen(pobjXzMajorEN.majorExplain) > 2000)
{
 throw new Error("(errid:Watl000059)字段[专业说明(majorExplain)]的长度不能超过2000(In 专业(XzMajor))!值:$(pobjXzMajorEN.majorExplain)(clsXzMajorBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzMajorEN.majorNationalID) == false && GetStrLen(pobjXzMajorEN.majorNationalID) > 10)
{
 throw new Error("(errid:Watl000059)字段[专业国家代码(majorNationalID)]的长度不能超过10(In 专业(XzMajor))!值:$(pobjXzMajorEN.majorNationalID)(clsXzMajorBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzMajorEN.id_XzCollege) == false && GetStrLen(pobjXzMajorEN.id_XzCollege) > 4)
{
 throw new Error("(errid:Watl000059)字段[学院流水号(id_XzCollege)]的长度不能超过4(In 专业(XzMajor))!值:$(pobjXzMajorEN.id_XzCollege)(clsXzMajorBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzMajorEN.id_MajorType) == false && GetStrLen(pobjXzMajorEN.id_MajorType) > 4)
{
 throw new Error("(errid:Watl000059)字段[专业类型(文理工)流水号(id_MajorType)]的长度不能超过4(In 专业(XzMajor))!值:$(pobjXzMajorEN.id_MajorType)(clsXzMajorBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzMajorEN.id_DegreeType) == false && GetStrLen(pobjXzMajorEN.id_DegreeType) > 4)
{
 throw new Error("(errid:Watl000059)字段[学位类型流水号(id_DegreeType)]的长度不能超过4(In 专业(XzMajor))!值:$(pobjXzMajorEN.id_DegreeType)(clsXzMajorBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzMajorEN.majorDirection) == false && GetStrLen(pobjXzMajorEN.majorDirection) > 30)
{
 throw new Error("(errid:Watl000059)字段[专业方向(majorDirection)]的长度不能超过30(In 专业(XzMajor))!值:$(pobjXzMajorEN.majorDirection)(clsXzMajorBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzMajorEN.modifyDate) == false && GetStrLen(pobjXzMajorEN.modifyDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(modifyDate)]的长度不能超过20(In 专业(XzMajor))!值:$(pobjXzMajorEN.modifyDate)(clsXzMajorBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzMajorEN.modifyUserID) == false && GetStrLen(pobjXzMajorEN.modifyUserID) > 18)
{
 throw new Error("(errid:Watl000059)字段[修改人(modifyUserID)]的长度不能超过18(In 专业(XzMajor))!值:$(pobjXzMajorEN.modifyUserID)(clsXzMajorBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzMajorEN.memo) == false && GetStrLen(pobjXzMajorEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 专业(XzMajor))!值:$(pobjXzMajorEN.memo)(clsXzMajorBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzMajorEN.id_XzMajorShoolType) == false && GetStrLen(pobjXzMajorEN.id_XzMajorShoolType) > 4)
{
 throw new Error("(errid:Watl000059)字段[专业学校类型流水号(id_XzMajorShoolType)]的长度不能超过4(In 专业(XzMajor))!值:$(pobjXzMajorEN.id_XzMajorShoolType)(clsXzMajorBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjXzMajorEN.id_XzMajor) == false && undefined !== pobjXzMajorEN.id_XzMajor && tzDataType.isString(pobjXzMajorEN.id_XzMajor) === false)
{
 throw new Error("(errid:Watl000060)字段[专业流水号(id_XzMajor)]的值:[$(pobjXzMajorEN.id_XzMajor)], 非法，应该为字符型(In 专业(XzMajor))!(clsXzMajorBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzMajorEN.majorID) == false && undefined !== pobjXzMajorEN.majorID && tzDataType.isString(pobjXzMajorEN.majorID) === false)
{
 throw new Error("(errid:Watl000060)字段[专业ID(majorID)]的值:[$(pobjXzMajorEN.majorID)], 非法，应该为字符型(In 专业(XzMajor))!(clsXzMajorBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzMajorEN.majorName) == false && undefined !== pobjXzMajorEN.majorName && tzDataType.isString(pobjXzMajorEN.majorName) === false)
{
 throw new Error("(errid:Watl000060)字段[专业名称(majorName)]的值:[$(pobjXzMajorEN.majorName)], 非法，应该为字符型(In 专业(XzMajor))!(clsXzMajorBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzMajorEN.majorEnglishName) == false && undefined !== pobjXzMajorEN.majorEnglishName && tzDataType.isString(pobjXzMajorEN.majorEnglishName) === false)
{
 throw new Error("(errid:Watl000060)字段[专业英文名称(majorEnglishName)]的值:[$(pobjXzMajorEN.majorEnglishName)], 非法，应该为字符型(In 专业(XzMajor))!(clsXzMajorBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzMajorEN.majorExplain) == false && undefined !== pobjXzMajorEN.majorExplain && tzDataType.isString(pobjXzMajorEN.majorExplain) === false)
{
 throw new Error("(errid:Watl000060)字段[专业说明(majorExplain)]的值:[$(pobjXzMajorEN.majorExplain)], 非法，应该为字符型(In 专业(XzMajor))!(clsXzMajorBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzMajorEN.majorNationalID) == false && undefined !== pobjXzMajorEN.majorNationalID && tzDataType.isString(pobjXzMajorEN.majorNationalID) === false)
{
 throw new Error("(errid:Watl000060)字段[专业国家代码(majorNationalID)]的值:[$(pobjXzMajorEN.majorNationalID)], 非法，应该为字符型(In 专业(XzMajor))!(clsXzMajorBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzMajorEN.id_XzCollege) == false && undefined !== pobjXzMajorEN.id_XzCollege && tzDataType.isString(pobjXzMajorEN.id_XzCollege) === false)
{
 throw new Error("(errid:Watl000060)字段[学院流水号(id_XzCollege)]的值:[$(pobjXzMajorEN.id_XzCollege)], 非法，应该为字符型(In 专业(XzMajor))!(clsXzMajorBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzMajorEN.id_MajorType) == false && undefined !== pobjXzMajorEN.id_MajorType && tzDataType.isString(pobjXzMajorEN.id_MajorType) === false)
{
 throw new Error("(errid:Watl000060)字段[专业类型(文理工)流水号(id_MajorType)]的值:[$(pobjXzMajorEN.id_MajorType)], 非法，应该为字符型(In 专业(XzMajor))!(clsXzMajorBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzMajorEN.id_DegreeType) == false && undefined !== pobjXzMajorEN.id_DegreeType && tzDataType.isString(pobjXzMajorEN.id_DegreeType) === false)
{
 throw new Error("(errid:Watl000060)字段[学位类型流水号(id_DegreeType)]的值:[$(pobjXzMajorEN.id_DegreeType)], 非法，应该为字符型(In 专业(XzMajor))!(clsXzMajorBL:CheckPropertyNew)");
}
if (null != pobjXzMajorEN.isMainMajor && undefined !== pobjXzMajorEN.isMainMajor && tzDataType.isBoolean(pobjXzMajorEN.isMainMajor) === false)
{
 throw new Error("(errid:Watl000060)字段[是否重要专业(isMainMajor)]的值:[$(pobjXzMajorEN.isMainMajor)], 非法，应该为布尔型(In 专业(XzMajor))!(clsXzMajorBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzMajorEN.majorDirection) == false && undefined !== pobjXzMajorEN.majorDirection && tzDataType.isString(pobjXzMajorEN.majorDirection) === false)
{
 throw new Error("(errid:Watl000060)字段[专业方向(majorDirection)]的值:[$(pobjXzMajorEN.majorDirection)], 非法，应该为字符型(In 专业(XzMajor))!(clsXzMajorBL:CheckPropertyNew)");
}
if (null != pobjXzMajorEN.isVisible && undefined !== pobjXzMajorEN.isVisible && tzDataType.isBoolean(pobjXzMajorEN.isVisible) === false)
{
 throw new Error("(errid:Watl000060)字段[是否显示(isVisible)]的值:[$(pobjXzMajorEN.isVisible)], 非法，应该为布尔型(In 专业(XzMajor))!(clsXzMajorBL:CheckPropertyNew)");
}
if (null != pobjXzMajorEN.isNormal && undefined !== pobjXzMajorEN.isNormal && tzDataType.isBoolean(pobjXzMajorEN.isNormal) === false)
{
 throw new Error("(errid:Watl000060)字段[IsNormal(isNormal)]的值:[$(pobjXzMajorEN.isNormal)], 非法，应该为布尔型(In 专业(XzMajor))!(clsXzMajorBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzMajorEN.modifyDate) == false && undefined !== pobjXzMajorEN.modifyDate && tzDataType.isString(pobjXzMajorEN.modifyDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(modifyDate)]的值:[$(pobjXzMajorEN.modifyDate)], 非法，应该为字符型(In 专业(XzMajor))!(clsXzMajorBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzMajorEN.modifyUserID) == false && undefined !== pobjXzMajorEN.modifyUserID && tzDataType.isString(pobjXzMajorEN.modifyUserID) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(modifyUserID)]的值:[$(pobjXzMajorEN.modifyUserID)], 非法，应该为字符型(In 专业(XzMajor))!(clsXzMajorBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzMajorEN.memo) == false && undefined !== pobjXzMajorEN.memo && tzDataType.isString(pobjXzMajorEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjXzMajorEN.memo)], 非法，应该为字符型(In 专业(XzMajor))!(clsXzMajorBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzMajorEN.id_XzMajorShoolType) == false && undefined !== pobjXzMajorEN.id_XzMajorShoolType && tzDataType.isString(pobjXzMajorEN.id_XzMajorShoolType) === false)
{
 throw new Error("(errid:Watl000060)字段[专业学校类型流水号(id_XzMajorShoolType)]的值:[$(pobjXzMajorEN.id_XzMajorShoolType)], 非法，应该为字符型(In 专业(XzMajor))!(clsXzMajorBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
if (IsNullOrEmpty(pobjXzMajorEN.id_XzCollege) == false && GetStrLen(pobjXzMajorEN.id_XzCollege) !=  4)
{
 throw ("(errid:Watl000061)字段[学院流水号]作为外键字段,长度应该为4(In 专业)!(clsXzMajorBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzMajorEN.id_MajorType) == false && GetStrLen(pobjXzMajorEN.id_MajorType) !=  4)
{
 throw ("(errid:Watl000061)字段[专业类型(文理工)流水号]作为外键字段,长度应该为4(In 专业)!(clsXzMajorBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzMajorEN.id_DegreeType) == false && GetStrLen(pobjXzMajorEN.id_DegreeType) !=  4)
{
 throw ("(errid:Watl000061)字段[学位类型流水号]作为外键字段,长度应该为4(In 专业)!(clsXzMajorBL:CheckPropertyNew)");
}

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjXzMajorEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function XzMajor_CheckProperty4Update (pobjXzMajorEN: clsXzMajorEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjXzMajorEN.id_XzMajor) == false && GetStrLen(pobjXzMajorEN.id_XzMajor) > 8)
{
 throw new Error("(errid:Watl000062)字段[专业流水号(id_XzMajor)]的长度不能超过8(In 专业(XzMajor))!值:$(pobjXzMajorEN.id_XzMajor)(clsXzMajorBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzMajorEN.majorID) == false && GetStrLen(pobjXzMajorEN.majorID) > 4)
{
 throw new Error("(errid:Watl000062)字段[专业ID(majorID)]的长度不能超过4(In 专业(XzMajor))!值:$(pobjXzMajorEN.majorID)(clsXzMajorBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzMajorEN.majorName) == false && GetStrLen(pobjXzMajorEN.majorName) > 100)
{
 throw new Error("(errid:Watl000062)字段[专业名称(majorName)]的长度不能超过100(In 专业(XzMajor))!值:$(pobjXzMajorEN.majorName)(clsXzMajorBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzMajorEN.majorEnglishName) == false && GetStrLen(pobjXzMajorEN.majorEnglishName) > 200)
{
 throw new Error("(errid:Watl000062)字段[专业英文名称(majorEnglishName)]的长度不能超过200(In 专业(XzMajor))!值:$(pobjXzMajorEN.majorEnglishName)(clsXzMajorBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzMajorEN.majorExplain) == false && GetStrLen(pobjXzMajorEN.majorExplain) > 2000)
{
 throw new Error("(errid:Watl000062)字段[专业说明(majorExplain)]的长度不能超过2000(In 专业(XzMajor))!值:$(pobjXzMajorEN.majorExplain)(clsXzMajorBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzMajorEN.majorNationalID) == false && GetStrLen(pobjXzMajorEN.majorNationalID) > 10)
{
 throw new Error("(errid:Watl000062)字段[专业国家代码(majorNationalID)]的长度不能超过10(In 专业(XzMajor))!值:$(pobjXzMajorEN.majorNationalID)(clsXzMajorBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzMajorEN.id_XzCollege) == false && GetStrLen(pobjXzMajorEN.id_XzCollege) > 4)
{
 throw new Error("(errid:Watl000062)字段[学院流水号(id_XzCollege)]的长度不能超过4(In 专业(XzMajor))!值:$(pobjXzMajorEN.id_XzCollege)(clsXzMajorBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzMajorEN.id_MajorType) == false && GetStrLen(pobjXzMajorEN.id_MajorType) > 4)
{
 throw new Error("(errid:Watl000062)字段[专业类型(文理工)流水号(id_MajorType)]的长度不能超过4(In 专业(XzMajor))!值:$(pobjXzMajorEN.id_MajorType)(clsXzMajorBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzMajorEN.id_DegreeType) == false && GetStrLen(pobjXzMajorEN.id_DegreeType) > 4)
{
 throw new Error("(errid:Watl000062)字段[学位类型流水号(id_DegreeType)]的长度不能超过4(In 专业(XzMajor))!值:$(pobjXzMajorEN.id_DegreeType)(clsXzMajorBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzMajorEN.majorDirection) == false && GetStrLen(pobjXzMajorEN.majorDirection) > 30)
{
 throw new Error("(errid:Watl000062)字段[专业方向(majorDirection)]的长度不能超过30(In 专业(XzMajor))!值:$(pobjXzMajorEN.majorDirection)(clsXzMajorBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzMajorEN.modifyDate) == false && GetStrLen(pobjXzMajorEN.modifyDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(modifyDate)]的长度不能超过20(In 专业(XzMajor))!值:$(pobjXzMajorEN.modifyDate)(clsXzMajorBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzMajorEN.modifyUserID) == false && GetStrLen(pobjXzMajorEN.modifyUserID) > 18)
{
 throw new Error("(errid:Watl000062)字段[修改人(modifyUserID)]的长度不能超过18(In 专业(XzMajor))!值:$(pobjXzMajorEN.modifyUserID)(clsXzMajorBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzMajorEN.memo) == false && GetStrLen(pobjXzMajorEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 专业(XzMajor))!值:$(pobjXzMajorEN.memo)(clsXzMajorBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzMajorEN.id_XzMajorShoolType) == false && GetStrLen(pobjXzMajorEN.id_XzMajorShoolType) > 4)
{
 throw new Error("(errid:Watl000062)字段[专业学校类型流水号(id_XzMajorShoolType)]的长度不能超过4(In 专业(XzMajor))!值:$(pobjXzMajorEN.id_XzMajorShoolType)(clsXzMajorBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjXzMajorEN.id_XzMajor) == false && undefined !== pobjXzMajorEN.id_XzMajor && tzDataType.isString(pobjXzMajorEN.id_XzMajor) === false)
{
 throw new Error("(errid:Watl000063)字段[专业流水号(id_XzMajor)]的值:[$(pobjXzMajorEN.id_XzMajor)], 非法，应该为字符型(In 专业(XzMajor))!(clsXzMajorBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzMajorEN.majorID) == false && undefined !== pobjXzMajorEN.majorID && tzDataType.isString(pobjXzMajorEN.majorID) === false)
{
 throw new Error("(errid:Watl000063)字段[专业ID(majorID)]的值:[$(pobjXzMajorEN.majorID)], 非法，应该为字符型(In 专业(XzMajor))!(clsXzMajorBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzMajorEN.majorName) == false && undefined !== pobjXzMajorEN.majorName && tzDataType.isString(pobjXzMajorEN.majorName) === false)
{
 throw new Error("(errid:Watl000063)字段[专业名称(majorName)]的值:[$(pobjXzMajorEN.majorName)], 非法，应该为字符型(In 专业(XzMajor))!(clsXzMajorBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzMajorEN.majorEnglishName) == false && undefined !== pobjXzMajorEN.majorEnglishName && tzDataType.isString(pobjXzMajorEN.majorEnglishName) === false)
{
 throw new Error("(errid:Watl000063)字段[专业英文名称(majorEnglishName)]的值:[$(pobjXzMajorEN.majorEnglishName)], 非法，应该为字符型(In 专业(XzMajor))!(clsXzMajorBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzMajorEN.majorExplain) == false && undefined !== pobjXzMajorEN.majorExplain && tzDataType.isString(pobjXzMajorEN.majorExplain) === false)
{
 throw new Error("(errid:Watl000063)字段[专业说明(majorExplain)]的值:[$(pobjXzMajorEN.majorExplain)], 非法，应该为字符型(In 专业(XzMajor))!(clsXzMajorBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzMajorEN.majorNationalID) == false && undefined !== pobjXzMajorEN.majorNationalID && tzDataType.isString(pobjXzMajorEN.majorNationalID) === false)
{
 throw new Error("(errid:Watl000063)字段[专业国家代码(majorNationalID)]的值:[$(pobjXzMajorEN.majorNationalID)], 非法，应该为字符型(In 专业(XzMajor))!(clsXzMajorBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzMajorEN.id_XzCollege) == false && undefined !== pobjXzMajorEN.id_XzCollege && tzDataType.isString(pobjXzMajorEN.id_XzCollege) === false)
{
 throw new Error("(errid:Watl000063)字段[学院流水号(id_XzCollege)]的值:[$(pobjXzMajorEN.id_XzCollege)], 非法，应该为字符型(In 专业(XzMajor))!(clsXzMajorBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzMajorEN.id_MajorType) == false && undefined !== pobjXzMajorEN.id_MajorType && tzDataType.isString(pobjXzMajorEN.id_MajorType) === false)
{
 throw new Error("(errid:Watl000063)字段[专业类型(文理工)流水号(id_MajorType)]的值:[$(pobjXzMajorEN.id_MajorType)], 非法，应该为字符型(In 专业(XzMajor))!(clsXzMajorBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzMajorEN.id_DegreeType) == false && undefined !== pobjXzMajorEN.id_DegreeType && tzDataType.isString(pobjXzMajorEN.id_DegreeType) === false)
{
 throw new Error("(errid:Watl000063)字段[学位类型流水号(id_DegreeType)]的值:[$(pobjXzMajorEN.id_DegreeType)], 非法，应该为字符型(In 专业(XzMajor))!(clsXzMajorBL:CheckProperty4Update)");
}
if (null != pobjXzMajorEN.isMainMajor && undefined !== pobjXzMajorEN.isMainMajor && tzDataType.isBoolean(pobjXzMajorEN.isMainMajor) === false)
{
 throw new Error("(errid:Watl000063)字段[是否重要专业(isMainMajor)]的值:[$(pobjXzMajorEN.isMainMajor)], 非法，应该为布尔型(In 专业(XzMajor))!(clsXzMajorBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzMajorEN.majorDirection) == false && undefined !== pobjXzMajorEN.majorDirection && tzDataType.isString(pobjXzMajorEN.majorDirection) === false)
{
 throw new Error("(errid:Watl000063)字段[专业方向(majorDirection)]的值:[$(pobjXzMajorEN.majorDirection)], 非法，应该为字符型(In 专业(XzMajor))!(clsXzMajorBL:CheckProperty4Update)");
}
if (null != pobjXzMajorEN.isVisible && undefined !== pobjXzMajorEN.isVisible && tzDataType.isBoolean(pobjXzMajorEN.isVisible) === false)
{
 throw new Error("(errid:Watl000063)字段[是否显示(isVisible)]的值:[$(pobjXzMajorEN.isVisible)], 非法，应该为布尔型(In 专业(XzMajor))!(clsXzMajorBL:CheckProperty4Update)");
}
if (null != pobjXzMajorEN.isNormal && undefined !== pobjXzMajorEN.isNormal && tzDataType.isBoolean(pobjXzMajorEN.isNormal) === false)
{
 throw new Error("(errid:Watl000063)字段[IsNormal(isNormal)]的值:[$(pobjXzMajorEN.isNormal)], 非法，应该为布尔型(In 专业(XzMajor))!(clsXzMajorBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzMajorEN.modifyDate) == false && undefined !== pobjXzMajorEN.modifyDate && tzDataType.isString(pobjXzMajorEN.modifyDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(modifyDate)]的值:[$(pobjXzMajorEN.modifyDate)], 非法，应该为字符型(In 专业(XzMajor))!(clsXzMajorBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzMajorEN.modifyUserID) == false && undefined !== pobjXzMajorEN.modifyUserID && tzDataType.isString(pobjXzMajorEN.modifyUserID) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(modifyUserID)]的值:[$(pobjXzMajorEN.modifyUserID)], 非法，应该为字符型(In 专业(XzMajor))!(clsXzMajorBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzMajorEN.memo) == false && undefined !== pobjXzMajorEN.memo && tzDataType.isString(pobjXzMajorEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjXzMajorEN.memo)], 非法，应该为字符型(In 专业(XzMajor))!(clsXzMajorBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzMajorEN.id_XzMajorShoolType) == false && undefined !== pobjXzMajorEN.id_XzMajorShoolType && tzDataType.isString(pobjXzMajorEN.id_XzMajorShoolType) === false)
{
 throw new Error("(errid:Watl000063)字段[专业学校类型流水号(id_XzMajorShoolType)]的值:[$(pobjXzMajorEN.id_XzMajorShoolType)], 非法，应该为字符型(In 专业(XzMajor))!(clsXzMajorBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (IsNullOrEmpty(pobjXzMajorEN.id_XzMajor) === true 
 || pobjXzMajorEN.id_XzMajor.toString()  ===  "0" )
{
 throw new Error("(errid:Watl000064)字段[专业流水号]不能为空(In 专业)!(clsXzMajorBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
if (IsNullOrEmpty(pobjXzMajorEN.id_XzCollege) == false && GetStrLen(pobjXzMajorEN.id_XzCollege) !=  4)
{
 throw ("(errid:Watl000065)字段[学院流水号]作为外键字段,长度应该为4(In 专业)!(clsXzMajorBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzMajorEN.id_MajorType) == false && GetStrLen(pobjXzMajorEN.id_MajorType) !=  4)
{
 throw ("(errid:Watl000065)字段[专业类型(文理工)流水号]作为外键字段,长度应该为4(In 专业)!(clsXzMajorBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzMajorEN.id_DegreeType) == false && GetStrLen(pobjXzMajorEN.id_DegreeType) !=  4)
{
 throw ("(errid:Watl000065)字段[学位类型流水号]作为外键字段,长度应该为4(In 专业)!(clsXzMajorBL:CheckPropertyNew)");
}

 pobjXzMajorEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function XzMajor_GetJSONStrByObj (pobjXzMajorEN: clsXzMajorEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjXzMajorEN.sf_UpdFldSetStr = pobjXzMajorEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjXzMajorEN);
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
export function XzMajor_GetObjLstByJSONStr (strJSON: string): Array<clsXzMajorEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrXzMajorObjLst = new Array<clsXzMajorEN>();
if (strJSON === "")
{
return arrXzMajorObjLst;
}
try
{
arrXzMajorObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrXzMajorObjLst;
}
return arrXzMajorObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrXzMajorObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function XzMajor_GetObjLstByJSONObjLst (arrXzMajorObjLstS: Array<clsXzMajorEN>): Array<clsXzMajorEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrXzMajorObjLst = new Array<clsXzMajorEN>();
for (const objInFor of arrXzMajorObjLstS) {
const obj1 = XzMajor_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrXzMajorObjLst.push(obj1);
}
return arrXzMajorObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function XzMajor_GetObjByJSONStr (strJSON: string): clsXzMajorEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjXzMajorEN = new clsXzMajorEN();
if (strJSON === "")
{
return pobjXzMajorEN;
}
try
{
pobjXzMajorEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjXzMajorEN;
}
return pobjXzMajorEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function XzMajor_GetCombineCondition(objXzMajor_Cond: clsXzMajorEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objXzMajor_Cond.dicFldComparisonOp, clsXzMajorEN.con_id_XzMajor) == true)
{
const strComparisonOp_id_XzMajor:string = objXzMajor_Cond.dicFldComparisonOp[clsXzMajorEN.con_id_XzMajor];
strWhereCond += Format(" And {0} {2} '{1}'", clsXzMajorEN.con_id_XzMajor, objXzMajor_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (Object.prototype.hasOwnProperty.call(objXzMajor_Cond.dicFldComparisonOp, clsXzMajorEN.con_MajorID) == true)
{
const strComparisonOp_MajorID:string = objXzMajor_Cond.dicFldComparisonOp[clsXzMajorEN.con_MajorID];
strWhereCond += Format(" And {0} {2} '{1}'", clsXzMajorEN.con_MajorID, objXzMajor_Cond.majorID, strComparisonOp_MajorID);
}
if (Object.prototype.hasOwnProperty.call(objXzMajor_Cond.dicFldComparisonOp, clsXzMajorEN.con_MajorName) == true)
{
const strComparisonOp_MajorName:string = objXzMajor_Cond.dicFldComparisonOp[clsXzMajorEN.con_MajorName];
strWhereCond += Format(" And {0} {2} '{1}'", clsXzMajorEN.con_MajorName, objXzMajor_Cond.majorName, strComparisonOp_MajorName);
}
if (Object.prototype.hasOwnProperty.call(objXzMajor_Cond.dicFldComparisonOp, clsXzMajorEN.con_MajorEnglishName) == true)
{
const strComparisonOp_MajorEnglishName:string = objXzMajor_Cond.dicFldComparisonOp[clsXzMajorEN.con_MajorEnglishName];
strWhereCond += Format(" And {0} {2} '{1}'", clsXzMajorEN.con_MajorEnglishName, objXzMajor_Cond.majorEnglishName, strComparisonOp_MajorEnglishName);
}
if (Object.prototype.hasOwnProperty.call(objXzMajor_Cond.dicFldComparisonOp, clsXzMajorEN.con_MajorExplain) == true)
{
const strComparisonOp_MajorExplain:string = objXzMajor_Cond.dicFldComparisonOp[clsXzMajorEN.con_MajorExplain];
strWhereCond += Format(" And {0} {2} '{1}'", clsXzMajorEN.con_MajorExplain, objXzMajor_Cond.majorExplain, strComparisonOp_MajorExplain);
}
if (Object.prototype.hasOwnProperty.call(objXzMajor_Cond.dicFldComparisonOp, clsXzMajorEN.con_MajorNationalID) == true)
{
const strComparisonOp_MajorNationalID:string = objXzMajor_Cond.dicFldComparisonOp[clsXzMajorEN.con_MajorNationalID];
strWhereCond += Format(" And {0} {2} '{1}'", clsXzMajorEN.con_MajorNationalID, objXzMajor_Cond.majorNationalID, strComparisonOp_MajorNationalID);
}
if (Object.prototype.hasOwnProperty.call(objXzMajor_Cond.dicFldComparisonOp, clsXzMajorEN.con_id_XzCollege) == true)
{
const strComparisonOp_id_XzCollege:string = objXzMajor_Cond.dicFldComparisonOp[clsXzMajorEN.con_id_XzCollege];
strWhereCond += Format(" And {0} {2} '{1}'", clsXzMajorEN.con_id_XzCollege, objXzMajor_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (Object.prototype.hasOwnProperty.call(objXzMajor_Cond.dicFldComparisonOp, clsXzMajorEN.con_id_MajorType) == true)
{
const strComparisonOp_id_MajorType:string = objXzMajor_Cond.dicFldComparisonOp[clsXzMajorEN.con_id_MajorType];
strWhereCond += Format(" And {0} {2} '{1}'", clsXzMajorEN.con_id_MajorType, objXzMajor_Cond.id_MajorType, strComparisonOp_id_MajorType);
}
if (Object.prototype.hasOwnProperty.call(objXzMajor_Cond.dicFldComparisonOp, clsXzMajorEN.con_id_DegreeType) == true)
{
const strComparisonOp_id_DegreeType:string = objXzMajor_Cond.dicFldComparisonOp[clsXzMajorEN.con_id_DegreeType];
strWhereCond += Format(" And {0} {2} '{1}'", clsXzMajorEN.con_id_DegreeType, objXzMajor_Cond.id_DegreeType, strComparisonOp_id_DegreeType);
}
if (Object.prototype.hasOwnProperty.call(objXzMajor_Cond.dicFldComparisonOp, clsXzMajorEN.con_IsMainMajor) == true)
{
if (objXzMajor_Cond.isMainMajor == true)
{
strWhereCond += Format(" And {0} = '1'", clsXzMajorEN.con_IsMainMajor);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsXzMajorEN.con_IsMainMajor);
}
}
if (Object.prototype.hasOwnProperty.call(objXzMajor_Cond.dicFldComparisonOp, clsXzMajorEN.con_MajorDirection) == true)
{
const strComparisonOp_MajorDirection:string = objXzMajor_Cond.dicFldComparisonOp[clsXzMajorEN.con_MajorDirection];
strWhereCond += Format(" And {0} {2} '{1}'", clsXzMajorEN.con_MajorDirection, objXzMajor_Cond.majorDirection, strComparisonOp_MajorDirection);
}
if (Object.prototype.hasOwnProperty.call(objXzMajor_Cond.dicFldComparisonOp, clsXzMajorEN.con_IsVisible) == true)
{
if (objXzMajor_Cond.isVisible == true)
{
strWhereCond += Format(" And {0} = '1'", clsXzMajorEN.con_IsVisible);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsXzMajorEN.con_IsVisible);
}
}
if (Object.prototype.hasOwnProperty.call(objXzMajor_Cond.dicFldComparisonOp, clsXzMajorEN.con_IsNormal) == true)
{
if (objXzMajor_Cond.isNormal == true)
{
strWhereCond += Format(" And {0} = '1'", clsXzMajorEN.con_IsNormal);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsXzMajorEN.con_IsNormal);
}
}
if (Object.prototype.hasOwnProperty.call(objXzMajor_Cond.dicFldComparisonOp, clsXzMajorEN.con_ModifyDate) == true)
{
const strComparisonOp_ModifyDate:string = objXzMajor_Cond.dicFldComparisonOp[clsXzMajorEN.con_ModifyDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsXzMajorEN.con_ModifyDate, objXzMajor_Cond.modifyDate, strComparisonOp_ModifyDate);
}
if (Object.prototype.hasOwnProperty.call(objXzMajor_Cond.dicFldComparisonOp, clsXzMajorEN.con_ModifyUserID) == true)
{
const strComparisonOp_ModifyUserID:string = objXzMajor_Cond.dicFldComparisonOp[clsXzMajorEN.con_ModifyUserID];
strWhereCond += Format(" And {0} {2} '{1}'", clsXzMajorEN.con_ModifyUserID, objXzMajor_Cond.modifyUserID, strComparisonOp_ModifyUserID);
}
if (Object.prototype.hasOwnProperty.call(objXzMajor_Cond.dicFldComparisonOp, clsXzMajorEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objXzMajor_Cond.dicFldComparisonOp[clsXzMajorEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsXzMajorEN.con_Memo, objXzMajor_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objXzMajor_Cond.dicFldComparisonOp, clsXzMajorEN.con_id_XzMajorShoolType) == true)
{
const strComparisonOp_id_XzMajorShoolType:string = objXzMajor_Cond.dicFldComparisonOp[clsXzMajorEN.con_id_XzMajorShoolType];
strWhereCond += Format(" And {0} {2} '{1}'", clsXzMajorEN.con_id_XzMajorShoolType, objXzMajor_Cond.id_XzMajorShoolType, strComparisonOp_id_XzMajorShoolType);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--XzMajor(专业),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param strid_XzMajor: 专业流水号(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function XzMajor_GetUniCondStr_id_XzMajor(objXzMajorEN: clsXzMajorEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and id_XzMajor = '{0}'", objXzMajorEN.id_XzMajor);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--XzMajor(专业),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param strid_XzMajor: 专业流水号(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function XzMajor_GetUniCondStr4Update_id_XzMajor(objXzMajorEN: clsXzMajorEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and id_XzMajor <> '{0}'", objXzMajorEN.id_XzMajor);
 strWhereCond +=  Format(" and id_XzMajor = '{0}'", objXzMajorEN.id_XzMajor);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objXzMajorENS:源对象
 * @param objXzMajorENT:目标对象
*/
export function XzMajor_CopyObjTo(objXzMajorENS: clsXzMajorEN , objXzMajorENT: clsXzMajorEN ): void 
{
objXzMajorENT.id_XzMajor = objXzMajorENS.id_XzMajor; //专业流水号
objXzMajorENT.majorID = objXzMajorENS.majorID; //专业ID
objXzMajorENT.majorName = objXzMajorENS.majorName; //专业名称
objXzMajorENT.majorEnglishName = objXzMajorENS.majorEnglishName; //专业英文名称
objXzMajorENT.majorExplain = objXzMajorENS.majorExplain; //专业说明
objXzMajorENT.majorNationalID = objXzMajorENS.majorNationalID; //专业国家代码
objXzMajorENT.id_XzCollege = objXzMajorENS.id_XzCollege; //学院流水号
objXzMajorENT.id_MajorType = objXzMajorENS.id_MajorType; //专业类型(文理工)流水号
objXzMajorENT.id_DegreeType = objXzMajorENS.id_DegreeType; //学位类型流水号
objXzMajorENT.isMainMajor = objXzMajorENS.isMainMajor; //是否重要专业
objXzMajorENT.majorDirection = objXzMajorENS.majorDirection; //专业方向
objXzMajorENT.isVisible = objXzMajorENS.isVisible; //是否显示
objXzMajorENT.isNormal = objXzMajorENS.isNormal; //IsNormal
objXzMajorENT.modifyDate = objXzMajorENS.modifyDate; //修改日期
objXzMajorENT.modifyUserID = objXzMajorENS.modifyUserID; //修改人
objXzMajorENT.memo = objXzMajorENS.memo; //备注
objXzMajorENT.id_XzMajorShoolType = objXzMajorENS.id_XzMajorShoolType; //专业学校类型流水号
objXzMajorENT.sf_UpdFldSetStr = objXzMajorENS.updFldString; //sf_UpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objXzMajorENS:源对象
 * @param objXzMajorENT:目标对象
*/
export function XzMajor_GetObjFromJsonObj(objXzMajorENS: clsXzMajorEN): clsXzMajorEN 
{
 const objXzMajorENT: clsXzMajorEN = new clsXzMajorEN();
ObjectAssign(objXzMajorENT, objXzMajorENS);
 return objXzMajorENT;
}