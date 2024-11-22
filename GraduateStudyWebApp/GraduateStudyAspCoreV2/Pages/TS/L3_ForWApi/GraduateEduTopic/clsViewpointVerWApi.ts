
 /**
 * 类名:clsViewpointVerWApi
 * 表名:ViewpointVer(01120650)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:48:22
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
 * 观点版本表(ViewpointVer)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2023年03月13日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { enumComparisonOp } from "../../PubFun/enumComparisonOp.js";
import { clsViewpointVerEN } from "../../L0_Entity/GraduateEduTopic/clsViewpointVerEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { tzDataType } from "../../PubFun/clsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const viewpointVer_Controller = "ViewpointVerApi";
 export const viewpointVer_ConstructorName = "viewpointVer";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngViewpointVId:关键字
 * @returns 对象
 **/
export async function ViewpointVer_GetObjByViewpointVIdAsync(lngViewpointVId: number): Promise<clsViewpointVerEN|null>  
{
const strThisFuncName = "GetObjByViewpointVIdAsync";

if (lngViewpointVId == 0)
{
  const strMsg = Format("参数:[lngViewpointVId]不能为空！(In clsViewpointVerWApi.GetObjByViewpointVIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjByViewpointVId";
const strUrl = GetWebApiUrl(viewpointVer_Controller, strAction);
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
return null;
}
//console.log(returnObj);
const objViewpointVer = ViewpointVer_GetObjFromJsonObj(returnObj);
return objViewpointVer;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointVer_ConstructorName, strThisFuncName);
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
export function ViewpointVer_SortFun_Defa(a:clsViewpointVerEN , b:clsViewpointVerEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.viewpointVId-b.viewpointVId;
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
export function ViewpointVer_SortFun_Defa_2Fld(a:clsViewpointVerEN , b:clsViewpointVerEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.viewpointId == b.viewpointId) return a.viewpointName.localeCompare(b.viewpointName);
else return a.viewpointId.localeCompare(b.viewpointId);
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
export function ViewpointVer_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsViewpointVerEN.con_ViewpointVId:
return (a: clsViewpointVerEN, b: clsViewpointVerEN) => {
return a.viewpointVId-b.viewpointVId;
}
case clsViewpointVerEN.con_ViewpointId:
return (a: clsViewpointVerEN, b: clsViewpointVerEN) => {
return a.viewpointId.localeCompare(b.viewpointId);
}
case clsViewpointVerEN.con_ViewpointName:
return (a: clsViewpointVerEN, b: clsViewpointVerEN) => {
if (a.viewpointName == null) return -1;
if (b.viewpointName == null) return 1;
return a.viewpointName.localeCompare(b.viewpointName);
}
case clsViewpointVerEN.con_ViewpointContent:
return (a: clsViewpointVerEN, b: clsViewpointVerEN) => {
if (a.viewpointContent == null) return -1;
if (b.viewpointContent == null) return 1;
return a.viewpointContent.localeCompare(b.viewpointContent);
}
case clsViewpointVerEN.con_ViewpointTypeId:
return (a: clsViewpointVerEN, b: clsViewpointVerEN) => {
if (a.viewpointTypeId == null) return -1;
if (b.viewpointTypeId == null) return 1;
return a.viewpointTypeId.localeCompare(b.viewpointTypeId);
}
case clsViewpointVerEN.con_Reason:
return (a: clsViewpointVerEN, b: clsViewpointVerEN) => {
if (a.reason == null) return -1;
if (b.reason == null) return 1;
return a.reason.localeCompare(b.reason);
}
case clsViewpointVerEN.con_Source:
return (a: clsViewpointVerEN, b: clsViewpointVerEN) => {
if (a.source == null) return -1;
if (b.source == null) return 1;
return a.source.localeCompare(b.source);
}
case clsViewpointVerEN.con_VPProposePeople:
return (a: clsViewpointVerEN, b: clsViewpointVerEN) => {
if (a.vpProposePeople == null) return -1;
if (b.vpProposePeople == null) return 1;
return a.vpProposePeople.localeCompare(b.vpProposePeople);
}
case clsViewpointVerEN.con_UserTypeId:
return (a: clsViewpointVerEN, b: clsViewpointVerEN) => {
if (a.userTypeId == null) return -1;
if (b.userTypeId == null) return 1;
return a.userTypeId.localeCompare(b.userTypeId);
}
case clsViewpointVerEN.con_CitationId:
return (a: clsViewpointVerEN, b: clsViewpointVerEN) => {
if (a.citationId == null) return -1;
if (b.citationId == null) return 1;
return a.citationId.localeCompare(b.citationId);
}
case clsViewpointVerEN.con_UpdDate:
return (a: clsViewpointVerEN, b: clsViewpointVerEN) => {
if (a.updDate == null) return -1;
if (b.updDate == null) return 1;
return a.updDate.localeCompare(b.updDate);
}
case clsViewpointVerEN.con_UpdUser:
return (a: clsViewpointVerEN, b: clsViewpointVerEN) => {
if (a.updUser == null) return -1;
if (b.updUser == null) return 1;
return a.updUser.localeCompare(b.updUser);
}
case clsViewpointVerEN.con_PdfContent:
return (a: clsViewpointVerEN, b: clsViewpointVerEN) => {
if (a.pdfContent == null) return -1;
if (b.pdfContent == null) return 1;
return a.pdfContent.localeCompare(b.pdfContent);
}
case clsViewpointVerEN.con_PdfPageNum:
return (a: clsViewpointVerEN, b: clsViewpointVerEN) => {
return a.pdfPageNum-b.pdfPageNum;
}
case clsViewpointVerEN.con_id_CurrEduCls:
return (a: clsViewpointVerEN, b: clsViewpointVerEN) => {
if (a.id_CurrEduCls == null) return -1;
if (b.id_CurrEduCls == null) return 1;
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
case clsViewpointVerEN.con_Memo:
return (a: clsViewpointVerEN, b: clsViewpointVerEN) => {
if (a.memo == null) return -1;
if (b.memo == null) return 1;
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[ViewpointVer]中不存在！(in ${ viewpointVer_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsViewpointVerEN.con_ViewpointVId:
return (a: clsViewpointVerEN, b: clsViewpointVerEN) => {
return b.viewpointVId-a.viewpointVId;
}
case clsViewpointVerEN.con_ViewpointId:
return (a: clsViewpointVerEN, b: clsViewpointVerEN) => {
return b.viewpointId.localeCompare(a.viewpointId);
}
case clsViewpointVerEN.con_ViewpointName:
return (a: clsViewpointVerEN, b: clsViewpointVerEN) => {
if (b.viewpointName == null) return -1;
if (a.viewpointName == null) return 1;
return b.viewpointName.localeCompare(a.viewpointName);
}
case clsViewpointVerEN.con_ViewpointContent:
return (a: clsViewpointVerEN, b: clsViewpointVerEN) => {
if (b.viewpointContent == null) return -1;
if (a.viewpointContent == null) return 1;
return b.viewpointContent.localeCompare(a.viewpointContent);
}
case clsViewpointVerEN.con_ViewpointTypeId:
return (a: clsViewpointVerEN, b: clsViewpointVerEN) => {
if (b.viewpointTypeId == null) return -1;
if (a.viewpointTypeId == null) return 1;
return b.viewpointTypeId.localeCompare(a.viewpointTypeId);
}
case clsViewpointVerEN.con_Reason:
return (a: clsViewpointVerEN, b: clsViewpointVerEN) => {
if (b.reason == null) return -1;
if (a.reason == null) return 1;
return b.reason.localeCompare(a.reason);
}
case clsViewpointVerEN.con_Source:
return (a: clsViewpointVerEN, b: clsViewpointVerEN) => {
if (b.source == null) return -1;
if (a.source == null) return 1;
return b.source.localeCompare(a.source);
}
case clsViewpointVerEN.con_VPProposePeople:
return (a: clsViewpointVerEN, b: clsViewpointVerEN) => {
if (b.vpProposePeople == null) return -1;
if (a.vpProposePeople == null) return 1;
return b.vpProposePeople.localeCompare(a.vpProposePeople);
}
case clsViewpointVerEN.con_UserTypeId:
return (a: clsViewpointVerEN, b: clsViewpointVerEN) => {
if (b.userTypeId == null) return -1;
if (a.userTypeId == null) return 1;
return b.userTypeId.localeCompare(a.userTypeId);
}
case clsViewpointVerEN.con_CitationId:
return (a: clsViewpointVerEN, b: clsViewpointVerEN) => {
if (b.citationId == null) return -1;
if (a.citationId == null) return 1;
return b.citationId.localeCompare(a.citationId);
}
case clsViewpointVerEN.con_UpdDate:
return (a: clsViewpointVerEN, b: clsViewpointVerEN) => {
if (b.updDate == null) return -1;
if (a.updDate == null) return 1;
return b.updDate.localeCompare(a.updDate);
}
case clsViewpointVerEN.con_UpdUser:
return (a: clsViewpointVerEN, b: clsViewpointVerEN) => {
if (b.updUser == null) return -1;
if (a.updUser == null) return 1;
return b.updUser.localeCompare(a.updUser);
}
case clsViewpointVerEN.con_PdfContent:
return (a: clsViewpointVerEN, b: clsViewpointVerEN) => {
if (b.pdfContent == null) return -1;
if (a.pdfContent == null) return 1;
return b.pdfContent.localeCompare(a.pdfContent);
}
case clsViewpointVerEN.con_PdfPageNum:
return (a: clsViewpointVerEN, b: clsViewpointVerEN) => {
return b.pdfPageNum-a.pdfPageNum;
}
case clsViewpointVerEN.con_id_CurrEduCls:
return (a: clsViewpointVerEN, b: clsViewpointVerEN) => {
if (b.id_CurrEduCls == null) return -1;
if (a.id_CurrEduCls == null) return 1;
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
case clsViewpointVerEN.con_Memo:
return (a: clsViewpointVerEN, b: clsViewpointVerEN) => {
if (b.memo == null) return -1;
if (a.memo == null) return 1;
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[ViewpointVer]中不存在！(in ${ viewpointVer_ConstructorName}.${ strThisFuncName})`;
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
export async function ViewpointVer_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsViewpointVerEN.con_ViewpointVId:
return (obj: clsViewpointVerEN) => {
return obj.viewpointVId === value;
}
case clsViewpointVerEN.con_ViewpointId:
return (obj: clsViewpointVerEN) => {
return obj.viewpointId === value;
}
case clsViewpointVerEN.con_ViewpointName:
return (obj: clsViewpointVerEN) => {
return obj.viewpointName === value;
}
case clsViewpointVerEN.con_ViewpointContent:
return (obj: clsViewpointVerEN) => {
return obj.viewpointContent === value;
}
case clsViewpointVerEN.con_ViewpointTypeId:
return (obj: clsViewpointVerEN) => {
return obj.viewpointTypeId === value;
}
case clsViewpointVerEN.con_Reason:
return (obj: clsViewpointVerEN) => {
return obj.reason === value;
}
case clsViewpointVerEN.con_Source:
return (obj: clsViewpointVerEN) => {
return obj.source === value;
}
case clsViewpointVerEN.con_VPProposePeople:
return (obj: clsViewpointVerEN) => {
return obj.vpProposePeople === value;
}
case clsViewpointVerEN.con_UserTypeId:
return (obj: clsViewpointVerEN) => {
return obj.userTypeId === value;
}
case clsViewpointVerEN.con_CitationId:
return (obj: clsViewpointVerEN) => {
return obj.citationId === value;
}
case clsViewpointVerEN.con_UpdDate:
return (obj: clsViewpointVerEN) => {
return obj.updDate === value;
}
case clsViewpointVerEN.con_UpdUser:
return (obj: clsViewpointVerEN) => {
return obj.updUser === value;
}
case clsViewpointVerEN.con_PdfContent:
return (obj: clsViewpointVerEN) => {
return obj.pdfContent === value;
}
case clsViewpointVerEN.con_PdfPageNum:
return (obj: clsViewpointVerEN) => {
return obj.pdfPageNum === value;
}
case clsViewpointVerEN.con_id_CurrEduCls:
return (obj: clsViewpointVerEN) => {
return obj.id_CurrEduCls === value;
}
case clsViewpointVerEN.con_Memo:
return (obj: clsViewpointVerEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[ViewpointVer]中不存在！(in ${ viewpointVer_ConstructorName}.${ strThisFuncName})`;
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
export async function ViewpointVer_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(viewpointVer_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointVer_ConstructorName, strThisFuncName);
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
export async function ViewpointVer_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(viewpointVer_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointVer_ConstructorName, strThisFuncName);
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
export async function ViewpointVer_GetFirstObjAsync(strWhereCond: string): Promise<clsViewpointVerEN|null>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(viewpointVer_Controller, strAction);
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
const objViewpointVer = ViewpointVer_GetObjFromJsonObj(returnObj);
return objViewpointVer;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointVer_ConstructorName, strThisFuncName);
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
export async function ViewpointVer_GetObjLstAsync(strWhereCond: string): Promise<Array<clsViewpointVerEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(viewpointVer_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", viewpointVer_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = ViewpointVer_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointVer_ConstructorName, strThisFuncName);
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
export async function ViewpointVer_GetObjLstByViewpointVIdLstAsync(arrViewpointVId: Array<string>): Promise<Array<clsViewpointVerEN>>  
{
const strThisFuncName = "GetObjLstByViewpointVIdLstAsync";
const strAction = "GetObjLstByViewpointVIdLst";
const strUrl = GetWebApiUrl(viewpointVer_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrViewpointVId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", viewpointVer_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = ViewpointVer_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointVer_ConstructorName, strThisFuncName);
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
export async function ViewpointVer_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsViewpointVerEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(viewpointVer_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", viewpointVer_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = ViewpointVer_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointVer_ConstructorName, strThisFuncName);
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
export async function ViewpointVer_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsViewpointVerEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(viewpointVer_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", viewpointVer_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = ViewpointVer_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointVer_ConstructorName, strThisFuncName);
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
export async function ViewpointVer_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(viewpointVer_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointVer_ConstructorName, strThisFuncName);
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
export async function ViewpointVer_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsViewpointVerEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
if (objPagerPara.pageIndex == 0) return new Array<clsViewpointVerEN>();
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(viewpointVer_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", viewpointVer_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = ViewpointVer_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointVer_ConstructorName, strThisFuncName);
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
export async function ViewpointVer_DelRecordAsync(lngViewpointVId: number): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(viewpointVer_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, lngViewpointVId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointVer_ConstructorName, strThisFuncName);
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
export async function ViewpointVer_DelViewpointVersAsync(arrViewpointVId: Array<string>): Promise<number> 
{
const strThisFuncName = "DelViewpointVersAsync";
const strAction = "DelViewpointVers";
const strUrl = GetWebApiUrl(viewpointVer_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointVer_ConstructorName, strThisFuncName);
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
export async function ViewpointVer_DelViewpointVersByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "DelViewpointVersByCondAsync";
const strAction = "DelViewpointVersByCond";
const strUrl = GetWebApiUrl(viewpointVer_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointVer_ConstructorName, strThisFuncName);
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
 * @param objViewpointVerEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function ViewpointVer_AddNewRecordAsync(objViewpointVerEN: clsViewpointVerEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objViewpointVerEN);
const strUrl = GetWebApiUrl(viewpointVer_Controller, strAction);
try
{
const response = await axios.post(strUrl, objViewpointVerEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointVer_ConstructorName, strThisFuncName);
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
 * @param objViewpointVerEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function ViewpointVer_AddNewRecordWithReturnKeyAsync(objViewpointVerEN: clsViewpointVerEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(viewpointVer_Controller, strAction);
try
{
const response = await axios.post(strUrl, objViewpointVerEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointVer_ConstructorName, strThisFuncName);
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
 * @param objViewpointVerEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function ViewpointVer_AddNewRecordWithReturnKey(objViewpointVerEN: clsViewpointVerEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objViewpointVerEN.viewpointVId === null || objViewpointVerEN.viewpointVId === 0)
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(viewpointVer_Controller, strAction);
try
{
const response = await axios.post(strUrl, objViewpointVerEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointVer_ConstructorName, strThisFuncName);
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
 * @param objViewpointVerEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function ViewpointVer_UpdateRecordAsync(objViewpointVerEN: clsViewpointVerEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objViewpointVerEN.sfUpdFldSetStr === undefined || objViewpointVerEN.sfUpdFldSetStr === null || objViewpointVerEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objViewpointVerEN.viewpointVId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(viewpointVer_Controller, strAction);
try
{
const response = await axios.post(strUrl, objViewpointVerEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointVer_ConstructorName, strThisFuncName);
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
 * @param objViewpointVerEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function ViewpointVer_UpdateWithConditionAsync(objViewpointVerEN: clsViewpointVerEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objViewpointVerEN.sfUpdFldSetStr === undefined || objViewpointVerEN.sfUpdFldSetStr === null || objViewpointVerEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objViewpointVerEN.viewpointVId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(viewpointVer_Controller, strAction);
objViewpointVerEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objViewpointVerEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointVer_ConstructorName, strThisFuncName);
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
export async function ViewpointVer_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(viewpointVer_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointVer_ConstructorName, strThisFuncName);
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
export async function ViewpointVer_IsExist(lngViewpointVId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(viewpointVer_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointVer_ConstructorName, strThisFuncName);
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
export async function ViewpointVer_IsExistAsync(lngViewpointVId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(viewpointVer_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointVer_ConstructorName, strThisFuncName);
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
export async function ViewpointVer_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(viewpointVer_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointVer_ConstructorName, strThisFuncName);
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
export async function ViewpointVer_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(viewpointVer_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointVer_ConstructorName, strThisFuncName);
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
export function ViewpointVer_GetWebApiUrl(strController: string, strAction: string): string {
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
export function ViewpointVer_CheckPropertyNew(pobjViewpointVerEN: clsViewpointVerEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjViewpointVerEN.viewpointId) === true )
{
 throw new Error("(errid:Watl000058)字段[观点Id]不能为空(In 观点版本表)!(clsViewpointVerBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjViewpointVerEN.viewpointId) == false && GetStrLen(pobjViewpointVerEN.viewpointId) > 8)
{
 throw new Error("(errid:Watl000059)字段[观点Id(viewpointId)]的长度不能超过8(In 观点版本表(ViewpointVer))!值:$(pobjViewpointVerEN.viewpointId)(clsViewpointVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjViewpointVerEN.viewpointName) == false && GetStrLen(pobjViewpointVerEN.viewpointName) > 500)
{
 throw new Error("(errid:Watl000059)字段[观点名称(viewpointName)]的长度不能超过500(In 观点版本表(ViewpointVer))!值:$(pobjViewpointVerEN.viewpointName)(clsViewpointVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjViewpointVerEN.viewpointTypeId) == false && GetStrLen(pobjViewpointVerEN.viewpointTypeId) > 4)
{
 throw new Error("(errid:Watl000059)字段[观点类型Id(viewpointTypeId)]的长度不能超过4(In 观点版本表(ViewpointVer))!值:$(pobjViewpointVerEN.viewpointTypeId)(clsViewpointVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjViewpointVerEN.source) == false && GetStrLen(pobjViewpointVerEN.source) > 500)
{
 throw new Error("(errid:Watl000059)字段[来源(source)]的长度不能超过500(In 观点版本表(ViewpointVer))!值:$(pobjViewpointVerEN.source)(clsViewpointVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjViewpointVerEN.vpProposePeople) == false && GetStrLen(pobjViewpointVerEN.vpProposePeople) > 50)
{
 throw new Error("(errid:Watl000059)字段[观点提出人(vpProposePeople)]的长度不能超过50(In 观点版本表(ViewpointVer))!值:$(pobjViewpointVerEN.vpProposePeople)(clsViewpointVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjViewpointVerEN.userTypeId) == false && GetStrLen(pobjViewpointVerEN.userTypeId) > 2)
{
 throw new Error("(errid:Watl000059)字段[用户类型Id(userTypeId)]的长度不能超过2(In 观点版本表(ViewpointVer))!值:$(pobjViewpointVerEN.userTypeId)(clsViewpointVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjViewpointVerEN.citationId) == false && GetStrLen(pobjViewpointVerEN.citationId) > 8)
{
 throw new Error("(errid:Watl000059)字段[引用Id(citationId)]的长度不能超过8(In 观点版本表(ViewpointVer))!值:$(pobjViewpointVerEN.citationId)(clsViewpointVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjViewpointVerEN.updDate) == false && GetStrLen(pobjViewpointVerEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 观点版本表(ViewpointVer))!值:$(pobjViewpointVerEN.updDate)(clsViewpointVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjViewpointVerEN.updUser) == false && GetStrLen(pobjViewpointVerEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 观点版本表(ViewpointVer))!值:$(pobjViewpointVerEN.updUser)(clsViewpointVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjViewpointVerEN.pdfContent) == false && GetStrLen(pobjViewpointVerEN.pdfContent) > 2000)
{
 throw new Error("(errid:Watl000059)字段[Pdf内容(pdfContent)]的长度不能超过2000(In 观点版本表(ViewpointVer))!值:$(pobjViewpointVerEN.pdfContent)(clsViewpointVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjViewpointVerEN.id_CurrEduCls) == false && GetStrLen(pobjViewpointVerEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 观点版本表(ViewpointVer))!值:$(pobjViewpointVerEN.id_CurrEduCls)(clsViewpointVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjViewpointVerEN.memo) == false && GetStrLen(pobjViewpointVerEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 观点版本表(ViewpointVer))!值:$(pobjViewpointVerEN.memo)(clsViewpointVerBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null != pobjViewpointVerEN.viewpointVId && undefined !== pobjViewpointVerEN.viewpointVId && tzDataType.isNumber(pobjViewpointVerEN.viewpointVId) === false)
{
 throw new Error("(errid:Watl000060)字段[ViewpointVId(viewpointVId)]的值:[$(pobjViewpointVerEN.viewpointVId)], 非法，应该为数值型(In 观点版本表(ViewpointVer))!(clsViewpointVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjViewpointVerEN.viewpointId) == false && undefined !== pobjViewpointVerEN.viewpointId && tzDataType.isString(pobjViewpointVerEN.viewpointId) === false)
{
 throw new Error("(errid:Watl000060)字段[观点Id(viewpointId)]的值:[$(pobjViewpointVerEN.viewpointId)], 非法，应该为字符型(In 观点版本表(ViewpointVer))!(clsViewpointVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjViewpointVerEN.viewpointName) == false && undefined !== pobjViewpointVerEN.viewpointName && tzDataType.isString(pobjViewpointVerEN.viewpointName) === false)
{
 throw new Error("(errid:Watl000060)字段[观点名称(viewpointName)]的值:[$(pobjViewpointVerEN.viewpointName)], 非法，应该为字符型(In 观点版本表(ViewpointVer))!(clsViewpointVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjViewpointVerEN.viewpointContent) == false && undefined !== pobjViewpointVerEN.viewpointContent && tzDataType.isString(pobjViewpointVerEN.viewpointContent) === false)
{
 throw new Error("(errid:Watl000060)字段[观点内容(viewpointContent)]的值:[$(pobjViewpointVerEN.viewpointContent)], 非法，应该为字符型(In 观点版本表(ViewpointVer))!(clsViewpointVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjViewpointVerEN.viewpointTypeId) == false && undefined !== pobjViewpointVerEN.viewpointTypeId && tzDataType.isString(pobjViewpointVerEN.viewpointTypeId) === false)
{
 throw new Error("(errid:Watl000060)字段[观点类型Id(viewpointTypeId)]的值:[$(pobjViewpointVerEN.viewpointTypeId)], 非法，应该为字符型(In 观点版本表(ViewpointVer))!(clsViewpointVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjViewpointVerEN.reason) == false && undefined !== pobjViewpointVerEN.reason && tzDataType.isString(pobjViewpointVerEN.reason) === false)
{
 throw new Error("(errid:Watl000060)字段[理由(reason)]的值:[$(pobjViewpointVerEN.reason)], 非法，应该为字符型(In 观点版本表(ViewpointVer))!(clsViewpointVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjViewpointVerEN.source) == false && undefined !== pobjViewpointVerEN.source && tzDataType.isString(pobjViewpointVerEN.source) === false)
{
 throw new Error("(errid:Watl000060)字段[来源(source)]的值:[$(pobjViewpointVerEN.source)], 非法，应该为字符型(In 观点版本表(ViewpointVer))!(clsViewpointVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjViewpointVerEN.vpProposePeople) == false && undefined !== pobjViewpointVerEN.vpProposePeople && tzDataType.isString(pobjViewpointVerEN.vpProposePeople) === false)
{
 throw new Error("(errid:Watl000060)字段[观点提出人(vpProposePeople)]的值:[$(pobjViewpointVerEN.vpProposePeople)], 非法，应该为字符型(In 观点版本表(ViewpointVer))!(clsViewpointVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjViewpointVerEN.userTypeId) == false && undefined !== pobjViewpointVerEN.userTypeId && tzDataType.isString(pobjViewpointVerEN.userTypeId) === false)
{
 throw new Error("(errid:Watl000060)字段[用户类型Id(userTypeId)]的值:[$(pobjViewpointVerEN.userTypeId)], 非法，应该为字符型(In 观点版本表(ViewpointVer))!(clsViewpointVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjViewpointVerEN.citationId) == false && undefined !== pobjViewpointVerEN.citationId && tzDataType.isString(pobjViewpointVerEN.citationId) === false)
{
 throw new Error("(errid:Watl000060)字段[引用Id(citationId)]的值:[$(pobjViewpointVerEN.citationId)], 非法，应该为字符型(In 观点版本表(ViewpointVer))!(clsViewpointVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjViewpointVerEN.updDate) == false && undefined !== pobjViewpointVerEN.updDate && tzDataType.isString(pobjViewpointVerEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjViewpointVerEN.updDate)], 非法，应该为字符型(In 观点版本表(ViewpointVer))!(clsViewpointVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjViewpointVerEN.updUser) == false && undefined !== pobjViewpointVerEN.updUser && tzDataType.isString(pobjViewpointVerEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjViewpointVerEN.updUser)], 非法，应该为字符型(In 观点版本表(ViewpointVer))!(clsViewpointVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjViewpointVerEN.pdfContent) == false && undefined !== pobjViewpointVerEN.pdfContent && tzDataType.isString(pobjViewpointVerEN.pdfContent) === false)
{
 throw new Error("(errid:Watl000060)字段[Pdf内容(pdfContent)]的值:[$(pobjViewpointVerEN.pdfContent)], 非法，应该为字符型(In 观点版本表(ViewpointVer))!(clsViewpointVerBL:CheckPropertyNew)");
}
if (null != pobjViewpointVerEN.pdfPageNum && undefined !== pobjViewpointVerEN.pdfPageNum && tzDataType.isNumber(pobjViewpointVerEN.pdfPageNum) === false)
{
 throw new Error("(errid:Watl000060)字段[Pdf页码(pdfPageNum)]的值:[$(pobjViewpointVerEN.pdfPageNum)], 非法，应该为数值型(In 观点版本表(ViewpointVer))!(clsViewpointVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjViewpointVerEN.id_CurrEduCls) == false && undefined !== pobjViewpointVerEN.id_CurrEduCls && tzDataType.isString(pobjViewpointVerEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjViewpointVerEN.id_CurrEduCls)], 非法，应该为字符型(In 观点版本表(ViewpointVer))!(clsViewpointVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjViewpointVerEN.memo) == false && undefined !== pobjViewpointVerEN.memo && tzDataType.isString(pobjViewpointVerEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjViewpointVerEN.memo)], 非法，应该为字符型(In 观点版本表(ViewpointVer))!(clsViewpointVerBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjViewpointVerEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function ViewpointVer_CheckProperty4Update (pobjViewpointVerEN: clsViewpointVerEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjViewpointVerEN.viewpointId) == false && GetStrLen(pobjViewpointVerEN.viewpointId) > 8)
{
 throw new Error("(errid:Watl000062)字段[观点Id(viewpointId)]的长度不能超过8(In 观点版本表(ViewpointVer))!值:$(pobjViewpointVerEN.viewpointId)(clsViewpointVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjViewpointVerEN.viewpointName) == false && GetStrLen(pobjViewpointVerEN.viewpointName) > 500)
{
 throw new Error("(errid:Watl000062)字段[观点名称(viewpointName)]的长度不能超过500(In 观点版本表(ViewpointVer))!值:$(pobjViewpointVerEN.viewpointName)(clsViewpointVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjViewpointVerEN.viewpointTypeId) == false && GetStrLen(pobjViewpointVerEN.viewpointTypeId) > 4)
{
 throw new Error("(errid:Watl000062)字段[观点类型Id(viewpointTypeId)]的长度不能超过4(In 观点版本表(ViewpointVer))!值:$(pobjViewpointVerEN.viewpointTypeId)(clsViewpointVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjViewpointVerEN.source) == false && GetStrLen(pobjViewpointVerEN.source) > 500)
{
 throw new Error("(errid:Watl000062)字段[来源(source)]的长度不能超过500(In 观点版本表(ViewpointVer))!值:$(pobjViewpointVerEN.source)(clsViewpointVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjViewpointVerEN.vpProposePeople) == false && GetStrLen(pobjViewpointVerEN.vpProposePeople) > 50)
{
 throw new Error("(errid:Watl000062)字段[观点提出人(vpProposePeople)]的长度不能超过50(In 观点版本表(ViewpointVer))!值:$(pobjViewpointVerEN.vpProposePeople)(clsViewpointVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjViewpointVerEN.userTypeId) == false && GetStrLen(pobjViewpointVerEN.userTypeId) > 2)
{
 throw new Error("(errid:Watl000062)字段[用户类型Id(userTypeId)]的长度不能超过2(In 观点版本表(ViewpointVer))!值:$(pobjViewpointVerEN.userTypeId)(clsViewpointVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjViewpointVerEN.citationId) == false && GetStrLen(pobjViewpointVerEN.citationId) > 8)
{
 throw new Error("(errid:Watl000062)字段[引用Id(citationId)]的长度不能超过8(In 观点版本表(ViewpointVer))!值:$(pobjViewpointVerEN.citationId)(clsViewpointVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjViewpointVerEN.updDate) == false && GetStrLen(pobjViewpointVerEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 观点版本表(ViewpointVer))!值:$(pobjViewpointVerEN.updDate)(clsViewpointVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjViewpointVerEN.updUser) == false && GetStrLen(pobjViewpointVerEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 观点版本表(ViewpointVer))!值:$(pobjViewpointVerEN.updUser)(clsViewpointVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjViewpointVerEN.pdfContent) == false && GetStrLen(pobjViewpointVerEN.pdfContent) > 2000)
{
 throw new Error("(errid:Watl000062)字段[Pdf内容(pdfContent)]的长度不能超过2000(In 观点版本表(ViewpointVer))!值:$(pobjViewpointVerEN.pdfContent)(clsViewpointVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjViewpointVerEN.id_CurrEduCls) == false && GetStrLen(pobjViewpointVerEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 观点版本表(ViewpointVer))!值:$(pobjViewpointVerEN.id_CurrEduCls)(clsViewpointVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjViewpointVerEN.memo) == false && GetStrLen(pobjViewpointVerEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 观点版本表(ViewpointVer))!值:$(pobjViewpointVerEN.memo)(clsViewpointVerBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null != pobjViewpointVerEN.viewpointVId && undefined !== pobjViewpointVerEN.viewpointVId && tzDataType.isNumber(pobjViewpointVerEN.viewpointVId) === false)
{
 throw new Error("(errid:Watl000063)字段[ViewpointVId(viewpointVId)]的值:[$(pobjViewpointVerEN.viewpointVId)], 非法，应该为数值型(In 观点版本表(ViewpointVer))!(clsViewpointVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjViewpointVerEN.viewpointId) == false && undefined !== pobjViewpointVerEN.viewpointId && tzDataType.isString(pobjViewpointVerEN.viewpointId) === false)
{
 throw new Error("(errid:Watl000063)字段[观点Id(viewpointId)]的值:[$(pobjViewpointVerEN.viewpointId)], 非法，应该为字符型(In 观点版本表(ViewpointVer))!(clsViewpointVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjViewpointVerEN.viewpointName) == false && undefined !== pobjViewpointVerEN.viewpointName && tzDataType.isString(pobjViewpointVerEN.viewpointName) === false)
{
 throw new Error("(errid:Watl000063)字段[观点名称(viewpointName)]的值:[$(pobjViewpointVerEN.viewpointName)], 非法，应该为字符型(In 观点版本表(ViewpointVer))!(clsViewpointVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjViewpointVerEN.viewpointContent) == false && undefined !== pobjViewpointVerEN.viewpointContent && tzDataType.isString(pobjViewpointVerEN.viewpointContent) === false)
{
 throw new Error("(errid:Watl000063)字段[观点内容(viewpointContent)]的值:[$(pobjViewpointVerEN.viewpointContent)], 非法，应该为字符型(In 观点版本表(ViewpointVer))!(clsViewpointVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjViewpointVerEN.viewpointTypeId) == false && undefined !== pobjViewpointVerEN.viewpointTypeId && tzDataType.isString(pobjViewpointVerEN.viewpointTypeId) === false)
{
 throw new Error("(errid:Watl000063)字段[观点类型Id(viewpointTypeId)]的值:[$(pobjViewpointVerEN.viewpointTypeId)], 非法，应该为字符型(In 观点版本表(ViewpointVer))!(clsViewpointVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjViewpointVerEN.reason) == false && undefined !== pobjViewpointVerEN.reason && tzDataType.isString(pobjViewpointVerEN.reason) === false)
{
 throw new Error("(errid:Watl000063)字段[理由(reason)]的值:[$(pobjViewpointVerEN.reason)], 非法，应该为字符型(In 观点版本表(ViewpointVer))!(clsViewpointVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjViewpointVerEN.source) == false && undefined !== pobjViewpointVerEN.source && tzDataType.isString(pobjViewpointVerEN.source) === false)
{
 throw new Error("(errid:Watl000063)字段[来源(source)]的值:[$(pobjViewpointVerEN.source)], 非法，应该为字符型(In 观点版本表(ViewpointVer))!(clsViewpointVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjViewpointVerEN.vpProposePeople) == false && undefined !== pobjViewpointVerEN.vpProposePeople && tzDataType.isString(pobjViewpointVerEN.vpProposePeople) === false)
{
 throw new Error("(errid:Watl000063)字段[观点提出人(vpProposePeople)]的值:[$(pobjViewpointVerEN.vpProposePeople)], 非法，应该为字符型(In 观点版本表(ViewpointVer))!(clsViewpointVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjViewpointVerEN.userTypeId) == false && undefined !== pobjViewpointVerEN.userTypeId && tzDataType.isString(pobjViewpointVerEN.userTypeId) === false)
{
 throw new Error("(errid:Watl000063)字段[用户类型Id(userTypeId)]的值:[$(pobjViewpointVerEN.userTypeId)], 非法，应该为字符型(In 观点版本表(ViewpointVer))!(clsViewpointVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjViewpointVerEN.citationId) == false && undefined !== pobjViewpointVerEN.citationId && tzDataType.isString(pobjViewpointVerEN.citationId) === false)
{
 throw new Error("(errid:Watl000063)字段[引用Id(citationId)]的值:[$(pobjViewpointVerEN.citationId)], 非法，应该为字符型(In 观点版本表(ViewpointVer))!(clsViewpointVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjViewpointVerEN.updDate) == false && undefined !== pobjViewpointVerEN.updDate && tzDataType.isString(pobjViewpointVerEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjViewpointVerEN.updDate)], 非法，应该为字符型(In 观点版本表(ViewpointVer))!(clsViewpointVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjViewpointVerEN.updUser) == false && undefined !== pobjViewpointVerEN.updUser && tzDataType.isString(pobjViewpointVerEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjViewpointVerEN.updUser)], 非法，应该为字符型(In 观点版本表(ViewpointVer))!(clsViewpointVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjViewpointVerEN.pdfContent) == false && undefined !== pobjViewpointVerEN.pdfContent && tzDataType.isString(pobjViewpointVerEN.pdfContent) === false)
{
 throw new Error("(errid:Watl000063)字段[Pdf内容(pdfContent)]的值:[$(pobjViewpointVerEN.pdfContent)], 非法，应该为字符型(In 观点版本表(ViewpointVer))!(clsViewpointVerBL:CheckProperty4Update)");
}
if (null != pobjViewpointVerEN.pdfPageNum && undefined !== pobjViewpointVerEN.pdfPageNum && tzDataType.isNumber(pobjViewpointVerEN.pdfPageNum) === false)
{
 throw new Error("(errid:Watl000063)字段[Pdf页码(pdfPageNum)]的值:[$(pobjViewpointVerEN.pdfPageNum)], 非法，应该为数值型(In 观点版本表(ViewpointVer))!(clsViewpointVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjViewpointVerEN.id_CurrEduCls) == false && undefined !== pobjViewpointVerEN.id_CurrEduCls && tzDataType.isString(pobjViewpointVerEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjViewpointVerEN.id_CurrEduCls)], 非法，应该为字符型(In 观点版本表(ViewpointVer))!(clsViewpointVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjViewpointVerEN.memo) == false && undefined !== pobjViewpointVerEN.memo && tzDataType.isString(pobjViewpointVerEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjViewpointVerEN.memo)], 非法，应该为字符型(In 观点版本表(ViewpointVer))!(clsViewpointVerBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjViewpointVerEN.viewpointVId 
 || pobjViewpointVerEN.viewpointVId != null && pobjViewpointVerEN.viewpointVId.toString()  ===  "")
{
 throw new Error("(errid:Watl000064)字段[ViewpointVId]不能为空(In 观点版本表)!(clsViewpointVerBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjViewpointVerEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function ViewpointVer_GetJSONStrByObj (pobjViewpointVerEN: clsViewpointVerEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjViewpointVerEN.sfUpdFldSetStr = pobjViewpointVerEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjViewpointVerEN);
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
export function ViewpointVer_GetObjLstByJSONStr (strJSON: string): Array<clsViewpointVerEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrViewpointVerObjLst = new Array<clsViewpointVerEN>();
if (strJSON === "")
{
return arrViewpointVerObjLst;
}
try
{
arrViewpointVerObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrViewpointVerObjLst;
}
return arrViewpointVerObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrViewpointVerObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function ViewpointVer_GetObjLstByJSONObjLst (arrViewpointVerObjLstS: Array<clsViewpointVerEN>): Array<clsViewpointVerEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrViewpointVerObjLst = new Array<clsViewpointVerEN>();
for (const objInFor of arrViewpointVerObjLstS) {
const obj1 = ViewpointVer_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrViewpointVerObjLst.push(obj1);
}
return arrViewpointVerObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function ViewpointVer_GetObjByJSONStr (strJSON: string): clsViewpointVerEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjViewpointVerEN = new clsViewpointVerEN();
if (strJSON === "")
{
return pobjViewpointVerEN;
}
try
{
pobjViewpointVerEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjViewpointVerEN;
}
return pobjViewpointVerEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function ViewpointVer_GetCombineCondition(objViewpointVer_Cond: clsViewpointVerEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objViewpointVer_Cond.dicFldComparisonOp, clsViewpointVerEN.con_ViewpointVId) == true)
{
const strComparisonOp_ViewpointVId:string = objViewpointVer_Cond.dicFldComparisonOp[clsViewpointVerEN.con_ViewpointVId];
strWhereCond += Format(" And {0} {2} {1}", clsViewpointVerEN.con_ViewpointVId, objViewpointVer_Cond.viewpointVId, strComparisonOp_ViewpointVId);
}
if (Object.prototype.hasOwnProperty.call(objViewpointVer_Cond.dicFldComparisonOp, clsViewpointVerEN.con_ViewpointId) == true)
{
const strComparisonOp_ViewpointId:string = objViewpointVer_Cond.dicFldComparisonOp[clsViewpointVerEN.con_ViewpointId];
strWhereCond += Format(" And {0} {2} '{1}'", clsViewpointVerEN.con_ViewpointId, objViewpointVer_Cond.viewpointId, strComparisonOp_ViewpointId);
}
if (Object.prototype.hasOwnProperty.call(objViewpointVer_Cond.dicFldComparisonOp, clsViewpointVerEN.con_ViewpointName) == true)
{
const strComparisonOp_ViewpointName:string = objViewpointVer_Cond.dicFldComparisonOp[clsViewpointVerEN.con_ViewpointName];
strWhereCond += Format(" And {0} {2} '{1}'", clsViewpointVerEN.con_ViewpointName, objViewpointVer_Cond.viewpointName, strComparisonOp_ViewpointName);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objViewpointVer_Cond.dicFldComparisonOp, clsViewpointVerEN.con_ViewpointTypeId) == true)
{
const strComparisonOp_ViewpointTypeId:string = objViewpointVer_Cond.dicFldComparisonOp[clsViewpointVerEN.con_ViewpointTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsViewpointVerEN.con_ViewpointTypeId, objViewpointVer_Cond.viewpointTypeId, strComparisonOp_ViewpointTypeId);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objViewpointVer_Cond.dicFldComparisonOp, clsViewpointVerEN.con_Source) == true)
{
const strComparisonOp_Source:string = objViewpointVer_Cond.dicFldComparisonOp[clsViewpointVerEN.con_Source];
strWhereCond += Format(" And {0} {2} '{1}'", clsViewpointVerEN.con_Source, objViewpointVer_Cond.source, strComparisonOp_Source);
}
if (Object.prototype.hasOwnProperty.call(objViewpointVer_Cond.dicFldComparisonOp, clsViewpointVerEN.con_VPProposePeople) == true)
{
const strComparisonOp_VPProposePeople:string = objViewpointVer_Cond.dicFldComparisonOp[clsViewpointVerEN.con_VPProposePeople];
strWhereCond += Format(" And {0} {2} '{1}'", clsViewpointVerEN.con_VPProposePeople, objViewpointVer_Cond.vpProposePeople, strComparisonOp_VPProposePeople);
}
if (Object.prototype.hasOwnProperty.call(objViewpointVer_Cond.dicFldComparisonOp, clsViewpointVerEN.con_UserTypeId) == true)
{
const strComparisonOp_UserTypeId:string = objViewpointVer_Cond.dicFldComparisonOp[clsViewpointVerEN.con_UserTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsViewpointVerEN.con_UserTypeId, objViewpointVer_Cond.userTypeId, strComparisonOp_UserTypeId);
}
if (Object.prototype.hasOwnProperty.call(objViewpointVer_Cond.dicFldComparisonOp, clsViewpointVerEN.con_CitationId) == true)
{
const strComparisonOp_CitationId:string = objViewpointVer_Cond.dicFldComparisonOp[clsViewpointVerEN.con_CitationId];
strWhereCond += Format(" And {0} {2} '{1}'", clsViewpointVerEN.con_CitationId, objViewpointVer_Cond.citationId, strComparisonOp_CitationId);
}
if (Object.prototype.hasOwnProperty.call(objViewpointVer_Cond.dicFldComparisonOp, clsViewpointVerEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objViewpointVer_Cond.dicFldComparisonOp[clsViewpointVerEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsViewpointVerEN.con_UpdDate, objViewpointVer_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objViewpointVer_Cond.dicFldComparisonOp, clsViewpointVerEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objViewpointVer_Cond.dicFldComparisonOp[clsViewpointVerEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsViewpointVerEN.con_UpdUser, objViewpointVer_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objViewpointVer_Cond.dicFldComparisonOp, clsViewpointVerEN.con_PdfContent) == true)
{
const strComparisonOp_PdfContent:string = objViewpointVer_Cond.dicFldComparisonOp[clsViewpointVerEN.con_PdfContent];
strWhereCond += Format(" And {0} {2} '{1}'", clsViewpointVerEN.con_PdfContent, objViewpointVer_Cond.pdfContent, strComparisonOp_PdfContent);
}
if (Object.prototype.hasOwnProperty.call(objViewpointVer_Cond.dicFldComparisonOp, clsViewpointVerEN.con_PdfPageNum) == true)
{
const strComparisonOp_PdfPageNum:string = objViewpointVer_Cond.dicFldComparisonOp[clsViewpointVerEN.con_PdfPageNum];
strWhereCond += Format(" And {0} {2} {1}", clsViewpointVerEN.con_PdfPageNum, objViewpointVer_Cond.pdfPageNum, strComparisonOp_PdfPageNum);
}
if (Object.prototype.hasOwnProperty.call(objViewpointVer_Cond.dicFldComparisonOp, clsViewpointVerEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objViewpointVer_Cond.dicFldComparisonOp[clsViewpointVerEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsViewpointVerEN.con_id_CurrEduCls, objViewpointVer_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (Object.prototype.hasOwnProperty.call(objViewpointVer_Cond.dicFldComparisonOp, clsViewpointVerEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objViewpointVer_Cond.dicFldComparisonOp[clsViewpointVerEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsViewpointVerEN.con_Memo, objViewpointVer_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--ViewpointVer(观点版本表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param lngViewpointVId: ViewpointVId(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function ViewpointVer_GetUniCondStr_ViewpointVId(objViewpointVerEN: clsViewpointVerEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and ViewpointVId = '{0}'", objViewpointVerEN.viewpointVId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--ViewpointVer(观点版本表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param lngViewpointVId: ViewpointVId(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function ViewpointVer_GetUniCondStr4Update_ViewpointVId(objViewpointVerEN: clsViewpointVerEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and ViewpointVId <> '{0}'", objViewpointVerEN.viewpointVId);
 strWhereCond +=  Format(" and ViewpointVId = '{0}'", objViewpointVerEN.viewpointVId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objViewpointVerENS:源对象
 * @param objViewpointVerENT:目标对象
*/
export function ViewpointVer_CopyObjTo(objViewpointVerENS: clsViewpointVerEN , objViewpointVerENT: clsViewpointVerEN ): void 
{
objViewpointVerENT.viewpointVId = objViewpointVerENS.viewpointVId; //ViewpointVId
objViewpointVerENT.viewpointId = objViewpointVerENS.viewpointId; //观点Id
objViewpointVerENT.viewpointName = objViewpointVerENS.viewpointName; //观点名称
objViewpointVerENT.viewpointContent = objViewpointVerENS.viewpointContent; //观点内容
objViewpointVerENT.viewpointTypeId = objViewpointVerENS.viewpointTypeId; //观点类型Id
objViewpointVerENT.reason = objViewpointVerENS.reason; //理由
objViewpointVerENT.source = objViewpointVerENS.source; //来源
objViewpointVerENT.vpProposePeople = objViewpointVerENS.vpProposePeople; //观点提出人
objViewpointVerENT.userTypeId = objViewpointVerENS.userTypeId; //用户类型Id
objViewpointVerENT.citationId = objViewpointVerENS.citationId; //引用Id
objViewpointVerENT.updDate = objViewpointVerENS.updDate; //修改日期
objViewpointVerENT.updUser = objViewpointVerENS.updUser; //修改人
objViewpointVerENT.pdfContent = objViewpointVerENS.pdfContent; //Pdf内容
objViewpointVerENT.pdfPageNum = objViewpointVerENS.pdfPageNum; //Pdf页码
objViewpointVerENT.id_CurrEduCls = objViewpointVerENS.id_CurrEduCls; //教学班流水号
objViewpointVerENT.memo = objViewpointVerENS.memo; //备注
objViewpointVerENT.sfUpdFldSetStr = objViewpointVerENS.updFldString; //sfUpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objViewpointVerENS:源对象
 * @param objViewpointVerENT:目标对象
*/
export function ViewpointVer_GetObjFromJsonObj(objViewpointVerENS: clsViewpointVerEN): clsViewpointVerEN 
{
 const objViewpointVerENT: clsViewpointVerEN = new clsViewpointVerEN();
ObjectAssign(objViewpointVerENT, objViewpointVerENS);
 return objViewpointVerENT;
}