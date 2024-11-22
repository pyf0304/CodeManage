
 /**
 * 类名:clsqa_PushWApi
 * 表名:qa_Push(01120640)
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
 * 答疑推送(qa_Push)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { clsqa_PushEN } from "../../L0_Entity/InteractManage/clsqa_PushEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { tzDataType } from "../../PubFun/jsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const qa_Push_Controller = "qa_PushApi";
 export const qa_Push_ConstructorName = "qa_Push";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngPushId:关键字
 * @returns 对象
 **/
export async function qa_Push_GetObjByPushIdAsync(lngPushId: number): Promise<clsqa_PushEN>  
{
const strThisFuncName = "GetObjByPushIdAsync";

if (lngPushId == 0)
{
  const strMsg = Format("参数:[lngPushId]不能为空！(In GetObjByPushIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjByPushId";
const strUrl = GetWebApiUrl(qa_Push_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"lngPushId": lngPushId,
}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObj = data.returnObj;
if (returnObj == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", qa_Push_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objqa_Push = qa_Push_GetObjFromJsonObj(returnObj);
return objqa_Push;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_Push_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_Push_ConstructorName, strThisFuncName);
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
export function qa_Push_SortFun_Defa(a:clsqa_PushEN , b:clsqa_PushEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.pushId-b.pushId;
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
export function qa_Push_SortFun_Defa_2Fld(a:clsqa_PushEN , b:clsqa_PushEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.questionsId == b.questionsId) return a.receiveUser.localeCompare(b.receiveUser);
else return a.questionsId.localeCompare(b.questionsId);
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
export function qa_Push_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsqa_PushEN.con_PushId:
return (a: clsqa_PushEN, b: clsqa_PushEN) => {
return a.pushId-b.pushId;
}
case clsqa_PushEN.con_QuestionsId:
return (a: clsqa_PushEN, b: clsqa_PushEN) => {
return a.questionsId.localeCompare(b.questionsId);
}
case clsqa_PushEN.con_ReceiveUser:
return (a: clsqa_PushEN, b: clsqa_PushEN) => {
return a.receiveUser.localeCompare(b.receiveUser);
}
case clsqa_PushEN.con_ReceiveDate:
return (a: clsqa_PushEN, b: clsqa_PushEN) => {
return a.receiveDate.localeCompare(b.receiveDate);
}
case clsqa_PushEN.con_IsReceive:
return (a: clsqa_PushEN, b: clsqa_PushEN) => {
if (a.isReceive == true) return 1;
else return -1
}
case clsqa_PushEN.con_UpdDate:
return (a: clsqa_PushEN, b: clsqa_PushEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsqa_PushEN.con_Memo:
return (a: clsqa_PushEN, b: clsqa_PushEN) => {
return a.memo.localeCompare(b.memo);
}
case clsqa_PushEN.con_id_CurrEduCls:
return (a: clsqa_PushEN, b: clsqa_PushEN) => {
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
case clsqa_PushEN.con_IsReply:
return (a: clsqa_PushEN, b: clsqa_PushEN) => {
if (a.isReply == true) return 1;
else return -1
}
case clsqa_PushEN.con_IsRequestReply:
return (a: clsqa_PushEN, b: clsqa_PushEN) => {
if (a.isRequestReply == true) return 1;
else return -1
}
case clsqa_PushEN.con_ReplyDate:
return (a: clsqa_PushEN, b: clsqa_PushEN) => {
return a.replyDate.localeCompare(b.replyDate);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[qa_Push]中不存在！(in ${ qa_Push_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsqa_PushEN.con_PushId:
return (a: clsqa_PushEN, b: clsqa_PushEN) => {
return b.pushId-a.pushId;
}
case clsqa_PushEN.con_QuestionsId:
return (a: clsqa_PushEN, b: clsqa_PushEN) => {
return b.questionsId.localeCompare(a.questionsId);
}
case clsqa_PushEN.con_ReceiveUser:
return (a: clsqa_PushEN, b: clsqa_PushEN) => {
return b.receiveUser.localeCompare(a.receiveUser);
}
case clsqa_PushEN.con_ReceiveDate:
return (a: clsqa_PushEN, b: clsqa_PushEN) => {
return b.receiveDate.localeCompare(a.receiveDate);
}
case clsqa_PushEN.con_IsReceive:
return (a: clsqa_PushEN, b: clsqa_PushEN) => {
if (b.isReceive == true) return 1;
else return -1
}
case clsqa_PushEN.con_UpdDate:
return (a: clsqa_PushEN, b: clsqa_PushEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsqa_PushEN.con_Memo:
return (a: clsqa_PushEN, b: clsqa_PushEN) => {
return b.memo.localeCompare(a.memo);
}
case clsqa_PushEN.con_id_CurrEduCls:
return (a: clsqa_PushEN, b: clsqa_PushEN) => {
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
case clsqa_PushEN.con_IsReply:
return (a: clsqa_PushEN, b: clsqa_PushEN) => {
if (b.isReply == true) return 1;
else return -1
}
case clsqa_PushEN.con_IsRequestReply:
return (a: clsqa_PushEN, b: clsqa_PushEN) => {
if (b.isRequestReply == true) return 1;
else return -1
}
case clsqa_PushEN.con_ReplyDate:
return (a: clsqa_PushEN, b: clsqa_PushEN) => {
return b.replyDate.localeCompare(a.replyDate);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[qa_Push]中不存在！(in ${ qa_Push_ConstructorName}.${ strThisFuncName})`;
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
export async function qa_Push_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsqa_PushEN.con_PushId:
return (obj: clsqa_PushEN) => {
return obj.pushId === value;
}
case clsqa_PushEN.con_QuestionsId:
return (obj: clsqa_PushEN) => {
return obj.questionsId === value;
}
case clsqa_PushEN.con_ReceiveUser:
return (obj: clsqa_PushEN) => {
return obj.receiveUser === value;
}
case clsqa_PushEN.con_ReceiveDate:
return (obj: clsqa_PushEN) => {
return obj.receiveDate === value;
}
case clsqa_PushEN.con_IsReceive:
return (obj: clsqa_PushEN) => {
return obj.isReceive === value;
}
case clsqa_PushEN.con_UpdDate:
return (obj: clsqa_PushEN) => {
return obj.updDate === value;
}
case clsqa_PushEN.con_Memo:
return (obj: clsqa_PushEN) => {
return obj.memo === value;
}
case clsqa_PushEN.con_id_CurrEduCls:
return (obj: clsqa_PushEN) => {
return obj.id_CurrEduCls === value;
}
case clsqa_PushEN.con_IsReply:
return (obj: clsqa_PushEN) => {
return obj.isReply === value;
}
case clsqa_PushEN.con_IsRequestReply:
return (obj: clsqa_PushEN) => {
return obj.isRequestReply === value;
}
case clsqa_PushEN.con_ReplyDate:
return (obj: clsqa_PushEN) => {
return obj.replyDate === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[qa_Push]中不存在！(in ${ qa_Push_ConstructorName}.${ strThisFuncName})`;
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
export async function qa_Push_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(qa_Push_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_Push_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_Push_ConstructorName, strThisFuncName);
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
export async function qa_Push_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(qa_Push_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_Push_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_Push_ConstructorName, strThisFuncName);
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
export async function qa_Push_GetFirstObjAsync(strWhereCond: string): Promise<clsqa_PushEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(qa_Push_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", qa_Push_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objqa_Push = qa_Push_GetObjFromJsonObj(returnObj);
return objqa_Push;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_Push_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_Push_ConstructorName, strThisFuncName);
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
export async function qa_Push_GetObjLstAsync(strWhereCond: string): Promise<Array<clsqa_PushEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(qa_Push_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", qa_Push_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = qa_Push_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_Push_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_Push_ConstructorName, strThisFuncName);
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
 * @param arrPushId:关键字列表
 * @returns 对象列表
 **/
export async function qa_Push_GetObjLstByPushIdLstAsync(arrPushId: Array<string>): Promise<Array<clsqa_PushEN>>  
{
const strThisFuncName = "GetObjLstByPushIdLstAsync";
const strAction = "GetObjLstByPushIdLst";
const strUrl = GetWebApiUrl(qa_Push_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrPushId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", qa_Push_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = qa_Push_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_Push_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_Push_ConstructorName, strThisFuncName);
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
export async function qa_Push_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsqa_PushEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(qa_Push_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", qa_Push_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = qa_Push_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_Push_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_Push_ConstructorName, strThisFuncName);
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
export async function qa_Push_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsqa_PushEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(qa_Push_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", qa_Push_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = qa_Push_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_Push_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_Push_ConstructorName, strThisFuncName);
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
export async function qa_Push_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(qa_Push_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_Push_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_Push_ConstructorName, strThisFuncName);
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
export async function qa_Push_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsqa_PushEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(qa_Push_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", qa_Push_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = qa_Push_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_Push_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_Push_ConstructorName, strThisFuncName);
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
 * @param lngPushId:关键字
 * @returns 获取删除的结果
 **/
export async function qa_Push_DelRecordAsync(lngPushId: number): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(qa_Push_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, lngPushId);
try
{
const response = await axios.delete(strUrl,
{
params: { "Id": lngPushId, }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_Push_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_Push_ConstructorName, strThisFuncName);
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
 * @param arrPushId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function qa_Push_Delqa_PushsAsync(arrPushId: Array<string>): Promise<number> 
{
const strThisFuncName = "Delqa_PushsAsync";
const strAction = "Delqa_Pushs";
const strUrl = GetWebApiUrl(qa_Push_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrPushId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_Push_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_Push_ConstructorName, strThisFuncName);
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
export async function qa_Push_Delqa_PushsByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "Delqa_PushsByCondAsync";
const strAction = "Delqa_PushsByCond";
const strUrl = GetWebApiUrl(qa_Push_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_Push_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_Push_ConstructorName, strThisFuncName);
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
 * @param objqa_PushEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function qa_Push_AddNewRecordAsync(objqa_PushEN: clsqa_PushEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objqa_PushEN);
const strUrl = GetWebApiUrl(qa_Push_Controller, strAction);
try
{
const response = await axios.post(strUrl, objqa_PushEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_Push_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_Push_ConstructorName, strThisFuncName);
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
 * @param objqa_PushEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function qa_Push_AddNewRecordWithReturnKeyAsync(objqa_PushEN: clsqa_PushEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(qa_Push_Controller, strAction);
try
{
const response = await axios.post(strUrl, objqa_PushEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_Push_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_Push_ConstructorName, strThisFuncName);
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
 * @param objqa_PushEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function qa_Push_AddNewRecordWithReturnKey(objqa_PushEN: clsqa_PushEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objqa_PushEN.pushId === null || objqa_PushEN.pushId === 0)
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(qa_Push_Controller, strAction);
try
{
const response = await axios.post(strUrl, objqa_PushEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_Push_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_Push_ConstructorName, strThisFuncName);
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
 * @param objqa_PushEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function qa_Push_UpdateRecordAsync(objqa_PushEN: clsqa_PushEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objqa_PushEN.sf_UpdFldSetStr === undefined || objqa_PushEN.sf_UpdFldSetStr === null || objqa_PushEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objqa_PushEN.pushId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(qa_Push_Controller, strAction);
try
{
const response = await axios.post(strUrl, objqa_PushEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_Push_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_Push_ConstructorName, strThisFuncName);
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
 * @param objqa_PushEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function qa_Push_UpdateWithConditionAsync(objqa_PushEN: clsqa_PushEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objqa_PushEN.sf_UpdFldSetStr === undefined || objqa_PushEN.sf_UpdFldSetStr === null || objqa_PushEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objqa_PushEN.pushId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(qa_Push_Controller, strAction);
objqa_PushEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objqa_PushEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_Push_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_Push_ConstructorName, strThisFuncName);
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
export async function qa_Push_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(qa_Push_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_Push_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_Push_ConstructorName, strThisFuncName);
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
 * @param lngPushId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function qa_Push_IsExist(lngPushId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(qa_Push_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"PushId": lngPushId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_Push_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_Push_ConstructorName, strThisFuncName);
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
 * @param lngPushId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function qa_Push_IsExistAsync(lngPushId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(qa_Push_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "lngPushId": lngPushId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_Push_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_Push_ConstructorName, strThisFuncName);
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
export async function qa_Push_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(qa_Push_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_Push_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_Push_ConstructorName, strThisFuncName);
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
export async function qa_Push_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(qa_Push_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_Push_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_Push_ConstructorName, strThisFuncName);
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
export function qa_Push_GetWebApiUrl(strController: string, strAction: string): string {
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
export function qa_Push_CheckPropertyNew(pobjqa_PushEN: clsqa_PushEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjqa_PushEN.questionsId) === true )
{
 throw new Error("(errid:Watl000058)字段[提问Id]不能为空(In 答疑推送)!(clsqa_PushBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjqa_PushEN.questionsId) == false && GetStrLen(pobjqa_PushEN.questionsId) > 8)
{
 throw new Error("(errid:Watl000059)字段[提问Id(questionsId)]的长度不能超过8(In 答疑推送(qa_Push))!值:$(pobjqa_PushEN.questionsId)(clsqa_PushBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjqa_PushEN.receiveUser) == false && GetStrLen(pobjqa_PushEN.receiveUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[接收用户(receiveUser)]的长度不能超过20(In 答疑推送(qa_Push))!值:$(pobjqa_PushEN.receiveUser)(clsqa_PushBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjqa_PushEN.receiveDate) == false && GetStrLen(pobjqa_PushEN.receiveDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[接收日期(receiveDate)]的长度不能超过20(In 答疑推送(qa_Push))!值:$(pobjqa_PushEN.receiveDate)(clsqa_PushBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjqa_PushEN.updDate) == false && GetStrLen(pobjqa_PushEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 答疑推送(qa_Push))!值:$(pobjqa_PushEN.updDate)(clsqa_PushBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjqa_PushEN.memo) == false && GetStrLen(pobjqa_PushEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 答疑推送(qa_Push))!值:$(pobjqa_PushEN.memo)(clsqa_PushBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjqa_PushEN.id_CurrEduCls) == false && GetStrLen(pobjqa_PushEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 答疑推送(qa_Push))!值:$(pobjqa_PushEN.id_CurrEduCls)(clsqa_PushBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjqa_PushEN.replyDate) == false && GetStrLen(pobjqa_PushEN.replyDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[回复日期(replyDate)]的长度不能超过20(In 答疑推送(qa_Push))!值:$(pobjqa_PushEN.replyDate)(clsqa_PushBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null != pobjqa_PushEN.pushId && undefined !== pobjqa_PushEN.pushId && tzDataType.isNumber(pobjqa_PushEN.pushId) === false)
{
 throw new Error("(errid:Watl000060)字段[推送d(pushId)]的值:[$(pobjqa_PushEN.pushId)], 非法，应该为数值型(In 答疑推送(qa_Push))!(clsqa_PushBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjqa_PushEN.questionsId) == false && undefined !== pobjqa_PushEN.questionsId && tzDataType.isString(pobjqa_PushEN.questionsId) === false)
{
 throw new Error("(errid:Watl000060)字段[提问Id(questionsId)]的值:[$(pobjqa_PushEN.questionsId)], 非法，应该为字符型(In 答疑推送(qa_Push))!(clsqa_PushBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjqa_PushEN.receiveUser) == false && undefined !== pobjqa_PushEN.receiveUser && tzDataType.isString(pobjqa_PushEN.receiveUser) === false)
{
 throw new Error("(errid:Watl000060)字段[接收用户(receiveUser)]的值:[$(pobjqa_PushEN.receiveUser)], 非法，应该为字符型(In 答疑推送(qa_Push))!(clsqa_PushBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjqa_PushEN.receiveDate) == false && undefined !== pobjqa_PushEN.receiveDate && tzDataType.isString(pobjqa_PushEN.receiveDate) === false)
{
 throw new Error("(errid:Watl000060)字段[接收日期(receiveDate)]的值:[$(pobjqa_PushEN.receiveDate)], 非法，应该为字符型(In 答疑推送(qa_Push))!(clsqa_PushBL:CheckPropertyNew)");
}
if (null != pobjqa_PushEN.isReceive && undefined !== pobjqa_PushEN.isReceive && tzDataType.isBoolean(pobjqa_PushEN.isReceive) === false)
{
 throw new Error("(errid:Watl000060)字段[是否接收(isReceive)]的值:[$(pobjqa_PushEN.isReceive)], 非法，应该为布尔型(In 答疑推送(qa_Push))!(clsqa_PushBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjqa_PushEN.updDate) == false && undefined !== pobjqa_PushEN.updDate && tzDataType.isString(pobjqa_PushEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjqa_PushEN.updDate)], 非法，应该为字符型(In 答疑推送(qa_Push))!(clsqa_PushBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjqa_PushEN.memo) == false && undefined !== pobjqa_PushEN.memo && tzDataType.isString(pobjqa_PushEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjqa_PushEN.memo)], 非法，应该为字符型(In 答疑推送(qa_Push))!(clsqa_PushBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjqa_PushEN.id_CurrEduCls) == false && undefined !== pobjqa_PushEN.id_CurrEduCls && tzDataType.isString(pobjqa_PushEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjqa_PushEN.id_CurrEduCls)], 非法，应该为字符型(In 答疑推送(qa_Push))!(clsqa_PushBL:CheckPropertyNew)");
}
if (null != pobjqa_PushEN.isReply && undefined !== pobjqa_PushEN.isReply && tzDataType.isBoolean(pobjqa_PushEN.isReply) === false)
{
 throw new Error("(errid:Watl000060)字段[是否回复(isReply)]的值:[$(pobjqa_PushEN.isReply)], 非法，应该为布尔型(In 答疑推送(qa_Push))!(clsqa_PushBL:CheckPropertyNew)");
}
if (null != pobjqa_PushEN.isRequestReply && undefined !== pobjqa_PushEN.isRequestReply && tzDataType.isBoolean(pobjqa_PushEN.isRequestReply) === false)
{
 throw new Error("(errid:Watl000060)字段[是否要求回复(isRequestReply)]的值:[$(pobjqa_PushEN.isRequestReply)], 非法，应该为布尔型(In 答疑推送(qa_Push))!(clsqa_PushBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjqa_PushEN.replyDate) == false && undefined !== pobjqa_PushEN.replyDate && tzDataType.isString(pobjqa_PushEN.replyDate) === false)
{
 throw new Error("(errid:Watl000060)字段[回复日期(replyDate)]的值:[$(pobjqa_PushEN.replyDate)], 非法，应该为字符型(In 答疑推送(qa_Push))!(clsqa_PushBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjqa_PushEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function qa_Push_CheckProperty4Update (pobjqa_PushEN: clsqa_PushEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjqa_PushEN.questionsId) == false && GetStrLen(pobjqa_PushEN.questionsId) > 8)
{
 throw new Error("(errid:Watl000062)字段[提问Id(questionsId)]的长度不能超过8(In 答疑推送(qa_Push))!值:$(pobjqa_PushEN.questionsId)(clsqa_PushBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjqa_PushEN.receiveUser) == false && GetStrLen(pobjqa_PushEN.receiveUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[接收用户(receiveUser)]的长度不能超过20(In 答疑推送(qa_Push))!值:$(pobjqa_PushEN.receiveUser)(clsqa_PushBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjqa_PushEN.receiveDate) == false && GetStrLen(pobjqa_PushEN.receiveDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[接收日期(receiveDate)]的长度不能超过20(In 答疑推送(qa_Push))!值:$(pobjqa_PushEN.receiveDate)(clsqa_PushBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjqa_PushEN.updDate) == false && GetStrLen(pobjqa_PushEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 答疑推送(qa_Push))!值:$(pobjqa_PushEN.updDate)(clsqa_PushBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjqa_PushEN.memo) == false && GetStrLen(pobjqa_PushEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 答疑推送(qa_Push))!值:$(pobjqa_PushEN.memo)(clsqa_PushBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjqa_PushEN.id_CurrEduCls) == false && GetStrLen(pobjqa_PushEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 答疑推送(qa_Push))!值:$(pobjqa_PushEN.id_CurrEduCls)(clsqa_PushBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjqa_PushEN.replyDate) == false && GetStrLen(pobjqa_PushEN.replyDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[回复日期(replyDate)]的长度不能超过20(In 答疑推送(qa_Push))!值:$(pobjqa_PushEN.replyDate)(clsqa_PushBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null != pobjqa_PushEN.pushId && undefined !== pobjqa_PushEN.pushId && tzDataType.isNumber(pobjqa_PushEN.pushId) === false)
{
 throw new Error("(errid:Watl000063)字段[推送d(pushId)]的值:[$(pobjqa_PushEN.pushId)], 非法，应该为数值型(In 答疑推送(qa_Push))!(clsqa_PushBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjqa_PushEN.questionsId) == false && undefined !== pobjqa_PushEN.questionsId && tzDataType.isString(pobjqa_PushEN.questionsId) === false)
{
 throw new Error("(errid:Watl000063)字段[提问Id(questionsId)]的值:[$(pobjqa_PushEN.questionsId)], 非法，应该为字符型(In 答疑推送(qa_Push))!(clsqa_PushBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjqa_PushEN.receiveUser) == false && undefined !== pobjqa_PushEN.receiveUser && tzDataType.isString(pobjqa_PushEN.receiveUser) === false)
{
 throw new Error("(errid:Watl000063)字段[接收用户(receiveUser)]的值:[$(pobjqa_PushEN.receiveUser)], 非法，应该为字符型(In 答疑推送(qa_Push))!(clsqa_PushBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjqa_PushEN.receiveDate) == false && undefined !== pobjqa_PushEN.receiveDate && tzDataType.isString(pobjqa_PushEN.receiveDate) === false)
{
 throw new Error("(errid:Watl000063)字段[接收日期(receiveDate)]的值:[$(pobjqa_PushEN.receiveDate)], 非法，应该为字符型(In 答疑推送(qa_Push))!(clsqa_PushBL:CheckProperty4Update)");
}
if (null != pobjqa_PushEN.isReceive && undefined !== pobjqa_PushEN.isReceive && tzDataType.isBoolean(pobjqa_PushEN.isReceive) === false)
{
 throw new Error("(errid:Watl000063)字段[是否接收(isReceive)]的值:[$(pobjqa_PushEN.isReceive)], 非法，应该为布尔型(In 答疑推送(qa_Push))!(clsqa_PushBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjqa_PushEN.updDate) == false && undefined !== pobjqa_PushEN.updDate && tzDataType.isString(pobjqa_PushEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjqa_PushEN.updDate)], 非法，应该为字符型(In 答疑推送(qa_Push))!(clsqa_PushBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjqa_PushEN.memo) == false && undefined !== pobjqa_PushEN.memo && tzDataType.isString(pobjqa_PushEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjqa_PushEN.memo)], 非法，应该为字符型(In 答疑推送(qa_Push))!(clsqa_PushBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjqa_PushEN.id_CurrEduCls) == false && undefined !== pobjqa_PushEN.id_CurrEduCls && tzDataType.isString(pobjqa_PushEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjqa_PushEN.id_CurrEduCls)], 非法，应该为字符型(In 答疑推送(qa_Push))!(clsqa_PushBL:CheckProperty4Update)");
}
if (null != pobjqa_PushEN.isReply && undefined !== pobjqa_PushEN.isReply && tzDataType.isBoolean(pobjqa_PushEN.isReply) === false)
{
 throw new Error("(errid:Watl000063)字段[是否回复(isReply)]的值:[$(pobjqa_PushEN.isReply)], 非法，应该为布尔型(In 答疑推送(qa_Push))!(clsqa_PushBL:CheckProperty4Update)");
}
if (null != pobjqa_PushEN.isRequestReply && undefined !== pobjqa_PushEN.isRequestReply && tzDataType.isBoolean(pobjqa_PushEN.isRequestReply) === false)
{
 throw new Error("(errid:Watl000063)字段[是否要求回复(isRequestReply)]的值:[$(pobjqa_PushEN.isRequestReply)], 非法，应该为布尔型(In 答疑推送(qa_Push))!(clsqa_PushBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjqa_PushEN.replyDate) == false && undefined !== pobjqa_PushEN.replyDate && tzDataType.isString(pobjqa_PushEN.replyDate) === false)
{
 throw new Error("(errid:Watl000063)字段[回复日期(replyDate)]的值:[$(pobjqa_PushEN.replyDate)], 非法，应该为字符型(In 答疑推送(qa_Push))!(clsqa_PushBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjqa_PushEN.pushId 
 || pobjqa_PushEN.pushId != null && pobjqa_PushEN.pushId.toString()  ===  "")
{
 throw new Error("(errid:Watl000064)字段[推送d]不能为空(In 答疑推送)!(clsqa_PushBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjqa_PushEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function qa_Push_GetJSONStrByObj (pobjqa_PushEN: clsqa_PushEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjqa_PushEN.sf_UpdFldSetStr = pobjqa_PushEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjqa_PushEN);
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
export function qa_Push_GetObjLstByJSONStr (strJSON: string): Array<clsqa_PushEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrqa_PushObjLst = new Array<clsqa_PushEN>();
if (strJSON === "")
{
return arrqa_PushObjLst;
}
try
{
arrqa_PushObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrqa_PushObjLst;
}
return arrqa_PushObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrqa_PushObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function qa_Push_GetObjLstByJSONObjLst (arrqa_PushObjLstS: Array<clsqa_PushEN>): Array<clsqa_PushEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrqa_PushObjLst = new Array<clsqa_PushEN>();
for (const objInFor of arrqa_PushObjLstS) {
const obj1 = qa_Push_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrqa_PushObjLst.push(obj1);
}
return arrqa_PushObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function qa_Push_GetObjByJSONStr (strJSON: string): clsqa_PushEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjqa_PushEN = new clsqa_PushEN();
if (strJSON === "")
{
return pobjqa_PushEN;
}
try
{
pobjqa_PushEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjqa_PushEN;
}
return pobjqa_PushEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function qa_Push_GetCombineCondition(objqa_Push_Cond: clsqa_PushEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objqa_Push_Cond.dicFldComparisonOp, clsqa_PushEN.con_PushId) == true)
{
const strComparisonOp_PushId:string = objqa_Push_Cond.dicFldComparisonOp[clsqa_PushEN.con_PushId];
strWhereCond += Format(" And {0} {2} {1}", clsqa_PushEN.con_PushId, objqa_Push_Cond.pushId, strComparisonOp_PushId);
}
if (Object.prototype.hasOwnProperty.call(objqa_Push_Cond.dicFldComparisonOp, clsqa_PushEN.con_QuestionsId) == true)
{
const strComparisonOp_QuestionsId:string = objqa_Push_Cond.dicFldComparisonOp[clsqa_PushEN.con_QuestionsId];
strWhereCond += Format(" And {0} {2} '{1}'", clsqa_PushEN.con_QuestionsId, objqa_Push_Cond.questionsId, strComparisonOp_QuestionsId);
}
if (Object.prototype.hasOwnProperty.call(objqa_Push_Cond.dicFldComparisonOp, clsqa_PushEN.con_ReceiveUser) == true)
{
const strComparisonOp_ReceiveUser:string = objqa_Push_Cond.dicFldComparisonOp[clsqa_PushEN.con_ReceiveUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsqa_PushEN.con_ReceiveUser, objqa_Push_Cond.receiveUser, strComparisonOp_ReceiveUser);
}
if (Object.prototype.hasOwnProperty.call(objqa_Push_Cond.dicFldComparisonOp, clsqa_PushEN.con_ReceiveDate) == true)
{
const strComparisonOp_ReceiveDate:string = objqa_Push_Cond.dicFldComparisonOp[clsqa_PushEN.con_ReceiveDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsqa_PushEN.con_ReceiveDate, objqa_Push_Cond.receiveDate, strComparisonOp_ReceiveDate);
}
if (Object.prototype.hasOwnProperty.call(objqa_Push_Cond.dicFldComparisonOp, clsqa_PushEN.con_IsReceive) == true)
{
if (objqa_Push_Cond.isReceive == true)
{
strWhereCond += Format(" And {0} = '1'", clsqa_PushEN.con_IsReceive);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsqa_PushEN.con_IsReceive);
}
}
if (Object.prototype.hasOwnProperty.call(objqa_Push_Cond.dicFldComparisonOp, clsqa_PushEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objqa_Push_Cond.dicFldComparisonOp[clsqa_PushEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsqa_PushEN.con_UpdDate, objqa_Push_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objqa_Push_Cond.dicFldComparisonOp, clsqa_PushEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objqa_Push_Cond.dicFldComparisonOp[clsqa_PushEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsqa_PushEN.con_Memo, objqa_Push_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objqa_Push_Cond.dicFldComparisonOp, clsqa_PushEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objqa_Push_Cond.dicFldComparisonOp[clsqa_PushEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsqa_PushEN.con_id_CurrEduCls, objqa_Push_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (Object.prototype.hasOwnProperty.call(objqa_Push_Cond.dicFldComparisonOp, clsqa_PushEN.con_IsReply) == true)
{
if (objqa_Push_Cond.isReply == true)
{
strWhereCond += Format(" And {0} = '1'", clsqa_PushEN.con_IsReply);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsqa_PushEN.con_IsReply);
}
}
if (Object.prototype.hasOwnProperty.call(objqa_Push_Cond.dicFldComparisonOp, clsqa_PushEN.con_IsRequestReply) == true)
{
if (objqa_Push_Cond.isRequestReply == true)
{
strWhereCond += Format(" And {0} = '1'", clsqa_PushEN.con_IsRequestReply);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsqa_PushEN.con_IsRequestReply);
}
}
if (Object.prototype.hasOwnProperty.call(objqa_Push_Cond.dicFldComparisonOp, clsqa_PushEN.con_ReplyDate) == true)
{
const strComparisonOp_ReplyDate:string = objqa_Push_Cond.dicFldComparisonOp[clsqa_PushEN.con_ReplyDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsqa_PushEN.con_ReplyDate, objqa_Push_Cond.replyDate, strComparisonOp_ReplyDate);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--qa_Push(答疑推送),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param lngPushId: 推送d(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function qa_Push_GetUniCondStr_PushId(objqa_PushEN: clsqa_PushEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and PushId = '{0}'", objqa_PushEN.pushId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--qa_Push(答疑推送),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param lngPushId: 推送d(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function qa_Push_GetUniCondStr4Update_PushId(objqa_PushEN: clsqa_PushEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and PushId <> '{0}'", objqa_PushEN.pushId);
 strWhereCond +=  Format(" and PushId = '{0}'", objqa_PushEN.pushId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objqa_PushENS:源对象
 * @param objqa_PushENT:目标对象
*/
export function qa_Push_CopyObjTo(objqa_PushENS: clsqa_PushEN , objqa_PushENT: clsqa_PushEN ): void 
{
objqa_PushENT.pushId = objqa_PushENS.pushId; //推送d
objqa_PushENT.questionsId = objqa_PushENS.questionsId; //提问Id
objqa_PushENT.receiveUser = objqa_PushENS.receiveUser; //接收用户
objqa_PushENT.receiveDate = objqa_PushENS.receiveDate; //接收日期
objqa_PushENT.isReceive = objqa_PushENS.isReceive; //是否接收
objqa_PushENT.updDate = objqa_PushENS.updDate; //修改日期
objqa_PushENT.memo = objqa_PushENS.memo; //备注
objqa_PushENT.id_CurrEduCls = objqa_PushENS.id_CurrEduCls; //教学班流水号
objqa_PushENT.isReply = objqa_PushENS.isReply; //是否回复
objqa_PushENT.isRequestReply = objqa_PushENS.isRequestReply; //是否要求回复
objqa_PushENT.replyDate = objqa_PushENS.replyDate; //回复日期
objqa_PushENT.sf_UpdFldSetStr = objqa_PushENS.updFldString; //sf_UpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objqa_PushENS:源对象
 * @param objqa_PushENT:目标对象
*/
export function qa_Push_GetObjFromJsonObj(objqa_PushENS: clsqa_PushEN): clsqa_PushEN 
{
 const objqa_PushENT: clsqa_PushEN = new clsqa_PushEN();
ObjectAssign(objqa_PushENT, objqa_PushENS);
 return objqa_PushENT;
}