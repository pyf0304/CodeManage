
 /**
 * 类名:clsgs_PTopicObjectiveRelaWApi
 * 表名:gs_PTopicObjectiveRela(01120673)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:50:09
 * 生成者:pyf
 * 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:研培论文(GraduateEduPaper)
 * 框架-层名:WA_访问层(TS)(WA_Access)
 * 编程语言:TypeScript
 * 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
   *      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 **/

/**
 * 论文客观关系表(gs_PTopicObjectiveRela)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2023年03月13日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { enumComparisonOp } from "../../PubFun/enumComparisonOp.js";
import { clsgs_PTopicObjectiveRelaEN } from "../../L0_Entity/GraduateEduPaper/clsgs_PTopicObjectiveRelaEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { tzDataType } from "../../PubFun/clsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const gs_PTopicObjectiveRela_Controller = "gs_PTopicObjectiveRelaApi";
 export const gs_PTopicObjectiveRela_ConstructorName = "gs_PTopicObjectiveRela";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngmId:关键字
 * @returns 对象
 **/
export async function gs_PTopicObjectiveRela_GetObjBymIdAsync(lngmId: number): Promise<clsgs_PTopicObjectiveRelaEN|null>  
{
const strThisFuncName = "GetObjBymIdAsync";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In clsgs_PTopicObjectiveRelaWApi.GetObjBymIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjBymId";
const strUrl = GetWebApiUrl(gs_PTopicObjectiveRela_Controller, strAction);
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
const objgs_PTopicObjectiveRela = gs_PTopicObjectiveRela_GetObjFromJsonObj(returnObj);
return objgs_PTopicObjectiveRela;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export function gs_PTopicObjectiveRela_SortFun_Defa(a:clsgs_PTopicObjectiveRelaEN , b:clsgs_PTopicObjectiveRelaEN): number 
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
export function gs_PTopicObjectiveRela_SortFun_Defa_2Fld(a:clsgs_PTopicObjectiveRelaEN , b:clsgs_PTopicObjectiveRelaEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.paperId == b.paperId) return a.sectionId.localeCompare(b.sectionId);
else return a.paperId.localeCompare(b.paperId);
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
export function gs_PTopicObjectiveRela_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsgs_PTopicObjectiveRelaEN.con_mId:
return (a: clsgs_PTopicObjectiveRelaEN, b: clsgs_PTopicObjectiveRelaEN) => {
return a.mId-b.mId;
}
case clsgs_PTopicObjectiveRelaEN.con_PaperId:
return (a: clsgs_PTopicObjectiveRelaEN, b: clsgs_PTopicObjectiveRelaEN) => {
return a.paperId.localeCompare(b.paperId);
}
case clsgs_PTopicObjectiveRelaEN.con_SectionId:
return (a: clsgs_PTopicObjectiveRelaEN, b: clsgs_PTopicObjectiveRelaEN) => {
if (a.sectionId == null) return -1;
if (b.sectionId == null) return 1;
return a.sectionId.localeCompare(b.sectionId);
}
case clsgs_PTopicObjectiveRelaEN.con_TopicObjectiveId:
return (a: clsgs_PTopicObjectiveRelaEN, b: clsgs_PTopicObjectiveRelaEN) => {
return a.topicObjectiveId.localeCompare(b.topicObjectiveId);
}
case clsgs_PTopicObjectiveRelaEN.con_UpdDate:
return (a: clsgs_PTopicObjectiveRelaEN, b: clsgs_PTopicObjectiveRelaEN) => {
if (a.updDate == null) return -1;
if (b.updDate == null) return 1;
return a.updDate.localeCompare(b.updDate);
}
case clsgs_PTopicObjectiveRelaEN.con_UpdUser:
return (a: clsgs_PTopicObjectiveRelaEN, b: clsgs_PTopicObjectiveRelaEN) => {
if (a.updUser == null) return -1;
if (b.updUser == null) return 1;
return a.updUser.localeCompare(b.updUser);
}
case clsgs_PTopicObjectiveRelaEN.con_Memo:
return (a: clsgs_PTopicObjectiveRelaEN, b: clsgs_PTopicObjectiveRelaEN) => {
if (a.memo == null) return -1;
if (b.memo == null) return 1;
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_PTopicObjectiveRela]中不存在！(in ${ gs_PTopicObjectiveRela_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsgs_PTopicObjectiveRelaEN.con_mId:
return (a: clsgs_PTopicObjectiveRelaEN, b: clsgs_PTopicObjectiveRelaEN) => {
return b.mId-a.mId;
}
case clsgs_PTopicObjectiveRelaEN.con_PaperId:
return (a: clsgs_PTopicObjectiveRelaEN, b: clsgs_PTopicObjectiveRelaEN) => {
return b.paperId.localeCompare(a.paperId);
}
case clsgs_PTopicObjectiveRelaEN.con_SectionId:
return (a: clsgs_PTopicObjectiveRelaEN, b: clsgs_PTopicObjectiveRelaEN) => {
if (b.sectionId == null) return -1;
if (a.sectionId == null) return 1;
return b.sectionId.localeCompare(a.sectionId);
}
case clsgs_PTopicObjectiveRelaEN.con_TopicObjectiveId:
return (a: clsgs_PTopicObjectiveRelaEN, b: clsgs_PTopicObjectiveRelaEN) => {
return b.topicObjectiveId.localeCompare(a.topicObjectiveId);
}
case clsgs_PTopicObjectiveRelaEN.con_UpdDate:
return (a: clsgs_PTopicObjectiveRelaEN, b: clsgs_PTopicObjectiveRelaEN) => {
if (b.updDate == null) return -1;
if (a.updDate == null) return 1;
return b.updDate.localeCompare(a.updDate);
}
case clsgs_PTopicObjectiveRelaEN.con_UpdUser:
return (a: clsgs_PTopicObjectiveRelaEN, b: clsgs_PTopicObjectiveRelaEN) => {
if (b.updUser == null) return -1;
if (a.updUser == null) return 1;
return b.updUser.localeCompare(a.updUser);
}
case clsgs_PTopicObjectiveRelaEN.con_Memo:
return (a: clsgs_PTopicObjectiveRelaEN, b: clsgs_PTopicObjectiveRelaEN) => {
if (b.memo == null) return -1;
if (a.memo == null) return 1;
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_PTopicObjectiveRela]中不存在！(in ${ gs_PTopicObjectiveRela_ConstructorName}.${ strThisFuncName})`;
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
export async function gs_PTopicObjectiveRela_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsgs_PTopicObjectiveRelaEN.con_mId:
return (obj: clsgs_PTopicObjectiveRelaEN) => {
return obj.mId === value;
}
case clsgs_PTopicObjectiveRelaEN.con_PaperId:
return (obj: clsgs_PTopicObjectiveRelaEN) => {
return obj.paperId === value;
}
case clsgs_PTopicObjectiveRelaEN.con_SectionId:
return (obj: clsgs_PTopicObjectiveRelaEN) => {
return obj.sectionId === value;
}
case clsgs_PTopicObjectiveRelaEN.con_TopicObjectiveId:
return (obj: clsgs_PTopicObjectiveRelaEN) => {
return obj.topicObjectiveId === value;
}
case clsgs_PTopicObjectiveRelaEN.con_UpdDate:
return (obj: clsgs_PTopicObjectiveRelaEN) => {
return obj.updDate === value;
}
case clsgs_PTopicObjectiveRelaEN.con_UpdUser:
return (obj: clsgs_PTopicObjectiveRelaEN) => {
return obj.updUser === value;
}
case clsgs_PTopicObjectiveRelaEN.con_Memo:
return (obj: clsgs_PTopicObjectiveRelaEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_PTopicObjectiveRela]中不存在！(in ${ gs_PTopicObjectiveRela_ConstructorName}.${ strThisFuncName})`;
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
export async function gs_PTopicObjectiveRela_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(gs_PTopicObjectiveRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export async function gs_PTopicObjectiveRela_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(gs_PTopicObjectiveRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export async function gs_PTopicObjectiveRela_GetFirstObjAsync(strWhereCond: string): Promise<clsgs_PTopicObjectiveRelaEN|null>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(gs_PTopicObjectiveRela_Controller, strAction);
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
const objgs_PTopicObjectiveRela = gs_PTopicObjectiveRela_GetObjFromJsonObj(returnObj);
return objgs_PTopicObjectiveRela;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export async function gs_PTopicObjectiveRela_GetObjLstAsync(strWhereCond: string): Promise<Array<clsgs_PTopicObjectiveRelaEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(gs_PTopicObjectiveRela_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_PTopicObjectiveRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export async function gs_PTopicObjectiveRela_GetObjLstBymIdLstAsync(arrmId: Array<string>): Promise<Array<clsgs_PTopicObjectiveRelaEN>>  
{
const strThisFuncName = "GetObjLstBymIdLstAsync";
const strAction = "GetObjLstBymIdLst";
const strUrl = GetWebApiUrl(gs_PTopicObjectiveRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrmId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_PTopicObjectiveRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export async function gs_PTopicObjectiveRela_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsgs_PTopicObjectiveRelaEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(gs_PTopicObjectiveRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_PTopicObjectiveRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export async function gs_PTopicObjectiveRela_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsgs_PTopicObjectiveRelaEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(gs_PTopicObjectiveRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_PTopicObjectiveRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export async function gs_PTopicObjectiveRela_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(gs_PTopicObjectiveRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export async function gs_PTopicObjectiveRela_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsgs_PTopicObjectiveRelaEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
if (objPagerPara.pageIndex == 0) return new Array<clsgs_PTopicObjectiveRelaEN>();
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(gs_PTopicObjectiveRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_PTopicObjectiveRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export async function gs_PTopicObjectiveRela_DelRecordAsync(lngmId: number): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(gs_PTopicObjectiveRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export async function gs_PTopicObjectiveRela_Delgs_PTopicObjectiveRelasAsync(arrmId: Array<string>): Promise<number> 
{
const strThisFuncName = "Delgs_PTopicObjectiveRelasAsync";
const strAction = "Delgs_PTopicObjectiveRelas";
const strUrl = GetWebApiUrl(gs_PTopicObjectiveRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export async function gs_PTopicObjectiveRela_Delgs_PTopicObjectiveRelasByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "Delgs_PTopicObjectiveRelasByCondAsync";
const strAction = "Delgs_PTopicObjectiveRelasByCond";
const strUrl = GetWebApiUrl(gs_PTopicObjectiveRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
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
 * @param objgs_PTopicObjectiveRelaEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_PTopicObjectiveRela_AddNewRecordAsync(objgs_PTopicObjectiveRelaEN: clsgs_PTopicObjectiveRelaEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objgs_PTopicObjectiveRelaEN);
const strUrl = GetWebApiUrl(gs_PTopicObjectiveRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_PTopicObjectiveRelaEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
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
 * @param objgs_PTopicObjectiveRelaEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function gs_PTopicObjectiveRela_AddNewRecordWithReturnKeyAsync(objgs_PTopicObjectiveRelaEN: clsgs_PTopicObjectiveRelaEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(gs_PTopicObjectiveRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_PTopicObjectiveRelaEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
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
 * @param objgs_PTopicObjectiveRelaEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function gs_PTopicObjectiveRela_AddNewRecordWithReturnKey(objgs_PTopicObjectiveRelaEN: clsgs_PTopicObjectiveRelaEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objgs_PTopicObjectiveRelaEN.mId === null || objgs_PTopicObjectiveRelaEN.mId === 0)
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(gs_PTopicObjectiveRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_PTopicObjectiveRelaEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
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
 * @param objgs_PTopicObjectiveRelaEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function gs_PTopicObjectiveRela_UpdateRecordAsync(objgs_PTopicObjectiveRelaEN: clsgs_PTopicObjectiveRelaEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objgs_PTopicObjectiveRelaEN.sfUpdFldSetStr === undefined || objgs_PTopicObjectiveRelaEN.sfUpdFldSetStr === null || objgs_PTopicObjectiveRelaEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_PTopicObjectiveRelaEN.mId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(gs_PTopicObjectiveRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_PTopicObjectiveRelaEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
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
 * @param objgs_PTopicObjectiveRelaEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function gs_PTopicObjectiveRela_UpdateWithConditionAsync(objgs_PTopicObjectiveRelaEN: clsgs_PTopicObjectiveRelaEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objgs_PTopicObjectiveRelaEN.sfUpdFldSetStr === undefined || objgs_PTopicObjectiveRelaEN.sfUpdFldSetStr === null || objgs_PTopicObjectiveRelaEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_PTopicObjectiveRelaEN.mId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(gs_PTopicObjectiveRela_Controller, strAction);
objgs_PTopicObjectiveRelaEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objgs_PTopicObjectiveRelaEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export async function gs_PTopicObjectiveRela_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(gs_PTopicObjectiveRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export async function gs_PTopicObjectiveRela_IsExist(lngmId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(gs_PTopicObjectiveRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export async function gs_PTopicObjectiveRela_IsExistAsync(lngmId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(gs_PTopicObjectiveRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export async function gs_PTopicObjectiveRela_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(gs_PTopicObjectiveRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export async function gs_PTopicObjectiveRela_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(gs_PTopicObjectiveRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export function gs_PTopicObjectiveRela_GetWebApiUrl(strController: string, strAction: string): string {
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
export function gs_PTopicObjectiveRela_CheckPropertyNew(pobjgs_PTopicObjectiveRelaEN: clsgs_PTopicObjectiveRelaEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjgs_PTopicObjectiveRelaEN.paperId) === true 
 || pobjgs_PTopicObjectiveRelaEN.paperId.toString()  ===  "0" )
{
 throw new Error("(errid:Watl000058)字段[论文Id]不能为空(In 论文客观关系表)!(clsgs_PTopicObjectiveRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PTopicObjectiveRelaEN.topicObjectiveId) === true )
{
 throw new Error("(errid:Watl000058)字段[客观Id]不能为空(In 论文客观关系表)!(clsgs_PTopicObjectiveRelaBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjgs_PTopicObjectiveRelaEN.paperId) == false && GetStrLen(pobjgs_PTopicObjectiveRelaEN.paperId) > 8)
{
 throw new Error("(errid:Watl000059)字段[论文Id(paperId)]的长度不能超过8(In 论文客观关系表(gs_PTopicObjectiveRela))!值:$(pobjgs_PTopicObjectiveRelaEN.paperId)(clsgs_PTopicObjectiveRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PTopicObjectiveRelaEN.sectionId) == false && GetStrLen(pobjgs_PTopicObjectiveRelaEN.sectionId) > 8)
{
 throw new Error("(errid:Watl000059)字段[节Id(sectionId)]的长度不能超过8(In 论文客观关系表(gs_PTopicObjectiveRela))!值:$(pobjgs_PTopicObjectiveRelaEN.sectionId)(clsgs_PTopicObjectiveRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PTopicObjectiveRelaEN.topicObjectiveId) == false && GetStrLen(pobjgs_PTopicObjectiveRelaEN.topicObjectiveId) > 8)
{
 throw new Error("(errid:Watl000059)字段[客观Id(topicObjectiveId)]的长度不能超过8(In 论文客观关系表(gs_PTopicObjectiveRela))!值:$(pobjgs_PTopicObjectiveRelaEN.topicObjectiveId)(clsgs_PTopicObjectiveRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PTopicObjectiveRelaEN.updDate) == false && GetStrLen(pobjgs_PTopicObjectiveRelaEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 论文客观关系表(gs_PTopicObjectiveRela))!值:$(pobjgs_PTopicObjectiveRelaEN.updDate)(clsgs_PTopicObjectiveRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PTopicObjectiveRelaEN.updUser) == false && GetStrLen(pobjgs_PTopicObjectiveRelaEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 论文客观关系表(gs_PTopicObjectiveRela))!值:$(pobjgs_PTopicObjectiveRelaEN.updUser)(clsgs_PTopicObjectiveRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PTopicObjectiveRelaEN.memo) == false && GetStrLen(pobjgs_PTopicObjectiveRelaEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 论文客观关系表(gs_PTopicObjectiveRela))!值:$(pobjgs_PTopicObjectiveRelaEN.memo)(clsgs_PTopicObjectiveRelaBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null != pobjgs_PTopicObjectiveRelaEN.mId && undefined !== pobjgs_PTopicObjectiveRelaEN.mId && tzDataType.isNumber(pobjgs_PTopicObjectiveRelaEN.mId) === false)
{
 throw new Error("(errid:Watl000060)字段[mId(mId)]的值:[$(pobjgs_PTopicObjectiveRelaEN.mId)], 非法，应该为数值型(In 论文客观关系表(gs_PTopicObjectiveRela))!(clsgs_PTopicObjectiveRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PTopicObjectiveRelaEN.paperId) == false && undefined !== pobjgs_PTopicObjectiveRelaEN.paperId && tzDataType.isString(pobjgs_PTopicObjectiveRelaEN.paperId) === false)
{
 throw new Error("(errid:Watl000060)字段[论文Id(paperId)]的值:[$(pobjgs_PTopicObjectiveRelaEN.paperId)], 非法，应该为字符型(In 论文客观关系表(gs_PTopicObjectiveRela))!(clsgs_PTopicObjectiveRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PTopicObjectiveRelaEN.sectionId) == false && undefined !== pobjgs_PTopicObjectiveRelaEN.sectionId && tzDataType.isString(pobjgs_PTopicObjectiveRelaEN.sectionId) === false)
{
 throw new Error("(errid:Watl000060)字段[节Id(sectionId)]的值:[$(pobjgs_PTopicObjectiveRelaEN.sectionId)], 非法，应该为字符型(In 论文客观关系表(gs_PTopicObjectiveRela))!(clsgs_PTopicObjectiveRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PTopicObjectiveRelaEN.topicObjectiveId) == false && undefined !== pobjgs_PTopicObjectiveRelaEN.topicObjectiveId && tzDataType.isString(pobjgs_PTopicObjectiveRelaEN.topicObjectiveId) === false)
{
 throw new Error("(errid:Watl000060)字段[客观Id(topicObjectiveId)]的值:[$(pobjgs_PTopicObjectiveRelaEN.topicObjectiveId)], 非法，应该为字符型(In 论文客观关系表(gs_PTopicObjectiveRela))!(clsgs_PTopicObjectiveRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PTopicObjectiveRelaEN.updDate) == false && undefined !== pobjgs_PTopicObjectiveRelaEN.updDate && tzDataType.isString(pobjgs_PTopicObjectiveRelaEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjgs_PTopicObjectiveRelaEN.updDate)], 非法，应该为字符型(In 论文客观关系表(gs_PTopicObjectiveRela))!(clsgs_PTopicObjectiveRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PTopicObjectiveRelaEN.updUser) == false && undefined !== pobjgs_PTopicObjectiveRelaEN.updUser && tzDataType.isString(pobjgs_PTopicObjectiveRelaEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjgs_PTopicObjectiveRelaEN.updUser)], 非法，应该为字符型(In 论文客观关系表(gs_PTopicObjectiveRela))!(clsgs_PTopicObjectiveRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PTopicObjectiveRelaEN.memo) == false && undefined !== pobjgs_PTopicObjectiveRelaEN.memo && tzDataType.isString(pobjgs_PTopicObjectiveRelaEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjgs_PTopicObjectiveRelaEN.memo)], 非法，应该为字符型(In 论文客观关系表(gs_PTopicObjectiveRela))!(clsgs_PTopicObjectiveRelaBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjgs_PTopicObjectiveRelaEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function gs_PTopicObjectiveRela_CheckProperty4Update (pobjgs_PTopicObjectiveRelaEN: clsgs_PTopicObjectiveRelaEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjgs_PTopicObjectiveRelaEN.paperId) == false && GetStrLen(pobjgs_PTopicObjectiveRelaEN.paperId) > 8)
{
 throw new Error("(errid:Watl000062)字段[论文Id(paperId)]的长度不能超过8(In 论文客观关系表(gs_PTopicObjectiveRela))!值:$(pobjgs_PTopicObjectiveRelaEN.paperId)(clsgs_PTopicObjectiveRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PTopicObjectiveRelaEN.sectionId) == false && GetStrLen(pobjgs_PTopicObjectiveRelaEN.sectionId) > 8)
{
 throw new Error("(errid:Watl000062)字段[节Id(sectionId)]的长度不能超过8(In 论文客观关系表(gs_PTopicObjectiveRela))!值:$(pobjgs_PTopicObjectiveRelaEN.sectionId)(clsgs_PTopicObjectiveRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PTopicObjectiveRelaEN.topicObjectiveId) == false && GetStrLen(pobjgs_PTopicObjectiveRelaEN.topicObjectiveId) > 8)
{
 throw new Error("(errid:Watl000062)字段[客观Id(topicObjectiveId)]的长度不能超过8(In 论文客观关系表(gs_PTopicObjectiveRela))!值:$(pobjgs_PTopicObjectiveRelaEN.topicObjectiveId)(clsgs_PTopicObjectiveRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PTopicObjectiveRelaEN.updDate) == false && GetStrLen(pobjgs_PTopicObjectiveRelaEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 论文客观关系表(gs_PTopicObjectiveRela))!值:$(pobjgs_PTopicObjectiveRelaEN.updDate)(clsgs_PTopicObjectiveRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PTopicObjectiveRelaEN.updUser) == false && GetStrLen(pobjgs_PTopicObjectiveRelaEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 论文客观关系表(gs_PTopicObjectiveRela))!值:$(pobjgs_PTopicObjectiveRelaEN.updUser)(clsgs_PTopicObjectiveRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PTopicObjectiveRelaEN.memo) == false && GetStrLen(pobjgs_PTopicObjectiveRelaEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 论文客观关系表(gs_PTopicObjectiveRela))!值:$(pobjgs_PTopicObjectiveRelaEN.memo)(clsgs_PTopicObjectiveRelaBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null != pobjgs_PTopicObjectiveRelaEN.mId && undefined !== pobjgs_PTopicObjectiveRelaEN.mId && tzDataType.isNumber(pobjgs_PTopicObjectiveRelaEN.mId) === false)
{
 throw new Error("(errid:Watl000063)字段[mId(mId)]的值:[$(pobjgs_PTopicObjectiveRelaEN.mId)], 非法，应该为数值型(In 论文客观关系表(gs_PTopicObjectiveRela))!(clsgs_PTopicObjectiveRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PTopicObjectiveRelaEN.paperId) == false && undefined !== pobjgs_PTopicObjectiveRelaEN.paperId && tzDataType.isString(pobjgs_PTopicObjectiveRelaEN.paperId) === false)
{
 throw new Error("(errid:Watl000063)字段[论文Id(paperId)]的值:[$(pobjgs_PTopicObjectiveRelaEN.paperId)], 非法，应该为字符型(In 论文客观关系表(gs_PTopicObjectiveRela))!(clsgs_PTopicObjectiveRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PTopicObjectiveRelaEN.sectionId) == false && undefined !== pobjgs_PTopicObjectiveRelaEN.sectionId && tzDataType.isString(pobjgs_PTopicObjectiveRelaEN.sectionId) === false)
{
 throw new Error("(errid:Watl000063)字段[节Id(sectionId)]的值:[$(pobjgs_PTopicObjectiveRelaEN.sectionId)], 非法，应该为字符型(In 论文客观关系表(gs_PTopicObjectiveRela))!(clsgs_PTopicObjectiveRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PTopicObjectiveRelaEN.topicObjectiveId) == false && undefined !== pobjgs_PTopicObjectiveRelaEN.topicObjectiveId && tzDataType.isString(pobjgs_PTopicObjectiveRelaEN.topicObjectiveId) === false)
{
 throw new Error("(errid:Watl000063)字段[客观Id(topicObjectiveId)]的值:[$(pobjgs_PTopicObjectiveRelaEN.topicObjectiveId)], 非法，应该为字符型(In 论文客观关系表(gs_PTopicObjectiveRela))!(clsgs_PTopicObjectiveRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PTopicObjectiveRelaEN.updDate) == false && undefined !== pobjgs_PTopicObjectiveRelaEN.updDate && tzDataType.isString(pobjgs_PTopicObjectiveRelaEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjgs_PTopicObjectiveRelaEN.updDate)], 非法，应该为字符型(In 论文客观关系表(gs_PTopicObjectiveRela))!(clsgs_PTopicObjectiveRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PTopicObjectiveRelaEN.updUser) == false && undefined !== pobjgs_PTopicObjectiveRelaEN.updUser && tzDataType.isString(pobjgs_PTopicObjectiveRelaEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjgs_PTopicObjectiveRelaEN.updUser)], 非法，应该为字符型(In 论文客观关系表(gs_PTopicObjectiveRela))!(clsgs_PTopicObjectiveRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PTopicObjectiveRelaEN.memo) == false && undefined !== pobjgs_PTopicObjectiveRelaEN.memo && tzDataType.isString(pobjgs_PTopicObjectiveRelaEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjgs_PTopicObjectiveRelaEN.memo)], 非法，应该为字符型(In 论文客观关系表(gs_PTopicObjectiveRela))!(clsgs_PTopicObjectiveRelaBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjgs_PTopicObjectiveRelaEN.mId 
 || pobjgs_PTopicObjectiveRelaEN.mId != null && pobjgs_PTopicObjectiveRelaEN.mId.toString()  ===  "")
{
 throw new Error("(errid:Watl000064)字段[mId]不能为空(In 论文客观关系表)!(clsgs_PTopicObjectiveRelaBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjgs_PTopicObjectiveRelaEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function gs_PTopicObjectiveRela_GetJSONStrByObj (pobjgs_PTopicObjectiveRelaEN: clsgs_PTopicObjectiveRelaEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjgs_PTopicObjectiveRelaEN.sfUpdFldSetStr = pobjgs_PTopicObjectiveRelaEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjgs_PTopicObjectiveRelaEN);
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
export function gs_PTopicObjectiveRela_GetObjLstByJSONStr (strJSON: string): Array<clsgs_PTopicObjectiveRelaEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrgs_PTopicObjectiveRelaObjLst = new Array<clsgs_PTopicObjectiveRelaEN>();
if (strJSON === "")
{
return arrgs_PTopicObjectiveRelaObjLst;
}
try
{
arrgs_PTopicObjectiveRelaObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrgs_PTopicObjectiveRelaObjLst;
}
return arrgs_PTopicObjectiveRelaObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrgs_PTopicObjectiveRelaObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function gs_PTopicObjectiveRela_GetObjLstByJSONObjLst (arrgs_PTopicObjectiveRelaObjLstS: Array<clsgs_PTopicObjectiveRelaEN>): Array<clsgs_PTopicObjectiveRelaEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrgs_PTopicObjectiveRelaObjLst = new Array<clsgs_PTopicObjectiveRelaEN>();
for (const objInFor of arrgs_PTopicObjectiveRelaObjLstS) {
const obj1 = gs_PTopicObjectiveRela_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrgs_PTopicObjectiveRelaObjLst.push(obj1);
}
return arrgs_PTopicObjectiveRelaObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function gs_PTopicObjectiveRela_GetObjByJSONStr (strJSON: string): clsgs_PTopicObjectiveRelaEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjgs_PTopicObjectiveRelaEN = new clsgs_PTopicObjectiveRelaEN();
if (strJSON === "")
{
return pobjgs_PTopicObjectiveRelaEN;
}
try
{
pobjgs_PTopicObjectiveRelaEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjgs_PTopicObjectiveRelaEN;
}
return pobjgs_PTopicObjectiveRelaEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function gs_PTopicObjectiveRela_GetCombineCondition(objgs_PTopicObjectiveRela_Cond: clsgs_PTopicObjectiveRelaEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objgs_PTopicObjectiveRela_Cond.dicFldComparisonOp, clsgs_PTopicObjectiveRelaEN.con_mId) == true)
{
const strComparisonOp_mId:string = objgs_PTopicObjectiveRela_Cond.dicFldComparisonOp[clsgs_PTopicObjectiveRelaEN.con_mId];
strWhereCond += Format(" And {0} {2} {1}", clsgs_PTopicObjectiveRelaEN.con_mId, objgs_PTopicObjectiveRela_Cond.mId, strComparisonOp_mId);
}
if (Object.prototype.hasOwnProperty.call(objgs_PTopicObjectiveRela_Cond.dicFldComparisonOp, clsgs_PTopicObjectiveRelaEN.con_PaperId) == true)
{
const strComparisonOp_PaperId:string = objgs_PTopicObjectiveRela_Cond.dicFldComparisonOp[clsgs_PTopicObjectiveRelaEN.con_PaperId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PTopicObjectiveRelaEN.con_PaperId, objgs_PTopicObjectiveRela_Cond.paperId, strComparisonOp_PaperId);
}
if (Object.prototype.hasOwnProperty.call(objgs_PTopicObjectiveRela_Cond.dicFldComparisonOp, clsgs_PTopicObjectiveRelaEN.con_SectionId) == true)
{
const strComparisonOp_SectionId:string = objgs_PTopicObjectiveRela_Cond.dicFldComparisonOp[clsgs_PTopicObjectiveRelaEN.con_SectionId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PTopicObjectiveRelaEN.con_SectionId, objgs_PTopicObjectiveRela_Cond.sectionId, strComparisonOp_SectionId);
}
if (Object.prototype.hasOwnProperty.call(objgs_PTopicObjectiveRela_Cond.dicFldComparisonOp, clsgs_PTopicObjectiveRelaEN.con_TopicObjectiveId) == true)
{
const strComparisonOp_TopicObjectiveId:string = objgs_PTopicObjectiveRela_Cond.dicFldComparisonOp[clsgs_PTopicObjectiveRelaEN.con_TopicObjectiveId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PTopicObjectiveRelaEN.con_TopicObjectiveId, objgs_PTopicObjectiveRela_Cond.topicObjectiveId, strComparisonOp_TopicObjectiveId);
}
if (Object.prototype.hasOwnProperty.call(objgs_PTopicObjectiveRela_Cond.dicFldComparisonOp, clsgs_PTopicObjectiveRelaEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objgs_PTopicObjectiveRela_Cond.dicFldComparisonOp[clsgs_PTopicObjectiveRelaEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PTopicObjectiveRelaEN.con_UpdDate, objgs_PTopicObjectiveRela_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objgs_PTopicObjectiveRela_Cond.dicFldComparisonOp, clsgs_PTopicObjectiveRelaEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objgs_PTopicObjectiveRela_Cond.dicFldComparisonOp[clsgs_PTopicObjectiveRelaEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PTopicObjectiveRelaEN.con_UpdUser, objgs_PTopicObjectiveRela_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objgs_PTopicObjectiveRela_Cond.dicFldComparisonOp, clsgs_PTopicObjectiveRelaEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objgs_PTopicObjectiveRela_Cond.dicFldComparisonOp[clsgs_PTopicObjectiveRelaEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PTopicObjectiveRelaEN.con_Memo, objgs_PTopicObjectiveRela_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--gs_PTopicObjectiveRela(论文客观关系表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param lngmId: mId(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function gs_PTopicObjectiveRela_GetUniCondStr_mId(objgs_PTopicObjectiveRelaEN: clsgs_PTopicObjectiveRelaEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and mId = '{0}'", objgs_PTopicObjectiveRelaEN.mId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--gs_PTopicObjectiveRela(论文客观关系表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param lngmId: mId(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function gs_PTopicObjectiveRela_GetUniCondStr4Update_mId(objgs_PTopicObjectiveRelaEN: clsgs_PTopicObjectiveRelaEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and mId <> '{0}'", objgs_PTopicObjectiveRelaEN.mId);
 strWhereCond +=  Format(" and mId = '{0}'", objgs_PTopicObjectiveRelaEN.mId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objgs_PTopicObjectiveRelaENS:源对象
 * @param objgs_PTopicObjectiveRelaENT:目标对象
*/
export function gs_PTopicObjectiveRela_CopyObjTo(objgs_PTopicObjectiveRelaENS: clsgs_PTopicObjectiveRelaEN , objgs_PTopicObjectiveRelaENT: clsgs_PTopicObjectiveRelaEN ): void 
{
objgs_PTopicObjectiveRelaENT.mId = objgs_PTopicObjectiveRelaENS.mId; //mId
objgs_PTopicObjectiveRelaENT.paperId = objgs_PTopicObjectiveRelaENS.paperId; //论文Id
objgs_PTopicObjectiveRelaENT.sectionId = objgs_PTopicObjectiveRelaENS.sectionId; //节Id
objgs_PTopicObjectiveRelaENT.topicObjectiveId = objgs_PTopicObjectiveRelaENS.topicObjectiveId; //客观Id
objgs_PTopicObjectiveRelaENT.updDate = objgs_PTopicObjectiveRelaENS.updDate; //修改日期
objgs_PTopicObjectiveRelaENT.updUser = objgs_PTopicObjectiveRelaENS.updUser; //修改人
objgs_PTopicObjectiveRelaENT.memo = objgs_PTopicObjectiveRelaENS.memo; //备注
objgs_PTopicObjectiveRelaENT.sfUpdFldSetStr = objgs_PTopicObjectiveRelaENS.updFldString; //sfUpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objgs_PTopicObjectiveRelaENS:源对象
 * @param objgs_PTopicObjectiveRelaENT:目标对象
*/
export function gs_PTopicObjectiveRela_GetObjFromJsonObj(objgs_PTopicObjectiveRelaENS: clsgs_PTopicObjectiveRelaEN): clsgs_PTopicObjectiveRelaEN 
{
 const objgs_PTopicObjectiveRelaENT: clsgs_PTopicObjectiveRelaEN = new clsgs_PTopicObjectiveRelaEN();
ObjectAssign(objgs_PTopicObjectiveRelaENT, objgs_PTopicObjectiveRelaENS);
 return objgs_PTopicObjectiveRelaENT;
}