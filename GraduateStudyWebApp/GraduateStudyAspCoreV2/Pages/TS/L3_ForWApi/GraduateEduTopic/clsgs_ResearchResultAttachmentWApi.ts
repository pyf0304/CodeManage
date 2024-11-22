
 /**
 * 类名:clsgs_ResearchResultAttachmentWApi
 * 表名:gs_ResearchResultAttachment(01120779)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:48:28
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
 * 研究成果附件表(gs_ResearchResultAttachment)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2023年03月13日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { enumComparisonOp } from "../../PubFun/enumComparisonOp.js";
import { clsgs_ResearchResultAttachmentEN } from "../../L0_Entity/GraduateEduTopic/clsgs_ResearchResultAttachmentEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { tzDataType } from "../../PubFun/clsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const gs_ResearchResultAttachment_Controller = "gs_ResearchResultAttachmentApi";
 export const gs_ResearchResultAttachment_ConstructorName = "gs_ResearchResultAttachment";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngmId:关键字
 * @returns 对象
 **/
export async function gs_ResearchResultAttachment_GetObjBymIdAsync(lngmId: number): Promise<clsgs_ResearchResultAttachmentEN|null>  
{
const strThisFuncName = "GetObjBymIdAsync";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In clsgs_ResearchResultAttachmentWApi.GetObjBymIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjBymId";
const strUrl = GetWebApiUrl(gs_ResearchResultAttachment_Controller, strAction);
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
const objgs_ResearchResultAttachment = gs_ResearchResultAttachment_GetObjFromJsonObj(returnObj);
return objgs_ResearchResultAttachment;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
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
export function gs_ResearchResultAttachment_SortFun_Defa(a:clsgs_ResearchResultAttachmentEN , b:clsgs_ResearchResultAttachmentEN): number 
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
export function gs_ResearchResultAttachment_SortFun_Defa_2Fld(a:clsgs_ResearchResultAttachmentEN , b:clsgs_ResearchResultAttachmentEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.resultId == b.resultId) return a.topicId.localeCompare(b.topicId);
else return a.resultId.localeCompare(b.resultId);
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
export function gs_ResearchResultAttachment_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsgs_ResearchResultAttachmentEN.con_mId:
return (a: clsgs_ResearchResultAttachmentEN, b: clsgs_ResearchResultAttachmentEN) => {
return a.mId-b.mId;
}
case clsgs_ResearchResultAttachmentEN.con_ResultId:
return (a: clsgs_ResearchResultAttachmentEN, b: clsgs_ResearchResultAttachmentEN) => {
return a.resultId.localeCompare(b.resultId);
}
case clsgs_ResearchResultAttachmentEN.con_TopicId:
return (a: clsgs_ResearchResultAttachmentEN, b: clsgs_ResearchResultAttachmentEN) => {
if (a.topicId == null) return -1;
if (b.topicId == null) return 1;
return a.topicId.localeCompare(b.topicId);
}
case clsgs_ResearchResultAttachmentEN.con_FileName:
return (a: clsgs_ResearchResultAttachmentEN, b: clsgs_ResearchResultAttachmentEN) => {
if (a.fileName == null) return -1;
if (b.fileName == null) return 1;
return a.fileName.localeCompare(b.fileName);
}
case clsgs_ResearchResultAttachmentEN.con_FilePath:
return (a: clsgs_ResearchResultAttachmentEN, b: clsgs_ResearchResultAttachmentEN) => {
if (a.filePath == null) return -1;
if (b.filePath == null) return 1;
return a.filePath.localeCompare(b.filePath);
}
case clsgs_ResearchResultAttachmentEN.con_UpdDate:
return (a: clsgs_ResearchResultAttachmentEN, b: clsgs_ResearchResultAttachmentEN) => {
if (a.updDate == null) return -1;
if (b.updDate == null) return 1;
return a.updDate.localeCompare(b.updDate);
}
case clsgs_ResearchResultAttachmentEN.con_UpdUser:
return (a: clsgs_ResearchResultAttachmentEN, b: clsgs_ResearchResultAttachmentEN) => {
if (a.updUser == null) return -1;
if (b.updUser == null) return 1;
return a.updUser.localeCompare(b.updUser);
}
case clsgs_ResearchResultAttachmentEN.con_Memo:
return (a: clsgs_ResearchResultAttachmentEN, b: clsgs_ResearchResultAttachmentEN) => {
if (a.memo == null) return -1;
if (b.memo == null) return 1;
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_ResearchResultAttachment]中不存在！(in ${ gs_ResearchResultAttachment_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsgs_ResearchResultAttachmentEN.con_mId:
return (a: clsgs_ResearchResultAttachmentEN, b: clsgs_ResearchResultAttachmentEN) => {
return b.mId-a.mId;
}
case clsgs_ResearchResultAttachmentEN.con_ResultId:
return (a: clsgs_ResearchResultAttachmentEN, b: clsgs_ResearchResultAttachmentEN) => {
return b.resultId.localeCompare(a.resultId);
}
case clsgs_ResearchResultAttachmentEN.con_TopicId:
return (a: clsgs_ResearchResultAttachmentEN, b: clsgs_ResearchResultAttachmentEN) => {
if (b.topicId == null) return -1;
if (a.topicId == null) return 1;
return b.topicId.localeCompare(a.topicId);
}
case clsgs_ResearchResultAttachmentEN.con_FileName:
return (a: clsgs_ResearchResultAttachmentEN, b: clsgs_ResearchResultAttachmentEN) => {
if (b.fileName == null) return -1;
if (a.fileName == null) return 1;
return b.fileName.localeCompare(a.fileName);
}
case clsgs_ResearchResultAttachmentEN.con_FilePath:
return (a: clsgs_ResearchResultAttachmentEN, b: clsgs_ResearchResultAttachmentEN) => {
if (b.filePath == null) return -1;
if (a.filePath == null) return 1;
return b.filePath.localeCompare(a.filePath);
}
case clsgs_ResearchResultAttachmentEN.con_UpdDate:
return (a: clsgs_ResearchResultAttachmentEN, b: clsgs_ResearchResultAttachmentEN) => {
if (b.updDate == null) return -1;
if (a.updDate == null) return 1;
return b.updDate.localeCompare(a.updDate);
}
case clsgs_ResearchResultAttachmentEN.con_UpdUser:
return (a: clsgs_ResearchResultAttachmentEN, b: clsgs_ResearchResultAttachmentEN) => {
if (b.updUser == null) return -1;
if (a.updUser == null) return 1;
return b.updUser.localeCompare(a.updUser);
}
case clsgs_ResearchResultAttachmentEN.con_Memo:
return (a: clsgs_ResearchResultAttachmentEN, b: clsgs_ResearchResultAttachmentEN) => {
if (b.memo == null) return -1;
if (a.memo == null) return 1;
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_ResearchResultAttachment]中不存在！(in ${ gs_ResearchResultAttachment_ConstructorName}.${ strThisFuncName})`;
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
export async function gs_ResearchResultAttachment_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsgs_ResearchResultAttachmentEN.con_mId:
return (obj: clsgs_ResearchResultAttachmentEN) => {
return obj.mId === value;
}
case clsgs_ResearchResultAttachmentEN.con_ResultId:
return (obj: clsgs_ResearchResultAttachmentEN) => {
return obj.resultId === value;
}
case clsgs_ResearchResultAttachmentEN.con_TopicId:
return (obj: clsgs_ResearchResultAttachmentEN) => {
return obj.topicId === value;
}
case clsgs_ResearchResultAttachmentEN.con_FileName:
return (obj: clsgs_ResearchResultAttachmentEN) => {
return obj.fileName === value;
}
case clsgs_ResearchResultAttachmentEN.con_FilePath:
return (obj: clsgs_ResearchResultAttachmentEN) => {
return obj.filePath === value;
}
case clsgs_ResearchResultAttachmentEN.con_UpdDate:
return (obj: clsgs_ResearchResultAttachmentEN) => {
return obj.updDate === value;
}
case clsgs_ResearchResultAttachmentEN.con_UpdUser:
return (obj: clsgs_ResearchResultAttachmentEN) => {
return obj.updUser === value;
}
case clsgs_ResearchResultAttachmentEN.con_Memo:
return (obj: clsgs_ResearchResultAttachmentEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_ResearchResultAttachment]中不存在！(in ${ gs_ResearchResultAttachment_ConstructorName}.${ strThisFuncName})`;
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
export async function gs_ResearchResultAttachment_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(gs_ResearchResultAttachment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
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
export async function gs_ResearchResultAttachment_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(gs_ResearchResultAttachment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
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
export async function gs_ResearchResultAttachment_GetFirstObjAsync(strWhereCond: string): Promise<clsgs_ResearchResultAttachmentEN|null>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(gs_ResearchResultAttachment_Controller, strAction);
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
const objgs_ResearchResultAttachment = gs_ResearchResultAttachment_GetObjFromJsonObj(returnObj);
return objgs_ResearchResultAttachment;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
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
export async function gs_ResearchResultAttachment_GetObjLstAsync(strWhereCond: string): Promise<Array<clsgs_ResearchResultAttachmentEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(gs_ResearchResultAttachment_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_ResearchResultAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
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
export async function gs_ResearchResultAttachment_GetObjLstBymIdLstAsync(arrmId: Array<string>): Promise<Array<clsgs_ResearchResultAttachmentEN>>  
{
const strThisFuncName = "GetObjLstBymIdLstAsync";
const strAction = "GetObjLstBymIdLst";
const strUrl = GetWebApiUrl(gs_ResearchResultAttachment_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrmId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_ResearchResultAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
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
export async function gs_ResearchResultAttachment_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsgs_ResearchResultAttachmentEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(gs_ResearchResultAttachment_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_ResearchResultAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
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
export async function gs_ResearchResultAttachment_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsgs_ResearchResultAttachmentEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(gs_ResearchResultAttachment_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_ResearchResultAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
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
export async function gs_ResearchResultAttachment_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(gs_ResearchResultAttachment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
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
export async function gs_ResearchResultAttachment_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsgs_ResearchResultAttachmentEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
if (objPagerPara.pageIndex == 0) return new Array<clsgs_ResearchResultAttachmentEN>();
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(gs_ResearchResultAttachment_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_ResearchResultAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
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
export async function gs_ResearchResultAttachment_DelRecordAsync(lngmId: number): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(gs_ResearchResultAttachment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
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
export async function gs_ResearchResultAttachment_Delgs_ResearchResultAttachmentsAsync(arrmId: Array<string>): Promise<number> 
{
const strThisFuncName = "Delgs_ResearchResultAttachmentsAsync";
const strAction = "Delgs_ResearchResultAttachments";
const strUrl = GetWebApiUrl(gs_ResearchResultAttachment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
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
export async function gs_ResearchResultAttachment_Delgs_ResearchResultAttachmentsByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "Delgs_ResearchResultAttachmentsByCondAsync";
const strAction = "Delgs_ResearchResultAttachmentsByCond";
const strUrl = GetWebApiUrl(gs_ResearchResultAttachment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
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
 * @param objgs_ResearchResultAttachmentEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_ResearchResultAttachment_AddNewRecordAsync(objgs_ResearchResultAttachmentEN: clsgs_ResearchResultAttachmentEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objgs_ResearchResultAttachmentEN);
const strUrl = GetWebApiUrl(gs_ResearchResultAttachment_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_ResearchResultAttachmentEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
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
 * @param objgs_ResearchResultAttachmentEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function gs_ResearchResultAttachment_AddNewRecordWithReturnKeyAsync(objgs_ResearchResultAttachmentEN: clsgs_ResearchResultAttachmentEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(gs_ResearchResultAttachment_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_ResearchResultAttachmentEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
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
 * @param objgs_ResearchResultAttachmentEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function gs_ResearchResultAttachment_AddNewRecordWithReturnKey(objgs_ResearchResultAttachmentEN: clsgs_ResearchResultAttachmentEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objgs_ResearchResultAttachmentEN.mId === null || objgs_ResearchResultAttachmentEN.mId === 0)
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(gs_ResearchResultAttachment_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_ResearchResultAttachmentEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
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
 * @param objgs_ResearchResultAttachmentEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function gs_ResearchResultAttachment_UpdateRecordAsync(objgs_ResearchResultAttachmentEN: clsgs_ResearchResultAttachmentEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objgs_ResearchResultAttachmentEN.sfUpdFldSetStr === undefined || objgs_ResearchResultAttachmentEN.sfUpdFldSetStr === null || objgs_ResearchResultAttachmentEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_ResearchResultAttachmentEN.mId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(gs_ResearchResultAttachment_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_ResearchResultAttachmentEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
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
 * @param objgs_ResearchResultAttachmentEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function gs_ResearchResultAttachment_UpdateWithConditionAsync(objgs_ResearchResultAttachmentEN: clsgs_ResearchResultAttachmentEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objgs_ResearchResultAttachmentEN.sfUpdFldSetStr === undefined || objgs_ResearchResultAttachmentEN.sfUpdFldSetStr === null || objgs_ResearchResultAttachmentEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_ResearchResultAttachmentEN.mId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(gs_ResearchResultAttachment_Controller, strAction);
objgs_ResearchResultAttachmentEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objgs_ResearchResultAttachmentEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
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
export async function gs_ResearchResultAttachment_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(gs_ResearchResultAttachment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
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
export async function gs_ResearchResultAttachment_IsExist(lngmId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(gs_ResearchResultAttachment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
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
export async function gs_ResearchResultAttachment_IsExistAsync(lngmId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(gs_ResearchResultAttachment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
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
export async function gs_ResearchResultAttachment_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(gs_ResearchResultAttachment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
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
export async function gs_ResearchResultAttachment_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(gs_ResearchResultAttachment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
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
export function gs_ResearchResultAttachment_GetWebApiUrl(strController: string, strAction: string): string {
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
export function gs_ResearchResultAttachment_CheckPropertyNew(pobjgs_ResearchResultAttachmentEN: clsgs_ResearchResultAttachmentEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjgs_ResearchResultAttachmentEN.resultId) === true )
{
 throw new Error("(errid:Watl000058)字段[成果Id]不能为空(In 研究成果附件表)!(clsgs_ResearchResultAttachmentBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjgs_ResearchResultAttachmentEN.resultId) == false && GetStrLen(pobjgs_ResearchResultAttachmentEN.resultId) > 10)
{
 throw new Error("(errid:Watl000059)字段[成果Id(resultId)]的长度不能超过10(In 研究成果附件表(gs_ResearchResultAttachment))!值:$(pobjgs_ResearchResultAttachmentEN.resultId)(clsgs_ResearchResultAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultAttachmentEN.topicId) == false && GetStrLen(pobjgs_ResearchResultAttachmentEN.topicId) > 8)
{
 throw new Error("(errid:Watl000059)字段[主题Id(topicId)]的长度不能超过8(In 研究成果附件表(gs_ResearchResultAttachment))!值:$(pobjgs_ResearchResultAttachmentEN.topicId)(clsgs_ResearchResultAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultAttachmentEN.fileName) == false && GetStrLen(pobjgs_ResearchResultAttachmentEN.fileName) > 500)
{
 throw new Error("(errid:Watl000059)字段[文件名称(fileName)]的长度不能超过500(In 研究成果附件表(gs_ResearchResultAttachment))!值:$(pobjgs_ResearchResultAttachmentEN.fileName)(clsgs_ResearchResultAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultAttachmentEN.filePath) == false && GetStrLen(pobjgs_ResearchResultAttachmentEN.filePath) > 500)
{
 throw new Error("(errid:Watl000059)字段[文件路径(filePath)]的长度不能超过500(In 研究成果附件表(gs_ResearchResultAttachment))!值:$(pobjgs_ResearchResultAttachmentEN.filePath)(clsgs_ResearchResultAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultAttachmentEN.updDate) == false && GetStrLen(pobjgs_ResearchResultAttachmentEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 研究成果附件表(gs_ResearchResultAttachment))!值:$(pobjgs_ResearchResultAttachmentEN.updDate)(clsgs_ResearchResultAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultAttachmentEN.updUser) == false && GetStrLen(pobjgs_ResearchResultAttachmentEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 研究成果附件表(gs_ResearchResultAttachment))!值:$(pobjgs_ResearchResultAttachmentEN.updUser)(clsgs_ResearchResultAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultAttachmentEN.memo) == false && GetStrLen(pobjgs_ResearchResultAttachmentEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 研究成果附件表(gs_ResearchResultAttachment))!值:$(pobjgs_ResearchResultAttachmentEN.memo)(clsgs_ResearchResultAttachmentBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null != pobjgs_ResearchResultAttachmentEN.mId && undefined !== pobjgs_ResearchResultAttachmentEN.mId && tzDataType.isNumber(pobjgs_ResearchResultAttachmentEN.mId) === false)
{
 throw new Error("(errid:Watl000060)字段[mId(mId)]的值:[$(pobjgs_ResearchResultAttachmentEN.mId)], 非法，应该为数值型(In 研究成果附件表(gs_ResearchResultAttachment))!(clsgs_ResearchResultAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultAttachmentEN.resultId) == false && undefined !== pobjgs_ResearchResultAttachmentEN.resultId && tzDataType.isString(pobjgs_ResearchResultAttachmentEN.resultId) === false)
{
 throw new Error("(errid:Watl000060)字段[成果Id(resultId)]的值:[$(pobjgs_ResearchResultAttachmentEN.resultId)], 非法，应该为字符型(In 研究成果附件表(gs_ResearchResultAttachment))!(clsgs_ResearchResultAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultAttachmentEN.topicId) == false && undefined !== pobjgs_ResearchResultAttachmentEN.topicId && tzDataType.isString(pobjgs_ResearchResultAttachmentEN.topicId) === false)
{
 throw new Error("(errid:Watl000060)字段[主题Id(topicId)]的值:[$(pobjgs_ResearchResultAttachmentEN.topicId)], 非法，应该为字符型(In 研究成果附件表(gs_ResearchResultAttachment))!(clsgs_ResearchResultAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultAttachmentEN.fileName) == false && undefined !== pobjgs_ResearchResultAttachmentEN.fileName && tzDataType.isString(pobjgs_ResearchResultAttachmentEN.fileName) === false)
{
 throw new Error("(errid:Watl000060)字段[文件名称(fileName)]的值:[$(pobjgs_ResearchResultAttachmentEN.fileName)], 非法，应该为字符型(In 研究成果附件表(gs_ResearchResultAttachment))!(clsgs_ResearchResultAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultAttachmentEN.filePath) == false && undefined !== pobjgs_ResearchResultAttachmentEN.filePath && tzDataType.isString(pobjgs_ResearchResultAttachmentEN.filePath) === false)
{
 throw new Error("(errid:Watl000060)字段[文件路径(filePath)]的值:[$(pobjgs_ResearchResultAttachmentEN.filePath)], 非法，应该为字符型(In 研究成果附件表(gs_ResearchResultAttachment))!(clsgs_ResearchResultAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultAttachmentEN.updDate) == false && undefined !== pobjgs_ResearchResultAttachmentEN.updDate && tzDataType.isString(pobjgs_ResearchResultAttachmentEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjgs_ResearchResultAttachmentEN.updDate)], 非法，应该为字符型(In 研究成果附件表(gs_ResearchResultAttachment))!(clsgs_ResearchResultAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultAttachmentEN.updUser) == false && undefined !== pobjgs_ResearchResultAttachmentEN.updUser && tzDataType.isString(pobjgs_ResearchResultAttachmentEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjgs_ResearchResultAttachmentEN.updUser)], 非法，应该为字符型(In 研究成果附件表(gs_ResearchResultAttachment))!(clsgs_ResearchResultAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultAttachmentEN.memo) == false && undefined !== pobjgs_ResearchResultAttachmentEN.memo && tzDataType.isString(pobjgs_ResearchResultAttachmentEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjgs_ResearchResultAttachmentEN.memo)], 非法，应该为字符型(In 研究成果附件表(gs_ResearchResultAttachment))!(clsgs_ResearchResultAttachmentBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjgs_ResearchResultAttachmentEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function gs_ResearchResultAttachment_CheckProperty4Update (pobjgs_ResearchResultAttachmentEN: clsgs_ResearchResultAttachmentEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjgs_ResearchResultAttachmentEN.resultId) == false && GetStrLen(pobjgs_ResearchResultAttachmentEN.resultId) > 10)
{
 throw new Error("(errid:Watl000062)字段[成果Id(resultId)]的长度不能超过10(In 研究成果附件表(gs_ResearchResultAttachment))!值:$(pobjgs_ResearchResultAttachmentEN.resultId)(clsgs_ResearchResultAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultAttachmentEN.topicId) == false && GetStrLen(pobjgs_ResearchResultAttachmentEN.topicId) > 8)
{
 throw new Error("(errid:Watl000062)字段[主题Id(topicId)]的长度不能超过8(In 研究成果附件表(gs_ResearchResultAttachment))!值:$(pobjgs_ResearchResultAttachmentEN.topicId)(clsgs_ResearchResultAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultAttachmentEN.fileName) == false && GetStrLen(pobjgs_ResearchResultAttachmentEN.fileName) > 500)
{
 throw new Error("(errid:Watl000062)字段[文件名称(fileName)]的长度不能超过500(In 研究成果附件表(gs_ResearchResultAttachment))!值:$(pobjgs_ResearchResultAttachmentEN.fileName)(clsgs_ResearchResultAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultAttachmentEN.filePath) == false && GetStrLen(pobjgs_ResearchResultAttachmentEN.filePath) > 500)
{
 throw new Error("(errid:Watl000062)字段[文件路径(filePath)]的长度不能超过500(In 研究成果附件表(gs_ResearchResultAttachment))!值:$(pobjgs_ResearchResultAttachmentEN.filePath)(clsgs_ResearchResultAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultAttachmentEN.updDate) == false && GetStrLen(pobjgs_ResearchResultAttachmentEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 研究成果附件表(gs_ResearchResultAttachment))!值:$(pobjgs_ResearchResultAttachmentEN.updDate)(clsgs_ResearchResultAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultAttachmentEN.updUser) == false && GetStrLen(pobjgs_ResearchResultAttachmentEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 研究成果附件表(gs_ResearchResultAttachment))!值:$(pobjgs_ResearchResultAttachmentEN.updUser)(clsgs_ResearchResultAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultAttachmentEN.memo) == false && GetStrLen(pobjgs_ResearchResultAttachmentEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 研究成果附件表(gs_ResearchResultAttachment))!值:$(pobjgs_ResearchResultAttachmentEN.memo)(clsgs_ResearchResultAttachmentBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null != pobjgs_ResearchResultAttachmentEN.mId && undefined !== pobjgs_ResearchResultAttachmentEN.mId && tzDataType.isNumber(pobjgs_ResearchResultAttachmentEN.mId) === false)
{
 throw new Error("(errid:Watl000063)字段[mId(mId)]的值:[$(pobjgs_ResearchResultAttachmentEN.mId)], 非法，应该为数值型(In 研究成果附件表(gs_ResearchResultAttachment))!(clsgs_ResearchResultAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultAttachmentEN.resultId) == false && undefined !== pobjgs_ResearchResultAttachmentEN.resultId && tzDataType.isString(pobjgs_ResearchResultAttachmentEN.resultId) === false)
{
 throw new Error("(errid:Watl000063)字段[成果Id(resultId)]的值:[$(pobjgs_ResearchResultAttachmentEN.resultId)], 非法，应该为字符型(In 研究成果附件表(gs_ResearchResultAttachment))!(clsgs_ResearchResultAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultAttachmentEN.topicId) == false && undefined !== pobjgs_ResearchResultAttachmentEN.topicId && tzDataType.isString(pobjgs_ResearchResultAttachmentEN.topicId) === false)
{
 throw new Error("(errid:Watl000063)字段[主题Id(topicId)]的值:[$(pobjgs_ResearchResultAttachmentEN.topicId)], 非法，应该为字符型(In 研究成果附件表(gs_ResearchResultAttachment))!(clsgs_ResearchResultAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultAttachmentEN.fileName) == false && undefined !== pobjgs_ResearchResultAttachmentEN.fileName && tzDataType.isString(pobjgs_ResearchResultAttachmentEN.fileName) === false)
{
 throw new Error("(errid:Watl000063)字段[文件名称(fileName)]的值:[$(pobjgs_ResearchResultAttachmentEN.fileName)], 非法，应该为字符型(In 研究成果附件表(gs_ResearchResultAttachment))!(clsgs_ResearchResultAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultAttachmentEN.filePath) == false && undefined !== pobjgs_ResearchResultAttachmentEN.filePath && tzDataType.isString(pobjgs_ResearchResultAttachmentEN.filePath) === false)
{
 throw new Error("(errid:Watl000063)字段[文件路径(filePath)]的值:[$(pobjgs_ResearchResultAttachmentEN.filePath)], 非法，应该为字符型(In 研究成果附件表(gs_ResearchResultAttachment))!(clsgs_ResearchResultAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultAttachmentEN.updDate) == false && undefined !== pobjgs_ResearchResultAttachmentEN.updDate && tzDataType.isString(pobjgs_ResearchResultAttachmentEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjgs_ResearchResultAttachmentEN.updDate)], 非法，应该为字符型(In 研究成果附件表(gs_ResearchResultAttachment))!(clsgs_ResearchResultAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultAttachmentEN.updUser) == false && undefined !== pobjgs_ResearchResultAttachmentEN.updUser && tzDataType.isString(pobjgs_ResearchResultAttachmentEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjgs_ResearchResultAttachmentEN.updUser)], 非法，应该为字符型(In 研究成果附件表(gs_ResearchResultAttachment))!(clsgs_ResearchResultAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ResearchResultAttachmentEN.memo) == false && undefined !== pobjgs_ResearchResultAttachmentEN.memo && tzDataType.isString(pobjgs_ResearchResultAttachmentEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjgs_ResearchResultAttachmentEN.memo)], 非法，应该为字符型(In 研究成果附件表(gs_ResearchResultAttachment))!(clsgs_ResearchResultAttachmentBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjgs_ResearchResultAttachmentEN.mId 
 || pobjgs_ResearchResultAttachmentEN.mId != null && pobjgs_ResearchResultAttachmentEN.mId.toString()  ===  "")
{
 throw new Error("(errid:Watl000064)字段[mId]不能为空(In 研究成果附件表)!(clsgs_ResearchResultAttachmentBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjgs_ResearchResultAttachmentEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function gs_ResearchResultAttachment_GetJSONStrByObj (pobjgs_ResearchResultAttachmentEN: clsgs_ResearchResultAttachmentEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjgs_ResearchResultAttachmentEN.sfUpdFldSetStr = pobjgs_ResearchResultAttachmentEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjgs_ResearchResultAttachmentEN);
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
export function gs_ResearchResultAttachment_GetObjLstByJSONStr (strJSON: string): Array<clsgs_ResearchResultAttachmentEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrgs_ResearchResultAttachmentObjLst = new Array<clsgs_ResearchResultAttachmentEN>();
if (strJSON === "")
{
return arrgs_ResearchResultAttachmentObjLst;
}
try
{
arrgs_ResearchResultAttachmentObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrgs_ResearchResultAttachmentObjLst;
}
return arrgs_ResearchResultAttachmentObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrgs_ResearchResultAttachmentObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function gs_ResearchResultAttachment_GetObjLstByJSONObjLst (arrgs_ResearchResultAttachmentObjLstS: Array<clsgs_ResearchResultAttachmentEN>): Array<clsgs_ResearchResultAttachmentEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrgs_ResearchResultAttachmentObjLst = new Array<clsgs_ResearchResultAttachmentEN>();
for (const objInFor of arrgs_ResearchResultAttachmentObjLstS) {
const obj1 = gs_ResearchResultAttachment_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrgs_ResearchResultAttachmentObjLst.push(obj1);
}
return arrgs_ResearchResultAttachmentObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function gs_ResearchResultAttachment_GetObjByJSONStr (strJSON: string): clsgs_ResearchResultAttachmentEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjgs_ResearchResultAttachmentEN = new clsgs_ResearchResultAttachmentEN();
if (strJSON === "")
{
return pobjgs_ResearchResultAttachmentEN;
}
try
{
pobjgs_ResearchResultAttachmentEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjgs_ResearchResultAttachmentEN;
}
return pobjgs_ResearchResultAttachmentEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function gs_ResearchResultAttachment_GetCombineCondition(objgs_ResearchResultAttachment_Cond: clsgs_ResearchResultAttachmentEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objgs_ResearchResultAttachment_Cond.dicFldComparisonOp, clsgs_ResearchResultAttachmentEN.con_mId) == true)
{
const strComparisonOp_mId:string = objgs_ResearchResultAttachment_Cond.dicFldComparisonOp[clsgs_ResearchResultAttachmentEN.con_mId];
strWhereCond += Format(" And {0} {2} {1}", clsgs_ResearchResultAttachmentEN.con_mId, objgs_ResearchResultAttachment_Cond.mId, strComparisonOp_mId);
}
if (Object.prototype.hasOwnProperty.call(objgs_ResearchResultAttachment_Cond.dicFldComparisonOp, clsgs_ResearchResultAttachmentEN.con_ResultId) == true)
{
const strComparisonOp_ResultId:string = objgs_ResearchResultAttachment_Cond.dicFldComparisonOp[clsgs_ResearchResultAttachmentEN.con_ResultId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_ResearchResultAttachmentEN.con_ResultId, objgs_ResearchResultAttachment_Cond.resultId, strComparisonOp_ResultId);
}
if (Object.prototype.hasOwnProperty.call(objgs_ResearchResultAttachment_Cond.dicFldComparisonOp, clsgs_ResearchResultAttachmentEN.con_TopicId) == true)
{
const strComparisonOp_TopicId:string = objgs_ResearchResultAttachment_Cond.dicFldComparisonOp[clsgs_ResearchResultAttachmentEN.con_TopicId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_ResearchResultAttachmentEN.con_TopicId, objgs_ResearchResultAttachment_Cond.topicId, strComparisonOp_TopicId);
}
if (Object.prototype.hasOwnProperty.call(objgs_ResearchResultAttachment_Cond.dicFldComparisonOp, clsgs_ResearchResultAttachmentEN.con_FileName) == true)
{
const strComparisonOp_FileName:string = objgs_ResearchResultAttachment_Cond.dicFldComparisonOp[clsgs_ResearchResultAttachmentEN.con_FileName];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_ResearchResultAttachmentEN.con_FileName, objgs_ResearchResultAttachment_Cond.fileName, strComparisonOp_FileName);
}
if (Object.prototype.hasOwnProperty.call(objgs_ResearchResultAttachment_Cond.dicFldComparisonOp, clsgs_ResearchResultAttachmentEN.con_FilePath) == true)
{
const strComparisonOp_FilePath:string = objgs_ResearchResultAttachment_Cond.dicFldComparisonOp[clsgs_ResearchResultAttachmentEN.con_FilePath];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_ResearchResultAttachmentEN.con_FilePath, objgs_ResearchResultAttachment_Cond.filePath, strComparisonOp_FilePath);
}
if (Object.prototype.hasOwnProperty.call(objgs_ResearchResultAttachment_Cond.dicFldComparisonOp, clsgs_ResearchResultAttachmentEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objgs_ResearchResultAttachment_Cond.dicFldComparisonOp[clsgs_ResearchResultAttachmentEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_ResearchResultAttachmentEN.con_UpdDate, objgs_ResearchResultAttachment_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objgs_ResearchResultAttachment_Cond.dicFldComparisonOp, clsgs_ResearchResultAttachmentEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objgs_ResearchResultAttachment_Cond.dicFldComparisonOp[clsgs_ResearchResultAttachmentEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_ResearchResultAttachmentEN.con_UpdUser, objgs_ResearchResultAttachment_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objgs_ResearchResultAttachment_Cond.dicFldComparisonOp, clsgs_ResearchResultAttachmentEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objgs_ResearchResultAttachment_Cond.dicFldComparisonOp[clsgs_ResearchResultAttachmentEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_ResearchResultAttachmentEN.con_Memo, objgs_ResearchResultAttachment_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--gs_ResearchResultAttachment(研究成果附件表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param lngmId: mId(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function gs_ResearchResultAttachment_GetUniCondStr_mId(objgs_ResearchResultAttachmentEN: clsgs_ResearchResultAttachmentEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and mId = '{0}'", objgs_ResearchResultAttachmentEN.mId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--gs_ResearchResultAttachment(研究成果附件表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param lngmId: mId(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function gs_ResearchResultAttachment_GetUniCondStr4Update_mId(objgs_ResearchResultAttachmentEN: clsgs_ResearchResultAttachmentEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and mId <> '{0}'", objgs_ResearchResultAttachmentEN.mId);
 strWhereCond +=  Format(" and mId = '{0}'", objgs_ResearchResultAttachmentEN.mId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objgs_ResearchResultAttachmentENS:源对象
 * @param objgs_ResearchResultAttachmentENT:目标对象
*/
export function gs_ResearchResultAttachment_CopyObjTo(objgs_ResearchResultAttachmentENS: clsgs_ResearchResultAttachmentEN , objgs_ResearchResultAttachmentENT: clsgs_ResearchResultAttachmentEN ): void 
{
objgs_ResearchResultAttachmentENT.mId = objgs_ResearchResultAttachmentENS.mId; //mId
objgs_ResearchResultAttachmentENT.resultId = objgs_ResearchResultAttachmentENS.resultId; //成果Id
objgs_ResearchResultAttachmentENT.topicId = objgs_ResearchResultAttachmentENS.topicId; //主题Id
objgs_ResearchResultAttachmentENT.fileName = objgs_ResearchResultAttachmentENS.fileName; //文件名称
objgs_ResearchResultAttachmentENT.filePath = objgs_ResearchResultAttachmentENS.filePath; //文件路径
objgs_ResearchResultAttachmentENT.updDate = objgs_ResearchResultAttachmentENS.updDate; //修改日期
objgs_ResearchResultAttachmentENT.updUser = objgs_ResearchResultAttachmentENS.updUser; //修改人
objgs_ResearchResultAttachmentENT.memo = objgs_ResearchResultAttachmentENS.memo; //备注
objgs_ResearchResultAttachmentENT.sfUpdFldSetStr = objgs_ResearchResultAttachmentENS.updFldString; //sfUpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objgs_ResearchResultAttachmentENS:源对象
 * @param objgs_ResearchResultAttachmentENT:目标对象
*/
export function gs_ResearchResultAttachment_GetObjFromJsonObj(objgs_ResearchResultAttachmentENS: clsgs_ResearchResultAttachmentEN): clsgs_ResearchResultAttachmentEN 
{
 const objgs_ResearchResultAttachmentENT: clsgs_ResearchResultAttachmentEN = new clsgs_ResearchResultAttachmentEN();
ObjectAssign(objgs_ResearchResultAttachmentENT, objgs_ResearchResultAttachmentENS);
 return objgs_ResearchResultAttachmentENT;
}