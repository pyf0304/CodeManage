
 /**
 * 类名:clsvPaperSubAttachmentWApi
 * 表名:vPaperSubAttachment(01120598)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:46:41
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
 * 子观点附件(vPaperSubAttachment)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { clsvPaperSubAttachmentEN } from "../../L0_Entity/GraduateEduPaper/clsvPaperSubAttachmentEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { tzDataType } from "../../PubFun/jsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const vPaperSubAttachment_Controller = "vPaperSubAttachmentApi";
 export const vPaperSubAttachment_ConstructorName = "vPaperSubAttachment";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngPaperSubAttachmentId:关键字
 * @returns 对象
 **/
export async function vPaperSubAttachment_GetObjByPaperSubAttachmentIdAsync(lngPaperSubAttachmentId: number): Promise<clsvPaperSubAttachmentEN>  
{
const strThisFuncName = "GetObjByPaperSubAttachmentIdAsync";

if (lngPaperSubAttachmentId == 0)
{
  const strMsg = Format("参数:[lngPaperSubAttachmentId]不能为空！(In GetObjByPaperSubAttachmentIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjByPaperSubAttachmentId";
const strUrl = GetWebApiUrl(vPaperSubAttachment_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"lngPaperSubAttachmentId": lngPaperSubAttachmentId,
}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObj = data.returnObj;
if (returnObj == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vPaperSubAttachment_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvPaperSubAttachment = vPaperSubAttachment_GetObjFromJsonObj(returnObj);
return objvPaperSubAttachment;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSubAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSubAttachment_ConstructorName, strThisFuncName);
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
export function vPaperSubAttachment_SortFun_Defa(a:clsvPaperSubAttachmentEN , b:clsvPaperSubAttachmentEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.paperSubAttachmentId-b.paperSubAttachmentId;
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
export function vPaperSubAttachment_SortFun_Defa_2Fld(a:clsvPaperSubAttachmentEN , b:clsvPaperSubAttachmentEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.explainContent == b.explainContent) return a.filePath.localeCompare(b.filePath);
else return a.explainContent.localeCompare(b.explainContent);
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
export function vPaperSubAttachment_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsvPaperSubAttachmentEN.con_ExplainContent:
return (a: clsvPaperSubAttachmentEN, b: clsvPaperSubAttachmentEN) => {
return a.explainContent.localeCompare(b.explainContent);
}
case clsvPaperSubAttachmentEN.con_FilePath:
return (a: clsvPaperSubAttachmentEN, b: clsvPaperSubAttachmentEN) => {
return a.filePath.localeCompare(b.filePath);
}
case clsvPaperSubAttachmentEN.con_Memo:
return (a: clsvPaperSubAttachmentEN, b: clsvPaperSubAttachmentEN) => {
return a.memo.localeCompare(b.memo);
}
case clsvPaperSubAttachmentEN.con_PaperRWId:
return (a: clsvPaperSubAttachmentEN, b: clsvPaperSubAttachmentEN) => {
return a.paperRWId.localeCompare(b.paperRWId);
}
case clsvPaperSubAttachmentEN.con_PaperSubAttachmentName:
return (a: clsvPaperSubAttachmentEN, b: clsvPaperSubAttachmentEN) => {
return a.paperSubAttachmentName.localeCompare(b.paperSubAttachmentName);
}
case clsvPaperSubAttachmentEN.con_RWTitle:
return (a: clsvPaperSubAttachmentEN, b: clsvPaperSubAttachmentEN) => {
return a.rwTitle.localeCompare(b.rwTitle);
}
case clsvPaperSubAttachmentEN.con_SubViewpointContent:
return (a: clsvPaperSubAttachmentEN, b: clsvPaperSubAttachmentEN) => {
return a.subViewpointContent.localeCompare(b.subViewpointContent);
}
case clsvPaperSubAttachmentEN.con_SubViewpointId:
return (a: clsvPaperSubAttachmentEN, b: clsvPaperSubAttachmentEN) => {
return a.subViewpointId-b.subViewpointId;
}
case clsvPaperSubAttachmentEN.con_UpdDate:
return (a: clsvPaperSubAttachmentEN, b: clsvPaperSubAttachmentEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsvPaperSubAttachmentEN.con_UpdUserId:
return (a: clsvPaperSubAttachmentEN, b: clsvPaperSubAttachmentEN) => {
return a.updUserId.localeCompare(b.updUserId);
}
case clsvPaperSubAttachmentEN.con_PaperSubAttachmentId:
return (a: clsvPaperSubAttachmentEN, b: clsvPaperSubAttachmentEN) => {
return a.paperSubAttachmentId-b.paperSubAttachmentId;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vPaperSubAttachment]中不存在！(in ${ vPaperSubAttachment_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsvPaperSubAttachmentEN.con_ExplainContent:
return (a: clsvPaperSubAttachmentEN, b: clsvPaperSubAttachmentEN) => {
return b.explainContent.localeCompare(a.explainContent);
}
case clsvPaperSubAttachmentEN.con_FilePath:
return (a: clsvPaperSubAttachmentEN, b: clsvPaperSubAttachmentEN) => {
return b.filePath.localeCompare(a.filePath);
}
case clsvPaperSubAttachmentEN.con_Memo:
return (a: clsvPaperSubAttachmentEN, b: clsvPaperSubAttachmentEN) => {
return b.memo.localeCompare(a.memo);
}
case clsvPaperSubAttachmentEN.con_PaperRWId:
return (a: clsvPaperSubAttachmentEN, b: clsvPaperSubAttachmentEN) => {
return b.paperRWId.localeCompare(a.paperRWId);
}
case clsvPaperSubAttachmentEN.con_PaperSubAttachmentName:
return (a: clsvPaperSubAttachmentEN, b: clsvPaperSubAttachmentEN) => {
return b.paperSubAttachmentName.localeCompare(a.paperSubAttachmentName);
}
case clsvPaperSubAttachmentEN.con_RWTitle:
return (a: clsvPaperSubAttachmentEN, b: clsvPaperSubAttachmentEN) => {
return b.rwTitle.localeCompare(a.rwTitle);
}
case clsvPaperSubAttachmentEN.con_SubViewpointContent:
return (a: clsvPaperSubAttachmentEN, b: clsvPaperSubAttachmentEN) => {
return b.subViewpointContent.localeCompare(a.subViewpointContent);
}
case clsvPaperSubAttachmentEN.con_SubViewpointId:
return (a: clsvPaperSubAttachmentEN, b: clsvPaperSubAttachmentEN) => {
return b.subViewpointId-a.subViewpointId;
}
case clsvPaperSubAttachmentEN.con_UpdDate:
return (a: clsvPaperSubAttachmentEN, b: clsvPaperSubAttachmentEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsvPaperSubAttachmentEN.con_UpdUserId:
return (a: clsvPaperSubAttachmentEN, b: clsvPaperSubAttachmentEN) => {
return b.updUserId.localeCompare(a.updUserId);
}
case clsvPaperSubAttachmentEN.con_PaperSubAttachmentId:
return (a: clsvPaperSubAttachmentEN, b: clsvPaperSubAttachmentEN) => {
return b.paperSubAttachmentId-a.paperSubAttachmentId;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vPaperSubAttachment]中不存在！(in ${ vPaperSubAttachment_ConstructorName}.${ strThisFuncName})`;
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
export async function vPaperSubAttachment_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsvPaperSubAttachmentEN.con_ExplainContent:
return (obj: clsvPaperSubAttachmentEN) => {
return obj.explainContent === value;
}
case clsvPaperSubAttachmentEN.con_FilePath:
return (obj: clsvPaperSubAttachmentEN) => {
return obj.filePath === value;
}
case clsvPaperSubAttachmentEN.con_Memo:
return (obj: clsvPaperSubAttachmentEN) => {
return obj.memo === value;
}
case clsvPaperSubAttachmentEN.con_PaperRWId:
return (obj: clsvPaperSubAttachmentEN) => {
return obj.paperRWId === value;
}
case clsvPaperSubAttachmentEN.con_PaperSubAttachmentName:
return (obj: clsvPaperSubAttachmentEN) => {
return obj.paperSubAttachmentName === value;
}
case clsvPaperSubAttachmentEN.con_RWTitle:
return (obj: clsvPaperSubAttachmentEN) => {
return obj.rwTitle === value;
}
case clsvPaperSubAttachmentEN.con_SubViewpointContent:
return (obj: clsvPaperSubAttachmentEN) => {
return obj.subViewpointContent === value;
}
case clsvPaperSubAttachmentEN.con_SubViewpointId:
return (obj: clsvPaperSubAttachmentEN) => {
return obj.subViewpointId === value;
}
case clsvPaperSubAttachmentEN.con_UpdDate:
return (obj: clsvPaperSubAttachmentEN) => {
return obj.updDate === value;
}
case clsvPaperSubAttachmentEN.con_UpdUserId:
return (obj: clsvPaperSubAttachmentEN) => {
return obj.updUserId === value;
}
case clsvPaperSubAttachmentEN.con_PaperSubAttachmentId:
return (obj: clsvPaperSubAttachmentEN) => {
return obj.paperSubAttachmentId === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vPaperSubAttachment]中不存在！(in ${ vPaperSubAttachment_ConstructorName}.${ strThisFuncName})`;
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
export async function vPaperSubAttachment_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vPaperSubAttachment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSubAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSubAttachment_ConstructorName, strThisFuncName);
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
export async function vPaperSubAttachment_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vPaperSubAttachment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSubAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSubAttachment_ConstructorName, strThisFuncName);
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
export async function vPaperSubAttachment_GetFirstObjAsync(strWhereCond: string): Promise<clsvPaperSubAttachmentEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(vPaperSubAttachment_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vPaperSubAttachment_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvPaperSubAttachment = vPaperSubAttachment_GetObjFromJsonObj(returnObj);
return objvPaperSubAttachment;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSubAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSubAttachment_ConstructorName, strThisFuncName);
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
export async function vPaperSubAttachment_GetObjLstAsync(strWhereCond: string): Promise<Array<clsvPaperSubAttachmentEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(vPaperSubAttachment_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vPaperSubAttachment_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vPaperSubAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSubAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSubAttachment_ConstructorName, strThisFuncName);
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
 * @param arrPaperSubAttachmentId:关键字列表
 * @returns 对象列表
 **/
export async function vPaperSubAttachment_GetObjLstByPaperSubAttachmentIdLstAsync(arrPaperSubAttachmentId: Array<string>): Promise<Array<clsvPaperSubAttachmentEN>>  
{
const strThisFuncName = "GetObjLstByPaperSubAttachmentIdLstAsync";
const strAction = "GetObjLstByPaperSubAttachmentIdLst";
const strUrl = GetWebApiUrl(vPaperSubAttachment_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrPaperSubAttachmentId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vPaperSubAttachment_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vPaperSubAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSubAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSubAttachment_ConstructorName, strThisFuncName);
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
export async function vPaperSubAttachment_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsvPaperSubAttachmentEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(vPaperSubAttachment_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vPaperSubAttachment_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vPaperSubAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSubAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSubAttachment_ConstructorName, strThisFuncName);
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
export async function vPaperSubAttachment_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsvPaperSubAttachmentEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vPaperSubAttachment_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vPaperSubAttachment_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vPaperSubAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSubAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSubAttachment_ConstructorName, strThisFuncName);
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
export async function vPaperSubAttachment_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vPaperSubAttachment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSubAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSubAttachment_ConstructorName, strThisFuncName);
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
export async function vPaperSubAttachment_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsvPaperSubAttachmentEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(vPaperSubAttachment_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vPaperSubAttachment_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vPaperSubAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSubAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSubAttachment_ConstructorName, strThisFuncName);
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
 * @param lngPaperSubAttachmentId:关键字
 * @returns 获取删除的结果
 **/
export async function vPaperSubAttachment_DelRecordAsync(lngPaperSubAttachmentId: number): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(vPaperSubAttachment_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, lngPaperSubAttachmentId);
try
{
const response = await axios.delete(strUrl,
{
params: { "Id": lngPaperSubAttachmentId, }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSubAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSubAttachment_ConstructorName, strThisFuncName);
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
 * @param arrPaperSubAttachmentId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function vPaperSubAttachment_DelvPaperSubAttachmentsAsync(arrPaperSubAttachmentId: Array<string>): Promise<number> 
{
const strThisFuncName = "DelvPaperSubAttachmentsAsync";
const strAction = "DelvPaperSubAttachments";
const strUrl = GetWebApiUrl(vPaperSubAttachment_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrPaperSubAttachmentId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSubAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSubAttachment_ConstructorName, strThisFuncName);
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
export async function vPaperSubAttachment_DelvPaperSubAttachmentsByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "DelvPaperSubAttachmentsByCondAsync";
const strAction = "DelvPaperSubAttachmentsByCond";
const strUrl = GetWebApiUrl(vPaperSubAttachment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSubAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSubAttachment_ConstructorName, strThisFuncName);
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
 * @param objvPaperSubAttachmentEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function vPaperSubAttachment_AddNewRecordAsync(objvPaperSubAttachmentEN: clsvPaperSubAttachmentEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objvPaperSubAttachmentEN);
const strUrl = GetWebApiUrl(vPaperSubAttachment_Controller, strAction);
try
{
const response = await axios.post(strUrl, objvPaperSubAttachmentEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSubAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSubAttachment_ConstructorName, strThisFuncName);
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
 * @param objvPaperSubAttachmentEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function vPaperSubAttachment_AddNewRecordWithReturnKeyAsync(objvPaperSubAttachmentEN: clsvPaperSubAttachmentEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(vPaperSubAttachment_Controller, strAction);
try
{
const response = await axios.post(strUrl, objvPaperSubAttachmentEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSubAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSubAttachment_ConstructorName, strThisFuncName);
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
 * @param objvPaperSubAttachmentEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function vPaperSubAttachment_AddNewRecordWithReturnKey(objvPaperSubAttachmentEN: clsvPaperSubAttachmentEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objvPaperSubAttachmentEN.paperSubAttachmentId === null || objvPaperSubAttachmentEN.paperSubAttachmentId === 0)
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(vPaperSubAttachment_Controller, strAction);
try
{
const response = await axios.post(strUrl, objvPaperSubAttachmentEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSubAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSubAttachment_ConstructorName, strThisFuncName);
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
 * @param objvPaperSubAttachmentEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function vPaperSubAttachment_UpdateRecordAsync(objvPaperSubAttachmentEN: clsvPaperSubAttachmentEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objvPaperSubAttachmentEN.sf_UpdFldSetStr === undefined || objvPaperSubAttachmentEN.sf_UpdFldSetStr === null || objvPaperSubAttachmentEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objvPaperSubAttachmentEN.paperSubAttachmentId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(vPaperSubAttachment_Controller, strAction);
try
{
const response = await axios.post(strUrl, objvPaperSubAttachmentEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSubAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSubAttachment_ConstructorName, strThisFuncName);
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
 * @param objvPaperSubAttachmentEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function vPaperSubAttachment_UpdateWithConditionAsync(objvPaperSubAttachmentEN: clsvPaperSubAttachmentEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objvPaperSubAttachmentEN.sf_UpdFldSetStr === undefined || objvPaperSubAttachmentEN.sf_UpdFldSetStr === null || objvPaperSubAttachmentEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objvPaperSubAttachmentEN.paperSubAttachmentId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(vPaperSubAttachment_Controller, strAction);
objvPaperSubAttachmentEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objvPaperSubAttachmentEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSubAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSubAttachment_ConstructorName, strThisFuncName);
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
export async function vPaperSubAttachment_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(vPaperSubAttachment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSubAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSubAttachment_ConstructorName, strThisFuncName);
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
 * @param lngPaperSubAttachmentId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function vPaperSubAttachment_IsExist(lngPaperSubAttachmentId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vPaperSubAttachment_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"PaperSubAttachmentId": lngPaperSubAttachmentId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSubAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSubAttachment_ConstructorName, strThisFuncName);
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
 * @param lngPaperSubAttachmentId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function vPaperSubAttachment_IsExistAsync(lngPaperSubAttachmentId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vPaperSubAttachment_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "lngPaperSubAttachmentId": lngPaperSubAttachmentId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSubAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSubAttachment_ConstructorName, strThisFuncName);
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
export async function vPaperSubAttachment_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(vPaperSubAttachment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSubAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSubAttachment_ConstructorName, strThisFuncName);
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
export async function vPaperSubAttachment_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(vPaperSubAttachment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSubAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSubAttachment_ConstructorName, strThisFuncName);
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
export function vPaperSubAttachment_GetWebApiUrl(strController: string, strAction: string): string {
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
export function vPaperSubAttachment_CheckPropertyNew(pobjvPaperSubAttachmentEN: clsvPaperSubAttachmentEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjvPaperSubAttachmentEN.filePath) === true )
{
 throw new Error("(errid:Watl000058)字段[文件路径]不能为空(In 子观点附件)!(clsvPaperSubAttachmentBL:CheckPropertyNew)");
}
if (null === pobjvPaperSubAttachmentEN.subViewpointId 
 || pobjvPaperSubAttachmentEN.subViewpointId != null && pobjvPaperSubAttachmentEN.subViewpointId.toString()  ===  "")
{
 throw new Error("(errid:Watl000058)字段[子观点Id]不能为空(In 子观点附件)!(clsvPaperSubAttachmentBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjvPaperSubAttachmentEN.explainContent) == false && GetStrLen(pobjvPaperSubAttachmentEN.explainContent) > 5000)
{
 throw new Error("(errid:Watl000059)字段[说明内容(explainContent)]的长度不能超过5000(In 子观点附件(vPaperSubAttachment))!值:$(pobjvPaperSubAttachmentEN.explainContent)(clsvPaperSubAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjvPaperSubAttachmentEN.filePath) == false && GetStrLen(pobjvPaperSubAttachmentEN.filePath) > 500)
{
 throw new Error("(errid:Watl000059)字段[文件路径(filePath)]的长度不能超过500(In 子观点附件(vPaperSubAttachment))!值:$(pobjvPaperSubAttachmentEN.filePath)(clsvPaperSubAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjvPaperSubAttachmentEN.memo) == false && GetStrLen(pobjvPaperSubAttachmentEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 子观点附件(vPaperSubAttachment))!值:$(pobjvPaperSubAttachmentEN.memo)(clsvPaperSubAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjvPaperSubAttachmentEN.paperRWId) == false && GetStrLen(pobjvPaperSubAttachmentEN.paperRWId) > 8)
{
 throw new Error("(errid:Watl000059)字段[课文阅读(paperRWId)]的长度不能超过8(In 子观点附件(vPaperSubAttachment))!值:$(pobjvPaperSubAttachmentEN.paperRWId)(clsvPaperSubAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjvPaperSubAttachmentEN.paperSubAttachmentName) == false && GetStrLen(pobjvPaperSubAttachmentEN.paperSubAttachmentName) > 200)
{
 throw new Error("(errid:Watl000059)字段[附件名称(paperSubAttachmentName)]的长度不能超过200(In 子观点附件(vPaperSubAttachment))!值:$(pobjvPaperSubAttachmentEN.paperSubAttachmentName)(clsvPaperSubAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjvPaperSubAttachmentEN.rwTitle) == false && GetStrLen(pobjvPaperSubAttachmentEN.rwTitle) > 50)
{
 throw new Error("(errid:Watl000059)字段[读写标题(rwTitle)]的长度不能超过50(In 子观点附件(vPaperSubAttachment))!值:$(pobjvPaperSubAttachmentEN.rwTitle)(clsvPaperSubAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjvPaperSubAttachmentEN.updDate) == false && GetStrLen(pobjvPaperSubAttachmentEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 子观点附件(vPaperSubAttachment))!值:$(pobjvPaperSubAttachmentEN.updDate)(clsvPaperSubAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjvPaperSubAttachmentEN.updUserId) == false && GetStrLen(pobjvPaperSubAttachmentEN.updUserId) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改用户Id(updUserId)]的长度不能超过20(In 子观点附件(vPaperSubAttachment))!值:$(pobjvPaperSubAttachmentEN.updUserId)(clsvPaperSubAttachmentBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjvPaperSubAttachmentEN.explainContent) == false && undefined !== pobjvPaperSubAttachmentEN.explainContent && tzDataType.isString(pobjvPaperSubAttachmentEN.explainContent) === false)
{
 throw new Error("(errid:Watl000060)字段[说明内容(explainContent)]的值:[$(pobjvPaperSubAttachmentEN.explainContent)], 非法，应该为字符型(In 子观点附件(vPaperSubAttachment))!(clsvPaperSubAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjvPaperSubAttachmentEN.filePath) == false && undefined !== pobjvPaperSubAttachmentEN.filePath && tzDataType.isString(pobjvPaperSubAttachmentEN.filePath) === false)
{
 throw new Error("(errid:Watl000060)字段[文件路径(filePath)]的值:[$(pobjvPaperSubAttachmentEN.filePath)], 非法，应该为字符型(In 子观点附件(vPaperSubAttachment))!(clsvPaperSubAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjvPaperSubAttachmentEN.memo) == false && undefined !== pobjvPaperSubAttachmentEN.memo && tzDataType.isString(pobjvPaperSubAttachmentEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjvPaperSubAttachmentEN.memo)], 非法，应该为字符型(In 子观点附件(vPaperSubAttachment))!(clsvPaperSubAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjvPaperSubAttachmentEN.paperRWId) == false && undefined !== pobjvPaperSubAttachmentEN.paperRWId && tzDataType.isString(pobjvPaperSubAttachmentEN.paperRWId) === false)
{
 throw new Error("(errid:Watl000060)字段[课文阅读(paperRWId)]的值:[$(pobjvPaperSubAttachmentEN.paperRWId)], 非法，应该为字符型(In 子观点附件(vPaperSubAttachment))!(clsvPaperSubAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjvPaperSubAttachmentEN.paperSubAttachmentName) == false && undefined !== pobjvPaperSubAttachmentEN.paperSubAttachmentName && tzDataType.isString(pobjvPaperSubAttachmentEN.paperSubAttachmentName) === false)
{
 throw new Error("(errid:Watl000060)字段[附件名称(paperSubAttachmentName)]的值:[$(pobjvPaperSubAttachmentEN.paperSubAttachmentName)], 非法，应该为字符型(In 子观点附件(vPaperSubAttachment))!(clsvPaperSubAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjvPaperSubAttachmentEN.rwTitle) == false && undefined !== pobjvPaperSubAttachmentEN.rwTitle && tzDataType.isString(pobjvPaperSubAttachmentEN.rwTitle) === false)
{
 throw new Error("(errid:Watl000060)字段[读写标题(rwTitle)]的值:[$(pobjvPaperSubAttachmentEN.rwTitle)], 非法，应该为字符型(In 子观点附件(vPaperSubAttachment))!(clsvPaperSubAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjvPaperSubAttachmentEN.subViewpointContent) == false && undefined !== pobjvPaperSubAttachmentEN.subViewpointContent && tzDataType.isString(pobjvPaperSubAttachmentEN.subViewpointContent) === false)
{
 throw new Error("(errid:Watl000060)字段[详情内容(subViewpointContent)]的值:[$(pobjvPaperSubAttachmentEN.subViewpointContent)], 非法，应该为字符型(In 子观点附件(vPaperSubAttachment))!(clsvPaperSubAttachmentBL:CheckPropertyNew)");
}
if (null != pobjvPaperSubAttachmentEN.subViewpointId && undefined !== pobjvPaperSubAttachmentEN.subViewpointId && tzDataType.isNumber(pobjvPaperSubAttachmentEN.subViewpointId) === false)
{
 throw new Error("(errid:Watl000060)字段[子观点Id(subViewpointId)]的值:[$(pobjvPaperSubAttachmentEN.subViewpointId)], 非法，应该为数值型(In 子观点附件(vPaperSubAttachment))!(clsvPaperSubAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjvPaperSubAttachmentEN.updDate) == false && undefined !== pobjvPaperSubAttachmentEN.updDate && tzDataType.isString(pobjvPaperSubAttachmentEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjvPaperSubAttachmentEN.updDate)], 非法，应该为字符型(In 子观点附件(vPaperSubAttachment))!(clsvPaperSubAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjvPaperSubAttachmentEN.updUserId) == false && undefined !== pobjvPaperSubAttachmentEN.updUserId && tzDataType.isString(pobjvPaperSubAttachmentEN.updUserId) === false)
{
 throw new Error("(errid:Watl000060)字段[修改用户Id(updUserId)]的值:[$(pobjvPaperSubAttachmentEN.updUserId)], 非法，应该为字符型(In 子观点附件(vPaperSubAttachment))!(clsvPaperSubAttachmentBL:CheckPropertyNew)");
}
if (null != pobjvPaperSubAttachmentEN.paperSubAttachmentId && undefined !== pobjvPaperSubAttachmentEN.paperSubAttachmentId && tzDataType.isNumber(pobjvPaperSubAttachmentEN.paperSubAttachmentId) === false)
{
 throw new Error("(errid:Watl000060)字段[子观点附件Id(paperSubAttachmentId)]的值:[$(pobjvPaperSubAttachmentEN.paperSubAttachmentId)], 非法，应该为数值型(In 子观点附件(vPaperSubAttachment))!(clsvPaperSubAttachmentBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjvPaperSubAttachmentEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function vPaperSubAttachment_CheckProperty4Update (pobjvPaperSubAttachmentEN: clsvPaperSubAttachmentEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjvPaperSubAttachmentEN.explainContent) == false && GetStrLen(pobjvPaperSubAttachmentEN.explainContent) > 5000)
{
 throw new Error("(errid:Watl000062)字段[说明内容(explainContent)]的长度不能超过5000(In 子观点附件(vPaperSubAttachment))!值:$(pobjvPaperSubAttachmentEN.explainContent)(clsvPaperSubAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjvPaperSubAttachmentEN.filePath) == false && GetStrLen(pobjvPaperSubAttachmentEN.filePath) > 500)
{
 throw new Error("(errid:Watl000062)字段[文件路径(filePath)]的长度不能超过500(In 子观点附件(vPaperSubAttachment))!值:$(pobjvPaperSubAttachmentEN.filePath)(clsvPaperSubAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjvPaperSubAttachmentEN.memo) == false && GetStrLen(pobjvPaperSubAttachmentEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 子观点附件(vPaperSubAttachment))!值:$(pobjvPaperSubAttachmentEN.memo)(clsvPaperSubAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjvPaperSubAttachmentEN.paperRWId) == false && GetStrLen(pobjvPaperSubAttachmentEN.paperRWId) > 8)
{
 throw new Error("(errid:Watl000062)字段[课文阅读(paperRWId)]的长度不能超过8(In 子观点附件(vPaperSubAttachment))!值:$(pobjvPaperSubAttachmentEN.paperRWId)(clsvPaperSubAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjvPaperSubAttachmentEN.paperSubAttachmentName) == false && GetStrLen(pobjvPaperSubAttachmentEN.paperSubAttachmentName) > 200)
{
 throw new Error("(errid:Watl000062)字段[附件名称(paperSubAttachmentName)]的长度不能超过200(In 子观点附件(vPaperSubAttachment))!值:$(pobjvPaperSubAttachmentEN.paperSubAttachmentName)(clsvPaperSubAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjvPaperSubAttachmentEN.rwTitle) == false && GetStrLen(pobjvPaperSubAttachmentEN.rwTitle) > 50)
{
 throw new Error("(errid:Watl000062)字段[读写标题(rwTitle)]的长度不能超过50(In 子观点附件(vPaperSubAttachment))!值:$(pobjvPaperSubAttachmentEN.rwTitle)(clsvPaperSubAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjvPaperSubAttachmentEN.updDate) == false && GetStrLen(pobjvPaperSubAttachmentEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 子观点附件(vPaperSubAttachment))!值:$(pobjvPaperSubAttachmentEN.updDate)(clsvPaperSubAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjvPaperSubAttachmentEN.updUserId) == false && GetStrLen(pobjvPaperSubAttachmentEN.updUserId) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改用户Id(updUserId)]的长度不能超过20(In 子观点附件(vPaperSubAttachment))!值:$(pobjvPaperSubAttachmentEN.updUserId)(clsvPaperSubAttachmentBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjvPaperSubAttachmentEN.explainContent) == false && undefined !== pobjvPaperSubAttachmentEN.explainContent && tzDataType.isString(pobjvPaperSubAttachmentEN.explainContent) === false)
{
 throw new Error("(errid:Watl000063)字段[说明内容(explainContent)]的值:[$(pobjvPaperSubAttachmentEN.explainContent)], 非法，应该为字符型(In 子观点附件(vPaperSubAttachment))!(clsvPaperSubAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjvPaperSubAttachmentEN.filePath) == false && undefined !== pobjvPaperSubAttachmentEN.filePath && tzDataType.isString(pobjvPaperSubAttachmentEN.filePath) === false)
{
 throw new Error("(errid:Watl000063)字段[文件路径(filePath)]的值:[$(pobjvPaperSubAttachmentEN.filePath)], 非法，应该为字符型(In 子观点附件(vPaperSubAttachment))!(clsvPaperSubAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjvPaperSubAttachmentEN.memo) == false && undefined !== pobjvPaperSubAttachmentEN.memo && tzDataType.isString(pobjvPaperSubAttachmentEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjvPaperSubAttachmentEN.memo)], 非法，应该为字符型(In 子观点附件(vPaperSubAttachment))!(clsvPaperSubAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjvPaperSubAttachmentEN.paperRWId) == false && undefined !== pobjvPaperSubAttachmentEN.paperRWId && tzDataType.isString(pobjvPaperSubAttachmentEN.paperRWId) === false)
{
 throw new Error("(errid:Watl000063)字段[课文阅读(paperRWId)]的值:[$(pobjvPaperSubAttachmentEN.paperRWId)], 非法，应该为字符型(In 子观点附件(vPaperSubAttachment))!(clsvPaperSubAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjvPaperSubAttachmentEN.paperSubAttachmentName) == false && undefined !== pobjvPaperSubAttachmentEN.paperSubAttachmentName && tzDataType.isString(pobjvPaperSubAttachmentEN.paperSubAttachmentName) === false)
{
 throw new Error("(errid:Watl000063)字段[附件名称(paperSubAttachmentName)]的值:[$(pobjvPaperSubAttachmentEN.paperSubAttachmentName)], 非法，应该为字符型(In 子观点附件(vPaperSubAttachment))!(clsvPaperSubAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjvPaperSubAttachmentEN.rwTitle) == false && undefined !== pobjvPaperSubAttachmentEN.rwTitle && tzDataType.isString(pobjvPaperSubAttachmentEN.rwTitle) === false)
{
 throw new Error("(errid:Watl000063)字段[读写标题(rwTitle)]的值:[$(pobjvPaperSubAttachmentEN.rwTitle)], 非法，应该为字符型(In 子观点附件(vPaperSubAttachment))!(clsvPaperSubAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjvPaperSubAttachmentEN.subViewpointContent) == false && undefined !== pobjvPaperSubAttachmentEN.subViewpointContent && tzDataType.isString(pobjvPaperSubAttachmentEN.subViewpointContent) === false)
{
 throw new Error("(errid:Watl000063)字段[详情内容(subViewpointContent)]的值:[$(pobjvPaperSubAttachmentEN.subViewpointContent)], 非法，应该为字符型(In 子观点附件(vPaperSubAttachment))!(clsvPaperSubAttachmentBL:CheckProperty4Update)");
}
if (null != pobjvPaperSubAttachmentEN.subViewpointId && undefined !== pobjvPaperSubAttachmentEN.subViewpointId && tzDataType.isNumber(pobjvPaperSubAttachmentEN.subViewpointId) === false)
{
 throw new Error("(errid:Watl000063)字段[子观点Id(subViewpointId)]的值:[$(pobjvPaperSubAttachmentEN.subViewpointId)], 非法，应该为数值型(In 子观点附件(vPaperSubAttachment))!(clsvPaperSubAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjvPaperSubAttachmentEN.updDate) == false && undefined !== pobjvPaperSubAttachmentEN.updDate && tzDataType.isString(pobjvPaperSubAttachmentEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjvPaperSubAttachmentEN.updDate)], 非法，应该为字符型(In 子观点附件(vPaperSubAttachment))!(clsvPaperSubAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjvPaperSubAttachmentEN.updUserId) == false && undefined !== pobjvPaperSubAttachmentEN.updUserId && tzDataType.isString(pobjvPaperSubAttachmentEN.updUserId) === false)
{
 throw new Error("(errid:Watl000063)字段[修改用户Id(updUserId)]的值:[$(pobjvPaperSubAttachmentEN.updUserId)], 非法，应该为字符型(In 子观点附件(vPaperSubAttachment))!(clsvPaperSubAttachmentBL:CheckProperty4Update)");
}
if (null != pobjvPaperSubAttachmentEN.paperSubAttachmentId && undefined !== pobjvPaperSubAttachmentEN.paperSubAttachmentId && tzDataType.isNumber(pobjvPaperSubAttachmentEN.paperSubAttachmentId) === false)
{
 throw new Error("(errid:Watl000063)字段[子观点附件Id(paperSubAttachmentId)]的值:[$(pobjvPaperSubAttachmentEN.paperSubAttachmentId)], 非法，应该为数值型(In 子观点附件(vPaperSubAttachment))!(clsvPaperSubAttachmentBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjvPaperSubAttachmentEN.paperSubAttachmentId 
 || pobjvPaperSubAttachmentEN.paperSubAttachmentId != null && pobjvPaperSubAttachmentEN.paperSubAttachmentId.toString()  ===  "")
{
 throw new Error("(errid:Watl000064)字段[子观点附件Id]不能为空(In 子观点附件)!(clsvPaperSubAttachmentBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjvPaperSubAttachmentEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vPaperSubAttachment_GetJSONStrByObj (pobjvPaperSubAttachmentEN: clsvPaperSubAttachmentEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjvPaperSubAttachmentEN.sf_UpdFldSetStr = pobjvPaperSubAttachmentEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjvPaperSubAttachmentEN);
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
export function vPaperSubAttachment_GetObjLstByJSONStr (strJSON: string): Array<clsvPaperSubAttachmentEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrvPaperSubAttachmentObjLst = new Array<clsvPaperSubAttachmentEN>();
if (strJSON === "")
{
return arrvPaperSubAttachmentObjLst;
}
try
{
arrvPaperSubAttachmentObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvPaperSubAttachmentObjLst;
}
return arrvPaperSubAttachmentObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrvPaperSubAttachmentObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function vPaperSubAttachment_GetObjLstByJSONObjLst (arrvPaperSubAttachmentObjLstS: Array<clsvPaperSubAttachmentEN>): Array<clsvPaperSubAttachmentEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrvPaperSubAttachmentObjLst = new Array<clsvPaperSubAttachmentEN>();
for (const objInFor of arrvPaperSubAttachmentObjLstS) {
const obj1 = vPaperSubAttachment_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrvPaperSubAttachmentObjLst.push(obj1);
}
return arrvPaperSubAttachmentObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vPaperSubAttachment_GetObjByJSONStr (strJSON: string): clsvPaperSubAttachmentEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjvPaperSubAttachmentEN = new clsvPaperSubAttachmentEN();
if (strJSON === "")
{
return pobjvPaperSubAttachmentEN;
}
try
{
pobjvPaperSubAttachmentEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvPaperSubAttachmentEN;
}
return pobjvPaperSubAttachmentEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function vPaperSubAttachment_GetCombineCondition(objvPaperSubAttachment_Cond: clsvPaperSubAttachmentEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objvPaperSubAttachment_Cond.dicFldComparisonOp, clsvPaperSubAttachmentEN.con_ExplainContent) == true)
{
const strComparisonOp_ExplainContent:string = objvPaperSubAttachment_Cond.dicFldComparisonOp[clsvPaperSubAttachmentEN.con_ExplainContent];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperSubAttachmentEN.con_ExplainContent, objvPaperSubAttachment_Cond.explainContent, strComparisonOp_ExplainContent);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSubAttachment_Cond.dicFldComparisonOp, clsvPaperSubAttachmentEN.con_FilePath) == true)
{
const strComparisonOp_FilePath:string = objvPaperSubAttachment_Cond.dicFldComparisonOp[clsvPaperSubAttachmentEN.con_FilePath];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperSubAttachmentEN.con_FilePath, objvPaperSubAttachment_Cond.filePath, strComparisonOp_FilePath);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSubAttachment_Cond.dicFldComparisonOp, clsvPaperSubAttachmentEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objvPaperSubAttachment_Cond.dicFldComparisonOp[clsvPaperSubAttachmentEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperSubAttachmentEN.con_Memo, objvPaperSubAttachment_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSubAttachment_Cond.dicFldComparisonOp, clsvPaperSubAttachmentEN.con_PaperRWId) == true)
{
const strComparisonOp_PaperRWId:string = objvPaperSubAttachment_Cond.dicFldComparisonOp[clsvPaperSubAttachmentEN.con_PaperRWId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperSubAttachmentEN.con_PaperRWId, objvPaperSubAttachment_Cond.paperRWId, strComparisonOp_PaperRWId);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSubAttachment_Cond.dicFldComparisonOp, clsvPaperSubAttachmentEN.con_PaperSubAttachmentName) == true)
{
const strComparisonOp_PaperSubAttachmentName:string = objvPaperSubAttachment_Cond.dicFldComparisonOp[clsvPaperSubAttachmentEN.con_PaperSubAttachmentName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperSubAttachmentEN.con_PaperSubAttachmentName, objvPaperSubAttachment_Cond.paperSubAttachmentName, strComparisonOp_PaperSubAttachmentName);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSubAttachment_Cond.dicFldComparisonOp, clsvPaperSubAttachmentEN.con_RWTitle) == true)
{
const strComparisonOp_RWTitle:string = objvPaperSubAttachment_Cond.dicFldComparisonOp[clsvPaperSubAttachmentEN.con_RWTitle];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperSubAttachmentEN.con_RWTitle, objvPaperSubAttachment_Cond.rwTitle, strComparisonOp_RWTitle);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objvPaperSubAttachment_Cond.dicFldComparisonOp, clsvPaperSubAttachmentEN.con_SubViewpointId) == true)
{
const strComparisonOp_SubViewpointId:string = objvPaperSubAttachment_Cond.dicFldComparisonOp[clsvPaperSubAttachmentEN.con_SubViewpointId];
strWhereCond += Format(" And {0} {2} {1}", clsvPaperSubAttachmentEN.con_SubViewpointId, objvPaperSubAttachment_Cond.subViewpointId, strComparisonOp_SubViewpointId);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSubAttachment_Cond.dicFldComparisonOp, clsvPaperSubAttachmentEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objvPaperSubAttachment_Cond.dicFldComparisonOp[clsvPaperSubAttachmentEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperSubAttachmentEN.con_UpdDate, objvPaperSubAttachment_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSubAttachment_Cond.dicFldComparisonOp, clsvPaperSubAttachmentEN.con_UpdUserId) == true)
{
const strComparisonOp_UpdUserId:string = objvPaperSubAttachment_Cond.dicFldComparisonOp[clsvPaperSubAttachmentEN.con_UpdUserId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperSubAttachmentEN.con_UpdUserId, objvPaperSubAttachment_Cond.updUserId, strComparisonOp_UpdUserId);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSubAttachment_Cond.dicFldComparisonOp, clsvPaperSubAttachmentEN.con_PaperSubAttachmentId) == true)
{
const strComparisonOp_PaperSubAttachmentId:string = objvPaperSubAttachment_Cond.dicFldComparisonOp[clsvPaperSubAttachmentEN.con_PaperSubAttachmentId];
strWhereCond += Format(" And {0} {2} {1}", clsvPaperSubAttachmentEN.con_PaperSubAttachmentId, objvPaperSubAttachment_Cond.paperSubAttachmentId, strComparisonOp_PaperSubAttachmentId);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--vPaperSubAttachment(子观点附件),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param lngPaperSubAttachmentId: 子观点附件Id(要求唯一的字段)
 * @param lngSubViewpointId: 子观点Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function vPaperSubAttachment_GetUniCondStr_PaperSubAttachmentId_SubViewpointId(objvPaperSubAttachmentEN: clsvPaperSubAttachmentEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and PaperSubAttachmentId = '{0}'", objvPaperSubAttachmentEN.paperSubAttachmentId);
 strWhereCond +=  Format(" and SubViewpointId = '{0}'", objvPaperSubAttachmentEN.subViewpointId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--vPaperSubAttachment(子观点附件),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param lngPaperSubAttachmentId: 子观点附件Id(要求唯一的字段)
 * @param lngSubViewpointId: 子观点Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function vPaperSubAttachment_GetUniCondStr4Update_PaperSubAttachmentId_SubViewpointId(objvPaperSubAttachmentEN: clsvPaperSubAttachmentEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and PaperSubAttachmentId <> '{0}'", objvPaperSubAttachmentEN.paperSubAttachmentId);
 strWhereCond +=  Format(" and PaperSubAttachmentId = '{0}'", objvPaperSubAttachmentEN.paperSubAttachmentId);
 strWhereCond +=  Format(" and SubViewpointId = '{0}'", objvPaperSubAttachmentEN.subViewpointId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objvPaperSubAttachmentENS:源对象
 * @param objvPaperSubAttachmentENT:目标对象
*/
export function vPaperSubAttachment_CopyObjTo(objvPaperSubAttachmentENS: clsvPaperSubAttachmentEN , objvPaperSubAttachmentENT: clsvPaperSubAttachmentEN ): void 
{
objvPaperSubAttachmentENT.explainContent = objvPaperSubAttachmentENS.explainContent; //说明内容
objvPaperSubAttachmentENT.filePath = objvPaperSubAttachmentENS.filePath; //文件路径
objvPaperSubAttachmentENT.memo = objvPaperSubAttachmentENS.memo; //备注
objvPaperSubAttachmentENT.paperRWId = objvPaperSubAttachmentENS.paperRWId; //课文阅读
objvPaperSubAttachmentENT.paperSubAttachmentName = objvPaperSubAttachmentENS.paperSubAttachmentName; //附件名称
objvPaperSubAttachmentENT.rwTitle = objvPaperSubAttachmentENS.rwTitle; //读写标题
objvPaperSubAttachmentENT.subViewpointContent = objvPaperSubAttachmentENS.subViewpointContent; //详情内容
objvPaperSubAttachmentENT.subViewpointId = objvPaperSubAttachmentENS.subViewpointId; //子观点Id
objvPaperSubAttachmentENT.updDate = objvPaperSubAttachmentENS.updDate; //修改日期
objvPaperSubAttachmentENT.updUserId = objvPaperSubAttachmentENS.updUserId; //修改用户Id
objvPaperSubAttachmentENT.paperSubAttachmentId = objvPaperSubAttachmentENS.paperSubAttachmentId; //子观点附件Id
objvPaperSubAttachmentENT.sf_UpdFldSetStr = objvPaperSubAttachmentENS.updFldString; //sf_UpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objvPaperSubAttachmentENS:源对象
 * @param objvPaperSubAttachmentENT:目标对象
*/
export function vPaperSubAttachment_GetObjFromJsonObj(objvPaperSubAttachmentENS: clsvPaperSubAttachmentEN): clsvPaperSubAttachmentEN 
{
 const objvPaperSubAttachmentENT: clsvPaperSubAttachmentEN = new clsvPaperSubAttachmentEN();
ObjectAssign(objvPaperSubAttachmentENT, objvPaperSubAttachmentENS);
 return objvPaperSubAttachmentENT;
}