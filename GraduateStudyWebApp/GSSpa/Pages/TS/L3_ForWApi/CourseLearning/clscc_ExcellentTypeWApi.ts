
 /**
 * 类名:clscc_ExcellentTypeWApi
 * 表名:cc_ExcellentType(01120062)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:45:59
 * 生成者:pyf
 * 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:课程学习(CourseLearning)
 * 框架-层名:WA_访问层(TS)(WA_Access)
 * 编程语言:TypeScript
 * 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
   *      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 **/

/**
 * 精品课程类型(cc_ExcellentType)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clscc_ExcellentTypeEN } from "../../L0_Entity/CourseLearning/clscc_ExcellentTypeEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { tzDataType } from "../../PubFun/jsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const cc_ExcellentType_Controller = "cc_ExcellentTypeApi";
 export const cc_ExcellentType_ConstructorName = "cc_ExcellentType";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strExcellentTypeId:关键字
 * @returns 对象
 **/
export async function cc_ExcellentType_GetObjByExcellentTypeIdAsync(strExcellentTypeId: string): Promise<clscc_ExcellentTypeEN>  
{
const strThisFuncName = "GetObjByExcellentTypeIdAsync";

if (IsNullOrEmpty(strExcellentTypeId) == true)
{
  const strMsg = Format("参数:[strExcellentTypeId]不能为空！(In GetObjByExcellentTypeIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strExcellentTypeId.length != 4)
{
const strMsg = Format("缓存分类变量:[strExcellentTypeId]的长度:[{0}]不正确！", strExcellentTypeId.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByExcellentTypeId";
const strUrl = GetWebApiUrl(cc_ExcellentType_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strExcellentTypeId": strExcellentTypeId,
}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObj = data.returnObj;
if (returnObj == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", cc_ExcellentType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objcc_ExcellentType = cc_ExcellentType_GetObjFromJsonObj(returnObj);
return objcc_ExcellentType;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_ExcellentType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_ExcellentType_ConstructorName, strThisFuncName);
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
 * @param strExcellentTypeId:所给的关键字
 * @returns 对象
*/
export async function cc_ExcellentType_GetObjByExcellentTypeId_Cache(strExcellentTypeId: string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByExcellentTypeId_Cache";

if (IsNullOrEmpty(strExcellentTypeId) == true)
{
  const strMsg = Format("参数:[strExcellentTypeId]不能为空！(In GetObjByExcellentTypeId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strExcellentTypeId.length != 4)
{
const strMsg = Format("缓存分类变量:[strExcellentTypeId]的长度:[{0}]不正确！", strExcellentTypeId.length);
console.error(strMsg);
throw (strMsg);
}
const arrcc_ExcellentTypeObjLst_Cache = await cc_ExcellentType_GetObjLst_Cache();
try
{
const arrcc_ExcellentType_Sel: Array <clscc_ExcellentTypeEN> = arrcc_ExcellentTypeObjLst_Cache.filter(x => x.excellentTypeId == strExcellentTypeId);
let objcc_ExcellentType: clscc_ExcellentTypeEN;
if (arrcc_ExcellentType_Sel.length > 0)
{
objcc_ExcellentType = arrcc_ExcellentType_Sel[0];
return objcc_ExcellentType;
}
else
{
if (bolTryAsyncOnce == true)
{
objcc_ExcellentType = await cc_ExcellentType_GetObjByExcellentTypeIdAsync(strExcellentTypeId);
if (objcc_ExcellentType != null)
{
cc_ExcellentType_ReFreshThisCache();
return objcc_ExcellentType;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strExcellentTypeId, cc_ExcellentType_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param strExcellentTypeId:所给的关键字
 * @returns 对象
*/
export async function cc_ExcellentType_GetObjByExcellentTypeId_localStorage(strExcellentTypeId: string) {
const strThisFuncName = "GetObjByExcellentTypeId_localStorage";

if (IsNullOrEmpty(strExcellentTypeId) == true)
{
  const strMsg = Format("参数:[strExcellentTypeId]不能为空！(In GetObjByExcellentTypeId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
if (strExcellentTypeId.length != 4)
{
const strMsg = Format("缓存分类变量:[strExcellentTypeId]的长度:[{0}]不正确！", strExcellentTypeId.length);
console.error(strMsg);
throw (strMsg);
}
const strKey = Format("{0}_{1}", clscc_ExcellentTypeEN._CurrTabName, strExcellentTypeId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objcc_ExcellentType_Cache: clscc_ExcellentTypeEN = JSON.parse(strTempObj);
return objcc_ExcellentType_Cache;
}
try
{
const objcc_ExcellentType = await cc_ExcellentType_GetObjByExcellentTypeIdAsync(strExcellentTypeId);
if (objcc_ExcellentType != null)
{
localStorage.setItem(strKey, JSON.stringify(objcc_ExcellentType));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objcc_ExcellentType;
}
return objcc_ExcellentType;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strExcellentTypeId, cc_ExcellentType_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objcc_ExcellentType:所给的对象
 * @returns 对象
*/
export async function cc_ExcellentType_UpdateObjInLst_Cache(objcc_ExcellentType: clscc_ExcellentTypeEN) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrcc_ExcellentTypeObjLst_Cache = await cc_ExcellentType_GetObjLst_Cache();
const obj = arrcc_ExcellentTypeObjLst_Cache.find(x => 
x.excellentTypeId == objcc_ExcellentType.excellentTypeId);
if (obj != null)
{
objcc_ExcellentType.excellentTypeId = obj.excellentTypeId;
ObjectAssign( obj, objcc_ExcellentType);
}
else
{
arrcc_ExcellentTypeObjLst_Cache.push(objcc_ExcellentType);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, cc_ExcellentType_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
}

/**
 * 根据关键字获取相关对象的名称属性, 从缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
 * @param strExcellentTypeId:所给的关键字
 * @returns 对象
*/
export async function cc_ExcellentType_GetNameByExcellentTypeId_Cache(strExcellentTypeId: string) {
const strThisFuncName = "GetNameByExcellentTypeId_Cache";

if (IsNullOrEmpty(strExcellentTypeId) == true)
{
  const strMsg = Format("参数:[strExcellentTypeId]不能为空！(In GetNameByExcellentTypeId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strExcellentTypeId.length != 4)
{
const strMsg = Format("缓存分类变量:[strExcellentTypeId]的长度:[{0}]不正确！", strExcellentTypeId.length);
console.error(strMsg);
throw (strMsg);
}
const arrcc_ExcellentTypeObjLst_Cache = await cc_ExcellentType_GetObjLst_Cache();
if (arrcc_ExcellentTypeObjLst_Cache == null) return "";
try
{
const arrcc_ExcellentType_Sel: Array <clscc_ExcellentTypeEN> = arrcc_ExcellentTypeObjLst_Cache.filter(x => x.excellentTypeId == strExcellentTypeId);
let objcc_ExcellentType: clscc_ExcellentTypeEN;
if (arrcc_ExcellentType_Sel.length > 0)
{
objcc_ExcellentType = arrcc_ExcellentType_Sel[0];
return objcc_ExcellentType.excellentTypeName;
}
else
{
return "";
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strExcellentTypeId);
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
export async function cc_ExcellentType_func(strInFldName:string , strOutFldName:string ,  strInValue: string) 
{
//const strThisFuncName = "func";

if (strInFldName != clscc_ExcellentTypeEN.con_ExcellentTypeId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clscc_ExcellentTypeEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clscc_ExcellentTypeEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strExcellentTypeId = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objcc_ExcellentType = await cc_ExcellentType_GetObjByExcellentTypeId_Cache(strExcellentTypeId );
if (objcc_ExcellentType == null) return "";
return objcc_ExcellentType.GetFldValue(strOutFldName).toString();
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
export function cc_ExcellentType_SortFun_Defa(a:clscc_ExcellentTypeEN , b:clscc_ExcellentTypeEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.excellentTypeId.localeCompare(b.excellentTypeId);
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
export function cc_ExcellentType_SortFun_Defa_2Fld(a:clscc_ExcellentTypeEN , b:clscc_ExcellentTypeEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.excellentTypeName == b.excellentTypeName) return a.id_School.localeCompare(b.id_School);
else return a.excellentTypeName.localeCompare(b.excellentTypeName);
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
export function cc_ExcellentType_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clscc_ExcellentTypeEN.con_ExcellentTypeId:
return (a: clscc_ExcellentTypeEN, b: clscc_ExcellentTypeEN) => {
return a.excellentTypeId.localeCompare(b.excellentTypeId);
}
case clscc_ExcellentTypeEN.con_ExcellentTypeName:
return (a: clscc_ExcellentTypeEN, b: clscc_ExcellentTypeEN) => {
return a.excellentTypeName.localeCompare(b.excellentTypeName);
}
case clscc_ExcellentTypeEN.con_id_School:
return (a: clscc_ExcellentTypeEN, b: clscc_ExcellentTypeEN) => {
return a.id_School.localeCompare(b.id_School);
}
case clscc_ExcellentTypeEN.con_IsUse:
return (a: clscc_ExcellentTypeEN, b: clscc_ExcellentTypeEN) => {
if (a.isUse == true) return 1;
else return -1
}
case clscc_ExcellentTypeEN.con_UpdDate:
return (a: clscc_ExcellentTypeEN, b: clscc_ExcellentTypeEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clscc_ExcellentTypeEN.con_UpdUserId:
return (a: clscc_ExcellentTypeEN, b: clscc_ExcellentTypeEN) => {
return a.updUserId.localeCompare(b.updUserId);
}
case clscc_ExcellentTypeEN.con_Memo:
return (a: clscc_ExcellentTypeEN, b: clscc_ExcellentTypeEN) => {
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[cc_ExcellentType]中不存在！(in ${ cc_ExcellentType_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clscc_ExcellentTypeEN.con_ExcellentTypeId:
return (a: clscc_ExcellentTypeEN, b: clscc_ExcellentTypeEN) => {
return b.excellentTypeId.localeCompare(a.excellentTypeId);
}
case clscc_ExcellentTypeEN.con_ExcellentTypeName:
return (a: clscc_ExcellentTypeEN, b: clscc_ExcellentTypeEN) => {
return b.excellentTypeName.localeCompare(a.excellentTypeName);
}
case clscc_ExcellentTypeEN.con_id_School:
return (a: clscc_ExcellentTypeEN, b: clscc_ExcellentTypeEN) => {
return b.id_School.localeCompare(a.id_School);
}
case clscc_ExcellentTypeEN.con_IsUse:
return (a: clscc_ExcellentTypeEN, b: clscc_ExcellentTypeEN) => {
if (b.isUse == true) return 1;
else return -1
}
case clscc_ExcellentTypeEN.con_UpdDate:
return (a: clscc_ExcellentTypeEN, b: clscc_ExcellentTypeEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clscc_ExcellentTypeEN.con_UpdUserId:
return (a: clscc_ExcellentTypeEN, b: clscc_ExcellentTypeEN) => {
return b.updUserId.localeCompare(a.updUserId);
}
case clscc_ExcellentTypeEN.con_Memo:
return (a: clscc_ExcellentTypeEN, b: clscc_ExcellentTypeEN) => {
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[cc_ExcellentType]中不存在！(in ${ cc_ExcellentType_ConstructorName}.${ strThisFuncName})`;
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
export async function cc_ExcellentType_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clscc_ExcellentTypeEN.con_ExcellentTypeId:
return (obj: clscc_ExcellentTypeEN) => {
return obj.excellentTypeId === value;
}
case clscc_ExcellentTypeEN.con_ExcellentTypeName:
return (obj: clscc_ExcellentTypeEN) => {
return obj.excellentTypeName === value;
}
case clscc_ExcellentTypeEN.con_id_School:
return (obj: clscc_ExcellentTypeEN) => {
return obj.id_School === value;
}
case clscc_ExcellentTypeEN.con_IsUse:
return (obj: clscc_ExcellentTypeEN) => {
return obj.isUse === value;
}
case clscc_ExcellentTypeEN.con_UpdDate:
return (obj: clscc_ExcellentTypeEN) => {
return obj.updDate === value;
}
case clscc_ExcellentTypeEN.con_UpdUserId:
return (obj: clscc_ExcellentTypeEN) => {
return obj.updUserId === value;
}
case clscc_ExcellentTypeEN.con_Memo:
return (obj: clscc_ExcellentTypeEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[cc_ExcellentType]中不存在！(in ${ cc_ExcellentType_ConstructorName}.${ strThisFuncName})`;
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
export async function cc_ExcellentType_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(cc_ExcellentType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_ExcellentType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_ExcellentType_ConstructorName, strThisFuncName);
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
export async function cc_ExcellentType_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(cc_ExcellentType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_ExcellentType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_ExcellentType_ConstructorName, strThisFuncName);
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
export async function cc_ExcellentType_GetFirstObjAsync(strWhereCond: string): Promise<clscc_ExcellentTypeEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(cc_ExcellentType_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", cc_ExcellentType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objcc_ExcellentType = cc_ExcellentType_GetObjFromJsonObj(returnObj);
return objcc_ExcellentType;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_ExcellentType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_ExcellentType_ConstructorName, strThisFuncName);
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
export async function cc_ExcellentType_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clscc_ExcellentTypeEN._CurrTabName;
clscc_ExcellentTypeEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clscc_ExcellentTypeEN._CurrTabName);
if (IsNullOrEmpty(clscc_ExcellentTypeEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clscc_ExcellentTypeEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrcc_ExcellentTypeExObjLst_Cache: Array<clscc_ExcellentTypeEN> = CacheHelper.Get(strKey);
const arrcc_ExcellentTypeObjLst_T = cc_ExcellentType_GetObjLstByJSONObjLst(arrcc_ExcellentTypeExObjLst_Cache);
return arrcc_ExcellentTypeObjLst_T;
}
try
{
const arrcc_ExcellentTypeExObjLst = await cc_ExcellentType_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrcc_ExcellentTypeExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrcc_ExcellentTypeExObjLst.length);
console.log(strInfo);
return arrcc_ExcellentTypeExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, cc_ExcellentType_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function cc_ExcellentType_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clscc_ExcellentTypeEN._CurrTabName;
clscc_ExcellentTypeEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clscc_ExcellentTypeEN._CurrTabName);
if (IsNullOrEmpty(clscc_ExcellentTypeEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clscc_ExcellentTypeEN.CacheAddiCondition);
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
const arrcc_ExcellentTypeExObjLst_Cache: Array<clscc_ExcellentTypeEN> = JSON.parse(strTempObjLst);
const arrcc_ExcellentTypeObjLst_T = cc_ExcellentType_GetObjLstByJSONObjLst(arrcc_ExcellentTypeExObjLst_Cache);
return arrcc_ExcellentTypeObjLst_T;
}
try
{
const arrcc_ExcellentTypeExObjLst = await cc_ExcellentType_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrcc_ExcellentTypeExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrcc_ExcellentTypeExObjLst.length);
console.log(strInfo);
return arrcc_ExcellentTypeExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, cc_ExcellentType_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function cc_ExcellentType_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clscc_ExcellentTypeEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrcc_ExcellentTypeObjLst_Cache: Array<clscc_ExcellentTypeEN> = JSON.parse(strTempObjLst);
return arrcc_ExcellentTypeObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function cc_ExcellentType_GetObjLstAsync(strWhereCond: string): Promise<Array<clscc_ExcellentTypeEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(cc_ExcellentType_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", cc_ExcellentType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = cc_ExcellentType_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_ExcellentType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_ExcellentType_ConstructorName, strThisFuncName);
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
export async function cc_ExcellentType_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clscc_ExcellentTypeEN._CurrTabName;
clscc_ExcellentTypeEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clscc_ExcellentTypeEN._CurrTabName);
if (IsNullOrEmpty(clscc_ExcellentTypeEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clscc_ExcellentTypeEN.CacheAddiCondition);
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
const arrcc_ExcellentTypeExObjLst_Cache: Array<clscc_ExcellentTypeEN> = JSON.parse(strTempObjLst);
const arrcc_ExcellentTypeObjLst_T = cc_ExcellentType_GetObjLstByJSONObjLst(arrcc_ExcellentTypeExObjLst_Cache);
return arrcc_ExcellentTypeObjLst_T;
}
try
{
const arrcc_ExcellentTypeExObjLst = await cc_ExcellentType_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrcc_ExcellentTypeExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrcc_ExcellentTypeExObjLst.length);
console.log(strInfo);
return arrcc_ExcellentTypeExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, cc_ExcellentType_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function cc_ExcellentType_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clscc_ExcellentTypeEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrcc_ExcellentTypeObjLst_Cache: Array<clscc_ExcellentTypeEN> = JSON.parse(strTempObjLst);
return arrcc_ExcellentTypeObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function cc_ExcellentType_GetObjLst_Cache(): Promise<Array<clscc_ExcellentTypeEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrcc_ExcellentTypeObjLst_Cache;
switch (clscc_ExcellentTypeEN.CacheModeId)
{
case "04"://sessionStorage
arrcc_ExcellentTypeObjLst_Cache = await cc_ExcellentType_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrcc_ExcellentTypeObjLst_Cache = await cc_ExcellentType_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrcc_ExcellentTypeObjLst_Cache = await cc_ExcellentType_GetObjLst_ClientCache();
break;
default:
arrcc_ExcellentTypeObjLst_Cache = await cc_ExcellentType_GetObjLst_ClientCache();
break;
}
const arrcc_ExcellentTypeObjLst = cc_ExcellentType_GetObjLstByJSONObjLst(arrcc_ExcellentTypeObjLst_Cache);
return arrcc_ExcellentTypeObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function cc_ExcellentType_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrcc_ExcellentTypeObjLst_Cache;
switch (clscc_ExcellentTypeEN.CacheModeId)
{
case "04"://sessionStorage
arrcc_ExcellentTypeObjLst_Cache = await cc_ExcellentType_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrcc_ExcellentTypeObjLst_Cache = await cc_ExcellentType_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrcc_ExcellentTypeObjLst_Cache = null;
break;
default:
arrcc_ExcellentTypeObjLst_Cache = null;
break;
}
return arrcc_ExcellentTypeObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrExcellentTypeId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function cc_ExcellentType_GetSubObjLst_Cache(objcc_ExcellentType_Cond: clscc_ExcellentTypeEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrcc_ExcellentTypeObjLst_Cache = await cc_ExcellentType_GetObjLst_Cache();
let arrcc_ExcellentType_Sel: Array < clscc_ExcellentTypeEN > = arrcc_ExcellentTypeObjLst_Cache;
if (objcc_ExcellentType_Cond.sf_FldComparisonOp == null || objcc_ExcellentType_Cond.sf_FldComparisonOp == "") return arrcc_ExcellentType_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objcc_ExcellentType_Cond.sf_FldComparisonOp);
//console.log("clscc_ExcellentTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objcc_ExcellentType_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrcc_ExcellentType_Sel = arrcc_ExcellentType_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objcc_ExcellentType_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrcc_ExcellentType_Sel = arrcc_ExcellentType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrcc_ExcellentType_Sel = arrcc_ExcellentType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrcc_ExcellentType_Sel = arrcc_ExcellentType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrcc_ExcellentType_Sel = arrcc_ExcellentType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrcc_ExcellentType_Sel = arrcc_ExcellentType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrcc_ExcellentType_Sel = arrcc_ExcellentType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrcc_ExcellentType_Sel = arrcc_ExcellentType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrcc_ExcellentType_Sel = arrcc_ExcellentType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrcc_ExcellentType_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objcc_ExcellentType_Cond), cc_ExcellentType_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clscc_ExcellentTypeEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrExcellentTypeId:关键字列表
 * @returns 对象列表
 **/
export async function cc_ExcellentType_GetObjLstByExcellentTypeIdLstAsync(arrExcellentTypeId: Array<string>): Promise<Array<clscc_ExcellentTypeEN>>  
{
const strThisFuncName = "GetObjLstByExcellentTypeIdLstAsync";
const strAction = "GetObjLstByExcellentTypeIdLst";
const strUrl = GetWebApiUrl(cc_ExcellentType_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrExcellentTypeId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", cc_ExcellentType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = cc_ExcellentType_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_ExcellentType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_ExcellentType_ConstructorName, strThisFuncName);
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
 * @param arrstrExcellentTypeIdLst:关键字列表
 * @returns 对象列表
*/
export async function cc_ExcellentType_GetObjLstByExcellentTypeIdLst_Cache(arrExcellentTypeIdLst: Array<string>) {
const strThisFuncName = "GetObjLstByExcellentTypeIdLst_Cache";
try
{
const arrcc_ExcellentTypeObjLst_Cache = await cc_ExcellentType_GetObjLst_Cache();
const arrcc_ExcellentType_Sel: Array <clscc_ExcellentTypeEN> = arrcc_ExcellentTypeObjLst_Cache.filter(x => arrExcellentTypeIdLst.indexOf(x.excellentTypeId)>-1);
return arrcc_ExcellentType_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrExcellentTypeIdLst.join(","), cc_ExcellentType_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clscc_ExcellentTypeEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function cc_ExcellentType_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clscc_ExcellentTypeEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(cc_ExcellentType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", cc_ExcellentType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = cc_ExcellentType_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_ExcellentType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_ExcellentType_ConstructorName, strThisFuncName);
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
export async function cc_ExcellentType_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clscc_ExcellentTypeEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(cc_ExcellentType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", cc_ExcellentType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = cc_ExcellentType_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_ExcellentType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_ExcellentType_ConstructorName, strThisFuncName);
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
export async function cc_ExcellentType_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(cc_ExcellentType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_ExcellentType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_ExcellentType_ConstructorName, strThisFuncName);
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
export async function cc_ExcellentType_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrcc_ExcellentTypeObjLst_Cache = await cc_ExcellentType_GetObjLst_Cache();
if (arrcc_ExcellentTypeObjLst_Cache.length == 0) return arrcc_ExcellentTypeObjLst_Cache;
let arrcc_ExcellentType_Sel = arrcc_ExcellentTypeObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objcc_ExcellentType_Cond = new clscc_ExcellentTypeEN();
ObjectAssign(objcc_ExcellentType_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clscc_ExcellentTypeWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrcc_ExcellentType_Sel = arrcc_ExcellentType_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objcc_ExcellentType_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrcc_ExcellentType_Sel = arrcc_ExcellentType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrcc_ExcellentType_Sel = arrcc_ExcellentType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrcc_ExcellentType_Sel = arrcc_ExcellentType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrcc_ExcellentType_Sel = arrcc_ExcellentType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrcc_ExcellentType_Sel = arrcc_ExcellentType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrcc_ExcellentType_Sel = arrcc_ExcellentType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrcc_ExcellentType_Sel = arrcc_ExcellentType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrcc_ExcellentType_Sel = arrcc_ExcellentType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrcc_ExcellentType_Sel = arrcc_ExcellentType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrcc_ExcellentType_Sel.length == 0) return arrcc_ExcellentType_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrcc_ExcellentType_Sel = arrcc_ExcellentType_Sel.sort(cc_ExcellentType_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrcc_ExcellentType_Sel = arrcc_ExcellentType_Sel.sort(objPagerPara.sortFun);
}
arrcc_ExcellentType_Sel = arrcc_ExcellentType_Sel.slice(intStart, intEnd);     
return arrcc_ExcellentType_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, cc_ExcellentType_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clscc_ExcellentTypeEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function cc_ExcellentType_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clscc_ExcellentTypeEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(cc_ExcellentType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", cc_ExcellentType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = cc_ExcellentType_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_ExcellentType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_ExcellentType_ConstructorName, strThisFuncName);
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
 * @param strExcellentTypeId:关键字
 * @returns 获取删除的结果
 **/
export async function cc_ExcellentType_DelRecordAsync(strExcellentTypeId: string): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(cc_ExcellentType_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, strExcellentTypeId);
try
{
const response = await axios.delete(strUrl,
{
params: { "Id": strExcellentTypeId, }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_ExcellentType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_ExcellentType_ConstructorName, strThisFuncName);
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
 * @param arrExcellentTypeId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function cc_ExcellentType_Delcc_ExcellentTypesAsync(arrExcellentTypeId: Array<string>): Promise<number> 
{
const strThisFuncName = "Delcc_ExcellentTypesAsync";
const strAction = "Delcc_ExcellentTypes";
const strUrl = GetWebApiUrl(cc_ExcellentType_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrExcellentTypeId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_ExcellentType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_ExcellentType_ConstructorName, strThisFuncName);
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
export async function cc_ExcellentType_Delcc_ExcellentTypesByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "Delcc_ExcellentTypesByCondAsync";
const strAction = "Delcc_ExcellentTypesByCond";
const strUrl = GetWebApiUrl(cc_ExcellentType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_ExcellentType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_ExcellentType_ConstructorName, strThisFuncName);
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
 * @param objcc_ExcellentTypeEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function cc_ExcellentType_AddNewRecordAsync(objcc_ExcellentTypeEN: clscc_ExcellentTypeEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
if (objcc_ExcellentTypeEN.excellentTypeId === null || objcc_ExcellentTypeEN.excellentTypeId === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objcc_ExcellentTypeEN);
const strUrl = GetWebApiUrl(cc_ExcellentType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objcc_ExcellentTypeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_ExcellentType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_ExcellentType_ConstructorName, strThisFuncName);
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
 * @param objcc_ExcellentTypeEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function cc_ExcellentType_AddNewRecordWithMaxIdAsync(objcc_ExcellentTypeEN: clscc_ExcellentTypeEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithMaxIdAsync";
const strAction = "AddNewRecordWithMaxId";
const strUrl = GetWebApiUrl(cc_ExcellentType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objcc_ExcellentTypeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_ExcellentType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_ExcellentType_ConstructorName, strThisFuncName);
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
 * @param objcc_ExcellentTypeEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function cc_ExcellentType_AddNewRecordWithReturnKeyAsync(objcc_ExcellentTypeEN: clscc_ExcellentTypeEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(cc_ExcellentType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objcc_ExcellentTypeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_ExcellentType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_ExcellentType_ConstructorName, strThisFuncName);
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
 * @param objcc_ExcellentTypeEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function cc_ExcellentType_AddNewRecordWithReturnKey(objcc_ExcellentTypeEN: clscc_ExcellentTypeEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objcc_ExcellentTypeEN.excellentTypeId === null || objcc_ExcellentTypeEN.excellentTypeId === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(cc_ExcellentType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objcc_ExcellentTypeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_ExcellentType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_ExcellentType_ConstructorName, strThisFuncName);
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
 * @param objcc_ExcellentTypeEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function cc_ExcellentType_UpdateRecordAsync(objcc_ExcellentTypeEN: clscc_ExcellentTypeEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objcc_ExcellentTypeEN.sf_UpdFldSetStr === undefined || objcc_ExcellentTypeEN.sf_UpdFldSetStr === null || objcc_ExcellentTypeEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objcc_ExcellentTypeEN.excellentTypeId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(cc_ExcellentType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objcc_ExcellentTypeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_ExcellentType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_ExcellentType_ConstructorName, strThisFuncName);
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
 * @param objcc_ExcellentTypeEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function cc_ExcellentType_UpdateWithConditionAsync(objcc_ExcellentTypeEN: clscc_ExcellentTypeEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objcc_ExcellentTypeEN.sf_UpdFldSetStr === undefined || objcc_ExcellentTypeEN.sf_UpdFldSetStr === null || objcc_ExcellentTypeEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objcc_ExcellentTypeEN.excellentTypeId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(cc_ExcellentType_Controller, strAction);
objcc_ExcellentTypeEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objcc_ExcellentTypeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_ExcellentType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_ExcellentType_ConstructorName, strThisFuncName);
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
 * @param objstrExcellentTypeId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function cc_ExcellentType_IsExistRecord_Cache(objcc_ExcellentType_Cond: clscc_ExcellentTypeEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrcc_ExcellentTypeObjLst_Cache = await cc_ExcellentType_GetObjLst_Cache();
if (arrcc_ExcellentTypeObjLst_Cache == null) return false;
let arrcc_ExcellentType_Sel: Array < clscc_ExcellentTypeEN > = arrcc_ExcellentTypeObjLst_Cache;
if (objcc_ExcellentType_Cond.sf_FldComparisonOp == null || objcc_ExcellentType_Cond.sf_FldComparisonOp == "") return arrcc_ExcellentType_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objcc_ExcellentType_Cond.sf_FldComparisonOp);
//console.log("clscc_ExcellentTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objcc_ExcellentType_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objcc_ExcellentType_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrcc_ExcellentType_Sel = arrcc_ExcellentType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrcc_ExcellentType_Sel = arrcc_ExcellentType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrcc_ExcellentType_Sel = arrcc_ExcellentType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrcc_ExcellentType_Sel = arrcc_ExcellentType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrcc_ExcellentType_Sel = arrcc_ExcellentType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrcc_ExcellentType_Sel = arrcc_ExcellentType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrcc_ExcellentType_Sel = arrcc_ExcellentType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrcc_ExcellentType_Sel = arrcc_ExcellentType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrcc_ExcellentType_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objcc_ExcellentType_Cond), cc_ExcellentType_ConstructorName, strThisFuncName);
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
export async function cc_ExcellentType_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(cc_ExcellentType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_ExcellentType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_ExcellentType_ConstructorName, strThisFuncName);
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
 * @param strExcellentTypeId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function cc_ExcellentType_IsExist(strExcellentTypeId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(cc_ExcellentType_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"ExcellentTypeId": strExcellentTypeId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_ExcellentType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_ExcellentType_ConstructorName, strThisFuncName);
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
 * @param strExcellentTypeId:所给的关键字
 * @returns 对象
*/
export async function cc_ExcellentType_IsExist_Cache(strExcellentTypeId:string) {
const strThisFuncName = "IsExist_Cache";
const arrcc_ExcellentTypeObjLst_Cache = await cc_ExcellentType_GetObjLst_Cache();
if (arrcc_ExcellentTypeObjLst_Cache == null) return false;
try
{
const arrcc_ExcellentType_Sel: Array <clscc_ExcellentTypeEN> = arrcc_ExcellentTypeObjLst_Cache.filter(x => x.excellentTypeId == strExcellentTypeId);
if (arrcc_ExcellentType_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strExcellentTypeId, cc_ExcellentType_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param strExcellentTypeId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function cc_ExcellentType_IsExistAsync(strExcellentTypeId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(cc_ExcellentType_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strExcellentTypeId": strExcellentTypeId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_ExcellentType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_ExcellentType_ConstructorName, strThisFuncName);
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
export async function cc_ExcellentType_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(cc_ExcellentType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_ExcellentType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_ExcellentType_ConstructorName, strThisFuncName);
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
 * @param objcc_ExcellentType_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function cc_ExcellentType_GetRecCountByCond_Cache(objcc_ExcellentType_Cond: clscc_ExcellentTypeEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrcc_ExcellentTypeObjLst_Cache = await cc_ExcellentType_GetObjLst_Cache();
if (arrcc_ExcellentTypeObjLst_Cache == null) return 0;
let arrcc_ExcellentType_Sel: Array < clscc_ExcellentTypeEN > = arrcc_ExcellentTypeObjLst_Cache;
if (objcc_ExcellentType_Cond.sf_FldComparisonOp == null || objcc_ExcellentType_Cond.sf_FldComparisonOp == "") return arrcc_ExcellentType_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objcc_ExcellentType_Cond.sf_FldComparisonOp);
//console.log("clscc_ExcellentTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objcc_ExcellentType_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrcc_ExcellentType_Sel = arrcc_ExcellentType_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objcc_ExcellentType_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrcc_ExcellentType_Sel = arrcc_ExcellentType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrcc_ExcellentType_Sel = arrcc_ExcellentType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrcc_ExcellentType_Sel = arrcc_ExcellentType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrcc_ExcellentType_Sel = arrcc_ExcellentType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrcc_ExcellentType_Sel = arrcc_ExcellentType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrcc_ExcellentType_Sel = arrcc_ExcellentType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrcc_ExcellentType_Sel = arrcc_ExcellentType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrcc_ExcellentType_Sel = arrcc_ExcellentType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrcc_ExcellentType_Sel = arrcc_ExcellentType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrcc_ExcellentType_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objcc_ExcellentType_Cond), cc_ExcellentType_ConstructorName, strThisFuncName);
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
export async function cc_ExcellentType_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(cc_ExcellentType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_ExcellentType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_ExcellentType_ConstructorName, strThisFuncName);
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
export function cc_ExcellentType_GetWebApiUrl(strController: string, strAction: string): string {
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
export function cc_ExcellentType_ReFreshCache():void
{
const strThisFuncName = "ReFreshCache";

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = clscc_ExcellentTypeEN._CurrTabName;
switch (clscc_ExcellentTypeEN.CacheModeId)
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
export function cc_ExcellentType_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clscc_ExcellentTypeEN._CurrTabName;
switch (clscc_ExcellentTypeEN.CacheModeId)
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
export async function cc_ExcellentType__Cache(strDivName: string, strDdlName: string )
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
const arrObjLst_Sel = await cc_ExcellentType_GetObjLst_Cache();
if (arrObjLst_Sel == null) return;
BindDdl_ObjLstInDiv(strDivName, strDdlName, arrObjLst_Sel, clscc_ExcellentTypeEN.con_ExcellentTypeId, clscc_ExcellentTypeEN.con_ExcellentTypeName, "精品课程类型");
}

/**
 * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function cc_ExcellentType_CheckPropertyNew(pobjcc_ExcellentTypeEN: clscc_ExcellentTypeEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjcc_ExcellentTypeEN.excellentTypeName) === true )
{
 throw new Error("(errid:Watl000058)字段[精品课程类型名称]不能为空(In 精品课程类型)!(clscc_ExcellentTypeBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjcc_ExcellentTypeEN.excellentTypeId) == false && GetStrLen(pobjcc_ExcellentTypeEN.excellentTypeId) > 4)
{
 throw new Error("(errid:Watl000059)字段[精品课程类型Id(excellentTypeId)]的长度不能超过4(In 精品课程类型(cc_ExcellentType))!值:$(pobjcc_ExcellentTypeEN.excellentTypeId)(clscc_ExcellentTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_ExcellentTypeEN.excellentTypeName) == false && GetStrLen(pobjcc_ExcellentTypeEN.excellentTypeName) > 30)
{
 throw new Error("(errid:Watl000059)字段[精品课程类型名称(excellentTypeName)]的长度不能超过30(In 精品课程类型(cc_ExcellentType))!值:$(pobjcc_ExcellentTypeEN.excellentTypeName)(clscc_ExcellentTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_ExcellentTypeEN.id_School) == false && GetStrLen(pobjcc_ExcellentTypeEN.id_School) > 4)
{
 throw new Error("(errid:Watl000059)字段[学校流水号(id_School)]的长度不能超过4(In 精品课程类型(cc_ExcellentType))!值:$(pobjcc_ExcellentTypeEN.id_School)(clscc_ExcellentTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_ExcellentTypeEN.updDate) == false && GetStrLen(pobjcc_ExcellentTypeEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 精品课程类型(cc_ExcellentType))!值:$(pobjcc_ExcellentTypeEN.updDate)(clscc_ExcellentTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_ExcellentTypeEN.updUserId) == false && GetStrLen(pobjcc_ExcellentTypeEN.updUserId) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改用户Id(updUserId)]的长度不能超过20(In 精品课程类型(cc_ExcellentType))!值:$(pobjcc_ExcellentTypeEN.updUserId)(clscc_ExcellentTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_ExcellentTypeEN.memo) == false && GetStrLen(pobjcc_ExcellentTypeEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 精品课程类型(cc_ExcellentType))!值:$(pobjcc_ExcellentTypeEN.memo)(clscc_ExcellentTypeBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjcc_ExcellentTypeEN.excellentTypeId) == false && undefined !== pobjcc_ExcellentTypeEN.excellentTypeId && tzDataType.isString(pobjcc_ExcellentTypeEN.excellentTypeId) === false)
{
 throw new Error("(errid:Watl000060)字段[精品课程类型Id(excellentTypeId)]的值:[$(pobjcc_ExcellentTypeEN.excellentTypeId)], 非法，应该为字符型(In 精品课程类型(cc_ExcellentType))!(clscc_ExcellentTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_ExcellentTypeEN.excellentTypeName) == false && undefined !== pobjcc_ExcellentTypeEN.excellentTypeName && tzDataType.isString(pobjcc_ExcellentTypeEN.excellentTypeName) === false)
{
 throw new Error("(errid:Watl000060)字段[精品课程类型名称(excellentTypeName)]的值:[$(pobjcc_ExcellentTypeEN.excellentTypeName)], 非法，应该为字符型(In 精品课程类型(cc_ExcellentType))!(clscc_ExcellentTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_ExcellentTypeEN.id_School) == false && undefined !== pobjcc_ExcellentTypeEN.id_School && tzDataType.isString(pobjcc_ExcellentTypeEN.id_School) === false)
{
 throw new Error("(errid:Watl000060)字段[学校流水号(id_School)]的值:[$(pobjcc_ExcellentTypeEN.id_School)], 非法，应该为字符型(In 精品课程类型(cc_ExcellentType))!(clscc_ExcellentTypeBL:CheckPropertyNew)");
}
if (null != pobjcc_ExcellentTypeEN.isUse && undefined !== pobjcc_ExcellentTypeEN.isUse && tzDataType.isBoolean(pobjcc_ExcellentTypeEN.isUse) === false)
{
 throw new Error("(errid:Watl000060)字段[是否使用(isUse)]的值:[$(pobjcc_ExcellentTypeEN.isUse)], 非法，应该为布尔型(In 精品课程类型(cc_ExcellentType))!(clscc_ExcellentTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_ExcellentTypeEN.updDate) == false && undefined !== pobjcc_ExcellentTypeEN.updDate && tzDataType.isString(pobjcc_ExcellentTypeEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjcc_ExcellentTypeEN.updDate)], 非法，应该为字符型(In 精品课程类型(cc_ExcellentType))!(clscc_ExcellentTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_ExcellentTypeEN.updUserId) == false && undefined !== pobjcc_ExcellentTypeEN.updUserId && tzDataType.isString(pobjcc_ExcellentTypeEN.updUserId) === false)
{
 throw new Error("(errid:Watl000060)字段[修改用户Id(updUserId)]的值:[$(pobjcc_ExcellentTypeEN.updUserId)], 非法，应该为字符型(In 精品课程类型(cc_ExcellentType))!(clscc_ExcellentTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_ExcellentTypeEN.memo) == false && undefined !== pobjcc_ExcellentTypeEN.memo && tzDataType.isString(pobjcc_ExcellentTypeEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjcc_ExcellentTypeEN.memo)], 非法，应该为字符型(In 精品课程类型(cc_ExcellentType))!(clscc_ExcellentTypeBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjcc_ExcellentTypeEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function cc_ExcellentType_CheckProperty4Update (pobjcc_ExcellentTypeEN: clscc_ExcellentTypeEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjcc_ExcellentTypeEN.excellentTypeId) == false && GetStrLen(pobjcc_ExcellentTypeEN.excellentTypeId) > 4)
{
 throw new Error("(errid:Watl000062)字段[精品课程类型Id(excellentTypeId)]的长度不能超过4(In 精品课程类型(cc_ExcellentType))!值:$(pobjcc_ExcellentTypeEN.excellentTypeId)(clscc_ExcellentTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjcc_ExcellentTypeEN.excellentTypeName) == false && GetStrLen(pobjcc_ExcellentTypeEN.excellentTypeName) > 30)
{
 throw new Error("(errid:Watl000062)字段[精品课程类型名称(excellentTypeName)]的长度不能超过30(In 精品课程类型(cc_ExcellentType))!值:$(pobjcc_ExcellentTypeEN.excellentTypeName)(clscc_ExcellentTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjcc_ExcellentTypeEN.id_School) == false && GetStrLen(pobjcc_ExcellentTypeEN.id_School) > 4)
{
 throw new Error("(errid:Watl000062)字段[学校流水号(id_School)]的长度不能超过4(In 精品课程类型(cc_ExcellentType))!值:$(pobjcc_ExcellentTypeEN.id_School)(clscc_ExcellentTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjcc_ExcellentTypeEN.updDate) == false && GetStrLen(pobjcc_ExcellentTypeEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 精品课程类型(cc_ExcellentType))!值:$(pobjcc_ExcellentTypeEN.updDate)(clscc_ExcellentTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjcc_ExcellentTypeEN.updUserId) == false && GetStrLen(pobjcc_ExcellentTypeEN.updUserId) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改用户Id(updUserId)]的长度不能超过20(In 精品课程类型(cc_ExcellentType))!值:$(pobjcc_ExcellentTypeEN.updUserId)(clscc_ExcellentTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjcc_ExcellentTypeEN.memo) == false && GetStrLen(pobjcc_ExcellentTypeEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 精品课程类型(cc_ExcellentType))!值:$(pobjcc_ExcellentTypeEN.memo)(clscc_ExcellentTypeBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjcc_ExcellentTypeEN.excellentTypeId) == false && undefined !== pobjcc_ExcellentTypeEN.excellentTypeId && tzDataType.isString(pobjcc_ExcellentTypeEN.excellentTypeId) === false)
{
 throw new Error("(errid:Watl000063)字段[精品课程类型Id(excellentTypeId)]的值:[$(pobjcc_ExcellentTypeEN.excellentTypeId)], 非法，应该为字符型(In 精品课程类型(cc_ExcellentType))!(clscc_ExcellentTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjcc_ExcellentTypeEN.excellentTypeName) == false && undefined !== pobjcc_ExcellentTypeEN.excellentTypeName && tzDataType.isString(pobjcc_ExcellentTypeEN.excellentTypeName) === false)
{
 throw new Error("(errid:Watl000063)字段[精品课程类型名称(excellentTypeName)]的值:[$(pobjcc_ExcellentTypeEN.excellentTypeName)], 非法，应该为字符型(In 精品课程类型(cc_ExcellentType))!(clscc_ExcellentTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjcc_ExcellentTypeEN.id_School) == false && undefined !== pobjcc_ExcellentTypeEN.id_School && tzDataType.isString(pobjcc_ExcellentTypeEN.id_School) === false)
{
 throw new Error("(errid:Watl000063)字段[学校流水号(id_School)]的值:[$(pobjcc_ExcellentTypeEN.id_School)], 非法，应该为字符型(In 精品课程类型(cc_ExcellentType))!(clscc_ExcellentTypeBL:CheckProperty4Update)");
}
if (null != pobjcc_ExcellentTypeEN.isUse && undefined !== pobjcc_ExcellentTypeEN.isUse && tzDataType.isBoolean(pobjcc_ExcellentTypeEN.isUse) === false)
{
 throw new Error("(errid:Watl000063)字段[是否使用(isUse)]的值:[$(pobjcc_ExcellentTypeEN.isUse)], 非法，应该为布尔型(In 精品课程类型(cc_ExcellentType))!(clscc_ExcellentTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjcc_ExcellentTypeEN.updDate) == false && undefined !== pobjcc_ExcellentTypeEN.updDate && tzDataType.isString(pobjcc_ExcellentTypeEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjcc_ExcellentTypeEN.updDate)], 非法，应该为字符型(In 精品课程类型(cc_ExcellentType))!(clscc_ExcellentTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjcc_ExcellentTypeEN.updUserId) == false && undefined !== pobjcc_ExcellentTypeEN.updUserId && tzDataType.isString(pobjcc_ExcellentTypeEN.updUserId) === false)
{
 throw new Error("(errid:Watl000063)字段[修改用户Id(updUserId)]的值:[$(pobjcc_ExcellentTypeEN.updUserId)], 非法，应该为字符型(In 精品课程类型(cc_ExcellentType))!(clscc_ExcellentTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjcc_ExcellentTypeEN.memo) == false && undefined !== pobjcc_ExcellentTypeEN.memo && tzDataType.isString(pobjcc_ExcellentTypeEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjcc_ExcellentTypeEN.memo)], 非法，应该为字符型(In 精品课程类型(cc_ExcellentType))!(clscc_ExcellentTypeBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (IsNullOrEmpty(pobjcc_ExcellentTypeEN.excellentTypeId) === true 
 || pobjcc_ExcellentTypeEN.excellentTypeId.toString()  ===  "0" )
{
 throw new Error("(errid:Watl000064)字段[精品课程类型Id]不能为空(In 精品课程类型)!(clscc_ExcellentTypeBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjcc_ExcellentTypeEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function cc_ExcellentType_GetJSONStrByObj (pobjcc_ExcellentTypeEN: clscc_ExcellentTypeEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjcc_ExcellentTypeEN.sf_UpdFldSetStr = pobjcc_ExcellentTypeEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjcc_ExcellentTypeEN);
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
export function cc_ExcellentType_GetObjLstByJSONStr (strJSON: string): Array<clscc_ExcellentTypeEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrcc_ExcellentTypeObjLst = new Array<clscc_ExcellentTypeEN>();
if (strJSON === "")
{
return arrcc_ExcellentTypeObjLst;
}
try
{
arrcc_ExcellentTypeObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrcc_ExcellentTypeObjLst;
}
return arrcc_ExcellentTypeObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrcc_ExcellentTypeObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function cc_ExcellentType_GetObjLstByJSONObjLst (arrcc_ExcellentTypeObjLstS: Array<clscc_ExcellentTypeEN>): Array<clscc_ExcellentTypeEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrcc_ExcellentTypeObjLst = new Array<clscc_ExcellentTypeEN>();
for (const objInFor of arrcc_ExcellentTypeObjLstS) {
const obj1 = cc_ExcellentType_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrcc_ExcellentTypeObjLst.push(obj1);
}
return arrcc_ExcellentTypeObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function cc_ExcellentType_GetObjByJSONStr (strJSON: string): clscc_ExcellentTypeEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjcc_ExcellentTypeEN = new clscc_ExcellentTypeEN();
if (strJSON === "")
{
return pobjcc_ExcellentTypeEN;
}
try
{
pobjcc_ExcellentTypeEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjcc_ExcellentTypeEN;
}
return pobjcc_ExcellentTypeEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function cc_ExcellentType_GetCombineCondition(objcc_ExcellentType_Cond: clscc_ExcellentTypeEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objcc_ExcellentType_Cond.dicFldComparisonOp, clscc_ExcellentTypeEN.con_ExcellentTypeId) == true)
{
const strComparisonOp_ExcellentTypeId:string = objcc_ExcellentType_Cond.dicFldComparisonOp[clscc_ExcellentTypeEN.con_ExcellentTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clscc_ExcellentTypeEN.con_ExcellentTypeId, objcc_ExcellentType_Cond.excellentTypeId, strComparisonOp_ExcellentTypeId);
}
if (Object.prototype.hasOwnProperty.call(objcc_ExcellentType_Cond.dicFldComparisonOp, clscc_ExcellentTypeEN.con_ExcellentTypeName) == true)
{
const strComparisonOp_ExcellentTypeName:string = objcc_ExcellentType_Cond.dicFldComparisonOp[clscc_ExcellentTypeEN.con_ExcellentTypeName];
strWhereCond += Format(" And {0} {2} '{1}'", clscc_ExcellentTypeEN.con_ExcellentTypeName, objcc_ExcellentType_Cond.excellentTypeName, strComparisonOp_ExcellentTypeName);
}
if (Object.prototype.hasOwnProperty.call(objcc_ExcellentType_Cond.dicFldComparisonOp, clscc_ExcellentTypeEN.con_id_School) == true)
{
const strComparisonOp_id_School:string = objcc_ExcellentType_Cond.dicFldComparisonOp[clscc_ExcellentTypeEN.con_id_School];
strWhereCond += Format(" And {0} {2} '{1}'", clscc_ExcellentTypeEN.con_id_School, objcc_ExcellentType_Cond.id_School, strComparisonOp_id_School);
}
if (Object.prototype.hasOwnProperty.call(objcc_ExcellentType_Cond.dicFldComparisonOp, clscc_ExcellentTypeEN.con_IsUse) == true)
{
if (objcc_ExcellentType_Cond.isUse == true)
{
strWhereCond += Format(" And {0} = '1'", clscc_ExcellentTypeEN.con_IsUse);
}
else
{
strWhereCond += Format(" And {0} = '0'", clscc_ExcellentTypeEN.con_IsUse);
}
}
if (Object.prototype.hasOwnProperty.call(objcc_ExcellentType_Cond.dicFldComparisonOp, clscc_ExcellentTypeEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objcc_ExcellentType_Cond.dicFldComparisonOp[clscc_ExcellentTypeEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clscc_ExcellentTypeEN.con_UpdDate, objcc_ExcellentType_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objcc_ExcellentType_Cond.dicFldComparisonOp, clscc_ExcellentTypeEN.con_UpdUserId) == true)
{
const strComparisonOp_UpdUserId:string = objcc_ExcellentType_Cond.dicFldComparisonOp[clscc_ExcellentTypeEN.con_UpdUserId];
strWhereCond += Format(" And {0} {2} '{1}'", clscc_ExcellentTypeEN.con_UpdUserId, objcc_ExcellentType_Cond.updUserId, strComparisonOp_UpdUserId);
}
if (Object.prototype.hasOwnProperty.call(objcc_ExcellentType_Cond.dicFldComparisonOp, clscc_ExcellentTypeEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objcc_ExcellentType_Cond.dicFldComparisonOp[clscc_ExcellentTypeEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clscc_ExcellentTypeEN.con_Memo, objcc_ExcellentType_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objcc_ExcellentTypeENS:源对象
 * @param objcc_ExcellentTypeENT:目标对象
*/
export function cc_ExcellentType_CopyObjTo(objcc_ExcellentTypeENS: clscc_ExcellentTypeEN , objcc_ExcellentTypeENT: clscc_ExcellentTypeEN ): void 
{
objcc_ExcellentTypeENT.excellentTypeId = objcc_ExcellentTypeENS.excellentTypeId; //精品课程类型Id
objcc_ExcellentTypeENT.excellentTypeName = objcc_ExcellentTypeENS.excellentTypeName; //精品课程类型名称
objcc_ExcellentTypeENT.id_School = objcc_ExcellentTypeENS.id_School; //学校流水号
objcc_ExcellentTypeENT.isUse = objcc_ExcellentTypeENS.isUse; //是否使用
objcc_ExcellentTypeENT.updDate = objcc_ExcellentTypeENS.updDate; //修改日期
objcc_ExcellentTypeENT.updUserId = objcc_ExcellentTypeENS.updUserId; //修改用户Id
objcc_ExcellentTypeENT.memo = objcc_ExcellentTypeENS.memo; //备注
objcc_ExcellentTypeENT.sf_UpdFldSetStr = objcc_ExcellentTypeENS.updFldString; //sf_UpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objcc_ExcellentTypeENS:源对象
 * @param objcc_ExcellentTypeENT:目标对象
*/
export function cc_ExcellentType_GetObjFromJsonObj(objcc_ExcellentTypeENS: clscc_ExcellentTypeEN): clscc_ExcellentTypeEN 
{
 const objcc_ExcellentTypeENT: clscc_ExcellentTypeEN = new clscc_ExcellentTypeEN();
ObjectAssign(objcc_ExcellentTypeENT, objcc_ExcellentTypeENS);
 return objcc_ExcellentTypeENT;
}