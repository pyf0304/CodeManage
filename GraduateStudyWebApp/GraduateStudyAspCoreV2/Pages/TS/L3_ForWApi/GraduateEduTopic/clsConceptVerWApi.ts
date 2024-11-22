
 /**
 * 类名:clsConceptVerWApi
 * 表名:ConceptVer(01120649)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:48:19
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
 * 概念版本表(ConceptVer)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2023年03月13日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { enumComparisonOp } from "../../PubFun/enumComparisonOp.js";
import { clsConceptVerEN } from "../../L0_Entity/GraduateEduTopic/clsConceptVerEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { tzDataType } from "../../PubFun/clsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const conceptVer_Controller = "ConceptVerApi";
 export const conceptVer_ConstructorName = "conceptVer";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngConceptVId:关键字
 * @returns 对象
 **/
export async function ConceptVer_GetObjByConceptVIdAsync(lngConceptVId: number): Promise<clsConceptVerEN|null>  
{
const strThisFuncName = "GetObjByConceptVIdAsync";

if (lngConceptVId == 0)
{
  const strMsg = Format("参数:[lngConceptVId]不能为空！(In clsConceptVerWApi.GetObjByConceptVIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjByConceptVId";
const strUrl = GetWebApiUrl(conceptVer_Controller, strAction);
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
return null;
}
//console.log(returnObj);
const objConceptVer = ConceptVer_GetObjFromJsonObj(returnObj);
return objConceptVer;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptVer_ConstructorName, strThisFuncName);
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
export function ConceptVer_SortFun_Defa(a:clsConceptVerEN , b:clsConceptVerEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.conceptVId-b.conceptVId;
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
export function ConceptVer_SortFun_Defa_2Fld(a:clsConceptVerEN , b:clsConceptVerEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.conceptId == b.conceptId) return a.conceptContent.localeCompare(b.conceptContent);
else return a.conceptId.localeCompare(b.conceptId);
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
export function ConceptVer_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsConceptVerEN.con_ConceptVId:
return (a: clsConceptVerEN, b: clsConceptVerEN) => {
return a.conceptVId-b.conceptVId;
}
case clsConceptVerEN.con_ConceptId:
return (a: clsConceptVerEN, b: clsConceptVerEN) => {
return a.conceptId.localeCompare(b.conceptId);
}
case clsConceptVerEN.con_ConceptContent:
return (a: clsConceptVerEN, b: clsConceptVerEN) => {
if (a.conceptContent == null) return -1;
if (b.conceptContent == null) return 1;
return a.conceptContent.localeCompare(b.conceptContent);
}
case clsConceptVerEN.con_ConceptName:
return (a: clsConceptVerEN, b: clsConceptVerEN) => {
if (a.conceptName == null) return -1;
if (b.conceptName == null) return 1;
return a.conceptName.localeCompare(b.conceptName);
}
case clsConceptVerEN.con_CitationId:
return (a: clsConceptVerEN, b: clsConceptVerEN) => {
if (a.citationId == null) return -1;
if (b.citationId == null) return 1;
return a.citationId.localeCompare(b.citationId);
}
case clsConceptVerEN.con_UpdDate:
return (a: clsConceptVerEN, b: clsConceptVerEN) => {
if (a.updDate == null) return -1;
if (b.updDate == null) return 1;
return a.updDate.localeCompare(b.updDate);
}
case clsConceptVerEN.con_UpdUser:
return (a: clsConceptVerEN, b: clsConceptVerEN) => {
if (a.updUser == null) return -1;
if (b.updUser == null) return 1;
return a.updUser.localeCompare(b.updUser);
}
case clsConceptVerEN.con_id_CurrEduCls:
return (a: clsConceptVerEN, b: clsConceptVerEN) => {
if (a.id_CurrEduCls == null) return -1;
if (b.id_CurrEduCls == null) return 1;
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
case clsConceptVerEN.con_PdfContent:
return (a: clsConceptVerEN, b: clsConceptVerEN) => {
if (a.pdfContent == null) return -1;
if (b.pdfContent == null) return 1;
return a.pdfContent.localeCompare(b.pdfContent);
}
case clsConceptVerEN.con_PdfPageNum:
return (a: clsConceptVerEN, b: clsConceptVerEN) => {
return a.pdfPageNum-b.pdfPageNum;
}
case clsConceptVerEN.con_Memo:
return (a: clsConceptVerEN, b: clsConceptVerEN) => {
if (a.memo == null) return -1;
if (b.memo == null) return 1;
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[ConceptVer]中不存在！(in ${ conceptVer_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsConceptVerEN.con_ConceptVId:
return (a: clsConceptVerEN, b: clsConceptVerEN) => {
return b.conceptVId-a.conceptVId;
}
case clsConceptVerEN.con_ConceptId:
return (a: clsConceptVerEN, b: clsConceptVerEN) => {
return b.conceptId.localeCompare(a.conceptId);
}
case clsConceptVerEN.con_ConceptContent:
return (a: clsConceptVerEN, b: clsConceptVerEN) => {
if (b.conceptContent == null) return -1;
if (a.conceptContent == null) return 1;
return b.conceptContent.localeCompare(a.conceptContent);
}
case clsConceptVerEN.con_ConceptName:
return (a: clsConceptVerEN, b: clsConceptVerEN) => {
if (b.conceptName == null) return -1;
if (a.conceptName == null) return 1;
return b.conceptName.localeCompare(a.conceptName);
}
case clsConceptVerEN.con_CitationId:
return (a: clsConceptVerEN, b: clsConceptVerEN) => {
if (b.citationId == null) return -1;
if (a.citationId == null) return 1;
return b.citationId.localeCompare(a.citationId);
}
case clsConceptVerEN.con_UpdDate:
return (a: clsConceptVerEN, b: clsConceptVerEN) => {
if (b.updDate == null) return -1;
if (a.updDate == null) return 1;
return b.updDate.localeCompare(a.updDate);
}
case clsConceptVerEN.con_UpdUser:
return (a: clsConceptVerEN, b: clsConceptVerEN) => {
if (b.updUser == null) return -1;
if (a.updUser == null) return 1;
return b.updUser.localeCompare(a.updUser);
}
case clsConceptVerEN.con_id_CurrEduCls:
return (a: clsConceptVerEN, b: clsConceptVerEN) => {
if (b.id_CurrEduCls == null) return -1;
if (a.id_CurrEduCls == null) return 1;
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
case clsConceptVerEN.con_PdfContent:
return (a: clsConceptVerEN, b: clsConceptVerEN) => {
if (b.pdfContent == null) return -1;
if (a.pdfContent == null) return 1;
return b.pdfContent.localeCompare(a.pdfContent);
}
case clsConceptVerEN.con_PdfPageNum:
return (a: clsConceptVerEN, b: clsConceptVerEN) => {
return b.pdfPageNum-a.pdfPageNum;
}
case clsConceptVerEN.con_Memo:
return (a: clsConceptVerEN, b: clsConceptVerEN) => {
if (b.memo == null) return -1;
if (a.memo == null) return 1;
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[ConceptVer]中不存在！(in ${ conceptVer_ConstructorName}.${ strThisFuncName})`;
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
export async function ConceptVer_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsConceptVerEN.con_ConceptVId:
return (obj: clsConceptVerEN) => {
return obj.conceptVId === value;
}
case clsConceptVerEN.con_ConceptId:
return (obj: clsConceptVerEN) => {
return obj.conceptId === value;
}
case clsConceptVerEN.con_ConceptContent:
return (obj: clsConceptVerEN) => {
return obj.conceptContent === value;
}
case clsConceptVerEN.con_ConceptName:
return (obj: clsConceptVerEN) => {
return obj.conceptName === value;
}
case clsConceptVerEN.con_CitationId:
return (obj: clsConceptVerEN) => {
return obj.citationId === value;
}
case clsConceptVerEN.con_UpdDate:
return (obj: clsConceptVerEN) => {
return obj.updDate === value;
}
case clsConceptVerEN.con_UpdUser:
return (obj: clsConceptVerEN) => {
return obj.updUser === value;
}
case clsConceptVerEN.con_id_CurrEduCls:
return (obj: clsConceptVerEN) => {
return obj.id_CurrEduCls === value;
}
case clsConceptVerEN.con_PdfContent:
return (obj: clsConceptVerEN) => {
return obj.pdfContent === value;
}
case clsConceptVerEN.con_PdfPageNum:
return (obj: clsConceptVerEN) => {
return obj.pdfPageNum === value;
}
case clsConceptVerEN.con_Memo:
return (obj: clsConceptVerEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[ConceptVer]中不存在！(in ${ conceptVer_ConstructorName}.${ strThisFuncName})`;
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
export async function ConceptVer_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(conceptVer_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptVer_ConstructorName, strThisFuncName);
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
export async function ConceptVer_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(conceptVer_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptVer_ConstructorName, strThisFuncName);
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
export async function ConceptVer_GetFirstObjAsync(strWhereCond: string): Promise<clsConceptVerEN|null>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(conceptVer_Controller, strAction);
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
const objConceptVer = ConceptVer_GetObjFromJsonObj(returnObj);
return objConceptVer;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptVer_ConstructorName, strThisFuncName);
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
export async function ConceptVer_GetObjLstAsync(strWhereCond: string): Promise<Array<clsConceptVerEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(conceptVer_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", conceptVer_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = ConceptVer_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptVer_ConstructorName, strThisFuncName);
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
export async function ConceptVer_GetObjLstByConceptVIdLstAsync(arrConceptVId: Array<string>): Promise<Array<clsConceptVerEN>>  
{
const strThisFuncName = "GetObjLstByConceptVIdLstAsync";
const strAction = "GetObjLstByConceptVIdLst";
const strUrl = GetWebApiUrl(conceptVer_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrConceptVId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", conceptVer_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = ConceptVer_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptVer_ConstructorName, strThisFuncName);
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
export async function ConceptVer_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsConceptVerEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(conceptVer_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", conceptVer_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = ConceptVer_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptVer_ConstructorName, strThisFuncName);
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
export async function ConceptVer_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsConceptVerEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(conceptVer_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", conceptVer_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = ConceptVer_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptVer_ConstructorName, strThisFuncName);
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
export async function ConceptVer_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(conceptVer_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptVer_ConstructorName, strThisFuncName);
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
export async function ConceptVer_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsConceptVerEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
if (objPagerPara.pageIndex == 0) return new Array<clsConceptVerEN>();
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(conceptVer_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", conceptVer_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = ConceptVer_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptVer_ConstructorName, strThisFuncName);
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
export async function ConceptVer_DelRecordAsync(lngConceptVId: number): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(conceptVer_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, lngConceptVId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptVer_ConstructorName, strThisFuncName);
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
export async function ConceptVer_DelConceptVersAsync(arrConceptVId: Array<string>): Promise<number> 
{
const strThisFuncName = "DelConceptVersAsync";
const strAction = "DelConceptVers";
const strUrl = GetWebApiUrl(conceptVer_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptVer_ConstructorName, strThisFuncName);
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
export async function ConceptVer_DelConceptVersByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "DelConceptVersByCondAsync";
const strAction = "DelConceptVersByCond";
const strUrl = GetWebApiUrl(conceptVer_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptVer_ConstructorName, strThisFuncName);
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
 * @param objConceptVerEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function ConceptVer_AddNewRecordAsync(objConceptVerEN: clsConceptVerEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objConceptVerEN);
const strUrl = GetWebApiUrl(conceptVer_Controller, strAction);
try
{
const response = await axios.post(strUrl, objConceptVerEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptVer_ConstructorName, strThisFuncName);
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
 * @param objConceptVerEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function ConceptVer_AddNewRecordWithReturnKeyAsync(objConceptVerEN: clsConceptVerEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(conceptVer_Controller, strAction);
try
{
const response = await axios.post(strUrl, objConceptVerEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptVer_ConstructorName, strThisFuncName);
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
 * @param objConceptVerEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function ConceptVer_AddNewRecordWithReturnKey(objConceptVerEN: clsConceptVerEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objConceptVerEN.conceptVId === null || objConceptVerEN.conceptVId === 0)
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(conceptVer_Controller, strAction);
try
{
const response = await axios.post(strUrl, objConceptVerEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptVer_ConstructorName, strThisFuncName);
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
 * @param objConceptVerEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function ConceptVer_UpdateRecordAsync(objConceptVerEN: clsConceptVerEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objConceptVerEN.sfUpdFldSetStr === undefined || objConceptVerEN.sfUpdFldSetStr === null || objConceptVerEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objConceptVerEN.conceptVId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(conceptVer_Controller, strAction);
try
{
const response = await axios.post(strUrl, objConceptVerEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptVer_ConstructorName, strThisFuncName);
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
 * @param objConceptVerEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function ConceptVer_UpdateWithConditionAsync(objConceptVerEN: clsConceptVerEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objConceptVerEN.sfUpdFldSetStr === undefined || objConceptVerEN.sfUpdFldSetStr === null || objConceptVerEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objConceptVerEN.conceptVId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(conceptVer_Controller, strAction);
objConceptVerEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objConceptVerEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptVer_ConstructorName, strThisFuncName);
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
export async function ConceptVer_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(conceptVer_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptVer_ConstructorName, strThisFuncName);
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
export async function ConceptVer_IsExist(lngConceptVId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(conceptVer_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptVer_ConstructorName, strThisFuncName);
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
export async function ConceptVer_IsExistAsync(lngConceptVId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(conceptVer_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptVer_ConstructorName, strThisFuncName);
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
export async function ConceptVer_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(conceptVer_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptVer_ConstructorName, strThisFuncName);
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
export async function ConceptVer_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(conceptVer_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptVer_ConstructorName, strThisFuncName);
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
export function ConceptVer_GetWebApiUrl(strController: string, strAction: string): string {
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
export function ConceptVer_CheckPropertyNew(pobjConceptVerEN: clsConceptVerEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjConceptVerEN.conceptId) === true )
{
 throw new Error("(errid:Watl000058)字段[概念Id]不能为空(In 概念版本表)!(clsConceptVerBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjConceptVerEN.conceptId) == false && GetStrLen(pobjConceptVerEN.conceptId) > 8)
{
 throw new Error("(errid:Watl000059)字段[概念Id(conceptId)]的长度不能超过8(In 概念版本表(ConceptVer))!值:$(pobjConceptVerEN.conceptId)(clsConceptVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjConceptVerEN.conceptName) == false && GetStrLen(pobjConceptVerEN.conceptName) > 500)
{
 throw new Error("(errid:Watl000059)字段[概念名称(conceptName)]的长度不能超过500(In 概念版本表(ConceptVer))!值:$(pobjConceptVerEN.conceptName)(clsConceptVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjConceptVerEN.citationId) == false && GetStrLen(pobjConceptVerEN.citationId) > 8)
{
 throw new Error("(errid:Watl000059)字段[引用Id(citationId)]的长度不能超过8(In 概念版本表(ConceptVer))!值:$(pobjConceptVerEN.citationId)(clsConceptVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjConceptVerEN.updDate) == false && GetStrLen(pobjConceptVerEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 概念版本表(ConceptVer))!值:$(pobjConceptVerEN.updDate)(clsConceptVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjConceptVerEN.updUser) == false && GetStrLen(pobjConceptVerEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 概念版本表(ConceptVer))!值:$(pobjConceptVerEN.updUser)(clsConceptVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjConceptVerEN.id_CurrEduCls) == false && GetStrLen(pobjConceptVerEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 概念版本表(ConceptVer))!值:$(pobjConceptVerEN.id_CurrEduCls)(clsConceptVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjConceptVerEN.pdfContent) == false && GetStrLen(pobjConceptVerEN.pdfContent) > 2000)
{
 throw new Error("(errid:Watl000059)字段[Pdf内容(pdfContent)]的长度不能超过2000(In 概念版本表(ConceptVer))!值:$(pobjConceptVerEN.pdfContent)(clsConceptVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjConceptVerEN.memo) == false && GetStrLen(pobjConceptVerEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 概念版本表(ConceptVer))!值:$(pobjConceptVerEN.memo)(clsConceptVerBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null != pobjConceptVerEN.conceptVId && undefined !== pobjConceptVerEN.conceptVId && tzDataType.isNumber(pobjConceptVerEN.conceptVId) === false)
{
 throw new Error("(errid:Watl000060)字段[ConceptVId(conceptVId)]的值:[$(pobjConceptVerEN.conceptVId)], 非法，应该为数值型(In 概念版本表(ConceptVer))!(clsConceptVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjConceptVerEN.conceptId) == false && undefined !== pobjConceptVerEN.conceptId && tzDataType.isString(pobjConceptVerEN.conceptId) === false)
{
 throw new Error("(errid:Watl000060)字段[概念Id(conceptId)]的值:[$(pobjConceptVerEN.conceptId)], 非法，应该为字符型(In 概念版本表(ConceptVer))!(clsConceptVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjConceptVerEN.conceptContent) == false && undefined !== pobjConceptVerEN.conceptContent && tzDataType.isString(pobjConceptVerEN.conceptContent) === false)
{
 throw new Error("(errid:Watl000060)字段[概念内容(conceptContent)]的值:[$(pobjConceptVerEN.conceptContent)], 非法，应该为字符型(In 概念版本表(ConceptVer))!(clsConceptVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjConceptVerEN.conceptName) == false && undefined !== pobjConceptVerEN.conceptName && tzDataType.isString(pobjConceptVerEN.conceptName) === false)
{
 throw new Error("(errid:Watl000060)字段[概念名称(conceptName)]的值:[$(pobjConceptVerEN.conceptName)], 非法，应该为字符型(In 概念版本表(ConceptVer))!(clsConceptVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjConceptVerEN.citationId) == false && undefined !== pobjConceptVerEN.citationId && tzDataType.isString(pobjConceptVerEN.citationId) === false)
{
 throw new Error("(errid:Watl000060)字段[引用Id(citationId)]的值:[$(pobjConceptVerEN.citationId)], 非法，应该为字符型(In 概念版本表(ConceptVer))!(clsConceptVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjConceptVerEN.updDate) == false && undefined !== pobjConceptVerEN.updDate && tzDataType.isString(pobjConceptVerEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjConceptVerEN.updDate)], 非法，应该为字符型(In 概念版本表(ConceptVer))!(clsConceptVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjConceptVerEN.updUser) == false && undefined !== pobjConceptVerEN.updUser && tzDataType.isString(pobjConceptVerEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjConceptVerEN.updUser)], 非法，应该为字符型(In 概念版本表(ConceptVer))!(clsConceptVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjConceptVerEN.id_CurrEduCls) == false && undefined !== pobjConceptVerEN.id_CurrEduCls && tzDataType.isString(pobjConceptVerEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjConceptVerEN.id_CurrEduCls)], 非法，应该为字符型(In 概念版本表(ConceptVer))!(clsConceptVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjConceptVerEN.pdfContent) == false && undefined !== pobjConceptVerEN.pdfContent && tzDataType.isString(pobjConceptVerEN.pdfContent) === false)
{
 throw new Error("(errid:Watl000060)字段[Pdf内容(pdfContent)]的值:[$(pobjConceptVerEN.pdfContent)], 非法，应该为字符型(In 概念版本表(ConceptVer))!(clsConceptVerBL:CheckPropertyNew)");
}
if (null != pobjConceptVerEN.pdfPageNum && undefined !== pobjConceptVerEN.pdfPageNum && tzDataType.isNumber(pobjConceptVerEN.pdfPageNum) === false)
{
 throw new Error("(errid:Watl000060)字段[Pdf页码(pdfPageNum)]的值:[$(pobjConceptVerEN.pdfPageNum)], 非法，应该为数值型(In 概念版本表(ConceptVer))!(clsConceptVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjConceptVerEN.memo) == false && undefined !== pobjConceptVerEN.memo && tzDataType.isString(pobjConceptVerEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjConceptVerEN.memo)], 非法，应该为字符型(In 概念版本表(ConceptVer))!(clsConceptVerBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjConceptVerEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function ConceptVer_CheckProperty4Update (pobjConceptVerEN: clsConceptVerEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjConceptVerEN.conceptId) == false && GetStrLen(pobjConceptVerEN.conceptId) > 8)
{
 throw new Error("(errid:Watl000062)字段[概念Id(conceptId)]的长度不能超过8(In 概念版本表(ConceptVer))!值:$(pobjConceptVerEN.conceptId)(clsConceptVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjConceptVerEN.conceptName) == false && GetStrLen(pobjConceptVerEN.conceptName) > 500)
{
 throw new Error("(errid:Watl000062)字段[概念名称(conceptName)]的长度不能超过500(In 概念版本表(ConceptVer))!值:$(pobjConceptVerEN.conceptName)(clsConceptVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjConceptVerEN.citationId) == false && GetStrLen(pobjConceptVerEN.citationId) > 8)
{
 throw new Error("(errid:Watl000062)字段[引用Id(citationId)]的长度不能超过8(In 概念版本表(ConceptVer))!值:$(pobjConceptVerEN.citationId)(clsConceptVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjConceptVerEN.updDate) == false && GetStrLen(pobjConceptVerEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 概念版本表(ConceptVer))!值:$(pobjConceptVerEN.updDate)(clsConceptVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjConceptVerEN.updUser) == false && GetStrLen(pobjConceptVerEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 概念版本表(ConceptVer))!值:$(pobjConceptVerEN.updUser)(clsConceptVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjConceptVerEN.id_CurrEduCls) == false && GetStrLen(pobjConceptVerEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 概念版本表(ConceptVer))!值:$(pobjConceptVerEN.id_CurrEduCls)(clsConceptVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjConceptVerEN.pdfContent) == false && GetStrLen(pobjConceptVerEN.pdfContent) > 2000)
{
 throw new Error("(errid:Watl000062)字段[Pdf内容(pdfContent)]的长度不能超过2000(In 概念版本表(ConceptVer))!值:$(pobjConceptVerEN.pdfContent)(clsConceptVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjConceptVerEN.memo) == false && GetStrLen(pobjConceptVerEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 概念版本表(ConceptVer))!值:$(pobjConceptVerEN.memo)(clsConceptVerBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null != pobjConceptVerEN.conceptVId && undefined !== pobjConceptVerEN.conceptVId && tzDataType.isNumber(pobjConceptVerEN.conceptVId) === false)
{
 throw new Error("(errid:Watl000063)字段[ConceptVId(conceptVId)]的值:[$(pobjConceptVerEN.conceptVId)], 非法，应该为数值型(In 概念版本表(ConceptVer))!(clsConceptVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjConceptVerEN.conceptId) == false && undefined !== pobjConceptVerEN.conceptId && tzDataType.isString(pobjConceptVerEN.conceptId) === false)
{
 throw new Error("(errid:Watl000063)字段[概念Id(conceptId)]的值:[$(pobjConceptVerEN.conceptId)], 非法，应该为字符型(In 概念版本表(ConceptVer))!(clsConceptVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjConceptVerEN.conceptContent) == false && undefined !== pobjConceptVerEN.conceptContent && tzDataType.isString(pobjConceptVerEN.conceptContent) === false)
{
 throw new Error("(errid:Watl000063)字段[概念内容(conceptContent)]的值:[$(pobjConceptVerEN.conceptContent)], 非法，应该为字符型(In 概念版本表(ConceptVer))!(clsConceptVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjConceptVerEN.conceptName) == false && undefined !== pobjConceptVerEN.conceptName && tzDataType.isString(pobjConceptVerEN.conceptName) === false)
{
 throw new Error("(errid:Watl000063)字段[概念名称(conceptName)]的值:[$(pobjConceptVerEN.conceptName)], 非法，应该为字符型(In 概念版本表(ConceptVer))!(clsConceptVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjConceptVerEN.citationId) == false && undefined !== pobjConceptVerEN.citationId && tzDataType.isString(pobjConceptVerEN.citationId) === false)
{
 throw new Error("(errid:Watl000063)字段[引用Id(citationId)]的值:[$(pobjConceptVerEN.citationId)], 非法，应该为字符型(In 概念版本表(ConceptVer))!(clsConceptVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjConceptVerEN.updDate) == false && undefined !== pobjConceptVerEN.updDate && tzDataType.isString(pobjConceptVerEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjConceptVerEN.updDate)], 非法，应该为字符型(In 概念版本表(ConceptVer))!(clsConceptVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjConceptVerEN.updUser) == false && undefined !== pobjConceptVerEN.updUser && tzDataType.isString(pobjConceptVerEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjConceptVerEN.updUser)], 非法，应该为字符型(In 概念版本表(ConceptVer))!(clsConceptVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjConceptVerEN.id_CurrEduCls) == false && undefined !== pobjConceptVerEN.id_CurrEduCls && tzDataType.isString(pobjConceptVerEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjConceptVerEN.id_CurrEduCls)], 非法，应该为字符型(In 概念版本表(ConceptVer))!(clsConceptVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjConceptVerEN.pdfContent) == false && undefined !== pobjConceptVerEN.pdfContent && tzDataType.isString(pobjConceptVerEN.pdfContent) === false)
{
 throw new Error("(errid:Watl000063)字段[Pdf内容(pdfContent)]的值:[$(pobjConceptVerEN.pdfContent)], 非法，应该为字符型(In 概念版本表(ConceptVer))!(clsConceptVerBL:CheckProperty4Update)");
}
if (null != pobjConceptVerEN.pdfPageNum && undefined !== pobjConceptVerEN.pdfPageNum && tzDataType.isNumber(pobjConceptVerEN.pdfPageNum) === false)
{
 throw new Error("(errid:Watl000063)字段[Pdf页码(pdfPageNum)]的值:[$(pobjConceptVerEN.pdfPageNum)], 非法，应该为数值型(In 概念版本表(ConceptVer))!(clsConceptVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjConceptVerEN.memo) == false && undefined !== pobjConceptVerEN.memo && tzDataType.isString(pobjConceptVerEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjConceptVerEN.memo)], 非法，应该为字符型(In 概念版本表(ConceptVer))!(clsConceptVerBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjConceptVerEN.conceptVId 
 || pobjConceptVerEN.conceptVId != null && pobjConceptVerEN.conceptVId.toString()  ===  "")
{
 throw new Error("(errid:Watl000064)字段[ConceptVId]不能为空(In 概念版本表)!(clsConceptVerBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjConceptVerEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function ConceptVer_GetJSONStrByObj (pobjConceptVerEN: clsConceptVerEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjConceptVerEN.sfUpdFldSetStr = pobjConceptVerEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjConceptVerEN);
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
export function ConceptVer_GetObjLstByJSONStr (strJSON: string): Array<clsConceptVerEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrConceptVerObjLst = new Array<clsConceptVerEN>();
if (strJSON === "")
{
return arrConceptVerObjLst;
}
try
{
arrConceptVerObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrConceptVerObjLst;
}
return arrConceptVerObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrConceptVerObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function ConceptVer_GetObjLstByJSONObjLst (arrConceptVerObjLstS: Array<clsConceptVerEN>): Array<clsConceptVerEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrConceptVerObjLst = new Array<clsConceptVerEN>();
for (const objInFor of arrConceptVerObjLstS) {
const obj1 = ConceptVer_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrConceptVerObjLst.push(obj1);
}
return arrConceptVerObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function ConceptVer_GetObjByJSONStr (strJSON: string): clsConceptVerEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjConceptVerEN = new clsConceptVerEN();
if (strJSON === "")
{
return pobjConceptVerEN;
}
try
{
pobjConceptVerEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjConceptVerEN;
}
return pobjConceptVerEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function ConceptVer_GetCombineCondition(objConceptVer_Cond: clsConceptVerEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objConceptVer_Cond.dicFldComparisonOp, clsConceptVerEN.con_ConceptVId) == true)
{
const strComparisonOp_ConceptVId:string = objConceptVer_Cond.dicFldComparisonOp[clsConceptVerEN.con_ConceptVId];
strWhereCond += Format(" And {0} {2} {1}", clsConceptVerEN.con_ConceptVId, objConceptVer_Cond.conceptVId, strComparisonOp_ConceptVId);
}
if (Object.prototype.hasOwnProperty.call(objConceptVer_Cond.dicFldComparisonOp, clsConceptVerEN.con_ConceptId) == true)
{
const strComparisonOp_ConceptId:string = objConceptVer_Cond.dicFldComparisonOp[clsConceptVerEN.con_ConceptId];
strWhereCond += Format(" And {0} {2} '{1}'", clsConceptVerEN.con_ConceptId, objConceptVer_Cond.conceptId, strComparisonOp_ConceptId);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objConceptVer_Cond.dicFldComparisonOp, clsConceptVerEN.con_ConceptName) == true)
{
const strComparisonOp_ConceptName:string = objConceptVer_Cond.dicFldComparisonOp[clsConceptVerEN.con_ConceptName];
strWhereCond += Format(" And {0} {2} '{1}'", clsConceptVerEN.con_ConceptName, objConceptVer_Cond.conceptName, strComparisonOp_ConceptName);
}
if (Object.prototype.hasOwnProperty.call(objConceptVer_Cond.dicFldComparisonOp, clsConceptVerEN.con_CitationId) == true)
{
const strComparisonOp_CitationId:string = objConceptVer_Cond.dicFldComparisonOp[clsConceptVerEN.con_CitationId];
strWhereCond += Format(" And {0} {2} '{1}'", clsConceptVerEN.con_CitationId, objConceptVer_Cond.citationId, strComparisonOp_CitationId);
}
if (Object.prototype.hasOwnProperty.call(objConceptVer_Cond.dicFldComparisonOp, clsConceptVerEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objConceptVer_Cond.dicFldComparisonOp[clsConceptVerEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsConceptVerEN.con_UpdDate, objConceptVer_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objConceptVer_Cond.dicFldComparisonOp, clsConceptVerEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objConceptVer_Cond.dicFldComparisonOp[clsConceptVerEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsConceptVerEN.con_UpdUser, objConceptVer_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objConceptVer_Cond.dicFldComparisonOp, clsConceptVerEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objConceptVer_Cond.dicFldComparisonOp[clsConceptVerEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsConceptVerEN.con_id_CurrEduCls, objConceptVer_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (Object.prototype.hasOwnProperty.call(objConceptVer_Cond.dicFldComparisonOp, clsConceptVerEN.con_PdfContent) == true)
{
const strComparisonOp_PdfContent:string = objConceptVer_Cond.dicFldComparisonOp[clsConceptVerEN.con_PdfContent];
strWhereCond += Format(" And {0} {2} '{1}'", clsConceptVerEN.con_PdfContent, objConceptVer_Cond.pdfContent, strComparisonOp_PdfContent);
}
if (Object.prototype.hasOwnProperty.call(objConceptVer_Cond.dicFldComparisonOp, clsConceptVerEN.con_PdfPageNum) == true)
{
const strComparisonOp_PdfPageNum:string = objConceptVer_Cond.dicFldComparisonOp[clsConceptVerEN.con_PdfPageNum];
strWhereCond += Format(" And {0} {2} {1}", clsConceptVerEN.con_PdfPageNum, objConceptVer_Cond.pdfPageNum, strComparisonOp_PdfPageNum);
}
if (Object.prototype.hasOwnProperty.call(objConceptVer_Cond.dicFldComparisonOp, clsConceptVerEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objConceptVer_Cond.dicFldComparisonOp[clsConceptVerEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsConceptVerEN.con_Memo, objConceptVer_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--ConceptVer(概念版本表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param lngConceptVId: ConceptVId(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function ConceptVer_GetUniCondStr_ConceptVId(objConceptVerEN: clsConceptVerEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and ConceptVId = '{0}'", objConceptVerEN.conceptVId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--ConceptVer(概念版本表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param lngConceptVId: ConceptVId(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function ConceptVer_GetUniCondStr4Update_ConceptVId(objConceptVerEN: clsConceptVerEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and ConceptVId <> '{0}'", objConceptVerEN.conceptVId);
 strWhereCond +=  Format(" and ConceptVId = '{0}'", objConceptVerEN.conceptVId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objConceptVerENS:源对象
 * @param objConceptVerENT:目标对象
*/
export function ConceptVer_CopyObjTo(objConceptVerENS: clsConceptVerEN , objConceptVerENT: clsConceptVerEN ): void 
{
objConceptVerENT.conceptVId = objConceptVerENS.conceptVId; //ConceptVId
objConceptVerENT.conceptId = objConceptVerENS.conceptId; //概念Id
objConceptVerENT.conceptContent = objConceptVerENS.conceptContent; //概念内容
objConceptVerENT.conceptName = objConceptVerENS.conceptName; //概念名称
objConceptVerENT.citationId = objConceptVerENS.citationId; //引用Id
objConceptVerENT.updDate = objConceptVerENS.updDate; //修改日期
objConceptVerENT.updUser = objConceptVerENS.updUser; //修改人
objConceptVerENT.id_CurrEduCls = objConceptVerENS.id_CurrEduCls; //教学班流水号
objConceptVerENT.pdfContent = objConceptVerENS.pdfContent; //Pdf内容
objConceptVerENT.pdfPageNum = objConceptVerENS.pdfPageNum; //Pdf页码
objConceptVerENT.memo = objConceptVerENS.memo; //备注
objConceptVerENT.sfUpdFldSetStr = objConceptVerENS.updFldString; //sfUpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objConceptVerENS:源对象
 * @param objConceptVerENT:目标对象
*/
export function ConceptVer_GetObjFromJsonObj(objConceptVerENS: clsConceptVerEN): clsConceptVerEN 
{
 const objConceptVerENT: clsConceptVerEN = new clsConceptVerEN();
ObjectAssign(objConceptVerENT, objConceptVerENS);
 return objConceptVerENT;
}