
 /**
 * 类名:clsvCurrEduClsStuWApi
 * 表名:vCurrEduClsStu(01120127)
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
 * v教学班与学生关系(vCurrEduClsStu)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clsvCurrEduClsStuEN } from "../../L0_Entity/DailyRunning/clsvCurrEduClsStuEN.js";
import { BindDdl_ObjLstInDiv_V, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const vCurrEduClsStu_Controller = "vCurrEduClsStuApi";
 export const vCurrEduClsStu_ConstructorName = "vCurrEduClsStu";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngid_EduClsStu:关键字
 * @returns 对象
 **/
export async function vCurrEduClsStu_GetObjByid_EduClsStuAsync(lngid_EduClsStu: number): Promise<clsvCurrEduClsStuEN>  
{
const strThisFuncName = "GetObjByid_EduClsStuAsync";

if (lngid_EduClsStu == 0)
{
  const strMsg = Format("参数:[lngid_EduClsStu]不能为空！(In GetObjByid_EduClsStuAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjByid_EduClsStu";
const strUrl = GetWebApiUrl(vCurrEduClsStu_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"lngid_EduClsStu": lngid_EduClsStu,
}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObj = data.returnObj;
if (returnObj == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vCurrEduClsStu_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvCurrEduClsStu = vCurrEduClsStu_GetObjFromJsonObj(returnObj);
return objvCurrEduClsStu;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vCurrEduClsStu_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vCurrEduClsStu_ConstructorName, strThisFuncName);
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
 * @param lngid_EduClsStu:所给的关键字
 * @returns 对象
*/
export async function vCurrEduClsStu_GetObjByid_EduClsStu_Cache(lngid_EduClsStu:number,strid_CurrEduCls:string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByid_EduClsStu_Cache";

if (lngid_EduClsStu == 0)
{
  const strMsg = Format("参数:[lngid_EduClsStu]不能为空！(In GetObjByid_EduClsStu_Cache)");
console.error(strMsg);
 throw (strMsg);
}
const arrvCurrEduClsStuObjLst_Cache = await vCurrEduClsStu_GetObjLst_Cache(strid_CurrEduCls);
try
{
const arrvCurrEduClsStu_Sel: Array <clsvCurrEduClsStuEN> = arrvCurrEduClsStuObjLst_Cache.filter(x => x.id_EduClsStu == lngid_EduClsStu);
let objvCurrEduClsStu: clsvCurrEduClsStuEN;
if (arrvCurrEduClsStu_Sel.length > 0)
{
objvCurrEduClsStu = arrvCurrEduClsStu_Sel[0];
return objvCurrEduClsStu;
}
else
{
if (bolTryAsyncOnce == true)
{
objvCurrEduClsStu = await vCurrEduClsStu_GetObjByid_EduClsStuAsync(lngid_EduClsStu);
if (objvCurrEduClsStu != null)
{
vCurrEduClsStu_ReFreshThisCache(strid_CurrEduCls);
return objvCurrEduClsStu;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngid_EduClsStu, vCurrEduClsStu_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param lngid_EduClsStu:所给的关键字
 * @returns 对象
*/
export async function vCurrEduClsStu_GetObjByid_EduClsStu_localStorage(lngid_EduClsStu: number) {
const strThisFuncName = "GetObjByid_EduClsStu_localStorage";

if (lngid_EduClsStu == 0)
{
  const strMsg = Format("参数:[lngid_EduClsStu]不能为空！(In GetObjByid_EduClsStu_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
const strKey = Format("{0}_{1}", clsvCurrEduClsStuEN._CurrTabName, lngid_EduClsStu);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objvCurrEduClsStu_Cache: clsvCurrEduClsStuEN = JSON.parse(strTempObj);
return objvCurrEduClsStu_Cache;
}
try
{
const objvCurrEduClsStu = await vCurrEduClsStu_GetObjByid_EduClsStuAsync(lngid_EduClsStu);
if (objvCurrEduClsStu != null)
{
localStorage.setItem(strKey, JSON.stringify(objvCurrEduClsStu));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objvCurrEduClsStu;
}
return objvCurrEduClsStu;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngid_EduClsStu, vCurrEduClsStu_ConstructorName, strThisFuncName);
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
 @param strid_CurrEduCls:缓存的分类字段
 * @returns 返回一个输出字段值
*/
export async function vCurrEduClsStu_func(strInFldName:string , strOutFldName:string , strInValue:number , strid_CurrEduCls_C: string)
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

if (strInFldName != clsvCurrEduClsStuEN.con_id_EduClsStu)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsvCurrEduClsStuEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clsvCurrEduClsStuEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const lngid_EduClsStu = Number(strInValue);
if (lngid_EduClsStu == 0)
{
return "";
}
const objvCurrEduClsStu = await vCurrEduClsStu_GetObjByid_EduClsStu_Cache(lngid_EduClsStu , strid_CurrEduCls_C);
if (objvCurrEduClsStu == null) return "";
return objvCurrEduClsStu.GetFldValue(strOutFldName).toString();
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
export function vCurrEduClsStu_SortFun_Defa(a:clsvCurrEduClsStuEN , b:clsvCurrEduClsStuEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.id_EduClsStu-b.id_EduClsStu;
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
export function vCurrEduClsStu_SortFun_Defa_2Fld(a:clsvCurrEduClsStuEN , b:clsvCurrEduClsStuEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.id_CurrEduCls == b.id_CurrEduCls) return a.currEduClsId.localeCompare(b.currEduClsId);
else return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
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
export function vCurrEduClsStu_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsvCurrEduClsStuEN.con_id_EduClsStu:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return a.id_EduClsStu-b.id_EduClsStu;
}
case clsvCurrEduClsStuEN.con_id_CurrEduCls:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
case clsvCurrEduClsStuEN.con_CurrEduClsId:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return a.currEduClsId.localeCompare(b.currEduClsId);
}
case clsvCurrEduClsStuEN.con_EduClsName:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return a.eduClsName.localeCompare(b.eduClsName);
}
case clsvCurrEduClsStuEN.con_CourseId:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return a.courseId.localeCompare(b.courseId);
}
case clsvCurrEduClsStuEN.con_CourseCode:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return a.courseCode.localeCompare(b.courseCode);
}
case clsvCurrEduClsStuEN.con_CourseName:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return a.courseName.localeCompare(b.courseName);
}
case clsvCurrEduClsStuEN.con_TeachingSolutionId:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return a.teachingSolutionId.localeCompare(b.teachingSolutionId);
}
case clsvCurrEduClsStuEN.con_TeachingSolutionName:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return a.teachingSolutionName.localeCompare(b.teachingSolutionName);
}
case clsvCurrEduClsStuEN.con_id_XzCollege:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return a.id_XzCollege.localeCompare(b.id_XzCollege);
}
case clsvCurrEduClsStuEN.con_CollegeID:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return a.collegeID.localeCompare(b.collegeID);
}
case clsvCurrEduClsStuEN.con_CollegeName:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return a.collegeName.localeCompare(b.collegeName);
}
case clsvCurrEduClsStuEN.con_LessonQtyPerWeek:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return a.lessonQtyPerWeek-b.lessonQtyPerWeek;
}
case clsvCurrEduClsStuEN.con_Mark:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return a.mark-b.mark;
}
case clsvCurrEduClsStuEN.con_id_UniZone:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return a.id_UniZone.localeCompare(b.id_UniZone);
}
case clsvCurrEduClsStuEN.con_GradeBaseName:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return a.gradeBaseName.localeCompare(b.gradeBaseName);
}
case clsvCurrEduClsStuEN.con_IsEffective:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
if (a.isEffective == true) return 1;
else return -1
}
case clsvCurrEduClsStuEN.con_id_CourseType:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return a.id_CourseType.localeCompare(b.id_CourseType);
}
case clsvCurrEduClsStuEN.con_CourseTypeID:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return a.courseTypeID.localeCompare(b.courseTypeID);
}
case clsvCurrEduClsStuEN.con_CourseTypeName:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return a.courseTypeName.localeCompare(b.courseTypeName);
}
case clsvCurrEduClsStuEN.con_IsDegree:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
if (a.isDegree == true) return 1;
else return -1
}
case clsvCurrEduClsStuEN.con_CurrStuNum:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return a.currStuNum-b.currStuNum;
}
case clsvCurrEduClsStuEN.con_id_Stu:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return a.id_Stu.localeCompare(b.id_Stu);
}
case clsvCurrEduClsStuEN.con_StuID:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return a.stuID.localeCompare(b.stuID);
}
case clsvCurrEduClsStuEN.con_StuName:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return a.stuName.localeCompare(b.stuName);
}
case clsvCurrEduClsStuEN.con_id_Sex:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return a.id_Sex.localeCompare(b.id_Sex);
}
case clsvCurrEduClsStuEN.con_SexDesc:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return a.sexDesc.localeCompare(b.sexDesc);
}
case clsvCurrEduClsStuEN.con_MajorID:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return a.majorID.localeCompare(b.majorID);
}
case clsvCurrEduClsStuEN.con_MajorName:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return a.majorName.localeCompare(b.majorName);
}
case clsvCurrEduClsStuEN.con_id_AdminCls:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return a.id_AdminCls.localeCompare(b.id_AdminCls);
}
case clsvCurrEduClsStuEN.con_Birthday:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return a.birthday.localeCompare(b.birthday);
}
case clsvCurrEduClsStuEN.con_EduClsStuStateID:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return a.eduClsStuStateID.localeCompare(b.eduClsStuStateID);
}
case clsvCurrEduClsStuEN.con_GetScoreTimes:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return a.getScoreTimes-b.getScoreTimes;
}
case clsvCurrEduClsStuEN.con_Score:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return a.score-b.score;
}
case clsvCurrEduClsStuEN.con_TotalScores:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return a.totalScores-b.totalScores;
}
case clsvCurrEduClsStuEN.con_Ranking:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return a.ranking-b.ranking;
}
case clsvCurrEduClsStuEN.con_Percentile:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return a.percentile-b.percentile;
}
case clsvCurrEduClsStuEN.con_Confirmed:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
if (a.confirmed == true) return 1;
else return -1
}
case clsvCurrEduClsStuEN.con_SchoolTerm:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return a.schoolTerm.localeCompare(b.schoolTerm);
}
case clsvCurrEduClsStuEN.con_SchoolYear:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return a.schoolYear.localeCompare(b.schoolYear);
}
case clsvCurrEduClsStuEN.con_SignInDate:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return a.signInDate.localeCompare(b.signInDate);
}
case clsvCurrEduClsStuEN.con_SignInStateID:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return a.signInStateID.localeCompare(b.signInStateID);
}
case clsvCurrEduClsStuEN.con_SignInUser:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return a.signInUser.localeCompare(b.signInUser);
}
case clsvCurrEduClsStuEN.con_ModifyDate:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return a.modifyDate.localeCompare(b.modifyDate);
}
case clsvCurrEduClsStuEN.con_ModifyUserID:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return a.modifyUserID.localeCompare(b.modifyUserID);
}
case clsvCurrEduClsStuEN.con_CollegeName4Stu:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return a.collegeName4Stu.localeCompare(b.collegeName4Stu);
}
case clsvCurrEduClsStuEN.con_EduClsTypeName:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return a.eduClsTypeName.localeCompare(b.eduClsTypeName);
}
case clsvCurrEduClsStuEN.con_IsSynScore:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
if (a.isSynScore == true) return 1;
else return -1
}
case clsvCurrEduClsStuEN.con_EduClsTypeId:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return a.eduClsTypeId.localeCompare(b.eduClsTypeId);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vCurrEduClsStu]中不存在！(in ${ vCurrEduClsStu_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsvCurrEduClsStuEN.con_id_EduClsStu:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return b.id_EduClsStu-a.id_EduClsStu;
}
case clsvCurrEduClsStuEN.con_id_CurrEduCls:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
case clsvCurrEduClsStuEN.con_CurrEduClsId:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return b.currEduClsId.localeCompare(a.currEduClsId);
}
case clsvCurrEduClsStuEN.con_EduClsName:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return b.eduClsName.localeCompare(a.eduClsName);
}
case clsvCurrEduClsStuEN.con_CourseId:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return b.courseId.localeCompare(a.courseId);
}
case clsvCurrEduClsStuEN.con_CourseCode:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return b.courseCode.localeCompare(a.courseCode);
}
case clsvCurrEduClsStuEN.con_CourseName:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return b.courseName.localeCompare(a.courseName);
}
case clsvCurrEduClsStuEN.con_TeachingSolutionId:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return b.teachingSolutionId.localeCompare(a.teachingSolutionId);
}
case clsvCurrEduClsStuEN.con_TeachingSolutionName:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return b.teachingSolutionName.localeCompare(a.teachingSolutionName);
}
case clsvCurrEduClsStuEN.con_id_XzCollege:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return b.id_XzCollege.localeCompare(a.id_XzCollege);
}
case clsvCurrEduClsStuEN.con_CollegeID:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return b.collegeID.localeCompare(a.collegeID);
}
case clsvCurrEduClsStuEN.con_CollegeName:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return b.collegeName.localeCompare(a.collegeName);
}
case clsvCurrEduClsStuEN.con_LessonQtyPerWeek:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return b.lessonQtyPerWeek-a.lessonQtyPerWeek;
}
case clsvCurrEduClsStuEN.con_Mark:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return b.mark-a.mark;
}
case clsvCurrEduClsStuEN.con_id_UniZone:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return b.id_UniZone.localeCompare(a.id_UniZone);
}
case clsvCurrEduClsStuEN.con_GradeBaseName:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return b.gradeBaseName.localeCompare(a.gradeBaseName);
}
case clsvCurrEduClsStuEN.con_IsEffective:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
if (b.isEffective == true) return 1;
else return -1
}
case clsvCurrEduClsStuEN.con_id_CourseType:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return b.id_CourseType.localeCompare(a.id_CourseType);
}
case clsvCurrEduClsStuEN.con_CourseTypeID:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return b.courseTypeID.localeCompare(a.courseTypeID);
}
case clsvCurrEduClsStuEN.con_CourseTypeName:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return b.courseTypeName.localeCompare(a.courseTypeName);
}
case clsvCurrEduClsStuEN.con_IsDegree:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
if (b.isDegree == true) return 1;
else return -1
}
case clsvCurrEduClsStuEN.con_CurrStuNum:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return b.currStuNum-a.currStuNum;
}
case clsvCurrEduClsStuEN.con_id_Stu:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return b.id_Stu.localeCompare(a.id_Stu);
}
case clsvCurrEduClsStuEN.con_StuID:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return b.stuID.localeCompare(a.stuID);
}
case clsvCurrEduClsStuEN.con_StuName:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return b.stuName.localeCompare(a.stuName);
}
case clsvCurrEduClsStuEN.con_id_Sex:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return b.id_Sex.localeCompare(a.id_Sex);
}
case clsvCurrEduClsStuEN.con_SexDesc:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return b.sexDesc.localeCompare(a.sexDesc);
}
case clsvCurrEduClsStuEN.con_MajorID:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return b.majorID.localeCompare(a.majorID);
}
case clsvCurrEduClsStuEN.con_MajorName:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return b.majorName.localeCompare(a.majorName);
}
case clsvCurrEduClsStuEN.con_id_AdminCls:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return b.id_AdminCls.localeCompare(a.id_AdminCls);
}
case clsvCurrEduClsStuEN.con_Birthday:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return b.birthday.localeCompare(a.birthday);
}
case clsvCurrEduClsStuEN.con_EduClsStuStateID:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return b.eduClsStuStateID.localeCompare(a.eduClsStuStateID);
}
case clsvCurrEduClsStuEN.con_GetScoreTimes:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return b.getScoreTimes-a.getScoreTimes;
}
case clsvCurrEduClsStuEN.con_Score:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return b.score-a.score;
}
case clsvCurrEduClsStuEN.con_TotalScores:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return b.totalScores-a.totalScores;
}
case clsvCurrEduClsStuEN.con_Ranking:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return b.ranking-a.ranking;
}
case clsvCurrEduClsStuEN.con_Percentile:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return b.percentile-a.percentile;
}
case clsvCurrEduClsStuEN.con_Confirmed:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
if (b.confirmed == true) return 1;
else return -1
}
case clsvCurrEduClsStuEN.con_SchoolTerm:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return b.schoolTerm.localeCompare(a.schoolTerm);
}
case clsvCurrEduClsStuEN.con_SchoolYear:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return b.schoolYear.localeCompare(a.schoolYear);
}
case clsvCurrEduClsStuEN.con_SignInDate:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return b.signInDate.localeCompare(a.signInDate);
}
case clsvCurrEduClsStuEN.con_SignInStateID:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return b.signInStateID.localeCompare(a.signInStateID);
}
case clsvCurrEduClsStuEN.con_SignInUser:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return b.signInUser.localeCompare(a.signInUser);
}
case clsvCurrEduClsStuEN.con_ModifyDate:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return b.modifyDate.localeCompare(a.modifyDate);
}
case clsvCurrEduClsStuEN.con_ModifyUserID:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return b.modifyUserID.localeCompare(a.modifyUserID);
}
case clsvCurrEduClsStuEN.con_CollegeName4Stu:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return b.collegeName4Stu.localeCompare(a.collegeName4Stu);
}
case clsvCurrEduClsStuEN.con_EduClsTypeName:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return b.eduClsTypeName.localeCompare(a.eduClsTypeName);
}
case clsvCurrEduClsStuEN.con_IsSynScore:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
if (b.isSynScore == true) return 1;
else return -1
}
case clsvCurrEduClsStuEN.con_EduClsTypeId:
return (a: clsvCurrEduClsStuEN, b: clsvCurrEduClsStuEN) => {
return b.eduClsTypeId.localeCompare(a.eduClsTypeId);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vCurrEduClsStu]中不存在！(in ${ vCurrEduClsStu_ConstructorName}.${ strThisFuncName})`;
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
export async function vCurrEduClsStu_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsvCurrEduClsStuEN.con_id_EduClsStu:
return (obj: clsvCurrEduClsStuEN) => {
return obj.id_EduClsStu === value;
}
case clsvCurrEduClsStuEN.con_id_CurrEduCls:
return (obj: clsvCurrEduClsStuEN) => {
return obj.id_CurrEduCls === value;
}
case clsvCurrEduClsStuEN.con_CurrEduClsId:
return (obj: clsvCurrEduClsStuEN) => {
return obj.currEduClsId === value;
}
case clsvCurrEduClsStuEN.con_EduClsName:
return (obj: clsvCurrEduClsStuEN) => {
return obj.eduClsName === value;
}
case clsvCurrEduClsStuEN.con_CourseId:
return (obj: clsvCurrEduClsStuEN) => {
return obj.courseId === value;
}
case clsvCurrEduClsStuEN.con_CourseCode:
return (obj: clsvCurrEduClsStuEN) => {
return obj.courseCode === value;
}
case clsvCurrEduClsStuEN.con_CourseName:
return (obj: clsvCurrEduClsStuEN) => {
return obj.courseName === value;
}
case clsvCurrEduClsStuEN.con_TeachingSolutionId:
return (obj: clsvCurrEduClsStuEN) => {
return obj.teachingSolutionId === value;
}
case clsvCurrEduClsStuEN.con_TeachingSolutionName:
return (obj: clsvCurrEduClsStuEN) => {
return obj.teachingSolutionName === value;
}
case clsvCurrEduClsStuEN.con_id_XzCollege:
return (obj: clsvCurrEduClsStuEN) => {
return obj.id_XzCollege === value;
}
case clsvCurrEduClsStuEN.con_CollegeID:
return (obj: clsvCurrEduClsStuEN) => {
return obj.collegeID === value;
}
case clsvCurrEduClsStuEN.con_CollegeName:
return (obj: clsvCurrEduClsStuEN) => {
return obj.collegeName === value;
}
case clsvCurrEduClsStuEN.con_LessonQtyPerWeek:
return (obj: clsvCurrEduClsStuEN) => {
return obj.lessonQtyPerWeek === value;
}
case clsvCurrEduClsStuEN.con_Mark:
return (obj: clsvCurrEduClsStuEN) => {
return obj.mark === value;
}
case clsvCurrEduClsStuEN.con_id_UniZone:
return (obj: clsvCurrEduClsStuEN) => {
return obj.id_UniZone === value;
}
case clsvCurrEduClsStuEN.con_GradeBaseName:
return (obj: clsvCurrEduClsStuEN) => {
return obj.gradeBaseName === value;
}
case clsvCurrEduClsStuEN.con_IsEffective:
return (obj: clsvCurrEduClsStuEN) => {
return obj.isEffective === value;
}
case clsvCurrEduClsStuEN.con_id_CourseType:
return (obj: clsvCurrEduClsStuEN) => {
return obj.id_CourseType === value;
}
case clsvCurrEduClsStuEN.con_CourseTypeID:
return (obj: clsvCurrEduClsStuEN) => {
return obj.courseTypeID === value;
}
case clsvCurrEduClsStuEN.con_CourseTypeName:
return (obj: clsvCurrEduClsStuEN) => {
return obj.courseTypeName === value;
}
case clsvCurrEduClsStuEN.con_IsDegree:
return (obj: clsvCurrEduClsStuEN) => {
return obj.isDegree === value;
}
case clsvCurrEduClsStuEN.con_CurrStuNum:
return (obj: clsvCurrEduClsStuEN) => {
return obj.currStuNum === value;
}
case clsvCurrEduClsStuEN.con_id_Stu:
return (obj: clsvCurrEduClsStuEN) => {
return obj.id_Stu === value;
}
case clsvCurrEduClsStuEN.con_StuID:
return (obj: clsvCurrEduClsStuEN) => {
return obj.stuID === value;
}
case clsvCurrEduClsStuEN.con_StuName:
return (obj: clsvCurrEduClsStuEN) => {
return obj.stuName === value;
}
case clsvCurrEduClsStuEN.con_id_Sex:
return (obj: clsvCurrEduClsStuEN) => {
return obj.id_Sex === value;
}
case clsvCurrEduClsStuEN.con_SexDesc:
return (obj: clsvCurrEduClsStuEN) => {
return obj.sexDesc === value;
}
case clsvCurrEduClsStuEN.con_MajorID:
return (obj: clsvCurrEduClsStuEN) => {
return obj.majorID === value;
}
case clsvCurrEduClsStuEN.con_MajorName:
return (obj: clsvCurrEduClsStuEN) => {
return obj.majorName === value;
}
case clsvCurrEduClsStuEN.con_id_AdminCls:
return (obj: clsvCurrEduClsStuEN) => {
return obj.id_AdminCls === value;
}
case clsvCurrEduClsStuEN.con_Birthday:
return (obj: clsvCurrEduClsStuEN) => {
return obj.birthday === value;
}
case clsvCurrEduClsStuEN.con_EduClsStuStateID:
return (obj: clsvCurrEduClsStuEN) => {
return obj.eduClsStuStateID === value;
}
case clsvCurrEduClsStuEN.con_GetScoreTimes:
return (obj: clsvCurrEduClsStuEN) => {
return obj.getScoreTimes === value;
}
case clsvCurrEduClsStuEN.con_Score:
return (obj: clsvCurrEduClsStuEN) => {
return obj.score === value;
}
case clsvCurrEduClsStuEN.con_TotalScores:
return (obj: clsvCurrEduClsStuEN) => {
return obj.totalScores === value;
}
case clsvCurrEduClsStuEN.con_Ranking:
return (obj: clsvCurrEduClsStuEN) => {
return obj.ranking === value;
}
case clsvCurrEduClsStuEN.con_Percentile:
return (obj: clsvCurrEduClsStuEN) => {
return obj.percentile === value;
}
case clsvCurrEduClsStuEN.con_Confirmed:
return (obj: clsvCurrEduClsStuEN) => {
return obj.confirmed === value;
}
case clsvCurrEduClsStuEN.con_SchoolTerm:
return (obj: clsvCurrEduClsStuEN) => {
return obj.schoolTerm === value;
}
case clsvCurrEduClsStuEN.con_SchoolYear:
return (obj: clsvCurrEduClsStuEN) => {
return obj.schoolYear === value;
}
case clsvCurrEduClsStuEN.con_SignInDate:
return (obj: clsvCurrEduClsStuEN) => {
return obj.signInDate === value;
}
case clsvCurrEduClsStuEN.con_SignInStateID:
return (obj: clsvCurrEduClsStuEN) => {
return obj.signInStateID === value;
}
case clsvCurrEduClsStuEN.con_SignInUser:
return (obj: clsvCurrEduClsStuEN) => {
return obj.signInUser === value;
}
case clsvCurrEduClsStuEN.con_ModifyDate:
return (obj: clsvCurrEduClsStuEN) => {
return obj.modifyDate === value;
}
case clsvCurrEduClsStuEN.con_ModifyUserID:
return (obj: clsvCurrEduClsStuEN) => {
return obj.modifyUserID === value;
}
case clsvCurrEduClsStuEN.con_CollegeName4Stu:
return (obj: clsvCurrEduClsStuEN) => {
return obj.collegeName4Stu === value;
}
case clsvCurrEduClsStuEN.con_EduClsTypeName:
return (obj: clsvCurrEduClsStuEN) => {
return obj.eduClsTypeName === value;
}
case clsvCurrEduClsStuEN.con_IsSynScore:
return (obj: clsvCurrEduClsStuEN) => {
return obj.isSynScore === value;
}
case clsvCurrEduClsStuEN.con_EduClsTypeId:
return (obj: clsvCurrEduClsStuEN) => {
return obj.eduClsTypeId === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vCurrEduClsStu]中不存在！(in ${ vCurrEduClsStu_ConstructorName}.${ strThisFuncName})`;
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
export async function vCurrEduClsStu_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vCurrEduClsStu_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vCurrEduClsStu_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vCurrEduClsStu_ConstructorName, strThisFuncName);
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
export async function vCurrEduClsStu_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vCurrEduClsStu_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vCurrEduClsStu_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vCurrEduClsStu_ConstructorName, strThisFuncName);
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
export async function vCurrEduClsStu_GetFirstObjAsync(strWhereCond: string): Promise<clsvCurrEduClsStuEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(vCurrEduClsStu_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vCurrEduClsStu_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvCurrEduClsStu = vCurrEduClsStu_GetObjFromJsonObj(returnObj);
return objvCurrEduClsStu;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vCurrEduClsStu_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vCurrEduClsStu_ConstructorName, strThisFuncName);
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
export async function vCurrEduClsStu_GetObjLst_ClientCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsvCurrEduClsStuEN._CurrTabName, strid_CurrEduCls);
clsvCurrEduClsStuEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvCurrEduClsStuEN._CurrTabName);
if (IsNullOrEmpty(clsvCurrEduClsStuEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvCurrEduClsStuEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrvCurrEduClsStuExObjLst_Cache: Array<clsvCurrEduClsStuEN> = CacheHelper.Get(strKey);
const arrvCurrEduClsStuObjLst_T = vCurrEduClsStu_GetObjLstByJSONObjLst(arrvCurrEduClsStuExObjLst_Cache);
return arrvCurrEduClsStuObjLst_T;
}
try
{
const arrvCurrEduClsStuExObjLst = await vCurrEduClsStu_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrvCurrEduClsStuExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvCurrEduClsStuExObjLst.length);
console.log(strInfo);
return arrvCurrEduClsStuExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vCurrEduClsStu_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vCurrEduClsStu_GetObjLst_localStorage(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsvCurrEduClsStuEN._CurrTabName, strid_CurrEduCls);
clsvCurrEduClsStuEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvCurrEduClsStuEN._CurrTabName);
if (IsNullOrEmpty(clsvCurrEduClsStuEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvCurrEduClsStuEN.CacheAddiCondition);
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
const arrvCurrEduClsStuExObjLst_Cache: Array<clsvCurrEduClsStuEN> = JSON.parse(strTempObjLst);
const arrvCurrEduClsStuObjLst_T = vCurrEduClsStu_GetObjLstByJSONObjLst(arrvCurrEduClsStuExObjLst_Cache);
return arrvCurrEduClsStuObjLst_T;
}
try
{
const arrvCurrEduClsStuExObjLst = await vCurrEduClsStu_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrvCurrEduClsStuExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvCurrEduClsStuExObjLst.length);
console.log(strInfo);
return arrvCurrEduClsStuExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vCurrEduClsStu_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vCurrEduClsStu_GetObjLst_localStorage_PureCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsvCurrEduClsStuEN._CurrTabName, strid_CurrEduCls);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrvCurrEduClsStuObjLst_Cache: Array<clsvCurrEduClsStuEN> = JSON.parse(strTempObjLst);
return arrvCurrEduClsStuObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function vCurrEduClsStu_GetObjLstAsync(strWhereCond: string): Promise<Array<clsvCurrEduClsStuEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(vCurrEduClsStu_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vCurrEduClsStu_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vCurrEduClsStu_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vCurrEduClsStu_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vCurrEduClsStu_ConstructorName, strThisFuncName);
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
export async function vCurrEduClsStu_GetObjLst_sessionStorage(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsvCurrEduClsStuEN._CurrTabName, strid_CurrEduCls);
clsvCurrEduClsStuEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvCurrEduClsStuEN._CurrTabName);
if (IsNullOrEmpty(clsvCurrEduClsStuEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvCurrEduClsStuEN.CacheAddiCondition);
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
const arrvCurrEduClsStuExObjLst_Cache: Array<clsvCurrEduClsStuEN> = JSON.parse(strTempObjLst);
const arrvCurrEduClsStuObjLst_T = vCurrEduClsStu_GetObjLstByJSONObjLst(arrvCurrEduClsStuExObjLst_Cache);
return arrvCurrEduClsStuObjLst_T;
}
try
{
const arrvCurrEduClsStuExObjLst = await vCurrEduClsStu_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrvCurrEduClsStuExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvCurrEduClsStuExObjLst.length);
console.log(strInfo);
return arrvCurrEduClsStuExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vCurrEduClsStu_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vCurrEduClsStu_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsvCurrEduClsStuEN._CurrTabName, strid_CurrEduCls);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrvCurrEduClsStuObjLst_Cache: Array<clsvCurrEduClsStuEN> = JSON.parse(strTempObjLst);
return arrvCurrEduClsStuObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vCurrEduClsStu_GetObjLst_Cache(strid_CurrEduCls: string): Promise<Array<clsvCurrEduClsStuEN>>
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
let arrvCurrEduClsStuObjLst_Cache;
switch (clsvCurrEduClsStuEN.CacheModeId)
{
case "04"://sessionStorage
arrvCurrEduClsStuObjLst_Cache = await vCurrEduClsStu_GetObjLst_sessionStorage(strid_CurrEduCls);
break;
case "03"://localStorage
arrvCurrEduClsStuObjLst_Cache = await vCurrEduClsStu_GetObjLst_localStorage(strid_CurrEduCls);
break;
case "02"://ClientCache
arrvCurrEduClsStuObjLst_Cache = await vCurrEduClsStu_GetObjLst_ClientCache(strid_CurrEduCls);
break;
default:
arrvCurrEduClsStuObjLst_Cache = await vCurrEduClsStu_GetObjLst_ClientCache(strid_CurrEduCls);
break;
}
const arrvCurrEduClsStuObjLst = vCurrEduClsStu_GetObjLstByJSONObjLst(arrvCurrEduClsStuObjLst_Cache);
return arrvCurrEduClsStuObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vCurrEduClsStu_GetObjLst_PureCache(strid_CurrEduCls: string)
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrvCurrEduClsStuObjLst_Cache;
switch (clsvCurrEduClsStuEN.CacheModeId)
{
case "04"://sessionStorage
arrvCurrEduClsStuObjLst_Cache = await vCurrEduClsStu_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls);
break;
case "03"://localStorage
arrvCurrEduClsStuObjLst_Cache = await vCurrEduClsStu_GetObjLst_localStorage_PureCache(strid_CurrEduCls);
break;
case "02"://ClientCache
arrvCurrEduClsStuObjLst_Cache = null;
break;
default:
arrvCurrEduClsStuObjLst_Cache = null;
break;
}
return arrvCurrEduClsStuObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objlngid_EduClsStu_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vCurrEduClsStu_GetSubObjLst_Cache(objvCurrEduClsStu_Cond: clsvCurrEduClsStuEN,strid_CurrEduCls: string) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrvCurrEduClsStuObjLst_Cache = await vCurrEduClsStu_GetObjLst_Cache(strid_CurrEduCls);
let arrvCurrEduClsStu_Sel: Array < clsvCurrEduClsStuEN > = arrvCurrEduClsStuObjLst_Cache;
if (objvCurrEduClsStu_Cond.sf_FldComparisonOp == null || objvCurrEduClsStu_Cond.sf_FldComparisonOp == "") return arrvCurrEduClsStu_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvCurrEduClsStu_Cond.sf_FldComparisonOp);
//console.log("clsvCurrEduClsStuWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvCurrEduClsStu_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvCurrEduClsStu_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvCurrEduClsStu_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objvCurrEduClsStu_Cond), vCurrEduClsStu_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvCurrEduClsStuEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrid_EduClsStu:关键字列表
 * @returns 对象列表
 **/
export async function vCurrEduClsStu_GetObjLstByid_EduClsStuLstAsync(arrid_EduClsStu: Array<string>): Promise<Array<clsvCurrEduClsStuEN>>  
{
const strThisFuncName = "GetObjLstByid_EduClsStuLstAsync";
const strAction = "GetObjLstByid_EduClsStuLst";
const strUrl = GetWebApiUrl(vCurrEduClsStu_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrid_EduClsStu);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vCurrEduClsStu_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vCurrEduClsStu_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vCurrEduClsStu_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vCurrEduClsStu_ConstructorName, strThisFuncName);
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
 * @param arrlngid_EduClsStuLst:关键字列表
 * @returns 对象列表
*/
export async function vCurrEduClsStu_GetObjLstByid_EduClsStuLst_Cache(arrid_EduClsStuLst: Array<number>,strid_CurrEduCls: string) {
const strThisFuncName = "GetObjLstByid_EduClsStuLst_Cache";
try
{
const arrvCurrEduClsStuObjLst_Cache = await vCurrEduClsStu_GetObjLst_Cache(strid_CurrEduCls);
const arrvCurrEduClsStu_Sel: Array <clsvCurrEduClsStuEN> = arrvCurrEduClsStuObjLst_Cache.filter(x => arrid_EduClsStuLst.indexOf(x.id_EduClsStu)>-1);
return arrvCurrEduClsStu_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrid_EduClsStuLst.join(","), vCurrEduClsStu_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvCurrEduClsStuEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function vCurrEduClsStu_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsvCurrEduClsStuEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(vCurrEduClsStu_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vCurrEduClsStu_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vCurrEduClsStu_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vCurrEduClsStu_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vCurrEduClsStu_ConstructorName, strThisFuncName);
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
export async function vCurrEduClsStu_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsvCurrEduClsStuEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vCurrEduClsStu_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vCurrEduClsStu_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vCurrEduClsStu_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vCurrEduClsStu_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vCurrEduClsStu_ConstructorName, strThisFuncName);
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
export async function vCurrEduClsStu_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vCurrEduClsStu_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vCurrEduClsStu_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vCurrEduClsStu_ConstructorName, strThisFuncName);
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
export async function vCurrEduClsStu_GetObjLstByPager_Cache(objPagerPara: stuPagerPara,strid_CurrEduCls: string) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrvCurrEduClsStuObjLst_Cache = await vCurrEduClsStu_GetObjLst_Cache(strid_CurrEduCls);
if (arrvCurrEduClsStuObjLst_Cache.length == 0) return arrvCurrEduClsStuObjLst_Cache;
let arrvCurrEduClsStu_Sel = arrvCurrEduClsStuObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objvCurrEduClsStu_Cond = new clsvCurrEduClsStuEN();
ObjectAssign(objvCurrEduClsStu_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsvCurrEduClsStuWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvCurrEduClsStu_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvCurrEduClsStu_Sel.length == 0) return arrvCurrEduClsStu_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.sort(vCurrEduClsStu_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.sort(objPagerPara.sortFun);
}
arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.slice(intStart, intEnd);     
return arrvCurrEduClsStu_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, vCurrEduClsStu_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvCurrEduClsStuEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function vCurrEduClsStu_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsvCurrEduClsStuEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(vCurrEduClsStu_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vCurrEduClsStu_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vCurrEduClsStu_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vCurrEduClsStu_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vCurrEduClsStu_ConstructorName, strThisFuncName);
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
 * @param objlngid_EduClsStu_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vCurrEduClsStu_IsExistRecord_Cache(objvCurrEduClsStu_Cond: clsvCurrEduClsStuEN,strid_CurrEduCls: string) {
const strThisFuncName = "IsExistRecord_Cache";
const arrvCurrEduClsStuObjLst_Cache = await vCurrEduClsStu_GetObjLst_Cache(strid_CurrEduCls);
if (arrvCurrEduClsStuObjLst_Cache == null) return false;
let arrvCurrEduClsStu_Sel: Array < clsvCurrEduClsStuEN > = arrvCurrEduClsStuObjLst_Cache;
if (objvCurrEduClsStu_Cond.sf_FldComparisonOp == null || objvCurrEduClsStu_Cond.sf_FldComparisonOp == "") return arrvCurrEduClsStu_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvCurrEduClsStu_Cond.sf_FldComparisonOp);
//console.log("clsvCurrEduClsStuWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvCurrEduClsStu_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvCurrEduClsStu_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvCurrEduClsStu_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objvCurrEduClsStu_Cond), vCurrEduClsStu_ConstructorName, strThisFuncName);
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
export async function vCurrEduClsStu_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(vCurrEduClsStu_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vCurrEduClsStu_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vCurrEduClsStu_ConstructorName, strThisFuncName);
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
 * @param lngid_EduClsStu:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function vCurrEduClsStu_IsExist(lngid_EduClsStu: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vCurrEduClsStu_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"id_EduClsStu": lngid_EduClsStu,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vCurrEduClsStu_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vCurrEduClsStu_ConstructorName, strThisFuncName);
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
 * @param lngid_EduClsStu:所给的关键字
 * @returns 对象
*/
export async function vCurrEduClsStu_IsExist_Cache(lngid_EduClsStu:number,strid_CurrEduCls:string) {
const strThisFuncName = "IsExist_Cache";
const arrvCurrEduClsStuObjLst_Cache = await vCurrEduClsStu_GetObjLst_Cache(strid_CurrEduCls);
if (arrvCurrEduClsStuObjLst_Cache == null) return false;
try
{
const arrvCurrEduClsStu_Sel: Array <clsvCurrEduClsStuEN> = arrvCurrEduClsStuObjLst_Cache.filter(x => x.id_EduClsStu == lngid_EduClsStu);
if (arrvCurrEduClsStu_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngid_EduClsStu, vCurrEduClsStu_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param lngid_EduClsStu:关键字
 * @returns 是否存在?存在返回True
 **/
export async function vCurrEduClsStu_IsExistAsync(lngid_EduClsStu: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vCurrEduClsStu_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "lngid_EduClsStu": lngid_EduClsStu }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vCurrEduClsStu_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vCurrEduClsStu_ConstructorName, strThisFuncName);
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
export async function vCurrEduClsStu_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(vCurrEduClsStu_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vCurrEduClsStu_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vCurrEduClsStu_ConstructorName, strThisFuncName);
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
 * @param objvCurrEduClsStu_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function vCurrEduClsStu_GetRecCountByCond_Cache(objvCurrEduClsStu_Cond: clsvCurrEduClsStuEN,strid_CurrEduCls: string) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrvCurrEduClsStuObjLst_Cache = await vCurrEduClsStu_GetObjLst_Cache(strid_CurrEduCls);
if (arrvCurrEduClsStuObjLst_Cache == null) return 0;
let arrvCurrEduClsStu_Sel: Array < clsvCurrEduClsStuEN > = arrvCurrEduClsStuObjLst_Cache;
if (objvCurrEduClsStu_Cond.sf_FldComparisonOp == null || objvCurrEduClsStu_Cond.sf_FldComparisonOp == "") return arrvCurrEduClsStu_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvCurrEduClsStu_Cond.sf_FldComparisonOp);
//console.log("clsvCurrEduClsStuWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvCurrEduClsStu_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvCurrEduClsStu_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvCurrEduClsStu_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objvCurrEduClsStu_Cond), vCurrEduClsStu_ConstructorName, strThisFuncName);
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
export function vCurrEduClsStu_GetWebApiUrl(strController: string, strAction: string): string {
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
export function vCurrEduClsStu_ReFreshThisCache(strid_CurrEduCls: string):void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = Format("{0}_{1}", clsvCurrEduClsStuEN._CurrTabName, strid_CurrEduCls);
switch (clsvCurrEduClsStuEN.CacheModeId)
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
export function vCurrEduClsStu_GetJSONStrByObj (pobjvCurrEduClsStuEN: clsvCurrEduClsStuEN): string
{
const strThisFuncName = "GetJSONStrByObj";
let strJson = "";
try
{
strJson = JSON.stringify(pobjvCurrEduClsStuEN);
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
export function vCurrEduClsStu_GetObjLstByJSONStr (strJSON: string): Array<clsvCurrEduClsStuEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrvCurrEduClsStuObjLst = new Array<clsvCurrEduClsStuEN>();
if (strJSON === "")
{
return arrvCurrEduClsStuObjLst;
}
try
{
arrvCurrEduClsStuObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvCurrEduClsStuObjLst;
}
return arrvCurrEduClsStuObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrvCurrEduClsStuObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function vCurrEduClsStu_GetObjLstByJSONObjLst (arrvCurrEduClsStuObjLstS: Array<clsvCurrEduClsStuEN>): Array<clsvCurrEduClsStuEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrvCurrEduClsStuObjLst = new Array<clsvCurrEduClsStuEN>();
for (const objInFor of arrvCurrEduClsStuObjLstS) {
const obj1 = vCurrEduClsStu_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrvCurrEduClsStuObjLst.push(obj1);
}
return arrvCurrEduClsStuObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vCurrEduClsStu_GetObjByJSONStr (strJSON: string): clsvCurrEduClsStuEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjvCurrEduClsStuEN = new clsvCurrEduClsStuEN();
if (strJSON === "")
{
return pobjvCurrEduClsStuEN;
}
try
{
pobjvCurrEduClsStuEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvCurrEduClsStuEN;
}
return pobjvCurrEduClsStuEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function vCurrEduClsStu_GetCombineCondition(objvCurrEduClsStu_Cond: clsvCurrEduClsStuEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN.con_id_EduClsStu) == true)
{
const strComparisonOp_id_EduClsStu:string = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN.con_id_EduClsStu];
strWhereCond += Format(" And {0} {2} {1}", clsvCurrEduClsStuEN.con_id_EduClsStu, objvCurrEduClsStu_Cond.id_EduClsStu, strComparisonOp_id_EduClsStu);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsStuEN.con_id_CurrEduCls, objvCurrEduClsStu_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN.con_CurrEduClsId) == true)
{
const strComparisonOp_CurrEduClsId:string = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN.con_CurrEduClsId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsStuEN.con_CurrEduClsId, objvCurrEduClsStu_Cond.currEduClsId, strComparisonOp_CurrEduClsId);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN.con_EduClsName) == true)
{
const strComparisonOp_EduClsName:string = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN.con_EduClsName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsStuEN.con_EduClsName, objvCurrEduClsStu_Cond.eduClsName, strComparisonOp_EduClsName);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN.con_CourseId) == true)
{
const strComparisonOp_CourseId:string = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN.con_CourseId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsStuEN.con_CourseId, objvCurrEduClsStu_Cond.courseId, strComparisonOp_CourseId);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN.con_CourseCode) == true)
{
const strComparisonOp_CourseCode:string = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN.con_CourseCode];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsStuEN.con_CourseCode, objvCurrEduClsStu_Cond.courseCode, strComparisonOp_CourseCode);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN.con_CourseName) == true)
{
const strComparisonOp_CourseName:string = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN.con_CourseName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsStuEN.con_CourseName, objvCurrEduClsStu_Cond.courseName, strComparisonOp_CourseName);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN.con_TeachingSolutionId) == true)
{
const strComparisonOp_TeachingSolutionId:string = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN.con_TeachingSolutionId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsStuEN.con_TeachingSolutionId, objvCurrEduClsStu_Cond.teachingSolutionId, strComparisonOp_TeachingSolutionId);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN.con_TeachingSolutionName) == true)
{
const strComparisonOp_TeachingSolutionName:string = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN.con_TeachingSolutionName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsStuEN.con_TeachingSolutionName, objvCurrEduClsStu_Cond.teachingSolutionName, strComparisonOp_TeachingSolutionName);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN.con_id_XzCollege) == true)
{
const strComparisonOp_id_XzCollege:string = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN.con_id_XzCollege];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsStuEN.con_id_XzCollege, objvCurrEduClsStu_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN.con_CollegeID) == true)
{
const strComparisonOp_CollegeID:string = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN.con_CollegeID];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsStuEN.con_CollegeID, objvCurrEduClsStu_Cond.collegeID, strComparisonOp_CollegeID);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN.con_CollegeName) == true)
{
const strComparisonOp_CollegeName:string = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN.con_CollegeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsStuEN.con_CollegeName, objvCurrEduClsStu_Cond.collegeName, strComparisonOp_CollegeName);
}
//数据类型number(smallint)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN.con_Mark) == true)
{
const strComparisonOp_Mark:string = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN.con_Mark];
strWhereCond += Format(" And {0} {2} {1}", clsvCurrEduClsStuEN.con_Mark, objvCurrEduClsStu_Cond.mark, strComparisonOp_Mark);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN.con_id_UniZone) == true)
{
const strComparisonOp_id_UniZone:string = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN.con_id_UniZone];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsStuEN.con_id_UniZone, objvCurrEduClsStu_Cond.id_UniZone, strComparisonOp_id_UniZone);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN.con_GradeBaseName) == true)
{
const strComparisonOp_GradeBaseName:string = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN.con_GradeBaseName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsStuEN.con_GradeBaseName, objvCurrEduClsStu_Cond.gradeBaseName, strComparisonOp_GradeBaseName);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN.con_IsEffective) == true)
{
if (objvCurrEduClsStu_Cond.isEffective == true)
{
strWhereCond += Format(" And {0} = '1'", clsvCurrEduClsStuEN.con_IsEffective);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvCurrEduClsStuEN.con_IsEffective);
}
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN.con_id_CourseType) == true)
{
const strComparisonOp_id_CourseType:string = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN.con_id_CourseType];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsStuEN.con_id_CourseType, objvCurrEduClsStu_Cond.id_CourseType, strComparisonOp_id_CourseType);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN.con_CourseTypeID) == true)
{
const strComparisonOp_CourseTypeID:string = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN.con_CourseTypeID];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsStuEN.con_CourseTypeID, objvCurrEduClsStu_Cond.courseTypeID, strComparisonOp_CourseTypeID);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN.con_CourseTypeName) == true)
{
const strComparisonOp_CourseTypeName:string = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN.con_CourseTypeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsStuEN.con_CourseTypeName, objvCurrEduClsStu_Cond.courseTypeName, strComparisonOp_CourseTypeName);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN.con_IsDegree) == true)
{
if (objvCurrEduClsStu_Cond.isDegree == true)
{
strWhereCond += Format(" And {0} = '1'", clsvCurrEduClsStuEN.con_IsDegree);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvCurrEduClsStuEN.con_IsDegree);
}
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN.con_CurrStuNum) == true)
{
const strComparisonOp_CurrStuNum:string = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN.con_CurrStuNum];
strWhereCond += Format(" And {0} {2} {1}", clsvCurrEduClsStuEN.con_CurrStuNum, objvCurrEduClsStu_Cond.currStuNum, strComparisonOp_CurrStuNum);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN.con_id_Stu) == true)
{
const strComparisonOp_id_Stu:string = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN.con_id_Stu];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsStuEN.con_id_Stu, objvCurrEduClsStu_Cond.id_Stu, strComparisonOp_id_Stu);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN.con_StuID) == true)
{
const strComparisonOp_StuID:string = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN.con_StuID];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsStuEN.con_StuID, objvCurrEduClsStu_Cond.stuID, strComparisonOp_StuID);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN.con_StuName) == true)
{
const strComparisonOp_StuName:string = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN.con_StuName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsStuEN.con_StuName, objvCurrEduClsStu_Cond.stuName, strComparisonOp_StuName);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN.con_id_Sex) == true)
{
const strComparisonOp_id_Sex:string = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN.con_id_Sex];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsStuEN.con_id_Sex, objvCurrEduClsStu_Cond.id_Sex, strComparisonOp_id_Sex);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN.con_SexDesc) == true)
{
const strComparisonOp_SexDesc:string = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN.con_SexDesc];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsStuEN.con_SexDesc, objvCurrEduClsStu_Cond.sexDesc, strComparisonOp_SexDesc);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN.con_MajorID) == true)
{
const strComparisonOp_MajorID:string = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN.con_MajorID];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsStuEN.con_MajorID, objvCurrEduClsStu_Cond.majorID, strComparisonOp_MajorID);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN.con_MajorName) == true)
{
const strComparisonOp_MajorName:string = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN.con_MajorName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsStuEN.con_MajorName, objvCurrEduClsStu_Cond.majorName, strComparisonOp_MajorName);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN.con_id_AdminCls) == true)
{
const strComparisonOp_id_AdminCls:string = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN.con_id_AdminCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsStuEN.con_id_AdminCls, objvCurrEduClsStu_Cond.id_AdminCls, strComparisonOp_id_AdminCls);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN.con_Birthday) == true)
{
const strComparisonOp_Birthday:string = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN.con_Birthday];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsStuEN.con_Birthday, objvCurrEduClsStu_Cond.birthday, strComparisonOp_Birthday);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN.con_EduClsStuStateID) == true)
{
const strComparisonOp_EduClsStuStateID:string = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN.con_EduClsStuStateID];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsStuEN.con_EduClsStuStateID, objvCurrEduClsStu_Cond.eduClsStuStateID, strComparisonOp_EduClsStuStateID);
}
//数据类型number(tinyint)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN.con_Score) == true)
{
const strComparisonOp_Score:string = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN.con_Score];
strWhereCond += Format(" And {0} {2} {1}", clsvCurrEduClsStuEN.con_Score, objvCurrEduClsStu_Cond.score, strComparisonOp_Score);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN.con_TotalScores) == true)
{
const strComparisonOp_TotalScores:string = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN.con_TotalScores];
strWhereCond += Format(" And {0} {2} {1}", clsvCurrEduClsStuEN.con_TotalScores, objvCurrEduClsStu_Cond.totalScores, strComparisonOp_TotalScores);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN.con_Ranking) == true)
{
const strComparisonOp_Ranking:string = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN.con_Ranking];
strWhereCond += Format(" And {0} {2} {1}", clsvCurrEduClsStuEN.con_Ranking, objvCurrEduClsStu_Cond.ranking, strComparisonOp_Ranking);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN.con_Percentile) == true)
{
const strComparisonOp_Percentile:string = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN.con_Percentile];
strWhereCond += Format(" And {0} {2} {1}", clsvCurrEduClsStuEN.con_Percentile, objvCurrEduClsStu_Cond.percentile, strComparisonOp_Percentile);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN.con_Confirmed) == true)
{
if (objvCurrEduClsStu_Cond.confirmed == true)
{
strWhereCond += Format(" And {0} = '1'", clsvCurrEduClsStuEN.con_Confirmed);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvCurrEduClsStuEN.con_Confirmed);
}
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN.con_SchoolTerm) == true)
{
const strComparisonOp_SchoolTerm:string = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN.con_SchoolTerm];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsStuEN.con_SchoolTerm, objvCurrEduClsStu_Cond.schoolTerm, strComparisonOp_SchoolTerm);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN.con_SchoolYear) == true)
{
const strComparisonOp_SchoolYear:string = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN.con_SchoolYear];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsStuEN.con_SchoolYear, objvCurrEduClsStu_Cond.schoolYear, strComparisonOp_SchoolYear);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN.con_SignInDate) == true)
{
const strComparisonOp_SignInDate:string = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN.con_SignInDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsStuEN.con_SignInDate, objvCurrEduClsStu_Cond.signInDate, strComparisonOp_SignInDate);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN.con_SignInStateID) == true)
{
const strComparisonOp_SignInStateID:string = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN.con_SignInStateID];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsStuEN.con_SignInStateID, objvCurrEduClsStu_Cond.signInStateID, strComparisonOp_SignInStateID);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN.con_SignInUser) == true)
{
const strComparisonOp_SignInUser:string = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN.con_SignInUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsStuEN.con_SignInUser, objvCurrEduClsStu_Cond.signInUser, strComparisonOp_SignInUser);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN.con_ModifyDate) == true)
{
const strComparisonOp_ModifyDate:string = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN.con_ModifyDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsStuEN.con_ModifyDate, objvCurrEduClsStu_Cond.modifyDate, strComparisonOp_ModifyDate);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN.con_ModifyUserID) == true)
{
const strComparisonOp_ModifyUserID:string = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN.con_ModifyUserID];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsStuEN.con_ModifyUserID, objvCurrEduClsStu_Cond.modifyUserID, strComparisonOp_ModifyUserID);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN.con_CollegeName4Stu) == true)
{
const strComparisonOp_CollegeName4Stu:string = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN.con_CollegeName4Stu];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsStuEN.con_CollegeName4Stu, objvCurrEduClsStu_Cond.collegeName4Stu, strComparisonOp_CollegeName4Stu);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN.con_EduClsTypeName) == true)
{
const strComparisonOp_EduClsTypeName:string = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN.con_EduClsTypeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsStuEN.con_EduClsTypeName, objvCurrEduClsStu_Cond.eduClsTypeName, strComparisonOp_EduClsTypeName);
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN.con_IsSynScore) == true)
{
if (objvCurrEduClsStu_Cond.isSynScore == true)
{
strWhereCond += Format(" And {0} = '1'", clsvCurrEduClsStuEN.con_IsSynScore);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvCurrEduClsStuEN.con_IsSynScore);
}
}
if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN.con_EduClsTypeId) == true)
{
const strComparisonOp_EduClsTypeId:string = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN.con_EduClsTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvCurrEduClsStuEN.con_EduClsTypeId, objvCurrEduClsStu_Cond.eduClsTypeId, strComparisonOp_EduClsTypeId);
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objvCurrEduClsStuENS:源对象
 * @param objvCurrEduClsStuENT:目标对象
*/
export function vCurrEduClsStu_CopyObjTo(objvCurrEduClsStuENS: clsvCurrEduClsStuEN , objvCurrEduClsStuENT: clsvCurrEduClsStuEN ): void 
{
objvCurrEduClsStuENT.id_EduClsStu = objvCurrEduClsStuENS.id_EduClsStu; //教学班学生流水号
objvCurrEduClsStuENT.id_CurrEduCls = objvCurrEduClsStuENS.id_CurrEduCls; //教学班流水号
objvCurrEduClsStuENT.currEduClsId = objvCurrEduClsStuENS.currEduClsId; //教学班Id
objvCurrEduClsStuENT.eduClsName = objvCurrEduClsStuENS.eduClsName; //教学班名
objvCurrEduClsStuENT.courseId = objvCurrEduClsStuENS.courseId; //课程Id
objvCurrEduClsStuENT.courseCode = objvCurrEduClsStuENS.courseCode; //课程代码
objvCurrEduClsStuENT.courseName = objvCurrEduClsStuENS.courseName; //课程名称
objvCurrEduClsStuENT.teachingSolutionId = objvCurrEduClsStuENS.teachingSolutionId; //教学方案Id
objvCurrEduClsStuENT.teachingSolutionName = objvCurrEduClsStuENS.teachingSolutionName; //教学方案名称
objvCurrEduClsStuENT.id_XzCollege = objvCurrEduClsStuENS.id_XzCollege; //学院流水号
objvCurrEduClsStuENT.collegeID = objvCurrEduClsStuENS.collegeID; //学院ID
objvCurrEduClsStuENT.collegeName = objvCurrEduClsStuENS.collegeName; //学院名称
objvCurrEduClsStuENT.lessonQtyPerWeek = objvCurrEduClsStuENS.lessonQtyPerWeek; //周课时数
objvCurrEduClsStuENT.mark = objvCurrEduClsStuENS.mark; //获得学分
objvCurrEduClsStuENT.id_UniZone = objvCurrEduClsStuENS.id_UniZone; //校区流水号
objvCurrEduClsStuENT.gradeBaseName = objvCurrEduClsStuENS.gradeBaseName; //年级名称
objvCurrEduClsStuENT.isEffective = objvCurrEduClsStuENS.isEffective; //是否有效
objvCurrEduClsStuENT.id_CourseType = objvCurrEduClsStuENS.id_CourseType; //课程类型流水号
objvCurrEduClsStuENT.courseTypeID = objvCurrEduClsStuENS.courseTypeID; //课程类型ID
objvCurrEduClsStuENT.courseTypeName = objvCurrEduClsStuENS.courseTypeName; //课程类型名称
objvCurrEduClsStuENT.isDegree = objvCurrEduClsStuENS.isDegree; //是否学位课
objvCurrEduClsStuENT.currStuNum = objvCurrEduClsStuENS.currStuNum; //当前学生数
objvCurrEduClsStuENT.id_Stu = objvCurrEduClsStuENS.id_Stu; //学生流水号
objvCurrEduClsStuENT.stuID = objvCurrEduClsStuENS.stuID; //学号
objvCurrEduClsStuENT.stuName = objvCurrEduClsStuENS.stuName; //姓名
objvCurrEduClsStuENT.id_Sex = objvCurrEduClsStuENS.id_Sex; //性别流水号
objvCurrEduClsStuENT.sexDesc = objvCurrEduClsStuENS.sexDesc; //性别名称
objvCurrEduClsStuENT.majorID = objvCurrEduClsStuENS.majorID; //专业ID
objvCurrEduClsStuENT.majorName = objvCurrEduClsStuENS.majorName; //专业名称
objvCurrEduClsStuENT.id_AdminCls = objvCurrEduClsStuENS.id_AdminCls; //行政班流水号
objvCurrEduClsStuENT.birthday = objvCurrEduClsStuENS.birthday; //出生日期
objvCurrEduClsStuENT.eduClsStuStateID = objvCurrEduClsStuENS.eduClsStuStateID; //教学班学生状态编号
objvCurrEduClsStuENT.getScoreTimes = objvCurrEduClsStuENS.getScoreTimes; //获得成绩次数
objvCurrEduClsStuENT.score = objvCurrEduClsStuENS.score; //得分
objvCurrEduClsStuENT.totalScores = objvCurrEduClsStuENS.totalScores; //总分值
objvCurrEduClsStuENT.ranking = objvCurrEduClsStuENS.ranking; //名次
objvCurrEduClsStuENT.percentile = objvCurrEduClsStuENS.percentile; //百分位
objvCurrEduClsStuENT.confirmed = objvCurrEduClsStuENS.confirmed; //是否确认
objvCurrEduClsStuENT.schoolTerm = objvCurrEduClsStuENS.schoolTerm; //学期
objvCurrEduClsStuENT.schoolYear = objvCurrEduClsStuENS.schoolYear; //学年
objvCurrEduClsStuENT.signInDate = objvCurrEduClsStuENS.signInDate; //签入时间
objvCurrEduClsStuENT.signInStateID = objvCurrEduClsStuENS.signInStateID; //签入状态表流水号
objvCurrEduClsStuENT.signInUser = objvCurrEduClsStuENS.signInUser; //签入人
objvCurrEduClsStuENT.modifyDate = objvCurrEduClsStuENS.modifyDate; //修改日期
objvCurrEduClsStuENT.modifyUserID = objvCurrEduClsStuENS.modifyUserID; //修改人
objvCurrEduClsStuENT.collegeName4Stu = objvCurrEduClsStuENS.collegeName4Stu; //CollegeName4Stu
objvCurrEduClsStuENT.eduClsTypeName = objvCurrEduClsStuENS.eduClsTypeName; //教学班类型名称
objvCurrEduClsStuENT.isSynScore = objvCurrEduClsStuENS.isSynScore; //是否同步成绩
objvCurrEduClsStuENT.eduClsTypeId = objvCurrEduClsStuENS.eduClsTypeId; //教学班类型Id
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objvCurrEduClsStuENS:源对象
 * @param objvCurrEduClsStuENT:目标对象
*/
export function vCurrEduClsStu_GetObjFromJsonObj(objvCurrEduClsStuENS: clsvCurrEduClsStuEN): clsvCurrEduClsStuEN 
{
 const objvCurrEduClsStuENT: clsvCurrEduClsStuEN = new clsvCurrEduClsStuEN();
ObjectAssign(objvCurrEduClsStuENT, objvCurrEduClsStuENS);
 return objvCurrEduClsStuENT;
}