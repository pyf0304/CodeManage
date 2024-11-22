
 /**
 * 类名:clsgs_TobeStudiedProblemVWApi
 * 表名:gs_TobeStudiedProblemV(01120775)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:47:12
 * 生成者:pyf
 * 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:研培主题(GraduateEduTopic)
 * 框架-层名:WA_访问层(TS)(WA_Access)
 * 编程语言:TypeScript
 * 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
   *      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 **/

/**
 * 待研究问题历史版本表(gs_TobeStudiedProblemV)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { clsgs_TobeStudiedProblemVEN } from "../../L0_Entity/GraduateEduTopic/clsgs_TobeStudiedProblemVEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { tzDataType } from "../../PubFun/jsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const gs_TobeStudiedProblemV_Controller = "gs_TobeStudiedProblemVApi";
 export const gs_TobeStudiedProblemV_ConstructorName = "gs_TobeStudiedProblemV";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngProblemVId:关键字
 * @returns 对象
 **/
export async function gs_TobeStudiedProblemV_GetObjByProblemVIdAsync(lngProblemVId: number): Promise<clsgs_TobeStudiedProblemVEN>  
{
const strThisFuncName = "GetObjByProblemVIdAsync";

if (lngProblemVId == 0)
{
  const strMsg = Format("参数:[lngProblemVId]不能为空！(In GetObjByProblemVIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjByProblemVId";
const strUrl = GetWebApiUrl(gs_TobeStudiedProblemV_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"lngProblemVId": lngProblemVId,
}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObj = data.returnObj;
if (returnObj == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objgs_TobeStudiedProblemV = gs_TobeStudiedProblemV_GetObjFromJsonObj(returnObj);
return objgs_TobeStudiedProblemV;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
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
export function gs_TobeStudiedProblemV_SortFun_Defa(a:clsgs_TobeStudiedProblemVEN , b:clsgs_TobeStudiedProblemVEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.problemVId-b.problemVId;
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
export function gs_TobeStudiedProblemV_SortFun_Defa_2Fld(a:clsgs_TobeStudiedProblemVEN , b:clsgs_TobeStudiedProblemVEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.problemId == b.problemId) return a.topicId.localeCompare(b.topicId);
else return a.problemId.localeCompare(b.problemId);
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
export function gs_TobeStudiedProblemV_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsgs_TobeStudiedProblemVEN.con_ProblemVId:
return (a: clsgs_TobeStudiedProblemVEN, b: clsgs_TobeStudiedProblemVEN) => {
return a.problemVId-b.problemVId;
}
case clsgs_TobeStudiedProblemVEN.con_ProblemId:
return (a: clsgs_TobeStudiedProblemVEN, b: clsgs_TobeStudiedProblemVEN) => {
return a.problemId.localeCompare(b.problemId);
}
case clsgs_TobeStudiedProblemVEN.con_TopicId:
return (a: clsgs_TobeStudiedProblemVEN, b: clsgs_TobeStudiedProblemVEN) => {
return a.topicId.localeCompare(b.topicId);
}
case clsgs_TobeStudiedProblemVEN.con_IsSubmit:
return (a: clsgs_TobeStudiedProblemVEN, b: clsgs_TobeStudiedProblemVEN) => {
if (a.isSubmit == true) return 1;
else return -1
}
case clsgs_TobeStudiedProblemVEN.con_ProblemContent:
return (a: clsgs_TobeStudiedProblemVEN, b: clsgs_TobeStudiedProblemVEN) => {
return a.problemContent.localeCompare(b.problemContent);
}
case clsgs_TobeStudiedProblemVEN.con_ProblemDate:
return (a: clsgs_TobeStudiedProblemVEN, b: clsgs_TobeStudiedProblemVEN) => {
return a.problemDate.localeCompare(b.problemDate);
}
case clsgs_TobeStudiedProblemVEN.con_Participant:
return (a: clsgs_TobeStudiedProblemVEN, b: clsgs_TobeStudiedProblemVEN) => {
return a.participant.localeCompare(b.participant);
}
case clsgs_TobeStudiedProblemVEN.con_UpdDate:
return (a: clsgs_TobeStudiedProblemVEN, b: clsgs_TobeStudiedProblemVEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsgs_TobeStudiedProblemVEN.con_UpdUser:
return (a: clsgs_TobeStudiedProblemVEN, b: clsgs_TobeStudiedProblemVEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsgs_TobeStudiedProblemVEN.con_Year:
return (a: clsgs_TobeStudiedProblemVEN, b: clsgs_TobeStudiedProblemVEN) => {
return a.year.localeCompare(b.year);
}
case clsgs_TobeStudiedProblemVEN.con_Month:
return (a: clsgs_TobeStudiedProblemVEN, b: clsgs_TobeStudiedProblemVEN) => {
return a.month.localeCompare(b.month);
}
case clsgs_TobeStudiedProblemVEN.con_Memo:
return (a: clsgs_TobeStudiedProblemVEN, b: clsgs_TobeStudiedProblemVEN) => {
return a.memo.localeCompare(b.memo);
}
case clsgs_TobeStudiedProblemVEN.con_ProblemTitle:
return (a: clsgs_TobeStudiedProblemVEN, b: clsgs_TobeStudiedProblemVEN) => {
return a.problemTitle.localeCompare(b.problemTitle);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_TobeStudiedProblemV]中不存在！(in ${ gs_TobeStudiedProblemV_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsgs_TobeStudiedProblemVEN.con_ProblemVId:
return (a: clsgs_TobeStudiedProblemVEN, b: clsgs_TobeStudiedProblemVEN) => {
return b.problemVId-a.problemVId;
}
case clsgs_TobeStudiedProblemVEN.con_ProblemId:
return (a: clsgs_TobeStudiedProblemVEN, b: clsgs_TobeStudiedProblemVEN) => {
return b.problemId.localeCompare(a.problemId);
}
case clsgs_TobeStudiedProblemVEN.con_TopicId:
return (a: clsgs_TobeStudiedProblemVEN, b: clsgs_TobeStudiedProblemVEN) => {
return b.topicId.localeCompare(a.topicId);
}
case clsgs_TobeStudiedProblemVEN.con_IsSubmit:
return (a: clsgs_TobeStudiedProblemVEN, b: clsgs_TobeStudiedProblemVEN) => {
if (b.isSubmit == true) return 1;
else return -1
}
case clsgs_TobeStudiedProblemVEN.con_ProblemContent:
return (a: clsgs_TobeStudiedProblemVEN, b: clsgs_TobeStudiedProblemVEN) => {
return b.problemContent.localeCompare(a.problemContent);
}
case clsgs_TobeStudiedProblemVEN.con_ProblemDate:
return (a: clsgs_TobeStudiedProblemVEN, b: clsgs_TobeStudiedProblemVEN) => {
return b.problemDate.localeCompare(a.problemDate);
}
case clsgs_TobeStudiedProblemVEN.con_Participant:
return (a: clsgs_TobeStudiedProblemVEN, b: clsgs_TobeStudiedProblemVEN) => {
return b.participant.localeCompare(a.participant);
}
case clsgs_TobeStudiedProblemVEN.con_UpdDate:
return (a: clsgs_TobeStudiedProblemVEN, b: clsgs_TobeStudiedProblemVEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsgs_TobeStudiedProblemVEN.con_UpdUser:
return (a: clsgs_TobeStudiedProblemVEN, b: clsgs_TobeStudiedProblemVEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsgs_TobeStudiedProblemVEN.con_Year:
return (a: clsgs_TobeStudiedProblemVEN, b: clsgs_TobeStudiedProblemVEN) => {
return b.year.localeCompare(a.year);
}
case clsgs_TobeStudiedProblemVEN.con_Month:
return (a: clsgs_TobeStudiedProblemVEN, b: clsgs_TobeStudiedProblemVEN) => {
return b.month.localeCompare(a.month);
}
case clsgs_TobeStudiedProblemVEN.con_Memo:
return (a: clsgs_TobeStudiedProblemVEN, b: clsgs_TobeStudiedProblemVEN) => {
return b.memo.localeCompare(a.memo);
}
case clsgs_TobeStudiedProblemVEN.con_ProblemTitle:
return (a: clsgs_TobeStudiedProblemVEN, b: clsgs_TobeStudiedProblemVEN) => {
return b.problemTitle.localeCompare(a.problemTitle);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_TobeStudiedProblemV]中不存在！(in ${ gs_TobeStudiedProblemV_ConstructorName}.${ strThisFuncName})`;
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
export async function gs_TobeStudiedProblemV_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsgs_TobeStudiedProblemVEN.con_ProblemVId:
return (obj: clsgs_TobeStudiedProblemVEN) => {
return obj.problemVId === value;
}
case clsgs_TobeStudiedProblemVEN.con_ProblemId:
return (obj: clsgs_TobeStudiedProblemVEN) => {
return obj.problemId === value;
}
case clsgs_TobeStudiedProblemVEN.con_TopicId:
return (obj: clsgs_TobeStudiedProblemVEN) => {
return obj.topicId === value;
}
case clsgs_TobeStudiedProblemVEN.con_IsSubmit:
return (obj: clsgs_TobeStudiedProblemVEN) => {
return obj.isSubmit === value;
}
case clsgs_TobeStudiedProblemVEN.con_ProblemContent:
return (obj: clsgs_TobeStudiedProblemVEN) => {
return obj.problemContent === value;
}
case clsgs_TobeStudiedProblemVEN.con_ProblemDate:
return (obj: clsgs_TobeStudiedProblemVEN) => {
return obj.problemDate === value;
}
case clsgs_TobeStudiedProblemVEN.con_Participant:
return (obj: clsgs_TobeStudiedProblemVEN) => {
return obj.participant === value;
}
case clsgs_TobeStudiedProblemVEN.con_UpdDate:
return (obj: clsgs_TobeStudiedProblemVEN) => {
return obj.updDate === value;
}
case clsgs_TobeStudiedProblemVEN.con_UpdUser:
return (obj: clsgs_TobeStudiedProblemVEN) => {
return obj.updUser === value;
}
case clsgs_TobeStudiedProblemVEN.con_Year:
return (obj: clsgs_TobeStudiedProblemVEN) => {
return obj.year === value;
}
case clsgs_TobeStudiedProblemVEN.con_Month:
return (obj: clsgs_TobeStudiedProblemVEN) => {
return obj.month === value;
}
case clsgs_TobeStudiedProblemVEN.con_Memo:
return (obj: clsgs_TobeStudiedProblemVEN) => {
return obj.memo === value;
}
case clsgs_TobeStudiedProblemVEN.con_ProblemTitle:
return (obj: clsgs_TobeStudiedProblemVEN) => {
return obj.problemTitle === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_TobeStudiedProblemV]中不存在！(in ${ gs_TobeStudiedProblemV_ConstructorName}.${ strThisFuncName})`;
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
export async function gs_TobeStudiedProblemV_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(gs_TobeStudiedProblemV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
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
export async function gs_TobeStudiedProblemV_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(gs_TobeStudiedProblemV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
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
export async function gs_TobeStudiedProblemV_GetFirstObjAsync(strWhereCond: string): Promise<clsgs_TobeStudiedProblemVEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(gs_TobeStudiedProblemV_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objgs_TobeStudiedProblemV = gs_TobeStudiedProblemV_GetObjFromJsonObj(returnObj);
return objgs_TobeStudiedProblemV;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
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
export async function gs_TobeStudiedProblemV_GetObjLstAsync(strWhereCond: string): Promise<Array<clsgs_TobeStudiedProblemVEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(gs_TobeStudiedProblemV_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_TobeStudiedProblemV_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
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
 * @param arrProblemVId:关键字列表
 * @returns 对象列表
 **/
export async function gs_TobeStudiedProblemV_GetObjLstByProblemVIdLstAsync(arrProblemVId: Array<string>): Promise<Array<clsgs_TobeStudiedProblemVEN>>  
{
const strThisFuncName = "GetObjLstByProblemVIdLstAsync";
const strAction = "GetObjLstByProblemVIdLst";
const strUrl = GetWebApiUrl(gs_TobeStudiedProblemV_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrProblemVId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_TobeStudiedProblemV_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
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
export async function gs_TobeStudiedProblemV_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsgs_TobeStudiedProblemVEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(gs_TobeStudiedProblemV_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_TobeStudiedProblemV_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
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
export async function gs_TobeStudiedProblemV_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsgs_TobeStudiedProblemVEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(gs_TobeStudiedProblemV_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_TobeStudiedProblemV_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
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
export async function gs_TobeStudiedProblemV_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(gs_TobeStudiedProblemV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
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
export async function gs_TobeStudiedProblemV_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsgs_TobeStudiedProblemVEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(gs_TobeStudiedProblemV_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_TobeStudiedProblemV_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
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
 * @param lngProblemVId:关键字
 * @returns 获取删除的结果
 **/
export async function gs_TobeStudiedProblemV_DelRecordAsync(lngProblemVId: number): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(gs_TobeStudiedProblemV_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, lngProblemVId);
try
{
const response = await axios.delete(strUrl,
{
params: { "Id": lngProblemVId, }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
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
 * @param arrProblemVId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function gs_TobeStudiedProblemV_Delgs_TobeStudiedProblemVsAsync(arrProblemVId: Array<string>): Promise<number> 
{
const strThisFuncName = "Delgs_TobeStudiedProblemVsAsync";
const strAction = "Delgs_TobeStudiedProblemVs";
const strUrl = GetWebApiUrl(gs_TobeStudiedProblemV_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrProblemVId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
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
export async function gs_TobeStudiedProblemV_Delgs_TobeStudiedProblemVsByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "Delgs_TobeStudiedProblemVsByCondAsync";
const strAction = "Delgs_TobeStudiedProblemVsByCond";
const strUrl = GetWebApiUrl(gs_TobeStudiedProblemV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
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
 * @param objgs_TobeStudiedProblemVEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_TobeStudiedProblemV_AddNewRecordAsync(objgs_TobeStudiedProblemVEN: clsgs_TobeStudiedProblemVEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objgs_TobeStudiedProblemVEN);
const strUrl = GetWebApiUrl(gs_TobeStudiedProblemV_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_TobeStudiedProblemVEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
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
 * @param objgs_TobeStudiedProblemVEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function gs_TobeStudiedProblemV_AddNewRecordWithReturnKeyAsync(objgs_TobeStudiedProblemVEN: clsgs_TobeStudiedProblemVEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(gs_TobeStudiedProblemV_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_TobeStudiedProblemVEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
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
 * @param objgs_TobeStudiedProblemVEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function gs_TobeStudiedProblemV_AddNewRecordWithReturnKey(objgs_TobeStudiedProblemVEN: clsgs_TobeStudiedProblemVEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objgs_TobeStudiedProblemVEN.problemVId === null || objgs_TobeStudiedProblemVEN.problemVId === 0)
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(gs_TobeStudiedProblemV_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_TobeStudiedProblemVEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
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
 * @param objgs_TobeStudiedProblemVEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function gs_TobeStudiedProblemV_UpdateRecordAsync(objgs_TobeStudiedProblemVEN: clsgs_TobeStudiedProblemVEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objgs_TobeStudiedProblemVEN.sf_UpdFldSetStr === undefined || objgs_TobeStudiedProblemVEN.sf_UpdFldSetStr === null || objgs_TobeStudiedProblemVEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_TobeStudiedProblemVEN.problemVId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(gs_TobeStudiedProblemV_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_TobeStudiedProblemVEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
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
 * @param objgs_TobeStudiedProblemVEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function gs_TobeStudiedProblemV_UpdateWithConditionAsync(objgs_TobeStudiedProblemVEN: clsgs_TobeStudiedProblemVEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objgs_TobeStudiedProblemVEN.sf_UpdFldSetStr === undefined || objgs_TobeStudiedProblemVEN.sf_UpdFldSetStr === null || objgs_TobeStudiedProblemVEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_TobeStudiedProblemVEN.problemVId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(gs_TobeStudiedProblemV_Controller, strAction);
objgs_TobeStudiedProblemVEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objgs_TobeStudiedProblemVEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
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
export async function gs_TobeStudiedProblemV_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(gs_TobeStudiedProblemV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
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
 * @param lngProblemVId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function gs_TobeStudiedProblemV_IsExist(lngProblemVId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(gs_TobeStudiedProblemV_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"ProblemVId": lngProblemVId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
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
 * @param lngProblemVId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function gs_TobeStudiedProblemV_IsExistAsync(lngProblemVId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(gs_TobeStudiedProblemV_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "lngProblemVId": lngProblemVId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
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
export async function gs_TobeStudiedProblemV_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(gs_TobeStudiedProblemV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
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
export async function gs_TobeStudiedProblemV_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(gs_TobeStudiedProblemV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TobeStudiedProblemV_ConstructorName, strThisFuncName);
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
export function gs_TobeStudiedProblemV_GetWebApiUrl(strController: string, strAction: string): string {
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
export function gs_TobeStudiedProblemV_CheckPropertyNew(pobjgs_TobeStudiedProblemVEN: clsgs_TobeStudiedProblemVEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemVEN.problemId) === true )
{
 throw new Error("(errid:Watl000058)字段[问题Id]不能为空(In 待研究问题历史版本表)!(clsgs_TobeStudiedProblemVBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemVEN.problemId) == false && GetStrLen(pobjgs_TobeStudiedProblemVEN.problemId) > 10)
{
 throw new Error("(errid:Watl000059)字段[问题Id(problemId)]的长度不能超过10(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!值:$(pobjgs_TobeStudiedProblemVEN.problemId)(clsgs_TobeStudiedProblemVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemVEN.topicId) == false && GetStrLen(pobjgs_TobeStudiedProblemVEN.topicId) > 8)
{
 throw new Error("(errid:Watl000059)字段[主题Id(topicId)]的长度不能超过8(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!值:$(pobjgs_TobeStudiedProblemVEN.topicId)(clsgs_TobeStudiedProblemVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemVEN.problemContent) == false && GetStrLen(pobjgs_TobeStudiedProblemVEN.problemContent) > 5000)
{
 throw new Error("(errid:Watl000059)字段[问题内容(problemContent)]的长度不能超过5000(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!值:$(pobjgs_TobeStudiedProblemVEN.problemContent)(clsgs_TobeStudiedProblemVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemVEN.problemDate) == false && GetStrLen(pobjgs_TobeStudiedProblemVEN.problemDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[问题日期(problemDate)]的长度不能超过20(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!值:$(pobjgs_TobeStudiedProblemVEN.problemDate)(clsgs_TobeStudiedProblemVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemVEN.participant) == false && GetStrLen(pobjgs_TobeStudiedProblemVEN.participant) > 500)
{
 throw new Error("(errid:Watl000059)字段[参与者(participant)]的长度不能超过500(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!值:$(pobjgs_TobeStudiedProblemVEN.participant)(clsgs_TobeStudiedProblemVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemVEN.updDate) == false && GetStrLen(pobjgs_TobeStudiedProblemVEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!值:$(pobjgs_TobeStudiedProblemVEN.updDate)(clsgs_TobeStudiedProblemVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemVEN.updUser) == false && GetStrLen(pobjgs_TobeStudiedProblemVEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!值:$(pobjgs_TobeStudiedProblemVEN.updUser)(clsgs_TobeStudiedProblemVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemVEN.year) == false && GetStrLen(pobjgs_TobeStudiedProblemVEN.year) > 4)
{
 throw new Error("(errid:Watl000059)字段[年(year)]的长度不能超过4(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!值:$(pobjgs_TobeStudiedProblemVEN.year)(clsgs_TobeStudiedProblemVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemVEN.month) == false && GetStrLen(pobjgs_TobeStudiedProblemVEN.month) > 2)
{
 throw new Error("(errid:Watl000059)字段[月(month)]的长度不能超过2(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!值:$(pobjgs_TobeStudiedProblemVEN.month)(clsgs_TobeStudiedProblemVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemVEN.memo) == false && GetStrLen(pobjgs_TobeStudiedProblemVEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!值:$(pobjgs_TobeStudiedProblemVEN.memo)(clsgs_TobeStudiedProblemVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemVEN.problemTitle) == false && GetStrLen(pobjgs_TobeStudiedProblemVEN.problemTitle) > 1000)
{
 throw new Error("(errid:Watl000059)字段[问题标题(problemTitle)]的长度不能超过1000(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!值:$(pobjgs_TobeStudiedProblemVEN.problemTitle)(clsgs_TobeStudiedProblemVBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null != pobjgs_TobeStudiedProblemVEN.problemVId && undefined !== pobjgs_TobeStudiedProblemVEN.problemVId && tzDataType.isNumber(pobjgs_TobeStudiedProblemVEN.problemVId) === false)
{
 throw new Error("(errid:Watl000060)字段[ProblemVId(problemVId)]的值:[$(pobjgs_TobeStudiedProblemVEN.problemVId)], 非法，应该为数值型(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!(clsgs_TobeStudiedProblemVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemVEN.problemId) == false && undefined !== pobjgs_TobeStudiedProblemVEN.problemId && tzDataType.isString(pobjgs_TobeStudiedProblemVEN.problemId) === false)
{
 throw new Error("(errid:Watl000060)字段[问题Id(problemId)]的值:[$(pobjgs_TobeStudiedProblemVEN.problemId)], 非法，应该为字符型(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!(clsgs_TobeStudiedProblemVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemVEN.topicId) == false && undefined !== pobjgs_TobeStudiedProblemVEN.topicId && tzDataType.isString(pobjgs_TobeStudiedProblemVEN.topicId) === false)
{
 throw new Error("(errid:Watl000060)字段[主题Id(topicId)]的值:[$(pobjgs_TobeStudiedProblemVEN.topicId)], 非法，应该为字符型(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!(clsgs_TobeStudiedProblemVBL:CheckPropertyNew)");
}
if (null != pobjgs_TobeStudiedProblemVEN.isSubmit && undefined !== pobjgs_TobeStudiedProblemVEN.isSubmit && tzDataType.isBoolean(pobjgs_TobeStudiedProblemVEN.isSubmit) === false)
{
 throw new Error("(errid:Watl000060)字段[是否提交(isSubmit)]的值:[$(pobjgs_TobeStudiedProblemVEN.isSubmit)], 非法，应该为布尔型(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!(clsgs_TobeStudiedProblemVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemVEN.problemContent) == false && undefined !== pobjgs_TobeStudiedProblemVEN.problemContent && tzDataType.isString(pobjgs_TobeStudiedProblemVEN.problemContent) === false)
{
 throw new Error("(errid:Watl000060)字段[问题内容(problemContent)]的值:[$(pobjgs_TobeStudiedProblemVEN.problemContent)], 非法，应该为字符型(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!(clsgs_TobeStudiedProblemVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemVEN.problemDate) == false && undefined !== pobjgs_TobeStudiedProblemVEN.problemDate && tzDataType.isString(pobjgs_TobeStudiedProblemVEN.problemDate) === false)
{
 throw new Error("(errid:Watl000060)字段[问题日期(problemDate)]的值:[$(pobjgs_TobeStudiedProblemVEN.problemDate)], 非法，应该为字符型(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!(clsgs_TobeStudiedProblemVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemVEN.participant) == false && undefined !== pobjgs_TobeStudiedProblemVEN.participant && tzDataType.isString(pobjgs_TobeStudiedProblemVEN.participant) === false)
{
 throw new Error("(errid:Watl000060)字段[参与者(participant)]的值:[$(pobjgs_TobeStudiedProblemVEN.participant)], 非法，应该为字符型(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!(clsgs_TobeStudiedProblemVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemVEN.updDate) == false && undefined !== pobjgs_TobeStudiedProblemVEN.updDate && tzDataType.isString(pobjgs_TobeStudiedProblemVEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjgs_TobeStudiedProblemVEN.updDate)], 非法，应该为字符型(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!(clsgs_TobeStudiedProblemVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemVEN.updUser) == false && undefined !== pobjgs_TobeStudiedProblemVEN.updUser && tzDataType.isString(pobjgs_TobeStudiedProblemVEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjgs_TobeStudiedProblemVEN.updUser)], 非法，应该为字符型(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!(clsgs_TobeStudiedProblemVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemVEN.year) == false && undefined !== pobjgs_TobeStudiedProblemVEN.year && tzDataType.isString(pobjgs_TobeStudiedProblemVEN.year) === false)
{
 throw new Error("(errid:Watl000060)字段[年(year)]的值:[$(pobjgs_TobeStudiedProblemVEN.year)], 非法，应该为字符型(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!(clsgs_TobeStudiedProblemVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemVEN.month) == false && undefined !== pobjgs_TobeStudiedProblemVEN.month && tzDataType.isString(pobjgs_TobeStudiedProblemVEN.month) === false)
{
 throw new Error("(errid:Watl000060)字段[月(month)]的值:[$(pobjgs_TobeStudiedProblemVEN.month)], 非法，应该为字符型(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!(clsgs_TobeStudiedProblemVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemVEN.memo) == false && undefined !== pobjgs_TobeStudiedProblemVEN.memo && tzDataType.isString(pobjgs_TobeStudiedProblemVEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjgs_TobeStudiedProblemVEN.memo)], 非法，应该为字符型(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!(clsgs_TobeStudiedProblemVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemVEN.problemTitle) == false && undefined !== pobjgs_TobeStudiedProblemVEN.problemTitle && tzDataType.isString(pobjgs_TobeStudiedProblemVEN.problemTitle) === false)
{
 throw new Error("(errid:Watl000060)字段[问题标题(problemTitle)]的值:[$(pobjgs_TobeStudiedProblemVEN.problemTitle)], 非法，应该为字符型(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!(clsgs_TobeStudiedProblemVBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjgs_TobeStudiedProblemVEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function gs_TobeStudiedProblemV_CheckProperty4Update (pobjgs_TobeStudiedProblemVEN: clsgs_TobeStudiedProblemVEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemVEN.problemId) == false && GetStrLen(pobjgs_TobeStudiedProblemVEN.problemId) > 10)
{
 throw new Error("(errid:Watl000062)字段[问题Id(problemId)]的长度不能超过10(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!值:$(pobjgs_TobeStudiedProblemVEN.problemId)(clsgs_TobeStudiedProblemVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemVEN.topicId) == false && GetStrLen(pobjgs_TobeStudiedProblemVEN.topicId) > 8)
{
 throw new Error("(errid:Watl000062)字段[主题Id(topicId)]的长度不能超过8(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!值:$(pobjgs_TobeStudiedProblemVEN.topicId)(clsgs_TobeStudiedProblemVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemVEN.problemContent) == false && GetStrLen(pobjgs_TobeStudiedProblemVEN.problemContent) > 5000)
{
 throw new Error("(errid:Watl000062)字段[问题内容(problemContent)]的长度不能超过5000(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!值:$(pobjgs_TobeStudiedProblemVEN.problemContent)(clsgs_TobeStudiedProblemVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemVEN.problemDate) == false && GetStrLen(pobjgs_TobeStudiedProblemVEN.problemDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[问题日期(problemDate)]的长度不能超过20(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!值:$(pobjgs_TobeStudiedProblemVEN.problemDate)(clsgs_TobeStudiedProblemVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemVEN.participant) == false && GetStrLen(pobjgs_TobeStudiedProblemVEN.participant) > 500)
{
 throw new Error("(errid:Watl000062)字段[参与者(participant)]的长度不能超过500(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!值:$(pobjgs_TobeStudiedProblemVEN.participant)(clsgs_TobeStudiedProblemVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemVEN.updDate) == false && GetStrLen(pobjgs_TobeStudiedProblemVEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!值:$(pobjgs_TobeStudiedProblemVEN.updDate)(clsgs_TobeStudiedProblemVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemVEN.updUser) == false && GetStrLen(pobjgs_TobeStudiedProblemVEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!值:$(pobjgs_TobeStudiedProblemVEN.updUser)(clsgs_TobeStudiedProblemVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemVEN.year) == false && GetStrLen(pobjgs_TobeStudiedProblemVEN.year) > 4)
{
 throw new Error("(errid:Watl000062)字段[年(year)]的长度不能超过4(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!值:$(pobjgs_TobeStudiedProblemVEN.year)(clsgs_TobeStudiedProblemVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemVEN.month) == false && GetStrLen(pobjgs_TobeStudiedProblemVEN.month) > 2)
{
 throw new Error("(errid:Watl000062)字段[月(month)]的长度不能超过2(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!值:$(pobjgs_TobeStudiedProblemVEN.month)(clsgs_TobeStudiedProblemVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemVEN.memo) == false && GetStrLen(pobjgs_TobeStudiedProblemVEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!值:$(pobjgs_TobeStudiedProblemVEN.memo)(clsgs_TobeStudiedProblemVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemVEN.problemTitle) == false && GetStrLen(pobjgs_TobeStudiedProblemVEN.problemTitle) > 1000)
{
 throw new Error("(errid:Watl000062)字段[问题标题(problemTitle)]的长度不能超过1000(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!值:$(pobjgs_TobeStudiedProblemVEN.problemTitle)(clsgs_TobeStudiedProblemVBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null != pobjgs_TobeStudiedProblemVEN.problemVId && undefined !== pobjgs_TobeStudiedProblemVEN.problemVId && tzDataType.isNumber(pobjgs_TobeStudiedProblemVEN.problemVId) === false)
{
 throw new Error("(errid:Watl000063)字段[ProblemVId(problemVId)]的值:[$(pobjgs_TobeStudiedProblemVEN.problemVId)], 非法，应该为数值型(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!(clsgs_TobeStudiedProblemVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemVEN.problemId) == false && undefined !== pobjgs_TobeStudiedProblemVEN.problemId && tzDataType.isString(pobjgs_TobeStudiedProblemVEN.problemId) === false)
{
 throw new Error("(errid:Watl000063)字段[问题Id(problemId)]的值:[$(pobjgs_TobeStudiedProblemVEN.problemId)], 非法，应该为字符型(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!(clsgs_TobeStudiedProblemVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemVEN.topicId) == false && undefined !== pobjgs_TobeStudiedProblemVEN.topicId && tzDataType.isString(pobjgs_TobeStudiedProblemVEN.topicId) === false)
{
 throw new Error("(errid:Watl000063)字段[主题Id(topicId)]的值:[$(pobjgs_TobeStudiedProblemVEN.topicId)], 非法，应该为字符型(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!(clsgs_TobeStudiedProblemVBL:CheckProperty4Update)");
}
if (null != pobjgs_TobeStudiedProblemVEN.isSubmit && undefined !== pobjgs_TobeStudiedProblemVEN.isSubmit && tzDataType.isBoolean(pobjgs_TobeStudiedProblemVEN.isSubmit) === false)
{
 throw new Error("(errid:Watl000063)字段[是否提交(isSubmit)]的值:[$(pobjgs_TobeStudiedProblemVEN.isSubmit)], 非法，应该为布尔型(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!(clsgs_TobeStudiedProblemVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemVEN.problemContent) == false && undefined !== pobjgs_TobeStudiedProblemVEN.problemContent && tzDataType.isString(pobjgs_TobeStudiedProblemVEN.problemContent) === false)
{
 throw new Error("(errid:Watl000063)字段[问题内容(problemContent)]的值:[$(pobjgs_TobeStudiedProblemVEN.problemContent)], 非法，应该为字符型(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!(clsgs_TobeStudiedProblemVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemVEN.problemDate) == false && undefined !== pobjgs_TobeStudiedProblemVEN.problemDate && tzDataType.isString(pobjgs_TobeStudiedProblemVEN.problemDate) === false)
{
 throw new Error("(errid:Watl000063)字段[问题日期(problemDate)]的值:[$(pobjgs_TobeStudiedProblemVEN.problemDate)], 非法，应该为字符型(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!(clsgs_TobeStudiedProblemVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemVEN.participant) == false && undefined !== pobjgs_TobeStudiedProblemVEN.participant && tzDataType.isString(pobjgs_TobeStudiedProblemVEN.participant) === false)
{
 throw new Error("(errid:Watl000063)字段[参与者(participant)]的值:[$(pobjgs_TobeStudiedProblemVEN.participant)], 非法，应该为字符型(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!(clsgs_TobeStudiedProblemVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemVEN.updDate) == false && undefined !== pobjgs_TobeStudiedProblemVEN.updDate && tzDataType.isString(pobjgs_TobeStudiedProblemVEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjgs_TobeStudiedProblemVEN.updDate)], 非法，应该为字符型(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!(clsgs_TobeStudiedProblemVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemVEN.updUser) == false && undefined !== pobjgs_TobeStudiedProblemVEN.updUser && tzDataType.isString(pobjgs_TobeStudiedProblemVEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjgs_TobeStudiedProblemVEN.updUser)], 非法，应该为字符型(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!(clsgs_TobeStudiedProblemVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemVEN.year) == false && undefined !== pobjgs_TobeStudiedProblemVEN.year && tzDataType.isString(pobjgs_TobeStudiedProblemVEN.year) === false)
{
 throw new Error("(errid:Watl000063)字段[年(year)]的值:[$(pobjgs_TobeStudiedProblemVEN.year)], 非法，应该为字符型(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!(clsgs_TobeStudiedProblemVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemVEN.month) == false && undefined !== pobjgs_TobeStudiedProblemVEN.month && tzDataType.isString(pobjgs_TobeStudiedProblemVEN.month) === false)
{
 throw new Error("(errid:Watl000063)字段[月(month)]的值:[$(pobjgs_TobeStudiedProblemVEN.month)], 非法，应该为字符型(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!(clsgs_TobeStudiedProblemVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemVEN.memo) == false && undefined !== pobjgs_TobeStudiedProblemVEN.memo && tzDataType.isString(pobjgs_TobeStudiedProblemVEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjgs_TobeStudiedProblemVEN.memo)], 非法，应该为字符型(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!(clsgs_TobeStudiedProblemVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemVEN.problemTitle) == false && undefined !== pobjgs_TobeStudiedProblemVEN.problemTitle && tzDataType.isString(pobjgs_TobeStudiedProblemVEN.problemTitle) === false)
{
 throw new Error("(errid:Watl000063)字段[问题标题(problemTitle)]的值:[$(pobjgs_TobeStudiedProblemVEN.problemTitle)], 非法，应该为字符型(In 待研究问题历史版本表(gs_TobeStudiedProblemV))!(clsgs_TobeStudiedProblemVBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjgs_TobeStudiedProblemVEN.problemVId 
 || pobjgs_TobeStudiedProblemVEN.problemVId != null && pobjgs_TobeStudiedProblemVEN.problemVId.toString()  ===  "")
{
 throw new Error("(errid:Watl000064)字段[ProblemVId]不能为空(In 待研究问题历史版本表)!(clsgs_TobeStudiedProblemVBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjgs_TobeStudiedProblemVEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function gs_TobeStudiedProblemV_GetJSONStrByObj (pobjgs_TobeStudiedProblemVEN: clsgs_TobeStudiedProblemVEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjgs_TobeStudiedProblemVEN.sf_UpdFldSetStr = pobjgs_TobeStudiedProblemVEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjgs_TobeStudiedProblemVEN);
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
export function gs_TobeStudiedProblemV_GetObjLstByJSONStr (strJSON: string): Array<clsgs_TobeStudiedProblemVEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrgs_TobeStudiedProblemVObjLst = new Array<clsgs_TobeStudiedProblemVEN>();
if (strJSON === "")
{
return arrgs_TobeStudiedProblemVObjLst;
}
try
{
arrgs_TobeStudiedProblemVObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrgs_TobeStudiedProblemVObjLst;
}
return arrgs_TobeStudiedProblemVObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrgs_TobeStudiedProblemVObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function gs_TobeStudiedProblemV_GetObjLstByJSONObjLst (arrgs_TobeStudiedProblemVObjLstS: Array<clsgs_TobeStudiedProblemVEN>): Array<clsgs_TobeStudiedProblemVEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrgs_TobeStudiedProblemVObjLst = new Array<clsgs_TobeStudiedProblemVEN>();
for (const objInFor of arrgs_TobeStudiedProblemVObjLstS) {
const obj1 = gs_TobeStudiedProblemV_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrgs_TobeStudiedProblemVObjLst.push(obj1);
}
return arrgs_TobeStudiedProblemVObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function gs_TobeStudiedProblemV_GetObjByJSONStr (strJSON: string): clsgs_TobeStudiedProblemVEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjgs_TobeStudiedProblemVEN = new clsgs_TobeStudiedProblemVEN();
if (strJSON === "")
{
return pobjgs_TobeStudiedProblemVEN;
}
try
{
pobjgs_TobeStudiedProblemVEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjgs_TobeStudiedProblemVEN;
}
return pobjgs_TobeStudiedProblemVEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function gs_TobeStudiedProblemV_GetCombineCondition(objgs_TobeStudiedProblemV_Cond: clsgs_TobeStudiedProblemVEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objgs_TobeStudiedProblemV_Cond.dicFldComparisonOp, clsgs_TobeStudiedProblemVEN.con_ProblemVId) == true)
{
const strComparisonOp_ProblemVId:string = objgs_TobeStudiedProblemV_Cond.dicFldComparisonOp[clsgs_TobeStudiedProblemVEN.con_ProblemVId];
strWhereCond += Format(" And {0} {2} {1}", clsgs_TobeStudiedProblemVEN.con_ProblemVId, objgs_TobeStudiedProblemV_Cond.problemVId, strComparisonOp_ProblemVId);
}
if (Object.prototype.hasOwnProperty.call(objgs_TobeStudiedProblemV_Cond.dicFldComparisonOp, clsgs_TobeStudiedProblemVEN.con_ProblemId) == true)
{
const strComparisonOp_ProblemId:string = objgs_TobeStudiedProblemV_Cond.dicFldComparisonOp[clsgs_TobeStudiedProblemVEN.con_ProblemId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TobeStudiedProblemVEN.con_ProblemId, objgs_TobeStudiedProblemV_Cond.problemId, strComparisonOp_ProblemId);
}
if (Object.prototype.hasOwnProperty.call(objgs_TobeStudiedProblemV_Cond.dicFldComparisonOp, clsgs_TobeStudiedProblemVEN.con_TopicId) == true)
{
const strComparisonOp_TopicId:string = objgs_TobeStudiedProblemV_Cond.dicFldComparisonOp[clsgs_TobeStudiedProblemVEN.con_TopicId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TobeStudiedProblemVEN.con_TopicId, objgs_TobeStudiedProblemV_Cond.topicId, strComparisonOp_TopicId);
}
if (Object.prototype.hasOwnProperty.call(objgs_TobeStudiedProblemV_Cond.dicFldComparisonOp, clsgs_TobeStudiedProblemVEN.con_IsSubmit) == true)
{
if (objgs_TobeStudiedProblemV_Cond.isSubmit == true)
{
strWhereCond += Format(" And {0} = '1'", clsgs_TobeStudiedProblemVEN.con_IsSubmit);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsgs_TobeStudiedProblemVEN.con_IsSubmit);
}
}
if (Object.prototype.hasOwnProperty.call(objgs_TobeStudiedProblemV_Cond.dicFldComparisonOp, clsgs_TobeStudiedProblemVEN.con_ProblemContent) == true)
{
const strComparisonOp_ProblemContent:string = objgs_TobeStudiedProblemV_Cond.dicFldComparisonOp[clsgs_TobeStudiedProblemVEN.con_ProblemContent];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TobeStudiedProblemVEN.con_ProblemContent, objgs_TobeStudiedProblemV_Cond.problemContent, strComparisonOp_ProblemContent);
}
if (Object.prototype.hasOwnProperty.call(objgs_TobeStudiedProblemV_Cond.dicFldComparisonOp, clsgs_TobeStudiedProblemVEN.con_ProblemDate) == true)
{
const strComparisonOp_ProblemDate:string = objgs_TobeStudiedProblemV_Cond.dicFldComparisonOp[clsgs_TobeStudiedProblemVEN.con_ProblemDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TobeStudiedProblemVEN.con_ProblemDate, objgs_TobeStudiedProblemV_Cond.problemDate, strComparisonOp_ProblemDate);
}
if (Object.prototype.hasOwnProperty.call(objgs_TobeStudiedProblemV_Cond.dicFldComparisonOp, clsgs_TobeStudiedProblemVEN.con_Participant) == true)
{
const strComparisonOp_Participant:string = objgs_TobeStudiedProblemV_Cond.dicFldComparisonOp[clsgs_TobeStudiedProblemVEN.con_Participant];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TobeStudiedProblemVEN.con_Participant, objgs_TobeStudiedProblemV_Cond.participant, strComparisonOp_Participant);
}
if (Object.prototype.hasOwnProperty.call(objgs_TobeStudiedProblemV_Cond.dicFldComparisonOp, clsgs_TobeStudiedProblemVEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objgs_TobeStudiedProblemV_Cond.dicFldComparisonOp[clsgs_TobeStudiedProblemVEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TobeStudiedProblemVEN.con_UpdDate, objgs_TobeStudiedProblemV_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objgs_TobeStudiedProblemV_Cond.dicFldComparisonOp, clsgs_TobeStudiedProblemVEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objgs_TobeStudiedProblemV_Cond.dicFldComparisonOp[clsgs_TobeStudiedProblemVEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TobeStudiedProblemVEN.con_UpdUser, objgs_TobeStudiedProblemV_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objgs_TobeStudiedProblemV_Cond.dicFldComparisonOp, clsgs_TobeStudiedProblemVEN.con_Year) == true)
{
const strComparisonOp_Year:string = objgs_TobeStudiedProblemV_Cond.dicFldComparisonOp[clsgs_TobeStudiedProblemVEN.con_Year];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TobeStudiedProblemVEN.con_Year, objgs_TobeStudiedProblemV_Cond.year, strComparisonOp_Year);
}
if (Object.prototype.hasOwnProperty.call(objgs_TobeStudiedProblemV_Cond.dicFldComparisonOp, clsgs_TobeStudiedProblemVEN.con_Month) == true)
{
const strComparisonOp_Month:string = objgs_TobeStudiedProblemV_Cond.dicFldComparisonOp[clsgs_TobeStudiedProblemVEN.con_Month];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TobeStudiedProblemVEN.con_Month, objgs_TobeStudiedProblemV_Cond.month, strComparisonOp_Month);
}
if (Object.prototype.hasOwnProperty.call(objgs_TobeStudiedProblemV_Cond.dicFldComparisonOp, clsgs_TobeStudiedProblemVEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objgs_TobeStudiedProblemV_Cond.dicFldComparisonOp[clsgs_TobeStudiedProblemVEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TobeStudiedProblemVEN.con_Memo, objgs_TobeStudiedProblemV_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objgs_TobeStudiedProblemV_Cond.dicFldComparisonOp, clsgs_TobeStudiedProblemVEN.con_ProblemTitle) == true)
{
const strComparisonOp_ProblemTitle:string = objgs_TobeStudiedProblemV_Cond.dicFldComparisonOp[clsgs_TobeStudiedProblemVEN.con_ProblemTitle];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TobeStudiedProblemVEN.con_ProblemTitle, objgs_TobeStudiedProblemV_Cond.problemTitle, strComparisonOp_ProblemTitle);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--gs_TobeStudiedProblemV(待研究问题历史版本表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param lngProblemVId: ProblemVId(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function gs_TobeStudiedProblemV_GetUniCondStr_ProblemVId(objgs_TobeStudiedProblemVEN: clsgs_TobeStudiedProblemVEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and ProblemVId = '{0}'", objgs_TobeStudiedProblemVEN.problemVId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--gs_TobeStudiedProblemV(待研究问题历史版本表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param lngProblemVId: ProblemVId(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function gs_TobeStudiedProblemV_GetUniCondStr4Update_ProblemVId(objgs_TobeStudiedProblemVEN: clsgs_TobeStudiedProblemVEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and ProblemVId <> '{0}'", objgs_TobeStudiedProblemVEN.problemVId);
 strWhereCond +=  Format(" and ProblemVId = '{0}'", objgs_TobeStudiedProblemVEN.problemVId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objgs_TobeStudiedProblemVENS:源对象
 * @param objgs_TobeStudiedProblemVENT:目标对象
*/
export function gs_TobeStudiedProblemV_CopyObjTo(objgs_TobeStudiedProblemVENS: clsgs_TobeStudiedProblemVEN , objgs_TobeStudiedProblemVENT: clsgs_TobeStudiedProblemVEN ): void 
{
objgs_TobeStudiedProblemVENT.problemVId = objgs_TobeStudiedProblemVENS.problemVId; //ProblemVId
objgs_TobeStudiedProblemVENT.problemId = objgs_TobeStudiedProblemVENS.problemId; //问题Id
objgs_TobeStudiedProblemVENT.topicId = objgs_TobeStudiedProblemVENS.topicId; //主题Id
objgs_TobeStudiedProblemVENT.isSubmit = objgs_TobeStudiedProblemVENS.isSubmit; //是否提交
objgs_TobeStudiedProblemVENT.problemContent = objgs_TobeStudiedProblemVENS.problemContent; //问题内容
objgs_TobeStudiedProblemVENT.problemDate = objgs_TobeStudiedProblemVENS.problemDate; //问题日期
objgs_TobeStudiedProblemVENT.participant = objgs_TobeStudiedProblemVENS.participant; //参与者
objgs_TobeStudiedProblemVENT.updDate = objgs_TobeStudiedProblemVENS.updDate; //修改日期
objgs_TobeStudiedProblemVENT.updUser = objgs_TobeStudiedProblemVENS.updUser; //修改人
objgs_TobeStudiedProblemVENT.year = objgs_TobeStudiedProblemVENS.year; //年
objgs_TobeStudiedProblemVENT.month = objgs_TobeStudiedProblemVENS.month; //月
objgs_TobeStudiedProblemVENT.memo = objgs_TobeStudiedProblemVENS.memo; //备注
objgs_TobeStudiedProblemVENT.problemTitle = objgs_TobeStudiedProblemVENS.problemTitle; //问题标题
objgs_TobeStudiedProblemVENT.sf_UpdFldSetStr = objgs_TobeStudiedProblemVENS.updFldString; //sf_UpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objgs_TobeStudiedProblemVENS:源对象
 * @param objgs_TobeStudiedProblemVENT:目标对象
*/
export function gs_TobeStudiedProblemV_GetObjFromJsonObj(objgs_TobeStudiedProblemVENS: clsgs_TobeStudiedProblemVEN): clsgs_TobeStudiedProblemVEN 
{
 const objgs_TobeStudiedProblemVENT: clsgs_TobeStudiedProblemVEN = new clsgs_TobeStudiedProblemVEN();
ObjectAssign(objgs_TobeStudiedProblemVENT, objgs_TobeStudiedProblemVENS);
 return objgs_TobeStudiedProblemVENT;
}