
 /**
 * 类名:clsSysVoteWApi
 * 表名:SysVote(01120639)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:46:10
 * 生成者:pyf
 * 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
 * 框架-层名:WA_访问层(TS)(WA_Access)
 * 编程语言:TypeScript
 * 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
   *      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 **/

/**
 * 系统点赞表(SysVote)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { clsSysVoteEN } from "../../L0_Entity/InteractManage/clsSysVoteEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { tzDataType } from "../../PubFun/jsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const sysVote_Controller = "SysVoteApi";
 export const sysVote_ConstructorName = "sysVote";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngVoteId:关键字
 * @returns 对象
 **/
export async function SysVote_GetObjByVoteIdAsync(lngVoteId: number): Promise<clsSysVoteEN>  
{
const strThisFuncName = "GetObjByVoteIdAsync";

if (lngVoteId == 0)
{
  const strMsg = Format("参数:[lngVoteId]不能为空！(In GetObjByVoteIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjByVoteId";
const strUrl = GetWebApiUrl(sysVote_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"lngVoteId": lngVoteId,
}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObj = data.returnObj;
if (returnObj == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sysVote_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objSysVote = SysVote_GetObjFromJsonObj(returnObj);
return objSysVote;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
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
export function SysVote_SortFun_Defa(a:clsSysVoteEN , b:clsSysVoteEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.voteId-b.voteId;
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
export function SysVote_SortFun_Defa_2Fld(a:clsSysVoteEN , b:clsSysVoteEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.tableKey == b.tableKey) return a.pubParentId.localeCompare(b.pubParentId);
else return a.tableKey.localeCompare(b.tableKey);
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
export function SysVote_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsSysVoteEN.con_VoteId:
return (a: clsSysVoteEN, b: clsSysVoteEN) => {
return a.voteId-b.voteId;
}
case clsSysVoteEN.con_TableKey:
return (a: clsSysVoteEN, b: clsSysVoteEN) => {
return a.tableKey.localeCompare(b.tableKey);
}
case clsSysVoteEN.con_PubParentId:
return (a: clsSysVoteEN, b: clsSysVoteEN) => {
return a.pubParentId.localeCompare(b.pubParentId);
}
case clsSysVoteEN.con_VoteTypeId:
return (a: clsSysVoteEN, b: clsSysVoteEN) => {
return a.voteTypeId.localeCompare(b.voteTypeId);
}
case clsSysVoteEN.con_UpdUser:
return (a: clsSysVoteEN, b: clsSysVoteEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsSysVoteEN.con_UpdDate:
return (a: clsSysVoteEN, b: clsSysVoteEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsSysVoteEN.con_Memo:
return (a: clsSysVoteEN, b: clsSysVoteEN) => {
return a.memo.localeCompare(b.memo);
}
case clsSysVoteEN.con_id_CurrEduCls:
return (a: clsSysVoteEN, b: clsSysVoteEN) => {
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
case clsSysVoteEN.con_UserId:
return (a: clsSysVoteEN, b: clsSysVoteEN) => {
return a.userId.localeCompare(b.userId);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[SysVote]中不存在！(in ${ sysVote_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsSysVoteEN.con_VoteId:
return (a: clsSysVoteEN, b: clsSysVoteEN) => {
return b.voteId-a.voteId;
}
case clsSysVoteEN.con_TableKey:
return (a: clsSysVoteEN, b: clsSysVoteEN) => {
return b.tableKey.localeCompare(a.tableKey);
}
case clsSysVoteEN.con_PubParentId:
return (a: clsSysVoteEN, b: clsSysVoteEN) => {
return b.pubParentId.localeCompare(a.pubParentId);
}
case clsSysVoteEN.con_VoteTypeId:
return (a: clsSysVoteEN, b: clsSysVoteEN) => {
return b.voteTypeId.localeCompare(a.voteTypeId);
}
case clsSysVoteEN.con_UpdUser:
return (a: clsSysVoteEN, b: clsSysVoteEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsSysVoteEN.con_UpdDate:
return (a: clsSysVoteEN, b: clsSysVoteEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsSysVoteEN.con_Memo:
return (a: clsSysVoteEN, b: clsSysVoteEN) => {
return b.memo.localeCompare(a.memo);
}
case clsSysVoteEN.con_id_CurrEduCls:
return (a: clsSysVoteEN, b: clsSysVoteEN) => {
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
case clsSysVoteEN.con_UserId:
return (a: clsSysVoteEN, b: clsSysVoteEN) => {
return b.userId.localeCompare(a.userId);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[SysVote]中不存在！(in ${ sysVote_ConstructorName}.${ strThisFuncName})`;
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
export async function SysVote_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsSysVoteEN.con_VoteId:
return (obj: clsSysVoteEN) => {
return obj.voteId === value;
}
case clsSysVoteEN.con_TableKey:
return (obj: clsSysVoteEN) => {
return obj.tableKey === value;
}
case clsSysVoteEN.con_PubParentId:
return (obj: clsSysVoteEN) => {
return obj.pubParentId === value;
}
case clsSysVoteEN.con_VoteTypeId:
return (obj: clsSysVoteEN) => {
return obj.voteTypeId === value;
}
case clsSysVoteEN.con_UpdUser:
return (obj: clsSysVoteEN) => {
return obj.updUser === value;
}
case clsSysVoteEN.con_UpdDate:
return (obj: clsSysVoteEN) => {
return obj.updDate === value;
}
case clsSysVoteEN.con_Memo:
return (obj: clsSysVoteEN) => {
return obj.memo === value;
}
case clsSysVoteEN.con_id_CurrEduCls:
return (obj: clsSysVoteEN) => {
return obj.id_CurrEduCls === value;
}
case clsSysVoteEN.con_UserId:
return (obj: clsSysVoteEN) => {
return obj.userId === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[SysVote]中不存在！(in ${ sysVote_ConstructorName}.${ strThisFuncName})`;
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
export async function SysVote_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(sysVote_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
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
export async function SysVote_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(sysVote_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
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
export async function SysVote_GetFirstObjAsync(strWhereCond: string): Promise<clsSysVoteEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(sysVote_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sysVote_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objSysVote = SysVote_GetObjFromJsonObj(returnObj);
return objSysVote;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
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
export async function SysVote_GetObjLstAsync(strWhereCond: string): Promise<Array<clsSysVoteEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(sysVote_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sysVote_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = SysVote_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
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
 * @param arrVoteId:关键字列表
 * @returns 对象列表
 **/
export async function SysVote_GetObjLstByVoteIdLstAsync(arrVoteId: Array<string>): Promise<Array<clsSysVoteEN>>  
{
const strThisFuncName = "GetObjLstByVoteIdLstAsync";
const strAction = "GetObjLstByVoteIdLst";
const strUrl = GetWebApiUrl(sysVote_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrVoteId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sysVote_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = SysVote_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
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
export async function SysVote_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsSysVoteEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(sysVote_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sysVote_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = SysVote_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
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
export async function SysVote_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsSysVoteEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(sysVote_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sysVote_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = SysVote_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
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
export async function SysVote_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(sysVote_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
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
export async function SysVote_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsSysVoteEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(sysVote_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sysVote_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = SysVote_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
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
 * @param lngVoteId:关键字
 * @returns 获取删除的结果
 **/
export async function SysVote_DelRecordAsync(lngVoteId: number): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(sysVote_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, lngVoteId);
try
{
const response = await axios.delete(strUrl,
{
params: { "Id": lngVoteId, }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
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
 * @param arrVoteId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function SysVote_DelSysVotesAsync(arrVoteId: Array<string>): Promise<number> 
{
const strThisFuncName = "DelSysVotesAsync";
const strAction = "DelSysVotes";
const strUrl = GetWebApiUrl(sysVote_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrVoteId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
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
export async function SysVote_DelSysVotesByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "DelSysVotesByCondAsync";
const strAction = "DelSysVotesByCond";
const strUrl = GetWebApiUrl(sysVote_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
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
 * @param objSysVoteEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function SysVote_AddNewRecordAsync(objSysVoteEN: clsSysVoteEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objSysVoteEN);
const strUrl = GetWebApiUrl(sysVote_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSysVoteEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
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
 * @param objSysVoteEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function SysVote_AddNewRecordWithReturnKeyAsync(objSysVoteEN: clsSysVoteEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(sysVote_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSysVoteEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
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
 * @param objSysVoteEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function SysVote_AddNewRecordWithReturnKey(objSysVoteEN: clsSysVoteEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objSysVoteEN.voteId === null || objSysVoteEN.voteId === 0)
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(sysVote_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSysVoteEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
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
 * @param objSysVoteEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function SysVote_UpdateRecordAsync(objSysVoteEN: clsSysVoteEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objSysVoteEN.sf_UpdFldSetStr === undefined || objSysVoteEN.sf_UpdFldSetStr === null || objSysVoteEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objSysVoteEN.voteId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(sysVote_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSysVoteEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
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
 * @param objSysVoteEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function SysVote_UpdateWithConditionAsync(objSysVoteEN: clsSysVoteEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objSysVoteEN.sf_UpdFldSetStr === undefined || objSysVoteEN.sf_UpdFldSetStr === null || objSysVoteEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objSysVoteEN.voteId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(sysVote_Controller, strAction);
objSysVoteEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objSysVoteEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
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
export async function SysVote_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(sysVote_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
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
 * @param lngVoteId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function SysVote_IsExist(lngVoteId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(sysVote_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"VoteId": lngVoteId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
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
 * @param lngVoteId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function SysVote_IsExistAsync(lngVoteId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(sysVote_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "lngVoteId": lngVoteId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
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
export async function SysVote_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(sysVote_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
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
export async function SysVote_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(sysVote_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
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
export function SysVote_GetWebApiUrl(strController: string, strAction: string): string {
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
export function SysVote_CheckPropertyNew(pobjSysVoteEN: clsSysVoteEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjSysVoteEN.tableKey) == false && GetStrLen(pobjSysVoteEN.tableKey) > 20)
{
 throw new Error("(errid:Watl000059)字段[表主键(tableKey)]的长度不能超过20(In 系统点赞表(SysVote))!值:$(pobjSysVoteEN.tableKey)(clsSysVoteBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysVoteEN.pubParentId) == false && GetStrLen(pobjSysVoteEN.pubParentId) > 20)
{
 throw new Error("(errid:Watl000059)字段[公共父Id(pubParentId)]的长度不能超过20(In 系统点赞表(SysVote))!值:$(pobjSysVoteEN.pubParentId)(clsSysVoteBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysVoteEN.voteTypeId) == false && GetStrLen(pobjSysVoteEN.voteTypeId) > 2)
{
 throw new Error("(errid:Watl000059)字段[点赞类型Id(voteTypeId)]的长度不能超过2(In 系统点赞表(SysVote))!值:$(pobjSysVoteEN.voteTypeId)(clsSysVoteBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysVoteEN.updUser) == false && GetStrLen(pobjSysVoteEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 系统点赞表(SysVote))!值:$(pobjSysVoteEN.updUser)(clsSysVoteBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysVoteEN.updDate) == false && GetStrLen(pobjSysVoteEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 系统点赞表(SysVote))!值:$(pobjSysVoteEN.updDate)(clsSysVoteBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysVoteEN.memo) == false && GetStrLen(pobjSysVoteEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 系统点赞表(SysVote))!值:$(pobjSysVoteEN.memo)(clsSysVoteBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysVoteEN.id_CurrEduCls) == false && GetStrLen(pobjSysVoteEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 系统点赞表(SysVote))!值:$(pobjSysVoteEN.id_CurrEduCls)(clsSysVoteBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysVoteEN.userId) == false && GetStrLen(pobjSysVoteEN.userId) > 20)
{
 throw new Error("(errid:Watl000059)字段[用户ID(userId)]的长度不能超过20(In 系统点赞表(SysVote))!值:$(pobjSysVoteEN.userId)(clsSysVoteBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null != pobjSysVoteEN.voteId && undefined !== pobjSysVoteEN.voteId && tzDataType.isNumber(pobjSysVoteEN.voteId) === false)
{
 throw new Error("(errid:Watl000060)字段[点赞Id(voteId)]的值:[$(pobjSysVoteEN.voteId)], 非法，应该为数值型(In 系统点赞表(SysVote))!(clsSysVoteBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysVoteEN.tableKey) == false && undefined !== pobjSysVoteEN.tableKey && tzDataType.isString(pobjSysVoteEN.tableKey) === false)
{
 throw new Error("(errid:Watl000060)字段[表主键(tableKey)]的值:[$(pobjSysVoteEN.tableKey)], 非法，应该为字符型(In 系统点赞表(SysVote))!(clsSysVoteBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysVoteEN.pubParentId) == false && undefined !== pobjSysVoteEN.pubParentId && tzDataType.isString(pobjSysVoteEN.pubParentId) === false)
{
 throw new Error("(errid:Watl000060)字段[公共父Id(pubParentId)]的值:[$(pobjSysVoteEN.pubParentId)], 非法，应该为字符型(In 系统点赞表(SysVote))!(clsSysVoteBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysVoteEN.voteTypeId) == false && undefined !== pobjSysVoteEN.voteTypeId && tzDataType.isString(pobjSysVoteEN.voteTypeId) === false)
{
 throw new Error("(errid:Watl000060)字段[点赞类型Id(voteTypeId)]的值:[$(pobjSysVoteEN.voteTypeId)], 非法，应该为字符型(In 系统点赞表(SysVote))!(clsSysVoteBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysVoteEN.updUser) == false && undefined !== pobjSysVoteEN.updUser && tzDataType.isString(pobjSysVoteEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjSysVoteEN.updUser)], 非法，应该为字符型(In 系统点赞表(SysVote))!(clsSysVoteBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysVoteEN.updDate) == false && undefined !== pobjSysVoteEN.updDate && tzDataType.isString(pobjSysVoteEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjSysVoteEN.updDate)], 非法，应该为字符型(In 系统点赞表(SysVote))!(clsSysVoteBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysVoteEN.memo) == false && undefined !== pobjSysVoteEN.memo && tzDataType.isString(pobjSysVoteEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjSysVoteEN.memo)], 非法，应该为字符型(In 系统点赞表(SysVote))!(clsSysVoteBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysVoteEN.id_CurrEduCls) == false && undefined !== pobjSysVoteEN.id_CurrEduCls && tzDataType.isString(pobjSysVoteEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjSysVoteEN.id_CurrEduCls)], 非法，应该为字符型(In 系统点赞表(SysVote))!(clsSysVoteBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysVoteEN.userId) == false && undefined !== pobjSysVoteEN.userId && tzDataType.isString(pobjSysVoteEN.userId) === false)
{
 throw new Error("(errid:Watl000060)字段[用户ID(userId)]的值:[$(pobjSysVoteEN.userId)], 非法，应该为字符型(In 系统点赞表(SysVote))!(clsSysVoteBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjSysVoteEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function SysVote_CheckProperty4Update (pobjSysVoteEN: clsSysVoteEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjSysVoteEN.tableKey) == false && GetStrLen(pobjSysVoteEN.tableKey) > 20)
{
 throw new Error("(errid:Watl000062)字段[表主键(tableKey)]的长度不能超过20(In 系统点赞表(SysVote))!值:$(pobjSysVoteEN.tableKey)(clsSysVoteBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysVoteEN.pubParentId) == false && GetStrLen(pobjSysVoteEN.pubParentId) > 20)
{
 throw new Error("(errid:Watl000062)字段[公共父Id(pubParentId)]的长度不能超过20(In 系统点赞表(SysVote))!值:$(pobjSysVoteEN.pubParentId)(clsSysVoteBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysVoteEN.voteTypeId) == false && GetStrLen(pobjSysVoteEN.voteTypeId) > 2)
{
 throw new Error("(errid:Watl000062)字段[点赞类型Id(voteTypeId)]的长度不能超过2(In 系统点赞表(SysVote))!值:$(pobjSysVoteEN.voteTypeId)(clsSysVoteBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysVoteEN.updUser) == false && GetStrLen(pobjSysVoteEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 系统点赞表(SysVote))!值:$(pobjSysVoteEN.updUser)(clsSysVoteBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysVoteEN.updDate) == false && GetStrLen(pobjSysVoteEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 系统点赞表(SysVote))!值:$(pobjSysVoteEN.updDate)(clsSysVoteBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysVoteEN.memo) == false && GetStrLen(pobjSysVoteEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 系统点赞表(SysVote))!值:$(pobjSysVoteEN.memo)(clsSysVoteBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysVoteEN.id_CurrEduCls) == false && GetStrLen(pobjSysVoteEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 系统点赞表(SysVote))!值:$(pobjSysVoteEN.id_CurrEduCls)(clsSysVoteBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysVoteEN.userId) == false && GetStrLen(pobjSysVoteEN.userId) > 20)
{
 throw new Error("(errid:Watl000062)字段[用户ID(userId)]的长度不能超过20(In 系统点赞表(SysVote))!值:$(pobjSysVoteEN.userId)(clsSysVoteBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null != pobjSysVoteEN.voteId && undefined !== pobjSysVoteEN.voteId && tzDataType.isNumber(pobjSysVoteEN.voteId) === false)
{
 throw new Error("(errid:Watl000063)字段[点赞Id(voteId)]的值:[$(pobjSysVoteEN.voteId)], 非法，应该为数值型(In 系统点赞表(SysVote))!(clsSysVoteBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysVoteEN.tableKey) == false && undefined !== pobjSysVoteEN.tableKey && tzDataType.isString(pobjSysVoteEN.tableKey) === false)
{
 throw new Error("(errid:Watl000063)字段[表主键(tableKey)]的值:[$(pobjSysVoteEN.tableKey)], 非法，应该为字符型(In 系统点赞表(SysVote))!(clsSysVoteBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysVoteEN.pubParentId) == false && undefined !== pobjSysVoteEN.pubParentId && tzDataType.isString(pobjSysVoteEN.pubParentId) === false)
{
 throw new Error("(errid:Watl000063)字段[公共父Id(pubParentId)]的值:[$(pobjSysVoteEN.pubParentId)], 非法，应该为字符型(In 系统点赞表(SysVote))!(clsSysVoteBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysVoteEN.voteTypeId) == false && undefined !== pobjSysVoteEN.voteTypeId && tzDataType.isString(pobjSysVoteEN.voteTypeId) === false)
{
 throw new Error("(errid:Watl000063)字段[点赞类型Id(voteTypeId)]的值:[$(pobjSysVoteEN.voteTypeId)], 非法，应该为字符型(In 系统点赞表(SysVote))!(clsSysVoteBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysVoteEN.updUser) == false && undefined !== pobjSysVoteEN.updUser && tzDataType.isString(pobjSysVoteEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjSysVoteEN.updUser)], 非法，应该为字符型(In 系统点赞表(SysVote))!(clsSysVoteBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysVoteEN.updDate) == false && undefined !== pobjSysVoteEN.updDate && tzDataType.isString(pobjSysVoteEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjSysVoteEN.updDate)], 非法，应该为字符型(In 系统点赞表(SysVote))!(clsSysVoteBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysVoteEN.memo) == false && undefined !== pobjSysVoteEN.memo && tzDataType.isString(pobjSysVoteEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjSysVoteEN.memo)], 非法，应该为字符型(In 系统点赞表(SysVote))!(clsSysVoteBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysVoteEN.id_CurrEduCls) == false && undefined !== pobjSysVoteEN.id_CurrEduCls && tzDataType.isString(pobjSysVoteEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjSysVoteEN.id_CurrEduCls)], 非法，应该为字符型(In 系统点赞表(SysVote))!(clsSysVoteBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysVoteEN.userId) == false && undefined !== pobjSysVoteEN.userId && tzDataType.isString(pobjSysVoteEN.userId) === false)
{
 throw new Error("(errid:Watl000063)字段[用户ID(userId)]的值:[$(pobjSysVoteEN.userId)], 非法，应该为字符型(In 系统点赞表(SysVote))!(clsSysVoteBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjSysVoteEN.voteId 
 || pobjSysVoteEN.voteId != null && pobjSysVoteEN.voteId.toString()  ===  "")
{
 throw new Error("(errid:Watl000064)字段[点赞Id]不能为空(In 系统点赞表)!(clsSysVoteBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjSysVoteEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function SysVote_GetJSONStrByObj (pobjSysVoteEN: clsSysVoteEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjSysVoteEN.sf_UpdFldSetStr = pobjSysVoteEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjSysVoteEN);
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
export function SysVote_GetObjLstByJSONStr (strJSON: string): Array<clsSysVoteEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrSysVoteObjLst = new Array<clsSysVoteEN>();
if (strJSON === "")
{
return arrSysVoteObjLst;
}
try
{
arrSysVoteObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrSysVoteObjLst;
}
return arrSysVoteObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrSysVoteObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function SysVote_GetObjLstByJSONObjLst (arrSysVoteObjLstS: Array<clsSysVoteEN>): Array<clsSysVoteEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrSysVoteObjLst = new Array<clsSysVoteEN>();
for (const objInFor of arrSysVoteObjLstS) {
const obj1 = SysVote_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrSysVoteObjLst.push(obj1);
}
return arrSysVoteObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function SysVote_GetObjByJSONStr (strJSON: string): clsSysVoteEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjSysVoteEN = new clsSysVoteEN();
if (strJSON === "")
{
return pobjSysVoteEN;
}
try
{
pobjSysVoteEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjSysVoteEN;
}
return pobjSysVoteEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function SysVote_GetCombineCondition(objSysVote_Cond: clsSysVoteEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objSysVote_Cond.dicFldComparisonOp, clsSysVoteEN.con_VoteId) == true)
{
const strComparisonOp_VoteId:string = objSysVote_Cond.dicFldComparisonOp[clsSysVoteEN.con_VoteId];
strWhereCond += Format(" And {0} {2} {1}", clsSysVoteEN.con_VoteId, objSysVote_Cond.voteId, strComparisonOp_VoteId);
}
if (Object.prototype.hasOwnProperty.call(objSysVote_Cond.dicFldComparisonOp, clsSysVoteEN.con_TableKey) == true)
{
const strComparisonOp_TableKey:string = objSysVote_Cond.dicFldComparisonOp[clsSysVoteEN.con_TableKey];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysVoteEN.con_TableKey, objSysVote_Cond.tableKey, strComparisonOp_TableKey);
}
if (Object.prototype.hasOwnProperty.call(objSysVote_Cond.dicFldComparisonOp, clsSysVoteEN.con_PubParentId) == true)
{
const strComparisonOp_PubParentId:string = objSysVote_Cond.dicFldComparisonOp[clsSysVoteEN.con_PubParentId];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysVoteEN.con_PubParentId, objSysVote_Cond.pubParentId, strComparisonOp_PubParentId);
}
if (Object.prototype.hasOwnProperty.call(objSysVote_Cond.dicFldComparisonOp, clsSysVoteEN.con_VoteTypeId) == true)
{
const strComparisonOp_VoteTypeId:string = objSysVote_Cond.dicFldComparisonOp[clsSysVoteEN.con_VoteTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysVoteEN.con_VoteTypeId, objSysVote_Cond.voteTypeId, strComparisonOp_VoteTypeId);
}
if (Object.prototype.hasOwnProperty.call(objSysVote_Cond.dicFldComparisonOp, clsSysVoteEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objSysVote_Cond.dicFldComparisonOp[clsSysVoteEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysVoteEN.con_UpdUser, objSysVote_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objSysVote_Cond.dicFldComparisonOp, clsSysVoteEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objSysVote_Cond.dicFldComparisonOp[clsSysVoteEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysVoteEN.con_UpdDate, objSysVote_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objSysVote_Cond.dicFldComparisonOp, clsSysVoteEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objSysVote_Cond.dicFldComparisonOp[clsSysVoteEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysVoteEN.con_Memo, objSysVote_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objSysVote_Cond.dicFldComparisonOp, clsSysVoteEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objSysVote_Cond.dicFldComparisonOp[clsSysVoteEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysVoteEN.con_id_CurrEduCls, objSysVote_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (Object.prototype.hasOwnProperty.call(objSysVote_Cond.dicFldComparisonOp, clsSysVoteEN.con_UserId) == true)
{
const strComparisonOp_UserId:string = objSysVote_Cond.dicFldComparisonOp[clsSysVoteEN.con_UserId];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysVoteEN.con_UserId, objSysVote_Cond.userId, strComparisonOp_UserId);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--SysVote(系统点赞表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param lngVoteId: 点赞Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function SysVote_GetUniCondStr_VoteId(objSysVoteEN: clsSysVoteEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and VoteId = '{0}'", objSysVoteEN.voteId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--SysVote(系统点赞表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param lngVoteId: 点赞Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function SysVote_GetUniCondStr4Update_VoteId(objSysVoteEN: clsSysVoteEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and VoteId <> '{0}'", objSysVoteEN.voteId);
 strWhereCond +=  Format(" and VoteId = '{0}'", objSysVoteEN.voteId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objSysVoteENS:源对象
 * @param objSysVoteENT:目标对象
*/
export function SysVote_CopyObjTo(objSysVoteENS: clsSysVoteEN , objSysVoteENT: clsSysVoteEN ): void 
{
objSysVoteENT.voteId = objSysVoteENS.voteId; //点赞Id
objSysVoteENT.tableKey = objSysVoteENS.tableKey; //表主键
objSysVoteENT.pubParentId = objSysVoteENS.pubParentId; //公共父Id
objSysVoteENT.voteTypeId = objSysVoteENS.voteTypeId; //点赞类型Id
objSysVoteENT.updUser = objSysVoteENS.updUser; //修改人
objSysVoteENT.updDate = objSysVoteENS.updDate; //修改日期
objSysVoteENT.memo = objSysVoteENS.memo; //备注
objSysVoteENT.id_CurrEduCls = objSysVoteENS.id_CurrEduCls; //教学班流水号
objSysVoteENT.userId = objSysVoteENS.userId; //用户ID
objSysVoteENT.sf_UpdFldSetStr = objSysVoteENS.updFldString; //sf_UpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objSysVoteENS:源对象
 * @param objSysVoteENT:目标对象
*/
export function SysVote_GetObjFromJsonObj(objSysVoteENS: clsSysVoteEN): clsSysVoteEN 
{
 const objSysVoteENT: clsSysVoteEN = new clsSysVoteEN();
ObjectAssign(objSysVoteENT, objSysVoteENS);
 return objSysVoteENT;
}