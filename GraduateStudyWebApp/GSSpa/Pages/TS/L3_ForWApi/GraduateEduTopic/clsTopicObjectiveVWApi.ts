
 /**
 * 类名:clsTopicObjectiveVWApi
 * 表名:TopicObjectiveV(01120648)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:46:59
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
 * 主题客观版本(TopicObjectiveV)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { clsTopicObjectiveVEN } from "../../L0_Entity/GraduateEduTopic/clsTopicObjectiveVEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { tzDataType } from "../../PubFun/jsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const topicObjectiveV_Controller = "TopicObjectiveVApi";
 export const topicObjectiveV_ConstructorName = "topicObjectiveV";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngTopicObjectiveVId:关键字
 * @returns 对象
 **/
export async function TopicObjectiveV_GetObjByTopicObjectiveVIdAsync(lngTopicObjectiveVId: number): Promise<clsTopicObjectiveVEN>  
{
const strThisFuncName = "GetObjByTopicObjectiveVIdAsync";

if (lngTopicObjectiveVId == 0)
{
  const strMsg = Format("参数:[lngTopicObjectiveVId]不能为空！(In GetObjByTopicObjectiveVIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjByTopicObjectiveVId";
const strUrl = GetWebApiUrl(topicObjectiveV_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", topicObjectiveV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objTopicObjectiveV = TopicObjectiveV_GetObjFromJsonObj(returnObj);
return objTopicObjectiveV;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicObjectiveV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicObjectiveV_ConstructorName, strThisFuncName);
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
export function TopicObjectiveV_SortFun_Defa(a:clsTopicObjectiveVEN , b:clsTopicObjectiveVEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.topicObjectiveVId-b.topicObjectiveVId;
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
export function TopicObjectiveV_SortFun_Defa_2Fld(a:clsTopicObjectiveVEN , b:clsTopicObjectiveVEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.topicObjectiveId == b.topicObjectiveId) return a.objectiveName.localeCompare(b.objectiveName);
else return a.topicObjectiveId.localeCompare(b.topicObjectiveId);
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
export function TopicObjectiveV_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsTopicObjectiveVEN.con_TopicObjectiveVId:
return (a: clsTopicObjectiveVEN, b: clsTopicObjectiveVEN) => {
return a.topicObjectiveVId-b.topicObjectiveVId;
}
case clsTopicObjectiveVEN.con_TopicObjectiveId:
return (a: clsTopicObjectiveVEN, b: clsTopicObjectiveVEN) => {
return a.topicObjectiveId.localeCompare(b.topicObjectiveId);
}
case clsTopicObjectiveVEN.con_ObjectiveName:
return (a: clsTopicObjectiveVEN, b: clsTopicObjectiveVEN) => {
return a.objectiveName.localeCompare(b.objectiveName);
}
case clsTopicObjectiveVEN.con_ObjectiveContent:
return (a: clsTopicObjectiveVEN, b: clsTopicObjectiveVEN) => {
return a.objectiveContent.localeCompare(b.objectiveContent);
}
case clsTopicObjectiveVEN.con_ObjectiveType:
return (a: clsTopicObjectiveVEN, b: clsTopicObjectiveVEN) => {
return a.objectiveType.localeCompare(b.objectiveType);
}
case clsTopicObjectiveVEN.con_Conclusion:
return (a: clsTopicObjectiveVEN, b: clsTopicObjectiveVEN) => {
return a.conclusion.localeCompare(b.conclusion);
}
case clsTopicObjectiveVEN.con_SourceId:
return (a: clsTopicObjectiveVEN, b: clsTopicObjectiveVEN) => {
return a.sourceId.localeCompare(b.sourceId);
}
case clsTopicObjectiveVEN.con_UpdDate:
return (a: clsTopicObjectiveVEN, b: clsTopicObjectiveVEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsTopicObjectiveVEN.con_UpdUser:
return (a: clsTopicObjectiveVEN, b: clsTopicObjectiveVEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsTopicObjectiveVEN.con_id_CurrEduCls:
return (a: clsTopicObjectiveVEN, b: clsTopicObjectiveVEN) => {
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
case clsTopicObjectiveVEN.con_PdfContent:
return (a: clsTopicObjectiveVEN, b: clsTopicObjectiveVEN) => {
return a.pdfContent.localeCompare(b.pdfContent);
}
case clsTopicObjectiveVEN.con_PdfPageNum:
return (a: clsTopicObjectiveVEN, b: clsTopicObjectiveVEN) => {
return a.pdfPageNum-b.pdfPageNum;
}
case clsTopicObjectiveVEN.con_Memo:
return (a: clsTopicObjectiveVEN, b: clsTopicObjectiveVEN) => {
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[TopicObjectiveV]中不存在！(in ${ topicObjectiveV_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsTopicObjectiveVEN.con_TopicObjectiveVId:
return (a: clsTopicObjectiveVEN, b: clsTopicObjectiveVEN) => {
return b.topicObjectiveVId-a.topicObjectiveVId;
}
case clsTopicObjectiveVEN.con_TopicObjectiveId:
return (a: clsTopicObjectiveVEN, b: clsTopicObjectiveVEN) => {
return b.topicObjectiveId.localeCompare(a.topicObjectiveId);
}
case clsTopicObjectiveVEN.con_ObjectiveName:
return (a: clsTopicObjectiveVEN, b: clsTopicObjectiveVEN) => {
return b.objectiveName.localeCompare(a.objectiveName);
}
case clsTopicObjectiveVEN.con_ObjectiveContent:
return (a: clsTopicObjectiveVEN, b: clsTopicObjectiveVEN) => {
return b.objectiveContent.localeCompare(a.objectiveContent);
}
case clsTopicObjectiveVEN.con_ObjectiveType:
return (a: clsTopicObjectiveVEN, b: clsTopicObjectiveVEN) => {
return b.objectiveType.localeCompare(a.objectiveType);
}
case clsTopicObjectiveVEN.con_Conclusion:
return (a: clsTopicObjectiveVEN, b: clsTopicObjectiveVEN) => {
return b.conclusion.localeCompare(a.conclusion);
}
case clsTopicObjectiveVEN.con_SourceId:
return (a: clsTopicObjectiveVEN, b: clsTopicObjectiveVEN) => {
return b.sourceId.localeCompare(a.sourceId);
}
case clsTopicObjectiveVEN.con_UpdDate:
return (a: clsTopicObjectiveVEN, b: clsTopicObjectiveVEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsTopicObjectiveVEN.con_UpdUser:
return (a: clsTopicObjectiveVEN, b: clsTopicObjectiveVEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsTopicObjectiveVEN.con_id_CurrEduCls:
return (a: clsTopicObjectiveVEN, b: clsTopicObjectiveVEN) => {
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
case clsTopicObjectiveVEN.con_PdfContent:
return (a: clsTopicObjectiveVEN, b: clsTopicObjectiveVEN) => {
return b.pdfContent.localeCompare(a.pdfContent);
}
case clsTopicObjectiveVEN.con_PdfPageNum:
return (a: clsTopicObjectiveVEN, b: clsTopicObjectiveVEN) => {
return b.pdfPageNum-a.pdfPageNum;
}
case clsTopicObjectiveVEN.con_Memo:
return (a: clsTopicObjectiveVEN, b: clsTopicObjectiveVEN) => {
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[TopicObjectiveV]中不存在！(in ${ topicObjectiveV_ConstructorName}.${ strThisFuncName})`;
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
export async function TopicObjectiveV_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsTopicObjectiveVEN.con_TopicObjectiveVId:
return (obj: clsTopicObjectiveVEN) => {
return obj.topicObjectiveVId === value;
}
case clsTopicObjectiveVEN.con_TopicObjectiveId:
return (obj: clsTopicObjectiveVEN) => {
return obj.topicObjectiveId === value;
}
case clsTopicObjectiveVEN.con_ObjectiveName:
return (obj: clsTopicObjectiveVEN) => {
return obj.objectiveName === value;
}
case clsTopicObjectiveVEN.con_ObjectiveContent:
return (obj: clsTopicObjectiveVEN) => {
return obj.objectiveContent === value;
}
case clsTopicObjectiveVEN.con_ObjectiveType:
return (obj: clsTopicObjectiveVEN) => {
return obj.objectiveType === value;
}
case clsTopicObjectiveVEN.con_Conclusion:
return (obj: clsTopicObjectiveVEN) => {
return obj.conclusion === value;
}
case clsTopicObjectiveVEN.con_SourceId:
return (obj: clsTopicObjectiveVEN) => {
return obj.sourceId === value;
}
case clsTopicObjectiveVEN.con_UpdDate:
return (obj: clsTopicObjectiveVEN) => {
return obj.updDate === value;
}
case clsTopicObjectiveVEN.con_UpdUser:
return (obj: clsTopicObjectiveVEN) => {
return obj.updUser === value;
}
case clsTopicObjectiveVEN.con_id_CurrEduCls:
return (obj: clsTopicObjectiveVEN) => {
return obj.id_CurrEduCls === value;
}
case clsTopicObjectiveVEN.con_PdfContent:
return (obj: clsTopicObjectiveVEN) => {
return obj.pdfContent === value;
}
case clsTopicObjectiveVEN.con_PdfPageNum:
return (obj: clsTopicObjectiveVEN) => {
return obj.pdfPageNum === value;
}
case clsTopicObjectiveVEN.con_Memo:
return (obj: clsTopicObjectiveVEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[TopicObjectiveV]中不存在！(in ${ topicObjectiveV_ConstructorName}.${ strThisFuncName})`;
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
export async function TopicObjectiveV_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(topicObjectiveV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicObjectiveV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicObjectiveV_ConstructorName, strThisFuncName);
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
export async function TopicObjectiveV_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(topicObjectiveV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicObjectiveV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicObjectiveV_ConstructorName, strThisFuncName);
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
export async function TopicObjectiveV_GetFirstObjAsync(strWhereCond: string): Promise<clsTopicObjectiveVEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(topicObjectiveV_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", topicObjectiveV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objTopicObjectiveV = TopicObjectiveV_GetObjFromJsonObj(returnObj);
return objTopicObjectiveV;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicObjectiveV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicObjectiveV_ConstructorName, strThisFuncName);
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
export async function TopicObjectiveV_GetObjLstAsync(strWhereCond: string): Promise<Array<clsTopicObjectiveVEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(topicObjectiveV_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", topicObjectiveV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = TopicObjectiveV_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicObjectiveV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicObjectiveV_ConstructorName, strThisFuncName);
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
export async function TopicObjectiveV_GetObjLstByTopicObjectiveVIdLstAsync(arrTopicObjectiveVId: Array<string>): Promise<Array<clsTopicObjectiveVEN>>  
{
const strThisFuncName = "GetObjLstByTopicObjectiveVIdLstAsync";
const strAction = "GetObjLstByTopicObjectiveVIdLst";
const strUrl = GetWebApiUrl(topicObjectiveV_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrTopicObjectiveVId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", topicObjectiveV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = TopicObjectiveV_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicObjectiveV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicObjectiveV_ConstructorName, strThisFuncName);
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
export async function TopicObjectiveV_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsTopicObjectiveVEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(topicObjectiveV_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", topicObjectiveV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = TopicObjectiveV_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicObjectiveV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicObjectiveV_ConstructorName, strThisFuncName);
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
export async function TopicObjectiveV_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsTopicObjectiveVEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(topicObjectiveV_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", topicObjectiveV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = TopicObjectiveV_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicObjectiveV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicObjectiveV_ConstructorName, strThisFuncName);
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
export async function TopicObjectiveV_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(topicObjectiveV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicObjectiveV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicObjectiveV_ConstructorName, strThisFuncName);
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
export async function TopicObjectiveV_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsTopicObjectiveVEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(topicObjectiveV_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", topicObjectiveV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = TopicObjectiveV_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicObjectiveV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicObjectiveV_ConstructorName, strThisFuncName);
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
export async function TopicObjectiveV_DelRecordAsync(lngTopicObjectiveVId: number): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(topicObjectiveV_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, lngTopicObjectiveVId);
try
{
const response = await axios.delete(strUrl,
{
params: { "Id": lngTopicObjectiveVId, }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicObjectiveV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicObjectiveV_ConstructorName, strThisFuncName);
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
export async function TopicObjectiveV_DelTopicObjectiveVsAsync(arrTopicObjectiveVId: Array<string>): Promise<number> 
{
const strThisFuncName = "DelTopicObjectiveVsAsync";
const strAction = "DelTopicObjectiveVs";
const strUrl = GetWebApiUrl(topicObjectiveV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicObjectiveV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicObjectiveV_ConstructorName, strThisFuncName);
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
export async function TopicObjectiveV_DelTopicObjectiveVsByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "DelTopicObjectiveVsByCondAsync";
const strAction = "DelTopicObjectiveVsByCond";
const strUrl = GetWebApiUrl(topicObjectiveV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicObjectiveV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicObjectiveV_ConstructorName, strThisFuncName);
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
 * @param objTopicObjectiveVEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function TopicObjectiveV_AddNewRecordAsync(objTopicObjectiveVEN: clsTopicObjectiveVEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objTopicObjectiveVEN);
const strUrl = GetWebApiUrl(topicObjectiveV_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopicObjectiveVEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicObjectiveV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicObjectiveV_ConstructorName, strThisFuncName);
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
 * @param objTopicObjectiveVEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function TopicObjectiveV_AddNewRecordWithReturnKeyAsync(objTopicObjectiveVEN: clsTopicObjectiveVEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(topicObjectiveV_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopicObjectiveVEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicObjectiveV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicObjectiveV_ConstructorName, strThisFuncName);
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
 * @param objTopicObjectiveVEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function TopicObjectiveV_AddNewRecordWithReturnKey(objTopicObjectiveVEN: clsTopicObjectiveVEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objTopicObjectiveVEN.topicObjectiveVId === null || objTopicObjectiveVEN.topicObjectiveVId === 0)
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(topicObjectiveV_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopicObjectiveVEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicObjectiveV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicObjectiveV_ConstructorName, strThisFuncName);
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
 * @param objTopicObjectiveVEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function TopicObjectiveV_UpdateRecordAsync(objTopicObjectiveVEN: clsTopicObjectiveVEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objTopicObjectiveVEN.sf_UpdFldSetStr === undefined || objTopicObjectiveVEN.sf_UpdFldSetStr === null || objTopicObjectiveVEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objTopicObjectiveVEN.topicObjectiveVId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(topicObjectiveV_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopicObjectiveVEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicObjectiveV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicObjectiveV_ConstructorName, strThisFuncName);
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
 * @param objTopicObjectiveVEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function TopicObjectiveV_UpdateWithConditionAsync(objTopicObjectiveVEN: clsTopicObjectiveVEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objTopicObjectiveVEN.sf_UpdFldSetStr === undefined || objTopicObjectiveVEN.sf_UpdFldSetStr === null || objTopicObjectiveVEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objTopicObjectiveVEN.topicObjectiveVId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(topicObjectiveV_Controller, strAction);
objTopicObjectiveVEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objTopicObjectiveVEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicObjectiveV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicObjectiveV_ConstructorName, strThisFuncName);
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
export async function TopicObjectiveV_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(topicObjectiveV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicObjectiveV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicObjectiveV_ConstructorName, strThisFuncName);
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
export async function TopicObjectiveV_IsExist(lngTopicObjectiveVId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(topicObjectiveV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicObjectiveV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicObjectiveV_ConstructorName, strThisFuncName);
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
export async function TopicObjectiveV_IsExistAsync(lngTopicObjectiveVId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(topicObjectiveV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicObjectiveV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicObjectiveV_ConstructorName, strThisFuncName);
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
export async function TopicObjectiveV_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(topicObjectiveV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicObjectiveV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicObjectiveV_ConstructorName, strThisFuncName);
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
export async function TopicObjectiveV_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(topicObjectiveV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicObjectiveV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicObjectiveV_ConstructorName, strThisFuncName);
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
export function TopicObjectiveV_GetWebApiUrl(strController: string, strAction: string): string {
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
export function TopicObjectiveV_CheckPropertyNew(pobjTopicObjectiveVEN: clsTopicObjectiveVEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjTopicObjectiveVEN.topicObjectiveId) === true )
{
 throw new Error("(errid:Watl000058)字段[客观Id]不能为空(In 主题客观版本)!(clsTopicObjectiveVBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjTopicObjectiveVEN.topicObjectiveId) == false && GetStrLen(pobjTopicObjectiveVEN.topicObjectiveId) > 8)
{
 throw new Error("(errid:Watl000059)字段[客观Id(topicObjectiveId)]的长度不能超过8(In 主题客观版本(TopicObjectiveV))!值:$(pobjTopicObjectiveVEN.topicObjectiveId)(clsTopicObjectiveVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVEN.objectiveName) == false && GetStrLen(pobjTopicObjectiveVEN.objectiveName) > 500)
{
 throw new Error("(errid:Watl000059)字段[客观名称(objectiveName)]的长度不能超过500(In 主题客观版本(TopicObjectiveV))!值:$(pobjTopicObjectiveVEN.objectiveName)(clsTopicObjectiveVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVEN.objectiveType) == false && GetStrLen(pobjTopicObjectiveVEN.objectiveType) > 2)
{
 throw new Error("(errid:Watl000059)字段[客观类型(objectiveType)]的长度不能超过2(In 主题客观版本(TopicObjectiveV))!值:$(pobjTopicObjectiveVEN.objectiveType)(clsTopicObjectiveVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVEN.sourceId) == false && GetStrLen(pobjTopicObjectiveVEN.sourceId) > 10)
{
 throw new Error("(errid:Watl000059)字段[来源Id(sourceId)]的长度不能超过10(In 主题客观版本(TopicObjectiveV))!值:$(pobjTopicObjectiveVEN.sourceId)(clsTopicObjectiveVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVEN.updDate) == false && GetStrLen(pobjTopicObjectiveVEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 主题客观版本(TopicObjectiveV))!值:$(pobjTopicObjectiveVEN.updDate)(clsTopicObjectiveVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVEN.updUser) == false && GetStrLen(pobjTopicObjectiveVEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 主题客观版本(TopicObjectiveV))!值:$(pobjTopicObjectiveVEN.updUser)(clsTopicObjectiveVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVEN.id_CurrEduCls) == false && GetStrLen(pobjTopicObjectiveVEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 主题客观版本(TopicObjectiveV))!值:$(pobjTopicObjectiveVEN.id_CurrEduCls)(clsTopicObjectiveVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVEN.pdfContent) == false && GetStrLen(pobjTopicObjectiveVEN.pdfContent) > 2000)
{
 throw new Error("(errid:Watl000059)字段[Pdf内容(pdfContent)]的长度不能超过2000(In 主题客观版本(TopicObjectiveV))!值:$(pobjTopicObjectiveVEN.pdfContent)(clsTopicObjectiveVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVEN.memo) == false && GetStrLen(pobjTopicObjectiveVEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 主题客观版本(TopicObjectiveV))!值:$(pobjTopicObjectiveVEN.memo)(clsTopicObjectiveVBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null != pobjTopicObjectiveVEN.topicObjectiveVId && undefined !== pobjTopicObjectiveVEN.topicObjectiveVId && tzDataType.isNumber(pobjTopicObjectiveVEN.topicObjectiveVId) === false)
{
 throw new Error("(errid:Watl000060)字段[主题客观版本Id(topicObjectiveVId)]的值:[$(pobjTopicObjectiveVEN.topicObjectiveVId)], 非法，应该为数值型(In 主题客观版本(TopicObjectiveV))!(clsTopicObjectiveVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVEN.topicObjectiveId) == false && undefined !== pobjTopicObjectiveVEN.topicObjectiveId && tzDataType.isString(pobjTopicObjectiveVEN.topicObjectiveId) === false)
{
 throw new Error("(errid:Watl000060)字段[客观Id(topicObjectiveId)]的值:[$(pobjTopicObjectiveVEN.topicObjectiveId)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveV))!(clsTopicObjectiveVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVEN.objectiveName) == false && undefined !== pobjTopicObjectiveVEN.objectiveName && tzDataType.isString(pobjTopicObjectiveVEN.objectiveName) === false)
{
 throw new Error("(errid:Watl000060)字段[客观名称(objectiveName)]的值:[$(pobjTopicObjectiveVEN.objectiveName)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveV))!(clsTopicObjectiveVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVEN.objectiveContent) == false && undefined !== pobjTopicObjectiveVEN.objectiveContent && tzDataType.isString(pobjTopicObjectiveVEN.objectiveContent) === false)
{
 throw new Error("(errid:Watl000060)字段[客观内容(objectiveContent)]的值:[$(pobjTopicObjectiveVEN.objectiveContent)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveV))!(clsTopicObjectiveVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVEN.objectiveType) == false && undefined !== pobjTopicObjectiveVEN.objectiveType && tzDataType.isString(pobjTopicObjectiveVEN.objectiveType) === false)
{
 throw new Error("(errid:Watl000060)字段[客观类型(objectiveType)]的值:[$(pobjTopicObjectiveVEN.objectiveType)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveV))!(clsTopicObjectiveVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVEN.conclusion) == false && undefined !== pobjTopicObjectiveVEN.conclusion && tzDataType.isString(pobjTopicObjectiveVEN.conclusion) === false)
{
 throw new Error("(errid:Watl000060)字段[结论(conclusion)]的值:[$(pobjTopicObjectiveVEN.conclusion)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveV))!(clsTopicObjectiveVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVEN.sourceId) == false && undefined !== pobjTopicObjectiveVEN.sourceId && tzDataType.isString(pobjTopicObjectiveVEN.sourceId) === false)
{
 throw new Error("(errid:Watl000060)字段[来源Id(sourceId)]的值:[$(pobjTopicObjectiveVEN.sourceId)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveV))!(clsTopicObjectiveVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVEN.updDate) == false && undefined !== pobjTopicObjectiveVEN.updDate && tzDataType.isString(pobjTopicObjectiveVEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjTopicObjectiveVEN.updDate)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveV))!(clsTopicObjectiveVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVEN.updUser) == false && undefined !== pobjTopicObjectiveVEN.updUser && tzDataType.isString(pobjTopicObjectiveVEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjTopicObjectiveVEN.updUser)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveV))!(clsTopicObjectiveVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVEN.id_CurrEduCls) == false && undefined !== pobjTopicObjectiveVEN.id_CurrEduCls && tzDataType.isString(pobjTopicObjectiveVEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjTopicObjectiveVEN.id_CurrEduCls)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveV))!(clsTopicObjectiveVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVEN.pdfContent) == false && undefined !== pobjTopicObjectiveVEN.pdfContent && tzDataType.isString(pobjTopicObjectiveVEN.pdfContent) === false)
{
 throw new Error("(errid:Watl000060)字段[Pdf内容(pdfContent)]的值:[$(pobjTopicObjectiveVEN.pdfContent)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveV))!(clsTopicObjectiveVBL:CheckPropertyNew)");
}
if (null != pobjTopicObjectiveVEN.pdfPageNum && undefined !== pobjTopicObjectiveVEN.pdfPageNum && tzDataType.isNumber(pobjTopicObjectiveVEN.pdfPageNum) === false)
{
 throw new Error("(errid:Watl000060)字段[Pdf页码(pdfPageNum)]的值:[$(pobjTopicObjectiveVEN.pdfPageNum)], 非法，应该为数值型(In 主题客观版本(TopicObjectiveV))!(clsTopicObjectiveVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVEN.memo) == false && undefined !== pobjTopicObjectiveVEN.memo && tzDataType.isString(pobjTopicObjectiveVEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjTopicObjectiveVEN.memo)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveV))!(clsTopicObjectiveVBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjTopicObjectiveVEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function TopicObjectiveV_CheckProperty4Update (pobjTopicObjectiveVEN: clsTopicObjectiveVEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjTopicObjectiveVEN.topicObjectiveId) == false && GetStrLen(pobjTopicObjectiveVEN.topicObjectiveId) > 8)
{
 throw new Error("(errid:Watl000062)字段[客观Id(topicObjectiveId)]的长度不能超过8(In 主题客观版本(TopicObjectiveV))!值:$(pobjTopicObjectiveVEN.topicObjectiveId)(clsTopicObjectiveVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVEN.objectiveName) == false && GetStrLen(pobjTopicObjectiveVEN.objectiveName) > 500)
{
 throw new Error("(errid:Watl000062)字段[客观名称(objectiveName)]的长度不能超过500(In 主题客观版本(TopicObjectiveV))!值:$(pobjTopicObjectiveVEN.objectiveName)(clsTopicObjectiveVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVEN.objectiveType) == false && GetStrLen(pobjTopicObjectiveVEN.objectiveType) > 2)
{
 throw new Error("(errid:Watl000062)字段[客观类型(objectiveType)]的长度不能超过2(In 主题客观版本(TopicObjectiveV))!值:$(pobjTopicObjectiveVEN.objectiveType)(clsTopicObjectiveVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVEN.sourceId) == false && GetStrLen(pobjTopicObjectiveVEN.sourceId) > 10)
{
 throw new Error("(errid:Watl000062)字段[来源Id(sourceId)]的长度不能超过10(In 主题客观版本(TopicObjectiveV))!值:$(pobjTopicObjectiveVEN.sourceId)(clsTopicObjectiveVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVEN.updDate) == false && GetStrLen(pobjTopicObjectiveVEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 主题客观版本(TopicObjectiveV))!值:$(pobjTopicObjectiveVEN.updDate)(clsTopicObjectiveVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVEN.updUser) == false && GetStrLen(pobjTopicObjectiveVEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 主题客观版本(TopicObjectiveV))!值:$(pobjTopicObjectiveVEN.updUser)(clsTopicObjectiveVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVEN.id_CurrEduCls) == false && GetStrLen(pobjTopicObjectiveVEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 主题客观版本(TopicObjectiveV))!值:$(pobjTopicObjectiveVEN.id_CurrEduCls)(clsTopicObjectiveVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVEN.pdfContent) == false && GetStrLen(pobjTopicObjectiveVEN.pdfContent) > 2000)
{
 throw new Error("(errid:Watl000062)字段[Pdf内容(pdfContent)]的长度不能超过2000(In 主题客观版本(TopicObjectiveV))!值:$(pobjTopicObjectiveVEN.pdfContent)(clsTopicObjectiveVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVEN.memo) == false && GetStrLen(pobjTopicObjectiveVEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 主题客观版本(TopicObjectiveV))!值:$(pobjTopicObjectiveVEN.memo)(clsTopicObjectiveVBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null != pobjTopicObjectiveVEN.topicObjectiveVId && undefined !== pobjTopicObjectiveVEN.topicObjectiveVId && tzDataType.isNumber(pobjTopicObjectiveVEN.topicObjectiveVId) === false)
{
 throw new Error("(errid:Watl000063)字段[主题客观版本Id(topicObjectiveVId)]的值:[$(pobjTopicObjectiveVEN.topicObjectiveVId)], 非法，应该为数值型(In 主题客观版本(TopicObjectiveV))!(clsTopicObjectiveVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVEN.topicObjectiveId) == false && undefined !== pobjTopicObjectiveVEN.topicObjectiveId && tzDataType.isString(pobjTopicObjectiveVEN.topicObjectiveId) === false)
{
 throw new Error("(errid:Watl000063)字段[客观Id(topicObjectiveId)]的值:[$(pobjTopicObjectiveVEN.topicObjectiveId)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveV))!(clsTopicObjectiveVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVEN.objectiveName) == false && undefined !== pobjTopicObjectiveVEN.objectiveName && tzDataType.isString(pobjTopicObjectiveVEN.objectiveName) === false)
{
 throw new Error("(errid:Watl000063)字段[客观名称(objectiveName)]的值:[$(pobjTopicObjectiveVEN.objectiveName)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveV))!(clsTopicObjectiveVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVEN.objectiveContent) == false && undefined !== pobjTopicObjectiveVEN.objectiveContent && tzDataType.isString(pobjTopicObjectiveVEN.objectiveContent) === false)
{
 throw new Error("(errid:Watl000063)字段[客观内容(objectiveContent)]的值:[$(pobjTopicObjectiveVEN.objectiveContent)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveV))!(clsTopicObjectiveVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVEN.objectiveType) == false && undefined !== pobjTopicObjectiveVEN.objectiveType && tzDataType.isString(pobjTopicObjectiveVEN.objectiveType) === false)
{
 throw new Error("(errid:Watl000063)字段[客观类型(objectiveType)]的值:[$(pobjTopicObjectiveVEN.objectiveType)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveV))!(clsTopicObjectiveVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVEN.conclusion) == false && undefined !== pobjTopicObjectiveVEN.conclusion && tzDataType.isString(pobjTopicObjectiveVEN.conclusion) === false)
{
 throw new Error("(errid:Watl000063)字段[结论(conclusion)]的值:[$(pobjTopicObjectiveVEN.conclusion)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveV))!(clsTopicObjectiveVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVEN.sourceId) == false && undefined !== pobjTopicObjectiveVEN.sourceId && tzDataType.isString(pobjTopicObjectiveVEN.sourceId) === false)
{
 throw new Error("(errid:Watl000063)字段[来源Id(sourceId)]的值:[$(pobjTopicObjectiveVEN.sourceId)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveV))!(clsTopicObjectiveVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVEN.updDate) == false && undefined !== pobjTopicObjectiveVEN.updDate && tzDataType.isString(pobjTopicObjectiveVEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjTopicObjectiveVEN.updDate)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveV))!(clsTopicObjectiveVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVEN.updUser) == false && undefined !== pobjTopicObjectiveVEN.updUser && tzDataType.isString(pobjTopicObjectiveVEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjTopicObjectiveVEN.updUser)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveV))!(clsTopicObjectiveVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVEN.id_CurrEduCls) == false && undefined !== pobjTopicObjectiveVEN.id_CurrEduCls && tzDataType.isString(pobjTopicObjectiveVEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjTopicObjectiveVEN.id_CurrEduCls)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveV))!(clsTopicObjectiveVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVEN.pdfContent) == false && undefined !== pobjTopicObjectiveVEN.pdfContent && tzDataType.isString(pobjTopicObjectiveVEN.pdfContent) === false)
{
 throw new Error("(errid:Watl000063)字段[Pdf内容(pdfContent)]的值:[$(pobjTopicObjectiveVEN.pdfContent)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveV))!(clsTopicObjectiveVBL:CheckProperty4Update)");
}
if (null != pobjTopicObjectiveVEN.pdfPageNum && undefined !== pobjTopicObjectiveVEN.pdfPageNum && tzDataType.isNumber(pobjTopicObjectiveVEN.pdfPageNum) === false)
{
 throw new Error("(errid:Watl000063)字段[Pdf页码(pdfPageNum)]的值:[$(pobjTopicObjectiveVEN.pdfPageNum)], 非法，应该为数值型(In 主题客观版本(TopicObjectiveV))!(clsTopicObjectiveVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTopicObjectiveVEN.memo) == false && undefined !== pobjTopicObjectiveVEN.memo && tzDataType.isString(pobjTopicObjectiveVEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjTopicObjectiveVEN.memo)], 非法，应该为字符型(In 主题客观版本(TopicObjectiveV))!(clsTopicObjectiveVBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjTopicObjectiveVEN.topicObjectiveVId 
 || pobjTopicObjectiveVEN.topicObjectiveVId != null && pobjTopicObjectiveVEN.topicObjectiveVId.toString()  ===  "")
{
 throw new Error("(errid:Watl000064)字段[主题客观版本Id]不能为空(In 主题客观版本)!(clsTopicObjectiveVBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjTopicObjectiveVEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function TopicObjectiveV_GetJSONStrByObj (pobjTopicObjectiveVEN: clsTopicObjectiveVEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjTopicObjectiveVEN.sf_UpdFldSetStr = pobjTopicObjectiveVEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjTopicObjectiveVEN);
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
export function TopicObjectiveV_GetObjLstByJSONStr (strJSON: string): Array<clsTopicObjectiveVEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrTopicObjectiveVObjLst = new Array<clsTopicObjectiveVEN>();
if (strJSON === "")
{
return arrTopicObjectiveVObjLst;
}
try
{
arrTopicObjectiveVObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrTopicObjectiveVObjLst;
}
return arrTopicObjectiveVObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrTopicObjectiveVObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function TopicObjectiveV_GetObjLstByJSONObjLst (arrTopicObjectiveVObjLstS: Array<clsTopicObjectiveVEN>): Array<clsTopicObjectiveVEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrTopicObjectiveVObjLst = new Array<clsTopicObjectiveVEN>();
for (const objInFor of arrTopicObjectiveVObjLstS) {
const obj1 = TopicObjectiveV_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrTopicObjectiveVObjLst.push(obj1);
}
return arrTopicObjectiveVObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function TopicObjectiveV_GetObjByJSONStr (strJSON: string): clsTopicObjectiveVEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjTopicObjectiveVEN = new clsTopicObjectiveVEN();
if (strJSON === "")
{
return pobjTopicObjectiveVEN;
}
try
{
pobjTopicObjectiveVEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjTopicObjectiveVEN;
}
return pobjTopicObjectiveVEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function TopicObjectiveV_GetCombineCondition(objTopicObjectiveV_Cond: clsTopicObjectiveVEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objTopicObjectiveV_Cond.dicFldComparisonOp, clsTopicObjectiveVEN.con_TopicObjectiveVId) == true)
{
const strComparisonOp_TopicObjectiveVId:string = objTopicObjectiveV_Cond.dicFldComparisonOp[clsTopicObjectiveVEN.con_TopicObjectiveVId];
strWhereCond += Format(" And {0} {2} {1}", clsTopicObjectiveVEN.con_TopicObjectiveVId, objTopicObjectiveV_Cond.topicObjectiveVId, strComparisonOp_TopicObjectiveVId);
}
if (Object.prototype.hasOwnProperty.call(objTopicObjectiveV_Cond.dicFldComparisonOp, clsTopicObjectiveVEN.con_TopicObjectiveId) == true)
{
const strComparisonOp_TopicObjectiveId:string = objTopicObjectiveV_Cond.dicFldComparisonOp[clsTopicObjectiveVEN.con_TopicObjectiveId];
strWhereCond += Format(" And {0} {2} '{1}'", clsTopicObjectiveVEN.con_TopicObjectiveId, objTopicObjectiveV_Cond.topicObjectiveId, strComparisonOp_TopicObjectiveId);
}
if (Object.prototype.hasOwnProperty.call(objTopicObjectiveV_Cond.dicFldComparisonOp, clsTopicObjectiveVEN.con_ObjectiveName) == true)
{
const strComparisonOp_ObjectiveName:string = objTopicObjectiveV_Cond.dicFldComparisonOp[clsTopicObjectiveVEN.con_ObjectiveName];
strWhereCond += Format(" And {0} {2} '{1}'", clsTopicObjectiveVEN.con_ObjectiveName, objTopicObjectiveV_Cond.objectiveName, strComparisonOp_ObjectiveName);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objTopicObjectiveV_Cond.dicFldComparisonOp, clsTopicObjectiveVEN.con_ObjectiveType) == true)
{
const strComparisonOp_ObjectiveType:string = objTopicObjectiveV_Cond.dicFldComparisonOp[clsTopicObjectiveVEN.con_ObjectiveType];
strWhereCond += Format(" And {0} {2} '{1}'", clsTopicObjectiveVEN.con_ObjectiveType, objTopicObjectiveV_Cond.objectiveType, strComparisonOp_ObjectiveType);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objTopicObjectiveV_Cond.dicFldComparisonOp, clsTopicObjectiveVEN.con_SourceId) == true)
{
const strComparisonOp_SourceId:string = objTopicObjectiveV_Cond.dicFldComparisonOp[clsTopicObjectiveVEN.con_SourceId];
strWhereCond += Format(" And {0} {2} '{1}'", clsTopicObjectiveVEN.con_SourceId, objTopicObjectiveV_Cond.sourceId, strComparisonOp_SourceId);
}
if (Object.prototype.hasOwnProperty.call(objTopicObjectiveV_Cond.dicFldComparisonOp, clsTopicObjectiveVEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objTopicObjectiveV_Cond.dicFldComparisonOp[clsTopicObjectiveVEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsTopicObjectiveVEN.con_UpdDate, objTopicObjectiveV_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objTopicObjectiveV_Cond.dicFldComparisonOp, clsTopicObjectiveVEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objTopicObjectiveV_Cond.dicFldComparisonOp[clsTopicObjectiveVEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsTopicObjectiveVEN.con_UpdUser, objTopicObjectiveV_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objTopicObjectiveV_Cond.dicFldComparisonOp, clsTopicObjectiveVEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objTopicObjectiveV_Cond.dicFldComparisonOp[clsTopicObjectiveVEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsTopicObjectiveVEN.con_id_CurrEduCls, objTopicObjectiveV_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (Object.prototype.hasOwnProperty.call(objTopicObjectiveV_Cond.dicFldComparisonOp, clsTopicObjectiveVEN.con_PdfContent) == true)
{
const strComparisonOp_PdfContent:string = objTopicObjectiveV_Cond.dicFldComparisonOp[clsTopicObjectiveVEN.con_PdfContent];
strWhereCond += Format(" And {0} {2} '{1}'", clsTopicObjectiveVEN.con_PdfContent, objTopicObjectiveV_Cond.pdfContent, strComparisonOp_PdfContent);
}
if (Object.prototype.hasOwnProperty.call(objTopicObjectiveV_Cond.dicFldComparisonOp, clsTopicObjectiveVEN.con_PdfPageNum) == true)
{
const strComparisonOp_PdfPageNum:string = objTopicObjectiveV_Cond.dicFldComparisonOp[clsTopicObjectiveVEN.con_PdfPageNum];
strWhereCond += Format(" And {0} {2} {1}", clsTopicObjectiveVEN.con_PdfPageNum, objTopicObjectiveV_Cond.pdfPageNum, strComparisonOp_PdfPageNum);
}
if (Object.prototype.hasOwnProperty.call(objTopicObjectiveV_Cond.dicFldComparisonOp, clsTopicObjectiveVEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objTopicObjectiveV_Cond.dicFldComparisonOp[clsTopicObjectiveVEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsTopicObjectiveVEN.con_Memo, objTopicObjectiveV_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--TopicObjectiveV(主题客观版本),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param lngTopicObjectiveVId: 主题客观版本Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function TopicObjectiveV_GetUniCondStr_TopicObjectiveVId(objTopicObjectiveVEN: clsTopicObjectiveVEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and TopicObjectiveVId = '{0}'", objTopicObjectiveVEN.topicObjectiveVId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--TopicObjectiveV(主题客观版本),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param lngTopicObjectiveVId: 主题客观版本Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function TopicObjectiveV_GetUniCondStr4Update_TopicObjectiveVId(objTopicObjectiveVEN: clsTopicObjectiveVEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and TopicObjectiveVId <> '{0}'", objTopicObjectiveVEN.topicObjectiveVId);
 strWhereCond +=  Format(" and TopicObjectiveVId = '{0}'", objTopicObjectiveVEN.topicObjectiveVId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objTopicObjectiveVENS:源对象
 * @param objTopicObjectiveVENT:目标对象
*/
export function TopicObjectiveV_CopyObjTo(objTopicObjectiveVENS: clsTopicObjectiveVEN , objTopicObjectiveVENT: clsTopicObjectiveVEN ): void 
{
objTopicObjectiveVENT.topicObjectiveVId = objTopicObjectiveVENS.topicObjectiveVId; //主题客观版本Id
objTopicObjectiveVENT.topicObjectiveId = objTopicObjectiveVENS.topicObjectiveId; //客观Id
objTopicObjectiveVENT.objectiveName = objTopicObjectiveVENS.objectiveName; //客观名称
objTopicObjectiveVENT.objectiveContent = objTopicObjectiveVENS.objectiveContent; //客观内容
objTopicObjectiveVENT.objectiveType = objTopicObjectiveVENS.objectiveType; //客观类型
objTopicObjectiveVENT.conclusion = objTopicObjectiveVENS.conclusion; //结论
objTopicObjectiveVENT.sourceId = objTopicObjectiveVENS.sourceId; //来源Id
objTopicObjectiveVENT.updDate = objTopicObjectiveVENS.updDate; //修改日期
objTopicObjectiveVENT.updUser = objTopicObjectiveVENS.updUser; //修改人
objTopicObjectiveVENT.id_CurrEduCls = objTopicObjectiveVENS.id_CurrEduCls; //教学班流水号
objTopicObjectiveVENT.pdfContent = objTopicObjectiveVENS.pdfContent; //Pdf内容
objTopicObjectiveVENT.pdfPageNum = objTopicObjectiveVENS.pdfPageNum; //Pdf页码
objTopicObjectiveVENT.memo = objTopicObjectiveVENS.memo; //备注
objTopicObjectiveVENT.sf_UpdFldSetStr = objTopicObjectiveVENS.updFldString; //sf_UpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objTopicObjectiveVENS:源对象
 * @param objTopicObjectiveVENT:目标对象
*/
export function TopicObjectiveV_GetObjFromJsonObj(objTopicObjectiveVENS: clsTopicObjectiveVEN): clsTopicObjectiveVEN 
{
 const objTopicObjectiveVENT: clsTopicObjectiveVEN = new clsTopicObjectiveVEN();
ObjectAssign(objTopicObjectiveVENT, objTopicObjectiveVENS);
 return objTopicObjectiveVENT;
}