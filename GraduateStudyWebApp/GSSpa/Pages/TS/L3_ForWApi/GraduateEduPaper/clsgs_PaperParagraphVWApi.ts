
 /**
 * 类名:clsgs_PaperParagraphVWApi
 * 表名:gs_PaperParagraphV(01120743)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:46:39
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
 * 论文段落版本(gs_PaperParagraphV)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { clsgs_PaperParagraphVEN } from "../../L0_Entity/GraduateEduPaper/clsgs_PaperParagraphVEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { tzDataType } from "../../PubFun/jsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const gs_PaperParagraphV_Controller = "gs_PaperParagraphVApi";
 export const gs_PaperParagraphV_ConstructorName = "gs_PaperParagraphV";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngParagraphVId:关键字
 * @returns 对象
 **/
export async function gs_PaperParagraphV_GetObjByParagraphVIdAsync(lngParagraphVId: number): Promise<clsgs_PaperParagraphVEN>  
{
const strThisFuncName = "GetObjByParagraphVIdAsync";

if (lngParagraphVId == 0)
{
  const strMsg = Format("参数:[lngParagraphVId]不能为空！(In GetObjByParagraphVIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjByParagraphVId";
const strUrl = GetWebApiUrl(gs_PaperParagraphV_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"lngParagraphVId": lngParagraphVId,
}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObj = data.returnObj;
if (returnObj == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_PaperParagraphV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objgs_PaperParagraphV = gs_PaperParagraphV_GetObjFromJsonObj(returnObj);
return objgs_PaperParagraphV;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperParagraphV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperParagraphV_ConstructorName, strThisFuncName);
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
export function gs_PaperParagraphV_SortFun_Defa(a:clsgs_PaperParagraphVEN , b:clsgs_PaperParagraphVEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.paragraphVId-b.paragraphVId;
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
export function gs_PaperParagraphV_SortFun_Defa_2Fld(a:clsgs_PaperParagraphVEN , b:clsgs_PaperParagraphVEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.paragraphId == b.paragraphId) return a.sectionId.localeCompare(b.sectionId);
else return a.paragraphId.localeCompare(b.paragraphId);
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
export function gs_PaperParagraphV_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsgs_PaperParagraphVEN.con_ParagraphVId:
return (a: clsgs_PaperParagraphVEN, b: clsgs_PaperParagraphVEN) => {
return a.paragraphVId-b.paragraphVId;
}
case clsgs_PaperParagraphVEN.con_ParagraphId:
return (a: clsgs_PaperParagraphVEN, b: clsgs_PaperParagraphVEN) => {
return a.paragraphId.localeCompare(b.paragraphId);
}
case clsgs_PaperParagraphVEN.con_SectionId:
return (a: clsgs_PaperParagraphVEN, b: clsgs_PaperParagraphVEN) => {
return a.sectionId.localeCompare(b.sectionId);
}
case clsgs_PaperParagraphVEN.con_ParagraphTypeId:
return (a: clsgs_PaperParagraphVEN, b: clsgs_PaperParagraphVEN) => {
return a.paragraphTypeId.localeCompare(b.paragraphTypeId);
}
case clsgs_PaperParagraphVEN.con_ParagraphContent:
return (a: clsgs_PaperParagraphVEN, b: clsgs_PaperParagraphVEN) => {
return a.paragraphContent.localeCompare(b.paragraphContent);
}
case clsgs_PaperParagraphVEN.con_UpdDate:
return (a: clsgs_PaperParagraphVEN, b: clsgs_PaperParagraphVEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsgs_PaperParagraphVEN.con_UpdUser:
return (a: clsgs_PaperParagraphVEN, b: clsgs_PaperParagraphVEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsgs_PaperParagraphVEN.con_Memo:
return (a: clsgs_PaperParagraphVEN, b: clsgs_PaperParagraphVEN) => {
return a.memo.localeCompare(b.memo);
}
case clsgs_PaperParagraphVEN.con_PaperId:
return (a: clsgs_PaperParagraphVEN, b: clsgs_PaperParagraphVEN) => {
return a.paperId.localeCompare(b.paperId);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_PaperParagraphV]中不存在！(in ${ gs_PaperParagraphV_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsgs_PaperParagraphVEN.con_ParagraphVId:
return (a: clsgs_PaperParagraphVEN, b: clsgs_PaperParagraphVEN) => {
return b.paragraphVId-a.paragraphVId;
}
case clsgs_PaperParagraphVEN.con_ParagraphId:
return (a: clsgs_PaperParagraphVEN, b: clsgs_PaperParagraphVEN) => {
return b.paragraphId.localeCompare(a.paragraphId);
}
case clsgs_PaperParagraphVEN.con_SectionId:
return (a: clsgs_PaperParagraphVEN, b: clsgs_PaperParagraphVEN) => {
return b.sectionId.localeCompare(a.sectionId);
}
case clsgs_PaperParagraphVEN.con_ParagraphTypeId:
return (a: clsgs_PaperParagraphVEN, b: clsgs_PaperParagraphVEN) => {
return b.paragraphTypeId.localeCompare(a.paragraphTypeId);
}
case clsgs_PaperParagraphVEN.con_ParagraphContent:
return (a: clsgs_PaperParagraphVEN, b: clsgs_PaperParagraphVEN) => {
return b.paragraphContent.localeCompare(a.paragraphContent);
}
case clsgs_PaperParagraphVEN.con_UpdDate:
return (a: clsgs_PaperParagraphVEN, b: clsgs_PaperParagraphVEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsgs_PaperParagraphVEN.con_UpdUser:
return (a: clsgs_PaperParagraphVEN, b: clsgs_PaperParagraphVEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsgs_PaperParagraphVEN.con_Memo:
return (a: clsgs_PaperParagraphVEN, b: clsgs_PaperParagraphVEN) => {
return b.memo.localeCompare(a.memo);
}
case clsgs_PaperParagraphVEN.con_PaperId:
return (a: clsgs_PaperParagraphVEN, b: clsgs_PaperParagraphVEN) => {
return b.paperId.localeCompare(a.paperId);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_PaperParagraphV]中不存在！(in ${ gs_PaperParagraphV_ConstructorName}.${ strThisFuncName})`;
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
export async function gs_PaperParagraphV_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsgs_PaperParagraphVEN.con_ParagraphVId:
return (obj: clsgs_PaperParagraphVEN) => {
return obj.paragraphVId === value;
}
case clsgs_PaperParagraphVEN.con_ParagraphId:
return (obj: clsgs_PaperParagraphVEN) => {
return obj.paragraphId === value;
}
case clsgs_PaperParagraphVEN.con_SectionId:
return (obj: clsgs_PaperParagraphVEN) => {
return obj.sectionId === value;
}
case clsgs_PaperParagraphVEN.con_ParagraphTypeId:
return (obj: clsgs_PaperParagraphVEN) => {
return obj.paragraphTypeId === value;
}
case clsgs_PaperParagraphVEN.con_ParagraphContent:
return (obj: clsgs_PaperParagraphVEN) => {
return obj.paragraphContent === value;
}
case clsgs_PaperParagraphVEN.con_UpdDate:
return (obj: clsgs_PaperParagraphVEN) => {
return obj.updDate === value;
}
case clsgs_PaperParagraphVEN.con_UpdUser:
return (obj: clsgs_PaperParagraphVEN) => {
return obj.updUser === value;
}
case clsgs_PaperParagraphVEN.con_Memo:
return (obj: clsgs_PaperParagraphVEN) => {
return obj.memo === value;
}
case clsgs_PaperParagraphVEN.con_PaperId:
return (obj: clsgs_PaperParagraphVEN) => {
return obj.paperId === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_PaperParagraphV]中不存在！(in ${ gs_PaperParagraphV_ConstructorName}.${ strThisFuncName})`;
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
export async function gs_PaperParagraphV_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(gs_PaperParagraphV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperParagraphV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperParagraphV_ConstructorName, strThisFuncName);
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
export async function gs_PaperParagraphV_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(gs_PaperParagraphV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperParagraphV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperParagraphV_ConstructorName, strThisFuncName);
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
export async function gs_PaperParagraphV_GetFirstObjAsync(strWhereCond: string): Promise<clsgs_PaperParagraphVEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(gs_PaperParagraphV_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_PaperParagraphV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objgs_PaperParagraphV = gs_PaperParagraphV_GetObjFromJsonObj(returnObj);
return objgs_PaperParagraphV;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperParagraphV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperParagraphV_ConstructorName, strThisFuncName);
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
export async function gs_PaperParagraphV_GetObjLstAsync(strWhereCond: string): Promise<Array<clsgs_PaperParagraphVEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(gs_PaperParagraphV_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_PaperParagraphV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_PaperParagraphV_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperParagraphV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperParagraphV_ConstructorName, strThisFuncName);
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
 * @param arrParagraphVId:关键字列表
 * @returns 对象列表
 **/
export async function gs_PaperParagraphV_GetObjLstByParagraphVIdLstAsync(arrParagraphVId: Array<string>): Promise<Array<clsgs_PaperParagraphVEN>>  
{
const strThisFuncName = "GetObjLstByParagraphVIdLstAsync";
const strAction = "GetObjLstByParagraphVIdLst";
const strUrl = GetWebApiUrl(gs_PaperParagraphV_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrParagraphVId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_PaperParagraphV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_PaperParagraphV_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperParagraphV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperParagraphV_ConstructorName, strThisFuncName);
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
export async function gs_PaperParagraphV_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsgs_PaperParagraphVEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(gs_PaperParagraphV_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_PaperParagraphV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_PaperParagraphV_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperParagraphV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperParagraphV_ConstructorName, strThisFuncName);
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
export async function gs_PaperParagraphV_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsgs_PaperParagraphVEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(gs_PaperParagraphV_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_PaperParagraphV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_PaperParagraphV_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperParagraphV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperParagraphV_ConstructorName, strThisFuncName);
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
export async function gs_PaperParagraphV_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(gs_PaperParagraphV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperParagraphV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperParagraphV_ConstructorName, strThisFuncName);
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
export async function gs_PaperParagraphV_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsgs_PaperParagraphVEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(gs_PaperParagraphV_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_PaperParagraphV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_PaperParagraphV_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperParagraphV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperParagraphV_ConstructorName, strThisFuncName);
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
 * @param lngParagraphVId:关键字
 * @returns 获取删除的结果
 **/
export async function gs_PaperParagraphV_DelRecordAsync(lngParagraphVId: number): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(gs_PaperParagraphV_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, lngParagraphVId);
try
{
const response = await axios.delete(strUrl,
{
params: { "Id": lngParagraphVId, }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperParagraphV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperParagraphV_ConstructorName, strThisFuncName);
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
 * @param arrParagraphVId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function gs_PaperParagraphV_Delgs_PaperParagraphVsAsync(arrParagraphVId: Array<string>): Promise<number> 
{
const strThisFuncName = "Delgs_PaperParagraphVsAsync";
const strAction = "Delgs_PaperParagraphVs";
const strUrl = GetWebApiUrl(gs_PaperParagraphV_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrParagraphVId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperParagraphV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperParagraphV_ConstructorName, strThisFuncName);
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
export async function gs_PaperParagraphV_Delgs_PaperParagraphVsByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "Delgs_PaperParagraphVsByCondAsync";
const strAction = "Delgs_PaperParagraphVsByCond";
const strUrl = GetWebApiUrl(gs_PaperParagraphV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperParagraphV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperParagraphV_ConstructorName, strThisFuncName);
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
 * @param objgs_PaperParagraphVEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_PaperParagraphV_AddNewRecordAsync(objgs_PaperParagraphVEN: clsgs_PaperParagraphVEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objgs_PaperParagraphVEN);
const strUrl = GetWebApiUrl(gs_PaperParagraphV_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_PaperParagraphVEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperParagraphV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperParagraphV_ConstructorName, strThisFuncName);
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
 * @param objgs_PaperParagraphVEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function gs_PaperParagraphV_AddNewRecordWithReturnKeyAsync(objgs_PaperParagraphVEN: clsgs_PaperParagraphVEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(gs_PaperParagraphV_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_PaperParagraphVEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperParagraphV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperParagraphV_ConstructorName, strThisFuncName);
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
 * @param objgs_PaperParagraphVEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function gs_PaperParagraphV_AddNewRecordWithReturnKey(objgs_PaperParagraphVEN: clsgs_PaperParagraphVEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objgs_PaperParagraphVEN.paragraphVId === null || objgs_PaperParagraphVEN.paragraphVId === 0)
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(gs_PaperParagraphV_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_PaperParagraphVEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperParagraphV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperParagraphV_ConstructorName, strThisFuncName);
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
 * @param objgs_PaperParagraphVEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function gs_PaperParagraphV_UpdateRecordAsync(objgs_PaperParagraphVEN: clsgs_PaperParagraphVEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objgs_PaperParagraphVEN.sf_UpdFldSetStr === undefined || objgs_PaperParagraphVEN.sf_UpdFldSetStr === null || objgs_PaperParagraphVEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_PaperParagraphVEN.paragraphVId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(gs_PaperParagraphV_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_PaperParagraphVEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperParagraphV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperParagraphV_ConstructorName, strThisFuncName);
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
 * @param objgs_PaperParagraphVEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function gs_PaperParagraphV_UpdateWithConditionAsync(objgs_PaperParagraphVEN: clsgs_PaperParagraphVEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objgs_PaperParagraphVEN.sf_UpdFldSetStr === undefined || objgs_PaperParagraphVEN.sf_UpdFldSetStr === null || objgs_PaperParagraphVEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_PaperParagraphVEN.paragraphVId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(gs_PaperParagraphV_Controller, strAction);
objgs_PaperParagraphVEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objgs_PaperParagraphVEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperParagraphV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperParagraphV_ConstructorName, strThisFuncName);
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
export async function gs_PaperParagraphV_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(gs_PaperParagraphV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperParagraphV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperParagraphV_ConstructorName, strThisFuncName);
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
 * @param lngParagraphVId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function gs_PaperParagraphV_IsExist(lngParagraphVId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(gs_PaperParagraphV_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"ParagraphVId": lngParagraphVId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperParagraphV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperParagraphV_ConstructorName, strThisFuncName);
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
 * @param lngParagraphVId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function gs_PaperParagraphV_IsExistAsync(lngParagraphVId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(gs_PaperParagraphV_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "lngParagraphVId": lngParagraphVId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperParagraphV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperParagraphV_ConstructorName, strThisFuncName);
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
export async function gs_PaperParagraphV_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(gs_PaperParagraphV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperParagraphV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperParagraphV_ConstructorName, strThisFuncName);
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
export async function gs_PaperParagraphV_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(gs_PaperParagraphV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperParagraphV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperParagraphV_ConstructorName, strThisFuncName);
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
export function gs_PaperParagraphV_GetWebApiUrl(strController: string, strAction: string): string {
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
export function gs_PaperParagraphV_CheckPropertyNew(pobjgs_PaperParagraphVEN: clsgs_PaperParagraphVEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjgs_PaperParagraphVEN.paragraphId) === true )
{
 throw new Error("(errid:Watl000058)字段[段落Id]不能为空(In 论文段落版本)!(clsgs_PaperParagraphVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphVEN.sectionId) === true )
{
 throw new Error("(errid:Watl000058)字段[节Id]不能为空(In 论文段落版本)!(clsgs_PaperParagraphVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphVEN.paragraphTypeId) === true )
{
 throw new Error("(errid:Watl000058)字段[段落类型Id]不能为空(In 论文段落版本)!(clsgs_PaperParagraphVBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjgs_PaperParagraphVEN.paragraphId) == false && GetStrLen(pobjgs_PaperParagraphVEN.paragraphId) > 10)
{
 throw new Error("(errid:Watl000059)字段[段落Id(paragraphId)]的长度不能超过10(In 论文段落版本(gs_PaperParagraphV))!值:$(pobjgs_PaperParagraphVEN.paragraphId)(clsgs_PaperParagraphVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphVEN.sectionId) == false && GetStrLen(pobjgs_PaperParagraphVEN.sectionId) > 8)
{
 throw new Error("(errid:Watl000059)字段[节Id(sectionId)]的长度不能超过8(In 论文段落版本(gs_PaperParagraphV))!值:$(pobjgs_PaperParagraphVEN.sectionId)(clsgs_PaperParagraphVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphVEN.paragraphTypeId) == false && GetStrLen(pobjgs_PaperParagraphVEN.paragraphTypeId) > 2)
{
 throw new Error("(errid:Watl000059)字段[段落类型Id(paragraphTypeId)]的长度不能超过2(In 论文段落版本(gs_PaperParagraphV))!值:$(pobjgs_PaperParagraphVEN.paragraphTypeId)(clsgs_PaperParagraphVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphVEN.updDate) == false && GetStrLen(pobjgs_PaperParagraphVEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 论文段落版本(gs_PaperParagraphV))!值:$(pobjgs_PaperParagraphVEN.updDate)(clsgs_PaperParagraphVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphVEN.updUser) == false && GetStrLen(pobjgs_PaperParagraphVEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 论文段落版本(gs_PaperParagraphV))!值:$(pobjgs_PaperParagraphVEN.updUser)(clsgs_PaperParagraphVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphVEN.memo) == false && GetStrLen(pobjgs_PaperParagraphVEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 论文段落版本(gs_PaperParagraphV))!值:$(pobjgs_PaperParagraphVEN.memo)(clsgs_PaperParagraphVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphVEN.paperId) == false && GetStrLen(pobjgs_PaperParagraphVEN.paperId) > 8)
{
 throw new Error("(errid:Watl000059)字段[论文Id(paperId)]的长度不能超过8(In 论文段落版本(gs_PaperParagraphV))!值:$(pobjgs_PaperParagraphVEN.paperId)(clsgs_PaperParagraphVBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null != pobjgs_PaperParagraphVEN.paragraphVId && undefined !== pobjgs_PaperParagraphVEN.paragraphVId && tzDataType.isNumber(pobjgs_PaperParagraphVEN.paragraphVId) === false)
{
 throw new Error("(errid:Watl000060)字段[段落版本Id(paragraphVId)]的值:[$(pobjgs_PaperParagraphVEN.paragraphVId)], 非法，应该为数值型(In 论文段落版本(gs_PaperParagraphV))!(clsgs_PaperParagraphVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphVEN.paragraphId) == false && undefined !== pobjgs_PaperParagraphVEN.paragraphId && tzDataType.isString(pobjgs_PaperParagraphVEN.paragraphId) === false)
{
 throw new Error("(errid:Watl000060)字段[段落Id(paragraphId)]的值:[$(pobjgs_PaperParagraphVEN.paragraphId)], 非法，应该为字符型(In 论文段落版本(gs_PaperParagraphV))!(clsgs_PaperParagraphVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphVEN.sectionId) == false && undefined !== pobjgs_PaperParagraphVEN.sectionId && tzDataType.isString(pobjgs_PaperParagraphVEN.sectionId) === false)
{
 throw new Error("(errid:Watl000060)字段[节Id(sectionId)]的值:[$(pobjgs_PaperParagraphVEN.sectionId)], 非法，应该为字符型(In 论文段落版本(gs_PaperParagraphV))!(clsgs_PaperParagraphVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphVEN.paragraphTypeId) == false && undefined !== pobjgs_PaperParagraphVEN.paragraphTypeId && tzDataType.isString(pobjgs_PaperParagraphVEN.paragraphTypeId) === false)
{
 throw new Error("(errid:Watl000060)字段[段落类型Id(paragraphTypeId)]的值:[$(pobjgs_PaperParagraphVEN.paragraphTypeId)], 非法，应该为字符型(In 论文段落版本(gs_PaperParagraphV))!(clsgs_PaperParagraphVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphVEN.paragraphContent) == false && undefined !== pobjgs_PaperParagraphVEN.paragraphContent && tzDataType.isString(pobjgs_PaperParagraphVEN.paragraphContent) === false)
{
 throw new Error("(errid:Watl000060)字段[段落内容(paragraphContent)]的值:[$(pobjgs_PaperParagraphVEN.paragraphContent)], 非法，应该为字符型(In 论文段落版本(gs_PaperParagraphV))!(clsgs_PaperParagraphVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphVEN.updDate) == false && undefined !== pobjgs_PaperParagraphVEN.updDate && tzDataType.isString(pobjgs_PaperParagraphVEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjgs_PaperParagraphVEN.updDate)], 非法，应该为字符型(In 论文段落版本(gs_PaperParagraphV))!(clsgs_PaperParagraphVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphVEN.updUser) == false && undefined !== pobjgs_PaperParagraphVEN.updUser && tzDataType.isString(pobjgs_PaperParagraphVEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjgs_PaperParagraphVEN.updUser)], 非法，应该为字符型(In 论文段落版本(gs_PaperParagraphV))!(clsgs_PaperParagraphVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphVEN.memo) == false && undefined !== pobjgs_PaperParagraphVEN.memo && tzDataType.isString(pobjgs_PaperParagraphVEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjgs_PaperParagraphVEN.memo)], 非法，应该为字符型(In 论文段落版本(gs_PaperParagraphV))!(clsgs_PaperParagraphVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphVEN.paperId) == false && undefined !== pobjgs_PaperParagraphVEN.paperId && tzDataType.isString(pobjgs_PaperParagraphVEN.paperId) === false)
{
 throw new Error("(errid:Watl000060)字段[论文Id(paperId)]的值:[$(pobjgs_PaperParagraphVEN.paperId)], 非法，应该为字符型(In 论文段落版本(gs_PaperParagraphV))!(clsgs_PaperParagraphVBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjgs_PaperParagraphVEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function gs_PaperParagraphV_CheckProperty4Update (pobjgs_PaperParagraphVEN: clsgs_PaperParagraphVEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjgs_PaperParagraphVEN.paragraphId) == false && GetStrLen(pobjgs_PaperParagraphVEN.paragraphId) > 10)
{
 throw new Error("(errid:Watl000062)字段[段落Id(paragraphId)]的长度不能超过10(In 论文段落版本(gs_PaperParagraphV))!值:$(pobjgs_PaperParagraphVEN.paragraphId)(clsgs_PaperParagraphVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphVEN.sectionId) == false && GetStrLen(pobjgs_PaperParagraphVEN.sectionId) > 8)
{
 throw new Error("(errid:Watl000062)字段[节Id(sectionId)]的长度不能超过8(In 论文段落版本(gs_PaperParagraphV))!值:$(pobjgs_PaperParagraphVEN.sectionId)(clsgs_PaperParagraphVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphVEN.paragraphTypeId) == false && GetStrLen(pobjgs_PaperParagraphVEN.paragraphTypeId) > 2)
{
 throw new Error("(errid:Watl000062)字段[段落类型Id(paragraphTypeId)]的长度不能超过2(In 论文段落版本(gs_PaperParagraphV))!值:$(pobjgs_PaperParagraphVEN.paragraphTypeId)(clsgs_PaperParagraphVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphVEN.updDate) == false && GetStrLen(pobjgs_PaperParagraphVEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 论文段落版本(gs_PaperParagraphV))!值:$(pobjgs_PaperParagraphVEN.updDate)(clsgs_PaperParagraphVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphVEN.updUser) == false && GetStrLen(pobjgs_PaperParagraphVEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 论文段落版本(gs_PaperParagraphV))!值:$(pobjgs_PaperParagraphVEN.updUser)(clsgs_PaperParagraphVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphVEN.memo) == false && GetStrLen(pobjgs_PaperParagraphVEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 论文段落版本(gs_PaperParagraphV))!值:$(pobjgs_PaperParagraphVEN.memo)(clsgs_PaperParagraphVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphVEN.paperId) == false && GetStrLen(pobjgs_PaperParagraphVEN.paperId) > 8)
{
 throw new Error("(errid:Watl000062)字段[论文Id(paperId)]的长度不能超过8(In 论文段落版本(gs_PaperParagraphV))!值:$(pobjgs_PaperParagraphVEN.paperId)(clsgs_PaperParagraphVBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null != pobjgs_PaperParagraphVEN.paragraphVId && undefined !== pobjgs_PaperParagraphVEN.paragraphVId && tzDataType.isNumber(pobjgs_PaperParagraphVEN.paragraphVId) === false)
{
 throw new Error("(errid:Watl000063)字段[段落版本Id(paragraphVId)]的值:[$(pobjgs_PaperParagraphVEN.paragraphVId)], 非法，应该为数值型(In 论文段落版本(gs_PaperParagraphV))!(clsgs_PaperParagraphVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphVEN.paragraphId) == false && undefined !== pobjgs_PaperParagraphVEN.paragraphId && tzDataType.isString(pobjgs_PaperParagraphVEN.paragraphId) === false)
{
 throw new Error("(errid:Watl000063)字段[段落Id(paragraphId)]的值:[$(pobjgs_PaperParagraphVEN.paragraphId)], 非法，应该为字符型(In 论文段落版本(gs_PaperParagraphV))!(clsgs_PaperParagraphVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphVEN.sectionId) == false && undefined !== pobjgs_PaperParagraphVEN.sectionId && tzDataType.isString(pobjgs_PaperParagraphVEN.sectionId) === false)
{
 throw new Error("(errid:Watl000063)字段[节Id(sectionId)]的值:[$(pobjgs_PaperParagraphVEN.sectionId)], 非法，应该为字符型(In 论文段落版本(gs_PaperParagraphV))!(clsgs_PaperParagraphVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphVEN.paragraphTypeId) == false && undefined !== pobjgs_PaperParagraphVEN.paragraphTypeId && tzDataType.isString(pobjgs_PaperParagraphVEN.paragraphTypeId) === false)
{
 throw new Error("(errid:Watl000063)字段[段落类型Id(paragraphTypeId)]的值:[$(pobjgs_PaperParagraphVEN.paragraphTypeId)], 非法，应该为字符型(In 论文段落版本(gs_PaperParagraphV))!(clsgs_PaperParagraphVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphVEN.paragraphContent) == false && undefined !== pobjgs_PaperParagraphVEN.paragraphContent && tzDataType.isString(pobjgs_PaperParagraphVEN.paragraphContent) === false)
{
 throw new Error("(errid:Watl000063)字段[段落内容(paragraphContent)]的值:[$(pobjgs_PaperParagraphVEN.paragraphContent)], 非法，应该为字符型(In 论文段落版本(gs_PaperParagraphV))!(clsgs_PaperParagraphVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphVEN.updDate) == false && undefined !== pobjgs_PaperParagraphVEN.updDate && tzDataType.isString(pobjgs_PaperParagraphVEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjgs_PaperParagraphVEN.updDate)], 非法，应该为字符型(In 论文段落版本(gs_PaperParagraphV))!(clsgs_PaperParagraphVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphVEN.updUser) == false && undefined !== pobjgs_PaperParagraphVEN.updUser && tzDataType.isString(pobjgs_PaperParagraphVEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjgs_PaperParagraphVEN.updUser)], 非法，应该为字符型(In 论文段落版本(gs_PaperParagraphV))!(clsgs_PaperParagraphVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphVEN.memo) == false && undefined !== pobjgs_PaperParagraphVEN.memo && tzDataType.isString(pobjgs_PaperParagraphVEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjgs_PaperParagraphVEN.memo)], 非法，应该为字符型(In 论文段落版本(gs_PaperParagraphV))!(clsgs_PaperParagraphVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphVEN.paperId) == false && undefined !== pobjgs_PaperParagraphVEN.paperId && tzDataType.isString(pobjgs_PaperParagraphVEN.paperId) === false)
{
 throw new Error("(errid:Watl000063)字段[论文Id(paperId)]的值:[$(pobjgs_PaperParagraphVEN.paperId)], 非法，应该为字符型(In 论文段落版本(gs_PaperParagraphV))!(clsgs_PaperParagraphVBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjgs_PaperParagraphVEN.paragraphVId 
 || pobjgs_PaperParagraphVEN.paragraphVId != null && pobjgs_PaperParagraphVEN.paragraphVId.toString()  ===  "")
{
 throw new Error("(errid:Watl000064)字段[段落版本Id]不能为空(In 论文段落版本)!(clsgs_PaperParagraphVBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjgs_PaperParagraphVEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function gs_PaperParagraphV_GetJSONStrByObj (pobjgs_PaperParagraphVEN: clsgs_PaperParagraphVEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjgs_PaperParagraphVEN.sf_UpdFldSetStr = pobjgs_PaperParagraphVEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjgs_PaperParagraphVEN);
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
export function gs_PaperParagraphV_GetObjLstByJSONStr (strJSON: string): Array<clsgs_PaperParagraphVEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrgs_PaperParagraphVObjLst = new Array<clsgs_PaperParagraphVEN>();
if (strJSON === "")
{
return arrgs_PaperParagraphVObjLst;
}
try
{
arrgs_PaperParagraphVObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrgs_PaperParagraphVObjLst;
}
return arrgs_PaperParagraphVObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrgs_PaperParagraphVObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function gs_PaperParagraphV_GetObjLstByJSONObjLst (arrgs_PaperParagraphVObjLstS: Array<clsgs_PaperParagraphVEN>): Array<clsgs_PaperParagraphVEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrgs_PaperParagraphVObjLst = new Array<clsgs_PaperParagraphVEN>();
for (const objInFor of arrgs_PaperParagraphVObjLstS) {
const obj1 = gs_PaperParagraphV_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrgs_PaperParagraphVObjLst.push(obj1);
}
return arrgs_PaperParagraphVObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function gs_PaperParagraphV_GetObjByJSONStr (strJSON: string): clsgs_PaperParagraphVEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjgs_PaperParagraphVEN = new clsgs_PaperParagraphVEN();
if (strJSON === "")
{
return pobjgs_PaperParagraphVEN;
}
try
{
pobjgs_PaperParagraphVEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjgs_PaperParagraphVEN;
}
return pobjgs_PaperParagraphVEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function gs_PaperParagraphV_GetCombineCondition(objgs_PaperParagraphV_Cond: clsgs_PaperParagraphVEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objgs_PaperParagraphV_Cond.dicFldComparisonOp, clsgs_PaperParagraphVEN.con_ParagraphVId) == true)
{
const strComparisonOp_ParagraphVId:string = objgs_PaperParagraphV_Cond.dicFldComparisonOp[clsgs_PaperParagraphVEN.con_ParagraphVId];
strWhereCond += Format(" And {0} {2} {1}", clsgs_PaperParagraphVEN.con_ParagraphVId, objgs_PaperParagraphV_Cond.paragraphVId, strComparisonOp_ParagraphVId);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperParagraphV_Cond.dicFldComparisonOp, clsgs_PaperParagraphVEN.con_ParagraphId) == true)
{
const strComparisonOp_ParagraphId:string = objgs_PaperParagraphV_Cond.dicFldComparisonOp[clsgs_PaperParagraphVEN.con_ParagraphId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperParagraphVEN.con_ParagraphId, objgs_PaperParagraphV_Cond.paragraphId, strComparisonOp_ParagraphId);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperParagraphV_Cond.dicFldComparisonOp, clsgs_PaperParagraphVEN.con_SectionId) == true)
{
const strComparisonOp_SectionId:string = objgs_PaperParagraphV_Cond.dicFldComparisonOp[clsgs_PaperParagraphVEN.con_SectionId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperParagraphVEN.con_SectionId, objgs_PaperParagraphV_Cond.sectionId, strComparisonOp_SectionId);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperParagraphV_Cond.dicFldComparisonOp, clsgs_PaperParagraphVEN.con_ParagraphTypeId) == true)
{
const strComparisonOp_ParagraphTypeId:string = objgs_PaperParagraphV_Cond.dicFldComparisonOp[clsgs_PaperParagraphVEN.con_ParagraphTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperParagraphVEN.con_ParagraphTypeId, objgs_PaperParagraphV_Cond.paragraphTypeId, strComparisonOp_ParagraphTypeId);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objgs_PaperParagraphV_Cond.dicFldComparisonOp, clsgs_PaperParagraphVEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objgs_PaperParagraphV_Cond.dicFldComparisonOp[clsgs_PaperParagraphVEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperParagraphVEN.con_UpdDate, objgs_PaperParagraphV_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperParagraphV_Cond.dicFldComparisonOp, clsgs_PaperParagraphVEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objgs_PaperParagraphV_Cond.dicFldComparisonOp[clsgs_PaperParagraphVEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperParagraphVEN.con_UpdUser, objgs_PaperParagraphV_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperParagraphV_Cond.dicFldComparisonOp, clsgs_PaperParagraphVEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objgs_PaperParagraphV_Cond.dicFldComparisonOp[clsgs_PaperParagraphVEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperParagraphVEN.con_Memo, objgs_PaperParagraphV_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperParagraphV_Cond.dicFldComparisonOp, clsgs_PaperParagraphVEN.con_PaperId) == true)
{
const strComparisonOp_PaperId:string = objgs_PaperParagraphV_Cond.dicFldComparisonOp[clsgs_PaperParagraphVEN.con_PaperId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperParagraphVEN.con_PaperId, objgs_PaperParagraphV_Cond.paperId, strComparisonOp_PaperId);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--gs_PaperParagraphV(论文段落版本),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param lngParagraphVId: 段落版本Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function gs_PaperParagraphV_GetUniCondStr_ParagraphVId(objgs_PaperParagraphVEN: clsgs_PaperParagraphVEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and ParagraphVId = '{0}'", objgs_PaperParagraphVEN.paragraphVId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--gs_PaperParagraphV(论文段落版本),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param lngParagraphVId: 段落版本Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function gs_PaperParagraphV_GetUniCondStr4Update_ParagraphVId(objgs_PaperParagraphVEN: clsgs_PaperParagraphVEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and ParagraphVId <> '{0}'", objgs_PaperParagraphVEN.paragraphVId);
 strWhereCond +=  Format(" and ParagraphVId = '{0}'", objgs_PaperParagraphVEN.paragraphVId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objgs_PaperParagraphVENS:源对象
 * @param objgs_PaperParagraphVENT:目标对象
*/
export function gs_PaperParagraphV_CopyObjTo(objgs_PaperParagraphVENS: clsgs_PaperParagraphVEN , objgs_PaperParagraphVENT: clsgs_PaperParagraphVEN ): void 
{
objgs_PaperParagraphVENT.paragraphVId = objgs_PaperParagraphVENS.paragraphVId; //段落版本Id
objgs_PaperParagraphVENT.paragraphId = objgs_PaperParagraphVENS.paragraphId; //段落Id
objgs_PaperParagraphVENT.sectionId = objgs_PaperParagraphVENS.sectionId; //节Id
objgs_PaperParagraphVENT.paragraphTypeId = objgs_PaperParagraphVENS.paragraphTypeId; //段落类型Id
objgs_PaperParagraphVENT.paragraphContent = objgs_PaperParagraphVENS.paragraphContent; //段落内容
objgs_PaperParagraphVENT.updDate = objgs_PaperParagraphVENS.updDate; //修改日期
objgs_PaperParagraphVENT.updUser = objgs_PaperParagraphVENS.updUser; //修改人
objgs_PaperParagraphVENT.memo = objgs_PaperParagraphVENS.memo; //备注
objgs_PaperParagraphVENT.paperId = objgs_PaperParagraphVENS.paperId; //论文Id
objgs_PaperParagraphVENT.sf_UpdFldSetStr = objgs_PaperParagraphVENS.updFldString; //sf_UpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objgs_PaperParagraphVENS:源对象
 * @param objgs_PaperParagraphVENT:目标对象
*/
export function gs_PaperParagraphV_GetObjFromJsonObj(objgs_PaperParagraphVENS: clsgs_PaperParagraphVEN): clsgs_PaperParagraphVEN 
{
 const objgs_PaperParagraphVENT: clsgs_PaperParagraphVEN = new clsgs_PaperParagraphVEN();
ObjectAssign(objgs_PaperParagraphVENT, objgs_PaperParagraphVENS);
 return objgs_PaperParagraphVENT;
}