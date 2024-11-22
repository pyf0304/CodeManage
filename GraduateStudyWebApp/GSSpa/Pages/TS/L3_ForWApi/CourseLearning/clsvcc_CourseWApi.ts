
 /**
 * 类名:clsvcc_CourseWApi
 * 表名:vcc_Course(01120058)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 12:02:23
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
 * v课程(vcc_Course)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clsvcc_CourseEN } from "../../L0_Entity/CourseLearning/clsvcc_CourseEN.js";
import { BindDdl_ObjLstInDiv_V, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const vcc_Course_Controller = "vcc_CourseApi";
 export const vcc_Course_ConstructorName = "vcc_Course";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strCourseId:关键字
 * @returns 对象
 **/
export async function vcc_Course_GetObjByCourseIdAsync(strCourseId: string): Promise<clsvcc_CourseEN>  
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
const strUrl = GetWebApiUrl(vcc_Course_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vcc_Course_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvcc_Course = vcc_Course_GetObjFromJsonObj(returnObj);
return objvcc_Course;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_Course_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_Course_ConstructorName, strThisFuncName);
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
export async function vcc_Course_GetObjByCourseId_Cache(strCourseId: string, bolTryAsyncOnce: boolean = true) {
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
const arrvcc_CourseObjLst_Cache = await vcc_Course_GetObjLst_Cache();
try
{
const arrvcc_Course_Sel: Array <clsvcc_CourseEN> = arrvcc_CourseObjLst_Cache.filter(x => x.courseId == strCourseId);
let objvcc_Course: clsvcc_CourseEN;
if (arrvcc_Course_Sel.length > 0)
{
objvcc_Course = arrvcc_Course_Sel[0];
return objvcc_Course;
}
else
{
if (bolTryAsyncOnce == true)
{
objvcc_Course = await vcc_Course_GetObjByCourseIdAsync(strCourseId);
if (objvcc_Course != null)
{
vcc_Course_ReFreshThisCache();
return objvcc_Course;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strCourseId, vcc_Course_ConstructorName, strThisFuncName);
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
export async function vcc_Course_GetObjByCourseId_localStorage(strCourseId: string) {
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
const strKey = Format("{0}_{1}", clsvcc_CourseEN._CurrTabName, strCourseId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objvcc_Course_Cache: clsvcc_CourseEN = JSON.parse(strTempObj);
return objvcc_Course_Cache;
}
try
{
const objvcc_Course = await vcc_Course_GetObjByCourseIdAsync(strCourseId);
if (objvcc_Course != null)
{
localStorage.setItem(strKey, JSON.stringify(objvcc_Course));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objvcc_Course;
}
return objvcc_Course;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strCourseId, vcc_Course_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
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
export async function vcc_Course_func(strInFldName:string , strOutFldName:string ,  strInValue: string) 
{
//const strThisFuncName = "func";

if (strInFldName != clsvcc_CourseEN.con_CourseId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsvcc_CourseEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clsvcc_CourseEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strCourseId = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objvcc_Course = await vcc_Course_GetObjByCourseId_Cache(strCourseId );
if (objvcc_Course == null) return "";
return objvcc_Course.GetFldValue(strOutFldName).toString();
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
export function vcc_Course_SortFun_Defa(a:clsvcc_CourseEN , b:clsvcc_CourseEN): number 
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
export function vcc_Course_SortFun_Defa_2Fld(a:clsvcc_CourseEN , b:clsvcc_CourseEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.likeCount == b.likeCount) return a.courseCode.localeCompare(b.courseCode);
else return a.likeCount - b.likeCount;
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
export function vcc_Course_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsvcc_CourseEN.con_CourseId:
return (a: clsvcc_CourseEN, b: clsvcc_CourseEN) => {
return a.courseId.localeCompare(b.courseId);
}
case clsvcc_CourseEN.con_LikeCount:
return (a: clsvcc_CourseEN, b: clsvcc_CourseEN) => {
return a.likeCount-b.likeCount;
}
case clsvcc_CourseEN.con_CourseCode:
return (a: clsvcc_CourseEN, b: clsvcc_CourseEN) => {
return a.courseCode.localeCompare(b.courseCode);
}
case clsvcc_CourseEN.con_CourseDescription:
return (a: clsvcc_CourseEN, b: clsvcc_CourseEN) => {
return a.courseDescription.localeCompare(b.courseDescription);
}
case clsvcc_CourseEN.con_CourseName:
return (a: clsvcc_CourseEN, b: clsvcc_CourseEN) => {
return a.courseName.localeCompare(b.courseName);
}
case clsvcc_CourseEN.con_CourseTypeID:
return (a: clsvcc_CourseEN, b: clsvcc_CourseEN) => {
return a.courseTypeID.localeCompare(b.courseTypeID);
}
case clsvcc_CourseEN.con_CourseTypeName:
return (a: clsvcc_CourseEN, b: clsvcc_CourseEN) => {
return a.courseTypeName.localeCompare(b.courseTypeName);
}
case clsvcc_CourseEN.con_CreateDate:
return (a: clsvcc_CourseEN, b: clsvcc_CourseEN) => {
return a.createDate.localeCompare(b.createDate);
}
case clsvcc_CourseEN.con_ExcellentTypeId:
return (a: clsvcc_CourseEN, b: clsvcc_CourseEN) => {
return a.excellentTypeId.localeCompare(b.excellentTypeId);
}
case clsvcc_CourseEN.con_ExcellentTypeName:
return (a: clsvcc_CourseEN, b: clsvcc_CourseEN) => {
return a.excellentTypeName.localeCompare(b.excellentTypeName);
}
case clsvcc_CourseEN.con_ExcellentYear:
return (a: clsvcc_CourseEN, b: clsvcc_CourseEN) => {
return a.excellentYear-b.excellentYear;
}
case clsvcc_CourseEN.con_IsBuildingCourse:
return (a: clsvcc_CourseEN, b: clsvcc_CourseEN) => {
if (a.isBuildingCourse == true) return 1;
else return -1
}
case clsvcc_CourseEN.con_IsDoubleLanguageCourse:
return (a: clsvcc_CourseEN, b: clsvcc_CourseEN) => {
if (a.isDoubleLanguageCourse == true) return 1;
else return -1
}
case clsvcc_CourseEN.con_IsOpen:
return (a: clsvcc_CourseEN, b: clsvcc_CourseEN) => {
if (a.isOpen == true) return 1;
else return -1
}
case clsvcc_CourseEN.con_IsRecommendedCourse:
return (a: clsvcc_CourseEN, b: clsvcc_CourseEN) => {
if (a.isRecommendedCourse == true) return 1;
else return -1
}
case clsvcc_CourseEN.con_IsSelfPropelledCourse:
return (a: clsvcc_CourseEN, b: clsvcc_CourseEN) => {
if (a.isSelfPropelledCourse == true) return 1;
else return -1
}
case clsvcc_CourseEN.con_OperationDate:
return (a: clsvcc_CourseEN, b: clsvcc_CourseEN) => {
return a.operationDate.localeCompare(b.operationDate);
}
case clsvcc_CourseEN.con_OrderNum:
return (a: clsvcc_CourseEN, b: clsvcc_CourseEN) => {
return a.orderNum-b.orderNum;
}
case clsvcc_CourseEN.con_OuterLink:
return (a: clsvcc_CourseEN, b: clsvcc_CourseEN) => {
return a.outerLink.localeCompare(b.outerLink);
}
case clsvcc_CourseEN.con_ViewCount:
return (a: clsvcc_CourseEN, b: clsvcc_CourseEN) => {
return a.viewCount-b.viewCount;
}
case clsvcc_CourseEN.con_ThemeId:
return (a: clsvcc_CourseEN, b: clsvcc_CourseEN) => {
return a.themeId.localeCompare(b.themeId);
}
case clsvcc_CourseEN.con_ThemeName:
return (a: clsvcc_CourseEN, b: clsvcc_CourseEN) => {
return a.themeName.localeCompare(b.themeName);
}
case clsvcc_CourseEN.con_ExampleImgPath:
return (a: clsvcc_CourseEN, b: clsvcc_CourseEN) => {
return a.exampleImgPath.localeCompare(b.exampleImgPath);
}
case clsvcc_CourseEN.con_id_XzMajor:
return (a: clsvcc_CourseEN, b: clsvcc_CourseEN) => {
return a.id_XzMajor.localeCompare(b.id_XzMajor);
}
case clsvcc_CourseEN.con_MajorID:
return (a: clsvcc_CourseEN, b: clsvcc_CourseEN) => {
return a.majorID.localeCompare(b.majorID);
}
case clsvcc_CourseEN.con_MajorName:
return (a: clsvcc_CourseEN, b: clsvcc_CourseEN) => {
return a.majorName.localeCompare(b.majorName);
}
case clsvcc_CourseEN.con_id_XzCollege:
return (a: clsvcc_CourseEN, b: clsvcc_CourseEN) => {
return a.id_XzCollege.localeCompare(b.id_XzCollege);
}
case clsvcc_CourseEN.con_CollegeID:
return (a: clsvcc_CourseEN, b: clsvcc_CourseEN) => {
return a.collegeID.localeCompare(b.collegeID);
}
case clsvcc_CourseEN.con_CollegeName:
return (a: clsvcc_CourseEN, b: clsvcc_CourseEN) => {
return a.collegeName.localeCompare(b.collegeName);
}
case clsvcc_CourseEN.con_CollegeNameA:
return (a: clsvcc_CourseEN, b: clsvcc_CourseEN) => {
return a.collegeNameA.localeCompare(b.collegeNameA);
}
case clsvcc_CourseEN.con_Memo:
return (a: clsvcc_CourseEN, b: clsvcc_CourseEN) => {
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vcc_Course]中不存在！(in ${ vcc_Course_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsvcc_CourseEN.con_CourseId:
return (a: clsvcc_CourseEN, b: clsvcc_CourseEN) => {
return b.courseId.localeCompare(a.courseId);
}
case clsvcc_CourseEN.con_LikeCount:
return (a: clsvcc_CourseEN, b: clsvcc_CourseEN) => {
return b.likeCount-a.likeCount;
}
case clsvcc_CourseEN.con_CourseCode:
return (a: clsvcc_CourseEN, b: clsvcc_CourseEN) => {
return b.courseCode.localeCompare(a.courseCode);
}
case clsvcc_CourseEN.con_CourseDescription:
return (a: clsvcc_CourseEN, b: clsvcc_CourseEN) => {
return b.courseDescription.localeCompare(a.courseDescription);
}
case clsvcc_CourseEN.con_CourseName:
return (a: clsvcc_CourseEN, b: clsvcc_CourseEN) => {
return b.courseName.localeCompare(a.courseName);
}
case clsvcc_CourseEN.con_CourseTypeID:
return (a: clsvcc_CourseEN, b: clsvcc_CourseEN) => {
return b.courseTypeID.localeCompare(a.courseTypeID);
}
case clsvcc_CourseEN.con_CourseTypeName:
return (a: clsvcc_CourseEN, b: clsvcc_CourseEN) => {
return b.courseTypeName.localeCompare(a.courseTypeName);
}
case clsvcc_CourseEN.con_CreateDate:
return (a: clsvcc_CourseEN, b: clsvcc_CourseEN) => {
return b.createDate.localeCompare(a.createDate);
}
case clsvcc_CourseEN.con_ExcellentTypeId:
return (a: clsvcc_CourseEN, b: clsvcc_CourseEN) => {
return b.excellentTypeId.localeCompare(a.excellentTypeId);
}
case clsvcc_CourseEN.con_ExcellentTypeName:
return (a: clsvcc_CourseEN, b: clsvcc_CourseEN) => {
return b.excellentTypeName.localeCompare(a.excellentTypeName);
}
case clsvcc_CourseEN.con_ExcellentYear:
return (a: clsvcc_CourseEN, b: clsvcc_CourseEN) => {
return b.excellentYear-a.excellentYear;
}
case clsvcc_CourseEN.con_IsBuildingCourse:
return (a: clsvcc_CourseEN, b: clsvcc_CourseEN) => {
if (b.isBuildingCourse == true) return 1;
else return -1
}
case clsvcc_CourseEN.con_IsDoubleLanguageCourse:
return (a: clsvcc_CourseEN, b: clsvcc_CourseEN) => {
if (b.isDoubleLanguageCourse == true) return 1;
else return -1
}
case clsvcc_CourseEN.con_IsOpen:
return (a: clsvcc_CourseEN, b: clsvcc_CourseEN) => {
if (b.isOpen == true) return 1;
else return -1
}
case clsvcc_CourseEN.con_IsRecommendedCourse:
return (a: clsvcc_CourseEN, b: clsvcc_CourseEN) => {
if (b.isRecommendedCourse == true) return 1;
else return -1
}
case clsvcc_CourseEN.con_IsSelfPropelledCourse:
return (a: clsvcc_CourseEN, b: clsvcc_CourseEN) => {
if (b.isSelfPropelledCourse == true) return 1;
else return -1
}
case clsvcc_CourseEN.con_OperationDate:
return (a: clsvcc_CourseEN, b: clsvcc_CourseEN) => {
return b.operationDate.localeCompare(a.operationDate);
}
case clsvcc_CourseEN.con_OrderNum:
return (a: clsvcc_CourseEN, b: clsvcc_CourseEN) => {
return b.orderNum-a.orderNum;
}
case clsvcc_CourseEN.con_OuterLink:
return (a: clsvcc_CourseEN, b: clsvcc_CourseEN) => {
return b.outerLink.localeCompare(a.outerLink);
}
case clsvcc_CourseEN.con_ViewCount:
return (a: clsvcc_CourseEN, b: clsvcc_CourseEN) => {
return b.viewCount-a.viewCount;
}
case clsvcc_CourseEN.con_ThemeId:
return (a: clsvcc_CourseEN, b: clsvcc_CourseEN) => {
return b.themeId.localeCompare(a.themeId);
}
case clsvcc_CourseEN.con_ThemeName:
return (a: clsvcc_CourseEN, b: clsvcc_CourseEN) => {
return b.themeName.localeCompare(a.themeName);
}
case clsvcc_CourseEN.con_ExampleImgPath:
return (a: clsvcc_CourseEN, b: clsvcc_CourseEN) => {
return b.exampleImgPath.localeCompare(a.exampleImgPath);
}
case clsvcc_CourseEN.con_id_XzMajor:
return (a: clsvcc_CourseEN, b: clsvcc_CourseEN) => {
return b.id_XzMajor.localeCompare(a.id_XzMajor);
}
case clsvcc_CourseEN.con_MajorID:
return (a: clsvcc_CourseEN, b: clsvcc_CourseEN) => {
return b.majorID.localeCompare(a.majorID);
}
case clsvcc_CourseEN.con_MajorName:
return (a: clsvcc_CourseEN, b: clsvcc_CourseEN) => {
return b.majorName.localeCompare(a.majorName);
}
case clsvcc_CourseEN.con_id_XzCollege:
return (a: clsvcc_CourseEN, b: clsvcc_CourseEN) => {
return b.id_XzCollege.localeCompare(a.id_XzCollege);
}
case clsvcc_CourseEN.con_CollegeID:
return (a: clsvcc_CourseEN, b: clsvcc_CourseEN) => {
return b.collegeID.localeCompare(a.collegeID);
}
case clsvcc_CourseEN.con_CollegeName:
return (a: clsvcc_CourseEN, b: clsvcc_CourseEN) => {
return b.collegeName.localeCompare(a.collegeName);
}
case clsvcc_CourseEN.con_CollegeNameA:
return (a: clsvcc_CourseEN, b: clsvcc_CourseEN) => {
return b.collegeNameA.localeCompare(a.collegeNameA);
}
case clsvcc_CourseEN.con_Memo:
return (a: clsvcc_CourseEN, b: clsvcc_CourseEN) => {
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vcc_Course]中不存在！(in ${ vcc_Course_ConstructorName}.${ strThisFuncName})`;
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
export async function vcc_Course_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsvcc_CourseEN.con_CourseId:
return (obj: clsvcc_CourseEN) => {
return obj.courseId === value;
}
case clsvcc_CourseEN.con_LikeCount:
return (obj: clsvcc_CourseEN) => {
return obj.likeCount === value;
}
case clsvcc_CourseEN.con_CourseCode:
return (obj: clsvcc_CourseEN) => {
return obj.courseCode === value;
}
case clsvcc_CourseEN.con_CourseDescription:
return (obj: clsvcc_CourseEN) => {
return obj.courseDescription === value;
}
case clsvcc_CourseEN.con_CourseName:
return (obj: clsvcc_CourseEN) => {
return obj.courseName === value;
}
case clsvcc_CourseEN.con_CourseTypeID:
return (obj: clsvcc_CourseEN) => {
return obj.courseTypeID === value;
}
case clsvcc_CourseEN.con_CourseTypeName:
return (obj: clsvcc_CourseEN) => {
return obj.courseTypeName === value;
}
case clsvcc_CourseEN.con_CreateDate:
return (obj: clsvcc_CourseEN) => {
return obj.createDate === value;
}
case clsvcc_CourseEN.con_ExcellentTypeId:
return (obj: clsvcc_CourseEN) => {
return obj.excellentTypeId === value;
}
case clsvcc_CourseEN.con_ExcellentTypeName:
return (obj: clsvcc_CourseEN) => {
return obj.excellentTypeName === value;
}
case clsvcc_CourseEN.con_ExcellentYear:
return (obj: clsvcc_CourseEN) => {
return obj.excellentYear === value;
}
case clsvcc_CourseEN.con_IsBuildingCourse:
return (obj: clsvcc_CourseEN) => {
return obj.isBuildingCourse === value;
}
case clsvcc_CourseEN.con_IsDoubleLanguageCourse:
return (obj: clsvcc_CourseEN) => {
return obj.isDoubleLanguageCourse === value;
}
case clsvcc_CourseEN.con_IsOpen:
return (obj: clsvcc_CourseEN) => {
return obj.isOpen === value;
}
case clsvcc_CourseEN.con_IsRecommendedCourse:
return (obj: clsvcc_CourseEN) => {
return obj.isRecommendedCourse === value;
}
case clsvcc_CourseEN.con_IsSelfPropelledCourse:
return (obj: clsvcc_CourseEN) => {
return obj.isSelfPropelledCourse === value;
}
case clsvcc_CourseEN.con_OperationDate:
return (obj: clsvcc_CourseEN) => {
return obj.operationDate === value;
}
case clsvcc_CourseEN.con_OrderNum:
return (obj: clsvcc_CourseEN) => {
return obj.orderNum === value;
}
case clsvcc_CourseEN.con_OuterLink:
return (obj: clsvcc_CourseEN) => {
return obj.outerLink === value;
}
case clsvcc_CourseEN.con_ViewCount:
return (obj: clsvcc_CourseEN) => {
return obj.viewCount === value;
}
case clsvcc_CourseEN.con_ThemeId:
return (obj: clsvcc_CourseEN) => {
return obj.themeId === value;
}
case clsvcc_CourseEN.con_ThemeName:
return (obj: clsvcc_CourseEN) => {
return obj.themeName === value;
}
case clsvcc_CourseEN.con_ExampleImgPath:
return (obj: clsvcc_CourseEN) => {
return obj.exampleImgPath === value;
}
case clsvcc_CourseEN.con_id_XzMajor:
return (obj: clsvcc_CourseEN) => {
return obj.id_XzMajor === value;
}
case clsvcc_CourseEN.con_MajorID:
return (obj: clsvcc_CourseEN) => {
return obj.majorID === value;
}
case clsvcc_CourseEN.con_MajorName:
return (obj: clsvcc_CourseEN) => {
return obj.majorName === value;
}
case clsvcc_CourseEN.con_id_XzCollege:
return (obj: clsvcc_CourseEN) => {
return obj.id_XzCollege === value;
}
case clsvcc_CourseEN.con_CollegeID:
return (obj: clsvcc_CourseEN) => {
return obj.collegeID === value;
}
case clsvcc_CourseEN.con_CollegeName:
return (obj: clsvcc_CourseEN) => {
return obj.collegeName === value;
}
case clsvcc_CourseEN.con_CollegeNameA:
return (obj: clsvcc_CourseEN) => {
return obj.collegeNameA === value;
}
case clsvcc_CourseEN.con_Memo:
return (obj: clsvcc_CourseEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vcc_Course]中不存在！(in ${ vcc_Course_ConstructorName}.${ strThisFuncName})`;
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
export async function vcc_Course_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vcc_Course_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_Course_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_Course_ConstructorName, strThisFuncName);
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
export async function vcc_Course_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vcc_Course_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_Course_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_Course_ConstructorName, strThisFuncName);
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
export async function vcc_Course_GetFirstObjAsync(strWhereCond: string): Promise<clsvcc_CourseEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(vcc_Course_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vcc_Course_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvcc_Course = vcc_Course_GetObjFromJsonObj(returnObj);
return objvcc_Course;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_Course_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_Course_ConstructorName, strThisFuncName);
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
export async function vcc_Course_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvcc_CourseEN._CurrTabName;
clsvcc_CourseEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvcc_CourseEN._CurrTabName);
if (IsNullOrEmpty(clsvcc_CourseEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvcc_CourseEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrvcc_CourseExObjLst_Cache: Array<clsvcc_CourseEN> = CacheHelper.Get(strKey);
const arrvcc_CourseObjLst_T = vcc_Course_GetObjLstByJSONObjLst(arrvcc_CourseExObjLst_Cache);
return arrvcc_CourseObjLst_T;
}
try
{
const arrvcc_CourseExObjLst = await vcc_Course_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrvcc_CourseExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvcc_CourseExObjLst.length);
console.log(strInfo);
return arrvcc_CourseExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vcc_Course_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vcc_Course_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvcc_CourseEN._CurrTabName;
clsvcc_CourseEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvcc_CourseEN._CurrTabName);
if (IsNullOrEmpty(clsvcc_CourseEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvcc_CourseEN.CacheAddiCondition);
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
const arrvcc_CourseExObjLst_Cache: Array<clsvcc_CourseEN> = JSON.parse(strTempObjLst);
const arrvcc_CourseObjLst_T = vcc_Course_GetObjLstByJSONObjLst(arrvcc_CourseExObjLst_Cache);
return arrvcc_CourseObjLst_T;
}
try
{
const arrvcc_CourseExObjLst = await vcc_Course_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrvcc_CourseExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvcc_CourseExObjLst.length);
console.log(strInfo);
return arrvcc_CourseExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vcc_Course_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vcc_Course_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsvcc_CourseEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrvcc_CourseObjLst_Cache: Array<clsvcc_CourseEN> = JSON.parse(strTempObjLst);
return arrvcc_CourseObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function vcc_Course_GetObjLstAsync(strWhereCond: string): Promise<Array<clsvcc_CourseEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(vcc_Course_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vcc_Course_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vcc_Course_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_Course_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_Course_ConstructorName, strThisFuncName);
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
export async function vcc_Course_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvcc_CourseEN._CurrTabName;
clsvcc_CourseEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvcc_CourseEN._CurrTabName);
if (IsNullOrEmpty(clsvcc_CourseEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvcc_CourseEN.CacheAddiCondition);
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
const arrvcc_CourseExObjLst_Cache: Array<clsvcc_CourseEN> = JSON.parse(strTempObjLst);
const arrvcc_CourseObjLst_T = vcc_Course_GetObjLstByJSONObjLst(arrvcc_CourseExObjLst_Cache);
return arrvcc_CourseObjLst_T;
}
try
{
const arrvcc_CourseExObjLst = await vcc_Course_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrvcc_CourseExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvcc_CourseExObjLst.length);
console.log(strInfo);
return arrvcc_CourseExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vcc_Course_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vcc_Course_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsvcc_CourseEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrvcc_CourseObjLst_Cache: Array<clsvcc_CourseEN> = JSON.parse(strTempObjLst);
return arrvcc_CourseObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vcc_Course_GetObjLst_Cache(): Promise<Array<clsvcc_CourseEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrvcc_CourseObjLst_Cache;
switch (clsvcc_CourseEN.CacheModeId)
{
case "04"://sessionStorage
arrvcc_CourseObjLst_Cache = await vcc_Course_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrvcc_CourseObjLst_Cache = await vcc_Course_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrvcc_CourseObjLst_Cache = await vcc_Course_GetObjLst_ClientCache();
break;
default:
arrvcc_CourseObjLst_Cache = await vcc_Course_GetObjLst_ClientCache();
break;
}
const arrvcc_CourseObjLst = vcc_Course_GetObjLstByJSONObjLst(arrvcc_CourseObjLst_Cache);
return arrvcc_CourseObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vcc_Course_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrvcc_CourseObjLst_Cache;
switch (clsvcc_CourseEN.CacheModeId)
{
case "04"://sessionStorage
arrvcc_CourseObjLst_Cache = await vcc_Course_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrvcc_CourseObjLst_Cache = await vcc_Course_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrvcc_CourseObjLst_Cache = null;
break;
default:
arrvcc_CourseObjLst_Cache = null;
break;
}
return arrvcc_CourseObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrCourseId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vcc_Course_GetSubObjLst_Cache(objvcc_Course_Cond: clsvcc_CourseEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrvcc_CourseObjLst_Cache = await vcc_Course_GetObjLst_Cache();
let arrvcc_Course_Sel: Array < clsvcc_CourseEN > = arrvcc_CourseObjLst_Cache;
if (objvcc_Course_Cond.sf_FldComparisonOp == null || objvcc_Course_Cond.sf_FldComparisonOp == "") return arrvcc_Course_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvcc_Course_Cond.sf_FldComparisonOp);
//console.log("clsvcc_CourseWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvcc_Course_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvcc_Course_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvcc_Course_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objvcc_Course_Cond), vcc_Course_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvcc_CourseEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrCourseId:关键字列表
 * @returns 对象列表
 **/
export async function vcc_Course_GetObjLstByCourseIdLstAsync(arrCourseId: Array<string>): Promise<Array<clsvcc_CourseEN>>  
{
const strThisFuncName = "GetObjLstByCourseIdLstAsync";
const strAction = "GetObjLstByCourseIdLst";
const strUrl = GetWebApiUrl(vcc_Course_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrCourseId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vcc_Course_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vcc_Course_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_Course_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_Course_ConstructorName, strThisFuncName);
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
export async function vcc_Course_GetObjLstByCourseIdLst_Cache(arrCourseIdLst: Array<string>) {
const strThisFuncName = "GetObjLstByCourseIdLst_Cache";
try
{
const arrvcc_CourseObjLst_Cache = await vcc_Course_GetObjLst_Cache();
const arrvcc_Course_Sel: Array <clsvcc_CourseEN> = arrvcc_CourseObjLst_Cache.filter(x => arrCourseIdLst.indexOf(x.courseId)>-1);
return arrvcc_Course_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrCourseIdLst.join(","), vcc_Course_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvcc_CourseEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function vcc_Course_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsvcc_CourseEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(vcc_Course_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vcc_Course_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vcc_Course_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_Course_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_Course_ConstructorName, strThisFuncName);
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
export async function vcc_Course_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsvcc_CourseEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vcc_Course_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vcc_Course_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vcc_Course_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_Course_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_Course_ConstructorName, strThisFuncName);
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
export async function vcc_Course_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vcc_Course_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_Course_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_Course_ConstructorName, strThisFuncName);
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
export async function vcc_Course_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrvcc_CourseObjLst_Cache = await vcc_Course_GetObjLst_Cache();
if (arrvcc_CourseObjLst_Cache.length == 0) return arrvcc_CourseObjLst_Cache;
let arrvcc_Course_Sel = arrvcc_CourseObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objvcc_Course_Cond = new clsvcc_CourseEN();
ObjectAssign(objvcc_Course_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsvcc_CourseWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvcc_Course_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvcc_Course_Sel.length == 0) return arrvcc_Course_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrvcc_Course_Sel = arrvcc_Course_Sel.sort(vcc_Course_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrvcc_Course_Sel = arrvcc_Course_Sel.sort(objPagerPara.sortFun);
}
arrvcc_Course_Sel = arrvcc_Course_Sel.slice(intStart, intEnd);     
return arrvcc_Course_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, vcc_Course_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvcc_CourseEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function vcc_Course_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsvcc_CourseEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(vcc_Course_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vcc_Course_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vcc_Course_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_Course_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_Course_ConstructorName, strThisFuncName);
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
export async function vcc_Course_IsExistRecord_Cache(objvcc_Course_Cond: clsvcc_CourseEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrvcc_CourseObjLst_Cache = await vcc_Course_GetObjLst_Cache();
if (arrvcc_CourseObjLst_Cache == null) return false;
let arrvcc_Course_Sel: Array < clsvcc_CourseEN > = arrvcc_CourseObjLst_Cache;
if (objvcc_Course_Cond.sf_FldComparisonOp == null || objvcc_Course_Cond.sf_FldComparisonOp == "") return arrvcc_Course_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvcc_Course_Cond.sf_FldComparisonOp);
//console.log("clsvcc_CourseWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvcc_Course_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvcc_Course_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvcc_Course_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objvcc_Course_Cond), vcc_Course_ConstructorName, strThisFuncName);
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
export async function vcc_Course_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(vcc_Course_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_Course_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_Course_ConstructorName, strThisFuncName);
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
export async function vcc_Course_IsExist(strCourseId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vcc_Course_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_Course_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_Course_ConstructorName, strThisFuncName);
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
export async function vcc_Course_IsExist_Cache(strCourseId:string) {
const strThisFuncName = "IsExist_Cache";
const arrvcc_CourseObjLst_Cache = await vcc_Course_GetObjLst_Cache();
if (arrvcc_CourseObjLst_Cache == null) return false;
try
{
const arrvcc_Course_Sel: Array <clsvcc_CourseEN> = arrvcc_CourseObjLst_Cache.filter(x => x.courseId == strCourseId);
if (arrvcc_Course_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strCourseId, vcc_Course_ConstructorName, strThisFuncName);
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
export async function vcc_Course_IsExistAsync(strCourseId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vcc_Course_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_Course_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_Course_ConstructorName, strThisFuncName);
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
export async function vcc_Course_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(vcc_Course_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_Course_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_Course_ConstructorName, strThisFuncName);
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
 * @param objvcc_Course_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function vcc_Course_GetRecCountByCond_Cache(objvcc_Course_Cond: clsvcc_CourseEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrvcc_CourseObjLst_Cache = await vcc_Course_GetObjLst_Cache();
if (arrvcc_CourseObjLst_Cache == null) return 0;
let arrvcc_Course_Sel: Array < clsvcc_CourseEN > = arrvcc_CourseObjLst_Cache;
if (objvcc_Course_Cond.sf_FldComparisonOp == null || objvcc_Course_Cond.sf_FldComparisonOp == "") return arrvcc_Course_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvcc_Course_Cond.sf_FldComparisonOp);
//console.log("clsvcc_CourseWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvcc_Course_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvcc_Course_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvcc_Course_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objvcc_Course_Cond), vcc_Course_ConstructorName, strThisFuncName);
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
export function vcc_Course_GetWebApiUrl(strController: string, strAction: string): string {
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
export function vcc_Course_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clsvcc_CourseEN._CurrTabName;
switch (clsvcc_CourseEN.CacheModeId)
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
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vcc_Course_GetJSONStrByObj (pobjvcc_CourseEN: clsvcc_CourseEN): string
{
const strThisFuncName = "GetJSONStrByObj";
let strJson = "";
try
{
strJson = JSON.stringify(pobjvcc_CourseEN);
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
export function vcc_Course_GetObjLstByJSONStr (strJSON: string): Array<clsvcc_CourseEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrvcc_CourseObjLst = new Array<clsvcc_CourseEN>();
if (strJSON === "")
{
return arrvcc_CourseObjLst;
}
try
{
arrvcc_CourseObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvcc_CourseObjLst;
}
return arrvcc_CourseObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrvcc_CourseObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function vcc_Course_GetObjLstByJSONObjLst (arrvcc_CourseObjLstS: Array<clsvcc_CourseEN>): Array<clsvcc_CourseEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrvcc_CourseObjLst = new Array<clsvcc_CourseEN>();
for (const objInFor of arrvcc_CourseObjLstS) {
const obj1 = vcc_Course_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrvcc_CourseObjLst.push(obj1);
}
return arrvcc_CourseObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vcc_Course_GetObjByJSONStr (strJSON: string): clsvcc_CourseEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjvcc_CourseEN = new clsvcc_CourseEN();
if (strJSON === "")
{
return pobjvcc_CourseEN;
}
try
{
pobjvcc_CourseEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvcc_CourseEN;
}
return pobjvcc_CourseEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function vcc_Course_GetCombineCondition(objvcc_Course_Cond: clsvcc_CourseEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objvcc_Course_Cond.dicFldComparisonOp, clsvcc_CourseEN.con_CourseId) == true)
{
const strComparisonOp_CourseId:string = objvcc_Course_Cond.dicFldComparisonOp[clsvcc_CourseEN.con_CourseId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseEN.con_CourseId, objvcc_Course_Cond.courseId, strComparisonOp_CourseId);
}
if (Object.prototype.hasOwnProperty.call(objvcc_Course_Cond.dicFldComparisonOp, clsvcc_CourseEN.con_LikeCount) == true)
{
const strComparisonOp_LikeCount:string = objvcc_Course_Cond.dicFldComparisonOp[clsvcc_CourseEN.con_LikeCount];
strWhereCond += Format(" And {0} {2} {1}", clsvcc_CourseEN.con_LikeCount, objvcc_Course_Cond.likeCount, strComparisonOp_LikeCount);
}
if (Object.prototype.hasOwnProperty.call(objvcc_Course_Cond.dicFldComparisonOp, clsvcc_CourseEN.con_CourseCode) == true)
{
const strComparisonOp_CourseCode:string = objvcc_Course_Cond.dicFldComparisonOp[clsvcc_CourseEN.con_CourseCode];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseEN.con_CourseCode, objvcc_Course_Cond.courseCode, strComparisonOp_CourseCode);
}
if (Object.prototype.hasOwnProperty.call(objvcc_Course_Cond.dicFldComparisonOp, clsvcc_CourseEN.con_CourseDescription) == true)
{
const strComparisonOp_CourseDescription:string = objvcc_Course_Cond.dicFldComparisonOp[clsvcc_CourseEN.con_CourseDescription];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseEN.con_CourseDescription, objvcc_Course_Cond.courseDescription, strComparisonOp_CourseDescription);
}
if (Object.prototype.hasOwnProperty.call(objvcc_Course_Cond.dicFldComparisonOp, clsvcc_CourseEN.con_CourseName) == true)
{
const strComparisonOp_CourseName:string = objvcc_Course_Cond.dicFldComparisonOp[clsvcc_CourseEN.con_CourseName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseEN.con_CourseName, objvcc_Course_Cond.courseName, strComparisonOp_CourseName);
}
if (Object.prototype.hasOwnProperty.call(objvcc_Course_Cond.dicFldComparisonOp, clsvcc_CourseEN.con_CourseTypeID) == true)
{
const strComparisonOp_CourseTypeID:string = objvcc_Course_Cond.dicFldComparisonOp[clsvcc_CourseEN.con_CourseTypeID];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseEN.con_CourseTypeID, objvcc_Course_Cond.courseTypeID, strComparisonOp_CourseTypeID);
}
if (Object.prototype.hasOwnProperty.call(objvcc_Course_Cond.dicFldComparisonOp, clsvcc_CourseEN.con_CourseTypeName) == true)
{
const strComparisonOp_CourseTypeName:string = objvcc_Course_Cond.dicFldComparisonOp[clsvcc_CourseEN.con_CourseTypeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseEN.con_CourseTypeName, objvcc_Course_Cond.courseTypeName, strComparisonOp_CourseTypeName);
}
if (Object.prototype.hasOwnProperty.call(objvcc_Course_Cond.dicFldComparisonOp, clsvcc_CourseEN.con_CreateDate) == true)
{
const strComparisonOp_CreateDate:string = objvcc_Course_Cond.dicFldComparisonOp[clsvcc_CourseEN.con_CreateDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseEN.con_CreateDate, objvcc_Course_Cond.createDate, strComparisonOp_CreateDate);
}
if (Object.prototype.hasOwnProperty.call(objvcc_Course_Cond.dicFldComparisonOp, clsvcc_CourseEN.con_ExcellentTypeId) == true)
{
const strComparisonOp_ExcellentTypeId:string = objvcc_Course_Cond.dicFldComparisonOp[clsvcc_CourseEN.con_ExcellentTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseEN.con_ExcellentTypeId, objvcc_Course_Cond.excellentTypeId, strComparisonOp_ExcellentTypeId);
}
if (Object.prototype.hasOwnProperty.call(objvcc_Course_Cond.dicFldComparisonOp, clsvcc_CourseEN.con_ExcellentTypeName) == true)
{
const strComparisonOp_ExcellentTypeName:string = objvcc_Course_Cond.dicFldComparisonOp[clsvcc_CourseEN.con_ExcellentTypeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseEN.con_ExcellentTypeName, objvcc_Course_Cond.excellentTypeName, strComparisonOp_ExcellentTypeName);
}
if (Object.prototype.hasOwnProperty.call(objvcc_Course_Cond.dicFldComparisonOp, clsvcc_CourseEN.con_ExcellentYear) == true)
{
const strComparisonOp_ExcellentYear:string = objvcc_Course_Cond.dicFldComparisonOp[clsvcc_CourseEN.con_ExcellentYear];
strWhereCond += Format(" And {0} {2} {1}", clsvcc_CourseEN.con_ExcellentYear, objvcc_Course_Cond.excellentYear, strComparisonOp_ExcellentYear);
}
if (Object.prototype.hasOwnProperty.call(objvcc_Course_Cond.dicFldComparisonOp, clsvcc_CourseEN.con_IsBuildingCourse) == true)
{
if (objvcc_Course_Cond.isBuildingCourse == true)
{
strWhereCond += Format(" And {0} = '1'", clsvcc_CourseEN.con_IsBuildingCourse);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvcc_CourseEN.con_IsBuildingCourse);
}
}
if (Object.prototype.hasOwnProperty.call(objvcc_Course_Cond.dicFldComparisonOp, clsvcc_CourseEN.con_IsDoubleLanguageCourse) == true)
{
if (objvcc_Course_Cond.isDoubleLanguageCourse == true)
{
strWhereCond += Format(" And {0} = '1'", clsvcc_CourseEN.con_IsDoubleLanguageCourse);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvcc_CourseEN.con_IsDoubleLanguageCourse);
}
}
if (Object.prototype.hasOwnProperty.call(objvcc_Course_Cond.dicFldComparisonOp, clsvcc_CourseEN.con_IsOpen) == true)
{
if (objvcc_Course_Cond.isOpen == true)
{
strWhereCond += Format(" And {0} = '1'", clsvcc_CourseEN.con_IsOpen);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvcc_CourseEN.con_IsOpen);
}
}
if (Object.prototype.hasOwnProperty.call(objvcc_Course_Cond.dicFldComparisonOp, clsvcc_CourseEN.con_IsRecommendedCourse) == true)
{
if (objvcc_Course_Cond.isRecommendedCourse == true)
{
strWhereCond += Format(" And {0} = '1'", clsvcc_CourseEN.con_IsRecommendedCourse);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvcc_CourseEN.con_IsRecommendedCourse);
}
}
if (Object.prototype.hasOwnProperty.call(objvcc_Course_Cond.dicFldComparisonOp, clsvcc_CourseEN.con_IsSelfPropelledCourse) == true)
{
if (objvcc_Course_Cond.isSelfPropelledCourse == true)
{
strWhereCond += Format(" And {0} = '1'", clsvcc_CourseEN.con_IsSelfPropelledCourse);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvcc_CourseEN.con_IsSelfPropelledCourse);
}
}
if (Object.prototype.hasOwnProperty.call(objvcc_Course_Cond.dicFldComparisonOp, clsvcc_CourseEN.con_OperationDate) == true)
{
const strComparisonOp_OperationDate:string = objvcc_Course_Cond.dicFldComparisonOp[clsvcc_CourseEN.con_OperationDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseEN.con_OperationDate, objvcc_Course_Cond.operationDate, strComparisonOp_OperationDate);
}
if (Object.prototype.hasOwnProperty.call(objvcc_Course_Cond.dicFldComparisonOp, clsvcc_CourseEN.con_OrderNum) == true)
{
const strComparisonOp_OrderNum:string = objvcc_Course_Cond.dicFldComparisonOp[clsvcc_CourseEN.con_OrderNum];
strWhereCond += Format(" And {0} {2} {1}", clsvcc_CourseEN.con_OrderNum, objvcc_Course_Cond.orderNum, strComparisonOp_OrderNum);
}
if (Object.prototype.hasOwnProperty.call(objvcc_Course_Cond.dicFldComparisonOp, clsvcc_CourseEN.con_OuterLink) == true)
{
const strComparisonOp_OuterLink:string = objvcc_Course_Cond.dicFldComparisonOp[clsvcc_CourseEN.con_OuterLink];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseEN.con_OuterLink, objvcc_Course_Cond.outerLink, strComparisonOp_OuterLink);
}
if (Object.prototype.hasOwnProperty.call(objvcc_Course_Cond.dicFldComparisonOp, clsvcc_CourseEN.con_ViewCount) == true)
{
const strComparisonOp_ViewCount:string = objvcc_Course_Cond.dicFldComparisonOp[clsvcc_CourseEN.con_ViewCount];
strWhereCond += Format(" And {0} {2} {1}", clsvcc_CourseEN.con_ViewCount, objvcc_Course_Cond.viewCount, strComparisonOp_ViewCount);
}
if (Object.prototype.hasOwnProperty.call(objvcc_Course_Cond.dicFldComparisonOp, clsvcc_CourseEN.con_ThemeId) == true)
{
const strComparisonOp_ThemeId:string = objvcc_Course_Cond.dicFldComparisonOp[clsvcc_CourseEN.con_ThemeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseEN.con_ThemeId, objvcc_Course_Cond.themeId, strComparisonOp_ThemeId);
}
if (Object.prototype.hasOwnProperty.call(objvcc_Course_Cond.dicFldComparisonOp, clsvcc_CourseEN.con_ThemeName) == true)
{
const strComparisonOp_ThemeName:string = objvcc_Course_Cond.dicFldComparisonOp[clsvcc_CourseEN.con_ThemeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseEN.con_ThemeName, objvcc_Course_Cond.themeName, strComparisonOp_ThemeName);
}
if (Object.prototype.hasOwnProperty.call(objvcc_Course_Cond.dicFldComparisonOp, clsvcc_CourseEN.con_ExampleImgPath) == true)
{
const strComparisonOp_ExampleImgPath:string = objvcc_Course_Cond.dicFldComparisonOp[clsvcc_CourseEN.con_ExampleImgPath];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseEN.con_ExampleImgPath, objvcc_Course_Cond.exampleImgPath, strComparisonOp_ExampleImgPath);
}
if (Object.prototype.hasOwnProperty.call(objvcc_Course_Cond.dicFldComparisonOp, clsvcc_CourseEN.con_id_XzMajor) == true)
{
const strComparisonOp_id_XzMajor:string = objvcc_Course_Cond.dicFldComparisonOp[clsvcc_CourseEN.con_id_XzMajor];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseEN.con_id_XzMajor, objvcc_Course_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (Object.prototype.hasOwnProperty.call(objvcc_Course_Cond.dicFldComparisonOp, clsvcc_CourseEN.con_MajorID) == true)
{
const strComparisonOp_MajorID:string = objvcc_Course_Cond.dicFldComparisonOp[clsvcc_CourseEN.con_MajorID];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseEN.con_MajorID, objvcc_Course_Cond.majorID, strComparisonOp_MajorID);
}
if (Object.prototype.hasOwnProperty.call(objvcc_Course_Cond.dicFldComparisonOp, clsvcc_CourseEN.con_MajorName) == true)
{
const strComparisonOp_MajorName:string = objvcc_Course_Cond.dicFldComparisonOp[clsvcc_CourseEN.con_MajorName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseEN.con_MajorName, objvcc_Course_Cond.majorName, strComparisonOp_MajorName);
}
if (Object.prototype.hasOwnProperty.call(objvcc_Course_Cond.dicFldComparisonOp, clsvcc_CourseEN.con_id_XzCollege) == true)
{
const strComparisonOp_id_XzCollege:string = objvcc_Course_Cond.dicFldComparisonOp[clsvcc_CourseEN.con_id_XzCollege];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseEN.con_id_XzCollege, objvcc_Course_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (Object.prototype.hasOwnProperty.call(objvcc_Course_Cond.dicFldComparisonOp, clsvcc_CourseEN.con_CollegeID) == true)
{
const strComparisonOp_CollegeID:string = objvcc_Course_Cond.dicFldComparisonOp[clsvcc_CourseEN.con_CollegeID];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseEN.con_CollegeID, objvcc_Course_Cond.collegeID, strComparisonOp_CollegeID);
}
if (Object.prototype.hasOwnProperty.call(objvcc_Course_Cond.dicFldComparisonOp, clsvcc_CourseEN.con_CollegeName) == true)
{
const strComparisonOp_CollegeName:string = objvcc_Course_Cond.dicFldComparisonOp[clsvcc_CourseEN.con_CollegeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseEN.con_CollegeName, objvcc_Course_Cond.collegeName, strComparisonOp_CollegeName);
}
if (Object.prototype.hasOwnProperty.call(objvcc_Course_Cond.dicFldComparisonOp, clsvcc_CourseEN.con_CollegeNameA) == true)
{
const strComparisonOp_CollegeNameA:string = objvcc_Course_Cond.dicFldComparisonOp[clsvcc_CourseEN.con_CollegeNameA];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseEN.con_CollegeNameA, objvcc_Course_Cond.collegeNameA, strComparisonOp_CollegeNameA);
}
if (Object.prototype.hasOwnProperty.call(objvcc_Course_Cond.dicFldComparisonOp, clsvcc_CourseEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objvcc_Course_Cond.dicFldComparisonOp[clsvcc_CourseEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseEN.con_Memo, objvcc_Course_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objvcc_CourseENS:源对象
 * @param objvcc_CourseENT:目标对象
*/
export function vcc_Course_CopyObjTo(objvcc_CourseENS: clsvcc_CourseEN , objvcc_CourseENT: clsvcc_CourseEN ): void 
{
objvcc_CourseENT.courseId = objvcc_CourseENS.courseId; //课程Id
objvcc_CourseENT.likeCount = objvcc_CourseENS.likeCount; //LikeCount
objvcc_CourseENT.courseCode = objvcc_CourseENS.courseCode; //课程代码
objvcc_CourseENT.courseDescription = objvcc_CourseENS.courseDescription; //课程描述
objvcc_CourseENT.courseName = objvcc_CourseENS.courseName; //课程名称
objvcc_CourseENT.courseTypeID = objvcc_CourseENS.courseTypeID; //课程类型ID
objvcc_CourseENT.courseTypeName = objvcc_CourseENS.courseTypeName; //课程类型名称
objvcc_CourseENT.createDate = objvcc_CourseENS.createDate; //建立日期
objvcc_CourseENT.excellentTypeId = objvcc_CourseENS.excellentTypeId; //精品课程类型Id
objvcc_CourseENT.excellentTypeName = objvcc_CourseENS.excellentTypeName; //精品课程类型名称
objvcc_CourseENT.excellentYear = objvcc_CourseENS.excellentYear; //课程年份
objvcc_CourseENT.isBuildingCourse = objvcc_CourseENS.isBuildingCourse; //是否已建设课程
objvcc_CourseENT.isDoubleLanguageCourse = objvcc_CourseENS.isDoubleLanguageCourse; //是否双语课程
objvcc_CourseENT.isOpen = objvcc_CourseENS.isOpen; //是否公开
objvcc_CourseENT.isRecommendedCourse = objvcc_CourseENS.isRecommendedCourse; //是否推荐课程
objvcc_CourseENT.isSelfPropelledCourse = objvcc_CourseENS.isSelfPropelledCourse; //是否自荐课程
objvcc_CourseENT.operationDate = objvcc_CourseENS.operationDate; //操作时间
objvcc_CourseENT.orderNum = objvcc_CourseENS.orderNum; //序号
objvcc_CourseENT.outerLink = objvcc_CourseENS.outerLink; //外链地址
objvcc_CourseENT.viewCount = objvcc_CourseENS.viewCount; //浏览量
objvcc_CourseENT.themeId = objvcc_CourseENS.themeId; //主题Id
objvcc_CourseENT.themeName = objvcc_CourseENS.themeName; //主题名
objvcc_CourseENT.exampleImgPath = objvcc_CourseENS.exampleImgPath; //示例图路径
objvcc_CourseENT.id_XzMajor = objvcc_CourseENS.id_XzMajor; //专业流水号
objvcc_CourseENT.majorID = objvcc_CourseENS.majorID; //专业ID
objvcc_CourseENT.majorName = objvcc_CourseENS.majorName; //专业名称
objvcc_CourseENT.id_XzCollege = objvcc_CourseENS.id_XzCollege; //学院流水号
objvcc_CourseENT.collegeID = objvcc_CourseENS.collegeID; //学院ID
objvcc_CourseENT.collegeName = objvcc_CourseENS.collegeName; //学院名称
objvcc_CourseENT.collegeNameA = objvcc_CourseENS.collegeNameA; //学院名称简写
objvcc_CourseENT.memo = objvcc_CourseENS.memo; //备注
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objvcc_CourseENS:源对象
 * @param objvcc_CourseENT:目标对象
*/
export function vcc_Course_GetObjFromJsonObj(objvcc_CourseENS: clsvcc_CourseEN): clsvcc_CourseEN 
{
 const objvcc_CourseENT: clsvcc_CourseEN = new clsvcc_CourseEN();
ObjectAssign(objvcc_CourseENT, objvcc_CourseENS);
 return objvcc_CourseENT;
}