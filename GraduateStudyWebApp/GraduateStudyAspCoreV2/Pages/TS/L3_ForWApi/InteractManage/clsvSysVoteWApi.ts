
 /**
 * 类名:clsvSysVoteWApi
 * 表名:vSysVote(01120633)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:45:03
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
 * v系统点赞视图(vSysVote)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2023年03月13日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { enumComparisonOp } from "../../PubFun/enumComparisonOp.js";
import { clsvSysVoteEN } from "../../L0_Entity/InteractManage/clsvSysVoteEN.js";
import { BindDdl_ObjLstInDiv_V, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const vSysVote_Controller = "vSysVoteApi";
 export const vSysVote_ConstructorName = "vSysVote";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngVoteId:关键字
 * @returns 对象
 **/
export async function vSysVote_GetObjByVoteIdAsync(lngVoteId: number): Promise<clsvSysVoteEN|null>  
{
const strThisFuncName = "GetObjByVoteIdAsync";

if (lngVoteId == 0)
{
  const strMsg = Format("参数:[lngVoteId]不能为空！(In clsvSysVoteWApi.GetObjByVoteIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjByVoteId";
const strUrl = GetWebApiUrl(vSysVote_Controller, strAction);
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
return null;
}
//console.log(returnObj);
const objvSysVote = vSysVote_GetObjFromJsonObj(returnObj);
return objvSysVote;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysVote_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysVote_ConstructorName, strThisFuncName);
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
export function vSysVote_SortFun_Defa(a:clsvSysVoteEN , b:clsvSysVoteEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.voteId-b.voteId;
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
export function vSysVote_SortFun_Defa_2Fld(a:clsvSysVoteEN , b:clsvSysVoteEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.tableKey == b.tableKey) return a.pubParentId.localeCompare(b.pubParentId);
else return a.tableKey.localeCompare(b.tableKey);
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
export function vSysVote_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsvSysVoteEN.con_VoteId:
return (a: clsvSysVoteEN, b: clsvSysVoteEN) => {
return a.voteId-b.voteId;
}
case clsvSysVoteEN.con_TableKey:
return (a: clsvSysVoteEN, b: clsvSysVoteEN) => {
if (a.tableKey == null) return -1;
if (b.tableKey == null) return 1;
return a.tableKey.localeCompare(b.tableKey);
}
case clsvSysVoteEN.con_PubParentId:
return (a: clsvSysVoteEN, b: clsvSysVoteEN) => {
if (a.pubParentId == null) return -1;
if (b.pubParentId == null) return 1;
return a.pubParentId.localeCompare(b.pubParentId);
}
case clsvSysVoteEN.con_VoteTypeId:
return (a: clsvSysVoteEN, b: clsvSysVoteEN) => {
if (a.voteTypeId == null) return -1;
if (b.voteTypeId == null) return 1;
return a.voteTypeId.localeCompare(b.voteTypeId);
}
case clsvSysVoteEN.con_VoteTypeName:
return (a: clsvSysVoteEN, b: clsvSysVoteEN) => {
if (a.voteTypeName == null) return -1;
if (b.voteTypeName == null) return 1;
return a.voteTypeName.localeCompare(b.voteTypeName);
}
case clsvSysVoteEN.con_UpdUser:
return (a: clsvSysVoteEN, b: clsvSysVoteEN) => {
if (a.updUser == null) return -1;
if (b.updUser == null) return 1;
return a.updUser.localeCompare(b.updUser);
}
case clsvSysVoteEN.con_VoteTable:
return (a: clsvSysVoteEN, b: clsvSysVoteEN) => {
if (a.voteTable == null) return -1;
if (b.voteTable == null) return 1;
return a.voteTable.localeCompare(b.voteTable);
}
case clsvSysVoteEN.con_UpdDate:
return (a: clsvSysVoteEN, b: clsvSysVoteEN) => {
if (a.updDate == null) return -1;
if (b.updDate == null) return 1;
return a.updDate.localeCompare(b.updDate);
}
case clsvSysVoteEN.con_VoteTableId:
return (a: clsvSysVoteEN, b: clsvSysVoteEN) => {
if (a.voteTableId == null) return -1;
if (b.voteTableId == null) return 1;
return a.voteTableId.localeCompare(b.voteTableId);
}
case clsvSysVoteEN.con_Memo:
return (a: clsvSysVoteEN, b: clsvSysVoteEN) => {
if (a.memo == null) return -1;
if (b.memo == null) return 1;
return a.memo.localeCompare(b.memo);
}
case clsvSysVoteEN.con_id_CurrEduCls:
return (a: clsvSysVoteEN, b: clsvSysVoteEN) => {
if (a.id_CurrEduCls == null) return -1;
if (b.id_CurrEduCls == null) return 1;
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
case clsvSysVoteEN.con_UserId:
return (a: clsvSysVoteEN, b: clsvSysVoteEN) => {
if (a.userId == null) return -1;
if (b.userId == null) return 1;
return a.userId.localeCompare(b.userId);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vSysVote]中不存在！(in ${ vSysVote_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsvSysVoteEN.con_VoteId:
return (a: clsvSysVoteEN, b: clsvSysVoteEN) => {
return b.voteId-a.voteId;
}
case clsvSysVoteEN.con_TableKey:
return (a: clsvSysVoteEN, b: clsvSysVoteEN) => {
if (b.tableKey == null) return -1;
if (a.tableKey == null) return 1;
return b.tableKey.localeCompare(a.tableKey);
}
case clsvSysVoteEN.con_PubParentId:
return (a: clsvSysVoteEN, b: clsvSysVoteEN) => {
if (b.pubParentId == null) return -1;
if (a.pubParentId == null) return 1;
return b.pubParentId.localeCompare(a.pubParentId);
}
case clsvSysVoteEN.con_VoteTypeId:
return (a: clsvSysVoteEN, b: clsvSysVoteEN) => {
if (b.voteTypeId == null) return -1;
if (a.voteTypeId == null) return 1;
return b.voteTypeId.localeCompare(a.voteTypeId);
}
case clsvSysVoteEN.con_VoteTypeName:
return (a: clsvSysVoteEN, b: clsvSysVoteEN) => {
if (b.voteTypeName == null) return -1;
if (a.voteTypeName == null) return 1;
return b.voteTypeName.localeCompare(a.voteTypeName);
}
case clsvSysVoteEN.con_UpdUser:
return (a: clsvSysVoteEN, b: clsvSysVoteEN) => {
if (b.updUser == null) return -1;
if (a.updUser == null) return 1;
return b.updUser.localeCompare(a.updUser);
}
case clsvSysVoteEN.con_VoteTable:
return (a: clsvSysVoteEN, b: clsvSysVoteEN) => {
if (b.voteTable == null) return -1;
if (a.voteTable == null) return 1;
return b.voteTable.localeCompare(a.voteTable);
}
case clsvSysVoteEN.con_UpdDate:
return (a: clsvSysVoteEN, b: clsvSysVoteEN) => {
if (b.updDate == null) return -1;
if (a.updDate == null) return 1;
return b.updDate.localeCompare(a.updDate);
}
case clsvSysVoteEN.con_VoteTableId:
return (a: clsvSysVoteEN, b: clsvSysVoteEN) => {
if (b.voteTableId == null) return -1;
if (a.voteTableId == null) return 1;
return b.voteTableId.localeCompare(a.voteTableId);
}
case clsvSysVoteEN.con_Memo:
return (a: clsvSysVoteEN, b: clsvSysVoteEN) => {
if (b.memo == null) return -1;
if (a.memo == null) return 1;
return b.memo.localeCompare(a.memo);
}
case clsvSysVoteEN.con_id_CurrEduCls:
return (a: clsvSysVoteEN, b: clsvSysVoteEN) => {
if (b.id_CurrEduCls == null) return -1;
if (a.id_CurrEduCls == null) return 1;
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
case clsvSysVoteEN.con_UserId:
return (a: clsvSysVoteEN, b: clsvSysVoteEN) => {
if (b.userId == null) return -1;
if (a.userId == null) return 1;
return b.userId.localeCompare(a.userId);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vSysVote]中不存在！(in ${ vSysVote_ConstructorName}.${ strThisFuncName})`;
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
export async function vSysVote_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsvSysVoteEN.con_VoteId:
return (obj: clsvSysVoteEN) => {
return obj.voteId === value;
}
case clsvSysVoteEN.con_TableKey:
return (obj: clsvSysVoteEN) => {
return obj.tableKey === value;
}
case clsvSysVoteEN.con_PubParentId:
return (obj: clsvSysVoteEN) => {
return obj.pubParentId === value;
}
case clsvSysVoteEN.con_VoteTypeId:
return (obj: clsvSysVoteEN) => {
return obj.voteTypeId === value;
}
case clsvSysVoteEN.con_VoteTypeName:
return (obj: clsvSysVoteEN) => {
return obj.voteTypeName === value;
}
case clsvSysVoteEN.con_UpdUser:
return (obj: clsvSysVoteEN) => {
return obj.updUser === value;
}
case clsvSysVoteEN.con_VoteTable:
return (obj: clsvSysVoteEN) => {
return obj.voteTable === value;
}
case clsvSysVoteEN.con_UpdDate:
return (obj: clsvSysVoteEN) => {
return obj.updDate === value;
}
case clsvSysVoteEN.con_VoteTableId:
return (obj: clsvSysVoteEN) => {
return obj.voteTableId === value;
}
case clsvSysVoteEN.con_Memo:
return (obj: clsvSysVoteEN) => {
return obj.memo === value;
}
case clsvSysVoteEN.con_id_CurrEduCls:
return (obj: clsvSysVoteEN) => {
return obj.id_CurrEduCls === value;
}
case clsvSysVoteEN.con_UserId:
return (obj: clsvSysVoteEN) => {
return obj.userId === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vSysVote]中不存在！(in ${ vSysVote_ConstructorName}.${ strThisFuncName})`;
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
export async function vSysVote_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vSysVote_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysVote_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysVote_ConstructorName, strThisFuncName);
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
export async function vSysVote_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vSysVote_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysVote_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysVote_ConstructorName, strThisFuncName);
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
export async function vSysVote_GetFirstObjAsync(strWhereCond: string): Promise<clsvSysVoteEN|null>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(vSysVote_Controller, strAction);
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
const objvSysVote = vSysVote_GetObjFromJsonObj(returnObj);
return objvSysVote;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysVote_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysVote_ConstructorName, strThisFuncName);
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
export async function vSysVote_GetObjLstAsync(strWhereCond: string): Promise<Array<clsvSysVoteEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(vSysVote_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vSysVote_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vSysVote_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysVote_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysVote_ConstructorName, strThisFuncName);
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
export async function vSysVote_GetObjLstByVoteIdLstAsync(arrVoteId: Array<string>): Promise<Array<clsvSysVoteEN>>  
{
const strThisFuncName = "GetObjLstByVoteIdLstAsync";
const strAction = "GetObjLstByVoteIdLst";
const strUrl = GetWebApiUrl(vSysVote_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrVoteId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vSysVote_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vSysVote_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysVote_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysVote_ConstructorName, strThisFuncName);
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
export async function vSysVote_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsvSysVoteEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(vSysVote_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vSysVote_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vSysVote_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysVote_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysVote_ConstructorName, strThisFuncName);
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
export async function vSysVote_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsvSysVoteEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vSysVote_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vSysVote_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vSysVote_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysVote_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysVote_ConstructorName, strThisFuncName);
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
export async function vSysVote_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vSysVote_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysVote_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysVote_ConstructorName, strThisFuncName);
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
export async function vSysVote_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsvSysVoteEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
if (objPagerPara.pageIndex == 0) return new Array<clsvSysVoteEN>();
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(vSysVote_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vSysVote_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vSysVote_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysVote_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysVote_ConstructorName, strThisFuncName);
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
export async function vSysVote_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(vSysVote_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysVote_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysVote_ConstructorName, strThisFuncName);
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
export async function vSysVote_IsExist(lngVoteId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vSysVote_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysVote_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysVote_ConstructorName, strThisFuncName);
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
export async function vSysVote_IsExistAsync(lngVoteId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vSysVote_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysVote_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysVote_ConstructorName, strThisFuncName);
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
export async function vSysVote_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(vSysVote_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysVote_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysVote_ConstructorName, strThisFuncName);
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
export function vSysVote_GetWebApiUrl(strController: string, strAction: string): string {
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
export function vSysVote_GetJSONStrByObj (pobjvSysVoteEN: clsvSysVoteEN): string
{
const strThisFuncName = "GetJSONStrByObj";
let strJson = "";
try
{
strJson = JSON.stringify(pobjvSysVoteEN);
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
export function vSysVote_GetObjLstByJSONStr (strJSON: string): Array<clsvSysVoteEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrvSysVoteObjLst = new Array<clsvSysVoteEN>();
if (strJSON === "")
{
return arrvSysVoteObjLst;
}
try
{
arrvSysVoteObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvSysVoteObjLst;
}
return arrvSysVoteObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrvSysVoteObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function vSysVote_GetObjLstByJSONObjLst (arrvSysVoteObjLstS: Array<clsvSysVoteEN>): Array<clsvSysVoteEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrvSysVoteObjLst = new Array<clsvSysVoteEN>();
for (const objInFor of arrvSysVoteObjLstS) {
const obj1 = vSysVote_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrvSysVoteObjLst.push(obj1);
}
return arrvSysVoteObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vSysVote_GetObjByJSONStr (strJSON: string): clsvSysVoteEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjvSysVoteEN = new clsvSysVoteEN();
if (strJSON === "")
{
return pobjvSysVoteEN;
}
try
{
pobjvSysVoteEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvSysVoteEN;
}
return pobjvSysVoteEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function vSysVote_GetCombineCondition(objvSysVote_Cond: clsvSysVoteEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objvSysVote_Cond.dicFldComparisonOp, clsvSysVoteEN.con_VoteId) == true)
{
const strComparisonOp_VoteId:string = objvSysVote_Cond.dicFldComparisonOp[clsvSysVoteEN.con_VoteId];
strWhereCond += Format(" And {0} {2} {1}", clsvSysVoteEN.con_VoteId, objvSysVote_Cond.voteId, strComparisonOp_VoteId);
}
if (Object.prototype.hasOwnProperty.call(objvSysVote_Cond.dicFldComparisonOp, clsvSysVoteEN.con_TableKey) == true)
{
const strComparisonOp_TableKey:string = objvSysVote_Cond.dicFldComparisonOp[clsvSysVoteEN.con_TableKey];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysVoteEN.con_TableKey, objvSysVote_Cond.tableKey, strComparisonOp_TableKey);
}
if (Object.prototype.hasOwnProperty.call(objvSysVote_Cond.dicFldComparisonOp, clsvSysVoteEN.con_PubParentId) == true)
{
const strComparisonOp_PubParentId:string = objvSysVote_Cond.dicFldComparisonOp[clsvSysVoteEN.con_PubParentId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysVoteEN.con_PubParentId, objvSysVote_Cond.pubParentId, strComparisonOp_PubParentId);
}
if (Object.prototype.hasOwnProperty.call(objvSysVote_Cond.dicFldComparisonOp, clsvSysVoteEN.con_VoteTypeId) == true)
{
const strComparisonOp_VoteTypeId:string = objvSysVote_Cond.dicFldComparisonOp[clsvSysVoteEN.con_VoteTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysVoteEN.con_VoteTypeId, objvSysVote_Cond.voteTypeId, strComparisonOp_VoteTypeId);
}
if (Object.prototype.hasOwnProperty.call(objvSysVote_Cond.dicFldComparisonOp, clsvSysVoteEN.con_VoteTypeName) == true)
{
const strComparisonOp_VoteTypeName:string = objvSysVote_Cond.dicFldComparisonOp[clsvSysVoteEN.con_VoteTypeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysVoteEN.con_VoteTypeName, objvSysVote_Cond.voteTypeName, strComparisonOp_VoteTypeName);
}
if (Object.prototype.hasOwnProperty.call(objvSysVote_Cond.dicFldComparisonOp, clsvSysVoteEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objvSysVote_Cond.dicFldComparisonOp[clsvSysVoteEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysVoteEN.con_UpdUser, objvSysVote_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objvSysVote_Cond.dicFldComparisonOp, clsvSysVoteEN.con_VoteTable) == true)
{
const strComparisonOp_VoteTable:string = objvSysVote_Cond.dicFldComparisonOp[clsvSysVoteEN.con_VoteTable];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysVoteEN.con_VoteTable, objvSysVote_Cond.voteTable, strComparisonOp_VoteTable);
}
if (Object.prototype.hasOwnProperty.call(objvSysVote_Cond.dicFldComparisonOp, clsvSysVoteEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objvSysVote_Cond.dicFldComparisonOp[clsvSysVoteEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysVoteEN.con_UpdDate, objvSysVote_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objvSysVote_Cond.dicFldComparisonOp, clsvSysVoteEN.con_VoteTableId) == true)
{
const strComparisonOp_VoteTableId:string = objvSysVote_Cond.dicFldComparisonOp[clsvSysVoteEN.con_VoteTableId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysVoteEN.con_VoteTableId, objvSysVote_Cond.voteTableId, strComparisonOp_VoteTableId);
}
if (Object.prototype.hasOwnProperty.call(objvSysVote_Cond.dicFldComparisonOp, clsvSysVoteEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objvSysVote_Cond.dicFldComparisonOp[clsvSysVoteEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysVoteEN.con_Memo, objvSysVote_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objvSysVote_Cond.dicFldComparisonOp, clsvSysVoteEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objvSysVote_Cond.dicFldComparisonOp[clsvSysVoteEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysVoteEN.con_id_CurrEduCls, objvSysVote_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (Object.prototype.hasOwnProperty.call(objvSysVote_Cond.dicFldComparisonOp, clsvSysVoteEN.con_UserId) == true)
{
const strComparisonOp_UserId:string = objvSysVote_Cond.dicFldComparisonOp[clsvSysVoteEN.con_UserId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysVoteEN.con_UserId, objvSysVote_Cond.userId, strComparisonOp_UserId);
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objvSysVoteENS:源对象
 * @param objvSysVoteENT:目标对象
*/
export function vSysVote_CopyObjTo(objvSysVoteENS: clsvSysVoteEN , objvSysVoteENT: clsvSysVoteEN ): void 
{
objvSysVoteENT.voteId = objvSysVoteENS.voteId; //点赞Id
objvSysVoteENT.tableKey = objvSysVoteENS.tableKey; //表主键
objvSysVoteENT.pubParentId = objvSysVoteENS.pubParentId; //公共父Id
objvSysVoteENT.voteTypeId = objvSysVoteENS.voteTypeId; //点赞类型Id
objvSysVoteENT.voteTypeName = objvSysVoteENS.voteTypeName; //点赞类型名称
objvSysVoteENT.updUser = objvSysVoteENS.updUser; //修改人
objvSysVoteENT.voteTable = objvSysVoteENS.voteTable; //点赞表
objvSysVoteENT.updDate = objvSysVoteENS.updDate; //修改日期
objvSysVoteENT.voteTableId = objvSysVoteENS.voteTableId; //点赞表Id
objvSysVoteENT.memo = objvSysVoteENS.memo; //备注
objvSysVoteENT.id_CurrEduCls = objvSysVoteENS.id_CurrEduCls; //教学班流水号
objvSysVoteENT.userId = objvSysVoteENS.userId; //用户ID
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objvSysVoteENS:源对象
 * @param objvSysVoteENT:目标对象
*/
export function vSysVote_GetObjFromJsonObj(objvSysVoteENS: clsvSysVoteEN): clsvSysVoteEN 
{
 const objvSysVoteENT: clsvSysVoteEN = new clsvSysVoteEN();
ObjectAssign(objvSysVoteENT, objvSysVoteENS);
 return objvSysVoteENT;
}