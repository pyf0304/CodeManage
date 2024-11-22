
 /**
 * 类名:clsqa_AnswerVWApi
 * 表名:qa_AnswerV(01120756)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:46:13
 * 生成者:pyf
 * 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
 * 框架-层名:WA_访问层(TS)(WA_Access)
 * 编程语言:TypeScript
 * 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
   *      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 **/

/**
 * 答疑回答历史V(qa_AnswerV)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clsqa_AnswerVEN } from "../../L0_Entity/InteractManage/clsqa_AnswerVEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { tzDataType } from "../../PubFun/jsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const qa_AnswerV_Controller = "qa_AnswerVApi";
 export const qa_AnswerV_ConstructorName = "qa_AnswerV";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngAnswerVId:关键字
 * @returns 对象
 **/
export async function qa_AnswerV_GetObjByAnswerVIdAsync(lngAnswerVId: number): Promise<clsqa_AnswerVEN>  
{
const strThisFuncName = "GetObjByAnswerVIdAsync";

if (lngAnswerVId == 0)
{
  const strMsg = Format("参数:[lngAnswerVId]不能为空！(In GetObjByAnswerVIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjByAnswerVId";
const strUrl = GetWebApiUrl(qa_AnswerV_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"lngAnswerVId": lngAnswerVId,
}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObj = data.returnObj;
if (returnObj == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", qa_AnswerV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objqa_AnswerV = qa_AnswerV_GetObjFromJsonObj(returnObj);
return objqa_AnswerV;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_AnswerV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_AnswerV_ConstructorName, strThisFuncName);
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
 * @param lngAnswerVId:所给的关键字
 * @returns 对象
*/
export async function qa_AnswerV_GetObjByAnswerVId_Cache(lngAnswerVId:number,strTopicId:string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByAnswerVId_Cache";

if (lngAnswerVId == 0)
{
  const strMsg = Format("参数:[lngAnswerVId]不能为空！(In GetObjByAnswerVId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
const arrqa_AnswerVObjLst_Cache = await qa_AnswerV_GetObjLst_Cache(strTopicId);
try
{
const arrqa_AnswerV_Sel: Array <clsqa_AnswerVEN> = arrqa_AnswerVObjLst_Cache.filter(x => x.answerVId == lngAnswerVId);
let objqa_AnswerV: clsqa_AnswerVEN;
if (arrqa_AnswerV_Sel.length > 0)
{
objqa_AnswerV = arrqa_AnswerV_Sel[0];
return objqa_AnswerV;
}
else
{
if (bolTryAsyncOnce == true)
{
objqa_AnswerV = await qa_AnswerV_GetObjByAnswerVIdAsync(lngAnswerVId);
if (objqa_AnswerV != null)
{
qa_AnswerV_ReFreshThisCache(strTopicId);
return objqa_AnswerV;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngAnswerVId, qa_AnswerV_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param lngAnswerVId:所给的关键字
 * @returns 对象
*/
export async function qa_AnswerV_GetObjByAnswerVId_localStorage(lngAnswerVId: number) {
const strThisFuncName = "GetObjByAnswerVId_localStorage";

if (lngAnswerVId == 0)
{
  const strMsg = Format("参数:[lngAnswerVId]不能为空！(In GetObjByAnswerVId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
const strKey = Format("{0}_{1}", clsqa_AnswerVEN._CurrTabName, lngAnswerVId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objqa_AnswerV_Cache: clsqa_AnswerVEN = JSON.parse(strTempObj);
return objqa_AnswerV_Cache;
}
try
{
const objqa_AnswerV = await qa_AnswerV_GetObjByAnswerVIdAsync(lngAnswerVId);
if (objqa_AnswerV != null)
{
localStorage.setItem(strKey, JSON.stringify(objqa_AnswerV));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objqa_AnswerV;
}
return objqa_AnswerV;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngAnswerVId, qa_AnswerV_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objqa_AnswerV:所给的对象
 * @returns 对象
*/
export async function qa_AnswerV_UpdateObjInLst_Cache(objqa_AnswerV: clsqa_AnswerVEN,strTopicId: string) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrqa_AnswerVObjLst_Cache = await qa_AnswerV_GetObjLst_Cache(strTopicId);
const obj = arrqa_AnswerVObjLst_Cache.find(x => x.answerVId == objqa_AnswerV.answerVId);
if (obj != null)
{
objqa_AnswerV.answerVId = obj.answerVId;
ObjectAssign( obj, objqa_AnswerV);
}
else
{
arrqa_AnswerVObjLst_Cache.push(objqa_AnswerV);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, qa_AnswerV_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
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
 @param strTopicId:缓存的分类字段
 * @returns 返回一个输出字段值
*/
export async function qa_AnswerV_func(strInFldName:string , strOutFldName:string , strInValue:number , strTopicId_C: string)
{
//const strThisFuncName = "func";

if (IsNullOrEmpty(strTopicId_C) == true)
{
  const strMsg = Format("参数:[strTopicId_C]不能为空！(In func)");
console.error(strMsg);
 throw (strMsg);
}
if (strTopicId_C.length != 8)
{
const strMsg = Format("缓存分类变量:[strTopicId_C]的长度:[{0}]不正确！", strTopicId_C.length);
console.error(strMsg);
throw (strMsg);
}

if (strInFldName != clsqa_AnswerVEN.con_AnswerVId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsqa_AnswerVEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clsqa_AnswerVEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const lngAnswerVId = Number(strInValue);
if (lngAnswerVId == 0)
{
return "";
}
const objqa_AnswerV = await qa_AnswerV_GetObjByAnswerVId_Cache(lngAnswerVId , strTopicId_C);
if (objqa_AnswerV == null) return "";
return objqa_AnswerV.GetFldValue(strOutFldName).toString();
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
export function qa_AnswerV_SortFun_Defa(a:clsqa_AnswerVEN , b:clsqa_AnswerVEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.answerVId-b.answerVId;
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
export function qa_AnswerV_SortFun_Defa_2Fld(a:clsqa_AnswerVEN , b:clsqa_AnswerVEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.answerId == b.answerId) return a.questionsId.localeCompare(b.questionsId);
else return a.answerId.localeCompare(b.answerId);
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
export function qa_AnswerV_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsqa_AnswerVEN.con_AnswerVId:
return (a: clsqa_AnswerVEN, b: clsqa_AnswerVEN) => {
return a.answerVId-b.answerVId;
}
case clsqa_AnswerVEN.con_AnswerId:
return (a: clsqa_AnswerVEN, b: clsqa_AnswerVEN) => {
return a.answerId.localeCompare(b.answerId);
}
case clsqa_AnswerVEN.con_QuestionsId:
return (a: clsqa_AnswerVEN, b: clsqa_AnswerVEN) => {
return a.questionsId.localeCompare(b.questionsId);
}
case clsqa_AnswerVEN.con_AnswerContent:
return (a: clsqa_AnswerVEN, b: clsqa_AnswerVEN) => {
return a.answerContent.localeCompare(b.answerContent);
}
case clsqa_AnswerVEN.con_score:
return (a: clsqa_AnswerVEN, b: clsqa_AnswerVEN) => {
return a.score-b.score;
}
case clsqa_AnswerVEN.con_ScoreType:
return (a: clsqa_AnswerVEN, b: clsqa_AnswerVEN) => {
return a.scoreType.localeCompare(b.scoreType);
}
case clsqa_AnswerVEN.con_IsRight:
return (a: clsqa_AnswerVEN, b: clsqa_AnswerVEN) => {
if (a.isRight == true) return 1;
else return -1
}
case clsqa_AnswerVEN.con_ParentId:
return (a: clsqa_AnswerVEN, b: clsqa_AnswerVEN) => {
return a.parentId.localeCompare(b.parentId);
}
case clsqa_AnswerVEN.con_VoteCount:
return (a: clsqa_AnswerVEN, b: clsqa_AnswerVEN) => {
return a.voteCount-b.voteCount;
}
case clsqa_AnswerVEN.con_IsRecommend:
return (a: clsqa_AnswerVEN, b: clsqa_AnswerVEN) => {
if (a.isRecommend == true) return 1;
else return -1
}
case clsqa_AnswerVEN.con_TopicId:
return (a: clsqa_AnswerVEN, b: clsqa_AnswerVEN) => {
return a.topicId.localeCompare(b.topicId);
}
case clsqa_AnswerVEN.con_AnswerTypeId:
return (a: clsqa_AnswerVEN, b: clsqa_AnswerVEN) => {
return a.answerTypeId.localeCompare(b.answerTypeId);
}
case clsqa_AnswerVEN.con_IsSubmit:
return (a: clsqa_AnswerVEN, b: clsqa_AnswerVEN) => {
if (a.isSubmit == true) return 1;
else return -1
}
case clsqa_AnswerVEN.con_UpdUser:
return (a: clsqa_AnswerVEN, b: clsqa_AnswerVEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsqa_AnswerVEN.con_UpdDate:
return (a: clsqa_AnswerVEN, b: clsqa_AnswerVEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsqa_AnswerVEN.con_Memo:
return (a: clsqa_AnswerVEN, b: clsqa_AnswerVEN) => {
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[qa_AnswerV]中不存在！(in ${ qa_AnswerV_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsqa_AnswerVEN.con_AnswerVId:
return (a: clsqa_AnswerVEN, b: clsqa_AnswerVEN) => {
return b.answerVId-a.answerVId;
}
case clsqa_AnswerVEN.con_AnswerId:
return (a: clsqa_AnswerVEN, b: clsqa_AnswerVEN) => {
return b.answerId.localeCompare(a.answerId);
}
case clsqa_AnswerVEN.con_QuestionsId:
return (a: clsqa_AnswerVEN, b: clsqa_AnswerVEN) => {
return b.questionsId.localeCompare(a.questionsId);
}
case clsqa_AnswerVEN.con_AnswerContent:
return (a: clsqa_AnswerVEN, b: clsqa_AnswerVEN) => {
return b.answerContent.localeCompare(a.answerContent);
}
case clsqa_AnswerVEN.con_score:
return (a: clsqa_AnswerVEN, b: clsqa_AnswerVEN) => {
return b.score-a.score;
}
case clsqa_AnswerVEN.con_ScoreType:
return (a: clsqa_AnswerVEN, b: clsqa_AnswerVEN) => {
return b.scoreType.localeCompare(a.scoreType);
}
case clsqa_AnswerVEN.con_IsRight:
return (a: clsqa_AnswerVEN, b: clsqa_AnswerVEN) => {
if (b.isRight == true) return 1;
else return -1
}
case clsqa_AnswerVEN.con_ParentId:
return (a: clsqa_AnswerVEN, b: clsqa_AnswerVEN) => {
return b.parentId.localeCompare(a.parentId);
}
case clsqa_AnswerVEN.con_VoteCount:
return (a: clsqa_AnswerVEN, b: clsqa_AnswerVEN) => {
return b.voteCount-a.voteCount;
}
case clsqa_AnswerVEN.con_IsRecommend:
return (a: clsqa_AnswerVEN, b: clsqa_AnswerVEN) => {
if (b.isRecommend == true) return 1;
else return -1
}
case clsqa_AnswerVEN.con_TopicId:
return (a: clsqa_AnswerVEN, b: clsqa_AnswerVEN) => {
return b.topicId.localeCompare(a.topicId);
}
case clsqa_AnswerVEN.con_AnswerTypeId:
return (a: clsqa_AnswerVEN, b: clsqa_AnswerVEN) => {
return b.answerTypeId.localeCompare(a.answerTypeId);
}
case clsqa_AnswerVEN.con_IsSubmit:
return (a: clsqa_AnswerVEN, b: clsqa_AnswerVEN) => {
if (b.isSubmit == true) return 1;
else return -1
}
case clsqa_AnswerVEN.con_UpdUser:
return (a: clsqa_AnswerVEN, b: clsqa_AnswerVEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsqa_AnswerVEN.con_UpdDate:
return (a: clsqa_AnswerVEN, b: clsqa_AnswerVEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsqa_AnswerVEN.con_Memo:
return (a: clsqa_AnswerVEN, b: clsqa_AnswerVEN) => {
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[qa_AnswerV]中不存在！(in ${ qa_AnswerV_ConstructorName}.${ strThisFuncName})`;
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
export async function qa_AnswerV_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsqa_AnswerVEN.con_AnswerVId:
return (obj: clsqa_AnswerVEN) => {
return obj.answerVId === value;
}
case clsqa_AnswerVEN.con_AnswerId:
return (obj: clsqa_AnswerVEN) => {
return obj.answerId === value;
}
case clsqa_AnswerVEN.con_QuestionsId:
return (obj: clsqa_AnswerVEN) => {
return obj.questionsId === value;
}
case clsqa_AnswerVEN.con_AnswerContent:
return (obj: clsqa_AnswerVEN) => {
return obj.answerContent === value;
}
case clsqa_AnswerVEN.con_score:
return (obj: clsqa_AnswerVEN) => {
return obj.score === value;
}
case clsqa_AnswerVEN.con_ScoreType:
return (obj: clsqa_AnswerVEN) => {
return obj.scoreType === value;
}
case clsqa_AnswerVEN.con_IsRight:
return (obj: clsqa_AnswerVEN) => {
return obj.isRight === value;
}
case clsqa_AnswerVEN.con_ParentId:
return (obj: clsqa_AnswerVEN) => {
return obj.parentId === value;
}
case clsqa_AnswerVEN.con_VoteCount:
return (obj: clsqa_AnswerVEN) => {
return obj.voteCount === value;
}
case clsqa_AnswerVEN.con_IsRecommend:
return (obj: clsqa_AnswerVEN) => {
return obj.isRecommend === value;
}
case clsqa_AnswerVEN.con_TopicId:
return (obj: clsqa_AnswerVEN) => {
return obj.topicId === value;
}
case clsqa_AnswerVEN.con_AnswerTypeId:
return (obj: clsqa_AnswerVEN) => {
return obj.answerTypeId === value;
}
case clsqa_AnswerVEN.con_IsSubmit:
return (obj: clsqa_AnswerVEN) => {
return obj.isSubmit === value;
}
case clsqa_AnswerVEN.con_UpdUser:
return (obj: clsqa_AnswerVEN) => {
return obj.updUser === value;
}
case clsqa_AnswerVEN.con_UpdDate:
return (obj: clsqa_AnswerVEN) => {
return obj.updDate === value;
}
case clsqa_AnswerVEN.con_Memo:
return (obj: clsqa_AnswerVEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[qa_AnswerV]中不存在！(in ${ qa_AnswerV_ConstructorName}.${ strThisFuncName})`;
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
export async function qa_AnswerV_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(qa_AnswerV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_AnswerV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_AnswerV_ConstructorName, strThisFuncName);
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
export async function qa_AnswerV_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(qa_AnswerV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_AnswerV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_AnswerV_ConstructorName, strThisFuncName);
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
export async function qa_AnswerV_GetFirstObjAsync(strWhereCond: string): Promise<clsqa_AnswerVEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(qa_AnswerV_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", qa_AnswerV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objqa_AnswerV = qa_AnswerV_GetObjFromJsonObj(returnObj);
return objqa_AnswerV;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_AnswerV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_AnswerV_ConstructorName, strThisFuncName);
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
export async function qa_AnswerV_GetObjLst_ClientCache(strTopicId: string)
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("TopicId='{0}'", strTopicId);
const strKey = Format("{0}_{1}", clsqa_AnswerVEN._CurrTabName, strTopicId);
clsqa_AnswerVEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsqa_AnswerVEN._CurrTabName);
if (IsNullOrEmpty(clsqa_AnswerVEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsqa_AnswerVEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrqa_AnswerVExObjLst_Cache: Array<clsqa_AnswerVEN> = CacheHelper.Get(strKey);
const arrqa_AnswerVObjLst_T = qa_AnswerV_GetObjLstByJSONObjLst(arrqa_AnswerVExObjLst_Cache);
return arrqa_AnswerVObjLst_T;
}
try
{
const arrqa_AnswerVExObjLst = await qa_AnswerV_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrqa_AnswerVExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrqa_AnswerVExObjLst.length);
console.log(strInfo);
return arrqa_AnswerVExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, qa_AnswerV_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function qa_AnswerV_GetObjLst_localStorage(strTopicId: string)
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("TopicId='{0}'", strTopicId);
const strKey = Format("{0}_{1}", clsqa_AnswerVEN._CurrTabName, strTopicId);
clsqa_AnswerVEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsqa_AnswerVEN._CurrTabName);
if (IsNullOrEmpty(clsqa_AnswerVEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsqa_AnswerVEN.CacheAddiCondition);
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
const arrqa_AnswerVExObjLst_Cache: Array<clsqa_AnswerVEN> = JSON.parse(strTempObjLst);
const arrqa_AnswerVObjLst_T = qa_AnswerV_GetObjLstByJSONObjLst(arrqa_AnswerVExObjLst_Cache);
return arrqa_AnswerVObjLst_T;
}
try
{
const arrqa_AnswerVExObjLst = await qa_AnswerV_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrqa_AnswerVExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrqa_AnswerVExObjLst.length);
console.log(strInfo);
return arrqa_AnswerVExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, qa_AnswerV_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function qa_AnswerV_GetObjLst_localStorage_PureCache(strTopicId: string)
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("TopicId='{0}'", strTopicId);
const strKey = Format("{0}_{1}", clsqa_AnswerVEN._CurrTabName, strTopicId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrqa_AnswerVObjLst_Cache: Array<clsqa_AnswerVEN> = JSON.parse(strTempObjLst);
return arrqa_AnswerVObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function qa_AnswerV_GetObjLstAsync(strWhereCond: string): Promise<Array<clsqa_AnswerVEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(qa_AnswerV_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", qa_AnswerV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = qa_AnswerV_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_AnswerV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_AnswerV_ConstructorName, strThisFuncName);
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
export async function qa_AnswerV_GetObjLst_sessionStorage(strTopicId: string)
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("TopicId='{0}'", strTopicId);
const strKey = Format("{0}_{1}", clsqa_AnswerVEN._CurrTabName, strTopicId);
clsqa_AnswerVEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsqa_AnswerVEN._CurrTabName);
if (IsNullOrEmpty(clsqa_AnswerVEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsqa_AnswerVEN.CacheAddiCondition);
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
const arrqa_AnswerVExObjLst_Cache: Array<clsqa_AnswerVEN> = JSON.parse(strTempObjLst);
const arrqa_AnswerVObjLst_T = qa_AnswerV_GetObjLstByJSONObjLst(arrqa_AnswerVExObjLst_Cache);
return arrqa_AnswerVObjLst_T;
}
try
{
const arrqa_AnswerVExObjLst = await qa_AnswerV_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrqa_AnswerVExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrqa_AnswerVExObjLst.length);
console.log(strInfo);
return arrqa_AnswerVExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, qa_AnswerV_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function qa_AnswerV_GetObjLst_sessionStorage_PureCache(strTopicId: string)
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("TopicId='{0}'", strTopicId);
const strKey = Format("{0}_{1}", clsqa_AnswerVEN._CurrTabName, strTopicId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrqa_AnswerVObjLst_Cache: Array<clsqa_AnswerVEN> = JSON.parse(strTempObjLst);
return arrqa_AnswerVObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function qa_AnswerV_GetObjLst_Cache(strTopicId: string): Promise<Array<clsqa_AnswerVEN>>
{
//const strThisFuncName = "GetObjLst_Cache";

if (IsNullOrEmpty(strTopicId) == true)
{
const strMsg = Format("缓存分类变量:[TopicId]不能为空！");
console.error(strMsg);
throw (strMsg);
}
if (strTopicId.length != 8)
{
const strMsg = Format("缓存分类变量:[strTopicId]的长度:[{0}]不正确！", strTopicId.length);
console.error(strMsg);
throw (strMsg);
}
let arrqa_AnswerVObjLst_Cache;
switch (clsqa_AnswerVEN.CacheModeId)
{
case "04"://sessionStorage
arrqa_AnswerVObjLst_Cache = await qa_AnswerV_GetObjLst_sessionStorage(strTopicId);
break;
case "03"://localStorage
arrqa_AnswerVObjLst_Cache = await qa_AnswerV_GetObjLst_localStorage(strTopicId);
break;
case "02"://ClientCache
arrqa_AnswerVObjLst_Cache = await qa_AnswerV_GetObjLst_ClientCache(strTopicId);
break;
default:
arrqa_AnswerVObjLst_Cache = await qa_AnswerV_GetObjLst_ClientCache(strTopicId);
break;
}
const arrqa_AnswerVObjLst = qa_AnswerV_GetObjLstByJSONObjLst(arrqa_AnswerVObjLst_Cache);
return arrqa_AnswerVObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function qa_AnswerV_GetObjLst_PureCache(strTopicId: string)
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrqa_AnswerVObjLst_Cache;
switch (clsqa_AnswerVEN.CacheModeId)
{
case "04"://sessionStorage
arrqa_AnswerVObjLst_Cache = await qa_AnswerV_GetObjLst_sessionStorage_PureCache(strTopicId);
break;
case "03"://localStorage
arrqa_AnswerVObjLst_Cache = await qa_AnswerV_GetObjLst_localStorage_PureCache(strTopicId);
break;
case "02"://ClientCache
arrqa_AnswerVObjLst_Cache = null;
break;
default:
arrqa_AnswerVObjLst_Cache = null;
break;
}
return arrqa_AnswerVObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objlngAnswerVId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function qa_AnswerV_GetSubObjLst_Cache(objqa_AnswerV_Cond: clsqa_AnswerVEN,strTopicId: string) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrqa_AnswerVObjLst_Cache = await qa_AnswerV_GetObjLst_Cache(strTopicId);
let arrqa_AnswerV_Sel: Array < clsqa_AnswerVEN > = arrqa_AnswerVObjLst_Cache;
if (objqa_AnswerV_Cond.sf_FldComparisonOp == null || objqa_AnswerV_Cond.sf_FldComparisonOp == "") return arrqa_AnswerV_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objqa_AnswerV_Cond.sf_FldComparisonOp);
//console.log("clsqa_AnswerVWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objqa_AnswerV_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrqa_AnswerV_Sel = arrqa_AnswerV_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objqa_AnswerV_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrqa_AnswerV_Sel = arrqa_AnswerV_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrqa_AnswerV_Sel = arrqa_AnswerV_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrqa_AnswerV_Sel = arrqa_AnswerV_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrqa_AnswerV_Sel = arrqa_AnswerV_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrqa_AnswerV_Sel = arrqa_AnswerV_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrqa_AnswerV_Sel = arrqa_AnswerV_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrqa_AnswerV_Sel = arrqa_AnswerV_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrqa_AnswerV_Sel = arrqa_AnswerV_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrqa_AnswerV_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objqa_AnswerV_Cond), qa_AnswerV_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsqa_AnswerVEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrAnswerVId:关键字列表
 * @returns 对象列表
 **/
export async function qa_AnswerV_GetObjLstByAnswerVIdLstAsync(arrAnswerVId: Array<string>): Promise<Array<clsqa_AnswerVEN>>  
{
const strThisFuncName = "GetObjLstByAnswerVIdLstAsync";
const strAction = "GetObjLstByAnswerVIdLst";
const strUrl = GetWebApiUrl(qa_AnswerV_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrAnswerVId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", qa_AnswerV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = qa_AnswerV_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_AnswerV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_AnswerV_ConstructorName, strThisFuncName);
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
 * @param arrlngAnswerVIdLst:关键字列表
 * @returns 对象列表
*/
export async function qa_AnswerV_GetObjLstByAnswerVIdLst_Cache(arrAnswerVIdLst: Array<number>,strTopicId: string) {
const strThisFuncName = "GetObjLstByAnswerVIdLst_Cache";
try
{
const arrqa_AnswerVObjLst_Cache = await qa_AnswerV_GetObjLst_Cache(strTopicId);
const arrqa_AnswerV_Sel: Array <clsqa_AnswerVEN> = arrqa_AnswerVObjLst_Cache.filter(x => arrAnswerVIdLst.indexOf(x.answerVId)>-1);
return arrqa_AnswerV_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrAnswerVIdLst.join(","), qa_AnswerV_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsqa_AnswerVEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function qa_AnswerV_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsqa_AnswerVEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(qa_AnswerV_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", qa_AnswerV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = qa_AnswerV_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_AnswerV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_AnswerV_ConstructorName, strThisFuncName);
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
export async function qa_AnswerV_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsqa_AnswerVEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(qa_AnswerV_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", qa_AnswerV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = qa_AnswerV_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_AnswerV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_AnswerV_ConstructorName, strThisFuncName);
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
export async function qa_AnswerV_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(qa_AnswerV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_AnswerV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_AnswerV_ConstructorName, strThisFuncName);
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
export async function qa_AnswerV_GetObjLstByPager_Cache(objPagerPara: stuPagerPara,strTopicId: string) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrqa_AnswerVObjLst_Cache = await qa_AnswerV_GetObjLst_Cache(strTopicId);
if (arrqa_AnswerVObjLst_Cache.length == 0) return arrqa_AnswerVObjLst_Cache;
let arrqa_AnswerV_Sel = arrqa_AnswerVObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objqa_AnswerV_Cond = new clsqa_AnswerVEN();
ObjectAssign(objqa_AnswerV_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsqa_AnswerVWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrqa_AnswerV_Sel = arrqa_AnswerV_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objqa_AnswerV_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrqa_AnswerV_Sel = arrqa_AnswerV_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrqa_AnswerV_Sel = arrqa_AnswerV_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrqa_AnswerV_Sel = arrqa_AnswerV_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrqa_AnswerV_Sel = arrqa_AnswerV_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrqa_AnswerV_Sel = arrqa_AnswerV_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrqa_AnswerV_Sel = arrqa_AnswerV_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrqa_AnswerV_Sel = arrqa_AnswerV_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrqa_AnswerV_Sel = arrqa_AnswerV_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrqa_AnswerV_Sel = arrqa_AnswerV_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrqa_AnswerV_Sel.length == 0) return arrqa_AnswerV_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrqa_AnswerV_Sel = arrqa_AnswerV_Sel.sort(qa_AnswerV_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrqa_AnswerV_Sel = arrqa_AnswerV_Sel.sort(objPagerPara.sortFun);
}
arrqa_AnswerV_Sel = arrqa_AnswerV_Sel.slice(intStart, intEnd);     
return arrqa_AnswerV_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, qa_AnswerV_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsqa_AnswerVEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function qa_AnswerV_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsqa_AnswerVEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(qa_AnswerV_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", qa_AnswerV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = qa_AnswerV_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_AnswerV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_AnswerV_ConstructorName, strThisFuncName);
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
 * @param lngAnswerVId:关键字
 * @returns 获取删除的结果
 **/
export async function qa_AnswerV_DelRecordAsync(lngAnswerVId: number): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(qa_AnswerV_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, lngAnswerVId);
try
{
const response = await axios.delete(strUrl,
{
params: { "Id": lngAnswerVId, }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_AnswerV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_AnswerV_ConstructorName, strThisFuncName);
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
 * @param arrAnswerVId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function qa_AnswerV_Delqa_AnswerVsAsync(arrAnswerVId: Array<string>): Promise<number> 
{
const strThisFuncName = "Delqa_AnswerVsAsync";
const strAction = "Delqa_AnswerVs";
const strUrl = GetWebApiUrl(qa_AnswerV_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrAnswerVId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_AnswerV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_AnswerV_ConstructorName, strThisFuncName);
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
export async function qa_AnswerV_Delqa_AnswerVsByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "Delqa_AnswerVsByCondAsync";
const strAction = "Delqa_AnswerVsByCond";
const strUrl = GetWebApiUrl(qa_AnswerV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_AnswerV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_AnswerV_ConstructorName, strThisFuncName);
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
 * @param objqa_AnswerVEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function qa_AnswerV_AddNewRecordAsync(objqa_AnswerVEN: clsqa_AnswerVEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objqa_AnswerVEN);
const strUrl = GetWebApiUrl(qa_AnswerV_Controller, strAction);
try
{
const response = await axios.post(strUrl, objqa_AnswerVEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_AnswerV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_AnswerV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}
/* 数据类型不是字符型，不可以最大关键字的方式添加记录。*/

 /**
 * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
 * @param objqa_AnswerVEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function qa_AnswerV_AddNewRecordWithReturnKeyAsync(objqa_AnswerVEN: clsqa_AnswerVEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(qa_AnswerV_Controller, strAction);
try
{
const response = await axios.post(strUrl, objqa_AnswerVEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_AnswerV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_AnswerV_ConstructorName, strThisFuncName);
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
 * @param objqa_AnswerVEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function qa_AnswerV_AddNewRecordWithReturnKey(objqa_AnswerVEN: clsqa_AnswerVEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objqa_AnswerVEN.answerVId === null || objqa_AnswerVEN.answerVId === 0)
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(qa_AnswerV_Controller, strAction);
try
{
const response = await axios.post(strUrl, objqa_AnswerVEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_AnswerV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_AnswerV_ConstructorName, strThisFuncName);
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
 * @param objqa_AnswerVEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function qa_AnswerV_UpdateRecordAsync(objqa_AnswerVEN: clsqa_AnswerVEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objqa_AnswerVEN.sf_UpdFldSetStr === undefined || objqa_AnswerVEN.sf_UpdFldSetStr === null || objqa_AnswerVEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objqa_AnswerVEN.answerVId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(qa_AnswerV_Controller, strAction);
try
{
const response = await axios.post(strUrl, objqa_AnswerVEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_AnswerV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_AnswerV_ConstructorName, strThisFuncName);
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
 * @param objqa_AnswerVEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function qa_AnswerV_UpdateWithConditionAsync(objqa_AnswerVEN: clsqa_AnswerVEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objqa_AnswerVEN.sf_UpdFldSetStr === undefined || objqa_AnswerVEN.sf_UpdFldSetStr === null || objqa_AnswerVEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objqa_AnswerVEN.answerVId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(qa_AnswerV_Controller, strAction);
objqa_AnswerVEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objqa_AnswerVEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_AnswerV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_AnswerV_ConstructorName, strThisFuncName);
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
 * @param objlngAnswerVId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function qa_AnswerV_IsExistRecord_Cache(objqa_AnswerV_Cond: clsqa_AnswerVEN,strTopicId: string) {
const strThisFuncName = "IsExistRecord_Cache";
const arrqa_AnswerVObjLst_Cache = await qa_AnswerV_GetObjLst_Cache(strTopicId);
if (arrqa_AnswerVObjLst_Cache == null) return false;
let arrqa_AnswerV_Sel: Array < clsqa_AnswerVEN > = arrqa_AnswerVObjLst_Cache;
if (objqa_AnswerV_Cond.sf_FldComparisonOp == null || objqa_AnswerV_Cond.sf_FldComparisonOp == "") return arrqa_AnswerV_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objqa_AnswerV_Cond.sf_FldComparisonOp);
//console.log("clsqa_AnswerVWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objqa_AnswerV_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objqa_AnswerV_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrqa_AnswerV_Sel = arrqa_AnswerV_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrqa_AnswerV_Sel = arrqa_AnswerV_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrqa_AnswerV_Sel = arrqa_AnswerV_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrqa_AnswerV_Sel = arrqa_AnswerV_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrqa_AnswerV_Sel = arrqa_AnswerV_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrqa_AnswerV_Sel = arrqa_AnswerV_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrqa_AnswerV_Sel = arrqa_AnswerV_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrqa_AnswerV_Sel = arrqa_AnswerV_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrqa_AnswerV_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objqa_AnswerV_Cond), qa_AnswerV_ConstructorName, strThisFuncName);
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
export async function qa_AnswerV_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(qa_AnswerV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_AnswerV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_AnswerV_ConstructorName, strThisFuncName);
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
 * @param lngAnswerVId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function qa_AnswerV_IsExist(lngAnswerVId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(qa_AnswerV_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"AnswerVId": lngAnswerVId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_AnswerV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_AnswerV_ConstructorName, strThisFuncName);
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
 * @param lngAnswerVId:所给的关键字
 * @returns 对象
*/
export async function qa_AnswerV_IsExist_Cache(lngAnswerVId:number,strTopicId:string) {
const strThisFuncName = "IsExist_Cache";
const arrqa_AnswerVObjLst_Cache = await qa_AnswerV_GetObjLst_Cache(strTopicId);
if (arrqa_AnswerVObjLst_Cache == null) return false;
try
{
const arrqa_AnswerV_Sel: Array <clsqa_AnswerVEN> = arrqa_AnswerVObjLst_Cache.filter(x => x.answerVId == lngAnswerVId);
if (arrqa_AnswerV_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngAnswerVId, qa_AnswerV_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param lngAnswerVId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function qa_AnswerV_IsExistAsync(lngAnswerVId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(qa_AnswerV_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "lngAnswerVId": lngAnswerVId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_AnswerV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_AnswerV_ConstructorName, strThisFuncName);
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
export async function qa_AnswerV_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(qa_AnswerV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_AnswerV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_AnswerV_ConstructorName, strThisFuncName);
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
 * @param objqa_AnswerV_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function qa_AnswerV_GetRecCountByCond_Cache(objqa_AnswerV_Cond: clsqa_AnswerVEN,strTopicId: string) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrqa_AnswerVObjLst_Cache = await qa_AnswerV_GetObjLst_Cache(strTopicId);
if (arrqa_AnswerVObjLst_Cache == null) return 0;
let arrqa_AnswerV_Sel: Array < clsqa_AnswerVEN > = arrqa_AnswerVObjLst_Cache;
if (objqa_AnswerV_Cond.sf_FldComparisonOp == null || objqa_AnswerV_Cond.sf_FldComparisonOp == "") return arrqa_AnswerV_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objqa_AnswerV_Cond.sf_FldComparisonOp);
//console.log("clsqa_AnswerVWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objqa_AnswerV_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrqa_AnswerV_Sel = arrqa_AnswerV_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objqa_AnswerV_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrqa_AnswerV_Sel = arrqa_AnswerV_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrqa_AnswerV_Sel = arrqa_AnswerV_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrqa_AnswerV_Sel = arrqa_AnswerV_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrqa_AnswerV_Sel = arrqa_AnswerV_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrqa_AnswerV_Sel = arrqa_AnswerV_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrqa_AnswerV_Sel = arrqa_AnswerV_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrqa_AnswerV_Sel = arrqa_AnswerV_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrqa_AnswerV_Sel = arrqa_AnswerV_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrqa_AnswerV_Sel = arrqa_AnswerV_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrqa_AnswerV_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objqa_AnswerV_Cond), qa_AnswerV_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return 0;
}
/*该表的关键字类型不是字符型自增，不需要生成获取最大关键字函数！*/
/*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/

/**
 * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
 * @param mapParam:参数列表
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 获取当前表关键字值的最大值
*/
export async function qa_AnswerV_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(qa_AnswerV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_AnswerV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_AnswerV_ConstructorName, strThisFuncName);
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
export function qa_AnswerV_GetWebApiUrl(strController: string, strAction: string): string {
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
export function qa_AnswerV_ReFreshCache(strTopicId: string):void
{
const strThisFuncName = "ReFreshCache";

if (IsNullOrEmpty(strTopicId) == true)
{
  const strMsg = Format("参数:[strTopicId]不能为空！(In clsqa_AnswerVWApi.ReFreshCache)");
console.error(strMsg);
 throw (strMsg);
}
if (strTopicId.length != 8)
{
const strMsg = Format("缓存分类变量:[strTopicId]的长度:[{0}]不正确！", strTopicId.length);
console.error(strMsg);
throw (strMsg);
}

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = Format("{0}_{1}", clsqa_AnswerVEN._CurrTabName, strTopicId);
switch (clsqa_AnswerVEN.CacheModeId)
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
export function qa_AnswerV_ReFreshThisCache(strTopicId: string):void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = Format("{0}_{1}", clsqa_AnswerVEN._CurrTabName, strTopicId);
switch (clsqa_AnswerVEN.CacheModeId)
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
export function qa_AnswerV_CheckPropertyNew(pobjqa_AnswerVEN: clsqa_AnswerVEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjqa_AnswerVEN.answerId) === true )
{
 throw new Error("(errid:Watl000058)字段[回答Id]不能为空(In 答疑回答历史V)!(clsqa_AnswerVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjqa_AnswerVEN.questionsId) === true )
{
 throw new Error("(errid:Watl000058)字段[提问Id]不能为空(In 答疑回答历史V)!(clsqa_AnswerVBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjqa_AnswerVEN.answerId) == false && GetStrLen(pobjqa_AnswerVEN.answerId) > 10)
{
 throw new Error("(errid:Watl000059)字段[回答Id(answerId)]的长度不能超过10(In 答疑回答历史V(qa_AnswerV))!值:$(pobjqa_AnswerVEN.answerId)(clsqa_AnswerVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjqa_AnswerVEN.questionsId) == false && GetStrLen(pobjqa_AnswerVEN.questionsId) > 8)
{
 throw new Error("(errid:Watl000059)字段[提问Id(questionsId)]的长度不能超过8(In 答疑回答历史V(qa_AnswerV))!值:$(pobjqa_AnswerVEN.questionsId)(clsqa_AnswerVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjqa_AnswerVEN.scoreType) == false && GetStrLen(pobjqa_AnswerVEN.scoreType) > 1)
{
 throw new Error("(errid:Watl000059)字段[评分类型(scoreType)]的长度不能超过1(In 答疑回答历史V(qa_AnswerV))!值:$(pobjqa_AnswerVEN.scoreType)(clsqa_AnswerVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjqa_AnswerVEN.parentId) == false && GetStrLen(pobjqa_AnswerVEN.parentId) > 10)
{
 throw new Error("(errid:Watl000059)字段[父节点Id(parentId)]的长度不能超过10(In 答疑回答历史V(qa_AnswerV))!值:$(pobjqa_AnswerVEN.parentId)(clsqa_AnswerVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjqa_AnswerVEN.topicId) == false && GetStrLen(pobjqa_AnswerVEN.topicId) > 8)
{
 throw new Error("(errid:Watl000059)字段[主题Id(topicId)]的长度不能超过8(In 答疑回答历史V(qa_AnswerV))!值:$(pobjqa_AnswerVEN.topicId)(clsqa_AnswerVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjqa_AnswerVEN.answerTypeId) == false && GetStrLen(pobjqa_AnswerVEN.answerTypeId) > 2)
{
 throw new Error("(errid:Watl000059)字段[答案类型ID(answerTypeId)]的长度不能超过2(In 答疑回答历史V(qa_AnswerV))!值:$(pobjqa_AnswerVEN.answerTypeId)(clsqa_AnswerVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjqa_AnswerVEN.updUser) == false && GetStrLen(pobjqa_AnswerVEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 答疑回答历史V(qa_AnswerV))!值:$(pobjqa_AnswerVEN.updUser)(clsqa_AnswerVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjqa_AnswerVEN.updDate) == false && GetStrLen(pobjqa_AnswerVEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 答疑回答历史V(qa_AnswerV))!值:$(pobjqa_AnswerVEN.updDate)(clsqa_AnswerVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjqa_AnswerVEN.memo) == false && GetStrLen(pobjqa_AnswerVEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 答疑回答历史V(qa_AnswerV))!值:$(pobjqa_AnswerVEN.memo)(clsqa_AnswerVBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null != pobjqa_AnswerVEN.answerVId && undefined !== pobjqa_AnswerVEN.answerVId && tzDataType.isNumber(pobjqa_AnswerVEN.answerVId) === false)
{
 throw new Error("(errid:Watl000060)字段[问答历史主键(answerVId)]的值:[$(pobjqa_AnswerVEN.answerVId)], 非法，应该为数值型(In 答疑回答历史V(qa_AnswerV))!(clsqa_AnswerVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjqa_AnswerVEN.answerId) == false && undefined !== pobjqa_AnswerVEN.answerId && tzDataType.isString(pobjqa_AnswerVEN.answerId) === false)
{
 throw new Error("(errid:Watl000060)字段[回答Id(answerId)]的值:[$(pobjqa_AnswerVEN.answerId)], 非法，应该为字符型(In 答疑回答历史V(qa_AnswerV))!(clsqa_AnswerVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjqa_AnswerVEN.questionsId) == false && undefined !== pobjqa_AnswerVEN.questionsId && tzDataType.isString(pobjqa_AnswerVEN.questionsId) === false)
{
 throw new Error("(errid:Watl000060)字段[提问Id(questionsId)]的值:[$(pobjqa_AnswerVEN.questionsId)], 非法，应该为字符型(In 答疑回答历史V(qa_AnswerV))!(clsqa_AnswerVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjqa_AnswerVEN.answerContent) == false && undefined !== pobjqa_AnswerVEN.answerContent && tzDataType.isString(pobjqa_AnswerVEN.answerContent) === false)
{
 throw new Error("(errid:Watl000060)字段[答案内容(answerContent)]的值:[$(pobjqa_AnswerVEN.answerContent)], 非法，应该为字符型(In 答疑回答历史V(qa_AnswerV))!(clsqa_AnswerVBL:CheckPropertyNew)");
}
if (null != pobjqa_AnswerVEN.score && undefined !== pobjqa_AnswerVEN.score && tzDataType.isNumber(pobjqa_AnswerVEN.score) === false)
{
 throw new Error("(errid:Watl000060)字段[评分(score)]的值:[$(pobjqa_AnswerVEN.score)], 非法，应该为数值型(In 答疑回答历史V(qa_AnswerV))!(clsqa_AnswerVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjqa_AnswerVEN.scoreType) == false && undefined !== pobjqa_AnswerVEN.scoreType && tzDataType.isString(pobjqa_AnswerVEN.scoreType) === false)
{
 throw new Error("(errid:Watl000060)字段[评分类型(scoreType)]的值:[$(pobjqa_AnswerVEN.scoreType)], 非法，应该为字符型(In 答疑回答历史V(qa_AnswerV))!(clsqa_AnswerVBL:CheckPropertyNew)");
}
if (null != pobjqa_AnswerVEN.isRight && undefined !== pobjqa_AnswerVEN.isRight && tzDataType.isBoolean(pobjqa_AnswerVEN.isRight) === false)
{
 throw new Error("(errid:Watl000060)字段[是否正确(isRight)]的值:[$(pobjqa_AnswerVEN.isRight)], 非法，应该为布尔型(In 答疑回答历史V(qa_AnswerV))!(clsqa_AnswerVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjqa_AnswerVEN.parentId) == false && undefined !== pobjqa_AnswerVEN.parentId && tzDataType.isString(pobjqa_AnswerVEN.parentId) === false)
{
 throw new Error("(errid:Watl000060)字段[父节点Id(parentId)]的值:[$(pobjqa_AnswerVEN.parentId)], 非法，应该为字符型(In 答疑回答历史V(qa_AnswerV))!(clsqa_AnswerVBL:CheckPropertyNew)");
}
if (null != pobjqa_AnswerVEN.voteCount && undefined !== pobjqa_AnswerVEN.voteCount && tzDataType.isNumber(pobjqa_AnswerVEN.voteCount) === false)
{
 throw new Error("(errid:Watl000060)字段[点赞计数(voteCount)]的值:[$(pobjqa_AnswerVEN.voteCount)], 非法，应该为数值型(In 答疑回答历史V(qa_AnswerV))!(clsqa_AnswerVBL:CheckPropertyNew)");
}
if (null != pobjqa_AnswerVEN.isRecommend && undefined !== pobjqa_AnswerVEN.isRecommend && tzDataType.isBoolean(pobjqa_AnswerVEN.isRecommend) === false)
{
 throw new Error("(errid:Watl000060)字段[是否推荐(isRecommend)]的值:[$(pobjqa_AnswerVEN.isRecommend)], 非法，应该为布尔型(In 答疑回答历史V(qa_AnswerV))!(clsqa_AnswerVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjqa_AnswerVEN.topicId) == false && undefined !== pobjqa_AnswerVEN.topicId && tzDataType.isString(pobjqa_AnswerVEN.topicId) === false)
{
 throw new Error("(errid:Watl000060)字段[主题Id(topicId)]的值:[$(pobjqa_AnswerVEN.topicId)], 非法，应该为字符型(In 答疑回答历史V(qa_AnswerV))!(clsqa_AnswerVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjqa_AnswerVEN.answerTypeId) == false && undefined !== pobjqa_AnswerVEN.answerTypeId && tzDataType.isString(pobjqa_AnswerVEN.answerTypeId) === false)
{
 throw new Error("(errid:Watl000060)字段[答案类型ID(answerTypeId)]的值:[$(pobjqa_AnswerVEN.answerTypeId)], 非法，应该为字符型(In 答疑回答历史V(qa_AnswerV))!(clsqa_AnswerVBL:CheckPropertyNew)");
}
if (null != pobjqa_AnswerVEN.isSubmit && undefined !== pobjqa_AnswerVEN.isSubmit && tzDataType.isBoolean(pobjqa_AnswerVEN.isSubmit) === false)
{
 throw new Error("(errid:Watl000060)字段[是否提交(isSubmit)]的值:[$(pobjqa_AnswerVEN.isSubmit)], 非法，应该为布尔型(In 答疑回答历史V(qa_AnswerV))!(clsqa_AnswerVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjqa_AnswerVEN.updUser) == false && undefined !== pobjqa_AnswerVEN.updUser && tzDataType.isString(pobjqa_AnswerVEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjqa_AnswerVEN.updUser)], 非法，应该为字符型(In 答疑回答历史V(qa_AnswerV))!(clsqa_AnswerVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjqa_AnswerVEN.updDate) == false && undefined !== pobjqa_AnswerVEN.updDate && tzDataType.isString(pobjqa_AnswerVEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjqa_AnswerVEN.updDate)], 非法，应该为字符型(In 答疑回答历史V(qa_AnswerV))!(clsqa_AnswerVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjqa_AnswerVEN.memo) == false && undefined !== pobjqa_AnswerVEN.memo && tzDataType.isString(pobjqa_AnswerVEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjqa_AnswerVEN.memo)], 非法，应该为字符型(In 答疑回答历史V(qa_AnswerV))!(clsqa_AnswerVBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjqa_AnswerVEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function qa_AnswerV_CheckProperty4Update (pobjqa_AnswerVEN: clsqa_AnswerVEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjqa_AnswerVEN.answerId) == false && GetStrLen(pobjqa_AnswerVEN.answerId) > 10)
{
 throw new Error("(errid:Watl000062)字段[回答Id(answerId)]的长度不能超过10(In 答疑回答历史V(qa_AnswerV))!值:$(pobjqa_AnswerVEN.answerId)(clsqa_AnswerVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjqa_AnswerVEN.questionsId) == false && GetStrLen(pobjqa_AnswerVEN.questionsId) > 8)
{
 throw new Error("(errid:Watl000062)字段[提问Id(questionsId)]的长度不能超过8(In 答疑回答历史V(qa_AnswerV))!值:$(pobjqa_AnswerVEN.questionsId)(clsqa_AnswerVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjqa_AnswerVEN.scoreType) == false && GetStrLen(pobjqa_AnswerVEN.scoreType) > 1)
{
 throw new Error("(errid:Watl000062)字段[评分类型(scoreType)]的长度不能超过1(In 答疑回答历史V(qa_AnswerV))!值:$(pobjqa_AnswerVEN.scoreType)(clsqa_AnswerVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjqa_AnswerVEN.parentId) == false && GetStrLen(pobjqa_AnswerVEN.parentId) > 10)
{
 throw new Error("(errid:Watl000062)字段[父节点Id(parentId)]的长度不能超过10(In 答疑回答历史V(qa_AnswerV))!值:$(pobjqa_AnswerVEN.parentId)(clsqa_AnswerVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjqa_AnswerVEN.topicId) == false && GetStrLen(pobjqa_AnswerVEN.topicId) > 8)
{
 throw new Error("(errid:Watl000062)字段[主题Id(topicId)]的长度不能超过8(In 答疑回答历史V(qa_AnswerV))!值:$(pobjqa_AnswerVEN.topicId)(clsqa_AnswerVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjqa_AnswerVEN.answerTypeId) == false && GetStrLen(pobjqa_AnswerVEN.answerTypeId) > 2)
{
 throw new Error("(errid:Watl000062)字段[答案类型ID(answerTypeId)]的长度不能超过2(In 答疑回答历史V(qa_AnswerV))!值:$(pobjqa_AnswerVEN.answerTypeId)(clsqa_AnswerVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjqa_AnswerVEN.updUser) == false && GetStrLen(pobjqa_AnswerVEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 答疑回答历史V(qa_AnswerV))!值:$(pobjqa_AnswerVEN.updUser)(clsqa_AnswerVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjqa_AnswerVEN.updDate) == false && GetStrLen(pobjqa_AnswerVEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 答疑回答历史V(qa_AnswerV))!值:$(pobjqa_AnswerVEN.updDate)(clsqa_AnswerVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjqa_AnswerVEN.memo) == false && GetStrLen(pobjqa_AnswerVEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 答疑回答历史V(qa_AnswerV))!值:$(pobjqa_AnswerVEN.memo)(clsqa_AnswerVBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null != pobjqa_AnswerVEN.answerVId && undefined !== pobjqa_AnswerVEN.answerVId && tzDataType.isNumber(pobjqa_AnswerVEN.answerVId) === false)
{
 throw new Error("(errid:Watl000063)字段[问答历史主键(answerVId)]的值:[$(pobjqa_AnswerVEN.answerVId)], 非法，应该为数值型(In 答疑回答历史V(qa_AnswerV))!(clsqa_AnswerVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjqa_AnswerVEN.answerId) == false && undefined !== pobjqa_AnswerVEN.answerId && tzDataType.isString(pobjqa_AnswerVEN.answerId) === false)
{
 throw new Error("(errid:Watl000063)字段[回答Id(answerId)]的值:[$(pobjqa_AnswerVEN.answerId)], 非法，应该为字符型(In 答疑回答历史V(qa_AnswerV))!(clsqa_AnswerVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjqa_AnswerVEN.questionsId) == false && undefined !== pobjqa_AnswerVEN.questionsId && tzDataType.isString(pobjqa_AnswerVEN.questionsId) === false)
{
 throw new Error("(errid:Watl000063)字段[提问Id(questionsId)]的值:[$(pobjqa_AnswerVEN.questionsId)], 非法，应该为字符型(In 答疑回答历史V(qa_AnswerV))!(clsqa_AnswerVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjqa_AnswerVEN.answerContent) == false && undefined !== pobjqa_AnswerVEN.answerContent && tzDataType.isString(pobjqa_AnswerVEN.answerContent) === false)
{
 throw new Error("(errid:Watl000063)字段[答案内容(answerContent)]的值:[$(pobjqa_AnswerVEN.answerContent)], 非法，应该为字符型(In 答疑回答历史V(qa_AnswerV))!(clsqa_AnswerVBL:CheckProperty4Update)");
}
if (null != pobjqa_AnswerVEN.score && undefined !== pobjqa_AnswerVEN.score && tzDataType.isNumber(pobjqa_AnswerVEN.score) === false)
{
 throw new Error("(errid:Watl000063)字段[评分(score)]的值:[$(pobjqa_AnswerVEN.score)], 非法，应该为数值型(In 答疑回答历史V(qa_AnswerV))!(clsqa_AnswerVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjqa_AnswerVEN.scoreType) == false && undefined !== pobjqa_AnswerVEN.scoreType && tzDataType.isString(pobjqa_AnswerVEN.scoreType) === false)
{
 throw new Error("(errid:Watl000063)字段[评分类型(scoreType)]的值:[$(pobjqa_AnswerVEN.scoreType)], 非法，应该为字符型(In 答疑回答历史V(qa_AnswerV))!(clsqa_AnswerVBL:CheckProperty4Update)");
}
if (null != pobjqa_AnswerVEN.isRight && undefined !== pobjqa_AnswerVEN.isRight && tzDataType.isBoolean(pobjqa_AnswerVEN.isRight) === false)
{
 throw new Error("(errid:Watl000063)字段[是否正确(isRight)]的值:[$(pobjqa_AnswerVEN.isRight)], 非法，应该为布尔型(In 答疑回答历史V(qa_AnswerV))!(clsqa_AnswerVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjqa_AnswerVEN.parentId) == false && undefined !== pobjqa_AnswerVEN.parentId && tzDataType.isString(pobjqa_AnswerVEN.parentId) === false)
{
 throw new Error("(errid:Watl000063)字段[父节点Id(parentId)]的值:[$(pobjqa_AnswerVEN.parentId)], 非法，应该为字符型(In 答疑回答历史V(qa_AnswerV))!(clsqa_AnswerVBL:CheckProperty4Update)");
}
if (null != pobjqa_AnswerVEN.voteCount && undefined !== pobjqa_AnswerVEN.voteCount && tzDataType.isNumber(pobjqa_AnswerVEN.voteCount) === false)
{
 throw new Error("(errid:Watl000063)字段[点赞计数(voteCount)]的值:[$(pobjqa_AnswerVEN.voteCount)], 非法，应该为数值型(In 答疑回答历史V(qa_AnswerV))!(clsqa_AnswerVBL:CheckProperty4Update)");
}
if (null != pobjqa_AnswerVEN.isRecommend && undefined !== pobjqa_AnswerVEN.isRecommend && tzDataType.isBoolean(pobjqa_AnswerVEN.isRecommend) === false)
{
 throw new Error("(errid:Watl000063)字段[是否推荐(isRecommend)]的值:[$(pobjqa_AnswerVEN.isRecommend)], 非法，应该为布尔型(In 答疑回答历史V(qa_AnswerV))!(clsqa_AnswerVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjqa_AnswerVEN.topicId) == false && undefined !== pobjqa_AnswerVEN.topicId && tzDataType.isString(pobjqa_AnswerVEN.topicId) === false)
{
 throw new Error("(errid:Watl000063)字段[主题Id(topicId)]的值:[$(pobjqa_AnswerVEN.topicId)], 非法，应该为字符型(In 答疑回答历史V(qa_AnswerV))!(clsqa_AnswerVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjqa_AnswerVEN.answerTypeId) == false && undefined !== pobjqa_AnswerVEN.answerTypeId && tzDataType.isString(pobjqa_AnswerVEN.answerTypeId) === false)
{
 throw new Error("(errid:Watl000063)字段[答案类型ID(answerTypeId)]的值:[$(pobjqa_AnswerVEN.answerTypeId)], 非法，应该为字符型(In 答疑回答历史V(qa_AnswerV))!(clsqa_AnswerVBL:CheckProperty4Update)");
}
if (null != pobjqa_AnswerVEN.isSubmit && undefined !== pobjqa_AnswerVEN.isSubmit && tzDataType.isBoolean(pobjqa_AnswerVEN.isSubmit) === false)
{
 throw new Error("(errid:Watl000063)字段[是否提交(isSubmit)]的值:[$(pobjqa_AnswerVEN.isSubmit)], 非法，应该为布尔型(In 答疑回答历史V(qa_AnswerV))!(clsqa_AnswerVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjqa_AnswerVEN.updUser) == false && undefined !== pobjqa_AnswerVEN.updUser && tzDataType.isString(pobjqa_AnswerVEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjqa_AnswerVEN.updUser)], 非法，应该为字符型(In 答疑回答历史V(qa_AnswerV))!(clsqa_AnswerVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjqa_AnswerVEN.updDate) == false && undefined !== pobjqa_AnswerVEN.updDate && tzDataType.isString(pobjqa_AnswerVEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjqa_AnswerVEN.updDate)], 非法，应该为字符型(In 答疑回答历史V(qa_AnswerV))!(clsqa_AnswerVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjqa_AnswerVEN.memo) == false && undefined !== pobjqa_AnswerVEN.memo && tzDataType.isString(pobjqa_AnswerVEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjqa_AnswerVEN.memo)], 非法，应该为字符型(In 答疑回答历史V(qa_AnswerV))!(clsqa_AnswerVBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjqa_AnswerVEN.answerVId 
 || pobjqa_AnswerVEN.answerVId != null && pobjqa_AnswerVEN.answerVId.toString()  ===  "")
{
 throw new Error("(errid:Watl000064)字段[问答历史主键]不能为空(In 答疑回答历史V)!(clsqa_AnswerVBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjqa_AnswerVEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function qa_AnswerV_GetJSONStrByObj (pobjqa_AnswerVEN: clsqa_AnswerVEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjqa_AnswerVEN.sf_UpdFldSetStr = pobjqa_AnswerVEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjqa_AnswerVEN);
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
export function qa_AnswerV_GetObjLstByJSONStr (strJSON: string): Array<clsqa_AnswerVEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrqa_AnswerVObjLst = new Array<clsqa_AnswerVEN>();
if (strJSON === "")
{
return arrqa_AnswerVObjLst;
}
try
{
arrqa_AnswerVObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrqa_AnswerVObjLst;
}
return arrqa_AnswerVObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrqa_AnswerVObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function qa_AnswerV_GetObjLstByJSONObjLst (arrqa_AnswerVObjLstS: Array<clsqa_AnswerVEN>): Array<clsqa_AnswerVEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrqa_AnswerVObjLst = new Array<clsqa_AnswerVEN>();
for (const objInFor of arrqa_AnswerVObjLstS) {
const obj1 = qa_AnswerV_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrqa_AnswerVObjLst.push(obj1);
}
return arrqa_AnswerVObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function qa_AnswerV_GetObjByJSONStr (strJSON: string): clsqa_AnswerVEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjqa_AnswerVEN = new clsqa_AnswerVEN();
if (strJSON === "")
{
return pobjqa_AnswerVEN;
}
try
{
pobjqa_AnswerVEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjqa_AnswerVEN;
}
return pobjqa_AnswerVEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function qa_AnswerV_GetCombineCondition(objqa_AnswerV_Cond: clsqa_AnswerVEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objqa_AnswerV_Cond.dicFldComparisonOp, clsqa_AnswerVEN.con_AnswerVId) == true)
{
const strComparisonOp_AnswerVId:string = objqa_AnswerV_Cond.dicFldComparisonOp[clsqa_AnswerVEN.con_AnswerVId];
strWhereCond += Format(" And {0} {2} {1}", clsqa_AnswerVEN.con_AnswerVId, objqa_AnswerV_Cond.answerVId, strComparisonOp_AnswerVId);
}
if (Object.prototype.hasOwnProperty.call(objqa_AnswerV_Cond.dicFldComparisonOp, clsqa_AnswerVEN.con_AnswerId) == true)
{
const strComparisonOp_AnswerId:string = objqa_AnswerV_Cond.dicFldComparisonOp[clsqa_AnswerVEN.con_AnswerId];
strWhereCond += Format(" And {0} {2} '{1}'", clsqa_AnswerVEN.con_AnswerId, objqa_AnswerV_Cond.answerId, strComparisonOp_AnswerId);
}
if (Object.prototype.hasOwnProperty.call(objqa_AnswerV_Cond.dicFldComparisonOp, clsqa_AnswerVEN.con_QuestionsId) == true)
{
const strComparisonOp_QuestionsId:string = objqa_AnswerV_Cond.dicFldComparisonOp[clsqa_AnswerVEN.con_QuestionsId];
strWhereCond += Format(" And {0} {2} '{1}'", clsqa_AnswerVEN.con_QuestionsId, objqa_AnswerV_Cond.questionsId, strComparisonOp_QuestionsId);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objqa_AnswerV_Cond.dicFldComparisonOp, clsqa_AnswerVEN.con_score) == true)
{
const strComparisonOp_score:string = objqa_AnswerV_Cond.dicFldComparisonOp[clsqa_AnswerVEN.con_score];
strWhereCond += Format(" And {0} {2} {1}", clsqa_AnswerVEN.con_score, objqa_AnswerV_Cond.score, strComparisonOp_score);
}
if (Object.prototype.hasOwnProperty.call(objqa_AnswerV_Cond.dicFldComparisonOp, clsqa_AnswerVEN.con_ScoreType) == true)
{
const strComparisonOp_ScoreType:string = objqa_AnswerV_Cond.dicFldComparisonOp[clsqa_AnswerVEN.con_ScoreType];
strWhereCond += Format(" And {0} {2} '{1}'", clsqa_AnswerVEN.con_ScoreType, objqa_AnswerV_Cond.scoreType, strComparisonOp_ScoreType);
}
if (Object.prototype.hasOwnProperty.call(objqa_AnswerV_Cond.dicFldComparisonOp, clsqa_AnswerVEN.con_IsRight) == true)
{
if (objqa_AnswerV_Cond.isRight == true)
{
strWhereCond += Format(" And {0} = '1'", clsqa_AnswerVEN.con_IsRight);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsqa_AnswerVEN.con_IsRight);
}
}
if (Object.prototype.hasOwnProperty.call(objqa_AnswerV_Cond.dicFldComparisonOp, clsqa_AnswerVEN.con_ParentId) == true)
{
const strComparisonOp_ParentId:string = objqa_AnswerV_Cond.dicFldComparisonOp[clsqa_AnswerVEN.con_ParentId];
strWhereCond += Format(" And {0} {2} '{1}'", clsqa_AnswerVEN.con_ParentId, objqa_AnswerV_Cond.parentId, strComparisonOp_ParentId);
}
if (Object.prototype.hasOwnProperty.call(objqa_AnswerV_Cond.dicFldComparisonOp, clsqa_AnswerVEN.con_VoteCount) == true)
{
const strComparisonOp_VoteCount:string = objqa_AnswerV_Cond.dicFldComparisonOp[clsqa_AnswerVEN.con_VoteCount];
strWhereCond += Format(" And {0} {2} {1}", clsqa_AnswerVEN.con_VoteCount, objqa_AnswerV_Cond.voteCount, strComparisonOp_VoteCount);
}
if (Object.prototype.hasOwnProperty.call(objqa_AnswerV_Cond.dicFldComparisonOp, clsqa_AnswerVEN.con_IsRecommend) == true)
{
if (objqa_AnswerV_Cond.isRecommend == true)
{
strWhereCond += Format(" And {0} = '1'", clsqa_AnswerVEN.con_IsRecommend);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsqa_AnswerVEN.con_IsRecommend);
}
}
if (Object.prototype.hasOwnProperty.call(objqa_AnswerV_Cond.dicFldComparisonOp, clsqa_AnswerVEN.con_TopicId) == true)
{
const strComparisonOp_TopicId:string = objqa_AnswerV_Cond.dicFldComparisonOp[clsqa_AnswerVEN.con_TopicId];
strWhereCond += Format(" And {0} {2} '{1}'", clsqa_AnswerVEN.con_TopicId, objqa_AnswerV_Cond.topicId, strComparisonOp_TopicId);
}
if (Object.prototype.hasOwnProperty.call(objqa_AnswerV_Cond.dicFldComparisonOp, clsqa_AnswerVEN.con_AnswerTypeId) == true)
{
const strComparisonOp_AnswerTypeId:string = objqa_AnswerV_Cond.dicFldComparisonOp[clsqa_AnswerVEN.con_AnswerTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsqa_AnswerVEN.con_AnswerTypeId, objqa_AnswerV_Cond.answerTypeId, strComparisonOp_AnswerTypeId);
}
if (Object.prototype.hasOwnProperty.call(objqa_AnswerV_Cond.dicFldComparisonOp, clsqa_AnswerVEN.con_IsSubmit) == true)
{
if (objqa_AnswerV_Cond.isSubmit == true)
{
strWhereCond += Format(" And {0} = '1'", clsqa_AnswerVEN.con_IsSubmit);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsqa_AnswerVEN.con_IsSubmit);
}
}
if (Object.prototype.hasOwnProperty.call(objqa_AnswerV_Cond.dicFldComparisonOp, clsqa_AnswerVEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objqa_AnswerV_Cond.dicFldComparisonOp[clsqa_AnswerVEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsqa_AnswerVEN.con_UpdUser, objqa_AnswerV_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objqa_AnswerV_Cond.dicFldComparisonOp, clsqa_AnswerVEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objqa_AnswerV_Cond.dicFldComparisonOp[clsqa_AnswerVEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsqa_AnswerVEN.con_UpdDate, objqa_AnswerV_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objqa_AnswerV_Cond.dicFldComparisonOp, clsqa_AnswerVEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objqa_AnswerV_Cond.dicFldComparisonOp[clsqa_AnswerVEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsqa_AnswerVEN.con_Memo, objqa_AnswerV_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--qa_AnswerV(答疑回答历史V),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param lngAnswerVId: 问答历史主键(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function qa_AnswerV_GetUniCondStr_AnswerVId(objqa_AnswerVEN: clsqa_AnswerVEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and AnswerVId = '{0}'", objqa_AnswerVEN.answerVId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--qa_AnswerV(答疑回答历史V),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param lngAnswerVId: 问答历史主键(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function qa_AnswerV_GetUniCondStr4Update_AnswerVId(objqa_AnswerVEN: clsqa_AnswerVEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and AnswerVId <> '{0}'", objqa_AnswerVEN.answerVId);
 strWhereCond +=  Format(" and AnswerVId = '{0}'", objqa_AnswerVEN.answerVId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objqa_AnswerVENS:源对象
 * @param objqa_AnswerVENT:目标对象
*/
export function qa_AnswerV_CopyObjTo(objqa_AnswerVENS: clsqa_AnswerVEN , objqa_AnswerVENT: clsqa_AnswerVEN ): void 
{
objqa_AnswerVENT.answerVId = objqa_AnswerVENS.answerVId; //问答历史主键
objqa_AnswerVENT.answerId = objqa_AnswerVENS.answerId; //回答Id
objqa_AnswerVENT.questionsId = objqa_AnswerVENS.questionsId; //提问Id
objqa_AnswerVENT.answerContent = objqa_AnswerVENS.answerContent; //答案内容
objqa_AnswerVENT.score = objqa_AnswerVENS.score; //评分
objqa_AnswerVENT.scoreType = objqa_AnswerVENS.scoreType; //评分类型
objqa_AnswerVENT.isRight = objqa_AnswerVENS.isRight; //是否正确
objqa_AnswerVENT.parentId = objqa_AnswerVENS.parentId; //父节点Id
objqa_AnswerVENT.voteCount = objqa_AnswerVENS.voteCount; //点赞计数
objqa_AnswerVENT.isRecommend = objqa_AnswerVENS.isRecommend; //是否推荐
objqa_AnswerVENT.topicId = objqa_AnswerVENS.topicId; //主题Id
objqa_AnswerVENT.answerTypeId = objqa_AnswerVENS.answerTypeId; //答案类型ID
objqa_AnswerVENT.isSubmit = objqa_AnswerVENS.isSubmit; //是否提交
objqa_AnswerVENT.updUser = objqa_AnswerVENS.updUser; //修改人
objqa_AnswerVENT.updDate = objqa_AnswerVENS.updDate; //修改日期
objqa_AnswerVENT.memo = objqa_AnswerVENS.memo; //备注
objqa_AnswerVENT.sf_UpdFldSetStr = objqa_AnswerVENS.updFldString; //sf_UpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objqa_AnswerVENS:源对象
 * @param objqa_AnswerVENT:目标对象
*/
export function qa_AnswerV_GetObjFromJsonObj(objqa_AnswerVENS: clsqa_AnswerVEN): clsqa_AnswerVEN 
{
 const objqa_AnswerVENT: clsqa_AnswerVEN = new clsqa_AnswerVEN();
ObjectAssign(objqa_AnswerVENT, objqa_AnswerVENS);
 return objqa_AnswerVENT;
}