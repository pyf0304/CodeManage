﻿
 /**
 * 类名:clsUserDefaValueWApi
 * 表名:UserDefaValue(01120203)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:52:27
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
 * 用户缺省值(UserDefaValue)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2023年03月13日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { enumComparisonOp } from "../../PubFun/enumComparisonOp.js";
import { clsUserDefaValueEN } from "../../L0_Entity/LogManage/clsUserDefaValueEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { tzDataType } from "../../PubFun/clsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const userDefaValue_Controller = "UserDefaValueApi";
 export const userDefaValue_ConstructorName = "userDefaValue";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngmId:关键字
 * @returns 对象
 **/
export async function UserDefaValue_GetObjBymIdAsync(lngmId: number): Promise<clsUserDefaValueEN|null>  
{
const strThisFuncName = "GetObjBymIdAsync";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In clsUserDefaValueWApi.GetObjBymIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjBymId";
const strUrl = GetWebApiUrl(userDefaValue_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"lngmId": lngmId,
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
const objUserDefaValue = UserDefaValue_GetObjFromJsonObj(returnObj);
return objUserDefaValue;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, userDefaValue_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, userDefaValue_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}
//该表在前台TypeScript中，不需要使用Cache;
//该表在前台TypeScript中，不需要使用Cache;
//该表在前台TypeScript中，不需要使用Cache;
//该表在前台TypeScript中，不需要使用Cache;
//该表在前台TypeScript中，不需要使用Cache;

/**
 * 排序函数。根据关键字字段的值进行比较
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
 * @param a:比较的第1个对象
 * @param  b:比较的第1个对象
 * @returns 返回两个对象比较的结果
*/
export function UserDefaValue_SortFun_Defa(a:clsUserDefaValueEN , b:clsUserDefaValueEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.mId-b.mId;
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
export function UserDefaValue_SortFun_Defa_2Fld(a:clsUserDefaValueEN , b:clsUserDefaValueEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.defaValNameId == b.defaValNameId) return a.userId.localeCompare(b.userId);
else return a.defaValNameId.localeCompare(b.defaValNameId);
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
export function UserDefaValue_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsUserDefaValueEN.con_mId:
return (a: clsUserDefaValueEN, b: clsUserDefaValueEN) => {
return a.mId-b.mId;
}
case clsUserDefaValueEN.con_DefaValNameId:
return (a: clsUserDefaValueEN, b: clsUserDefaValueEN) => {
return a.defaValNameId.localeCompare(b.defaValNameId);
}
case clsUserDefaValueEN.con_UserId:
return (a: clsUserDefaValueEN, b: clsUserDefaValueEN) => {
return a.userId.localeCompare(b.userId);
}
case clsUserDefaValueEN.con_UserDefaValue:
return (a: clsUserDefaValueEN, b: clsUserDefaValueEN) => {
return a.userDefaValue.localeCompare(b.userDefaValue);
}
case clsUserDefaValueEN.con_UpdDate:
return (a: clsUserDefaValueEN, b: clsUserDefaValueEN) => {
if (a.updDate == null) return -1;
if (b.updDate == null) return 1;
return a.updDate.localeCompare(b.updDate);
}
case clsUserDefaValueEN.con_UpdUser:
return (a: clsUserDefaValueEN, b: clsUserDefaValueEN) => {
if (a.updUser == null) return -1;
if (b.updUser == null) return 1;
return a.updUser.localeCompare(b.updUser);
}
case clsUserDefaValueEN.con_Memo:
return (a: clsUserDefaValueEN, b: clsUserDefaValueEN) => {
if (a.memo == null) return -1;
if (b.memo == null) return 1;
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[UserDefaValue]中不存在！(in ${ userDefaValue_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsUserDefaValueEN.con_mId:
return (a: clsUserDefaValueEN, b: clsUserDefaValueEN) => {
return b.mId-a.mId;
}
case clsUserDefaValueEN.con_DefaValNameId:
return (a: clsUserDefaValueEN, b: clsUserDefaValueEN) => {
return b.defaValNameId.localeCompare(a.defaValNameId);
}
case clsUserDefaValueEN.con_UserId:
return (a: clsUserDefaValueEN, b: clsUserDefaValueEN) => {
return b.userId.localeCompare(a.userId);
}
case clsUserDefaValueEN.con_UserDefaValue:
return (a: clsUserDefaValueEN, b: clsUserDefaValueEN) => {
return b.userDefaValue.localeCompare(a.userDefaValue);
}
case clsUserDefaValueEN.con_UpdDate:
return (a: clsUserDefaValueEN, b: clsUserDefaValueEN) => {
if (b.updDate == null) return -1;
if (a.updDate == null) return 1;
return b.updDate.localeCompare(a.updDate);
}
case clsUserDefaValueEN.con_UpdUser:
return (a: clsUserDefaValueEN, b: clsUserDefaValueEN) => {
if (b.updUser == null) return -1;
if (a.updUser == null) return 1;
return b.updUser.localeCompare(a.updUser);
}
case clsUserDefaValueEN.con_Memo:
return (a: clsUserDefaValueEN, b: clsUserDefaValueEN) => {
if (b.memo == null) return -1;
if (a.memo == null) return 1;
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[UserDefaValue]中不存在！(in ${ userDefaValue_ConstructorName}.${ strThisFuncName})`;
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
export async function UserDefaValue_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsUserDefaValueEN.con_mId:
return (obj: clsUserDefaValueEN) => {
return obj.mId === value;
}
case clsUserDefaValueEN.con_DefaValNameId:
return (obj: clsUserDefaValueEN) => {
return obj.defaValNameId === value;
}
case clsUserDefaValueEN.con_UserId:
return (obj: clsUserDefaValueEN) => {
return obj.userId === value;
}
case clsUserDefaValueEN.con_UserDefaValue:
return (obj: clsUserDefaValueEN) => {
return obj.userDefaValue === value;
}
case clsUserDefaValueEN.con_UpdDate:
return (obj: clsUserDefaValueEN) => {
return obj.updDate === value;
}
case clsUserDefaValueEN.con_UpdUser:
return (obj: clsUserDefaValueEN) => {
return obj.updUser === value;
}
case clsUserDefaValueEN.con_Memo:
return (obj: clsUserDefaValueEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[UserDefaValue]中不存在！(in ${ userDefaValue_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
}
//该表在前台TypeScript中，不需要使用Cache;

 /**
 * 根据条件获取满足条件的第一条记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
 * @param strWhereCond:条件
 * @returns 返回的第一条记录的关键字值
 **/
export async function UserDefaValue_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(userDefaValue_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, userDefaValue_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, userDefaValue_ConstructorName, strThisFuncName);
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
export async function UserDefaValue_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(userDefaValue_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, userDefaValue_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, userDefaValue_ConstructorName, strThisFuncName);
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
export async function UserDefaValue_GetFirstObjAsync(strWhereCond: string): Promise<clsUserDefaValueEN|null>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(userDefaValue_Controller, strAction);
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
const objUserDefaValue = UserDefaValue_GetObjFromJsonObj(returnObj);
return objUserDefaValue;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, userDefaValue_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, userDefaValue_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}
//该表在前台TypeScript中，不需要使用Cache;
//该表在前台TypeScript中，不需要使用Cache;
//该表在前台TypeScript中，不需要使用Cache;

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function UserDefaValue_GetObjLstAsync(strWhereCond: string): Promise<Array<clsUserDefaValueEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(userDefaValue_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", userDefaValue_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = UserDefaValue_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, userDefaValue_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, userDefaValue_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}
//该表在前台TypeScript中，不需要使用Cache;
//该表在前台TypeScript中，不需要使用Cache;
//该表在前台TypeScript中，不需要使用Cache;
//该表在前台TypeScript中，不需要使用Cache;
//该表在前台TypeScript中，不需要使用Cache;

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrmId:关键字列表
 * @returns 对象列表
 **/
export async function UserDefaValue_GetObjLstBymIdLstAsync(arrmId: Array<string>): Promise<Array<clsUserDefaValueEN>>  
{
const strThisFuncName = "GetObjLstBymIdLstAsync";
const strAction = "GetObjLstBymIdLst";
const strUrl = GetWebApiUrl(userDefaValue_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrmId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", userDefaValue_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = UserDefaValue_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, userDefaValue_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, userDefaValue_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}
//该表在前台TypeScript中，不需要使用Cache;

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function UserDefaValue_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsUserDefaValueEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(userDefaValue_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", userDefaValue_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = UserDefaValue_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, userDefaValue_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, userDefaValue_ConstructorName, strThisFuncName);
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
export async function UserDefaValue_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsUserDefaValueEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(userDefaValue_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", userDefaValue_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = UserDefaValue_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, userDefaValue_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, userDefaValue_ConstructorName, strThisFuncName);
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
export async function UserDefaValue_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(userDefaValue_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, userDefaValue_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, userDefaValue_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}
//该表在前台TypeScript中，不需要使用Cache;

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function UserDefaValue_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsUserDefaValueEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
if (objPagerPara.pageIndex == 0) return new Array<clsUserDefaValueEN>();
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(userDefaValue_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", userDefaValue_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = UserDefaValue_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, userDefaValue_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, userDefaValue_ConstructorName, strThisFuncName);
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
 * @param lngmId:关键字
 * @returns 获取删除的结果
 **/
export async function UserDefaValue_DelRecordAsync(lngmId: number): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(userDefaValue_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, lngmId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, userDefaValue_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, userDefaValue_ConstructorName, strThisFuncName);
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
 * @param arrmId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function UserDefaValue_DelUserDefaValuesAsync(arrmId: Array<string>): Promise<number> 
{
const strThisFuncName = "DelUserDefaValuesAsync";
const strAction = "DelUserDefaValues";
const strUrl = GetWebApiUrl(userDefaValue_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrmId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, userDefaValue_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, userDefaValue_ConstructorName, strThisFuncName);
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
export async function UserDefaValue_DelUserDefaValuesByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "DelUserDefaValuesByCondAsync";
const strAction = "DelUserDefaValuesByCond";
const strUrl = GetWebApiUrl(userDefaValue_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, userDefaValue_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, userDefaValue_ConstructorName, strThisFuncName);
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
 * @param objUserDefaValueEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function UserDefaValue_AddNewRecordAsync(objUserDefaValueEN: clsUserDefaValueEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objUserDefaValueEN);
const strUrl = GetWebApiUrl(userDefaValue_Controller, strAction);
try
{
const response = await axios.post(strUrl, objUserDefaValueEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, userDefaValue_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, userDefaValue_ConstructorName, strThisFuncName);
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
 * @param objUserDefaValueEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function UserDefaValue_AddNewRecordWithReturnKeyAsync(objUserDefaValueEN: clsUserDefaValueEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(userDefaValue_Controller, strAction);
try
{
const response = await axios.post(strUrl, objUserDefaValueEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, userDefaValue_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, userDefaValue_ConstructorName, strThisFuncName);
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
 * @param objUserDefaValueEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function UserDefaValue_AddNewRecordWithReturnKey(objUserDefaValueEN: clsUserDefaValueEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objUserDefaValueEN.mId === null || objUserDefaValueEN.mId === 0)
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(userDefaValue_Controller, strAction);
try
{
const response = await axios.post(strUrl, objUserDefaValueEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, userDefaValue_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, userDefaValue_ConstructorName, strThisFuncName);
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
 * @param objUserDefaValueEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function UserDefaValue_UpdateRecordAsync(objUserDefaValueEN: clsUserDefaValueEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objUserDefaValueEN.sfUpdFldSetStr === undefined || objUserDefaValueEN.sfUpdFldSetStr === null || objUserDefaValueEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objUserDefaValueEN.mId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(userDefaValue_Controller, strAction);
try
{
const response = await axios.post(strUrl, objUserDefaValueEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, userDefaValue_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, userDefaValue_ConstructorName, strThisFuncName);
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
 * @param objUserDefaValueEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function UserDefaValue_UpdateWithConditionAsync(objUserDefaValueEN: clsUserDefaValueEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objUserDefaValueEN.sfUpdFldSetStr === undefined || objUserDefaValueEN.sfUpdFldSetStr === null || objUserDefaValueEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objUserDefaValueEN.mId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(userDefaValue_Controller, strAction);
objUserDefaValueEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objUserDefaValueEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, userDefaValue_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, userDefaValue_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}
//该表在前台TypeScript中，不需要使用Cache;

 /**
 * 根据条件获取是否存在相应的记录？
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
 * @param strWhereCond:条件
 * @returns 是否存在记录？
 **/
export async function UserDefaValue_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(userDefaValue_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, userDefaValue_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, userDefaValue_ConstructorName, strThisFuncName);
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
 * @param lngmId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function UserDefaValue_IsExist(lngmId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(userDefaValue_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"mId": lngmId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, userDefaValue_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, userDefaValue_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}
//该表在前台TypeScript中，不需要使用Cache;

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param lngmId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function UserDefaValue_IsExistAsync(lngmId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(userDefaValue_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "lngmId": lngmId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, userDefaValue_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, userDefaValue_ConstructorName, strThisFuncName);
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
export async function UserDefaValue_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(userDefaValue_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, userDefaValue_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, userDefaValue_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}
//该表在前台TypeScript中，不需要使用Cache;
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
export async function UserDefaValue_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(userDefaValue_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, userDefaValue_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, userDefaValue_ConstructorName, strThisFuncName);
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
export function UserDefaValue_GetWebApiUrl(strController: string, strAction: string): string {
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
//该表在前台TypeScript中，不需要使用Cache;
//该表在前台TypeScript中，不需要使用Cache;
//该表在前台TypeScript中，不需要使用Cache;

/**
 * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function UserDefaValue_CheckPropertyNew(pobjUserDefaValueEN: clsUserDefaValueEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjUserDefaValueEN.defaValNameId) === true )
{
 throw new Error("(errid:Watl000058)字段[缺省值名称Id]不能为空(In 用户缺省值)!(clsUserDefaValueBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjUserDefaValueEN.userId) === true )
{
 throw new Error("(errid:Watl000058)字段[用户ID]不能为空(In 用户缺省值)!(clsUserDefaValueBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjUserDefaValueEN.userDefaValue) === true )
{
 throw new Error("(errid:Watl000058)字段[用户缺省值]不能为空(In 用户缺省值)!(clsUserDefaValueBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjUserDefaValueEN.defaValNameId) == false && GetStrLen(pobjUserDefaValueEN.defaValNameId) > 8)
{
 throw new Error("(errid:Watl000059)字段[缺省值名称Id(defaValNameId)]的长度不能超过8(In 用户缺省值(UserDefaValue))!值:$(pobjUserDefaValueEN.defaValNameId)(clsUserDefaValueBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjUserDefaValueEN.userId) == false && GetStrLen(pobjUserDefaValueEN.userId) > 18)
{
 throw new Error("(errid:Watl000059)字段[用户ID(userId)]的长度不能超过18(In 用户缺省值(UserDefaValue))!值:$(pobjUserDefaValueEN.userId)(clsUserDefaValueBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjUserDefaValueEN.userDefaValue) == false && GetStrLen(pobjUserDefaValueEN.userDefaValue) > 100)
{
 throw new Error("(errid:Watl000059)字段[用户缺省值(userDefaValue)]的长度不能超过100(In 用户缺省值(UserDefaValue))!值:$(pobjUserDefaValueEN.userDefaValue)(clsUserDefaValueBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjUserDefaValueEN.updDate) == false && GetStrLen(pobjUserDefaValueEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 用户缺省值(UserDefaValue))!值:$(pobjUserDefaValueEN.updDate)(clsUserDefaValueBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjUserDefaValueEN.updUser) == false && GetStrLen(pobjUserDefaValueEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 用户缺省值(UserDefaValue))!值:$(pobjUserDefaValueEN.updUser)(clsUserDefaValueBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjUserDefaValueEN.memo) == false && GetStrLen(pobjUserDefaValueEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 用户缺省值(UserDefaValue))!值:$(pobjUserDefaValueEN.memo)(clsUserDefaValueBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null != pobjUserDefaValueEN.mId && undefined !== pobjUserDefaValueEN.mId && tzDataType.isNumber(pobjUserDefaValueEN.mId) === false)
{
 throw new Error("(errid:Watl000060)字段[mId(mId)]的值:[$(pobjUserDefaValueEN.mId)], 非法，应该为数值型(In 用户缺省值(UserDefaValue))!(clsUserDefaValueBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjUserDefaValueEN.defaValNameId) == false && undefined !== pobjUserDefaValueEN.defaValNameId && tzDataType.isString(pobjUserDefaValueEN.defaValNameId) === false)
{
 throw new Error("(errid:Watl000060)字段[缺省值名称Id(defaValNameId)]的值:[$(pobjUserDefaValueEN.defaValNameId)], 非法，应该为字符型(In 用户缺省值(UserDefaValue))!(clsUserDefaValueBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjUserDefaValueEN.userId) == false && undefined !== pobjUserDefaValueEN.userId && tzDataType.isString(pobjUserDefaValueEN.userId) === false)
{
 throw new Error("(errid:Watl000060)字段[用户ID(userId)]的值:[$(pobjUserDefaValueEN.userId)], 非法，应该为字符型(In 用户缺省值(UserDefaValue))!(clsUserDefaValueBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjUserDefaValueEN.userDefaValue) == false && undefined !== pobjUserDefaValueEN.userDefaValue && tzDataType.isString(pobjUserDefaValueEN.userDefaValue) === false)
{
 throw new Error("(errid:Watl000060)字段[用户缺省值(userDefaValue)]的值:[$(pobjUserDefaValueEN.userDefaValue)], 非法，应该为字符型(In 用户缺省值(UserDefaValue))!(clsUserDefaValueBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjUserDefaValueEN.updDate) == false && undefined !== pobjUserDefaValueEN.updDate && tzDataType.isString(pobjUserDefaValueEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjUserDefaValueEN.updDate)], 非法，应该为字符型(In 用户缺省值(UserDefaValue))!(clsUserDefaValueBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjUserDefaValueEN.updUser) == false && undefined !== pobjUserDefaValueEN.updUser && tzDataType.isString(pobjUserDefaValueEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjUserDefaValueEN.updUser)], 非法，应该为字符型(In 用户缺省值(UserDefaValue))!(clsUserDefaValueBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjUserDefaValueEN.memo) == false && undefined !== pobjUserDefaValueEN.memo && tzDataType.isString(pobjUserDefaValueEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjUserDefaValueEN.memo)], 非法，应该为字符型(In 用户缺省值(UserDefaValue))!(clsUserDefaValueBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjUserDefaValueEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function UserDefaValue_CheckProperty4Update (pobjUserDefaValueEN: clsUserDefaValueEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjUserDefaValueEN.defaValNameId) == false && GetStrLen(pobjUserDefaValueEN.defaValNameId) > 8)
{
 throw new Error("(errid:Watl000062)字段[缺省值名称Id(defaValNameId)]的长度不能超过8(In 用户缺省值(UserDefaValue))!值:$(pobjUserDefaValueEN.defaValNameId)(clsUserDefaValueBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjUserDefaValueEN.userId) == false && GetStrLen(pobjUserDefaValueEN.userId) > 18)
{
 throw new Error("(errid:Watl000062)字段[用户ID(userId)]的长度不能超过18(In 用户缺省值(UserDefaValue))!值:$(pobjUserDefaValueEN.userId)(clsUserDefaValueBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjUserDefaValueEN.userDefaValue) == false && GetStrLen(pobjUserDefaValueEN.userDefaValue) > 100)
{
 throw new Error("(errid:Watl000062)字段[用户缺省值(userDefaValue)]的长度不能超过100(In 用户缺省值(UserDefaValue))!值:$(pobjUserDefaValueEN.userDefaValue)(clsUserDefaValueBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjUserDefaValueEN.updDate) == false && GetStrLen(pobjUserDefaValueEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 用户缺省值(UserDefaValue))!值:$(pobjUserDefaValueEN.updDate)(clsUserDefaValueBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjUserDefaValueEN.updUser) == false && GetStrLen(pobjUserDefaValueEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 用户缺省值(UserDefaValue))!值:$(pobjUserDefaValueEN.updUser)(clsUserDefaValueBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjUserDefaValueEN.memo) == false && GetStrLen(pobjUserDefaValueEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 用户缺省值(UserDefaValue))!值:$(pobjUserDefaValueEN.memo)(clsUserDefaValueBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null != pobjUserDefaValueEN.mId && undefined !== pobjUserDefaValueEN.mId && tzDataType.isNumber(pobjUserDefaValueEN.mId) === false)
{
 throw new Error("(errid:Watl000063)字段[mId(mId)]的值:[$(pobjUserDefaValueEN.mId)], 非法，应该为数值型(In 用户缺省值(UserDefaValue))!(clsUserDefaValueBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjUserDefaValueEN.defaValNameId) == false && undefined !== pobjUserDefaValueEN.defaValNameId && tzDataType.isString(pobjUserDefaValueEN.defaValNameId) === false)
{
 throw new Error("(errid:Watl000063)字段[缺省值名称Id(defaValNameId)]的值:[$(pobjUserDefaValueEN.defaValNameId)], 非法，应该为字符型(In 用户缺省值(UserDefaValue))!(clsUserDefaValueBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjUserDefaValueEN.userId) == false && undefined !== pobjUserDefaValueEN.userId && tzDataType.isString(pobjUserDefaValueEN.userId) === false)
{
 throw new Error("(errid:Watl000063)字段[用户ID(userId)]的值:[$(pobjUserDefaValueEN.userId)], 非法，应该为字符型(In 用户缺省值(UserDefaValue))!(clsUserDefaValueBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjUserDefaValueEN.userDefaValue) == false && undefined !== pobjUserDefaValueEN.userDefaValue && tzDataType.isString(pobjUserDefaValueEN.userDefaValue) === false)
{
 throw new Error("(errid:Watl000063)字段[用户缺省值(userDefaValue)]的值:[$(pobjUserDefaValueEN.userDefaValue)], 非法，应该为字符型(In 用户缺省值(UserDefaValue))!(clsUserDefaValueBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjUserDefaValueEN.updDate) == false && undefined !== pobjUserDefaValueEN.updDate && tzDataType.isString(pobjUserDefaValueEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjUserDefaValueEN.updDate)], 非法，应该为字符型(In 用户缺省值(UserDefaValue))!(clsUserDefaValueBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjUserDefaValueEN.updUser) == false && undefined !== pobjUserDefaValueEN.updUser && tzDataType.isString(pobjUserDefaValueEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjUserDefaValueEN.updUser)], 非法，应该为字符型(In 用户缺省值(UserDefaValue))!(clsUserDefaValueBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjUserDefaValueEN.memo) == false && undefined !== pobjUserDefaValueEN.memo && tzDataType.isString(pobjUserDefaValueEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjUserDefaValueEN.memo)], 非法，应该为字符型(In 用户缺省值(UserDefaValue))!(clsUserDefaValueBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjUserDefaValueEN.mId 
 || pobjUserDefaValueEN.mId != null && pobjUserDefaValueEN.mId.toString()  ===  "")
{
 throw new Error("(errid:Watl000064)字段[mId]不能为空(In 用户缺省值)!(clsUserDefaValueBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjUserDefaValueEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function UserDefaValue_GetJSONStrByObj (pobjUserDefaValueEN: clsUserDefaValueEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjUserDefaValueEN.sfUpdFldSetStr = pobjUserDefaValueEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjUserDefaValueEN);
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
export function UserDefaValue_GetObjLstByJSONStr (strJSON: string): Array<clsUserDefaValueEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrUserDefaValueObjLst = new Array<clsUserDefaValueEN>();
if (strJSON === "")
{
return arrUserDefaValueObjLst;
}
try
{
arrUserDefaValueObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrUserDefaValueObjLst;
}
return arrUserDefaValueObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrUserDefaValueObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function UserDefaValue_GetObjLstByJSONObjLst (arrUserDefaValueObjLstS: Array<clsUserDefaValueEN>): Array<clsUserDefaValueEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrUserDefaValueObjLst = new Array<clsUserDefaValueEN>();
for (const objInFor of arrUserDefaValueObjLstS) {
const obj1 = UserDefaValue_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrUserDefaValueObjLst.push(obj1);
}
return arrUserDefaValueObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function UserDefaValue_GetObjByJSONStr (strJSON: string): clsUserDefaValueEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjUserDefaValueEN = new clsUserDefaValueEN();
if (strJSON === "")
{
return pobjUserDefaValueEN;
}
try
{
pobjUserDefaValueEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjUserDefaValueEN;
}
return pobjUserDefaValueEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function UserDefaValue_GetCombineCondition(objUserDefaValue_Cond: clsUserDefaValueEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objUserDefaValue_Cond.dicFldComparisonOp, clsUserDefaValueEN.con_mId) == true)
{
const strComparisonOp_mId:string = objUserDefaValue_Cond.dicFldComparisonOp[clsUserDefaValueEN.con_mId];
strWhereCond += Format(" And {0} {2} {1}", clsUserDefaValueEN.con_mId, objUserDefaValue_Cond.mId, strComparisonOp_mId);
}
if (Object.prototype.hasOwnProperty.call(objUserDefaValue_Cond.dicFldComparisonOp, clsUserDefaValueEN.con_DefaValNameId) == true)
{
const strComparisonOp_DefaValNameId:string = objUserDefaValue_Cond.dicFldComparisonOp[clsUserDefaValueEN.con_DefaValNameId];
strWhereCond += Format(" And {0} {2} '{1}'", clsUserDefaValueEN.con_DefaValNameId, objUserDefaValue_Cond.defaValNameId, strComparisonOp_DefaValNameId);
}
if (Object.prototype.hasOwnProperty.call(objUserDefaValue_Cond.dicFldComparisonOp, clsUserDefaValueEN.con_UserId) == true)
{
const strComparisonOp_UserId:string = objUserDefaValue_Cond.dicFldComparisonOp[clsUserDefaValueEN.con_UserId];
strWhereCond += Format(" And {0} {2} '{1}'", clsUserDefaValueEN.con_UserId, objUserDefaValue_Cond.userId, strComparisonOp_UserId);
}
if (Object.prototype.hasOwnProperty.call(objUserDefaValue_Cond.dicFldComparisonOp, clsUserDefaValueEN.con_UserDefaValue) == true)
{
const strComparisonOp_UserDefaValue:string = objUserDefaValue_Cond.dicFldComparisonOp[clsUserDefaValueEN.con_UserDefaValue];
strWhereCond += Format(" And {0} {2} '{1}'", clsUserDefaValueEN.con_UserDefaValue, objUserDefaValue_Cond.userDefaValue, strComparisonOp_UserDefaValue);
}
if (Object.prototype.hasOwnProperty.call(objUserDefaValue_Cond.dicFldComparisonOp, clsUserDefaValueEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objUserDefaValue_Cond.dicFldComparisonOp[clsUserDefaValueEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsUserDefaValueEN.con_UpdDate, objUserDefaValue_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objUserDefaValue_Cond.dicFldComparisonOp, clsUserDefaValueEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objUserDefaValue_Cond.dicFldComparisonOp[clsUserDefaValueEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsUserDefaValueEN.con_UpdUser, objUserDefaValue_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objUserDefaValue_Cond.dicFldComparisonOp, clsUserDefaValueEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objUserDefaValue_Cond.dicFldComparisonOp[clsUserDefaValueEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsUserDefaValueEN.con_Memo, objUserDefaValue_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--UserDefaValue(用户缺省值),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param strDefaValNameId: 缺省值名称Id(要求唯一的字段)
 * @param strUserId: 用户ID(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function UserDefaValue_GetUniCondStr_DefaValNameId_UserId(objUserDefaValueEN: clsUserDefaValueEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and DefaValNameId = '{0}'", objUserDefaValueEN.defaValNameId);
 strWhereCond +=  Format(" and UserId = '{0}'", objUserDefaValueEN.userId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--UserDefaValue(用户缺省值),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param strDefaValNameId: 缺省值名称Id(要求唯一的字段)
 * @param strUserId: 用户ID(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function UserDefaValue_GetUniCondStr4Update_DefaValNameId_UserId(objUserDefaValueEN: clsUserDefaValueEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and mId <> '{0}'", objUserDefaValueEN.mId);
 strWhereCond +=  Format(" and DefaValNameId = '{0}'", objUserDefaValueEN.defaValNameId);
 strWhereCond +=  Format(" and UserId = '{0}'", objUserDefaValueEN.userId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objUserDefaValueENS:源对象
 * @param objUserDefaValueENT:目标对象
*/
export function UserDefaValue_CopyObjTo(objUserDefaValueENS: clsUserDefaValueEN , objUserDefaValueENT: clsUserDefaValueEN ): void 
{
objUserDefaValueENT.mId = objUserDefaValueENS.mId; //mId
objUserDefaValueENT.defaValNameId = objUserDefaValueENS.defaValNameId; //缺省值名称Id
objUserDefaValueENT.userId = objUserDefaValueENS.userId; //用户ID
objUserDefaValueENT.userDefaValue = objUserDefaValueENS.userDefaValue; //用户缺省值
objUserDefaValueENT.updDate = objUserDefaValueENS.updDate; //修改日期
objUserDefaValueENT.updUser = objUserDefaValueENS.updUser; //修改人
objUserDefaValueENT.memo = objUserDefaValueENS.memo; //备注
objUserDefaValueENT.sfUpdFldSetStr = objUserDefaValueENS.updFldString; //sfUpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objUserDefaValueENS:源对象
 * @param objUserDefaValueENT:目标对象
*/
export function UserDefaValue_GetObjFromJsonObj(objUserDefaValueENS: clsUserDefaValueEN): clsUserDefaValueEN 
{
 const objUserDefaValueENT: clsUserDefaValueEN = new clsUserDefaValueEN();
ObjectAssign(objUserDefaValueENT, objUserDefaValueENS);
 return objUserDefaValueENT;
}