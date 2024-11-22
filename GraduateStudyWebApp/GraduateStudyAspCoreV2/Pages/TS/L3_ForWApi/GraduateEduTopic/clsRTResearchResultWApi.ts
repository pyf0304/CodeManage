
 /**
 * 类名:clsRTResearchResultWApi
 * 表名:RTResearchResult(01120620)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:50:32
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
 * 研究结果(RTResearchResult)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2023年03月13日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { enumComparisonOp } from "../../PubFun/enumComparisonOp.js";
import { clsRTResearchResultEN } from "../../L0_Entity/GraduateEduTopic/clsRTResearchResultEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { tzDataType } from "../../PubFun/clsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const rTResearchResult_Controller = "RTResearchResultApi";
 export const rTResearchResult_ConstructorName = "rTResearchResult";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngmId:关键字
 * @returns 对象
 **/
export async function RTResearchResult_GetObjBymIdAsync(lngmId: number): Promise<clsRTResearchResultEN|null>  
{
const strThisFuncName = "GetObjBymIdAsync";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In clsRTResearchResultWApi.GetObjBymIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjBymId";
const strUrl = GetWebApiUrl(rTResearchResult_Controller, strAction);
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
return null;
}
//console.log(returnObj);
const objRTResearchResult = RTResearchResult_GetObjFromJsonObj(returnObj);
return objRTResearchResult;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTResearchResult_ConstructorName, strThisFuncName);
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
export function RTResearchResult_SortFun_Defa(a:clsRTResearchResultEN , b:clsRTResearchResultEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.mId-b.mId;
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
export function RTResearchResult_SortFun_Defa_2Fld(a:clsRTResearchResultEN , b:clsRTResearchResultEN): number 
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
export function RTResearchResult_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsRTResearchResultEN.con_mId:
return (a: clsRTResearchResultEN, b: clsRTResearchResultEN) => {
return a.mId-b.mId;
}
case clsRTResearchResultEN.con_TopicId:
return (a: clsRTResearchResultEN, b: clsRTResearchResultEN) => {
if (a.topicId == null) return -1;
if (b.topicId == null) return 1;
return a.topicId.localeCompare(b.topicId);
}
case clsRTResearchResultEN.con_PaperId:
return (a: clsRTResearchResultEN, b: clsRTResearchResultEN) => {
if (a.paperId == null) return -1;
if (b.paperId == null) return 1;
return a.paperId.localeCompare(b.paperId);
}
case clsRTResearchResultEN.con_UpdDate:
return (a: clsRTResearchResultEN, b: clsRTResearchResultEN) => {
if (a.updDate == null) return -1;
if (b.updDate == null) return 1;
return a.updDate.localeCompare(b.updDate);
}
case clsRTResearchResultEN.con_UpdUser:
return (a: clsRTResearchResultEN, b: clsRTResearchResultEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsRTResearchResultEN.con_Memo:
return (a: clsRTResearchResultEN, b: clsRTResearchResultEN) => {
if (a.memo == null) return -1;
if (b.memo == null) return 1;
return a.memo.localeCompare(b.memo);
}
case clsRTResearchResultEN.con_id_CurrEduCls:
return (a: clsRTResearchResultEN, b: clsRTResearchResultEN) => {
if (a.id_CurrEduCls == null) return -1;
if (b.id_CurrEduCls == null) return 1;
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[RTResearchResult]中不存在！(in ${ rTResearchResult_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsRTResearchResultEN.con_mId:
return (a: clsRTResearchResultEN, b: clsRTResearchResultEN) => {
return b.mId-a.mId;
}
case clsRTResearchResultEN.con_TopicId:
return (a: clsRTResearchResultEN, b: clsRTResearchResultEN) => {
if (b.topicId == null) return -1;
if (a.topicId == null) return 1;
return b.topicId.localeCompare(a.topicId);
}
case clsRTResearchResultEN.con_PaperId:
return (a: clsRTResearchResultEN, b: clsRTResearchResultEN) => {
if (b.paperId == null) return -1;
if (a.paperId == null) return 1;
return b.paperId.localeCompare(a.paperId);
}
case clsRTResearchResultEN.con_UpdDate:
return (a: clsRTResearchResultEN, b: clsRTResearchResultEN) => {
if (b.updDate == null) return -1;
if (a.updDate == null) return 1;
return b.updDate.localeCompare(a.updDate);
}
case clsRTResearchResultEN.con_UpdUser:
return (a: clsRTResearchResultEN, b: clsRTResearchResultEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsRTResearchResultEN.con_Memo:
return (a: clsRTResearchResultEN, b: clsRTResearchResultEN) => {
if (b.memo == null) return -1;
if (a.memo == null) return 1;
return b.memo.localeCompare(a.memo);
}
case clsRTResearchResultEN.con_id_CurrEduCls:
return (a: clsRTResearchResultEN, b: clsRTResearchResultEN) => {
if (b.id_CurrEduCls == null) return -1;
if (a.id_CurrEduCls == null) return 1;
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[RTResearchResult]中不存在！(in ${ rTResearchResult_ConstructorName}.${ strThisFuncName})`;
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
export async function RTResearchResult_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsRTResearchResultEN.con_mId:
return (obj: clsRTResearchResultEN) => {
return obj.mId === value;
}
case clsRTResearchResultEN.con_TopicId:
return (obj: clsRTResearchResultEN) => {
return obj.topicId === value;
}
case clsRTResearchResultEN.con_PaperId:
return (obj: clsRTResearchResultEN) => {
return obj.paperId === value;
}
case clsRTResearchResultEN.con_UpdDate:
return (obj: clsRTResearchResultEN) => {
return obj.updDate === value;
}
case clsRTResearchResultEN.con_UpdUser:
return (obj: clsRTResearchResultEN) => {
return obj.updUser === value;
}
case clsRTResearchResultEN.con_Memo:
return (obj: clsRTResearchResultEN) => {
return obj.memo === value;
}
case clsRTResearchResultEN.con_id_CurrEduCls:
return (obj: clsRTResearchResultEN) => {
return obj.id_CurrEduCls === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[RTResearchResult]中不存在！(in ${ rTResearchResult_ConstructorName}.${ strThisFuncName})`;
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
export async function RTResearchResult_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(rTResearchResult_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTResearchResult_ConstructorName, strThisFuncName);
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
export async function RTResearchResult_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(rTResearchResult_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTResearchResult_ConstructorName, strThisFuncName);
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
export async function RTResearchResult_GetFirstObjAsync(strWhereCond: string): Promise<clsRTResearchResultEN|null>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(rTResearchResult_Controller, strAction);
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
const objRTResearchResult = RTResearchResult_GetObjFromJsonObj(returnObj);
return objRTResearchResult;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTResearchResult_ConstructorName, strThisFuncName);
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
export async function RTResearchResult_GetObjLstAsync(strWhereCond: string): Promise<Array<clsRTResearchResultEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(rTResearchResult_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", rTResearchResult_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = RTResearchResult_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTResearchResult_ConstructorName, strThisFuncName);
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
export async function RTResearchResult_GetObjLstBymIdLstAsync(arrmId: Array<string>): Promise<Array<clsRTResearchResultEN>>  
{
const strThisFuncName = "GetObjLstBymIdLstAsync";
const strAction = "GetObjLstBymIdLst";
const strUrl = GetWebApiUrl(rTResearchResult_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrmId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", rTResearchResult_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = RTResearchResult_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTResearchResult_ConstructorName, strThisFuncName);
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
export async function RTResearchResult_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsRTResearchResultEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(rTResearchResult_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", rTResearchResult_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = RTResearchResult_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTResearchResult_ConstructorName, strThisFuncName);
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
export async function RTResearchResult_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsRTResearchResultEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(rTResearchResult_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", rTResearchResult_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = RTResearchResult_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTResearchResult_ConstructorName, strThisFuncName);
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
export async function RTResearchResult_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(rTResearchResult_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTResearchResult_ConstructorName, strThisFuncName);
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
export async function RTResearchResult_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsRTResearchResultEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
if (objPagerPara.pageIndex == 0) return new Array<clsRTResearchResultEN>();
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(rTResearchResult_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", rTResearchResult_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = RTResearchResult_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTResearchResult_ConstructorName, strThisFuncName);
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
export async function RTResearchResult_DelRecordAsync(lngmId: number): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(rTResearchResult_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, lngmId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTResearchResult_ConstructorName, strThisFuncName);
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
export async function RTResearchResult_DelRTResearchResultsAsync(arrmId: Array<string>): Promise<number> 
{
const strThisFuncName = "DelRTResearchResultsAsync";
const strAction = "DelRTResearchResults";
const strUrl = GetWebApiUrl(rTResearchResult_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTResearchResult_ConstructorName, strThisFuncName);
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
export async function RTResearchResult_DelRTResearchResultsByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "DelRTResearchResultsByCondAsync";
const strAction = "DelRTResearchResultsByCond";
const strUrl = GetWebApiUrl(rTResearchResult_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTResearchResult_ConstructorName, strThisFuncName);
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
 * @param objRTResearchResultEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function RTResearchResult_AddNewRecordAsync(objRTResearchResultEN: clsRTResearchResultEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objRTResearchResultEN);
const strUrl = GetWebApiUrl(rTResearchResult_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRTResearchResultEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTResearchResult_ConstructorName, strThisFuncName);
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
 * @param objRTResearchResultEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function RTResearchResult_AddNewRecordWithReturnKeyAsync(objRTResearchResultEN: clsRTResearchResultEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(rTResearchResult_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRTResearchResultEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTResearchResult_ConstructorName, strThisFuncName);
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
 * @param objRTResearchResultEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function RTResearchResult_AddNewRecordWithReturnKey(objRTResearchResultEN: clsRTResearchResultEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objRTResearchResultEN.mId === null || objRTResearchResultEN.mId === 0)
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(rTResearchResult_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRTResearchResultEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTResearchResult_ConstructorName, strThisFuncName);
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
 * @param objRTResearchResultEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function RTResearchResult_UpdateRecordAsync(objRTResearchResultEN: clsRTResearchResultEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objRTResearchResultEN.sfUpdFldSetStr === undefined || objRTResearchResultEN.sfUpdFldSetStr === null || objRTResearchResultEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objRTResearchResultEN.mId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(rTResearchResult_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRTResearchResultEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTResearchResult_ConstructorName, strThisFuncName);
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
 * @param objRTResearchResultEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function RTResearchResult_UpdateWithConditionAsync(objRTResearchResultEN: clsRTResearchResultEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objRTResearchResultEN.sfUpdFldSetStr === undefined || objRTResearchResultEN.sfUpdFldSetStr === null || objRTResearchResultEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objRTResearchResultEN.mId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(rTResearchResult_Controller, strAction);
objRTResearchResultEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objRTResearchResultEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTResearchResult_ConstructorName, strThisFuncName);
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
export async function RTResearchResult_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(rTResearchResult_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTResearchResult_ConstructorName, strThisFuncName);
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
export async function RTResearchResult_IsExist(lngmId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(rTResearchResult_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTResearchResult_ConstructorName, strThisFuncName);
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
export async function RTResearchResult_IsExistAsync(lngmId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(rTResearchResult_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTResearchResult_ConstructorName, strThisFuncName);
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
export async function RTResearchResult_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(rTResearchResult_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTResearchResult_ConstructorName, strThisFuncName);
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
export async function RTResearchResult_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(rTResearchResult_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTResearchResult_ConstructorName, strThisFuncName);
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
export function RTResearchResult_GetWebApiUrl(strController: string, strAction: string): string {
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
export function RTResearchResult_CheckPropertyNew(pobjRTResearchResultEN: clsRTResearchResultEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjRTResearchResultEN.updUser) === true )
{
 throw new Error("(errid:Watl000058)字段[修改人]不能为空(In 研究结果)!(clsRTResearchResultBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjRTResearchResultEN.topicId) == false && GetStrLen(pobjRTResearchResultEN.topicId) > 8)
{
 throw new Error("(errid:Watl000059)字段[主题Id(topicId)]的长度不能超过8(In 研究结果(RTResearchResult))!值:$(pobjRTResearchResultEN.topicId)(clsRTResearchResultBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRTResearchResultEN.paperId) == false && GetStrLen(pobjRTResearchResultEN.paperId) > 8)
{
 throw new Error("(errid:Watl000059)字段[论文Id(paperId)]的长度不能超过8(In 研究结果(RTResearchResult))!值:$(pobjRTResearchResultEN.paperId)(clsRTResearchResultBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRTResearchResultEN.updDate) == false && GetStrLen(pobjRTResearchResultEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 研究结果(RTResearchResult))!值:$(pobjRTResearchResultEN.updDate)(clsRTResearchResultBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRTResearchResultEN.updUser) == false && GetStrLen(pobjRTResearchResultEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 研究结果(RTResearchResult))!值:$(pobjRTResearchResultEN.updUser)(clsRTResearchResultBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRTResearchResultEN.memo) == false && GetStrLen(pobjRTResearchResultEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 研究结果(RTResearchResult))!值:$(pobjRTResearchResultEN.memo)(clsRTResearchResultBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRTResearchResultEN.id_CurrEduCls) == false && GetStrLen(pobjRTResearchResultEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 研究结果(RTResearchResult))!值:$(pobjRTResearchResultEN.id_CurrEduCls)(clsRTResearchResultBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null != pobjRTResearchResultEN.mId && undefined !== pobjRTResearchResultEN.mId && tzDataType.isNumber(pobjRTResearchResultEN.mId) === false)
{
 throw new Error("(errid:Watl000060)字段[mId(mId)]的值:[$(pobjRTResearchResultEN.mId)], 非法，应该为数值型(In 研究结果(RTResearchResult))!(clsRTResearchResultBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRTResearchResultEN.topicId) == false && undefined !== pobjRTResearchResultEN.topicId && tzDataType.isString(pobjRTResearchResultEN.topicId) === false)
{
 throw new Error("(errid:Watl000060)字段[主题Id(topicId)]的值:[$(pobjRTResearchResultEN.topicId)], 非法，应该为字符型(In 研究结果(RTResearchResult))!(clsRTResearchResultBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRTResearchResultEN.paperId) == false && undefined !== pobjRTResearchResultEN.paperId && tzDataType.isString(pobjRTResearchResultEN.paperId) === false)
{
 throw new Error("(errid:Watl000060)字段[论文Id(paperId)]的值:[$(pobjRTResearchResultEN.paperId)], 非法，应该为字符型(In 研究结果(RTResearchResult))!(clsRTResearchResultBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRTResearchResultEN.updDate) == false && undefined !== pobjRTResearchResultEN.updDate && tzDataType.isString(pobjRTResearchResultEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjRTResearchResultEN.updDate)], 非法，应该为字符型(In 研究结果(RTResearchResult))!(clsRTResearchResultBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRTResearchResultEN.updUser) == false && undefined !== pobjRTResearchResultEN.updUser && tzDataType.isString(pobjRTResearchResultEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjRTResearchResultEN.updUser)], 非法，应该为字符型(In 研究结果(RTResearchResult))!(clsRTResearchResultBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRTResearchResultEN.memo) == false && undefined !== pobjRTResearchResultEN.memo && tzDataType.isString(pobjRTResearchResultEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjRTResearchResultEN.memo)], 非法，应该为字符型(In 研究结果(RTResearchResult))!(clsRTResearchResultBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRTResearchResultEN.id_CurrEduCls) == false && undefined !== pobjRTResearchResultEN.id_CurrEduCls && tzDataType.isString(pobjRTResearchResultEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjRTResearchResultEN.id_CurrEduCls)], 非法，应该为字符型(In 研究结果(RTResearchResult))!(clsRTResearchResultBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjRTResearchResultEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function RTResearchResult_CheckProperty4Update (pobjRTResearchResultEN: clsRTResearchResultEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjRTResearchResultEN.topicId) == false && GetStrLen(pobjRTResearchResultEN.topicId) > 8)
{
 throw new Error("(errid:Watl000062)字段[主题Id(topicId)]的长度不能超过8(In 研究结果(RTResearchResult))!值:$(pobjRTResearchResultEN.topicId)(clsRTResearchResultBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRTResearchResultEN.paperId) == false && GetStrLen(pobjRTResearchResultEN.paperId) > 8)
{
 throw new Error("(errid:Watl000062)字段[论文Id(paperId)]的长度不能超过8(In 研究结果(RTResearchResult))!值:$(pobjRTResearchResultEN.paperId)(clsRTResearchResultBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRTResearchResultEN.updDate) == false && GetStrLen(pobjRTResearchResultEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 研究结果(RTResearchResult))!值:$(pobjRTResearchResultEN.updDate)(clsRTResearchResultBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRTResearchResultEN.updUser) == false && GetStrLen(pobjRTResearchResultEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 研究结果(RTResearchResult))!值:$(pobjRTResearchResultEN.updUser)(clsRTResearchResultBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRTResearchResultEN.memo) == false && GetStrLen(pobjRTResearchResultEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 研究结果(RTResearchResult))!值:$(pobjRTResearchResultEN.memo)(clsRTResearchResultBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRTResearchResultEN.id_CurrEduCls) == false && GetStrLen(pobjRTResearchResultEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 研究结果(RTResearchResult))!值:$(pobjRTResearchResultEN.id_CurrEduCls)(clsRTResearchResultBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null != pobjRTResearchResultEN.mId && undefined !== pobjRTResearchResultEN.mId && tzDataType.isNumber(pobjRTResearchResultEN.mId) === false)
{
 throw new Error("(errid:Watl000063)字段[mId(mId)]的值:[$(pobjRTResearchResultEN.mId)], 非法，应该为数值型(In 研究结果(RTResearchResult))!(clsRTResearchResultBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRTResearchResultEN.topicId) == false && undefined !== pobjRTResearchResultEN.topicId && tzDataType.isString(pobjRTResearchResultEN.topicId) === false)
{
 throw new Error("(errid:Watl000063)字段[主题Id(topicId)]的值:[$(pobjRTResearchResultEN.topicId)], 非法，应该为字符型(In 研究结果(RTResearchResult))!(clsRTResearchResultBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRTResearchResultEN.paperId) == false && undefined !== pobjRTResearchResultEN.paperId && tzDataType.isString(pobjRTResearchResultEN.paperId) === false)
{
 throw new Error("(errid:Watl000063)字段[论文Id(paperId)]的值:[$(pobjRTResearchResultEN.paperId)], 非法，应该为字符型(In 研究结果(RTResearchResult))!(clsRTResearchResultBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRTResearchResultEN.updDate) == false && undefined !== pobjRTResearchResultEN.updDate && tzDataType.isString(pobjRTResearchResultEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjRTResearchResultEN.updDate)], 非法，应该为字符型(In 研究结果(RTResearchResult))!(clsRTResearchResultBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRTResearchResultEN.updUser) == false && undefined !== pobjRTResearchResultEN.updUser && tzDataType.isString(pobjRTResearchResultEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjRTResearchResultEN.updUser)], 非法，应该为字符型(In 研究结果(RTResearchResult))!(clsRTResearchResultBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRTResearchResultEN.memo) == false && undefined !== pobjRTResearchResultEN.memo && tzDataType.isString(pobjRTResearchResultEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjRTResearchResultEN.memo)], 非法，应该为字符型(In 研究结果(RTResearchResult))!(clsRTResearchResultBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRTResearchResultEN.id_CurrEduCls) == false && undefined !== pobjRTResearchResultEN.id_CurrEduCls && tzDataType.isString(pobjRTResearchResultEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjRTResearchResultEN.id_CurrEduCls)], 非法，应该为字符型(In 研究结果(RTResearchResult))!(clsRTResearchResultBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjRTResearchResultEN.mId 
 || pobjRTResearchResultEN.mId != null && pobjRTResearchResultEN.mId.toString()  ===  "")
{
 throw new Error("(errid:Watl000064)字段[mId]不能为空(In 研究结果)!(clsRTResearchResultBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjRTResearchResultEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function RTResearchResult_GetJSONStrByObj (pobjRTResearchResultEN: clsRTResearchResultEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjRTResearchResultEN.sfUpdFldSetStr = pobjRTResearchResultEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjRTResearchResultEN);
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
export function RTResearchResult_GetObjLstByJSONStr (strJSON: string): Array<clsRTResearchResultEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrRTResearchResultObjLst = new Array<clsRTResearchResultEN>();
if (strJSON === "")
{
return arrRTResearchResultObjLst;
}
try
{
arrRTResearchResultObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrRTResearchResultObjLst;
}
return arrRTResearchResultObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrRTResearchResultObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function RTResearchResult_GetObjLstByJSONObjLst (arrRTResearchResultObjLstS: Array<clsRTResearchResultEN>): Array<clsRTResearchResultEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrRTResearchResultObjLst = new Array<clsRTResearchResultEN>();
for (const objInFor of arrRTResearchResultObjLstS) {
const obj1 = RTResearchResult_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrRTResearchResultObjLst.push(obj1);
}
return arrRTResearchResultObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function RTResearchResult_GetObjByJSONStr (strJSON: string): clsRTResearchResultEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjRTResearchResultEN = new clsRTResearchResultEN();
if (strJSON === "")
{
return pobjRTResearchResultEN;
}
try
{
pobjRTResearchResultEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjRTResearchResultEN;
}
return pobjRTResearchResultEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function RTResearchResult_GetCombineCondition(objRTResearchResult_Cond: clsRTResearchResultEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objRTResearchResult_Cond.dicFldComparisonOp, clsRTResearchResultEN.con_mId) == true)
{
const strComparisonOp_mId:string = objRTResearchResult_Cond.dicFldComparisonOp[clsRTResearchResultEN.con_mId];
strWhereCond += Format(" And {0} {2} {1}", clsRTResearchResultEN.con_mId, objRTResearchResult_Cond.mId, strComparisonOp_mId);
}
if (Object.prototype.hasOwnProperty.call(objRTResearchResult_Cond.dicFldComparisonOp, clsRTResearchResultEN.con_TopicId) == true)
{
const strComparisonOp_TopicId:string = objRTResearchResult_Cond.dicFldComparisonOp[clsRTResearchResultEN.con_TopicId];
strWhereCond += Format(" And {0} {2} '{1}'", clsRTResearchResultEN.con_TopicId, objRTResearchResult_Cond.topicId, strComparisonOp_TopicId);
}
if (Object.prototype.hasOwnProperty.call(objRTResearchResult_Cond.dicFldComparisonOp, clsRTResearchResultEN.con_PaperId) == true)
{
const strComparisonOp_PaperId:string = objRTResearchResult_Cond.dicFldComparisonOp[clsRTResearchResultEN.con_PaperId];
strWhereCond += Format(" And {0} {2} '{1}'", clsRTResearchResultEN.con_PaperId, objRTResearchResult_Cond.paperId, strComparisonOp_PaperId);
}
if (Object.prototype.hasOwnProperty.call(objRTResearchResult_Cond.dicFldComparisonOp, clsRTResearchResultEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objRTResearchResult_Cond.dicFldComparisonOp[clsRTResearchResultEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsRTResearchResultEN.con_UpdDate, objRTResearchResult_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objRTResearchResult_Cond.dicFldComparisonOp, clsRTResearchResultEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objRTResearchResult_Cond.dicFldComparisonOp[clsRTResearchResultEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsRTResearchResultEN.con_UpdUser, objRTResearchResult_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objRTResearchResult_Cond.dicFldComparisonOp, clsRTResearchResultEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objRTResearchResult_Cond.dicFldComparisonOp[clsRTResearchResultEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsRTResearchResultEN.con_Memo, objRTResearchResult_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objRTResearchResult_Cond.dicFldComparisonOp, clsRTResearchResultEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objRTResearchResult_Cond.dicFldComparisonOp[clsRTResearchResultEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsRTResearchResultEN.con_id_CurrEduCls, objRTResearchResult_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--RTResearchResult(研究结果),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param lngmId: mId(要求唯一的字段)
 * @param strTopicId: 主题Id(要求唯一的字段)
 * @param strPaperId: 论文Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function RTResearchResult_GetUniCondStr_mId_TopicId_PaperId(objRTResearchResultEN: clsRTResearchResultEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and mId = '{0}'", objRTResearchResultEN.mId);
 strWhereCond +=  Format(" and TopicId = '{0}'", objRTResearchResultEN.topicId);
 strWhereCond +=  Format(" and PaperId = '{0}'", objRTResearchResultEN.paperId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--RTResearchResult(研究结果),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param lngmId: mId(要求唯一的字段)
 * @param strTopicId: 主题Id(要求唯一的字段)
 * @param strPaperId: 论文Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function RTResearchResult_GetUniCondStr4Update_mId_TopicId_PaperId(objRTResearchResultEN: clsRTResearchResultEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and mId <> '{0}'", objRTResearchResultEN.mId);
 strWhereCond +=  Format(" and mId = '{0}'", objRTResearchResultEN.mId);
 strWhereCond +=  Format(" and TopicId = '{0}'", objRTResearchResultEN.topicId);
 strWhereCond +=  Format(" and PaperId = '{0}'", objRTResearchResultEN.paperId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objRTResearchResultENS:源对象
 * @param objRTResearchResultENT:目标对象
*/
export function RTResearchResult_CopyObjTo(objRTResearchResultENS: clsRTResearchResultEN , objRTResearchResultENT: clsRTResearchResultEN ): void 
{
objRTResearchResultENT.mId = objRTResearchResultENS.mId; //mId
objRTResearchResultENT.topicId = objRTResearchResultENS.topicId; //主题Id
objRTResearchResultENT.paperId = objRTResearchResultENS.paperId; //论文Id
objRTResearchResultENT.updDate = objRTResearchResultENS.updDate; //修改日期
objRTResearchResultENT.updUser = objRTResearchResultENS.updUser; //修改人
objRTResearchResultENT.memo = objRTResearchResultENS.memo; //备注
objRTResearchResultENT.id_CurrEduCls = objRTResearchResultENS.id_CurrEduCls; //教学班流水号
objRTResearchResultENT.sfUpdFldSetStr = objRTResearchResultENS.updFldString; //sfUpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objRTResearchResultENS:源对象
 * @param objRTResearchResultENT:目标对象
*/
export function RTResearchResult_GetObjFromJsonObj(objRTResearchResultENS: clsRTResearchResultEN): clsRTResearchResultEN 
{
 const objRTResearchResultENT: clsRTResearchResultEN = new clsRTResearchResultEN();
ObjectAssign(objRTResearchResultENT, objRTResearchResultENS);
 return objRTResearchResultENT;
}