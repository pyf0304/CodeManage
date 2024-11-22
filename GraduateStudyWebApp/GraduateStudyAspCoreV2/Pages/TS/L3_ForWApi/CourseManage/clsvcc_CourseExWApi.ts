
 /**
 * 类名:clsvcc_CourseExWApi
 * 表名:vcc_CourseEx(01120213)
 * 版本:2023.01.07.1(服务器:WIN-SRV103-116)
 * 日期:2023/01/07 23:16:03
 * 生成者:pyf
 * 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:课程管理(CourseManage)
 * 框架-层名:WA_访问层(TS)(WA_Access)
 * 编程语言:TypeScript
 * 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
   *      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 **/

/**
 * v课程Ex(vcc_CourseEx)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2023年01月07日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { enumComparisonOp } from "../../PubFun/enumComparisonOp.js";
import { clsvcc_CourseExEN } from "../../L0_Entity/CourseManage/clsvcc_CourseExEN.js";
import { BindDdl_ObjLstInDiv_V, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const vcc_CourseEx_Controller = "vcc_CourseExApi";
 export const vcc_CourseEx_ConstructorName = "vcc_CourseEx";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strCourseId:关键字
 * @returns 对象
 **/
export async function vcc_CourseEx_GetObjByCourseIdAsync(strCourseId: string): Promise<clsvcc_CourseExEN|null>  
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
const strUrl = GetWebApiUrl(vcc_CourseEx_Controller, strAction);
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
return null;
}
//console.log(returnObj);
const objvcc_CourseEx = vcc_CourseEx_GetObjFromJsonObj(returnObj);
return objvcc_CourseEx;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_CourseEx_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_CourseEx_ConstructorName, strThisFuncName);
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

/**
 * 排序函数。根据关键字字段的值进行比较
 * 作者:pyf
 * 日期:2023-01-07
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
 * @param a:比较的第1个对象
 * @param  b:比较的第1个对象
 * @returns 返回两个对象比较的结果
*/
export function vcc_CourseEx_SortFun_Defa(a:clsvcc_CourseExEN , b:clsvcc_CourseExEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.courseId.localeCompare(b.courseId);
}
/**
 * 排序函数。根据表对象中随机两个字段的值进行比较
 * 作者:pyf
 * 日期:2023-01-07
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
 * @param  a:比较的第1个对象
 * @param  b:比较的第1个对象
 * @returns 返回两个对象比较的结果
*/
export function vcc_CourseEx_SortFun_Defa_2Fld(a:clsvcc_CourseExEN , b:clsvcc_CourseExEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.likeCount == b.likeCount) return a.courseCode.localeCompare(b.courseCode);
else return a.likeCount - b.likeCount;
}

/**
 * 排序函数。根据关键字字段的值进行比较
 * 作者:pyf
 * 日期:2023-01-07
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
 * @param a:比较的第1个对象
 * @param  b:比较的第1个对象
 * @returns 返回两个对象比较的结果
*/
export function vcc_CourseEx_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsvcc_CourseExEN.con_CourseId:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
return a.courseId.localeCompare(b.courseId);
}
case clsvcc_CourseExEN.con_LikeCount:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
return a.likeCount-b.likeCount;
}
case clsvcc_CourseExEN.con_CourseCode:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
return a.courseCode.localeCompare(b.courseCode);
}
case clsvcc_CourseExEN.con_CourseDescription:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
return a.courseDescription.localeCompare(b.courseDescription);
}
case clsvcc_CourseExEN.con_CourseName:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
return a.courseName.localeCompare(b.courseName);
}
case clsvcc_CourseExEN.con_CourseTypeID:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
return a.courseTypeID.localeCompare(b.courseTypeID);
}
case clsvcc_CourseExEN.con_CourseTypeName:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
return a.courseTypeName.localeCompare(b.courseTypeName);
}
case clsvcc_CourseExEN.con_CreateDate:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
return a.createDate.localeCompare(b.createDate);
}
case clsvcc_CourseExEN.con_ExcellentTypeId:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
return a.excellentTypeId.localeCompare(b.excellentTypeId);
}
case clsvcc_CourseExEN.con_ExcellentTypeName:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
return a.excellentTypeName.localeCompare(b.excellentTypeName);
}
case clsvcc_CourseExEN.con_ExcellentYear:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
return a.excellentYear-b.excellentYear;
}
case clsvcc_CourseExEN.con_IsBuildingCourse:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
if (a.isBuildingCourse == true) return 1;
else return -1
}
case clsvcc_CourseExEN.con_IsDoubleLanguageCourse:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
if (a.isDoubleLanguageCourse == true) return 1;
else return -1
}
case clsvcc_CourseExEN.con_IsOpen:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
if (a.isOpen == true) return 1;
else return -1
}
case clsvcc_CourseExEN.con_IsRecommendedCourse:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
if (a.isRecommendedCourse == true) return 1;
else return -1
}
case clsvcc_CourseExEN.con_IsSelfPropelledCourse:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
if (a.isSelfPropelledCourse == true) return 1;
else return -1
}
case clsvcc_CourseExEN.con_OperationDate:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
return a.operationDate.localeCompare(b.operationDate);
}
case clsvcc_CourseExEN.con_OrderNum:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
return a.orderNum-b.orderNum;
}
case clsvcc_CourseExEN.con_OuterLink:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
return a.outerLink.localeCompare(b.outerLink);
}
case clsvcc_CourseExEN.con_ViewCount:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
return a.viewCount-b.viewCount;
}
case clsvcc_CourseExEN.con_ThemeId:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
return a.themeId.localeCompare(b.themeId);
}
case clsvcc_CourseExEN.con_ThemeName:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
return a.themeName.localeCompare(b.themeName);
}
case clsvcc_CourseExEN.con_ExampleImgPath:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
return a.exampleImgPath.localeCompare(b.exampleImgPath);
}
case clsvcc_CourseExEN.con_id_XzMajor:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
return a.id_XzMajor.localeCompare(b.id_XzMajor);
}
case clsvcc_CourseExEN.con_MajorID:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
return a.majorID.localeCompare(b.majorID);
}
case clsvcc_CourseExEN.con_MajorName:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
return a.majorName.localeCompare(b.majorName);
}
case clsvcc_CourseExEN.con_id_XzCollege:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
return a.id_XzCollege.localeCompare(b.id_XzCollege);
}
case clsvcc_CourseExEN.con_CollegeID:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
return a.collegeID.localeCompare(b.collegeID);
}
case clsvcc_CourseExEN.con_CollegeName:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
return a.collegeName.localeCompare(b.collegeName);
}
case clsvcc_CourseExEN.con_CollegeNameA:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
return a.collegeNameA.localeCompare(b.collegeNameA);
}
case clsvcc_CourseExEN.con_Memo:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
return a.memo.localeCompare(b.memo);
}
case clsvcc_CourseExEN.con_QuestionNum:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
return a.questionNum-b.questionNum;
}
case clsvcc_CourseExEN.con_KnowledgesNum:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
return a.knowledgesNum-b.knowledgesNum;
}
case clsvcc_CourseExEN.con_TeacherNum:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
return a.teacherNum-b.teacherNum;
}
case clsvcc_CourseExEN.con_ChapterNum:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
return a.chapterNum-b.chapterNum;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vcc_CourseEx]中不存在！(in ${ vcc_CourseEx_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsvcc_CourseExEN.con_CourseId:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
return b.courseId.localeCompare(a.courseId);
}
case clsvcc_CourseExEN.con_LikeCount:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
return b.likeCount-a.likeCount;
}
case clsvcc_CourseExEN.con_CourseCode:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
return b.courseCode.localeCompare(a.courseCode);
}
case clsvcc_CourseExEN.con_CourseDescription:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
return b.courseDescription.localeCompare(a.courseDescription);
}
case clsvcc_CourseExEN.con_CourseName:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
return b.courseName.localeCompare(a.courseName);
}
case clsvcc_CourseExEN.con_CourseTypeID:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
return b.courseTypeID.localeCompare(a.courseTypeID);
}
case clsvcc_CourseExEN.con_CourseTypeName:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
return b.courseTypeName.localeCompare(a.courseTypeName);
}
case clsvcc_CourseExEN.con_CreateDate:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
return b.createDate.localeCompare(a.createDate);
}
case clsvcc_CourseExEN.con_ExcellentTypeId:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
return b.excellentTypeId.localeCompare(a.excellentTypeId);
}
case clsvcc_CourseExEN.con_ExcellentTypeName:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
return b.excellentTypeName.localeCompare(a.excellentTypeName);
}
case clsvcc_CourseExEN.con_ExcellentYear:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
return b.excellentYear-a.excellentYear;
}
case clsvcc_CourseExEN.con_IsBuildingCourse:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
if (b.isBuildingCourse == true) return 1;
else return -1
}
case clsvcc_CourseExEN.con_IsDoubleLanguageCourse:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
if (b.isDoubleLanguageCourse == true) return 1;
else return -1
}
case clsvcc_CourseExEN.con_IsOpen:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
if (b.isOpen == true) return 1;
else return -1
}
case clsvcc_CourseExEN.con_IsRecommendedCourse:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
if (b.isRecommendedCourse == true) return 1;
else return -1
}
case clsvcc_CourseExEN.con_IsSelfPropelledCourse:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
if (b.isSelfPropelledCourse == true) return 1;
else return -1
}
case clsvcc_CourseExEN.con_OperationDate:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
return b.operationDate.localeCompare(a.operationDate);
}
case clsvcc_CourseExEN.con_OrderNum:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
return b.orderNum-a.orderNum;
}
case clsvcc_CourseExEN.con_OuterLink:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
return b.outerLink.localeCompare(a.outerLink);
}
case clsvcc_CourseExEN.con_ViewCount:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
return b.viewCount-a.viewCount;
}
case clsvcc_CourseExEN.con_ThemeId:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
return b.themeId.localeCompare(a.themeId);
}
case clsvcc_CourseExEN.con_ThemeName:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
return b.themeName.localeCompare(a.themeName);
}
case clsvcc_CourseExEN.con_ExampleImgPath:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
return b.exampleImgPath.localeCompare(a.exampleImgPath);
}
case clsvcc_CourseExEN.con_id_XzMajor:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
return b.id_XzMajor.localeCompare(a.id_XzMajor);
}
case clsvcc_CourseExEN.con_MajorID:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
return b.majorID.localeCompare(a.majorID);
}
case clsvcc_CourseExEN.con_MajorName:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
return b.majorName.localeCompare(a.majorName);
}
case clsvcc_CourseExEN.con_id_XzCollege:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
return b.id_XzCollege.localeCompare(a.id_XzCollege);
}
case clsvcc_CourseExEN.con_CollegeID:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
return b.collegeID.localeCompare(a.collegeID);
}
case clsvcc_CourseExEN.con_CollegeName:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
return b.collegeName.localeCompare(a.collegeName);
}
case clsvcc_CourseExEN.con_CollegeNameA:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
return b.collegeNameA.localeCompare(a.collegeNameA);
}
case clsvcc_CourseExEN.con_Memo:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
return b.memo.localeCompare(a.memo);
}
case clsvcc_CourseExEN.con_QuestionNum:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
return b.questionNum-a.questionNum;
}
case clsvcc_CourseExEN.con_KnowledgesNum:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
return b.knowledgesNum-a.knowledgesNum;
}
case clsvcc_CourseExEN.con_TeacherNum:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
return b.teacherNum-a.teacherNum;
}
case clsvcc_CourseExEN.con_ChapterNum:
return (a: clsvcc_CourseExEN, b: clsvcc_CourseExEN) => {
return b.chapterNum-a.chapterNum;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vcc_CourseEx]中不存在！(in ${ vcc_CourseEx_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
}

/**
 * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
 * 作者:pyf
 * 日期:2023-01-07
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
 * @param strKey:比较的关键字段名称
 * @param value:给定值
 * @returns 返回对象的字段值是否等于给定值
*/
export async function vcc_CourseEx_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsvcc_CourseExEN.con_CourseId:
return (obj: clsvcc_CourseExEN) => {
return obj.courseId === value;
}
case clsvcc_CourseExEN.con_LikeCount:
return (obj: clsvcc_CourseExEN) => {
return obj.likeCount === value;
}
case clsvcc_CourseExEN.con_CourseCode:
return (obj: clsvcc_CourseExEN) => {
return obj.courseCode === value;
}
case clsvcc_CourseExEN.con_CourseDescription:
return (obj: clsvcc_CourseExEN) => {
return obj.courseDescription === value;
}
case clsvcc_CourseExEN.con_CourseName:
return (obj: clsvcc_CourseExEN) => {
return obj.courseName === value;
}
case clsvcc_CourseExEN.con_CourseTypeID:
return (obj: clsvcc_CourseExEN) => {
return obj.courseTypeID === value;
}
case clsvcc_CourseExEN.con_CourseTypeName:
return (obj: clsvcc_CourseExEN) => {
return obj.courseTypeName === value;
}
case clsvcc_CourseExEN.con_CreateDate:
return (obj: clsvcc_CourseExEN) => {
return obj.createDate === value;
}
case clsvcc_CourseExEN.con_ExcellentTypeId:
return (obj: clsvcc_CourseExEN) => {
return obj.excellentTypeId === value;
}
case clsvcc_CourseExEN.con_ExcellentTypeName:
return (obj: clsvcc_CourseExEN) => {
return obj.excellentTypeName === value;
}
case clsvcc_CourseExEN.con_ExcellentYear:
return (obj: clsvcc_CourseExEN) => {
return obj.excellentYear === value;
}
case clsvcc_CourseExEN.con_IsBuildingCourse:
return (obj: clsvcc_CourseExEN) => {
return obj.isBuildingCourse === value;
}
case clsvcc_CourseExEN.con_IsDoubleLanguageCourse:
return (obj: clsvcc_CourseExEN) => {
return obj.isDoubleLanguageCourse === value;
}
case clsvcc_CourseExEN.con_IsOpen:
return (obj: clsvcc_CourseExEN) => {
return obj.isOpen === value;
}
case clsvcc_CourseExEN.con_IsRecommendedCourse:
return (obj: clsvcc_CourseExEN) => {
return obj.isRecommendedCourse === value;
}
case clsvcc_CourseExEN.con_IsSelfPropelledCourse:
return (obj: clsvcc_CourseExEN) => {
return obj.isSelfPropelledCourse === value;
}
case clsvcc_CourseExEN.con_OperationDate:
return (obj: clsvcc_CourseExEN) => {
return obj.operationDate === value;
}
case clsvcc_CourseExEN.con_OrderNum:
return (obj: clsvcc_CourseExEN) => {
return obj.orderNum === value;
}
case clsvcc_CourseExEN.con_OuterLink:
return (obj: clsvcc_CourseExEN) => {
return obj.outerLink === value;
}
case clsvcc_CourseExEN.con_ViewCount:
return (obj: clsvcc_CourseExEN) => {
return obj.viewCount === value;
}
case clsvcc_CourseExEN.con_ThemeId:
return (obj: clsvcc_CourseExEN) => {
return obj.themeId === value;
}
case clsvcc_CourseExEN.con_ThemeName:
return (obj: clsvcc_CourseExEN) => {
return obj.themeName === value;
}
case clsvcc_CourseExEN.con_ExampleImgPath:
return (obj: clsvcc_CourseExEN) => {
return obj.exampleImgPath === value;
}
case clsvcc_CourseExEN.con_id_XzMajor:
return (obj: clsvcc_CourseExEN) => {
return obj.id_XzMajor === value;
}
case clsvcc_CourseExEN.con_MajorID:
return (obj: clsvcc_CourseExEN) => {
return obj.majorID === value;
}
case clsvcc_CourseExEN.con_MajorName:
return (obj: clsvcc_CourseExEN) => {
return obj.majorName === value;
}
case clsvcc_CourseExEN.con_id_XzCollege:
return (obj: clsvcc_CourseExEN) => {
return obj.id_XzCollege === value;
}
case clsvcc_CourseExEN.con_CollegeID:
return (obj: clsvcc_CourseExEN) => {
return obj.collegeID === value;
}
case clsvcc_CourseExEN.con_CollegeName:
return (obj: clsvcc_CourseExEN) => {
return obj.collegeName === value;
}
case clsvcc_CourseExEN.con_CollegeNameA:
return (obj: clsvcc_CourseExEN) => {
return obj.collegeNameA === value;
}
case clsvcc_CourseExEN.con_Memo:
return (obj: clsvcc_CourseExEN) => {
return obj.memo === value;
}
case clsvcc_CourseExEN.con_QuestionNum:
return (obj: clsvcc_CourseExEN) => {
return obj.questionNum === value;
}
case clsvcc_CourseExEN.con_KnowledgesNum:
return (obj: clsvcc_CourseExEN) => {
return obj.knowledgesNum === value;
}
case clsvcc_CourseExEN.con_TeacherNum:
return (obj: clsvcc_CourseExEN) => {
return obj.teacherNum === value;
}
case clsvcc_CourseExEN.con_ChapterNum:
return (obj: clsvcc_CourseExEN) => {
return obj.chapterNum === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vcc_CourseEx]中不存在！(in ${ vcc_CourseEx_ConstructorName}.${ strThisFuncName})`;
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
export async function vcc_CourseEx_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vcc_CourseEx_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_CourseEx_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_CourseEx_ConstructorName, strThisFuncName);
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
export async function vcc_CourseEx_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vcc_CourseEx_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_CourseEx_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_CourseEx_ConstructorName, strThisFuncName);
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
export async function vcc_CourseEx_GetFirstObjAsync(strWhereCond: string): Promise<clsvcc_CourseExEN|null>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(vcc_CourseEx_Controller, strAction);
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
const objvcc_CourseEx = vcc_CourseEx_GetObjFromJsonObj(returnObj);
return objvcc_CourseEx;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_CourseEx_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_CourseEx_ConstructorName, strThisFuncName);
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
export async function vcc_CourseEx_GetObjLstAsync(strWhereCond: string): Promise<Array<clsvcc_CourseExEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(vcc_CourseEx_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vcc_CourseEx_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vcc_CourseEx_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_CourseEx_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_CourseEx_ConstructorName, strThisFuncName);
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
 * @param arrCourseId:关键字列表
 * @returns 对象列表
 **/
export async function vcc_CourseEx_GetObjLstByCourseIdLstAsync(arrCourseId: Array<string>): Promise<Array<clsvcc_CourseExEN>>  
{
const strThisFuncName = "GetObjLstByCourseIdLstAsync";
const strAction = "GetObjLstByCourseIdLst";
const strUrl = GetWebApiUrl(vcc_CourseEx_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrCourseId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vcc_CourseEx_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vcc_CourseEx_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_CourseEx_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_CourseEx_ConstructorName, strThisFuncName);
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
export async function vcc_CourseEx_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsvcc_CourseExEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(vcc_CourseEx_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vcc_CourseEx_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vcc_CourseEx_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_CourseEx_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_CourseEx_ConstructorName, strThisFuncName);
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
export async function vcc_CourseEx_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsvcc_CourseExEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vcc_CourseEx_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vcc_CourseEx_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vcc_CourseEx_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_CourseEx_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_CourseEx_ConstructorName, strThisFuncName);
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
export async function vcc_CourseEx_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vcc_CourseEx_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_CourseEx_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_CourseEx_ConstructorName, strThisFuncName);
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
export async function vcc_CourseEx_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsvcc_CourseExEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(vcc_CourseEx_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vcc_CourseEx_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vcc_CourseEx_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_CourseEx_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_CourseEx_ConstructorName, strThisFuncName);
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
export async function vcc_CourseEx_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(vcc_CourseEx_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_CourseEx_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_CourseEx_ConstructorName, strThisFuncName);
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
export async function vcc_CourseEx_IsExist(strCourseId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vcc_CourseEx_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"courseId": strCourseId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_CourseEx_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_CourseEx_ConstructorName, strThisFuncName);
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
 * @param strCourseId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function vcc_CourseEx_IsExistAsync(strCourseId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vcc_CourseEx_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_CourseEx_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_CourseEx_ConstructorName, strThisFuncName);
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
export async function vcc_CourseEx_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(vcc_CourseEx_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_CourseEx_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_CourseEx_ConstructorName, strThisFuncName);
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
 * 获取WebApi的地址
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
 * @returns 返回当前文件中Web服务的地址
*/
export function vcc_CourseEx_GetWebApiUrl(strController: string, strAction: string): string {
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

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2023-01-07
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vcc_CourseEx_GetJSONStrByObj (pobjvcc_CourseExEN: clsvcc_CourseExEN): string
{
const strThisFuncName = "GetJSONStrByObj";
let strJson = "";
try
{
strJson = JSON.stringify(pobjvcc_CourseExEN);
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
 * 日期:2023-01-07
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象列表
*/
export function vcc_CourseEx_GetObjLstByJSONStr (strJSON: string): Array<clsvcc_CourseExEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrvcc_CourseExObjLst = new Array<clsvcc_CourseExEN>();
if (strJSON === "")
{
return arrvcc_CourseExObjLst;
}
try
{
arrvcc_CourseExObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvcc_CourseExObjLst;
}
return arrvcc_CourseExObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2023-01-07
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrvcc_CourseExObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function vcc_CourseEx_GetObjLstByJSONObjLst (arrvcc_CourseExObjLstS: Array<clsvcc_CourseExEN>): Array<clsvcc_CourseExEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrvcc_CourseExObjLst = new Array<clsvcc_CourseExEN>();
for (const objInFor of arrvcc_CourseExObjLstS) {
const obj1 = vcc_CourseEx_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrvcc_CourseExObjLst.push(obj1);
}
return arrvcc_CourseExObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2023-01-07
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vcc_CourseEx_GetObjByJSONStr (strJSON: string): clsvcc_CourseExEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjvcc_CourseExEN = new clsvcc_CourseExEN();
if (strJSON === "")
{
return pobjvcc_CourseExEN;
}
try
{
pobjvcc_CourseExEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvcc_CourseExEN;
}
return pobjvcc_CourseExEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function vcc_CourseEx_GetCombineCondition(objvcc_CourseEx_Cond: clsvcc_CourseExEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN.con_CourseId) == true)
{
const strComparisonOp_CourseId:string = objvcc_CourseEx_Cond.dicFldComparisonOp[clsvcc_CourseExEN.con_CourseId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseExEN.con_CourseId, objvcc_CourseEx_Cond.courseId, strComparisonOp_CourseId);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN.con_LikeCount) == true)
{
const strComparisonOp_LikeCount:string = objvcc_CourseEx_Cond.dicFldComparisonOp[clsvcc_CourseExEN.con_LikeCount];
strWhereCond += Format(" And {0} {2} {1}", clsvcc_CourseExEN.con_LikeCount, objvcc_CourseEx_Cond.likeCount, strComparisonOp_LikeCount);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN.con_CourseCode) == true)
{
const strComparisonOp_CourseCode:string = objvcc_CourseEx_Cond.dicFldComparisonOp[clsvcc_CourseExEN.con_CourseCode];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseExEN.con_CourseCode, objvcc_CourseEx_Cond.courseCode, strComparisonOp_CourseCode);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN.con_CourseDescription) == true)
{
const strComparisonOp_CourseDescription:string = objvcc_CourseEx_Cond.dicFldComparisonOp[clsvcc_CourseExEN.con_CourseDescription];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseExEN.con_CourseDescription, objvcc_CourseEx_Cond.courseDescription, strComparisonOp_CourseDescription);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN.con_CourseName) == true)
{
const strComparisonOp_CourseName:string = objvcc_CourseEx_Cond.dicFldComparisonOp[clsvcc_CourseExEN.con_CourseName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseExEN.con_CourseName, objvcc_CourseEx_Cond.courseName, strComparisonOp_CourseName);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN.con_CourseTypeID) == true)
{
const strComparisonOp_CourseTypeID:string = objvcc_CourseEx_Cond.dicFldComparisonOp[clsvcc_CourseExEN.con_CourseTypeID];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseExEN.con_CourseTypeID, objvcc_CourseEx_Cond.courseTypeID, strComparisonOp_CourseTypeID);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN.con_CourseTypeName) == true)
{
const strComparisonOp_CourseTypeName:string = objvcc_CourseEx_Cond.dicFldComparisonOp[clsvcc_CourseExEN.con_CourseTypeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseExEN.con_CourseTypeName, objvcc_CourseEx_Cond.courseTypeName, strComparisonOp_CourseTypeName);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN.con_CreateDate) == true)
{
const strComparisonOp_CreateDate:string = objvcc_CourseEx_Cond.dicFldComparisonOp[clsvcc_CourseExEN.con_CreateDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseExEN.con_CreateDate, objvcc_CourseEx_Cond.createDate, strComparisonOp_CreateDate);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN.con_ExcellentTypeId) == true)
{
const strComparisonOp_ExcellentTypeId:string = objvcc_CourseEx_Cond.dicFldComparisonOp[clsvcc_CourseExEN.con_ExcellentTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseExEN.con_ExcellentTypeId, objvcc_CourseEx_Cond.excellentTypeId, strComparisonOp_ExcellentTypeId);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN.con_ExcellentTypeName) == true)
{
const strComparisonOp_ExcellentTypeName:string = objvcc_CourseEx_Cond.dicFldComparisonOp[clsvcc_CourseExEN.con_ExcellentTypeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseExEN.con_ExcellentTypeName, objvcc_CourseEx_Cond.excellentTypeName, strComparisonOp_ExcellentTypeName);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN.con_ExcellentYear) == true)
{
const strComparisonOp_ExcellentYear:string = objvcc_CourseEx_Cond.dicFldComparisonOp[clsvcc_CourseExEN.con_ExcellentYear];
strWhereCond += Format(" And {0} {2} {1}", clsvcc_CourseExEN.con_ExcellentYear, objvcc_CourseEx_Cond.excellentYear, strComparisonOp_ExcellentYear);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN.con_IsBuildingCourse) == true)
{
if (objvcc_CourseEx_Cond.isBuildingCourse == true)
{
strWhereCond += Format(" And {0} = '1'", clsvcc_CourseExEN.con_IsBuildingCourse);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvcc_CourseExEN.con_IsBuildingCourse);
}
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN.con_IsDoubleLanguageCourse) == true)
{
if (objvcc_CourseEx_Cond.isDoubleLanguageCourse == true)
{
strWhereCond += Format(" And {0} = '1'", clsvcc_CourseExEN.con_IsDoubleLanguageCourse);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvcc_CourseExEN.con_IsDoubleLanguageCourse);
}
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN.con_IsOpen) == true)
{
if (objvcc_CourseEx_Cond.isOpen == true)
{
strWhereCond += Format(" And {0} = '1'", clsvcc_CourseExEN.con_IsOpen);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvcc_CourseExEN.con_IsOpen);
}
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN.con_IsRecommendedCourse) == true)
{
if (objvcc_CourseEx_Cond.isRecommendedCourse == true)
{
strWhereCond += Format(" And {0} = '1'", clsvcc_CourseExEN.con_IsRecommendedCourse);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvcc_CourseExEN.con_IsRecommendedCourse);
}
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN.con_IsSelfPropelledCourse) == true)
{
if (objvcc_CourseEx_Cond.isSelfPropelledCourse == true)
{
strWhereCond += Format(" And {0} = '1'", clsvcc_CourseExEN.con_IsSelfPropelledCourse);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvcc_CourseExEN.con_IsSelfPropelledCourse);
}
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN.con_OperationDate) == true)
{
const strComparisonOp_OperationDate:string = objvcc_CourseEx_Cond.dicFldComparisonOp[clsvcc_CourseExEN.con_OperationDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseExEN.con_OperationDate, objvcc_CourseEx_Cond.operationDate, strComparisonOp_OperationDate);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN.con_OrderNum) == true)
{
const strComparisonOp_OrderNum:string = objvcc_CourseEx_Cond.dicFldComparisonOp[clsvcc_CourseExEN.con_OrderNum];
strWhereCond += Format(" And {0} {2} {1}", clsvcc_CourseExEN.con_OrderNum, objvcc_CourseEx_Cond.orderNum, strComparisonOp_OrderNum);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN.con_OuterLink) == true)
{
const strComparisonOp_OuterLink:string = objvcc_CourseEx_Cond.dicFldComparisonOp[clsvcc_CourseExEN.con_OuterLink];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseExEN.con_OuterLink, objvcc_CourseEx_Cond.outerLink, strComparisonOp_OuterLink);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN.con_ViewCount) == true)
{
const strComparisonOp_ViewCount:string = objvcc_CourseEx_Cond.dicFldComparisonOp[clsvcc_CourseExEN.con_ViewCount];
strWhereCond += Format(" And {0} {2} {1}", clsvcc_CourseExEN.con_ViewCount, objvcc_CourseEx_Cond.viewCount, strComparisonOp_ViewCount);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN.con_ThemeId) == true)
{
const strComparisonOp_ThemeId:string = objvcc_CourseEx_Cond.dicFldComparisonOp[clsvcc_CourseExEN.con_ThemeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseExEN.con_ThemeId, objvcc_CourseEx_Cond.themeId, strComparisonOp_ThemeId);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN.con_ThemeName) == true)
{
const strComparisonOp_ThemeName:string = objvcc_CourseEx_Cond.dicFldComparisonOp[clsvcc_CourseExEN.con_ThemeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseExEN.con_ThemeName, objvcc_CourseEx_Cond.themeName, strComparisonOp_ThemeName);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN.con_ExampleImgPath) == true)
{
const strComparisonOp_ExampleImgPath:string = objvcc_CourseEx_Cond.dicFldComparisonOp[clsvcc_CourseExEN.con_ExampleImgPath];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseExEN.con_ExampleImgPath, objvcc_CourseEx_Cond.exampleImgPath, strComparisonOp_ExampleImgPath);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN.con_id_XzMajor) == true)
{
const strComparisonOp_id_XzMajor:string = objvcc_CourseEx_Cond.dicFldComparisonOp[clsvcc_CourseExEN.con_id_XzMajor];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseExEN.con_id_XzMajor, objvcc_CourseEx_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN.con_MajorID) == true)
{
const strComparisonOp_MajorID:string = objvcc_CourseEx_Cond.dicFldComparisonOp[clsvcc_CourseExEN.con_MajorID];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseExEN.con_MajorID, objvcc_CourseEx_Cond.majorID, strComparisonOp_MajorID);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN.con_MajorName) == true)
{
const strComparisonOp_MajorName:string = objvcc_CourseEx_Cond.dicFldComparisonOp[clsvcc_CourseExEN.con_MajorName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseExEN.con_MajorName, objvcc_CourseEx_Cond.majorName, strComparisonOp_MajorName);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN.con_id_XzCollege) == true)
{
const strComparisonOp_id_XzCollege:string = objvcc_CourseEx_Cond.dicFldComparisonOp[clsvcc_CourseExEN.con_id_XzCollege];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseExEN.con_id_XzCollege, objvcc_CourseEx_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN.con_CollegeID) == true)
{
const strComparisonOp_CollegeID:string = objvcc_CourseEx_Cond.dicFldComparisonOp[clsvcc_CourseExEN.con_CollegeID];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseExEN.con_CollegeID, objvcc_CourseEx_Cond.collegeID, strComparisonOp_CollegeID);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN.con_CollegeName) == true)
{
const strComparisonOp_CollegeName:string = objvcc_CourseEx_Cond.dicFldComparisonOp[clsvcc_CourseExEN.con_CollegeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseExEN.con_CollegeName, objvcc_CourseEx_Cond.collegeName, strComparisonOp_CollegeName);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN.con_CollegeNameA) == true)
{
const strComparisonOp_CollegeNameA:string = objvcc_CourseEx_Cond.dicFldComparisonOp[clsvcc_CourseExEN.con_CollegeNameA];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseExEN.con_CollegeNameA, objvcc_CourseEx_Cond.collegeNameA, strComparisonOp_CollegeNameA);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objvcc_CourseEx_Cond.dicFldComparisonOp[clsvcc_CourseExEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseExEN.con_Memo, objvcc_CourseEx_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN.con_QuestionNum) == true)
{
const strComparisonOp_QuestionNum:string = objvcc_CourseEx_Cond.dicFldComparisonOp[clsvcc_CourseExEN.con_QuestionNum];
strWhereCond += Format(" And {0} {2} {1}", clsvcc_CourseExEN.con_QuestionNum, objvcc_CourseEx_Cond.questionNum, strComparisonOp_QuestionNum);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN.con_KnowledgesNum) == true)
{
const strComparisonOp_KnowledgesNum:string = objvcc_CourseEx_Cond.dicFldComparisonOp[clsvcc_CourseExEN.con_KnowledgesNum];
strWhereCond += Format(" And {0} {2} {1}", clsvcc_CourseExEN.con_KnowledgesNum, objvcc_CourseEx_Cond.knowledgesNum, strComparisonOp_KnowledgesNum);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN.con_TeacherNum) == true)
{
const strComparisonOp_TeacherNum:string = objvcc_CourseEx_Cond.dicFldComparisonOp[clsvcc_CourseExEN.con_TeacherNum];
strWhereCond += Format(" And {0} {2} {1}", clsvcc_CourseExEN.con_TeacherNum, objvcc_CourseEx_Cond.teacherNum, strComparisonOp_TeacherNum);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseEx_Cond.dicFldComparisonOp, clsvcc_CourseExEN.con_ChapterNum) == true)
{
const strComparisonOp_ChapterNum:string = objvcc_CourseEx_Cond.dicFldComparisonOp[clsvcc_CourseExEN.con_ChapterNum];
strWhereCond += Format(" And {0} {2} {1}", clsvcc_CourseExEN.con_ChapterNum, objvcc_CourseEx_Cond.chapterNum, strComparisonOp_ChapterNum);
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objvcc_CourseExENS:源对象
 * @param objvcc_CourseExENT:目标对象
*/
export function vcc_CourseEx_CopyObjTo(objvcc_CourseExENS: clsvcc_CourseExEN , objvcc_CourseExENT: clsvcc_CourseExEN ): void 
{
objvcc_CourseExENT.courseId = objvcc_CourseExENS.courseId; //课程Id
objvcc_CourseExENT.likeCount = objvcc_CourseExENS.likeCount; //LikeCount
objvcc_CourseExENT.courseCode = objvcc_CourseExENS.courseCode; //课程代码
objvcc_CourseExENT.courseDescription = objvcc_CourseExENS.courseDescription; //课程描述
objvcc_CourseExENT.courseName = objvcc_CourseExENS.courseName; //课程名称
objvcc_CourseExENT.courseTypeID = objvcc_CourseExENS.courseTypeID; //课程类型ID
objvcc_CourseExENT.courseTypeName = objvcc_CourseExENS.courseTypeName; //课程类型名称
objvcc_CourseExENT.createDate = objvcc_CourseExENS.createDate; //建立日期
objvcc_CourseExENT.excellentTypeId = objvcc_CourseExENS.excellentTypeId; //精品课程类型Id
objvcc_CourseExENT.excellentTypeName = objvcc_CourseExENS.excellentTypeName; //精品课程类型名称
objvcc_CourseExENT.excellentYear = objvcc_CourseExENS.excellentYear; //课程年份
objvcc_CourseExENT.isBuildingCourse = objvcc_CourseExENS.isBuildingCourse; //是否已建设课程
objvcc_CourseExENT.isDoubleLanguageCourse = objvcc_CourseExENS.isDoubleLanguageCourse; //是否双语课程
objvcc_CourseExENT.isOpen = objvcc_CourseExENS.isOpen; //是否公开
objvcc_CourseExENT.isRecommendedCourse = objvcc_CourseExENS.isRecommendedCourse; //是否推荐课程
objvcc_CourseExENT.isSelfPropelledCourse = objvcc_CourseExENS.isSelfPropelledCourse; //是否自荐课程
objvcc_CourseExENT.operationDate = objvcc_CourseExENS.operationDate; //操作时间
objvcc_CourseExENT.orderNum = objvcc_CourseExENS.orderNum; //序号
objvcc_CourseExENT.outerLink = objvcc_CourseExENS.outerLink; //外链地址
objvcc_CourseExENT.viewCount = objvcc_CourseExENS.viewCount; //浏览量
objvcc_CourseExENT.themeId = objvcc_CourseExENS.themeId; //主题Id
objvcc_CourseExENT.themeName = objvcc_CourseExENS.themeName; //主题名
objvcc_CourseExENT.exampleImgPath = objvcc_CourseExENS.exampleImgPath; //示例图路径
objvcc_CourseExENT.id_XzMajor = objvcc_CourseExENS.id_XzMajor; //专业流水号
objvcc_CourseExENT.majorID = objvcc_CourseExENS.majorID; //专业ID
objvcc_CourseExENT.majorName = objvcc_CourseExENS.majorName; //专业名称
objvcc_CourseExENT.id_XzCollege = objvcc_CourseExENS.id_XzCollege; //学院流水号
objvcc_CourseExENT.collegeID = objvcc_CourseExENS.collegeID; //学院ID
objvcc_CourseExENT.collegeName = objvcc_CourseExENS.collegeName; //学院名称
objvcc_CourseExENT.collegeNameA = objvcc_CourseExENS.collegeNameA; //学院名称简写
objvcc_CourseExENT.memo = objvcc_CourseExENS.memo; //备注
objvcc_CourseExENT.questionNum = objvcc_CourseExENS.questionNum; //题目数
objvcc_CourseExENT.knowledgesNum = objvcc_CourseExENS.knowledgesNum; //知识点数
objvcc_CourseExENT.teacherNum = objvcc_CourseExENS.teacherNum; //教师数
objvcc_CourseExENT.chapterNum = objvcc_CourseExENS.chapterNum; //章节数
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objvcc_CourseExENS:源对象
 * @param objvcc_CourseExENT:目标对象
*/
export function vcc_CourseEx_GetObjFromJsonObj(objvcc_CourseExENS: clsvcc_CourseExEN): clsvcc_CourseExEN 
{
 const objvcc_CourseExENT: clsvcc_CourseExEN = new clsvcc_CourseExEN();
ObjectAssign(objvcc_CourseExENT, objvcc_CourseExENS);
 return objvcc_CourseExENT;
}