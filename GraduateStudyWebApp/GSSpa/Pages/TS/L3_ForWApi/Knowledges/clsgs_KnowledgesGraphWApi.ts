
 /**
 * 类名:clsgs_KnowledgesGraphWApi
 * 表名:gs_KnowledgesGraph(01120873)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:46:03
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
 * 知识点逻辑图(gs_KnowledgesGraph)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clsgs_KnowledgesGraphEN } from "../../L0_Entity/Knowledges/clsgs_KnowledgesGraphEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { tzDataType } from "../../PubFun/jsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const gs_KnowledgesGraph_Controller = "gs_KnowledgesGraphApi";
 export const gs_KnowledgesGraph_ConstructorName = "gs_KnowledgesGraph";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strKnowledgeGraphId:关键字
 * @returns 对象
 **/
export async function gs_KnowledgesGraph_GetObjByKnowledgeGraphIdAsync(strKnowledgeGraphId: string): Promise<clsgs_KnowledgesGraphEN>  
{
const strThisFuncName = "GetObjByKnowledgeGraphIdAsync";

if (IsNullOrEmpty(strKnowledgeGraphId) == true)
{
  const strMsg = Format("参数:[strKnowledgeGraphId]不能为空！(In GetObjByKnowledgeGraphIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strKnowledgeGraphId.length != 10)
{
const strMsg = Format("缓存分类变量:[strKnowledgeGraphId]的长度:[{0}]不正确！", strKnowledgeGraphId.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByKnowledgeGraphId";
const strUrl = GetWebApiUrl(gs_KnowledgesGraph_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strKnowledgeGraphId": strKnowledgeGraphId,
}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObj = data.returnObj;
if (returnObj == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_KnowledgesGraph_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objgs_KnowledgesGraph = gs_KnowledgesGraph_GetObjFromJsonObj(returnObj);
return objgs_KnowledgesGraph;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_KnowledgesGraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_KnowledgesGraph_ConstructorName, strThisFuncName);
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
 * @param strKnowledgeGraphId:所给的关键字
 * @returns 对象
*/
export async function gs_KnowledgesGraph_GetObjByKnowledgeGraphId_Cache(strKnowledgeGraphId:string,strCourseId:string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByKnowledgeGraphId_Cache";

if (IsNullOrEmpty(strKnowledgeGraphId) == true)
{
  const strMsg = Format("参数:[strKnowledgeGraphId]不能为空！(In GetObjByKnowledgeGraphId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strKnowledgeGraphId.length != 10)
{
const strMsg = Format("缓存分类变量:[strKnowledgeGraphId]的长度:[{0}]不正确！", strKnowledgeGraphId.length);
console.error(strMsg);
throw (strMsg);
}
const arrgs_KnowledgesGraphObjLst_Cache = await gs_KnowledgesGraph_GetObjLst_Cache(strCourseId);
try
{
const arrgs_KnowledgesGraph_Sel: Array <clsgs_KnowledgesGraphEN> = arrgs_KnowledgesGraphObjLst_Cache.filter(x => x.knowledgeGraphId == strKnowledgeGraphId);
let objgs_KnowledgesGraph: clsgs_KnowledgesGraphEN;
if (arrgs_KnowledgesGraph_Sel.length > 0)
{
objgs_KnowledgesGraph = arrgs_KnowledgesGraph_Sel[0];
return objgs_KnowledgesGraph;
}
else
{
if (bolTryAsyncOnce == true)
{
objgs_KnowledgesGraph = await gs_KnowledgesGraph_GetObjByKnowledgeGraphIdAsync(strKnowledgeGraphId);
if (objgs_KnowledgesGraph != null)
{
gs_KnowledgesGraph_ReFreshThisCache(strCourseId);
return objgs_KnowledgesGraph;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strKnowledgeGraphId, gs_KnowledgesGraph_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param strKnowledgeGraphId:所给的关键字
 * @returns 对象
*/
export async function gs_KnowledgesGraph_GetObjByKnowledgeGraphId_localStorage(strKnowledgeGraphId: string) {
const strThisFuncName = "GetObjByKnowledgeGraphId_localStorage";

if (IsNullOrEmpty(strKnowledgeGraphId) == true)
{
  const strMsg = Format("参数:[strKnowledgeGraphId]不能为空！(In GetObjByKnowledgeGraphId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
if (strKnowledgeGraphId.length != 10)
{
const strMsg = Format("缓存分类变量:[strKnowledgeGraphId]的长度:[{0}]不正确！", strKnowledgeGraphId.length);
console.error(strMsg);
throw (strMsg);
}
const strKey = Format("{0}_{1}", clsgs_KnowledgesGraphEN._CurrTabName, strKnowledgeGraphId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objgs_KnowledgesGraph_Cache: clsgs_KnowledgesGraphEN = JSON.parse(strTempObj);
return objgs_KnowledgesGraph_Cache;
}
try
{
const objgs_KnowledgesGraph = await gs_KnowledgesGraph_GetObjByKnowledgeGraphIdAsync(strKnowledgeGraphId);
if (objgs_KnowledgesGraph != null)
{
localStorage.setItem(strKey, JSON.stringify(objgs_KnowledgesGraph));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objgs_KnowledgesGraph;
}
return objgs_KnowledgesGraph;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strKnowledgeGraphId, gs_KnowledgesGraph_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objgs_KnowledgesGraph:所给的对象
 * @returns 对象
*/
export async function gs_KnowledgesGraph_UpdateObjInLst_Cache(objgs_KnowledgesGraph: clsgs_KnowledgesGraphEN,strCourseId: string) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrgs_KnowledgesGraphObjLst_Cache = await gs_KnowledgesGraph_GetObjLst_Cache(strCourseId);
const obj = arrgs_KnowledgesGraphObjLst_Cache.find(x => x.knowledgeGraphName == objgs_KnowledgesGraph.knowledgeGraphName && x.courseId == objgs_KnowledgesGraph.courseId && x.createUser == objgs_KnowledgesGraph.createUser);
if (obj != null)
{
objgs_KnowledgesGraph.knowledgeGraphId = obj.knowledgeGraphId;
ObjectAssign( obj, objgs_KnowledgesGraph);
}
else
{
arrgs_KnowledgesGraphObjLst_Cache.push(objgs_KnowledgesGraph);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, gs_KnowledgesGraph_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
}

/**
 * 根据关键字获取相关对象的名称属性, 从缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
 * @param strKnowledgeGraphId:所给的关键字
 * @returns 对象
*/
export async function gs_KnowledgesGraph_GetNameByKnowledgeGraphId_Cache(strKnowledgeGraphId: string,strCourseId: string) {
const strThisFuncName = "GetNameByKnowledgeGraphId_Cache";

if (IsNullOrEmpty(strKnowledgeGraphId) == true)
{
  const strMsg = Format("参数:[strKnowledgeGraphId]不能为空！(In GetNameByKnowledgeGraphId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strKnowledgeGraphId.length != 10)
{
const strMsg = Format("缓存分类变量:[strKnowledgeGraphId]的长度:[{0}]不正确！", strKnowledgeGraphId.length);
console.error(strMsg);
throw (strMsg);
}
const arrgs_KnowledgesGraphObjLst_Cache = await gs_KnowledgesGraph_GetObjLst_Cache(strCourseId);
if (arrgs_KnowledgesGraphObjLst_Cache == null) return "";
try
{
const arrgs_KnowledgesGraph_Sel: Array <clsgs_KnowledgesGraphEN> = arrgs_KnowledgesGraphObjLst_Cache.filter(x => x.knowledgeGraphId == strKnowledgeGraphId);
let objgs_KnowledgesGraph: clsgs_KnowledgesGraphEN;
if (arrgs_KnowledgesGraph_Sel.length > 0)
{
objgs_KnowledgesGraph = arrgs_KnowledgesGraph_Sel[0];
return objgs_KnowledgesGraph.knowledgeGraphName;
}
else
{
return "";
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strKnowledgeGraphId);
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
export async function gs_KnowledgesGraph_func(strInFldName:string , strOutFldName:string , strInValue:string , strCourseId_C: string)
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

if (strInFldName != clsgs_KnowledgesGraphEN.con_KnowledgeGraphId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsgs_KnowledgesGraphEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clsgs_KnowledgesGraphEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strKnowledgeGraphId = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objgs_KnowledgesGraph = await gs_KnowledgesGraph_GetObjByKnowledgeGraphId_Cache(strKnowledgeGraphId , strCourseId_C);
if (objgs_KnowledgesGraph == null) return "";
return objgs_KnowledgesGraph.GetFldValue(strOutFldName).toString();
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
export function gs_KnowledgesGraph_SortFun_Defa(a:clsgs_KnowledgesGraphEN , b:clsgs_KnowledgesGraphEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.knowledgeGraphId.localeCompare(b.knowledgeGraphId);
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
export function gs_KnowledgesGraph_SortFun_Defa_2Fld(a:clsgs_KnowledgesGraphEN , b:clsgs_KnowledgesGraphEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.knowledgeGraphName == b.knowledgeGraphName) return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
else return a.knowledgeGraphName.localeCompare(b.knowledgeGraphName);
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
export function gs_KnowledgesGraph_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsgs_KnowledgesGraphEN.con_KnowledgeGraphId:
return (a: clsgs_KnowledgesGraphEN, b: clsgs_KnowledgesGraphEN) => {
return a.knowledgeGraphId.localeCompare(b.knowledgeGraphId);
}
case clsgs_KnowledgesGraphEN.con_KnowledgeGraphName:
return (a: clsgs_KnowledgesGraphEN, b: clsgs_KnowledgesGraphEN) => {
return a.knowledgeGraphName.localeCompare(b.knowledgeGraphName);
}
case clsgs_KnowledgesGraphEN.con_id_CurrEduCls:
return (a: clsgs_KnowledgesGraphEN, b: clsgs_KnowledgesGraphEN) => {
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
case clsgs_KnowledgesGraphEN.con_CourseId:
return (a: clsgs_KnowledgesGraphEN, b: clsgs_KnowledgesGraphEN) => {
return a.courseId.localeCompare(b.courseId);
}
case clsgs_KnowledgesGraphEN.con_CreateUser:
return (a: clsgs_KnowledgesGraphEN, b: clsgs_KnowledgesGraphEN) => {
return a.createUser.localeCompare(b.createUser);
}
case clsgs_KnowledgesGraphEN.con_UpdDate:
return (a: clsgs_KnowledgesGraphEN, b: clsgs_KnowledgesGraphEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsgs_KnowledgesGraphEN.con_UpdUser:
return (a: clsgs_KnowledgesGraphEN, b: clsgs_KnowledgesGraphEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsgs_KnowledgesGraphEN.con_Memo:
return (a: clsgs_KnowledgesGraphEN, b: clsgs_KnowledgesGraphEN) => {
return a.memo.localeCompare(b.memo);
}
case clsgs_KnowledgesGraphEN.con_GraphTypeId:
return (a: clsgs_KnowledgesGraphEN, b: clsgs_KnowledgesGraphEN) => {
return a.graphTypeId.localeCompare(b.graphTypeId);
}
case clsgs_KnowledgesGraphEN.con_IsDisplay:
return (a: clsgs_KnowledgesGraphEN, b: clsgs_KnowledgesGraphEN) => {
if (a.isDisplay == true) return 1;
else return -1
}
case clsgs_KnowledgesGraphEN.con_IsExtend:
return (a: clsgs_KnowledgesGraphEN, b: clsgs_KnowledgesGraphEN) => {
if (a.isExtend == true) return 1;
else return -1
}
case clsgs_KnowledgesGraphEN.con_IsRecommend:
return (a: clsgs_KnowledgesGraphEN, b: clsgs_KnowledgesGraphEN) => {
if (a.isRecommend == true) return 1;
else return -1
}
case clsgs_KnowledgesGraphEN.con_IsAnswer:
return (a: clsgs_KnowledgesGraphEN, b: clsgs_KnowledgesGraphEN) => {
if (a.isAnswer == true) return 1;
else return -1
}
case clsgs_KnowledgesGraphEN.con_IsSubmit:
return (a: clsgs_KnowledgesGraphEN, b: clsgs_KnowledgesGraphEN) => {
if (a.isSubmit == true) return 1;
else return -1
}
case clsgs_KnowledgesGraphEN.con_StartTime:
return (a: clsgs_KnowledgesGraphEN, b: clsgs_KnowledgesGraphEN) => {
return a.startTime.localeCompare(b.startTime);
}
case clsgs_KnowledgesGraphEN.con_SubmitTime:
return (a: clsgs_KnowledgesGraphEN, b: clsgs_KnowledgesGraphEN) => {
return a.submitTime.localeCompare(b.submitTime);
}
case clsgs_KnowledgesGraphEN.con_EduClassName:
return (a: clsgs_KnowledgesGraphEN, b: clsgs_KnowledgesGraphEN) => {
return a.eduClassName.localeCompare(b.eduClassName);
}
case clsgs_KnowledgesGraphEN.con_CourseName:
return (a: clsgs_KnowledgesGraphEN, b: clsgs_KnowledgesGraphEN) => {
return a.courseName.localeCompare(b.courseName);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_KnowledgesGraph]中不存在！(in ${ gs_KnowledgesGraph_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsgs_KnowledgesGraphEN.con_KnowledgeGraphId:
return (a: clsgs_KnowledgesGraphEN, b: clsgs_KnowledgesGraphEN) => {
return b.knowledgeGraphId.localeCompare(a.knowledgeGraphId);
}
case clsgs_KnowledgesGraphEN.con_KnowledgeGraphName:
return (a: clsgs_KnowledgesGraphEN, b: clsgs_KnowledgesGraphEN) => {
return b.knowledgeGraphName.localeCompare(a.knowledgeGraphName);
}
case clsgs_KnowledgesGraphEN.con_id_CurrEduCls:
return (a: clsgs_KnowledgesGraphEN, b: clsgs_KnowledgesGraphEN) => {
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
case clsgs_KnowledgesGraphEN.con_CourseId:
return (a: clsgs_KnowledgesGraphEN, b: clsgs_KnowledgesGraphEN) => {
return b.courseId.localeCompare(a.courseId);
}
case clsgs_KnowledgesGraphEN.con_CreateUser:
return (a: clsgs_KnowledgesGraphEN, b: clsgs_KnowledgesGraphEN) => {
return b.createUser.localeCompare(a.createUser);
}
case clsgs_KnowledgesGraphEN.con_UpdDate:
return (a: clsgs_KnowledgesGraphEN, b: clsgs_KnowledgesGraphEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsgs_KnowledgesGraphEN.con_UpdUser:
return (a: clsgs_KnowledgesGraphEN, b: clsgs_KnowledgesGraphEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsgs_KnowledgesGraphEN.con_Memo:
return (a: clsgs_KnowledgesGraphEN, b: clsgs_KnowledgesGraphEN) => {
return b.memo.localeCompare(a.memo);
}
case clsgs_KnowledgesGraphEN.con_GraphTypeId:
return (a: clsgs_KnowledgesGraphEN, b: clsgs_KnowledgesGraphEN) => {
return b.graphTypeId.localeCompare(a.graphTypeId);
}
case clsgs_KnowledgesGraphEN.con_IsDisplay:
return (a: clsgs_KnowledgesGraphEN, b: clsgs_KnowledgesGraphEN) => {
if (b.isDisplay == true) return 1;
else return -1
}
case clsgs_KnowledgesGraphEN.con_IsExtend:
return (a: clsgs_KnowledgesGraphEN, b: clsgs_KnowledgesGraphEN) => {
if (b.isExtend == true) return 1;
else return -1
}
case clsgs_KnowledgesGraphEN.con_IsRecommend:
return (a: clsgs_KnowledgesGraphEN, b: clsgs_KnowledgesGraphEN) => {
if (b.isRecommend == true) return 1;
else return -1
}
case clsgs_KnowledgesGraphEN.con_IsAnswer:
return (a: clsgs_KnowledgesGraphEN, b: clsgs_KnowledgesGraphEN) => {
if (b.isAnswer == true) return 1;
else return -1
}
case clsgs_KnowledgesGraphEN.con_IsSubmit:
return (a: clsgs_KnowledgesGraphEN, b: clsgs_KnowledgesGraphEN) => {
if (b.isSubmit == true) return 1;
else return -1
}
case clsgs_KnowledgesGraphEN.con_StartTime:
return (a: clsgs_KnowledgesGraphEN, b: clsgs_KnowledgesGraphEN) => {
return b.startTime.localeCompare(a.startTime);
}
case clsgs_KnowledgesGraphEN.con_SubmitTime:
return (a: clsgs_KnowledgesGraphEN, b: clsgs_KnowledgesGraphEN) => {
return b.submitTime.localeCompare(a.submitTime);
}
case clsgs_KnowledgesGraphEN.con_EduClassName:
return (a: clsgs_KnowledgesGraphEN, b: clsgs_KnowledgesGraphEN) => {
return b.eduClassName.localeCompare(a.eduClassName);
}
case clsgs_KnowledgesGraphEN.con_CourseName:
return (a: clsgs_KnowledgesGraphEN, b: clsgs_KnowledgesGraphEN) => {
return b.courseName.localeCompare(a.courseName);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_KnowledgesGraph]中不存在！(in ${ gs_KnowledgesGraph_ConstructorName}.${ strThisFuncName})`;
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
export async function gs_KnowledgesGraph_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsgs_KnowledgesGraphEN.con_KnowledgeGraphId:
return (obj: clsgs_KnowledgesGraphEN) => {
return obj.knowledgeGraphId === value;
}
case clsgs_KnowledgesGraphEN.con_KnowledgeGraphName:
return (obj: clsgs_KnowledgesGraphEN) => {
return obj.knowledgeGraphName === value;
}
case clsgs_KnowledgesGraphEN.con_id_CurrEduCls:
return (obj: clsgs_KnowledgesGraphEN) => {
return obj.id_CurrEduCls === value;
}
case clsgs_KnowledgesGraphEN.con_CourseId:
return (obj: clsgs_KnowledgesGraphEN) => {
return obj.courseId === value;
}
case clsgs_KnowledgesGraphEN.con_CreateUser:
return (obj: clsgs_KnowledgesGraphEN) => {
return obj.createUser === value;
}
case clsgs_KnowledgesGraphEN.con_UpdDate:
return (obj: clsgs_KnowledgesGraphEN) => {
return obj.updDate === value;
}
case clsgs_KnowledgesGraphEN.con_UpdUser:
return (obj: clsgs_KnowledgesGraphEN) => {
return obj.updUser === value;
}
case clsgs_KnowledgesGraphEN.con_Memo:
return (obj: clsgs_KnowledgesGraphEN) => {
return obj.memo === value;
}
case clsgs_KnowledgesGraphEN.con_GraphTypeId:
return (obj: clsgs_KnowledgesGraphEN) => {
return obj.graphTypeId === value;
}
case clsgs_KnowledgesGraphEN.con_IsDisplay:
return (obj: clsgs_KnowledgesGraphEN) => {
return obj.isDisplay === value;
}
case clsgs_KnowledgesGraphEN.con_IsExtend:
return (obj: clsgs_KnowledgesGraphEN) => {
return obj.isExtend === value;
}
case clsgs_KnowledgesGraphEN.con_IsRecommend:
return (obj: clsgs_KnowledgesGraphEN) => {
return obj.isRecommend === value;
}
case clsgs_KnowledgesGraphEN.con_IsAnswer:
return (obj: clsgs_KnowledgesGraphEN) => {
return obj.isAnswer === value;
}
case clsgs_KnowledgesGraphEN.con_IsSubmit:
return (obj: clsgs_KnowledgesGraphEN) => {
return obj.isSubmit === value;
}
case clsgs_KnowledgesGraphEN.con_StartTime:
return (obj: clsgs_KnowledgesGraphEN) => {
return obj.startTime === value;
}
case clsgs_KnowledgesGraphEN.con_SubmitTime:
return (obj: clsgs_KnowledgesGraphEN) => {
return obj.submitTime === value;
}
case clsgs_KnowledgesGraphEN.con_EduClassName:
return (obj: clsgs_KnowledgesGraphEN) => {
return obj.eduClassName === value;
}
case clsgs_KnowledgesGraphEN.con_CourseName:
return (obj: clsgs_KnowledgesGraphEN) => {
return obj.courseName === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_KnowledgesGraph]中不存在！(in ${ gs_KnowledgesGraph_ConstructorName}.${ strThisFuncName})`;
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
export async function gs_KnowledgesGraph_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(gs_KnowledgesGraph_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_KnowledgesGraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_KnowledgesGraph_ConstructorName, strThisFuncName);
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
export async function gs_KnowledgesGraph_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(gs_KnowledgesGraph_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_KnowledgesGraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_KnowledgesGraph_ConstructorName, strThisFuncName);
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
export async function gs_KnowledgesGraph_GetFirstObjAsync(strWhereCond: string): Promise<clsgs_KnowledgesGraphEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(gs_KnowledgesGraph_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_KnowledgesGraph_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objgs_KnowledgesGraph = gs_KnowledgesGraph_GetObjFromJsonObj(returnObj);
return objgs_KnowledgesGraph;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_KnowledgesGraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_KnowledgesGraph_ConstructorName, strThisFuncName);
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
export async function gs_KnowledgesGraph_GetObjLst_ClientCache(strCourseId: string)
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("CourseId='{0}'", strCourseId);
const strKey = Format("{0}_{1}", clsgs_KnowledgesGraphEN._CurrTabName, strCourseId);
clsgs_KnowledgesGraphEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsgs_KnowledgesGraphEN._CurrTabName);
if (IsNullOrEmpty(clsgs_KnowledgesGraphEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsgs_KnowledgesGraphEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrgs_KnowledgesGraphExObjLst_Cache: Array<clsgs_KnowledgesGraphEN> = CacheHelper.Get(strKey);
const arrgs_KnowledgesGraphObjLst_T = gs_KnowledgesGraph_GetObjLstByJSONObjLst(arrgs_KnowledgesGraphExObjLst_Cache);
return arrgs_KnowledgesGraphObjLst_T;
}
try
{
const arrgs_KnowledgesGraphExObjLst = await gs_KnowledgesGraph_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrgs_KnowledgesGraphExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_KnowledgesGraphExObjLst.length);
console.log(strInfo);
return arrgs_KnowledgesGraphExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, gs_KnowledgesGraph_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_KnowledgesGraph_GetObjLst_localStorage(strCourseId: string)
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("CourseId='{0}'", strCourseId);
const strKey = Format("{0}_{1}", clsgs_KnowledgesGraphEN._CurrTabName, strCourseId);
clsgs_KnowledgesGraphEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsgs_KnowledgesGraphEN._CurrTabName);
if (IsNullOrEmpty(clsgs_KnowledgesGraphEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsgs_KnowledgesGraphEN.CacheAddiCondition);
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
const arrgs_KnowledgesGraphExObjLst_Cache: Array<clsgs_KnowledgesGraphEN> = JSON.parse(strTempObjLst);
const arrgs_KnowledgesGraphObjLst_T = gs_KnowledgesGraph_GetObjLstByJSONObjLst(arrgs_KnowledgesGraphExObjLst_Cache);
return arrgs_KnowledgesGraphObjLst_T;
}
try
{
const arrgs_KnowledgesGraphExObjLst = await gs_KnowledgesGraph_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrgs_KnowledgesGraphExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_KnowledgesGraphExObjLst.length);
console.log(strInfo);
return arrgs_KnowledgesGraphExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, gs_KnowledgesGraph_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_KnowledgesGraph_GetObjLst_localStorage_PureCache(strCourseId: string)
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("CourseId='{0}'", strCourseId);
const strKey = Format("{0}_{1}", clsgs_KnowledgesGraphEN._CurrTabName, strCourseId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrgs_KnowledgesGraphObjLst_Cache: Array<clsgs_KnowledgesGraphEN> = JSON.parse(strTempObjLst);
return arrgs_KnowledgesGraphObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function gs_KnowledgesGraph_GetObjLstAsync(strWhereCond: string): Promise<Array<clsgs_KnowledgesGraphEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(gs_KnowledgesGraph_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_KnowledgesGraph_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_KnowledgesGraph_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_KnowledgesGraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_KnowledgesGraph_ConstructorName, strThisFuncName);
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
export async function gs_KnowledgesGraph_GetObjLst_sessionStorage(strCourseId: string)
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("CourseId='{0}'", strCourseId);
const strKey = Format("{0}_{1}", clsgs_KnowledgesGraphEN._CurrTabName, strCourseId);
clsgs_KnowledgesGraphEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsgs_KnowledgesGraphEN._CurrTabName);
if (IsNullOrEmpty(clsgs_KnowledgesGraphEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsgs_KnowledgesGraphEN.CacheAddiCondition);
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
const arrgs_KnowledgesGraphExObjLst_Cache: Array<clsgs_KnowledgesGraphEN> = JSON.parse(strTempObjLst);
const arrgs_KnowledgesGraphObjLst_T = gs_KnowledgesGraph_GetObjLstByJSONObjLst(arrgs_KnowledgesGraphExObjLst_Cache);
return arrgs_KnowledgesGraphObjLst_T;
}
try
{
const arrgs_KnowledgesGraphExObjLst = await gs_KnowledgesGraph_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrgs_KnowledgesGraphExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_KnowledgesGraphExObjLst.length);
console.log(strInfo);
return arrgs_KnowledgesGraphExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, gs_KnowledgesGraph_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_KnowledgesGraph_GetObjLst_sessionStorage_PureCache(strCourseId: string)
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("CourseId='{0}'", strCourseId);
const strKey = Format("{0}_{1}", clsgs_KnowledgesGraphEN._CurrTabName, strCourseId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrgs_KnowledgesGraphObjLst_Cache: Array<clsgs_KnowledgesGraphEN> = JSON.parse(strTempObjLst);
return arrgs_KnowledgesGraphObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_KnowledgesGraph_GetObjLst_Cache(strCourseId: string): Promise<Array<clsgs_KnowledgesGraphEN>>
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
let arrgs_KnowledgesGraphObjLst_Cache;
switch (clsgs_KnowledgesGraphEN.CacheModeId)
{
case "04"://sessionStorage
arrgs_KnowledgesGraphObjLst_Cache = await gs_KnowledgesGraph_GetObjLst_sessionStorage(strCourseId);
break;
case "03"://localStorage
arrgs_KnowledgesGraphObjLst_Cache = await gs_KnowledgesGraph_GetObjLst_localStorage(strCourseId);
break;
case "02"://ClientCache
arrgs_KnowledgesGraphObjLst_Cache = await gs_KnowledgesGraph_GetObjLst_ClientCache(strCourseId);
break;
default:
arrgs_KnowledgesGraphObjLst_Cache = await gs_KnowledgesGraph_GetObjLst_ClientCache(strCourseId);
break;
}
const arrgs_KnowledgesGraphObjLst = gs_KnowledgesGraph_GetObjLstByJSONObjLst(arrgs_KnowledgesGraphObjLst_Cache);
return arrgs_KnowledgesGraphObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_KnowledgesGraph_GetObjLst_PureCache(strCourseId: string)
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrgs_KnowledgesGraphObjLst_Cache;
switch (clsgs_KnowledgesGraphEN.CacheModeId)
{
case "04"://sessionStorage
arrgs_KnowledgesGraphObjLst_Cache = await gs_KnowledgesGraph_GetObjLst_sessionStorage_PureCache(strCourseId);
break;
case "03"://localStorage
arrgs_KnowledgesGraphObjLst_Cache = await gs_KnowledgesGraph_GetObjLst_localStorage_PureCache(strCourseId);
break;
case "02"://ClientCache
arrgs_KnowledgesGraphObjLst_Cache = null;
break;
default:
arrgs_KnowledgesGraphObjLst_Cache = null;
break;
}
return arrgs_KnowledgesGraphObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrKnowledgeGraphId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function gs_KnowledgesGraph_GetSubObjLst_Cache(objgs_KnowledgesGraph_Cond: clsgs_KnowledgesGraphEN,strCourseId: string) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrgs_KnowledgesGraphObjLst_Cache = await gs_KnowledgesGraph_GetObjLst_Cache(strCourseId);
let arrgs_KnowledgesGraph_Sel: Array < clsgs_KnowledgesGraphEN > = arrgs_KnowledgesGraphObjLst_Cache;
if (objgs_KnowledgesGraph_Cond.sf_FldComparisonOp == null || objgs_KnowledgesGraph_Cond.sf_FldComparisonOp == "") return arrgs_KnowledgesGraph_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_KnowledgesGraph_Cond.sf_FldComparisonOp);
//console.log("clsgs_KnowledgesGraphWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objgs_KnowledgesGraph_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrgs_KnowledgesGraph_Sel = arrgs_KnowledgesGraph_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_KnowledgesGraph_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_KnowledgesGraph_Sel = arrgs_KnowledgesGraph_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_KnowledgesGraph_Sel = arrgs_KnowledgesGraph_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_KnowledgesGraph_Sel = arrgs_KnowledgesGraph_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_KnowledgesGraph_Sel = arrgs_KnowledgesGraph_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_KnowledgesGraph_Sel = arrgs_KnowledgesGraph_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_KnowledgesGraph_Sel = arrgs_KnowledgesGraph_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_KnowledgesGraph_Sel = arrgs_KnowledgesGraph_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_KnowledgesGraph_Sel = arrgs_KnowledgesGraph_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrgs_KnowledgesGraph_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objgs_KnowledgesGraph_Cond), gs_KnowledgesGraph_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsgs_KnowledgesGraphEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrKnowledgeGraphId:关键字列表
 * @returns 对象列表
 **/
export async function gs_KnowledgesGraph_GetObjLstByKnowledgeGraphIdLstAsync(arrKnowledgeGraphId: Array<string>): Promise<Array<clsgs_KnowledgesGraphEN>>  
{
const strThisFuncName = "GetObjLstByKnowledgeGraphIdLstAsync";
const strAction = "GetObjLstByKnowledgeGraphIdLst";
const strUrl = GetWebApiUrl(gs_KnowledgesGraph_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrKnowledgeGraphId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_KnowledgesGraph_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_KnowledgesGraph_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_KnowledgesGraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_KnowledgesGraph_ConstructorName, strThisFuncName);
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
 * @param arrstrKnowledgeGraphIdLst:关键字列表
 * @returns 对象列表
*/
export async function gs_KnowledgesGraph_GetObjLstByKnowledgeGraphIdLst_Cache(arrKnowledgeGraphIdLst: Array<string>,strCourseId: string) {
const strThisFuncName = "GetObjLstByKnowledgeGraphIdLst_Cache";
try
{
const arrgs_KnowledgesGraphObjLst_Cache = await gs_KnowledgesGraph_GetObjLst_Cache(strCourseId);
const arrgs_KnowledgesGraph_Sel: Array <clsgs_KnowledgesGraphEN> = arrgs_KnowledgesGraphObjLst_Cache.filter(x => arrKnowledgeGraphIdLst.indexOf(x.knowledgeGraphId)>-1);
return arrgs_KnowledgesGraph_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrKnowledgeGraphIdLst.join(","), gs_KnowledgesGraph_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsgs_KnowledgesGraphEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function gs_KnowledgesGraph_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsgs_KnowledgesGraphEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(gs_KnowledgesGraph_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_KnowledgesGraph_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_KnowledgesGraph_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_KnowledgesGraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_KnowledgesGraph_ConstructorName, strThisFuncName);
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
export async function gs_KnowledgesGraph_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsgs_KnowledgesGraphEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(gs_KnowledgesGraph_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_KnowledgesGraph_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_KnowledgesGraph_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_KnowledgesGraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_KnowledgesGraph_ConstructorName, strThisFuncName);
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
export async function gs_KnowledgesGraph_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(gs_KnowledgesGraph_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_KnowledgesGraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_KnowledgesGraph_ConstructorName, strThisFuncName);
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
export async function gs_KnowledgesGraph_GetObjLstByPager_Cache(objPagerPara: stuPagerPara,strCourseId: string) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrgs_KnowledgesGraphObjLst_Cache = await gs_KnowledgesGraph_GetObjLst_Cache(strCourseId);
if (arrgs_KnowledgesGraphObjLst_Cache.length == 0) return arrgs_KnowledgesGraphObjLst_Cache;
let arrgs_KnowledgesGraph_Sel = arrgs_KnowledgesGraphObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objgs_KnowledgesGraph_Cond = new clsgs_KnowledgesGraphEN();
ObjectAssign(objgs_KnowledgesGraph_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsgs_KnowledgesGraphWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrgs_KnowledgesGraph_Sel = arrgs_KnowledgesGraph_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_KnowledgesGraph_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_KnowledgesGraph_Sel = arrgs_KnowledgesGraph_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_KnowledgesGraph_Sel = arrgs_KnowledgesGraph_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrgs_KnowledgesGraph_Sel = arrgs_KnowledgesGraph_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_KnowledgesGraph_Sel = arrgs_KnowledgesGraph_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_KnowledgesGraph_Sel = arrgs_KnowledgesGraph_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_KnowledgesGraph_Sel = arrgs_KnowledgesGraph_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_KnowledgesGraph_Sel = arrgs_KnowledgesGraph_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_KnowledgesGraph_Sel = arrgs_KnowledgesGraph_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_KnowledgesGraph_Sel = arrgs_KnowledgesGraph_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrgs_KnowledgesGraph_Sel.length == 0) return arrgs_KnowledgesGraph_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrgs_KnowledgesGraph_Sel = arrgs_KnowledgesGraph_Sel.sort(gs_KnowledgesGraph_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrgs_KnowledgesGraph_Sel = arrgs_KnowledgesGraph_Sel.sort(objPagerPara.sortFun);
}
arrgs_KnowledgesGraph_Sel = arrgs_KnowledgesGraph_Sel.slice(intStart, intEnd);     
return arrgs_KnowledgesGraph_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, gs_KnowledgesGraph_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsgs_KnowledgesGraphEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function gs_KnowledgesGraph_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsgs_KnowledgesGraphEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(gs_KnowledgesGraph_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_KnowledgesGraph_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_KnowledgesGraph_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_KnowledgesGraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_KnowledgesGraph_ConstructorName, strThisFuncName);
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
 * @param strKnowledgeGraphId:关键字
 * @returns 获取删除的结果
 **/
export async function gs_KnowledgesGraph_DelRecordAsync(strKnowledgeGraphId: string): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(gs_KnowledgesGraph_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, strKnowledgeGraphId);
try
{
const response = await axios.delete(strUrl,
{
params: { "Id": strKnowledgeGraphId, }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_KnowledgesGraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_KnowledgesGraph_ConstructorName, strThisFuncName);
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
 * @param arrKnowledgeGraphId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function gs_KnowledgesGraph_Delgs_KnowledgesGraphsAsync(arrKnowledgeGraphId: Array<string>): Promise<number> 
{
const strThisFuncName = "Delgs_KnowledgesGraphsAsync";
const strAction = "Delgs_KnowledgesGraphs";
const strUrl = GetWebApiUrl(gs_KnowledgesGraph_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrKnowledgeGraphId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_KnowledgesGraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_KnowledgesGraph_ConstructorName, strThisFuncName);
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
export async function gs_KnowledgesGraph_Delgs_KnowledgesGraphsByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "Delgs_KnowledgesGraphsByCondAsync";
const strAction = "Delgs_KnowledgesGraphsByCond";
const strUrl = GetWebApiUrl(gs_KnowledgesGraph_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_KnowledgesGraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_KnowledgesGraph_ConstructorName, strThisFuncName);
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
 * @param objgs_KnowledgesGraphEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_KnowledgesGraph_AddNewRecordAsync(objgs_KnowledgesGraphEN: clsgs_KnowledgesGraphEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objgs_KnowledgesGraphEN);
const strUrl = GetWebApiUrl(gs_KnowledgesGraph_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_KnowledgesGraphEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_KnowledgesGraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_KnowledgesGraph_ConstructorName, strThisFuncName);
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
 * @param objgs_KnowledgesGraphEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_KnowledgesGraph_AddNewRecordWithMaxIdAsync(objgs_KnowledgesGraphEN: clsgs_KnowledgesGraphEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithMaxIdAsync";
const strAction = "AddNewRecordWithMaxId";
const strUrl = GetWebApiUrl(gs_KnowledgesGraph_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_KnowledgesGraphEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_KnowledgesGraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_KnowledgesGraph_ConstructorName, strThisFuncName);
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
 * @param objgs_KnowledgesGraphEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function gs_KnowledgesGraph_AddNewRecordWithReturnKeyAsync(objgs_KnowledgesGraphEN: clsgs_KnowledgesGraphEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(gs_KnowledgesGraph_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_KnowledgesGraphEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_KnowledgesGraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_KnowledgesGraph_ConstructorName, strThisFuncName);
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
 * @param objgs_KnowledgesGraphEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function gs_KnowledgesGraph_AddNewRecordWithReturnKey(objgs_KnowledgesGraphEN: clsgs_KnowledgesGraphEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objgs_KnowledgesGraphEN.knowledgeGraphId === null || objgs_KnowledgesGraphEN.knowledgeGraphId === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(gs_KnowledgesGraph_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_KnowledgesGraphEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_KnowledgesGraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_KnowledgesGraph_ConstructorName, strThisFuncName);
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
 * @param objgs_KnowledgesGraphEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function gs_KnowledgesGraph_UpdateRecordAsync(objgs_KnowledgesGraphEN: clsgs_KnowledgesGraphEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objgs_KnowledgesGraphEN.sf_UpdFldSetStr === undefined || objgs_KnowledgesGraphEN.sf_UpdFldSetStr === null || objgs_KnowledgesGraphEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_KnowledgesGraphEN.knowledgeGraphId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(gs_KnowledgesGraph_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_KnowledgesGraphEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_KnowledgesGraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_KnowledgesGraph_ConstructorName, strThisFuncName);
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
 * @param objgs_KnowledgesGraphEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function gs_KnowledgesGraph_UpdateWithConditionAsync(objgs_KnowledgesGraphEN: clsgs_KnowledgesGraphEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objgs_KnowledgesGraphEN.sf_UpdFldSetStr === undefined || objgs_KnowledgesGraphEN.sf_UpdFldSetStr === null || objgs_KnowledgesGraphEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_KnowledgesGraphEN.knowledgeGraphId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(gs_KnowledgesGraph_Controller, strAction);
objgs_KnowledgesGraphEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objgs_KnowledgesGraphEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_KnowledgesGraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_KnowledgesGraph_ConstructorName, strThisFuncName);
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
 * @param objstrKnowledgeGraphId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function gs_KnowledgesGraph_IsExistRecord_Cache(objgs_KnowledgesGraph_Cond: clsgs_KnowledgesGraphEN,strCourseId: string) {
const strThisFuncName = "IsExistRecord_Cache";
const arrgs_KnowledgesGraphObjLst_Cache = await gs_KnowledgesGraph_GetObjLst_Cache(strCourseId);
if (arrgs_KnowledgesGraphObjLst_Cache == null) return false;
let arrgs_KnowledgesGraph_Sel: Array < clsgs_KnowledgesGraphEN > = arrgs_KnowledgesGraphObjLst_Cache;
if (objgs_KnowledgesGraph_Cond.sf_FldComparisonOp == null || objgs_KnowledgesGraph_Cond.sf_FldComparisonOp == "") return arrgs_KnowledgesGraph_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_KnowledgesGraph_Cond.sf_FldComparisonOp);
//console.log("clsgs_KnowledgesGraphWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objgs_KnowledgesGraph_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_KnowledgesGraph_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_KnowledgesGraph_Sel = arrgs_KnowledgesGraph_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_KnowledgesGraph_Sel = arrgs_KnowledgesGraph_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_KnowledgesGraph_Sel = arrgs_KnowledgesGraph_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_KnowledgesGraph_Sel = arrgs_KnowledgesGraph_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_KnowledgesGraph_Sel = arrgs_KnowledgesGraph_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_KnowledgesGraph_Sel = arrgs_KnowledgesGraph_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_KnowledgesGraph_Sel = arrgs_KnowledgesGraph_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_KnowledgesGraph_Sel = arrgs_KnowledgesGraph_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrgs_KnowledgesGraph_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objgs_KnowledgesGraph_Cond), gs_KnowledgesGraph_ConstructorName, strThisFuncName);
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
export async function gs_KnowledgesGraph_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(gs_KnowledgesGraph_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_KnowledgesGraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_KnowledgesGraph_ConstructorName, strThisFuncName);
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
 * @param strKnowledgeGraphId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function gs_KnowledgesGraph_IsExist(strKnowledgeGraphId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(gs_KnowledgesGraph_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"KnowledgeGraphId": strKnowledgeGraphId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_KnowledgesGraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_KnowledgesGraph_ConstructorName, strThisFuncName);
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
 * @param strKnowledgeGraphId:所给的关键字
 * @returns 对象
*/
export async function gs_KnowledgesGraph_IsExist_Cache(strKnowledgeGraphId:string,strCourseId:string) {
const strThisFuncName = "IsExist_Cache";
const arrgs_KnowledgesGraphObjLst_Cache = await gs_KnowledgesGraph_GetObjLst_Cache(strCourseId);
if (arrgs_KnowledgesGraphObjLst_Cache == null) return false;
try
{
const arrgs_KnowledgesGraph_Sel: Array <clsgs_KnowledgesGraphEN> = arrgs_KnowledgesGraphObjLst_Cache.filter(x => x.knowledgeGraphId == strKnowledgeGraphId);
if (arrgs_KnowledgesGraph_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strKnowledgeGraphId, gs_KnowledgesGraph_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param strKnowledgeGraphId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function gs_KnowledgesGraph_IsExistAsync(strKnowledgeGraphId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(gs_KnowledgesGraph_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strKnowledgeGraphId": strKnowledgeGraphId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_KnowledgesGraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_KnowledgesGraph_ConstructorName, strThisFuncName);
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
export async function gs_KnowledgesGraph_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(gs_KnowledgesGraph_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_KnowledgesGraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_KnowledgesGraph_ConstructorName, strThisFuncName);
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
 * @param objgs_KnowledgesGraph_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function gs_KnowledgesGraph_GetRecCountByCond_Cache(objgs_KnowledgesGraph_Cond: clsgs_KnowledgesGraphEN,strCourseId: string) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrgs_KnowledgesGraphObjLst_Cache = await gs_KnowledgesGraph_GetObjLst_Cache(strCourseId);
if (arrgs_KnowledgesGraphObjLst_Cache == null) return 0;
let arrgs_KnowledgesGraph_Sel: Array < clsgs_KnowledgesGraphEN > = arrgs_KnowledgesGraphObjLst_Cache;
if (objgs_KnowledgesGraph_Cond.sf_FldComparisonOp == null || objgs_KnowledgesGraph_Cond.sf_FldComparisonOp == "") return arrgs_KnowledgesGraph_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_KnowledgesGraph_Cond.sf_FldComparisonOp);
//console.log("clsgs_KnowledgesGraphWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objgs_KnowledgesGraph_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrgs_KnowledgesGraph_Sel = arrgs_KnowledgesGraph_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_KnowledgesGraph_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_KnowledgesGraph_Sel = arrgs_KnowledgesGraph_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_KnowledgesGraph_Sel = arrgs_KnowledgesGraph_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrgs_KnowledgesGraph_Sel = arrgs_KnowledgesGraph_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_KnowledgesGraph_Sel = arrgs_KnowledgesGraph_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_KnowledgesGraph_Sel = arrgs_KnowledgesGraph_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_KnowledgesGraph_Sel = arrgs_KnowledgesGraph_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_KnowledgesGraph_Sel = arrgs_KnowledgesGraph_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_KnowledgesGraph_Sel = arrgs_KnowledgesGraph_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_KnowledgesGraph_Sel = arrgs_KnowledgesGraph_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrgs_KnowledgesGraph_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objgs_KnowledgesGraph_Cond), gs_KnowledgesGraph_ConstructorName, strThisFuncName);
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
export async function gs_KnowledgesGraph_GetMaxStrIdAsync(): Promise<string>  
{
const strThisFuncName = "GetMaxStrIdAsync";
const strAction = "GetMaxStrId";
const strUrl = GetWebApiUrl(gs_KnowledgesGraph_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_KnowledgesGraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_KnowledgesGraph_ConstructorName, strThisFuncName);
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
export async function gs_KnowledgesGraph_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(gs_KnowledgesGraph_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_KnowledgesGraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_KnowledgesGraph_ConstructorName, strThisFuncName);
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
export function gs_KnowledgesGraph_GetWebApiUrl(strController: string, strAction: string): string {
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
export function gs_KnowledgesGraph_ReFreshCache(strCourseId: string):void
{
const strThisFuncName = "ReFreshCache";

if (IsNullOrEmpty(strCourseId) == true)
{
  const strMsg = Format("参数:[strCourseId]不能为空！(In clsgs_KnowledgesGraphWApi.ReFreshCache)");
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
const strKey = Format("{0}_{1}", clsgs_KnowledgesGraphEN._CurrTabName, strCourseId);
switch (clsgs_KnowledgesGraphEN.CacheModeId)
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
export function gs_KnowledgesGraph_ReFreshThisCache(strCourseId: string):void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = Format("{0}_{1}", clsgs_KnowledgesGraphEN._CurrTabName, strCourseId);
switch (clsgs_KnowledgesGraphEN.CacheModeId)
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
export async function gs_KnowledgesGraph__Cache(strDivName: string, strDdlName: string , strCourseId: string)
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
const arrObjLst_Sel = await gs_KnowledgesGraph_GetObjLst_Cache(strCourseId);
if (arrObjLst_Sel == null) return;
BindDdl_ObjLstInDiv(strDivName, strDdlName, arrObjLst_Sel, clsgs_KnowledgesGraphEN.con_KnowledgeGraphId, clsgs_KnowledgesGraphEN.con_KnowledgeGraphName, "知识点逻辑图");
}

/**
 * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function gs_KnowledgesGraph_CheckPropertyNew(pobjgs_KnowledgesGraphEN: clsgs_KnowledgesGraphEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjgs_KnowledgesGraphEN.knowledgeGraphId) == false && GetStrLen(pobjgs_KnowledgesGraphEN.knowledgeGraphId) > 10)
{
 throw new Error("(errid:Watl000059)字段[知识点图Id(knowledgeGraphId)]的长度不能超过10(In 知识点逻辑图(gs_KnowledgesGraph))!值:$(pobjgs_KnowledgesGraphEN.knowledgeGraphId)(clsgs_KnowledgesGraphBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_KnowledgesGraphEN.knowledgeGraphName) == false && GetStrLen(pobjgs_KnowledgesGraphEN.knowledgeGraphName) > 100)
{
 throw new Error("(errid:Watl000059)字段[连连看图名(knowledgeGraphName)]的长度不能超过100(In 知识点逻辑图(gs_KnowledgesGraph))!值:$(pobjgs_KnowledgesGraphEN.knowledgeGraphName)(clsgs_KnowledgesGraphBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_KnowledgesGraphEN.id_CurrEduCls) == false && GetStrLen(pobjgs_KnowledgesGraphEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 知识点逻辑图(gs_KnowledgesGraph))!值:$(pobjgs_KnowledgesGraphEN.id_CurrEduCls)(clsgs_KnowledgesGraphBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_KnowledgesGraphEN.courseId) == false && GetStrLen(pobjgs_KnowledgesGraphEN.courseId) > 8)
{
 throw new Error("(errid:Watl000059)字段[课程Id(courseId)]的长度不能超过8(In 知识点逻辑图(gs_KnowledgesGraph))!值:$(pobjgs_KnowledgesGraphEN.courseId)(clsgs_KnowledgesGraphBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_KnowledgesGraphEN.createUser) == false && GetStrLen(pobjgs_KnowledgesGraphEN.createUser) > 50)
{
 throw new Error("(errid:Watl000059)字段[建立用户(createUser)]的长度不能超过50(In 知识点逻辑图(gs_KnowledgesGraph))!值:$(pobjgs_KnowledgesGraphEN.createUser)(clsgs_KnowledgesGraphBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_KnowledgesGraphEN.updDate) == false && GetStrLen(pobjgs_KnowledgesGraphEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 知识点逻辑图(gs_KnowledgesGraph))!值:$(pobjgs_KnowledgesGraphEN.updDate)(clsgs_KnowledgesGraphBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_KnowledgesGraphEN.updUser) == false && GetStrLen(pobjgs_KnowledgesGraphEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 知识点逻辑图(gs_KnowledgesGraph))!值:$(pobjgs_KnowledgesGraphEN.updUser)(clsgs_KnowledgesGraphBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_KnowledgesGraphEN.memo) == false && GetStrLen(pobjgs_KnowledgesGraphEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 知识点逻辑图(gs_KnowledgesGraph))!值:$(pobjgs_KnowledgesGraphEN.memo)(clsgs_KnowledgesGraphBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_KnowledgesGraphEN.graphTypeId) == false && GetStrLen(pobjgs_KnowledgesGraphEN.graphTypeId) > 2)
{
 throw new Error("(errid:Watl000059)字段[图谱类型Id(graphTypeId)]的长度不能超过2(In 知识点逻辑图(gs_KnowledgesGraph))!值:$(pobjgs_KnowledgesGraphEN.graphTypeId)(clsgs_KnowledgesGraphBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_KnowledgesGraphEN.startTime) == false && GetStrLen(pobjgs_KnowledgesGraphEN.startTime) > 20)
{
 throw new Error("(errid:Watl000059)字段[开始时间(startTime)]的长度不能超过20(In 知识点逻辑图(gs_KnowledgesGraph))!值:$(pobjgs_KnowledgesGraphEN.startTime)(clsgs_KnowledgesGraphBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_KnowledgesGraphEN.submitTime) == false && GetStrLen(pobjgs_KnowledgesGraphEN.submitTime) > 20)
{
 throw new Error("(errid:Watl000059)字段[提交时间(submitTime)]的长度不能超过20(In 知识点逻辑图(gs_KnowledgesGraph))!值:$(pobjgs_KnowledgesGraphEN.submitTime)(clsgs_KnowledgesGraphBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_KnowledgesGraphEN.eduClassName) == false && GetStrLen(pobjgs_KnowledgesGraphEN.eduClassName) > 20)
{
 throw new Error("(errid:Watl000059)字段[教学班(eduClassName)]的长度不能超过20(In 知识点逻辑图(gs_KnowledgesGraph))!值:$(pobjgs_KnowledgesGraphEN.eduClassName)(clsgs_KnowledgesGraphBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_KnowledgesGraphEN.courseName) == false && GetStrLen(pobjgs_KnowledgesGraphEN.courseName) > 100)
{
 throw new Error("(errid:Watl000059)字段[课程名称(courseName)]的长度不能超过100(In 知识点逻辑图(gs_KnowledgesGraph))!值:$(pobjgs_KnowledgesGraphEN.courseName)(clsgs_KnowledgesGraphBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjgs_KnowledgesGraphEN.knowledgeGraphId) == false && undefined !== pobjgs_KnowledgesGraphEN.knowledgeGraphId && tzDataType.isString(pobjgs_KnowledgesGraphEN.knowledgeGraphId) === false)
{
 throw new Error("(errid:Watl000060)字段[知识点图Id(knowledgeGraphId)]的值:[$(pobjgs_KnowledgesGraphEN.knowledgeGraphId)], 非法，应该为字符型(In 知识点逻辑图(gs_KnowledgesGraph))!(clsgs_KnowledgesGraphBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_KnowledgesGraphEN.knowledgeGraphName) == false && undefined !== pobjgs_KnowledgesGraphEN.knowledgeGraphName && tzDataType.isString(pobjgs_KnowledgesGraphEN.knowledgeGraphName) === false)
{
 throw new Error("(errid:Watl000060)字段[连连看图名(knowledgeGraphName)]的值:[$(pobjgs_KnowledgesGraphEN.knowledgeGraphName)], 非法，应该为字符型(In 知识点逻辑图(gs_KnowledgesGraph))!(clsgs_KnowledgesGraphBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_KnowledgesGraphEN.id_CurrEduCls) == false && undefined !== pobjgs_KnowledgesGraphEN.id_CurrEduCls && tzDataType.isString(pobjgs_KnowledgesGraphEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjgs_KnowledgesGraphEN.id_CurrEduCls)], 非法，应该为字符型(In 知识点逻辑图(gs_KnowledgesGraph))!(clsgs_KnowledgesGraphBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_KnowledgesGraphEN.courseId) == false && undefined !== pobjgs_KnowledgesGraphEN.courseId && tzDataType.isString(pobjgs_KnowledgesGraphEN.courseId) === false)
{
 throw new Error("(errid:Watl000060)字段[课程Id(courseId)]的值:[$(pobjgs_KnowledgesGraphEN.courseId)], 非法，应该为字符型(In 知识点逻辑图(gs_KnowledgesGraph))!(clsgs_KnowledgesGraphBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_KnowledgesGraphEN.createUser) == false && undefined !== pobjgs_KnowledgesGraphEN.createUser && tzDataType.isString(pobjgs_KnowledgesGraphEN.createUser) === false)
{
 throw new Error("(errid:Watl000060)字段[建立用户(createUser)]的值:[$(pobjgs_KnowledgesGraphEN.createUser)], 非法，应该为字符型(In 知识点逻辑图(gs_KnowledgesGraph))!(clsgs_KnowledgesGraphBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_KnowledgesGraphEN.updDate) == false && undefined !== pobjgs_KnowledgesGraphEN.updDate && tzDataType.isString(pobjgs_KnowledgesGraphEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjgs_KnowledgesGraphEN.updDate)], 非法，应该为字符型(In 知识点逻辑图(gs_KnowledgesGraph))!(clsgs_KnowledgesGraphBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_KnowledgesGraphEN.updUser) == false && undefined !== pobjgs_KnowledgesGraphEN.updUser && tzDataType.isString(pobjgs_KnowledgesGraphEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjgs_KnowledgesGraphEN.updUser)], 非法，应该为字符型(In 知识点逻辑图(gs_KnowledgesGraph))!(clsgs_KnowledgesGraphBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_KnowledgesGraphEN.memo) == false && undefined !== pobjgs_KnowledgesGraphEN.memo && tzDataType.isString(pobjgs_KnowledgesGraphEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjgs_KnowledgesGraphEN.memo)], 非法，应该为字符型(In 知识点逻辑图(gs_KnowledgesGraph))!(clsgs_KnowledgesGraphBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_KnowledgesGraphEN.graphTypeId) == false && undefined !== pobjgs_KnowledgesGraphEN.graphTypeId && tzDataType.isString(pobjgs_KnowledgesGraphEN.graphTypeId) === false)
{
 throw new Error("(errid:Watl000060)字段[图谱类型Id(graphTypeId)]的值:[$(pobjgs_KnowledgesGraphEN.graphTypeId)], 非法，应该为字符型(In 知识点逻辑图(gs_KnowledgesGraph))!(clsgs_KnowledgesGraphBL:CheckPropertyNew)");
}
if (null != pobjgs_KnowledgesGraphEN.isDisplay && undefined !== pobjgs_KnowledgesGraphEN.isDisplay && tzDataType.isBoolean(pobjgs_KnowledgesGraphEN.isDisplay) === false)
{
 throw new Error("(errid:Watl000060)字段[是否显示(isDisplay)]的值:[$(pobjgs_KnowledgesGraphEN.isDisplay)], 非法，应该为布尔型(In 知识点逻辑图(gs_KnowledgesGraph))!(clsgs_KnowledgesGraphBL:CheckPropertyNew)");
}
if (null != pobjgs_KnowledgesGraphEN.isExtend && undefined !== pobjgs_KnowledgesGraphEN.isExtend && tzDataType.isBoolean(pobjgs_KnowledgesGraphEN.isExtend) === false)
{
 throw new Error("(errid:Watl000060)字段[是否扩展(isExtend)]的值:[$(pobjgs_KnowledgesGraphEN.isExtend)], 非法，应该为布尔型(In 知识点逻辑图(gs_KnowledgesGraph))!(clsgs_KnowledgesGraphBL:CheckPropertyNew)");
}
if (null != pobjgs_KnowledgesGraphEN.isRecommend && undefined !== pobjgs_KnowledgesGraphEN.isRecommend && tzDataType.isBoolean(pobjgs_KnowledgesGraphEN.isRecommend) === false)
{
 throw new Error("(errid:Watl000060)字段[是否推荐(isRecommend)]的值:[$(pobjgs_KnowledgesGraphEN.isRecommend)], 非法，应该为布尔型(In 知识点逻辑图(gs_KnowledgesGraph))!(clsgs_KnowledgesGraphBL:CheckPropertyNew)");
}
if (null != pobjgs_KnowledgesGraphEN.isAnswer && undefined !== pobjgs_KnowledgesGraphEN.isAnswer && tzDataType.isBoolean(pobjgs_KnowledgesGraphEN.isAnswer) === false)
{
 throw new Error("(errid:Watl000060)字段[是否回答(isAnswer)]的值:[$(pobjgs_KnowledgesGraphEN.isAnswer)], 非法，应该为布尔型(In 知识点逻辑图(gs_KnowledgesGraph))!(clsgs_KnowledgesGraphBL:CheckPropertyNew)");
}
if (null != pobjgs_KnowledgesGraphEN.isSubmit && undefined !== pobjgs_KnowledgesGraphEN.isSubmit && tzDataType.isBoolean(pobjgs_KnowledgesGraphEN.isSubmit) === false)
{
 throw new Error("(errid:Watl000060)字段[是否提交(isSubmit)]的值:[$(pobjgs_KnowledgesGraphEN.isSubmit)], 非法，应该为布尔型(In 知识点逻辑图(gs_KnowledgesGraph))!(clsgs_KnowledgesGraphBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_KnowledgesGraphEN.startTime) == false && undefined !== pobjgs_KnowledgesGraphEN.startTime && tzDataType.isString(pobjgs_KnowledgesGraphEN.startTime) === false)
{
 throw new Error("(errid:Watl000060)字段[开始时间(startTime)]的值:[$(pobjgs_KnowledgesGraphEN.startTime)], 非法，应该为字符型(In 知识点逻辑图(gs_KnowledgesGraph))!(clsgs_KnowledgesGraphBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_KnowledgesGraphEN.submitTime) == false && undefined !== pobjgs_KnowledgesGraphEN.submitTime && tzDataType.isString(pobjgs_KnowledgesGraphEN.submitTime) === false)
{
 throw new Error("(errid:Watl000060)字段[提交时间(submitTime)]的值:[$(pobjgs_KnowledgesGraphEN.submitTime)], 非法，应该为字符型(In 知识点逻辑图(gs_KnowledgesGraph))!(clsgs_KnowledgesGraphBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_KnowledgesGraphEN.eduClassName) == false && undefined !== pobjgs_KnowledgesGraphEN.eduClassName && tzDataType.isString(pobjgs_KnowledgesGraphEN.eduClassName) === false)
{
 throw new Error("(errid:Watl000060)字段[教学班(eduClassName)]的值:[$(pobjgs_KnowledgesGraphEN.eduClassName)], 非法，应该为字符型(In 知识点逻辑图(gs_KnowledgesGraph))!(clsgs_KnowledgesGraphBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_KnowledgesGraphEN.courseName) == false && undefined !== pobjgs_KnowledgesGraphEN.courseName && tzDataType.isString(pobjgs_KnowledgesGraphEN.courseName) === false)
{
 throw new Error("(errid:Watl000060)字段[课程名称(courseName)]的值:[$(pobjgs_KnowledgesGraphEN.courseName)], 非法，应该为字符型(In 知识点逻辑图(gs_KnowledgesGraph))!(clsgs_KnowledgesGraphBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjgs_KnowledgesGraphEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function gs_KnowledgesGraph_CheckProperty4Update (pobjgs_KnowledgesGraphEN: clsgs_KnowledgesGraphEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjgs_KnowledgesGraphEN.knowledgeGraphId) == false && GetStrLen(pobjgs_KnowledgesGraphEN.knowledgeGraphId) > 10)
{
 throw new Error("(errid:Watl000062)字段[知识点图Id(knowledgeGraphId)]的长度不能超过10(In 知识点逻辑图(gs_KnowledgesGraph))!值:$(pobjgs_KnowledgesGraphEN.knowledgeGraphId)(clsgs_KnowledgesGraphBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_KnowledgesGraphEN.knowledgeGraphName) == false && GetStrLen(pobjgs_KnowledgesGraphEN.knowledgeGraphName) > 100)
{
 throw new Error("(errid:Watl000062)字段[连连看图名(knowledgeGraphName)]的长度不能超过100(In 知识点逻辑图(gs_KnowledgesGraph))!值:$(pobjgs_KnowledgesGraphEN.knowledgeGraphName)(clsgs_KnowledgesGraphBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_KnowledgesGraphEN.id_CurrEduCls) == false && GetStrLen(pobjgs_KnowledgesGraphEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 知识点逻辑图(gs_KnowledgesGraph))!值:$(pobjgs_KnowledgesGraphEN.id_CurrEduCls)(clsgs_KnowledgesGraphBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_KnowledgesGraphEN.courseId) == false && GetStrLen(pobjgs_KnowledgesGraphEN.courseId) > 8)
{
 throw new Error("(errid:Watl000062)字段[课程Id(courseId)]的长度不能超过8(In 知识点逻辑图(gs_KnowledgesGraph))!值:$(pobjgs_KnowledgesGraphEN.courseId)(clsgs_KnowledgesGraphBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_KnowledgesGraphEN.createUser) == false && GetStrLen(pobjgs_KnowledgesGraphEN.createUser) > 50)
{
 throw new Error("(errid:Watl000062)字段[建立用户(createUser)]的长度不能超过50(In 知识点逻辑图(gs_KnowledgesGraph))!值:$(pobjgs_KnowledgesGraphEN.createUser)(clsgs_KnowledgesGraphBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_KnowledgesGraphEN.updDate) == false && GetStrLen(pobjgs_KnowledgesGraphEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 知识点逻辑图(gs_KnowledgesGraph))!值:$(pobjgs_KnowledgesGraphEN.updDate)(clsgs_KnowledgesGraphBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_KnowledgesGraphEN.updUser) == false && GetStrLen(pobjgs_KnowledgesGraphEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 知识点逻辑图(gs_KnowledgesGraph))!值:$(pobjgs_KnowledgesGraphEN.updUser)(clsgs_KnowledgesGraphBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_KnowledgesGraphEN.memo) == false && GetStrLen(pobjgs_KnowledgesGraphEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 知识点逻辑图(gs_KnowledgesGraph))!值:$(pobjgs_KnowledgesGraphEN.memo)(clsgs_KnowledgesGraphBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_KnowledgesGraphEN.graphTypeId) == false && GetStrLen(pobjgs_KnowledgesGraphEN.graphTypeId) > 2)
{
 throw new Error("(errid:Watl000062)字段[图谱类型Id(graphTypeId)]的长度不能超过2(In 知识点逻辑图(gs_KnowledgesGraph))!值:$(pobjgs_KnowledgesGraphEN.graphTypeId)(clsgs_KnowledgesGraphBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_KnowledgesGraphEN.startTime) == false && GetStrLen(pobjgs_KnowledgesGraphEN.startTime) > 20)
{
 throw new Error("(errid:Watl000062)字段[开始时间(startTime)]的长度不能超过20(In 知识点逻辑图(gs_KnowledgesGraph))!值:$(pobjgs_KnowledgesGraphEN.startTime)(clsgs_KnowledgesGraphBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_KnowledgesGraphEN.submitTime) == false && GetStrLen(pobjgs_KnowledgesGraphEN.submitTime) > 20)
{
 throw new Error("(errid:Watl000062)字段[提交时间(submitTime)]的长度不能超过20(In 知识点逻辑图(gs_KnowledgesGraph))!值:$(pobjgs_KnowledgesGraphEN.submitTime)(clsgs_KnowledgesGraphBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_KnowledgesGraphEN.eduClassName) == false && GetStrLen(pobjgs_KnowledgesGraphEN.eduClassName) > 20)
{
 throw new Error("(errid:Watl000062)字段[教学班(eduClassName)]的长度不能超过20(In 知识点逻辑图(gs_KnowledgesGraph))!值:$(pobjgs_KnowledgesGraphEN.eduClassName)(clsgs_KnowledgesGraphBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_KnowledgesGraphEN.courseName) == false && GetStrLen(pobjgs_KnowledgesGraphEN.courseName) > 100)
{
 throw new Error("(errid:Watl000062)字段[课程名称(courseName)]的长度不能超过100(In 知识点逻辑图(gs_KnowledgesGraph))!值:$(pobjgs_KnowledgesGraphEN.courseName)(clsgs_KnowledgesGraphBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjgs_KnowledgesGraphEN.knowledgeGraphId) == false && undefined !== pobjgs_KnowledgesGraphEN.knowledgeGraphId && tzDataType.isString(pobjgs_KnowledgesGraphEN.knowledgeGraphId) === false)
{
 throw new Error("(errid:Watl000063)字段[知识点图Id(knowledgeGraphId)]的值:[$(pobjgs_KnowledgesGraphEN.knowledgeGraphId)], 非法，应该为字符型(In 知识点逻辑图(gs_KnowledgesGraph))!(clsgs_KnowledgesGraphBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_KnowledgesGraphEN.knowledgeGraphName) == false && undefined !== pobjgs_KnowledgesGraphEN.knowledgeGraphName && tzDataType.isString(pobjgs_KnowledgesGraphEN.knowledgeGraphName) === false)
{
 throw new Error("(errid:Watl000063)字段[连连看图名(knowledgeGraphName)]的值:[$(pobjgs_KnowledgesGraphEN.knowledgeGraphName)], 非法，应该为字符型(In 知识点逻辑图(gs_KnowledgesGraph))!(clsgs_KnowledgesGraphBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_KnowledgesGraphEN.id_CurrEduCls) == false && undefined !== pobjgs_KnowledgesGraphEN.id_CurrEduCls && tzDataType.isString(pobjgs_KnowledgesGraphEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjgs_KnowledgesGraphEN.id_CurrEduCls)], 非法，应该为字符型(In 知识点逻辑图(gs_KnowledgesGraph))!(clsgs_KnowledgesGraphBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_KnowledgesGraphEN.courseId) == false && undefined !== pobjgs_KnowledgesGraphEN.courseId && tzDataType.isString(pobjgs_KnowledgesGraphEN.courseId) === false)
{
 throw new Error("(errid:Watl000063)字段[课程Id(courseId)]的值:[$(pobjgs_KnowledgesGraphEN.courseId)], 非法，应该为字符型(In 知识点逻辑图(gs_KnowledgesGraph))!(clsgs_KnowledgesGraphBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_KnowledgesGraphEN.createUser) == false && undefined !== pobjgs_KnowledgesGraphEN.createUser && tzDataType.isString(pobjgs_KnowledgesGraphEN.createUser) === false)
{
 throw new Error("(errid:Watl000063)字段[建立用户(createUser)]的值:[$(pobjgs_KnowledgesGraphEN.createUser)], 非法，应该为字符型(In 知识点逻辑图(gs_KnowledgesGraph))!(clsgs_KnowledgesGraphBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_KnowledgesGraphEN.updDate) == false && undefined !== pobjgs_KnowledgesGraphEN.updDate && tzDataType.isString(pobjgs_KnowledgesGraphEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjgs_KnowledgesGraphEN.updDate)], 非法，应该为字符型(In 知识点逻辑图(gs_KnowledgesGraph))!(clsgs_KnowledgesGraphBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_KnowledgesGraphEN.updUser) == false && undefined !== pobjgs_KnowledgesGraphEN.updUser && tzDataType.isString(pobjgs_KnowledgesGraphEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjgs_KnowledgesGraphEN.updUser)], 非法，应该为字符型(In 知识点逻辑图(gs_KnowledgesGraph))!(clsgs_KnowledgesGraphBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_KnowledgesGraphEN.memo) == false && undefined !== pobjgs_KnowledgesGraphEN.memo && tzDataType.isString(pobjgs_KnowledgesGraphEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjgs_KnowledgesGraphEN.memo)], 非法，应该为字符型(In 知识点逻辑图(gs_KnowledgesGraph))!(clsgs_KnowledgesGraphBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_KnowledgesGraphEN.graphTypeId) == false && undefined !== pobjgs_KnowledgesGraphEN.graphTypeId && tzDataType.isString(pobjgs_KnowledgesGraphEN.graphTypeId) === false)
{
 throw new Error("(errid:Watl000063)字段[图谱类型Id(graphTypeId)]的值:[$(pobjgs_KnowledgesGraphEN.graphTypeId)], 非法，应该为字符型(In 知识点逻辑图(gs_KnowledgesGraph))!(clsgs_KnowledgesGraphBL:CheckProperty4Update)");
}
if (null != pobjgs_KnowledgesGraphEN.isDisplay && undefined !== pobjgs_KnowledgesGraphEN.isDisplay && tzDataType.isBoolean(pobjgs_KnowledgesGraphEN.isDisplay) === false)
{
 throw new Error("(errid:Watl000063)字段[是否显示(isDisplay)]的值:[$(pobjgs_KnowledgesGraphEN.isDisplay)], 非法，应该为布尔型(In 知识点逻辑图(gs_KnowledgesGraph))!(clsgs_KnowledgesGraphBL:CheckProperty4Update)");
}
if (null != pobjgs_KnowledgesGraphEN.isExtend && undefined !== pobjgs_KnowledgesGraphEN.isExtend && tzDataType.isBoolean(pobjgs_KnowledgesGraphEN.isExtend) === false)
{
 throw new Error("(errid:Watl000063)字段[是否扩展(isExtend)]的值:[$(pobjgs_KnowledgesGraphEN.isExtend)], 非法，应该为布尔型(In 知识点逻辑图(gs_KnowledgesGraph))!(clsgs_KnowledgesGraphBL:CheckProperty4Update)");
}
if (null != pobjgs_KnowledgesGraphEN.isRecommend && undefined !== pobjgs_KnowledgesGraphEN.isRecommend && tzDataType.isBoolean(pobjgs_KnowledgesGraphEN.isRecommend) === false)
{
 throw new Error("(errid:Watl000063)字段[是否推荐(isRecommend)]的值:[$(pobjgs_KnowledgesGraphEN.isRecommend)], 非法，应该为布尔型(In 知识点逻辑图(gs_KnowledgesGraph))!(clsgs_KnowledgesGraphBL:CheckProperty4Update)");
}
if (null != pobjgs_KnowledgesGraphEN.isAnswer && undefined !== pobjgs_KnowledgesGraphEN.isAnswer && tzDataType.isBoolean(pobjgs_KnowledgesGraphEN.isAnswer) === false)
{
 throw new Error("(errid:Watl000063)字段[是否回答(isAnswer)]的值:[$(pobjgs_KnowledgesGraphEN.isAnswer)], 非法，应该为布尔型(In 知识点逻辑图(gs_KnowledgesGraph))!(clsgs_KnowledgesGraphBL:CheckProperty4Update)");
}
if (null != pobjgs_KnowledgesGraphEN.isSubmit && undefined !== pobjgs_KnowledgesGraphEN.isSubmit && tzDataType.isBoolean(pobjgs_KnowledgesGraphEN.isSubmit) === false)
{
 throw new Error("(errid:Watl000063)字段[是否提交(isSubmit)]的值:[$(pobjgs_KnowledgesGraphEN.isSubmit)], 非法，应该为布尔型(In 知识点逻辑图(gs_KnowledgesGraph))!(clsgs_KnowledgesGraphBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_KnowledgesGraphEN.startTime) == false && undefined !== pobjgs_KnowledgesGraphEN.startTime && tzDataType.isString(pobjgs_KnowledgesGraphEN.startTime) === false)
{
 throw new Error("(errid:Watl000063)字段[开始时间(startTime)]的值:[$(pobjgs_KnowledgesGraphEN.startTime)], 非法，应该为字符型(In 知识点逻辑图(gs_KnowledgesGraph))!(clsgs_KnowledgesGraphBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_KnowledgesGraphEN.submitTime) == false && undefined !== pobjgs_KnowledgesGraphEN.submitTime && tzDataType.isString(pobjgs_KnowledgesGraphEN.submitTime) === false)
{
 throw new Error("(errid:Watl000063)字段[提交时间(submitTime)]的值:[$(pobjgs_KnowledgesGraphEN.submitTime)], 非法，应该为字符型(In 知识点逻辑图(gs_KnowledgesGraph))!(clsgs_KnowledgesGraphBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_KnowledgesGraphEN.eduClassName) == false && undefined !== pobjgs_KnowledgesGraphEN.eduClassName && tzDataType.isString(pobjgs_KnowledgesGraphEN.eduClassName) === false)
{
 throw new Error("(errid:Watl000063)字段[教学班(eduClassName)]的值:[$(pobjgs_KnowledgesGraphEN.eduClassName)], 非法，应该为字符型(In 知识点逻辑图(gs_KnowledgesGraph))!(clsgs_KnowledgesGraphBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_KnowledgesGraphEN.courseName) == false && undefined !== pobjgs_KnowledgesGraphEN.courseName && tzDataType.isString(pobjgs_KnowledgesGraphEN.courseName) === false)
{
 throw new Error("(errid:Watl000063)字段[课程名称(courseName)]的值:[$(pobjgs_KnowledgesGraphEN.courseName)], 非法，应该为字符型(In 知识点逻辑图(gs_KnowledgesGraph))!(clsgs_KnowledgesGraphBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (IsNullOrEmpty(pobjgs_KnowledgesGraphEN.knowledgeGraphId) === true 
 || pobjgs_KnowledgesGraphEN.knowledgeGraphId.toString()  ===  "0" )
{
 throw new Error("(errid:Watl000064)字段[知识点图Id]不能为空(In 知识点逻辑图)!(clsgs_KnowledgesGraphBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjgs_KnowledgesGraphEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function gs_KnowledgesGraph_GetJSONStrByObj (pobjgs_KnowledgesGraphEN: clsgs_KnowledgesGraphEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjgs_KnowledgesGraphEN.sf_UpdFldSetStr = pobjgs_KnowledgesGraphEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjgs_KnowledgesGraphEN);
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
export function gs_KnowledgesGraph_GetObjLstByJSONStr (strJSON: string): Array<clsgs_KnowledgesGraphEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrgs_KnowledgesGraphObjLst = new Array<clsgs_KnowledgesGraphEN>();
if (strJSON === "")
{
return arrgs_KnowledgesGraphObjLst;
}
try
{
arrgs_KnowledgesGraphObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrgs_KnowledgesGraphObjLst;
}
return arrgs_KnowledgesGraphObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrgs_KnowledgesGraphObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function gs_KnowledgesGraph_GetObjLstByJSONObjLst (arrgs_KnowledgesGraphObjLstS: Array<clsgs_KnowledgesGraphEN>): Array<clsgs_KnowledgesGraphEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrgs_KnowledgesGraphObjLst = new Array<clsgs_KnowledgesGraphEN>();
for (const objInFor of arrgs_KnowledgesGraphObjLstS) {
const obj1 = gs_KnowledgesGraph_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrgs_KnowledgesGraphObjLst.push(obj1);
}
return arrgs_KnowledgesGraphObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function gs_KnowledgesGraph_GetObjByJSONStr (strJSON: string): clsgs_KnowledgesGraphEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjgs_KnowledgesGraphEN = new clsgs_KnowledgesGraphEN();
if (strJSON === "")
{
return pobjgs_KnowledgesGraphEN;
}
try
{
pobjgs_KnowledgesGraphEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjgs_KnowledgesGraphEN;
}
return pobjgs_KnowledgesGraphEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function gs_KnowledgesGraph_GetCombineCondition(objgs_KnowledgesGraph_Cond: clsgs_KnowledgesGraphEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objgs_KnowledgesGraph_Cond.dicFldComparisonOp, clsgs_KnowledgesGraphEN.con_KnowledgeGraphId) == true)
{
const strComparisonOp_KnowledgeGraphId:string = objgs_KnowledgesGraph_Cond.dicFldComparisonOp[clsgs_KnowledgesGraphEN.con_KnowledgeGraphId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_KnowledgesGraphEN.con_KnowledgeGraphId, objgs_KnowledgesGraph_Cond.knowledgeGraphId, strComparisonOp_KnowledgeGraphId);
}
if (Object.prototype.hasOwnProperty.call(objgs_KnowledgesGraph_Cond.dicFldComparisonOp, clsgs_KnowledgesGraphEN.con_KnowledgeGraphName) == true)
{
const strComparisonOp_KnowledgeGraphName:string = objgs_KnowledgesGraph_Cond.dicFldComparisonOp[clsgs_KnowledgesGraphEN.con_KnowledgeGraphName];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_KnowledgesGraphEN.con_KnowledgeGraphName, objgs_KnowledgesGraph_Cond.knowledgeGraphName, strComparisonOp_KnowledgeGraphName);
}
if (Object.prototype.hasOwnProperty.call(objgs_KnowledgesGraph_Cond.dicFldComparisonOp, clsgs_KnowledgesGraphEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objgs_KnowledgesGraph_Cond.dicFldComparisonOp[clsgs_KnowledgesGraphEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_KnowledgesGraphEN.con_id_CurrEduCls, objgs_KnowledgesGraph_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (Object.prototype.hasOwnProperty.call(objgs_KnowledgesGraph_Cond.dicFldComparisonOp, clsgs_KnowledgesGraphEN.con_CourseId) == true)
{
const strComparisonOp_CourseId:string = objgs_KnowledgesGraph_Cond.dicFldComparisonOp[clsgs_KnowledgesGraphEN.con_CourseId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_KnowledgesGraphEN.con_CourseId, objgs_KnowledgesGraph_Cond.courseId, strComparisonOp_CourseId);
}
if (Object.prototype.hasOwnProperty.call(objgs_KnowledgesGraph_Cond.dicFldComparisonOp, clsgs_KnowledgesGraphEN.con_CreateUser) == true)
{
const strComparisonOp_CreateUser:string = objgs_KnowledgesGraph_Cond.dicFldComparisonOp[clsgs_KnowledgesGraphEN.con_CreateUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_KnowledgesGraphEN.con_CreateUser, objgs_KnowledgesGraph_Cond.createUser, strComparisonOp_CreateUser);
}
if (Object.prototype.hasOwnProperty.call(objgs_KnowledgesGraph_Cond.dicFldComparisonOp, clsgs_KnowledgesGraphEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objgs_KnowledgesGraph_Cond.dicFldComparisonOp[clsgs_KnowledgesGraphEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_KnowledgesGraphEN.con_UpdDate, objgs_KnowledgesGraph_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objgs_KnowledgesGraph_Cond.dicFldComparisonOp, clsgs_KnowledgesGraphEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objgs_KnowledgesGraph_Cond.dicFldComparisonOp[clsgs_KnowledgesGraphEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_KnowledgesGraphEN.con_UpdUser, objgs_KnowledgesGraph_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objgs_KnowledgesGraph_Cond.dicFldComparisonOp, clsgs_KnowledgesGraphEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objgs_KnowledgesGraph_Cond.dicFldComparisonOp[clsgs_KnowledgesGraphEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_KnowledgesGraphEN.con_Memo, objgs_KnowledgesGraph_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objgs_KnowledgesGraph_Cond.dicFldComparisonOp, clsgs_KnowledgesGraphEN.con_GraphTypeId) == true)
{
const strComparisonOp_GraphTypeId:string = objgs_KnowledgesGraph_Cond.dicFldComparisonOp[clsgs_KnowledgesGraphEN.con_GraphTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_KnowledgesGraphEN.con_GraphTypeId, objgs_KnowledgesGraph_Cond.graphTypeId, strComparisonOp_GraphTypeId);
}
if (Object.prototype.hasOwnProperty.call(objgs_KnowledgesGraph_Cond.dicFldComparisonOp, clsgs_KnowledgesGraphEN.con_IsDisplay) == true)
{
if (objgs_KnowledgesGraph_Cond.isDisplay == true)
{
strWhereCond += Format(" And {0} = '1'", clsgs_KnowledgesGraphEN.con_IsDisplay);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsgs_KnowledgesGraphEN.con_IsDisplay);
}
}
if (Object.prototype.hasOwnProperty.call(objgs_KnowledgesGraph_Cond.dicFldComparisonOp, clsgs_KnowledgesGraphEN.con_IsExtend) == true)
{
if (objgs_KnowledgesGraph_Cond.isExtend == true)
{
strWhereCond += Format(" And {0} = '1'", clsgs_KnowledgesGraphEN.con_IsExtend);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsgs_KnowledgesGraphEN.con_IsExtend);
}
}
if (Object.prototype.hasOwnProperty.call(objgs_KnowledgesGraph_Cond.dicFldComparisonOp, clsgs_KnowledgesGraphEN.con_IsRecommend) == true)
{
if (objgs_KnowledgesGraph_Cond.isRecommend == true)
{
strWhereCond += Format(" And {0} = '1'", clsgs_KnowledgesGraphEN.con_IsRecommend);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsgs_KnowledgesGraphEN.con_IsRecommend);
}
}
if (Object.prototype.hasOwnProperty.call(objgs_KnowledgesGraph_Cond.dicFldComparisonOp, clsgs_KnowledgesGraphEN.con_IsAnswer) == true)
{
if (objgs_KnowledgesGraph_Cond.isAnswer == true)
{
strWhereCond += Format(" And {0} = '1'", clsgs_KnowledgesGraphEN.con_IsAnswer);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsgs_KnowledgesGraphEN.con_IsAnswer);
}
}
if (Object.prototype.hasOwnProperty.call(objgs_KnowledgesGraph_Cond.dicFldComparisonOp, clsgs_KnowledgesGraphEN.con_IsSubmit) == true)
{
if (objgs_KnowledgesGraph_Cond.isSubmit == true)
{
strWhereCond += Format(" And {0} = '1'", clsgs_KnowledgesGraphEN.con_IsSubmit);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsgs_KnowledgesGraphEN.con_IsSubmit);
}
}
if (Object.prototype.hasOwnProperty.call(objgs_KnowledgesGraph_Cond.dicFldComparisonOp, clsgs_KnowledgesGraphEN.con_StartTime) == true)
{
const strComparisonOp_StartTime:string = objgs_KnowledgesGraph_Cond.dicFldComparisonOp[clsgs_KnowledgesGraphEN.con_StartTime];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_KnowledgesGraphEN.con_StartTime, objgs_KnowledgesGraph_Cond.startTime, strComparisonOp_StartTime);
}
if (Object.prototype.hasOwnProperty.call(objgs_KnowledgesGraph_Cond.dicFldComparisonOp, clsgs_KnowledgesGraphEN.con_SubmitTime) == true)
{
const strComparisonOp_SubmitTime:string = objgs_KnowledgesGraph_Cond.dicFldComparisonOp[clsgs_KnowledgesGraphEN.con_SubmitTime];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_KnowledgesGraphEN.con_SubmitTime, objgs_KnowledgesGraph_Cond.submitTime, strComparisonOp_SubmitTime);
}
if (Object.prototype.hasOwnProperty.call(objgs_KnowledgesGraph_Cond.dicFldComparisonOp, clsgs_KnowledgesGraphEN.con_EduClassName) == true)
{
const strComparisonOp_EduClassName:string = objgs_KnowledgesGraph_Cond.dicFldComparisonOp[clsgs_KnowledgesGraphEN.con_EduClassName];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_KnowledgesGraphEN.con_EduClassName, objgs_KnowledgesGraph_Cond.eduClassName, strComparisonOp_EduClassName);
}
if (Object.prototype.hasOwnProperty.call(objgs_KnowledgesGraph_Cond.dicFldComparisonOp, clsgs_KnowledgesGraphEN.con_CourseName) == true)
{
const strComparisonOp_CourseName:string = objgs_KnowledgesGraph_Cond.dicFldComparisonOp[clsgs_KnowledgesGraphEN.con_CourseName];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_KnowledgesGraphEN.con_CourseName, objgs_KnowledgesGraph_Cond.courseName, strComparisonOp_CourseName);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--gs_KnowledgesGraph(知识点逻辑图),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param strKnowledgeGraphName: 连连看图名(要求唯一的字段)
 * @param strCourseId: 课程Id(要求唯一的字段)
 * @param strCreateUser: 建立用户(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function gs_KnowledgesGraph_GetUniCondStr_KnowledgeGraphName_CourseId_CreateUser(objgs_KnowledgesGraphEN: clsgs_KnowledgesGraphEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and KnowledgeGraphName = '{0}'", objgs_KnowledgesGraphEN.knowledgeGraphName);
 strWhereCond +=  Format(" and CourseId = '{0}'", objgs_KnowledgesGraphEN.courseId);
 strWhereCond +=  Format(" and CreateUser = '{0}'", objgs_KnowledgesGraphEN.createUser);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--gs_KnowledgesGraph(知识点逻辑图),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param strKnowledgeGraphName: 连连看图名(要求唯一的字段)
 * @param strCourseId: 课程Id(要求唯一的字段)
 * @param strCreateUser: 建立用户(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function gs_KnowledgesGraph_GetUniCondStr4Update_KnowledgeGraphName_CourseId_CreateUser(objgs_KnowledgesGraphEN: clsgs_KnowledgesGraphEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and KnowledgeGraphId <> '{0}'", objgs_KnowledgesGraphEN.knowledgeGraphId);
 strWhereCond +=  Format(" and KnowledgeGraphName = '{0}'", objgs_KnowledgesGraphEN.knowledgeGraphName);
 strWhereCond +=  Format(" and CourseId = '{0}'", objgs_KnowledgesGraphEN.courseId);
 strWhereCond +=  Format(" and CreateUser = '{0}'", objgs_KnowledgesGraphEN.createUser);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objgs_KnowledgesGraphENS:源对象
 * @param objgs_KnowledgesGraphENT:目标对象
*/
export function gs_KnowledgesGraph_CopyObjTo(objgs_KnowledgesGraphENS: clsgs_KnowledgesGraphEN , objgs_KnowledgesGraphENT: clsgs_KnowledgesGraphEN ): void 
{
objgs_KnowledgesGraphENT.knowledgeGraphId = objgs_KnowledgesGraphENS.knowledgeGraphId; //知识点图Id
objgs_KnowledgesGraphENT.knowledgeGraphName = objgs_KnowledgesGraphENS.knowledgeGraphName; //连连看图名
objgs_KnowledgesGraphENT.id_CurrEduCls = objgs_KnowledgesGraphENS.id_CurrEduCls; //教学班流水号
objgs_KnowledgesGraphENT.courseId = objgs_KnowledgesGraphENS.courseId; //课程Id
objgs_KnowledgesGraphENT.createUser = objgs_KnowledgesGraphENS.createUser; //建立用户
objgs_KnowledgesGraphENT.updDate = objgs_KnowledgesGraphENS.updDate; //修改日期
objgs_KnowledgesGraphENT.updUser = objgs_KnowledgesGraphENS.updUser; //修改人
objgs_KnowledgesGraphENT.memo = objgs_KnowledgesGraphENS.memo; //备注
objgs_KnowledgesGraphENT.graphTypeId = objgs_KnowledgesGraphENS.graphTypeId; //图谱类型Id
objgs_KnowledgesGraphENT.isDisplay = objgs_KnowledgesGraphENS.isDisplay; //是否显示
objgs_KnowledgesGraphENT.isExtend = objgs_KnowledgesGraphENS.isExtend; //是否扩展
objgs_KnowledgesGraphENT.isRecommend = objgs_KnowledgesGraphENS.isRecommend; //是否推荐
objgs_KnowledgesGraphENT.isAnswer = objgs_KnowledgesGraphENS.isAnswer; //是否回答
objgs_KnowledgesGraphENT.isSubmit = objgs_KnowledgesGraphENS.isSubmit; //是否提交
objgs_KnowledgesGraphENT.startTime = objgs_KnowledgesGraphENS.startTime; //开始时间
objgs_KnowledgesGraphENT.submitTime = objgs_KnowledgesGraphENS.submitTime; //提交时间
objgs_KnowledgesGraphENT.eduClassName = objgs_KnowledgesGraphENS.eduClassName; //教学班
objgs_KnowledgesGraphENT.courseName = objgs_KnowledgesGraphENS.courseName; //课程名称
objgs_KnowledgesGraphENT.sf_UpdFldSetStr = objgs_KnowledgesGraphENS.updFldString; //sf_UpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objgs_KnowledgesGraphENS:源对象
 * @param objgs_KnowledgesGraphENT:目标对象
*/
export function gs_KnowledgesGraph_GetObjFromJsonObj(objgs_KnowledgesGraphENS: clsgs_KnowledgesGraphEN): clsgs_KnowledgesGraphEN 
{
 const objgs_KnowledgesGraphENT: clsgs_KnowledgesGraphEN = new clsgs_KnowledgesGraphEN();
ObjectAssign(objgs_KnowledgesGraphENT, objgs_KnowledgesGraphENS);
 return objgs_KnowledgesGraphENT;
}