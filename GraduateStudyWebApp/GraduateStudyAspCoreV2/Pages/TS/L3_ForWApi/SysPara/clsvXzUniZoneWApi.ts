
 /**
 * 类名:clsvXzUniZoneWApi
 * 表名:vXzUniZone(01120332)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:45:36
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
 * v校区(vXzUniZone)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2023年03月13日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { enumComparisonOp } from "../../PubFun/enumComparisonOp.js";
import { clsvXzUniZoneEN } from "../../L0_Entity/SysPara/clsvXzUniZoneEN.js";
import { BindDdl_ObjLstInDiv_V, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const vXzUniZone_Controller = "vXzUniZoneApi";
 export const vXzUniZone_ConstructorName = "vXzUniZone";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strid_UniZone:关键字
 * @returns 对象
 **/
export async function vXzUniZone_GetObjByid_UniZoneAsync(strid_UniZone: string): Promise<clsvXzUniZoneEN|null>  
{
const strThisFuncName = "GetObjByid_UniZoneAsync";

if (IsNullOrEmpty(strid_UniZone) == true)
{
  const strMsg = Format("参数:[strid_UniZone]不能为空！(In clsvXzUniZoneWApi.GetObjByid_UniZoneAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_UniZone.length != 4)
{
const strMsg = Format("缓存分类变量:[strid_UniZone]的长度:[{0}]不正确！(clsvXzUniZoneWApi.GetObjByid_UniZoneAsync)", strid_UniZone.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByid_UniZone";
const strUrl = GetWebApiUrl(vXzUniZone_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strid_UniZone": strid_UniZone,
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
const objvXzUniZone = vXzUniZone_GetObjFromJsonObj(returnObj);
return objvXzUniZone;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzUniZone_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzUniZone_ConstructorName, strThisFuncName);
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

/**
 * 排序函数。根据关键字字段的值进行比较
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
 * @param a:比较的第1个对象
 * @param  b:比较的第1个对象
 * @returns 返回两个对象比较的结果
*/
export function vXzUniZone_SortFun_Defa(a:clsvXzUniZoneEN , b:clsvXzUniZoneEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.id_UniZone.localeCompare(b.id_UniZone);
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
export function vXzUniZone_SortFun_Defa_2Fld(a:clsvXzUniZoneEN , b:clsvXzUniZoneEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.uniZoneID == b.uniZoneID) return a.uniZoneDesc.localeCompare(b.uniZoneDesc);
else return a.uniZoneID.localeCompare(b.uniZoneID);
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
export function vXzUniZone_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsvXzUniZoneEN.con_id_UniZone:
return (a: clsvXzUniZoneEN, b: clsvXzUniZoneEN) => {
return a.id_UniZone.localeCompare(b.id_UniZone);
}
case clsvXzUniZoneEN.con_UniZoneID:
return (a: clsvXzUniZoneEN, b: clsvXzUniZoneEN) => {
return a.uniZoneID.localeCompare(b.uniZoneID);
}
case clsvXzUniZoneEN.con_UniZoneDesc:
return (a: clsvXzUniZoneEN, b: clsvXzUniZoneEN) => {
return a.uniZoneDesc.localeCompare(b.uniZoneDesc);
}
case clsvXzUniZoneEN.con_UniZoneDescA:
return (a: clsvXzUniZoneEN, b: clsvXzUniZoneEN) => {
if (a.uniZoneDescA == null) return -1;
if (b.uniZoneDescA == null) return 1;
return a.uniZoneDescA.localeCompare(b.uniZoneDescA);
}
case clsvXzUniZoneEN.con_id_School:
return (a: clsvXzUniZoneEN, b: clsvXzUniZoneEN) => {
if (a.id_School == null) return -1;
if (b.id_School == null) return 1;
return a.id_School.localeCompare(b.id_School);
}
case clsvXzUniZoneEN.con_SchoolId:
return (a: clsvXzUniZoneEN, b: clsvXzUniZoneEN) => {
if (a.schoolId == null) return -1;
if (b.schoolId == null) return 1;
return a.schoolId.localeCompare(b.schoolId);
}
case clsvXzUniZoneEN.con_SchoolName:
return (a: clsvXzUniZoneEN, b: clsvXzUniZoneEN) => {
if (a.schoolName == null) return -1;
if (b.schoolName == null) return 1;
return a.schoolName.localeCompare(b.schoolName);
}
case clsvXzUniZoneEN.con_SchoolNameA:
return (a: clsvXzUniZoneEN, b: clsvXzUniZoneEN) => {
if (a.schoolNameA == null) return -1;
if (b.schoolNameA == null) return 1;
return a.schoolNameA.localeCompare(b.schoolNameA);
}
case clsvXzUniZoneEN.con_id_Uni:
return (a: clsvXzUniZoneEN, b: clsvXzUniZoneEN) => {
if (a.id_Uni == null) return -1;
if (b.id_Uni == null) return 1;
return a.id_Uni.localeCompare(b.id_Uni);
}
case clsvXzUniZoneEN.con_ModifyDate:
return (a: clsvXzUniZoneEN, b: clsvXzUniZoneEN) => {
if (a.modifyDate == null) return -1;
if (b.modifyDate == null) return 1;
return a.modifyDate.localeCompare(b.modifyDate);
}
case clsvXzUniZoneEN.con_ModifyUserID:
return (a: clsvXzUniZoneEN, b: clsvXzUniZoneEN) => {
if (a.modifyUserID == null) return -1;
if (b.modifyUserID == null) return 1;
return a.modifyUserID.localeCompare(b.modifyUserID);
}
case clsvXzUniZoneEN.con_Memo:
return (a: clsvXzUniZoneEN, b: clsvXzUniZoneEN) => {
if (a.memo == null) return -1;
if (b.memo == null) return 1;
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vXzUniZone]中不存在！(in ${ vXzUniZone_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsvXzUniZoneEN.con_id_UniZone:
return (a: clsvXzUniZoneEN, b: clsvXzUniZoneEN) => {
return b.id_UniZone.localeCompare(a.id_UniZone);
}
case clsvXzUniZoneEN.con_UniZoneID:
return (a: clsvXzUniZoneEN, b: clsvXzUniZoneEN) => {
return b.uniZoneID.localeCompare(a.uniZoneID);
}
case clsvXzUniZoneEN.con_UniZoneDesc:
return (a: clsvXzUniZoneEN, b: clsvXzUniZoneEN) => {
return b.uniZoneDesc.localeCompare(a.uniZoneDesc);
}
case clsvXzUniZoneEN.con_UniZoneDescA:
return (a: clsvXzUniZoneEN, b: clsvXzUniZoneEN) => {
if (b.uniZoneDescA == null) return -1;
if (a.uniZoneDescA == null) return 1;
return b.uniZoneDescA.localeCompare(a.uniZoneDescA);
}
case clsvXzUniZoneEN.con_id_School:
return (a: clsvXzUniZoneEN, b: clsvXzUniZoneEN) => {
if (b.id_School == null) return -1;
if (a.id_School == null) return 1;
return b.id_School.localeCompare(a.id_School);
}
case clsvXzUniZoneEN.con_SchoolId:
return (a: clsvXzUniZoneEN, b: clsvXzUniZoneEN) => {
if (b.schoolId == null) return -1;
if (a.schoolId == null) return 1;
return b.schoolId.localeCompare(a.schoolId);
}
case clsvXzUniZoneEN.con_SchoolName:
return (a: clsvXzUniZoneEN, b: clsvXzUniZoneEN) => {
if (b.schoolName == null) return -1;
if (a.schoolName == null) return 1;
return b.schoolName.localeCompare(a.schoolName);
}
case clsvXzUniZoneEN.con_SchoolNameA:
return (a: clsvXzUniZoneEN, b: clsvXzUniZoneEN) => {
if (b.schoolNameA == null) return -1;
if (a.schoolNameA == null) return 1;
return b.schoolNameA.localeCompare(a.schoolNameA);
}
case clsvXzUniZoneEN.con_id_Uni:
return (a: clsvXzUniZoneEN, b: clsvXzUniZoneEN) => {
if (b.id_Uni == null) return -1;
if (a.id_Uni == null) return 1;
return b.id_Uni.localeCompare(a.id_Uni);
}
case clsvXzUniZoneEN.con_ModifyDate:
return (a: clsvXzUniZoneEN, b: clsvXzUniZoneEN) => {
if (b.modifyDate == null) return -1;
if (a.modifyDate == null) return 1;
return b.modifyDate.localeCompare(a.modifyDate);
}
case clsvXzUniZoneEN.con_ModifyUserID:
return (a: clsvXzUniZoneEN, b: clsvXzUniZoneEN) => {
if (b.modifyUserID == null) return -1;
if (a.modifyUserID == null) return 1;
return b.modifyUserID.localeCompare(a.modifyUserID);
}
case clsvXzUniZoneEN.con_Memo:
return (a: clsvXzUniZoneEN, b: clsvXzUniZoneEN) => {
if (b.memo == null) return -1;
if (a.memo == null) return 1;
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vXzUniZone]中不存在！(in ${ vXzUniZone_ConstructorName}.${ strThisFuncName})`;
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
export async function vXzUniZone_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsvXzUniZoneEN.con_id_UniZone:
return (obj: clsvXzUniZoneEN) => {
return obj.id_UniZone === value;
}
case clsvXzUniZoneEN.con_UniZoneID:
return (obj: clsvXzUniZoneEN) => {
return obj.uniZoneID === value;
}
case clsvXzUniZoneEN.con_UniZoneDesc:
return (obj: clsvXzUniZoneEN) => {
return obj.uniZoneDesc === value;
}
case clsvXzUniZoneEN.con_UniZoneDescA:
return (obj: clsvXzUniZoneEN) => {
return obj.uniZoneDescA === value;
}
case clsvXzUniZoneEN.con_id_School:
return (obj: clsvXzUniZoneEN) => {
return obj.id_School === value;
}
case clsvXzUniZoneEN.con_SchoolId:
return (obj: clsvXzUniZoneEN) => {
return obj.schoolId === value;
}
case clsvXzUniZoneEN.con_SchoolName:
return (obj: clsvXzUniZoneEN) => {
return obj.schoolName === value;
}
case clsvXzUniZoneEN.con_SchoolNameA:
return (obj: clsvXzUniZoneEN) => {
return obj.schoolNameA === value;
}
case clsvXzUniZoneEN.con_id_Uni:
return (obj: clsvXzUniZoneEN) => {
return obj.id_Uni === value;
}
case clsvXzUniZoneEN.con_ModifyDate:
return (obj: clsvXzUniZoneEN) => {
return obj.modifyDate === value;
}
case clsvXzUniZoneEN.con_ModifyUserID:
return (obj: clsvXzUniZoneEN) => {
return obj.modifyUserID === value;
}
case clsvXzUniZoneEN.con_Memo:
return (obj: clsvXzUniZoneEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vXzUniZone]中不存在！(in ${ vXzUniZone_ConstructorName}.${ strThisFuncName})`;
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
export async function vXzUniZone_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vXzUniZone_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzUniZone_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzUniZone_ConstructorName, strThisFuncName);
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
export async function vXzUniZone_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vXzUniZone_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzUniZone_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzUniZone_ConstructorName, strThisFuncName);
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
export async function vXzUniZone_GetFirstObjAsync(strWhereCond: string): Promise<clsvXzUniZoneEN|null>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(vXzUniZone_Controller, strAction);
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
const objvXzUniZone = vXzUniZone_GetObjFromJsonObj(returnObj);
return objvXzUniZone;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzUniZone_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzUniZone_ConstructorName, strThisFuncName);
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
export async function vXzUniZone_GetObjLstAsync(strWhereCond: string): Promise<Array<clsvXzUniZoneEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(vXzUniZone_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vXzUniZone_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vXzUniZone_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzUniZone_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzUniZone_ConstructorName, strThisFuncName);
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
 * @param arrid_UniZone:关键字列表
 * @returns 对象列表
 **/
export async function vXzUniZone_GetObjLstByid_UniZoneLstAsync(arrid_UniZone: Array<string>): Promise<Array<clsvXzUniZoneEN>>  
{
const strThisFuncName = "GetObjLstByid_UniZoneLstAsync";
const strAction = "GetObjLstByid_UniZoneLst";
const strUrl = GetWebApiUrl(vXzUniZone_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrid_UniZone);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vXzUniZone_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vXzUniZone_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzUniZone_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzUniZone_ConstructorName, strThisFuncName);
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
export async function vXzUniZone_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsvXzUniZoneEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(vXzUniZone_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vXzUniZone_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vXzUniZone_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzUniZone_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzUniZone_ConstructorName, strThisFuncName);
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
export async function vXzUniZone_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsvXzUniZoneEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vXzUniZone_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vXzUniZone_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vXzUniZone_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzUniZone_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzUniZone_ConstructorName, strThisFuncName);
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
export async function vXzUniZone_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vXzUniZone_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzUniZone_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzUniZone_ConstructorName, strThisFuncName);
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
export async function vXzUniZone_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsvXzUniZoneEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
if (objPagerPara.pageIndex == 0) return new Array<clsvXzUniZoneEN>();
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(vXzUniZone_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vXzUniZone_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vXzUniZone_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzUniZone_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzUniZone_ConstructorName, strThisFuncName);
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
export async function vXzUniZone_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(vXzUniZone_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzUniZone_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzUniZone_ConstructorName, strThisFuncName);
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
 * @param strid_UniZone:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function vXzUniZone_IsExist(strid_UniZone: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vXzUniZone_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"id_UniZone": strid_UniZone,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzUniZone_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzUniZone_ConstructorName, strThisFuncName);
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
 * @param strid_UniZone:关键字
 * @returns 是否存在?存在返回True
 **/
export async function vXzUniZone_IsExistAsync(strid_UniZone: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vXzUniZone_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strid_UniZone": strid_UniZone }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzUniZone_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzUniZone_ConstructorName, strThisFuncName);
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
export async function vXzUniZone_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(vXzUniZone_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzUniZone_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzUniZone_ConstructorName, strThisFuncName);
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
 * 获取WebApi的地址
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
 * @returns 返回当前文件中Web服务的地址
*/
export function vXzUniZone_GetWebApiUrl(strController: string, strAction: string): string {
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

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vXzUniZone_GetJSONStrByObj (pobjvXzUniZoneEN: clsvXzUniZoneEN): string
{
const strThisFuncName = "GetJSONStrByObj";
let strJson = "";
try
{
strJson = JSON.stringify(pobjvXzUniZoneEN);
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
export function vXzUniZone_GetObjLstByJSONStr (strJSON: string): Array<clsvXzUniZoneEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrvXzUniZoneObjLst = new Array<clsvXzUniZoneEN>();
if (strJSON === "")
{
return arrvXzUniZoneObjLst;
}
try
{
arrvXzUniZoneObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvXzUniZoneObjLst;
}
return arrvXzUniZoneObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrvXzUniZoneObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function vXzUniZone_GetObjLstByJSONObjLst (arrvXzUniZoneObjLstS: Array<clsvXzUniZoneEN>): Array<clsvXzUniZoneEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrvXzUniZoneObjLst = new Array<clsvXzUniZoneEN>();
for (const objInFor of arrvXzUniZoneObjLstS) {
const obj1 = vXzUniZone_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrvXzUniZoneObjLst.push(obj1);
}
return arrvXzUniZoneObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vXzUniZone_GetObjByJSONStr (strJSON: string): clsvXzUniZoneEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjvXzUniZoneEN = new clsvXzUniZoneEN();
if (strJSON === "")
{
return pobjvXzUniZoneEN;
}
try
{
pobjvXzUniZoneEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvXzUniZoneEN;
}
return pobjvXzUniZoneEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function vXzUniZone_GetCombineCondition(objvXzUniZone_Cond: clsvXzUniZoneEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objvXzUniZone_Cond.dicFldComparisonOp, clsvXzUniZoneEN.con_id_UniZone) == true)
{
const strComparisonOp_id_UniZone:string = objvXzUniZone_Cond.dicFldComparisonOp[clsvXzUniZoneEN.con_id_UniZone];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzUniZoneEN.con_id_UniZone, objvXzUniZone_Cond.id_UniZone, strComparisonOp_id_UniZone);
}
if (Object.prototype.hasOwnProperty.call(objvXzUniZone_Cond.dicFldComparisonOp, clsvXzUniZoneEN.con_UniZoneID) == true)
{
const strComparisonOp_UniZoneID:string = objvXzUniZone_Cond.dicFldComparisonOp[clsvXzUniZoneEN.con_UniZoneID];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzUniZoneEN.con_UniZoneID, objvXzUniZone_Cond.uniZoneID, strComparisonOp_UniZoneID);
}
if (Object.prototype.hasOwnProperty.call(objvXzUniZone_Cond.dicFldComparisonOp, clsvXzUniZoneEN.con_UniZoneDesc) == true)
{
const strComparisonOp_UniZoneDesc:string = objvXzUniZone_Cond.dicFldComparisonOp[clsvXzUniZoneEN.con_UniZoneDesc];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzUniZoneEN.con_UniZoneDesc, objvXzUniZone_Cond.uniZoneDesc, strComparisonOp_UniZoneDesc);
}
if (Object.prototype.hasOwnProperty.call(objvXzUniZone_Cond.dicFldComparisonOp, clsvXzUniZoneEN.con_UniZoneDescA) == true)
{
const strComparisonOp_UniZoneDescA:string = objvXzUniZone_Cond.dicFldComparisonOp[clsvXzUniZoneEN.con_UniZoneDescA];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzUniZoneEN.con_UniZoneDescA, objvXzUniZone_Cond.uniZoneDescA, strComparisonOp_UniZoneDescA);
}
if (Object.prototype.hasOwnProperty.call(objvXzUniZone_Cond.dicFldComparisonOp, clsvXzUniZoneEN.con_id_School) == true)
{
const strComparisonOp_id_School:string = objvXzUniZone_Cond.dicFldComparisonOp[clsvXzUniZoneEN.con_id_School];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzUniZoneEN.con_id_School, objvXzUniZone_Cond.id_School, strComparisonOp_id_School);
}
if (Object.prototype.hasOwnProperty.call(objvXzUniZone_Cond.dicFldComparisonOp, clsvXzUniZoneEN.con_SchoolId) == true)
{
const strComparisonOp_SchoolId:string = objvXzUniZone_Cond.dicFldComparisonOp[clsvXzUniZoneEN.con_SchoolId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzUniZoneEN.con_SchoolId, objvXzUniZone_Cond.schoolId, strComparisonOp_SchoolId);
}
if (Object.prototype.hasOwnProperty.call(objvXzUniZone_Cond.dicFldComparisonOp, clsvXzUniZoneEN.con_SchoolName) == true)
{
const strComparisonOp_SchoolName:string = objvXzUniZone_Cond.dicFldComparisonOp[clsvXzUniZoneEN.con_SchoolName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzUniZoneEN.con_SchoolName, objvXzUniZone_Cond.schoolName, strComparisonOp_SchoolName);
}
if (Object.prototype.hasOwnProperty.call(objvXzUniZone_Cond.dicFldComparisonOp, clsvXzUniZoneEN.con_SchoolNameA) == true)
{
const strComparisonOp_SchoolNameA:string = objvXzUniZone_Cond.dicFldComparisonOp[clsvXzUniZoneEN.con_SchoolNameA];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzUniZoneEN.con_SchoolNameA, objvXzUniZone_Cond.schoolNameA, strComparisonOp_SchoolNameA);
}
if (Object.prototype.hasOwnProperty.call(objvXzUniZone_Cond.dicFldComparisonOp, clsvXzUniZoneEN.con_id_Uni) == true)
{
const strComparisonOp_id_Uni:string = objvXzUniZone_Cond.dicFldComparisonOp[clsvXzUniZoneEN.con_id_Uni];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzUniZoneEN.con_id_Uni, objvXzUniZone_Cond.id_Uni, strComparisonOp_id_Uni);
}
if (Object.prototype.hasOwnProperty.call(objvXzUniZone_Cond.dicFldComparisonOp, clsvXzUniZoneEN.con_ModifyDate) == true)
{
const strComparisonOp_ModifyDate:string = objvXzUniZone_Cond.dicFldComparisonOp[clsvXzUniZoneEN.con_ModifyDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzUniZoneEN.con_ModifyDate, objvXzUniZone_Cond.modifyDate, strComparisonOp_ModifyDate);
}
if (Object.prototype.hasOwnProperty.call(objvXzUniZone_Cond.dicFldComparisonOp, clsvXzUniZoneEN.con_ModifyUserID) == true)
{
const strComparisonOp_ModifyUserID:string = objvXzUniZone_Cond.dicFldComparisonOp[clsvXzUniZoneEN.con_ModifyUserID];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzUniZoneEN.con_ModifyUserID, objvXzUniZone_Cond.modifyUserID, strComparisonOp_ModifyUserID);
}
if (Object.prototype.hasOwnProperty.call(objvXzUniZone_Cond.dicFldComparisonOp, clsvXzUniZoneEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objvXzUniZone_Cond.dicFldComparisonOp[clsvXzUniZoneEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzUniZoneEN.con_Memo, objvXzUniZone_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objvXzUniZoneENS:源对象
 * @param objvXzUniZoneENT:目标对象
*/
export function vXzUniZone_CopyObjTo(objvXzUniZoneENS: clsvXzUniZoneEN , objvXzUniZoneENT: clsvXzUniZoneEN ): void 
{
objvXzUniZoneENT.id_UniZone = objvXzUniZoneENS.id_UniZone; //校区流水号
objvXzUniZoneENT.uniZoneID = objvXzUniZoneENS.uniZoneID; //校区编号
objvXzUniZoneENT.uniZoneDesc = objvXzUniZoneENS.uniZoneDesc; //校区名称
objvXzUniZoneENT.uniZoneDescA = objvXzUniZoneENS.uniZoneDescA; //UniZoneDescA
objvXzUniZoneENT.id_School = objvXzUniZoneENS.id_School; //学校流水号
objvXzUniZoneENT.schoolId = objvXzUniZoneENS.schoolId; //学校编号
objvXzUniZoneENT.schoolName = objvXzUniZoneENS.schoolName; //学校名称
objvXzUniZoneENT.schoolNameA = objvXzUniZoneENS.schoolNameA; //学校简称
objvXzUniZoneENT.id_Uni = objvXzUniZoneENS.id_Uni; //id_Uni
objvXzUniZoneENT.modifyDate = objvXzUniZoneENS.modifyDate; //修改日期
objvXzUniZoneENT.modifyUserID = objvXzUniZoneENS.modifyUserID; //修改人
objvXzUniZoneENT.memo = objvXzUniZoneENS.memo; //备注
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objvXzUniZoneENS:源对象
 * @param objvXzUniZoneENT:目标对象
*/
export function vXzUniZone_GetObjFromJsonObj(objvXzUniZoneENS: clsvXzUniZoneEN): clsvXzUniZoneEN 
{
 const objvXzUniZoneENT: clsvXzUniZoneEN = new clsvXzUniZoneEN();
ObjectAssign(objvXzUniZoneENT, objvXzUniZoneENS);
 return objvXzUniZoneENT;
}