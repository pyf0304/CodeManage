
 /**
 * 类名:clsvPaperCollectionLogWApi
 * 表名:vPaperCollectionLog(01120569)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 12:02:39
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
 * v论文收藏(vPaperCollectionLog)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { clsvPaperCollectionLogEN } from "../../L0_Entity/GraduateEduPaper/clsvPaperCollectionLogEN.js";
import { BindDdl_ObjLstInDiv_V, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const vPaperCollectionLog_Controller = "vPaperCollectionLogApi";
 export const vPaperCollectionLog_ConstructorName = "vPaperCollectionLog";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngPaperCollectionLogId:关键字
 * @returns 对象
 **/
export async function vPaperCollectionLog_GetObjByPaperCollectionLogIdAsync(lngPaperCollectionLogId: number): Promise<clsvPaperCollectionLogEN>  
{
const strThisFuncName = "GetObjByPaperCollectionLogIdAsync";

if (lngPaperCollectionLogId == 0)
{
  const strMsg = Format("参数:[lngPaperCollectionLogId]不能为空！(In GetObjByPaperCollectionLogIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjByPaperCollectionLogId";
const strUrl = GetWebApiUrl(vPaperCollectionLog_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"lngPaperCollectionLogId": lngPaperCollectionLogId,
}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObj = data.returnObj;
if (returnObj == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vPaperCollectionLog_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvPaperCollectionLog = vPaperCollectionLog_GetObjFromJsonObj(returnObj);
return objvPaperCollectionLog;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperCollectionLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperCollectionLog_ConstructorName, strThisFuncName);
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

/**
 * 排序函数。根据关键字字段的值进行比较
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
 * @param a:比较的第1个对象
 * @param  b:比较的第1个对象
 * @returns 返回两个对象比较的结果
*/
export function vPaperCollectionLog_SortFun_Defa(a:clsvPaperCollectionLogEN , b:clsvPaperCollectionLogEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.paperCollectionLogId-b.paperCollectionLogId;
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
export function vPaperCollectionLog_SortFun_Defa_2Fld(a:clsvPaperCollectionLogEN , b:clsvPaperCollectionLogEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.paperId == b.paperId) return a.updUser.localeCompare(b.updUser);
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
export function vPaperCollectionLog_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsvPaperCollectionLogEN.con_PaperCollectionLogId:
return (a: clsvPaperCollectionLogEN, b: clsvPaperCollectionLogEN) => {
return a.paperCollectionLogId-b.paperCollectionLogId;
}
case clsvPaperCollectionLogEN.con_PaperId:
return (a: clsvPaperCollectionLogEN, b: clsvPaperCollectionLogEN) => {
return a.paperId.localeCompare(b.paperId);
}
case clsvPaperCollectionLogEN.con_UpdUser:
return (a: clsvPaperCollectionLogEN, b: clsvPaperCollectionLogEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsvPaperCollectionLogEN.con_UpdDate:
return (a: clsvPaperCollectionLogEN, b: clsvPaperCollectionLogEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsvPaperCollectionLogEN.con_Meno:
return (a: clsvPaperCollectionLogEN, b: clsvPaperCollectionLogEN) => {
return a.meno.localeCompare(b.meno);
}
case clsvPaperCollectionLogEN.con_PaperTitle:
return (a: clsvPaperCollectionLogEN, b: clsvPaperCollectionLogEN) => {
return a.paperTitle.localeCompare(b.paperTitle);
}
case clsvPaperCollectionLogEN.con_Author:
return (a: clsvPaperCollectionLogEN, b: clsvPaperCollectionLogEN) => {
return a.author.localeCompare(b.author);
}
case clsvPaperCollectionLogEN.con_Keyword:
return (a: clsvPaperCollectionLogEN, b: clsvPaperCollectionLogEN) => {
return a.keyword.localeCompare(b.keyword);
}
case clsvPaperCollectionLogEN.con_BrowseNumber:
return (a: clsvPaperCollectionLogEN, b: clsvPaperCollectionLogEN) => {
return a.browseNumber-b.browseNumber;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vPaperCollectionLog]中不存在！(in ${ vPaperCollectionLog_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsvPaperCollectionLogEN.con_PaperCollectionLogId:
return (a: clsvPaperCollectionLogEN, b: clsvPaperCollectionLogEN) => {
return b.paperCollectionLogId-a.paperCollectionLogId;
}
case clsvPaperCollectionLogEN.con_PaperId:
return (a: clsvPaperCollectionLogEN, b: clsvPaperCollectionLogEN) => {
return b.paperId.localeCompare(a.paperId);
}
case clsvPaperCollectionLogEN.con_UpdUser:
return (a: clsvPaperCollectionLogEN, b: clsvPaperCollectionLogEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsvPaperCollectionLogEN.con_UpdDate:
return (a: clsvPaperCollectionLogEN, b: clsvPaperCollectionLogEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsvPaperCollectionLogEN.con_Meno:
return (a: clsvPaperCollectionLogEN, b: clsvPaperCollectionLogEN) => {
return b.meno.localeCompare(a.meno);
}
case clsvPaperCollectionLogEN.con_PaperTitle:
return (a: clsvPaperCollectionLogEN, b: clsvPaperCollectionLogEN) => {
return b.paperTitle.localeCompare(a.paperTitle);
}
case clsvPaperCollectionLogEN.con_Author:
return (a: clsvPaperCollectionLogEN, b: clsvPaperCollectionLogEN) => {
return b.author.localeCompare(a.author);
}
case clsvPaperCollectionLogEN.con_Keyword:
return (a: clsvPaperCollectionLogEN, b: clsvPaperCollectionLogEN) => {
return b.keyword.localeCompare(a.keyword);
}
case clsvPaperCollectionLogEN.con_BrowseNumber:
return (a: clsvPaperCollectionLogEN, b: clsvPaperCollectionLogEN) => {
return b.browseNumber-a.browseNumber;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vPaperCollectionLog]中不存在！(in ${ vPaperCollectionLog_ConstructorName}.${ strThisFuncName})`;
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
export async function vPaperCollectionLog_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsvPaperCollectionLogEN.con_PaperCollectionLogId:
return (obj: clsvPaperCollectionLogEN) => {
return obj.paperCollectionLogId === value;
}
case clsvPaperCollectionLogEN.con_PaperId:
return (obj: clsvPaperCollectionLogEN) => {
return obj.paperId === value;
}
case clsvPaperCollectionLogEN.con_UpdUser:
return (obj: clsvPaperCollectionLogEN) => {
return obj.updUser === value;
}
case clsvPaperCollectionLogEN.con_UpdDate:
return (obj: clsvPaperCollectionLogEN) => {
return obj.updDate === value;
}
case clsvPaperCollectionLogEN.con_Meno:
return (obj: clsvPaperCollectionLogEN) => {
return obj.meno === value;
}
case clsvPaperCollectionLogEN.con_PaperTitle:
return (obj: clsvPaperCollectionLogEN) => {
return obj.paperTitle === value;
}
case clsvPaperCollectionLogEN.con_Author:
return (obj: clsvPaperCollectionLogEN) => {
return obj.author === value;
}
case clsvPaperCollectionLogEN.con_Keyword:
return (obj: clsvPaperCollectionLogEN) => {
return obj.keyword === value;
}
case clsvPaperCollectionLogEN.con_BrowseNumber:
return (obj: clsvPaperCollectionLogEN) => {
return obj.browseNumber === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vPaperCollectionLog]中不存在！(in ${ vPaperCollectionLog_ConstructorName}.${ strThisFuncName})`;
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
export async function vPaperCollectionLog_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vPaperCollectionLog_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperCollectionLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperCollectionLog_ConstructorName, strThisFuncName);
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
export async function vPaperCollectionLog_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vPaperCollectionLog_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperCollectionLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperCollectionLog_ConstructorName, strThisFuncName);
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
export async function vPaperCollectionLog_GetFirstObjAsync(strWhereCond: string): Promise<clsvPaperCollectionLogEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(vPaperCollectionLog_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vPaperCollectionLog_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvPaperCollectionLog = vPaperCollectionLog_GetObjFromJsonObj(returnObj);
return objvPaperCollectionLog;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperCollectionLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperCollectionLog_ConstructorName, strThisFuncName);
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
export async function vPaperCollectionLog_GetObjLstAsync(strWhereCond: string): Promise<Array<clsvPaperCollectionLogEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(vPaperCollectionLog_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vPaperCollectionLog_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vPaperCollectionLog_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperCollectionLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperCollectionLog_ConstructorName, strThisFuncName);
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
 * @param arrPaperCollectionLogId:关键字列表
 * @returns 对象列表
 **/
export async function vPaperCollectionLog_GetObjLstByPaperCollectionLogIdLstAsync(arrPaperCollectionLogId: Array<string>): Promise<Array<clsvPaperCollectionLogEN>>  
{
const strThisFuncName = "GetObjLstByPaperCollectionLogIdLstAsync";
const strAction = "GetObjLstByPaperCollectionLogIdLst";
const strUrl = GetWebApiUrl(vPaperCollectionLog_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrPaperCollectionLogId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vPaperCollectionLog_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vPaperCollectionLog_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperCollectionLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperCollectionLog_ConstructorName, strThisFuncName);
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
export async function vPaperCollectionLog_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsvPaperCollectionLogEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(vPaperCollectionLog_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vPaperCollectionLog_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vPaperCollectionLog_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperCollectionLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperCollectionLog_ConstructorName, strThisFuncName);
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
export async function vPaperCollectionLog_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsvPaperCollectionLogEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vPaperCollectionLog_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vPaperCollectionLog_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vPaperCollectionLog_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperCollectionLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperCollectionLog_ConstructorName, strThisFuncName);
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
export async function vPaperCollectionLog_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vPaperCollectionLog_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperCollectionLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperCollectionLog_ConstructorName, strThisFuncName);
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
export async function vPaperCollectionLog_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsvPaperCollectionLogEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(vPaperCollectionLog_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vPaperCollectionLog_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vPaperCollectionLog_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperCollectionLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperCollectionLog_ConstructorName, strThisFuncName);
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
export async function vPaperCollectionLog_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(vPaperCollectionLog_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperCollectionLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperCollectionLog_ConstructorName, strThisFuncName);
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
 * @param lngPaperCollectionLogId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function vPaperCollectionLog_IsExist(lngPaperCollectionLogId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vPaperCollectionLog_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"PaperCollectionLogId": lngPaperCollectionLogId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperCollectionLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperCollectionLog_ConstructorName, strThisFuncName);
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
 * @param lngPaperCollectionLogId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function vPaperCollectionLog_IsExistAsync(lngPaperCollectionLogId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vPaperCollectionLog_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "lngPaperCollectionLogId": lngPaperCollectionLogId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperCollectionLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperCollectionLog_ConstructorName, strThisFuncName);
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
export async function vPaperCollectionLog_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(vPaperCollectionLog_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperCollectionLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperCollectionLog_ConstructorName, strThisFuncName);
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
 * 获取WebApi的地址
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
 * @returns 返回当前文件中Web服务的地址
*/
export function vPaperCollectionLog_GetWebApiUrl(strController: string, strAction: string): string {
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

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vPaperCollectionLog_GetJSONStrByObj (pobjvPaperCollectionLogEN: clsvPaperCollectionLogEN): string
{
const strThisFuncName = "GetJSONStrByObj";
let strJson = "";
try
{
strJson = JSON.stringify(pobjvPaperCollectionLogEN);
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
export function vPaperCollectionLog_GetObjLstByJSONStr (strJSON: string): Array<clsvPaperCollectionLogEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrvPaperCollectionLogObjLst = new Array<clsvPaperCollectionLogEN>();
if (strJSON === "")
{
return arrvPaperCollectionLogObjLst;
}
try
{
arrvPaperCollectionLogObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvPaperCollectionLogObjLst;
}
return arrvPaperCollectionLogObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrvPaperCollectionLogObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function vPaperCollectionLog_GetObjLstByJSONObjLst (arrvPaperCollectionLogObjLstS: Array<clsvPaperCollectionLogEN>): Array<clsvPaperCollectionLogEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrvPaperCollectionLogObjLst = new Array<clsvPaperCollectionLogEN>();
for (const objInFor of arrvPaperCollectionLogObjLstS) {
const obj1 = vPaperCollectionLog_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrvPaperCollectionLogObjLst.push(obj1);
}
return arrvPaperCollectionLogObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vPaperCollectionLog_GetObjByJSONStr (strJSON: string): clsvPaperCollectionLogEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjvPaperCollectionLogEN = new clsvPaperCollectionLogEN();
if (strJSON === "")
{
return pobjvPaperCollectionLogEN;
}
try
{
pobjvPaperCollectionLogEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvPaperCollectionLogEN;
}
return pobjvPaperCollectionLogEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function vPaperCollectionLog_GetCombineCondition(objvPaperCollectionLog_Cond: clsvPaperCollectionLogEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objvPaperCollectionLog_Cond.dicFldComparisonOp, clsvPaperCollectionLogEN.con_PaperCollectionLogId) == true)
{
const strComparisonOp_PaperCollectionLogId:string = objvPaperCollectionLog_Cond.dicFldComparisonOp[clsvPaperCollectionLogEN.con_PaperCollectionLogId];
strWhereCond += Format(" And {0} {2} {1}", clsvPaperCollectionLogEN.con_PaperCollectionLogId, objvPaperCollectionLog_Cond.paperCollectionLogId, strComparisonOp_PaperCollectionLogId);
}
if (Object.prototype.hasOwnProperty.call(objvPaperCollectionLog_Cond.dicFldComparisonOp, clsvPaperCollectionLogEN.con_PaperId) == true)
{
const strComparisonOp_PaperId:string = objvPaperCollectionLog_Cond.dicFldComparisonOp[clsvPaperCollectionLogEN.con_PaperId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperCollectionLogEN.con_PaperId, objvPaperCollectionLog_Cond.paperId, strComparisonOp_PaperId);
}
if (Object.prototype.hasOwnProperty.call(objvPaperCollectionLog_Cond.dicFldComparisonOp, clsvPaperCollectionLogEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objvPaperCollectionLog_Cond.dicFldComparisonOp[clsvPaperCollectionLogEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperCollectionLogEN.con_UpdUser, objvPaperCollectionLog_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objvPaperCollectionLog_Cond.dicFldComparisonOp, clsvPaperCollectionLogEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objvPaperCollectionLog_Cond.dicFldComparisonOp[clsvPaperCollectionLogEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperCollectionLogEN.con_UpdDate, objvPaperCollectionLog_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objvPaperCollectionLog_Cond.dicFldComparisonOp, clsvPaperCollectionLogEN.con_Meno) == true)
{
const strComparisonOp_Meno:string = objvPaperCollectionLog_Cond.dicFldComparisonOp[clsvPaperCollectionLogEN.con_Meno];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperCollectionLogEN.con_Meno, objvPaperCollectionLog_Cond.meno, strComparisonOp_Meno);
}
if (Object.prototype.hasOwnProperty.call(objvPaperCollectionLog_Cond.dicFldComparisonOp, clsvPaperCollectionLogEN.con_PaperTitle) == true)
{
const strComparisonOp_PaperTitle:string = objvPaperCollectionLog_Cond.dicFldComparisonOp[clsvPaperCollectionLogEN.con_PaperTitle];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperCollectionLogEN.con_PaperTitle, objvPaperCollectionLog_Cond.paperTitle, strComparisonOp_PaperTitle);
}
if (Object.prototype.hasOwnProperty.call(objvPaperCollectionLog_Cond.dicFldComparisonOp, clsvPaperCollectionLogEN.con_Author) == true)
{
const strComparisonOp_Author:string = objvPaperCollectionLog_Cond.dicFldComparisonOp[clsvPaperCollectionLogEN.con_Author];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperCollectionLogEN.con_Author, objvPaperCollectionLog_Cond.author, strComparisonOp_Author);
}
if (Object.prototype.hasOwnProperty.call(objvPaperCollectionLog_Cond.dicFldComparisonOp, clsvPaperCollectionLogEN.con_Keyword) == true)
{
const strComparisonOp_Keyword:string = objvPaperCollectionLog_Cond.dicFldComparisonOp[clsvPaperCollectionLogEN.con_Keyword];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperCollectionLogEN.con_Keyword, objvPaperCollectionLog_Cond.keyword, strComparisonOp_Keyword);
}
if (Object.prototype.hasOwnProperty.call(objvPaperCollectionLog_Cond.dicFldComparisonOp, clsvPaperCollectionLogEN.con_BrowseNumber) == true)
{
const strComparisonOp_BrowseNumber:string = objvPaperCollectionLog_Cond.dicFldComparisonOp[clsvPaperCollectionLogEN.con_BrowseNumber];
strWhereCond += Format(" And {0} {2} {1}", clsvPaperCollectionLogEN.con_BrowseNumber, objvPaperCollectionLog_Cond.browseNumber, strComparisonOp_BrowseNumber);
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objvPaperCollectionLogENS:源对象
 * @param objvPaperCollectionLogENT:目标对象
*/
export function vPaperCollectionLog_CopyObjTo(objvPaperCollectionLogENS: clsvPaperCollectionLogEN , objvPaperCollectionLogENT: clsvPaperCollectionLogEN ): void 
{
objvPaperCollectionLogENT.paperCollectionLogId = objvPaperCollectionLogENS.paperCollectionLogId; //论文收藏Id
objvPaperCollectionLogENT.paperId = objvPaperCollectionLogENS.paperId; //论文Id
objvPaperCollectionLogENT.updUser = objvPaperCollectionLogENS.updUser; //修改人
objvPaperCollectionLogENT.updDate = objvPaperCollectionLogENS.updDate; //修改日期
objvPaperCollectionLogENT.meno = objvPaperCollectionLogENS.meno; //备注
objvPaperCollectionLogENT.paperTitle = objvPaperCollectionLogENS.paperTitle; //论文标题
objvPaperCollectionLogENT.author = objvPaperCollectionLogENS.author; //作者
objvPaperCollectionLogENT.keyword = objvPaperCollectionLogENS.keyword; //关键字
objvPaperCollectionLogENT.browseNumber = objvPaperCollectionLogENS.browseNumber; //浏览量
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objvPaperCollectionLogENS:源对象
 * @param objvPaperCollectionLogENT:目标对象
*/
export function vPaperCollectionLog_GetObjFromJsonObj(objvPaperCollectionLogENS: clsvPaperCollectionLogEN): clsvPaperCollectionLogEN 
{
 const objvPaperCollectionLogENT: clsvPaperCollectionLogEN = new clsvPaperCollectionLogEN();
ObjectAssign(objvPaperCollectionLogENT, objvPaperCollectionLogENS);
 return objvPaperCollectionLogENT;
}