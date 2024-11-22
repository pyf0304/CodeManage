﻿
 /**
 * 类名:clsgs_ResearchPlanWApi
 * 表名:gs_ResearchPlan(01120663)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:49:38
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
 * 主题研究计划(gs_ResearchPlan)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2023年03月13日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { enumComparisonOp } from "../../PubFun/enumComparisonOp.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { clsgs_ResearchPlanEN } from "../../L0_Entity/GraduateEduTopic/clsgs_ResearchPlanEN.js";
import { vgs_ResearchPlan_ReFreshThisCache } from "../../L3_ForWApi/GraduateEduTopic/clsvgs_ResearchPlanWApi.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { tzDataType } from "../../PubFun/clsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const gs_ResearchPlan_Controller = "gs_ResearchPlanApi";
 export const gs_ResearchPlan_ConstructorName = "gs_ResearchPlan";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strPlanId:关键字
 * @returns 对象
 **/
export async function gs_ResearchPlan_GetObjByPlanIdAsync(strPlanId: string): Promise<clsgs_ResearchPlanEN|null>  
{
const strThisFuncName = "GetObjByPlanIdAsync";

if (IsNullOrEmpty(strPlanId) == true)
{
  const strMsg = Format("参数:[strPlanId]不能为空！(In clsgs_ResearchPlanWApi.GetObjByPlanIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strPlanId.length != 8)
{
const strMsg = Format("缓存分类变量:[strPlanId]的长度:[{0}]不正确！(clsgs_ResearchPlanWApi.GetObjByPlanIdAsync)", strPlanId.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByPlanId";
const strUrl = GetWebApiUrl(gs_ResearchPlan_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strPlanId": strPlanId,
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
const objgs_ResearchPlan = gs_ResearchPlan_GetObjFromJsonObj(returnObj);
return objgs_ResearchPlan;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchPlan_ConstructorName, strThisFuncName);
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
 * 根据关键字获取相关对象, 从缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
 * @param strPlanId:所给的关键字
 * @returns 对象
*/
export async function gs_ResearchPlan_GetObjByPlanId_Cache(strPlanId:string,strid_CurrEduCls:string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByPlanId_Cache";

if (IsNullOrEmpty(strPlanId) == true)
{
  const strMsg = Format("参数:[strPlanId]不能为空！(In clsgs_ResearchPlanWApi.GetObjByPlanId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strPlanId.length != 8)
{
const strMsg = Format("缓存分类变量:[strPlanId]的长度:[{0}]不正确！(clsgs_ResearchPlanWApi.GetObjByPlanId_Cache)", strPlanId.length);
console.error(strMsg);
throw (strMsg);
}
const arrgs_ResearchPlanObjLst_Cache = await gs_ResearchPlan_GetObjLst_Cache(strid_CurrEduCls);
try
{
const arrgs_ResearchPlan_Sel: Array <clsgs_ResearchPlanEN> = arrgs_ResearchPlanObjLst_Cache.filter(x => 
 x.planId == strPlanId );
let objgs_ResearchPlan: clsgs_ResearchPlanEN;
if (arrgs_ResearchPlan_Sel.length > 0)
{
objgs_ResearchPlan = arrgs_ResearchPlan_Sel[0];
return objgs_ResearchPlan;
}
else
{
if (bolTryAsyncOnce == true)
{
const objgs_ResearchPlan_Const = await gs_ResearchPlan_GetObjByPlanIdAsync(strPlanId);
if (objgs_ResearchPlan_Const != null)
{
gs_ResearchPlan_ReFreshThisCache(strid_CurrEduCls);
return objgs_ResearchPlan_Const;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strPlanId, gs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param strPlanId:所给的关键字
 * @returns 对象
*/
export async function gs_ResearchPlan_GetObjByPlanId_localStorage(strPlanId: string) {
const strThisFuncName = "GetObjByPlanId_localStorage";

if (IsNullOrEmpty(strPlanId) == true)
{
  const strMsg = Format("参数:[strPlanId]不能为空！(In clsgs_ResearchPlanWApi.GetObjByPlanId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
if (strPlanId.length != 8)
{
const strMsg = Format("缓存分类变量:[strPlanId]的长度:[{0}]不正确！(clsgs_ResearchPlanWApi.GetObjByPlanId_localStorage)", strPlanId.length);
console.error(strMsg);
throw (strMsg);
}
const strKey = Format("{0}_{1}", clsgs_ResearchPlanEN._CurrTabName, strPlanId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objgs_ResearchPlan_Cache: clsgs_ResearchPlanEN = JSON.parse(strTempObj);
return objgs_ResearchPlan_Cache;
}
try
{
const objgs_ResearchPlan = await gs_ResearchPlan_GetObjByPlanIdAsync(strPlanId);
if (objgs_ResearchPlan != null)
{
localStorage.setItem(strKey, JSON.stringify(objgs_ResearchPlan));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objgs_ResearchPlan;
}
return objgs_ResearchPlan;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strPlanId, gs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objgs_ResearchPlan:所给的对象
 * @returns 对象
*/
export async function gs_ResearchPlan_UpdateObjInLst_Cache(objgs_ResearchPlan: clsgs_ResearchPlanEN,strid_CurrEduCls: string) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrgs_ResearchPlanObjLst_Cache = await gs_ResearchPlan_GetObjLst_Cache(strid_CurrEduCls);
const obj = arrgs_ResearchPlanObjLst_Cache.find(x => x.planId == objgs_ResearchPlan.planId);
if (obj != null)
{
objgs_ResearchPlan.planId = obj.planId;
ObjectAssign( obj, objgs_ResearchPlan);
}
else
{
arrgs_ResearchPlanObjLst_Cache.push(objgs_ResearchPlan);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, gs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
}
/*该表没有名称字段，不能生成此函数！*/

/**
 * 映射函数。根据表映射把输入字段值，映射成输出字段值
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
 * @param strInFldName:输入字段名
 * @param strOutFldName:输出字段名
 * @param strInValue:输入字段值
 @param strid_CurrEduCls:缓存的分类字段
 * @returns 返回一个输出字段值
*/
export async function gs_ResearchPlan_func(strInFldName:string , strOutFldName:string , strInValue:string 
, strid_CurrEduCls_C: string)
{
//const strThisFuncName = "func";

if (IsNullOrEmpty(strid_CurrEduCls_C) == true)
{
  const strMsg = Format("参数:[strid_CurrEduCls_C]不能为空！(In clsgs_ResearchPlanWApi.func)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_CurrEduCls_C.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsgs_ResearchPlanWApi.func)", strid_CurrEduCls_C.length);
console.error(strMsg);
throw (strMsg);
}

if (strInFldName != clsgs_ResearchPlanEN.con_PlanId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsgs_ResearchPlanEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strOutFldName, clsgs_ResearchPlanEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strPlanId = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objgs_ResearchPlan = await gs_ResearchPlan_GetObjByPlanId_Cache(strPlanId , strid_CurrEduCls_C);
if (objgs_ResearchPlan == null) return "";
if (objgs_ResearchPlan.GetFldValue(strOutFldName) == null) return "";
return objgs_ResearchPlan.GetFldValue(strOutFldName).toString();
}

/**
 * 排序函数。根据关键字字段的值进行比较
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
 * @param a:比较的第1个对象
 * @param  b:比较的第1个对象
 * @returns 返回两个对象比较的结果
*/
export function gs_ResearchPlan_SortFun_Defa(a:clsgs_ResearchPlanEN , b:clsgs_ResearchPlanEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.planId.localeCompare(b.planId);
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
export function gs_ResearchPlan_SortFun_Defa_2Fld(a:clsgs_ResearchPlanEN , b:clsgs_ResearchPlanEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.topicId == b.topicId) return a.statusId.localeCompare(b.statusId);
else return a.topicId.localeCompare(b.topicId);
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
export function gs_ResearchPlan_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsgs_ResearchPlanEN.con_PlanId:
return (a: clsgs_ResearchPlanEN, b: clsgs_ResearchPlanEN) => {
return a.planId.localeCompare(b.planId);
}
case clsgs_ResearchPlanEN.con_TopicId:
return (a: clsgs_ResearchPlanEN, b: clsgs_ResearchPlanEN) => {
return a.topicId.localeCompare(b.topicId);
}
case clsgs_ResearchPlanEN.con_StatusId:
return (a: clsgs_ResearchPlanEN, b: clsgs_ResearchPlanEN) => {
return a.statusId.localeCompare(b.statusId);
}
case clsgs_ResearchPlanEN.con_PlanContent:
return (a: clsgs_ResearchPlanEN, b: clsgs_ResearchPlanEN) => {
if (a.planContent == null) return -1;
if (b.planContent == null) return 1;
return a.planContent.localeCompare(b.planContent);
}
case clsgs_ResearchPlanEN.con_ResponsibleUser:
return (a: clsgs_ResearchPlanEN, b: clsgs_ResearchPlanEN) => {
if (a.responsibleUser == null) return -1;
if (b.responsibleUser == null) return 1;
return a.responsibleUser.localeCompare(b.responsibleUser);
}
case clsgs_ResearchPlanEN.con_StartDate:
return (a: clsgs_ResearchPlanEN, b: clsgs_ResearchPlanEN) => {
if (a.startDate == null) return -1;
if (b.startDate == null) return 1;
return a.startDate.localeCompare(b.startDate);
}
case clsgs_ResearchPlanEN.con_EndDate:
return (a: clsgs_ResearchPlanEN, b: clsgs_ResearchPlanEN) => {
if (a.endDate == null) return -1;
if (b.endDate == null) return 1;
return a.endDate.localeCompare(b.endDate);
}
case clsgs_ResearchPlanEN.con_ActualFinishingDate:
return (a: clsgs_ResearchPlanEN, b: clsgs_ResearchPlanEN) => {
if (a.actualFinishingDate == null) return -1;
if (b.actualFinishingDate == null) return 1;
return a.actualFinishingDate.localeCompare(b.actualFinishingDate);
}
case clsgs_ResearchPlanEN.con_AcceptanceUser:
return (a: clsgs_ResearchPlanEN, b: clsgs_ResearchPlanEN) => {
if (a.acceptanceUser == null) return -1;
if (b.acceptanceUser == null) return 1;
return a.acceptanceUser.localeCompare(b.acceptanceUser);
}
case clsgs_ResearchPlanEN.con_IsSubmit:
return (a: clsgs_ResearchPlanEN, b: clsgs_ResearchPlanEN) => {
if (a.isSubmit == true) return 1;
else return -1
}
case clsgs_ResearchPlanEN.con_UpdUser:
return (a: clsgs_ResearchPlanEN, b: clsgs_ResearchPlanEN) => {
if (a.updUser == null) return -1;
if (b.updUser == null) return 1;
return a.updUser.localeCompare(b.updUser);
}
case clsgs_ResearchPlanEN.con_UpdDate:
return (a: clsgs_ResearchPlanEN, b: clsgs_ResearchPlanEN) => {
if (a.updDate == null) return -1;
if (b.updDate == null) return 1;
return a.updDate.localeCompare(b.updDate);
}
case clsgs_ResearchPlanEN.con_Memo:
return (a: clsgs_ResearchPlanEN, b: clsgs_ResearchPlanEN) => {
if (a.memo == null) return -1;
if (b.memo == null) return 1;
return a.memo.localeCompare(b.memo);
}
case clsgs_ResearchPlanEN.con_PlanTypeId:
return (a: clsgs_ResearchPlanEN, b: clsgs_ResearchPlanEN) => {
if (a.planTypeId == null) return -1;
if (b.planTypeId == null) return 1;
return a.planTypeId.localeCompare(b.planTypeId);
}
case clsgs_ResearchPlanEN.con_id_CurrEduCls:
return (a: clsgs_ResearchPlanEN, b: clsgs_ResearchPlanEN) => {
if (a.id_CurrEduCls == null) return -1;
if (b.id_CurrEduCls == null) return 1;
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_ResearchPlan]中不存在！(in ${ gs_ResearchPlan_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsgs_ResearchPlanEN.con_PlanId:
return (a: clsgs_ResearchPlanEN, b: clsgs_ResearchPlanEN) => {
return b.planId.localeCompare(a.planId);
}
case clsgs_ResearchPlanEN.con_TopicId:
return (a: clsgs_ResearchPlanEN, b: clsgs_ResearchPlanEN) => {
return b.topicId.localeCompare(a.topicId);
}
case clsgs_ResearchPlanEN.con_StatusId:
return (a: clsgs_ResearchPlanEN, b: clsgs_ResearchPlanEN) => {
return b.statusId.localeCompare(a.statusId);
}
case clsgs_ResearchPlanEN.con_PlanContent:
return (a: clsgs_ResearchPlanEN, b: clsgs_ResearchPlanEN) => {
if (b.planContent == null) return -1;
if (a.planContent == null) return 1;
return b.planContent.localeCompare(a.planContent);
}
case clsgs_ResearchPlanEN.con_ResponsibleUser:
return (a: clsgs_ResearchPlanEN, b: clsgs_ResearchPlanEN) => {
if (b.responsibleUser == null) return -1;
if (a.responsibleUser == null) return 1;
return b.responsibleUser.localeCompare(a.responsibleUser);
}
case clsgs_ResearchPlanEN.con_StartDate:
return (a: clsgs_ResearchPlanEN, b: clsgs_ResearchPlanEN) => {
if (b.startDate == null) return -1;
if (a.startDate == null) return 1;
return b.startDate.localeCompare(a.startDate);
}
case clsgs_ResearchPlanEN.con_EndDate:
return (a: clsgs_ResearchPlanEN, b: clsgs_ResearchPlanEN) => {
if (b.endDate == null) return -1;
if (a.endDate == null) return 1;
return b.endDate.localeCompare(a.endDate);
}
case clsgs_ResearchPlanEN.con_ActualFinishingDate:
return (a: clsgs_ResearchPlanEN, b: clsgs_ResearchPlanEN) => {
if (b.actualFinishingDate == null) return -1;
if (a.actualFinishingDate == null) return 1;
return b.actualFinishingDate.localeCompare(a.actualFinishingDate);
}
case clsgs_ResearchPlanEN.con_AcceptanceUser:
return (a: clsgs_ResearchPlanEN, b: clsgs_ResearchPlanEN) => {
if (b.acceptanceUser == null) return -1;
if (a.acceptanceUser == null) return 1;
return b.acceptanceUser.localeCompare(a.acceptanceUser);
}
case clsgs_ResearchPlanEN.con_IsSubmit:
return (a: clsgs_ResearchPlanEN, b: clsgs_ResearchPlanEN) => {
if (b.isSubmit == true) return 1;
else return -1
}
case clsgs_ResearchPlanEN.con_UpdUser:
return (a: clsgs_ResearchPlanEN, b: clsgs_ResearchPlanEN) => {
if (b.updUser == null) return -1;
if (a.updUser == null) return 1;
return b.updUser.localeCompare(a.updUser);
}
case clsgs_ResearchPlanEN.con_UpdDate:
return (a: clsgs_ResearchPlanEN, b: clsgs_ResearchPlanEN) => {
if (b.updDate == null) return -1;
if (a.updDate == null) return 1;
return b.updDate.localeCompare(a.updDate);
}
case clsgs_ResearchPlanEN.con_Memo:
return (a: clsgs_ResearchPlanEN, b: clsgs_ResearchPlanEN) => {
if (b.memo == null) return -1;
if (a.memo == null) return 1;
return b.memo.localeCompare(a.memo);
}
case clsgs_ResearchPlanEN.con_PlanTypeId:
return (a: clsgs_ResearchPlanEN, b: clsgs_ResearchPlanEN) => {
if (b.planTypeId == null) return -1;
if (a.planTypeId == null) return 1;
return b.planTypeId.localeCompare(a.planTypeId);
}
case clsgs_ResearchPlanEN.con_id_CurrEduCls:
return (a: clsgs_ResearchPlanEN, b: clsgs_ResearchPlanEN) => {
if (b.id_CurrEduCls == null) return -1;
if (a.id_CurrEduCls == null) return 1;
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_ResearchPlan]中不存在！(in ${ gs_ResearchPlan_ConstructorName}.${ strThisFuncName})`;
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
export async function gs_ResearchPlan_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsgs_ResearchPlanEN.con_PlanId:
return (obj: clsgs_ResearchPlanEN) => {
return obj.planId === value;
}
case clsgs_ResearchPlanEN.con_TopicId:
return (obj: clsgs_ResearchPlanEN) => {
return obj.topicId === value;
}
case clsgs_ResearchPlanEN.con_StatusId:
return (obj: clsgs_ResearchPlanEN) => {
return obj.statusId === value;
}
case clsgs_ResearchPlanEN.con_PlanContent:
return (obj: clsgs_ResearchPlanEN) => {
return obj.planContent === value;
}
case clsgs_ResearchPlanEN.con_ResponsibleUser:
return (obj: clsgs_ResearchPlanEN) => {
return obj.responsibleUser === value;
}
case clsgs_ResearchPlanEN.con_StartDate:
return (obj: clsgs_ResearchPlanEN) => {
return obj.startDate === value;
}
case clsgs_ResearchPlanEN.con_EndDate:
return (obj: clsgs_ResearchPlanEN) => {
return obj.endDate === value;
}
case clsgs_ResearchPlanEN.con_ActualFinishingDate:
return (obj: clsgs_ResearchPlanEN) => {
return obj.actualFinishingDate === value;
}
case clsgs_ResearchPlanEN.con_AcceptanceUser:
return (obj: clsgs_ResearchPlanEN) => {
return obj.acceptanceUser === value;
}
case clsgs_ResearchPlanEN.con_IsSubmit:
return (obj: clsgs_ResearchPlanEN) => {
return obj.isSubmit === value;
}
case clsgs_ResearchPlanEN.con_UpdUser:
return (obj: clsgs_ResearchPlanEN) => {
return obj.updUser === value;
}
case clsgs_ResearchPlanEN.con_UpdDate:
return (obj: clsgs_ResearchPlanEN) => {
return obj.updDate === value;
}
case clsgs_ResearchPlanEN.con_Memo:
return (obj: clsgs_ResearchPlanEN) => {
return obj.memo === value;
}
case clsgs_ResearchPlanEN.con_PlanTypeId:
return (obj: clsgs_ResearchPlanEN) => {
return obj.planTypeId === value;
}
case clsgs_ResearchPlanEN.con_id_CurrEduCls:
return (obj: clsgs_ResearchPlanEN) => {
return obj.id_CurrEduCls === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_ResearchPlan]中不存在！(in ${ gs_ResearchPlan_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
}

/**
 * 映射函数。根据表映射把输入字段值，映射成输出字段值
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_funcKey)
 * @param strInFldName:输入字段名
 * @param strInValue:输入字段值
 * @param strComparisonOp:比较操作符
 @param strid_CurrEduCls:缓存的分类字段
 * @returns 返回一个关键字值列表
*/
export async function gs_ResearchPlan_funcKey(strInFldName:string, strInValue: any, strComparisonOp:string, strid_CurrEduCls_C: string): Promise<Array<string>>
{
//const strThisFuncName = "funcKey";

if (IsNullOrEmpty(strid_CurrEduCls_C) == true)
{
  const strMsg = Format("参数:[strid_CurrEduCls_C]不能为空！(In clsgs_ResearchPlanWApi.funcKey)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_CurrEduCls_C.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsgs_ResearchPlanWApi.funcKey)", strid_CurrEduCls_C.length);
console.error(strMsg);
throw (strMsg);
}

if (strInFldName == clsgs_ResearchPlanEN.con_PlanId)
{
const strMsg = Format("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (IsNullOrEmpty(strInValue) == true)
{
return [];
}
const arrgs_ResearchPlan = await gs_ResearchPlan_GetObjLst_Cache(strid_CurrEduCls_C);
if (arrgs_ResearchPlan == null) return [];
let arrgs_ResearchPlan_Sel = arrgs_ResearchPlan;
const strType = typeof(strInValue);
switch (strType)
{
case "string":
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01: // " = "
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
break;
case enumComparisonOp.Like_03:
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
break;
case enumComparisonOp.In_04:
const arrValues = strInValue.split(',');
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
break;
}
break;
case "boolean":
if (strInValue == null) return [];
if (strComparisonOp == enumComparisonOp.Equal_01)
{
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
}
break;
case "number":
if (Number(strInValue) == 0) return [];
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01:
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
break;
case enumComparisonOp.NotEqual_02:
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
break;
case enumComparisonOp.NotLessThan_05://" >= ":
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
break;
case enumComparisonOp.NotGreaterThan_06://" <= ":
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
case enumComparisonOp.GreaterThan_07://" > ":
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
break;
case enumComparisonOp.LessThan_08://" < ":
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
}
break;
}
if (arrgs_ResearchPlan_Sel.length == 0) return [];
return arrgs_ResearchPlan_Sel.map(x=>x.planId);
}

 /**
 * 根据条件获取满足条件的第一条记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
 * @param strWhereCond:条件
 * @returns 返回的第一条记录的关键字值
 **/
export async function gs_ResearchPlan_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(gs_ResearchPlan_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchPlan_ConstructorName, strThisFuncName);
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
export async function gs_ResearchPlan_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(gs_ResearchPlan_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchPlan_ConstructorName, strThisFuncName);
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
export async function gs_ResearchPlan_GetFirstObjAsync(strWhereCond: string): Promise<clsgs_ResearchPlanEN|null>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(gs_ResearchPlan_Controller, strAction);
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
const objgs_ResearchPlan = gs_ResearchPlan_GetObjFromJsonObj(returnObj);
return objgs_ResearchPlan;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchPlan_ConstructorName, strThisFuncName);
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
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_ResearchPlan_GetObjLst_ClientCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
if (IsNullOrEmpty(clsgs_ResearchPlanEN.WhereFormat) == false)
{
strWhereCond = Format(clsgs_ResearchPlanEN.WhereFormat, strid_CurrEduCls);
}
else
{
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
}
const strKey = Format("{0}_{1}", clsgs_ResearchPlanEN._CurrTabName, strid_CurrEduCls);
if (IsNullOrEmpty(clsgs_ResearchPlanEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsgs_ResearchPlanEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrgs_ResearchPlanExObjLst_Cache: Array<clsgs_ResearchPlanEN> = CacheHelper.Get(strKey);
const arrgs_ResearchPlanObjLst_T = gs_ResearchPlan_GetObjLstByJSONObjLst(arrgs_ResearchPlanExObjLst_Cache);
return arrgs_ResearchPlanObjLst_T;
}
try
{
const arrgs_ResearchPlanExObjLst = await gs_ResearchPlan_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrgs_ResearchPlanExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_ResearchPlanExObjLst.length);
console.log(strInfo);
return arrgs_ResearchPlanExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, gs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_ResearchPlan_GetObjLst_localStorage(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
if (IsNullOrEmpty(clsgs_ResearchPlanEN.WhereFormat) == false)
{
strWhereCond = Format(clsgs_ResearchPlanEN.WhereFormat, strid_CurrEduCls);
}
else
{
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
}
const strKey = Format("{0}_{1}", clsgs_ResearchPlanEN._CurrTabName, strid_CurrEduCls);
if (IsNullOrEmpty(clsgs_ResearchPlanEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsgs_ResearchPlanEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrgs_ResearchPlanExObjLst_Cache: Array<clsgs_ResearchPlanEN> = JSON.parse(strTempObjLst);
const arrgs_ResearchPlanObjLst_T = gs_ResearchPlan_GetObjLstByJSONObjLst(arrgs_ResearchPlanExObjLst_Cache);
return arrgs_ResearchPlanObjLst_T;
}
try
{
const arrgs_ResearchPlanExObjLst = await gs_ResearchPlan_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrgs_ResearchPlanExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_ResearchPlanExObjLst.length);
console.log(strInfo);
return arrgs_ResearchPlanExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, gs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_ResearchPlan_GetObjLst_localStorage_PureCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsgs_ResearchPlanEN._CurrTabName, strid_CurrEduCls);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrgs_ResearchPlanObjLst_Cache: Array<clsgs_ResearchPlanEN> = JSON.parse(strTempObjLst);
return arrgs_ResearchPlanObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function gs_ResearchPlan_GetObjLstAsync(strWhereCond: string): Promise<Array<clsgs_ResearchPlanEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(gs_ResearchPlan_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_ResearchPlan_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchPlan_ConstructorName, strThisFuncName);
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
 * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_ResearchPlan_GetObjLst_sessionStorage(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
if (IsNullOrEmpty(clsgs_ResearchPlanEN.WhereFormat) == false)
{
strWhereCond = Format(clsgs_ResearchPlanEN.WhereFormat, strid_CurrEduCls);
}
else
{
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
}
const strKey = Format("{0}_{1}", clsgs_ResearchPlanEN._CurrTabName, strid_CurrEduCls);
if (IsNullOrEmpty(clsgs_ResearchPlanEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsgs_ResearchPlanEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrgs_ResearchPlanExObjLst_Cache: Array<clsgs_ResearchPlanEN> = JSON.parse(strTempObjLst);
const arrgs_ResearchPlanObjLst_T = gs_ResearchPlan_GetObjLstByJSONObjLst(arrgs_ResearchPlanExObjLst_Cache);
return arrgs_ResearchPlanObjLst_T;
}
try
{
const arrgs_ResearchPlanExObjLst = await gs_ResearchPlan_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrgs_ResearchPlanExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_ResearchPlanExObjLst.length);
console.log(strInfo);
return arrgs_ResearchPlanExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, gs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_ResearchPlan_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsgs_ResearchPlanEN._CurrTabName, strid_CurrEduCls);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrgs_ResearchPlanObjLst_Cache: Array<clsgs_ResearchPlanEN> = JSON.parse(strTempObjLst);
return arrgs_ResearchPlanObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_ResearchPlan_GetObjLst_Cache(strid_CurrEduCls: string): Promise<Array<clsgs_ResearchPlanEN>>
{
//const strThisFuncName = "GetObjLst_Cache";

if (IsNullOrEmpty(strid_CurrEduCls) == true)
{
const strMsg = Format("缓存分类变量:[id_CurrEduCls]不能为空！(in clsgs_ResearchPlanWApi.gs_ResearchPlan_GetObjLst_Cache() )");
console.error(strMsg);
throw (strMsg);
}
if (strid_CurrEduCls.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(in clsgs_ResearchPlanWApi.gs_ResearchPlan_GetObjLst_Cache() )", strid_CurrEduCls.length);
console.error(strMsg);
throw (strMsg);
}
let arrgs_ResearchPlanObjLst_Cache;
switch (clsgs_ResearchPlanEN.CacheModeId)
{
case "04"://sessionStorage
arrgs_ResearchPlanObjLst_Cache = await gs_ResearchPlan_GetObjLst_sessionStorage(strid_CurrEduCls);
break;
case "03"://localStorage
arrgs_ResearchPlanObjLst_Cache = await gs_ResearchPlan_GetObjLst_localStorage(strid_CurrEduCls);
break;
case "02"://ClientCache
arrgs_ResearchPlanObjLst_Cache = await gs_ResearchPlan_GetObjLst_ClientCache(strid_CurrEduCls);
break;
default:
arrgs_ResearchPlanObjLst_Cache = await gs_ResearchPlan_GetObjLst_ClientCache(strid_CurrEduCls);
break;
}
const arrgs_ResearchPlanObjLst = gs_ResearchPlan_GetObjLstByJSONObjLst(arrgs_ResearchPlanObjLst_Cache);
return arrgs_ResearchPlanObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_ResearchPlan_GetObjLst_PureCache(strid_CurrEduCls: string)
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrgs_ResearchPlanObjLst_Cache;
switch (clsgs_ResearchPlanEN.CacheModeId)
{
case "04"://sessionStorage
arrgs_ResearchPlanObjLst_Cache = await gs_ResearchPlan_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls);
break;
case "03"://localStorage
arrgs_ResearchPlanObjLst_Cache = await gs_ResearchPlan_GetObjLst_localStorage_PureCache(strid_CurrEduCls);
break;
case "02"://ClientCache
arrgs_ResearchPlanObjLst_Cache = null;
break;
default:
arrgs_ResearchPlanObjLst_Cache = null;
break;
}
return arrgs_ResearchPlanObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrPlanId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function gs_ResearchPlan_GetSubObjLst_Cache(objgs_ResearchPlan_Cond: clsgs_ResearchPlanEN,strid_CurrEduCls: string) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrgs_ResearchPlanObjLst_Cache = await gs_ResearchPlan_GetObjLst_Cache(strid_CurrEduCls);
let arrgs_ResearchPlan_Sel: Array < clsgs_ResearchPlanEN > = arrgs_ResearchPlanObjLst_Cache;
if (objgs_ResearchPlan_Cond.sf_FldComparisonOp == null || objgs_ResearchPlan_Cond.sf_FldComparisonOp == "") return arrgs_ResearchPlan_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_ResearchPlan_Cond.sf_FldComparisonOp);
//console.log("clsgs_ResearchPlanWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objgs_ResearchPlan_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_ResearchPlan_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrgs_ResearchPlan_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objgs_ResearchPlan_Cond), gs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsgs_ResearchPlanEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrPlanId:关键字列表
 * @returns 对象列表
 **/
export async function gs_ResearchPlan_GetObjLstByPlanIdLstAsync(arrPlanId: Array<string>): Promise<Array<clsgs_ResearchPlanEN>>  
{
const strThisFuncName = "GetObjLstByPlanIdLstAsync";
const strAction = "GetObjLstByPlanIdLst";
const strUrl = GetWebApiUrl(gs_ResearchPlan_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrPlanId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_ResearchPlan_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchPlan_ConstructorName, strThisFuncName);
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
 * 根据关键字列表获取相关对象列表, 从缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
 * @param arrstrPlanIdLst:关键字列表
 * @returns 对象列表
*/
export async function gs_ResearchPlan_GetObjLstByPlanIdLst_Cache(arrPlanIdLst: Array<string>,strid_CurrEduCls: string) {
const strThisFuncName = "GetObjLstByPlanIdLst_Cache";
try
{
const arrgs_ResearchPlanObjLst_Cache = await gs_ResearchPlan_GetObjLst_Cache(strid_CurrEduCls);
const arrgs_ResearchPlan_Sel: Array <clsgs_ResearchPlanEN> = arrgs_ResearchPlanObjLst_Cache.filter(x => arrPlanIdLst.indexOf(x.planId)>-1);
return arrgs_ResearchPlan_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrPlanIdLst.join(","), gs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function gs_ResearchPlan_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsgs_ResearchPlanEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(gs_ResearchPlan_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_ResearchPlan_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchPlan_ConstructorName, strThisFuncName);
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
export async function gs_ResearchPlan_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsgs_ResearchPlanEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(gs_ResearchPlan_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_ResearchPlan_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchPlan_ConstructorName, strThisFuncName);
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
export async function gs_ResearchPlan_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(gs_ResearchPlan_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchPlan_ConstructorName, strThisFuncName);
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
 * 根据分页条件从缓存中获取分页对象列表，只获取一页.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
 * @param objPagerPara:分页参数结构
 * @returns 对象列表
*/
export async function gs_ResearchPlan_GetObjLstByPager_Cache(objPagerPara: stuPagerPara,strid_CurrEduCls: string) {
const strThisFuncName = "GetObjLstByPager_Cache";
if (objPagerPara.pageIndex == 0) return new Array<clsgs_ResearchPlanEN>();
const arrgs_ResearchPlanObjLst_Cache = await gs_ResearchPlan_GetObjLst_Cache(strid_CurrEduCls);
if (arrgs_ResearchPlanObjLst_Cache.length == 0) return arrgs_ResearchPlanObjLst_Cache;
let arrgs_ResearchPlan_Sel = arrgs_ResearchPlanObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objgs_ResearchPlan_Cond = new clsgs_ResearchPlanEN();
ObjectAssign(objgs_ResearchPlan_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsgs_ResearchPlanWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_ResearchPlan_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrgs_ResearchPlan_Sel.length == 0) return arrgs_ResearchPlan_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.sort(gs_ResearchPlan_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.sort(objPagerPara.sortFun);
}
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.slice(intStart, intEnd);     
return arrgs_ResearchPlan_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, gs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsgs_ResearchPlanEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function gs_ResearchPlan_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsgs_ResearchPlanEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
if (objPagerPara.pageIndex == 0) return new Array<clsgs_ResearchPlanEN>();
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(gs_ResearchPlan_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_ResearchPlan_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchPlan_ConstructorName, strThisFuncName);
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
 * @param strPlanId:关键字
 * @returns 获取删除的结果
 **/
export async function gs_ResearchPlan_DelRecordAsync(strPlanId: string): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(gs_ResearchPlan_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, strPlanId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchPlan_ConstructorName, strThisFuncName);
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
 * @param arrPlanId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function gs_ResearchPlan_Delgs_ResearchPlansAsync(arrPlanId: Array<string>): Promise<number> 
{
const strThisFuncName = "Delgs_ResearchPlansAsync";
const strAction = "Delgs_ResearchPlans";
const strUrl = GetWebApiUrl(gs_ResearchPlan_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrPlanId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchPlan_ConstructorName, strThisFuncName);
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
export async function gs_ResearchPlan_Delgs_ResearchPlansByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "Delgs_ResearchPlansByCondAsync";
const strAction = "Delgs_ResearchPlansByCond";
const strUrl = GetWebApiUrl(gs_ResearchPlan_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchPlan_ConstructorName, strThisFuncName);
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
 * @param objgs_ResearchPlanEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_ResearchPlan_AddNewRecordAsync(objgs_ResearchPlanEN: clsgs_ResearchPlanEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objgs_ResearchPlanEN);
const strUrl = GetWebApiUrl(gs_ResearchPlan_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_ResearchPlanEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchPlan_ConstructorName, strThisFuncName);
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
 * @param objgs_ResearchPlanEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_ResearchPlan_AddNewRecordWithMaxIdAsync(objgs_ResearchPlanEN: clsgs_ResearchPlanEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithMaxIdAsync";
const strAction = "AddNewRecordWithMaxId";
const strUrl = GetWebApiUrl(gs_ResearchPlan_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_ResearchPlanEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchPlan_ConstructorName, strThisFuncName);
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
 * @param objgs_ResearchPlanEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function gs_ResearchPlan_AddNewRecordWithReturnKeyAsync(objgs_ResearchPlanEN: clsgs_ResearchPlanEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(gs_ResearchPlan_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_ResearchPlanEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchPlan_ConstructorName, strThisFuncName);
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
 * @param objgs_ResearchPlanEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function gs_ResearchPlan_AddNewRecordWithReturnKey(objgs_ResearchPlanEN: clsgs_ResearchPlanEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objgs_ResearchPlanEN.planId === null || objgs_ResearchPlanEN.planId === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(gs_ResearchPlan_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_ResearchPlanEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchPlan_ConstructorName, strThisFuncName);
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
 * @param objgs_ResearchPlanEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function gs_ResearchPlan_UpdateRecordAsync(objgs_ResearchPlanEN: clsgs_ResearchPlanEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objgs_ResearchPlanEN.sfUpdFldSetStr === undefined || objgs_ResearchPlanEN.sfUpdFldSetStr === null || objgs_ResearchPlanEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_ResearchPlanEN.planId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(gs_ResearchPlan_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_ResearchPlanEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchPlan_ConstructorName, strThisFuncName);
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
 * @param objgs_ResearchPlanEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function gs_ResearchPlan_UpdateWithConditionAsync(objgs_ResearchPlanEN: clsgs_ResearchPlanEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objgs_ResearchPlanEN.sfUpdFldSetStr === undefined || objgs_ResearchPlanEN.sfUpdFldSetStr === null || objgs_ResearchPlanEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_ResearchPlanEN.planId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(gs_ResearchPlan_Controller, strAction);
objgs_ResearchPlanEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objgs_ResearchPlanEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchPlan_ConstructorName, strThisFuncName);
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
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
 * @param objstrPlanId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function gs_ResearchPlan_IsExistRecord_Cache(objgs_ResearchPlan_Cond: clsgs_ResearchPlanEN,strid_CurrEduCls: string) {
const strThisFuncName = "IsExistRecord_Cache";
const arrgs_ResearchPlanObjLst_Cache = await gs_ResearchPlan_GetObjLst_Cache(strid_CurrEduCls);
if (arrgs_ResearchPlanObjLst_Cache == null) return false;
let arrgs_ResearchPlan_Sel: Array < clsgs_ResearchPlanEN > = arrgs_ResearchPlanObjLst_Cache;
if (objgs_ResearchPlan_Cond.sf_FldComparisonOp == null || objgs_ResearchPlan_Cond.sf_FldComparisonOp == "") return arrgs_ResearchPlan_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_ResearchPlan_Cond.sf_FldComparisonOp);
//console.log("clsgs_ResearchPlanWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objgs_ResearchPlan_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_ResearchPlan_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrgs_ResearchPlan_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objgs_ResearchPlan_Cond), gs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return false;
}

 /**
 * 根据条件获取是否存在相应的记录？
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
 * @param strWhereCond:条件
 * @returns 是否存在记录？
 **/
export async function gs_ResearchPlan_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(gs_ResearchPlan_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchPlan_ConstructorName, strThisFuncName);
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
 * @param strPlanId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function gs_ResearchPlan_IsExist(strPlanId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(gs_ResearchPlan_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"PlanId": strPlanId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchPlan_ConstructorName, strThisFuncName);
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
 * 根据关键字判断是否存在记录, 从本地缓存中判断.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
 * @param strPlanId:所给的关键字
 * @returns 对象
*/
export async function gs_ResearchPlan_IsExist_Cache(strPlanId:string,strid_CurrEduCls:string) {
const strThisFuncName = "IsExist_Cache";
const arrgs_ResearchPlanObjLst_Cache = await gs_ResearchPlan_GetObjLst_Cache(strid_CurrEduCls);
if (arrgs_ResearchPlanObjLst_Cache == null) return false;
try
{
const arrgs_ResearchPlan_Sel: Array <clsgs_ResearchPlanEN> = arrgs_ResearchPlanObjLst_Cache.filter(x => x.planId == strPlanId);
if (arrgs_ResearchPlan_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e)
{
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strPlanId, gs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param strPlanId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function gs_ResearchPlan_IsExistAsync(strPlanId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(gs_ResearchPlan_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strPlanId": strPlanId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchPlan_ConstructorName, strThisFuncName);
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
export async function gs_ResearchPlan_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(gs_ResearchPlan_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchPlan_ConstructorName, strThisFuncName);
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
 * 根据条件对象, 从缓存的对象列表中获取记录数.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
 * @param objgs_ResearchPlan_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function gs_ResearchPlan_GetRecCountByCond_Cache(objgs_ResearchPlan_Cond: clsgs_ResearchPlanEN,strid_CurrEduCls: string) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrgs_ResearchPlanObjLst_Cache = await gs_ResearchPlan_GetObjLst_Cache(strid_CurrEduCls);
if (arrgs_ResearchPlanObjLst_Cache == null) return 0;
let arrgs_ResearchPlan_Sel: Array < clsgs_ResearchPlanEN > = arrgs_ResearchPlanObjLst_Cache;
if (objgs_ResearchPlan_Cond.sf_FldComparisonOp == null || objgs_ResearchPlan_Cond.sf_FldComparisonOp == "") return arrgs_ResearchPlan_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_ResearchPlan_Cond.sf_FldComparisonOp);
//console.log("clsgs_ResearchPlanWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objgs_ResearchPlan_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_ResearchPlan_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrgs_ResearchPlan_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objgs_ResearchPlan_Cond), gs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return 0;
}

 /**
 * 获取表的最大关键字
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdAsync)
 * @returns 获取表的最大关键字
 **/
export async function gs_ResearchPlan_GetMaxStrIdAsync(): Promise<string>  
{
const strThisFuncName = "GetMaxStrIdAsync";
const strAction = "GetMaxStrId";
const strUrl = GetWebApiUrl(gs_ResearchPlan_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchPlan_ConstructorName, strThisFuncName);
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
export async function gs_ResearchPlan_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(gs_ResearchPlan_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ResearchPlan_ConstructorName, strThisFuncName);
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
export function gs_ResearchPlan_GetWebApiUrl(strController: string, strAction: string): string {
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

 /**
 * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
 **/
export function gs_ResearchPlan_ReFreshCache(strid_CurrEduCls: string):void
{
const strThisFuncName = "ReFreshCache";

if (IsNullOrEmpty(strid_CurrEduCls) == true)
{
  const strMsg = Format("参数:[strid_CurrEduCls]不能为空！(In clsgs_ResearchPlanWApi.clsgs_ResearchPlanWApi.ReFreshCache)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_CurrEduCls.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(clsgs_ResearchPlanWApi.clsgs_ResearchPlanWApi.ReFreshCache)", strid_CurrEduCls.length);
console.error(strMsg);
throw (strMsg);
}

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = Format("{0}_{1}", clsgs_ResearchPlanEN._CurrTabName, strid_CurrEduCls);
switch (clsgs_ResearchPlanEN.CacheModeId)
{
case "04"://sessionStorage
sessionStorage.removeItem(strKey);
break;
case "03"://localStorage
localStorage.removeItem(strKey);
break;
case "02"://ClientCache
CacheHelper.Remove(strKey);
break;
default:
CacheHelper.Remove(strKey);
break;
}
vgs_ResearchPlan_ReFreshThisCache(strid_CurrEduCls);
}

 /**
 * 刷新本类中的缓存.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
 **/
export function gs_ResearchPlan_ReFreshThisCache(strid_CurrEduCls: string):void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = Format("{0}_{1}", clsgs_ResearchPlanEN._CurrTabName, strid_CurrEduCls);
switch (clsgs_ResearchPlanEN.CacheModeId)
{
case "04"://sessionStorage
sessionStorage.removeItem(strKey);
break;
case "03"://localStorage
localStorage.removeItem(strKey);
break;
case "02"://ClientCache
CacheHelper.Remove(strKey);
break;
default:
CacheHelper.Remove(strKey);
break;
}
const strMsg = Format("刷新缓存成功！");
console.trace(strMsg);
}
else
{
const strMsg = Format("刷新缓存已经关闭。");
console.trace(strMsg);
}
}
/* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/

/**
 * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function gs_ResearchPlan_CheckPropertyNew(pobjgs_ResearchPlanEN: clsgs_ResearchPlanEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjgs_ResearchPlanEN.topicId) === true 
 || pobjgs_ResearchPlanEN.topicId.toString()  ===  "0" )
{
 throw new Error("(errid:Watl000058)字段[主题Id]不能为空(In 主题研究计划)!(clsgs_ResearchPlanBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ResearchPlanEN.statusId) === true )
{
 throw new Error("(errid:Watl000058)字段[状态Id]不能为空(In 主题研究计划)!(clsgs_ResearchPlanBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjgs_ResearchPlanEN.planId) == false && GetStrLen(pobjgs_ResearchPlanEN.planId) > 8)
{
 throw new Error("(errid:Watl000059)字段[计划Id(planId)]的长度不能超过8(In 主题研究计划(gs_ResearchPlan))!值:$(pobjgs_ResearchPlanEN.planId)(clsgs_ResearchPlanBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ResearchPlanEN.topicId) == false && GetStrLen(pobjgs_ResearchPlanEN.topicId) > 8)
{
 throw new Error("(errid:Watl000059)字段[主题Id(topicId)]的长度不能超过8(In 主题研究计划(gs_ResearchPlan))!值:$(pobjgs_ResearchPlanEN.topicId)(clsgs_ResearchPlanBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ResearchPlanEN.statusId) == false && GetStrLen(pobjgs_ResearchPlanEN.statusId) > 2)
{
 throw new Error("(errid:Watl000059)字段[状态Id(statusId)]的长度不能超过2(In 主题研究计划(gs_ResearchPlan))!值:$(pobjgs_ResearchPlanEN.statusId)(clsgs_ResearchPlanBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ResearchPlanEN.planContent) == false && GetStrLen(pobjgs_ResearchPlanEN.planContent) > 1000)
{
 throw new Error("(errid:Watl000059)字段[计划内容(planContent)]的长度不能超过1000(In 主题研究计划(gs_ResearchPlan))!值:$(pobjgs_ResearchPlanEN.planContent)(clsgs_ResearchPlanBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ResearchPlanEN.responsibleUser) == false && GetStrLen(pobjgs_ResearchPlanEN.responsibleUser) > 50)
{
 throw new Error("(errid:Watl000059)字段[负责人/小组(responsibleUser)]的长度不能超过50(In 主题研究计划(gs_ResearchPlan))!值:$(pobjgs_ResearchPlanEN.responsibleUser)(clsgs_ResearchPlanBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ResearchPlanEN.startDate) == false && GetStrLen(pobjgs_ResearchPlanEN.startDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[开始日期(startDate)]的长度不能超过20(In 主题研究计划(gs_ResearchPlan))!值:$(pobjgs_ResearchPlanEN.startDate)(clsgs_ResearchPlanBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ResearchPlanEN.endDate) == false && GetStrLen(pobjgs_ResearchPlanEN.endDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[截止日期(endDate)]的长度不能超过20(In 主题研究计划(gs_ResearchPlan))!值:$(pobjgs_ResearchPlanEN.endDate)(clsgs_ResearchPlanBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ResearchPlanEN.actualFinishingDate) == false && GetStrLen(pobjgs_ResearchPlanEN.actualFinishingDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[实际完成日期(actualFinishingDate)]的长度不能超过20(In 主题研究计划(gs_ResearchPlan))!值:$(pobjgs_ResearchPlanEN.actualFinishingDate)(clsgs_ResearchPlanBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ResearchPlanEN.acceptanceUser) == false && GetStrLen(pobjgs_ResearchPlanEN.acceptanceUser) > 50)
{
 throw new Error("(errid:Watl000059)字段[验收用户(acceptanceUser)]的长度不能超过50(In 主题研究计划(gs_ResearchPlan))!值:$(pobjgs_ResearchPlanEN.acceptanceUser)(clsgs_ResearchPlanBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ResearchPlanEN.updUser) == false && GetStrLen(pobjgs_ResearchPlanEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 主题研究计划(gs_ResearchPlan))!值:$(pobjgs_ResearchPlanEN.updUser)(clsgs_ResearchPlanBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ResearchPlanEN.updDate) == false && GetStrLen(pobjgs_ResearchPlanEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 主题研究计划(gs_ResearchPlan))!值:$(pobjgs_ResearchPlanEN.updDate)(clsgs_ResearchPlanBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ResearchPlanEN.memo) == false && GetStrLen(pobjgs_ResearchPlanEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 主题研究计划(gs_ResearchPlan))!值:$(pobjgs_ResearchPlanEN.memo)(clsgs_ResearchPlanBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ResearchPlanEN.planTypeId) == false && GetStrLen(pobjgs_ResearchPlanEN.planTypeId) > 2)
{
 throw new Error("(errid:Watl000059)字段[计划类型(planTypeId)]的长度不能超过2(In 主题研究计划(gs_ResearchPlan))!值:$(pobjgs_ResearchPlanEN.planTypeId)(clsgs_ResearchPlanBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ResearchPlanEN.id_CurrEduCls) == false && GetStrLen(pobjgs_ResearchPlanEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 主题研究计划(gs_ResearchPlan))!值:$(pobjgs_ResearchPlanEN.id_CurrEduCls)(clsgs_ResearchPlanBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjgs_ResearchPlanEN.planId) == false && undefined !== pobjgs_ResearchPlanEN.planId && tzDataType.isString(pobjgs_ResearchPlanEN.planId) === false)
{
 throw new Error("(errid:Watl000060)字段[计划Id(planId)]的值:[$(pobjgs_ResearchPlanEN.planId)], 非法，应该为字符型(In 主题研究计划(gs_ResearchPlan))!(clsgs_ResearchPlanBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ResearchPlanEN.topicId) == false && undefined !== pobjgs_ResearchPlanEN.topicId && tzDataType.isString(pobjgs_ResearchPlanEN.topicId) === false)
{
 throw new Error("(errid:Watl000060)字段[主题Id(topicId)]的值:[$(pobjgs_ResearchPlanEN.topicId)], 非法，应该为字符型(In 主题研究计划(gs_ResearchPlan))!(clsgs_ResearchPlanBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ResearchPlanEN.statusId) == false && undefined !== pobjgs_ResearchPlanEN.statusId && tzDataType.isString(pobjgs_ResearchPlanEN.statusId) === false)
{
 throw new Error("(errid:Watl000060)字段[状态Id(statusId)]的值:[$(pobjgs_ResearchPlanEN.statusId)], 非法，应该为字符型(In 主题研究计划(gs_ResearchPlan))!(clsgs_ResearchPlanBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ResearchPlanEN.planContent) == false && undefined !== pobjgs_ResearchPlanEN.planContent && tzDataType.isString(pobjgs_ResearchPlanEN.planContent) === false)
{
 throw new Error("(errid:Watl000060)字段[计划内容(planContent)]的值:[$(pobjgs_ResearchPlanEN.planContent)], 非法，应该为字符型(In 主题研究计划(gs_ResearchPlan))!(clsgs_ResearchPlanBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ResearchPlanEN.responsibleUser) == false && undefined !== pobjgs_ResearchPlanEN.responsibleUser && tzDataType.isString(pobjgs_ResearchPlanEN.responsibleUser) === false)
{
 throw new Error("(errid:Watl000060)字段[负责人/小组(responsibleUser)]的值:[$(pobjgs_ResearchPlanEN.responsibleUser)], 非法，应该为字符型(In 主题研究计划(gs_ResearchPlan))!(clsgs_ResearchPlanBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ResearchPlanEN.startDate) == false && undefined !== pobjgs_ResearchPlanEN.startDate && tzDataType.isString(pobjgs_ResearchPlanEN.startDate) === false)
{
 throw new Error("(errid:Watl000060)字段[开始日期(startDate)]的值:[$(pobjgs_ResearchPlanEN.startDate)], 非法，应该为字符型(In 主题研究计划(gs_ResearchPlan))!(clsgs_ResearchPlanBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ResearchPlanEN.endDate) == false && undefined !== pobjgs_ResearchPlanEN.endDate && tzDataType.isString(pobjgs_ResearchPlanEN.endDate) === false)
{
 throw new Error("(errid:Watl000060)字段[截止日期(endDate)]的值:[$(pobjgs_ResearchPlanEN.endDate)], 非法，应该为字符型(In 主题研究计划(gs_ResearchPlan))!(clsgs_ResearchPlanBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ResearchPlanEN.actualFinishingDate) == false && undefined !== pobjgs_ResearchPlanEN.actualFinishingDate && tzDataType.isString(pobjgs_ResearchPlanEN.actualFinishingDate) === false)
{
 throw new Error("(errid:Watl000060)字段[实际完成日期(actualFinishingDate)]的值:[$(pobjgs_ResearchPlanEN.actualFinishingDate)], 非法，应该为字符型(In 主题研究计划(gs_ResearchPlan))!(clsgs_ResearchPlanBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ResearchPlanEN.acceptanceUser) == false && undefined !== pobjgs_ResearchPlanEN.acceptanceUser && tzDataType.isString(pobjgs_ResearchPlanEN.acceptanceUser) === false)
{
 throw new Error("(errid:Watl000060)字段[验收用户(acceptanceUser)]的值:[$(pobjgs_ResearchPlanEN.acceptanceUser)], 非法，应该为字符型(In 主题研究计划(gs_ResearchPlan))!(clsgs_ResearchPlanBL:CheckPropertyNew)");
}
if (null != pobjgs_ResearchPlanEN.isSubmit && undefined !== pobjgs_ResearchPlanEN.isSubmit && tzDataType.isBoolean(pobjgs_ResearchPlanEN.isSubmit) === false)
{
 throw new Error("(errid:Watl000060)字段[是否提交(isSubmit)]的值:[$(pobjgs_ResearchPlanEN.isSubmit)], 非法，应该为布尔型(In 主题研究计划(gs_ResearchPlan))!(clsgs_ResearchPlanBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ResearchPlanEN.updUser) == false && undefined !== pobjgs_ResearchPlanEN.updUser && tzDataType.isString(pobjgs_ResearchPlanEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjgs_ResearchPlanEN.updUser)], 非法，应该为字符型(In 主题研究计划(gs_ResearchPlan))!(clsgs_ResearchPlanBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ResearchPlanEN.updDate) == false && undefined !== pobjgs_ResearchPlanEN.updDate && tzDataType.isString(pobjgs_ResearchPlanEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjgs_ResearchPlanEN.updDate)], 非法，应该为字符型(In 主题研究计划(gs_ResearchPlan))!(clsgs_ResearchPlanBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ResearchPlanEN.memo) == false && undefined !== pobjgs_ResearchPlanEN.memo && tzDataType.isString(pobjgs_ResearchPlanEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjgs_ResearchPlanEN.memo)], 非法，应该为字符型(In 主题研究计划(gs_ResearchPlan))!(clsgs_ResearchPlanBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ResearchPlanEN.planTypeId) == false && undefined !== pobjgs_ResearchPlanEN.planTypeId && tzDataType.isString(pobjgs_ResearchPlanEN.planTypeId) === false)
{
 throw new Error("(errid:Watl000060)字段[计划类型(planTypeId)]的值:[$(pobjgs_ResearchPlanEN.planTypeId)], 非法，应该为字符型(In 主题研究计划(gs_ResearchPlan))!(clsgs_ResearchPlanBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ResearchPlanEN.id_CurrEduCls) == false && undefined !== pobjgs_ResearchPlanEN.id_CurrEduCls && tzDataType.isString(pobjgs_ResearchPlanEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjgs_ResearchPlanEN.id_CurrEduCls)], 非法，应该为字符型(In 主题研究计划(gs_ResearchPlan))!(clsgs_ResearchPlanBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjgs_ResearchPlanEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function gs_ResearchPlan_CheckProperty4Update (pobjgs_ResearchPlanEN: clsgs_ResearchPlanEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjgs_ResearchPlanEN.planId) == false && GetStrLen(pobjgs_ResearchPlanEN.planId) > 8)
{
 throw new Error("(errid:Watl000062)字段[计划Id(planId)]的长度不能超过8(In 主题研究计划(gs_ResearchPlan))!值:$(pobjgs_ResearchPlanEN.planId)(clsgs_ResearchPlanBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ResearchPlanEN.topicId) == false && GetStrLen(pobjgs_ResearchPlanEN.topicId) > 8)
{
 throw new Error("(errid:Watl000062)字段[主题Id(topicId)]的长度不能超过8(In 主题研究计划(gs_ResearchPlan))!值:$(pobjgs_ResearchPlanEN.topicId)(clsgs_ResearchPlanBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ResearchPlanEN.statusId) == false && GetStrLen(pobjgs_ResearchPlanEN.statusId) > 2)
{
 throw new Error("(errid:Watl000062)字段[状态Id(statusId)]的长度不能超过2(In 主题研究计划(gs_ResearchPlan))!值:$(pobjgs_ResearchPlanEN.statusId)(clsgs_ResearchPlanBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ResearchPlanEN.planContent) == false && GetStrLen(pobjgs_ResearchPlanEN.planContent) > 1000)
{
 throw new Error("(errid:Watl000062)字段[计划内容(planContent)]的长度不能超过1000(In 主题研究计划(gs_ResearchPlan))!值:$(pobjgs_ResearchPlanEN.planContent)(clsgs_ResearchPlanBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ResearchPlanEN.responsibleUser) == false && GetStrLen(pobjgs_ResearchPlanEN.responsibleUser) > 50)
{
 throw new Error("(errid:Watl000062)字段[负责人/小组(responsibleUser)]的长度不能超过50(In 主题研究计划(gs_ResearchPlan))!值:$(pobjgs_ResearchPlanEN.responsibleUser)(clsgs_ResearchPlanBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ResearchPlanEN.startDate) == false && GetStrLen(pobjgs_ResearchPlanEN.startDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[开始日期(startDate)]的长度不能超过20(In 主题研究计划(gs_ResearchPlan))!值:$(pobjgs_ResearchPlanEN.startDate)(clsgs_ResearchPlanBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ResearchPlanEN.endDate) == false && GetStrLen(pobjgs_ResearchPlanEN.endDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[截止日期(endDate)]的长度不能超过20(In 主题研究计划(gs_ResearchPlan))!值:$(pobjgs_ResearchPlanEN.endDate)(clsgs_ResearchPlanBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ResearchPlanEN.actualFinishingDate) == false && GetStrLen(pobjgs_ResearchPlanEN.actualFinishingDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[实际完成日期(actualFinishingDate)]的长度不能超过20(In 主题研究计划(gs_ResearchPlan))!值:$(pobjgs_ResearchPlanEN.actualFinishingDate)(clsgs_ResearchPlanBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ResearchPlanEN.acceptanceUser) == false && GetStrLen(pobjgs_ResearchPlanEN.acceptanceUser) > 50)
{
 throw new Error("(errid:Watl000062)字段[验收用户(acceptanceUser)]的长度不能超过50(In 主题研究计划(gs_ResearchPlan))!值:$(pobjgs_ResearchPlanEN.acceptanceUser)(clsgs_ResearchPlanBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ResearchPlanEN.updUser) == false && GetStrLen(pobjgs_ResearchPlanEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 主题研究计划(gs_ResearchPlan))!值:$(pobjgs_ResearchPlanEN.updUser)(clsgs_ResearchPlanBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ResearchPlanEN.updDate) == false && GetStrLen(pobjgs_ResearchPlanEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 主题研究计划(gs_ResearchPlan))!值:$(pobjgs_ResearchPlanEN.updDate)(clsgs_ResearchPlanBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ResearchPlanEN.memo) == false && GetStrLen(pobjgs_ResearchPlanEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 主题研究计划(gs_ResearchPlan))!值:$(pobjgs_ResearchPlanEN.memo)(clsgs_ResearchPlanBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ResearchPlanEN.planTypeId) == false && GetStrLen(pobjgs_ResearchPlanEN.planTypeId) > 2)
{
 throw new Error("(errid:Watl000062)字段[计划类型(planTypeId)]的长度不能超过2(In 主题研究计划(gs_ResearchPlan))!值:$(pobjgs_ResearchPlanEN.planTypeId)(clsgs_ResearchPlanBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ResearchPlanEN.id_CurrEduCls) == false && GetStrLen(pobjgs_ResearchPlanEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 主题研究计划(gs_ResearchPlan))!值:$(pobjgs_ResearchPlanEN.id_CurrEduCls)(clsgs_ResearchPlanBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjgs_ResearchPlanEN.planId) == false && undefined !== pobjgs_ResearchPlanEN.planId && tzDataType.isString(pobjgs_ResearchPlanEN.planId) === false)
{
 throw new Error("(errid:Watl000063)字段[计划Id(planId)]的值:[$(pobjgs_ResearchPlanEN.planId)], 非法，应该为字符型(In 主题研究计划(gs_ResearchPlan))!(clsgs_ResearchPlanBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ResearchPlanEN.topicId) == false && undefined !== pobjgs_ResearchPlanEN.topicId && tzDataType.isString(pobjgs_ResearchPlanEN.topicId) === false)
{
 throw new Error("(errid:Watl000063)字段[主题Id(topicId)]的值:[$(pobjgs_ResearchPlanEN.topicId)], 非法，应该为字符型(In 主题研究计划(gs_ResearchPlan))!(clsgs_ResearchPlanBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ResearchPlanEN.statusId) == false && undefined !== pobjgs_ResearchPlanEN.statusId && tzDataType.isString(pobjgs_ResearchPlanEN.statusId) === false)
{
 throw new Error("(errid:Watl000063)字段[状态Id(statusId)]的值:[$(pobjgs_ResearchPlanEN.statusId)], 非法，应该为字符型(In 主题研究计划(gs_ResearchPlan))!(clsgs_ResearchPlanBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ResearchPlanEN.planContent) == false && undefined !== pobjgs_ResearchPlanEN.planContent && tzDataType.isString(pobjgs_ResearchPlanEN.planContent) === false)
{
 throw new Error("(errid:Watl000063)字段[计划内容(planContent)]的值:[$(pobjgs_ResearchPlanEN.planContent)], 非法，应该为字符型(In 主题研究计划(gs_ResearchPlan))!(clsgs_ResearchPlanBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ResearchPlanEN.responsibleUser) == false && undefined !== pobjgs_ResearchPlanEN.responsibleUser && tzDataType.isString(pobjgs_ResearchPlanEN.responsibleUser) === false)
{
 throw new Error("(errid:Watl000063)字段[负责人/小组(responsibleUser)]的值:[$(pobjgs_ResearchPlanEN.responsibleUser)], 非法，应该为字符型(In 主题研究计划(gs_ResearchPlan))!(clsgs_ResearchPlanBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ResearchPlanEN.startDate) == false && undefined !== pobjgs_ResearchPlanEN.startDate && tzDataType.isString(pobjgs_ResearchPlanEN.startDate) === false)
{
 throw new Error("(errid:Watl000063)字段[开始日期(startDate)]的值:[$(pobjgs_ResearchPlanEN.startDate)], 非法，应该为字符型(In 主题研究计划(gs_ResearchPlan))!(clsgs_ResearchPlanBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ResearchPlanEN.endDate) == false && undefined !== pobjgs_ResearchPlanEN.endDate && tzDataType.isString(pobjgs_ResearchPlanEN.endDate) === false)
{
 throw new Error("(errid:Watl000063)字段[截止日期(endDate)]的值:[$(pobjgs_ResearchPlanEN.endDate)], 非法，应该为字符型(In 主题研究计划(gs_ResearchPlan))!(clsgs_ResearchPlanBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ResearchPlanEN.actualFinishingDate) == false && undefined !== pobjgs_ResearchPlanEN.actualFinishingDate && tzDataType.isString(pobjgs_ResearchPlanEN.actualFinishingDate) === false)
{
 throw new Error("(errid:Watl000063)字段[实际完成日期(actualFinishingDate)]的值:[$(pobjgs_ResearchPlanEN.actualFinishingDate)], 非法，应该为字符型(In 主题研究计划(gs_ResearchPlan))!(clsgs_ResearchPlanBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ResearchPlanEN.acceptanceUser) == false && undefined !== pobjgs_ResearchPlanEN.acceptanceUser && tzDataType.isString(pobjgs_ResearchPlanEN.acceptanceUser) === false)
{
 throw new Error("(errid:Watl000063)字段[验收用户(acceptanceUser)]的值:[$(pobjgs_ResearchPlanEN.acceptanceUser)], 非法，应该为字符型(In 主题研究计划(gs_ResearchPlan))!(clsgs_ResearchPlanBL:CheckProperty4Update)");
}
if (null != pobjgs_ResearchPlanEN.isSubmit && undefined !== pobjgs_ResearchPlanEN.isSubmit && tzDataType.isBoolean(pobjgs_ResearchPlanEN.isSubmit) === false)
{
 throw new Error("(errid:Watl000063)字段[是否提交(isSubmit)]的值:[$(pobjgs_ResearchPlanEN.isSubmit)], 非法，应该为布尔型(In 主题研究计划(gs_ResearchPlan))!(clsgs_ResearchPlanBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ResearchPlanEN.updUser) == false && undefined !== pobjgs_ResearchPlanEN.updUser && tzDataType.isString(pobjgs_ResearchPlanEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjgs_ResearchPlanEN.updUser)], 非法，应该为字符型(In 主题研究计划(gs_ResearchPlan))!(clsgs_ResearchPlanBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ResearchPlanEN.updDate) == false && undefined !== pobjgs_ResearchPlanEN.updDate && tzDataType.isString(pobjgs_ResearchPlanEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjgs_ResearchPlanEN.updDate)], 非法，应该为字符型(In 主题研究计划(gs_ResearchPlan))!(clsgs_ResearchPlanBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ResearchPlanEN.memo) == false && undefined !== pobjgs_ResearchPlanEN.memo && tzDataType.isString(pobjgs_ResearchPlanEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjgs_ResearchPlanEN.memo)], 非法，应该为字符型(In 主题研究计划(gs_ResearchPlan))!(clsgs_ResearchPlanBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ResearchPlanEN.planTypeId) == false && undefined !== pobjgs_ResearchPlanEN.planTypeId && tzDataType.isString(pobjgs_ResearchPlanEN.planTypeId) === false)
{
 throw new Error("(errid:Watl000063)字段[计划类型(planTypeId)]的值:[$(pobjgs_ResearchPlanEN.planTypeId)], 非法，应该为字符型(In 主题研究计划(gs_ResearchPlan))!(clsgs_ResearchPlanBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ResearchPlanEN.id_CurrEduCls) == false && undefined !== pobjgs_ResearchPlanEN.id_CurrEduCls && tzDataType.isString(pobjgs_ResearchPlanEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjgs_ResearchPlanEN.id_CurrEduCls)], 非法，应该为字符型(In 主题研究计划(gs_ResearchPlan))!(clsgs_ResearchPlanBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (IsNullOrEmpty(pobjgs_ResearchPlanEN.planId) === true )
{
 throw new Error("(errid:Watl000064)字段[计划Id]不能为空(In 主题研究计划)!(clsgs_ResearchPlanBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjgs_ResearchPlanEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function gs_ResearchPlan_GetJSONStrByObj (pobjgs_ResearchPlanEN: clsgs_ResearchPlanEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjgs_ResearchPlanEN.sfUpdFldSetStr = pobjgs_ResearchPlanEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjgs_ResearchPlanEN);
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
export function gs_ResearchPlan_GetObjLstByJSONStr (strJSON: string): Array<clsgs_ResearchPlanEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrgs_ResearchPlanObjLst = new Array<clsgs_ResearchPlanEN>();
if (strJSON === "")
{
return arrgs_ResearchPlanObjLst;
}
try
{
arrgs_ResearchPlanObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrgs_ResearchPlanObjLst;
}
return arrgs_ResearchPlanObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrgs_ResearchPlanObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function gs_ResearchPlan_GetObjLstByJSONObjLst (arrgs_ResearchPlanObjLstS: Array<clsgs_ResearchPlanEN>): Array<clsgs_ResearchPlanEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrgs_ResearchPlanObjLst = new Array<clsgs_ResearchPlanEN>();
for (const objInFor of arrgs_ResearchPlanObjLstS) {
const obj1 = gs_ResearchPlan_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrgs_ResearchPlanObjLst.push(obj1);
}
return arrgs_ResearchPlanObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function gs_ResearchPlan_GetObjByJSONStr (strJSON: string): clsgs_ResearchPlanEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjgs_ResearchPlanEN = new clsgs_ResearchPlanEN();
if (strJSON === "")
{
return pobjgs_ResearchPlanEN;
}
try
{
pobjgs_ResearchPlanEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjgs_ResearchPlanEN;
}
return pobjgs_ResearchPlanEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function gs_ResearchPlan_GetCombineCondition(objgs_ResearchPlan_Cond: clsgs_ResearchPlanEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objgs_ResearchPlan_Cond.dicFldComparisonOp, clsgs_ResearchPlanEN.con_PlanId) == true)
{
const strComparisonOp_PlanId:string = objgs_ResearchPlan_Cond.dicFldComparisonOp[clsgs_ResearchPlanEN.con_PlanId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_ResearchPlanEN.con_PlanId, objgs_ResearchPlan_Cond.planId, strComparisonOp_PlanId);
}
if (Object.prototype.hasOwnProperty.call(objgs_ResearchPlan_Cond.dicFldComparisonOp, clsgs_ResearchPlanEN.con_TopicId) == true)
{
const strComparisonOp_TopicId:string = objgs_ResearchPlan_Cond.dicFldComparisonOp[clsgs_ResearchPlanEN.con_TopicId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_ResearchPlanEN.con_TopicId, objgs_ResearchPlan_Cond.topicId, strComparisonOp_TopicId);
}
if (Object.prototype.hasOwnProperty.call(objgs_ResearchPlan_Cond.dicFldComparisonOp, clsgs_ResearchPlanEN.con_StatusId) == true)
{
const strComparisonOp_StatusId:string = objgs_ResearchPlan_Cond.dicFldComparisonOp[clsgs_ResearchPlanEN.con_StatusId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_ResearchPlanEN.con_StatusId, objgs_ResearchPlan_Cond.statusId, strComparisonOp_StatusId);
}
if (Object.prototype.hasOwnProperty.call(objgs_ResearchPlan_Cond.dicFldComparisonOp, clsgs_ResearchPlanEN.con_PlanContent) == true)
{
const strComparisonOp_PlanContent:string = objgs_ResearchPlan_Cond.dicFldComparisonOp[clsgs_ResearchPlanEN.con_PlanContent];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_ResearchPlanEN.con_PlanContent, objgs_ResearchPlan_Cond.planContent, strComparisonOp_PlanContent);
}
if (Object.prototype.hasOwnProperty.call(objgs_ResearchPlan_Cond.dicFldComparisonOp, clsgs_ResearchPlanEN.con_ResponsibleUser) == true)
{
const strComparisonOp_ResponsibleUser:string = objgs_ResearchPlan_Cond.dicFldComparisonOp[clsgs_ResearchPlanEN.con_ResponsibleUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_ResearchPlanEN.con_ResponsibleUser, objgs_ResearchPlan_Cond.responsibleUser, strComparisonOp_ResponsibleUser);
}
if (Object.prototype.hasOwnProperty.call(objgs_ResearchPlan_Cond.dicFldComparisonOp, clsgs_ResearchPlanEN.con_StartDate) == true)
{
const strComparisonOp_StartDate:string = objgs_ResearchPlan_Cond.dicFldComparisonOp[clsgs_ResearchPlanEN.con_StartDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_ResearchPlanEN.con_StartDate, objgs_ResearchPlan_Cond.startDate, strComparisonOp_StartDate);
}
if (Object.prototype.hasOwnProperty.call(objgs_ResearchPlan_Cond.dicFldComparisonOp, clsgs_ResearchPlanEN.con_EndDate) == true)
{
const strComparisonOp_EndDate:string = objgs_ResearchPlan_Cond.dicFldComparisonOp[clsgs_ResearchPlanEN.con_EndDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_ResearchPlanEN.con_EndDate, objgs_ResearchPlan_Cond.endDate, strComparisonOp_EndDate);
}
if (Object.prototype.hasOwnProperty.call(objgs_ResearchPlan_Cond.dicFldComparisonOp, clsgs_ResearchPlanEN.con_ActualFinishingDate) == true)
{
const strComparisonOp_ActualFinishingDate:string = objgs_ResearchPlan_Cond.dicFldComparisonOp[clsgs_ResearchPlanEN.con_ActualFinishingDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_ResearchPlanEN.con_ActualFinishingDate, objgs_ResearchPlan_Cond.actualFinishingDate, strComparisonOp_ActualFinishingDate);
}
if (Object.prototype.hasOwnProperty.call(objgs_ResearchPlan_Cond.dicFldComparisonOp, clsgs_ResearchPlanEN.con_AcceptanceUser) == true)
{
const strComparisonOp_AcceptanceUser:string = objgs_ResearchPlan_Cond.dicFldComparisonOp[clsgs_ResearchPlanEN.con_AcceptanceUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_ResearchPlanEN.con_AcceptanceUser, objgs_ResearchPlan_Cond.acceptanceUser, strComparisonOp_AcceptanceUser);
}
if (Object.prototype.hasOwnProperty.call(objgs_ResearchPlan_Cond.dicFldComparisonOp, clsgs_ResearchPlanEN.con_IsSubmit) == true)
{
if (objgs_ResearchPlan_Cond.isSubmit == true)
{
strWhereCond += Format(" And {0} = '1'", clsgs_ResearchPlanEN.con_IsSubmit);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsgs_ResearchPlanEN.con_IsSubmit);
}
}
if (Object.prototype.hasOwnProperty.call(objgs_ResearchPlan_Cond.dicFldComparisonOp, clsgs_ResearchPlanEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objgs_ResearchPlan_Cond.dicFldComparisonOp[clsgs_ResearchPlanEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_ResearchPlanEN.con_UpdUser, objgs_ResearchPlan_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objgs_ResearchPlan_Cond.dicFldComparisonOp, clsgs_ResearchPlanEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objgs_ResearchPlan_Cond.dicFldComparisonOp[clsgs_ResearchPlanEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_ResearchPlanEN.con_UpdDate, objgs_ResearchPlan_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objgs_ResearchPlan_Cond.dicFldComparisonOp, clsgs_ResearchPlanEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objgs_ResearchPlan_Cond.dicFldComparisonOp[clsgs_ResearchPlanEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_ResearchPlanEN.con_Memo, objgs_ResearchPlan_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objgs_ResearchPlan_Cond.dicFldComparisonOp, clsgs_ResearchPlanEN.con_PlanTypeId) == true)
{
const strComparisonOp_PlanTypeId:string = objgs_ResearchPlan_Cond.dicFldComparisonOp[clsgs_ResearchPlanEN.con_PlanTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_ResearchPlanEN.con_PlanTypeId, objgs_ResearchPlan_Cond.planTypeId, strComparisonOp_PlanTypeId);
}
if (Object.prototype.hasOwnProperty.call(objgs_ResearchPlan_Cond.dicFldComparisonOp, clsgs_ResearchPlanEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objgs_ResearchPlan_Cond.dicFldComparisonOp[clsgs_ResearchPlanEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_ResearchPlanEN.con_id_CurrEduCls, objgs_ResearchPlan_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--gs_ResearchPlan(主题研究计划),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param strPlanId: 计划Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function gs_ResearchPlan_GetUniCondStr_PlanId(objgs_ResearchPlanEN: clsgs_ResearchPlanEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and PlanId = '{0}'", objgs_ResearchPlanEN.planId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--gs_ResearchPlan(主题研究计划),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param strPlanId: 计划Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function gs_ResearchPlan_GetUniCondStr4Update_PlanId(objgs_ResearchPlanEN: clsgs_ResearchPlanEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and PlanId <> '{0}'", objgs_ResearchPlanEN.planId);
 strWhereCond +=  Format(" and PlanId = '{0}'", objgs_ResearchPlanEN.planId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objgs_ResearchPlanENS:源对象
 * @param objgs_ResearchPlanENT:目标对象
*/
export function gs_ResearchPlan_CopyObjTo(objgs_ResearchPlanENS: clsgs_ResearchPlanEN , objgs_ResearchPlanENT: clsgs_ResearchPlanEN ): void 
{
objgs_ResearchPlanENT.planId = objgs_ResearchPlanENS.planId; //计划Id
objgs_ResearchPlanENT.topicId = objgs_ResearchPlanENS.topicId; //主题Id
objgs_ResearchPlanENT.statusId = objgs_ResearchPlanENS.statusId; //状态Id
objgs_ResearchPlanENT.planContent = objgs_ResearchPlanENS.planContent; //计划内容
objgs_ResearchPlanENT.responsibleUser = objgs_ResearchPlanENS.responsibleUser; //负责人/小组
objgs_ResearchPlanENT.startDate = objgs_ResearchPlanENS.startDate; //开始日期
objgs_ResearchPlanENT.endDate = objgs_ResearchPlanENS.endDate; //截止日期
objgs_ResearchPlanENT.actualFinishingDate = objgs_ResearchPlanENS.actualFinishingDate; //实际完成日期
objgs_ResearchPlanENT.acceptanceUser = objgs_ResearchPlanENS.acceptanceUser; //验收用户
objgs_ResearchPlanENT.isSubmit = objgs_ResearchPlanENS.isSubmit; //是否提交
objgs_ResearchPlanENT.updUser = objgs_ResearchPlanENS.updUser; //修改人
objgs_ResearchPlanENT.updDate = objgs_ResearchPlanENS.updDate; //修改日期
objgs_ResearchPlanENT.memo = objgs_ResearchPlanENS.memo; //备注
objgs_ResearchPlanENT.planTypeId = objgs_ResearchPlanENS.planTypeId; //计划类型
objgs_ResearchPlanENT.id_CurrEduCls = objgs_ResearchPlanENS.id_CurrEduCls; //教学班流水号
objgs_ResearchPlanENT.sfUpdFldSetStr = objgs_ResearchPlanENS.updFldString; //sfUpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objgs_ResearchPlanENS:源对象
 * @param objgs_ResearchPlanENT:目标对象
*/
export function gs_ResearchPlan_GetObjFromJsonObj(objgs_ResearchPlanENS: clsgs_ResearchPlanEN): clsgs_ResearchPlanEN 
{
 const objgs_ResearchPlanENT: clsgs_ResearchPlanEN = new clsgs_ResearchPlanEN();
ObjectAssign(objgs_ResearchPlanENT, objgs_ResearchPlanENS);
 return objgs_ResearchPlanENT;
}