
 /**
 * 类名:clsPaperCollectionLogWApi
 * 表名:PaperCollectionLog(01120565)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:46:47
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
 * 论文收藏(PaperCollectionLog)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { clsPaperCollectionLogEN } from "../../L0_Entity/GraduateEduPaper/clsPaperCollectionLogEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { tzDataType } from "../../PubFun/jsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const paperCollectionLog_Controller = "PaperCollectionLogApi";
 export const paperCollectionLog_ConstructorName = "paperCollectionLog";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngPaperCollectionLogId:关键字
 * @returns 对象
 **/
export async function PaperCollectionLog_GetObjByPaperCollectionLogIdAsync(lngPaperCollectionLogId: number): Promise<clsPaperCollectionLogEN>  
{
const strThisFuncName = "GetObjByPaperCollectionLogIdAsync";

if (lngPaperCollectionLogId == 0)
{
  const strMsg = Format("参数:[lngPaperCollectionLogId]不能为空！(In GetObjByPaperCollectionLogIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjByPaperCollectionLogId";
const strUrl = GetWebApiUrl(paperCollectionLog_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", paperCollectionLog_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objPaperCollectionLog = PaperCollectionLog_GetObjFromJsonObj(returnObj);
return objPaperCollectionLog;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperCollectionLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperCollectionLog_ConstructorName, strThisFuncName);
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
export function PaperCollectionLog_SortFun_Defa(a:clsPaperCollectionLogEN , b:clsPaperCollectionLogEN): number 
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
export function PaperCollectionLog_SortFun_Defa_2Fld(a:clsPaperCollectionLogEN , b:clsPaperCollectionLogEN): number 
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
export function PaperCollectionLog_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsPaperCollectionLogEN.con_PaperCollectionLogId:
return (a: clsPaperCollectionLogEN, b: clsPaperCollectionLogEN) => {
return a.paperCollectionLogId-b.paperCollectionLogId;
}
case clsPaperCollectionLogEN.con_PaperId:
return (a: clsPaperCollectionLogEN, b: clsPaperCollectionLogEN) => {
return a.paperId.localeCompare(b.paperId);
}
case clsPaperCollectionLogEN.con_UpdUser:
return (a: clsPaperCollectionLogEN, b: clsPaperCollectionLogEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsPaperCollectionLogEN.con_UpdDate:
return (a: clsPaperCollectionLogEN, b: clsPaperCollectionLogEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsPaperCollectionLogEN.con_Meno:
return (a: clsPaperCollectionLogEN, b: clsPaperCollectionLogEN) => {
return a.meno.localeCompare(b.meno);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[PaperCollectionLog]中不存在！(in ${ paperCollectionLog_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsPaperCollectionLogEN.con_PaperCollectionLogId:
return (a: clsPaperCollectionLogEN, b: clsPaperCollectionLogEN) => {
return b.paperCollectionLogId-a.paperCollectionLogId;
}
case clsPaperCollectionLogEN.con_PaperId:
return (a: clsPaperCollectionLogEN, b: clsPaperCollectionLogEN) => {
return b.paperId.localeCompare(a.paperId);
}
case clsPaperCollectionLogEN.con_UpdUser:
return (a: clsPaperCollectionLogEN, b: clsPaperCollectionLogEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsPaperCollectionLogEN.con_UpdDate:
return (a: clsPaperCollectionLogEN, b: clsPaperCollectionLogEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsPaperCollectionLogEN.con_Meno:
return (a: clsPaperCollectionLogEN, b: clsPaperCollectionLogEN) => {
return b.meno.localeCompare(a.meno);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[PaperCollectionLog]中不存在！(in ${ paperCollectionLog_ConstructorName}.${ strThisFuncName})`;
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
export async function PaperCollectionLog_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsPaperCollectionLogEN.con_PaperCollectionLogId:
return (obj: clsPaperCollectionLogEN) => {
return obj.paperCollectionLogId === value;
}
case clsPaperCollectionLogEN.con_PaperId:
return (obj: clsPaperCollectionLogEN) => {
return obj.paperId === value;
}
case clsPaperCollectionLogEN.con_UpdUser:
return (obj: clsPaperCollectionLogEN) => {
return obj.updUser === value;
}
case clsPaperCollectionLogEN.con_UpdDate:
return (obj: clsPaperCollectionLogEN) => {
return obj.updDate === value;
}
case clsPaperCollectionLogEN.con_Meno:
return (obj: clsPaperCollectionLogEN) => {
return obj.meno === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[PaperCollectionLog]中不存在！(in ${ paperCollectionLog_ConstructorName}.${ strThisFuncName})`;
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
export async function PaperCollectionLog_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(paperCollectionLog_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperCollectionLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperCollectionLog_ConstructorName, strThisFuncName);
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
export async function PaperCollectionLog_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(paperCollectionLog_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperCollectionLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperCollectionLog_ConstructorName, strThisFuncName);
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
export async function PaperCollectionLog_GetFirstObjAsync(strWhereCond: string): Promise<clsPaperCollectionLogEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(paperCollectionLog_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", paperCollectionLog_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objPaperCollectionLog = PaperCollectionLog_GetObjFromJsonObj(returnObj);
return objPaperCollectionLog;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperCollectionLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperCollectionLog_ConstructorName, strThisFuncName);
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
export async function PaperCollectionLog_GetObjLstAsync(strWhereCond: string): Promise<Array<clsPaperCollectionLogEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(paperCollectionLog_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", paperCollectionLog_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = PaperCollectionLog_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperCollectionLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperCollectionLog_ConstructorName, strThisFuncName);
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
export async function PaperCollectionLog_GetObjLstByPaperCollectionLogIdLstAsync(arrPaperCollectionLogId: Array<string>): Promise<Array<clsPaperCollectionLogEN>>  
{
const strThisFuncName = "GetObjLstByPaperCollectionLogIdLstAsync";
const strAction = "GetObjLstByPaperCollectionLogIdLst";
const strUrl = GetWebApiUrl(paperCollectionLog_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrPaperCollectionLogId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", paperCollectionLog_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = PaperCollectionLog_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperCollectionLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperCollectionLog_ConstructorName, strThisFuncName);
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
export async function PaperCollectionLog_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsPaperCollectionLogEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(paperCollectionLog_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", paperCollectionLog_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = PaperCollectionLog_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperCollectionLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperCollectionLog_ConstructorName, strThisFuncName);
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
export async function PaperCollectionLog_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsPaperCollectionLogEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(paperCollectionLog_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", paperCollectionLog_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = PaperCollectionLog_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperCollectionLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperCollectionLog_ConstructorName, strThisFuncName);
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
export async function PaperCollectionLog_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(paperCollectionLog_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperCollectionLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperCollectionLog_ConstructorName, strThisFuncName);
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
export async function PaperCollectionLog_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsPaperCollectionLogEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(paperCollectionLog_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", paperCollectionLog_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = PaperCollectionLog_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperCollectionLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperCollectionLog_ConstructorName, strThisFuncName);
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
 * @param lngPaperCollectionLogId:关键字
 * @returns 获取删除的结果
 **/
export async function PaperCollectionLog_DelRecordAsync(lngPaperCollectionLogId: number): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(paperCollectionLog_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, lngPaperCollectionLogId);
try
{
const response = await axios.delete(strUrl,
{
params: { "Id": lngPaperCollectionLogId, }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperCollectionLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperCollectionLog_ConstructorName, strThisFuncName);
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
 * @param arrPaperCollectionLogId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function PaperCollectionLog_DelPaperCollectionLogsAsync(arrPaperCollectionLogId: Array<string>): Promise<number> 
{
const strThisFuncName = "DelPaperCollectionLogsAsync";
const strAction = "DelPaperCollectionLogs";
const strUrl = GetWebApiUrl(paperCollectionLog_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrPaperCollectionLogId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperCollectionLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperCollectionLog_ConstructorName, strThisFuncName);
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
export async function PaperCollectionLog_DelPaperCollectionLogsByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "DelPaperCollectionLogsByCondAsync";
const strAction = "DelPaperCollectionLogsByCond";
const strUrl = GetWebApiUrl(paperCollectionLog_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperCollectionLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperCollectionLog_ConstructorName, strThisFuncName);
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
 * @param objPaperCollectionLogEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function PaperCollectionLog_AddNewRecordAsync(objPaperCollectionLogEN: clsPaperCollectionLogEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objPaperCollectionLogEN);
const strUrl = GetWebApiUrl(paperCollectionLog_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPaperCollectionLogEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperCollectionLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperCollectionLog_ConstructorName, strThisFuncName);
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
 * @param objPaperCollectionLogEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function PaperCollectionLog_AddNewRecordWithReturnKeyAsync(objPaperCollectionLogEN: clsPaperCollectionLogEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(paperCollectionLog_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPaperCollectionLogEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperCollectionLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperCollectionLog_ConstructorName, strThisFuncName);
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
 * @param objPaperCollectionLogEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function PaperCollectionLog_AddNewRecordWithReturnKey(objPaperCollectionLogEN: clsPaperCollectionLogEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objPaperCollectionLogEN.paperCollectionLogId === null || objPaperCollectionLogEN.paperCollectionLogId === 0)
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(paperCollectionLog_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPaperCollectionLogEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperCollectionLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperCollectionLog_ConstructorName, strThisFuncName);
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
 * @param objPaperCollectionLogEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function PaperCollectionLog_UpdateRecordAsync(objPaperCollectionLogEN: clsPaperCollectionLogEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objPaperCollectionLogEN.sf_UpdFldSetStr === undefined || objPaperCollectionLogEN.sf_UpdFldSetStr === null || objPaperCollectionLogEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objPaperCollectionLogEN.paperCollectionLogId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(paperCollectionLog_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPaperCollectionLogEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperCollectionLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperCollectionLog_ConstructorName, strThisFuncName);
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
 * @param objPaperCollectionLogEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function PaperCollectionLog_UpdateWithConditionAsync(objPaperCollectionLogEN: clsPaperCollectionLogEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objPaperCollectionLogEN.sf_UpdFldSetStr === undefined || objPaperCollectionLogEN.sf_UpdFldSetStr === null || objPaperCollectionLogEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objPaperCollectionLogEN.paperCollectionLogId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(paperCollectionLog_Controller, strAction);
objPaperCollectionLogEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objPaperCollectionLogEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperCollectionLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperCollectionLog_ConstructorName, strThisFuncName);
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
export async function PaperCollectionLog_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(paperCollectionLog_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperCollectionLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperCollectionLog_ConstructorName, strThisFuncName);
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
export async function PaperCollectionLog_IsExist(lngPaperCollectionLogId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(paperCollectionLog_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperCollectionLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperCollectionLog_ConstructorName, strThisFuncName);
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
export async function PaperCollectionLog_IsExistAsync(lngPaperCollectionLogId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(paperCollectionLog_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperCollectionLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperCollectionLog_ConstructorName, strThisFuncName);
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
export async function PaperCollectionLog_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(paperCollectionLog_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperCollectionLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperCollectionLog_ConstructorName, strThisFuncName);
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
export async function PaperCollectionLog_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(paperCollectionLog_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperCollectionLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperCollectionLog_ConstructorName, strThisFuncName);
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
export function PaperCollectionLog_GetWebApiUrl(strController: string, strAction: string): string {
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
export function PaperCollectionLog_CheckPropertyNew(pobjPaperCollectionLogEN: clsPaperCollectionLogEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjPaperCollectionLogEN.updUser) === true )
{
 throw new Error("(errid:Watl000058)字段[修改人]不能为空(In 论文收藏)!(clsPaperCollectionLogBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjPaperCollectionLogEN.paperId) == false && GetStrLen(pobjPaperCollectionLogEN.paperId) > 8)
{
 throw new Error("(errid:Watl000059)字段[论文Id(paperId)]的长度不能超过8(In 论文收藏(PaperCollectionLog))!值:$(pobjPaperCollectionLogEN.paperId)(clsPaperCollectionLogBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperCollectionLogEN.updUser) == false && GetStrLen(pobjPaperCollectionLogEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 论文收藏(PaperCollectionLog))!值:$(pobjPaperCollectionLogEN.updUser)(clsPaperCollectionLogBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperCollectionLogEN.updDate) == false && GetStrLen(pobjPaperCollectionLogEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 论文收藏(PaperCollectionLog))!值:$(pobjPaperCollectionLogEN.updDate)(clsPaperCollectionLogBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperCollectionLogEN.meno) == false && GetStrLen(pobjPaperCollectionLogEN.meno) > 2000)
{
 throw new Error("(errid:Watl000059)字段[备注(meno)]的长度不能超过2000(In 论文收藏(PaperCollectionLog))!值:$(pobjPaperCollectionLogEN.meno)(clsPaperCollectionLogBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null != pobjPaperCollectionLogEN.paperCollectionLogId && undefined !== pobjPaperCollectionLogEN.paperCollectionLogId && tzDataType.isNumber(pobjPaperCollectionLogEN.paperCollectionLogId) === false)
{
 throw new Error("(errid:Watl000060)字段[论文收藏Id(paperCollectionLogId)]的值:[$(pobjPaperCollectionLogEN.paperCollectionLogId)], 非法，应该为数值型(In 论文收藏(PaperCollectionLog))!(clsPaperCollectionLogBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperCollectionLogEN.paperId) == false && undefined !== pobjPaperCollectionLogEN.paperId && tzDataType.isString(pobjPaperCollectionLogEN.paperId) === false)
{
 throw new Error("(errid:Watl000060)字段[论文Id(paperId)]的值:[$(pobjPaperCollectionLogEN.paperId)], 非法，应该为字符型(In 论文收藏(PaperCollectionLog))!(clsPaperCollectionLogBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperCollectionLogEN.updUser) == false && undefined !== pobjPaperCollectionLogEN.updUser && tzDataType.isString(pobjPaperCollectionLogEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjPaperCollectionLogEN.updUser)], 非法，应该为字符型(In 论文收藏(PaperCollectionLog))!(clsPaperCollectionLogBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperCollectionLogEN.updDate) == false && undefined !== pobjPaperCollectionLogEN.updDate && tzDataType.isString(pobjPaperCollectionLogEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjPaperCollectionLogEN.updDate)], 非法，应该为字符型(In 论文收藏(PaperCollectionLog))!(clsPaperCollectionLogBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperCollectionLogEN.meno) == false && undefined !== pobjPaperCollectionLogEN.meno && tzDataType.isString(pobjPaperCollectionLogEN.meno) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(meno)]的值:[$(pobjPaperCollectionLogEN.meno)], 非法，应该为字符型(In 论文收藏(PaperCollectionLog))!(clsPaperCollectionLogBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjPaperCollectionLogEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function PaperCollectionLog_CheckProperty4Update (pobjPaperCollectionLogEN: clsPaperCollectionLogEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjPaperCollectionLogEN.paperId) == false && GetStrLen(pobjPaperCollectionLogEN.paperId) > 8)
{
 throw new Error("(errid:Watl000062)字段[论文Id(paperId)]的长度不能超过8(In 论文收藏(PaperCollectionLog))!值:$(pobjPaperCollectionLogEN.paperId)(clsPaperCollectionLogBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperCollectionLogEN.updUser) == false && GetStrLen(pobjPaperCollectionLogEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 论文收藏(PaperCollectionLog))!值:$(pobjPaperCollectionLogEN.updUser)(clsPaperCollectionLogBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperCollectionLogEN.updDate) == false && GetStrLen(pobjPaperCollectionLogEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 论文收藏(PaperCollectionLog))!值:$(pobjPaperCollectionLogEN.updDate)(clsPaperCollectionLogBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperCollectionLogEN.meno) == false && GetStrLen(pobjPaperCollectionLogEN.meno) > 2000)
{
 throw new Error("(errid:Watl000062)字段[备注(meno)]的长度不能超过2000(In 论文收藏(PaperCollectionLog))!值:$(pobjPaperCollectionLogEN.meno)(clsPaperCollectionLogBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null != pobjPaperCollectionLogEN.paperCollectionLogId && undefined !== pobjPaperCollectionLogEN.paperCollectionLogId && tzDataType.isNumber(pobjPaperCollectionLogEN.paperCollectionLogId) === false)
{
 throw new Error("(errid:Watl000063)字段[论文收藏Id(paperCollectionLogId)]的值:[$(pobjPaperCollectionLogEN.paperCollectionLogId)], 非法，应该为数值型(In 论文收藏(PaperCollectionLog))!(clsPaperCollectionLogBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperCollectionLogEN.paperId) == false && undefined !== pobjPaperCollectionLogEN.paperId && tzDataType.isString(pobjPaperCollectionLogEN.paperId) === false)
{
 throw new Error("(errid:Watl000063)字段[论文Id(paperId)]的值:[$(pobjPaperCollectionLogEN.paperId)], 非法，应该为字符型(In 论文收藏(PaperCollectionLog))!(clsPaperCollectionLogBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperCollectionLogEN.updUser) == false && undefined !== pobjPaperCollectionLogEN.updUser && tzDataType.isString(pobjPaperCollectionLogEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjPaperCollectionLogEN.updUser)], 非法，应该为字符型(In 论文收藏(PaperCollectionLog))!(clsPaperCollectionLogBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperCollectionLogEN.updDate) == false && undefined !== pobjPaperCollectionLogEN.updDate && tzDataType.isString(pobjPaperCollectionLogEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjPaperCollectionLogEN.updDate)], 非法，应该为字符型(In 论文收藏(PaperCollectionLog))!(clsPaperCollectionLogBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperCollectionLogEN.meno) == false && undefined !== pobjPaperCollectionLogEN.meno && tzDataType.isString(pobjPaperCollectionLogEN.meno) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(meno)]的值:[$(pobjPaperCollectionLogEN.meno)], 非法，应该为字符型(In 论文收藏(PaperCollectionLog))!(clsPaperCollectionLogBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjPaperCollectionLogEN.paperCollectionLogId 
 || pobjPaperCollectionLogEN.paperCollectionLogId != null && pobjPaperCollectionLogEN.paperCollectionLogId.toString()  ===  "")
{
 throw new Error("(errid:Watl000064)字段[论文收藏Id]不能为空(In 论文收藏)!(clsPaperCollectionLogBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjPaperCollectionLogEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function PaperCollectionLog_GetJSONStrByObj (pobjPaperCollectionLogEN: clsPaperCollectionLogEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjPaperCollectionLogEN.sf_UpdFldSetStr = pobjPaperCollectionLogEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjPaperCollectionLogEN);
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
export function PaperCollectionLog_GetObjLstByJSONStr (strJSON: string): Array<clsPaperCollectionLogEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrPaperCollectionLogObjLst = new Array<clsPaperCollectionLogEN>();
if (strJSON === "")
{
return arrPaperCollectionLogObjLst;
}
try
{
arrPaperCollectionLogObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrPaperCollectionLogObjLst;
}
return arrPaperCollectionLogObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrPaperCollectionLogObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function PaperCollectionLog_GetObjLstByJSONObjLst (arrPaperCollectionLogObjLstS: Array<clsPaperCollectionLogEN>): Array<clsPaperCollectionLogEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrPaperCollectionLogObjLst = new Array<clsPaperCollectionLogEN>();
for (const objInFor of arrPaperCollectionLogObjLstS) {
const obj1 = PaperCollectionLog_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrPaperCollectionLogObjLst.push(obj1);
}
return arrPaperCollectionLogObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function PaperCollectionLog_GetObjByJSONStr (strJSON: string): clsPaperCollectionLogEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjPaperCollectionLogEN = new clsPaperCollectionLogEN();
if (strJSON === "")
{
return pobjPaperCollectionLogEN;
}
try
{
pobjPaperCollectionLogEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjPaperCollectionLogEN;
}
return pobjPaperCollectionLogEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function PaperCollectionLog_GetCombineCondition(objPaperCollectionLog_Cond: clsPaperCollectionLogEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objPaperCollectionLog_Cond.dicFldComparisonOp, clsPaperCollectionLogEN.con_PaperCollectionLogId) == true)
{
const strComparisonOp_PaperCollectionLogId:string = objPaperCollectionLog_Cond.dicFldComparisonOp[clsPaperCollectionLogEN.con_PaperCollectionLogId];
strWhereCond += Format(" And {0} {2} {1}", clsPaperCollectionLogEN.con_PaperCollectionLogId, objPaperCollectionLog_Cond.paperCollectionLogId, strComparisonOp_PaperCollectionLogId);
}
if (Object.prototype.hasOwnProperty.call(objPaperCollectionLog_Cond.dicFldComparisonOp, clsPaperCollectionLogEN.con_PaperId) == true)
{
const strComparisonOp_PaperId:string = objPaperCollectionLog_Cond.dicFldComparisonOp[clsPaperCollectionLogEN.con_PaperId];
strWhereCond += Format(" And {0} {2} '{1}'", clsPaperCollectionLogEN.con_PaperId, objPaperCollectionLog_Cond.paperId, strComparisonOp_PaperId);
}
if (Object.prototype.hasOwnProperty.call(objPaperCollectionLog_Cond.dicFldComparisonOp, clsPaperCollectionLogEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objPaperCollectionLog_Cond.dicFldComparisonOp[clsPaperCollectionLogEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsPaperCollectionLogEN.con_UpdUser, objPaperCollectionLog_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objPaperCollectionLog_Cond.dicFldComparisonOp, clsPaperCollectionLogEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objPaperCollectionLog_Cond.dicFldComparisonOp[clsPaperCollectionLogEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsPaperCollectionLogEN.con_UpdDate, objPaperCollectionLog_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objPaperCollectionLog_Cond.dicFldComparisonOp, clsPaperCollectionLogEN.con_Meno) == true)
{
const strComparisonOp_Meno:string = objPaperCollectionLog_Cond.dicFldComparisonOp[clsPaperCollectionLogEN.con_Meno];
strWhereCond += Format(" And {0} {2} '{1}'", clsPaperCollectionLogEN.con_Meno, objPaperCollectionLog_Cond.meno, strComparisonOp_Meno);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--PaperCollectionLog(论文收藏),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param lngPaperCollectionLogId: 论文收藏Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function PaperCollectionLog_GetUniCondStr_PaperCollectionLogId(objPaperCollectionLogEN: clsPaperCollectionLogEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and PaperCollectionLogId = '{0}'", objPaperCollectionLogEN.paperCollectionLogId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--PaperCollectionLog(论文收藏),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param lngPaperCollectionLogId: 论文收藏Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function PaperCollectionLog_GetUniCondStr4Update_PaperCollectionLogId(objPaperCollectionLogEN: clsPaperCollectionLogEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and PaperCollectionLogId <> '{0}'", objPaperCollectionLogEN.paperCollectionLogId);
 strWhereCond +=  Format(" and PaperCollectionLogId = '{0}'", objPaperCollectionLogEN.paperCollectionLogId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objPaperCollectionLogENS:源对象
 * @param objPaperCollectionLogENT:目标对象
*/
export function PaperCollectionLog_CopyObjTo(objPaperCollectionLogENS: clsPaperCollectionLogEN , objPaperCollectionLogENT: clsPaperCollectionLogEN ): void 
{
objPaperCollectionLogENT.paperCollectionLogId = objPaperCollectionLogENS.paperCollectionLogId; //论文收藏Id
objPaperCollectionLogENT.paperId = objPaperCollectionLogENS.paperId; //论文Id
objPaperCollectionLogENT.updUser = objPaperCollectionLogENS.updUser; //修改人
objPaperCollectionLogENT.updDate = objPaperCollectionLogENS.updDate; //修改日期
objPaperCollectionLogENT.meno = objPaperCollectionLogENS.meno; //备注
objPaperCollectionLogENT.sf_UpdFldSetStr = objPaperCollectionLogENS.updFldString; //sf_UpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objPaperCollectionLogENS:源对象
 * @param objPaperCollectionLogENT:目标对象
*/
export function PaperCollectionLog_GetObjFromJsonObj(objPaperCollectionLogENS: clsPaperCollectionLogEN): clsPaperCollectionLogEN 
{
 const objPaperCollectionLogENT: clsPaperCollectionLogEN = new clsPaperCollectionLogEN();
ObjectAssign(objPaperCollectionLogENT, objPaperCollectionLogENS);
 return objPaperCollectionLogENT;
}