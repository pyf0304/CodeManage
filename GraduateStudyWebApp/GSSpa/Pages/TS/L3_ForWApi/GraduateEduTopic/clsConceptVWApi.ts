
 /**
 * 类名:clsConceptVWApi
 * 表名:ConceptV(01120649)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:46:59
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
 * 概念版本表(ConceptV)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { clsConceptVEN } from "../../L0_Entity/GraduateEduTopic/clsConceptVEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { tzDataType } from "../../PubFun/jsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const conceptV_Controller = "ConceptVApi";
 export const conceptV_ConstructorName = "conceptV";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngConceptVId:关键字
 * @returns 对象
 **/
export async function ConceptV_GetObjByConceptVIdAsync(lngConceptVId: number): Promise<clsConceptVEN>  
{
const strThisFuncName = "GetObjByConceptVIdAsync";

if (lngConceptVId == 0)
{
  const strMsg = Format("参数:[lngConceptVId]不能为空！(In GetObjByConceptVIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjByConceptVId";
const strUrl = GetWebApiUrl(conceptV_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"lngConceptVId": lngConceptVId,
}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObj = data.returnObj;
if (returnObj == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", conceptV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objConceptV = ConceptV_GetObjFromJsonObj(returnObj);
return objConceptV;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptV_ConstructorName, strThisFuncName);
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
export function ConceptV_SortFun_Defa(a:clsConceptVEN , b:clsConceptVEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.conceptVId-b.conceptVId;
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
export function ConceptV_SortFun_Defa_2Fld(a:clsConceptVEN , b:clsConceptVEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.conceptId == b.conceptId) return a.conceptContent.localeCompare(b.conceptContent);
else return a.conceptId.localeCompare(b.conceptId);
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
export function ConceptV_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsConceptVEN.con_ConceptVId:
return (a: clsConceptVEN, b: clsConceptVEN) => {
return a.conceptVId-b.conceptVId;
}
case clsConceptVEN.con_ConceptId:
return (a: clsConceptVEN, b: clsConceptVEN) => {
return a.conceptId.localeCompare(b.conceptId);
}
case clsConceptVEN.con_ConceptContent:
return (a: clsConceptVEN, b: clsConceptVEN) => {
return a.conceptContent.localeCompare(b.conceptContent);
}
case clsConceptVEN.con_ConceptName:
return (a: clsConceptVEN, b: clsConceptVEN) => {
return a.conceptName.localeCompare(b.conceptName);
}
case clsConceptVEN.con_CitationId:
return (a: clsConceptVEN, b: clsConceptVEN) => {
return a.citationId.localeCompare(b.citationId);
}
case clsConceptVEN.con_UpdDate:
return (a: clsConceptVEN, b: clsConceptVEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsConceptVEN.con_UpdUser:
return (a: clsConceptVEN, b: clsConceptVEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsConceptVEN.con_id_CurrEduCls:
return (a: clsConceptVEN, b: clsConceptVEN) => {
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
case clsConceptVEN.con_PdfContent:
return (a: clsConceptVEN, b: clsConceptVEN) => {
return a.pdfContent.localeCompare(b.pdfContent);
}
case clsConceptVEN.con_PdfPageNum:
return (a: clsConceptVEN, b: clsConceptVEN) => {
return a.pdfPageNum-b.pdfPageNum;
}
case clsConceptVEN.con_Memo:
return (a: clsConceptVEN, b: clsConceptVEN) => {
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[ConceptV]中不存在！(in ${ conceptV_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsConceptVEN.con_ConceptVId:
return (a: clsConceptVEN, b: clsConceptVEN) => {
return b.conceptVId-a.conceptVId;
}
case clsConceptVEN.con_ConceptId:
return (a: clsConceptVEN, b: clsConceptVEN) => {
return b.conceptId.localeCompare(a.conceptId);
}
case clsConceptVEN.con_ConceptContent:
return (a: clsConceptVEN, b: clsConceptVEN) => {
return b.conceptContent.localeCompare(a.conceptContent);
}
case clsConceptVEN.con_ConceptName:
return (a: clsConceptVEN, b: clsConceptVEN) => {
return b.conceptName.localeCompare(a.conceptName);
}
case clsConceptVEN.con_CitationId:
return (a: clsConceptVEN, b: clsConceptVEN) => {
return b.citationId.localeCompare(a.citationId);
}
case clsConceptVEN.con_UpdDate:
return (a: clsConceptVEN, b: clsConceptVEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsConceptVEN.con_UpdUser:
return (a: clsConceptVEN, b: clsConceptVEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsConceptVEN.con_id_CurrEduCls:
return (a: clsConceptVEN, b: clsConceptVEN) => {
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
case clsConceptVEN.con_PdfContent:
return (a: clsConceptVEN, b: clsConceptVEN) => {
return b.pdfContent.localeCompare(a.pdfContent);
}
case clsConceptVEN.con_PdfPageNum:
return (a: clsConceptVEN, b: clsConceptVEN) => {
return b.pdfPageNum-a.pdfPageNum;
}
case clsConceptVEN.con_Memo:
return (a: clsConceptVEN, b: clsConceptVEN) => {
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[ConceptV]中不存在！(in ${ conceptV_ConstructorName}.${ strThisFuncName})`;
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
export async function ConceptV_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsConceptVEN.con_ConceptVId:
return (obj: clsConceptVEN) => {
return obj.conceptVId === value;
}
case clsConceptVEN.con_ConceptId:
return (obj: clsConceptVEN) => {
return obj.conceptId === value;
}
case clsConceptVEN.con_ConceptContent:
return (obj: clsConceptVEN) => {
return obj.conceptContent === value;
}
case clsConceptVEN.con_ConceptName:
return (obj: clsConceptVEN) => {
return obj.conceptName === value;
}
case clsConceptVEN.con_CitationId:
return (obj: clsConceptVEN) => {
return obj.citationId === value;
}
case clsConceptVEN.con_UpdDate:
return (obj: clsConceptVEN) => {
return obj.updDate === value;
}
case clsConceptVEN.con_UpdUser:
return (obj: clsConceptVEN) => {
return obj.updUser === value;
}
case clsConceptVEN.con_id_CurrEduCls:
return (obj: clsConceptVEN) => {
return obj.id_CurrEduCls === value;
}
case clsConceptVEN.con_PdfContent:
return (obj: clsConceptVEN) => {
return obj.pdfContent === value;
}
case clsConceptVEN.con_PdfPageNum:
return (obj: clsConceptVEN) => {
return obj.pdfPageNum === value;
}
case clsConceptVEN.con_Memo:
return (obj: clsConceptVEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[ConceptV]中不存在！(in ${ conceptV_ConstructorName}.${ strThisFuncName})`;
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
export async function ConceptV_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(conceptV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptV_ConstructorName, strThisFuncName);
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
export async function ConceptV_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(conceptV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptV_ConstructorName, strThisFuncName);
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
export async function ConceptV_GetFirstObjAsync(strWhereCond: string): Promise<clsConceptVEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(conceptV_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", conceptV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objConceptV = ConceptV_GetObjFromJsonObj(returnObj);
return objConceptV;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptV_ConstructorName, strThisFuncName);
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
export async function ConceptV_GetObjLstAsync(strWhereCond: string): Promise<Array<clsConceptVEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(conceptV_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", conceptV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = ConceptV_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptV_ConstructorName, strThisFuncName);
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
 * @param arrConceptVId:关键字列表
 * @returns 对象列表
 **/
export async function ConceptV_GetObjLstByConceptVIdLstAsync(arrConceptVId: Array<string>): Promise<Array<clsConceptVEN>>  
{
const strThisFuncName = "GetObjLstByConceptVIdLstAsync";
const strAction = "GetObjLstByConceptVIdLst";
const strUrl = GetWebApiUrl(conceptV_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrConceptVId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", conceptV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = ConceptV_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptV_ConstructorName, strThisFuncName);
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
export async function ConceptV_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsConceptVEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(conceptV_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", conceptV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = ConceptV_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptV_ConstructorName, strThisFuncName);
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
export async function ConceptV_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsConceptVEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(conceptV_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", conceptV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = ConceptV_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptV_ConstructorName, strThisFuncName);
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
export async function ConceptV_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(conceptV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptV_ConstructorName, strThisFuncName);
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
export async function ConceptV_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsConceptVEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(conceptV_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", conceptV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = ConceptV_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptV_ConstructorName, strThisFuncName);
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
 * @param lngConceptVId:关键字
 * @returns 获取删除的结果
 **/
export async function ConceptV_DelRecordAsync(lngConceptVId: number): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(conceptV_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, lngConceptVId);
try
{
const response = await axios.delete(strUrl,
{
params: { "Id": lngConceptVId, }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptV_ConstructorName, strThisFuncName);
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
 * @param arrConceptVId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function ConceptV_DelConceptVsAsync(arrConceptVId: Array<string>): Promise<number> 
{
const strThisFuncName = "DelConceptVsAsync";
const strAction = "DelConceptVs";
const strUrl = GetWebApiUrl(conceptV_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrConceptVId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptV_ConstructorName, strThisFuncName);
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
export async function ConceptV_DelConceptVsByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "DelConceptVsByCondAsync";
const strAction = "DelConceptVsByCond";
const strUrl = GetWebApiUrl(conceptV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptV_ConstructorName, strThisFuncName);
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
 * @param objConceptVEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function ConceptV_AddNewRecordAsync(objConceptVEN: clsConceptVEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objConceptVEN);
const strUrl = GetWebApiUrl(conceptV_Controller, strAction);
try
{
const response = await axios.post(strUrl, objConceptVEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptV_ConstructorName, strThisFuncName);
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
 * @param objConceptVEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function ConceptV_AddNewRecordWithReturnKeyAsync(objConceptVEN: clsConceptVEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(conceptV_Controller, strAction);
try
{
const response = await axios.post(strUrl, objConceptVEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptV_ConstructorName, strThisFuncName);
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
 * @param objConceptVEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function ConceptV_AddNewRecordWithReturnKey(objConceptVEN: clsConceptVEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objConceptVEN.conceptVId === null || objConceptVEN.conceptVId === 0)
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(conceptV_Controller, strAction);
try
{
const response = await axios.post(strUrl, objConceptVEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptV_ConstructorName, strThisFuncName);
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
 * @param objConceptVEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function ConceptV_UpdateRecordAsync(objConceptVEN: clsConceptVEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objConceptVEN.sf_UpdFldSetStr === undefined || objConceptVEN.sf_UpdFldSetStr === null || objConceptVEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objConceptVEN.conceptVId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(conceptV_Controller, strAction);
try
{
const response = await axios.post(strUrl, objConceptVEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptV_ConstructorName, strThisFuncName);
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
 * @param objConceptVEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function ConceptV_UpdateWithConditionAsync(objConceptVEN: clsConceptVEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objConceptVEN.sf_UpdFldSetStr === undefined || objConceptVEN.sf_UpdFldSetStr === null || objConceptVEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objConceptVEN.conceptVId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(conceptV_Controller, strAction);
objConceptVEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objConceptVEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptV_ConstructorName, strThisFuncName);
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
export async function ConceptV_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(conceptV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptV_ConstructorName, strThisFuncName);
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
 * @param lngConceptVId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function ConceptV_IsExist(lngConceptVId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(conceptV_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"ConceptVId": lngConceptVId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptV_ConstructorName, strThisFuncName);
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
 * @param lngConceptVId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function ConceptV_IsExistAsync(lngConceptVId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(conceptV_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "lngConceptVId": lngConceptVId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptV_ConstructorName, strThisFuncName);
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
export async function ConceptV_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(conceptV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptV_ConstructorName, strThisFuncName);
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
export async function ConceptV_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(conceptV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptV_ConstructorName, strThisFuncName);
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
export function ConceptV_GetWebApiUrl(strController: string, strAction: string): string {
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
export function ConceptV_CheckPropertyNew(pobjConceptVEN: clsConceptVEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjConceptVEN.conceptId) === true )
{
 throw new Error("(errid:Watl000058)字段[概念Id]不能为空(In 概念版本表)!(clsConceptVBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjConceptVEN.conceptId) == false && GetStrLen(pobjConceptVEN.conceptId) > 8)
{
 throw new Error("(errid:Watl000059)字段[概念Id(conceptId)]的长度不能超过8(In 概念版本表(ConceptV))!值:$(pobjConceptVEN.conceptId)(clsConceptVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjConceptVEN.conceptName) == false && GetStrLen(pobjConceptVEN.conceptName) > 500)
{
 throw new Error("(errid:Watl000059)字段[概念名称(conceptName)]的长度不能超过500(In 概念版本表(ConceptV))!值:$(pobjConceptVEN.conceptName)(clsConceptVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjConceptVEN.citationId) == false && GetStrLen(pobjConceptVEN.citationId) > 8)
{
 throw new Error("(errid:Watl000059)字段[引用Id(citationId)]的长度不能超过8(In 概念版本表(ConceptV))!值:$(pobjConceptVEN.citationId)(clsConceptVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjConceptVEN.updDate) == false && GetStrLen(pobjConceptVEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 概念版本表(ConceptV))!值:$(pobjConceptVEN.updDate)(clsConceptVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjConceptVEN.updUser) == false && GetStrLen(pobjConceptVEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 概念版本表(ConceptV))!值:$(pobjConceptVEN.updUser)(clsConceptVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjConceptVEN.id_CurrEduCls) == false && GetStrLen(pobjConceptVEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 概念版本表(ConceptV))!值:$(pobjConceptVEN.id_CurrEduCls)(clsConceptVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjConceptVEN.pdfContent) == false && GetStrLen(pobjConceptVEN.pdfContent) > 2000)
{
 throw new Error("(errid:Watl000059)字段[Pdf内容(pdfContent)]的长度不能超过2000(In 概念版本表(ConceptV))!值:$(pobjConceptVEN.pdfContent)(clsConceptVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjConceptVEN.memo) == false && GetStrLen(pobjConceptVEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 概念版本表(ConceptV))!值:$(pobjConceptVEN.memo)(clsConceptVBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null != pobjConceptVEN.conceptVId && undefined !== pobjConceptVEN.conceptVId && tzDataType.isNumber(pobjConceptVEN.conceptVId) === false)
{
 throw new Error("(errid:Watl000060)字段[ConceptVId(conceptVId)]的值:[$(pobjConceptVEN.conceptVId)], 非法，应该为数值型(In 概念版本表(ConceptV))!(clsConceptVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjConceptVEN.conceptId) == false && undefined !== pobjConceptVEN.conceptId && tzDataType.isString(pobjConceptVEN.conceptId) === false)
{
 throw new Error("(errid:Watl000060)字段[概念Id(conceptId)]的值:[$(pobjConceptVEN.conceptId)], 非法，应该为字符型(In 概念版本表(ConceptV))!(clsConceptVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjConceptVEN.conceptContent) == false && undefined !== pobjConceptVEN.conceptContent && tzDataType.isString(pobjConceptVEN.conceptContent) === false)
{
 throw new Error("(errid:Watl000060)字段[概念内容(conceptContent)]的值:[$(pobjConceptVEN.conceptContent)], 非法，应该为字符型(In 概念版本表(ConceptV))!(clsConceptVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjConceptVEN.conceptName) == false && undefined !== pobjConceptVEN.conceptName && tzDataType.isString(pobjConceptVEN.conceptName) === false)
{
 throw new Error("(errid:Watl000060)字段[概念名称(conceptName)]的值:[$(pobjConceptVEN.conceptName)], 非法，应该为字符型(In 概念版本表(ConceptV))!(clsConceptVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjConceptVEN.citationId) == false && undefined !== pobjConceptVEN.citationId && tzDataType.isString(pobjConceptVEN.citationId) === false)
{
 throw new Error("(errid:Watl000060)字段[引用Id(citationId)]的值:[$(pobjConceptVEN.citationId)], 非法，应该为字符型(In 概念版本表(ConceptV))!(clsConceptVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjConceptVEN.updDate) == false && undefined !== pobjConceptVEN.updDate && tzDataType.isString(pobjConceptVEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjConceptVEN.updDate)], 非法，应该为字符型(In 概念版本表(ConceptV))!(clsConceptVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjConceptVEN.updUser) == false && undefined !== pobjConceptVEN.updUser && tzDataType.isString(pobjConceptVEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjConceptVEN.updUser)], 非法，应该为字符型(In 概念版本表(ConceptV))!(clsConceptVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjConceptVEN.id_CurrEduCls) == false && undefined !== pobjConceptVEN.id_CurrEduCls && tzDataType.isString(pobjConceptVEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjConceptVEN.id_CurrEduCls)], 非法，应该为字符型(In 概念版本表(ConceptV))!(clsConceptVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjConceptVEN.pdfContent) == false && undefined !== pobjConceptVEN.pdfContent && tzDataType.isString(pobjConceptVEN.pdfContent) === false)
{
 throw new Error("(errid:Watl000060)字段[Pdf内容(pdfContent)]的值:[$(pobjConceptVEN.pdfContent)], 非法，应该为字符型(In 概念版本表(ConceptV))!(clsConceptVBL:CheckPropertyNew)");
}
if (null != pobjConceptVEN.pdfPageNum && undefined !== pobjConceptVEN.pdfPageNum && tzDataType.isNumber(pobjConceptVEN.pdfPageNum) === false)
{
 throw new Error("(errid:Watl000060)字段[Pdf页码(pdfPageNum)]的值:[$(pobjConceptVEN.pdfPageNum)], 非法，应该为数值型(In 概念版本表(ConceptV))!(clsConceptVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjConceptVEN.memo) == false && undefined !== pobjConceptVEN.memo && tzDataType.isString(pobjConceptVEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjConceptVEN.memo)], 非法，应该为字符型(In 概念版本表(ConceptV))!(clsConceptVBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjConceptVEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function ConceptV_CheckProperty4Update (pobjConceptVEN: clsConceptVEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjConceptVEN.conceptId) == false && GetStrLen(pobjConceptVEN.conceptId) > 8)
{
 throw new Error("(errid:Watl000062)字段[概念Id(conceptId)]的长度不能超过8(In 概念版本表(ConceptV))!值:$(pobjConceptVEN.conceptId)(clsConceptVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjConceptVEN.conceptName) == false && GetStrLen(pobjConceptVEN.conceptName) > 500)
{
 throw new Error("(errid:Watl000062)字段[概念名称(conceptName)]的长度不能超过500(In 概念版本表(ConceptV))!值:$(pobjConceptVEN.conceptName)(clsConceptVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjConceptVEN.citationId) == false && GetStrLen(pobjConceptVEN.citationId) > 8)
{
 throw new Error("(errid:Watl000062)字段[引用Id(citationId)]的长度不能超过8(In 概念版本表(ConceptV))!值:$(pobjConceptVEN.citationId)(clsConceptVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjConceptVEN.updDate) == false && GetStrLen(pobjConceptVEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 概念版本表(ConceptV))!值:$(pobjConceptVEN.updDate)(clsConceptVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjConceptVEN.updUser) == false && GetStrLen(pobjConceptVEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 概念版本表(ConceptV))!值:$(pobjConceptVEN.updUser)(clsConceptVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjConceptVEN.id_CurrEduCls) == false && GetStrLen(pobjConceptVEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 概念版本表(ConceptV))!值:$(pobjConceptVEN.id_CurrEduCls)(clsConceptVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjConceptVEN.pdfContent) == false && GetStrLen(pobjConceptVEN.pdfContent) > 2000)
{
 throw new Error("(errid:Watl000062)字段[Pdf内容(pdfContent)]的长度不能超过2000(In 概念版本表(ConceptV))!值:$(pobjConceptVEN.pdfContent)(clsConceptVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjConceptVEN.memo) == false && GetStrLen(pobjConceptVEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 概念版本表(ConceptV))!值:$(pobjConceptVEN.memo)(clsConceptVBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null != pobjConceptVEN.conceptVId && undefined !== pobjConceptVEN.conceptVId && tzDataType.isNumber(pobjConceptVEN.conceptVId) === false)
{
 throw new Error("(errid:Watl000063)字段[ConceptVId(conceptVId)]的值:[$(pobjConceptVEN.conceptVId)], 非法，应该为数值型(In 概念版本表(ConceptV))!(clsConceptVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjConceptVEN.conceptId) == false && undefined !== pobjConceptVEN.conceptId && tzDataType.isString(pobjConceptVEN.conceptId) === false)
{
 throw new Error("(errid:Watl000063)字段[概念Id(conceptId)]的值:[$(pobjConceptVEN.conceptId)], 非法，应该为字符型(In 概念版本表(ConceptV))!(clsConceptVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjConceptVEN.conceptContent) == false && undefined !== pobjConceptVEN.conceptContent && tzDataType.isString(pobjConceptVEN.conceptContent) === false)
{
 throw new Error("(errid:Watl000063)字段[概念内容(conceptContent)]的值:[$(pobjConceptVEN.conceptContent)], 非法，应该为字符型(In 概念版本表(ConceptV))!(clsConceptVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjConceptVEN.conceptName) == false && undefined !== pobjConceptVEN.conceptName && tzDataType.isString(pobjConceptVEN.conceptName) === false)
{
 throw new Error("(errid:Watl000063)字段[概念名称(conceptName)]的值:[$(pobjConceptVEN.conceptName)], 非法，应该为字符型(In 概念版本表(ConceptV))!(clsConceptVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjConceptVEN.citationId) == false && undefined !== pobjConceptVEN.citationId && tzDataType.isString(pobjConceptVEN.citationId) === false)
{
 throw new Error("(errid:Watl000063)字段[引用Id(citationId)]的值:[$(pobjConceptVEN.citationId)], 非法，应该为字符型(In 概念版本表(ConceptV))!(clsConceptVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjConceptVEN.updDate) == false && undefined !== pobjConceptVEN.updDate && tzDataType.isString(pobjConceptVEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjConceptVEN.updDate)], 非法，应该为字符型(In 概念版本表(ConceptV))!(clsConceptVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjConceptVEN.updUser) == false && undefined !== pobjConceptVEN.updUser && tzDataType.isString(pobjConceptVEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjConceptVEN.updUser)], 非法，应该为字符型(In 概念版本表(ConceptV))!(clsConceptVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjConceptVEN.id_CurrEduCls) == false && undefined !== pobjConceptVEN.id_CurrEduCls && tzDataType.isString(pobjConceptVEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjConceptVEN.id_CurrEduCls)], 非法，应该为字符型(In 概念版本表(ConceptV))!(clsConceptVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjConceptVEN.pdfContent) == false && undefined !== pobjConceptVEN.pdfContent && tzDataType.isString(pobjConceptVEN.pdfContent) === false)
{
 throw new Error("(errid:Watl000063)字段[Pdf内容(pdfContent)]的值:[$(pobjConceptVEN.pdfContent)], 非法，应该为字符型(In 概念版本表(ConceptV))!(clsConceptVBL:CheckProperty4Update)");
}
if (null != pobjConceptVEN.pdfPageNum && undefined !== pobjConceptVEN.pdfPageNum && tzDataType.isNumber(pobjConceptVEN.pdfPageNum) === false)
{
 throw new Error("(errid:Watl000063)字段[Pdf页码(pdfPageNum)]的值:[$(pobjConceptVEN.pdfPageNum)], 非法，应该为数值型(In 概念版本表(ConceptV))!(clsConceptVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjConceptVEN.memo) == false && undefined !== pobjConceptVEN.memo && tzDataType.isString(pobjConceptVEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjConceptVEN.memo)], 非法，应该为字符型(In 概念版本表(ConceptV))!(clsConceptVBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjConceptVEN.conceptVId 
 || pobjConceptVEN.conceptVId != null && pobjConceptVEN.conceptVId.toString()  ===  "")
{
 throw new Error("(errid:Watl000064)字段[ConceptVId]不能为空(In 概念版本表)!(clsConceptVBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjConceptVEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function ConceptV_GetJSONStrByObj (pobjConceptVEN: clsConceptVEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjConceptVEN.sf_UpdFldSetStr = pobjConceptVEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjConceptVEN);
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
export function ConceptV_GetObjLstByJSONStr (strJSON: string): Array<clsConceptVEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrConceptVObjLst = new Array<clsConceptVEN>();
if (strJSON === "")
{
return arrConceptVObjLst;
}
try
{
arrConceptVObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrConceptVObjLst;
}
return arrConceptVObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrConceptVObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function ConceptV_GetObjLstByJSONObjLst (arrConceptVObjLstS: Array<clsConceptVEN>): Array<clsConceptVEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrConceptVObjLst = new Array<clsConceptVEN>();
for (const objInFor of arrConceptVObjLstS) {
const obj1 = ConceptV_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrConceptVObjLst.push(obj1);
}
return arrConceptVObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function ConceptV_GetObjByJSONStr (strJSON: string): clsConceptVEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjConceptVEN = new clsConceptVEN();
if (strJSON === "")
{
return pobjConceptVEN;
}
try
{
pobjConceptVEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjConceptVEN;
}
return pobjConceptVEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function ConceptV_GetCombineCondition(objConceptV_Cond: clsConceptVEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objConceptV_Cond.dicFldComparisonOp, clsConceptVEN.con_ConceptVId) == true)
{
const strComparisonOp_ConceptVId:string = objConceptV_Cond.dicFldComparisonOp[clsConceptVEN.con_ConceptVId];
strWhereCond += Format(" And {0} {2} {1}", clsConceptVEN.con_ConceptVId, objConceptV_Cond.conceptVId, strComparisonOp_ConceptVId);
}
if (Object.prototype.hasOwnProperty.call(objConceptV_Cond.dicFldComparisonOp, clsConceptVEN.con_ConceptId) == true)
{
const strComparisonOp_ConceptId:string = objConceptV_Cond.dicFldComparisonOp[clsConceptVEN.con_ConceptId];
strWhereCond += Format(" And {0} {2} '{1}'", clsConceptVEN.con_ConceptId, objConceptV_Cond.conceptId, strComparisonOp_ConceptId);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objConceptV_Cond.dicFldComparisonOp, clsConceptVEN.con_ConceptName) == true)
{
const strComparisonOp_ConceptName:string = objConceptV_Cond.dicFldComparisonOp[clsConceptVEN.con_ConceptName];
strWhereCond += Format(" And {0} {2} '{1}'", clsConceptVEN.con_ConceptName, objConceptV_Cond.conceptName, strComparisonOp_ConceptName);
}
if (Object.prototype.hasOwnProperty.call(objConceptV_Cond.dicFldComparisonOp, clsConceptVEN.con_CitationId) == true)
{
const strComparisonOp_CitationId:string = objConceptV_Cond.dicFldComparisonOp[clsConceptVEN.con_CitationId];
strWhereCond += Format(" And {0} {2} '{1}'", clsConceptVEN.con_CitationId, objConceptV_Cond.citationId, strComparisonOp_CitationId);
}
if (Object.prototype.hasOwnProperty.call(objConceptV_Cond.dicFldComparisonOp, clsConceptVEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objConceptV_Cond.dicFldComparisonOp[clsConceptVEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsConceptVEN.con_UpdDate, objConceptV_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objConceptV_Cond.dicFldComparisonOp, clsConceptVEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objConceptV_Cond.dicFldComparisonOp[clsConceptVEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsConceptVEN.con_UpdUser, objConceptV_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objConceptV_Cond.dicFldComparisonOp, clsConceptVEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objConceptV_Cond.dicFldComparisonOp[clsConceptVEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsConceptVEN.con_id_CurrEduCls, objConceptV_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (Object.prototype.hasOwnProperty.call(objConceptV_Cond.dicFldComparisonOp, clsConceptVEN.con_PdfContent) == true)
{
const strComparisonOp_PdfContent:string = objConceptV_Cond.dicFldComparisonOp[clsConceptVEN.con_PdfContent];
strWhereCond += Format(" And {0} {2} '{1}'", clsConceptVEN.con_PdfContent, objConceptV_Cond.pdfContent, strComparisonOp_PdfContent);
}
if (Object.prototype.hasOwnProperty.call(objConceptV_Cond.dicFldComparisonOp, clsConceptVEN.con_PdfPageNum) == true)
{
const strComparisonOp_PdfPageNum:string = objConceptV_Cond.dicFldComparisonOp[clsConceptVEN.con_PdfPageNum];
strWhereCond += Format(" And {0} {2} {1}", clsConceptVEN.con_PdfPageNum, objConceptV_Cond.pdfPageNum, strComparisonOp_PdfPageNum);
}
if (Object.prototype.hasOwnProperty.call(objConceptV_Cond.dicFldComparisonOp, clsConceptVEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objConceptV_Cond.dicFldComparisonOp[clsConceptVEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsConceptVEN.con_Memo, objConceptV_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--ConceptV(概念版本表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param lngConceptVId: ConceptVId(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function ConceptV_GetUniCondStr_ConceptVId(objConceptVEN: clsConceptVEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and ConceptVId = '{0}'", objConceptVEN.conceptVId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--ConceptV(概念版本表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param lngConceptVId: ConceptVId(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function ConceptV_GetUniCondStr4Update_ConceptVId(objConceptVEN: clsConceptVEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and ConceptVId <> '{0}'", objConceptVEN.conceptVId);
 strWhereCond +=  Format(" and ConceptVId = '{0}'", objConceptVEN.conceptVId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objConceptVENS:源对象
 * @param objConceptVENT:目标对象
*/
export function ConceptV_CopyObjTo(objConceptVENS: clsConceptVEN , objConceptVENT: clsConceptVEN ): void 
{
objConceptVENT.conceptVId = objConceptVENS.conceptVId; //ConceptVId
objConceptVENT.conceptId = objConceptVENS.conceptId; //概念Id
objConceptVENT.conceptContent = objConceptVENS.conceptContent; //概念内容
objConceptVENT.conceptName = objConceptVENS.conceptName; //概念名称
objConceptVENT.citationId = objConceptVENS.citationId; //引用Id
objConceptVENT.updDate = objConceptVENS.updDate; //修改日期
objConceptVENT.updUser = objConceptVENS.updUser; //修改人
objConceptVENT.id_CurrEduCls = objConceptVENS.id_CurrEduCls; //教学班流水号
objConceptVENT.pdfContent = objConceptVENS.pdfContent; //Pdf内容
objConceptVENT.pdfPageNum = objConceptVENS.pdfPageNum; //Pdf页码
objConceptVENT.memo = objConceptVENS.memo; //备注
objConceptVENT.sf_UpdFldSetStr = objConceptVENS.updFldString; //sf_UpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objConceptVENS:源对象
 * @param objConceptVENT:目标对象
*/
export function ConceptV_GetObjFromJsonObj(objConceptVENS: clsConceptVEN): clsConceptVEN 
{
 const objConceptVENT: clsConceptVEN = new clsConceptVEN();
ObjectAssign(objConceptVENT, objConceptVENS);
 return objConceptVENT;
}