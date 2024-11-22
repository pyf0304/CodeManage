
 /**
 * 类名:clscc_CourseKnowledgesWApi
 * 表名:cc_CourseKnowledges(01120082)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:46:00
 * 生成者:pyf
 * 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:知识点相关(Knowledges)
 * 框架-层名:WA_访问层(TS)(WA_Access)
 * 编程语言:TypeScript
 * 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
   *      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 **/

/**
 * 知识点(cc_CourseKnowledges)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clscc_CourseKnowledgesEN } from "../../L0_Entity/Knowledges/clscc_CourseKnowledgesEN.js";
import { clsOrderByData } from "../../PubFun/clsOrderByData.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { tzDataType } from "../../PubFun/jsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const cc_CourseKnowledges_Controller = "cc_CourseKnowledgesApi";
 export const cc_CourseKnowledges_ConstructorName = "cc_CourseKnowledges";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strCourseKnowledgeId:关键字
 * @returns 对象
 **/
export async function cc_CourseKnowledges_GetObjByCourseKnowledgeIdAsync(strCourseKnowledgeId: string): Promise<clscc_CourseKnowledgesEN>  
{
const strThisFuncName = "GetObjByCourseKnowledgeIdAsync";

if (IsNullOrEmpty(strCourseKnowledgeId) == true)
{
  const strMsg = Format("参数:[strCourseKnowledgeId]不能为空！(In GetObjByCourseKnowledgeIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strCourseKnowledgeId.length != 8)
{
const strMsg = Format("缓存分类变量:[strCourseKnowledgeId]的长度:[{0}]不正确！", strCourseKnowledgeId.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByCourseKnowledgeId";
const strUrl = GetWebApiUrl(cc_CourseKnowledges_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strCourseKnowledgeId": strCourseKnowledgeId,
}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObj = data.returnObj;
if (returnObj == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", cc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objcc_CourseKnowledges = cc_CourseKnowledges_GetObjFromJsonObj(returnObj);
return objcc_CourseKnowledges;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_CourseKnowledges_ConstructorName, strThisFuncName);
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
 * @param strCourseKnowledgeId:所给的关键字
 * @returns 对象
*/
export async function cc_CourseKnowledges_GetObjByCourseKnowledgeId_Cache(strCourseKnowledgeId:string,strCourseId:string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByCourseKnowledgeId_Cache";

if (IsNullOrEmpty(strCourseKnowledgeId) == true)
{
  const strMsg = Format("参数:[strCourseKnowledgeId]不能为空！(In GetObjByCourseKnowledgeId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strCourseKnowledgeId.length != 8)
{
const strMsg = Format("缓存分类变量:[strCourseKnowledgeId]的长度:[{0}]不正确！", strCourseKnowledgeId.length);
console.error(strMsg);
throw (strMsg);
}
const arrcc_CourseKnowledgesObjLst_Cache = await cc_CourseKnowledges_GetObjLst_Cache(strCourseId);
try
{
const arrcc_CourseKnowledges_Sel: Array <clscc_CourseKnowledgesEN> = arrcc_CourseKnowledgesObjLst_Cache.filter(x => x.courseKnowledgeId == strCourseKnowledgeId);
let objcc_CourseKnowledges: clscc_CourseKnowledgesEN;
if (arrcc_CourseKnowledges_Sel.length > 0)
{
objcc_CourseKnowledges = arrcc_CourseKnowledges_Sel[0];
return objcc_CourseKnowledges;
}
else
{
if (bolTryAsyncOnce == true)
{
objcc_CourseKnowledges = await cc_CourseKnowledges_GetObjByCourseKnowledgeIdAsync(strCourseKnowledgeId);
if (objcc_CourseKnowledges != null)
{
cc_CourseKnowledges_ReFreshThisCache(strCourseId);
return objcc_CourseKnowledges;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strCourseKnowledgeId, cc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param strCourseKnowledgeId:所给的关键字
 * @returns 对象
*/
export async function cc_CourseKnowledges_GetObjByCourseKnowledgeId_localStorage(strCourseKnowledgeId: string) {
const strThisFuncName = "GetObjByCourseKnowledgeId_localStorage";

if (IsNullOrEmpty(strCourseKnowledgeId) == true)
{
  const strMsg = Format("参数:[strCourseKnowledgeId]不能为空！(In GetObjByCourseKnowledgeId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
if (strCourseKnowledgeId.length != 8)
{
const strMsg = Format("缓存分类变量:[strCourseKnowledgeId]的长度:[{0}]不正确！", strCourseKnowledgeId.length);
console.error(strMsg);
throw (strMsg);
}
const strKey = Format("{0}_{1}", clscc_CourseKnowledgesEN._CurrTabName, strCourseKnowledgeId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objcc_CourseKnowledges_Cache: clscc_CourseKnowledgesEN = JSON.parse(strTempObj);
return objcc_CourseKnowledges_Cache;
}
try
{
const objcc_CourseKnowledges = await cc_CourseKnowledges_GetObjByCourseKnowledgeIdAsync(strCourseKnowledgeId);
if (objcc_CourseKnowledges != null)
{
localStorage.setItem(strKey, JSON.stringify(objcc_CourseKnowledges));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objcc_CourseKnowledges;
}
return objcc_CourseKnowledges;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strCourseKnowledgeId, cc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objcc_CourseKnowledges:所给的对象
 * @returns 对象
*/
export async function cc_CourseKnowledges_UpdateObjInLst_Cache(objcc_CourseKnowledges: clscc_CourseKnowledgesEN,strCourseId: string) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrcc_CourseKnowledgesObjLst_Cache = await cc_CourseKnowledges_GetObjLst_Cache(strCourseId);
const obj = arrcc_CourseKnowledgesObjLst_Cache.find(x => x.courseId == objcc_CourseKnowledges.courseId && x.knowledgeName == objcc_CourseKnowledges.knowledgeName);
if (obj != null)
{
objcc_CourseKnowledges.courseKnowledgeId = obj.courseKnowledgeId;
ObjectAssign( obj, objcc_CourseKnowledges);
}
else
{
arrcc_CourseKnowledgesObjLst_Cache.push(objcc_CourseKnowledges);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, cc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
}

/**
 * 根据关键字获取相关对象的名称属性, 从缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
 * @param strCourseKnowledgeId:所给的关键字
 * @returns 对象
*/
export async function cc_CourseKnowledges_GetNameByCourseKnowledgeId_Cache(strCourseKnowledgeId: string,strCourseId: string) {
const strThisFuncName = "GetNameByCourseKnowledgeId_Cache";

if (IsNullOrEmpty(strCourseKnowledgeId) == true)
{
  const strMsg = Format("参数:[strCourseKnowledgeId]不能为空！(In GetNameByCourseKnowledgeId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strCourseKnowledgeId.length != 8)
{
const strMsg = Format("缓存分类变量:[strCourseKnowledgeId]的长度:[{0}]不正确！", strCourseKnowledgeId.length);
console.error(strMsg);
throw (strMsg);
}
const arrcc_CourseKnowledgesObjLst_Cache = await cc_CourseKnowledges_GetObjLst_Cache(strCourseId);
if (arrcc_CourseKnowledgesObjLst_Cache == null) return "";
try
{
const arrcc_CourseKnowledges_Sel: Array <clscc_CourseKnowledgesEN> = arrcc_CourseKnowledgesObjLst_Cache.filter(x => x.courseKnowledgeId == strCourseKnowledgeId);
let objcc_CourseKnowledges: clscc_CourseKnowledgesEN;
if (arrcc_CourseKnowledges_Sel.length > 0)
{
objcc_CourseKnowledges = arrcc_CourseKnowledges_Sel[0];
return objcc_CourseKnowledges.knowledgeName;
}
else
{
return "";
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strCourseKnowledgeId);
console.error(strMsg);
alert(strMsg);
}
return "";
}

/**
 * 映射函数。根据表映射把输入字段值，映射成输出字段值
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
 * @param strInFldName:输入字段名
 * @param strOutFldName:输出字段名
 * @param strInValue:输入字段值
 @param strCourseId:缓存的分类字段
 * @returns 返回一个输出字段值
*/
export async function cc_CourseKnowledges_func(strInFldName:string , strOutFldName:string , strInValue:string , strCourseId_C: string)
{
//const strThisFuncName = "func";

if (IsNullOrEmpty(strCourseId_C) == true)
{
  const strMsg = Format("参数:[strCourseId_C]不能为空！(In func)");
console.error(strMsg);
 throw (strMsg);
}
if (strCourseId_C.length != 8)
{
const strMsg = Format("缓存分类变量:[strCourseId_C]的长度:[{0}]不正确！", strCourseId_C.length);
console.error(strMsg);
throw (strMsg);
}

if (strInFldName != clscc_CourseKnowledgesEN.con_CourseKnowledgeId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clscc_CourseKnowledgesEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clscc_CourseKnowledgesEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strCourseKnowledgeId = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objcc_CourseKnowledges = await cc_CourseKnowledges_GetObjByCourseKnowledgeId_Cache(strCourseKnowledgeId , strCourseId_C);
if (objcc_CourseKnowledges == null) return "";
return objcc_CourseKnowledges.GetFldValue(strOutFldName).toString();
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
export function cc_CourseKnowledges_SortFun_Defa(a:clscc_CourseKnowledgesEN , b:clscc_CourseKnowledgesEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.courseKnowledgeId.localeCompare(b.courseKnowledgeId);
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
export function cc_CourseKnowledges_SortFun_Defa_2Fld(a:clscc_CourseKnowledgesEN , b:clscc_CourseKnowledgesEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.knowledgeName == b.knowledgeName) return a.knowledgeTitle.localeCompare(b.knowledgeTitle);
else return a.knowledgeName.localeCompare(b.knowledgeName);
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
export function cc_CourseKnowledges_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clscc_CourseKnowledgesEN.con_CourseKnowledgeId:
return (a: clscc_CourseKnowledgesEN, b: clscc_CourseKnowledgesEN) => {
return a.courseKnowledgeId.localeCompare(b.courseKnowledgeId);
}
case clscc_CourseKnowledgesEN.con_KnowledgeName:
return (a: clscc_CourseKnowledgesEN, b: clscc_CourseKnowledgesEN) => {
return a.knowledgeName.localeCompare(b.knowledgeName);
}
case clscc_CourseKnowledgesEN.con_KnowledgeTitle:
return (a: clscc_CourseKnowledgesEN, b: clscc_CourseKnowledgesEN) => {
return a.knowledgeTitle.localeCompare(b.knowledgeTitle);
}
case clscc_CourseKnowledgesEN.con_KnowledgeContent:
return (a: clscc_CourseKnowledgesEN, b: clscc_CourseKnowledgesEN) => {
return a.knowledgeContent.localeCompare(b.knowledgeContent);
}
case clscc_CourseKnowledgesEN.con_CourseId:
return (a: clscc_CourseKnowledgesEN, b: clscc_CourseKnowledgesEN) => {
return a.courseId.localeCompare(b.courseId);
}
case clscc_CourseKnowledgesEN.con_KnowledgeTypeId:
return (a: clscc_CourseKnowledgesEN, b: clscc_CourseKnowledgesEN) => {
return a.knowledgeTypeId.localeCompare(b.knowledgeTypeId);
}
case clscc_CourseKnowledgesEN.con_CourseChapterId:
return (a: clscc_CourseKnowledgesEN, b: clscc_CourseKnowledgesEN) => {
return a.courseChapterId.localeCompare(b.courseChapterId);
}
case clscc_CourseKnowledgesEN.con_UserId:
return (a: clscc_CourseKnowledgesEN, b: clscc_CourseKnowledgesEN) => {
return a.userId.localeCompare(b.userId);
}
case clscc_CourseKnowledgesEN.con_UploadDate:
return (a: clscc_CourseKnowledgesEN, b: clscc_CourseKnowledgesEN) => {
return a.uploadDate.localeCompare(b.uploadDate);
}
case clscc_CourseKnowledgesEN.con_IsShow:
return (a: clscc_CourseKnowledgesEN, b: clscc_CourseKnowledgesEN) => {
if (a.isShow == true) return 1;
else return -1
}
case clscc_CourseKnowledgesEN.con_IsCast:
return (a: clscc_CourseKnowledgesEN, b: clscc_CourseKnowledgesEN) => {
if (a.isCast == true) return 1;
else return -1
}
case clscc_CourseKnowledgesEN.con_LikeCount:
return (a: clscc_CourseKnowledgesEN, b: clscc_CourseKnowledgesEN) => {
return a.likeCount-b.likeCount;
}
case clscc_CourseKnowledgesEN.con_OrderNum:
return (a: clscc_CourseKnowledgesEN, b: clscc_CourseKnowledgesEN) => {
return a.orderNum-b.orderNum;
}
case clscc_CourseKnowledgesEN.con_UpdDate:
return (a: clscc_CourseKnowledgesEN, b: clscc_CourseKnowledgesEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clscc_CourseKnowledgesEN.con_UpdUser:
return (a: clscc_CourseKnowledgesEN, b: clscc_CourseKnowledgesEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clscc_CourseKnowledgesEN.con_Memo:
return (a: clscc_CourseKnowledgesEN, b: clscc_CourseKnowledgesEN) => {
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[cc_CourseKnowledges]中不存在！(in ${ cc_CourseKnowledges_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clscc_CourseKnowledgesEN.con_CourseKnowledgeId:
return (a: clscc_CourseKnowledgesEN, b: clscc_CourseKnowledgesEN) => {
return b.courseKnowledgeId.localeCompare(a.courseKnowledgeId);
}
case clscc_CourseKnowledgesEN.con_KnowledgeName:
return (a: clscc_CourseKnowledgesEN, b: clscc_CourseKnowledgesEN) => {
return b.knowledgeName.localeCompare(a.knowledgeName);
}
case clscc_CourseKnowledgesEN.con_KnowledgeTitle:
return (a: clscc_CourseKnowledgesEN, b: clscc_CourseKnowledgesEN) => {
return b.knowledgeTitle.localeCompare(a.knowledgeTitle);
}
case clscc_CourseKnowledgesEN.con_KnowledgeContent:
return (a: clscc_CourseKnowledgesEN, b: clscc_CourseKnowledgesEN) => {
return b.knowledgeContent.localeCompare(a.knowledgeContent);
}
case clscc_CourseKnowledgesEN.con_CourseId:
return (a: clscc_CourseKnowledgesEN, b: clscc_CourseKnowledgesEN) => {
return b.courseId.localeCompare(a.courseId);
}
case clscc_CourseKnowledgesEN.con_KnowledgeTypeId:
return (a: clscc_CourseKnowledgesEN, b: clscc_CourseKnowledgesEN) => {
return b.knowledgeTypeId.localeCompare(a.knowledgeTypeId);
}
case clscc_CourseKnowledgesEN.con_CourseChapterId:
return (a: clscc_CourseKnowledgesEN, b: clscc_CourseKnowledgesEN) => {
return b.courseChapterId.localeCompare(a.courseChapterId);
}
case clscc_CourseKnowledgesEN.con_UserId:
return (a: clscc_CourseKnowledgesEN, b: clscc_CourseKnowledgesEN) => {
return b.userId.localeCompare(a.userId);
}
case clscc_CourseKnowledgesEN.con_UploadDate:
return (a: clscc_CourseKnowledgesEN, b: clscc_CourseKnowledgesEN) => {
return b.uploadDate.localeCompare(a.uploadDate);
}
case clscc_CourseKnowledgesEN.con_IsShow:
return (a: clscc_CourseKnowledgesEN, b: clscc_CourseKnowledgesEN) => {
if (b.isShow == true) return 1;
else return -1
}
case clscc_CourseKnowledgesEN.con_IsCast:
return (a: clscc_CourseKnowledgesEN, b: clscc_CourseKnowledgesEN) => {
if (b.isCast == true) return 1;
else return -1
}
case clscc_CourseKnowledgesEN.con_LikeCount:
return (a: clscc_CourseKnowledgesEN, b: clscc_CourseKnowledgesEN) => {
return b.likeCount-a.likeCount;
}
case clscc_CourseKnowledgesEN.con_OrderNum:
return (a: clscc_CourseKnowledgesEN, b: clscc_CourseKnowledgesEN) => {
return b.orderNum-a.orderNum;
}
case clscc_CourseKnowledgesEN.con_UpdDate:
return (a: clscc_CourseKnowledgesEN, b: clscc_CourseKnowledgesEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clscc_CourseKnowledgesEN.con_UpdUser:
return (a: clscc_CourseKnowledgesEN, b: clscc_CourseKnowledgesEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clscc_CourseKnowledgesEN.con_Memo:
return (a: clscc_CourseKnowledgesEN, b: clscc_CourseKnowledgesEN) => {
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[cc_CourseKnowledges]中不存在！(in ${ cc_CourseKnowledges_ConstructorName}.${ strThisFuncName})`;
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
export async function cc_CourseKnowledges_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clscc_CourseKnowledgesEN.con_CourseKnowledgeId:
return (obj: clscc_CourseKnowledgesEN) => {
return obj.courseKnowledgeId === value;
}
case clscc_CourseKnowledgesEN.con_KnowledgeName:
return (obj: clscc_CourseKnowledgesEN) => {
return obj.knowledgeName === value;
}
case clscc_CourseKnowledgesEN.con_KnowledgeTitle:
return (obj: clscc_CourseKnowledgesEN) => {
return obj.knowledgeTitle === value;
}
case clscc_CourseKnowledgesEN.con_KnowledgeContent:
return (obj: clscc_CourseKnowledgesEN) => {
return obj.knowledgeContent === value;
}
case clscc_CourseKnowledgesEN.con_CourseId:
return (obj: clscc_CourseKnowledgesEN) => {
return obj.courseId === value;
}
case clscc_CourseKnowledgesEN.con_KnowledgeTypeId:
return (obj: clscc_CourseKnowledgesEN) => {
return obj.knowledgeTypeId === value;
}
case clscc_CourseKnowledgesEN.con_CourseChapterId:
return (obj: clscc_CourseKnowledgesEN) => {
return obj.courseChapterId === value;
}
case clscc_CourseKnowledgesEN.con_UserId:
return (obj: clscc_CourseKnowledgesEN) => {
return obj.userId === value;
}
case clscc_CourseKnowledgesEN.con_UploadDate:
return (obj: clscc_CourseKnowledgesEN) => {
return obj.uploadDate === value;
}
case clscc_CourseKnowledgesEN.con_IsShow:
return (obj: clscc_CourseKnowledgesEN) => {
return obj.isShow === value;
}
case clscc_CourseKnowledgesEN.con_IsCast:
return (obj: clscc_CourseKnowledgesEN) => {
return obj.isCast === value;
}
case clscc_CourseKnowledgesEN.con_LikeCount:
return (obj: clscc_CourseKnowledgesEN) => {
return obj.likeCount === value;
}
case clscc_CourseKnowledgesEN.con_OrderNum:
return (obj: clscc_CourseKnowledgesEN) => {
return obj.orderNum === value;
}
case clscc_CourseKnowledgesEN.con_UpdDate:
return (obj: clscc_CourseKnowledgesEN) => {
return obj.updDate === value;
}
case clscc_CourseKnowledgesEN.con_UpdUser:
return (obj: clscc_CourseKnowledgesEN) => {
return obj.updUser === value;
}
case clscc_CourseKnowledgesEN.con_Memo:
return (obj: clscc_CourseKnowledgesEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[cc_CourseKnowledges]中不存在！(in ${ cc_CourseKnowledges_ConstructorName}.${ strThisFuncName})`;
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
export async function cc_CourseKnowledges_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(cc_CourseKnowledges_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_CourseKnowledges_ConstructorName, strThisFuncName);
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
export async function cc_CourseKnowledges_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(cc_CourseKnowledges_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_CourseKnowledges_ConstructorName, strThisFuncName);
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
export async function cc_CourseKnowledges_GetFirstObjAsync(strWhereCond: string): Promise<clscc_CourseKnowledgesEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(cc_CourseKnowledges_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", cc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objcc_CourseKnowledges = cc_CourseKnowledges_GetObjFromJsonObj(returnObj);
return objcc_CourseKnowledges;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_CourseKnowledges_ConstructorName, strThisFuncName);
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
export async function cc_CourseKnowledges_GetObjLst_ClientCache(strCourseId: string)
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("CourseId='{0}'", strCourseId);
const strKey = Format("{0}_{1}", clscc_CourseKnowledgesEN._CurrTabName, strCourseId);
clscc_CourseKnowledgesEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clscc_CourseKnowledgesEN._CurrTabName);
if (IsNullOrEmpty(clscc_CourseKnowledgesEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clscc_CourseKnowledgesEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrcc_CourseKnowledgesExObjLst_Cache: Array<clscc_CourseKnowledgesEN> = CacheHelper.Get(strKey);
const arrcc_CourseKnowledgesObjLst_T = cc_CourseKnowledges_GetObjLstByJSONObjLst(arrcc_CourseKnowledgesExObjLst_Cache);
return arrcc_CourseKnowledgesObjLst_T;
}
try
{
const arrcc_CourseKnowledgesExObjLst = await cc_CourseKnowledges_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrcc_CourseKnowledgesExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrcc_CourseKnowledgesExObjLst.length);
console.log(strInfo);
return arrcc_CourseKnowledgesExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, cc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function cc_CourseKnowledges_GetObjLst_localStorage(strCourseId: string)
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("CourseId='{0}'", strCourseId);
const strKey = Format("{0}_{1}", clscc_CourseKnowledgesEN._CurrTabName, strCourseId);
clscc_CourseKnowledgesEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clscc_CourseKnowledgesEN._CurrTabName);
if (IsNullOrEmpty(clscc_CourseKnowledgesEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clscc_CourseKnowledgesEN.CacheAddiCondition);
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
const arrcc_CourseKnowledgesExObjLst_Cache: Array<clscc_CourseKnowledgesEN> = JSON.parse(strTempObjLst);
const arrcc_CourseKnowledgesObjLst_T = cc_CourseKnowledges_GetObjLstByJSONObjLst(arrcc_CourseKnowledgesExObjLst_Cache);
return arrcc_CourseKnowledgesObjLst_T;
}
try
{
const arrcc_CourseKnowledgesExObjLst = await cc_CourseKnowledges_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrcc_CourseKnowledgesExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrcc_CourseKnowledgesExObjLst.length);
console.log(strInfo);
return arrcc_CourseKnowledgesExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, cc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function cc_CourseKnowledges_GetObjLst_localStorage_PureCache(strCourseId: string)
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("CourseId='{0}'", strCourseId);
const strKey = Format("{0}_{1}", clscc_CourseKnowledgesEN._CurrTabName, strCourseId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrcc_CourseKnowledgesObjLst_Cache: Array<clscc_CourseKnowledgesEN> = JSON.parse(strTempObjLst);
return arrcc_CourseKnowledgesObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function cc_CourseKnowledges_GetObjLstAsync(strWhereCond: string): Promise<Array<clscc_CourseKnowledgesEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(cc_CourseKnowledges_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", cc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = cc_CourseKnowledges_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_CourseKnowledges_ConstructorName, strThisFuncName);
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
export async function cc_CourseKnowledges_GetObjLst_sessionStorage(strCourseId: string)
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("CourseId='{0}'", strCourseId);
const strKey = Format("{0}_{1}", clscc_CourseKnowledgesEN._CurrTabName, strCourseId);
clscc_CourseKnowledgesEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clscc_CourseKnowledgesEN._CurrTabName);
if (IsNullOrEmpty(clscc_CourseKnowledgesEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clscc_CourseKnowledgesEN.CacheAddiCondition);
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
const arrcc_CourseKnowledgesExObjLst_Cache: Array<clscc_CourseKnowledgesEN> = JSON.parse(strTempObjLst);
const arrcc_CourseKnowledgesObjLst_T = cc_CourseKnowledges_GetObjLstByJSONObjLst(arrcc_CourseKnowledgesExObjLst_Cache);
return arrcc_CourseKnowledgesObjLst_T;
}
try
{
const arrcc_CourseKnowledgesExObjLst = await cc_CourseKnowledges_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrcc_CourseKnowledgesExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrcc_CourseKnowledgesExObjLst.length);
console.log(strInfo);
return arrcc_CourseKnowledgesExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, cc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function cc_CourseKnowledges_GetObjLst_sessionStorage_PureCache(strCourseId: string)
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("CourseId='{0}'", strCourseId);
const strKey = Format("{0}_{1}", clscc_CourseKnowledgesEN._CurrTabName, strCourseId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrcc_CourseKnowledgesObjLst_Cache: Array<clscc_CourseKnowledgesEN> = JSON.parse(strTempObjLst);
return arrcc_CourseKnowledgesObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function cc_CourseKnowledges_GetObjLst_Cache(strCourseId: string): Promise<Array<clscc_CourseKnowledgesEN>>
{
//const strThisFuncName = "GetObjLst_Cache";

if (IsNullOrEmpty(strCourseId) == true)
{
const strMsg = Format("缓存分类变量:[CourseId]不能为空！");
console.error(strMsg);
throw (strMsg);
}
if (strCourseId.length != 8)
{
const strMsg = Format("缓存分类变量:[strCourseId]的长度:[{0}]不正确！", strCourseId.length);
console.error(strMsg);
throw (strMsg);
}
let arrcc_CourseKnowledgesObjLst_Cache;
switch (clscc_CourseKnowledgesEN.CacheModeId)
{
case "04"://sessionStorage
arrcc_CourseKnowledgesObjLst_Cache = await cc_CourseKnowledges_GetObjLst_sessionStorage(strCourseId);
break;
case "03"://localStorage
arrcc_CourseKnowledgesObjLst_Cache = await cc_CourseKnowledges_GetObjLst_localStorage(strCourseId);
break;
case "02"://ClientCache
arrcc_CourseKnowledgesObjLst_Cache = await cc_CourseKnowledges_GetObjLst_ClientCache(strCourseId);
break;
default:
arrcc_CourseKnowledgesObjLst_Cache = await cc_CourseKnowledges_GetObjLst_ClientCache(strCourseId);
break;
}
const arrcc_CourseKnowledgesObjLst = cc_CourseKnowledges_GetObjLstByJSONObjLst(arrcc_CourseKnowledgesObjLst_Cache);
return arrcc_CourseKnowledgesObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function cc_CourseKnowledges_GetObjLst_PureCache(strCourseId: string)
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrcc_CourseKnowledgesObjLst_Cache;
switch (clscc_CourseKnowledgesEN.CacheModeId)
{
case "04"://sessionStorage
arrcc_CourseKnowledgesObjLst_Cache = await cc_CourseKnowledges_GetObjLst_sessionStorage_PureCache(strCourseId);
break;
case "03"://localStorage
arrcc_CourseKnowledgesObjLst_Cache = await cc_CourseKnowledges_GetObjLst_localStorage_PureCache(strCourseId);
break;
case "02"://ClientCache
arrcc_CourseKnowledgesObjLst_Cache = null;
break;
default:
arrcc_CourseKnowledgesObjLst_Cache = null;
break;
}
return arrcc_CourseKnowledgesObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrCourseKnowledgeId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function cc_CourseKnowledges_GetSubObjLst_Cache(objcc_CourseKnowledges_Cond: clscc_CourseKnowledgesEN,strCourseId: string) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrcc_CourseKnowledgesObjLst_Cache = await cc_CourseKnowledges_GetObjLst_Cache(strCourseId);
let arrcc_CourseKnowledges_Sel: Array < clscc_CourseKnowledgesEN > = arrcc_CourseKnowledgesObjLst_Cache;
if (objcc_CourseKnowledges_Cond.sf_FldComparisonOp == null || objcc_CourseKnowledges_Cond.sf_FldComparisonOp == "") return arrcc_CourseKnowledges_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objcc_CourseKnowledges_Cond.sf_FldComparisonOp);
//console.log("clscc_CourseKnowledgesWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objcc_CourseKnowledges_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrcc_CourseKnowledges_Sel = arrcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objcc_CourseKnowledges_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrcc_CourseKnowledges_Sel = arrcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrcc_CourseKnowledges_Sel = arrcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrcc_CourseKnowledges_Sel = arrcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrcc_CourseKnowledges_Sel = arrcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrcc_CourseKnowledges_Sel = arrcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrcc_CourseKnowledges_Sel = arrcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrcc_CourseKnowledges_Sel = arrcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrcc_CourseKnowledges_Sel = arrcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrcc_CourseKnowledges_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objcc_CourseKnowledges_Cond), cc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clscc_CourseKnowledgesEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrCourseKnowledgeId:关键字列表
 * @returns 对象列表
 **/
export async function cc_CourseKnowledges_GetObjLstByCourseKnowledgeIdLstAsync(arrCourseKnowledgeId: Array<string>): Promise<Array<clscc_CourseKnowledgesEN>>  
{
const strThisFuncName = "GetObjLstByCourseKnowledgeIdLstAsync";
const strAction = "GetObjLstByCourseKnowledgeIdLst";
const strUrl = GetWebApiUrl(cc_CourseKnowledges_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrCourseKnowledgeId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", cc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = cc_CourseKnowledges_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_CourseKnowledges_ConstructorName, strThisFuncName);
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
 * @param arrstrCourseKnowledgeIdLst:关键字列表
 * @returns 对象列表
*/
export async function cc_CourseKnowledges_GetObjLstByCourseKnowledgeIdLst_Cache(arrCourseKnowledgeIdLst: Array<string>,strCourseId: string) {
const strThisFuncName = "GetObjLstByCourseKnowledgeIdLst_Cache";
try
{
const arrcc_CourseKnowledgesObjLst_Cache = await cc_CourseKnowledges_GetObjLst_Cache(strCourseId);
const arrcc_CourseKnowledges_Sel: Array <clscc_CourseKnowledgesEN> = arrcc_CourseKnowledgesObjLst_Cache.filter(x => arrCourseKnowledgeIdLst.indexOf(x.courseKnowledgeId)>-1);
return arrcc_CourseKnowledges_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrCourseKnowledgeIdLst.join(","), cc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clscc_CourseKnowledgesEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function cc_CourseKnowledges_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clscc_CourseKnowledgesEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(cc_CourseKnowledges_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", cc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = cc_CourseKnowledges_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_CourseKnowledges_ConstructorName, strThisFuncName);
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
export async function cc_CourseKnowledges_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clscc_CourseKnowledgesEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(cc_CourseKnowledges_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", cc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = cc_CourseKnowledges_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_CourseKnowledges_ConstructorName, strThisFuncName);
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
export async function cc_CourseKnowledges_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(cc_CourseKnowledges_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_CourseKnowledges_ConstructorName, strThisFuncName);
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
export async function cc_CourseKnowledges_GetObjLstByPager_Cache(objPagerPara: stuPagerPara,strCourseId: string) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrcc_CourseKnowledgesObjLst_Cache = await cc_CourseKnowledges_GetObjLst_Cache(strCourseId);
if (arrcc_CourseKnowledgesObjLst_Cache.length == 0) return arrcc_CourseKnowledgesObjLst_Cache;
let arrcc_CourseKnowledges_Sel = arrcc_CourseKnowledgesObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objcc_CourseKnowledges_Cond = new clscc_CourseKnowledgesEN();
ObjectAssign(objcc_CourseKnowledges_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clscc_CourseKnowledgesWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrcc_CourseKnowledges_Sel = arrcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objcc_CourseKnowledges_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrcc_CourseKnowledges_Sel = arrcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrcc_CourseKnowledges_Sel = arrcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrcc_CourseKnowledges_Sel = arrcc_CourseKnowledges_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrcc_CourseKnowledges_Sel = arrcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrcc_CourseKnowledges_Sel = arrcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrcc_CourseKnowledges_Sel = arrcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrcc_CourseKnowledges_Sel = arrcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrcc_CourseKnowledges_Sel = arrcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrcc_CourseKnowledges_Sel = arrcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrcc_CourseKnowledges_Sel.length == 0) return arrcc_CourseKnowledges_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrcc_CourseKnowledges_Sel = arrcc_CourseKnowledges_Sel.sort(cc_CourseKnowledges_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrcc_CourseKnowledges_Sel = arrcc_CourseKnowledges_Sel.sort(objPagerPara.sortFun);
}
arrcc_CourseKnowledges_Sel = arrcc_CourseKnowledges_Sel.slice(intStart, intEnd);     
return arrcc_CourseKnowledges_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, cc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clscc_CourseKnowledgesEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function cc_CourseKnowledges_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clscc_CourseKnowledgesEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(cc_CourseKnowledges_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", cc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = cc_CourseKnowledges_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_CourseKnowledges_ConstructorName, strThisFuncName);
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
 * @param strCourseKnowledgeId:关键字
 * @returns 获取删除的结果
 **/
export async function cc_CourseKnowledges_DelRecordAsync(strCourseKnowledgeId: string): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(cc_CourseKnowledges_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, strCourseKnowledgeId);
try
{
const response = await axios.delete(strUrl,
{
params: { "Id": strCourseKnowledgeId, }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_CourseKnowledges_ConstructorName, strThisFuncName);
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
 * @param arrCourseKnowledgeId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function cc_CourseKnowledges_Delcc_CourseKnowledgessAsync(arrCourseKnowledgeId: Array<string>): Promise<number> 
{
const strThisFuncName = "Delcc_CourseKnowledgessAsync";
const strAction = "Delcc_CourseKnowledgess";
const strUrl = GetWebApiUrl(cc_CourseKnowledges_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrCourseKnowledgeId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_CourseKnowledges_ConstructorName, strThisFuncName);
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
export async function cc_CourseKnowledges_Delcc_CourseKnowledgessByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "Delcc_CourseKnowledgessByCondAsync";
const strAction = "Delcc_CourseKnowledgessByCond";
const strUrl = GetWebApiUrl(cc_CourseKnowledges_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_CourseKnowledges_ConstructorName, strThisFuncName);
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
 * @param objcc_CourseKnowledgesEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function cc_CourseKnowledges_AddNewRecordAsync(objcc_CourseKnowledgesEN: clscc_CourseKnowledgesEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objcc_CourseKnowledgesEN);
const strUrl = GetWebApiUrl(cc_CourseKnowledges_Controller, strAction);
try
{
const response = await axios.post(strUrl, objcc_CourseKnowledgesEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_CourseKnowledges_ConstructorName, strThisFuncName);
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
 * @param objcc_CourseKnowledgesEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function cc_CourseKnowledges_AddNewRecordWithMaxIdAsync(objcc_CourseKnowledgesEN: clscc_CourseKnowledgesEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithMaxIdAsync";
const strAction = "AddNewRecordWithMaxId";
const strUrl = GetWebApiUrl(cc_CourseKnowledges_Controller, strAction);
try
{
const response = await axios.post(strUrl, objcc_CourseKnowledgesEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_CourseKnowledges_ConstructorName, strThisFuncName);
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
 * @param objcc_CourseKnowledgesEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function cc_CourseKnowledges_GoTopAsync(objOrderByData: clsOrderByData): Promise<boolean> 
{
const strThisFuncName = "GoTopAsync";
let strMsg = "";
const strAction = "GoTop";
if (objOrderByData.KeyIdLst.length == 0)
{
strMsg = "根据关键字列表置顶时，给定的关键字值列表不能为空!";
throw strMsg;
}
const strUrl = GetWebApiUrl(cc_CourseKnowledges_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_CourseKnowledges_ConstructorName, strThisFuncName);
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
 * @param objcc_CourseKnowledgesEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function cc_CourseKnowledges_UpMoveAsync(objOrderByData: clsOrderByData): Promise<boolean> 
{
const strThisFuncName = "UpMoveAsync";
let strMsg = "";
const strAction = "UpMove";
if (objOrderByData.KeyIdLst.length == 0)
{
strMsg = "根据关键字列表上移时，给定的关键字值列表不能为空!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objcc_CourseKnowledgesEN);
const strUrl = GetWebApiUrl(cc_CourseKnowledges_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_CourseKnowledges_ConstructorName, strThisFuncName);
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
 * @param objcc_CourseKnowledgesEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function cc_CourseKnowledges_DownMoveAsync(objOrderByData: clsOrderByData): Promise<boolean> 
{
const strThisFuncName = "DownMoveAsync";
let strMsg = "";
const strAction = "DownMove";
if (objOrderByData.KeyIdLst.length == 0)
{
strMsg = "根据关键字列表下移时，给定的关键字值列表不能为空!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objcc_CourseKnowledgesEN);
const strUrl = GetWebApiUrl(cc_CourseKnowledges_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_CourseKnowledges_ConstructorName, strThisFuncName);
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
 * @param objcc_CourseKnowledgesEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function cc_CourseKnowledges_GoBottomAsync(objOrderByData: clsOrderByData): Promise<boolean> 
{
const strThisFuncName = "GoBottomAsync";
let strMsg = "";
const strAction = "GoBottom";
if (objOrderByData.KeyIdLst.length == 0)
{
strMsg = "根据关键字列表置底时，给定的关键字值列表不能为空!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objcc_CourseKnowledgesEN);
const strUrl = GetWebApiUrl(cc_CourseKnowledges_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_CourseKnowledges_ConstructorName, strThisFuncName);
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
 * @param objcc_CourseKnowledgesEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function cc_CourseKnowledges_ReOrderAsync(objOrderByData: clsOrderByData): Promise<boolean> 
{
const strThisFuncName = "ReOrderAsync";
const strAction = "ReOrder";
 //var strJSON = JSON.stringify(objcc_CourseKnowledgesEN);
const strUrl = GetWebApiUrl(cc_CourseKnowledges_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_CourseKnowledges_ConstructorName, strThisFuncName);
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
 * @param objcc_CourseKnowledgesEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function cc_CourseKnowledges_AddNewRecordWithReturnKeyAsync(objcc_CourseKnowledgesEN: clscc_CourseKnowledgesEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(cc_CourseKnowledges_Controller, strAction);
try
{
const response = await axios.post(strUrl, objcc_CourseKnowledgesEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_CourseKnowledges_ConstructorName, strThisFuncName);
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
 * @param objcc_CourseKnowledgesEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function cc_CourseKnowledges_AddNewRecordWithReturnKey(objcc_CourseKnowledgesEN: clscc_CourseKnowledgesEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objcc_CourseKnowledgesEN.courseKnowledgeId === null || objcc_CourseKnowledgesEN.courseKnowledgeId === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(cc_CourseKnowledges_Controller, strAction);
try
{
const response = await axios.post(strUrl, objcc_CourseKnowledgesEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_CourseKnowledges_ConstructorName, strThisFuncName);
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
 * @param objcc_CourseKnowledgesEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function cc_CourseKnowledges_UpdateRecordAsync(objcc_CourseKnowledgesEN: clscc_CourseKnowledgesEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objcc_CourseKnowledgesEN.sf_UpdFldSetStr === undefined || objcc_CourseKnowledgesEN.sf_UpdFldSetStr === null || objcc_CourseKnowledgesEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objcc_CourseKnowledgesEN.courseKnowledgeId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(cc_CourseKnowledges_Controller, strAction);
try
{
const response = await axios.post(strUrl, objcc_CourseKnowledgesEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_CourseKnowledges_ConstructorName, strThisFuncName);
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
 * @param objcc_CourseKnowledgesEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function cc_CourseKnowledges_UpdateWithConditionAsync(objcc_CourseKnowledgesEN: clscc_CourseKnowledgesEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objcc_CourseKnowledgesEN.sf_UpdFldSetStr === undefined || objcc_CourseKnowledgesEN.sf_UpdFldSetStr === null || objcc_CourseKnowledgesEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objcc_CourseKnowledgesEN.courseKnowledgeId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(cc_CourseKnowledges_Controller, strAction);
objcc_CourseKnowledgesEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objcc_CourseKnowledgesEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_CourseKnowledges_ConstructorName, strThisFuncName);
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
 * @param objstrCourseKnowledgeId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function cc_CourseKnowledges_IsExistRecord_Cache(objcc_CourseKnowledges_Cond: clscc_CourseKnowledgesEN,strCourseId: string) {
const strThisFuncName = "IsExistRecord_Cache";
const arrcc_CourseKnowledgesObjLst_Cache = await cc_CourseKnowledges_GetObjLst_Cache(strCourseId);
if (arrcc_CourseKnowledgesObjLst_Cache == null) return false;
let arrcc_CourseKnowledges_Sel: Array < clscc_CourseKnowledgesEN > = arrcc_CourseKnowledgesObjLst_Cache;
if (objcc_CourseKnowledges_Cond.sf_FldComparisonOp == null || objcc_CourseKnowledges_Cond.sf_FldComparisonOp == "") return arrcc_CourseKnowledges_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objcc_CourseKnowledges_Cond.sf_FldComparisonOp);
//console.log("clscc_CourseKnowledgesWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objcc_CourseKnowledges_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objcc_CourseKnowledges_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrcc_CourseKnowledges_Sel = arrcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrcc_CourseKnowledges_Sel = arrcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrcc_CourseKnowledges_Sel = arrcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrcc_CourseKnowledges_Sel = arrcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrcc_CourseKnowledges_Sel = arrcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrcc_CourseKnowledges_Sel = arrcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrcc_CourseKnowledges_Sel = arrcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrcc_CourseKnowledges_Sel = arrcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrcc_CourseKnowledges_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objcc_CourseKnowledges_Cond), cc_CourseKnowledges_ConstructorName, strThisFuncName);
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
export async function cc_CourseKnowledges_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(cc_CourseKnowledges_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_CourseKnowledges_ConstructorName, strThisFuncName);
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
 * @param strCourseKnowledgeId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function cc_CourseKnowledges_IsExist(strCourseKnowledgeId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(cc_CourseKnowledges_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"CourseKnowledgeId": strCourseKnowledgeId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_CourseKnowledges_ConstructorName, strThisFuncName);
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
 * @param strCourseKnowledgeId:所给的关键字
 * @returns 对象
*/
export async function cc_CourseKnowledges_IsExist_Cache(strCourseKnowledgeId:string,strCourseId:string) {
const strThisFuncName = "IsExist_Cache";
const arrcc_CourseKnowledgesObjLst_Cache = await cc_CourseKnowledges_GetObjLst_Cache(strCourseId);
if (arrcc_CourseKnowledgesObjLst_Cache == null) return false;
try
{
const arrcc_CourseKnowledges_Sel: Array <clscc_CourseKnowledgesEN> = arrcc_CourseKnowledgesObjLst_Cache.filter(x => x.courseKnowledgeId == strCourseKnowledgeId);
if (arrcc_CourseKnowledges_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strCourseKnowledgeId, cc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param strCourseKnowledgeId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function cc_CourseKnowledges_IsExistAsync(strCourseKnowledgeId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(cc_CourseKnowledges_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strCourseKnowledgeId": strCourseKnowledgeId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_CourseKnowledges_ConstructorName, strThisFuncName);
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
export async function cc_CourseKnowledges_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(cc_CourseKnowledges_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_CourseKnowledges_ConstructorName, strThisFuncName);
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
 * @param objcc_CourseKnowledges_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function cc_CourseKnowledges_GetRecCountByCond_Cache(objcc_CourseKnowledges_Cond: clscc_CourseKnowledgesEN,strCourseId: string) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrcc_CourseKnowledgesObjLst_Cache = await cc_CourseKnowledges_GetObjLst_Cache(strCourseId);
if (arrcc_CourseKnowledgesObjLst_Cache == null) return 0;
let arrcc_CourseKnowledges_Sel: Array < clscc_CourseKnowledgesEN > = arrcc_CourseKnowledgesObjLst_Cache;
if (objcc_CourseKnowledges_Cond.sf_FldComparisonOp == null || objcc_CourseKnowledges_Cond.sf_FldComparisonOp == "") return arrcc_CourseKnowledges_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objcc_CourseKnowledges_Cond.sf_FldComparisonOp);
//console.log("clscc_CourseKnowledgesWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objcc_CourseKnowledges_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrcc_CourseKnowledges_Sel = arrcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objcc_CourseKnowledges_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrcc_CourseKnowledges_Sel = arrcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrcc_CourseKnowledges_Sel = arrcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrcc_CourseKnowledges_Sel = arrcc_CourseKnowledges_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrcc_CourseKnowledges_Sel = arrcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrcc_CourseKnowledges_Sel = arrcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrcc_CourseKnowledges_Sel = arrcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrcc_CourseKnowledges_Sel = arrcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrcc_CourseKnowledges_Sel = arrcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrcc_CourseKnowledges_Sel = arrcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrcc_CourseKnowledges_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objcc_CourseKnowledges_Cond), cc_CourseKnowledges_ConstructorName, strThisFuncName);
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
export async function cc_CourseKnowledges_GetMaxStrIdAsync(): Promise<string>  
{
const strThisFuncName = "GetMaxStrIdAsync";
const strAction = "GetMaxStrId";
const strUrl = GetWebApiUrl(cc_CourseKnowledges_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_CourseKnowledges_ConstructorName, strThisFuncName);
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
export async function cc_CourseKnowledges_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(cc_CourseKnowledges_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_CourseKnowledges_ConstructorName, strThisFuncName);
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
export function cc_CourseKnowledges_GetWebApiUrl(strController: string, strAction: string): string {
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
export function cc_CourseKnowledges_ReFreshCache(strCourseId: string):void
{
const strThisFuncName = "ReFreshCache";

if (IsNullOrEmpty(strCourseId) == true)
{
  const strMsg = Format("参数:[strCourseId]不能为空！(In clscc_CourseKnowledgesWApi.ReFreshCache)");
console.error(strMsg);
 throw (strMsg);
}
if (strCourseId.length != 8)
{
const strMsg = Format("缓存分类变量:[strCourseId]的长度:[{0}]不正确！", strCourseId.length);
console.error(strMsg);
throw (strMsg);
}

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = Format("{0}_{1}", clscc_CourseKnowledgesEN._CurrTabName, strCourseId);
switch (clscc_CourseKnowledgesEN.CacheModeId)
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
export function cc_CourseKnowledges_ReFreshThisCache(strCourseId: string):void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = Format("{0}_{1}", clscc_CourseKnowledgesEN._CurrTabName, strCourseId);
switch (clscc_CourseKnowledgesEN.CacheModeId)
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
export async function cc_CourseKnowledges__Cache(strDivName: string, strDdlName: string , strCourseId: string)
{
const strThisFuncName = "_Cache";

if (IsNullOrEmpty(strCourseId) == true)
{
  const strMsg = Format("参数:[strCourseId]不能为空！(In )");
console.error(strMsg);
 throw (strMsg);
}
if (strCourseId.length != 8)
{
const strMsg = Format("缓存分类变量:[strCourseId]的长度:[{0}]不正确！", strCourseId.length);
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
const arrObjLst_Sel = await cc_CourseKnowledges_GetObjLst_Cache(strCourseId);
if (arrObjLst_Sel == null) return;
BindDdl_ObjLstInDiv(strDivName, strDdlName, arrObjLst_Sel, clscc_CourseKnowledgesEN.con_CourseKnowledgeId, clscc_CourseKnowledgesEN.con_KnowledgeName, "知识点");
}

/**
 * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function cc_CourseKnowledges_CheckPropertyNew(pobjcc_CourseKnowledgesEN: clscc_CourseKnowledgesEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjcc_CourseKnowledgesEN.knowledgeName) === true )
{
 throw new Error("(errid:Watl000058)字段[知识点名称]不能为空(In 知识点)!(clscc_CourseKnowledgesBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_CourseKnowledgesEN.courseId) === true 
 || pobjcc_CourseKnowledgesEN.courseId.toString()  ===  "0" )
{
 throw new Error("(errid:Watl000058)字段[课程Id]不能为空(In 知识点)!(clscc_CourseKnowledgesBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_CourseKnowledgesEN.courseChapterId) === true 
 || pobjcc_CourseKnowledgesEN.courseChapterId.toString()  ===  "0" )
{
 throw new Error("(errid:Watl000058)字段[课程章节ID]不能为空(In 知识点)!(clscc_CourseKnowledgesBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_CourseKnowledgesEN.userId) === true )
{
 throw new Error("(errid:Watl000058)字段[用户ID]不能为空(In 知识点)!(clscc_CourseKnowledgesBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjcc_CourseKnowledgesEN.courseKnowledgeId) == false && GetStrLen(pobjcc_CourseKnowledgesEN.courseKnowledgeId) > 8)
{
 throw new Error("(errid:Watl000059)字段[知识点Id(courseKnowledgeId)]的长度不能超过8(In 知识点(cc_CourseKnowledges))!值:$(pobjcc_CourseKnowledgesEN.courseKnowledgeId)(clscc_CourseKnowledgesBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_CourseKnowledgesEN.knowledgeName) == false && GetStrLen(pobjcc_CourseKnowledgesEN.knowledgeName) > 100)
{
 throw new Error("(errid:Watl000059)字段[知识点名称(knowledgeName)]的长度不能超过100(In 知识点(cc_CourseKnowledges))!值:$(pobjcc_CourseKnowledgesEN.knowledgeName)(clscc_CourseKnowledgesBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_CourseKnowledgesEN.knowledgeTitle) == false && GetStrLen(pobjcc_CourseKnowledgesEN.knowledgeTitle) > 100)
{
 throw new Error("(errid:Watl000059)字段[知识点标题(knowledgeTitle)]的长度不能超过100(In 知识点(cc_CourseKnowledges))!值:$(pobjcc_CourseKnowledgesEN.knowledgeTitle)(clscc_CourseKnowledgesBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_CourseKnowledgesEN.courseId) == false && GetStrLen(pobjcc_CourseKnowledgesEN.courseId) > 8)
{
 throw new Error("(errid:Watl000059)字段[课程Id(courseId)]的长度不能超过8(In 知识点(cc_CourseKnowledges))!值:$(pobjcc_CourseKnowledgesEN.courseId)(clscc_CourseKnowledgesBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_CourseKnowledgesEN.knowledgeTypeId) == false && GetStrLen(pobjcc_CourseKnowledgesEN.knowledgeTypeId) > 4)
{
 throw new Error("(errid:Watl000059)字段[知识点类型Id(knowledgeTypeId)]的长度不能超过4(In 知识点(cc_CourseKnowledges))!值:$(pobjcc_CourseKnowledgesEN.knowledgeTypeId)(clscc_CourseKnowledgesBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_CourseKnowledgesEN.courseChapterId) == false && GetStrLen(pobjcc_CourseKnowledgesEN.courseChapterId) > 8)
{
 throw new Error("(errid:Watl000059)字段[课程章节ID(courseChapterId)]的长度不能超过8(In 知识点(cc_CourseKnowledges))!值:$(pobjcc_CourseKnowledgesEN.courseChapterId)(clscc_CourseKnowledgesBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_CourseKnowledgesEN.userId) == false && GetStrLen(pobjcc_CourseKnowledgesEN.userId) > 20)
{
 throw new Error("(errid:Watl000059)字段[用户ID(userId)]的长度不能超过20(In 知识点(cc_CourseKnowledges))!值:$(pobjcc_CourseKnowledgesEN.userId)(clscc_CourseKnowledgesBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_CourseKnowledgesEN.uploadDate) == false && GetStrLen(pobjcc_CourseKnowledgesEN.uploadDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[上传时间(uploadDate)]的长度不能超过20(In 知识点(cc_CourseKnowledges))!值:$(pobjcc_CourseKnowledgesEN.uploadDate)(clscc_CourseKnowledgesBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_CourseKnowledgesEN.updDate) == false && GetStrLen(pobjcc_CourseKnowledgesEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 知识点(cc_CourseKnowledges))!值:$(pobjcc_CourseKnowledgesEN.updDate)(clscc_CourseKnowledgesBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_CourseKnowledgesEN.updUser) == false && GetStrLen(pobjcc_CourseKnowledgesEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 知识点(cc_CourseKnowledges))!值:$(pobjcc_CourseKnowledgesEN.updUser)(clscc_CourseKnowledgesBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_CourseKnowledgesEN.memo) == false && GetStrLen(pobjcc_CourseKnowledgesEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 知识点(cc_CourseKnowledges))!值:$(pobjcc_CourseKnowledgesEN.memo)(clscc_CourseKnowledgesBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjcc_CourseKnowledgesEN.courseKnowledgeId) == false && undefined !== pobjcc_CourseKnowledgesEN.courseKnowledgeId && tzDataType.isString(pobjcc_CourseKnowledgesEN.courseKnowledgeId) === false)
{
 throw new Error("(errid:Watl000060)字段[知识点Id(courseKnowledgeId)]的值:[$(pobjcc_CourseKnowledgesEN.courseKnowledgeId)], 非法，应该为字符型(In 知识点(cc_CourseKnowledges))!(clscc_CourseKnowledgesBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_CourseKnowledgesEN.knowledgeName) == false && undefined !== pobjcc_CourseKnowledgesEN.knowledgeName && tzDataType.isString(pobjcc_CourseKnowledgesEN.knowledgeName) === false)
{
 throw new Error("(errid:Watl000060)字段[知识点名称(knowledgeName)]的值:[$(pobjcc_CourseKnowledgesEN.knowledgeName)], 非法，应该为字符型(In 知识点(cc_CourseKnowledges))!(clscc_CourseKnowledgesBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_CourseKnowledgesEN.knowledgeTitle) == false && undefined !== pobjcc_CourseKnowledgesEN.knowledgeTitle && tzDataType.isString(pobjcc_CourseKnowledgesEN.knowledgeTitle) === false)
{
 throw new Error("(errid:Watl000060)字段[知识点标题(knowledgeTitle)]的值:[$(pobjcc_CourseKnowledgesEN.knowledgeTitle)], 非法，应该为字符型(In 知识点(cc_CourseKnowledges))!(clscc_CourseKnowledgesBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_CourseKnowledgesEN.knowledgeContent) == false && undefined !== pobjcc_CourseKnowledgesEN.knowledgeContent && tzDataType.isString(pobjcc_CourseKnowledgesEN.knowledgeContent) === false)
{
 throw new Error("(errid:Watl000060)字段[知识点内容(knowledgeContent)]的值:[$(pobjcc_CourseKnowledgesEN.knowledgeContent)], 非法，应该为字符型(In 知识点(cc_CourseKnowledges))!(clscc_CourseKnowledgesBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_CourseKnowledgesEN.courseId) == false && undefined !== pobjcc_CourseKnowledgesEN.courseId && tzDataType.isString(pobjcc_CourseKnowledgesEN.courseId) === false)
{
 throw new Error("(errid:Watl000060)字段[课程Id(courseId)]的值:[$(pobjcc_CourseKnowledgesEN.courseId)], 非法，应该为字符型(In 知识点(cc_CourseKnowledges))!(clscc_CourseKnowledgesBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_CourseKnowledgesEN.knowledgeTypeId) == false && undefined !== pobjcc_CourseKnowledgesEN.knowledgeTypeId && tzDataType.isString(pobjcc_CourseKnowledgesEN.knowledgeTypeId) === false)
{
 throw new Error("(errid:Watl000060)字段[知识点类型Id(knowledgeTypeId)]的值:[$(pobjcc_CourseKnowledgesEN.knowledgeTypeId)], 非法，应该为字符型(In 知识点(cc_CourseKnowledges))!(clscc_CourseKnowledgesBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_CourseKnowledgesEN.courseChapterId) == false && undefined !== pobjcc_CourseKnowledgesEN.courseChapterId && tzDataType.isString(pobjcc_CourseKnowledgesEN.courseChapterId) === false)
{
 throw new Error("(errid:Watl000060)字段[课程章节ID(courseChapterId)]的值:[$(pobjcc_CourseKnowledgesEN.courseChapterId)], 非法，应该为字符型(In 知识点(cc_CourseKnowledges))!(clscc_CourseKnowledgesBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_CourseKnowledgesEN.userId) == false && undefined !== pobjcc_CourseKnowledgesEN.userId && tzDataType.isString(pobjcc_CourseKnowledgesEN.userId) === false)
{
 throw new Error("(errid:Watl000060)字段[用户ID(userId)]的值:[$(pobjcc_CourseKnowledgesEN.userId)], 非法，应该为字符型(In 知识点(cc_CourseKnowledges))!(clscc_CourseKnowledgesBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_CourseKnowledgesEN.uploadDate) == false && undefined !== pobjcc_CourseKnowledgesEN.uploadDate && tzDataType.isString(pobjcc_CourseKnowledgesEN.uploadDate) === false)
{
 throw new Error("(errid:Watl000060)字段[上传时间(uploadDate)]的值:[$(pobjcc_CourseKnowledgesEN.uploadDate)], 非法，应该为字符型(In 知识点(cc_CourseKnowledges))!(clscc_CourseKnowledgesBL:CheckPropertyNew)");
}
if (null != pobjcc_CourseKnowledgesEN.isShow && undefined !== pobjcc_CourseKnowledgesEN.isShow && tzDataType.isBoolean(pobjcc_CourseKnowledgesEN.isShow) === false)
{
 throw new Error("(errid:Watl000060)字段[是否启用(isShow)]的值:[$(pobjcc_CourseKnowledgesEN.isShow)], 非法，应该为布尔型(In 知识点(cc_CourseKnowledges))!(clscc_CourseKnowledgesBL:CheckPropertyNew)");
}
if (null != pobjcc_CourseKnowledgesEN.isCast && undefined !== pobjcc_CourseKnowledgesEN.isCast && tzDataType.isBoolean(pobjcc_CourseKnowledgesEN.isCast) === false)
{
 throw new Error("(errid:Watl000060)字段[是否播放(isCast)]的值:[$(pobjcc_CourseKnowledgesEN.isCast)], 非法，应该为布尔型(In 知识点(cc_CourseKnowledges))!(clscc_CourseKnowledgesBL:CheckPropertyNew)");
}
if (null != pobjcc_CourseKnowledgesEN.likeCount && undefined !== pobjcc_CourseKnowledgesEN.likeCount && tzDataType.isNumber(pobjcc_CourseKnowledgesEN.likeCount) === false)
{
 throw new Error("(errid:Watl000060)字段[资源喜欢数量(likeCount)]的值:[$(pobjcc_CourseKnowledgesEN.likeCount)], 非法，应该为数值型(In 知识点(cc_CourseKnowledges))!(clscc_CourseKnowledgesBL:CheckPropertyNew)");
}
if (null != pobjcc_CourseKnowledgesEN.orderNum && undefined !== pobjcc_CourseKnowledgesEN.orderNum && tzDataType.isNumber(pobjcc_CourseKnowledgesEN.orderNum) === false)
{
 throw new Error("(errid:Watl000060)字段[序号(orderNum)]的值:[$(pobjcc_CourseKnowledgesEN.orderNum)], 非法，应该为数值型(In 知识点(cc_CourseKnowledges))!(clscc_CourseKnowledgesBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_CourseKnowledgesEN.updDate) == false && undefined !== pobjcc_CourseKnowledgesEN.updDate && tzDataType.isString(pobjcc_CourseKnowledgesEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjcc_CourseKnowledgesEN.updDate)], 非法，应该为字符型(In 知识点(cc_CourseKnowledges))!(clscc_CourseKnowledgesBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_CourseKnowledgesEN.updUser) == false && undefined !== pobjcc_CourseKnowledgesEN.updUser && tzDataType.isString(pobjcc_CourseKnowledgesEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjcc_CourseKnowledgesEN.updUser)], 非法，应该为字符型(In 知识点(cc_CourseKnowledges))!(clscc_CourseKnowledgesBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_CourseKnowledgesEN.memo) == false && undefined !== pobjcc_CourseKnowledgesEN.memo && tzDataType.isString(pobjcc_CourseKnowledgesEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjcc_CourseKnowledgesEN.memo)], 非法，应该为字符型(In 知识点(cc_CourseKnowledges))!(clscc_CourseKnowledgesBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
if (IsNullOrEmpty(pobjcc_CourseKnowledgesEN.courseId) == false && GetStrLen(pobjcc_CourseKnowledgesEN.courseId) !=  8)
{
 throw ("(errid:Watl000061)字段[课程Id]作为外键字段,长度应该为8(In 知识点)!(clscc_CourseKnowledgesBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_CourseKnowledgesEN.courseChapterId) == false && GetStrLen(pobjcc_CourseKnowledgesEN.courseChapterId) !=  8)
{
 throw ("(errid:Watl000061)字段[课程章节ID]作为外键字段,长度应该为8(In 知识点)!(clscc_CourseKnowledgesBL:CheckPropertyNew)");
}

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjcc_CourseKnowledgesEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function cc_CourseKnowledges_CheckProperty4Update (pobjcc_CourseKnowledgesEN: clscc_CourseKnowledgesEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjcc_CourseKnowledgesEN.courseKnowledgeId) == false && GetStrLen(pobjcc_CourseKnowledgesEN.courseKnowledgeId) > 8)
{
 throw new Error("(errid:Watl000062)字段[知识点Id(courseKnowledgeId)]的长度不能超过8(In 知识点(cc_CourseKnowledges))!值:$(pobjcc_CourseKnowledgesEN.courseKnowledgeId)(clscc_CourseKnowledgesBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjcc_CourseKnowledgesEN.knowledgeName) == false && GetStrLen(pobjcc_CourseKnowledgesEN.knowledgeName) > 100)
{
 throw new Error("(errid:Watl000062)字段[知识点名称(knowledgeName)]的长度不能超过100(In 知识点(cc_CourseKnowledges))!值:$(pobjcc_CourseKnowledgesEN.knowledgeName)(clscc_CourseKnowledgesBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjcc_CourseKnowledgesEN.knowledgeTitle) == false && GetStrLen(pobjcc_CourseKnowledgesEN.knowledgeTitle) > 100)
{
 throw new Error("(errid:Watl000062)字段[知识点标题(knowledgeTitle)]的长度不能超过100(In 知识点(cc_CourseKnowledges))!值:$(pobjcc_CourseKnowledgesEN.knowledgeTitle)(clscc_CourseKnowledgesBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjcc_CourseKnowledgesEN.courseId) == false && GetStrLen(pobjcc_CourseKnowledgesEN.courseId) > 8)
{
 throw new Error("(errid:Watl000062)字段[课程Id(courseId)]的长度不能超过8(In 知识点(cc_CourseKnowledges))!值:$(pobjcc_CourseKnowledgesEN.courseId)(clscc_CourseKnowledgesBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjcc_CourseKnowledgesEN.knowledgeTypeId) == false && GetStrLen(pobjcc_CourseKnowledgesEN.knowledgeTypeId) > 4)
{
 throw new Error("(errid:Watl000062)字段[知识点类型Id(knowledgeTypeId)]的长度不能超过4(In 知识点(cc_CourseKnowledges))!值:$(pobjcc_CourseKnowledgesEN.knowledgeTypeId)(clscc_CourseKnowledgesBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjcc_CourseKnowledgesEN.courseChapterId) == false && GetStrLen(pobjcc_CourseKnowledgesEN.courseChapterId) > 8)
{
 throw new Error("(errid:Watl000062)字段[课程章节ID(courseChapterId)]的长度不能超过8(In 知识点(cc_CourseKnowledges))!值:$(pobjcc_CourseKnowledgesEN.courseChapterId)(clscc_CourseKnowledgesBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjcc_CourseKnowledgesEN.userId) == false && GetStrLen(pobjcc_CourseKnowledgesEN.userId) > 20)
{
 throw new Error("(errid:Watl000062)字段[用户ID(userId)]的长度不能超过20(In 知识点(cc_CourseKnowledges))!值:$(pobjcc_CourseKnowledgesEN.userId)(clscc_CourseKnowledgesBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjcc_CourseKnowledgesEN.uploadDate) == false && GetStrLen(pobjcc_CourseKnowledgesEN.uploadDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[上传时间(uploadDate)]的长度不能超过20(In 知识点(cc_CourseKnowledges))!值:$(pobjcc_CourseKnowledgesEN.uploadDate)(clscc_CourseKnowledgesBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjcc_CourseKnowledgesEN.updDate) == false && GetStrLen(pobjcc_CourseKnowledgesEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 知识点(cc_CourseKnowledges))!值:$(pobjcc_CourseKnowledgesEN.updDate)(clscc_CourseKnowledgesBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjcc_CourseKnowledgesEN.updUser) == false && GetStrLen(pobjcc_CourseKnowledgesEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 知识点(cc_CourseKnowledges))!值:$(pobjcc_CourseKnowledgesEN.updUser)(clscc_CourseKnowledgesBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjcc_CourseKnowledgesEN.memo) == false && GetStrLen(pobjcc_CourseKnowledgesEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 知识点(cc_CourseKnowledges))!值:$(pobjcc_CourseKnowledgesEN.memo)(clscc_CourseKnowledgesBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjcc_CourseKnowledgesEN.courseKnowledgeId) == false && undefined !== pobjcc_CourseKnowledgesEN.courseKnowledgeId && tzDataType.isString(pobjcc_CourseKnowledgesEN.courseKnowledgeId) === false)
{
 throw new Error("(errid:Watl000063)字段[知识点Id(courseKnowledgeId)]的值:[$(pobjcc_CourseKnowledgesEN.courseKnowledgeId)], 非法，应该为字符型(In 知识点(cc_CourseKnowledges))!(clscc_CourseKnowledgesBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjcc_CourseKnowledgesEN.knowledgeName) == false && undefined !== pobjcc_CourseKnowledgesEN.knowledgeName && tzDataType.isString(pobjcc_CourseKnowledgesEN.knowledgeName) === false)
{
 throw new Error("(errid:Watl000063)字段[知识点名称(knowledgeName)]的值:[$(pobjcc_CourseKnowledgesEN.knowledgeName)], 非法，应该为字符型(In 知识点(cc_CourseKnowledges))!(clscc_CourseKnowledgesBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjcc_CourseKnowledgesEN.knowledgeTitle) == false && undefined !== pobjcc_CourseKnowledgesEN.knowledgeTitle && tzDataType.isString(pobjcc_CourseKnowledgesEN.knowledgeTitle) === false)
{
 throw new Error("(errid:Watl000063)字段[知识点标题(knowledgeTitle)]的值:[$(pobjcc_CourseKnowledgesEN.knowledgeTitle)], 非法，应该为字符型(In 知识点(cc_CourseKnowledges))!(clscc_CourseKnowledgesBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjcc_CourseKnowledgesEN.knowledgeContent) == false && undefined !== pobjcc_CourseKnowledgesEN.knowledgeContent && tzDataType.isString(pobjcc_CourseKnowledgesEN.knowledgeContent) === false)
{
 throw new Error("(errid:Watl000063)字段[知识点内容(knowledgeContent)]的值:[$(pobjcc_CourseKnowledgesEN.knowledgeContent)], 非法，应该为字符型(In 知识点(cc_CourseKnowledges))!(clscc_CourseKnowledgesBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjcc_CourseKnowledgesEN.courseId) == false && undefined !== pobjcc_CourseKnowledgesEN.courseId && tzDataType.isString(pobjcc_CourseKnowledgesEN.courseId) === false)
{
 throw new Error("(errid:Watl000063)字段[课程Id(courseId)]的值:[$(pobjcc_CourseKnowledgesEN.courseId)], 非法，应该为字符型(In 知识点(cc_CourseKnowledges))!(clscc_CourseKnowledgesBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjcc_CourseKnowledgesEN.knowledgeTypeId) == false && undefined !== pobjcc_CourseKnowledgesEN.knowledgeTypeId && tzDataType.isString(pobjcc_CourseKnowledgesEN.knowledgeTypeId) === false)
{
 throw new Error("(errid:Watl000063)字段[知识点类型Id(knowledgeTypeId)]的值:[$(pobjcc_CourseKnowledgesEN.knowledgeTypeId)], 非法，应该为字符型(In 知识点(cc_CourseKnowledges))!(clscc_CourseKnowledgesBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjcc_CourseKnowledgesEN.courseChapterId) == false && undefined !== pobjcc_CourseKnowledgesEN.courseChapterId && tzDataType.isString(pobjcc_CourseKnowledgesEN.courseChapterId) === false)
{
 throw new Error("(errid:Watl000063)字段[课程章节ID(courseChapterId)]的值:[$(pobjcc_CourseKnowledgesEN.courseChapterId)], 非法，应该为字符型(In 知识点(cc_CourseKnowledges))!(clscc_CourseKnowledgesBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjcc_CourseKnowledgesEN.userId) == false && undefined !== pobjcc_CourseKnowledgesEN.userId && tzDataType.isString(pobjcc_CourseKnowledgesEN.userId) === false)
{
 throw new Error("(errid:Watl000063)字段[用户ID(userId)]的值:[$(pobjcc_CourseKnowledgesEN.userId)], 非法，应该为字符型(In 知识点(cc_CourseKnowledges))!(clscc_CourseKnowledgesBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjcc_CourseKnowledgesEN.uploadDate) == false && undefined !== pobjcc_CourseKnowledgesEN.uploadDate && tzDataType.isString(pobjcc_CourseKnowledgesEN.uploadDate) === false)
{
 throw new Error("(errid:Watl000063)字段[上传时间(uploadDate)]的值:[$(pobjcc_CourseKnowledgesEN.uploadDate)], 非法，应该为字符型(In 知识点(cc_CourseKnowledges))!(clscc_CourseKnowledgesBL:CheckProperty4Update)");
}
if (null != pobjcc_CourseKnowledgesEN.isShow && undefined !== pobjcc_CourseKnowledgesEN.isShow && tzDataType.isBoolean(pobjcc_CourseKnowledgesEN.isShow) === false)
{
 throw new Error("(errid:Watl000063)字段[是否启用(isShow)]的值:[$(pobjcc_CourseKnowledgesEN.isShow)], 非法，应该为布尔型(In 知识点(cc_CourseKnowledges))!(clscc_CourseKnowledgesBL:CheckProperty4Update)");
}
if (null != pobjcc_CourseKnowledgesEN.isCast && undefined !== pobjcc_CourseKnowledgesEN.isCast && tzDataType.isBoolean(pobjcc_CourseKnowledgesEN.isCast) === false)
{
 throw new Error("(errid:Watl000063)字段[是否播放(isCast)]的值:[$(pobjcc_CourseKnowledgesEN.isCast)], 非法，应该为布尔型(In 知识点(cc_CourseKnowledges))!(clscc_CourseKnowledgesBL:CheckProperty4Update)");
}
if (null != pobjcc_CourseKnowledgesEN.likeCount && undefined !== pobjcc_CourseKnowledgesEN.likeCount && tzDataType.isNumber(pobjcc_CourseKnowledgesEN.likeCount) === false)
{
 throw new Error("(errid:Watl000063)字段[资源喜欢数量(likeCount)]的值:[$(pobjcc_CourseKnowledgesEN.likeCount)], 非法，应该为数值型(In 知识点(cc_CourseKnowledges))!(clscc_CourseKnowledgesBL:CheckProperty4Update)");
}
if (null != pobjcc_CourseKnowledgesEN.orderNum && undefined !== pobjcc_CourseKnowledgesEN.orderNum && tzDataType.isNumber(pobjcc_CourseKnowledgesEN.orderNum) === false)
{
 throw new Error("(errid:Watl000063)字段[序号(orderNum)]的值:[$(pobjcc_CourseKnowledgesEN.orderNum)], 非法，应该为数值型(In 知识点(cc_CourseKnowledges))!(clscc_CourseKnowledgesBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjcc_CourseKnowledgesEN.updDate) == false && undefined !== pobjcc_CourseKnowledgesEN.updDate && tzDataType.isString(pobjcc_CourseKnowledgesEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjcc_CourseKnowledgesEN.updDate)], 非法，应该为字符型(In 知识点(cc_CourseKnowledges))!(clscc_CourseKnowledgesBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjcc_CourseKnowledgesEN.updUser) == false && undefined !== pobjcc_CourseKnowledgesEN.updUser && tzDataType.isString(pobjcc_CourseKnowledgesEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjcc_CourseKnowledgesEN.updUser)], 非法，应该为字符型(In 知识点(cc_CourseKnowledges))!(clscc_CourseKnowledgesBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjcc_CourseKnowledgesEN.memo) == false && undefined !== pobjcc_CourseKnowledgesEN.memo && tzDataType.isString(pobjcc_CourseKnowledgesEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjcc_CourseKnowledgesEN.memo)], 非法，应该为字符型(In 知识点(cc_CourseKnowledges))!(clscc_CourseKnowledgesBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (IsNullOrEmpty(pobjcc_CourseKnowledgesEN.courseKnowledgeId) === true 
 || pobjcc_CourseKnowledgesEN.courseKnowledgeId.toString()  ===  "0" )
{
 throw new Error("(errid:Watl000064)字段[知识点Id]不能为空(In 知识点)!(clscc_CourseKnowledgesBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
if (IsNullOrEmpty(pobjcc_CourseKnowledgesEN.courseId) == false && GetStrLen(pobjcc_CourseKnowledgesEN.courseId) !=  8)
{
 throw ("(errid:Watl000065)字段[课程Id]作为外键字段,长度应该为8(In 知识点)!(clscc_CourseKnowledgesBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_CourseKnowledgesEN.courseChapterId) == false && GetStrLen(pobjcc_CourseKnowledgesEN.courseChapterId) !=  8)
{
 throw ("(errid:Watl000065)字段[课程章节ID]作为外键字段,长度应该为8(In 知识点)!(clscc_CourseKnowledgesBL:CheckPropertyNew)");
}

 pobjcc_CourseKnowledgesEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function cc_CourseKnowledges_GetJSONStrByObj (pobjcc_CourseKnowledgesEN: clscc_CourseKnowledgesEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjcc_CourseKnowledgesEN.sf_UpdFldSetStr = pobjcc_CourseKnowledgesEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjcc_CourseKnowledgesEN);
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
export function cc_CourseKnowledges_GetObjLstByJSONStr (strJSON: string): Array<clscc_CourseKnowledgesEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrcc_CourseKnowledgesObjLst = new Array<clscc_CourseKnowledgesEN>();
if (strJSON === "")
{
return arrcc_CourseKnowledgesObjLst;
}
try
{
arrcc_CourseKnowledgesObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrcc_CourseKnowledgesObjLst;
}
return arrcc_CourseKnowledgesObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrcc_CourseKnowledgesObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function cc_CourseKnowledges_GetObjLstByJSONObjLst (arrcc_CourseKnowledgesObjLstS: Array<clscc_CourseKnowledgesEN>): Array<clscc_CourseKnowledgesEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrcc_CourseKnowledgesObjLst = new Array<clscc_CourseKnowledgesEN>();
for (const objInFor of arrcc_CourseKnowledgesObjLstS) {
const obj1 = cc_CourseKnowledges_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrcc_CourseKnowledgesObjLst.push(obj1);
}
return arrcc_CourseKnowledgesObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function cc_CourseKnowledges_GetObjByJSONStr (strJSON: string): clscc_CourseKnowledgesEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjcc_CourseKnowledgesEN = new clscc_CourseKnowledgesEN();
if (strJSON === "")
{
return pobjcc_CourseKnowledgesEN;
}
try
{
pobjcc_CourseKnowledgesEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjcc_CourseKnowledgesEN;
}
return pobjcc_CourseKnowledgesEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function cc_CourseKnowledges_GetCombineCondition(objcc_CourseKnowledges_Cond: clscc_CourseKnowledgesEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objcc_CourseKnowledges_Cond.dicFldComparisonOp, clscc_CourseKnowledgesEN.con_CourseKnowledgeId) == true)
{
const strComparisonOp_CourseKnowledgeId:string = objcc_CourseKnowledges_Cond.dicFldComparisonOp[clscc_CourseKnowledgesEN.con_CourseKnowledgeId];
strWhereCond += Format(" And {0} {2} '{1}'", clscc_CourseKnowledgesEN.con_CourseKnowledgeId, objcc_CourseKnowledges_Cond.courseKnowledgeId, strComparisonOp_CourseKnowledgeId);
}
if (Object.prototype.hasOwnProperty.call(objcc_CourseKnowledges_Cond.dicFldComparisonOp, clscc_CourseKnowledgesEN.con_KnowledgeName) == true)
{
const strComparisonOp_KnowledgeName:string = objcc_CourseKnowledges_Cond.dicFldComparisonOp[clscc_CourseKnowledgesEN.con_KnowledgeName];
strWhereCond += Format(" And {0} {2} '{1}'", clscc_CourseKnowledgesEN.con_KnowledgeName, objcc_CourseKnowledges_Cond.knowledgeName, strComparisonOp_KnowledgeName);
}
if (Object.prototype.hasOwnProperty.call(objcc_CourseKnowledges_Cond.dicFldComparisonOp, clscc_CourseKnowledgesEN.con_KnowledgeTitle) == true)
{
const strComparisonOp_KnowledgeTitle:string = objcc_CourseKnowledges_Cond.dicFldComparisonOp[clscc_CourseKnowledgesEN.con_KnowledgeTitle];
strWhereCond += Format(" And {0} {2} '{1}'", clscc_CourseKnowledgesEN.con_KnowledgeTitle, objcc_CourseKnowledges_Cond.knowledgeTitle, strComparisonOp_KnowledgeTitle);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objcc_CourseKnowledges_Cond.dicFldComparisonOp, clscc_CourseKnowledgesEN.con_CourseId) == true)
{
const strComparisonOp_CourseId:string = objcc_CourseKnowledges_Cond.dicFldComparisonOp[clscc_CourseKnowledgesEN.con_CourseId];
strWhereCond += Format(" And {0} {2} '{1}'", clscc_CourseKnowledgesEN.con_CourseId, objcc_CourseKnowledges_Cond.courseId, strComparisonOp_CourseId);
}
if (Object.prototype.hasOwnProperty.call(objcc_CourseKnowledges_Cond.dicFldComparisonOp, clscc_CourseKnowledgesEN.con_KnowledgeTypeId) == true)
{
const strComparisonOp_KnowledgeTypeId:string = objcc_CourseKnowledges_Cond.dicFldComparisonOp[clscc_CourseKnowledgesEN.con_KnowledgeTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clscc_CourseKnowledgesEN.con_KnowledgeTypeId, objcc_CourseKnowledges_Cond.knowledgeTypeId, strComparisonOp_KnowledgeTypeId);
}
if (Object.prototype.hasOwnProperty.call(objcc_CourseKnowledges_Cond.dicFldComparisonOp, clscc_CourseKnowledgesEN.con_CourseChapterId) == true)
{
const strComparisonOp_CourseChapterId:string = objcc_CourseKnowledges_Cond.dicFldComparisonOp[clscc_CourseKnowledgesEN.con_CourseChapterId];
strWhereCond += Format(" And {0} {2} '{1}'", clscc_CourseKnowledgesEN.con_CourseChapterId, objcc_CourseKnowledges_Cond.courseChapterId, strComparisonOp_CourseChapterId);
}
if (Object.prototype.hasOwnProperty.call(objcc_CourseKnowledges_Cond.dicFldComparisonOp, clscc_CourseKnowledgesEN.con_UserId) == true)
{
const strComparisonOp_UserId:string = objcc_CourseKnowledges_Cond.dicFldComparisonOp[clscc_CourseKnowledgesEN.con_UserId];
strWhereCond += Format(" And {0} {2} '{1}'", clscc_CourseKnowledgesEN.con_UserId, objcc_CourseKnowledges_Cond.userId, strComparisonOp_UserId);
}
if (Object.prototype.hasOwnProperty.call(objcc_CourseKnowledges_Cond.dicFldComparisonOp, clscc_CourseKnowledgesEN.con_UploadDate) == true)
{
const strComparisonOp_UploadDate:string = objcc_CourseKnowledges_Cond.dicFldComparisonOp[clscc_CourseKnowledgesEN.con_UploadDate];
strWhereCond += Format(" And {0} {2} '{1}'", clscc_CourseKnowledgesEN.con_UploadDate, objcc_CourseKnowledges_Cond.uploadDate, strComparisonOp_UploadDate);
}
if (Object.prototype.hasOwnProperty.call(objcc_CourseKnowledges_Cond.dicFldComparisonOp, clscc_CourseKnowledgesEN.con_IsShow) == true)
{
if (objcc_CourseKnowledges_Cond.isShow == true)
{
strWhereCond += Format(" And {0} = '1'", clscc_CourseKnowledgesEN.con_IsShow);
}
else
{
strWhereCond += Format(" And {0} = '0'", clscc_CourseKnowledgesEN.con_IsShow);
}
}
if (Object.prototype.hasOwnProperty.call(objcc_CourseKnowledges_Cond.dicFldComparisonOp, clscc_CourseKnowledgesEN.con_IsCast) == true)
{
if (objcc_CourseKnowledges_Cond.isCast == true)
{
strWhereCond += Format(" And {0} = '1'", clscc_CourseKnowledgesEN.con_IsCast);
}
else
{
strWhereCond += Format(" And {0} = '0'", clscc_CourseKnowledgesEN.con_IsCast);
}
}
if (Object.prototype.hasOwnProperty.call(objcc_CourseKnowledges_Cond.dicFldComparisonOp, clscc_CourseKnowledgesEN.con_LikeCount) == true)
{
const strComparisonOp_LikeCount:string = objcc_CourseKnowledges_Cond.dicFldComparisonOp[clscc_CourseKnowledgesEN.con_LikeCount];
strWhereCond += Format(" And {0} {2} {1}", clscc_CourseKnowledgesEN.con_LikeCount, objcc_CourseKnowledges_Cond.likeCount, strComparisonOp_LikeCount);
}
if (Object.prototype.hasOwnProperty.call(objcc_CourseKnowledges_Cond.dicFldComparisonOp, clscc_CourseKnowledgesEN.con_OrderNum) == true)
{
const strComparisonOp_OrderNum:string = objcc_CourseKnowledges_Cond.dicFldComparisonOp[clscc_CourseKnowledgesEN.con_OrderNum];
strWhereCond += Format(" And {0} {2} {1}", clscc_CourseKnowledgesEN.con_OrderNum, objcc_CourseKnowledges_Cond.orderNum, strComparisonOp_OrderNum);
}
if (Object.prototype.hasOwnProperty.call(objcc_CourseKnowledges_Cond.dicFldComparisonOp, clscc_CourseKnowledgesEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objcc_CourseKnowledges_Cond.dicFldComparisonOp[clscc_CourseKnowledgesEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clscc_CourseKnowledgesEN.con_UpdDate, objcc_CourseKnowledges_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objcc_CourseKnowledges_Cond.dicFldComparisonOp, clscc_CourseKnowledgesEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objcc_CourseKnowledges_Cond.dicFldComparisonOp[clscc_CourseKnowledgesEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clscc_CourseKnowledgesEN.con_UpdUser, objcc_CourseKnowledges_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objcc_CourseKnowledges_Cond.dicFldComparisonOp, clscc_CourseKnowledgesEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objcc_CourseKnowledges_Cond.dicFldComparisonOp[clscc_CourseKnowledgesEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clscc_CourseKnowledgesEN.con_Memo, objcc_CourseKnowledges_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--cc_CourseKnowledges(知识点),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param strCourseId: 课程Id(要求唯一的字段)
 * @param strKnowledgeName: 知识点名称(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function cc_CourseKnowledges_GetUniCondStr_CourseId_KnowledgeName(objcc_CourseKnowledgesEN: clscc_CourseKnowledgesEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and CourseId = '{0}'", objcc_CourseKnowledgesEN.courseId);
 strWhereCond +=  Format(" and KnowledgeName = '{0}'", objcc_CourseKnowledgesEN.knowledgeName);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--cc_CourseKnowledges(知识点),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param strCourseId: 课程Id(要求唯一的字段)
 * @param strKnowledgeName: 知识点名称(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function cc_CourseKnowledges_GetUniCondStr4Update_CourseId_KnowledgeName(objcc_CourseKnowledgesEN: clscc_CourseKnowledgesEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and CourseKnowledgeId <> '{0}'", objcc_CourseKnowledgesEN.courseKnowledgeId);
 strWhereCond +=  Format(" and CourseId = '{0}'", objcc_CourseKnowledgesEN.courseId);
 strWhereCond +=  Format(" and KnowledgeName = '{0}'", objcc_CourseKnowledgesEN.knowledgeName);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objcc_CourseKnowledgesENS:源对象
 * @param objcc_CourseKnowledgesENT:目标对象
*/
export function cc_CourseKnowledges_CopyObjTo(objcc_CourseKnowledgesENS: clscc_CourseKnowledgesEN , objcc_CourseKnowledgesENT: clscc_CourseKnowledgesEN ): void 
{
objcc_CourseKnowledgesENT.courseKnowledgeId = objcc_CourseKnowledgesENS.courseKnowledgeId; //知识点Id
objcc_CourseKnowledgesENT.knowledgeName = objcc_CourseKnowledgesENS.knowledgeName; //知识点名称
objcc_CourseKnowledgesENT.knowledgeTitle = objcc_CourseKnowledgesENS.knowledgeTitle; //知识点标题
objcc_CourseKnowledgesENT.knowledgeContent = objcc_CourseKnowledgesENS.knowledgeContent; //知识点内容
objcc_CourseKnowledgesENT.courseId = objcc_CourseKnowledgesENS.courseId; //课程Id
objcc_CourseKnowledgesENT.knowledgeTypeId = objcc_CourseKnowledgesENS.knowledgeTypeId; //知识点类型Id
objcc_CourseKnowledgesENT.courseChapterId = objcc_CourseKnowledgesENS.courseChapterId; //课程章节ID
objcc_CourseKnowledgesENT.userId = objcc_CourseKnowledgesENS.userId; //用户ID
objcc_CourseKnowledgesENT.uploadDate = objcc_CourseKnowledgesENS.uploadDate; //上传时间
objcc_CourseKnowledgesENT.isShow = objcc_CourseKnowledgesENS.isShow; //是否启用
objcc_CourseKnowledgesENT.isCast = objcc_CourseKnowledgesENS.isCast; //是否播放
objcc_CourseKnowledgesENT.likeCount = objcc_CourseKnowledgesENS.likeCount; //资源喜欢数量
objcc_CourseKnowledgesENT.orderNum = objcc_CourseKnowledgesENS.orderNum; //序号
objcc_CourseKnowledgesENT.updDate = objcc_CourseKnowledgesENS.updDate; //修改日期
objcc_CourseKnowledgesENT.updUser = objcc_CourseKnowledgesENS.updUser; //修改人
objcc_CourseKnowledgesENT.memo = objcc_CourseKnowledgesENS.memo; //备注
objcc_CourseKnowledgesENT.sf_UpdFldSetStr = objcc_CourseKnowledgesENS.updFldString; //sf_UpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objcc_CourseKnowledgesENS:源对象
 * @param objcc_CourseKnowledgesENT:目标对象
*/
export function cc_CourseKnowledges_GetObjFromJsonObj(objcc_CourseKnowledgesENS: clscc_CourseKnowledgesEN): clscc_CourseKnowledgesEN 
{
 const objcc_CourseKnowledgesENT: clscc_CourseKnowledgesEN = new clscc_CourseKnowledgesEN();
ObjectAssign(objcc_CourseKnowledgesENT, objcc_CourseKnowledgesENS);
 return objcc_CourseKnowledgesENT;
}