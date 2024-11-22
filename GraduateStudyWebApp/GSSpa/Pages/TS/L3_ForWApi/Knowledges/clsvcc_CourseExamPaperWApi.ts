
 /**
 * 类名:clsvcc_CourseExamPaperWApi
 * 表名:vcc_CourseExamPaper(01120098)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 12:02:24
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
 * v考卷(vcc_CourseExamPaper)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clsvcc_CourseExamPaperEN } from "../../L0_Entity/Knowledges/clsvcc_CourseExamPaperEN.js";
import { BindDdl_ObjLstInDiv_V, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const vcc_CourseExamPaper_Controller = "vcc_CourseExamPaperApi";
 export const vcc_CourseExamPaper_ConstructorName = "vcc_CourseExamPaper";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strCourseExamPaperId:关键字
 * @returns 对象
 **/
export async function vcc_CourseExamPaper_GetObjByCourseExamPaperIdAsync(strCourseExamPaperId: string): Promise<clsvcc_CourseExamPaperEN>  
{
const strThisFuncName = "GetObjByCourseExamPaperIdAsync";

if (IsNullOrEmpty(strCourseExamPaperId) == true)
{
  const strMsg = Format("参数:[strCourseExamPaperId]不能为空！(In GetObjByCourseExamPaperIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strCourseExamPaperId.length != 8)
{
const strMsg = Format("缓存分类变量:[strCourseExamPaperId]的长度:[{0}]不正确！", strCourseExamPaperId.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByCourseExamPaperId";
const strUrl = GetWebApiUrl(vcc_CourseExamPaper_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strCourseExamPaperId": strCourseExamPaperId,
}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObj = data.returnObj;
if (returnObj == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vcc_CourseExamPaper_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvcc_CourseExamPaper = vcc_CourseExamPaper_GetObjFromJsonObj(returnObj);
return objvcc_CourseExamPaper;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_CourseExamPaper_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_CourseExamPaper_ConstructorName, strThisFuncName);
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
 * @param strCourseExamPaperId:所给的关键字
 * @returns 对象
*/
export async function vcc_CourseExamPaper_GetObjByCourseExamPaperId_Cache(strCourseExamPaperId:string,strCourseId:string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByCourseExamPaperId_Cache";

if (IsNullOrEmpty(strCourseExamPaperId) == true)
{
  const strMsg = Format("参数:[strCourseExamPaperId]不能为空！(In GetObjByCourseExamPaperId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strCourseExamPaperId.length != 8)
{
const strMsg = Format("缓存分类变量:[strCourseExamPaperId]的长度:[{0}]不正确！", strCourseExamPaperId.length);
console.error(strMsg);
throw (strMsg);
}
const arrvcc_CourseExamPaperObjLst_Cache = await vcc_CourseExamPaper_GetObjLst_Cache(strCourseId);
try
{
const arrvcc_CourseExamPaper_Sel: Array <clsvcc_CourseExamPaperEN> = arrvcc_CourseExamPaperObjLst_Cache.filter(x => x.courseExamPaperId == strCourseExamPaperId);
let objvcc_CourseExamPaper: clsvcc_CourseExamPaperEN;
if (arrvcc_CourseExamPaper_Sel.length > 0)
{
objvcc_CourseExamPaper = arrvcc_CourseExamPaper_Sel[0];
return objvcc_CourseExamPaper;
}
else
{
if (bolTryAsyncOnce == true)
{
objvcc_CourseExamPaper = await vcc_CourseExamPaper_GetObjByCourseExamPaperIdAsync(strCourseExamPaperId);
if (objvcc_CourseExamPaper != null)
{
vcc_CourseExamPaper_ReFreshThisCache(strCourseId);
return objvcc_CourseExamPaper;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strCourseExamPaperId, vcc_CourseExamPaper_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param strCourseExamPaperId:所给的关键字
 * @returns 对象
*/
export async function vcc_CourseExamPaper_GetObjByCourseExamPaperId_localStorage(strCourseExamPaperId: string) {
const strThisFuncName = "GetObjByCourseExamPaperId_localStorage";

if (IsNullOrEmpty(strCourseExamPaperId) == true)
{
  const strMsg = Format("参数:[strCourseExamPaperId]不能为空！(In GetObjByCourseExamPaperId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
if (strCourseExamPaperId.length != 8)
{
const strMsg = Format("缓存分类变量:[strCourseExamPaperId]的长度:[{0}]不正确！", strCourseExamPaperId.length);
console.error(strMsg);
throw (strMsg);
}
const strKey = Format("{0}_{1}", clsvcc_CourseExamPaperEN._CurrTabName, strCourseExamPaperId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objvcc_CourseExamPaper_Cache: clsvcc_CourseExamPaperEN = JSON.parse(strTempObj);
return objvcc_CourseExamPaper_Cache;
}
try
{
const objvcc_CourseExamPaper = await vcc_CourseExamPaper_GetObjByCourseExamPaperIdAsync(strCourseExamPaperId);
if (objvcc_CourseExamPaper != null)
{
localStorage.setItem(strKey, JSON.stringify(objvcc_CourseExamPaper));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objvcc_CourseExamPaper;
}
return objvcc_CourseExamPaper;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strCourseExamPaperId, vcc_CourseExamPaper_ConstructorName, strThisFuncName);
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
 @param strCourseId:缓存的分类字段
 * @returns 返回一个输出字段值
*/
export async function vcc_CourseExamPaper_func(strInFldName:string , strOutFldName:string , strInValue:string , strCourseId_C: string)
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

if (strInFldName != clsvcc_CourseExamPaperEN.con_CourseExamPaperId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsvcc_CourseExamPaperEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clsvcc_CourseExamPaperEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strCourseExamPaperId = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objvcc_CourseExamPaper = await vcc_CourseExamPaper_GetObjByCourseExamPaperId_Cache(strCourseExamPaperId , strCourseId_C);
if (objvcc_CourseExamPaper == null) return "";
return objvcc_CourseExamPaper.GetFldValue(strOutFldName).toString();
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
export function vcc_CourseExamPaper_SortFun_Defa(a:clsvcc_CourseExamPaperEN , b:clsvcc_CourseExamPaperEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.courseExamPaperId.localeCompare(b.courseExamPaperId);
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
export function vcc_CourseExamPaper_SortFun_Defa_2Fld(a:clsvcc_CourseExamPaperEN , b:clsvcc_CourseExamPaperEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.courseId == b.courseId) return a.courseName.localeCompare(b.courseName);
else return a.courseId.localeCompare(b.courseId);
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
export function vcc_CourseExamPaper_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsvcc_CourseExamPaperEN.con_CourseExamPaperId:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return a.courseExamPaperId.localeCompare(b.courseExamPaperId);
}
case clsvcc_CourseExamPaperEN.con_CourseId:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return a.courseId.localeCompare(b.courseId);
}
case clsvcc_CourseExamPaperEN.con_CourseName:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return a.courseName.localeCompare(b.courseName);
}
case clsvcc_CourseExamPaperEN.con_ExamPaperName:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return a.examPaperName.localeCompare(b.examPaperName);
}
case clsvcc_CourseExamPaperEN.con_PaperIndex:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return a.paperIndex-b.paperIndex;
}
case clsvcc_CourseExamPaperEN.con_ExamPaperTypeId:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return a.examPaperTypeId.localeCompare(b.examPaperTypeId);
}
case clsvcc_CourseExamPaperEN.con_ExamPaperTypeName:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return a.examPaperTypeName.localeCompare(b.examPaperTypeName);
}
case clsvcc_CourseExamPaperEN.con_IsShow:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
if (a.isShow == true) return 1;
else return -1
}
case clsvcc_CourseExamPaperEN.con_TotalScore:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return a.totalScore-b.totalScore;
}
case clsvcc_CourseExamPaperEN.con_ViewCount:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return a.viewCount-b.viewCount;
}
case clsvcc_CourseExamPaperEN.con_DoneNumber:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return a.doneNumber-b.doneNumber;
}
case clsvcc_CourseExamPaperEN.con_PaperTime:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return a.paperTime-b.paperTime;
}
case clsvcc_CourseExamPaperEN.con_DownloadNumber:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return a.downloadNumber-b.downloadNumber;
}
case clsvcc_CourseExamPaperEN.con_CollectionCount:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return a.collectionCount-b.collectionCount;
}
case clsvcc_CourseExamPaperEN.con_LikeCount:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return a.likeCount-b.likeCount;
}
case clsvcc_CourseExamPaperEN.con_id_XzMajor:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return a.id_XzMajor.localeCompare(b.id_XzMajor);
}
case clsvcc_CourseExamPaperEN.con_MajorName:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return a.majorName.localeCompare(b.majorName);
}
case clsvcc_CourseExamPaperEN.con_PaperDispModeId:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return a.paperDispModeId.localeCompare(b.paperDispModeId);
}
case clsvcc_CourseExamPaperEN.con_PaperDispModeName:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return a.paperDispModeName.localeCompare(b.paperDispModeName);
}
case clsvcc_CourseExamPaperEN.con_ExamCreateTime:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return a.examCreateTime.localeCompare(b.examCreateTime);
}
case clsvcc_CourseExamPaperEN.con_CreateUserID:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return a.createUserID.localeCompare(b.createUserID);
}
case clsvcc_CourseExamPaperEN.con_UserName:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return a.userName.localeCompare(b.userName);
}
case clsvcc_CourseExamPaperEN.con_IsOpenToAllStu:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
if (a.isOpenToAllStu == true) return 1;
else return -1
}
case clsvcc_CourseExamPaperEN.con_IsOpenToSchool:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
if (a.isOpenToSchool == true) return 1;
else return -1
}
case clsvcc_CourseExamPaperEN.con_IsOpenToSocial:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
if (a.isOpenToSocial == true) return 1;
else return -1
}
case clsvcc_CourseExamPaperEN.con_CourseChapterId:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return a.courseChapterId.localeCompare(b.courseChapterId);
}
case clsvcc_CourseExamPaperEN.con_CourseChapterName:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return a.courseChapterName.localeCompare(b.courseChapterName);
}
case clsvcc_CourseExamPaperEN.con_ChapterId:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return a.chapterId.localeCompare(b.chapterId);
}
case clsvcc_CourseExamPaperEN.con_SectionId:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return a.sectionId.localeCompare(b.sectionId);
}
case clsvcc_CourseExamPaperEN.con_ChapterName:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return a.chapterName.localeCompare(b.chapterName);
}
case clsvcc_CourseExamPaperEN.con_SectionName:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return a.sectionName.localeCompare(b.sectionName);
}
case clsvcc_CourseExamPaperEN.con_ChapterName_Sim:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return a.chapterName_Sim.localeCompare(b.chapterName_Sim);
}
case clsvcc_CourseExamPaperEN.con_SectionName_Sim:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return a.sectionName_Sim.localeCompare(b.sectionName_Sim);
}
case clsvcc_CourseExamPaperEN.con_IsAutoGeneQuestion:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
if (a.isAutoGeneQuestion == true) return 1;
else return -1
}
case clsvcc_CourseExamPaperEN.con_IsCanMultiDo:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
if (a.isCanMultiDo == true) return 1;
else return -1
}
case clsvcc_CourseExamPaperEN.con_UpdDate:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsvcc_CourseExamPaperEN.con_UpdUserId:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return a.updUserId.localeCompare(b.updUserId);
}
case clsvcc_CourseExamPaperEN.con_Memo:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return a.memo.localeCompare(b.memo);
}
case clsvcc_CourseExamPaperEN.con_QuestionNum:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return a.questionNum-b.questionNum;
}
case clsvcc_CourseExamPaperEN.con_BigTopicNum:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return a.bigTopicNum-b.bigTopicNum;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vcc_CourseExamPaper]中不存在！(in ${ vcc_CourseExamPaper_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsvcc_CourseExamPaperEN.con_CourseExamPaperId:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return b.courseExamPaperId.localeCompare(a.courseExamPaperId);
}
case clsvcc_CourseExamPaperEN.con_CourseId:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return b.courseId.localeCompare(a.courseId);
}
case clsvcc_CourseExamPaperEN.con_CourseName:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return b.courseName.localeCompare(a.courseName);
}
case clsvcc_CourseExamPaperEN.con_ExamPaperName:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return b.examPaperName.localeCompare(a.examPaperName);
}
case clsvcc_CourseExamPaperEN.con_PaperIndex:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return b.paperIndex-a.paperIndex;
}
case clsvcc_CourseExamPaperEN.con_ExamPaperTypeId:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return b.examPaperTypeId.localeCompare(a.examPaperTypeId);
}
case clsvcc_CourseExamPaperEN.con_ExamPaperTypeName:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return b.examPaperTypeName.localeCompare(a.examPaperTypeName);
}
case clsvcc_CourseExamPaperEN.con_IsShow:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
if (b.isShow == true) return 1;
else return -1
}
case clsvcc_CourseExamPaperEN.con_TotalScore:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return b.totalScore-a.totalScore;
}
case clsvcc_CourseExamPaperEN.con_ViewCount:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return b.viewCount-a.viewCount;
}
case clsvcc_CourseExamPaperEN.con_DoneNumber:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return b.doneNumber-a.doneNumber;
}
case clsvcc_CourseExamPaperEN.con_PaperTime:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return b.paperTime-a.paperTime;
}
case clsvcc_CourseExamPaperEN.con_DownloadNumber:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return b.downloadNumber-a.downloadNumber;
}
case clsvcc_CourseExamPaperEN.con_CollectionCount:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return b.collectionCount-a.collectionCount;
}
case clsvcc_CourseExamPaperEN.con_LikeCount:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return b.likeCount-a.likeCount;
}
case clsvcc_CourseExamPaperEN.con_id_XzMajor:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return b.id_XzMajor.localeCompare(a.id_XzMajor);
}
case clsvcc_CourseExamPaperEN.con_MajorName:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return b.majorName.localeCompare(a.majorName);
}
case clsvcc_CourseExamPaperEN.con_PaperDispModeId:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return b.paperDispModeId.localeCompare(a.paperDispModeId);
}
case clsvcc_CourseExamPaperEN.con_PaperDispModeName:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return b.paperDispModeName.localeCompare(a.paperDispModeName);
}
case clsvcc_CourseExamPaperEN.con_ExamCreateTime:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return b.examCreateTime.localeCompare(a.examCreateTime);
}
case clsvcc_CourseExamPaperEN.con_CreateUserID:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return b.createUserID.localeCompare(a.createUserID);
}
case clsvcc_CourseExamPaperEN.con_UserName:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return b.userName.localeCompare(a.userName);
}
case clsvcc_CourseExamPaperEN.con_IsOpenToAllStu:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
if (b.isOpenToAllStu == true) return 1;
else return -1
}
case clsvcc_CourseExamPaperEN.con_IsOpenToSchool:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
if (b.isOpenToSchool == true) return 1;
else return -1
}
case clsvcc_CourseExamPaperEN.con_IsOpenToSocial:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
if (b.isOpenToSocial == true) return 1;
else return -1
}
case clsvcc_CourseExamPaperEN.con_CourseChapterId:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return b.courseChapterId.localeCompare(a.courseChapterId);
}
case clsvcc_CourseExamPaperEN.con_CourseChapterName:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return b.courseChapterName.localeCompare(a.courseChapterName);
}
case clsvcc_CourseExamPaperEN.con_ChapterId:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return b.chapterId.localeCompare(a.chapterId);
}
case clsvcc_CourseExamPaperEN.con_SectionId:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return b.sectionId.localeCompare(a.sectionId);
}
case clsvcc_CourseExamPaperEN.con_ChapterName:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return b.chapterName.localeCompare(a.chapterName);
}
case clsvcc_CourseExamPaperEN.con_SectionName:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return b.sectionName.localeCompare(a.sectionName);
}
case clsvcc_CourseExamPaperEN.con_ChapterName_Sim:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return b.chapterName_Sim.localeCompare(a.chapterName_Sim);
}
case clsvcc_CourseExamPaperEN.con_SectionName_Sim:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return b.sectionName_Sim.localeCompare(a.sectionName_Sim);
}
case clsvcc_CourseExamPaperEN.con_IsAutoGeneQuestion:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
if (b.isAutoGeneQuestion == true) return 1;
else return -1
}
case clsvcc_CourseExamPaperEN.con_IsCanMultiDo:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
if (b.isCanMultiDo == true) return 1;
else return -1
}
case clsvcc_CourseExamPaperEN.con_UpdDate:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsvcc_CourseExamPaperEN.con_UpdUserId:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return b.updUserId.localeCompare(a.updUserId);
}
case clsvcc_CourseExamPaperEN.con_Memo:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return b.memo.localeCompare(a.memo);
}
case clsvcc_CourseExamPaperEN.con_QuestionNum:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return b.questionNum-a.questionNum;
}
case clsvcc_CourseExamPaperEN.con_BigTopicNum:
return (a: clsvcc_CourseExamPaperEN, b: clsvcc_CourseExamPaperEN) => {
return b.bigTopicNum-a.bigTopicNum;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vcc_CourseExamPaper]中不存在！(in ${ vcc_CourseExamPaper_ConstructorName}.${ strThisFuncName})`;
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
export async function vcc_CourseExamPaper_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsvcc_CourseExamPaperEN.con_CourseExamPaperId:
return (obj: clsvcc_CourseExamPaperEN) => {
return obj.courseExamPaperId === value;
}
case clsvcc_CourseExamPaperEN.con_CourseId:
return (obj: clsvcc_CourseExamPaperEN) => {
return obj.courseId === value;
}
case clsvcc_CourseExamPaperEN.con_CourseName:
return (obj: clsvcc_CourseExamPaperEN) => {
return obj.courseName === value;
}
case clsvcc_CourseExamPaperEN.con_ExamPaperName:
return (obj: clsvcc_CourseExamPaperEN) => {
return obj.examPaperName === value;
}
case clsvcc_CourseExamPaperEN.con_PaperIndex:
return (obj: clsvcc_CourseExamPaperEN) => {
return obj.paperIndex === value;
}
case clsvcc_CourseExamPaperEN.con_ExamPaperTypeId:
return (obj: clsvcc_CourseExamPaperEN) => {
return obj.examPaperTypeId === value;
}
case clsvcc_CourseExamPaperEN.con_ExamPaperTypeName:
return (obj: clsvcc_CourseExamPaperEN) => {
return obj.examPaperTypeName === value;
}
case clsvcc_CourseExamPaperEN.con_IsShow:
return (obj: clsvcc_CourseExamPaperEN) => {
return obj.isShow === value;
}
case clsvcc_CourseExamPaperEN.con_TotalScore:
return (obj: clsvcc_CourseExamPaperEN) => {
return obj.totalScore === value;
}
case clsvcc_CourseExamPaperEN.con_ViewCount:
return (obj: clsvcc_CourseExamPaperEN) => {
return obj.viewCount === value;
}
case clsvcc_CourseExamPaperEN.con_DoneNumber:
return (obj: clsvcc_CourseExamPaperEN) => {
return obj.doneNumber === value;
}
case clsvcc_CourseExamPaperEN.con_PaperTime:
return (obj: clsvcc_CourseExamPaperEN) => {
return obj.paperTime === value;
}
case clsvcc_CourseExamPaperEN.con_DownloadNumber:
return (obj: clsvcc_CourseExamPaperEN) => {
return obj.downloadNumber === value;
}
case clsvcc_CourseExamPaperEN.con_CollectionCount:
return (obj: clsvcc_CourseExamPaperEN) => {
return obj.collectionCount === value;
}
case clsvcc_CourseExamPaperEN.con_LikeCount:
return (obj: clsvcc_CourseExamPaperEN) => {
return obj.likeCount === value;
}
case clsvcc_CourseExamPaperEN.con_id_XzMajor:
return (obj: clsvcc_CourseExamPaperEN) => {
return obj.id_XzMajor === value;
}
case clsvcc_CourseExamPaperEN.con_MajorName:
return (obj: clsvcc_CourseExamPaperEN) => {
return obj.majorName === value;
}
case clsvcc_CourseExamPaperEN.con_PaperDispModeId:
return (obj: clsvcc_CourseExamPaperEN) => {
return obj.paperDispModeId === value;
}
case clsvcc_CourseExamPaperEN.con_PaperDispModeName:
return (obj: clsvcc_CourseExamPaperEN) => {
return obj.paperDispModeName === value;
}
case clsvcc_CourseExamPaperEN.con_ExamCreateTime:
return (obj: clsvcc_CourseExamPaperEN) => {
return obj.examCreateTime === value;
}
case clsvcc_CourseExamPaperEN.con_CreateUserID:
return (obj: clsvcc_CourseExamPaperEN) => {
return obj.createUserID === value;
}
case clsvcc_CourseExamPaperEN.con_UserName:
return (obj: clsvcc_CourseExamPaperEN) => {
return obj.userName === value;
}
case clsvcc_CourseExamPaperEN.con_IsOpenToAllStu:
return (obj: clsvcc_CourseExamPaperEN) => {
return obj.isOpenToAllStu === value;
}
case clsvcc_CourseExamPaperEN.con_IsOpenToSchool:
return (obj: clsvcc_CourseExamPaperEN) => {
return obj.isOpenToSchool === value;
}
case clsvcc_CourseExamPaperEN.con_IsOpenToSocial:
return (obj: clsvcc_CourseExamPaperEN) => {
return obj.isOpenToSocial === value;
}
case clsvcc_CourseExamPaperEN.con_CourseChapterId:
return (obj: clsvcc_CourseExamPaperEN) => {
return obj.courseChapterId === value;
}
case clsvcc_CourseExamPaperEN.con_CourseChapterName:
return (obj: clsvcc_CourseExamPaperEN) => {
return obj.courseChapterName === value;
}
case clsvcc_CourseExamPaperEN.con_ChapterId:
return (obj: clsvcc_CourseExamPaperEN) => {
return obj.chapterId === value;
}
case clsvcc_CourseExamPaperEN.con_SectionId:
return (obj: clsvcc_CourseExamPaperEN) => {
return obj.sectionId === value;
}
case clsvcc_CourseExamPaperEN.con_ChapterName:
return (obj: clsvcc_CourseExamPaperEN) => {
return obj.chapterName === value;
}
case clsvcc_CourseExamPaperEN.con_SectionName:
return (obj: clsvcc_CourseExamPaperEN) => {
return obj.sectionName === value;
}
case clsvcc_CourseExamPaperEN.con_ChapterName_Sim:
return (obj: clsvcc_CourseExamPaperEN) => {
return obj.chapterName_Sim === value;
}
case clsvcc_CourseExamPaperEN.con_SectionName_Sim:
return (obj: clsvcc_CourseExamPaperEN) => {
return obj.sectionName_Sim === value;
}
case clsvcc_CourseExamPaperEN.con_IsAutoGeneQuestion:
return (obj: clsvcc_CourseExamPaperEN) => {
return obj.isAutoGeneQuestion === value;
}
case clsvcc_CourseExamPaperEN.con_IsCanMultiDo:
return (obj: clsvcc_CourseExamPaperEN) => {
return obj.isCanMultiDo === value;
}
case clsvcc_CourseExamPaperEN.con_UpdDate:
return (obj: clsvcc_CourseExamPaperEN) => {
return obj.updDate === value;
}
case clsvcc_CourseExamPaperEN.con_UpdUserId:
return (obj: clsvcc_CourseExamPaperEN) => {
return obj.updUserId === value;
}
case clsvcc_CourseExamPaperEN.con_Memo:
return (obj: clsvcc_CourseExamPaperEN) => {
return obj.memo === value;
}
case clsvcc_CourseExamPaperEN.con_QuestionNum:
return (obj: clsvcc_CourseExamPaperEN) => {
return obj.questionNum === value;
}
case clsvcc_CourseExamPaperEN.con_BigTopicNum:
return (obj: clsvcc_CourseExamPaperEN) => {
return obj.bigTopicNum === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vcc_CourseExamPaper]中不存在！(in ${ vcc_CourseExamPaper_ConstructorName}.${ strThisFuncName})`;
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
export async function vcc_CourseExamPaper_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vcc_CourseExamPaper_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_CourseExamPaper_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_CourseExamPaper_ConstructorName, strThisFuncName);
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
export async function vcc_CourseExamPaper_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vcc_CourseExamPaper_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_CourseExamPaper_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_CourseExamPaper_ConstructorName, strThisFuncName);
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
export async function vcc_CourseExamPaper_GetFirstObjAsync(strWhereCond: string): Promise<clsvcc_CourseExamPaperEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(vcc_CourseExamPaper_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vcc_CourseExamPaper_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvcc_CourseExamPaper = vcc_CourseExamPaper_GetObjFromJsonObj(returnObj);
return objvcc_CourseExamPaper;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_CourseExamPaper_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_CourseExamPaper_ConstructorName, strThisFuncName);
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
export async function vcc_CourseExamPaper_GetObjLst_ClientCache(strCourseId: string)
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("CourseId='{0}'", strCourseId);
const strKey = Format("{0}_{1}", clsvcc_CourseExamPaperEN._CurrTabName, strCourseId);
clsvcc_CourseExamPaperEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvcc_CourseExamPaperEN._CurrTabName);
if (IsNullOrEmpty(clsvcc_CourseExamPaperEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvcc_CourseExamPaperEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrvcc_CourseExamPaperExObjLst_Cache: Array<clsvcc_CourseExamPaperEN> = CacheHelper.Get(strKey);
const arrvcc_CourseExamPaperObjLst_T = vcc_CourseExamPaper_GetObjLstByJSONObjLst(arrvcc_CourseExamPaperExObjLst_Cache);
return arrvcc_CourseExamPaperObjLst_T;
}
try
{
const arrvcc_CourseExamPaperExObjLst = await vcc_CourseExamPaper_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrvcc_CourseExamPaperExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvcc_CourseExamPaperExObjLst.length);
console.log(strInfo);
return arrvcc_CourseExamPaperExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vcc_CourseExamPaper_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vcc_CourseExamPaper_GetObjLst_localStorage(strCourseId: string)
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("CourseId='{0}'", strCourseId);
const strKey = Format("{0}_{1}", clsvcc_CourseExamPaperEN._CurrTabName, strCourseId);
clsvcc_CourseExamPaperEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvcc_CourseExamPaperEN._CurrTabName);
if (IsNullOrEmpty(clsvcc_CourseExamPaperEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvcc_CourseExamPaperEN.CacheAddiCondition);
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
const arrvcc_CourseExamPaperExObjLst_Cache: Array<clsvcc_CourseExamPaperEN> = JSON.parse(strTempObjLst);
const arrvcc_CourseExamPaperObjLst_T = vcc_CourseExamPaper_GetObjLstByJSONObjLst(arrvcc_CourseExamPaperExObjLst_Cache);
return arrvcc_CourseExamPaperObjLst_T;
}
try
{
const arrvcc_CourseExamPaperExObjLst = await vcc_CourseExamPaper_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrvcc_CourseExamPaperExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvcc_CourseExamPaperExObjLst.length);
console.log(strInfo);
return arrvcc_CourseExamPaperExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vcc_CourseExamPaper_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vcc_CourseExamPaper_GetObjLst_localStorage_PureCache(strCourseId: string)
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("CourseId='{0}'", strCourseId);
const strKey = Format("{0}_{1}", clsvcc_CourseExamPaperEN._CurrTabName, strCourseId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrvcc_CourseExamPaperObjLst_Cache: Array<clsvcc_CourseExamPaperEN> = JSON.parse(strTempObjLst);
return arrvcc_CourseExamPaperObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function vcc_CourseExamPaper_GetObjLstAsync(strWhereCond: string): Promise<Array<clsvcc_CourseExamPaperEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(vcc_CourseExamPaper_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vcc_CourseExamPaper_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vcc_CourseExamPaper_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_CourseExamPaper_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_CourseExamPaper_ConstructorName, strThisFuncName);
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
export async function vcc_CourseExamPaper_GetObjLst_sessionStorage(strCourseId: string)
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("CourseId='{0}'", strCourseId);
const strKey = Format("{0}_{1}", clsvcc_CourseExamPaperEN._CurrTabName, strCourseId);
clsvcc_CourseExamPaperEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvcc_CourseExamPaperEN._CurrTabName);
if (IsNullOrEmpty(clsvcc_CourseExamPaperEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvcc_CourseExamPaperEN.CacheAddiCondition);
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
const arrvcc_CourseExamPaperExObjLst_Cache: Array<clsvcc_CourseExamPaperEN> = JSON.parse(strTempObjLst);
const arrvcc_CourseExamPaperObjLst_T = vcc_CourseExamPaper_GetObjLstByJSONObjLst(arrvcc_CourseExamPaperExObjLst_Cache);
return arrvcc_CourseExamPaperObjLst_T;
}
try
{
const arrvcc_CourseExamPaperExObjLst = await vcc_CourseExamPaper_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrvcc_CourseExamPaperExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvcc_CourseExamPaperExObjLst.length);
console.log(strInfo);
return arrvcc_CourseExamPaperExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vcc_CourseExamPaper_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vcc_CourseExamPaper_GetObjLst_sessionStorage_PureCache(strCourseId: string)
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("CourseId='{0}'", strCourseId);
const strKey = Format("{0}_{1}", clsvcc_CourseExamPaperEN._CurrTabName, strCourseId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrvcc_CourseExamPaperObjLst_Cache: Array<clsvcc_CourseExamPaperEN> = JSON.parse(strTempObjLst);
return arrvcc_CourseExamPaperObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vcc_CourseExamPaper_GetObjLst_Cache(strCourseId: string): Promise<Array<clsvcc_CourseExamPaperEN>>
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
let arrvcc_CourseExamPaperObjLst_Cache;
switch (clsvcc_CourseExamPaperEN.CacheModeId)
{
case "04"://sessionStorage
arrvcc_CourseExamPaperObjLst_Cache = await vcc_CourseExamPaper_GetObjLst_sessionStorage(strCourseId);
break;
case "03"://localStorage
arrvcc_CourseExamPaperObjLst_Cache = await vcc_CourseExamPaper_GetObjLst_localStorage(strCourseId);
break;
case "02"://ClientCache
arrvcc_CourseExamPaperObjLst_Cache = await vcc_CourseExamPaper_GetObjLst_ClientCache(strCourseId);
break;
default:
arrvcc_CourseExamPaperObjLst_Cache = await vcc_CourseExamPaper_GetObjLst_ClientCache(strCourseId);
break;
}
const arrvcc_CourseExamPaperObjLst = vcc_CourseExamPaper_GetObjLstByJSONObjLst(arrvcc_CourseExamPaperObjLst_Cache);
return arrvcc_CourseExamPaperObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vcc_CourseExamPaper_GetObjLst_PureCache(strCourseId: string)
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrvcc_CourseExamPaperObjLst_Cache;
switch (clsvcc_CourseExamPaperEN.CacheModeId)
{
case "04"://sessionStorage
arrvcc_CourseExamPaperObjLst_Cache = await vcc_CourseExamPaper_GetObjLst_sessionStorage_PureCache(strCourseId);
break;
case "03"://localStorage
arrvcc_CourseExamPaperObjLst_Cache = await vcc_CourseExamPaper_GetObjLst_localStorage_PureCache(strCourseId);
break;
case "02"://ClientCache
arrvcc_CourseExamPaperObjLst_Cache = null;
break;
default:
arrvcc_CourseExamPaperObjLst_Cache = null;
break;
}
return arrvcc_CourseExamPaperObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrCourseExamPaperId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vcc_CourseExamPaper_GetSubObjLst_Cache(objvcc_CourseExamPaper_Cond: clsvcc_CourseExamPaperEN,strCourseId: string) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrvcc_CourseExamPaperObjLst_Cache = await vcc_CourseExamPaper_GetObjLst_Cache(strCourseId);
let arrvcc_CourseExamPaper_Sel: Array < clsvcc_CourseExamPaperEN > = arrvcc_CourseExamPaperObjLst_Cache;
if (objvcc_CourseExamPaper_Cond.sf_FldComparisonOp == null || objvcc_CourseExamPaper_Cond.sf_FldComparisonOp == "") return arrvcc_CourseExamPaper_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvcc_CourseExamPaper_Cond.sf_FldComparisonOp);
//console.log("clsvcc_CourseExamPaperWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvcc_CourseExamPaper_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvcc_CourseExamPaper_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvcc_CourseExamPaper_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objvcc_CourseExamPaper_Cond), vcc_CourseExamPaper_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvcc_CourseExamPaperEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrCourseExamPaperId:关键字列表
 * @returns 对象列表
 **/
export async function vcc_CourseExamPaper_GetObjLstByCourseExamPaperIdLstAsync(arrCourseExamPaperId: Array<string>): Promise<Array<clsvcc_CourseExamPaperEN>>  
{
const strThisFuncName = "GetObjLstByCourseExamPaperIdLstAsync";
const strAction = "GetObjLstByCourseExamPaperIdLst";
const strUrl = GetWebApiUrl(vcc_CourseExamPaper_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrCourseExamPaperId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vcc_CourseExamPaper_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vcc_CourseExamPaper_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_CourseExamPaper_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_CourseExamPaper_ConstructorName, strThisFuncName);
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
 * @param arrstrCourseExamPaperIdLst:关键字列表
 * @returns 对象列表
*/
export async function vcc_CourseExamPaper_GetObjLstByCourseExamPaperIdLst_Cache(arrCourseExamPaperIdLst: Array<string>,strCourseId: string) {
const strThisFuncName = "GetObjLstByCourseExamPaperIdLst_Cache";
try
{
const arrvcc_CourseExamPaperObjLst_Cache = await vcc_CourseExamPaper_GetObjLst_Cache(strCourseId);
const arrvcc_CourseExamPaper_Sel: Array <clsvcc_CourseExamPaperEN> = arrvcc_CourseExamPaperObjLst_Cache.filter(x => arrCourseExamPaperIdLst.indexOf(x.courseExamPaperId)>-1);
return arrvcc_CourseExamPaper_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrCourseExamPaperIdLst.join(","), vcc_CourseExamPaper_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvcc_CourseExamPaperEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function vcc_CourseExamPaper_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsvcc_CourseExamPaperEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(vcc_CourseExamPaper_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vcc_CourseExamPaper_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vcc_CourseExamPaper_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_CourseExamPaper_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_CourseExamPaper_ConstructorName, strThisFuncName);
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
export async function vcc_CourseExamPaper_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsvcc_CourseExamPaperEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vcc_CourseExamPaper_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vcc_CourseExamPaper_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vcc_CourseExamPaper_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_CourseExamPaper_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_CourseExamPaper_ConstructorName, strThisFuncName);
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
export async function vcc_CourseExamPaper_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vcc_CourseExamPaper_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_CourseExamPaper_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_CourseExamPaper_ConstructorName, strThisFuncName);
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
export async function vcc_CourseExamPaper_GetObjLstByPager_Cache(objPagerPara: stuPagerPara,strCourseId: string) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrvcc_CourseExamPaperObjLst_Cache = await vcc_CourseExamPaper_GetObjLst_Cache(strCourseId);
if (arrvcc_CourseExamPaperObjLst_Cache.length == 0) return arrvcc_CourseExamPaperObjLst_Cache;
let arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaperObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objvcc_CourseExamPaper_Cond = new clsvcc_CourseExamPaperEN();
ObjectAssign(objvcc_CourseExamPaper_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsvcc_CourseExamPaperWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvcc_CourseExamPaper_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvcc_CourseExamPaper_Sel.length == 0) return arrvcc_CourseExamPaper_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.sort(vcc_CourseExamPaper_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.sort(objPagerPara.sortFun);
}
arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.slice(intStart, intEnd);     
return arrvcc_CourseExamPaper_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, vcc_CourseExamPaper_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvcc_CourseExamPaperEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function vcc_CourseExamPaper_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsvcc_CourseExamPaperEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(vcc_CourseExamPaper_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vcc_CourseExamPaper_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vcc_CourseExamPaper_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_CourseExamPaper_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_CourseExamPaper_ConstructorName, strThisFuncName);
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
 * @param objstrCourseExamPaperId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vcc_CourseExamPaper_IsExistRecord_Cache(objvcc_CourseExamPaper_Cond: clsvcc_CourseExamPaperEN,strCourseId: string) {
const strThisFuncName = "IsExistRecord_Cache";
const arrvcc_CourseExamPaperObjLst_Cache = await vcc_CourseExamPaper_GetObjLst_Cache(strCourseId);
if (arrvcc_CourseExamPaperObjLst_Cache == null) return false;
let arrvcc_CourseExamPaper_Sel: Array < clsvcc_CourseExamPaperEN > = arrvcc_CourseExamPaperObjLst_Cache;
if (objvcc_CourseExamPaper_Cond.sf_FldComparisonOp == null || objvcc_CourseExamPaper_Cond.sf_FldComparisonOp == "") return arrvcc_CourseExamPaper_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvcc_CourseExamPaper_Cond.sf_FldComparisonOp);
//console.log("clsvcc_CourseExamPaperWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvcc_CourseExamPaper_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvcc_CourseExamPaper_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvcc_CourseExamPaper_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objvcc_CourseExamPaper_Cond), vcc_CourseExamPaper_ConstructorName, strThisFuncName);
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
export async function vcc_CourseExamPaper_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(vcc_CourseExamPaper_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_CourseExamPaper_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_CourseExamPaper_ConstructorName, strThisFuncName);
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
 * @param strCourseExamPaperId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function vcc_CourseExamPaper_IsExist(strCourseExamPaperId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vcc_CourseExamPaper_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"CourseExamPaperId": strCourseExamPaperId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_CourseExamPaper_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_CourseExamPaper_ConstructorName, strThisFuncName);
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
 * @param strCourseExamPaperId:所给的关键字
 * @returns 对象
*/
export async function vcc_CourseExamPaper_IsExist_Cache(strCourseExamPaperId:string,strCourseId:string) {
const strThisFuncName = "IsExist_Cache";
const arrvcc_CourseExamPaperObjLst_Cache = await vcc_CourseExamPaper_GetObjLst_Cache(strCourseId);
if (arrvcc_CourseExamPaperObjLst_Cache == null) return false;
try
{
const arrvcc_CourseExamPaper_Sel: Array <clsvcc_CourseExamPaperEN> = arrvcc_CourseExamPaperObjLst_Cache.filter(x => x.courseExamPaperId == strCourseExamPaperId);
if (arrvcc_CourseExamPaper_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strCourseExamPaperId, vcc_CourseExamPaper_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param strCourseExamPaperId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function vcc_CourseExamPaper_IsExistAsync(strCourseExamPaperId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vcc_CourseExamPaper_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strCourseExamPaperId": strCourseExamPaperId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_CourseExamPaper_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_CourseExamPaper_ConstructorName, strThisFuncName);
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
export async function vcc_CourseExamPaper_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(vcc_CourseExamPaper_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_CourseExamPaper_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_CourseExamPaper_ConstructorName, strThisFuncName);
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
 * @param objvcc_CourseExamPaper_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function vcc_CourseExamPaper_GetRecCountByCond_Cache(objvcc_CourseExamPaper_Cond: clsvcc_CourseExamPaperEN,strCourseId: string) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrvcc_CourseExamPaperObjLst_Cache = await vcc_CourseExamPaper_GetObjLst_Cache(strCourseId);
if (arrvcc_CourseExamPaperObjLst_Cache == null) return 0;
let arrvcc_CourseExamPaper_Sel: Array < clsvcc_CourseExamPaperEN > = arrvcc_CourseExamPaperObjLst_Cache;
if (objvcc_CourseExamPaper_Cond.sf_FldComparisonOp == null || objvcc_CourseExamPaper_Cond.sf_FldComparisonOp == "") return arrvcc_CourseExamPaper_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvcc_CourseExamPaper_Cond.sf_FldComparisonOp);
//console.log("clsvcc_CourseExamPaperWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvcc_CourseExamPaper_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvcc_CourseExamPaper_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvcc_CourseExamPaper_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objvcc_CourseExamPaper_Cond), vcc_CourseExamPaper_ConstructorName, strThisFuncName);
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
export function vcc_CourseExamPaper_GetWebApiUrl(strController: string, strAction: string): string {
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
export function vcc_CourseExamPaper_ReFreshThisCache(strCourseId: string):void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = Format("{0}_{1}", clsvcc_CourseExamPaperEN._CurrTabName, strCourseId);
switch (clsvcc_CourseExamPaperEN.CacheModeId)
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
export function vcc_CourseExamPaper_GetJSONStrByObj (pobjvcc_CourseExamPaperEN: clsvcc_CourseExamPaperEN): string
{
const strThisFuncName = "GetJSONStrByObj";
let strJson = "";
try
{
strJson = JSON.stringify(pobjvcc_CourseExamPaperEN);
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
export function vcc_CourseExamPaper_GetObjLstByJSONStr (strJSON: string): Array<clsvcc_CourseExamPaperEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrvcc_CourseExamPaperObjLst = new Array<clsvcc_CourseExamPaperEN>();
if (strJSON === "")
{
return arrvcc_CourseExamPaperObjLst;
}
try
{
arrvcc_CourseExamPaperObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvcc_CourseExamPaperObjLst;
}
return arrvcc_CourseExamPaperObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrvcc_CourseExamPaperObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function vcc_CourseExamPaper_GetObjLstByJSONObjLst (arrvcc_CourseExamPaperObjLstS: Array<clsvcc_CourseExamPaperEN>): Array<clsvcc_CourseExamPaperEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrvcc_CourseExamPaperObjLst = new Array<clsvcc_CourseExamPaperEN>();
for (const objInFor of arrvcc_CourseExamPaperObjLstS) {
const obj1 = vcc_CourseExamPaper_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrvcc_CourseExamPaperObjLst.push(obj1);
}
return arrvcc_CourseExamPaperObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vcc_CourseExamPaper_GetObjByJSONStr (strJSON: string): clsvcc_CourseExamPaperEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjvcc_CourseExamPaperEN = new clsvcc_CourseExamPaperEN();
if (strJSON === "")
{
return pobjvcc_CourseExamPaperEN;
}
try
{
pobjvcc_CourseExamPaperEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvcc_CourseExamPaperEN;
}
return pobjvcc_CourseExamPaperEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function vcc_CourseExamPaper_GetCombineCondition(objvcc_CourseExamPaper_Cond: clsvcc_CourseExamPaperEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN.con_CourseExamPaperId) == true)
{
const strComparisonOp_CourseExamPaperId:string = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN.con_CourseExamPaperId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseExamPaperEN.con_CourseExamPaperId, objvcc_CourseExamPaper_Cond.courseExamPaperId, strComparisonOp_CourseExamPaperId);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN.con_CourseId) == true)
{
const strComparisonOp_CourseId:string = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN.con_CourseId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseExamPaperEN.con_CourseId, objvcc_CourseExamPaper_Cond.courseId, strComparisonOp_CourseId);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN.con_CourseName) == true)
{
const strComparisonOp_CourseName:string = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN.con_CourseName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseExamPaperEN.con_CourseName, objvcc_CourseExamPaper_Cond.courseName, strComparisonOp_CourseName);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN.con_ExamPaperName) == true)
{
const strComparisonOp_ExamPaperName:string = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN.con_ExamPaperName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseExamPaperEN.con_ExamPaperName, objvcc_CourseExamPaper_Cond.examPaperName, strComparisonOp_ExamPaperName);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN.con_PaperIndex) == true)
{
const strComparisonOp_PaperIndex:string = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN.con_PaperIndex];
strWhereCond += Format(" And {0} {2} {1}", clsvcc_CourseExamPaperEN.con_PaperIndex, objvcc_CourseExamPaper_Cond.paperIndex, strComparisonOp_PaperIndex);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN.con_ExamPaperTypeId) == true)
{
const strComparisonOp_ExamPaperTypeId:string = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN.con_ExamPaperTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseExamPaperEN.con_ExamPaperTypeId, objvcc_CourseExamPaper_Cond.examPaperTypeId, strComparisonOp_ExamPaperTypeId);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN.con_ExamPaperTypeName) == true)
{
const strComparisonOp_ExamPaperTypeName:string = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN.con_ExamPaperTypeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseExamPaperEN.con_ExamPaperTypeName, objvcc_CourseExamPaper_Cond.examPaperTypeName, strComparisonOp_ExamPaperTypeName);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN.con_IsShow) == true)
{
if (objvcc_CourseExamPaper_Cond.isShow == true)
{
strWhereCond += Format(" And {0} = '1'", clsvcc_CourseExamPaperEN.con_IsShow);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvcc_CourseExamPaperEN.con_IsShow);
}
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN.con_TotalScore) == true)
{
const strComparisonOp_TotalScore:string = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN.con_TotalScore];
strWhereCond += Format(" And {0} {2} {1}", clsvcc_CourseExamPaperEN.con_TotalScore, objvcc_CourseExamPaper_Cond.totalScore, strComparisonOp_TotalScore);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN.con_ViewCount) == true)
{
const strComparisonOp_ViewCount:string = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN.con_ViewCount];
strWhereCond += Format(" And {0} {2} {1}", clsvcc_CourseExamPaperEN.con_ViewCount, objvcc_CourseExamPaper_Cond.viewCount, strComparisonOp_ViewCount);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN.con_DoneNumber) == true)
{
const strComparisonOp_DoneNumber:string = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN.con_DoneNumber];
strWhereCond += Format(" And {0} {2} {1}", clsvcc_CourseExamPaperEN.con_DoneNumber, objvcc_CourseExamPaper_Cond.doneNumber, strComparisonOp_DoneNumber);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN.con_PaperTime) == true)
{
const strComparisonOp_PaperTime:string = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN.con_PaperTime];
strWhereCond += Format(" And {0} {2} {1}", clsvcc_CourseExamPaperEN.con_PaperTime, objvcc_CourseExamPaper_Cond.paperTime, strComparisonOp_PaperTime);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN.con_DownloadNumber) == true)
{
const strComparisonOp_DownloadNumber:string = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN.con_DownloadNumber];
strWhereCond += Format(" And {0} {2} {1}", clsvcc_CourseExamPaperEN.con_DownloadNumber, objvcc_CourseExamPaper_Cond.downloadNumber, strComparisonOp_DownloadNumber);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN.con_CollectionCount) == true)
{
const strComparisonOp_CollectionCount:string = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN.con_CollectionCount];
strWhereCond += Format(" And {0} {2} {1}", clsvcc_CourseExamPaperEN.con_CollectionCount, objvcc_CourseExamPaper_Cond.collectionCount, strComparisonOp_CollectionCount);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN.con_LikeCount) == true)
{
const strComparisonOp_LikeCount:string = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN.con_LikeCount];
strWhereCond += Format(" And {0} {2} {1}", clsvcc_CourseExamPaperEN.con_LikeCount, objvcc_CourseExamPaper_Cond.likeCount, strComparisonOp_LikeCount);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN.con_id_XzMajor) == true)
{
const strComparisonOp_id_XzMajor:string = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN.con_id_XzMajor];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseExamPaperEN.con_id_XzMajor, objvcc_CourseExamPaper_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN.con_MajorName) == true)
{
const strComparisonOp_MajorName:string = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN.con_MajorName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseExamPaperEN.con_MajorName, objvcc_CourseExamPaper_Cond.majorName, strComparisonOp_MajorName);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN.con_PaperDispModeId) == true)
{
const strComparisonOp_PaperDispModeId:string = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN.con_PaperDispModeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseExamPaperEN.con_PaperDispModeId, objvcc_CourseExamPaper_Cond.paperDispModeId, strComparisonOp_PaperDispModeId);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN.con_PaperDispModeName) == true)
{
const strComparisonOp_PaperDispModeName:string = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN.con_PaperDispModeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseExamPaperEN.con_PaperDispModeName, objvcc_CourseExamPaper_Cond.paperDispModeName, strComparisonOp_PaperDispModeName);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN.con_ExamCreateTime) == true)
{
const strComparisonOp_ExamCreateTime:string = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN.con_ExamCreateTime];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseExamPaperEN.con_ExamCreateTime, objvcc_CourseExamPaper_Cond.examCreateTime, strComparisonOp_ExamCreateTime);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN.con_CreateUserID) == true)
{
const strComparisonOp_CreateUserID:string = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN.con_CreateUserID];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseExamPaperEN.con_CreateUserID, objvcc_CourseExamPaper_Cond.createUserID, strComparisonOp_CreateUserID);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN.con_UserName) == true)
{
const strComparisonOp_UserName:string = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN.con_UserName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseExamPaperEN.con_UserName, objvcc_CourseExamPaper_Cond.userName, strComparisonOp_UserName);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN.con_IsOpenToAllStu) == true)
{
if (objvcc_CourseExamPaper_Cond.isOpenToAllStu == true)
{
strWhereCond += Format(" And {0} = '1'", clsvcc_CourseExamPaperEN.con_IsOpenToAllStu);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvcc_CourseExamPaperEN.con_IsOpenToAllStu);
}
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN.con_IsOpenToSchool) == true)
{
if (objvcc_CourseExamPaper_Cond.isOpenToSchool == true)
{
strWhereCond += Format(" And {0} = '1'", clsvcc_CourseExamPaperEN.con_IsOpenToSchool);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvcc_CourseExamPaperEN.con_IsOpenToSchool);
}
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN.con_IsOpenToSocial) == true)
{
if (objvcc_CourseExamPaper_Cond.isOpenToSocial == true)
{
strWhereCond += Format(" And {0} = '1'", clsvcc_CourseExamPaperEN.con_IsOpenToSocial);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvcc_CourseExamPaperEN.con_IsOpenToSocial);
}
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN.con_CourseChapterId) == true)
{
const strComparisonOp_CourseChapterId:string = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN.con_CourseChapterId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseExamPaperEN.con_CourseChapterId, objvcc_CourseExamPaper_Cond.courseChapterId, strComparisonOp_CourseChapterId);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN.con_CourseChapterName) == true)
{
const strComparisonOp_CourseChapterName:string = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN.con_CourseChapterName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseExamPaperEN.con_CourseChapterName, objvcc_CourseExamPaper_Cond.courseChapterName, strComparisonOp_CourseChapterName);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN.con_ChapterId) == true)
{
const strComparisonOp_ChapterId:string = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN.con_ChapterId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseExamPaperEN.con_ChapterId, objvcc_CourseExamPaper_Cond.chapterId, strComparisonOp_ChapterId);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN.con_SectionId) == true)
{
const strComparisonOp_SectionId:string = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN.con_SectionId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseExamPaperEN.con_SectionId, objvcc_CourseExamPaper_Cond.sectionId, strComparisonOp_SectionId);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN.con_ChapterName) == true)
{
const strComparisonOp_ChapterName:string = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN.con_ChapterName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseExamPaperEN.con_ChapterName, objvcc_CourseExamPaper_Cond.chapterName, strComparisonOp_ChapterName);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN.con_SectionName) == true)
{
const strComparisonOp_SectionName:string = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN.con_SectionName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseExamPaperEN.con_SectionName, objvcc_CourseExamPaper_Cond.sectionName, strComparisonOp_SectionName);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN.con_ChapterName_Sim) == true)
{
const strComparisonOp_ChapterName_Sim:string = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN.con_ChapterName_Sim];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseExamPaperEN.con_ChapterName_Sim, objvcc_CourseExamPaper_Cond.chapterName_Sim, strComparisonOp_ChapterName_Sim);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN.con_SectionName_Sim) == true)
{
const strComparisonOp_SectionName_Sim:string = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN.con_SectionName_Sim];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseExamPaperEN.con_SectionName_Sim, objvcc_CourseExamPaper_Cond.sectionName_Sim, strComparisonOp_SectionName_Sim);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN.con_IsAutoGeneQuestion) == true)
{
if (objvcc_CourseExamPaper_Cond.isAutoGeneQuestion == true)
{
strWhereCond += Format(" And {0} = '1'", clsvcc_CourseExamPaperEN.con_IsAutoGeneQuestion);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvcc_CourseExamPaperEN.con_IsAutoGeneQuestion);
}
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN.con_IsCanMultiDo) == true)
{
if (objvcc_CourseExamPaper_Cond.isCanMultiDo == true)
{
strWhereCond += Format(" And {0} = '1'", clsvcc_CourseExamPaperEN.con_IsCanMultiDo);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvcc_CourseExamPaperEN.con_IsCanMultiDo);
}
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseExamPaperEN.con_UpdDate, objvcc_CourseExamPaper_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN.con_UpdUserId) == true)
{
const strComparisonOp_UpdUserId:string = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN.con_UpdUserId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseExamPaperEN.con_UpdUserId, objvcc_CourseExamPaper_Cond.updUserId, strComparisonOp_UpdUserId);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseExamPaperEN.con_Memo, objvcc_CourseExamPaper_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN.con_QuestionNum) == true)
{
const strComparisonOp_QuestionNum:string = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN.con_QuestionNum];
strWhereCond += Format(" And {0} {2} {1}", clsvcc_CourseExamPaperEN.con_QuestionNum, objvcc_CourseExamPaper_Cond.questionNum, strComparisonOp_QuestionNum);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN.con_BigTopicNum) == true)
{
const strComparisonOp_BigTopicNum:string = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN.con_BigTopicNum];
strWhereCond += Format(" And {0} {2} {1}", clsvcc_CourseExamPaperEN.con_BigTopicNum, objvcc_CourseExamPaper_Cond.bigTopicNum, strComparisonOp_BigTopicNum);
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objvcc_CourseExamPaperENS:源对象
 * @param objvcc_CourseExamPaperENT:目标对象
*/
export function vcc_CourseExamPaper_CopyObjTo(objvcc_CourseExamPaperENS: clsvcc_CourseExamPaperEN , objvcc_CourseExamPaperENT: clsvcc_CourseExamPaperEN ): void 
{
objvcc_CourseExamPaperENT.courseExamPaperId = objvcc_CourseExamPaperENS.courseExamPaperId; //考卷流水号
objvcc_CourseExamPaperENT.courseId = objvcc_CourseExamPaperENS.courseId; //课程Id
objvcc_CourseExamPaperENT.courseName = objvcc_CourseExamPaperENS.courseName; //课程名称
objvcc_CourseExamPaperENT.examPaperName = objvcc_CourseExamPaperENS.examPaperName; //考卷名称
objvcc_CourseExamPaperENT.paperIndex = objvcc_CourseExamPaperENS.paperIndex; //试卷序号
objvcc_CourseExamPaperENT.examPaperTypeId = objvcc_CourseExamPaperENS.examPaperTypeId; //试卷类型Id
objvcc_CourseExamPaperENT.examPaperTypeName = objvcc_CourseExamPaperENS.examPaperTypeName; //试卷类型名称
objvcc_CourseExamPaperENT.isShow = objvcc_CourseExamPaperENS.isShow; //是否启用
objvcc_CourseExamPaperENT.totalScore = objvcc_CourseExamPaperENS.totalScore; //总得分
objvcc_CourseExamPaperENT.viewCount = objvcc_CourseExamPaperENS.viewCount; //浏览量
objvcc_CourseExamPaperENT.doneNumber = objvcc_CourseExamPaperENS.doneNumber; //已做人数
objvcc_CourseExamPaperENT.paperTime = objvcc_CourseExamPaperENS.paperTime; //考试时间（分钟）
objvcc_CourseExamPaperENT.downloadNumber = objvcc_CourseExamPaperENS.downloadNumber; //下载数目
objvcc_CourseExamPaperENT.collectionCount = objvcc_CourseExamPaperENS.collectionCount; //收藏数量
objvcc_CourseExamPaperENT.likeCount = objvcc_CourseExamPaperENS.likeCount; //资源喜欢数量
objvcc_CourseExamPaperENT.id_XzMajor = objvcc_CourseExamPaperENS.id_XzMajor; //专业流水号
objvcc_CourseExamPaperENT.majorName = objvcc_CourseExamPaperENS.majorName; //专业名称
objvcc_CourseExamPaperENT.paperDispModeId = objvcc_CourseExamPaperENS.paperDispModeId; //试卷显示模式Id
objvcc_CourseExamPaperENT.paperDispModeName = objvcc_CourseExamPaperENS.paperDispModeName; //试卷显示模式名称
objvcc_CourseExamPaperENT.examCreateTime = objvcc_CourseExamPaperENS.examCreateTime; //考卷建立时间
objvcc_CourseExamPaperENT.createUserID = objvcc_CourseExamPaperENS.createUserID; //建立用户ID
objvcc_CourseExamPaperENT.userName = objvcc_CourseExamPaperENS.userName; //用户名
objvcc_CourseExamPaperENT.isOpenToAllStu = objvcc_CourseExamPaperENS.isOpenToAllStu; //全校师生
objvcc_CourseExamPaperENT.isOpenToSchool = objvcc_CourseExamPaperENS.isOpenToSchool; //全校师生公开
objvcc_CourseExamPaperENT.isOpenToSocial = objvcc_CourseExamPaperENS.isOpenToSocial; //社会公众
objvcc_CourseExamPaperENT.courseChapterId = objvcc_CourseExamPaperENS.courseChapterId; //课程章节ID
objvcc_CourseExamPaperENT.courseChapterName = objvcc_CourseExamPaperENS.courseChapterName; //课程章节名称
objvcc_CourseExamPaperENT.chapterId = objvcc_CourseExamPaperENS.chapterId; //章Id
objvcc_CourseExamPaperENT.sectionId = objvcc_CourseExamPaperENS.sectionId; //节Id
objvcc_CourseExamPaperENT.chapterName = objvcc_CourseExamPaperENS.chapterName; //章名
objvcc_CourseExamPaperENT.sectionName = objvcc_CourseExamPaperENS.sectionName; //节名
objvcc_CourseExamPaperENT.chapterName_Sim = objvcc_CourseExamPaperENS.chapterName_Sim; //章名简称
objvcc_CourseExamPaperENT.sectionName_Sim = objvcc_CourseExamPaperENS.sectionName_Sim; //节名简称
objvcc_CourseExamPaperENT.isAutoGeneQuestion = objvcc_CourseExamPaperENS.isAutoGeneQuestion; //是否自动生成题目
objvcc_CourseExamPaperENT.isCanMultiDo = objvcc_CourseExamPaperENS.isCanMultiDo; //是否可以做多次
objvcc_CourseExamPaperENT.updDate = objvcc_CourseExamPaperENS.updDate; //修改日期
objvcc_CourseExamPaperENT.updUserId = objvcc_CourseExamPaperENS.updUserId; //修改用户Id
objvcc_CourseExamPaperENT.memo = objvcc_CourseExamPaperENS.memo; //备注
objvcc_CourseExamPaperENT.questionNum = objvcc_CourseExamPaperENS.questionNum; //题目数
objvcc_CourseExamPaperENT.bigTopicNum = objvcc_CourseExamPaperENS.bigTopicNum; //大标题数
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objvcc_CourseExamPaperENS:源对象
 * @param objvcc_CourseExamPaperENT:目标对象
*/
export function vcc_CourseExamPaper_GetObjFromJsonObj(objvcc_CourseExamPaperENS: clsvcc_CourseExamPaperEN): clsvcc_CourseExamPaperEN 
{
 const objvcc_CourseExamPaperENT: clsvcc_CourseExamPaperEN = new clsvcc_CourseExamPaperEN();
ObjectAssign(objvcc_CourseExamPaperENT, objvcc_CourseExamPaperENS);
 return objvcc_CourseExamPaperENT;
}