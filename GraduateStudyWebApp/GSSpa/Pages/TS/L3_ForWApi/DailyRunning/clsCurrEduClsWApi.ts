
 /**
 * 类名:clsCurrEduClsWApi
 * 表名:CurrEduCls(01120123)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:46:08
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
 * 当前教学班(CurrEduCls)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clsCurrEduClsEN } from "../../L0_Entity/DailyRunning/clsCurrEduClsEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { tzDataType } from "../../PubFun/jsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const currEduCls_Controller = "CurrEduClsApi";
 export const currEduCls_ConstructorName = "currEduCls";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strid_CurrEduCls:关键字
 * @returns 对象
 **/
export async function CurrEduCls_GetObjByid_CurrEduClsAsync(strid_CurrEduCls: string): Promise<clsCurrEduClsEN>  
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
const strUrl = GetWebApiUrl(currEduCls_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", currEduCls_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objCurrEduCls = CurrEduCls_GetObjFromJsonObj(returnObj);
return objCurrEduCls;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduCls_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduCls_ConstructorName, strThisFuncName);
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
export async function CurrEduCls_GetObjByid_CurrEduCls_Cache(strid_CurrEduCls: string, bolTryAsyncOnce: boolean = true) {
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
const arrCurrEduClsObjLst_Cache = await CurrEduCls_GetObjLst_Cache();
try
{
const arrCurrEduCls_Sel: Array <clsCurrEduClsEN> = arrCurrEduClsObjLst_Cache.filter(x => x.id_CurrEduCls == strid_CurrEduCls);
let objCurrEduCls: clsCurrEduClsEN;
if (arrCurrEduCls_Sel.length > 0)
{
objCurrEduCls = arrCurrEduCls_Sel[0];
return objCurrEduCls;
}
else
{
if (bolTryAsyncOnce == true)
{
objCurrEduCls = await CurrEduCls_GetObjByid_CurrEduClsAsync(strid_CurrEduCls);
if (objCurrEduCls != null)
{
CurrEduCls_ReFreshThisCache();
return objCurrEduCls;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strid_CurrEduCls, currEduCls_ConstructorName, strThisFuncName);
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
export async function CurrEduCls_GetObjByid_CurrEduCls_localStorage(strid_CurrEduCls: string) {
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
const strKey = Format("{0}_{1}", clsCurrEduClsEN._CurrTabName, strid_CurrEduCls);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objCurrEduCls_Cache: clsCurrEduClsEN = JSON.parse(strTempObj);
return objCurrEduCls_Cache;
}
try
{
const objCurrEduCls = await CurrEduCls_GetObjByid_CurrEduClsAsync(strid_CurrEduCls);
if (objCurrEduCls != null)
{
localStorage.setItem(strKey, JSON.stringify(objCurrEduCls));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objCurrEduCls;
}
return objCurrEduCls;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strid_CurrEduCls, currEduCls_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objCurrEduCls:所给的对象
 * @returns 对象
*/
export async function CurrEduCls_UpdateObjInLst_Cache(objCurrEduCls: clsCurrEduClsEN) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrCurrEduClsObjLst_Cache = await CurrEduCls_GetObjLst_Cache();
const obj = arrCurrEduClsObjLst_Cache.find(x => x.eduClsName == objCurrEduCls.eduClsName);
if (obj != null)
{
objCurrEduCls.id_CurrEduCls = obj.id_CurrEduCls;
ObjectAssign( obj, objCurrEduCls);
}
else
{
arrCurrEduClsObjLst_Cache.push(objCurrEduCls);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, currEduCls_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
}

/**
 * 根据关键字获取相关对象的名称属性, 从缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
 * @param strid_CurrEduCls:所给的关键字
 * @returns 对象
*/
export async function CurrEduCls_GetNameByid_CurrEduCls_Cache(strid_CurrEduCls: string) {
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
const arrCurrEduClsObjLst_Cache = await CurrEduCls_GetObjLst_Cache();
if (arrCurrEduClsObjLst_Cache == null) return "";
try
{
const arrCurrEduCls_Sel: Array <clsCurrEduClsEN> = arrCurrEduClsObjLst_Cache.filter(x => x.id_CurrEduCls == strid_CurrEduCls);
let objCurrEduCls: clsCurrEduClsEN;
if (arrCurrEduCls_Sel.length > 0)
{
objCurrEduCls = arrCurrEduCls_Sel[0];
return objCurrEduCls.eduClsName;
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
export async function CurrEduCls_func(strInFldName:string , strOutFldName:string ,  strInValue: string) 
{
//const strThisFuncName = "func";

if (strInFldName != clsCurrEduClsEN.con_id_CurrEduCls)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsCurrEduClsEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clsCurrEduClsEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strid_CurrEduCls = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objCurrEduCls = await CurrEduCls_GetObjByid_CurrEduCls_Cache(strid_CurrEduCls );
if (objCurrEduCls == null) return "";
return objCurrEduCls.GetFldValue(strOutFldName).toString();
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
export function CurrEduCls_SortFun_Defa(a:clsCurrEduClsEN , b:clsCurrEduClsEN): number 
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
export function CurrEduCls_SortFun_Defa_2Fld(a:clsCurrEduClsEN , b:clsCurrEduClsEN): number 
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
export function CurrEduCls_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsCurrEduClsEN.con_id_CurrEduCls:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
case clsCurrEduClsEN.con_CurrEduClsId:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
return a.currEduClsId.localeCompare(b.currEduClsId);
}
case clsCurrEduClsEN.con_EduClsName:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
return a.eduClsName.localeCompare(b.eduClsName);
}
case clsCurrEduClsEN.con_EduClsTypeId:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
return a.eduClsTypeId.localeCompare(b.eduClsTypeId);
}
case clsCurrEduClsEN.con_CourseId:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
return a.courseId.localeCompare(b.courseId);
}
case clsCurrEduClsEN.con_TeachingSolutionId:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
return a.teachingSolutionId.localeCompare(b.teachingSolutionId);
}
case clsCurrEduClsEN.con_id_XzCollege:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
return a.id_XzCollege.localeCompare(b.id_XzCollege);
}
case clsCurrEduClsEN.con_id_XzMajor:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
return a.id_XzMajor.localeCompare(b.id_XzMajor);
}
case clsCurrEduClsEN.con_id_EduWay:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
return a.id_EduWay.localeCompare(b.id_EduWay);
}
case clsCurrEduClsEN.con_id_ClassRoomType:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
return a.id_ClassRoomType.localeCompare(b.id_ClassRoomType);
}
case clsCurrEduClsEN.con_TotalLessonQty:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
return a.totalLessonQty-b.totalLessonQty;
}
case clsCurrEduClsEN.con_MaxStuQty:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
return a.maxStuQty-b.maxStuQty;
}
case clsCurrEduClsEN.con_WeekQty:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
return a.weekQty-b.weekQty;
}
case clsCurrEduClsEN.con_ScheUnitPW:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
return a.scheUnitPW-b.scheUnitPW;
}
case clsCurrEduClsEN.con_WeekStatusID:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
return a.weekStatusID.localeCompare(b.weekStatusID);
}
case clsCurrEduClsEN.con_CustomerWeek:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
return a.customerWeek.localeCompare(b.customerWeek);
}
case clsCurrEduClsEN.con_LessonQtyPerWeek:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
return a.lessonQtyPerWeek-b.lessonQtyPerWeek;
}
case clsCurrEduClsEN.con_Mark:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
return a.mark-b.mark;
}
case clsCurrEduClsEN.con_id_UniZone:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
return a.id_UniZone.localeCompare(b.id_UniZone);
}
case clsCurrEduClsEN.con_id_GradeBase:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
return a.id_GradeBase.localeCompare(b.id_GradeBase);
}
case clsCurrEduClsEN.con_IsEffective:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
if (a.isEffective == true) return 1;
else return -1
}
case clsCurrEduClsEN.con_IsForPaperReading:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
if (a.isForPaperReading == true) return 1;
else return -1
}
case clsCurrEduClsEN.con_SchoolYear:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
return a.schoolYear.localeCompare(b.schoolYear);
}
case clsCurrEduClsEN.con_SchoolTerm:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
return a.schoolTerm.localeCompare(b.schoolTerm);
}
case clsCurrEduClsEN.con_id_CourseType:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
return a.id_CourseType.localeCompare(b.id_CourseType);
}
case clsCurrEduClsEN.con_IsDegree:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
if (a.isDegree == true) return 1;
else return -1
}
case clsCurrEduClsEN.con_id_ScoreType:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
return a.id_ScoreType.localeCompare(b.id_ScoreType);
}
case clsCurrEduClsEN.con_GetScoreWayId:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
return a.getScoreWayId.localeCompare(b.getScoreWayId);
}
case clsCurrEduClsEN.con_IsProportionalCtrl:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
if (a.isProportionalCtrl == true) return 1;
else return -1
}
case clsCurrEduClsEN.con_id_ExamType:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
return a.id_ExamType.localeCompare(b.id_ExamType);
}
case clsCurrEduClsEN.con_ExamTime:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
return a.examTime.localeCompare(b.examTime);
}
case clsCurrEduClsEN.con_BeginWeek:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
return a.beginWeek-b.beginWeek;
}
case clsCurrEduClsEN.con_ModifyDate:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
return a.modifyDate.localeCompare(b.modifyDate);
}
case clsCurrEduClsEN.con_ModifyUserID:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
return a.modifyUserID.localeCompare(b.modifyUserID);
}
case clsCurrEduClsEN.con_Memo:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[CurrEduCls]中不存在！(in ${ currEduCls_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsCurrEduClsEN.con_id_CurrEduCls:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
case clsCurrEduClsEN.con_CurrEduClsId:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
return b.currEduClsId.localeCompare(a.currEduClsId);
}
case clsCurrEduClsEN.con_EduClsName:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
return b.eduClsName.localeCompare(a.eduClsName);
}
case clsCurrEduClsEN.con_EduClsTypeId:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
return b.eduClsTypeId.localeCompare(a.eduClsTypeId);
}
case clsCurrEduClsEN.con_CourseId:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
return b.courseId.localeCompare(a.courseId);
}
case clsCurrEduClsEN.con_TeachingSolutionId:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
return b.teachingSolutionId.localeCompare(a.teachingSolutionId);
}
case clsCurrEduClsEN.con_id_XzCollege:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
return b.id_XzCollege.localeCompare(a.id_XzCollege);
}
case clsCurrEduClsEN.con_id_XzMajor:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
return b.id_XzMajor.localeCompare(a.id_XzMajor);
}
case clsCurrEduClsEN.con_id_EduWay:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
return b.id_EduWay.localeCompare(a.id_EduWay);
}
case clsCurrEduClsEN.con_id_ClassRoomType:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
return b.id_ClassRoomType.localeCompare(a.id_ClassRoomType);
}
case clsCurrEduClsEN.con_TotalLessonQty:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
return b.totalLessonQty-a.totalLessonQty;
}
case clsCurrEduClsEN.con_MaxStuQty:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
return b.maxStuQty-a.maxStuQty;
}
case clsCurrEduClsEN.con_WeekQty:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
return b.weekQty-a.weekQty;
}
case clsCurrEduClsEN.con_ScheUnitPW:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
return b.scheUnitPW-a.scheUnitPW;
}
case clsCurrEduClsEN.con_WeekStatusID:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
return b.weekStatusID.localeCompare(a.weekStatusID);
}
case clsCurrEduClsEN.con_CustomerWeek:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
return b.customerWeek.localeCompare(a.customerWeek);
}
case clsCurrEduClsEN.con_LessonQtyPerWeek:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
return b.lessonQtyPerWeek-a.lessonQtyPerWeek;
}
case clsCurrEduClsEN.con_Mark:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
return b.mark-a.mark;
}
case clsCurrEduClsEN.con_id_UniZone:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
return b.id_UniZone.localeCompare(a.id_UniZone);
}
case clsCurrEduClsEN.con_id_GradeBase:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
return b.id_GradeBase.localeCompare(a.id_GradeBase);
}
case clsCurrEduClsEN.con_IsEffective:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
if (b.isEffective == true) return 1;
else return -1
}
case clsCurrEduClsEN.con_IsForPaperReading:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
if (b.isForPaperReading == true) return 1;
else return -1
}
case clsCurrEduClsEN.con_SchoolYear:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
return b.schoolYear.localeCompare(a.schoolYear);
}
case clsCurrEduClsEN.con_SchoolTerm:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
return b.schoolTerm.localeCompare(a.schoolTerm);
}
case clsCurrEduClsEN.con_id_CourseType:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
return b.id_CourseType.localeCompare(a.id_CourseType);
}
case clsCurrEduClsEN.con_IsDegree:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
if (b.isDegree == true) return 1;
else return -1
}
case clsCurrEduClsEN.con_id_ScoreType:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
return b.id_ScoreType.localeCompare(a.id_ScoreType);
}
case clsCurrEduClsEN.con_GetScoreWayId:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
return b.getScoreWayId.localeCompare(a.getScoreWayId);
}
case clsCurrEduClsEN.con_IsProportionalCtrl:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
if (b.isProportionalCtrl == true) return 1;
else return -1
}
case clsCurrEduClsEN.con_id_ExamType:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
return b.id_ExamType.localeCompare(a.id_ExamType);
}
case clsCurrEduClsEN.con_ExamTime:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
return b.examTime.localeCompare(a.examTime);
}
case clsCurrEduClsEN.con_BeginWeek:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
return b.beginWeek-a.beginWeek;
}
case clsCurrEduClsEN.con_ModifyDate:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
return b.modifyDate.localeCompare(a.modifyDate);
}
case clsCurrEduClsEN.con_ModifyUserID:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
return b.modifyUserID.localeCompare(a.modifyUserID);
}
case clsCurrEduClsEN.con_Memo:
return (a: clsCurrEduClsEN, b: clsCurrEduClsEN) => {
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[CurrEduCls]中不存在！(in ${ currEduCls_ConstructorName}.${ strThisFuncName})`;
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
export async function CurrEduCls_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsCurrEduClsEN.con_id_CurrEduCls:
return (obj: clsCurrEduClsEN) => {
return obj.id_CurrEduCls === value;
}
case clsCurrEduClsEN.con_CurrEduClsId:
return (obj: clsCurrEduClsEN) => {
return obj.currEduClsId === value;
}
case clsCurrEduClsEN.con_EduClsName:
return (obj: clsCurrEduClsEN) => {
return obj.eduClsName === value;
}
case clsCurrEduClsEN.con_EduClsTypeId:
return (obj: clsCurrEduClsEN) => {
return obj.eduClsTypeId === value;
}
case clsCurrEduClsEN.con_CourseId:
return (obj: clsCurrEduClsEN) => {
return obj.courseId === value;
}
case clsCurrEduClsEN.con_TeachingSolutionId:
return (obj: clsCurrEduClsEN) => {
return obj.teachingSolutionId === value;
}
case clsCurrEduClsEN.con_id_XzCollege:
return (obj: clsCurrEduClsEN) => {
return obj.id_XzCollege === value;
}
case clsCurrEduClsEN.con_id_XzMajor:
return (obj: clsCurrEduClsEN) => {
return obj.id_XzMajor === value;
}
case clsCurrEduClsEN.con_id_EduWay:
return (obj: clsCurrEduClsEN) => {
return obj.id_EduWay === value;
}
case clsCurrEduClsEN.con_id_ClassRoomType:
return (obj: clsCurrEduClsEN) => {
return obj.id_ClassRoomType === value;
}
case clsCurrEduClsEN.con_TotalLessonQty:
return (obj: clsCurrEduClsEN) => {
return obj.totalLessonQty === value;
}
case clsCurrEduClsEN.con_MaxStuQty:
return (obj: clsCurrEduClsEN) => {
return obj.maxStuQty === value;
}
case clsCurrEduClsEN.con_WeekQty:
return (obj: clsCurrEduClsEN) => {
return obj.weekQty === value;
}
case clsCurrEduClsEN.con_ScheUnitPW:
return (obj: clsCurrEduClsEN) => {
return obj.scheUnitPW === value;
}
case clsCurrEduClsEN.con_WeekStatusID:
return (obj: clsCurrEduClsEN) => {
return obj.weekStatusID === value;
}
case clsCurrEduClsEN.con_CustomerWeek:
return (obj: clsCurrEduClsEN) => {
return obj.customerWeek === value;
}
case clsCurrEduClsEN.con_LessonQtyPerWeek:
return (obj: clsCurrEduClsEN) => {
return obj.lessonQtyPerWeek === value;
}
case clsCurrEduClsEN.con_Mark:
return (obj: clsCurrEduClsEN) => {
return obj.mark === value;
}
case clsCurrEduClsEN.con_id_UniZone:
return (obj: clsCurrEduClsEN) => {
return obj.id_UniZone === value;
}
case clsCurrEduClsEN.con_id_GradeBase:
return (obj: clsCurrEduClsEN) => {
return obj.id_GradeBase === value;
}
case clsCurrEduClsEN.con_IsEffective:
return (obj: clsCurrEduClsEN) => {
return obj.isEffective === value;
}
case clsCurrEduClsEN.con_IsForPaperReading:
return (obj: clsCurrEduClsEN) => {
return obj.isForPaperReading === value;
}
case clsCurrEduClsEN.con_SchoolYear:
return (obj: clsCurrEduClsEN) => {
return obj.schoolYear === value;
}
case clsCurrEduClsEN.con_SchoolTerm:
return (obj: clsCurrEduClsEN) => {
return obj.schoolTerm === value;
}
case clsCurrEduClsEN.con_id_CourseType:
return (obj: clsCurrEduClsEN) => {
return obj.id_CourseType === value;
}
case clsCurrEduClsEN.con_IsDegree:
return (obj: clsCurrEduClsEN) => {
return obj.isDegree === value;
}
case clsCurrEduClsEN.con_id_ScoreType:
return (obj: clsCurrEduClsEN) => {
return obj.id_ScoreType === value;
}
case clsCurrEduClsEN.con_GetScoreWayId:
return (obj: clsCurrEduClsEN) => {
return obj.getScoreWayId === value;
}
case clsCurrEduClsEN.con_IsProportionalCtrl:
return (obj: clsCurrEduClsEN) => {
return obj.isProportionalCtrl === value;
}
case clsCurrEduClsEN.con_id_ExamType:
return (obj: clsCurrEduClsEN) => {
return obj.id_ExamType === value;
}
case clsCurrEduClsEN.con_ExamTime:
return (obj: clsCurrEduClsEN) => {
return obj.examTime === value;
}
case clsCurrEduClsEN.con_BeginWeek:
return (obj: clsCurrEduClsEN) => {
return obj.beginWeek === value;
}
case clsCurrEduClsEN.con_ModifyDate:
return (obj: clsCurrEduClsEN) => {
return obj.modifyDate === value;
}
case clsCurrEduClsEN.con_ModifyUserID:
return (obj: clsCurrEduClsEN) => {
return obj.modifyUserID === value;
}
case clsCurrEduClsEN.con_Memo:
return (obj: clsCurrEduClsEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[CurrEduCls]中不存在！(in ${ currEduCls_ConstructorName}.${ strThisFuncName})`;
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
export async function CurrEduCls_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(currEduCls_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduCls_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduCls_ConstructorName, strThisFuncName);
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
export async function CurrEduCls_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(currEduCls_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduCls_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduCls_ConstructorName, strThisFuncName);
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
export async function CurrEduCls_GetFirstObjAsync(strWhereCond: string): Promise<clsCurrEduClsEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(currEduCls_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", currEduCls_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objCurrEduCls = CurrEduCls_GetObjFromJsonObj(returnObj);
return objCurrEduCls;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduCls_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduCls_ConstructorName, strThisFuncName);
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
export async function CurrEduCls_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsCurrEduClsEN._CurrTabName;
clsCurrEduClsEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsCurrEduClsEN._CurrTabName);
if (IsNullOrEmpty(clsCurrEduClsEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsCurrEduClsEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrCurrEduClsExObjLst_Cache: Array<clsCurrEduClsEN> = CacheHelper.Get(strKey);
const arrCurrEduClsObjLst_T = CurrEduCls_GetObjLstByJSONObjLst(arrCurrEduClsExObjLst_Cache);
return arrCurrEduClsObjLst_T;
}
try
{
const arrCurrEduClsExObjLst = await CurrEduCls_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrCurrEduClsExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrCurrEduClsExObjLst.length);
console.log(strInfo);
return arrCurrEduClsExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, currEduCls_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function CurrEduCls_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsCurrEduClsEN._CurrTabName;
clsCurrEduClsEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsCurrEduClsEN._CurrTabName);
if (IsNullOrEmpty(clsCurrEduClsEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsCurrEduClsEN.CacheAddiCondition);
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
const arrCurrEduClsExObjLst_Cache: Array<clsCurrEduClsEN> = JSON.parse(strTempObjLst);
const arrCurrEduClsObjLst_T = CurrEduCls_GetObjLstByJSONObjLst(arrCurrEduClsExObjLst_Cache);
return arrCurrEduClsObjLst_T;
}
try
{
const arrCurrEduClsExObjLst = await CurrEduCls_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrCurrEduClsExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrCurrEduClsExObjLst.length);
console.log(strInfo);
return arrCurrEduClsExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, currEduCls_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function CurrEduCls_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsCurrEduClsEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrCurrEduClsObjLst_Cache: Array<clsCurrEduClsEN> = JSON.parse(strTempObjLst);
return arrCurrEduClsObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function CurrEduCls_GetObjLstAsync(strWhereCond: string): Promise<Array<clsCurrEduClsEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(currEduCls_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", currEduCls_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = CurrEduCls_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduCls_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduCls_ConstructorName, strThisFuncName);
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
export async function CurrEduCls_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsCurrEduClsEN._CurrTabName;
clsCurrEduClsEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsCurrEduClsEN._CurrTabName);
if (IsNullOrEmpty(clsCurrEduClsEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsCurrEduClsEN.CacheAddiCondition);
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
const arrCurrEduClsExObjLst_Cache: Array<clsCurrEduClsEN> = JSON.parse(strTempObjLst);
const arrCurrEduClsObjLst_T = CurrEduCls_GetObjLstByJSONObjLst(arrCurrEduClsExObjLst_Cache);
return arrCurrEduClsObjLst_T;
}
try
{
const arrCurrEduClsExObjLst = await CurrEduCls_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrCurrEduClsExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrCurrEduClsExObjLst.length);
console.log(strInfo);
return arrCurrEduClsExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, currEduCls_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function CurrEduCls_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsCurrEduClsEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrCurrEduClsObjLst_Cache: Array<clsCurrEduClsEN> = JSON.parse(strTempObjLst);
return arrCurrEduClsObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function CurrEduCls_GetObjLst_Cache(): Promise<Array<clsCurrEduClsEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrCurrEduClsObjLst_Cache;
switch (clsCurrEduClsEN.CacheModeId)
{
case "04"://sessionStorage
arrCurrEduClsObjLst_Cache = await CurrEduCls_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrCurrEduClsObjLst_Cache = await CurrEduCls_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrCurrEduClsObjLst_Cache = await CurrEduCls_GetObjLst_ClientCache();
break;
default:
arrCurrEduClsObjLst_Cache = await CurrEduCls_GetObjLst_ClientCache();
break;
}
const arrCurrEduClsObjLst = CurrEduCls_GetObjLstByJSONObjLst(arrCurrEduClsObjLst_Cache);
return arrCurrEduClsObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function CurrEduCls_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrCurrEduClsObjLst_Cache;
switch (clsCurrEduClsEN.CacheModeId)
{
case "04"://sessionStorage
arrCurrEduClsObjLst_Cache = await CurrEduCls_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrCurrEduClsObjLst_Cache = await CurrEduCls_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrCurrEduClsObjLst_Cache = null;
break;
default:
arrCurrEduClsObjLst_Cache = null;
break;
}
return arrCurrEduClsObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrid_CurrEduCls_Cond:条件对象
 * @returns 对象列表子集
*/
export async function CurrEduCls_GetSubObjLst_Cache(objCurrEduCls_Cond: clsCurrEduClsEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrCurrEduClsObjLst_Cache = await CurrEduCls_GetObjLst_Cache();
let arrCurrEduCls_Sel: Array < clsCurrEduClsEN > = arrCurrEduClsObjLst_Cache;
if (objCurrEduCls_Cond.sf_FldComparisonOp == null || objCurrEduCls_Cond.sf_FldComparisonOp == "") return arrCurrEduCls_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objCurrEduCls_Cond.sf_FldComparisonOp);
//console.log("clsCurrEduClsWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objCurrEduCls_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objCurrEduCls_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrCurrEduCls_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objCurrEduCls_Cond), currEduCls_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsCurrEduClsEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrid_CurrEduCls:关键字列表
 * @returns 对象列表
 **/
export async function CurrEduCls_GetObjLstByid_CurrEduClsLstAsync(arrid_CurrEduCls: Array<string>): Promise<Array<clsCurrEduClsEN>>  
{
const strThisFuncName = "GetObjLstByid_CurrEduClsLstAsync";
const strAction = "GetObjLstByid_CurrEduClsLst";
const strUrl = GetWebApiUrl(currEduCls_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrid_CurrEduCls);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", currEduCls_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = CurrEduCls_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduCls_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduCls_ConstructorName, strThisFuncName);
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
export async function CurrEduCls_GetObjLstByid_CurrEduClsLst_Cache(arrid_CurrEduClsLst: Array<string>) {
const strThisFuncName = "GetObjLstByid_CurrEduClsLst_Cache";
try
{
const arrCurrEduClsObjLst_Cache = await CurrEduCls_GetObjLst_Cache();
const arrCurrEduCls_Sel: Array <clsCurrEduClsEN> = arrCurrEduClsObjLst_Cache.filter(x => arrid_CurrEduClsLst.indexOf(x.id_CurrEduCls)>-1);
return arrCurrEduCls_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrid_CurrEduClsLst.join(","), currEduCls_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsCurrEduClsEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function CurrEduCls_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsCurrEduClsEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(currEduCls_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", currEduCls_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = CurrEduCls_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduCls_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduCls_ConstructorName, strThisFuncName);
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
export async function CurrEduCls_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsCurrEduClsEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(currEduCls_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", currEduCls_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = CurrEduCls_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduCls_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduCls_ConstructorName, strThisFuncName);
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
export async function CurrEduCls_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(currEduCls_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduCls_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduCls_ConstructorName, strThisFuncName);
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
export async function CurrEduCls_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrCurrEduClsObjLst_Cache = await CurrEduCls_GetObjLst_Cache();
if (arrCurrEduClsObjLst_Cache.length == 0) return arrCurrEduClsObjLst_Cache;
let arrCurrEduCls_Sel = arrCurrEduClsObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objCurrEduCls_Cond = new clsCurrEduClsEN();
ObjectAssign(objCurrEduCls_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsCurrEduClsWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objCurrEduCls_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrCurrEduCls_Sel.length == 0) return arrCurrEduCls_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrCurrEduCls_Sel = arrCurrEduCls_Sel.sort(CurrEduCls_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrCurrEduCls_Sel = arrCurrEduCls_Sel.sort(objPagerPara.sortFun);
}
arrCurrEduCls_Sel = arrCurrEduCls_Sel.slice(intStart, intEnd);     
return arrCurrEduCls_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, currEduCls_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsCurrEduClsEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function CurrEduCls_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsCurrEduClsEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(currEduCls_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", currEduCls_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = CurrEduCls_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduCls_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduCls_ConstructorName, strThisFuncName);
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
 * @param strid_CurrEduCls:关键字
 * @returns 获取删除的结果
 **/
export async function CurrEduCls_DelRecordAsync(strid_CurrEduCls: string): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(currEduCls_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, strid_CurrEduCls);
try
{
const response = await axios.delete(strUrl,
{
params: { "Id": strid_CurrEduCls, }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduCls_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduCls_ConstructorName, strThisFuncName);
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
 * @param arrid_CurrEduCls:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function CurrEduCls_DelCurrEduClssAsync(arrid_CurrEduCls: Array<string>): Promise<number> 
{
const strThisFuncName = "DelCurrEduClssAsync";
const strAction = "DelCurrEduClss";
const strUrl = GetWebApiUrl(currEduCls_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrid_CurrEduCls);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduCls_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduCls_ConstructorName, strThisFuncName);
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
export async function CurrEduCls_DelCurrEduClssByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "DelCurrEduClssByCondAsync";
const strAction = "DelCurrEduClssByCond";
const strUrl = GetWebApiUrl(currEduCls_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduCls_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduCls_ConstructorName, strThisFuncName);
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
 * @param objCurrEduClsEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function CurrEduCls_AddNewRecordAsync(objCurrEduClsEN: clsCurrEduClsEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objCurrEduClsEN);
const strUrl = GetWebApiUrl(currEduCls_Controller, strAction);
try
{
const response = await axios.post(strUrl, objCurrEduClsEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduCls_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduCls_ConstructorName, strThisFuncName);
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
 * @param objCurrEduClsEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function CurrEduCls_AddNewRecordWithMaxIdAsync(objCurrEduClsEN: clsCurrEduClsEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithMaxIdAsync";
const strAction = "AddNewRecordWithMaxId";
const strUrl = GetWebApiUrl(currEduCls_Controller, strAction);
try
{
const response = await axios.post(strUrl, objCurrEduClsEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduCls_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduCls_ConstructorName, strThisFuncName);
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
 * @param objCurrEduClsEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function CurrEduCls_AddNewRecordWithReturnKeyAsync(objCurrEduClsEN: clsCurrEduClsEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(currEduCls_Controller, strAction);
try
{
const response = await axios.post(strUrl, objCurrEduClsEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduCls_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduCls_ConstructorName, strThisFuncName);
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
 * @param objCurrEduClsEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function CurrEduCls_AddNewRecordWithReturnKey(objCurrEduClsEN: clsCurrEduClsEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objCurrEduClsEN.id_CurrEduCls === null || objCurrEduClsEN.id_CurrEduCls === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(currEduCls_Controller, strAction);
try
{
const response = await axios.post(strUrl, objCurrEduClsEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduCls_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduCls_ConstructorName, strThisFuncName);
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
 * @param objCurrEduClsEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function CurrEduCls_UpdateRecordAsync(objCurrEduClsEN: clsCurrEduClsEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objCurrEduClsEN.sf_UpdFldSetStr === undefined || objCurrEduClsEN.sf_UpdFldSetStr === null || objCurrEduClsEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objCurrEduClsEN.id_CurrEduCls);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(currEduCls_Controller, strAction);
try
{
const response = await axios.post(strUrl, objCurrEduClsEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduCls_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduCls_ConstructorName, strThisFuncName);
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
 * @param objCurrEduClsEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function CurrEduCls_UpdateWithConditionAsync(objCurrEduClsEN: clsCurrEduClsEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objCurrEduClsEN.sf_UpdFldSetStr === undefined || objCurrEduClsEN.sf_UpdFldSetStr === null || objCurrEduClsEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objCurrEduClsEN.id_CurrEduCls);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(currEduCls_Controller, strAction);
objCurrEduClsEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objCurrEduClsEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduCls_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduCls_ConstructorName, strThisFuncName);
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
export async function CurrEduCls_IsExistRecord_Cache(objCurrEduCls_Cond: clsCurrEduClsEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrCurrEduClsObjLst_Cache = await CurrEduCls_GetObjLst_Cache();
if (arrCurrEduClsObjLst_Cache == null) return false;
let arrCurrEduCls_Sel: Array < clsCurrEduClsEN > = arrCurrEduClsObjLst_Cache;
if (objCurrEduCls_Cond.sf_FldComparisonOp == null || objCurrEduCls_Cond.sf_FldComparisonOp == "") return arrCurrEduCls_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objCurrEduCls_Cond.sf_FldComparisonOp);
//console.log("clsCurrEduClsWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objCurrEduCls_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objCurrEduCls_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrCurrEduCls_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objCurrEduCls_Cond), currEduCls_ConstructorName, strThisFuncName);
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
export async function CurrEduCls_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(currEduCls_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduCls_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduCls_ConstructorName, strThisFuncName);
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
export async function CurrEduCls_IsExist(strid_CurrEduCls: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(currEduCls_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduCls_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduCls_ConstructorName, strThisFuncName);
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
export async function CurrEduCls_IsExist_Cache(strid_CurrEduCls:string) {
const strThisFuncName = "IsExist_Cache";
const arrCurrEduClsObjLst_Cache = await CurrEduCls_GetObjLst_Cache();
if (arrCurrEduClsObjLst_Cache == null) return false;
try
{
const arrCurrEduCls_Sel: Array <clsCurrEduClsEN> = arrCurrEduClsObjLst_Cache.filter(x => x.id_CurrEduCls == strid_CurrEduCls);
if (arrCurrEduCls_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strid_CurrEduCls, currEduCls_ConstructorName, strThisFuncName);
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
export async function CurrEduCls_IsExistAsync(strid_CurrEduCls: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(currEduCls_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduCls_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduCls_ConstructorName, strThisFuncName);
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
export async function CurrEduCls_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(currEduCls_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduCls_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduCls_ConstructorName, strThisFuncName);
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
 * @param objCurrEduCls_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function CurrEduCls_GetRecCountByCond_Cache(objCurrEduCls_Cond: clsCurrEduClsEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrCurrEduClsObjLst_Cache = await CurrEduCls_GetObjLst_Cache();
if (arrCurrEduClsObjLst_Cache == null) return 0;
let arrCurrEduCls_Sel: Array < clsCurrEduClsEN > = arrCurrEduClsObjLst_Cache;
if (objCurrEduCls_Cond.sf_FldComparisonOp == null || objCurrEduCls_Cond.sf_FldComparisonOp == "") return arrCurrEduCls_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objCurrEduCls_Cond.sf_FldComparisonOp);
//console.log("clsCurrEduClsWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objCurrEduCls_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objCurrEduCls_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrCurrEduCls_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objCurrEduCls_Cond), currEduCls_ConstructorName, strThisFuncName);
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
export async function CurrEduCls_GetMaxStrIdAsync(): Promise<string>  
{
const strThisFuncName = "GetMaxStrIdAsync";
const strAction = "GetMaxStrId";
const strUrl = GetWebApiUrl(currEduCls_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduCls_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduCls_ConstructorName, strThisFuncName);
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
export async function CurrEduCls_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(currEduCls_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduCls_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduCls_ConstructorName, strThisFuncName);
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
export function CurrEduCls_GetWebApiUrl(strController: string, strAction: string): string {
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
export function CurrEduCls_ReFreshCache():void
{
const strThisFuncName = "ReFreshCache";

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = clsCurrEduClsEN._CurrTabName;
switch (clsCurrEduClsEN.CacheModeId)
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
export function CurrEduCls_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clsCurrEduClsEN._CurrTabName;
switch (clsCurrEduClsEN.CacheModeId)
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
export async function CurrEduCls_BindDdl_id_CurrEduClsInDiv_Cache(strDivName: string, strDdlName: string )
{
const strThisFuncName = "BindDdl_id_CurrEduClsInDiv_Cache";

const objDdl = document.getElementById(strDdlName);
if (objDdl == null)
{
const strMsg = Format("下拉框：{0} 不存在！(In BindDdl_id_CurrEduClsInDiv)", strDdlName);
alert(strMsg);
console.error(strMsg);
throw (strMsg);
}
//为数据源于表的下拉框设置内容
//console.log("开始：BindDdl_id_CurrEduClsInDiv_Cache");
const arrObjLst_Sel = await CurrEduCls_GetObjLst_Cache();
if (arrObjLst_Sel == null) return;
BindDdl_ObjLstInDiv(strDivName, strDdlName, arrObjLst_Sel, clsCurrEduClsEN.con_id_CurrEduCls, clsCurrEduClsEN.con_EduClsName, "当前教学班");
}

/**
 * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function CurrEduCls_CheckPropertyNew(pobjCurrEduClsEN: clsCurrEduClsEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjCurrEduClsEN.currEduClsId) === true )
{
 throw new Error("(errid:Watl000058)字段[教学班Id]不能为空(In 当前教学班)!(clsCurrEduClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.id_XzMajor) === true 
 || pobjCurrEduClsEN.id_XzMajor.toString()  ===  "0" )
{
 throw new Error("(errid:Watl000058)字段[专业流水号]不能为空(In 当前教学班)!(clsCurrEduClsBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjCurrEduClsEN.id_CurrEduCls) == false && GetStrLen(pobjCurrEduClsEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.id_CurrEduCls)(clsCurrEduClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.currEduClsId) == false && GetStrLen(pobjCurrEduClsEN.currEduClsId) > 15)
{
 throw new Error("(errid:Watl000059)字段[教学班Id(currEduClsId)]的长度不能超过15(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.currEduClsId)(clsCurrEduClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.eduClsName) == false && GetStrLen(pobjCurrEduClsEN.eduClsName) > 100)
{
 throw new Error("(errid:Watl000059)字段[教学班名(eduClsName)]的长度不能超过100(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.eduClsName)(clsCurrEduClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.eduClsTypeId) == false && GetStrLen(pobjCurrEduClsEN.eduClsTypeId) > 4)
{
 throw new Error("(errid:Watl000059)字段[教学班类型Id(eduClsTypeId)]的长度不能超过4(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.eduClsTypeId)(clsCurrEduClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.courseId) == false && GetStrLen(pobjCurrEduClsEN.courseId) > 8)
{
 throw new Error("(errid:Watl000059)字段[课程Id(courseId)]的长度不能超过8(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.courseId)(clsCurrEduClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.teachingSolutionId) == false && GetStrLen(pobjCurrEduClsEN.teachingSolutionId) > 8)
{
 throw new Error("(errid:Watl000059)字段[教学方案Id(teachingSolutionId)]的长度不能超过8(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.teachingSolutionId)(clsCurrEduClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.id_XzCollege) == false && GetStrLen(pobjCurrEduClsEN.id_XzCollege) > 4)
{
 throw new Error("(errid:Watl000059)字段[学院流水号(id_XzCollege)]的长度不能超过4(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.id_XzCollege)(clsCurrEduClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.id_XzMajor) == false && GetStrLen(pobjCurrEduClsEN.id_XzMajor) > 8)
{
 throw new Error("(errid:Watl000059)字段[专业流水号(id_XzMajor)]的长度不能超过8(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.id_XzMajor)(clsCurrEduClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.id_EduWay) == false && GetStrLen(pobjCurrEduClsEN.id_EduWay) > 4)
{
 throw new Error("(errid:Watl000059)字段[教学方式流水号(id_EduWay)]的长度不能超过4(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.id_EduWay)(clsCurrEduClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.id_ClassRoomType) == false && GetStrLen(pobjCurrEduClsEN.id_ClassRoomType) > 4)
{
 throw new Error("(errid:Watl000059)字段[教室类型流水号(id_ClassRoomType)]的长度不能超过4(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.id_ClassRoomType)(clsCurrEduClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.weekStatusID) == false && GetStrLen(pobjCurrEduClsEN.weekStatusID) > 2)
{
 throw new Error("(errid:Watl000059)字段[周状态编号(单,双,全周)(weekStatusID)]的长度不能超过2(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.weekStatusID)(clsCurrEduClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.customerWeek) == false && GetStrLen(pobjCurrEduClsEN.customerWeek) > 50)
{
 throw new Error("(errid:Watl000059)字段[自定义上课周(customerWeek)]的长度不能超过50(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.customerWeek)(clsCurrEduClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.id_UniZone) == false && GetStrLen(pobjCurrEduClsEN.id_UniZone) > 4)
{
 throw new Error("(errid:Watl000059)字段[校区流水号(id_UniZone)]的长度不能超过4(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.id_UniZone)(clsCurrEduClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.id_GradeBase) == false && GetStrLen(pobjCurrEduClsEN.id_GradeBase) > 4)
{
 throw new Error("(errid:Watl000059)字段[年级流水号(id_GradeBase)]的长度不能超过4(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.id_GradeBase)(clsCurrEduClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.schoolYear) == false && GetStrLen(pobjCurrEduClsEN.schoolYear) > 10)
{
 throw new Error("(errid:Watl000059)字段[学年(schoolYear)]的长度不能超过10(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.schoolYear)(clsCurrEduClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.schoolTerm) == false && GetStrLen(pobjCurrEduClsEN.schoolTerm) > 1)
{
 throw new Error("(errid:Watl000059)字段[学期(schoolTerm)]的长度不能超过1(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.schoolTerm)(clsCurrEduClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.id_CourseType) == false && GetStrLen(pobjCurrEduClsEN.id_CourseType) > 4)
{
 throw new Error("(errid:Watl000059)字段[课程类型流水号(id_CourseType)]的长度不能超过4(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.id_CourseType)(clsCurrEduClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.id_ScoreType) == false && GetStrLen(pobjCurrEduClsEN.id_ScoreType) > 4)
{
 throw new Error("(errid:Watl000059)字段[成绩类型流水号(id_ScoreType)]的长度不能超过4(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.id_ScoreType)(clsCurrEduClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.getScoreWayId) == false && GetStrLen(pobjCurrEduClsEN.getScoreWayId) > 2)
{
 throw new Error("(errid:Watl000059)字段[获得成绩方式Id(getScoreWayId)]的长度不能超过2(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.getScoreWayId)(clsCurrEduClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.id_ExamType) == false && GetStrLen(pobjCurrEduClsEN.id_ExamType) > 4)
{
 throw new Error("(errid:Watl000059)字段[考试方式流水号(id_ExamType)]的长度不能超过4(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.id_ExamType)(clsCurrEduClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.examTime) == false && GetStrLen(pobjCurrEduClsEN.examTime) > 8)
{
 throw new Error("(errid:Watl000059)字段[考试时间(examTime)]的长度不能超过8(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.examTime)(clsCurrEduClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.modifyDate) == false && GetStrLen(pobjCurrEduClsEN.modifyDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(modifyDate)]的长度不能超过20(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.modifyDate)(clsCurrEduClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.modifyUserID) == false && GetStrLen(pobjCurrEduClsEN.modifyUserID) > 18)
{
 throw new Error("(errid:Watl000059)字段[修改人(modifyUserID)]的长度不能超过18(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.modifyUserID)(clsCurrEduClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.memo) == false && GetStrLen(pobjCurrEduClsEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.memo)(clsCurrEduClsBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjCurrEduClsEN.id_CurrEduCls) == false && undefined !== pobjCurrEduClsEN.id_CurrEduCls && tzDataType.isString(pobjCurrEduClsEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjCurrEduClsEN.id_CurrEduCls)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.currEduClsId) == false && undefined !== pobjCurrEduClsEN.currEduClsId && tzDataType.isString(pobjCurrEduClsEN.currEduClsId) === false)
{
 throw new Error("(errid:Watl000060)字段[教学班Id(currEduClsId)]的值:[$(pobjCurrEduClsEN.currEduClsId)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.eduClsName) == false && undefined !== pobjCurrEduClsEN.eduClsName && tzDataType.isString(pobjCurrEduClsEN.eduClsName) === false)
{
 throw new Error("(errid:Watl000060)字段[教学班名(eduClsName)]的值:[$(pobjCurrEduClsEN.eduClsName)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.eduClsTypeId) == false && undefined !== pobjCurrEduClsEN.eduClsTypeId && tzDataType.isString(pobjCurrEduClsEN.eduClsTypeId) === false)
{
 throw new Error("(errid:Watl000060)字段[教学班类型Id(eduClsTypeId)]的值:[$(pobjCurrEduClsEN.eduClsTypeId)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.courseId) == false && undefined !== pobjCurrEduClsEN.courseId && tzDataType.isString(pobjCurrEduClsEN.courseId) === false)
{
 throw new Error("(errid:Watl000060)字段[课程Id(courseId)]的值:[$(pobjCurrEduClsEN.courseId)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.teachingSolutionId) == false && undefined !== pobjCurrEduClsEN.teachingSolutionId && tzDataType.isString(pobjCurrEduClsEN.teachingSolutionId) === false)
{
 throw new Error("(errid:Watl000060)字段[教学方案Id(teachingSolutionId)]的值:[$(pobjCurrEduClsEN.teachingSolutionId)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.id_XzCollege) == false && undefined !== pobjCurrEduClsEN.id_XzCollege && tzDataType.isString(pobjCurrEduClsEN.id_XzCollege) === false)
{
 throw new Error("(errid:Watl000060)字段[学院流水号(id_XzCollege)]的值:[$(pobjCurrEduClsEN.id_XzCollege)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.id_XzMajor) == false && undefined !== pobjCurrEduClsEN.id_XzMajor && tzDataType.isString(pobjCurrEduClsEN.id_XzMajor) === false)
{
 throw new Error("(errid:Watl000060)字段[专业流水号(id_XzMajor)]的值:[$(pobjCurrEduClsEN.id_XzMajor)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.id_EduWay) == false && undefined !== pobjCurrEduClsEN.id_EduWay && tzDataType.isString(pobjCurrEduClsEN.id_EduWay) === false)
{
 throw new Error("(errid:Watl000060)字段[教学方式流水号(id_EduWay)]的值:[$(pobjCurrEduClsEN.id_EduWay)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.id_ClassRoomType) == false && undefined !== pobjCurrEduClsEN.id_ClassRoomType && tzDataType.isString(pobjCurrEduClsEN.id_ClassRoomType) === false)
{
 throw new Error("(errid:Watl000060)字段[教室类型流水号(id_ClassRoomType)]的值:[$(pobjCurrEduClsEN.id_ClassRoomType)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
}
if (null != pobjCurrEduClsEN.totalLessonQty && undefined !== pobjCurrEduClsEN.totalLessonQty && tzDataType.isNumber(pobjCurrEduClsEN.totalLessonQty) === false)
{
 throw new Error("(errid:Watl000060)字段[总课时数(totalLessonQty)]的值:[$(pobjCurrEduClsEN.totalLessonQty)], 非法，应该为数值型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
}
if (null != pobjCurrEduClsEN.maxStuQty && undefined !== pobjCurrEduClsEN.maxStuQty && tzDataType.isNumber(pobjCurrEduClsEN.maxStuQty) === false)
{
 throw new Error("(errid:Watl000060)字段[最大学生数(maxStuQty)]的值:[$(pobjCurrEduClsEN.maxStuQty)], 非法，应该为数值型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
}
if (null != pobjCurrEduClsEN.weekQty && undefined !== pobjCurrEduClsEN.weekQty && tzDataType.isNumber(pobjCurrEduClsEN.weekQty) === false)
{
 throw new Error("(errid:Watl000060)字段[总周数(weekQty)]的值:[$(pobjCurrEduClsEN.weekQty)], 非法，应该为数值型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
}
if (null != pobjCurrEduClsEN.scheUnitPW && undefined !== pobjCurrEduClsEN.scheUnitPW && tzDataType.isNumber(pobjCurrEduClsEN.scheUnitPW) === false)
{
 throw new Error("(errid:Watl000060)字段[周排课次数(scheUnitPW)]的值:[$(pobjCurrEduClsEN.scheUnitPW)], 非法，应该为数值型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.weekStatusID) == false && undefined !== pobjCurrEduClsEN.weekStatusID && tzDataType.isString(pobjCurrEduClsEN.weekStatusID) === false)
{
 throw new Error("(errid:Watl000060)字段[周状态编号(单,双,全周)(weekStatusID)]的值:[$(pobjCurrEduClsEN.weekStatusID)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.customerWeek) == false && undefined !== pobjCurrEduClsEN.customerWeek && tzDataType.isString(pobjCurrEduClsEN.customerWeek) === false)
{
 throw new Error("(errid:Watl000060)字段[自定义上课周(customerWeek)]的值:[$(pobjCurrEduClsEN.customerWeek)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
}
if (null != pobjCurrEduClsEN.lessonQtyPerWeek && undefined !== pobjCurrEduClsEN.lessonQtyPerWeek && tzDataType.isNumber(pobjCurrEduClsEN.lessonQtyPerWeek) === false)
{
 throw new Error("(errid:Watl000060)字段[周课时数(lessonQtyPerWeek)]的值:[$(pobjCurrEduClsEN.lessonQtyPerWeek)], 非法，应该为数值型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
}
if (null != pobjCurrEduClsEN.mark && undefined !== pobjCurrEduClsEN.mark && tzDataType.isNumber(pobjCurrEduClsEN.mark) === false)
{
 throw new Error("(errid:Watl000060)字段[获得学分(mark)]的值:[$(pobjCurrEduClsEN.mark)], 非法，应该为数值型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.id_UniZone) == false && undefined !== pobjCurrEduClsEN.id_UniZone && tzDataType.isString(pobjCurrEduClsEN.id_UniZone) === false)
{
 throw new Error("(errid:Watl000060)字段[校区流水号(id_UniZone)]的值:[$(pobjCurrEduClsEN.id_UniZone)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.id_GradeBase) == false && undefined !== pobjCurrEduClsEN.id_GradeBase && tzDataType.isString(pobjCurrEduClsEN.id_GradeBase) === false)
{
 throw new Error("(errid:Watl000060)字段[年级流水号(id_GradeBase)]的值:[$(pobjCurrEduClsEN.id_GradeBase)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
}
if (null != pobjCurrEduClsEN.isEffective && undefined !== pobjCurrEduClsEN.isEffective && tzDataType.isBoolean(pobjCurrEduClsEN.isEffective) === false)
{
 throw new Error("(errid:Watl000060)字段[是否有效(isEffective)]的值:[$(pobjCurrEduClsEN.isEffective)], 非法，应该为布尔型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
}
if (null != pobjCurrEduClsEN.isForPaperReading && undefined !== pobjCurrEduClsEN.isForPaperReading && tzDataType.isBoolean(pobjCurrEduClsEN.isForPaperReading) === false)
{
 throw new Error("(errid:Watl000060)字段[是否参与论文阅读(isForPaperReading)]的值:[$(pobjCurrEduClsEN.isForPaperReading)], 非法，应该为布尔型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.schoolYear) == false && undefined !== pobjCurrEduClsEN.schoolYear && tzDataType.isString(pobjCurrEduClsEN.schoolYear) === false)
{
 throw new Error("(errid:Watl000060)字段[学年(schoolYear)]的值:[$(pobjCurrEduClsEN.schoolYear)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.schoolTerm) == false && undefined !== pobjCurrEduClsEN.schoolTerm && tzDataType.isString(pobjCurrEduClsEN.schoolTerm) === false)
{
 throw new Error("(errid:Watl000060)字段[学期(schoolTerm)]的值:[$(pobjCurrEduClsEN.schoolTerm)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.id_CourseType) == false && undefined !== pobjCurrEduClsEN.id_CourseType && tzDataType.isString(pobjCurrEduClsEN.id_CourseType) === false)
{
 throw new Error("(errid:Watl000060)字段[课程类型流水号(id_CourseType)]的值:[$(pobjCurrEduClsEN.id_CourseType)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
}
if (null != pobjCurrEduClsEN.isDegree && undefined !== pobjCurrEduClsEN.isDegree && tzDataType.isBoolean(pobjCurrEduClsEN.isDegree) === false)
{
 throw new Error("(errid:Watl000060)字段[是否学位课(isDegree)]的值:[$(pobjCurrEduClsEN.isDegree)], 非法，应该为布尔型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.id_ScoreType) == false && undefined !== pobjCurrEduClsEN.id_ScoreType && tzDataType.isString(pobjCurrEduClsEN.id_ScoreType) === false)
{
 throw new Error("(errid:Watl000060)字段[成绩类型流水号(id_ScoreType)]的值:[$(pobjCurrEduClsEN.id_ScoreType)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.getScoreWayId) == false && undefined !== pobjCurrEduClsEN.getScoreWayId && tzDataType.isString(pobjCurrEduClsEN.getScoreWayId) === false)
{
 throw new Error("(errid:Watl000060)字段[获得成绩方式Id(getScoreWayId)]的值:[$(pobjCurrEduClsEN.getScoreWayId)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
}
if (null != pobjCurrEduClsEN.isProportionalCtrl && undefined !== pobjCurrEduClsEN.isProportionalCtrl && tzDataType.isBoolean(pobjCurrEduClsEN.isProportionalCtrl) === false)
{
 throw new Error("(errid:Watl000060)字段[是否比例控制(isProportionalCtrl)]的值:[$(pobjCurrEduClsEN.isProportionalCtrl)], 非法，应该为布尔型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.id_ExamType) == false && undefined !== pobjCurrEduClsEN.id_ExamType && tzDataType.isString(pobjCurrEduClsEN.id_ExamType) === false)
{
 throw new Error("(errid:Watl000060)字段[考试方式流水号(id_ExamType)]的值:[$(pobjCurrEduClsEN.id_ExamType)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.examTime) == false && undefined !== pobjCurrEduClsEN.examTime && tzDataType.isString(pobjCurrEduClsEN.examTime) === false)
{
 throw new Error("(errid:Watl000060)字段[考试时间(examTime)]的值:[$(pobjCurrEduClsEN.examTime)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
}
if (null != pobjCurrEduClsEN.beginWeek && undefined !== pobjCurrEduClsEN.beginWeek && tzDataType.isNumber(pobjCurrEduClsEN.beginWeek) === false)
{
 throw new Error("(errid:Watl000060)字段[开始周(beginWeek)]的值:[$(pobjCurrEduClsEN.beginWeek)], 非法，应该为数值型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.modifyDate) == false && undefined !== pobjCurrEduClsEN.modifyDate && tzDataType.isString(pobjCurrEduClsEN.modifyDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(modifyDate)]的值:[$(pobjCurrEduClsEN.modifyDate)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.modifyUserID) == false && undefined !== pobjCurrEduClsEN.modifyUserID && tzDataType.isString(pobjCurrEduClsEN.modifyUserID) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(modifyUserID)]的值:[$(pobjCurrEduClsEN.modifyUserID)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.memo) == false && undefined !== pobjCurrEduClsEN.memo && tzDataType.isString(pobjCurrEduClsEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjCurrEduClsEN.memo)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
if (IsNullOrEmpty(pobjCurrEduClsEN.courseId) == false && GetStrLen(pobjCurrEduClsEN.courseId) !=  8)
{
 throw ("(errid:Watl000061)字段[课程Id]作为外键字段,长度应该为8(In 当前教学班)!(clsCurrEduClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.id_EduWay) == false && GetStrLen(pobjCurrEduClsEN.id_EduWay) !=  4)
{
 throw ("(errid:Watl000061)字段[教学方式流水号]作为外键字段,长度应该为4(In 当前教学班)!(clsCurrEduClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.id_ClassRoomType) == false && GetStrLen(pobjCurrEduClsEN.id_ClassRoomType) !=  4)
{
 throw ("(errid:Watl000061)字段[教室类型流水号]作为外键字段,长度应该为4(In 当前教学班)!(clsCurrEduClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.weekStatusID) == false && GetStrLen(pobjCurrEduClsEN.weekStatusID) !=  2)
{
 throw ("(errid:Watl000061)字段[周状态编号(单,双,全周)]作为外键字段,长度应该为2(In 当前教学班)!(clsCurrEduClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.id_UniZone) == false && GetStrLen(pobjCurrEduClsEN.id_UniZone) !=  4)
{
 throw ("(errid:Watl000061)字段[校区流水号]作为外键字段,长度应该为4(In 当前教学班)!(clsCurrEduClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.id_GradeBase) == false && GetStrLen(pobjCurrEduClsEN.id_GradeBase) !=  4)
{
 throw ("(errid:Watl000061)字段[年级流水号]作为外键字段,长度应该为4(In 当前教学班)!(clsCurrEduClsBL:CheckPropertyNew)");
}

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjCurrEduClsEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function CurrEduCls_CheckProperty4Update (pobjCurrEduClsEN: clsCurrEduClsEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjCurrEduClsEN.id_CurrEduCls) == false && GetStrLen(pobjCurrEduClsEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.id_CurrEduCls)(clsCurrEduClsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.currEduClsId) == false && GetStrLen(pobjCurrEduClsEN.currEduClsId) > 15)
{
 throw new Error("(errid:Watl000062)字段[教学班Id(currEduClsId)]的长度不能超过15(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.currEduClsId)(clsCurrEduClsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.eduClsName) == false && GetStrLen(pobjCurrEduClsEN.eduClsName) > 100)
{
 throw new Error("(errid:Watl000062)字段[教学班名(eduClsName)]的长度不能超过100(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.eduClsName)(clsCurrEduClsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.eduClsTypeId) == false && GetStrLen(pobjCurrEduClsEN.eduClsTypeId) > 4)
{
 throw new Error("(errid:Watl000062)字段[教学班类型Id(eduClsTypeId)]的长度不能超过4(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.eduClsTypeId)(clsCurrEduClsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.courseId) == false && GetStrLen(pobjCurrEduClsEN.courseId) > 8)
{
 throw new Error("(errid:Watl000062)字段[课程Id(courseId)]的长度不能超过8(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.courseId)(clsCurrEduClsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.teachingSolutionId) == false && GetStrLen(pobjCurrEduClsEN.teachingSolutionId) > 8)
{
 throw new Error("(errid:Watl000062)字段[教学方案Id(teachingSolutionId)]的长度不能超过8(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.teachingSolutionId)(clsCurrEduClsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.id_XzCollege) == false && GetStrLen(pobjCurrEduClsEN.id_XzCollege) > 4)
{
 throw new Error("(errid:Watl000062)字段[学院流水号(id_XzCollege)]的长度不能超过4(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.id_XzCollege)(clsCurrEduClsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.id_XzMajor) == false && GetStrLen(pobjCurrEduClsEN.id_XzMajor) > 8)
{
 throw new Error("(errid:Watl000062)字段[专业流水号(id_XzMajor)]的长度不能超过8(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.id_XzMajor)(clsCurrEduClsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.id_EduWay) == false && GetStrLen(pobjCurrEduClsEN.id_EduWay) > 4)
{
 throw new Error("(errid:Watl000062)字段[教学方式流水号(id_EduWay)]的长度不能超过4(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.id_EduWay)(clsCurrEduClsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.id_ClassRoomType) == false && GetStrLen(pobjCurrEduClsEN.id_ClassRoomType) > 4)
{
 throw new Error("(errid:Watl000062)字段[教室类型流水号(id_ClassRoomType)]的长度不能超过4(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.id_ClassRoomType)(clsCurrEduClsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.weekStatusID) == false && GetStrLen(pobjCurrEduClsEN.weekStatusID) > 2)
{
 throw new Error("(errid:Watl000062)字段[周状态编号(单,双,全周)(weekStatusID)]的长度不能超过2(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.weekStatusID)(clsCurrEduClsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.customerWeek) == false && GetStrLen(pobjCurrEduClsEN.customerWeek) > 50)
{
 throw new Error("(errid:Watl000062)字段[自定义上课周(customerWeek)]的长度不能超过50(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.customerWeek)(clsCurrEduClsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.id_UniZone) == false && GetStrLen(pobjCurrEduClsEN.id_UniZone) > 4)
{
 throw new Error("(errid:Watl000062)字段[校区流水号(id_UniZone)]的长度不能超过4(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.id_UniZone)(clsCurrEduClsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.id_GradeBase) == false && GetStrLen(pobjCurrEduClsEN.id_GradeBase) > 4)
{
 throw new Error("(errid:Watl000062)字段[年级流水号(id_GradeBase)]的长度不能超过4(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.id_GradeBase)(clsCurrEduClsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.schoolYear) == false && GetStrLen(pobjCurrEduClsEN.schoolYear) > 10)
{
 throw new Error("(errid:Watl000062)字段[学年(schoolYear)]的长度不能超过10(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.schoolYear)(clsCurrEduClsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.schoolTerm) == false && GetStrLen(pobjCurrEduClsEN.schoolTerm) > 1)
{
 throw new Error("(errid:Watl000062)字段[学期(schoolTerm)]的长度不能超过1(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.schoolTerm)(clsCurrEduClsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.id_CourseType) == false && GetStrLen(pobjCurrEduClsEN.id_CourseType) > 4)
{
 throw new Error("(errid:Watl000062)字段[课程类型流水号(id_CourseType)]的长度不能超过4(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.id_CourseType)(clsCurrEduClsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.id_ScoreType) == false && GetStrLen(pobjCurrEduClsEN.id_ScoreType) > 4)
{
 throw new Error("(errid:Watl000062)字段[成绩类型流水号(id_ScoreType)]的长度不能超过4(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.id_ScoreType)(clsCurrEduClsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.getScoreWayId) == false && GetStrLen(pobjCurrEduClsEN.getScoreWayId) > 2)
{
 throw new Error("(errid:Watl000062)字段[获得成绩方式Id(getScoreWayId)]的长度不能超过2(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.getScoreWayId)(clsCurrEduClsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.id_ExamType) == false && GetStrLen(pobjCurrEduClsEN.id_ExamType) > 4)
{
 throw new Error("(errid:Watl000062)字段[考试方式流水号(id_ExamType)]的长度不能超过4(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.id_ExamType)(clsCurrEduClsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.examTime) == false && GetStrLen(pobjCurrEduClsEN.examTime) > 8)
{
 throw new Error("(errid:Watl000062)字段[考试时间(examTime)]的长度不能超过8(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.examTime)(clsCurrEduClsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.modifyDate) == false && GetStrLen(pobjCurrEduClsEN.modifyDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(modifyDate)]的长度不能超过20(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.modifyDate)(clsCurrEduClsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.modifyUserID) == false && GetStrLen(pobjCurrEduClsEN.modifyUserID) > 18)
{
 throw new Error("(errid:Watl000062)字段[修改人(modifyUserID)]的长度不能超过18(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.modifyUserID)(clsCurrEduClsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.memo) == false && GetStrLen(pobjCurrEduClsEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.memo)(clsCurrEduClsBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjCurrEduClsEN.id_CurrEduCls) == false && undefined !== pobjCurrEduClsEN.id_CurrEduCls && tzDataType.isString(pobjCurrEduClsEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjCurrEduClsEN.id_CurrEduCls)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.currEduClsId) == false && undefined !== pobjCurrEduClsEN.currEduClsId && tzDataType.isString(pobjCurrEduClsEN.currEduClsId) === false)
{
 throw new Error("(errid:Watl000063)字段[教学班Id(currEduClsId)]的值:[$(pobjCurrEduClsEN.currEduClsId)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.eduClsName) == false && undefined !== pobjCurrEduClsEN.eduClsName && tzDataType.isString(pobjCurrEduClsEN.eduClsName) === false)
{
 throw new Error("(errid:Watl000063)字段[教学班名(eduClsName)]的值:[$(pobjCurrEduClsEN.eduClsName)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.eduClsTypeId) == false && undefined !== pobjCurrEduClsEN.eduClsTypeId && tzDataType.isString(pobjCurrEduClsEN.eduClsTypeId) === false)
{
 throw new Error("(errid:Watl000063)字段[教学班类型Id(eduClsTypeId)]的值:[$(pobjCurrEduClsEN.eduClsTypeId)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.courseId) == false && undefined !== pobjCurrEduClsEN.courseId && tzDataType.isString(pobjCurrEduClsEN.courseId) === false)
{
 throw new Error("(errid:Watl000063)字段[课程Id(courseId)]的值:[$(pobjCurrEduClsEN.courseId)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.teachingSolutionId) == false && undefined !== pobjCurrEduClsEN.teachingSolutionId && tzDataType.isString(pobjCurrEduClsEN.teachingSolutionId) === false)
{
 throw new Error("(errid:Watl000063)字段[教学方案Id(teachingSolutionId)]的值:[$(pobjCurrEduClsEN.teachingSolutionId)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.id_XzCollege) == false && undefined !== pobjCurrEduClsEN.id_XzCollege && tzDataType.isString(pobjCurrEduClsEN.id_XzCollege) === false)
{
 throw new Error("(errid:Watl000063)字段[学院流水号(id_XzCollege)]的值:[$(pobjCurrEduClsEN.id_XzCollege)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.id_XzMajor) == false && undefined !== pobjCurrEduClsEN.id_XzMajor && tzDataType.isString(pobjCurrEduClsEN.id_XzMajor) === false)
{
 throw new Error("(errid:Watl000063)字段[专业流水号(id_XzMajor)]的值:[$(pobjCurrEduClsEN.id_XzMajor)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.id_EduWay) == false && undefined !== pobjCurrEduClsEN.id_EduWay && tzDataType.isString(pobjCurrEduClsEN.id_EduWay) === false)
{
 throw new Error("(errid:Watl000063)字段[教学方式流水号(id_EduWay)]的值:[$(pobjCurrEduClsEN.id_EduWay)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.id_ClassRoomType) == false && undefined !== pobjCurrEduClsEN.id_ClassRoomType && tzDataType.isString(pobjCurrEduClsEN.id_ClassRoomType) === false)
{
 throw new Error("(errid:Watl000063)字段[教室类型流水号(id_ClassRoomType)]的值:[$(pobjCurrEduClsEN.id_ClassRoomType)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
}
if (null != pobjCurrEduClsEN.totalLessonQty && undefined !== pobjCurrEduClsEN.totalLessonQty && tzDataType.isNumber(pobjCurrEduClsEN.totalLessonQty) === false)
{
 throw new Error("(errid:Watl000063)字段[总课时数(totalLessonQty)]的值:[$(pobjCurrEduClsEN.totalLessonQty)], 非法，应该为数值型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
}
if (null != pobjCurrEduClsEN.maxStuQty && undefined !== pobjCurrEduClsEN.maxStuQty && tzDataType.isNumber(pobjCurrEduClsEN.maxStuQty) === false)
{
 throw new Error("(errid:Watl000063)字段[最大学生数(maxStuQty)]的值:[$(pobjCurrEduClsEN.maxStuQty)], 非法，应该为数值型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
}
if (null != pobjCurrEduClsEN.weekQty && undefined !== pobjCurrEduClsEN.weekQty && tzDataType.isNumber(pobjCurrEduClsEN.weekQty) === false)
{
 throw new Error("(errid:Watl000063)字段[总周数(weekQty)]的值:[$(pobjCurrEduClsEN.weekQty)], 非法，应该为数值型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
}
if (null != pobjCurrEduClsEN.scheUnitPW && undefined !== pobjCurrEduClsEN.scheUnitPW && tzDataType.isNumber(pobjCurrEduClsEN.scheUnitPW) === false)
{
 throw new Error("(errid:Watl000063)字段[周排课次数(scheUnitPW)]的值:[$(pobjCurrEduClsEN.scheUnitPW)], 非法，应该为数值型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.weekStatusID) == false && undefined !== pobjCurrEduClsEN.weekStatusID && tzDataType.isString(pobjCurrEduClsEN.weekStatusID) === false)
{
 throw new Error("(errid:Watl000063)字段[周状态编号(单,双,全周)(weekStatusID)]的值:[$(pobjCurrEduClsEN.weekStatusID)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.customerWeek) == false && undefined !== pobjCurrEduClsEN.customerWeek && tzDataType.isString(pobjCurrEduClsEN.customerWeek) === false)
{
 throw new Error("(errid:Watl000063)字段[自定义上课周(customerWeek)]的值:[$(pobjCurrEduClsEN.customerWeek)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
}
if (null != pobjCurrEduClsEN.lessonQtyPerWeek && undefined !== pobjCurrEduClsEN.lessonQtyPerWeek && tzDataType.isNumber(pobjCurrEduClsEN.lessonQtyPerWeek) === false)
{
 throw new Error("(errid:Watl000063)字段[周课时数(lessonQtyPerWeek)]的值:[$(pobjCurrEduClsEN.lessonQtyPerWeek)], 非法，应该为数值型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
}
if (null != pobjCurrEduClsEN.mark && undefined !== pobjCurrEduClsEN.mark && tzDataType.isNumber(pobjCurrEduClsEN.mark) === false)
{
 throw new Error("(errid:Watl000063)字段[获得学分(mark)]的值:[$(pobjCurrEduClsEN.mark)], 非法，应该为数值型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.id_UniZone) == false && undefined !== pobjCurrEduClsEN.id_UniZone && tzDataType.isString(pobjCurrEduClsEN.id_UniZone) === false)
{
 throw new Error("(errid:Watl000063)字段[校区流水号(id_UniZone)]的值:[$(pobjCurrEduClsEN.id_UniZone)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.id_GradeBase) == false && undefined !== pobjCurrEduClsEN.id_GradeBase && tzDataType.isString(pobjCurrEduClsEN.id_GradeBase) === false)
{
 throw new Error("(errid:Watl000063)字段[年级流水号(id_GradeBase)]的值:[$(pobjCurrEduClsEN.id_GradeBase)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
}
if (null != pobjCurrEduClsEN.isEffective && undefined !== pobjCurrEduClsEN.isEffective && tzDataType.isBoolean(pobjCurrEduClsEN.isEffective) === false)
{
 throw new Error("(errid:Watl000063)字段[是否有效(isEffective)]的值:[$(pobjCurrEduClsEN.isEffective)], 非法，应该为布尔型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
}
if (null != pobjCurrEduClsEN.isForPaperReading && undefined !== pobjCurrEduClsEN.isForPaperReading && tzDataType.isBoolean(pobjCurrEduClsEN.isForPaperReading) === false)
{
 throw new Error("(errid:Watl000063)字段[是否参与论文阅读(isForPaperReading)]的值:[$(pobjCurrEduClsEN.isForPaperReading)], 非法，应该为布尔型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.schoolYear) == false && undefined !== pobjCurrEduClsEN.schoolYear && tzDataType.isString(pobjCurrEduClsEN.schoolYear) === false)
{
 throw new Error("(errid:Watl000063)字段[学年(schoolYear)]的值:[$(pobjCurrEduClsEN.schoolYear)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.schoolTerm) == false && undefined !== pobjCurrEduClsEN.schoolTerm && tzDataType.isString(pobjCurrEduClsEN.schoolTerm) === false)
{
 throw new Error("(errid:Watl000063)字段[学期(schoolTerm)]的值:[$(pobjCurrEduClsEN.schoolTerm)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.id_CourseType) == false && undefined !== pobjCurrEduClsEN.id_CourseType && tzDataType.isString(pobjCurrEduClsEN.id_CourseType) === false)
{
 throw new Error("(errid:Watl000063)字段[课程类型流水号(id_CourseType)]的值:[$(pobjCurrEduClsEN.id_CourseType)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
}
if (null != pobjCurrEduClsEN.isDegree && undefined !== pobjCurrEduClsEN.isDegree && tzDataType.isBoolean(pobjCurrEduClsEN.isDegree) === false)
{
 throw new Error("(errid:Watl000063)字段[是否学位课(isDegree)]的值:[$(pobjCurrEduClsEN.isDegree)], 非法，应该为布尔型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.id_ScoreType) == false && undefined !== pobjCurrEduClsEN.id_ScoreType && tzDataType.isString(pobjCurrEduClsEN.id_ScoreType) === false)
{
 throw new Error("(errid:Watl000063)字段[成绩类型流水号(id_ScoreType)]的值:[$(pobjCurrEduClsEN.id_ScoreType)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.getScoreWayId) == false && undefined !== pobjCurrEduClsEN.getScoreWayId && tzDataType.isString(pobjCurrEduClsEN.getScoreWayId) === false)
{
 throw new Error("(errid:Watl000063)字段[获得成绩方式Id(getScoreWayId)]的值:[$(pobjCurrEduClsEN.getScoreWayId)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
}
if (null != pobjCurrEduClsEN.isProportionalCtrl && undefined !== pobjCurrEduClsEN.isProportionalCtrl && tzDataType.isBoolean(pobjCurrEduClsEN.isProportionalCtrl) === false)
{
 throw new Error("(errid:Watl000063)字段[是否比例控制(isProportionalCtrl)]的值:[$(pobjCurrEduClsEN.isProportionalCtrl)], 非法，应该为布尔型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.id_ExamType) == false && undefined !== pobjCurrEduClsEN.id_ExamType && tzDataType.isString(pobjCurrEduClsEN.id_ExamType) === false)
{
 throw new Error("(errid:Watl000063)字段[考试方式流水号(id_ExamType)]的值:[$(pobjCurrEduClsEN.id_ExamType)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.examTime) == false && undefined !== pobjCurrEduClsEN.examTime && tzDataType.isString(pobjCurrEduClsEN.examTime) === false)
{
 throw new Error("(errid:Watl000063)字段[考试时间(examTime)]的值:[$(pobjCurrEduClsEN.examTime)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
}
if (null != pobjCurrEduClsEN.beginWeek && undefined !== pobjCurrEduClsEN.beginWeek && tzDataType.isNumber(pobjCurrEduClsEN.beginWeek) === false)
{
 throw new Error("(errid:Watl000063)字段[开始周(beginWeek)]的值:[$(pobjCurrEduClsEN.beginWeek)], 非法，应该为数值型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.modifyDate) == false && undefined !== pobjCurrEduClsEN.modifyDate && tzDataType.isString(pobjCurrEduClsEN.modifyDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(modifyDate)]的值:[$(pobjCurrEduClsEN.modifyDate)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.modifyUserID) == false && undefined !== pobjCurrEduClsEN.modifyUserID && tzDataType.isString(pobjCurrEduClsEN.modifyUserID) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(modifyUserID)]的值:[$(pobjCurrEduClsEN.modifyUserID)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.memo) == false && undefined !== pobjCurrEduClsEN.memo && tzDataType.isString(pobjCurrEduClsEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjCurrEduClsEN.memo)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (IsNullOrEmpty(pobjCurrEduClsEN.id_CurrEduCls) === true 
 || pobjCurrEduClsEN.id_CurrEduCls.toString()  ===  "0" )
{
 throw new Error("(errid:Watl000064)字段[教学班流水号]不能为空(In 当前教学班)!(clsCurrEduClsBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
if (IsNullOrEmpty(pobjCurrEduClsEN.courseId) == false && GetStrLen(pobjCurrEduClsEN.courseId) !=  8)
{
 throw ("(errid:Watl000065)字段[课程Id]作为外键字段,长度应该为8(In 当前教学班)!(clsCurrEduClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.id_EduWay) == false && GetStrLen(pobjCurrEduClsEN.id_EduWay) !=  4)
{
 throw ("(errid:Watl000065)字段[教学方式流水号]作为外键字段,长度应该为4(In 当前教学班)!(clsCurrEduClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.id_ClassRoomType) == false && GetStrLen(pobjCurrEduClsEN.id_ClassRoomType) !=  4)
{
 throw ("(errid:Watl000065)字段[教室类型流水号]作为外键字段,长度应该为4(In 当前教学班)!(clsCurrEduClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.weekStatusID) == false && GetStrLen(pobjCurrEduClsEN.weekStatusID) !=  2)
{
 throw ("(errid:Watl000065)字段[周状态编号(单,双,全周)]作为外键字段,长度应该为2(In 当前教学班)!(clsCurrEduClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.id_UniZone) == false && GetStrLen(pobjCurrEduClsEN.id_UniZone) !=  4)
{
 throw ("(errid:Watl000065)字段[校区流水号]作为外键字段,长度应该为4(In 当前教学班)!(clsCurrEduClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsEN.id_GradeBase) == false && GetStrLen(pobjCurrEduClsEN.id_GradeBase) !=  4)
{
 throw ("(errid:Watl000065)字段[年级流水号]作为外键字段,长度应该为4(In 当前教学班)!(clsCurrEduClsBL:CheckPropertyNew)");
}

 pobjCurrEduClsEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function CurrEduCls_GetJSONStrByObj (pobjCurrEduClsEN: clsCurrEduClsEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjCurrEduClsEN.sf_UpdFldSetStr = pobjCurrEduClsEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjCurrEduClsEN);
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
export function CurrEduCls_GetObjLstByJSONStr (strJSON: string): Array<clsCurrEduClsEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrCurrEduClsObjLst = new Array<clsCurrEduClsEN>();
if (strJSON === "")
{
return arrCurrEduClsObjLst;
}
try
{
arrCurrEduClsObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrCurrEduClsObjLst;
}
return arrCurrEduClsObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrCurrEduClsObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function CurrEduCls_GetObjLstByJSONObjLst (arrCurrEduClsObjLstS: Array<clsCurrEduClsEN>): Array<clsCurrEduClsEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrCurrEduClsObjLst = new Array<clsCurrEduClsEN>();
for (const objInFor of arrCurrEduClsObjLstS) {
const obj1 = CurrEduCls_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrCurrEduClsObjLst.push(obj1);
}
return arrCurrEduClsObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function CurrEduCls_GetObjByJSONStr (strJSON: string): clsCurrEduClsEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjCurrEduClsEN = new clsCurrEduClsEN();
if (strJSON === "")
{
return pobjCurrEduClsEN;
}
try
{
pobjCurrEduClsEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjCurrEduClsEN;
}
return pobjCurrEduClsEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function CurrEduCls_GetCombineCondition(objCurrEduCls_Cond: clsCurrEduClsEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objCurrEduCls_Cond.dicFldComparisonOp, clsCurrEduClsEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objCurrEduCls_Cond.dicFldComparisonOp[clsCurrEduClsEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsCurrEduClsEN.con_id_CurrEduCls, objCurrEduCls_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (Object.prototype.hasOwnProperty.call(objCurrEduCls_Cond.dicFldComparisonOp, clsCurrEduClsEN.con_CurrEduClsId) == true)
{
const strComparisonOp_CurrEduClsId:string = objCurrEduCls_Cond.dicFldComparisonOp[clsCurrEduClsEN.con_CurrEduClsId];
strWhereCond += Format(" And {0} {2} '{1}'", clsCurrEduClsEN.con_CurrEduClsId, objCurrEduCls_Cond.currEduClsId, strComparisonOp_CurrEduClsId);
}
if (Object.prototype.hasOwnProperty.call(objCurrEduCls_Cond.dicFldComparisonOp, clsCurrEduClsEN.con_EduClsName) == true)
{
const strComparisonOp_EduClsName:string = objCurrEduCls_Cond.dicFldComparisonOp[clsCurrEduClsEN.con_EduClsName];
strWhereCond += Format(" And {0} {2} '{1}'", clsCurrEduClsEN.con_EduClsName, objCurrEduCls_Cond.eduClsName, strComparisonOp_EduClsName);
}
if (Object.prototype.hasOwnProperty.call(objCurrEduCls_Cond.dicFldComparisonOp, clsCurrEduClsEN.con_EduClsTypeId) == true)
{
const strComparisonOp_EduClsTypeId:string = objCurrEduCls_Cond.dicFldComparisonOp[clsCurrEduClsEN.con_EduClsTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsCurrEduClsEN.con_EduClsTypeId, objCurrEduCls_Cond.eduClsTypeId, strComparisonOp_EduClsTypeId);
}
if (Object.prototype.hasOwnProperty.call(objCurrEduCls_Cond.dicFldComparisonOp, clsCurrEduClsEN.con_CourseId) == true)
{
const strComparisonOp_CourseId:string = objCurrEduCls_Cond.dicFldComparisonOp[clsCurrEduClsEN.con_CourseId];
strWhereCond += Format(" And {0} {2} '{1}'", clsCurrEduClsEN.con_CourseId, objCurrEduCls_Cond.courseId, strComparisonOp_CourseId);
}
if (Object.prototype.hasOwnProperty.call(objCurrEduCls_Cond.dicFldComparisonOp, clsCurrEduClsEN.con_TeachingSolutionId) == true)
{
const strComparisonOp_TeachingSolutionId:string = objCurrEduCls_Cond.dicFldComparisonOp[clsCurrEduClsEN.con_TeachingSolutionId];
strWhereCond += Format(" And {0} {2} '{1}'", clsCurrEduClsEN.con_TeachingSolutionId, objCurrEduCls_Cond.teachingSolutionId, strComparisonOp_TeachingSolutionId);
}
if (Object.prototype.hasOwnProperty.call(objCurrEduCls_Cond.dicFldComparisonOp, clsCurrEduClsEN.con_id_XzCollege) == true)
{
const strComparisonOp_id_XzCollege:string = objCurrEduCls_Cond.dicFldComparisonOp[clsCurrEduClsEN.con_id_XzCollege];
strWhereCond += Format(" And {0} {2} '{1}'", clsCurrEduClsEN.con_id_XzCollege, objCurrEduCls_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (Object.prototype.hasOwnProperty.call(objCurrEduCls_Cond.dicFldComparisonOp, clsCurrEduClsEN.con_id_XzMajor) == true)
{
const strComparisonOp_id_XzMajor:string = objCurrEduCls_Cond.dicFldComparisonOp[clsCurrEduClsEN.con_id_XzMajor];
strWhereCond += Format(" And {0} {2} '{1}'", clsCurrEduClsEN.con_id_XzMajor, objCurrEduCls_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (Object.prototype.hasOwnProperty.call(objCurrEduCls_Cond.dicFldComparisonOp, clsCurrEduClsEN.con_id_EduWay) == true)
{
const strComparisonOp_id_EduWay:string = objCurrEduCls_Cond.dicFldComparisonOp[clsCurrEduClsEN.con_id_EduWay];
strWhereCond += Format(" And {0} {2} '{1}'", clsCurrEduClsEN.con_id_EduWay, objCurrEduCls_Cond.id_EduWay, strComparisonOp_id_EduWay);
}
if (Object.prototype.hasOwnProperty.call(objCurrEduCls_Cond.dicFldComparisonOp, clsCurrEduClsEN.con_id_ClassRoomType) == true)
{
const strComparisonOp_id_ClassRoomType:string = objCurrEduCls_Cond.dicFldComparisonOp[clsCurrEduClsEN.con_id_ClassRoomType];
strWhereCond += Format(" And {0} {2} '{1}'", clsCurrEduClsEN.con_id_ClassRoomType, objCurrEduCls_Cond.id_ClassRoomType, strComparisonOp_id_ClassRoomType);
}
if (Object.prototype.hasOwnProperty.call(objCurrEduCls_Cond.dicFldComparisonOp, clsCurrEduClsEN.con_TotalLessonQty) == true)
{
const strComparisonOp_TotalLessonQty:string = objCurrEduCls_Cond.dicFldComparisonOp[clsCurrEduClsEN.con_TotalLessonQty];
strWhereCond += Format(" And {0} {2} {1}", clsCurrEduClsEN.con_TotalLessonQty, objCurrEduCls_Cond.totalLessonQty, strComparisonOp_TotalLessonQty);
}
if (Object.prototype.hasOwnProperty.call(objCurrEduCls_Cond.dicFldComparisonOp, clsCurrEduClsEN.con_MaxStuQty) == true)
{
const strComparisonOp_MaxStuQty:string = objCurrEduCls_Cond.dicFldComparisonOp[clsCurrEduClsEN.con_MaxStuQty];
strWhereCond += Format(" And {0} {2} {1}", clsCurrEduClsEN.con_MaxStuQty, objCurrEduCls_Cond.maxStuQty, strComparisonOp_MaxStuQty);
}
if (Object.prototype.hasOwnProperty.call(objCurrEduCls_Cond.dicFldComparisonOp, clsCurrEduClsEN.con_WeekQty) == true)
{
const strComparisonOp_WeekQty:string = objCurrEduCls_Cond.dicFldComparisonOp[clsCurrEduClsEN.con_WeekQty];
strWhereCond += Format(" And {0} {2} {1}", clsCurrEduClsEN.con_WeekQty, objCurrEduCls_Cond.weekQty, strComparisonOp_WeekQty);
}
//数据类型number(smallint)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objCurrEduCls_Cond.dicFldComparisonOp, clsCurrEduClsEN.con_WeekStatusID) == true)
{
const strComparisonOp_WeekStatusID:string = objCurrEduCls_Cond.dicFldComparisonOp[clsCurrEduClsEN.con_WeekStatusID];
strWhereCond += Format(" And {0} {2} '{1}'", clsCurrEduClsEN.con_WeekStatusID, objCurrEduCls_Cond.weekStatusID, strComparisonOp_WeekStatusID);
}
if (Object.prototype.hasOwnProperty.call(objCurrEduCls_Cond.dicFldComparisonOp, clsCurrEduClsEN.con_CustomerWeek) == true)
{
const strComparisonOp_CustomerWeek:string = objCurrEduCls_Cond.dicFldComparisonOp[clsCurrEduClsEN.con_CustomerWeek];
strWhereCond += Format(" And {0} {2} '{1}'", clsCurrEduClsEN.con_CustomerWeek, objCurrEduCls_Cond.customerWeek, strComparisonOp_CustomerWeek);
}
//数据类型number(smallint)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objCurrEduCls_Cond.dicFldComparisonOp, clsCurrEduClsEN.con_Mark) == true)
{
const strComparisonOp_Mark:string = objCurrEduCls_Cond.dicFldComparisonOp[clsCurrEduClsEN.con_Mark];
strWhereCond += Format(" And {0} {2} {1}", clsCurrEduClsEN.con_Mark, objCurrEduCls_Cond.mark, strComparisonOp_Mark);
}
if (Object.prototype.hasOwnProperty.call(objCurrEduCls_Cond.dicFldComparisonOp, clsCurrEduClsEN.con_id_UniZone) == true)
{
const strComparisonOp_id_UniZone:string = objCurrEduCls_Cond.dicFldComparisonOp[clsCurrEduClsEN.con_id_UniZone];
strWhereCond += Format(" And {0} {2} '{1}'", clsCurrEduClsEN.con_id_UniZone, objCurrEduCls_Cond.id_UniZone, strComparisonOp_id_UniZone);
}
if (Object.prototype.hasOwnProperty.call(objCurrEduCls_Cond.dicFldComparisonOp, clsCurrEduClsEN.con_id_GradeBase) == true)
{
const strComparisonOp_id_GradeBase:string = objCurrEduCls_Cond.dicFldComparisonOp[clsCurrEduClsEN.con_id_GradeBase];
strWhereCond += Format(" And {0} {2} '{1}'", clsCurrEduClsEN.con_id_GradeBase, objCurrEduCls_Cond.id_GradeBase, strComparisonOp_id_GradeBase);
}
if (Object.prototype.hasOwnProperty.call(objCurrEduCls_Cond.dicFldComparisonOp, clsCurrEduClsEN.con_IsEffective) == true)
{
if (objCurrEduCls_Cond.isEffective == true)
{
strWhereCond += Format(" And {0} = '1'", clsCurrEduClsEN.con_IsEffective);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsCurrEduClsEN.con_IsEffective);
}
}
if (Object.prototype.hasOwnProperty.call(objCurrEduCls_Cond.dicFldComparisonOp, clsCurrEduClsEN.con_IsForPaperReading) == true)
{
if (objCurrEduCls_Cond.isForPaperReading == true)
{
strWhereCond += Format(" And {0} = '1'", clsCurrEduClsEN.con_IsForPaperReading);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsCurrEduClsEN.con_IsForPaperReading);
}
}
if (Object.prototype.hasOwnProperty.call(objCurrEduCls_Cond.dicFldComparisonOp, clsCurrEduClsEN.con_SchoolYear) == true)
{
const strComparisonOp_SchoolYear:string = objCurrEduCls_Cond.dicFldComparisonOp[clsCurrEduClsEN.con_SchoolYear];
strWhereCond += Format(" And {0} {2} '{1}'", clsCurrEduClsEN.con_SchoolYear, objCurrEduCls_Cond.schoolYear, strComparisonOp_SchoolYear);
}
if (Object.prototype.hasOwnProperty.call(objCurrEduCls_Cond.dicFldComparisonOp, clsCurrEduClsEN.con_SchoolTerm) == true)
{
const strComparisonOp_SchoolTerm:string = objCurrEduCls_Cond.dicFldComparisonOp[clsCurrEduClsEN.con_SchoolTerm];
strWhereCond += Format(" And {0} {2} '{1}'", clsCurrEduClsEN.con_SchoolTerm, objCurrEduCls_Cond.schoolTerm, strComparisonOp_SchoolTerm);
}
if (Object.prototype.hasOwnProperty.call(objCurrEduCls_Cond.dicFldComparisonOp, clsCurrEduClsEN.con_id_CourseType) == true)
{
const strComparisonOp_id_CourseType:string = objCurrEduCls_Cond.dicFldComparisonOp[clsCurrEduClsEN.con_id_CourseType];
strWhereCond += Format(" And {0} {2} '{1}'", clsCurrEduClsEN.con_id_CourseType, objCurrEduCls_Cond.id_CourseType, strComparisonOp_id_CourseType);
}
if (Object.prototype.hasOwnProperty.call(objCurrEduCls_Cond.dicFldComparisonOp, clsCurrEduClsEN.con_IsDegree) == true)
{
if (objCurrEduCls_Cond.isDegree == true)
{
strWhereCond += Format(" And {0} = '1'", clsCurrEduClsEN.con_IsDegree);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsCurrEduClsEN.con_IsDegree);
}
}
if (Object.prototype.hasOwnProperty.call(objCurrEduCls_Cond.dicFldComparisonOp, clsCurrEduClsEN.con_id_ScoreType) == true)
{
const strComparisonOp_id_ScoreType:string = objCurrEduCls_Cond.dicFldComparisonOp[clsCurrEduClsEN.con_id_ScoreType];
strWhereCond += Format(" And {0} {2} '{1}'", clsCurrEduClsEN.con_id_ScoreType, objCurrEduCls_Cond.id_ScoreType, strComparisonOp_id_ScoreType);
}
if (Object.prototype.hasOwnProperty.call(objCurrEduCls_Cond.dicFldComparisonOp, clsCurrEduClsEN.con_GetScoreWayId) == true)
{
const strComparisonOp_GetScoreWayId:string = objCurrEduCls_Cond.dicFldComparisonOp[clsCurrEduClsEN.con_GetScoreWayId];
strWhereCond += Format(" And {0} {2} '{1}'", clsCurrEduClsEN.con_GetScoreWayId, objCurrEduCls_Cond.getScoreWayId, strComparisonOp_GetScoreWayId);
}
if (Object.prototype.hasOwnProperty.call(objCurrEduCls_Cond.dicFldComparisonOp, clsCurrEduClsEN.con_IsProportionalCtrl) == true)
{
if (objCurrEduCls_Cond.isProportionalCtrl == true)
{
strWhereCond += Format(" And {0} = '1'", clsCurrEduClsEN.con_IsProportionalCtrl);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsCurrEduClsEN.con_IsProportionalCtrl);
}
}
if (Object.prototype.hasOwnProperty.call(objCurrEduCls_Cond.dicFldComparisonOp, clsCurrEduClsEN.con_id_ExamType) == true)
{
const strComparisonOp_id_ExamType:string = objCurrEduCls_Cond.dicFldComparisonOp[clsCurrEduClsEN.con_id_ExamType];
strWhereCond += Format(" And {0} {2} '{1}'", clsCurrEduClsEN.con_id_ExamType, objCurrEduCls_Cond.id_ExamType, strComparisonOp_id_ExamType);
}
if (Object.prototype.hasOwnProperty.call(objCurrEduCls_Cond.dicFldComparisonOp, clsCurrEduClsEN.con_ExamTime) == true)
{
const strComparisonOp_ExamTime:string = objCurrEduCls_Cond.dicFldComparisonOp[clsCurrEduClsEN.con_ExamTime];
strWhereCond += Format(" And {0} {2} '{1}'", clsCurrEduClsEN.con_ExamTime, objCurrEduCls_Cond.examTime, strComparisonOp_ExamTime);
}
//数据类型number(smallint)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objCurrEduCls_Cond.dicFldComparisonOp, clsCurrEduClsEN.con_ModifyDate) == true)
{
const strComparisonOp_ModifyDate:string = objCurrEduCls_Cond.dicFldComparisonOp[clsCurrEduClsEN.con_ModifyDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsCurrEduClsEN.con_ModifyDate, objCurrEduCls_Cond.modifyDate, strComparisonOp_ModifyDate);
}
if (Object.prototype.hasOwnProperty.call(objCurrEduCls_Cond.dicFldComparisonOp, clsCurrEduClsEN.con_ModifyUserID) == true)
{
const strComparisonOp_ModifyUserID:string = objCurrEduCls_Cond.dicFldComparisonOp[clsCurrEduClsEN.con_ModifyUserID];
strWhereCond += Format(" And {0} {2} '{1}'", clsCurrEduClsEN.con_ModifyUserID, objCurrEduCls_Cond.modifyUserID, strComparisonOp_ModifyUserID);
}
if (Object.prototype.hasOwnProperty.call(objCurrEduCls_Cond.dicFldComparisonOp, clsCurrEduClsEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objCurrEduCls_Cond.dicFldComparisonOp[clsCurrEduClsEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsCurrEduClsEN.con_Memo, objCurrEduCls_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--CurrEduCls(当前教学班),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param strEduClsName: 教学班名(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function CurrEduCls_GetUniCondStr_EduClsName(objCurrEduClsEN: clsCurrEduClsEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and EduClsName = '{0}'", objCurrEduClsEN.eduClsName);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--CurrEduCls(当前教学班),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param strEduClsName: 教学班名(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function CurrEduCls_GetUniCondStr4Update_EduClsName(objCurrEduClsEN: clsCurrEduClsEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and id_CurrEduCls <> '{0}'", objCurrEduClsEN.id_CurrEduCls);
 strWhereCond +=  Format(" and EduClsName = '{0}'", objCurrEduClsEN.eduClsName);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objCurrEduClsENS:源对象
 * @param objCurrEduClsENT:目标对象
*/
export function CurrEduCls_CopyObjTo(objCurrEduClsENS: clsCurrEduClsEN , objCurrEduClsENT: clsCurrEduClsEN ): void 
{
objCurrEduClsENT.id_CurrEduCls = objCurrEduClsENS.id_CurrEduCls; //教学班流水号
objCurrEduClsENT.currEduClsId = objCurrEduClsENS.currEduClsId; //教学班Id
objCurrEduClsENT.eduClsName = objCurrEduClsENS.eduClsName; //教学班名
objCurrEduClsENT.eduClsTypeId = objCurrEduClsENS.eduClsTypeId; //教学班类型Id
objCurrEduClsENT.courseId = objCurrEduClsENS.courseId; //课程Id
objCurrEduClsENT.teachingSolutionId = objCurrEduClsENS.teachingSolutionId; //教学方案Id
objCurrEduClsENT.id_XzCollege = objCurrEduClsENS.id_XzCollege; //学院流水号
objCurrEduClsENT.id_XzMajor = objCurrEduClsENS.id_XzMajor; //专业流水号
objCurrEduClsENT.id_EduWay = objCurrEduClsENS.id_EduWay; //教学方式流水号
objCurrEduClsENT.id_ClassRoomType = objCurrEduClsENS.id_ClassRoomType; //教室类型流水号
objCurrEduClsENT.totalLessonQty = objCurrEduClsENS.totalLessonQty; //总课时数
objCurrEduClsENT.maxStuQty = objCurrEduClsENS.maxStuQty; //最大学生数
objCurrEduClsENT.weekQty = objCurrEduClsENS.weekQty; //总周数
objCurrEduClsENT.scheUnitPW = objCurrEduClsENS.scheUnitPW; //周排课次数
objCurrEduClsENT.weekStatusID = objCurrEduClsENS.weekStatusID; //周状态编号(单,双,全周)
objCurrEduClsENT.customerWeek = objCurrEduClsENS.customerWeek; //自定义上课周
objCurrEduClsENT.lessonQtyPerWeek = objCurrEduClsENS.lessonQtyPerWeek; //周课时数
objCurrEduClsENT.mark = objCurrEduClsENS.mark; //获得学分
objCurrEduClsENT.id_UniZone = objCurrEduClsENS.id_UniZone; //校区流水号
objCurrEduClsENT.id_GradeBase = objCurrEduClsENS.id_GradeBase; //年级流水号
objCurrEduClsENT.isEffective = objCurrEduClsENS.isEffective; //是否有效
objCurrEduClsENT.isForPaperReading = objCurrEduClsENS.isForPaperReading; //是否参与论文阅读
objCurrEduClsENT.schoolYear = objCurrEduClsENS.schoolYear; //学年
objCurrEduClsENT.schoolTerm = objCurrEduClsENS.schoolTerm; //学期
objCurrEduClsENT.id_CourseType = objCurrEduClsENS.id_CourseType; //课程类型流水号
objCurrEduClsENT.isDegree = objCurrEduClsENS.isDegree; //是否学位课
objCurrEduClsENT.id_ScoreType = objCurrEduClsENS.id_ScoreType; //成绩类型流水号
objCurrEduClsENT.getScoreWayId = objCurrEduClsENS.getScoreWayId; //获得成绩方式Id
objCurrEduClsENT.isProportionalCtrl = objCurrEduClsENS.isProportionalCtrl; //是否比例控制
objCurrEduClsENT.id_ExamType = objCurrEduClsENS.id_ExamType; //考试方式流水号
objCurrEduClsENT.examTime = objCurrEduClsENS.examTime; //考试时间
objCurrEduClsENT.beginWeek = objCurrEduClsENS.beginWeek; //开始周
objCurrEduClsENT.modifyDate = objCurrEduClsENS.modifyDate; //修改日期
objCurrEduClsENT.modifyUserID = objCurrEduClsENS.modifyUserID; //修改人
objCurrEduClsENT.memo = objCurrEduClsENS.memo; //备注
objCurrEduClsENT.sf_UpdFldSetStr = objCurrEduClsENS.updFldString; //sf_UpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objCurrEduClsENS:源对象
 * @param objCurrEduClsENT:目标对象
*/
export function CurrEduCls_GetObjFromJsonObj(objCurrEduClsENS: clsCurrEduClsEN): clsCurrEduClsEN 
{
 const objCurrEduClsENT: clsCurrEduClsEN = new clsCurrEduClsEN();
ObjectAssign(objCurrEduClsENT, objCurrEduClsENS);
 return objCurrEduClsENT;
}