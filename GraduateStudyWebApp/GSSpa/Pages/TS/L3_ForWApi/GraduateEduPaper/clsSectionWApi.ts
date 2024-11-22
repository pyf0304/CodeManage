
 /**
 * 类名:clsSectionWApi
 * 表名:Section(01120558)
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
 * 论文节表(Section)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { clsOrderByData } from "../../PubFun/clsOrderByData.js";
import { clsSectionEN } from "../../L0_Entity/GraduateEduPaper/clsSectionEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { tzDataType } from "../../PubFun/jsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const section_Controller = "SectionApi";
 export const section_ConstructorName = "section";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strSectionId:关键字
 * @returns 对象
 **/
export async function Section_GetObjBySectionIdAsync(strSectionId: string): Promise<clsSectionEN>  
{
const strThisFuncName = "GetObjBySectionIdAsync";

if (IsNullOrEmpty(strSectionId) == true)
{
  const strMsg = Format("参数:[strSectionId]不能为空！(In GetObjBySectionIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strSectionId.length != 8)
{
const strMsg = Format("缓存分类变量:[strSectionId]的长度:[{0}]不正确！", strSectionId.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjBySectionId";
const strUrl = GetWebApiUrl(section_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strSectionId": strSectionId,
}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObj = data.returnObj;
if (returnObj == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", section_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objSection = Section_GetObjFromJsonObj(returnObj);
return objSection;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
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
export function Section_SortFun_Defa(a:clsSectionEN , b:clsSectionEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.sectionId.localeCompare(b.sectionId);
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
export function Section_SortFun_Defa_2Fld(a:clsSectionEN , b:clsSectionEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.sectionName == b.sectionName) return a.paperId.localeCompare(b.paperId);
else return a.sectionName.localeCompare(b.sectionName);
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
export function Section_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsSectionEN.con_SectionId:
return (a: clsSectionEN, b: clsSectionEN) => {
return a.sectionId.localeCompare(b.sectionId);
}
case clsSectionEN.con_SectionName:
return (a: clsSectionEN, b: clsSectionEN) => {
return a.sectionName.localeCompare(b.sectionName);
}
case clsSectionEN.con_PaperId:
return (a: clsSectionEN, b: clsSectionEN) => {
return a.paperId.localeCompare(b.paperId);
}
case clsSectionEN.con_ParentId:
return (a: clsSectionEN, b: clsSectionEN) => {
return a.parentId.localeCompare(b.parentId);
}
case clsSectionEN.con_OrderNum:
return (a: clsSectionEN, b: clsSectionEN) => {
return a.orderNum-b.orderNum;
}
case clsSectionEN.con_UpdDate:
return (a: clsSectionEN, b: clsSectionEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsSectionEN.con_UpdUser:
return (a: clsSectionEN, b: clsSectionEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsSectionEN.con_Memo:
return (a: clsSectionEN, b: clsSectionEN) => {
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[Section]中不存在！(in ${ section_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsSectionEN.con_SectionId:
return (a: clsSectionEN, b: clsSectionEN) => {
return b.sectionId.localeCompare(a.sectionId);
}
case clsSectionEN.con_SectionName:
return (a: clsSectionEN, b: clsSectionEN) => {
return b.sectionName.localeCompare(a.sectionName);
}
case clsSectionEN.con_PaperId:
return (a: clsSectionEN, b: clsSectionEN) => {
return b.paperId.localeCompare(a.paperId);
}
case clsSectionEN.con_ParentId:
return (a: clsSectionEN, b: clsSectionEN) => {
return b.parentId.localeCompare(a.parentId);
}
case clsSectionEN.con_OrderNum:
return (a: clsSectionEN, b: clsSectionEN) => {
return b.orderNum-a.orderNum;
}
case clsSectionEN.con_UpdDate:
return (a: clsSectionEN, b: clsSectionEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsSectionEN.con_UpdUser:
return (a: clsSectionEN, b: clsSectionEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsSectionEN.con_Memo:
return (a: clsSectionEN, b: clsSectionEN) => {
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[Section]中不存在！(in ${ section_ConstructorName}.${ strThisFuncName})`;
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
export async function Section_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsSectionEN.con_SectionId:
return (obj: clsSectionEN) => {
return obj.sectionId === value;
}
case clsSectionEN.con_SectionName:
return (obj: clsSectionEN) => {
return obj.sectionName === value;
}
case clsSectionEN.con_PaperId:
return (obj: clsSectionEN) => {
return obj.paperId === value;
}
case clsSectionEN.con_ParentId:
return (obj: clsSectionEN) => {
return obj.parentId === value;
}
case clsSectionEN.con_OrderNum:
return (obj: clsSectionEN) => {
return obj.orderNum === value;
}
case clsSectionEN.con_UpdDate:
return (obj: clsSectionEN) => {
return obj.updDate === value;
}
case clsSectionEN.con_UpdUser:
return (obj: clsSectionEN) => {
return obj.updUser === value;
}
case clsSectionEN.con_Memo:
return (obj: clsSectionEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[Section]中不存在！(in ${ section_ConstructorName}.${ strThisFuncName})`;
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
export async function Section_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(section_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
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
export async function Section_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(section_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
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
export async function Section_GetFirstObjAsync(strWhereCond: string): Promise<clsSectionEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(section_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", section_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objSection = Section_GetObjFromJsonObj(returnObj);
return objSection;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
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
export async function Section_GetObjLstAsync(strWhereCond: string): Promise<Array<clsSectionEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(section_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", section_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = Section_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
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
 * @param arrSectionId:关键字列表
 * @returns 对象列表
 **/
export async function Section_GetObjLstBySectionIdLstAsync(arrSectionId: Array<string>): Promise<Array<clsSectionEN>>  
{
const strThisFuncName = "GetObjLstBySectionIdLstAsync";
const strAction = "GetObjLstBySectionIdLst";
const strUrl = GetWebApiUrl(section_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrSectionId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", section_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = Section_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
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
export async function Section_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsSectionEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(section_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", section_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = Section_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
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
export async function Section_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsSectionEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(section_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", section_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = Section_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
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
export async function Section_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(section_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
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
export async function Section_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsSectionEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(section_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", section_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = Section_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
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
 * @param strSectionId:关键字
 * @returns 获取删除的结果
 **/
export async function Section_DelRecordAsync(strSectionId: string): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(section_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, strSectionId);
try
{
const response = await axios.delete(strUrl,
{
params: { "Id": strSectionId, }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
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
 * @param arrSectionId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function Section_DelSectionsAsync(arrSectionId: Array<string>): Promise<number> 
{
const strThisFuncName = "DelSectionsAsync";
const strAction = "DelSections";
const strUrl = GetWebApiUrl(section_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrSectionId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
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
export async function Section_DelSectionsByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "DelSectionsByCondAsync";
const strAction = "DelSectionsByCond";
const strUrl = GetWebApiUrl(section_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
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
 * @param objSectionEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function Section_AddNewRecordAsync(objSectionEN: clsSectionEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objSectionEN);
const strUrl = GetWebApiUrl(section_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSectionEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
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
 * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
 * @param objSectionEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function Section_AddNewRecordWithMaxIdAsync(objSectionEN: clsSectionEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithMaxIdAsync";
const strAction = "AddNewRecordWithMaxId";
const strUrl = GetWebApiUrl(section_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSectionEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
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
 * 把所给的关键字列表相关的记录移顶
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GoTopAsync)
 * @param objSectionEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function Section_GoTopAsync(objOrderByData: clsOrderByData): Promise<boolean> 
{
const strThisFuncName = "GoTopAsync";
let strMsg = "";
const strAction = "GoTop";
if (objOrderByData.KeyIdLst.length == 0)
{
strMsg = "根据关键字列表置顶时，给定的关键字值列表不能为空!";
throw strMsg;
}
const strUrl = GetWebApiUrl(section_Controller, strAction);
try
{
const response = await axios.post(strUrl, objOrderByData);
const data = response.data;
if (data.errorId == 0)
{
return data.returnBool;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
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
 * 把所给的关键字列表相关的记录上移
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpMoveAsync)
 * @param objSectionEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function Section_UpMoveAsync(objOrderByData: clsOrderByData): Promise<boolean> 
{
const strThisFuncName = "UpMoveAsync";
let strMsg = "";
const strAction = "UpMove";
if (objOrderByData.KeyIdLst.length == 0)
{
strMsg = "根据关键字列表上移时，给定的关键字值列表不能为空!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objSectionEN);
const strUrl = GetWebApiUrl(section_Controller, strAction);
try
{
const response = await axios.post(strUrl, objOrderByData);
const data = response.data;
if (data.errorId == 0)
{
return data.returnBool;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
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
 * 把所给的关键字列表相关的记录下移
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DownMoveAsync)
 * @param objSectionEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function Section_DownMoveAsync(objOrderByData: clsOrderByData): Promise<boolean> 
{
const strThisFuncName = "DownMoveAsync";
let strMsg = "";
const strAction = "DownMove";
if (objOrderByData.KeyIdLst.length == 0)
{
strMsg = "根据关键字列表下移时，给定的关键字值列表不能为空!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objSectionEN);
const strUrl = GetWebApiUrl(section_Controller, strAction);
try
{
const response = await axios.post(strUrl, objOrderByData);
const data = response.data;
if (data.errorId == 0)
{
return (data.returnBool);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
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
 * 把所给的关键字列表相关的记录移底
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GoBottomAsync)
 * @param objSectionEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function Section_GoBottomAsync(objOrderByData: clsOrderByData): Promise<boolean> 
{
const strThisFuncName = "GoBottomAsync";
let strMsg = "";
const strAction = "GoBottom";
if (objOrderByData.KeyIdLst.length == 0)
{
strMsg = "根据关键字列表置底时，给定的关键字值列表不能为空!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objSectionEN);
const strUrl = GetWebApiUrl(section_Controller, strAction);
try
{
const response = await axios.post(strUrl, objOrderByData);
const data = response.data;
if (data.errorId == 0)
{
return data.returnBool;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
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
 * 把列表记录重序
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReOrderAsync)
 * @param objSectionEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function Section_ReOrderAsync(objOrderByData: clsOrderByData): Promise<boolean> 
{
const strThisFuncName = "ReOrderAsync";
const strAction = "ReOrder";
 //var strJSON = JSON.stringify(objSectionEN);
const strUrl = GetWebApiUrl(section_Controller, strAction);
try
{
const response = await axios.post(strUrl, objOrderByData);
const data = response.data;
if (data.errorId == 0)
{
return data.returnBool;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
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
 * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
 * @param objSectionEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function Section_AddNewRecordWithReturnKeyAsync(objSectionEN: clsSectionEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(section_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSectionEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
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
 * @param objSectionEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function Section_AddNewRecordWithReturnKey(objSectionEN: clsSectionEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objSectionEN.sectionId === null || objSectionEN.sectionId === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(section_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSectionEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
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
 * @param objSectionEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function Section_UpdateRecordAsync(objSectionEN: clsSectionEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objSectionEN.sf_UpdFldSetStr === undefined || objSectionEN.sf_UpdFldSetStr === null || objSectionEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objSectionEN.sectionId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(section_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSectionEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
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
 * @param objSectionEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function Section_UpdateWithConditionAsync(objSectionEN: clsSectionEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objSectionEN.sf_UpdFldSetStr === undefined || objSectionEN.sf_UpdFldSetStr === null || objSectionEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objSectionEN.sectionId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(section_Controller, strAction);
objSectionEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objSectionEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
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
export async function Section_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(section_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
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
 * @param strSectionId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function Section_IsExist(strSectionId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(section_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"SectionId": strSectionId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
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
 * @param strSectionId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function Section_IsExistAsync(strSectionId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(section_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strSectionId": strSectionId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
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
export async function Section_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(section_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
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
 * 获取表的最大关键字
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdAsync)
 * @returns 获取表的最大关键字
 **/
export async function Section_GetMaxStrIdAsync(): Promise<string>  
{
const strThisFuncName = "GetMaxStrIdAsync";
const strAction = "GetMaxStrId";
const strUrl = GetWebApiUrl(section_Controller, strAction);
try
{
const response = await axios.get(strUrl);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}
/*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/

/**
 * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
 * @param mapParam:参数列表
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 获取当前表关键字值的最大值
*/
export async function Section_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(section_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
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
export function Section_GetWebApiUrl(strController: string, strAction: string): string {
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
export function Section_CheckPropertyNew(pobjSectionEN: clsSectionEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjSectionEN.updUser) === true )
{
 throw new Error("(errid:Watl000058)字段[修改人]不能为空(In 论文节表)!(clsSectionBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjSectionEN.sectionId) == false && GetStrLen(pobjSectionEN.sectionId) > 8)
{
 throw new Error("(errid:Watl000059)字段[节Id(sectionId)]的长度不能超过8(In 论文节表(Section))!值:$(pobjSectionEN.sectionId)(clsSectionBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSectionEN.sectionName) == false && GetStrLen(pobjSectionEN.sectionName) > 100)
{
 throw new Error("(errid:Watl000059)字段[节名(sectionName)]的长度不能超过100(In 论文节表(Section))!值:$(pobjSectionEN.sectionName)(clsSectionBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSectionEN.paperId) == false && GetStrLen(pobjSectionEN.paperId) > 500)
{
 throw new Error("(errid:Watl000059)字段[节名称(paperId)]的长度不能超过500(In 论文节表(Section))!值:$(pobjSectionEN.paperId)(clsSectionBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSectionEN.parentId) == false && GetStrLen(pobjSectionEN.parentId) > 10)
{
 throw new Error("(errid:Watl000059)字段[父节点Id(parentId)]的长度不能超过10(In 论文节表(Section))!值:$(pobjSectionEN.parentId)(clsSectionBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSectionEN.updDate) == false && GetStrLen(pobjSectionEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 论文节表(Section))!值:$(pobjSectionEN.updDate)(clsSectionBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSectionEN.updUser) == false && GetStrLen(pobjSectionEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 论文节表(Section))!值:$(pobjSectionEN.updUser)(clsSectionBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSectionEN.memo) == false && GetStrLen(pobjSectionEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 论文节表(Section))!值:$(pobjSectionEN.memo)(clsSectionBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjSectionEN.sectionId) == false && undefined !== pobjSectionEN.sectionId && tzDataType.isString(pobjSectionEN.sectionId) === false)
{
 throw new Error("(errid:Watl000060)字段[节Id(sectionId)]的值:[$(pobjSectionEN.sectionId)], 非法，应该为字符型(In 论文节表(Section))!(clsSectionBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSectionEN.sectionName) == false && undefined !== pobjSectionEN.sectionName && tzDataType.isString(pobjSectionEN.sectionName) === false)
{
 throw new Error("(errid:Watl000060)字段[节名(sectionName)]的值:[$(pobjSectionEN.sectionName)], 非法，应该为字符型(In 论文节表(Section))!(clsSectionBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSectionEN.paperId) == false && undefined !== pobjSectionEN.paperId && tzDataType.isString(pobjSectionEN.paperId) === false)
{
 throw new Error("(errid:Watl000060)字段[节名称(paperId)]的值:[$(pobjSectionEN.paperId)], 非法，应该为字符型(In 论文节表(Section))!(clsSectionBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSectionEN.parentId) == false && undefined !== pobjSectionEN.parentId && tzDataType.isString(pobjSectionEN.parentId) === false)
{
 throw new Error("(errid:Watl000060)字段[父节点Id(parentId)]的值:[$(pobjSectionEN.parentId)], 非法，应该为字符型(In 论文节表(Section))!(clsSectionBL:CheckPropertyNew)");
}
if (null != pobjSectionEN.orderNum && undefined !== pobjSectionEN.orderNum && tzDataType.isNumber(pobjSectionEN.orderNum) === false)
{
 throw new Error("(errid:Watl000060)字段[序号(orderNum)]的值:[$(pobjSectionEN.orderNum)], 非法，应该为数值型(In 论文节表(Section))!(clsSectionBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSectionEN.updDate) == false && undefined !== pobjSectionEN.updDate && tzDataType.isString(pobjSectionEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjSectionEN.updDate)], 非法，应该为字符型(In 论文节表(Section))!(clsSectionBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSectionEN.updUser) == false && undefined !== pobjSectionEN.updUser && tzDataType.isString(pobjSectionEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjSectionEN.updUser)], 非法，应该为字符型(In 论文节表(Section))!(clsSectionBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSectionEN.memo) == false && undefined !== pobjSectionEN.memo && tzDataType.isString(pobjSectionEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjSectionEN.memo)], 非法，应该为字符型(In 论文节表(Section))!(clsSectionBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjSectionEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function Section_CheckProperty4Update (pobjSectionEN: clsSectionEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjSectionEN.sectionId) == false && GetStrLen(pobjSectionEN.sectionId) > 8)
{
 throw new Error("(errid:Watl000062)字段[节Id(sectionId)]的长度不能超过8(In 论文节表(Section))!值:$(pobjSectionEN.sectionId)(clsSectionBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSectionEN.sectionName) == false && GetStrLen(pobjSectionEN.sectionName) > 100)
{
 throw new Error("(errid:Watl000062)字段[节名(sectionName)]的长度不能超过100(In 论文节表(Section))!值:$(pobjSectionEN.sectionName)(clsSectionBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSectionEN.paperId) == false && GetStrLen(pobjSectionEN.paperId) > 500)
{
 throw new Error("(errid:Watl000062)字段[节名称(paperId)]的长度不能超过500(In 论文节表(Section))!值:$(pobjSectionEN.paperId)(clsSectionBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSectionEN.parentId) == false && GetStrLen(pobjSectionEN.parentId) > 10)
{
 throw new Error("(errid:Watl000062)字段[父节点Id(parentId)]的长度不能超过10(In 论文节表(Section))!值:$(pobjSectionEN.parentId)(clsSectionBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSectionEN.updDate) == false && GetStrLen(pobjSectionEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 论文节表(Section))!值:$(pobjSectionEN.updDate)(clsSectionBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSectionEN.updUser) == false && GetStrLen(pobjSectionEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 论文节表(Section))!值:$(pobjSectionEN.updUser)(clsSectionBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSectionEN.memo) == false && GetStrLen(pobjSectionEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 论文节表(Section))!值:$(pobjSectionEN.memo)(clsSectionBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjSectionEN.sectionId) == false && undefined !== pobjSectionEN.sectionId && tzDataType.isString(pobjSectionEN.sectionId) === false)
{
 throw new Error("(errid:Watl000063)字段[节Id(sectionId)]的值:[$(pobjSectionEN.sectionId)], 非法，应该为字符型(In 论文节表(Section))!(clsSectionBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSectionEN.sectionName) == false && undefined !== pobjSectionEN.sectionName && tzDataType.isString(pobjSectionEN.sectionName) === false)
{
 throw new Error("(errid:Watl000063)字段[节名(sectionName)]的值:[$(pobjSectionEN.sectionName)], 非法，应该为字符型(In 论文节表(Section))!(clsSectionBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSectionEN.paperId) == false && undefined !== pobjSectionEN.paperId && tzDataType.isString(pobjSectionEN.paperId) === false)
{
 throw new Error("(errid:Watl000063)字段[节名称(paperId)]的值:[$(pobjSectionEN.paperId)], 非法，应该为字符型(In 论文节表(Section))!(clsSectionBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSectionEN.parentId) == false && undefined !== pobjSectionEN.parentId && tzDataType.isString(pobjSectionEN.parentId) === false)
{
 throw new Error("(errid:Watl000063)字段[父节点Id(parentId)]的值:[$(pobjSectionEN.parentId)], 非法，应该为字符型(In 论文节表(Section))!(clsSectionBL:CheckProperty4Update)");
}
if (null != pobjSectionEN.orderNum && undefined !== pobjSectionEN.orderNum && tzDataType.isNumber(pobjSectionEN.orderNum) === false)
{
 throw new Error("(errid:Watl000063)字段[序号(orderNum)]的值:[$(pobjSectionEN.orderNum)], 非法，应该为数值型(In 论文节表(Section))!(clsSectionBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSectionEN.updDate) == false && undefined !== pobjSectionEN.updDate && tzDataType.isString(pobjSectionEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjSectionEN.updDate)], 非法，应该为字符型(In 论文节表(Section))!(clsSectionBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSectionEN.updUser) == false && undefined !== pobjSectionEN.updUser && tzDataType.isString(pobjSectionEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjSectionEN.updUser)], 非法，应该为字符型(In 论文节表(Section))!(clsSectionBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSectionEN.memo) == false && undefined !== pobjSectionEN.memo && tzDataType.isString(pobjSectionEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjSectionEN.memo)], 非法，应该为字符型(In 论文节表(Section))!(clsSectionBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (IsNullOrEmpty(pobjSectionEN.sectionId) === true )
{
 throw new Error("(errid:Watl000064)字段[节Id]不能为空(In 论文节表)!(clsSectionBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjSectionEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function Section_GetJSONStrByObj (pobjSectionEN: clsSectionEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjSectionEN.sf_UpdFldSetStr = pobjSectionEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjSectionEN);
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
export function Section_GetObjLstByJSONStr (strJSON: string): Array<clsSectionEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrSectionObjLst = new Array<clsSectionEN>();
if (strJSON === "")
{
return arrSectionObjLst;
}
try
{
arrSectionObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrSectionObjLst;
}
return arrSectionObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrSectionObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function Section_GetObjLstByJSONObjLst (arrSectionObjLstS: Array<clsSectionEN>): Array<clsSectionEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrSectionObjLst = new Array<clsSectionEN>();
for (const objInFor of arrSectionObjLstS) {
const obj1 = Section_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrSectionObjLst.push(obj1);
}
return arrSectionObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function Section_GetObjByJSONStr (strJSON: string): clsSectionEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjSectionEN = new clsSectionEN();
if (strJSON === "")
{
return pobjSectionEN;
}
try
{
pobjSectionEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjSectionEN;
}
return pobjSectionEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function Section_GetCombineCondition(objSection_Cond: clsSectionEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objSection_Cond.dicFldComparisonOp, clsSectionEN.con_SectionId) == true)
{
const strComparisonOp_SectionId:string = objSection_Cond.dicFldComparisonOp[clsSectionEN.con_SectionId];
strWhereCond += Format(" And {0} {2} '{1}'", clsSectionEN.con_SectionId, objSection_Cond.sectionId, strComparisonOp_SectionId);
}
if (Object.prototype.hasOwnProperty.call(objSection_Cond.dicFldComparisonOp, clsSectionEN.con_SectionName) == true)
{
const strComparisonOp_SectionName:string = objSection_Cond.dicFldComparisonOp[clsSectionEN.con_SectionName];
strWhereCond += Format(" And {0} {2} '{1}'", clsSectionEN.con_SectionName, objSection_Cond.sectionName, strComparisonOp_SectionName);
}
if (Object.prototype.hasOwnProperty.call(objSection_Cond.dicFldComparisonOp, clsSectionEN.con_PaperId) == true)
{
const strComparisonOp_PaperId:string = objSection_Cond.dicFldComparisonOp[clsSectionEN.con_PaperId];
strWhereCond += Format(" And {0} {2} '{1}'", clsSectionEN.con_PaperId, objSection_Cond.paperId, strComparisonOp_PaperId);
}
if (Object.prototype.hasOwnProperty.call(objSection_Cond.dicFldComparisonOp, clsSectionEN.con_ParentId) == true)
{
const strComparisonOp_ParentId:string = objSection_Cond.dicFldComparisonOp[clsSectionEN.con_ParentId];
strWhereCond += Format(" And {0} {2} '{1}'", clsSectionEN.con_ParentId, objSection_Cond.parentId, strComparisonOp_ParentId);
}
if (Object.prototype.hasOwnProperty.call(objSection_Cond.dicFldComparisonOp, clsSectionEN.con_OrderNum) == true)
{
const strComparisonOp_OrderNum:string = objSection_Cond.dicFldComparisonOp[clsSectionEN.con_OrderNum];
strWhereCond += Format(" And {0} {2} {1}", clsSectionEN.con_OrderNum, objSection_Cond.orderNum, strComparisonOp_OrderNum);
}
if (Object.prototype.hasOwnProperty.call(objSection_Cond.dicFldComparisonOp, clsSectionEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objSection_Cond.dicFldComparisonOp[clsSectionEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsSectionEN.con_UpdDate, objSection_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objSection_Cond.dicFldComparisonOp, clsSectionEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objSection_Cond.dicFldComparisonOp[clsSectionEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsSectionEN.con_UpdUser, objSection_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objSection_Cond.dicFldComparisonOp, clsSectionEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objSection_Cond.dicFldComparisonOp[clsSectionEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsSectionEN.con_Memo, objSection_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--Section(论文节表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param strSectionName: 节名(要求唯一的字段)
 * @param strPaperId: 节名称(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function Section_GetUniCondStr_PaperId_SectionName(objSectionEN: clsSectionEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and SectionName = '{0}'", objSectionEN.sectionName);
 strWhereCond +=  Format(" and PaperId = '{0}'", objSectionEN.paperId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--Section(论文节表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param strSectionName: 节名(要求唯一的字段)
 * @param strPaperId: 节名称(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function Section_GetUniCondStr4Update_PaperId_SectionName(objSectionEN: clsSectionEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and SectionId <> '{0}'", objSectionEN.sectionId);
 strWhereCond +=  Format(" and SectionName = '{0}'", objSectionEN.sectionName);
 strWhereCond +=  Format(" and PaperId = '{0}'", objSectionEN.paperId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objSectionENS:源对象
 * @param objSectionENT:目标对象
*/
export function Section_CopyObjTo(objSectionENS: clsSectionEN , objSectionENT: clsSectionEN ): void 
{
objSectionENT.sectionId = objSectionENS.sectionId; //节Id
objSectionENT.sectionName = objSectionENS.sectionName; //节名
objSectionENT.paperId = objSectionENS.paperId; //节名称
objSectionENT.parentId = objSectionENS.parentId; //父节点Id
objSectionENT.orderNum = objSectionENS.orderNum; //序号
objSectionENT.updDate = objSectionENS.updDate; //修改日期
objSectionENT.updUser = objSectionENS.updUser; //修改人
objSectionENT.memo = objSectionENS.memo; //备注
objSectionENT.sf_UpdFldSetStr = objSectionENS.updFldString; //sf_UpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objSectionENS:源对象
 * @param objSectionENT:目标对象
*/
export function Section_GetObjFromJsonObj(objSectionENS: clsSectionEN): clsSectionEN 
{
 const objSectionENT: clsSectionEN = new clsSectionEN();
ObjectAssign(objSectionENT, objSectionENS);
 return objSectionENT;
}