
 /**
 * 类名:clsvSysSocialRelationsWApi
 * 表名:vSysSocialRelations(01120654)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 12:02:54
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
 * 社会关系表视图(vSysSocialRelations)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clsvSysSocialRelationsEN } from "../../L0_Entity/GraduateEduTopic/clsvSysSocialRelationsEN.js";
import { BindDdl_ObjLstInDiv_V, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const vSysSocialRelations_Controller = "vSysSocialRelationsApi";
 export const vSysSocialRelations_ConstructorName = "vSysSocialRelations";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strSocialId:关键字
 * @returns 对象
 **/
export async function vSysSocialRelations_GetObjBySocialIdAsync(strSocialId: string): Promise<clsvSysSocialRelationsEN>  
{
const strThisFuncName = "GetObjBySocialIdAsync";

if (IsNullOrEmpty(strSocialId) == true)
{
  const strMsg = Format("参数:[strSocialId]不能为空！(In GetObjBySocialIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strSocialId.length != 10)
{
const strMsg = Format("缓存分类变量:[strSocialId]的长度:[{0}]不正确！", strSocialId.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjBySocialId";
const strUrl = GetWebApiUrl(vSysSocialRelations_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strSocialId": strSocialId,
}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObj = data.returnObj;
if (returnObj == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vSysSocialRelations_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvSysSocialRelations = vSysSocialRelations_GetObjFromJsonObj(returnObj);
return objvSysSocialRelations;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysSocialRelations_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysSocialRelations_ConstructorName, strThisFuncName);
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
 * @param strSocialId:所给的关键字
 * @returns 对象
*/
export async function vSysSocialRelations_GetObjBySocialId_Cache(strSocialId:string,strid_CurrEduCls:string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjBySocialId_Cache";

if (IsNullOrEmpty(strSocialId) == true)
{
  const strMsg = Format("参数:[strSocialId]不能为空！(In GetObjBySocialId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strSocialId.length != 10)
{
const strMsg = Format("缓存分类变量:[strSocialId]的长度:[{0}]不正确！", strSocialId.length);
console.error(strMsg);
throw (strMsg);
}
const arrvSysSocialRelationsObjLst_Cache = await vSysSocialRelations_GetObjLst_Cache(strid_CurrEduCls);
try
{
const arrvSysSocialRelations_Sel: Array <clsvSysSocialRelationsEN> = arrvSysSocialRelationsObjLst_Cache.filter(x => x.socialId == strSocialId);
let objvSysSocialRelations: clsvSysSocialRelationsEN;
if (arrvSysSocialRelations_Sel.length > 0)
{
objvSysSocialRelations = arrvSysSocialRelations_Sel[0];
return objvSysSocialRelations;
}
else
{
if (bolTryAsyncOnce == true)
{
objvSysSocialRelations = await vSysSocialRelations_GetObjBySocialIdAsync(strSocialId);
if (objvSysSocialRelations != null)
{
vSysSocialRelations_ReFreshThisCache(strid_CurrEduCls);
return objvSysSocialRelations;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strSocialId, vSysSocialRelations_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param strSocialId:所给的关键字
 * @returns 对象
*/
export async function vSysSocialRelations_GetObjBySocialId_localStorage(strSocialId: string) {
const strThisFuncName = "GetObjBySocialId_localStorage";

if (IsNullOrEmpty(strSocialId) == true)
{
  const strMsg = Format("参数:[strSocialId]不能为空！(In GetObjBySocialId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
if (strSocialId.length != 10)
{
const strMsg = Format("缓存分类变量:[strSocialId]的长度:[{0}]不正确！", strSocialId.length);
console.error(strMsg);
throw (strMsg);
}
const strKey = Format("{0}_{1}", clsvSysSocialRelationsEN._CurrTabName, strSocialId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objvSysSocialRelations_Cache: clsvSysSocialRelationsEN = JSON.parse(strTempObj);
return objvSysSocialRelations_Cache;
}
try
{
const objvSysSocialRelations = await vSysSocialRelations_GetObjBySocialIdAsync(strSocialId);
if (objvSysSocialRelations != null)
{
localStorage.setItem(strKey, JSON.stringify(objvSysSocialRelations));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objvSysSocialRelations;
}
return objvSysSocialRelations;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strSocialId, vSysSocialRelations_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 根据关键字获取相关对象的名称属性, 从缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
 * @param strSocialId:所给的关键字
 * @returns 对象
*/
export async function vSysSocialRelations_GetNameBySocialId_Cache(strSocialId: string,strid_CurrEduCls: string) {
const strThisFuncName = "GetNameBySocialId_Cache";

if (IsNullOrEmpty(strSocialId) == true)
{
  const strMsg = Format("参数:[strSocialId]不能为空！(In GetNameBySocialId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strSocialId.length != 10)
{
const strMsg = Format("缓存分类变量:[strSocialId]的长度:[{0}]不正确！", strSocialId.length);
console.error(strMsg);
throw (strMsg);
}
const arrvSysSocialRelationsObjLst_Cache = await vSysSocialRelations_GetObjLst_Cache(strid_CurrEduCls);
if (arrvSysSocialRelationsObjLst_Cache == null) return "";
try
{
const arrvSysSocialRelations_Sel: Array <clsvSysSocialRelationsEN> = arrvSysSocialRelationsObjLst_Cache.filter(x => x.socialId == strSocialId);
let objvSysSocialRelations: clsvSysSocialRelationsEN;
if (arrvSysSocialRelations_Sel.length > 0)
{
objvSysSocialRelations = arrvSysSocialRelations_Sel[0];
return objvSysSocialRelations.levelName;
}
else
{
return "";
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strSocialId);
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
 @param strid_CurrEduCls:缓存的分类字段
 * @returns 返回一个输出字段值
*/
export async function vSysSocialRelations_func(strInFldName:string , strOutFldName:string , strInValue:string , strid_CurrEduCls_C: string)
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

if (strInFldName != clsvSysSocialRelationsEN.con_SocialId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsvSysSocialRelationsEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clsvSysSocialRelationsEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strSocialId = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objvSysSocialRelations = await vSysSocialRelations_GetObjBySocialId_Cache(strSocialId , strid_CurrEduCls_C);
if (objvSysSocialRelations == null) return "";
return objvSysSocialRelations.GetFldValue(strOutFldName).toString();
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
export function vSysSocialRelations_SortFun_Defa(a:clsvSysSocialRelationsEN , b:clsvSysSocialRelationsEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.socialId.localeCompare(b.socialId);
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
export function vSysSocialRelations_SortFun_Defa_2Fld(a:clsvSysSocialRelationsEN , b:clsvSysSocialRelationsEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.fullName == b.fullName) return a.nationality.localeCompare(b.nationality);
else return a.fullName.localeCompare(b.fullName);
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
export function vSysSocialRelations_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsvSysSocialRelationsEN.con_SocialId:
return (a: clsvSysSocialRelationsEN, b: clsvSysSocialRelationsEN) => {
return a.socialId.localeCompare(b.socialId);
}
case clsvSysSocialRelationsEN.con_FullName:
return (a: clsvSysSocialRelationsEN, b: clsvSysSocialRelationsEN) => {
return a.fullName.localeCompare(b.fullName);
}
case clsvSysSocialRelationsEN.con_Nationality:
return (a: clsvSysSocialRelationsEN, b: clsvSysSocialRelationsEN) => {
return a.nationality.localeCompare(b.nationality);
}
case clsvSysSocialRelationsEN.con_WorkUnit:
return (a: clsvSysSocialRelationsEN, b: clsvSysSocialRelationsEN) => {
return a.workUnit.localeCompare(b.workUnit);
}
case clsvSysSocialRelationsEN.con_Major:
return (a: clsvSysSocialRelationsEN, b: clsvSysSocialRelationsEN) => {
return a.major.localeCompare(b.major);
}
case clsvSysSocialRelationsEN.con_Achievement:
return (a: clsvSysSocialRelationsEN, b: clsvSysSocialRelationsEN) => {
return a.achievement.localeCompare(b.achievement);
}
case clsvSysSocialRelationsEN.con_DetailedDescription:
return (a: clsvSysSocialRelationsEN, b: clsvSysSocialRelationsEN) => {
return a.detailedDescription.localeCompare(b.detailedDescription);
}
case clsvSysSocialRelationsEN.con_LevelId:
return (a: clsvSysSocialRelationsEN, b: clsvSysSocialRelationsEN) => {
return a.levelId.localeCompare(b.levelId);
}
case clsvSysSocialRelationsEN.con_LevelName:
return (a: clsvSysSocialRelationsEN, b: clsvSysSocialRelationsEN) => {
return a.levelName.localeCompare(b.levelName);
}
case clsvSysSocialRelationsEN.con_UpdUser:
return (a: clsvSysSocialRelationsEN, b: clsvSysSocialRelationsEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsvSysSocialRelationsEN.con_UpdDate:
return (a: clsvSysSocialRelationsEN, b: clsvSysSocialRelationsEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsvSysSocialRelationsEN.con_IsSubmit:
return (a: clsvSysSocialRelationsEN, b: clsvSysSocialRelationsEN) => {
if (a.isSubmit == true) return 1;
else return -1
}
case clsvSysSocialRelationsEN.con_OkCount:
return (a: clsvSysSocialRelationsEN, b: clsvSysSocialRelationsEN) => {
return a.okCount-b.okCount;
}
case clsvSysSocialRelationsEN.con_CitationCount:
return (a: clsvSysSocialRelationsEN, b: clsvSysSocialRelationsEN) => {
return a.citationCount-b.citationCount;
}
case clsvSysSocialRelationsEN.con_VersionCount:
return (a: clsvSysSocialRelationsEN, b: clsvSysSocialRelationsEN) => {
return a.versionCount-b.versionCount;
}
case clsvSysSocialRelationsEN.con_id_CurrEduCls:
return (a: clsvSysSocialRelationsEN, b: clsvSysSocialRelationsEN) => {
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
case clsvSysSocialRelationsEN.con_Memo:
return (a: clsvSysSocialRelationsEN, b: clsvSysSocialRelationsEN) => {
return a.memo.localeCompare(b.memo);
}
case clsvSysSocialRelationsEN.con_AppraiseCount:
return (a: clsvSysSocialRelationsEN, b: clsvSysSocialRelationsEN) => {
return a.appraiseCount-b.appraiseCount;
}
case clsvSysSocialRelationsEN.con_score:
return (a: clsvSysSocialRelationsEN, b: clsvSysSocialRelationsEN) => {
return a.score-b.score;
}
case clsvSysSocialRelationsEN.con_StuScore:
return (a: clsvSysSocialRelationsEN, b: clsvSysSocialRelationsEN) => {
return a.stuScore-b.stuScore;
}
case clsvSysSocialRelationsEN.con_TeaScore:
return (a: clsvSysSocialRelationsEN, b: clsvSysSocialRelationsEN) => {
return a.teaScore-b.teaScore;
}
case clsvSysSocialRelationsEN.con_CitationId:
return (a: clsvSysSocialRelationsEN, b: clsvSysSocialRelationsEN) => {
return a.citationId.localeCompare(b.citationId);
}
case clsvSysSocialRelationsEN.con_CreateDate:
return (a: clsvSysSocialRelationsEN, b: clsvSysSocialRelationsEN) => {
return a.createDate.localeCompare(b.createDate);
}
case clsvSysSocialRelationsEN.con_ShareId:
return (a: clsvSysSocialRelationsEN, b: clsvSysSocialRelationsEN) => {
return a.shareId.localeCompare(b.shareId);
}
case clsvSysSocialRelationsEN.con_PdfContent:
return (a: clsvSysSocialRelationsEN, b: clsvSysSocialRelationsEN) => {
return a.pdfContent.localeCompare(b.pdfContent);
}
case clsvSysSocialRelationsEN.con_PdfPageNum:
return (a: clsvSysSocialRelationsEN, b: clsvSysSocialRelationsEN) => {
return a.pdfPageNum-b.pdfPageNum;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vSysSocialRelations]中不存在！(in ${ vSysSocialRelations_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsvSysSocialRelationsEN.con_SocialId:
return (a: clsvSysSocialRelationsEN, b: clsvSysSocialRelationsEN) => {
return b.socialId.localeCompare(a.socialId);
}
case clsvSysSocialRelationsEN.con_FullName:
return (a: clsvSysSocialRelationsEN, b: clsvSysSocialRelationsEN) => {
return b.fullName.localeCompare(a.fullName);
}
case clsvSysSocialRelationsEN.con_Nationality:
return (a: clsvSysSocialRelationsEN, b: clsvSysSocialRelationsEN) => {
return b.nationality.localeCompare(a.nationality);
}
case clsvSysSocialRelationsEN.con_WorkUnit:
return (a: clsvSysSocialRelationsEN, b: clsvSysSocialRelationsEN) => {
return b.workUnit.localeCompare(a.workUnit);
}
case clsvSysSocialRelationsEN.con_Major:
return (a: clsvSysSocialRelationsEN, b: clsvSysSocialRelationsEN) => {
return b.major.localeCompare(a.major);
}
case clsvSysSocialRelationsEN.con_Achievement:
return (a: clsvSysSocialRelationsEN, b: clsvSysSocialRelationsEN) => {
return b.achievement.localeCompare(a.achievement);
}
case clsvSysSocialRelationsEN.con_DetailedDescription:
return (a: clsvSysSocialRelationsEN, b: clsvSysSocialRelationsEN) => {
return b.detailedDescription.localeCompare(a.detailedDescription);
}
case clsvSysSocialRelationsEN.con_LevelId:
return (a: clsvSysSocialRelationsEN, b: clsvSysSocialRelationsEN) => {
return b.levelId.localeCompare(a.levelId);
}
case clsvSysSocialRelationsEN.con_LevelName:
return (a: clsvSysSocialRelationsEN, b: clsvSysSocialRelationsEN) => {
return b.levelName.localeCompare(a.levelName);
}
case clsvSysSocialRelationsEN.con_UpdUser:
return (a: clsvSysSocialRelationsEN, b: clsvSysSocialRelationsEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsvSysSocialRelationsEN.con_UpdDate:
return (a: clsvSysSocialRelationsEN, b: clsvSysSocialRelationsEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsvSysSocialRelationsEN.con_IsSubmit:
return (a: clsvSysSocialRelationsEN, b: clsvSysSocialRelationsEN) => {
if (b.isSubmit == true) return 1;
else return -1
}
case clsvSysSocialRelationsEN.con_OkCount:
return (a: clsvSysSocialRelationsEN, b: clsvSysSocialRelationsEN) => {
return b.okCount-a.okCount;
}
case clsvSysSocialRelationsEN.con_CitationCount:
return (a: clsvSysSocialRelationsEN, b: clsvSysSocialRelationsEN) => {
return b.citationCount-a.citationCount;
}
case clsvSysSocialRelationsEN.con_VersionCount:
return (a: clsvSysSocialRelationsEN, b: clsvSysSocialRelationsEN) => {
return b.versionCount-a.versionCount;
}
case clsvSysSocialRelationsEN.con_id_CurrEduCls:
return (a: clsvSysSocialRelationsEN, b: clsvSysSocialRelationsEN) => {
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
case clsvSysSocialRelationsEN.con_Memo:
return (a: clsvSysSocialRelationsEN, b: clsvSysSocialRelationsEN) => {
return b.memo.localeCompare(a.memo);
}
case clsvSysSocialRelationsEN.con_AppraiseCount:
return (a: clsvSysSocialRelationsEN, b: clsvSysSocialRelationsEN) => {
return b.appraiseCount-a.appraiseCount;
}
case clsvSysSocialRelationsEN.con_score:
return (a: clsvSysSocialRelationsEN, b: clsvSysSocialRelationsEN) => {
return b.score-a.score;
}
case clsvSysSocialRelationsEN.con_StuScore:
return (a: clsvSysSocialRelationsEN, b: clsvSysSocialRelationsEN) => {
return b.stuScore-a.stuScore;
}
case clsvSysSocialRelationsEN.con_TeaScore:
return (a: clsvSysSocialRelationsEN, b: clsvSysSocialRelationsEN) => {
return b.teaScore-a.teaScore;
}
case clsvSysSocialRelationsEN.con_CitationId:
return (a: clsvSysSocialRelationsEN, b: clsvSysSocialRelationsEN) => {
return b.citationId.localeCompare(a.citationId);
}
case clsvSysSocialRelationsEN.con_CreateDate:
return (a: clsvSysSocialRelationsEN, b: clsvSysSocialRelationsEN) => {
return b.createDate.localeCompare(a.createDate);
}
case clsvSysSocialRelationsEN.con_ShareId:
return (a: clsvSysSocialRelationsEN, b: clsvSysSocialRelationsEN) => {
return b.shareId.localeCompare(a.shareId);
}
case clsvSysSocialRelationsEN.con_PdfContent:
return (a: clsvSysSocialRelationsEN, b: clsvSysSocialRelationsEN) => {
return b.pdfContent.localeCompare(a.pdfContent);
}
case clsvSysSocialRelationsEN.con_PdfPageNum:
return (a: clsvSysSocialRelationsEN, b: clsvSysSocialRelationsEN) => {
return b.pdfPageNum-a.pdfPageNum;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vSysSocialRelations]中不存在！(in ${ vSysSocialRelations_ConstructorName}.${ strThisFuncName})`;
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
export async function vSysSocialRelations_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsvSysSocialRelationsEN.con_SocialId:
return (obj: clsvSysSocialRelationsEN) => {
return obj.socialId === value;
}
case clsvSysSocialRelationsEN.con_FullName:
return (obj: clsvSysSocialRelationsEN) => {
return obj.fullName === value;
}
case clsvSysSocialRelationsEN.con_Nationality:
return (obj: clsvSysSocialRelationsEN) => {
return obj.nationality === value;
}
case clsvSysSocialRelationsEN.con_WorkUnit:
return (obj: clsvSysSocialRelationsEN) => {
return obj.workUnit === value;
}
case clsvSysSocialRelationsEN.con_Major:
return (obj: clsvSysSocialRelationsEN) => {
return obj.major === value;
}
case clsvSysSocialRelationsEN.con_Achievement:
return (obj: clsvSysSocialRelationsEN) => {
return obj.achievement === value;
}
case clsvSysSocialRelationsEN.con_DetailedDescription:
return (obj: clsvSysSocialRelationsEN) => {
return obj.detailedDescription === value;
}
case clsvSysSocialRelationsEN.con_LevelId:
return (obj: clsvSysSocialRelationsEN) => {
return obj.levelId === value;
}
case clsvSysSocialRelationsEN.con_LevelName:
return (obj: clsvSysSocialRelationsEN) => {
return obj.levelName === value;
}
case clsvSysSocialRelationsEN.con_UpdUser:
return (obj: clsvSysSocialRelationsEN) => {
return obj.updUser === value;
}
case clsvSysSocialRelationsEN.con_UpdDate:
return (obj: clsvSysSocialRelationsEN) => {
return obj.updDate === value;
}
case clsvSysSocialRelationsEN.con_IsSubmit:
return (obj: clsvSysSocialRelationsEN) => {
return obj.isSubmit === value;
}
case clsvSysSocialRelationsEN.con_OkCount:
return (obj: clsvSysSocialRelationsEN) => {
return obj.okCount === value;
}
case clsvSysSocialRelationsEN.con_CitationCount:
return (obj: clsvSysSocialRelationsEN) => {
return obj.citationCount === value;
}
case clsvSysSocialRelationsEN.con_VersionCount:
return (obj: clsvSysSocialRelationsEN) => {
return obj.versionCount === value;
}
case clsvSysSocialRelationsEN.con_id_CurrEduCls:
return (obj: clsvSysSocialRelationsEN) => {
return obj.id_CurrEduCls === value;
}
case clsvSysSocialRelationsEN.con_Memo:
return (obj: clsvSysSocialRelationsEN) => {
return obj.memo === value;
}
case clsvSysSocialRelationsEN.con_AppraiseCount:
return (obj: clsvSysSocialRelationsEN) => {
return obj.appraiseCount === value;
}
case clsvSysSocialRelationsEN.con_score:
return (obj: clsvSysSocialRelationsEN) => {
return obj.score === value;
}
case clsvSysSocialRelationsEN.con_StuScore:
return (obj: clsvSysSocialRelationsEN) => {
return obj.stuScore === value;
}
case clsvSysSocialRelationsEN.con_TeaScore:
return (obj: clsvSysSocialRelationsEN) => {
return obj.teaScore === value;
}
case clsvSysSocialRelationsEN.con_CitationId:
return (obj: clsvSysSocialRelationsEN) => {
return obj.citationId === value;
}
case clsvSysSocialRelationsEN.con_CreateDate:
return (obj: clsvSysSocialRelationsEN) => {
return obj.createDate === value;
}
case clsvSysSocialRelationsEN.con_ShareId:
return (obj: clsvSysSocialRelationsEN) => {
return obj.shareId === value;
}
case clsvSysSocialRelationsEN.con_PdfContent:
return (obj: clsvSysSocialRelationsEN) => {
return obj.pdfContent === value;
}
case clsvSysSocialRelationsEN.con_PdfPageNum:
return (obj: clsvSysSocialRelationsEN) => {
return obj.pdfPageNum === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vSysSocialRelations]中不存在！(in ${ vSysSocialRelations_ConstructorName}.${ strThisFuncName})`;
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
export async function vSysSocialRelations_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vSysSocialRelations_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysSocialRelations_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysSocialRelations_ConstructorName, strThisFuncName);
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
export async function vSysSocialRelations_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vSysSocialRelations_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysSocialRelations_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysSocialRelations_ConstructorName, strThisFuncName);
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
export async function vSysSocialRelations_GetFirstObjAsync(strWhereCond: string): Promise<clsvSysSocialRelationsEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(vSysSocialRelations_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vSysSocialRelations_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvSysSocialRelations = vSysSocialRelations_GetObjFromJsonObj(returnObj);
return objvSysSocialRelations;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysSocialRelations_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysSocialRelations_ConstructorName, strThisFuncName);
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
export async function vSysSocialRelations_GetObjLst_ClientCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsvSysSocialRelationsEN._CurrTabName, strid_CurrEduCls);
clsvSysSocialRelationsEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvSysSocialRelationsEN._CurrTabName);
if (IsNullOrEmpty(clsvSysSocialRelationsEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvSysSocialRelationsEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrvSysSocialRelationsExObjLst_Cache: Array<clsvSysSocialRelationsEN> = CacheHelper.Get(strKey);
const arrvSysSocialRelationsObjLst_T = vSysSocialRelations_GetObjLstByJSONObjLst(arrvSysSocialRelationsExObjLst_Cache);
return arrvSysSocialRelationsObjLst_T;
}
try
{
const arrvSysSocialRelationsExObjLst = await vSysSocialRelations_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrvSysSocialRelationsExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvSysSocialRelationsExObjLst.length);
console.log(strInfo);
return arrvSysSocialRelationsExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vSysSocialRelations_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vSysSocialRelations_GetObjLst_localStorage(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsvSysSocialRelationsEN._CurrTabName, strid_CurrEduCls);
clsvSysSocialRelationsEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvSysSocialRelationsEN._CurrTabName);
if (IsNullOrEmpty(clsvSysSocialRelationsEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvSysSocialRelationsEN.CacheAddiCondition);
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
const arrvSysSocialRelationsExObjLst_Cache: Array<clsvSysSocialRelationsEN> = JSON.parse(strTempObjLst);
const arrvSysSocialRelationsObjLst_T = vSysSocialRelations_GetObjLstByJSONObjLst(arrvSysSocialRelationsExObjLst_Cache);
return arrvSysSocialRelationsObjLst_T;
}
try
{
const arrvSysSocialRelationsExObjLst = await vSysSocialRelations_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrvSysSocialRelationsExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvSysSocialRelationsExObjLst.length);
console.log(strInfo);
return arrvSysSocialRelationsExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vSysSocialRelations_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vSysSocialRelations_GetObjLst_localStorage_PureCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsvSysSocialRelationsEN._CurrTabName, strid_CurrEduCls);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrvSysSocialRelationsObjLst_Cache: Array<clsvSysSocialRelationsEN> = JSON.parse(strTempObjLst);
return arrvSysSocialRelationsObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function vSysSocialRelations_GetObjLstAsync(strWhereCond: string): Promise<Array<clsvSysSocialRelationsEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(vSysSocialRelations_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vSysSocialRelations_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vSysSocialRelations_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysSocialRelations_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysSocialRelations_ConstructorName, strThisFuncName);
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
export async function vSysSocialRelations_GetObjLst_sessionStorage(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsvSysSocialRelationsEN._CurrTabName, strid_CurrEduCls);
clsvSysSocialRelationsEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvSysSocialRelationsEN._CurrTabName);
if (IsNullOrEmpty(clsvSysSocialRelationsEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvSysSocialRelationsEN.CacheAddiCondition);
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
const arrvSysSocialRelationsExObjLst_Cache: Array<clsvSysSocialRelationsEN> = JSON.parse(strTempObjLst);
const arrvSysSocialRelationsObjLst_T = vSysSocialRelations_GetObjLstByJSONObjLst(arrvSysSocialRelationsExObjLst_Cache);
return arrvSysSocialRelationsObjLst_T;
}
try
{
const arrvSysSocialRelationsExObjLst = await vSysSocialRelations_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrvSysSocialRelationsExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvSysSocialRelationsExObjLst.length);
console.log(strInfo);
return arrvSysSocialRelationsExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vSysSocialRelations_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vSysSocialRelations_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsvSysSocialRelationsEN._CurrTabName, strid_CurrEduCls);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrvSysSocialRelationsObjLst_Cache: Array<clsvSysSocialRelationsEN> = JSON.parse(strTempObjLst);
return arrvSysSocialRelationsObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vSysSocialRelations_GetObjLst_Cache(strid_CurrEduCls: string): Promise<Array<clsvSysSocialRelationsEN>>
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
let arrvSysSocialRelationsObjLst_Cache;
switch (clsvSysSocialRelationsEN.CacheModeId)
{
case "04"://sessionStorage
arrvSysSocialRelationsObjLst_Cache = await vSysSocialRelations_GetObjLst_sessionStorage(strid_CurrEduCls);
break;
case "03"://localStorage
arrvSysSocialRelationsObjLst_Cache = await vSysSocialRelations_GetObjLst_localStorage(strid_CurrEduCls);
break;
case "02"://ClientCache
arrvSysSocialRelationsObjLst_Cache = await vSysSocialRelations_GetObjLst_ClientCache(strid_CurrEduCls);
break;
default:
arrvSysSocialRelationsObjLst_Cache = await vSysSocialRelations_GetObjLst_ClientCache(strid_CurrEduCls);
break;
}
const arrvSysSocialRelationsObjLst = vSysSocialRelations_GetObjLstByJSONObjLst(arrvSysSocialRelationsObjLst_Cache);
return arrvSysSocialRelationsObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vSysSocialRelations_GetObjLst_PureCache(strid_CurrEduCls: string)
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrvSysSocialRelationsObjLst_Cache;
switch (clsvSysSocialRelationsEN.CacheModeId)
{
case "04"://sessionStorage
arrvSysSocialRelationsObjLst_Cache = await vSysSocialRelations_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls);
break;
case "03"://localStorage
arrvSysSocialRelationsObjLst_Cache = await vSysSocialRelations_GetObjLst_localStorage_PureCache(strid_CurrEduCls);
break;
case "02"://ClientCache
arrvSysSocialRelationsObjLst_Cache = null;
break;
default:
arrvSysSocialRelationsObjLst_Cache = null;
break;
}
return arrvSysSocialRelationsObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrSocialId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vSysSocialRelations_GetSubObjLst_Cache(objvSysSocialRelations_Cond: clsvSysSocialRelationsEN,strid_CurrEduCls: string) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrvSysSocialRelationsObjLst_Cache = await vSysSocialRelations_GetObjLst_Cache(strid_CurrEduCls);
let arrvSysSocialRelations_Sel: Array < clsvSysSocialRelationsEN > = arrvSysSocialRelationsObjLst_Cache;
if (objvSysSocialRelations_Cond.sf_FldComparisonOp == null || objvSysSocialRelations_Cond.sf_FldComparisonOp == "") return arrvSysSocialRelations_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvSysSocialRelations_Cond.sf_FldComparisonOp);
//console.log("clsvSysSocialRelationsWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvSysSocialRelations_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvSysSocialRelations_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvSysSocialRelations_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objvSysSocialRelations_Cond), vSysSocialRelations_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvSysSocialRelationsEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrSocialId:关键字列表
 * @returns 对象列表
 **/
export async function vSysSocialRelations_GetObjLstBySocialIdLstAsync(arrSocialId: Array<string>): Promise<Array<clsvSysSocialRelationsEN>>  
{
const strThisFuncName = "GetObjLstBySocialIdLstAsync";
const strAction = "GetObjLstBySocialIdLst";
const strUrl = GetWebApiUrl(vSysSocialRelations_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrSocialId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vSysSocialRelations_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vSysSocialRelations_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysSocialRelations_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysSocialRelations_ConstructorName, strThisFuncName);
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
 * @param arrstrSocialIdLst:关键字列表
 * @returns 对象列表
*/
export async function vSysSocialRelations_GetObjLstBySocialIdLst_Cache(arrSocialIdLst: Array<string>,strid_CurrEduCls: string) {
const strThisFuncName = "GetObjLstBySocialIdLst_Cache";
try
{
const arrvSysSocialRelationsObjLst_Cache = await vSysSocialRelations_GetObjLst_Cache(strid_CurrEduCls);
const arrvSysSocialRelations_Sel: Array <clsvSysSocialRelationsEN> = arrvSysSocialRelationsObjLst_Cache.filter(x => arrSocialIdLst.indexOf(x.socialId)>-1);
return arrvSysSocialRelations_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrSocialIdLst.join(","), vSysSocialRelations_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvSysSocialRelationsEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function vSysSocialRelations_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsvSysSocialRelationsEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(vSysSocialRelations_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vSysSocialRelations_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vSysSocialRelations_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysSocialRelations_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysSocialRelations_ConstructorName, strThisFuncName);
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
export async function vSysSocialRelations_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsvSysSocialRelationsEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vSysSocialRelations_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vSysSocialRelations_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vSysSocialRelations_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysSocialRelations_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysSocialRelations_ConstructorName, strThisFuncName);
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
export async function vSysSocialRelations_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vSysSocialRelations_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysSocialRelations_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysSocialRelations_ConstructorName, strThisFuncName);
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
export async function vSysSocialRelations_GetObjLstByPager_Cache(objPagerPara: stuPagerPara,strid_CurrEduCls: string) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrvSysSocialRelationsObjLst_Cache = await vSysSocialRelations_GetObjLst_Cache(strid_CurrEduCls);
if (arrvSysSocialRelationsObjLst_Cache.length == 0) return arrvSysSocialRelationsObjLst_Cache;
let arrvSysSocialRelations_Sel = arrvSysSocialRelationsObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objvSysSocialRelations_Cond = new clsvSysSocialRelationsEN();
ObjectAssign(objvSysSocialRelations_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsvSysSocialRelationsWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvSysSocialRelations_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvSysSocialRelations_Sel.length == 0) return arrvSysSocialRelations_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.sort(vSysSocialRelations_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.sort(objPagerPara.sortFun);
}
arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.slice(intStart, intEnd);     
return arrvSysSocialRelations_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, vSysSocialRelations_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvSysSocialRelationsEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function vSysSocialRelations_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsvSysSocialRelationsEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(vSysSocialRelations_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vSysSocialRelations_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vSysSocialRelations_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysSocialRelations_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysSocialRelations_ConstructorName, strThisFuncName);
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
 * @param objstrSocialId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vSysSocialRelations_IsExistRecord_Cache(objvSysSocialRelations_Cond: clsvSysSocialRelationsEN,strid_CurrEduCls: string) {
const strThisFuncName = "IsExistRecord_Cache";
const arrvSysSocialRelationsObjLst_Cache = await vSysSocialRelations_GetObjLst_Cache(strid_CurrEduCls);
if (arrvSysSocialRelationsObjLst_Cache == null) return false;
let arrvSysSocialRelations_Sel: Array < clsvSysSocialRelationsEN > = arrvSysSocialRelationsObjLst_Cache;
if (objvSysSocialRelations_Cond.sf_FldComparisonOp == null || objvSysSocialRelations_Cond.sf_FldComparisonOp == "") return arrvSysSocialRelations_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvSysSocialRelations_Cond.sf_FldComparisonOp);
//console.log("clsvSysSocialRelationsWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvSysSocialRelations_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvSysSocialRelations_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvSysSocialRelations_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objvSysSocialRelations_Cond), vSysSocialRelations_ConstructorName, strThisFuncName);
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
export async function vSysSocialRelations_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(vSysSocialRelations_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysSocialRelations_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysSocialRelations_ConstructorName, strThisFuncName);
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
 * @param strSocialId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function vSysSocialRelations_IsExist(strSocialId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vSysSocialRelations_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"SocialId": strSocialId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysSocialRelations_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysSocialRelations_ConstructorName, strThisFuncName);
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
 * @param strSocialId:所给的关键字
 * @returns 对象
*/
export async function vSysSocialRelations_IsExist_Cache(strSocialId:string,strid_CurrEduCls:string) {
const strThisFuncName = "IsExist_Cache";
const arrvSysSocialRelationsObjLst_Cache = await vSysSocialRelations_GetObjLst_Cache(strid_CurrEduCls);
if (arrvSysSocialRelationsObjLst_Cache == null) return false;
try
{
const arrvSysSocialRelations_Sel: Array <clsvSysSocialRelationsEN> = arrvSysSocialRelationsObjLst_Cache.filter(x => x.socialId == strSocialId);
if (arrvSysSocialRelations_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strSocialId, vSysSocialRelations_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param strSocialId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function vSysSocialRelations_IsExistAsync(strSocialId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vSysSocialRelations_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strSocialId": strSocialId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysSocialRelations_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysSocialRelations_ConstructorName, strThisFuncName);
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
export async function vSysSocialRelations_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(vSysSocialRelations_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysSocialRelations_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysSocialRelations_ConstructorName, strThisFuncName);
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
 * @param objvSysSocialRelations_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function vSysSocialRelations_GetRecCountByCond_Cache(objvSysSocialRelations_Cond: clsvSysSocialRelationsEN,strid_CurrEduCls: string) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrvSysSocialRelationsObjLst_Cache = await vSysSocialRelations_GetObjLst_Cache(strid_CurrEduCls);
if (arrvSysSocialRelationsObjLst_Cache == null) return 0;
let arrvSysSocialRelations_Sel: Array < clsvSysSocialRelationsEN > = arrvSysSocialRelationsObjLst_Cache;
if (objvSysSocialRelations_Cond.sf_FldComparisonOp == null || objvSysSocialRelations_Cond.sf_FldComparisonOp == "") return arrvSysSocialRelations_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvSysSocialRelations_Cond.sf_FldComparisonOp);
//console.log("clsvSysSocialRelationsWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvSysSocialRelations_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvSysSocialRelations_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvSysSocialRelations_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objvSysSocialRelations_Cond), vSysSocialRelations_ConstructorName, strThisFuncName);
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
export function vSysSocialRelations_GetWebApiUrl(strController: string, strAction: string): string {
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
export function vSysSocialRelations_ReFreshThisCache(strid_CurrEduCls: string):void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = Format("{0}_{1}", clsvSysSocialRelationsEN._CurrTabName, strid_CurrEduCls);
switch (clsvSysSocialRelationsEN.CacheModeId)
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
export async function vSysSocialRelations__Cache(strDivName: string, strDdlName: string , strid_CurrEduCls: string)
{
const strThisFuncName = "_Cache";

if (IsNullOrEmpty(strid_CurrEduCls) == true)
{
  const strMsg = Format("参数:[strid_CurrEduCls]不能为空！(In )");
console.error(strMsg);
 throw (strMsg);
}
if (strid_CurrEduCls.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！", strid_CurrEduCls.length);
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
const arrObjLst_Sel = await vSysSocialRelations_GetObjLst_Cache(strid_CurrEduCls);
if (arrObjLst_Sel == null) return;
BindDdl_ObjLstInDiv_V(strDivName, strDdlName, arrObjLst_Sel, clsvSysSocialRelationsEN.con_SocialId, clsvSysSocialRelationsEN.con_LevelName, "社会关系表视图");
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vSysSocialRelations_GetJSONStrByObj (pobjvSysSocialRelationsEN: clsvSysSocialRelationsEN): string
{
const strThisFuncName = "GetJSONStrByObj";
let strJson = "";
try
{
strJson = JSON.stringify(pobjvSysSocialRelationsEN);
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
export function vSysSocialRelations_GetObjLstByJSONStr (strJSON: string): Array<clsvSysSocialRelationsEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrvSysSocialRelationsObjLst = new Array<clsvSysSocialRelationsEN>();
if (strJSON === "")
{
return arrvSysSocialRelationsObjLst;
}
try
{
arrvSysSocialRelationsObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvSysSocialRelationsObjLst;
}
return arrvSysSocialRelationsObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrvSysSocialRelationsObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function vSysSocialRelations_GetObjLstByJSONObjLst (arrvSysSocialRelationsObjLstS: Array<clsvSysSocialRelationsEN>): Array<clsvSysSocialRelationsEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrvSysSocialRelationsObjLst = new Array<clsvSysSocialRelationsEN>();
for (const objInFor of arrvSysSocialRelationsObjLstS) {
const obj1 = vSysSocialRelations_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrvSysSocialRelationsObjLst.push(obj1);
}
return arrvSysSocialRelationsObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vSysSocialRelations_GetObjByJSONStr (strJSON: string): clsvSysSocialRelationsEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjvSysSocialRelationsEN = new clsvSysSocialRelationsEN();
if (strJSON === "")
{
return pobjvSysSocialRelationsEN;
}
try
{
pobjvSysSocialRelationsEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvSysSocialRelationsEN;
}
return pobjvSysSocialRelationsEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function vSysSocialRelations_GetCombineCondition(objvSysSocialRelations_Cond: clsvSysSocialRelationsEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objvSysSocialRelations_Cond.dicFldComparisonOp, clsvSysSocialRelationsEN.con_SocialId) == true)
{
const strComparisonOp_SocialId:string = objvSysSocialRelations_Cond.dicFldComparisonOp[clsvSysSocialRelationsEN.con_SocialId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysSocialRelationsEN.con_SocialId, objvSysSocialRelations_Cond.socialId, strComparisonOp_SocialId);
}
if (Object.prototype.hasOwnProperty.call(objvSysSocialRelations_Cond.dicFldComparisonOp, clsvSysSocialRelationsEN.con_FullName) == true)
{
const strComparisonOp_FullName:string = objvSysSocialRelations_Cond.dicFldComparisonOp[clsvSysSocialRelationsEN.con_FullName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysSocialRelationsEN.con_FullName, objvSysSocialRelations_Cond.fullName, strComparisonOp_FullName);
}
if (Object.prototype.hasOwnProperty.call(objvSysSocialRelations_Cond.dicFldComparisonOp, clsvSysSocialRelationsEN.con_Nationality) == true)
{
const strComparisonOp_Nationality:string = objvSysSocialRelations_Cond.dicFldComparisonOp[clsvSysSocialRelationsEN.con_Nationality];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysSocialRelationsEN.con_Nationality, objvSysSocialRelations_Cond.nationality, strComparisonOp_Nationality);
}
if (Object.prototype.hasOwnProperty.call(objvSysSocialRelations_Cond.dicFldComparisonOp, clsvSysSocialRelationsEN.con_WorkUnit) == true)
{
const strComparisonOp_WorkUnit:string = objvSysSocialRelations_Cond.dicFldComparisonOp[clsvSysSocialRelationsEN.con_WorkUnit];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysSocialRelationsEN.con_WorkUnit, objvSysSocialRelations_Cond.workUnit, strComparisonOp_WorkUnit);
}
if (Object.prototype.hasOwnProperty.call(objvSysSocialRelations_Cond.dicFldComparisonOp, clsvSysSocialRelationsEN.con_Major) == true)
{
const strComparisonOp_Major:string = objvSysSocialRelations_Cond.dicFldComparisonOp[clsvSysSocialRelationsEN.con_Major];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysSocialRelationsEN.con_Major, objvSysSocialRelations_Cond.major, strComparisonOp_Major);
}
if (Object.prototype.hasOwnProperty.call(objvSysSocialRelations_Cond.dicFldComparisonOp, clsvSysSocialRelationsEN.con_Achievement) == true)
{
const strComparisonOp_Achievement:string = objvSysSocialRelations_Cond.dicFldComparisonOp[clsvSysSocialRelationsEN.con_Achievement];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysSocialRelationsEN.con_Achievement, objvSysSocialRelations_Cond.achievement, strComparisonOp_Achievement);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objvSysSocialRelations_Cond.dicFldComparisonOp, clsvSysSocialRelationsEN.con_LevelId) == true)
{
const strComparisonOp_LevelId:string = objvSysSocialRelations_Cond.dicFldComparisonOp[clsvSysSocialRelationsEN.con_LevelId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysSocialRelationsEN.con_LevelId, objvSysSocialRelations_Cond.levelId, strComparisonOp_LevelId);
}
if (Object.prototype.hasOwnProperty.call(objvSysSocialRelations_Cond.dicFldComparisonOp, clsvSysSocialRelationsEN.con_LevelName) == true)
{
const strComparisonOp_LevelName:string = objvSysSocialRelations_Cond.dicFldComparisonOp[clsvSysSocialRelationsEN.con_LevelName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysSocialRelationsEN.con_LevelName, objvSysSocialRelations_Cond.levelName, strComparisonOp_LevelName);
}
if (Object.prototype.hasOwnProperty.call(objvSysSocialRelations_Cond.dicFldComparisonOp, clsvSysSocialRelationsEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objvSysSocialRelations_Cond.dicFldComparisonOp[clsvSysSocialRelationsEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysSocialRelationsEN.con_UpdUser, objvSysSocialRelations_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objvSysSocialRelations_Cond.dicFldComparisonOp, clsvSysSocialRelationsEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objvSysSocialRelations_Cond.dicFldComparisonOp[clsvSysSocialRelationsEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysSocialRelationsEN.con_UpdDate, objvSysSocialRelations_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objvSysSocialRelations_Cond.dicFldComparisonOp, clsvSysSocialRelationsEN.con_IsSubmit) == true)
{
if (objvSysSocialRelations_Cond.isSubmit == true)
{
strWhereCond += Format(" And {0} = '1'", clsvSysSocialRelationsEN.con_IsSubmit);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvSysSocialRelationsEN.con_IsSubmit);
}
}
if (Object.prototype.hasOwnProperty.call(objvSysSocialRelations_Cond.dicFldComparisonOp, clsvSysSocialRelationsEN.con_OkCount) == true)
{
const strComparisonOp_OkCount:string = objvSysSocialRelations_Cond.dicFldComparisonOp[clsvSysSocialRelationsEN.con_OkCount];
strWhereCond += Format(" And {0} {2} {1}", clsvSysSocialRelationsEN.con_OkCount, objvSysSocialRelations_Cond.okCount, strComparisonOp_OkCount);
}
if (Object.prototype.hasOwnProperty.call(objvSysSocialRelations_Cond.dicFldComparisonOp, clsvSysSocialRelationsEN.con_CitationCount) == true)
{
const strComparisonOp_CitationCount:string = objvSysSocialRelations_Cond.dicFldComparisonOp[clsvSysSocialRelationsEN.con_CitationCount];
strWhereCond += Format(" And {0} {2} {1}", clsvSysSocialRelationsEN.con_CitationCount, objvSysSocialRelations_Cond.citationCount, strComparisonOp_CitationCount);
}
if (Object.prototype.hasOwnProperty.call(objvSysSocialRelations_Cond.dicFldComparisonOp, clsvSysSocialRelationsEN.con_VersionCount) == true)
{
const strComparisonOp_VersionCount:string = objvSysSocialRelations_Cond.dicFldComparisonOp[clsvSysSocialRelationsEN.con_VersionCount];
strWhereCond += Format(" And {0} {2} {1}", clsvSysSocialRelationsEN.con_VersionCount, objvSysSocialRelations_Cond.versionCount, strComparisonOp_VersionCount);
}
if (Object.prototype.hasOwnProperty.call(objvSysSocialRelations_Cond.dicFldComparisonOp, clsvSysSocialRelationsEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objvSysSocialRelations_Cond.dicFldComparisonOp[clsvSysSocialRelationsEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysSocialRelationsEN.con_id_CurrEduCls, objvSysSocialRelations_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (Object.prototype.hasOwnProperty.call(objvSysSocialRelations_Cond.dicFldComparisonOp, clsvSysSocialRelationsEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objvSysSocialRelations_Cond.dicFldComparisonOp[clsvSysSocialRelationsEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysSocialRelationsEN.con_Memo, objvSysSocialRelations_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objvSysSocialRelations_Cond.dicFldComparisonOp, clsvSysSocialRelationsEN.con_AppraiseCount) == true)
{
const strComparisonOp_AppraiseCount:string = objvSysSocialRelations_Cond.dicFldComparisonOp[clsvSysSocialRelationsEN.con_AppraiseCount];
strWhereCond += Format(" And {0} {2} {1}", clsvSysSocialRelationsEN.con_AppraiseCount, objvSysSocialRelations_Cond.appraiseCount, strComparisonOp_AppraiseCount);
}
if (Object.prototype.hasOwnProperty.call(objvSysSocialRelations_Cond.dicFldComparisonOp, clsvSysSocialRelationsEN.con_score) == true)
{
const strComparisonOp_score:string = objvSysSocialRelations_Cond.dicFldComparisonOp[clsvSysSocialRelationsEN.con_score];
strWhereCond += Format(" And {0} {2} {1}", clsvSysSocialRelationsEN.con_score, objvSysSocialRelations_Cond.score, strComparisonOp_score);
}
if (Object.prototype.hasOwnProperty.call(objvSysSocialRelations_Cond.dicFldComparisonOp, clsvSysSocialRelationsEN.con_StuScore) == true)
{
const strComparisonOp_StuScore:string = objvSysSocialRelations_Cond.dicFldComparisonOp[clsvSysSocialRelationsEN.con_StuScore];
strWhereCond += Format(" And {0} {2} {1}", clsvSysSocialRelationsEN.con_StuScore, objvSysSocialRelations_Cond.stuScore, strComparisonOp_StuScore);
}
if (Object.prototype.hasOwnProperty.call(objvSysSocialRelations_Cond.dicFldComparisonOp, clsvSysSocialRelationsEN.con_TeaScore) == true)
{
const strComparisonOp_TeaScore:string = objvSysSocialRelations_Cond.dicFldComparisonOp[clsvSysSocialRelationsEN.con_TeaScore];
strWhereCond += Format(" And {0} {2} {1}", clsvSysSocialRelationsEN.con_TeaScore, objvSysSocialRelations_Cond.teaScore, strComparisonOp_TeaScore);
}
if (Object.prototype.hasOwnProperty.call(objvSysSocialRelations_Cond.dicFldComparisonOp, clsvSysSocialRelationsEN.con_CitationId) == true)
{
const strComparisonOp_CitationId:string = objvSysSocialRelations_Cond.dicFldComparisonOp[clsvSysSocialRelationsEN.con_CitationId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysSocialRelationsEN.con_CitationId, objvSysSocialRelations_Cond.citationId, strComparisonOp_CitationId);
}
if (Object.prototype.hasOwnProperty.call(objvSysSocialRelations_Cond.dicFldComparisonOp, clsvSysSocialRelationsEN.con_CreateDate) == true)
{
const strComparisonOp_CreateDate:string = objvSysSocialRelations_Cond.dicFldComparisonOp[clsvSysSocialRelationsEN.con_CreateDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysSocialRelationsEN.con_CreateDate, objvSysSocialRelations_Cond.createDate, strComparisonOp_CreateDate);
}
if (Object.prototype.hasOwnProperty.call(objvSysSocialRelations_Cond.dicFldComparisonOp, clsvSysSocialRelationsEN.con_ShareId) == true)
{
const strComparisonOp_ShareId:string = objvSysSocialRelations_Cond.dicFldComparisonOp[clsvSysSocialRelationsEN.con_ShareId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysSocialRelationsEN.con_ShareId, objvSysSocialRelations_Cond.shareId, strComparisonOp_ShareId);
}
if (Object.prototype.hasOwnProperty.call(objvSysSocialRelations_Cond.dicFldComparisonOp, clsvSysSocialRelationsEN.con_PdfContent) == true)
{
const strComparisonOp_PdfContent:string = objvSysSocialRelations_Cond.dicFldComparisonOp[clsvSysSocialRelationsEN.con_PdfContent];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysSocialRelationsEN.con_PdfContent, objvSysSocialRelations_Cond.pdfContent, strComparisonOp_PdfContent);
}
if (Object.prototype.hasOwnProperty.call(objvSysSocialRelations_Cond.dicFldComparisonOp, clsvSysSocialRelationsEN.con_PdfPageNum) == true)
{
const strComparisonOp_PdfPageNum:string = objvSysSocialRelations_Cond.dicFldComparisonOp[clsvSysSocialRelationsEN.con_PdfPageNum];
strWhereCond += Format(" And {0} {2} {1}", clsvSysSocialRelationsEN.con_PdfPageNum, objvSysSocialRelations_Cond.pdfPageNum, strComparisonOp_PdfPageNum);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--vSysSocialRelations(社会关系表视图),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param strSocialId: 社会Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function vSysSocialRelations_GetUniCondStr_SocialId(objvSysSocialRelationsEN: clsvSysSocialRelationsEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and SocialId = '{0}'", objvSysSocialRelationsEN.socialId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--vSysSocialRelations(社会关系表视图),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param strSocialId: 社会Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function vSysSocialRelations_GetUniCondStr4Update_SocialId(objvSysSocialRelationsEN: clsvSysSocialRelationsEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and SocialId <> '{0}'", objvSysSocialRelationsEN.socialId);
 strWhereCond +=  Format(" and SocialId = '{0}'", objvSysSocialRelationsEN.socialId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objvSysSocialRelationsENS:源对象
 * @param objvSysSocialRelationsENT:目标对象
*/
export function vSysSocialRelations_CopyObjTo(objvSysSocialRelationsENS: clsvSysSocialRelationsEN , objvSysSocialRelationsENT: clsvSysSocialRelationsEN ): void 
{
objvSysSocialRelationsENT.socialId = objvSysSocialRelationsENS.socialId; //社会Id
objvSysSocialRelationsENT.fullName = objvSysSocialRelationsENS.fullName; //姓名
objvSysSocialRelationsENT.nationality = objvSysSocialRelationsENS.nationality; //国籍
objvSysSocialRelationsENT.workUnit = objvSysSocialRelationsENS.workUnit; //工作单位
objvSysSocialRelationsENT.major = objvSysSocialRelationsENS.major; //专业
objvSysSocialRelationsENT.achievement = objvSysSocialRelationsENS.achievement; //成就
objvSysSocialRelationsENT.detailedDescription = objvSysSocialRelationsENS.detailedDescription; //详细说明
objvSysSocialRelationsENT.levelId = objvSysSocialRelationsENS.levelId; //级别Id
objvSysSocialRelationsENT.levelName = objvSysSocialRelationsENS.levelName; //级别名称
objvSysSocialRelationsENT.updUser = objvSysSocialRelationsENS.updUser; //修改人
objvSysSocialRelationsENT.updDate = objvSysSocialRelationsENS.updDate; //修改日期
objvSysSocialRelationsENT.isSubmit = objvSysSocialRelationsENS.isSubmit; //是否提交
objvSysSocialRelationsENT.okCount = objvSysSocialRelationsENS.okCount; //点赞统计
objvSysSocialRelationsENT.citationCount = objvSysSocialRelationsENS.citationCount; //引用统计
objvSysSocialRelationsENT.versionCount = objvSysSocialRelationsENS.versionCount; //版本统计
objvSysSocialRelationsENT.id_CurrEduCls = objvSysSocialRelationsENS.id_CurrEduCls; //教学班流水号
objvSysSocialRelationsENT.memo = objvSysSocialRelationsENS.memo; //备注
objvSysSocialRelationsENT.appraiseCount = objvSysSocialRelationsENS.appraiseCount; //评论数
objvSysSocialRelationsENT.score = objvSysSocialRelationsENS.score; //评分
objvSysSocialRelationsENT.stuScore = objvSysSocialRelationsENS.stuScore; //学生平均分
objvSysSocialRelationsENT.teaScore = objvSysSocialRelationsENS.teaScore; //教师评分
objvSysSocialRelationsENT.citationId = objvSysSocialRelationsENS.citationId; //引用Id
objvSysSocialRelationsENT.createDate = objvSysSocialRelationsENS.createDate; //建立日期
objvSysSocialRelationsENT.shareId = objvSysSocialRelationsENS.shareId; //分享Id
objvSysSocialRelationsENT.pdfContent = objvSysSocialRelationsENS.pdfContent; //Pdf内容
objvSysSocialRelationsENT.pdfPageNum = objvSysSocialRelationsENS.pdfPageNum; //Pdf页码
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objvSysSocialRelationsENS:源对象
 * @param objvSysSocialRelationsENT:目标对象
*/
export function vSysSocialRelations_GetObjFromJsonObj(objvSysSocialRelationsENS: clsvSysSocialRelationsEN): clsvSysSocialRelationsEN 
{
 const objvSysSocialRelationsENT: clsvSysSocialRelationsEN = new clsvSysSocialRelationsEN();
ObjectAssign(objvSysSocialRelationsENT, objvSysSocialRelationsENS);
 return objvSysSocialRelationsENT;
}