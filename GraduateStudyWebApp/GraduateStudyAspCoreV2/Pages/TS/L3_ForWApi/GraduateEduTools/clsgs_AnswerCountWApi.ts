
 /**
 * 类名:clsgs_AnswerCountWApi
 * 表名:gs_AnswerCount(01120767)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:47:39
 * 生成者:pyf
 * 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:研培设置(GraduateEduTools)
 * 框架-层名:WA_访问层(TS)(WA_Access)
 * 编程语言:TypeScript
 * 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
   *      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 **/

/**
 * 问题讨论回答统计(gs_AnswerCount)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2023年03月13日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { enumComparisonOp } from "../../PubFun/enumComparisonOp.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { clsgs_AnswerCountEN } from "../../L0_Entity/GraduateEduTools/clsgs_AnswerCountEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { tzDataType } from "../../PubFun/clsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const gs_AnswerCount_Controller = "gs_AnswerCountApi";
 export const gs_AnswerCount_ConstructorName = "gs_AnswerCount";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strAnswerCountId:关键字
 * @returns 对象
 **/
export async function gs_AnswerCount_GetObjByAnswerCountIdAsync(strAnswerCountId: string): Promise<clsgs_AnswerCountEN|null>  
{
const strThisFuncName = "GetObjByAnswerCountIdAsync";

if (IsNullOrEmpty(strAnswerCountId) == true)
{
  const strMsg = Format("参数:[strAnswerCountId]不能为空！(In clsgs_AnswerCountWApi.GetObjByAnswerCountIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strAnswerCountId.length != 10)
{
const strMsg = Format("缓存分类变量:[strAnswerCountId]的长度:[{0}]不正确！(clsgs_AnswerCountWApi.GetObjByAnswerCountIdAsync)", strAnswerCountId.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByAnswerCountId";
const strUrl = GetWebApiUrl(gs_AnswerCount_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strAnswerCountId": strAnswerCountId,
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
const objgs_AnswerCount = gs_AnswerCount_GetObjFromJsonObj(returnObj);
return objgs_AnswerCount;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_AnswerCount_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_AnswerCount_ConstructorName, strThisFuncName);
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
 * @param strAnswerCountId:所给的关键字
 * @returns 对象
*/
export async function gs_AnswerCount_GetObjByAnswerCountId_Cache(strAnswerCountId:string,strid_CurrEduCls:string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByAnswerCountId_Cache";

if (IsNullOrEmpty(strAnswerCountId) == true)
{
  const strMsg = Format("参数:[strAnswerCountId]不能为空！(In clsgs_AnswerCountWApi.GetObjByAnswerCountId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strAnswerCountId.length != 10)
{
const strMsg = Format("缓存分类变量:[strAnswerCountId]的长度:[{0}]不正确！(clsgs_AnswerCountWApi.GetObjByAnswerCountId_Cache)", strAnswerCountId.length);
console.error(strMsg);
throw (strMsg);
}
const arrgs_AnswerCountObjLst_Cache = await gs_AnswerCount_GetObjLst_Cache(strid_CurrEduCls);
try
{
const arrgs_AnswerCount_Sel: Array <clsgs_AnswerCountEN> = arrgs_AnswerCountObjLst_Cache.filter(x => 
 x.answerCountId == strAnswerCountId );
let objgs_AnswerCount: clsgs_AnswerCountEN;
if (arrgs_AnswerCount_Sel.length > 0)
{
objgs_AnswerCount = arrgs_AnswerCount_Sel[0];
return objgs_AnswerCount;
}
else
{
if (bolTryAsyncOnce == true)
{
const objgs_AnswerCount_Const = await gs_AnswerCount_GetObjByAnswerCountIdAsync(strAnswerCountId);
if (objgs_AnswerCount_Const != null)
{
gs_AnswerCount_ReFreshThisCache(strid_CurrEduCls);
return objgs_AnswerCount_Const;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strAnswerCountId, gs_AnswerCount_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param strAnswerCountId:所给的关键字
 * @returns 对象
*/
export async function gs_AnswerCount_GetObjByAnswerCountId_localStorage(strAnswerCountId: string) {
const strThisFuncName = "GetObjByAnswerCountId_localStorage";

if (IsNullOrEmpty(strAnswerCountId) == true)
{
  const strMsg = Format("参数:[strAnswerCountId]不能为空！(In clsgs_AnswerCountWApi.GetObjByAnswerCountId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
if (strAnswerCountId.length != 10)
{
const strMsg = Format("缓存分类变量:[strAnswerCountId]的长度:[{0}]不正确！(clsgs_AnswerCountWApi.GetObjByAnswerCountId_localStorage)", strAnswerCountId.length);
console.error(strMsg);
throw (strMsg);
}
const strKey = Format("{0}_{1}", clsgs_AnswerCountEN._CurrTabName, strAnswerCountId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objgs_AnswerCount_Cache: clsgs_AnswerCountEN = JSON.parse(strTempObj);
return objgs_AnswerCount_Cache;
}
try
{
const objgs_AnswerCount = await gs_AnswerCount_GetObjByAnswerCountIdAsync(strAnswerCountId);
if (objgs_AnswerCount != null)
{
localStorage.setItem(strKey, JSON.stringify(objgs_AnswerCount));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objgs_AnswerCount;
}
return objgs_AnswerCount;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strAnswerCountId, gs_AnswerCount_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objgs_AnswerCount:所给的对象
 * @returns 对象
*/
export async function gs_AnswerCount_UpdateObjInLst_Cache(objgs_AnswerCount: clsgs_AnswerCountEN,strid_CurrEduCls: string) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrgs_AnswerCountObjLst_Cache = await gs_AnswerCount_GetObjLst_Cache(strid_CurrEduCls);
const obj = arrgs_AnswerCountObjLst_Cache.find(x => x.answerCountId == objgs_AnswerCount.answerCountId);
if (obj != null)
{
objgs_AnswerCount.answerCountId = obj.answerCountId;
ObjectAssign( obj, objgs_AnswerCount);
}
else
{
arrgs_AnswerCountObjLst_Cache.push(objgs_AnswerCount);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, gs_AnswerCount_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
}
/*该表没有名称字段，不能生成此函数！*/

/**
 * 映射函数。根据表映射把输入字段值，映射成输出字段值
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
 * @param strInFldName:输入字段名
 * @param strOutFldName:输出字段名
 * @param strInValue:输入字段值
 @param strid_CurrEduCls:缓存的分类字段
 * @returns 返回一个输出字段值
*/
export async function gs_AnswerCount_func(strInFldName:string , strOutFldName:string , strInValue:string 
, strid_CurrEduCls_C: string)
{
//const strThisFuncName = "func";

if (IsNullOrEmpty(strid_CurrEduCls_C) == true)
{
  const strMsg = Format("参数:[strid_CurrEduCls_C]不能为空！(In clsgs_AnswerCountWApi.func)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_CurrEduCls_C.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsgs_AnswerCountWApi.func)", strid_CurrEduCls_C.length);
console.error(strMsg);
throw (strMsg);
}

if (strInFldName != clsgs_AnswerCountEN.con_AnswerCountId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsgs_AnswerCountEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strOutFldName, clsgs_AnswerCountEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strAnswerCountId = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objgs_AnswerCount = await gs_AnswerCount_GetObjByAnswerCountId_Cache(strAnswerCountId , strid_CurrEduCls_C);
if (objgs_AnswerCount == null) return "";
if (objgs_AnswerCount.GetFldValue(strOutFldName) == null) return "";
return objgs_AnswerCount.GetFldValue(strOutFldName).toString();
}

/**
 * 排序函数。根据关键字字段的值进行比较
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
 * @param a:比较的第1个对象
 * @param  b:比较的第1个对象
 * @returns 返回两个对象比较的结果
*/
export function gs_AnswerCount_SortFun_Defa(a:clsgs_AnswerCountEN , b:clsgs_AnswerCountEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.answerCountId.localeCompare(b.answerCountId);
}
/**
 * 排序函数。根据表对象中随机两个字段的值进行比较
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
 * @param  a:比较的第1个对象
 * @param  b:比较的第1个对象
 * @returns 返回两个对象比较的结果
*/
export function gs_AnswerCount_SortFun_Defa_2Fld(a:clsgs_AnswerCountEN , b:clsgs_AnswerCountEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.memo == b.memo) return a.dataUser.localeCompare(b.dataUser);
else return a.memo.localeCompare(b.memo);
}

/**
 * 排序函数。根据关键字字段的值进行比较
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
 * @param a:比较的第1个对象
 * @param  b:比较的第1个对象
 * @returns 返回两个对象比较的结果
*/
export function gs_AnswerCount_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsgs_AnswerCountEN.con_Memo:
return (a: clsgs_AnswerCountEN, b: clsgs_AnswerCountEN) => {
if (a.memo == null) return -1;
if (b.memo == null) return 1;
return a.memo.localeCompare(b.memo);
}
case clsgs_AnswerCountEN.con_AnswerCountId:
return (a: clsgs_AnswerCountEN, b: clsgs_AnswerCountEN) => {
return a.answerCountId.localeCompare(b.answerCountId);
}
case clsgs_AnswerCountEN.con_DataUser:
return (a: clsgs_AnswerCountEN, b: clsgs_AnswerCountEN) => {
if (a.dataUser == null) return -1;
if (b.dataUser == null) return 1;
return a.dataUser.localeCompare(b.dataUser);
}
case clsgs_AnswerCountEN.con_DataAddDate:
return (a: clsgs_AnswerCountEN, b: clsgs_AnswerCountEN) => {
if (a.dataAddDate == null) return -1;
if (b.dataAddDate == null) return 1;
return a.dataAddDate.localeCompare(b.dataAddDate);
}
case clsgs_AnswerCountEN.con_Month:
return (a: clsgs_AnswerCountEN, b: clsgs_AnswerCountEN) => {
return a.month-b.month;
}
case clsgs_AnswerCountEN.con_Week:
return (a: clsgs_AnswerCountEN, b: clsgs_AnswerCountEN) => {
return a.week-b.week;
}
case clsgs_AnswerCountEN.con_WeekTimeRange:
return (a: clsgs_AnswerCountEN, b: clsgs_AnswerCountEN) => {
if (a.weekTimeRange == null) return -1;
if (b.weekTimeRange == null) return 1;
return a.weekTimeRange.localeCompare(b.weekTimeRange);
}
case clsgs_AnswerCountEN.con_IsRecommend:
return (a: clsgs_AnswerCountEN, b: clsgs_AnswerCountEN) => {
if (a.isRecommend == true) return 1;
else return -1
}
case clsgs_AnswerCountEN.con_AnswerId:
return (a: clsgs_AnswerCountEN, b: clsgs_AnswerCountEN) => {
if (a.answerId == null) return -1;
if (b.answerId == null) return 1;
return a.answerId.localeCompare(b.answerId);
}
case clsgs_AnswerCountEN.con_AnswerTypeId:
return (a: clsgs_AnswerCountEN, b: clsgs_AnswerCountEN) => {
if (a.answerTypeId == null) return -1;
if (b.answerTypeId == null) return 1;
return a.answerTypeId.localeCompare(b.answerTypeId);
}
case clsgs_AnswerCountEN.con_QuestionsId:
return (a: clsgs_AnswerCountEN, b: clsgs_AnswerCountEN) => {
if (a.questionsId == null) return -1;
if (b.questionsId == null) return 1;
return a.questionsId.localeCompare(b.questionsId);
}
case clsgs_AnswerCountEN.con_TopicId:
return (a: clsgs_AnswerCountEN, b: clsgs_AnswerCountEN) => {
if (a.topicId == null) return -1;
if (b.topicId == null) return 1;
return a.topicId.localeCompare(b.topicId);
}
case clsgs_AnswerCountEN.con_PaperId:
return (a: clsgs_AnswerCountEN, b: clsgs_AnswerCountEN) => {
if (a.paperId == null) return -1;
if (b.paperId == null) return 1;
return a.paperId.localeCompare(b.paperId);
}
case clsgs_AnswerCountEN.con_id_CurrEduCls:
return (a: clsgs_AnswerCountEN, b: clsgs_AnswerCountEN) => {
if (a.id_CurrEduCls == null) return -1;
if (b.id_CurrEduCls == null) return 1;
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
case clsgs_AnswerCountEN.con_AnswerContent:
return (a: clsgs_AnswerCountEN, b: clsgs_AnswerCountEN) => {
if (a.answerContent == null) return -1;
if (b.answerContent == null) return 1;
return a.answerContent.localeCompare(b.answerContent);
}
case clsgs_AnswerCountEN.con_Score:
return (a: clsgs_AnswerCountEN, b: clsgs_AnswerCountEN) => {
return a.score-b.score;
}
case clsgs_AnswerCountEN.con_ScoreType:
return (a: clsgs_AnswerCountEN, b: clsgs_AnswerCountEN) => {
if (a.scoreType == null) return -1;
if (b.scoreType == null) return 1;
return a.scoreType.localeCompare(b.scoreType);
}
case clsgs_AnswerCountEN.con_UpdUser:
return (a: clsgs_AnswerCountEN, b: clsgs_AnswerCountEN) => {
if (a.updUser == null) return -1;
if (b.updUser == null) return 1;
return a.updUser.localeCompare(b.updUser);
}
case clsgs_AnswerCountEN.con_UpdDate:
return (a: clsgs_AnswerCountEN, b: clsgs_AnswerCountEN) => {
if (a.updDate == null) return -1;
if (b.updDate == null) return 1;
return a.updDate.localeCompare(b.updDate);
}
case clsgs_AnswerCountEN.con_UserName:
return (a: clsgs_AnswerCountEN, b: clsgs_AnswerCountEN) => {
if (a.userName == null) return -1;
if (b.userName == null) return 1;
return a.userName.localeCompare(b.userName);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_AnswerCount]中不存在！(in ${ gs_AnswerCount_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsgs_AnswerCountEN.con_Memo:
return (a: clsgs_AnswerCountEN, b: clsgs_AnswerCountEN) => {
if (b.memo == null) return -1;
if (a.memo == null) return 1;
return b.memo.localeCompare(a.memo);
}
case clsgs_AnswerCountEN.con_AnswerCountId:
return (a: clsgs_AnswerCountEN, b: clsgs_AnswerCountEN) => {
return b.answerCountId.localeCompare(a.answerCountId);
}
case clsgs_AnswerCountEN.con_DataUser:
return (a: clsgs_AnswerCountEN, b: clsgs_AnswerCountEN) => {
if (b.dataUser == null) return -1;
if (a.dataUser == null) return 1;
return b.dataUser.localeCompare(a.dataUser);
}
case clsgs_AnswerCountEN.con_DataAddDate:
return (a: clsgs_AnswerCountEN, b: clsgs_AnswerCountEN) => {
if (b.dataAddDate == null) return -1;
if (a.dataAddDate == null) return 1;
return b.dataAddDate.localeCompare(a.dataAddDate);
}
case clsgs_AnswerCountEN.con_Month:
return (a: clsgs_AnswerCountEN, b: clsgs_AnswerCountEN) => {
return b.month-a.month;
}
case clsgs_AnswerCountEN.con_Week:
return (a: clsgs_AnswerCountEN, b: clsgs_AnswerCountEN) => {
return b.week-a.week;
}
case clsgs_AnswerCountEN.con_WeekTimeRange:
return (a: clsgs_AnswerCountEN, b: clsgs_AnswerCountEN) => {
if (b.weekTimeRange == null) return -1;
if (a.weekTimeRange == null) return 1;
return b.weekTimeRange.localeCompare(a.weekTimeRange);
}
case clsgs_AnswerCountEN.con_IsRecommend:
return (a: clsgs_AnswerCountEN, b: clsgs_AnswerCountEN) => {
if (b.isRecommend == true) return 1;
else return -1
}
case clsgs_AnswerCountEN.con_AnswerId:
return (a: clsgs_AnswerCountEN, b: clsgs_AnswerCountEN) => {
if (b.answerId == null) return -1;
if (a.answerId == null) return 1;
return b.answerId.localeCompare(a.answerId);
}
case clsgs_AnswerCountEN.con_AnswerTypeId:
return (a: clsgs_AnswerCountEN, b: clsgs_AnswerCountEN) => {
if (b.answerTypeId == null) return -1;
if (a.answerTypeId == null) return 1;
return b.answerTypeId.localeCompare(a.answerTypeId);
}
case clsgs_AnswerCountEN.con_QuestionsId:
return (a: clsgs_AnswerCountEN, b: clsgs_AnswerCountEN) => {
if (b.questionsId == null) return -1;
if (a.questionsId == null) return 1;
return b.questionsId.localeCompare(a.questionsId);
}
case clsgs_AnswerCountEN.con_TopicId:
return (a: clsgs_AnswerCountEN, b: clsgs_AnswerCountEN) => {
if (b.topicId == null) return -1;
if (a.topicId == null) return 1;
return b.topicId.localeCompare(a.topicId);
}
case clsgs_AnswerCountEN.con_PaperId:
return (a: clsgs_AnswerCountEN, b: clsgs_AnswerCountEN) => {
if (b.paperId == null) return -1;
if (a.paperId == null) return 1;
return b.paperId.localeCompare(a.paperId);
}
case clsgs_AnswerCountEN.con_id_CurrEduCls:
return (a: clsgs_AnswerCountEN, b: clsgs_AnswerCountEN) => {
if (b.id_CurrEduCls == null) return -1;
if (a.id_CurrEduCls == null) return 1;
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
case clsgs_AnswerCountEN.con_AnswerContent:
return (a: clsgs_AnswerCountEN, b: clsgs_AnswerCountEN) => {
if (b.answerContent == null) return -1;
if (a.answerContent == null) return 1;
return b.answerContent.localeCompare(a.answerContent);
}
case clsgs_AnswerCountEN.con_Score:
return (a: clsgs_AnswerCountEN, b: clsgs_AnswerCountEN) => {
return b.score-a.score;
}
case clsgs_AnswerCountEN.con_ScoreType:
return (a: clsgs_AnswerCountEN, b: clsgs_AnswerCountEN) => {
if (b.scoreType == null) return -1;
if (a.scoreType == null) return 1;
return b.scoreType.localeCompare(a.scoreType);
}
case clsgs_AnswerCountEN.con_UpdUser:
return (a: clsgs_AnswerCountEN, b: clsgs_AnswerCountEN) => {
if (b.updUser == null) return -1;
if (a.updUser == null) return 1;
return b.updUser.localeCompare(a.updUser);
}
case clsgs_AnswerCountEN.con_UpdDate:
return (a: clsgs_AnswerCountEN, b: clsgs_AnswerCountEN) => {
if (b.updDate == null) return -1;
if (a.updDate == null) return 1;
return b.updDate.localeCompare(a.updDate);
}
case clsgs_AnswerCountEN.con_UserName:
return (a: clsgs_AnswerCountEN, b: clsgs_AnswerCountEN) => {
if (b.userName == null) return -1;
if (a.userName == null) return 1;
return b.userName.localeCompare(a.userName);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_AnswerCount]中不存在！(in ${ gs_AnswerCount_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
}

/**
 * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
 * @param strKey:比较的关键字段名称
 * @param value:给定值
 * @returns 返回对象的字段值是否等于给定值
*/
export async function gs_AnswerCount_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsgs_AnswerCountEN.con_Memo:
return (obj: clsgs_AnswerCountEN) => {
return obj.memo === value;
}
case clsgs_AnswerCountEN.con_AnswerCountId:
return (obj: clsgs_AnswerCountEN) => {
return obj.answerCountId === value;
}
case clsgs_AnswerCountEN.con_DataUser:
return (obj: clsgs_AnswerCountEN) => {
return obj.dataUser === value;
}
case clsgs_AnswerCountEN.con_DataAddDate:
return (obj: clsgs_AnswerCountEN) => {
return obj.dataAddDate === value;
}
case clsgs_AnswerCountEN.con_Month:
return (obj: clsgs_AnswerCountEN) => {
return obj.month === value;
}
case clsgs_AnswerCountEN.con_Week:
return (obj: clsgs_AnswerCountEN) => {
return obj.week === value;
}
case clsgs_AnswerCountEN.con_WeekTimeRange:
return (obj: clsgs_AnswerCountEN) => {
return obj.weekTimeRange === value;
}
case clsgs_AnswerCountEN.con_IsRecommend:
return (obj: clsgs_AnswerCountEN) => {
return obj.isRecommend === value;
}
case clsgs_AnswerCountEN.con_AnswerId:
return (obj: clsgs_AnswerCountEN) => {
return obj.answerId === value;
}
case clsgs_AnswerCountEN.con_AnswerTypeId:
return (obj: clsgs_AnswerCountEN) => {
return obj.answerTypeId === value;
}
case clsgs_AnswerCountEN.con_QuestionsId:
return (obj: clsgs_AnswerCountEN) => {
return obj.questionsId === value;
}
case clsgs_AnswerCountEN.con_TopicId:
return (obj: clsgs_AnswerCountEN) => {
return obj.topicId === value;
}
case clsgs_AnswerCountEN.con_PaperId:
return (obj: clsgs_AnswerCountEN) => {
return obj.paperId === value;
}
case clsgs_AnswerCountEN.con_id_CurrEduCls:
return (obj: clsgs_AnswerCountEN) => {
return obj.id_CurrEduCls === value;
}
case clsgs_AnswerCountEN.con_AnswerContent:
return (obj: clsgs_AnswerCountEN) => {
return obj.answerContent === value;
}
case clsgs_AnswerCountEN.con_Score:
return (obj: clsgs_AnswerCountEN) => {
return obj.score === value;
}
case clsgs_AnswerCountEN.con_ScoreType:
return (obj: clsgs_AnswerCountEN) => {
return obj.scoreType === value;
}
case clsgs_AnswerCountEN.con_UpdUser:
return (obj: clsgs_AnswerCountEN) => {
return obj.updUser === value;
}
case clsgs_AnswerCountEN.con_UpdDate:
return (obj: clsgs_AnswerCountEN) => {
return obj.updDate === value;
}
case clsgs_AnswerCountEN.con_UserName:
return (obj: clsgs_AnswerCountEN) => {
return obj.userName === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_AnswerCount]中不存在！(in ${ gs_AnswerCount_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
}

/**
 * 映射函数。根据表映射把输入字段值，映射成输出字段值
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_funcKey)
 * @param strInFldName:输入字段名
 * @param strInValue:输入字段值
 * @param strComparisonOp:比较操作符
 @param strid_CurrEduCls:缓存的分类字段
 * @returns 返回一个关键字值列表
*/
export async function gs_AnswerCount_funcKey(strInFldName:string, strInValue: any, strComparisonOp:string, strid_CurrEduCls_C: string): Promise<Array<string>>
{
//const strThisFuncName = "funcKey";

if (IsNullOrEmpty(strid_CurrEduCls_C) == true)
{
  const strMsg = Format("参数:[strid_CurrEduCls_C]不能为空！(In clsgs_AnswerCountWApi.funcKey)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_CurrEduCls_C.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsgs_AnswerCountWApi.funcKey)", strid_CurrEduCls_C.length);
console.error(strMsg);
throw (strMsg);
}

if (strInFldName == clsgs_AnswerCountEN.con_AnswerCountId)
{
const strMsg = Format("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (IsNullOrEmpty(strInValue) == true)
{
return [];
}
const arrgs_AnswerCount = await gs_AnswerCount_GetObjLst_Cache(strid_CurrEduCls_C);
if (arrgs_AnswerCount == null) return [];
let arrgs_AnswerCount_Sel = arrgs_AnswerCount;
const strType = typeof(strInValue);
switch (strType)
{
case "string":
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01: // " = "
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
break;
case enumComparisonOp.Like_03:
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
break;
case enumComparisonOp.In_04:
const arrValues = strInValue.split(',');
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
break;
}
break;
case "boolean":
if (strInValue == null) return [];
if (strComparisonOp == enumComparisonOp.Equal_01)
{
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
}
break;
case "number":
if (Number(strInValue) == 0) return [];
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01:
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
break;
case enumComparisonOp.NotEqual_02:
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
break;
case enumComparisonOp.NotLessThan_05://" >= ":
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
break;
case enumComparisonOp.NotGreaterThan_06://" <= ":
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
case enumComparisonOp.GreaterThan_07://" > ":
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
break;
case enumComparisonOp.LessThan_08://" < ":
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
}
break;
}
if (arrgs_AnswerCount_Sel.length == 0) return [];
return arrgs_AnswerCount_Sel.map(x=>x.answerCountId);
}

 /**
 * 根据条件获取满足条件的第一条记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
 * @param strWhereCond:条件
 * @returns 返回的第一条记录的关键字值
 **/
export async function gs_AnswerCount_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(gs_AnswerCount_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_AnswerCount_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_AnswerCount_ConstructorName, strThisFuncName);
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
export async function gs_AnswerCount_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(gs_AnswerCount_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_AnswerCount_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_AnswerCount_ConstructorName, strThisFuncName);
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
export async function gs_AnswerCount_GetFirstObjAsync(strWhereCond: string): Promise<clsgs_AnswerCountEN|null>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(gs_AnswerCount_Controller, strAction);
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
const objgs_AnswerCount = gs_AnswerCount_GetObjFromJsonObj(returnObj);
return objgs_AnswerCount;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_AnswerCount_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_AnswerCount_ConstructorName, strThisFuncName);
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
export async function gs_AnswerCount_GetObjLst_ClientCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
if (IsNullOrEmpty(clsgs_AnswerCountEN.WhereFormat) == false)
{
strWhereCond = Format(clsgs_AnswerCountEN.WhereFormat, strid_CurrEduCls);
}
else
{
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
}
const strKey = Format("{0}_{1}", clsgs_AnswerCountEN._CurrTabName, strid_CurrEduCls);
if (IsNullOrEmpty(clsgs_AnswerCountEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsgs_AnswerCountEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrgs_AnswerCountExObjLst_Cache: Array<clsgs_AnswerCountEN> = CacheHelper.Get(strKey);
const arrgs_AnswerCountObjLst_T = gs_AnswerCount_GetObjLstByJSONObjLst(arrgs_AnswerCountExObjLst_Cache);
return arrgs_AnswerCountObjLst_T;
}
try
{
const arrgs_AnswerCountExObjLst = await gs_AnswerCount_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrgs_AnswerCountExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_AnswerCountExObjLst.length);
console.log(strInfo);
return arrgs_AnswerCountExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, gs_AnswerCount_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_AnswerCount_GetObjLst_localStorage(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
if (IsNullOrEmpty(clsgs_AnswerCountEN.WhereFormat) == false)
{
strWhereCond = Format(clsgs_AnswerCountEN.WhereFormat, strid_CurrEduCls);
}
else
{
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
}
const strKey = Format("{0}_{1}", clsgs_AnswerCountEN._CurrTabName, strid_CurrEduCls);
if (IsNullOrEmpty(clsgs_AnswerCountEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsgs_AnswerCountEN.CacheAddiCondition);
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
const arrgs_AnswerCountExObjLst_Cache: Array<clsgs_AnswerCountEN> = JSON.parse(strTempObjLst);
const arrgs_AnswerCountObjLst_T = gs_AnswerCount_GetObjLstByJSONObjLst(arrgs_AnswerCountExObjLst_Cache);
return arrgs_AnswerCountObjLst_T;
}
try
{
const arrgs_AnswerCountExObjLst = await gs_AnswerCount_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrgs_AnswerCountExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_AnswerCountExObjLst.length);
console.log(strInfo);
return arrgs_AnswerCountExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, gs_AnswerCount_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_AnswerCount_GetObjLst_localStorage_PureCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsgs_AnswerCountEN._CurrTabName, strid_CurrEduCls);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrgs_AnswerCountObjLst_Cache: Array<clsgs_AnswerCountEN> = JSON.parse(strTempObjLst);
return arrgs_AnswerCountObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function gs_AnswerCount_GetObjLstAsync(strWhereCond: string): Promise<Array<clsgs_AnswerCountEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(gs_AnswerCount_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_AnswerCount_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_AnswerCount_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_AnswerCount_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_AnswerCount_ConstructorName, strThisFuncName);
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
export async function gs_AnswerCount_GetObjLst_sessionStorage(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
if (IsNullOrEmpty(clsgs_AnswerCountEN.WhereFormat) == false)
{
strWhereCond = Format(clsgs_AnswerCountEN.WhereFormat, strid_CurrEduCls);
}
else
{
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
}
const strKey = Format("{0}_{1}", clsgs_AnswerCountEN._CurrTabName, strid_CurrEduCls);
if (IsNullOrEmpty(clsgs_AnswerCountEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsgs_AnswerCountEN.CacheAddiCondition);
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
const arrgs_AnswerCountExObjLst_Cache: Array<clsgs_AnswerCountEN> = JSON.parse(strTempObjLst);
const arrgs_AnswerCountObjLst_T = gs_AnswerCount_GetObjLstByJSONObjLst(arrgs_AnswerCountExObjLst_Cache);
return arrgs_AnswerCountObjLst_T;
}
try
{
const arrgs_AnswerCountExObjLst = await gs_AnswerCount_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrgs_AnswerCountExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_AnswerCountExObjLst.length);
console.log(strInfo);
return arrgs_AnswerCountExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, gs_AnswerCount_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_AnswerCount_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsgs_AnswerCountEN._CurrTabName, strid_CurrEduCls);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrgs_AnswerCountObjLst_Cache: Array<clsgs_AnswerCountEN> = JSON.parse(strTempObjLst);
return arrgs_AnswerCountObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_AnswerCount_GetObjLst_Cache(strid_CurrEduCls: string): Promise<Array<clsgs_AnswerCountEN>>
{
//const strThisFuncName = "GetObjLst_Cache";

if (IsNullOrEmpty(strid_CurrEduCls) == true)
{
const strMsg = Format("缓存分类变量:[id_CurrEduCls]不能为空！(in clsgs_AnswerCountWApi.gs_AnswerCount_GetObjLst_Cache() )");
console.error(strMsg);
throw (strMsg);
}
if (strid_CurrEduCls.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(in clsgs_AnswerCountWApi.gs_AnswerCount_GetObjLst_Cache() )", strid_CurrEduCls.length);
console.error(strMsg);
throw (strMsg);
}
let arrgs_AnswerCountObjLst_Cache;
switch (clsgs_AnswerCountEN.CacheModeId)
{
case "04"://sessionStorage
arrgs_AnswerCountObjLst_Cache = await gs_AnswerCount_GetObjLst_sessionStorage(strid_CurrEduCls);
break;
case "03"://localStorage
arrgs_AnswerCountObjLst_Cache = await gs_AnswerCount_GetObjLst_localStorage(strid_CurrEduCls);
break;
case "02"://ClientCache
arrgs_AnswerCountObjLst_Cache = await gs_AnswerCount_GetObjLst_ClientCache(strid_CurrEduCls);
break;
default:
arrgs_AnswerCountObjLst_Cache = await gs_AnswerCount_GetObjLst_ClientCache(strid_CurrEduCls);
break;
}
const arrgs_AnswerCountObjLst = gs_AnswerCount_GetObjLstByJSONObjLst(arrgs_AnswerCountObjLst_Cache);
return arrgs_AnswerCountObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_AnswerCount_GetObjLst_PureCache(strid_CurrEduCls: string)
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrgs_AnswerCountObjLst_Cache;
switch (clsgs_AnswerCountEN.CacheModeId)
{
case "04"://sessionStorage
arrgs_AnswerCountObjLst_Cache = await gs_AnswerCount_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls);
break;
case "03"://localStorage
arrgs_AnswerCountObjLst_Cache = await gs_AnswerCount_GetObjLst_localStorage_PureCache(strid_CurrEduCls);
break;
case "02"://ClientCache
arrgs_AnswerCountObjLst_Cache = null;
break;
default:
arrgs_AnswerCountObjLst_Cache = null;
break;
}
return arrgs_AnswerCountObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrAnswerCountId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function gs_AnswerCount_GetSubObjLst_Cache(objgs_AnswerCount_Cond: clsgs_AnswerCountEN,strid_CurrEduCls: string) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrgs_AnswerCountObjLst_Cache = await gs_AnswerCount_GetObjLst_Cache(strid_CurrEduCls);
let arrgs_AnswerCount_Sel: Array < clsgs_AnswerCountEN > = arrgs_AnswerCountObjLst_Cache;
if (objgs_AnswerCount_Cond.sf_FldComparisonOp == null || objgs_AnswerCount_Cond.sf_FldComparisonOp == "") return arrgs_AnswerCount_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_AnswerCount_Cond.sf_FldComparisonOp);
//console.log("clsgs_AnswerCountWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objgs_AnswerCount_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_AnswerCount_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrgs_AnswerCount_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objgs_AnswerCount_Cond), gs_AnswerCount_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsgs_AnswerCountEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrAnswerCountId:关键字列表
 * @returns 对象列表
 **/
export async function gs_AnswerCount_GetObjLstByAnswerCountIdLstAsync(arrAnswerCountId: Array<string>): Promise<Array<clsgs_AnswerCountEN>>  
{
const strThisFuncName = "GetObjLstByAnswerCountIdLstAsync";
const strAction = "GetObjLstByAnswerCountIdLst";
const strUrl = GetWebApiUrl(gs_AnswerCount_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrAnswerCountId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_AnswerCount_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_AnswerCount_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_AnswerCount_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_AnswerCount_ConstructorName, strThisFuncName);
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
 * @param arrstrAnswerCountIdLst:关键字列表
 * @returns 对象列表
*/
export async function gs_AnswerCount_GetObjLstByAnswerCountIdLst_Cache(arrAnswerCountIdLst: Array<string>,strid_CurrEduCls: string) {
const strThisFuncName = "GetObjLstByAnswerCountIdLst_Cache";
try
{
const arrgs_AnswerCountObjLst_Cache = await gs_AnswerCount_GetObjLst_Cache(strid_CurrEduCls);
const arrgs_AnswerCount_Sel: Array <clsgs_AnswerCountEN> = arrgs_AnswerCountObjLst_Cache.filter(x => arrAnswerCountIdLst.indexOf(x.answerCountId)>-1);
return arrgs_AnswerCount_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrAnswerCountIdLst.join(","), gs_AnswerCount_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function gs_AnswerCount_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsgs_AnswerCountEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(gs_AnswerCount_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_AnswerCount_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_AnswerCount_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_AnswerCount_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_AnswerCount_ConstructorName, strThisFuncName);
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
export async function gs_AnswerCount_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsgs_AnswerCountEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(gs_AnswerCount_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_AnswerCount_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_AnswerCount_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_AnswerCount_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_AnswerCount_ConstructorName, strThisFuncName);
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
export async function gs_AnswerCount_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(gs_AnswerCount_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_AnswerCount_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_AnswerCount_ConstructorName, strThisFuncName);
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
export async function gs_AnswerCount_GetObjLstByPager_Cache(objPagerPara: stuPagerPara,strid_CurrEduCls: string) {
const strThisFuncName = "GetObjLstByPager_Cache";
if (objPagerPara.pageIndex == 0) return new Array<clsgs_AnswerCountEN>();
const arrgs_AnswerCountObjLst_Cache = await gs_AnswerCount_GetObjLst_Cache(strid_CurrEduCls);
if (arrgs_AnswerCountObjLst_Cache.length == 0) return arrgs_AnswerCountObjLst_Cache;
let arrgs_AnswerCount_Sel = arrgs_AnswerCountObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objgs_AnswerCount_Cond = new clsgs_AnswerCountEN();
ObjectAssign(objgs_AnswerCount_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsgs_AnswerCountWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_AnswerCount_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrgs_AnswerCount_Sel.length == 0) return arrgs_AnswerCount_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.sort(gs_AnswerCount_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.sort(objPagerPara.sortFun);
}
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.slice(intStart, intEnd);     
return arrgs_AnswerCount_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, gs_AnswerCount_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsgs_AnswerCountEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function gs_AnswerCount_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsgs_AnswerCountEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
if (objPagerPara.pageIndex == 0) return new Array<clsgs_AnswerCountEN>();
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(gs_AnswerCount_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_AnswerCount_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_AnswerCount_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_AnswerCount_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_AnswerCount_ConstructorName, strThisFuncName);
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
 * @param strAnswerCountId:关键字
 * @returns 获取删除的结果
 **/
export async function gs_AnswerCount_DelRecordAsync(strAnswerCountId: string): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(gs_AnswerCount_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, strAnswerCountId);
try
{
const response = await axios.delete(strUrl);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_AnswerCount_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_AnswerCount_ConstructorName, strThisFuncName);
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
 * @param arrAnswerCountId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function gs_AnswerCount_Delgs_AnswerCountsAsync(arrAnswerCountId: Array<string>): Promise<number> 
{
const strThisFuncName = "Delgs_AnswerCountsAsync";
const strAction = "Delgs_AnswerCounts";
const strUrl = GetWebApiUrl(gs_AnswerCount_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrAnswerCountId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_AnswerCount_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_AnswerCount_ConstructorName, strThisFuncName);
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
export async function gs_AnswerCount_Delgs_AnswerCountsByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "Delgs_AnswerCountsByCondAsync";
const strAction = "Delgs_AnswerCountsByCond";
const strUrl = GetWebApiUrl(gs_AnswerCount_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_AnswerCount_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_AnswerCount_ConstructorName, strThisFuncName);
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
 * @param objgs_AnswerCountEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_AnswerCount_AddNewRecordAsync(objgs_AnswerCountEN: clsgs_AnswerCountEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objgs_AnswerCountEN);
const strUrl = GetWebApiUrl(gs_AnswerCount_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_AnswerCountEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_AnswerCount_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_AnswerCount_ConstructorName, strThisFuncName);
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
 * @param objgs_AnswerCountEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_AnswerCount_AddNewRecordWithMaxIdAsync(objgs_AnswerCountEN: clsgs_AnswerCountEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithMaxIdAsync";
const strAction = "AddNewRecordWithMaxId";
const strUrl = GetWebApiUrl(gs_AnswerCount_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_AnswerCountEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_AnswerCount_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_AnswerCount_ConstructorName, strThisFuncName);
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
 * @param objgs_AnswerCountEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function gs_AnswerCount_AddNewRecordWithReturnKeyAsync(objgs_AnswerCountEN: clsgs_AnswerCountEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(gs_AnswerCount_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_AnswerCountEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_AnswerCount_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_AnswerCount_ConstructorName, strThisFuncName);
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
 * @param objgs_AnswerCountEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function gs_AnswerCount_AddNewRecordWithReturnKey(objgs_AnswerCountEN: clsgs_AnswerCountEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objgs_AnswerCountEN.answerCountId === null || objgs_AnswerCountEN.answerCountId === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(gs_AnswerCount_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_AnswerCountEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_AnswerCount_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_AnswerCount_ConstructorName, strThisFuncName);
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
 * @param objgs_AnswerCountEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function gs_AnswerCount_UpdateRecordAsync(objgs_AnswerCountEN: clsgs_AnswerCountEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objgs_AnswerCountEN.sfUpdFldSetStr === undefined || objgs_AnswerCountEN.sfUpdFldSetStr === null || objgs_AnswerCountEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_AnswerCountEN.answerCountId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(gs_AnswerCount_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_AnswerCountEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_AnswerCount_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_AnswerCount_ConstructorName, strThisFuncName);
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
 * @param objgs_AnswerCountEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function gs_AnswerCount_UpdateWithConditionAsync(objgs_AnswerCountEN: clsgs_AnswerCountEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objgs_AnswerCountEN.sfUpdFldSetStr === undefined || objgs_AnswerCountEN.sfUpdFldSetStr === null || objgs_AnswerCountEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_AnswerCountEN.answerCountId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(gs_AnswerCount_Controller, strAction);
objgs_AnswerCountEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objgs_AnswerCountEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_AnswerCount_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_AnswerCount_ConstructorName, strThisFuncName);
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
 * @param objstrAnswerCountId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function gs_AnswerCount_IsExistRecord_Cache(objgs_AnswerCount_Cond: clsgs_AnswerCountEN,strid_CurrEduCls: string) {
const strThisFuncName = "IsExistRecord_Cache";
const arrgs_AnswerCountObjLst_Cache = await gs_AnswerCount_GetObjLst_Cache(strid_CurrEduCls);
if (arrgs_AnswerCountObjLst_Cache == null) return false;
let arrgs_AnswerCount_Sel: Array < clsgs_AnswerCountEN > = arrgs_AnswerCountObjLst_Cache;
if (objgs_AnswerCount_Cond.sf_FldComparisonOp == null || objgs_AnswerCount_Cond.sf_FldComparisonOp == "") return arrgs_AnswerCount_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_AnswerCount_Cond.sf_FldComparisonOp);
//console.log("clsgs_AnswerCountWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objgs_AnswerCount_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_AnswerCount_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrgs_AnswerCount_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objgs_AnswerCount_Cond), gs_AnswerCount_ConstructorName, strThisFuncName);
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
export async function gs_AnswerCount_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(gs_AnswerCount_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_AnswerCount_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_AnswerCount_ConstructorName, strThisFuncName);
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
 * @param strAnswerCountId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function gs_AnswerCount_IsExist(strAnswerCountId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(gs_AnswerCount_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"AnswerCountId": strAnswerCountId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_AnswerCount_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_AnswerCount_ConstructorName, strThisFuncName);
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
 * @param strAnswerCountId:所给的关键字
 * @returns 对象
*/
export async function gs_AnswerCount_IsExist_Cache(strAnswerCountId:string,strid_CurrEduCls:string) {
const strThisFuncName = "IsExist_Cache";
const arrgs_AnswerCountObjLst_Cache = await gs_AnswerCount_GetObjLst_Cache(strid_CurrEduCls);
if (arrgs_AnswerCountObjLst_Cache == null) return false;
try
{
const arrgs_AnswerCount_Sel: Array <clsgs_AnswerCountEN> = arrgs_AnswerCountObjLst_Cache.filter(x => x.answerCountId == strAnswerCountId);
if (arrgs_AnswerCount_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strAnswerCountId, gs_AnswerCount_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param strAnswerCountId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function gs_AnswerCount_IsExistAsync(strAnswerCountId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(gs_AnswerCount_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strAnswerCountId": strAnswerCountId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_AnswerCount_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_AnswerCount_ConstructorName, strThisFuncName);
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
export async function gs_AnswerCount_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(gs_AnswerCount_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_AnswerCount_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_AnswerCount_ConstructorName, strThisFuncName);
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
 * @param objgs_AnswerCount_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function gs_AnswerCount_GetRecCountByCond_Cache(objgs_AnswerCount_Cond: clsgs_AnswerCountEN,strid_CurrEduCls: string) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrgs_AnswerCountObjLst_Cache = await gs_AnswerCount_GetObjLst_Cache(strid_CurrEduCls);
if (arrgs_AnswerCountObjLst_Cache == null) return 0;
let arrgs_AnswerCount_Sel: Array < clsgs_AnswerCountEN > = arrgs_AnswerCountObjLst_Cache;
if (objgs_AnswerCount_Cond.sf_FldComparisonOp == null || objgs_AnswerCount_Cond.sf_FldComparisonOp == "") return arrgs_AnswerCount_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_AnswerCount_Cond.sf_FldComparisonOp);
//console.log("clsgs_AnswerCountWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objgs_AnswerCount_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_AnswerCount_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrgs_AnswerCount_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objgs_AnswerCount_Cond), gs_AnswerCount_ConstructorName, strThisFuncName);
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
export async function gs_AnswerCount_GetMaxStrIdAsync(): Promise<string>  
{
const strThisFuncName = "GetMaxStrIdAsync";
const strAction = "GetMaxStrId";
const strUrl = GetWebApiUrl(gs_AnswerCount_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_AnswerCount_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_AnswerCount_ConstructorName, strThisFuncName);
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
export async function gs_AnswerCount_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(gs_AnswerCount_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_AnswerCount_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_AnswerCount_ConstructorName, strThisFuncName);
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
export function gs_AnswerCount_GetWebApiUrl(strController: string, strAction: string): string {
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
export function gs_AnswerCount_ReFreshCache(strid_CurrEduCls: string):void
{
const strThisFuncName = "ReFreshCache";

if (IsNullOrEmpty(strid_CurrEduCls) == true)
{
  const strMsg = Format("参数:[strid_CurrEduCls]不能为空！(In clsgs_AnswerCountWApi.clsgs_AnswerCountWApi.ReFreshCache)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_CurrEduCls.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(clsgs_AnswerCountWApi.clsgs_AnswerCountWApi.ReFreshCache)", strid_CurrEduCls.length);
console.error(strMsg);
throw (strMsg);
}

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = Format("{0}_{1}", clsgs_AnswerCountEN._CurrTabName, strid_CurrEduCls);
switch (clsgs_AnswerCountEN.CacheModeId)
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
export function gs_AnswerCount_ReFreshThisCache(strid_CurrEduCls: string):void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = Format("{0}_{1}", clsgs_AnswerCountEN._CurrTabName, strid_CurrEduCls);
switch (clsgs_AnswerCountEN.CacheModeId)
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
 * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function gs_AnswerCount_CheckPropertyNew(pobjgs_AnswerCountEN: clsgs_AnswerCountEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjgs_AnswerCountEN.memo) == false && GetStrLen(pobjgs_AnswerCountEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 问题讨论回答统计(gs_AnswerCount))!值:$(pobjgs_AnswerCountEN.memo)(clsgs_AnswerCountBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_AnswerCountEN.answerCountId) == false && GetStrLen(pobjgs_AnswerCountEN.answerCountId) > 10)
{
 throw new Error("(errid:Watl000059)字段[AnswerCountId(answerCountId)]的长度不能超过10(In 问题讨论回答统计(gs_AnswerCount))!值:$(pobjgs_AnswerCountEN.answerCountId)(clsgs_AnswerCountBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_AnswerCountEN.dataUser) == false && GetStrLen(pobjgs_AnswerCountEN.dataUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[数据用户(dataUser)]的长度不能超过20(In 问题讨论回答统计(gs_AnswerCount))!值:$(pobjgs_AnswerCountEN.dataUser)(clsgs_AnswerCountBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_AnswerCountEN.dataAddDate) == false && GetStrLen(pobjgs_AnswerCountEN.dataAddDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[数据添加日期(dataAddDate)]的长度不能超过20(In 问题讨论回答统计(gs_AnswerCount))!值:$(pobjgs_AnswerCountEN.dataAddDate)(clsgs_AnswerCountBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_AnswerCountEN.weekTimeRange) == false && GetStrLen(pobjgs_AnswerCountEN.weekTimeRange) > 100)
{
 throw new Error("(errid:Watl000059)字段[WeekTimeRange(weekTimeRange)]的长度不能超过100(In 问题讨论回答统计(gs_AnswerCount))!值:$(pobjgs_AnswerCountEN.weekTimeRange)(clsgs_AnswerCountBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_AnswerCountEN.answerId) == false && GetStrLen(pobjgs_AnswerCountEN.answerId) > 10)
{
 throw new Error("(errid:Watl000059)字段[回答Id(answerId)]的长度不能超过10(In 问题讨论回答统计(gs_AnswerCount))!值:$(pobjgs_AnswerCountEN.answerId)(clsgs_AnswerCountBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_AnswerCountEN.answerTypeId) == false && GetStrLen(pobjgs_AnswerCountEN.answerTypeId) > 2)
{
 throw new Error("(errid:Watl000059)字段[答案类型ID(answerTypeId)]的长度不能超过2(In 问题讨论回答统计(gs_AnswerCount))!值:$(pobjgs_AnswerCountEN.answerTypeId)(clsgs_AnswerCountBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_AnswerCountEN.questionsId) == false && GetStrLen(pobjgs_AnswerCountEN.questionsId) > 8)
{
 throw new Error("(errid:Watl000059)字段[提问Id(questionsId)]的长度不能超过8(In 问题讨论回答统计(gs_AnswerCount))!值:$(pobjgs_AnswerCountEN.questionsId)(clsgs_AnswerCountBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_AnswerCountEN.topicId) == false && GetStrLen(pobjgs_AnswerCountEN.topicId) > 8)
{
 throw new Error("(errid:Watl000059)字段[主题Id(topicId)]的长度不能超过8(In 问题讨论回答统计(gs_AnswerCount))!值:$(pobjgs_AnswerCountEN.topicId)(clsgs_AnswerCountBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_AnswerCountEN.paperId) == false && GetStrLen(pobjgs_AnswerCountEN.paperId) > 8)
{
 throw new Error("(errid:Watl000059)字段[论文Id(paperId)]的长度不能超过8(In 问题讨论回答统计(gs_AnswerCount))!值:$(pobjgs_AnswerCountEN.paperId)(clsgs_AnswerCountBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_AnswerCountEN.id_CurrEduCls) == false && GetStrLen(pobjgs_AnswerCountEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 问题讨论回答统计(gs_AnswerCount))!值:$(pobjgs_AnswerCountEN.id_CurrEduCls)(clsgs_AnswerCountBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_AnswerCountEN.scoreType) == false && GetStrLen(pobjgs_AnswerCountEN.scoreType) > 1)
{
 throw new Error("(errid:Watl000059)字段[评分类型(scoreType)]的长度不能超过1(In 问题讨论回答统计(gs_AnswerCount))!值:$(pobjgs_AnswerCountEN.scoreType)(clsgs_AnswerCountBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_AnswerCountEN.updUser) == false && GetStrLen(pobjgs_AnswerCountEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 问题讨论回答统计(gs_AnswerCount))!值:$(pobjgs_AnswerCountEN.updUser)(clsgs_AnswerCountBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_AnswerCountEN.updDate) == false && GetStrLen(pobjgs_AnswerCountEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 问题讨论回答统计(gs_AnswerCount))!值:$(pobjgs_AnswerCountEN.updDate)(clsgs_AnswerCountBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_AnswerCountEN.userName) == false && GetStrLen(pobjgs_AnswerCountEN.userName) > 30)
{
 throw new Error("(errid:Watl000059)字段[用户名(userName)]的长度不能超过30(In 问题讨论回答统计(gs_AnswerCount))!值:$(pobjgs_AnswerCountEN.userName)(clsgs_AnswerCountBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjgs_AnswerCountEN.memo) == false && undefined !== pobjgs_AnswerCountEN.memo && tzDataType.isString(pobjgs_AnswerCountEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjgs_AnswerCountEN.memo)], 非法，应该为字符型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_AnswerCountEN.answerCountId) == false && undefined !== pobjgs_AnswerCountEN.answerCountId && tzDataType.isString(pobjgs_AnswerCountEN.answerCountId) === false)
{
 throw new Error("(errid:Watl000060)字段[AnswerCountId(answerCountId)]的值:[$(pobjgs_AnswerCountEN.answerCountId)], 非法，应该为字符型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_AnswerCountEN.dataUser) == false && undefined !== pobjgs_AnswerCountEN.dataUser && tzDataType.isString(pobjgs_AnswerCountEN.dataUser) === false)
{
 throw new Error("(errid:Watl000060)字段[数据用户(dataUser)]的值:[$(pobjgs_AnswerCountEN.dataUser)], 非法，应该为字符型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_AnswerCountEN.dataAddDate) == false && undefined !== pobjgs_AnswerCountEN.dataAddDate && tzDataType.isString(pobjgs_AnswerCountEN.dataAddDate) === false)
{
 throw new Error("(errid:Watl000060)字段[数据添加日期(dataAddDate)]的值:[$(pobjgs_AnswerCountEN.dataAddDate)], 非法，应该为字符型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckPropertyNew)");
}
if (null != pobjgs_AnswerCountEN.month && undefined !== pobjgs_AnswerCountEN.month && tzDataType.isNumber(pobjgs_AnswerCountEN.month) === false)
{
 throw new Error("(errid:Watl000060)字段[月(month)]的值:[$(pobjgs_AnswerCountEN.month)], 非法，应该为数值型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckPropertyNew)");
}
if (null != pobjgs_AnswerCountEN.week && undefined !== pobjgs_AnswerCountEN.week && tzDataType.isNumber(pobjgs_AnswerCountEN.week) === false)
{
 throw new Error("(errid:Watl000060)字段[周(week)]的值:[$(pobjgs_AnswerCountEN.week)], 非法，应该为数值型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_AnswerCountEN.weekTimeRange) == false && undefined !== pobjgs_AnswerCountEN.weekTimeRange && tzDataType.isString(pobjgs_AnswerCountEN.weekTimeRange) === false)
{
 throw new Error("(errid:Watl000060)字段[WeekTimeRange(weekTimeRange)]的值:[$(pobjgs_AnswerCountEN.weekTimeRange)], 非法，应该为字符型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckPropertyNew)");
}
if (null != pobjgs_AnswerCountEN.isRecommend && undefined !== pobjgs_AnswerCountEN.isRecommend && tzDataType.isBoolean(pobjgs_AnswerCountEN.isRecommend) === false)
{
 throw new Error("(errid:Watl000060)字段[是否推荐(isRecommend)]的值:[$(pobjgs_AnswerCountEN.isRecommend)], 非法，应该为布尔型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_AnswerCountEN.answerId) == false && undefined !== pobjgs_AnswerCountEN.answerId && tzDataType.isString(pobjgs_AnswerCountEN.answerId) === false)
{
 throw new Error("(errid:Watl000060)字段[回答Id(answerId)]的值:[$(pobjgs_AnswerCountEN.answerId)], 非法，应该为字符型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_AnswerCountEN.answerTypeId) == false && undefined !== pobjgs_AnswerCountEN.answerTypeId && tzDataType.isString(pobjgs_AnswerCountEN.answerTypeId) === false)
{
 throw new Error("(errid:Watl000060)字段[答案类型ID(answerTypeId)]的值:[$(pobjgs_AnswerCountEN.answerTypeId)], 非法，应该为字符型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_AnswerCountEN.questionsId) == false && undefined !== pobjgs_AnswerCountEN.questionsId && tzDataType.isString(pobjgs_AnswerCountEN.questionsId) === false)
{
 throw new Error("(errid:Watl000060)字段[提问Id(questionsId)]的值:[$(pobjgs_AnswerCountEN.questionsId)], 非法，应该为字符型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_AnswerCountEN.topicId) == false && undefined !== pobjgs_AnswerCountEN.topicId && tzDataType.isString(pobjgs_AnswerCountEN.topicId) === false)
{
 throw new Error("(errid:Watl000060)字段[主题Id(topicId)]的值:[$(pobjgs_AnswerCountEN.topicId)], 非法，应该为字符型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_AnswerCountEN.paperId) == false && undefined !== pobjgs_AnswerCountEN.paperId && tzDataType.isString(pobjgs_AnswerCountEN.paperId) === false)
{
 throw new Error("(errid:Watl000060)字段[论文Id(paperId)]的值:[$(pobjgs_AnswerCountEN.paperId)], 非法，应该为字符型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_AnswerCountEN.id_CurrEduCls) == false && undefined !== pobjgs_AnswerCountEN.id_CurrEduCls && tzDataType.isString(pobjgs_AnswerCountEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjgs_AnswerCountEN.id_CurrEduCls)], 非法，应该为字符型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_AnswerCountEN.answerContent) == false && undefined !== pobjgs_AnswerCountEN.answerContent && tzDataType.isString(pobjgs_AnswerCountEN.answerContent) === false)
{
 throw new Error("(errid:Watl000060)字段[答案内容(answerContent)]的值:[$(pobjgs_AnswerCountEN.answerContent)], 非法，应该为字符型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckPropertyNew)");
}
if (null != pobjgs_AnswerCountEN.score && undefined !== pobjgs_AnswerCountEN.score && tzDataType.isNumber(pobjgs_AnswerCountEN.score) === false)
{
 throw new Error("(errid:Watl000060)字段[评分(score)]的值:[$(pobjgs_AnswerCountEN.score)], 非法，应该为数值型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_AnswerCountEN.scoreType) == false && undefined !== pobjgs_AnswerCountEN.scoreType && tzDataType.isString(pobjgs_AnswerCountEN.scoreType) === false)
{
 throw new Error("(errid:Watl000060)字段[评分类型(scoreType)]的值:[$(pobjgs_AnswerCountEN.scoreType)], 非法，应该为字符型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_AnswerCountEN.updUser) == false && undefined !== pobjgs_AnswerCountEN.updUser && tzDataType.isString(pobjgs_AnswerCountEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjgs_AnswerCountEN.updUser)], 非法，应该为字符型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_AnswerCountEN.updDate) == false && undefined !== pobjgs_AnswerCountEN.updDate && tzDataType.isString(pobjgs_AnswerCountEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjgs_AnswerCountEN.updDate)], 非法，应该为字符型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_AnswerCountEN.userName) == false && undefined !== pobjgs_AnswerCountEN.userName && tzDataType.isString(pobjgs_AnswerCountEN.userName) === false)
{
 throw new Error("(errid:Watl000060)字段[用户名(userName)]的值:[$(pobjgs_AnswerCountEN.userName)], 非法，应该为字符型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjgs_AnswerCountEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function gs_AnswerCount_CheckProperty4Update (pobjgs_AnswerCountEN: clsgs_AnswerCountEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjgs_AnswerCountEN.memo) == false && GetStrLen(pobjgs_AnswerCountEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 问题讨论回答统计(gs_AnswerCount))!值:$(pobjgs_AnswerCountEN.memo)(clsgs_AnswerCountBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_AnswerCountEN.answerCountId) == false && GetStrLen(pobjgs_AnswerCountEN.answerCountId) > 10)
{
 throw new Error("(errid:Watl000062)字段[AnswerCountId(answerCountId)]的长度不能超过10(In 问题讨论回答统计(gs_AnswerCount))!值:$(pobjgs_AnswerCountEN.answerCountId)(clsgs_AnswerCountBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_AnswerCountEN.dataUser) == false && GetStrLen(pobjgs_AnswerCountEN.dataUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[数据用户(dataUser)]的长度不能超过20(In 问题讨论回答统计(gs_AnswerCount))!值:$(pobjgs_AnswerCountEN.dataUser)(clsgs_AnswerCountBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_AnswerCountEN.dataAddDate) == false && GetStrLen(pobjgs_AnswerCountEN.dataAddDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[数据添加日期(dataAddDate)]的长度不能超过20(In 问题讨论回答统计(gs_AnswerCount))!值:$(pobjgs_AnswerCountEN.dataAddDate)(clsgs_AnswerCountBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_AnswerCountEN.weekTimeRange) == false && GetStrLen(pobjgs_AnswerCountEN.weekTimeRange) > 100)
{
 throw new Error("(errid:Watl000062)字段[WeekTimeRange(weekTimeRange)]的长度不能超过100(In 问题讨论回答统计(gs_AnswerCount))!值:$(pobjgs_AnswerCountEN.weekTimeRange)(clsgs_AnswerCountBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_AnswerCountEN.answerId) == false && GetStrLen(pobjgs_AnswerCountEN.answerId) > 10)
{
 throw new Error("(errid:Watl000062)字段[回答Id(answerId)]的长度不能超过10(In 问题讨论回答统计(gs_AnswerCount))!值:$(pobjgs_AnswerCountEN.answerId)(clsgs_AnswerCountBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_AnswerCountEN.answerTypeId) == false && GetStrLen(pobjgs_AnswerCountEN.answerTypeId) > 2)
{
 throw new Error("(errid:Watl000062)字段[答案类型ID(answerTypeId)]的长度不能超过2(In 问题讨论回答统计(gs_AnswerCount))!值:$(pobjgs_AnswerCountEN.answerTypeId)(clsgs_AnswerCountBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_AnswerCountEN.questionsId) == false && GetStrLen(pobjgs_AnswerCountEN.questionsId) > 8)
{
 throw new Error("(errid:Watl000062)字段[提问Id(questionsId)]的长度不能超过8(In 问题讨论回答统计(gs_AnswerCount))!值:$(pobjgs_AnswerCountEN.questionsId)(clsgs_AnswerCountBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_AnswerCountEN.topicId) == false && GetStrLen(pobjgs_AnswerCountEN.topicId) > 8)
{
 throw new Error("(errid:Watl000062)字段[主题Id(topicId)]的长度不能超过8(In 问题讨论回答统计(gs_AnswerCount))!值:$(pobjgs_AnswerCountEN.topicId)(clsgs_AnswerCountBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_AnswerCountEN.paperId) == false && GetStrLen(pobjgs_AnswerCountEN.paperId) > 8)
{
 throw new Error("(errid:Watl000062)字段[论文Id(paperId)]的长度不能超过8(In 问题讨论回答统计(gs_AnswerCount))!值:$(pobjgs_AnswerCountEN.paperId)(clsgs_AnswerCountBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_AnswerCountEN.id_CurrEduCls) == false && GetStrLen(pobjgs_AnswerCountEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 问题讨论回答统计(gs_AnswerCount))!值:$(pobjgs_AnswerCountEN.id_CurrEduCls)(clsgs_AnswerCountBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_AnswerCountEN.scoreType) == false && GetStrLen(pobjgs_AnswerCountEN.scoreType) > 1)
{
 throw new Error("(errid:Watl000062)字段[评分类型(scoreType)]的长度不能超过1(In 问题讨论回答统计(gs_AnswerCount))!值:$(pobjgs_AnswerCountEN.scoreType)(clsgs_AnswerCountBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_AnswerCountEN.updUser) == false && GetStrLen(pobjgs_AnswerCountEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 问题讨论回答统计(gs_AnswerCount))!值:$(pobjgs_AnswerCountEN.updUser)(clsgs_AnswerCountBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_AnswerCountEN.updDate) == false && GetStrLen(pobjgs_AnswerCountEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 问题讨论回答统计(gs_AnswerCount))!值:$(pobjgs_AnswerCountEN.updDate)(clsgs_AnswerCountBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_AnswerCountEN.userName) == false && GetStrLen(pobjgs_AnswerCountEN.userName) > 30)
{
 throw new Error("(errid:Watl000062)字段[用户名(userName)]的长度不能超过30(In 问题讨论回答统计(gs_AnswerCount))!值:$(pobjgs_AnswerCountEN.userName)(clsgs_AnswerCountBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjgs_AnswerCountEN.memo) == false && undefined !== pobjgs_AnswerCountEN.memo && tzDataType.isString(pobjgs_AnswerCountEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjgs_AnswerCountEN.memo)], 非法，应该为字符型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_AnswerCountEN.answerCountId) == false && undefined !== pobjgs_AnswerCountEN.answerCountId && tzDataType.isString(pobjgs_AnswerCountEN.answerCountId) === false)
{
 throw new Error("(errid:Watl000063)字段[AnswerCountId(answerCountId)]的值:[$(pobjgs_AnswerCountEN.answerCountId)], 非法，应该为字符型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_AnswerCountEN.dataUser) == false && undefined !== pobjgs_AnswerCountEN.dataUser && tzDataType.isString(pobjgs_AnswerCountEN.dataUser) === false)
{
 throw new Error("(errid:Watl000063)字段[数据用户(dataUser)]的值:[$(pobjgs_AnswerCountEN.dataUser)], 非法，应该为字符型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_AnswerCountEN.dataAddDate) == false && undefined !== pobjgs_AnswerCountEN.dataAddDate && tzDataType.isString(pobjgs_AnswerCountEN.dataAddDate) === false)
{
 throw new Error("(errid:Watl000063)字段[数据添加日期(dataAddDate)]的值:[$(pobjgs_AnswerCountEN.dataAddDate)], 非法，应该为字符型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckProperty4Update)");
}
if (null != pobjgs_AnswerCountEN.month && undefined !== pobjgs_AnswerCountEN.month && tzDataType.isNumber(pobjgs_AnswerCountEN.month) === false)
{
 throw new Error("(errid:Watl000063)字段[月(month)]的值:[$(pobjgs_AnswerCountEN.month)], 非法，应该为数值型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckProperty4Update)");
}
if (null != pobjgs_AnswerCountEN.week && undefined !== pobjgs_AnswerCountEN.week && tzDataType.isNumber(pobjgs_AnswerCountEN.week) === false)
{
 throw new Error("(errid:Watl000063)字段[周(week)]的值:[$(pobjgs_AnswerCountEN.week)], 非法，应该为数值型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_AnswerCountEN.weekTimeRange) == false && undefined !== pobjgs_AnswerCountEN.weekTimeRange && tzDataType.isString(pobjgs_AnswerCountEN.weekTimeRange) === false)
{
 throw new Error("(errid:Watl000063)字段[WeekTimeRange(weekTimeRange)]的值:[$(pobjgs_AnswerCountEN.weekTimeRange)], 非法，应该为字符型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckProperty4Update)");
}
if (null != pobjgs_AnswerCountEN.isRecommend && undefined !== pobjgs_AnswerCountEN.isRecommend && tzDataType.isBoolean(pobjgs_AnswerCountEN.isRecommend) === false)
{
 throw new Error("(errid:Watl000063)字段[是否推荐(isRecommend)]的值:[$(pobjgs_AnswerCountEN.isRecommend)], 非法，应该为布尔型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_AnswerCountEN.answerId) == false && undefined !== pobjgs_AnswerCountEN.answerId && tzDataType.isString(pobjgs_AnswerCountEN.answerId) === false)
{
 throw new Error("(errid:Watl000063)字段[回答Id(answerId)]的值:[$(pobjgs_AnswerCountEN.answerId)], 非法，应该为字符型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_AnswerCountEN.answerTypeId) == false && undefined !== pobjgs_AnswerCountEN.answerTypeId && tzDataType.isString(pobjgs_AnswerCountEN.answerTypeId) === false)
{
 throw new Error("(errid:Watl000063)字段[答案类型ID(answerTypeId)]的值:[$(pobjgs_AnswerCountEN.answerTypeId)], 非法，应该为字符型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_AnswerCountEN.questionsId) == false && undefined !== pobjgs_AnswerCountEN.questionsId && tzDataType.isString(pobjgs_AnswerCountEN.questionsId) === false)
{
 throw new Error("(errid:Watl000063)字段[提问Id(questionsId)]的值:[$(pobjgs_AnswerCountEN.questionsId)], 非法，应该为字符型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_AnswerCountEN.topicId) == false && undefined !== pobjgs_AnswerCountEN.topicId && tzDataType.isString(pobjgs_AnswerCountEN.topicId) === false)
{
 throw new Error("(errid:Watl000063)字段[主题Id(topicId)]的值:[$(pobjgs_AnswerCountEN.topicId)], 非法，应该为字符型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_AnswerCountEN.paperId) == false && undefined !== pobjgs_AnswerCountEN.paperId && tzDataType.isString(pobjgs_AnswerCountEN.paperId) === false)
{
 throw new Error("(errid:Watl000063)字段[论文Id(paperId)]的值:[$(pobjgs_AnswerCountEN.paperId)], 非法，应该为字符型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_AnswerCountEN.id_CurrEduCls) == false && undefined !== pobjgs_AnswerCountEN.id_CurrEduCls && tzDataType.isString(pobjgs_AnswerCountEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjgs_AnswerCountEN.id_CurrEduCls)], 非法，应该为字符型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_AnswerCountEN.answerContent) == false && undefined !== pobjgs_AnswerCountEN.answerContent && tzDataType.isString(pobjgs_AnswerCountEN.answerContent) === false)
{
 throw new Error("(errid:Watl000063)字段[答案内容(answerContent)]的值:[$(pobjgs_AnswerCountEN.answerContent)], 非法，应该为字符型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckProperty4Update)");
}
if (null != pobjgs_AnswerCountEN.score && undefined !== pobjgs_AnswerCountEN.score && tzDataType.isNumber(pobjgs_AnswerCountEN.score) === false)
{
 throw new Error("(errid:Watl000063)字段[评分(score)]的值:[$(pobjgs_AnswerCountEN.score)], 非法，应该为数值型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_AnswerCountEN.scoreType) == false && undefined !== pobjgs_AnswerCountEN.scoreType && tzDataType.isString(pobjgs_AnswerCountEN.scoreType) === false)
{
 throw new Error("(errid:Watl000063)字段[评分类型(scoreType)]的值:[$(pobjgs_AnswerCountEN.scoreType)], 非法，应该为字符型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_AnswerCountEN.updUser) == false && undefined !== pobjgs_AnswerCountEN.updUser && tzDataType.isString(pobjgs_AnswerCountEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjgs_AnswerCountEN.updUser)], 非法，应该为字符型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_AnswerCountEN.updDate) == false && undefined !== pobjgs_AnswerCountEN.updDate && tzDataType.isString(pobjgs_AnswerCountEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjgs_AnswerCountEN.updDate)], 非法，应该为字符型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_AnswerCountEN.userName) == false && undefined !== pobjgs_AnswerCountEN.userName && tzDataType.isString(pobjgs_AnswerCountEN.userName) === false)
{
 throw new Error("(errid:Watl000063)字段[用户名(userName)]的值:[$(pobjgs_AnswerCountEN.userName)], 非法，应该为字符型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (IsNullOrEmpty(pobjgs_AnswerCountEN.answerCountId) === true )
{
 throw new Error("(errid:Watl000064)字段[AnswerCountId]不能为空(In 问题讨论回答统计)!(clsgs_AnswerCountBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjgs_AnswerCountEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function gs_AnswerCount_GetJSONStrByObj (pobjgs_AnswerCountEN: clsgs_AnswerCountEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjgs_AnswerCountEN.sfUpdFldSetStr = pobjgs_AnswerCountEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjgs_AnswerCountEN);
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
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象列表
*/
export function gs_AnswerCount_GetObjLstByJSONStr (strJSON: string): Array<clsgs_AnswerCountEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrgs_AnswerCountObjLst = new Array<clsgs_AnswerCountEN>();
if (strJSON === "")
{
return arrgs_AnswerCountObjLst;
}
try
{
arrgs_AnswerCountObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrgs_AnswerCountObjLst;
}
return arrgs_AnswerCountObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrgs_AnswerCountObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function gs_AnswerCount_GetObjLstByJSONObjLst (arrgs_AnswerCountObjLstS: Array<clsgs_AnswerCountEN>): Array<clsgs_AnswerCountEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrgs_AnswerCountObjLst = new Array<clsgs_AnswerCountEN>();
for (const objInFor of arrgs_AnswerCountObjLstS) {
const obj1 = gs_AnswerCount_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrgs_AnswerCountObjLst.push(obj1);
}
return arrgs_AnswerCountObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function gs_AnswerCount_GetObjByJSONStr (strJSON: string): clsgs_AnswerCountEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjgs_AnswerCountEN = new clsgs_AnswerCountEN();
if (strJSON === "")
{
return pobjgs_AnswerCountEN;
}
try
{
pobjgs_AnswerCountEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjgs_AnswerCountEN;
}
return pobjgs_AnswerCountEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function gs_AnswerCount_GetCombineCondition(objgs_AnswerCount_Cond: clsgs_AnswerCountEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objgs_AnswerCount_Cond.dicFldComparisonOp, clsgs_AnswerCountEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objgs_AnswerCount_Cond.dicFldComparisonOp[clsgs_AnswerCountEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_AnswerCountEN.con_Memo, objgs_AnswerCount_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objgs_AnswerCount_Cond.dicFldComparisonOp, clsgs_AnswerCountEN.con_AnswerCountId) == true)
{
const strComparisonOp_AnswerCountId:string = objgs_AnswerCount_Cond.dicFldComparisonOp[clsgs_AnswerCountEN.con_AnswerCountId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_AnswerCountEN.con_AnswerCountId, objgs_AnswerCount_Cond.answerCountId, strComparisonOp_AnswerCountId);
}
if (Object.prototype.hasOwnProperty.call(objgs_AnswerCount_Cond.dicFldComparisonOp, clsgs_AnswerCountEN.con_DataUser) == true)
{
const strComparisonOp_DataUser:string = objgs_AnswerCount_Cond.dicFldComparisonOp[clsgs_AnswerCountEN.con_DataUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_AnswerCountEN.con_DataUser, objgs_AnswerCount_Cond.dataUser, strComparisonOp_DataUser);
}
if (Object.prototype.hasOwnProperty.call(objgs_AnswerCount_Cond.dicFldComparisonOp, clsgs_AnswerCountEN.con_DataAddDate) == true)
{
const strComparisonOp_DataAddDate:string = objgs_AnswerCount_Cond.dicFldComparisonOp[clsgs_AnswerCountEN.con_DataAddDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_AnswerCountEN.con_DataAddDate, objgs_AnswerCount_Cond.dataAddDate, strComparisonOp_DataAddDate);
}
if (Object.prototype.hasOwnProperty.call(objgs_AnswerCount_Cond.dicFldComparisonOp, clsgs_AnswerCountEN.con_Month) == true)
{
const strComparisonOp_Month:string = objgs_AnswerCount_Cond.dicFldComparisonOp[clsgs_AnswerCountEN.con_Month];
strWhereCond += Format(" And {0} {2} {1}", clsgs_AnswerCountEN.con_Month, objgs_AnswerCount_Cond.month, strComparisonOp_Month);
}
if (Object.prototype.hasOwnProperty.call(objgs_AnswerCount_Cond.dicFldComparisonOp, clsgs_AnswerCountEN.con_Week) == true)
{
const strComparisonOp_Week:string = objgs_AnswerCount_Cond.dicFldComparisonOp[clsgs_AnswerCountEN.con_Week];
strWhereCond += Format(" And {0} {2} {1}", clsgs_AnswerCountEN.con_Week, objgs_AnswerCount_Cond.week, strComparisonOp_Week);
}
if (Object.prototype.hasOwnProperty.call(objgs_AnswerCount_Cond.dicFldComparisonOp, clsgs_AnswerCountEN.con_WeekTimeRange) == true)
{
const strComparisonOp_WeekTimeRange:string = objgs_AnswerCount_Cond.dicFldComparisonOp[clsgs_AnswerCountEN.con_WeekTimeRange];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_AnswerCountEN.con_WeekTimeRange, objgs_AnswerCount_Cond.weekTimeRange, strComparisonOp_WeekTimeRange);
}
if (Object.prototype.hasOwnProperty.call(objgs_AnswerCount_Cond.dicFldComparisonOp, clsgs_AnswerCountEN.con_IsRecommend) == true)
{
if (objgs_AnswerCount_Cond.isRecommend == true)
{
strWhereCond += Format(" And {0} = '1'", clsgs_AnswerCountEN.con_IsRecommend);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsgs_AnswerCountEN.con_IsRecommend);
}
}
if (Object.prototype.hasOwnProperty.call(objgs_AnswerCount_Cond.dicFldComparisonOp, clsgs_AnswerCountEN.con_AnswerId) == true)
{
const strComparisonOp_AnswerId:string = objgs_AnswerCount_Cond.dicFldComparisonOp[clsgs_AnswerCountEN.con_AnswerId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_AnswerCountEN.con_AnswerId, objgs_AnswerCount_Cond.answerId, strComparisonOp_AnswerId);
}
if (Object.prototype.hasOwnProperty.call(objgs_AnswerCount_Cond.dicFldComparisonOp, clsgs_AnswerCountEN.con_AnswerTypeId) == true)
{
const strComparisonOp_AnswerTypeId:string = objgs_AnswerCount_Cond.dicFldComparisonOp[clsgs_AnswerCountEN.con_AnswerTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_AnswerCountEN.con_AnswerTypeId, objgs_AnswerCount_Cond.answerTypeId, strComparisonOp_AnswerTypeId);
}
if (Object.prototype.hasOwnProperty.call(objgs_AnswerCount_Cond.dicFldComparisonOp, clsgs_AnswerCountEN.con_QuestionsId) == true)
{
const strComparisonOp_QuestionsId:string = objgs_AnswerCount_Cond.dicFldComparisonOp[clsgs_AnswerCountEN.con_QuestionsId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_AnswerCountEN.con_QuestionsId, objgs_AnswerCount_Cond.questionsId, strComparisonOp_QuestionsId);
}
if (Object.prototype.hasOwnProperty.call(objgs_AnswerCount_Cond.dicFldComparisonOp, clsgs_AnswerCountEN.con_TopicId) == true)
{
const strComparisonOp_TopicId:string = objgs_AnswerCount_Cond.dicFldComparisonOp[clsgs_AnswerCountEN.con_TopicId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_AnswerCountEN.con_TopicId, objgs_AnswerCount_Cond.topicId, strComparisonOp_TopicId);
}
if (Object.prototype.hasOwnProperty.call(objgs_AnswerCount_Cond.dicFldComparisonOp, clsgs_AnswerCountEN.con_PaperId) == true)
{
const strComparisonOp_PaperId:string = objgs_AnswerCount_Cond.dicFldComparisonOp[clsgs_AnswerCountEN.con_PaperId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_AnswerCountEN.con_PaperId, objgs_AnswerCount_Cond.paperId, strComparisonOp_PaperId);
}
if (Object.prototype.hasOwnProperty.call(objgs_AnswerCount_Cond.dicFldComparisonOp, clsgs_AnswerCountEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objgs_AnswerCount_Cond.dicFldComparisonOp[clsgs_AnswerCountEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_AnswerCountEN.con_id_CurrEduCls, objgs_AnswerCount_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objgs_AnswerCount_Cond.dicFldComparisonOp, clsgs_AnswerCountEN.con_Score) == true)
{
const strComparisonOp_Score:string = objgs_AnswerCount_Cond.dicFldComparisonOp[clsgs_AnswerCountEN.con_Score];
strWhereCond += Format(" And {0} {2} {1}", clsgs_AnswerCountEN.con_Score, objgs_AnswerCount_Cond.score, strComparisonOp_Score);
}
if (Object.prototype.hasOwnProperty.call(objgs_AnswerCount_Cond.dicFldComparisonOp, clsgs_AnswerCountEN.con_ScoreType) == true)
{
const strComparisonOp_ScoreType:string = objgs_AnswerCount_Cond.dicFldComparisonOp[clsgs_AnswerCountEN.con_ScoreType];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_AnswerCountEN.con_ScoreType, objgs_AnswerCount_Cond.scoreType, strComparisonOp_ScoreType);
}
if (Object.prototype.hasOwnProperty.call(objgs_AnswerCount_Cond.dicFldComparisonOp, clsgs_AnswerCountEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objgs_AnswerCount_Cond.dicFldComparisonOp[clsgs_AnswerCountEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_AnswerCountEN.con_UpdUser, objgs_AnswerCount_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objgs_AnswerCount_Cond.dicFldComparisonOp, clsgs_AnswerCountEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objgs_AnswerCount_Cond.dicFldComparisonOp[clsgs_AnswerCountEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_AnswerCountEN.con_UpdDate, objgs_AnswerCount_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objgs_AnswerCount_Cond.dicFldComparisonOp, clsgs_AnswerCountEN.con_UserName) == true)
{
const strComparisonOp_UserName:string = objgs_AnswerCount_Cond.dicFldComparisonOp[clsgs_AnswerCountEN.con_UserName];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_AnswerCountEN.con_UserName, objgs_AnswerCount_Cond.userName, strComparisonOp_UserName);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--gs_AnswerCount(问题讨论回答统计),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param strAnswerCountId: AnswerCountId(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function gs_AnswerCount_GetUniCondStr_AnswerCountId(objgs_AnswerCountEN: clsgs_AnswerCountEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and AnswerCountId = '{0}'", objgs_AnswerCountEN.answerCountId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--gs_AnswerCount(问题讨论回答统计),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param strAnswerCountId: AnswerCountId(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function gs_AnswerCount_GetUniCondStr4Update_AnswerCountId(objgs_AnswerCountEN: clsgs_AnswerCountEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and AnswerCountId <> '{0}'", objgs_AnswerCountEN.answerCountId);
 strWhereCond +=  Format(" and AnswerCountId = '{0}'", objgs_AnswerCountEN.answerCountId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objgs_AnswerCountENS:源对象
 * @param objgs_AnswerCountENT:目标对象
*/
export function gs_AnswerCount_CopyObjTo(objgs_AnswerCountENS: clsgs_AnswerCountEN , objgs_AnswerCountENT: clsgs_AnswerCountEN ): void 
{
objgs_AnswerCountENT.memo = objgs_AnswerCountENS.memo; //备注
objgs_AnswerCountENT.answerCountId = objgs_AnswerCountENS.answerCountId; //AnswerCountId
objgs_AnswerCountENT.dataUser = objgs_AnswerCountENS.dataUser; //数据用户
objgs_AnswerCountENT.dataAddDate = objgs_AnswerCountENS.dataAddDate; //数据添加日期
objgs_AnswerCountENT.month = objgs_AnswerCountENS.month; //月
objgs_AnswerCountENT.week = objgs_AnswerCountENS.week; //周
objgs_AnswerCountENT.weekTimeRange = objgs_AnswerCountENS.weekTimeRange; //WeekTimeRange
objgs_AnswerCountENT.isRecommend = objgs_AnswerCountENS.isRecommend; //是否推荐
objgs_AnswerCountENT.answerId = objgs_AnswerCountENS.answerId; //回答Id
objgs_AnswerCountENT.answerTypeId = objgs_AnswerCountENS.answerTypeId; //答案类型ID
objgs_AnswerCountENT.questionsId = objgs_AnswerCountENS.questionsId; //提问Id
objgs_AnswerCountENT.topicId = objgs_AnswerCountENS.topicId; //主题Id
objgs_AnswerCountENT.paperId = objgs_AnswerCountENS.paperId; //论文Id
objgs_AnswerCountENT.id_CurrEduCls = objgs_AnswerCountENS.id_CurrEduCls; //教学班流水号
objgs_AnswerCountENT.answerContent = objgs_AnswerCountENS.answerContent; //答案内容
objgs_AnswerCountENT.score = objgs_AnswerCountENS.score; //评分
objgs_AnswerCountENT.scoreType = objgs_AnswerCountENS.scoreType; //评分类型
objgs_AnswerCountENT.updUser = objgs_AnswerCountENS.updUser; //修改人
objgs_AnswerCountENT.updDate = objgs_AnswerCountENS.updDate; //修改日期
objgs_AnswerCountENT.userName = objgs_AnswerCountENS.userName; //用户名
objgs_AnswerCountENT.sfUpdFldSetStr = objgs_AnswerCountENS.updFldString; //sfUpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objgs_AnswerCountENS:源对象
 * @param objgs_AnswerCountENT:目标对象
*/
export function gs_AnswerCount_GetObjFromJsonObj(objgs_AnswerCountENS: clsgs_AnswerCountEN): clsgs_AnswerCountEN 
{
 const objgs_AnswerCountENT: clsgs_AnswerCountEN = new clsgs_AnswerCountEN();
ObjectAssign(objgs_AnswerCountENT, objgs_AnswerCountENS);
 return objgs_AnswerCountENT;
}