
 /**
 * 类名:clsgs_PSocialRelaWApi
 * 表名:gs_PSocialRela(01120671)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:46:45
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
 * 论文社会关系(gs_PSocialRela)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { clsgs_PSocialRelaEN } from "../../L0_Entity/GraduateEduPaper/clsgs_PSocialRelaEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { tzDataType } from "../../PubFun/jsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const gs_PSocialRela_Controller = "gs_PSocialRelaApi";
 export const gs_PSocialRela_ConstructorName = "gs_PSocialRela";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngmId:关键字
 * @returns 对象
 **/
export async function gs_PSocialRela_GetObjBymIdAsync(lngmId: number): Promise<clsgs_PSocialRelaEN>  
{
const strThisFuncName = "GetObjBymIdAsync";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In GetObjBymIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjBymId";
const strUrl = GetWebApiUrl(gs_PSocialRela_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_PSocialRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objgs_PSocialRela = gs_PSocialRela_GetObjFromJsonObj(returnObj);
return objgs_PSocialRela;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PSocialRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PSocialRela_ConstructorName, strThisFuncName);
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
export function gs_PSocialRela_SortFun_Defa(a:clsgs_PSocialRelaEN , b:clsgs_PSocialRelaEN): number 
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
export function gs_PSocialRela_SortFun_Defa_2Fld(a:clsgs_PSocialRelaEN , b:clsgs_PSocialRelaEN): number 
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
export function gs_PSocialRela_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsgs_PSocialRelaEN.con_mId:
return (a: clsgs_PSocialRelaEN, b: clsgs_PSocialRelaEN) => {
return a.mId-b.mId;
}
case clsgs_PSocialRelaEN.con_PaperId:
return (a: clsgs_PSocialRelaEN, b: clsgs_PSocialRelaEN) => {
return a.paperId.localeCompare(b.paperId);
}
case clsgs_PSocialRelaEN.con_SectionId:
return (a: clsgs_PSocialRelaEN, b: clsgs_PSocialRelaEN) => {
return a.sectionId.localeCompare(b.sectionId);
}
case clsgs_PSocialRelaEN.con_SocialId:
return (a: clsgs_PSocialRelaEN, b: clsgs_PSocialRelaEN) => {
return a.socialId.localeCompare(b.socialId);
}
case clsgs_PSocialRelaEN.con_UpdDate:
return (a: clsgs_PSocialRelaEN, b: clsgs_PSocialRelaEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsgs_PSocialRelaEN.con_UpdUser:
return (a: clsgs_PSocialRelaEN, b: clsgs_PSocialRelaEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsgs_PSocialRelaEN.con_Memo:
return (a: clsgs_PSocialRelaEN, b: clsgs_PSocialRelaEN) => {
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_PSocialRela]中不存在！(in ${ gs_PSocialRela_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsgs_PSocialRelaEN.con_mId:
return (a: clsgs_PSocialRelaEN, b: clsgs_PSocialRelaEN) => {
return b.mId-a.mId;
}
case clsgs_PSocialRelaEN.con_PaperId:
return (a: clsgs_PSocialRelaEN, b: clsgs_PSocialRelaEN) => {
return b.paperId.localeCompare(a.paperId);
}
case clsgs_PSocialRelaEN.con_SectionId:
return (a: clsgs_PSocialRelaEN, b: clsgs_PSocialRelaEN) => {
return b.sectionId.localeCompare(a.sectionId);
}
case clsgs_PSocialRelaEN.con_SocialId:
return (a: clsgs_PSocialRelaEN, b: clsgs_PSocialRelaEN) => {
return b.socialId.localeCompare(a.socialId);
}
case clsgs_PSocialRelaEN.con_UpdDate:
return (a: clsgs_PSocialRelaEN, b: clsgs_PSocialRelaEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsgs_PSocialRelaEN.con_UpdUser:
return (a: clsgs_PSocialRelaEN, b: clsgs_PSocialRelaEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsgs_PSocialRelaEN.con_Memo:
return (a: clsgs_PSocialRelaEN, b: clsgs_PSocialRelaEN) => {
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_PSocialRela]中不存在！(in ${ gs_PSocialRela_ConstructorName}.${ strThisFuncName})`;
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
export async function gs_PSocialRela_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsgs_PSocialRelaEN.con_mId:
return (obj: clsgs_PSocialRelaEN) => {
return obj.mId === value;
}
case clsgs_PSocialRelaEN.con_PaperId:
return (obj: clsgs_PSocialRelaEN) => {
return obj.paperId === value;
}
case clsgs_PSocialRelaEN.con_SectionId:
return (obj: clsgs_PSocialRelaEN) => {
return obj.sectionId === value;
}
case clsgs_PSocialRelaEN.con_SocialId:
return (obj: clsgs_PSocialRelaEN) => {
return obj.socialId === value;
}
case clsgs_PSocialRelaEN.con_UpdDate:
return (obj: clsgs_PSocialRelaEN) => {
return obj.updDate === value;
}
case clsgs_PSocialRelaEN.con_UpdUser:
return (obj: clsgs_PSocialRelaEN) => {
return obj.updUser === value;
}
case clsgs_PSocialRelaEN.con_Memo:
return (obj: clsgs_PSocialRelaEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_PSocialRela]中不存在！(in ${ gs_PSocialRela_ConstructorName}.${ strThisFuncName})`;
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
export async function gs_PSocialRela_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(gs_PSocialRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PSocialRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PSocialRela_ConstructorName, strThisFuncName);
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
export async function gs_PSocialRela_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(gs_PSocialRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PSocialRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PSocialRela_ConstructorName, strThisFuncName);
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
export async function gs_PSocialRela_GetFirstObjAsync(strWhereCond: string): Promise<clsgs_PSocialRelaEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(gs_PSocialRela_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_PSocialRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objgs_PSocialRela = gs_PSocialRela_GetObjFromJsonObj(returnObj);
return objgs_PSocialRela;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PSocialRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PSocialRela_ConstructorName, strThisFuncName);
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
export async function gs_PSocialRela_GetObjLstAsync(strWhereCond: string): Promise<Array<clsgs_PSocialRelaEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(gs_PSocialRela_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_PSocialRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_PSocialRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PSocialRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PSocialRela_ConstructorName, strThisFuncName);
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
export async function gs_PSocialRela_GetObjLstBymIdLstAsync(arrmId: Array<string>): Promise<Array<clsgs_PSocialRelaEN>>  
{
const strThisFuncName = "GetObjLstBymIdLstAsync";
const strAction = "GetObjLstBymIdLst";
const strUrl = GetWebApiUrl(gs_PSocialRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrmId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_PSocialRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_PSocialRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PSocialRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PSocialRela_ConstructorName, strThisFuncName);
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
export async function gs_PSocialRela_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsgs_PSocialRelaEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(gs_PSocialRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_PSocialRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_PSocialRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PSocialRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PSocialRela_ConstructorName, strThisFuncName);
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
export async function gs_PSocialRela_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsgs_PSocialRelaEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(gs_PSocialRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_PSocialRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_PSocialRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PSocialRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PSocialRela_ConstructorName, strThisFuncName);
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
export async function gs_PSocialRela_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(gs_PSocialRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PSocialRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PSocialRela_ConstructorName, strThisFuncName);
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
export async function gs_PSocialRela_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsgs_PSocialRelaEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(gs_PSocialRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_PSocialRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_PSocialRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PSocialRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PSocialRela_ConstructorName, strThisFuncName);
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
export async function gs_PSocialRela_DelRecordAsync(lngmId: number): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(gs_PSocialRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PSocialRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PSocialRela_ConstructorName, strThisFuncName);
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
export async function gs_PSocialRela_Delgs_PSocialRelasAsync(arrmId: Array<string>): Promise<number> 
{
const strThisFuncName = "Delgs_PSocialRelasAsync";
const strAction = "Delgs_PSocialRelas";
const strUrl = GetWebApiUrl(gs_PSocialRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PSocialRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PSocialRela_ConstructorName, strThisFuncName);
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
export async function gs_PSocialRela_Delgs_PSocialRelasByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "Delgs_PSocialRelasByCondAsync";
const strAction = "Delgs_PSocialRelasByCond";
const strUrl = GetWebApiUrl(gs_PSocialRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PSocialRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PSocialRela_ConstructorName, strThisFuncName);
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
 * @param objgs_PSocialRelaEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_PSocialRela_AddNewRecordAsync(objgs_PSocialRelaEN: clsgs_PSocialRelaEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objgs_PSocialRelaEN);
const strUrl = GetWebApiUrl(gs_PSocialRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_PSocialRelaEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PSocialRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PSocialRela_ConstructorName, strThisFuncName);
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
 * @param objgs_PSocialRelaEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function gs_PSocialRela_AddNewRecordWithReturnKeyAsync(objgs_PSocialRelaEN: clsgs_PSocialRelaEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(gs_PSocialRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_PSocialRelaEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PSocialRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PSocialRela_ConstructorName, strThisFuncName);
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
 * @param objgs_PSocialRelaEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function gs_PSocialRela_AddNewRecordWithReturnKey(objgs_PSocialRelaEN: clsgs_PSocialRelaEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objgs_PSocialRelaEN.mId === null || objgs_PSocialRelaEN.mId === 0)
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(gs_PSocialRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_PSocialRelaEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PSocialRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PSocialRela_ConstructorName, strThisFuncName);
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
 * @param objgs_PSocialRelaEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function gs_PSocialRela_UpdateRecordAsync(objgs_PSocialRelaEN: clsgs_PSocialRelaEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objgs_PSocialRelaEN.sf_UpdFldSetStr === undefined || objgs_PSocialRelaEN.sf_UpdFldSetStr === null || objgs_PSocialRelaEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_PSocialRelaEN.mId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(gs_PSocialRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_PSocialRelaEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PSocialRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PSocialRela_ConstructorName, strThisFuncName);
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
 * @param objgs_PSocialRelaEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function gs_PSocialRela_UpdateWithConditionAsync(objgs_PSocialRelaEN: clsgs_PSocialRelaEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objgs_PSocialRelaEN.sf_UpdFldSetStr === undefined || objgs_PSocialRelaEN.sf_UpdFldSetStr === null || objgs_PSocialRelaEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_PSocialRelaEN.mId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(gs_PSocialRela_Controller, strAction);
objgs_PSocialRelaEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objgs_PSocialRelaEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PSocialRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PSocialRela_ConstructorName, strThisFuncName);
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
export async function gs_PSocialRela_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(gs_PSocialRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PSocialRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PSocialRela_ConstructorName, strThisFuncName);
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
export async function gs_PSocialRela_IsExist(lngmId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(gs_PSocialRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PSocialRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PSocialRela_ConstructorName, strThisFuncName);
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
export async function gs_PSocialRela_IsExistAsync(lngmId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(gs_PSocialRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PSocialRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PSocialRela_ConstructorName, strThisFuncName);
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
export async function gs_PSocialRela_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(gs_PSocialRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PSocialRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PSocialRela_ConstructorName, strThisFuncName);
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
export async function gs_PSocialRela_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(gs_PSocialRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PSocialRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PSocialRela_ConstructorName, strThisFuncName);
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
export function gs_PSocialRela_GetWebApiUrl(strController: string, strAction: string): string {
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
export function gs_PSocialRela_CheckPropertyNew(pobjgs_PSocialRelaEN: clsgs_PSocialRelaEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjgs_PSocialRelaEN.paperId) === true 
 || pobjgs_PSocialRelaEN.paperId.toString()  ===  "0" )
{
 throw new Error("(errid:Watl000058)字段[论文Id]不能为空(In 论文社会关系)!(clsgs_PSocialRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PSocialRelaEN.socialId) === true )
{
 throw new Error("(errid:Watl000058)字段[社会Id]不能为空(In 论文社会关系)!(clsgs_PSocialRelaBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjgs_PSocialRelaEN.paperId) == false && GetStrLen(pobjgs_PSocialRelaEN.paperId) > 8)
{
 throw new Error("(errid:Watl000059)字段[论文Id(paperId)]的长度不能超过8(In 论文社会关系(gs_PSocialRela))!值:$(pobjgs_PSocialRelaEN.paperId)(clsgs_PSocialRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PSocialRelaEN.sectionId) == false && GetStrLen(pobjgs_PSocialRelaEN.sectionId) > 8)
{
 throw new Error("(errid:Watl000059)字段[节Id(sectionId)]的长度不能超过8(In 论文社会关系(gs_PSocialRela))!值:$(pobjgs_PSocialRelaEN.sectionId)(clsgs_PSocialRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PSocialRelaEN.socialId) == false && GetStrLen(pobjgs_PSocialRelaEN.socialId) > 10)
{
 throw new Error("(errid:Watl000059)字段[社会Id(socialId)]的长度不能超过10(In 论文社会关系(gs_PSocialRela))!值:$(pobjgs_PSocialRelaEN.socialId)(clsgs_PSocialRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PSocialRelaEN.updDate) == false && GetStrLen(pobjgs_PSocialRelaEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 论文社会关系(gs_PSocialRela))!值:$(pobjgs_PSocialRelaEN.updDate)(clsgs_PSocialRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PSocialRelaEN.updUser) == false && GetStrLen(pobjgs_PSocialRelaEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 论文社会关系(gs_PSocialRela))!值:$(pobjgs_PSocialRelaEN.updUser)(clsgs_PSocialRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PSocialRelaEN.memo) == false && GetStrLen(pobjgs_PSocialRelaEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 论文社会关系(gs_PSocialRela))!值:$(pobjgs_PSocialRelaEN.memo)(clsgs_PSocialRelaBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null != pobjgs_PSocialRelaEN.mId && undefined !== pobjgs_PSocialRelaEN.mId && tzDataType.isNumber(pobjgs_PSocialRelaEN.mId) === false)
{
 throw new Error("(errid:Watl000060)字段[mId(mId)]的值:[$(pobjgs_PSocialRelaEN.mId)], 非法，应该为数值型(In 论文社会关系(gs_PSocialRela))!(clsgs_PSocialRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PSocialRelaEN.paperId) == false && undefined !== pobjgs_PSocialRelaEN.paperId && tzDataType.isString(pobjgs_PSocialRelaEN.paperId) === false)
{
 throw new Error("(errid:Watl000060)字段[论文Id(paperId)]的值:[$(pobjgs_PSocialRelaEN.paperId)], 非法，应该为字符型(In 论文社会关系(gs_PSocialRela))!(clsgs_PSocialRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PSocialRelaEN.sectionId) == false && undefined !== pobjgs_PSocialRelaEN.sectionId && tzDataType.isString(pobjgs_PSocialRelaEN.sectionId) === false)
{
 throw new Error("(errid:Watl000060)字段[节Id(sectionId)]的值:[$(pobjgs_PSocialRelaEN.sectionId)], 非法，应该为字符型(In 论文社会关系(gs_PSocialRela))!(clsgs_PSocialRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PSocialRelaEN.socialId) == false && undefined !== pobjgs_PSocialRelaEN.socialId && tzDataType.isString(pobjgs_PSocialRelaEN.socialId) === false)
{
 throw new Error("(errid:Watl000060)字段[社会Id(socialId)]的值:[$(pobjgs_PSocialRelaEN.socialId)], 非法，应该为字符型(In 论文社会关系(gs_PSocialRela))!(clsgs_PSocialRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PSocialRelaEN.updDate) == false && undefined !== pobjgs_PSocialRelaEN.updDate && tzDataType.isString(pobjgs_PSocialRelaEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjgs_PSocialRelaEN.updDate)], 非法，应该为字符型(In 论文社会关系(gs_PSocialRela))!(clsgs_PSocialRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PSocialRelaEN.updUser) == false && undefined !== pobjgs_PSocialRelaEN.updUser && tzDataType.isString(pobjgs_PSocialRelaEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjgs_PSocialRelaEN.updUser)], 非法，应该为字符型(In 论文社会关系(gs_PSocialRela))!(clsgs_PSocialRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PSocialRelaEN.memo) == false && undefined !== pobjgs_PSocialRelaEN.memo && tzDataType.isString(pobjgs_PSocialRelaEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjgs_PSocialRelaEN.memo)], 非法，应该为字符型(In 论文社会关系(gs_PSocialRela))!(clsgs_PSocialRelaBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjgs_PSocialRelaEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function gs_PSocialRela_CheckProperty4Update (pobjgs_PSocialRelaEN: clsgs_PSocialRelaEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjgs_PSocialRelaEN.paperId) == false && GetStrLen(pobjgs_PSocialRelaEN.paperId) > 8)
{
 throw new Error("(errid:Watl000062)字段[论文Id(paperId)]的长度不能超过8(In 论文社会关系(gs_PSocialRela))!值:$(pobjgs_PSocialRelaEN.paperId)(clsgs_PSocialRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PSocialRelaEN.sectionId) == false && GetStrLen(pobjgs_PSocialRelaEN.sectionId) > 8)
{
 throw new Error("(errid:Watl000062)字段[节Id(sectionId)]的长度不能超过8(In 论文社会关系(gs_PSocialRela))!值:$(pobjgs_PSocialRelaEN.sectionId)(clsgs_PSocialRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PSocialRelaEN.socialId) == false && GetStrLen(pobjgs_PSocialRelaEN.socialId) > 10)
{
 throw new Error("(errid:Watl000062)字段[社会Id(socialId)]的长度不能超过10(In 论文社会关系(gs_PSocialRela))!值:$(pobjgs_PSocialRelaEN.socialId)(clsgs_PSocialRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PSocialRelaEN.updDate) == false && GetStrLen(pobjgs_PSocialRelaEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 论文社会关系(gs_PSocialRela))!值:$(pobjgs_PSocialRelaEN.updDate)(clsgs_PSocialRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PSocialRelaEN.updUser) == false && GetStrLen(pobjgs_PSocialRelaEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 论文社会关系(gs_PSocialRela))!值:$(pobjgs_PSocialRelaEN.updUser)(clsgs_PSocialRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PSocialRelaEN.memo) == false && GetStrLen(pobjgs_PSocialRelaEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 论文社会关系(gs_PSocialRela))!值:$(pobjgs_PSocialRelaEN.memo)(clsgs_PSocialRelaBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null != pobjgs_PSocialRelaEN.mId && undefined !== pobjgs_PSocialRelaEN.mId && tzDataType.isNumber(pobjgs_PSocialRelaEN.mId) === false)
{
 throw new Error("(errid:Watl000063)字段[mId(mId)]的值:[$(pobjgs_PSocialRelaEN.mId)], 非法，应该为数值型(In 论文社会关系(gs_PSocialRela))!(clsgs_PSocialRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PSocialRelaEN.paperId) == false && undefined !== pobjgs_PSocialRelaEN.paperId && tzDataType.isString(pobjgs_PSocialRelaEN.paperId) === false)
{
 throw new Error("(errid:Watl000063)字段[论文Id(paperId)]的值:[$(pobjgs_PSocialRelaEN.paperId)], 非法，应该为字符型(In 论文社会关系(gs_PSocialRela))!(clsgs_PSocialRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PSocialRelaEN.sectionId) == false && undefined !== pobjgs_PSocialRelaEN.sectionId && tzDataType.isString(pobjgs_PSocialRelaEN.sectionId) === false)
{
 throw new Error("(errid:Watl000063)字段[节Id(sectionId)]的值:[$(pobjgs_PSocialRelaEN.sectionId)], 非法，应该为字符型(In 论文社会关系(gs_PSocialRela))!(clsgs_PSocialRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PSocialRelaEN.socialId) == false && undefined !== pobjgs_PSocialRelaEN.socialId && tzDataType.isString(pobjgs_PSocialRelaEN.socialId) === false)
{
 throw new Error("(errid:Watl000063)字段[社会Id(socialId)]的值:[$(pobjgs_PSocialRelaEN.socialId)], 非法，应该为字符型(In 论文社会关系(gs_PSocialRela))!(clsgs_PSocialRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PSocialRelaEN.updDate) == false && undefined !== pobjgs_PSocialRelaEN.updDate && tzDataType.isString(pobjgs_PSocialRelaEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjgs_PSocialRelaEN.updDate)], 非法，应该为字符型(In 论文社会关系(gs_PSocialRela))!(clsgs_PSocialRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PSocialRelaEN.updUser) == false && undefined !== pobjgs_PSocialRelaEN.updUser && tzDataType.isString(pobjgs_PSocialRelaEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjgs_PSocialRelaEN.updUser)], 非法，应该为字符型(In 论文社会关系(gs_PSocialRela))!(clsgs_PSocialRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PSocialRelaEN.memo) == false && undefined !== pobjgs_PSocialRelaEN.memo && tzDataType.isString(pobjgs_PSocialRelaEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjgs_PSocialRelaEN.memo)], 非法，应该为字符型(In 论文社会关系(gs_PSocialRela))!(clsgs_PSocialRelaBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjgs_PSocialRelaEN.mId 
 || pobjgs_PSocialRelaEN.mId != null && pobjgs_PSocialRelaEN.mId.toString()  ===  "")
{
 throw new Error("(errid:Watl000064)字段[mId]不能为空(In 论文社会关系)!(clsgs_PSocialRelaBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjgs_PSocialRelaEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function gs_PSocialRela_GetJSONStrByObj (pobjgs_PSocialRelaEN: clsgs_PSocialRelaEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjgs_PSocialRelaEN.sf_UpdFldSetStr = pobjgs_PSocialRelaEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjgs_PSocialRelaEN);
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
export function gs_PSocialRela_GetObjLstByJSONStr (strJSON: string): Array<clsgs_PSocialRelaEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrgs_PSocialRelaObjLst = new Array<clsgs_PSocialRelaEN>();
if (strJSON === "")
{
return arrgs_PSocialRelaObjLst;
}
try
{
arrgs_PSocialRelaObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrgs_PSocialRelaObjLst;
}
return arrgs_PSocialRelaObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrgs_PSocialRelaObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function gs_PSocialRela_GetObjLstByJSONObjLst (arrgs_PSocialRelaObjLstS: Array<clsgs_PSocialRelaEN>): Array<clsgs_PSocialRelaEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrgs_PSocialRelaObjLst = new Array<clsgs_PSocialRelaEN>();
for (const objInFor of arrgs_PSocialRelaObjLstS) {
const obj1 = gs_PSocialRela_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrgs_PSocialRelaObjLst.push(obj1);
}
return arrgs_PSocialRelaObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function gs_PSocialRela_GetObjByJSONStr (strJSON: string): clsgs_PSocialRelaEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjgs_PSocialRelaEN = new clsgs_PSocialRelaEN();
if (strJSON === "")
{
return pobjgs_PSocialRelaEN;
}
try
{
pobjgs_PSocialRelaEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjgs_PSocialRelaEN;
}
return pobjgs_PSocialRelaEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function gs_PSocialRela_GetCombineCondition(objgs_PSocialRela_Cond: clsgs_PSocialRelaEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objgs_PSocialRela_Cond.dicFldComparisonOp, clsgs_PSocialRelaEN.con_mId) == true)
{
const strComparisonOp_mId:string = objgs_PSocialRela_Cond.dicFldComparisonOp[clsgs_PSocialRelaEN.con_mId];
strWhereCond += Format(" And {0} {2} {1}", clsgs_PSocialRelaEN.con_mId, objgs_PSocialRela_Cond.mId, strComparisonOp_mId);
}
if (Object.prototype.hasOwnProperty.call(objgs_PSocialRela_Cond.dicFldComparisonOp, clsgs_PSocialRelaEN.con_PaperId) == true)
{
const strComparisonOp_PaperId:string = objgs_PSocialRela_Cond.dicFldComparisonOp[clsgs_PSocialRelaEN.con_PaperId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PSocialRelaEN.con_PaperId, objgs_PSocialRela_Cond.paperId, strComparisonOp_PaperId);
}
if (Object.prototype.hasOwnProperty.call(objgs_PSocialRela_Cond.dicFldComparisonOp, clsgs_PSocialRelaEN.con_SectionId) == true)
{
const strComparisonOp_SectionId:string = objgs_PSocialRela_Cond.dicFldComparisonOp[clsgs_PSocialRelaEN.con_SectionId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PSocialRelaEN.con_SectionId, objgs_PSocialRela_Cond.sectionId, strComparisonOp_SectionId);
}
if (Object.prototype.hasOwnProperty.call(objgs_PSocialRela_Cond.dicFldComparisonOp, clsgs_PSocialRelaEN.con_SocialId) == true)
{
const strComparisonOp_SocialId:string = objgs_PSocialRela_Cond.dicFldComparisonOp[clsgs_PSocialRelaEN.con_SocialId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PSocialRelaEN.con_SocialId, objgs_PSocialRela_Cond.socialId, strComparisonOp_SocialId);
}
if (Object.prototype.hasOwnProperty.call(objgs_PSocialRela_Cond.dicFldComparisonOp, clsgs_PSocialRelaEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objgs_PSocialRela_Cond.dicFldComparisonOp[clsgs_PSocialRelaEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PSocialRelaEN.con_UpdDate, objgs_PSocialRela_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objgs_PSocialRela_Cond.dicFldComparisonOp, clsgs_PSocialRelaEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objgs_PSocialRela_Cond.dicFldComparisonOp[clsgs_PSocialRelaEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PSocialRelaEN.con_UpdUser, objgs_PSocialRela_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objgs_PSocialRela_Cond.dicFldComparisonOp, clsgs_PSocialRelaEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objgs_PSocialRela_Cond.dicFldComparisonOp[clsgs_PSocialRelaEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PSocialRelaEN.con_Memo, objgs_PSocialRela_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--gs_PSocialRela(论文社会关系),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param lngmId: mId(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function gs_PSocialRela_GetUniCondStr_mId(objgs_PSocialRelaEN: clsgs_PSocialRelaEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and mId = '{0}'", objgs_PSocialRelaEN.mId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--gs_PSocialRela(论文社会关系),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param lngmId: mId(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function gs_PSocialRela_GetUniCondStr4Update_mId(objgs_PSocialRelaEN: clsgs_PSocialRelaEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and mId <> '{0}'", objgs_PSocialRelaEN.mId);
 strWhereCond +=  Format(" and mId = '{0}'", objgs_PSocialRelaEN.mId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objgs_PSocialRelaENS:源对象
 * @param objgs_PSocialRelaENT:目标对象
*/
export function gs_PSocialRela_CopyObjTo(objgs_PSocialRelaENS: clsgs_PSocialRelaEN , objgs_PSocialRelaENT: clsgs_PSocialRelaEN ): void 
{
objgs_PSocialRelaENT.mId = objgs_PSocialRelaENS.mId; //mId
objgs_PSocialRelaENT.paperId = objgs_PSocialRelaENS.paperId; //论文Id
objgs_PSocialRelaENT.sectionId = objgs_PSocialRelaENS.sectionId; //节Id
objgs_PSocialRelaENT.socialId = objgs_PSocialRelaENS.socialId; //社会Id
objgs_PSocialRelaENT.updDate = objgs_PSocialRelaENS.updDate; //修改日期
objgs_PSocialRelaENT.updUser = objgs_PSocialRelaENS.updUser; //修改人
objgs_PSocialRelaENT.memo = objgs_PSocialRelaENS.memo; //备注
objgs_PSocialRelaENT.sf_UpdFldSetStr = objgs_PSocialRelaENS.updFldString; //sf_UpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objgs_PSocialRelaENS:源对象
 * @param objgs_PSocialRelaENT:目标对象
*/
export function gs_PSocialRela_GetObjFromJsonObj(objgs_PSocialRelaENS: clsgs_PSocialRelaEN): clsgs_PSocialRelaEN 
{
 const objgs_PSocialRelaENT: clsgs_PSocialRelaEN = new clsgs_PSocialRelaEN();
ObjectAssign(objgs_PSocialRelaENT, objgs_PSocialRelaENS);
 return objgs_PSocialRelaENT;
}