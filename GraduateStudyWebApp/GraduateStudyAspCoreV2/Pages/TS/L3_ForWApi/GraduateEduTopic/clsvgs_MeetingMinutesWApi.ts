﻿
 /**
 * 类名:clsvgs_MeetingMinutesWApi
 * 表名:vgs_MeetingMinutes(01120768)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:47:57
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
 * 会议纪要视图(vgs_MeetingMinutes)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2023年03月13日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { enumComparisonOp } from "../../PubFun/enumComparisonOp.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { clsvgs_MeetingMinutesEN } from "../../L0_Entity/GraduateEduTopic/clsvgs_MeetingMinutesEN.js";
import { BindDdl_ObjLstInDiv_V, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const vgs_MeetingMinutes_Controller = "vgs_MeetingMinutesApi";
 export const vgs_MeetingMinutes_ConstructorName = "vgs_MeetingMinutes";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strMeetingId:关键字
 * @returns 对象
 **/
export async function vgs_MeetingMinutes_GetObjByMeetingIdAsync(strMeetingId: string): Promise<clsvgs_MeetingMinutesEN|null>  
{
const strThisFuncName = "GetObjByMeetingIdAsync";

if (IsNullOrEmpty(strMeetingId) == true)
{
  const strMsg = Format("参数:[strMeetingId]不能为空！(In clsvgs_MeetingMinutesWApi.GetObjByMeetingIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strMeetingId.length != 10)
{
const strMsg = Format("缓存分类变量:[strMeetingId]的长度:[{0}]不正确！(clsvgs_MeetingMinutesWApi.GetObjByMeetingIdAsync)", strMeetingId.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByMeetingId";
const strUrl = GetWebApiUrl(vgs_MeetingMinutes_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strMeetingId": strMeetingId,
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
const objvgs_MeetingMinutes = vgs_MeetingMinutes_GetObjFromJsonObj(returnObj);
return objvgs_MeetingMinutes;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_MeetingMinutes_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_MeetingMinutes_ConstructorName, strThisFuncName);
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
 * @param strMeetingId:所给的关键字
 * @returns 对象
*/
export async function vgs_MeetingMinutes_GetObjByMeetingId_Cache(strMeetingId: string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByMeetingId_Cache";

if (IsNullOrEmpty(strMeetingId) == true)
{
  const strMsg = Format("参数:[strMeetingId]不能为空！(In clsvgs_MeetingMinutesWApi.GetObjByMeetingId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strMeetingId.length != 10)
{
const strMsg = Format("缓存分类变量:[strMeetingId]的长度:[{0}]不正确！(clsvgs_MeetingMinutesWApi.GetObjByMeetingId_Cache)", strMeetingId.length);
console.error(strMsg);
throw (strMsg);
}
const arrvgs_MeetingMinutesObjLst_Cache = await vgs_MeetingMinutes_GetObjLst_Cache();
try
{
const arrvgs_MeetingMinutes_Sel: Array <clsvgs_MeetingMinutesEN> = arrvgs_MeetingMinutesObjLst_Cache.filter(x => 
 x.meetingId == strMeetingId );
let objvgs_MeetingMinutes: clsvgs_MeetingMinutesEN;
if (arrvgs_MeetingMinutes_Sel.length > 0)
{
objvgs_MeetingMinutes = arrvgs_MeetingMinutes_Sel[0];
return objvgs_MeetingMinutes;
}
else
{
if (bolTryAsyncOnce == true)
{
const objvgs_MeetingMinutes_Const = await vgs_MeetingMinutes_GetObjByMeetingIdAsync(strMeetingId);
if (objvgs_MeetingMinutes_Const != null)
{
vgs_MeetingMinutes_ReFreshThisCache();
return objvgs_MeetingMinutes_Const;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strMeetingId, vgs_MeetingMinutes_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param strMeetingId:所给的关键字
 * @returns 对象
*/
export async function vgs_MeetingMinutes_GetObjByMeetingId_localStorage(strMeetingId: string) {
const strThisFuncName = "GetObjByMeetingId_localStorage";

if (IsNullOrEmpty(strMeetingId) == true)
{
  const strMsg = Format("参数:[strMeetingId]不能为空！(In clsvgs_MeetingMinutesWApi.GetObjByMeetingId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
if (strMeetingId.length != 10)
{
const strMsg = Format("缓存分类变量:[strMeetingId]的长度:[{0}]不正确！(clsvgs_MeetingMinutesWApi.GetObjByMeetingId_localStorage)", strMeetingId.length);
console.error(strMsg);
throw (strMsg);
}
const strKey = Format("{0}_{1}", clsvgs_MeetingMinutesEN._CurrTabName, strMeetingId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objvgs_MeetingMinutes_Cache: clsvgs_MeetingMinutesEN = JSON.parse(strTempObj);
return objvgs_MeetingMinutes_Cache;
}
try
{
const objvgs_MeetingMinutes = await vgs_MeetingMinutes_GetObjByMeetingIdAsync(strMeetingId);
if (objvgs_MeetingMinutes != null)
{
localStorage.setItem(strKey, JSON.stringify(objvgs_MeetingMinutes));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objvgs_MeetingMinutes;
}
return objvgs_MeetingMinutes;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strMeetingId, vgs_MeetingMinutes_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
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
 * @returns 返回一个输出字段值
*/
export async function vgs_MeetingMinutes_func(strInFldName:string , strOutFldName:string , strInValue:string )
{
//const strThisFuncName = "func";

if (strInFldName != clsvgs_MeetingMinutesEN.con_MeetingId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsvgs_MeetingMinutesEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strOutFldName, clsvgs_MeetingMinutesEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strMeetingId = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objvgs_MeetingMinutes = await vgs_MeetingMinutes_GetObjByMeetingId_Cache(strMeetingId );
if (objvgs_MeetingMinutes == null) return "";
if (objvgs_MeetingMinutes.GetFldValue(strOutFldName) == null) return "";
return objvgs_MeetingMinutes.GetFldValue(strOutFldName).toString();
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
export function vgs_MeetingMinutes_SortFun_Defa(a:clsvgs_MeetingMinutesEN , b:clsvgs_MeetingMinutesEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.meetingId.localeCompare(b.meetingId);
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
export function vgs_MeetingMinutes_SortFun_Defa_2Fld(a:clsvgs_MeetingMinutesEN , b:clsvgs_MeetingMinutesEN): number 
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
export function vgs_MeetingMinutes_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsvgs_MeetingMinutesEN.con_MeetingId:
return (a: clsvgs_MeetingMinutesEN, b: clsvgs_MeetingMinutesEN) => {
return a.meetingId.localeCompare(b.meetingId);
}
case clsvgs_MeetingMinutesEN.con_TopicId:
return (a: clsvgs_MeetingMinutesEN, b: clsvgs_MeetingMinutesEN) => {
if (a.topicId == null) return -1;
if (b.topicId == null) return 1;
return a.topicId.localeCompare(b.topicId);
}
case clsvgs_MeetingMinutesEN.con_IsSubmit:
return (a: clsvgs_MeetingMinutesEN, b: clsvgs_MeetingMinutesEN) => {
if (a.isSubmit == true) return 1;
else return -1
}
case clsvgs_MeetingMinutesEN.con_TopicName:
return (a: clsvgs_MeetingMinutesEN, b: clsvgs_MeetingMinutesEN) => {
if (a.topicName == null) return -1;
if (b.topicName == null) return 1;
return a.topicName.localeCompare(b.topicName);
}
case clsvgs_MeetingMinutesEN.con_MeetingContent:
return (a: clsvgs_MeetingMinutesEN, b: clsvgs_MeetingMinutesEN) => {
if (a.meetingContent == null) return -1;
if (b.meetingContent == null) return 1;
return a.meetingContent.localeCompare(b.meetingContent);
}
case clsvgs_MeetingMinutesEN.con_MeetingDate:
return (a: clsvgs_MeetingMinutesEN, b: clsvgs_MeetingMinutesEN) => {
if (a.meetingDate == null) return -1;
if (b.meetingDate == null) return 1;
return a.meetingDate.localeCompare(b.meetingDate);
}
case clsvgs_MeetingMinutesEN.con_UpdDate:
return (a: clsvgs_MeetingMinutesEN, b: clsvgs_MeetingMinutesEN) => {
if (a.updDate == null) return -1;
if (b.updDate == null) return 1;
return a.updDate.localeCompare(b.updDate);
}
case clsvgs_MeetingMinutesEN.con_UpdUser:
return (a: clsvgs_MeetingMinutesEN, b: clsvgs_MeetingMinutesEN) => {
if (a.updUser == null) return -1;
if (b.updUser == null) return 1;
return a.updUser.localeCompare(b.updUser);
}
case clsvgs_MeetingMinutesEN.con_Year:
return (a: clsvgs_MeetingMinutesEN, b: clsvgs_MeetingMinutesEN) => {
if (a.year == null) return -1;
if (b.year == null) return 1;
return a.year.localeCompare(b.year);
}
case clsvgs_MeetingMinutesEN.con_Month:
return (a: clsvgs_MeetingMinutesEN, b: clsvgs_MeetingMinutesEN) => {
if (a.month == null) return -1;
if (b.month == null) return 1;
return a.month.localeCompare(b.month);
}
case clsvgs_MeetingMinutesEN.con_Memo:
return (a: clsvgs_MeetingMinutesEN, b: clsvgs_MeetingMinutesEN) => {
if (a.memo == null) return -1;
if (b.memo == null) return 1;
return a.memo.localeCompare(b.memo);
}
case clsvgs_MeetingMinutesEN.con_VersionCount:
return (a: clsvgs_MeetingMinutesEN, b: clsvgs_MeetingMinutesEN) => {
return a.versionCount-b.versionCount;
}
case clsvgs_MeetingMinutesEN.con_Participants:
return (a: clsvgs_MeetingMinutesEN, b: clsvgs_MeetingMinutesEN) => {
if (a.participants == null) return -1;
if (b.participants == null) return 1;
return a.participants.localeCompare(b.participants);
}
case clsvgs_MeetingMinutesEN.con_id_CurrEduCls:
return (a: clsvgs_MeetingMinutesEN, b: clsvgs_MeetingMinutesEN) => {
if (a.id_CurrEduCls == null) return -1;
if (b.id_CurrEduCls == null) return 1;
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vgs_MeetingMinutes]中不存在！(in ${ vgs_MeetingMinutes_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsvgs_MeetingMinutesEN.con_MeetingId:
return (a: clsvgs_MeetingMinutesEN, b: clsvgs_MeetingMinutesEN) => {
return b.meetingId.localeCompare(a.meetingId);
}
case clsvgs_MeetingMinutesEN.con_TopicId:
return (a: clsvgs_MeetingMinutesEN, b: clsvgs_MeetingMinutesEN) => {
if (b.topicId == null) return -1;
if (a.topicId == null) return 1;
return b.topicId.localeCompare(a.topicId);
}
case clsvgs_MeetingMinutesEN.con_IsSubmit:
return (a: clsvgs_MeetingMinutesEN, b: clsvgs_MeetingMinutesEN) => {
if (b.isSubmit == true) return 1;
else return -1
}
case clsvgs_MeetingMinutesEN.con_TopicName:
return (a: clsvgs_MeetingMinutesEN, b: clsvgs_MeetingMinutesEN) => {
if (b.topicName == null) return -1;
if (a.topicName == null) return 1;
return b.topicName.localeCompare(a.topicName);
}
case clsvgs_MeetingMinutesEN.con_MeetingContent:
return (a: clsvgs_MeetingMinutesEN, b: clsvgs_MeetingMinutesEN) => {
if (b.meetingContent == null) return -1;
if (a.meetingContent == null) return 1;
return b.meetingContent.localeCompare(a.meetingContent);
}
case clsvgs_MeetingMinutesEN.con_MeetingDate:
return (a: clsvgs_MeetingMinutesEN, b: clsvgs_MeetingMinutesEN) => {
if (b.meetingDate == null) return -1;
if (a.meetingDate == null) return 1;
return b.meetingDate.localeCompare(a.meetingDate);
}
case clsvgs_MeetingMinutesEN.con_UpdDate:
return (a: clsvgs_MeetingMinutesEN, b: clsvgs_MeetingMinutesEN) => {
if (b.updDate == null) return -1;
if (a.updDate == null) return 1;
return b.updDate.localeCompare(a.updDate);
}
case clsvgs_MeetingMinutesEN.con_UpdUser:
return (a: clsvgs_MeetingMinutesEN, b: clsvgs_MeetingMinutesEN) => {
if (b.updUser == null) return -1;
if (a.updUser == null) return 1;
return b.updUser.localeCompare(a.updUser);
}
case clsvgs_MeetingMinutesEN.con_Year:
return (a: clsvgs_MeetingMinutesEN, b: clsvgs_MeetingMinutesEN) => {
if (b.year == null) return -1;
if (a.year == null) return 1;
return b.year.localeCompare(a.year);
}
case clsvgs_MeetingMinutesEN.con_Month:
return (a: clsvgs_MeetingMinutesEN, b: clsvgs_MeetingMinutesEN) => {
if (b.month == null) return -1;
if (a.month == null) return 1;
return b.month.localeCompare(a.month);
}
case clsvgs_MeetingMinutesEN.con_Memo:
return (a: clsvgs_MeetingMinutesEN, b: clsvgs_MeetingMinutesEN) => {
if (b.memo == null) return -1;
if (a.memo == null) return 1;
return b.memo.localeCompare(a.memo);
}
case clsvgs_MeetingMinutesEN.con_VersionCount:
return (a: clsvgs_MeetingMinutesEN, b: clsvgs_MeetingMinutesEN) => {
return b.versionCount-a.versionCount;
}
case clsvgs_MeetingMinutesEN.con_Participants:
return (a: clsvgs_MeetingMinutesEN, b: clsvgs_MeetingMinutesEN) => {
if (b.participants == null) return -1;
if (a.participants == null) return 1;
return b.participants.localeCompare(a.participants);
}
case clsvgs_MeetingMinutesEN.con_id_CurrEduCls:
return (a: clsvgs_MeetingMinutesEN, b: clsvgs_MeetingMinutesEN) => {
if (b.id_CurrEduCls == null) return -1;
if (a.id_CurrEduCls == null) return 1;
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vgs_MeetingMinutes]中不存在！(in ${ vgs_MeetingMinutes_ConstructorName}.${ strThisFuncName})`;
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
export async function vgs_MeetingMinutes_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsvgs_MeetingMinutesEN.con_MeetingId:
return (obj: clsvgs_MeetingMinutesEN) => {
return obj.meetingId === value;
}
case clsvgs_MeetingMinutesEN.con_TopicId:
return (obj: clsvgs_MeetingMinutesEN) => {
return obj.topicId === value;
}
case clsvgs_MeetingMinutesEN.con_IsSubmit:
return (obj: clsvgs_MeetingMinutesEN) => {
return obj.isSubmit === value;
}
case clsvgs_MeetingMinutesEN.con_TopicName:
return (obj: clsvgs_MeetingMinutesEN) => {
return obj.topicName === value;
}
case clsvgs_MeetingMinutesEN.con_MeetingContent:
return (obj: clsvgs_MeetingMinutesEN) => {
return obj.meetingContent === value;
}
case clsvgs_MeetingMinutesEN.con_MeetingDate:
return (obj: clsvgs_MeetingMinutesEN) => {
return obj.meetingDate === value;
}
case clsvgs_MeetingMinutesEN.con_UpdDate:
return (obj: clsvgs_MeetingMinutesEN) => {
return obj.updDate === value;
}
case clsvgs_MeetingMinutesEN.con_UpdUser:
return (obj: clsvgs_MeetingMinutesEN) => {
return obj.updUser === value;
}
case clsvgs_MeetingMinutesEN.con_Year:
return (obj: clsvgs_MeetingMinutesEN) => {
return obj.year === value;
}
case clsvgs_MeetingMinutesEN.con_Month:
return (obj: clsvgs_MeetingMinutesEN) => {
return obj.month === value;
}
case clsvgs_MeetingMinutesEN.con_Memo:
return (obj: clsvgs_MeetingMinutesEN) => {
return obj.memo === value;
}
case clsvgs_MeetingMinutesEN.con_VersionCount:
return (obj: clsvgs_MeetingMinutesEN) => {
return obj.versionCount === value;
}
case clsvgs_MeetingMinutesEN.con_Participants:
return (obj: clsvgs_MeetingMinutesEN) => {
return obj.participants === value;
}
case clsvgs_MeetingMinutesEN.con_id_CurrEduCls:
return (obj: clsvgs_MeetingMinutesEN) => {
return obj.id_CurrEduCls === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vgs_MeetingMinutes]中不存在！(in ${ vgs_MeetingMinutes_ConstructorName}.${ strThisFuncName})`;
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
 * @returns 返回一个关键字值列表
*/
export async function vgs_MeetingMinutes_funcKey(strInFldName:string, strInValue: any, strComparisonOp:string): Promise<Array<string>> 
{
//const strThisFuncName = "funcKey";

if (strInFldName == clsvgs_MeetingMinutesEN.con_MeetingId)
{
const strMsg = Format("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (IsNullOrEmpty(strInValue) == true)
{
return [];
}
const arrvgs_MeetingMinutes = await vgs_MeetingMinutes_GetObjLst_Cache();
if (arrvgs_MeetingMinutes == null) return [];
let arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes;
const strType = typeof(strInValue);
switch (strType)
{
case "string":
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01: // " = "
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
break;
case enumComparisonOp.Like_03:
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
break;
case enumComparisonOp.In_04:
const arrValues = strInValue.split(',');
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
break;
}
break;
case "boolean":
if (strInValue == null) return [];
if (strComparisonOp == enumComparisonOp.Equal_01)
{
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
}
break;
case "number":
if (Number(strInValue) == 0) return [];
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01:
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
break;
case enumComparisonOp.NotEqual_02:
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
break;
case enumComparisonOp.NotLessThan_05://" >= ":
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
break;
case enumComparisonOp.NotGreaterThan_06://" <= ":
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
case enumComparisonOp.GreaterThan_07://" > ":
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
break;
case enumComparisonOp.LessThan_08://" < ":
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
}
break;
}
if (arrvgs_MeetingMinutes_Sel.length == 0) return [];
return arrvgs_MeetingMinutes_Sel.map(x=>x.meetingId);
}

 /**
 * 根据条件获取满足条件的第一条记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
 * @param strWhereCond:条件
 * @returns 返回的第一条记录的关键字值
 **/
export async function vgs_MeetingMinutes_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vgs_MeetingMinutes_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_MeetingMinutes_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_MeetingMinutes_ConstructorName, strThisFuncName);
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
export async function vgs_MeetingMinutes_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vgs_MeetingMinutes_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_MeetingMinutes_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_MeetingMinutes_ConstructorName, strThisFuncName);
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
export async function vgs_MeetingMinutes_GetFirstObjAsync(strWhereCond: string): Promise<clsvgs_MeetingMinutesEN|null>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(vgs_MeetingMinutes_Controller, strAction);
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
const objvgs_MeetingMinutes = vgs_MeetingMinutes_GetObjFromJsonObj(returnObj);
return objvgs_MeetingMinutes;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_MeetingMinutes_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_MeetingMinutes_ConstructorName, strThisFuncName);
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
export async function vgs_MeetingMinutes_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvgs_MeetingMinutesEN._CurrTabName;
if (IsNullOrEmpty(clsvgs_MeetingMinutesEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvgs_MeetingMinutesEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrvgs_MeetingMinutesExObjLst_Cache: Array<clsvgs_MeetingMinutesEN> = CacheHelper.Get(strKey);
const arrvgs_MeetingMinutesObjLst_T = vgs_MeetingMinutes_GetObjLstByJSONObjLst(arrvgs_MeetingMinutesExObjLst_Cache);
return arrvgs_MeetingMinutesObjLst_T;
}
try
{
const arrvgs_MeetingMinutesExObjLst = await vgs_MeetingMinutes_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrvgs_MeetingMinutesExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvgs_MeetingMinutesExObjLst.length);
console.log(strInfo);
return arrvgs_MeetingMinutesExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vgs_MeetingMinutes_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vgs_MeetingMinutes_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvgs_MeetingMinutesEN._CurrTabName;
if (IsNullOrEmpty(clsvgs_MeetingMinutesEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvgs_MeetingMinutesEN.CacheAddiCondition);
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
const arrvgs_MeetingMinutesExObjLst_Cache: Array<clsvgs_MeetingMinutesEN> = JSON.parse(strTempObjLst);
const arrvgs_MeetingMinutesObjLst_T = vgs_MeetingMinutes_GetObjLstByJSONObjLst(arrvgs_MeetingMinutesExObjLst_Cache);
return arrvgs_MeetingMinutesObjLst_T;
}
try
{
const arrvgs_MeetingMinutesExObjLst = await vgs_MeetingMinutes_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrvgs_MeetingMinutesExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvgs_MeetingMinutesExObjLst.length);
console.log(strInfo);
return arrvgs_MeetingMinutesExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vgs_MeetingMinutes_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vgs_MeetingMinutes_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsvgs_MeetingMinutesEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrvgs_MeetingMinutesObjLst_Cache: Array<clsvgs_MeetingMinutesEN> = JSON.parse(strTempObjLst);
return arrvgs_MeetingMinutesObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function vgs_MeetingMinutes_GetObjLstAsync(strWhereCond: string): Promise<Array<clsvgs_MeetingMinutesEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(vgs_MeetingMinutes_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_MeetingMinutes_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vgs_MeetingMinutes_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_MeetingMinutes_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_MeetingMinutes_ConstructorName, strThisFuncName);
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
export async function vgs_MeetingMinutes_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvgs_MeetingMinutesEN._CurrTabName;
if (IsNullOrEmpty(clsvgs_MeetingMinutesEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvgs_MeetingMinutesEN.CacheAddiCondition);
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
const arrvgs_MeetingMinutesExObjLst_Cache: Array<clsvgs_MeetingMinutesEN> = JSON.parse(strTempObjLst);
const arrvgs_MeetingMinutesObjLst_T = vgs_MeetingMinutes_GetObjLstByJSONObjLst(arrvgs_MeetingMinutesExObjLst_Cache);
return arrvgs_MeetingMinutesObjLst_T;
}
try
{
const arrvgs_MeetingMinutesExObjLst = await vgs_MeetingMinutes_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrvgs_MeetingMinutesExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvgs_MeetingMinutesExObjLst.length);
console.log(strInfo);
return arrvgs_MeetingMinutesExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vgs_MeetingMinutes_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vgs_MeetingMinutes_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsvgs_MeetingMinutesEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrvgs_MeetingMinutesObjLst_Cache: Array<clsvgs_MeetingMinutesEN> = JSON.parse(strTempObjLst);
return arrvgs_MeetingMinutesObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vgs_MeetingMinutes_GetObjLst_Cache(): Promise<Array<clsvgs_MeetingMinutesEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrvgs_MeetingMinutesObjLst_Cache;
switch (clsvgs_MeetingMinutesEN.CacheModeId)
{
case "04"://sessionStorage
arrvgs_MeetingMinutesObjLst_Cache = await vgs_MeetingMinutes_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrvgs_MeetingMinutesObjLst_Cache = await vgs_MeetingMinutes_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrvgs_MeetingMinutesObjLst_Cache = await vgs_MeetingMinutes_GetObjLst_ClientCache();
break;
default:
arrvgs_MeetingMinutesObjLst_Cache = await vgs_MeetingMinutes_GetObjLst_ClientCache();
break;
}
const arrvgs_MeetingMinutesObjLst = vgs_MeetingMinutes_GetObjLstByJSONObjLst(arrvgs_MeetingMinutesObjLst_Cache);
return arrvgs_MeetingMinutesObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vgs_MeetingMinutes_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrvgs_MeetingMinutesObjLst_Cache;
switch (clsvgs_MeetingMinutesEN.CacheModeId)
{
case "04"://sessionStorage
arrvgs_MeetingMinutesObjLst_Cache = await vgs_MeetingMinutes_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrvgs_MeetingMinutesObjLst_Cache = await vgs_MeetingMinutes_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrvgs_MeetingMinutesObjLst_Cache = null;
break;
default:
arrvgs_MeetingMinutesObjLst_Cache = null;
break;
}
return arrvgs_MeetingMinutesObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrMeetingId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vgs_MeetingMinutes_GetSubObjLst_Cache(objvgs_MeetingMinutes_Cond: clsvgs_MeetingMinutesEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrvgs_MeetingMinutesObjLst_Cache = await vgs_MeetingMinutes_GetObjLst_Cache();
let arrvgs_MeetingMinutes_Sel: Array < clsvgs_MeetingMinutesEN > = arrvgs_MeetingMinutesObjLst_Cache;
if (objvgs_MeetingMinutes_Cond.sf_FldComparisonOp == null || objvgs_MeetingMinutes_Cond.sf_FldComparisonOp == "") return arrvgs_MeetingMinutes_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvgs_MeetingMinutes_Cond.sf_FldComparisonOp);
//console.log("clsvgs_MeetingMinutesWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvgs_MeetingMinutes_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvgs_MeetingMinutes_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvgs_MeetingMinutes_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objvgs_MeetingMinutes_Cond), vgs_MeetingMinutes_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvgs_MeetingMinutesEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrMeetingId:关键字列表
 * @returns 对象列表
 **/
export async function vgs_MeetingMinutes_GetObjLstByMeetingIdLstAsync(arrMeetingId: Array<string>): Promise<Array<clsvgs_MeetingMinutesEN>>  
{
const strThisFuncName = "GetObjLstByMeetingIdLstAsync";
const strAction = "GetObjLstByMeetingIdLst";
const strUrl = GetWebApiUrl(vgs_MeetingMinutes_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrMeetingId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_MeetingMinutes_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vgs_MeetingMinutes_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_MeetingMinutes_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_MeetingMinutes_ConstructorName, strThisFuncName);
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
 * @param arrstrMeetingIdLst:关键字列表
 * @returns 对象列表
*/
export async function vgs_MeetingMinutes_GetObjLstByMeetingIdLst_Cache(arrMeetingIdLst: Array<string>) {
const strThisFuncName = "GetObjLstByMeetingIdLst_Cache";
try
{
const arrvgs_MeetingMinutesObjLst_Cache = await vgs_MeetingMinutes_GetObjLst_Cache();
const arrvgs_MeetingMinutes_Sel: Array <clsvgs_MeetingMinutesEN> = arrvgs_MeetingMinutesObjLst_Cache.filter(x => arrMeetingIdLst.indexOf(x.meetingId)>-1);
return arrvgs_MeetingMinutes_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrMeetingIdLst.join(","), vgs_MeetingMinutes_ConstructorName, strThisFuncName);
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
export async function vgs_MeetingMinutes_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsvgs_MeetingMinutesEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(vgs_MeetingMinutes_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_MeetingMinutes_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vgs_MeetingMinutes_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_MeetingMinutes_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_MeetingMinutes_ConstructorName, strThisFuncName);
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
export async function vgs_MeetingMinutes_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsvgs_MeetingMinutesEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vgs_MeetingMinutes_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_MeetingMinutes_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vgs_MeetingMinutes_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_MeetingMinutes_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_MeetingMinutes_ConstructorName, strThisFuncName);
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
export async function vgs_MeetingMinutes_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vgs_MeetingMinutes_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_MeetingMinutes_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_MeetingMinutes_ConstructorName, strThisFuncName);
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
export async function vgs_MeetingMinutes_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
if (objPagerPara.pageIndex == 0) return new Array<clsvgs_MeetingMinutesEN>();
const arrvgs_MeetingMinutesObjLst_Cache = await vgs_MeetingMinutes_GetObjLst_Cache();
if (arrvgs_MeetingMinutesObjLst_Cache.length == 0) return arrvgs_MeetingMinutesObjLst_Cache;
let arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutesObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objvgs_MeetingMinutes_Cond = new clsvgs_MeetingMinutesEN();
ObjectAssign(objvgs_MeetingMinutes_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsvgs_MeetingMinutesWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvgs_MeetingMinutes_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvgs_MeetingMinutes_Sel.length == 0) return arrvgs_MeetingMinutes_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.sort(vgs_MeetingMinutes_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.sort(objPagerPara.sortFun);
}
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.slice(intStart, intEnd);     
return arrvgs_MeetingMinutes_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, vgs_MeetingMinutes_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvgs_MeetingMinutesEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function vgs_MeetingMinutes_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsvgs_MeetingMinutesEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
if (objPagerPara.pageIndex == 0) return new Array<clsvgs_MeetingMinutesEN>();
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(vgs_MeetingMinutes_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_MeetingMinutes_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vgs_MeetingMinutes_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_MeetingMinutes_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_MeetingMinutes_ConstructorName, strThisFuncName);
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
 * @param objstrMeetingId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vgs_MeetingMinutes_IsExistRecord_Cache(objvgs_MeetingMinutes_Cond: clsvgs_MeetingMinutesEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrvgs_MeetingMinutesObjLst_Cache = await vgs_MeetingMinutes_GetObjLst_Cache();
if (arrvgs_MeetingMinutesObjLst_Cache == null) return false;
let arrvgs_MeetingMinutes_Sel: Array < clsvgs_MeetingMinutesEN > = arrvgs_MeetingMinutesObjLst_Cache;
if (objvgs_MeetingMinutes_Cond.sf_FldComparisonOp == null || objvgs_MeetingMinutes_Cond.sf_FldComparisonOp == "") return arrvgs_MeetingMinutes_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvgs_MeetingMinutes_Cond.sf_FldComparisonOp);
//console.log("clsvgs_MeetingMinutesWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvgs_MeetingMinutes_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvgs_MeetingMinutes_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvgs_MeetingMinutes_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objvgs_MeetingMinutes_Cond), vgs_MeetingMinutes_ConstructorName, strThisFuncName);
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
export async function vgs_MeetingMinutes_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(vgs_MeetingMinutes_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_MeetingMinutes_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_MeetingMinutes_ConstructorName, strThisFuncName);
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
 * @param strMeetingId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function vgs_MeetingMinutes_IsExist(strMeetingId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vgs_MeetingMinutes_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"MeetingId": strMeetingId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_MeetingMinutes_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_MeetingMinutes_ConstructorName, strThisFuncName);
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
 * @param strMeetingId:所给的关键字
 * @returns 对象
*/
export async function vgs_MeetingMinutes_IsExist_Cache(strMeetingId:string) {
const strThisFuncName = "IsExist_Cache";
const arrvgs_MeetingMinutesObjLst_Cache = await vgs_MeetingMinutes_GetObjLst_Cache();
if (arrvgs_MeetingMinutesObjLst_Cache == null) return false;
try
{
const arrvgs_MeetingMinutes_Sel: Array <clsvgs_MeetingMinutesEN> = arrvgs_MeetingMinutesObjLst_Cache.filter(x => x.meetingId == strMeetingId);
if (arrvgs_MeetingMinutes_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strMeetingId, vgs_MeetingMinutes_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param strMeetingId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function vgs_MeetingMinutes_IsExistAsync(strMeetingId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vgs_MeetingMinutes_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strMeetingId": strMeetingId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_MeetingMinutes_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_MeetingMinutes_ConstructorName, strThisFuncName);
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
export async function vgs_MeetingMinutes_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(vgs_MeetingMinutes_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_MeetingMinutes_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_MeetingMinutes_ConstructorName, strThisFuncName);
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
 * @param objvgs_MeetingMinutes_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function vgs_MeetingMinutes_GetRecCountByCond_Cache(objvgs_MeetingMinutes_Cond: clsvgs_MeetingMinutesEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrvgs_MeetingMinutesObjLst_Cache = await vgs_MeetingMinutes_GetObjLst_Cache();
if (arrvgs_MeetingMinutesObjLst_Cache == null) return 0;
let arrvgs_MeetingMinutes_Sel: Array < clsvgs_MeetingMinutesEN > = arrvgs_MeetingMinutesObjLst_Cache;
if (objvgs_MeetingMinutes_Cond.sf_FldComparisonOp == null || objvgs_MeetingMinutes_Cond.sf_FldComparisonOp == "") return arrvgs_MeetingMinutes_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvgs_MeetingMinutes_Cond.sf_FldComparisonOp);
//console.log("clsvgs_MeetingMinutesWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvgs_MeetingMinutes_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvgs_MeetingMinutes_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvgs_MeetingMinutes_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objvgs_MeetingMinutes_Cond), vgs_MeetingMinutes_ConstructorName, strThisFuncName);
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
export function vgs_MeetingMinutes_GetWebApiUrl(strController: string, strAction: string): string {
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
export function vgs_MeetingMinutes_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clsvgs_MeetingMinutesEN._CurrTabName;
switch (clsvgs_MeetingMinutesEN.CacheModeId)
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
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vgs_MeetingMinutes_GetJSONStrByObj (pobjvgs_MeetingMinutesEN: clsvgs_MeetingMinutesEN): string
{
const strThisFuncName = "GetJSONStrByObj";
let strJson = "";
try
{
strJson = JSON.stringify(pobjvgs_MeetingMinutesEN);
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
export function vgs_MeetingMinutes_GetObjLstByJSONStr (strJSON: string): Array<clsvgs_MeetingMinutesEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrvgs_MeetingMinutesObjLst = new Array<clsvgs_MeetingMinutesEN>();
if (strJSON === "")
{
return arrvgs_MeetingMinutesObjLst;
}
try
{
arrvgs_MeetingMinutesObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvgs_MeetingMinutesObjLst;
}
return arrvgs_MeetingMinutesObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrvgs_MeetingMinutesObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function vgs_MeetingMinutes_GetObjLstByJSONObjLst (arrvgs_MeetingMinutesObjLstS: Array<clsvgs_MeetingMinutesEN>): Array<clsvgs_MeetingMinutesEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrvgs_MeetingMinutesObjLst = new Array<clsvgs_MeetingMinutesEN>();
for (const objInFor of arrvgs_MeetingMinutesObjLstS) {
const obj1 = vgs_MeetingMinutes_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrvgs_MeetingMinutesObjLst.push(obj1);
}
return arrvgs_MeetingMinutesObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vgs_MeetingMinutes_GetObjByJSONStr (strJSON: string): clsvgs_MeetingMinutesEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjvgs_MeetingMinutesEN = new clsvgs_MeetingMinutesEN();
if (strJSON === "")
{
return pobjvgs_MeetingMinutesEN;
}
try
{
pobjvgs_MeetingMinutesEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvgs_MeetingMinutesEN;
}
return pobjvgs_MeetingMinutesEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function vgs_MeetingMinutes_GetCombineCondition(objvgs_MeetingMinutes_Cond: clsvgs_MeetingMinutesEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objvgs_MeetingMinutes_Cond.dicFldComparisonOp, clsvgs_MeetingMinutesEN.con_MeetingId) == true)
{
const strComparisonOp_MeetingId:string = objvgs_MeetingMinutes_Cond.dicFldComparisonOp[clsvgs_MeetingMinutesEN.con_MeetingId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_MeetingMinutesEN.con_MeetingId, objvgs_MeetingMinutes_Cond.meetingId, strComparisonOp_MeetingId);
}
if (Object.prototype.hasOwnProperty.call(objvgs_MeetingMinutes_Cond.dicFldComparisonOp, clsvgs_MeetingMinutesEN.con_TopicId) == true)
{
const strComparisonOp_TopicId:string = objvgs_MeetingMinutes_Cond.dicFldComparisonOp[clsvgs_MeetingMinutesEN.con_TopicId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_MeetingMinutesEN.con_TopicId, objvgs_MeetingMinutes_Cond.topicId, strComparisonOp_TopicId);
}
if (Object.prototype.hasOwnProperty.call(objvgs_MeetingMinutes_Cond.dicFldComparisonOp, clsvgs_MeetingMinutesEN.con_IsSubmit) == true)
{
if (objvgs_MeetingMinutes_Cond.isSubmit == true)
{
strWhereCond += Format(" And {0} = '1'", clsvgs_MeetingMinutesEN.con_IsSubmit);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvgs_MeetingMinutesEN.con_IsSubmit);
}
}
if (Object.prototype.hasOwnProperty.call(objvgs_MeetingMinutes_Cond.dicFldComparisonOp, clsvgs_MeetingMinutesEN.con_TopicName) == true)
{
const strComparisonOp_TopicName:string = objvgs_MeetingMinutes_Cond.dicFldComparisonOp[clsvgs_MeetingMinutesEN.con_TopicName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_MeetingMinutesEN.con_TopicName, objvgs_MeetingMinutes_Cond.topicName, strComparisonOp_TopicName);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objvgs_MeetingMinutes_Cond.dicFldComparisonOp, clsvgs_MeetingMinutesEN.con_MeetingDate) == true)
{
const strComparisonOp_MeetingDate:string = objvgs_MeetingMinutes_Cond.dicFldComparisonOp[clsvgs_MeetingMinutesEN.con_MeetingDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_MeetingMinutesEN.con_MeetingDate, objvgs_MeetingMinutes_Cond.meetingDate, strComparisonOp_MeetingDate);
}
if (Object.prototype.hasOwnProperty.call(objvgs_MeetingMinutes_Cond.dicFldComparisonOp, clsvgs_MeetingMinutesEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objvgs_MeetingMinutes_Cond.dicFldComparisonOp[clsvgs_MeetingMinutesEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_MeetingMinutesEN.con_UpdDate, objvgs_MeetingMinutes_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objvgs_MeetingMinutes_Cond.dicFldComparisonOp, clsvgs_MeetingMinutesEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objvgs_MeetingMinutes_Cond.dicFldComparisonOp[clsvgs_MeetingMinutesEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_MeetingMinutesEN.con_UpdUser, objvgs_MeetingMinutes_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objvgs_MeetingMinutes_Cond.dicFldComparisonOp, clsvgs_MeetingMinutesEN.con_Year) == true)
{
const strComparisonOp_Year:string = objvgs_MeetingMinutes_Cond.dicFldComparisonOp[clsvgs_MeetingMinutesEN.con_Year];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_MeetingMinutesEN.con_Year, objvgs_MeetingMinutes_Cond.year, strComparisonOp_Year);
}
if (Object.prototype.hasOwnProperty.call(objvgs_MeetingMinutes_Cond.dicFldComparisonOp, clsvgs_MeetingMinutesEN.con_Month) == true)
{
const strComparisonOp_Month:string = objvgs_MeetingMinutes_Cond.dicFldComparisonOp[clsvgs_MeetingMinutesEN.con_Month];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_MeetingMinutesEN.con_Month, objvgs_MeetingMinutes_Cond.month, strComparisonOp_Month);
}
if (Object.prototype.hasOwnProperty.call(objvgs_MeetingMinutes_Cond.dicFldComparisonOp, clsvgs_MeetingMinutesEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objvgs_MeetingMinutes_Cond.dicFldComparisonOp[clsvgs_MeetingMinutesEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_MeetingMinutesEN.con_Memo, objvgs_MeetingMinutes_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objvgs_MeetingMinutes_Cond.dicFldComparisonOp, clsvgs_MeetingMinutesEN.con_VersionCount) == true)
{
const strComparisonOp_VersionCount:string = objvgs_MeetingMinutes_Cond.dicFldComparisonOp[clsvgs_MeetingMinutesEN.con_VersionCount];
strWhereCond += Format(" And {0} {2} {1}", clsvgs_MeetingMinutesEN.con_VersionCount, objvgs_MeetingMinutes_Cond.versionCount, strComparisonOp_VersionCount);
}
if (Object.prototype.hasOwnProperty.call(objvgs_MeetingMinutes_Cond.dicFldComparisonOp, clsvgs_MeetingMinutesEN.con_Participants) == true)
{
const strComparisonOp_Participants:string = objvgs_MeetingMinutes_Cond.dicFldComparisonOp[clsvgs_MeetingMinutesEN.con_Participants];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_MeetingMinutesEN.con_Participants, objvgs_MeetingMinutes_Cond.participants, strComparisonOp_Participants);
}
if (Object.prototype.hasOwnProperty.call(objvgs_MeetingMinutes_Cond.dicFldComparisonOp, clsvgs_MeetingMinutesEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objvgs_MeetingMinutes_Cond.dicFldComparisonOp[clsvgs_MeetingMinutesEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_MeetingMinutesEN.con_id_CurrEduCls, objvgs_MeetingMinutes_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objvgs_MeetingMinutesENS:源对象
 * @param objvgs_MeetingMinutesENT:目标对象
*/
export function vgs_MeetingMinutes_CopyObjTo(objvgs_MeetingMinutesENS: clsvgs_MeetingMinutesEN , objvgs_MeetingMinutesENT: clsvgs_MeetingMinutesEN ): void 
{
objvgs_MeetingMinutesENT.meetingId = objvgs_MeetingMinutesENS.meetingId; //会议Id
objvgs_MeetingMinutesENT.topicId = objvgs_MeetingMinutesENS.topicId; //主题Id
objvgs_MeetingMinutesENT.isSubmit = objvgs_MeetingMinutesENS.isSubmit; //是否提交
objvgs_MeetingMinutesENT.topicName = objvgs_MeetingMinutesENS.topicName; //栏目主题
objvgs_MeetingMinutesENT.meetingContent = objvgs_MeetingMinutesENS.meetingContent; //会议内容
objvgs_MeetingMinutesENT.meetingDate = objvgs_MeetingMinutesENS.meetingDate; //会议日期
objvgs_MeetingMinutesENT.updDate = objvgs_MeetingMinutesENS.updDate; //修改日期
objvgs_MeetingMinutesENT.updUser = objvgs_MeetingMinutesENS.updUser; //修改人
objvgs_MeetingMinutesENT.year = objvgs_MeetingMinutesENS.year; //年
objvgs_MeetingMinutesENT.month = objvgs_MeetingMinutesENS.month; //月
objvgs_MeetingMinutesENT.memo = objvgs_MeetingMinutesENS.memo; //备注
objvgs_MeetingMinutesENT.versionCount = objvgs_MeetingMinutesENS.versionCount; //版本统计
objvgs_MeetingMinutesENT.participants = objvgs_MeetingMinutesENS.participants; //参会者
objvgs_MeetingMinutesENT.id_CurrEduCls = objvgs_MeetingMinutesENS.id_CurrEduCls; //教学班流水号
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objvgs_MeetingMinutesENS:源对象
 * @param objvgs_MeetingMinutesENT:目标对象
*/
export function vgs_MeetingMinutes_GetObjFromJsonObj(objvgs_MeetingMinutesENS: clsvgs_MeetingMinutesEN): clsvgs_MeetingMinutesEN 
{
 const objvgs_MeetingMinutesENT: clsvgs_MeetingMinutesEN = new clsvgs_MeetingMinutesEN();
ObjectAssign(objvgs_MeetingMinutesENT, objvgs_MeetingMinutesENS);
 return objvgs_MeetingMinutesENT;
}