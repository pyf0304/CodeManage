
 /**
 * 类名:clsgs_ResearchResultWApi
 * 表名:gs_ResearchResult(01120780)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:48:31
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
 * 研究成果(gs_ResearchResult)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2023年03月13日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { enumComparisonOp } from "../../PubFun/enumComparisonOp.js";
import { clsgs_ResearchResultEN } from "../../L0_Entity/GraduateEduTopic/clsgs_ResearchResultEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { tzDataType } from "../../PubFun/clsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const gs_ResearchResult_Controller = "gs_ResearchResultApi";
 export const gs_ResearchResult_ConstructorName = "gs_ResearchResult";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strResultId:关键字
 * @returns 对象
 **/
export async function gs_ResearchResult_GetObjByResultIdAsync(strResultId: string): Promise<clsgs_ResearchResultEN|null>  
{
const strThisFuncName = "GetObjByResultIdAsync";

if (IsNullOrEmpty(strResultId) == true)
{
  const strMsg = Format("参数:[strResultId]不能为空！(In clsgs_ResearchResultWApi.GetObjByResultIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strResultId.length != 10)
{
const strMsg = Format("缓存分类变量:[strResultId]的长度:[{0}]不正确！(clsgs_ResearchResultWApi.GetObjByResultIdAsync)", strResultId.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByResultId";
const strUrl = GetWebApiUrl(gs_ResearchResult_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strResultId": strResultId,
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
const objgs_ResearchResult = gs_ResearchResult_GetObjFromJsonObj(returnObj);
return objgs_ResearchResult;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchResult_ConstructorName, strThisFuncName);
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
export function gs_ResearchResult_SortFun_Defa(a:clsgs_ResearchResultEN , b:clsgs_ResearchResultEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.resultId.localeCompare(b.resultId);
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
export function gs_ResearchResult_SortFun_Defa_2Fld(a:clsgs_ResearchResultEN , b:clsgs_ResearchResultEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.topicId == b.topicId) return a.paperId.localeCompare(b.paperId);
else return a.topicId.localeCompare(b.topicId);
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
export function gs_ResearchResult_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsgs_ResearchResultEN.con_ResultId:
return (a: clsgs_ResearchResultEN, b: clsgs_ResearchResultEN) => {
return a.resultId.localeCompare(b.resultId);
}
case clsgs_ResearchResultEN.con_TopicId:
return (a: clsgs_ResearchResultEN, b: clsgs_ResearchResultEN) => {
if (a.topicId == null) return -1;
if (b.topicId == null) return 1;
return a.topicId.localeCompare(b.topicId);
}
case clsgs_ResearchResultEN.con_PaperId:
return (a: clsgs_ResearchResultEN, b: clsgs_ResearchResultEN) => {
if (a.paperId == null) return -1;
if (b.paperId == null) return 1;
return a.paperId.localeCompare(b.paperId);
}
case clsgs_ResearchResultEN.con_ResultTypeId:
return (a: clsgs_ResearchResultEN, b: clsgs_ResearchResultEN) => {
if (a.resultTypeId == null) return -1;
if (b.resultTypeId == null) return 1;
return a.resultTypeId.localeCompare(b.resultTypeId);
}
case clsgs_ResearchResultEN.con_ResultName:
return (a: clsgs_ResearchResultEN, b: clsgs_ResearchResultEN) => {
if (a.resultName == null) return -1;
if (b.resultName == null) return 1;
return a.resultName.localeCompare(b.resultName);
}
case clsgs_ResearchResultEN.con_ResultContent:
return (a: clsgs_ResearchResultEN, b: clsgs_ResearchResultEN) => {
if (a.resultContent == null) return -1;
if (b.resultContent == null) return 1;
return a.resultContent.localeCompare(b.resultContent);
}
case clsgs_ResearchResultEN.con_Author:
return (a: clsgs_ResearchResultEN, b: clsgs_ResearchResultEN) => {
if (a.author == null) return -1;
if (b.author == null) return 1;
return a.author.localeCompare(b.author);
}
case clsgs_ResearchResultEN.con_Division:
return (a: clsgs_ResearchResultEN, b: clsgs_ResearchResultEN) => {
if (a.division == null) return -1;
if (b.division == null) return 1;
return a.division.localeCompare(b.division);
}
case clsgs_ResearchResultEN.con_VersionCount:
return (a: clsgs_ResearchResultEN, b: clsgs_ResearchResultEN) => {
return a.versionCount-b.versionCount;
}
case clsgs_ResearchResultEN.con_OkCount:
return (a: clsgs_ResearchResultEN, b: clsgs_ResearchResultEN) => {
return a.okCount-b.okCount;
}
case clsgs_ResearchResultEN.con_AppraiseCount:
return (a: clsgs_ResearchResultEN, b: clsgs_ResearchResultEN) => {
return a.appraiseCount-b.appraiseCount;
}
case clsgs_ResearchResultEN.con_Score:
return (a: clsgs_ResearchResultEN, b: clsgs_ResearchResultEN) => {
return a.score-b.score;
}
case clsgs_ResearchResultEN.con_StuScore:
return (a: clsgs_ResearchResultEN, b: clsgs_ResearchResultEN) => {
return a.stuScore-b.stuScore;
}
case clsgs_ResearchResultEN.con_TeaScore:
return (a: clsgs_ResearchResultEN, b: clsgs_ResearchResultEN) => {
return a.teaScore-b.teaScore;
}
case clsgs_ResearchResultEN.con_id_CurrEduCls:
return (a: clsgs_ResearchResultEN, b: clsgs_ResearchResultEN) => {
if (a.id_CurrEduCls == null) return -1;
if (b.id_CurrEduCls == null) return 1;
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
case clsgs_ResearchResultEN.con_UpdDate:
return (a: clsgs_ResearchResultEN, b: clsgs_ResearchResultEN) => {
if (a.updDate == null) return -1;
if (b.updDate == null) return 1;
return a.updDate.localeCompare(b.updDate);
}
case clsgs_ResearchResultEN.con_UpdUser:
return (a: clsgs_ResearchResultEN, b: clsgs_ResearchResultEN) => {
if (a.updUser == null) return -1;
if (b.updUser == null) return 1;
return a.updUser.localeCompare(b.updUser);
}
case clsgs_ResearchResultEN.con_Memo:
return (a: clsgs_ResearchResultEN, b: clsgs_ResearchResultEN) => {
if (a.memo == null) return -1;
if (b.memo == null) return 1;
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_ResearchResult]中不存在！(in ${ gs_ResearchResult_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsgs_ResearchResultEN.con_ResultId:
return (a: clsgs_ResearchResultEN, b: clsgs_ResearchResultEN) => {
return b.resultId.localeCompare(a.resultId);
}
case clsgs_ResearchResultEN.con_TopicId:
return (a: clsgs_ResearchResultEN, b: clsgs_ResearchResultEN) => {
if (b.topicId == null) return -1;
if (a.topicId == null) return 1;
return b.topicId.localeCompare(a.topicId);
}
case clsgs_ResearchResultEN.con_PaperId:
return (a: clsgs_ResearchResultEN, b: clsgs_ResearchResultEN) => {
if (b.paperId == null) return -1;
if (a.paperId == null) return 1;
return b.paperId.localeCompare(a.paperId);
}
case clsgs_ResearchResultEN.con_ResultTypeId:
return (a: clsgs_ResearchResultEN, b: clsgs_ResearchResultEN) => {
if (b.resultTypeId == null) return -1;
if (a.resultTypeId == null) return 1;
return b.resultTypeId.localeCompare(a.resultTypeId);
}
case clsgs_ResearchResultEN.con_ResultName:
return (a: clsgs_ResearchResultEN, b: clsgs_ResearchResultEN) => {
if (b.resultName == null) return -1;
if (a.resultName == null) return 1;
return b.resultName.localeCompare(a.resultName);
}
case clsgs_ResearchResultEN.con_ResultContent:
return (a: clsgs_ResearchResultEN, b: clsgs_ResearchResultEN) => {
if (b.resultContent == null) return -1;
if (a.resultContent == null) return 1;
return b.resultContent.localeCompare(a.resultContent);
}
case clsgs_ResearchResultEN.con_Author:
return (a: clsgs_ResearchResultEN, b: clsgs_ResearchResultEN) => {
if (b.author == null) return -1;
if (a.author == null) return 1;
return b.author.localeCompare(a.author);
}
case clsgs_ResearchResultEN.con_Division:
return (a: clsgs_ResearchResultEN, b: clsgs_ResearchResultEN) => {
if (b.division == null) return -1;
if (a.division == null) return 1;
return b.division.localeCompare(a.division);
}
case clsgs_ResearchResultEN.con_VersionCount:
return (a: clsgs_ResearchResultEN, b: clsgs_ResearchResultEN) => {
return b.versionCount-a.versionCount;
}
case clsgs_ResearchResultEN.con_OkCount:
return (a: clsgs_ResearchResultEN, b: clsgs_ResearchResultEN) => {
return b.okCount-a.okCount;
}
case clsgs_ResearchResultEN.con_AppraiseCount:
return (a: clsgs_ResearchResultEN, b: clsgs_ResearchResultEN) => {
return b.appraiseCount-a.appraiseCount;
}
case clsgs_ResearchResultEN.con_Score:
return (a: clsgs_ResearchResultEN, b: clsgs_ResearchResultEN) => {
return b.score-a.score;
}
case clsgs_ResearchResultEN.con_StuScore:
return (a: clsgs_ResearchResultEN, b: clsgs_ResearchResultEN) => {
return b.stuScore-a.stuScore;
}
case clsgs_ResearchResultEN.con_TeaScore:
return (a: clsgs_ResearchResultEN, b: clsgs_ResearchResultEN) => {
return b.teaScore-a.teaScore;
}
case clsgs_ResearchResultEN.con_id_CurrEduCls:
return (a: clsgs_ResearchResultEN, b: clsgs_ResearchResultEN) => {
if (b.id_CurrEduCls == null) return -1;
if (a.id_CurrEduCls == null) return 1;
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
case clsgs_ResearchResultEN.con_UpdDate:
return (a: clsgs_ResearchResultEN, b: clsgs_ResearchResultEN) => {
if (b.updDate == null) return -1;
if (a.updDate == null) return 1;
return b.updDate.localeCompare(a.updDate);
}
case clsgs_ResearchResultEN.con_UpdUser:
return (a: clsgs_ResearchResultEN, b: clsgs_ResearchResultEN) => {
if (b.updUser == null) return -1;
if (a.updUser == null) return 1;
return b.updUser.localeCompare(a.updUser);
}
case clsgs_ResearchResultEN.con_Memo:
return (a: clsgs_ResearchResultEN, b: clsgs_ResearchResultEN) => {
if (b.memo == null) return -1;
if (a.memo == null) return 1;
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_ResearchResult]中不存在！(in ${ gs_ResearchResult_ConstructorName}.${ strThisFuncName})`;
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
export async function gs_ResearchResult_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsgs_ResearchResultEN.con_ResultId:
return (obj: clsgs_ResearchResultEN) => {
return obj.resultId === value;
}
case clsgs_ResearchResultEN.con_TopicId:
return (obj: clsgs_ResearchResultEN) => {
return obj.topicId === value;
}
case clsgs_ResearchResultEN.con_PaperId:
return (obj: clsgs_ResearchResultEN) => {
return obj.paperId === value;
}
case clsgs_ResearchResultEN.con_ResultTypeId:
return (obj: clsgs_ResearchResultEN) => {
return obj.resultTypeId === value;
}
case clsgs_ResearchResultEN.con_ResultName:
return (obj: clsgs_ResearchResultEN) => {
return obj.resultName === value;
}
case clsgs_ResearchResultEN.con_ResultContent:
return (obj: clsgs_ResearchResultEN) => {
return obj.resultContent === value;
}
case clsgs_ResearchResultEN.con_Author:
return (obj: clsgs_ResearchResultEN) => {
return obj.author === value;
}
case clsgs_ResearchResultEN.con_Division:
return (obj: clsgs_ResearchResultEN) => {
return obj.division === value;
}
case clsgs_ResearchResultEN.con_VersionCount:
return (obj: clsgs_ResearchResultEN) => {
return obj.versionCount === value;
}
case clsgs_ResearchResultEN.con_OkCount:
return (obj: clsgs_ResearchResultEN) => {
return obj.okCount === value;
}
case clsgs_ResearchResultEN.con_AppraiseCount:
return (obj: clsgs_ResearchResultEN) => {
return obj.appraiseCount === value;
}
case clsgs_ResearchResultEN.con_Score:
return (obj: clsgs_ResearchResultEN) => {
return obj.score === value;
}
case clsgs_ResearchResultEN.con_StuScore:
return (obj: clsgs_ResearchResultEN) => {
return obj.stuScore === value;
}
case clsgs_ResearchResultEN.con_TeaScore:
return (obj: clsgs_ResearchResultEN) => {
return obj.teaScore === value;
}
case clsgs_ResearchResultEN.con_id_CurrEduCls:
return (obj: clsgs_ResearchResultEN) => {
return obj.id_CurrEduCls === value;
}
case clsgs_ResearchResultEN.con_UpdDate:
return (obj: clsgs_ResearchResultEN) => {
return obj.updDate === value;
}
case clsgs_ResearchResultEN.con_UpdUser:
return (obj: clsgs_ResearchResultEN) => {
return obj.updUser === value;
}
case clsgs_ResearchResultEN.con_Memo:
return (obj: clsgs_ResearchResultEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_ResearchResult]中不存在！(in ${ gs_ResearchResult_ConstructorName}.${ strThisFuncName})`;
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
export async function gs_ResearchResult_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(gs_ResearchResult_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchResult_ConstructorName, strThisFuncName);
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
export async function gs_ResearchResult_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(gs_ResearchResult_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchResult_ConstructorName, strThisFuncName);
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
export async function gs_ResearchResult_GetFirstObjAsync(strWhereCond: string): Promise<clsgs_ResearchResultEN|null>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(gs_ResearchResult_Controller, strAction);
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
const objgs_ResearchResult = gs_ResearchResult_GetObjFromJsonObj(returnObj);
return objgs_ResearchResult;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchResult_ConstructorName, strThisFuncName);
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
export async function gs_ResearchResult_GetObjLstAsync(strWhereCond: string): Promise<Array<clsgs_ResearchResultEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(gs_ResearchResult_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_ResearchResult_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_ResearchResult_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchResult_ConstructorName, strThisFuncName);
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
 * @param arrResultId:关键字列表
 * @returns 对象列表
 **/
export async function gs_ResearchResult_GetObjLstByResultIdLstAsync(arrResultId: Array<string>): Promise<Array<clsgs_ResearchResultEN>>  
{
const strThisFuncName = "GetObjLstByResultIdLstAsync";
const strAction = "GetObjLstByResultIdLst";
const strUrl = GetWebApiUrl(gs_ResearchResult_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrResultId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_ResearchResult_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_ResearchResult_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchResult_ConstructorName, strThisFuncName);
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
export async function gs_ResearchResult_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsgs_ResearchResultEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(gs_ResearchResult_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_ResearchResult_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_ResearchResult_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchResult_ConstructorName, strThisFuncName);
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
export async function gs_ResearchResult_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsgs_ResearchResultEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(gs_ResearchResult_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_ResearchResult_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_ResearchResult_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchResult_ConstructorName, strThisFuncName);
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
export async function gs_ResearchResult_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(gs_ResearchResult_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchResult_ConstructorName, strThisFuncName);
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
export async function gs_ResearchResult_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsgs_ResearchResultEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
if (objPagerPara.pageIndex == 0) return new Array<clsgs_ResearchResultEN>();
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(gs_ResearchResult_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_ResearchResult_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_ResearchResult_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchResult_ConstructorName, strThisFuncName);
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
 * @param strResultId:关键字
 * @returns 获取删除的结果
 **/
export async function gs_ResearchResult_DelRecordAsync(strResultId: string): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(gs_ResearchResult_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, strResultId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchResult_ConstructorName, strThisFuncName);
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
 * @param arrResultId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function gs_ResearchResult_Delgs_ResearchResultsAsync(arrResultId: Array<string>): Promise<number> 
{
const strThisFuncName = "Delgs_ResearchResultsAsync";
const strAction = "Delgs_ResearchResults";
const strUrl = GetWebApiUrl(gs_ResearchResult_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrResultId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchResult_ConstructorName, strThisFuncName);
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
export async function gs_ResearchResult_Delgs_ResearchResultsByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "Delgs_ResearchResultsByCondAsync";
const strAction = "Delgs_ResearchResultsByCond";
const strUrl = GetWebApiUrl(gs_ResearchResult_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchResult_ConstructorName, strThisFuncName);
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
 * @param objgs_ResearchResultEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_ResearchResult_AddNewRecordAsync(objgs_ResearchResultEN: clsgs_ResearchResultEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objgs_ResearchResultEN);
const strUrl = GetWebApiUrl(gs_ResearchResult_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_ResearchResultEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchResult_ConstructorName, strThisFuncName);
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
 * @param objgs_ResearchResultEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_ResearchResult_AddNewRecordWithMaxIdAsync(objgs_ResearchResultEN: clsgs_ResearchResultEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithMaxIdAsync";
const strAction = "AddNewRecordWithMaxId";
const strUrl = GetWebApiUrl(gs_ResearchResult_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_ResearchResultEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchResult_ConstructorName, strThisFuncName);
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
 * @param objgs_ResearchResultEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function gs_ResearchResult_AddNewRecordWithReturnKeyAsync(objgs_ResearchResultEN: clsgs_ResearchResultEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(gs_ResearchResult_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_ResearchResultEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchResult_ConstructorName, strThisFuncName);
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
 * @param objgs_ResearchResultEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function gs_ResearchResult_AddNewRecordWithReturnKey(objgs_ResearchResultEN: clsgs_ResearchResultEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objgs_ResearchResultEN.resultId === null || objgs_ResearchResultEN.resultId === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(gs_ResearchResult_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_ResearchResultEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchResult_ConstructorName, strThisFuncName);
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
 * @param objgs_ResearchResultEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function gs_ResearchResult_UpdateRecordAsync(objgs_ResearchResultEN: clsgs_ResearchResultEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objgs_ResearchResultEN.sfUpdFldSetStr === undefined || objgs_ResearchResultEN.sfUpdFldSetStr === null || objgs_ResearchResultEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_ResearchResultEN.resultId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(gs_ResearchResult_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_ResearchResultEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchResult_ConstructorName, strThisFuncName);
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
 * @param objgs_ResearchResultEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function gs_ResearchResult_UpdateWithConditionAsync(objgs_ResearchResultEN: clsgs_ResearchResultEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objgs_ResearchResultEN.sfUpdFldSetStr === undefined || objgs_ResearchResultEN.sfUpdFldSetStr === null || objgs_ResearchResultEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_ResearchResultEN.resultId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(gs_ResearchResult_Controller, strAction);
objgs_ResearchResultEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objgs_ResearchResultEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchResult_ConstructorName, strThisFuncName);
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
export async function gs_ResearchResult_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(gs_ResearchResult_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchResult_ConstructorName, strThisFuncName);
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
 * @param strResultId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function gs_ResearchResult_IsExist(strResultId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(gs_ResearchResult_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"ResultId": strResultId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchResult_ConstructorName, strThisFuncName);
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
 * @param strResultId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function gs_ResearchResult_IsExistAsync(strResultId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(gs_ResearchResult_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strResultId": strResultId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchResult_ConstructorName, strThisFuncName);
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
export async function gs_ResearchResult_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(gs_ResearchResult_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchResult_ConstructorName, strThisFuncName);
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
export async function gs_ResearchResult_GetMaxStrIdAsync(): Promise<string>  
{
const strThisFuncName = "GetMaxStrIdAsync";
const strAction = "GetMaxStrId";
const strUrl = GetWebApiUrl(gs_ResearchResult_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchResult_ConstructorName, strThisFuncName);
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
export async function gs_ResearchResult_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(gs_ResearchResult_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchResult_ConstructorName, strThisFuncName);
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
export function gs_ResearchResult_GetWebApiUrl(strController: string, strAction: string): string {
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
export function gs_ResearchResult_CheckPropertyNew(pobjgs_ResearchResultEN: clsgs_ResearchResultEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjgs_ResearchResultEN.resultId) == false && GetStrLen(pobjgs_ResearchResultEN.resultId) > 10)
{
 throw new Error("(errid:Watl000059)字段[成果Id(resultId)]的长度不能超过10(In 研究成果(gs_ResearchResult))!值:$(pobjgs_ResearchResultEN.resultId)(clsgs_ResearchResultBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultEN.topicId) == false && GetStrLen(pobjgs_ResearchResultEN.topicId) > 8)
{
 throw new Error("(errid:Watl000059)字段[主题Id(topicId)]的长度不能超过8(In 研究成果(gs_ResearchResult))!值:$(pobjgs_ResearchResultEN.topicId)(clsgs_ResearchResultBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultEN.paperId) == false && GetStrLen(pobjgs_ResearchResultEN.paperId) > 8)
{
 throw new Error("(errid:Watl000059)字段[论文Id(paperId)]的长度不能超过8(In 研究成果(gs_ResearchResult))!值:$(pobjgs_ResearchResultEN.paperId)(clsgs_ResearchResultBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultEN.resultTypeId) == false && GetStrLen(pobjgs_ResearchResultEN.resultTypeId) > 2)
{
 throw new Error("(errid:Watl000059)字段[成果类型Id(resultTypeId)]的长度不能超过2(In 研究成果(gs_ResearchResult))!值:$(pobjgs_ResearchResultEN.resultTypeId)(clsgs_ResearchResultBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultEN.resultName) == false && GetStrLen(pobjgs_ResearchResultEN.resultName) > 500)
{
 throw new Error("(errid:Watl000059)字段[成果名称(resultName)]的长度不能超过500(In 研究成果(gs_ResearchResult))!值:$(pobjgs_ResearchResultEN.resultName)(clsgs_ResearchResultBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultEN.author) == false && GetStrLen(pobjgs_ResearchResultEN.author) > 200)
{
 throw new Error("(errid:Watl000059)字段[作者(author)]的长度不能超过200(In 研究成果(gs_ResearchResult))!值:$(pobjgs_ResearchResultEN.author)(clsgs_ResearchResultBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultEN.division) == false && GetStrLen(pobjgs_ResearchResultEN.division) > 500)
{
 throw new Error("(errid:Watl000059)字段[分工(division)]的长度不能超过500(In 研究成果(gs_ResearchResult))!值:$(pobjgs_ResearchResultEN.division)(clsgs_ResearchResultBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultEN.id_CurrEduCls) == false && GetStrLen(pobjgs_ResearchResultEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 研究成果(gs_ResearchResult))!值:$(pobjgs_ResearchResultEN.id_CurrEduCls)(clsgs_ResearchResultBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultEN.updDate) == false && GetStrLen(pobjgs_ResearchResultEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 研究成果(gs_ResearchResult))!值:$(pobjgs_ResearchResultEN.updDate)(clsgs_ResearchResultBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultEN.updUser) == false && GetStrLen(pobjgs_ResearchResultEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 研究成果(gs_ResearchResult))!值:$(pobjgs_ResearchResultEN.updUser)(clsgs_ResearchResultBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultEN.memo) == false && GetStrLen(pobjgs_ResearchResultEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 研究成果(gs_ResearchResult))!值:$(pobjgs_ResearchResultEN.memo)(clsgs_ResearchResultBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjgs_ResearchResultEN.resultId) == false && undefined !== pobjgs_ResearchResultEN.resultId && tzDataType.isString(pobjgs_ResearchResultEN.resultId) === false)
{
 throw new Error("(errid:Watl000060)字段[成果Id(resultId)]的值:[$(pobjgs_ResearchResultEN.resultId)], 非法，应该为字符型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultEN.topicId) == false && undefined !== pobjgs_ResearchResultEN.topicId && tzDataType.isString(pobjgs_ResearchResultEN.topicId) === false)
{
 throw new Error("(errid:Watl000060)字段[主题Id(topicId)]的值:[$(pobjgs_ResearchResultEN.topicId)], 非法，应该为字符型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultEN.paperId) == false && undefined !== pobjgs_ResearchResultEN.paperId && tzDataType.isString(pobjgs_ResearchResultEN.paperId) === false)
{
 throw new Error("(errid:Watl000060)字段[论文Id(paperId)]的值:[$(pobjgs_ResearchResultEN.paperId)], 非法，应该为字符型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultEN.resultTypeId) == false && undefined !== pobjgs_ResearchResultEN.resultTypeId && tzDataType.isString(pobjgs_ResearchResultEN.resultTypeId) === false)
{
 throw new Error("(errid:Watl000060)字段[成果类型Id(resultTypeId)]的值:[$(pobjgs_ResearchResultEN.resultTypeId)], 非法，应该为字符型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultEN.resultName) == false && undefined !== pobjgs_ResearchResultEN.resultName && tzDataType.isString(pobjgs_ResearchResultEN.resultName) === false)
{
 throw new Error("(errid:Watl000060)字段[成果名称(resultName)]的值:[$(pobjgs_ResearchResultEN.resultName)], 非法，应该为字符型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultEN.resultContent) == false && undefined !== pobjgs_ResearchResultEN.resultContent && tzDataType.isString(pobjgs_ResearchResultEN.resultContent) === false)
{
 throw new Error("(errid:Watl000060)字段[成果内容(resultContent)]的值:[$(pobjgs_ResearchResultEN.resultContent)], 非法，应该为字符型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultEN.author) == false && undefined !== pobjgs_ResearchResultEN.author && tzDataType.isString(pobjgs_ResearchResultEN.author) === false)
{
 throw new Error("(errid:Watl000060)字段[作者(author)]的值:[$(pobjgs_ResearchResultEN.author)], 非法，应该为字符型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultEN.division) == false && undefined !== pobjgs_ResearchResultEN.division && tzDataType.isString(pobjgs_ResearchResultEN.division) === false)
{
 throw new Error("(errid:Watl000060)字段[分工(division)]的值:[$(pobjgs_ResearchResultEN.division)], 非法，应该为字符型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckPropertyNew)");
}
if (null != pobjgs_ResearchResultEN.versionCount && undefined !== pobjgs_ResearchResultEN.versionCount && tzDataType.isNumber(pobjgs_ResearchResultEN.versionCount) === false)
{
 throw new Error("(errid:Watl000060)字段[版本统计(versionCount)]的值:[$(pobjgs_ResearchResultEN.versionCount)], 非法，应该为数值型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckPropertyNew)");
}
if (null != pobjgs_ResearchResultEN.okCount && undefined !== pobjgs_ResearchResultEN.okCount && tzDataType.isNumber(pobjgs_ResearchResultEN.okCount) === false)
{
 throw new Error("(errid:Watl000060)字段[点赞统计(okCount)]的值:[$(pobjgs_ResearchResultEN.okCount)], 非法，应该为数值型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckPropertyNew)");
}
if (null != pobjgs_ResearchResultEN.appraiseCount && undefined !== pobjgs_ResearchResultEN.appraiseCount && tzDataType.isNumber(pobjgs_ResearchResultEN.appraiseCount) === false)
{
 throw new Error("(errid:Watl000060)字段[评论数(appraiseCount)]的值:[$(pobjgs_ResearchResultEN.appraiseCount)], 非法，应该为数值型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckPropertyNew)");
}
if (null != pobjgs_ResearchResultEN.score && undefined !== pobjgs_ResearchResultEN.score && tzDataType.isNumber(pobjgs_ResearchResultEN.score) === false)
{
 throw new Error("(errid:Watl000060)字段[评分(score)]的值:[$(pobjgs_ResearchResultEN.score)], 非法，应该为数值型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckPropertyNew)");
}
if (null != pobjgs_ResearchResultEN.stuScore && undefined !== pobjgs_ResearchResultEN.stuScore && tzDataType.isNumber(pobjgs_ResearchResultEN.stuScore) === false)
{
 throw new Error("(errid:Watl000060)字段[学生平均分(stuScore)]的值:[$(pobjgs_ResearchResultEN.stuScore)], 非法，应该为数值型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckPropertyNew)");
}
if (null != pobjgs_ResearchResultEN.teaScore && undefined !== pobjgs_ResearchResultEN.teaScore && tzDataType.isNumber(pobjgs_ResearchResultEN.teaScore) === false)
{
 throw new Error("(errid:Watl000060)字段[教师评分(teaScore)]的值:[$(pobjgs_ResearchResultEN.teaScore)], 非法，应该为数值型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultEN.id_CurrEduCls) == false && undefined !== pobjgs_ResearchResultEN.id_CurrEduCls && tzDataType.isString(pobjgs_ResearchResultEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjgs_ResearchResultEN.id_CurrEduCls)], 非法，应该为字符型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultEN.updDate) == false && undefined !== pobjgs_ResearchResultEN.updDate && tzDataType.isString(pobjgs_ResearchResultEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjgs_ResearchResultEN.updDate)], 非法，应该为字符型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultEN.updUser) == false && undefined !== pobjgs_ResearchResultEN.updUser && tzDataType.isString(pobjgs_ResearchResultEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjgs_ResearchResultEN.updUser)], 非法，应该为字符型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultEN.memo) == false && undefined !== pobjgs_ResearchResultEN.memo && tzDataType.isString(pobjgs_ResearchResultEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjgs_ResearchResultEN.memo)], 非法，应该为字符型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjgs_ResearchResultEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function gs_ResearchResult_CheckProperty4Update (pobjgs_ResearchResultEN: clsgs_ResearchResultEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjgs_ResearchResultEN.resultId) == false && GetStrLen(pobjgs_ResearchResultEN.resultId) > 10)
{
 throw new Error("(errid:Watl000062)字段[成果Id(resultId)]的长度不能超过10(In 研究成果(gs_ResearchResult))!值:$(pobjgs_ResearchResultEN.resultId)(clsgs_ResearchResultBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultEN.topicId) == false && GetStrLen(pobjgs_ResearchResultEN.topicId) > 8)
{
 throw new Error("(errid:Watl000062)字段[主题Id(topicId)]的长度不能超过8(In 研究成果(gs_ResearchResult))!值:$(pobjgs_ResearchResultEN.topicId)(clsgs_ResearchResultBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultEN.paperId) == false && GetStrLen(pobjgs_ResearchResultEN.paperId) > 8)
{
 throw new Error("(errid:Watl000062)字段[论文Id(paperId)]的长度不能超过8(In 研究成果(gs_ResearchResult))!值:$(pobjgs_ResearchResultEN.paperId)(clsgs_ResearchResultBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultEN.resultTypeId) == false && GetStrLen(pobjgs_ResearchResultEN.resultTypeId) > 2)
{
 throw new Error("(errid:Watl000062)字段[成果类型Id(resultTypeId)]的长度不能超过2(In 研究成果(gs_ResearchResult))!值:$(pobjgs_ResearchResultEN.resultTypeId)(clsgs_ResearchResultBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultEN.resultName) == false && GetStrLen(pobjgs_ResearchResultEN.resultName) > 500)
{
 throw new Error("(errid:Watl000062)字段[成果名称(resultName)]的长度不能超过500(In 研究成果(gs_ResearchResult))!值:$(pobjgs_ResearchResultEN.resultName)(clsgs_ResearchResultBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultEN.author) == false && GetStrLen(pobjgs_ResearchResultEN.author) > 200)
{
 throw new Error("(errid:Watl000062)字段[作者(author)]的长度不能超过200(In 研究成果(gs_ResearchResult))!值:$(pobjgs_ResearchResultEN.author)(clsgs_ResearchResultBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultEN.division) == false && GetStrLen(pobjgs_ResearchResultEN.division) > 500)
{
 throw new Error("(errid:Watl000062)字段[分工(division)]的长度不能超过500(In 研究成果(gs_ResearchResult))!值:$(pobjgs_ResearchResultEN.division)(clsgs_ResearchResultBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultEN.id_CurrEduCls) == false && GetStrLen(pobjgs_ResearchResultEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 研究成果(gs_ResearchResult))!值:$(pobjgs_ResearchResultEN.id_CurrEduCls)(clsgs_ResearchResultBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultEN.updDate) == false && GetStrLen(pobjgs_ResearchResultEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 研究成果(gs_ResearchResult))!值:$(pobjgs_ResearchResultEN.updDate)(clsgs_ResearchResultBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultEN.updUser) == false && GetStrLen(pobjgs_ResearchResultEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 研究成果(gs_ResearchResult))!值:$(pobjgs_ResearchResultEN.updUser)(clsgs_ResearchResultBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultEN.memo) == false && GetStrLen(pobjgs_ResearchResultEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 研究成果(gs_ResearchResult))!值:$(pobjgs_ResearchResultEN.memo)(clsgs_ResearchResultBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjgs_ResearchResultEN.resultId) == false && undefined !== pobjgs_ResearchResultEN.resultId && tzDataType.isString(pobjgs_ResearchResultEN.resultId) === false)
{
 throw new Error("(errid:Watl000063)字段[成果Id(resultId)]的值:[$(pobjgs_ResearchResultEN.resultId)], 非法，应该为字符型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultEN.topicId) == false && undefined !== pobjgs_ResearchResultEN.topicId && tzDataType.isString(pobjgs_ResearchResultEN.topicId) === false)
{
 throw new Error("(errid:Watl000063)字段[主题Id(topicId)]的值:[$(pobjgs_ResearchResultEN.topicId)], 非法，应该为字符型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultEN.paperId) == false && undefined !== pobjgs_ResearchResultEN.paperId && tzDataType.isString(pobjgs_ResearchResultEN.paperId) === false)
{
 throw new Error("(errid:Watl000063)字段[论文Id(paperId)]的值:[$(pobjgs_ResearchResultEN.paperId)], 非法，应该为字符型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultEN.resultTypeId) == false && undefined !== pobjgs_ResearchResultEN.resultTypeId && tzDataType.isString(pobjgs_ResearchResultEN.resultTypeId) === false)
{
 throw new Error("(errid:Watl000063)字段[成果类型Id(resultTypeId)]的值:[$(pobjgs_ResearchResultEN.resultTypeId)], 非法，应该为字符型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultEN.resultName) == false && undefined !== pobjgs_ResearchResultEN.resultName && tzDataType.isString(pobjgs_ResearchResultEN.resultName) === false)
{
 throw new Error("(errid:Watl000063)字段[成果名称(resultName)]的值:[$(pobjgs_ResearchResultEN.resultName)], 非法，应该为字符型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultEN.resultContent) == false && undefined !== pobjgs_ResearchResultEN.resultContent && tzDataType.isString(pobjgs_ResearchResultEN.resultContent) === false)
{
 throw new Error("(errid:Watl000063)字段[成果内容(resultContent)]的值:[$(pobjgs_ResearchResultEN.resultContent)], 非法，应该为字符型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultEN.author) == false && undefined !== pobjgs_ResearchResultEN.author && tzDataType.isString(pobjgs_ResearchResultEN.author) === false)
{
 throw new Error("(errid:Watl000063)字段[作者(author)]的值:[$(pobjgs_ResearchResultEN.author)], 非法，应该为字符型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultEN.division) == false && undefined !== pobjgs_ResearchResultEN.division && tzDataType.isString(pobjgs_ResearchResultEN.division) === false)
{
 throw new Error("(errid:Watl000063)字段[分工(division)]的值:[$(pobjgs_ResearchResultEN.division)], 非法，应该为字符型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckProperty4Update)");
}
if (null != pobjgs_ResearchResultEN.versionCount && undefined !== pobjgs_ResearchResultEN.versionCount && tzDataType.isNumber(pobjgs_ResearchResultEN.versionCount) === false)
{
 throw new Error("(errid:Watl000063)字段[版本统计(versionCount)]的值:[$(pobjgs_ResearchResultEN.versionCount)], 非法，应该为数值型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckProperty4Update)");
}
if (null != pobjgs_ResearchResultEN.okCount && undefined !== pobjgs_ResearchResultEN.okCount && tzDataType.isNumber(pobjgs_ResearchResultEN.okCount) === false)
{
 throw new Error("(errid:Watl000063)字段[点赞统计(okCount)]的值:[$(pobjgs_ResearchResultEN.okCount)], 非法，应该为数值型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckProperty4Update)");
}
if (null != pobjgs_ResearchResultEN.appraiseCount && undefined !== pobjgs_ResearchResultEN.appraiseCount && tzDataType.isNumber(pobjgs_ResearchResultEN.appraiseCount) === false)
{
 throw new Error("(errid:Watl000063)字段[评论数(appraiseCount)]的值:[$(pobjgs_ResearchResultEN.appraiseCount)], 非法，应该为数值型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckProperty4Update)");
}
if (null != pobjgs_ResearchResultEN.score && undefined !== pobjgs_ResearchResultEN.score && tzDataType.isNumber(pobjgs_ResearchResultEN.score) === false)
{
 throw new Error("(errid:Watl000063)字段[评分(score)]的值:[$(pobjgs_ResearchResultEN.score)], 非法，应该为数值型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckProperty4Update)");
}
if (null != pobjgs_ResearchResultEN.stuScore && undefined !== pobjgs_ResearchResultEN.stuScore && tzDataType.isNumber(pobjgs_ResearchResultEN.stuScore) === false)
{
 throw new Error("(errid:Watl000063)字段[学生平均分(stuScore)]的值:[$(pobjgs_ResearchResultEN.stuScore)], 非法，应该为数值型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckProperty4Update)");
}
if (null != pobjgs_ResearchResultEN.teaScore && undefined !== pobjgs_ResearchResultEN.teaScore && tzDataType.isNumber(pobjgs_ResearchResultEN.teaScore) === false)
{
 throw new Error("(errid:Watl000063)字段[教师评分(teaScore)]的值:[$(pobjgs_ResearchResultEN.teaScore)], 非法，应该为数值型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultEN.id_CurrEduCls) == false && undefined !== pobjgs_ResearchResultEN.id_CurrEduCls && tzDataType.isString(pobjgs_ResearchResultEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjgs_ResearchResultEN.id_CurrEduCls)], 非法，应该为字符型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultEN.updDate) == false && undefined !== pobjgs_ResearchResultEN.updDate && tzDataType.isString(pobjgs_ResearchResultEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjgs_ResearchResultEN.updDate)], 非法，应该为字符型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultEN.updUser) == false && undefined !== pobjgs_ResearchResultEN.updUser && tzDataType.isString(pobjgs_ResearchResultEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjgs_ResearchResultEN.updUser)], 非法，应该为字符型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultEN.memo) == false && undefined !== pobjgs_ResearchResultEN.memo && tzDataType.isString(pobjgs_ResearchResultEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjgs_ResearchResultEN.memo)], 非法，应该为字符型(In 研究成果(gs_ResearchResult))!(clsgs_ResearchResultBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (IsNullOrEmpty(pobjgs_ResearchResultEN.resultId) === true )
{
 throw new Error("(errid:Watl000064)字段[成果Id]不能为空(In 研究成果)!(clsgs_ResearchResultBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjgs_ResearchResultEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function gs_ResearchResult_GetJSONStrByObj (pobjgs_ResearchResultEN: clsgs_ResearchResultEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjgs_ResearchResultEN.sfUpdFldSetStr = pobjgs_ResearchResultEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjgs_ResearchResultEN);
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
export function gs_ResearchResult_GetObjLstByJSONStr (strJSON: string): Array<clsgs_ResearchResultEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrgs_ResearchResultObjLst = new Array<clsgs_ResearchResultEN>();
if (strJSON === "")
{
return arrgs_ResearchResultObjLst;
}
try
{
arrgs_ResearchResultObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrgs_ResearchResultObjLst;
}
return arrgs_ResearchResultObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrgs_ResearchResultObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function gs_ResearchResult_GetObjLstByJSONObjLst (arrgs_ResearchResultObjLstS: Array<clsgs_ResearchResultEN>): Array<clsgs_ResearchResultEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrgs_ResearchResultObjLst = new Array<clsgs_ResearchResultEN>();
for (const objInFor of arrgs_ResearchResultObjLstS) {
const obj1 = gs_ResearchResult_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrgs_ResearchResultObjLst.push(obj1);
}
return arrgs_ResearchResultObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function gs_ResearchResult_GetObjByJSONStr (strJSON: string): clsgs_ResearchResultEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjgs_ResearchResultEN = new clsgs_ResearchResultEN();
if (strJSON === "")
{
return pobjgs_ResearchResultEN;
}
try
{
pobjgs_ResearchResultEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjgs_ResearchResultEN;
}
return pobjgs_ResearchResultEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function gs_ResearchResult_GetCombineCondition(objgs_ResearchResult_Cond: clsgs_ResearchResultEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objgs_ResearchResult_Cond.dicFldComparisonOp, clsgs_ResearchResultEN.con_ResultId) == true)
{
const strComparisonOp_ResultId:string = objgs_ResearchResult_Cond.dicFldComparisonOp[clsgs_ResearchResultEN.con_ResultId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_ResearchResultEN.con_ResultId, objgs_ResearchResult_Cond.resultId, strComparisonOp_ResultId);
}
if (Object.prototype.hasOwnProperty.call(objgs_ResearchResult_Cond.dicFldComparisonOp, clsgs_ResearchResultEN.con_TopicId) == true)
{
const strComparisonOp_TopicId:string = objgs_ResearchResult_Cond.dicFldComparisonOp[clsgs_ResearchResultEN.con_TopicId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_ResearchResultEN.con_TopicId, objgs_ResearchResult_Cond.topicId, strComparisonOp_TopicId);
}
if (Object.prototype.hasOwnProperty.call(objgs_ResearchResult_Cond.dicFldComparisonOp, clsgs_ResearchResultEN.con_PaperId) == true)
{
const strComparisonOp_PaperId:string = objgs_ResearchResult_Cond.dicFldComparisonOp[clsgs_ResearchResultEN.con_PaperId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_ResearchResultEN.con_PaperId, objgs_ResearchResult_Cond.paperId, strComparisonOp_PaperId);
}
if (Object.prototype.hasOwnProperty.call(objgs_ResearchResult_Cond.dicFldComparisonOp, clsgs_ResearchResultEN.con_ResultTypeId) == true)
{
const strComparisonOp_ResultTypeId:string = objgs_ResearchResult_Cond.dicFldComparisonOp[clsgs_ResearchResultEN.con_ResultTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_ResearchResultEN.con_ResultTypeId, objgs_ResearchResult_Cond.resultTypeId, strComparisonOp_ResultTypeId);
}
if (Object.prototype.hasOwnProperty.call(objgs_ResearchResult_Cond.dicFldComparisonOp, clsgs_ResearchResultEN.con_ResultName) == true)
{
const strComparisonOp_ResultName:string = objgs_ResearchResult_Cond.dicFldComparisonOp[clsgs_ResearchResultEN.con_ResultName];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_ResearchResultEN.con_ResultName, objgs_ResearchResult_Cond.resultName, strComparisonOp_ResultName);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objgs_ResearchResult_Cond.dicFldComparisonOp, clsgs_ResearchResultEN.con_Author) == true)
{
const strComparisonOp_Author:string = objgs_ResearchResult_Cond.dicFldComparisonOp[clsgs_ResearchResultEN.con_Author];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_ResearchResultEN.con_Author, objgs_ResearchResult_Cond.author, strComparisonOp_Author);
}
if (Object.prototype.hasOwnProperty.call(objgs_ResearchResult_Cond.dicFldComparisonOp, clsgs_ResearchResultEN.con_Division) == true)
{
const strComparisonOp_Division:string = objgs_ResearchResult_Cond.dicFldComparisonOp[clsgs_ResearchResultEN.con_Division];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_ResearchResultEN.con_Division, objgs_ResearchResult_Cond.division, strComparisonOp_Division);
}
if (Object.prototype.hasOwnProperty.call(objgs_ResearchResult_Cond.dicFldComparisonOp, clsgs_ResearchResultEN.con_VersionCount) == true)
{
const strComparisonOp_VersionCount:string = objgs_ResearchResult_Cond.dicFldComparisonOp[clsgs_ResearchResultEN.con_VersionCount];
strWhereCond += Format(" And {0} {2} {1}", clsgs_ResearchResultEN.con_VersionCount, objgs_ResearchResult_Cond.versionCount, strComparisonOp_VersionCount);
}
if (Object.prototype.hasOwnProperty.call(objgs_ResearchResult_Cond.dicFldComparisonOp, clsgs_ResearchResultEN.con_OkCount) == true)
{
const strComparisonOp_OkCount:string = objgs_ResearchResult_Cond.dicFldComparisonOp[clsgs_ResearchResultEN.con_OkCount];
strWhereCond += Format(" And {0} {2} {1}", clsgs_ResearchResultEN.con_OkCount, objgs_ResearchResult_Cond.okCount, strComparisonOp_OkCount);
}
if (Object.prototype.hasOwnProperty.call(objgs_ResearchResult_Cond.dicFldComparisonOp, clsgs_ResearchResultEN.con_AppraiseCount) == true)
{
const strComparisonOp_AppraiseCount:string = objgs_ResearchResult_Cond.dicFldComparisonOp[clsgs_ResearchResultEN.con_AppraiseCount];
strWhereCond += Format(" And {0} {2} {1}", clsgs_ResearchResultEN.con_AppraiseCount, objgs_ResearchResult_Cond.appraiseCount, strComparisonOp_AppraiseCount);
}
if (Object.prototype.hasOwnProperty.call(objgs_ResearchResult_Cond.dicFldComparisonOp, clsgs_ResearchResultEN.con_Score) == true)
{
const strComparisonOp_Score:string = objgs_ResearchResult_Cond.dicFldComparisonOp[clsgs_ResearchResultEN.con_Score];
strWhereCond += Format(" And {0} {2} {1}", clsgs_ResearchResultEN.con_Score, objgs_ResearchResult_Cond.score, strComparisonOp_Score);
}
if (Object.prototype.hasOwnProperty.call(objgs_ResearchResult_Cond.dicFldComparisonOp, clsgs_ResearchResultEN.con_StuScore) == true)
{
const strComparisonOp_StuScore:string = objgs_ResearchResult_Cond.dicFldComparisonOp[clsgs_ResearchResultEN.con_StuScore];
strWhereCond += Format(" And {0} {2} {1}", clsgs_ResearchResultEN.con_StuScore, objgs_ResearchResult_Cond.stuScore, strComparisonOp_StuScore);
}
if (Object.prototype.hasOwnProperty.call(objgs_ResearchResult_Cond.dicFldComparisonOp, clsgs_ResearchResultEN.con_TeaScore) == true)
{
const strComparisonOp_TeaScore:string = objgs_ResearchResult_Cond.dicFldComparisonOp[clsgs_ResearchResultEN.con_TeaScore];
strWhereCond += Format(" And {0} {2} {1}", clsgs_ResearchResultEN.con_TeaScore, objgs_ResearchResult_Cond.teaScore, strComparisonOp_TeaScore);
}
if (Object.prototype.hasOwnProperty.call(objgs_ResearchResult_Cond.dicFldComparisonOp, clsgs_ResearchResultEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objgs_ResearchResult_Cond.dicFldComparisonOp[clsgs_ResearchResultEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_ResearchResultEN.con_id_CurrEduCls, objgs_ResearchResult_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (Object.prototype.hasOwnProperty.call(objgs_ResearchResult_Cond.dicFldComparisonOp, clsgs_ResearchResultEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objgs_ResearchResult_Cond.dicFldComparisonOp[clsgs_ResearchResultEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_ResearchResultEN.con_UpdDate, objgs_ResearchResult_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objgs_ResearchResult_Cond.dicFldComparisonOp, clsgs_ResearchResultEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objgs_ResearchResult_Cond.dicFldComparisonOp[clsgs_ResearchResultEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_ResearchResultEN.con_UpdUser, objgs_ResearchResult_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objgs_ResearchResult_Cond.dicFldComparisonOp, clsgs_ResearchResultEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objgs_ResearchResult_Cond.dicFldComparisonOp[clsgs_ResearchResultEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_ResearchResultEN.con_Memo, objgs_ResearchResult_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--gs_ResearchResult(研究成果),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param strTopicId: 主题Id(要求唯一的字段)
 * @param strResultTypeId: 成果类型Id(要求唯一的字段)
 * @param strResultName: 成果名称(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function gs_ResearchResult_GetUniCondStr_TopicId_ResultTypeId_ResultName(objgs_ResearchResultEN: clsgs_ResearchResultEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and TopicId = '{0}'", objgs_ResearchResultEN.topicId);
 strWhereCond +=  Format(" and ResultTypeId = '{0}'", objgs_ResearchResultEN.resultTypeId);
 strWhereCond +=  Format(" and ResultName = '{0}'", objgs_ResearchResultEN.resultName);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--gs_ResearchResult(研究成果),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param strTopicId: 主题Id(要求唯一的字段)
 * @param strResultTypeId: 成果类型Id(要求唯一的字段)
 * @param strResultName: 成果名称(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function gs_ResearchResult_GetUniCondStr4Update_TopicId_ResultTypeId_ResultName(objgs_ResearchResultEN: clsgs_ResearchResultEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and ResultId <> '{0}'", objgs_ResearchResultEN.resultId);
 strWhereCond +=  Format(" and TopicId = '{0}'", objgs_ResearchResultEN.topicId);
 strWhereCond +=  Format(" and ResultTypeId = '{0}'", objgs_ResearchResultEN.resultTypeId);
 strWhereCond +=  Format(" and ResultName = '{0}'", objgs_ResearchResultEN.resultName);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objgs_ResearchResultENS:源对象
 * @param objgs_ResearchResultENT:目标对象
*/
export function gs_ResearchResult_CopyObjTo(objgs_ResearchResultENS: clsgs_ResearchResultEN , objgs_ResearchResultENT: clsgs_ResearchResultEN ): void 
{
objgs_ResearchResultENT.resultId = objgs_ResearchResultENS.resultId; //成果Id
objgs_ResearchResultENT.topicId = objgs_ResearchResultENS.topicId; //主题Id
objgs_ResearchResultENT.paperId = objgs_ResearchResultENS.paperId; //论文Id
objgs_ResearchResultENT.resultTypeId = objgs_ResearchResultENS.resultTypeId; //成果类型Id
objgs_ResearchResultENT.resultName = objgs_ResearchResultENS.resultName; //成果名称
objgs_ResearchResultENT.resultContent = objgs_ResearchResultENS.resultContent; //成果内容
objgs_ResearchResultENT.author = objgs_ResearchResultENS.author; //作者
objgs_ResearchResultENT.division = objgs_ResearchResultENS.division; //分工
objgs_ResearchResultENT.versionCount = objgs_ResearchResultENS.versionCount; //版本统计
objgs_ResearchResultENT.okCount = objgs_ResearchResultENS.okCount; //点赞统计
objgs_ResearchResultENT.appraiseCount = objgs_ResearchResultENS.appraiseCount; //评论数
objgs_ResearchResultENT.score = objgs_ResearchResultENS.score; //评分
objgs_ResearchResultENT.stuScore = objgs_ResearchResultENS.stuScore; //学生平均分
objgs_ResearchResultENT.teaScore = objgs_ResearchResultENS.teaScore; //教师评分
objgs_ResearchResultENT.id_CurrEduCls = objgs_ResearchResultENS.id_CurrEduCls; //教学班流水号
objgs_ResearchResultENT.updDate = objgs_ResearchResultENS.updDate; //修改日期
objgs_ResearchResultENT.updUser = objgs_ResearchResultENS.updUser; //修改人
objgs_ResearchResultENT.memo = objgs_ResearchResultENS.memo; //备注
objgs_ResearchResultENT.sfUpdFldSetStr = objgs_ResearchResultENS.updFldString; //sfUpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objgs_ResearchResultENS:源对象
 * @param objgs_ResearchResultENT:目标对象
*/
export function gs_ResearchResult_GetObjFromJsonObj(objgs_ResearchResultENS: clsgs_ResearchResultEN): clsgs_ResearchResultEN 
{
 const objgs_ResearchResultENT: clsgs_ResearchResultEN = new clsgs_ResearchResultEN();
ObjectAssign(objgs_ResearchResultENT, objgs_ResearchResultENS);
 return objgs_ResearchResultENT;
}