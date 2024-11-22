
 /**
 * 类名:clsvPaperSubViewpointWApi
 * 表名:vPaperSubViewpoint(01120551)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:54:36
 * 生成者:pyf
 * 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:研培论文(GraduateEduPaper)
 * 框架-层名:WA_访问层(TS)(WA_Access)
 * 编程语言:TypeScript
 * 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
   *      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 **/

/**
 * v子观点表(vPaperSubViewpoint)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2023年03月13日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { enumComparisonOp } from "../../PubFun/enumComparisonOp.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { clsvPaperSubViewpointEN } from "../../L0_Entity/GraduateEduPaper/clsvPaperSubViewpointEN.js";
import { BindDdl_ObjLstInDiv_V, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const vPaperSubViewpoint_Controller = "vPaperSubViewpointApi";
 export const vPaperSubViewpoint_ConstructorName = "vPaperSubViewpoint";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strSubViewpointId:关键字
 * @returns 对象
 **/
export async function vPaperSubViewpoint_GetObjBySubViewpointIdAsync(strSubViewpointId: string): Promise<clsvPaperSubViewpointEN|null>  
{
const strThisFuncName = "GetObjBySubViewpointIdAsync";

if (IsNullOrEmpty(strSubViewpointId) == true)
{
  const strMsg = Format("参数:[strSubViewpointId]不能为空！(In clsvPaperSubViewpointWApi.GetObjBySubViewpointIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strSubViewpointId.length != 8)
{
const strMsg = Format("缓存分类变量:[strSubViewpointId]的长度:[{0}]不正确！(clsvPaperSubViewpointWApi.GetObjBySubViewpointIdAsync)", strSubViewpointId.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjBySubViewpointId";
const strUrl = GetWebApiUrl(vPaperSubViewpoint_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strSubViewpointId": strSubViewpointId,
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
const objvPaperSubViewpoint = vPaperSubViewpoint_GetObjFromJsonObj(returnObj);
return objvPaperSubViewpoint;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSubViewpoint_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSubViewpoint_ConstructorName, strThisFuncName);
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
 * @param strSubViewpointId:所给的关键字
 * @returns 对象
*/
export async function vPaperSubViewpoint_GetObjBySubViewpointId_Cache(strSubViewpointId:string,strid_CurrEduCls:string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjBySubViewpointId_Cache";

if (IsNullOrEmpty(strSubViewpointId) == true)
{
  const strMsg = Format("参数:[strSubViewpointId]不能为空！(In clsvPaperSubViewpointWApi.GetObjBySubViewpointId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strSubViewpointId.length != 8)
{
const strMsg = Format("缓存分类变量:[strSubViewpointId]的长度:[{0}]不正确！(clsvPaperSubViewpointWApi.GetObjBySubViewpointId_Cache)", strSubViewpointId.length);
console.error(strMsg);
throw (strMsg);
}
const arrvPaperSubViewpointObjLst_Cache = await vPaperSubViewpoint_GetObjLst_Cache(strid_CurrEduCls);
try
{
const arrvPaperSubViewpoint_Sel: Array <clsvPaperSubViewpointEN> = arrvPaperSubViewpointObjLst_Cache.filter(x => 
 x.subViewpointId == strSubViewpointId );
let objvPaperSubViewpoint: clsvPaperSubViewpointEN;
if (arrvPaperSubViewpoint_Sel.length > 0)
{
objvPaperSubViewpoint = arrvPaperSubViewpoint_Sel[0];
return objvPaperSubViewpoint;
}
else
{
if (bolTryAsyncOnce == true)
{
const objvPaperSubViewpoint_Const = await vPaperSubViewpoint_GetObjBySubViewpointIdAsync(strSubViewpointId);
if (objvPaperSubViewpoint_Const != null)
{
vPaperSubViewpoint_ReFreshThisCache(strid_CurrEduCls);
return objvPaperSubViewpoint_Const;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strSubViewpointId, vPaperSubViewpoint_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param strSubViewpointId:所给的关键字
 * @returns 对象
*/
export async function vPaperSubViewpoint_GetObjBySubViewpointId_localStorage(strSubViewpointId: string) {
const strThisFuncName = "GetObjBySubViewpointId_localStorage";

if (IsNullOrEmpty(strSubViewpointId) == true)
{
  const strMsg = Format("参数:[strSubViewpointId]不能为空！(In clsvPaperSubViewpointWApi.GetObjBySubViewpointId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
if (strSubViewpointId.length != 8)
{
const strMsg = Format("缓存分类变量:[strSubViewpointId]的长度:[{0}]不正确！(clsvPaperSubViewpointWApi.GetObjBySubViewpointId_localStorage)", strSubViewpointId.length);
console.error(strMsg);
throw (strMsg);
}
const strKey = Format("{0}_{1}", clsvPaperSubViewpointEN._CurrTabName, strSubViewpointId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objvPaperSubViewpoint_Cache: clsvPaperSubViewpointEN = JSON.parse(strTempObj);
return objvPaperSubViewpoint_Cache;
}
try
{
const objvPaperSubViewpoint = await vPaperSubViewpoint_GetObjBySubViewpointIdAsync(strSubViewpointId);
if (objvPaperSubViewpoint != null)
{
localStorage.setItem(strKey, JSON.stringify(objvPaperSubViewpoint));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objvPaperSubViewpoint;
}
return objvPaperSubViewpoint;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strSubViewpointId, vPaperSubViewpoint_ConstructorName, strThisFuncName);
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
export async function vPaperSubViewpoint_func(strInFldName:string , strOutFldName:string , strInValue:string 
, strid_CurrEduCls_C: string)
{
//const strThisFuncName = "func";

if (IsNullOrEmpty(strid_CurrEduCls_C) == true)
{
  const strMsg = Format("参数:[strid_CurrEduCls_C]不能为空！(In clsvPaperSubViewpointWApi.func)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_CurrEduCls_C.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsvPaperSubViewpointWApi.func)", strid_CurrEduCls_C.length);
console.error(strMsg);
throw (strMsg);
}

if (strInFldName != clsvPaperSubViewpointEN.con_SubViewpointId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsvPaperSubViewpointEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strOutFldName, clsvPaperSubViewpointEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strSubViewpointId = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objvPaperSubViewpoint = await vPaperSubViewpoint_GetObjBySubViewpointId_Cache(strSubViewpointId , strid_CurrEduCls_C);
if (objvPaperSubViewpoint == null) return "";
if (objvPaperSubViewpoint.GetFldValue(strOutFldName) == null) return "";
return objvPaperSubViewpoint.GetFldValue(strOutFldName).toString();
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
export function vPaperSubViewpoint_SortFun_Defa(a:clsvPaperSubViewpointEN , b:clsvPaperSubViewpointEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.subViewpointId.localeCompare(b.subViewpointId);
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
export function vPaperSubViewpoint_SortFun_Defa_2Fld(a:clsvPaperSubViewpointEN , b:clsvPaperSubViewpointEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.paperRWId == b.paperRWId) return a.paperId.localeCompare(b.paperId);
else return a.paperRWId.localeCompare(b.paperRWId);
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
export function vPaperSubViewpoint_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsvPaperSubViewpointEN.con_SubViewpointId:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
return a.subViewpointId.localeCompare(b.subViewpointId);
}
case clsvPaperSubViewpointEN.con_PaperRWId:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
if (a.paperRWId == null) return -1;
if (b.paperRWId == null) return 1;
return a.paperRWId.localeCompare(b.paperRWId);
}
case clsvPaperSubViewpointEN.con_PaperId:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
if (a.paperId == null) return -1;
if (b.paperId == null) return 1;
return a.paperId.localeCompare(b.paperId);
}
case clsvPaperSubViewpointEN.con_PaperTitle:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
if (a.paperTitle == null) return -1;
if (b.paperTitle == null) return 1;
return a.paperTitle.localeCompare(b.paperTitle);
}
case clsvPaperSubViewpointEN.con_IsSubmit:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
if (a.isSubmit == true) return 1;
else return -1
}
case clsvPaperSubViewpointEN.con_id_CurrEduCls:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
case clsvPaperSubViewpointEN.con_UserId:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
return a.userId.localeCompare(b.userId);
}
case clsvPaperSubViewpointEN.con_SectionId:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
if (a.sectionId == null) return -1;
if (b.sectionId == null) return 1;
return a.sectionId.localeCompare(b.sectionId);
}
case clsvPaperSubViewpointEN.con_SectionName:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
if (a.sectionName == null) return -1;
if (b.sectionName == null) return 1;
return a.sectionName.localeCompare(b.sectionName);
}
case clsvPaperSubViewpointEN.con_SubViewpointTypeId:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
return a.subViewpointTypeId.localeCompare(b.subViewpointTypeId);
}
case clsvPaperSubViewpointEN.con_SubViewpointTypeName:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
if (a.subViewpointTypeName == null) return -1;
if (b.subViewpointTypeName == null) return 1;
return a.subViewpointTypeName.localeCompare(b.subViewpointTypeName);
}
case clsvPaperSubViewpointEN.con_DefaTitle:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
if (a.defaTitle == null) return -1;
if (b.defaTitle == null) return 1;
return a.defaTitle.localeCompare(b.defaTitle);
}
case clsvPaperSubViewpointEN.con_RWTitle:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
if (a.rwTitle == null) return -1;
if (b.rwTitle == null) return 1;
return a.rwTitle.localeCompare(b.rwTitle);
}
case clsvPaperSubViewpointEN.con_SubViewpointContent:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
if (a.subViewpointContent == null) return -1;
if (b.subViewpointContent == null) return 1;
return a.subViewpointContent.localeCompare(b.subViewpointContent);
}
case clsvPaperSubViewpointEN.con_ExplainTypeId:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
if (a.explainTypeId == null) return -1;
if (b.explainTypeId == null) return 1;
return a.explainTypeId.localeCompare(b.explainTypeId);
}
case clsvPaperSubViewpointEN.con_ExplainTypeName:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
if (a.explainTypeName == null) return -1;
if (b.explainTypeName == null) return 1;
return a.explainTypeName.localeCompare(b.explainTypeName);
}
case clsvPaperSubViewpointEN.con_ExplainContent:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
if (a.explainContent == null) return -1;
if (b.explainContent == null) return 1;
return a.explainContent.localeCompare(b.explainContent);
}
case clsvPaperSubViewpointEN.con_IsPublic:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
if (a.isPublic == true) return 1;
else return -1
}
case clsvPaperSubViewpointEN.con_LiteratureSourcesId:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
if (a.literatureSourcesId == null) return -1;
if (b.literatureSourcesId == null) return 1;
return a.literatureSourcesId.localeCompare(b.literatureSourcesId);
}
case clsvPaperSubViewpointEN.con_PageNumber:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
return a.pageNumber-b.pageNumber;
}
case clsvPaperSubViewpointEN.con_OrderNum:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
return a.orderNum-b.orderNum;
}
case clsvPaperSubViewpointEN.con_PaperLineNum:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
return a.paperLineNum-b.paperLineNum;
}
case clsvPaperSubViewpointEN.con_PaperPageNum:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
return a.paperPageNum-b.paperPageNum;
}
case clsvPaperSubViewpointEN.con_AppraiseCount:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
return a.appraiseCount-b.appraiseCount;
}
case clsvPaperSubViewpointEN.con_OkCount:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
return a.okCount-b.okCount;
}
case clsvPaperSubViewpointEN.con_Score:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
return a.score-b.score;
}
case clsvPaperSubViewpointEN.con_StuScore:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
return a.stuScore-b.stuScore;
}
case clsvPaperSubViewpointEN.con_TeaScore:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
return a.teaScore-b.teaScore;
}
case clsvPaperSubViewpointEN.con_CreateDate:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
if (a.createDate == null) return -1;
if (b.createDate == null) return 1;
return a.createDate.localeCompare(b.createDate);
}
case clsvPaperSubViewpointEN.con_ShareId:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
return a.shareId.localeCompare(b.shareId);
}
case clsvPaperSubViewpointEN.con_TopicId:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
if (a.topicId == null) return -1;
if (b.topicId == null) return 1;
return a.topicId.localeCompare(b.topicId);
}
case clsvPaperSubViewpointEN.con_AttitudesId:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
return a.attitudesId.localeCompare(b.attitudesId);
}
case clsvPaperSubViewpointEN.con_AttitudesName:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
if (a.attitudesName == null) return -1;
if (b.attitudesName == null) return 1;
return a.attitudesName.localeCompare(b.attitudesName);
}
case clsvPaperSubViewpointEN.con_UpdDate:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
if (a.updDate == null) return -1;
if (b.updDate == null) return 1;
return a.updDate.localeCompare(b.updDate);
}
case clsvPaperSubViewpointEN.con_UpdUser:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
if (a.updUser == null) return -1;
if (b.updUser == null) return 1;
return a.updUser.localeCompare(b.updUser);
}
case clsvPaperSubViewpointEN.con_Memo:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
if (a.memo == null) return -1;
if (b.memo == null) return 1;
return a.memo.localeCompare(b.memo);
}
case clsvPaperSubViewpointEN.con_SectionOrderNum:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
return a.sectionOrderNum-b.sectionOrderNum;
}
case clsvPaperSubViewpointEN.con_SubViewpointTypeOrderNum:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
return a.subViewpointTypeOrderNum-b.subViewpointTypeOrderNum;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vPaperSubViewpoint]中不存在！(in ${ vPaperSubViewpoint_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsvPaperSubViewpointEN.con_SubViewpointId:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
return b.subViewpointId.localeCompare(a.subViewpointId);
}
case clsvPaperSubViewpointEN.con_PaperRWId:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
if (b.paperRWId == null) return -1;
if (a.paperRWId == null) return 1;
return b.paperRWId.localeCompare(a.paperRWId);
}
case clsvPaperSubViewpointEN.con_PaperId:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
if (b.paperId == null) return -1;
if (a.paperId == null) return 1;
return b.paperId.localeCompare(a.paperId);
}
case clsvPaperSubViewpointEN.con_PaperTitle:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
if (b.paperTitle == null) return -1;
if (a.paperTitle == null) return 1;
return b.paperTitle.localeCompare(a.paperTitle);
}
case clsvPaperSubViewpointEN.con_IsSubmit:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
if (b.isSubmit == true) return 1;
else return -1
}
case clsvPaperSubViewpointEN.con_id_CurrEduCls:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
case clsvPaperSubViewpointEN.con_UserId:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
return b.userId.localeCompare(a.userId);
}
case clsvPaperSubViewpointEN.con_SectionId:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
if (b.sectionId == null) return -1;
if (a.sectionId == null) return 1;
return b.sectionId.localeCompare(a.sectionId);
}
case clsvPaperSubViewpointEN.con_SectionName:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
if (b.sectionName == null) return -1;
if (a.sectionName == null) return 1;
return b.sectionName.localeCompare(a.sectionName);
}
case clsvPaperSubViewpointEN.con_SubViewpointTypeId:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
return b.subViewpointTypeId.localeCompare(a.subViewpointTypeId);
}
case clsvPaperSubViewpointEN.con_SubViewpointTypeName:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
if (b.subViewpointTypeName == null) return -1;
if (a.subViewpointTypeName == null) return 1;
return b.subViewpointTypeName.localeCompare(a.subViewpointTypeName);
}
case clsvPaperSubViewpointEN.con_DefaTitle:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
if (b.defaTitle == null) return -1;
if (a.defaTitle == null) return 1;
return b.defaTitle.localeCompare(a.defaTitle);
}
case clsvPaperSubViewpointEN.con_RWTitle:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
if (b.rwTitle == null) return -1;
if (a.rwTitle == null) return 1;
return b.rwTitle.localeCompare(a.rwTitle);
}
case clsvPaperSubViewpointEN.con_SubViewpointContent:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
if (b.subViewpointContent == null) return -1;
if (a.subViewpointContent == null) return 1;
return b.subViewpointContent.localeCompare(a.subViewpointContent);
}
case clsvPaperSubViewpointEN.con_ExplainTypeId:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
if (b.explainTypeId == null) return -1;
if (a.explainTypeId == null) return 1;
return b.explainTypeId.localeCompare(a.explainTypeId);
}
case clsvPaperSubViewpointEN.con_ExplainTypeName:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
if (b.explainTypeName == null) return -1;
if (a.explainTypeName == null) return 1;
return b.explainTypeName.localeCompare(a.explainTypeName);
}
case clsvPaperSubViewpointEN.con_ExplainContent:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
if (b.explainContent == null) return -1;
if (a.explainContent == null) return 1;
return b.explainContent.localeCompare(a.explainContent);
}
case clsvPaperSubViewpointEN.con_IsPublic:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
if (b.isPublic == true) return 1;
else return -1
}
case clsvPaperSubViewpointEN.con_LiteratureSourcesId:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
if (b.literatureSourcesId == null) return -1;
if (a.literatureSourcesId == null) return 1;
return b.literatureSourcesId.localeCompare(a.literatureSourcesId);
}
case clsvPaperSubViewpointEN.con_PageNumber:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
return b.pageNumber-a.pageNumber;
}
case clsvPaperSubViewpointEN.con_OrderNum:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
return b.orderNum-a.orderNum;
}
case clsvPaperSubViewpointEN.con_PaperLineNum:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
return b.paperLineNum-a.paperLineNum;
}
case clsvPaperSubViewpointEN.con_PaperPageNum:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
return b.paperPageNum-a.paperPageNum;
}
case clsvPaperSubViewpointEN.con_AppraiseCount:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
return b.appraiseCount-a.appraiseCount;
}
case clsvPaperSubViewpointEN.con_OkCount:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
return b.okCount-a.okCount;
}
case clsvPaperSubViewpointEN.con_Score:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
return b.score-a.score;
}
case clsvPaperSubViewpointEN.con_StuScore:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
return b.stuScore-a.stuScore;
}
case clsvPaperSubViewpointEN.con_TeaScore:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
return b.teaScore-a.teaScore;
}
case clsvPaperSubViewpointEN.con_CreateDate:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
if (b.createDate == null) return -1;
if (a.createDate == null) return 1;
return b.createDate.localeCompare(a.createDate);
}
case clsvPaperSubViewpointEN.con_ShareId:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
return b.shareId.localeCompare(a.shareId);
}
case clsvPaperSubViewpointEN.con_TopicId:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
if (b.topicId == null) return -1;
if (a.topicId == null) return 1;
return b.topicId.localeCompare(a.topicId);
}
case clsvPaperSubViewpointEN.con_AttitudesId:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
return b.attitudesId.localeCompare(a.attitudesId);
}
case clsvPaperSubViewpointEN.con_AttitudesName:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
if (b.attitudesName == null) return -1;
if (a.attitudesName == null) return 1;
return b.attitudesName.localeCompare(a.attitudesName);
}
case clsvPaperSubViewpointEN.con_UpdDate:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
if (b.updDate == null) return -1;
if (a.updDate == null) return 1;
return b.updDate.localeCompare(a.updDate);
}
case clsvPaperSubViewpointEN.con_UpdUser:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
if (b.updUser == null) return -1;
if (a.updUser == null) return 1;
return b.updUser.localeCompare(a.updUser);
}
case clsvPaperSubViewpointEN.con_Memo:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
if (b.memo == null) return -1;
if (a.memo == null) return 1;
return b.memo.localeCompare(a.memo);
}
case clsvPaperSubViewpointEN.con_SectionOrderNum:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
return b.sectionOrderNum-a.sectionOrderNum;
}
case clsvPaperSubViewpointEN.con_SubViewpointTypeOrderNum:
return (a: clsvPaperSubViewpointEN, b: clsvPaperSubViewpointEN) => {
return b.subViewpointTypeOrderNum-a.subViewpointTypeOrderNum;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vPaperSubViewpoint]中不存在！(in ${ vPaperSubViewpoint_ConstructorName}.${ strThisFuncName})`;
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
export async function vPaperSubViewpoint_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsvPaperSubViewpointEN.con_SubViewpointId:
return (obj: clsvPaperSubViewpointEN) => {
return obj.subViewpointId === value;
}
case clsvPaperSubViewpointEN.con_PaperRWId:
return (obj: clsvPaperSubViewpointEN) => {
return obj.paperRWId === value;
}
case clsvPaperSubViewpointEN.con_PaperId:
return (obj: clsvPaperSubViewpointEN) => {
return obj.paperId === value;
}
case clsvPaperSubViewpointEN.con_PaperTitle:
return (obj: clsvPaperSubViewpointEN) => {
return obj.paperTitle === value;
}
case clsvPaperSubViewpointEN.con_IsSubmit:
return (obj: clsvPaperSubViewpointEN) => {
return obj.isSubmit === value;
}
case clsvPaperSubViewpointEN.con_id_CurrEduCls:
return (obj: clsvPaperSubViewpointEN) => {
return obj.id_CurrEduCls === value;
}
case clsvPaperSubViewpointEN.con_UserId:
return (obj: clsvPaperSubViewpointEN) => {
return obj.userId === value;
}
case clsvPaperSubViewpointEN.con_SectionId:
return (obj: clsvPaperSubViewpointEN) => {
return obj.sectionId === value;
}
case clsvPaperSubViewpointEN.con_SectionName:
return (obj: clsvPaperSubViewpointEN) => {
return obj.sectionName === value;
}
case clsvPaperSubViewpointEN.con_SubViewpointTypeId:
return (obj: clsvPaperSubViewpointEN) => {
return obj.subViewpointTypeId === value;
}
case clsvPaperSubViewpointEN.con_SubViewpointTypeName:
return (obj: clsvPaperSubViewpointEN) => {
return obj.subViewpointTypeName === value;
}
case clsvPaperSubViewpointEN.con_DefaTitle:
return (obj: clsvPaperSubViewpointEN) => {
return obj.defaTitle === value;
}
case clsvPaperSubViewpointEN.con_RWTitle:
return (obj: clsvPaperSubViewpointEN) => {
return obj.rwTitle === value;
}
case clsvPaperSubViewpointEN.con_SubViewpointContent:
return (obj: clsvPaperSubViewpointEN) => {
return obj.subViewpointContent === value;
}
case clsvPaperSubViewpointEN.con_ExplainTypeId:
return (obj: clsvPaperSubViewpointEN) => {
return obj.explainTypeId === value;
}
case clsvPaperSubViewpointEN.con_ExplainTypeName:
return (obj: clsvPaperSubViewpointEN) => {
return obj.explainTypeName === value;
}
case clsvPaperSubViewpointEN.con_ExplainContent:
return (obj: clsvPaperSubViewpointEN) => {
return obj.explainContent === value;
}
case clsvPaperSubViewpointEN.con_IsPublic:
return (obj: clsvPaperSubViewpointEN) => {
return obj.isPublic === value;
}
case clsvPaperSubViewpointEN.con_LiteratureSourcesId:
return (obj: clsvPaperSubViewpointEN) => {
return obj.literatureSourcesId === value;
}
case clsvPaperSubViewpointEN.con_PageNumber:
return (obj: clsvPaperSubViewpointEN) => {
return obj.pageNumber === value;
}
case clsvPaperSubViewpointEN.con_OrderNum:
return (obj: clsvPaperSubViewpointEN) => {
return obj.orderNum === value;
}
case clsvPaperSubViewpointEN.con_PaperLineNum:
return (obj: clsvPaperSubViewpointEN) => {
return obj.paperLineNum === value;
}
case clsvPaperSubViewpointEN.con_PaperPageNum:
return (obj: clsvPaperSubViewpointEN) => {
return obj.paperPageNum === value;
}
case clsvPaperSubViewpointEN.con_AppraiseCount:
return (obj: clsvPaperSubViewpointEN) => {
return obj.appraiseCount === value;
}
case clsvPaperSubViewpointEN.con_OkCount:
return (obj: clsvPaperSubViewpointEN) => {
return obj.okCount === value;
}
case clsvPaperSubViewpointEN.con_Score:
return (obj: clsvPaperSubViewpointEN) => {
return obj.score === value;
}
case clsvPaperSubViewpointEN.con_StuScore:
return (obj: clsvPaperSubViewpointEN) => {
return obj.stuScore === value;
}
case clsvPaperSubViewpointEN.con_TeaScore:
return (obj: clsvPaperSubViewpointEN) => {
return obj.teaScore === value;
}
case clsvPaperSubViewpointEN.con_CreateDate:
return (obj: clsvPaperSubViewpointEN) => {
return obj.createDate === value;
}
case clsvPaperSubViewpointEN.con_ShareId:
return (obj: clsvPaperSubViewpointEN) => {
return obj.shareId === value;
}
case clsvPaperSubViewpointEN.con_TopicId:
return (obj: clsvPaperSubViewpointEN) => {
return obj.topicId === value;
}
case clsvPaperSubViewpointEN.con_AttitudesId:
return (obj: clsvPaperSubViewpointEN) => {
return obj.attitudesId === value;
}
case clsvPaperSubViewpointEN.con_AttitudesName:
return (obj: clsvPaperSubViewpointEN) => {
return obj.attitudesName === value;
}
case clsvPaperSubViewpointEN.con_UpdDate:
return (obj: clsvPaperSubViewpointEN) => {
return obj.updDate === value;
}
case clsvPaperSubViewpointEN.con_UpdUser:
return (obj: clsvPaperSubViewpointEN) => {
return obj.updUser === value;
}
case clsvPaperSubViewpointEN.con_Memo:
return (obj: clsvPaperSubViewpointEN) => {
return obj.memo === value;
}
case clsvPaperSubViewpointEN.con_SectionOrderNum:
return (obj: clsvPaperSubViewpointEN) => {
return obj.sectionOrderNum === value;
}
case clsvPaperSubViewpointEN.con_SubViewpointTypeOrderNum:
return (obj: clsvPaperSubViewpointEN) => {
return obj.subViewpointTypeOrderNum === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vPaperSubViewpoint]中不存在！(in ${ vPaperSubViewpoint_ConstructorName}.${ strThisFuncName})`;
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
export async function vPaperSubViewpoint_funcKey(strInFldName:string, strInValue: any, strComparisonOp:string, strid_CurrEduCls_C: string): Promise<Array<string>>
{
//const strThisFuncName = "funcKey";

if (IsNullOrEmpty(strid_CurrEduCls_C) == true)
{
  const strMsg = Format("参数:[strid_CurrEduCls_C]不能为空！(In clsvPaperSubViewpointWApi.funcKey)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_CurrEduCls_C.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsvPaperSubViewpointWApi.funcKey)", strid_CurrEduCls_C.length);
console.error(strMsg);
throw (strMsg);
}

if (strInFldName == clsvPaperSubViewpointEN.con_SubViewpointId)
{
const strMsg = Format("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (IsNullOrEmpty(strInValue) == true)
{
return [];
}
const arrvPaperSubViewpoint = await vPaperSubViewpoint_GetObjLst_Cache(strid_CurrEduCls_C);
if (arrvPaperSubViewpoint == null) return [];
let arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint;
const strType = typeof(strInValue);
switch (strType)
{
case "string":
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01: // " = "
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
break;
case enumComparisonOp.Like_03:
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
break;
case enumComparisonOp.In_04:
const arrValues = strInValue.split(',');
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
break;
}
break;
case "boolean":
if (strInValue == null) return [];
if (strComparisonOp == enumComparisonOp.Equal_01)
{
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
}
break;
case "number":
if (Number(strInValue) == 0) return [];
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01:
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
break;
case enumComparisonOp.NotEqual_02:
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
break;
case enumComparisonOp.NotLessThan_05://" >= ":
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
break;
case enumComparisonOp.NotGreaterThan_06://" <= ":
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
case enumComparisonOp.GreaterThan_07://" > ":
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
break;
case enumComparisonOp.LessThan_08://" < ":
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
}
break;
}
if (arrvPaperSubViewpoint_Sel.length == 0) return [];
return arrvPaperSubViewpoint_Sel.map(x=>x.subViewpointId);
}

 /**
 * 根据条件获取满足条件的第一条记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
 * @param strWhereCond:条件
 * @returns 返回的第一条记录的关键字值
 **/
export async function vPaperSubViewpoint_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vPaperSubViewpoint_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSubViewpoint_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSubViewpoint_ConstructorName, strThisFuncName);
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
export async function vPaperSubViewpoint_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vPaperSubViewpoint_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSubViewpoint_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSubViewpoint_ConstructorName, strThisFuncName);
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
export async function vPaperSubViewpoint_GetFirstObjAsync(strWhereCond: string): Promise<clsvPaperSubViewpointEN|null>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(vPaperSubViewpoint_Controller, strAction);
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
const objvPaperSubViewpoint = vPaperSubViewpoint_GetObjFromJsonObj(returnObj);
return objvPaperSubViewpoint;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSubViewpoint_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSubViewpoint_ConstructorName, strThisFuncName);
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
export async function vPaperSubViewpoint_GetObjLst_ClientCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
if (IsNullOrEmpty(clsvPaperSubViewpointEN.WhereFormat) == false)
{
strWhereCond = Format(clsvPaperSubViewpointEN.WhereFormat, strid_CurrEduCls);
}
else
{
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
}
const strKey = Format("{0}_{1}", clsvPaperSubViewpointEN._CurrTabName, strid_CurrEduCls);
if (IsNullOrEmpty(clsvPaperSubViewpointEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvPaperSubViewpointEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrvPaperSubViewpointExObjLst_Cache: Array<clsvPaperSubViewpointEN> = CacheHelper.Get(strKey);
const arrvPaperSubViewpointObjLst_T = vPaperSubViewpoint_GetObjLstByJSONObjLst(arrvPaperSubViewpointExObjLst_Cache);
return arrvPaperSubViewpointObjLst_T;
}
try
{
const arrvPaperSubViewpointExObjLst = await vPaperSubViewpoint_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrvPaperSubViewpointExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvPaperSubViewpointExObjLst.length);
console.log(strInfo);
return arrvPaperSubViewpointExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vPaperSubViewpoint_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vPaperSubViewpoint_GetObjLst_localStorage(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
if (IsNullOrEmpty(clsvPaperSubViewpointEN.WhereFormat) == false)
{
strWhereCond = Format(clsvPaperSubViewpointEN.WhereFormat, strid_CurrEduCls);
}
else
{
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
}
const strKey = Format("{0}_{1}", clsvPaperSubViewpointEN._CurrTabName, strid_CurrEduCls);
if (IsNullOrEmpty(clsvPaperSubViewpointEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvPaperSubViewpointEN.CacheAddiCondition);
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
const arrvPaperSubViewpointExObjLst_Cache: Array<clsvPaperSubViewpointEN> = JSON.parse(strTempObjLst);
const arrvPaperSubViewpointObjLst_T = vPaperSubViewpoint_GetObjLstByJSONObjLst(arrvPaperSubViewpointExObjLst_Cache);
return arrvPaperSubViewpointObjLst_T;
}
try
{
const arrvPaperSubViewpointExObjLst = await vPaperSubViewpoint_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrvPaperSubViewpointExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvPaperSubViewpointExObjLst.length);
console.log(strInfo);
return arrvPaperSubViewpointExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vPaperSubViewpoint_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vPaperSubViewpoint_GetObjLst_localStorage_PureCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsvPaperSubViewpointEN._CurrTabName, strid_CurrEduCls);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrvPaperSubViewpointObjLst_Cache: Array<clsvPaperSubViewpointEN> = JSON.parse(strTempObjLst);
return arrvPaperSubViewpointObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function vPaperSubViewpoint_GetObjLstAsync(strWhereCond: string): Promise<Array<clsvPaperSubViewpointEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(vPaperSubViewpoint_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vPaperSubViewpoint_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vPaperSubViewpoint_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSubViewpoint_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSubViewpoint_ConstructorName, strThisFuncName);
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
export async function vPaperSubViewpoint_GetObjLst_sessionStorage(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
if (IsNullOrEmpty(clsvPaperSubViewpointEN.WhereFormat) == false)
{
strWhereCond = Format(clsvPaperSubViewpointEN.WhereFormat, strid_CurrEduCls);
}
else
{
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
}
const strKey = Format("{0}_{1}", clsvPaperSubViewpointEN._CurrTabName, strid_CurrEduCls);
if (IsNullOrEmpty(clsvPaperSubViewpointEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvPaperSubViewpointEN.CacheAddiCondition);
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
const arrvPaperSubViewpointExObjLst_Cache: Array<clsvPaperSubViewpointEN> = JSON.parse(strTempObjLst);
const arrvPaperSubViewpointObjLst_T = vPaperSubViewpoint_GetObjLstByJSONObjLst(arrvPaperSubViewpointExObjLst_Cache);
return arrvPaperSubViewpointObjLst_T;
}
try
{
const arrvPaperSubViewpointExObjLst = await vPaperSubViewpoint_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrvPaperSubViewpointExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvPaperSubViewpointExObjLst.length);
console.log(strInfo);
return arrvPaperSubViewpointExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vPaperSubViewpoint_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vPaperSubViewpoint_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsvPaperSubViewpointEN._CurrTabName, strid_CurrEduCls);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrvPaperSubViewpointObjLst_Cache: Array<clsvPaperSubViewpointEN> = JSON.parse(strTempObjLst);
return arrvPaperSubViewpointObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vPaperSubViewpoint_GetObjLst_Cache(strid_CurrEduCls: string): Promise<Array<clsvPaperSubViewpointEN>>
{
//const strThisFuncName = "GetObjLst_Cache";

if (IsNullOrEmpty(strid_CurrEduCls) == true)
{
const strMsg = Format("缓存分类变量:[id_CurrEduCls]不能为空！(in clsvPaperSubViewpointWApi.vPaperSubViewpoint_GetObjLst_Cache() )");
console.error(strMsg);
throw (strMsg);
}
if (strid_CurrEduCls.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(in clsvPaperSubViewpointWApi.vPaperSubViewpoint_GetObjLst_Cache() )", strid_CurrEduCls.length);
console.error(strMsg);
throw (strMsg);
}
let arrvPaperSubViewpointObjLst_Cache;
switch (clsvPaperSubViewpointEN.CacheModeId)
{
case "04"://sessionStorage
arrvPaperSubViewpointObjLst_Cache = await vPaperSubViewpoint_GetObjLst_sessionStorage(strid_CurrEduCls);
break;
case "03"://localStorage
arrvPaperSubViewpointObjLst_Cache = await vPaperSubViewpoint_GetObjLst_localStorage(strid_CurrEduCls);
break;
case "02"://ClientCache
arrvPaperSubViewpointObjLst_Cache = await vPaperSubViewpoint_GetObjLst_ClientCache(strid_CurrEduCls);
break;
default:
arrvPaperSubViewpointObjLst_Cache = await vPaperSubViewpoint_GetObjLst_ClientCache(strid_CurrEduCls);
break;
}
const arrvPaperSubViewpointObjLst = vPaperSubViewpoint_GetObjLstByJSONObjLst(arrvPaperSubViewpointObjLst_Cache);
return arrvPaperSubViewpointObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vPaperSubViewpoint_GetObjLst_PureCache(strid_CurrEduCls: string)
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrvPaperSubViewpointObjLst_Cache;
switch (clsvPaperSubViewpointEN.CacheModeId)
{
case "04"://sessionStorage
arrvPaperSubViewpointObjLst_Cache = await vPaperSubViewpoint_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls);
break;
case "03"://localStorage
arrvPaperSubViewpointObjLst_Cache = await vPaperSubViewpoint_GetObjLst_localStorage_PureCache(strid_CurrEduCls);
break;
case "02"://ClientCache
arrvPaperSubViewpointObjLst_Cache = null;
break;
default:
arrvPaperSubViewpointObjLst_Cache = null;
break;
}
return arrvPaperSubViewpointObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrSubViewpointId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vPaperSubViewpoint_GetSubObjLst_Cache(objvPaperSubViewpoint_Cond: clsvPaperSubViewpointEN,strid_CurrEduCls: string) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrvPaperSubViewpointObjLst_Cache = await vPaperSubViewpoint_GetObjLst_Cache(strid_CurrEduCls);
let arrvPaperSubViewpoint_Sel: Array < clsvPaperSubViewpointEN > = arrvPaperSubViewpointObjLst_Cache;
if (objvPaperSubViewpoint_Cond.sf_FldComparisonOp == null || objvPaperSubViewpoint_Cond.sf_FldComparisonOp == "") return arrvPaperSubViewpoint_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvPaperSubViewpoint_Cond.sf_FldComparisonOp);
//console.log("clsvPaperSubViewpointWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvPaperSubViewpoint_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvPaperSubViewpoint_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvPaperSubViewpoint_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objvPaperSubViewpoint_Cond), vPaperSubViewpoint_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvPaperSubViewpointEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrSubViewpointId:关键字列表
 * @returns 对象列表
 **/
export async function vPaperSubViewpoint_GetObjLstBySubViewpointIdLstAsync(arrSubViewpointId: Array<string>): Promise<Array<clsvPaperSubViewpointEN>>  
{
const strThisFuncName = "GetObjLstBySubViewpointIdLstAsync";
const strAction = "GetObjLstBySubViewpointIdLst";
const strUrl = GetWebApiUrl(vPaperSubViewpoint_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrSubViewpointId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vPaperSubViewpoint_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vPaperSubViewpoint_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSubViewpoint_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSubViewpoint_ConstructorName, strThisFuncName);
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
 * @param arrstrSubViewpointIdLst:关键字列表
 * @returns 对象列表
*/
export async function vPaperSubViewpoint_GetObjLstBySubViewpointIdLst_Cache(arrSubViewpointIdLst: Array<string>,strid_CurrEduCls: string) {
const strThisFuncName = "GetObjLstBySubViewpointIdLst_Cache";
try
{
const arrvPaperSubViewpointObjLst_Cache = await vPaperSubViewpoint_GetObjLst_Cache(strid_CurrEduCls);
const arrvPaperSubViewpoint_Sel: Array <clsvPaperSubViewpointEN> = arrvPaperSubViewpointObjLst_Cache.filter(x => arrSubViewpointIdLst.indexOf(x.subViewpointId)>-1);
return arrvPaperSubViewpoint_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrSubViewpointIdLst.join(","), vPaperSubViewpoint_ConstructorName, strThisFuncName);
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
export async function vPaperSubViewpoint_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsvPaperSubViewpointEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(vPaperSubViewpoint_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vPaperSubViewpoint_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vPaperSubViewpoint_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSubViewpoint_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSubViewpoint_ConstructorName, strThisFuncName);
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
export async function vPaperSubViewpoint_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsvPaperSubViewpointEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vPaperSubViewpoint_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vPaperSubViewpoint_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vPaperSubViewpoint_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSubViewpoint_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSubViewpoint_ConstructorName, strThisFuncName);
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
export async function vPaperSubViewpoint_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vPaperSubViewpoint_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSubViewpoint_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSubViewpoint_ConstructorName, strThisFuncName);
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
export async function vPaperSubViewpoint_GetObjLstByPager_Cache(objPagerPara: stuPagerPara,strid_CurrEduCls: string) {
const strThisFuncName = "GetObjLstByPager_Cache";
if (objPagerPara.pageIndex == 0) return new Array<clsvPaperSubViewpointEN>();
const arrvPaperSubViewpointObjLst_Cache = await vPaperSubViewpoint_GetObjLst_Cache(strid_CurrEduCls);
if (arrvPaperSubViewpointObjLst_Cache.length == 0) return arrvPaperSubViewpointObjLst_Cache;
let arrvPaperSubViewpoint_Sel = arrvPaperSubViewpointObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objvPaperSubViewpoint_Cond = new clsvPaperSubViewpointEN();
ObjectAssign(objvPaperSubViewpoint_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsvPaperSubViewpointWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvPaperSubViewpoint_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvPaperSubViewpoint_Sel.length == 0) return arrvPaperSubViewpoint_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.sort(vPaperSubViewpoint_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.sort(objPagerPara.sortFun);
}
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.slice(intStart, intEnd);     
return arrvPaperSubViewpoint_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, vPaperSubViewpoint_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvPaperSubViewpointEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function vPaperSubViewpoint_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsvPaperSubViewpointEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
if (objPagerPara.pageIndex == 0) return new Array<clsvPaperSubViewpointEN>();
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(vPaperSubViewpoint_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vPaperSubViewpoint_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vPaperSubViewpoint_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSubViewpoint_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSubViewpoint_ConstructorName, strThisFuncName);
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
 * @param objstrSubViewpointId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vPaperSubViewpoint_IsExistRecord_Cache(objvPaperSubViewpoint_Cond: clsvPaperSubViewpointEN,strid_CurrEduCls: string) {
const strThisFuncName = "IsExistRecord_Cache";
const arrvPaperSubViewpointObjLst_Cache = await vPaperSubViewpoint_GetObjLst_Cache(strid_CurrEduCls);
if (arrvPaperSubViewpointObjLst_Cache == null) return false;
let arrvPaperSubViewpoint_Sel: Array < clsvPaperSubViewpointEN > = arrvPaperSubViewpointObjLst_Cache;
if (objvPaperSubViewpoint_Cond.sf_FldComparisonOp == null || objvPaperSubViewpoint_Cond.sf_FldComparisonOp == "") return arrvPaperSubViewpoint_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvPaperSubViewpoint_Cond.sf_FldComparisonOp);
//console.log("clsvPaperSubViewpointWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvPaperSubViewpoint_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvPaperSubViewpoint_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvPaperSubViewpoint_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objvPaperSubViewpoint_Cond), vPaperSubViewpoint_ConstructorName, strThisFuncName);
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
export async function vPaperSubViewpoint_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(vPaperSubViewpoint_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSubViewpoint_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSubViewpoint_ConstructorName, strThisFuncName);
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
 * @param strSubViewpointId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function vPaperSubViewpoint_IsExist(strSubViewpointId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vPaperSubViewpoint_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"SubViewpointId": strSubViewpointId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSubViewpoint_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSubViewpoint_ConstructorName, strThisFuncName);
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
 * @param strSubViewpointId:所给的关键字
 * @returns 对象
*/
export async function vPaperSubViewpoint_IsExist_Cache(strSubViewpointId:string,strid_CurrEduCls:string) {
const strThisFuncName = "IsExist_Cache";
const arrvPaperSubViewpointObjLst_Cache = await vPaperSubViewpoint_GetObjLst_Cache(strid_CurrEduCls);
if (arrvPaperSubViewpointObjLst_Cache == null) return false;
try
{
const arrvPaperSubViewpoint_Sel: Array <clsvPaperSubViewpointEN> = arrvPaperSubViewpointObjLst_Cache.filter(x => x.subViewpointId == strSubViewpointId);
if (arrvPaperSubViewpoint_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strSubViewpointId, vPaperSubViewpoint_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param strSubViewpointId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function vPaperSubViewpoint_IsExistAsync(strSubViewpointId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vPaperSubViewpoint_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strSubViewpointId": strSubViewpointId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSubViewpoint_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSubViewpoint_ConstructorName, strThisFuncName);
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
export async function vPaperSubViewpoint_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(vPaperSubViewpoint_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSubViewpoint_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSubViewpoint_ConstructorName, strThisFuncName);
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
 * @param objvPaperSubViewpoint_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function vPaperSubViewpoint_GetRecCountByCond_Cache(objvPaperSubViewpoint_Cond: clsvPaperSubViewpointEN,strid_CurrEduCls: string) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrvPaperSubViewpointObjLst_Cache = await vPaperSubViewpoint_GetObjLst_Cache(strid_CurrEduCls);
if (arrvPaperSubViewpointObjLst_Cache == null) return 0;
let arrvPaperSubViewpoint_Sel: Array < clsvPaperSubViewpointEN > = arrvPaperSubViewpointObjLst_Cache;
if (objvPaperSubViewpoint_Cond.sf_FldComparisonOp == null || objvPaperSubViewpoint_Cond.sf_FldComparisonOp == "") return arrvPaperSubViewpoint_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvPaperSubViewpoint_Cond.sf_FldComparisonOp);
//console.log("clsvPaperSubViewpointWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvPaperSubViewpoint_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvPaperSubViewpoint_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvPaperSubViewpoint_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objvPaperSubViewpoint_Cond), vPaperSubViewpoint_ConstructorName, strThisFuncName);
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
export function vPaperSubViewpoint_GetWebApiUrl(strController: string, strAction: string): string {
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
export function vPaperSubViewpoint_ReFreshThisCache(strid_CurrEduCls: string):void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = Format("{0}_{1}", clsvPaperSubViewpointEN._CurrTabName, strid_CurrEduCls);
switch (clsvPaperSubViewpointEN.CacheModeId)
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
export function vPaperSubViewpoint_GetJSONStrByObj (pobjvPaperSubViewpointEN: clsvPaperSubViewpointEN): string
{
const strThisFuncName = "GetJSONStrByObj";
let strJson = "";
try
{
strJson = JSON.stringify(pobjvPaperSubViewpointEN);
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
export function vPaperSubViewpoint_GetObjLstByJSONStr (strJSON: string): Array<clsvPaperSubViewpointEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrvPaperSubViewpointObjLst = new Array<clsvPaperSubViewpointEN>();
if (strJSON === "")
{
return arrvPaperSubViewpointObjLst;
}
try
{
arrvPaperSubViewpointObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvPaperSubViewpointObjLst;
}
return arrvPaperSubViewpointObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrvPaperSubViewpointObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function vPaperSubViewpoint_GetObjLstByJSONObjLst (arrvPaperSubViewpointObjLstS: Array<clsvPaperSubViewpointEN>): Array<clsvPaperSubViewpointEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrvPaperSubViewpointObjLst = new Array<clsvPaperSubViewpointEN>();
for (const objInFor of arrvPaperSubViewpointObjLstS) {
const obj1 = vPaperSubViewpoint_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrvPaperSubViewpointObjLst.push(obj1);
}
return arrvPaperSubViewpointObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vPaperSubViewpoint_GetObjByJSONStr (strJSON: string): clsvPaperSubViewpointEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjvPaperSubViewpointEN = new clsvPaperSubViewpointEN();
if (strJSON === "")
{
return pobjvPaperSubViewpointEN;
}
try
{
pobjvPaperSubViewpointEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvPaperSubViewpointEN;
}
return pobjvPaperSubViewpointEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function vPaperSubViewpoint_GetCombineCondition(objvPaperSubViewpoint_Cond: clsvPaperSubViewpointEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN.con_SubViewpointId) == true)
{
const strComparisonOp_SubViewpointId:string = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN.con_SubViewpointId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperSubViewpointEN.con_SubViewpointId, objvPaperSubViewpoint_Cond.subViewpointId, strComparisonOp_SubViewpointId);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN.con_PaperRWId) == true)
{
const strComparisonOp_PaperRWId:string = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN.con_PaperRWId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperSubViewpointEN.con_PaperRWId, objvPaperSubViewpoint_Cond.paperRWId, strComparisonOp_PaperRWId);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN.con_PaperId) == true)
{
const strComparisonOp_PaperId:string = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN.con_PaperId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperSubViewpointEN.con_PaperId, objvPaperSubViewpoint_Cond.paperId, strComparisonOp_PaperId);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN.con_PaperTitle) == true)
{
const strComparisonOp_PaperTitle:string = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN.con_PaperTitle];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperSubViewpointEN.con_PaperTitle, objvPaperSubViewpoint_Cond.paperTitle, strComparisonOp_PaperTitle);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN.con_IsSubmit) == true)
{
if (objvPaperSubViewpoint_Cond.isSubmit == true)
{
strWhereCond += Format(" And {0} = '1'", clsvPaperSubViewpointEN.con_IsSubmit);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvPaperSubViewpointEN.con_IsSubmit);
}
}
if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperSubViewpointEN.con_id_CurrEduCls, objvPaperSubViewpoint_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN.con_UserId) == true)
{
const strComparisonOp_UserId:string = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN.con_UserId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperSubViewpointEN.con_UserId, objvPaperSubViewpoint_Cond.userId, strComparisonOp_UserId);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN.con_SectionId) == true)
{
const strComparisonOp_SectionId:string = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN.con_SectionId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperSubViewpointEN.con_SectionId, objvPaperSubViewpoint_Cond.sectionId, strComparisonOp_SectionId);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN.con_SectionName) == true)
{
const strComparisonOp_SectionName:string = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN.con_SectionName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperSubViewpointEN.con_SectionName, objvPaperSubViewpoint_Cond.sectionName, strComparisonOp_SectionName);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN.con_SubViewpointTypeId) == true)
{
const strComparisonOp_SubViewpointTypeId:string = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN.con_SubViewpointTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperSubViewpointEN.con_SubViewpointTypeId, objvPaperSubViewpoint_Cond.subViewpointTypeId, strComparisonOp_SubViewpointTypeId);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN.con_SubViewpointTypeName) == true)
{
const strComparisonOp_SubViewpointTypeName:string = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN.con_SubViewpointTypeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperSubViewpointEN.con_SubViewpointTypeName, objvPaperSubViewpoint_Cond.subViewpointTypeName, strComparisonOp_SubViewpointTypeName);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN.con_DefaTitle) == true)
{
const strComparisonOp_DefaTitle:string = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN.con_DefaTitle];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperSubViewpointEN.con_DefaTitle, objvPaperSubViewpoint_Cond.defaTitle, strComparisonOp_DefaTitle);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN.con_RWTitle) == true)
{
const strComparisonOp_RWTitle:string = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN.con_RWTitle];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperSubViewpointEN.con_RWTitle, objvPaperSubViewpoint_Cond.rwTitle, strComparisonOp_RWTitle);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN.con_ExplainTypeId) == true)
{
const strComparisonOp_ExplainTypeId:string = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN.con_ExplainTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperSubViewpointEN.con_ExplainTypeId, objvPaperSubViewpoint_Cond.explainTypeId, strComparisonOp_ExplainTypeId);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN.con_ExplainTypeName) == true)
{
const strComparisonOp_ExplainTypeName:string = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN.con_ExplainTypeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperSubViewpointEN.con_ExplainTypeName, objvPaperSubViewpoint_Cond.explainTypeName, strComparisonOp_ExplainTypeName);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN.con_ExplainContent) == true)
{
const strComparisonOp_ExplainContent:string = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN.con_ExplainContent];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperSubViewpointEN.con_ExplainContent, objvPaperSubViewpoint_Cond.explainContent, strComparisonOp_ExplainContent);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN.con_IsPublic) == true)
{
if (objvPaperSubViewpoint_Cond.isPublic == true)
{
strWhereCond += Format(" And {0} = '1'", clsvPaperSubViewpointEN.con_IsPublic);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvPaperSubViewpointEN.con_IsPublic);
}
}
if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN.con_LiteratureSourcesId) == true)
{
const strComparisonOp_LiteratureSourcesId:string = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN.con_LiteratureSourcesId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperSubViewpointEN.con_LiteratureSourcesId, objvPaperSubViewpoint_Cond.literatureSourcesId, strComparisonOp_LiteratureSourcesId);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN.con_PageNumber) == true)
{
const strComparisonOp_PageNumber:string = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN.con_PageNumber];
strWhereCond += Format(" And {0} {2} {1}", clsvPaperSubViewpointEN.con_PageNumber, objvPaperSubViewpoint_Cond.pageNumber, strComparisonOp_PageNumber);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN.con_OrderNum) == true)
{
const strComparisonOp_OrderNum:string = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN.con_OrderNum];
strWhereCond += Format(" And {0} {2} {1}", clsvPaperSubViewpointEN.con_OrderNum, objvPaperSubViewpoint_Cond.orderNum, strComparisonOp_OrderNum);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN.con_PaperLineNum) == true)
{
const strComparisonOp_PaperLineNum:string = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN.con_PaperLineNum];
strWhereCond += Format(" And {0} {2} {1}", clsvPaperSubViewpointEN.con_PaperLineNum, objvPaperSubViewpoint_Cond.paperLineNum, strComparisonOp_PaperLineNum);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN.con_PaperPageNum) == true)
{
const strComparisonOp_PaperPageNum:string = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN.con_PaperPageNum];
strWhereCond += Format(" And {0} {2} {1}", clsvPaperSubViewpointEN.con_PaperPageNum, objvPaperSubViewpoint_Cond.paperPageNum, strComparisonOp_PaperPageNum);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN.con_AppraiseCount) == true)
{
const strComparisonOp_AppraiseCount:string = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN.con_AppraiseCount];
strWhereCond += Format(" And {0} {2} {1}", clsvPaperSubViewpointEN.con_AppraiseCount, objvPaperSubViewpoint_Cond.appraiseCount, strComparisonOp_AppraiseCount);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN.con_OkCount) == true)
{
const strComparisonOp_OkCount:string = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN.con_OkCount];
strWhereCond += Format(" And {0} {2} {1}", clsvPaperSubViewpointEN.con_OkCount, objvPaperSubViewpoint_Cond.okCount, strComparisonOp_OkCount);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN.con_Score) == true)
{
const strComparisonOp_Score:string = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN.con_Score];
strWhereCond += Format(" And {0} {2} {1}", clsvPaperSubViewpointEN.con_Score, objvPaperSubViewpoint_Cond.score, strComparisonOp_Score);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN.con_StuScore) == true)
{
const strComparisonOp_StuScore:string = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN.con_StuScore];
strWhereCond += Format(" And {0} {2} {1}", clsvPaperSubViewpointEN.con_StuScore, objvPaperSubViewpoint_Cond.stuScore, strComparisonOp_StuScore);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN.con_TeaScore) == true)
{
const strComparisonOp_TeaScore:string = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN.con_TeaScore];
strWhereCond += Format(" And {0} {2} {1}", clsvPaperSubViewpointEN.con_TeaScore, objvPaperSubViewpoint_Cond.teaScore, strComparisonOp_TeaScore);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN.con_CreateDate) == true)
{
const strComparisonOp_CreateDate:string = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN.con_CreateDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperSubViewpointEN.con_CreateDate, objvPaperSubViewpoint_Cond.createDate, strComparisonOp_CreateDate);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN.con_ShareId) == true)
{
const strComparisonOp_ShareId:string = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN.con_ShareId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperSubViewpointEN.con_ShareId, objvPaperSubViewpoint_Cond.shareId, strComparisonOp_ShareId);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN.con_TopicId) == true)
{
const strComparisonOp_TopicId:string = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN.con_TopicId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperSubViewpointEN.con_TopicId, objvPaperSubViewpoint_Cond.topicId, strComparisonOp_TopicId);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN.con_AttitudesId) == true)
{
const strComparisonOp_AttitudesId:string = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN.con_AttitudesId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperSubViewpointEN.con_AttitudesId, objvPaperSubViewpoint_Cond.attitudesId, strComparisonOp_AttitudesId);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN.con_AttitudesName) == true)
{
const strComparisonOp_AttitudesName:string = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN.con_AttitudesName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperSubViewpointEN.con_AttitudesName, objvPaperSubViewpoint_Cond.attitudesName, strComparisonOp_AttitudesName);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperSubViewpointEN.con_UpdDate, objvPaperSubViewpoint_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperSubViewpointEN.con_UpdUser, objvPaperSubViewpoint_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperSubViewpointEN.con_Memo, objvPaperSubViewpoint_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN.con_SectionOrderNum) == true)
{
const strComparisonOp_SectionOrderNum:string = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN.con_SectionOrderNum];
strWhereCond += Format(" And {0} {2} {1}", clsvPaperSubViewpointEN.con_SectionOrderNum, objvPaperSubViewpoint_Cond.sectionOrderNum, strComparisonOp_SectionOrderNum);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN.con_SubViewpointTypeOrderNum) == true)
{
const strComparisonOp_SubViewpointTypeOrderNum:string = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN.con_SubViewpointTypeOrderNum];
strWhereCond += Format(" And {0} {2} {1}", clsvPaperSubViewpointEN.con_SubViewpointTypeOrderNum, objvPaperSubViewpoint_Cond.subViewpointTypeOrderNum, strComparisonOp_SubViewpointTypeOrderNum);
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objvPaperSubViewpointENS:源对象
 * @param objvPaperSubViewpointENT:目标对象
*/
export function vPaperSubViewpoint_CopyObjTo(objvPaperSubViewpointENS: clsvPaperSubViewpointEN , objvPaperSubViewpointENT: clsvPaperSubViewpointEN ): void 
{
objvPaperSubViewpointENT.subViewpointId = objvPaperSubViewpointENS.subViewpointId; //子观点Id
objvPaperSubViewpointENT.paperRWId = objvPaperSubViewpointENS.paperRWId; //课文阅读
objvPaperSubViewpointENT.paperId = objvPaperSubViewpointENS.paperId; //论文Id
objvPaperSubViewpointENT.paperTitle = objvPaperSubViewpointENS.paperTitle; //论文标题
objvPaperSubViewpointENT.isSubmit = objvPaperSubViewpointENS.isSubmit; //是否提交
objvPaperSubViewpointENT.id_CurrEduCls = objvPaperSubViewpointENS.id_CurrEduCls; //教学班流水号
objvPaperSubViewpointENT.userId = objvPaperSubViewpointENS.userId; //用户ID
objvPaperSubViewpointENT.sectionId = objvPaperSubViewpointENS.sectionId; //节Id
objvPaperSubViewpointENT.sectionName = objvPaperSubViewpointENS.sectionName; //节名
objvPaperSubViewpointENT.subViewpointTypeId = objvPaperSubViewpointENS.subViewpointTypeId; //类型Id
objvPaperSubViewpointENT.subViewpointTypeName = objvPaperSubViewpointENS.subViewpointTypeName; //类型名称
objvPaperSubViewpointENT.defaTitle = objvPaperSubViewpointENS.defaTitle; //默认标题
objvPaperSubViewpointENT.rwTitle = objvPaperSubViewpointENS.rwTitle; //读写标题
objvPaperSubViewpointENT.subViewpointContent = objvPaperSubViewpointENS.subViewpointContent; //详情内容
objvPaperSubViewpointENT.explainTypeId = objvPaperSubViewpointENS.explainTypeId; //说明类型Id
objvPaperSubViewpointENT.explainTypeName = objvPaperSubViewpointENS.explainTypeName; //说明类型名
objvPaperSubViewpointENT.explainContent = objvPaperSubViewpointENS.explainContent; //说明内容
objvPaperSubViewpointENT.isPublic = objvPaperSubViewpointENS.isPublic; //是否公开
objvPaperSubViewpointENT.literatureSourcesId = objvPaperSubViewpointENS.literatureSourcesId; //文献来源
objvPaperSubViewpointENT.pageNumber = objvPaperSubViewpointENS.pageNumber; //页码
objvPaperSubViewpointENT.orderNum = objvPaperSubViewpointENS.orderNum; //序号
objvPaperSubViewpointENT.paperLineNum = objvPaperSubViewpointENS.paperLineNum; //论文行号
objvPaperSubViewpointENT.paperPageNum = objvPaperSubViewpointENS.paperPageNum; //论文页码
objvPaperSubViewpointENT.appraiseCount = objvPaperSubViewpointENS.appraiseCount; //评论数
objvPaperSubViewpointENT.okCount = objvPaperSubViewpointENS.okCount; //点赞统计
objvPaperSubViewpointENT.score = objvPaperSubViewpointENS.score; //评分
objvPaperSubViewpointENT.stuScore = objvPaperSubViewpointENS.stuScore; //学生平均分
objvPaperSubViewpointENT.teaScore = objvPaperSubViewpointENS.teaScore; //教师评分
objvPaperSubViewpointENT.createDate = objvPaperSubViewpointENS.createDate; //建立日期
objvPaperSubViewpointENT.shareId = objvPaperSubViewpointENS.shareId; //分享Id
objvPaperSubViewpointENT.topicId = objvPaperSubViewpointENS.topicId; //主题Id
objvPaperSubViewpointENT.attitudesId = objvPaperSubViewpointENS.attitudesId; //态度Id
objvPaperSubViewpointENT.attitudesName = objvPaperSubViewpointENS.attitudesName; //名称
objvPaperSubViewpointENT.updDate = objvPaperSubViewpointENS.updDate; //修改日期
objvPaperSubViewpointENT.updUser = objvPaperSubViewpointENS.updUser; //修改人
objvPaperSubViewpointENT.memo = objvPaperSubViewpointENS.memo; //备注
objvPaperSubViewpointENT.sectionOrderNum = objvPaperSubViewpointENS.sectionOrderNum; //SectionOrderNum
objvPaperSubViewpointENT.subViewpointTypeOrderNum = objvPaperSubViewpointENS.subViewpointTypeOrderNum; //子观点类型序号
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objvPaperSubViewpointENS:源对象
 * @param objvPaperSubViewpointENT:目标对象
*/
export function vPaperSubViewpoint_GetObjFromJsonObj(objvPaperSubViewpointENS: clsvPaperSubViewpointEN): clsvPaperSubViewpointEN 
{
 const objvPaperSubViewpointENT: clsvPaperSubViewpointEN = new clsvPaperSubViewpointEN();
ObjectAssign(objvPaperSubViewpointENT, objvPaperSubViewpointENS);
 return objvPaperSubViewpointENT;
}