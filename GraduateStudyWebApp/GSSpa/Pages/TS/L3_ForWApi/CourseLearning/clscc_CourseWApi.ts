
 /**
 * 类名:clscc_CourseWApi
 * 表名:cc_Course(01120056)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:45:59
 * 生成者:pyf
 * 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:课程学习(CourseLearning)
 * 框架-层名:WA_访问层(TS)(WA_Access)
 * 编程语言:TypeScript
 * 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
   *      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 **/

/**
 * 课程(cc_Course)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clscc_CourseEN } from "../../L0_Entity/CourseLearning/clscc_CourseEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { tzDataType } from "../../PubFun/jsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const cc_Course_Controller = "cc_CourseApi";
 export const cc_Course_ConstructorName = "cc_Course";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strCourseId:关键字
 * @returns 对象
 **/
export async function cc_Course_GetObjByCourseIdAsync(strCourseId: string): Promise<clscc_CourseEN>  
{
const strThisFuncName = "GetObjByCourseIdAsync";

if (IsNullOrEmpty(strCourseId) == true)
{
  const strMsg = Format("参数:[strCourseId]不能为空！(In GetObjByCourseIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strCourseId.length != 8)
{
const strMsg = Format("缓存分类变量:[strCourseId]的长度:[{0}]不正确！", strCourseId.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByCourseId";
const strUrl = GetWebApiUrl(cc_Course_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strCourseId": strCourseId,
}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObj = data.returnObj;
if (returnObj == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", cc_Course_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objcc_Course = cc_Course_GetObjFromJsonObj(returnObj);
return objcc_Course;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_Course_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_Course_ConstructorName, strThisFuncName);
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
 * @param strCourseId:所给的关键字
 * @returns 对象
*/
export async function cc_Course_GetObjByCourseId_Cache(strCourseId: string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByCourseId_Cache";

if (IsNullOrEmpty(strCourseId) == true)
{
  const strMsg = Format("参数:[strCourseId]不能为空！(In GetObjByCourseId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strCourseId.length != 8)
{
const strMsg = Format("缓存分类变量:[strCourseId]的长度:[{0}]不正确！", strCourseId.length);
console.error(strMsg);
throw (strMsg);
}
const arrcc_CourseObjLst_Cache = await cc_Course_GetObjLst_Cache();
try
{
const arrcc_Course_Sel: Array <clscc_CourseEN> = arrcc_CourseObjLst_Cache.filter(x => x.courseId == strCourseId);
let objcc_Course: clscc_CourseEN;
if (arrcc_Course_Sel.length > 0)
{
objcc_Course = arrcc_Course_Sel[0];
return objcc_Course;
}
else
{
if (bolTryAsyncOnce == true)
{
objcc_Course = await cc_Course_GetObjByCourseIdAsync(strCourseId);
if (objcc_Course != null)
{
cc_Course_ReFreshThisCache();
return objcc_Course;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strCourseId, cc_Course_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param strCourseId:所给的关键字
 * @returns 对象
*/
export async function cc_Course_GetObjByCourseId_localStorage(strCourseId: string) {
const strThisFuncName = "GetObjByCourseId_localStorage";

if (IsNullOrEmpty(strCourseId) == true)
{
  const strMsg = Format("参数:[strCourseId]不能为空！(In GetObjByCourseId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
if (strCourseId.length != 8)
{
const strMsg = Format("缓存分类变量:[strCourseId]的长度:[{0}]不正确！", strCourseId.length);
console.error(strMsg);
throw (strMsg);
}
const strKey = Format("{0}_{1}", clscc_CourseEN._CurrTabName, strCourseId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objcc_Course_Cache: clscc_CourseEN = JSON.parse(strTempObj);
return objcc_Course_Cache;
}
try
{
const objcc_Course = await cc_Course_GetObjByCourseIdAsync(strCourseId);
if (objcc_Course != null)
{
localStorage.setItem(strKey, JSON.stringify(objcc_Course));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objcc_Course;
}
return objcc_Course;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strCourseId, cc_Course_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objcc_Course:所给的对象
 * @returns 对象
*/
export async function cc_Course_UpdateObjInLst_Cache(objcc_Course: clscc_CourseEN) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrcc_CourseObjLst_Cache = await cc_Course_GetObjLst_Cache();
const obj = arrcc_CourseObjLst_Cache.find(x => x.courseId == objcc_Course.courseId);
if (obj != null)
{
objcc_Course.courseId = obj.courseId;
ObjectAssign( obj, objcc_Course);
}
else
{
arrcc_CourseObjLst_Cache.push(objcc_Course);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, cc_Course_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
}

/**
 * 根据关键字获取相关对象的名称属性, 从缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
 * @param strCourseId:所给的关键字
 * @returns 对象
*/
export async function cc_Course_GetNameByCourseId_Cache(strCourseId: string) {
const strThisFuncName = "GetNameByCourseId_Cache";

if (IsNullOrEmpty(strCourseId) == true)
{
  const strMsg = Format("参数:[strCourseId]不能为空！(In GetNameByCourseId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strCourseId.length != 8)
{
const strMsg = Format("缓存分类变量:[strCourseId]的长度:[{0}]不正确！", strCourseId.length);
console.error(strMsg);
throw (strMsg);
}
const arrcc_CourseObjLst_Cache = await cc_Course_GetObjLst_Cache();
if (arrcc_CourseObjLst_Cache == null) return "";
try
{
const arrcc_Course_Sel: Array <clscc_CourseEN> = arrcc_CourseObjLst_Cache.filter(x => x.courseId == strCourseId);
let objcc_Course: clscc_CourseEN;
if (arrcc_Course_Sel.length > 0)
{
objcc_Course = arrcc_Course_Sel[0];
return objcc_Course.courseName;
}
else
{
return "";
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strCourseId);
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
 * @returns 返回一个输出字段值
*/
export async function cc_Course_func(strInFldName:string , strOutFldName:string ,  strInValue: string) 
{
//const strThisFuncName = "func";

if (strInFldName != clscc_CourseEN.con_CourseId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clscc_CourseEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clscc_CourseEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strCourseId = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objcc_Course = await cc_Course_GetObjByCourseId_Cache(strCourseId );
if (objcc_Course == null) return "";
return objcc_Course.GetFldValue(strOutFldName).toString();
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
export function cc_Course_SortFun_Defa(a:clscc_CourseEN , b:clscc_CourseEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.courseId.localeCompare(b.courseId);
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
export function cc_Course_SortFun_Defa_2Fld(a:clscc_CourseEN , b:clscc_CourseEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.courseCode == b.courseCode) return a.courseDescription.localeCompare(b.courseDescription);
else return a.courseCode.localeCompare(b.courseCode);
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
export function cc_Course_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clscc_CourseEN.con_CourseId:
return (a: clscc_CourseEN, b: clscc_CourseEN) => {
return a.courseId.localeCompare(b.courseId);
}
case clscc_CourseEN.con_CourseCode:
return (a: clscc_CourseEN, b: clscc_CourseEN) => {
return a.courseCode.localeCompare(b.courseCode);
}
case clscc_CourseEN.con_CourseDescription:
return (a: clscc_CourseEN, b: clscc_CourseEN) => {
return a.courseDescription.localeCompare(b.courseDescription);
}
case clscc_CourseEN.con_CourseName:
return (a: clscc_CourseEN, b: clscc_CourseEN) => {
return a.courseName.localeCompare(b.courseName);
}
case clscc_CourseEN.con_CourseTypeID:
return (a: clscc_CourseEN, b: clscc_CourseEN) => {
return a.courseTypeID.localeCompare(b.courseTypeID);
}
case clscc_CourseEN.con_CreateDate:
return (a: clscc_CourseEN, b: clscc_CourseEN) => {
return a.createDate.localeCompare(b.createDate);
}
case clscc_CourseEN.con_ExcellentTypeId:
return (a: clscc_CourseEN, b: clscc_CourseEN) => {
return a.excellentTypeId.localeCompare(b.excellentTypeId);
}
case clscc_CourseEN.con_ExcellentYear:
return (a: clscc_CourseEN, b: clscc_CourseEN) => {
return a.excellentYear-b.excellentYear;
}
case clscc_CourseEN.con_IsBuildingCourse:
return (a: clscc_CourseEN, b: clscc_CourseEN) => {
if (a.isBuildingCourse == true) return 1;
else return -1
}
case clscc_CourseEN.con_IsDoubleLanguageCourse:
return (a: clscc_CourseEN, b: clscc_CourseEN) => {
if (a.isDoubleLanguageCourse == true) return 1;
else return -1
}
case clscc_CourseEN.con_IsOpen:
return (a: clscc_CourseEN, b: clscc_CourseEN) => {
if (a.isOpen == true) return 1;
else return -1
}
case clscc_CourseEN.con_IsRecommendedCourse:
return (a: clscc_CourseEN, b: clscc_CourseEN) => {
if (a.isRecommendedCourse == true) return 1;
else return -1
}
case clscc_CourseEN.con_IsSelfPropelledCourse:
return (a: clscc_CourseEN, b: clscc_CourseEN) => {
if (a.isSelfPropelledCourse == true) return 1;
else return -1
}
case clscc_CourseEN.con_OperationDate:
return (a: clscc_CourseEN, b: clscc_CourseEN) => {
return a.operationDate.localeCompare(b.operationDate);
}
case clscc_CourseEN.con_OrderNum:
return (a: clscc_CourseEN, b: clscc_CourseEN) => {
return a.orderNum-b.orderNum;
}
case clscc_CourseEN.con_OuterLink:
return (a: clscc_CourseEN, b: clscc_CourseEN) => {
return a.outerLink.localeCompare(b.outerLink);
}
case clscc_CourseEN.con_ViewCount:
return (a: clscc_CourseEN, b: clscc_CourseEN) => {
return a.viewCount-b.viewCount;
}
case clscc_CourseEN.con_ThemeId:
return (a: clscc_CourseEN, b: clscc_CourseEN) => {
return a.themeId.localeCompare(b.themeId);
}
case clscc_CourseEN.con_id_School:
return (a: clscc_CourseEN, b: clscc_CourseEN) => {
return a.id_School.localeCompare(b.id_School);
}
case clscc_CourseEN.con_id_XzMajor:
return (a: clscc_CourseEN, b: clscc_CourseEN) => {
return a.id_XzMajor.localeCompare(b.id_XzMajor);
}
case clscc_CourseEN.con_id_XzCollege:
return (a: clscc_CourseEN, b: clscc_CourseEN) => {
return a.id_XzCollege.localeCompare(b.id_XzCollege);
}
case clscc_CourseEN.con_UpdDate:
return (a: clscc_CourseEN, b: clscc_CourseEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clscc_CourseEN.con_UpdUserId:
return (a: clscc_CourseEN, b: clscc_CourseEN) => {
return a.updUserId.localeCompare(b.updUserId);
}
case clscc_CourseEN.con_Memo:
return (a: clscc_CourseEN, b: clscc_CourseEN) => {
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[cc_Course]中不存在！(in ${ cc_Course_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clscc_CourseEN.con_CourseId:
return (a: clscc_CourseEN, b: clscc_CourseEN) => {
return b.courseId.localeCompare(a.courseId);
}
case clscc_CourseEN.con_CourseCode:
return (a: clscc_CourseEN, b: clscc_CourseEN) => {
return b.courseCode.localeCompare(a.courseCode);
}
case clscc_CourseEN.con_CourseDescription:
return (a: clscc_CourseEN, b: clscc_CourseEN) => {
return b.courseDescription.localeCompare(a.courseDescription);
}
case clscc_CourseEN.con_CourseName:
return (a: clscc_CourseEN, b: clscc_CourseEN) => {
return b.courseName.localeCompare(a.courseName);
}
case clscc_CourseEN.con_CourseTypeID:
return (a: clscc_CourseEN, b: clscc_CourseEN) => {
return b.courseTypeID.localeCompare(a.courseTypeID);
}
case clscc_CourseEN.con_CreateDate:
return (a: clscc_CourseEN, b: clscc_CourseEN) => {
return b.createDate.localeCompare(a.createDate);
}
case clscc_CourseEN.con_ExcellentTypeId:
return (a: clscc_CourseEN, b: clscc_CourseEN) => {
return b.excellentTypeId.localeCompare(a.excellentTypeId);
}
case clscc_CourseEN.con_ExcellentYear:
return (a: clscc_CourseEN, b: clscc_CourseEN) => {
return b.excellentYear-a.excellentYear;
}
case clscc_CourseEN.con_IsBuildingCourse:
return (a: clscc_CourseEN, b: clscc_CourseEN) => {
if (b.isBuildingCourse == true) return 1;
else return -1
}
case clscc_CourseEN.con_IsDoubleLanguageCourse:
return (a: clscc_CourseEN, b: clscc_CourseEN) => {
if (b.isDoubleLanguageCourse == true) return 1;
else return -1
}
case clscc_CourseEN.con_IsOpen:
return (a: clscc_CourseEN, b: clscc_CourseEN) => {
if (b.isOpen == true) return 1;
else return -1
}
case clscc_CourseEN.con_IsRecommendedCourse:
return (a: clscc_CourseEN, b: clscc_CourseEN) => {
if (b.isRecommendedCourse == true) return 1;
else return -1
}
case clscc_CourseEN.con_IsSelfPropelledCourse:
return (a: clscc_CourseEN, b: clscc_CourseEN) => {
if (b.isSelfPropelledCourse == true) return 1;
else return -1
}
case clscc_CourseEN.con_OperationDate:
return (a: clscc_CourseEN, b: clscc_CourseEN) => {
return b.operationDate.localeCompare(a.operationDate);
}
case clscc_CourseEN.con_OrderNum:
return (a: clscc_CourseEN, b: clscc_CourseEN) => {
return b.orderNum-a.orderNum;
}
case clscc_CourseEN.con_OuterLink:
return (a: clscc_CourseEN, b: clscc_CourseEN) => {
return b.outerLink.localeCompare(a.outerLink);
}
case clscc_CourseEN.con_ViewCount:
return (a: clscc_CourseEN, b: clscc_CourseEN) => {
return b.viewCount-a.viewCount;
}
case clscc_CourseEN.con_ThemeId:
return (a: clscc_CourseEN, b: clscc_CourseEN) => {
return b.themeId.localeCompare(a.themeId);
}
case clscc_CourseEN.con_id_School:
return (a: clscc_CourseEN, b: clscc_CourseEN) => {
return b.id_School.localeCompare(a.id_School);
}
case clscc_CourseEN.con_id_XzMajor:
return (a: clscc_CourseEN, b: clscc_CourseEN) => {
return b.id_XzMajor.localeCompare(a.id_XzMajor);
}
case clscc_CourseEN.con_id_XzCollege:
return (a: clscc_CourseEN, b: clscc_CourseEN) => {
return b.id_XzCollege.localeCompare(a.id_XzCollege);
}
case clscc_CourseEN.con_UpdDate:
return (a: clscc_CourseEN, b: clscc_CourseEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clscc_CourseEN.con_UpdUserId:
return (a: clscc_CourseEN, b: clscc_CourseEN) => {
return b.updUserId.localeCompare(a.updUserId);
}
case clscc_CourseEN.con_Memo:
return (a: clscc_CourseEN, b: clscc_CourseEN) => {
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[cc_Course]中不存在！(in ${ cc_Course_ConstructorName}.${ strThisFuncName})`;
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
export async function cc_Course_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clscc_CourseEN.con_CourseId:
return (obj: clscc_CourseEN) => {
return obj.courseId === value;
}
case clscc_CourseEN.con_CourseCode:
return (obj: clscc_CourseEN) => {
return obj.courseCode === value;
}
case clscc_CourseEN.con_CourseDescription:
return (obj: clscc_CourseEN) => {
return obj.courseDescription === value;
}
case clscc_CourseEN.con_CourseName:
return (obj: clscc_CourseEN) => {
return obj.courseName === value;
}
case clscc_CourseEN.con_CourseTypeID:
return (obj: clscc_CourseEN) => {
return obj.courseTypeID === value;
}
case clscc_CourseEN.con_CreateDate:
return (obj: clscc_CourseEN) => {
return obj.createDate === value;
}
case clscc_CourseEN.con_ExcellentTypeId:
return (obj: clscc_CourseEN) => {
return obj.excellentTypeId === value;
}
case clscc_CourseEN.con_ExcellentYear:
return (obj: clscc_CourseEN) => {
return obj.excellentYear === value;
}
case clscc_CourseEN.con_IsBuildingCourse:
return (obj: clscc_CourseEN) => {
return obj.isBuildingCourse === value;
}
case clscc_CourseEN.con_IsDoubleLanguageCourse:
return (obj: clscc_CourseEN) => {
return obj.isDoubleLanguageCourse === value;
}
case clscc_CourseEN.con_IsOpen:
return (obj: clscc_CourseEN) => {
return obj.isOpen === value;
}
case clscc_CourseEN.con_IsRecommendedCourse:
return (obj: clscc_CourseEN) => {
return obj.isRecommendedCourse === value;
}
case clscc_CourseEN.con_IsSelfPropelledCourse:
return (obj: clscc_CourseEN) => {
return obj.isSelfPropelledCourse === value;
}
case clscc_CourseEN.con_OperationDate:
return (obj: clscc_CourseEN) => {
return obj.operationDate === value;
}
case clscc_CourseEN.con_OrderNum:
return (obj: clscc_CourseEN) => {
return obj.orderNum === value;
}
case clscc_CourseEN.con_OuterLink:
return (obj: clscc_CourseEN) => {
return obj.outerLink === value;
}
case clscc_CourseEN.con_ViewCount:
return (obj: clscc_CourseEN) => {
return obj.viewCount === value;
}
case clscc_CourseEN.con_ThemeId:
return (obj: clscc_CourseEN) => {
return obj.themeId === value;
}
case clscc_CourseEN.con_id_School:
return (obj: clscc_CourseEN) => {
return obj.id_School === value;
}
case clscc_CourseEN.con_id_XzMajor:
return (obj: clscc_CourseEN) => {
return obj.id_XzMajor === value;
}
case clscc_CourseEN.con_id_XzCollege:
return (obj: clscc_CourseEN) => {
return obj.id_XzCollege === value;
}
case clscc_CourseEN.con_UpdDate:
return (obj: clscc_CourseEN) => {
return obj.updDate === value;
}
case clscc_CourseEN.con_UpdUserId:
return (obj: clscc_CourseEN) => {
return obj.updUserId === value;
}
case clscc_CourseEN.con_Memo:
return (obj: clscc_CourseEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[cc_Course]中不存在！(in ${ cc_Course_ConstructorName}.${ strThisFuncName})`;
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
export async function cc_Course_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(cc_Course_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_Course_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_Course_ConstructorName, strThisFuncName);
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
export async function cc_Course_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(cc_Course_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_Course_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_Course_ConstructorName, strThisFuncName);
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
export async function cc_Course_GetFirstObjAsync(strWhereCond: string): Promise<clscc_CourseEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(cc_Course_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", cc_Course_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objcc_Course = cc_Course_GetObjFromJsonObj(returnObj);
return objcc_Course;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_Course_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_Course_ConstructorName, strThisFuncName);
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
export async function cc_Course_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clscc_CourseEN._CurrTabName;
clscc_CourseEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clscc_CourseEN._CurrTabName);
if (IsNullOrEmpty(clscc_CourseEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clscc_CourseEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrcc_CourseExObjLst_Cache: Array<clscc_CourseEN> = CacheHelper.Get(strKey);
const arrcc_CourseObjLst_T = cc_Course_GetObjLstByJSONObjLst(arrcc_CourseExObjLst_Cache);
return arrcc_CourseObjLst_T;
}
try
{
const arrcc_CourseExObjLst = await cc_Course_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrcc_CourseExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrcc_CourseExObjLst.length);
console.log(strInfo);
return arrcc_CourseExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, cc_Course_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function cc_Course_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clscc_CourseEN._CurrTabName;
clscc_CourseEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clscc_CourseEN._CurrTabName);
if (IsNullOrEmpty(clscc_CourseEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clscc_CourseEN.CacheAddiCondition);
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
const arrcc_CourseExObjLst_Cache: Array<clscc_CourseEN> = JSON.parse(strTempObjLst);
const arrcc_CourseObjLst_T = cc_Course_GetObjLstByJSONObjLst(arrcc_CourseExObjLst_Cache);
return arrcc_CourseObjLst_T;
}
try
{
const arrcc_CourseExObjLst = await cc_Course_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrcc_CourseExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrcc_CourseExObjLst.length);
console.log(strInfo);
return arrcc_CourseExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, cc_Course_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function cc_Course_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clscc_CourseEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrcc_CourseObjLst_Cache: Array<clscc_CourseEN> = JSON.parse(strTempObjLst);
return arrcc_CourseObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function cc_Course_GetObjLstAsync(strWhereCond: string): Promise<Array<clscc_CourseEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(cc_Course_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", cc_Course_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = cc_Course_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_Course_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_Course_ConstructorName, strThisFuncName);
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
export async function cc_Course_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clscc_CourseEN._CurrTabName;
clscc_CourseEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clscc_CourseEN._CurrTabName);
if (IsNullOrEmpty(clscc_CourseEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clscc_CourseEN.CacheAddiCondition);
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
const arrcc_CourseExObjLst_Cache: Array<clscc_CourseEN> = JSON.parse(strTempObjLst);
const arrcc_CourseObjLst_T = cc_Course_GetObjLstByJSONObjLst(arrcc_CourseExObjLst_Cache);
return arrcc_CourseObjLst_T;
}
try
{
const arrcc_CourseExObjLst = await cc_Course_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrcc_CourseExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrcc_CourseExObjLst.length);
console.log(strInfo);
return arrcc_CourseExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, cc_Course_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function cc_Course_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clscc_CourseEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrcc_CourseObjLst_Cache: Array<clscc_CourseEN> = JSON.parse(strTempObjLst);
return arrcc_CourseObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function cc_Course_GetObjLst_Cache(): Promise<Array<clscc_CourseEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrcc_CourseObjLst_Cache;
switch (clscc_CourseEN.CacheModeId)
{
case "04"://sessionStorage
arrcc_CourseObjLst_Cache = await cc_Course_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrcc_CourseObjLst_Cache = await cc_Course_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrcc_CourseObjLst_Cache = await cc_Course_GetObjLst_ClientCache();
break;
default:
arrcc_CourseObjLst_Cache = await cc_Course_GetObjLst_ClientCache();
break;
}
const arrcc_CourseObjLst = cc_Course_GetObjLstByJSONObjLst(arrcc_CourseObjLst_Cache);
return arrcc_CourseObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function cc_Course_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrcc_CourseObjLst_Cache;
switch (clscc_CourseEN.CacheModeId)
{
case "04"://sessionStorage
arrcc_CourseObjLst_Cache = await cc_Course_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrcc_CourseObjLst_Cache = await cc_Course_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrcc_CourseObjLst_Cache = null;
break;
default:
arrcc_CourseObjLst_Cache = null;
break;
}
return arrcc_CourseObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrCourseId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function cc_Course_GetSubObjLst_Cache(objcc_Course_Cond: clscc_CourseEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrcc_CourseObjLst_Cache = await cc_Course_GetObjLst_Cache();
let arrcc_Course_Sel: Array < clscc_CourseEN > = arrcc_CourseObjLst_Cache;
if (objcc_Course_Cond.sf_FldComparisonOp == null || objcc_Course_Cond.sf_FldComparisonOp == "") return arrcc_Course_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objcc_Course_Cond.sf_FldComparisonOp);
//console.log("clscc_CourseWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objcc_Course_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objcc_Course_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrcc_Course_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objcc_Course_Cond), cc_Course_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clscc_CourseEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrCourseId:关键字列表
 * @returns 对象列表
 **/
export async function cc_Course_GetObjLstByCourseIdLstAsync(arrCourseId: Array<string>): Promise<Array<clscc_CourseEN>>  
{
const strThisFuncName = "GetObjLstByCourseIdLstAsync";
const strAction = "GetObjLstByCourseIdLst";
const strUrl = GetWebApiUrl(cc_Course_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrCourseId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", cc_Course_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = cc_Course_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_Course_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_Course_ConstructorName, strThisFuncName);
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
 * @param arrstrCourseIdLst:关键字列表
 * @returns 对象列表
*/
export async function cc_Course_GetObjLstByCourseIdLst_Cache(arrCourseIdLst: Array<string>) {
const strThisFuncName = "GetObjLstByCourseIdLst_Cache";
try
{
const arrcc_CourseObjLst_Cache = await cc_Course_GetObjLst_Cache();
const arrcc_Course_Sel: Array <clscc_CourseEN> = arrcc_CourseObjLst_Cache.filter(x => arrCourseIdLst.indexOf(x.courseId)>-1);
return arrcc_Course_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrCourseIdLst.join(","), cc_Course_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clscc_CourseEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function cc_Course_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clscc_CourseEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(cc_Course_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", cc_Course_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = cc_Course_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_Course_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_Course_ConstructorName, strThisFuncName);
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
export async function cc_Course_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clscc_CourseEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(cc_Course_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", cc_Course_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = cc_Course_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_Course_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_Course_ConstructorName, strThisFuncName);
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
export async function cc_Course_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(cc_Course_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_Course_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_Course_ConstructorName, strThisFuncName);
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
export async function cc_Course_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrcc_CourseObjLst_Cache = await cc_Course_GetObjLst_Cache();
if (arrcc_CourseObjLst_Cache.length == 0) return arrcc_CourseObjLst_Cache;
let arrcc_Course_Sel = arrcc_CourseObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objcc_Course_Cond = new clscc_CourseEN();
ObjectAssign(objcc_Course_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clscc_CourseWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objcc_Course_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrcc_Course_Sel = arrcc_Course_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrcc_Course_Sel.length == 0) return arrcc_Course_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrcc_Course_Sel = arrcc_Course_Sel.sort(cc_Course_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrcc_Course_Sel = arrcc_Course_Sel.sort(objPagerPara.sortFun);
}
arrcc_Course_Sel = arrcc_Course_Sel.slice(intStart, intEnd);     
return arrcc_Course_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, cc_Course_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clscc_CourseEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function cc_Course_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clscc_CourseEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(cc_Course_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", cc_Course_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = cc_Course_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_Course_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_Course_ConstructorName, strThisFuncName);
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
 * @param strCourseId:关键字
 * @returns 获取删除的结果
 **/
export async function cc_Course_DelRecordAsync(strCourseId: string): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(cc_Course_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, strCourseId);
try
{
const response = await axios.delete(strUrl,
{
params: { "Id": strCourseId, }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_Course_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_Course_ConstructorName, strThisFuncName);
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
 * @param arrCourseId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function cc_Course_Delcc_CoursesAsync(arrCourseId: Array<string>): Promise<number> 
{
const strThisFuncName = "Delcc_CoursesAsync";
const strAction = "Delcc_Courses";
const strUrl = GetWebApiUrl(cc_Course_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrCourseId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_Course_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_Course_ConstructorName, strThisFuncName);
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
export async function cc_Course_Delcc_CoursesByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "Delcc_CoursesByCondAsync";
const strAction = "Delcc_CoursesByCond";
const strUrl = GetWebApiUrl(cc_Course_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_Course_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_Course_ConstructorName, strThisFuncName);
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
 * @param objcc_CourseEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function cc_Course_AddNewRecordAsync(objcc_CourseEN: clscc_CourseEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objcc_CourseEN);
const strUrl = GetWebApiUrl(cc_Course_Controller, strAction);
try
{
const response = await axios.post(strUrl, objcc_CourseEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_Course_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_Course_ConstructorName, strThisFuncName);
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
 * @param objcc_CourseEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function cc_Course_AddNewRecordWithMaxIdAsync(objcc_CourseEN: clscc_CourseEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithMaxIdAsync";
const strAction = "AddNewRecordWithMaxId";
const strUrl = GetWebApiUrl(cc_Course_Controller, strAction);
try
{
const response = await axios.post(strUrl, objcc_CourseEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_Course_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_Course_ConstructorName, strThisFuncName);
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
 * @param objcc_CourseEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function cc_Course_AddNewRecordWithReturnKeyAsync(objcc_CourseEN: clscc_CourseEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(cc_Course_Controller, strAction);
try
{
const response = await axios.post(strUrl, objcc_CourseEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_Course_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_Course_ConstructorName, strThisFuncName);
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
 * @param objcc_CourseEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function cc_Course_AddNewRecordWithReturnKey(objcc_CourseEN: clscc_CourseEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objcc_CourseEN.courseId === null || objcc_CourseEN.courseId === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(cc_Course_Controller, strAction);
try
{
const response = await axios.post(strUrl, objcc_CourseEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_Course_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_Course_ConstructorName, strThisFuncName);
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
 * @param objcc_CourseEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function cc_Course_UpdateRecordAsync(objcc_CourseEN: clscc_CourseEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objcc_CourseEN.sf_UpdFldSetStr === undefined || objcc_CourseEN.sf_UpdFldSetStr === null || objcc_CourseEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objcc_CourseEN.courseId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(cc_Course_Controller, strAction);
try
{
const response = await axios.post(strUrl, objcc_CourseEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_Course_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_Course_ConstructorName, strThisFuncName);
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
 * @param objcc_CourseEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function cc_Course_UpdateWithConditionAsync(objcc_CourseEN: clscc_CourseEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objcc_CourseEN.sf_UpdFldSetStr === undefined || objcc_CourseEN.sf_UpdFldSetStr === null || objcc_CourseEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objcc_CourseEN.courseId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(cc_Course_Controller, strAction);
objcc_CourseEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objcc_CourseEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_Course_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_Course_ConstructorName, strThisFuncName);
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
 * @param objstrCourseId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function cc_Course_IsExistRecord_Cache(objcc_Course_Cond: clscc_CourseEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrcc_CourseObjLst_Cache = await cc_Course_GetObjLst_Cache();
if (arrcc_CourseObjLst_Cache == null) return false;
let arrcc_Course_Sel: Array < clscc_CourseEN > = arrcc_CourseObjLst_Cache;
if (objcc_Course_Cond.sf_FldComparisonOp == null || objcc_Course_Cond.sf_FldComparisonOp == "") return arrcc_Course_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objcc_Course_Cond.sf_FldComparisonOp);
//console.log("clscc_CourseWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objcc_Course_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objcc_Course_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrcc_Course_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objcc_Course_Cond), cc_Course_ConstructorName, strThisFuncName);
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
export async function cc_Course_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(cc_Course_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_Course_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_Course_ConstructorName, strThisFuncName);
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
 * @param strCourseId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function cc_Course_IsExist(strCourseId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(cc_Course_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"CourseId": strCourseId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_Course_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_Course_ConstructorName, strThisFuncName);
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
 * @param strCourseId:所给的关键字
 * @returns 对象
*/
export async function cc_Course_IsExist_Cache(strCourseId:string) {
const strThisFuncName = "IsExist_Cache";
const arrcc_CourseObjLst_Cache = await cc_Course_GetObjLst_Cache();
if (arrcc_CourseObjLst_Cache == null) return false;
try
{
const arrcc_Course_Sel: Array <clscc_CourseEN> = arrcc_CourseObjLst_Cache.filter(x => x.courseId == strCourseId);
if (arrcc_Course_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strCourseId, cc_Course_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param strCourseId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function cc_Course_IsExistAsync(strCourseId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(cc_Course_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strCourseId": strCourseId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_Course_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_Course_ConstructorName, strThisFuncName);
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
export async function cc_Course_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(cc_Course_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_Course_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_Course_ConstructorName, strThisFuncName);
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
 * @param objcc_Course_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function cc_Course_GetRecCountByCond_Cache(objcc_Course_Cond: clscc_CourseEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrcc_CourseObjLst_Cache = await cc_Course_GetObjLst_Cache();
if (arrcc_CourseObjLst_Cache == null) return 0;
let arrcc_Course_Sel: Array < clscc_CourseEN > = arrcc_CourseObjLst_Cache;
if (objcc_Course_Cond.sf_FldComparisonOp == null || objcc_Course_Cond.sf_FldComparisonOp == "") return arrcc_Course_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objcc_Course_Cond.sf_FldComparisonOp);
//console.log("clscc_CourseWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objcc_Course_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objcc_Course_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrcc_Course_Sel = arrcc_Course_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrcc_Course_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objcc_Course_Cond), cc_Course_ConstructorName, strThisFuncName);
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
export async function cc_Course_GetMaxStrIdAsync(): Promise<string>  
{
const strThisFuncName = "GetMaxStrIdAsync";
const strAction = "GetMaxStrId";
const strUrl = GetWebApiUrl(cc_Course_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_Course_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_Course_ConstructorName, strThisFuncName);
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
export async function cc_Course_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(cc_Course_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, cc_Course_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, cc_Course_ConstructorName, strThisFuncName);
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
export function cc_Course_GetWebApiUrl(strController: string, strAction: string): string {
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
export function cc_Course_ReFreshCache():void
{
const strThisFuncName = "ReFreshCache";

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = clscc_CourseEN._CurrTabName;
switch (clscc_CourseEN.CacheModeId)
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
export function cc_Course_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clscc_CourseEN._CurrTabName;
switch (clscc_CourseEN.CacheModeId)
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
export async function cc_Course__Cache(strDivName: string, strDdlName: string )
{
const strThisFuncName = "_Cache";

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
const arrObjLst_Sel = await cc_Course_GetObjLst_Cache();
if (arrObjLst_Sel == null) return;
BindDdl_ObjLstInDiv(strDivName, strDdlName, arrObjLst_Sel, clscc_CourseEN.con_CourseId, clscc_CourseEN.con_CourseName, "课程");
}

/**
 * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function cc_Course_CheckPropertyNew(pobjcc_CourseEN: clscc_CourseEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjcc_CourseEN.courseName) === true )
{
 throw new Error("(errid:Watl000058)字段[课程名称]不能为空(In 课程)!(clscc_CourseBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjcc_CourseEN.courseId) == false && GetStrLen(pobjcc_CourseEN.courseId) > 8)
{
 throw new Error("(errid:Watl000059)字段[课程Id(courseId)]的长度不能超过8(In 课程(cc_Course))!值:$(pobjcc_CourseEN.courseId)(clscc_CourseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_CourseEN.courseCode) == false && GetStrLen(pobjcc_CourseEN.courseCode) > 20)
{
 throw new Error("(errid:Watl000059)字段[课程代码(courseCode)]的长度不能超过20(In 课程(cc_Course))!值:$(pobjcc_CourseEN.courseCode)(clscc_CourseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_CourseEN.courseDescription) == false && GetStrLen(pobjcc_CourseEN.courseDescription) > 8000)
{
 throw new Error("(errid:Watl000059)字段[课程描述(courseDescription)]的长度不能超过8000(In 课程(cc_Course))!值:$(pobjcc_CourseEN.courseDescription)(clscc_CourseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_CourseEN.courseName) == false && GetStrLen(pobjcc_CourseEN.courseName) > 100)
{
 throw new Error("(errid:Watl000059)字段[课程名称(courseName)]的长度不能超过100(In 课程(cc_Course))!值:$(pobjcc_CourseEN.courseName)(clscc_CourseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_CourseEN.courseTypeID) == false && GetStrLen(pobjcc_CourseEN.courseTypeID) > 4)
{
 throw new Error("(errid:Watl000059)字段[课程类型ID(courseTypeID)]的长度不能超过4(In 课程(cc_Course))!值:$(pobjcc_CourseEN.courseTypeID)(clscc_CourseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_CourseEN.createDate) == false && GetStrLen(pobjcc_CourseEN.createDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[建立日期(createDate)]的长度不能超过20(In 课程(cc_Course))!值:$(pobjcc_CourseEN.createDate)(clscc_CourseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_CourseEN.excellentTypeId) == false && GetStrLen(pobjcc_CourseEN.excellentTypeId) > 4)
{
 throw new Error("(errid:Watl000059)字段[精品课程类型Id(excellentTypeId)]的长度不能超过4(In 课程(cc_Course))!值:$(pobjcc_CourseEN.excellentTypeId)(clscc_CourseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_CourseEN.operationDate) == false && GetStrLen(pobjcc_CourseEN.operationDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[操作时间(operationDate)]的长度不能超过20(In 课程(cc_Course))!值:$(pobjcc_CourseEN.operationDate)(clscc_CourseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_CourseEN.outerLink) == false && GetStrLen(pobjcc_CourseEN.outerLink) > 500)
{
 throw new Error("(errid:Watl000059)字段[外链地址(outerLink)]的长度不能超过500(In 课程(cc_Course))!值:$(pobjcc_CourseEN.outerLink)(clscc_CourseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_CourseEN.themeId) == false && GetStrLen(pobjcc_CourseEN.themeId) > 4)
{
 throw new Error("(errid:Watl000059)字段[主题Id(themeId)]的长度不能超过4(In 课程(cc_Course))!值:$(pobjcc_CourseEN.themeId)(clscc_CourseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_CourseEN.id_School) == false && GetStrLen(pobjcc_CourseEN.id_School) > 4)
{
 throw new Error("(errid:Watl000059)字段[学校流水号(id_School)]的长度不能超过4(In 课程(cc_Course))!值:$(pobjcc_CourseEN.id_School)(clscc_CourseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_CourseEN.id_XzMajor) == false && GetStrLen(pobjcc_CourseEN.id_XzMajor) > 8)
{
 throw new Error("(errid:Watl000059)字段[专业流水号(id_XzMajor)]的长度不能超过8(In 课程(cc_Course))!值:$(pobjcc_CourseEN.id_XzMajor)(clscc_CourseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_CourseEN.id_XzCollege) == false && GetStrLen(pobjcc_CourseEN.id_XzCollege) > 4)
{
 throw new Error("(errid:Watl000059)字段[学院流水号(id_XzCollege)]的长度不能超过4(In 课程(cc_Course))!值:$(pobjcc_CourseEN.id_XzCollege)(clscc_CourseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_CourseEN.updDate) == false && GetStrLen(pobjcc_CourseEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 课程(cc_Course))!值:$(pobjcc_CourseEN.updDate)(clscc_CourseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_CourseEN.updUserId) == false && GetStrLen(pobjcc_CourseEN.updUserId) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改用户Id(updUserId)]的长度不能超过20(In 课程(cc_Course))!值:$(pobjcc_CourseEN.updUserId)(clscc_CourseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_CourseEN.memo) == false && GetStrLen(pobjcc_CourseEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 课程(cc_Course))!值:$(pobjcc_CourseEN.memo)(clscc_CourseBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjcc_CourseEN.courseId) == false && undefined !== pobjcc_CourseEN.courseId && tzDataType.isString(pobjcc_CourseEN.courseId) === false)
{
 throw new Error("(errid:Watl000060)字段[课程Id(courseId)]的值:[$(pobjcc_CourseEN.courseId)], 非法，应该为字符型(In 课程(cc_Course))!(clscc_CourseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_CourseEN.courseCode) == false && undefined !== pobjcc_CourseEN.courseCode && tzDataType.isString(pobjcc_CourseEN.courseCode) === false)
{
 throw new Error("(errid:Watl000060)字段[课程代码(courseCode)]的值:[$(pobjcc_CourseEN.courseCode)], 非法，应该为字符型(In 课程(cc_Course))!(clscc_CourseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_CourseEN.courseDescription) == false && undefined !== pobjcc_CourseEN.courseDescription && tzDataType.isString(pobjcc_CourseEN.courseDescription) === false)
{
 throw new Error("(errid:Watl000060)字段[课程描述(courseDescription)]的值:[$(pobjcc_CourseEN.courseDescription)], 非法，应该为字符型(In 课程(cc_Course))!(clscc_CourseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_CourseEN.courseName) == false && undefined !== pobjcc_CourseEN.courseName && tzDataType.isString(pobjcc_CourseEN.courseName) === false)
{
 throw new Error("(errid:Watl000060)字段[课程名称(courseName)]的值:[$(pobjcc_CourseEN.courseName)], 非法，应该为字符型(In 课程(cc_Course))!(clscc_CourseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_CourseEN.courseTypeID) == false && undefined !== pobjcc_CourseEN.courseTypeID && tzDataType.isString(pobjcc_CourseEN.courseTypeID) === false)
{
 throw new Error("(errid:Watl000060)字段[课程类型ID(courseTypeID)]的值:[$(pobjcc_CourseEN.courseTypeID)], 非法，应该为字符型(In 课程(cc_Course))!(clscc_CourseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_CourseEN.createDate) == false && undefined !== pobjcc_CourseEN.createDate && tzDataType.isString(pobjcc_CourseEN.createDate) === false)
{
 throw new Error("(errid:Watl000060)字段[建立日期(createDate)]的值:[$(pobjcc_CourseEN.createDate)], 非法，应该为字符型(In 课程(cc_Course))!(clscc_CourseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_CourseEN.excellentTypeId) == false && undefined !== pobjcc_CourseEN.excellentTypeId && tzDataType.isString(pobjcc_CourseEN.excellentTypeId) === false)
{
 throw new Error("(errid:Watl000060)字段[精品课程类型Id(excellentTypeId)]的值:[$(pobjcc_CourseEN.excellentTypeId)], 非法，应该为字符型(In 课程(cc_Course))!(clscc_CourseBL:CheckPropertyNew)");
}
if (null != pobjcc_CourseEN.excellentYear && undefined !== pobjcc_CourseEN.excellentYear && tzDataType.isNumber(pobjcc_CourseEN.excellentYear) === false)
{
 throw new Error("(errid:Watl000060)字段[课程年份(excellentYear)]的值:[$(pobjcc_CourseEN.excellentYear)], 非法，应该为数值型(In 课程(cc_Course))!(clscc_CourseBL:CheckPropertyNew)");
}
if (null != pobjcc_CourseEN.isBuildingCourse && undefined !== pobjcc_CourseEN.isBuildingCourse && tzDataType.isBoolean(pobjcc_CourseEN.isBuildingCourse) === false)
{
 throw new Error("(errid:Watl000060)字段[是否已建设课程(isBuildingCourse)]的值:[$(pobjcc_CourseEN.isBuildingCourse)], 非法，应该为布尔型(In 课程(cc_Course))!(clscc_CourseBL:CheckPropertyNew)");
}
if (null != pobjcc_CourseEN.isDoubleLanguageCourse && undefined !== pobjcc_CourseEN.isDoubleLanguageCourse && tzDataType.isBoolean(pobjcc_CourseEN.isDoubleLanguageCourse) === false)
{
 throw new Error("(errid:Watl000060)字段[是否双语课程(isDoubleLanguageCourse)]的值:[$(pobjcc_CourseEN.isDoubleLanguageCourse)], 非法，应该为布尔型(In 课程(cc_Course))!(clscc_CourseBL:CheckPropertyNew)");
}
if (null != pobjcc_CourseEN.isOpen && undefined !== pobjcc_CourseEN.isOpen && tzDataType.isBoolean(pobjcc_CourseEN.isOpen) === false)
{
 throw new Error("(errid:Watl000060)字段[是否公开(isOpen)]的值:[$(pobjcc_CourseEN.isOpen)], 非法，应该为布尔型(In 课程(cc_Course))!(clscc_CourseBL:CheckPropertyNew)");
}
if (null != pobjcc_CourseEN.isRecommendedCourse && undefined !== pobjcc_CourseEN.isRecommendedCourse && tzDataType.isBoolean(pobjcc_CourseEN.isRecommendedCourse) === false)
{
 throw new Error("(errid:Watl000060)字段[是否推荐课程(isRecommendedCourse)]的值:[$(pobjcc_CourseEN.isRecommendedCourse)], 非法，应该为布尔型(In 课程(cc_Course))!(clscc_CourseBL:CheckPropertyNew)");
}
if (null != pobjcc_CourseEN.isSelfPropelledCourse && undefined !== pobjcc_CourseEN.isSelfPropelledCourse && tzDataType.isBoolean(pobjcc_CourseEN.isSelfPropelledCourse) === false)
{
 throw new Error("(errid:Watl000060)字段[是否自荐课程(isSelfPropelledCourse)]的值:[$(pobjcc_CourseEN.isSelfPropelledCourse)], 非法，应该为布尔型(In 课程(cc_Course))!(clscc_CourseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_CourseEN.operationDate) == false && undefined !== pobjcc_CourseEN.operationDate && tzDataType.isString(pobjcc_CourseEN.operationDate) === false)
{
 throw new Error("(errid:Watl000060)字段[操作时间(operationDate)]的值:[$(pobjcc_CourseEN.operationDate)], 非法，应该为字符型(In 课程(cc_Course))!(clscc_CourseBL:CheckPropertyNew)");
}
if (null != pobjcc_CourseEN.orderNum && undefined !== pobjcc_CourseEN.orderNum && tzDataType.isNumber(pobjcc_CourseEN.orderNum) === false)
{
 throw new Error("(errid:Watl000060)字段[序号(orderNum)]的值:[$(pobjcc_CourseEN.orderNum)], 非法，应该为数值型(In 课程(cc_Course))!(clscc_CourseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_CourseEN.outerLink) == false && undefined !== pobjcc_CourseEN.outerLink && tzDataType.isString(pobjcc_CourseEN.outerLink) === false)
{
 throw new Error("(errid:Watl000060)字段[外链地址(outerLink)]的值:[$(pobjcc_CourseEN.outerLink)], 非法，应该为字符型(In 课程(cc_Course))!(clscc_CourseBL:CheckPropertyNew)");
}
if (null != pobjcc_CourseEN.viewCount && undefined !== pobjcc_CourseEN.viewCount && tzDataType.isNumber(pobjcc_CourseEN.viewCount) === false)
{
 throw new Error("(errid:Watl000060)字段[浏览量(viewCount)]的值:[$(pobjcc_CourseEN.viewCount)], 非法，应该为数值型(In 课程(cc_Course))!(clscc_CourseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_CourseEN.themeId) == false && undefined !== pobjcc_CourseEN.themeId && tzDataType.isString(pobjcc_CourseEN.themeId) === false)
{
 throw new Error("(errid:Watl000060)字段[主题Id(themeId)]的值:[$(pobjcc_CourseEN.themeId)], 非法，应该为字符型(In 课程(cc_Course))!(clscc_CourseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_CourseEN.id_School) == false && undefined !== pobjcc_CourseEN.id_School && tzDataType.isString(pobjcc_CourseEN.id_School) === false)
{
 throw new Error("(errid:Watl000060)字段[学校流水号(id_School)]的值:[$(pobjcc_CourseEN.id_School)], 非法，应该为字符型(In 课程(cc_Course))!(clscc_CourseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_CourseEN.id_XzMajor) == false && undefined !== pobjcc_CourseEN.id_XzMajor && tzDataType.isString(pobjcc_CourseEN.id_XzMajor) === false)
{
 throw new Error("(errid:Watl000060)字段[专业流水号(id_XzMajor)]的值:[$(pobjcc_CourseEN.id_XzMajor)], 非法，应该为字符型(In 课程(cc_Course))!(clscc_CourseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_CourseEN.id_XzCollege) == false && undefined !== pobjcc_CourseEN.id_XzCollege && tzDataType.isString(pobjcc_CourseEN.id_XzCollege) === false)
{
 throw new Error("(errid:Watl000060)字段[学院流水号(id_XzCollege)]的值:[$(pobjcc_CourseEN.id_XzCollege)], 非法，应该为字符型(In 课程(cc_Course))!(clscc_CourseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_CourseEN.updDate) == false && undefined !== pobjcc_CourseEN.updDate && tzDataType.isString(pobjcc_CourseEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjcc_CourseEN.updDate)], 非法，应该为字符型(In 课程(cc_Course))!(clscc_CourseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_CourseEN.updUserId) == false && undefined !== pobjcc_CourseEN.updUserId && tzDataType.isString(pobjcc_CourseEN.updUserId) === false)
{
 throw new Error("(errid:Watl000060)字段[修改用户Id(updUserId)]的值:[$(pobjcc_CourseEN.updUserId)], 非法，应该为字符型(In 课程(cc_Course))!(clscc_CourseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_CourseEN.memo) == false && undefined !== pobjcc_CourseEN.memo && tzDataType.isString(pobjcc_CourseEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjcc_CourseEN.memo)], 非法，应该为字符型(In 课程(cc_Course))!(clscc_CourseBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
if (IsNullOrEmpty(pobjcc_CourseEN.courseTypeID) == false && GetStrLen(pobjcc_CourseEN.courseTypeID) !=  4)
{
 throw ("(errid:Watl000061)字段[课程类型ID]作为外键字段,长度应该为4(In 课程)!(clscc_CourseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_CourseEN.excellentTypeId) == false && GetStrLen(pobjcc_CourseEN.excellentTypeId) !=  4)
{
 throw ("(errid:Watl000061)字段[精品课程类型Id]作为外键字段,长度应该为4(In 课程)!(clscc_CourseBL:CheckPropertyNew)");
}

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjcc_CourseEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function cc_Course_CheckProperty4Update (pobjcc_CourseEN: clscc_CourseEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjcc_CourseEN.courseId) == false && GetStrLen(pobjcc_CourseEN.courseId) > 8)
{
 throw new Error("(errid:Watl000062)字段[课程Id(courseId)]的长度不能超过8(In 课程(cc_Course))!值:$(pobjcc_CourseEN.courseId)(clscc_CourseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjcc_CourseEN.courseCode) == false && GetStrLen(pobjcc_CourseEN.courseCode) > 20)
{
 throw new Error("(errid:Watl000062)字段[课程代码(courseCode)]的长度不能超过20(In 课程(cc_Course))!值:$(pobjcc_CourseEN.courseCode)(clscc_CourseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjcc_CourseEN.courseDescription) == false && GetStrLen(pobjcc_CourseEN.courseDescription) > 8000)
{
 throw new Error("(errid:Watl000062)字段[课程描述(courseDescription)]的长度不能超过8000(In 课程(cc_Course))!值:$(pobjcc_CourseEN.courseDescription)(clscc_CourseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjcc_CourseEN.courseName) == false && GetStrLen(pobjcc_CourseEN.courseName) > 100)
{
 throw new Error("(errid:Watl000062)字段[课程名称(courseName)]的长度不能超过100(In 课程(cc_Course))!值:$(pobjcc_CourseEN.courseName)(clscc_CourseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjcc_CourseEN.courseTypeID) == false && GetStrLen(pobjcc_CourseEN.courseTypeID) > 4)
{
 throw new Error("(errid:Watl000062)字段[课程类型ID(courseTypeID)]的长度不能超过4(In 课程(cc_Course))!值:$(pobjcc_CourseEN.courseTypeID)(clscc_CourseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjcc_CourseEN.createDate) == false && GetStrLen(pobjcc_CourseEN.createDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[建立日期(createDate)]的长度不能超过20(In 课程(cc_Course))!值:$(pobjcc_CourseEN.createDate)(clscc_CourseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjcc_CourseEN.excellentTypeId) == false && GetStrLen(pobjcc_CourseEN.excellentTypeId) > 4)
{
 throw new Error("(errid:Watl000062)字段[精品课程类型Id(excellentTypeId)]的长度不能超过4(In 课程(cc_Course))!值:$(pobjcc_CourseEN.excellentTypeId)(clscc_CourseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjcc_CourseEN.operationDate) == false && GetStrLen(pobjcc_CourseEN.operationDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[操作时间(operationDate)]的长度不能超过20(In 课程(cc_Course))!值:$(pobjcc_CourseEN.operationDate)(clscc_CourseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjcc_CourseEN.outerLink) == false && GetStrLen(pobjcc_CourseEN.outerLink) > 500)
{
 throw new Error("(errid:Watl000062)字段[外链地址(outerLink)]的长度不能超过500(In 课程(cc_Course))!值:$(pobjcc_CourseEN.outerLink)(clscc_CourseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjcc_CourseEN.themeId) == false && GetStrLen(pobjcc_CourseEN.themeId) > 4)
{
 throw new Error("(errid:Watl000062)字段[主题Id(themeId)]的长度不能超过4(In 课程(cc_Course))!值:$(pobjcc_CourseEN.themeId)(clscc_CourseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjcc_CourseEN.id_School) == false && GetStrLen(pobjcc_CourseEN.id_School) > 4)
{
 throw new Error("(errid:Watl000062)字段[学校流水号(id_School)]的长度不能超过4(In 课程(cc_Course))!值:$(pobjcc_CourseEN.id_School)(clscc_CourseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjcc_CourseEN.id_XzMajor) == false && GetStrLen(pobjcc_CourseEN.id_XzMajor) > 8)
{
 throw new Error("(errid:Watl000062)字段[专业流水号(id_XzMajor)]的长度不能超过8(In 课程(cc_Course))!值:$(pobjcc_CourseEN.id_XzMajor)(clscc_CourseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjcc_CourseEN.id_XzCollege) == false && GetStrLen(pobjcc_CourseEN.id_XzCollege) > 4)
{
 throw new Error("(errid:Watl000062)字段[学院流水号(id_XzCollege)]的长度不能超过4(In 课程(cc_Course))!值:$(pobjcc_CourseEN.id_XzCollege)(clscc_CourseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjcc_CourseEN.updDate) == false && GetStrLen(pobjcc_CourseEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 课程(cc_Course))!值:$(pobjcc_CourseEN.updDate)(clscc_CourseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjcc_CourseEN.updUserId) == false && GetStrLen(pobjcc_CourseEN.updUserId) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改用户Id(updUserId)]的长度不能超过20(In 课程(cc_Course))!值:$(pobjcc_CourseEN.updUserId)(clscc_CourseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjcc_CourseEN.memo) == false && GetStrLen(pobjcc_CourseEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 课程(cc_Course))!值:$(pobjcc_CourseEN.memo)(clscc_CourseBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjcc_CourseEN.courseId) == false && undefined !== pobjcc_CourseEN.courseId && tzDataType.isString(pobjcc_CourseEN.courseId) === false)
{
 throw new Error("(errid:Watl000063)字段[课程Id(courseId)]的值:[$(pobjcc_CourseEN.courseId)], 非法，应该为字符型(In 课程(cc_Course))!(clscc_CourseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjcc_CourseEN.courseCode) == false && undefined !== pobjcc_CourseEN.courseCode && tzDataType.isString(pobjcc_CourseEN.courseCode) === false)
{
 throw new Error("(errid:Watl000063)字段[课程代码(courseCode)]的值:[$(pobjcc_CourseEN.courseCode)], 非法，应该为字符型(In 课程(cc_Course))!(clscc_CourseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjcc_CourseEN.courseDescription) == false && undefined !== pobjcc_CourseEN.courseDescription && tzDataType.isString(pobjcc_CourseEN.courseDescription) === false)
{
 throw new Error("(errid:Watl000063)字段[课程描述(courseDescription)]的值:[$(pobjcc_CourseEN.courseDescription)], 非法，应该为字符型(In 课程(cc_Course))!(clscc_CourseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjcc_CourseEN.courseName) == false && undefined !== pobjcc_CourseEN.courseName && tzDataType.isString(pobjcc_CourseEN.courseName) === false)
{
 throw new Error("(errid:Watl000063)字段[课程名称(courseName)]的值:[$(pobjcc_CourseEN.courseName)], 非法，应该为字符型(In 课程(cc_Course))!(clscc_CourseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjcc_CourseEN.courseTypeID) == false && undefined !== pobjcc_CourseEN.courseTypeID && tzDataType.isString(pobjcc_CourseEN.courseTypeID) === false)
{
 throw new Error("(errid:Watl000063)字段[课程类型ID(courseTypeID)]的值:[$(pobjcc_CourseEN.courseTypeID)], 非法，应该为字符型(In 课程(cc_Course))!(clscc_CourseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjcc_CourseEN.createDate) == false && undefined !== pobjcc_CourseEN.createDate && tzDataType.isString(pobjcc_CourseEN.createDate) === false)
{
 throw new Error("(errid:Watl000063)字段[建立日期(createDate)]的值:[$(pobjcc_CourseEN.createDate)], 非法，应该为字符型(In 课程(cc_Course))!(clscc_CourseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjcc_CourseEN.excellentTypeId) == false && undefined !== pobjcc_CourseEN.excellentTypeId && tzDataType.isString(pobjcc_CourseEN.excellentTypeId) === false)
{
 throw new Error("(errid:Watl000063)字段[精品课程类型Id(excellentTypeId)]的值:[$(pobjcc_CourseEN.excellentTypeId)], 非法，应该为字符型(In 课程(cc_Course))!(clscc_CourseBL:CheckProperty4Update)");
}
if (null != pobjcc_CourseEN.excellentYear && undefined !== pobjcc_CourseEN.excellentYear && tzDataType.isNumber(pobjcc_CourseEN.excellentYear) === false)
{
 throw new Error("(errid:Watl000063)字段[课程年份(excellentYear)]的值:[$(pobjcc_CourseEN.excellentYear)], 非法，应该为数值型(In 课程(cc_Course))!(clscc_CourseBL:CheckProperty4Update)");
}
if (null != pobjcc_CourseEN.isBuildingCourse && undefined !== pobjcc_CourseEN.isBuildingCourse && tzDataType.isBoolean(pobjcc_CourseEN.isBuildingCourse) === false)
{
 throw new Error("(errid:Watl000063)字段[是否已建设课程(isBuildingCourse)]的值:[$(pobjcc_CourseEN.isBuildingCourse)], 非法，应该为布尔型(In 课程(cc_Course))!(clscc_CourseBL:CheckProperty4Update)");
}
if (null != pobjcc_CourseEN.isDoubleLanguageCourse && undefined !== pobjcc_CourseEN.isDoubleLanguageCourse && tzDataType.isBoolean(pobjcc_CourseEN.isDoubleLanguageCourse) === false)
{
 throw new Error("(errid:Watl000063)字段[是否双语课程(isDoubleLanguageCourse)]的值:[$(pobjcc_CourseEN.isDoubleLanguageCourse)], 非法，应该为布尔型(In 课程(cc_Course))!(clscc_CourseBL:CheckProperty4Update)");
}
if (null != pobjcc_CourseEN.isOpen && undefined !== pobjcc_CourseEN.isOpen && tzDataType.isBoolean(pobjcc_CourseEN.isOpen) === false)
{
 throw new Error("(errid:Watl000063)字段[是否公开(isOpen)]的值:[$(pobjcc_CourseEN.isOpen)], 非法，应该为布尔型(In 课程(cc_Course))!(clscc_CourseBL:CheckProperty4Update)");
}
if (null != pobjcc_CourseEN.isRecommendedCourse && undefined !== pobjcc_CourseEN.isRecommendedCourse && tzDataType.isBoolean(pobjcc_CourseEN.isRecommendedCourse) === false)
{
 throw new Error("(errid:Watl000063)字段[是否推荐课程(isRecommendedCourse)]的值:[$(pobjcc_CourseEN.isRecommendedCourse)], 非法，应该为布尔型(In 课程(cc_Course))!(clscc_CourseBL:CheckProperty4Update)");
}
if (null != pobjcc_CourseEN.isSelfPropelledCourse && undefined !== pobjcc_CourseEN.isSelfPropelledCourse && tzDataType.isBoolean(pobjcc_CourseEN.isSelfPropelledCourse) === false)
{
 throw new Error("(errid:Watl000063)字段[是否自荐课程(isSelfPropelledCourse)]的值:[$(pobjcc_CourseEN.isSelfPropelledCourse)], 非法，应该为布尔型(In 课程(cc_Course))!(clscc_CourseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjcc_CourseEN.operationDate) == false && undefined !== pobjcc_CourseEN.operationDate && tzDataType.isString(pobjcc_CourseEN.operationDate) === false)
{
 throw new Error("(errid:Watl000063)字段[操作时间(operationDate)]的值:[$(pobjcc_CourseEN.operationDate)], 非法，应该为字符型(In 课程(cc_Course))!(clscc_CourseBL:CheckProperty4Update)");
}
if (null != pobjcc_CourseEN.orderNum && undefined !== pobjcc_CourseEN.orderNum && tzDataType.isNumber(pobjcc_CourseEN.orderNum) === false)
{
 throw new Error("(errid:Watl000063)字段[序号(orderNum)]的值:[$(pobjcc_CourseEN.orderNum)], 非法，应该为数值型(In 课程(cc_Course))!(clscc_CourseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjcc_CourseEN.outerLink) == false && undefined !== pobjcc_CourseEN.outerLink && tzDataType.isString(pobjcc_CourseEN.outerLink) === false)
{
 throw new Error("(errid:Watl000063)字段[外链地址(outerLink)]的值:[$(pobjcc_CourseEN.outerLink)], 非法，应该为字符型(In 课程(cc_Course))!(clscc_CourseBL:CheckProperty4Update)");
}
if (null != pobjcc_CourseEN.viewCount && undefined !== pobjcc_CourseEN.viewCount && tzDataType.isNumber(pobjcc_CourseEN.viewCount) === false)
{
 throw new Error("(errid:Watl000063)字段[浏览量(viewCount)]的值:[$(pobjcc_CourseEN.viewCount)], 非法，应该为数值型(In 课程(cc_Course))!(clscc_CourseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjcc_CourseEN.themeId) == false && undefined !== pobjcc_CourseEN.themeId && tzDataType.isString(pobjcc_CourseEN.themeId) === false)
{
 throw new Error("(errid:Watl000063)字段[主题Id(themeId)]的值:[$(pobjcc_CourseEN.themeId)], 非法，应该为字符型(In 课程(cc_Course))!(clscc_CourseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjcc_CourseEN.id_School) == false && undefined !== pobjcc_CourseEN.id_School && tzDataType.isString(pobjcc_CourseEN.id_School) === false)
{
 throw new Error("(errid:Watl000063)字段[学校流水号(id_School)]的值:[$(pobjcc_CourseEN.id_School)], 非法，应该为字符型(In 课程(cc_Course))!(clscc_CourseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjcc_CourseEN.id_XzMajor) == false && undefined !== pobjcc_CourseEN.id_XzMajor && tzDataType.isString(pobjcc_CourseEN.id_XzMajor) === false)
{
 throw new Error("(errid:Watl000063)字段[专业流水号(id_XzMajor)]的值:[$(pobjcc_CourseEN.id_XzMajor)], 非法，应该为字符型(In 课程(cc_Course))!(clscc_CourseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjcc_CourseEN.id_XzCollege) == false && undefined !== pobjcc_CourseEN.id_XzCollege && tzDataType.isString(pobjcc_CourseEN.id_XzCollege) === false)
{
 throw new Error("(errid:Watl000063)字段[学院流水号(id_XzCollege)]的值:[$(pobjcc_CourseEN.id_XzCollege)], 非法，应该为字符型(In 课程(cc_Course))!(clscc_CourseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjcc_CourseEN.updDate) == false && undefined !== pobjcc_CourseEN.updDate && tzDataType.isString(pobjcc_CourseEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjcc_CourseEN.updDate)], 非法，应该为字符型(In 课程(cc_Course))!(clscc_CourseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjcc_CourseEN.updUserId) == false && undefined !== pobjcc_CourseEN.updUserId && tzDataType.isString(pobjcc_CourseEN.updUserId) === false)
{
 throw new Error("(errid:Watl000063)字段[修改用户Id(updUserId)]的值:[$(pobjcc_CourseEN.updUserId)], 非法，应该为字符型(In 课程(cc_Course))!(clscc_CourseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjcc_CourseEN.memo) == false && undefined !== pobjcc_CourseEN.memo && tzDataType.isString(pobjcc_CourseEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjcc_CourseEN.memo)], 非法，应该为字符型(In 课程(cc_Course))!(clscc_CourseBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (IsNullOrEmpty(pobjcc_CourseEN.courseId) === true 
 || pobjcc_CourseEN.courseId.toString()  ===  "0" )
{
 throw new Error("(errid:Watl000064)字段[课程Id]不能为空(In 课程)!(clscc_CourseBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
if (IsNullOrEmpty(pobjcc_CourseEN.courseTypeID) == false && GetStrLen(pobjcc_CourseEN.courseTypeID) !=  4)
{
 throw ("(errid:Watl000065)字段[课程类型ID]作为外键字段,长度应该为4(In 课程)!(clscc_CourseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjcc_CourseEN.excellentTypeId) == false && GetStrLen(pobjcc_CourseEN.excellentTypeId) !=  4)
{
 throw ("(errid:Watl000065)字段[精品课程类型Id]作为外键字段,长度应该为4(In 课程)!(clscc_CourseBL:CheckPropertyNew)");
}

 pobjcc_CourseEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function cc_Course_GetJSONStrByObj (pobjcc_CourseEN: clscc_CourseEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjcc_CourseEN.sf_UpdFldSetStr = pobjcc_CourseEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjcc_CourseEN);
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
export function cc_Course_GetObjLstByJSONStr (strJSON: string): Array<clscc_CourseEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrcc_CourseObjLst = new Array<clscc_CourseEN>();
if (strJSON === "")
{
return arrcc_CourseObjLst;
}
try
{
arrcc_CourseObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrcc_CourseObjLst;
}
return arrcc_CourseObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrcc_CourseObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function cc_Course_GetObjLstByJSONObjLst (arrcc_CourseObjLstS: Array<clscc_CourseEN>): Array<clscc_CourseEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrcc_CourseObjLst = new Array<clscc_CourseEN>();
for (const objInFor of arrcc_CourseObjLstS) {
const obj1 = cc_Course_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrcc_CourseObjLst.push(obj1);
}
return arrcc_CourseObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function cc_Course_GetObjByJSONStr (strJSON: string): clscc_CourseEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjcc_CourseEN = new clscc_CourseEN();
if (strJSON === "")
{
return pobjcc_CourseEN;
}
try
{
pobjcc_CourseEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjcc_CourseEN;
}
return pobjcc_CourseEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function cc_Course_GetCombineCondition(objcc_Course_Cond: clscc_CourseEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objcc_Course_Cond.dicFldComparisonOp, clscc_CourseEN.con_CourseId) == true)
{
const strComparisonOp_CourseId:string = objcc_Course_Cond.dicFldComparisonOp[clscc_CourseEN.con_CourseId];
strWhereCond += Format(" And {0} {2} '{1}'", clscc_CourseEN.con_CourseId, objcc_Course_Cond.courseId, strComparisonOp_CourseId);
}
if (Object.prototype.hasOwnProperty.call(objcc_Course_Cond.dicFldComparisonOp, clscc_CourseEN.con_CourseCode) == true)
{
const strComparisonOp_CourseCode:string = objcc_Course_Cond.dicFldComparisonOp[clscc_CourseEN.con_CourseCode];
strWhereCond += Format(" And {0} {2} '{1}'", clscc_CourseEN.con_CourseCode, objcc_Course_Cond.courseCode, strComparisonOp_CourseCode);
}
if (Object.prototype.hasOwnProperty.call(objcc_Course_Cond.dicFldComparisonOp, clscc_CourseEN.con_CourseDescription) == true)
{
const strComparisonOp_CourseDescription:string = objcc_Course_Cond.dicFldComparisonOp[clscc_CourseEN.con_CourseDescription];
strWhereCond += Format(" And {0} {2} '{1}'", clscc_CourseEN.con_CourseDescription, objcc_Course_Cond.courseDescription, strComparisonOp_CourseDescription);
}
if (Object.prototype.hasOwnProperty.call(objcc_Course_Cond.dicFldComparisonOp, clscc_CourseEN.con_CourseName) == true)
{
const strComparisonOp_CourseName:string = objcc_Course_Cond.dicFldComparisonOp[clscc_CourseEN.con_CourseName];
strWhereCond += Format(" And {0} {2} '{1}'", clscc_CourseEN.con_CourseName, objcc_Course_Cond.courseName, strComparisonOp_CourseName);
}
if (Object.prototype.hasOwnProperty.call(objcc_Course_Cond.dicFldComparisonOp, clscc_CourseEN.con_CourseTypeID) == true)
{
const strComparisonOp_CourseTypeID:string = objcc_Course_Cond.dicFldComparisonOp[clscc_CourseEN.con_CourseTypeID];
strWhereCond += Format(" And {0} {2} '{1}'", clscc_CourseEN.con_CourseTypeID, objcc_Course_Cond.courseTypeID, strComparisonOp_CourseTypeID);
}
if (Object.prototype.hasOwnProperty.call(objcc_Course_Cond.dicFldComparisonOp, clscc_CourseEN.con_CreateDate) == true)
{
const strComparisonOp_CreateDate:string = objcc_Course_Cond.dicFldComparisonOp[clscc_CourseEN.con_CreateDate];
strWhereCond += Format(" And {0} {2} '{1}'", clscc_CourseEN.con_CreateDate, objcc_Course_Cond.createDate, strComparisonOp_CreateDate);
}
if (Object.prototype.hasOwnProperty.call(objcc_Course_Cond.dicFldComparisonOp, clscc_CourseEN.con_ExcellentTypeId) == true)
{
const strComparisonOp_ExcellentTypeId:string = objcc_Course_Cond.dicFldComparisonOp[clscc_CourseEN.con_ExcellentTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clscc_CourseEN.con_ExcellentTypeId, objcc_Course_Cond.excellentTypeId, strComparisonOp_ExcellentTypeId);
}
if (Object.prototype.hasOwnProperty.call(objcc_Course_Cond.dicFldComparisonOp, clscc_CourseEN.con_ExcellentYear) == true)
{
const strComparisonOp_ExcellentYear:string = objcc_Course_Cond.dicFldComparisonOp[clscc_CourseEN.con_ExcellentYear];
strWhereCond += Format(" And {0} {2} {1}", clscc_CourseEN.con_ExcellentYear, objcc_Course_Cond.excellentYear, strComparisonOp_ExcellentYear);
}
if (Object.prototype.hasOwnProperty.call(objcc_Course_Cond.dicFldComparisonOp, clscc_CourseEN.con_IsBuildingCourse) == true)
{
if (objcc_Course_Cond.isBuildingCourse == true)
{
strWhereCond += Format(" And {0} = '1'", clscc_CourseEN.con_IsBuildingCourse);
}
else
{
strWhereCond += Format(" And {0} = '0'", clscc_CourseEN.con_IsBuildingCourse);
}
}
if (Object.prototype.hasOwnProperty.call(objcc_Course_Cond.dicFldComparisonOp, clscc_CourseEN.con_IsDoubleLanguageCourse) == true)
{
if (objcc_Course_Cond.isDoubleLanguageCourse == true)
{
strWhereCond += Format(" And {0} = '1'", clscc_CourseEN.con_IsDoubleLanguageCourse);
}
else
{
strWhereCond += Format(" And {0} = '0'", clscc_CourseEN.con_IsDoubleLanguageCourse);
}
}
if (Object.prototype.hasOwnProperty.call(objcc_Course_Cond.dicFldComparisonOp, clscc_CourseEN.con_IsOpen) == true)
{
if (objcc_Course_Cond.isOpen == true)
{
strWhereCond += Format(" And {0} = '1'", clscc_CourseEN.con_IsOpen);
}
else
{
strWhereCond += Format(" And {0} = '0'", clscc_CourseEN.con_IsOpen);
}
}
if (Object.prototype.hasOwnProperty.call(objcc_Course_Cond.dicFldComparisonOp, clscc_CourseEN.con_IsRecommendedCourse) == true)
{
if (objcc_Course_Cond.isRecommendedCourse == true)
{
strWhereCond += Format(" And {0} = '1'", clscc_CourseEN.con_IsRecommendedCourse);
}
else
{
strWhereCond += Format(" And {0} = '0'", clscc_CourseEN.con_IsRecommendedCourse);
}
}
if (Object.prototype.hasOwnProperty.call(objcc_Course_Cond.dicFldComparisonOp, clscc_CourseEN.con_IsSelfPropelledCourse) == true)
{
if (objcc_Course_Cond.isSelfPropelledCourse == true)
{
strWhereCond += Format(" And {0} = '1'", clscc_CourseEN.con_IsSelfPropelledCourse);
}
else
{
strWhereCond += Format(" And {0} = '0'", clscc_CourseEN.con_IsSelfPropelledCourse);
}
}
if (Object.prototype.hasOwnProperty.call(objcc_Course_Cond.dicFldComparisonOp, clscc_CourseEN.con_OperationDate) == true)
{
const strComparisonOp_OperationDate:string = objcc_Course_Cond.dicFldComparisonOp[clscc_CourseEN.con_OperationDate];
strWhereCond += Format(" And {0} {2} '{1}'", clscc_CourseEN.con_OperationDate, objcc_Course_Cond.operationDate, strComparisonOp_OperationDate);
}
if (Object.prototype.hasOwnProperty.call(objcc_Course_Cond.dicFldComparisonOp, clscc_CourseEN.con_OrderNum) == true)
{
const strComparisonOp_OrderNum:string = objcc_Course_Cond.dicFldComparisonOp[clscc_CourseEN.con_OrderNum];
strWhereCond += Format(" And {0} {2} {1}", clscc_CourseEN.con_OrderNum, objcc_Course_Cond.orderNum, strComparisonOp_OrderNum);
}
if (Object.prototype.hasOwnProperty.call(objcc_Course_Cond.dicFldComparisonOp, clscc_CourseEN.con_OuterLink) == true)
{
const strComparisonOp_OuterLink:string = objcc_Course_Cond.dicFldComparisonOp[clscc_CourseEN.con_OuterLink];
strWhereCond += Format(" And {0} {2} '{1}'", clscc_CourseEN.con_OuterLink, objcc_Course_Cond.outerLink, strComparisonOp_OuterLink);
}
if (Object.prototype.hasOwnProperty.call(objcc_Course_Cond.dicFldComparisonOp, clscc_CourseEN.con_ViewCount) == true)
{
const strComparisonOp_ViewCount:string = objcc_Course_Cond.dicFldComparisonOp[clscc_CourseEN.con_ViewCount];
strWhereCond += Format(" And {0} {2} {1}", clscc_CourseEN.con_ViewCount, objcc_Course_Cond.viewCount, strComparisonOp_ViewCount);
}
if (Object.prototype.hasOwnProperty.call(objcc_Course_Cond.dicFldComparisonOp, clscc_CourseEN.con_ThemeId) == true)
{
const strComparisonOp_ThemeId:string = objcc_Course_Cond.dicFldComparisonOp[clscc_CourseEN.con_ThemeId];
strWhereCond += Format(" And {0} {2} '{1}'", clscc_CourseEN.con_ThemeId, objcc_Course_Cond.themeId, strComparisonOp_ThemeId);
}
if (Object.prototype.hasOwnProperty.call(objcc_Course_Cond.dicFldComparisonOp, clscc_CourseEN.con_id_School) == true)
{
const strComparisonOp_id_School:string = objcc_Course_Cond.dicFldComparisonOp[clscc_CourseEN.con_id_School];
strWhereCond += Format(" And {0} {2} '{1}'", clscc_CourseEN.con_id_School, objcc_Course_Cond.id_School, strComparisonOp_id_School);
}
if (Object.prototype.hasOwnProperty.call(objcc_Course_Cond.dicFldComparisonOp, clscc_CourseEN.con_id_XzMajor) == true)
{
const strComparisonOp_id_XzMajor:string = objcc_Course_Cond.dicFldComparisonOp[clscc_CourseEN.con_id_XzMajor];
strWhereCond += Format(" And {0} {2} '{1}'", clscc_CourseEN.con_id_XzMajor, objcc_Course_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (Object.prototype.hasOwnProperty.call(objcc_Course_Cond.dicFldComparisonOp, clscc_CourseEN.con_id_XzCollege) == true)
{
const strComparisonOp_id_XzCollege:string = objcc_Course_Cond.dicFldComparisonOp[clscc_CourseEN.con_id_XzCollege];
strWhereCond += Format(" And {0} {2} '{1}'", clscc_CourseEN.con_id_XzCollege, objcc_Course_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (Object.prototype.hasOwnProperty.call(objcc_Course_Cond.dicFldComparisonOp, clscc_CourseEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objcc_Course_Cond.dicFldComparisonOp[clscc_CourseEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clscc_CourseEN.con_UpdDate, objcc_Course_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objcc_Course_Cond.dicFldComparisonOp, clscc_CourseEN.con_UpdUserId) == true)
{
const strComparisonOp_UpdUserId:string = objcc_Course_Cond.dicFldComparisonOp[clscc_CourseEN.con_UpdUserId];
strWhereCond += Format(" And {0} {2} '{1}'", clscc_CourseEN.con_UpdUserId, objcc_Course_Cond.updUserId, strComparisonOp_UpdUserId);
}
if (Object.prototype.hasOwnProperty.call(objcc_Course_Cond.dicFldComparisonOp, clscc_CourseEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objcc_Course_Cond.dicFldComparisonOp[clscc_CourseEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clscc_CourseEN.con_Memo, objcc_Course_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--cc_Course(课程),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param strCourseId: 课程Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function cc_Course_GetUniCondStr_CourseId(objcc_CourseEN: clscc_CourseEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and CourseId = '{0}'", objcc_CourseEN.courseId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--cc_Course(课程),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param strCourseId: 课程Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function cc_Course_GetUniCondStr4Update_CourseId(objcc_CourseEN: clscc_CourseEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and CourseId <> '{0}'", objcc_CourseEN.courseId);
 strWhereCond +=  Format(" and CourseId = '{0}'", objcc_CourseEN.courseId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objcc_CourseENS:源对象
 * @param objcc_CourseENT:目标对象
*/
export function cc_Course_CopyObjTo(objcc_CourseENS: clscc_CourseEN , objcc_CourseENT: clscc_CourseEN ): void 
{
objcc_CourseENT.courseId = objcc_CourseENS.courseId; //课程Id
objcc_CourseENT.courseCode = objcc_CourseENS.courseCode; //课程代码
objcc_CourseENT.courseDescription = objcc_CourseENS.courseDescription; //课程描述
objcc_CourseENT.courseName = objcc_CourseENS.courseName; //课程名称
objcc_CourseENT.courseTypeID = objcc_CourseENS.courseTypeID; //课程类型ID
objcc_CourseENT.createDate = objcc_CourseENS.createDate; //建立日期
objcc_CourseENT.excellentTypeId = objcc_CourseENS.excellentTypeId; //精品课程类型Id
objcc_CourseENT.excellentYear = objcc_CourseENS.excellentYear; //课程年份
objcc_CourseENT.isBuildingCourse = objcc_CourseENS.isBuildingCourse; //是否已建设课程
objcc_CourseENT.isDoubleLanguageCourse = objcc_CourseENS.isDoubleLanguageCourse; //是否双语课程
objcc_CourseENT.isOpen = objcc_CourseENS.isOpen; //是否公开
objcc_CourseENT.isRecommendedCourse = objcc_CourseENS.isRecommendedCourse; //是否推荐课程
objcc_CourseENT.isSelfPropelledCourse = objcc_CourseENS.isSelfPropelledCourse; //是否自荐课程
objcc_CourseENT.operationDate = objcc_CourseENS.operationDate; //操作时间
objcc_CourseENT.orderNum = objcc_CourseENS.orderNum; //序号
objcc_CourseENT.outerLink = objcc_CourseENS.outerLink; //外链地址
objcc_CourseENT.viewCount = objcc_CourseENS.viewCount; //浏览量
objcc_CourseENT.themeId = objcc_CourseENS.themeId; //主题Id
objcc_CourseENT.id_School = objcc_CourseENS.id_School; //学校流水号
objcc_CourseENT.id_XzMajor = objcc_CourseENS.id_XzMajor; //专业流水号
objcc_CourseENT.id_XzCollege = objcc_CourseENS.id_XzCollege; //学院流水号
objcc_CourseENT.updDate = objcc_CourseENS.updDate; //修改日期
objcc_CourseENT.updUserId = objcc_CourseENS.updUserId; //修改用户Id
objcc_CourseENT.memo = objcc_CourseENS.memo; //备注
objcc_CourseENT.sf_UpdFldSetStr = objcc_CourseENS.updFldString; //sf_UpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objcc_CourseENS:源对象
 * @param objcc_CourseENT:目标对象
*/
export function cc_Course_GetObjFromJsonObj(objcc_CourseENS: clscc_CourseEN): clscc_CourseEN 
{
 const objcc_CourseENT: clscc_CourseEN = new clscc_CourseEN();
ObjectAssign(objcc_CourseENT, objcc_CourseENS);
 return objcc_CourseENT;
}