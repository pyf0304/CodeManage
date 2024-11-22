﻿
 /**
 * 类名:clsPlatDefaRoleWApi
 * 表名:PlatDefaRole(01120231)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:45:54
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
 * 平台默认角色(PlatDefaRole)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { clsPlatDefaRoleEN } from "../../L0_Entity/SysPara/clsPlatDefaRoleEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { tzDataType } from "../../PubFun/jsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const platDefaRole_Controller = "PlatDefaRoleApi";
 export const platDefaRole_ConstructorName = "platDefaRole";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngmId:关键字
 * @returns 对象
 **/
export async function PlatDefaRole_GetObjBymIdAsync(lngmId: number): Promise<clsPlatDefaRoleEN>  
{
const strThisFuncName = "GetObjBymIdAsync";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In GetObjBymIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjBymId";
const strUrl = GetWebApiUrl(platDefaRole_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", platDefaRole_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objPlatDefaRole = PlatDefaRole_GetObjFromJsonObj(returnObj);
return objPlatDefaRole;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, platDefaRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, platDefaRole_ConstructorName, strThisFuncName);
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
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
 * @param a:比较的第1个对象
 * @param  b:比较的第1个对象
 * @returns 返回两个对象比较的结果
*/
export function PlatDefaRole_SortFun_Defa(a:clsPlatDefaRoleEN , b:clsPlatDefaRoleEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.mId-b.mId;
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
export function PlatDefaRole_SortFun_Defa_2Fld(a:clsPlatDefaRoleEN , b:clsPlatDefaRoleEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.id_School == b.id_School) return a.personType.localeCompare(b.personType);
else return a.id_School.localeCompare(b.id_School);
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
export function PlatDefaRole_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsPlatDefaRoleEN.con_mId:
return (a: clsPlatDefaRoleEN, b: clsPlatDefaRoleEN) => {
return a.mId-b.mId;
}
case clsPlatDefaRoleEN.con_id_School:
return (a: clsPlatDefaRoleEN, b: clsPlatDefaRoleEN) => {
return a.id_School.localeCompare(b.id_School);
}
case clsPlatDefaRoleEN.con_PersonType:
return (a: clsPlatDefaRoleEN, b: clsPlatDefaRoleEN) => {
return a.personType.localeCompare(b.personType);
}
case clsPlatDefaRoleEN.con_PrjId:
return (a: clsPlatDefaRoleEN, b: clsPlatDefaRoleEN) => {
return a.prjId.localeCompare(b.prjId);
}
case clsPlatDefaRoleEN.con_RoleId:
return (a: clsPlatDefaRoleEN, b: clsPlatDefaRoleEN) => {
return a.roleId.localeCompare(b.roleId);
}
case clsPlatDefaRoleEN.con_Memo:
return (a: clsPlatDefaRoleEN, b: clsPlatDefaRoleEN) => {
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[PlatDefaRole]中不存在！(in ${ platDefaRole_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsPlatDefaRoleEN.con_mId:
return (a: clsPlatDefaRoleEN, b: clsPlatDefaRoleEN) => {
return b.mId-a.mId;
}
case clsPlatDefaRoleEN.con_id_School:
return (a: clsPlatDefaRoleEN, b: clsPlatDefaRoleEN) => {
return b.id_School.localeCompare(a.id_School);
}
case clsPlatDefaRoleEN.con_PersonType:
return (a: clsPlatDefaRoleEN, b: clsPlatDefaRoleEN) => {
return b.personType.localeCompare(a.personType);
}
case clsPlatDefaRoleEN.con_PrjId:
return (a: clsPlatDefaRoleEN, b: clsPlatDefaRoleEN) => {
return b.prjId.localeCompare(a.prjId);
}
case clsPlatDefaRoleEN.con_RoleId:
return (a: clsPlatDefaRoleEN, b: clsPlatDefaRoleEN) => {
return b.roleId.localeCompare(a.roleId);
}
case clsPlatDefaRoleEN.con_Memo:
return (a: clsPlatDefaRoleEN, b: clsPlatDefaRoleEN) => {
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[PlatDefaRole]中不存在！(in ${ platDefaRole_ConstructorName}.${ strThisFuncName})`;
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
export async function PlatDefaRole_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsPlatDefaRoleEN.con_mId:
return (obj: clsPlatDefaRoleEN) => {
return obj.mId === value;
}
case clsPlatDefaRoleEN.con_id_School:
return (obj: clsPlatDefaRoleEN) => {
return obj.id_School === value;
}
case clsPlatDefaRoleEN.con_PersonType:
return (obj: clsPlatDefaRoleEN) => {
return obj.personType === value;
}
case clsPlatDefaRoleEN.con_PrjId:
return (obj: clsPlatDefaRoleEN) => {
return obj.prjId === value;
}
case clsPlatDefaRoleEN.con_RoleId:
return (obj: clsPlatDefaRoleEN) => {
return obj.roleId === value;
}
case clsPlatDefaRoleEN.con_Memo:
return (obj: clsPlatDefaRoleEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[PlatDefaRole]中不存在！(in ${ platDefaRole_ConstructorName}.${ strThisFuncName})`;
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
export async function PlatDefaRole_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(platDefaRole_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, platDefaRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, platDefaRole_ConstructorName, strThisFuncName);
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
export async function PlatDefaRole_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(platDefaRole_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, platDefaRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, platDefaRole_ConstructorName, strThisFuncName);
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
export async function PlatDefaRole_GetFirstObjAsync(strWhereCond: string): Promise<clsPlatDefaRoleEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(platDefaRole_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", platDefaRole_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objPlatDefaRole = PlatDefaRole_GetObjFromJsonObj(returnObj);
return objPlatDefaRole;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, platDefaRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, platDefaRole_ConstructorName, strThisFuncName);
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
export async function PlatDefaRole_GetObjLstAsync(strWhereCond: string): Promise<Array<clsPlatDefaRoleEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(platDefaRole_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", platDefaRole_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = PlatDefaRole_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, platDefaRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, platDefaRole_ConstructorName, strThisFuncName);
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
export async function PlatDefaRole_GetObjLstBymIdLstAsync(arrmId: Array<string>): Promise<Array<clsPlatDefaRoleEN>>  
{
const strThisFuncName = "GetObjLstBymIdLstAsync";
const strAction = "GetObjLstBymIdLst";
const strUrl = GetWebApiUrl(platDefaRole_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrmId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", platDefaRole_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = PlatDefaRole_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, platDefaRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, platDefaRole_ConstructorName, strThisFuncName);
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
export async function PlatDefaRole_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsPlatDefaRoleEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(platDefaRole_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", platDefaRole_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = PlatDefaRole_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, platDefaRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, platDefaRole_ConstructorName, strThisFuncName);
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
export async function PlatDefaRole_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsPlatDefaRoleEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(platDefaRole_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", platDefaRole_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = PlatDefaRole_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, platDefaRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, platDefaRole_ConstructorName, strThisFuncName);
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
export async function PlatDefaRole_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(platDefaRole_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, platDefaRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, platDefaRole_ConstructorName, strThisFuncName);
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
export async function PlatDefaRole_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsPlatDefaRoleEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(platDefaRole_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", platDefaRole_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = PlatDefaRole_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, platDefaRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, platDefaRole_ConstructorName, strThisFuncName);
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
export async function PlatDefaRole_DelRecordAsync(lngmId: number): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(platDefaRole_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, lngmId);
try
{
const response = await axios.delete(strUrl,
{
params: { "Id": lngmId, }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, platDefaRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, platDefaRole_ConstructorName, strThisFuncName);
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
export async function PlatDefaRole_DelPlatDefaRolesAsync(arrmId: Array<string>): Promise<number> 
{
const strThisFuncName = "DelPlatDefaRolesAsync";
const strAction = "DelPlatDefaRoles";
const strUrl = GetWebApiUrl(platDefaRole_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, platDefaRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, platDefaRole_ConstructorName, strThisFuncName);
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
export async function PlatDefaRole_DelPlatDefaRolesByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "DelPlatDefaRolesByCondAsync";
const strAction = "DelPlatDefaRolesByCond";
const strUrl = GetWebApiUrl(platDefaRole_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, platDefaRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, platDefaRole_ConstructorName, strThisFuncName);
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
 * @param objPlatDefaRoleEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function PlatDefaRole_AddNewRecordAsync(objPlatDefaRoleEN: clsPlatDefaRoleEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objPlatDefaRoleEN);
const strUrl = GetWebApiUrl(platDefaRole_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPlatDefaRoleEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, platDefaRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, platDefaRole_ConstructorName, strThisFuncName);
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
 * @param objPlatDefaRoleEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function PlatDefaRole_AddNewRecordWithReturnKeyAsync(objPlatDefaRoleEN: clsPlatDefaRoleEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(platDefaRole_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPlatDefaRoleEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, platDefaRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, platDefaRole_ConstructorName, strThisFuncName);
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
 * @param objPlatDefaRoleEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function PlatDefaRole_AddNewRecordWithReturnKey(objPlatDefaRoleEN: clsPlatDefaRoleEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objPlatDefaRoleEN.mId === null || objPlatDefaRoleEN.mId === 0)
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(platDefaRole_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPlatDefaRoleEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, platDefaRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, platDefaRole_ConstructorName, strThisFuncName);
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
 * @param objPlatDefaRoleEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function PlatDefaRole_UpdateRecordAsync(objPlatDefaRoleEN: clsPlatDefaRoleEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objPlatDefaRoleEN.sf_UpdFldSetStr === undefined || objPlatDefaRoleEN.sf_UpdFldSetStr === null || objPlatDefaRoleEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objPlatDefaRoleEN.mId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(platDefaRole_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPlatDefaRoleEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, platDefaRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, platDefaRole_ConstructorName, strThisFuncName);
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
 * @param objPlatDefaRoleEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function PlatDefaRole_UpdateWithConditionAsync(objPlatDefaRoleEN: clsPlatDefaRoleEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objPlatDefaRoleEN.sf_UpdFldSetStr === undefined || objPlatDefaRoleEN.sf_UpdFldSetStr === null || objPlatDefaRoleEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objPlatDefaRoleEN.mId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(platDefaRole_Controller, strAction);
objPlatDefaRoleEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objPlatDefaRoleEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, platDefaRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, platDefaRole_ConstructorName, strThisFuncName);
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
export async function PlatDefaRole_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(platDefaRole_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, platDefaRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, platDefaRole_ConstructorName, strThisFuncName);
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
export async function PlatDefaRole_IsExist(lngmId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(platDefaRole_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, platDefaRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, platDefaRole_ConstructorName, strThisFuncName);
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
export async function PlatDefaRole_IsExistAsync(lngmId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(platDefaRole_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, platDefaRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, platDefaRole_ConstructorName, strThisFuncName);
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
export async function PlatDefaRole_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(platDefaRole_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, platDefaRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, platDefaRole_ConstructorName, strThisFuncName);
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
export async function PlatDefaRole_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(platDefaRole_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, platDefaRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, platDefaRole_ConstructorName, strThisFuncName);
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
export function PlatDefaRole_GetWebApiUrl(strController: string, strAction: string): string {
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
export function PlatDefaRole_CheckPropertyNew(pobjPlatDefaRoleEN: clsPlatDefaRoleEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjPlatDefaRoleEN.personType) === true )
{
 throw new Error("(errid:Watl000058)字段[人员类别]不能为空(In 平台默认角色)!(clsPlatDefaRoleBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPlatDefaRoleEN.prjId) === true )
{
 throw new Error("(errid:Watl000058)字段[PrjId]不能为空(In 平台默认角色)!(clsPlatDefaRoleBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPlatDefaRoleEN.roleId) === true 
 || pobjPlatDefaRoleEN.roleId.toString()  ===  "0" )
{
 throw new Error("(errid:Watl000058)字段[角色Id]不能为空(In 平台默认角色)!(clsPlatDefaRoleBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjPlatDefaRoleEN.id_School) == false && GetStrLen(pobjPlatDefaRoleEN.id_School) > 4)
{
 throw new Error("(errid:Watl000059)字段[学校流水号(id_School)]的长度不能超过4(In 平台默认角色(PlatDefaRole))!值:$(pobjPlatDefaRoleEN.id_School)(clsPlatDefaRoleBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPlatDefaRoleEN.personType) == false && GetStrLen(pobjPlatDefaRoleEN.personType) > 30)
{
 throw new Error("(errid:Watl000059)字段[人员类别(personType)]的长度不能超过30(In 平台默认角色(PlatDefaRole))!值:$(pobjPlatDefaRoleEN.personType)(clsPlatDefaRoleBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPlatDefaRoleEN.prjId) == false && GetStrLen(pobjPlatDefaRoleEN.prjId) > 4)
{
 throw new Error("(errid:Watl000059)字段[PrjId(prjId)]的长度不能超过4(In 平台默认角色(PlatDefaRole))!值:$(pobjPlatDefaRoleEN.prjId)(clsPlatDefaRoleBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPlatDefaRoleEN.roleId) == false && GetStrLen(pobjPlatDefaRoleEN.roleId) > 8)
{
 throw new Error("(errid:Watl000059)字段[角色Id(roleId)]的长度不能超过8(In 平台默认角色(PlatDefaRole))!值:$(pobjPlatDefaRoleEN.roleId)(clsPlatDefaRoleBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPlatDefaRoleEN.memo) == false && GetStrLen(pobjPlatDefaRoleEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 平台默认角色(PlatDefaRole))!值:$(pobjPlatDefaRoleEN.memo)(clsPlatDefaRoleBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null != pobjPlatDefaRoleEN.mId && undefined !== pobjPlatDefaRoleEN.mId && tzDataType.isNumber(pobjPlatDefaRoleEN.mId) === false)
{
 throw new Error("(errid:Watl000060)字段[mId(mId)]的值:[$(pobjPlatDefaRoleEN.mId)], 非法，应该为数值型(In 平台默认角色(PlatDefaRole))!(clsPlatDefaRoleBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPlatDefaRoleEN.id_School) == false && undefined !== pobjPlatDefaRoleEN.id_School && tzDataType.isString(pobjPlatDefaRoleEN.id_School) === false)
{
 throw new Error("(errid:Watl000060)字段[学校流水号(id_School)]的值:[$(pobjPlatDefaRoleEN.id_School)], 非法，应该为字符型(In 平台默认角色(PlatDefaRole))!(clsPlatDefaRoleBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPlatDefaRoleEN.personType) == false && undefined !== pobjPlatDefaRoleEN.personType && tzDataType.isString(pobjPlatDefaRoleEN.personType) === false)
{
 throw new Error("(errid:Watl000060)字段[人员类别(personType)]的值:[$(pobjPlatDefaRoleEN.personType)], 非法，应该为字符型(In 平台默认角色(PlatDefaRole))!(clsPlatDefaRoleBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPlatDefaRoleEN.prjId) == false && undefined !== pobjPlatDefaRoleEN.prjId && tzDataType.isString(pobjPlatDefaRoleEN.prjId) === false)
{
 throw new Error("(errid:Watl000060)字段[PrjId(prjId)]的值:[$(pobjPlatDefaRoleEN.prjId)], 非法，应该为字符型(In 平台默认角色(PlatDefaRole))!(clsPlatDefaRoleBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPlatDefaRoleEN.roleId) == false && undefined !== pobjPlatDefaRoleEN.roleId && tzDataType.isString(pobjPlatDefaRoleEN.roleId) === false)
{
 throw new Error("(errid:Watl000060)字段[角色Id(roleId)]的值:[$(pobjPlatDefaRoleEN.roleId)], 非法，应该为字符型(In 平台默认角色(PlatDefaRole))!(clsPlatDefaRoleBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPlatDefaRoleEN.memo) == false && undefined !== pobjPlatDefaRoleEN.memo && tzDataType.isString(pobjPlatDefaRoleEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjPlatDefaRoleEN.memo)], 非法，应该为字符型(In 平台默认角色(PlatDefaRole))!(clsPlatDefaRoleBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjPlatDefaRoleEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function PlatDefaRole_CheckProperty4Update (pobjPlatDefaRoleEN: clsPlatDefaRoleEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjPlatDefaRoleEN.id_School) == false && GetStrLen(pobjPlatDefaRoleEN.id_School) > 4)
{
 throw new Error("(errid:Watl000062)字段[学校流水号(id_School)]的长度不能超过4(In 平台默认角色(PlatDefaRole))!值:$(pobjPlatDefaRoleEN.id_School)(clsPlatDefaRoleBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPlatDefaRoleEN.personType) == false && GetStrLen(pobjPlatDefaRoleEN.personType) > 30)
{
 throw new Error("(errid:Watl000062)字段[人员类别(personType)]的长度不能超过30(In 平台默认角色(PlatDefaRole))!值:$(pobjPlatDefaRoleEN.personType)(clsPlatDefaRoleBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPlatDefaRoleEN.prjId) == false && GetStrLen(pobjPlatDefaRoleEN.prjId) > 4)
{
 throw new Error("(errid:Watl000062)字段[PrjId(prjId)]的长度不能超过4(In 平台默认角色(PlatDefaRole))!值:$(pobjPlatDefaRoleEN.prjId)(clsPlatDefaRoleBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPlatDefaRoleEN.roleId) == false && GetStrLen(pobjPlatDefaRoleEN.roleId) > 8)
{
 throw new Error("(errid:Watl000062)字段[角色Id(roleId)]的长度不能超过8(In 平台默认角色(PlatDefaRole))!值:$(pobjPlatDefaRoleEN.roleId)(clsPlatDefaRoleBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPlatDefaRoleEN.memo) == false && GetStrLen(pobjPlatDefaRoleEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 平台默认角色(PlatDefaRole))!值:$(pobjPlatDefaRoleEN.memo)(clsPlatDefaRoleBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null != pobjPlatDefaRoleEN.mId && undefined !== pobjPlatDefaRoleEN.mId && tzDataType.isNumber(pobjPlatDefaRoleEN.mId) === false)
{
 throw new Error("(errid:Watl000063)字段[mId(mId)]的值:[$(pobjPlatDefaRoleEN.mId)], 非法，应该为数值型(In 平台默认角色(PlatDefaRole))!(clsPlatDefaRoleBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPlatDefaRoleEN.id_School) == false && undefined !== pobjPlatDefaRoleEN.id_School && tzDataType.isString(pobjPlatDefaRoleEN.id_School) === false)
{
 throw new Error("(errid:Watl000063)字段[学校流水号(id_School)]的值:[$(pobjPlatDefaRoleEN.id_School)], 非法，应该为字符型(In 平台默认角色(PlatDefaRole))!(clsPlatDefaRoleBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPlatDefaRoleEN.personType) == false && undefined !== pobjPlatDefaRoleEN.personType && tzDataType.isString(pobjPlatDefaRoleEN.personType) === false)
{
 throw new Error("(errid:Watl000063)字段[人员类别(personType)]的值:[$(pobjPlatDefaRoleEN.personType)], 非法，应该为字符型(In 平台默认角色(PlatDefaRole))!(clsPlatDefaRoleBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPlatDefaRoleEN.prjId) == false && undefined !== pobjPlatDefaRoleEN.prjId && tzDataType.isString(pobjPlatDefaRoleEN.prjId) === false)
{
 throw new Error("(errid:Watl000063)字段[PrjId(prjId)]的值:[$(pobjPlatDefaRoleEN.prjId)], 非法，应该为字符型(In 平台默认角色(PlatDefaRole))!(clsPlatDefaRoleBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPlatDefaRoleEN.roleId) == false && undefined !== pobjPlatDefaRoleEN.roleId && tzDataType.isString(pobjPlatDefaRoleEN.roleId) === false)
{
 throw new Error("(errid:Watl000063)字段[角色Id(roleId)]的值:[$(pobjPlatDefaRoleEN.roleId)], 非法，应该为字符型(In 平台默认角色(PlatDefaRole))!(clsPlatDefaRoleBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPlatDefaRoleEN.memo) == false && undefined !== pobjPlatDefaRoleEN.memo && tzDataType.isString(pobjPlatDefaRoleEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjPlatDefaRoleEN.memo)], 非法，应该为字符型(In 平台默认角色(PlatDefaRole))!(clsPlatDefaRoleBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjPlatDefaRoleEN.mId 
 || pobjPlatDefaRoleEN.mId != null && pobjPlatDefaRoleEN.mId.toString()  ===  "")
{
 throw new Error("(errid:Watl000064)字段[mId]不能为空(In 平台默认角色)!(clsPlatDefaRoleBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjPlatDefaRoleEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function PlatDefaRole_GetJSONStrByObj (pobjPlatDefaRoleEN: clsPlatDefaRoleEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjPlatDefaRoleEN.sf_UpdFldSetStr = pobjPlatDefaRoleEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjPlatDefaRoleEN);
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
export function PlatDefaRole_GetObjLstByJSONStr (strJSON: string): Array<clsPlatDefaRoleEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrPlatDefaRoleObjLst = new Array<clsPlatDefaRoleEN>();
if (strJSON === "")
{
return arrPlatDefaRoleObjLst;
}
try
{
arrPlatDefaRoleObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrPlatDefaRoleObjLst;
}
return arrPlatDefaRoleObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrPlatDefaRoleObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function PlatDefaRole_GetObjLstByJSONObjLst (arrPlatDefaRoleObjLstS: Array<clsPlatDefaRoleEN>): Array<clsPlatDefaRoleEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrPlatDefaRoleObjLst = new Array<clsPlatDefaRoleEN>();
for (const objInFor of arrPlatDefaRoleObjLstS) {
const obj1 = PlatDefaRole_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrPlatDefaRoleObjLst.push(obj1);
}
return arrPlatDefaRoleObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function PlatDefaRole_GetObjByJSONStr (strJSON: string): clsPlatDefaRoleEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjPlatDefaRoleEN = new clsPlatDefaRoleEN();
if (strJSON === "")
{
return pobjPlatDefaRoleEN;
}
try
{
pobjPlatDefaRoleEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjPlatDefaRoleEN;
}
return pobjPlatDefaRoleEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function PlatDefaRole_GetCombineCondition(objPlatDefaRole_Cond: clsPlatDefaRoleEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objPlatDefaRole_Cond.dicFldComparisonOp, clsPlatDefaRoleEN.con_mId) == true)
{
const strComparisonOp_mId:string = objPlatDefaRole_Cond.dicFldComparisonOp[clsPlatDefaRoleEN.con_mId];
strWhereCond += Format(" And {0} {2} {1}", clsPlatDefaRoleEN.con_mId, objPlatDefaRole_Cond.mId, strComparisonOp_mId);
}
if (Object.prototype.hasOwnProperty.call(objPlatDefaRole_Cond.dicFldComparisonOp, clsPlatDefaRoleEN.con_id_School) == true)
{
const strComparisonOp_id_School:string = objPlatDefaRole_Cond.dicFldComparisonOp[clsPlatDefaRoleEN.con_id_School];
strWhereCond += Format(" And {0} {2} '{1}'", clsPlatDefaRoleEN.con_id_School, objPlatDefaRole_Cond.id_School, strComparisonOp_id_School);
}
if (Object.prototype.hasOwnProperty.call(objPlatDefaRole_Cond.dicFldComparisonOp, clsPlatDefaRoleEN.con_PersonType) == true)
{
const strComparisonOp_PersonType:string = objPlatDefaRole_Cond.dicFldComparisonOp[clsPlatDefaRoleEN.con_PersonType];
strWhereCond += Format(" And {0} {2} '{1}'", clsPlatDefaRoleEN.con_PersonType, objPlatDefaRole_Cond.personType, strComparisonOp_PersonType);
}
if (Object.prototype.hasOwnProperty.call(objPlatDefaRole_Cond.dicFldComparisonOp, clsPlatDefaRoleEN.con_PrjId) == true)
{
const strComparisonOp_PrjId:string = objPlatDefaRole_Cond.dicFldComparisonOp[clsPlatDefaRoleEN.con_PrjId];
strWhereCond += Format(" And {0} {2} '{1}'", clsPlatDefaRoleEN.con_PrjId, objPlatDefaRole_Cond.prjId, strComparisonOp_PrjId);
}
if (Object.prototype.hasOwnProperty.call(objPlatDefaRole_Cond.dicFldComparisonOp, clsPlatDefaRoleEN.con_RoleId) == true)
{
const strComparisonOp_RoleId:string = objPlatDefaRole_Cond.dicFldComparisonOp[clsPlatDefaRoleEN.con_RoleId];
strWhereCond += Format(" And {0} {2} '{1}'", clsPlatDefaRoleEN.con_RoleId, objPlatDefaRole_Cond.roleId, strComparisonOp_RoleId);
}
if (Object.prototype.hasOwnProperty.call(objPlatDefaRole_Cond.dicFldComparisonOp, clsPlatDefaRoleEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objPlatDefaRole_Cond.dicFldComparisonOp[clsPlatDefaRoleEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsPlatDefaRoleEN.con_Memo, objPlatDefaRole_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--PlatDefaRole(平台默认角色),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param strid_School: 学校流水号(要求唯一的字段)
 * @param strPrjId: PrjId(要求唯一的字段)
 * @param strRoleId: 角色Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function PlatDefaRole_GetUniCondStr_id_School_PrjId_RoleId(objPlatDefaRoleEN: clsPlatDefaRoleEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and id_School = '{0}'", objPlatDefaRoleEN.id_School);
 strWhereCond +=  Format(" and PrjId = '{0}'", objPlatDefaRoleEN.prjId);
 strWhereCond +=  Format(" and RoleId = '{0}'", objPlatDefaRoleEN.roleId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--PlatDefaRole(平台默认角色),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param strid_School: 学校流水号(要求唯一的字段)
 * @param strPrjId: PrjId(要求唯一的字段)
 * @param strRoleId: 角色Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function PlatDefaRole_GetUniCondStr4Update_id_School_PrjId_RoleId(objPlatDefaRoleEN: clsPlatDefaRoleEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and mId <> '{0}'", objPlatDefaRoleEN.mId);
 strWhereCond +=  Format(" and id_School = '{0}'", objPlatDefaRoleEN.id_School);
 strWhereCond +=  Format(" and PrjId = '{0}'", objPlatDefaRoleEN.prjId);
 strWhereCond +=  Format(" and RoleId = '{0}'", objPlatDefaRoleEN.roleId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objPlatDefaRoleENS:源对象
 * @param objPlatDefaRoleENT:目标对象
*/
export function PlatDefaRole_CopyObjTo(objPlatDefaRoleENS: clsPlatDefaRoleEN , objPlatDefaRoleENT: clsPlatDefaRoleEN ): void 
{
objPlatDefaRoleENT.mId = objPlatDefaRoleENS.mId; //mId
objPlatDefaRoleENT.id_School = objPlatDefaRoleENS.id_School; //学校流水号
objPlatDefaRoleENT.personType = objPlatDefaRoleENS.personType; //人员类别
objPlatDefaRoleENT.prjId = objPlatDefaRoleENS.prjId; //PrjId
objPlatDefaRoleENT.roleId = objPlatDefaRoleENS.roleId; //角色Id
objPlatDefaRoleENT.memo = objPlatDefaRoleENS.memo; //备注
objPlatDefaRoleENT.sf_UpdFldSetStr = objPlatDefaRoleENS.updFldString; //sf_UpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objPlatDefaRoleENS:源对象
 * @param objPlatDefaRoleENT:目标对象
*/
export function PlatDefaRole_GetObjFromJsonObj(objPlatDefaRoleENS: clsPlatDefaRoleEN): clsPlatDefaRoleEN 
{
 const objPlatDefaRoleENT: clsPlatDefaRoleEN = new clsPlatDefaRoleEN();
ObjectAssign(objPlatDefaRoleENT, objPlatDefaRoleENS);
 return objPlatDefaRoleENT;
}