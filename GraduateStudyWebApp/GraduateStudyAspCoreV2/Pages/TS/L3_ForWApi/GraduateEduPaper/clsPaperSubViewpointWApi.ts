
 /**
 * 类名:clsPaperSubViewpointWApi
 * 表名:PaperSubViewpoint(01120534)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:54:23
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
 * 子观点表(PaperSubViewpoint)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2023年03月13日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { enumComparisonOp } from "../../PubFun/enumComparisonOp.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { clsPaperSubViewpointEN } from "../../L0_Entity/GraduateEduPaper/clsPaperSubViewpointEN.js";
import { clsOrderByData } from "../../PubFun/clsOrderByData.js";
import { vPaperSubViewpoint_ReFreshThisCache } from "../../L3_ForWApi/GraduateEduPaper/clsvPaperSubViewpointWApi.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { tzDataType } from "../../PubFun/clsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const paperSubViewpoint_Controller = "PaperSubViewpointApi";
 export const paperSubViewpoint_ConstructorName = "paperSubViewpoint";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strSubViewpointId:关键字
 * @returns 对象
 **/
export async function PaperSubViewpoint_GetObjBySubViewpointIdAsync(strSubViewpointId: string): Promise<clsPaperSubViewpointEN|null>  
{
const strThisFuncName = "GetObjBySubViewpointIdAsync";

if (IsNullOrEmpty(strSubViewpointId) == true)
{
  const strMsg = Format("参数:[strSubViewpointId]不能为空！(In clsPaperSubViewpointWApi.GetObjBySubViewpointIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strSubViewpointId.length != 8)
{
const strMsg = Format("缓存分类变量:[strSubViewpointId]的长度:[{0}]不正确！(clsPaperSubViewpointWApi.GetObjBySubViewpointIdAsync)", strSubViewpointId.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjBySubViewpointId";
const strUrl = GetWebApiUrl(paperSubViewpoint_Controller, strAction);
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
const objPaperSubViewpoint = PaperSubViewpoint_GetObjFromJsonObj(returnObj);
return objPaperSubViewpoint;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubViewpoint_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubViewpoint_ConstructorName, strThisFuncName);
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
export async function PaperSubViewpoint_GetObjBySubViewpointId_Cache(strSubViewpointId:string,strid_CurrEduCls:string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjBySubViewpointId_Cache";

if (IsNullOrEmpty(strSubViewpointId) == true)
{
  const strMsg = Format("参数:[strSubViewpointId]不能为空！(In clsPaperSubViewpointWApi.GetObjBySubViewpointId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strSubViewpointId.length != 8)
{
const strMsg = Format("缓存分类变量:[strSubViewpointId]的长度:[{0}]不正确！(clsPaperSubViewpointWApi.GetObjBySubViewpointId_Cache)", strSubViewpointId.length);
console.error(strMsg);
throw (strMsg);
}
const arrPaperSubViewpointObjLst_Cache = await PaperSubViewpoint_GetObjLst_Cache(strid_CurrEduCls);
try
{
const arrPaperSubViewpoint_Sel: Array <clsPaperSubViewpointEN> = arrPaperSubViewpointObjLst_Cache.filter(x => 
 x.subViewpointId == strSubViewpointId );
let objPaperSubViewpoint: clsPaperSubViewpointEN;
if (arrPaperSubViewpoint_Sel.length > 0)
{
objPaperSubViewpoint = arrPaperSubViewpoint_Sel[0];
return objPaperSubViewpoint;
}
else
{
if (bolTryAsyncOnce == true)
{
const objPaperSubViewpoint_Const = await PaperSubViewpoint_GetObjBySubViewpointIdAsync(strSubViewpointId);
if (objPaperSubViewpoint_Const != null)
{
PaperSubViewpoint_ReFreshThisCache(strid_CurrEduCls);
return objPaperSubViewpoint_Const;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strSubViewpointId, paperSubViewpoint_ConstructorName, strThisFuncName);
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
export async function PaperSubViewpoint_GetObjBySubViewpointId_localStorage(strSubViewpointId: string) {
const strThisFuncName = "GetObjBySubViewpointId_localStorage";

if (IsNullOrEmpty(strSubViewpointId) == true)
{
  const strMsg = Format("参数:[strSubViewpointId]不能为空！(In clsPaperSubViewpointWApi.GetObjBySubViewpointId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
if (strSubViewpointId.length != 8)
{
const strMsg = Format("缓存分类变量:[strSubViewpointId]的长度:[{0}]不正确！(clsPaperSubViewpointWApi.GetObjBySubViewpointId_localStorage)", strSubViewpointId.length);
console.error(strMsg);
throw (strMsg);
}
const strKey = Format("{0}_{1}", clsPaperSubViewpointEN._CurrTabName, strSubViewpointId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objPaperSubViewpoint_Cache: clsPaperSubViewpointEN = JSON.parse(strTempObj);
return objPaperSubViewpoint_Cache;
}
try
{
const objPaperSubViewpoint = await PaperSubViewpoint_GetObjBySubViewpointIdAsync(strSubViewpointId);
if (objPaperSubViewpoint != null)
{
localStorage.setItem(strKey, JSON.stringify(objPaperSubViewpoint));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objPaperSubViewpoint;
}
return objPaperSubViewpoint;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strSubViewpointId, paperSubViewpoint_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objPaperSubViewpoint:所给的对象
 * @returns 对象
*/
export async function PaperSubViewpoint_UpdateObjInLst_Cache(objPaperSubViewpoint: clsPaperSubViewpointEN,strid_CurrEduCls: string) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrPaperSubViewpointObjLst_Cache = await PaperSubViewpoint_GetObjLst_Cache(strid_CurrEduCls);
const obj = arrPaperSubViewpointObjLst_Cache.find(x => x.subViewpointId == objPaperSubViewpoint.subViewpointId);
if (obj != null)
{
objPaperSubViewpoint.subViewpointId = obj.subViewpointId;
ObjectAssign( obj, objPaperSubViewpoint);
}
else
{
arrPaperSubViewpointObjLst_Cache.push(objPaperSubViewpoint);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, paperSubViewpoint_ConstructorName, strThisFuncName);
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
export async function PaperSubViewpoint_func(strInFldName:string , strOutFldName:string , strInValue:string 
, strid_CurrEduCls_C: string)
{
//const strThisFuncName = "func";

if (IsNullOrEmpty(strid_CurrEduCls_C) == true)
{
  const strMsg = Format("参数:[strid_CurrEduCls_C]不能为空！(In clsPaperSubViewpointWApi.func)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_CurrEduCls_C.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsPaperSubViewpointWApi.func)", strid_CurrEduCls_C.length);
console.error(strMsg);
throw (strMsg);
}

if (strInFldName != clsPaperSubViewpointEN.con_SubViewpointId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsPaperSubViewpointEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strOutFldName, clsPaperSubViewpointEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strSubViewpointId = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objPaperSubViewpoint = await PaperSubViewpoint_GetObjBySubViewpointId_Cache(strSubViewpointId , strid_CurrEduCls_C);
if (objPaperSubViewpoint == null) return "";
if (objPaperSubViewpoint.GetFldValue(strOutFldName) == null) return "";
return objPaperSubViewpoint.GetFldValue(strOutFldName).toString();
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
export function PaperSubViewpoint_SortFun_Defa(a:clsPaperSubViewpointEN , b:clsPaperSubViewpointEN): number 
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
export function PaperSubViewpoint_SortFun_Defa_2Fld(a:clsPaperSubViewpointEN , b:clsPaperSubViewpointEN): number 
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
export function PaperSubViewpoint_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsPaperSubViewpointEN.con_SubViewpointId:
return (a: clsPaperSubViewpointEN, b: clsPaperSubViewpointEN) => {
return a.subViewpointId.localeCompare(b.subViewpointId);
}
case clsPaperSubViewpointEN.con_PaperRWId:
return (a: clsPaperSubViewpointEN, b: clsPaperSubViewpointEN) => {
return a.paperRWId.localeCompare(b.paperRWId);
}
case clsPaperSubViewpointEN.con_PaperId:
return (a: clsPaperSubViewpointEN, b: clsPaperSubViewpointEN) => {
return a.paperId.localeCompare(b.paperId);
}
case clsPaperSubViewpointEN.con_id_CurrEduCls:
return (a: clsPaperSubViewpointEN, b: clsPaperSubViewpointEN) => {
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
case clsPaperSubViewpointEN.con_UserId:
return (a: clsPaperSubViewpointEN, b: clsPaperSubViewpointEN) => {
return a.userId.localeCompare(b.userId);
}
case clsPaperSubViewpointEN.con_SectionId:
return (a: clsPaperSubViewpointEN, b: clsPaperSubViewpointEN) => {
if (a.sectionId == null) return -1;
if (b.sectionId == null) return 1;
return a.sectionId.localeCompare(b.sectionId);
}
case clsPaperSubViewpointEN.con_SubViewpointTypeId:
return (a: clsPaperSubViewpointEN, b: clsPaperSubViewpointEN) => {
return a.subViewpointTypeId.localeCompare(b.subViewpointTypeId);
}
case clsPaperSubViewpointEN.con_RWTitle:
return (a: clsPaperSubViewpointEN, b: clsPaperSubViewpointEN) => {
if (a.rwTitle == null) return -1;
if (b.rwTitle == null) return 1;
return a.rwTitle.localeCompare(b.rwTitle);
}
case clsPaperSubViewpointEN.con_SubViewpointContent:
return (a: clsPaperSubViewpointEN, b: clsPaperSubViewpointEN) => {
if (a.subViewpointContent == null) return -1;
if (b.subViewpointContent == null) return 1;
return a.subViewpointContent.localeCompare(b.subViewpointContent);
}
case clsPaperSubViewpointEN.con_ExplainTypeId:
return (a: clsPaperSubViewpointEN, b: clsPaperSubViewpointEN) => {
if (a.explainTypeId == null) return -1;
if (b.explainTypeId == null) return 1;
return a.explainTypeId.localeCompare(b.explainTypeId);
}
case clsPaperSubViewpointEN.con_ExplainContent:
return (a: clsPaperSubViewpointEN, b: clsPaperSubViewpointEN) => {
if (a.explainContent == null) return -1;
if (b.explainContent == null) return 1;
return a.explainContent.localeCompare(b.explainContent);
}
case clsPaperSubViewpointEN.con_IsPublic:
return (a: clsPaperSubViewpointEN, b: clsPaperSubViewpointEN) => {
if (a.isPublic == true) return 1;
else return -1
}
case clsPaperSubViewpointEN.con_LiteratureSourcesId:
return (a: clsPaperSubViewpointEN, b: clsPaperSubViewpointEN) => {
if (a.literatureSourcesId == null) return -1;
if (b.literatureSourcesId == null) return 1;
return a.literatureSourcesId.localeCompare(b.literatureSourcesId);
}
case clsPaperSubViewpointEN.con_PageNumber:
return (a: clsPaperSubViewpointEN, b: clsPaperSubViewpointEN) => {
return a.pageNumber-b.pageNumber;
}
case clsPaperSubViewpointEN.con_OrderNum:
return (a: clsPaperSubViewpointEN, b: clsPaperSubViewpointEN) => {
return a.orderNum-b.orderNum;
}
case clsPaperSubViewpointEN.con_PaperLineNum:
return (a: clsPaperSubViewpointEN, b: clsPaperSubViewpointEN) => {
return a.paperLineNum-b.paperLineNum;
}
case clsPaperSubViewpointEN.con_PaperPageNum:
return (a: clsPaperSubViewpointEN, b: clsPaperSubViewpointEN) => {
return a.paperPageNum-b.paperPageNum;
}
case clsPaperSubViewpointEN.con_AppraiseCount:
return (a: clsPaperSubViewpointEN, b: clsPaperSubViewpointEN) => {
return a.appraiseCount-b.appraiseCount;
}
case clsPaperSubViewpointEN.con_OkCount:
return (a: clsPaperSubViewpointEN, b: clsPaperSubViewpointEN) => {
return a.okCount-b.okCount;
}
case clsPaperSubViewpointEN.con_Score:
return (a: clsPaperSubViewpointEN, b: clsPaperSubViewpointEN) => {
return a.score-b.score;
}
case clsPaperSubViewpointEN.con_StuScore:
return (a: clsPaperSubViewpointEN, b: clsPaperSubViewpointEN) => {
return a.stuScore-b.stuScore;
}
case clsPaperSubViewpointEN.con_TeaScore:
return (a: clsPaperSubViewpointEN, b: clsPaperSubViewpointEN) => {
return a.teaScore-b.teaScore;
}
case clsPaperSubViewpointEN.con_CreateDate:
return (a: clsPaperSubViewpointEN, b: clsPaperSubViewpointEN) => {
if (a.createDate == null) return -1;
if (b.createDate == null) return 1;
return a.createDate.localeCompare(b.createDate);
}
case clsPaperSubViewpointEN.con_ShareId:
return (a: clsPaperSubViewpointEN, b: clsPaperSubViewpointEN) => {
return a.shareId.localeCompare(b.shareId);
}
case clsPaperSubViewpointEN.con_TopicId:
return (a: clsPaperSubViewpointEN, b: clsPaperSubViewpointEN) => {
if (a.topicId == null) return -1;
if (b.topicId == null) return 1;
return a.topicId.localeCompare(b.topicId);
}
case clsPaperSubViewpointEN.con_AttitudesId:
return (a: clsPaperSubViewpointEN, b: clsPaperSubViewpointEN) => {
if (a.attitudesId == null) return -1;
if (b.attitudesId == null) return 1;
return a.attitudesId.localeCompare(b.attitudesId);
}
case clsPaperSubViewpointEN.con_UpdDate:
return (a: clsPaperSubViewpointEN, b: clsPaperSubViewpointEN) => {
if (a.updDate == null) return -1;
if (b.updDate == null) return 1;
return a.updDate.localeCompare(b.updDate);
}
case clsPaperSubViewpointEN.con_UpdUser:
return (a: clsPaperSubViewpointEN, b: clsPaperSubViewpointEN) => {
if (a.updUser == null) return -1;
if (b.updUser == null) return 1;
return a.updUser.localeCompare(b.updUser);
}
case clsPaperSubViewpointEN.con_Memo:
return (a: clsPaperSubViewpointEN, b: clsPaperSubViewpointEN) => {
if (a.memo == null) return -1;
if (b.memo == null) return 1;
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[PaperSubViewpoint]中不存在！(in ${ paperSubViewpoint_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsPaperSubViewpointEN.con_SubViewpointId:
return (a: clsPaperSubViewpointEN, b: clsPaperSubViewpointEN) => {
return b.subViewpointId.localeCompare(a.subViewpointId);
}
case clsPaperSubViewpointEN.con_PaperRWId:
return (a: clsPaperSubViewpointEN, b: clsPaperSubViewpointEN) => {
return b.paperRWId.localeCompare(a.paperRWId);
}
case clsPaperSubViewpointEN.con_PaperId:
return (a: clsPaperSubViewpointEN, b: clsPaperSubViewpointEN) => {
return b.paperId.localeCompare(a.paperId);
}
case clsPaperSubViewpointEN.con_id_CurrEduCls:
return (a: clsPaperSubViewpointEN, b: clsPaperSubViewpointEN) => {
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
case clsPaperSubViewpointEN.con_UserId:
return (a: clsPaperSubViewpointEN, b: clsPaperSubViewpointEN) => {
return b.userId.localeCompare(a.userId);
}
case clsPaperSubViewpointEN.con_SectionId:
return (a: clsPaperSubViewpointEN, b: clsPaperSubViewpointEN) => {
if (b.sectionId == null) return -1;
if (a.sectionId == null) return 1;
return b.sectionId.localeCompare(a.sectionId);
}
case clsPaperSubViewpointEN.con_SubViewpointTypeId:
return (a: clsPaperSubViewpointEN, b: clsPaperSubViewpointEN) => {
return b.subViewpointTypeId.localeCompare(a.subViewpointTypeId);
}
case clsPaperSubViewpointEN.con_RWTitle:
return (a: clsPaperSubViewpointEN, b: clsPaperSubViewpointEN) => {
if (b.rwTitle == null) return -1;
if (a.rwTitle == null) return 1;
return b.rwTitle.localeCompare(a.rwTitle);
}
case clsPaperSubViewpointEN.con_SubViewpointContent:
return (a: clsPaperSubViewpointEN, b: clsPaperSubViewpointEN) => {
if (b.subViewpointContent == null) return -1;
if (a.subViewpointContent == null) return 1;
return b.subViewpointContent.localeCompare(a.subViewpointContent);
}
case clsPaperSubViewpointEN.con_ExplainTypeId:
return (a: clsPaperSubViewpointEN, b: clsPaperSubViewpointEN) => {
if (b.explainTypeId == null) return -1;
if (a.explainTypeId == null) return 1;
return b.explainTypeId.localeCompare(a.explainTypeId);
}
case clsPaperSubViewpointEN.con_ExplainContent:
return (a: clsPaperSubViewpointEN, b: clsPaperSubViewpointEN) => {
if (b.explainContent == null) return -1;
if (a.explainContent == null) return 1;
return b.explainContent.localeCompare(a.explainContent);
}
case clsPaperSubViewpointEN.con_IsPublic:
return (a: clsPaperSubViewpointEN, b: clsPaperSubViewpointEN) => {
if (b.isPublic == true) return 1;
else return -1
}
case clsPaperSubViewpointEN.con_LiteratureSourcesId:
return (a: clsPaperSubViewpointEN, b: clsPaperSubViewpointEN) => {
if (b.literatureSourcesId == null) return -1;
if (a.literatureSourcesId == null) return 1;
return b.literatureSourcesId.localeCompare(a.literatureSourcesId);
}
case clsPaperSubViewpointEN.con_PageNumber:
return (a: clsPaperSubViewpointEN, b: clsPaperSubViewpointEN) => {
return b.pageNumber-a.pageNumber;
}
case clsPaperSubViewpointEN.con_OrderNum:
return (a: clsPaperSubViewpointEN, b: clsPaperSubViewpointEN) => {
return b.orderNum-a.orderNum;
}
case clsPaperSubViewpointEN.con_PaperLineNum:
return (a: clsPaperSubViewpointEN, b: clsPaperSubViewpointEN) => {
return b.paperLineNum-a.paperLineNum;
}
case clsPaperSubViewpointEN.con_PaperPageNum:
return (a: clsPaperSubViewpointEN, b: clsPaperSubViewpointEN) => {
return b.paperPageNum-a.paperPageNum;
}
case clsPaperSubViewpointEN.con_AppraiseCount:
return (a: clsPaperSubViewpointEN, b: clsPaperSubViewpointEN) => {
return b.appraiseCount-a.appraiseCount;
}
case clsPaperSubViewpointEN.con_OkCount:
return (a: clsPaperSubViewpointEN, b: clsPaperSubViewpointEN) => {
return b.okCount-a.okCount;
}
case clsPaperSubViewpointEN.con_Score:
return (a: clsPaperSubViewpointEN, b: clsPaperSubViewpointEN) => {
return b.score-a.score;
}
case clsPaperSubViewpointEN.con_StuScore:
return (a: clsPaperSubViewpointEN, b: clsPaperSubViewpointEN) => {
return b.stuScore-a.stuScore;
}
case clsPaperSubViewpointEN.con_TeaScore:
return (a: clsPaperSubViewpointEN, b: clsPaperSubViewpointEN) => {
return b.teaScore-a.teaScore;
}
case clsPaperSubViewpointEN.con_CreateDate:
return (a: clsPaperSubViewpointEN, b: clsPaperSubViewpointEN) => {
if (b.createDate == null) return -1;
if (a.createDate == null) return 1;
return b.createDate.localeCompare(a.createDate);
}
case clsPaperSubViewpointEN.con_ShareId:
return (a: clsPaperSubViewpointEN, b: clsPaperSubViewpointEN) => {
return b.shareId.localeCompare(a.shareId);
}
case clsPaperSubViewpointEN.con_TopicId:
return (a: clsPaperSubViewpointEN, b: clsPaperSubViewpointEN) => {
if (b.topicId == null) return -1;
if (a.topicId == null) return 1;
return b.topicId.localeCompare(a.topicId);
}
case clsPaperSubViewpointEN.con_AttitudesId:
return (a: clsPaperSubViewpointEN, b: clsPaperSubViewpointEN) => {
if (b.attitudesId == null) return -1;
if (a.attitudesId == null) return 1;
return b.attitudesId.localeCompare(a.attitudesId);
}
case clsPaperSubViewpointEN.con_UpdDate:
return (a: clsPaperSubViewpointEN, b: clsPaperSubViewpointEN) => {
if (b.updDate == null) return -1;
if (a.updDate == null) return 1;
return b.updDate.localeCompare(a.updDate);
}
case clsPaperSubViewpointEN.con_UpdUser:
return (a: clsPaperSubViewpointEN, b: clsPaperSubViewpointEN) => {
if (b.updUser == null) return -1;
if (a.updUser == null) return 1;
return b.updUser.localeCompare(a.updUser);
}
case clsPaperSubViewpointEN.con_Memo:
return (a: clsPaperSubViewpointEN, b: clsPaperSubViewpointEN) => {
if (b.memo == null) return -1;
if (a.memo == null) return 1;
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[PaperSubViewpoint]中不存在！(in ${ paperSubViewpoint_ConstructorName}.${ strThisFuncName})`;
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
export async function PaperSubViewpoint_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsPaperSubViewpointEN.con_SubViewpointId:
return (obj: clsPaperSubViewpointEN) => {
return obj.subViewpointId === value;
}
case clsPaperSubViewpointEN.con_PaperRWId:
return (obj: clsPaperSubViewpointEN) => {
return obj.paperRWId === value;
}
case clsPaperSubViewpointEN.con_PaperId:
return (obj: clsPaperSubViewpointEN) => {
return obj.paperId === value;
}
case clsPaperSubViewpointEN.con_id_CurrEduCls:
return (obj: clsPaperSubViewpointEN) => {
return obj.id_CurrEduCls === value;
}
case clsPaperSubViewpointEN.con_UserId:
return (obj: clsPaperSubViewpointEN) => {
return obj.userId === value;
}
case clsPaperSubViewpointEN.con_SectionId:
return (obj: clsPaperSubViewpointEN) => {
return obj.sectionId === value;
}
case clsPaperSubViewpointEN.con_SubViewpointTypeId:
return (obj: clsPaperSubViewpointEN) => {
return obj.subViewpointTypeId === value;
}
case clsPaperSubViewpointEN.con_RWTitle:
return (obj: clsPaperSubViewpointEN) => {
return obj.rwTitle === value;
}
case clsPaperSubViewpointEN.con_SubViewpointContent:
return (obj: clsPaperSubViewpointEN) => {
return obj.subViewpointContent === value;
}
case clsPaperSubViewpointEN.con_ExplainTypeId:
return (obj: clsPaperSubViewpointEN) => {
return obj.explainTypeId === value;
}
case clsPaperSubViewpointEN.con_ExplainContent:
return (obj: clsPaperSubViewpointEN) => {
return obj.explainContent === value;
}
case clsPaperSubViewpointEN.con_IsPublic:
return (obj: clsPaperSubViewpointEN) => {
return obj.isPublic === value;
}
case clsPaperSubViewpointEN.con_LiteratureSourcesId:
return (obj: clsPaperSubViewpointEN) => {
return obj.literatureSourcesId === value;
}
case clsPaperSubViewpointEN.con_PageNumber:
return (obj: clsPaperSubViewpointEN) => {
return obj.pageNumber === value;
}
case clsPaperSubViewpointEN.con_OrderNum:
return (obj: clsPaperSubViewpointEN) => {
return obj.orderNum === value;
}
case clsPaperSubViewpointEN.con_PaperLineNum:
return (obj: clsPaperSubViewpointEN) => {
return obj.paperLineNum === value;
}
case clsPaperSubViewpointEN.con_PaperPageNum:
return (obj: clsPaperSubViewpointEN) => {
return obj.paperPageNum === value;
}
case clsPaperSubViewpointEN.con_AppraiseCount:
return (obj: clsPaperSubViewpointEN) => {
return obj.appraiseCount === value;
}
case clsPaperSubViewpointEN.con_OkCount:
return (obj: clsPaperSubViewpointEN) => {
return obj.okCount === value;
}
case clsPaperSubViewpointEN.con_Score:
return (obj: clsPaperSubViewpointEN) => {
return obj.score === value;
}
case clsPaperSubViewpointEN.con_StuScore:
return (obj: clsPaperSubViewpointEN) => {
return obj.stuScore === value;
}
case clsPaperSubViewpointEN.con_TeaScore:
return (obj: clsPaperSubViewpointEN) => {
return obj.teaScore === value;
}
case clsPaperSubViewpointEN.con_CreateDate:
return (obj: clsPaperSubViewpointEN) => {
return obj.createDate === value;
}
case clsPaperSubViewpointEN.con_ShareId:
return (obj: clsPaperSubViewpointEN) => {
return obj.shareId === value;
}
case clsPaperSubViewpointEN.con_TopicId:
return (obj: clsPaperSubViewpointEN) => {
return obj.topicId === value;
}
case clsPaperSubViewpointEN.con_AttitudesId:
return (obj: clsPaperSubViewpointEN) => {
return obj.attitudesId === value;
}
case clsPaperSubViewpointEN.con_UpdDate:
return (obj: clsPaperSubViewpointEN) => {
return obj.updDate === value;
}
case clsPaperSubViewpointEN.con_UpdUser:
return (obj: clsPaperSubViewpointEN) => {
return obj.updUser === value;
}
case clsPaperSubViewpointEN.con_Memo:
return (obj: clsPaperSubViewpointEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[PaperSubViewpoint]中不存在！(in ${ paperSubViewpoint_ConstructorName}.${ strThisFuncName})`;
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
export async function PaperSubViewpoint_funcKey(strInFldName:string, strInValue: any, strComparisonOp:string, strid_CurrEduCls_C: string): Promise<Array<string>>
{
//const strThisFuncName = "funcKey";

if (IsNullOrEmpty(strid_CurrEduCls_C) == true)
{
  const strMsg = Format("参数:[strid_CurrEduCls_C]不能为空！(In clsPaperSubViewpointWApi.funcKey)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_CurrEduCls_C.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsPaperSubViewpointWApi.funcKey)", strid_CurrEduCls_C.length);
console.error(strMsg);
throw (strMsg);
}

if (strInFldName == clsPaperSubViewpointEN.con_SubViewpointId)
{
const strMsg = Format("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (IsNullOrEmpty(strInValue) == true)
{
return [];
}
const arrPaperSubViewpoint = await PaperSubViewpoint_GetObjLst_Cache(strid_CurrEduCls_C);
if (arrPaperSubViewpoint == null) return [];
let arrPaperSubViewpoint_Sel = arrPaperSubViewpoint;
const strType = typeof(strInValue);
switch (strType)
{
case "string":
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01: // " = "
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
break;
case enumComparisonOp.Like_03:
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
break;
case enumComparisonOp.In_04:
const arrValues = strInValue.split(',');
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
break;
}
break;
case "boolean":
if (strInValue == null) return [];
if (strComparisonOp == enumComparisonOp.Equal_01)
{
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
}
break;
case "number":
if (Number(strInValue) == 0) return [];
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01:
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
break;
case enumComparisonOp.NotEqual_02:
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
break;
case enumComparisonOp.NotLessThan_05://" >= ":
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
break;
case enumComparisonOp.NotGreaterThan_06://" <= ":
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
case enumComparisonOp.GreaterThan_07://" > ":
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
break;
case enumComparisonOp.LessThan_08://" < ":
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
}
break;
}
if (arrPaperSubViewpoint_Sel.length == 0) return [];
return arrPaperSubViewpoint_Sel.map(x=>x.subViewpointId);
}

 /**
 * 根据条件获取满足条件的第一条记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
 * @param strWhereCond:条件
 * @returns 返回的第一条记录的关键字值
 **/
export async function PaperSubViewpoint_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(paperSubViewpoint_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubViewpoint_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubViewpoint_ConstructorName, strThisFuncName);
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
export async function PaperSubViewpoint_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(paperSubViewpoint_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubViewpoint_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubViewpoint_ConstructorName, strThisFuncName);
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
export async function PaperSubViewpoint_GetFirstObjAsync(strWhereCond: string): Promise<clsPaperSubViewpointEN|null>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(paperSubViewpoint_Controller, strAction);
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
const objPaperSubViewpoint = PaperSubViewpoint_GetObjFromJsonObj(returnObj);
return objPaperSubViewpoint;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubViewpoint_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubViewpoint_ConstructorName, strThisFuncName);
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
export async function PaperSubViewpoint_GetObjLst_ClientCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
if (IsNullOrEmpty(clsPaperSubViewpointEN.WhereFormat) == false)
{
strWhereCond = Format(clsPaperSubViewpointEN.WhereFormat, strid_CurrEduCls);
}
else
{
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
}
const strKey = Format("{0}_{1}", clsPaperSubViewpointEN._CurrTabName, strid_CurrEduCls);
if (IsNullOrEmpty(clsPaperSubViewpointEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsPaperSubViewpointEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrPaperSubViewpointExObjLst_Cache: Array<clsPaperSubViewpointEN> = CacheHelper.Get(strKey);
const arrPaperSubViewpointObjLst_T = PaperSubViewpoint_GetObjLstByJSONObjLst(arrPaperSubViewpointExObjLst_Cache);
return arrPaperSubViewpointObjLst_T;
}
try
{
const arrPaperSubViewpointExObjLst = await PaperSubViewpoint_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrPaperSubViewpointExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrPaperSubViewpointExObjLst.length);
console.log(strInfo);
return arrPaperSubViewpointExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, paperSubViewpoint_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function PaperSubViewpoint_GetObjLst_localStorage(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
if (IsNullOrEmpty(clsPaperSubViewpointEN.WhereFormat) == false)
{
strWhereCond = Format(clsPaperSubViewpointEN.WhereFormat, strid_CurrEduCls);
}
else
{
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
}
const strKey = Format("{0}_{1}", clsPaperSubViewpointEN._CurrTabName, strid_CurrEduCls);
if (IsNullOrEmpty(clsPaperSubViewpointEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsPaperSubViewpointEN.CacheAddiCondition);
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
const arrPaperSubViewpointExObjLst_Cache: Array<clsPaperSubViewpointEN> = JSON.parse(strTempObjLst);
const arrPaperSubViewpointObjLst_T = PaperSubViewpoint_GetObjLstByJSONObjLst(arrPaperSubViewpointExObjLst_Cache);
return arrPaperSubViewpointObjLst_T;
}
try
{
const arrPaperSubViewpointExObjLst = await PaperSubViewpoint_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrPaperSubViewpointExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrPaperSubViewpointExObjLst.length);
console.log(strInfo);
return arrPaperSubViewpointExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, paperSubViewpoint_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function PaperSubViewpoint_GetObjLst_localStorage_PureCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsPaperSubViewpointEN._CurrTabName, strid_CurrEduCls);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrPaperSubViewpointObjLst_Cache: Array<clsPaperSubViewpointEN> = JSON.parse(strTempObjLst);
return arrPaperSubViewpointObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function PaperSubViewpoint_GetObjLstAsync(strWhereCond: string): Promise<Array<clsPaperSubViewpointEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(paperSubViewpoint_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", paperSubViewpoint_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = PaperSubViewpoint_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubViewpoint_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubViewpoint_ConstructorName, strThisFuncName);
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
export async function PaperSubViewpoint_GetObjLst_sessionStorage(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
if (IsNullOrEmpty(clsPaperSubViewpointEN.WhereFormat) == false)
{
strWhereCond = Format(clsPaperSubViewpointEN.WhereFormat, strid_CurrEduCls);
}
else
{
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
}
const strKey = Format("{0}_{1}", clsPaperSubViewpointEN._CurrTabName, strid_CurrEduCls);
if (IsNullOrEmpty(clsPaperSubViewpointEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsPaperSubViewpointEN.CacheAddiCondition);
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
const arrPaperSubViewpointExObjLst_Cache: Array<clsPaperSubViewpointEN> = JSON.parse(strTempObjLst);
const arrPaperSubViewpointObjLst_T = PaperSubViewpoint_GetObjLstByJSONObjLst(arrPaperSubViewpointExObjLst_Cache);
return arrPaperSubViewpointObjLst_T;
}
try
{
const arrPaperSubViewpointExObjLst = await PaperSubViewpoint_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrPaperSubViewpointExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrPaperSubViewpointExObjLst.length);
console.log(strInfo);
return arrPaperSubViewpointExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, paperSubViewpoint_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function PaperSubViewpoint_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsPaperSubViewpointEN._CurrTabName, strid_CurrEduCls);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrPaperSubViewpointObjLst_Cache: Array<clsPaperSubViewpointEN> = JSON.parse(strTempObjLst);
return arrPaperSubViewpointObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function PaperSubViewpoint_GetObjLst_Cache(strid_CurrEduCls: string): Promise<Array<clsPaperSubViewpointEN>>
{
//const strThisFuncName = "GetObjLst_Cache";

if (IsNullOrEmpty(strid_CurrEduCls) == true)
{
const strMsg = Format("缓存分类变量:[id_CurrEduCls]不能为空！(in clsPaperSubViewpointWApi.PaperSubViewpoint_GetObjLst_Cache() )");
console.error(strMsg);
throw (strMsg);
}
if (strid_CurrEduCls.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(in clsPaperSubViewpointWApi.PaperSubViewpoint_GetObjLst_Cache() )", strid_CurrEduCls.length);
console.error(strMsg);
throw (strMsg);
}
let arrPaperSubViewpointObjLst_Cache;
switch (clsPaperSubViewpointEN.CacheModeId)
{
case "04"://sessionStorage
arrPaperSubViewpointObjLst_Cache = await PaperSubViewpoint_GetObjLst_sessionStorage(strid_CurrEduCls);
break;
case "03"://localStorage
arrPaperSubViewpointObjLst_Cache = await PaperSubViewpoint_GetObjLst_localStorage(strid_CurrEduCls);
break;
case "02"://ClientCache
arrPaperSubViewpointObjLst_Cache = await PaperSubViewpoint_GetObjLst_ClientCache(strid_CurrEduCls);
break;
default:
arrPaperSubViewpointObjLst_Cache = await PaperSubViewpoint_GetObjLst_ClientCache(strid_CurrEduCls);
break;
}
const arrPaperSubViewpointObjLst = PaperSubViewpoint_GetObjLstByJSONObjLst(arrPaperSubViewpointObjLst_Cache);
return arrPaperSubViewpointObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function PaperSubViewpoint_GetObjLst_PureCache(strid_CurrEduCls: string)
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrPaperSubViewpointObjLst_Cache;
switch (clsPaperSubViewpointEN.CacheModeId)
{
case "04"://sessionStorage
arrPaperSubViewpointObjLst_Cache = await PaperSubViewpoint_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls);
break;
case "03"://localStorage
arrPaperSubViewpointObjLst_Cache = await PaperSubViewpoint_GetObjLst_localStorage_PureCache(strid_CurrEduCls);
break;
case "02"://ClientCache
arrPaperSubViewpointObjLst_Cache = null;
break;
default:
arrPaperSubViewpointObjLst_Cache = null;
break;
}
return arrPaperSubViewpointObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrSubViewpointId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function PaperSubViewpoint_GetSubObjLst_Cache(objPaperSubViewpoint_Cond: clsPaperSubViewpointEN,strid_CurrEduCls: string) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrPaperSubViewpointObjLst_Cache = await PaperSubViewpoint_GetObjLst_Cache(strid_CurrEduCls);
let arrPaperSubViewpoint_Sel: Array < clsPaperSubViewpointEN > = arrPaperSubViewpointObjLst_Cache;
if (objPaperSubViewpoint_Cond.sf_FldComparisonOp == null || objPaperSubViewpoint_Cond.sf_FldComparisonOp == "") return arrPaperSubViewpoint_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objPaperSubViewpoint_Cond.sf_FldComparisonOp);
//console.log("clsPaperSubViewpointWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objPaperSubViewpoint_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objPaperSubViewpoint_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrPaperSubViewpoint_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objPaperSubViewpoint_Cond), paperSubViewpoint_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsPaperSubViewpointEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrSubViewpointId:关键字列表
 * @returns 对象列表
 **/
export async function PaperSubViewpoint_GetObjLstBySubViewpointIdLstAsync(arrSubViewpointId: Array<string>): Promise<Array<clsPaperSubViewpointEN>>  
{
const strThisFuncName = "GetObjLstBySubViewpointIdLstAsync";
const strAction = "GetObjLstBySubViewpointIdLst";
const strUrl = GetWebApiUrl(paperSubViewpoint_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrSubViewpointId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", paperSubViewpoint_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = PaperSubViewpoint_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubViewpoint_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubViewpoint_ConstructorName, strThisFuncName);
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
export async function PaperSubViewpoint_GetObjLstBySubViewpointIdLst_Cache(arrSubViewpointIdLst: Array<string>,strid_CurrEduCls: string) {
const strThisFuncName = "GetObjLstBySubViewpointIdLst_Cache";
try
{
const arrPaperSubViewpointObjLst_Cache = await PaperSubViewpoint_GetObjLst_Cache(strid_CurrEduCls);
const arrPaperSubViewpoint_Sel: Array <clsPaperSubViewpointEN> = arrPaperSubViewpointObjLst_Cache.filter(x => arrSubViewpointIdLst.indexOf(x.subViewpointId)>-1);
return arrPaperSubViewpoint_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrSubViewpointIdLst.join(","), paperSubViewpoint_ConstructorName, strThisFuncName);
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
export async function PaperSubViewpoint_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsPaperSubViewpointEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(paperSubViewpoint_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", paperSubViewpoint_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = PaperSubViewpoint_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubViewpoint_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubViewpoint_ConstructorName, strThisFuncName);
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
export async function PaperSubViewpoint_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsPaperSubViewpointEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(paperSubViewpoint_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", paperSubViewpoint_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = PaperSubViewpoint_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubViewpoint_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubViewpoint_ConstructorName, strThisFuncName);
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
export async function PaperSubViewpoint_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(paperSubViewpoint_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubViewpoint_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubViewpoint_ConstructorName, strThisFuncName);
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
export async function PaperSubViewpoint_GetObjLstByPager_Cache(objPagerPara: stuPagerPara,strid_CurrEduCls: string) {
const strThisFuncName = "GetObjLstByPager_Cache";
if (objPagerPara.pageIndex == 0) return new Array<clsPaperSubViewpointEN>();
const arrPaperSubViewpointObjLst_Cache = await PaperSubViewpoint_GetObjLst_Cache(strid_CurrEduCls);
if (arrPaperSubViewpointObjLst_Cache.length == 0) return arrPaperSubViewpointObjLst_Cache;
let arrPaperSubViewpoint_Sel = arrPaperSubViewpointObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objPaperSubViewpoint_Cond = new clsPaperSubViewpointEN();
ObjectAssign(objPaperSubViewpoint_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsPaperSubViewpointWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objPaperSubViewpoint_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrPaperSubViewpoint_Sel.length == 0) return arrPaperSubViewpoint_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.sort(PaperSubViewpoint_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.sort(objPagerPara.sortFun);
}
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.slice(intStart, intEnd);     
return arrPaperSubViewpoint_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, paperSubViewpoint_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsPaperSubViewpointEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function PaperSubViewpoint_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsPaperSubViewpointEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
if (objPagerPara.pageIndex == 0) return new Array<clsPaperSubViewpointEN>();
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(paperSubViewpoint_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", paperSubViewpoint_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = PaperSubViewpoint_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubViewpoint_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubViewpoint_ConstructorName, strThisFuncName);
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
 * @param strSubViewpointId:关键字
 * @returns 获取删除的结果
 **/
export async function PaperSubViewpoint_DelRecordAsync(strSubViewpointId: string): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(paperSubViewpoint_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, strSubViewpointId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubViewpoint_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubViewpoint_ConstructorName, strThisFuncName);
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
 * @param arrSubViewpointId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function PaperSubViewpoint_DelPaperSubViewpointsAsync(arrSubViewpointId: Array<string>): Promise<number> 
{
const strThisFuncName = "DelPaperSubViewpointsAsync";
const strAction = "DelPaperSubViewpoints";
const strUrl = GetWebApiUrl(paperSubViewpoint_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrSubViewpointId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubViewpoint_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubViewpoint_ConstructorName, strThisFuncName);
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
export async function PaperSubViewpoint_DelPaperSubViewpointsByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "DelPaperSubViewpointsByCondAsync";
const strAction = "DelPaperSubViewpointsByCond";
const strUrl = GetWebApiUrl(paperSubViewpoint_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubViewpoint_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubViewpoint_ConstructorName, strThisFuncName);
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
 * @param objPaperSubViewpointEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function PaperSubViewpoint_AddNewRecordAsync(objPaperSubViewpointEN: clsPaperSubViewpointEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objPaperSubViewpointEN);
const strUrl = GetWebApiUrl(paperSubViewpoint_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPaperSubViewpointEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubViewpoint_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubViewpoint_ConstructorName, strThisFuncName);
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
 * @param objPaperSubViewpointEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function PaperSubViewpoint_AddNewRecordWithMaxIdAsync(objPaperSubViewpointEN: clsPaperSubViewpointEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithMaxIdAsync";
const strAction = "AddNewRecordWithMaxId";
const strUrl = GetWebApiUrl(paperSubViewpoint_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPaperSubViewpointEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubViewpoint_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubViewpoint_ConstructorName, strThisFuncName);
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
 * @param objPaperSubViewpointEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function PaperSubViewpoint_GoTopAsync(objOrderByData: clsOrderByData): Promise<boolean> 
{
const strThisFuncName = "GoTopAsync";
let strMsg = "";
const strAction = "GoTop";
if (objOrderByData.KeyIdLst.length == 0)
{
strMsg = "根据关键字列表置顶时，给定的关键字值列表不能为空!";
throw strMsg;
}
const strUrl = GetWebApiUrl(paperSubViewpoint_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubViewpoint_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubViewpoint_ConstructorName, strThisFuncName);
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
 * @param objPaperSubViewpointEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function PaperSubViewpoint_UpMoveAsync(objOrderByData: clsOrderByData): Promise<boolean> 
{
const strThisFuncName = "UpMoveAsync";
let strMsg = "";
const strAction = "UpMove";
if (objOrderByData.KeyIdLst.length == 0)
{
strMsg = "根据关键字列表上移时，给定的关键字值列表不能为空!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objPaperSubViewpointEN);
const strUrl = GetWebApiUrl(paperSubViewpoint_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubViewpoint_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubViewpoint_ConstructorName, strThisFuncName);
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
 * @param objPaperSubViewpointEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function PaperSubViewpoint_DownMoveAsync(objOrderByData: clsOrderByData): Promise<boolean> 
{
const strThisFuncName = "DownMoveAsync";
let strMsg = "";
const strAction = "DownMove";
if (objOrderByData.KeyIdLst.length == 0)
{
strMsg = "根据关键字列表下移时，给定的关键字值列表不能为空!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objPaperSubViewpointEN);
const strUrl = GetWebApiUrl(paperSubViewpoint_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubViewpoint_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubViewpoint_ConstructorName, strThisFuncName);
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
 * @param objPaperSubViewpointEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function PaperSubViewpoint_GoBottomAsync(objOrderByData: clsOrderByData): Promise<boolean> 
{
const strThisFuncName = "GoBottomAsync";
let strMsg = "";
const strAction = "GoBottom";
if (objOrderByData.KeyIdLst.length == 0)
{
strMsg = "根据关键字列表置底时，给定的关键字值列表不能为空!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objPaperSubViewpointEN);
const strUrl = GetWebApiUrl(paperSubViewpoint_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubViewpoint_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubViewpoint_ConstructorName, strThisFuncName);
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
 * @param objPaperSubViewpointEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function PaperSubViewpoint_ReOrderAsync(objOrderByData: clsOrderByData): Promise<boolean> 
{
const strThisFuncName = "ReOrderAsync";
const strAction = "ReOrder";
 //var strJSON = JSON.stringify(objPaperSubViewpointEN);
const strUrl = GetWebApiUrl(paperSubViewpoint_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubViewpoint_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubViewpoint_ConstructorName, strThisFuncName);
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
 * @param objPaperSubViewpointEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function PaperSubViewpoint_AddNewRecordWithReturnKeyAsync(objPaperSubViewpointEN: clsPaperSubViewpointEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(paperSubViewpoint_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPaperSubViewpointEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubViewpoint_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubViewpoint_ConstructorName, strThisFuncName);
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
 * @param objPaperSubViewpointEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function PaperSubViewpoint_AddNewRecordWithReturnKey(objPaperSubViewpointEN: clsPaperSubViewpointEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objPaperSubViewpointEN.subViewpointId === null || objPaperSubViewpointEN.subViewpointId === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(paperSubViewpoint_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPaperSubViewpointEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubViewpoint_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubViewpoint_ConstructorName, strThisFuncName);
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
 * @param objPaperSubViewpointEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function PaperSubViewpoint_UpdateRecordAsync(objPaperSubViewpointEN: clsPaperSubViewpointEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objPaperSubViewpointEN.sfUpdFldSetStr === undefined || objPaperSubViewpointEN.sfUpdFldSetStr === null || objPaperSubViewpointEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objPaperSubViewpointEN.subViewpointId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(paperSubViewpoint_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPaperSubViewpointEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubViewpoint_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubViewpoint_ConstructorName, strThisFuncName);
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
 * @param objPaperSubViewpointEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function PaperSubViewpoint_UpdateWithConditionAsync(objPaperSubViewpointEN: clsPaperSubViewpointEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objPaperSubViewpointEN.sfUpdFldSetStr === undefined || objPaperSubViewpointEN.sfUpdFldSetStr === null || objPaperSubViewpointEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objPaperSubViewpointEN.subViewpointId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(paperSubViewpoint_Controller, strAction);
objPaperSubViewpointEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objPaperSubViewpointEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubViewpoint_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubViewpoint_ConstructorName, strThisFuncName);
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
export async function PaperSubViewpoint_IsExistRecord_Cache(objPaperSubViewpoint_Cond: clsPaperSubViewpointEN,strid_CurrEduCls: string) {
const strThisFuncName = "IsExistRecord_Cache";
const arrPaperSubViewpointObjLst_Cache = await PaperSubViewpoint_GetObjLst_Cache(strid_CurrEduCls);
if (arrPaperSubViewpointObjLst_Cache == null) return false;
let arrPaperSubViewpoint_Sel: Array < clsPaperSubViewpointEN > = arrPaperSubViewpointObjLst_Cache;
if (objPaperSubViewpoint_Cond.sf_FldComparisonOp == null || objPaperSubViewpoint_Cond.sf_FldComparisonOp == "") return arrPaperSubViewpoint_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objPaperSubViewpoint_Cond.sf_FldComparisonOp);
//console.log("clsPaperSubViewpointWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objPaperSubViewpoint_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objPaperSubViewpoint_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrPaperSubViewpoint_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objPaperSubViewpoint_Cond), paperSubViewpoint_ConstructorName, strThisFuncName);
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
export async function PaperSubViewpoint_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(paperSubViewpoint_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubViewpoint_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubViewpoint_ConstructorName, strThisFuncName);
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
export async function PaperSubViewpoint_IsExist(strSubViewpointId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(paperSubViewpoint_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubViewpoint_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubViewpoint_ConstructorName, strThisFuncName);
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
export async function PaperSubViewpoint_IsExist_Cache(strSubViewpointId:string,strid_CurrEduCls:string) {
const strThisFuncName = "IsExist_Cache";
const arrPaperSubViewpointObjLst_Cache = await PaperSubViewpoint_GetObjLst_Cache(strid_CurrEduCls);
if (arrPaperSubViewpointObjLst_Cache == null) return false;
try
{
const arrPaperSubViewpoint_Sel: Array <clsPaperSubViewpointEN> = arrPaperSubViewpointObjLst_Cache.filter(x => x.subViewpointId == strSubViewpointId);
if (arrPaperSubViewpoint_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strSubViewpointId, paperSubViewpoint_ConstructorName, strThisFuncName);
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
export async function PaperSubViewpoint_IsExistAsync(strSubViewpointId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(paperSubViewpoint_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubViewpoint_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubViewpoint_ConstructorName, strThisFuncName);
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
export async function PaperSubViewpoint_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(paperSubViewpoint_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubViewpoint_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubViewpoint_ConstructorName, strThisFuncName);
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
 * @param objPaperSubViewpoint_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function PaperSubViewpoint_GetRecCountByCond_Cache(objPaperSubViewpoint_Cond: clsPaperSubViewpointEN,strid_CurrEduCls: string) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrPaperSubViewpointObjLst_Cache = await PaperSubViewpoint_GetObjLst_Cache(strid_CurrEduCls);
if (arrPaperSubViewpointObjLst_Cache == null) return 0;
let arrPaperSubViewpoint_Sel: Array < clsPaperSubViewpointEN > = arrPaperSubViewpointObjLst_Cache;
if (objPaperSubViewpoint_Cond.sf_FldComparisonOp == null || objPaperSubViewpoint_Cond.sf_FldComparisonOp == "") return arrPaperSubViewpoint_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objPaperSubViewpoint_Cond.sf_FldComparisonOp);
//console.log("clsPaperSubViewpointWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objPaperSubViewpoint_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objPaperSubViewpoint_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrPaperSubViewpoint_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objPaperSubViewpoint_Cond), paperSubViewpoint_ConstructorName, strThisFuncName);
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
export async function PaperSubViewpoint_GetMaxStrIdAsync(): Promise<string>  
{
const strThisFuncName = "GetMaxStrIdAsync";
const strAction = "GetMaxStrId";
const strUrl = GetWebApiUrl(paperSubViewpoint_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubViewpoint_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubViewpoint_ConstructorName, strThisFuncName);
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
export async function PaperSubViewpoint_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(paperSubViewpoint_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubViewpoint_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubViewpoint_ConstructorName, strThisFuncName);
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
export function PaperSubViewpoint_GetWebApiUrl(strController: string, strAction: string): string {
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
export function PaperSubViewpoint_ReFreshCache(strid_CurrEduCls: string):void
{
const strThisFuncName = "ReFreshCache";

if (IsNullOrEmpty(strid_CurrEduCls) == true)
{
  const strMsg = Format("参数:[strid_CurrEduCls]不能为空！(In clsPaperSubViewpointWApi.clsPaperSubViewpointWApi.ReFreshCache)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_CurrEduCls.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(clsPaperSubViewpointWApi.clsPaperSubViewpointWApi.ReFreshCache)", strid_CurrEduCls.length);
console.error(strMsg);
throw (strMsg);
}

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = Format("{0}_{1}", clsPaperSubViewpointEN._CurrTabName, strid_CurrEduCls);
switch (clsPaperSubViewpointEN.CacheModeId)
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
vPaperSubViewpoint_ReFreshThisCache(strid_CurrEduCls);
}

 /**
 * 刷新本类中的缓存.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
 **/
export function PaperSubViewpoint_ReFreshThisCache(strid_CurrEduCls: string):void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = Format("{0}_{1}", clsPaperSubViewpointEN._CurrTabName, strid_CurrEduCls);
switch (clsPaperSubViewpointEN.CacheModeId)
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
export function PaperSubViewpoint_CheckPropertyNew(pobjPaperSubViewpointEN: clsPaperSubViewpointEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjPaperSubViewpointEN.paperRWId) === true )
{
 throw new Error("(errid:Watl000058)字段[课文阅读]不能为空(In 子观点表)!(clsPaperSubViewpointBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.paperId) === true 
 || pobjPaperSubViewpointEN.paperId.toString()  ===  "0" )
{
 throw new Error("(errid:Watl000058)字段[论文Id]不能为空(In 子观点表)!(clsPaperSubViewpointBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.id_CurrEduCls) === true 
 || pobjPaperSubViewpointEN.id_CurrEduCls.toString()  ===  "0" )
{
 throw new Error("(errid:Watl000058)字段[教学班流水号]不能为空(In 子观点表)!(clsPaperSubViewpointBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.userId) === true )
{
 throw new Error("(errid:Watl000058)字段[用户ID]不能为空(In 子观点表)!(clsPaperSubViewpointBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.subViewpointTypeId) === true 
 || pobjPaperSubViewpointEN.subViewpointTypeId.toString()  ===  "0" )
{
 throw new Error("(errid:Watl000058)字段[类型Id]不能为空(In 子观点表)!(clsPaperSubViewpointBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.shareId) === true 
 || pobjPaperSubViewpointEN.shareId.toString()  ===  "0" )
{
 throw new Error("(errid:Watl000058)字段[分享Id]不能为空(In 子观点表)!(clsPaperSubViewpointBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjPaperSubViewpointEN.subViewpointId) == false && GetStrLen(pobjPaperSubViewpointEN.subViewpointId) > 8)
{
 throw new Error("(errid:Watl000059)字段[子观点Id(subViewpointId)]的长度不能超过8(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.subViewpointId)(clsPaperSubViewpointBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.paperRWId) == false && GetStrLen(pobjPaperSubViewpointEN.paperRWId) > 8)
{
 throw new Error("(errid:Watl000059)字段[课文阅读(paperRWId)]的长度不能超过8(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.paperRWId)(clsPaperSubViewpointBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.paperId) == false && GetStrLen(pobjPaperSubViewpointEN.paperId) > 8)
{
 throw new Error("(errid:Watl000059)字段[论文Id(paperId)]的长度不能超过8(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.paperId)(clsPaperSubViewpointBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.id_CurrEduCls) == false && GetStrLen(pobjPaperSubViewpointEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.id_CurrEduCls)(clsPaperSubViewpointBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.userId) == false && GetStrLen(pobjPaperSubViewpointEN.userId) > 18)
{
 throw new Error("(errid:Watl000059)字段[用户ID(userId)]的长度不能超过18(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.userId)(clsPaperSubViewpointBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.sectionId) == false && GetStrLen(pobjPaperSubViewpointEN.sectionId) > 8)
{
 throw new Error("(errid:Watl000059)字段[节Id(sectionId)]的长度不能超过8(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.sectionId)(clsPaperSubViewpointBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.subViewpointTypeId) == false && GetStrLen(pobjPaperSubViewpointEN.subViewpointTypeId) > 8)
{
 throw new Error("(errid:Watl000059)字段[类型Id(subViewpointTypeId)]的长度不能超过8(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.subViewpointTypeId)(clsPaperSubViewpointBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.rwTitle) == false && GetStrLen(pobjPaperSubViewpointEN.rwTitle) > 50)
{
 throw new Error("(errid:Watl000059)字段[读写标题(rwTitle)]的长度不能超过50(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.rwTitle)(clsPaperSubViewpointBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.explainTypeId) == false && GetStrLen(pobjPaperSubViewpointEN.explainTypeId) > 2)
{
 throw new Error("(errid:Watl000059)字段[说明类型Id(explainTypeId)]的长度不能超过2(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.explainTypeId)(clsPaperSubViewpointBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.explainContent) == false && GetStrLen(pobjPaperSubViewpointEN.explainContent) > 5000)
{
 throw new Error("(errid:Watl000059)字段[说明内容(explainContent)]的长度不能超过5000(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.explainContent)(clsPaperSubViewpointBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.literatureSourcesId) == false && GetStrLen(pobjPaperSubViewpointEN.literatureSourcesId) > 8)
{
 throw new Error("(errid:Watl000059)字段[文献来源(literatureSourcesId)]的长度不能超过8(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.literatureSourcesId)(clsPaperSubViewpointBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.createDate) == false && GetStrLen(pobjPaperSubViewpointEN.createDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[建立日期(createDate)]的长度不能超过20(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.createDate)(clsPaperSubViewpointBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.shareId) == false && GetStrLen(pobjPaperSubViewpointEN.shareId) > 2)
{
 throw new Error("(errid:Watl000059)字段[分享Id(shareId)]的长度不能超过2(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.shareId)(clsPaperSubViewpointBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.topicId) == false && GetStrLen(pobjPaperSubViewpointEN.topicId) > 8)
{
 throw new Error("(errid:Watl000059)字段[主题Id(topicId)]的长度不能超过8(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.topicId)(clsPaperSubViewpointBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.attitudesId) == false && GetStrLen(pobjPaperSubViewpointEN.attitudesId) > 2)
{
 throw new Error("(errid:Watl000059)字段[态度Id(attitudesId)]的长度不能超过2(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.attitudesId)(clsPaperSubViewpointBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.updDate) == false && GetStrLen(pobjPaperSubViewpointEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.updDate)(clsPaperSubViewpointBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.updUser) == false && GetStrLen(pobjPaperSubViewpointEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.updUser)(clsPaperSubViewpointBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.memo) == false && GetStrLen(pobjPaperSubViewpointEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.memo)(clsPaperSubViewpointBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjPaperSubViewpointEN.subViewpointId) == false && undefined !== pobjPaperSubViewpointEN.subViewpointId && tzDataType.isString(pobjPaperSubViewpointEN.subViewpointId) === false)
{
 throw new Error("(errid:Watl000060)字段[子观点Id(subViewpointId)]的值:[$(pobjPaperSubViewpointEN.subViewpointId)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.paperRWId) == false && undefined !== pobjPaperSubViewpointEN.paperRWId && tzDataType.isString(pobjPaperSubViewpointEN.paperRWId) === false)
{
 throw new Error("(errid:Watl000060)字段[课文阅读(paperRWId)]的值:[$(pobjPaperSubViewpointEN.paperRWId)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.paperId) == false && undefined !== pobjPaperSubViewpointEN.paperId && tzDataType.isString(pobjPaperSubViewpointEN.paperId) === false)
{
 throw new Error("(errid:Watl000060)字段[论文Id(paperId)]的值:[$(pobjPaperSubViewpointEN.paperId)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.id_CurrEduCls) == false && undefined !== pobjPaperSubViewpointEN.id_CurrEduCls && tzDataType.isString(pobjPaperSubViewpointEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjPaperSubViewpointEN.id_CurrEduCls)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.userId) == false && undefined !== pobjPaperSubViewpointEN.userId && tzDataType.isString(pobjPaperSubViewpointEN.userId) === false)
{
 throw new Error("(errid:Watl000060)字段[用户ID(userId)]的值:[$(pobjPaperSubViewpointEN.userId)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.sectionId) == false && undefined !== pobjPaperSubViewpointEN.sectionId && tzDataType.isString(pobjPaperSubViewpointEN.sectionId) === false)
{
 throw new Error("(errid:Watl000060)字段[节Id(sectionId)]的值:[$(pobjPaperSubViewpointEN.sectionId)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.subViewpointTypeId) == false && undefined !== pobjPaperSubViewpointEN.subViewpointTypeId && tzDataType.isString(pobjPaperSubViewpointEN.subViewpointTypeId) === false)
{
 throw new Error("(errid:Watl000060)字段[类型Id(subViewpointTypeId)]的值:[$(pobjPaperSubViewpointEN.subViewpointTypeId)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.rwTitle) == false && undefined !== pobjPaperSubViewpointEN.rwTitle && tzDataType.isString(pobjPaperSubViewpointEN.rwTitle) === false)
{
 throw new Error("(errid:Watl000060)字段[读写标题(rwTitle)]的值:[$(pobjPaperSubViewpointEN.rwTitle)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.subViewpointContent) == false && undefined !== pobjPaperSubViewpointEN.subViewpointContent && tzDataType.isString(pobjPaperSubViewpointEN.subViewpointContent) === false)
{
 throw new Error("(errid:Watl000060)字段[详情内容(subViewpointContent)]的值:[$(pobjPaperSubViewpointEN.subViewpointContent)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.explainTypeId) == false && undefined !== pobjPaperSubViewpointEN.explainTypeId && tzDataType.isString(pobjPaperSubViewpointEN.explainTypeId) === false)
{
 throw new Error("(errid:Watl000060)字段[说明类型Id(explainTypeId)]的值:[$(pobjPaperSubViewpointEN.explainTypeId)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.explainContent) == false && undefined !== pobjPaperSubViewpointEN.explainContent && tzDataType.isString(pobjPaperSubViewpointEN.explainContent) === false)
{
 throw new Error("(errid:Watl000060)字段[说明内容(explainContent)]的值:[$(pobjPaperSubViewpointEN.explainContent)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckPropertyNew)");
}
if (null != pobjPaperSubViewpointEN.isPublic && undefined !== pobjPaperSubViewpointEN.isPublic && tzDataType.isBoolean(pobjPaperSubViewpointEN.isPublic) === false)
{
 throw new Error("(errid:Watl000060)字段[是否公开(isPublic)]的值:[$(pobjPaperSubViewpointEN.isPublic)], 非法，应该为布尔型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.literatureSourcesId) == false && undefined !== pobjPaperSubViewpointEN.literatureSourcesId && tzDataType.isString(pobjPaperSubViewpointEN.literatureSourcesId) === false)
{
 throw new Error("(errid:Watl000060)字段[文献来源(literatureSourcesId)]的值:[$(pobjPaperSubViewpointEN.literatureSourcesId)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckPropertyNew)");
}
if (null != pobjPaperSubViewpointEN.pageNumber && undefined !== pobjPaperSubViewpointEN.pageNumber && tzDataType.isNumber(pobjPaperSubViewpointEN.pageNumber) === false)
{
 throw new Error("(errid:Watl000060)字段[页码(pageNumber)]的值:[$(pobjPaperSubViewpointEN.pageNumber)], 非法，应该为数值型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckPropertyNew)");
}
if (null != pobjPaperSubViewpointEN.orderNum && undefined !== pobjPaperSubViewpointEN.orderNum && tzDataType.isNumber(pobjPaperSubViewpointEN.orderNum) === false)
{
 throw new Error("(errid:Watl000060)字段[序号(orderNum)]的值:[$(pobjPaperSubViewpointEN.orderNum)], 非法，应该为数值型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckPropertyNew)");
}
if (null != pobjPaperSubViewpointEN.paperLineNum && undefined !== pobjPaperSubViewpointEN.paperLineNum && tzDataType.isNumber(pobjPaperSubViewpointEN.paperLineNum) === false)
{
 throw new Error("(errid:Watl000060)字段[论文行号(paperLineNum)]的值:[$(pobjPaperSubViewpointEN.paperLineNum)], 非法，应该为数值型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckPropertyNew)");
}
if (null != pobjPaperSubViewpointEN.paperPageNum && undefined !== pobjPaperSubViewpointEN.paperPageNum && tzDataType.isNumber(pobjPaperSubViewpointEN.paperPageNum) === false)
{
 throw new Error("(errid:Watl000060)字段[论文页码(paperPageNum)]的值:[$(pobjPaperSubViewpointEN.paperPageNum)], 非法，应该为数值型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckPropertyNew)");
}
if (null != pobjPaperSubViewpointEN.appraiseCount && undefined !== pobjPaperSubViewpointEN.appraiseCount && tzDataType.isNumber(pobjPaperSubViewpointEN.appraiseCount) === false)
{
 throw new Error("(errid:Watl000060)字段[评论数(appraiseCount)]的值:[$(pobjPaperSubViewpointEN.appraiseCount)], 非法，应该为数值型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckPropertyNew)");
}
if (null != pobjPaperSubViewpointEN.okCount && undefined !== pobjPaperSubViewpointEN.okCount && tzDataType.isNumber(pobjPaperSubViewpointEN.okCount) === false)
{
 throw new Error("(errid:Watl000060)字段[点赞统计(okCount)]的值:[$(pobjPaperSubViewpointEN.okCount)], 非法，应该为数值型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckPropertyNew)");
}
if (null != pobjPaperSubViewpointEN.score && undefined !== pobjPaperSubViewpointEN.score && tzDataType.isNumber(pobjPaperSubViewpointEN.score) === false)
{
 throw new Error("(errid:Watl000060)字段[评分(score)]的值:[$(pobjPaperSubViewpointEN.score)], 非法，应该为数值型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckPropertyNew)");
}
if (null != pobjPaperSubViewpointEN.stuScore && undefined !== pobjPaperSubViewpointEN.stuScore && tzDataType.isNumber(pobjPaperSubViewpointEN.stuScore) === false)
{
 throw new Error("(errid:Watl000060)字段[学生平均分(stuScore)]的值:[$(pobjPaperSubViewpointEN.stuScore)], 非法，应该为数值型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckPropertyNew)");
}
if (null != pobjPaperSubViewpointEN.teaScore && undefined !== pobjPaperSubViewpointEN.teaScore && tzDataType.isNumber(pobjPaperSubViewpointEN.teaScore) === false)
{
 throw new Error("(errid:Watl000060)字段[教师评分(teaScore)]的值:[$(pobjPaperSubViewpointEN.teaScore)], 非法，应该为数值型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.createDate) == false && undefined !== pobjPaperSubViewpointEN.createDate && tzDataType.isString(pobjPaperSubViewpointEN.createDate) === false)
{
 throw new Error("(errid:Watl000060)字段[建立日期(createDate)]的值:[$(pobjPaperSubViewpointEN.createDate)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.shareId) == false && undefined !== pobjPaperSubViewpointEN.shareId && tzDataType.isString(pobjPaperSubViewpointEN.shareId) === false)
{
 throw new Error("(errid:Watl000060)字段[分享Id(shareId)]的值:[$(pobjPaperSubViewpointEN.shareId)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.topicId) == false && undefined !== pobjPaperSubViewpointEN.topicId && tzDataType.isString(pobjPaperSubViewpointEN.topicId) === false)
{
 throw new Error("(errid:Watl000060)字段[主题Id(topicId)]的值:[$(pobjPaperSubViewpointEN.topicId)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.attitudesId) == false && undefined !== pobjPaperSubViewpointEN.attitudesId && tzDataType.isString(pobjPaperSubViewpointEN.attitudesId) === false)
{
 throw new Error("(errid:Watl000060)字段[态度Id(attitudesId)]的值:[$(pobjPaperSubViewpointEN.attitudesId)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.updDate) == false && undefined !== pobjPaperSubViewpointEN.updDate && tzDataType.isString(pobjPaperSubViewpointEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjPaperSubViewpointEN.updDate)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.updUser) == false && undefined !== pobjPaperSubViewpointEN.updUser && tzDataType.isString(pobjPaperSubViewpointEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjPaperSubViewpointEN.updUser)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.memo) == false && undefined !== pobjPaperSubViewpointEN.memo && tzDataType.isString(pobjPaperSubViewpointEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjPaperSubViewpointEN.memo)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
if (IsNullOrEmpty(pobjPaperSubViewpointEN.paperRWId) == false && GetStrLen(pobjPaperSubViewpointEN.paperRWId) !=  8)
{
 throw ("(errid:Watl000061)字段[课文阅读]作为外键字段,长度应该为8(In 子观点表)!(clsPaperSubViewpointBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.subViewpointTypeId) == false && GetStrLen(pobjPaperSubViewpointEN.subViewpointTypeId) !=  8)
{
 throw ("(errid:Watl000061)字段[类型Id]作为外键字段,长度应该为8(In 子观点表)!(clsPaperSubViewpointBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.explainTypeId) == false && GetStrLen(pobjPaperSubViewpointEN.explainTypeId) !=  2)
{
 throw ("(errid:Watl000061)字段[说明类型Id]作为外键字段,长度应该为2(In 子观点表)!(clsPaperSubViewpointBL:CheckPropertyNew)");
}

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjPaperSubViewpointEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function PaperSubViewpoint_CheckProperty4Update (pobjPaperSubViewpointEN: clsPaperSubViewpointEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjPaperSubViewpointEN.subViewpointId) == false && GetStrLen(pobjPaperSubViewpointEN.subViewpointId) > 8)
{
 throw new Error("(errid:Watl000062)字段[子观点Id(subViewpointId)]的长度不能超过8(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.subViewpointId)(clsPaperSubViewpointBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.paperRWId) == false && GetStrLen(pobjPaperSubViewpointEN.paperRWId) > 8)
{
 throw new Error("(errid:Watl000062)字段[课文阅读(paperRWId)]的长度不能超过8(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.paperRWId)(clsPaperSubViewpointBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.paperId) == false && GetStrLen(pobjPaperSubViewpointEN.paperId) > 8)
{
 throw new Error("(errid:Watl000062)字段[论文Id(paperId)]的长度不能超过8(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.paperId)(clsPaperSubViewpointBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.id_CurrEduCls) == false && GetStrLen(pobjPaperSubViewpointEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.id_CurrEduCls)(clsPaperSubViewpointBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.userId) == false && GetStrLen(pobjPaperSubViewpointEN.userId) > 18)
{
 throw new Error("(errid:Watl000062)字段[用户ID(userId)]的长度不能超过18(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.userId)(clsPaperSubViewpointBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.sectionId) == false && GetStrLen(pobjPaperSubViewpointEN.sectionId) > 8)
{
 throw new Error("(errid:Watl000062)字段[节Id(sectionId)]的长度不能超过8(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.sectionId)(clsPaperSubViewpointBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.subViewpointTypeId) == false && GetStrLen(pobjPaperSubViewpointEN.subViewpointTypeId) > 8)
{
 throw new Error("(errid:Watl000062)字段[类型Id(subViewpointTypeId)]的长度不能超过8(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.subViewpointTypeId)(clsPaperSubViewpointBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.rwTitle) == false && GetStrLen(pobjPaperSubViewpointEN.rwTitle) > 50)
{
 throw new Error("(errid:Watl000062)字段[读写标题(rwTitle)]的长度不能超过50(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.rwTitle)(clsPaperSubViewpointBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.explainTypeId) == false && GetStrLen(pobjPaperSubViewpointEN.explainTypeId) > 2)
{
 throw new Error("(errid:Watl000062)字段[说明类型Id(explainTypeId)]的长度不能超过2(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.explainTypeId)(clsPaperSubViewpointBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.explainContent) == false && GetStrLen(pobjPaperSubViewpointEN.explainContent) > 5000)
{
 throw new Error("(errid:Watl000062)字段[说明内容(explainContent)]的长度不能超过5000(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.explainContent)(clsPaperSubViewpointBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.literatureSourcesId) == false && GetStrLen(pobjPaperSubViewpointEN.literatureSourcesId) > 8)
{
 throw new Error("(errid:Watl000062)字段[文献来源(literatureSourcesId)]的长度不能超过8(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.literatureSourcesId)(clsPaperSubViewpointBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.createDate) == false && GetStrLen(pobjPaperSubViewpointEN.createDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[建立日期(createDate)]的长度不能超过20(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.createDate)(clsPaperSubViewpointBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.shareId) == false && GetStrLen(pobjPaperSubViewpointEN.shareId) > 2)
{
 throw new Error("(errid:Watl000062)字段[分享Id(shareId)]的长度不能超过2(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.shareId)(clsPaperSubViewpointBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.topicId) == false && GetStrLen(pobjPaperSubViewpointEN.topicId) > 8)
{
 throw new Error("(errid:Watl000062)字段[主题Id(topicId)]的长度不能超过8(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.topicId)(clsPaperSubViewpointBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.attitudesId) == false && GetStrLen(pobjPaperSubViewpointEN.attitudesId) > 2)
{
 throw new Error("(errid:Watl000062)字段[态度Id(attitudesId)]的长度不能超过2(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.attitudesId)(clsPaperSubViewpointBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.updDate) == false && GetStrLen(pobjPaperSubViewpointEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.updDate)(clsPaperSubViewpointBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.updUser) == false && GetStrLen(pobjPaperSubViewpointEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.updUser)(clsPaperSubViewpointBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.memo) == false && GetStrLen(pobjPaperSubViewpointEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.memo)(clsPaperSubViewpointBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjPaperSubViewpointEN.subViewpointId) == false && undefined !== pobjPaperSubViewpointEN.subViewpointId && tzDataType.isString(pobjPaperSubViewpointEN.subViewpointId) === false)
{
 throw new Error("(errid:Watl000063)字段[子观点Id(subViewpointId)]的值:[$(pobjPaperSubViewpointEN.subViewpointId)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.paperRWId) == false && undefined !== pobjPaperSubViewpointEN.paperRWId && tzDataType.isString(pobjPaperSubViewpointEN.paperRWId) === false)
{
 throw new Error("(errid:Watl000063)字段[课文阅读(paperRWId)]的值:[$(pobjPaperSubViewpointEN.paperRWId)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.paperId) == false && undefined !== pobjPaperSubViewpointEN.paperId && tzDataType.isString(pobjPaperSubViewpointEN.paperId) === false)
{
 throw new Error("(errid:Watl000063)字段[论文Id(paperId)]的值:[$(pobjPaperSubViewpointEN.paperId)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.id_CurrEduCls) == false && undefined !== pobjPaperSubViewpointEN.id_CurrEduCls && tzDataType.isString(pobjPaperSubViewpointEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjPaperSubViewpointEN.id_CurrEduCls)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.userId) == false && undefined !== pobjPaperSubViewpointEN.userId && tzDataType.isString(pobjPaperSubViewpointEN.userId) === false)
{
 throw new Error("(errid:Watl000063)字段[用户ID(userId)]的值:[$(pobjPaperSubViewpointEN.userId)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.sectionId) == false && undefined !== pobjPaperSubViewpointEN.sectionId && tzDataType.isString(pobjPaperSubViewpointEN.sectionId) === false)
{
 throw new Error("(errid:Watl000063)字段[节Id(sectionId)]的值:[$(pobjPaperSubViewpointEN.sectionId)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.subViewpointTypeId) == false && undefined !== pobjPaperSubViewpointEN.subViewpointTypeId && tzDataType.isString(pobjPaperSubViewpointEN.subViewpointTypeId) === false)
{
 throw new Error("(errid:Watl000063)字段[类型Id(subViewpointTypeId)]的值:[$(pobjPaperSubViewpointEN.subViewpointTypeId)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.rwTitle) == false && undefined !== pobjPaperSubViewpointEN.rwTitle && tzDataType.isString(pobjPaperSubViewpointEN.rwTitle) === false)
{
 throw new Error("(errid:Watl000063)字段[读写标题(rwTitle)]的值:[$(pobjPaperSubViewpointEN.rwTitle)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.subViewpointContent) == false && undefined !== pobjPaperSubViewpointEN.subViewpointContent && tzDataType.isString(pobjPaperSubViewpointEN.subViewpointContent) === false)
{
 throw new Error("(errid:Watl000063)字段[详情内容(subViewpointContent)]的值:[$(pobjPaperSubViewpointEN.subViewpointContent)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.explainTypeId) == false && undefined !== pobjPaperSubViewpointEN.explainTypeId && tzDataType.isString(pobjPaperSubViewpointEN.explainTypeId) === false)
{
 throw new Error("(errid:Watl000063)字段[说明类型Id(explainTypeId)]的值:[$(pobjPaperSubViewpointEN.explainTypeId)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.explainContent) == false && undefined !== pobjPaperSubViewpointEN.explainContent && tzDataType.isString(pobjPaperSubViewpointEN.explainContent) === false)
{
 throw new Error("(errid:Watl000063)字段[说明内容(explainContent)]的值:[$(pobjPaperSubViewpointEN.explainContent)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckProperty4Update)");
}
if (null != pobjPaperSubViewpointEN.isPublic && undefined !== pobjPaperSubViewpointEN.isPublic && tzDataType.isBoolean(pobjPaperSubViewpointEN.isPublic) === false)
{
 throw new Error("(errid:Watl000063)字段[是否公开(isPublic)]的值:[$(pobjPaperSubViewpointEN.isPublic)], 非法，应该为布尔型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.literatureSourcesId) == false && undefined !== pobjPaperSubViewpointEN.literatureSourcesId && tzDataType.isString(pobjPaperSubViewpointEN.literatureSourcesId) === false)
{
 throw new Error("(errid:Watl000063)字段[文献来源(literatureSourcesId)]的值:[$(pobjPaperSubViewpointEN.literatureSourcesId)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckProperty4Update)");
}
if (null != pobjPaperSubViewpointEN.pageNumber && undefined !== pobjPaperSubViewpointEN.pageNumber && tzDataType.isNumber(pobjPaperSubViewpointEN.pageNumber) === false)
{
 throw new Error("(errid:Watl000063)字段[页码(pageNumber)]的值:[$(pobjPaperSubViewpointEN.pageNumber)], 非法，应该为数值型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckProperty4Update)");
}
if (null != pobjPaperSubViewpointEN.orderNum && undefined !== pobjPaperSubViewpointEN.orderNum && tzDataType.isNumber(pobjPaperSubViewpointEN.orderNum) === false)
{
 throw new Error("(errid:Watl000063)字段[序号(orderNum)]的值:[$(pobjPaperSubViewpointEN.orderNum)], 非法，应该为数值型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckProperty4Update)");
}
if (null != pobjPaperSubViewpointEN.paperLineNum && undefined !== pobjPaperSubViewpointEN.paperLineNum && tzDataType.isNumber(pobjPaperSubViewpointEN.paperLineNum) === false)
{
 throw new Error("(errid:Watl000063)字段[论文行号(paperLineNum)]的值:[$(pobjPaperSubViewpointEN.paperLineNum)], 非法，应该为数值型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckProperty4Update)");
}
if (null != pobjPaperSubViewpointEN.paperPageNum && undefined !== pobjPaperSubViewpointEN.paperPageNum && tzDataType.isNumber(pobjPaperSubViewpointEN.paperPageNum) === false)
{
 throw new Error("(errid:Watl000063)字段[论文页码(paperPageNum)]的值:[$(pobjPaperSubViewpointEN.paperPageNum)], 非法，应该为数值型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckProperty4Update)");
}
if (null != pobjPaperSubViewpointEN.appraiseCount && undefined !== pobjPaperSubViewpointEN.appraiseCount && tzDataType.isNumber(pobjPaperSubViewpointEN.appraiseCount) === false)
{
 throw new Error("(errid:Watl000063)字段[评论数(appraiseCount)]的值:[$(pobjPaperSubViewpointEN.appraiseCount)], 非法，应该为数值型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckProperty4Update)");
}
if (null != pobjPaperSubViewpointEN.okCount && undefined !== pobjPaperSubViewpointEN.okCount && tzDataType.isNumber(pobjPaperSubViewpointEN.okCount) === false)
{
 throw new Error("(errid:Watl000063)字段[点赞统计(okCount)]的值:[$(pobjPaperSubViewpointEN.okCount)], 非法，应该为数值型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckProperty4Update)");
}
if (null != pobjPaperSubViewpointEN.score && undefined !== pobjPaperSubViewpointEN.score && tzDataType.isNumber(pobjPaperSubViewpointEN.score) === false)
{
 throw new Error("(errid:Watl000063)字段[评分(score)]的值:[$(pobjPaperSubViewpointEN.score)], 非法，应该为数值型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckProperty4Update)");
}
if (null != pobjPaperSubViewpointEN.stuScore && undefined !== pobjPaperSubViewpointEN.stuScore && tzDataType.isNumber(pobjPaperSubViewpointEN.stuScore) === false)
{
 throw new Error("(errid:Watl000063)字段[学生平均分(stuScore)]的值:[$(pobjPaperSubViewpointEN.stuScore)], 非法，应该为数值型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckProperty4Update)");
}
if (null != pobjPaperSubViewpointEN.teaScore && undefined !== pobjPaperSubViewpointEN.teaScore && tzDataType.isNumber(pobjPaperSubViewpointEN.teaScore) === false)
{
 throw new Error("(errid:Watl000063)字段[教师评分(teaScore)]的值:[$(pobjPaperSubViewpointEN.teaScore)], 非法，应该为数值型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.createDate) == false && undefined !== pobjPaperSubViewpointEN.createDate && tzDataType.isString(pobjPaperSubViewpointEN.createDate) === false)
{
 throw new Error("(errid:Watl000063)字段[建立日期(createDate)]的值:[$(pobjPaperSubViewpointEN.createDate)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.shareId) == false && undefined !== pobjPaperSubViewpointEN.shareId && tzDataType.isString(pobjPaperSubViewpointEN.shareId) === false)
{
 throw new Error("(errid:Watl000063)字段[分享Id(shareId)]的值:[$(pobjPaperSubViewpointEN.shareId)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.topicId) == false && undefined !== pobjPaperSubViewpointEN.topicId && tzDataType.isString(pobjPaperSubViewpointEN.topicId) === false)
{
 throw new Error("(errid:Watl000063)字段[主题Id(topicId)]的值:[$(pobjPaperSubViewpointEN.topicId)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.attitudesId) == false && undefined !== pobjPaperSubViewpointEN.attitudesId && tzDataType.isString(pobjPaperSubViewpointEN.attitudesId) === false)
{
 throw new Error("(errid:Watl000063)字段[态度Id(attitudesId)]的值:[$(pobjPaperSubViewpointEN.attitudesId)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.updDate) == false && undefined !== pobjPaperSubViewpointEN.updDate && tzDataType.isString(pobjPaperSubViewpointEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjPaperSubViewpointEN.updDate)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.updUser) == false && undefined !== pobjPaperSubViewpointEN.updUser && tzDataType.isString(pobjPaperSubViewpointEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjPaperSubViewpointEN.updUser)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.memo) == false && undefined !== pobjPaperSubViewpointEN.memo && tzDataType.isString(pobjPaperSubViewpointEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjPaperSubViewpointEN.memo)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (IsNullOrEmpty(pobjPaperSubViewpointEN.subViewpointId) === true 
 || pobjPaperSubViewpointEN.subViewpointId.toString()  ===  "0" )
{
 throw new Error("(errid:Watl000064)字段[子观点Id]不能为空(In 子观点表)!(clsPaperSubViewpointBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
if (IsNullOrEmpty(pobjPaperSubViewpointEN.paperRWId) == false && GetStrLen(pobjPaperSubViewpointEN.paperRWId) !=  8)
{
 throw ("(errid:Watl000065)字段[课文阅读]作为外键字段,长度应该为8(In 子观点表)!(clsPaperSubViewpointBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.subViewpointTypeId) == false && GetStrLen(pobjPaperSubViewpointEN.subViewpointTypeId) !=  8)
{
 throw ("(errid:Watl000065)字段[类型Id]作为外键字段,长度应该为8(In 子观点表)!(clsPaperSubViewpointBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointEN.explainTypeId) == false && GetStrLen(pobjPaperSubViewpointEN.explainTypeId) !=  2)
{
 throw ("(errid:Watl000065)字段[说明类型Id]作为外键字段,长度应该为2(In 子观点表)!(clsPaperSubViewpointBL:CheckPropertyNew)");
}

 pobjPaperSubViewpointEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function PaperSubViewpoint_GetJSONStrByObj (pobjPaperSubViewpointEN: clsPaperSubViewpointEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjPaperSubViewpointEN.sfUpdFldSetStr = pobjPaperSubViewpointEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjPaperSubViewpointEN);
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
export function PaperSubViewpoint_GetObjLstByJSONStr (strJSON: string): Array<clsPaperSubViewpointEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrPaperSubViewpointObjLst = new Array<clsPaperSubViewpointEN>();
if (strJSON === "")
{
return arrPaperSubViewpointObjLst;
}
try
{
arrPaperSubViewpointObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrPaperSubViewpointObjLst;
}
return arrPaperSubViewpointObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrPaperSubViewpointObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function PaperSubViewpoint_GetObjLstByJSONObjLst (arrPaperSubViewpointObjLstS: Array<clsPaperSubViewpointEN>): Array<clsPaperSubViewpointEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrPaperSubViewpointObjLst = new Array<clsPaperSubViewpointEN>();
for (const objInFor of arrPaperSubViewpointObjLstS) {
const obj1 = PaperSubViewpoint_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrPaperSubViewpointObjLst.push(obj1);
}
return arrPaperSubViewpointObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function PaperSubViewpoint_GetObjByJSONStr (strJSON: string): clsPaperSubViewpointEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjPaperSubViewpointEN = new clsPaperSubViewpointEN();
if (strJSON === "")
{
return pobjPaperSubViewpointEN;
}
try
{
pobjPaperSubViewpointEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjPaperSubViewpointEN;
}
return pobjPaperSubViewpointEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function PaperSubViewpoint_GetCombineCondition(objPaperSubViewpoint_Cond: clsPaperSubViewpointEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objPaperSubViewpoint_Cond.dicFldComparisonOp, clsPaperSubViewpointEN.con_SubViewpointId) == true)
{
const strComparisonOp_SubViewpointId:string = objPaperSubViewpoint_Cond.dicFldComparisonOp[clsPaperSubViewpointEN.con_SubViewpointId];
strWhereCond += Format(" And {0} {2} '{1}'", clsPaperSubViewpointEN.con_SubViewpointId, objPaperSubViewpoint_Cond.subViewpointId, strComparisonOp_SubViewpointId);
}
if (Object.prototype.hasOwnProperty.call(objPaperSubViewpoint_Cond.dicFldComparisonOp, clsPaperSubViewpointEN.con_PaperRWId) == true)
{
const strComparisonOp_PaperRWId:string = objPaperSubViewpoint_Cond.dicFldComparisonOp[clsPaperSubViewpointEN.con_PaperRWId];
strWhereCond += Format(" And {0} {2} '{1}'", clsPaperSubViewpointEN.con_PaperRWId, objPaperSubViewpoint_Cond.paperRWId, strComparisonOp_PaperRWId);
}
if (Object.prototype.hasOwnProperty.call(objPaperSubViewpoint_Cond.dicFldComparisonOp, clsPaperSubViewpointEN.con_PaperId) == true)
{
const strComparisonOp_PaperId:string = objPaperSubViewpoint_Cond.dicFldComparisonOp[clsPaperSubViewpointEN.con_PaperId];
strWhereCond += Format(" And {0} {2} '{1}'", clsPaperSubViewpointEN.con_PaperId, objPaperSubViewpoint_Cond.paperId, strComparisonOp_PaperId);
}
if (Object.prototype.hasOwnProperty.call(objPaperSubViewpoint_Cond.dicFldComparisonOp, clsPaperSubViewpointEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objPaperSubViewpoint_Cond.dicFldComparisonOp[clsPaperSubViewpointEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsPaperSubViewpointEN.con_id_CurrEduCls, objPaperSubViewpoint_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (Object.prototype.hasOwnProperty.call(objPaperSubViewpoint_Cond.dicFldComparisonOp, clsPaperSubViewpointEN.con_UserId) == true)
{
const strComparisonOp_UserId:string = objPaperSubViewpoint_Cond.dicFldComparisonOp[clsPaperSubViewpointEN.con_UserId];
strWhereCond += Format(" And {0} {2} '{1}'", clsPaperSubViewpointEN.con_UserId, objPaperSubViewpoint_Cond.userId, strComparisonOp_UserId);
}
if (Object.prototype.hasOwnProperty.call(objPaperSubViewpoint_Cond.dicFldComparisonOp, clsPaperSubViewpointEN.con_SectionId) == true)
{
const strComparisonOp_SectionId:string = objPaperSubViewpoint_Cond.dicFldComparisonOp[clsPaperSubViewpointEN.con_SectionId];
strWhereCond += Format(" And {0} {2} '{1}'", clsPaperSubViewpointEN.con_SectionId, objPaperSubViewpoint_Cond.sectionId, strComparisonOp_SectionId);
}
if (Object.prototype.hasOwnProperty.call(objPaperSubViewpoint_Cond.dicFldComparisonOp, clsPaperSubViewpointEN.con_SubViewpointTypeId) == true)
{
const strComparisonOp_SubViewpointTypeId:string = objPaperSubViewpoint_Cond.dicFldComparisonOp[clsPaperSubViewpointEN.con_SubViewpointTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsPaperSubViewpointEN.con_SubViewpointTypeId, objPaperSubViewpoint_Cond.subViewpointTypeId, strComparisonOp_SubViewpointTypeId);
}
if (Object.prototype.hasOwnProperty.call(objPaperSubViewpoint_Cond.dicFldComparisonOp, clsPaperSubViewpointEN.con_RWTitle) == true)
{
const strComparisonOp_RWTitle:string = objPaperSubViewpoint_Cond.dicFldComparisonOp[clsPaperSubViewpointEN.con_RWTitle];
strWhereCond += Format(" And {0} {2} '{1}'", clsPaperSubViewpointEN.con_RWTitle, objPaperSubViewpoint_Cond.rwTitle, strComparisonOp_RWTitle);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objPaperSubViewpoint_Cond.dicFldComparisonOp, clsPaperSubViewpointEN.con_ExplainTypeId) == true)
{
const strComparisonOp_ExplainTypeId:string = objPaperSubViewpoint_Cond.dicFldComparisonOp[clsPaperSubViewpointEN.con_ExplainTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsPaperSubViewpointEN.con_ExplainTypeId, objPaperSubViewpoint_Cond.explainTypeId, strComparisonOp_ExplainTypeId);
}
if (Object.prototype.hasOwnProperty.call(objPaperSubViewpoint_Cond.dicFldComparisonOp, clsPaperSubViewpointEN.con_ExplainContent) == true)
{
const strComparisonOp_ExplainContent:string = objPaperSubViewpoint_Cond.dicFldComparisonOp[clsPaperSubViewpointEN.con_ExplainContent];
strWhereCond += Format(" And {0} {2} '{1}'", clsPaperSubViewpointEN.con_ExplainContent, objPaperSubViewpoint_Cond.explainContent, strComparisonOp_ExplainContent);
}
if (Object.prototype.hasOwnProperty.call(objPaperSubViewpoint_Cond.dicFldComparisonOp, clsPaperSubViewpointEN.con_IsPublic) == true)
{
if (objPaperSubViewpoint_Cond.isPublic == true)
{
strWhereCond += Format(" And {0} = '1'", clsPaperSubViewpointEN.con_IsPublic);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsPaperSubViewpointEN.con_IsPublic);
}
}
if (Object.prototype.hasOwnProperty.call(objPaperSubViewpoint_Cond.dicFldComparisonOp, clsPaperSubViewpointEN.con_LiteratureSourcesId) == true)
{
const strComparisonOp_LiteratureSourcesId:string = objPaperSubViewpoint_Cond.dicFldComparisonOp[clsPaperSubViewpointEN.con_LiteratureSourcesId];
strWhereCond += Format(" And {0} {2} '{1}'", clsPaperSubViewpointEN.con_LiteratureSourcesId, objPaperSubViewpoint_Cond.literatureSourcesId, strComparisonOp_LiteratureSourcesId);
}
if (Object.prototype.hasOwnProperty.call(objPaperSubViewpoint_Cond.dicFldComparisonOp, clsPaperSubViewpointEN.con_PageNumber) == true)
{
const strComparisonOp_PageNumber:string = objPaperSubViewpoint_Cond.dicFldComparisonOp[clsPaperSubViewpointEN.con_PageNumber];
strWhereCond += Format(" And {0} {2} {1}", clsPaperSubViewpointEN.con_PageNumber, objPaperSubViewpoint_Cond.pageNumber, strComparisonOp_PageNumber);
}
if (Object.prototype.hasOwnProperty.call(objPaperSubViewpoint_Cond.dicFldComparisonOp, clsPaperSubViewpointEN.con_OrderNum) == true)
{
const strComparisonOp_OrderNum:string = objPaperSubViewpoint_Cond.dicFldComparisonOp[clsPaperSubViewpointEN.con_OrderNum];
strWhereCond += Format(" And {0} {2} {1}", clsPaperSubViewpointEN.con_OrderNum, objPaperSubViewpoint_Cond.orderNum, strComparisonOp_OrderNum);
}
if (Object.prototype.hasOwnProperty.call(objPaperSubViewpoint_Cond.dicFldComparisonOp, clsPaperSubViewpointEN.con_PaperLineNum) == true)
{
const strComparisonOp_PaperLineNum:string = objPaperSubViewpoint_Cond.dicFldComparisonOp[clsPaperSubViewpointEN.con_PaperLineNum];
strWhereCond += Format(" And {0} {2} {1}", clsPaperSubViewpointEN.con_PaperLineNum, objPaperSubViewpoint_Cond.paperLineNum, strComparisonOp_PaperLineNum);
}
if (Object.prototype.hasOwnProperty.call(objPaperSubViewpoint_Cond.dicFldComparisonOp, clsPaperSubViewpointEN.con_PaperPageNum) == true)
{
const strComparisonOp_PaperPageNum:string = objPaperSubViewpoint_Cond.dicFldComparisonOp[clsPaperSubViewpointEN.con_PaperPageNum];
strWhereCond += Format(" And {0} {2} {1}", clsPaperSubViewpointEN.con_PaperPageNum, objPaperSubViewpoint_Cond.paperPageNum, strComparisonOp_PaperPageNum);
}
if (Object.prototype.hasOwnProperty.call(objPaperSubViewpoint_Cond.dicFldComparisonOp, clsPaperSubViewpointEN.con_AppraiseCount) == true)
{
const strComparisonOp_AppraiseCount:string = objPaperSubViewpoint_Cond.dicFldComparisonOp[clsPaperSubViewpointEN.con_AppraiseCount];
strWhereCond += Format(" And {0} {2} {1}", clsPaperSubViewpointEN.con_AppraiseCount, objPaperSubViewpoint_Cond.appraiseCount, strComparisonOp_AppraiseCount);
}
if (Object.prototype.hasOwnProperty.call(objPaperSubViewpoint_Cond.dicFldComparisonOp, clsPaperSubViewpointEN.con_OkCount) == true)
{
const strComparisonOp_OkCount:string = objPaperSubViewpoint_Cond.dicFldComparisonOp[clsPaperSubViewpointEN.con_OkCount];
strWhereCond += Format(" And {0} {2} {1}", clsPaperSubViewpointEN.con_OkCount, objPaperSubViewpoint_Cond.okCount, strComparisonOp_OkCount);
}
if (Object.prototype.hasOwnProperty.call(objPaperSubViewpoint_Cond.dicFldComparisonOp, clsPaperSubViewpointEN.con_Score) == true)
{
const strComparisonOp_Score:string = objPaperSubViewpoint_Cond.dicFldComparisonOp[clsPaperSubViewpointEN.con_Score];
strWhereCond += Format(" And {0} {2} {1}", clsPaperSubViewpointEN.con_Score, objPaperSubViewpoint_Cond.score, strComparisonOp_Score);
}
if (Object.prototype.hasOwnProperty.call(objPaperSubViewpoint_Cond.dicFldComparisonOp, clsPaperSubViewpointEN.con_StuScore) == true)
{
const strComparisonOp_StuScore:string = objPaperSubViewpoint_Cond.dicFldComparisonOp[clsPaperSubViewpointEN.con_StuScore];
strWhereCond += Format(" And {0} {2} {1}", clsPaperSubViewpointEN.con_StuScore, objPaperSubViewpoint_Cond.stuScore, strComparisonOp_StuScore);
}
if (Object.prototype.hasOwnProperty.call(objPaperSubViewpoint_Cond.dicFldComparisonOp, clsPaperSubViewpointEN.con_TeaScore) == true)
{
const strComparisonOp_TeaScore:string = objPaperSubViewpoint_Cond.dicFldComparisonOp[clsPaperSubViewpointEN.con_TeaScore];
strWhereCond += Format(" And {0} {2} {1}", clsPaperSubViewpointEN.con_TeaScore, objPaperSubViewpoint_Cond.teaScore, strComparisonOp_TeaScore);
}
if (Object.prototype.hasOwnProperty.call(objPaperSubViewpoint_Cond.dicFldComparisonOp, clsPaperSubViewpointEN.con_CreateDate) == true)
{
const strComparisonOp_CreateDate:string = objPaperSubViewpoint_Cond.dicFldComparisonOp[clsPaperSubViewpointEN.con_CreateDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsPaperSubViewpointEN.con_CreateDate, objPaperSubViewpoint_Cond.createDate, strComparisonOp_CreateDate);
}
if (Object.prototype.hasOwnProperty.call(objPaperSubViewpoint_Cond.dicFldComparisonOp, clsPaperSubViewpointEN.con_ShareId) == true)
{
const strComparisonOp_ShareId:string = objPaperSubViewpoint_Cond.dicFldComparisonOp[clsPaperSubViewpointEN.con_ShareId];
strWhereCond += Format(" And {0} {2} '{1}'", clsPaperSubViewpointEN.con_ShareId, objPaperSubViewpoint_Cond.shareId, strComparisonOp_ShareId);
}
if (Object.prototype.hasOwnProperty.call(objPaperSubViewpoint_Cond.dicFldComparisonOp, clsPaperSubViewpointEN.con_TopicId) == true)
{
const strComparisonOp_TopicId:string = objPaperSubViewpoint_Cond.dicFldComparisonOp[clsPaperSubViewpointEN.con_TopicId];
strWhereCond += Format(" And {0} {2} '{1}'", clsPaperSubViewpointEN.con_TopicId, objPaperSubViewpoint_Cond.topicId, strComparisonOp_TopicId);
}
if (Object.prototype.hasOwnProperty.call(objPaperSubViewpoint_Cond.dicFldComparisonOp, clsPaperSubViewpointEN.con_AttitudesId) == true)
{
const strComparisonOp_AttitudesId:string = objPaperSubViewpoint_Cond.dicFldComparisonOp[clsPaperSubViewpointEN.con_AttitudesId];
strWhereCond += Format(" And {0} {2} '{1}'", clsPaperSubViewpointEN.con_AttitudesId, objPaperSubViewpoint_Cond.attitudesId, strComparisonOp_AttitudesId);
}
if (Object.prototype.hasOwnProperty.call(objPaperSubViewpoint_Cond.dicFldComparisonOp, clsPaperSubViewpointEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objPaperSubViewpoint_Cond.dicFldComparisonOp[clsPaperSubViewpointEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsPaperSubViewpointEN.con_UpdDate, objPaperSubViewpoint_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objPaperSubViewpoint_Cond.dicFldComparisonOp, clsPaperSubViewpointEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objPaperSubViewpoint_Cond.dicFldComparisonOp[clsPaperSubViewpointEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsPaperSubViewpointEN.con_UpdUser, objPaperSubViewpoint_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objPaperSubViewpoint_Cond.dicFldComparisonOp, clsPaperSubViewpointEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objPaperSubViewpoint_Cond.dicFldComparisonOp[clsPaperSubViewpointEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsPaperSubViewpointEN.con_Memo, objPaperSubViewpoint_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--PaperSubViewpoint(子观点表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param strPaperRWId: 课文阅读(要求唯一的字段)
 * @param strSubViewpointTypeId: 类型Id(要求唯一的字段)
 * @param strSubViewpointContent: 详情内容(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function PaperSubViewpoint_GetUniCondStr_PaperRWId_SubViewpointTypeId_SubViewpointContent(objPaperSubViewpointEN: clsPaperSubViewpointEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and PaperRWId = '{0}'", objPaperSubViewpointEN.paperRWId);
 strWhereCond +=  Format(" and SubViewpointTypeId = '{0}'", objPaperSubViewpointEN.subViewpointTypeId);
 strWhereCond +=  Format(" and SubViewpointContent = '{0}'", objPaperSubViewpointEN.subViewpointContent);
 return strWhereCond;
}
 /**
 *获取唯一性条件串(Uniqueness)--PaperSubViewpoint(子观点表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param strSubViewpointId: 子观点Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function PaperSubViewpoint_GetUniCondStr_SubViewpointId(objPaperSubViewpointEN: clsPaperSubViewpointEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and SubViewpointId = '{0}'", objPaperSubViewpointEN.subViewpointId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--PaperSubViewpoint(子观点表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param strPaperRWId: 课文阅读(要求唯一的字段)
 * @param strSubViewpointTypeId: 类型Id(要求唯一的字段)
 * @param strSubViewpointContent: 详情内容(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function PaperSubViewpoint_GetUniCondStr4Update_PaperRWId_SubViewpointTypeId_SubViewpointContent(objPaperSubViewpointEN: clsPaperSubViewpointEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and SubViewpointId <> '{0}'", objPaperSubViewpointEN.subViewpointId);
 strWhereCond +=  Format(" and PaperRWId = '{0}'", objPaperSubViewpointEN.paperRWId);
 strWhereCond +=  Format(" and SubViewpointTypeId = '{0}'", objPaperSubViewpointEN.subViewpointTypeId);
 strWhereCond +=  Format(" and SubViewpointContent = '{0}'", objPaperSubViewpointEN.subViewpointContent);
 return strWhereCond;
}
 /**
 *获取唯一性条件串(Uniqueness)--PaperSubViewpoint(子观点表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param strSubViewpointId: 子观点Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function PaperSubViewpoint_GetUniCondStr4Update_SubViewpointId(objPaperSubViewpointEN: clsPaperSubViewpointEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and SubViewpointId <> '{0}'", objPaperSubViewpointEN.subViewpointId);
 strWhereCond +=  Format(" and SubViewpointId = '{0}'", objPaperSubViewpointEN.subViewpointId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objPaperSubViewpointENS:源对象
 * @param objPaperSubViewpointENT:目标对象
*/
export function PaperSubViewpoint_CopyObjTo(objPaperSubViewpointENS: clsPaperSubViewpointEN , objPaperSubViewpointENT: clsPaperSubViewpointEN ): void 
{
objPaperSubViewpointENT.subViewpointId = objPaperSubViewpointENS.subViewpointId; //子观点Id
objPaperSubViewpointENT.paperRWId = objPaperSubViewpointENS.paperRWId; //课文阅读
objPaperSubViewpointENT.paperId = objPaperSubViewpointENS.paperId; //论文Id
objPaperSubViewpointENT.id_CurrEduCls = objPaperSubViewpointENS.id_CurrEduCls; //教学班流水号
objPaperSubViewpointENT.userId = objPaperSubViewpointENS.userId; //用户ID
objPaperSubViewpointENT.sectionId = objPaperSubViewpointENS.sectionId; //节Id
objPaperSubViewpointENT.subViewpointTypeId = objPaperSubViewpointENS.subViewpointTypeId; //类型Id
objPaperSubViewpointENT.rwTitle = objPaperSubViewpointENS.rwTitle; //读写标题
objPaperSubViewpointENT.subViewpointContent = objPaperSubViewpointENS.subViewpointContent; //详情内容
objPaperSubViewpointENT.explainTypeId = objPaperSubViewpointENS.explainTypeId; //说明类型Id
objPaperSubViewpointENT.explainContent = objPaperSubViewpointENS.explainContent; //说明内容
objPaperSubViewpointENT.isPublic = objPaperSubViewpointENS.isPublic; //是否公开
objPaperSubViewpointENT.literatureSourcesId = objPaperSubViewpointENS.literatureSourcesId; //文献来源
objPaperSubViewpointENT.pageNumber = objPaperSubViewpointENS.pageNumber; //页码
objPaperSubViewpointENT.orderNum = objPaperSubViewpointENS.orderNum; //序号
objPaperSubViewpointENT.paperLineNum = objPaperSubViewpointENS.paperLineNum; //论文行号
objPaperSubViewpointENT.paperPageNum = objPaperSubViewpointENS.paperPageNum; //论文页码
objPaperSubViewpointENT.appraiseCount = objPaperSubViewpointENS.appraiseCount; //评论数
objPaperSubViewpointENT.okCount = objPaperSubViewpointENS.okCount; //点赞统计
objPaperSubViewpointENT.score = objPaperSubViewpointENS.score; //评分
objPaperSubViewpointENT.stuScore = objPaperSubViewpointENS.stuScore; //学生平均分
objPaperSubViewpointENT.teaScore = objPaperSubViewpointENS.teaScore; //教师评分
objPaperSubViewpointENT.createDate = objPaperSubViewpointENS.createDate; //建立日期
objPaperSubViewpointENT.shareId = objPaperSubViewpointENS.shareId; //分享Id
objPaperSubViewpointENT.topicId = objPaperSubViewpointENS.topicId; //主题Id
objPaperSubViewpointENT.attitudesId = objPaperSubViewpointENS.attitudesId; //态度Id
objPaperSubViewpointENT.updDate = objPaperSubViewpointENS.updDate; //修改日期
objPaperSubViewpointENT.updUser = objPaperSubViewpointENS.updUser; //修改人
objPaperSubViewpointENT.memo = objPaperSubViewpointENS.memo; //备注
objPaperSubViewpointENT.sfUpdFldSetStr = objPaperSubViewpointENS.updFldString; //sfUpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objPaperSubViewpointENS:源对象
 * @param objPaperSubViewpointENT:目标对象
*/
export function PaperSubViewpoint_GetObjFromJsonObj(objPaperSubViewpointENS: clsPaperSubViewpointEN): clsPaperSubViewpointEN 
{
 const objPaperSubViewpointENT: clsPaperSubViewpointEN = new clsPaperSubViewpointEN();
ObjectAssign(objPaperSubViewpointENT, objPaperSubViewpointENS);
 return objPaperSubViewpointENT;
}