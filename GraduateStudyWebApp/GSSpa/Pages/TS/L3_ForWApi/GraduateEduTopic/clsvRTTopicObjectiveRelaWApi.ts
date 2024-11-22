
 /**
 * 类名:clsvRTTopicObjectiveRelaWApi
 * 表名:vRTTopicObjectiveRela(01120616)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 12:02:50
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
 * vRTTopicObjectiveRela(vRTTopicObjectiveRela)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clsvRTTopicObjectiveRelaEN } from "../../L0_Entity/GraduateEduTopic/clsvRTTopicObjectiveRelaEN.js";
import { BindDdl_ObjLstInDiv_V, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const vRTTopicObjectiveRela_Controller = "vRTTopicObjectiveRelaApi";
 export const vRTTopicObjectiveRela_ConstructorName = "vRTTopicObjectiveRela";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngmId:关键字
 * @returns 对象
 **/
export async function vRTTopicObjectiveRela_GetObjBymIdAsync(lngmId: number): Promise<clsvRTTopicObjectiveRelaEN>  
{
const strThisFuncName = "GetObjBymIdAsync";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In GetObjBymIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjBymId";
const strUrl = GetWebApiUrl(vRTTopicObjectiveRela_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vRTTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvRTTopicObjectiveRela = vRTTopicObjectiveRela_GetObjFromJsonObj(returnObj);
return objvRTTopicObjectiveRela;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export async function vRTTopicObjectiveRela_GetObjBymId_Cache(lngmId: number, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjBymId_Cache";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In GetObjBymId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
const arrvRTTopicObjectiveRelaObjLst_Cache = await vRTTopicObjectiveRela_GetObjLst_Cache();
try
{
const arrvRTTopicObjectiveRela_Sel: Array <clsvRTTopicObjectiveRelaEN> = arrvRTTopicObjectiveRelaObjLst_Cache.filter(x => x.mId == lngmId);
let objvRTTopicObjectiveRela: clsvRTTopicObjectiveRelaEN;
if (arrvRTTopicObjectiveRela_Sel.length > 0)
{
objvRTTopicObjectiveRela = arrvRTTopicObjectiveRela_Sel[0];
return objvRTTopicObjectiveRela;
}
else
{
if (bolTryAsyncOnce == true)
{
objvRTTopicObjectiveRela = await vRTTopicObjectiveRela_GetObjBymIdAsync(lngmId);
if (objvRTTopicObjectiveRela != null)
{
vRTTopicObjectiveRela_ReFreshThisCache();
return objvRTTopicObjectiveRela;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, vRTTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export async function vRTTopicObjectiveRela_GetObjBymId_localStorage(lngmId: number) {
const strThisFuncName = "GetObjBymId_localStorage";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In GetObjBymId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
const strKey = Format("{0}_{1}", clsvRTTopicObjectiveRelaEN._CurrTabName, lngmId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objvRTTopicObjectiveRela_Cache: clsvRTTopicObjectiveRelaEN = JSON.parse(strTempObj);
return objvRTTopicObjectiveRela_Cache;
}
try
{
const objvRTTopicObjectiveRela = await vRTTopicObjectiveRela_GetObjBymIdAsync(lngmId);
if (objvRTTopicObjectiveRela != null)
{
localStorage.setItem(strKey, JSON.stringify(objvRTTopicObjectiveRela));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objvRTTopicObjectiveRela;
}
return objvRTTopicObjectiveRela;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, vRTTopicObjectiveRela_ConstructorName, strThisFuncName);
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
 * @returns 返回一个输出字段值
*/
export async function vRTTopicObjectiveRela_func(strInFldName:string , strOutFldName:string ,  strInValue: string) 
{
//const strThisFuncName = "func";

if (strInFldName != clsvRTTopicObjectiveRelaEN.con_mId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsvRTTopicObjectiveRelaEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clsvRTTopicObjectiveRelaEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const lngmId = Number(strInValue);
if (lngmId == 0)
{
return "";
}
const objvRTTopicObjectiveRela = await vRTTopicObjectiveRela_GetObjBymId_Cache(lngmId );
if (objvRTTopicObjectiveRela == null) return "";
return objvRTTopicObjectiveRela.GetFldValue(strOutFldName).toString();
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
export function vRTTopicObjectiveRela_SortFun_Defa(a:clsvRTTopicObjectiveRelaEN , b:clsvRTTopicObjectiveRelaEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.mId-b.mId;
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
export function vRTTopicObjectiveRela_SortFun_Defa_2Fld(a:clsvRTTopicObjectiveRelaEN , b:clsvRTTopicObjectiveRelaEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.topicId == b.topicId) return a.topicObjectiveId.localeCompare(b.topicObjectiveId);
else return a.topicId.localeCompare(b.topicId);
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
export function vRTTopicObjectiveRela_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsvRTTopicObjectiveRelaEN.con_mId:
return (a: clsvRTTopicObjectiveRelaEN, b: clsvRTTopicObjectiveRelaEN) => {
return a.mId-b.mId;
}
case clsvRTTopicObjectiveRelaEN.con_TopicId:
return (a: clsvRTTopicObjectiveRelaEN, b: clsvRTTopicObjectiveRelaEN) => {
return a.topicId.localeCompare(b.topicId);
}
case clsvRTTopicObjectiveRelaEN.con_TopicObjectiveId:
return (a: clsvRTTopicObjectiveRelaEN, b: clsvRTTopicObjectiveRelaEN) => {
return a.topicObjectiveId.localeCompare(b.topicObjectiveId);
}
case clsvRTTopicObjectiveRelaEN.con_UpdDate:
return (a: clsvRTTopicObjectiveRelaEN, b: clsvRTTopicObjectiveRelaEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsvRTTopicObjectiveRelaEN.con_UpdUser:
return (a: clsvRTTopicObjectiveRelaEN, b: clsvRTTopicObjectiveRelaEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsvRTTopicObjectiveRelaEN.con_ObjectiveTypeName:
return (a: clsvRTTopicObjectiveRelaEN, b: clsvRTTopicObjectiveRelaEN) => {
return a.objectiveTypeName.localeCompare(b.objectiveTypeName);
}
case clsvRTTopicObjectiveRelaEN.con_ObjectiveType:
return (a: clsvRTTopicObjectiveRelaEN, b: clsvRTTopicObjectiveRelaEN) => {
return a.objectiveType.localeCompare(b.objectiveType);
}
case clsvRTTopicObjectiveRelaEN.con_SourceId:
return (a: clsvRTTopicObjectiveRelaEN, b: clsvRTTopicObjectiveRelaEN) => {
return a.sourceId.localeCompare(b.sourceId);
}
case clsvRTTopicObjectiveRelaEN.con_IsSubmit:
return (a: clsvRTTopicObjectiveRelaEN, b: clsvRTTopicObjectiveRelaEN) => {
if (a.isSubmit == true) return 1;
else return -1
}
case clsvRTTopicObjectiveRelaEN.con_ObjectiveName:
return (a: clsvRTTopicObjectiveRelaEN, b: clsvRTTopicObjectiveRelaEN) => {
return a.objectiveName.localeCompare(b.objectiveName);
}
case clsvRTTopicObjectiveRelaEN.con_ObjectiveContent:
return (a: clsvRTTopicObjectiveRelaEN, b: clsvRTTopicObjectiveRelaEN) => {
return a.objectiveContent.localeCompare(b.objectiveContent);
}
case clsvRTTopicObjectiveRelaEN.con_Conclusion:
return (a: clsvRTTopicObjectiveRelaEN, b: clsvRTTopicObjectiveRelaEN) => {
return a.conclusion.localeCompare(b.conclusion);
}
case clsvRTTopicObjectiveRelaEN.con_TopicContent:
return (a: clsvRTTopicObjectiveRelaEN, b: clsvRTTopicObjectiveRelaEN) => {
return a.topicContent.localeCompare(b.topicContent);
}
case clsvRTTopicObjectiveRelaEN.con_TopicName:
return (a: clsvRTTopicObjectiveRelaEN, b: clsvRTTopicObjectiveRelaEN) => {
return a.topicName.localeCompare(b.topicName);
}
case clsvRTTopicObjectiveRelaEN.con_AppraiseCount:
return (a: clsvRTTopicObjectiveRelaEN, b: clsvRTTopicObjectiveRelaEN) => {
return a.appraiseCount-b.appraiseCount;
}
case clsvRTTopicObjectiveRelaEN.con_CitationCount:
return (a: clsvRTTopicObjectiveRelaEN, b: clsvRTTopicObjectiveRelaEN) => {
return a.citationCount-b.citationCount;
}
case clsvRTTopicObjectiveRelaEN.con_score:
return (a: clsvRTTopicObjectiveRelaEN, b: clsvRTTopicObjectiveRelaEN) => {
return a.score-b.score;
}
case clsvRTTopicObjectiveRelaEN.con_StuScore:
return (a: clsvRTTopicObjectiveRelaEN, b: clsvRTTopicObjectiveRelaEN) => {
return a.stuScore-b.stuScore;
}
case clsvRTTopicObjectiveRelaEN.con_TeaScore:
return (a: clsvRTTopicObjectiveRelaEN, b: clsvRTTopicObjectiveRelaEN) => {
return a.teaScore-b.teaScore;
}
case clsvRTTopicObjectiveRelaEN.con_ObjDate:
return (a: clsvRTTopicObjectiveRelaEN, b: clsvRTTopicObjectiveRelaEN) => {
return a.objDate.localeCompare(b.objDate);
}
case clsvRTTopicObjectiveRelaEN.con_ObjUserId:
return (a: clsvRTTopicObjectiveRelaEN, b: clsvRTTopicObjectiveRelaEN) => {
return a.objUserId.localeCompare(b.objUserId);
}
case clsvRTTopicObjectiveRelaEN.con_id_CurrEduCls:
return (a: clsvRTTopicObjectiveRelaEN, b: clsvRTTopicObjectiveRelaEN) => {
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
case clsvRTTopicObjectiveRelaEN.con_PdfContent:
return (a: clsvRTTopicObjectiveRelaEN, b: clsvRTTopicObjectiveRelaEN) => {
return a.pdfContent.localeCompare(b.pdfContent);
}
case clsvRTTopicObjectiveRelaEN.con_PdfPageNum:
return (a: clsvRTTopicObjectiveRelaEN, b: clsvRTTopicObjectiveRelaEN) => {
return a.pdfPageNum-b.pdfPageNum;
}
case clsvRTTopicObjectiveRelaEN.con_OkCount:
return (a: clsvRTTopicObjectiveRelaEN, b: clsvRTTopicObjectiveRelaEN) => {
return a.okCount-b.okCount;
}
case clsvRTTopicObjectiveRelaEN.con_VersionCount:
return (a: clsvRTTopicObjectiveRelaEN, b: clsvRTTopicObjectiveRelaEN) => {
return a.versionCount-b.versionCount;
}
case clsvRTTopicObjectiveRelaEN.con_CreateDate:
return (a: clsvRTTopicObjectiveRelaEN, b: clsvRTTopicObjectiveRelaEN) => {
return a.createDate.localeCompare(b.createDate);
}
case clsvRTTopicObjectiveRelaEN.con_ShareId:
return (a: clsvRTTopicObjectiveRelaEN, b: clsvRTTopicObjectiveRelaEN) => {
return a.shareId.localeCompare(b.shareId);
}
case clsvRTTopicObjectiveRelaEN.con_ClassificationId:
return (a: clsvRTTopicObjectiveRelaEN, b: clsvRTTopicObjectiveRelaEN) => {
return a.classificationId.localeCompare(b.classificationId);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vRTTopicObjectiveRela]中不存在！(in ${ vRTTopicObjectiveRela_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsvRTTopicObjectiveRelaEN.con_mId:
return (a: clsvRTTopicObjectiveRelaEN, b: clsvRTTopicObjectiveRelaEN) => {
return b.mId-a.mId;
}
case clsvRTTopicObjectiveRelaEN.con_TopicId:
return (a: clsvRTTopicObjectiveRelaEN, b: clsvRTTopicObjectiveRelaEN) => {
return b.topicId.localeCompare(a.topicId);
}
case clsvRTTopicObjectiveRelaEN.con_TopicObjectiveId:
return (a: clsvRTTopicObjectiveRelaEN, b: clsvRTTopicObjectiveRelaEN) => {
return b.topicObjectiveId.localeCompare(a.topicObjectiveId);
}
case clsvRTTopicObjectiveRelaEN.con_UpdDate:
return (a: clsvRTTopicObjectiveRelaEN, b: clsvRTTopicObjectiveRelaEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsvRTTopicObjectiveRelaEN.con_UpdUser:
return (a: clsvRTTopicObjectiveRelaEN, b: clsvRTTopicObjectiveRelaEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsvRTTopicObjectiveRelaEN.con_ObjectiveTypeName:
return (a: clsvRTTopicObjectiveRelaEN, b: clsvRTTopicObjectiveRelaEN) => {
return b.objectiveTypeName.localeCompare(a.objectiveTypeName);
}
case clsvRTTopicObjectiveRelaEN.con_ObjectiveType:
return (a: clsvRTTopicObjectiveRelaEN, b: clsvRTTopicObjectiveRelaEN) => {
return b.objectiveType.localeCompare(a.objectiveType);
}
case clsvRTTopicObjectiveRelaEN.con_SourceId:
return (a: clsvRTTopicObjectiveRelaEN, b: clsvRTTopicObjectiveRelaEN) => {
return b.sourceId.localeCompare(a.sourceId);
}
case clsvRTTopicObjectiveRelaEN.con_IsSubmit:
return (a: clsvRTTopicObjectiveRelaEN, b: clsvRTTopicObjectiveRelaEN) => {
if (b.isSubmit == true) return 1;
else return -1
}
case clsvRTTopicObjectiveRelaEN.con_ObjectiveName:
return (a: clsvRTTopicObjectiveRelaEN, b: clsvRTTopicObjectiveRelaEN) => {
return b.objectiveName.localeCompare(a.objectiveName);
}
case clsvRTTopicObjectiveRelaEN.con_ObjectiveContent:
return (a: clsvRTTopicObjectiveRelaEN, b: clsvRTTopicObjectiveRelaEN) => {
return b.objectiveContent.localeCompare(a.objectiveContent);
}
case clsvRTTopicObjectiveRelaEN.con_Conclusion:
return (a: clsvRTTopicObjectiveRelaEN, b: clsvRTTopicObjectiveRelaEN) => {
return b.conclusion.localeCompare(a.conclusion);
}
case clsvRTTopicObjectiveRelaEN.con_TopicContent:
return (a: clsvRTTopicObjectiveRelaEN, b: clsvRTTopicObjectiveRelaEN) => {
return b.topicContent.localeCompare(a.topicContent);
}
case clsvRTTopicObjectiveRelaEN.con_TopicName:
return (a: clsvRTTopicObjectiveRelaEN, b: clsvRTTopicObjectiveRelaEN) => {
return b.topicName.localeCompare(a.topicName);
}
case clsvRTTopicObjectiveRelaEN.con_AppraiseCount:
return (a: clsvRTTopicObjectiveRelaEN, b: clsvRTTopicObjectiveRelaEN) => {
return b.appraiseCount-a.appraiseCount;
}
case clsvRTTopicObjectiveRelaEN.con_CitationCount:
return (a: clsvRTTopicObjectiveRelaEN, b: clsvRTTopicObjectiveRelaEN) => {
return b.citationCount-a.citationCount;
}
case clsvRTTopicObjectiveRelaEN.con_score:
return (a: clsvRTTopicObjectiveRelaEN, b: clsvRTTopicObjectiveRelaEN) => {
return b.score-a.score;
}
case clsvRTTopicObjectiveRelaEN.con_StuScore:
return (a: clsvRTTopicObjectiveRelaEN, b: clsvRTTopicObjectiveRelaEN) => {
return b.stuScore-a.stuScore;
}
case clsvRTTopicObjectiveRelaEN.con_TeaScore:
return (a: clsvRTTopicObjectiveRelaEN, b: clsvRTTopicObjectiveRelaEN) => {
return b.teaScore-a.teaScore;
}
case clsvRTTopicObjectiveRelaEN.con_ObjDate:
return (a: clsvRTTopicObjectiveRelaEN, b: clsvRTTopicObjectiveRelaEN) => {
return b.objDate.localeCompare(a.objDate);
}
case clsvRTTopicObjectiveRelaEN.con_ObjUserId:
return (a: clsvRTTopicObjectiveRelaEN, b: clsvRTTopicObjectiveRelaEN) => {
return b.objUserId.localeCompare(a.objUserId);
}
case clsvRTTopicObjectiveRelaEN.con_id_CurrEduCls:
return (a: clsvRTTopicObjectiveRelaEN, b: clsvRTTopicObjectiveRelaEN) => {
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
case clsvRTTopicObjectiveRelaEN.con_PdfContent:
return (a: clsvRTTopicObjectiveRelaEN, b: clsvRTTopicObjectiveRelaEN) => {
return b.pdfContent.localeCompare(a.pdfContent);
}
case clsvRTTopicObjectiveRelaEN.con_PdfPageNum:
return (a: clsvRTTopicObjectiveRelaEN, b: clsvRTTopicObjectiveRelaEN) => {
return b.pdfPageNum-a.pdfPageNum;
}
case clsvRTTopicObjectiveRelaEN.con_OkCount:
return (a: clsvRTTopicObjectiveRelaEN, b: clsvRTTopicObjectiveRelaEN) => {
return b.okCount-a.okCount;
}
case clsvRTTopicObjectiveRelaEN.con_VersionCount:
return (a: clsvRTTopicObjectiveRelaEN, b: clsvRTTopicObjectiveRelaEN) => {
return b.versionCount-a.versionCount;
}
case clsvRTTopicObjectiveRelaEN.con_CreateDate:
return (a: clsvRTTopicObjectiveRelaEN, b: clsvRTTopicObjectiveRelaEN) => {
return b.createDate.localeCompare(a.createDate);
}
case clsvRTTopicObjectiveRelaEN.con_ShareId:
return (a: clsvRTTopicObjectiveRelaEN, b: clsvRTTopicObjectiveRelaEN) => {
return b.shareId.localeCompare(a.shareId);
}
case clsvRTTopicObjectiveRelaEN.con_ClassificationId:
return (a: clsvRTTopicObjectiveRelaEN, b: clsvRTTopicObjectiveRelaEN) => {
return b.classificationId.localeCompare(a.classificationId);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vRTTopicObjectiveRela]中不存在！(in ${ vRTTopicObjectiveRela_ConstructorName}.${ strThisFuncName})`;
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
export async function vRTTopicObjectiveRela_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsvRTTopicObjectiveRelaEN.con_mId:
return (obj: clsvRTTopicObjectiveRelaEN) => {
return obj.mId === value;
}
case clsvRTTopicObjectiveRelaEN.con_TopicId:
return (obj: clsvRTTopicObjectiveRelaEN) => {
return obj.topicId === value;
}
case clsvRTTopicObjectiveRelaEN.con_TopicObjectiveId:
return (obj: clsvRTTopicObjectiveRelaEN) => {
return obj.topicObjectiveId === value;
}
case clsvRTTopicObjectiveRelaEN.con_UpdDate:
return (obj: clsvRTTopicObjectiveRelaEN) => {
return obj.updDate === value;
}
case clsvRTTopicObjectiveRelaEN.con_UpdUser:
return (obj: clsvRTTopicObjectiveRelaEN) => {
return obj.updUser === value;
}
case clsvRTTopicObjectiveRelaEN.con_ObjectiveTypeName:
return (obj: clsvRTTopicObjectiveRelaEN) => {
return obj.objectiveTypeName === value;
}
case clsvRTTopicObjectiveRelaEN.con_ObjectiveType:
return (obj: clsvRTTopicObjectiveRelaEN) => {
return obj.objectiveType === value;
}
case clsvRTTopicObjectiveRelaEN.con_SourceId:
return (obj: clsvRTTopicObjectiveRelaEN) => {
return obj.sourceId === value;
}
case clsvRTTopicObjectiveRelaEN.con_IsSubmit:
return (obj: clsvRTTopicObjectiveRelaEN) => {
return obj.isSubmit === value;
}
case clsvRTTopicObjectiveRelaEN.con_ObjectiveName:
return (obj: clsvRTTopicObjectiveRelaEN) => {
return obj.objectiveName === value;
}
case clsvRTTopicObjectiveRelaEN.con_ObjectiveContent:
return (obj: clsvRTTopicObjectiveRelaEN) => {
return obj.objectiveContent === value;
}
case clsvRTTopicObjectiveRelaEN.con_Conclusion:
return (obj: clsvRTTopicObjectiveRelaEN) => {
return obj.conclusion === value;
}
case clsvRTTopicObjectiveRelaEN.con_TopicContent:
return (obj: clsvRTTopicObjectiveRelaEN) => {
return obj.topicContent === value;
}
case clsvRTTopicObjectiveRelaEN.con_TopicName:
return (obj: clsvRTTopicObjectiveRelaEN) => {
return obj.topicName === value;
}
case clsvRTTopicObjectiveRelaEN.con_AppraiseCount:
return (obj: clsvRTTopicObjectiveRelaEN) => {
return obj.appraiseCount === value;
}
case clsvRTTopicObjectiveRelaEN.con_CitationCount:
return (obj: clsvRTTopicObjectiveRelaEN) => {
return obj.citationCount === value;
}
case clsvRTTopicObjectiveRelaEN.con_score:
return (obj: clsvRTTopicObjectiveRelaEN) => {
return obj.score === value;
}
case clsvRTTopicObjectiveRelaEN.con_StuScore:
return (obj: clsvRTTopicObjectiveRelaEN) => {
return obj.stuScore === value;
}
case clsvRTTopicObjectiveRelaEN.con_TeaScore:
return (obj: clsvRTTopicObjectiveRelaEN) => {
return obj.teaScore === value;
}
case clsvRTTopicObjectiveRelaEN.con_ObjDate:
return (obj: clsvRTTopicObjectiveRelaEN) => {
return obj.objDate === value;
}
case clsvRTTopicObjectiveRelaEN.con_ObjUserId:
return (obj: clsvRTTopicObjectiveRelaEN) => {
return obj.objUserId === value;
}
case clsvRTTopicObjectiveRelaEN.con_id_CurrEduCls:
return (obj: clsvRTTopicObjectiveRelaEN) => {
return obj.id_CurrEduCls === value;
}
case clsvRTTopicObjectiveRelaEN.con_PdfContent:
return (obj: clsvRTTopicObjectiveRelaEN) => {
return obj.pdfContent === value;
}
case clsvRTTopicObjectiveRelaEN.con_PdfPageNum:
return (obj: clsvRTTopicObjectiveRelaEN) => {
return obj.pdfPageNum === value;
}
case clsvRTTopicObjectiveRelaEN.con_OkCount:
return (obj: clsvRTTopicObjectiveRelaEN) => {
return obj.okCount === value;
}
case clsvRTTopicObjectiveRelaEN.con_VersionCount:
return (obj: clsvRTTopicObjectiveRelaEN) => {
return obj.versionCount === value;
}
case clsvRTTopicObjectiveRelaEN.con_CreateDate:
return (obj: clsvRTTopicObjectiveRelaEN) => {
return obj.createDate === value;
}
case clsvRTTopicObjectiveRelaEN.con_ShareId:
return (obj: clsvRTTopicObjectiveRelaEN) => {
return obj.shareId === value;
}
case clsvRTTopicObjectiveRelaEN.con_ClassificationId:
return (obj: clsvRTTopicObjectiveRelaEN) => {
return obj.classificationId === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vRTTopicObjectiveRela]中不存在！(in ${ vRTTopicObjectiveRela_ConstructorName}.${ strThisFuncName})`;
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
export async function vRTTopicObjectiveRela_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vRTTopicObjectiveRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export async function vRTTopicObjectiveRela_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vRTTopicObjectiveRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export async function vRTTopicObjectiveRela_GetFirstObjAsync(strWhereCond: string): Promise<clsvRTTopicObjectiveRelaEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(vRTTopicObjectiveRela_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vRTTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvRTTopicObjectiveRela = vRTTopicObjectiveRela_GetObjFromJsonObj(returnObj);
return objvRTTopicObjectiveRela;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export async function vRTTopicObjectiveRela_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvRTTopicObjectiveRelaEN._CurrTabName;
clsvRTTopicObjectiveRelaEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvRTTopicObjectiveRelaEN._CurrTabName);
if (IsNullOrEmpty(clsvRTTopicObjectiveRelaEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvRTTopicObjectiveRelaEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrvRTTopicObjectiveRelaExObjLst_Cache: Array<clsvRTTopicObjectiveRelaEN> = CacheHelper.Get(strKey);
const arrvRTTopicObjectiveRelaObjLst_T = vRTTopicObjectiveRela_GetObjLstByJSONObjLst(arrvRTTopicObjectiveRelaExObjLst_Cache);
return arrvRTTopicObjectiveRelaObjLst_T;
}
try
{
const arrvRTTopicObjectiveRelaExObjLst = await vRTTopicObjectiveRela_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrvRTTopicObjectiveRelaExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvRTTopicObjectiveRelaExObjLst.length);
console.log(strInfo);
return arrvRTTopicObjectiveRelaExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vRTTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vRTTopicObjectiveRela_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvRTTopicObjectiveRelaEN._CurrTabName;
clsvRTTopicObjectiveRelaEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvRTTopicObjectiveRelaEN._CurrTabName);
if (IsNullOrEmpty(clsvRTTopicObjectiveRelaEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvRTTopicObjectiveRelaEN.CacheAddiCondition);
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
const arrvRTTopicObjectiveRelaExObjLst_Cache: Array<clsvRTTopicObjectiveRelaEN> = JSON.parse(strTempObjLst);
const arrvRTTopicObjectiveRelaObjLst_T = vRTTopicObjectiveRela_GetObjLstByJSONObjLst(arrvRTTopicObjectiveRelaExObjLst_Cache);
return arrvRTTopicObjectiveRelaObjLst_T;
}
try
{
const arrvRTTopicObjectiveRelaExObjLst = await vRTTopicObjectiveRela_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrvRTTopicObjectiveRelaExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvRTTopicObjectiveRelaExObjLst.length);
console.log(strInfo);
return arrvRTTopicObjectiveRelaExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vRTTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vRTTopicObjectiveRela_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsvRTTopicObjectiveRelaEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrvRTTopicObjectiveRelaObjLst_Cache: Array<clsvRTTopicObjectiveRelaEN> = JSON.parse(strTempObjLst);
return arrvRTTopicObjectiveRelaObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function vRTTopicObjectiveRela_GetObjLstAsync(strWhereCond: string): Promise<Array<clsvRTTopicObjectiveRelaEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(vRTTopicObjectiveRela_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vRTTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vRTTopicObjectiveRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export async function vRTTopicObjectiveRela_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvRTTopicObjectiveRelaEN._CurrTabName;
clsvRTTopicObjectiveRelaEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvRTTopicObjectiveRelaEN._CurrTabName);
if (IsNullOrEmpty(clsvRTTopicObjectiveRelaEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvRTTopicObjectiveRelaEN.CacheAddiCondition);
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
const arrvRTTopicObjectiveRelaExObjLst_Cache: Array<clsvRTTopicObjectiveRelaEN> = JSON.parse(strTempObjLst);
const arrvRTTopicObjectiveRelaObjLst_T = vRTTopicObjectiveRela_GetObjLstByJSONObjLst(arrvRTTopicObjectiveRelaExObjLst_Cache);
return arrvRTTopicObjectiveRelaObjLst_T;
}
try
{
const arrvRTTopicObjectiveRelaExObjLst = await vRTTopicObjectiveRela_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrvRTTopicObjectiveRelaExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvRTTopicObjectiveRelaExObjLst.length);
console.log(strInfo);
return arrvRTTopicObjectiveRelaExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vRTTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vRTTopicObjectiveRela_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsvRTTopicObjectiveRelaEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrvRTTopicObjectiveRelaObjLst_Cache: Array<clsvRTTopicObjectiveRelaEN> = JSON.parse(strTempObjLst);
return arrvRTTopicObjectiveRelaObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vRTTopicObjectiveRela_GetObjLst_Cache(): Promise<Array<clsvRTTopicObjectiveRelaEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrvRTTopicObjectiveRelaObjLst_Cache;
switch (clsvRTTopicObjectiveRelaEN.CacheModeId)
{
case "04"://sessionStorage
arrvRTTopicObjectiveRelaObjLst_Cache = await vRTTopicObjectiveRela_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrvRTTopicObjectiveRelaObjLst_Cache = await vRTTopicObjectiveRela_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrvRTTopicObjectiveRelaObjLst_Cache = await vRTTopicObjectiveRela_GetObjLst_ClientCache();
break;
default:
arrvRTTopicObjectiveRelaObjLst_Cache = await vRTTopicObjectiveRela_GetObjLst_ClientCache();
break;
}
const arrvRTTopicObjectiveRelaObjLst = vRTTopicObjectiveRela_GetObjLstByJSONObjLst(arrvRTTopicObjectiveRelaObjLst_Cache);
return arrvRTTopicObjectiveRelaObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vRTTopicObjectiveRela_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrvRTTopicObjectiveRelaObjLst_Cache;
switch (clsvRTTopicObjectiveRelaEN.CacheModeId)
{
case "04"://sessionStorage
arrvRTTopicObjectiveRelaObjLst_Cache = await vRTTopicObjectiveRela_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrvRTTopicObjectiveRelaObjLst_Cache = await vRTTopicObjectiveRela_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrvRTTopicObjectiveRelaObjLst_Cache = null;
break;
default:
arrvRTTopicObjectiveRelaObjLst_Cache = null;
break;
}
return arrvRTTopicObjectiveRelaObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objlngmId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vRTTopicObjectiveRela_GetSubObjLst_Cache(objvRTTopicObjectiveRela_Cond: clsvRTTopicObjectiveRelaEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrvRTTopicObjectiveRelaObjLst_Cache = await vRTTopicObjectiveRela_GetObjLst_Cache();
let arrvRTTopicObjectiveRela_Sel: Array < clsvRTTopicObjectiveRelaEN > = arrvRTTopicObjectiveRelaObjLst_Cache;
if (objvRTTopicObjectiveRela_Cond.sf_FldComparisonOp == null || objvRTTopicObjectiveRela_Cond.sf_FldComparisonOp == "") return arrvRTTopicObjectiveRela_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvRTTopicObjectiveRela_Cond.sf_FldComparisonOp);
//console.log("clsvRTTopicObjectiveRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvRTTopicObjectiveRela_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvRTTopicObjectiveRela_Sel = arrvRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvRTTopicObjectiveRela_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvRTTopicObjectiveRela_Sel = arrvRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvRTTopicObjectiveRela_Sel = arrvRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvRTTopicObjectiveRela_Sel = arrvRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvRTTopicObjectiveRela_Sel = arrvRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvRTTopicObjectiveRela_Sel = arrvRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvRTTopicObjectiveRela_Sel = arrvRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvRTTopicObjectiveRela_Sel = arrvRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvRTTopicObjectiveRela_Sel = arrvRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvRTTopicObjectiveRela_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objvRTTopicObjectiveRela_Cond), vRTTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvRTTopicObjectiveRelaEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrmId:关键字列表
 * @returns 对象列表
 **/
export async function vRTTopicObjectiveRela_GetObjLstBymIdLstAsync(arrmId: Array<string>): Promise<Array<clsvRTTopicObjectiveRelaEN>>  
{
const strThisFuncName = "GetObjLstBymIdLstAsync";
const strAction = "GetObjLstBymIdLst";
const strUrl = GetWebApiUrl(vRTTopicObjectiveRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrmId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vRTTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vRTTopicObjectiveRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export async function vRTTopicObjectiveRela_GetObjLstBymIdLst_Cache(arrmIdLst: Array<number>) {
const strThisFuncName = "GetObjLstBymIdLst_Cache";
try
{
const arrvRTTopicObjectiveRelaObjLst_Cache = await vRTTopicObjectiveRela_GetObjLst_Cache();
const arrvRTTopicObjectiveRela_Sel: Array <clsvRTTopicObjectiveRelaEN> = arrvRTTopicObjectiveRelaObjLst_Cache.filter(x => arrmIdLst.indexOf(x.mId)>-1);
return arrvRTTopicObjectiveRela_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrmIdLst.join(","), vRTTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvRTTopicObjectiveRelaEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function vRTTopicObjectiveRela_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsvRTTopicObjectiveRelaEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(vRTTopicObjectiveRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vRTTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vRTTopicObjectiveRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export async function vRTTopicObjectiveRela_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsvRTTopicObjectiveRelaEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vRTTopicObjectiveRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vRTTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vRTTopicObjectiveRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export async function vRTTopicObjectiveRela_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vRTTopicObjectiveRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export async function vRTTopicObjectiveRela_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrvRTTopicObjectiveRelaObjLst_Cache = await vRTTopicObjectiveRela_GetObjLst_Cache();
if (arrvRTTopicObjectiveRelaObjLst_Cache.length == 0) return arrvRTTopicObjectiveRelaObjLst_Cache;
let arrvRTTopicObjectiveRela_Sel = arrvRTTopicObjectiveRelaObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objvRTTopicObjectiveRela_Cond = new clsvRTTopicObjectiveRelaEN();
ObjectAssign(objvRTTopicObjectiveRela_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsvRTTopicObjectiveRelaWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvRTTopicObjectiveRela_Sel = arrvRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvRTTopicObjectiveRela_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvRTTopicObjectiveRela_Sel = arrvRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvRTTopicObjectiveRela_Sel = arrvRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvRTTopicObjectiveRela_Sel = arrvRTTopicObjectiveRela_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvRTTopicObjectiveRela_Sel = arrvRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvRTTopicObjectiveRela_Sel = arrvRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvRTTopicObjectiveRela_Sel = arrvRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvRTTopicObjectiveRela_Sel = arrvRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvRTTopicObjectiveRela_Sel = arrvRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvRTTopicObjectiveRela_Sel = arrvRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvRTTopicObjectiveRela_Sel.length == 0) return arrvRTTopicObjectiveRela_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrvRTTopicObjectiveRela_Sel = arrvRTTopicObjectiveRela_Sel.sort(vRTTopicObjectiveRela_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrvRTTopicObjectiveRela_Sel = arrvRTTopicObjectiveRela_Sel.sort(objPagerPara.sortFun);
}
arrvRTTopicObjectiveRela_Sel = arrvRTTopicObjectiveRela_Sel.slice(intStart, intEnd);     
return arrvRTTopicObjectiveRela_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, vRTTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvRTTopicObjectiveRelaEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function vRTTopicObjectiveRela_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsvRTTopicObjectiveRelaEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(vRTTopicObjectiveRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vRTTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vRTTopicObjectiveRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export async function vRTTopicObjectiveRela_IsExistRecord_Cache(objvRTTopicObjectiveRela_Cond: clsvRTTopicObjectiveRelaEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrvRTTopicObjectiveRelaObjLst_Cache = await vRTTopicObjectiveRela_GetObjLst_Cache();
if (arrvRTTopicObjectiveRelaObjLst_Cache == null) return false;
let arrvRTTopicObjectiveRela_Sel: Array < clsvRTTopicObjectiveRelaEN > = arrvRTTopicObjectiveRelaObjLst_Cache;
if (objvRTTopicObjectiveRela_Cond.sf_FldComparisonOp == null || objvRTTopicObjectiveRela_Cond.sf_FldComparisonOp == "") return arrvRTTopicObjectiveRela_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvRTTopicObjectiveRela_Cond.sf_FldComparisonOp);
//console.log("clsvRTTopicObjectiveRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvRTTopicObjectiveRela_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvRTTopicObjectiveRela_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvRTTopicObjectiveRela_Sel = arrvRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvRTTopicObjectiveRela_Sel = arrvRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvRTTopicObjectiveRela_Sel = arrvRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvRTTopicObjectiveRela_Sel = arrvRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvRTTopicObjectiveRela_Sel = arrvRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvRTTopicObjectiveRela_Sel = arrvRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvRTTopicObjectiveRela_Sel = arrvRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvRTTopicObjectiveRela_Sel = arrvRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvRTTopicObjectiveRela_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objvRTTopicObjectiveRela_Cond), vRTTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export async function vRTTopicObjectiveRela_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(vRTTopicObjectiveRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export async function vRTTopicObjectiveRela_IsExist(lngmId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vRTTopicObjectiveRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export async function vRTTopicObjectiveRela_IsExist_Cache(lngmId:number) {
const strThisFuncName = "IsExist_Cache";
const arrvRTTopicObjectiveRelaObjLst_Cache = await vRTTopicObjectiveRela_GetObjLst_Cache();
if (arrvRTTopicObjectiveRelaObjLst_Cache == null) return false;
try
{
const arrvRTTopicObjectiveRela_Sel: Array <clsvRTTopicObjectiveRelaEN> = arrvRTTopicObjectiveRelaObjLst_Cache.filter(x => x.mId == lngmId);
if (arrvRTTopicObjectiveRela_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngmId, vRTTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export async function vRTTopicObjectiveRela_IsExistAsync(lngmId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vRTTopicObjectiveRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export async function vRTTopicObjectiveRela_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(vRTTopicObjectiveRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTTopicObjectiveRela_ConstructorName, strThisFuncName);
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
 * @param objvRTTopicObjectiveRela_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function vRTTopicObjectiveRela_GetRecCountByCond_Cache(objvRTTopicObjectiveRela_Cond: clsvRTTopicObjectiveRelaEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrvRTTopicObjectiveRelaObjLst_Cache = await vRTTopicObjectiveRela_GetObjLst_Cache();
if (arrvRTTopicObjectiveRelaObjLst_Cache == null) return 0;
let arrvRTTopicObjectiveRela_Sel: Array < clsvRTTopicObjectiveRelaEN > = arrvRTTopicObjectiveRelaObjLst_Cache;
if (objvRTTopicObjectiveRela_Cond.sf_FldComparisonOp == null || objvRTTopicObjectiveRela_Cond.sf_FldComparisonOp == "") return arrvRTTopicObjectiveRela_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvRTTopicObjectiveRela_Cond.sf_FldComparisonOp);
//console.log("clsvRTTopicObjectiveRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvRTTopicObjectiveRela_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvRTTopicObjectiveRela_Sel = arrvRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvRTTopicObjectiveRela_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvRTTopicObjectiveRela_Sel = arrvRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvRTTopicObjectiveRela_Sel = arrvRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvRTTopicObjectiveRela_Sel = arrvRTTopicObjectiveRela_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvRTTopicObjectiveRela_Sel = arrvRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvRTTopicObjectiveRela_Sel = arrvRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvRTTopicObjectiveRela_Sel = arrvRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvRTTopicObjectiveRela_Sel = arrvRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvRTTopicObjectiveRela_Sel = arrvRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvRTTopicObjectiveRela_Sel = arrvRTTopicObjectiveRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvRTTopicObjectiveRela_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objvRTTopicObjectiveRela_Cond), vRTTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export function vRTTopicObjectiveRela_GetWebApiUrl(strController: string, strAction: string): string {
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
export function vRTTopicObjectiveRela_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clsvRTTopicObjectiveRelaEN._CurrTabName;
switch (clsvRTTopicObjectiveRelaEN.CacheModeId)
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
export function vRTTopicObjectiveRela_GetJSONStrByObj (pobjvRTTopicObjectiveRelaEN: clsvRTTopicObjectiveRelaEN): string
{
const strThisFuncName = "GetJSONStrByObj";
let strJson = "";
try
{
strJson = JSON.stringify(pobjvRTTopicObjectiveRelaEN);
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
export function vRTTopicObjectiveRela_GetObjLstByJSONStr (strJSON: string): Array<clsvRTTopicObjectiveRelaEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrvRTTopicObjectiveRelaObjLst = new Array<clsvRTTopicObjectiveRelaEN>();
if (strJSON === "")
{
return arrvRTTopicObjectiveRelaObjLst;
}
try
{
arrvRTTopicObjectiveRelaObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvRTTopicObjectiveRelaObjLst;
}
return arrvRTTopicObjectiveRelaObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrvRTTopicObjectiveRelaObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function vRTTopicObjectiveRela_GetObjLstByJSONObjLst (arrvRTTopicObjectiveRelaObjLstS: Array<clsvRTTopicObjectiveRelaEN>): Array<clsvRTTopicObjectiveRelaEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrvRTTopicObjectiveRelaObjLst = new Array<clsvRTTopicObjectiveRelaEN>();
for (const objInFor of arrvRTTopicObjectiveRelaObjLstS) {
const obj1 = vRTTopicObjectiveRela_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrvRTTopicObjectiveRelaObjLst.push(obj1);
}
return arrvRTTopicObjectiveRelaObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vRTTopicObjectiveRela_GetObjByJSONStr (strJSON: string): clsvRTTopicObjectiveRelaEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjvRTTopicObjectiveRelaEN = new clsvRTTopicObjectiveRelaEN();
if (strJSON === "")
{
return pobjvRTTopicObjectiveRelaEN;
}
try
{
pobjvRTTopicObjectiveRelaEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvRTTopicObjectiveRelaEN;
}
return pobjvRTTopicObjectiveRelaEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function vRTTopicObjectiveRela_GetCombineCondition(objvRTTopicObjectiveRela_Cond: clsvRTTopicObjectiveRelaEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objvRTTopicObjectiveRela_Cond.dicFldComparisonOp, clsvRTTopicObjectiveRelaEN.con_mId) == true)
{
const strComparisonOp_mId:string = objvRTTopicObjectiveRela_Cond.dicFldComparisonOp[clsvRTTopicObjectiveRelaEN.con_mId];
strWhereCond += Format(" And {0} {2} {1}", clsvRTTopicObjectiveRelaEN.con_mId, objvRTTopicObjectiveRela_Cond.mId, strComparisonOp_mId);
}
if (Object.prototype.hasOwnProperty.call(objvRTTopicObjectiveRela_Cond.dicFldComparisonOp, clsvRTTopicObjectiveRelaEN.con_TopicId) == true)
{
const strComparisonOp_TopicId:string = objvRTTopicObjectiveRela_Cond.dicFldComparisonOp[clsvRTTopicObjectiveRelaEN.con_TopicId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTTopicObjectiveRelaEN.con_TopicId, objvRTTopicObjectiveRela_Cond.topicId, strComparisonOp_TopicId);
}
if (Object.prototype.hasOwnProperty.call(objvRTTopicObjectiveRela_Cond.dicFldComparisonOp, clsvRTTopicObjectiveRelaEN.con_TopicObjectiveId) == true)
{
const strComparisonOp_TopicObjectiveId:string = objvRTTopicObjectiveRela_Cond.dicFldComparisonOp[clsvRTTopicObjectiveRelaEN.con_TopicObjectiveId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTTopicObjectiveRelaEN.con_TopicObjectiveId, objvRTTopicObjectiveRela_Cond.topicObjectiveId, strComparisonOp_TopicObjectiveId);
}
if (Object.prototype.hasOwnProperty.call(objvRTTopicObjectiveRela_Cond.dicFldComparisonOp, clsvRTTopicObjectiveRelaEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objvRTTopicObjectiveRela_Cond.dicFldComparisonOp[clsvRTTopicObjectiveRelaEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTTopicObjectiveRelaEN.con_UpdDate, objvRTTopicObjectiveRela_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objvRTTopicObjectiveRela_Cond.dicFldComparisonOp, clsvRTTopicObjectiveRelaEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objvRTTopicObjectiveRela_Cond.dicFldComparisonOp[clsvRTTopicObjectiveRelaEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTTopicObjectiveRelaEN.con_UpdUser, objvRTTopicObjectiveRela_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objvRTTopicObjectiveRela_Cond.dicFldComparisonOp, clsvRTTopicObjectiveRelaEN.con_ObjectiveTypeName) == true)
{
const strComparisonOp_ObjectiveTypeName:string = objvRTTopicObjectiveRela_Cond.dicFldComparisonOp[clsvRTTopicObjectiveRelaEN.con_ObjectiveTypeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTTopicObjectiveRelaEN.con_ObjectiveTypeName, objvRTTopicObjectiveRela_Cond.objectiveTypeName, strComparisonOp_ObjectiveTypeName);
}
if (Object.prototype.hasOwnProperty.call(objvRTTopicObjectiveRela_Cond.dicFldComparisonOp, clsvRTTopicObjectiveRelaEN.con_ObjectiveType) == true)
{
const strComparisonOp_ObjectiveType:string = objvRTTopicObjectiveRela_Cond.dicFldComparisonOp[clsvRTTopicObjectiveRelaEN.con_ObjectiveType];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTTopicObjectiveRelaEN.con_ObjectiveType, objvRTTopicObjectiveRela_Cond.objectiveType, strComparisonOp_ObjectiveType);
}
if (Object.prototype.hasOwnProperty.call(objvRTTopicObjectiveRela_Cond.dicFldComparisonOp, clsvRTTopicObjectiveRelaEN.con_SourceId) == true)
{
const strComparisonOp_SourceId:string = objvRTTopicObjectiveRela_Cond.dicFldComparisonOp[clsvRTTopicObjectiveRelaEN.con_SourceId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTTopicObjectiveRelaEN.con_SourceId, objvRTTopicObjectiveRela_Cond.sourceId, strComparisonOp_SourceId);
}
if (Object.prototype.hasOwnProperty.call(objvRTTopicObjectiveRela_Cond.dicFldComparisonOp, clsvRTTopicObjectiveRelaEN.con_IsSubmit) == true)
{
if (objvRTTopicObjectiveRela_Cond.isSubmit == true)
{
strWhereCond += Format(" And {0} = '1'", clsvRTTopicObjectiveRelaEN.con_IsSubmit);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvRTTopicObjectiveRelaEN.con_IsSubmit);
}
}
if (Object.prototype.hasOwnProperty.call(objvRTTopicObjectiveRela_Cond.dicFldComparisonOp, clsvRTTopicObjectiveRelaEN.con_ObjectiveName) == true)
{
const strComparisonOp_ObjectiveName:string = objvRTTopicObjectiveRela_Cond.dicFldComparisonOp[clsvRTTopicObjectiveRelaEN.con_ObjectiveName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTTopicObjectiveRelaEN.con_ObjectiveName, objvRTTopicObjectiveRela_Cond.objectiveName, strComparisonOp_ObjectiveName);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
//数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
//数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objvRTTopicObjectiveRela_Cond.dicFldComparisonOp, clsvRTTopicObjectiveRelaEN.con_TopicName) == true)
{
const strComparisonOp_TopicName:string = objvRTTopicObjectiveRela_Cond.dicFldComparisonOp[clsvRTTopicObjectiveRelaEN.con_TopicName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTTopicObjectiveRelaEN.con_TopicName, objvRTTopicObjectiveRela_Cond.topicName, strComparisonOp_TopicName);
}
if (Object.prototype.hasOwnProperty.call(objvRTTopicObjectiveRela_Cond.dicFldComparisonOp, clsvRTTopicObjectiveRelaEN.con_AppraiseCount) == true)
{
const strComparisonOp_AppraiseCount:string = objvRTTopicObjectiveRela_Cond.dicFldComparisonOp[clsvRTTopicObjectiveRelaEN.con_AppraiseCount];
strWhereCond += Format(" And {0} {2} {1}", clsvRTTopicObjectiveRelaEN.con_AppraiseCount, objvRTTopicObjectiveRela_Cond.appraiseCount, strComparisonOp_AppraiseCount);
}
if (Object.prototype.hasOwnProperty.call(objvRTTopicObjectiveRela_Cond.dicFldComparisonOp, clsvRTTopicObjectiveRelaEN.con_CitationCount) == true)
{
const strComparisonOp_CitationCount:string = objvRTTopicObjectiveRela_Cond.dicFldComparisonOp[clsvRTTopicObjectiveRelaEN.con_CitationCount];
strWhereCond += Format(" And {0} {2} {1}", clsvRTTopicObjectiveRelaEN.con_CitationCount, objvRTTopicObjectiveRela_Cond.citationCount, strComparisonOp_CitationCount);
}
if (Object.prototype.hasOwnProperty.call(objvRTTopicObjectiveRela_Cond.dicFldComparisonOp, clsvRTTopicObjectiveRelaEN.con_score) == true)
{
const strComparisonOp_score:string = objvRTTopicObjectiveRela_Cond.dicFldComparisonOp[clsvRTTopicObjectiveRelaEN.con_score];
strWhereCond += Format(" And {0} {2} {1}", clsvRTTopicObjectiveRelaEN.con_score, objvRTTopicObjectiveRela_Cond.score, strComparisonOp_score);
}
if (Object.prototype.hasOwnProperty.call(objvRTTopicObjectiveRela_Cond.dicFldComparisonOp, clsvRTTopicObjectiveRelaEN.con_StuScore) == true)
{
const strComparisonOp_StuScore:string = objvRTTopicObjectiveRela_Cond.dicFldComparisonOp[clsvRTTopicObjectiveRelaEN.con_StuScore];
strWhereCond += Format(" And {0} {2} {1}", clsvRTTopicObjectiveRelaEN.con_StuScore, objvRTTopicObjectiveRela_Cond.stuScore, strComparisonOp_StuScore);
}
if (Object.prototype.hasOwnProperty.call(objvRTTopicObjectiveRela_Cond.dicFldComparisonOp, clsvRTTopicObjectiveRelaEN.con_TeaScore) == true)
{
const strComparisonOp_TeaScore:string = objvRTTopicObjectiveRela_Cond.dicFldComparisonOp[clsvRTTopicObjectiveRelaEN.con_TeaScore];
strWhereCond += Format(" And {0} {2} {1}", clsvRTTopicObjectiveRelaEN.con_TeaScore, objvRTTopicObjectiveRela_Cond.teaScore, strComparisonOp_TeaScore);
}
if (Object.prototype.hasOwnProperty.call(objvRTTopicObjectiveRela_Cond.dicFldComparisonOp, clsvRTTopicObjectiveRelaEN.con_ObjDate) == true)
{
const strComparisonOp_ObjDate:string = objvRTTopicObjectiveRela_Cond.dicFldComparisonOp[clsvRTTopicObjectiveRelaEN.con_ObjDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTTopicObjectiveRelaEN.con_ObjDate, objvRTTopicObjectiveRela_Cond.objDate, strComparisonOp_ObjDate);
}
if (Object.prototype.hasOwnProperty.call(objvRTTopicObjectiveRela_Cond.dicFldComparisonOp, clsvRTTopicObjectiveRelaEN.con_ObjUserId) == true)
{
const strComparisonOp_ObjUserId:string = objvRTTopicObjectiveRela_Cond.dicFldComparisonOp[clsvRTTopicObjectiveRelaEN.con_ObjUserId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTTopicObjectiveRelaEN.con_ObjUserId, objvRTTopicObjectiveRela_Cond.objUserId, strComparisonOp_ObjUserId);
}
if (Object.prototype.hasOwnProperty.call(objvRTTopicObjectiveRela_Cond.dicFldComparisonOp, clsvRTTopicObjectiveRelaEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objvRTTopicObjectiveRela_Cond.dicFldComparisonOp[clsvRTTopicObjectiveRelaEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTTopicObjectiveRelaEN.con_id_CurrEduCls, objvRTTopicObjectiveRela_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (Object.prototype.hasOwnProperty.call(objvRTTopicObjectiveRela_Cond.dicFldComparisonOp, clsvRTTopicObjectiveRelaEN.con_PdfContent) == true)
{
const strComparisonOp_PdfContent:string = objvRTTopicObjectiveRela_Cond.dicFldComparisonOp[clsvRTTopicObjectiveRelaEN.con_PdfContent];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTTopicObjectiveRelaEN.con_PdfContent, objvRTTopicObjectiveRela_Cond.pdfContent, strComparisonOp_PdfContent);
}
if (Object.prototype.hasOwnProperty.call(objvRTTopicObjectiveRela_Cond.dicFldComparisonOp, clsvRTTopicObjectiveRelaEN.con_PdfPageNum) == true)
{
const strComparisonOp_PdfPageNum:string = objvRTTopicObjectiveRela_Cond.dicFldComparisonOp[clsvRTTopicObjectiveRelaEN.con_PdfPageNum];
strWhereCond += Format(" And {0} {2} {1}", clsvRTTopicObjectiveRelaEN.con_PdfPageNum, objvRTTopicObjectiveRela_Cond.pdfPageNum, strComparisonOp_PdfPageNum);
}
if (Object.prototype.hasOwnProperty.call(objvRTTopicObjectiveRela_Cond.dicFldComparisonOp, clsvRTTopicObjectiveRelaEN.con_OkCount) == true)
{
const strComparisonOp_OkCount:string = objvRTTopicObjectiveRela_Cond.dicFldComparisonOp[clsvRTTopicObjectiveRelaEN.con_OkCount];
strWhereCond += Format(" And {0} {2} {1}", clsvRTTopicObjectiveRelaEN.con_OkCount, objvRTTopicObjectiveRela_Cond.okCount, strComparisonOp_OkCount);
}
if (Object.prototype.hasOwnProperty.call(objvRTTopicObjectiveRela_Cond.dicFldComparisonOp, clsvRTTopicObjectiveRelaEN.con_VersionCount) == true)
{
const strComparisonOp_VersionCount:string = objvRTTopicObjectiveRela_Cond.dicFldComparisonOp[clsvRTTopicObjectiveRelaEN.con_VersionCount];
strWhereCond += Format(" And {0} {2} {1}", clsvRTTopicObjectiveRelaEN.con_VersionCount, objvRTTopicObjectiveRela_Cond.versionCount, strComparisonOp_VersionCount);
}
if (Object.prototype.hasOwnProperty.call(objvRTTopicObjectiveRela_Cond.dicFldComparisonOp, clsvRTTopicObjectiveRelaEN.con_CreateDate) == true)
{
const strComparisonOp_CreateDate:string = objvRTTopicObjectiveRela_Cond.dicFldComparisonOp[clsvRTTopicObjectiveRelaEN.con_CreateDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTTopicObjectiveRelaEN.con_CreateDate, objvRTTopicObjectiveRela_Cond.createDate, strComparisonOp_CreateDate);
}
if (Object.prototype.hasOwnProperty.call(objvRTTopicObjectiveRela_Cond.dicFldComparisonOp, clsvRTTopicObjectiveRelaEN.con_ShareId) == true)
{
const strComparisonOp_ShareId:string = objvRTTopicObjectiveRela_Cond.dicFldComparisonOp[clsvRTTopicObjectiveRelaEN.con_ShareId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTTopicObjectiveRelaEN.con_ShareId, objvRTTopicObjectiveRela_Cond.shareId, strComparisonOp_ShareId);
}
if (Object.prototype.hasOwnProperty.call(objvRTTopicObjectiveRela_Cond.dicFldComparisonOp, clsvRTTopicObjectiveRelaEN.con_ClassificationId) == true)
{
const strComparisonOp_ClassificationId:string = objvRTTopicObjectiveRela_Cond.dicFldComparisonOp[clsvRTTopicObjectiveRelaEN.con_ClassificationId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTTopicObjectiveRelaEN.con_ClassificationId, objvRTTopicObjectiveRela_Cond.classificationId, strComparisonOp_ClassificationId);
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objvRTTopicObjectiveRelaENS:源对象
 * @param objvRTTopicObjectiveRelaENT:目标对象
*/
export function vRTTopicObjectiveRela_CopyObjTo(objvRTTopicObjectiveRelaENS: clsvRTTopicObjectiveRelaEN , objvRTTopicObjectiveRelaENT: clsvRTTopicObjectiveRelaEN ): void 
{
objvRTTopicObjectiveRelaENT.mId = objvRTTopicObjectiveRelaENS.mId; //mId
objvRTTopicObjectiveRelaENT.topicId = objvRTTopicObjectiveRelaENS.topicId; //主题Id
objvRTTopicObjectiveRelaENT.topicObjectiveId = objvRTTopicObjectiveRelaENS.topicObjectiveId; //客观Id
objvRTTopicObjectiveRelaENT.updDate = objvRTTopicObjectiveRelaENS.updDate; //修改日期
objvRTTopicObjectiveRelaENT.updUser = objvRTTopicObjectiveRelaENS.updUser; //修改人
objvRTTopicObjectiveRelaENT.objectiveTypeName = objvRTTopicObjectiveRelaENS.objectiveTypeName; //ObjectiveTypeName
objvRTTopicObjectiveRelaENT.objectiveType = objvRTTopicObjectiveRelaENS.objectiveType; //客观类型
objvRTTopicObjectiveRelaENT.sourceId = objvRTTopicObjectiveRelaENS.sourceId; //来源Id
objvRTTopicObjectiveRelaENT.isSubmit = objvRTTopicObjectiveRelaENS.isSubmit; //是否提交
objvRTTopicObjectiveRelaENT.objectiveName = objvRTTopicObjectiveRelaENS.objectiveName; //客观名称
objvRTTopicObjectiveRelaENT.objectiveContent = objvRTTopicObjectiveRelaENS.objectiveContent; //客观内容
objvRTTopicObjectiveRelaENT.conclusion = objvRTTopicObjectiveRelaENS.conclusion; //结论
objvRTTopicObjectiveRelaENT.topicContent = objvRTTopicObjectiveRelaENS.topicContent; //主题内容
objvRTTopicObjectiveRelaENT.topicName = objvRTTopicObjectiveRelaENS.topicName; //栏目主题
objvRTTopicObjectiveRelaENT.appraiseCount = objvRTTopicObjectiveRelaENS.appraiseCount; //评论数
objvRTTopicObjectiveRelaENT.citationCount = objvRTTopicObjectiveRelaENS.citationCount; //引用统计
objvRTTopicObjectiveRelaENT.score = objvRTTopicObjectiveRelaENS.score; //评分
objvRTTopicObjectiveRelaENT.stuScore = objvRTTopicObjectiveRelaENS.stuScore; //学生平均分
objvRTTopicObjectiveRelaENT.teaScore = objvRTTopicObjectiveRelaENS.teaScore; //教师评分
objvRTTopicObjectiveRelaENT.objDate = objvRTTopicObjectiveRelaENS.objDate; //ObjDate
objvRTTopicObjectiveRelaENT.objUserId = objvRTTopicObjectiveRelaENS.objUserId; //ObjUserId
objvRTTopicObjectiveRelaENT.id_CurrEduCls = objvRTTopicObjectiveRelaENS.id_CurrEduCls; //教学班流水号
objvRTTopicObjectiveRelaENT.pdfContent = objvRTTopicObjectiveRelaENS.pdfContent; //Pdf内容
objvRTTopicObjectiveRelaENT.pdfPageNum = objvRTTopicObjectiveRelaENS.pdfPageNum; //Pdf页码
objvRTTopicObjectiveRelaENT.okCount = objvRTTopicObjectiveRelaENS.okCount; //点赞统计
objvRTTopicObjectiveRelaENT.versionCount = objvRTTopicObjectiveRelaENS.versionCount; //版本统计
objvRTTopicObjectiveRelaENT.createDate = objvRTTopicObjectiveRelaENS.createDate; //建立日期
objvRTTopicObjectiveRelaENT.shareId = objvRTTopicObjectiveRelaENS.shareId; //分享Id
objvRTTopicObjectiveRelaENT.classificationId = objvRTTopicObjectiveRelaENS.classificationId; //分类Id
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objvRTTopicObjectiveRelaENS:源对象
 * @param objvRTTopicObjectiveRelaENT:目标对象
*/
export function vRTTopicObjectiveRela_GetObjFromJsonObj(objvRTTopicObjectiveRelaENS: clsvRTTopicObjectiveRelaEN): clsvRTTopicObjectiveRelaEN 
{
 const objvRTTopicObjectiveRelaENT: clsvRTTopicObjectiveRelaEN = new clsvRTTopicObjectiveRelaEN();
ObjectAssign(objvRTTopicObjectiveRelaENT, objvRTTopicObjectiveRelaENS);
 return objvRTTopicObjectiveRelaENT;
}