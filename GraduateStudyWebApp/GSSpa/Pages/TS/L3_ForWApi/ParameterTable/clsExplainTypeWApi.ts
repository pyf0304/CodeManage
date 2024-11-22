
 /**
 * 类名:clsExplainTypeWApi
 * 表名:ExplainType(01120548)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:46:26
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
 * 说明类型(ExplainType)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clsExplainTypeEN } from "../../L0_Entity/ParameterTable/clsExplainTypeEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { tzDataType } from "../../PubFun/jsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const explainType_Controller = "ExplainTypeApi";
 export const explainType_ConstructorName = "explainType";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strExplainTypeId:关键字
 * @returns 对象
 **/
export async function ExplainType_GetObjByExplainTypeIdAsync(strExplainTypeId: string): Promise<clsExplainTypeEN>  
{
const strThisFuncName = "GetObjByExplainTypeIdAsync";

if (IsNullOrEmpty(strExplainTypeId) == true)
{
  const strMsg = Format("参数:[strExplainTypeId]不能为空！(In GetObjByExplainTypeIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strExplainTypeId.length != 2)
{
const strMsg = Format("缓存分类变量:[strExplainTypeId]的长度:[{0}]不正确！", strExplainTypeId.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByExplainTypeId";
const strUrl = GetWebApiUrl(explainType_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strExplainTypeId": strExplainTypeId,
}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObj = data.returnObj;
if (returnObj == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", explainType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objExplainType = ExplainType_GetObjFromJsonObj(returnObj);
return objExplainType;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, explainType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, explainType_ConstructorName, strThisFuncName);
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
 * @param strExplainTypeId:所给的关键字
 * @returns 对象
*/
export async function ExplainType_GetObjByExplainTypeId_Cache(strExplainTypeId: string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByExplainTypeId_Cache";

if (IsNullOrEmpty(strExplainTypeId) == true)
{
  const strMsg = Format("参数:[strExplainTypeId]不能为空！(In GetObjByExplainTypeId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strExplainTypeId.length != 2)
{
const strMsg = Format("缓存分类变量:[strExplainTypeId]的长度:[{0}]不正确！", strExplainTypeId.length);
console.error(strMsg);
throw (strMsg);
}
const arrExplainTypeObjLst_Cache = await ExplainType_GetObjLst_Cache();
try
{
const arrExplainType_Sel: Array <clsExplainTypeEN> = arrExplainTypeObjLst_Cache.filter(x => x.explainTypeId == strExplainTypeId);
let objExplainType: clsExplainTypeEN;
if (arrExplainType_Sel.length > 0)
{
objExplainType = arrExplainType_Sel[0];
return objExplainType;
}
else
{
if (bolTryAsyncOnce == true)
{
objExplainType = await ExplainType_GetObjByExplainTypeIdAsync(strExplainTypeId);
if (objExplainType != null)
{
ExplainType_ReFreshThisCache();
return objExplainType;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strExplainTypeId, explainType_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param strExplainTypeId:所给的关键字
 * @returns 对象
*/
export async function ExplainType_GetObjByExplainTypeId_localStorage(strExplainTypeId: string) {
const strThisFuncName = "GetObjByExplainTypeId_localStorage";

if (IsNullOrEmpty(strExplainTypeId) == true)
{
  const strMsg = Format("参数:[strExplainTypeId]不能为空！(In GetObjByExplainTypeId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
if (strExplainTypeId.length != 2)
{
const strMsg = Format("缓存分类变量:[strExplainTypeId]的长度:[{0}]不正确！", strExplainTypeId.length);
console.error(strMsg);
throw (strMsg);
}
const strKey = Format("{0}_{1}", clsExplainTypeEN._CurrTabName, strExplainTypeId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objExplainType_Cache: clsExplainTypeEN = JSON.parse(strTempObj);
return objExplainType_Cache;
}
try
{
const objExplainType = await ExplainType_GetObjByExplainTypeIdAsync(strExplainTypeId);
if (objExplainType != null)
{
localStorage.setItem(strKey, JSON.stringify(objExplainType));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objExplainType;
}
return objExplainType;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strExplainTypeId, explainType_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objExplainType:所给的对象
 * @returns 对象
*/
export async function ExplainType_UpdateObjInLst_Cache(objExplainType: clsExplainTypeEN) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrExplainTypeObjLst_Cache = await ExplainType_GetObjLst_Cache();
const obj = arrExplainTypeObjLst_Cache.find(x => 
x.explainTypeId == objExplainType.explainTypeId);
if (obj != null)
{
objExplainType.explainTypeId = obj.explainTypeId;
ObjectAssign( obj, objExplainType);
}
else
{
arrExplainTypeObjLst_Cache.push(objExplainType);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, explainType_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
}

/**
 * 根据关键字获取相关对象的名称属性, 从缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
 * @param strExplainTypeId:所给的关键字
 * @returns 对象
*/
export async function ExplainType_GetNameByExplainTypeId_Cache(strExplainTypeId: string) {
const strThisFuncName = "GetNameByExplainTypeId_Cache";

if (IsNullOrEmpty(strExplainTypeId) == true)
{
  const strMsg = Format("参数:[strExplainTypeId]不能为空！(In GetNameByExplainTypeId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strExplainTypeId.length != 2)
{
const strMsg = Format("缓存分类变量:[strExplainTypeId]的长度:[{0}]不正确！", strExplainTypeId.length);
console.error(strMsg);
throw (strMsg);
}
const arrExplainTypeObjLst_Cache = await ExplainType_GetObjLst_Cache();
if (arrExplainTypeObjLst_Cache == null) return "";
try
{
const arrExplainType_Sel: Array <clsExplainTypeEN> = arrExplainTypeObjLst_Cache.filter(x => x.explainTypeId == strExplainTypeId);
let objExplainType: clsExplainTypeEN;
if (arrExplainType_Sel.length > 0)
{
objExplainType = arrExplainType_Sel[0];
return objExplainType.explainTypeName;
}
else
{
return "";
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strExplainTypeId);
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
export async function ExplainType_func(strInFldName:string , strOutFldName:string ,  strInValue: string) 
{
//const strThisFuncName = "func";

if (strInFldName != clsExplainTypeEN.con_ExplainTypeId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsExplainTypeEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clsExplainTypeEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strExplainTypeId = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objExplainType = await ExplainType_GetObjByExplainTypeId_Cache(strExplainTypeId );
if (objExplainType == null) return "";
return objExplainType.GetFldValue(strOutFldName).toString();
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
export function ExplainType_SortFun_Defa(a:clsExplainTypeEN , b:clsExplainTypeEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.explainTypeId.localeCompare(b.explainTypeId);
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
export function ExplainType_SortFun_Defa_2Fld(a:clsExplainTypeEN , b:clsExplainTypeEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.explainTypeName == b.explainTypeName) return a.updDate.localeCompare(b.updDate);
else return a.explainTypeName.localeCompare(b.explainTypeName);
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
export function ExplainType_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsExplainTypeEN.con_ExplainTypeId:
return (a: clsExplainTypeEN, b: clsExplainTypeEN) => {
return a.explainTypeId.localeCompare(b.explainTypeId);
}
case clsExplainTypeEN.con_ExplainTypeName:
return (a: clsExplainTypeEN, b: clsExplainTypeEN) => {
return a.explainTypeName.localeCompare(b.explainTypeName);
}
case clsExplainTypeEN.con_UpdDate:
return (a: clsExplainTypeEN, b: clsExplainTypeEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsExplainTypeEN.con_UpdUserId:
return (a: clsExplainTypeEN, b: clsExplainTypeEN) => {
return a.updUserId.localeCompare(b.updUserId);
}
case clsExplainTypeEN.con_Memo:
return (a: clsExplainTypeEN, b: clsExplainTypeEN) => {
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[ExplainType]中不存在！(in ${ explainType_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsExplainTypeEN.con_ExplainTypeId:
return (a: clsExplainTypeEN, b: clsExplainTypeEN) => {
return b.explainTypeId.localeCompare(a.explainTypeId);
}
case clsExplainTypeEN.con_ExplainTypeName:
return (a: clsExplainTypeEN, b: clsExplainTypeEN) => {
return b.explainTypeName.localeCompare(a.explainTypeName);
}
case clsExplainTypeEN.con_UpdDate:
return (a: clsExplainTypeEN, b: clsExplainTypeEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsExplainTypeEN.con_UpdUserId:
return (a: clsExplainTypeEN, b: clsExplainTypeEN) => {
return b.updUserId.localeCompare(a.updUserId);
}
case clsExplainTypeEN.con_Memo:
return (a: clsExplainTypeEN, b: clsExplainTypeEN) => {
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[ExplainType]中不存在！(in ${ explainType_ConstructorName}.${ strThisFuncName})`;
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
export async function ExplainType_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsExplainTypeEN.con_ExplainTypeId:
return (obj: clsExplainTypeEN) => {
return obj.explainTypeId === value;
}
case clsExplainTypeEN.con_ExplainTypeName:
return (obj: clsExplainTypeEN) => {
return obj.explainTypeName === value;
}
case clsExplainTypeEN.con_UpdDate:
return (obj: clsExplainTypeEN) => {
return obj.updDate === value;
}
case clsExplainTypeEN.con_UpdUserId:
return (obj: clsExplainTypeEN) => {
return obj.updUserId === value;
}
case clsExplainTypeEN.con_Memo:
return (obj: clsExplainTypeEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[ExplainType]中不存在！(in ${ explainType_ConstructorName}.${ strThisFuncName})`;
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
export async function ExplainType_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(explainType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, explainType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, explainType_ConstructorName, strThisFuncName);
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
export async function ExplainType_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(explainType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, explainType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, explainType_ConstructorName, strThisFuncName);
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
export async function ExplainType_GetFirstObjAsync(strWhereCond: string): Promise<clsExplainTypeEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(explainType_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", explainType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objExplainType = ExplainType_GetObjFromJsonObj(returnObj);
return objExplainType;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, explainType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, explainType_ConstructorName, strThisFuncName);
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
export async function ExplainType_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsExplainTypeEN._CurrTabName;
clsExplainTypeEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsExplainTypeEN._CurrTabName);
if (IsNullOrEmpty(clsExplainTypeEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsExplainTypeEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrExplainTypeExObjLst_Cache: Array<clsExplainTypeEN> = CacheHelper.Get(strKey);
const arrExplainTypeObjLst_T = ExplainType_GetObjLstByJSONObjLst(arrExplainTypeExObjLst_Cache);
return arrExplainTypeObjLst_T;
}
try
{
const arrExplainTypeExObjLst = await ExplainType_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrExplainTypeExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrExplainTypeExObjLst.length);
console.log(strInfo);
return arrExplainTypeExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, explainType_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function ExplainType_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsExplainTypeEN._CurrTabName;
clsExplainTypeEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsExplainTypeEN._CurrTabName);
if (IsNullOrEmpty(clsExplainTypeEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsExplainTypeEN.CacheAddiCondition);
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
const arrExplainTypeExObjLst_Cache: Array<clsExplainTypeEN> = JSON.parse(strTempObjLst);
const arrExplainTypeObjLst_T = ExplainType_GetObjLstByJSONObjLst(arrExplainTypeExObjLst_Cache);
return arrExplainTypeObjLst_T;
}
try
{
const arrExplainTypeExObjLst = await ExplainType_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrExplainTypeExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrExplainTypeExObjLst.length);
console.log(strInfo);
return arrExplainTypeExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, explainType_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function ExplainType_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsExplainTypeEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrExplainTypeObjLst_Cache: Array<clsExplainTypeEN> = JSON.parse(strTempObjLst);
return arrExplainTypeObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function ExplainType_GetObjLstAsync(strWhereCond: string): Promise<Array<clsExplainTypeEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(explainType_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", explainType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = ExplainType_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, explainType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, explainType_ConstructorName, strThisFuncName);
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
export async function ExplainType_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsExplainTypeEN._CurrTabName;
clsExplainTypeEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsExplainTypeEN._CurrTabName);
if (IsNullOrEmpty(clsExplainTypeEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsExplainTypeEN.CacheAddiCondition);
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
const arrExplainTypeExObjLst_Cache: Array<clsExplainTypeEN> = JSON.parse(strTempObjLst);
const arrExplainTypeObjLst_T = ExplainType_GetObjLstByJSONObjLst(arrExplainTypeExObjLst_Cache);
return arrExplainTypeObjLst_T;
}
try
{
const arrExplainTypeExObjLst = await ExplainType_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrExplainTypeExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrExplainTypeExObjLst.length);
console.log(strInfo);
return arrExplainTypeExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, explainType_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function ExplainType_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsExplainTypeEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrExplainTypeObjLst_Cache: Array<clsExplainTypeEN> = JSON.parse(strTempObjLst);
return arrExplainTypeObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function ExplainType_GetObjLst_Cache(): Promise<Array<clsExplainTypeEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrExplainTypeObjLst_Cache;
switch (clsExplainTypeEN.CacheModeId)
{
case "04"://sessionStorage
arrExplainTypeObjLst_Cache = await ExplainType_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrExplainTypeObjLst_Cache = await ExplainType_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrExplainTypeObjLst_Cache = await ExplainType_GetObjLst_ClientCache();
break;
default:
arrExplainTypeObjLst_Cache = await ExplainType_GetObjLst_ClientCache();
break;
}
const arrExplainTypeObjLst = ExplainType_GetObjLstByJSONObjLst(arrExplainTypeObjLst_Cache);
return arrExplainTypeObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function ExplainType_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrExplainTypeObjLst_Cache;
switch (clsExplainTypeEN.CacheModeId)
{
case "04"://sessionStorage
arrExplainTypeObjLst_Cache = await ExplainType_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrExplainTypeObjLst_Cache = await ExplainType_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrExplainTypeObjLst_Cache = null;
break;
default:
arrExplainTypeObjLst_Cache = null;
break;
}
return arrExplainTypeObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrExplainTypeId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function ExplainType_GetSubObjLst_Cache(objExplainType_Cond: clsExplainTypeEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrExplainTypeObjLst_Cache = await ExplainType_GetObjLst_Cache();
let arrExplainType_Sel: Array < clsExplainTypeEN > = arrExplainTypeObjLst_Cache;
if (objExplainType_Cond.sf_FldComparisonOp == null || objExplainType_Cond.sf_FldComparisonOp == "") return arrExplainType_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objExplainType_Cond.sf_FldComparisonOp);
//console.log("clsExplainTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objExplainType_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objExplainType_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrExplainType_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objExplainType_Cond), explainType_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsExplainTypeEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrExplainTypeId:关键字列表
 * @returns 对象列表
 **/
export async function ExplainType_GetObjLstByExplainTypeIdLstAsync(arrExplainTypeId: Array<string>): Promise<Array<clsExplainTypeEN>>  
{
const strThisFuncName = "GetObjLstByExplainTypeIdLstAsync";
const strAction = "GetObjLstByExplainTypeIdLst";
const strUrl = GetWebApiUrl(explainType_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrExplainTypeId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", explainType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = ExplainType_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, explainType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, explainType_ConstructorName, strThisFuncName);
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
 * @param arrstrExplainTypeIdLst:关键字列表
 * @returns 对象列表
*/
export async function ExplainType_GetObjLstByExplainTypeIdLst_Cache(arrExplainTypeIdLst: Array<string>) {
const strThisFuncName = "GetObjLstByExplainTypeIdLst_Cache";
try
{
const arrExplainTypeObjLst_Cache = await ExplainType_GetObjLst_Cache();
const arrExplainType_Sel: Array <clsExplainTypeEN> = arrExplainTypeObjLst_Cache.filter(x => arrExplainTypeIdLst.indexOf(x.explainTypeId)>-1);
return arrExplainType_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrExplainTypeIdLst.join(","), explainType_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsExplainTypeEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function ExplainType_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsExplainTypeEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(explainType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", explainType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = ExplainType_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, explainType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, explainType_ConstructorName, strThisFuncName);
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
export async function ExplainType_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsExplainTypeEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(explainType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", explainType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = ExplainType_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, explainType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, explainType_ConstructorName, strThisFuncName);
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
export async function ExplainType_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(explainType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, explainType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, explainType_ConstructorName, strThisFuncName);
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
export async function ExplainType_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrExplainTypeObjLst_Cache = await ExplainType_GetObjLst_Cache();
if (arrExplainTypeObjLst_Cache.length == 0) return arrExplainTypeObjLst_Cache;
let arrExplainType_Sel = arrExplainTypeObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objExplainType_Cond = new clsExplainTypeEN();
ObjectAssign(objExplainType_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsExplainTypeWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objExplainType_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrExplainType_Sel = arrExplainType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrExplainType_Sel.length == 0) return arrExplainType_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrExplainType_Sel = arrExplainType_Sel.sort(ExplainType_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrExplainType_Sel = arrExplainType_Sel.sort(objPagerPara.sortFun);
}
arrExplainType_Sel = arrExplainType_Sel.slice(intStart, intEnd);     
return arrExplainType_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, explainType_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsExplainTypeEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function ExplainType_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsExplainTypeEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(explainType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", explainType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = ExplainType_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, explainType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, explainType_ConstructorName, strThisFuncName);
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
 * @param strExplainTypeId:关键字
 * @returns 获取删除的结果
 **/
export async function ExplainType_DelRecordAsync(strExplainTypeId: string): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(explainType_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, strExplainTypeId);
try
{
const response = await axios.delete(strUrl,
{
params: { "Id": strExplainTypeId, }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, explainType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, explainType_ConstructorName, strThisFuncName);
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
 * @param arrExplainTypeId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function ExplainType_DelExplainTypesAsync(arrExplainTypeId: Array<string>): Promise<number> 
{
const strThisFuncName = "DelExplainTypesAsync";
const strAction = "DelExplainTypes";
const strUrl = GetWebApiUrl(explainType_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrExplainTypeId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, explainType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, explainType_ConstructorName, strThisFuncName);
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
export async function ExplainType_DelExplainTypesByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "DelExplainTypesByCondAsync";
const strAction = "DelExplainTypesByCond";
const strUrl = GetWebApiUrl(explainType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, explainType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, explainType_ConstructorName, strThisFuncName);
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
 * @param objExplainTypeEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function ExplainType_AddNewRecordAsync(objExplainTypeEN: clsExplainTypeEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
if (objExplainTypeEN.explainTypeId === null || objExplainTypeEN.explainTypeId === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objExplainTypeEN);
const strUrl = GetWebApiUrl(explainType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objExplainTypeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, explainType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, explainType_ConstructorName, strThisFuncName);
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
 * @param objExplainTypeEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function ExplainType_AddNewRecordWithMaxIdAsync(objExplainTypeEN: clsExplainTypeEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithMaxIdAsync";
const strAction = "AddNewRecordWithMaxId";
const strUrl = GetWebApiUrl(explainType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objExplainTypeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, explainType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, explainType_ConstructorName, strThisFuncName);
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
 * @param objExplainTypeEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function ExplainType_AddNewRecordWithReturnKeyAsync(objExplainTypeEN: clsExplainTypeEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(explainType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objExplainTypeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, explainType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, explainType_ConstructorName, strThisFuncName);
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
 * @param objExplainTypeEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function ExplainType_AddNewRecordWithReturnKey(objExplainTypeEN: clsExplainTypeEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objExplainTypeEN.explainTypeId === null || objExplainTypeEN.explainTypeId === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(explainType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objExplainTypeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, explainType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, explainType_ConstructorName, strThisFuncName);
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
 * @param objExplainTypeEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function ExplainType_UpdateRecordAsync(objExplainTypeEN: clsExplainTypeEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objExplainTypeEN.sf_UpdFldSetStr === undefined || objExplainTypeEN.sf_UpdFldSetStr === null || objExplainTypeEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objExplainTypeEN.explainTypeId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(explainType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objExplainTypeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, explainType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, explainType_ConstructorName, strThisFuncName);
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
 * @param objExplainTypeEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function ExplainType_UpdateWithConditionAsync(objExplainTypeEN: clsExplainTypeEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objExplainTypeEN.sf_UpdFldSetStr === undefined || objExplainTypeEN.sf_UpdFldSetStr === null || objExplainTypeEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objExplainTypeEN.explainTypeId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(explainType_Controller, strAction);
objExplainTypeEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objExplainTypeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, explainType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, explainType_ConstructorName, strThisFuncName);
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
 * @param objstrExplainTypeId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function ExplainType_IsExistRecord_Cache(objExplainType_Cond: clsExplainTypeEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrExplainTypeObjLst_Cache = await ExplainType_GetObjLst_Cache();
if (arrExplainTypeObjLst_Cache == null) return false;
let arrExplainType_Sel: Array < clsExplainTypeEN > = arrExplainTypeObjLst_Cache;
if (objExplainType_Cond.sf_FldComparisonOp == null || objExplainType_Cond.sf_FldComparisonOp == "") return arrExplainType_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objExplainType_Cond.sf_FldComparisonOp);
//console.log("clsExplainTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objExplainType_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objExplainType_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrExplainType_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objExplainType_Cond), explainType_ConstructorName, strThisFuncName);
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
export async function ExplainType_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(explainType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, explainType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, explainType_ConstructorName, strThisFuncName);
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
 * @param strExplainTypeId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function ExplainType_IsExist(strExplainTypeId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(explainType_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"ExplainTypeId": strExplainTypeId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, explainType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, explainType_ConstructorName, strThisFuncName);
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
 * @param strExplainTypeId:所给的关键字
 * @returns 对象
*/
export async function ExplainType_IsExist_Cache(strExplainTypeId:string) {
const strThisFuncName = "IsExist_Cache";
const arrExplainTypeObjLst_Cache = await ExplainType_GetObjLst_Cache();
if (arrExplainTypeObjLst_Cache == null) return false;
try
{
const arrExplainType_Sel: Array <clsExplainTypeEN> = arrExplainTypeObjLst_Cache.filter(x => x.explainTypeId == strExplainTypeId);
if (arrExplainType_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strExplainTypeId, explainType_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param strExplainTypeId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function ExplainType_IsExistAsync(strExplainTypeId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(explainType_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strExplainTypeId": strExplainTypeId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, explainType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, explainType_ConstructorName, strThisFuncName);
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
export async function ExplainType_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(explainType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, explainType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, explainType_ConstructorName, strThisFuncName);
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
 * @param objExplainType_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function ExplainType_GetRecCountByCond_Cache(objExplainType_Cond: clsExplainTypeEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrExplainTypeObjLst_Cache = await ExplainType_GetObjLst_Cache();
if (arrExplainTypeObjLst_Cache == null) return 0;
let arrExplainType_Sel: Array < clsExplainTypeEN > = arrExplainTypeObjLst_Cache;
if (objExplainType_Cond.sf_FldComparisonOp == null || objExplainType_Cond.sf_FldComparisonOp == "") return arrExplainType_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objExplainType_Cond.sf_FldComparisonOp);
//console.log("clsExplainTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objExplainType_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objExplainType_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrExplainType_Sel = arrExplainType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrExplainType_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objExplainType_Cond), explainType_ConstructorName, strThisFuncName);
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
export async function ExplainType_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(explainType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, explainType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, explainType_ConstructorName, strThisFuncName);
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
export function ExplainType_GetWebApiUrl(strController: string, strAction: string): string {
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
export function ExplainType_ReFreshCache():void
{
const strThisFuncName = "ReFreshCache";

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = clsExplainTypeEN._CurrTabName;
switch (clsExplainTypeEN.CacheModeId)
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
export function ExplainType_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clsExplainTypeEN._CurrTabName;
switch (clsExplainTypeEN.CacheModeId)
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
export async function ExplainType_BindDdl_ExplainTypeIdInDiv_Cache(strDivName: string, strDdlName: string )
{
const strThisFuncName = "BindDdl_ExplainTypeIdInDiv_Cache";

const objDdl = document.getElementById(strDdlName);
if (objDdl == null)
{
const strMsg = Format("下拉框：{0} 不存在！(In BindDdl_ExplainTypeIdInDiv)", strDdlName);
alert(strMsg);
console.error(strMsg);
throw (strMsg);
}
//为数据源于表的下拉框设置内容
//console.log("开始：BindDdl_ExplainTypeIdInDiv_Cache");
const arrObjLst_Sel = await ExplainType_GetObjLst_Cache();
if (arrObjLst_Sel == null) return;
BindDdl_ObjLstInDiv(strDivName, strDdlName, arrObjLst_Sel, clsExplainTypeEN.con_ExplainTypeId, clsExplainTypeEN.con_ExplainTypeName, "说明类型");
}

/**
 * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function ExplainType_CheckPropertyNew(pobjExplainTypeEN: clsExplainTypeEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjExplainTypeEN.explainTypeId) == false && GetStrLen(pobjExplainTypeEN.explainTypeId) > 2)
{
 throw new Error("(errid:Watl000059)字段[说明类型Id(explainTypeId)]的长度不能超过2(In 说明类型(ExplainType))!值:$(pobjExplainTypeEN.explainTypeId)(clsExplainTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjExplainTypeEN.explainTypeName) == false && GetStrLen(pobjExplainTypeEN.explainTypeName) > 50)
{
 throw new Error("(errid:Watl000059)字段[说明类型名(explainTypeName)]的长度不能超过50(In 说明类型(ExplainType))!值:$(pobjExplainTypeEN.explainTypeName)(clsExplainTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjExplainTypeEN.updDate) == false && GetStrLen(pobjExplainTypeEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 说明类型(ExplainType))!值:$(pobjExplainTypeEN.updDate)(clsExplainTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjExplainTypeEN.updUserId) == false && GetStrLen(pobjExplainTypeEN.updUserId) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改用户Id(updUserId)]的长度不能超过20(In 说明类型(ExplainType))!值:$(pobjExplainTypeEN.updUserId)(clsExplainTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjExplainTypeEN.memo) == false && GetStrLen(pobjExplainTypeEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 说明类型(ExplainType))!值:$(pobjExplainTypeEN.memo)(clsExplainTypeBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjExplainTypeEN.explainTypeId) == false && undefined !== pobjExplainTypeEN.explainTypeId && tzDataType.isString(pobjExplainTypeEN.explainTypeId) === false)
{
 throw new Error("(errid:Watl000060)字段[说明类型Id(explainTypeId)]的值:[$(pobjExplainTypeEN.explainTypeId)], 非法，应该为字符型(In 说明类型(ExplainType))!(clsExplainTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjExplainTypeEN.explainTypeName) == false && undefined !== pobjExplainTypeEN.explainTypeName && tzDataType.isString(pobjExplainTypeEN.explainTypeName) === false)
{
 throw new Error("(errid:Watl000060)字段[说明类型名(explainTypeName)]的值:[$(pobjExplainTypeEN.explainTypeName)], 非法，应该为字符型(In 说明类型(ExplainType))!(clsExplainTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjExplainTypeEN.updDate) == false && undefined !== pobjExplainTypeEN.updDate && tzDataType.isString(pobjExplainTypeEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjExplainTypeEN.updDate)], 非法，应该为字符型(In 说明类型(ExplainType))!(clsExplainTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjExplainTypeEN.updUserId) == false && undefined !== pobjExplainTypeEN.updUserId && tzDataType.isString(pobjExplainTypeEN.updUserId) === false)
{
 throw new Error("(errid:Watl000060)字段[修改用户Id(updUserId)]的值:[$(pobjExplainTypeEN.updUserId)], 非法，应该为字符型(In 说明类型(ExplainType))!(clsExplainTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjExplainTypeEN.memo) == false && undefined !== pobjExplainTypeEN.memo && tzDataType.isString(pobjExplainTypeEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjExplainTypeEN.memo)], 非法，应该为字符型(In 说明类型(ExplainType))!(clsExplainTypeBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjExplainTypeEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function ExplainType_CheckProperty4Update (pobjExplainTypeEN: clsExplainTypeEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjExplainTypeEN.explainTypeId) == false && GetStrLen(pobjExplainTypeEN.explainTypeId) > 2)
{
 throw new Error("(errid:Watl000062)字段[说明类型Id(explainTypeId)]的长度不能超过2(In 说明类型(ExplainType))!值:$(pobjExplainTypeEN.explainTypeId)(clsExplainTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjExplainTypeEN.explainTypeName) == false && GetStrLen(pobjExplainTypeEN.explainTypeName) > 50)
{
 throw new Error("(errid:Watl000062)字段[说明类型名(explainTypeName)]的长度不能超过50(In 说明类型(ExplainType))!值:$(pobjExplainTypeEN.explainTypeName)(clsExplainTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjExplainTypeEN.updDate) == false && GetStrLen(pobjExplainTypeEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 说明类型(ExplainType))!值:$(pobjExplainTypeEN.updDate)(clsExplainTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjExplainTypeEN.updUserId) == false && GetStrLen(pobjExplainTypeEN.updUserId) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改用户Id(updUserId)]的长度不能超过20(In 说明类型(ExplainType))!值:$(pobjExplainTypeEN.updUserId)(clsExplainTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjExplainTypeEN.memo) == false && GetStrLen(pobjExplainTypeEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 说明类型(ExplainType))!值:$(pobjExplainTypeEN.memo)(clsExplainTypeBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjExplainTypeEN.explainTypeId) == false && undefined !== pobjExplainTypeEN.explainTypeId && tzDataType.isString(pobjExplainTypeEN.explainTypeId) === false)
{
 throw new Error("(errid:Watl000063)字段[说明类型Id(explainTypeId)]的值:[$(pobjExplainTypeEN.explainTypeId)], 非法，应该为字符型(In 说明类型(ExplainType))!(clsExplainTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjExplainTypeEN.explainTypeName) == false && undefined !== pobjExplainTypeEN.explainTypeName && tzDataType.isString(pobjExplainTypeEN.explainTypeName) === false)
{
 throw new Error("(errid:Watl000063)字段[说明类型名(explainTypeName)]的值:[$(pobjExplainTypeEN.explainTypeName)], 非法，应该为字符型(In 说明类型(ExplainType))!(clsExplainTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjExplainTypeEN.updDate) == false && undefined !== pobjExplainTypeEN.updDate && tzDataType.isString(pobjExplainTypeEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjExplainTypeEN.updDate)], 非法，应该为字符型(In 说明类型(ExplainType))!(clsExplainTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjExplainTypeEN.updUserId) == false && undefined !== pobjExplainTypeEN.updUserId && tzDataType.isString(pobjExplainTypeEN.updUserId) === false)
{
 throw new Error("(errid:Watl000063)字段[修改用户Id(updUserId)]的值:[$(pobjExplainTypeEN.updUserId)], 非法，应该为字符型(In 说明类型(ExplainType))!(clsExplainTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjExplainTypeEN.memo) == false && undefined !== pobjExplainTypeEN.memo && tzDataType.isString(pobjExplainTypeEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjExplainTypeEN.memo)], 非法，应该为字符型(In 说明类型(ExplainType))!(clsExplainTypeBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (IsNullOrEmpty(pobjExplainTypeEN.explainTypeId) === true 
 || pobjExplainTypeEN.explainTypeId.toString()  ===  "0" )
{
 throw new Error("(errid:Watl000064)字段[说明类型Id]不能为空(In 说明类型)!(clsExplainTypeBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjExplainTypeEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function ExplainType_GetJSONStrByObj (pobjExplainTypeEN: clsExplainTypeEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjExplainTypeEN.sf_UpdFldSetStr = pobjExplainTypeEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjExplainTypeEN);
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
export function ExplainType_GetObjLstByJSONStr (strJSON: string): Array<clsExplainTypeEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrExplainTypeObjLst = new Array<clsExplainTypeEN>();
if (strJSON === "")
{
return arrExplainTypeObjLst;
}
try
{
arrExplainTypeObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrExplainTypeObjLst;
}
return arrExplainTypeObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrExplainTypeObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function ExplainType_GetObjLstByJSONObjLst (arrExplainTypeObjLstS: Array<clsExplainTypeEN>): Array<clsExplainTypeEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrExplainTypeObjLst = new Array<clsExplainTypeEN>();
for (const objInFor of arrExplainTypeObjLstS) {
const obj1 = ExplainType_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrExplainTypeObjLst.push(obj1);
}
return arrExplainTypeObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function ExplainType_GetObjByJSONStr (strJSON: string): clsExplainTypeEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjExplainTypeEN = new clsExplainTypeEN();
if (strJSON === "")
{
return pobjExplainTypeEN;
}
try
{
pobjExplainTypeEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjExplainTypeEN;
}
return pobjExplainTypeEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function ExplainType_GetCombineCondition(objExplainType_Cond: clsExplainTypeEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objExplainType_Cond.dicFldComparisonOp, clsExplainTypeEN.con_ExplainTypeId) == true)
{
const strComparisonOp_ExplainTypeId:string = objExplainType_Cond.dicFldComparisonOp[clsExplainTypeEN.con_ExplainTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsExplainTypeEN.con_ExplainTypeId, objExplainType_Cond.explainTypeId, strComparisonOp_ExplainTypeId);
}
if (Object.prototype.hasOwnProperty.call(objExplainType_Cond.dicFldComparisonOp, clsExplainTypeEN.con_ExplainTypeName) == true)
{
const strComparisonOp_ExplainTypeName:string = objExplainType_Cond.dicFldComparisonOp[clsExplainTypeEN.con_ExplainTypeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsExplainTypeEN.con_ExplainTypeName, objExplainType_Cond.explainTypeName, strComparisonOp_ExplainTypeName);
}
if (Object.prototype.hasOwnProperty.call(objExplainType_Cond.dicFldComparisonOp, clsExplainTypeEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objExplainType_Cond.dicFldComparisonOp[clsExplainTypeEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsExplainTypeEN.con_UpdDate, objExplainType_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objExplainType_Cond.dicFldComparisonOp, clsExplainTypeEN.con_UpdUserId) == true)
{
const strComparisonOp_UpdUserId:string = objExplainType_Cond.dicFldComparisonOp[clsExplainTypeEN.con_UpdUserId];
strWhereCond += Format(" And {0} {2} '{1}'", clsExplainTypeEN.con_UpdUserId, objExplainType_Cond.updUserId, strComparisonOp_UpdUserId);
}
if (Object.prototype.hasOwnProperty.call(objExplainType_Cond.dicFldComparisonOp, clsExplainTypeEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objExplainType_Cond.dicFldComparisonOp[clsExplainTypeEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsExplainTypeEN.con_Memo, objExplainType_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objExplainTypeENS:源对象
 * @param objExplainTypeENT:目标对象
*/
export function ExplainType_CopyObjTo(objExplainTypeENS: clsExplainTypeEN , objExplainTypeENT: clsExplainTypeEN ): void 
{
objExplainTypeENT.explainTypeId = objExplainTypeENS.explainTypeId; //说明类型Id
objExplainTypeENT.explainTypeName = objExplainTypeENS.explainTypeName; //说明类型名
objExplainTypeENT.updDate = objExplainTypeENS.updDate; //修改日期
objExplainTypeENT.updUserId = objExplainTypeENS.updUserId; //修改用户Id
objExplainTypeENT.memo = objExplainTypeENS.memo; //备注
objExplainTypeENT.sf_UpdFldSetStr = objExplainTypeENS.updFldString; //sf_UpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objExplainTypeENS:源对象
 * @param objExplainTypeENT:目标对象
*/
export function ExplainType_GetObjFromJsonObj(objExplainTypeENS: clsExplainTypeEN): clsExplainTypeEN 
{
 const objExplainTypeENT: clsExplainTypeEN = new clsExplainTypeEN();
ObjectAssign(objExplainTypeENT, objExplainTypeENS);
 return objExplainTypeENT;
}