
 /**
 * 类名:clsvgs_ResearchPlanWApi
 * 表名:vgs_ResearchPlan(01120662)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:47:05
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
 * 主题研究计划视图(vgs_ResearchPlan)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2023年03月13日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { enumComparisonOp } from "../../PubFun/enumComparisonOp.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { clsvgs_ResearchPlanEN } from "../../L0_Entity/GraduateEduTopic/clsvgs_ResearchPlanEN.js";
import { BindDdl_ObjLstInDiv_V, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const vgs_ResearchPlan_Controller = "vgs_ResearchPlanApi";
 export const vgs_ResearchPlan_ConstructorName = "vgs_ResearchPlan";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strPlanId:关键字
 * @returns 对象
 **/
export async function vgs_ResearchPlan_GetObjByPlanIdAsync(strPlanId: string): Promise<clsvgs_ResearchPlanEN|null>  
{
const strThisFuncName = "GetObjByPlanIdAsync";

if (IsNullOrEmpty(strPlanId) == true)
{
  const strMsg = Format("参数:[strPlanId]不能为空！(In clsvgs_ResearchPlanWApi.GetObjByPlanIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strPlanId.length != 8)
{
const strMsg = Format("缓存分类变量:[strPlanId]的长度:[{0}]不正确！(clsvgs_ResearchPlanWApi.GetObjByPlanIdAsync)", strPlanId.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByPlanId";
const strUrl = GetWebApiUrl(vgs_ResearchPlan_Controller, strAction);
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
const objvgs_ResearchPlan = vgs_ResearchPlan_GetObjFromJsonObj(returnObj);
return objvgs_ResearchPlan;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_ResearchPlan_ConstructorName, strThisFuncName);
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
export async function vgs_ResearchPlan_GetObjByPlanId_Cache(strPlanId:string,strid_CurrEduCls:string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByPlanId_Cache";

if (IsNullOrEmpty(strPlanId) == true)
{
  const strMsg = Format("参数:[strPlanId]不能为空！(In clsvgs_ResearchPlanWApi.GetObjByPlanId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strPlanId.length != 8)
{
const strMsg = Format("缓存分类变量:[strPlanId]的长度:[{0}]不正确！(clsvgs_ResearchPlanWApi.GetObjByPlanId_Cache)", strPlanId.length);
console.error(strMsg);
throw (strMsg);
}
const arrvgs_ResearchPlanObjLst_Cache = await vgs_ResearchPlan_GetObjLst_Cache(strid_CurrEduCls);
try
{
const arrvgs_ResearchPlan_Sel: Array <clsvgs_ResearchPlanEN> = arrvgs_ResearchPlanObjLst_Cache.filter(x => 
 x.planId == strPlanId );
let objvgs_ResearchPlan: clsvgs_ResearchPlanEN;
if (arrvgs_ResearchPlan_Sel.length > 0)
{
objvgs_ResearchPlan = arrvgs_ResearchPlan_Sel[0];
return objvgs_ResearchPlan;
}
else
{
if (bolTryAsyncOnce == true)
{
const objvgs_ResearchPlan_Const = await vgs_ResearchPlan_GetObjByPlanIdAsync(strPlanId);
if (objvgs_ResearchPlan_Const != null)
{
vgs_ResearchPlan_ReFreshThisCache(strid_CurrEduCls);
return objvgs_ResearchPlan_Const;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strPlanId, vgs_ResearchPlan_ConstructorName, strThisFuncName);
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
export async function vgs_ResearchPlan_GetObjByPlanId_localStorage(strPlanId: string) {
const strThisFuncName = "GetObjByPlanId_localStorage";

if (IsNullOrEmpty(strPlanId) == true)
{
  const strMsg = Format("参数:[strPlanId]不能为空！(In clsvgs_ResearchPlanWApi.GetObjByPlanId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
if (strPlanId.length != 8)
{
const strMsg = Format("缓存分类变量:[strPlanId]的长度:[{0}]不正确！(clsvgs_ResearchPlanWApi.GetObjByPlanId_localStorage)", strPlanId.length);
console.error(strMsg);
throw (strMsg);
}
const strKey = Format("{0}_{1}", clsvgs_ResearchPlanEN._CurrTabName, strPlanId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objvgs_ResearchPlan_Cache: clsvgs_ResearchPlanEN = JSON.parse(strTempObj);
return objvgs_ResearchPlan_Cache;
}
try
{
const objvgs_ResearchPlan = await vgs_ResearchPlan_GetObjByPlanIdAsync(strPlanId);
if (objvgs_ResearchPlan != null)
{
localStorage.setItem(strKey, JSON.stringify(objvgs_ResearchPlan));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objvgs_ResearchPlan;
}
return objvgs_ResearchPlan;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strPlanId, vgs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 根据关键字获取相关对象的名称属性, 从缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
 * @param strPlanId:所给的关键字
 * @returns 对象
*/
export async function vgs_ResearchPlan_GetNameByPlanId_Cache(strPlanId: string,strid_CurrEduCls: string) {
const strThisFuncName = "GetNameByPlanId_Cache";

if (IsNullOrEmpty(strPlanId) == true)
{
  const strMsg = Format("参数:[strPlanId]不能为空！(In clsvgs_ResearchPlanWApi.GetNameByPlanId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strPlanId.length != 8)
{
const strMsg = Format("缓存分类变量:[strPlanId]的长度:[{0}]不正确！(clsvgs_ResearchPlanWApi.GetNameByPlanId_Cache)", strPlanId.length);
console.error(strMsg);
throw (strMsg);
}
const arrvgs_ResearchPlanObjLst_Cache = await vgs_ResearchPlan_GetObjLst_Cache(strid_CurrEduCls);
if (arrvgs_ResearchPlanObjLst_Cache == null) return "";
try
{
const arrvgs_ResearchPlan_Sel: Array <clsvgs_ResearchPlanEN> = arrvgs_ResearchPlanObjLst_Cache.filter(x => 
 x.planId == strPlanId );
let objvgs_ResearchPlan: clsvgs_ResearchPlanEN;
if (arrvgs_ResearchPlan_Sel.length > 0)
{
objvgs_ResearchPlan = arrvgs_ResearchPlan_Sel[0];
return objvgs_ResearchPlan.statusName;
}
else
{
return "";
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strPlanId);
console.error(strMsg);
alert(strMsg);
}
return "";
}

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
export async function vgs_ResearchPlan_func(strInFldName:string , strOutFldName:string , strInValue:string 
, strid_CurrEduCls_C: string)
{
//const strThisFuncName = "func";

if (IsNullOrEmpty(strid_CurrEduCls_C) == true)
{
  const strMsg = Format("参数:[strid_CurrEduCls_C]不能为空！(In clsvgs_ResearchPlanWApi.func)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_CurrEduCls_C.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsvgs_ResearchPlanWApi.func)", strid_CurrEduCls_C.length);
console.error(strMsg);
throw (strMsg);
}

if (strInFldName != clsvgs_ResearchPlanEN.con_PlanId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsvgs_ResearchPlanEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strOutFldName, clsvgs_ResearchPlanEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strPlanId = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objvgs_ResearchPlan = await vgs_ResearchPlan_GetObjByPlanId_Cache(strPlanId , strid_CurrEduCls_C);
if (objvgs_ResearchPlan == null) return "";
if (objvgs_ResearchPlan.GetFldValue(strOutFldName) == null) return "";
return objvgs_ResearchPlan.GetFldValue(strOutFldName).toString();
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
export function vgs_ResearchPlan_SortFun_Defa(a:clsvgs_ResearchPlanEN , b:clsvgs_ResearchPlanEN): number 
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
export function vgs_ResearchPlan_SortFun_Defa_2Fld(a:clsvgs_ResearchPlanEN , b:clsvgs_ResearchPlanEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.topicId == b.topicId) return a.topicName.localeCompare(b.topicName);
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
export function vgs_ResearchPlan_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsvgs_ResearchPlanEN.con_PlanId:
return (a: clsvgs_ResearchPlanEN, b: clsvgs_ResearchPlanEN) => {
return a.planId.localeCompare(b.planId);
}
case clsvgs_ResearchPlanEN.con_TopicId:
return (a: clsvgs_ResearchPlanEN, b: clsvgs_ResearchPlanEN) => {
return a.topicId.localeCompare(b.topicId);
}
case clsvgs_ResearchPlanEN.con_TopicName:
return (a: clsvgs_ResearchPlanEN, b: clsvgs_ResearchPlanEN) => {
if (a.topicName == null) return -1;
if (b.topicName == null) return 1;
return a.topicName.localeCompare(b.topicName);
}
case clsvgs_ResearchPlanEN.con_id_CurrEduCls:
return (a: clsvgs_ResearchPlanEN, b: clsvgs_ResearchPlanEN) => {
if (a.id_CurrEduCls == null) return -1;
if (b.id_CurrEduCls == null) return 1;
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
case clsvgs_ResearchPlanEN.con_StatusId:
return (a: clsvgs_ResearchPlanEN, b: clsvgs_ResearchPlanEN) => {
return a.statusId.localeCompare(b.statusId);
}
case clsvgs_ResearchPlanEN.con_StatusName:
return (a: clsvgs_ResearchPlanEN, b: clsvgs_ResearchPlanEN) => {
if (a.statusName == null) return -1;
if (b.statusName == null) return 1;
return a.statusName.localeCompare(b.statusName);
}
case clsvgs_ResearchPlanEN.con_PlanContent:
return (a: clsvgs_ResearchPlanEN, b: clsvgs_ResearchPlanEN) => {
if (a.planContent == null) return -1;
if (b.planContent == null) return 1;
return a.planContent.localeCompare(b.planContent);
}
case clsvgs_ResearchPlanEN.con_ResponsibleUser:
return (a: clsvgs_ResearchPlanEN, b: clsvgs_ResearchPlanEN) => {
if (a.responsibleUser == null) return -1;
if (b.responsibleUser == null) return 1;
return a.responsibleUser.localeCompare(b.responsibleUser);
}
case clsvgs_ResearchPlanEN.con_StartDate:
return (a: clsvgs_ResearchPlanEN, b: clsvgs_ResearchPlanEN) => {
if (a.startDate == null) return -1;
if (b.startDate == null) return 1;
return a.startDate.localeCompare(b.startDate);
}
case clsvgs_ResearchPlanEN.con_EndDate:
return (a: clsvgs_ResearchPlanEN, b: clsvgs_ResearchPlanEN) => {
if (a.endDate == null) return -1;
if (b.endDate == null) return 1;
return a.endDate.localeCompare(b.endDate);
}
case clsvgs_ResearchPlanEN.con_ActualFinishingDate:
return (a: clsvgs_ResearchPlanEN, b: clsvgs_ResearchPlanEN) => {
if (a.actualFinishingDate == null) return -1;
if (b.actualFinishingDate == null) return 1;
return a.actualFinishingDate.localeCompare(b.actualFinishingDate);
}
case clsvgs_ResearchPlanEN.con_AcceptanceUser:
return (a: clsvgs_ResearchPlanEN, b: clsvgs_ResearchPlanEN) => {
if (a.acceptanceUser == null) return -1;
if (b.acceptanceUser == null) return 1;
return a.acceptanceUser.localeCompare(b.acceptanceUser);
}
case clsvgs_ResearchPlanEN.con_IsSubmit:
return (a: clsvgs_ResearchPlanEN, b: clsvgs_ResearchPlanEN) => {
if (a.isSubmit == true) return 1;
else return -1
}
case clsvgs_ResearchPlanEN.con_UpdUser:
return (a: clsvgs_ResearchPlanEN, b: clsvgs_ResearchPlanEN) => {
if (a.updUser == null) return -1;
if (b.updUser == null) return 1;
return a.updUser.localeCompare(b.updUser);
}
case clsvgs_ResearchPlanEN.con_UpdDate:
return (a: clsvgs_ResearchPlanEN, b: clsvgs_ResearchPlanEN) => {
if (a.updDate == null) return -1;
if (b.updDate == null) return 1;
return a.updDate.localeCompare(b.updDate);
}
case clsvgs_ResearchPlanEN.con_Memo:
return (a: clsvgs_ResearchPlanEN, b: clsvgs_ResearchPlanEN) => {
if (a.memo == null) return -1;
if (b.memo == null) return 1;
return a.memo.localeCompare(b.memo);
}
case clsvgs_ResearchPlanEN.con_PlanTypeId:
return (a: clsvgs_ResearchPlanEN, b: clsvgs_ResearchPlanEN) => {
if (a.planTypeId == null) return -1;
if (b.planTypeId == null) return 1;
return a.planTypeId.localeCompare(b.planTypeId);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vgs_ResearchPlan]中不存在！(in ${ vgs_ResearchPlan_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsvgs_ResearchPlanEN.con_PlanId:
return (a: clsvgs_ResearchPlanEN, b: clsvgs_ResearchPlanEN) => {
return b.planId.localeCompare(a.planId);
}
case clsvgs_ResearchPlanEN.con_TopicId:
return (a: clsvgs_ResearchPlanEN, b: clsvgs_ResearchPlanEN) => {
return b.topicId.localeCompare(a.topicId);
}
case clsvgs_ResearchPlanEN.con_TopicName:
return (a: clsvgs_ResearchPlanEN, b: clsvgs_ResearchPlanEN) => {
if (b.topicName == null) return -1;
if (a.topicName == null) return 1;
return b.topicName.localeCompare(a.topicName);
}
case clsvgs_ResearchPlanEN.con_id_CurrEduCls:
return (a: clsvgs_ResearchPlanEN, b: clsvgs_ResearchPlanEN) => {
if (b.id_CurrEduCls == null) return -1;
if (a.id_CurrEduCls == null) return 1;
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
case clsvgs_ResearchPlanEN.con_StatusId:
return (a: clsvgs_ResearchPlanEN, b: clsvgs_ResearchPlanEN) => {
return b.statusId.localeCompare(a.statusId);
}
case clsvgs_ResearchPlanEN.con_StatusName:
return (a: clsvgs_ResearchPlanEN, b: clsvgs_ResearchPlanEN) => {
if (b.statusName == null) return -1;
if (a.statusName == null) return 1;
return b.statusName.localeCompare(a.statusName);
}
case clsvgs_ResearchPlanEN.con_PlanContent:
return (a: clsvgs_ResearchPlanEN, b: clsvgs_ResearchPlanEN) => {
if (b.planContent == null) return -1;
if (a.planContent == null) return 1;
return b.planContent.localeCompare(a.planContent);
}
case clsvgs_ResearchPlanEN.con_ResponsibleUser:
return (a: clsvgs_ResearchPlanEN, b: clsvgs_ResearchPlanEN) => {
if (b.responsibleUser == null) return -1;
if (a.responsibleUser == null) return 1;
return b.responsibleUser.localeCompare(a.responsibleUser);
}
case clsvgs_ResearchPlanEN.con_StartDate:
return (a: clsvgs_ResearchPlanEN, b: clsvgs_ResearchPlanEN) => {
if (b.startDate == null) return -1;
if (a.startDate == null) return 1;
return b.startDate.localeCompare(a.startDate);
}
case clsvgs_ResearchPlanEN.con_EndDate:
return (a: clsvgs_ResearchPlanEN, b: clsvgs_ResearchPlanEN) => {
if (b.endDate == null) return -1;
if (a.endDate == null) return 1;
return b.endDate.localeCompare(a.endDate);
}
case clsvgs_ResearchPlanEN.con_ActualFinishingDate:
return (a: clsvgs_ResearchPlanEN, b: clsvgs_ResearchPlanEN) => {
if (b.actualFinishingDate == null) return -1;
if (a.actualFinishingDate == null) return 1;
return b.actualFinishingDate.localeCompare(a.actualFinishingDate);
}
case clsvgs_ResearchPlanEN.con_AcceptanceUser:
return (a: clsvgs_ResearchPlanEN, b: clsvgs_ResearchPlanEN) => {
if (b.acceptanceUser == null) return -1;
if (a.acceptanceUser == null) return 1;
return b.acceptanceUser.localeCompare(a.acceptanceUser);
}
case clsvgs_ResearchPlanEN.con_IsSubmit:
return (a: clsvgs_ResearchPlanEN, b: clsvgs_ResearchPlanEN) => {
if (b.isSubmit == true) return 1;
else return -1
}
case clsvgs_ResearchPlanEN.con_UpdUser:
return (a: clsvgs_ResearchPlanEN, b: clsvgs_ResearchPlanEN) => {
if (b.updUser == null) return -1;
if (a.updUser == null) return 1;
return b.updUser.localeCompare(a.updUser);
}
case clsvgs_ResearchPlanEN.con_UpdDate:
return (a: clsvgs_ResearchPlanEN, b: clsvgs_ResearchPlanEN) => {
if (b.updDate == null) return -1;
if (a.updDate == null) return 1;
return b.updDate.localeCompare(a.updDate);
}
case clsvgs_ResearchPlanEN.con_Memo:
return (a: clsvgs_ResearchPlanEN, b: clsvgs_ResearchPlanEN) => {
if (b.memo == null) return -1;
if (a.memo == null) return 1;
return b.memo.localeCompare(a.memo);
}
case clsvgs_ResearchPlanEN.con_PlanTypeId:
return (a: clsvgs_ResearchPlanEN, b: clsvgs_ResearchPlanEN) => {
if (b.planTypeId == null) return -1;
if (a.planTypeId == null) return 1;
return b.planTypeId.localeCompare(a.planTypeId);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vgs_ResearchPlan]中不存在！(in ${ vgs_ResearchPlan_ConstructorName}.${ strThisFuncName})`;
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
export async function vgs_ResearchPlan_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsvgs_ResearchPlanEN.con_PlanId:
return (obj: clsvgs_ResearchPlanEN) => {
return obj.planId === value;
}
case clsvgs_ResearchPlanEN.con_TopicId:
return (obj: clsvgs_ResearchPlanEN) => {
return obj.topicId === value;
}
case clsvgs_ResearchPlanEN.con_TopicName:
return (obj: clsvgs_ResearchPlanEN) => {
return obj.topicName === value;
}
case clsvgs_ResearchPlanEN.con_id_CurrEduCls:
return (obj: clsvgs_ResearchPlanEN) => {
return obj.id_CurrEduCls === value;
}
case clsvgs_ResearchPlanEN.con_StatusId:
return (obj: clsvgs_ResearchPlanEN) => {
return obj.statusId === value;
}
case clsvgs_ResearchPlanEN.con_StatusName:
return (obj: clsvgs_ResearchPlanEN) => {
return obj.statusName === value;
}
case clsvgs_ResearchPlanEN.con_PlanContent:
return (obj: clsvgs_ResearchPlanEN) => {
return obj.planContent === value;
}
case clsvgs_ResearchPlanEN.con_ResponsibleUser:
return (obj: clsvgs_ResearchPlanEN) => {
return obj.responsibleUser === value;
}
case clsvgs_ResearchPlanEN.con_StartDate:
return (obj: clsvgs_ResearchPlanEN) => {
return obj.startDate === value;
}
case clsvgs_ResearchPlanEN.con_EndDate:
return (obj: clsvgs_ResearchPlanEN) => {
return obj.endDate === value;
}
case clsvgs_ResearchPlanEN.con_ActualFinishingDate:
return (obj: clsvgs_ResearchPlanEN) => {
return obj.actualFinishingDate === value;
}
case clsvgs_ResearchPlanEN.con_AcceptanceUser:
return (obj: clsvgs_ResearchPlanEN) => {
return obj.acceptanceUser === value;
}
case clsvgs_ResearchPlanEN.con_IsSubmit:
return (obj: clsvgs_ResearchPlanEN) => {
return obj.isSubmit === value;
}
case clsvgs_ResearchPlanEN.con_UpdUser:
return (obj: clsvgs_ResearchPlanEN) => {
return obj.updUser === value;
}
case clsvgs_ResearchPlanEN.con_UpdDate:
return (obj: clsvgs_ResearchPlanEN) => {
return obj.updDate === value;
}
case clsvgs_ResearchPlanEN.con_Memo:
return (obj: clsvgs_ResearchPlanEN) => {
return obj.memo === value;
}
case clsvgs_ResearchPlanEN.con_PlanTypeId:
return (obj: clsvgs_ResearchPlanEN) => {
return obj.planTypeId === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vgs_ResearchPlan]中不存在！(in ${ vgs_ResearchPlan_ConstructorName}.${ strThisFuncName})`;
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
export async function vgs_ResearchPlan_funcKey(strInFldName:string, strInValue: any, strComparisonOp:string, strid_CurrEduCls_C: string): Promise<Array<string>>
{
//const strThisFuncName = "funcKey";

if (IsNullOrEmpty(strid_CurrEduCls_C) == true)
{
  const strMsg = Format("参数:[strid_CurrEduCls_C]不能为空！(In clsvgs_ResearchPlanWApi.funcKey)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_CurrEduCls_C.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsvgs_ResearchPlanWApi.funcKey)", strid_CurrEduCls_C.length);
console.error(strMsg);
throw (strMsg);
}

if (strInFldName == clsvgs_ResearchPlanEN.con_PlanId)
{
const strMsg = Format("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (IsNullOrEmpty(strInValue) == true)
{
return [];
}
const arrvgs_ResearchPlan = await vgs_ResearchPlan_GetObjLst_Cache(strid_CurrEduCls_C);
if (arrvgs_ResearchPlan == null) return [];
let arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan;
const strType = typeof(strInValue);
switch (strType)
{
case "string":
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01: // " = "
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
break;
case enumComparisonOp.Like_03:
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
break;
case enumComparisonOp.In_04:
const arrValues = strInValue.split(',');
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
break;
}
break;
case "boolean":
if (strInValue == null) return [];
if (strComparisonOp == enumComparisonOp.Equal_01)
{
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
}
break;
case "number":
if (Number(strInValue) == 0) return [];
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01:
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
break;
case enumComparisonOp.NotEqual_02:
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
break;
case enumComparisonOp.NotLessThan_05://" >= ":
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
break;
case enumComparisonOp.NotGreaterThan_06://" <= ":
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
case enumComparisonOp.GreaterThan_07://" > ":
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
break;
case enumComparisonOp.LessThan_08://" < ":
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
}
break;
}
if (arrvgs_ResearchPlan_Sel.length == 0) return [];
return arrvgs_ResearchPlan_Sel.map(x=>x.planId);
}

 /**
 * 根据条件获取满足条件的第一条记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
 * @param strWhereCond:条件
 * @returns 返回的第一条记录的关键字值
 **/
export async function vgs_ResearchPlan_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vgs_ResearchPlan_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_ResearchPlan_ConstructorName, strThisFuncName);
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
export async function vgs_ResearchPlan_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vgs_ResearchPlan_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_ResearchPlan_ConstructorName, strThisFuncName);
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
export async function vgs_ResearchPlan_GetFirstObjAsync(strWhereCond: string): Promise<clsvgs_ResearchPlanEN|null>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(vgs_ResearchPlan_Controller, strAction);
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
const objvgs_ResearchPlan = vgs_ResearchPlan_GetObjFromJsonObj(returnObj);
return objvgs_ResearchPlan;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_ResearchPlan_ConstructorName, strThisFuncName);
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
export async function vgs_ResearchPlan_GetObjLst_ClientCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
if (IsNullOrEmpty(clsvgs_ResearchPlanEN.WhereFormat) == false)
{
strWhereCond = Format(clsvgs_ResearchPlanEN.WhereFormat, strid_CurrEduCls);
}
else
{
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
}
const strKey = Format("{0}_{1}", clsvgs_ResearchPlanEN._CurrTabName, strid_CurrEduCls);
if (IsNullOrEmpty(clsvgs_ResearchPlanEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvgs_ResearchPlanEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrvgs_ResearchPlanExObjLst_Cache: Array<clsvgs_ResearchPlanEN> = CacheHelper.Get(strKey);
const arrvgs_ResearchPlanObjLst_T = vgs_ResearchPlan_GetObjLstByJSONObjLst(arrvgs_ResearchPlanExObjLst_Cache);
return arrvgs_ResearchPlanObjLst_T;
}
try
{
const arrvgs_ResearchPlanExObjLst = await vgs_ResearchPlan_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrvgs_ResearchPlanExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvgs_ResearchPlanExObjLst.length);
console.log(strInfo);
return arrvgs_ResearchPlanExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vgs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vgs_ResearchPlan_GetObjLst_localStorage(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
if (IsNullOrEmpty(clsvgs_ResearchPlanEN.WhereFormat) == false)
{
strWhereCond = Format(clsvgs_ResearchPlanEN.WhereFormat, strid_CurrEduCls);
}
else
{
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
}
const strKey = Format("{0}_{1}", clsvgs_ResearchPlanEN._CurrTabName, strid_CurrEduCls);
if (IsNullOrEmpty(clsvgs_ResearchPlanEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvgs_ResearchPlanEN.CacheAddiCondition);
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
const arrvgs_ResearchPlanExObjLst_Cache: Array<clsvgs_ResearchPlanEN> = JSON.parse(strTempObjLst);
const arrvgs_ResearchPlanObjLst_T = vgs_ResearchPlan_GetObjLstByJSONObjLst(arrvgs_ResearchPlanExObjLst_Cache);
return arrvgs_ResearchPlanObjLst_T;
}
try
{
const arrvgs_ResearchPlanExObjLst = await vgs_ResearchPlan_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrvgs_ResearchPlanExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvgs_ResearchPlanExObjLst.length);
console.log(strInfo);
return arrvgs_ResearchPlanExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vgs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vgs_ResearchPlan_GetObjLst_localStorage_PureCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsvgs_ResearchPlanEN._CurrTabName, strid_CurrEduCls);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrvgs_ResearchPlanObjLst_Cache: Array<clsvgs_ResearchPlanEN> = JSON.parse(strTempObjLst);
return arrvgs_ResearchPlanObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function vgs_ResearchPlan_GetObjLstAsync(strWhereCond: string): Promise<Array<clsvgs_ResearchPlanEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(vgs_ResearchPlan_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vgs_ResearchPlan_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_ResearchPlan_ConstructorName, strThisFuncName);
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
export async function vgs_ResearchPlan_GetObjLst_sessionStorage(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
if (IsNullOrEmpty(clsvgs_ResearchPlanEN.WhereFormat) == false)
{
strWhereCond = Format(clsvgs_ResearchPlanEN.WhereFormat, strid_CurrEduCls);
}
else
{
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
}
const strKey = Format("{0}_{1}", clsvgs_ResearchPlanEN._CurrTabName, strid_CurrEduCls);
if (IsNullOrEmpty(clsvgs_ResearchPlanEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvgs_ResearchPlanEN.CacheAddiCondition);
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
const arrvgs_ResearchPlanExObjLst_Cache: Array<clsvgs_ResearchPlanEN> = JSON.parse(strTempObjLst);
const arrvgs_ResearchPlanObjLst_T = vgs_ResearchPlan_GetObjLstByJSONObjLst(arrvgs_ResearchPlanExObjLst_Cache);
return arrvgs_ResearchPlanObjLst_T;
}
try
{
const arrvgs_ResearchPlanExObjLst = await vgs_ResearchPlan_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrvgs_ResearchPlanExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvgs_ResearchPlanExObjLst.length);
console.log(strInfo);
return arrvgs_ResearchPlanExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vgs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vgs_ResearchPlan_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsvgs_ResearchPlanEN._CurrTabName, strid_CurrEduCls);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrvgs_ResearchPlanObjLst_Cache: Array<clsvgs_ResearchPlanEN> = JSON.parse(strTempObjLst);
return arrvgs_ResearchPlanObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vgs_ResearchPlan_GetObjLst_Cache(strid_CurrEduCls: string): Promise<Array<clsvgs_ResearchPlanEN>>
{
//const strThisFuncName = "GetObjLst_Cache";

if (IsNullOrEmpty(strid_CurrEduCls) == true)
{
const strMsg = Format("缓存分类变量:[id_CurrEduCls]不能为空！(in clsvgs_ResearchPlanWApi.vgs_ResearchPlan_GetObjLst_Cache() )");
console.error(strMsg);
throw (strMsg);
}
if (strid_CurrEduCls.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(in clsvgs_ResearchPlanWApi.vgs_ResearchPlan_GetObjLst_Cache() )", strid_CurrEduCls.length);
console.error(strMsg);
throw (strMsg);
}
let arrvgs_ResearchPlanObjLst_Cache;
switch (clsvgs_ResearchPlanEN.CacheModeId)
{
case "04"://sessionStorage
arrvgs_ResearchPlanObjLst_Cache = await vgs_ResearchPlan_GetObjLst_sessionStorage(strid_CurrEduCls);
break;
case "03"://localStorage
arrvgs_ResearchPlanObjLst_Cache = await vgs_ResearchPlan_GetObjLst_localStorage(strid_CurrEduCls);
break;
case "02"://ClientCache
arrvgs_ResearchPlanObjLst_Cache = await vgs_ResearchPlan_GetObjLst_ClientCache(strid_CurrEduCls);
break;
default:
arrvgs_ResearchPlanObjLst_Cache = await vgs_ResearchPlan_GetObjLst_ClientCache(strid_CurrEduCls);
break;
}
const arrvgs_ResearchPlanObjLst = vgs_ResearchPlan_GetObjLstByJSONObjLst(arrvgs_ResearchPlanObjLst_Cache);
return arrvgs_ResearchPlanObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vgs_ResearchPlan_GetObjLst_PureCache(strid_CurrEduCls: string)
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrvgs_ResearchPlanObjLst_Cache;
switch (clsvgs_ResearchPlanEN.CacheModeId)
{
case "04"://sessionStorage
arrvgs_ResearchPlanObjLst_Cache = await vgs_ResearchPlan_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls);
break;
case "03"://localStorage
arrvgs_ResearchPlanObjLst_Cache = await vgs_ResearchPlan_GetObjLst_localStorage_PureCache(strid_CurrEduCls);
break;
case "02"://ClientCache
arrvgs_ResearchPlanObjLst_Cache = null;
break;
default:
arrvgs_ResearchPlanObjLst_Cache = null;
break;
}
return arrvgs_ResearchPlanObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrPlanId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vgs_ResearchPlan_GetSubObjLst_Cache(objvgs_ResearchPlan_Cond: clsvgs_ResearchPlanEN,strid_CurrEduCls: string) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrvgs_ResearchPlanObjLst_Cache = await vgs_ResearchPlan_GetObjLst_Cache(strid_CurrEduCls);
let arrvgs_ResearchPlan_Sel: Array < clsvgs_ResearchPlanEN > = arrvgs_ResearchPlanObjLst_Cache;
if (objvgs_ResearchPlan_Cond.sf_FldComparisonOp == null || objvgs_ResearchPlan_Cond.sf_FldComparisonOp == "") return arrvgs_ResearchPlan_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvgs_ResearchPlan_Cond.sf_FldComparisonOp);
//console.log("clsvgs_ResearchPlanWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvgs_ResearchPlan_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvgs_ResearchPlan_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvgs_ResearchPlan_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objvgs_ResearchPlan_Cond), vgs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvgs_ResearchPlanEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrPlanId:关键字列表
 * @returns 对象列表
 **/
export async function vgs_ResearchPlan_GetObjLstByPlanIdLstAsync(arrPlanId: Array<string>): Promise<Array<clsvgs_ResearchPlanEN>>  
{
const strThisFuncName = "GetObjLstByPlanIdLstAsync";
const strAction = "GetObjLstByPlanIdLst";
const strUrl = GetWebApiUrl(vgs_ResearchPlan_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrPlanId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vgs_ResearchPlan_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_ResearchPlan_ConstructorName, strThisFuncName);
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
export async function vgs_ResearchPlan_GetObjLstByPlanIdLst_Cache(arrPlanIdLst: Array<string>,strid_CurrEduCls: string) {
const strThisFuncName = "GetObjLstByPlanIdLst_Cache";
try
{
const arrvgs_ResearchPlanObjLst_Cache = await vgs_ResearchPlan_GetObjLst_Cache(strid_CurrEduCls);
const arrvgs_ResearchPlan_Sel: Array <clsvgs_ResearchPlanEN> = arrvgs_ResearchPlanObjLst_Cache.filter(x => arrPlanIdLst.indexOf(x.planId)>-1);
return arrvgs_ResearchPlan_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrPlanIdLst.join(","), vgs_ResearchPlan_ConstructorName, strThisFuncName);
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
export async function vgs_ResearchPlan_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsvgs_ResearchPlanEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(vgs_ResearchPlan_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vgs_ResearchPlan_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_ResearchPlan_ConstructorName, strThisFuncName);
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
export async function vgs_ResearchPlan_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsvgs_ResearchPlanEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vgs_ResearchPlan_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vgs_ResearchPlan_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_ResearchPlan_ConstructorName, strThisFuncName);
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
export async function vgs_ResearchPlan_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vgs_ResearchPlan_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_ResearchPlan_ConstructorName, strThisFuncName);
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
export async function vgs_ResearchPlan_GetObjLstByPager_Cache(objPagerPara: stuPagerPara,strid_CurrEduCls: string) {
const strThisFuncName = "GetObjLstByPager_Cache";
if (objPagerPara.pageIndex == 0) return new Array<clsvgs_ResearchPlanEN>();
const arrvgs_ResearchPlanObjLst_Cache = await vgs_ResearchPlan_GetObjLst_Cache(strid_CurrEduCls);
if (arrvgs_ResearchPlanObjLst_Cache.length == 0) return arrvgs_ResearchPlanObjLst_Cache;
let arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlanObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objvgs_ResearchPlan_Cond = new clsvgs_ResearchPlanEN();
ObjectAssign(objvgs_ResearchPlan_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsvgs_ResearchPlanWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvgs_ResearchPlan_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvgs_ResearchPlan_Sel.length == 0) return arrvgs_ResearchPlan_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.sort(vgs_ResearchPlan_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.sort(objPagerPara.sortFun);
}
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.slice(intStart, intEnd);     
return arrvgs_ResearchPlan_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, vgs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvgs_ResearchPlanEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function vgs_ResearchPlan_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsvgs_ResearchPlanEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
if (objPagerPara.pageIndex == 0) return new Array<clsvgs_ResearchPlanEN>();
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(vgs_ResearchPlan_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vgs_ResearchPlan_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_ResearchPlan_ConstructorName, strThisFuncName);
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
export async function vgs_ResearchPlan_IsExistRecord_Cache(objvgs_ResearchPlan_Cond: clsvgs_ResearchPlanEN,strid_CurrEduCls: string) {
const strThisFuncName = "IsExistRecord_Cache";
const arrvgs_ResearchPlanObjLst_Cache = await vgs_ResearchPlan_GetObjLst_Cache(strid_CurrEduCls);
if (arrvgs_ResearchPlanObjLst_Cache == null) return false;
let arrvgs_ResearchPlan_Sel: Array < clsvgs_ResearchPlanEN > = arrvgs_ResearchPlanObjLst_Cache;
if (objvgs_ResearchPlan_Cond.sf_FldComparisonOp == null || objvgs_ResearchPlan_Cond.sf_FldComparisonOp == "") return arrvgs_ResearchPlan_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvgs_ResearchPlan_Cond.sf_FldComparisonOp);
//console.log("clsvgs_ResearchPlanWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvgs_ResearchPlan_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvgs_ResearchPlan_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvgs_ResearchPlan_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objvgs_ResearchPlan_Cond), vgs_ResearchPlan_ConstructorName, strThisFuncName);
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
export async function vgs_ResearchPlan_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(vgs_ResearchPlan_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_ResearchPlan_ConstructorName, strThisFuncName);
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
export async function vgs_ResearchPlan_IsExist(strPlanId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vgs_ResearchPlan_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_ResearchPlan_ConstructorName, strThisFuncName);
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
export async function vgs_ResearchPlan_IsExist_Cache(strPlanId:string,strid_CurrEduCls:string) {
const strThisFuncName = "IsExist_Cache";
const arrvgs_ResearchPlanObjLst_Cache = await vgs_ResearchPlan_GetObjLst_Cache(strid_CurrEduCls);
if (arrvgs_ResearchPlanObjLst_Cache == null) return false;
try
{
const arrvgs_ResearchPlan_Sel: Array <clsvgs_ResearchPlanEN> = arrvgs_ResearchPlanObjLst_Cache.filter(x => x.planId == strPlanId);
if (arrvgs_ResearchPlan_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strPlanId, vgs_ResearchPlan_ConstructorName, strThisFuncName);
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
export async function vgs_ResearchPlan_IsExistAsync(strPlanId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vgs_ResearchPlan_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_ResearchPlan_ConstructorName, strThisFuncName);
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
export async function vgs_ResearchPlan_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(vgs_ResearchPlan_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_ResearchPlan_ConstructorName, strThisFuncName);
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
 * @param objvgs_ResearchPlan_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function vgs_ResearchPlan_GetRecCountByCond_Cache(objvgs_ResearchPlan_Cond: clsvgs_ResearchPlanEN,strid_CurrEduCls: string) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrvgs_ResearchPlanObjLst_Cache = await vgs_ResearchPlan_GetObjLst_Cache(strid_CurrEduCls);
if (arrvgs_ResearchPlanObjLst_Cache == null) return 0;
let arrvgs_ResearchPlan_Sel: Array < clsvgs_ResearchPlanEN > = arrvgs_ResearchPlanObjLst_Cache;
if (objvgs_ResearchPlan_Cond.sf_FldComparisonOp == null || objvgs_ResearchPlan_Cond.sf_FldComparisonOp == "") return arrvgs_ResearchPlan_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvgs_ResearchPlan_Cond.sf_FldComparisonOp);
//console.log("clsvgs_ResearchPlanWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvgs_ResearchPlan_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvgs_ResearchPlan_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvgs_ResearchPlan_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objvgs_ResearchPlan_Cond), vgs_ResearchPlan_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return 0;
}

/**
 * 获取WebApi的地址
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
 * @returns 返回当前文件中Web服务的地址
*/
export function vgs_ResearchPlan_GetWebApiUrl(strController: string, strAction: string): string {
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
 * 刷新本类中的缓存.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
 **/
export function vgs_ResearchPlan_ReFreshThisCache(strid_CurrEduCls: string):void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = Format("{0}_{1}", clsvgs_ResearchPlanEN._CurrTabName, strid_CurrEduCls);
switch (clsvgs_ResearchPlanEN.CacheModeId)
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

/**
 * 绑定基于Web的下拉框,在某一层下的下拉框
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
 * @param objDDL:需要绑定当前表的下拉框
*/
export async function vgs_ResearchPlan__Cache(strDivName: string, strDdlName: string , strid_CurrEduCls: string)
{
const strThisFuncName = "_Cache";

if (IsNullOrEmpty(strid_CurrEduCls) == true)
{
  const strMsg = Format("参数:[strid_CurrEduCls]不能为空！(In clsvgs_ResearchPlanWApi.)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_CurrEduCls.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(clsvgs_ResearchPlanWApi.)", strid_CurrEduCls.length);
console.error(strMsg);
throw (strMsg);
}

const objDdl = document.getElementById(strDdlName);
if (objDdl == null)
{
const strMsg = Format("下拉框：{0} 不存在！(In )", strDdlName);
alert(strMsg);
console.error(strMsg);
throw (strMsg);
}
//为数据源于表的下拉框设置内容
//console.log("开始：_Cache");
const arrObjLst_Sel = await vgs_ResearchPlan_GetObjLst_Cache(strid_CurrEduCls);
if (arrObjLst_Sel == null) return;
BindDdl_ObjLstInDiv_V(strDivName, strDdlName, arrObjLst_Sel, clsvgs_ResearchPlanEN.con_StatusId, clsvgs_ResearchPlanEN.con_StatusName, "主题研究计划视图");
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vgs_ResearchPlan_GetJSONStrByObj (pobjvgs_ResearchPlanEN: clsvgs_ResearchPlanEN): string
{
const strThisFuncName = "GetJSONStrByObj";
let strJson = "";
try
{
strJson = JSON.stringify(pobjvgs_ResearchPlanEN);
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
export function vgs_ResearchPlan_GetObjLstByJSONStr (strJSON: string): Array<clsvgs_ResearchPlanEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrvgs_ResearchPlanObjLst = new Array<clsvgs_ResearchPlanEN>();
if (strJSON === "")
{
return arrvgs_ResearchPlanObjLst;
}
try
{
arrvgs_ResearchPlanObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvgs_ResearchPlanObjLst;
}
return arrvgs_ResearchPlanObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrvgs_ResearchPlanObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function vgs_ResearchPlan_GetObjLstByJSONObjLst (arrvgs_ResearchPlanObjLstS: Array<clsvgs_ResearchPlanEN>): Array<clsvgs_ResearchPlanEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrvgs_ResearchPlanObjLst = new Array<clsvgs_ResearchPlanEN>();
for (const objInFor of arrvgs_ResearchPlanObjLstS) {
const obj1 = vgs_ResearchPlan_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrvgs_ResearchPlanObjLst.push(obj1);
}
return arrvgs_ResearchPlanObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vgs_ResearchPlan_GetObjByJSONStr (strJSON: string): clsvgs_ResearchPlanEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjvgs_ResearchPlanEN = new clsvgs_ResearchPlanEN();
if (strJSON === "")
{
return pobjvgs_ResearchPlanEN;
}
try
{
pobjvgs_ResearchPlanEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvgs_ResearchPlanEN;
}
return pobjvgs_ResearchPlanEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function vgs_ResearchPlan_GetCombineCondition(objvgs_ResearchPlan_Cond: clsvgs_ResearchPlanEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objvgs_ResearchPlan_Cond.dicFldComparisonOp, clsvgs_ResearchPlanEN.con_PlanId) == true)
{
const strComparisonOp_PlanId:string = objvgs_ResearchPlan_Cond.dicFldComparisonOp[clsvgs_ResearchPlanEN.con_PlanId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_ResearchPlanEN.con_PlanId, objvgs_ResearchPlan_Cond.planId, strComparisonOp_PlanId);
}
if (Object.prototype.hasOwnProperty.call(objvgs_ResearchPlan_Cond.dicFldComparisonOp, clsvgs_ResearchPlanEN.con_TopicId) == true)
{
const strComparisonOp_TopicId:string = objvgs_ResearchPlan_Cond.dicFldComparisonOp[clsvgs_ResearchPlanEN.con_TopicId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_ResearchPlanEN.con_TopicId, objvgs_ResearchPlan_Cond.topicId, strComparisonOp_TopicId);
}
if (Object.prototype.hasOwnProperty.call(objvgs_ResearchPlan_Cond.dicFldComparisonOp, clsvgs_ResearchPlanEN.con_TopicName) == true)
{
const strComparisonOp_TopicName:string = objvgs_ResearchPlan_Cond.dicFldComparisonOp[clsvgs_ResearchPlanEN.con_TopicName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_ResearchPlanEN.con_TopicName, objvgs_ResearchPlan_Cond.topicName, strComparisonOp_TopicName);
}
if (Object.prototype.hasOwnProperty.call(objvgs_ResearchPlan_Cond.dicFldComparisonOp, clsvgs_ResearchPlanEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objvgs_ResearchPlan_Cond.dicFldComparisonOp[clsvgs_ResearchPlanEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_ResearchPlanEN.con_id_CurrEduCls, objvgs_ResearchPlan_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (Object.prototype.hasOwnProperty.call(objvgs_ResearchPlan_Cond.dicFldComparisonOp, clsvgs_ResearchPlanEN.con_StatusId) == true)
{
const strComparisonOp_StatusId:string = objvgs_ResearchPlan_Cond.dicFldComparisonOp[clsvgs_ResearchPlanEN.con_StatusId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_ResearchPlanEN.con_StatusId, objvgs_ResearchPlan_Cond.statusId, strComparisonOp_StatusId);
}
if (Object.prototype.hasOwnProperty.call(objvgs_ResearchPlan_Cond.dicFldComparisonOp, clsvgs_ResearchPlanEN.con_StatusName) == true)
{
const strComparisonOp_StatusName:string = objvgs_ResearchPlan_Cond.dicFldComparisonOp[clsvgs_ResearchPlanEN.con_StatusName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_ResearchPlanEN.con_StatusName, objvgs_ResearchPlan_Cond.statusName, strComparisonOp_StatusName);
}
if (Object.prototype.hasOwnProperty.call(objvgs_ResearchPlan_Cond.dicFldComparisonOp, clsvgs_ResearchPlanEN.con_PlanContent) == true)
{
const strComparisonOp_PlanContent:string = objvgs_ResearchPlan_Cond.dicFldComparisonOp[clsvgs_ResearchPlanEN.con_PlanContent];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_ResearchPlanEN.con_PlanContent, objvgs_ResearchPlan_Cond.planContent, strComparisonOp_PlanContent);
}
if (Object.prototype.hasOwnProperty.call(objvgs_ResearchPlan_Cond.dicFldComparisonOp, clsvgs_ResearchPlanEN.con_ResponsibleUser) == true)
{
const strComparisonOp_ResponsibleUser:string = objvgs_ResearchPlan_Cond.dicFldComparisonOp[clsvgs_ResearchPlanEN.con_ResponsibleUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_ResearchPlanEN.con_ResponsibleUser, objvgs_ResearchPlan_Cond.responsibleUser, strComparisonOp_ResponsibleUser);
}
if (Object.prototype.hasOwnProperty.call(objvgs_ResearchPlan_Cond.dicFldComparisonOp, clsvgs_ResearchPlanEN.con_StartDate) == true)
{
const strComparisonOp_StartDate:string = objvgs_ResearchPlan_Cond.dicFldComparisonOp[clsvgs_ResearchPlanEN.con_StartDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_ResearchPlanEN.con_StartDate, objvgs_ResearchPlan_Cond.startDate, strComparisonOp_StartDate);
}
if (Object.prototype.hasOwnProperty.call(objvgs_ResearchPlan_Cond.dicFldComparisonOp, clsvgs_ResearchPlanEN.con_EndDate) == true)
{
const strComparisonOp_EndDate:string = objvgs_ResearchPlan_Cond.dicFldComparisonOp[clsvgs_ResearchPlanEN.con_EndDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_ResearchPlanEN.con_EndDate, objvgs_ResearchPlan_Cond.endDate, strComparisonOp_EndDate);
}
if (Object.prototype.hasOwnProperty.call(objvgs_ResearchPlan_Cond.dicFldComparisonOp, clsvgs_ResearchPlanEN.con_ActualFinishingDate) == true)
{
const strComparisonOp_ActualFinishingDate:string = objvgs_ResearchPlan_Cond.dicFldComparisonOp[clsvgs_ResearchPlanEN.con_ActualFinishingDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_ResearchPlanEN.con_ActualFinishingDate, objvgs_ResearchPlan_Cond.actualFinishingDate, strComparisonOp_ActualFinishingDate);
}
if (Object.prototype.hasOwnProperty.call(objvgs_ResearchPlan_Cond.dicFldComparisonOp, clsvgs_ResearchPlanEN.con_AcceptanceUser) == true)
{
const strComparisonOp_AcceptanceUser:string = objvgs_ResearchPlan_Cond.dicFldComparisonOp[clsvgs_ResearchPlanEN.con_AcceptanceUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_ResearchPlanEN.con_AcceptanceUser, objvgs_ResearchPlan_Cond.acceptanceUser, strComparisonOp_AcceptanceUser);
}
if (Object.prototype.hasOwnProperty.call(objvgs_ResearchPlan_Cond.dicFldComparisonOp, clsvgs_ResearchPlanEN.con_IsSubmit) == true)
{
if (objvgs_ResearchPlan_Cond.isSubmit == true)
{
strWhereCond += Format(" And {0} = '1'", clsvgs_ResearchPlanEN.con_IsSubmit);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvgs_ResearchPlanEN.con_IsSubmit);
}
}
if (Object.prototype.hasOwnProperty.call(objvgs_ResearchPlan_Cond.dicFldComparisonOp, clsvgs_ResearchPlanEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objvgs_ResearchPlan_Cond.dicFldComparisonOp[clsvgs_ResearchPlanEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_ResearchPlanEN.con_UpdUser, objvgs_ResearchPlan_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objvgs_ResearchPlan_Cond.dicFldComparisonOp, clsvgs_ResearchPlanEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objvgs_ResearchPlan_Cond.dicFldComparisonOp[clsvgs_ResearchPlanEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_ResearchPlanEN.con_UpdDate, objvgs_ResearchPlan_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objvgs_ResearchPlan_Cond.dicFldComparisonOp, clsvgs_ResearchPlanEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objvgs_ResearchPlan_Cond.dicFldComparisonOp[clsvgs_ResearchPlanEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_ResearchPlanEN.con_Memo, objvgs_ResearchPlan_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objvgs_ResearchPlan_Cond.dicFldComparisonOp, clsvgs_ResearchPlanEN.con_PlanTypeId) == true)
{
const strComparisonOp_PlanTypeId:string = objvgs_ResearchPlan_Cond.dicFldComparisonOp[clsvgs_ResearchPlanEN.con_PlanTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_ResearchPlanEN.con_PlanTypeId, objvgs_ResearchPlan_Cond.planTypeId, strComparisonOp_PlanTypeId);
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objvgs_ResearchPlanENS:源对象
 * @param objvgs_ResearchPlanENT:目标对象
*/
export function vgs_ResearchPlan_CopyObjTo(objvgs_ResearchPlanENS: clsvgs_ResearchPlanEN , objvgs_ResearchPlanENT: clsvgs_ResearchPlanEN ): void 
{
objvgs_ResearchPlanENT.planId = objvgs_ResearchPlanENS.planId; //计划Id
objvgs_ResearchPlanENT.topicId = objvgs_ResearchPlanENS.topicId; //主题Id
objvgs_ResearchPlanENT.topicName = objvgs_ResearchPlanENS.topicName; //栏目主题
objvgs_ResearchPlanENT.id_CurrEduCls = objvgs_ResearchPlanENS.id_CurrEduCls; //教学班流水号
objvgs_ResearchPlanENT.statusId = objvgs_ResearchPlanENS.statusId; //状态Id
objvgs_ResearchPlanENT.statusName = objvgs_ResearchPlanENS.statusName; //状态名称
objvgs_ResearchPlanENT.planContent = objvgs_ResearchPlanENS.planContent; //计划内容
objvgs_ResearchPlanENT.responsibleUser = objvgs_ResearchPlanENS.responsibleUser; //负责人/小组
objvgs_ResearchPlanENT.startDate = objvgs_ResearchPlanENS.startDate; //开始日期
objvgs_ResearchPlanENT.endDate = objvgs_ResearchPlanENS.endDate; //截止日期
objvgs_ResearchPlanENT.actualFinishingDate = objvgs_ResearchPlanENS.actualFinishingDate; //实际完成日期
objvgs_ResearchPlanENT.acceptanceUser = objvgs_ResearchPlanENS.acceptanceUser; //验收用户
objvgs_ResearchPlanENT.isSubmit = objvgs_ResearchPlanENS.isSubmit; //是否提交
objvgs_ResearchPlanENT.updUser = objvgs_ResearchPlanENS.updUser; //修改人
objvgs_ResearchPlanENT.updDate = objvgs_ResearchPlanENS.updDate; //修改日期
objvgs_ResearchPlanENT.memo = objvgs_ResearchPlanENS.memo; //备注
objvgs_ResearchPlanENT.planTypeId = objvgs_ResearchPlanENS.planTypeId; //计划类型
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objvgs_ResearchPlanENS:源对象
 * @param objvgs_ResearchPlanENT:目标对象
*/
export function vgs_ResearchPlan_GetObjFromJsonObj(objvgs_ResearchPlanENS: clsvgs_ResearchPlanEN): clsvgs_ResearchPlanEN 
{
 const objvgs_ResearchPlanENT: clsvgs_ResearchPlanEN = new clsvgs_ResearchPlanEN();
ObjectAssign(objvgs_ResearchPlanENT, objvgs_ResearchPlanENS);
 return objvgs_ResearchPlanENT;
}