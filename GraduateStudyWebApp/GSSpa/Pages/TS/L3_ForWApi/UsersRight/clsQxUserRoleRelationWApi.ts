﻿
 /**
 * 类名:clsQxUserRoleRelationWApi
 * 表名:QxUserRoleRelation(01120481)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:46:16
 * 生成者:pyf
 * 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:权限管理(UsersRight)
 * 框架-层名:WA_访问层(TS)(WA_Access)
 * 编程语言:TypeScript
 * 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
   *      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 **/

/**
 * Qx用户角色关系(QxUserRoleRelation)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clsQxUserRoleRelationEN } from "../../L0_Entity/UsersRight/clsQxUserRoleRelationEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { tzDataType } from "../../PubFun/jsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const qxUserRoleRelation_Controller = "QxUserRoleRelationApi";
 export const qxUserRoleRelation_ConstructorName = "qxUserRoleRelation";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngmId:关键字
 * @returns 对象
 **/
export async function QxUserRoleRelation_GetObjBymIdAsync(lngmId: number): Promise<clsQxUserRoleRelationEN>  
{
const strThisFuncName = "GetObjBymIdAsync";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In GetObjBymIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjBymId";
const strUrl = GetWebApiUrl(qxUserRoleRelation_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", qxUserRoleRelation_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objQxUserRoleRelation = QxUserRoleRelation_GetObjFromJsonObj(returnObj);
return objQxUserRoleRelation;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qxUserRoleRelation_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qxUserRoleRelation_ConstructorName, strThisFuncName);
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
export async function QxUserRoleRelation_GetObjBymId_Cache(lngmId: number, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjBymId_Cache";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In GetObjBymId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
const arrQxUserRoleRelationObjLst_Cache = await QxUserRoleRelation_GetObjLst_Cache();
try
{
const arrQxUserRoleRelation_Sel: Array <clsQxUserRoleRelationEN> = arrQxUserRoleRelationObjLst_Cache.filter(x => x.mId == lngmId);
let objQxUserRoleRelation: clsQxUserRoleRelationEN;
if (arrQxUserRoleRelation_Sel.length > 0)
{
objQxUserRoleRelation = arrQxUserRoleRelation_Sel[0];
return objQxUserRoleRelation;
}
else
{
if (bolTryAsyncOnce == true)
{
objQxUserRoleRelation = await QxUserRoleRelation_GetObjBymIdAsync(lngmId);
if (objQxUserRoleRelation != null)
{
QxUserRoleRelation_ReFreshThisCache();
return objQxUserRoleRelation;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, qxUserRoleRelation_ConstructorName, strThisFuncName);
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
export async function QxUserRoleRelation_GetObjBymId_localStorage(lngmId: number) {
const strThisFuncName = "GetObjBymId_localStorage";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In GetObjBymId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
const strKey = Format("{0}_{1}", clsQxUserRoleRelationEN._CurrTabName, lngmId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objQxUserRoleRelation_Cache: clsQxUserRoleRelationEN = JSON.parse(strTempObj);
return objQxUserRoleRelation_Cache;
}
try
{
const objQxUserRoleRelation = await QxUserRoleRelation_GetObjBymIdAsync(lngmId);
if (objQxUserRoleRelation != null)
{
localStorage.setItem(strKey, JSON.stringify(objQxUserRoleRelation));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objQxUserRoleRelation;
}
return objQxUserRoleRelation;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, qxUserRoleRelation_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objQxUserRoleRelation:所给的对象
 * @returns 对象
*/
export async function QxUserRoleRelation_UpdateObjInLst_Cache(objQxUserRoleRelation: clsQxUserRoleRelationEN) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrQxUserRoleRelationObjLst_Cache = await QxUserRoleRelation_GetObjLst_Cache();
const obj = arrQxUserRoleRelationObjLst_Cache.find(x => x.roleId == objQxUserRoleRelation.roleId && x.userId == objQxUserRoleRelation.userId);
if (obj != null)
{
objQxUserRoleRelation.mId = obj.mId;
ObjectAssign( obj, objQxUserRoleRelation);
}
else
{
arrQxUserRoleRelationObjLst_Cache.push(objQxUserRoleRelation);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, qxUserRoleRelation_ConstructorName, strThisFuncName);
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
 * @returns 返回一个输出字段值
*/
export async function QxUserRoleRelation_func(strInFldName:string , strOutFldName:string ,  strInValue: string) 
{
//const strThisFuncName = "func";

if (strInFldName != clsQxUserRoleRelationEN.con_mId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsQxUserRoleRelationEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clsQxUserRoleRelationEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const lngmId = Number(strInValue);
if (lngmId == 0)
{
return "";
}
const objQxUserRoleRelation = await QxUserRoleRelation_GetObjBymId_Cache(lngmId );
if (objQxUserRoleRelation == null) return "";
return objQxUserRoleRelation.GetFldValue(strOutFldName).toString();
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
export function QxUserRoleRelation_SortFun_Defa(a:clsQxUserRoleRelationEN , b:clsQxUserRoleRelationEN): number 
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
export function QxUserRoleRelation_SortFun_Defa_2Fld(a:clsQxUserRoleRelationEN , b:clsQxUserRoleRelationEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.userId == b.userId) return a.roleId.localeCompare(b.roleId);
else return a.userId.localeCompare(b.userId);
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
export function QxUserRoleRelation_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsQxUserRoleRelationEN.con_mId:
return (a: clsQxUserRoleRelationEN, b: clsQxUserRoleRelationEN) => {
return a.mId-b.mId;
}
case clsQxUserRoleRelationEN.con_UserId:
return (a: clsQxUserRoleRelationEN, b: clsQxUserRoleRelationEN) => {
return a.userId.localeCompare(b.userId);
}
case clsQxUserRoleRelationEN.con_RoleId:
return (a: clsQxUserRoleRelationEN, b: clsQxUserRoleRelationEN) => {
return a.roleId.localeCompare(b.roleId);
}
case clsQxUserRoleRelationEN.con_QxPrjId:
return (a: clsQxUserRoleRelationEN, b: clsQxUserRoleRelationEN) => {
return a.qxPrjId.localeCompare(b.qxPrjId);
}
case clsQxUserRoleRelationEN.con_Memo:
return (a: clsQxUserRoleRelationEN, b: clsQxUserRoleRelationEN) => {
return a.memo.localeCompare(b.memo);
}
case clsQxUserRoleRelationEN.con_QuestionnaireSetId:
return (a: clsQxUserRoleRelationEN, b: clsQxUserRoleRelationEN) => {
return a.questionnaireSetId.localeCompare(b.questionnaireSetId);
}
case clsQxUserRoleRelationEN.con_UpdDate:
return (a: clsQxUserRoleRelationEN, b: clsQxUserRoleRelationEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsQxUserRoleRelationEN.con_UpdUser:
return (a: clsQxUserRoleRelationEN, b: clsQxUserRoleRelationEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsQxUserRoleRelationEN.con_UpdUserId:
return (a: clsQxUserRoleRelationEN, b: clsQxUserRoleRelationEN) => {
return a.updUserId.localeCompare(b.updUserId);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[QxUserRoleRelation]中不存在！(in ${ qxUserRoleRelation_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsQxUserRoleRelationEN.con_mId:
return (a: clsQxUserRoleRelationEN, b: clsQxUserRoleRelationEN) => {
return b.mId-a.mId;
}
case clsQxUserRoleRelationEN.con_UserId:
return (a: clsQxUserRoleRelationEN, b: clsQxUserRoleRelationEN) => {
return b.userId.localeCompare(a.userId);
}
case clsQxUserRoleRelationEN.con_RoleId:
return (a: clsQxUserRoleRelationEN, b: clsQxUserRoleRelationEN) => {
return b.roleId.localeCompare(a.roleId);
}
case clsQxUserRoleRelationEN.con_QxPrjId:
return (a: clsQxUserRoleRelationEN, b: clsQxUserRoleRelationEN) => {
return b.qxPrjId.localeCompare(a.qxPrjId);
}
case clsQxUserRoleRelationEN.con_Memo:
return (a: clsQxUserRoleRelationEN, b: clsQxUserRoleRelationEN) => {
return b.memo.localeCompare(a.memo);
}
case clsQxUserRoleRelationEN.con_QuestionnaireSetId:
return (a: clsQxUserRoleRelationEN, b: clsQxUserRoleRelationEN) => {
return b.questionnaireSetId.localeCompare(a.questionnaireSetId);
}
case clsQxUserRoleRelationEN.con_UpdDate:
return (a: clsQxUserRoleRelationEN, b: clsQxUserRoleRelationEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsQxUserRoleRelationEN.con_UpdUser:
return (a: clsQxUserRoleRelationEN, b: clsQxUserRoleRelationEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsQxUserRoleRelationEN.con_UpdUserId:
return (a: clsQxUserRoleRelationEN, b: clsQxUserRoleRelationEN) => {
return b.updUserId.localeCompare(a.updUserId);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[QxUserRoleRelation]中不存在！(in ${ qxUserRoleRelation_ConstructorName}.${ strThisFuncName})`;
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
export async function QxUserRoleRelation_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsQxUserRoleRelationEN.con_mId:
return (obj: clsQxUserRoleRelationEN) => {
return obj.mId === value;
}
case clsQxUserRoleRelationEN.con_UserId:
return (obj: clsQxUserRoleRelationEN) => {
return obj.userId === value;
}
case clsQxUserRoleRelationEN.con_RoleId:
return (obj: clsQxUserRoleRelationEN) => {
return obj.roleId === value;
}
case clsQxUserRoleRelationEN.con_QxPrjId:
return (obj: clsQxUserRoleRelationEN) => {
return obj.qxPrjId === value;
}
case clsQxUserRoleRelationEN.con_Memo:
return (obj: clsQxUserRoleRelationEN) => {
return obj.memo === value;
}
case clsQxUserRoleRelationEN.con_QuestionnaireSetId:
return (obj: clsQxUserRoleRelationEN) => {
return obj.questionnaireSetId === value;
}
case clsQxUserRoleRelationEN.con_UpdDate:
return (obj: clsQxUserRoleRelationEN) => {
return obj.updDate === value;
}
case clsQxUserRoleRelationEN.con_UpdUser:
return (obj: clsQxUserRoleRelationEN) => {
return obj.updUser === value;
}
case clsQxUserRoleRelationEN.con_UpdUserId:
return (obj: clsQxUserRoleRelationEN) => {
return obj.updUserId === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[QxUserRoleRelation]中不存在！(in ${ qxUserRoleRelation_ConstructorName}.${ strThisFuncName})`;
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
export async function QxUserRoleRelation_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(qxUserRoleRelation_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qxUserRoleRelation_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qxUserRoleRelation_ConstructorName, strThisFuncName);
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
export async function QxUserRoleRelation_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(qxUserRoleRelation_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qxUserRoleRelation_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qxUserRoleRelation_ConstructorName, strThisFuncName);
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
export async function QxUserRoleRelation_GetFirstObjAsync(strWhereCond: string): Promise<clsQxUserRoleRelationEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(qxUserRoleRelation_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", qxUserRoleRelation_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objQxUserRoleRelation = QxUserRoleRelation_GetObjFromJsonObj(returnObj);
return objQxUserRoleRelation;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qxUserRoleRelation_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qxUserRoleRelation_ConstructorName, strThisFuncName);
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
export async function QxUserRoleRelation_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsQxUserRoleRelationEN._CurrTabName;
clsQxUserRoleRelationEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsQxUserRoleRelationEN._CurrTabName);
if (IsNullOrEmpty(clsQxUserRoleRelationEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsQxUserRoleRelationEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrQxUserRoleRelationExObjLst_Cache: Array<clsQxUserRoleRelationEN> = CacheHelper.Get(strKey);
const arrQxUserRoleRelationObjLst_T = QxUserRoleRelation_GetObjLstByJSONObjLst(arrQxUserRoleRelationExObjLst_Cache);
return arrQxUserRoleRelationObjLst_T;
}
try
{
const arrQxUserRoleRelationExObjLst = await QxUserRoleRelation_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrQxUserRoleRelationExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrQxUserRoleRelationExObjLst.length);
console.log(strInfo);
return arrQxUserRoleRelationExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, qxUserRoleRelation_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function QxUserRoleRelation_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsQxUserRoleRelationEN._CurrTabName;
clsQxUserRoleRelationEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsQxUserRoleRelationEN._CurrTabName);
if (IsNullOrEmpty(clsQxUserRoleRelationEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsQxUserRoleRelationEN.CacheAddiCondition);
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
const arrQxUserRoleRelationExObjLst_Cache: Array<clsQxUserRoleRelationEN> = JSON.parse(strTempObjLst);
const arrQxUserRoleRelationObjLst_T = QxUserRoleRelation_GetObjLstByJSONObjLst(arrQxUserRoleRelationExObjLst_Cache);
return arrQxUserRoleRelationObjLst_T;
}
try
{
const arrQxUserRoleRelationExObjLst = await QxUserRoleRelation_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrQxUserRoleRelationExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrQxUserRoleRelationExObjLst.length);
console.log(strInfo);
return arrQxUserRoleRelationExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, qxUserRoleRelation_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function QxUserRoleRelation_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsQxUserRoleRelationEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrQxUserRoleRelationObjLst_Cache: Array<clsQxUserRoleRelationEN> = JSON.parse(strTempObjLst);
return arrQxUserRoleRelationObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function QxUserRoleRelation_GetObjLstAsync(strWhereCond: string): Promise<Array<clsQxUserRoleRelationEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(qxUserRoleRelation_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", qxUserRoleRelation_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = QxUserRoleRelation_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qxUserRoleRelation_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qxUserRoleRelation_ConstructorName, strThisFuncName);
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
export async function QxUserRoleRelation_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsQxUserRoleRelationEN._CurrTabName;
clsQxUserRoleRelationEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsQxUserRoleRelationEN._CurrTabName);
if (IsNullOrEmpty(clsQxUserRoleRelationEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsQxUserRoleRelationEN.CacheAddiCondition);
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
const arrQxUserRoleRelationExObjLst_Cache: Array<clsQxUserRoleRelationEN> = JSON.parse(strTempObjLst);
const arrQxUserRoleRelationObjLst_T = QxUserRoleRelation_GetObjLstByJSONObjLst(arrQxUserRoleRelationExObjLst_Cache);
return arrQxUserRoleRelationObjLst_T;
}
try
{
const arrQxUserRoleRelationExObjLst = await QxUserRoleRelation_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrQxUserRoleRelationExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrQxUserRoleRelationExObjLst.length);
console.log(strInfo);
return arrQxUserRoleRelationExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, qxUserRoleRelation_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function QxUserRoleRelation_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsQxUserRoleRelationEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrQxUserRoleRelationObjLst_Cache: Array<clsQxUserRoleRelationEN> = JSON.parse(strTempObjLst);
return arrQxUserRoleRelationObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function QxUserRoleRelation_GetObjLst_Cache(): Promise<Array<clsQxUserRoleRelationEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrQxUserRoleRelationObjLst_Cache;
switch (clsQxUserRoleRelationEN.CacheModeId)
{
case "04"://sessionStorage
arrQxUserRoleRelationObjLst_Cache = await QxUserRoleRelation_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrQxUserRoleRelationObjLst_Cache = await QxUserRoleRelation_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrQxUserRoleRelationObjLst_Cache = await QxUserRoleRelation_GetObjLst_ClientCache();
break;
default:
arrQxUserRoleRelationObjLst_Cache = await QxUserRoleRelation_GetObjLst_ClientCache();
break;
}
const arrQxUserRoleRelationObjLst = QxUserRoleRelation_GetObjLstByJSONObjLst(arrQxUserRoleRelationObjLst_Cache);
return arrQxUserRoleRelationObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function QxUserRoleRelation_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrQxUserRoleRelationObjLst_Cache;
switch (clsQxUserRoleRelationEN.CacheModeId)
{
case "04"://sessionStorage
arrQxUserRoleRelationObjLst_Cache = await QxUserRoleRelation_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrQxUserRoleRelationObjLst_Cache = await QxUserRoleRelation_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrQxUserRoleRelationObjLst_Cache = null;
break;
default:
arrQxUserRoleRelationObjLst_Cache = null;
break;
}
return arrQxUserRoleRelationObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objlngmId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function QxUserRoleRelation_GetSubObjLst_Cache(objQxUserRoleRelation_Cond: clsQxUserRoleRelationEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrQxUserRoleRelationObjLst_Cache = await QxUserRoleRelation_GetObjLst_Cache();
let arrQxUserRoleRelation_Sel: Array < clsQxUserRoleRelationEN > = arrQxUserRoleRelationObjLst_Cache;
if (objQxUserRoleRelation_Cond.sf_FldComparisonOp == null || objQxUserRoleRelation_Cond.sf_FldComparisonOp == "") return arrQxUserRoleRelation_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objQxUserRoleRelation_Cond.sf_FldComparisonOp);
//console.log("clsQxUserRoleRelationWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objQxUserRoleRelation_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrQxUserRoleRelation_Sel = arrQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objQxUserRoleRelation_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrQxUserRoleRelation_Sel = arrQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrQxUserRoleRelation_Sel = arrQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrQxUserRoleRelation_Sel = arrQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrQxUserRoleRelation_Sel = arrQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrQxUserRoleRelation_Sel = arrQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrQxUserRoleRelation_Sel = arrQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrQxUserRoleRelation_Sel = arrQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrQxUserRoleRelation_Sel = arrQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrQxUserRoleRelation_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objQxUserRoleRelation_Cond), qxUserRoleRelation_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsQxUserRoleRelationEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrmId:关键字列表
 * @returns 对象列表
 **/
export async function QxUserRoleRelation_GetObjLstBymIdLstAsync(arrmId: Array<string>): Promise<Array<clsQxUserRoleRelationEN>>  
{
const strThisFuncName = "GetObjLstBymIdLstAsync";
const strAction = "GetObjLstBymIdLst";
const strUrl = GetWebApiUrl(qxUserRoleRelation_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrmId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", qxUserRoleRelation_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = QxUserRoleRelation_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qxUserRoleRelation_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qxUserRoleRelation_ConstructorName, strThisFuncName);
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
export async function QxUserRoleRelation_GetObjLstBymIdLst_Cache(arrmIdLst: Array<number>) {
const strThisFuncName = "GetObjLstBymIdLst_Cache";
try
{
const arrQxUserRoleRelationObjLst_Cache = await QxUserRoleRelation_GetObjLst_Cache();
const arrQxUserRoleRelation_Sel: Array <clsQxUserRoleRelationEN> = arrQxUserRoleRelationObjLst_Cache.filter(x => arrmIdLst.indexOf(x.mId)>-1);
return arrQxUserRoleRelation_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrmIdLst.join(","), qxUserRoleRelation_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsQxUserRoleRelationEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function QxUserRoleRelation_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsQxUserRoleRelationEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(qxUserRoleRelation_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", qxUserRoleRelation_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = QxUserRoleRelation_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qxUserRoleRelation_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qxUserRoleRelation_ConstructorName, strThisFuncName);
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
export async function QxUserRoleRelation_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsQxUserRoleRelationEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(qxUserRoleRelation_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", qxUserRoleRelation_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = QxUserRoleRelation_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qxUserRoleRelation_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qxUserRoleRelation_ConstructorName, strThisFuncName);
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
export async function QxUserRoleRelation_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(qxUserRoleRelation_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qxUserRoleRelation_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qxUserRoleRelation_ConstructorName, strThisFuncName);
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
export async function QxUserRoleRelation_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrQxUserRoleRelationObjLst_Cache = await QxUserRoleRelation_GetObjLst_Cache();
if (arrQxUserRoleRelationObjLst_Cache.length == 0) return arrQxUserRoleRelationObjLst_Cache;
let arrQxUserRoleRelation_Sel = arrQxUserRoleRelationObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objQxUserRoleRelation_Cond = new clsQxUserRoleRelationEN();
ObjectAssign(objQxUserRoleRelation_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsQxUserRoleRelationWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrQxUserRoleRelation_Sel = arrQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objQxUserRoleRelation_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrQxUserRoleRelation_Sel = arrQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrQxUserRoleRelation_Sel = arrQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrQxUserRoleRelation_Sel = arrQxUserRoleRelation_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrQxUserRoleRelation_Sel = arrQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrQxUserRoleRelation_Sel = arrQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrQxUserRoleRelation_Sel = arrQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrQxUserRoleRelation_Sel = arrQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrQxUserRoleRelation_Sel = arrQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrQxUserRoleRelation_Sel = arrQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrQxUserRoleRelation_Sel.length == 0) return arrQxUserRoleRelation_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrQxUserRoleRelation_Sel = arrQxUserRoleRelation_Sel.sort(QxUserRoleRelation_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrQxUserRoleRelation_Sel = arrQxUserRoleRelation_Sel.sort(objPagerPara.sortFun);
}
arrQxUserRoleRelation_Sel = arrQxUserRoleRelation_Sel.slice(intStart, intEnd);     
return arrQxUserRoleRelation_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, qxUserRoleRelation_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsQxUserRoleRelationEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function QxUserRoleRelation_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsQxUserRoleRelationEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(qxUserRoleRelation_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", qxUserRoleRelation_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = QxUserRoleRelation_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qxUserRoleRelation_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qxUserRoleRelation_ConstructorName, strThisFuncName);
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
export async function QxUserRoleRelation_DelRecordAsync(lngmId: number): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(qxUserRoleRelation_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qxUserRoleRelation_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qxUserRoleRelation_ConstructorName, strThisFuncName);
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
export async function QxUserRoleRelation_DelQxUserRoleRelationsAsync(arrmId: Array<string>): Promise<number> 
{
const strThisFuncName = "DelQxUserRoleRelationsAsync";
const strAction = "DelQxUserRoleRelations";
const strUrl = GetWebApiUrl(qxUserRoleRelation_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qxUserRoleRelation_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qxUserRoleRelation_ConstructorName, strThisFuncName);
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
export async function QxUserRoleRelation_DelQxUserRoleRelationsByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "DelQxUserRoleRelationsByCondAsync";
const strAction = "DelQxUserRoleRelationsByCond";
const strUrl = GetWebApiUrl(qxUserRoleRelation_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qxUserRoleRelation_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qxUserRoleRelation_ConstructorName, strThisFuncName);
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
 * @param objQxUserRoleRelationEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function QxUserRoleRelation_AddNewRecordAsync(objQxUserRoleRelationEN: clsQxUserRoleRelationEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objQxUserRoleRelationEN);
const strUrl = GetWebApiUrl(qxUserRoleRelation_Controller, strAction);
try
{
const response = await axios.post(strUrl, objQxUserRoleRelationEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qxUserRoleRelation_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qxUserRoleRelation_ConstructorName, strThisFuncName);
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
 * @param objQxUserRoleRelationEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function QxUserRoleRelation_AddNewRecordWithReturnKeyAsync(objQxUserRoleRelationEN: clsQxUserRoleRelationEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(qxUserRoleRelation_Controller, strAction);
try
{
const response = await axios.post(strUrl, objQxUserRoleRelationEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qxUserRoleRelation_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qxUserRoleRelation_ConstructorName, strThisFuncName);
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
 * @param objQxUserRoleRelationEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function QxUserRoleRelation_AddNewRecordWithReturnKey(objQxUserRoleRelationEN: clsQxUserRoleRelationEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objQxUserRoleRelationEN.mId === null || objQxUserRoleRelationEN.mId === 0)
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(qxUserRoleRelation_Controller, strAction);
try
{
const response = await axios.post(strUrl, objQxUserRoleRelationEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qxUserRoleRelation_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qxUserRoleRelation_ConstructorName, strThisFuncName);
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
 * @param objQxUserRoleRelationEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function QxUserRoleRelation_UpdateRecordAsync(objQxUserRoleRelationEN: clsQxUserRoleRelationEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objQxUserRoleRelationEN.sf_UpdFldSetStr === undefined || objQxUserRoleRelationEN.sf_UpdFldSetStr === null || objQxUserRoleRelationEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objQxUserRoleRelationEN.mId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(qxUserRoleRelation_Controller, strAction);
try
{
const response = await axios.post(strUrl, objQxUserRoleRelationEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qxUserRoleRelation_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qxUserRoleRelation_ConstructorName, strThisFuncName);
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
 * @param objQxUserRoleRelationEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function QxUserRoleRelation_UpdateWithConditionAsync(objQxUserRoleRelationEN: clsQxUserRoleRelationEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objQxUserRoleRelationEN.sf_UpdFldSetStr === undefined || objQxUserRoleRelationEN.sf_UpdFldSetStr === null || objQxUserRoleRelationEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objQxUserRoleRelationEN.mId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(qxUserRoleRelation_Controller, strAction);
objQxUserRoleRelationEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objQxUserRoleRelationEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qxUserRoleRelation_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qxUserRoleRelation_ConstructorName, strThisFuncName);
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
export async function QxUserRoleRelation_IsExistRecord_Cache(objQxUserRoleRelation_Cond: clsQxUserRoleRelationEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrQxUserRoleRelationObjLst_Cache = await QxUserRoleRelation_GetObjLst_Cache();
if (arrQxUserRoleRelationObjLst_Cache == null) return false;
let arrQxUserRoleRelation_Sel: Array < clsQxUserRoleRelationEN > = arrQxUserRoleRelationObjLst_Cache;
if (objQxUserRoleRelation_Cond.sf_FldComparisonOp == null || objQxUserRoleRelation_Cond.sf_FldComparisonOp == "") return arrQxUserRoleRelation_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objQxUserRoleRelation_Cond.sf_FldComparisonOp);
//console.log("clsQxUserRoleRelationWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objQxUserRoleRelation_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objQxUserRoleRelation_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrQxUserRoleRelation_Sel = arrQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrQxUserRoleRelation_Sel = arrQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrQxUserRoleRelation_Sel = arrQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrQxUserRoleRelation_Sel = arrQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrQxUserRoleRelation_Sel = arrQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrQxUserRoleRelation_Sel = arrQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrQxUserRoleRelation_Sel = arrQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrQxUserRoleRelation_Sel = arrQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrQxUserRoleRelation_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objQxUserRoleRelation_Cond), qxUserRoleRelation_ConstructorName, strThisFuncName);
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
export async function QxUserRoleRelation_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(qxUserRoleRelation_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qxUserRoleRelation_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qxUserRoleRelation_ConstructorName, strThisFuncName);
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
export async function QxUserRoleRelation_IsExist(lngmId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(qxUserRoleRelation_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qxUserRoleRelation_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qxUserRoleRelation_ConstructorName, strThisFuncName);
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
export async function QxUserRoleRelation_IsExist_Cache(lngmId:number) {
const strThisFuncName = "IsExist_Cache";
const arrQxUserRoleRelationObjLst_Cache = await QxUserRoleRelation_GetObjLst_Cache();
if (arrQxUserRoleRelationObjLst_Cache == null) return false;
try
{
const arrQxUserRoleRelation_Sel: Array <clsQxUserRoleRelationEN> = arrQxUserRoleRelationObjLst_Cache.filter(x => x.mId == lngmId);
if (arrQxUserRoleRelation_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngmId, qxUserRoleRelation_ConstructorName, strThisFuncName);
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
export async function QxUserRoleRelation_IsExistAsync(lngmId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(qxUserRoleRelation_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qxUserRoleRelation_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qxUserRoleRelation_ConstructorName, strThisFuncName);
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
export async function QxUserRoleRelation_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(qxUserRoleRelation_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qxUserRoleRelation_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qxUserRoleRelation_ConstructorName, strThisFuncName);
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
 * @param objQxUserRoleRelation_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function QxUserRoleRelation_GetRecCountByCond_Cache(objQxUserRoleRelation_Cond: clsQxUserRoleRelationEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrQxUserRoleRelationObjLst_Cache = await QxUserRoleRelation_GetObjLst_Cache();
if (arrQxUserRoleRelationObjLst_Cache == null) return 0;
let arrQxUserRoleRelation_Sel: Array < clsQxUserRoleRelationEN > = arrQxUserRoleRelationObjLst_Cache;
if (objQxUserRoleRelation_Cond.sf_FldComparisonOp == null || objQxUserRoleRelation_Cond.sf_FldComparisonOp == "") return arrQxUserRoleRelation_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objQxUserRoleRelation_Cond.sf_FldComparisonOp);
//console.log("clsQxUserRoleRelationWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objQxUserRoleRelation_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrQxUserRoleRelation_Sel = arrQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objQxUserRoleRelation_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrQxUserRoleRelation_Sel = arrQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrQxUserRoleRelation_Sel = arrQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrQxUserRoleRelation_Sel = arrQxUserRoleRelation_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrQxUserRoleRelation_Sel = arrQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrQxUserRoleRelation_Sel = arrQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrQxUserRoleRelation_Sel = arrQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrQxUserRoleRelation_Sel = arrQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrQxUserRoleRelation_Sel = arrQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrQxUserRoleRelation_Sel = arrQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrQxUserRoleRelation_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objQxUserRoleRelation_Cond), qxUserRoleRelation_ConstructorName, strThisFuncName);
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
export async function QxUserRoleRelation_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(qxUserRoleRelation_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qxUserRoleRelation_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qxUserRoleRelation_ConstructorName, strThisFuncName);
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
export function QxUserRoleRelation_GetWebApiUrl(strController: string, strAction: string): string {
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
export function QxUserRoleRelation_ReFreshCache():void
{
const strThisFuncName = "ReFreshCache";

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = clsQxUserRoleRelationEN._CurrTabName;
switch (clsQxUserRoleRelationEN.CacheModeId)
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
}

 /**
 * 刷新本类中的缓存.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
 **/
export function QxUserRoleRelation_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clsQxUserRoleRelationEN._CurrTabName;
switch (clsQxUserRoleRelationEN.CacheModeId)
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
export function QxUserRoleRelation_CheckPropertyNew(pobjQxUserRoleRelationEN: clsQxUserRoleRelationEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjQxUserRoleRelationEN.roleId) === true 
 || pobjQxUserRoleRelationEN.roleId.toString()  ===  "0" )
{
 throw new Error("(errid:Watl000058)字段[角色Id]不能为空(In Qx用户角色关系)!(clsQxUserRoleRelationBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUserRoleRelationEN.qxPrjId) === true )
{
 throw new Error("(errid:Watl000058)字段[QxPrjId]不能为空(In Qx用户角色关系)!(clsQxUserRoleRelationBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUserRoleRelationEN.updUser) === true )
{
 throw new Error("(errid:Watl000058)字段[修改人]不能为空(In Qx用户角色关系)!(clsQxUserRoleRelationBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjQxUserRoleRelationEN.userId) == false && GetStrLen(pobjQxUserRoleRelationEN.userId) > 20)
{
 throw new Error("(errid:Watl000059)字段[用户ID(userId)]的长度不能超过20(In Qx用户角色关系(QxUserRoleRelation))!值:$(pobjQxUserRoleRelationEN.userId)(clsQxUserRoleRelationBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUserRoleRelationEN.roleId) == false && GetStrLen(pobjQxUserRoleRelationEN.roleId) > 8)
{
 throw new Error("(errid:Watl000059)字段[角色Id(roleId)]的长度不能超过8(In Qx用户角色关系(QxUserRoleRelation))!值:$(pobjQxUserRoleRelationEN.roleId)(clsQxUserRoleRelationBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUserRoleRelationEN.qxPrjId) == false && GetStrLen(pobjQxUserRoleRelationEN.qxPrjId) > 4)
{
 throw new Error("(errid:Watl000059)字段[QxPrjId(qxPrjId)]的长度不能超过4(In Qx用户角色关系(QxUserRoleRelation))!值:$(pobjQxUserRoleRelationEN.qxPrjId)(clsQxUserRoleRelationBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUserRoleRelationEN.memo) == false && GetStrLen(pobjQxUserRoleRelationEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In Qx用户角色关系(QxUserRoleRelation))!值:$(pobjQxUserRoleRelationEN.memo)(clsQxUserRoleRelationBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUserRoleRelationEN.questionnaireSetId) == false && GetStrLen(pobjQxUserRoleRelationEN.questionnaireSetId) > 4)
{
 throw new Error("(errid:Watl000059)字段[问卷集ID(questionnaireSetId)]的长度不能超过4(In Qx用户角色关系(QxUserRoleRelation))!值:$(pobjQxUserRoleRelationEN.questionnaireSetId)(clsQxUserRoleRelationBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUserRoleRelationEN.updDate) == false && GetStrLen(pobjQxUserRoleRelationEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In Qx用户角色关系(QxUserRoleRelation))!值:$(pobjQxUserRoleRelationEN.updDate)(clsQxUserRoleRelationBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUserRoleRelationEN.updUser) == false && GetStrLen(pobjQxUserRoleRelationEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In Qx用户角色关系(QxUserRoleRelation))!值:$(pobjQxUserRoleRelationEN.updUser)(clsQxUserRoleRelationBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUserRoleRelationEN.updUserId) == false && GetStrLen(pobjQxUserRoleRelationEN.updUserId) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改用户Id(updUserId)]的长度不能超过20(In Qx用户角色关系(QxUserRoleRelation))!值:$(pobjQxUserRoleRelationEN.updUserId)(clsQxUserRoleRelationBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null != pobjQxUserRoleRelationEN.mId && undefined !== pobjQxUserRoleRelationEN.mId && tzDataType.isNumber(pobjQxUserRoleRelationEN.mId) === false)
{
 throw new Error("(errid:Watl000060)字段[mId(mId)]的值:[$(pobjQxUserRoleRelationEN.mId)], 非法，应该为数值型(In Qx用户角色关系(QxUserRoleRelation))!(clsQxUserRoleRelationBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUserRoleRelationEN.userId) == false && undefined !== pobjQxUserRoleRelationEN.userId && tzDataType.isString(pobjQxUserRoleRelationEN.userId) === false)
{
 throw new Error("(errid:Watl000060)字段[用户ID(userId)]的值:[$(pobjQxUserRoleRelationEN.userId)], 非法，应该为字符型(In Qx用户角色关系(QxUserRoleRelation))!(clsQxUserRoleRelationBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUserRoleRelationEN.roleId) == false && undefined !== pobjQxUserRoleRelationEN.roleId && tzDataType.isString(pobjQxUserRoleRelationEN.roleId) === false)
{
 throw new Error("(errid:Watl000060)字段[角色Id(roleId)]的值:[$(pobjQxUserRoleRelationEN.roleId)], 非法，应该为字符型(In Qx用户角色关系(QxUserRoleRelation))!(clsQxUserRoleRelationBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUserRoleRelationEN.qxPrjId) == false && undefined !== pobjQxUserRoleRelationEN.qxPrjId && tzDataType.isString(pobjQxUserRoleRelationEN.qxPrjId) === false)
{
 throw new Error("(errid:Watl000060)字段[QxPrjId(qxPrjId)]的值:[$(pobjQxUserRoleRelationEN.qxPrjId)], 非法，应该为字符型(In Qx用户角色关系(QxUserRoleRelation))!(clsQxUserRoleRelationBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUserRoleRelationEN.memo) == false && undefined !== pobjQxUserRoleRelationEN.memo && tzDataType.isString(pobjQxUserRoleRelationEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjQxUserRoleRelationEN.memo)], 非法，应该为字符型(In Qx用户角色关系(QxUserRoleRelation))!(clsQxUserRoleRelationBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUserRoleRelationEN.questionnaireSetId) == false && undefined !== pobjQxUserRoleRelationEN.questionnaireSetId && tzDataType.isString(pobjQxUserRoleRelationEN.questionnaireSetId) === false)
{
 throw new Error("(errid:Watl000060)字段[问卷集ID(questionnaireSetId)]的值:[$(pobjQxUserRoleRelationEN.questionnaireSetId)], 非法，应该为字符型(In Qx用户角色关系(QxUserRoleRelation))!(clsQxUserRoleRelationBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUserRoleRelationEN.updDate) == false && undefined !== pobjQxUserRoleRelationEN.updDate && tzDataType.isString(pobjQxUserRoleRelationEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjQxUserRoleRelationEN.updDate)], 非法，应该为字符型(In Qx用户角色关系(QxUserRoleRelation))!(clsQxUserRoleRelationBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUserRoleRelationEN.updUser) == false && undefined !== pobjQxUserRoleRelationEN.updUser && tzDataType.isString(pobjQxUserRoleRelationEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjQxUserRoleRelationEN.updUser)], 非法，应该为字符型(In Qx用户角色关系(QxUserRoleRelation))!(clsQxUserRoleRelationBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUserRoleRelationEN.updUserId) == false && undefined !== pobjQxUserRoleRelationEN.updUserId && tzDataType.isString(pobjQxUserRoleRelationEN.updUserId) === false)
{
 throw new Error("(errid:Watl000060)字段[修改用户Id(updUserId)]的值:[$(pobjQxUserRoleRelationEN.updUserId)], 非法，应该为字符型(In Qx用户角色关系(QxUserRoleRelation))!(clsQxUserRoleRelationBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjQxUserRoleRelationEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function QxUserRoleRelation_CheckProperty4Update (pobjQxUserRoleRelationEN: clsQxUserRoleRelationEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjQxUserRoleRelationEN.userId) == false && GetStrLen(pobjQxUserRoleRelationEN.userId) > 20)
{
 throw new Error("(errid:Watl000062)字段[用户ID(userId)]的长度不能超过20(In Qx用户角色关系(QxUserRoleRelation))!值:$(pobjQxUserRoleRelationEN.userId)(clsQxUserRoleRelationBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUserRoleRelationEN.roleId) == false && GetStrLen(pobjQxUserRoleRelationEN.roleId) > 8)
{
 throw new Error("(errid:Watl000062)字段[角色Id(roleId)]的长度不能超过8(In Qx用户角色关系(QxUserRoleRelation))!值:$(pobjQxUserRoleRelationEN.roleId)(clsQxUserRoleRelationBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUserRoleRelationEN.qxPrjId) == false && GetStrLen(pobjQxUserRoleRelationEN.qxPrjId) > 4)
{
 throw new Error("(errid:Watl000062)字段[QxPrjId(qxPrjId)]的长度不能超过4(In Qx用户角色关系(QxUserRoleRelation))!值:$(pobjQxUserRoleRelationEN.qxPrjId)(clsQxUserRoleRelationBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUserRoleRelationEN.memo) == false && GetStrLen(pobjQxUserRoleRelationEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In Qx用户角色关系(QxUserRoleRelation))!值:$(pobjQxUserRoleRelationEN.memo)(clsQxUserRoleRelationBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUserRoleRelationEN.questionnaireSetId) == false && GetStrLen(pobjQxUserRoleRelationEN.questionnaireSetId) > 4)
{
 throw new Error("(errid:Watl000062)字段[问卷集ID(questionnaireSetId)]的长度不能超过4(In Qx用户角色关系(QxUserRoleRelation))!值:$(pobjQxUserRoleRelationEN.questionnaireSetId)(clsQxUserRoleRelationBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUserRoleRelationEN.updDate) == false && GetStrLen(pobjQxUserRoleRelationEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In Qx用户角色关系(QxUserRoleRelation))!值:$(pobjQxUserRoleRelationEN.updDate)(clsQxUserRoleRelationBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUserRoleRelationEN.updUser) == false && GetStrLen(pobjQxUserRoleRelationEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In Qx用户角色关系(QxUserRoleRelation))!值:$(pobjQxUserRoleRelationEN.updUser)(clsQxUserRoleRelationBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUserRoleRelationEN.updUserId) == false && GetStrLen(pobjQxUserRoleRelationEN.updUserId) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改用户Id(updUserId)]的长度不能超过20(In Qx用户角色关系(QxUserRoleRelation))!值:$(pobjQxUserRoleRelationEN.updUserId)(clsQxUserRoleRelationBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null != pobjQxUserRoleRelationEN.mId && undefined !== pobjQxUserRoleRelationEN.mId && tzDataType.isNumber(pobjQxUserRoleRelationEN.mId) === false)
{
 throw new Error("(errid:Watl000063)字段[mId(mId)]的值:[$(pobjQxUserRoleRelationEN.mId)], 非法，应该为数值型(In Qx用户角色关系(QxUserRoleRelation))!(clsQxUserRoleRelationBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUserRoleRelationEN.userId) == false && undefined !== pobjQxUserRoleRelationEN.userId && tzDataType.isString(pobjQxUserRoleRelationEN.userId) === false)
{
 throw new Error("(errid:Watl000063)字段[用户ID(userId)]的值:[$(pobjQxUserRoleRelationEN.userId)], 非法，应该为字符型(In Qx用户角色关系(QxUserRoleRelation))!(clsQxUserRoleRelationBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUserRoleRelationEN.roleId) == false && undefined !== pobjQxUserRoleRelationEN.roleId && tzDataType.isString(pobjQxUserRoleRelationEN.roleId) === false)
{
 throw new Error("(errid:Watl000063)字段[角色Id(roleId)]的值:[$(pobjQxUserRoleRelationEN.roleId)], 非法，应该为字符型(In Qx用户角色关系(QxUserRoleRelation))!(clsQxUserRoleRelationBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUserRoleRelationEN.qxPrjId) == false && undefined !== pobjQxUserRoleRelationEN.qxPrjId && tzDataType.isString(pobjQxUserRoleRelationEN.qxPrjId) === false)
{
 throw new Error("(errid:Watl000063)字段[QxPrjId(qxPrjId)]的值:[$(pobjQxUserRoleRelationEN.qxPrjId)], 非法，应该为字符型(In Qx用户角色关系(QxUserRoleRelation))!(clsQxUserRoleRelationBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUserRoleRelationEN.memo) == false && undefined !== pobjQxUserRoleRelationEN.memo && tzDataType.isString(pobjQxUserRoleRelationEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjQxUserRoleRelationEN.memo)], 非法，应该为字符型(In Qx用户角色关系(QxUserRoleRelation))!(clsQxUserRoleRelationBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUserRoleRelationEN.questionnaireSetId) == false && undefined !== pobjQxUserRoleRelationEN.questionnaireSetId && tzDataType.isString(pobjQxUserRoleRelationEN.questionnaireSetId) === false)
{
 throw new Error("(errid:Watl000063)字段[问卷集ID(questionnaireSetId)]的值:[$(pobjQxUserRoleRelationEN.questionnaireSetId)], 非法，应该为字符型(In Qx用户角色关系(QxUserRoleRelation))!(clsQxUserRoleRelationBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUserRoleRelationEN.updDate) == false && undefined !== pobjQxUserRoleRelationEN.updDate && tzDataType.isString(pobjQxUserRoleRelationEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjQxUserRoleRelationEN.updDate)], 非法，应该为字符型(In Qx用户角色关系(QxUserRoleRelation))!(clsQxUserRoleRelationBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUserRoleRelationEN.updUser) == false && undefined !== pobjQxUserRoleRelationEN.updUser && tzDataType.isString(pobjQxUserRoleRelationEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjQxUserRoleRelationEN.updUser)], 非法，应该为字符型(In Qx用户角色关系(QxUserRoleRelation))!(clsQxUserRoleRelationBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUserRoleRelationEN.updUserId) == false && undefined !== pobjQxUserRoleRelationEN.updUserId && tzDataType.isString(pobjQxUserRoleRelationEN.updUserId) === false)
{
 throw new Error("(errid:Watl000063)字段[修改用户Id(updUserId)]的值:[$(pobjQxUserRoleRelationEN.updUserId)], 非法，应该为字符型(In Qx用户角色关系(QxUserRoleRelation))!(clsQxUserRoleRelationBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjQxUserRoleRelationEN.mId 
 || pobjQxUserRoleRelationEN.mId != null && pobjQxUserRoleRelationEN.mId.toString()  ===  "")
{
 throw new Error("(errid:Watl000064)字段[mId]不能为空(In Qx用户角色关系)!(clsQxUserRoleRelationBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjQxUserRoleRelationEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function QxUserRoleRelation_GetJSONStrByObj (pobjQxUserRoleRelationEN: clsQxUserRoleRelationEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjQxUserRoleRelationEN.sf_UpdFldSetStr = pobjQxUserRoleRelationEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjQxUserRoleRelationEN);
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
export function QxUserRoleRelation_GetObjLstByJSONStr (strJSON: string): Array<clsQxUserRoleRelationEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrQxUserRoleRelationObjLst = new Array<clsQxUserRoleRelationEN>();
if (strJSON === "")
{
return arrQxUserRoleRelationObjLst;
}
try
{
arrQxUserRoleRelationObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrQxUserRoleRelationObjLst;
}
return arrQxUserRoleRelationObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrQxUserRoleRelationObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function QxUserRoleRelation_GetObjLstByJSONObjLst (arrQxUserRoleRelationObjLstS: Array<clsQxUserRoleRelationEN>): Array<clsQxUserRoleRelationEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrQxUserRoleRelationObjLst = new Array<clsQxUserRoleRelationEN>();
for (const objInFor of arrQxUserRoleRelationObjLstS) {
const obj1 = QxUserRoleRelation_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrQxUserRoleRelationObjLst.push(obj1);
}
return arrQxUserRoleRelationObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function QxUserRoleRelation_GetObjByJSONStr (strJSON: string): clsQxUserRoleRelationEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjQxUserRoleRelationEN = new clsQxUserRoleRelationEN();
if (strJSON === "")
{
return pobjQxUserRoleRelationEN;
}
try
{
pobjQxUserRoleRelationEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjQxUserRoleRelationEN;
}
return pobjQxUserRoleRelationEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function QxUserRoleRelation_GetCombineCondition(objQxUserRoleRelation_Cond: clsQxUserRoleRelationEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objQxUserRoleRelation_Cond.dicFldComparisonOp, clsQxUserRoleRelationEN.con_mId) == true)
{
const strComparisonOp_mId:string = objQxUserRoleRelation_Cond.dicFldComparisonOp[clsQxUserRoleRelationEN.con_mId];
strWhereCond += Format(" And {0} {2} {1}", clsQxUserRoleRelationEN.con_mId, objQxUserRoleRelation_Cond.mId, strComparisonOp_mId);
}
if (Object.prototype.hasOwnProperty.call(objQxUserRoleRelation_Cond.dicFldComparisonOp, clsQxUserRoleRelationEN.con_UserId) == true)
{
const strComparisonOp_UserId:string = objQxUserRoleRelation_Cond.dicFldComparisonOp[clsQxUserRoleRelationEN.con_UserId];
strWhereCond += Format(" And {0} {2} '{1}'", clsQxUserRoleRelationEN.con_UserId, objQxUserRoleRelation_Cond.userId, strComparisonOp_UserId);
}
if (Object.prototype.hasOwnProperty.call(objQxUserRoleRelation_Cond.dicFldComparisonOp, clsQxUserRoleRelationEN.con_RoleId) == true)
{
const strComparisonOp_RoleId:string = objQxUserRoleRelation_Cond.dicFldComparisonOp[clsQxUserRoleRelationEN.con_RoleId];
strWhereCond += Format(" And {0} {2} '{1}'", clsQxUserRoleRelationEN.con_RoleId, objQxUserRoleRelation_Cond.roleId, strComparisonOp_RoleId);
}
if (Object.prototype.hasOwnProperty.call(objQxUserRoleRelation_Cond.dicFldComparisonOp, clsQxUserRoleRelationEN.con_QxPrjId) == true)
{
const strComparisonOp_QxPrjId:string = objQxUserRoleRelation_Cond.dicFldComparisonOp[clsQxUserRoleRelationEN.con_QxPrjId];
strWhereCond += Format(" And {0} {2} '{1}'", clsQxUserRoleRelationEN.con_QxPrjId, objQxUserRoleRelation_Cond.qxPrjId, strComparisonOp_QxPrjId);
}
if (Object.prototype.hasOwnProperty.call(objQxUserRoleRelation_Cond.dicFldComparisonOp, clsQxUserRoleRelationEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objQxUserRoleRelation_Cond.dicFldComparisonOp[clsQxUserRoleRelationEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsQxUserRoleRelationEN.con_Memo, objQxUserRoleRelation_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objQxUserRoleRelation_Cond.dicFldComparisonOp, clsQxUserRoleRelationEN.con_QuestionnaireSetId) == true)
{
const strComparisonOp_QuestionnaireSetId:string = objQxUserRoleRelation_Cond.dicFldComparisonOp[clsQxUserRoleRelationEN.con_QuestionnaireSetId];
strWhereCond += Format(" And {0} {2} '{1}'", clsQxUserRoleRelationEN.con_QuestionnaireSetId, objQxUserRoleRelation_Cond.questionnaireSetId, strComparisonOp_QuestionnaireSetId);
}
if (Object.prototype.hasOwnProperty.call(objQxUserRoleRelation_Cond.dicFldComparisonOp, clsQxUserRoleRelationEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objQxUserRoleRelation_Cond.dicFldComparisonOp[clsQxUserRoleRelationEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsQxUserRoleRelationEN.con_UpdDate, objQxUserRoleRelation_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objQxUserRoleRelation_Cond.dicFldComparisonOp, clsQxUserRoleRelationEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objQxUserRoleRelation_Cond.dicFldComparisonOp[clsQxUserRoleRelationEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsQxUserRoleRelationEN.con_UpdUser, objQxUserRoleRelation_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objQxUserRoleRelation_Cond.dicFldComparisonOp, clsQxUserRoleRelationEN.con_UpdUserId) == true)
{
const strComparisonOp_UpdUserId:string = objQxUserRoleRelation_Cond.dicFldComparisonOp[clsQxUserRoleRelationEN.con_UpdUserId];
strWhereCond += Format(" And {0} {2} '{1}'", clsQxUserRoleRelationEN.con_UpdUserId, objQxUserRoleRelation_Cond.updUserId, strComparisonOp_UpdUserId);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--QxUserRoleRelation(Qx用户角色关系),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param strRoleId: 角色Id(要求唯一的字段)
 * @param strUserId: 用户ID(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function QxUserRoleRelation_GetUniCondStr_RoleId_UserId(objQxUserRoleRelationEN: clsQxUserRoleRelationEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and RoleId = '{0}'", objQxUserRoleRelationEN.roleId);
 strWhereCond +=  Format(" and UserId = '{0}'", objQxUserRoleRelationEN.userId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--QxUserRoleRelation(Qx用户角色关系),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param strRoleId: 角色Id(要求唯一的字段)
 * @param strUserId: 用户ID(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function QxUserRoleRelation_GetUniCondStr4Update_RoleId_UserId(objQxUserRoleRelationEN: clsQxUserRoleRelationEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and mId <> '{0}'", objQxUserRoleRelationEN.mId);
 strWhereCond +=  Format(" and RoleId = '{0}'", objQxUserRoleRelationEN.roleId);
 strWhereCond +=  Format(" and UserId = '{0}'", objQxUserRoleRelationEN.userId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objQxUserRoleRelationENS:源对象
 * @param objQxUserRoleRelationENT:目标对象
*/
export function QxUserRoleRelation_CopyObjTo(objQxUserRoleRelationENS: clsQxUserRoleRelationEN , objQxUserRoleRelationENT: clsQxUserRoleRelationEN ): void 
{
objQxUserRoleRelationENT.mId = objQxUserRoleRelationENS.mId; //mId
objQxUserRoleRelationENT.userId = objQxUserRoleRelationENS.userId; //用户ID
objQxUserRoleRelationENT.roleId = objQxUserRoleRelationENS.roleId; //角色Id
objQxUserRoleRelationENT.qxPrjId = objQxUserRoleRelationENS.qxPrjId; //QxPrjId
objQxUserRoleRelationENT.memo = objQxUserRoleRelationENS.memo; //备注
objQxUserRoleRelationENT.questionnaireSetId = objQxUserRoleRelationENS.questionnaireSetId; //问卷集ID
objQxUserRoleRelationENT.updDate = objQxUserRoleRelationENS.updDate; //修改日期
objQxUserRoleRelationENT.updUser = objQxUserRoleRelationENS.updUser; //修改人
objQxUserRoleRelationENT.updUserId = objQxUserRoleRelationENS.updUserId; //修改用户Id
objQxUserRoleRelationENT.sf_UpdFldSetStr = objQxUserRoleRelationENS.updFldString; //sf_UpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objQxUserRoleRelationENS:源对象
 * @param objQxUserRoleRelationENT:目标对象
*/
export function QxUserRoleRelation_GetObjFromJsonObj(objQxUserRoleRelationENS: clsQxUserRoleRelationEN): clsQxUserRoleRelationEN 
{
 const objQxUserRoleRelationENT: clsQxUserRoleRelationEN = new clsQxUserRoleRelationEN();
ObjectAssign(objQxUserRoleRelationENT, objQxUserRoleRelationENS);
 return objQxUserRoleRelationENT;
}