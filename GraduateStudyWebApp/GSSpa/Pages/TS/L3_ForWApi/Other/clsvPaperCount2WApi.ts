
 /**
 * 类名:clsvPaperCount2WApi
 * 表名:vPaperCount2(01120596)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 12:02:34
 * 生成者:pyf
 * 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:其他(Other)
 * 框架-层名:WA_访问层(TS)(WA_Access)
 * 编程语言:TypeScript
 * 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
   *      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 **/

/**
 * vPaperCount2(vPaperCount2)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { clsvPaperCount2EN } from "../../L0_Entity/Other/clsvPaperCount2EN.js";
import { BindDdl_ObjLstInDiv_V, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const vPaperCount2_Controller = "vPaperCount2Api";
 export const vPaperCount2_ConstructorName = "vPaperCount2";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strPaperId:关键字
 * @returns 对象
 **/
export async function vPaperCount2_GetObjByPaperIdAsync(strPaperId: string): Promise<clsvPaperCount2EN>  
{
const strThisFuncName = "GetObjByPaperIdAsync";

if (IsNullOrEmpty(strPaperId) == true)
{
  const strMsg = Format("参数:[strPaperId]不能为空！(In GetObjByPaperIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strPaperId.length != 8)
{
const strMsg = Format("缓存分类变量:[strPaperId]的长度:[{0}]不正确！", strPaperId.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByPaperId";
const strUrl = GetWebApiUrl(vPaperCount2_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strPaperId": strPaperId,
}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObj = data.returnObj;
if (returnObj == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vPaperCount2_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvPaperCount2 = vPaperCount2_GetObjFromJsonObj(returnObj);
return objvPaperCount2;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperCount2_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperCount2_ConstructorName, strThisFuncName);
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
export function vPaperCount2_SortFun_Defa(a:clsvPaperCount2EN , b:clsvPaperCount2EN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.paperId.localeCompare(b.paperId);
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
export function vPaperCount2_SortFun_Defa_2Fld(a:clsvPaperCount2EN , b:clsvPaperCount2EN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.pcount == b.pcount) return a.okCount - b.okCount;
else return a.pcount - b.pcount;
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
export function vPaperCount2_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsvPaperCount2EN.con_PaperId:
return (a: clsvPaperCount2EN, b: clsvPaperCount2EN) => {
return a.paperId.localeCompare(b.paperId);
}
case clsvPaperCount2EN.con_Pcount:
return (a: clsvPaperCount2EN, b: clsvPaperCount2EN) => {
return a.pcount-b.pcount;
}
case clsvPaperCount2EN.con_OkCount:
return (a: clsvPaperCount2EN, b: clsvPaperCount2EN) => {
return a.okCount-b.okCount;
}
case clsvPaperCount2EN.con_AppraiseCount:
return (a: clsvPaperCount2EN, b: clsvPaperCount2EN) => {
return a.appraiseCount-b.appraiseCount;
}
case clsvPaperCount2EN.con_CollectionCount:
return (a: clsvPaperCount2EN, b: clsvPaperCount2EN) => {
return a.collectionCount-b.collectionCount;
}
case clsvPaperCount2EN.con_DownloadCount:
return (a: clsvPaperCount2EN, b: clsvPaperCount2EN) => {
return a.downloadCount-b.downloadCount;
}
case clsvPaperCount2EN.con_score:
return (a: clsvPaperCount2EN, b: clsvPaperCount2EN) => {
return a.score-b.score;
}
case clsvPaperCount2EN.con_AttachmentCount:
return (a: clsvPaperCount2EN, b: clsvPaperCount2EN) => {
return a.attachmentCount-b.attachmentCount;
}
case clsvPaperCount2EN.con_UpdUser:
return (a: clsvPaperCount2EN, b: clsvPaperCount2EN) => {
return a.updUser.localeCompare(b.updUser);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vPaperCount2]中不存在！(in ${ vPaperCount2_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsvPaperCount2EN.con_PaperId:
return (a: clsvPaperCount2EN, b: clsvPaperCount2EN) => {
return b.paperId.localeCompare(a.paperId);
}
case clsvPaperCount2EN.con_Pcount:
return (a: clsvPaperCount2EN, b: clsvPaperCount2EN) => {
return b.pcount-a.pcount;
}
case clsvPaperCount2EN.con_OkCount:
return (a: clsvPaperCount2EN, b: clsvPaperCount2EN) => {
return b.okCount-a.okCount;
}
case clsvPaperCount2EN.con_AppraiseCount:
return (a: clsvPaperCount2EN, b: clsvPaperCount2EN) => {
return b.appraiseCount-a.appraiseCount;
}
case clsvPaperCount2EN.con_CollectionCount:
return (a: clsvPaperCount2EN, b: clsvPaperCount2EN) => {
return b.collectionCount-a.collectionCount;
}
case clsvPaperCount2EN.con_DownloadCount:
return (a: clsvPaperCount2EN, b: clsvPaperCount2EN) => {
return b.downloadCount-a.downloadCount;
}
case clsvPaperCount2EN.con_score:
return (a: clsvPaperCount2EN, b: clsvPaperCount2EN) => {
return b.score-a.score;
}
case clsvPaperCount2EN.con_AttachmentCount:
return (a: clsvPaperCount2EN, b: clsvPaperCount2EN) => {
return b.attachmentCount-a.attachmentCount;
}
case clsvPaperCount2EN.con_UpdUser:
return (a: clsvPaperCount2EN, b: clsvPaperCount2EN) => {
return b.updUser.localeCompare(a.updUser);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vPaperCount2]中不存在！(in ${ vPaperCount2_ConstructorName}.${ strThisFuncName})`;
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
export async function vPaperCount2_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsvPaperCount2EN.con_PaperId:
return (obj: clsvPaperCount2EN) => {
return obj.paperId === value;
}
case clsvPaperCount2EN.con_Pcount:
return (obj: clsvPaperCount2EN) => {
return obj.pcount === value;
}
case clsvPaperCount2EN.con_OkCount:
return (obj: clsvPaperCount2EN) => {
return obj.okCount === value;
}
case clsvPaperCount2EN.con_AppraiseCount:
return (obj: clsvPaperCount2EN) => {
return obj.appraiseCount === value;
}
case clsvPaperCount2EN.con_CollectionCount:
return (obj: clsvPaperCount2EN) => {
return obj.collectionCount === value;
}
case clsvPaperCount2EN.con_DownloadCount:
return (obj: clsvPaperCount2EN) => {
return obj.downloadCount === value;
}
case clsvPaperCount2EN.con_score:
return (obj: clsvPaperCount2EN) => {
return obj.score === value;
}
case clsvPaperCount2EN.con_AttachmentCount:
return (obj: clsvPaperCount2EN) => {
return obj.attachmentCount === value;
}
case clsvPaperCount2EN.con_UpdUser:
return (obj: clsvPaperCount2EN) => {
return obj.updUser === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vPaperCount2]中不存在！(in ${ vPaperCount2_ConstructorName}.${ strThisFuncName})`;
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
export async function vPaperCount2_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vPaperCount2_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperCount2_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperCount2_ConstructorName, strThisFuncName);
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
export async function vPaperCount2_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vPaperCount2_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperCount2_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperCount2_ConstructorName, strThisFuncName);
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
export async function vPaperCount2_GetFirstObjAsync(strWhereCond: string): Promise<clsvPaperCount2EN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(vPaperCount2_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vPaperCount2_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvPaperCount2 = vPaperCount2_GetObjFromJsonObj(returnObj);
return objvPaperCount2;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperCount2_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperCount2_ConstructorName, strThisFuncName);
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
export async function vPaperCount2_GetObjLstAsync(strWhereCond: string): Promise<Array<clsvPaperCount2EN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(vPaperCount2_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vPaperCount2_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vPaperCount2_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperCount2_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperCount2_ConstructorName, strThisFuncName);
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
 * @param arrPaperId:关键字列表
 * @returns 对象列表
 **/
export async function vPaperCount2_GetObjLstByPaperIdLstAsync(arrPaperId: Array<string>): Promise<Array<clsvPaperCount2EN>>  
{
const strThisFuncName = "GetObjLstByPaperIdLstAsync";
const strAction = "GetObjLstByPaperIdLst";
const strUrl = GetWebApiUrl(vPaperCount2_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrPaperId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vPaperCount2_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vPaperCount2_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperCount2_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperCount2_ConstructorName, strThisFuncName);
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
export async function vPaperCount2_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsvPaperCount2EN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(vPaperCount2_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vPaperCount2_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vPaperCount2_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperCount2_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperCount2_ConstructorName, strThisFuncName);
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
export async function vPaperCount2_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsvPaperCount2EN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vPaperCount2_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vPaperCount2_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vPaperCount2_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperCount2_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperCount2_ConstructorName, strThisFuncName);
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
export async function vPaperCount2_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vPaperCount2_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperCount2_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperCount2_ConstructorName, strThisFuncName);
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
export async function vPaperCount2_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsvPaperCount2EN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(vPaperCount2_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vPaperCount2_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vPaperCount2_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperCount2_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperCount2_ConstructorName, strThisFuncName);
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
export async function vPaperCount2_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(vPaperCount2_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperCount2_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperCount2_ConstructorName, strThisFuncName);
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
 * @param strPaperId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function vPaperCount2_IsExist(strPaperId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vPaperCount2_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"PaperId": strPaperId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperCount2_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperCount2_ConstructorName, strThisFuncName);
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
 * @param strPaperId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function vPaperCount2_IsExistAsync(strPaperId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vPaperCount2_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strPaperId": strPaperId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperCount2_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperCount2_ConstructorName, strThisFuncName);
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
export async function vPaperCount2_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(vPaperCount2_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperCount2_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperCount2_ConstructorName, strThisFuncName);
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
export function vPaperCount2_GetWebApiUrl(strController: string, strAction: string): string {
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
export function vPaperCount2_GetJSONStrByObj (pobjvPaperCount2EN: clsvPaperCount2EN): string
{
const strThisFuncName = "GetJSONStrByObj";
let strJson = "";
try
{
strJson = JSON.stringify(pobjvPaperCount2EN);
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
export function vPaperCount2_GetObjLstByJSONStr (strJSON: string): Array<clsvPaperCount2EN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrvPaperCount2ObjLst = new Array<clsvPaperCount2EN>();
if (strJSON === "")
{
return arrvPaperCount2ObjLst;
}
try
{
arrvPaperCount2ObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvPaperCount2ObjLst;
}
return arrvPaperCount2ObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrvPaperCount2ObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function vPaperCount2_GetObjLstByJSONObjLst (arrvPaperCount2ObjLstS: Array<clsvPaperCount2EN>): Array<clsvPaperCount2EN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrvPaperCount2ObjLst = new Array<clsvPaperCount2EN>();
for (const objInFor of arrvPaperCount2ObjLstS) {
const obj1 = vPaperCount2_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrvPaperCount2ObjLst.push(obj1);
}
return arrvPaperCount2ObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vPaperCount2_GetObjByJSONStr (strJSON: string): clsvPaperCount2EN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjvPaperCount2EN = new clsvPaperCount2EN();
if (strJSON === "")
{
return pobjvPaperCount2EN;
}
try
{
pobjvPaperCount2EN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvPaperCount2EN;
}
return pobjvPaperCount2EN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function vPaperCount2_GetCombineCondition(objvPaperCount2_Cond: clsvPaperCount2EN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objvPaperCount2_Cond.dicFldComparisonOp, clsvPaperCount2EN.con_PaperId) == true)
{
const strComparisonOp_PaperId:string = objvPaperCount2_Cond.dicFldComparisonOp[clsvPaperCount2EN.con_PaperId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperCount2EN.con_PaperId, objvPaperCount2_Cond.paperId, strComparisonOp_PaperId);
}
if (Object.prototype.hasOwnProperty.call(objvPaperCount2_Cond.dicFldComparisonOp, clsvPaperCount2EN.con_Pcount) == true)
{
const strComparisonOp_Pcount:string = objvPaperCount2_Cond.dicFldComparisonOp[clsvPaperCount2EN.con_Pcount];
strWhereCond += Format(" And {0} {2} {1}", clsvPaperCount2EN.con_Pcount, objvPaperCount2_Cond.pcount, strComparisonOp_Pcount);
}
if (Object.prototype.hasOwnProperty.call(objvPaperCount2_Cond.dicFldComparisonOp, clsvPaperCount2EN.con_OkCount) == true)
{
const strComparisonOp_OkCount:string = objvPaperCount2_Cond.dicFldComparisonOp[clsvPaperCount2EN.con_OkCount];
strWhereCond += Format(" And {0} {2} {1}", clsvPaperCount2EN.con_OkCount, objvPaperCount2_Cond.okCount, strComparisonOp_OkCount);
}
if (Object.prototype.hasOwnProperty.call(objvPaperCount2_Cond.dicFldComparisonOp, clsvPaperCount2EN.con_AppraiseCount) == true)
{
const strComparisonOp_AppraiseCount:string = objvPaperCount2_Cond.dicFldComparisonOp[clsvPaperCount2EN.con_AppraiseCount];
strWhereCond += Format(" And {0} {2} {1}", clsvPaperCount2EN.con_AppraiseCount, objvPaperCount2_Cond.appraiseCount, strComparisonOp_AppraiseCount);
}
if (Object.prototype.hasOwnProperty.call(objvPaperCount2_Cond.dicFldComparisonOp, clsvPaperCount2EN.con_CollectionCount) == true)
{
const strComparisonOp_CollectionCount:string = objvPaperCount2_Cond.dicFldComparisonOp[clsvPaperCount2EN.con_CollectionCount];
strWhereCond += Format(" And {0} {2} {1}", clsvPaperCount2EN.con_CollectionCount, objvPaperCount2_Cond.collectionCount, strComparisonOp_CollectionCount);
}
if (Object.prototype.hasOwnProperty.call(objvPaperCount2_Cond.dicFldComparisonOp, clsvPaperCount2EN.con_DownloadCount) == true)
{
const strComparisonOp_DownloadCount:string = objvPaperCount2_Cond.dicFldComparisonOp[clsvPaperCount2EN.con_DownloadCount];
strWhereCond += Format(" And {0} {2} {1}", clsvPaperCount2EN.con_DownloadCount, objvPaperCount2_Cond.downloadCount, strComparisonOp_DownloadCount);
}
if (Object.prototype.hasOwnProperty.call(objvPaperCount2_Cond.dicFldComparisonOp, clsvPaperCount2EN.con_score) == true)
{
const strComparisonOp_score:string = objvPaperCount2_Cond.dicFldComparisonOp[clsvPaperCount2EN.con_score];
strWhereCond += Format(" And {0} {2} {1}", clsvPaperCount2EN.con_score, objvPaperCount2_Cond.score, strComparisonOp_score);
}
if (Object.prototype.hasOwnProperty.call(objvPaperCount2_Cond.dicFldComparisonOp, clsvPaperCount2EN.con_AttachmentCount) == true)
{
const strComparisonOp_AttachmentCount:string = objvPaperCount2_Cond.dicFldComparisonOp[clsvPaperCount2EN.con_AttachmentCount];
strWhereCond += Format(" And {0} {2} {1}", clsvPaperCount2EN.con_AttachmentCount, objvPaperCount2_Cond.attachmentCount, strComparisonOp_AttachmentCount);
}
if (Object.prototype.hasOwnProperty.call(objvPaperCount2_Cond.dicFldComparisonOp, clsvPaperCount2EN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objvPaperCount2_Cond.dicFldComparisonOp[clsvPaperCount2EN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperCount2EN.con_UpdUser, objvPaperCount2_Cond.updUser, strComparisonOp_UpdUser);
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objvPaperCount2ENS:源对象
 * @param objvPaperCount2ENT:目标对象
*/
export function vPaperCount2_CopyObjTo(objvPaperCount2ENS: clsvPaperCount2EN , objvPaperCount2ENT: clsvPaperCount2EN ): void 
{
objvPaperCount2ENT.paperId = objvPaperCount2ENS.paperId; //论文Id
objvPaperCount2ENT.pcount = objvPaperCount2ENS.pcount; //读写数
objvPaperCount2ENT.okCount = objvPaperCount2ENS.okCount; //点赞统计
objvPaperCount2ENT.appraiseCount = objvPaperCount2ENS.appraiseCount; //评论数
objvPaperCount2ENT.collectionCount = objvPaperCount2ENS.collectionCount; //收藏数
objvPaperCount2ENT.downloadCount = objvPaperCount2ENS.downloadCount; //下载数
objvPaperCount2ENT.score = objvPaperCount2ENS.score; //评分
objvPaperCount2ENT.attachmentCount = objvPaperCount2ENS.attachmentCount; //附件计数
objvPaperCount2ENT.updUser = objvPaperCount2ENS.updUser; //修改人
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objvPaperCount2ENS:源对象
 * @param objvPaperCount2ENT:目标对象
*/
export function vPaperCount2_GetObjFromJsonObj(objvPaperCount2ENS: clsvPaperCount2EN): clsvPaperCount2EN 
{
 const objvPaperCount2ENT: clsvPaperCount2EN = new clsvPaperCount2EN();
ObjectAssign(objvPaperCount2ENT, objvPaperCount2ENS);
 return objvPaperCount2ENT;
}