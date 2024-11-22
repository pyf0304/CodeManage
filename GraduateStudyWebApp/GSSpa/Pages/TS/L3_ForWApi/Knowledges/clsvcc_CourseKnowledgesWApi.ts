
 /**
 * 类名:clsvcc_CourseKnowledgesWApi
 * 表名:vcc_CourseKnowledges(01120141)
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
 * v课程知识点(vcc_CourseKnowledges)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { clsvcc_CourseKnowledgesEN } from "../../L0_Entity/Knowledges/clsvcc_CourseKnowledgesEN.js";
import { BindDdl_ObjLstInDiv_V, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const vcc_CourseKnowledges_Controller = "vcc_CourseKnowledgesApi";
 export const vcc_CourseKnowledges_ConstructorName = "vcc_CourseKnowledges";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strCourseKnowledgeId:关键字
 * @returns 对象
 **/
export async function vcc_CourseKnowledges_GetObjByCourseKnowledgeIdAsync(strCourseKnowledgeId: string): Promise<clsvcc_CourseKnowledgesEN>  
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
const strUrl = GetWebApiUrl(vcc_CourseKnowledges_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vcc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvcc_CourseKnowledges = vcc_CourseKnowledges_GetObjFromJsonObj(returnObj);
return objvcc_CourseKnowledges;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_CourseKnowledges_ConstructorName, strThisFuncName);
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
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
 * @param a:比较的第1个对象
 * @param  b:比较的第1个对象
 * @returns 返回两个对象比较的结果
*/
export function vcc_CourseKnowledges_SortFun_Defa(a:clsvcc_CourseKnowledgesEN , b:clsvcc_CourseKnowledgesEN): number 
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
export function vcc_CourseKnowledges_SortFun_Defa_2Fld(a:clsvcc_CourseKnowledgesEN , b:clsvcc_CourseKnowledgesEN): number 
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
export function vcc_CourseKnowledges_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsvcc_CourseKnowledgesEN.con_CourseKnowledgeId:
return (a: clsvcc_CourseKnowledgesEN, b: clsvcc_CourseKnowledgesEN) => {
return a.courseKnowledgeId.localeCompare(b.courseKnowledgeId);
}
case clsvcc_CourseKnowledgesEN.con_KnowledgeName:
return (a: clsvcc_CourseKnowledgesEN, b: clsvcc_CourseKnowledgesEN) => {
return a.knowledgeName.localeCompare(b.knowledgeName);
}
case clsvcc_CourseKnowledgesEN.con_KnowledgeTitle:
return (a: clsvcc_CourseKnowledgesEN, b: clsvcc_CourseKnowledgesEN) => {
return a.knowledgeTitle.localeCompare(b.knowledgeTitle);
}
case clsvcc_CourseKnowledgesEN.con_KnowledgeContent:
return (a: clsvcc_CourseKnowledgesEN, b: clsvcc_CourseKnowledgesEN) => {
return a.knowledgeContent.localeCompare(b.knowledgeContent);
}
case clsvcc_CourseKnowledgesEN.con_CourseId:
return (a: clsvcc_CourseKnowledgesEN, b: clsvcc_CourseKnowledgesEN) => {
return a.courseId.localeCompare(b.courseId);
}
case clsvcc_CourseKnowledgesEN.con_CourseCode:
return (a: clsvcc_CourseKnowledgesEN, b: clsvcc_CourseKnowledgesEN) => {
return a.courseCode.localeCompare(b.courseCode);
}
case clsvcc_CourseKnowledgesEN.con_CourseName:
return (a: clsvcc_CourseKnowledgesEN, b: clsvcc_CourseKnowledgesEN) => {
return a.courseName.localeCompare(b.courseName);
}
case clsvcc_CourseKnowledgesEN.con_CourseChapterId:
return (a: clsvcc_CourseKnowledgesEN, b: clsvcc_CourseKnowledgesEN) => {
return a.courseChapterId.localeCompare(b.courseChapterId);
}
case clsvcc_CourseKnowledgesEN.con_UserId:
return (a: clsvcc_CourseKnowledgesEN, b: clsvcc_CourseKnowledgesEN) => {
return a.userId.localeCompare(b.userId);
}
case clsvcc_CourseKnowledgesEN.con_ChapterId:
return (a: clsvcc_CourseKnowledgesEN, b: clsvcc_CourseKnowledgesEN) => {
return a.chapterId.localeCompare(b.chapterId);
}
case clsvcc_CourseKnowledgesEN.con_UploadDate:
return (a: clsvcc_CourseKnowledgesEN, b: clsvcc_CourseKnowledgesEN) => {
return a.uploadDate.localeCompare(b.uploadDate);
}
case clsvcc_CourseKnowledgesEN.con_SectionId:
return (a: clsvcc_CourseKnowledgesEN, b: clsvcc_CourseKnowledgesEN) => {
return a.sectionId.localeCompare(b.sectionId);
}
case clsvcc_CourseKnowledgesEN.con_IsShow:
return (a: clsvcc_CourseKnowledgesEN, b: clsvcc_CourseKnowledgesEN) => {
if (a.isShow == true) return 1;
else return -1
}
case clsvcc_CourseKnowledgesEN.con_ChapterName:
return (a: clsvcc_CourseKnowledgesEN, b: clsvcc_CourseKnowledgesEN) => {
return a.chapterName.localeCompare(b.chapterName);
}
case clsvcc_CourseKnowledgesEN.con_IsCast:
return (a: clsvcc_CourseKnowledgesEN, b: clsvcc_CourseKnowledgesEN) => {
if (a.isCast == true) return 1;
else return -1
}
case clsvcc_CourseKnowledgesEN.con_SectionName:
return (a: clsvcc_CourseKnowledgesEN, b: clsvcc_CourseKnowledgesEN) => {
return a.sectionName.localeCompare(b.sectionName);
}
case clsvcc_CourseKnowledgesEN.con_LikeCount:
return (a: clsvcc_CourseKnowledgesEN, b: clsvcc_CourseKnowledgesEN) => {
return a.likeCount-b.likeCount;
}
case clsvcc_CourseKnowledgesEN.con_ChapterName_Sim:
return (a: clsvcc_CourseKnowledgesEN, b: clsvcc_CourseKnowledgesEN) => {
return a.chapterName_Sim.localeCompare(b.chapterName_Sim);
}
case clsvcc_CourseKnowledgesEN.con_UpdDate:
return (a: clsvcc_CourseKnowledgesEN, b: clsvcc_CourseKnowledgesEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsvcc_CourseKnowledgesEN.con_SectionName_Sim:
return (a: clsvcc_CourseKnowledgesEN, b: clsvcc_CourseKnowledgesEN) => {
return a.sectionName_Sim.localeCompare(b.sectionName_Sim);
}
case clsvcc_CourseKnowledgesEN.con_Memo:
return (a: clsvcc_CourseKnowledgesEN, b: clsvcc_CourseKnowledgesEN) => {
return a.memo.localeCompare(b.memo);
}
case clsvcc_CourseKnowledgesEN.con_QuestionNum:
return (a: clsvcc_CourseKnowledgesEN, b: clsvcc_CourseKnowledgesEN) => {
return a.questionNum-b.questionNum;
}
case clsvcc_CourseKnowledgesEN.con_OrderNum:
return (a: clsvcc_CourseKnowledgesEN, b: clsvcc_CourseKnowledgesEN) => {
return a.orderNum-b.orderNum;
}
case clsvcc_CourseKnowledgesEN.con_UpdUser:
return (a: clsvcc_CourseKnowledgesEN, b: clsvcc_CourseKnowledgesEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsvcc_CourseKnowledgesEN.con_KnowledgeTypeId:
return (a: clsvcc_CourseKnowledgesEN, b: clsvcc_CourseKnowledgesEN) => {
return a.knowledgeTypeId.localeCompare(b.knowledgeTypeId);
}
case clsvcc_CourseKnowledgesEN.con_KnowledgeTypeName:
return (a: clsvcc_CourseKnowledgesEN, b: clsvcc_CourseKnowledgesEN) => {
return a.knowledgeTypeName.localeCompare(b.knowledgeTypeName);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vcc_CourseKnowledges]中不存在！(in ${ vcc_CourseKnowledges_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsvcc_CourseKnowledgesEN.con_CourseKnowledgeId:
return (a: clsvcc_CourseKnowledgesEN, b: clsvcc_CourseKnowledgesEN) => {
return b.courseKnowledgeId.localeCompare(a.courseKnowledgeId);
}
case clsvcc_CourseKnowledgesEN.con_KnowledgeName:
return (a: clsvcc_CourseKnowledgesEN, b: clsvcc_CourseKnowledgesEN) => {
return b.knowledgeName.localeCompare(a.knowledgeName);
}
case clsvcc_CourseKnowledgesEN.con_KnowledgeTitle:
return (a: clsvcc_CourseKnowledgesEN, b: clsvcc_CourseKnowledgesEN) => {
return b.knowledgeTitle.localeCompare(a.knowledgeTitle);
}
case clsvcc_CourseKnowledgesEN.con_KnowledgeContent:
return (a: clsvcc_CourseKnowledgesEN, b: clsvcc_CourseKnowledgesEN) => {
return b.knowledgeContent.localeCompare(a.knowledgeContent);
}
case clsvcc_CourseKnowledgesEN.con_CourseId:
return (a: clsvcc_CourseKnowledgesEN, b: clsvcc_CourseKnowledgesEN) => {
return b.courseId.localeCompare(a.courseId);
}
case clsvcc_CourseKnowledgesEN.con_CourseCode:
return (a: clsvcc_CourseKnowledgesEN, b: clsvcc_CourseKnowledgesEN) => {
return b.courseCode.localeCompare(a.courseCode);
}
case clsvcc_CourseKnowledgesEN.con_CourseName:
return (a: clsvcc_CourseKnowledgesEN, b: clsvcc_CourseKnowledgesEN) => {
return b.courseName.localeCompare(a.courseName);
}
case clsvcc_CourseKnowledgesEN.con_CourseChapterId:
return (a: clsvcc_CourseKnowledgesEN, b: clsvcc_CourseKnowledgesEN) => {
return b.courseChapterId.localeCompare(a.courseChapterId);
}
case clsvcc_CourseKnowledgesEN.con_UserId:
return (a: clsvcc_CourseKnowledgesEN, b: clsvcc_CourseKnowledgesEN) => {
return b.userId.localeCompare(a.userId);
}
case clsvcc_CourseKnowledgesEN.con_ChapterId:
return (a: clsvcc_CourseKnowledgesEN, b: clsvcc_CourseKnowledgesEN) => {
return b.chapterId.localeCompare(a.chapterId);
}
case clsvcc_CourseKnowledgesEN.con_UploadDate:
return (a: clsvcc_CourseKnowledgesEN, b: clsvcc_CourseKnowledgesEN) => {
return b.uploadDate.localeCompare(a.uploadDate);
}
case clsvcc_CourseKnowledgesEN.con_SectionId:
return (a: clsvcc_CourseKnowledgesEN, b: clsvcc_CourseKnowledgesEN) => {
return b.sectionId.localeCompare(a.sectionId);
}
case clsvcc_CourseKnowledgesEN.con_IsShow:
return (a: clsvcc_CourseKnowledgesEN, b: clsvcc_CourseKnowledgesEN) => {
if (b.isShow == true) return 1;
else return -1
}
case clsvcc_CourseKnowledgesEN.con_ChapterName:
return (a: clsvcc_CourseKnowledgesEN, b: clsvcc_CourseKnowledgesEN) => {
return b.chapterName.localeCompare(a.chapterName);
}
case clsvcc_CourseKnowledgesEN.con_IsCast:
return (a: clsvcc_CourseKnowledgesEN, b: clsvcc_CourseKnowledgesEN) => {
if (b.isCast == true) return 1;
else return -1
}
case clsvcc_CourseKnowledgesEN.con_SectionName:
return (a: clsvcc_CourseKnowledgesEN, b: clsvcc_CourseKnowledgesEN) => {
return b.sectionName.localeCompare(a.sectionName);
}
case clsvcc_CourseKnowledgesEN.con_LikeCount:
return (a: clsvcc_CourseKnowledgesEN, b: clsvcc_CourseKnowledgesEN) => {
return b.likeCount-a.likeCount;
}
case clsvcc_CourseKnowledgesEN.con_ChapterName_Sim:
return (a: clsvcc_CourseKnowledgesEN, b: clsvcc_CourseKnowledgesEN) => {
return b.chapterName_Sim.localeCompare(a.chapterName_Sim);
}
case clsvcc_CourseKnowledgesEN.con_UpdDate:
return (a: clsvcc_CourseKnowledgesEN, b: clsvcc_CourseKnowledgesEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsvcc_CourseKnowledgesEN.con_SectionName_Sim:
return (a: clsvcc_CourseKnowledgesEN, b: clsvcc_CourseKnowledgesEN) => {
return b.sectionName_Sim.localeCompare(a.sectionName_Sim);
}
case clsvcc_CourseKnowledgesEN.con_Memo:
return (a: clsvcc_CourseKnowledgesEN, b: clsvcc_CourseKnowledgesEN) => {
return b.memo.localeCompare(a.memo);
}
case clsvcc_CourseKnowledgesEN.con_QuestionNum:
return (a: clsvcc_CourseKnowledgesEN, b: clsvcc_CourseKnowledgesEN) => {
return b.questionNum-a.questionNum;
}
case clsvcc_CourseKnowledgesEN.con_OrderNum:
return (a: clsvcc_CourseKnowledgesEN, b: clsvcc_CourseKnowledgesEN) => {
return b.orderNum-a.orderNum;
}
case clsvcc_CourseKnowledgesEN.con_UpdUser:
return (a: clsvcc_CourseKnowledgesEN, b: clsvcc_CourseKnowledgesEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsvcc_CourseKnowledgesEN.con_KnowledgeTypeId:
return (a: clsvcc_CourseKnowledgesEN, b: clsvcc_CourseKnowledgesEN) => {
return b.knowledgeTypeId.localeCompare(a.knowledgeTypeId);
}
case clsvcc_CourseKnowledgesEN.con_KnowledgeTypeName:
return (a: clsvcc_CourseKnowledgesEN, b: clsvcc_CourseKnowledgesEN) => {
return b.knowledgeTypeName.localeCompare(a.knowledgeTypeName);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vcc_CourseKnowledges]中不存在！(in ${ vcc_CourseKnowledges_ConstructorName}.${ strThisFuncName})`;
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
export async function vcc_CourseKnowledges_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsvcc_CourseKnowledgesEN.con_CourseKnowledgeId:
return (obj: clsvcc_CourseKnowledgesEN) => {
return obj.courseKnowledgeId === value;
}
case clsvcc_CourseKnowledgesEN.con_KnowledgeName:
return (obj: clsvcc_CourseKnowledgesEN) => {
return obj.knowledgeName === value;
}
case clsvcc_CourseKnowledgesEN.con_KnowledgeTitle:
return (obj: clsvcc_CourseKnowledgesEN) => {
return obj.knowledgeTitle === value;
}
case clsvcc_CourseKnowledgesEN.con_KnowledgeContent:
return (obj: clsvcc_CourseKnowledgesEN) => {
return obj.knowledgeContent === value;
}
case clsvcc_CourseKnowledgesEN.con_CourseId:
return (obj: clsvcc_CourseKnowledgesEN) => {
return obj.courseId === value;
}
case clsvcc_CourseKnowledgesEN.con_CourseCode:
return (obj: clsvcc_CourseKnowledgesEN) => {
return obj.courseCode === value;
}
case clsvcc_CourseKnowledgesEN.con_CourseName:
return (obj: clsvcc_CourseKnowledgesEN) => {
return obj.courseName === value;
}
case clsvcc_CourseKnowledgesEN.con_CourseChapterId:
return (obj: clsvcc_CourseKnowledgesEN) => {
return obj.courseChapterId === value;
}
case clsvcc_CourseKnowledgesEN.con_UserId:
return (obj: clsvcc_CourseKnowledgesEN) => {
return obj.userId === value;
}
case clsvcc_CourseKnowledgesEN.con_ChapterId:
return (obj: clsvcc_CourseKnowledgesEN) => {
return obj.chapterId === value;
}
case clsvcc_CourseKnowledgesEN.con_UploadDate:
return (obj: clsvcc_CourseKnowledgesEN) => {
return obj.uploadDate === value;
}
case clsvcc_CourseKnowledgesEN.con_SectionId:
return (obj: clsvcc_CourseKnowledgesEN) => {
return obj.sectionId === value;
}
case clsvcc_CourseKnowledgesEN.con_IsShow:
return (obj: clsvcc_CourseKnowledgesEN) => {
return obj.isShow === value;
}
case clsvcc_CourseKnowledgesEN.con_ChapterName:
return (obj: clsvcc_CourseKnowledgesEN) => {
return obj.chapterName === value;
}
case clsvcc_CourseKnowledgesEN.con_IsCast:
return (obj: clsvcc_CourseKnowledgesEN) => {
return obj.isCast === value;
}
case clsvcc_CourseKnowledgesEN.con_SectionName:
return (obj: clsvcc_CourseKnowledgesEN) => {
return obj.sectionName === value;
}
case clsvcc_CourseKnowledgesEN.con_LikeCount:
return (obj: clsvcc_CourseKnowledgesEN) => {
return obj.likeCount === value;
}
case clsvcc_CourseKnowledgesEN.con_ChapterName_Sim:
return (obj: clsvcc_CourseKnowledgesEN) => {
return obj.chapterName_Sim === value;
}
case clsvcc_CourseKnowledgesEN.con_UpdDate:
return (obj: clsvcc_CourseKnowledgesEN) => {
return obj.updDate === value;
}
case clsvcc_CourseKnowledgesEN.con_SectionName_Sim:
return (obj: clsvcc_CourseKnowledgesEN) => {
return obj.sectionName_Sim === value;
}
case clsvcc_CourseKnowledgesEN.con_Memo:
return (obj: clsvcc_CourseKnowledgesEN) => {
return obj.memo === value;
}
case clsvcc_CourseKnowledgesEN.con_QuestionNum:
return (obj: clsvcc_CourseKnowledgesEN) => {
return obj.questionNum === value;
}
case clsvcc_CourseKnowledgesEN.con_OrderNum:
return (obj: clsvcc_CourseKnowledgesEN) => {
return obj.orderNum === value;
}
case clsvcc_CourseKnowledgesEN.con_UpdUser:
return (obj: clsvcc_CourseKnowledgesEN) => {
return obj.updUser === value;
}
case clsvcc_CourseKnowledgesEN.con_KnowledgeTypeId:
return (obj: clsvcc_CourseKnowledgesEN) => {
return obj.knowledgeTypeId === value;
}
case clsvcc_CourseKnowledgesEN.con_KnowledgeTypeName:
return (obj: clsvcc_CourseKnowledgesEN) => {
return obj.knowledgeTypeName === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vcc_CourseKnowledges]中不存在！(in ${ vcc_CourseKnowledges_ConstructorName}.${ strThisFuncName})`;
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
export async function vcc_CourseKnowledges_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vcc_CourseKnowledges_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_CourseKnowledges_ConstructorName, strThisFuncName);
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
export async function vcc_CourseKnowledges_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vcc_CourseKnowledges_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_CourseKnowledges_ConstructorName, strThisFuncName);
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
export async function vcc_CourseKnowledges_GetFirstObjAsync(strWhereCond: string): Promise<clsvcc_CourseKnowledgesEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(vcc_CourseKnowledges_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vcc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvcc_CourseKnowledges = vcc_CourseKnowledges_GetObjFromJsonObj(returnObj);
return objvcc_CourseKnowledges;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_CourseKnowledges_ConstructorName, strThisFuncName);
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
export async function vcc_CourseKnowledges_GetObjLstAsync(strWhereCond: string): Promise<Array<clsvcc_CourseKnowledgesEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(vcc_CourseKnowledges_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vcc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vcc_CourseKnowledges_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_CourseKnowledges_ConstructorName, strThisFuncName);
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
 * @param arrCourseKnowledgeId:关键字列表
 * @returns 对象列表
 **/
export async function vcc_CourseKnowledges_GetObjLstByCourseKnowledgeIdLstAsync(arrCourseKnowledgeId: Array<string>): Promise<Array<clsvcc_CourseKnowledgesEN>>  
{
const strThisFuncName = "GetObjLstByCourseKnowledgeIdLstAsync";
const strAction = "GetObjLstByCourseKnowledgeIdLst";
const strUrl = GetWebApiUrl(vcc_CourseKnowledges_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrCourseKnowledgeId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vcc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vcc_CourseKnowledges_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_CourseKnowledges_ConstructorName, strThisFuncName);
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
export async function vcc_CourseKnowledges_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsvcc_CourseKnowledgesEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(vcc_CourseKnowledges_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vcc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vcc_CourseKnowledges_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_CourseKnowledges_ConstructorName, strThisFuncName);
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
export async function vcc_CourseKnowledges_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsvcc_CourseKnowledgesEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vcc_CourseKnowledges_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vcc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vcc_CourseKnowledges_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_CourseKnowledges_ConstructorName, strThisFuncName);
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
export async function vcc_CourseKnowledges_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vcc_CourseKnowledges_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_CourseKnowledges_ConstructorName, strThisFuncName);
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
export async function vcc_CourseKnowledges_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsvcc_CourseKnowledgesEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(vcc_CourseKnowledges_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vcc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vcc_CourseKnowledges_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_CourseKnowledges_ConstructorName, strThisFuncName);
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
export async function vcc_CourseKnowledges_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(vcc_CourseKnowledges_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_CourseKnowledges_ConstructorName, strThisFuncName);
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
export async function vcc_CourseKnowledges_IsExist(strCourseKnowledgeId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vcc_CourseKnowledges_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_CourseKnowledges_ConstructorName, strThisFuncName);
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
 * @param strCourseKnowledgeId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function vcc_CourseKnowledges_IsExistAsync(strCourseKnowledgeId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vcc_CourseKnowledges_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_CourseKnowledges_ConstructorName, strThisFuncName);
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
export async function vcc_CourseKnowledges_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(vcc_CourseKnowledges_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_CourseKnowledges_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_CourseKnowledges_ConstructorName, strThisFuncName);
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
export function vcc_CourseKnowledges_GetWebApiUrl(strController: string, strAction: string): string {
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
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vcc_CourseKnowledges_GetJSONStrByObj (pobjvcc_CourseKnowledgesEN: clsvcc_CourseKnowledgesEN): string
{
const strThisFuncName = "GetJSONStrByObj";
let strJson = "";
try
{
strJson = JSON.stringify(pobjvcc_CourseKnowledgesEN);
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
export function vcc_CourseKnowledges_GetObjLstByJSONStr (strJSON: string): Array<clsvcc_CourseKnowledgesEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrvcc_CourseKnowledgesObjLst = new Array<clsvcc_CourseKnowledgesEN>();
if (strJSON === "")
{
return arrvcc_CourseKnowledgesObjLst;
}
try
{
arrvcc_CourseKnowledgesObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvcc_CourseKnowledgesObjLst;
}
return arrvcc_CourseKnowledgesObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrvcc_CourseKnowledgesObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function vcc_CourseKnowledges_GetObjLstByJSONObjLst (arrvcc_CourseKnowledgesObjLstS: Array<clsvcc_CourseKnowledgesEN>): Array<clsvcc_CourseKnowledgesEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrvcc_CourseKnowledgesObjLst = new Array<clsvcc_CourseKnowledgesEN>();
for (const objInFor of arrvcc_CourseKnowledgesObjLstS) {
const obj1 = vcc_CourseKnowledges_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrvcc_CourseKnowledgesObjLst.push(obj1);
}
return arrvcc_CourseKnowledgesObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vcc_CourseKnowledges_GetObjByJSONStr (strJSON: string): clsvcc_CourseKnowledgesEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjvcc_CourseKnowledgesEN = new clsvcc_CourseKnowledgesEN();
if (strJSON === "")
{
return pobjvcc_CourseKnowledgesEN;
}
try
{
pobjvcc_CourseKnowledgesEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvcc_CourseKnowledgesEN;
}
return pobjvcc_CourseKnowledgesEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function vcc_CourseKnowledges_GetCombineCondition(objvcc_CourseKnowledges_Cond: clsvcc_CourseKnowledgesEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN.con_CourseKnowledgeId) == true)
{
const strComparisonOp_CourseKnowledgeId:string = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN.con_CourseKnowledgeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseKnowledgesEN.con_CourseKnowledgeId, objvcc_CourseKnowledges_Cond.courseKnowledgeId, strComparisonOp_CourseKnowledgeId);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN.con_KnowledgeName) == true)
{
const strComparisonOp_KnowledgeName:string = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN.con_KnowledgeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseKnowledgesEN.con_KnowledgeName, objvcc_CourseKnowledges_Cond.knowledgeName, strComparisonOp_KnowledgeName);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN.con_KnowledgeTitle) == true)
{
const strComparisonOp_KnowledgeTitle:string = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN.con_KnowledgeTitle];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseKnowledgesEN.con_KnowledgeTitle, objvcc_CourseKnowledges_Cond.knowledgeTitle, strComparisonOp_KnowledgeTitle);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN.con_CourseId) == true)
{
const strComparisonOp_CourseId:string = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN.con_CourseId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseKnowledgesEN.con_CourseId, objvcc_CourseKnowledges_Cond.courseId, strComparisonOp_CourseId);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN.con_CourseCode) == true)
{
const strComparisonOp_CourseCode:string = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN.con_CourseCode];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseKnowledgesEN.con_CourseCode, objvcc_CourseKnowledges_Cond.courseCode, strComparisonOp_CourseCode);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN.con_CourseName) == true)
{
const strComparisonOp_CourseName:string = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN.con_CourseName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseKnowledgesEN.con_CourseName, objvcc_CourseKnowledges_Cond.courseName, strComparisonOp_CourseName);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN.con_CourseChapterId) == true)
{
const strComparisonOp_CourseChapterId:string = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN.con_CourseChapterId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseKnowledgesEN.con_CourseChapterId, objvcc_CourseKnowledges_Cond.courseChapterId, strComparisonOp_CourseChapterId);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN.con_UserId) == true)
{
const strComparisonOp_UserId:string = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN.con_UserId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseKnowledgesEN.con_UserId, objvcc_CourseKnowledges_Cond.userId, strComparisonOp_UserId);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN.con_ChapterId) == true)
{
const strComparisonOp_ChapterId:string = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN.con_ChapterId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseKnowledgesEN.con_ChapterId, objvcc_CourseKnowledges_Cond.chapterId, strComparisonOp_ChapterId);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN.con_UploadDate) == true)
{
const strComparisonOp_UploadDate:string = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN.con_UploadDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseKnowledgesEN.con_UploadDate, objvcc_CourseKnowledges_Cond.uploadDate, strComparisonOp_UploadDate);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN.con_SectionId) == true)
{
const strComparisonOp_SectionId:string = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN.con_SectionId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseKnowledgesEN.con_SectionId, objvcc_CourseKnowledges_Cond.sectionId, strComparisonOp_SectionId);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN.con_IsShow) == true)
{
if (objvcc_CourseKnowledges_Cond.isShow == true)
{
strWhereCond += Format(" And {0} = '1'", clsvcc_CourseKnowledgesEN.con_IsShow);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvcc_CourseKnowledgesEN.con_IsShow);
}
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN.con_ChapterName) == true)
{
const strComparisonOp_ChapterName:string = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN.con_ChapterName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseKnowledgesEN.con_ChapterName, objvcc_CourseKnowledges_Cond.chapterName, strComparisonOp_ChapterName);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN.con_IsCast) == true)
{
if (objvcc_CourseKnowledges_Cond.isCast == true)
{
strWhereCond += Format(" And {0} = '1'", clsvcc_CourseKnowledgesEN.con_IsCast);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvcc_CourseKnowledgesEN.con_IsCast);
}
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN.con_SectionName) == true)
{
const strComparisonOp_SectionName:string = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN.con_SectionName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseKnowledgesEN.con_SectionName, objvcc_CourseKnowledges_Cond.sectionName, strComparisonOp_SectionName);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN.con_LikeCount) == true)
{
const strComparisonOp_LikeCount:string = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN.con_LikeCount];
strWhereCond += Format(" And {0} {2} {1}", clsvcc_CourseKnowledgesEN.con_LikeCount, objvcc_CourseKnowledges_Cond.likeCount, strComparisonOp_LikeCount);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN.con_ChapterName_Sim) == true)
{
const strComparisonOp_ChapterName_Sim:string = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN.con_ChapterName_Sim];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseKnowledgesEN.con_ChapterName_Sim, objvcc_CourseKnowledges_Cond.chapterName_Sim, strComparisonOp_ChapterName_Sim);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseKnowledgesEN.con_UpdDate, objvcc_CourseKnowledges_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN.con_SectionName_Sim) == true)
{
const strComparisonOp_SectionName_Sim:string = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN.con_SectionName_Sim];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseKnowledgesEN.con_SectionName_Sim, objvcc_CourseKnowledges_Cond.sectionName_Sim, strComparisonOp_SectionName_Sim);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseKnowledgesEN.con_Memo, objvcc_CourseKnowledges_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN.con_QuestionNum) == true)
{
const strComparisonOp_QuestionNum:string = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN.con_QuestionNum];
strWhereCond += Format(" And {0} {2} {1}", clsvcc_CourseKnowledgesEN.con_QuestionNum, objvcc_CourseKnowledges_Cond.questionNum, strComparisonOp_QuestionNum);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN.con_OrderNum) == true)
{
const strComparisonOp_OrderNum:string = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN.con_OrderNum];
strWhereCond += Format(" And {0} {2} {1}", clsvcc_CourseKnowledgesEN.con_OrderNum, objvcc_CourseKnowledges_Cond.orderNum, strComparisonOp_OrderNum);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseKnowledgesEN.con_UpdUser, objvcc_CourseKnowledges_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN.con_KnowledgeTypeId) == true)
{
const strComparisonOp_KnowledgeTypeId:string = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN.con_KnowledgeTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseKnowledgesEN.con_KnowledgeTypeId, objvcc_CourseKnowledges_Cond.knowledgeTypeId, strComparisonOp_KnowledgeTypeId);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN.con_KnowledgeTypeName) == true)
{
const strComparisonOp_KnowledgeTypeName:string = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN.con_KnowledgeTypeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseKnowledgesEN.con_KnowledgeTypeName, objvcc_CourseKnowledges_Cond.knowledgeTypeName, strComparisonOp_KnowledgeTypeName);
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objvcc_CourseKnowledgesENS:源对象
 * @param objvcc_CourseKnowledgesENT:目标对象
*/
export function vcc_CourseKnowledges_CopyObjTo(objvcc_CourseKnowledgesENS: clsvcc_CourseKnowledgesEN , objvcc_CourseKnowledgesENT: clsvcc_CourseKnowledgesEN ): void 
{
objvcc_CourseKnowledgesENT.courseKnowledgeId = objvcc_CourseKnowledgesENS.courseKnowledgeId; //知识点Id
objvcc_CourseKnowledgesENT.knowledgeName = objvcc_CourseKnowledgesENS.knowledgeName; //知识点名称
objvcc_CourseKnowledgesENT.knowledgeTitle = objvcc_CourseKnowledgesENS.knowledgeTitle; //知识点标题
objvcc_CourseKnowledgesENT.knowledgeContent = objvcc_CourseKnowledgesENS.knowledgeContent; //知识点内容
objvcc_CourseKnowledgesENT.courseId = objvcc_CourseKnowledgesENS.courseId; //课程Id
objvcc_CourseKnowledgesENT.courseCode = objvcc_CourseKnowledgesENS.courseCode; //课程代码
objvcc_CourseKnowledgesENT.courseName = objvcc_CourseKnowledgesENS.courseName; //课程名称
objvcc_CourseKnowledgesENT.courseChapterId = objvcc_CourseKnowledgesENS.courseChapterId; //课程章节ID
objvcc_CourseKnowledgesENT.userId = objvcc_CourseKnowledgesENS.userId; //用户ID
objvcc_CourseKnowledgesENT.chapterId = objvcc_CourseKnowledgesENS.chapterId; //章Id
objvcc_CourseKnowledgesENT.uploadDate = objvcc_CourseKnowledgesENS.uploadDate; //上传时间
objvcc_CourseKnowledgesENT.sectionId = objvcc_CourseKnowledgesENS.sectionId; //节Id
objvcc_CourseKnowledgesENT.isShow = objvcc_CourseKnowledgesENS.isShow; //是否启用
objvcc_CourseKnowledgesENT.chapterName = objvcc_CourseKnowledgesENS.chapterName; //章名
objvcc_CourseKnowledgesENT.isCast = objvcc_CourseKnowledgesENS.isCast; //是否播放
objvcc_CourseKnowledgesENT.sectionName = objvcc_CourseKnowledgesENS.sectionName; //节名
objvcc_CourseKnowledgesENT.likeCount = objvcc_CourseKnowledgesENS.likeCount; //资源喜欢数量
objvcc_CourseKnowledgesENT.chapterName_Sim = objvcc_CourseKnowledgesENS.chapterName_Sim; //章名简称
objvcc_CourseKnowledgesENT.updDate = objvcc_CourseKnowledgesENS.updDate; //修改日期
objvcc_CourseKnowledgesENT.sectionName_Sim = objvcc_CourseKnowledgesENS.sectionName_Sim; //节名简称
objvcc_CourseKnowledgesENT.memo = objvcc_CourseKnowledgesENS.memo; //备注
objvcc_CourseKnowledgesENT.questionNum = objvcc_CourseKnowledgesENS.questionNum; //题目数
objvcc_CourseKnowledgesENT.orderNum = objvcc_CourseKnowledgesENS.orderNum; //序号
objvcc_CourseKnowledgesENT.updUser = objvcc_CourseKnowledgesENS.updUser; //修改人
objvcc_CourseKnowledgesENT.knowledgeTypeId = objvcc_CourseKnowledgesENS.knowledgeTypeId; //知识点类型Id
objvcc_CourseKnowledgesENT.knowledgeTypeName = objvcc_CourseKnowledgesENS.knowledgeTypeName; //知识点类型名
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objvcc_CourseKnowledgesENS:源对象
 * @param objvcc_CourseKnowledgesENT:目标对象
*/
export function vcc_CourseKnowledges_GetObjFromJsonObj(objvcc_CourseKnowledgesENS: clsvcc_CourseKnowledgesEN): clsvcc_CourseKnowledgesEN 
{
 const objvcc_CourseKnowledgesENT: clsvcc_CourseKnowledgesEN = new clsvcc_CourseKnowledgesEN();
ObjectAssign(objvcc_CourseKnowledgesENT, objvcc_CourseKnowledgesENS);
 return objvcc_CourseKnowledgesENT;
}