
 /**
 * 类名:clsgs_PaperSubViewsAttitudesWApi
 * 表名:gs_PaperSubViewsAttitudes(01120755)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:55:26
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
 * 子观点态度(gs_PaperSubViewsAttitudes)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2023年03月13日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { enumComparisonOp } from "../../PubFun/enumComparisonOp.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { clsgs_PaperSubViewsAttitudesEN } from "../../L0_Entity/ParameterTable/clsgs_PaperSubViewsAttitudesEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { tzDataType } from "../../PubFun/clsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const gs_PaperSubViewsAttitudes_Controller = "gs_PaperSubViewsAttitudesApi";
 export const gs_PaperSubViewsAttitudes_ConstructorName = "gs_PaperSubViewsAttitudes";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strAttitudesId:关键字
 * @returns 对象
 **/
export async function gs_PaperSubViewsAttitudes_GetObjByAttitudesIdAsync(strAttitudesId: string): Promise<clsgs_PaperSubViewsAttitudesEN|null>  
{
const strThisFuncName = "GetObjByAttitudesIdAsync";

if (IsNullOrEmpty(strAttitudesId) == true)
{
  const strMsg = Format("参数:[strAttitudesId]不能为空！(In clsgs_PaperSubViewsAttitudesWApi.GetObjByAttitudesIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strAttitudesId.length != 2)
{
const strMsg = Format("缓存分类变量:[strAttitudesId]的长度:[{0}]不正确！(clsgs_PaperSubViewsAttitudesWApi.GetObjByAttitudesIdAsync)", strAttitudesId.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByAttitudesId";
const strUrl = GetWebApiUrl(gs_PaperSubViewsAttitudes_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strAttitudesId": strAttitudesId,
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
const objgs_PaperSubViewsAttitudes = gs_PaperSubViewsAttitudes_GetObjFromJsonObj(returnObj);
return objgs_PaperSubViewsAttitudes;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperSubViewsAttitudes_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperSubViewsAttitudes_ConstructorName, strThisFuncName);
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
 * @param strAttitudesId:所给的关键字
 * @returns 对象
*/
export async function gs_PaperSubViewsAttitudes_GetObjByAttitudesId_Cache(strAttitudesId: string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByAttitudesId_Cache";

if (IsNullOrEmpty(strAttitudesId) == true)
{
  const strMsg = Format("参数:[strAttitudesId]不能为空！(In clsgs_PaperSubViewsAttitudesWApi.GetObjByAttitudesId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strAttitudesId.length != 2)
{
const strMsg = Format("缓存分类变量:[strAttitudesId]的长度:[{0}]不正确！(clsgs_PaperSubViewsAttitudesWApi.GetObjByAttitudesId_Cache)", strAttitudesId.length);
console.error(strMsg);
throw (strMsg);
}
const arrgs_PaperSubViewsAttitudesObjLst_Cache = await gs_PaperSubViewsAttitudes_GetObjLst_Cache();
try
{
const arrgs_PaperSubViewsAttitudes_Sel: Array <clsgs_PaperSubViewsAttitudesEN> = arrgs_PaperSubViewsAttitudesObjLst_Cache.filter(x => 
 x.attitudesId == strAttitudesId );
let objgs_PaperSubViewsAttitudes: clsgs_PaperSubViewsAttitudesEN;
if (arrgs_PaperSubViewsAttitudes_Sel.length > 0)
{
objgs_PaperSubViewsAttitudes = arrgs_PaperSubViewsAttitudes_Sel[0];
return objgs_PaperSubViewsAttitudes;
}
else
{
if (bolTryAsyncOnce == true)
{
const objgs_PaperSubViewsAttitudes_Const = await gs_PaperSubViewsAttitudes_GetObjByAttitudesIdAsync(strAttitudesId);
if (objgs_PaperSubViewsAttitudes_Const != null)
{
gs_PaperSubViewsAttitudes_ReFreshThisCache();
return objgs_PaperSubViewsAttitudes_Const;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strAttitudesId, gs_PaperSubViewsAttitudes_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param strAttitudesId:所给的关键字
 * @returns 对象
*/
export async function gs_PaperSubViewsAttitudes_GetObjByAttitudesId_localStorage(strAttitudesId: string) {
const strThisFuncName = "GetObjByAttitudesId_localStorage";

if (IsNullOrEmpty(strAttitudesId) == true)
{
  const strMsg = Format("参数:[strAttitudesId]不能为空！(In clsgs_PaperSubViewsAttitudesWApi.GetObjByAttitudesId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
if (strAttitudesId.length != 2)
{
const strMsg = Format("缓存分类变量:[strAttitudesId]的长度:[{0}]不正确！(clsgs_PaperSubViewsAttitudesWApi.GetObjByAttitudesId_localStorage)", strAttitudesId.length);
console.error(strMsg);
throw (strMsg);
}
const strKey = Format("{0}_{1}", clsgs_PaperSubViewsAttitudesEN._CurrTabName, strAttitudesId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objgs_PaperSubViewsAttitudes_Cache: clsgs_PaperSubViewsAttitudesEN = JSON.parse(strTempObj);
return objgs_PaperSubViewsAttitudes_Cache;
}
try
{
const objgs_PaperSubViewsAttitudes = await gs_PaperSubViewsAttitudes_GetObjByAttitudesIdAsync(strAttitudesId);
if (objgs_PaperSubViewsAttitudes != null)
{
localStorage.setItem(strKey, JSON.stringify(objgs_PaperSubViewsAttitudes));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objgs_PaperSubViewsAttitudes;
}
return objgs_PaperSubViewsAttitudes;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strAttitudesId, gs_PaperSubViewsAttitudes_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objgs_PaperSubViewsAttitudes:所给的对象
 * @returns 对象
*/
export async function gs_PaperSubViewsAttitudes_UpdateObjInLst_Cache(objgs_PaperSubViewsAttitudes: clsgs_PaperSubViewsAttitudesEN) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrgs_PaperSubViewsAttitudesObjLst_Cache = await gs_PaperSubViewsAttitudes_GetObjLst_Cache();
const obj = arrgs_PaperSubViewsAttitudesObjLst_Cache.find(x => x.attitudesId == objgs_PaperSubViewsAttitudes.attitudesId);
if (obj != null)
{
objgs_PaperSubViewsAttitudes.attitudesId = obj.attitudesId;
ObjectAssign( obj, objgs_PaperSubViewsAttitudes);
}
else
{
arrgs_PaperSubViewsAttitudesObjLst_Cache.push(objgs_PaperSubViewsAttitudes);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, gs_PaperSubViewsAttitudes_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
}

/**
 * 根据关键字获取相关对象的名称属性, 从缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
 * @param strAttitudesId:所给的关键字
 * @returns 对象
*/
export async function gs_PaperSubViewsAttitudes_GetNameByAttitudesId_Cache(strAttitudesId: string) {
const strThisFuncName = "GetNameByAttitudesId_Cache";

if (IsNullOrEmpty(strAttitudesId) == true)
{
  const strMsg = Format("参数:[strAttitudesId]不能为空！(In clsgs_PaperSubViewsAttitudesWApi.GetNameByAttitudesId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strAttitudesId.length != 2)
{
const strMsg = Format("缓存分类变量:[strAttitudesId]的长度:[{0}]不正确！(clsgs_PaperSubViewsAttitudesWApi.GetNameByAttitudesId_Cache)", strAttitudesId.length);
console.error(strMsg);
throw (strMsg);
}
const arrgs_PaperSubViewsAttitudesObjLst_Cache = await gs_PaperSubViewsAttitudes_GetObjLst_Cache();
if (arrgs_PaperSubViewsAttitudesObjLst_Cache == null) return "";
try
{
const arrgs_PaperSubViewsAttitudes_Sel: Array <clsgs_PaperSubViewsAttitudesEN> = arrgs_PaperSubViewsAttitudesObjLst_Cache.filter(x => 
 x.attitudesId == strAttitudesId );
let objgs_PaperSubViewsAttitudes: clsgs_PaperSubViewsAttitudesEN;
if (arrgs_PaperSubViewsAttitudes_Sel.length > 0)
{
objgs_PaperSubViewsAttitudes = arrgs_PaperSubViewsAttitudes_Sel[0];
return objgs_PaperSubViewsAttitudes.attitudesName;
}
else
{
return "";
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strAttitudesId);
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
export async function gs_PaperSubViewsAttitudes_func(strInFldName:string , strOutFldName:string , strInValue:string )
{
//const strThisFuncName = "func";

if (strInFldName != clsgs_PaperSubViewsAttitudesEN.con_AttitudesId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsgs_PaperSubViewsAttitudesEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strOutFldName, clsgs_PaperSubViewsAttitudesEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strAttitudesId = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objgs_PaperSubViewsAttitudes = await gs_PaperSubViewsAttitudes_GetObjByAttitudesId_Cache(strAttitudesId );
if (objgs_PaperSubViewsAttitudes == null) return "";
if (objgs_PaperSubViewsAttitudes.GetFldValue(strOutFldName) == null) return "";
return objgs_PaperSubViewsAttitudes.GetFldValue(strOutFldName).toString();
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
export function gs_PaperSubViewsAttitudes_SortFun_Defa(a:clsgs_PaperSubViewsAttitudesEN , b:clsgs_PaperSubViewsAttitudesEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.attitudesId.localeCompare(b.attitudesId);
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
export function gs_PaperSubViewsAttitudes_SortFun_Defa_2Fld(a:clsgs_PaperSubViewsAttitudesEN , b:clsgs_PaperSubViewsAttitudesEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.attitudesName == b.attitudesName) return a.attitudesENName.localeCompare(b.attitudesENName);
else return a.attitudesName.localeCompare(b.attitudesName);
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
export function gs_PaperSubViewsAttitudes_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsgs_PaperSubViewsAttitudesEN.con_AttitudesId:
return (a: clsgs_PaperSubViewsAttitudesEN, b: clsgs_PaperSubViewsAttitudesEN) => {
return a.attitudesId.localeCompare(b.attitudesId);
}
case clsgs_PaperSubViewsAttitudesEN.con_AttitudesName:
return (a: clsgs_PaperSubViewsAttitudesEN, b: clsgs_PaperSubViewsAttitudesEN) => {
return a.attitudesName.localeCompare(b.attitudesName);
}
case clsgs_PaperSubViewsAttitudesEN.con_AttitudesENName:
return (a: clsgs_PaperSubViewsAttitudesEN, b: clsgs_PaperSubViewsAttitudesEN) => {
if (a.attitudesENName == null) return -1;
if (b.attitudesENName == null) return 1;
return a.attitudesENName.localeCompare(b.attitudesENName);
}
case clsgs_PaperSubViewsAttitudesEN.con_UpdUser:
return (a: clsgs_PaperSubViewsAttitudesEN, b: clsgs_PaperSubViewsAttitudesEN) => {
if (a.updUser == null) return -1;
if (b.updUser == null) return 1;
return a.updUser.localeCompare(b.updUser);
}
case clsgs_PaperSubViewsAttitudesEN.con_UpdDate:
return (a: clsgs_PaperSubViewsAttitudesEN, b: clsgs_PaperSubViewsAttitudesEN) => {
if (a.updDate == null) return -1;
if (b.updDate == null) return 1;
return a.updDate.localeCompare(b.updDate);
}
case clsgs_PaperSubViewsAttitudesEN.con_Memo:
return (a: clsgs_PaperSubViewsAttitudesEN, b: clsgs_PaperSubViewsAttitudesEN) => {
if (a.memo == null) return -1;
if (b.memo == null) return 1;
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_PaperSubViewsAttitudes]中不存在！(in ${ gs_PaperSubViewsAttitudes_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsgs_PaperSubViewsAttitudesEN.con_AttitudesId:
return (a: clsgs_PaperSubViewsAttitudesEN, b: clsgs_PaperSubViewsAttitudesEN) => {
return b.attitudesId.localeCompare(a.attitudesId);
}
case clsgs_PaperSubViewsAttitudesEN.con_AttitudesName:
return (a: clsgs_PaperSubViewsAttitudesEN, b: clsgs_PaperSubViewsAttitudesEN) => {
return b.attitudesName.localeCompare(a.attitudesName);
}
case clsgs_PaperSubViewsAttitudesEN.con_AttitudesENName:
return (a: clsgs_PaperSubViewsAttitudesEN, b: clsgs_PaperSubViewsAttitudesEN) => {
if (b.attitudesENName == null) return -1;
if (a.attitudesENName == null) return 1;
return b.attitudesENName.localeCompare(a.attitudesENName);
}
case clsgs_PaperSubViewsAttitudesEN.con_UpdUser:
return (a: clsgs_PaperSubViewsAttitudesEN, b: clsgs_PaperSubViewsAttitudesEN) => {
if (b.updUser == null) return -1;
if (a.updUser == null) return 1;
return b.updUser.localeCompare(a.updUser);
}
case clsgs_PaperSubViewsAttitudesEN.con_UpdDate:
return (a: clsgs_PaperSubViewsAttitudesEN, b: clsgs_PaperSubViewsAttitudesEN) => {
if (b.updDate == null) return -1;
if (a.updDate == null) return 1;
return b.updDate.localeCompare(a.updDate);
}
case clsgs_PaperSubViewsAttitudesEN.con_Memo:
return (a: clsgs_PaperSubViewsAttitudesEN, b: clsgs_PaperSubViewsAttitudesEN) => {
if (b.memo == null) return -1;
if (a.memo == null) return 1;
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_PaperSubViewsAttitudes]中不存在！(in ${ gs_PaperSubViewsAttitudes_ConstructorName}.${ strThisFuncName})`;
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
export async function gs_PaperSubViewsAttitudes_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsgs_PaperSubViewsAttitudesEN.con_AttitudesId:
return (obj: clsgs_PaperSubViewsAttitudesEN) => {
return obj.attitudesId === value;
}
case clsgs_PaperSubViewsAttitudesEN.con_AttitudesName:
return (obj: clsgs_PaperSubViewsAttitudesEN) => {
return obj.attitudesName === value;
}
case clsgs_PaperSubViewsAttitudesEN.con_AttitudesENName:
return (obj: clsgs_PaperSubViewsAttitudesEN) => {
return obj.attitudesENName === value;
}
case clsgs_PaperSubViewsAttitudesEN.con_UpdUser:
return (obj: clsgs_PaperSubViewsAttitudesEN) => {
return obj.updUser === value;
}
case clsgs_PaperSubViewsAttitudesEN.con_UpdDate:
return (obj: clsgs_PaperSubViewsAttitudesEN) => {
return obj.updDate === value;
}
case clsgs_PaperSubViewsAttitudesEN.con_Memo:
return (obj: clsgs_PaperSubViewsAttitudesEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_PaperSubViewsAttitudes]中不存在！(in ${ gs_PaperSubViewsAttitudes_ConstructorName}.${ strThisFuncName})`;
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
export async function gs_PaperSubViewsAttitudes_funcKey(strInFldName:string, strInValue: any, strComparisonOp:string): Promise<Array<string>> 
{
//const strThisFuncName = "funcKey";

if (strInFldName == clsgs_PaperSubViewsAttitudesEN.con_AttitudesId)
{
const strMsg = Format("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (IsNullOrEmpty(strInValue) == true)
{
return [];
}
const arrgs_PaperSubViewsAttitudes = await gs_PaperSubViewsAttitudes_GetObjLst_Cache();
if (arrgs_PaperSubViewsAttitudes == null) return [];
let arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes;
const strType = typeof(strInValue);
switch (strType)
{
case "string":
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01: // " = "
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
break;
case enumComparisonOp.Like_03:
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
break;
case enumComparisonOp.In_04:
const arrValues = strInValue.split(',');
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
break;
}
break;
case "boolean":
if (strInValue == null) return [];
if (strComparisonOp == enumComparisonOp.Equal_01)
{
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
}
break;
case "number":
if (Number(strInValue) == 0) return [];
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01:
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
break;
case enumComparisonOp.NotEqual_02:
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
break;
case enumComparisonOp.NotLessThan_05://" >= ":
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
break;
case enumComparisonOp.NotGreaterThan_06://" <= ":
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
case enumComparisonOp.GreaterThan_07://" > ":
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
break;
case enumComparisonOp.LessThan_08://" < ":
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
}
break;
}
if (arrgs_PaperSubViewsAttitudes_Sel.length == 0) return [];
return arrgs_PaperSubViewsAttitudes_Sel.map(x=>x.attitudesId);
}

 /**
 * 根据条件获取满足条件的第一条记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
 * @param strWhereCond:条件
 * @returns 返回的第一条记录的关键字值
 **/
export async function gs_PaperSubViewsAttitudes_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(gs_PaperSubViewsAttitudes_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperSubViewsAttitudes_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperSubViewsAttitudes_ConstructorName, strThisFuncName);
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
export async function gs_PaperSubViewsAttitudes_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(gs_PaperSubViewsAttitudes_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperSubViewsAttitudes_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperSubViewsAttitudes_ConstructorName, strThisFuncName);
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
export async function gs_PaperSubViewsAttitudes_GetFirstObjAsync(strWhereCond: string): Promise<clsgs_PaperSubViewsAttitudesEN|null>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(gs_PaperSubViewsAttitudes_Controller, strAction);
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
const objgs_PaperSubViewsAttitudes = gs_PaperSubViewsAttitudes_GetObjFromJsonObj(returnObj);
return objgs_PaperSubViewsAttitudes;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperSubViewsAttitudes_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperSubViewsAttitudes_ConstructorName, strThisFuncName);
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
export async function gs_PaperSubViewsAttitudes_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsgs_PaperSubViewsAttitudesEN._CurrTabName;
if (IsNullOrEmpty(clsgs_PaperSubViewsAttitudesEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsgs_PaperSubViewsAttitudesEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrgs_PaperSubViewsAttitudesExObjLst_Cache: Array<clsgs_PaperSubViewsAttitudesEN> = CacheHelper.Get(strKey);
const arrgs_PaperSubViewsAttitudesObjLst_T = gs_PaperSubViewsAttitudes_GetObjLstByJSONObjLst(arrgs_PaperSubViewsAttitudesExObjLst_Cache);
return arrgs_PaperSubViewsAttitudesObjLst_T;
}
try
{
const arrgs_PaperSubViewsAttitudesExObjLst = await gs_PaperSubViewsAttitudes_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrgs_PaperSubViewsAttitudesExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_PaperSubViewsAttitudesExObjLst.length);
console.log(strInfo);
return arrgs_PaperSubViewsAttitudesExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, gs_PaperSubViewsAttitudes_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_PaperSubViewsAttitudes_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsgs_PaperSubViewsAttitudesEN._CurrTabName;
if (IsNullOrEmpty(clsgs_PaperSubViewsAttitudesEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsgs_PaperSubViewsAttitudesEN.CacheAddiCondition);
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
const arrgs_PaperSubViewsAttitudesExObjLst_Cache: Array<clsgs_PaperSubViewsAttitudesEN> = JSON.parse(strTempObjLst);
const arrgs_PaperSubViewsAttitudesObjLst_T = gs_PaperSubViewsAttitudes_GetObjLstByJSONObjLst(arrgs_PaperSubViewsAttitudesExObjLst_Cache);
return arrgs_PaperSubViewsAttitudesObjLst_T;
}
try
{
const arrgs_PaperSubViewsAttitudesExObjLst = await gs_PaperSubViewsAttitudes_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrgs_PaperSubViewsAttitudesExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_PaperSubViewsAttitudesExObjLst.length);
console.log(strInfo);
return arrgs_PaperSubViewsAttitudesExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, gs_PaperSubViewsAttitudes_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_PaperSubViewsAttitudes_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsgs_PaperSubViewsAttitudesEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrgs_PaperSubViewsAttitudesObjLst_Cache: Array<clsgs_PaperSubViewsAttitudesEN> = JSON.parse(strTempObjLst);
return arrgs_PaperSubViewsAttitudesObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function gs_PaperSubViewsAttitudes_GetObjLstAsync(strWhereCond: string): Promise<Array<clsgs_PaperSubViewsAttitudesEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(gs_PaperSubViewsAttitudes_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_PaperSubViewsAttitudes_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_PaperSubViewsAttitudes_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperSubViewsAttitudes_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperSubViewsAttitudes_ConstructorName, strThisFuncName);
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
export async function gs_PaperSubViewsAttitudes_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsgs_PaperSubViewsAttitudesEN._CurrTabName;
if (IsNullOrEmpty(clsgs_PaperSubViewsAttitudesEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsgs_PaperSubViewsAttitudesEN.CacheAddiCondition);
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
const arrgs_PaperSubViewsAttitudesExObjLst_Cache: Array<clsgs_PaperSubViewsAttitudesEN> = JSON.parse(strTempObjLst);
const arrgs_PaperSubViewsAttitudesObjLst_T = gs_PaperSubViewsAttitudes_GetObjLstByJSONObjLst(arrgs_PaperSubViewsAttitudesExObjLst_Cache);
return arrgs_PaperSubViewsAttitudesObjLst_T;
}
try
{
const arrgs_PaperSubViewsAttitudesExObjLst = await gs_PaperSubViewsAttitudes_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrgs_PaperSubViewsAttitudesExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_PaperSubViewsAttitudesExObjLst.length);
console.log(strInfo);
return arrgs_PaperSubViewsAttitudesExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, gs_PaperSubViewsAttitudes_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_PaperSubViewsAttitudes_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsgs_PaperSubViewsAttitudesEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrgs_PaperSubViewsAttitudesObjLst_Cache: Array<clsgs_PaperSubViewsAttitudesEN> = JSON.parse(strTempObjLst);
return arrgs_PaperSubViewsAttitudesObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_PaperSubViewsAttitudes_GetObjLst_Cache(): Promise<Array<clsgs_PaperSubViewsAttitudesEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrgs_PaperSubViewsAttitudesObjLst_Cache;
switch (clsgs_PaperSubViewsAttitudesEN.CacheModeId)
{
case "04"://sessionStorage
arrgs_PaperSubViewsAttitudesObjLst_Cache = await gs_PaperSubViewsAttitudes_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrgs_PaperSubViewsAttitudesObjLst_Cache = await gs_PaperSubViewsAttitudes_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrgs_PaperSubViewsAttitudesObjLst_Cache = await gs_PaperSubViewsAttitudes_GetObjLst_ClientCache();
break;
default:
arrgs_PaperSubViewsAttitudesObjLst_Cache = await gs_PaperSubViewsAttitudes_GetObjLst_ClientCache();
break;
}
const arrgs_PaperSubViewsAttitudesObjLst = gs_PaperSubViewsAttitudes_GetObjLstByJSONObjLst(arrgs_PaperSubViewsAttitudesObjLst_Cache);
return arrgs_PaperSubViewsAttitudesObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_PaperSubViewsAttitudes_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrgs_PaperSubViewsAttitudesObjLst_Cache;
switch (clsgs_PaperSubViewsAttitudesEN.CacheModeId)
{
case "04"://sessionStorage
arrgs_PaperSubViewsAttitudesObjLst_Cache = await gs_PaperSubViewsAttitudes_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrgs_PaperSubViewsAttitudesObjLst_Cache = await gs_PaperSubViewsAttitudes_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrgs_PaperSubViewsAttitudesObjLst_Cache = null;
break;
default:
arrgs_PaperSubViewsAttitudesObjLst_Cache = null;
break;
}
return arrgs_PaperSubViewsAttitudesObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrAttitudesId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function gs_PaperSubViewsAttitudes_GetSubObjLst_Cache(objgs_PaperSubViewsAttitudes_Cond: clsgs_PaperSubViewsAttitudesEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrgs_PaperSubViewsAttitudesObjLst_Cache = await gs_PaperSubViewsAttitudes_GetObjLst_Cache();
let arrgs_PaperSubViewsAttitudes_Sel: Array < clsgs_PaperSubViewsAttitudesEN > = arrgs_PaperSubViewsAttitudesObjLst_Cache;
if (objgs_PaperSubViewsAttitudes_Cond.sf_FldComparisonOp == null || objgs_PaperSubViewsAttitudes_Cond.sf_FldComparisonOp == "") return arrgs_PaperSubViewsAttitudes_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_PaperSubViewsAttitudes_Cond.sf_FldComparisonOp);
//console.log("clsgs_PaperSubViewsAttitudesWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objgs_PaperSubViewsAttitudes_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_PaperSubViewsAttitudes_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrgs_PaperSubViewsAttitudes_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objgs_PaperSubViewsAttitudes_Cond), gs_PaperSubViewsAttitudes_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsgs_PaperSubViewsAttitudesEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrAttitudesId:关键字列表
 * @returns 对象列表
 **/
export async function gs_PaperSubViewsAttitudes_GetObjLstByAttitudesIdLstAsync(arrAttitudesId: Array<string>): Promise<Array<clsgs_PaperSubViewsAttitudesEN>>  
{
const strThisFuncName = "GetObjLstByAttitudesIdLstAsync";
const strAction = "GetObjLstByAttitudesIdLst";
const strUrl = GetWebApiUrl(gs_PaperSubViewsAttitudes_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrAttitudesId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_PaperSubViewsAttitudes_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_PaperSubViewsAttitudes_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperSubViewsAttitudes_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperSubViewsAttitudes_ConstructorName, strThisFuncName);
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
 * @param arrstrAttitudesIdLst:关键字列表
 * @returns 对象列表
*/
export async function gs_PaperSubViewsAttitudes_GetObjLstByAttitudesIdLst_Cache(arrAttitudesIdLst: Array<string>) {
const strThisFuncName = "GetObjLstByAttitudesIdLst_Cache";
try
{
const arrgs_PaperSubViewsAttitudesObjLst_Cache = await gs_PaperSubViewsAttitudes_GetObjLst_Cache();
const arrgs_PaperSubViewsAttitudes_Sel: Array <clsgs_PaperSubViewsAttitudesEN> = arrgs_PaperSubViewsAttitudesObjLst_Cache.filter(x => arrAttitudesIdLst.indexOf(x.attitudesId)>-1);
return arrgs_PaperSubViewsAttitudes_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrAttitudesIdLst.join(","), gs_PaperSubViewsAttitudes_ConstructorName, strThisFuncName);
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
export async function gs_PaperSubViewsAttitudes_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsgs_PaperSubViewsAttitudesEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(gs_PaperSubViewsAttitudes_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_PaperSubViewsAttitudes_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_PaperSubViewsAttitudes_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperSubViewsAttitudes_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperSubViewsAttitudes_ConstructorName, strThisFuncName);
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
export async function gs_PaperSubViewsAttitudes_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsgs_PaperSubViewsAttitudesEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(gs_PaperSubViewsAttitudes_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_PaperSubViewsAttitudes_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_PaperSubViewsAttitudes_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperSubViewsAttitudes_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperSubViewsAttitudes_ConstructorName, strThisFuncName);
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
export async function gs_PaperSubViewsAttitudes_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(gs_PaperSubViewsAttitudes_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperSubViewsAttitudes_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperSubViewsAttitudes_ConstructorName, strThisFuncName);
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
export async function gs_PaperSubViewsAttitudes_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
if (objPagerPara.pageIndex == 0) return new Array<clsgs_PaperSubViewsAttitudesEN>();
const arrgs_PaperSubViewsAttitudesObjLst_Cache = await gs_PaperSubViewsAttitudes_GetObjLst_Cache();
if (arrgs_PaperSubViewsAttitudesObjLst_Cache.length == 0) return arrgs_PaperSubViewsAttitudesObjLst_Cache;
let arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudesObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objgs_PaperSubViewsAttitudes_Cond = new clsgs_PaperSubViewsAttitudesEN();
ObjectAssign(objgs_PaperSubViewsAttitudes_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsgs_PaperSubViewsAttitudesWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_PaperSubViewsAttitudes_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrgs_PaperSubViewsAttitudes_Sel.length == 0) return arrgs_PaperSubViewsAttitudes_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.sort(gs_PaperSubViewsAttitudes_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.sort(objPagerPara.sortFun);
}
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.slice(intStart, intEnd);     
return arrgs_PaperSubViewsAttitudes_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, gs_PaperSubViewsAttitudes_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsgs_PaperSubViewsAttitudesEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function gs_PaperSubViewsAttitudes_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsgs_PaperSubViewsAttitudesEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
if (objPagerPara.pageIndex == 0) return new Array<clsgs_PaperSubViewsAttitudesEN>();
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(gs_PaperSubViewsAttitudes_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_PaperSubViewsAttitudes_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_PaperSubViewsAttitudes_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperSubViewsAttitudes_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperSubViewsAttitudes_ConstructorName, strThisFuncName);
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
 * @param strAttitudesId:关键字
 * @returns 获取删除的结果
 **/
export async function gs_PaperSubViewsAttitudes_DelRecordAsync(strAttitudesId: string): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(gs_PaperSubViewsAttitudes_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, strAttitudesId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperSubViewsAttitudes_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperSubViewsAttitudes_ConstructorName, strThisFuncName);
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
 * @param arrAttitudesId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function gs_PaperSubViewsAttitudes_Delgs_PaperSubViewsAttitudessAsync(arrAttitudesId: Array<string>): Promise<number> 
{
const strThisFuncName = "Delgs_PaperSubViewsAttitudessAsync";
const strAction = "Delgs_PaperSubViewsAttitudess";
const strUrl = GetWebApiUrl(gs_PaperSubViewsAttitudes_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrAttitudesId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperSubViewsAttitudes_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperSubViewsAttitudes_ConstructorName, strThisFuncName);
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
export async function gs_PaperSubViewsAttitudes_Delgs_PaperSubViewsAttitudessByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "Delgs_PaperSubViewsAttitudessByCondAsync";
const strAction = "Delgs_PaperSubViewsAttitudessByCond";
const strUrl = GetWebApiUrl(gs_PaperSubViewsAttitudes_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperSubViewsAttitudes_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperSubViewsAttitudes_ConstructorName, strThisFuncName);
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
 * @param objgs_PaperSubViewsAttitudesEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_PaperSubViewsAttitudes_AddNewRecordAsync(objgs_PaperSubViewsAttitudesEN: clsgs_PaperSubViewsAttitudesEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objgs_PaperSubViewsAttitudesEN);
const strUrl = GetWebApiUrl(gs_PaperSubViewsAttitudes_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_PaperSubViewsAttitudesEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperSubViewsAttitudes_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperSubViewsAttitudes_ConstructorName, strThisFuncName);
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
 * @param objgs_PaperSubViewsAttitudesEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_PaperSubViewsAttitudes_AddNewRecordWithMaxIdAsync(objgs_PaperSubViewsAttitudesEN: clsgs_PaperSubViewsAttitudesEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithMaxIdAsync";
const strAction = "AddNewRecordWithMaxId";
const strUrl = GetWebApiUrl(gs_PaperSubViewsAttitudes_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_PaperSubViewsAttitudesEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperSubViewsAttitudes_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperSubViewsAttitudes_ConstructorName, strThisFuncName);
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
 * @param objgs_PaperSubViewsAttitudesEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function gs_PaperSubViewsAttitudes_AddNewRecordWithReturnKeyAsync(objgs_PaperSubViewsAttitudesEN: clsgs_PaperSubViewsAttitudesEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(gs_PaperSubViewsAttitudes_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_PaperSubViewsAttitudesEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperSubViewsAttitudes_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperSubViewsAttitudes_ConstructorName, strThisFuncName);
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
 * @param objgs_PaperSubViewsAttitudesEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function gs_PaperSubViewsAttitudes_AddNewRecordWithReturnKey(objgs_PaperSubViewsAttitudesEN: clsgs_PaperSubViewsAttitudesEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objgs_PaperSubViewsAttitudesEN.attitudesId === null || objgs_PaperSubViewsAttitudesEN.attitudesId === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(gs_PaperSubViewsAttitudes_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_PaperSubViewsAttitudesEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperSubViewsAttitudes_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperSubViewsAttitudes_ConstructorName, strThisFuncName);
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
 * @param objgs_PaperSubViewsAttitudesEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function gs_PaperSubViewsAttitudes_UpdateRecordAsync(objgs_PaperSubViewsAttitudesEN: clsgs_PaperSubViewsAttitudesEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objgs_PaperSubViewsAttitudesEN.sfUpdFldSetStr === undefined || objgs_PaperSubViewsAttitudesEN.sfUpdFldSetStr === null || objgs_PaperSubViewsAttitudesEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_PaperSubViewsAttitudesEN.attitudesId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(gs_PaperSubViewsAttitudes_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_PaperSubViewsAttitudesEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperSubViewsAttitudes_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperSubViewsAttitudes_ConstructorName, strThisFuncName);
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
 * @param objgs_PaperSubViewsAttitudesEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function gs_PaperSubViewsAttitudes_UpdateWithConditionAsync(objgs_PaperSubViewsAttitudesEN: clsgs_PaperSubViewsAttitudesEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objgs_PaperSubViewsAttitudesEN.sfUpdFldSetStr === undefined || objgs_PaperSubViewsAttitudesEN.sfUpdFldSetStr === null || objgs_PaperSubViewsAttitudesEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_PaperSubViewsAttitudesEN.attitudesId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(gs_PaperSubViewsAttitudes_Controller, strAction);
objgs_PaperSubViewsAttitudesEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objgs_PaperSubViewsAttitudesEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperSubViewsAttitudes_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperSubViewsAttitudes_ConstructorName, strThisFuncName);
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
 * @param objstrAttitudesId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function gs_PaperSubViewsAttitudes_IsExistRecord_Cache(objgs_PaperSubViewsAttitudes_Cond: clsgs_PaperSubViewsAttitudesEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrgs_PaperSubViewsAttitudesObjLst_Cache = await gs_PaperSubViewsAttitudes_GetObjLst_Cache();
if (arrgs_PaperSubViewsAttitudesObjLst_Cache == null) return false;
let arrgs_PaperSubViewsAttitudes_Sel: Array < clsgs_PaperSubViewsAttitudesEN > = arrgs_PaperSubViewsAttitudesObjLst_Cache;
if (objgs_PaperSubViewsAttitudes_Cond.sf_FldComparisonOp == null || objgs_PaperSubViewsAttitudes_Cond.sf_FldComparisonOp == "") return arrgs_PaperSubViewsAttitudes_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_PaperSubViewsAttitudes_Cond.sf_FldComparisonOp);
//console.log("clsgs_PaperSubViewsAttitudesWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objgs_PaperSubViewsAttitudes_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_PaperSubViewsAttitudes_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrgs_PaperSubViewsAttitudes_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objgs_PaperSubViewsAttitudes_Cond), gs_PaperSubViewsAttitudes_ConstructorName, strThisFuncName);
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
export async function gs_PaperSubViewsAttitudes_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(gs_PaperSubViewsAttitudes_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperSubViewsAttitudes_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperSubViewsAttitudes_ConstructorName, strThisFuncName);
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
 * @param strAttitudesId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function gs_PaperSubViewsAttitudes_IsExist(strAttitudesId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(gs_PaperSubViewsAttitudes_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"AttitudesId": strAttitudesId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperSubViewsAttitudes_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperSubViewsAttitudes_ConstructorName, strThisFuncName);
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
 * @param strAttitudesId:所给的关键字
 * @returns 对象
*/
export async function gs_PaperSubViewsAttitudes_IsExist_Cache(strAttitudesId:string) {
const strThisFuncName = "IsExist_Cache";
const arrgs_PaperSubViewsAttitudesObjLst_Cache = await gs_PaperSubViewsAttitudes_GetObjLst_Cache();
if (arrgs_PaperSubViewsAttitudesObjLst_Cache == null) return false;
try
{
const arrgs_PaperSubViewsAttitudes_Sel: Array <clsgs_PaperSubViewsAttitudesEN> = arrgs_PaperSubViewsAttitudesObjLst_Cache.filter(x => x.attitudesId == strAttitudesId);
if (arrgs_PaperSubViewsAttitudes_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strAttitudesId, gs_PaperSubViewsAttitudes_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param strAttitudesId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function gs_PaperSubViewsAttitudes_IsExistAsync(strAttitudesId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(gs_PaperSubViewsAttitudes_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strAttitudesId": strAttitudesId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperSubViewsAttitudes_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperSubViewsAttitudes_ConstructorName, strThisFuncName);
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
export async function gs_PaperSubViewsAttitudes_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(gs_PaperSubViewsAttitudes_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperSubViewsAttitudes_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperSubViewsAttitudes_ConstructorName, strThisFuncName);
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
 * @param objgs_PaperSubViewsAttitudes_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function gs_PaperSubViewsAttitudes_GetRecCountByCond_Cache(objgs_PaperSubViewsAttitudes_Cond: clsgs_PaperSubViewsAttitudesEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrgs_PaperSubViewsAttitudesObjLst_Cache = await gs_PaperSubViewsAttitudes_GetObjLst_Cache();
if (arrgs_PaperSubViewsAttitudesObjLst_Cache == null) return 0;
let arrgs_PaperSubViewsAttitudes_Sel: Array < clsgs_PaperSubViewsAttitudesEN > = arrgs_PaperSubViewsAttitudesObjLst_Cache;
if (objgs_PaperSubViewsAttitudes_Cond.sf_FldComparisonOp == null || objgs_PaperSubViewsAttitudes_Cond.sf_FldComparisonOp == "") return arrgs_PaperSubViewsAttitudes_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_PaperSubViewsAttitudes_Cond.sf_FldComparisonOp);
//console.log("clsgs_PaperSubViewsAttitudesWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objgs_PaperSubViewsAttitudes_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_PaperSubViewsAttitudes_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_PaperSubViewsAttitudes_Sel = arrgs_PaperSubViewsAttitudes_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrgs_PaperSubViewsAttitudes_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objgs_PaperSubViewsAttitudes_Cond), gs_PaperSubViewsAttitudes_ConstructorName, strThisFuncName);
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
export async function gs_PaperSubViewsAttitudes_GetMaxStrIdAsync(): Promise<string>  
{
const strThisFuncName = "GetMaxStrIdAsync";
const strAction = "GetMaxStrId";
const strUrl = GetWebApiUrl(gs_PaperSubViewsAttitudes_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperSubViewsAttitudes_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperSubViewsAttitudes_ConstructorName, strThisFuncName);
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
export async function gs_PaperSubViewsAttitudes_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(gs_PaperSubViewsAttitudes_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperSubViewsAttitudes_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperSubViewsAttitudes_ConstructorName, strThisFuncName);
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
export function gs_PaperSubViewsAttitudes_GetWebApiUrl(strController: string, strAction: string): string {
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
export function gs_PaperSubViewsAttitudes_ReFreshCache():void
{
const strThisFuncName = "ReFreshCache";

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = clsgs_PaperSubViewsAttitudesEN._CurrTabName;
switch (clsgs_PaperSubViewsAttitudesEN.CacheModeId)
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
export function gs_PaperSubViewsAttitudes_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clsgs_PaperSubViewsAttitudesEN._CurrTabName;
switch (clsgs_PaperSubViewsAttitudesEN.CacheModeId)
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
export async function gs_PaperSubViewsAttitudes_BindDdl_AttitudesIdInDiv_Cache(strDivName: string, strDdlName: string )
{
const strThisFuncName = "BindDdl_AttitudesIdInDiv_Cache";

const objDdl = document.getElementById(strDdlName);
if (objDdl == null)
{
const strMsg = Format("下拉框：{0} 不存在！(In BindDdl_AttitudesIdInDiv)", strDdlName);
alert(strMsg);
console.error(strMsg);
throw (strMsg);
}
//为数据源于表的下拉框设置内容
//console.log("开始：BindDdl_AttitudesIdInDiv_Cache");
const arrObjLst_Sel = await gs_PaperSubViewsAttitudes_GetObjLst_Cache();
if (arrObjLst_Sel == null) return;
BindDdl_ObjLstInDiv(strDivName, strDdlName, arrObjLst_Sel, clsgs_PaperSubViewsAttitudesEN.con_AttitudesId, clsgs_PaperSubViewsAttitudesEN.con_AttitudesName, "子观点态度");
}

/**
 * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function gs_PaperSubViewsAttitudes_CheckPropertyNew(pobjgs_PaperSubViewsAttitudesEN: clsgs_PaperSubViewsAttitudesEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjgs_PaperSubViewsAttitudesEN.attitudesName) === true )
{
 throw new Error("(errid:Watl000058)字段[名称]不能为空(In 子观点态度)!(clsgs_PaperSubViewsAttitudesBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjgs_PaperSubViewsAttitudesEN.attitudesId) == false && GetStrLen(pobjgs_PaperSubViewsAttitudesEN.attitudesId) > 2)
{
 throw new Error("(errid:Watl000059)字段[态度Id(attitudesId)]的长度不能超过2(In 子观点态度(gs_PaperSubViewsAttitudes))!值:$(pobjgs_PaperSubViewsAttitudesEN.attitudesId)(clsgs_PaperSubViewsAttitudesBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperSubViewsAttitudesEN.attitudesName) == false && GetStrLen(pobjgs_PaperSubViewsAttitudesEN.attitudesName) > 200)
{
 throw new Error("(errid:Watl000059)字段[名称(attitudesName)]的长度不能超过200(In 子观点态度(gs_PaperSubViewsAttitudes))!值:$(pobjgs_PaperSubViewsAttitudesEN.attitudesName)(clsgs_PaperSubViewsAttitudesBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperSubViewsAttitudesEN.attitudesENName) == false && GetStrLen(pobjgs_PaperSubViewsAttitudesEN.attitudesENName) > 200)
{
 throw new Error("(errid:Watl000059)字段[态度英文名(attitudesENName)]的长度不能超过200(In 子观点态度(gs_PaperSubViewsAttitudes))!值:$(pobjgs_PaperSubViewsAttitudesEN.attitudesENName)(clsgs_PaperSubViewsAttitudesBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperSubViewsAttitudesEN.updUser) == false && GetStrLen(pobjgs_PaperSubViewsAttitudesEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 子观点态度(gs_PaperSubViewsAttitudes))!值:$(pobjgs_PaperSubViewsAttitudesEN.updUser)(clsgs_PaperSubViewsAttitudesBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperSubViewsAttitudesEN.updDate) == false && GetStrLen(pobjgs_PaperSubViewsAttitudesEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 子观点态度(gs_PaperSubViewsAttitudes))!值:$(pobjgs_PaperSubViewsAttitudesEN.updDate)(clsgs_PaperSubViewsAttitudesBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperSubViewsAttitudesEN.memo) == false && GetStrLen(pobjgs_PaperSubViewsAttitudesEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 子观点态度(gs_PaperSubViewsAttitudes))!值:$(pobjgs_PaperSubViewsAttitudesEN.memo)(clsgs_PaperSubViewsAttitudesBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjgs_PaperSubViewsAttitudesEN.attitudesId) == false && undefined !== pobjgs_PaperSubViewsAttitudesEN.attitudesId && tzDataType.isString(pobjgs_PaperSubViewsAttitudesEN.attitudesId) === false)
{
 throw new Error("(errid:Watl000060)字段[态度Id(attitudesId)]的值:[$(pobjgs_PaperSubViewsAttitudesEN.attitudesId)], 非法，应该为字符型(In 子观点态度(gs_PaperSubViewsAttitudes))!(clsgs_PaperSubViewsAttitudesBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperSubViewsAttitudesEN.attitudesName) == false && undefined !== pobjgs_PaperSubViewsAttitudesEN.attitudesName && tzDataType.isString(pobjgs_PaperSubViewsAttitudesEN.attitudesName) === false)
{
 throw new Error("(errid:Watl000060)字段[名称(attitudesName)]的值:[$(pobjgs_PaperSubViewsAttitudesEN.attitudesName)], 非法，应该为字符型(In 子观点态度(gs_PaperSubViewsAttitudes))!(clsgs_PaperSubViewsAttitudesBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperSubViewsAttitudesEN.attitudesENName) == false && undefined !== pobjgs_PaperSubViewsAttitudesEN.attitudesENName && tzDataType.isString(pobjgs_PaperSubViewsAttitudesEN.attitudesENName) === false)
{
 throw new Error("(errid:Watl000060)字段[态度英文名(attitudesENName)]的值:[$(pobjgs_PaperSubViewsAttitudesEN.attitudesENName)], 非法，应该为字符型(In 子观点态度(gs_PaperSubViewsAttitudes))!(clsgs_PaperSubViewsAttitudesBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperSubViewsAttitudesEN.updUser) == false && undefined !== pobjgs_PaperSubViewsAttitudesEN.updUser && tzDataType.isString(pobjgs_PaperSubViewsAttitudesEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjgs_PaperSubViewsAttitudesEN.updUser)], 非法，应该为字符型(In 子观点态度(gs_PaperSubViewsAttitudes))!(clsgs_PaperSubViewsAttitudesBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperSubViewsAttitudesEN.updDate) == false && undefined !== pobjgs_PaperSubViewsAttitudesEN.updDate && tzDataType.isString(pobjgs_PaperSubViewsAttitudesEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjgs_PaperSubViewsAttitudesEN.updDate)], 非法，应该为字符型(In 子观点态度(gs_PaperSubViewsAttitudes))!(clsgs_PaperSubViewsAttitudesBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperSubViewsAttitudesEN.memo) == false && undefined !== pobjgs_PaperSubViewsAttitudesEN.memo && tzDataType.isString(pobjgs_PaperSubViewsAttitudesEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjgs_PaperSubViewsAttitudesEN.memo)], 非法，应该为字符型(In 子观点态度(gs_PaperSubViewsAttitudes))!(clsgs_PaperSubViewsAttitudesBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjgs_PaperSubViewsAttitudesEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function gs_PaperSubViewsAttitudes_CheckProperty4Update (pobjgs_PaperSubViewsAttitudesEN: clsgs_PaperSubViewsAttitudesEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjgs_PaperSubViewsAttitudesEN.attitudesId) == false && GetStrLen(pobjgs_PaperSubViewsAttitudesEN.attitudesId) > 2)
{
 throw new Error("(errid:Watl000062)字段[态度Id(attitudesId)]的长度不能超过2(In 子观点态度(gs_PaperSubViewsAttitudes))!值:$(pobjgs_PaperSubViewsAttitudesEN.attitudesId)(clsgs_PaperSubViewsAttitudesBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperSubViewsAttitudesEN.attitudesName) == false && GetStrLen(pobjgs_PaperSubViewsAttitudesEN.attitudesName) > 200)
{
 throw new Error("(errid:Watl000062)字段[名称(attitudesName)]的长度不能超过200(In 子观点态度(gs_PaperSubViewsAttitudes))!值:$(pobjgs_PaperSubViewsAttitudesEN.attitudesName)(clsgs_PaperSubViewsAttitudesBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperSubViewsAttitudesEN.attitudesENName) == false && GetStrLen(pobjgs_PaperSubViewsAttitudesEN.attitudesENName) > 200)
{
 throw new Error("(errid:Watl000062)字段[态度英文名(attitudesENName)]的长度不能超过200(In 子观点态度(gs_PaperSubViewsAttitudes))!值:$(pobjgs_PaperSubViewsAttitudesEN.attitudesENName)(clsgs_PaperSubViewsAttitudesBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperSubViewsAttitudesEN.updUser) == false && GetStrLen(pobjgs_PaperSubViewsAttitudesEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 子观点态度(gs_PaperSubViewsAttitudes))!值:$(pobjgs_PaperSubViewsAttitudesEN.updUser)(clsgs_PaperSubViewsAttitudesBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperSubViewsAttitudesEN.updDate) == false && GetStrLen(pobjgs_PaperSubViewsAttitudesEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 子观点态度(gs_PaperSubViewsAttitudes))!值:$(pobjgs_PaperSubViewsAttitudesEN.updDate)(clsgs_PaperSubViewsAttitudesBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperSubViewsAttitudesEN.memo) == false && GetStrLen(pobjgs_PaperSubViewsAttitudesEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 子观点态度(gs_PaperSubViewsAttitudes))!值:$(pobjgs_PaperSubViewsAttitudesEN.memo)(clsgs_PaperSubViewsAttitudesBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjgs_PaperSubViewsAttitudesEN.attitudesId) == false && undefined !== pobjgs_PaperSubViewsAttitudesEN.attitudesId && tzDataType.isString(pobjgs_PaperSubViewsAttitudesEN.attitudesId) === false)
{
 throw new Error("(errid:Watl000063)字段[态度Id(attitudesId)]的值:[$(pobjgs_PaperSubViewsAttitudesEN.attitudesId)], 非法，应该为字符型(In 子观点态度(gs_PaperSubViewsAttitudes))!(clsgs_PaperSubViewsAttitudesBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperSubViewsAttitudesEN.attitudesName) == false && undefined !== pobjgs_PaperSubViewsAttitudesEN.attitudesName && tzDataType.isString(pobjgs_PaperSubViewsAttitudesEN.attitudesName) === false)
{
 throw new Error("(errid:Watl000063)字段[名称(attitudesName)]的值:[$(pobjgs_PaperSubViewsAttitudesEN.attitudesName)], 非法，应该为字符型(In 子观点态度(gs_PaperSubViewsAttitudes))!(clsgs_PaperSubViewsAttitudesBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperSubViewsAttitudesEN.attitudesENName) == false && undefined !== pobjgs_PaperSubViewsAttitudesEN.attitudesENName && tzDataType.isString(pobjgs_PaperSubViewsAttitudesEN.attitudesENName) === false)
{
 throw new Error("(errid:Watl000063)字段[态度英文名(attitudesENName)]的值:[$(pobjgs_PaperSubViewsAttitudesEN.attitudesENName)], 非法，应该为字符型(In 子观点态度(gs_PaperSubViewsAttitudes))!(clsgs_PaperSubViewsAttitudesBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperSubViewsAttitudesEN.updUser) == false && undefined !== pobjgs_PaperSubViewsAttitudesEN.updUser && tzDataType.isString(pobjgs_PaperSubViewsAttitudesEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjgs_PaperSubViewsAttitudesEN.updUser)], 非法，应该为字符型(In 子观点态度(gs_PaperSubViewsAttitudes))!(clsgs_PaperSubViewsAttitudesBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperSubViewsAttitudesEN.updDate) == false && undefined !== pobjgs_PaperSubViewsAttitudesEN.updDate && tzDataType.isString(pobjgs_PaperSubViewsAttitudesEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjgs_PaperSubViewsAttitudesEN.updDate)], 非法，应该为字符型(In 子观点态度(gs_PaperSubViewsAttitudes))!(clsgs_PaperSubViewsAttitudesBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperSubViewsAttitudesEN.memo) == false && undefined !== pobjgs_PaperSubViewsAttitudesEN.memo && tzDataType.isString(pobjgs_PaperSubViewsAttitudesEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjgs_PaperSubViewsAttitudesEN.memo)], 非法，应该为字符型(In 子观点态度(gs_PaperSubViewsAttitudes))!(clsgs_PaperSubViewsAttitudesBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (IsNullOrEmpty(pobjgs_PaperSubViewsAttitudesEN.attitudesId) === true 
 || pobjgs_PaperSubViewsAttitudesEN.attitudesId.toString()  ===  "0" )
{
 throw new Error("(errid:Watl000064)字段[态度Id]不能为空(In 子观点态度)!(clsgs_PaperSubViewsAttitudesBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjgs_PaperSubViewsAttitudesEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function gs_PaperSubViewsAttitudes_GetJSONStrByObj (pobjgs_PaperSubViewsAttitudesEN: clsgs_PaperSubViewsAttitudesEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjgs_PaperSubViewsAttitudesEN.sfUpdFldSetStr = pobjgs_PaperSubViewsAttitudesEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjgs_PaperSubViewsAttitudesEN);
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
export function gs_PaperSubViewsAttitudes_GetObjLstByJSONStr (strJSON: string): Array<clsgs_PaperSubViewsAttitudesEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrgs_PaperSubViewsAttitudesObjLst = new Array<clsgs_PaperSubViewsAttitudesEN>();
if (strJSON === "")
{
return arrgs_PaperSubViewsAttitudesObjLst;
}
try
{
arrgs_PaperSubViewsAttitudesObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrgs_PaperSubViewsAttitudesObjLst;
}
return arrgs_PaperSubViewsAttitudesObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrgs_PaperSubViewsAttitudesObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function gs_PaperSubViewsAttitudes_GetObjLstByJSONObjLst (arrgs_PaperSubViewsAttitudesObjLstS: Array<clsgs_PaperSubViewsAttitudesEN>): Array<clsgs_PaperSubViewsAttitudesEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrgs_PaperSubViewsAttitudesObjLst = new Array<clsgs_PaperSubViewsAttitudesEN>();
for (const objInFor of arrgs_PaperSubViewsAttitudesObjLstS) {
const obj1 = gs_PaperSubViewsAttitudes_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrgs_PaperSubViewsAttitudesObjLst.push(obj1);
}
return arrgs_PaperSubViewsAttitudesObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function gs_PaperSubViewsAttitudes_GetObjByJSONStr (strJSON: string): clsgs_PaperSubViewsAttitudesEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjgs_PaperSubViewsAttitudesEN = new clsgs_PaperSubViewsAttitudesEN();
if (strJSON === "")
{
return pobjgs_PaperSubViewsAttitudesEN;
}
try
{
pobjgs_PaperSubViewsAttitudesEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjgs_PaperSubViewsAttitudesEN;
}
return pobjgs_PaperSubViewsAttitudesEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function gs_PaperSubViewsAttitudes_GetCombineCondition(objgs_PaperSubViewsAttitudes_Cond: clsgs_PaperSubViewsAttitudesEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objgs_PaperSubViewsAttitudes_Cond.dicFldComparisonOp, clsgs_PaperSubViewsAttitudesEN.con_AttitudesId) == true)
{
const strComparisonOp_AttitudesId:string = objgs_PaperSubViewsAttitudes_Cond.dicFldComparisonOp[clsgs_PaperSubViewsAttitudesEN.con_AttitudesId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperSubViewsAttitudesEN.con_AttitudesId, objgs_PaperSubViewsAttitudes_Cond.attitudesId, strComparisonOp_AttitudesId);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperSubViewsAttitudes_Cond.dicFldComparisonOp, clsgs_PaperSubViewsAttitudesEN.con_AttitudesName) == true)
{
const strComparisonOp_AttitudesName:string = objgs_PaperSubViewsAttitudes_Cond.dicFldComparisonOp[clsgs_PaperSubViewsAttitudesEN.con_AttitudesName];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperSubViewsAttitudesEN.con_AttitudesName, objgs_PaperSubViewsAttitudes_Cond.attitudesName, strComparisonOp_AttitudesName);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperSubViewsAttitudes_Cond.dicFldComparisonOp, clsgs_PaperSubViewsAttitudesEN.con_AttitudesENName) == true)
{
const strComparisonOp_AttitudesENName:string = objgs_PaperSubViewsAttitudes_Cond.dicFldComparisonOp[clsgs_PaperSubViewsAttitudesEN.con_AttitudesENName];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperSubViewsAttitudesEN.con_AttitudesENName, objgs_PaperSubViewsAttitudes_Cond.attitudesENName, strComparisonOp_AttitudesENName);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperSubViewsAttitudes_Cond.dicFldComparisonOp, clsgs_PaperSubViewsAttitudesEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objgs_PaperSubViewsAttitudes_Cond.dicFldComparisonOp[clsgs_PaperSubViewsAttitudesEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperSubViewsAttitudesEN.con_UpdUser, objgs_PaperSubViewsAttitudes_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperSubViewsAttitudes_Cond.dicFldComparisonOp, clsgs_PaperSubViewsAttitudesEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objgs_PaperSubViewsAttitudes_Cond.dicFldComparisonOp[clsgs_PaperSubViewsAttitudesEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperSubViewsAttitudesEN.con_UpdDate, objgs_PaperSubViewsAttitudes_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperSubViewsAttitudes_Cond.dicFldComparisonOp, clsgs_PaperSubViewsAttitudesEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objgs_PaperSubViewsAttitudes_Cond.dicFldComparisonOp[clsgs_PaperSubViewsAttitudesEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperSubViewsAttitudesEN.con_Memo, objgs_PaperSubViewsAttitudes_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--gs_PaperSubViewsAttitudes(子观点态度),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param strAttitudesId: 态度Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function gs_PaperSubViewsAttitudes_GetUniCondStr_AttitudesId(objgs_PaperSubViewsAttitudesEN: clsgs_PaperSubViewsAttitudesEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and AttitudesId = '{0}'", objgs_PaperSubViewsAttitudesEN.attitudesId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--gs_PaperSubViewsAttitudes(子观点态度),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param strAttitudesId: 态度Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function gs_PaperSubViewsAttitudes_GetUniCondStr4Update_AttitudesId(objgs_PaperSubViewsAttitudesEN: clsgs_PaperSubViewsAttitudesEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and AttitudesId <> '{0}'", objgs_PaperSubViewsAttitudesEN.attitudesId);
 strWhereCond +=  Format(" and AttitudesId = '{0}'", objgs_PaperSubViewsAttitudesEN.attitudesId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objgs_PaperSubViewsAttitudesENS:源对象
 * @param objgs_PaperSubViewsAttitudesENT:目标对象
*/
export function gs_PaperSubViewsAttitudes_CopyObjTo(objgs_PaperSubViewsAttitudesENS: clsgs_PaperSubViewsAttitudesEN , objgs_PaperSubViewsAttitudesENT: clsgs_PaperSubViewsAttitudesEN ): void 
{
objgs_PaperSubViewsAttitudesENT.attitudesId = objgs_PaperSubViewsAttitudesENS.attitudesId; //态度Id
objgs_PaperSubViewsAttitudesENT.attitudesName = objgs_PaperSubViewsAttitudesENS.attitudesName; //名称
objgs_PaperSubViewsAttitudesENT.attitudesENName = objgs_PaperSubViewsAttitudesENS.attitudesENName; //态度英文名
objgs_PaperSubViewsAttitudesENT.updUser = objgs_PaperSubViewsAttitudesENS.updUser; //修改人
objgs_PaperSubViewsAttitudesENT.updDate = objgs_PaperSubViewsAttitudesENS.updDate; //修改日期
objgs_PaperSubViewsAttitudesENT.memo = objgs_PaperSubViewsAttitudesENS.memo; //备注
objgs_PaperSubViewsAttitudesENT.sfUpdFldSetStr = objgs_PaperSubViewsAttitudesENS.updFldString; //sfUpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objgs_PaperSubViewsAttitudesENS:源对象
 * @param objgs_PaperSubViewsAttitudesENT:目标对象
*/
export function gs_PaperSubViewsAttitudes_GetObjFromJsonObj(objgs_PaperSubViewsAttitudesENS: clsgs_PaperSubViewsAttitudesEN): clsgs_PaperSubViewsAttitudesEN 
{
 const objgs_PaperSubViewsAttitudesENT: clsgs_PaperSubViewsAttitudesEN = new clsgs_PaperSubViewsAttitudesEN();
ObjectAssign(objgs_PaperSubViewsAttitudesENT, objgs_PaperSubViewsAttitudesENS);
 return objgs_PaperSubViewsAttitudesENT;
}