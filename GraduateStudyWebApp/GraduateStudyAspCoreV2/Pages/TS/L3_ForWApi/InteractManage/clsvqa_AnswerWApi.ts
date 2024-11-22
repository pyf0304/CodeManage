
 /**
 * 类名:clsvqa_AnswerWApi
 * 表名:vqa_Answer(01120635)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:45:06
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
 * v答疑回答(vqa_Answer)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2023年03月13日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { enumComparisonOp } from "../../PubFun/enumComparisonOp.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { clsvqa_AnswerEN } from "../../L0_Entity/InteractManage/clsvqa_AnswerEN.js";
import { BindDdl_ObjLstInDiv_V, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const vqa_Answer_Controller = "vqa_AnswerApi";
 export const vqa_Answer_ConstructorName = "vqa_Answer";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strAnswerId:关键字
 * @returns 对象
 **/
export async function vqa_Answer_GetObjByAnswerIdAsync(strAnswerId: string): Promise<clsvqa_AnswerEN|null>  
{
const strThisFuncName = "GetObjByAnswerIdAsync";

if (IsNullOrEmpty(strAnswerId) == true)
{
  const strMsg = Format("参数:[strAnswerId]不能为空！(In clsvqa_AnswerWApi.GetObjByAnswerIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strAnswerId.length != 10)
{
const strMsg = Format("缓存分类变量:[strAnswerId]的长度:[{0}]不正确！(clsvqa_AnswerWApi.GetObjByAnswerIdAsync)", strAnswerId.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByAnswerId";
const strUrl = GetWebApiUrl(vqa_Answer_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strAnswerId": strAnswerId,
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
const objvqa_Answer = vqa_Answer_GetObjFromJsonObj(returnObj);
return objvqa_Answer;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vqa_Answer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vqa_Answer_ConstructorName, strThisFuncName);
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
 * @param strAnswerId:所给的关键字
 * @returns 对象
*/
export async function vqa_Answer_GetObjByAnswerId_Cache(strAnswerId:string,strTopicId:string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByAnswerId_Cache";

if (IsNullOrEmpty(strAnswerId) == true)
{
  const strMsg = Format("参数:[strAnswerId]不能为空！(In clsvqa_AnswerWApi.GetObjByAnswerId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strAnswerId.length != 10)
{
const strMsg = Format("缓存分类变量:[strAnswerId]的长度:[{0}]不正确！(clsvqa_AnswerWApi.GetObjByAnswerId_Cache)", strAnswerId.length);
console.error(strMsg);
throw (strMsg);
}
const arrvqa_AnswerObjLst_Cache = await vqa_Answer_GetObjLst_Cache(strTopicId);
try
{
const arrvqa_Answer_Sel: Array <clsvqa_AnswerEN> = arrvqa_AnswerObjLst_Cache.filter(x => 
 x.answerId == strAnswerId );
let objvqa_Answer: clsvqa_AnswerEN;
if (arrvqa_Answer_Sel.length > 0)
{
objvqa_Answer = arrvqa_Answer_Sel[0];
return objvqa_Answer;
}
else
{
if (bolTryAsyncOnce == true)
{
const objvqa_Answer_Const = await vqa_Answer_GetObjByAnswerIdAsync(strAnswerId);
if (objvqa_Answer_Const != null)
{
vqa_Answer_ReFreshThisCache(strTopicId);
return objvqa_Answer_Const;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strAnswerId, vqa_Answer_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param strAnswerId:所给的关键字
 * @returns 对象
*/
export async function vqa_Answer_GetObjByAnswerId_localStorage(strAnswerId: string) {
const strThisFuncName = "GetObjByAnswerId_localStorage";

if (IsNullOrEmpty(strAnswerId) == true)
{
  const strMsg = Format("参数:[strAnswerId]不能为空！(In clsvqa_AnswerWApi.GetObjByAnswerId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
if (strAnswerId.length != 10)
{
const strMsg = Format("缓存分类变量:[strAnswerId]的长度:[{0}]不正确！(clsvqa_AnswerWApi.GetObjByAnswerId_localStorage)", strAnswerId.length);
console.error(strMsg);
throw (strMsg);
}
const strKey = Format("{0}_{1}", clsvqa_AnswerEN._CurrTabName, strAnswerId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objvqa_Answer_Cache: clsvqa_AnswerEN = JSON.parse(strTempObj);
return objvqa_Answer_Cache;
}
try
{
const objvqa_Answer = await vqa_Answer_GetObjByAnswerIdAsync(strAnswerId);
if (objvqa_Answer != null)
{
localStorage.setItem(strKey, JSON.stringify(objvqa_Answer));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objvqa_Answer;
}
return objvqa_Answer;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strAnswerId, vqa_Answer_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
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
 @param strTopicId:缓存的分类字段
 * @returns 返回一个输出字段值
*/
export async function vqa_Answer_func(strInFldName:string , strOutFldName:string , strInValue:string 
, strTopicId_C: string)
{
//const strThisFuncName = "func";

if (IsNullOrEmpty(strTopicId_C) == true)
{
  const strMsg = Format("参数:[strTopicId_C]不能为空！(In clsvqa_AnswerWApi.func)");
console.error(strMsg);
 throw (strMsg);
}
if (strTopicId_C.length != 8)
{
const strMsg = Format("缓存分类变量:[strTopicId_C]的长度:[{0}]不正确！(clsvqa_AnswerWApi.func)", strTopicId_C.length);
console.error(strMsg);
throw (strMsg);
}

if (strInFldName != clsvqa_AnswerEN.con_AnswerId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsvqa_AnswerEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strOutFldName, clsvqa_AnswerEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strAnswerId = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objvqa_Answer = await vqa_Answer_GetObjByAnswerId_Cache(strAnswerId , strTopicId_C);
if (objvqa_Answer == null) return "";
if (objvqa_Answer.GetFldValue(strOutFldName) == null) return "";
return objvqa_Answer.GetFldValue(strOutFldName).toString();
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
export function vqa_Answer_SortFun_Defa(a:clsvqa_AnswerEN , b:clsvqa_AnswerEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.answerId.localeCompare(b.answerId);
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
export function vqa_Answer_SortFun_Defa_2Fld(a:clsvqa_AnswerEN , b:clsvqa_AnswerEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.questionsId == b.questionsId) return a.answerContent.localeCompare(b.answerContent);
else return a.questionsId.localeCompare(b.questionsId);
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
export function vqa_Answer_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsvqa_AnswerEN.con_AnswerId:
return (a: clsvqa_AnswerEN, b: clsvqa_AnswerEN) => {
return a.answerId.localeCompare(b.answerId);
}
case clsvqa_AnswerEN.con_QuestionsId:
return (a: clsvqa_AnswerEN, b: clsvqa_AnswerEN) => {
return a.questionsId.localeCompare(b.questionsId);
}
case clsvqa_AnswerEN.con_AnswerContent:
return (a: clsvqa_AnswerEN, b: clsvqa_AnswerEN) => {
if (a.answerContent == null) return -1;
if (b.answerContent == null) return 1;
return a.answerContent.localeCompare(b.answerContent);
}
case clsvqa_AnswerEN.con_Score:
return (a: clsvqa_AnswerEN, b: clsvqa_AnswerEN) => {
return a.score-b.score;
}
case clsvqa_AnswerEN.con_ScoreType:
return (a: clsvqa_AnswerEN, b: clsvqa_AnswerEN) => {
if (a.scoreType == null) return -1;
if (b.scoreType == null) return 1;
return a.scoreType.localeCompare(b.scoreType);
}
case clsvqa_AnswerEN.con_IsRight:
return (a: clsvqa_AnswerEN, b: clsvqa_AnswerEN) => {
if (a.isRight == true) return 1;
else return -1
}
case clsvqa_AnswerEN.con_ParentId:
return (a: clsvqa_AnswerEN, b: clsvqa_AnswerEN) => {
if (a.parentId == null) return -1;
if (b.parentId == null) return 1;
return a.parentId.localeCompare(b.parentId);
}
case clsvqa_AnswerEN.con_VoteCount:
return (a: clsvqa_AnswerEN, b: clsvqa_AnswerEN) => {
return a.voteCount-b.voteCount;
}
case clsvqa_AnswerEN.con_UpdUser:
return (a: clsvqa_AnswerEN, b: clsvqa_AnswerEN) => {
if (a.updUser == null) return -1;
if (b.updUser == null) return 1;
return a.updUser.localeCompare(b.updUser);
}
case clsvqa_AnswerEN.con_UserName:
return (a: clsvqa_AnswerEN, b: clsvqa_AnswerEN) => {
if (a.userName == null) return -1;
if (b.userName == null) return 1;
return a.userName.localeCompare(b.userName);
}
case clsvqa_AnswerEN.con_UpdDate:
return (a: clsvqa_AnswerEN, b: clsvqa_AnswerEN) => {
if (a.updDate == null) return -1;
if (b.updDate == null) return 1;
return a.updDate.localeCompare(b.updDate);
}
case clsvqa_AnswerEN.con_Memo:
return (a: clsvqa_AnswerEN, b: clsvqa_AnswerEN) => {
if (a.memo == null) return -1;
if (b.memo == null) return 1;
return a.memo.localeCompare(b.memo);
}
case clsvqa_AnswerEN.con_qa_PaperId:
return (a: clsvqa_AnswerEN, b: clsvqa_AnswerEN) => {
if (a.qa_PaperId == null) return -1;
if (b.qa_PaperId == null) return 1;
return a.qa_PaperId.localeCompare(b.qa_PaperId);
}
case clsvqa_AnswerEN.con_QuestionsContent:
return (a: clsvqa_AnswerEN, b: clsvqa_AnswerEN) => {
if (a.questionsContent == null) return -1;
if (b.questionsContent == null) return 1;
return a.questionsContent.localeCompare(b.questionsContent);
}
case clsvqa_AnswerEN.con_PaperId:
return (a: clsvqa_AnswerEN, b: clsvqa_AnswerEN) => {
if (a.paperId == null) return -1;
if (b.paperId == null) return 1;
return a.paperId.localeCompare(b.paperId);
}
case clsvqa_AnswerEN.con_QuestionsTypeId:
return (a: clsvqa_AnswerEN, b: clsvqa_AnswerEN) => {
if (a.questionsTypeId == null) return -1;
if (b.questionsTypeId == null) return 1;
return a.questionsTypeId.localeCompare(b.questionsTypeId);
}
case clsvqa_AnswerEN.con_QuestionsTypeName:
return (a: clsvqa_AnswerEN, b: clsvqa_AnswerEN) => {
if (a.questionsTypeName == null) return -1;
if (b.questionsTypeName == null) return 1;
return a.questionsTypeName.localeCompare(b.questionsTypeName);
}
case clsvqa_AnswerEN.con_IsRecommend:
return (a: clsvqa_AnswerEN, b: clsvqa_AnswerEN) => {
if (a.isRecommend == true) return 1;
else return -1
}
case clsvqa_AnswerEN.con_TopicId:
return (a: clsvqa_AnswerEN, b: clsvqa_AnswerEN) => {
if (a.topicId == null) return -1;
if (b.topicId == null) return 1;
return a.topicId.localeCompare(b.topicId);
}
case clsvqa_AnswerEN.con_AnswerTypeId:
return (a: clsvqa_AnswerEN, b: clsvqa_AnswerEN) => {
if (a.answerTypeId == null) return -1;
if (b.answerTypeId == null) return 1;
return a.answerTypeId.localeCompare(b.answerTypeId);
}
case clsvqa_AnswerEN.con_IsSubmit:
return (a: clsvqa_AnswerEN, b: clsvqa_AnswerEN) => {
if (a.isSubmit == true) return 1;
else return -1
}
case clsvqa_AnswerEN.con_AnswerCount:
return (a: clsvqa_AnswerEN, b: clsvqa_AnswerEN) => {
return a.answerCount-b.answerCount;
}
case clsvqa_AnswerEN.con_PaperTitle:
return (a: clsvqa_AnswerEN, b: clsvqa_AnswerEN) => {
if (a.paperTitle == null) return -1;
if (b.paperTitle == null) return 1;
return a.paperTitle.localeCompare(b.paperTitle);
}
case clsvqa_AnswerEN.con_QuestUserName:
return (a: clsvqa_AnswerEN, b: clsvqa_AnswerEN) => {
if (a.questUserName == null) return -1;
if (b.questUserName == null) return 1;
return a.questUserName.localeCompare(b.questUserName);
}
case clsvqa_AnswerEN.con_AppraiseCount:
return (a: clsvqa_AnswerEN, b: clsvqa_AnswerEN) => {
return a.appraiseCount-b.appraiseCount;
}
case clsvqa_AnswerEN.con_StuScore:
return (a: clsvqa_AnswerEN, b: clsvqa_AnswerEN) => {
return a.stuScore-b.stuScore;
}
case clsvqa_AnswerEN.con_TeaScore:
return (a: clsvqa_AnswerEN, b: clsvqa_AnswerEN) => {
return a.teaScore-b.teaScore;
}
case clsvqa_AnswerEN.con_UserId:
return (a: clsvqa_AnswerEN, b: clsvqa_AnswerEN) => {
if (a.userId == null) return -1;
if (b.userId == null) return 1;
return a.userId.localeCompare(b.userId);
}
case clsvqa_AnswerEN.con_id_CurrEduCls:
return (a: clsvqa_AnswerEN, b: clsvqa_AnswerEN) => {
if (a.id_CurrEduCls == null) return -1;
if (b.id_CurrEduCls == null) return 1;
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vqa_Answer]中不存在！(in ${ vqa_Answer_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsvqa_AnswerEN.con_AnswerId:
return (a: clsvqa_AnswerEN, b: clsvqa_AnswerEN) => {
return b.answerId.localeCompare(a.answerId);
}
case clsvqa_AnswerEN.con_QuestionsId:
return (a: clsvqa_AnswerEN, b: clsvqa_AnswerEN) => {
return b.questionsId.localeCompare(a.questionsId);
}
case clsvqa_AnswerEN.con_AnswerContent:
return (a: clsvqa_AnswerEN, b: clsvqa_AnswerEN) => {
if (b.answerContent == null) return -1;
if (a.answerContent == null) return 1;
return b.answerContent.localeCompare(a.answerContent);
}
case clsvqa_AnswerEN.con_Score:
return (a: clsvqa_AnswerEN, b: clsvqa_AnswerEN) => {
return b.score-a.score;
}
case clsvqa_AnswerEN.con_ScoreType:
return (a: clsvqa_AnswerEN, b: clsvqa_AnswerEN) => {
if (b.scoreType == null) return -1;
if (a.scoreType == null) return 1;
return b.scoreType.localeCompare(a.scoreType);
}
case clsvqa_AnswerEN.con_IsRight:
return (a: clsvqa_AnswerEN, b: clsvqa_AnswerEN) => {
if (b.isRight == true) return 1;
else return -1
}
case clsvqa_AnswerEN.con_ParentId:
return (a: clsvqa_AnswerEN, b: clsvqa_AnswerEN) => {
if (b.parentId == null) return -1;
if (a.parentId == null) return 1;
return b.parentId.localeCompare(a.parentId);
}
case clsvqa_AnswerEN.con_VoteCount:
return (a: clsvqa_AnswerEN, b: clsvqa_AnswerEN) => {
return b.voteCount-a.voteCount;
}
case clsvqa_AnswerEN.con_UpdUser:
return (a: clsvqa_AnswerEN, b: clsvqa_AnswerEN) => {
if (b.updUser == null) return -1;
if (a.updUser == null) return 1;
return b.updUser.localeCompare(a.updUser);
}
case clsvqa_AnswerEN.con_UserName:
return (a: clsvqa_AnswerEN, b: clsvqa_AnswerEN) => {
if (b.userName == null) return -1;
if (a.userName == null) return 1;
return b.userName.localeCompare(a.userName);
}
case clsvqa_AnswerEN.con_UpdDate:
return (a: clsvqa_AnswerEN, b: clsvqa_AnswerEN) => {
if (b.updDate == null) return -1;
if (a.updDate == null) return 1;
return b.updDate.localeCompare(a.updDate);
}
case clsvqa_AnswerEN.con_Memo:
return (a: clsvqa_AnswerEN, b: clsvqa_AnswerEN) => {
if (b.memo == null) return -1;
if (a.memo == null) return 1;
return b.memo.localeCompare(a.memo);
}
case clsvqa_AnswerEN.con_qa_PaperId:
return (a: clsvqa_AnswerEN, b: clsvqa_AnswerEN) => {
if (b.qa_PaperId == null) return -1;
if (a.qa_PaperId == null) return 1;
return b.qa_PaperId.localeCompare(a.qa_PaperId);
}
case clsvqa_AnswerEN.con_QuestionsContent:
return (a: clsvqa_AnswerEN, b: clsvqa_AnswerEN) => {
if (b.questionsContent == null) return -1;
if (a.questionsContent == null) return 1;
return b.questionsContent.localeCompare(a.questionsContent);
}
case clsvqa_AnswerEN.con_PaperId:
return (a: clsvqa_AnswerEN, b: clsvqa_AnswerEN) => {
if (b.paperId == null) return -1;
if (a.paperId == null) return 1;
return b.paperId.localeCompare(a.paperId);
}
case clsvqa_AnswerEN.con_QuestionsTypeId:
return (a: clsvqa_AnswerEN, b: clsvqa_AnswerEN) => {
if (b.questionsTypeId == null) return -1;
if (a.questionsTypeId == null) return 1;
return b.questionsTypeId.localeCompare(a.questionsTypeId);
}
case clsvqa_AnswerEN.con_QuestionsTypeName:
return (a: clsvqa_AnswerEN, b: clsvqa_AnswerEN) => {
if (b.questionsTypeName == null) return -1;
if (a.questionsTypeName == null) return 1;
return b.questionsTypeName.localeCompare(a.questionsTypeName);
}
case clsvqa_AnswerEN.con_IsRecommend:
return (a: clsvqa_AnswerEN, b: clsvqa_AnswerEN) => {
if (b.isRecommend == true) return 1;
else return -1
}
case clsvqa_AnswerEN.con_TopicId:
return (a: clsvqa_AnswerEN, b: clsvqa_AnswerEN) => {
if (b.topicId == null) return -1;
if (a.topicId == null) return 1;
return b.topicId.localeCompare(a.topicId);
}
case clsvqa_AnswerEN.con_AnswerTypeId:
return (a: clsvqa_AnswerEN, b: clsvqa_AnswerEN) => {
if (b.answerTypeId == null) return -1;
if (a.answerTypeId == null) return 1;
return b.answerTypeId.localeCompare(a.answerTypeId);
}
case clsvqa_AnswerEN.con_IsSubmit:
return (a: clsvqa_AnswerEN, b: clsvqa_AnswerEN) => {
if (b.isSubmit == true) return 1;
else return -1
}
case clsvqa_AnswerEN.con_AnswerCount:
return (a: clsvqa_AnswerEN, b: clsvqa_AnswerEN) => {
return b.answerCount-a.answerCount;
}
case clsvqa_AnswerEN.con_PaperTitle:
return (a: clsvqa_AnswerEN, b: clsvqa_AnswerEN) => {
if (b.paperTitle == null) return -1;
if (a.paperTitle == null) return 1;
return b.paperTitle.localeCompare(a.paperTitle);
}
case clsvqa_AnswerEN.con_QuestUserName:
return (a: clsvqa_AnswerEN, b: clsvqa_AnswerEN) => {
if (b.questUserName == null) return -1;
if (a.questUserName == null) return 1;
return b.questUserName.localeCompare(a.questUserName);
}
case clsvqa_AnswerEN.con_AppraiseCount:
return (a: clsvqa_AnswerEN, b: clsvqa_AnswerEN) => {
return b.appraiseCount-a.appraiseCount;
}
case clsvqa_AnswerEN.con_StuScore:
return (a: clsvqa_AnswerEN, b: clsvqa_AnswerEN) => {
return b.stuScore-a.stuScore;
}
case clsvqa_AnswerEN.con_TeaScore:
return (a: clsvqa_AnswerEN, b: clsvqa_AnswerEN) => {
return b.teaScore-a.teaScore;
}
case clsvqa_AnswerEN.con_UserId:
return (a: clsvqa_AnswerEN, b: clsvqa_AnswerEN) => {
if (b.userId == null) return -1;
if (a.userId == null) return 1;
return b.userId.localeCompare(a.userId);
}
case clsvqa_AnswerEN.con_id_CurrEduCls:
return (a: clsvqa_AnswerEN, b: clsvqa_AnswerEN) => {
if (b.id_CurrEduCls == null) return -1;
if (a.id_CurrEduCls == null) return 1;
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vqa_Answer]中不存在！(in ${ vqa_Answer_ConstructorName}.${ strThisFuncName})`;
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
export async function vqa_Answer_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsvqa_AnswerEN.con_AnswerId:
return (obj: clsvqa_AnswerEN) => {
return obj.answerId === value;
}
case clsvqa_AnswerEN.con_QuestionsId:
return (obj: clsvqa_AnswerEN) => {
return obj.questionsId === value;
}
case clsvqa_AnswerEN.con_AnswerContent:
return (obj: clsvqa_AnswerEN) => {
return obj.answerContent === value;
}
case clsvqa_AnswerEN.con_Score:
return (obj: clsvqa_AnswerEN) => {
return obj.score === value;
}
case clsvqa_AnswerEN.con_ScoreType:
return (obj: clsvqa_AnswerEN) => {
return obj.scoreType === value;
}
case clsvqa_AnswerEN.con_IsRight:
return (obj: clsvqa_AnswerEN) => {
return obj.isRight === value;
}
case clsvqa_AnswerEN.con_ParentId:
return (obj: clsvqa_AnswerEN) => {
return obj.parentId === value;
}
case clsvqa_AnswerEN.con_VoteCount:
return (obj: clsvqa_AnswerEN) => {
return obj.voteCount === value;
}
case clsvqa_AnswerEN.con_UpdUser:
return (obj: clsvqa_AnswerEN) => {
return obj.updUser === value;
}
case clsvqa_AnswerEN.con_UserName:
return (obj: clsvqa_AnswerEN) => {
return obj.userName === value;
}
case clsvqa_AnswerEN.con_UpdDate:
return (obj: clsvqa_AnswerEN) => {
return obj.updDate === value;
}
case clsvqa_AnswerEN.con_Memo:
return (obj: clsvqa_AnswerEN) => {
return obj.memo === value;
}
case clsvqa_AnswerEN.con_qa_PaperId:
return (obj: clsvqa_AnswerEN) => {
return obj.qa_PaperId === value;
}
case clsvqa_AnswerEN.con_QuestionsContent:
return (obj: clsvqa_AnswerEN) => {
return obj.questionsContent === value;
}
case clsvqa_AnswerEN.con_PaperId:
return (obj: clsvqa_AnswerEN) => {
return obj.paperId === value;
}
case clsvqa_AnswerEN.con_QuestionsTypeId:
return (obj: clsvqa_AnswerEN) => {
return obj.questionsTypeId === value;
}
case clsvqa_AnswerEN.con_QuestionsTypeName:
return (obj: clsvqa_AnswerEN) => {
return obj.questionsTypeName === value;
}
case clsvqa_AnswerEN.con_IsRecommend:
return (obj: clsvqa_AnswerEN) => {
return obj.isRecommend === value;
}
case clsvqa_AnswerEN.con_TopicId:
return (obj: clsvqa_AnswerEN) => {
return obj.topicId === value;
}
case clsvqa_AnswerEN.con_AnswerTypeId:
return (obj: clsvqa_AnswerEN) => {
return obj.answerTypeId === value;
}
case clsvqa_AnswerEN.con_IsSubmit:
return (obj: clsvqa_AnswerEN) => {
return obj.isSubmit === value;
}
case clsvqa_AnswerEN.con_AnswerCount:
return (obj: clsvqa_AnswerEN) => {
return obj.answerCount === value;
}
case clsvqa_AnswerEN.con_PaperTitle:
return (obj: clsvqa_AnswerEN) => {
return obj.paperTitle === value;
}
case clsvqa_AnswerEN.con_QuestUserName:
return (obj: clsvqa_AnswerEN) => {
return obj.questUserName === value;
}
case clsvqa_AnswerEN.con_AppraiseCount:
return (obj: clsvqa_AnswerEN) => {
return obj.appraiseCount === value;
}
case clsvqa_AnswerEN.con_StuScore:
return (obj: clsvqa_AnswerEN) => {
return obj.stuScore === value;
}
case clsvqa_AnswerEN.con_TeaScore:
return (obj: clsvqa_AnswerEN) => {
return obj.teaScore === value;
}
case clsvqa_AnswerEN.con_UserId:
return (obj: clsvqa_AnswerEN) => {
return obj.userId === value;
}
case clsvqa_AnswerEN.con_id_CurrEduCls:
return (obj: clsvqa_AnswerEN) => {
return obj.id_CurrEduCls === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vqa_Answer]中不存在！(in ${ vqa_Answer_ConstructorName}.${ strThisFuncName})`;
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
 @param strTopicId:缓存的分类字段
 * @returns 返回一个关键字值列表
*/
export async function vqa_Answer_funcKey(strInFldName:string, strInValue: any, strComparisonOp:string, strTopicId_C: string): Promise<Array<string>>
{
//const strThisFuncName = "funcKey";

if (IsNullOrEmpty(strTopicId_C) == true)
{
  const strMsg = Format("参数:[strTopicId_C]不能为空！(In clsvqa_AnswerWApi.funcKey)");
console.error(strMsg);
 throw (strMsg);
}
if (strTopicId_C.length != 8)
{
const strMsg = Format("缓存分类变量:[strTopicId_C]的长度:[{0}]不正确！(clsvqa_AnswerWApi.funcKey)", strTopicId_C.length);
console.error(strMsg);
throw (strMsg);
}

if (strInFldName == clsvqa_AnswerEN.con_AnswerId)
{
const strMsg = Format("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (IsNullOrEmpty(strInValue) == true)
{
return [];
}
const arrvqa_Answer = await vqa_Answer_GetObjLst_Cache(strTopicId_C);
if (arrvqa_Answer == null) return [];
let arrvqa_Answer_Sel = arrvqa_Answer;
const strType = typeof(strInValue);
switch (strType)
{
case "string":
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01: // " = "
arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
break;
case enumComparisonOp.Like_03:
arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
break;
case enumComparisonOp.In_04:
const arrValues = strInValue.split(',');
arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
break;
}
break;
case "boolean":
if (strInValue == null) return [];
if (strComparisonOp == enumComparisonOp.Equal_01)
{
arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
}
break;
case "number":
if (Number(strInValue) == 0) return [];
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01:
arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
break;
case enumComparisonOp.NotEqual_02:
arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
break;
case enumComparisonOp.NotLessThan_05://" >= ":
arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
break;
case enumComparisonOp.NotGreaterThan_06://" <= ":
arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
case enumComparisonOp.GreaterThan_07://" > ":
arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
break;
case enumComparisonOp.LessThan_08://" < ":
arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
}
break;
}
if (arrvqa_Answer_Sel.length == 0) return [];
return arrvqa_Answer_Sel.map(x=>x.answerId);
}

 /**
 * 根据条件获取满足条件的第一条记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
 * @param strWhereCond:条件
 * @returns 返回的第一条记录的关键字值
 **/
export async function vqa_Answer_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vqa_Answer_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vqa_Answer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vqa_Answer_ConstructorName, strThisFuncName);
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
export async function vqa_Answer_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vqa_Answer_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vqa_Answer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vqa_Answer_ConstructorName, strThisFuncName);
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
export async function vqa_Answer_GetFirstObjAsync(strWhereCond: string): Promise<clsvqa_AnswerEN|null>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(vqa_Answer_Controller, strAction);
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
const objvqa_Answer = vqa_Answer_GetObjFromJsonObj(returnObj);
return objvqa_Answer;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vqa_Answer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vqa_Answer_ConstructorName, strThisFuncName);
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
export async function vqa_Answer_GetObjLst_ClientCache(strTopicId: string)
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
if (IsNullOrEmpty(clsvqa_AnswerEN.WhereFormat) == false)
{
strWhereCond = Format(clsvqa_AnswerEN.WhereFormat, strTopicId);
}
else
{
strWhereCond = Format("TopicId='{0}'", strTopicId);
}
const strKey = Format("{0}_{1}", clsvqa_AnswerEN._CurrTabName, strTopicId);
if (IsNullOrEmpty(clsvqa_AnswerEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvqa_AnswerEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrvqa_AnswerExObjLst_Cache: Array<clsvqa_AnswerEN> = CacheHelper.Get(strKey);
const arrvqa_AnswerObjLst_T = vqa_Answer_GetObjLstByJSONObjLst(arrvqa_AnswerExObjLst_Cache);
return arrvqa_AnswerObjLst_T;
}
try
{
const arrvqa_AnswerExObjLst = await vqa_Answer_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrvqa_AnswerExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvqa_AnswerExObjLst.length);
console.log(strInfo);
return arrvqa_AnswerExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vqa_Answer_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vqa_Answer_GetObjLst_localStorage(strTopicId: string)
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
if (IsNullOrEmpty(clsvqa_AnswerEN.WhereFormat) == false)
{
strWhereCond = Format(clsvqa_AnswerEN.WhereFormat, strTopicId);
}
else
{
strWhereCond = Format("TopicId='{0}'", strTopicId);
}
const strKey = Format("{0}_{1}", clsvqa_AnswerEN._CurrTabName, strTopicId);
if (IsNullOrEmpty(clsvqa_AnswerEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvqa_AnswerEN.CacheAddiCondition);
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
const arrvqa_AnswerExObjLst_Cache: Array<clsvqa_AnswerEN> = JSON.parse(strTempObjLst);
const arrvqa_AnswerObjLst_T = vqa_Answer_GetObjLstByJSONObjLst(arrvqa_AnswerExObjLst_Cache);
return arrvqa_AnswerObjLst_T;
}
try
{
const arrvqa_AnswerExObjLst = await vqa_Answer_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrvqa_AnswerExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvqa_AnswerExObjLst.length);
console.log(strInfo);
return arrvqa_AnswerExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vqa_Answer_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vqa_Answer_GetObjLst_localStorage_PureCache(strTopicId: string)
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("TopicId='{0}'", strTopicId);
const strKey = Format("{0}_{1}", clsvqa_AnswerEN._CurrTabName, strTopicId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrvqa_AnswerObjLst_Cache: Array<clsvqa_AnswerEN> = JSON.parse(strTempObjLst);
return arrvqa_AnswerObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function vqa_Answer_GetObjLstAsync(strWhereCond: string): Promise<Array<clsvqa_AnswerEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(vqa_Answer_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vqa_Answer_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vqa_Answer_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vqa_Answer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vqa_Answer_ConstructorName, strThisFuncName);
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
export async function vqa_Answer_GetObjLst_sessionStorage(strTopicId: string)
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
if (IsNullOrEmpty(clsvqa_AnswerEN.WhereFormat) == false)
{
strWhereCond = Format(clsvqa_AnswerEN.WhereFormat, strTopicId);
}
else
{
strWhereCond = Format("TopicId='{0}'", strTopicId);
}
const strKey = Format("{0}_{1}", clsvqa_AnswerEN._CurrTabName, strTopicId);
if (IsNullOrEmpty(clsvqa_AnswerEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvqa_AnswerEN.CacheAddiCondition);
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
const arrvqa_AnswerExObjLst_Cache: Array<clsvqa_AnswerEN> = JSON.parse(strTempObjLst);
const arrvqa_AnswerObjLst_T = vqa_Answer_GetObjLstByJSONObjLst(arrvqa_AnswerExObjLst_Cache);
return arrvqa_AnswerObjLst_T;
}
try
{
const arrvqa_AnswerExObjLst = await vqa_Answer_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrvqa_AnswerExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvqa_AnswerExObjLst.length);
console.log(strInfo);
return arrvqa_AnswerExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vqa_Answer_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vqa_Answer_GetObjLst_sessionStorage_PureCache(strTopicId: string)
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("TopicId='{0}'", strTopicId);
const strKey = Format("{0}_{1}", clsvqa_AnswerEN._CurrTabName, strTopicId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrvqa_AnswerObjLst_Cache: Array<clsvqa_AnswerEN> = JSON.parse(strTempObjLst);
return arrvqa_AnswerObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vqa_Answer_GetObjLst_Cache(strTopicId: string): Promise<Array<clsvqa_AnswerEN>>
{
//const strThisFuncName = "GetObjLst_Cache";

if (IsNullOrEmpty(strTopicId) == true)
{
const strMsg = Format("缓存分类变量:[TopicId]不能为空！(in clsvqa_AnswerWApi.vqa_Answer_GetObjLst_Cache() )");
console.error(strMsg);
throw (strMsg);
}
if (strTopicId.length != 8)
{
const strMsg = Format("缓存分类变量:[strTopicId]的长度:[{0}]不正确！(in clsvqa_AnswerWApi.vqa_Answer_GetObjLst_Cache() )", strTopicId.length);
console.error(strMsg);
throw (strMsg);
}
let arrvqa_AnswerObjLst_Cache;
switch (clsvqa_AnswerEN.CacheModeId)
{
case "04"://sessionStorage
arrvqa_AnswerObjLst_Cache = await vqa_Answer_GetObjLst_sessionStorage(strTopicId);
break;
case "03"://localStorage
arrvqa_AnswerObjLst_Cache = await vqa_Answer_GetObjLst_localStorage(strTopicId);
break;
case "02"://ClientCache
arrvqa_AnswerObjLst_Cache = await vqa_Answer_GetObjLst_ClientCache(strTopicId);
break;
default:
arrvqa_AnswerObjLst_Cache = await vqa_Answer_GetObjLst_ClientCache(strTopicId);
break;
}
const arrvqa_AnswerObjLst = vqa_Answer_GetObjLstByJSONObjLst(arrvqa_AnswerObjLst_Cache);
return arrvqa_AnswerObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vqa_Answer_GetObjLst_PureCache(strTopicId: string)
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrvqa_AnswerObjLst_Cache;
switch (clsvqa_AnswerEN.CacheModeId)
{
case "04"://sessionStorage
arrvqa_AnswerObjLst_Cache = await vqa_Answer_GetObjLst_sessionStorage_PureCache(strTopicId);
break;
case "03"://localStorage
arrvqa_AnswerObjLst_Cache = await vqa_Answer_GetObjLst_localStorage_PureCache(strTopicId);
break;
case "02"://ClientCache
arrvqa_AnswerObjLst_Cache = null;
break;
default:
arrvqa_AnswerObjLst_Cache = null;
break;
}
return arrvqa_AnswerObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrAnswerId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vqa_Answer_GetSubObjLst_Cache(objvqa_Answer_Cond: clsvqa_AnswerEN,strTopicId: string) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrvqa_AnswerObjLst_Cache = await vqa_Answer_GetObjLst_Cache(strTopicId);
let arrvqa_Answer_Sel: Array < clsvqa_AnswerEN > = arrvqa_AnswerObjLst_Cache;
if (objvqa_Answer_Cond.sf_FldComparisonOp == null || objvqa_Answer_Cond.sf_FldComparisonOp == "") return arrvqa_Answer_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvqa_Answer_Cond.sf_FldComparisonOp);
//console.log("clsvqa_AnswerWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvqa_Answer_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvqa_Answer_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvqa_Answer_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objvqa_Answer_Cond), vqa_Answer_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvqa_AnswerEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrAnswerId:关键字列表
 * @returns 对象列表
 **/
export async function vqa_Answer_GetObjLstByAnswerIdLstAsync(arrAnswerId: Array<string>): Promise<Array<clsvqa_AnswerEN>>  
{
const strThisFuncName = "GetObjLstByAnswerIdLstAsync";
const strAction = "GetObjLstByAnswerIdLst";
const strUrl = GetWebApiUrl(vqa_Answer_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrAnswerId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vqa_Answer_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vqa_Answer_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vqa_Answer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vqa_Answer_ConstructorName, strThisFuncName);
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
 * @param arrstrAnswerIdLst:关键字列表
 * @returns 对象列表
*/
export async function vqa_Answer_GetObjLstByAnswerIdLst_Cache(arrAnswerIdLst: Array<string>,strTopicId: string) {
const strThisFuncName = "GetObjLstByAnswerIdLst_Cache";
try
{
const arrvqa_AnswerObjLst_Cache = await vqa_Answer_GetObjLst_Cache(strTopicId);
const arrvqa_Answer_Sel: Array <clsvqa_AnswerEN> = arrvqa_AnswerObjLst_Cache.filter(x => arrAnswerIdLst.indexOf(x.answerId)>-1);
return arrvqa_Answer_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrAnswerIdLst.join(","), vqa_Answer_ConstructorName, strThisFuncName);
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
export async function vqa_Answer_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsvqa_AnswerEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(vqa_Answer_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vqa_Answer_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vqa_Answer_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vqa_Answer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vqa_Answer_ConstructorName, strThisFuncName);
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
export async function vqa_Answer_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsvqa_AnswerEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vqa_Answer_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vqa_Answer_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vqa_Answer_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vqa_Answer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vqa_Answer_ConstructorName, strThisFuncName);
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
export async function vqa_Answer_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vqa_Answer_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vqa_Answer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vqa_Answer_ConstructorName, strThisFuncName);
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
export async function vqa_Answer_GetObjLstByPager_Cache(objPagerPara: stuPagerPara,strTopicId: string) {
const strThisFuncName = "GetObjLstByPager_Cache";
if (objPagerPara.pageIndex == 0) return new Array<clsvqa_AnswerEN>();
const arrvqa_AnswerObjLst_Cache = await vqa_Answer_GetObjLst_Cache(strTopicId);
if (arrvqa_AnswerObjLst_Cache.length == 0) return arrvqa_AnswerObjLst_Cache;
let arrvqa_Answer_Sel = arrvqa_AnswerObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objvqa_Answer_Cond = new clsvqa_AnswerEN();
ObjectAssign(objvqa_Answer_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsvqa_AnswerWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvqa_Answer_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvqa_Answer_Sel.length == 0) return arrvqa_Answer_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrvqa_Answer_Sel = arrvqa_Answer_Sel.sort(vqa_Answer_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrvqa_Answer_Sel = arrvqa_Answer_Sel.sort(objPagerPara.sortFun);
}
arrvqa_Answer_Sel = arrvqa_Answer_Sel.slice(intStart, intEnd);     
return arrvqa_Answer_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, vqa_Answer_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvqa_AnswerEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function vqa_Answer_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsvqa_AnswerEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
if (objPagerPara.pageIndex == 0) return new Array<clsvqa_AnswerEN>();
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(vqa_Answer_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vqa_Answer_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vqa_Answer_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vqa_Answer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vqa_Answer_ConstructorName, strThisFuncName);
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
 * @param objstrAnswerId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vqa_Answer_IsExistRecord_Cache(objvqa_Answer_Cond: clsvqa_AnswerEN,strTopicId: string) {
const strThisFuncName = "IsExistRecord_Cache";
const arrvqa_AnswerObjLst_Cache = await vqa_Answer_GetObjLst_Cache(strTopicId);
if (arrvqa_AnswerObjLst_Cache == null) return false;
let arrvqa_Answer_Sel: Array < clsvqa_AnswerEN > = arrvqa_AnswerObjLst_Cache;
if (objvqa_Answer_Cond.sf_FldComparisonOp == null || objvqa_Answer_Cond.sf_FldComparisonOp == "") return arrvqa_Answer_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvqa_Answer_Cond.sf_FldComparisonOp);
//console.log("clsvqa_AnswerWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvqa_Answer_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvqa_Answer_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvqa_Answer_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objvqa_Answer_Cond), vqa_Answer_ConstructorName, strThisFuncName);
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
export async function vqa_Answer_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(vqa_Answer_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vqa_Answer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vqa_Answer_ConstructorName, strThisFuncName);
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
 * @param strAnswerId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function vqa_Answer_IsExist(strAnswerId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vqa_Answer_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"AnswerId": strAnswerId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vqa_Answer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vqa_Answer_ConstructorName, strThisFuncName);
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
 * @param strAnswerId:所给的关键字
 * @returns 对象
*/
export async function vqa_Answer_IsExist_Cache(strAnswerId:string,strTopicId:string) {
const strThisFuncName = "IsExist_Cache";
const arrvqa_AnswerObjLst_Cache = await vqa_Answer_GetObjLst_Cache(strTopicId);
if (arrvqa_AnswerObjLst_Cache == null) return false;
try
{
const arrvqa_Answer_Sel: Array <clsvqa_AnswerEN> = arrvqa_AnswerObjLst_Cache.filter(x => x.answerId == strAnswerId);
if (arrvqa_Answer_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strAnswerId, vqa_Answer_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param strAnswerId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function vqa_Answer_IsExistAsync(strAnswerId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vqa_Answer_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strAnswerId": strAnswerId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vqa_Answer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vqa_Answer_ConstructorName, strThisFuncName);
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
export async function vqa_Answer_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(vqa_Answer_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vqa_Answer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vqa_Answer_ConstructorName, strThisFuncName);
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
 * @param objvqa_Answer_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function vqa_Answer_GetRecCountByCond_Cache(objvqa_Answer_Cond: clsvqa_AnswerEN,strTopicId: string) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrvqa_AnswerObjLst_Cache = await vqa_Answer_GetObjLst_Cache(strTopicId);
if (arrvqa_AnswerObjLst_Cache == null) return 0;
let arrvqa_Answer_Sel: Array < clsvqa_AnswerEN > = arrvqa_AnswerObjLst_Cache;
if (objvqa_Answer_Cond.sf_FldComparisonOp == null || objvqa_Answer_Cond.sf_FldComparisonOp == "") return arrvqa_Answer_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvqa_Answer_Cond.sf_FldComparisonOp);
//console.log("clsvqa_AnswerWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvqa_Answer_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvqa_Answer_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvqa_Answer_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objvqa_Answer_Cond), vqa_Answer_ConstructorName, strThisFuncName);
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
export function vqa_Answer_GetWebApiUrl(strController: string, strAction: string): string {
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
export function vqa_Answer_ReFreshThisCache(strTopicId: string):void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = Format("{0}_{1}", clsvqa_AnswerEN._CurrTabName, strTopicId);
switch (clsvqa_AnswerEN.CacheModeId)
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
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vqa_Answer_GetJSONStrByObj (pobjvqa_AnswerEN: clsvqa_AnswerEN): string
{
const strThisFuncName = "GetJSONStrByObj";
let strJson = "";
try
{
strJson = JSON.stringify(pobjvqa_AnswerEN);
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
export function vqa_Answer_GetObjLstByJSONStr (strJSON: string): Array<clsvqa_AnswerEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrvqa_AnswerObjLst = new Array<clsvqa_AnswerEN>();
if (strJSON === "")
{
return arrvqa_AnswerObjLst;
}
try
{
arrvqa_AnswerObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvqa_AnswerObjLst;
}
return arrvqa_AnswerObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrvqa_AnswerObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function vqa_Answer_GetObjLstByJSONObjLst (arrvqa_AnswerObjLstS: Array<clsvqa_AnswerEN>): Array<clsvqa_AnswerEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrvqa_AnswerObjLst = new Array<clsvqa_AnswerEN>();
for (const objInFor of arrvqa_AnswerObjLstS) {
const obj1 = vqa_Answer_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrvqa_AnswerObjLst.push(obj1);
}
return arrvqa_AnswerObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vqa_Answer_GetObjByJSONStr (strJSON: string): clsvqa_AnswerEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjvqa_AnswerEN = new clsvqa_AnswerEN();
if (strJSON === "")
{
return pobjvqa_AnswerEN;
}
try
{
pobjvqa_AnswerEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvqa_AnswerEN;
}
return pobjvqa_AnswerEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function vqa_Answer_GetCombineCondition(objvqa_Answer_Cond: clsvqa_AnswerEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objvqa_Answer_Cond.dicFldComparisonOp, clsvqa_AnswerEN.con_AnswerId) == true)
{
const strComparisonOp_AnswerId:string = objvqa_Answer_Cond.dicFldComparisonOp[clsvqa_AnswerEN.con_AnswerId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvqa_AnswerEN.con_AnswerId, objvqa_Answer_Cond.answerId, strComparisonOp_AnswerId);
}
if (Object.prototype.hasOwnProperty.call(objvqa_Answer_Cond.dicFldComparisonOp, clsvqa_AnswerEN.con_QuestionsId) == true)
{
const strComparisonOp_QuestionsId:string = objvqa_Answer_Cond.dicFldComparisonOp[clsvqa_AnswerEN.con_QuestionsId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvqa_AnswerEN.con_QuestionsId, objvqa_Answer_Cond.questionsId, strComparisonOp_QuestionsId);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objvqa_Answer_Cond.dicFldComparisonOp, clsvqa_AnswerEN.con_Score) == true)
{
const strComparisonOp_Score:string = objvqa_Answer_Cond.dicFldComparisonOp[clsvqa_AnswerEN.con_Score];
strWhereCond += Format(" And {0} {2} {1}", clsvqa_AnswerEN.con_Score, objvqa_Answer_Cond.score, strComparisonOp_Score);
}
if (Object.prototype.hasOwnProperty.call(objvqa_Answer_Cond.dicFldComparisonOp, clsvqa_AnswerEN.con_ScoreType) == true)
{
const strComparisonOp_ScoreType:string = objvqa_Answer_Cond.dicFldComparisonOp[clsvqa_AnswerEN.con_ScoreType];
strWhereCond += Format(" And {0} {2} '{1}'", clsvqa_AnswerEN.con_ScoreType, objvqa_Answer_Cond.scoreType, strComparisonOp_ScoreType);
}
if (Object.prototype.hasOwnProperty.call(objvqa_Answer_Cond.dicFldComparisonOp, clsvqa_AnswerEN.con_IsRight) == true)
{
if (objvqa_Answer_Cond.isRight == true)
{
strWhereCond += Format(" And {0} = '1'", clsvqa_AnswerEN.con_IsRight);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvqa_AnswerEN.con_IsRight);
}
}
if (Object.prototype.hasOwnProperty.call(objvqa_Answer_Cond.dicFldComparisonOp, clsvqa_AnswerEN.con_ParentId) == true)
{
const strComparisonOp_ParentId:string = objvqa_Answer_Cond.dicFldComparisonOp[clsvqa_AnswerEN.con_ParentId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvqa_AnswerEN.con_ParentId, objvqa_Answer_Cond.parentId, strComparisonOp_ParentId);
}
if (Object.prototype.hasOwnProperty.call(objvqa_Answer_Cond.dicFldComparisonOp, clsvqa_AnswerEN.con_VoteCount) == true)
{
const strComparisonOp_VoteCount:string = objvqa_Answer_Cond.dicFldComparisonOp[clsvqa_AnswerEN.con_VoteCount];
strWhereCond += Format(" And {0} {2} {1}", clsvqa_AnswerEN.con_VoteCount, objvqa_Answer_Cond.voteCount, strComparisonOp_VoteCount);
}
if (Object.prototype.hasOwnProperty.call(objvqa_Answer_Cond.dicFldComparisonOp, clsvqa_AnswerEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objvqa_Answer_Cond.dicFldComparisonOp[clsvqa_AnswerEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsvqa_AnswerEN.con_UpdUser, objvqa_Answer_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objvqa_Answer_Cond.dicFldComparisonOp, clsvqa_AnswerEN.con_UserName) == true)
{
const strComparisonOp_UserName:string = objvqa_Answer_Cond.dicFldComparisonOp[clsvqa_AnswerEN.con_UserName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvqa_AnswerEN.con_UserName, objvqa_Answer_Cond.userName, strComparisonOp_UserName);
}
if (Object.prototype.hasOwnProperty.call(objvqa_Answer_Cond.dicFldComparisonOp, clsvqa_AnswerEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objvqa_Answer_Cond.dicFldComparisonOp[clsvqa_AnswerEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvqa_AnswerEN.con_UpdDate, objvqa_Answer_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objvqa_Answer_Cond.dicFldComparisonOp, clsvqa_AnswerEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objvqa_Answer_Cond.dicFldComparisonOp[clsvqa_AnswerEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsvqa_AnswerEN.con_Memo, objvqa_Answer_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objvqa_Answer_Cond.dicFldComparisonOp, clsvqa_AnswerEN.con_qa_PaperId) == true)
{
const strComparisonOp_qa_PaperId:string = objvqa_Answer_Cond.dicFldComparisonOp[clsvqa_AnswerEN.con_qa_PaperId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvqa_AnswerEN.con_qa_PaperId, objvqa_Answer_Cond.qa_PaperId, strComparisonOp_qa_PaperId);
}
if (Object.prototype.hasOwnProperty.call(objvqa_Answer_Cond.dicFldComparisonOp, clsvqa_AnswerEN.con_QuestionsContent) == true)
{
const strComparisonOp_QuestionsContent:string = objvqa_Answer_Cond.dicFldComparisonOp[clsvqa_AnswerEN.con_QuestionsContent];
strWhereCond += Format(" And {0} {2} '{1}'", clsvqa_AnswerEN.con_QuestionsContent, objvqa_Answer_Cond.questionsContent, strComparisonOp_QuestionsContent);
}
if (Object.prototype.hasOwnProperty.call(objvqa_Answer_Cond.dicFldComparisonOp, clsvqa_AnswerEN.con_PaperId) == true)
{
const strComparisonOp_PaperId:string = objvqa_Answer_Cond.dicFldComparisonOp[clsvqa_AnswerEN.con_PaperId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvqa_AnswerEN.con_PaperId, objvqa_Answer_Cond.paperId, strComparisonOp_PaperId);
}
if (Object.prototype.hasOwnProperty.call(objvqa_Answer_Cond.dicFldComparisonOp, clsvqa_AnswerEN.con_QuestionsTypeId) == true)
{
const strComparisonOp_QuestionsTypeId:string = objvqa_Answer_Cond.dicFldComparisonOp[clsvqa_AnswerEN.con_QuestionsTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvqa_AnswerEN.con_QuestionsTypeId, objvqa_Answer_Cond.questionsTypeId, strComparisonOp_QuestionsTypeId);
}
if (Object.prototype.hasOwnProperty.call(objvqa_Answer_Cond.dicFldComparisonOp, clsvqa_AnswerEN.con_QuestionsTypeName) == true)
{
const strComparisonOp_QuestionsTypeName:string = objvqa_Answer_Cond.dicFldComparisonOp[clsvqa_AnswerEN.con_QuestionsTypeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvqa_AnswerEN.con_QuestionsTypeName, objvqa_Answer_Cond.questionsTypeName, strComparisonOp_QuestionsTypeName);
}
if (Object.prototype.hasOwnProperty.call(objvqa_Answer_Cond.dicFldComparisonOp, clsvqa_AnswerEN.con_IsRecommend) == true)
{
if (objvqa_Answer_Cond.isRecommend == true)
{
strWhereCond += Format(" And {0} = '1'", clsvqa_AnswerEN.con_IsRecommend);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvqa_AnswerEN.con_IsRecommend);
}
}
if (Object.prototype.hasOwnProperty.call(objvqa_Answer_Cond.dicFldComparisonOp, clsvqa_AnswerEN.con_TopicId) == true)
{
const strComparisonOp_TopicId:string = objvqa_Answer_Cond.dicFldComparisonOp[clsvqa_AnswerEN.con_TopicId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvqa_AnswerEN.con_TopicId, objvqa_Answer_Cond.topicId, strComparisonOp_TopicId);
}
if (Object.prototype.hasOwnProperty.call(objvqa_Answer_Cond.dicFldComparisonOp, clsvqa_AnswerEN.con_AnswerTypeId) == true)
{
const strComparisonOp_AnswerTypeId:string = objvqa_Answer_Cond.dicFldComparisonOp[clsvqa_AnswerEN.con_AnswerTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvqa_AnswerEN.con_AnswerTypeId, objvqa_Answer_Cond.answerTypeId, strComparisonOp_AnswerTypeId);
}
if (Object.prototype.hasOwnProperty.call(objvqa_Answer_Cond.dicFldComparisonOp, clsvqa_AnswerEN.con_IsSubmit) == true)
{
if (objvqa_Answer_Cond.isSubmit == true)
{
strWhereCond += Format(" And {0} = '1'", clsvqa_AnswerEN.con_IsSubmit);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvqa_AnswerEN.con_IsSubmit);
}
}
if (Object.prototype.hasOwnProperty.call(objvqa_Answer_Cond.dicFldComparisonOp, clsvqa_AnswerEN.con_AnswerCount) == true)
{
const strComparisonOp_AnswerCount:string = objvqa_Answer_Cond.dicFldComparisonOp[clsvqa_AnswerEN.con_AnswerCount];
strWhereCond += Format(" And {0} {2} {1}", clsvqa_AnswerEN.con_AnswerCount, objvqa_Answer_Cond.answerCount, strComparisonOp_AnswerCount);
}
if (Object.prototype.hasOwnProperty.call(objvqa_Answer_Cond.dicFldComparisonOp, clsvqa_AnswerEN.con_PaperTitle) == true)
{
const strComparisonOp_PaperTitle:string = objvqa_Answer_Cond.dicFldComparisonOp[clsvqa_AnswerEN.con_PaperTitle];
strWhereCond += Format(" And {0} {2} '{1}'", clsvqa_AnswerEN.con_PaperTitle, objvqa_Answer_Cond.paperTitle, strComparisonOp_PaperTitle);
}
if (Object.prototype.hasOwnProperty.call(objvqa_Answer_Cond.dicFldComparisonOp, clsvqa_AnswerEN.con_QuestUserName) == true)
{
const strComparisonOp_QuestUserName:string = objvqa_Answer_Cond.dicFldComparisonOp[clsvqa_AnswerEN.con_QuestUserName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvqa_AnswerEN.con_QuestUserName, objvqa_Answer_Cond.questUserName, strComparisonOp_QuestUserName);
}
if (Object.prototype.hasOwnProperty.call(objvqa_Answer_Cond.dicFldComparisonOp, clsvqa_AnswerEN.con_AppraiseCount) == true)
{
const strComparisonOp_AppraiseCount:string = objvqa_Answer_Cond.dicFldComparisonOp[clsvqa_AnswerEN.con_AppraiseCount];
strWhereCond += Format(" And {0} {2} {1}", clsvqa_AnswerEN.con_AppraiseCount, objvqa_Answer_Cond.appraiseCount, strComparisonOp_AppraiseCount);
}
if (Object.prototype.hasOwnProperty.call(objvqa_Answer_Cond.dicFldComparisonOp, clsvqa_AnswerEN.con_StuScore) == true)
{
const strComparisonOp_StuScore:string = objvqa_Answer_Cond.dicFldComparisonOp[clsvqa_AnswerEN.con_StuScore];
strWhereCond += Format(" And {0} {2} {1}", clsvqa_AnswerEN.con_StuScore, objvqa_Answer_Cond.stuScore, strComparisonOp_StuScore);
}
if (Object.prototype.hasOwnProperty.call(objvqa_Answer_Cond.dicFldComparisonOp, clsvqa_AnswerEN.con_TeaScore) == true)
{
const strComparisonOp_TeaScore:string = objvqa_Answer_Cond.dicFldComparisonOp[clsvqa_AnswerEN.con_TeaScore];
strWhereCond += Format(" And {0} {2} {1}", clsvqa_AnswerEN.con_TeaScore, objvqa_Answer_Cond.teaScore, strComparisonOp_TeaScore);
}
if (Object.prototype.hasOwnProperty.call(objvqa_Answer_Cond.dicFldComparisonOp, clsvqa_AnswerEN.con_UserId) == true)
{
const strComparisonOp_UserId:string = objvqa_Answer_Cond.dicFldComparisonOp[clsvqa_AnswerEN.con_UserId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvqa_AnswerEN.con_UserId, objvqa_Answer_Cond.userId, strComparisonOp_UserId);
}
if (Object.prototype.hasOwnProperty.call(objvqa_Answer_Cond.dicFldComparisonOp, clsvqa_AnswerEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objvqa_Answer_Cond.dicFldComparisonOp[clsvqa_AnswerEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsvqa_AnswerEN.con_id_CurrEduCls, objvqa_Answer_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objvqa_AnswerENS:源对象
 * @param objvqa_AnswerENT:目标对象
*/
export function vqa_Answer_CopyObjTo(objvqa_AnswerENS: clsvqa_AnswerEN , objvqa_AnswerENT: clsvqa_AnswerEN ): void 
{
objvqa_AnswerENT.answerId = objvqa_AnswerENS.answerId; //回答Id
objvqa_AnswerENT.questionsId = objvqa_AnswerENS.questionsId; //提问Id
objvqa_AnswerENT.answerContent = objvqa_AnswerENS.answerContent; //答案内容
objvqa_AnswerENT.score = objvqa_AnswerENS.score; //评分
objvqa_AnswerENT.scoreType = objvqa_AnswerENS.scoreType; //评分类型
objvqa_AnswerENT.isRight = objvqa_AnswerENS.isRight; //是否正确
objvqa_AnswerENT.parentId = objvqa_AnswerENS.parentId; //父节点Id
objvqa_AnswerENT.voteCount = objvqa_AnswerENS.voteCount; //点赞计数
objvqa_AnswerENT.updUser = objvqa_AnswerENS.updUser; //修改人
objvqa_AnswerENT.userName = objvqa_AnswerENS.userName; //用户名
objvqa_AnswerENT.updDate = objvqa_AnswerENS.updDate; //修改日期
objvqa_AnswerENT.memo = objvqa_AnswerENS.memo; //备注
objvqa_AnswerENT.qa_PaperId = objvqa_AnswerENS.qa_PaperId; //论文答疑Id
objvqa_AnswerENT.questionsContent = objvqa_AnswerENS.questionsContent; //提问内容
objvqa_AnswerENT.paperId = objvqa_AnswerENS.paperId; //论文Id
objvqa_AnswerENT.questionsTypeId = objvqa_AnswerENS.questionsTypeId; //问题类型Id
objvqa_AnswerENT.questionsTypeName = objvqa_AnswerENS.questionsTypeName; //问题类型名称
objvqa_AnswerENT.isRecommend = objvqa_AnswerENS.isRecommend; //是否推荐
objvqa_AnswerENT.topicId = objvqa_AnswerENS.topicId; //主题Id
objvqa_AnswerENT.answerTypeId = objvqa_AnswerENS.answerTypeId; //答案类型ID
objvqa_AnswerENT.isSubmit = objvqa_AnswerENS.isSubmit; //是否提交
objvqa_AnswerENT.answerCount = objvqa_AnswerENS.answerCount; //回答计数
objvqa_AnswerENT.paperTitle = objvqa_AnswerENS.paperTitle; //论文标题
objvqa_AnswerENT.questUserName = objvqa_AnswerENS.questUserName; //QuestUserName
objvqa_AnswerENT.appraiseCount = objvqa_AnswerENS.appraiseCount; //评论数
objvqa_AnswerENT.stuScore = objvqa_AnswerENS.stuScore; //学生平均分
objvqa_AnswerENT.teaScore = objvqa_AnswerENS.teaScore; //教师评分
objvqa_AnswerENT.userId = objvqa_AnswerENS.userId; //用户ID
objvqa_AnswerENT.id_CurrEduCls = objvqa_AnswerENS.id_CurrEduCls; //教学班流水号
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objvqa_AnswerENS:源对象
 * @param objvqa_AnswerENT:目标对象
*/
export function vqa_Answer_GetObjFromJsonObj(objvqa_AnswerENS: clsvqa_AnswerEN): clsvqa_AnswerEN 
{
 const objvqa_AnswerENT: clsvqa_AnswerEN = new clsvqa_AnswerEN();
ObjectAssign(objvqa_AnswerENT, objvqa_AnswerENS);
 return objvqa_AnswerENT;
}