
 /**
 * 类名:clsvPaperDownloadLogWApi
 * 表名:vPaperDownloadLog(01120572)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 12:02:40
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
 * v论文下载记录(vPaperDownloadLog)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { clsvPaperDownloadLogEN } from "../../L0_Entity/GraduateEduPaper/clsvPaperDownloadLogEN.js";
import { BindDdl_ObjLstInDiv_V, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const vPaperDownloadLog_Controller = "vPaperDownloadLogApi";
 export const vPaperDownloadLog_ConstructorName = "vPaperDownloadLog";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngPaperDownloadId:关键字
 * @returns 对象
 **/
export async function vPaperDownloadLog_GetObjByPaperDownloadIdAsync(lngPaperDownloadId: number): Promise<clsvPaperDownloadLogEN>  
{
const strThisFuncName = "GetObjByPaperDownloadIdAsync";

if (lngPaperDownloadId == 0)
{
  const strMsg = Format("参数:[lngPaperDownloadId]不能为空！(In GetObjByPaperDownloadIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjByPaperDownloadId";
const strUrl = GetWebApiUrl(vPaperDownloadLog_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"lngPaperDownloadId": lngPaperDownloadId,
}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObj = data.returnObj;
if (returnObj == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vPaperDownloadLog_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvPaperDownloadLog = vPaperDownloadLog_GetObjFromJsonObj(returnObj);
return objvPaperDownloadLog;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperDownloadLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperDownloadLog_ConstructorName, strThisFuncName);
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
export function vPaperDownloadLog_SortFun_Defa(a:clsvPaperDownloadLogEN , b:clsvPaperDownloadLogEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.paperDownloadId-b.paperDownloadId;
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
export function vPaperDownloadLog_SortFun_Defa_2Fld(a:clsvPaperDownloadLogEN , b:clsvPaperDownloadLogEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.downloadFile == b.downloadFile) return a.downloadLink.localeCompare(b.downloadLink);
else return a.downloadFile.localeCompare(b.downloadFile);
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
export function vPaperDownloadLog_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsvPaperDownloadLogEN.con_PaperDownloadId:
return (a: clsvPaperDownloadLogEN, b: clsvPaperDownloadLogEN) => {
return a.paperDownloadId-b.paperDownloadId;
}
case clsvPaperDownloadLogEN.con_DownloadFile:
return (a: clsvPaperDownloadLogEN, b: clsvPaperDownloadLogEN) => {
return a.downloadFile.localeCompare(b.downloadFile);
}
case clsvPaperDownloadLogEN.con_DownloadLink:
return (a: clsvPaperDownloadLogEN, b: clsvPaperDownloadLogEN) => {
return a.downloadLink.localeCompare(b.downloadLink);
}
case clsvPaperDownloadLogEN.con_PaperId:
return (a: clsvPaperDownloadLogEN, b: clsvPaperDownloadLogEN) => {
return a.paperId.localeCompare(b.paperId);
}
case clsvPaperDownloadLogEN.con_UpdUser:
return (a: clsvPaperDownloadLogEN, b: clsvPaperDownloadLogEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsvPaperDownloadLogEN.con_UpdDate:
return (a: clsvPaperDownloadLogEN, b: clsvPaperDownloadLogEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsvPaperDownloadLogEN.con_Memo:
return (a: clsvPaperDownloadLogEN, b: clsvPaperDownloadLogEN) => {
return a.memo.localeCompare(b.memo);
}
case clsvPaperDownloadLogEN.con_PaperTitle:
return (a: clsvPaperDownloadLogEN, b: clsvPaperDownloadLogEN) => {
return a.paperTitle.localeCompare(b.paperTitle);
}
case clsvPaperDownloadLogEN.con_Author:
return (a: clsvPaperDownloadLogEN, b: clsvPaperDownloadLogEN) => {
return a.author.localeCompare(b.author);
}
case clsvPaperDownloadLogEN.con_Keyword:
return (a: clsvPaperDownloadLogEN, b: clsvPaperDownloadLogEN) => {
return a.keyword.localeCompare(b.keyword);
}
case clsvPaperDownloadLogEN.con_UserName:
return (a: clsvPaperDownloadLogEN, b: clsvPaperDownloadLogEN) => {
return a.userName.localeCompare(b.userName);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vPaperDownloadLog]中不存在！(in ${ vPaperDownloadLog_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsvPaperDownloadLogEN.con_PaperDownloadId:
return (a: clsvPaperDownloadLogEN, b: clsvPaperDownloadLogEN) => {
return b.paperDownloadId-a.paperDownloadId;
}
case clsvPaperDownloadLogEN.con_DownloadFile:
return (a: clsvPaperDownloadLogEN, b: clsvPaperDownloadLogEN) => {
return b.downloadFile.localeCompare(a.downloadFile);
}
case clsvPaperDownloadLogEN.con_DownloadLink:
return (a: clsvPaperDownloadLogEN, b: clsvPaperDownloadLogEN) => {
return b.downloadLink.localeCompare(a.downloadLink);
}
case clsvPaperDownloadLogEN.con_PaperId:
return (a: clsvPaperDownloadLogEN, b: clsvPaperDownloadLogEN) => {
return b.paperId.localeCompare(a.paperId);
}
case clsvPaperDownloadLogEN.con_UpdUser:
return (a: clsvPaperDownloadLogEN, b: clsvPaperDownloadLogEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsvPaperDownloadLogEN.con_UpdDate:
return (a: clsvPaperDownloadLogEN, b: clsvPaperDownloadLogEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsvPaperDownloadLogEN.con_Memo:
return (a: clsvPaperDownloadLogEN, b: clsvPaperDownloadLogEN) => {
return b.memo.localeCompare(a.memo);
}
case clsvPaperDownloadLogEN.con_PaperTitle:
return (a: clsvPaperDownloadLogEN, b: clsvPaperDownloadLogEN) => {
return b.paperTitle.localeCompare(a.paperTitle);
}
case clsvPaperDownloadLogEN.con_Author:
return (a: clsvPaperDownloadLogEN, b: clsvPaperDownloadLogEN) => {
return b.author.localeCompare(a.author);
}
case clsvPaperDownloadLogEN.con_Keyword:
return (a: clsvPaperDownloadLogEN, b: clsvPaperDownloadLogEN) => {
return b.keyword.localeCompare(a.keyword);
}
case clsvPaperDownloadLogEN.con_UserName:
return (a: clsvPaperDownloadLogEN, b: clsvPaperDownloadLogEN) => {
return b.userName.localeCompare(a.userName);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vPaperDownloadLog]中不存在！(in ${ vPaperDownloadLog_ConstructorName}.${ strThisFuncName})`;
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
export async function vPaperDownloadLog_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsvPaperDownloadLogEN.con_PaperDownloadId:
return (obj: clsvPaperDownloadLogEN) => {
return obj.paperDownloadId === value;
}
case clsvPaperDownloadLogEN.con_DownloadFile:
return (obj: clsvPaperDownloadLogEN) => {
return obj.downloadFile === value;
}
case clsvPaperDownloadLogEN.con_DownloadLink:
return (obj: clsvPaperDownloadLogEN) => {
return obj.downloadLink === value;
}
case clsvPaperDownloadLogEN.con_PaperId:
return (obj: clsvPaperDownloadLogEN) => {
return obj.paperId === value;
}
case clsvPaperDownloadLogEN.con_UpdUser:
return (obj: clsvPaperDownloadLogEN) => {
return obj.updUser === value;
}
case clsvPaperDownloadLogEN.con_UpdDate:
return (obj: clsvPaperDownloadLogEN) => {
return obj.updDate === value;
}
case clsvPaperDownloadLogEN.con_Memo:
return (obj: clsvPaperDownloadLogEN) => {
return obj.memo === value;
}
case clsvPaperDownloadLogEN.con_PaperTitle:
return (obj: clsvPaperDownloadLogEN) => {
return obj.paperTitle === value;
}
case clsvPaperDownloadLogEN.con_Author:
return (obj: clsvPaperDownloadLogEN) => {
return obj.author === value;
}
case clsvPaperDownloadLogEN.con_Keyword:
return (obj: clsvPaperDownloadLogEN) => {
return obj.keyword === value;
}
case clsvPaperDownloadLogEN.con_UserName:
return (obj: clsvPaperDownloadLogEN) => {
return obj.userName === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vPaperDownloadLog]中不存在！(in ${ vPaperDownloadLog_ConstructorName}.${ strThisFuncName})`;
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
export async function vPaperDownloadLog_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vPaperDownloadLog_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperDownloadLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperDownloadLog_ConstructorName, strThisFuncName);
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
export async function vPaperDownloadLog_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vPaperDownloadLog_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperDownloadLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperDownloadLog_ConstructorName, strThisFuncName);
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
export async function vPaperDownloadLog_GetFirstObjAsync(strWhereCond: string): Promise<clsvPaperDownloadLogEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(vPaperDownloadLog_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vPaperDownloadLog_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvPaperDownloadLog = vPaperDownloadLog_GetObjFromJsonObj(returnObj);
return objvPaperDownloadLog;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperDownloadLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperDownloadLog_ConstructorName, strThisFuncName);
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
export async function vPaperDownloadLog_GetObjLstAsync(strWhereCond: string): Promise<Array<clsvPaperDownloadLogEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(vPaperDownloadLog_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vPaperDownloadLog_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vPaperDownloadLog_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperDownloadLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperDownloadLog_ConstructorName, strThisFuncName);
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
 * @param arrPaperDownloadId:关键字列表
 * @returns 对象列表
 **/
export async function vPaperDownloadLog_GetObjLstByPaperDownloadIdLstAsync(arrPaperDownloadId: Array<string>): Promise<Array<clsvPaperDownloadLogEN>>  
{
const strThisFuncName = "GetObjLstByPaperDownloadIdLstAsync";
const strAction = "GetObjLstByPaperDownloadIdLst";
const strUrl = GetWebApiUrl(vPaperDownloadLog_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrPaperDownloadId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vPaperDownloadLog_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vPaperDownloadLog_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperDownloadLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperDownloadLog_ConstructorName, strThisFuncName);
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
export async function vPaperDownloadLog_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsvPaperDownloadLogEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(vPaperDownloadLog_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vPaperDownloadLog_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vPaperDownloadLog_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperDownloadLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperDownloadLog_ConstructorName, strThisFuncName);
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
export async function vPaperDownloadLog_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsvPaperDownloadLogEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vPaperDownloadLog_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vPaperDownloadLog_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vPaperDownloadLog_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperDownloadLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperDownloadLog_ConstructorName, strThisFuncName);
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
export async function vPaperDownloadLog_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vPaperDownloadLog_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperDownloadLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperDownloadLog_ConstructorName, strThisFuncName);
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
export async function vPaperDownloadLog_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsvPaperDownloadLogEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(vPaperDownloadLog_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vPaperDownloadLog_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vPaperDownloadLog_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperDownloadLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperDownloadLog_ConstructorName, strThisFuncName);
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
export async function vPaperDownloadLog_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(vPaperDownloadLog_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperDownloadLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperDownloadLog_ConstructorName, strThisFuncName);
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
 * @param lngPaperDownloadId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function vPaperDownloadLog_IsExist(lngPaperDownloadId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vPaperDownloadLog_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"PaperDownloadId": lngPaperDownloadId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperDownloadLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperDownloadLog_ConstructorName, strThisFuncName);
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
 * @param lngPaperDownloadId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function vPaperDownloadLog_IsExistAsync(lngPaperDownloadId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vPaperDownloadLog_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "lngPaperDownloadId": lngPaperDownloadId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperDownloadLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperDownloadLog_ConstructorName, strThisFuncName);
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
export async function vPaperDownloadLog_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(vPaperDownloadLog_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperDownloadLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperDownloadLog_ConstructorName, strThisFuncName);
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
export function vPaperDownloadLog_GetWebApiUrl(strController: string, strAction: string): string {
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
export function vPaperDownloadLog_GetJSONStrByObj (pobjvPaperDownloadLogEN: clsvPaperDownloadLogEN): string
{
const strThisFuncName = "GetJSONStrByObj";
let strJson = "";
try
{
strJson = JSON.stringify(pobjvPaperDownloadLogEN);
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
export function vPaperDownloadLog_GetObjLstByJSONStr (strJSON: string): Array<clsvPaperDownloadLogEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrvPaperDownloadLogObjLst = new Array<clsvPaperDownloadLogEN>();
if (strJSON === "")
{
return arrvPaperDownloadLogObjLst;
}
try
{
arrvPaperDownloadLogObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvPaperDownloadLogObjLst;
}
return arrvPaperDownloadLogObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrvPaperDownloadLogObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function vPaperDownloadLog_GetObjLstByJSONObjLst (arrvPaperDownloadLogObjLstS: Array<clsvPaperDownloadLogEN>): Array<clsvPaperDownloadLogEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrvPaperDownloadLogObjLst = new Array<clsvPaperDownloadLogEN>();
for (const objInFor of arrvPaperDownloadLogObjLstS) {
const obj1 = vPaperDownloadLog_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrvPaperDownloadLogObjLst.push(obj1);
}
return arrvPaperDownloadLogObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vPaperDownloadLog_GetObjByJSONStr (strJSON: string): clsvPaperDownloadLogEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjvPaperDownloadLogEN = new clsvPaperDownloadLogEN();
if (strJSON === "")
{
return pobjvPaperDownloadLogEN;
}
try
{
pobjvPaperDownloadLogEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvPaperDownloadLogEN;
}
return pobjvPaperDownloadLogEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function vPaperDownloadLog_GetCombineCondition(objvPaperDownloadLog_Cond: clsvPaperDownloadLogEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objvPaperDownloadLog_Cond.dicFldComparisonOp, clsvPaperDownloadLogEN.con_PaperDownloadId) == true)
{
const strComparisonOp_PaperDownloadId:string = objvPaperDownloadLog_Cond.dicFldComparisonOp[clsvPaperDownloadLogEN.con_PaperDownloadId];
strWhereCond += Format(" And {0} {2} {1}", clsvPaperDownloadLogEN.con_PaperDownloadId, objvPaperDownloadLog_Cond.paperDownloadId, strComparisonOp_PaperDownloadId);
}
if (Object.prototype.hasOwnProperty.call(objvPaperDownloadLog_Cond.dicFldComparisonOp, clsvPaperDownloadLogEN.con_DownloadFile) == true)
{
const strComparisonOp_DownloadFile:string = objvPaperDownloadLog_Cond.dicFldComparisonOp[clsvPaperDownloadLogEN.con_DownloadFile];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperDownloadLogEN.con_DownloadFile, objvPaperDownloadLog_Cond.downloadFile, strComparisonOp_DownloadFile);
}
if (Object.prototype.hasOwnProperty.call(objvPaperDownloadLog_Cond.dicFldComparisonOp, clsvPaperDownloadLogEN.con_DownloadLink) == true)
{
const strComparisonOp_DownloadLink:string = objvPaperDownloadLog_Cond.dicFldComparisonOp[clsvPaperDownloadLogEN.con_DownloadLink];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperDownloadLogEN.con_DownloadLink, objvPaperDownloadLog_Cond.downloadLink, strComparisonOp_DownloadLink);
}
if (Object.prototype.hasOwnProperty.call(objvPaperDownloadLog_Cond.dicFldComparisonOp, clsvPaperDownloadLogEN.con_PaperId) == true)
{
const strComparisonOp_PaperId:string = objvPaperDownloadLog_Cond.dicFldComparisonOp[clsvPaperDownloadLogEN.con_PaperId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperDownloadLogEN.con_PaperId, objvPaperDownloadLog_Cond.paperId, strComparisonOp_PaperId);
}
if (Object.prototype.hasOwnProperty.call(objvPaperDownloadLog_Cond.dicFldComparisonOp, clsvPaperDownloadLogEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objvPaperDownloadLog_Cond.dicFldComparisonOp[clsvPaperDownloadLogEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperDownloadLogEN.con_UpdUser, objvPaperDownloadLog_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objvPaperDownloadLog_Cond.dicFldComparisonOp, clsvPaperDownloadLogEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objvPaperDownloadLog_Cond.dicFldComparisonOp[clsvPaperDownloadLogEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperDownloadLogEN.con_UpdDate, objvPaperDownloadLog_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objvPaperDownloadLog_Cond.dicFldComparisonOp, clsvPaperDownloadLogEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objvPaperDownloadLog_Cond.dicFldComparisonOp[clsvPaperDownloadLogEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperDownloadLogEN.con_Memo, objvPaperDownloadLog_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objvPaperDownloadLog_Cond.dicFldComparisonOp, clsvPaperDownloadLogEN.con_PaperTitle) == true)
{
const strComparisonOp_PaperTitle:string = objvPaperDownloadLog_Cond.dicFldComparisonOp[clsvPaperDownloadLogEN.con_PaperTitle];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperDownloadLogEN.con_PaperTitle, objvPaperDownloadLog_Cond.paperTitle, strComparisonOp_PaperTitle);
}
if (Object.prototype.hasOwnProperty.call(objvPaperDownloadLog_Cond.dicFldComparisonOp, clsvPaperDownloadLogEN.con_Author) == true)
{
const strComparisonOp_Author:string = objvPaperDownloadLog_Cond.dicFldComparisonOp[clsvPaperDownloadLogEN.con_Author];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperDownloadLogEN.con_Author, objvPaperDownloadLog_Cond.author, strComparisonOp_Author);
}
if (Object.prototype.hasOwnProperty.call(objvPaperDownloadLog_Cond.dicFldComparisonOp, clsvPaperDownloadLogEN.con_Keyword) == true)
{
const strComparisonOp_Keyword:string = objvPaperDownloadLog_Cond.dicFldComparisonOp[clsvPaperDownloadLogEN.con_Keyword];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperDownloadLogEN.con_Keyword, objvPaperDownloadLog_Cond.keyword, strComparisonOp_Keyword);
}
if (Object.prototype.hasOwnProperty.call(objvPaperDownloadLog_Cond.dicFldComparisonOp, clsvPaperDownloadLogEN.con_UserName) == true)
{
const strComparisonOp_UserName:string = objvPaperDownloadLog_Cond.dicFldComparisonOp[clsvPaperDownloadLogEN.con_UserName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperDownloadLogEN.con_UserName, objvPaperDownloadLog_Cond.userName, strComparisonOp_UserName);
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objvPaperDownloadLogENS:源对象
 * @param objvPaperDownloadLogENT:目标对象
*/
export function vPaperDownloadLog_CopyObjTo(objvPaperDownloadLogENS: clsvPaperDownloadLogEN , objvPaperDownloadLogENT: clsvPaperDownloadLogEN ): void 
{
objvPaperDownloadLogENT.paperDownloadId = objvPaperDownloadLogENS.paperDownloadId; //PaperDownloadId
objvPaperDownloadLogENT.downloadFile = objvPaperDownloadLogENS.downloadFile; //DownloadFile
objvPaperDownloadLogENT.downloadLink = objvPaperDownloadLogENS.downloadLink; //DownloadLink
objvPaperDownloadLogENT.paperId = objvPaperDownloadLogENS.paperId; //论文Id
objvPaperDownloadLogENT.updUser = objvPaperDownloadLogENS.updUser; //修改人
objvPaperDownloadLogENT.updDate = objvPaperDownloadLogENS.updDate; //修改日期
objvPaperDownloadLogENT.memo = objvPaperDownloadLogENS.memo; //备注
objvPaperDownloadLogENT.paperTitle = objvPaperDownloadLogENS.paperTitle; //论文标题
objvPaperDownloadLogENT.author = objvPaperDownloadLogENS.author; //作者
objvPaperDownloadLogENT.keyword = objvPaperDownloadLogENS.keyword; //关键字
objvPaperDownloadLogENT.userName = objvPaperDownloadLogENS.userName; //用户名
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objvPaperDownloadLogENS:源对象
 * @param objvPaperDownloadLogENT:目标对象
*/
export function vPaperDownloadLog_GetObjFromJsonObj(objvPaperDownloadLogENS: clsvPaperDownloadLogEN): clsvPaperDownloadLogEN 
{
 const objvPaperDownloadLogENT: clsvPaperDownloadLogEN = new clsvPaperDownloadLogEN();
ObjectAssign(objvPaperDownloadLogENT, objvPaperDownloadLogENS);
 return objvPaperDownloadLogENT;
}