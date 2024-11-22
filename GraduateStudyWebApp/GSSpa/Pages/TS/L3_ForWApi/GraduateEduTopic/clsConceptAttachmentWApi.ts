﻿
 /**
 * 类名:clsConceptAttachmentWApi
 * 表名:ConceptAttachment(01120603)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:46:49
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
 * 概念附件(ConceptAttachment)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clsConceptAttachmentEN } from "../../L0_Entity/GraduateEduTopic/clsConceptAttachmentEN.js";
import { vConceptAttachment_ReFreshThisCache } from "../../L3_ForWApi/GraduateEduTopic/clsvConceptAttachmentWApi.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { tzDataType } from "../../PubFun/jsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const conceptAttachment_Controller = "ConceptAttachmentApi";
 export const conceptAttachment_ConstructorName = "conceptAttachment";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngConceptAttachmentId:关键字
 * @returns 对象
 **/
export async function ConceptAttachment_GetObjByConceptAttachmentIdAsync(lngConceptAttachmentId: number): Promise<clsConceptAttachmentEN>  
{
const strThisFuncName = "GetObjByConceptAttachmentIdAsync";

if (lngConceptAttachmentId == 0)
{
  const strMsg = Format("参数:[lngConceptAttachmentId]不能为空！(In GetObjByConceptAttachmentIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjByConceptAttachmentId";
const strUrl = GetWebApiUrl(conceptAttachment_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"lngConceptAttachmentId": lngConceptAttachmentId,
}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObj = data.returnObj;
if (returnObj == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", conceptAttachment_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objConceptAttachment = ConceptAttachment_GetObjFromJsonObj(returnObj);
return objConceptAttachment;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptAttachment_ConstructorName, strThisFuncName);
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
 * @param lngConceptAttachmentId:所给的关键字
 * @returns 对象
*/
export async function ConceptAttachment_GetObjByConceptAttachmentId_Cache(lngConceptAttachmentId:number,strid_CurrEduCls:string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByConceptAttachmentId_Cache";

if (lngConceptAttachmentId == 0)
{
  const strMsg = Format("参数:[lngConceptAttachmentId]不能为空！(In GetObjByConceptAttachmentId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
const arrConceptAttachmentObjLst_Cache = await ConceptAttachment_GetObjLst_Cache(strid_CurrEduCls);
try
{
const arrConceptAttachment_Sel: Array <clsConceptAttachmentEN> = arrConceptAttachmentObjLst_Cache.filter(x => x.conceptAttachmentId == lngConceptAttachmentId);
let objConceptAttachment: clsConceptAttachmentEN;
if (arrConceptAttachment_Sel.length > 0)
{
objConceptAttachment = arrConceptAttachment_Sel[0];
return objConceptAttachment;
}
else
{
if (bolTryAsyncOnce == true)
{
objConceptAttachment = await ConceptAttachment_GetObjByConceptAttachmentIdAsync(lngConceptAttachmentId);
if (objConceptAttachment != null)
{
ConceptAttachment_ReFreshThisCache(strid_CurrEduCls);
return objConceptAttachment;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngConceptAttachmentId, conceptAttachment_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param lngConceptAttachmentId:所给的关键字
 * @returns 对象
*/
export async function ConceptAttachment_GetObjByConceptAttachmentId_localStorage(lngConceptAttachmentId: number) {
const strThisFuncName = "GetObjByConceptAttachmentId_localStorage";

if (lngConceptAttachmentId == 0)
{
  const strMsg = Format("参数:[lngConceptAttachmentId]不能为空！(In GetObjByConceptAttachmentId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
const strKey = Format("{0}_{1}", clsConceptAttachmentEN._CurrTabName, lngConceptAttachmentId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objConceptAttachment_Cache: clsConceptAttachmentEN = JSON.parse(strTempObj);
return objConceptAttachment_Cache;
}
try
{
const objConceptAttachment = await ConceptAttachment_GetObjByConceptAttachmentIdAsync(lngConceptAttachmentId);
if (objConceptAttachment != null)
{
localStorage.setItem(strKey, JSON.stringify(objConceptAttachment));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objConceptAttachment;
}
return objConceptAttachment;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngConceptAttachmentId, conceptAttachment_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objConceptAttachment:所给的对象
 * @returns 对象
*/
export async function ConceptAttachment_UpdateObjInLst_Cache(objConceptAttachment: clsConceptAttachmentEN,strid_CurrEduCls: string) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrConceptAttachmentObjLst_Cache = await ConceptAttachment_GetObjLst_Cache(strid_CurrEduCls);
const obj = arrConceptAttachmentObjLst_Cache.find(x => x.conceptAttachmentId == objConceptAttachment.conceptAttachmentId && x.conceptId == objConceptAttachment.conceptId);
if (obj != null)
{
objConceptAttachment.conceptAttachmentId = obj.conceptAttachmentId;
ObjectAssign( obj, objConceptAttachment);
}
else
{
arrConceptAttachmentObjLst_Cache.push(objConceptAttachment);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, conceptAttachment_ConstructorName, strThisFuncName);
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
 @param strid_CurrEduCls:缓存的分类字段
 * @returns 返回一个输出字段值
*/
export async function ConceptAttachment_func(strInFldName:string , strOutFldName:string , strInValue:number , strid_CurrEduCls_C: string)
{
//const strThisFuncName = "func";

if (IsNullOrEmpty(strid_CurrEduCls_C) == true)
{
  const strMsg = Format("参数:[strid_CurrEduCls_C]不能为空！(In func)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_CurrEduCls_C.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！", strid_CurrEduCls_C.length);
console.error(strMsg);
throw (strMsg);
}

if (strInFldName != clsConceptAttachmentEN.con_ConceptAttachmentId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsConceptAttachmentEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clsConceptAttachmentEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const lngConceptAttachmentId = Number(strInValue);
if (lngConceptAttachmentId == 0)
{
return "";
}
const objConceptAttachment = await ConceptAttachment_GetObjByConceptAttachmentId_Cache(lngConceptAttachmentId , strid_CurrEduCls_C);
if (objConceptAttachment == null) return "";
return objConceptAttachment.GetFldValue(strOutFldName).toString();
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
export function ConceptAttachment_SortFun_Defa(a:clsConceptAttachmentEN , b:clsConceptAttachmentEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.conceptAttachmentId-b.conceptAttachmentId;
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
export function ConceptAttachment_SortFun_Defa_2Fld(a:clsConceptAttachmentEN , b:clsConceptAttachmentEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.conceptAttachmentName == b.conceptAttachmentName) return a.conceptId.localeCompare(b.conceptId);
else return a.conceptAttachmentName.localeCompare(b.conceptAttachmentName);
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
export function ConceptAttachment_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsConceptAttachmentEN.con_ConceptAttachmentId:
return (a: clsConceptAttachmentEN, b: clsConceptAttachmentEN) => {
return a.conceptAttachmentId-b.conceptAttachmentId;
}
case clsConceptAttachmentEN.con_ConceptAttachmentName:
return (a: clsConceptAttachmentEN, b: clsConceptAttachmentEN) => {
return a.conceptAttachmentName.localeCompare(b.conceptAttachmentName);
}
case clsConceptAttachmentEN.con_ConceptId:
return (a: clsConceptAttachmentEN, b: clsConceptAttachmentEN) => {
return a.conceptId.localeCompare(b.conceptId);
}
case clsConceptAttachmentEN.con_FilePath:
return (a: clsConceptAttachmentEN, b: clsConceptAttachmentEN) => {
return a.filePath.localeCompare(b.filePath);
}
case clsConceptAttachmentEN.con_UpdDate:
return (a: clsConceptAttachmentEN, b: clsConceptAttachmentEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsConceptAttachmentEN.con_UpdUserId:
return (a: clsConceptAttachmentEN, b: clsConceptAttachmentEN) => {
return a.updUserId.localeCompare(b.updUserId);
}
case clsConceptAttachmentEN.con_Memo:
return (a: clsConceptAttachmentEN, b: clsConceptAttachmentEN) => {
return a.memo.localeCompare(b.memo);
}
case clsConceptAttachmentEN.con_id_CurrEduCls:
return (a: clsConceptAttachmentEN, b: clsConceptAttachmentEN) => {
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[ConceptAttachment]中不存在！(in ${ conceptAttachment_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsConceptAttachmentEN.con_ConceptAttachmentId:
return (a: clsConceptAttachmentEN, b: clsConceptAttachmentEN) => {
return b.conceptAttachmentId-a.conceptAttachmentId;
}
case clsConceptAttachmentEN.con_ConceptAttachmentName:
return (a: clsConceptAttachmentEN, b: clsConceptAttachmentEN) => {
return b.conceptAttachmentName.localeCompare(a.conceptAttachmentName);
}
case clsConceptAttachmentEN.con_ConceptId:
return (a: clsConceptAttachmentEN, b: clsConceptAttachmentEN) => {
return b.conceptId.localeCompare(a.conceptId);
}
case clsConceptAttachmentEN.con_FilePath:
return (a: clsConceptAttachmentEN, b: clsConceptAttachmentEN) => {
return b.filePath.localeCompare(a.filePath);
}
case clsConceptAttachmentEN.con_UpdDate:
return (a: clsConceptAttachmentEN, b: clsConceptAttachmentEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsConceptAttachmentEN.con_UpdUserId:
return (a: clsConceptAttachmentEN, b: clsConceptAttachmentEN) => {
return b.updUserId.localeCompare(a.updUserId);
}
case clsConceptAttachmentEN.con_Memo:
return (a: clsConceptAttachmentEN, b: clsConceptAttachmentEN) => {
return b.memo.localeCompare(a.memo);
}
case clsConceptAttachmentEN.con_id_CurrEduCls:
return (a: clsConceptAttachmentEN, b: clsConceptAttachmentEN) => {
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[ConceptAttachment]中不存在！(in ${ conceptAttachment_ConstructorName}.${ strThisFuncName})`;
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
export async function ConceptAttachment_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsConceptAttachmentEN.con_ConceptAttachmentId:
return (obj: clsConceptAttachmentEN) => {
return obj.conceptAttachmentId === value;
}
case clsConceptAttachmentEN.con_ConceptAttachmentName:
return (obj: clsConceptAttachmentEN) => {
return obj.conceptAttachmentName === value;
}
case clsConceptAttachmentEN.con_ConceptId:
return (obj: clsConceptAttachmentEN) => {
return obj.conceptId === value;
}
case clsConceptAttachmentEN.con_FilePath:
return (obj: clsConceptAttachmentEN) => {
return obj.filePath === value;
}
case clsConceptAttachmentEN.con_UpdDate:
return (obj: clsConceptAttachmentEN) => {
return obj.updDate === value;
}
case clsConceptAttachmentEN.con_UpdUserId:
return (obj: clsConceptAttachmentEN) => {
return obj.updUserId === value;
}
case clsConceptAttachmentEN.con_Memo:
return (obj: clsConceptAttachmentEN) => {
return obj.memo === value;
}
case clsConceptAttachmentEN.con_id_CurrEduCls:
return (obj: clsConceptAttachmentEN) => {
return obj.id_CurrEduCls === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[ConceptAttachment]中不存在！(in ${ conceptAttachment_ConstructorName}.${ strThisFuncName})`;
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
export async function ConceptAttachment_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(conceptAttachment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptAttachment_ConstructorName, strThisFuncName);
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
export async function ConceptAttachment_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(conceptAttachment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptAttachment_ConstructorName, strThisFuncName);
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
export async function ConceptAttachment_GetFirstObjAsync(strWhereCond: string): Promise<clsConceptAttachmentEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(conceptAttachment_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", conceptAttachment_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objConceptAttachment = ConceptAttachment_GetObjFromJsonObj(returnObj);
return objConceptAttachment;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptAttachment_ConstructorName, strThisFuncName);
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
export async function ConceptAttachment_GetObjLst_ClientCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsConceptAttachmentEN._CurrTabName, strid_CurrEduCls);
clsConceptAttachmentEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsConceptAttachmentEN._CurrTabName);
if (IsNullOrEmpty(clsConceptAttachmentEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsConceptAttachmentEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrConceptAttachmentExObjLst_Cache: Array<clsConceptAttachmentEN> = CacheHelper.Get(strKey);
const arrConceptAttachmentObjLst_T = ConceptAttachment_GetObjLstByJSONObjLst(arrConceptAttachmentExObjLst_Cache);
return arrConceptAttachmentObjLst_T;
}
try
{
const arrConceptAttachmentExObjLst = await ConceptAttachment_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrConceptAttachmentExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrConceptAttachmentExObjLst.length);
console.log(strInfo);
return arrConceptAttachmentExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, conceptAttachment_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function ConceptAttachment_GetObjLst_localStorage(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsConceptAttachmentEN._CurrTabName, strid_CurrEduCls);
clsConceptAttachmentEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsConceptAttachmentEN._CurrTabName);
if (IsNullOrEmpty(clsConceptAttachmentEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsConceptAttachmentEN.CacheAddiCondition);
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
const arrConceptAttachmentExObjLst_Cache: Array<clsConceptAttachmentEN> = JSON.parse(strTempObjLst);
const arrConceptAttachmentObjLst_T = ConceptAttachment_GetObjLstByJSONObjLst(arrConceptAttachmentExObjLst_Cache);
return arrConceptAttachmentObjLst_T;
}
try
{
const arrConceptAttachmentExObjLst = await ConceptAttachment_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrConceptAttachmentExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrConceptAttachmentExObjLst.length);
console.log(strInfo);
return arrConceptAttachmentExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, conceptAttachment_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function ConceptAttachment_GetObjLst_localStorage_PureCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsConceptAttachmentEN._CurrTabName, strid_CurrEduCls);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrConceptAttachmentObjLst_Cache: Array<clsConceptAttachmentEN> = JSON.parse(strTempObjLst);
return arrConceptAttachmentObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function ConceptAttachment_GetObjLstAsync(strWhereCond: string): Promise<Array<clsConceptAttachmentEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(conceptAttachment_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", conceptAttachment_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = ConceptAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptAttachment_ConstructorName, strThisFuncName);
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
export async function ConceptAttachment_GetObjLst_sessionStorage(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsConceptAttachmentEN._CurrTabName, strid_CurrEduCls);
clsConceptAttachmentEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsConceptAttachmentEN._CurrTabName);
if (IsNullOrEmpty(clsConceptAttachmentEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsConceptAttachmentEN.CacheAddiCondition);
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
const arrConceptAttachmentExObjLst_Cache: Array<clsConceptAttachmentEN> = JSON.parse(strTempObjLst);
const arrConceptAttachmentObjLst_T = ConceptAttachment_GetObjLstByJSONObjLst(arrConceptAttachmentExObjLst_Cache);
return arrConceptAttachmentObjLst_T;
}
try
{
const arrConceptAttachmentExObjLst = await ConceptAttachment_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrConceptAttachmentExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrConceptAttachmentExObjLst.length);
console.log(strInfo);
return arrConceptAttachmentExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, conceptAttachment_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function ConceptAttachment_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsConceptAttachmentEN._CurrTabName, strid_CurrEduCls);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrConceptAttachmentObjLst_Cache: Array<clsConceptAttachmentEN> = JSON.parse(strTempObjLst);
return arrConceptAttachmentObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function ConceptAttachment_GetObjLst_Cache(strid_CurrEduCls: string): Promise<Array<clsConceptAttachmentEN>>
{
//const strThisFuncName = "GetObjLst_Cache";

if (IsNullOrEmpty(strid_CurrEduCls) == true)
{
const strMsg = Format("缓存分类变量:[id_CurrEduCls]不能为空！");
console.error(strMsg);
throw (strMsg);
}
if (strid_CurrEduCls.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！", strid_CurrEduCls.length);
console.error(strMsg);
throw (strMsg);
}
let arrConceptAttachmentObjLst_Cache;
switch (clsConceptAttachmentEN.CacheModeId)
{
case "04"://sessionStorage
arrConceptAttachmentObjLst_Cache = await ConceptAttachment_GetObjLst_sessionStorage(strid_CurrEduCls);
break;
case "03"://localStorage
arrConceptAttachmentObjLst_Cache = await ConceptAttachment_GetObjLst_localStorage(strid_CurrEduCls);
break;
case "02"://ClientCache
arrConceptAttachmentObjLst_Cache = await ConceptAttachment_GetObjLst_ClientCache(strid_CurrEduCls);
break;
default:
arrConceptAttachmentObjLst_Cache = await ConceptAttachment_GetObjLst_ClientCache(strid_CurrEduCls);
break;
}
const arrConceptAttachmentObjLst = ConceptAttachment_GetObjLstByJSONObjLst(arrConceptAttachmentObjLst_Cache);
return arrConceptAttachmentObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function ConceptAttachment_GetObjLst_PureCache(strid_CurrEduCls: string)
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrConceptAttachmentObjLst_Cache;
switch (clsConceptAttachmentEN.CacheModeId)
{
case "04"://sessionStorage
arrConceptAttachmentObjLst_Cache = await ConceptAttachment_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls);
break;
case "03"://localStorage
arrConceptAttachmentObjLst_Cache = await ConceptAttachment_GetObjLst_localStorage_PureCache(strid_CurrEduCls);
break;
case "02"://ClientCache
arrConceptAttachmentObjLst_Cache = null;
break;
default:
arrConceptAttachmentObjLst_Cache = null;
break;
}
return arrConceptAttachmentObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objlngConceptAttachmentId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function ConceptAttachment_GetSubObjLst_Cache(objConceptAttachment_Cond: clsConceptAttachmentEN,strid_CurrEduCls: string) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrConceptAttachmentObjLst_Cache = await ConceptAttachment_GetObjLst_Cache(strid_CurrEduCls);
let arrConceptAttachment_Sel: Array < clsConceptAttachmentEN > = arrConceptAttachmentObjLst_Cache;
if (objConceptAttachment_Cond.sf_FldComparisonOp == null || objConceptAttachment_Cond.sf_FldComparisonOp == "") return arrConceptAttachment_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objConceptAttachment_Cond.sf_FldComparisonOp);
//console.log("clsConceptAttachmentWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objConceptAttachment_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objConceptAttachment_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrConceptAttachment_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objConceptAttachment_Cond), conceptAttachment_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsConceptAttachmentEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrConceptAttachmentId:关键字列表
 * @returns 对象列表
 **/
export async function ConceptAttachment_GetObjLstByConceptAttachmentIdLstAsync(arrConceptAttachmentId: Array<string>): Promise<Array<clsConceptAttachmentEN>>  
{
const strThisFuncName = "GetObjLstByConceptAttachmentIdLstAsync";
const strAction = "GetObjLstByConceptAttachmentIdLst";
const strUrl = GetWebApiUrl(conceptAttachment_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrConceptAttachmentId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", conceptAttachment_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = ConceptAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptAttachment_ConstructorName, strThisFuncName);
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
 * @param arrlngConceptAttachmentIdLst:关键字列表
 * @returns 对象列表
*/
export async function ConceptAttachment_GetObjLstByConceptAttachmentIdLst_Cache(arrConceptAttachmentIdLst: Array<number>,strid_CurrEduCls: string) {
const strThisFuncName = "GetObjLstByConceptAttachmentIdLst_Cache";
try
{
const arrConceptAttachmentObjLst_Cache = await ConceptAttachment_GetObjLst_Cache(strid_CurrEduCls);
const arrConceptAttachment_Sel: Array <clsConceptAttachmentEN> = arrConceptAttachmentObjLst_Cache.filter(x => arrConceptAttachmentIdLst.indexOf(x.conceptAttachmentId)>-1);
return arrConceptAttachment_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrConceptAttachmentIdLst.join(","), conceptAttachment_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsConceptAttachmentEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function ConceptAttachment_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsConceptAttachmentEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(conceptAttachment_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", conceptAttachment_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = ConceptAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptAttachment_ConstructorName, strThisFuncName);
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
export async function ConceptAttachment_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsConceptAttachmentEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(conceptAttachment_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", conceptAttachment_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = ConceptAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptAttachment_ConstructorName, strThisFuncName);
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
export async function ConceptAttachment_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(conceptAttachment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptAttachment_ConstructorName, strThisFuncName);
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
export async function ConceptAttachment_GetObjLstByPager_Cache(objPagerPara: stuPagerPara,strid_CurrEduCls: string) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrConceptAttachmentObjLst_Cache = await ConceptAttachment_GetObjLst_Cache(strid_CurrEduCls);
if (arrConceptAttachmentObjLst_Cache.length == 0) return arrConceptAttachmentObjLst_Cache;
let arrConceptAttachment_Sel = arrConceptAttachmentObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objConceptAttachment_Cond = new clsConceptAttachmentEN();
ObjectAssign(objConceptAttachment_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsConceptAttachmentWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objConceptAttachment_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrConceptAttachment_Sel.length == 0) return arrConceptAttachment_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrConceptAttachment_Sel = arrConceptAttachment_Sel.sort(ConceptAttachment_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrConceptAttachment_Sel = arrConceptAttachment_Sel.sort(objPagerPara.sortFun);
}
arrConceptAttachment_Sel = arrConceptAttachment_Sel.slice(intStart, intEnd);     
return arrConceptAttachment_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, conceptAttachment_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsConceptAttachmentEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function ConceptAttachment_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsConceptAttachmentEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(conceptAttachment_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", conceptAttachment_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = ConceptAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptAttachment_ConstructorName, strThisFuncName);
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
 * @param lngConceptAttachmentId:关键字
 * @returns 获取删除的结果
 **/
export async function ConceptAttachment_DelRecordAsync(lngConceptAttachmentId: number): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(conceptAttachment_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, lngConceptAttachmentId);
try
{
const response = await axios.delete(strUrl,
{
params: { "Id": lngConceptAttachmentId, }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptAttachment_ConstructorName, strThisFuncName);
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
 * @param arrConceptAttachmentId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function ConceptAttachment_DelConceptAttachmentsAsync(arrConceptAttachmentId: Array<string>): Promise<number> 
{
const strThisFuncName = "DelConceptAttachmentsAsync";
const strAction = "DelConceptAttachments";
const strUrl = GetWebApiUrl(conceptAttachment_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrConceptAttachmentId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptAttachment_ConstructorName, strThisFuncName);
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
export async function ConceptAttachment_DelConceptAttachmentsByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "DelConceptAttachmentsByCondAsync";
const strAction = "DelConceptAttachmentsByCond";
const strUrl = GetWebApiUrl(conceptAttachment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptAttachment_ConstructorName, strThisFuncName);
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
 * @param objConceptAttachmentEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function ConceptAttachment_AddNewRecordAsync(objConceptAttachmentEN: clsConceptAttachmentEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objConceptAttachmentEN);
const strUrl = GetWebApiUrl(conceptAttachment_Controller, strAction);
try
{
const response = await axios.post(strUrl, objConceptAttachmentEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptAttachment_ConstructorName, strThisFuncName);
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
 * @param objConceptAttachmentEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function ConceptAttachment_AddNewRecordWithReturnKeyAsync(objConceptAttachmentEN: clsConceptAttachmentEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(conceptAttachment_Controller, strAction);
try
{
const response = await axios.post(strUrl, objConceptAttachmentEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptAttachment_ConstructorName, strThisFuncName);
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
 * @param objConceptAttachmentEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function ConceptAttachment_AddNewRecordWithReturnKey(objConceptAttachmentEN: clsConceptAttachmentEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objConceptAttachmentEN.conceptAttachmentId === null || objConceptAttachmentEN.conceptAttachmentId === 0)
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(conceptAttachment_Controller, strAction);
try
{
const response = await axios.post(strUrl, objConceptAttachmentEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptAttachment_ConstructorName, strThisFuncName);
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
 * @param objConceptAttachmentEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function ConceptAttachment_UpdateRecordAsync(objConceptAttachmentEN: clsConceptAttachmentEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objConceptAttachmentEN.sf_UpdFldSetStr === undefined || objConceptAttachmentEN.sf_UpdFldSetStr === null || objConceptAttachmentEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objConceptAttachmentEN.conceptAttachmentId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(conceptAttachment_Controller, strAction);
try
{
const response = await axios.post(strUrl, objConceptAttachmentEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptAttachment_ConstructorName, strThisFuncName);
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
 * @param objConceptAttachmentEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function ConceptAttachment_UpdateWithConditionAsync(objConceptAttachmentEN: clsConceptAttachmentEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objConceptAttachmentEN.sf_UpdFldSetStr === undefined || objConceptAttachmentEN.sf_UpdFldSetStr === null || objConceptAttachmentEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objConceptAttachmentEN.conceptAttachmentId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(conceptAttachment_Controller, strAction);
objConceptAttachmentEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objConceptAttachmentEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptAttachment_ConstructorName, strThisFuncName);
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
 * @param objlngConceptAttachmentId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function ConceptAttachment_IsExistRecord_Cache(objConceptAttachment_Cond: clsConceptAttachmentEN,strid_CurrEduCls: string) {
const strThisFuncName = "IsExistRecord_Cache";
const arrConceptAttachmentObjLst_Cache = await ConceptAttachment_GetObjLst_Cache(strid_CurrEduCls);
if (arrConceptAttachmentObjLst_Cache == null) return false;
let arrConceptAttachment_Sel: Array < clsConceptAttachmentEN > = arrConceptAttachmentObjLst_Cache;
if (objConceptAttachment_Cond.sf_FldComparisonOp == null || objConceptAttachment_Cond.sf_FldComparisonOp == "") return arrConceptAttachment_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objConceptAttachment_Cond.sf_FldComparisonOp);
//console.log("clsConceptAttachmentWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objConceptAttachment_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objConceptAttachment_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrConceptAttachment_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objConceptAttachment_Cond), conceptAttachment_ConstructorName, strThisFuncName);
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
export async function ConceptAttachment_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(conceptAttachment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptAttachment_ConstructorName, strThisFuncName);
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
 * @param lngConceptAttachmentId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function ConceptAttachment_IsExist(lngConceptAttachmentId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(conceptAttachment_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"ConceptAttachmentId": lngConceptAttachmentId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptAttachment_ConstructorName, strThisFuncName);
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
 * @param lngConceptAttachmentId:所给的关键字
 * @returns 对象
*/
export async function ConceptAttachment_IsExist_Cache(lngConceptAttachmentId:number,strid_CurrEduCls:string) {
const strThisFuncName = "IsExist_Cache";
const arrConceptAttachmentObjLst_Cache = await ConceptAttachment_GetObjLst_Cache(strid_CurrEduCls);
if (arrConceptAttachmentObjLst_Cache == null) return false;
try
{
const arrConceptAttachment_Sel: Array <clsConceptAttachmentEN> = arrConceptAttachmentObjLst_Cache.filter(x => x.conceptAttachmentId == lngConceptAttachmentId);
if (arrConceptAttachment_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngConceptAttachmentId, conceptAttachment_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param lngConceptAttachmentId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function ConceptAttachment_IsExistAsync(lngConceptAttachmentId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(conceptAttachment_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "lngConceptAttachmentId": lngConceptAttachmentId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptAttachment_ConstructorName, strThisFuncName);
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
export async function ConceptAttachment_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(conceptAttachment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptAttachment_ConstructorName, strThisFuncName);
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
 * @param objConceptAttachment_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function ConceptAttachment_GetRecCountByCond_Cache(objConceptAttachment_Cond: clsConceptAttachmentEN,strid_CurrEduCls: string) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrConceptAttachmentObjLst_Cache = await ConceptAttachment_GetObjLst_Cache(strid_CurrEduCls);
if (arrConceptAttachmentObjLst_Cache == null) return 0;
let arrConceptAttachment_Sel: Array < clsConceptAttachmentEN > = arrConceptAttachmentObjLst_Cache;
if (objConceptAttachment_Cond.sf_FldComparisonOp == null || objConceptAttachment_Cond.sf_FldComparisonOp == "") return arrConceptAttachment_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objConceptAttachment_Cond.sf_FldComparisonOp);
//console.log("clsConceptAttachmentWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objConceptAttachment_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objConceptAttachment_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrConceptAttachment_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objConceptAttachment_Cond), conceptAttachment_ConstructorName, strThisFuncName);
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
export async function ConceptAttachment_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(conceptAttachment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, conceptAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, conceptAttachment_ConstructorName, strThisFuncName);
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
export function ConceptAttachment_GetWebApiUrl(strController: string, strAction: string): string {
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
export function ConceptAttachment_ReFreshCache(strid_CurrEduCls: string):void
{
const strThisFuncName = "ReFreshCache";

if (IsNullOrEmpty(strid_CurrEduCls) == true)
{
  const strMsg = Format("参数:[strid_CurrEduCls]不能为空！(In clsConceptAttachmentWApi.ReFreshCache)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_CurrEduCls.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！", strid_CurrEduCls.length);
console.error(strMsg);
throw (strMsg);
}

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = Format("{0}_{1}", clsConceptAttachmentEN._CurrTabName, strid_CurrEduCls);
switch (clsConceptAttachmentEN.CacheModeId)
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
vConceptAttachment_ReFreshThisCache(strid_CurrEduCls);
}

 /**
 * 刷新本类中的缓存.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
 **/
export function ConceptAttachment_ReFreshThisCache(strid_CurrEduCls: string):void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = Format("{0}_{1}", clsConceptAttachmentEN._CurrTabName, strid_CurrEduCls);
switch (clsConceptAttachmentEN.CacheModeId)
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
export function ConceptAttachment_CheckPropertyNew(pobjConceptAttachmentEN: clsConceptAttachmentEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjConceptAttachmentEN.conceptId) === true )
{
 throw new Error("(errid:Watl000058)字段[概念Id]不能为空(In 概念附件)!(clsConceptAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjConceptAttachmentEN.filePath) === true )
{
 throw new Error("(errid:Watl000058)字段[文件路径]不能为空(In 概念附件)!(clsConceptAttachmentBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjConceptAttachmentEN.conceptAttachmentName) == false && GetStrLen(pobjConceptAttachmentEN.conceptAttachmentName) > 200)
{
 throw new Error("(errid:Watl000059)字段[附件名称(conceptAttachmentName)]的长度不能超过200(In 概念附件(ConceptAttachment))!值:$(pobjConceptAttachmentEN.conceptAttachmentName)(clsConceptAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjConceptAttachmentEN.conceptId) == false && GetStrLen(pobjConceptAttachmentEN.conceptId) > 8)
{
 throw new Error("(errid:Watl000059)字段[概念Id(conceptId)]的长度不能超过8(In 概念附件(ConceptAttachment))!值:$(pobjConceptAttachmentEN.conceptId)(clsConceptAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjConceptAttachmentEN.filePath) == false && GetStrLen(pobjConceptAttachmentEN.filePath) > 500)
{
 throw new Error("(errid:Watl000059)字段[文件路径(filePath)]的长度不能超过500(In 概念附件(ConceptAttachment))!值:$(pobjConceptAttachmentEN.filePath)(clsConceptAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjConceptAttachmentEN.updDate) == false && GetStrLen(pobjConceptAttachmentEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 概念附件(ConceptAttachment))!值:$(pobjConceptAttachmentEN.updDate)(clsConceptAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjConceptAttachmentEN.updUserId) == false && GetStrLen(pobjConceptAttachmentEN.updUserId) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改用户Id(updUserId)]的长度不能超过20(In 概念附件(ConceptAttachment))!值:$(pobjConceptAttachmentEN.updUserId)(clsConceptAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjConceptAttachmentEN.memo) == false && GetStrLen(pobjConceptAttachmentEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 概念附件(ConceptAttachment))!值:$(pobjConceptAttachmentEN.memo)(clsConceptAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjConceptAttachmentEN.id_CurrEduCls) == false && GetStrLen(pobjConceptAttachmentEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 概念附件(ConceptAttachment))!值:$(pobjConceptAttachmentEN.id_CurrEduCls)(clsConceptAttachmentBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null != pobjConceptAttachmentEN.conceptAttachmentId && undefined !== pobjConceptAttachmentEN.conceptAttachmentId && tzDataType.isNumber(pobjConceptAttachmentEN.conceptAttachmentId) === false)
{
 throw new Error("(errid:Watl000060)字段[概念附件Id(conceptAttachmentId)]的值:[$(pobjConceptAttachmentEN.conceptAttachmentId)], 非法，应该为数值型(In 概念附件(ConceptAttachment))!(clsConceptAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjConceptAttachmentEN.conceptAttachmentName) == false && undefined !== pobjConceptAttachmentEN.conceptAttachmentName && tzDataType.isString(pobjConceptAttachmentEN.conceptAttachmentName) === false)
{
 throw new Error("(errid:Watl000060)字段[附件名称(conceptAttachmentName)]的值:[$(pobjConceptAttachmentEN.conceptAttachmentName)], 非法，应该为字符型(In 概念附件(ConceptAttachment))!(clsConceptAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjConceptAttachmentEN.conceptId) == false && undefined !== pobjConceptAttachmentEN.conceptId && tzDataType.isString(pobjConceptAttachmentEN.conceptId) === false)
{
 throw new Error("(errid:Watl000060)字段[概念Id(conceptId)]的值:[$(pobjConceptAttachmentEN.conceptId)], 非法，应该为字符型(In 概念附件(ConceptAttachment))!(clsConceptAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjConceptAttachmentEN.filePath) == false && undefined !== pobjConceptAttachmentEN.filePath && tzDataType.isString(pobjConceptAttachmentEN.filePath) === false)
{
 throw new Error("(errid:Watl000060)字段[文件路径(filePath)]的值:[$(pobjConceptAttachmentEN.filePath)], 非法，应该为字符型(In 概念附件(ConceptAttachment))!(clsConceptAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjConceptAttachmentEN.updDate) == false && undefined !== pobjConceptAttachmentEN.updDate && tzDataType.isString(pobjConceptAttachmentEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjConceptAttachmentEN.updDate)], 非法，应该为字符型(In 概念附件(ConceptAttachment))!(clsConceptAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjConceptAttachmentEN.updUserId) == false && undefined !== pobjConceptAttachmentEN.updUserId && tzDataType.isString(pobjConceptAttachmentEN.updUserId) === false)
{
 throw new Error("(errid:Watl000060)字段[修改用户Id(updUserId)]的值:[$(pobjConceptAttachmentEN.updUserId)], 非法，应该为字符型(In 概念附件(ConceptAttachment))!(clsConceptAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjConceptAttachmentEN.memo) == false && undefined !== pobjConceptAttachmentEN.memo && tzDataType.isString(pobjConceptAttachmentEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjConceptAttachmentEN.memo)], 非法，应该为字符型(In 概念附件(ConceptAttachment))!(clsConceptAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjConceptAttachmentEN.id_CurrEduCls) == false && undefined !== pobjConceptAttachmentEN.id_CurrEduCls && tzDataType.isString(pobjConceptAttachmentEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjConceptAttachmentEN.id_CurrEduCls)], 非法，应该为字符型(In 概念附件(ConceptAttachment))!(clsConceptAttachmentBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjConceptAttachmentEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function ConceptAttachment_CheckProperty4Update (pobjConceptAttachmentEN: clsConceptAttachmentEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjConceptAttachmentEN.conceptAttachmentName) == false && GetStrLen(pobjConceptAttachmentEN.conceptAttachmentName) > 200)
{
 throw new Error("(errid:Watl000062)字段[附件名称(conceptAttachmentName)]的长度不能超过200(In 概念附件(ConceptAttachment))!值:$(pobjConceptAttachmentEN.conceptAttachmentName)(clsConceptAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjConceptAttachmentEN.conceptId) == false && GetStrLen(pobjConceptAttachmentEN.conceptId) > 8)
{
 throw new Error("(errid:Watl000062)字段[概念Id(conceptId)]的长度不能超过8(In 概念附件(ConceptAttachment))!值:$(pobjConceptAttachmentEN.conceptId)(clsConceptAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjConceptAttachmentEN.filePath) == false && GetStrLen(pobjConceptAttachmentEN.filePath) > 500)
{
 throw new Error("(errid:Watl000062)字段[文件路径(filePath)]的长度不能超过500(In 概念附件(ConceptAttachment))!值:$(pobjConceptAttachmentEN.filePath)(clsConceptAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjConceptAttachmentEN.updDate) == false && GetStrLen(pobjConceptAttachmentEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 概念附件(ConceptAttachment))!值:$(pobjConceptAttachmentEN.updDate)(clsConceptAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjConceptAttachmentEN.updUserId) == false && GetStrLen(pobjConceptAttachmentEN.updUserId) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改用户Id(updUserId)]的长度不能超过20(In 概念附件(ConceptAttachment))!值:$(pobjConceptAttachmentEN.updUserId)(clsConceptAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjConceptAttachmentEN.memo) == false && GetStrLen(pobjConceptAttachmentEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 概念附件(ConceptAttachment))!值:$(pobjConceptAttachmentEN.memo)(clsConceptAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjConceptAttachmentEN.id_CurrEduCls) == false && GetStrLen(pobjConceptAttachmentEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 概念附件(ConceptAttachment))!值:$(pobjConceptAttachmentEN.id_CurrEduCls)(clsConceptAttachmentBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null != pobjConceptAttachmentEN.conceptAttachmentId && undefined !== pobjConceptAttachmentEN.conceptAttachmentId && tzDataType.isNumber(pobjConceptAttachmentEN.conceptAttachmentId) === false)
{
 throw new Error("(errid:Watl000063)字段[概念附件Id(conceptAttachmentId)]的值:[$(pobjConceptAttachmentEN.conceptAttachmentId)], 非法，应该为数值型(In 概念附件(ConceptAttachment))!(clsConceptAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjConceptAttachmentEN.conceptAttachmentName) == false && undefined !== pobjConceptAttachmentEN.conceptAttachmentName && tzDataType.isString(pobjConceptAttachmentEN.conceptAttachmentName) === false)
{
 throw new Error("(errid:Watl000063)字段[附件名称(conceptAttachmentName)]的值:[$(pobjConceptAttachmentEN.conceptAttachmentName)], 非法，应该为字符型(In 概念附件(ConceptAttachment))!(clsConceptAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjConceptAttachmentEN.conceptId) == false && undefined !== pobjConceptAttachmentEN.conceptId && tzDataType.isString(pobjConceptAttachmentEN.conceptId) === false)
{
 throw new Error("(errid:Watl000063)字段[概念Id(conceptId)]的值:[$(pobjConceptAttachmentEN.conceptId)], 非法，应该为字符型(In 概念附件(ConceptAttachment))!(clsConceptAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjConceptAttachmentEN.filePath) == false && undefined !== pobjConceptAttachmentEN.filePath && tzDataType.isString(pobjConceptAttachmentEN.filePath) === false)
{
 throw new Error("(errid:Watl000063)字段[文件路径(filePath)]的值:[$(pobjConceptAttachmentEN.filePath)], 非法，应该为字符型(In 概念附件(ConceptAttachment))!(clsConceptAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjConceptAttachmentEN.updDate) == false && undefined !== pobjConceptAttachmentEN.updDate && tzDataType.isString(pobjConceptAttachmentEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjConceptAttachmentEN.updDate)], 非法，应该为字符型(In 概念附件(ConceptAttachment))!(clsConceptAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjConceptAttachmentEN.updUserId) == false && undefined !== pobjConceptAttachmentEN.updUserId && tzDataType.isString(pobjConceptAttachmentEN.updUserId) === false)
{
 throw new Error("(errid:Watl000063)字段[修改用户Id(updUserId)]的值:[$(pobjConceptAttachmentEN.updUserId)], 非法，应该为字符型(In 概念附件(ConceptAttachment))!(clsConceptAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjConceptAttachmentEN.memo) == false && undefined !== pobjConceptAttachmentEN.memo && tzDataType.isString(pobjConceptAttachmentEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjConceptAttachmentEN.memo)], 非法，应该为字符型(In 概念附件(ConceptAttachment))!(clsConceptAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjConceptAttachmentEN.id_CurrEduCls) == false && undefined !== pobjConceptAttachmentEN.id_CurrEduCls && tzDataType.isString(pobjConceptAttachmentEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjConceptAttachmentEN.id_CurrEduCls)], 非法，应该为字符型(In 概念附件(ConceptAttachment))!(clsConceptAttachmentBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjConceptAttachmentEN.conceptAttachmentId 
 || pobjConceptAttachmentEN.conceptAttachmentId != null && pobjConceptAttachmentEN.conceptAttachmentId.toString()  ===  "")
{
 throw new Error("(errid:Watl000064)字段[概念附件Id]不能为空(In 概念附件)!(clsConceptAttachmentBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjConceptAttachmentEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function ConceptAttachment_GetJSONStrByObj (pobjConceptAttachmentEN: clsConceptAttachmentEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjConceptAttachmentEN.sf_UpdFldSetStr = pobjConceptAttachmentEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjConceptAttachmentEN);
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
export function ConceptAttachment_GetObjLstByJSONStr (strJSON: string): Array<clsConceptAttachmentEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrConceptAttachmentObjLst = new Array<clsConceptAttachmentEN>();
if (strJSON === "")
{
return arrConceptAttachmentObjLst;
}
try
{
arrConceptAttachmentObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrConceptAttachmentObjLst;
}
return arrConceptAttachmentObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrConceptAttachmentObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function ConceptAttachment_GetObjLstByJSONObjLst (arrConceptAttachmentObjLstS: Array<clsConceptAttachmentEN>): Array<clsConceptAttachmentEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrConceptAttachmentObjLst = new Array<clsConceptAttachmentEN>();
for (const objInFor of arrConceptAttachmentObjLstS) {
const obj1 = ConceptAttachment_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrConceptAttachmentObjLst.push(obj1);
}
return arrConceptAttachmentObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function ConceptAttachment_GetObjByJSONStr (strJSON: string): clsConceptAttachmentEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjConceptAttachmentEN = new clsConceptAttachmentEN();
if (strJSON === "")
{
return pobjConceptAttachmentEN;
}
try
{
pobjConceptAttachmentEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjConceptAttachmentEN;
}
return pobjConceptAttachmentEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function ConceptAttachment_GetCombineCondition(objConceptAttachment_Cond: clsConceptAttachmentEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objConceptAttachment_Cond.dicFldComparisonOp, clsConceptAttachmentEN.con_ConceptAttachmentId) == true)
{
const strComparisonOp_ConceptAttachmentId:string = objConceptAttachment_Cond.dicFldComparisonOp[clsConceptAttachmentEN.con_ConceptAttachmentId];
strWhereCond += Format(" And {0} {2} {1}", clsConceptAttachmentEN.con_ConceptAttachmentId, objConceptAttachment_Cond.conceptAttachmentId, strComparisonOp_ConceptAttachmentId);
}
if (Object.prototype.hasOwnProperty.call(objConceptAttachment_Cond.dicFldComparisonOp, clsConceptAttachmentEN.con_ConceptAttachmentName) == true)
{
const strComparisonOp_ConceptAttachmentName:string = objConceptAttachment_Cond.dicFldComparisonOp[clsConceptAttachmentEN.con_ConceptAttachmentName];
strWhereCond += Format(" And {0} {2} '{1}'", clsConceptAttachmentEN.con_ConceptAttachmentName, objConceptAttachment_Cond.conceptAttachmentName, strComparisonOp_ConceptAttachmentName);
}
if (Object.prototype.hasOwnProperty.call(objConceptAttachment_Cond.dicFldComparisonOp, clsConceptAttachmentEN.con_ConceptId) == true)
{
const strComparisonOp_ConceptId:string = objConceptAttachment_Cond.dicFldComparisonOp[clsConceptAttachmentEN.con_ConceptId];
strWhereCond += Format(" And {0} {2} '{1}'", clsConceptAttachmentEN.con_ConceptId, objConceptAttachment_Cond.conceptId, strComparisonOp_ConceptId);
}
if (Object.prototype.hasOwnProperty.call(objConceptAttachment_Cond.dicFldComparisonOp, clsConceptAttachmentEN.con_FilePath) == true)
{
const strComparisonOp_FilePath:string = objConceptAttachment_Cond.dicFldComparisonOp[clsConceptAttachmentEN.con_FilePath];
strWhereCond += Format(" And {0} {2} '{1}'", clsConceptAttachmentEN.con_FilePath, objConceptAttachment_Cond.filePath, strComparisonOp_FilePath);
}
if (Object.prototype.hasOwnProperty.call(objConceptAttachment_Cond.dicFldComparisonOp, clsConceptAttachmentEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objConceptAttachment_Cond.dicFldComparisonOp[clsConceptAttachmentEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsConceptAttachmentEN.con_UpdDate, objConceptAttachment_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objConceptAttachment_Cond.dicFldComparisonOp, clsConceptAttachmentEN.con_UpdUserId) == true)
{
const strComparisonOp_UpdUserId:string = objConceptAttachment_Cond.dicFldComparisonOp[clsConceptAttachmentEN.con_UpdUserId];
strWhereCond += Format(" And {0} {2} '{1}'", clsConceptAttachmentEN.con_UpdUserId, objConceptAttachment_Cond.updUserId, strComparisonOp_UpdUserId);
}
if (Object.prototype.hasOwnProperty.call(objConceptAttachment_Cond.dicFldComparisonOp, clsConceptAttachmentEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objConceptAttachment_Cond.dicFldComparisonOp[clsConceptAttachmentEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsConceptAttachmentEN.con_Memo, objConceptAttachment_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objConceptAttachment_Cond.dicFldComparisonOp, clsConceptAttachmentEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objConceptAttachment_Cond.dicFldComparisonOp[clsConceptAttachmentEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsConceptAttachmentEN.con_id_CurrEduCls, objConceptAttachment_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--ConceptAttachment(概念附件),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param lngConceptAttachmentId: 概念附件Id(要求唯一的字段)
 * @param strConceptId: 概念Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function ConceptAttachment_GetUniCondStr_ConceptAttachmentId_ConceptId(objConceptAttachmentEN: clsConceptAttachmentEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and ConceptAttachmentId = '{0}'", objConceptAttachmentEN.conceptAttachmentId);
 strWhereCond +=  Format(" and ConceptId = '{0}'", objConceptAttachmentEN.conceptId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--ConceptAttachment(概念附件),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param lngConceptAttachmentId: 概念附件Id(要求唯一的字段)
 * @param strConceptId: 概念Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function ConceptAttachment_GetUniCondStr4Update_ConceptAttachmentId_ConceptId(objConceptAttachmentEN: clsConceptAttachmentEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and ConceptAttachmentId <> '{0}'", objConceptAttachmentEN.conceptAttachmentId);
 strWhereCond +=  Format(" and ConceptAttachmentId = '{0}'", objConceptAttachmentEN.conceptAttachmentId);
 strWhereCond +=  Format(" and ConceptId = '{0}'", objConceptAttachmentEN.conceptId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objConceptAttachmentENS:源对象
 * @param objConceptAttachmentENT:目标对象
*/
export function ConceptAttachment_CopyObjTo(objConceptAttachmentENS: clsConceptAttachmentEN , objConceptAttachmentENT: clsConceptAttachmentEN ): void 
{
objConceptAttachmentENT.conceptAttachmentId = objConceptAttachmentENS.conceptAttachmentId; //概念附件Id
objConceptAttachmentENT.conceptAttachmentName = objConceptAttachmentENS.conceptAttachmentName; //附件名称
objConceptAttachmentENT.conceptId = objConceptAttachmentENS.conceptId; //概念Id
objConceptAttachmentENT.filePath = objConceptAttachmentENS.filePath; //文件路径
objConceptAttachmentENT.updDate = objConceptAttachmentENS.updDate; //修改日期
objConceptAttachmentENT.updUserId = objConceptAttachmentENS.updUserId; //修改用户Id
objConceptAttachmentENT.memo = objConceptAttachmentENS.memo; //备注
objConceptAttachmentENT.id_CurrEduCls = objConceptAttachmentENS.id_CurrEduCls; //教学班流水号
objConceptAttachmentENT.sf_UpdFldSetStr = objConceptAttachmentENS.updFldString; //sf_UpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objConceptAttachmentENS:源对象
 * @param objConceptAttachmentENT:目标对象
*/
export function ConceptAttachment_GetObjFromJsonObj(objConceptAttachmentENS: clsConceptAttachmentEN): clsConceptAttachmentEN 
{
 const objConceptAttachmentENT: clsConceptAttachmentEN = new clsConceptAttachmentEN();
ObjectAssign(objConceptAttachmentENT, objConceptAttachmentENS);
 return objConceptAttachmentENT;
}