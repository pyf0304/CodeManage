
 /**
 * 类名:clsViewpointVWApi
 * 表名:ViewpointV(01120650)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:47:00
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
 * 观点版本表(ViewpointV)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { clsViewpointVEN } from "../../L0_Entity/GraduateEduTopic/clsViewpointVEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { tzDataType } from "../../PubFun/jsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const viewpointV_Controller = "ViewpointVApi";
 export const viewpointV_ConstructorName = "viewpointV";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngViewpointVId:关键字
 * @returns 对象
 **/
export async function ViewpointV_GetObjByViewpointVIdAsync(lngViewpointVId: number): Promise<clsViewpointVEN>  
{
const strThisFuncName = "GetObjByViewpointVIdAsync";

if (lngViewpointVId == 0)
{
  const strMsg = Format("参数:[lngViewpointVId]不能为空！(In GetObjByViewpointVIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjByViewpointVId";
const strUrl = GetWebApiUrl(viewpointV_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"lngViewpointVId": lngViewpointVId,
}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObj = data.returnObj;
if (returnObj == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", viewpointV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objViewpointV = ViewpointV_GetObjFromJsonObj(returnObj);
return objViewpointV;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointV_ConstructorName, strThisFuncName);
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
export function ViewpointV_SortFun_Defa(a:clsViewpointVEN , b:clsViewpointVEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.viewpointVId-b.viewpointVId;
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
export function ViewpointV_SortFun_Defa_2Fld(a:clsViewpointVEN , b:clsViewpointVEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.viewpointId == b.viewpointId) return a.viewpointName.localeCompare(b.viewpointName);
else return a.viewpointId.localeCompare(b.viewpointId);
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
export function ViewpointV_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsViewpointVEN.con_ViewpointVId:
return (a: clsViewpointVEN, b: clsViewpointVEN) => {
return a.viewpointVId-b.viewpointVId;
}
case clsViewpointVEN.con_ViewpointId:
return (a: clsViewpointVEN, b: clsViewpointVEN) => {
return a.viewpointId.localeCompare(b.viewpointId);
}
case clsViewpointVEN.con_ViewpointName:
return (a: clsViewpointVEN, b: clsViewpointVEN) => {
return a.viewpointName.localeCompare(b.viewpointName);
}
case clsViewpointVEN.con_ViewpointContent:
return (a: clsViewpointVEN, b: clsViewpointVEN) => {
return a.viewpointContent.localeCompare(b.viewpointContent);
}
case clsViewpointVEN.con_ViewpointTypeId:
return (a: clsViewpointVEN, b: clsViewpointVEN) => {
return a.viewpointTypeId.localeCompare(b.viewpointTypeId);
}
case clsViewpointVEN.con_Reason:
return (a: clsViewpointVEN, b: clsViewpointVEN) => {
return a.reason.localeCompare(b.reason);
}
case clsViewpointVEN.con_Source:
return (a: clsViewpointVEN, b: clsViewpointVEN) => {
return a.source.localeCompare(b.source);
}
case clsViewpointVEN.con_VPProposePeople:
return (a: clsViewpointVEN, b: clsViewpointVEN) => {
return a.vpProposePeople.localeCompare(b.vpProposePeople);
}
case clsViewpointVEN.con_UserTypeId:
return (a: clsViewpointVEN, b: clsViewpointVEN) => {
return a.userTypeId.localeCompare(b.userTypeId);
}
case clsViewpointVEN.con_CitationId:
return (a: clsViewpointVEN, b: clsViewpointVEN) => {
return a.citationId.localeCompare(b.citationId);
}
case clsViewpointVEN.con_UpdDate:
return (a: clsViewpointVEN, b: clsViewpointVEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsViewpointVEN.con_UpdUser:
return (a: clsViewpointVEN, b: clsViewpointVEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsViewpointVEN.con_PdfContent:
return (a: clsViewpointVEN, b: clsViewpointVEN) => {
return a.pdfContent.localeCompare(b.pdfContent);
}
case clsViewpointVEN.con_PdfPageNum:
return (a: clsViewpointVEN, b: clsViewpointVEN) => {
return a.pdfPageNum-b.pdfPageNum;
}
case clsViewpointVEN.con_id_CurrEduCls:
return (a: clsViewpointVEN, b: clsViewpointVEN) => {
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
case clsViewpointVEN.con_Memo:
return (a: clsViewpointVEN, b: clsViewpointVEN) => {
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[ViewpointV]中不存在！(in ${ viewpointV_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsViewpointVEN.con_ViewpointVId:
return (a: clsViewpointVEN, b: clsViewpointVEN) => {
return b.viewpointVId-a.viewpointVId;
}
case clsViewpointVEN.con_ViewpointId:
return (a: clsViewpointVEN, b: clsViewpointVEN) => {
return b.viewpointId.localeCompare(a.viewpointId);
}
case clsViewpointVEN.con_ViewpointName:
return (a: clsViewpointVEN, b: clsViewpointVEN) => {
return b.viewpointName.localeCompare(a.viewpointName);
}
case clsViewpointVEN.con_ViewpointContent:
return (a: clsViewpointVEN, b: clsViewpointVEN) => {
return b.viewpointContent.localeCompare(a.viewpointContent);
}
case clsViewpointVEN.con_ViewpointTypeId:
return (a: clsViewpointVEN, b: clsViewpointVEN) => {
return b.viewpointTypeId.localeCompare(a.viewpointTypeId);
}
case clsViewpointVEN.con_Reason:
return (a: clsViewpointVEN, b: clsViewpointVEN) => {
return b.reason.localeCompare(a.reason);
}
case clsViewpointVEN.con_Source:
return (a: clsViewpointVEN, b: clsViewpointVEN) => {
return b.source.localeCompare(a.source);
}
case clsViewpointVEN.con_VPProposePeople:
return (a: clsViewpointVEN, b: clsViewpointVEN) => {
return b.vpProposePeople.localeCompare(a.vpProposePeople);
}
case clsViewpointVEN.con_UserTypeId:
return (a: clsViewpointVEN, b: clsViewpointVEN) => {
return b.userTypeId.localeCompare(a.userTypeId);
}
case clsViewpointVEN.con_CitationId:
return (a: clsViewpointVEN, b: clsViewpointVEN) => {
return b.citationId.localeCompare(a.citationId);
}
case clsViewpointVEN.con_UpdDate:
return (a: clsViewpointVEN, b: clsViewpointVEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsViewpointVEN.con_UpdUser:
return (a: clsViewpointVEN, b: clsViewpointVEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsViewpointVEN.con_PdfContent:
return (a: clsViewpointVEN, b: clsViewpointVEN) => {
return b.pdfContent.localeCompare(a.pdfContent);
}
case clsViewpointVEN.con_PdfPageNum:
return (a: clsViewpointVEN, b: clsViewpointVEN) => {
return b.pdfPageNum-a.pdfPageNum;
}
case clsViewpointVEN.con_id_CurrEduCls:
return (a: clsViewpointVEN, b: clsViewpointVEN) => {
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
case clsViewpointVEN.con_Memo:
return (a: clsViewpointVEN, b: clsViewpointVEN) => {
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[ViewpointV]中不存在！(in ${ viewpointV_ConstructorName}.${ strThisFuncName})`;
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
export async function ViewpointV_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsViewpointVEN.con_ViewpointVId:
return (obj: clsViewpointVEN) => {
return obj.viewpointVId === value;
}
case clsViewpointVEN.con_ViewpointId:
return (obj: clsViewpointVEN) => {
return obj.viewpointId === value;
}
case clsViewpointVEN.con_ViewpointName:
return (obj: clsViewpointVEN) => {
return obj.viewpointName === value;
}
case clsViewpointVEN.con_ViewpointContent:
return (obj: clsViewpointVEN) => {
return obj.viewpointContent === value;
}
case clsViewpointVEN.con_ViewpointTypeId:
return (obj: clsViewpointVEN) => {
return obj.viewpointTypeId === value;
}
case clsViewpointVEN.con_Reason:
return (obj: clsViewpointVEN) => {
return obj.reason === value;
}
case clsViewpointVEN.con_Source:
return (obj: clsViewpointVEN) => {
return obj.source === value;
}
case clsViewpointVEN.con_VPProposePeople:
return (obj: clsViewpointVEN) => {
return obj.vpProposePeople === value;
}
case clsViewpointVEN.con_UserTypeId:
return (obj: clsViewpointVEN) => {
return obj.userTypeId === value;
}
case clsViewpointVEN.con_CitationId:
return (obj: clsViewpointVEN) => {
return obj.citationId === value;
}
case clsViewpointVEN.con_UpdDate:
return (obj: clsViewpointVEN) => {
return obj.updDate === value;
}
case clsViewpointVEN.con_UpdUser:
return (obj: clsViewpointVEN) => {
return obj.updUser === value;
}
case clsViewpointVEN.con_PdfContent:
return (obj: clsViewpointVEN) => {
return obj.pdfContent === value;
}
case clsViewpointVEN.con_PdfPageNum:
return (obj: clsViewpointVEN) => {
return obj.pdfPageNum === value;
}
case clsViewpointVEN.con_id_CurrEduCls:
return (obj: clsViewpointVEN) => {
return obj.id_CurrEduCls === value;
}
case clsViewpointVEN.con_Memo:
return (obj: clsViewpointVEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[ViewpointV]中不存在！(in ${ viewpointV_ConstructorName}.${ strThisFuncName})`;
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
export async function ViewpointV_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(viewpointV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointV_ConstructorName, strThisFuncName);
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
export async function ViewpointV_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(viewpointV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointV_ConstructorName, strThisFuncName);
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
export async function ViewpointV_GetFirstObjAsync(strWhereCond: string): Promise<clsViewpointVEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(viewpointV_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", viewpointV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objViewpointV = ViewpointV_GetObjFromJsonObj(returnObj);
return objViewpointV;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointV_ConstructorName, strThisFuncName);
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
export async function ViewpointV_GetObjLstAsync(strWhereCond: string): Promise<Array<clsViewpointVEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(viewpointV_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", viewpointV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = ViewpointV_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointV_ConstructorName, strThisFuncName);
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
 * @param arrViewpointVId:关键字列表
 * @returns 对象列表
 **/
export async function ViewpointV_GetObjLstByViewpointVIdLstAsync(arrViewpointVId: Array<string>): Promise<Array<clsViewpointVEN>>  
{
const strThisFuncName = "GetObjLstByViewpointVIdLstAsync";
const strAction = "GetObjLstByViewpointVIdLst";
const strUrl = GetWebApiUrl(viewpointV_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrViewpointVId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", viewpointV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = ViewpointV_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointV_ConstructorName, strThisFuncName);
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
export async function ViewpointV_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsViewpointVEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(viewpointV_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", viewpointV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = ViewpointV_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointV_ConstructorName, strThisFuncName);
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
export async function ViewpointV_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsViewpointVEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(viewpointV_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", viewpointV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = ViewpointV_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointV_ConstructorName, strThisFuncName);
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
export async function ViewpointV_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(viewpointV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointV_ConstructorName, strThisFuncName);
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
export async function ViewpointV_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsViewpointVEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(viewpointV_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", viewpointV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = ViewpointV_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointV_ConstructorName, strThisFuncName);
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
 * @param lngViewpointVId:关键字
 * @returns 获取删除的结果
 **/
export async function ViewpointV_DelRecordAsync(lngViewpointVId: number): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(viewpointV_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, lngViewpointVId);
try
{
const response = await axios.delete(strUrl,
{
params: { "Id": lngViewpointVId, }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointV_ConstructorName, strThisFuncName);
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
 * @param arrViewpointVId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function ViewpointV_DelViewpointVsAsync(arrViewpointVId: Array<string>): Promise<number> 
{
const strThisFuncName = "DelViewpointVsAsync";
const strAction = "DelViewpointVs";
const strUrl = GetWebApiUrl(viewpointV_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrViewpointVId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointV_ConstructorName, strThisFuncName);
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
export async function ViewpointV_DelViewpointVsByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "DelViewpointVsByCondAsync";
const strAction = "DelViewpointVsByCond";
const strUrl = GetWebApiUrl(viewpointV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointV_ConstructorName, strThisFuncName);
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
 * @param objViewpointVEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function ViewpointV_AddNewRecordAsync(objViewpointVEN: clsViewpointVEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objViewpointVEN);
const strUrl = GetWebApiUrl(viewpointV_Controller, strAction);
try
{
const response = await axios.post(strUrl, objViewpointVEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointV_ConstructorName, strThisFuncName);
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
 * @param objViewpointVEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function ViewpointV_AddNewRecordWithReturnKeyAsync(objViewpointVEN: clsViewpointVEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(viewpointV_Controller, strAction);
try
{
const response = await axios.post(strUrl, objViewpointVEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointV_ConstructorName, strThisFuncName);
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
 * @param objViewpointVEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function ViewpointV_AddNewRecordWithReturnKey(objViewpointVEN: clsViewpointVEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objViewpointVEN.viewpointVId === null || objViewpointVEN.viewpointVId === 0)
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(viewpointV_Controller, strAction);
try
{
const response = await axios.post(strUrl, objViewpointVEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointV_ConstructorName, strThisFuncName);
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
 * @param objViewpointVEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function ViewpointV_UpdateRecordAsync(objViewpointVEN: clsViewpointVEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objViewpointVEN.sf_UpdFldSetStr === undefined || objViewpointVEN.sf_UpdFldSetStr === null || objViewpointVEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objViewpointVEN.viewpointVId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(viewpointV_Controller, strAction);
try
{
const response = await axios.post(strUrl, objViewpointVEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointV_ConstructorName, strThisFuncName);
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
 * @param objViewpointVEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function ViewpointV_UpdateWithConditionAsync(objViewpointVEN: clsViewpointVEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objViewpointVEN.sf_UpdFldSetStr === undefined || objViewpointVEN.sf_UpdFldSetStr === null || objViewpointVEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objViewpointVEN.viewpointVId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(viewpointV_Controller, strAction);
objViewpointVEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objViewpointVEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointV_ConstructorName, strThisFuncName);
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
export async function ViewpointV_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(viewpointV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointV_ConstructorName, strThisFuncName);
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
 * @param lngViewpointVId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function ViewpointV_IsExist(lngViewpointVId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(viewpointV_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"ViewpointVId": lngViewpointVId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointV_ConstructorName, strThisFuncName);
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
 * @param lngViewpointVId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function ViewpointV_IsExistAsync(lngViewpointVId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(viewpointV_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "lngViewpointVId": lngViewpointVId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointV_ConstructorName, strThisFuncName);
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
export async function ViewpointV_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(viewpointV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointV_ConstructorName, strThisFuncName);
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
export async function ViewpointV_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(viewpointV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointV_ConstructorName, strThisFuncName);
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
export function ViewpointV_GetWebApiUrl(strController: string, strAction: string): string {
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
export function ViewpointV_CheckPropertyNew(pobjViewpointVEN: clsViewpointVEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjViewpointVEN.viewpointId) === true )
{
 throw new Error("(errid:Watl000058)字段[观点Id]不能为空(In 观点版本表)!(clsViewpointVBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjViewpointVEN.viewpointId) == false && GetStrLen(pobjViewpointVEN.viewpointId) > 8)
{
 throw new Error("(errid:Watl000059)字段[观点Id(viewpointId)]的长度不能超过8(In 观点版本表(ViewpointV))!值:$(pobjViewpointVEN.viewpointId)(clsViewpointVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjViewpointVEN.viewpointName) == false && GetStrLen(pobjViewpointVEN.viewpointName) > 500)
{
 throw new Error("(errid:Watl000059)字段[观点名称(viewpointName)]的长度不能超过500(In 观点版本表(ViewpointV))!值:$(pobjViewpointVEN.viewpointName)(clsViewpointVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjViewpointVEN.viewpointTypeId) == false && GetStrLen(pobjViewpointVEN.viewpointTypeId) > 4)
{
 throw new Error("(errid:Watl000059)字段[观点类型Id(viewpointTypeId)]的长度不能超过4(In 观点版本表(ViewpointV))!值:$(pobjViewpointVEN.viewpointTypeId)(clsViewpointVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjViewpointVEN.source) == false && GetStrLen(pobjViewpointVEN.source) > 500)
{
 throw new Error("(errid:Watl000059)字段[来源(source)]的长度不能超过500(In 观点版本表(ViewpointV))!值:$(pobjViewpointVEN.source)(clsViewpointVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjViewpointVEN.vpProposePeople) == false && GetStrLen(pobjViewpointVEN.vpProposePeople) > 50)
{
 throw new Error("(errid:Watl000059)字段[观点提出人(vpProposePeople)]的长度不能超过50(In 观点版本表(ViewpointV))!值:$(pobjViewpointVEN.vpProposePeople)(clsViewpointVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjViewpointVEN.userTypeId) == false && GetStrLen(pobjViewpointVEN.userTypeId) > 2)
{
 throw new Error("(errid:Watl000059)字段[用户类型Id(userTypeId)]的长度不能超过2(In 观点版本表(ViewpointV))!值:$(pobjViewpointVEN.userTypeId)(clsViewpointVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjViewpointVEN.citationId) == false && GetStrLen(pobjViewpointVEN.citationId) > 8)
{
 throw new Error("(errid:Watl000059)字段[引用Id(citationId)]的长度不能超过8(In 观点版本表(ViewpointV))!值:$(pobjViewpointVEN.citationId)(clsViewpointVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjViewpointVEN.updDate) == false && GetStrLen(pobjViewpointVEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 观点版本表(ViewpointV))!值:$(pobjViewpointVEN.updDate)(clsViewpointVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjViewpointVEN.updUser) == false && GetStrLen(pobjViewpointVEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 观点版本表(ViewpointV))!值:$(pobjViewpointVEN.updUser)(clsViewpointVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjViewpointVEN.pdfContent) == false && GetStrLen(pobjViewpointVEN.pdfContent) > 2000)
{
 throw new Error("(errid:Watl000059)字段[Pdf内容(pdfContent)]的长度不能超过2000(In 观点版本表(ViewpointV))!值:$(pobjViewpointVEN.pdfContent)(clsViewpointVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjViewpointVEN.id_CurrEduCls) == false && GetStrLen(pobjViewpointVEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 观点版本表(ViewpointV))!值:$(pobjViewpointVEN.id_CurrEduCls)(clsViewpointVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjViewpointVEN.memo) == false && GetStrLen(pobjViewpointVEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 观点版本表(ViewpointV))!值:$(pobjViewpointVEN.memo)(clsViewpointVBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null != pobjViewpointVEN.viewpointVId && undefined !== pobjViewpointVEN.viewpointVId && tzDataType.isNumber(pobjViewpointVEN.viewpointVId) === false)
{
 throw new Error("(errid:Watl000060)字段[ViewpointVId(viewpointVId)]的值:[$(pobjViewpointVEN.viewpointVId)], 非法，应该为数值型(In 观点版本表(ViewpointV))!(clsViewpointVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjViewpointVEN.viewpointId) == false && undefined !== pobjViewpointVEN.viewpointId && tzDataType.isString(pobjViewpointVEN.viewpointId) === false)
{
 throw new Error("(errid:Watl000060)字段[观点Id(viewpointId)]的值:[$(pobjViewpointVEN.viewpointId)], 非法，应该为字符型(In 观点版本表(ViewpointV))!(clsViewpointVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjViewpointVEN.viewpointName) == false && undefined !== pobjViewpointVEN.viewpointName && tzDataType.isString(pobjViewpointVEN.viewpointName) === false)
{
 throw new Error("(errid:Watl000060)字段[观点名称(viewpointName)]的值:[$(pobjViewpointVEN.viewpointName)], 非法，应该为字符型(In 观点版本表(ViewpointV))!(clsViewpointVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjViewpointVEN.viewpointContent) == false && undefined !== pobjViewpointVEN.viewpointContent && tzDataType.isString(pobjViewpointVEN.viewpointContent) === false)
{
 throw new Error("(errid:Watl000060)字段[观点内容(viewpointContent)]的值:[$(pobjViewpointVEN.viewpointContent)], 非法，应该为字符型(In 观点版本表(ViewpointV))!(clsViewpointVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjViewpointVEN.viewpointTypeId) == false && undefined !== pobjViewpointVEN.viewpointTypeId && tzDataType.isString(pobjViewpointVEN.viewpointTypeId) === false)
{
 throw new Error("(errid:Watl000060)字段[观点类型Id(viewpointTypeId)]的值:[$(pobjViewpointVEN.viewpointTypeId)], 非法，应该为字符型(In 观点版本表(ViewpointV))!(clsViewpointVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjViewpointVEN.reason) == false && undefined !== pobjViewpointVEN.reason && tzDataType.isString(pobjViewpointVEN.reason) === false)
{
 throw new Error("(errid:Watl000060)字段[理由(reason)]的值:[$(pobjViewpointVEN.reason)], 非法，应该为字符型(In 观点版本表(ViewpointV))!(clsViewpointVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjViewpointVEN.source) == false && undefined !== pobjViewpointVEN.source && tzDataType.isString(pobjViewpointVEN.source) === false)
{
 throw new Error("(errid:Watl000060)字段[来源(source)]的值:[$(pobjViewpointVEN.source)], 非法，应该为字符型(In 观点版本表(ViewpointV))!(clsViewpointVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjViewpointVEN.vpProposePeople) == false && undefined !== pobjViewpointVEN.vpProposePeople && tzDataType.isString(pobjViewpointVEN.vpProposePeople) === false)
{
 throw new Error("(errid:Watl000060)字段[观点提出人(vpProposePeople)]的值:[$(pobjViewpointVEN.vpProposePeople)], 非法，应该为字符型(In 观点版本表(ViewpointV))!(clsViewpointVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjViewpointVEN.userTypeId) == false && undefined !== pobjViewpointVEN.userTypeId && tzDataType.isString(pobjViewpointVEN.userTypeId) === false)
{
 throw new Error("(errid:Watl000060)字段[用户类型Id(userTypeId)]的值:[$(pobjViewpointVEN.userTypeId)], 非法，应该为字符型(In 观点版本表(ViewpointV))!(clsViewpointVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjViewpointVEN.citationId) == false && undefined !== pobjViewpointVEN.citationId && tzDataType.isString(pobjViewpointVEN.citationId) === false)
{
 throw new Error("(errid:Watl000060)字段[引用Id(citationId)]的值:[$(pobjViewpointVEN.citationId)], 非法，应该为字符型(In 观点版本表(ViewpointV))!(clsViewpointVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjViewpointVEN.updDate) == false && undefined !== pobjViewpointVEN.updDate && tzDataType.isString(pobjViewpointVEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjViewpointVEN.updDate)], 非法，应该为字符型(In 观点版本表(ViewpointV))!(clsViewpointVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjViewpointVEN.updUser) == false && undefined !== pobjViewpointVEN.updUser && tzDataType.isString(pobjViewpointVEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjViewpointVEN.updUser)], 非法，应该为字符型(In 观点版本表(ViewpointV))!(clsViewpointVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjViewpointVEN.pdfContent) == false && undefined !== pobjViewpointVEN.pdfContent && tzDataType.isString(pobjViewpointVEN.pdfContent) === false)
{
 throw new Error("(errid:Watl000060)字段[Pdf内容(pdfContent)]的值:[$(pobjViewpointVEN.pdfContent)], 非法，应该为字符型(In 观点版本表(ViewpointV))!(clsViewpointVBL:CheckPropertyNew)");
}
if (null != pobjViewpointVEN.pdfPageNum && undefined !== pobjViewpointVEN.pdfPageNum && tzDataType.isNumber(pobjViewpointVEN.pdfPageNum) === false)
{
 throw new Error("(errid:Watl000060)字段[Pdf页码(pdfPageNum)]的值:[$(pobjViewpointVEN.pdfPageNum)], 非法，应该为数值型(In 观点版本表(ViewpointV))!(clsViewpointVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjViewpointVEN.id_CurrEduCls) == false && undefined !== pobjViewpointVEN.id_CurrEduCls && tzDataType.isString(pobjViewpointVEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjViewpointVEN.id_CurrEduCls)], 非法，应该为字符型(In 观点版本表(ViewpointV))!(clsViewpointVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjViewpointVEN.memo) == false && undefined !== pobjViewpointVEN.memo && tzDataType.isString(pobjViewpointVEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjViewpointVEN.memo)], 非法，应该为字符型(In 观点版本表(ViewpointV))!(clsViewpointVBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjViewpointVEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function ViewpointV_CheckProperty4Update (pobjViewpointVEN: clsViewpointVEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjViewpointVEN.viewpointId) == false && GetStrLen(pobjViewpointVEN.viewpointId) > 8)
{
 throw new Error("(errid:Watl000062)字段[观点Id(viewpointId)]的长度不能超过8(In 观点版本表(ViewpointV))!值:$(pobjViewpointVEN.viewpointId)(clsViewpointVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjViewpointVEN.viewpointName) == false && GetStrLen(pobjViewpointVEN.viewpointName) > 500)
{
 throw new Error("(errid:Watl000062)字段[观点名称(viewpointName)]的长度不能超过500(In 观点版本表(ViewpointV))!值:$(pobjViewpointVEN.viewpointName)(clsViewpointVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjViewpointVEN.viewpointTypeId) == false && GetStrLen(pobjViewpointVEN.viewpointTypeId) > 4)
{
 throw new Error("(errid:Watl000062)字段[观点类型Id(viewpointTypeId)]的长度不能超过4(In 观点版本表(ViewpointV))!值:$(pobjViewpointVEN.viewpointTypeId)(clsViewpointVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjViewpointVEN.source) == false && GetStrLen(pobjViewpointVEN.source) > 500)
{
 throw new Error("(errid:Watl000062)字段[来源(source)]的长度不能超过500(In 观点版本表(ViewpointV))!值:$(pobjViewpointVEN.source)(clsViewpointVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjViewpointVEN.vpProposePeople) == false && GetStrLen(pobjViewpointVEN.vpProposePeople) > 50)
{
 throw new Error("(errid:Watl000062)字段[观点提出人(vpProposePeople)]的长度不能超过50(In 观点版本表(ViewpointV))!值:$(pobjViewpointVEN.vpProposePeople)(clsViewpointVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjViewpointVEN.userTypeId) == false && GetStrLen(pobjViewpointVEN.userTypeId) > 2)
{
 throw new Error("(errid:Watl000062)字段[用户类型Id(userTypeId)]的长度不能超过2(In 观点版本表(ViewpointV))!值:$(pobjViewpointVEN.userTypeId)(clsViewpointVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjViewpointVEN.citationId) == false && GetStrLen(pobjViewpointVEN.citationId) > 8)
{
 throw new Error("(errid:Watl000062)字段[引用Id(citationId)]的长度不能超过8(In 观点版本表(ViewpointV))!值:$(pobjViewpointVEN.citationId)(clsViewpointVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjViewpointVEN.updDate) == false && GetStrLen(pobjViewpointVEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 观点版本表(ViewpointV))!值:$(pobjViewpointVEN.updDate)(clsViewpointVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjViewpointVEN.updUser) == false && GetStrLen(pobjViewpointVEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 观点版本表(ViewpointV))!值:$(pobjViewpointVEN.updUser)(clsViewpointVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjViewpointVEN.pdfContent) == false && GetStrLen(pobjViewpointVEN.pdfContent) > 2000)
{
 throw new Error("(errid:Watl000062)字段[Pdf内容(pdfContent)]的长度不能超过2000(In 观点版本表(ViewpointV))!值:$(pobjViewpointVEN.pdfContent)(clsViewpointVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjViewpointVEN.id_CurrEduCls) == false && GetStrLen(pobjViewpointVEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 观点版本表(ViewpointV))!值:$(pobjViewpointVEN.id_CurrEduCls)(clsViewpointVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjViewpointVEN.memo) == false && GetStrLen(pobjViewpointVEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 观点版本表(ViewpointV))!值:$(pobjViewpointVEN.memo)(clsViewpointVBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null != pobjViewpointVEN.viewpointVId && undefined !== pobjViewpointVEN.viewpointVId && tzDataType.isNumber(pobjViewpointVEN.viewpointVId) === false)
{
 throw new Error("(errid:Watl000063)字段[ViewpointVId(viewpointVId)]的值:[$(pobjViewpointVEN.viewpointVId)], 非法，应该为数值型(In 观点版本表(ViewpointV))!(clsViewpointVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjViewpointVEN.viewpointId) == false && undefined !== pobjViewpointVEN.viewpointId && tzDataType.isString(pobjViewpointVEN.viewpointId) === false)
{
 throw new Error("(errid:Watl000063)字段[观点Id(viewpointId)]的值:[$(pobjViewpointVEN.viewpointId)], 非法，应该为字符型(In 观点版本表(ViewpointV))!(clsViewpointVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjViewpointVEN.viewpointName) == false && undefined !== pobjViewpointVEN.viewpointName && tzDataType.isString(pobjViewpointVEN.viewpointName) === false)
{
 throw new Error("(errid:Watl000063)字段[观点名称(viewpointName)]的值:[$(pobjViewpointVEN.viewpointName)], 非法，应该为字符型(In 观点版本表(ViewpointV))!(clsViewpointVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjViewpointVEN.viewpointContent) == false && undefined !== pobjViewpointVEN.viewpointContent && tzDataType.isString(pobjViewpointVEN.viewpointContent) === false)
{
 throw new Error("(errid:Watl000063)字段[观点内容(viewpointContent)]的值:[$(pobjViewpointVEN.viewpointContent)], 非法，应该为字符型(In 观点版本表(ViewpointV))!(clsViewpointVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjViewpointVEN.viewpointTypeId) == false && undefined !== pobjViewpointVEN.viewpointTypeId && tzDataType.isString(pobjViewpointVEN.viewpointTypeId) === false)
{
 throw new Error("(errid:Watl000063)字段[观点类型Id(viewpointTypeId)]的值:[$(pobjViewpointVEN.viewpointTypeId)], 非法，应该为字符型(In 观点版本表(ViewpointV))!(clsViewpointVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjViewpointVEN.reason) == false && undefined !== pobjViewpointVEN.reason && tzDataType.isString(pobjViewpointVEN.reason) === false)
{
 throw new Error("(errid:Watl000063)字段[理由(reason)]的值:[$(pobjViewpointVEN.reason)], 非法，应该为字符型(In 观点版本表(ViewpointV))!(clsViewpointVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjViewpointVEN.source) == false && undefined !== pobjViewpointVEN.source && tzDataType.isString(pobjViewpointVEN.source) === false)
{
 throw new Error("(errid:Watl000063)字段[来源(source)]的值:[$(pobjViewpointVEN.source)], 非法，应该为字符型(In 观点版本表(ViewpointV))!(clsViewpointVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjViewpointVEN.vpProposePeople) == false && undefined !== pobjViewpointVEN.vpProposePeople && tzDataType.isString(pobjViewpointVEN.vpProposePeople) === false)
{
 throw new Error("(errid:Watl000063)字段[观点提出人(vpProposePeople)]的值:[$(pobjViewpointVEN.vpProposePeople)], 非法，应该为字符型(In 观点版本表(ViewpointV))!(clsViewpointVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjViewpointVEN.userTypeId) == false && undefined !== pobjViewpointVEN.userTypeId && tzDataType.isString(pobjViewpointVEN.userTypeId) === false)
{
 throw new Error("(errid:Watl000063)字段[用户类型Id(userTypeId)]的值:[$(pobjViewpointVEN.userTypeId)], 非法，应该为字符型(In 观点版本表(ViewpointV))!(clsViewpointVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjViewpointVEN.citationId) == false && undefined !== pobjViewpointVEN.citationId && tzDataType.isString(pobjViewpointVEN.citationId) === false)
{
 throw new Error("(errid:Watl000063)字段[引用Id(citationId)]的值:[$(pobjViewpointVEN.citationId)], 非法，应该为字符型(In 观点版本表(ViewpointV))!(clsViewpointVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjViewpointVEN.updDate) == false && undefined !== pobjViewpointVEN.updDate && tzDataType.isString(pobjViewpointVEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjViewpointVEN.updDate)], 非法，应该为字符型(In 观点版本表(ViewpointV))!(clsViewpointVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjViewpointVEN.updUser) == false && undefined !== pobjViewpointVEN.updUser && tzDataType.isString(pobjViewpointVEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjViewpointVEN.updUser)], 非法，应该为字符型(In 观点版本表(ViewpointV))!(clsViewpointVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjViewpointVEN.pdfContent) == false && undefined !== pobjViewpointVEN.pdfContent && tzDataType.isString(pobjViewpointVEN.pdfContent) === false)
{
 throw new Error("(errid:Watl000063)字段[Pdf内容(pdfContent)]的值:[$(pobjViewpointVEN.pdfContent)], 非法，应该为字符型(In 观点版本表(ViewpointV))!(clsViewpointVBL:CheckProperty4Update)");
}
if (null != pobjViewpointVEN.pdfPageNum && undefined !== pobjViewpointVEN.pdfPageNum && tzDataType.isNumber(pobjViewpointVEN.pdfPageNum) === false)
{
 throw new Error("(errid:Watl000063)字段[Pdf页码(pdfPageNum)]的值:[$(pobjViewpointVEN.pdfPageNum)], 非法，应该为数值型(In 观点版本表(ViewpointV))!(clsViewpointVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjViewpointVEN.id_CurrEduCls) == false && undefined !== pobjViewpointVEN.id_CurrEduCls && tzDataType.isString(pobjViewpointVEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjViewpointVEN.id_CurrEduCls)], 非法，应该为字符型(In 观点版本表(ViewpointV))!(clsViewpointVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjViewpointVEN.memo) == false && undefined !== pobjViewpointVEN.memo && tzDataType.isString(pobjViewpointVEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjViewpointVEN.memo)], 非法，应该为字符型(In 观点版本表(ViewpointV))!(clsViewpointVBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjViewpointVEN.viewpointVId 
 || pobjViewpointVEN.viewpointVId != null && pobjViewpointVEN.viewpointVId.toString()  ===  "")
{
 throw new Error("(errid:Watl000064)字段[ViewpointVId]不能为空(In 观点版本表)!(clsViewpointVBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjViewpointVEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function ViewpointV_GetJSONStrByObj (pobjViewpointVEN: clsViewpointVEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjViewpointVEN.sf_UpdFldSetStr = pobjViewpointVEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjViewpointVEN);
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
export function ViewpointV_GetObjLstByJSONStr (strJSON: string): Array<clsViewpointVEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrViewpointVObjLst = new Array<clsViewpointVEN>();
if (strJSON === "")
{
return arrViewpointVObjLst;
}
try
{
arrViewpointVObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrViewpointVObjLst;
}
return arrViewpointVObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrViewpointVObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function ViewpointV_GetObjLstByJSONObjLst (arrViewpointVObjLstS: Array<clsViewpointVEN>): Array<clsViewpointVEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrViewpointVObjLst = new Array<clsViewpointVEN>();
for (const objInFor of arrViewpointVObjLstS) {
const obj1 = ViewpointV_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrViewpointVObjLst.push(obj1);
}
return arrViewpointVObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function ViewpointV_GetObjByJSONStr (strJSON: string): clsViewpointVEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjViewpointVEN = new clsViewpointVEN();
if (strJSON === "")
{
return pobjViewpointVEN;
}
try
{
pobjViewpointVEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjViewpointVEN;
}
return pobjViewpointVEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function ViewpointV_GetCombineCondition(objViewpointV_Cond: clsViewpointVEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objViewpointV_Cond.dicFldComparisonOp, clsViewpointVEN.con_ViewpointVId) == true)
{
const strComparisonOp_ViewpointVId:string = objViewpointV_Cond.dicFldComparisonOp[clsViewpointVEN.con_ViewpointVId];
strWhereCond += Format(" And {0} {2} {1}", clsViewpointVEN.con_ViewpointVId, objViewpointV_Cond.viewpointVId, strComparisonOp_ViewpointVId);
}
if (Object.prototype.hasOwnProperty.call(objViewpointV_Cond.dicFldComparisonOp, clsViewpointVEN.con_ViewpointId) == true)
{
const strComparisonOp_ViewpointId:string = objViewpointV_Cond.dicFldComparisonOp[clsViewpointVEN.con_ViewpointId];
strWhereCond += Format(" And {0} {2} '{1}'", clsViewpointVEN.con_ViewpointId, objViewpointV_Cond.viewpointId, strComparisonOp_ViewpointId);
}
if (Object.prototype.hasOwnProperty.call(objViewpointV_Cond.dicFldComparisonOp, clsViewpointVEN.con_ViewpointName) == true)
{
const strComparisonOp_ViewpointName:string = objViewpointV_Cond.dicFldComparisonOp[clsViewpointVEN.con_ViewpointName];
strWhereCond += Format(" And {0} {2} '{1}'", clsViewpointVEN.con_ViewpointName, objViewpointV_Cond.viewpointName, strComparisonOp_ViewpointName);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objViewpointV_Cond.dicFldComparisonOp, clsViewpointVEN.con_ViewpointTypeId) == true)
{
const strComparisonOp_ViewpointTypeId:string = objViewpointV_Cond.dicFldComparisonOp[clsViewpointVEN.con_ViewpointTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsViewpointVEN.con_ViewpointTypeId, objViewpointV_Cond.viewpointTypeId, strComparisonOp_ViewpointTypeId);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objViewpointV_Cond.dicFldComparisonOp, clsViewpointVEN.con_Source) == true)
{
const strComparisonOp_Source:string = objViewpointV_Cond.dicFldComparisonOp[clsViewpointVEN.con_Source];
strWhereCond += Format(" And {0} {2} '{1}'", clsViewpointVEN.con_Source, objViewpointV_Cond.source, strComparisonOp_Source);
}
if (Object.prototype.hasOwnProperty.call(objViewpointV_Cond.dicFldComparisonOp, clsViewpointVEN.con_VPProposePeople) == true)
{
const strComparisonOp_VPProposePeople:string = objViewpointV_Cond.dicFldComparisonOp[clsViewpointVEN.con_VPProposePeople];
strWhereCond += Format(" And {0} {2} '{1}'", clsViewpointVEN.con_VPProposePeople, objViewpointV_Cond.vpProposePeople, strComparisonOp_VPProposePeople);
}
if (Object.prototype.hasOwnProperty.call(objViewpointV_Cond.dicFldComparisonOp, clsViewpointVEN.con_UserTypeId) == true)
{
const strComparisonOp_UserTypeId:string = objViewpointV_Cond.dicFldComparisonOp[clsViewpointVEN.con_UserTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsViewpointVEN.con_UserTypeId, objViewpointV_Cond.userTypeId, strComparisonOp_UserTypeId);
}
if (Object.prototype.hasOwnProperty.call(objViewpointV_Cond.dicFldComparisonOp, clsViewpointVEN.con_CitationId) == true)
{
const strComparisonOp_CitationId:string = objViewpointV_Cond.dicFldComparisonOp[clsViewpointVEN.con_CitationId];
strWhereCond += Format(" And {0} {2} '{1}'", clsViewpointVEN.con_CitationId, objViewpointV_Cond.citationId, strComparisonOp_CitationId);
}
if (Object.prototype.hasOwnProperty.call(objViewpointV_Cond.dicFldComparisonOp, clsViewpointVEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objViewpointV_Cond.dicFldComparisonOp[clsViewpointVEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsViewpointVEN.con_UpdDate, objViewpointV_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objViewpointV_Cond.dicFldComparisonOp, clsViewpointVEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objViewpointV_Cond.dicFldComparisonOp[clsViewpointVEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsViewpointVEN.con_UpdUser, objViewpointV_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objViewpointV_Cond.dicFldComparisonOp, clsViewpointVEN.con_PdfContent) == true)
{
const strComparisonOp_PdfContent:string = objViewpointV_Cond.dicFldComparisonOp[clsViewpointVEN.con_PdfContent];
strWhereCond += Format(" And {0} {2} '{1}'", clsViewpointVEN.con_PdfContent, objViewpointV_Cond.pdfContent, strComparisonOp_PdfContent);
}
if (Object.prototype.hasOwnProperty.call(objViewpointV_Cond.dicFldComparisonOp, clsViewpointVEN.con_PdfPageNum) == true)
{
const strComparisonOp_PdfPageNum:string = objViewpointV_Cond.dicFldComparisonOp[clsViewpointVEN.con_PdfPageNum];
strWhereCond += Format(" And {0} {2} {1}", clsViewpointVEN.con_PdfPageNum, objViewpointV_Cond.pdfPageNum, strComparisonOp_PdfPageNum);
}
if (Object.prototype.hasOwnProperty.call(objViewpointV_Cond.dicFldComparisonOp, clsViewpointVEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objViewpointV_Cond.dicFldComparisonOp[clsViewpointVEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsViewpointVEN.con_id_CurrEduCls, objViewpointV_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (Object.prototype.hasOwnProperty.call(objViewpointV_Cond.dicFldComparisonOp, clsViewpointVEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objViewpointV_Cond.dicFldComparisonOp[clsViewpointVEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsViewpointVEN.con_Memo, objViewpointV_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--ViewpointV(观点版本表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param lngViewpointVId: ViewpointVId(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function ViewpointV_GetUniCondStr_ViewpointVId(objViewpointVEN: clsViewpointVEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and ViewpointVId = '{0}'", objViewpointVEN.viewpointVId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--ViewpointV(观点版本表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param lngViewpointVId: ViewpointVId(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function ViewpointV_GetUniCondStr4Update_ViewpointVId(objViewpointVEN: clsViewpointVEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and ViewpointVId <> '{0}'", objViewpointVEN.viewpointVId);
 strWhereCond +=  Format(" and ViewpointVId = '{0}'", objViewpointVEN.viewpointVId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objViewpointVENS:源对象
 * @param objViewpointVENT:目标对象
*/
export function ViewpointV_CopyObjTo(objViewpointVENS: clsViewpointVEN , objViewpointVENT: clsViewpointVEN ): void 
{
objViewpointVENT.viewpointVId = objViewpointVENS.viewpointVId; //ViewpointVId
objViewpointVENT.viewpointId = objViewpointVENS.viewpointId; //观点Id
objViewpointVENT.viewpointName = objViewpointVENS.viewpointName; //观点名称
objViewpointVENT.viewpointContent = objViewpointVENS.viewpointContent; //观点内容
objViewpointVENT.viewpointTypeId = objViewpointVENS.viewpointTypeId; //观点类型Id
objViewpointVENT.reason = objViewpointVENS.reason; //理由
objViewpointVENT.source = objViewpointVENS.source; //来源
objViewpointVENT.vpProposePeople = objViewpointVENS.vpProposePeople; //观点提出人
objViewpointVENT.userTypeId = objViewpointVENS.userTypeId; //用户类型Id
objViewpointVENT.citationId = objViewpointVENS.citationId; //引用Id
objViewpointVENT.updDate = objViewpointVENS.updDate; //修改日期
objViewpointVENT.updUser = objViewpointVENS.updUser; //修改人
objViewpointVENT.pdfContent = objViewpointVENS.pdfContent; //Pdf内容
objViewpointVENT.pdfPageNum = objViewpointVENS.pdfPageNum; //Pdf页码
objViewpointVENT.id_CurrEduCls = objViewpointVENS.id_CurrEduCls; //教学班流水号
objViewpointVENT.memo = objViewpointVENS.memo; //备注
objViewpointVENT.sf_UpdFldSetStr = objViewpointVENS.updFldString; //sf_UpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objViewpointVENS:源对象
 * @param objViewpointVENT:目标对象
*/
export function ViewpointV_GetObjFromJsonObj(objViewpointVENS: clsViewpointVEN): clsViewpointVEN 
{
 const objViewpointVENT: clsViewpointVEN = new clsViewpointVEN();
ObjectAssign(objViewpointVENT, objViewpointVENS);
 return objViewpointVENT;
}