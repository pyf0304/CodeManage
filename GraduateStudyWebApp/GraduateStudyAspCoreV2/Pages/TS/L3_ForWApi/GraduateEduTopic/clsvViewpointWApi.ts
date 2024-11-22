
 /**
 * 类名:clsvViewpointWApi
 * 表名:vViewpoint(01120543)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:47:19
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
 * v观点表视图(vViewpoint)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2023年03月13日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { enumComparisonOp } from "../../PubFun/enumComparisonOp.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { clsvViewpointEN } from "../../L0_Entity/GraduateEduTopic/clsvViewpointEN.js";
import { BindDdl_ObjLstInDiv_V, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const vViewpoint_Controller = "vViewpointApi";
 export const vViewpoint_ConstructorName = "vViewpoint";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strViewpointId:关键字
 * @returns 对象
 **/
export async function vViewpoint_GetObjByViewpointIdAsync(strViewpointId: string): Promise<clsvViewpointEN|null>  
{
const strThisFuncName = "GetObjByViewpointIdAsync";

if (IsNullOrEmpty(strViewpointId) == true)
{
  const strMsg = Format("参数:[strViewpointId]不能为空！(In clsvViewpointWApi.GetObjByViewpointIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strViewpointId.length != 8)
{
const strMsg = Format("缓存分类变量:[strViewpointId]的长度:[{0}]不正确！(clsvViewpointWApi.GetObjByViewpointIdAsync)", strViewpointId.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByViewpointId";
const strUrl = GetWebApiUrl(vViewpoint_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strViewpointId": strViewpointId,
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
const objvViewpoint = vViewpoint_GetObjFromJsonObj(returnObj);
return objvViewpoint;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vViewpoint_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vViewpoint_ConstructorName, strThisFuncName);
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
 * @param strViewpointId:所给的关键字
 * @returns 对象
*/
export async function vViewpoint_GetObjByViewpointId_Cache(strViewpointId:string,strid_CurrEduCls:string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByViewpointId_Cache";

if (IsNullOrEmpty(strViewpointId) == true)
{
  const strMsg = Format("参数:[strViewpointId]不能为空！(In clsvViewpointWApi.GetObjByViewpointId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strViewpointId.length != 8)
{
const strMsg = Format("缓存分类变量:[strViewpointId]的长度:[{0}]不正确！(clsvViewpointWApi.GetObjByViewpointId_Cache)", strViewpointId.length);
console.error(strMsg);
throw (strMsg);
}
const arrvViewpointObjLst_Cache = await vViewpoint_GetObjLst_Cache(strid_CurrEduCls);
try
{
const arrvViewpoint_Sel: Array <clsvViewpointEN> = arrvViewpointObjLst_Cache.filter(x => 
 x.viewpointId == strViewpointId );
let objvViewpoint: clsvViewpointEN;
if (arrvViewpoint_Sel.length > 0)
{
objvViewpoint = arrvViewpoint_Sel[0];
return objvViewpoint;
}
else
{
if (bolTryAsyncOnce == true)
{
const objvViewpoint_Const = await vViewpoint_GetObjByViewpointIdAsync(strViewpointId);
if (objvViewpoint_Const != null)
{
vViewpoint_ReFreshThisCache(strid_CurrEduCls);
return objvViewpoint_Const;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strViewpointId, vViewpoint_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param strViewpointId:所给的关键字
 * @returns 对象
*/
export async function vViewpoint_GetObjByViewpointId_localStorage(strViewpointId: string) {
const strThisFuncName = "GetObjByViewpointId_localStorage";

if (IsNullOrEmpty(strViewpointId) == true)
{
  const strMsg = Format("参数:[strViewpointId]不能为空！(In clsvViewpointWApi.GetObjByViewpointId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
if (strViewpointId.length != 8)
{
const strMsg = Format("缓存分类变量:[strViewpointId]的长度:[{0}]不正确！(clsvViewpointWApi.GetObjByViewpointId_localStorage)", strViewpointId.length);
console.error(strMsg);
throw (strMsg);
}
const strKey = Format("{0}_{1}", clsvViewpointEN._CurrTabName, strViewpointId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objvViewpoint_Cache: clsvViewpointEN = JSON.parse(strTempObj);
return objvViewpoint_Cache;
}
try
{
const objvViewpoint = await vViewpoint_GetObjByViewpointIdAsync(strViewpointId);
if (objvViewpoint != null)
{
localStorage.setItem(strKey, JSON.stringify(objvViewpoint));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objvViewpoint;
}
return objvViewpoint;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strViewpointId, vViewpoint_ConstructorName, strThisFuncName);
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
 @param strid_CurrEduCls:缓存的分类字段
 * @returns 返回一个输出字段值
*/
export async function vViewpoint_func(strInFldName:string , strOutFldName:string , strInValue:string 
, strid_CurrEduCls_C: string)
{
//const strThisFuncName = "func";

if (IsNullOrEmpty(strid_CurrEduCls_C) == true)
{
  const strMsg = Format("参数:[strid_CurrEduCls_C]不能为空！(In clsvViewpointWApi.func)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_CurrEduCls_C.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsvViewpointWApi.func)", strid_CurrEduCls_C.length);
console.error(strMsg);
throw (strMsg);
}

if (strInFldName != clsvViewpointEN.con_ViewpointId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsvViewpointEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strOutFldName, clsvViewpointEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strViewpointId = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objvViewpoint = await vViewpoint_GetObjByViewpointId_Cache(strViewpointId , strid_CurrEduCls_C);
if (objvViewpoint == null) return "";
if (objvViewpoint.GetFldValue(strOutFldName) == null) return "";
return objvViewpoint.GetFldValue(strOutFldName).toString();
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
export function vViewpoint_SortFun_Defa(a:clsvViewpointEN , b:clsvViewpointEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.viewpointId.localeCompare(b.viewpointId);
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
export function vViewpoint_SortFun_Defa_2Fld(a:clsvViewpointEN , b:clsvViewpointEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.viewpointName == b.viewpointName) return a.viewpointContent.localeCompare(b.viewpointContent);
else return a.viewpointName.localeCompare(b.viewpointName);
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
export function vViewpoint_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsvViewpointEN.con_ViewpointId:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
return a.viewpointId.localeCompare(b.viewpointId);
}
case clsvViewpointEN.con_ViewpointName:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
if (a.viewpointName == null) return -1;
if (b.viewpointName == null) return 1;
return a.viewpointName.localeCompare(b.viewpointName);
}
case clsvViewpointEN.con_ViewpointContent:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
if (a.viewpointContent == null) return -1;
if (b.viewpointContent == null) return 1;
return a.viewpointContent.localeCompare(b.viewpointContent);
}
case clsvViewpointEN.con_ViewpointTypeId:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
if (a.viewpointTypeId == null) return -1;
if (b.viewpointTypeId == null) return 1;
return a.viewpointTypeId.localeCompare(b.viewpointTypeId);
}
case clsvViewpointEN.con_ViewpointTypeName:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
if (a.viewpointTypeName == null) return -1;
if (b.viewpointTypeName == null) return 1;
return a.viewpointTypeName.localeCompare(b.viewpointTypeName);
}
case clsvViewpointEN.con_Reason:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
if (a.reason == null) return -1;
if (b.reason == null) return 1;
return a.reason.localeCompare(b.reason);
}
case clsvViewpointEN.con_Source:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
if (a.source == null) return -1;
if (b.source == null) return 1;
return a.source.localeCompare(b.source);
}
case clsvViewpointEN.con_VPProposePeople:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
if (a.vpProposePeople == null) return -1;
if (b.vpProposePeople == null) return 1;
return a.vpProposePeople.localeCompare(b.vpProposePeople);
}
case clsvViewpointEN.con_UpdDate:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
if (a.updDate == null) return -1;
if (b.updDate == null) return 1;
return a.updDate.localeCompare(b.updDate);
}
case clsvViewpointEN.con_UpdUser:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
if (a.updUser == null) return -1;
if (b.updUser == null) return 1;
return a.updUser.localeCompare(b.updUser);
}
case clsvViewpointEN.con_Memo:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
if (a.memo == null) return -1;
if (b.memo == null) return 1;
return a.memo.localeCompare(b.memo);
}
case clsvViewpointEN.con_IsSubmit:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
if (a.isSubmit == true) return 1;
else return -1
}
case clsvViewpointEN.con_AppraiseCount:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
return a.appraiseCount-b.appraiseCount;
}
case clsvViewpointEN.con_Score:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
return a.score-b.score;
}
case clsvViewpointEN.con_OkCount:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
return a.okCount-b.okCount;
}
case clsvViewpointEN.con_UserTypeId:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
if (a.userTypeId == null) return -1;
if (b.userTypeId == null) return 1;
return a.userTypeId.localeCompare(b.userTypeId);
}
case clsvViewpointEN.con_UserTypeName:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
if (a.userTypeName == null) return -1;
if (b.userTypeName == null) return 1;
return a.userTypeName.localeCompare(b.userTypeName);
}
case clsvViewpointEN.con_Author:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
if (a.author == null) return -1;
if (b.author == null) return 1;
return a.author.localeCompare(b.author);
}
case clsvViewpointEN.con_CitationId:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
if (a.citationId == null) return -1;
if (b.citationId == null) return 1;
return a.citationId.localeCompare(b.citationId);
}
case clsvViewpointEN.con_Keyword:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
if (a.keyword == null) return -1;
if (b.keyword == null) return 1;
return a.keyword.localeCompare(b.keyword);
}
case clsvViewpointEN.con_PaperTitle:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
if (a.paperTitle == null) return -1;
if (b.paperTitle == null) return 1;
return a.paperTitle.localeCompare(b.paperTitle);
}
case clsvViewpointEN.con_Periodical:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
if (a.periodical == null) return -1;
if (b.periodical == null) return 1;
return a.periodical.localeCompare(b.periodical);
}
case clsvViewpointEN.con_ResearchQuestion:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
if (a.researchQuestion == null) return -1;
if (b.researchQuestion == null) return 1;
return a.researchQuestion.localeCompare(b.researchQuestion);
}
case clsvViewpointEN.con_UploadfileUrl:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
if (a.uploadfileUrl == null) return -1;
if (b.uploadfileUrl == null) return 1;
return a.uploadfileUrl.localeCompare(b.uploadfileUrl);
}
case clsvViewpointEN.con_CitationCount:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
return a.citationCount-b.citationCount;
}
case clsvViewpointEN.con_StuScore:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
return a.stuScore-b.stuScore;
}
case clsvViewpointEN.con_TeaScore:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
return a.teaScore-b.teaScore;
}
case clsvViewpointEN.con_id_CurrEduCls:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
if (a.id_CurrEduCls == null) return -1;
if (b.id_CurrEduCls == null) return 1;
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
case clsvViewpointEN.con_PdfContent:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
if (a.pdfContent == null) return -1;
if (b.pdfContent == null) return 1;
return a.pdfContent.localeCompare(b.pdfContent);
}
case clsvViewpointEN.con_PdfPageNum:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
return a.pdfPageNum-b.pdfPageNum;
}
case clsvViewpointEN.con_VersionCount:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
return a.versionCount-b.versionCount;
}
case clsvViewpointEN.con_CreateDate:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
if (a.createDate == null) return -1;
if (b.createDate == null) return 1;
return a.createDate.localeCompare(b.createDate);
}
case clsvViewpointEN.con_ShareId:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
if (a.shareId == null) return -1;
if (b.shareId == null) return 1;
return a.shareId.localeCompare(b.shareId);
}
case clsvViewpointEN.con_IsRecommend:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
if (a.isRecommend == true) return 1;
else return -1
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vViewpoint]中不存在！(in ${ vViewpoint_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsvViewpointEN.con_ViewpointId:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
return b.viewpointId.localeCompare(a.viewpointId);
}
case clsvViewpointEN.con_ViewpointName:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
if (b.viewpointName == null) return -1;
if (a.viewpointName == null) return 1;
return b.viewpointName.localeCompare(a.viewpointName);
}
case clsvViewpointEN.con_ViewpointContent:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
if (b.viewpointContent == null) return -1;
if (a.viewpointContent == null) return 1;
return b.viewpointContent.localeCompare(a.viewpointContent);
}
case clsvViewpointEN.con_ViewpointTypeId:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
if (b.viewpointTypeId == null) return -1;
if (a.viewpointTypeId == null) return 1;
return b.viewpointTypeId.localeCompare(a.viewpointTypeId);
}
case clsvViewpointEN.con_ViewpointTypeName:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
if (b.viewpointTypeName == null) return -1;
if (a.viewpointTypeName == null) return 1;
return b.viewpointTypeName.localeCompare(a.viewpointTypeName);
}
case clsvViewpointEN.con_Reason:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
if (b.reason == null) return -1;
if (a.reason == null) return 1;
return b.reason.localeCompare(a.reason);
}
case clsvViewpointEN.con_Source:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
if (b.source == null) return -1;
if (a.source == null) return 1;
return b.source.localeCompare(a.source);
}
case clsvViewpointEN.con_VPProposePeople:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
if (b.vpProposePeople == null) return -1;
if (a.vpProposePeople == null) return 1;
return b.vpProposePeople.localeCompare(a.vpProposePeople);
}
case clsvViewpointEN.con_UpdDate:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
if (b.updDate == null) return -1;
if (a.updDate == null) return 1;
return b.updDate.localeCompare(a.updDate);
}
case clsvViewpointEN.con_UpdUser:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
if (b.updUser == null) return -1;
if (a.updUser == null) return 1;
return b.updUser.localeCompare(a.updUser);
}
case clsvViewpointEN.con_Memo:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
if (b.memo == null) return -1;
if (a.memo == null) return 1;
return b.memo.localeCompare(a.memo);
}
case clsvViewpointEN.con_IsSubmit:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
if (b.isSubmit == true) return 1;
else return -1
}
case clsvViewpointEN.con_AppraiseCount:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
return b.appraiseCount-a.appraiseCount;
}
case clsvViewpointEN.con_Score:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
return b.score-a.score;
}
case clsvViewpointEN.con_OkCount:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
return b.okCount-a.okCount;
}
case clsvViewpointEN.con_UserTypeId:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
if (b.userTypeId == null) return -1;
if (a.userTypeId == null) return 1;
return b.userTypeId.localeCompare(a.userTypeId);
}
case clsvViewpointEN.con_UserTypeName:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
if (b.userTypeName == null) return -1;
if (a.userTypeName == null) return 1;
return b.userTypeName.localeCompare(a.userTypeName);
}
case clsvViewpointEN.con_Author:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
if (b.author == null) return -1;
if (a.author == null) return 1;
return b.author.localeCompare(a.author);
}
case clsvViewpointEN.con_CitationId:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
if (b.citationId == null) return -1;
if (a.citationId == null) return 1;
return b.citationId.localeCompare(a.citationId);
}
case clsvViewpointEN.con_Keyword:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
if (b.keyword == null) return -1;
if (a.keyword == null) return 1;
return b.keyword.localeCompare(a.keyword);
}
case clsvViewpointEN.con_PaperTitle:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
if (b.paperTitle == null) return -1;
if (a.paperTitle == null) return 1;
return b.paperTitle.localeCompare(a.paperTitle);
}
case clsvViewpointEN.con_Periodical:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
if (b.periodical == null) return -1;
if (a.periodical == null) return 1;
return b.periodical.localeCompare(a.periodical);
}
case clsvViewpointEN.con_ResearchQuestion:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
if (b.researchQuestion == null) return -1;
if (a.researchQuestion == null) return 1;
return b.researchQuestion.localeCompare(a.researchQuestion);
}
case clsvViewpointEN.con_UploadfileUrl:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
if (b.uploadfileUrl == null) return -1;
if (a.uploadfileUrl == null) return 1;
return b.uploadfileUrl.localeCompare(a.uploadfileUrl);
}
case clsvViewpointEN.con_CitationCount:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
return b.citationCount-a.citationCount;
}
case clsvViewpointEN.con_StuScore:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
return b.stuScore-a.stuScore;
}
case clsvViewpointEN.con_TeaScore:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
return b.teaScore-a.teaScore;
}
case clsvViewpointEN.con_id_CurrEduCls:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
if (b.id_CurrEduCls == null) return -1;
if (a.id_CurrEduCls == null) return 1;
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
case clsvViewpointEN.con_PdfContent:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
if (b.pdfContent == null) return -1;
if (a.pdfContent == null) return 1;
return b.pdfContent.localeCompare(a.pdfContent);
}
case clsvViewpointEN.con_PdfPageNum:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
return b.pdfPageNum-a.pdfPageNum;
}
case clsvViewpointEN.con_VersionCount:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
return b.versionCount-a.versionCount;
}
case clsvViewpointEN.con_CreateDate:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
if (b.createDate == null) return -1;
if (a.createDate == null) return 1;
return b.createDate.localeCompare(a.createDate);
}
case clsvViewpointEN.con_ShareId:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
if (b.shareId == null) return -1;
if (a.shareId == null) return 1;
return b.shareId.localeCompare(a.shareId);
}
case clsvViewpointEN.con_IsRecommend:
return (a: clsvViewpointEN, b: clsvViewpointEN) => {
if (b.isRecommend == true) return 1;
else return -1
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vViewpoint]中不存在！(in ${ vViewpoint_ConstructorName}.${ strThisFuncName})`;
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
export async function vViewpoint_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsvViewpointEN.con_ViewpointId:
return (obj: clsvViewpointEN) => {
return obj.viewpointId === value;
}
case clsvViewpointEN.con_ViewpointName:
return (obj: clsvViewpointEN) => {
return obj.viewpointName === value;
}
case clsvViewpointEN.con_ViewpointContent:
return (obj: clsvViewpointEN) => {
return obj.viewpointContent === value;
}
case clsvViewpointEN.con_ViewpointTypeId:
return (obj: clsvViewpointEN) => {
return obj.viewpointTypeId === value;
}
case clsvViewpointEN.con_ViewpointTypeName:
return (obj: clsvViewpointEN) => {
return obj.viewpointTypeName === value;
}
case clsvViewpointEN.con_Reason:
return (obj: clsvViewpointEN) => {
return obj.reason === value;
}
case clsvViewpointEN.con_Source:
return (obj: clsvViewpointEN) => {
return obj.source === value;
}
case clsvViewpointEN.con_VPProposePeople:
return (obj: clsvViewpointEN) => {
return obj.vpProposePeople === value;
}
case clsvViewpointEN.con_UpdDate:
return (obj: clsvViewpointEN) => {
return obj.updDate === value;
}
case clsvViewpointEN.con_UpdUser:
return (obj: clsvViewpointEN) => {
return obj.updUser === value;
}
case clsvViewpointEN.con_Memo:
return (obj: clsvViewpointEN) => {
return obj.memo === value;
}
case clsvViewpointEN.con_IsSubmit:
return (obj: clsvViewpointEN) => {
return obj.isSubmit === value;
}
case clsvViewpointEN.con_AppraiseCount:
return (obj: clsvViewpointEN) => {
return obj.appraiseCount === value;
}
case clsvViewpointEN.con_Score:
return (obj: clsvViewpointEN) => {
return obj.score === value;
}
case clsvViewpointEN.con_OkCount:
return (obj: clsvViewpointEN) => {
return obj.okCount === value;
}
case clsvViewpointEN.con_UserTypeId:
return (obj: clsvViewpointEN) => {
return obj.userTypeId === value;
}
case clsvViewpointEN.con_UserTypeName:
return (obj: clsvViewpointEN) => {
return obj.userTypeName === value;
}
case clsvViewpointEN.con_Author:
return (obj: clsvViewpointEN) => {
return obj.author === value;
}
case clsvViewpointEN.con_CitationId:
return (obj: clsvViewpointEN) => {
return obj.citationId === value;
}
case clsvViewpointEN.con_Keyword:
return (obj: clsvViewpointEN) => {
return obj.keyword === value;
}
case clsvViewpointEN.con_PaperTitle:
return (obj: clsvViewpointEN) => {
return obj.paperTitle === value;
}
case clsvViewpointEN.con_Periodical:
return (obj: clsvViewpointEN) => {
return obj.periodical === value;
}
case clsvViewpointEN.con_ResearchQuestion:
return (obj: clsvViewpointEN) => {
return obj.researchQuestion === value;
}
case clsvViewpointEN.con_UploadfileUrl:
return (obj: clsvViewpointEN) => {
return obj.uploadfileUrl === value;
}
case clsvViewpointEN.con_CitationCount:
return (obj: clsvViewpointEN) => {
return obj.citationCount === value;
}
case clsvViewpointEN.con_StuScore:
return (obj: clsvViewpointEN) => {
return obj.stuScore === value;
}
case clsvViewpointEN.con_TeaScore:
return (obj: clsvViewpointEN) => {
return obj.teaScore === value;
}
case clsvViewpointEN.con_id_CurrEduCls:
return (obj: clsvViewpointEN) => {
return obj.id_CurrEduCls === value;
}
case clsvViewpointEN.con_PdfContent:
return (obj: clsvViewpointEN) => {
return obj.pdfContent === value;
}
case clsvViewpointEN.con_PdfPageNum:
return (obj: clsvViewpointEN) => {
return obj.pdfPageNum === value;
}
case clsvViewpointEN.con_VersionCount:
return (obj: clsvViewpointEN) => {
return obj.versionCount === value;
}
case clsvViewpointEN.con_CreateDate:
return (obj: clsvViewpointEN) => {
return obj.createDate === value;
}
case clsvViewpointEN.con_ShareId:
return (obj: clsvViewpointEN) => {
return obj.shareId === value;
}
case clsvViewpointEN.con_IsRecommend:
return (obj: clsvViewpointEN) => {
return obj.isRecommend === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vViewpoint]中不存在！(in ${ vViewpoint_ConstructorName}.${ strThisFuncName})`;
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
export async function vViewpoint_funcKey(strInFldName:string, strInValue: any, strComparisonOp:string, strid_CurrEduCls_C: string): Promise<Array<string>>
{
//const strThisFuncName = "funcKey";

if (IsNullOrEmpty(strid_CurrEduCls_C) == true)
{
  const strMsg = Format("参数:[strid_CurrEduCls_C]不能为空！(In clsvViewpointWApi.funcKey)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_CurrEduCls_C.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsvViewpointWApi.funcKey)", strid_CurrEduCls_C.length);
console.error(strMsg);
throw (strMsg);
}

if (strInFldName == clsvViewpointEN.con_ViewpointId)
{
const strMsg = Format("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (IsNullOrEmpty(strInValue) == true)
{
return [];
}
const arrvViewpoint = await vViewpoint_GetObjLst_Cache(strid_CurrEduCls_C);
if (arrvViewpoint == null) return [];
let arrvViewpoint_Sel = arrvViewpoint;
const strType = typeof(strInValue);
switch (strType)
{
case "string":
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01: // " = "
arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
break;
case enumComparisonOp.Like_03:
arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
break;
case enumComparisonOp.In_04:
const arrValues = strInValue.split(',');
arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
break;
}
break;
case "boolean":
if (strInValue == null) return [];
if (strComparisonOp == enumComparisonOp.Equal_01)
{
arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
}
break;
case "number":
if (Number(strInValue) == 0) return [];
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01:
arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
break;
case enumComparisonOp.NotEqual_02:
arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
break;
case enumComparisonOp.NotLessThan_05://" >= ":
arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
break;
case enumComparisonOp.NotGreaterThan_06://" <= ":
arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
case enumComparisonOp.GreaterThan_07://" > ":
arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
break;
case enumComparisonOp.LessThan_08://" < ":
arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
}
break;
}
if (arrvViewpoint_Sel.length == 0) return [];
return arrvViewpoint_Sel.map(x=>x.viewpointId);
}

 /**
 * 根据条件获取满足条件的第一条记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
 * @param strWhereCond:条件
 * @returns 返回的第一条记录的关键字值
 **/
export async function vViewpoint_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vViewpoint_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vViewpoint_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vViewpoint_ConstructorName, strThisFuncName);
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
export async function vViewpoint_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vViewpoint_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vViewpoint_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vViewpoint_ConstructorName, strThisFuncName);
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
export async function vViewpoint_GetFirstObjAsync(strWhereCond: string): Promise<clsvViewpointEN|null>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(vViewpoint_Controller, strAction);
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
const objvViewpoint = vViewpoint_GetObjFromJsonObj(returnObj);
return objvViewpoint;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vViewpoint_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vViewpoint_ConstructorName, strThisFuncName);
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
export async function vViewpoint_GetObjLst_ClientCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
if (IsNullOrEmpty(clsvViewpointEN.WhereFormat) == false)
{
strWhereCond = Format(clsvViewpointEN.WhereFormat, strid_CurrEduCls);
}
else
{
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
}
const strKey = Format("{0}_{1}", clsvViewpointEN._CurrTabName, strid_CurrEduCls);
if (IsNullOrEmpty(clsvViewpointEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvViewpointEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrvViewpointExObjLst_Cache: Array<clsvViewpointEN> = CacheHelper.Get(strKey);
const arrvViewpointObjLst_T = vViewpoint_GetObjLstByJSONObjLst(arrvViewpointExObjLst_Cache);
return arrvViewpointObjLst_T;
}
try
{
const arrvViewpointExObjLst = await vViewpoint_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrvViewpointExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvViewpointExObjLst.length);
console.log(strInfo);
return arrvViewpointExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vViewpoint_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vViewpoint_GetObjLst_localStorage(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
if (IsNullOrEmpty(clsvViewpointEN.WhereFormat) == false)
{
strWhereCond = Format(clsvViewpointEN.WhereFormat, strid_CurrEduCls);
}
else
{
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
}
const strKey = Format("{0}_{1}", clsvViewpointEN._CurrTabName, strid_CurrEduCls);
if (IsNullOrEmpty(clsvViewpointEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvViewpointEN.CacheAddiCondition);
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
const arrvViewpointExObjLst_Cache: Array<clsvViewpointEN> = JSON.parse(strTempObjLst);
const arrvViewpointObjLst_T = vViewpoint_GetObjLstByJSONObjLst(arrvViewpointExObjLst_Cache);
return arrvViewpointObjLst_T;
}
try
{
const arrvViewpointExObjLst = await vViewpoint_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrvViewpointExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvViewpointExObjLst.length);
console.log(strInfo);
return arrvViewpointExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vViewpoint_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vViewpoint_GetObjLst_localStorage_PureCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsvViewpointEN._CurrTabName, strid_CurrEduCls);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrvViewpointObjLst_Cache: Array<clsvViewpointEN> = JSON.parse(strTempObjLst);
return arrvViewpointObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function vViewpoint_GetObjLstAsync(strWhereCond: string): Promise<Array<clsvViewpointEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(vViewpoint_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vViewpoint_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vViewpoint_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vViewpoint_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vViewpoint_ConstructorName, strThisFuncName);
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
export async function vViewpoint_GetObjLst_sessionStorage(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
if (IsNullOrEmpty(clsvViewpointEN.WhereFormat) == false)
{
strWhereCond = Format(clsvViewpointEN.WhereFormat, strid_CurrEduCls);
}
else
{
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
}
const strKey = Format("{0}_{1}", clsvViewpointEN._CurrTabName, strid_CurrEduCls);
if (IsNullOrEmpty(clsvViewpointEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvViewpointEN.CacheAddiCondition);
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
const arrvViewpointExObjLst_Cache: Array<clsvViewpointEN> = JSON.parse(strTempObjLst);
const arrvViewpointObjLst_T = vViewpoint_GetObjLstByJSONObjLst(arrvViewpointExObjLst_Cache);
return arrvViewpointObjLst_T;
}
try
{
const arrvViewpointExObjLst = await vViewpoint_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrvViewpointExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvViewpointExObjLst.length);
console.log(strInfo);
return arrvViewpointExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vViewpoint_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vViewpoint_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsvViewpointEN._CurrTabName, strid_CurrEduCls);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrvViewpointObjLst_Cache: Array<clsvViewpointEN> = JSON.parse(strTempObjLst);
return arrvViewpointObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vViewpoint_GetObjLst_Cache(strid_CurrEduCls: string): Promise<Array<clsvViewpointEN>>
{
//const strThisFuncName = "GetObjLst_Cache";

if (IsNullOrEmpty(strid_CurrEduCls) == true)
{
const strMsg = Format("缓存分类变量:[id_CurrEduCls]不能为空！(in clsvViewpointWApi.vViewpoint_GetObjLst_Cache() )");
console.error(strMsg);
throw (strMsg);
}
if (strid_CurrEduCls.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(in clsvViewpointWApi.vViewpoint_GetObjLst_Cache() )", strid_CurrEduCls.length);
console.error(strMsg);
throw (strMsg);
}
let arrvViewpointObjLst_Cache;
switch (clsvViewpointEN.CacheModeId)
{
case "04"://sessionStorage
arrvViewpointObjLst_Cache = await vViewpoint_GetObjLst_sessionStorage(strid_CurrEduCls);
break;
case "03"://localStorage
arrvViewpointObjLst_Cache = await vViewpoint_GetObjLst_localStorage(strid_CurrEduCls);
break;
case "02"://ClientCache
arrvViewpointObjLst_Cache = await vViewpoint_GetObjLst_ClientCache(strid_CurrEduCls);
break;
default:
arrvViewpointObjLst_Cache = await vViewpoint_GetObjLst_ClientCache(strid_CurrEduCls);
break;
}
const arrvViewpointObjLst = vViewpoint_GetObjLstByJSONObjLst(arrvViewpointObjLst_Cache);
return arrvViewpointObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vViewpoint_GetObjLst_PureCache(strid_CurrEduCls: string)
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrvViewpointObjLst_Cache;
switch (clsvViewpointEN.CacheModeId)
{
case "04"://sessionStorage
arrvViewpointObjLst_Cache = await vViewpoint_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls);
break;
case "03"://localStorage
arrvViewpointObjLst_Cache = await vViewpoint_GetObjLst_localStorage_PureCache(strid_CurrEduCls);
break;
case "02"://ClientCache
arrvViewpointObjLst_Cache = null;
break;
default:
arrvViewpointObjLst_Cache = null;
break;
}
return arrvViewpointObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrViewpointId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vViewpoint_GetSubObjLst_Cache(objvViewpoint_Cond: clsvViewpointEN,strid_CurrEduCls: string) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrvViewpointObjLst_Cache = await vViewpoint_GetObjLst_Cache(strid_CurrEduCls);
let arrvViewpoint_Sel: Array < clsvViewpointEN > = arrvViewpointObjLst_Cache;
if (objvViewpoint_Cond.sf_FldComparisonOp == null || objvViewpoint_Cond.sf_FldComparisonOp == "") return arrvViewpoint_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvViewpoint_Cond.sf_FldComparisonOp);
//console.log("clsvViewpointWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvViewpoint_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvViewpoint_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvViewpoint_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objvViewpoint_Cond), vViewpoint_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvViewpointEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrViewpointId:关键字列表
 * @returns 对象列表
 **/
export async function vViewpoint_GetObjLstByViewpointIdLstAsync(arrViewpointId: Array<string>): Promise<Array<clsvViewpointEN>>  
{
const strThisFuncName = "GetObjLstByViewpointIdLstAsync";
const strAction = "GetObjLstByViewpointIdLst";
const strUrl = GetWebApiUrl(vViewpoint_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrViewpointId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vViewpoint_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vViewpoint_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vViewpoint_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vViewpoint_ConstructorName, strThisFuncName);
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
 * @param arrstrViewpointIdLst:关键字列表
 * @returns 对象列表
*/
export async function vViewpoint_GetObjLstByViewpointIdLst_Cache(arrViewpointIdLst: Array<string>,strid_CurrEduCls: string) {
const strThisFuncName = "GetObjLstByViewpointIdLst_Cache";
try
{
const arrvViewpointObjLst_Cache = await vViewpoint_GetObjLst_Cache(strid_CurrEduCls);
const arrvViewpoint_Sel: Array <clsvViewpointEN> = arrvViewpointObjLst_Cache.filter(x => arrViewpointIdLst.indexOf(x.viewpointId)>-1);
return arrvViewpoint_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrViewpointIdLst.join(","), vViewpoint_ConstructorName, strThisFuncName);
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
export async function vViewpoint_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsvViewpointEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(vViewpoint_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vViewpoint_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vViewpoint_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vViewpoint_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vViewpoint_ConstructorName, strThisFuncName);
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
export async function vViewpoint_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsvViewpointEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vViewpoint_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vViewpoint_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vViewpoint_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vViewpoint_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vViewpoint_ConstructorName, strThisFuncName);
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
export async function vViewpoint_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vViewpoint_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vViewpoint_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vViewpoint_ConstructorName, strThisFuncName);
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
export async function vViewpoint_GetObjLstByPager_Cache(objPagerPara: stuPagerPara,strid_CurrEduCls: string) {
const strThisFuncName = "GetObjLstByPager_Cache";
if (objPagerPara.pageIndex == 0) return new Array<clsvViewpointEN>();
const arrvViewpointObjLst_Cache = await vViewpoint_GetObjLst_Cache(strid_CurrEduCls);
if (arrvViewpointObjLst_Cache.length == 0) return arrvViewpointObjLst_Cache;
let arrvViewpoint_Sel = arrvViewpointObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objvViewpoint_Cond = new clsvViewpointEN();
ObjectAssign(objvViewpoint_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsvViewpointWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvViewpoint_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvViewpoint_Sel.length == 0) return arrvViewpoint_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrvViewpoint_Sel = arrvViewpoint_Sel.sort(vViewpoint_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrvViewpoint_Sel = arrvViewpoint_Sel.sort(objPagerPara.sortFun);
}
arrvViewpoint_Sel = arrvViewpoint_Sel.slice(intStart, intEnd);     
return arrvViewpoint_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, vViewpoint_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvViewpointEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function vViewpoint_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsvViewpointEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
if (objPagerPara.pageIndex == 0) return new Array<clsvViewpointEN>();
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(vViewpoint_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vViewpoint_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vViewpoint_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vViewpoint_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vViewpoint_ConstructorName, strThisFuncName);
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
 * @param objstrViewpointId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vViewpoint_IsExistRecord_Cache(objvViewpoint_Cond: clsvViewpointEN,strid_CurrEduCls: string) {
const strThisFuncName = "IsExistRecord_Cache";
const arrvViewpointObjLst_Cache = await vViewpoint_GetObjLst_Cache(strid_CurrEduCls);
if (arrvViewpointObjLst_Cache == null) return false;
let arrvViewpoint_Sel: Array < clsvViewpointEN > = arrvViewpointObjLst_Cache;
if (objvViewpoint_Cond.sf_FldComparisonOp == null || objvViewpoint_Cond.sf_FldComparisonOp == "") return arrvViewpoint_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvViewpoint_Cond.sf_FldComparisonOp);
//console.log("clsvViewpointWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvViewpoint_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvViewpoint_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvViewpoint_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objvViewpoint_Cond), vViewpoint_ConstructorName, strThisFuncName);
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
export async function vViewpoint_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(vViewpoint_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vViewpoint_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vViewpoint_ConstructorName, strThisFuncName);
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
 * @param strViewpointId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function vViewpoint_IsExist(strViewpointId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vViewpoint_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"ViewpointId": strViewpointId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vViewpoint_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vViewpoint_ConstructorName, strThisFuncName);
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
 * @param strViewpointId:所给的关键字
 * @returns 对象
*/
export async function vViewpoint_IsExist_Cache(strViewpointId:string,strid_CurrEduCls:string) {
const strThisFuncName = "IsExist_Cache";
const arrvViewpointObjLst_Cache = await vViewpoint_GetObjLst_Cache(strid_CurrEduCls);
if (arrvViewpointObjLst_Cache == null) return false;
try
{
const arrvViewpoint_Sel: Array <clsvViewpointEN> = arrvViewpointObjLst_Cache.filter(x => x.viewpointId == strViewpointId);
if (arrvViewpoint_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strViewpointId, vViewpoint_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param strViewpointId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function vViewpoint_IsExistAsync(strViewpointId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vViewpoint_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strViewpointId": strViewpointId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vViewpoint_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vViewpoint_ConstructorName, strThisFuncName);
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
export async function vViewpoint_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(vViewpoint_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vViewpoint_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vViewpoint_ConstructorName, strThisFuncName);
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
 * @param objvViewpoint_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function vViewpoint_GetRecCountByCond_Cache(objvViewpoint_Cond: clsvViewpointEN,strid_CurrEduCls: string) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrvViewpointObjLst_Cache = await vViewpoint_GetObjLst_Cache(strid_CurrEduCls);
if (arrvViewpointObjLst_Cache == null) return 0;
let arrvViewpoint_Sel: Array < clsvViewpointEN > = arrvViewpointObjLst_Cache;
if (objvViewpoint_Cond.sf_FldComparisonOp == null || objvViewpoint_Cond.sf_FldComparisonOp == "") return arrvViewpoint_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvViewpoint_Cond.sf_FldComparisonOp);
//console.log("clsvViewpointWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvViewpoint_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvViewpoint_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvViewpoint_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objvViewpoint_Cond), vViewpoint_ConstructorName, strThisFuncName);
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
export function vViewpoint_GetWebApiUrl(strController: string, strAction: string): string {
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
export function vViewpoint_ReFreshThisCache(strid_CurrEduCls: string):void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = Format("{0}_{1}", clsvViewpointEN._CurrTabName, strid_CurrEduCls);
switch (clsvViewpointEN.CacheModeId)
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
export function vViewpoint_GetJSONStrByObj (pobjvViewpointEN: clsvViewpointEN): string
{
const strThisFuncName = "GetJSONStrByObj";
let strJson = "";
try
{
strJson = JSON.stringify(pobjvViewpointEN);
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
export function vViewpoint_GetObjLstByJSONStr (strJSON: string): Array<clsvViewpointEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrvViewpointObjLst = new Array<clsvViewpointEN>();
if (strJSON === "")
{
return arrvViewpointObjLst;
}
try
{
arrvViewpointObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvViewpointObjLst;
}
return arrvViewpointObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrvViewpointObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function vViewpoint_GetObjLstByJSONObjLst (arrvViewpointObjLstS: Array<clsvViewpointEN>): Array<clsvViewpointEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrvViewpointObjLst = new Array<clsvViewpointEN>();
for (const objInFor of arrvViewpointObjLstS) {
const obj1 = vViewpoint_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrvViewpointObjLst.push(obj1);
}
return arrvViewpointObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vViewpoint_GetObjByJSONStr (strJSON: string): clsvViewpointEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjvViewpointEN = new clsvViewpointEN();
if (strJSON === "")
{
return pobjvViewpointEN;
}
try
{
pobjvViewpointEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvViewpointEN;
}
return pobjvViewpointEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function vViewpoint_GetCombineCondition(objvViewpoint_Cond: clsvViewpointEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objvViewpoint_Cond.dicFldComparisonOp, clsvViewpointEN.con_ViewpointId) == true)
{
const strComparisonOp_ViewpointId:string = objvViewpoint_Cond.dicFldComparisonOp[clsvViewpointEN.con_ViewpointId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvViewpointEN.con_ViewpointId, objvViewpoint_Cond.viewpointId, strComparisonOp_ViewpointId);
}
if (Object.prototype.hasOwnProperty.call(objvViewpoint_Cond.dicFldComparisonOp, clsvViewpointEN.con_ViewpointName) == true)
{
const strComparisonOp_ViewpointName:string = objvViewpoint_Cond.dicFldComparisonOp[clsvViewpointEN.con_ViewpointName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvViewpointEN.con_ViewpointName, objvViewpoint_Cond.viewpointName, strComparisonOp_ViewpointName);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objvViewpoint_Cond.dicFldComparisonOp, clsvViewpointEN.con_ViewpointTypeId) == true)
{
const strComparisonOp_ViewpointTypeId:string = objvViewpoint_Cond.dicFldComparisonOp[clsvViewpointEN.con_ViewpointTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvViewpointEN.con_ViewpointTypeId, objvViewpoint_Cond.viewpointTypeId, strComparisonOp_ViewpointTypeId);
}
if (Object.prototype.hasOwnProperty.call(objvViewpoint_Cond.dicFldComparisonOp, clsvViewpointEN.con_ViewpointTypeName) == true)
{
const strComparisonOp_ViewpointTypeName:string = objvViewpoint_Cond.dicFldComparisonOp[clsvViewpointEN.con_ViewpointTypeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvViewpointEN.con_ViewpointTypeName, objvViewpoint_Cond.viewpointTypeName, strComparisonOp_ViewpointTypeName);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objvViewpoint_Cond.dicFldComparisonOp, clsvViewpointEN.con_Source) == true)
{
const strComparisonOp_Source:string = objvViewpoint_Cond.dicFldComparisonOp[clsvViewpointEN.con_Source];
strWhereCond += Format(" And {0} {2} '{1}'", clsvViewpointEN.con_Source, objvViewpoint_Cond.source, strComparisonOp_Source);
}
if (Object.prototype.hasOwnProperty.call(objvViewpoint_Cond.dicFldComparisonOp, clsvViewpointEN.con_VPProposePeople) == true)
{
const strComparisonOp_VPProposePeople:string = objvViewpoint_Cond.dicFldComparisonOp[clsvViewpointEN.con_VPProposePeople];
strWhereCond += Format(" And {0} {2} '{1}'", clsvViewpointEN.con_VPProposePeople, objvViewpoint_Cond.vpProposePeople, strComparisonOp_VPProposePeople);
}
if (Object.prototype.hasOwnProperty.call(objvViewpoint_Cond.dicFldComparisonOp, clsvViewpointEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objvViewpoint_Cond.dicFldComparisonOp[clsvViewpointEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvViewpointEN.con_UpdDate, objvViewpoint_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objvViewpoint_Cond.dicFldComparisonOp, clsvViewpointEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objvViewpoint_Cond.dicFldComparisonOp[clsvViewpointEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsvViewpointEN.con_UpdUser, objvViewpoint_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objvViewpoint_Cond.dicFldComparisonOp, clsvViewpointEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objvViewpoint_Cond.dicFldComparisonOp[clsvViewpointEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsvViewpointEN.con_Memo, objvViewpoint_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objvViewpoint_Cond.dicFldComparisonOp, clsvViewpointEN.con_IsSubmit) == true)
{
if (objvViewpoint_Cond.isSubmit == true)
{
strWhereCond += Format(" And {0} = '1'", clsvViewpointEN.con_IsSubmit);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvViewpointEN.con_IsSubmit);
}
}
if (Object.prototype.hasOwnProperty.call(objvViewpoint_Cond.dicFldComparisonOp, clsvViewpointEN.con_AppraiseCount) == true)
{
const strComparisonOp_AppraiseCount:string = objvViewpoint_Cond.dicFldComparisonOp[clsvViewpointEN.con_AppraiseCount];
strWhereCond += Format(" And {0} {2} {1}", clsvViewpointEN.con_AppraiseCount, objvViewpoint_Cond.appraiseCount, strComparisonOp_AppraiseCount);
}
if (Object.prototype.hasOwnProperty.call(objvViewpoint_Cond.dicFldComparisonOp, clsvViewpointEN.con_Score) == true)
{
const strComparisonOp_Score:string = objvViewpoint_Cond.dicFldComparisonOp[clsvViewpointEN.con_Score];
strWhereCond += Format(" And {0} {2} {1}", clsvViewpointEN.con_Score, objvViewpoint_Cond.score, strComparisonOp_Score);
}
if (Object.prototype.hasOwnProperty.call(objvViewpoint_Cond.dicFldComparisonOp, clsvViewpointEN.con_OkCount) == true)
{
const strComparisonOp_OkCount:string = objvViewpoint_Cond.dicFldComparisonOp[clsvViewpointEN.con_OkCount];
strWhereCond += Format(" And {0} {2} {1}", clsvViewpointEN.con_OkCount, objvViewpoint_Cond.okCount, strComparisonOp_OkCount);
}
if (Object.prototype.hasOwnProperty.call(objvViewpoint_Cond.dicFldComparisonOp, clsvViewpointEN.con_UserTypeId) == true)
{
const strComparisonOp_UserTypeId:string = objvViewpoint_Cond.dicFldComparisonOp[clsvViewpointEN.con_UserTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvViewpointEN.con_UserTypeId, objvViewpoint_Cond.userTypeId, strComparisonOp_UserTypeId);
}
if (Object.prototype.hasOwnProperty.call(objvViewpoint_Cond.dicFldComparisonOp, clsvViewpointEN.con_UserTypeName) == true)
{
const strComparisonOp_UserTypeName:string = objvViewpoint_Cond.dicFldComparisonOp[clsvViewpointEN.con_UserTypeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvViewpointEN.con_UserTypeName, objvViewpoint_Cond.userTypeName, strComparisonOp_UserTypeName);
}
if (Object.prototype.hasOwnProperty.call(objvViewpoint_Cond.dicFldComparisonOp, clsvViewpointEN.con_Author) == true)
{
const strComparisonOp_Author:string = objvViewpoint_Cond.dicFldComparisonOp[clsvViewpointEN.con_Author];
strWhereCond += Format(" And {0} {2} '{1}'", clsvViewpointEN.con_Author, objvViewpoint_Cond.author, strComparisonOp_Author);
}
if (Object.prototype.hasOwnProperty.call(objvViewpoint_Cond.dicFldComparisonOp, clsvViewpointEN.con_CitationId) == true)
{
const strComparisonOp_CitationId:string = objvViewpoint_Cond.dicFldComparisonOp[clsvViewpointEN.con_CitationId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvViewpointEN.con_CitationId, objvViewpoint_Cond.citationId, strComparisonOp_CitationId);
}
if (Object.prototype.hasOwnProperty.call(objvViewpoint_Cond.dicFldComparisonOp, clsvViewpointEN.con_Keyword) == true)
{
const strComparisonOp_Keyword:string = objvViewpoint_Cond.dicFldComparisonOp[clsvViewpointEN.con_Keyword];
strWhereCond += Format(" And {0} {2} '{1}'", clsvViewpointEN.con_Keyword, objvViewpoint_Cond.keyword, strComparisonOp_Keyword);
}
if (Object.prototype.hasOwnProperty.call(objvViewpoint_Cond.dicFldComparisonOp, clsvViewpointEN.con_PaperTitle) == true)
{
const strComparisonOp_PaperTitle:string = objvViewpoint_Cond.dicFldComparisonOp[clsvViewpointEN.con_PaperTitle];
strWhereCond += Format(" And {0} {2} '{1}'", clsvViewpointEN.con_PaperTitle, objvViewpoint_Cond.paperTitle, strComparisonOp_PaperTitle);
}
if (Object.prototype.hasOwnProperty.call(objvViewpoint_Cond.dicFldComparisonOp, clsvViewpointEN.con_Periodical) == true)
{
const strComparisonOp_Periodical:string = objvViewpoint_Cond.dicFldComparisonOp[clsvViewpointEN.con_Periodical];
strWhereCond += Format(" And {0} {2} '{1}'", clsvViewpointEN.con_Periodical, objvViewpoint_Cond.periodical, strComparisonOp_Periodical);
}
if (Object.prototype.hasOwnProperty.call(objvViewpoint_Cond.dicFldComparisonOp, clsvViewpointEN.con_ResearchQuestion) == true)
{
const strComparisonOp_ResearchQuestion:string = objvViewpoint_Cond.dicFldComparisonOp[clsvViewpointEN.con_ResearchQuestion];
strWhereCond += Format(" And {0} {2} '{1}'", clsvViewpointEN.con_ResearchQuestion, objvViewpoint_Cond.researchQuestion, strComparisonOp_ResearchQuestion);
}
if (Object.prototype.hasOwnProperty.call(objvViewpoint_Cond.dicFldComparisonOp, clsvViewpointEN.con_UploadfileUrl) == true)
{
const strComparisonOp_UploadfileUrl:string = objvViewpoint_Cond.dicFldComparisonOp[clsvViewpointEN.con_UploadfileUrl];
strWhereCond += Format(" And {0} {2} '{1}'", clsvViewpointEN.con_UploadfileUrl, objvViewpoint_Cond.uploadfileUrl, strComparisonOp_UploadfileUrl);
}
if (Object.prototype.hasOwnProperty.call(objvViewpoint_Cond.dicFldComparisonOp, clsvViewpointEN.con_CitationCount) == true)
{
const strComparisonOp_CitationCount:string = objvViewpoint_Cond.dicFldComparisonOp[clsvViewpointEN.con_CitationCount];
strWhereCond += Format(" And {0} {2} {1}", clsvViewpointEN.con_CitationCount, objvViewpoint_Cond.citationCount, strComparisonOp_CitationCount);
}
if (Object.prototype.hasOwnProperty.call(objvViewpoint_Cond.dicFldComparisonOp, clsvViewpointEN.con_StuScore) == true)
{
const strComparisonOp_StuScore:string = objvViewpoint_Cond.dicFldComparisonOp[clsvViewpointEN.con_StuScore];
strWhereCond += Format(" And {0} {2} {1}", clsvViewpointEN.con_StuScore, objvViewpoint_Cond.stuScore, strComparisonOp_StuScore);
}
if (Object.prototype.hasOwnProperty.call(objvViewpoint_Cond.dicFldComparisonOp, clsvViewpointEN.con_TeaScore) == true)
{
const strComparisonOp_TeaScore:string = objvViewpoint_Cond.dicFldComparisonOp[clsvViewpointEN.con_TeaScore];
strWhereCond += Format(" And {0} {2} {1}", clsvViewpointEN.con_TeaScore, objvViewpoint_Cond.teaScore, strComparisonOp_TeaScore);
}
if (Object.prototype.hasOwnProperty.call(objvViewpoint_Cond.dicFldComparisonOp, clsvViewpointEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objvViewpoint_Cond.dicFldComparisonOp[clsvViewpointEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsvViewpointEN.con_id_CurrEduCls, objvViewpoint_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (Object.prototype.hasOwnProperty.call(objvViewpoint_Cond.dicFldComparisonOp, clsvViewpointEN.con_PdfContent) == true)
{
const strComparisonOp_PdfContent:string = objvViewpoint_Cond.dicFldComparisonOp[clsvViewpointEN.con_PdfContent];
strWhereCond += Format(" And {0} {2} '{1}'", clsvViewpointEN.con_PdfContent, objvViewpoint_Cond.pdfContent, strComparisonOp_PdfContent);
}
if (Object.prototype.hasOwnProperty.call(objvViewpoint_Cond.dicFldComparisonOp, clsvViewpointEN.con_PdfPageNum) == true)
{
const strComparisonOp_PdfPageNum:string = objvViewpoint_Cond.dicFldComparisonOp[clsvViewpointEN.con_PdfPageNum];
strWhereCond += Format(" And {0} {2} {1}", clsvViewpointEN.con_PdfPageNum, objvViewpoint_Cond.pdfPageNum, strComparisonOp_PdfPageNum);
}
if (Object.prototype.hasOwnProperty.call(objvViewpoint_Cond.dicFldComparisonOp, clsvViewpointEN.con_VersionCount) == true)
{
const strComparisonOp_VersionCount:string = objvViewpoint_Cond.dicFldComparisonOp[clsvViewpointEN.con_VersionCount];
strWhereCond += Format(" And {0} {2} {1}", clsvViewpointEN.con_VersionCount, objvViewpoint_Cond.versionCount, strComparisonOp_VersionCount);
}
if (Object.prototype.hasOwnProperty.call(objvViewpoint_Cond.dicFldComparisonOp, clsvViewpointEN.con_CreateDate) == true)
{
const strComparisonOp_CreateDate:string = objvViewpoint_Cond.dicFldComparisonOp[clsvViewpointEN.con_CreateDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvViewpointEN.con_CreateDate, objvViewpoint_Cond.createDate, strComparisonOp_CreateDate);
}
if (Object.prototype.hasOwnProperty.call(objvViewpoint_Cond.dicFldComparisonOp, clsvViewpointEN.con_ShareId) == true)
{
const strComparisonOp_ShareId:string = objvViewpoint_Cond.dicFldComparisonOp[clsvViewpointEN.con_ShareId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvViewpointEN.con_ShareId, objvViewpoint_Cond.shareId, strComparisonOp_ShareId);
}
if (Object.prototype.hasOwnProperty.call(objvViewpoint_Cond.dicFldComparisonOp, clsvViewpointEN.con_IsRecommend) == true)
{
if (objvViewpoint_Cond.isRecommend == true)
{
strWhereCond += Format(" And {0} = '1'", clsvViewpointEN.con_IsRecommend);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvViewpointEN.con_IsRecommend);
}
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objvViewpointENS:源对象
 * @param objvViewpointENT:目标对象
*/
export function vViewpoint_CopyObjTo(objvViewpointENS: clsvViewpointEN , objvViewpointENT: clsvViewpointEN ): void 
{
objvViewpointENT.viewpointId = objvViewpointENS.viewpointId; //观点Id
objvViewpointENT.viewpointName = objvViewpointENS.viewpointName; //观点名称
objvViewpointENT.viewpointContent = objvViewpointENS.viewpointContent; //观点内容
objvViewpointENT.viewpointTypeId = objvViewpointENS.viewpointTypeId; //观点类型Id
objvViewpointENT.viewpointTypeName = objvViewpointENS.viewpointTypeName; //观点类型名
objvViewpointENT.reason = objvViewpointENS.reason; //理由
objvViewpointENT.source = objvViewpointENS.source; //来源
objvViewpointENT.vpProposePeople = objvViewpointENS.vpProposePeople; //观点提出人
objvViewpointENT.updDate = objvViewpointENS.updDate; //修改日期
objvViewpointENT.updUser = objvViewpointENS.updUser; //修改人
objvViewpointENT.memo = objvViewpointENS.memo; //备注
objvViewpointENT.isSubmit = objvViewpointENS.isSubmit; //是否提交
objvViewpointENT.appraiseCount = objvViewpointENS.appraiseCount; //评论数
objvViewpointENT.score = objvViewpointENS.score; //评分
objvViewpointENT.okCount = objvViewpointENS.okCount; //点赞统计
objvViewpointENT.userTypeId = objvViewpointENS.userTypeId; //用户类型Id
objvViewpointENT.userTypeName = objvViewpointENS.userTypeName; //用户类型名称
objvViewpointENT.author = objvViewpointENS.author; //作者
objvViewpointENT.citationId = objvViewpointENS.citationId; //引用Id
objvViewpointENT.keyword = objvViewpointENS.keyword; //关键字
objvViewpointENT.paperTitle = objvViewpointENS.paperTitle; //论文标题
objvViewpointENT.periodical = objvViewpointENS.periodical; //期刊
objvViewpointENT.researchQuestion = objvViewpointENS.researchQuestion; //研究问题
objvViewpointENT.uploadfileUrl = objvViewpointENS.uploadfileUrl; //文件地址
objvViewpointENT.citationCount = objvViewpointENS.citationCount; //引用统计
objvViewpointENT.stuScore = objvViewpointENS.stuScore; //学生平均分
objvViewpointENT.teaScore = objvViewpointENS.teaScore; //教师评分
objvViewpointENT.id_CurrEduCls = objvViewpointENS.id_CurrEduCls; //教学班流水号
objvViewpointENT.pdfContent = objvViewpointENS.pdfContent; //Pdf内容
objvViewpointENT.pdfPageNum = objvViewpointENS.pdfPageNum; //Pdf页码
objvViewpointENT.versionCount = objvViewpointENS.versionCount; //版本统计
objvViewpointENT.createDate = objvViewpointENS.createDate; //建立日期
objvViewpointENT.shareId = objvViewpointENS.shareId; //分享Id
objvViewpointENT.isRecommend = objvViewpointENS.isRecommend; //是否推荐
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objvViewpointENS:源对象
 * @param objvViewpointENT:目标对象
*/
export function vViewpoint_GetObjFromJsonObj(objvViewpointENS: clsvViewpointEN): clsvViewpointEN 
{
 const objvViewpointENT: clsvViewpointEN = new clsvViewpointEN();
ObjectAssign(objvViewpointENT, objvViewpointENS);
 return objvViewpointENT;
}