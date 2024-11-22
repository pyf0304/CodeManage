
 /**
 * 类名:clsvgs_RTqa_PaperRelaWApi
 * 表名:vgs_RTqa_PaperRela(01120695)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:53:23
 * 生成者:pyf
 * 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:研培主题(GraduateEduTopic)
 * 框架-层名:WA_访问层(TS)(WA_Access)
 * 编程语言:TypeScript
 * 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
   *      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 **/

/**
 * 主题答疑关系视图(vgs_RTqa_PaperRela)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2023年03月13日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { enumComparisonOp } from "../../PubFun/enumComparisonOp.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { clsvgs_RTqa_PaperRelaEN } from "../../L0_Entity/GraduateEduTopic/clsvgs_RTqa_PaperRelaEN.js";
import { BindDdl_ObjLstInDiv_V, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const vgs_RTqa_PaperRela_Controller = "vgs_RTqa_PaperRelaApi";
 export const vgs_RTqa_PaperRela_ConstructorName = "vgs_RTqa_PaperRela";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngmId:关键字
 * @returns 对象
 **/
export async function vgs_RTqa_PaperRela_GetObjBymIdAsync(lngmId: number): Promise<clsvgs_RTqa_PaperRelaEN|null>  
{
const strThisFuncName = "GetObjBymIdAsync";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In clsvgs_RTqa_PaperRelaWApi.GetObjBymIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjBymId";
const strUrl = GetWebApiUrl(vgs_RTqa_PaperRela_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"lngmId": lngmId,
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
const objvgs_RTqa_PaperRela = vgs_RTqa_PaperRela_GetObjFromJsonObj(returnObj);
return objvgs_RTqa_PaperRela;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
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
 * @param lngmId:所给的关键字
 * @returns 对象
*/
export async function vgs_RTqa_PaperRela_GetObjBymId_Cache(lngmId:number,strTopicId:string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjBymId_Cache";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In clsvgs_RTqa_PaperRelaWApi.GetObjBymId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
const arrvgs_RTqa_PaperRelaObjLst_Cache = await vgs_RTqa_PaperRela_GetObjLst_Cache(strTopicId);
try
{
const arrvgs_RTqa_PaperRela_Sel: Array <clsvgs_RTqa_PaperRelaEN> = arrvgs_RTqa_PaperRelaObjLst_Cache.filter(x => 
 x.mId == lngmId );
let objvgs_RTqa_PaperRela: clsvgs_RTqa_PaperRelaEN;
if (arrvgs_RTqa_PaperRela_Sel.length > 0)
{
objvgs_RTqa_PaperRela = arrvgs_RTqa_PaperRela_Sel[0];
return objvgs_RTqa_PaperRela;
}
else
{
if (bolTryAsyncOnce == true)
{
const objvgs_RTqa_PaperRela_Const = await vgs_RTqa_PaperRela_GetObjBymIdAsync(lngmId);
if (objvgs_RTqa_PaperRela_Const != null)
{
vgs_RTqa_PaperRela_ReFreshThisCache(strTopicId);
return objvgs_RTqa_PaperRela_Const;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param lngmId:所给的关键字
 * @returns 对象
*/
export async function vgs_RTqa_PaperRela_GetObjBymId_localStorage(lngmId: number) {
const strThisFuncName = "GetObjBymId_localStorage";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In clsvgs_RTqa_PaperRelaWApi.GetObjBymId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
const strKey = Format("{0}_{1}", clsvgs_RTqa_PaperRelaEN._CurrTabName, lngmId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objvgs_RTqa_PaperRela_Cache: clsvgs_RTqa_PaperRelaEN = JSON.parse(strTempObj);
return objvgs_RTqa_PaperRela_Cache;
}
try
{
const objvgs_RTqa_PaperRela = await vgs_RTqa_PaperRela_GetObjBymIdAsync(lngmId);
if (objvgs_RTqa_PaperRela != null)
{
localStorage.setItem(strKey, JSON.stringify(objvgs_RTqa_PaperRela));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objvgs_RTqa_PaperRela;
}
return objvgs_RTqa_PaperRela;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
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
export async function vgs_RTqa_PaperRela_func(strInFldName:string , strOutFldName:string , strInValue:string 
, strTopicId_C: string)
{
//const strThisFuncName = "func";

if (IsNullOrEmpty(strTopicId_C) == true)
{
  const strMsg = Format("参数:[strTopicId_C]不能为空！(In clsvgs_RTqa_PaperRelaWApi.func)");
console.error(strMsg);
 throw (strMsg);
}
if (strTopicId_C.length != 8)
{
const strMsg = Format("缓存分类变量:[strTopicId_C]的长度:[{0}]不正确！(clsvgs_RTqa_PaperRelaWApi.func)", strTopicId_C.length);
console.error(strMsg);
throw (strMsg);
}

if (strInFldName != clsvgs_RTqa_PaperRelaEN.con_mId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsvgs_RTqa_PaperRelaEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strOutFldName, clsvgs_RTqa_PaperRelaEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const lngmId = Number(strInValue);
if (lngmId == 0)
{
return "";
}
const objvgs_RTqa_PaperRela = await vgs_RTqa_PaperRela_GetObjBymId_Cache(lngmId , strTopicId_C);
if (objvgs_RTqa_PaperRela == null) return "";
if (objvgs_RTqa_PaperRela.GetFldValue(strOutFldName) == null) return "";
return objvgs_RTqa_PaperRela.GetFldValue(strOutFldName).toString();
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
export function vgs_RTqa_PaperRela_SortFun_Defa(a:clsvgs_RTqa_PaperRelaEN , b:clsvgs_RTqa_PaperRelaEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.mId-b.mId;
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
export function vgs_RTqa_PaperRela_SortFun_Defa_2Fld(a:clsvgs_RTqa_PaperRelaEN , b:clsvgs_RTqa_PaperRelaEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.topicId == b.topicId) return a.topicName.localeCompare(b.topicName);
else return a.topicId.localeCompare(b.topicId);
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
export function vgs_RTqa_PaperRela_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsvgs_RTqa_PaperRelaEN.con_mId:
return (a: clsvgs_RTqa_PaperRelaEN, b: clsvgs_RTqa_PaperRelaEN) => {
return a.mId-b.mId;
}
case clsvgs_RTqa_PaperRelaEN.con_TopicId:
return (a: clsvgs_RTqa_PaperRelaEN, b: clsvgs_RTqa_PaperRelaEN) => {
return a.topicId.localeCompare(b.topicId);
}
case clsvgs_RTqa_PaperRelaEN.con_TopicName:
return (a: clsvgs_RTqa_PaperRelaEN, b: clsvgs_RTqa_PaperRelaEN) => {
if (a.topicName == null) return -1;
if (b.topicName == null) return 1;
return a.topicName.localeCompare(b.topicName);
}
case clsvgs_RTqa_PaperRelaEN.con_id_CurrEduCls:
return (a: clsvgs_RTqa_PaperRelaEN, b: clsvgs_RTqa_PaperRelaEN) => {
if (a.id_CurrEduCls == null) return -1;
if (b.id_CurrEduCls == null) return 1;
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
case clsvgs_RTqa_PaperRelaEN.con_qa_PaperId:
return (a: clsvgs_RTqa_PaperRelaEN, b: clsvgs_RTqa_PaperRelaEN) => {
return a.qa_PaperId.localeCompare(b.qa_PaperId);
}
case clsvgs_RTqa_PaperRelaEN.con_PaperId:
return (a: clsvgs_RTqa_PaperRelaEN, b: clsvgs_RTqa_PaperRelaEN) => {
if (a.paperId == null) return -1;
if (b.paperId == null) return 1;
return a.paperId.localeCompare(b.paperId);
}
case clsvgs_RTqa_PaperRelaEN.con_QuestionsCount:
return (a: clsvgs_RTqa_PaperRelaEN, b: clsvgs_RTqa_PaperRelaEN) => {
return a.questionsCount-b.questionsCount;
}
case clsvgs_RTqa_PaperRelaEN.con_IsPublic:
return (a: clsvgs_RTqa_PaperRelaEN, b: clsvgs_RTqa_PaperRelaEN) => {
if (a.isPublic == true) return 1;
else return -1
}
case clsvgs_RTqa_PaperRelaEN.con_IsSubmit:
return (a: clsvgs_RTqa_PaperRelaEN, b: clsvgs_RTqa_PaperRelaEN) => {
if (a.isSubmit == true) return 1;
else return -1
}
case clsvgs_RTqa_PaperRelaEN.con_PaperTitle:
return (a: clsvgs_RTqa_PaperRelaEN, b: clsvgs_RTqa_PaperRelaEN) => {
if (a.paperTitle == null) return -1;
if (b.paperTitle == null) return 1;
return a.paperTitle.localeCompare(b.paperTitle);
}
case clsvgs_RTqa_PaperRelaEN.con_AttachmentCount:
return (a: clsvgs_RTqa_PaperRelaEN, b: clsvgs_RTqa_PaperRelaEN) => {
return a.attachmentCount-b.attachmentCount;
}
case clsvgs_RTqa_PaperRelaEN.con_AnswerCount:
return (a: clsvgs_RTqa_PaperRelaEN, b: clsvgs_RTqa_PaperRelaEN) => {
return a.answerCount-b.answerCount;
}
case clsvgs_RTqa_PaperRelaEN.con_ShareId:
return (a: clsvgs_RTqa_PaperRelaEN, b: clsvgs_RTqa_PaperRelaEN) => {
if (a.shareId == null) return -1;
if (b.shareId == null) return 1;
return a.shareId.localeCompare(b.shareId);
}
case clsvgs_RTqa_PaperRelaEN.con_TagsCount:
return (a: clsvgs_RTqa_PaperRelaEN, b: clsvgs_RTqa_PaperRelaEN) => {
return a.tagsCount-b.tagsCount;
}
case clsvgs_RTqa_PaperRelaEN.con_UpdDate:
return (a: clsvgs_RTqa_PaperRelaEN, b: clsvgs_RTqa_PaperRelaEN) => {
if (a.updDate == null) return -1;
if (b.updDate == null) return 1;
return a.updDate.localeCompare(b.updDate);
}
case clsvgs_RTqa_PaperRelaEN.con_UpdUser:
return (a: clsvgs_RTqa_PaperRelaEN, b: clsvgs_RTqa_PaperRelaEN) => {
if (a.updUser == null) return -1;
if (b.updUser == null) return 1;
return a.updUser.localeCompare(b.updUser);
}
case clsvgs_RTqa_PaperRelaEN.con_Memo:
return (a: clsvgs_RTqa_PaperRelaEN, b: clsvgs_RTqa_PaperRelaEN) => {
if (a.memo == null) return -1;
if (b.memo == null) return 1;
return a.memo.localeCompare(b.memo);
}
case clsvgs_RTqa_PaperRelaEN.con_qaUser:
return (a: clsvgs_RTqa_PaperRelaEN, b: clsvgs_RTqa_PaperRelaEN) => {
if (a.qaUser == null) return -1;
if (b.qaUser == null) return 1;
return a.qaUser.localeCompare(b.qaUser);
}
case clsvgs_RTqa_PaperRelaEN.con_qaDate:
return (a: clsvgs_RTqa_PaperRelaEN, b: clsvgs_RTqa_PaperRelaEN) => {
if (a.qaDate == null) return -1;
if (b.qaDate == null) return 1;
return a.qaDate.localeCompare(b.qaDate);
}
case clsvgs_RTqa_PaperRelaEN.con_qaUserName:
return (a: clsvgs_RTqa_PaperRelaEN, b: clsvgs_RTqa_PaperRelaEN) => {
if (a.qaUserName == null) return -1;
if (b.qaUserName == null) return 1;
return a.qaUserName.localeCompare(b.qaUserName);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vgs_RTqa_PaperRela]中不存在！(in ${ vgs_RTqa_PaperRela_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsvgs_RTqa_PaperRelaEN.con_mId:
return (a: clsvgs_RTqa_PaperRelaEN, b: clsvgs_RTqa_PaperRelaEN) => {
return b.mId-a.mId;
}
case clsvgs_RTqa_PaperRelaEN.con_TopicId:
return (a: clsvgs_RTqa_PaperRelaEN, b: clsvgs_RTqa_PaperRelaEN) => {
return b.topicId.localeCompare(a.topicId);
}
case clsvgs_RTqa_PaperRelaEN.con_TopicName:
return (a: clsvgs_RTqa_PaperRelaEN, b: clsvgs_RTqa_PaperRelaEN) => {
if (b.topicName == null) return -1;
if (a.topicName == null) return 1;
return b.topicName.localeCompare(a.topicName);
}
case clsvgs_RTqa_PaperRelaEN.con_id_CurrEduCls:
return (a: clsvgs_RTqa_PaperRelaEN, b: clsvgs_RTqa_PaperRelaEN) => {
if (b.id_CurrEduCls == null) return -1;
if (a.id_CurrEduCls == null) return 1;
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
case clsvgs_RTqa_PaperRelaEN.con_qa_PaperId:
return (a: clsvgs_RTqa_PaperRelaEN, b: clsvgs_RTqa_PaperRelaEN) => {
return b.qa_PaperId.localeCompare(a.qa_PaperId);
}
case clsvgs_RTqa_PaperRelaEN.con_PaperId:
return (a: clsvgs_RTqa_PaperRelaEN, b: clsvgs_RTqa_PaperRelaEN) => {
if (b.paperId == null) return -1;
if (a.paperId == null) return 1;
return b.paperId.localeCompare(a.paperId);
}
case clsvgs_RTqa_PaperRelaEN.con_QuestionsCount:
return (a: clsvgs_RTqa_PaperRelaEN, b: clsvgs_RTqa_PaperRelaEN) => {
return b.questionsCount-a.questionsCount;
}
case clsvgs_RTqa_PaperRelaEN.con_IsPublic:
return (a: clsvgs_RTqa_PaperRelaEN, b: clsvgs_RTqa_PaperRelaEN) => {
if (b.isPublic == true) return 1;
else return -1
}
case clsvgs_RTqa_PaperRelaEN.con_IsSubmit:
return (a: clsvgs_RTqa_PaperRelaEN, b: clsvgs_RTqa_PaperRelaEN) => {
if (b.isSubmit == true) return 1;
else return -1
}
case clsvgs_RTqa_PaperRelaEN.con_PaperTitle:
return (a: clsvgs_RTqa_PaperRelaEN, b: clsvgs_RTqa_PaperRelaEN) => {
if (b.paperTitle == null) return -1;
if (a.paperTitle == null) return 1;
return b.paperTitle.localeCompare(a.paperTitle);
}
case clsvgs_RTqa_PaperRelaEN.con_AttachmentCount:
return (a: clsvgs_RTqa_PaperRelaEN, b: clsvgs_RTqa_PaperRelaEN) => {
return b.attachmentCount-a.attachmentCount;
}
case clsvgs_RTqa_PaperRelaEN.con_AnswerCount:
return (a: clsvgs_RTqa_PaperRelaEN, b: clsvgs_RTqa_PaperRelaEN) => {
return b.answerCount-a.answerCount;
}
case clsvgs_RTqa_PaperRelaEN.con_ShareId:
return (a: clsvgs_RTqa_PaperRelaEN, b: clsvgs_RTqa_PaperRelaEN) => {
if (b.shareId == null) return -1;
if (a.shareId == null) return 1;
return b.shareId.localeCompare(a.shareId);
}
case clsvgs_RTqa_PaperRelaEN.con_TagsCount:
return (a: clsvgs_RTqa_PaperRelaEN, b: clsvgs_RTqa_PaperRelaEN) => {
return b.tagsCount-a.tagsCount;
}
case clsvgs_RTqa_PaperRelaEN.con_UpdDate:
return (a: clsvgs_RTqa_PaperRelaEN, b: clsvgs_RTqa_PaperRelaEN) => {
if (b.updDate == null) return -1;
if (a.updDate == null) return 1;
return b.updDate.localeCompare(a.updDate);
}
case clsvgs_RTqa_PaperRelaEN.con_UpdUser:
return (a: clsvgs_RTqa_PaperRelaEN, b: clsvgs_RTqa_PaperRelaEN) => {
if (b.updUser == null) return -1;
if (a.updUser == null) return 1;
return b.updUser.localeCompare(a.updUser);
}
case clsvgs_RTqa_PaperRelaEN.con_Memo:
return (a: clsvgs_RTqa_PaperRelaEN, b: clsvgs_RTqa_PaperRelaEN) => {
if (b.memo == null) return -1;
if (a.memo == null) return 1;
return b.memo.localeCompare(a.memo);
}
case clsvgs_RTqa_PaperRelaEN.con_qaUser:
return (a: clsvgs_RTqa_PaperRelaEN, b: clsvgs_RTqa_PaperRelaEN) => {
if (b.qaUser == null) return -1;
if (a.qaUser == null) return 1;
return b.qaUser.localeCompare(a.qaUser);
}
case clsvgs_RTqa_PaperRelaEN.con_qaDate:
return (a: clsvgs_RTqa_PaperRelaEN, b: clsvgs_RTqa_PaperRelaEN) => {
if (b.qaDate == null) return -1;
if (a.qaDate == null) return 1;
return b.qaDate.localeCompare(a.qaDate);
}
case clsvgs_RTqa_PaperRelaEN.con_qaUserName:
return (a: clsvgs_RTqa_PaperRelaEN, b: clsvgs_RTqa_PaperRelaEN) => {
if (b.qaUserName == null) return -1;
if (a.qaUserName == null) return 1;
return b.qaUserName.localeCompare(a.qaUserName);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vgs_RTqa_PaperRela]中不存在！(in ${ vgs_RTqa_PaperRela_ConstructorName}.${ strThisFuncName})`;
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
export async function vgs_RTqa_PaperRela_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsvgs_RTqa_PaperRelaEN.con_mId:
return (obj: clsvgs_RTqa_PaperRelaEN) => {
return obj.mId === value;
}
case clsvgs_RTqa_PaperRelaEN.con_TopicId:
return (obj: clsvgs_RTqa_PaperRelaEN) => {
return obj.topicId === value;
}
case clsvgs_RTqa_PaperRelaEN.con_TopicName:
return (obj: clsvgs_RTqa_PaperRelaEN) => {
return obj.topicName === value;
}
case clsvgs_RTqa_PaperRelaEN.con_id_CurrEduCls:
return (obj: clsvgs_RTqa_PaperRelaEN) => {
return obj.id_CurrEduCls === value;
}
case clsvgs_RTqa_PaperRelaEN.con_qa_PaperId:
return (obj: clsvgs_RTqa_PaperRelaEN) => {
return obj.qa_PaperId === value;
}
case clsvgs_RTqa_PaperRelaEN.con_PaperId:
return (obj: clsvgs_RTqa_PaperRelaEN) => {
return obj.paperId === value;
}
case clsvgs_RTqa_PaperRelaEN.con_QuestionsCount:
return (obj: clsvgs_RTqa_PaperRelaEN) => {
return obj.questionsCount === value;
}
case clsvgs_RTqa_PaperRelaEN.con_IsPublic:
return (obj: clsvgs_RTqa_PaperRelaEN) => {
return obj.isPublic === value;
}
case clsvgs_RTqa_PaperRelaEN.con_IsSubmit:
return (obj: clsvgs_RTqa_PaperRelaEN) => {
return obj.isSubmit === value;
}
case clsvgs_RTqa_PaperRelaEN.con_PaperTitle:
return (obj: clsvgs_RTqa_PaperRelaEN) => {
return obj.paperTitle === value;
}
case clsvgs_RTqa_PaperRelaEN.con_AttachmentCount:
return (obj: clsvgs_RTqa_PaperRelaEN) => {
return obj.attachmentCount === value;
}
case clsvgs_RTqa_PaperRelaEN.con_AnswerCount:
return (obj: clsvgs_RTqa_PaperRelaEN) => {
return obj.answerCount === value;
}
case clsvgs_RTqa_PaperRelaEN.con_ShareId:
return (obj: clsvgs_RTqa_PaperRelaEN) => {
return obj.shareId === value;
}
case clsvgs_RTqa_PaperRelaEN.con_TagsCount:
return (obj: clsvgs_RTqa_PaperRelaEN) => {
return obj.tagsCount === value;
}
case clsvgs_RTqa_PaperRelaEN.con_UpdDate:
return (obj: clsvgs_RTqa_PaperRelaEN) => {
return obj.updDate === value;
}
case clsvgs_RTqa_PaperRelaEN.con_UpdUser:
return (obj: clsvgs_RTqa_PaperRelaEN) => {
return obj.updUser === value;
}
case clsvgs_RTqa_PaperRelaEN.con_Memo:
return (obj: clsvgs_RTqa_PaperRelaEN) => {
return obj.memo === value;
}
case clsvgs_RTqa_PaperRelaEN.con_qaUser:
return (obj: clsvgs_RTqa_PaperRelaEN) => {
return obj.qaUser === value;
}
case clsvgs_RTqa_PaperRelaEN.con_qaDate:
return (obj: clsvgs_RTqa_PaperRelaEN) => {
return obj.qaDate === value;
}
case clsvgs_RTqa_PaperRelaEN.con_qaUserName:
return (obj: clsvgs_RTqa_PaperRelaEN) => {
return obj.qaUserName === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vgs_RTqa_PaperRela]中不存在！(in ${ vgs_RTqa_PaperRela_ConstructorName}.${ strThisFuncName})`;
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
export async function vgs_RTqa_PaperRela_funcKey(strInFldName:string, strInValue: any, strComparisonOp:string, strTopicId_C: string): Promise<Array<number>>
{
//const strThisFuncName = "funcKey";

if (IsNullOrEmpty(strTopicId_C) == true)
{
  const strMsg = Format("参数:[strTopicId_C]不能为空！(In clsvgs_RTqa_PaperRelaWApi.funcKey)");
console.error(strMsg);
 throw (strMsg);
}
if (strTopicId_C.length != 8)
{
const strMsg = Format("缓存分类变量:[strTopicId_C]的长度:[{0}]不正确！(clsvgs_RTqa_PaperRelaWApi.funcKey)", strTopicId_C.length);
console.error(strMsg);
throw (strMsg);
}

if (strInFldName == clsvgs_RTqa_PaperRelaEN.con_mId)
{
const strMsg = Format("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (Number(strInValue) == 0)
{
return [];
}
const arrvgs_RTqa_PaperRela = await vgs_RTqa_PaperRela_GetObjLst_Cache(strTopicId_C);
if (arrvgs_RTqa_PaperRela == null) return [];
let arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela;
const strType = typeof(strInValue);
switch (strType)
{
case "string":
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01: // " = "
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
break;
case enumComparisonOp.Like_03:
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
break;
case enumComparisonOp.In_04:
const arrValues = strInValue.split(',');
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
break;
}
break;
case "boolean":
if (strInValue == null) return [];
if (strComparisonOp == enumComparisonOp.Equal_01)
{
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
}
break;
case "number":
if (Number(strInValue) == 0) return [];
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01:
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
break;
case enumComparisonOp.NotEqual_02:
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
break;
case enumComparisonOp.NotLessThan_05://" >= ":
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
break;
case enumComparisonOp.NotGreaterThan_06://" <= ":
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
case enumComparisonOp.GreaterThan_07://" > ":
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
break;
case enumComparisonOp.LessThan_08://" < ":
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
}
break;
}
if (arrvgs_RTqa_PaperRela_Sel.length == 0) return [];
return arrvgs_RTqa_PaperRela_Sel.map(x=>x.mId);
}

 /**
 * 根据条件获取满足条件的第一条记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
 * @param strWhereCond:条件
 * @returns 返回的第一条记录的关键字值
 **/
export async function vgs_RTqa_PaperRela_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vgs_RTqa_PaperRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
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
export async function vgs_RTqa_PaperRela_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vgs_RTqa_PaperRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
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
export async function vgs_RTqa_PaperRela_GetFirstObjAsync(strWhereCond: string): Promise<clsvgs_RTqa_PaperRelaEN|null>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(vgs_RTqa_PaperRela_Controller, strAction);
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
const objvgs_RTqa_PaperRela = vgs_RTqa_PaperRela_GetObjFromJsonObj(returnObj);
return objvgs_RTqa_PaperRela;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
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
export async function vgs_RTqa_PaperRela_GetObjLst_ClientCache(strTopicId: string)
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
if (IsNullOrEmpty(clsvgs_RTqa_PaperRelaEN.WhereFormat) == false)
{
strWhereCond = Format(clsvgs_RTqa_PaperRelaEN.WhereFormat, strTopicId);
}
else
{
strWhereCond = Format("TopicId='{0}'", strTopicId);
}
const strKey = Format("{0}_{1}", clsvgs_RTqa_PaperRelaEN._CurrTabName, strTopicId);
if (IsNullOrEmpty(clsvgs_RTqa_PaperRelaEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvgs_RTqa_PaperRelaEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrvgs_RTqa_PaperRelaExObjLst_Cache: Array<clsvgs_RTqa_PaperRelaEN> = CacheHelper.Get(strKey);
const arrvgs_RTqa_PaperRelaObjLst_T = vgs_RTqa_PaperRela_GetObjLstByJSONObjLst(arrvgs_RTqa_PaperRelaExObjLst_Cache);
return arrvgs_RTqa_PaperRelaObjLst_T;
}
try
{
const arrvgs_RTqa_PaperRelaExObjLst = await vgs_RTqa_PaperRela_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrvgs_RTqa_PaperRelaExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvgs_RTqa_PaperRelaExObjLst.length);
console.log(strInfo);
return arrvgs_RTqa_PaperRelaExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vgs_RTqa_PaperRela_GetObjLst_localStorage(strTopicId: string)
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
if (IsNullOrEmpty(clsvgs_RTqa_PaperRelaEN.WhereFormat) == false)
{
strWhereCond = Format(clsvgs_RTqa_PaperRelaEN.WhereFormat, strTopicId);
}
else
{
strWhereCond = Format("TopicId='{0}'", strTopicId);
}
const strKey = Format("{0}_{1}", clsvgs_RTqa_PaperRelaEN._CurrTabName, strTopicId);
if (IsNullOrEmpty(clsvgs_RTqa_PaperRelaEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvgs_RTqa_PaperRelaEN.CacheAddiCondition);
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
const arrvgs_RTqa_PaperRelaExObjLst_Cache: Array<clsvgs_RTqa_PaperRelaEN> = JSON.parse(strTempObjLst);
const arrvgs_RTqa_PaperRelaObjLst_T = vgs_RTqa_PaperRela_GetObjLstByJSONObjLst(arrvgs_RTqa_PaperRelaExObjLst_Cache);
return arrvgs_RTqa_PaperRelaObjLst_T;
}
try
{
const arrvgs_RTqa_PaperRelaExObjLst = await vgs_RTqa_PaperRela_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrvgs_RTqa_PaperRelaExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvgs_RTqa_PaperRelaExObjLst.length);
console.log(strInfo);
return arrvgs_RTqa_PaperRelaExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vgs_RTqa_PaperRela_GetObjLst_localStorage_PureCache(strTopicId: string)
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("TopicId='{0}'", strTopicId);
const strKey = Format("{0}_{1}", clsvgs_RTqa_PaperRelaEN._CurrTabName, strTopicId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrvgs_RTqa_PaperRelaObjLst_Cache: Array<clsvgs_RTqa_PaperRelaEN> = JSON.parse(strTempObjLst);
return arrvgs_RTqa_PaperRelaObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function vgs_RTqa_PaperRela_GetObjLstAsync(strWhereCond: string): Promise<Array<clsvgs_RTqa_PaperRelaEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(vgs_RTqa_PaperRela_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vgs_RTqa_PaperRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
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
export async function vgs_RTqa_PaperRela_GetObjLst_sessionStorage(strTopicId: string)
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
if (IsNullOrEmpty(clsvgs_RTqa_PaperRelaEN.WhereFormat) == false)
{
strWhereCond = Format(clsvgs_RTqa_PaperRelaEN.WhereFormat, strTopicId);
}
else
{
strWhereCond = Format("TopicId='{0}'", strTopicId);
}
const strKey = Format("{0}_{1}", clsvgs_RTqa_PaperRelaEN._CurrTabName, strTopicId);
if (IsNullOrEmpty(clsvgs_RTqa_PaperRelaEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvgs_RTqa_PaperRelaEN.CacheAddiCondition);
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
const arrvgs_RTqa_PaperRelaExObjLst_Cache: Array<clsvgs_RTqa_PaperRelaEN> = JSON.parse(strTempObjLst);
const arrvgs_RTqa_PaperRelaObjLst_T = vgs_RTqa_PaperRela_GetObjLstByJSONObjLst(arrvgs_RTqa_PaperRelaExObjLst_Cache);
return arrvgs_RTqa_PaperRelaObjLst_T;
}
try
{
const arrvgs_RTqa_PaperRelaExObjLst = await vgs_RTqa_PaperRela_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrvgs_RTqa_PaperRelaExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvgs_RTqa_PaperRelaExObjLst.length);
console.log(strInfo);
return arrvgs_RTqa_PaperRelaExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vgs_RTqa_PaperRela_GetObjLst_sessionStorage_PureCache(strTopicId: string)
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("TopicId='{0}'", strTopicId);
const strKey = Format("{0}_{1}", clsvgs_RTqa_PaperRelaEN._CurrTabName, strTopicId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrvgs_RTqa_PaperRelaObjLst_Cache: Array<clsvgs_RTqa_PaperRelaEN> = JSON.parse(strTempObjLst);
return arrvgs_RTqa_PaperRelaObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vgs_RTqa_PaperRela_GetObjLst_Cache(strTopicId: string): Promise<Array<clsvgs_RTqa_PaperRelaEN>>
{
//const strThisFuncName = "GetObjLst_Cache";

if (IsNullOrEmpty(strTopicId) == true)
{
const strMsg = Format("缓存分类变量:[TopicId]不能为空！(in clsvgs_RTqa_PaperRelaWApi.vgs_RTqa_PaperRela_GetObjLst_Cache() )");
console.error(strMsg);
throw (strMsg);
}
if (strTopicId.length != 8)
{
const strMsg = Format("缓存分类变量:[strTopicId]的长度:[{0}]不正确！(in clsvgs_RTqa_PaperRelaWApi.vgs_RTqa_PaperRela_GetObjLst_Cache() )", strTopicId.length);
console.error(strMsg);
throw (strMsg);
}
let arrvgs_RTqa_PaperRelaObjLst_Cache;
switch (clsvgs_RTqa_PaperRelaEN.CacheModeId)
{
case "04"://sessionStorage
arrvgs_RTqa_PaperRelaObjLst_Cache = await vgs_RTqa_PaperRela_GetObjLst_sessionStorage(strTopicId);
break;
case "03"://localStorage
arrvgs_RTqa_PaperRelaObjLst_Cache = await vgs_RTqa_PaperRela_GetObjLst_localStorage(strTopicId);
break;
case "02"://ClientCache
arrvgs_RTqa_PaperRelaObjLst_Cache = await vgs_RTqa_PaperRela_GetObjLst_ClientCache(strTopicId);
break;
default:
arrvgs_RTqa_PaperRelaObjLst_Cache = await vgs_RTqa_PaperRela_GetObjLst_ClientCache(strTopicId);
break;
}
const arrvgs_RTqa_PaperRelaObjLst = vgs_RTqa_PaperRela_GetObjLstByJSONObjLst(arrvgs_RTqa_PaperRelaObjLst_Cache);
return arrvgs_RTqa_PaperRelaObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vgs_RTqa_PaperRela_GetObjLst_PureCache(strTopicId: string)
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrvgs_RTqa_PaperRelaObjLst_Cache;
switch (clsvgs_RTqa_PaperRelaEN.CacheModeId)
{
case "04"://sessionStorage
arrvgs_RTqa_PaperRelaObjLst_Cache = await vgs_RTqa_PaperRela_GetObjLst_sessionStorage_PureCache(strTopicId);
break;
case "03"://localStorage
arrvgs_RTqa_PaperRelaObjLst_Cache = await vgs_RTqa_PaperRela_GetObjLst_localStorage_PureCache(strTopicId);
break;
case "02"://ClientCache
arrvgs_RTqa_PaperRelaObjLst_Cache = null;
break;
default:
arrvgs_RTqa_PaperRelaObjLst_Cache = null;
break;
}
return arrvgs_RTqa_PaperRelaObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objlngmId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vgs_RTqa_PaperRela_GetSubObjLst_Cache(objvgs_RTqa_PaperRela_Cond: clsvgs_RTqa_PaperRelaEN,strTopicId: string) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrvgs_RTqa_PaperRelaObjLst_Cache = await vgs_RTqa_PaperRela_GetObjLst_Cache(strTopicId);
let arrvgs_RTqa_PaperRela_Sel: Array < clsvgs_RTqa_PaperRelaEN > = arrvgs_RTqa_PaperRelaObjLst_Cache;
if (objvgs_RTqa_PaperRela_Cond.sf_FldComparisonOp == null || objvgs_RTqa_PaperRela_Cond.sf_FldComparisonOp == "") return arrvgs_RTqa_PaperRela_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvgs_RTqa_PaperRela_Cond.sf_FldComparisonOp);
//console.log("clsvgs_RTqa_PaperRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvgs_RTqa_PaperRela_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvgs_RTqa_PaperRela_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvgs_RTqa_PaperRela_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objvgs_RTqa_PaperRela_Cond), vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvgs_RTqa_PaperRelaEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrmId:关键字列表
 * @returns 对象列表
 **/
export async function vgs_RTqa_PaperRela_GetObjLstBymIdLstAsync(arrmId: Array<string>): Promise<Array<clsvgs_RTqa_PaperRelaEN>>  
{
const strThisFuncName = "GetObjLstBymIdLstAsync";
const strAction = "GetObjLstBymIdLst";
const strUrl = GetWebApiUrl(vgs_RTqa_PaperRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrmId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vgs_RTqa_PaperRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
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
 * @param arrlngmIdLst:关键字列表
 * @returns 对象列表
*/
export async function vgs_RTqa_PaperRela_GetObjLstBymIdLst_Cache(arrmIdLst: Array<number>,strTopicId: string) {
const strThisFuncName = "GetObjLstBymIdLst_Cache";
try
{
const arrvgs_RTqa_PaperRelaObjLst_Cache = await vgs_RTqa_PaperRela_GetObjLst_Cache(strTopicId);
const arrvgs_RTqa_PaperRela_Sel: Array <clsvgs_RTqa_PaperRelaEN> = arrvgs_RTqa_PaperRelaObjLst_Cache.filter(x => arrmIdLst.indexOf(x.mId)>-1);
return arrvgs_RTqa_PaperRela_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrmIdLst.join(","), vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
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
export async function vgs_RTqa_PaperRela_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsvgs_RTqa_PaperRelaEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(vgs_RTqa_PaperRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vgs_RTqa_PaperRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
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
export async function vgs_RTqa_PaperRela_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsvgs_RTqa_PaperRelaEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vgs_RTqa_PaperRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vgs_RTqa_PaperRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
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
export async function vgs_RTqa_PaperRela_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vgs_RTqa_PaperRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
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
export async function vgs_RTqa_PaperRela_GetObjLstByPager_Cache(objPagerPara: stuPagerPara,strTopicId: string) {
const strThisFuncName = "GetObjLstByPager_Cache";
if (objPagerPara.pageIndex == 0) return new Array<clsvgs_RTqa_PaperRelaEN>();
const arrvgs_RTqa_PaperRelaObjLst_Cache = await vgs_RTqa_PaperRela_GetObjLst_Cache(strTopicId);
if (arrvgs_RTqa_PaperRelaObjLst_Cache.length == 0) return arrvgs_RTqa_PaperRelaObjLst_Cache;
let arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRelaObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objvgs_RTqa_PaperRela_Cond = new clsvgs_RTqa_PaperRelaEN();
ObjectAssign(objvgs_RTqa_PaperRela_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsvgs_RTqa_PaperRelaWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvgs_RTqa_PaperRela_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvgs_RTqa_PaperRela_Sel.length == 0) return arrvgs_RTqa_PaperRela_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.sort(vgs_RTqa_PaperRela_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.sort(objPagerPara.sortFun);
}
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.slice(intStart, intEnd);     
return arrvgs_RTqa_PaperRela_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvgs_RTqa_PaperRelaEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function vgs_RTqa_PaperRela_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsvgs_RTqa_PaperRelaEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
if (objPagerPara.pageIndex == 0) return new Array<clsvgs_RTqa_PaperRelaEN>();
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(vgs_RTqa_PaperRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vgs_RTqa_PaperRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
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
 * @param objlngmId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vgs_RTqa_PaperRela_IsExistRecord_Cache(objvgs_RTqa_PaperRela_Cond: clsvgs_RTqa_PaperRelaEN,strTopicId: string) {
const strThisFuncName = "IsExistRecord_Cache";
const arrvgs_RTqa_PaperRelaObjLst_Cache = await vgs_RTqa_PaperRela_GetObjLst_Cache(strTopicId);
if (arrvgs_RTqa_PaperRelaObjLst_Cache == null) return false;
let arrvgs_RTqa_PaperRela_Sel: Array < clsvgs_RTqa_PaperRelaEN > = arrvgs_RTqa_PaperRelaObjLst_Cache;
if (objvgs_RTqa_PaperRela_Cond.sf_FldComparisonOp == null || objvgs_RTqa_PaperRela_Cond.sf_FldComparisonOp == "") return arrvgs_RTqa_PaperRela_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvgs_RTqa_PaperRela_Cond.sf_FldComparisonOp);
//console.log("clsvgs_RTqa_PaperRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvgs_RTqa_PaperRela_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvgs_RTqa_PaperRela_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvgs_RTqa_PaperRela_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objvgs_RTqa_PaperRela_Cond), vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
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
export async function vgs_RTqa_PaperRela_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(vgs_RTqa_PaperRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
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
 * @param lngmId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function vgs_RTqa_PaperRela_IsExist(lngmId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vgs_RTqa_PaperRela_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"mId": lngmId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
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
 * @param lngmId:所给的关键字
 * @returns 对象
*/
export async function vgs_RTqa_PaperRela_IsExist_Cache(lngmId:number,strTopicId:string) {
const strThisFuncName = "IsExist_Cache";
const arrvgs_RTqa_PaperRelaObjLst_Cache = await vgs_RTqa_PaperRela_GetObjLst_Cache(strTopicId);
if (arrvgs_RTqa_PaperRelaObjLst_Cache == null) return false;
try
{
const arrvgs_RTqa_PaperRela_Sel: Array <clsvgs_RTqa_PaperRelaEN> = arrvgs_RTqa_PaperRelaObjLst_Cache.filter(x => x.mId == lngmId);
if (arrvgs_RTqa_PaperRela_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngmId, vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param lngmId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function vgs_RTqa_PaperRela_IsExistAsync(lngmId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vgs_RTqa_PaperRela_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "lngmId": lngmId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
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
export async function vgs_RTqa_PaperRela_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(vgs_RTqa_PaperRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
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
 * @param objvgs_RTqa_PaperRela_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function vgs_RTqa_PaperRela_GetRecCountByCond_Cache(objvgs_RTqa_PaperRela_Cond: clsvgs_RTqa_PaperRelaEN,strTopicId: string) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrvgs_RTqa_PaperRelaObjLst_Cache = await vgs_RTqa_PaperRela_GetObjLst_Cache(strTopicId);
if (arrvgs_RTqa_PaperRelaObjLst_Cache == null) return 0;
let arrvgs_RTqa_PaperRela_Sel: Array < clsvgs_RTqa_PaperRelaEN > = arrvgs_RTqa_PaperRelaObjLst_Cache;
if (objvgs_RTqa_PaperRela_Cond.sf_FldComparisonOp == null || objvgs_RTqa_PaperRela_Cond.sf_FldComparisonOp == "") return arrvgs_RTqa_PaperRela_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvgs_RTqa_PaperRela_Cond.sf_FldComparisonOp);
//console.log("clsvgs_RTqa_PaperRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvgs_RTqa_PaperRela_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvgs_RTqa_PaperRela_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvgs_RTqa_PaperRela_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objvgs_RTqa_PaperRela_Cond), vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
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
export function vgs_RTqa_PaperRela_GetWebApiUrl(strController: string, strAction: string): string {
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
export function vgs_RTqa_PaperRela_ReFreshThisCache(strTopicId: string):void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = Format("{0}_{1}", clsvgs_RTqa_PaperRelaEN._CurrTabName, strTopicId);
switch (clsvgs_RTqa_PaperRelaEN.CacheModeId)
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
export function vgs_RTqa_PaperRela_GetJSONStrByObj (pobjvgs_RTqa_PaperRelaEN: clsvgs_RTqa_PaperRelaEN): string
{
const strThisFuncName = "GetJSONStrByObj";
let strJson = "";
try
{
strJson = JSON.stringify(pobjvgs_RTqa_PaperRelaEN);
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
export function vgs_RTqa_PaperRela_GetObjLstByJSONStr (strJSON: string): Array<clsvgs_RTqa_PaperRelaEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrvgs_RTqa_PaperRelaObjLst = new Array<clsvgs_RTqa_PaperRelaEN>();
if (strJSON === "")
{
return arrvgs_RTqa_PaperRelaObjLst;
}
try
{
arrvgs_RTqa_PaperRelaObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvgs_RTqa_PaperRelaObjLst;
}
return arrvgs_RTqa_PaperRelaObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrvgs_RTqa_PaperRelaObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function vgs_RTqa_PaperRela_GetObjLstByJSONObjLst (arrvgs_RTqa_PaperRelaObjLstS: Array<clsvgs_RTqa_PaperRelaEN>): Array<clsvgs_RTqa_PaperRelaEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrvgs_RTqa_PaperRelaObjLst = new Array<clsvgs_RTqa_PaperRelaEN>();
for (const objInFor of arrvgs_RTqa_PaperRelaObjLstS) {
const obj1 = vgs_RTqa_PaperRela_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrvgs_RTqa_PaperRelaObjLst.push(obj1);
}
return arrvgs_RTqa_PaperRelaObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vgs_RTqa_PaperRela_GetObjByJSONStr (strJSON: string): clsvgs_RTqa_PaperRelaEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjvgs_RTqa_PaperRelaEN = new clsvgs_RTqa_PaperRelaEN();
if (strJSON === "")
{
return pobjvgs_RTqa_PaperRelaEN;
}
try
{
pobjvgs_RTqa_PaperRelaEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvgs_RTqa_PaperRelaEN;
}
return pobjvgs_RTqa_PaperRelaEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function vgs_RTqa_PaperRela_GetCombineCondition(objvgs_RTqa_PaperRela_Cond: clsvgs_RTqa_PaperRelaEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp, clsvgs_RTqa_PaperRelaEN.con_mId) == true)
{
const strComparisonOp_mId:string = objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp[clsvgs_RTqa_PaperRelaEN.con_mId];
strWhereCond += Format(" And {0} {2} {1}", clsvgs_RTqa_PaperRelaEN.con_mId, objvgs_RTqa_PaperRela_Cond.mId, strComparisonOp_mId);
}
if (Object.prototype.hasOwnProperty.call(objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp, clsvgs_RTqa_PaperRelaEN.con_TopicId) == true)
{
const strComparisonOp_TopicId:string = objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp[clsvgs_RTqa_PaperRelaEN.con_TopicId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_RTqa_PaperRelaEN.con_TopicId, objvgs_RTqa_PaperRela_Cond.topicId, strComparisonOp_TopicId);
}
if (Object.prototype.hasOwnProperty.call(objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp, clsvgs_RTqa_PaperRelaEN.con_TopicName) == true)
{
const strComparisonOp_TopicName:string = objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp[clsvgs_RTqa_PaperRelaEN.con_TopicName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_RTqa_PaperRelaEN.con_TopicName, objvgs_RTqa_PaperRela_Cond.topicName, strComparisonOp_TopicName);
}
if (Object.prototype.hasOwnProperty.call(objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp, clsvgs_RTqa_PaperRelaEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp[clsvgs_RTqa_PaperRelaEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_RTqa_PaperRelaEN.con_id_CurrEduCls, objvgs_RTqa_PaperRela_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (Object.prototype.hasOwnProperty.call(objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp, clsvgs_RTqa_PaperRelaEN.con_qa_PaperId) == true)
{
const strComparisonOp_qa_PaperId:string = objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp[clsvgs_RTqa_PaperRelaEN.con_qa_PaperId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_RTqa_PaperRelaEN.con_qa_PaperId, objvgs_RTqa_PaperRela_Cond.qa_PaperId, strComparisonOp_qa_PaperId);
}
if (Object.prototype.hasOwnProperty.call(objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp, clsvgs_RTqa_PaperRelaEN.con_PaperId) == true)
{
const strComparisonOp_PaperId:string = objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp[clsvgs_RTqa_PaperRelaEN.con_PaperId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_RTqa_PaperRelaEN.con_PaperId, objvgs_RTqa_PaperRela_Cond.paperId, strComparisonOp_PaperId);
}
if (Object.prototype.hasOwnProperty.call(objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp, clsvgs_RTqa_PaperRelaEN.con_QuestionsCount) == true)
{
const strComparisonOp_QuestionsCount:string = objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp[clsvgs_RTqa_PaperRelaEN.con_QuestionsCount];
strWhereCond += Format(" And {0} {2} {1}", clsvgs_RTqa_PaperRelaEN.con_QuestionsCount, objvgs_RTqa_PaperRela_Cond.questionsCount, strComparisonOp_QuestionsCount);
}
if (Object.prototype.hasOwnProperty.call(objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp, clsvgs_RTqa_PaperRelaEN.con_IsPublic) == true)
{
if (objvgs_RTqa_PaperRela_Cond.isPublic == true)
{
strWhereCond += Format(" And {0} = '1'", clsvgs_RTqa_PaperRelaEN.con_IsPublic);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvgs_RTqa_PaperRelaEN.con_IsPublic);
}
}
if (Object.prototype.hasOwnProperty.call(objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp, clsvgs_RTqa_PaperRelaEN.con_IsSubmit) == true)
{
if (objvgs_RTqa_PaperRela_Cond.isSubmit == true)
{
strWhereCond += Format(" And {0} = '1'", clsvgs_RTqa_PaperRelaEN.con_IsSubmit);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvgs_RTqa_PaperRelaEN.con_IsSubmit);
}
}
if (Object.prototype.hasOwnProperty.call(objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp, clsvgs_RTqa_PaperRelaEN.con_PaperTitle) == true)
{
const strComparisonOp_PaperTitle:string = objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp[clsvgs_RTqa_PaperRelaEN.con_PaperTitle];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_RTqa_PaperRelaEN.con_PaperTitle, objvgs_RTqa_PaperRela_Cond.paperTitle, strComparisonOp_PaperTitle);
}
if (Object.prototype.hasOwnProperty.call(objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp, clsvgs_RTqa_PaperRelaEN.con_AttachmentCount) == true)
{
const strComparisonOp_AttachmentCount:string = objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp[clsvgs_RTqa_PaperRelaEN.con_AttachmentCount];
strWhereCond += Format(" And {0} {2} {1}", clsvgs_RTqa_PaperRelaEN.con_AttachmentCount, objvgs_RTqa_PaperRela_Cond.attachmentCount, strComparisonOp_AttachmentCount);
}
if (Object.prototype.hasOwnProperty.call(objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp, clsvgs_RTqa_PaperRelaEN.con_AnswerCount) == true)
{
const strComparisonOp_AnswerCount:string = objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp[clsvgs_RTqa_PaperRelaEN.con_AnswerCount];
strWhereCond += Format(" And {0} {2} {1}", clsvgs_RTqa_PaperRelaEN.con_AnswerCount, objvgs_RTqa_PaperRela_Cond.answerCount, strComparisonOp_AnswerCount);
}
if (Object.prototype.hasOwnProperty.call(objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp, clsvgs_RTqa_PaperRelaEN.con_ShareId) == true)
{
const strComparisonOp_ShareId:string = objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp[clsvgs_RTqa_PaperRelaEN.con_ShareId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_RTqa_PaperRelaEN.con_ShareId, objvgs_RTqa_PaperRela_Cond.shareId, strComparisonOp_ShareId);
}
if (Object.prototype.hasOwnProperty.call(objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp, clsvgs_RTqa_PaperRelaEN.con_TagsCount) == true)
{
const strComparisonOp_TagsCount:string = objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp[clsvgs_RTqa_PaperRelaEN.con_TagsCount];
strWhereCond += Format(" And {0} {2} {1}", clsvgs_RTqa_PaperRelaEN.con_TagsCount, objvgs_RTqa_PaperRela_Cond.tagsCount, strComparisonOp_TagsCount);
}
if (Object.prototype.hasOwnProperty.call(objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp, clsvgs_RTqa_PaperRelaEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp[clsvgs_RTqa_PaperRelaEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_RTqa_PaperRelaEN.con_UpdDate, objvgs_RTqa_PaperRela_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp, clsvgs_RTqa_PaperRelaEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp[clsvgs_RTqa_PaperRelaEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_RTqa_PaperRelaEN.con_UpdUser, objvgs_RTqa_PaperRela_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp, clsvgs_RTqa_PaperRelaEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp[clsvgs_RTqa_PaperRelaEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_RTqa_PaperRelaEN.con_Memo, objvgs_RTqa_PaperRela_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp, clsvgs_RTqa_PaperRelaEN.con_qaUser) == true)
{
const strComparisonOp_qaUser:string = objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp[clsvgs_RTqa_PaperRelaEN.con_qaUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_RTqa_PaperRelaEN.con_qaUser, objvgs_RTqa_PaperRela_Cond.qaUser, strComparisonOp_qaUser);
}
if (Object.prototype.hasOwnProperty.call(objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp, clsvgs_RTqa_PaperRelaEN.con_qaDate) == true)
{
const strComparisonOp_qaDate:string = objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp[clsvgs_RTqa_PaperRelaEN.con_qaDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_RTqa_PaperRelaEN.con_qaDate, objvgs_RTqa_PaperRela_Cond.qaDate, strComparisonOp_qaDate);
}
if (Object.prototype.hasOwnProperty.call(objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp, clsvgs_RTqa_PaperRelaEN.con_qaUserName) == true)
{
const strComparisonOp_qaUserName:string = objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp[clsvgs_RTqa_PaperRelaEN.con_qaUserName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_RTqa_PaperRelaEN.con_qaUserName, objvgs_RTqa_PaperRela_Cond.qaUserName, strComparisonOp_qaUserName);
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objvgs_RTqa_PaperRelaENS:源对象
 * @param objvgs_RTqa_PaperRelaENT:目标对象
*/
export function vgs_RTqa_PaperRela_CopyObjTo(objvgs_RTqa_PaperRelaENS: clsvgs_RTqa_PaperRelaEN , objvgs_RTqa_PaperRelaENT: clsvgs_RTqa_PaperRelaEN ): void 
{
objvgs_RTqa_PaperRelaENT.mId = objvgs_RTqa_PaperRelaENS.mId; //mId
objvgs_RTqa_PaperRelaENT.topicId = objvgs_RTqa_PaperRelaENS.topicId; //主题Id
objvgs_RTqa_PaperRelaENT.topicName = objvgs_RTqa_PaperRelaENS.topicName; //栏目主题
objvgs_RTqa_PaperRelaENT.id_CurrEduCls = objvgs_RTqa_PaperRelaENS.id_CurrEduCls; //教学班流水号
objvgs_RTqa_PaperRelaENT.qa_PaperId = objvgs_RTqa_PaperRelaENS.qa_PaperId; //论文答疑Id
objvgs_RTqa_PaperRelaENT.paperId = objvgs_RTqa_PaperRelaENS.paperId; //论文Id
objvgs_RTqa_PaperRelaENT.questionsCount = objvgs_RTqa_PaperRelaENS.questionsCount; //提问计数
objvgs_RTqa_PaperRelaENT.isPublic = objvgs_RTqa_PaperRelaENS.isPublic; //是否公开
objvgs_RTqa_PaperRelaENT.isSubmit = objvgs_RTqa_PaperRelaENS.isSubmit; //是否提交
objvgs_RTqa_PaperRelaENT.paperTitle = objvgs_RTqa_PaperRelaENS.paperTitle; //论文标题
objvgs_RTqa_PaperRelaENT.attachmentCount = objvgs_RTqa_PaperRelaENS.attachmentCount; //附件计数
objvgs_RTqa_PaperRelaENT.answerCount = objvgs_RTqa_PaperRelaENS.answerCount; //回答计数
objvgs_RTqa_PaperRelaENT.shareId = objvgs_RTqa_PaperRelaENS.shareId; //分享Id
objvgs_RTqa_PaperRelaENT.tagsCount = objvgs_RTqa_PaperRelaENS.tagsCount; //论文标注数
objvgs_RTqa_PaperRelaENT.updDate = objvgs_RTqa_PaperRelaENS.updDate; //修改日期
objvgs_RTqa_PaperRelaENT.updUser = objvgs_RTqa_PaperRelaENS.updUser; //修改人
objvgs_RTqa_PaperRelaENT.memo = objvgs_RTqa_PaperRelaENS.memo; //备注
objvgs_RTqa_PaperRelaENT.qaUser = objvgs_RTqa_PaperRelaENS.qaUser; //qaUser
objvgs_RTqa_PaperRelaENT.qaDate = objvgs_RTqa_PaperRelaENS.qaDate; //qaDate
objvgs_RTqa_PaperRelaENT.qaUserName = objvgs_RTqa_PaperRelaENS.qaUserName; //qaUserName
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objvgs_RTqa_PaperRelaENS:源对象
 * @param objvgs_RTqa_PaperRelaENT:目标对象
*/
export function vgs_RTqa_PaperRela_GetObjFromJsonObj(objvgs_RTqa_PaperRelaENS: clsvgs_RTqa_PaperRelaEN): clsvgs_RTqa_PaperRelaEN 
{
 const objvgs_RTqa_PaperRelaENT: clsvgs_RTqa_PaperRelaEN = new clsvgs_RTqa_PaperRelaEN();
ObjectAssign(objvgs_RTqa_PaperRelaENT, objvgs_RTqa_PaperRelaENS);
 return objvgs_RTqa_PaperRelaENT;
}