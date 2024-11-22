﻿
 /**
 * 类名:clsvViewpointCitationWApi
 * 表名:vViewpointCitation(01120594)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:49:06
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
 * v观点引用(vViewpointCitation)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2023年03月13日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { enumComparisonOp } from "../../PubFun/enumComparisonOp.js";
import { clsvViewpointCitationEN } from "../../L0_Entity/GraduateEduTopic/clsvViewpointCitationEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { tzDataType } from "../../PubFun/clsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const vViewpointCitation_Controller = "vViewpointCitationApi";
 export const vViewpointCitation_ConstructorName = "vViewpointCitation";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngmId:关键字
 * @returns 对象
 **/
export async function vViewpointCitation_GetObjBymIdAsync(lngmId: number): Promise<clsvViewpointCitationEN|null>  
{
const strThisFuncName = "GetObjBymIdAsync";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In clsvViewpointCitationWApi.GetObjBymIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjBymId";
const strUrl = GetWebApiUrl(vViewpointCitation_Controller, strAction);
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
return null;
}
//console.log(returnObj);
const objvViewpointCitation = vViewpointCitation_GetObjFromJsonObj(returnObj);
return objvViewpointCitation;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vViewpointCitation_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vViewpointCitation_ConstructorName, strThisFuncName);
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
export function vViewpointCitation_SortFun_Defa(a:clsvViewpointCitationEN , b:clsvViewpointCitationEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.mId-b.mId;
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
export function vViewpointCitation_SortFun_Defa_2Fld(a:clsvViewpointCitationEN , b:clsvViewpointCitationEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.memo == b.memo) return a.paperContent.localeCompare(b.paperContent);
else return a.memo.localeCompare(b.memo);
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
export function vViewpointCitation_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsvViewpointCitationEN.con_Memo:
return (a: clsvViewpointCitationEN, b: clsvViewpointCitationEN) => {
if (a.memo == null) return -1;
if (b.memo == null) return 1;
return a.memo.localeCompare(b.memo);
}
case clsvViewpointCitationEN.con_mId:
return (a: clsvViewpointCitationEN, b: clsvViewpointCitationEN) => {
return a.mId-b.mId;
}
case clsvViewpointCitationEN.con_PaperContent:
return (a: clsvViewpointCitationEN, b: clsvViewpointCitationEN) => {
if (a.paperContent == null) return -1;
if (b.paperContent == null) return 1;
return a.paperContent.localeCompare(b.paperContent);
}
case clsvViewpointCitationEN.con_PaperId:
return (a: clsvViewpointCitationEN, b: clsvViewpointCitationEN) => {
if (a.paperId == null) return -1;
if (b.paperId == null) return 1;
return a.paperId.localeCompare(b.paperId);
}
case clsvViewpointCitationEN.con_PaperTitle:
return (a: clsvViewpointCitationEN, b: clsvViewpointCitationEN) => {
if (a.paperTitle == null) return -1;
if (b.paperTitle == null) return 1;
return a.paperTitle.localeCompare(b.paperTitle);
}
case clsvViewpointCitationEN.con_Reason:
return (a: clsvViewpointCitationEN, b: clsvViewpointCitationEN) => {
if (a.reason == null) return -1;
if (b.reason == null) return 1;
return a.reason.localeCompare(b.reason);
}
case clsvViewpointCitationEN.con_UpdUserId:
return (a: clsvViewpointCitationEN, b: clsvViewpointCitationEN) => {
if (a.updUserId == null) return -1;
if (b.updUserId == null) return 1;
return a.updUserId.localeCompare(b.updUserId);
}
case clsvViewpointCitationEN.con_UserName:
return (a: clsvViewpointCitationEN, b: clsvViewpointCitationEN) => {
if (a.userName == null) return -1;
if (b.userName == null) return 1;
return a.userName.localeCompare(b.userName);
}
case clsvViewpointCitationEN.con_ViewpointId:
return (a: clsvViewpointCitationEN, b: clsvViewpointCitationEN) => {
if (a.viewpointId == null) return -1;
if (b.viewpointId == null) return 1;
return a.viewpointId.localeCompare(b.viewpointId);
}
case clsvViewpointCitationEN.con_ViewpointName:
return (a: clsvViewpointCitationEN, b: clsvViewpointCitationEN) => {
if (a.viewpointName == null) return -1;
if (b.viewpointName == null) return 1;
return a.viewpointName.localeCompare(b.viewpointName);
}
case clsvViewpointCitationEN.con_ViewpointTypeId:
return (a: clsvViewpointCitationEN, b: clsvViewpointCitationEN) => {
if (a.viewpointTypeId == null) return -1;
if (b.viewpointTypeId == null) return 1;
return a.viewpointTypeId.localeCompare(b.viewpointTypeId);
}
case clsvViewpointCitationEN.con_ViewpointTypeName:
return (a: clsvViewpointCitationEN, b: clsvViewpointCitationEN) => {
if (a.viewpointTypeName == null) return -1;
if (b.viewpointTypeName == null) return 1;
return a.viewpointTypeName.localeCompare(b.viewpointTypeName);
}
case clsvViewpointCitationEN.con_UpdDate:
return (a: clsvViewpointCitationEN, b: clsvViewpointCitationEN) => {
if (a.updDate == null) return -1;
if (b.updDate == null) return 1;
return a.updDate.localeCompare(b.updDate);
}
case clsvViewpointCitationEN.con_ProposePeople:
return (a: clsvViewpointCitationEN, b: clsvViewpointCitationEN) => {
if (a.proposePeople == null) return -1;
if (b.proposePeople == null) return 1;
return a.proposePeople.localeCompare(b.proposePeople);
}
case clsvViewpointCitationEN.con_Source:
return (a: clsvViewpointCitationEN, b: clsvViewpointCitationEN) => {
if (a.source == null) return -1;
if (b.source == null) return 1;
return a.source.localeCompare(b.source);
}
case clsvViewpointCitationEN.con_TopicId:
return (a: clsvViewpointCitationEN, b: clsvViewpointCitationEN) => {
if (a.topicId == null) return -1;
if (b.topicId == null) return 1;
return a.topicId.localeCompare(b.topicId);
}
case clsvViewpointCitationEN.con_TopicName:
return (a: clsvViewpointCitationEN, b: clsvViewpointCitationEN) => {
if (a.topicName == null) return -1;
if (b.topicName == null) return 1;
return a.topicName.localeCompare(b.topicName);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vViewpointCitation]中不存在！(in ${ vViewpointCitation_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsvViewpointCitationEN.con_Memo:
return (a: clsvViewpointCitationEN, b: clsvViewpointCitationEN) => {
if (b.memo == null) return -1;
if (a.memo == null) return 1;
return b.memo.localeCompare(a.memo);
}
case clsvViewpointCitationEN.con_mId:
return (a: clsvViewpointCitationEN, b: clsvViewpointCitationEN) => {
return b.mId-a.mId;
}
case clsvViewpointCitationEN.con_PaperContent:
return (a: clsvViewpointCitationEN, b: clsvViewpointCitationEN) => {
if (b.paperContent == null) return -1;
if (a.paperContent == null) return 1;
return b.paperContent.localeCompare(a.paperContent);
}
case clsvViewpointCitationEN.con_PaperId:
return (a: clsvViewpointCitationEN, b: clsvViewpointCitationEN) => {
if (b.paperId == null) return -1;
if (a.paperId == null) return 1;
return b.paperId.localeCompare(a.paperId);
}
case clsvViewpointCitationEN.con_PaperTitle:
return (a: clsvViewpointCitationEN, b: clsvViewpointCitationEN) => {
if (b.paperTitle == null) return -1;
if (a.paperTitle == null) return 1;
return b.paperTitle.localeCompare(a.paperTitle);
}
case clsvViewpointCitationEN.con_Reason:
return (a: clsvViewpointCitationEN, b: clsvViewpointCitationEN) => {
if (b.reason == null) return -1;
if (a.reason == null) return 1;
return b.reason.localeCompare(a.reason);
}
case clsvViewpointCitationEN.con_UpdUserId:
return (a: clsvViewpointCitationEN, b: clsvViewpointCitationEN) => {
if (b.updUserId == null) return -1;
if (a.updUserId == null) return 1;
return b.updUserId.localeCompare(a.updUserId);
}
case clsvViewpointCitationEN.con_UserName:
return (a: clsvViewpointCitationEN, b: clsvViewpointCitationEN) => {
if (b.userName == null) return -1;
if (a.userName == null) return 1;
return b.userName.localeCompare(a.userName);
}
case clsvViewpointCitationEN.con_ViewpointId:
return (a: clsvViewpointCitationEN, b: clsvViewpointCitationEN) => {
if (b.viewpointId == null) return -1;
if (a.viewpointId == null) return 1;
return b.viewpointId.localeCompare(a.viewpointId);
}
case clsvViewpointCitationEN.con_ViewpointName:
return (a: clsvViewpointCitationEN, b: clsvViewpointCitationEN) => {
if (b.viewpointName == null) return -1;
if (a.viewpointName == null) return 1;
return b.viewpointName.localeCompare(a.viewpointName);
}
case clsvViewpointCitationEN.con_ViewpointTypeId:
return (a: clsvViewpointCitationEN, b: clsvViewpointCitationEN) => {
if (b.viewpointTypeId == null) return -1;
if (a.viewpointTypeId == null) return 1;
return b.viewpointTypeId.localeCompare(a.viewpointTypeId);
}
case clsvViewpointCitationEN.con_ViewpointTypeName:
return (a: clsvViewpointCitationEN, b: clsvViewpointCitationEN) => {
if (b.viewpointTypeName == null) return -1;
if (a.viewpointTypeName == null) return 1;
return b.viewpointTypeName.localeCompare(a.viewpointTypeName);
}
case clsvViewpointCitationEN.con_UpdDate:
return (a: clsvViewpointCitationEN, b: clsvViewpointCitationEN) => {
if (b.updDate == null) return -1;
if (a.updDate == null) return 1;
return b.updDate.localeCompare(a.updDate);
}
case clsvViewpointCitationEN.con_ProposePeople:
return (a: clsvViewpointCitationEN, b: clsvViewpointCitationEN) => {
if (b.proposePeople == null) return -1;
if (a.proposePeople == null) return 1;
return b.proposePeople.localeCompare(a.proposePeople);
}
case clsvViewpointCitationEN.con_Source:
return (a: clsvViewpointCitationEN, b: clsvViewpointCitationEN) => {
if (b.source == null) return -1;
if (a.source == null) return 1;
return b.source.localeCompare(a.source);
}
case clsvViewpointCitationEN.con_TopicId:
return (a: clsvViewpointCitationEN, b: clsvViewpointCitationEN) => {
if (b.topicId == null) return -1;
if (a.topicId == null) return 1;
return b.topicId.localeCompare(a.topicId);
}
case clsvViewpointCitationEN.con_TopicName:
return (a: clsvViewpointCitationEN, b: clsvViewpointCitationEN) => {
if (b.topicName == null) return -1;
if (a.topicName == null) return 1;
return b.topicName.localeCompare(a.topicName);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vViewpointCitation]中不存在！(in ${ vViewpointCitation_ConstructorName}.${ strThisFuncName})`;
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
export async function vViewpointCitation_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsvViewpointCitationEN.con_Memo:
return (obj: clsvViewpointCitationEN) => {
return obj.memo === value;
}
case clsvViewpointCitationEN.con_mId:
return (obj: clsvViewpointCitationEN) => {
return obj.mId === value;
}
case clsvViewpointCitationEN.con_PaperContent:
return (obj: clsvViewpointCitationEN) => {
return obj.paperContent === value;
}
case clsvViewpointCitationEN.con_PaperId:
return (obj: clsvViewpointCitationEN) => {
return obj.paperId === value;
}
case clsvViewpointCitationEN.con_PaperTitle:
return (obj: clsvViewpointCitationEN) => {
return obj.paperTitle === value;
}
case clsvViewpointCitationEN.con_Reason:
return (obj: clsvViewpointCitationEN) => {
return obj.reason === value;
}
case clsvViewpointCitationEN.con_UpdUserId:
return (obj: clsvViewpointCitationEN) => {
return obj.updUserId === value;
}
case clsvViewpointCitationEN.con_UserName:
return (obj: clsvViewpointCitationEN) => {
return obj.userName === value;
}
case clsvViewpointCitationEN.con_ViewpointId:
return (obj: clsvViewpointCitationEN) => {
return obj.viewpointId === value;
}
case clsvViewpointCitationEN.con_ViewpointName:
return (obj: clsvViewpointCitationEN) => {
return obj.viewpointName === value;
}
case clsvViewpointCitationEN.con_ViewpointTypeId:
return (obj: clsvViewpointCitationEN) => {
return obj.viewpointTypeId === value;
}
case clsvViewpointCitationEN.con_ViewpointTypeName:
return (obj: clsvViewpointCitationEN) => {
return obj.viewpointTypeName === value;
}
case clsvViewpointCitationEN.con_UpdDate:
return (obj: clsvViewpointCitationEN) => {
return obj.updDate === value;
}
case clsvViewpointCitationEN.con_ProposePeople:
return (obj: clsvViewpointCitationEN) => {
return obj.proposePeople === value;
}
case clsvViewpointCitationEN.con_Source:
return (obj: clsvViewpointCitationEN) => {
return obj.source === value;
}
case clsvViewpointCitationEN.con_TopicId:
return (obj: clsvViewpointCitationEN) => {
return obj.topicId === value;
}
case clsvViewpointCitationEN.con_TopicName:
return (obj: clsvViewpointCitationEN) => {
return obj.topicName === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vViewpointCitation]中不存在！(in ${ vViewpointCitation_ConstructorName}.${ strThisFuncName})`;
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
export async function vViewpointCitation_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vViewpointCitation_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vViewpointCitation_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vViewpointCitation_ConstructorName, strThisFuncName);
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
export async function vViewpointCitation_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vViewpointCitation_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vViewpointCitation_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vViewpointCitation_ConstructorName, strThisFuncName);
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
export async function vViewpointCitation_GetFirstObjAsync(strWhereCond: string): Promise<clsvViewpointCitationEN|null>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(vViewpointCitation_Controller, strAction);
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
const objvViewpointCitation = vViewpointCitation_GetObjFromJsonObj(returnObj);
return objvViewpointCitation;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vViewpointCitation_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vViewpointCitation_ConstructorName, strThisFuncName);
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
export async function vViewpointCitation_GetObjLstAsync(strWhereCond: string): Promise<Array<clsvViewpointCitationEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(vViewpointCitation_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vViewpointCitation_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vViewpointCitation_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vViewpointCitation_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vViewpointCitation_ConstructorName, strThisFuncName);
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
export async function vViewpointCitation_GetObjLstBymIdLstAsync(arrmId: Array<string>): Promise<Array<clsvViewpointCitationEN>>  
{
const strThisFuncName = "GetObjLstBymIdLstAsync";
const strAction = "GetObjLstBymIdLst";
const strUrl = GetWebApiUrl(vViewpointCitation_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrmId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vViewpointCitation_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vViewpointCitation_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vViewpointCitation_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vViewpointCitation_ConstructorName, strThisFuncName);
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
export async function vViewpointCitation_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsvViewpointCitationEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(vViewpointCitation_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vViewpointCitation_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vViewpointCitation_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vViewpointCitation_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vViewpointCitation_ConstructorName, strThisFuncName);
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
export async function vViewpointCitation_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsvViewpointCitationEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vViewpointCitation_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vViewpointCitation_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vViewpointCitation_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vViewpointCitation_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vViewpointCitation_ConstructorName, strThisFuncName);
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
export async function vViewpointCitation_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vViewpointCitation_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vViewpointCitation_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vViewpointCitation_ConstructorName, strThisFuncName);
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
export async function vViewpointCitation_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsvViewpointCitationEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
if (objPagerPara.pageIndex == 0) return new Array<clsvViewpointCitationEN>();
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(vViewpointCitation_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vViewpointCitation_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vViewpointCitation_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vViewpointCitation_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vViewpointCitation_ConstructorName, strThisFuncName);
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
export async function vViewpointCitation_DelRecordAsync(lngmId: number): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(vViewpointCitation_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, lngmId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vViewpointCitation_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vViewpointCitation_ConstructorName, strThisFuncName);
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
export async function vViewpointCitation_DelvViewpointCitationsAsync(arrmId: Array<string>): Promise<number> 
{
const strThisFuncName = "DelvViewpointCitationsAsync";
const strAction = "DelvViewpointCitations";
const strUrl = GetWebApiUrl(vViewpointCitation_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vViewpointCitation_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vViewpointCitation_ConstructorName, strThisFuncName);
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
export async function vViewpointCitation_DelvViewpointCitationsByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "DelvViewpointCitationsByCondAsync";
const strAction = "DelvViewpointCitationsByCond";
const strUrl = GetWebApiUrl(vViewpointCitation_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vViewpointCitation_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vViewpointCitation_ConstructorName, strThisFuncName);
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
 * @param objvViewpointCitationEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function vViewpointCitation_AddNewRecordAsync(objvViewpointCitationEN: clsvViewpointCitationEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objvViewpointCitationEN);
const strUrl = GetWebApiUrl(vViewpointCitation_Controller, strAction);
try
{
const response = await axios.post(strUrl, objvViewpointCitationEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vViewpointCitation_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vViewpointCitation_ConstructorName, strThisFuncName);
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
 * @param objvViewpointCitationEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function vViewpointCitation_AddNewRecordWithReturnKeyAsync(objvViewpointCitationEN: clsvViewpointCitationEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(vViewpointCitation_Controller, strAction);
try
{
const response = await axios.post(strUrl, objvViewpointCitationEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vViewpointCitation_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vViewpointCitation_ConstructorName, strThisFuncName);
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
 * @param objvViewpointCitationEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function vViewpointCitation_AddNewRecordWithReturnKey(objvViewpointCitationEN: clsvViewpointCitationEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objvViewpointCitationEN.mId === null || objvViewpointCitationEN.mId === 0)
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(vViewpointCitation_Controller, strAction);
try
{
const response = await axios.post(strUrl, objvViewpointCitationEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vViewpointCitation_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vViewpointCitation_ConstructorName, strThisFuncName);
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
 * @param objvViewpointCitationEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function vViewpointCitation_UpdateRecordAsync(objvViewpointCitationEN: clsvViewpointCitationEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objvViewpointCitationEN.sfUpdFldSetStr === undefined || objvViewpointCitationEN.sfUpdFldSetStr === null || objvViewpointCitationEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objvViewpointCitationEN.mId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(vViewpointCitation_Controller, strAction);
try
{
const response = await axios.post(strUrl, objvViewpointCitationEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vViewpointCitation_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vViewpointCitation_ConstructorName, strThisFuncName);
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
 * @param objvViewpointCitationEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function vViewpointCitation_UpdateWithConditionAsync(objvViewpointCitationEN: clsvViewpointCitationEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objvViewpointCitationEN.sfUpdFldSetStr === undefined || objvViewpointCitationEN.sfUpdFldSetStr === null || objvViewpointCitationEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objvViewpointCitationEN.mId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(vViewpointCitation_Controller, strAction);
objvViewpointCitationEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objvViewpointCitationEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vViewpointCitation_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vViewpointCitation_ConstructorName, strThisFuncName);
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
export async function vViewpointCitation_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(vViewpointCitation_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vViewpointCitation_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vViewpointCitation_ConstructorName, strThisFuncName);
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
export async function vViewpointCitation_IsExist(lngmId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vViewpointCitation_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vViewpointCitation_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vViewpointCitation_ConstructorName, strThisFuncName);
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
export async function vViewpointCitation_IsExistAsync(lngmId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vViewpointCitation_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vViewpointCitation_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vViewpointCitation_ConstructorName, strThisFuncName);
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
export async function vViewpointCitation_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(vViewpointCitation_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vViewpointCitation_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vViewpointCitation_ConstructorName, strThisFuncName);
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
export async function vViewpointCitation_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(vViewpointCitation_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vViewpointCitation_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vViewpointCitation_ConstructorName, strThisFuncName);
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
export function vViewpointCitation_GetWebApiUrl(strController: string, strAction: string): string {
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
export function vViewpointCitation_CheckPropertyNew(pobjvViewpointCitationEN: clsvViewpointCitationEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjvViewpointCitationEN.memo) == false && GetStrLen(pobjvViewpointCitationEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In v观点引用(vViewpointCitation))!值:$(pobjvViewpointCitationEN.memo)(clsvViewpointCitationBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjvViewpointCitationEN.paperId) == false && GetStrLen(pobjvViewpointCitationEN.paperId) > 8)
{
 throw new Error("(errid:Watl000059)字段[论文Id(paperId)]的长度不能超过8(In v观点引用(vViewpointCitation))!值:$(pobjvViewpointCitationEN.paperId)(clsvViewpointCitationBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjvViewpointCitationEN.paperTitle) == false && GetStrLen(pobjvViewpointCitationEN.paperTitle) > 500)
{
 throw new Error("(errid:Watl000059)字段[论文标题(paperTitle)]的长度不能超过500(In v观点引用(vViewpointCitation))!值:$(pobjvViewpointCitationEN.paperTitle)(clsvViewpointCitationBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjvViewpointCitationEN.updUserId) == false && GetStrLen(pobjvViewpointCitationEN.updUserId) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改用户Id(updUserId)]的长度不能超过20(In v观点引用(vViewpointCitation))!值:$(pobjvViewpointCitationEN.updUserId)(clsvViewpointCitationBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjvViewpointCitationEN.userName) == false && GetStrLen(pobjvViewpointCitationEN.userName) > 30)
{
 throw new Error("(errid:Watl000059)字段[用户名(userName)]的长度不能超过30(In v观点引用(vViewpointCitation))!值:$(pobjvViewpointCitationEN.userName)(clsvViewpointCitationBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjvViewpointCitationEN.viewpointId) == false && GetStrLen(pobjvViewpointCitationEN.viewpointId) > 8)
{
 throw new Error("(errid:Watl000059)字段[观点Id(viewpointId)]的长度不能超过8(In v观点引用(vViewpointCitation))!值:$(pobjvViewpointCitationEN.viewpointId)(clsvViewpointCitationBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjvViewpointCitationEN.viewpointName) == false && GetStrLen(pobjvViewpointCitationEN.viewpointName) > 500)
{
 throw new Error("(errid:Watl000059)字段[观点名称(viewpointName)]的长度不能超过500(In v观点引用(vViewpointCitation))!值:$(pobjvViewpointCitationEN.viewpointName)(clsvViewpointCitationBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjvViewpointCitationEN.viewpointTypeId) == false && GetStrLen(pobjvViewpointCitationEN.viewpointTypeId) > 4)
{
 throw new Error("(errid:Watl000059)字段[观点类型Id(viewpointTypeId)]的长度不能超过4(In v观点引用(vViewpointCitation))!值:$(pobjvViewpointCitationEN.viewpointTypeId)(clsvViewpointCitationBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjvViewpointCitationEN.viewpointTypeName) == false && GetStrLen(pobjvViewpointCitationEN.viewpointTypeName) > 50)
{
 throw new Error("(errid:Watl000059)字段[观点类型名(viewpointTypeName)]的长度不能超过50(In v观点引用(vViewpointCitation))!值:$(pobjvViewpointCitationEN.viewpointTypeName)(clsvViewpointCitationBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjvViewpointCitationEN.updDate) == false && GetStrLen(pobjvViewpointCitationEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In v观点引用(vViewpointCitation))!值:$(pobjvViewpointCitationEN.updDate)(clsvViewpointCitationBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjvViewpointCitationEN.proposePeople) == false && GetStrLen(pobjvViewpointCitationEN.proposePeople) > 50)
{
 throw new Error("(errid:Watl000059)字段[提出人(proposePeople)]的长度不能超过50(In v观点引用(vViewpointCitation))!值:$(pobjvViewpointCitationEN.proposePeople)(clsvViewpointCitationBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjvViewpointCitationEN.source) == false && GetStrLen(pobjvViewpointCitationEN.source) > 500)
{
 throw new Error("(errid:Watl000059)字段[来源(source)]的长度不能超过500(In v观点引用(vViewpointCitation))!值:$(pobjvViewpointCitationEN.source)(clsvViewpointCitationBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjvViewpointCitationEN.topicId) == false && GetStrLen(pobjvViewpointCitationEN.topicId) > 8)
{
 throw new Error("(errid:Watl000059)字段[主题Id(topicId)]的长度不能超过8(In v观点引用(vViewpointCitation))!值:$(pobjvViewpointCitationEN.topicId)(clsvViewpointCitationBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjvViewpointCitationEN.topicName) == false && GetStrLen(pobjvViewpointCitationEN.topicName) > 200)
{
 throw new Error("(errid:Watl000059)字段[栏目主题(topicName)]的长度不能超过200(In v观点引用(vViewpointCitation))!值:$(pobjvViewpointCitationEN.topicName)(clsvViewpointCitationBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjvViewpointCitationEN.memo) == false && undefined !== pobjvViewpointCitationEN.memo && tzDataType.isString(pobjvViewpointCitationEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjvViewpointCitationEN.memo)], 非法，应该为字符型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckPropertyNew)");
}
if (null != pobjvViewpointCitationEN.mId && undefined !== pobjvViewpointCitationEN.mId && tzDataType.isNumber(pobjvViewpointCitationEN.mId) === false)
{
 throw new Error("(errid:Watl000060)字段[mId(mId)]的值:[$(pobjvViewpointCitationEN.mId)], 非法，应该为数值型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjvViewpointCitationEN.paperContent) == false && undefined !== pobjvViewpointCitationEN.paperContent && tzDataType.isString(pobjvViewpointCitationEN.paperContent) === false)
{
 throw new Error("(errid:Watl000060)字段[主题内容(paperContent)]的值:[$(pobjvViewpointCitationEN.paperContent)], 非法，应该为字符型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjvViewpointCitationEN.paperId) == false && undefined !== pobjvViewpointCitationEN.paperId && tzDataType.isString(pobjvViewpointCitationEN.paperId) === false)
{
 throw new Error("(errid:Watl000060)字段[论文Id(paperId)]的值:[$(pobjvViewpointCitationEN.paperId)], 非法，应该为字符型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjvViewpointCitationEN.paperTitle) == false && undefined !== pobjvViewpointCitationEN.paperTitle && tzDataType.isString(pobjvViewpointCitationEN.paperTitle) === false)
{
 throw new Error("(errid:Watl000060)字段[论文标题(paperTitle)]的值:[$(pobjvViewpointCitationEN.paperTitle)], 非法，应该为字符型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjvViewpointCitationEN.reason) == false && undefined !== pobjvViewpointCitationEN.reason && tzDataType.isString(pobjvViewpointCitationEN.reason) === false)
{
 throw new Error("(errid:Watl000060)字段[理由(reason)]的值:[$(pobjvViewpointCitationEN.reason)], 非法，应该为字符型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjvViewpointCitationEN.updUserId) == false && undefined !== pobjvViewpointCitationEN.updUserId && tzDataType.isString(pobjvViewpointCitationEN.updUserId) === false)
{
 throw new Error("(errid:Watl000060)字段[修改用户Id(updUserId)]的值:[$(pobjvViewpointCitationEN.updUserId)], 非法，应该为字符型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjvViewpointCitationEN.userName) == false && undefined !== pobjvViewpointCitationEN.userName && tzDataType.isString(pobjvViewpointCitationEN.userName) === false)
{
 throw new Error("(errid:Watl000060)字段[用户名(userName)]的值:[$(pobjvViewpointCitationEN.userName)], 非法，应该为字符型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjvViewpointCitationEN.viewpointId) == false && undefined !== pobjvViewpointCitationEN.viewpointId && tzDataType.isString(pobjvViewpointCitationEN.viewpointId) === false)
{
 throw new Error("(errid:Watl000060)字段[观点Id(viewpointId)]的值:[$(pobjvViewpointCitationEN.viewpointId)], 非法，应该为字符型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjvViewpointCitationEN.viewpointName) == false && undefined !== pobjvViewpointCitationEN.viewpointName && tzDataType.isString(pobjvViewpointCitationEN.viewpointName) === false)
{
 throw new Error("(errid:Watl000060)字段[观点名称(viewpointName)]的值:[$(pobjvViewpointCitationEN.viewpointName)], 非法，应该为字符型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjvViewpointCitationEN.viewpointTypeId) == false && undefined !== pobjvViewpointCitationEN.viewpointTypeId && tzDataType.isString(pobjvViewpointCitationEN.viewpointTypeId) === false)
{
 throw new Error("(errid:Watl000060)字段[观点类型Id(viewpointTypeId)]的值:[$(pobjvViewpointCitationEN.viewpointTypeId)], 非法，应该为字符型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjvViewpointCitationEN.viewpointTypeName) == false && undefined !== pobjvViewpointCitationEN.viewpointTypeName && tzDataType.isString(pobjvViewpointCitationEN.viewpointTypeName) === false)
{
 throw new Error("(errid:Watl000060)字段[观点类型名(viewpointTypeName)]的值:[$(pobjvViewpointCitationEN.viewpointTypeName)], 非法，应该为字符型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjvViewpointCitationEN.updDate) == false && undefined !== pobjvViewpointCitationEN.updDate && tzDataType.isString(pobjvViewpointCitationEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjvViewpointCitationEN.updDate)], 非法，应该为字符型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjvViewpointCitationEN.proposePeople) == false && undefined !== pobjvViewpointCitationEN.proposePeople && tzDataType.isString(pobjvViewpointCitationEN.proposePeople) === false)
{
 throw new Error("(errid:Watl000060)字段[提出人(proposePeople)]的值:[$(pobjvViewpointCitationEN.proposePeople)], 非法，应该为字符型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjvViewpointCitationEN.source) == false && undefined !== pobjvViewpointCitationEN.source && tzDataType.isString(pobjvViewpointCitationEN.source) === false)
{
 throw new Error("(errid:Watl000060)字段[来源(source)]的值:[$(pobjvViewpointCitationEN.source)], 非法，应该为字符型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjvViewpointCitationEN.topicId) == false && undefined !== pobjvViewpointCitationEN.topicId && tzDataType.isString(pobjvViewpointCitationEN.topicId) === false)
{
 throw new Error("(errid:Watl000060)字段[主题Id(topicId)]的值:[$(pobjvViewpointCitationEN.topicId)], 非法，应该为字符型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjvViewpointCitationEN.topicName) == false && undefined !== pobjvViewpointCitationEN.topicName && tzDataType.isString(pobjvViewpointCitationEN.topicName) === false)
{
 throw new Error("(errid:Watl000060)字段[栏目主题(topicName)]的值:[$(pobjvViewpointCitationEN.topicName)], 非法，应该为字符型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjvViewpointCitationEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function vViewpointCitation_CheckProperty4Update (pobjvViewpointCitationEN: clsvViewpointCitationEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjvViewpointCitationEN.memo) == false && GetStrLen(pobjvViewpointCitationEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In v观点引用(vViewpointCitation))!值:$(pobjvViewpointCitationEN.memo)(clsvViewpointCitationBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjvViewpointCitationEN.paperId) == false && GetStrLen(pobjvViewpointCitationEN.paperId) > 8)
{
 throw new Error("(errid:Watl000062)字段[论文Id(paperId)]的长度不能超过8(In v观点引用(vViewpointCitation))!值:$(pobjvViewpointCitationEN.paperId)(clsvViewpointCitationBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjvViewpointCitationEN.paperTitle) == false && GetStrLen(pobjvViewpointCitationEN.paperTitle) > 500)
{
 throw new Error("(errid:Watl000062)字段[论文标题(paperTitle)]的长度不能超过500(In v观点引用(vViewpointCitation))!值:$(pobjvViewpointCitationEN.paperTitle)(clsvViewpointCitationBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjvViewpointCitationEN.updUserId) == false && GetStrLen(pobjvViewpointCitationEN.updUserId) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改用户Id(updUserId)]的长度不能超过20(In v观点引用(vViewpointCitation))!值:$(pobjvViewpointCitationEN.updUserId)(clsvViewpointCitationBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjvViewpointCitationEN.userName) == false && GetStrLen(pobjvViewpointCitationEN.userName) > 30)
{
 throw new Error("(errid:Watl000062)字段[用户名(userName)]的长度不能超过30(In v观点引用(vViewpointCitation))!值:$(pobjvViewpointCitationEN.userName)(clsvViewpointCitationBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjvViewpointCitationEN.viewpointId) == false && GetStrLen(pobjvViewpointCitationEN.viewpointId) > 8)
{
 throw new Error("(errid:Watl000062)字段[观点Id(viewpointId)]的长度不能超过8(In v观点引用(vViewpointCitation))!值:$(pobjvViewpointCitationEN.viewpointId)(clsvViewpointCitationBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjvViewpointCitationEN.viewpointName) == false && GetStrLen(pobjvViewpointCitationEN.viewpointName) > 500)
{
 throw new Error("(errid:Watl000062)字段[观点名称(viewpointName)]的长度不能超过500(In v观点引用(vViewpointCitation))!值:$(pobjvViewpointCitationEN.viewpointName)(clsvViewpointCitationBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjvViewpointCitationEN.viewpointTypeId) == false && GetStrLen(pobjvViewpointCitationEN.viewpointTypeId) > 4)
{
 throw new Error("(errid:Watl000062)字段[观点类型Id(viewpointTypeId)]的长度不能超过4(In v观点引用(vViewpointCitation))!值:$(pobjvViewpointCitationEN.viewpointTypeId)(clsvViewpointCitationBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjvViewpointCitationEN.viewpointTypeName) == false && GetStrLen(pobjvViewpointCitationEN.viewpointTypeName) > 50)
{
 throw new Error("(errid:Watl000062)字段[观点类型名(viewpointTypeName)]的长度不能超过50(In v观点引用(vViewpointCitation))!值:$(pobjvViewpointCitationEN.viewpointTypeName)(clsvViewpointCitationBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjvViewpointCitationEN.updDate) == false && GetStrLen(pobjvViewpointCitationEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In v观点引用(vViewpointCitation))!值:$(pobjvViewpointCitationEN.updDate)(clsvViewpointCitationBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjvViewpointCitationEN.proposePeople) == false && GetStrLen(pobjvViewpointCitationEN.proposePeople) > 50)
{
 throw new Error("(errid:Watl000062)字段[提出人(proposePeople)]的长度不能超过50(In v观点引用(vViewpointCitation))!值:$(pobjvViewpointCitationEN.proposePeople)(clsvViewpointCitationBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjvViewpointCitationEN.source) == false && GetStrLen(pobjvViewpointCitationEN.source) > 500)
{
 throw new Error("(errid:Watl000062)字段[来源(source)]的长度不能超过500(In v观点引用(vViewpointCitation))!值:$(pobjvViewpointCitationEN.source)(clsvViewpointCitationBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjvViewpointCitationEN.topicId) == false && GetStrLen(pobjvViewpointCitationEN.topicId) > 8)
{
 throw new Error("(errid:Watl000062)字段[主题Id(topicId)]的长度不能超过8(In v观点引用(vViewpointCitation))!值:$(pobjvViewpointCitationEN.topicId)(clsvViewpointCitationBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjvViewpointCitationEN.topicName) == false && GetStrLen(pobjvViewpointCitationEN.topicName) > 200)
{
 throw new Error("(errid:Watl000062)字段[栏目主题(topicName)]的长度不能超过200(In v观点引用(vViewpointCitation))!值:$(pobjvViewpointCitationEN.topicName)(clsvViewpointCitationBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjvViewpointCitationEN.memo) == false && undefined !== pobjvViewpointCitationEN.memo && tzDataType.isString(pobjvViewpointCitationEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjvViewpointCitationEN.memo)], 非法，应该为字符型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckProperty4Update)");
}
if (null != pobjvViewpointCitationEN.mId && undefined !== pobjvViewpointCitationEN.mId && tzDataType.isNumber(pobjvViewpointCitationEN.mId) === false)
{
 throw new Error("(errid:Watl000063)字段[mId(mId)]的值:[$(pobjvViewpointCitationEN.mId)], 非法，应该为数值型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjvViewpointCitationEN.paperContent) == false && undefined !== pobjvViewpointCitationEN.paperContent && tzDataType.isString(pobjvViewpointCitationEN.paperContent) === false)
{
 throw new Error("(errid:Watl000063)字段[主题内容(paperContent)]的值:[$(pobjvViewpointCitationEN.paperContent)], 非法，应该为字符型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjvViewpointCitationEN.paperId) == false && undefined !== pobjvViewpointCitationEN.paperId && tzDataType.isString(pobjvViewpointCitationEN.paperId) === false)
{
 throw new Error("(errid:Watl000063)字段[论文Id(paperId)]的值:[$(pobjvViewpointCitationEN.paperId)], 非法，应该为字符型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjvViewpointCitationEN.paperTitle) == false && undefined !== pobjvViewpointCitationEN.paperTitle && tzDataType.isString(pobjvViewpointCitationEN.paperTitle) === false)
{
 throw new Error("(errid:Watl000063)字段[论文标题(paperTitle)]的值:[$(pobjvViewpointCitationEN.paperTitle)], 非法，应该为字符型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjvViewpointCitationEN.reason) == false && undefined !== pobjvViewpointCitationEN.reason && tzDataType.isString(pobjvViewpointCitationEN.reason) === false)
{
 throw new Error("(errid:Watl000063)字段[理由(reason)]的值:[$(pobjvViewpointCitationEN.reason)], 非法，应该为字符型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjvViewpointCitationEN.updUserId) == false && undefined !== pobjvViewpointCitationEN.updUserId && tzDataType.isString(pobjvViewpointCitationEN.updUserId) === false)
{
 throw new Error("(errid:Watl000063)字段[修改用户Id(updUserId)]的值:[$(pobjvViewpointCitationEN.updUserId)], 非法，应该为字符型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjvViewpointCitationEN.userName) == false && undefined !== pobjvViewpointCitationEN.userName && tzDataType.isString(pobjvViewpointCitationEN.userName) === false)
{
 throw new Error("(errid:Watl000063)字段[用户名(userName)]的值:[$(pobjvViewpointCitationEN.userName)], 非法，应该为字符型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjvViewpointCitationEN.viewpointId) == false && undefined !== pobjvViewpointCitationEN.viewpointId && tzDataType.isString(pobjvViewpointCitationEN.viewpointId) === false)
{
 throw new Error("(errid:Watl000063)字段[观点Id(viewpointId)]的值:[$(pobjvViewpointCitationEN.viewpointId)], 非法，应该为字符型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjvViewpointCitationEN.viewpointName) == false && undefined !== pobjvViewpointCitationEN.viewpointName && tzDataType.isString(pobjvViewpointCitationEN.viewpointName) === false)
{
 throw new Error("(errid:Watl000063)字段[观点名称(viewpointName)]的值:[$(pobjvViewpointCitationEN.viewpointName)], 非法，应该为字符型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjvViewpointCitationEN.viewpointTypeId) == false && undefined !== pobjvViewpointCitationEN.viewpointTypeId && tzDataType.isString(pobjvViewpointCitationEN.viewpointTypeId) === false)
{
 throw new Error("(errid:Watl000063)字段[观点类型Id(viewpointTypeId)]的值:[$(pobjvViewpointCitationEN.viewpointTypeId)], 非法，应该为字符型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjvViewpointCitationEN.viewpointTypeName) == false && undefined !== pobjvViewpointCitationEN.viewpointTypeName && tzDataType.isString(pobjvViewpointCitationEN.viewpointTypeName) === false)
{
 throw new Error("(errid:Watl000063)字段[观点类型名(viewpointTypeName)]的值:[$(pobjvViewpointCitationEN.viewpointTypeName)], 非法，应该为字符型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjvViewpointCitationEN.updDate) == false && undefined !== pobjvViewpointCitationEN.updDate && tzDataType.isString(pobjvViewpointCitationEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjvViewpointCitationEN.updDate)], 非法，应该为字符型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjvViewpointCitationEN.proposePeople) == false && undefined !== pobjvViewpointCitationEN.proposePeople && tzDataType.isString(pobjvViewpointCitationEN.proposePeople) === false)
{
 throw new Error("(errid:Watl000063)字段[提出人(proposePeople)]的值:[$(pobjvViewpointCitationEN.proposePeople)], 非法，应该为字符型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjvViewpointCitationEN.source) == false && undefined !== pobjvViewpointCitationEN.source && tzDataType.isString(pobjvViewpointCitationEN.source) === false)
{
 throw new Error("(errid:Watl000063)字段[来源(source)]的值:[$(pobjvViewpointCitationEN.source)], 非法，应该为字符型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjvViewpointCitationEN.topicId) == false && undefined !== pobjvViewpointCitationEN.topicId && tzDataType.isString(pobjvViewpointCitationEN.topicId) === false)
{
 throw new Error("(errid:Watl000063)字段[主题Id(topicId)]的值:[$(pobjvViewpointCitationEN.topicId)], 非法，应该为字符型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjvViewpointCitationEN.topicName) == false && undefined !== pobjvViewpointCitationEN.topicName && tzDataType.isString(pobjvViewpointCitationEN.topicName) === false)
{
 throw new Error("(errid:Watl000063)字段[栏目主题(topicName)]的值:[$(pobjvViewpointCitationEN.topicName)], 非法，应该为字符型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjvViewpointCitationEN.mId 
 || pobjvViewpointCitationEN.mId != null && pobjvViewpointCitationEN.mId.toString()  ===  "")
{
 throw new Error("(errid:Watl000064)字段[mId]不能为空(In v观点引用)!(clsvViewpointCitationBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjvViewpointCitationEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vViewpointCitation_GetJSONStrByObj (pobjvViewpointCitationEN: clsvViewpointCitationEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjvViewpointCitationEN.sfUpdFldSetStr = pobjvViewpointCitationEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjvViewpointCitationEN);
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
export function vViewpointCitation_GetObjLstByJSONStr (strJSON: string): Array<clsvViewpointCitationEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrvViewpointCitationObjLst = new Array<clsvViewpointCitationEN>();
if (strJSON === "")
{
return arrvViewpointCitationObjLst;
}
try
{
arrvViewpointCitationObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvViewpointCitationObjLst;
}
return arrvViewpointCitationObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrvViewpointCitationObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function vViewpointCitation_GetObjLstByJSONObjLst (arrvViewpointCitationObjLstS: Array<clsvViewpointCitationEN>): Array<clsvViewpointCitationEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrvViewpointCitationObjLst = new Array<clsvViewpointCitationEN>();
for (const objInFor of arrvViewpointCitationObjLstS) {
const obj1 = vViewpointCitation_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrvViewpointCitationObjLst.push(obj1);
}
return arrvViewpointCitationObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vViewpointCitation_GetObjByJSONStr (strJSON: string): clsvViewpointCitationEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjvViewpointCitationEN = new clsvViewpointCitationEN();
if (strJSON === "")
{
return pobjvViewpointCitationEN;
}
try
{
pobjvViewpointCitationEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvViewpointCitationEN;
}
return pobjvViewpointCitationEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function vViewpointCitation_GetCombineCondition(objvViewpointCitation_Cond: clsvViewpointCitationEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objvViewpointCitation_Cond.dicFldComparisonOp, clsvViewpointCitationEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objvViewpointCitation_Cond.dicFldComparisonOp[clsvViewpointCitationEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsvViewpointCitationEN.con_Memo, objvViewpointCitation_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objvViewpointCitation_Cond.dicFldComparisonOp, clsvViewpointCitationEN.con_mId) == true)
{
const strComparisonOp_mId:string = objvViewpointCitation_Cond.dicFldComparisonOp[clsvViewpointCitationEN.con_mId];
strWhereCond += Format(" And {0} {2} {1}", clsvViewpointCitationEN.con_mId, objvViewpointCitation_Cond.mId, strComparisonOp_mId);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objvViewpointCitation_Cond.dicFldComparisonOp, clsvViewpointCitationEN.con_PaperId) == true)
{
const strComparisonOp_PaperId:string = objvViewpointCitation_Cond.dicFldComparisonOp[clsvViewpointCitationEN.con_PaperId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvViewpointCitationEN.con_PaperId, objvViewpointCitation_Cond.paperId, strComparisonOp_PaperId);
}
if (Object.prototype.hasOwnProperty.call(objvViewpointCitation_Cond.dicFldComparisonOp, clsvViewpointCitationEN.con_PaperTitle) == true)
{
const strComparisonOp_PaperTitle:string = objvViewpointCitation_Cond.dicFldComparisonOp[clsvViewpointCitationEN.con_PaperTitle];
strWhereCond += Format(" And {0} {2} '{1}'", clsvViewpointCitationEN.con_PaperTitle, objvViewpointCitation_Cond.paperTitle, strComparisonOp_PaperTitle);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objvViewpointCitation_Cond.dicFldComparisonOp, clsvViewpointCitationEN.con_UpdUserId) == true)
{
const strComparisonOp_UpdUserId:string = objvViewpointCitation_Cond.dicFldComparisonOp[clsvViewpointCitationEN.con_UpdUserId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvViewpointCitationEN.con_UpdUserId, objvViewpointCitation_Cond.updUserId, strComparisonOp_UpdUserId);
}
if (Object.prototype.hasOwnProperty.call(objvViewpointCitation_Cond.dicFldComparisonOp, clsvViewpointCitationEN.con_UserName) == true)
{
const strComparisonOp_UserName:string = objvViewpointCitation_Cond.dicFldComparisonOp[clsvViewpointCitationEN.con_UserName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvViewpointCitationEN.con_UserName, objvViewpointCitation_Cond.userName, strComparisonOp_UserName);
}
if (Object.prototype.hasOwnProperty.call(objvViewpointCitation_Cond.dicFldComparisonOp, clsvViewpointCitationEN.con_ViewpointId) == true)
{
const strComparisonOp_ViewpointId:string = objvViewpointCitation_Cond.dicFldComparisonOp[clsvViewpointCitationEN.con_ViewpointId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvViewpointCitationEN.con_ViewpointId, objvViewpointCitation_Cond.viewpointId, strComparisonOp_ViewpointId);
}
if (Object.prototype.hasOwnProperty.call(objvViewpointCitation_Cond.dicFldComparisonOp, clsvViewpointCitationEN.con_ViewpointName) == true)
{
const strComparisonOp_ViewpointName:string = objvViewpointCitation_Cond.dicFldComparisonOp[clsvViewpointCitationEN.con_ViewpointName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvViewpointCitationEN.con_ViewpointName, objvViewpointCitation_Cond.viewpointName, strComparisonOp_ViewpointName);
}
if (Object.prototype.hasOwnProperty.call(objvViewpointCitation_Cond.dicFldComparisonOp, clsvViewpointCitationEN.con_ViewpointTypeId) == true)
{
const strComparisonOp_ViewpointTypeId:string = objvViewpointCitation_Cond.dicFldComparisonOp[clsvViewpointCitationEN.con_ViewpointTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvViewpointCitationEN.con_ViewpointTypeId, objvViewpointCitation_Cond.viewpointTypeId, strComparisonOp_ViewpointTypeId);
}
if (Object.prototype.hasOwnProperty.call(objvViewpointCitation_Cond.dicFldComparisonOp, clsvViewpointCitationEN.con_ViewpointTypeName) == true)
{
const strComparisonOp_ViewpointTypeName:string = objvViewpointCitation_Cond.dicFldComparisonOp[clsvViewpointCitationEN.con_ViewpointTypeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvViewpointCitationEN.con_ViewpointTypeName, objvViewpointCitation_Cond.viewpointTypeName, strComparisonOp_ViewpointTypeName);
}
if (Object.prototype.hasOwnProperty.call(objvViewpointCitation_Cond.dicFldComparisonOp, clsvViewpointCitationEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objvViewpointCitation_Cond.dicFldComparisonOp[clsvViewpointCitationEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvViewpointCitationEN.con_UpdDate, objvViewpointCitation_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objvViewpointCitation_Cond.dicFldComparisonOp, clsvViewpointCitationEN.con_ProposePeople) == true)
{
const strComparisonOp_ProposePeople:string = objvViewpointCitation_Cond.dicFldComparisonOp[clsvViewpointCitationEN.con_ProposePeople];
strWhereCond += Format(" And {0} {2} '{1}'", clsvViewpointCitationEN.con_ProposePeople, objvViewpointCitation_Cond.proposePeople, strComparisonOp_ProposePeople);
}
if (Object.prototype.hasOwnProperty.call(objvViewpointCitation_Cond.dicFldComparisonOp, clsvViewpointCitationEN.con_Source) == true)
{
const strComparisonOp_Source:string = objvViewpointCitation_Cond.dicFldComparisonOp[clsvViewpointCitationEN.con_Source];
strWhereCond += Format(" And {0} {2} '{1}'", clsvViewpointCitationEN.con_Source, objvViewpointCitation_Cond.source, strComparisonOp_Source);
}
if (Object.prototype.hasOwnProperty.call(objvViewpointCitation_Cond.dicFldComparisonOp, clsvViewpointCitationEN.con_TopicId) == true)
{
const strComparisonOp_TopicId:string = objvViewpointCitation_Cond.dicFldComparisonOp[clsvViewpointCitationEN.con_TopicId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvViewpointCitationEN.con_TopicId, objvViewpointCitation_Cond.topicId, strComparisonOp_TopicId);
}
if (Object.prototype.hasOwnProperty.call(objvViewpointCitation_Cond.dicFldComparisonOp, clsvViewpointCitationEN.con_TopicName) == true)
{
const strComparisonOp_TopicName:string = objvViewpointCitation_Cond.dicFldComparisonOp[clsvViewpointCitationEN.con_TopicName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvViewpointCitationEN.con_TopicName, objvViewpointCitation_Cond.topicName, strComparisonOp_TopicName);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--vViewpointCitation(v观点引用),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param lngmId: mId(要求唯一的字段)
 * @param strPaperId: 论文Id(要求唯一的字段)
 * @param strViewpointId: 观点Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function vViewpointCitation_GetUniCondStr_mId_PaperId_ViewpointId(objvViewpointCitationEN: clsvViewpointCitationEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and mId = '{0}'", objvViewpointCitationEN.mId);
 strWhereCond +=  Format(" and PaperId = '{0}'", objvViewpointCitationEN.paperId);
 strWhereCond +=  Format(" and ViewpointId = '{0}'", objvViewpointCitationEN.viewpointId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--vViewpointCitation(v观点引用),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param lngmId: mId(要求唯一的字段)
 * @param strPaperId: 论文Id(要求唯一的字段)
 * @param strViewpointId: 观点Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function vViewpointCitation_GetUniCondStr4Update_mId_PaperId_ViewpointId(objvViewpointCitationEN: clsvViewpointCitationEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and mId <> '{0}'", objvViewpointCitationEN.mId);
 strWhereCond +=  Format(" and mId = '{0}'", objvViewpointCitationEN.mId);
 strWhereCond +=  Format(" and PaperId = '{0}'", objvViewpointCitationEN.paperId);
 strWhereCond +=  Format(" and ViewpointId = '{0}'", objvViewpointCitationEN.viewpointId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objvViewpointCitationENS:源对象
 * @param objvViewpointCitationENT:目标对象
*/
export function vViewpointCitation_CopyObjTo(objvViewpointCitationENS: clsvViewpointCitationEN , objvViewpointCitationENT: clsvViewpointCitationEN ): void 
{
objvViewpointCitationENT.memo = objvViewpointCitationENS.memo; //备注
objvViewpointCitationENT.mId = objvViewpointCitationENS.mId; //mId
objvViewpointCitationENT.paperContent = objvViewpointCitationENS.paperContent; //主题内容
objvViewpointCitationENT.paperId = objvViewpointCitationENS.paperId; //论文Id
objvViewpointCitationENT.paperTitle = objvViewpointCitationENS.paperTitle; //论文标题
objvViewpointCitationENT.reason = objvViewpointCitationENS.reason; //理由
objvViewpointCitationENT.updUserId = objvViewpointCitationENS.updUserId; //修改用户Id
objvViewpointCitationENT.userName = objvViewpointCitationENS.userName; //用户名
objvViewpointCitationENT.viewpointId = objvViewpointCitationENS.viewpointId; //观点Id
objvViewpointCitationENT.viewpointName = objvViewpointCitationENS.viewpointName; //观点名称
objvViewpointCitationENT.viewpointTypeId = objvViewpointCitationENS.viewpointTypeId; //观点类型Id
objvViewpointCitationENT.viewpointTypeName = objvViewpointCitationENS.viewpointTypeName; //观点类型名
objvViewpointCitationENT.updDate = objvViewpointCitationENS.updDate; //修改日期
objvViewpointCitationENT.proposePeople = objvViewpointCitationENS.proposePeople; //提出人
objvViewpointCitationENT.source = objvViewpointCitationENS.source; //来源
objvViewpointCitationENT.topicId = objvViewpointCitationENS.topicId; //主题Id
objvViewpointCitationENT.topicName = objvViewpointCitationENS.topicName; //栏目主题
objvViewpointCitationENT.sfUpdFldSetStr = objvViewpointCitationENS.updFldString; //sfUpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objvViewpointCitationENS:源对象
 * @param objvViewpointCitationENT:目标对象
*/
export function vViewpointCitation_GetObjFromJsonObj(objvViewpointCitationENS: clsvViewpointCitationEN): clsvViewpointCitationEN 
{
 const objvViewpointCitationENT: clsvViewpointCitationEN = new clsvViewpointCitationEN();
ObjectAssign(objvViewpointCitationENT, objvViewpointCitationENS);
 return objvViewpointCitationENT;
}