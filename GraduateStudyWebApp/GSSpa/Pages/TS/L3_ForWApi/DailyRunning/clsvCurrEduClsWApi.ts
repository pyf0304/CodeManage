
 /**
 * 类名:clsvCurrEduClsWApi
 * 表名:vCurrEduCls(01120126)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 12:02:28
 * 生成者:pyf
 * 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:日常运行(DailyRunning)
 * 框架-层名:WA_访问层(TS)(WA_Access)
 * 编程语言:TypeScript
 * 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
   *      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 **/

/**
 * v当前教学班(vCurrEduCls)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clsvCurrEduClsEN } from "../../L0_Entity/DailyRunning/clsvCurrEduClsEN.js";
import { BindDdl_ObjLstInDiv_V, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const vCurrEduCls_Controller = "vCurrEduClsApi";
 export const vCurrEduCls_ConstructorName = "vCurrEduCls";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strid_CurrEduCls:关键字
 * @returns 对象
 **/
export async function vCurrEduCls_GetObjByid_CurrEduClsAsync(strid_CurrEduCls: string): Promise<clsvCurrEduClsEN>  
{
const strThisFuncName = "GetObjByid_CurrEduClsAsync";

if (IsNullOrEmpty(strid_CurrEduCls) == true)
{
  const strMsg = Format("参数:[strid_CurrEduCls]不能为空！(In GetObjByid_CurrEduClsAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_CurrEduCls.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！", strid_CurrEduCls.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByid_CurrEduCls";
const strUrl = GetWebApiUrl(vCurrEduCls_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strid_CurrEduCls": strid_CurrEduCls,
}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObj = data.returnObj;
if (returnObj == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vCurrEduCls_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvCurrEduCls = vCurrEduCls_GetObjFromJsonObj(returnObj);
return objvCurrEduCls;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vCurrEduCls_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vCurrEduCls_ConstructorName, strThisFuncName);
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
 * @param strid_CurrEduCls:所给的关键字
 * @returns 对象
*/
export async function vCurrEduCls_GetObjByid_CurrEduCls_Cache(strid_CurrEduCls: string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByid_CurrEduCls_Cache";

if (IsNullOrEmpty(strid_CurrEduCls) == true)
{
  const strMsg = Format("参数:[strid_CurrEduCls]不能为空！(In GetObjByid_CurrEduCls_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_CurrEduCls.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！", strid_CurrEduCls.length);
console.error(strMsg);
throw (strMsg);
}
const arrvCurrEduClsObjLst_Cache = await vCurrEduCls_GetObjLst_Cache();
try
{
const arrvCurrEduCls_Sel: Array <clsvCurrEduClsEN> = arrvCurrEduClsObjLst_Cache.filter(x => x.id_CurrEduCls == strid_CurrEduCls);
let objvCurrEduCls: clsvCurrEduClsEN;
if (arrvCurrEduCls_Sel.length > 0)
{
objvCurrEduCls = arrvCurrEduCls_Sel[0];
return objvCurrEduCls;
}
else
{
if (bolTryAsyncOnce == true)
{
objvCurrEduCls = await vCurrEduCls_GetObjByid_CurrEduClsAsync(strid_CurrEduCls);
if (objvCurrEduCls != null)
{
vCurrEduCls_ReFreshThisCache();
return objvCurrEduCls;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strid_CurrEduCls, vCurrEduCls_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param strid_CurrEduCls:所给的关键字
 * @returns 对象
*/
export async function vCurrEduCls_GetObjByid_CurrEduCls_localStorage(strid_CurrEduCls: string) {
const strThisFuncName = "GetObjByid_CurrEduCls_localStorage";

if (IsNullOrEmpty(strid_CurrEduCls) == true)
{
  const strMsg = Format("参数:[strid_CurrEduCls]不能为空！(In GetObjByid_CurrEduCls_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_CurrEduCls.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！", strid_CurrEduCls.length);
console.error(strMsg);
throw (strMsg);
}
const strKey = Format("{0}_{1}", clsvCurrEduClsEN._CurrTabName, strid_CurrEduCls);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objvCurrEduCls_Cache: clsvCurrEduClsEN = JSON.parse(strTempObj);
return objvCurrEduCls_Cache;
}
try
{
const objvCurrEduCls = await vCurrEduCls_GetObjByid_CurrEduClsAsync(strid_CurrEduCls);
if (objvCurrEduCls != null)
{
localStorage.setItem(strKey, JSON.stringify(objvCurrEduCls));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objvCurrEduCls;
}
return objvCurrEduCls;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strid_CurrEduCls, vCurrEduCls_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 根据关键字获取相关对象的名称属性, 从缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
 * @param strid_CurrEduCls:所给的关键字
 * @returns 对象
*/
export async function vCurrEduCls_GetNameByid_CurrEduCls_Cache(strid_CurrEduCls: string) {
const strThisFuncName = "GetNameByid_CurrEduCls_Cache";

if (IsNullOrEmpty(strid_CurrEduCls) == true)
{
  const strMsg = Format("参数:[strid_CurrEduCls]不能为空！(In GetNameByid_CurrEduCls_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_CurrEduCls.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！", strid_CurrEduCls.length);
console.error(strMsg);
throw (strMsg);
}
const arrvCurrEduClsObjLst_Cache = await vCurrEduCls_GetObjLst_Cache();
if (arrvCurrEduClsObjLst_Cache == null) return "";
try
{
const arrvCurrEduCls_Sel: Array <clsvCurrEduClsEN> = arrvCurrEduClsObjLst_Cache.filter(x => x.id_CurrEduCls == strid_CurrEduCls);
let objvCurrEduCls: clsvCurrEduClsEN;
if (arrvCurrEduCls_Sel.length > 0)
{
objvCurrEduCls = arrvCurrEduCls_Sel[0];
return objvCurrEduCls.eduClsName;
}
else
{
return "";
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strid_CurrEduCls);
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
export async function vCurrEduCls_func(strInFldName:string , strOutFldName:string ,  strInValue: string) 
{
//const strThisFuncName = "func";

if (strInFldName != clsvCurrEduClsEN.con_id_CurrEduCls)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsvCurrEduClsEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clsvCurrEduClsEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strid_CurrEduCls = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objvCurrEduCls = await vCurrEduCls_GetObjByid_CurrEduCls_Cache(strid_CurrEduCls );
if (objvCurrEduCls == null) return "";
return objvCurrEduCls.GetFldValue(strOutFldName).toString();
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
export function vCurrEduCls_SortFun_Defa(a:clsvCurrEduClsEN , b:clsvCurrEduClsEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
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
export function vCurrEduCls_SortFun_Defa_2Fld(a:clsvCurrEduClsEN , b:clsvCurrEduClsEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.currEduClsId == b.currEduClsId) return a.eduClsName.localeCompare(b.eduClsName);
else return a.currEduClsId.localeCompare(b.currEduClsId);
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
export function vCurrEduCls_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsvCurrEduClsEN.con_id_CurrEduCls:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
case clsvCurrEduClsEN.con_CurrEduClsId:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return a.currEduClsId.localeCompare(b.currEduClsId);
}
case clsvCurrEduClsEN.con_EduClsName:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return a.eduClsName.localeCompare(b.eduClsName);
}
case clsvCurrEduClsEN.con_EduClsTypeId:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return a.eduClsTypeId.localeCompare(b.eduClsTypeId);
}
case clsvCurrEduClsEN.con_EduClsTypeName:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return a.eduClsTypeName.localeCompare(b.eduClsTypeName);
}
case clsvCurrEduClsEN.con_CourseId:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return a.courseId.localeCompare(b.courseId);
}
case clsvCurrEduClsEN.con_CourseCode:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return a.courseCode.localeCompare(b.courseCode);
}
case clsvCurrEduClsEN.con_CourseDescription:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return a.courseDescription.localeCompare(b.courseDescription);
}
case clsvCurrEduClsEN.con_CourseName:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return a.courseName.localeCompare(b.courseName);
}
case clsvCurrEduClsEN.con_ViewCount:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return a.viewCount-b.viewCount;
}
case clsvCurrEduClsEN.con_ExampleImgPath:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return a.exampleImgPath.localeCompare(b.exampleImgPath);
}
case clsvCurrEduClsEN.con_TeachingSolutionId:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return a.teachingSolutionId.localeCompare(b.teachingSolutionId);
}
case clsvCurrEduClsEN.con_TeachingSolutionName:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return a.teachingSolutionName.localeCompare(b.teachingSolutionName);
}
case clsvCurrEduClsEN.con_id_Teacher:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return a.id_Teacher.localeCompare(b.id_Teacher);
}
case clsvCurrEduClsEN.con_TeacherID:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return a.teacherID.localeCompare(b.teacherID);
}
case clsvCurrEduClsEN.con_TeacherName:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return a.teacherName.localeCompare(b.teacherName);
}
case clsvCurrEduClsEN.con_id_XzCollege:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return a.id_XzCollege.localeCompare(b.id_XzCollege);
}
case clsvCurrEduClsEN.con_CollegeID:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return a.collegeID.localeCompare(b.collegeID);
}
case clsvCurrEduClsEN.con_CollegeName:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return a.collegeName.localeCompare(b.collegeName);
}
case clsvCurrEduClsEN.con_ClgEnglishName:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return a.clgEnglishName.localeCompare(b.clgEnglishName);
}
case clsvCurrEduClsEN.con_PhoneNumber:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return a.phoneNumber.localeCompare(b.phoneNumber);
}
case clsvCurrEduClsEN.con_id_XzMajor:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return a.id_XzMajor.localeCompare(b.id_XzMajor);
}
case clsvCurrEduClsEN.con_MajorName:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return a.majorName.localeCompare(b.majorName);
}
case clsvCurrEduClsEN.con_id_EduWay:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return a.id_EduWay.localeCompare(b.id_EduWay);
}
case clsvCurrEduClsEN.con_id_ClassRoomType:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return a.id_ClassRoomType.localeCompare(b.id_ClassRoomType);
}
case clsvCurrEduClsEN.con_TotalLessonQty:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return a.totalLessonQty-b.totalLessonQty;
}
case clsvCurrEduClsEN.con_MaxStuQty:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return a.maxStuQty-b.maxStuQty;
}
case clsvCurrEduClsEN.con_WeekQty:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return a.weekQty-b.weekQty;
}
case clsvCurrEduClsEN.con_ScheUnitPW:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return a.scheUnitPW-b.scheUnitPW;
}
case clsvCurrEduClsEN.con_WeekStatusID:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return a.weekStatusID.localeCompare(b.weekStatusID);
}
case clsvCurrEduClsEN.con_CustomerWeek:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return a.customerWeek.localeCompare(b.customerWeek);
}
case clsvCurrEduClsEN.con_LessonQtyPerWeek:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return a.lessonQtyPerWeek-b.lessonQtyPerWeek;
}
case clsvCurrEduClsEN.con_Mark:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return a.mark-b.mark;
}
case clsvCurrEduClsEN.con_id_UniZone:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return a.id_UniZone.localeCompare(b.id_UniZone);
}
case clsvCurrEduClsEN.con_id_GradeBase:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return a.id_GradeBase.localeCompare(b.id_GradeBase);
}
case clsvCurrEduClsEN.con_GradeBaseID:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return a.gradeBaseID.localeCompare(b.gradeBaseID);
}
case clsvCurrEduClsEN.con_GradeBaseName:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return a.gradeBaseName.localeCompare(b.gradeBaseName);
}
case clsvCurrEduClsEN.con_GradeBaseNameA:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return a.gradeBaseNameA.localeCompare(b.gradeBaseNameA);
}
case clsvCurrEduClsEN.con_IsEffective:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
if (a.isEffective == true) return 1;
else return -1
}
case clsvCurrEduClsEN.con_IsForPaperReading:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
if (a.isForPaperReading == true) return 1;
else return -1
}
case clsvCurrEduClsEN.con_SchoolYear:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return a.schoolYear.localeCompare(b.schoolYear);
}
case clsvCurrEduClsEN.con_SchoolTerm:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return a.schoolTerm.localeCompare(b.schoolTerm);
}
case clsvCurrEduClsEN.con_id_CourseType:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return a.id_CourseType.localeCompare(b.id_CourseType);
}
case clsvCurrEduClsEN.con_CourseTypeID:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return a.courseTypeID.localeCompare(b.courseTypeID);
}
case clsvCurrEduClsEN.con_CourseTypeName:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return a.courseTypeName.localeCompare(b.courseTypeName);
}
case clsvCurrEduClsEN.con_IsDegree:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
if (a.isDegree == true) return 1;
else return -1
}
case clsvCurrEduClsEN.con_id_ScoreType:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return a.id_ScoreType.localeCompare(b.id_ScoreType);
}
case clsvCurrEduClsEN.con_GetScoreWayId:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return a.getScoreWayId.localeCompare(b.getScoreWayId);
}
case clsvCurrEduClsEN.con_IsProportionalCtrl:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
if (a.isProportionalCtrl == true) return 1;
else return -1
}
case clsvCurrEduClsEN.con_id_ExamType:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return a.id_ExamType.localeCompare(b.id_ExamType);
}
case clsvCurrEduClsEN.con_BeginWeek:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return a.beginWeek-b.beginWeek;
}
case clsvCurrEduClsEN.con_ModifyDate:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return a.modifyDate.localeCompare(b.modifyDate);
}
case clsvCurrEduClsEN.con_ModifyUserID:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return a.modifyUserID.localeCompare(b.modifyUserID);
}
case clsvCurrEduClsEN.con_Memo:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return a.memo.localeCompare(b.memo);
}
case clsvCurrEduClsEN.con_CurrStuNum_Valid:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return a.currStuNum_Valid-b.currStuNum_Valid;
}
case clsvCurrEduClsEN.con_CurrStuNum:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return a.currStuNum-b.currStuNum;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vCurrEduCls]中不存在！(in ${ vCurrEduCls_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsvCurrEduClsEN.con_id_CurrEduCls:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
case clsvCurrEduClsEN.con_CurrEduClsId:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return b.currEduClsId.localeCompare(a.currEduClsId);
}
case clsvCurrEduClsEN.con_EduClsName:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return b.eduClsName.localeCompare(a.eduClsName);
}
case clsvCurrEduClsEN.con_EduClsTypeId:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return b.eduClsTypeId.localeCompare(a.eduClsTypeId);
}
case clsvCurrEduClsEN.con_EduClsTypeName:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return b.eduClsTypeName.localeCompare(a.eduClsTypeName);
}
case clsvCurrEduClsEN.con_CourseId:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return b.courseId.localeCompare(a.courseId);
}
case clsvCurrEduClsEN.con_CourseCode:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return b.courseCode.localeCompare(a.courseCode);
}
case clsvCurrEduClsEN.con_CourseDescription:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return b.courseDescription.localeCompare(a.courseDescription);
}
case clsvCurrEduClsEN.con_CourseName:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return b.courseName.localeCompare(a.courseName);
}
case clsvCurrEduClsEN.con_ViewCount:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return b.viewCount-a.viewCount;
}
case clsvCurrEduClsEN.con_ExampleImgPath:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return b.exampleImgPath.localeCompare(a.exampleImgPath);
}
case clsvCurrEduClsEN.con_TeachingSolutionId:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return b.teachingSolutionId.localeCompare(a.teachingSolutionId);
}
case clsvCurrEduClsEN.con_TeachingSolutionName:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return b.teachingSolutionName.localeCompare(a.teachingSolutionName);
}
case clsvCurrEduClsEN.con_id_Teacher:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return b.id_Teacher.localeCompare(a.id_Teacher);
}
case clsvCurrEduClsEN.con_TeacherID:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return b.teacherID.localeCompare(a.teacherID);
}
case clsvCurrEduClsEN.con_TeacherName:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return b.teacherName.localeCompare(a.teacherName);
}
case clsvCurrEduClsEN.con_id_XzCollege:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return b.id_XzCollege.localeCompare(a.id_XzCollege);
}
case clsvCurrEduClsEN.con_CollegeID:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return b.collegeID.localeCompare(a.collegeID);
}
case clsvCurrEduClsEN.con_CollegeName:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return b.collegeName.localeCompare(a.collegeName);
}
case clsvCurrEduClsEN.con_ClgEnglishName:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return b.clgEnglishName.localeCompare(a.clgEnglishName);
}
case clsvCurrEduClsEN.con_PhoneNumber:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return b.phoneNumber.localeCompare(a.phoneNumber);
}
case clsvCurrEduClsEN.con_id_XzMajor:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return b.id_XzMajor.localeCompare(a.id_XzMajor);
}
case clsvCurrEduClsEN.con_MajorName:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return b.majorName.localeCompare(a.majorName);
}
case clsvCurrEduClsEN.con_id_EduWay:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return b.id_EduWay.localeCompare(a.id_EduWay);
}
case clsvCurrEduClsEN.con_id_ClassRoomType:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return b.id_ClassRoomType.localeCompare(a.id_ClassRoomType);
}
case clsvCurrEduClsEN.con_TotalLessonQty:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return b.totalLessonQty-a.totalLessonQty;
}
case clsvCurrEduClsEN.con_MaxStuQty:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return b.maxStuQty-a.maxStuQty;
}
case clsvCurrEduClsEN.con_WeekQty:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return b.weekQty-a.weekQty;
}
case clsvCurrEduClsEN.con_ScheUnitPW:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return b.scheUnitPW-a.scheUnitPW;
}
case clsvCurrEduClsEN.con_WeekStatusID:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return b.weekStatusID.localeCompare(a.weekStatusID);
}
case clsvCurrEduClsEN.con_CustomerWeek:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return b.customerWeek.localeCompare(a.customerWeek);
}
case clsvCurrEduClsEN.con_LessonQtyPerWeek:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return b.lessonQtyPerWeek-a.lessonQtyPerWeek;
}
case clsvCurrEduClsEN.con_Mark:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return b.mark-a.mark;
}
case clsvCurrEduClsEN.con_id_UniZone:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return b.id_UniZone.localeCompare(a.id_UniZone);
}
case clsvCurrEduClsEN.con_id_GradeBase:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return b.id_GradeBase.localeCompare(a.id_GradeBase);
}
case clsvCurrEduClsEN.con_GradeBaseID:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return b.gradeBaseID.localeCompare(a.gradeBaseID);
}
case clsvCurrEduClsEN.con_GradeBaseName:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return b.gradeBaseName.localeCompare(a.gradeBaseName);
}
case clsvCurrEduClsEN.con_GradeBaseNameA:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return b.gradeBaseNameA.localeCompare(a.gradeBaseNameA);
}
case clsvCurrEduClsEN.con_IsEffective:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
if (b.isEffective == true) return 1;
else return -1
}
case clsvCurrEduClsEN.con_IsForPaperReading:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
if (b.isForPaperReading == true) return 1;
else return -1
}
case clsvCurrEduClsEN.con_SchoolYear:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return b.schoolYear.localeCompare(a.schoolYear);
}
case clsvCurrEduClsEN.con_SchoolTerm:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return b.schoolTerm.localeCompare(a.schoolTerm);
}
case clsvCurrEduClsEN.con_id_CourseType:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return b.id_CourseType.localeCompare(a.id_CourseType);
}
case clsvCurrEduClsEN.con_CourseTypeID:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return b.courseTypeID.localeCompare(a.courseTypeID);
}
case clsvCurrEduClsEN.con_CourseTypeName:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return b.courseTypeName.localeCompare(a.courseTypeName);
}
case clsvCurrEduClsEN.con_IsDegree:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
if (b.isDegree == true) return 1;
else return -1
}
case clsvCurrEduClsEN.con_id_ScoreType:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return b.id_ScoreType.localeCompare(a.id_ScoreType);
}
case clsvCurrEduClsEN.con_GetScoreWayId:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return b.getScoreWayId.localeCompare(a.getScoreWayId);
}
case clsvCurrEduClsEN.con_IsProportionalCtrl:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
if (b.isProportionalCtrl == true) return 1;
else return -1
}
case clsvCurrEduClsEN.con_id_ExamType:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return b.id_ExamType.localeCompare(a.id_ExamType);
}
case clsvCurrEduClsEN.con_BeginWeek:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return b.beginWeek-a.beginWeek;
}
case clsvCurrEduClsEN.con_ModifyDate:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return b.modifyDate.localeCompare(a.modifyDate);
}
case clsvCurrEduClsEN.con_ModifyUserID:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return b.modifyUserID.localeCompare(a.modifyUserID);
}
case clsvCurrEduClsEN.con_Memo:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return b.memo.localeCompare(a.memo);
}
case clsvCurrEduClsEN.con_CurrStuNum_Valid:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return b.currStuNum_Valid-a.currStuNum_Valid;
}
case clsvCurrEduClsEN.con_CurrStuNum:
return (a: clsvCurrEduClsEN, b: clsvCurrEduClsEN) => {
return b.currStuNum-a.currStuNum;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vCurrEduCls]中不存在！(in ${ vCurrEduCls_ConstructorName}.${ strThisFuncName})`;
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
export async function vCurrEduCls_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsvCurrEduClsEN.con_id_CurrEduCls:
return (obj: clsvCurrEduClsEN) => {
return obj.id_CurrEduCls === value;
}
case clsvCurrEduClsEN.con_CurrEduClsId:
return (obj: clsvCurrEduClsEN) => {
return obj.currEduClsId === value;
}
case clsvCurrEduClsEN.con_EduClsName:
return (obj: clsvCurrEduClsEN) => {
return obj.eduClsName === value;
}
case clsvCurrEduClsEN.con_EduClsTypeId:
return (obj: clsvCurrEduClsEN) => {
return obj.eduClsTypeId === value;
}
case clsvCurrEduClsEN.con_EduClsTypeName:
return (obj: clsvCurrEduClsEN) => {
return obj.eduClsTypeName === value;
}
case clsvCurrEduClsEN.con_CourseId:
return (obj: clsvCurrEduClsEN) => {
return obj.courseId === value;
}
case clsvCurrEduClsEN.con_CourseCode:
return (obj: clsvCurrEduClsEN) => {
return obj.courseCode === value;
}
case clsvCurrEduClsEN.con_CourseDescription:
return (obj: clsvCurrEduClsEN) => {
return obj.courseDescription === value;
}
case clsvCurrEduClsEN.con_CourseName:
return (obj: clsvCurrEduClsEN) => {
return obj.courseName === value;
}
case clsvCurrEduClsEN.con_ViewCount:
return (obj: clsvCurrEduClsEN) => {
return obj.viewCount === value;
}
case clsvCurrEduClsEN.con_ExampleImgPath:
return (obj: clsvCurrEduClsEN) => {
return obj.exampleImgPath === value;
}
case clsvCurrEduClsEN.con_TeachingSolutionId:
return (obj: clsvCurrEduClsEN) => {
return obj.teachingSolutionId === value;
}
case clsvCurrEduClsEN.con_TeachingSolutionName:
return (obj: clsvCurrEduClsEN) => {
return obj.teachingSolutionName === value;
}
case clsvCurrEduClsEN.con_id_Teacher:
return (obj: clsvCurrEduClsEN) => {
return obj.id_Teacher === value;
}
case clsvCurrEduClsEN.con_TeacherID:
return (obj: clsvCurrEduClsEN) => {
return obj.teacherID === value;
}
case clsvCurrEduClsEN.con_TeacherName:
return (obj: clsvCurrEduClsEN) => {
return obj.teacherName === value;
}
case clsvCurrEduClsEN.con_id_XzCollege:
return (obj: clsvCurrEduClsEN) => {
return obj.id_XzCollege === value;
}
case clsvCurrEduClsEN.con_CollegeID:
return (obj: clsvCurrEduClsEN) => {
return obj.collegeID === value;
}
case clsvCurrEduClsEN.con_CollegeName:
return (obj: clsvCurrEduClsEN) => {
return obj.collegeName === value;
}
case clsvCurrEduClsEN.con_ClgEnglishName:
return (obj: clsvCurrEduClsEN) => {
return obj.clgEnglishName === value;
}
case clsvCurrEduClsEN.con_PhoneNumber:
return (obj: clsvCurrEduClsEN) => {
return obj.phoneNumber === value;
}
case clsvCurrEduClsEN.con_id_XzMajor:
return (obj: clsvCurrEduClsEN) => {
return obj.id_XzMajor === value;
}
case clsvCurrEduClsEN.con_MajorName:
return (obj: clsvCurrEduClsEN) => {
return obj.majorName === value;
}
case clsvCurrEduClsEN.con_id_EduWay:
return (obj: clsvCurrEduClsEN) => {
return obj.id_EduWay === value;
}
case clsvCurrEduClsEN.con_id_ClassRoomType:
return (obj: clsvCurrEduClsEN) => {
return obj.id_ClassRoomType === value;
}
case clsvCurrEduClsEN.con_TotalLessonQty:
return (obj: clsvCurrEduClsEN) => {
return obj.totalLessonQty === value;
}
case clsvCurrEduClsEN.con_MaxStuQty:
return (obj: clsvCurrEduClsEN) => {
return obj.maxStuQty === value;
}
case clsvCurrEduClsEN.con_WeekQty:
return (obj: clsvCurrEduClsEN) => {
return obj.weekQty === value;
}
case clsvCurrEduClsEN.con_ScheUnitPW:
return (obj: clsvCurrEduClsEN) => {
return obj.scheUnitPW === value;
}
case clsvCurrEduClsEN.con_WeekStatusID:
return (obj: clsvCurrEduClsEN) => {
return obj.weekStatusID === value;
}
case clsvCurrEduClsEN.con_CustomerWeek:
return (obj: clsvCurrEduClsEN) => {
return obj.customerWeek === value;
}
case clsvCurrEduClsEN.con_LessonQtyPerWeek:
return (obj: clsvCurrEduClsEN) => {
return obj.lessonQtyPerWeek === value;
}
case clsvCurrEduClsEN.con_Mark:
return (obj: clsvCurrEduClsEN) => {
return obj.mark === value;
}
case clsvCurrEduClsEN.con_id_UniZone:
return (obj: clsvCurrEduClsEN) => {
return obj.id_UniZone === value;
}
case clsvCurrEduClsEN.con_id_GradeBase:
return (obj: clsvCurrEduClsEN) => {
return obj.id_GradeBase === value;
}
case clsvCurrEduClsEN.con_GradeBaseID:
return (obj: clsvCurrEduClsEN) => {
return obj.gradeBaseID === value;
}
case clsvCurrEduClsEN.con_GradeBaseName:
return (obj: clsvCurrEduClsEN) => {
return obj.gradeBaseName === value;
}
case clsvCurrEduClsEN.con_GradeBaseNameA:
return (obj: clsvCurrEduClsEN) => {
return obj.gradeBaseNameA === value;
}
case clsvCurrEduClsEN.con_IsEffective:
return (obj: clsvCurrEduClsEN) => {
return obj.isEffective === value;
}
case clsvCurrEduClsEN.con_IsForPaperReading:
return (obj: clsvCurrEduClsEN) => {
return obj.isForPaperReading === value;
}
case clsvCurrEduClsEN.con_SchoolYear:
return (obj: clsvCurrEduClsEN) => {
return obj.schoolYear === value;
}
case clsvCurrEduClsEN.con_SchoolTerm:
return (obj: clsvCurrEduClsEN) => {
return obj.schoolTerm === value;
}
case clsvCurrEduClsEN.con_id_CourseType:
return (obj: clsvCurrEduClsEN) => {
return obj.id_CourseType === value;
}
case clsvCurrEduClsEN.con_CourseTypeID:
return (obj: clsvCurrEduClsEN) => {
return obj.courseTypeID === value;
}
case clsvCurrEduClsEN.con_CourseTypeName:
return (obj: clsvCurrEduClsEN) => {
return obj.courseTypeName === value;
}
case clsvCurrEduClsEN.con_IsDegree:
return (obj: clsvCurrEduClsEN) => {
return obj.isDegree === value;
}
case clsvCurrEduClsEN.con_id_ScoreType:
return (obj: clsvCurrEduClsEN) => {
return obj.id_ScoreType === value;
}
case clsvCurrEduClsEN.con_GetScoreWayId:
return (obj: clsvCurrEduClsEN) => {
return obj.getScoreWayId === value;
}
case clsvCurrEduClsEN.con_IsProportionalCtrl:
return (obj: clsvCurrEduClsEN) => {
return obj.isProportionalCtrl === value;
}
case clsvCurrEduClsEN.con_id_ExamType:
return (obj: clsvCurrEduClsEN) => {
return obj.id_ExamType === value;
}
case clsvCurrEduClsEN.con_BeginWeek:
return (obj: clsvCurrEduClsEN) => {
return obj.beginWeek === value;
}
case clsvCurrEduClsEN.con_ModifyDate:
return (obj: clsvCurrEduClsEN) => {
return obj.modifyDate === value;
}
case clsvCurrEduClsEN.con_ModifyUserID:
return (obj: clsvCurrEduClsEN) => {
return obj.modifyUserID === value;
}
case clsvCurrEduClsEN.con_Memo:
return (obj: clsvCurrEduClsEN) => {
return obj.memo === value;
}
case clsvCurrEduClsEN.con_CurrStuNum_Valid:
return (obj: clsvCurrEduClsEN) => {
return obj.currStuNum_Valid === value;
}
case clsvCurrEduClsEN.con_CurrStuNum:
return (obj: clsvCurrEduClsEN) => {
return obj.currStuNum === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vCurrEduCls]中不存在！(in ${ vCurrEduCls_ConstructorName}.${ strThisFuncName})`;
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
export async function vCurrEduCls_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vCurrEduCls_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vCurrEduCls_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vCurrEduCls_ConstructorName, strThisFuncName);
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
export async function vCurrEduCls_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vCurrEduCls_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vCurrEduCls_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vCurrEduCls_ConstructorName, strThisFuncName);
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
export async function vCurrEduCls_GetFirstObjAsync(strWhereCond: string): Promise<clsvCurrEduClsEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(vCurrEduCls_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vCurrEduCls_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvCurrEduCls = vCurrEduCls_GetObjFromJsonObj(returnObj);
return objvCurrEduCls;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vCurrEduCls_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vCurrEduCls_ConstructorName, strThisFuncName);
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
export async function vCurrEduCls_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvCurrEduClsEN._CurrTabName;
clsvCurrEduClsEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvCurrEduClsEN._CurrTabName);
if (IsNullOrEmpty(clsvCurrEduClsEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvCurrEduClsEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrvCurrEduClsExObjLst_Cache: Array<clsvCurrEduClsEN> = CacheHelper.Get(strKey);
const arrvCurrEduClsObjLst_T = vCurrEduCls_GetObjLstByJSONObjLst(arrvCurrEduClsExObjLst_Cache);
return arrvCurrEduClsObjLst_T;
}
try
{
const arrvCurrEduClsExObjLst = await vCurrEduCls_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrvCurrEduClsExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvCurrEduClsExObjLst.length);
console.log(strInfo);
return arrvCurrEduClsExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vCurrEduCls_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vCurrEduCls_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvCurrEduClsEN._CurrTabName;
clsvCurrEduClsEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvCurrEduClsEN._CurrTabName);
if (IsNullOrEmpty(clsvCurrEduClsEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvCurrEduClsEN.CacheAddiCondition);
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
const arrvCurrEduClsExObjLst_Cache: Array<clsvCurrEduClsEN> = JSON.parse(strTempObjLst);
const arrvCurrEduClsObjLst_T = vCurrEduCls_GetObjLstByJSONObjLst(arrvCurrEduClsExObjLst_Cache);
return arrvCurrEduClsObjLst_T;
}
try
{
const arrvCurrEduClsExObjLst = await vCurrEduCls_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrvCurrEduClsExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvCurrEduClsExObjLst.length);
console.log(strInfo);
return arrvCurrEduClsExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vCurrEduCls_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vCurrEduCls_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsvCurrEduClsEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrvCurrEduClsObjLst_Cache: Array<clsvCurrEduClsEN> = JSON.parse(strTempObjLst);
return arrvCurrEduClsObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function vCurrEduCls_GetObjLstAsync(strWhereCond: string): Promise<Array<clsvCurrEduClsEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(vCurrEduCls_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vCurrEduCls_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vCurrEduCls_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vCurrEduCls_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vCurrEduCls_ConstructorName, strThisFuncName);
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
export async function vCurrEduCls_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvCurrEduClsEN._CurrTabName;
clsvCurrEduClsEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvCurrEduClsEN._CurrTabName);
if (IsNullOrEmpty(clsvCurrEduClsEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvCurrEduClsEN.CacheAddiCondition);
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
const arrvCurrEduClsExObjLst_Cache: Array<clsvCurrEduClsEN> = JSON.parse(strTempObjLst);
const arrvCurrEduClsObjLst_T = vCurrEduCls_GetObjLstByJSONObjLst(arrvCurrEduClsExObjLst_Cache);
return arrvCurrEduClsObjLst_T;
}
try
{
const arrvCurrEduClsExObjLst = await vCurrEduCls_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrvCurrEduClsExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvCurrEduClsExObjLst.length);
console.log(strInfo);
return arrvCurrEduClsExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vCurrEduCls_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vCurrEduCls_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsvCurrEduClsEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrvCurrEduClsObjLst_Cache: Array<clsvCurrEduClsEN> = JSON.parse(strTempObjLst);
return arrvCurrEduClsObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vCurrEduCls_GetObjLst_Cache(): Promise<Array<clsvCurrEduClsEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrvCurrEduClsObjLst_Cache;
switch (clsvCurrEduClsEN.CacheModeId)
{
case "04"://sessionStorage
arrvCurrEduClsObjLst_Cache = await vCurrEduCls_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrvCurrEduClsObjLst_Cache = await vCurrEduCls_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrvCurrEduClsObjLst_Cache = await vCurrEduCls_GetObjLst_ClientCache();
break;
default:
arrvCurrEduClsObjLst_Cache = await vCurrEduCls_GetObjLst_ClientCache();
break;
}
const arrvCurrEduClsObjLst = vCurrEduCls_GetObjLstByJSONObjLst(arrvCurrEduClsObjLst_Cache);
return arrvCurrEduClsObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vCurrEduCls_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrvCurrEduClsObjLst_Cache;
switch (clsvCurrEduClsEN.CacheModeId)
{
case "04"://sessionStorage
arrvCurrEduClsObjLst_Cache = await vCurrEduCls_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrvCurrEduClsObjLst_Cache = await vCurrEduCls_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrvCurrEduClsObjLst_Cache = null;
break;
default:
arrvCurrEduClsObjLst_Cache = null;
break;
}
return arrvCurrEduClsObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrid_CurrEduCls_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vCurrEduCls_GetSubObjLst_Cache(objvCurrEduCls_Cond: clsvCurrEduClsEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrvCurrEduClsObjLst_Cache = await vCurrEduCls_GetObjLst_Cache();
let arrvCurrEduCls_Sel: Array < clsvCurrEduClsEN > = arrvCurrEduClsObjLst_Cache;
if (objvCurrEduCls_Cond.sf_FldComparisonOp == null || objvCurrEduCls_Cond.sf_FldComparisonOp == "") return arrvCurrEduCls_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvCurrEduCls_Cond.sf_FldComparisonOp);
//console.log("clsvCurrEduClsWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvCurrEduCls_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvCurrEduCls_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvCurrEduCls_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objvCurrEduCls_Cond), vCurrEduCls_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvCurrEduClsEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrid_CurrEduCls:关键字列表
 * @returns 对象列表
 **/
export async function vCurrEduCls_GetObjLstByid_CurrEduClsLstAsync(arrid_CurrEduCls: Array<string>): Promise<Array<clsvCurrEduClsEN>>  
{
const strThisFuncName = "GetObjLstByid_CurrEduClsLstAsync";
const strAction = "GetObjLstByid_CurrEduClsLst";
const strUrl = GetWebApiUrl(vCurrEduCls_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrid_CurrEduCls);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vCurrEduCls_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vCurrEduCls_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vCurrEduCls_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vCurrEduCls_ConstructorName, strThisFuncName);
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
 * @param arrstrid_CurrEduClsLst:关键字列表
 * @returns 对象列表
*/
export async function vCurrEduCls_GetObjLstByid_CurrEduClsLst_Cache(arrid_CurrEduClsLst: Array<string>) {
const strThisFuncName = "GetObjLstByid_CurrEduClsLst_Cache";
try
{
const arrvCurrEduClsObjLst_Cache = await vCurrEduCls_GetObjLst_Cache();
const arrvCurrEduCls_Sel: Array <clsvCurrEduClsEN> = arrvCurrEduClsObjLst_Cache.filter(x => arrid_CurrEduClsLst.indexOf(x.id_CurrEduCls)>-1);
return arrvCurrEduCls_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrid_CurrEduClsLst.join(","), vCurrEduCls_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvCurrEduClsEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function vCurrEduCls_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsvCurrEduClsEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(vCurrEduCls_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vCurrEduCls_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vCurrEduCls_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vCurrEduCls_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vCurrEduCls_ConstructorName, strThisFuncName);
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
export async function vCurrEduCls_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsvCurrEduClsEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vCurrEduCls_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vCurrEduCls_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vCurrEduCls_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vCurrEduCls_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vCurrEduCls_ConstructorName, strThisFuncName);
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
export async function vCurrEduCls_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vCurrEduCls_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vCurrEduCls_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vCurrEduCls_ConstructorName, strThisFuncName);
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
export async function vCurrEduCls_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrvCurrEduClsObjLst_Cache = await vCurrEduCls_GetObjLst_Cache();
if (arrvCurrEduClsObjLst_Cache.length == 0) return arrvCurrEduClsObjLst_Cache;
let arrvCurrEduCls_Sel = arrvCurrEduClsObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objvCurrEduCls_Cond = new clsvCurrEduClsEN();
ObjectAssign(objvCurrEduCls_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsvCurrEduClsWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvCurrEduCls_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvCurrEduCls_Sel.length == 0) return arrvCurrEduCls_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.sort(vCurrEduCls_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.sort(objPagerPara.sortFun);
}
arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.slice(intStart, intEnd);     
return arrvCurrEduCls_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, vCurrEduCls_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvCurrEduClsEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function vCurrEduCls_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsvCurrEduClsEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(vCurrEduCls_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vCurrEduCls_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vCurrEduCls_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vCurrEduCls_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vCurrEduCls_ConstructorName, strThisFuncName);
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
 * @param objstrid_CurrEduCls_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vCurrEduCls_IsExistRecord_Cache(objvCurrEduCls_Cond: clsvCurrEduClsEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrvCurrEduClsObjLst_Cache = await vCurrEduCls_GetObjLst_Cache();
if (arrvCurrEduClsObjLst_Cache == null) return false;
let arrvCurrEduCls_Sel: Array < clsvCurrEduClsEN > = arrvCurrEduClsObjLst_Cache;
if (objvCurrEduCls_Cond.sf_FldComparisonOp == null || objvCurrEduCls_Cond.sf_FldComparisonOp == "") return arrvCurrEduCls_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvCurrEduCls_Cond.sf_FldComparisonOp);
//console.log("clsvCurrEduClsWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvCurrEduCls_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvCurrEduCls_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvCurrEduCls_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objvCurrEduCls_Cond), vCurrEduCls_ConstructorName, strThisFuncName);
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
export async function vCurrEduCls_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(vCurrEduCls_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vCurrEduCls_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vCurrEduCls_ConstructorName, strThisFuncName);
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
 * @param strid_CurrEduCls:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function vCurrEduCls_IsExist(strid_CurrEduCls: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vCurrEduCls_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"id_CurrEduCls": strid_CurrEduCls,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vCurrEduCls_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vCurrEduCls_ConstructorName, strThisFuncName);
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
 * @param strid_CurrEduCls:所给的关键字
 * @returns 对象
*/
export async function vCurrEduCls_IsExist_Cache(strid_CurrEduCls:string) {
const strThisFuncName = "IsExist_Cache";
const arrvCurrEduClsObjLst_Cache = await vCurrEduCls_GetObjLst_Cache();
if (arrvCurrEduClsObjLst_Cache == null) return false;
try
{
const arrvCurrEduCls_Sel: Array <clsvCurrEduClsEN> = arrvCurrEduClsObjLst_Cache.filter(x => x.id_CurrEduCls == strid_CurrEduCls);
if (arrvCurrEduCls_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strid_CurrEduCls, vCurrEduCls_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param strid_CurrEduCls:关键字
 * @returns 是否存在?存在返回True
 **/
export async function vCurrEduCls_IsExistAsync(strid_CurrEduCls: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vCurrEduCls_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strid_CurrEduCls": strid_CurrEduCls }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vCurrEduCls_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vCurrEduCls_ConstructorName, strThisFuncName);
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
export async function vCurrEduCls_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(vCurrEduCls_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vCurrEduCls_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vCurrEduCls_ConstructorName, strThisFuncName);
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
 * @param objvCurrEduCls_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function vCurrEduCls_GetRecCountByCond_Cache(objvCurrEduCls_Cond: clsvCurrEduClsEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrvCurrEduClsObjLst_Cache = await vCurrEduCls_GetObjLst_Cache();
if (arrvCurrEduClsObjLst_Cache == null) return 0;
let arrvCurrEduCls_Sel: Array < clsvCurrEduClsEN > = arrvCurrEduClsObjLst_Cache;
if (objvCurrEduCls_Cond.sf_FldComparisonOp == null || objvCurrEduCls_Cond.sf_FldComparisonOp == "") return arrvCurrEduCls_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvCurrEduCls_Cond.sf_FldComparisonOp);
//console.log("clsvCurrEduClsWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvCurrEduCls_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvCurrEduCls_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvCurrEduCls_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objvCurrEduCls_Cond), vCurrEduCls_ConstructorName, strThisFuncName);
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
export function vCurrEduCls_GetWebApiUrl(strController: string, strAction: string): string {
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
export function vCurrEduCls_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clsvCurrEduClsEN._CurrTabName;
switch (clsvCurrEduClsEN.CacheModeId)
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
export async function vCurrEduCls__Cache(strDivName: string, strDdlName: string )
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
const arrObjLst_Sel = await vCurrEduCls_GetObjLst_Cache();
if (arrObjLst_Sel == null) return;
BindDdl_ObjLstInDiv_V(strDivName, strDdlName, arrObjLst_Sel, clsvCurrEduClsEN.con_id_CurrEduCls, clsvCurrEduClsEN.con_EduClsName, "v当前教学班");
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vCurrEduCls_GetJSONStrByObj (pobjvCurrEduClsEN: clsvCurrEduClsEN): string
{
const strThisFuncName = "GetJSONStrByObj";
let strJson = "";
try
{
strJson = JSON.stringify(pobjvCurrEduClsEN);
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
export function vCurrEduCls_GetObjLstByJSONStr (strJSON: string): Array<clsvCurrEduClsEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrvCurrEduClsObjLst = new Array<clsvCurrEduClsEN>();
if (strJSON === "")
{
return arrvCurrEduClsObjLst;
}
try
{
arrvCurrEduClsObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvCurrEduClsObjLst;
}
return arrvCurrEduClsObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrvCurrEduClsObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function vCurrEduCls_GetObjLstByJSONObjLst (arrvCurrEduClsObjLstS: Array<clsvCurrEduClsEN>): Array<clsvCurrEduClsEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrvCurrEduClsObjLst = new Array<clsvCurrEduClsEN>();
for (const objInFor of arrvCurrEduClsObjLstS) {
const obj1 = vCurrEduCls_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrvCurrEduClsObjLst.push(obj1);
}
return arrvCurrEduClsObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vCurrEduCls_GetObjByJSONStr (strJSON: string): clsvCurrEduClsEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjvCurrEduClsEN = new clsvCurrEduClsEN();
if (strJSON === "")
{
return pobjvCurrEduClsEN;
}
try
{
pobjvCurrEduClsEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvCurrEduClsEN;
}
return pobjvCurrEduClsEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function vCurrEduCls_GetCombineCondition(objvCurrEduCls_Cond: clsvCurrEduClsEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsEN.con_id_CurrEduCls, objvCurrEduCls_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN.con_CurrEduClsId) == true)
{
const strComparisonOp_CurrEduClsId:string = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN.con_CurrEduClsId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsEN.con_CurrEduClsId, objvCurrEduCls_Cond.currEduClsId, strComparisonOp_CurrEduClsId);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN.con_EduClsName) == true)
{
const strComparisonOp_EduClsName:string = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN.con_EduClsName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsEN.con_EduClsName, objvCurrEduCls_Cond.eduClsName, strComparisonOp_EduClsName);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN.con_EduClsTypeId) == true)
{
const strComparisonOp_EduClsTypeId:string = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN.con_EduClsTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsEN.con_EduClsTypeId, objvCurrEduCls_Cond.eduClsTypeId, strComparisonOp_EduClsTypeId);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN.con_EduClsTypeName) == true)
{
const strComparisonOp_EduClsTypeName:string = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN.con_EduClsTypeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsEN.con_EduClsTypeName, objvCurrEduCls_Cond.eduClsTypeName, strComparisonOp_EduClsTypeName);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN.con_CourseId) == true)
{
const strComparisonOp_CourseId:string = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN.con_CourseId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsEN.con_CourseId, objvCurrEduCls_Cond.courseId, strComparisonOp_CourseId);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN.con_CourseCode) == true)
{
const strComparisonOp_CourseCode:string = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN.con_CourseCode];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsEN.con_CourseCode, objvCurrEduCls_Cond.courseCode, strComparisonOp_CourseCode);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN.con_CourseDescription) == true)
{
const strComparisonOp_CourseDescription:string = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN.con_CourseDescription];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsEN.con_CourseDescription, objvCurrEduCls_Cond.courseDescription, strComparisonOp_CourseDescription);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN.con_CourseName) == true)
{
const strComparisonOp_CourseName:string = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN.con_CourseName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsEN.con_CourseName, objvCurrEduCls_Cond.courseName, strComparisonOp_CourseName);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN.con_ViewCount) == true)
{
const strComparisonOp_ViewCount:string = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN.con_ViewCount];
strWhereCond += Format(" And {0} {2} {1}", clsvCurrEduClsEN.con_ViewCount, objvCurrEduCls_Cond.viewCount, strComparisonOp_ViewCount);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN.con_ExampleImgPath) == true)
{
const strComparisonOp_ExampleImgPath:string = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN.con_ExampleImgPath];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsEN.con_ExampleImgPath, objvCurrEduCls_Cond.exampleImgPath, strComparisonOp_ExampleImgPath);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN.con_TeachingSolutionId) == true)
{
const strComparisonOp_TeachingSolutionId:string = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN.con_TeachingSolutionId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsEN.con_TeachingSolutionId, objvCurrEduCls_Cond.teachingSolutionId, strComparisonOp_TeachingSolutionId);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN.con_TeachingSolutionName) == true)
{
const strComparisonOp_TeachingSolutionName:string = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN.con_TeachingSolutionName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsEN.con_TeachingSolutionName, objvCurrEduCls_Cond.teachingSolutionName, strComparisonOp_TeachingSolutionName);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN.con_id_Teacher) == true)
{
const strComparisonOp_id_Teacher:string = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN.con_id_Teacher];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsEN.con_id_Teacher, objvCurrEduCls_Cond.id_Teacher, strComparisonOp_id_Teacher);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN.con_TeacherID) == true)
{
const strComparisonOp_TeacherID:string = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN.con_TeacherID];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsEN.con_TeacherID, objvCurrEduCls_Cond.teacherID, strComparisonOp_TeacherID);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN.con_TeacherName) == true)
{
const strComparisonOp_TeacherName:string = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN.con_TeacherName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsEN.con_TeacherName, objvCurrEduCls_Cond.teacherName, strComparisonOp_TeacherName);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN.con_id_XzCollege) == true)
{
const strComparisonOp_id_XzCollege:string = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN.con_id_XzCollege];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsEN.con_id_XzCollege, objvCurrEduCls_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN.con_CollegeID) == true)
{
const strComparisonOp_CollegeID:string = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN.con_CollegeID];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsEN.con_CollegeID, objvCurrEduCls_Cond.collegeID, strComparisonOp_CollegeID);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN.con_CollegeName) == true)
{
const strComparisonOp_CollegeName:string = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN.con_CollegeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsEN.con_CollegeName, objvCurrEduCls_Cond.collegeName, strComparisonOp_CollegeName);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN.con_ClgEnglishName) == true)
{
const strComparisonOp_ClgEnglishName:string = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN.con_ClgEnglishName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsEN.con_ClgEnglishName, objvCurrEduCls_Cond.clgEnglishName, strComparisonOp_ClgEnglishName);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN.con_PhoneNumber) == true)
{
const strComparisonOp_PhoneNumber:string = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN.con_PhoneNumber];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsEN.con_PhoneNumber, objvCurrEduCls_Cond.phoneNumber, strComparisonOp_PhoneNumber);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN.con_id_XzMajor) == true)
{
const strComparisonOp_id_XzMajor:string = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN.con_id_XzMajor];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsEN.con_id_XzMajor, objvCurrEduCls_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN.con_MajorName) == true)
{
const strComparisonOp_MajorName:string = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN.con_MajorName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsEN.con_MajorName, objvCurrEduCls_Cond.majorName, strComparisonOp_MajorName);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN.con_id_EduWay) == true)
{
const strComparisonOp_id_EduWay:string = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN.con_id_EduWay];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsEN.con_id_EduWay, objvCurrEduCls_Cond.id_EduWay, strComparisonOp_id_EduWay);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN.con_id_ClassRoomType) == true)
{
const strComparisonOp_id_ClassRoomType:string = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN.con_id_ClassRoomType];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsEN.con_id_ClassRoomType, objvCurrEduCls_Cond.id_ClassRoomType, strComparisonOp_id_ClassRoomType);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN.con_TotalLessonQty) == true)
{
const strComparisonOp_TotalLessonQty:string = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN.con_TotalLessonQty];
strWhereCond += Format(" And {0} {2} {1}", clsvCurrEduClsEN.con_TotalLessonQty, objvCurrEduCls_Cond.totalLessonQty, strComparisonOp_TotalLessonQty);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN.con_MaxStuQty) == true)
{
const strComparisonOp_MaxStuQty:string = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN.con_MaxStuQty];
strWhereCond += Format(" And {0} {2} {1}", clsvCurrEduClsEN.con_MaxStuQty, objvCurrEduCls_Cond.maxStuQty, strComparisonOp_MaxStuQty);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN.con_WeekQty) == true)
{
const strComparisonOp_WeekQty:string = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN.con_WeekQty];
strWhereCond += Format(" And {0} {2} {1}", clsvCurrEduClsEN.con_WeekQty, objvCurrEduCls_Cond.weekQty, strComparisonOp_WeekQty);
}
//数据类型number(smallint)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN.con_WeekStatusID) == true)
{
const strComparisonOp_WeekStatusID:string = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN.con_WeekStatusID];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsEN.con_WeekStatusID, objvCurrEduCls_Cond.weekStatusID, strComparisonOp_WeekStatusID);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN.con_CustomerWeek) == true)
{
const strComparisonOp_CustomerWeek:string = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN.con_CustomerWeek];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsEN.con_CustomerWeek, objvCurrEduCls_Cond.customerWeek, strComparisonOp_CustomerWeek);
}
//数据类型number(smallint)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN.con_Mark) == true)
{
const strComparisonOp_Mark:string = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN.con_Mark];
strWhereCond += Format(" And {0} {2} {1}", clsvCurrEduClsEN.con_Mark, objvCurrEduCls_Cond.mark, strComparisonOp_Mark);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN.con_id_UniZone) == true)
{
const strComparisonOp_id_UniZone:string = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN.con_id_UniZone];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsEN.con_id_UniZone, objvCurrEduCls_Cond.id_UniZone, strComparisonOp_id_UniZone);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN.con_id_GradeBase) == true)
{
const strComparisonOp_id_GradeBase:string = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN.con_id_GradeBase];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsEN.con_id_GradeBase, objvCurrEduCls_Cond.id_GradeBase, strComparisonOp_id_GradeBase);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN.con_GradeBaseID) == true)
{
const strComparisonOp_GradeBaseID:string = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN.con_GradeBaseID];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsEN.con_GradeBaseID, objvCurrEduCls_Cond.gradeBaseID, strComparisonOp_GradeBaseID);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN.con_GradeBaseName) == true)
{
const strComparisonOp_GradeBaseName:string = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN.con_GradeBaseName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsEN.con_GradeBaseName, objvCurrEduCls_Cond.gradeBaseName, strComparisonOp_GradeBaseName);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN.con_GradeBaseNameA) == true)
{
const strComparisonOp_GradeBaseNameA:string = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN.con_GradeBaseNameA];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsEN.con_GradeBaseNameA, objvCurrEduCls_Cond.gradeBaseNameA, strComparisonOp_GradeBaseNameA);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN.con_IsEffective) == true)
{
if (objvCurrEduCls_Cond.isEffective == true)
{
strWhereCond += Format(" And {0} = '1'", clsvCurrEduClsEN.con_IsEffective);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvCurrEduClsEN.con_IsEffective);
}
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN.con_IsForPaperReading) == true)
{
if (objvCurrEduCls_Cond.isForPaperReading == true)
{
strWhereCond += Format(" And {0} = '1'", clsvCurrEduClsEN.con_IsForPaperReading);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvCurrEduClsEN.con_IsForPaperReading);
}
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN.con_SchoolYear) == true)
{
const strComparisonOp_SchoolYear:string = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN.con_SchoolYear];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsEN.con_SchoolYear, objvCurrEduCls_Cond.schoolYear, strComparisonOp_SchoolYear);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN.con_SchoolTerm) == true)
{
const strComparisonOp_SchoolTerm:string = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN.con_SchoolTerm];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsEN.con_SchoolTerm, objvCurrEduCls_Cond.schoolTerm, strComparisonOp_SchoolTerm);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN.con_id_CourseType) == true)
{
const strComparisonOp_id_CourseType:string = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN.con_id_CourseType];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsEN.con_id_CourseType, objvCurrEduCls_Cond.id_CourseType, strComparisonOp_id_CourseType);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN.con_CourseTypeID) == true)
{
const strComparisonOp_CourseTypeID:string = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN.con_CourseTypeID];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsEN.con_CourseTypeID, objvCurrEduCls_Cond.courseTypeID, strComparisonOp_CourseTypeID);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN.con_CourseTypeName) == true)
{
const strComparisonOp_CourseTypeName:string = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN.con_CourseTypeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsEN.con_CourseTypeName, objvCurrEduCls_Cond.courseTypeName, strComparisonOp_CourseTypeName);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN.con_IsDegree) == true)
{
if (objvCurrEduCls_Cond.isDegree == true)
{
strWhereCond += Format(" And {0} = '1'", clsvCurrEduClsEN.con_IsDegree);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvCurrEduClsEN.con_IsDegree);
}
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN.con_id_ScoreType) == true)
{
const strComparisonOp_id_ScoreType:string = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN.con_id_ScoreType];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsEN.con_id_ScoreType, objvCurrEduCls_Cond.id_ScoreType, strComparisonOp_id_ScoreType);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN.con_GetScoreWayId) == true)
{
const strComparisonOp_GetScoreWayId:string = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN.con_GetScoreWayId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsEN.con_GetScoreWayId, objvCurrEduCls_Cond.getScoreWayId, strComparisonOp_GetScoreWayId);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN.con_IsProportionalCtrl) == true)
{
if (objvCurrEduCls_Cond.isProportionalCtrl == true)
{
strWhereCond += Format(" And {0} = '1'", clsvCurrEduClsEN.con_IsProportionalCtrl);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvCurrEduClsEN.con_IsProportionalCtrl);
}
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN.con_id_ExamType) == true)
{
const strComparisonOp_id_ExamType:string = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN.con_id_ExamType];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsEN.con_id_ExamType, objvCurrEduCls_Cond.id_ExamType, strComparisonOp_id_ExamType);
}
//数据类型number(smallint)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN.con_ModifyDate) == true)
{
const strComparisonOp_ModifyDate:string = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN.con_ModifyDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsEN.con_ModifyDate, objvCurrEduCls_Cond.modifyDate, strComparisonOp_ModifyDate);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN.con_ModifyUserID) == true)
{
const strComparisonOp_ModifyUserID:string = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN.con_ModifyUserID];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsEN.con_ModifyUserID, objvCurrEduCls_Cond.modifyUserID, strComparisonOp_ModifyUserID);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsEN.con_Memo, objvCurrEduCls_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN.con_CurrStuNum_Valid) == true)
{
const strComparisonOp_CurrStuNum_Valid:string = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN.con_CurrStuNum_Valid];
strWhereCond += Format(" And {0} {2} {1}", clsvCurrEduClsEN.con_CurrStuNum_Valid, objvCurrEduCls_Cond.currStuNum_Valid, strComparisonOp_CurrStuNum_Valid);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN.con_CurrStuNum) == true)
{
const strComparisonOp_CurrStuNum:string = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN.con_CurrStuNum];
strWhereCond += Format(" And {0} {2} {1}", clsvCurrEduClsEN.con_CurrStuNum, objvCurrEduCls_Cond.currStuNum, strComparisonOp_CurrStuNum);
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objvCurrEduClsENS:源对象
 * @param objvCurrEduClsENT:目标对象
*/
export function vCurrEduCls_CopyObjTo(objvCurrEduClsENS: clsvCurrEduClsEN , objvCurrEduClsENT: clsvCurrEduClsEN ): void 
{
objvCurrEduClsENT.id_CurrEduCls = objvCurrEduClsENS.id_CurrEduCls; //教学班流水号
objvCurrEduClsENT.currEduClsId = objvCurrEduClsENS.currEduClsId; //教学班Id
objvCurrEduClsENT.eduClsName = objvCurrEduClsENS.eduClsName; //教学班名
objvCurrEduClsENT.eduClsTypeId = objvCurrEduClsENS.eduClsTypeId; //教学班类型Id
objvCurrEduClsENT.eduClsTypeName = objvCurrEduClsENS.eduClsTypeName; //教学班类型名称
objvCurrEduClsENT.courseId = objvCurrEduClsENS.courseId; //课程Id
objvCurrEduClsENT.courseCode = objvCurrEduClsENS.courseCode; //课程代码
objvCurrEduClsENT.courseDescription = objvCurrEduClsENS.courseDescription; //课程描述
objvCurrEduClsENT.courseName = objvCurrEduClsENS.courseName; //课程名称
objvCurrEduClsENT.viewCount = objvCurrEduClsENS.viewCount; //浏览量
objvCurrEduClsENT.exampleImgPath = objvCurrEduClsENS.exampleImgPath; //示例图路径
objvCurrEduClsENT.teachingSolutionId = objvCurrEduClsENS.teachingSolutionId; //教学方案Id
objvCurrEduClsENT.teachingSolutionName = objvCurrEduClsENS.teachingSolutionName; //教学方案名称
objvCurrEduClsENT.id_Teacher = objvCurrEduClsENS.id_Teacher; //教师流水号
objvCurrEduClsENT.teacherID = objvCurrEduClsENS.teacherID; //教师工号
objvCurrEduClsENT.teacherName = objvCurrEduClsENS.teacherName; //教师姓名
objvCurrEduClsENT.id_XzCollege = objvCurrEduClsENS.id_XzCollege; //学院流水号
objvCurrEduClsENT.collegeID = objvCurrEduClsENS.collegeID; //学院ID
objvCurrEduClsENT.collegeName = objvCurrEduClsENS.collegeName; //学院名称
objvCurrEduClsENT.clgEnglishName = objvCurrEduClsENS.clgEnglishName; //ClgEnglishName
objvCurrEduClsENT.phoneNumber = objvCurrEduClsENS.phoneNumber; //PhoneNumber
objvCurrEduClsENT.id_XzMajor = objvCurrEduClsENS.id_XzMajor; //专业流水号
objvCurrEduClsENT.majorName = objvCurrEduClsENS.majorName; //专业名称
objvCurrEduClsENT.id_EduWay = objvCurrEduClsENS.id_EduWay; //教学方式流水号
objvCurrEduClsENT.id_ClassRoomType = objvCurrEduClsENS.id_ClassRoomType; //教室类型流水号
objvCurrEduClsENT.totalLessonQty = objvCurrEduClsENS.totalLessonQty; //总课时数
objvCurrEduClsENT.maxStuQty = objvCurrEduClsENS.maxStuQty; //最大学生数
objvCurrEduClsENT.weekQty = objvCurrEduClsENS.weekQty; //总周数
objvCurrEduClsENT.scheUnitPW = objvCurrEduClsENS.scheUnitPW; //周排课次数
objvCurrEduClsENT.weekStatusID = objvCurrEduClsENS.weekStatusID; //周状态编号(单,双,全周)
objvCurrEduClsENT.customerWeek = objvCurrEduClsENS.customerWeek; //自定义上课周
objvCurrEduClsENT.lessonQtyPerWeek = objvCurrEduClsENS.lessonQtyPerWeek; //周课时数
objvCurrEduClsENT.mark = objvCurrEduClsENS.mark; //获得学分
objvCurrEduClsENT.id_UniZone = objvCurrEduClsENS.id_UniZone; //校区流水号
objvCurrEduClsENT.id_GradeBase = objvCurrEduClsENS.id_GradeBase; //年级流水号
objvCurrEduClsENT.gradeBaseID = objvCurrEduClsENS.gradeBaseID; //年级代号
objvCurrEduClsENT.gradeBaseName = objvCurrEduClsENS.gradeBaseName; //年级名称
objvCurrEduClsENT.gradeBaseNameA = objvCurrEduClsENS.gradeBaseNameA; //年级名称缩写
objvCurrEduClsENT.isEffective = objvCurrEduClsENS.isEffective; //是否有效
objvCurrEduClsENT.isForPaperReading = objvCurrEduClsENS.isForPaperReading; //是否参与论文阅读
objvCurrEduClsENT.schoolYear = objvCurrEduClsENS.schoolYear; //学年
objvCurrEduClsENT.schoolTerm = objvCurrEduClsENS.schoolTerm; //学期
objvCurrEduClsENT.id_CourseType = objvCurrEduClsENS.id_CourseType; //课程类型流水号
objvCurrEduClsENT.courseTypeID = objvCurrEduClsENS.courseTypeID; //课程类型ID
objvCurrEduClsENT.courseTypeName = objvCurrEduClsENS.courseTypeName; //课程类型名称
objvCurrEduClsENT.isDegree = objvCurrEduClsENS.isDegree; //是否学位课
objvCurrEduClsENT.id_ScoreType = objvCurrEduClsENS.id_ScoreType; //成绩类型流水号
objvCurrEduClsENT.getScoreWayId = objvCurrEduClsENS.getScoreWayId; //获得成绩方式Id
objvCurrEduClsENT.isProportionalCtrl = objvCurrEduClsENS.isProportionalCtrl; //是否比例控制
objvCurrEduClsENT.id_ExamType = objvCurrEduClsENS.id_ExamType; //考试方式流水号
objvCurrEduClsENT.beginWeek = objvCurrEduClsENS.beginWeek; //开始周
objvCurrEduClsENT.modifyDate = objvCurrEduClsENS.modifyDate; //修改日期
objvCurrEduClsENT.modifyUserID = objvCurrEduClsENS.modifyUserID; //修改人
objvCurrEduClsENT.memo = objvCurrEduClsENS.memo; //备注
objvCurrEduClsENT.currStuNum_Valid = objvCurrEduClsENS.currStuNum_Valid; //CurrStuNum_Valid
objvCurrEduClsENT.currStuNum = objvCurrEduClsENS.currStuNum; //当前学生数
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objvCurrEduClsENS:源对象
 * @param objvCurrEduClsENT:目标对象
*/
export function vCurrEduCls_GetObjFromJsonObj(objvCurrEduClsENS: clsvCurrEduClsEN): clsvCurrEduClsEN 
{
 const objvCurrEduClsENT: clsvCurrEduClsEN = new clsvCurrEduClsEN();
ObjectAssign(objvCurrEduClsENT, objvCurrEduClsENS);
 return objvCurrEduClsENT;
}