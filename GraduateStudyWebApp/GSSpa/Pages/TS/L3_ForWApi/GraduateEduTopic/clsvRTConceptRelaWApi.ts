
 /**
 * 类名:clsvRTConceptRelaWApi
 * 表名:vRTConceptRela(01120607)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 12:02:48
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
 * vRTConceptRela(vRTConceptRela)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clsvRTConceptRelaEN } from "../../L0_Entity/GraduateEduTopic/clsvRTConceptRelaEN.js";
import { clsOrderByData } from "../../PubFun/clsOrderByData.js";
import { BindDdl_ObjLstInDiv_V, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const vRTConceptRela_Controller = "vRTConceptRelaApi";
 export const vRTConceptRela_ConstructorName = "vRTConceptRela";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngmId:关键字
 * @returns 对象
 **/
export async function vRTConceptRela_GetObjBymIdAsync(lngmId: number): Promise<clsvRTConceptRelaEN>  
{
const strThisFuncName = "GetObjBymIdAsync";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In GetObjBymIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjBymId";
const strUrl = GetWebApiUrl(vRTConceptRela_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vRTConceptRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvRTConceptRela = vRTConceptRela_GetObjFromJsonObj(returnObj);
return objvRTConceptRela;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTConceptRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTConceptRela_ConstructorName, strThisFuncName);
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
export async function vRTConceptRela_GetObjBymId_Cache(lngmId: number, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjBymId_Cache";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In GetObjBymId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
const arrvRTConceptRelaObjLst_Cache = await vRTConceptRela_GetObjLst_Cache();
try
{
const arrvRTConceptRela_Sel: Array <clsvRTConceptRelaEN> = arrvRTConceptRelaObjLst_Cache.filter(x => x.mId == lngmId);
let objvRTConceptRela: clsvRTConceptRelaEN;
if (arrvRTConceptRela_Sel.length > 0)
{
objvRTConceptRela = arrvRTConceptRela_Sel[0];
return objvRTConceptRela;
}
else
{
if (bolTryAsyncOnce == true)
{
objvRTConceptRela = await vRTConceptRela_GetObjBymIdAsync(lngmId);
if (objvRTConceptRela != null)
{
vRTConceptRela_ReFreshThisCache();
return objvRTConceptRela;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, vRTConceptRela_ConstructorName, strThisFuncName);
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
export async function vRTConceptRela_GetObjBymId_localStorage(lngmId: number) {
const strThisFuncName = "GetObjBymId_localStorage";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In GetObjBymId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
const strKey = Format("{0}_{1}", clsvRTConceptRelaEN._CurrTabName, lngmId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objvRTConceptRela_Cache: clsvRTConceptRelaEN = JSON.parse(strTempObj);
return objvRTConceptRela_Cache;
}
try
{
const objvRTConceptRela = await vRTConceptRela_GetObjBymIdAsync(lngmId);
if (objvRTConceptRela != null)
{
localStorage.setItem(strKey, JSON.stringify(objvRTConceptRela));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objvRTConceptRela;
}
return objvRTConceptRela;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, vRTConceptRela_ConstructorName, strThisFuncName);
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
export async function vRTConceptRela_func(strInFldName:string , strOutFldName:string ,  strInValue: string) 
{
//const strThisFuncName = "func";

if (strInFldName != clsvRTConceptRelaEN.con_mId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsvRTConceptRelaEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clsvRTConceptRelaEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const lngmId = Number(strInValue);
if (lngmId == 0)
{
return "";
}
const objvRTConceptRela = await vRTConceptRela_GetObjBymId_Cache(lngmId );
if (objvRTConceptRela == null) return "";
return objvRTConceptRela.GetFldValue(strOutFldName).toString();
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
export function vRTConceptRela_SortFun_Defa(a:clsvRTConceptRelaEN , b:clsvRTConceptRelaEN): number 
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
export function vRTConceptRela_SortFun_Defa_2Fld(a:clsvRTConceptRelaEN , b:clsvRTConceptRelaEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.topicId == b.topicId) return a.conceptId.localeCompare(b.conceptId);
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
export function vRTConceptRela_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsvRTConceptRelaEN.con_mId:
return (a: clsvRTConceptRelaEN, b: clsvRTConceptRelaEN) => {
return a.mId-b.mId;
}
case clsvRTConceptRelaEN.con_TopicId:
return (a: clsvRTConceptRelaEN, b: clsvRTConceptRelaEN) => {
return a.topicId.localeCompare(b.topicId);
}
case clsvRTConceptRelaEN.con_ConceptId:
return (a: clsvRTConceptRelaEN, b: clsvRTConceptRelaEN) => {
return a.conceptId.localeCompare(b.conceptId);
}
case clsvRTConceptRelaEN.con_UpdDate:
return (a: clsvRTConceptRelaEN, b: clsvRTConceptRelaEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsvRTConceptRelaEN.con_Memo:
return (a: clsvRTConceptRelaEN, b: clsvRTConceptRelaEN) => {
return a.memo.localeCompare(b.memo);
}
case clsvRTConceptRelaEN.con_TopicName:
return (a: clsvRTConceptRelaEN, b: clsvRTConceptRelaEN) => {
return a.topicName.localeCompare(b.topicName);
}
case clsvRTConceptRelaEN.con_TopicContent:
return (a: clsvRTConceptRelaEN, b: clsvRTConceptRelaEN) => {
return a.topicContent.localeCompare(b.topicContent);
}
case clsvRTConceptRelaEN.con_OrderNum:
return (a: clsvRTConceptRelaEN, b: clsvRTConceptRelaEN) => {
return a.orderNum-b.orderNum;
}
case clsvRTConceptRelaEN.con_TopicProposePeople:
return (a: clsvRTConceptRelaEN, b: clsvRTConceptRelaEN) => {
return a.topicProposePeople.localeCompare(b.topicProposePeople);
}
case clsvRTConceptRelaEN.con_ConceptContent:
return (a: clsvRTConceptRelaEN, b: clsvRTConceptRelaEN) => {
return a.conceptContent.localeCompare(b.conceptContent);
}
case clsvRTConceptRelaEN.con_ConceptName:
return (a: clsvRTConceptRelaEN, b: clsvRTConceptRelaEN) => {
return a.conceptName.localeCompare(b.conceptName);
}
case clsvRTConceptRelaEN.con_AppraiseCount:
return (a: clsvRTConceptRelaEN, b: clsvRTConceptRelaEN) => {
return a.appraiseCount-b.appraiseCount;
}
case clsvRTConceptRelaEN.con_CitationCount:
return (a: clsvRTConceptRelaEN, b: clsvRTConceptRelaEN) => {
return a.citationCount-b.citationCount;
}
case clsvRTConceptRelaEN.con_CitationId:
return (a: clsvRTConceptRelaEN, b: clsvRTConceptRelaEN) => {
return a.citationId.localeCompare(b.citationId);
}
case clsvRTConceptRelaEN.con_IsSubmit:
return (a: clsvRTConceptRelaEN, b: clsvRTConceptRelaEN) => {
if (a.isSubmit == true) return 1;
else return -1
}
case clsvRTConceptRelaEN.con_score:
return (a: clsvRTConceptRelaEN, b: clsvRTConceptRelaEN) => {
return a.score-b.score;
}
case clsvRTConceptRelaEN.con_StuScore:
return (a: clsvRTConceptRelaEN, b: clsvRTConceptRelaEN) => {
return a.stuScore-b.stuScore;
}
case clsvRTConceptRelaEN.con_TeaScore:
return (a: clsvRTConceptRelaEN, b: clsvRTConceptRelaEN) => {
return a.teaScore-b.teaScore;
}
case clsvRTConceptRelaEN.con_ConcepDate:
return (a: clsvRTConceptRelaEN, b: clsvRTConceptRelaEN) => {
return a.concepDate.localeCompare(b.concepDate);
}
case clsvRTConceptRelaEN.con_ConcepUserId:
return (a: clsvRTConceptRelaEN, b: clsvRTConceptRelaEN) => {
return a.concepUserId.localeCompare(b.concepUserId);
}
case clsvRTConceptRelaEN.con_id_CurrEduCls:
return (a: clsvRTConceptRelaEN, b: clsvRTConceptRelaEN) => {
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
case clsvRTConceptRelaEN.con_PdfContent:
return (a: clsvRTConceptRelaEN, b: clsvRTConceptRelaEN) => {
return a.pdfContent.localeCompare(b.pdfContent);
}
case clsvRTConceptRelaEN.con_PdfPageNum:
return (a: clsvRTConceptRelaEN, b: clsvRTConceptRelaEN) => {
return a.pdfPageNum-b.pdfPageNum;
}
case clsvRTConceptRelaEN.con_OkCount:
return (a: clsvRTConceptRelaEN, b: clsvRTConceptRelaEN) => {
return a.okCount-b.okCount;
}
case clsvRTConceptRelaEN.con_VersionCount:
return (a: clsvRTConceptRelaEN, b: clsvRTConceptRelaEN) => {
return a.versionCount-b.versionCount;
}
case clsvRTConceptRelaEN.con_CreateDate:
return (a: clsvRTConceptRelaEN, b: clsvRTConceptRelaEN) => {
return a.createDate.localeCompare(b.createDate);
}
case clsvRTConceptRelaEN.con_ShareId:
return (a: clsvRTConceptRelaEN, b: clsvRTConceptRelaEN) => {
return a.shareId.localeCompare(b.shareId);
}
case clsvRTConceptRelaEN.con_UpdUser:
return (a: clsvRTConceptRelaEN, b: clsvRTConceptRelaEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsvRTConceptRelaEN.con_ClassificationId:
return (a: clsvRTConceptRelaEN, b: clsvRTConceptRelaEN) => {
return a.classificationId.localeCompare(b.classificationId);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vRTConceptRela]中不存在！(in ${ vRTConceptRela_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsvRTConceptRelaEN.con_mId:
return (a: clsvRTConceptRelaEN, b: clsvRTConceptRelaEN) => {
return b.mId-a.mId;
}
case clsvRTConceptRelaEN.con_TopicId:
return (a: clsvRTConceptRelaEN, b: clsvRTConceptRelaEN) => {
return b.topicId.localeCompare(a.topicId);
}
case clsvRTConceptRelaEN.con_ConceptId:
return (a: clsvRTConceptRelaEN, b: clsvRTConceptRelaEN) => {
return b.conceptId.localeCompare(a.conceptId);
}
case clsvRTConceptRelaEN.con_UpdDate:
return (a: clsvRTConceptRelaEN, b: clsvRTConceptRelaEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsvRTConceptRelaEN.con_Memo:
return (a: clsvRTConceptRelaEN, b: clsvRTConceptRelaEN) => {
return b.memo.localeCompare(a.memo);
}
case clsvRTConceptRelaEN.con_TopicName:
return (a: clsvRTConceptRelaEN, b: clsvRTConceptRelaEN) => {
return b.topicName.localeCompare(a.topicName);
}
case clsvRTConceptRelaEN.con_TopicContent:
return (a: clsvRTConceptRelaEN, b: clsvRTConceptRelaEN) => {
return b.topicContent.localeCompare(a.topicContent);
}
case clsvRTConceptRelaEN.con_OrderNum:
return (a: clsvRTConceptRelaEN, b: clsvRTConceptRelaEN) => {
return b.orderNum-a.orderNum;
}
case clsvRTConceptRelaEN.con_TopicProposePeople:
return (a: clsvRTConceptRelaEN, b: clsvRTConceptRelaEN) => {
return b.topicProposePeople.localeCompare(a.topicProposePeople);
}
case clsvRTConceptRelaEN.con_ConceptContent:
return (a: clsvRTConceptRelaEN, b: clsvRTConceptRelaEN) => {
return b.conceptContent.localeCompare(a.conceptContent);
}
case clsvRTConceptRelaEN.con_ConceptName:
return (a: clsvRTConceptRelaEN, b: clsvRTConceptRelaEN) => {
return b.conceptName.localeCompare(a.conceptName);
}
case clsvRTConceptRelaEN.con_AppraiseCount:
return (a: clsvRTConceptRelaEN, b: clsvRTConceptRelaEN) => {
return b.appraiseCount-a.appraiseCount;
}
case clsvRTConceptRelaEN.con_CitationCount:
return (a: clsvRTConceptRelaEN, b: clsvRTConceptRelaEN) => {
return b.citationCount-a.citationCount;
}
case clsvRTConceptRelaEN.con_CitationId:
return (a: clsvRTConceptRelaEN, b: clsvRTConceptRelaEN) => {
return b.citationId.localeCompare(a.citationId);
}
case clsvRTConceptRelaEN.con_IsSubmit:
return (a: clsvRTConceptRelaEN, b: clsvRTConceptRelaEN) => {
if (b.isSubmit == true) return 1;
else return -1
}
case clsvRTConceptRelaEN.con_score:
return (a: clsvRTConceptRelaEN, b: clsvRTConceptRelaEN) => {
return b.score-a.score;
}
case clsvRTConceptRelaEN.con_StuScore:
return (a: clsvRTConceptRelaEN, b: clsvRTConceptRelaEN) => {
return b.stuScore-a.stuScore;
}
case clsvRTConceptRelaEN.con_TeaScore:
return (a: clsvRTConceptRelaEN, b: clsvRTConceptRelaEN) => {
return b.teaScore-a.teaScore;
}
case clsvRTConceptRelaEN.con_ConcepDate:
return (a: clsvRTConceptRelaEN, b: clsvRTConceptRelaEN) => {
return b.concepDate.localeCompare(a.concepDate);
}
case clsvRTConceptRelaEN.con_ConcepUserId:
return (a: clsvRTConceptRelaEN, b: clsvRTConceptRelaEN) => {
return b.concepUserId.localeCompare(a.concepUserId);
}
case clsvRTConceptRelaEN.con_id_CurrEduCls:
return (a: clsvRTConceptRelaEN, b: clsvRTConceptRelaEN) => {
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
case clsvRTConceptRelaEN.con_PdfContent:
return (a: clsvRTConceptRelaEN, b: clsvRTConceptRelaEN) => {
return b.pdfContent.localeCompare(a.pdfContent);
}
case clsvRTConceptRelaEN.con_PdfPageNum:
return (a: clsvRTConceptRelaEN, b: clsvRTConceptRelaEN) => {
return b.pdfPageNum-a.pdfPageNum;
}
case clsvRTConceptRelaEN.con_OkCount:
return (a: clsvRTConceptRelaEN, b: clsvRTConceptRelaEN) => {
return b.okCount-a.okCount;
}
case clsvRTConceptRelaEN.con_VersionCount:
return (a: clsvRTConceptRelaEN, b: clsvRTConceptRelaEN) => {
return b.versionCount-a.versionCount;
}
case clsvRTConceptRelaEN.con_CreateDate:
return (a: clsvRTConceptRelaEN, b: clsvRTConceptRelaEN) => {
return b.createDate.localeCompare(a.createDate);
}
case clsvRTConceptRelaEN.con_ShareId:
return (a: clsvRTConceptRelaEN, b: clsvRTConceptRelaEN) => {
return b.shareId.localeCompare(a.shareId);
}
case clsvRTConceptRelaEN.con_UpdUser:
return (a: clsvRTConceptRelaEN, b: clsvRTConceptRelaEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsvRTConceptRelaEN.con_ClassificationId:
return (a: clsvRTConceptRelaEN, b: clsvRTConceptRelaEN) => {
return b.classificationId.localeCompare(a.classificationId);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vRTConceptRela]中不存在！(in ${ vRTConceptRela_ConstructorName}.${ strThisFuncName})`;
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
export async function vRTConceptRela_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsvRTConceptRelaEN.con_mId:
return (obj: clsvRTConceptRelaEN) => {
return obj.mId === value;
}
case clsvRTConceptRelaEN.con_TopicId:
return (obj: clsvRTConceptRelaEN) => {
return obj.topicId === value;
}
case clsvRTConceptRelaEN.con_ConceptId:
return (obj: clsvRTConceptRelaEN) => {
return obj.conceptId === value;
}
case clsvRTConceptRelaEN.con_UpdDate:
return (obj: clsvRTConceptRelaEN) => {
return obj.updDate === value;
}
case clsvRTConceptRelaEN.con_Memo:
return (obj: clsvRTConceptRelaEN) => {
return obj.memo === value;
}
case clsvRTConceptRelaEN.con_TopicName:
return (obj: clsvRTConceptRelaEN) => {
return obj.topicName === value;
}
case clsvRTConceptRelaEN.con_TopicContent:
return (obj: clsvRTConceptRelaEN) => {
return obj.topicContent === value;
}
case clsvRTConceptRelaEN.con_OrderNum:
return (obj: clsvRTConceptRelaEN) => {
return obj.orderNum === value;
}
case clsvRTConceptRelaEN.con_TopicProposePeople:
return (obj: clsvRTConceptRelaEN) => {
return obj.topicProposePeople === value;
}
case clsvRTConceptRelaEN.con_ConceptContent:
return (obj: clsvRTConceptRelaEN) => {
return obj.conceptContent === value;
}
case clsvRTConceptRelaEN.con_ConceptName:
return (obj: clsvRTConceptRelaEN) => {
return obj.conceptName === value;
}
case clsvRTConceptRelaEN.con_AppraiseCount:
return (obj: clsvRTConceptRelaEN) => {
return obj.appraiseCount === value;
}
case clsvRTConceptRelaEN.con_CitationCount:
return (obj: clsvRTConceptRelaEN) => {
return obj.citationCount === value;
}
case clsvRTConceptRelaEN.con_CitationId:
return (obj: clsvRTConceptRelaEN) => {
return obj.citationId === value;
}
case clsvRTConceptRelaEN.con_IsSubmit:
return (obj: clsvRTConceptRelaEN) => {
return obj.isSubmit === value;
}
case clsvRTConceptRelaEN.con_score:
return (obj: clsvRTConceptRelaEN) => {
return obj.score === value;
}
case clsvRTConceptRelaEN.con_StuScore:
return (obj: clsvRTConceptRelaEN) => {
return obj.stuScore === value;
}
case clsvRTConceptRelaEN.con_TeaScore:
return (obj: clsvRTConceptRelaEN) => {
return obj.teaScore === value;
}
case clsvRTConceptRelaEN.con_ConcepDate:
return (obj: clsvRTConceptRelaEN) => {
return obj.concepDate === value;
}
case clsvRTConceptRelaEN.con_ConcepUserId:
return (obj: clsvRTConceptRelaEN) => {
return obj.concepUserId === value;
}
case clsvRTConceptRelaEN.con_id_CurrEduCls:
return (obj: clsvRTConceptRelaEN) => {
return obj.id_CurrEduCls === value;
}
case clsvRTConceptRelaEN.con_PdfContent:
return (obj: clsvRTConceptRelaEN) => {
return obj.pdfContent === value;
}
case clsvRTConceptRelaEN.con_PdfPageNum:
return (obj: clsvRTConceptRelaEN) => {
return obj.pdfPageNum === value;
}
case clsvRTConceptRelaEN.con_OkCount:
return (obj: clsvRTConceptRelaEN) => {
return obj.okCount === value;
}
case clsvRTConceptRelaEN.con_VersionCount:
return (obj: clsvRTConceptRelaEN) => {
return obj.versionCount === value;
}
case clsvRTConceptRelaEN.con_CreateDate:
return (obj: clsvRTConceptRelaEN) => {
return obj.createDate === value;
}
case clsvRTConceptRelaEN.con_ShareId:
return (obj: clsvRTConceptRelaEN) => {
return obj.shareId === value;
}
case clsvRTConceptRelaEN.con_UpdUser:
return (obj: clsvRTConceptRelaEN) => {
return obj.updUser === value;
}
case clsvRTConceptRelaEN.con_ClassificationId:
return (obj: clsvRTConceptRelaEN) => {
return obj.classificationId === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vRTConceptRela]中不存在！(in ${ vRTConceptRela_ConstructorName}.${ strThisFuncName})`;
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
export async function vRTConceptRela_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vRTConceptRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTConceptRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTConceptRela_ConstructorName, strThisFuncName);
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
export async function vRTConceptRela_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vRTConceptRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTConceptRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTConceptRela_ConstructorName, strThisFuncName);
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
export async function vRTConceptRela_GetFirstObjAsync(strWhereCond: string): Promise<clsvRTConceptRelaEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(vRTConceptRela_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vRTConceptRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvRTConceptRela = vRTConceptRela_GetObjFromJsonObj(returnObj);
return objvRTConceptRela;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTConceptRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTConceptRela_ConstructorName, strThisFuncName);
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
export async function vRTConceptRela_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvRTConceptRelaEN._CurrTabName;
clsvRTConceptRelaEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvRTConceptRelaEN._CurrTabName);
if (IsNullOrEmpty(clsvRTConceptRelaEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvRTConceptRelaEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrvRTConceptRelaExObjLst_Cache: Array<clsvRTConceptRelaEN> = CacheHelper.Get(strKey);
const arrvRTConceptRelaObjLst_T = vRTConceptRela_GetObjLstByJSONObjLst(arrvRTConceptRelaExObjLst_Cache);
return arrvRTConceptRelaObjLst_T;
}
try
{
const arrvRTConceptRelaExObjLst = await vRTConceptRela_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrvRTConceptRelaExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvRTConceptRelaExObjLst.length);
console.log(strInfo);
return arrvRTConceptRelaExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vRTConceptRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vRTConceptRela_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvRTConceptRelaEN._CurrTabName;
clsvRTConceptRelaEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvRTConceptRelaEN._CurrTabName);
if (IsNullOrEmpty(clsvRTConceptRelaEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvRTConceptRelaEN.CacheAddiCondition);
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
const arrvRTConceptRelaExObjLst_Cache: Array<clsvRTConceptRelaEN> = JSON.parse(strTempObjLst);
const arrvRTConceptRelaObjLst_T = vRTConceptRela_GetObjLstByJSONObjLst(arrvRTConceptRelaExObjLst_Cache);
return arrvRTConceptRelaObjLst_T;
}
try
{
const arrvRTConceptRelaExObjLst = await vRTConceptRela_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrvRTConceptRelaExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvRTConceptRelaExObjLst.length);
console.log(strInfo);
return arrvRTConceptRelaExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vRTConceptRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vRTConceptRela_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsvRTConceptRelaEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrvRTConceptRelaObjLst_Cache: Array<clsvRTConceptRelaEN> = JSON.parse(strTempObjLst);
return arrvRTConceptRelaObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function vRTConceptRela_GetObjLstAsync(strWhereCond: string): Promise<Array<clsvRTConceptRelaEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(vRTConceptRela_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vRTConceptRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vRTConceptRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTConceptRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTConceptRela_ConstructorName, strThisFuncName);
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
export async function vRTConceptRela_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvRTConceptRelaEN._CurrTabName;
clsvRTConceptRelaEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvRTConceptRelaEN._CurrTabName);
if (IsNullOrEmpty(clsvRTConceptRelaEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvRTConceptRelaEN.CacheAddiCondition);
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
const arrvRTConceptRelaExObjLst_Cache: Array<clsvRTConceptRelaEN> = JSON.parse(strTempObjLst);
const arrvRTConceptRelaObjLst_T = vRTConceptRela_GetObjLstByJSONObjLst(arrvRTConceptRelaExObjLst_Cache);
return arrvRTConceptRelaObjLst_T;
}
try
{
const arrvRTConceptRelaExObjLst = await vRTConceptRela_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrvRTConceptRelaExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvRTConceptRelaExObjLst.length);
console.log(strInfo);
return arrvRTConceptRelaExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vRTConceptRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vRTConceptRela_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsvRTConceptRelaEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrvRTConceptRelaObjLst_Cache: Array<clsvRTConceptRelaEN> = JSON.parse(strTempObjLst);
return arrvRTConceptRelaObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vRTConceptRela_GetObjLst_Cache(): Promise<Array<clsvRTConceptRelaEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrvRTConceptRelaObjLst_Cache;
switch (clsvRTConceptRelaEN.CacheModeId)
{
case "04"://sessionStorage
arrvRTConceptRelaObjLst_Cache = await vRTConceptRela_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrvRTConceptRelaObjLst_Cache = await vRTConceptRela_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrvRTConceptRelaObjLst_Cache = await vRTConceptRela_GetObjLst_ClientCache();
break;
default:
arrvRTConceptRelaObjLst_Cache = await vRTConceptRela_GetObjLst_ClientCache();
break;
}
const arrvRTConceptRelaObjLst = vRTConceptRela_GetObjLstByJSONObjLst(arrvRTConceptRelaObjLst_Cache);
return arrvRTConceptRelaObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vRTConceptRela_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrvRTConceptRelaObjLst_Cache;
switch (clsvRTConceptRelaEN.CacheModeId)
{
case "04"://sessionStorage
arrvRTConceptRelaObjLst_Cache = await vRTConceptRela_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrvRTConceptRelaObjLst_Cache = await vRTConceptRela_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrvRTConceptRelaObjLst_Cache = null;
break;
default:
arrvRTConceptRelaObjLst_Cache = null;
break;
}
return arrvRTConceptRelaObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objlngmId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vRTConceptRela_GetSubObjLst_Cache(objvRTConceptRela_Cond: clsvRTConceptRelaEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrvRTConceptRelaObjLst_Cache = await vRTConceptRela_GetObjLst_Cache();
let arrvRTConceptRela_Sel: Array < clsvRTConceptRelaEN > = arrvRTConceptRelaObjLst_Cache;
if (objvRTConceptRela_Cond.sf_FldComparisonOp == null || objvRTConceptRela_Cond.sf_FldComparisonOp == "") return arrvRTConceptRela_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvRTConceptRela_Cond.sf_FldComparisonOp);
//console.log("clsvRTConceptRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvRTConceptRela_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvRTConceptRela_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvRTConceptRela_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objvRTConceptRela_Cond), vRTConceptRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvRTConceptRelaEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrmId:关键字列表
 * @returns 对象列表
 **/
export async function vRTConceptRela_GetObjLstBymIdLstAsync(arrmId: Array<string>): Promise<Array<clsvRTConceptRelaEN>>  
{
const strThisFuncName = "GetObjLstBymIdLstAsync";
const strAction = "GetObjLstBymIdLst";
const strUrl = GetWebApiUrl(vRTConceptRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrmId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vRTConceptRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vRTConceptRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTConceptRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTConceptRela_ConstructorName, strThisFuncName);
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
export async function vRTConceptRela_GetObjLstBymIdLst_Cache(arrmIdLst: Array<number>) {
const strThisFuncName = "GetObjLstBymIdLst_Cache";
try
{
const arrvRTConceptRelaObjLst_Cache = await vRTConceptRela_GetObjLst_Cache();
const arrvRTConceptRela_Sel: Array <clsvRTConceptRelaEN> = arrvRTConceptRelaObjLst_Cache.filter(x => arrmIdLst.indexOf(x.mId)>-1);
return arrvRTConceptRela_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrmIdLst.join(","), vRTConceptRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvRTConceptRelaEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function vRTConceptRela_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsvRTConceptRelaEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(vRTConceptRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vRTConceptRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vRTConceptRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTConceptRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTConceptRela_ConstructorName, strThisFuncName);
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
export async function vRTConceptRela_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsvRTConceptRelaEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vRTConceptRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vRTConceptRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vRTConceptRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTConceptRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTConceptRela_ConstructorName, strThisFuncName);
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
export async function vRTConceptRela_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vRTConceptRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTConceptRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTConceptRela_ConstructorName, strThisFuncName);
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
export async function vRTConceptRela_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrvRTConceptRelaObjLst_Cache = await vRTConceptRela_GetObjLst_Cache();
if (arrvRTConceptRelaObjLst_Cache.length == 0) return arrvRTConceptRelaObjLst_Cache;
let arrvRTConceptRela_Sel = arrvRTConceptRelaObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objvRTConceptRela_Cond = new clsvRTConceptRelaEN();
ObjectAssign(objvRTConceptRela_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsvRTConceptRelaWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvRTConceptRela_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvRTConceptRela_Sel.length == 0) return arrvRTConceptRela_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.sort(vRTConceptRela_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.sort(objPagerPara.sortFun);
}
arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.slice(intStart, intEnd);     
return arrvRTConceptRela_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, vRTConceptRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvRTConceptRelaEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function vRTConceptRela_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsvRTConceptRelaEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(vRTConceptRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vRTConceptRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vRTConceptRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTConceptRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTConceptRela_ConstructorName, strThisFuncName);
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
 * 把所给的关键字列表相关的记录移顶
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GoTopAsync)
 * @param objvRTConceptRelaEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function vRTConceptRela_GoTopAsync(objOrderByData: clsOrderByData): Promise<boolean> 
{
const strThisFuncName = "GoTopAsync";
let strMsg = "";
const strAction = "GoTop";
if (objOrderByData.KeyIdLst.length == 0)
{
strMsg = "根据关键字列表置顶时，给定的关键字值列表不能为空!";
throw strMsg;
}
const strUrl = GetWebApiUrl(vRTConceptRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objOrderByData);
const data = response.data;
if (data.errorId == 0)
{
return data.returnBool;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTConceptRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTConceptRela_ConstructorName, strThisFuncName);
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
 * 把所给的关键字列表相关的记录上移
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpMoveAsync)
 * @param objvRTConceptRelaEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function vRTConceptRela_UpMoveAsync(objOrderByData: clsOrderByData): Promise<boolean> 
{
const strThisFuncName = "UpMoveAsync";
let strMsg = "";
const strAction = "UpMove";
if (objOrderByData.KeyIdLst.length == 0)
{
strMsg = "根据关键字列表上移时，给定的关键字值列表不能为空!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objvRTConceptRelaEN);
const strUrl = GetWebApiUrl(vRTConceptRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objOrderByData);
const data = response.data;
if (data.errorId == 0)
{
return data.returnBool;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTConceptRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTConceptRela_ConstructorName, strThisFuncName);
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
 * 把所给的关键字列表相关的记录下移
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DownMoveAsync)
 * @param objvRTConceptRelaEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function vRTConceptRela_DownMoveAsync(objOrderByData: clsOrderByData): Promise<boolean> 
{
const strThisFuncName = "DownMoveAsync";
let strMsg = "";
const strAction = "DownMove";
if (objOrderByData.KeyIdLst.length == 0)
{
strMsg = "根据关键字列表下移时，给定的关键字值列表不能为空!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objvRTConceptRelaEN);
const strUrl = GetWebApiUrl(vRTConceptRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objOrderByData);
const data = response.data;
if (data.errorId == 0)
{
return (data.returnBool);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTConceptRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTConceptRela_ConstructorName, strThisFuncName);
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
 * 把所给的关键字列表相关的记录移底
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GoBottomAsync)
 * @param objvRTConceptRelaEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function vRTConceptRela_GoBottomAsync(objOrderByData: clsOrderByData): Promise<boolean> 
{
const strThisFuncName = "GoBottomAsync";
let strMsg = "";
const strAction = "GoBottom";
if (objOrderByData.KeyIdLst.length == 0)
{
strMsg = "根据关键字列表置底时，给定的关键字值列表不能为空!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objvRTConceptRelaEN);
const strUrl = GetWebApiUrl(vRTConceptRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objOrderByData);
const data = response.data;
if (data.errorId == 0)
{
return data.returnBool;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTConceptRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTConceptRela_ConstructorName, strThisFuncName);
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
 * 把列表记录重序
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReOrderAsync)
 * @param objvRTConceptRelaEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function vRTConceptRela_ReOrderAsync(objOrderByData: clsOrderByData): Promise<boolean> 
{
const strThisFuncName = "ReOrderAsync";
const strAction = "ReOrder";
 //var strJSON = JSON.stringify(objvRTConceptRelaEN);
const strUrl = GetWebApiUrl(vRTConceptRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objOrderByData);
const data = response.data;
if (data.errorId == 0)
{
return data.returnBool;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTConceptRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTConceptRela_ConstructorName, strThisFuncName);
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
export async function vRTConceptRela_IsExistRecord_Cache(objvRTConceptRela_Cond: clsvRTConceptRelaEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrvRTConceptRelaObjLst_Cache = await vRTConceptRela_GetObjLst_Cache();
if (arrvRTConceptRelaObjLst_Cache == null) return false;
let arrvRTConceptRela_Sel: Array < clsvRTConceptRelaEN > = arrvRTConceptRelaObjLst_Cache;
if (objvRTConceptRela_Cond.sf_FldComparisonOp == null || objvRTConceptRela_Cond.sf_FldComparisonOp == "") return arrvRTConceptRela_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvRTConceptRela_Cond.sf_FldComparisonOp);
//console.log("clsvRTConceptRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvRTConceptRela_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvRTConceptRela_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvRTConceptRela_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objvRTConceptRela_Cond), vRTConceptRela_ConstructorName, strThisFuncName);
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
export async function vRTConceptRela_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(vRTConceptRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTConceptRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTConceptRela_ConstructorName, strThisFuncName);
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
export async function vRTConceptRela_IsExist(lngmId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vRTConceptRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTConceptRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTConceptRela_ConstructorName, strThisFuncName);
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
export async function vRTConceptRela_IsExist_Cache(lngmId:number) {
const strThisFuncName = "IsExist_Cache";
const arrvRTConceptRelaObjLst_Cache = await vRTConceptRela_GetObjLst_Cache();
if (arrvRTConceptRelaObjLst_Cache == null) return false;
try
{
const arrvRTConceptRela_Sel: Array <clsvRTConceptRelaEN> = arrvRTConceptRelaObjLst_Cache.filter(x => x.mId == lngmId);
if (arrvRTConceptRela_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngmId, vRTConceptRela_ConstructorName, strThisFuncName);
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
export async function vRTConceptRela_IsExistAsync(lngmId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vRTConceptRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTConceptRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTConceptRela_ConstructorName, strThisFuncName);
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
export async function vRTConceptRela_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(vRTConceptRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTConceptRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTConceptRela_ConstructorName, strThisFuncName);
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
 * @param objvRTConceptRela_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function vRTConceptRela_GetRecCountByCond_Cache(objvRTConceptRela_Cond: clsvRTConceptRelaEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrvRTConceptRelaObjLst_Cache = await vRTConceptRela_GetObjLst_Cache();
if (arrvRTConceptRelaObjLst_Cache == null) return 0;
let arrvRTConceptRela_Sel: Array < clsvRTConceptRelaEN > = arrvRTConceptRelaObjLst_Cache;
if (objvRTConceptRela_Cond.sf_FldComparisonOp == null || objvRTConceptRela_Cond.sf_FldComparisonOp == "") return arrvRTConceptRela_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvRTConceptRela_Cond.sf_FldComparisonOp);
//console.log("clsvRTConceptRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvRTConceptRela_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvRTConceptRela_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvRTConceptRela_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objvRTConceptRela_Cond), vRTConceptRela_ConstructorName, strThisFuncName);
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
export function vRTConceptRela_GetWebApiUrl(strController: string, strAction: string): string {
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
export function vRTConceptRela_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clsvRTConceptRelaEN._CurrTabName;
switch (clsvRTConceptRelaEN.CacheModeId)
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
export function vRTConceptRela_GetJSONStrByObj (pobjvRTConceptRelaEN: clsvRTConceptRelaEN): string
{
const strThisFuncName = "GetJSONStrByObj";
let strJson = "";
try
{
strJson = JSON.stringify(pobjvRTConceptRelaEN);
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
export function vRTConceptRela_GetObjLstByJSONStr (strJSON: string): Array<clsvRTConceptRelaEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrvRTConceptRelaObjLst = new Array<clsvRTConceptRelaEN>();
if (strJSON === "")
{
return arrvRTConceptRelaObjLst;
}
try
{
arrvRTConceptRelaObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvRTConceptRelaObjLst;
}
return arrvRTConceptRelaObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrvRTConceptRelaObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function vRTConceptRela_GetObjLstByJSONObjLst (arrvRTConceptRelaObjLstS: Array<clsvRTConceptRelaEN>): Array<clsvRTConceptRelaEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrvRTConceptRelaObjLst = new Array<clsvRTConceptRelaEN>();
for (const objInFor of arrvRTConceptRelaObjLstS) {
const obj1 = vRTConceptRela_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrvRTConceptRelaObjLst.push(obj1);
}
return arrvRTConceptRelaObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vRTConceptRela_GetObjByJSONStr (strJSON: string): clsvRTConceptRelaEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjvRTConceptRelaEN = new clsvRTConceptRelaEN();
if (strJSON === "")
{
return pobjvRTConceptRelaEN;
}
try
{
pobjvRTConceptRelaEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvRTConceptRelaEN;
}
return pobjvRTConceptRelaEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function vRTConceptRela_GetCombineCondition(objvRTConceptRela_Cond: clsvRTConceptRelaEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objvRTConceptRela_Cond.dicFldComparisonOp, clsvRTConceptRelaEN.con_mId) == true)
{
const strComparisonOp_mId:string = objvRTConceptRela_Cond.dicFldComparisonOp[clsvRTConceptRelaEN.con_mId];
strWhereCond += Format(" And {0} {2} {1}", clsvRTConceptRelaEN.con_mId, objvRTConceptRela_Cond.mId, strComparisonOp_mId);
}
if (Object.prototype.hasOwnProperty.call(objvRTConceptRela_Cond.dicFldComparisonOp, clsvRTConceptRelaEN.con_TopicId) == true)
{
const strComparisonOp_TopicId:string = objvRTConceptRela_Cond.dicFldComparisonOp[clsvRTConceptRelaEN.con_TopicId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTConceptRelaEN.con_TopicId, objvRTConceptRela_Cond.topicId, strComparisonOp_TopicId);
}
if (Object.prototype.hasOwnProperty.call(objvRTConceptRela_Cond.dicFldComparisonOp, clsvRTConceptRelaEN.con_ConceptId) == true)
{
const strComparisonOp_ConceptId:string = objvRTConceptRela_Cond.dicFldComparisonOp[clsvRTConceptRelaEN.con_ConceptId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTConceptRelaEN.con_ConceptId, objvRTConceptRela_Cond.conceptId, strComparisonOp_ConceptId);
}
if (Object.prototype.hasOwnProperty.call(objvRTConceptRela_Cond.dicFldComparisonOp, clsvRTConceptRelaEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objvRTConceptRela_Cond.dicFldComparisonOp[clsvRTConceptRelaEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTConceptRelaEN.con_UpdDate, objvRTConceptRela_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objvRTConceptRela_Cond.dicFldComparisonOp, clsvRTConceptRelaEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objvRTConceptRela_Cond.dicFldComparisonOp[clsvRTConceptRelaEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTConceptRelaEN.con_Memo, objvRTConceptRela_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objvRTConceptRela_Cond.dicFldComparisonOp, clsvRTConceptRelaEN.con_TopicName) == true)
{
const strComparisonOp_TopicName:string = objvRTConceptRela_Cond.dicFldComparisonOp[clsvRTConceptRelaEN.con_TopicName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTConceptRelaEN.con_TopicName, objvRTConceptRela_Cond.topicName, strComparisonOp_TopicName);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objvRTConceptRela_Cond.dicFldComparisonOp, clsvRTConceptRelaEN.con_OrderNum) == true)
{
const strComparisonOp_OrderNum:string = objvRTConceptRela_Cond.dicFldComparisonOp[clsvRTConceptRelaEN.con_OrderNum];
strWhereCond += Format(" And {0} {2} {1}", clsvRTConceptRelaEN.con_OrderNum, objvRTConceptRela_Cond.orderNum, strComparisonOp_OrderNum);
}
if (Object.prototype.hasOwnProperty.call(objvRTConceptRela_Cond.dicFldComparisonOp, clsvRTConceptRelaEN.con_TopicProposePeople) == true)
{
const strComparisonOp_TopicProposePeople:string = objvRTConceptRela_Cond.dicFldComparisonOp[clsvRTConceptRelaEN.con_TopicProposePeople];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTConceptRelaEN.con_TopicProposePeople, objvRTConceptRela_Cond.topicProposePeople, strComparisonOp_TopicProposePeople);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objvRTConceptRela_Cond.dicFldComparisonOp, clsvRTConceptRelaEN.con_ConceptName) == true)
{
const strComparisonOp_ConceptName:string = objvRTConceptRela_Cond.dicFldComparisonOp[clsvRTConceptRelaEN.con_ConceptName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTConceptRelaEN.con_ConceptName, objvRTConceptRela_Cond.conceptName, strComparisonOp_ConceptName);
}
if (Object.prototype.hasOwnProperty.call(objvRTConceptRela_Cond.dicFldComparisonOp, clsvRTConceptRelaEN.con_AppraiseCount) == true)
{
const strComparisonOp_AppraiseCount:string = objvRTConceptRela_Cond.dicFldComparisonOp[clsvRTConceptRelaEN.con_AppraiseCount];
strWhereCond += Format(" And {0} {2} {1}", clsvRTConceptRelaEN.con_AppraiseCount, objvRTConceptRela_Cond.appraiseCount, strComparisonOp_AppraiseCount);
}
if (Object.prototype.hasOwnProperty.call(objvRTConceptRela_Cond.dicFldComparisonOp, clsvRTConceptRelaEN.con_CitationCount) == true)
{
const strComparisonOp_CitationCount:string = objvRTConceptRela_Cond.dicFldComparisonOp[clsvRTConceptRelaEN.con_CitationCount];
strWhereCond += Format(" And {0} {2} {1}", clsvRTConceptRelaEN.con_CitationCount, objvRTConceptRela_Cond.citationCount, strComparisonOp_CitationCount);
}
if (Object.prototype.hasOwnProperty.call(objvRTConceptRela_Cond.dicFldComparisonOp, clsvRTConceptRelaEN.con_CitationId) == true)
{
const strComparisonOp_CitationId:string = objvRTConceptRela_Cond.dicFldComparisonOp[clsvRTConceptRelaEN.con_CitationId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTConceptRelaEN.con_CitationId, objvRTConceptRela_Cond.citationId, strComparisonOp_CitationId);
}
if (Object.prototype.hasOwnProperty.call(objvRTConceptRela_Cond.dicFldComparisonOp, clsvRTConceptRelaEN.con_IsSubmit) == true)
{
if (objvRTConceptRela_Cond.isSubmit == true)
{
strWhereCond += Format(" And {0} = '1'", clsvRTConceptRelaEN.con_IsSubmit);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvRTConceptRelaEN.con_IsSubmit);
}
}
if (Object.prototype.hasOwnProperty.call(objvRTConceptRela_Cond.dicFldComparisonOp, clsvRTConceptRelaEN.con_score) == true)
{
const strComparisonOp_score:string = objvRTConceptRela_Cond.dicFldComparisonOp[clsvRTConceptRelaEN.con_score];
strWhereCond += Format(" And {0} {2} {1}", clsvRTConceptRelaEN.con_score, objvRTConceptRela_Cond.score, strComparisonOp_score);
}
if (Object.prototype.hasOwnProperty.call(objvRTConceptRela_Cond.dicFldComparisonOp, clsvRTConceptRelaEN.con_StuScore) == true)
{
const strComparisonOp_StuScore:string = objvRTConceptRela_Cond.dicFldComparisonOp[clsvRTConceptRelaEN.con_StuScore];
strWhereCond += Format(" And {0} {2} {1}", clsvRTConceptRelaEN.con_StuScore, objvRTConceptRela_Cond.stuScore, strComparisonOp_StuScore);
}
if (Object.prototype.hasOwnProperty.call(objvRTConceptRela_Cond.dicFldComparisonOp, clsvRTConceptRelaEN.con_TeaScore) == true)
{
const strComparisonOp_TeaScore:string = objvRTConceptRela_Cond.dicFldComparisonOp[clsvRTConceptRelaEN.con_TeaScore];
strWhereCond += Format(" And {0} {2} {1}", clsvRTConceptRelaEN.con_TeaScore, objvRTConceptRela_Cond.teaScore, strComparisonOp_TeaScore);
}
if (Object.prototype.hasOwnProperty.call(objvRTConceptRela_Cond.dicFldComparisonOp, clsvRTConceptRelaEN.con_ConcepDate) == true)
{
const strComparisonOp_ConcepDate:string = objvRTConceptRela_Cond.dicFldComparisonOp[clsvRTConceptRelaEN.con_ConcepDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTConceptRelaEN.con_ConcepDate, objvRTConceptRela_Cond.concepDate, strComparisonOp_ConcepDate);
}
if (Object.prototype.hasOwnProperty.call(objvRTConceptRela_Cond.dicFldComparisonOp, clsvRTConceptRelaEN.con_ConcepUserId) == true)
{
const strComparisonOp_ConcepUserId:string = objvRTConceptRela_Cond.dicFldComparisonOp[clsvRTConceptRelaEN.con_ConcepUserId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTConceptRelaEN.con_ConcepUserId, objvRTConceptRela_Cond.concepUserId, strComparisonOp_ConcepUserId);
}
if (Object.prototype.hasOwnProperty.call(objvRTConceptRela_Cond.dicFldComparisonOp, clsvRTConceptRelaEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objvRTConceptRela_Cond.dicFldComparisonOp[clsvRTConceptRelaEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTConceptRelaEN.con_id_CurrEduCls, objvRTConceptRela_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (Object.prototype.hasOwnProperty.call(objvRTConceptRela_Cond.dicFldComparisonOp, clsvRTConceptRelaEN.con_PdfContent) == true)
{
const strComparisonOp_PdfContent:string = objvRTConceptRela_Cond.dicFldComparisonOp[clsvRTConceptRelaEN.con_PdfContent];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTConceptRelaEN.con_PdfContent, objvRTConceptRela_Cond.pdfContent, strComparisonOp_PdfContent);
}
if (Object.prototype.hasOwnProperty.call(objvRTConceptRela_Cond.dicFldComparisonOp, clsvRTConceptRelaEN.con_PdfPageNum) == true)
{
const strComparisonOp_PdfPageNum:string = objvRTConceptRela_Cond.dicFldComparisonOp[clsvRTConceptRelaEN.con_PdfPageNum];
strWhereCond += Format(" And {0} {2} {1}", clsvRTConceptRelaEN.con_PdfPageNum, objvRTConceptRela_Cond.pdfPageNum, strComparisonOp_PdfPageNum);
}
if (Object.prototype.hasOwnProperty.call(objvRTConceptRela_Cond.dicFldComparisonOp, clsvRTConceptRelaEN.con_OkCount) == true)
{
const strComparisonOp_OkCount:string = objvRTConceptRela_Cond.dicFldComparisonOp[clsvRTConceptRelaEN.con_OkCount];
strWhereCond += Format(" And {0} {2} {1}", clsvRTConceptRelaEN.con_OkCount, objvRTConceptRela_Cond.okCount, strComparisonOp_OkCount);
}
if (Object.prototype.hasOwnProperty.call(objvRTConceptRela_Cond.dicFldComparisonOp, clsvRTConceptRelaEN.con_VersionCount) == true)
{
const strComparisonOp_VersionCount:string = objvRTConceptRela_Cond.dicFldComparisonOp[clsvRTConceptRelaEN.con_VersionCount];
strWhereCond += Format(" And {0} {2} {1}", clsvRTConceptRelaEN.con_VersionCount, objvRTConceptRela_Cond.versionCount, strComparisonOp_VersionCount);
}
if (Object.prototype.hasOwnProperty.call(objvRTConceptRela_Cond.dicFldComparisonOp, clsvRTConceptRelaEN.con_CreateDate) == true)
{
const strComparisonOp_CreateDate:string = objvRTConceptRela_Cond.dicFldComparisonOp[clsvRTConceptRelaEN.con_CreateDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTConceptRelaEN.con_CreateDate, objvRTConceptRela_Cond.createDate, strComparisonOp_CreateDate);
}
if (Object.prototype.hasOwnProperty.call(objvRTConceptRela_Cond.dicFldComparisonOp, clsvRTConceptRelaEN.con_ShareId) == true)
{
const strComparisonOp_ShareId:string = objvRTConceptRela_Cond.dicFldComparisonOp[clsvRTConceptRelaEN.con_ShareId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTConceptRelaEN.con_ShareId, objvRTConceptRela_Cond.shareId, strComparisonOp_ShareId);
}
if (Object.prototype.hasOwnProperty.call(objvRTConceptRela_Cond.dicFldComparisonOp, clsvRTConceptRelaEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objvRTConceptRela_Cond.dicFldComparisonOp[clsvRTConceptRelaEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTConceptRelaEN.con_UpdUser, objvRTConceptRela_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objvRTConceptRela_Cond.dicFldComparisonOp, clsvRTConceptRelaEN.con_ClassificationId) == true)
{
const strComparisonOp_ClassificationId:string = objvRTConceptRela_Cond.dicFldComparisonOp[clsvRTConceptRelaEN.con_ClassificationId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTConceptRelaEN.con_ClassificationId, objvRTConceptRela_Cond.classificationId, strComparisonOp_ClassificationId);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--vRTConceptRela(vRTConceptRela),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param lngmId: mId(要求唯一的字段)
 * @param strTopicId: 主题Id(要求唯一的字段)
 * @param strConceptId: 概念Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function vRTConceptRela_GetUniCondStr_mId_TopicId_ConceptId(objvRTConceptRelaEN: clsvRTConceptRelaEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and mId = '{0}'", objvRTConceptRelaEN.mId);
 strWhereCond +=  Format(" and TopicId = '{0}'", objvRTConceptRelaEN.topicId);
 strWhereCond +=  Format(" and ConceptId = '{0}'", objvRTConceptRelaEN.conceptId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--vRTConceptRela(vRTConceptRela),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param lngmId: mId(要求唯一的字段)
 * @param strTopicId: 主题Id(要求唯一的字段)
 * @param strConceptId: 概念Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function vRTConceptRela_GetUniCondStr4Update_mId_TopicId_ConceptId(objvRTConceptRelaEN: clsvRTConceptRelaEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and mId <> '{0}'", objvRTConceptRelaEN.mId);
 strWhereCond +=  Format(" and mId = '{0}'", objvRTConceptRelaEN.mId);
 strWhereCond +=  Format(" and TopicId = '{0}'", objvRTConceptRelaEN.topicId);
 strWhereCond +=  Format(" and ConceptId = '{0}'", objvRTConceptRelaEN.conceptId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objvRTConceptRelaENS:源对象
 * @param objvRTConceptRelaENT:目标对象
*/
export function vRTConceptRela_CopyObjTo(objvRTConceptRelaENS: clsvRTConceptRelaEN , objvRTConceptRelaENT: clsvRTConceptRelaEN ): void 
{
objvRTConceptRelaENT.mId = objvRTConceptRelaENS.mId; //mId
objvRTConceptRelaENT.topicId = objvRTConceptRelaENS.topicId; //主题Id
objvRTConceptRelaENT.conceptId = objvRTConceptRelaENS.conceptId; //概念Id
objvRTConceptRelaENT.updDate = objvRTConceptRelaENS.updDate; //修改日期
objvRTConceptRelaENT.memo = objvRTConceptRelaENS.memo; //备注
objvRTConceptRelaENT.topicName = objvRTConceptRelaENS.topicName; //栏目主题
objvRTConceptRelaENT.topicContent = objvRTConceptRelaENS.topicContent; //主题内容
objvRTConceptRelaENT.orderNum = objvRTConceptRelaENS.orderNum; //序号
objvRTConceptRelaENT.topicProposePeople = objvRTConceptRelaENS.topicProposePeople; //主题提出人
objvRTConceptRelaENT.conceptContent = objvRTConceptRelaENS.conceptContent; //概念内容
objvRTConceptRelaENT.conceptName = objvRTConceptRelaENS.conceptName; //概念名称
objvRTConceptRelaENT.appraiseCount = objvRTConceptRelaENS.appraiseCount; //评论数
objvRTConceptRelaENT.citationCount = objvRTConceptRelaENS.citationCount; //引用统计
objvRTConceptRelaENT.citationId = objvRTConceptRelaENS.citationId; //引用Id
objvRTConceptRelaENT.isSubmit = objvRTConceptRelaENS.isSubmit; //是否提交
objvRTConceptRelaENT.score = objvRTConceptRelaENS.score; //评分
objvRTConceptRelaENT.stuScore = objvRTConceptRelaENS.stuScore; //学生平均分
objvRTConceptRelaENT.teaScore = objvRTConceptRelaENS.teaScore; //教师评分
objvRTConceptRelaENT.concepDate = objvRTConceptRelaENS.concepDate; //ConcepDate
objvRTConceptRelaENT.concepUserId = objvRTConceptRelaENS.concepUserId; //ConcepUserId
objvRTConceptRelaENT.id_CurrEduCls = objvRTConceptRelaENS.id_CurrEduCls; //教学班流水号
objvRTConceptRelaENT.pdfContent = objvRTConceptRelaENS.pdfContent; //Pdf内容
objvRTConceptRelaENT.pdfPageNum = objvRTConceptRelaENS.pdfPageNum; //Pdf页码
objvRTConceptRelaENT.okCount = objvRTConceptRelaENS.okCount; //点赞统计
objvRTConceptRelaENT.versionCount = objvRTConceptRelaENS.versionCount; //版本统计
objvRTConceptRelaENT.createDate = objvRTConceptRelaENS.createDate; //建立日期
objvRTConceptRelaENT.shareId = objvRTConceptRelaENS.shareId; //分享Id
objvRTConceptRelaENT.updUser = objvRTConceptRelaENS.updUser; //修改人
objvRTConceptRelaENT.classificationId = objvRTConceptRelaENS.classificationId; //分类Id
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objvRTConceptRelaENS:源对象
 * @param objvRTConceptRelaENT:目标对象
*/
export function vRTConceptRela_GetObjFromJsonObj(objvRTConceptRelaENS: clsvRTConceptRelaEN): clsvRTConceptRelaEN 
{
 const objvRTConceptRelaENT: clsvRTConceptRelaEN = new clsvRTConceptRelaEN();
ObjectAssign(objvRTConceptRelaENT, objvRTConceptRelaENS);
 return objvRTConceptRelaENT;
}