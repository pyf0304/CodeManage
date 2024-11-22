
 /**
 * 类名:clsgs_TobeStudiedProblemWApi
 * 表名:gs_TobeStudiedProblem(01120776)
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
 * 待研究问题(gs_TobeStudiedProblem)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { clsgs_TobeStudiedProblemEN } from "../../L0_Entity/GraduateEduTopic/clsgs_TobeStudiedProblemEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { tzDataType } from "../../PubFun/jsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const gs_TobeStudiedProblem_Controller = "gs_TobeStudiedProblemApi";
 export const gs_TobeStudiedProblem_ConstructorName = "gs_TobeStudiedProblem";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strProblemId:关键字
 * @returns 对象
 **/
export async function gs_TobeStudiedProblem_GetObjByProblemIdAsync(strProblemId: string): Promise<clsgs_TobeStudiedProblemEN>  
{
const strThisFuncName = "GetObjByProblemIdAsync";

if (IsNullOrEmpty(strProblemId) == true)
{
  const strMsg = Format("参数:[strProblemId]不能为空！(In GetObjByProblemIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strProblemId.length != 10)
{
const strMsg = Format("缓存分类变量:[strProblemId]的长度:[{0}]不正确！", strProblemId.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByProblemId";
const strUrl = GetWebApiUrl(gs_TobeStudiedProblem_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strProblemId": strProblemId,
}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObj = data.returnObj;
if (returnObj == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objgs_TobeStudiedProblem = gs_TobeStudiedProblem_GetObjFromJsonObj(returnObj);
return objgs_TobeStudiedProblem;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
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
export function gs_TobeStudiedProblem_SortFun_Defa(a:clsgs_TobeStudiedProblemEN , b:clsgs_TobeStudiedProblemEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.problemId.localeCompare(b.problemId);
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
export function gs_TobeStudiedProblem_SortFun_Defa_2Fld(a:clsgs_TobeStudiedProblemEN , b:clsgs_TobeStudiedProblemEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.problemTitle == b.problemTitle) return a.problemContent.localeCompare(b.problemContent);
else return a.problemTitle.localeCompare(b.problemTitle);
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
export function gs_TobeStudiedProblem_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsgs_TobeStudiedProblemEN.con_ProblemId:
return (a: clsgs_TobeStudiedProblemEN, b: clsgs_TobeStudiedProblemEN) => {
return a.problemId.localeCompare(b.problemId);
}
case clsgs_TobeStudiedProblemEN.con_ProblemTitle:
return (a: clsgs_TobeStudiedProblemEN, b: clsgs_TobeStudiedProblemEN) => {
return a.problemTitle.localeCompare(b.problemTitle);
}
case clsgs_TobeStudiedProblemEN.con_ProblemContent:
return (a: clsgs_TobeStudiedProblemEN, b: clsgs_TobeStudiedProblemEN) => {
return a.problemContent.localeCompare(b.problemContent);
}
case clsgs_TobeStudiedProblemEN.con_TopicId:
return (a: clsgs_TobeStudiedProblemEN, b: clsgs_TobeStudiedProblemEN) => {
return a.topicId.localeCompare(b.topicId);
}
case clsgs_TobeStudiedProblemEN.con_IsSubmit:
return (a: clsgs_TobeStudiedProblemEN, b: clsgs_TobeStudiedProblemEN) => {
if (a.isSubmit == true) return 1;
else return -1
}
case clsgs_TobeStudiedProblemEN.con_ProblemDate:
return (a: clsgs_TobeStudiedProblemEN, b: clsgs_TobeStudiedProblemEN) => {
return a.problemDate.localeCompare(b.problemDate);
}
case clsgs_TobeStudiedProblemEN.con_UpdDate:
return (a: clsgs_TobeStudiedProblemEN, b: clsgs_TobeStudiedProblemEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsgs_TobeStudiedProblemEN.con_UpdUser:
return (a: clsgs_TobeStudiedProblemEN, b: clsgs_TobeStudiedProblemEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsgs_TobeStudiedProblemEN.con_Year:
return (a: clsgs_TobeStudiedProblemEN, b: clsgs_TobeStudiedProblemEN) => {
return a.year.localeCompare(b.year);
}
case clsgs_TobeStudiedProblemEN.con_Month:
return (a: clsgs_TobeStudiedProblemEN, b: clsgs_TobeStudiedProblemEN) => {
return a.month.localeCompare(b.month);
}
case clsgs_TobeStudiedProblemEN.con_VersionCount:
return (a: clsgs_TobeStudiedProblemEN, b: clsgs_TobeStudiedProblemEN) => {
return a.versionCount-b.versionCount;
}
case clsgs_TobeStudiedProblemEN.con_Participant:
return (a: clsgs_TobeStudiedProblemEN, b: clsgs_TobeStudiedProblemEN) => {
return a.participant.localeCompare(b.participant);
}
case clsgs_TobeStudiedProblemEN.con_Memo:
return (a: clsgs_TobeStudiedProblemEN, b: clsgs_TobeStudiedProblemEN) => {
return a.memo.localeCompare(b.memo);
}
case clsgs_TobeStudiedProblemEN.con_id_CurrEduCls:
return (a: clsgs_TobeStudiedProblemEN, b: clsgs_TobeStudiedProblemEN) => {
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_TobeStudiedProblem]中不存在！(in ${ gs_TobeStudiedProblem_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsgs_TobeStudiedProblemEN.con_ProblemId:
return (a: clsgs_TobeStudiedProblemEN, b: clsgs_TobeStudiedProblemEN) => {
return b.problemId.localeCompare(a.problemId);
}
case clsgs_TobeStudiedProblemEN.con_ProblemTitle:
return (a: clsgs_TobeStudiedProblemEN, b: clsgs_TobeStudiedProblemEN) => {
return b.problemTitle.localeCompare(a.problemTitle);
}
case clsgs_TobeStudiedProblemEN.con_ProblemContent:
return (a: clsgs_TobeStudiedProblemEN, b: clsgs_TobeStudiedProblemEN) => {
return b.problemContent.localeCompare(a.problemContent);
}
case clsgs_TobeStudiedProblemEN.con_TopicId:
return (a: clsgs_TobeStudiedProblemEN, b: clsgs_TobeStudiedProblemEN) => {
return b.topicId.localeCompare(a.topicId);
}
case clsgs_TobeStudiedProblemEN.con_IsSubmit:
return (a: clsgs_TobeStudiedProblemEN, b: clsgs_TobeStudiedProblemEN) => {
if (b.isSubmit == true) return 1;
else return -1
}
case clsgs_TobeStudiedProblemEN.con_ProblemDate:
return (a: clsgs_TobeStudiedProblemEN, b: clsgs_TobeStudiedProblemEN) => {
return b.problemDate.localeCompare(a.problemDate);
}
case clsgs_TobeStudiedProblemEN.con_UpdDate:
return (a: clsgs_TobeStudiedProblemEN, b: clsgs_TobeStudiedProblemEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsgs_TobeStudiedProblemEN.con_UpdUser:
return (a: clsgs_TobeStudiedProblemEN, b: clsgs_TobeStudiedProblemEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsgs_TobeStudiedProblemEN.con_Year:
return (a: clsgs_TobeStudiedProblemEN, b: clsgs_TobeStudiedProblemEN) => {
return b.year.localeCompare(a.year);
}
case clsgs_TobeStudiedProblemEN.con_Month:
return (a: clsgs_TobeStudiedProblemEN, b: clsgs_TobeStudiedProblemEN) => {
return b.month.localeCompare(a.month);
}
case clsgs_TobeStudiedProblemEN.con_VersionCount:
return (a: clsgs_TobeStudiedProblemEN, b: clsgs_TobeStudiedProblemEN) => {
return b.versionCount-a.versionCount;
}
case clsgs_TobeStudiedProblemEN.con_Participant:
return (a: clsgs_TobeStudiedProblemEN, b: clsgs_TobeStudiedProblemEN) => {
return b.participant.localeCompare(a.participant);
}
case clsgs_TobeStudiedProblemEN.con_Memo:
return (a: clsgs_TobeStudiedProblemEN, b: clsgs_TobeStudiedProblemEN) => {
return b.memo.localeCompare(a.memo);
}
case clsgs_TobeStudiedProblemEN.con_id_CurrEduCls:
return (a: clsgs_TobeStudiedProblemEN, b: clsgs_TobeStudiedProblemEN) => {
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_TobeStudiedProblem]中不存在！(in ${ gs_TobeStudiedProblem_ConstructorName}.${ strThisFuncName})`;
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
export async function gs_TobeStudiedProblem_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsgs_TobeStudiedProblemEN.con_ProblemId:
return (obj: clsgs_TobeStudiedProblemEN) => {
return obj.problemId === value;
}
case clsgs_TobeStudiedProblemEN.con_ProblemTitle:
return (obj: clsgs_TobeStudiedProblemEN) => {
return obj.problemTitle === value;
}
case clsgs_TobeStudiedProblemEN.con_ProblemContent:
return (obj: clsgs_TobeStudiedProblemEN) => {
return obj.problemContent === value;
}
case clsgs_TobeStudiedProblemEN.con_TopicId:
return (obj: clsgs_TobeStudiedProblemEN) => {
return obj.topicId === value;
}
case clsgs_TobeStudiedProblemEN.con_IsSubmit:
return (obj: clsgs_TobeStudiedProblemEN) => {
return obj.isSubmit === value;
}
case clsgs_TobeStudiedProblemEN.con_ProblemDate:
return (obj: clsgs_TobeStudiedProblemEN) => {
return obj.problemDate === value;
}
case clsgs_TobeStudiedProblemEN.con_UpdDate:
return (obj: clsgs_TobeStudiedProblemEN) => {
return obj.updDate === value;
}
case clsgs_TobeStudiedProblemEN.con_UpdUser:
return (obj: clsgs_TobeStudiedProblemEN) => {
return obj.updUser === value;
}
case clsgs_TobeStudiedProblemEN.con_Year:
return (obj: clsgs_TobeStudiedProblemEN) => {
return obj.year === value;
}
case clsgs_TobeStudiedProblemEN.con_Month:
return (obj: clsgs_TobeStudiedProblemEN) => {
return obj.month === value;
}
case clsgs_TobeStudiedProblemEN.con_VersionCount:
return (obj: clsgs_TobeStudiedProblemEN) => {
return obj.versionCount === value;
}
case clsgs_TobeStudiedProblemEN.con_Participant:
return (obj: clsgs_TobeStudiedProblemEN) => {
return obj.participant === value;
}
case clsgs_TobeStudiedProblemEN.con_Memo:
return (obj: clsgs_TobeStudiedProblemEN) => {
return obj.memo === value;
}
case clsgs_TobeStudiedProblemEN.con_id_CurrEduCls:
return (obj: clsgs_TobeStudiedProblemEN) => {
return obj.id_CurrEduCls === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_TobeStudiedProblem]中不存在！(in ${ gs_TobeStudiedProblem_ConstructorName}.${ strThisFuncName})`;
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
export async function gs_TobeStudiedProblem_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(gs_TobeStudiedProblem_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
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
export async function gs_TobeStudiedProblem_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(gs_TobeStudiedProblem_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
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
export async function gs_TobeStudiedProblem_GetFirstObjAsync(strWhereCond: string): Promise<clsgs_TobeStudiedProblemEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(gs_TobeStudiedProblem_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objgs_TobeStudiedProblem = gs_TobeStudiedProblem_GetObjFromJsonObj(returnObj);
return objgs_TobeStudiedProblem;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
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
export async function gs_TobeStudiedProblem_GetObjLstAsync(strWhereCond: string): Promise<Array<clsgs_TobeStudiedProblemEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(gs_TobeStudiedProblem_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_TobeStudiedProblem_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
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
 * @param arrProblemId:关键字列表
 * @returns 对象列表
 **/
export async function gs_TobeStudiedProblem_GetObjLstByProblemIdLstAsync(arrProblemId: Array<string>): Promise<Array<clsgs_TobeStudiedProblemEN>>  
{
const strThisFuncName = "GetObjLstByProblemIdLstAsync";
const strAction = "GetObjLstByProblemIdLst";
const strUrl = GetWebApiUrl(gs_TobeStudiedProblem_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrProblemId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_TobeStudiedProblem_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
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
export async function gs_TobeStudiedProblem_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsgs_TobeStudiedProblemEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(gs_TobeStudiedProblem_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_TobeStudiedProblem_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
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
export async function gs_TobeStudiedProblem_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsgs_TobeStudiedProblemEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(gs_TobeStudiedProblem_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_TobeStudiedProblem_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
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
export async function gs_TobeStudiedProblem_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(gs_TobeStudiedProblem_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
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
export async function gs_TobeStudiedProblem_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsgs_TobeStudiedProblemEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(gs_TobeStudiedProblem_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_TobeStudiedProblem_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
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
 * @param strProblemId:关键字
 * @returns 获取删除的结果
 **/
export async function gs_TobeStudiedProblem_DelRecordAsync(strProblemId: string): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(gs_TobeStudiedProblem_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, strProblemId);
try
{
const response = await axios.delete(strUrl,
{
params: { "Id": strProblemId, }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
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
 * @param arrProblemId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function gs_TobeStudiedProblem_Delgs_TobeStudiedProblemsAsync(arrProblemId: Array<string>): Promise<number> 
{
const strThisFuncName = "Delgs_TobeStudiedProblemsAsync";
const strAction = "Delgs_TobeStudiedProblems";
const strUrl = GetWebApiUrl(gs_TobeStudiedProblem_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrProblemId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
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
export async function gs_TobeStudiedProblem_Delgs_TobeStudiedProblemsByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "Delgs_TobeStudiedProblemsByCondAsync";
const strAction = "Delgs_TobeStudiedProblemsByCond";
const strUrl = GetWebApiUrl(gs_TobeStudiedProblem_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
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
 * @param objgs_TobeStudiedProblemEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_TobeStudiedProblem_AddNewRecordAsync(objgs_TobeStudiedProblemEN: clsgs_TobeStudiedProblemEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objgs_TobeStudiedProblemEN);
const strUrl = GetWebApiUrl(gs_TobeStudiedProblem_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_TobeStudiedProblemEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
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
 * @param objgs_TobeStudiedProblemEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_TobeStudiedProblem_AddNewRecordWithMaxIdAsync(objgs_TobeStudiedProblemEN: clsgs_TobeStudiedProblemEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithMaxIdAsync";
const strAction = "AddNewRecordWithMaxId";
const strUrl = GetWebApiUrl(gs_TobeStudiedProblem_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_TobeStudiedProblemEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
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
 * @param objgs_TobeStudiedProblemEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function gs_TobeStudiedProblem_AddNewRecordWithReturnKeyAsync(objgs_TobeStudiedProblemEN: clsgs_TobeStudiedProblemEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(gs_TobeStudiedProblem_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_TobeStudiedProblemEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
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
 * @param objgs_TobeStudiedProblemEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function gs_TobeStudiedProblem_AddNewRecordWithReturnKey(objgs_TobeStudiedProblemEN: clsgs_TobeStudiedProblemEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objgs_TobeStudiedProblemEN.problemId === null || objgs_TobeStudiedProblemEN.problemId === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(gs_TobeStudiedProblem_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_TobeStudiedProblemEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
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
 * @param objgs_TobeStudiedProblemEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function gs_TobeStudiedProblem_UpdateRecordAsync(objgs_TobeStudiedProblemEN: clsgs_TobeStudiedProblemEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objgs_TobeStudiedProblemEN.sf_UpdFldSetStr === undefined || objgs_TobeStudiedProblemEN.sf_UpdFldSetStr === null || objgs_TobeStudiedProblemEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_TobeStudiedProblemEN.problemId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(gs_TobeStudiedProblem_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_TobeStudiedProblemEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
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
 * @param objgs_TobeStudiedProblemEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function gs_TobeStudiedProblem_UpdateWithConditionAsync(objgs_TobeStudiedProblemEN: clsgs_TobeStudiedProblemEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objgs_TobeStudiedProblemEN.sf_UpdFldSetStr === undefined || objgs_TobeStudiedProblemEN.sf_UpdFldSetStr === null || objgs_TobeStudiedProblemEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_TobeStudiedProblemEN.problemId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(gs_TobeStudiedProblem_Controller, strAction);
objgs_TobeStudiedProblemEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objgs_TobeStudiedProblemEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
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
export async function gs_TobeStudiedProblem_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(gs_TobeStudiedProblem_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
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
 * @param strProblemId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function gs_TobeStudiedProblem_IsExist(strProblemId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(gs_TobeStudiedProblem_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"ProblemId": strProblemId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
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
 * @param strProblemId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function gs_TobeStudiedProblem_IsExistAsync(strProblemId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(gs_TobeStudiedProblem_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strProblemId": strProblemId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
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
export async function gs_TobeStudiedProblem_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(gs_TobeStudiedProblem_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
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
 * 获取表的最大关键字
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdAsync)
 * @returns 获取表的最大关键字
 **/
export async function gs_TobeStudiedProblem_GetMaxStrIdAsync(): Promise<string>  
{
const strThisFuncName = "GetMaxStrIdAsync";
const strAction = "GetMaxStrId";
const strUrl = GetWebApiUrl(gs_TobeStudiedProblem_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
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
export async function gs_TobeStudiedProblem_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(gs_TobeStudiedProblem_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TobeStudiedProblem_ConstructorName, strThisFuncName);
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
export function gs_TobeStudiedProblem_GetWebApiUrl(strController: string, strAction: string): string {
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
export function gs_TobeStudiedProblem_CheckPropertyNew(pobjgs_TobeStudiedProblemEN: clsgs_TobeStudiedProblemEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemEN.problemId) == false && GetStrLen(pobjgs_TobeStudiedProblemEN.problemId) > 10)
{
 throw new Error("(errid:Watl000059)字段[问题Id(problemId)]的长度不能超过10(In 待研究问题(gs_TobeStudiedProblem))!值:$(pobjgs_TobeStudiedProblemEN.problemId)(clsgs_TobeStudiedProblemBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemEN.problemTitle) == false && GetStrLen(pobjgs_TobeStudiedProblemEN.problemTitle) > 1000)
{
 throw new Error("(errid:Watl000059)字段[问题标题(problemTitle)]的长度不能超过1000(In 待研究问题(gs_TobeStudiedProblem))!值:$(pobjgs_TobeStudiedProblemEN.problemTitle)(clsgs_TobeStudiedProblemBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemEN.topicId) == false && GetStrLen(pobjgs_TobeStudiedProblemEN.topicId) > 8)
{
 throw new Error("(errid:Watl000059)字段[主题Id(topicId)]的长度不能超过8(In 待研究问题(gs_TobeStudiedProblem))!值:$(pobjgs_TobeStudiedProblemEN.topicId)(clsgs_TobeStudiedProblemBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemEN.problemDate) == false && GetStrLen(pobjgs_TobeStudiedProblemEN.problemDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[问题日期(problemDate)]的长度不能超过20(In 待研究问题(gs_TobeStudiedProblem))!值:$(pobjgs_TobeStudiedProblemEN.problemDate)(clsgs_TobeStudiedProblemBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemEN.updDate) == false && GetStrLen(pobjgs_TobeStudiedProblemEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 待研究问题(gs_TobeStudiedProblem))!值:$(pobjgs_TobeStudiedProblemEN.updDate)(clsgs_TobeStudiedProblemBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemEN.updUser) == false && GetStrLen(pobjgs_TobeStudiedProblemEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 待研究问题(gs_TobeStudiedProblem))!值:$(pobjgs_TobeStudiedProblemEN.updUser)(clsgs_TobeStudiedProblemBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemEN.year) == false && GetStrLen(pobjgs_TobeStudiedProblemEN.year) > 4)
{
 throw new Error("(errid:Watl000059)字段[年(year)]的长度不能超过4(In 待研究问题(gs_TobeStudiedProblem))!值:$(pobjgs_TobeStudiedProblemEN.year)(clsgs_TobeStudiedProblemBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemEN.month) == false && GetStrLen(pobjgs_TobeStudiedProblemEN.month) > 2)
{
 throw new Error("(errid:Watl000059)字段[月(month)]的长度不能超过2(In 待研究问题(gs_TobeStudiedProblem))!值:$(pobjgs_TobeStudiedProblemEN.month)(clsgs_TobeStudiedProblemBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemEN.participant) == false && GetStrLen(pobjgs_TobeStudiedProblemEN.participant) > 500)
{
 throw new Error("(errid:Watl000059)字段[参与者(participant)]的长度不能超过500(In 待研究问题(gs_TobeStudiedProblem))!值:$(pobjgs_TobeStudiedProblemEN.participant)(clsgs_TobeStudiedProblemBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemEN.memo) == false && GetStrLen(pobjgs_TobeStudiedProblemEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 待研究问题(gs_TobeStudiedProblem))!值:$(pobjgs_TobeStudiedProblemEN.memo)(clsgs_TobeStudiedProblemBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemEN.id_CurrEduCls) == false && GetStrLen(pobjgs_TobeStudiedProblemEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 待研究问题(gs_TobeStudiedProblem))!值:$(pobjgs_TobeStudiedProblemEN.id_CurrEduCls)(clsgs_TobeStudiedProblemBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemEN.problemId) == false && undefined !== pobjgs_TobeStudiedProblemEN.problemId && tzDataType.isString(pobjgs_TobeStudiedProblemEN.problemId) === false)
{
 throw new Error("(errid:Watl000060)字段[问题Id(problemId)]的值:[$(pobjgs_TobeStudiedProblemEN.problemId)], 非法，应该为字符型(In 待研究问题(gs_TobeStudiedProblem))!(clsgs_TobeStudiedProblemBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemEN.problemTitle) == false && undefined !== pobjgs_TobeStudiedProblemEN.problemTitle && tzDataType.isString(pobjgs_TobeStudiedProblemEN.problemTitle) === false)
{
 throw new Error("(errid:Watl000060)字段[问题标题(problemTitle)]的值:[$(pobjgs_TobeStudiedProblemEN.problemTitle)], 非法，应该为字符型(In 待研究问题(gs_TobeStudiedProblem))!(clsgs_TobeStudiedProblemBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemEN.problemContent) == false && undefined !== pobjgs_TobeStudiedProblemEN.problemContent && tzDataType.isString(pobjgs_TobeStudiedProblemEN.problemContent) === false)
{
 throw new Error("(errid:Watl000060)字段[问题内容(problemContent)]的值:[$(pobjgs_TobeStudiedProblemEN.problemContent)], 非法，应该为字符型(In 待研究问题(gs_TobeStudiedProblem))!(clsgs_TobeStudiedProblemBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemEN.topicId) == false && undefined !== pobjgs_TobeStudiedProblemEN.topicId && tzDataType.isString(pobjgs_TobeStudiedProblemEN.topicId) === false)
{
 throw new Error("(errid:Watl000060)字段[主题Id(topicId)]的值:[$(pobjgs_TobeStudiedProblemEN.topicId)], 非法，应该为字符型(In 待研究问题(gs_TobeStudiedProblem))!(clsgs_TobeStudiedProblemBL:CheckPropertyNew)");
}
if (null != pobjgs_TobeStudiedProblemEN.isSubmit && undefined !== pobjgs_TobeStudiedProblemEN.isSubmit && tzDataType.isBoolean(pobjgs_TobeStudiedProblemEN.isSubmit) === false)
{
 throw new Error("(errid:Watl000060)字段[是否提交(isSubmit)]的值:[$(pobjgs_TobeStudiedProblemEN.isSubmit)], 非法，应该为布尔型(In 待研究问题(gs_TobeStudiedProblem))!(clsgs_TobeStudiedProblemBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemEN.problemDate) == false && undefined !== pobjgs_TobeStudiedProblemEN.problemDate && tzDataType.isString(pobjgs_TobeStudiedProblemEN.problemDate) === false)
{
 throw new Error("(errid:Watl000060)字段[问题日期(problemDate)]的值:[$(pobjgs_TobeStudiedProblemEN.problemDate)], 非法，应该为字符型(In 待研究问题(gs_TobeStudiedProblem))!(clsgs_TobeStudiedProblemBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemEN.updDate) == false && undefined !== pobjgs_TobeStudiedProblemEN.updDate && tzDataType.isString(pobjgs_TobeStudiedProblemEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjgs_TobeStudiedProblemEN.updDate)], 非法，应该为字符型(In 待研究问题(gs_TobeStudiedProblem))!(clsgs_TobeStudiedProblemBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemEN.updUser) == false && undefined !== pobjgs_TobeStudiedProblemEN.updUser && tzDataType.isString(pobjgs_TobeStudiedProblemEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjgs_TobeStudiedProblemEN.updUser)], 非法，应该为字符型(In 待研究问题(gs_TobeStudiedProblem))!(clsgs_TobeStudiedProblemBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemEN.year) == false && undefined !== pobjgs_TobeStudiedProblemEN.year && tzDataType.isString(pobjgs_TobeStudiedProblemEN.year) === false)
{
 throw new Error("(errid:Watl000060)字段[年(year)]的值:[$(pobjgs_TobeStudiedProblemEN.year)], 非法，应该为字符型(In 待研究问题(gs_TobeStudiedProblem))!(clsgs_TobeStudiedProblemBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemEN.month) == false && undefined !== pobjgs_TobeStudiedProblemEN.month && tzDataType.isString(pobjgs_TobeStudiedProblemEN.month) === false)
{
 throw new Error("(errid:Watl000060)字段[月(month)]的值:[$(pobjgs_TobeStudiedProblemEN.month)], 非法，应该为字符型(In 待研究问题(gs_TobeStudiedProblem))!(clsgs_TobeStudiedProblemBL:CheckPropertyNew)");
}
if (null != pobjgs_TobeStudiedProblemEN.versionCount && undefined !== pobjgs_TobeStudiedProblemEN.versionCount && tzDataType.isNumber(pobjgs_TobeStudiedProblemEN.versionCount) === false)
{
 throw new Error("(errid:Watl000060)字段[版本统计(versionCount)]的值:[$(pobjgs_TobeStudiedProblemEN.versionCount)], 非法，应该为数值型(In 待研究问题(gs_TobeStudiedProblem))!(clsgs_TobeStudiedProblemBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemEN.participant) == false && undefined !== pobjgs_TobeStudiedProblemEN.participant && tzDataType.isString(pobjgs_TobeStudiedProblemEN.participant) === false)
{
 throw new Error("(errid:Watl000060)字段[参与者(participant)]的值:[$(pobjgs_TobeStudiedProblemEN.participant)], 非法，应该为字符型(In 待研究问题(gs_TobeStudiedProblem))!(clsgs_TobeStudiedProblemBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemEN.memo) == false && undefined !== pobjgs_TobeStudiedProblemEN.memo && tzDataType.isString(pobjgs_TobeStudiedProblemEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjgs_TobeStudiedProblemEN.memo)], 非法，应该为字符型(In 待研究问题(gs_TobeStudiedProblem))!(clsgs_TobeStudiedProblemBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemEN.id_CurrEduCls) == false && undefined !== pobjgs_TobeStudiedProblemEN.id_CurrEduCls && tzDataType.isString(pobjgs_TobeStudiedProblemEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjgs_TobeStudiedProblemEN.id_CurrEduCls)], 非法，应该为字符型(In 待研究问题(gs_TobeStudiedProblem))!(clsgs_TobeStudiedProblemBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjgs_TobeStudiedProblemEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function gs_TobeStudiedProblem_CheckProperty4Update (pobjgs_TobeStudiedProblemEN: clsgs_TobeStudiedProblemEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemEN.problemId) == false && GetStrLen(pobjgs_TobeStudiedProblemEN.problemId) > 10)
{
 throw new Error("(errid:Watl000062)字段[问题Id(problemId)]的长度不能超过10(In 待研究问题(gs_TobeStudiedProblem))!值:$(pobjgs_TobeStudiedProblemEN.problemId)(clsgs_TobeStudiedProblemBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemEN.problemTitle) == false && GetStrLen(pobjgs_TobeStudiedProblemEN.problemTitle) > 1000)
{
 throw new Error("(errid:Watl000062)字段[问题标题(problemTitle)]的长度不能超过1000(In 待研究问题(gs_TobeStudiedProblem))!值:$(pobjgs_TobeStudiedProblemEN.problemTitle)(clsgs_TobeStudiedProblemBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemEN.topicId) == false && GetStrLen(pobjgs_TobeStudiedProblemEN.topicId) > 8)
{
 throw new Error("(errid:Watl000062)字段[主题Id(topicId)]的长度不能超过8(In 待研究问题(gs_TobeStudiedProblem))!值:$(pobjgs_TobeStudiedProblemEN.topicId)(clsgs_TobeStudiedProblemBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemEN.problemDate) == false && GetStrLen(pobjgs_TobeStudiedProblemEN.problemDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[问题日期(problemDate)]的长度不能超过20(In 待研究问题(gs_TobeStudiedProblem))!值:$(pobjgs_TobeStudiedProblemEN.problemDate)(clsgs_TobeStudiedProblemBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemEN.updDate) == false && GetStrLen(pobjgs_TobeStudiedProblemEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 待研究问题(gs_TobeStudiedProblem))!值:$(pobjgs_TobeStudiedProblemEN.updDate)(clsgs_TobeStudiedProblemBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemEN.updUser) == false && GetStrLen(pobjgs_TobeStudiedProblemEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 待研究问题(gs_TobeStudiedProblem))!值:$(pobjgs_TobeStudiedProblemEN.updUser)(clsgs_TobeStudiedProblemBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemEN.year) == false && GetStrLen(pobjgs_TobeStudiedProblemEN.year) > 4)
{
 throw new Error("(errid:Watl000062)字段[年(year)]的长度不能超过4(In 待研究问题(gs_TobeStudiedProblem))!值:$(pobjgs_TobeStudiedProblemEN.year)(clsgs_TobeStudiedProblemBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemEN.month) == false && GetStrLen(pobjgs_TobeStudiedProblemEN.month) > 2)
{
 throw new Error("(errid:Watl000062)字段[月(month)]的长度不能超过2(In 待研究问题(gs_TobeStudiedProblem))!值:$(pobjgs_TobeStudiedProblemEN.month)(clsgs_TobeStudiedProblemBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemEN.participant) == false && GetStrLen(pobjgs_TobeStudiedProblemEN.participant) > 500)
{
 throw new Error("(errid:Watl000062)字段[参与者(participant)]的长度不能超过500(In 待研究问题(gs_TobeStudiedProblem))!值:$(pobjgs_TobeStudiedProblemEN.participant)(clsgs_TobeStudiedProblemBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemEN.memo) == false && GetStrLen(pobjgs_TobeStudiedProblemEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 待研究问题(gs_TobeStudiedProblem))!值:$(pobjgs_TobeStudiedProblemEN.memo)(clsgs_TobeStudiedProblemBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemEN.id_CurrEduCls) == false && GetStrLen(pobjgs_TobeStudiedProblemEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 待研究问题(gs_TobeStudiedProblem))!值:$(pobjgs_TobeStudiedProblemEN.id_CurrEduCls)(clsgs_TobeStudiedProblemBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemEN.problemId) == false && undefined !== pobjgs_TobeStudiedProblemEN.problemId && tzDataType.isString(pobjgs_TobeStudiedProblemEN.problemId) === false)
{
 throw new Error("(errid:Watl000063)字段[问题Id(problemId)]的值:[$(pobjgs_TobeStudiedProblemEN.problemId)], 非法，应该为字符型(In 待研究问题(gs_TobeStudiedProblem))!(clsgs_TobeStudiedProblemBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemEN.problemTitle) == false && undefined !== pobjgs_TobeStudiedProblemEN.problemTitle && tzDataType.isString(pobjgs_TobeStudiedProblemEN.problemTitle) === false)
{
 throw new Error("(errid:Watl000063)字段[问题标题(problemTitle)]的值:[$(pobjgs_TobeStudiedProblemEN.problemTitle)], 非法，应该为字符型(In 待研究问题(gs_TobeStudiedProblem))!(clsgs_TobeStudiedProblemBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemEN.problemContent) == false && undefined !== pobjgs_TobeStudiedProblemEN.problemContent && tzDataType.isString(pobjgs_TobeStudiedProblemEN.problemContent) === false)
{
 throw new Error("(errid:Watl000063)字段[问题内容(problemContent)]的值:[$(pobjgs_TobeStudiedProblemEN.problemContent)], 非法，应该为字符型(In 待研究问题(gs_TobeStudiedProblem))!(clsgs_TobeStudiedProblemBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemEN.topicId) == false && undefined !== pobjgs_TobeStudiedProblemEN.topicId && tzDataType.isString(pobjgs_TobeStudiedProblemEN.topicId) === false)
{
 throw new Error("(errid:Watl000063)字段[主题Id(topicId)]的值:[$(pobjgs_TobeStudiedProblemEN.topicId)], 非法，应该为字符型(In 待研究问题(gs_TobeStudiedProblem))!(clsgs_TobeStudiedProblemBL:CheckProperty4Update)");
}
if (null != pobjgs_TobeStudiedProblemEN.isSubmit && undefined !== pobjgs_TobeStudiedProblemEN.isSubmit && tzDataType.isBoolean(pobjgs_TobeStudiedProblemEN.isSubmit) === false)
{
 throw new Error("(errid:Watl000063)字段[是否提交(isSubmit)]的值:[$(pobjgs_TobeStudiedProblemEN.isSubmit)], 非法，应该为布尔型(In 待研究问题(gs_TobeStudiedProblem))!(clsgs_TobeStudiedProblemBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemEN.problemDate) == false && undefined !== pobjgs_TobeStudiedProblemEN.problemDate && tzDataType.isString(pobjgs_TobeStudiedProblemEN.problemDate) === false)
{
 throw new Error("(errid:Watl000063)字段[问题日期(problemDate)]的值:[$(pobjgs_TobeStudiedProblemEN.problemDate)], 非法，应该为字符型(In 待研究问题(gs_TobeStudiedProblem))!(clsgs_TobeStudiedProblemBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemEN.updDate) == false && undefined !== pobjgs_TobeStudiedProblemEN.updDate && tzDataType.isString(pobjgs_TobeStudiedProblemEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjgs_TobeStudiedProblemEN.updDate)], 非法，应该为字符型(In 待研究问题(gs_TobeStudiedProblem))!(clsgs_TobeStudiedProblemBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemEN.updUser) == false && undefined !== pobjgs_TobeStudiedProblemEN.updUser && tzDataType.isString(pobjgs_TobeStudiedProblemEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjgs_TobeStudiedProblemEN.updUser)], 非法，应该为字符型(In 待研究问题(gs_TobeStudiedProblem))!(clsgs_TobeStudiedProblemBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemEN.year) == false && undefined !== pobjgs_TobeStudiedProblemEN.year && tzDataType.isString(pobjgs_TobeStudiedProblemEN.year) === false)
{
 throw new Error("(errid:Watl000063)字段[年(year)]的值:[$(pobjgs_TobeStudiedProblemEN.year)], 非法，应该为字符型(In 待研究问题(gs_TobeStudiedProblem))!(clsgs_TobeStudiedProblemBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemEN.month) == false && undefined !== pobjgs_TobeStudiedProblemEN.month && tzDataType.isString(pobjgs_TobeStudiedProblemEN.month) === false)
{
 throw new Error("(errid:Watl000063)字段[月(month)]的值:[$(pobjgs_TobeStudiedProblemEN.month)], 非法，应该为字符型(In 待研究问题(gs_TobeStudiedProblem))!(clsgs_TobeStudiedProblemBL:CheckProperty4Update)");
}
if (null != pobjgs_TobeStudiedProblemEN.versionCount && undefined !== pobjgs_TobeStudiedProblemEN.versionCount && tzDataType.isNumber(pobjgs_TobeStudiedProblemEN.versionCount) === false)
{
 throw new Error("(errid:Watl000063)字段[版本统计(versionCount)]的值:[$(pobjgs_TobeStudiedProblemEN.versionCount)], 非法，应该为数值型(In 待研究问题(gs_TobeStudiedProblem))!(clsgs_TobeStudiedProblemBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemEN.participant) == false && undefined !== pobjgs_TobeStudiedProblemEN.participant && tzDataType.isString(pobjgs_TobeStudiedProblemEN.participant) === false)
{
 throw new Error("(errid:Watl000063)字段[参与者(participant)]的值:[$(pobjgs_TobeStudiedProblemEN.participant)], 非法，应该为字符型(In 待研究问题(gs_TobeStudiedProblem))!(clsgs_TobeStudiedProblemBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemEN.memo) == false && undefined !== pobjgs_TobeStudiedProblemEN.memo && tzDataType.isString(pobjgs_TobeStudiedProblemEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjgs_TobeStudiedProblemEN.memo)], 非法，应该为字符型(In 待研究问题(gs_TobeStudiedProblem))!(clsgs_TobeStudiedProblemBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemEN.id_CurrEduCls) == false && undefined !== pobjgs_TobeStudiedProblemEN.id_CurrEduCls && tzDataType.isString(pobjgs_TobeStudiedProblemEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjgs_TobeStudiedProblemEN.id_CurrEduCls)], 非法，应该为字符型(In 待研究问题(gs_TobeStudiedProblem))!(clsgs_TobeStudiedProblemBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (IsNullOrEmpty(pobjgs_TobeStudiedProblemEN.problemId) === true )
{
 throw new Error("(errid:Watl000064)字段[问题Id]不能为空(In 待研究问题)!(clsgs_TobeStudiedProblemBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjgs_TobeStudiedProblemEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function gs_TobeStudiedProblem_GetJSONStrByObj (pobjgs_TobeStudiedProblemEN: clsgs_TobeStudiedProblemEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjgs_TobeStudiedProblemEN.sf_UpdFldSetStr = pobjgs_TobeStudiedProblemEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjgs_TobeStudiedProblemEN);
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
export function gs_TobeStudiedProblem_GetObjLstByJSONStr (strJSON: string): Array<clsgs_TobeStudiedProblemEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrgs_TobeStudiedProblemObjLst = new Array<clsgs_TobeStudiedProblemEN>();
if (strJSON === "")
{
return arrgs_TobeStudiedProblemObjLst;
}
try
{
arrgs_TobeStudiedProblemObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrgs_TobeStudiedProblemObjLst;
}
return arrgs_TobeStudiedProblemObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrgs_TobeStudiedProblemObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function gs_TobeStudiedProblem_GetObjLstByJSONObjLst (arrgs_TobeStudiedProblemObjLstS: Array<clsgs_TobeStudiedProblemEN>): Array<clsgs_TobeStudiedProblemEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrgs_TobeStudiedProblemObjLst = new Array<clsgs_TobeStudiedProblemEN>();
for (const objInFor of arrgs_TobeStudiedProblemObjLstS) {
const obj1 = gs_TobeStudiedProblem_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrgs_TobeStudiedProblemObjLst.push(obj1);
}
return arrgs_TobeStudiedProblemObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function gs_TobeStudiedProblem_GetObjByJSONStr (strJSON: string): clsgs_TobeStudiedProblemEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjgs_TobeStudiedProblemEN = new clsgs_TobeStudiedProblemEN();
if (strJSON === "")
{
return pobjgs_TobeStudiedProblemEN;
}
try
{
pobjgs_TobeStudiedProblemEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjgs_TobeStudiedProblemEN;
}
return pobjgs_TobeStudiedProblemEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function gs_TobeStudiedProblem_GetCombineCondition(objgs_TobeStudiedProblem_Cond: clsgs_TobeStudiedProblemEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objgs_TobeStudiedProblem_Cond.dicFldComparisonOp, clsgs_TobeStudiedProblemEN.con_ProblemId) == true)
{
const strComparisonOp_ProblemId:string = objgs_TobeStudiedProblem_Cond.dicFldComparisonOp[clsgs_TobeStudiedProblemEN.con_ProblemId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TobeStudiedProblemEN.con_ProblemId, objgs_TobeStudiedProblem_Cond.problemId, strComparisonOp_ProblemId);
}
if (Object.prototype.hasOwnProperty.call(objgs_TobeStudiedProblem_Cond.dicFldComparisonOp, clsgs_TobeStudiedProblemEN.con_ProblemTitle) == true)
{
const strComparisonOp_ProblemTitle:string = objgs_TobeStudiedProblem_Cond.dicFldComparisonOp[clsgs_TobeStudiedProblemEN.con_ProblemTitle];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TobeStudiedProblemEN.con_ProblemTitle, objgs_TobeStudiedProblem_Cond.problemTitle, strComparisonOp_ProblemTitle);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objgs_TobeStudiedProblem_Cond.dicFldComparisonOp, clsgs_TobeStudiedProblemEN.con_TopicId) == true)
{
const strComparisonOp_TopicId:string = objgs_TobeStudiedProblem_Cond.dicFldComparisonOp[clsgs_TobeStudiedProblemEN.con_TopicId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TobeStudiedProblemEN.con_TopicId, objgs_TobeStudiedProblem_Cond.topicId, strComparisonOp_TopicId);
}
if (Object.prototype.hasOwnProperty.call(objgs_TobeStudiedProblem_Cond.dicFldComparisonOp, clsgs_TobeStudiedProblemEN.con_IsSubmit) == true)
{
if (objgs_TobeStudiedProblem_Cond.isSubmit == true)
{
strWhereCond += Format(" And {0} = '1'", clsgs_TobeStudiedProblemEN.con_IsSubmit);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsgs_TobeStudiedProblemEN.con_IsSubmit);
}
}
if (Object.prototype.hasOwnProperty.call(objgs_TobeStudiedProblem_Cond.dicFldComparisonOp, clsgs_TobeStudiedProblemEN.con_ProblemDate) == true)
{
const strComparisonOp_ProblemDate:string = objgs_TobeStudiedProblem_Cond.dicFldComparisonOp[clsgs_TobeStudiedProblemEN.con_ProblemDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TobeStudiedProblemEN.con_ProblemDate, objgs_TobeStudiedProblem_Cond.problemDate, strComparisonOp_ProblemDate);
}
if (Object.prototype.hasOwnProperty.call(objgs_TobeStudiedProblem_Cond.dicFldComparisonOp, clsgs_TobeStudiedProblemEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objgs_TobeStudiedProblem_Cond.dicFldComparisonOp[clsgs_TobeStudiedProblemEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TobeStudiedProblemEN.con_UpdDate, objgs_TobeStudiedProblem_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objgs_TobeStudiedProblem_Cond.dicFldComparisonOp, clsgs_TobeStudiedProblemEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objgs_TobeStudiedProblem_Cond.dicFldComparisonOp[clsgs_TobeStudiedProblemEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TobeStudiedProblemEN.con_UpdUser, objgs_TobeStudiedProblem_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objgs_TobeStudiedProblem_Cond.dicFldComparisonOp, clsgs_TobeStudiedProblemEN.con_Year) == true)
{
const strComparisonOp_Year:string = objgs_TobeStudiedProblem_Cond.dicFldComparisonOp[clsgs_TobeStudiedProblemEN.con_Year];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TobeStudiedProblemEN.con_Year, objgs_TobeStudiedProblem_Cond.year, strComparisonOp_Year);
}
if (Object.prototype.hasOwnProperty.call(objgs_TobeStudiedProblem_Cond.dicFldComparisonOp, clsgs_TobeStudiedProblemEN.con_Month) == true)
{
const strComparisonOp_Month:string = objgs_TobeStudiedProblem_Cond.dicFldComparisonOp[clsgs_TobeStudiedProblemEN.con_Month];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TobeStudiedProblemEN.con_Month, objgs_TobeStudiedProblem_Cond.month, strComparisonOp_Month);
}
if (Object.prototype.hasOwnProperty.call(objgs_TobeStudiedProblem_Cond.dicFldComparisonOp, clsgs_TobeStudiedProblemEN.con_VersionCount) == true)
{
const strComparisonOp_VersionCount:string = objgs_TobeStudiedProblem_Cond.dicFldComparisonOp[clsgs_TobeStudiedProblemEN.con_VersionCount];
strWhereCond += Format(" And {0} {2} {1}", clsgs_TobeStudiedProblemEN.con_VersionCount, objgs_TobeStudiedProblem_Cond.versionCount, strComparisonOp_VersionCount);
}
if (Object.prototype.hasOwnProperty.call(objgs_TobeStudiedProblem_Cond.dicFldComparisonOp, clsgs_TobeStudiedProblemEN.con_Participant) == true)
{
const strComparisonOp_Participant:string = objgs_TobeStudiedProblem_Cond.dicFldComparisonOp[clsgs_TobeStudiedProblemEN.con_Participant];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TobeStudiedProblemEN.con_Participant, objgs_TobeStudiedProblem_Cond.participant, strComparisonOp_Participant);
}
if (Object.prototype.hasOwnProperty.call(objgs_TobeStudiedProblem_Cond.dicFldComparisonOp, clsgs_TobeStudiedProblemEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objgs_TobeStudiedProblem_Cond.dicFldComparisonOp[clsgs_TobeStudiedProblemEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TobeStudiedProblemEN.con_Memo, objgs_TobeStudiedProblem_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objgs_TobeStudiedProblem_Cond.dicFldComparisonOp, clsgs_TobeStudiedProblemEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objgs_TobeStudiedProblem_Cond.dicFldComparisonOp[clsgs_TobeStudiedProblemEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TobeStudiedProblemEN.con_id_CurrEduCls, objgs_TobeStudiedProblem_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--gs_TobeStudiedProblem(待研究问题),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param strProblemId: 问题Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function gs_TobeStudiedProblem_GetUniCondStr_ProblemId(objgs_TobeStudiedProblemEN: clsgs_TobeStudiedProblemEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and ProblemId = '{0}'", objgs_TobeStudiedProblemEN.problemId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--gs_TobeStudiedProblem(待研究问题),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param strProblemId: 问题Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function gs_TobeStudiedProblem_GetUniCondStr4Update_ProblemId(objgs_TobeStudiedProblemEN: clsgs_TobeStudiedProblemEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and ProblemId <> '{0}'", objgs_TobeStudiedProblemEN.problemId);
 strWhereCond +=  Format(" and ProblemId = '{0}'", objgs_TobeStudiedProblemEN.problemId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objgs_TobeStudiedProblemENS:源对象
 * @param objgs_TobeStudiedProblemENT:目标对象
*/
export function gs_TobeStudiedProblem_CopyObjTo(objgs_TobeStudiedProblemENS: clsgs_TobeStudiedProblemEN , objgs_TobeStudiedProblemENT: clsgs_TobeStudiedProblemEN ): void 
{
objgs_TobeStudiedProblemENT.problemId = objgs_TobeStudiedProblemENS.problemId; //问题Id
objgs_TobeStudiedProblemENT.problemTitle = objgs_TobeStudiedProblemENS.problemTitle; //问题标题
objgs_TobeStudiedProblemENT.problemContent = objgs_TobeStudiedProblemENS.problemContent; //问题内容
objgs_TobeStudiedProblemENT.topicId = objgs_TobeStudiedProblemENS.topicId; //主题Id
objgs_TobeStudiedProblemENT.isSubmit = objgs_TobeStudiedProblemENS.isSubmit; //是否提交
objgs_TobeStudiedProblemENT.problemDate = objgs_TobeStudiedProblemENS.problemDate; //问题日期
objgs_TobeStudiedProblemENT.updDate = objgs_TobeStudiedProblemENS.updDate; //修改日期
objgs_TobeStudiedProblemENT.updUser = objgs_TobeStudiedProblemENS.updUser; //修改人
objgs_TobeStudiedProblemENT.year = objgs_TobeStudiedProblemENS.year; //年
objgs_TobeStudiedProblemENT.month = objgs_TobeStudiedProblemENS.month; //月
objgs_TobeStudiedProblemENT.versionCount = objgs_TobeStudiedProblemENS.versionCount; //版本统计
objgs_TobeStudiedProblemENT.participant = objgs_TobeStudiedProblemENS.participant; //参与者
objgs_TobeStudiedProblemENT.memo = objgs_TobeStudiedProblemENS.memo; //备注
objgs_TobeStudiedProblemENT.id_CurrEduCls = objgs_TobeStudiedProblemENS.id_CurrEduCls; //教学班流水号
objgs_TobeStudiedProblemENT.sf_UpdFldSetStr = objgs_TobeStudiedProblemENS.updFldString; //sf_UpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objgs_TobeStudiedProblemENS:源对象
 * @param objgs_TobeStudiedProblemENT:目标对象
*/
export function gs_TobeStudiedProblem_GetObjFromJsonObj(objgs_TobeStudiedProblemENS: clsgs_TobeStudiedProblemEN): clsgs_TobeStudiedProblemEN 
{
 const objgs_TobeStudiedProblemENT: clsgs_TobeStudiedProblemEN = new clsgs_TobeStudiedProblemEN();
ObjectAssign(objgs_TobeStudiedProblemENT, objgs_TobeStudiedProblemENS);
 return objgs_TobeStudiedProblemENT;
}