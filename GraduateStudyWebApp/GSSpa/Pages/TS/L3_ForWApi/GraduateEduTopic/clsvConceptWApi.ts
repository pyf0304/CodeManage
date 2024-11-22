
 /**
 * 类名:clsvConceptWApi
 * 表名:vConcept(01120619)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 12:02:52
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
 * 概念视图(vConcept)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clsvConceptEN } from "../../L0_Entity/GraduateEduTopic/clsvConceptEN.js";
import { BindDdl_ObjLstInDiv_V, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const vConcept_Controller = "vConceptApi";
 export const vConcept_ConstructorName = "vConcept";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strConceptId:关键字
 * @returns 对象
 **/
export async function vConcept_GetObjByConceptIdAsync(strConceptId: string): Promise<clsvConceptEN>  
{
const strThisFuncName = "GetObjByConceptIdAsync";

if (IsNullOrEmpty(strConceptId) == true)
{
  const strMsg = Format("参数:[strConceptId]不能为空！(In GetObjByConceptIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strConceptId.length != 8)
{
const strMsg = Format("缓存分类变量:[strConceptId]的长度:[{0}]不正确！", strConceptId.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByConceptId";
const strUrl = GetWebApiUrl(vConcept_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strConceptId": strConceptId,
}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObj = data.returnObj;
if (returnObj == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vConcept_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvConcept = vConcept_GetObjFromJsonObj(returnObj);
return objvConcept;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vConcept_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vConcept_ConstructorName, strThisFuncName);
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
 * @param strConceptId:所给的关键字
 * @returns 对象
*/
export async function vConcept_GetObjByConceptId_Cache(strConceptId:string,strid_CurrEduCls:string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByConceptId_Cache";

if (IsNullOrEmpty(strConceptId) == true)
{
  const strMsg = Format("参数:[strConceptId]不能为空！(In GetObjByConceptId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strConceptId.length != 8)
{
const strMsg = Format("缓存分类变量:[strConceptId]的长度:[{0}]不正确！", strConceptId.length);
console.error(strMsg);
throw (strMsg);
}
const arrvConceptObjLst_Cache = await vConcept_GetObjLst_Cache(strid_CurrEduCls);
try
{
const arrvConcept_Sel: Array <clsvConceptEN> = arrvConceptObjLst_Cache.filter(x => x.conceptId == strConceptId);
let objvConcept: clsvConceptEN;
if (arrvConcept_Sel.length > 0)
{
objvConcept = arrvConcept_Sel[0];
return objvConcept;
}
else
{
if (bolTryAsyncOnce == true)
{
objvConcept = await vConcept_GetObjByConceptIdAsync(strConceptId);
if (objvConcept != null)
{
vConcept_ReFreshThisCache(strid_CurrEduCls);
return objvConcept;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strConceptId, vConcept_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param strConceptId:所给的关键字
 * @returns 对象
*/
export async function vConcept_GetObjByConceptId_localStorage(strConceptId: string) {
const strThisFuncName = "GetObjByConceptId_localStorage";

if (IsNullOrEmpty(strConceptId) == true)
{
  const strMsg = Format("参数:[strConceptId]不能为空！(In GetObjByConceptId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
if (strConceptId.length != 8)
{
const strMsg = Format("缓存分类变量:[strConceptId]的长度:[{0}]不正确！", strConceptId.length);
console.error(strMsg);
throw (strMsg);
}
const strKey = Format("{0}_{1}", clsvConceptEN._CurrTabName, strConceptId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objvConcept_Cache: clsvConceptEN = JSON.parse(strTempObj);
return objvConcept_Cache;
}
try
{
const objvConcept = await vConcept_GetObjByConceptIdAsync(strConceptId);
if (objvConcept != null)
{
localStorage.setItem(strKey, JSON.stringify(objvConcept));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objvConcept;
}
return objvConcept;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strConceptId, vConcept_ConstructorName, strThisFuncName);
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
 @param strid_CurrEduCls:缓存的分类字段
 * @returns 返回一个输出字段值
*/
export async function vConcept_func(strInFldName:string , strOutFldName:string , strInValue:string , strid_CurrEduCls_C: string)
{
//const strThisFuncName = "func";

if (IsNullOrEmpty(strid_CurrEduCls_C) == true)
{
  const strMsg = Format("参数:[strid_CurrEduCls_C]不能为空！(In func)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_CurrEduCls_C.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！", strid_CurrEduCls_C.length);
console.error(strMsg);
throw (strMsg);
}

if (strInFldName != clsvConceptEN.con_ConceptId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsvConceptEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clsvConceptEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strConceptId = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objvConcept = await vConcept_GetObjByConceptId_Cache(strConceptId , strid_CurrEduCls_C);
if (objvConcept == null) return "";
return objvConcept.GetFldValue(strOutFldName).toString();
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
export function vConcept_SortFun_Defa(a:clsvConceptEN , b:clsvConceptEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.conceptId.localeCompare(b.conceptId);
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
export function vConcept_SortFun_Defa_2Fld(a:clsvConceptEN , b:clsvConceptEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.conceptContent == b.conceptContent) return a.conceptName.localeCompare(b.conceptName);
else return a.conceptContent.localeCompare(b.conceptContent);
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
export function vConcept_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsvConceptEN.con_ConceptContent:
return (a: clsvConceptEN, b: clsvConceptEN) => {
return a.conceptContent.localeCompare(b.conceptContent);
}
case clsvConceptEN.con_ConceptName:
return (a: clsvConceptEN, b: clsvConceptEN) => {
return a.conceptName.localeCompare(b.conceptName);
}
case clsvConceptEN.con_IsSubmit:
return (a: clsvConceptEN, b: clsvConceptEN) => {
if (a.isSubmit == true) return 1;
else return -1
}
case clsvConceptEN.con_ConceptId:
return (a: clsvConceptEN, b: clsvConceptEN) => {
return a.conceptId.localeCompare(b.conceptId);
}
case clsvConceptEN.con_UpdDate:
return (a: clsvConceptEN, b: clsvConceptEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsvConceptEN.con_Memo:
return (a: clsvConceptEN, b: clsvConceptEN) => {
return a.memo.localeCompare(b.memo);
}
case clsvConceptEN.con_Author:
return (a: clsvConceptEN, b: clsvConceptEN) => {
return a.author.localeCompare(b.author);
}
case clsvConceptEN.con_CitationId:
return (a: clsvConceptEN, b: clsvConceptEN) => {
return a.citationId.localeCompare(b.citationId);
}
case clsvConceptEN.con_Keyword:
return (a: clsvConceptEN, b: clsvConceptEN) => {
return a.keyword.localeCompare(b.keyword);
}
case clsvConceptEN.con_PaperTitle:
return (a: clsvConceptEN, b: clsvConceptEN) => {
return a.paperTitle.localeCompare(b.paperTitle);
}
case clsvConceptEN.con_Periodical:
return (a: clsvConceptEN, b: clsvConceptEN) => {
return a.periodical.localeCompare(b.periodical);
}
case clsvConceptEN.con_ResearchQuestion:
return (a: clsvConceptEN, b: clsvConceptEN) => {
return a.researchQuestion.localeCompare(b.researchQuestion);
}
case clsvConceptEN.con_CitationCount:
return (a: clsvConceptEN, b: clsvConceptEN) => {
return a.citationCount-b.citationCount;
}
case clsvConceptEN.con_AppraiseCount:
return (a: clsvConceptEN, b: clsvConceptEN) => {
return a.appraiseCount-b.appraiseCount;
}
case clsvConceptEN.con_score:
return (a: clsvConceptEN, b: clsvConceptEN) => {
return a.score-b.score;
}
case clsvConceptEN.con_StuScore:
return (a: clsvConceptEN, b: clsvConceptEN) => {
return a.stuScore-b.stuScore;
}
case clsvConceptEN.con_TeaScore:
return (a: clsvConceptEN, b: clsvConceptEN) => {
return a.teaScore-b.teaScore;
}
case clsvConceptEN.con_id_CurrEduCls:
return (a: clsvConceptEN, b: clsvConceptEN) => {
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
case clsvConceptEN.con_PdfPageNum:
return (a: clsvConceptEN, b: clsvConceptEN) => {
return a.pdfPageNum-b.pdfPageNum;
}
case clsvConceptEN.con_OkCount:
return (a: clsvConceptEN, b: clsvConceptEN) => {
return a.okCount-b.okCount;
}
case clsvConceptEN.con_VersionCount:
return (a: clsvConceptEN, b: clsvConceptEN) => {
return a.versionCount-b.versionCount;
}
case clsvConceptEN.con_CreateDate:
return (a: clsvConceptEN, b: clsvConceptEN) => {
return a.createDate.localeCompare(b.createDate);
}
case clsvConceptEN.con_ShareId:
return (a: clsvConceptEN, b: clsvConceptEN) => {
return a.shareId.localeCompare(b.shareId);
}
case clsvConceptEN.con_UpdUser:
return (a: clsvConceptEN, b: clsvConceptEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsvConceptEN.con_PdfContent:
return (a: clsvConceptEN, b: clsvConceptEN) => {
return a.pdfContent.localeCompare(b.pdfContent);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vConcept]中不存在！(in ${ vConcept_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsvConceptEN.con_ConceptContent:
return (a: clsvConceptEN, b: clsvConceptEN) => {
return b.conceptContent.localeCompare(a.conceptContent);
}
case clsvConceptEN.con_ConceptName:
return (a: clsvConceptEN, b: clsvConceptEN) => {
return b.conceptName.localeCompare(a.conceptName);
}
case clsvConceptEN.con_IsSubmit:
return (a: clsvConceptEN, b: clsvConceptEN) => {
if (b.isSubmit == true) return 1;
else return -1
}
case clsvConceptEN.con_ConceptId:
return (a: clsvConceptEN, b: clsvConceptEN) => {
return b.conceptId.localeCompare(a.conceptId);
}
case clsvConceptEN.con_UpdDate:
return (a: clsvConceptEN, b: clsvConceptEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsvConceptEN.con_Memo:
return (a: clsvConceptEN, b: clsvConceptEN) => {
return b.memo.localeCompare(a.memo);
}
case clsvConceptEN.con_Author:
return (a: clsvConceptEN, b: clsvConceptEN) => {
return b.author.localeCompare(a.author);
}
case clsvConceptEN.con_CitationId:
return (a: clsvConceptEN, b: clsvConceptEN) => {
return b.citationId.localeCompare(a.citationId);
}
case clsvConceptEN.con_Keyword:
return (a: clsvConceptEN, b: clsvConceptEN) => {
return b.keyword.localeCompare(a.keyword);
}
case clsvConceptEN.con_PaperTitle:
return (a: clsvConceptEN, b: clsvConceptEN) => {
return b.paperTitle.localeCompare(a.paperTitle);
}
case clsvConceptEN.con_Periodical:
return (a: clsvConceptEN, b: clsvConceptEN) => {
return b.periodical.localeCompare(a.periodical);
}
case clsvConceptEN.con_ResearchQuestion:
return (a: clsvConceptEN, b: clsvConceptEN) => {
return b.researchQuestion.localeCompare(a.researchQuestion);
}
case clsvConceptEN.con_CitationCount:
return (a: clsvConceptEN, b: clsvConceptEN) => {
return b.citationCount-a.citationCount;
}
case clsvConceptEN.con_AppraiseCount:
return (a: clsvConceptEN, b: clsvConceptEN) => {
return b.appraiseCount-a.appraiseCount;
}
case clsvConceptEN.con_score:
return (a: clsvConceptEN, b: clsvConceptEN) => {
return b.score-a.score;
}
case clsvConceptEN.con_StuScore:
return (a: clsvConceptEN, b: clsvConceptEN) => {
return b.stuScore-a.stuScore;
}
case clsvConceptEN.con_TeaScore:
return (a: clsvConceptEN, b: clsvConceptEN) => {
return b.teaScore-a.teaScore;
}
case clsvConceptEN.con_id_CurrEduCls:
return (a: clsvConceptEN, b: clsvConceptEN) => {
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
case clsvConceptEN.con_PdfPageNum:
return (a: clsvConceptEN, b: clsvConceptEN) => {
return b.pdfPageNum-a.pdfPageNum;
}
case clsvConceptEN.con_OkCount:
return (a: clsvConceptEN, b: clsvConceptEN) => {
return b.okCount-a.okCount;
}
case clsvConceptEN.con_VersionCount:
return (a: clsvConceptEN, b: clsvConceptEN) => {
return b.versionCount-a.versionCount;
}
case clsvConceptEN.con_CreateDate:
return (a: clsvConceptEN, b: clsvConceptEN) => {
return b.createDate.localeCompare(a.createDate);
}
case clsvConceptEN.con_ShareId:
return (a: clsvConceptEN, b: clsvConceptEN) => {
return b.shareId.localeCompare(a.shareId);
}
case clsvConceptEN.con_UpdUser:
return (a: clsvConceptEN, b: clsvConceptEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsvConceptEN.con_PdfContent:
return (a: clsvConceptEN, b: clsvConceptEN) => {
return b.pdfContent.localeCompare(a.pdfContent);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vConcept]中不存在！(in ${ vConcept_ConstructorName}.${ strThisFuncName})`;
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
export async function vConcept_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsvConceptEN.con_ConceptContent:
return (obj: clsvConceptEN) => {
return obj.conceptContent === value;
}
case clsvConceptEN.con_ConceptName:
return (obj: clsvConceptEN) => {
return obj.conceptName === value;
}
case clsvConceptEN.con_IsSubmit:
return (obj: clsvConceptEN) => {
return obj.isSubmit === value;
}
case clsvConceptEN.con_ConceptId:
return (obj: clsvConceptEN) => {
return obj.conceptId === value;
}
case clsvConceptEN.con_UpdDate:
return (obj: clsvConceptEN) => {
return obj.updDate === value;
}
case clsvConceptEN.con_Memo:
return (obj: clsvConceptEN) => {
return obj.memo === value;
}
case clsvConceptEN.con_Author:
return (obj: clsvConceptEN) => {
return obj.author === value;
}
case clsvConceptEN.con_CitationId:
return (obj: clsvConceptEN) => {
return obj.citationId === value;
}
case clsvConceptEN.con_Keyword:
return (obj: clsvConceptEN) => {
return obj.keyword === value;
}
case clsvConceptEN.con_PaperTitle:
return (obj: clsvConceptEN) => {
return obj.paperTitle === value;
}
case clsvConceptEN.con_Periodical:
return (obj: clsvConceptEN) => {
return obj.periodical === value;
}
case clsvConceptEN.con_ResearchQuestion:
return (obj: clsvConceptEN) => {
return obj.researchQuestion === value;
}
case clsvConceptEN.con_CitationCount:
return (obj: clsvConceptEN) => {
return obj.citationCount === value;
}
case clsvConceptEN.con_AppraiseCount:
return (obj: clsvConceptEN) => {
return obj.appraiseCount === value;
}
case clsvConceptEN.con_score:
return (obj: clsvConceptEN) => {
return obj.score === value;
}
case clsvConceptEN.con_StuScore:
return (obj: clsvConceptEN) => {
return obj.stuScore === value;
}
case clsvConceptEN.con_TeaScore:
return (obj: clsvConceptEN) => {
return obj.teaScore === value;
}
case clsvConceptEN.con_id_CurrEduCls:
return (obj: clsvConceptEN) => {
return obj.id_CurrEduCls === value;
}
case clsvConceptEN.con_PdfPageNum:
return (obj: clsvConceptEN) => {
return obj.pdfPageNum === value;
}
case clsvConceptEN.con_OkCount:
return (obj: clsvConceptEN) => {
return obj.okCount === value;
}
case clsvConceptEN.con_VersionCount:
return (obj: clsvConceptEN) => {
return obj.versionCount === value;
}
case clsvConceptEN.con_CreateDate:
return (obj: clsvConceptEN) => {
return obj.createDate === value;
}
case clsvConceptEN.con_ShareId:
return (obj: clsvConceptEN) => {
return obj.shareId === value;
}
case clsvConceptEN.con_UpdUser:
return (obj: clsvConceptEN) => {
return obj.updUser === value;
}
case clsvConceptEN.con_PdfContent:
return (obj: clsvConceptEN) => {
return obj.pdfContent === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vConcept]中不存在！(in ${ vConcept_ConstructorName}.${ strThisFuncName})`;
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
export async function vConcept_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vConcept_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vConcept_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vConcept_ConstructorName, strThisFuncName);
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
export async function vConcept_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vConcept_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vConcept_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vConcept_ConstructorName, strThisFuncName);
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
export async function vConcept_GetFirstObjAsync(strWhereCond: string): Promise<clsvConceptEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(vConcept_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vConcept_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvConcept = vConcept_GetObjFromJsonObj(returnObj);
return objvConcept;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vConcept_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vConcept_ConstructorName, strThisFuncName);
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
export async function vConcept_GetObjLst_ClientCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsvConceptEN._CurrTabName, strid_CurrEduCls);
clsvConceptEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvConceptEN._CurrTabName);
if (IsNullOrEmpty(clsvConceptEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvConceptEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrvConceptExObjLst_Cache: Array<clsvConceptEN> = CacheHelper.Get(strKey);
const arrvConceptObjLst_T = vConcept_GetObjLstByJSONObjLst(arrvConceptExObjLst_Cache);
return arrvConceptObjLst_T;
}
try
{
const arrvConceptExObjLst = await vConcept_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrvConceptExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvConceptExObjLst.length);
console.log(strInfo);
return arrvConceptExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vConcept_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vConcept_GetObjLst_localStorage(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsvConceptEN._CurrTabName, strid_CurrEduCls);
clsvConceptEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvConceptEN._CurrTabName);
if (IsNullOrEmpty(clsvConceptEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvConceptEN.CacheAddiCondition);
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
const arrvConceptExObjLst_Cache: Array<clsvConceptEN> = JSON.parse(strTempObjLst);
const arrvConceptObjLst_T = vConcept_GetObjLstByJSONObjLst(arrvConceptExObjLst_Cache);
return arrvConceptObjLst_T;
}
try
{
const arrvConceptExObjLst = await vConcept_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrvConceptExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvConceptExObjLst.length);
console.log(strInfo);
return arrvConceptExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vConcept_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vConcept_GetObjLst_localStorage_PureCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsvConceptEN._CurrTabName, strid_CurrEduCls);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrvConceptObjLst_Cache: Array<clsvConceptEN> = JSON.parse(strTempObjLst);
return arrvConceptObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function vConcept_GetObjLstAsync(strWhereCond: string): Promise<Array<clsvConceptEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(vConcept_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vConcept_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vConcept_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vConcept_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vConcept_ConstructorName, strThisFuncName);
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
export async function vConcept_GetObjLst_sessionStorage(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsvConceptEN._CurrTabName, strid_CurrEduCls);
clsvConceptEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvConceptEN._CurrTabName);
if (IsNullOrEmpty(clsvConceptEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvConceptEN.CacheAddiCondition);
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
const arrvConceptExObjLst_Cache: Array<clsvConceptEN> = JSON.parse(strTempObjLst);
const arrvConceptObjLst_T = vConcept_GetObjLstByJSONObjLst(arrvConceptExObjLst_Cache);
return arrvConceptObjLst_T;
}
try
{
const arrvConceptExObjLst = await vConcept_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrvConceptExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvConceptExObjLst.length);
console.log(strInfo);
return arrvConceptExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vConcept_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vConcept_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsvConceptEN._CurrTabName, strid_CurrEduCls);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrvConceptObjLst_Cache: Array<clsvConceptEN> = JSON.parse(strTempObjLst);
return arrvConceptObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vConcept_GetObjLst_Cache(strid_CurrEduCls: string): Promise<Array<clsvConceptEN>>
{
//const strThisFuncName = "GetObjLst_Cache";

if (IsNullOrEmpty(strid_CurrEduCls) == true)
{
const strMsg = Format("缓存分类变量:[id_CurrEduCls]不能为空！");
console.error(strMsg);
throw (strMsg);
}
if (strid_CurrEduCls.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！", strid_CurrEduCls.length);
console.error(strMsg);
throw (strMsg);
}
let arrvConceptObjLst_Cache;
switch (clsvConceptEN.CacheModeId)
{
case "04"://sessionStorage
arrvConceptObjLst_Cache = await vConcept_GetObjLst_sessionStorage(strid_CurrEduCls);
break;
case "03"://localStorage
arrvConceptObjLst_Cache = await vConcept_GetObjLst_localStorage(strid_CurrEduCls);
break;
case "02"://ClientCache
arrvConceptObjLst_Cache = await vConcept_GetObjLst_ClientCache(strid_CurrEduCls);
break;
default:
arrvConceptObjLst_Cache = await vConcept_GetObjLst_ClientCache(strid_CurrEduCls);
break;
}
const arrvConceptObjLst = vConcept_GetObjLstByJSONObjLst(arrvConceptObjLst_Cache);
return arrvConceptObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vConcept_GetObjLst_PureCache(strid_CurrEduCls: string)
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrvConceptObjLst_Cache;
switch (clsvConceptEN.CacheModeId)
{
case "04"://sessionStorage
arrvConceptObjLst_Cache = await vConcept_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls);
break;
case "03"://localStorage
arrvConceptObjLst_Cache = await vConcept_GetObjLst_localStorage_PureCache(strid_CurrEduCls);
break;
case "02"://ClientCache
arrvConceptObjLst_Cache = null;
break;
default:
arrvConceptObjLst_Cache = null;
break;
}
return arrvConceptObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrConceptId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vConcept_GetSubObjLst_Cache(objvConcept_Cond: clsvConceptEN,strid_CurrEduCls: string) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrvConceptObjLst_Cache = await vConcept_GetObjLst_Cache(strid_CurrEduCls);
let arrvConcept_Sel: Array < clsvConceptEN > = arrvConceptObjLst_Cache;
if (objvConcept_Cond.sf_FldComparisonOp == null || objvConcept_Cond.sf_FldComparisonOp == "") return arrvConcept_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvConcept_Cond.sf_FldComparisonOp);
//console.log("clsvConceptWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvConcept_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvConcept_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvConcept_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objvConcept_Cond), vConcept_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvConceptEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrConceptId:关键字列表
 * @returns 对象列表
 **/
export async function vConcept_GetObjLstByConceptIdLstAsync(arrConceptId: Array<string>): Promise<Array<clsvConceptEN>>  
{
const strThisFuncName = "GetObjLstByConceptIdLstAsync";
const strAction = "GetObjLstByConceptIdLst";
const strUrl = GetWebApiUrl(vConcept_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrConceptId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vConcept_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vConcept_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vConcept_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vConcept_ConstructorName, strThisFuncName);
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
 * @param arrstrConceptIdLst:关键字列表
 * @returns 对象列表
*/
export async function vConcept_GetObjLstByConceptIdLst_Cache(arrConceptIdLst: Array<string>,strid_CurrEduCls: string) {
const strThisFuncName = "GetObjLstByConceptIdLst_Cache";
try
{
const arrvConceptObjLst_Cache = await vConcept_GetObjLst_Cache(strid_CurrEduCls);
const arrvConcept_Sel: Array <clsvConceptEN> = arrvConceptObjLst_Cache.filter(x => arrConceptIdLst.indexOf(x.conceptId)>-1);
return arrvConcept_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrConceptIdLst.join(","), vConcept_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvConceptEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function vConcept_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsvConceptEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(vConcept_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vConcept_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vConcept_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vConcept_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vConcept_ConstructorName, strThisFuncName);
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
export async function vConcept_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsvConceptEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vConcept_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vConcept_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vConcept_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vConcept_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vConcept_ConstructorName, strThisFuncName);
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
export async function vConcept_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vConcept_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vConcept_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vConcept_ConstructorName, strThisFuncName);
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
export async function vConcept_GetObjLstByPager_Cache(objPagerPara: stuPagerPara,strid_CurrEduCls: string) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrvConceptObjLst_Cache = await vConcept_GetObjLst_Cache(strid_CurrEduCls);
if (arrvConceptObjLst_Cache.length == 0) return arrvConceptObjLst_Cache;
let arrvConcept_Sel = arrvConceptObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objvConcept_Cond = new clsvConceptEN();
ObjectAssign(objvConcept_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsvConceptWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvConcept_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvConcept_Sel = arrvConcept_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvConcept_Sel.length == 0) return arrvConcept_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrvConcept_Sel = arrvConcept_Sel.sort(vConcept_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrvConcept_Sel = arrvConcept_Sel.sort(objPagerPara.sortFun);
}
arrvConcept_Sel = arrvConcept_Sel.slice(intStart, intEnd);     
return arrvConcept_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, vConcept_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvConceptEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function vConcept_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsvConceptEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(vConcept_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vConcept_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vConcept_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vConcept_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vConcept_ConstructorName, strThisFuncName);
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
 * @param objstrConceptId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vConcept_IsExistRecord_Cache(objvConcept_Cond: clsvConceptEN,strid_CurrEduCls: string) {
const strThisFuncName = "IsExistRecord_Cache";
const arrvConceptObjLst_Cache = await vConcept_GetObjLst_Cache(strid_CurrEduCls);
if (arrvConceptObjLst_Cache == null) return false;
let arrvConcept_Sel: Array < clsvConceptEN > = arrvConceptObjLst_Cache;
if (objvConcept_Cond.sf_FldComparisonOp == null || objvConcept_Cond.sf_FldComparisonOp == "") return arrvConcept_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvConcept_Cond.sf_FldComparisonOp);
//console.log("clsvConceptWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvConcept_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvConcept_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvConcept_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objvConcept_Cond), vConcept_ConstructorName, strThisFuncName);
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
export async function vConcept_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(vConcept_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vConcept_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vConcept_ConstructorName, strThisFuncName);
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
 * @param strConceptId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function vConcept_IsExist(strConceptId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vConcept_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"ConceptId": strConceptId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vConcept_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vConcept_ConstructorName, strThisFuncName);
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
 * @param strConceptId:所给的关键字
 * @returns 对象
*/
export async function vConcept_IsExist_Cache(strConceptId:string,strid_CurrEduCls:string) {
const strThisFuncName = "IsExist_Cache";
const arrvConceptObjLst_Cache = await vConcept_GetObjLst_Cache(strid_CurrEduCls);
if (arrvConceptObjLst_Cache == null) return false;
try
{
const arrvConcept_Sel: Array <clsvConceptEN> = arrvConceptObjLst_Cache.filter(x => x.conceptId == strConceptId);
if (arrvConcept_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strConceptId, vConcept_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param strConceptId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function vConcept_IsExistAsync(strConceptId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vConcept_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strConceptId": strConceptId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vConcept_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vConcept_ConstructorName, strThisFuncName);
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
export async function vConcept_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(vConcept_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vConcept_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vConcept_ConstructorName, strThisFuncName);
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
 * @param objvConcept_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function vConcept_GetRecCountByCond_Cache(objvConcept_Cond: clsvConceptEN,strid_CurrEduCls: string) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrvConceptObjLst_Cache = await vConcept_GetObjLst_Cache(strid_CurrEduCls);
if (arrvConceptObjLst_Cache == null) return 0;
let arrvConcept_Sel: Array < clsvConceptEN > = arrvConceptObjLst_Cache;
if (objvConcept_Cond.sf_FldComparisonOp == null || objvConcept_Cond.sf_FldComparisonOp == "") return arrvConcept_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvConcept_Cond.sf_FldComparisonOp);
//console.log("clsvConceptWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvConcept_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvConcept_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvConcept_Sel = arrvConcept_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvConcept_Sel = arrvConcept_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvConcept_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objvConcept_Cond), vConcept_ConstructorName, strThisFuncName);
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
export function vConcept_GetWebApiUrl(strController: string, strAction: string): string {
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
export function vConcept_ReFreshThisCache(strid_CurrEduCls: string):void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = Format("{0}_{1}", clsvConceptEN._CurrTabName, strid_CurrEduCls);
switch (clsvConceptEN.CacheModeId)
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
export function vConcept_GetJSONStrByObj (pobjvConceptEN: clsvConceptEN): string
{
const strThisFuncName = "GetJSONStrByObj";
let strJson = "";
try
{
strJson = JSON.stringify(pobjvConceptEN);
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
export function vConcept_GetObjLstByJSONStr (strJSON: string): Array<clsvConceptEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrvConceptObjLst = new Array<clsvConceptEN>();
if (strJSON === "")
{
return arrvConceptObjLst;
}
try
{
arrvConceptObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvConceptObjLst;
}
return arrvConceptObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrvConceptObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function vConcept_GetObjLstByJSONObjLst (arrvConceptObjLstS: Array<clsvConceptEN>): Array<clsvConceptEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrvConceptObjLst = new Array<clsvConceptEN>();
for (const objInFor of arrvConceptObjLstS) {
const obj1 = vConcept_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrvConceptObjLst.push(obj1);
}
return arrvConceptObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vConcept_GetObjByJSONStr (strJSON: string): clsvConceptEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjvConceptEN = new clsvConceptEN();
if (strJSON === "")
{
return pobjvConceptEN;
}
try
{
pobjvConceptEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvConceptEN;
}
return pobjvConceptEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function vConcept_GetCombineCondition(objvConcept_Cond: clsvConceptEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
//数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objvConcept_Cond.dicFldComparisonOp, clsvConceptEN.con_ConceptName) == true)
{
const strComparisonOp_ConceptName:string = objvConcept_Cond.dicFldComparisonOp[clsvConceptEN.con_ConceptName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvConceptEN.con_ConceptName, objvConcept_Cond.conceptName, strComparisonOp_ConceptName);
}
if (Object.prototype.hasOwnProperty.call(objvConcept_Cond.dicFldComparisonOp, clsvConceptEN.con_IsSubmit) == true)
{
if (objvConcept_Cond.isSubmit == true)
{
strWhereCond += Format(" And {0} = '1'", clsvConceptEN.con_IsSubmit);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvConceptEN.con_IsSubmit);
}
}
if (Object.prototype.hasOwnProperty.call(objvConcept_Cond.dicFldComparisonOp, clsvConceptEN.con_ConceptId) == true)
{
const strComparisonOp_ConceptId:string = objvConcept_Cond.dicFldComparisonOp[clsvConceptEN.con_ConceptId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvConceptEN.con_ConceptId, objvConcept_Cond.conceptId, strComparisonOp_ConceptId);
}
if (Object.prototype.hasOwnProperty.call(objvConcept_Cond.dicFldComparisonOp, clsvConceptEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objvConcept_Cond.dicFldComparisonOp[clsvConceptEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvConceptEN.con_UpdDate, objvConcept_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objvConcept_Cond.dicFldComparisonOp, clsvConceptEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objvConcept_Cond.dicFldComparisonOp[clsvConceptEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsvConceptEN.con_Memo, objvConcept_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objvConcept_Cond.dicFldComparisonOp, clsvConceptEN.con_Author) == true)
{
const strComparisonOp_Author:string = objvConcept_Cond.dicFldComparisonOp[clsvConceptEN.con_Author];
strWhereCond += Format(" And {0} {2} '{1}'", clsvConceptEN.con_Author, objvConcept_Cond.author, strComparisonOp_Author);
}
if (Object.prototype.hasOwnProperty.call(objvConcept_Cond.dicFldComparisonOp, clsvConceptEN.con_CitationId) == true)
{
const strComparisonOp_CitationId:string = objvConcept_Cond.dicFldComparisonOp[clsvConceptEN.con_CitationId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvConceptEN.con_CitationId, objvConcept_Cond.citationId, strComparisonOp_CitationId);
}
if (Object.prototype.hasOwnProperty.call(objvConcept_Cond.dicFldComparisonOp, clsvConceptEN.con_Keyword) == true)
{
const strComparisonOp_Keyword:string = objvConcept_Cond.dicFldComparisonOp[clsvConceptEN.con_Keyword];
strWhereCond += Format(" And {0} {2} '{1}'", clsvConceptEN.con_Keyword, objvConcept_Cond.keyword, strComparisonOp_Keyword);
}
if (Object.prototype.hasOwnProperty.call(objvConcept_Cond.dicFldComparisonOp, clsvConceptEN.con_PaperTitle) == true)
{
const strComparisonOp_PaperTitle:string = objvConcept_Cond.dicFldComparisonOp[clsvConceptEN.con_PaperTitle];
strWhereCond += Format(" And {0} {2} '{1}'", clsvConceptEN.con_PaperTitle, objvConcept_Cond.paperTitle, strComparisonOp_PaperTitle);
}
if (Object.prototype.hasOwnProperty.call(objvConcept_Cond.dicFldComparisonOp, clsvConceptEN.con_Periodical) == true)
{
const strComparisonOp_Periodical:string = objvConcept_Cond.dicFldComparisonOp[clsvConceptEN.con_Periodical];
strWhereCond += Format(" And {0} {2} '{1}'", clsvConceptEN.con_Periodical, objvConcept_Cond.periodical, strComparisonOp_Periodical);
}
if (Object.prototype.hasOwnProperty.call(objvConcept_Cond.dicFldComparisonOp, clsvConceptEN.con_ResearchQuestion) == true)
{
const strComparisonOp_ResearchQuestion:string = objvConcept_Cond.dicFldComparisonOp[clsvConceptEN.con_ResearchQuestion];
strWhereCond += Format(" And {0} {2} '{1}'", clsvConceptEN.con_ResearchQuestion, objvConcept_Cond.researchQuestion, strComparisonOp_ResearchQuestion);
}
if (Object.prototype.hasOwnProperty.call(objvConcept_Cond.dicFldComparisonOp, clsvConceptEN.con_CitationCount) == true)
{
const strComparisonOp_CitationCount:string = objvConcept_Cond.dicFldComparisonOp[clsvConceptEN.con_CitationCount];
strWhereCond += Format(" And {0} {2} {1}", clsvConceptEN.con_CitationCount, objvConcept_Cond.citationCount, strComparisonOp_CitationCount);
}
if (Object.prototype.hasOwnProperty.call(objvConcept_Cond.dicFldComparisonOp, clsvConceptEN.con_AppraiseCount) == true)
{
const strComparisonOp_AppraiseCount:string = objvConcept_Cond.dicFldComparisonOp[clsvConceptEN.con_AppraiseCount];
strWhereCond += Format(" And {0} {2} {1}", clsvConceptEN.con_AppraiseCount, objvConcept_Cond.appraiseCount, strComparisonOp_AppraiseCount);
}
if (Object.prototype.hasOwnProperty.call(objvConcept_Cond.dicFldComparisonOp, clsvConceptEN.con_score) == true)
{
const strComparisonOp_score:string = objvConcept_Cond.dicFldComparisonOp[clsvConceptEN.con_score];
strWhereCond += Format(" And {0} {2} {1}", clsvConceptEN.con_score, objvConcept_Cond.score, strComparisonOp_score);
}
if (Object.prototype.hasOwnProperty.call(objvConcept_Cond.dicFldComparisonOp, clsvConceptEN.con_StuScore) == true)
{
const strComparisonOp_StuScore:string = objvConcept_Cond.dicFldComparisonOp[clsvConceptEN.con_StuScore];
strWhereCond += Format(" And {0} {2} {1}", clsvConceptEN.con_StuScore, objvConcept_Cond.stuScore, strComparisonOp_StuScore);
}
if (Object.prototype.hasOwnProperty.call(objvConcept_Cond.dicFldComparisonOp, clsvConceptEN.con_TeaScore) == true)
{
const strComparisonOp_TeaScore:string = objvConcept_Cond.dicFldComparisonOp[clsvConceptEN.con_TeaScore];
strWhereCond += Format(" And {0} {2} {1}", clsvConceptEN.con_TeaScore, objvConcept_Cond.teaScore, strComparisonOp_TeaScore);
}
if (Object.prototype.hasOwnProperty.call(objvConcept_Cond.dicFldComparisonOp, clsvConceptEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objvConcept_Cond.dicFldComparisonOp[clsvConceptEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsvConceptEN.con_id_CurrEduCls, objvConcept_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (Object.prototype.hasOwnProperty.call(objvConcept_Cond.dicFldComparisonOp, clsvConceptEN.con_PdfPageNum) == true)
{
const strComparisonOp_PdfPageNum:string = objvConcept_Cond.dicFldComparisonOp[clsvConceptEN.con_PdfPageNum];
strWhereCond += Format(" And {0} {2} {1}", clsvConceptEN.con_PdfPageNum, objvConcept_Cond.pdfPageNum, strComparisonOp_PdfPageNum);
}
if (Object.prototype.hasOwnProperty.call(objvConcept_Cond.dicFldComparisonOp, clsvConceptEN.con_OkCount) == true)
{
const strComparisonOp_OkCount:string = objvConcept_Cond.dicFldComparisonOp[clsvConceptEN.con_OkCount];
strWhereCond += Format(" And {0} {2} {1}", clsvConceptEN.con_OkCount, objvConcept_Cond.okCount, strComparisonOp_OkCount);
}
if (Object.prototype.hasOwnProperty.call(objvConcept_Cond.dicFldComparisonOp, clsvConceptEN.con_VersionCount) == true)
{
const strComparisonOp_VersionCount:string = objvConcept_Cond.dicFldComparisonOp[clsvConceptEN.con_VersionCount];
strWhereCond += Format(" And {0} {2} {1}", clsvConceptEN.con_VersionCount, objvConcept_Cond.versionCount, strComparisonOp_VersionCount);
}
if (Object.prototype.hasOwnProperty.call(objvConcept_Cond.dicFldComparisonOp, clsvConceptEN.con_CreateDate) == true)
{
const strComparisonOp_CreateDate:string = objvConcept_Cond.dicFldComparisonOp[clsvConceptEN.con_CreateDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvConceptEN.con_CreateDate, objvConcept_Cond.createDate, strComparisonOp_CreateDate);
}
if (Object.prototype.hasOwnProperty.call(objvConcept_Cond.dicFldComparisonOp, clsvConceptEN.con_ShareId) == true)
{
const strComparisonOp_ShareId:string = objvConcept_Cond.dicFldComparisonOp[clsvConceptEN.con_ShareId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvConceptEN.con_ShareId, objvConcept_Cond.shareId, strComparisonOp_ShareId);
}
if (Object.prototype.hasOwnProperty.call(objvConcept_Cond.dicFldComparisonOp, clsvConceptEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objvConcept_Cond.dicFldComparisonOp[clsvConceptEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsvConceptEN.con_UpdUser, objvConcept_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objvConcept_Cond.dicFldComparisonOp, clsvConceptEN.con_PdfContent) == true)
{
const strComparisonOp_PdfContent:string = objvConcept_Cond.dicFldComparisonOp[clsvConceptEN.con_PdfContent];
strWhereCond += Format(" And {0} {2} '{1}'", clsvConceptEN.con_PdfContent, objvConcept_Cond.pdfContent, strComparisonOp_PdfContent);
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objvConceptENS:源对象
 * @param objvConceptENT:目标对象
*/
export function vConcept_CopyObjTo(objvConceptENS: clsvConceptEN , objvConceptENT: clsvConceptEN ): void 
{
objvConceptENT.conceptContent = objvConceptENS.conceptContent; //概念内容
objvConceptENT.conceptName = objvConceptENS.conceptName; //概念名称
objvConceptENT.isSubmit = objvConceptENS.isSubmit; //是否提交
objvConceptENT.conceptId = objvConceptENS.conceptId; //概念Id
objvConceptENT.updDate = objvConceptENS.updDate; //修改日期
objvConceptENT.memo = objvConceptENS.memo; //备注
objvConceptENT.author = objvConceptENS.author; //作者
objvConceptENT.citationId = objvConceptENS.citationId; //引用Id
objvConceptENT.keyword = objvConceptENS.keyword; //关键字
objvConceptENT.paperTitle = objvConceptENS.paperTitle; //论文标题
objvConceptENT.periodical = objvConceptENS.periodical; //期刊
objvConceptENT.researchQuestion = objvConceptENS.researchQuestion; //研究问题
objvConceptENT.citationCount = objvConceptENS.citationCount; //引用统计
objvConceptENT.appraiseCount = objvConceptENS.appraiseCount; //评论数
objvConceptENT.score = objvConceptENS.score; //评分
objvConceptENT.stuScore = objvConceptENS.stuScore; //学生平均分
objvConceptENT.teaScore = objvConceptENS.teaScore; //教师评分
objvConceptENT.id_CurrEduCls = objvConceptENS.id_CurrEduCls; //教学班流水号
objvConceptENT.pdfPageNum = objvConceptENS.pdfPageNum; //Pdf页码
objvConceptENT.okCount = objvConceptENS.okCount; //点赞统计
objvConceptENT.versionCount = objvConceptENS.versionCount; //版本统计
objvConceptENT.createDate = objvConceptENS.createDate; //建立日期
objvConceptENT.shareId = objvConceptENS.shareId; //分享Id
objvConceptENT.updUser = objvConceptENS.updUser; //修改人
objvConceptENT.pdfContent = objvConceptENS.pdfContent; //Pdf内容
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objvConceptENS:源对象
 * @param objvConceptENT:目标对象
*/
export function vConcept_GetObjFromJsonObj(objvConceptENS: clsvConceptEN): clsvConceptEN 
{
 const objvConceptENT: clsvConceptEN = new clsvConceptEN();
ObjectAssign(objvConceptENT, objvConceptENS);
 return objvConceptENT;
}