﻿
 /**
 * 类名:clsTopicObjectiveVerWApi
 * 表名:TopicObjectiveVer(01120648)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:45:24
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
 * 主题客观版本(TopicObjectiveVer)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2023年03月13日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { enumComparisonOp } from "../../PubFun/enumComparisonOp.js";
import { clsTopicObjectiveVerEN } from "../../L0_Entity/GraduateEduTopic/clsTopicObjectiveVerEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { tzDataType } from "../../PubFun/clsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const topicObjectiveVer_Controller = "TopicObjectiveVerApi";
 export const topicObjectiveVer_ConstructorName = "topicObjectiveVer";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngTopicObjectiveVId:关键字
 * @returns 对象
 **/
export async function TopicObjectiveVer_GetObjByTopicObjectiveVIdAsync(lngTopicObjectiveVId: number): Promise<clsTopicObjectiveVerEN|null>  
{
const strThisFuncName = "GetObjByTopicObjectiveVIdAsync";

if (lngTopicObjectiveVId == 0)
{
  const strMsg = Format("参数:[lngTopicObjectiveVId]不能为空！(In clsTopicObjectiveVerWApi.GetObjByTopicObjectiveVIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjByTopicObjectiveVId";
const strUrl = GetWebApiUrl(topicObjectiveVer_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"lngTopicObjectiveVId": lngTopicObjectiveVId,
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
const objTopicObjectiveVer = TopicObjectiveVer_GetObjFromJsonObj(returnObj);
return objTopicObjectiveVer;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicObjectiveVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicObjectiveVer_ConstructorName, strThisFuncName);
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
export function TopicObjectiveVer_SortFun_Defa(a:clsTopicObjectiveVerEN , b:clsTopicObjectiveVerEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.topicObjectiveVId-b.topicObjectiveVId;
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
export function TopicObjectiveVer_SortFun_Defa_2Fld(a:clsTopicObjectiveVerEN , b:clsTopicObjectiveVerEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.topicObjectiveId == b.topicObjectiveId) return a.objectiveName.localeCompare(b.objectiveName);
else return a.topicObjectiveId.localeCompare(b.topicObjectiveId);
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
export function TopicObjectiveVer_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsTopicObjectiveVerEN.con_TopicObjectiveVId:
return (a: clsTopicObjectiveVerEN, b: clsTopicObjectiveVerEN) => {
return a.topicObjectiveVId-b.topicObjectiveVId;
}
case clsTopicObjectiveVerEN.con_TopicObjectiveId:
return (a: clsTopicObjectiveVerEN, b: clsTopicObjectiveVerEN) => {
return a.topicObjectiveId.localeCompare(b.topicObjectiveId);
}
case clsTopicObjectiveVerEN.con_ObjectiveName:
return (a: clsTopicObjectiveVerEN, b: clsTopicObjectiveVerEN) => {
if (a.objectiveName == null) return -1;
if (b.objectiveName == null) return 1;
return a.objectiveName.localeCompare(b.objectiveName);
}
case clsTopicObjectiveVerEN.con_ObjectiveContent:
return (a: clsTopicObjectiveVerEN, b: clsTopicObjectiveVerEN) => {
if (a.objectiveContent == null) return -1;
if (b.objectiveContent == null) return 1;
return a.objectiveContent.localeCompare(b.objectiveContent);
}
case clsTopicObjectiveVerEN.con_ObjectiveType:
return (a: clsTopicObjectiveVerEN, b: clsTopicObjectiveVerEN) => {
if (a.objectiveType == null) return -1;
if (b.objectiveType == null) return 1;
return a.objectiveType.localeCompare(b.objectiveType);
}
case clsTopicObjectiveVerEN.con_Conclusion:
return (a: clsTopicObjectiveVerEN, b: clsTopicObjectiveVerEN) => {
if (a.conclusion == null) return -1;
if (b.conclusion == null) return 1;
return a.conclusion.localeCompare(b.conclusion);
}
case clsTopicObjectiveVerEN.con_SourceId:
return (a: clsTopicObjectiveVerEN, b: clsTopicObjectiveVerEN) => {
if (a.sourceId == null) return -1;
if (b.sourceId == null) return 1;
return a.sourceId.localeCompare(b.sourceId);
}
case clsTopicObjectiveVerEN.con_UpdDate:
return (a: clsTopicObjectiveVerEN, b: clsTopicObjectiveVerEN) => {
if (a.updDate == null) return -1;
if (b.updDate == null) return 1;
return a.updDate.localeCompare(b.updDate);
}
case clsTopicObjectiveVerEN.con_UpdUser:
return (a: clsTopicObjectiveVerEN, b: clsTopicObjectiveVerEN) => {
if (a.updUser == null) return -1;
if (b.updUser == null) return 1;
return a.updUser.localeCompare(b.updUser);
}
case clsTopicObjectiveVerEN.con_id_CurrEduCls:
return (a: clsTopicObjectiveVerEN, b: clsTopicObjectiveVerEN) => {
if (a.id_CurrEduCls == null) return -1;
if (b.id_CurrEduCls == null) return 1;
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
case clsTopicObjectiveVerEN.con_PdfContent:
return (a: clsTopicObjectiveVerEN, b: clsTopicObjectiveVerEN) => {
if (a.pdfContent == null) return -1;
if (b.pdfContent == null) return 1;
return a.pdfContent.localeCompare(b.pdfContent);
}
case clsTopicObjectiveVerEN.con_PdfPageNum:
return (a: clsTopicObjectiveVerEN, b: clsTopicObjectiveVerEN) => {
return a.pdfPageNum-b.pdfPageNum;
}
case clsTopicObjectiveVerEN.con_Memo:
return (a: clsTopicObjectiveVerEN, b: clsTopicObjectiveVerEN) => {
if (a.memo == null) return -1;
if (b.memo == null) return 1;
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[TopicObjectiveVer]中不存在！(in ${ topicObjectiveVer_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsTopicObjectiveVerEN.con_TopicObjectiveVId:
return (a: clsTopicObjectiveVerEN, b: clsTopicObjectiveVerEN) => {
return b.topicObjectiveVId-a.topicObjectiveVId;
}
case clsTopicObjectiveVerEN.con_TopicObjectiveId:
return (a: clsTopicObjectiveVerEN, b: clsTopicObjectiveVerEN) => {
return b.topicObjectiveId.localeCompare(a.topicObjectiveId);
}
case clsTopicObjectiveVerEN.con_ObjectiveName:
return (a: clsTopicObjectiveVerEN, b: clsTopicObjectiveVerEN) => {
if (b.objectiveName == null) return -1;
if (a.objectiveName == null) return 1;
return b.objectiveName.localeCompare(a.objectiveName);
}
case clsTopicObjectiveVerEN.con_ObjectiveContent:
return (a: clsTopicObjectiveVerEN, b: clsTopicObjectiveVerEN) => {
if (b.objectiveContent == null) return -1;
if (a.objectiveContent == null) return 1;
return b.objectiveContent.localeCompare(a.objectiveContent);
}
case clsTopicObjectiveVerEN.con_ObjectiveType:
return (a: clsTopicObjectiveVerEN, b: clsTopicObjectiveVerEN) => {
if (b.objectiveType == null) return -1;
if (a.objectiveType == null) return 1;
return b.objectiveType.localeCompare(a.objectiveType);
}
case clsTopicObjectiveVerEN.con_Conclusion:
return (a: clsTopicObjectiveVerEN, b: clsTopicObjectiveVerEN) => {
if (b.conclusion == null) return -1;
if (a.conclusion == null) return 1;
return b.conclusion.localeCompare(a.conclusion);
}
case clsTopicObjectiveVerEN.con_SourceId:
return (a: clsTopicObjectiveVerEN, b: clsTopicObjectiveVerEN) => {
if (b.sourceId == null) return -1;
if (a.sourceId == null) return 1;
return b.sourceId.localeCompare(a.sourceId);
}
case clsTopicObjectiveVerEN.con_UpdDate:
return (a: clsTopicObjectiveVerEN, b: clsTopicObjectiveVerEN) => {
if (b.updDate == null) return -1;
if (a.updDate == null) return 1;
return b.updDate.localeCompare(a.updDate);
}
case clsTopicObjectiveVerEN.con_UpdUser:
return (a: clsTopicObjectiveVerEN, b: clsTopicObjectiveVerEN) => {
if (b.updUser == null) return -1;
if (a.updUser == null) return 1;
return b.updUser.localeCompare(a.updUser);
}
case clsTopicObjectiveVerEN.con_id_CurrEduCls:
return (a: clsTopicObjectiveVerEN, b: clsTopicObjectiveVerEN) => {
if (b.id_CurrEduCls == null) return -1;
if (a.id_CurrEduCls == null) return 1;
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
case clsTopicObjectiveVerEN.con_PdfContent:
return (a: clsTopicObjectiveVerEN, b: clsTopicObjectiveVerEN) => {
if (b.pdfContent == null) return -1;
if (a.pdfContent == null) return 1;
return b.pdfContent.localeCompare(a.pdfContent);
}
case clsTopicObjectiveVerEN.con_PdfPageNum:
return (a: clsTopicObjectiveVerEN, b: clsTopicObjectiveVerEN) => {
return b.pdfPageNum-a.pdfPageNum;
}
case clsTopicObjectiveVerEN.con_Memo:
return (a: clsTopicObjectiveVerEN, b: clsTopicObjectiveVerEN) => {
if (b.memo == null) return -1;
if (a.memo == null) return 1;
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[TopicObjectiveVer]中不存在！(in ${ topicObjectiveVer_ConstructorName}.${ strThisFuncName})`;
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
export async function TopicObjectiveVer_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsTopicObjectiveVerEN.con_TopicObjectiveVId:
return (obj: clsTopicObjectiveVerEN) => {
return obj.topicObjectiveVId === value;
}
case clsTopicObjectiveVerEN.con_TopicObjectiveId:
return (obj: clsTopicObjectiveVerEN) => {
return obj.topicObjectiveId === value;
}
case clsTopicObjectiveVerEN.con_ObjectiveName:
return (obj: clsTopicObjectiveVerEN) => {
return obj.objectiveName === value;
}
case clsTopicObjectiveVerEN.con_ObjectiveContent:
return (obj: clsTopicObjectiveVerEN) => {
return obj.objectiveContent === value;
}
case clsTopicObjectiveVerEN.con_ObjectiveType:
return (obj: clsTopicObjectiveVerEN) => {
return obj.objectiveType === value;
}
case clsTopicObjectiveVerEN.con_Conclusion:
return (obj: clsTopicObjectiveVerEN) => {
return obj.conclusion === value;
}
case clsTopicObjectiveVerEN.con_SourceId:
return (obj: clsTopicObjectiveVerEN) => {
return obj.sourceId === value;
}
case clsTopicObjectiveVerEN.con_UpdDate:
return (obj: clsTopicObjectiveVerEN) => {
return obj.updDate === value;
}
case clsTopicObjectiveVerEN.con_UpdUser:
return (obj: clsTopicObjectiveVerEN) => {
return obj.updUser === value;
}
case clsTopicObjectiveVerEN.con_id_CurrEduCls:
return (obj: clsTopicObjectiveVerEN) => {
return obj.id_CurrEduCls === value;
}
case clsTopicObjectiveVerEN.con_PdfContent:
return (obj: clsTopicObjectiveVerEN) => {
return obj.pdfContent === value;
}
case clsTopicObjectiveVerEN.con_PdfPageNum:
return (obj: clsTopicObjectiveVerEN) => {
return obj.pdfPageNum === value;
}
case clsTopicObjectiveVerEN.con_Memo:
return (obj: clsTopicObjectiveVerEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[TopicObjectiveVer]中不存在！(in ${ topicObjectiveVer_ConstructorName}.${ strThisFuncName})`;
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
export async function TopicObjectiveVer_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(topicObjectiveVer_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicObjectiveVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicObjectiveVer_ConstructorName, strThisFuncName);
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
export async function TopicObjectiveVer_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(topicObjectiveVer_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicObjectiveVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicObjectiveVer_ConstructorName, strThisFuncName);
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
export async function TopicObjectiveVer_GetFirstObjAsync(strWhereCond: string): Promise<clsTopicObjectiveVerEN|null>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(topicObjectiveVer_Controller, strAction);
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
const objTopicObjectiveVer = TopicObjectiveVer_GetObjFromJsonObj(returnObj);
return objTopicObjectiveVer;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicObjectiveVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicObjectiveVer_ConstructorName, strThisFuncName);
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
export async function TopicObjectiveVer_GetObjLstAsync(strWhereCond: string): Promise<Array<clsTopicObjectiveVerEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(topicObjectiveVer_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", topicObjectiveVer_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = TopicObjectiveVer_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicObjectiveVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicObjectiveVer_ConstructorName, strThisFuncName);
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
 * @param arrTopicObjectiveVId:关键字列表
 * @returns 对象列表
 **/
export async function TopicObjectiveVer_GetObjLstByTopicObjectiveVIdLstAsync(arrTopicObjectiveVId: Array<string>): Promise<Array<clsTopicObjectiveVerEN>>  
{
const strThisFuncName = "GetObjLstByTopicObjectiveVIdLstAsync";
const strAction = "GetObjLstByTopicObjectiveVIdLst";
const strUrl = GetWebApiUrl(topicObjectiveVer_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrTopicObjectiveVId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", topicObjectiveVer_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = TopicObjectiveVer_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicObjectiveVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicObjectiveVer_ConstructorName, strThisFuncName);
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
export async function TopicObjectiveVer_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsTopicObjectiveVerEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(topicObjectiveVer_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", topicObjectiveVer_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = TopicObjectiveVer_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicObjectiveVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicObjectiveVer_ConstructorName, strThisFuncName);
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
export async function TopicObjectiveVer_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsTopicObjectiveVerEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(topicObjectiveVer_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", topicObjectiveVer_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = TopicObjectiveVer_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicObjectiveVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicObjectiveVer_ConstructorName, strThisFuncName);
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
export async function TopicObjectiveVer_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(topicObjectiveVer_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicObjectiveVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicObjectiveVer_ConstructorName, strThisFuncName);
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
export async function TopicObjectiveVer_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsTopicObjectiveVerEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
if (objPagerPara.pageIndex == 0) return new Array<clsTopicObjectiveVerEN>();
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(topicObjectiveVer_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", topicObjectiveVer_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = TopicObjectiveVer_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicObjectiveVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicObjectiveVer_ConstructorName, strThisFuncName);
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
 * @param lngTopicObjectiveVId:关键字
 * @returns 获取删除的结果
 **/
export async function TopicObjectiveVer_DelRecordAsync(lngTopicObjectiveVId: number): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(topicObjectiveVer_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, lngTopicObjectiveVId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicObjectiveVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicObjectiveVer_ConstructorName, strThisFuncName);
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
 * @param arrTopicObjectiveVId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function TopicObjectiveVer_DelTopicObjectiveVersAsync(arrTopicObjectiveVId: Array<string>): Promise<number> 
{
const strThisFuncName = "DelTopicObjectiveVersAsync";
const strAction = "DelTopicObjectiveVers";
const strUrl = GetWebApiUrl(topicObjectiveVer_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrTopicObjectiveVId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicObjectiveVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicObjectiveVer_ConstructorName, strThisFuncName);
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
export async function TopicObjectiveVer_DelTopicObjectiveVersByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "DelTopicObjectiveVersByCondAsync";
const strAction = "DelTopicObjectiveVersByCond";
const strUrl = GetWebApiUrl(topicObjectiveVer_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicObjectiveVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicObjectiveVer_ConstructorName, strThisFuncName);
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
 * @param objTopicObjectiveVerEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function TopicObjectiveVer_AddNewRecordAsync(objTopicObjectiveVerEN: clsTopicObjectiveVerEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objTopicObjectiveVerEN);
const strUrl = GetWebApiUrl(topicObjectiveVer_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopicObjectiveVerEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicObjectiveVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicObjectiveVer_ConstructorName, strThisFuncName);
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
 * @param objTopicObjectiveVerEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function TopicObjectiveVer_AddNewRecordWithReturnKeyAsync(objTopicObjectiveVerEN: clsTopicObjectiveVerEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(topicObjectiveVer_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopicObjectiveVerEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicObjectiveVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicObjectiveVer_ConstructorName, strThisFuncName);
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
 * @param objTopicObjectiveVerEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function TopicObjectiveVer_AddNewRecordWithReturnKey(objTopicObjectiveVerEN: clsTopicObjectiveVerEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objTopicObjectiveVerEN.topicObjectiveVId === null || objTopicObjectiveVerEN.topicObjectiveVId === 0)
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(topicObjectiveVer_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopicObjectiveVerEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicObjectiveVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicObjectiveVer_ConstructorName, strThisFuncName);
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
 * @param objTopicObjectiveVerEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function TopicObjectiveVer_UpdateRecordAsync(objTopicObjectiveVerEN: clsTopicObjectiveVerEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objTopicObjectiveVerEN.sfUpdFldSetStr === undefined || objTopicObjectiveVerEN.sfUpdFldSetStr === null || objTopicObjectiveVerEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objTopicObjectiveVerEN.topicObjectiveVId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(topicObjectiveVer_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopicObjectiveVerEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicObjectiveVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicObjectiveVer_ConstructorName, strThisFuncName);
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
 * @param objTopicObjectiveVerEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function TopicObjectiveVer_UpdateWithConditionAsync(objTopicObjectiveVerEN: clsTopicObjectiveVerEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objTopicObjectiveVerEN.sfUpdFldSetStr === undefined || objTopicObjectiveVerEN.sfUpdFldSetStr === null || objTopicObjectiveVerEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objTopicObjectiveVerEN.topicObjectiveVId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(topicObjectiveVer_Controller, strAction);
objTopicObjectiveVerEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objTopicObjectiveVerEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicObjectiveVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicObjectiveVer_ConstructorName, strThisFuncName);
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
export async function TopicObjectiveVer_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(topicObjectiveVer_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicObjectiveVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicObjectiveVer_ConstructorName, strThisFuncName);
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
 * @param lngTopicObjectiveVId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function TopicObjectiveVer_IsExist(lngTopicObjectiveVId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(topicObjectiveVer_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"TopicObjectiveVId": lngTopicObjectiveVId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicObjectiveVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicObjectiveVer_ConstructorName, strThisFuncName);
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
 * @param lngTopicObjectiveVId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function TopicObjectiveVer_IsExistAsync(lngTopicObjectiveVId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(topicObjectiveVer_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "lngTopicObjectiveVId": lngTopicObjectiveVId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicObjectiveVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicObjectiveVer_ConstructorName, strThisFuncName);
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
export async function TopicObjectiveVer_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(topicObjectiveVer_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicObjectiveVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicObjectiveVer_ConstructorName, strThisFuncName);
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
export async function TopicObjectiveVer_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(topicObjectiveVer_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicObjectiveVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicObjectiveVer_ConstructorName, strThisFuncName);
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
export function TopicObjectiveVer_GetWebApiUrl(strController: string, strAction: string): string {
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
export function TopicObjectiveVer_CheckPropertyNew(pobjTopicObjectiveVerEN: clsTopicObjectiveVerEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjTopicObjectiveVerEN.topicObjectiveId) === true )
{
 throw new Error("(errid:Watl000058)字段[客观Id]不能为空(In 主题客观版本)!(clsTopicObjectiveVerBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjTopicObjectiveVerEN.topicObjectiveId) == false && GetStrLen(pobjTopicObjectiveVerEN.topicObjectiveId) > 8)
{
 throw new Error("(errid:Watl000059)字段[客观Id(topicObjectiveId)]的长度不能超过8(In 主题客观版本(TopicObjectiveVer))!值:$(pobjTopicObjectiveVerEN.topicObjectiveId)(clsTopicObjectiveVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVerEN.objectiveName) == false && GetStrLen(pobjTopicObjectiveVerEN.objectiveName) > 500)
{
 throw new Error("(errid:Watl000059)字段[客观名称(objectiveName)]的长度不能超过500(In 主题客观版本(TopicObjectiveVer))!值:$(pobjTopicObjectiveVerEN.objectiveName)(clsTopicObjectiveVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVerEN.objectiveType) == false && GetStrLen(pobjTopicObjectiveVerEN.objectiveType) > 2)
{
 throw new Error("(errid:Watl000059)字段[客观类型(objectiveType)]的长度不能超过2(In 主题客观版本(TopicObjectiveVer))!值:$(pobjTopicObjectiveVerEN.objectiveType)(clsTopicObjectiveVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVerEN.sourceId) == false && GetStrLen(pobjTopicObjectiveVerEN.sourceId) > 10)
{
 throw new Error("(errid:Watl000059)字段[来源Id(sourceId)]的长度不能超过10(In 主题客观版本(TopicObjectiveVer))!值:$(pobjTopicObjectiveVerEN.sourceId)(clsTopicObjectiveVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVerEN.updDate) == false && GetStrLen(pobjTopicObjectiveVerEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 主题客观版本(TopicObjectiveVer))!值:$(pobjTopicObjectiveVerEN.updDate)(clsTopicObjectiveVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVerEN.updUser) == false && GetStrLen(pobjTopicObjectiveVerEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 主题客观版本(TopicObjectiveVer))!值:$(pobjTopicObjectiveVerEN.updUser)(clsTopicObjectiveVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVerEN.id_CurrEduCls) == false && GetStrLen(pobjTopicObjectiveVerEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 主题客观版本(TopicObjectiveVer))!值:$(pobjTopicObjectiveVerEN.id_CurrEduCls)(clsTopicObjectiveVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVerEN.pdfContent) == false && GetStrLen(pobjTopicObjectiveVerEN.pdfContent) > 2000)
{
 throw new Error("(errid:Watl000059)字段[Pdf内容(pdfContent)]的长度不能超过2000(In 主题客观版本(TopicObjectiveVer))!值:$(pobjTopicObjectiveVerEN.pdfContent)(clsTopicObjectiveVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVerEN.memo) == false && GetStrLen(pobjTopicObjectiveVerEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 主题客观版本(TopicObjectiveVer))!值:$(pobjTopicObjectiveVerEN.memo)(clsTopicObjectiveVerBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null != pobjTopicObjectiveVerEN.topicObjectiveVId && undefined !== pobjTopicObjectiveVerEN.topicObjectiveVId && tzDataType.isNumber(pobjTopicObjectiveVerEN.topicObjectiveVId) === false)
{
 throw new Error("(errid:Watl000060)字段[主题客观版本Id(topicObjectiveVId)]的值:[$(pobjTopicObjectiveVerEN.topicObjectiveVId)], 非法，应该为数值型(In 主题客观版本(TopicObjectiveVer))!(clsTopicObjectiveVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVerEN.topicObjectiveId) == false && undefined !== pobjTopicObjectiveVerEN.topicObjectiveId && tzDataType.isString(pobjTopicObjectiveVerEN.topicObjectiveId) === false)
{
 throw new Error("(errid:Watl000060)字段[客观Id(topicObjectiveId)]的值:[$(pobjTopicObjectiveVerEN.topicObjectiveId)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveVer))!(clsTopicObjectiveVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVerEN.objectiveName) == false && undefined !== pobjTopicObjectiveVerEN.objectiveName && tzDataType.isString(pobjTopicObjectiveVerEN.objectiveName) === false)
{
 throw new Error("(errid:Watl000060)字段[客观名称(objectiveName)]的值:[$(pobjTopicObjectiveVerEN.objectiveName)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveVer))!(clsTopicObjectiveVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVerEN.objectiveContent) == false && undefined !== pobjTopicObjectiveVerEN.objectiveContent && tzDataType.isString(pobjTopicObjectiveVerEN.objectiveContent) === false)
{
 throw new Error("(errid:Watl000060)字段[客观内容(objectiveContent)]的值:[$(pobjTopicObjectiveVerEN.objectiveContent)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveVer))!(clsTopicObjectiveVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVerEN.objectiveType) == false && undefined !== pobjTopicObjectiveVerEN.objectiveType && tzDataType.isString(pobjTopicObjectiveVerEN.objectiveType) === false)
{
 throw new Error("(errid:Watl000060)字段[客观类型(objectiveType)]的值:[$(pobjTopicObjectiveVerEN.objectiveType)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveVer))!(clsTopicObjectiveVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVerEN.conclusion) == false && undefined !== pobjTopicObjectiveVerEN.conclusion && tzDataType.isString(pobjTopicObjectiveVerEN.conclusion) === false)
{
 throw new Error("(errid:Watl000060)字段[结论(conclusion)]的值:[$(pobjTopicObjectiveVerEN.conclusion)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveVer))!(clsTopicObjectiveVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVerEN.sourceId) == false && undefined !== pobjTopicObjectiveVerEN.sourceId && tzDataType.isString(pobjTopicObjectiveVerEN.sourceId) === false)
{
 throw new Error("(errid:Watl000060)字段[来源Id(sourceId)]的值:[$(pobjTopicObjectiveVerEN.sourceId)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveVer))!(clsTopicObjectiveVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVerEN.updDate) == false && undefined !== pobjTopicObjectiveVerEN.updDate && tzDataType.isString(pobjTopicObjectiveVerEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjTopicObjectiveVerEN.updDate)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveVer))!(clsTopicObjectiveVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVerEN.updUser) == false && undefined !== pobjTopicObjectiveVerEN.updUser && tzDataType.isString(pobjTopicObjectiveVerEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjTopicObjectiveVerEN.updUser)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveVer))!(clsTopicObjectiveVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVerEN.id_CurrEduCls) == false && undefined !== pobjTopicObjectiveVerEN.id_CurrEduCls && tzDataType.isString(pobjTopicObjectiveVerEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjTopicObjectiveVerEN.id_CurrEduCls)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveVer))!(clsTopicObjectiveVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVerEN.pdfContent) == false && undefined !== pobjTopicObjectiveVerEN.pdfContent && tzDataType.isString(pobjTopicObjectiveVerEN.pdfContent) === false)
{
 throw new Error("(errid:Watl000060)字段[Pdf内容(pdfContent)]的值:[$(pobjTopicObjectiveVerEN.pdfContent)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveVer))!(clsTopicObjectiveVerBL:CheckPropertyNew)");
}
if (null != pobjTopicObjectiveVerEN.pdfPageNum && undefined !== pobjTopicObjectiveVerEN.pdfPageNum && tzDataType.isNumber(pobjTopicObjectiveVerEN.pdfPageNum) === false)
{
 throw new Error("(errid:Watl000060)字段[Pdf页码(pdfPageNum)]的值:[$(pobjTopicObjectiveVerEN.pdfPageNum)], 非法，应该为数值型(In 主题客观版本(TopicObjectiveVer))!(clsTopicObjectiveVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVerEN.memo) == false && undefined !== pobjTopicObjectiveVerEN.memo && tzDataType.isString(pobjTopicObjectiveVerEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjTopicObjectiveVerEN.memo)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveVer))!(clsTopicObjectiveVerBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjTopicObjectiveVerEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function TopicObjectiveVer_CheckProperty4Update (pobjTopicObjectiveVerEN: clsTopicObjectiveVerEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjTopicObjectiveVerEN.topicObjectiveId) == false && GetStrLen(pobjTopicObjectiveVerEN.topicObjectiveId) > 8)
{
 throw new Error("(errid:Watl000062)字段[客观Id(topicObjectiveId)]的长度不能超过8(In 主题客观版本(TopicObjectiveVer))!值:$(pobjTopicObjectiveVerEN.topicObjectiveId)(clsTopicObjectiveVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVerEN.objectiveName) == false && GetStrLen(pobjTopicObjectiveVerEN.objectiveName) > 500)
{
 throw new Error("(errid:Watl000062)字段[客观名称(objectiveName)]的长度不能超过500(In 主题客观版本(TopicObjectiveVer))!值:$(pobjTopicObjectiveVerEN.objectiveName)(clsTopicObjectiveVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVerEN.objectiveType) == false && GetStrLen(pobjTopicObjectiveVerEN.objectiveType) > 2)
{
 throw new Error("(errid:Watl000062)字段[客观类型(objectiveType)]的长度不能超过2(In 主题客观版本(TopicObjectiveVer))!值:$(pobjTopicObjectiveVerEN.objectiveType)(clsTopicObjectiveVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVerEN.sourceId) == false && GetStrLen(pobjTopicObjectiveVerEN.sourceId) > 10)
{
 throw new Error("(errid:Watl000062)字段[来源Id(sourceId)]的长度不能超过10(In 主题客观版本(TopicObjectiveVer))!值:$(pobjTopicObjectiveVerEN.sourceId)(clsTopicObjectiveVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVerEN.updDate) == false && GetStrLen(pobjTopicObjectiveVerEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 主题客观版本(TopicObjectiveVer))!值:$(pobjTopicObjectiveVerEN.updDate)(clsTopicObjectiveVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVerEN.updUser) == false && GetStrLen(pobjTopicObjectiveVerEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 主题客观版本(TopicObjectiveVer))!值:$(pobjTopicObjectiveVerEN.updUser)(clsTopicObjectiveVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVerEN.id_CurrEduCls) == false && GetStrLen(pobjTopicObjectiveVerEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 主题客观版本(TopicObjectiveVer))!值:$(pobjTopicObjectiveVerEN.id_CurrEduCls)(clsTopicObjectiveVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVerEN.pdfContent) == false && GetStrLen(pobjTopicObjectiveVerEN.pdfContent) > 2000)
{
 throw new Error("(errid:Watl000062)字段[Pdf内容(pdfContent)]的长度不能超过2000(In 主题客观版本(TopicObjectiveVer))!值:$(pobjTopicObjectiveVerEN.pdfContent)(clsTopicObjectiveVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVerEN.memo) == false && GetStrLen(pobjTopicObjectiveVerEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 主题客观版本(TopicObjectiveVer))!值:$(pobjTopicObjectiveVerEN.memo)(clsTopicObjectiveVerBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null != pobjTopicObjectiveVerEN.topicObjectiveVId && undefined !== pobjTopicObjectiveVerEN.topicObjectiveVId && tzDataType.isNumber(pobjTopicObjectiveVerEN.topicObjectiveVId) === false)
{
 throw new Error("(errid:Watl000063)字段[主题客观版本Id(topicObjectiveVId)]的值:[$(pobjTopicObjectiveVerEN.topicObjectiveVId)], 非法，应该为数值型(In 主题客观版本(TopicObjectiveVer))!(clsTopicObjectiveVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVerEN.topicObjectiveId) == false && undefined !== pobjTopicObjectiveVerEN.topicObjectiveId && tzDataType.isString(pobjTopicObjectiveVerEN.topicObjectiveId) === false)
{
 throw new Error("(errid:Watl000063)字段[客观Id(topicObjectiveId)]的值:[$(pobjTopicObjectiveVerEN.topicObjectiveId)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveVer))!(clsTopicObjectiveVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVerEN.objectiveName) == false && undefined !== pobjTopicObjectiveVerEN.objectiveName && tzDataType.isString(pobjTopicObjectiveVerEN.objectiveName) === false)
{
 throw new Error("(errid:Watl000063)字段[客观名称(objectiveName)]的值:[$(pobjTopicObjectiveVerEN.objectiveName)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveVer))!(clsTopicObjectiveVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVerEN.objectiveContent) == false && undefined !== pobjTopicObjectiveVerEN.objectiveContent && tzDataType.isString(pobjTopicObjectiveVerEN.objectiveContent) === false)
{
 throw new Error("(errid:Watl000063)字段[客观内容(objectiveContent)]的值:[$(pobjTopicObjectiveVerEN.objectiveContent)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveVer))!(clsTopicObjectiveVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVerEN.objectiveType) == false && undefined !== pobjTopicObjectiveVerEN.objectiveType && tzDataType.isString(pobjTopicObjectiveVerEN.objectiveType) === false)
{
 throw new Error("(errid:Watl000063)字段[客观类型(objectiveType)]的值:[$(pobjTopicObjectiveVerEN.objectiveType)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveVer))!(clsTopicObjectiveVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVerEN.conclusion) == false && undefined !== pobjTopicObjectiveVerEN.conclusion && tzDataType.isString(pobjTopicObjectiveVerEN.conclusion) === false)
{
 throw new Error("(errid:Watl000063)字段[结论(conclusion)]的值:[$(pobjTopicObjectiveVerEN.conclusion)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveVer))!(clsTopicObjectiveVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVerEN.sourceId) == false && undefined !== pobjTopicObjectiveVerEN.sourceId && tzDataType.isString(pobjTopicObjectiveVerEN.sourceId) === false)
{
 throw new Error("(errid:Watl000063)字段[来源Id(sourceId)]的值:[$(pobjTopicObjectiveVerEN.sourceId)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveVer))!(clsTopicObjectiveVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVerEN.updDate) == false && undefined !== pobjTopicObjectiveVerEN.updDate && tzDataType.isString(pobjTopicObjectiveVerEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjTopicObjectiveVerEN.updDate)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveVer))!(clsTopicObjectiveVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVerEN.updUser) == false && undefined !== pobjTopicObjectiveVerEN.updUser && tzDataType.isString(pobjTopicObjectiveVerEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjTopicObjectiveVerEN.updUser)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveVer))!(clsTopicObjectiveVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVerEN.id_CurrEduCls) == false && undefined !== pobjTopicObjectiveVerEN.id_CurrEduCls && tzDataType.isString(pobjTopicObjectiveVerEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjTopicObjectiveVerEN.id_CurrEduCls)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveVer))!(clsTopicObjectiveVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVerEN.pdfContent) == false && undefined !== pobjTopicObjectiveVerEN.pdfContent && tzDataType.isString(pobjTopicObjectiveVerEN.pdfContent) === false)
{
 throw new Error("(errid:Watl000063)字段[Pdf内容(pdfContent)]的值:[$(pobjTopicObjectiveVerEN.pdfContent)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveVer))!(clsTopicObjectiveVerBL:CheckProperty4Update)");
}
if (null != pobjTopicObjectiveVerEN.pdfPageNum && undefined !== pobjTopicObjectiveVerEN.pdfPageNum && tzDataType.isNumber(pobjTopicObjectiveVerEN.pdfPageNum) === false)
{
 throw new Error("(errid:Watl000063)字段[Pdf页码(pdfPageNum)]的值:[$(pobjTopicObjectiveVerEN.pdfPageNum)], 非法，应该为数值型(In 主题客观版本(TopicObjectiveVer))!(clsTopicObjectiveVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVerEN.memo) == false && undefined !== pobjTopicObjectiveVerEN.memo && tzDataType.isString(pobjTopicObjectiveVerEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjTopicObjectiveVerEN.memo)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveVer))!(clsTopicObjectiveVerBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjTopicObjectiveVerEN.topicObjectiveVId 
 || pobjTopicObjectiveVerEN.topicObjectiveVId != null && pobjTopicObjectiveVerEN.topicObjectiveVId.toString()  ===  "")
{
 throw new Error("(errid:Watl000064)字段[主题客观版本Id]不能为空(In 主题客观版本)!(clsTopicObjectiveVerBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjTopicObjectiveVerEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function TopicObjectiveVer_GetJSONStrByObj (pobjTopicObjectiveVerEN: clsTopicObjectiveVerEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjTopicObjectiveVerEN.sfUpdFldSetStr = pobjTopicObjectiveVerEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjTopicObjectiveVerEN);
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
export function TopicObjectiveVer_GetObjLstByJSONStr (strJSON: string): Array<clsTopicObjectiveVerEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrTopicObjectiveVerObjLst = new Array<clsTopicObjectiveVerEN>();
if (strJSON === "")
{
return arrTopicObjectiveVerObjLst;
}
try
{
arrTopicObjectiveVerObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrTopicObjectiveVerObjLst;
}
return arrTopicObjectiveVerObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrTopicObjectiveVerObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function TopicObjectiveVer_GetObjLstByJSONObjLst (arrTopicObjectiveVerObjLstS: Array<clsTopicObjectiveVerEN>): Array<clsTopicObjectiveVerEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrTopicObjectiveVerObjLst = new Array<clsTopicObjectiveVerEN>();
for (const objInFor of arrTopicObjectiveVerObjLstS) {
const obj1 = TopicObjectiveVer_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrTopicObjectiveVerObjLst.push(obj1);
}
return arrTopicObjectiveVerObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function TopicObjectiveVer_GetObjByJSONStr (strJSON: string): clsTopicObjectiveVerEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjTopicObjectiveVerEN = new clsTopicObjectiveVerEN();
if (strJSON === "")
{
return pobjTopicObjectiveVerEN;
}
try
{
pobjTopicObjectiveVerEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjTopicObjectiveVerEN;
}
return pobjTopicObjectiveVerEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function TopicObjectiveVer_GetCombineCondition(objTopicObjectiveVer_Cond: clsTopicObjectiveVerEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objTopicObjectiveVer_Cond.dicFldComparisonOp, clsTopicObjectiveVerEN.con_TopicObjectiveVId) == true)
{
const strComparisonOp_TopicObjectiveVId:string = objTopicObjectiveVer_Cond.dicFldComparisonOp[clsTopicObjectiveVerEN.con_TopicObjectiveVId];
strWhereCond += Format(" And {0} {2} {1}", clsTopicObjectiveVerEN.con_TopicObjectiveVId, objTopicObjectiveVer_Cond.topicObjectiveVId, strComparisonOp_TopicObjectiveVId);
}
if (Object.prototype.hasOwnProperty.call(objTopicObjectiveVer_Cond.dicFldComparisonOp, clsTopicObjectiveVerEN.con_TopicObjectiveId) == true)
{
const strComparisonOp_TopicObjectiveId:string = objTopicObjectiveVer_Cond.dicFldComparisonOp[clsTopicObjectiveVerEN.con_TopicObjectiveId];
strWhereCond += Format(" And {0} {2} '{1}'", clsTopicObjectiveVerEN.con_TopicObjectiveId, objTopicObjectiveVer_Cond.topicObjectiveId, strComparisonOp_TopicObjectiveId);
}
if (Object.prototype.hasOwnProperty.call(objTopicObjectiveVer_Cond.dicFldComparisonOp, clsTopicObjectiveVerEN.con_ObjectiveName) == true)
{
const strComparisonOp_ObjectiveName:string = objTopicObjectiveVer_Cond.dicFldComparisonOp[clsTopicObjectiveVerEN.con_ObjectiveName];
strWhereCond += Format(" And {0} {2} '{1}'", clsTopicObjectiveVerEN.con_ObjectiveName, objTopicObjectiveVer_Cond.objectiveName, strComparisonOp_ObjectiveName);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objTopicObjectiveVer_Cond.dicFldComparisonOp, clsTopicObjectiveVerEN.con_ObjectiveType) == true)
{
const strComparisonOp_ObjectiveType:string = objTopicObjectiveVer_Cond.dicFldComparisonOp[clsTopicObjectiveVerEN.con_ObjectiveType];
strWhereCond += Format(" And {0} {2} '{1}'", clsTopicObjectiveVerEN.con_ObjectiveType, objTopicObjectiveVer_Cond.objectiveType, strComparisonOp_ObjectiveType);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objTopicObjectiveVer_Cond.dicFldComparisonOp, clsTopicObjectiveVerEN.con_SourceId) == true)
{
const strComparisonOp_SourceId:string = objTopicObjectiveVer_Cond.dicFldComparisonOp[clsTopicObjectiveVerEN.con_SourceId];
strWhereCond += Format(" And {0} {2} '{1}'", clsTopicObjectiveVerEN.con_SourceId, objTopicObjectiveVer_Cond.sourceId, strComparisonOp_SourceId);
}
if (Object.prototype.hasOwnProperty.call(objTopicObjectiveVer_Cond.dicFldComparisonOp, clsTopicObjectiveVerEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objTopicObjectiveVer_Cond.dicFldComparisonOp[clsTopicObjectiveVerEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsTopicObjectiveVerEN.con_UpdDate, objTopicObjectiveVer_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objTopicObjectiveVer_Cond.dicFldComparisonOp, clsTopicObjectiveVerEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objTopicObjectiveVer_Cond.dicFldComparisonOp[clsTopicObjectiveVerEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsTopicObjectiveVerEN.con_UpdUser, objTopicObjectiveVer_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objTopicObjectiveVer_Cond.dicFldComparisonOp, clsTopicObjectiveVerEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objTopicObjectiveVer_Cond.dicFldComparisonOp[clsTopicObjectiveVerEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsTopicObjectiveVerEN.con_id_CurrEduCls, objTopicObjectiveVer_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (Object.prototype.hasOwnProperty.call(objTopicObjectiveVer_Cond.dicFldComparisonOp, clsTopicObjectiveVerEN.con_PdfContent) == true)
{
const strComparisonOp_PdfContent:string = objTopicObjectiveVer_Cond.dicFldComparisonOp[clsTopicObjectiveVerEN.con_PdfContent];
strWhereCond += Format(" And {0} {2} '{1}'", clsTopicObjectiveVerEN.con_PdfContent, objTopicObjectiveVer_Cond.pdfContent, strComparisonOp_PdfContent);
}
if (Object.prototype.hasOwnProperty.call(objTopicObjectiveVer_Cond.dicFldComparisonOp, clsTopicObjectiveVerEN.con_PdfPageNum) == true)
{
const strComparisonOp_PdfPageNum:string = objTopicObjectiveVer_Cond.dicFldComparisonOp[clsTopicObjectiveVerEN.con_PdfPageNum];
strWhereCond += Format(" And {0} {2} {1}", clsTopicObjectiveVerEN.con_PdfPageNum, objTopicObjectiveVer_Cond.pdfPageNum, strComparisonOp_PdfPageNum);
}
if (Object.prototype.hasOwnProperty.call(objTopicObjectiveVer_Cond.dicFldComparisonOp, clsTopicObjectiveVerEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objTopicObjectiveVer_Cond.dicFldComparisonOp[clsTopicObjectiveVerEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsTopicObjectiveVerEN.con_Memo, objTopicObjectiveVer_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--TopicObjectiveVer(主题客观版本),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param lngTopicObjectiveVId: 主题客观版本Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function TopicObjectiveVer_GetUniCondStr_TopicObjectiveVId(objTopicObjectiveVerEN: clsTopicObjectiveVerEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and TopicObjectiveVId = '{0}'", objTopicObjectiveVerEN.topicObjectiveVId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--TopicObjectiveVer(主题客观版本),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param lngTopicObjectiveVId: 主题客观版本Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function TopicObjectiveVer_GetUniCondStr4Update_TopicObjectiveVId(objTopicObjectiveVerEN: clsTopicObjectiveVerEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and TopicObjectiveVId <> '{0}'", objTopicObjectiveVerEN.topicObjectiveVId);
 strWhereCond +=  Format(" and TopicObjectiveVId = '{0}'", objTopicObjectiveVerEN.topicObjectiveVId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objTopicObjectiveVerENS:源对象
 * @param objTopicObjectiveVerENT:目标对象
*/
export function TopicObjectiveVer_CopyObjTo(objTopicObjectiveVerENS: clsTopicObjectiveVerEN , objTopicObjectiveVerENT: clsTopicObjectiveVerEN ): void 
{
objTopicObjectiveVerENT.topicObjectiveVId = objTopicObjectiveVerENS.topicObjectiveVId; //主题客观版本Id
objTopicObjectiveVerENT.topicObjectiveId = objTopicObjectiveVerENS.topicObjectiveId; //客观Id
objTopicObjectiveVerENT.objectiveName = objTopicObjectiveVerENS.objectiveName; //客观名称
objTopicObjectiveVerENT.objectiveContent = objTopicObjectiveVerENS.objectiveContent; //客观内容
objTopicObjectiveVerENT.objectiveType = objTopicObjectiveVerENS.objectiveType; //客观类型
objTopicObjectiveVerENT.conclusion = objTopicObjectiveVerENS.conclusion; //结论
objTopicObjectiveVerENT.sourceId = objTopicObjectiveVerENS.sourceId; //来源Id
objTopicObjectiveVerENT.updDate = objTopicObjectiveVerENS.updDate; //修改日期
objTopicObjectiveVerENT.updUser = objTopicObjectiveVerENS.updUser; //修改人
objTopicObjectiveVerENT.id_CurrEduCls = objTopicObjectiveVerENS.id_CurrEduCls; //教学班流水号
objTopicObjectiveVerENT.pdfContent = objTopicObjectiveVerENS.pdfContent; //Pdf内容
objTopicObjectiveVerENT.pdfPageNum = objTopicObjectiveVerENS.pdfPageNum; //Pdf页码
objTopicObjectiveVerENT.memo = objTopicObjectiveVerENS.memo; //备注
objTopicObjectiveVerENT.sfUpdFldSetStr = objTopicObjectiveVerENS.updFldString; //sfUpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objTopicObjectiveVerENS:源对象
 * @param objTopicObjectiveVerENT:目标对象
*/
export function TopicObjectiveVer_GetObjFromJsonObj(objTopicObjectiveVerENS: clsTopicObjectiveVerEN): clsTopicObjectiveVerEN 
{
 const objTopicObjectiveVerENT: clsTopicObjectiveVerEN = new clsTopicObjectiveVerEN();
ObjectAssign(objTopicObjectiveVerENT, objTopicObjectiveVerENS);
 return objTopicObjectiveVerENT;
}