﻿
 /**
 * 类名:clsLoginLogWApi
 * 表名:LoginLog(01120357)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:52:52
 * 生成者:pyf
 * 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:日志管理(LogManage)
 * 框架-层名:WA_访问层(TS)(WA_Access)
 * 编程语言:TypeScript
 * 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
   *      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 **/

/**
 * 登录日志(LoginLog)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2023年03月13日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { enumComparisonOp } from "../../PubFun/enumComparisonOp.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { clsLoginLogEN } from "../../L0_Entity/LogManage/clsLoginLogEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { tzDataType } from "../../PubFun/clsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const loginLog_Controller = "LoginLogApi";
 export const loginLog_ConstructorName = "loginLog";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngLoginLogId:关键字
 * @returns 对象
 **/
export async function LoginLog_GetObjByLoginLogIdAsync(lngLoginLogId: number): Promise<clsLoginLogEN|null>  
{
const strThisFuncName = "GetObjByLoginLogIdAsync";

if (lngLoginLogId == 0)
{
  const strMsg = Format("参数:[lngLoginLogId]不能为空！(In clsLoginLogWApi.GetObjByLoginLogIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjByLoginLogId";
const strUrl = GetWebApiUrl(loginLog_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"lngLoginLogId": lngLoginLogId,
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
const objLoginLog = LoginLog_GetObjFromJsonObj(returnObj);
return objLoginLog;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, loginLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, loginLog_ConstructorName, strThisFuncName);
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
 * @param lngLoginLogId:所给的关键字
 * @returns 对象
*/
export async function LoginLog_GetObjByLoginLogId_Cache(lngLoginLogId: number, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByLoginLogId_Cache";

if (lngLoginLogId == 0)
{
  const strMsg = Format("参数:[lngLoginLogId]不能为空！(In clsLoginLogWApi.GetObjByLoginLogId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
const arrLoginLogObjLst_Cache = await LoginLog_GetObjLst_Cache();
try
{
const arrLoginLog_Sel: Array <clsLoginLogEN> = arrLoginLogObjLst_Cache.filter(x => 
 x.loginLogId == lngLoginLogId );
let objLoginLog: clsLoginLogEN;
if (arrLoginLog_Sel.length > 0)
{
objLoginLog = arrLoginLog_Sel[0];
return objLoginLog;
}
else
{
if (bolTryAsyncOnce == true)
{
const objLoginLog_Const = await LoginLog_GetObjByLoginLogIdAsync(lngLoginLogId);
if (objLoginLog_Const != null)
{
LoginLog_ReFreshThisCache();
return objLoginLog_Const;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngLoginLogId, loginLog_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param lngLoginLogId:所给的关键字
 * @returns 对象
*/
export async function LoginLog_GetObjByLoginLogId_localStorage(lngLoginLogId: number) {
const strThisFuncName = "GetObjByLoginLogId_localStorage";

if (lngLoginLogId == 0)
{
  const strMsg = Format("参数:[lngLoginLogId]不能为空！(In clsLoginLogWApi.GetObjByLoginLogId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
const strKey = Format("{0}_{1}", clsLoginLogEN._CurrTabName, lngLoginLogId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objLoginLog_Cache: clsLoginLogEN = JSON.parse(strTempObj);
return objLoginLog_Cache;
}
try
{
const objLoginLog = await LoginLog_GetObjByLoginLogIdAsync(lngLoginLogId);
if (objLoginLog != null)
{
localStorage.setItem(strKey, JSON.stringify(objLoginLog));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objLoginLog;
}
return objLoginLog;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngLoginLogId, loginLog_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objLoginLog:所给的对象
 * @returns 对象
*/
export async function LoginLog_UpdateObjInLst_Cache(objLoginLog: clsLoginLogEN) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrLoginLogObjLst_Cache = await LoginLog_GetObjLst_Cache();
const obj = arrLoginLogObjLst_Cache.find(x => x.loginUserId == objLoginLog.loginUserId && x.loginIP == objLoginLog.loginIP && x.loginTime == objLoginLog.loginTime);
if (obj != null)
{
objLoginLog.loginLogId = obj.loginLogId;
ObjectAssign( obj, objLoginLog);
}
else
{
arrLoginLogObjLst_Cache.push(objLoginLog);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, loginLog_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
}
/*该表没有名称字段，不能生成此函数！*/

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
export async function LoginLog_func(strInFldName:string , strOutFldName:string , strInValue:string )
{
//const strThisFuncName = "func";

if (strInFldName != clsLoginLogEN.con_LoginLogId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsLoginLogEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strOutFldName, clsLoginLogEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const lngLoginLogId = Number(strInValue);
if (lngLoginLogId == 0)
{
return "";
}
const objLoginLog = await LoginLog_GetObjByLoginLogId_Cache(lngLoginLogId );
if (objLoginLog == null) return "";
if (objLoginLog.GetFldValue(strOutFldName) == null) return "";
return objLoginLog.GetFldValue(strOutFldName).toString();
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
export function LoginLog_SortFun_Defa(a:clsLoginLogEN , b:clsLoginLogEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.loginLogId-b.loginLogId;
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
export function LoginLog_SortFun_Defa_2Fld(a:clsLoginLogEN , b:clsLoginLogEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.loginLogNumber == b.loginLogNumber) return a.loginIP.localeCompare(b.loginIP);
else return a.loginLogNumber.localeCompare(b.loginLogNumber);
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
export function LoginLog_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsLoginLogEN.con_LoginLogId:
return (a: clsLoginLogEN, b: clsLoginLogEN) => {
return a.loginLogId-b.loginLogId;
}
case clsLoginLogEN.con_LoginLogNumber:
return (a: clsLoginLogEN, b: clsLoginLogEN) => {
if (a.loginLogNumber == null) return -1;
if (b.loginLogNumber == null) return 1;
return a.loginLogNumber.localeCompare(b.loginLogNumber);
}
case clsLoginLogEN.con_LoginIP:
return (a: clsLoginLogEN, b: clsLoginLogEN) => {
if (a.loginIP == null) return -1;
if (b.loginIP == null) return 1;
return a.loginIP.localeCompare(b.loginIP);
}
case clsLoginLogEN.con_FailReason:
return (a: clsLoginLogEN, b: clsLoginLogEN) => {
if (a.failReason == null) return -1;
if (b.failReason == null) return 1;
return a.failReason.localeCompare(b.failReason);
}
case clsLoginLogEN.con_LoginResult:
return (a: clsLoginLogEN, b: clsLoginLogEN) => {
if (a.loginResult == null) return -1;
if (b.loginResult == null) return 1;
return a.loginResult.localeCompare(b.loginResult);
}
case clsLoginLogEN.con_LoginTime:
return (a: clsLoginLogEN, b: clsLoginLogEN) => {
if (a.loginTime == null) return -1;
if (b.loginTime == null) return 1;
return a.loginTime.localeCompare(b.loginTime);
}
case clsLoginLogEN.con_LoginUserId:
return (a: clsLoginLogEN, b: clsLoginLogEN) => {
if (a.loginUserId == null) return -1;
if (b.loginUserId == null) return 1;
return a.loginUserId.localeCompare(b.loginUserId);
}
case clsLoginLogEN.con_OnlineTime:
return (a: clsLoginLogEN, b: clsLoginLogEN) => {
if (a.onlineTime == null) return -1;
if (b.onlineTime == null) return 1;
return a.onlineTime.localeCompare(b.onlineTime);
}
case clsLoginLogEN.con_OutTime:
return (a: clsLoginLogEN, b: clsLoginLogEN) => {
if (a.outTime == null) return -1;
if (b.outTime == null) return 1;
return a.outTime.localeCompare(b.outTime);
}
case clsLoginLogEN.con_Memo:
return (a: clsLoginLogEN, b: clsLoginLogEN) => {
if (a.memo == null) return -1;
if (b.memo == null) return 1;
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[LoginLog]中不存在！(in ${ loginLog_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsLoginLogEN.con_LoginLogId:
return (a: clsLoginLogEN, b: clsLoginLogEN) => {
return b.loginLogId-a.loginLogId;
}
case clsLoginLogEN.con_LoginLogNumber:
return (a: clsLoginLogEN, b: clsLoginLogEN) => {
if (b.loginLogNumber == null) return -1;
if (a.loginLogNumber == null) return 1;
return b.loginLogNumber.localeCompare(a.loginLogNumber);
}
case clsLoginLogEN.con_LoginIP:
return (a: clsLoginLogEN, b: clsLoginLogEN) => {
if (b.loginIP == null) return -1;
if (a.loginIP == null) return 1;
return b.loginIP.localeCompare(a.loginIP);
}
case clsLoginLogEN.con_FailReason:
return (a: clsLoginLogEN, b: clsLoginLogEN) => {
if (b.failReason == null) return -1;
if (a.failReason == null) return 1;
return b.failReason.localeCompare(a.failReason);
}
case clsLoginLogEN.con_LoginResult:
return (a: clsLoginLogEN, b: clsLoginLogEN) => {
if (b.loginResult == null) return -1;
if (a.loginResult == null) return 1;
return b.loginResult.localeCompare(a.loginResult);
}
case clsLoginLogEN.con_LoginTime:
return (a: clsLoginLogEN, b: clsLoginLogEN) => {
if (b.loginTime == null) return -1;
if (a.loginTime == null) return 1;
return b.loginTime.localeCompare(a.loginTime);
}
case clsLoginLogEN.con_LoginUserId:
return (a: clsLoginLogEN, b: clsLoginLogEN) => {
if (b.loginUserId == null) return -1;
if (a.loginUserId == null) return 1;
return b.loginUserId.localeCompare(a.loginUserId);
}
case clsLoginLogEN.con_OnlineTime:
return (a: clsLoginLogEN, b: clsLoginLogEN) => {
if (b.onlineTime == null) return -1;
if (a.onlineTime == null) return 1;
return b.onlineTime.localeCompare(a.onlineTime);
}
case clsLoginLogEN.con_OutTime:
return (a: clsLoginLogEN, b: clsLoginLogEN) => {
if (b.outTime == null) return -1;
if (a.outTime == null) return 1;
return b.outTime.localeCompare(a.outTime);
}
case clsLoginLogEN.con_Memo:
return (a: clsLoginLogEN, b: clsLoginLogEN) => {
if (b.memo == null) return -1;
if (a.memo == null) return 1;
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[LoginLog]中不存在！(in ${ loginLog_ConstructorName}.${ strThisFuncName})`;
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
export async function LoginLog_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsLoginLogEN.con_LoginLogId:
return (obj: clsLoginLogEN) => {
return obj.loginLogId === value;
}
case clsLoginLogEN.con_LoginLogNumber:
return (obj: clsLoginLogEN) => {
return obj.loginLogNumber === value;
}
case clsLoginLogEN.con_LoginIP:
return (obj: clsLoginLogEN) => {
return obj.loginIP === value;
}
case clsLoginLogEN.con_FailReason:
return (obj: clsLoginLogEN) => {
return obj.failReason === value;
}
case clsLoginLogEN.con_LoginResult:
return (obj: clsLoginLogEN) => {
return obj.loginResult === value;
}
case clsLoginLogEN.con_LoginTime:
return (obj: clsLoginLogEN) => {
return obj.loginTime === value;
}
case clsLoginLogEN.con_LoginUserId:
return (obj: clsLoginLogEN) => {
return obj.loginUserId === value;
}
case clsLoginLogEN.con_OnlineTime:
return (obj: clsLoginLogEN) => {
return obj.onlineTime === value;
}
case clsLoginLogEN.con_OutTime:
return (obj: clsLoginLogEN) => {
return obj.outTime === value;
}
case clsLoginLogEN.con_Memo:
return (obj: clsLoginLogEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[LoginLog]中不存在！(in ${ loginLog_ConstructorName}.${ strThisFuncName})`;
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
export async function LoginLog_funcKey(strInFldName:string, strInValue: any, strComparisonOp:string): Promise<Array<number>> 
{
//const strThisFuncName = "funcKey";

if (strInFldName == clsLoginLogEN.con_LoginLogId)
{
const strMsg = Format("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (Number(strInValue) == 0)
{
return [];
}
const arrLoginLog = await LoginLog_GetObjLst_Cache();
if (arrLoginLog == null) return [];
let arrLoginLog_Sel = arrLoginLog;
const strType = typeof(strInValue);
switch (strType)
{
case "string":
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01: // " = "
arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
break;
case enumComparisonOp.Like_03:
arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
break;
case enumComparisonOp.In_04:
const arrValues = strInValue.split(',');
arrLoginLog_Sel = arrLoginLog_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
break;
}
break;
case "boolean":
if (strInValue == null) return [];
if (strComparisonOp == enumComparisonOp.Equal_01)
{
arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
}
break;
case "number":
if (Number(strInValue) == 0) return [];
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01:
arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
break;
case enumComparisonOp.NotEqual_02:
arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
break;
case enumComparisonOp.NotLessThan_05://" >= ":
arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
break;
case enumComparisonOp.NotGreaterThan_06://" <= ":
arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
case enumComparisonOp.GreaterThan_07://" > ":
arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
break;
case enumComparisonOp.LessThan_08://" < ":
arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
}
break;
}
if (arrLoginLog_Sel.length == 0) return [];
return arrLoginLog_Sel.map(x=>x.loginLogId);
}

 /**
 * 根据条件获取满足条件的第一条记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
 * @param strWhereCond:条件
 * @returns 返回的第一条记录的关键字值
 **/
export async function LoginLog_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(loginLog_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, loginLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, loginLog_ConstructorName, strThisFuncName);
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
export async function LoginLog_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(loginLog_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, loginLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, loginLog_ConstructorName, strThisFuncName);
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
export async function LoginLog_GetFirstObjAsync(strWhereCond: string): Promise<clsLoginLogEN|null>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(loginLog_Controller, strAction);
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
const objLoginLog = LoginLog_GetObjFromJsonObj(returnObj);
return objLoginLog;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, loginLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, loginLog_ConstructorName, strThisFuncName);
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
export async function LoginLog_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsLoginLogEN._CurrTabName;
if (IsNullOrEmpty(clsLoginLogEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsLoginLogEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrLoginLogExObjLst_Cache: Array<clsLoginLogEN> = CacheHelper.Get(strKey);
const arrLoginLogObjLst_T = LoginLog_GetObjLstByJSONObjLst(arrLoginLogExObjLst_Cache);
return arrLoginLogObjLst_T;
}
try
{
const arrLoginLogExObjLst = await LoginLog_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrLoginLogExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrLoginLogExObjLst.length);
console.log(strInfo);
return arrLoginLogExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, loginLog_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function LoginLog_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsLoginLogEN._CurrTabName;
if (IsNullOrEmpty(clsLoginLogEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsLoginLogEN.CacheAddiCondition);
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
const arrLoginLogExObjLst_Cache: Array<clsLoginLogEN> = JSON.parse(strTempObjLst);
const arrLoginLogObjLst_T = LoginLog_GetObjLstByJSONObjLst(arrLoginLogExObjLst_Cache);
return arrLoginLogObjLst_T;
}
try
{
const arrLoginLogExObjLst = await LoginLog_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrLoginLogExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrLoginLogExObjLst.length);
console.log(strInfo);
return arrLoginLogExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, loginLog_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function LoginLog_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsLoginLogEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrLoginLogObjLst_Cache: Array<clsLoginLogEN> = JSON.parse(strTempObjLst);
return arrLoginLogObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function LoginLog_GetObjLstAsync(strWhereCond: string): Promise<Array<clsLoginLogEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(loginLog_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", loginLog_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = LoginLog_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, loginLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, loginLog_ConstructorName, strThisFuncName);
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
export async function LoginLog_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsLoginLogEN._CurrTabName;
if (IsNullOrEmpty(clsLoginLogEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsLoginLogEN.CacheAddiCondition);
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
const arrLoginLogExObjLst_Cache: Array<clsLoginLogEN> = JSON.parse(strTempObjLst);
const arrLoginLogObjLst_T = LoginLog_GetObjLstByJSONObjLst(arrLoginLogExObjLst_Cache);
return arrLoginLogObjLst_T;
}
try
{
const arrLoginLogExObjLst = await LoginLog_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrLoginLogExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrLoginLogExObjLst.length);
console.log(strInfo);
return arrLoginLogExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, loginLog_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function LoginLog_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsLoginLogEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrLoginLogObjLst_Cache: Array<clsLoginLogEN> = JSON.parse(strTempObjLst);
return arrLoginLogObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function LoginLog_GetObjLst_Cache(): Promise<Array<clsLoginLogEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrLoginLogObjLst_Cache;
switch (clsLoginLogEN.CacheModeId)
{
case "04"://sessionStorage
arrLoginLogObjLst_Cache = await LoginLog_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrLoginLogObjLst_Cache = await LoginLog_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrLoginLogObjLst_Cache = await LoginLog_GetObjLst_ClientCache();
break;
default:
arrLoginLogObjLst_Cache = await LoginLog_GetObjLst_ClientCache();
break;
}
const arrLoginLogObjLst = LoginLog_GetObjLstByJSONObjLst(arrLoginLogObjLst_Cache);
return arrLoginLogObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function LoginLog_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrLoginLogObjLst_Cache;
switch (clsLoginLogEN.CacheModeId)
{
case "04"://sessionStorage
arrLoginLogObjLst_Cache = await LoginLog_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrLoginLogObjLst_Cache = await LoginLog_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrLoginLogObjLst_Cache = null;
break;
default:
arrLoginLogObjLst_Cache = null;
break;
}
return arrLoginLogObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objlngLoginLogId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function LoginLog_GetSubObjLst_Cache(objLoginLog_Cond: clsLoginLogEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrLoginLogObjLst_Cache = await LoginLog_GetObjLst_Cache();
let arrLoginLog_Sel: Array < clsLoginLogEN > = arrLoginLogObjLst_Cache;
if (objLoginLog_Cond.sf_FldComparisonOp == null || objLoginLog_Cond.sf_FldComparisonOp == "") return arrLoginLog_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objLoginLog_Cond.sf_FldComparisonOp);
//console.log("clsLoginLogWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objLoginLog_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objLoginLog_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrLoginLog_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objLoginLog_Cond), loginLog_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsLoginLogEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrLoginLogId:关键字列表
 * @returns 对象列表
 **/
export async function LoginLog_GetObjLstByLoginLogIdLstAsync(arrLoginLogId: Array<string>): Promise<Array<clsLoginLogEN>>  
{
const strThisFuncName = "GetObjLstByLoginLogIdLstAsync";
const strAction = "GetObjLstByLoginLogIdLst";
const strUrl = GetWebApiUrl(loginLog_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrLoginLogId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", loginLog_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = LoginLog_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, loginLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, loginLog_ConstructorName, strThisFuncName);
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
 * @param arrlngLoginLogIdLst:关键字列表
 * @returns 对象列表
*/
export async function LoginLog_GetObjLstByLoginLogIdLst_Cache(arrLoginLogIdLst: Array<number>) {
const strThisFuncName = "GetObjLstByLoginLogIdLst_Cache";
try
{
const arrLoginLogObjLst_Cache = await LoginLog_GetObjLst_Cache();
const arrLoginLog_Sel: Array <clsLoginLogEN> = arrLoginLogObjLst_Cache.filter(x => arrLoginLogIdLst.indexOf(x.loginLogId)>-1);
return arrLoginLog_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrLoginLogIdLst.join(","), loginLog_ConstructorName, strThisFuncName);
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
export async function LoginLog_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsLoginLogEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(loginLog_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", loginLog_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = LoginLog_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, loginLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, loginLog_ConstructorName, strThisFuncName);
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
export async function LoginLog_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsLoginLogEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(loginLog_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", loginLog_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = LoginLog_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, loginLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, loginLog_ConstructorName, strThisFuncName);
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
export async function LoginLog_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(loginLog_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, loginLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, loginLog_ConstructorName, strThisFuncName);
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
export async function LoginLog_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
if (objPagerPara.pageIndex == 0) return new Array<clsLoginLogEN>();
const arrLoginLogObjLst_Cache = await LoginLog_GetObjLst_Cache();
if (arrLoginLogObjLst_Cache.length == 0) return arrLoginLogObjLst_Cache;
let arrLoginLog_Sel = arrLoginLogObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objLoginLog_Cond = new clsLoginLogEN();
ObjectAssign(objLoginLog_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsLoginLogWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objLoginLog_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrLoginLog_Sel = arrLoginLog_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrLoginLog_Sel.length == 0) return arrLoginLog_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrLoginLog_Sel = arrLoginLog_Sel.sort(LoginLog_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrLoginLog_Sel = arrLoginLog_Sel.sort(objPagerPara.sortFun);
}
arrLoginLog_Sel = arrLoginLog_Sel.slice(intStart, intEnd);     
return arrLoginLog_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, loginLog_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsLoginLogEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function LoginLog_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsLoginLogEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
if (objPagerPara.pageIndex == 0) return new Array<clsLoginLogEN>();
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(loginLog_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", loginLog_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = LoginLog_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, loginLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, loginLog_ConstructorName, strThisFuncName);
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
 * @param lngLoginLogId:关键字
 * @returns 获取删除的结果
 **/
export async function LoginLog_DelRecordAsync(lngLoginLogId: number): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(loginLog_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, lngLoginLogId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, loginLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, loginLog_ConstructorName, strThisFuncName);
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
 * @param arrLoginLogId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function LoginLog_DelLoginLogsAsync(arrLoginLogId: Array<string>): Promise<number> 
{
const strThisFuncName = "DelLoginLogsAsync";
const strAction = "DelLoginLogs";
const strUrl = GetWebApiUrl(loginLog_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrLoginLogId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, loginLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, loginLog_ConstructorName, strThisFuncName);
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
export async function LoginLog_DelLoginLogsByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "DelLoginLogsByCondAsync";
const strAction = "DelLoginLogsByCond";
const strUrl = GetWebApiUrl(loginLog_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, loginLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, loginLog_ConstructorName, strThisFuncName);
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
 * @param objLoginLogEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function LoginLog_AddNewRecordAsync(objLoginLogEN: clsLoginLogEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objLoginLogEN);
const strUrl = GetWebApiUrl(loginLog_Controller, strAction);
try
{
const response = await axios.post(strUrl, objLoginLogEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, loginLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, loginLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}
/* 数据类型不是字符型，不可以最大关键字的方式添加记录。*/

 /**
 * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
 * @param objLoginLogEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function LoginLog_AddNewRecordWithReturnKeyAsync(objLoginLogEN: clsLoginLogEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(loginLog_Controller, strAction);
try
{
const response = await axios.post(strUrl, objLoginLogEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, loginLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, loginLog_ConstructorName, strThisFuncName);
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
 * @param objLoginLogEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function LoginLog_AddNewRecordWithReturnKey(objLoginLogEN: clsLoginLogEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objLoginLogEN.loginLogId === null || objLoginLogEN.loginLogId === 0)
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(loginLog_Controller, strAction);
try
{
const response = await axios.post(strUrl, objLoginLogEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, loginLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, loginLog_ConstructorName, strThisFuncName);
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
 * @param objLoginLogEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function LoginLog_UpdateRecordAsync(objLoginLogEN: clsLoginLogEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objLoginLogEN.sfUpdFldSetStr === undefined || objLoginLogEN.sfUpdFldSetStr === null || objLoginLogEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objLoginLogEN.loginLogId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(loginLog_Controller, strAction);
try
{
const response = await axios.post(strUrl, objLoginLogEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, loginLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, loginLog_ConstructorName, strThisFuncName);
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
 * @param objLoginLogEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function LoginLog_UpdateWithConditionAsync(objLoginLogEN: clsLoginLogEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objLoginLogEN.sfUpdFldSetStr === undefined || objLoginLogEN.sfUpdFldSetStr === null || objLoginLogEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objLoginLogEN.loginLogId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(loginLog_Controller, strAction);
objLoginLogEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objLoginLogEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, loginLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, loginLog_ConstructorName, strThisFuncName);
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
 * @param objlngLoginLogId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function LoginLog_IsExistRecord_Cache(objLoginLog_Cond: clsLoginLogEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrLoginLogObjLst_Cache = await LoginLog_GetObjLst_Cache();
if (arrLoginLogObjLst_Cache == null) return false;
let arrLoginLog_Sel: Array < clsLoginLogEN > = arrLoginLogObjLst_Cache;
if (objLoginLog_Cond.sf_FldComparisonOp == null || objLoginLog_Cond.sf_FldComparisonOp == "") return arrLoginLog_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objLoginLog_Cond.sf_FldComparisonOp);
//console.log("clsLoginLogWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objLoginLog_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objLoginLog_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrLoginLog_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objLoginLog_Cond), loginLog_ConstructorName, strThisFuncName);
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
export async function LoginLog_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(loginLog_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, loginLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, loginLog_ConstructorName, strThisFuncName);
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
 * @param lngLoginLogId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function LoginLog_IsExist(lngLoginLogId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(loginLog_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"LoginLogId": lngLoginLogId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, loginLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, loginLog_ConstructorName, strThisFuncName);
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
 * @param lngLoginLogId:所给的关键字
 * @returns 对象
*/
export async function LoginLog_IsExist_Cache(lngLoginLogId:number) {
const strThisFuncName = "IsExist_Cache";
const arrLoginLogObjLst_Cache = await LoginLog_GetObjLst_Cache();
if (arrLoginLogObjLst_Cache == null) return false;
try
{
const arrLoginLog_Sel: Array <clsLoginLogEN> = arrLoginLogObjLst_Cache.filter(x => x.loginLogId == lngLoginLogId);
if (arrLoginLog_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngLoginLogId, loginLog_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param lngLoginLogId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function LoginLog_IsExistAsync(lngLoginLogId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(loginLog_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "lngLoginLogId": lngLoginLogId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, loginLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, loginLog_ConstructorName, strThisFuncName);
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
export async function LoginLog_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(loginLog_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, loginLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, loginLog_ConstructorName, strThisFuncName);
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
 * @param objLoginLog_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function LoginLog_GetRecCountByCond_Cache(objLoginLog_Cond: clsLoginLogEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrLoginLogObjLst_Cache = await LoginLog_GetObjLst_Cache();
if (arrLoginLogObjLst_Cache == null) return 0;
let arrLoginLog_Sel: Array < clsLoginLogEN > = arrLoginLogObjLst_Cache;
if (objLoginLog_Cond.sf_FldComparisonOp == null || objLoginLog_Cond.sf_FldComparisonOp == "") return arrLoginLog_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objLoginLog_Cond.sf_FldComparisonOp);
//console.log("clsLoginLogWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objLoginLog_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objLoginLog_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrLoginLog_Sel = arrLoginLog_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrLoginLog_Sel = arrLoginLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrLoginLog_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objLoginLog_Cond), loginLog_ConstructorName, strThisFuncName);
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
export async function LoginLog_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(loginLog_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, loginLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, loginLog_ConstructorName, strThisFuncName);
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
export function LoginLog_GetWebApiUrl(strController: string, strAction: string): string {
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
export function LoginLog_ReFreshCache():void
{
const strThisFuncName = "ReFreshCache";

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = clsLoginLogEN._CurrTabName;
switch (clsLoginLogEN.CacheModeId)
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
export function LoginLog_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clsLoginLogEN._CurrTabName;
switch (clsLoginLogEN.CacheModeId)
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
/* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/

/**
 * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function LoginLog_CheckPropertyNew(pobjLoginLogEN: clsLoginLogEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjLoginLogEN.loginLogNumber) == false && GetStrLen(pobjLoginLogEN.loginLogNumber) > 500)
{
 throw new Error("(errid:Watl000059)字段[LoginLogNumber(loginLogNumber)]的长度不能超过500(In 登录日志(LoginLog))!值:$(pobjLoginLogEN.loginLogNumber)(clsLoginLogBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjLoginLogEN.loginIP) == false && GetStrLen(pobjLoginLogEN.loginIP) > 200)
{
 throw new Error("(errid:Watl000059)字段[LoginIP(loginIP)]的长度不能超过200(In 登录日志(LoginLog))!值:$(pobjLoginLogEN.loginIP)(clsLoginLogBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjLoginLogEN.failReason) == false && GetStrLen(pobjLoginLogEN.failReason) > 500)
{
 throw new Error("(errid:Watl000059)字段[FailReason(failReason)]的长度不能超过500(In 登录日志(LoginLog))!值:$(pobjLoginLogEN.failReason)(clsLoginLogBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjLoginLogEN.loginResult) == false && GetStrLen(pobjLoginLogEN.loginResult) > 500)
{
 throw new Error("(errid:Watl000059)字段[LoginResult(loginResult)]的长度不能超过500(In 登录日志(LoginLog))!值:$(pobjLoginLogEN.loginResult)(clsLoginLogBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjLoginLogEN.loginTime) == false && GetStrLen(pobjLoginLogEN.loginTime) > 20)
{
 throw new Error("(errid:Watl000059)字段[LoginTime(loginTime)]的长度不能超过20(In 登录日志(LoginLog))!值:$(pobjLoginLogEN.loginTime)(clsLoginLogBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjLoginLogEN.loginUserId) == false && GetStrLen(pobjLoginLogEN.loginUserId) > 200)
{
 throw new Error("(errid:Watl000059)字段[LoginUserId(loginUserId)]的长度不能超过200(In 登录日志(LoginLog))!值:$(pobjLoginLogEN.loginUserId)(clsLoginLogBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjLoginLogEN.onlineTime) == false && GetStrLen(pobjLoginLogEN.onlineTime) > 200)
{
 throw new Error("(errid:Watl000059)字段[OnlineTime(onlineTime)]的长度不能超过200(In 登录日志(LoginLog))!值:$(pobjLoginLogEN.onlineTime)(clsLoginLogBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjLoginLogEN.outTime) == false && GetStrLen(pobjLoginLogEN.outTime) > 20)
{
 throw new Error("(errid:Watl000059)字段[OutTime(outTime)]的长度不能超过20(In 登录日志(LoginLog))!值:$(pobjLoginLogEN.outTime)(clsLoginLogBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjLoginLogEN.memo) == false && GetStrLen(pobjLoginLogEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 登录日志(LoginLog))!值:$(pobjLoginLogEN.memo)(clsLoginLogBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null != pobjLoginLogEN.loginLogId && undefined !== pobjLoginLogEN.loginLogId && tzDataType.isNumber(pobjLoginLogEN.loginLogId) === false)
{
 throw new Error("(errid:Watl000060)字段[LoginLogId(loginLogId)]的值:[$(pobjLoginLogEN.loginLogId)], 非法，应该为数值型(In 登录日志(LoginLog))!(clsLoginLogBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjLoginLogEN.loginLogNumber) == false && undefined !== pobjLoginLogEN.loginLogNumber && tzDataType.isString(pobjLoginLogEN.loginLogNumber) === false)
{
 throw new Error("(errid:Watl000060)字段[LoginLogNumber(loginLogNumber)]的值:[$(pobjLoginLogEN.loginLogNumber)], 非法，应该为字符型(In 登录日志(LoginLog))!(clsLoginLogBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjLoginLogEN.loginIP) == false && undefined !== pobjLoginLogEN.loginIP && tzDataType.isString(pobjLoginLogEN.loginIP) === false)
{
 throw new Error("(errid:Watl000060)字段[LoginIP(loginIP)]的值:[$(pobjLoginLogEN.loginIP)], 非法，应该为字符型(In 登录日志(LoginLog))!(clsLoginLogBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjLoginLogEN.failReason) == false && undefined !== pobjLoginLogEN.failReason && tzDataType.isString(pobjLoginLogEN.failReason) === false)
{
 throw new Error("(errid:Watl000060)字段[FailReason(failReason)]的值:[$(pobjLoginLogEN.failReason)], 非法，应该为字符型(In 登录日志(LoginLog))!(clsLoginLogBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjLoginLogEN.loginResult) == false && undefined !== pobjLoginLogEN.loginResult && tzDataType.isString(pobjLoginLogEN.loginResult) === false)
{
 throw new Error("(errid:Watl000060)字段[LoginResult(loginResult)]的值:[$(pobjLoginLogEN.loginResult)], 非法，应该为字符型(In 登录日志(LoginLog))!(clsLoginLogBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjLoginLogEN.loginTime) == false && undefined !== pobjLoginLogEN.loginTime && tzDataType.isString(pobjLoginLogEN.loginTime) === false)
{
 throw new Error("(errid:Watl000060)字段[LoginTime(loginTime)]的值:[$(pobjLoginLogEN.loginTime)], 非法，应该为字符型(In 登录日志(LoginLog))!(clsLoginLogBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjLoginLogEN.loginUserId) == false && undefined !== pobjLoginLogEN.loginUserId && tzDataType.isString(pobjLoginLogEN.loginUserId) === false)
{
 throw new Error("(errid:Watl000060)字段[LoginUserId(loginUserId)]的值:[$(pobjLoginLogEN.loginUserId)], 非法，应该为字符型(In 登录日志(LoginLog))!(clsLoginLogBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjLoginLogEN.onlineTime) == false && undefined !== pobjLoginLogEN.onlineTime && tzDataType.isString(pobjLoginLogEN.onlineTime) === false)
{
 throw new Error("(errid:Watl000060)字段[OnlineTime(onlineTime)]的值:[$(pobjLoginLogEN.onlineTime)], 非法，应该为字符型(In 登录日志(LoginLog))!(clsLoginLogBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjLoginLogEN.outTime) == false && undefined !== pobjLoginLogEN.outTime && tzDataType.isString(pobjLoginLogEN.outTime) === false)
{
 throw new Error("(errid:Watl000060)字段[OutTime(outTime)]的值:[$(pobjLoginLogEN.outTime)], 非法，应该为字符型(In 登录日志(LoginLog))!(clsLoginLogBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjLoginLogEN.memo) == false && undefined !== pobjLoginLogEN.memo && tzDataType.isString(pobjLoginLogEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjLoginLogEN.memo)], 非法，应该为字符型(In 登录日志(LoginLog))!(clsLoginLogBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjLoginLogEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function LoginLog_CheckProperty4Update (pobjLoginLogEN: clsLoginLogEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjLoginLogEN.loginLogNumber) == false && GetStrLen(pobjLoginLogEN.loginLogNumber) > 500)
{
 throw new Error("(errid:Watl000062)字段[LoginLogNumber(loginLogNumber)]的长度不能超过500(In 登录日志(LoginLog))!值:$(pobjLoginLogEN.loginLogNumber)(clsLoginLogBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjLoginLogEN.loginIP) == false && GetStrLen(pobjLoginLogEN.loginIP) > 200)
{
 throw new Error("(errid:Watl000062)字段[LoginIP(loginIP)]的长度不能超过200(In 登录日志(LoginLog))!值:$(pobjLoginLogEN.loginIP)(clsLoginLogBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjLoginLogEN.failReason) == false && GetStrLen(pobjLoginLogEN.failReason) > 500)
{
 throw new Error("(errid:Watl000062)字段[FailReason(failReason)]的长度不能超过500(In 登录日志(LoginLog))!值:$(pobjLoginLogEN.failReason)(clsLoginLogBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjLoginLogEN.loginResult) == false && GetStrLen(pobjLoginLogEN.loginResult) > 500)
{
 throw new Error("(errid:Watl000062)字段[LoginResult(loginResult)]的长度不能超过500(In 登录日志(LoginLog))!值:$(pobjLoginLogEN.loginResult)(clsLoginLogBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjLoginLogEN.loginTime) == false && GetStrLen(pobjLoginLogEN.loginTime) > 20)
{
 throw new Error("(errid:Watl000062)字段[LoginTime(loginTime)]的长度不能超过20(In 登录日志(LoginLog))!值:$(pobjLoginLogEN.loginTime)(clsLoginLogBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjLoginLogEN.loginUserId) == false && GetStrLen(pobjLoginLogEN.loginUserId) > 200)
{
 throw new Error("(errid:Watl000062)字段[LoginUserId(loginUserId)]的长度不能超过200(In 登录日志(LoginLog))!值:$(pobjLoginLogEN.loginUserId)(clsLoginLogBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjLoginLogEN.onlineTime) == false && GetStrLen(pobjLoginLogEN.onlineTime) > 200)
{
 throw new Error("(errid:Watl000062)字段[OnlineTime(onlineTime)]的长度不能超过200(In 登录日志(LoginLog))!值:$(pobjLoginLogEN.onlineTime)(clsLoginLogBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjLoginLogEN.outTime) == false && GetStrLen(pobjLoginLogEN.outTime) > 20)
{
 throw new Error("(errid:Watl000062)字段[OutTime(outTime)]的长度不能超过20(In 登录日志(LoginLog))!值:$(pobjLoginLogEN.outTime)(clsLoginLogBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjLoginLogEN.memo) == false && GetStrLen(pobjLoginLogEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 登录日志(LoginLog))!值:$(pobjLoginLogEN.memo)(clsLoginLogBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null != pobjLoginLogEN.loginLogId && undefined !== pobjLoginLogEN.loginLogId && tzDataType.isNumber(pobjLoginLogEN.loginLogId) === false)
{
 throw new Error("(errid:Watl000063)字段[LoginLogId(loginLogId)]的值:[$(pobjLoginLogEN.loginLogId)], 非法，应该为数值型(In 登录日志(LoginLog))!(clsLoginLogBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjLoginLogEN.loginLogNumber) == false && undefined !== pobjLoginLogEN.loginLogNumber && tzDataType.isString(pobjLoginLogEN.loginLogNumber) === false)
{
 throw new Error("(errid:Watl000063)字段[LoginLogNumber(loginLogNumber)]的值:[$(pobjLoginLogEN.loginLogNumber)], 非法，应该为字符型(In 登录日志(LoginLog))!(clsLoginLogBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjLoginLogEN.loginIP) == false && undefined !== pobjLoginLogEN.loginIP && tzDataType.isString(pobjLoginLogEN.loginIP) === false)
{
 throw new Error("(errid:Watl000063)字段[LoginIP(loginIP)]的值:[$(pobjLoginLogEN.loginIP)], 非法，应该为字符型(In 登录日志(LoginLog))!(clsLoginLogBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjLoginLogEN.failReason) == false && undefined !== pobjLoginLogEN.failReason && tzDataType.isString(pobjLoginLogEN.failReason) === false)
{
 throw new Error("(errid:Watl000063)字段[FailReason(failReason)]的值:[$(pobjLoginLogEN.failReason)], 非法，应该为字符型(In 登录日志(LoginLog))!(clsLoginLogBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjLoginLogEN.loginResult) == false && undefined !== pobjLoginLogEN.loginResult && tzDataType.isString(pobjLoginLogEN.loginResult) === false)
{
 throw new Error("(errid:Watl000063)字段[LoginResult(loginResult)]的值:[$(pobjLoginLogEN.loginResult)], 非法，应该为字符型(In 登录日志(LoginLog))!(clsLoginLogBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjLoginLogEN.loginTime) == false && undefined !== pobjLoginLogEN.loginTime && tzDataType.isString(pobjLoginLogEN.loginTime) === false)
{
 throw new Error("(errid:Watl000063)字段[LoginTime(loginTime)]的值:[$(pobjLoginLogEN.loginTime)], 非法，应该为字符型(In 登录日志(LoginLog))!(clsLoginLogBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjLoginLogEN.loginUserId) == false && undefined !== pobjLoginLogEN.loginUserId && tzDataType.isString(pobjLoginLogEN.loginUserId) === false)
{
 throw new Error("(errid:Watl000063)字段[LoginUserId(loginUserId)]的值:[$(pobjLoginLogEN.loginUserId)], 非法，应该为字符型(In 登录日志(LoginLog))!(clsLoginLogBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjLoginLogEN.onlineTime) == false && undefined !== pobjLoginLogEN.onlineTime && tzDataType.isString(pobjLoginLogEN.onlineTime) === false)
{
 throw new Error("(errid:Watl000063)字段[OnlineTime(onlineTime)]的值:[$(pobjLoginLogEN.onlineTime)], 非法，应该为字符型(In 登录日志(LoginLog))!(clsLoginLogBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjLoginLogEN.outTime) == false && undefined !== pobjLoginLogEN.outTime && tzDataType.isString(pobjLoginLogEN.outTime) === false)
{
 throw new Error("(errid:Watl000063)字段[OutTime(outTime)]的值:[$(pobjLoginLogEN.outTime)], 非法，应该为字符型(In 登录日志(LoginLog))!(clsLoginLogBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjLoginLogEN.memo) == false && undefined !== pobjLoginLogEN.memo && tzDataType.isString(pobjLoginLogEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjLoginLogEN.memo)], 非法，应该为字符型(In 登录日志(LoginLog))!(clsLoginLogBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjLoginLogEN.loginLogId 
 || pobjLoginLogEN.loginLogId != null && pobjLoginLogEN.loginLogId.toString()  ===  "")
{
 throw new Error("(errid:Watl000064)字段[LoginLogId]不能为空(In 登录日志)!(clsLoginLogBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjLoginLogEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function LoginLog_GetJSONStrByObj (pobjLoginLogEN: clsLoginLogEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjLoginLogEN.sfUpdFldSetStr = pobjLoginLogEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjLoginLogEN);
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
export function LoginLog_GetObjLstByJSONStr (strJSON: string): Array<clsLoginLogEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrLoginLogObjLst = new Array<clsLoginLogEN>();
if (strJSON === "")
{
return arrLoginLogObjLst;
}
try
{
arrLoginLogObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrLoginLogObjLst;
}
return arrLoginLogObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrLoginLogObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function LoginLog_GetObjLstByJSONObjLst (arrLoginLogObjLstS: Array<clsLoginLogEN>): Array<clsLoginLogEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrLoginLogObjLst = new Array<clsLoginLogEN>();
for (const objInFor of arrLoginLogObjLstS) {
const obj1 = LoginLog_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrLoginLogObjLst.push(obj1);
}
return arrLoginLogObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function LoginLog_GetObjByJSONStr (strJSON: string): clsLoginLogEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjLoginLogEN = new clsLoginLogEN();
if (strJSON === "")
{
return pobjLoginLogEN;
}
try
{
pobjLoginLogEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjLoginLogEN;
}
return pobjLoginLogEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function LoginLog_GetCombineCondition(objLoginLog_Cond: clsLoginLogEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objLoginLog_Cond.dicFldComparisonOp, clsLoginLogEN.con_LoginLogId) == true)
{
const strComparisonOp_LoginLogId:string = objLoginLog_Cond.dicFldComparisonOp[clsLoginLogEN.con_LoginLogId];
strWhereCond += Format(" And {0} {2} {1}", clsLoginLogEN.con_LoginLogId, objLoginLog_Cond.loginLogId, strComparisonOp_LoginLogId);
}
if (Object.prototype.hasOwnProperty.call(objLoginLog_Cond.dicFldComparisonOp, clsLoginLogEN.con_LoginLogNumber) == true)
{
const strComparisonOp_LoginLogNumber:string = objLoginLog_Cond.dicFldComparisonOp[clsLoginLogEN.con_LoginLogNumber];
strWhereCond += Format(" And {0} {2} '{1}'", clsLoginLogEN.con_LoginLogNumber, objLoginLog_Cond.loginLogNumber, strComparisonOp_LoginLogNumber);
}
if (Object.prototype.hasOwnProperty.call(objLoginLog_Cond.dicFldComparisonOp, clsLoginLogEN.con_LoginIP) == true)
{
const strComparisonOp_LoginIP:string = objLoginLog_Cond.dicFldComparisonOp[clsLoginLogEN.con_LoginIP];
strWhereCond += Format(" And {0} {2} '{1}'", clsLoginLogEN.con_LoginIP, objLoginLog_Cond.loginIP, strComparisonOp_LoginIP);
}
if (Object.prototype.hasOwnProperty.call(objLoginLog_Cond.dicFldComparisonOp, clsLoginLogEN.con_FailReason) == true)
{
const strComparisonOp_FailReason:string = objLoginLog_Cond.dicFldComparisonOp[clsLoginLogEN.con_FailReason];
strWhereCond += Format(" And {0} {2} '{1}'", clsLoginLogEN.con_FailReason, objLoginLog_Cond.failReason, strComparisonOp_FailReason);
}
if (Object.prototype.hasOwnProperty.call(objLoginLog_Cond.dicFldComparisonOp, clsLoginLogEN.con_LoginResult) == true)
{
const strComparisonOp_LoginResult:string = objLoginLog_Cond.dicFldComparisonOp[clsLoginLogEN.con_LoginResult];
strWhereCond += Format(" And {0} {2} '{1}'", clsLoginLogEN.con_LoginResult, objLoginLog_Cond.loginResult, strComparisonOp_LoginResult);
}
if (Object.prototype.hasOwnProperty.call(objLoginLog_Cond.dicFldComparisonOp, clsLoginLogEN.con_LoginTime) == true)
{
const strComparisonOp_LoginTime:string = objLoginLog_Cond.dicFldComparisonOp[clsLoginLogEN.con_LoginTime];
strWhereCond += Format(" And {0} {2} '{1}'", clsLoginLogEN.con_LoginTime, objLoginLog_Cond.loginTime, strComparisonOp_LoginTime);
}
if (Object.prototype.hasOwnProperty.call(objLoginLog_Cond.dicFldComparisonOp, clsLoginLogEN.con_LoginUserId) == true)
{
const strComparisonOp_LoginUserId:string = objLoginLog_Cond.dicFldComparisonOp[clsLoginLogEN.con_LoginUserId];
strWhereCond += Format(" And {0} {2} '{1}'", clsLoginLogEN.con_LoginUserId, objLoginLog_Cond.loginUserId, strComparisonOp_LoginUserId);
}
if (Object.prototype.hasOwnProperty.call(objLoginLog_Cond.dicFldComparisonOp, clsLoginLogEN.con_OnlineTime) == true)
{
const strComparisonOp_OnlineTime:string = objLoginLog_Cond.dicFldComparisonOp[clsLoginLogEN.con_OnlineTime];
strWhereCond += Format(" And {0} {2} '{1}'", clsLoginLogEN.con_OnlineTime, objLoginLog_Cond.onlineTime, strComparisonOp_OnlineTime);
}
if (Object.prototype.hasOwnProperty.call(objLoginLog_Cond.dicFldComparisonOp, clsLoginLogEN.con_OutTime) == true)
{
const strComparisonOp_OutTime:string = objLoginLog_Cond.dicFldComparisonOp[clsLoginLogEN.con_OutTime];
strWhereCond += Format(" And {0} {2} '{1}'", clsLoginLogEN.con_OutTime, objLoginLog_Cond.outTime, strComparisonOp_OutTime);
}
if (Object.prototype.hasOwnProperty.call(objLoginLog_Cond.dicFldComparisonOp, clsLoginLogEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objLoginLog_Cond.dicFldComparisonOp[clsLoginLogEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsLoginLogEN.con_Memo, objLoginLog_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--LoginLog(登录日志),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param strLoginUserId: LoginUserId(要求唯一的字段)
 * @param strLoginIP: LoginIP(要求唯一的字段)
 * @param strLoginTime: LoginTime(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function LoginLog_GetUniCondStr_LoginUserId_LoginIP_LoginTime(objLoginLogEN: clsLoginLogEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and LoginUserId = '{0}'", objLoginLogEN.loginUserId);
 strWhereCond +=  Format(" and LoginIP = '{0}'", objLoginLogEN.loginIP);
 strWhereCond +=  Format(" and LoginTime = '{0}'", objLoginLogEN.loginTime);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--LoginLog(登录日志),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param strLoginUserId: LoginUserId(要求唯一的字段)
 * @param strLoginIP: LoginIP(要求唯一的字段)
 * @param strLoginTime: LoginTime(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function LoginLog_GetUniCondStr4Update_LoginUserId_LoginIP_LoginTime(objLoginLogEN: clsLoginLogEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and LoginLogId <> '{0}'", objLoginLogEN.loginLogId);
 strWhereCond +=  Format(" and LoginUserId = '{0}'", objLoginLogEN.loginUserId);
 strWhereCond +=  Format(" and LoginIP = '{0}'", objLoginLogEN.loginIP);
 strWhereCond +=  Format(" and LoginTime = '{0}'", objLoginLogEN.loginTime);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objLoginLogENS:源对象
 * @param objLoginLogENT:目标对象
*/
export function LoginLog_CopyObjTo(objLoginLogENS: clsLoginLogEN , objLoginLogENT: clsLoginLogEN ): void 
{
objLoginLogENT.loginLogId = objLoginLogENS.loginLogId; //LoginLogId
objLoginLogENT.loginLogNumber = objLoginLogENS.loginLogNumber; //LoginLogNumber
objLoginLogENT.loginIP = objLoginLogENS.loginIP; //LoginIP
objLoginLogENT.failReason = objLoginLogENS.failReason; //FailReason
objLoginLogENT.loginResult = objLoginLogENS.loginResult; //LoginResult
objLoginLogENT.loginTime = objLoginLogENS.loginTime; //LoginTime
objLoginLogENT.loginUserId = objLoginLogENS.loginUserId; //LoginUserId
objLoginLogENT.onlineTime = objLoginLogENS.onlineTime; //OnlineTime
objLoginLogENT.outTime = objLoginLogENS.outTime; //OutTime
objLoginLogENT.memo = objLoginLogENS.memo; //备注
objLoginLogENT.sfUpdFldSetStr = objLoginLogENS.updFldString; //sfUpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objLoginLogENS:源对象
 * @param objLoginLogENT:目标对象
*/
export function LoginLog_GetObjFromJsonObj(objLoginLogENS: clsLoginLogEN): clsLoginLogEN 
{
 const objLoginLogENT: clsLoginLogEN = new clsLoginLogEN();
ObjectAssign(objLoginLogENT, objLoginLogENS);
 return objLoginLogENT;
}