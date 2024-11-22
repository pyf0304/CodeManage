﻿
 /**
 * 类名:clsRTUserRelaWApi
 * 表名:RTUserRela(01120582)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:47:01
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
 * 主题用户关系(RTUserRela)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clsRTUserRelaEN } from "../../L0_Entity/GraduateEduTopic/clsRTUserRelaEN.js";
import { clsOrderByData } from "../../PubFun/clsOrderByData.js";
import { vRTUserRela_ReFreshThisCache } from "../../L3_ForWApi/GraduateEduTopic/clsvRTUserRelaWApi.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { tzDataType } from "../../PubFun/jsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const rTUserRela_Controller = "RTUserRelaApi";
 export const rTUserRela_ConstructorName = "rTUserRela";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngmId:关键字
 * @returns 对象
 **/
export async function RTUserRela_GetObjBymIdAsync(lngmId: number): Promise<clsRTUserRelaEN>  
{
const strThisFuncName = "GetObjBymIdAsync";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In GetObjBymIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjBymId";
const strUrl = GetWebApiUrl(rTUserRela_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", rTUserRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objRTUserRela = RTUserRela_GetObjFromJsonObj(returnObj);
return objRTUserRela;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTUserRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTUserRela_ConstructorName, strThisFuncName);
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
 * @param lngmId:所给的关键字
 * @returns 对象
*/
export async function RTUserRela_GetObjBymId_Cache(lngmId:number,strTopicId:string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjBymId_Cache";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In GetObjBymId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
const arrRTUserRelaObjLst_Cache = await RTUserRela_GetObjLst_Cache(strTopicId);
try
{
const arrRTUserRela_Sel: Array <clsRTUserRelaEN> = arrRTUserRelaObjLst_Cache.filter(x => x.mId == lngmId);
let objRTUserRela: clsRTUserRelaEN;
if (arrRTUserRela_Sel.length > 0)
{
objRTUserRela = arrRTUserRela_Sel[0];
return objRTUserRela;
}
else
{
if (bolTryAsyncOnce == true)
{
objRTUserRela = await RTUserRela_GetObjBymIdAsync(lngmId);
if (objRTUserRela != null)
{
RTUserRela_ReFreshThisCache(strTopicId);
return objRTUserRela;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, rTUserRela_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param lngmId:所给的关键字
 * @returns 对象
*/
export async function RTUserRela_GetObjBymId_localStorage(lngmId: number) {
const strThisFuncName = "GetObjBymId_localStorage";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In GetObjBymId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
const strKey = Format("{0}_{1}", clsRTUserRelaEN._CurrTabName, lngmId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objRTUserRela_Cache: clsRTUserRelaEN = JSON.parse(strTempObj);
return objRTUserRela_Cache;
}
try
{
const objRTUserRela = await RTUserRela_GetObjBymIdAsync(lngmId);
if (objRTUserRela != null)
{
localStorage.setItem(strKey, JSON.stringify(objRTUserRela));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objRTUserRela;
}
return objRTUserRela;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, rTUserRela_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objRTUserRela:所给的对象
 * @returns 对象
*/
export async function RTUserRela_UpdateObjInLst_Cache(objRTUserRela: clsRTUserRelaEN,strTopicId: string) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrRTUserRelaObjLst_Cache = await RTUserRela_GetObjLst_Cache(strTopicId);
const obj = arrRTUserRelaObjLst_Cache.find(x => x.topicId == objRTUserRela.topicId && x.userId == objRTUserRela.userId);
if (obj != null)
{
objRTUserRela.mId = obj.mId;
ObjectAssign( obj, objRTUserRela);
}
else
{
arrRTUserRelaObjLst_Cache.push(objRTUserRela);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, rTUserRela_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
}
/*该表没有名称字段，不能生成此函数！*/

/**
 * 映射函数。根据表映射把输入字段值，映射成输出字段值
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
 * @param strInFldName:输入字段名
 * @param strOutFldName:输出字段名
 * @param strInValue:输入字段值
 @param strTopicId:缓存的分类字段
 * @returns 返回一个输出字段值
*/
export async function RTUserRela_func(strInFldName:string , strOutFldName:string , strInValue:number , strTopicId_C: string)
{
//const strThisFuncName = "func";

if (IsNullOrEmpty(strTopicId_C) == true)
{
  const strMsg = Format("参数:[strTopicId_C]不能为空！(In func)");
console.error(strMsg);
 throw (strMsg);
}
if (strTopicId_C.length != 8)
{
const strMsg = Format("缓存分类变量:[strTopicId_C]的长度:[{0}]不正确！", strTopicId_C.length);
console.error(strMsg);
throw (strMsg);
}

if (strInFldName != clsRTUserRelaEN.con_mId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsRTUserRelaEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clsRTUserRelaEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const lngmId = Number(strInValue);
if (lngmId == 0)
{
return "";
}
const objRTUserRela = await RTUserRela_GetObjBymId_Cache(lngmId , strTopicId_C);
if (objRTUserRela == null) return "";
return objRTUserRela.GetFldValue(strOutFldName).toString();
}

/**
 * 排序函数。根据关键字字段的值进行比较
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
 * @param a:比较的第1个对象
 * @param  b:比较的第1个对象
 * @returns 返回两个对象比较的结果
*/
export function RTUserRela_SortFun_Defa(a:clsRTUserRelaEN , b:clsRTUserRelaEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.mId-b.mId;
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
export function RTUserRela_SortFun_Defa_2Fld(a:clsRTUserRelaEN , b:clsRTUserRelaEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.topicId == b.topicId) return a.userId.localeCompare(b.userId);
else return a.topicId.localeCompare(b.topicId);
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
export function RTUserRela_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsRTUserRelaEN.con_mId:
return (a: clsRTUserRelaEN, b: clsRTUserRelaEN) => {
return a.mId-b.mId;
}
case clsRTUserRelaEN.con_TopicId:
return (a: clsRTUserRelaEN, b: clsRTUserRelaEN) => {
return a.topicId.localeCompare(b.topicId);
}
case clsRTUserRelaEN.con_UserId:
return (a: clsRTUserRelaEN, b: clsRTUserRelaEN) => {
return a.userId.localeCompare(b.userId);
}
case clsRTUserRelaEN.con_TopicUserRoleId:
return (a: clsRTUserRelaEN, b: clsRTUserRelaEN) => {
return a.topicUserRoleId.localeCompare(b.topicUserRoleId);
}
case clsRTUserRelaEN.con_ColorId:
return (a: clsRTUserRelaEN, b: clsRTUserRelaEN) => {
return a.colorId.localeCompare(b.colorId);
}
case clsRTUserRelaEN.con_OrderNum:
return (a: clsRTUserRelaEN, b: clsRTUserRelaEN) => {
return a.orderNum-b.orderNum;
}
case clsRTUserRelaEN.con_UserBgColor:
return (a: clsRTUserRelaEN, b: clsRTUserRelaEN) => {
return a.userBgColor.localeCompare(b.userBgColor);
}
case clsRTUserRelaEN.con_id_CurrEduCls:
return (a: clsRTUserRelaEN, b: clsRTUserRelaEN) => {
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
case clsRTUserRelaEN.con_UpdDate:
return (a: clsRTUserRelaEN, b: clsRTUserRelaEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsRTUserRelaEN.con_UpdUser:
return (a: clsRTUserRelaEN, b: clsRTUserRelaEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsRTUserRelaEN.con_Memo:
return (a: clsRTUserRelaEN, b: clsRTUserRelaEN) => {
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[RTUserRela]中不存在！(in ${ rTUserRela_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsRTUserRelaEN.con_mId:
return (a: clsRTUserRelaEN, b: clsRTUserRelaEN) => {
return b.mId-a.mId;
}
case clsRTUserRelaEN.con_TopicId:
return (a: clsRTUserRelaEN, b: clsRTUserRelaEN) => {
return b.topicId.localeCompare(a.topicId);
}
case clsRTUserRelaEN.con_UserId:
return (a: clsRTUserRelaEN, b: clsRTUserRelaEN) => {
return b.userId.localeCompare(a.userId);
}
case clsRTUserRelaEN.con_TopicUserRoleId:
return (a: clsRTUserRelaEN, b: clsRTUserRelaEN) => {
return b.topicUserRoleId.localeCompare(a.topicUserRoleId);
}
case clsRTUserRelaEN.con_ColorId:
return (a: clsRTUserRelaEN, b: clsRTUserRelaEN) => {
return b.colorId.localeCompare(a.colorId);
}
case clsRTUserRelaEN.con_OrderNum:
return (a: clsRTUserRelaEN, b: clsRTUserRelaEN) => {
return b.orderNum-a.orderNum;
}
case clsRTUserRelaEN.con_UserBgColor:
return (a: clsRTUserRelaEN, b: clsRTUserRelaEN) => {
return b.userBgColor.localeCompare(a.userBgColor);
}
case clsRTUserRelaEN.con_id_CurrEduCls:
return (a: clsRTUserRelaEN, b: clsRTUserRelaEN) => {
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
case clsRTUserRelaEN.con_UpdDate:
return (a: clsRTUserRelaEN, b: clsRTUserRelaEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsRTUserRelaEN.con_UpdUser:
return (a: clsRTUserRelaEN, b: clsRTUserRelaEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsRTUserRelaEN.con_Memo:
return (a: clsRTUserRelaEN, b: clsRTUserRelaEN) => {
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[RTUserRela]中不存在！(in ${ rTUserRela_ConstructorName}.${ strThisFuncName})`;
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
export async function RTUserRela_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsRTUserRelaEN.con_mId:
return (obj: clsRTUserRelaEN) => {
return obj.mId === value;
}
case clsRTUserRelaEN.con_TopicId:
return (obj: clsRTUserRelaEN) => {
return obj.topicId === value;
}
case clsRTUserRelaEN.con_UserId:
return (obj: clsRTUserRelaEN) => {
return obj.userId === value;
}
case clsRTUserRelaEN.con_TopicUserRoleId:
return (obj: clsRTUserRelaEN) => {
return obj.topicUserRoleId === value;
}
case clsRTUserRelaEN.con_ColorId:
return (obj: clsRTUserRelaEN) => {
return obj.colorId === value;
}
case clsRTUserRelaEN.con_OrderNum:
return (obj: clsRTUserRelaEN) => {
return obj.orderNum === value;
}
case clsRTUserRelaEN.con_UserBgColor:
return (obj: clsRTUserRelaEN) => {
return obj.userBgColor === value;
}
case clsRTUserRelaEN.con_id_CurrEduCls:
return (obj: clsRTUserRelaEN) => {
return obj.id_CurrEduCls === value;
}
case clsRTUserRelaEN.con_UpdDate:
return (obj: clsRTUserRelaEN) => {
return obj.updDate === value;
}
case clsRTUserRelaEN.con_UpdUser:
return (obj: clsRTUserRelaEN) => {
return obj.updUser === value;
}
case clsRTUserRelaEN.con_Memo:
return (obj: clsRTUserRelaEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[RTUserRela]中不存在！(in ${ rTUserRela_ConstructorName}.${ strThisFuncName})`;
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
export async function RTUserRela_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(rTUserRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTUserRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTUserRela_ConstructorName, strThisFuncName);
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
export async function RTUserRela_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(rTUserRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTUserRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTUserRela_ConstructorName, strThisFuncName);
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
export async function RTUserRela_GetFirstObjAsync(strWhereCond: string): Promise<clsRTUserRelaEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(rTUserRela_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", rTUserRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objRTUserRela = RTUserRela_GetObjFromJsonObj(returnObj);
return objRTUserRela;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTUserRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTUserRela_ConstructorName, strThisFuncName);
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
export async function RTUserRela_GetObjLst_ClientCache(strTopicId: string)
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("TopicId='{0}'", strTopicId);
const strKey = Format("{0}_{1}", clsRTUserRelaEN._CurrTabName, strTopicId);
clsRTUserRelaEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsRTUserRelaEN._CurrTabName);
if (IsNullOrEmpty(clsRTUserRelaEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsRTUserRelaEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrRTUserRelaExObjLst_Cache: Array<clsRTUserRelaEN> = CacheHelper.Get(strKey);
const arrRTUserRelaObjLst_T = RTUserRela_GetObjLstByJSONObjLst(arrRTUserRelaExObjLst_Cache);
return arrRTUserRelaObjLst_T;
}
try
{
const arrRTUserRelaExObjLst = await RTUserRela_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrRTUserRelaExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrRTUserRelaExObjLst.length);
console.log(strInfo);
return arrRTUserRelaExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, rTUserRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function RTUserRela_GetObjLst_localStorage(strTopicId: string)
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("TopicId='{0}'", strTopicId);
const strKey = Format("{0}_{1}", clsRTUserRelaEN._CurrTabName, strTopicId);
clsRTUserRelaEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsRTUserRelaEN._CurrTabName);
if (IsNullOrEmpty(clsRTUserRelaEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsRTUserRelaEN.CacheAddiCondition);
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
const arrRTUserRelaExObjLst_Cache: Array<clsRTUserRelaEN> = JSON.parse(strTempObjLst);
const arrRTUserRelaObjLst_T = RTUserRela_GetObjLstByJSONObjLst(arrRTUserRelaExObjLst_Cache);
return arrRTUserRelaObjLst_T;
}
try
{
const arrRTUserRelaExObjLst = await RTUserRela_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrRTUserRelaExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrRTUserRelaExObjLst.length);
console.log(strInfo);
return arrRTUserRelaExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, rTUserRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function RTUserRela_GetObjLst_localStorage_PureCache(strTopicId: string)
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("TopicId='{0}'", strTopicId);
const strKey = Format("{0}_{1}", clsRTUserRelaEN._CurrTabName, strTopicId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrRTUserRelaObjLst_Cache: Array<clsRTUserRelaEN> = JSON.parse(strTempObjLst);
return arrRTUserRelaObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function RTUserRela_GetObjLstAsync(strWhereCond: string): Promise<Array<clsRTUserRelaEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(rTUserRela_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", rTUserRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = RTUserRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTUserRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTUserRela_ConstructorName, strThisFuncName);
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
export async function RTUserRela_GetObjLst_sessionStorage(strTopicId: string)
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("TopicId='{0}'", strTopicId);
const strKey = Format("{0}_{1}", clsRTUserRelaEN._CurrTabName, strTopicId);
clsRTUserRelaEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsRTUserRelaEN._CurrTabName);
if (IsNullOrEmpty(clsRTUserRelaEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsRTUserRelaEN.CacheAddiCondition);
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
const arrRTUserRelaExObjLst_Cache: Array<clsRTUserRelaEN> = JSON.parse(strTempObjLst);
const arrRTUserRelaObjLst_T = RTUserRela_GetObjLstByJSONObjLst(arrRTUserRelaExObjLst_Cache);
return arrRTUserRelaObjLst_T;
}
try
{
const arrRTUserRelaExObjLst = await RTUserRela_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrRTUserRelaExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrRTUserRelaExObjLst.length);
console.log(strInfo);
return arrRTUserRelaExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, rTUserRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function RTUserRela_GetObjLst_sessionStorage_PureCache(strTopicId: string)
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("TopicId='{0}'", strTopicId);
const strKey = Format("{0}_{1}", clsRTUserRelaEN._CurrTabName, strTopicId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrRTUserRelaObjLst_Cache: Array<clsRTUserRelaEN> = JSON.parse(strTempObjLst);
return arrRTUserRelaObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function RTUserRela_GetObjLst_Cache(strTopicId: string): Promise<Array<clsRTUserRelaEN>>
{
//const strThisFuncName = "GetObjLst_Cache";

if (IsNullOrEmpty(strTopicId) == true)
{
const strMsg = Format("缓存分类变量:[TopicId]不能为空！");
console.error(strMsg);
throw (strMsg);
}
if (strTopicId.length != 8)
{
const strMsg = Format("缓存分类变量:[strTopicId]的长度:[{0}]不正确！", strTopicId.length);
console.error(strMsg);
throw (strMsg);
}
let arrRTUserRelaObjLst_Cache;
switch (clsRTUserRelaEN.CacheModeId)
{
case "04"://sessionStorage
arrRTUserRelaObjLst_Cache = await RTUserRela_GetObjLst_sessionStorage(strTopicId);
break;
case "03"://localStorage
arrRTUserRelaObjLst_Cache = await RTUserRela_GetObjLst_localStorage(strTopicId);
break;
case "02"://ClientCache
arrRTUserRelaObjLst_Cache = await RTUserRela_GetObjLst_ClientCache(strTopicId);
break;
default:
arrRTUserRelaObjLst_Cache = await RTUserRela_GetObjLst_ClientCache(strTopicId);
break;
}
const arrRTUserRelaObjLst = RTUserRela_GetObjLstByJSONObjLst(arrRTUserRelaObjLst_Cache);
return arrRTUserRelaObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function RTUserRela_GetObjLst_PureCache(strTopicId: string)
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrRTUserRelaObjLst_Cache;
switch (clsRTUserRelaEN.CacheModeId)
{
case "04"://sessionStorage
arrRTUserRelaObjLst_Cache = await RTUserRela_GetObjLst_sessionStorage_PureCache(strTopicId);
break;
case "03"://localStorage
arrRTUserRelaObjLst_Cache = await RTUserRela_GetObjLst_localStorage_PureCache(strTopicId);
break;
case "02"://ClientCache
arrRTUserRelaObjLst_Cache = null;
break;
default:
arrRTUserRelaObjLst_Cache = null;
break;
}
return arrRTUserRelaObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objlngmId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function RTUserRela_GetSubObjLst_Cache(objRTUserRela_Cond: clsRTUserRelaEN,strTopicId: string) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrRTUserRelaObjLst_Cache = await RTUserRela_GetObjLst_Cache(strTopicId);
let arrRTUserRela_Sel: Array < clsRTUserRelaEN > = arrRTUserRelaObjLst_Cache;
if (objRTUserRela_Cond.sf_FldComparisonOp == null || objRTUserRela_Cond.sf_FldComparisonOp == "") return arrRTUserRela_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objRTUserRela_Cond.sf_FldComparisonOp);
//console.log("clsRTUserRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objRTUserRela_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objRTUserRela_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrRTUserRela_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objRTUserRela_Cond), rTUserRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsRTUserRelaEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrmId:关键字列表
 * @returns 对象列表
 **/
export async function RTUserRela_GetObjLstBymIdLstAsync(arrmId: Array<string>): Promise<Array<clsRTUserRelaEN>>  
{
const strThisFuncName = "GetObjLstBymIdLstAsync";
const strAction = "GetObjLstBymIdLst";
const strUrl = GetWebApiUrl(rTUserRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrmId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", rTUserRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = RTUserRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTUserRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTUserRela_ConstructorName, strThisFuncName);
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
 * @param arrlngmIdLst:关键字列表
 * @returns 对象列表
*/
export async function RTUserRela_GetObjLstBymIdLst_Cache(arrmIdLst: Array<number>,strTopicId: string) {
const strThisFuncName = "GetObjLstBymIdLst_Cache";
try
{
const arrRTUserRelaObjLst_Cache = await RTUserRela_GetObjLst_Cache(strTopicId);
const arrRTUserRela_Sel: Array <clsRTUserRelaEN> = arrRTUserRelaObjLst_Cache.filter(x => arrmIdLst.indexOf(x.mId)>-1);
return arrRTUserRela_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrmIdLst.join(","), rTUserRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsRTUserRelaEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function RTUserRela_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsRTUserRelaEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(rTUserRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", rTUserRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = RTUserRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTUserRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTUserRela_ConstructorName, strThisFuncName);
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
export async function RTUserRela_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsRTUserRelaEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(rTUserRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", rTUserRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = RTUserRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTUserRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTUserRela_ConstructorName, strThisFuncName);
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
export async function RTUserRela_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(rTUserRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTUserRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTUserRela_ConstructorName, strThisFuncName);
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
export async function RTUserRela_GetObjLstByPager_Cache(objPagerPara: stuPagerPara,strTopicId: string) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrRTUserRelaObjLst_Cache = await RTUserRela_GetObjLst_Cache(strTopicId);
if (arrRTUserRelaObjLst_Cache.length == 0) return arrRTUserRelaObjLst_Cache;
let arrRTUserRela_Sel = arrRTUserRelaObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objRTUserRela_Cond = new clsRTUserRelaEN();
ObjectAssign(objRTUserRela_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsRTUserRelaWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objRTUserRela_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrRTUserRela_Sel.length == 0) return arrRTUserRela_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrRTUserRela_Sel = arrRTUserRela_Sel.sort(RTUserRela_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrRTUserRela_Sel = arrRTUserRela_Sel.sort(objPagerPara.sortFun);
}
arrRTUserRela_Sel = arrRTUserRela_Sel.slice(intStart, intEnd);     
return arrRTUserRela_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, rTUserRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsRTUserRelaEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function RTUserRela_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsRTUserRelaEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(rTUserRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", rTUserRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = RTUserRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTUserRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTUserRela_ConstructorName, strThisFuncName);
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
export async function RTUserRela_DelRecordAsync(lngmId: number): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(rTUserRela_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, lngmId);
try
{
const response = await axios.delete(strUrl,
{
params: { "Id": lngmId, }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTUserRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTUserRela_ConstructorName, strThisFuncName);
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
export async function RTUserRela_DelRTUserRelasAsync(arrmId: Array<string>): Promise<number> 
{
const strThisFuncName = "DelRTUserRelasAsync";
const strAction = "DelRTUserRelas";
const strUrl = GetWebApiUrl(rTUserRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTUserRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTUserRela_ConstructorName, strThisFuncName);
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
export async function RTUserRela_DelRTUserRelasByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "DelRTUserRelasByCondAsync";
const strAction = "DelRTUserRelasByCond";
const strUrl = GetWebApiUrl(rTUserRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTUserRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTUserRela_ConstructorName, strThisFuncName);
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
 * @param objRTUserRelaEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function RTUserRela_AddNewRecordAsync(objRTUserRelaEN: clsRTUserRelaEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objRTUserRelaEN);
const strUrl = GetWebApiUrl(rTUserRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRTUserRelaEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTUserRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTUserRela_ConstructorName, strThisFuncName);
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
 * 把所给的关键字列表相关的记录移顶
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GoTopAsync)
 * @param objRTUserRelaEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function RTUserRela_GoTopAsync(objOrderByData: clsOrderByData): Promise<boolean> 
{
const strThisFuncName = "GoTopAsync";
let strMsg = "";
const strAction = "GoTop";
if (objOrderByData.KeyIdLst.length == 0)
{
strMsg = "根据关键字列表置顶时，给定的关键字值列表不能为空!";
throw strMsg;
}
const strUrl = GetWebApiUrl(rTUserRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTUserRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTUserRela_ConstructorName, strThisFuncName);
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
 * @param objRTUserRelaEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function RTUserRela_UpMoveAsync(objOrderByData: clsOrderByData): Promise<boolean> 
{
const strThisFuncName = "UpMoveAsync";
let strMsg = "";
const strAction = "UpMove";
if (objOrderByData.KeyIdLst.length == 0)
{
strMsg = "根据关键字列表上移时，给定的关键字值列表不能为空!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objRTUserRelaEN);
const strUrl = GetWebApiUrl(rTUserRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTUserRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTUserRela_ConstructorName, strThisFuncName);
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
 * @param objRTUserRelaEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function RTUserRela_DownMoveAsync(objOrderByData: clsOrderByData): Promise<boolean> 
{
const strThisFuncName = "DownMoveAsync";
let strMsg = "";
const strAction = "DownMove";
if (objOrderByData.KeyIdLst.length == 0)
{
strMsg = "根据关键字列表下移时，给定的关键字值列表不能为空!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objRTUserRelaEN);
const strUrl = GetWebApiUrl(rTUserRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTUserRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTUserRela_ConstructorName, strThisFuncName);
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
 * @param objRTUserRelaEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function RTUserRela_GoBottomAsync(objOrderByData: clsOrderByData): Promise<boolean> 
{
const strThisFuncName = "GoBottomAsync";
let strMsg = "";
const strAction = "GoBottom";
if (objOrderByData.KeyIdLst.length == 0)
{
strMsg = "根据关键字列表置底时，给定的关键字值列表不能为空!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objRTUserRelaEN);
const strUrl = GetWebApiUrl(rTUserRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTUserRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTUserRela_ConstructorName, strThisFuncName);
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
 * @param objRTUserRelaEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function RTUserRela_ReOrderAsync(objOrderByData: clsOrderByData): Promise<boolean> 
{
const strThisFuncName = "ReOrderAsync";
const strAction = "ReOrder";
 //var strJSON = JSON.stringify(objRTUserRelaEN);
const strUrl = GetWebApiUrl(rTUserRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTUserRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTUserRela_ConstructorName, strThisFuncName);
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
 * @param objRTUserRelaEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function RTUserRela_AddNewRecordWithReturnKeyAsync(objRTUserRelaEN: clsRTUserRelaEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(rTUserRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRTUserRelaEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTUserRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTUserRela_ConstructorName, strThisFuncName);
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
 * @param objRTUserRelaEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function RTUserRela_AddNewRecordWithReturnKey(objRTUserRelaEN: clsRTUserRelaEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objRTUserRelaEN.mId === null || objRTUserRelaEN.mId === 0)
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(rTUserRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRTUserRelaEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTUserRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTUserRela_ConstructorName, strThisFuncName);
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
 * @param objRTUserRelaEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function RTUserRela_UpdateRecordAsync(objRTUserRelaEN: clsRTUserRelaEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objRTUserRelaEN.sf_UpdFldSetStr === undefined || objRTUserRelaEN.sf_UpdFldSetStr === null || objRTUserRelaEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objRTUserRelaEN.mId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(rTUserRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRTUserRelaEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTUserRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTUserRela_ConstructorName, strThisFuncName);
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
 * @param objRTUserRelaEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function RTUserRela_UpdateWithConditionAsync(objRTUserRelaEN: clsRTUserRelaEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objRTUserRelaEN.sf_UpdFldSetStr === undefined || objRTUserRelaEN.sf_UpdFldSetStr === null || objRTUserRelaEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objRTUserRelaEN.mId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(rTUserRela_Controller, strAction);
objRTUserRelaEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objRTUserRelaEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTUserRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTUserRela_ConstructorName, strThisFuncName);
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
 * @param objlngmId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function RTUserRela_IsExistRecord_Cache(objRTUserRela_Cond: clsRTUserRelaEN,strTopicId: string) {
const strThisFuncName = "IsExistRecord_Cache";
const arrRTUserRelaObjLst_Cache = await RTUserRela_GetObjLst_Cache(strTopicId);
if (arrRTUserRelaObjLst_Cache == null) return false;
let arrRTUserRela_Sel: Array < clsRTUserRelaEN > = arrRTUserRelaObjLst_Cache;
if (objRTUserRela_Cond.sf_FldComparisonOp == null || objRTUserRela_Cond.sf_FldComparisonOp == "") return arrRTUserRela_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objRTUserRela_Cond.sf_FldComparisonOp);
//console.log("clsRTUserRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objRTUserRela_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objRTUserRela_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrRTUserRela_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objRTUserRela_Cond), rTUserRela_ConstructorName, strThisFuncName);
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
export async function RTUserRela_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(rTUserRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTUserRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTUserRela_ConstructorName, strThisFuncName);
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
export async function RTUserRela_IsExist(lngmId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(rTUserRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTUserRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTUserRela_ConstructorName, strThisFuncName);
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
 * @param lngmId:所给的关键字
 * @returns 对象
*/
export async function RTUserRela_IsExist_Cache(lngmId:number,strTopicId:string) {
const strThisFuncName = "IsExist_Cache";
const arrRTUserRelaObjLst_Cache = await RTUserRela_GetObjLst_Cache(strTopicId);
if (arrRTUserRelaObjLst_Cache == null) return false;
try
{
const arrRTUserRela_Sel: Array <clsRTUserRelaEN> = arrRTUserRelaObjLst_Cache.filter(x => x.mId == lngmId);
if (arrRTUserRela_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngmId, rTUserRela_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param lngmId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function RTUserRela_IsExistAsync(lngmId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(rTUserRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTUserRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTUserRela_ConstructorName, strThisFuncName);
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
export async function RTUserRela_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(rTUserRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTUserRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTUserRela_ConstructorName, strThisFuncName);
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
 * @param objRTUserRela_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function RTUserRela_GetRecCountByCond_Cache(objRTUserRela_Cond: clsRTUserRelaEN,strTopicId: string) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrRTUserRelaObjLst_Cache = await RTUserRela_GetObjLst_Cache(strTopicId);
if (arrRTUserRelaObjLst_Cache == null) return 0;
let arrRTUserRela_Sel: Array < clsRTUserRelaEN > = arrRTUserRelaObjLst_Cache;
if (objRTUserRela_Cond.sf_FldComparisonOp == null || objRTUserRela_Cond.sf_FldComparisonOp == "") return arrRTUserRela_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objRTUserRela_Cond.sf_FldComparisonOp);
//console.log("clsRTUserRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objRTUserRela_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objRTUserRela_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrRTUserRela_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objRTUserRela_Cond), rTUserRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return 0;
}
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
export async function RTUserRela_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(rTUserRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rTUserRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rTUserRela_ConstructorName, strThisFuncName);
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
export function RTUserRela_GetWebApiUrl(strController: string, strAction: string): string {
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
export function RTUserRela_ReFreshCache(strTopicId: string):void
{
const strThisFuncName = "ReFreshCache";

if (IsNullOrEmpty(strTopicId) == true)
{
  const strMsg = Format("参数:[strTopicId]不能为空！(In clsRTUserRelaWApi.ReFreshCache)");
console.error(strMsg);
 throw (strMsg);
}
if (strTopicId.length != 8)
{
const strMsg = Format("缓存分类变量:[strTopicId]的长度:[{0}]不正确！", strTopicId.length);
console.error(strMsg);
throw (strMsg);
}

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = Format("{0}_{1}", clsRTUserRelaEN._CurrTabName, strTopicId);
switch (clsRTUserRelaEN.CacheModeId)
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
vRTUserRela_ReFreshThisCache(strTopicId);
}

 /**
 * 刷新本类中的缓存.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
 **/
export function RTUserRela_ReFreshThisCache(strTopicId: string):void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = Format("{0}_{1}", clsRTUserRelaEN._CurrTabName, strTopicId);
switch (clsRTUserRelaEN.CacheModeId)
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
export function RTUserRela_CheckPropertyNew(pobjRTUserRelaEN: clsRTUserRelaEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjRTUserRelaEN.topicUserRoleId) === true )
{
 throw new Error("(errid:Watl000058)字段[主键Id]不能为空(In 主题用户关系)!(clsRTUserRelaBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjRTUserRelaEN.topicId) == false && GetStrLen(pobjRTUserRelaEN.topicId) > 8)
{
 throw new Error("(errid:Watl000059)字段[主题Id(topicId)]的长度不能超过8(In 主题用户关系(RTUserRela))!值:$(pobjRTUserRelaEN.topicId)(clsRTUserRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRTUserRelaEN.userId) == false && GetStrLen(pobjRTUserRelaEN.userId) > 20)
{
 throw new Error("(errid:Watl000059)字段[用户ID(userId)]的长度不能超过20(In 主题用户关系(RTUserRela))!值:$(pobjRTUserRelaEN.userId)(clsRTUserRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRTUserRelaEN.topicUserRoleId) == false && GetStrLen(pobjRTUserRelaEN.topicUserRoleId) > 4)
{
 throw new Error("(errid:Watl000059)字段[主键Id(topicUserRoleId)]的长度不能超过4(In 主题用户关系(RTUserRela))!值:$(pobjRTUserRelaEN.topicUserRoleId)(clsRTUserRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRTUserRelaEN.colorId) == false && GetStrLen(pobjRTUserRelaEN.colorId) > 2)
{
 throw new Error("(errid:Watl000059)字段[颜色Id(colorId)]的长度不能超过2(In 主题用户关系(RTUserRela))!值:$(pobjRTUserRelaEN.colorId)(clsRTUserRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRTUserRelaEN.userBgColor) == false && GetStrLen(pobjRTUserRelaEN.userBgColor) > 200)
{
 throw new Error("(errid:Watl000059)字段[用户段落背景(userBgColor)]的长度不能超过200(In 主题用户关系(RTUserRela))!值:$(pobjRTUserRelaEN.userBgColor)(clsRTUserRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRTUserRelaEN.id_CurrEduCls) == false && GetStrLen(pobjRTUserRelaEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 主题用户关系(RTUserRela))!值:$(pobjRTUserRelaEN.id_CurrEduCls)(clsRTUserRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRTUserRelaEN.updDate) == false && GetStrLen(pobjRTUserRelaEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 主题用户关系(RTUserRela))!值:$(pobjRTUserRelaEN.updDate)(clsRTUserRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRTUserRelaEN.updUser) == false && GetStrLen(pobjRTUserRelaEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 主题用户关系(RTUserRela))!值:$(pobjRTUserRelaEN.updUser)(clsRTUserRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRTUserRelaEN.memo) == false && GetStrLen(pobjRTUserRelaEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 主题用户关系(RTUserRela))!值:$(pobjRTUserRelaEN.memo)(clsRTUserRelaBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null != pobjRTUserRelaEN.mId && undefined !== pobjRTUserRelaEN.mId && tzDataType.isNumber(pobjRTUserRelaEN.mId) === false)
{
 throw new Error("(errid:Watl000060)字段[mId(mId)]的值:[$(pobjRTUserRelaEN.mId)], 非法，应该为数值型(In 主题用户关系(RTUserRela))!(clsRTUserRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRTUserRelaEN.topicId) == false && undefined !== pobjRTUserRelaEN.topicId && tzDataType.isString(pobjRTUserRelaEN.topicId) === false)
{
 throw new Error("(errid:Watl000060)字段[主题Id(topicId)]的值:[$(pobjRTUserRelaEN.topicId)], 非法，应该为字符型(In 主题用户关系(RTUserRela))!(clsRTUserRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRTUserRelaEN.userId) == false && undefined !== pobjRTUserRelaEN.userId && tzDataType.isString(pobjRTUserRelaEN.userId) === false)
{
 throw new Error("(errid:Watl000060)字段[用户ID(userId)]的值:[$(pobjRTUserRelaEN.userId)], 非法，应该为字符型(In 主题用户关系(RTUserRela))!(clsRTUserRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRTUserRelaEN.topicUserRoleId) == false && undefined !== pobjRTUserRelaEN.topicUserRoleId && tzDataType.isString(pobjRTUserRelaEN.topicUserRoleId) === false)
{
 throw new Error("(errid:Watl000060)字段[主键Id(topicUserRoleId)]的值:[$(pobjRTUserRelaEN.topicUserRoleId)], 非法，应该为字符型(In 主题用户关系(RTUserRela))!(clsRTUserRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRTUserRelaEN.colorId) == false && undefined !== pobjRTUserRelaEN.colorId && tzDataType.isString(pobjRTUserRelaEN.colorId) === false)
{
 throw new Error("(errid:Watl000060)字段[颜色Id(colorId)]的值:[$(pobjRTUserRelaEN.colorId)], 非法，应该为字符型(In 主题用户关系(RTUserRela))!(clsRTUserRelaBL:CheckPropertyNew)");
}
if (null != pobjRTUserRelaEN.orderNum && undefined !== pobjRTUserRelaEN.orderNum && tzDataType.isNumber(pobjRTUserRelaEN.orderNum) === false)
{
 throw new Error("(errid:Watl000060)字段[序号(orderNum)]的值:[$(pobjRTUserRelaEN.orderNum)], 非法，应该为数值型(In 主题用户关系(RTUserRela))!(clsRTUserRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRTUserRelaEN.userBgColor) == false && undefined !== pobjRTUserRelaEN.userBgColor && tzDataType.isString(pobjRTUserRelaEN.userBgColor) === false)
{
 throw new Error("(errid:Watl000060)字段[用户段落背景(userBgColor)]的值:[$(pobjRTUserRelaEN.userBgColor)], 非法，应该为字符型(In 主题用户关系(RTUserRela))!(clsRTUserRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRTUserRelaEN.id_CurrEduCls) == false && undefined !== pobjRTUserRelaEN.id_CurrEduCls && tzDataType.isString(pobjRTUserRelaEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjRTUserRelaEN.id_CurrEduCls)], 非法，应该为字符型(In 主题用户关系(RTUserRela))!(clsRTUserRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRTUserRelaEN.updDate) == false && undefined !== pobjRTUserRelaEN.updDate && tzDataType.isString(pobjRTUserRelaEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjRTUserRelaEN.updDate)], 非法，应该为字符型(In 主题用户关系(RTUserRela))!(clsRTUserRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRTUserRelaEN.updUser) == false && undefined !== pobjRTUserRelaEN.updUser && tzDataType.isString(pobjRTUserRelaEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjRTUserRelaEN.updUser)], 非法，应该为字符型(In 主题用户关系(RTUserRela))!(clsRTUserRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRTUserRelaEN.memo) == false && undefined !== pobjRTUserRelaEN.memo && tzDataType.isString(pobjRTUserRelaEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjRTUserRelaEN.memo)], 非法，应该为字符型(In 主题用户关系(RTUserRela))!(clsRTUserRelaBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjRTUserRelaEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function RTUserRela_CheckProperty4Update (pobjRTUserRelaEN: clsRTUserRelaEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjRTUserRelaEN.topicId) == false && GetStrLen(pobjRTUserRelaEN.topicId) > 8)
{
 throw new Error("(errid:Watl000062)字段[主题Id(topicId)]的长度不能超过8(In 主题用户关系(RTUserRela))!值:$(pobjRTUserRelaEN.topicId)(clsRTUserRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRTUserRelaEN.userId) == false && GetStrLen(pobjRTUserRelaEN.userId) > 20)
{
 throw new Error("(errid:Watl000062)字段[用户ID(userId)]的长度不能超过20(In 主题用户关系(RTUserRela))!值:$(pobjRTUserRelaEN.userId)(clsRTUserRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRTUserRelaEN.topicUserRoleId) == false && GetStrLen(pobjRTUserRelaEN.topicUserRoleId) > 4)
{
 throw new Error("(errid:Watl000062)字段[主键Id(topicUserRoleId)]的长度不能超过4(In 主题用户关系(RTUserRela))!值:$(pobjRTUserRelaEN.topicUserRoleId)(clsRTUserRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRTUserRelaEN.colorId) == false && GetStrLen(pobjRTUserRelaEN.colorId) > 2)
{
 throw new Error("(errid:Watl000062)字段[颜色Id(colorId)]的长度不能超过2(In 主题用户关系(RTUserRela))!值:$(pobjRTUserRelaEN.colorId)(clsRTUserRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRTUserRelaEN.userBgColor) == false && GetStrLen(pobjRTUserRelaEN.userBgColor) > 200)
{
 throw new Error("(errid:Watl000062)字段[用户段落背景(userBgColor)]的长度不能超过200(In 主题用户关系(RTUserRela))!值:$(pobjRTUserRelaEN.userBgColor)(clsRTUserRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRTUserRelaEN.id_CurrEduCls) == false && GetStrLen(pobjRTUserRelaEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 主题用户关系(RTUserRela))!值:$(pobjRTUserRelaEN.id_CurrEduCls)(clsRTUserRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRTUserRelaEN.updDate) == false && GetStrLen(pobjRTUserRelaEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 主题用户关系(RTUserRela))!值:$(pobjRTUserRelaEN.updDate)(clsRTUserRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRTUserRelaEN.updUser) == false && GetStrLen(pobjRTUserRelaEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 主题用户关系(RTUserRela))!值:$(pobjRTUserRelaEN.updUser)(clsRTUserRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRTUserRelaEN.memo) == false && GetStrLen(pobjRTUserRelaEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 主题用户关系(RTUserRela))!值:$(pobjRTUserRelaEN.memo)(clsRTUserRelaBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null != pobjRTUserRelaEN.mId && undefined !== pobjRTUserRelaEN.mId && tzDataType.isNumber(pobjRTUserRelaEN.mId) === false)
{
 throw new Error("(errid:Watl000063)字段[mId(mId)]的值:[$(pobjRTUserRelaEN.mId)], 非法，应该为数值型(In 主题用户关系(RTUserRela))!(clsRTUserRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRTUserRelaEN.topicId) == false && undefined !== pobjRTUserRelaEN.topicId && tzDataType.isString(pobjRTUserRelaEN.topicId) === false)
{
 throw new Error("(errid:Watl000063)字段[主题Id(topicId)]的值:[$(pobjRTUserRelaEN.topicId)], 非法，应该为字符型(In 主题用户关系(RTUserRela))!(clsRTUserRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRTUserRelaEN.userId) == false && undefined !== pobjRTUserRelaEN.userId && tzDataType.isString(pobjRTUserRelaEN.userId) === false)
{
 throw new Error("(errid:Watl000063)字段[用户ID(userId)]的值:[$(pobjRTUserRelaEN.userId)], 非法，应该为字符型(In 主题用户关系(RTUserRela))!(clsRTUserRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRTUserRelaEN.topicUserRoleId) == false && undefined !== pobjRTUserRelaEN.topicUserRoleId && tzDataType.isString(pobjRTUserRelaEN.topicUserRoleId) === false)
{
 throw new Error("(errid:Watl000063)字段[主键Id(topicUserRoleId)]的值:[$(pobjRTUserRelaEN.topicUserRoleId)], 非法，应该为字符型(In 主题用户关系(RTUserRela))!(clsRTUserRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRTUserRelaEN.colorId) == false && undefined !== pobjRTUserRelaEN.colorId && tzDataType.isString(pobjRTUserRelaEN.colorId) === false)
{
 throw new Error("(errid:Watl000063)字段[颜色Id(colorId)]的值:[$(pobjRTUserRelaEN.colorId)], 非法，应该为字符型(In 主题用户关系(RTUserRela))!(clsRTUserRelaBL:CheckProperty4Update)");
}
if (null != pobjRTUserRelaEN.orderNum && undefined !== pobjRTUserRelaEN.orderNum && tzDataType.isNumber(pobjRTUserRelaEN.orderNum) === false)
{
 throw new Error("(errid:Watl000063)字段[序号(orderNum)]的值:[$(pobjRTUserRelaEN.orderNum)], 非法，应该为数值型(In 主题用户关系(RTUserRela))!(clsRTUserRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRTUserRelaEN.userBgColor) == false && undefined !== pobjRTUserRelaEN.userBgColor && tzDataType.isString(pobjRTUserRelaEN.userBgColor) === false)
{
 throw new Error("(errid:Watl000063)字段[用户段落背景(userBgColor)]的值:[$(pobjRTUserRelaEN.userBgColor)], 非法，应该为字符型(In 主题用户关系(RTUserRela))!(clsRTUserRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRTUserRelaEN.id_CurrEduCls) == false && undefined !== pobjRTUserRelaEN.id_CurrEduCls && tzDataType.isString(pobjRTUserRelaEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjRTUserRelaEN.id_CurrEduCls)], 非法，应该为字符型(In 主题用户关系(RTUserRela))!(clsRTUserRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRTUserRelaEN.updDate) == false && undefined !== pobjRTUserRelaEN.updDate && tzDataType.isString(pobjRTUserRelaEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjRTUserRelaEN.updDate)], 非法，应该为字符型(In 主题用户关系(RTUserRela))!(clsRTUserRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRTUserRelaEN.updUser) == false && undefined !== pobjRTUserRelaEN.updUser && tzDataType.isString(pobjRTUserRelaEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjRTUserRelaEN.updUser)], 非法，应该为字符型(In 主题用户关系(RTUserRela))!(clsRTUserRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRTUserRelaEN.memo) == false && undefined !== pobjRTUserRelaEN.memo && tzDataType.isString(pobjRTUserRelaEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjRTUserRelaEN.memo)], 非法，应该为字符型(In 主题用户关系(RTUserRela))!(clsRTUserRelaBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjRTUserRelaEN.mId 
 || pobjRTUserRelaEN.mId != null && pobjRTUserRelaEN.mId.toString()  ===  "")
{
 throw new Error("(errid:Watl000064)字段[mId]不能为空(In 主题用户关系)!(clsRTUserRelaBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjRTUserRelaEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function RTUserRela_GetJSONStrByObj (pobjRTUserRelaEN: clsRTUserRelaEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjRTUserRelaEN.sf_UpdFldSetStr = pobjRTUserRelaEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjRTUserRelaEN);
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
export function RTUserRela_GetObjLstByJSONStr (strJSON: string): Array<clsRTUserRelaEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrRTUserRelaObjLst = new Array<clsRTUserRelaEN>();
if (strJSON === "")
{
return arrRTUserRelaObjLst;
}
try
{
arrRTUserRelaObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrRTUserRelaObjLst;
}
return arrRTUserRelaObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrRTUserRelaObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function RTUserRela_GetObjLstByJSONObjLst (arrRTUserRelaObjLstS: Array<clsRTUserRelaEN>): Array<clsRTUserRelaEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrRTUserRelaObjLst = new Array<clsRTUserRelaEN>();
for (const objInFor of arrRTUserRelaObjLstS) {
const obj1 = RTUserRela_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrRTUserRelaObjLst.push(obj1);
}
return arrRTUserRelaObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function RTUserRela_GetObjByJSONStr (strJSON: string): clsRTUserRelaEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjRTUserRelaEN = new clsRTUserRelaEN();
if (strJSON === "")
{
return pobjRTUserRelaEN;
}
try
{
pobjRTUserRelaEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjRTUserRelaEN;
}
return pobjRTUserRelaEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function RTUserRela_GetCombineCondition(objRTUserRela_Cond: clsRTUserRelaEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objRTUserRela_Cond.dicFldComparisonOp, clsRTUserRelaEN.con_mId) == true)
{
const strComparisonOp_mId:string = objRTUserRela_Cond.dicFldComparisonOp[clsRTUserRelaEN.con_mId];
strWhereCond += Format(" And {0} {2} {1}", clsRTUserRelaEN.con_mId, objRTUserRela_Cond.mId, strComparisonOp_mId);
}
if (Object.prototype.hasOwnProperty.call(objRTUserRela_Cond.dicFldComparisonOp, clsRTUserRelaEN.con_TopicId) == true)
{
const strComparisonOp_TopicId:string = objRTUserRela_Cond.dicFldComparisonOp[clsRTUserRelaEN.con_TopicId];
strWhereCond += Format(" And {0} {2} '{1}'", clsRTUserRelaEN.con_TopicId, objRTUserRela_Cond.topicId, strComparisonOp_TopicId);
}
if (Object.prototype.hasOwnProperty.call(objRTUserRela_Cond.dicFldComparisonOp, clsRTUserRelaEN.con_UserId) == true)
{
const strComparisonOp_UserId:string = objRTUserRela_Cond.dicFldComparisonOp[clsRTUserRelaEN.con_UserId];
strWhereCond += Format(" And {0} {2} '{1}'", clsRTUserRelaEN.con_UserId, objRTUserRela_Cond.userId, strComparisonOp_UserId);
}
if (Object.prototype.hasOwnProperty.call(objRTUserRela_Cond.dicFldComparisonOp, clsRTUserRelaEN.con_TopicUserRoleId) == true)
{
const strComparisonOp_TopicUserRoleId:string = objRTUserRela_Cond.dicFldComparisonOp[clsRTUserRelaEN.con_TopicUserRoleId];
strWhereCond += Format(" And {0} {2} '{1}'", clsRTUserRelaEN.con_TopicUserRoleId, objRTUserRela_Cond.topicUserRoleId, strComparisonOp_TopicUserRoleId);
}
if (Object.prototype.hasOwnProperty.call(objRTUserRela_Cond.dicFldComparisonOp, clsRTUserRelaEN.con_ColorId) == true)
{
const strComparisonOp_ColorId:string = objRTUserRela_Cond.dicFldComparisonOp[clsRTUserRelaEN.con_ColorId];
strWhereCond += Format(" And {0} {2} '{1}'", clsRTUserRelaEN.con_ColorId, objRTUserRela_Cond.colorId, strComparisonOp_ColorId);
}
if (Object.prototype.hasOwnProperty.call(objRTUserRela_Cond.dicFldComparisonOp, clsRTUserRelaEN.con_OrderNum) == true)
{
const strComparisonOp_OrderNum:string = objRTUserRela_Cond.dicFldComparisonOp[clsRTUserRelaEN.con_OrderNum];
strWhereCond += Format(" And {0} {2} {1}", clsRTUserRelaEN.con_OrderNum, objRTUserRela_Cond.orderNum, strComparisonOp_OrderNum);
}
if (Object.prototype.hasOwnProperty.call(objRTUserRela_Cond.dicFldComparisonOp, clsRTUserRelaEN.con_UserBgColor) == true)
{
const strComparisonOp_UserBgColor:string = objRTUserRela_Cond.dicFldComparisonOp[clsRTUserRelaEN.con_UserBgColor];
strWhereCond += Format(" And {0} {2} '{1}'", clsRTUserRelaEN.con_UserBgColor, objRTUserRela_Cond.userBgColor, strComparisonOp_UserBgColor);
}
if (Object.prototype.hasOwnProperty.call(objRTUserRela_Cond.dicFldComparisonOp, clsRTUserRelaEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objRTUserRela_Cond.dicFldComparisonOp[clsRTUserRelaEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsRTUserRelaEN.con_id_CurrEduCls, objRTUserRela_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (Object.prototype.hasOwnProperty.call(objRTUserRela_Cond.dicFldComparisonOp, clsRTUserRelaEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objRTUserRela_Cond.dicFldComparisonOp[clsRTUserRelaEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsRTUserRelaEN.con_UpdDate, objRTUserRela_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objRTUserRela_Cond.dicFldComparisonOp, clsRTUserRelaEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objRTUserRela_Cond.dicFldComparisonOp[clsRTUserRelaEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsRTUserRelaEN.con_UpdUser, objRTUserRela_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objRTUserRela_Cond.dicFldComparisonOp, clsRTUserRelaEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objRTUserRela_Cond.dicFldComparisonOp[clsRTUserRelaEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsRTUserRelaEN.con_Memo, objRTUserRela_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--RTUserRela(主题用户关系),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param strTopicId: 主题Id(要求唯一的字段)
 * @param strUserId: 用户ID(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function RTUserRela_GetUniCondStr_TopicId_UserId(objRTUserRelaEN: clsRTUserRelaEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and TopicId = '{0}'", objRTUserRelaEN.topicId);
 strWhereCond +=  Format(" and UserId = '{0}'", objRTUserRelaEN.userId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--RTUserRela(主题用户关系),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param strTopicId: 主题Id(要求唯一的字段)
 * @param strUserId: 用户ID(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function RTUserRela_GetUniCondStr4Update_TopicId_UserId(objRTUserRelaEN: clsRTUserRelaEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and mId <> '{0}'", objRTUserRelaEN.mId);
 strWhereCond +=  Format(" and TopicId = '{0}'", objRTUserRelaEN.topicId);
 strWhereCond +=  Format(" and UserId = '{0}'", objRTUserRelaEN.userId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objRTUserRelaENS:源对象
 * @param objRTUserRelaENT:目标对象
*/
export function RTUserRela_CopyObjTo(objRTUserRelaENS: clsRTUserRelaEN , objRTUserRelaENT: clsRTUserRelaEN ): void 
{
objRTUserRelaENT.mId = objRTUserRelaENS.mId; //mId
objRTUserRelaENT.topicId = objRTUserRelaENS.topicId; //主题Id
objRTUserRelaENT.userId = objRTUserRelaENS.userId; //用户ID
objRTUserRelaENT.topicUserRoleId = objRTUserRelaENS.topicUserRoleId; //主键Id
objRTUserRelaENT.colorId = objRTUserRelaENS.colorId; //颜色Id
objRTUserRelaENT.orderNum = objRTUserRelaENS.orderNum; //序号
objRTUserRelaENT.userBgColor = objRTUserRelaENS.userBgColor; //用户段落背景
objRTUserRelaENT.id_CurrEduCls = objRTUserRelaENS.id_CurrEduCls; //教学班流水号
objRTUserRelaENT.updDate = objRTUserRelaENS.updDate; //修改日期
objRTUserRelaENT.updUser = objRTUserRelaENS.updUser; //修改人
objRTUserRelaENT.memo = objRTUserRelaENS.memo; //备注
objRTUserRelaENT.sf_UpdFldSetStr = objRTUserRelaENS.updFldString; //sf_UpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objRTUserRelaENS:源对象
 * @param objRTUserRelaENT:目标对象
*/
export function RTUserRela_GetObjFromJsonObj(objRTUserRelaENS: clsRTUserRelaEN): clsRTUserRelaEN 
{
 const objRTUserRelaENT: clsRTUserRelaEN = new clsRTUserRelaEN();
ObjectAssign(objRTUserRelaENT, objRTUserRelaENS);
 return objRTUserRelaENT;
}