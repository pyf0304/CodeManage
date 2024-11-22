
 /**
 * 类名:clsSysDefaValNameWApi
 * 表名:SysDefaValName(01120936)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:52:24
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
 * SysDefaValName(SysDefaValName)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2023年03月13日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { enumComparisonOp } from "../../PubFun/enumComparisonOp.js";
import { clsSysDefaValNameEN } from "../../L0_Entity/LogManage/clsSysDefaValNameEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { tzDataType } from "../../PubFun/clsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const sysDefaValName_Controller = "SysDefaValNameApi";
 export const sysDefaValName_ConstructorName = "sysDefaValName";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strDefaValNameId:关键字
 * @returns 对象
 **/
export async function SysDefaValName_GetObjByDefaValNameIdAsync(strDefaValNameId: string): Promise<clsSysDefaValNameEN|null>  
{
const strThisFuncName = "GetObjByDefaValNameIdAsync";

if (IsNullOrEmpty(strDefaValNameId) == true)
{
  const strMsg = Format("参数:[strDefaValNameId]不能为空！(In clsSysDefaValNameWApi.GetObjByDefaValNameIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjByDefaValNameId";
const strUrl = GetWebApiUrl(sysDefaValName_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strDefaValNameId": strDefaValNameId,
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
const objSysDefaValName = SysDefaValName_GetObjFromJsonObj(returnObj);
return objSysDefaValName;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysDefaValName_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysDefaValName_ConstructorName, strThisFuncName);
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
export function SysDefaValName_SortFun_Defa(a:clsSysDefaValNameEN , b:clsSysDefaValNameEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.defaValNameId.localeCompare(b.defaValNameId);
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
export function SysDefaValName_SortFun_Defa_2Fld(a:clsSysDefaValNameEN , b:clsSysDefaValNameEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.defaValName == b.defaValName) return a.sysDefaValue.localeCompare(b.sysDefaValue);
else return a.defaValName.localeCompare(b.defaValName);
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
export function SysDefaValName_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsSysDefaValNameEN.con_DefaValNameId:
return (a: clsSysDefaValNameEN, b: clsSysDefaValNameEN) => {
return a.defaValNameId.localeCompare(b.defaValNameId);
}
case clsSysDefaValNameEN.con_DefaValName:
return (a: clsSysDefaValNameEN, b: clsSysDefaValNameEN) => {
return a.defaValName.localeCompare(b.defaValName);
}
case clsSysDefaValNameEN.con_SysDefaValue:
return (a: clsSysDefaValNameEN, b: clsSysDefaValNameEN) => {
return a.sysDefaValue.localeCompare(b.sysDefaValue);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[SysDefaValName]中不存在！(in ${ sysDefaValName_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsSysDefaValNameEN.con_DefaValNameId:
return (a: clsSysDefaValNameEN, b: clsSysDefaValNameEN) => {
return b.defaValNameId.localeCompare(a.defaValNameId);
}
case clsSysDefaValNameEN.con_DefaValName:
return (a: clsSysDefaValNameEN, b: clsSysDefaValNameEN) => {
return b.defaValName.localeCompare(a.defaValName);
}
case clsSysDefaValNameEN.con_SysDefaValue:
return (a: clsSysDefaValNameEN, b: clsSysDefaValNameEN) => {
return b.sysDefaValue.localeCompare(a.sysDefaValue);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[SysDefaValName]中不存在！(in ${ sysDefaValName_ConstructorName}.${ strThisFuncName})`;
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
export async function SysDefaValName_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsSysDefaValNameEN.con_DefaValNameId:
return (obj: clsSysDefaValNameEN) => {
return obj.defaValNameId === value;
}
case clsSysDefaValNameEN.con_DefaValName:
return (obj: clsSysDefaValNameEN) => {
return obj.defaValName === value;
}
case clsSysDefaValNameEN.con_SysDefaValue:
return (obj: clsSysDefaValNameEN) => {
return obj.sysDefaValue === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[SysDefaValName]中不存在！(in ${ sysDefaValName_ConstructorName}.${ strThisFuncName})`;
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
export async function SysDefaValName_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(sysDefaValName_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysDefaValName_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysDefaValName_ConstructorName, strThisFuncName);
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
export async function SysDefaValName_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(sysDefaValName_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysDefaValName_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysDefaValName_ConstructorName, strThisFuncName);
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
export async function SysDefaValName_GetFirstObjAsync(strWhereCond: string): Promise<clsSysDefaValNameEN|null>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(sysDefaValName_Controller, strAction);
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
const objSysDefaValName = SysDefaValName_GetObjFromJsonObj(returnObj);
return objSysDefaValName;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysDefaValName_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysDefaValName_ConstructorName, strThisFuncName);
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
export async function SysDefaValName_GetObjLstAsync(strWhereCond: string): Promise<Array<clsSysDefaValNameEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(sysDefaValName_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sysDefaValName_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = SysDefaValName_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysDefaValName_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysDefaValName_ConstructorName, strThisFuncName);
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
 * @param arrDefaValNameId:关键字列表
 * @returns 对象列表
 **/
export async function SysDefaValName_GetObjLstByDefaValNameIdLstAsync(arrDefaValNameId: Array<string>): Promise<Array<clsSysDefaValNameEN>>  
{
const strThisFuncName = "GetObjLstByDefaValNameIdLstAsync";
const strAction = "GetObjLstByDefaValNameIdLst";
const strUrl = GetWebApiUrl(sysDefaValName_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrDefaValNameId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sysDefaValName_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = SysDefaValName_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysDefaValName_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysDefaValName_ConstructorName, strThisFuncName);
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
export async function SysDefaValName_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsSysDefaValNameEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(sysDefaValName_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sysDefaValName_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = SysDefaValName_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysDefaValName_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysDefaValName_ConstructorName, strThisFuncName);
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
export async function SysDefaValName_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsSysDefaValNameEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(sysDefaValName_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sysDefaValName_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = SysDefaValName_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysDefaValName_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysDefaValName_ConstructorName, strThisFuncName);
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
export async function SysDefaValName_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(sysDefaValName_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysDefaValName_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysDefaValName_ConstructorName, strThisFuncName);
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
export async function SysDefaValName_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsSysDefaValNameEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
if (objPagerPara.pageIndex == 0) return new Array<clsSysDefaValNameEN>();
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(sysDefaValName_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sysDefaValName_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = SysDefaValName_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysDefaValName_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysDefaValName_ConstructorName, strThisFuncName);
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
 * @param strDefaValNameId:关键字
 * @returns 获取删除的结果
 **/
export async function SysDefaValName_DelRecordAsync(strDefaValNameId: string): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(sysDefaValName_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, strDefaValNameId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysDefaValName_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysDefaValName_ConstructorName, strThisFuncName);
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
 * @param arrDefaValNameId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function SysDefaValName_DelSysDefaValNamesAsync(arrDefaValNameId: Array<string>): Promise<number> 
{
const strThisFuncName = "DelSysDefaValNamesAsync";
const strAction = "DelSysDefaValNames";
const strUrl = GetWebApiUrl(sysDefaValName_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrDefaValNameId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysDefaValName_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysDefaValName_ConstructorName, strThisFuncName);
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
export async function SysDefaValName_DelSysDefaValNamesByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "DelSysDefaValNamesByCondAsync";
const strAction = "DelSysDefaValNamesByCond";
const strUrl = GetWebApiUrl(sysDefaValName_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysDefaValName_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysDefaValName_ConstructorName, strThisFuncName);
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
 * @param objSysDefaValNameEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function SysDefaValName_AddNewRecordAsync(objSysDefaValNameEN: clsSysDefaValNameEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
if (objSysDefaValNameEN.defaValNameId === null || objSysDefaValNameEN.defaValNameId === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objSysDefaValNameEN);
const strUrl = GetWebApiUrl(sysDefaValName_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSysDefaValNameEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysDefaValName_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysDefaValName_ConstructorName, strThisFuncName);
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
 * @param objSysDefaValNameEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function SysDefaValName_AddNewRecordWithMaxIdAsync(objSysDefaValNameEN: clsSysDefaValNameEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithMaxIdAsync";
const strAction = "AddNewRecordWithMaxId";
const strUrl = GetWebApiUrl(sysDefaValName_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSysDefaValNameEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysDefaValName_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysDefaValName_ConstructorName, strThisFuncName);
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
 * @param objSysDefaValNameEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function SysDefaValName_AddNewRecordWithReturnKeyAsync(objSysDefaValNameEN: clsSysDefaValNameEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(sysDefaValName_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSysDefaValNameEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysDefaValName_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysDefaValName_ConstructorName, strThisFuncName);
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
 * @param objSysDefaValNameEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function SysDefaValName_AddNewRecordWithReturnKey(objSysDefaValNameEN: clsSysDefaValNameEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objSysDefaValNameEN.defaValNameId === null || objSysDefaValNameEN.defaValNameId === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(sysDefaValName_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSysDefaValNameEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysDefaValName_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysDefaValName_ConstructorName, strThisFuncName);
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
 * @param objSysDefaValNameEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function SysDefaValName_UpdateRecordAsync(objSysDefaValNameEN: clsSysDefaValNameEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objSysDefaValNameEN.sfUpdFldSetStr === undefined || objSysDefaValNameEN.sfUpdFldSetStr === null || objSysDefaValNameEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objSysDefaValNameEN.defaValNameId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(sysDefaValName_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSysDefaValNameEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysDefaValName_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysDefaValName_ConstructorName, strThisFuncName);
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
 * @param objSysDefaValNameEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function SysDefaValName_UpdateWithConditionAsync(objSysDefaValNameEN: clsSysDefaValNameEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objSysDefaValNameEN.sfUpdFldSetStr === undefined || objSysDefaValNameEN.sfUpdFldSetStr === null || objSysDefaValNameEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objSysDefaValNameEN.defaValNameId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(sysDefaValName_Controller, strAction);
objSysDefaValNameEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objSysDefaValNameEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysDefaValName_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysDefaValName_ConstructorName, strThisFuncName);
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
export async function SysDefaValName_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(sysDefaValName_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysDefaValName_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysDefaValName_ConstructorName, strThisFuncName);
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
 * @param strDefaValNameId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function SysDefaValName_IsExist(strDefaValNameId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(sysDefaValName_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"DefaValNameId": strDefaValNameId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysDefaValName_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysDefaValName_ConstructorName, strThisFuncName);
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
 * @param strDefaValNameId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function SysDefaValName_IsExistAsync(strDefaValNameId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(sysDefaValName_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strDefaValNameId": strDefaValNameId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysDefaValName_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysDefaValName_ConstructorName, strThisFuncName);
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
export async function SysDefaValName_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(sysDefaValName_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysDefaValName_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysDefaValName_ConstructorName, strThisFuncName);
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
export async function SysDefaValName_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(sysDefaValName_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysDefaValName_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysDefaValName_ConstructorName, strThisFuncName);
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
export function SysDefaValName_GetWebApiUrl(strController: string, strAction: string): string {
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
export function SysDefaValName_CheckPropertyNew(pobjSysDefaValNameEN: clsSysDefaValNameEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjSysDefaValNameEN.defaValName) === true )
{
 throw new Error("(errid:Watl000058)字段[缺省值名称]不能为空(In SysDefaValName)!(clsSysDefaValNameBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysDefaValNameEN.sysDefaValue) === true )
{
 throw new Error("(errid:Watl000058)字段[SysDefaValue]不能为空(In SysDefaValName)!(clsSysDefaValNameBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjSysDefaValNameEN.defaValNameId) == false && GetStrLen(pobjSysDefaValNameEN.defaValNameId) > 8)
{
 throw new Error("(errid:Watl000059)字段[缺省值名称Id(defaValNameId)]的长度不能超过8(In SysDefaValName(SysDefaValName))!值:$(pobjSysDefaValNameEN.defaValNameId)(clsSysDefaValNameBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysDefaValNameEN.defaValName) == false && GetStrLen(pobjSysDefaValNameEN.defaValName) > 30)
{
 throw new Error("(errid:Watl000059)字段[缺省值名称(defaValName)]的长度不能超过30(In SysDefaValName(SysDefaValName))!值:$(pobjSysDefaValNameEN.defaValName)(clsSysDefaValNameBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysDefaValNameEN.sysDefaValue) == false && GetStrLen(pobjSysDefaValNameEN.sysDefaValue) > 100)
{
 throw new Error("(errid:Watl000059)字段[SysDefaValue(sysDefaValue)]的长度不能超过100(In SysDefaValName(SysDefaValName))!值:$(pobjSysDefaValNameEN.sysDefaValue)(clsSysDefaValNameBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjSysDefaValNameEN.defaValNameId) == false && undefined !== pobjSysDefaValNameEN.defaValNameId && tzDataType.isString(pobjSysDefaValNameEN.defaValNameId) === false)
{
 throw new Error("(errid:Watl000060)字段[缺省值名称Id(defaValNameId)]的值:[$(pobjSysDefaValNameEN.defaValNameId)], 非法，应该为字符型(In SysDefaValName(SysDefaValName))!(clsSysDefaValNameBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysDefaValNameEN.defaValName) == false && undefined !== pobjSysDefaValNameEN.defaValName && tzDataType.isString(pobjSysDefaValNameEN.defaValName) === false)
{
 throw new Error("(errid:Watl000060)字段[缺省值名称(defaValName)]的值:[$(pobjSysDefaValNameEN.defaValName)], 非法，应该为字符型(In SysDefaValName(SysDefaValName))!(clsSysDefaValNameBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysDefaValNameEN.sysDefaValue) == false && undefined !== pobjSysDefaValNameEN.sysDefaValue && tzDataType.isString(pobjSysDefaValNameEN.sysDefaValue) === false)
{
 throw new Error("(errid:Watl000060)字段[SysDefaValue(sysDefaValue)]的值:[$(pobjSysDefaValNameEN.sysDefaValue)], 非法，应该为字符型(In SysDefaValName(SysDefaValName))!(clsSysDefaValNameBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjSysDefaValNameEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function SysDefaValName_CheckProperty4Update (pobjSysDefaValNameEN: clsSysDefaValNameEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjSysDefaValNameEN.defaValNameId) == false && GetStrLen(pobjSysDefaValNameEN.defaValNameId) > 8)
{
 throw new Error("(errid:Watl000062)字段[缺省值名称Id(defaValNameId)]的长度不能超过8(In SysDefaValName(SysDefaValName))!值:$(pobjSysDefaValNameEN.defaValNameId)(clsSysDefaValNameBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysDefaValNameEN.defaValName) == false && GetStrLen(pobjSysDefaValNameEN.defaValName) > 30)
{
 throw new Error("(errid:Watl000062)字段[缺省值名称(defaValName)]的长度不能超过30(In SysDefaValName(SysDefaValName))!值:$(pobjSysDefaValNameEN.defaValName)(clsSysDefaValNameBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysDefaValNameEN.sysDefaValue) == false && GetStrLen(pobjSysDefaValNameEN.sysDefaValue) > 100)
{
 throw new Error("(errid:Watl000062)字段[SysDefaValue(sysDefaValue)]的长度不能超过100(In SysDefaValName(SysDefaValName))!值:$(pobjSysDefaValNameEN.sysDefaValue)(clsSysDefaValNameBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjSysDefaValNameEN.defaValNameId) == false && undefined !== pobjSysDefaValNameEN.defaValNameId && tzDataType.isString(pobjSysDefaValNameEN.defaValNameId) === false)
{
 throw new Error("(errid:Watl000063)字段[缺省值名称Id(defaValNameId)]的值:[$(pobjSysDefaValNameEN.defaValNameId)], 非法，应该为字符型(In SysDefaValName(SysDefaValName))!(clsSysDefaValNameBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysDefaValNameEN.defaValName) == false && undefined !== pobjSysDefaValNameEN.defaValName && tzDataType.isString(pobjSysDefaValNameEN.defaValName) === false)
{
 throw new Error("(errid:Watl000063)字段[缺省值名称(defaValName)]的值:[$(pobjSysDefaValNameEN.defaValName)], 非法，应该为字符型(In SysDefaValName(SysDefaValName))!(clsSysDefaValNameBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysDefaValNameEN.sysDefaValue) == false && undefined !== pobjSysDefaValNameEN.sysDefaValue && tzDataType.isString(pobjSysDefaValNameEN.sysDefaValue) === false)
{
 throw new Error("(errid:Watl000063)字段[SysDefaValue(sysDefaValue)]的值:[$(pobjSysDefaValNameEN.sysDefaValue)], 非法，应该为字符型(In SysDefaValName(SysDefaValName))!(clsSysDefaValNameBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (IsNullOrEmpty(pobjSysDefaValNameEN.defaValNameId) === true )
{
 throw new Error("(errid:Watl000064)字段[缺省值名称Id]不能为空(In SysDefaValName)!(clsSysDefaValNameBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjSysDefaValNameEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function SysDefaValName_GetJSONStrByObj (pobjSysDefaValNameEN: clsSysDefaValNameEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjSysDefaValNameEN.sfUpdFldSetStr = pobjSysDefaValNameEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjSysDefaValNameEN);
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
export function SysDefaValName_GetObjLstByJSONStr (strJSON: string): Array<clsSysDefaValNameEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrSysDefaValNameObjLst = new Array<clsSysDefaValNameEN>();
if (strJSON === "")
{
return arrSysDefaValNameObjLst;
}
try
{
arrSysDefaValNameObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrSysDefaValNameObjLst;
}
return arrSysDefaValNameObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrSysDefaValNameObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function SysDefaValName_GetObjLstByJSONObjLst (arrSysDefaValNameObjLstS: Array<clsSysDefaValNameEN>): Array<clsSysDefaValNameEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrSysDefaValNameObjLst = new Array<clsSysDefaValNameEN>();
for (const objInFor of arrSysDefaValNameObjLstS) {
const obj1 = SysDefaValName_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrSysDefaValNameObjLst.push(obj1);
}
return arrSysDefaValNameObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function SysDefaValName_GetObjByJSONStr (strJSON: string): clsSysDefaValNameEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjSysDefaValNameEN = new clsSysDefaValNameEN();
if (strJSON === "")
{
return pobjSysDefaValNameEN;
}
try
{
pobjSysDefaValNameEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjSysDefaValNameEN;
}
return pobjSysDefaValNameEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function SysDefaValName_GetCombineCondition(objSysDefaValName_Cond: clsSysDefaValNameEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objSysDefaValName_Cond.dicFldComparisonOp, clsSysDefaValNameEN.con_DefaValNameId) == true)
{
const strComparisonOp_DefaValNameId:string = objSysDefaValName_Cond.dicFldComparisonOp[clsSysDefaValNameEN.con_DefaValNameId];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysDefaValNameEN.con_DefaValNameId, objSysDefaValName_Cond.defaValNameId, strComparisonOp_DefaValNameId);
}
if (Object.prototype.hasOwnProperty.call(objSysDefaValName_Cond.dicFldComparisonOp, clsSysDefaValNameEN.con_DefaValName) == true)
{
const strComparisonOp_DefaValName:string = objSysDefaValName_Cond.dicFldComparisonOp[clsSysDefaValNameEN.con_DefaValName];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysDefaValNameEN.con_DefaValName, objSysDefaValName_Cond.defaValName, strComparisonOp_DefaValName);
}
if (Object.prototype.hasOwnProperty.call(objSysDefaValName_Cond.dicFldComparisonOp, clsSysDefaValNameEN.con_SysDefaValue) == true)
{
const strComparisonOp_SysDefaValue:string = objSysDefaValName_Cond.dicFldComparisonOp[clsSysDefaValNameEN.con_SysDefaValue];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysDefaValNameEN.con_SysDefaValue, objSysDefaValName_Cond.sysDefaValue, strComparisonOp_SysDefaValue);
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objSysDefaValNameENS:源对象
 * @param objSysDefaValNameENT:目标对象
*/
export function SysDefaValName_CopyObjTo(objSysDefaValNameENS: clsSysDefaValNameEN , objSysDefaValNameENT: clsSysDefaValNameEN ): void 
{
objSysDefaValNameENT.defaValNameId = objSysDefaValNameENS.defaValNameId; //缺省值名称Id
objSysDefaValNameENT.defaValName = objSysDefaValNameENS.defaValName; //缺省值名称
objSysDefaValNameENT.sysDefaValue = objSysDefaValNameENS.sysDefaValue; //SysDefaValue
objSysDefaValNameENT.sfUpdFldSetStr = objSysDefaValNameENS.updFldString; //sfUpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objSysDefaValNameENS:源对象
 * @param objSysDefaValNameENT:目标对象
*/
export function SysDefaValName_GetObjFromJsonObj(objSysDefaValNameENS: clsSysDefaValNameEN): clsSysDefaValNameEN 
{
 const objSysDefaValNameENT: clsSysDefaValNameEN = new clsSysDefaValNameEN();
ObjectAssign(objSysDefaValNameENT, objSysDefaValNameENS);
 return objSysDefaValNameENT;
}