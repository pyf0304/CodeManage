﻿
 /**
 * 类名:clsgs_PConcepRelaWApi
 * 表名:gs_PConcepRela(01120670)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:46:44
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
 * 论文概念关系(gs_PConcepRela)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { clsgs_PConcepRelaEN } from "../../L0_Entity/GraduateEduPaper/clsgs_PConcepRelaEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { tzDataType } from "../../PubFun/jsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const gs_PConcepRela_Controller = "gs_PConcepRelaApi";
 export const gs_PConcepRela_ConstructorName = "gs_PConcepRela";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngmId:关键字
 * @returns 对象
 **/
export async function gs_PConcepRela_GetObjBymIdAsync(lngmId: number): Promise<clsgs_PConcepRelaEN>  
{
const strThisFuncName = "GetObjBymIdAsync";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In GetObjBymIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjBymId";
const strUrl = GetWebApiUrl(gs_PConcepRela_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_PConcepRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objgs_PConcepRela = gs_PConcepRela_GetObjFromJsonObj(returnObj);
return objgs_PConcepRela;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PConcepRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PConcepRela_ConstructorName, strThisFuncName);
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
export function gs_PConcepRela_SortFun_Defa(a:clsgs_PConcepRelaEN , b:clsgs_PConcepRelaEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.mId-b.mId;
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
export function gs_PConcepRela_SortFun_Defa_2Fld(a:clsgs_PConcepRelaEN , b:clsgs_PConcepRelaEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.paperId == b.paperId) return a.sectionId.localeCompare(b.sectionId);
else return a.paperId.localeCompare(b.paperId);
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
export function gs_PConcepRela_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsgs_PConcepRelaEN.con_mId:
return (a: clsgs_PConcepRelaEN, b: clsgs_PConcepRelaEN) => {
return a.mId-b.mId;
}
case clsgs_PConcepRelaEN.con_PaperId:
return (a: clsgs_PConcepRelaEN, b: clsgs_PConcepRelaEN) => {
return a.paperId.localeCompare(b.paperId);
}
case clsgs_PConcepRelaEN.con_SectionId:
return (a: clsgs_PConcepRelaEN, b: clsgs_PConcepRelaEN) => {
return a.sectionId.localeCompare(b.sectionId);
}
case clsgs_PConcepRelaEN.con_ConceptId:
return (a: clsgs_PConcepRelaEN, b: clsgs_PConcepRelaEN) => {
return a.conceptId.localeCompare(b.conceptId);
}
case clsgs_PConcepRelaEN.con_UpdDate:
return (a: clsgs_PConcepRelaEN, b: clsgs_PConcepRelaEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsgs_PConcepRelaEN.con_UpdUser:
return (a: clsgs_PConcepRelaEN, b: clsgs_PConcepRelaEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsgs_PConcepRelaEN.con_Memo:
return (a: clsgs_PConcepRelaEN, b: clsgs_PConcepRelaEN) => {
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_PConcepRela]中不存在！(in ${ gs_PConcepRela_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsgs_PConcepRelaEN.con_mId:
return (a: clsgs_PConcepRelaEN, b: clsgs_PConcepRelaEN) => {
return b.mId-a.mId;
}
case clsgs_PConcepRelaEN.con_PaperId:
return (a: clsgs_PConcepRelaEN, b: clsgs_PConcepRelaEN) => {
return b.paperId.localeCompare(a.paperId);
}
case clsgs_PConcepRelaEN.con_SectionId:
return (a: clsgs_PConcepRelaEN, b: clsgs_PConcepRelaEN) => {
return b.sectionId.localeCompare(a.sectionId);
}
case clsgs_PConcepRelaEN.con_ConceptId:
return (a: clsgs_PConcepRelaEN, b: clsgs_PConcepRelaEN) => {
return b.conceptId.localeCompare(a.conceptId);
}
case clsgs_PConcepRelaEN.con_UpdDate:
return (a: clsgs_PConcepRelaEN, b: clsgs_PConcepRelaEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsgs_PConcepRelaEN.con_UpdUser:
return (a: clsgs_PConcepRelaEN, b: clsgs_PConcepRelaEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsgs_PConcepRelaEN.con_Memo:
return (a: clsgs_PConcepRelaEN, b: clsgs_PConcepRelaEN) => {
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_PConcepRela]中不存在！(in ${ gs_PConcepRela_ConstructorName}.${ strThisFuncName})`;
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
export async function gs_PConcepRela_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsgs_PConcepRelaEN.con_mId:
return (obj: clsgs_PConcepRelaEN) => {
return obj.mId === value;
}
case clsgs_PConcepRelaEN.con_PaperId:
return (obj: clsgs_PConcepRelaEN) => {
return obj.paperId === value;
}
case clsgs_PConcepRelaEN.con_SectionId:
return (obj: clsgs_PConcepRelaEN) => {
return obj.sectionId === value;
}
case clsgs_PConcepRelaEN.con_ConceptId:
return (obj: clsgs_PConcepRelaEN) => {
return obj.conceptId === value;
}
case clsgs_PConcepRelaEN.con_UpdDate:
return (obj: clsgs_PConcepRelaEN) => {
return obj.updDate === value;
}
case clsgs_PConcepRelaEN.con_UpdUser:
return (obj: clsgs_PConcepRelaEN) => {
return obj.updUser === value;
}
case clsgs_PConcepRelaEN.con_Memo:
return (obj: clsgs_PConcepRelaEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_PConcepRela]中不存在！(in ${ gs_PConcepRela_ConstructorName}.${ strThisFuncName})`;
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
export async function gs_PConcepRela_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(gs_PConcepRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PConcepRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PConcepRela_ConstructorName, strThisFuncName);
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
export async function gs_PConcepRela_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(gs_PConcepRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PConcepRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PConcepRela_ConstructorName, strThisFuncName);
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
export async function gs_PConcepRela_GetFirstObjAsync(strWhereCond: string): Promise<clsgs_PConcepRelaEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(gs_PConcepRela_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_PConcepRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objgs_PConcepRela = gs_PConcepRela_GetObjFromJsonObj(returnObj);
return objgs_PConcepRela;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PConcepRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PConcepRela_ConstructorName, strThisFuncName);
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
export async function gs_PConcepRela_GetObjLstAsync(strWhereCond: string): Promise<Array<clsgs_PConcepRelaEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(gs_PConcepRela_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_PConcepRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_PConcepRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PConcepRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PConcepRela_ConstructorName, strThisFuncName);
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
export async function gs_PConcepRela_GetObjLstBymIdLstAsync(arrmId: Array<string>): Promise<Array<clsgs_PConcepRelaEN>>  
{
const strThisFuncName = "GetObjLstBymIdLstAsync";
const strAction = "GetObjLstBymIdLst";
const strUrl = GetWebApiUrl(gs_PConcepRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrmId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_PConcepRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_PConcepRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PConcepRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PConcepRela_ConstructorName, strThisFuncName);
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
export async function gs_PConcepRela_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsgs_PConcepRelaEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(gs_PConcepRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_PConcepRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_PConcepRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PConcepRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PConcepRela_ConstructorName, strThisFuncName);
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
export async function gs_PConcepRela_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsgs_PConcepRelaEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(gs_PConcepRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_PConcepRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_PConcepRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PConcepRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PConcepRela_ConstructorName, strThisFuncName);
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
export async function gs_PConcepRela_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(gs_PConcepRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PConcepRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PConcepRela_ConstructorName, strThisFuncName);
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
export async function gs_PConcepRela_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsgs_PConcepRelaEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(gs_PConcepRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_PConcepRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_PConcepRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PConcepRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PConcepRela_ConstructorName, strThisFuncName);
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
export async function gs_PConcepRela_DelRecordAsync(lngmId: number): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(gs_PConcepRela_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, lngmId);
try
{
const response = await axios.delete(strUrl,
{
params: { "Id": lngmId, }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PConcepRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PConcepRela_ConstructorName, strThisFuncName);
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
export async function gs_PConcepRela_Delgs_PConcepRelasAsync(arrmId: Array<string>): Promise<number> 
{
const strThisFuncName = "Delgs_PConcepRelasAsync";
const strAction = "Delgs_PConcepRelas";
const strUrl = GetWebApiUrl(gs_PConcepRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PConcepRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PConcepRela_ConstructorName, strThisFuncName);
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
export async function gs_PConcepRela_Delgs_PConcepRelasByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "Delgs_PConcepRelasByCondAsync";
const strAction = "Delgs_PConcepRelasByCond";
const strUrl = GetWebApiUrl(gs_PConcepRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PConcepRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PConcepRela_ConstructorName, strThisFuncName);
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
 * @param objgs_PConcepRelaEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_PConcepRela_AddNewRecordAsync(objgs_PConcepRelaEN: clsgs_PConcepRelaEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objgs_PConcepRelaEN);
const strUrl = GetWebApiUrl(gs_PConcepRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_PConcepRelaEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PConcepRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PConcepRela_ConstructorName, strThisFuncName);
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
 * @param objgs_PConcepRelaEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function gs_PConcepRela_AddNewRecordWithReturnKeyAsync(objgs_PConcepRelaEN: clsgs_PConcepRelaEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(gs_PConcepRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_PConcepRelaEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PConcepRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PConcepRela_ConstructorName, strThisFuncName);
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
 * @param objgs_PConcepRelaEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function gs_PConcepRela_AddNewRecordWithReturnKey(objgs_PConcepRelaEN: clsgs_PConcepRelaEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objgs_PConcepRelaEN.mId === null || objgs_PConcepRelaEN.mId === 0)
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(gs_PConcepRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_PConcepRelaEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PConcepRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PConcepRela_ConstructorName, strThisFuncName);
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
 * @param objgs_PConcepRelaEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function gs_PConcepRela_UpdateRecordAsync(objgs_PConcepRelaEN: clsgs_PConcepRelaEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objgs_PConcepRelaEN.sf_UpdFldSetStr === undefined || objgs_PConcepRelaEN.sf_UpdFldSetStr === null || objgs_PConcepRelaEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_PConcepRelaEN.mId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(gs_PConcepRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_PConcepRelaEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PConcepRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PConcepRela_ConstructorName, strThisFuncName);
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
 * @param objgs_PConcepRelaEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function gs_PConcepRela_UpdateWithConditionAsync(objgs_PConcepRelaEN: clsgs_PConcepRelaEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objgs_PConcepRelaEN.sf_UpdFldSetStr === undefined || objgs_PConcepRelaEN.sf_UpdFldSetStr === null || objgs_PConcepRelaEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_PConcepRelaEN.mId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(gs_PConcepRela_Controller, strAction);
objgs_PConcepRelaEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objgs_PConcepRelaEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PConcepRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PConcepRela_ConstructorName, strThisFuncName);
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
export async function gs_PConcepRela_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(gs_PConcepRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PConcepRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PConcepRela_ConstructorName, strThisFuncName);
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
export async function gs_PConcepRela_IsExist(lngmId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(gs_PConcepRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PConcepRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PConcepRela_ConstructorName, strThisFuncName);
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
export async function gs_PConcepRela_IsExistAsync(lngmId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(gs_PConcepRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PConcepRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PConcepRela_ConstructorName, strThisFuncName);
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
export async function gs_PConcepRela_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(gs_PConcepRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PConcepRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PConcepRela_ConstructorName, strThisFuncName);
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
export async function gs_PConcepRela_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(gs_PConcepRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PConcepRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PConcepRela_ConstructorName, strThisFuncName);
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
export function gs_PConcepRela_GetWebApiUrl(strController: string, strAction: string): string {
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
export function gs_PConcepRela_CheckPropertyNew(pobjgs_PConcepRelaEN: clsgs_PConcepRelaEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjgs_PConcepRelaEN.paperId) === true 
 || pobjgs_PConcepRelaEN.paperId.toString()  ===  "0" )
{
 throw new Error("(errid:Watl000058)字段[论文Id]不能为空(In 论文概念关系)!(clsgs_PConcepRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PConcepRelaEN.conceptId) === true )
{
 throw new Error("(errid:Watl000058)字段[概念Id]不能为空(In 论文概念关系)!(clsgs_PConcepRelaBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjgs_PConcepRelaEN.paperId) == false && GetStrLen(pobjgs_PConcepRelaEN.paperId) > 8)
{
 throw new Error("(errid:Watl000059)字段[论文Id(paperId)]的长度不能超过8(In 论文概念关系(gs_PConcepRela))!值:$(pobjgs_PConcepRelaEN.paperId)(clsgs_PConcepRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PConcepRelaEN.sectionId) == false && GetStrLen(pobjgs_PConcepRelaEN.sectionId) > 8)
{
 throw new Error("(errid:Watl000059)字段[节Id(sectionId)]的长度不能超过8(In 论文概念关系(gs_PConcepRela))!值:$(pobjgs_PConcepRelaEN.sectionId)(clsgs_PConcepRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PConcepRelaEN.conceptId) == false && GetStrLen(pobjgs_PConcepRelaEN.conceptId) > 8)
{
 throw new Error("(errid:Watl000059)字段[概念Id(conceptId)]的长度不能超过8(In 论文概念关系(gs_PConcepRela))!值:$(pobjgs_PConcepRelaEN.conceptId)(clsgs_PConcepRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PConcepRelaEN.updDate) == false && GetStrLen(pobjgs_PConcepRelaEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 论文概念关系(gs_PConcepRela))!值:$(pobjgs_PConcepRelaEN.updDate)(clsgs_PConcepRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PConcepRelaEN.updUser) == false && GetStrLen(pobjgs_PConcepRelaEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 论文概念关系(gs_PConcepRela))!值:$(pobjgs_PConcepRelaEN.updUser)(clsgs_PConcepRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PConcepRelaEN.memo) == false && GetStrLen(pobjgs_PConcepRelaEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 论文概念关系(gs_PConcepRela))!值:$(pobjgs_PConcepRelaEN.memo)(clsgs_PConcepRelaBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null != pobjgs_PConcepRelaEN.mId && undefined !== pobjgs_PConcepRelaEN.mId && tzDataType.isNumber(pobjgs_PConcepRelaEN.mId) === false)
{
 throw new Error("(errid:Watl000060)字段[mId(mId)]的值:[$(pobjgs_PConcepRelaEN.mId)], 非法，应该为数值型(In 论文概念关系(gs_PConcepRela))!(clsgs_PConcepRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PConcepRelaEN.paperId) == false && undefined !== pobjgs_PConcepRelaEN.paperId && tzDataType.isString(pobjgs_PConcepRelaEN.paperId) === false)
{
 throw new Error("(errid:Watl000060)字段[论文Id(paperId)]的值:[$(pobjgs_PConcepRelaEN.paperId)], 非法，应该为字符型(In 论文概念关系(gs_PConcepRela))!(clsgs_PConcepRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PConcepRelaEN.sectionId) == false && undefined !== pobjgs_PConcepRelaEN.sectionId && tzDataType.isString(pobjgs_PConcepRelaEN.sectionId) === false)
{
 throw new Error("(errid:Watl000060)字段[节Id(sectionId)]的值:[$(pobjgs_PConcepRelaEN.sectionId)], 非法，应该为字符型(In 论文概念关系(gs_PConcepRela))!(clsgs_PConcepRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PConcepRelaEN.conceptId) == false && undefined !== pobjgs_PConcepRelaEN.conceptId && tzDataType.isString(pobjgs_PConcepRelaEN.conceptId) === false)
{
 throw new Error("(errid:Watl000060)字段[概念Id(conceptId)]的值:[$(pobjgs_PConcepRelaEN.conceptId)], 非法，应该为字符型(In 论文概念关系(gs_PConcepRela))!(clsgs_PConcepRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PConcepRelaEN.updDate) == false && undefined !== pobjgs_PConcepRelaEN.updDate && tzDataType.isString(pobjgs_PConcepRelaEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjgs_PConcepRelaEN.updDate)], 非法，应该为字符型(In 论文概念关系(gs_PConcepRela))!(clsgs_PConcepRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PConcepRelaEN.updUser) == false && undefined !== pobjgs_PConcepRelaEN.updUser && tzDataType.isString(pobjgs_PConcepRelaEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjgs_PConcepRelaEN.updUser)], 非法，应该为字符型(In 论文概念关系(gs_PConcepRela))!(clsgs_PConcepRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PConcepRelaEN.memo) == false && undefined !== pobjgs_PConcepRelaEN.memo && tzDataType.isString(pobjgs_PConcepRelaEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjgs_PConcepRelaEN.memo)], 非法，应该为字符型(In 论文概念关系(gs_PConcepRela))!(clsgs_PConcepRelaBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjgs_PConcepRelaEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function gs_PConcepRela_CheckProperty4Update (pobjgs_PConcepRelaEN: clsgs_PConcepRelaEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjgs_PConcepRelaEN.paperId) == false && GetStrLen(pobjgs_PConcepRelaEN.paperId) > 8)
{
 throw new Error("(errid:Watl000062)字段[论文Id(paperId)]的长度不能超过8(In 论文概念关系(gs_PConcepRela))!值:$(pobjgs_PConcepRelaEN.paperId)(clsgs_PConcepRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PConcepRelaEN.sectionId) == false && GetStrLen(pobjgs_PConcepRelaEN.sectionId) > 8)
{
 throw new Error("(errid:Watl000062)字段[节Id(sectionId)]的长度不能超过8(In 论文概念关系(gs_PConcepRela))!值:$(pobjgs_PConcepRelaEN.sectionId)(clsgs_PConcepRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PConcepRelaEN.conceptId) == false && GetStrLen(pobjgs_PConcepRelaEN.conceptId) > 8)
{
 throw new Error("(errid:Watl000062)字段[概念Id(conceptId)]的长度不能超过8(In 论文概念关系(gs_PConcepRela))!值:$(pobjgs_PConcepRelaEN.conceptId)(clsgs_PConcepRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PConcepRelaEN.updDate) == false && GetStrLen(pobjgs_PConcepRelaEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 论文概念关系(gs_PConcepRela))!值:$(pobjgs_PConcepRelaEN.updDate)(clsgs_PConcepRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PConcepRelaEN.updUser) == false && GetStrLen(pobjgs_PConcepRelaEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 论文概念关系(gs_PConcepRela))!值:$(pobjgs_PConcepRelaEN.updUser)(clsgs_PConcepRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PConcepRelaEN.memo) == false && GetStrLen(pobjgs_PConcepRelaEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 论文概念关系(gs_PConcepRela))!值:$(pobjgs_PConcepRelaEN.memo)(clsgs_PConcepRelaBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null != pobjgs_PConcepRelaEN.mId && undefined !== pobjgs_PConcepRelaEN.mId && tzDataType.isNumber(pobjgs_PConcepRelaEN.mId) === false)
{
 throw new Error("(errid:Watl000063)字段[mId(mId)]的值:[$(pobjgs_PConcepRelaEN.mId)], 非法，应该为数值型(In 论文概念关系(gs_PConcepRela))!(clsgs_PConcepRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PConcepRelaEN.paperId) == false && undefined !== pobjgs_PConcepRelaEN.paperId && tzDataType.isString(pobjgs_PConcepRelaEN.paperId) === false)
{
 throw new Error("(errid:Watl000063)字段[论文Id(paperId)]的值:[$(pobjgs_PConcepRelaEN.paperId)], 非法，应该为字符型(In 论文概念关系(gs_PConcepRela))!(clsgs_PConcepRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PConcepRelaEN.sectionId) == false && undefined !== pobjgs_PConcepRelaEN.sectionId && tzDataType.isString(pobjgs_PConcepRelaEN.sectionId) === false)
{
 throw new Error("(errid:Watl000063)字段[节Id(sectionId)]的值:[$(pobjgs_PConcepRelaEN.sectionId)], 非法，应该为字符型(In 论文概念关系(gs_PConcepRela))!(clsgs_PConcepRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PConcepRelaEN.conceptId) == false && undefined !== pobjgs_PConcepRelaEN.conceptId && tzDataType.isString(pobjgs_PConcepRelaEN.conceptId) === false)
{
 throw new Error("(errid:Watl000063)字段[概念Id(conceptId)]的值:[$(pobjgs_PConcepRelaEN.conceptId)], 非法，应该为字符型(In 论文概念关系(gs_PConcepRela))!(clsgs_PConcepRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PConcepRelaEN.updDate) == false && undefined !== pobjgs_PConcepRelaEN.updDate && tzDataType.isString(pobjgs_PConcepRelaEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjgs_PConcepRelaEN.updDate)], 非法，应该为字符型(In 论文概念关系(gs_PConcepRela))!(clsgs_PConcepRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PConcepRelaEN.updUser) == false && undefined !== pobjgs_PConcepRelaEN.updUser && tzDataType.isString(pobjgs_PConcepRelaEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjgs_PConcepRelaEN.updUser)], 非法，应该为字符型(In 论文概念关系(gs_PConcepRela))!(clsgs_PConcepRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PConcepRelaEN.memo) == false && undefined !== pobjgs_PConcepRelaEN.memo && tzDataType.isString(pobjgs_PConcepRelaEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjgs_PConcepRelaEN.memo)], 非法，应该为字符型(In 论文概念关系(gs_PConcepRela))!(clsgs_PConcepRelaBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjgs_PConcepRelaEN.mId 
 || pobjgs_PConcepRelaEN.mId != null && pobjgs_PConcepRelaEN.mId.toString()  ===  "")
{
 throw new Error("(errid:Watl000064)字段[mId]不能为空(In 论文概念关系)!(clsgs_PConcepRelaBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjgs_PConcepRelaEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function gs_PConcepRela_GetJSONStrByObj (pobjgs_PConcepRelaEN: clsgs_PConcepRelaEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjgs_PConcepRelaEN.sf_UpdFldSetStr = pobjgs_PConcepRelaEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjgs_PConcepRelaEN);
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
export function gs_PConcepRela_GetObjLstByJSONStr (strJSON: string): Array<clsgs_PConcepRelaEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrgs_PConcepRelaObjLst = new Array<clsgs_PConcepRelaEN>();
if (strJSON === "")
{
return arrgs_PConcepRelaObjLst;
}
try
{
arrgs_PConcepRelaObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrgs_PConcepRelaObjLst;
}
return arrgs_PConcepRelaObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrgs_PConcepRelaObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function gs_PConcepRela_GetObjLstByJSONObjLst (arrgs_PConcepRelaObjLstS: Array<clsgs_PConcepRelaEN>): Array<clsgs_PConcepRelaEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrgs_PConcepRelaObjLst = new Array<clsgs_PConcepRelaEN>();
for (const objInFor of arrgs_PConcepRelaObjLstS) {
const obj1 = gs_PConcepRela_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrgs_PConcepRelaObjLst.push(obj1);
}
return arrgs_PConcepRelaObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function gs_PConcepRela_GetObjByJSONStr (strJSON: string): clsgs_PConcepRelaEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjgs_PConcepRelaEN = new clsgs_PConcepRelaEN();
if (strJSON === "")
{
return pobjgs_PConcepRelaEN;
}
try
{
pobjgs_PConcepRelaEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjgs_PConcepRelaEN;
}
return pobjgs_PConcepRelaEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function gs_PConcepRela_GetCombineCondition(objgs_PConcepRela_Cond: clsgs_PConcepRelaEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objgs_PConcepRela_Cond.dicFldComparisonOp, clsgs_PConcepRelaEN.con_mId) == true)
{
const strComparisonOp_mId:string = objgs_PConcepRela_Cond.dicFldComparisonOp[clsgs_PConcepRelaEN.con_mId];
strWhereCond += Format(" And {0} {2} {1}", clsgs_PConcepRelaEN.con_mId, objgs_PConcepRela_Cond.mId, strComparisonOp_mId);
}
if (Object.prototype.hasOwnProperty.call(objgs_PConcepRela_Cond.dicFldComparisonOp, clsgs_PConcepRelaEN.con_PaperId) == true)
{
const strComparisonOp_PaperId:string = objgs_PConcepRela_Cond.dicFldComparisonOp[clsgs_PConcepRelaEN.con_PaperId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PConcepRelaEN.con_PaperId, objgs_PConcepRela_Cond.paperId, strComparisonOp_PaperId);
}
if (Object.prototype.hasOwnProperty.call(objgs_PConcepRela_Cond.dicFldComparisonOp, clsgs_PConcepRelaEN.con_SectionId) == true)
{
const strComparisonOp_SectionId:string = objgs_PConcepRela_Cond.dicFldComparisonOp[clsgs_PConcepRelaEN.con_SectionId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PConcepRelaEN.con_SectionId, objgs_PConcepRela_Cond.sectionId, strComparisonOp_SectionId);
}
if (Object.prototype.hasOwnProperty.call(objgs_PConcepRela_Cond.dicFldComparisonOp, clsgs_PConcepRelaEN.con_ConceptId) == true)
{
const strComparisonOp_ConceptId:string = objgs_PConcepRela_Cond.dicFldComparisonOp[clsgs_PConcepRelaEN.con_ConceptId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PConcepRelaEN.con_ConceptId, objgs_PConcepRela_Cond.conceptId, strComparisonOp_ConceptId);
}
if (Object.prototype.hasOwnProperty.call(objgs_PConcepRela_Cond.dicFldComparisonOp, clsgs_PConcepRelaEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objgs_PConcepRela_Cond.dicFldComparisonOp[clsgs_PConcepRelaEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PConcepRelaEN.con_UpdDate, objgs_PConcepRela_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objgs_PConcepRela_Cond.dicFldComparisonOp, clsgs_PConcepRelaEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objgs_PConcepRela_Cond.dicFldComparisonOp[clsgs_PConcepRelaEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PConcepRelaEN.con_UpdUser, objgs_PConcepRela_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objgs_PConcepRela_Cond.dicFldComparisonOp, clsgs_PConcepRelaEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objgs_PConcepRela_Cond.dicFldComparisonOp[clsgs_PConcepRelaEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PConcepRelaEN.con_Memo, objgs_PConcepRela_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--gs_PConcepRela(论文概念关系),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param lngmId: mId(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function gs_PConcepRela_GetUniCondStr_mId(objgs_PConcepRelaEN: clsgs_PConcepRelaEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and mId = '{0}'", objgs_PConcepRelaEN.mId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--gs_PConcepRela(论文概念关系),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param lngmId: mId(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function gs_PConcepRela_GetUniCondStr4Update_mId(objgs_PConcepRelaEN: clsgs_PConcepRelaEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and mId <> '{0}'", objgs_PConcepRelaEN.mId);
 strWhereCond +=  Format(" and mId = '{0}'", objgs_PConcepRelaEN.mId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objgs_PConcepRelaENS:源对象
 * @param objgs_PConcepRelaENT:目标对象
*/
export function gs_PConcepRela_CopyObjTo(objgs_PConcepRelaENS: clsgs_PConcepRelaEN , objgs_PConcepRelaENT: clsgs_PConcepRelaEN ): void 
{
objgs_PConcepRelaENT.mId = objgs_PConcepRelaENS.mId; //mId
objgs_PConcepRelaENT.paperId = objgs_PConcepRelaENS.paperId; //论文Id
objgs_PConcepRelaENT.sectionId = objgs_PConcepRelaENS.sectionId; //节Id
objgs_PConcepRelaENT.conceptId = objgs_PConcepRelaENS.conceptId; //概念Id
objgs_PConcepRelaENT.updDate = objgs_PConcepRelaENS.updDate; //修改日期
objgs_PConcepRelaENT.updUser = objgs_PConcepRelaENS.updUser; //修改人
objgs_PConcepRelaENT.memo = objgs_PConcepRelaENS.memo; //备注
objgs_PConcepRelaENT.sf_UpdFldSetStr = objgs_PConcepRelaENS.updFldString; //sf_UpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objgs_PConcepRelaENS:源对象
 * @param objgs_PConcepRelaENT:目标对象
*/
export function gs_PConcepRela_GetObjFromJsonObj(objgs_PConcepRelaENS: clsgs_PConcepRelaEN): clsgs_PConcepRelaEN 
{
 const objgs_PConcepRelaENT: clsgs_PConcepRelaEN = new clsgs_PConcepRelaEN();
ObjectAssign(objgs_PConcepRelaENT, objgs_PConcepRelaENS);
 return objgs_PConcepRelaENT;
}