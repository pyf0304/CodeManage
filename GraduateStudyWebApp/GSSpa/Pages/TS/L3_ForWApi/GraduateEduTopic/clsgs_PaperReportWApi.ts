
 /**
 * 类名:clsgs_PaperReportWApi
 * 表名:gs_PaperReport(01120772)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:47:05
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
 * 论文汇报表(gs_PaperReport)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clsgs_PaperReportEN } from "../../L0_Entity/GraduateEduTopic/clsgs_PaperReportEN.js";
import { vgs_PaperReport_ReFreshThisCache } from "../../L3_ForWApi/GraduateEduTopic/clsvgs_PaperReportWApi.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { tzDataType } from "../../PubFun/jsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const gs_PaperReport_Controller = "gs_PaperReportApi";
 export const gs_PaperReport_ConstructorName = "gs_PaperReport";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strReportId:关键字
 * @returns 对象
 **/
export async function gs_PaperReport_GetObjByReportIdAsync(strReportId: string): Promise<clsgs_PaperReportEN>  
{
const strThisFuncName = "GetObjByReportIdAsync";

if (IsNullOrEmpty(strReportId) == true)
{
  const strMsg = Format("参数:[strReportId]不能为空！(In GetObjByReportIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strReportId.length != 10)
{
const strMsg = Format("缓存分类变量:[strReportId]的长度:[{0}]不正确！", strReportId.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByReportId";
const strUrl = GetWebApiUrl(gs_PaperReport_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strReportId": strReportId,
}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObj = data.returnObj;
if (returnObj == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_PaperReport_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objgs_PaperReport = gs_PaperReport_GetObjFromJsonObj(returnObj);
return objgs_PaperReport;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperReport_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperReport_ConstructorName, strThisFuncName);
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
 * @param strReportId:所给的关键字
 * @returns 对象
*/
export async function gs_PaperReport_GetObjByReportId_Cache(strReportId: string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByReportId_Cache";

if (IsNullOrEmpty(strReportId) == true)
{
  const strMsg = Format("参数:[strReportId]不能为空！(In GetObjByReportId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strReportId.length != 10)
{
const strMsg = Format("缓存分类变量:[strReportId]的长度:[{0}]不正确！", strReportId.length);
console.error(strMsg);
throw (strMsg);
}
const arrgs_PaperReportObjLst_Cache = await gs_PaperReport_GetObjLst_Cache();
try
{
const arrgs_PaperReport_Sel: Array <clsgs_PaperReportEN> = arrgs_PaperReportObjLst_Cache.filter(x => x.reportId == strReportId);
let objgs_PaperReport: clsgs_PaperReportEN;
if (arrgs_PaperReport_Sel.length > 0)
{
objgs_PaperReport = arrgs_PaperReport_Sel[0];
return objgs_PaperReport;
}
else
{
if (bolTryAsyncOnce == true)
{
objgs_PaperReport = await gs_PaperReport_GetObjByReportIdAsync(strReportId);
if (objgs_PaperReport != null)
{
gs_PaperReport_ReFreshThisCache();
return objgs_PaperReport;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strReportId, gs_PaperReport_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param strReportId:所给的关键字
 * @returns 对象
*/
export async function gs_PaperReport_GetObjByReportId_localStorage(strReportId: string) {
const strThisFuncName = "GetObjByReportId_localStorage";

if (IsNullOrEmpty(strReportId) == true)
{
  const strMsg = Format("参数:[strReportId]不能为空！(In GetObjByReportId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
if (strReportId.length != 10)
{
const strMsg = Format("缓存分类变量:[strReportId]的长度:[{0}]不正确！", strReportId.length);
console.error(strMsg);
throw (strMsg);
}
const strKey = Format("{0}_{1}", clsgs_PaperReportEN._CurrTabName, strReportId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objgs_PaperReport_Cache: clsgs_PaperReportEN = JSON.parse(strTempObj);
return objgs_PaperReport_Cache;
}
try
{
const objgs_PaperReport = await gs_PaperReport_GetObjByReportIdAsync(strReportId);
if (objgs_PaperReport != null)
{
localStorage.setItem(strKey, JSON.stringify(objgs_PaperReport));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objgs_PaperReport;
}
return objgs_PaperReport;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strReportId, gs_PaperReport_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objgs_PaperReport:所给的对象
 * @returns 对象
*/
export async function gs_PaperReport_UpdateObjInLst_Cache(objgs_PaperReport: clsgs_PaperReportEN) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrgs_PaperReportObjLst_Cache = await gs_PaperReport_GetObjLst_Cache();
const obj = arrgs_PaperReportObjLst_Cache.find(x => x.topicId == objgs_PaperReport.topicId && x.reportUser == objgs_PaperReport.reportUser && x.reportDate == objgs_PaperReport.reportDate);
if (obj != null)
{
objgs_PaperReport.reportId = obj.reportId;
ObjectAssign( obj, objgs_PaperReport);
}
else
{
arrgs_PaperReportObjLst_Cache.push(objgs_PaperReport);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, gs_PaperReport_ConstructorName, strThisFuncName);
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
 * @returns 返回一个输出字段值
*/
export async function gs_PaperReport_func(strInFldName:string , strOutFldName:string ,  strInValue: string) 
{
//const strThisFuncName = "func";

if (strInFldName != clsgs_PaperReportEN.con_ReportId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsgs_PaperReportEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clsgs_PaperReportEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strReportId = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objgs_PaperReport = await gs_PaperReport_GetObjByReportId_Cache(strReportId );
if (objgs_PaperReport == null) return "";
return objgs_PaperReport.GetFldValue(strOutFldName).toString();
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
export function gs_PaperReport_SortFun_Defa(a:clsgs_PaperReportEN , b:clsgs_PaperReportEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.reportId.localeCompare(b.reportId);
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
export function gs_PaperReport_SortFun_Defa_2Fld(a:clsgs_PaperReportEN , b:clsgs_PaperReportEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.topicId == b.topicId) return a.paperId.localeCompare(b.paperId);
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
export function gs_PaperReport_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsgs_PaperReportEN.con_ReportId:
return (a: clsgs_PaperReportEN, b: clsgs_PaperReportEN) => {
return a.reportId.localeCompare(b.reportId);
}
case clsgs_PaperReportEN.con_TopicId:
return (a: clsgs_PaperReportEN, b: clsgs_PaperReportEN) => {
return a.topicId.localeCompare(b.topicId);
}
case clsgs_PaperReportEN.con_PaperId:
return (a: clsgs_PaperReportEN, b: clsgs_PaperReportEN) => {
return a.paperId.localeCompare(b.paperId);
}
case clsgs_PaperReportEN.con_ReportContent:
return (a: clsgs_PaperReportEN, b: clsgs_PaperReportEN) => {
return a.reportContent.localeCompare(b.reportContent);
}
case clsgs_PaperReportEN.con_IsSubmit:
return (a: clsgs_PaperReportEN, b: clsgs_PaperReportEN) => {
if (a.isSubmit == true) return 1;
else return -1
}
case clsgs_PaperReportEN.con_ReportUser:
return (a: clsgs_PaperReportEN, b: clsgs_PaperReportEN) => {
return a.reportUser.localeCompare(b.reportUser);
}
case clsgs_PaperReportEN.con_ReportDate:
return (a: clsgs_PaperReportEN, b: clsgs_PaperReportEN) => {
return a.reportDate.localeCompare(b.reportDate);
}
case clsgs_PaperReportEN.con_VersionCount:
return (a: clsgs_PaperReportEN, b: clsgs_PaperReportEN) => {
return a.versionCount-b.versionCount;
}
case clsgs_PaperReportEN.con_OkCount:
return (a: clsgs_PaperReportEN, b: clsgs_PaperReportEN) => {
return a.okCount-b.okCount;
}
case clsgs_PaperReportEN.con_AppraiseCount:
return (a: clsgs_PaperReportEN, b: clsgs_PaperReportEN) => {
return a.appraiseCount-b.appraiseCount;
}
case clsgs_PaperReportEN.con_score:
return (a: clsgs_PaperReportEN, b: clsgs_PaperReportEN) => {
return a.score-b.score;
}
case clsgs_PaperReportEN.con_StuScore:
return (a: clsgs_PaperReportEN, b: clsgs_PaperReportEN) => {
return a.stuScore-b.stuScore;
}
case clsgs_PaperReportEN.con_TeaScore:
return (a: clsgs_PaperReportEN, b: clsgs_PaperReportEN) => {
return a.teaScore-b.teaScore;
}
case clsgs_PaperReportEN.con_PDFUrl:
return (a: clsgs_PaperReportEN, b: clsgs_PaperReportEN) => {
return a.pdFUrl.localeCompare(b.pdFUrl);
}
case clsgs_PaperReportEN.con_PPTUrl:
return (a: clsgs_PaperReportEN, b: clsgs_PaperReportEN) => {
return a.ppTUrl.localeCompare(b.ppTUrl);
}
case clsgs_PaperReportEN.con_Month:
return (a: clsgs_PaperReportEN, b: clsgs_PaperReportEN) => {
return a.month.localeCompare(b.month);
}
case clsgs_PaperReportEN.con_Week:
return (a: clsgs_PaperReportEN, b: clsgs_PaperReportEN) => {
return a.week-b.week;
}
case clsgs_PaperReportEN.con_Year:
return (a: clsgs_PaperReportEN, b: clsgs_PaperReportEN) => {
return a.year.localeCompare(b.year);
}
case clsgs_PaperReportEN.con_id_CurrEduCls:
return (a: clsgs_PaperReportEN, b: clsgs_PaperReportEN) => {
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
case clsgs_PaperReportEN.con_UpdUser:
return (a: clsgs_PaperReportEN, b: clsgs_PaperReportEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsgs_PaperReportEN.con_UpdDate:
return (a: clsgs_PaperReportEN, b: clsgs_PaperReportEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsgs_PaperReportEN.con_Memo:
return (a: clsgs_PaperReportEN, b: clsgs_PaperReportEN) => {
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_PaperReport]中不存在！(in ${ gs_PaperReport_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsgs_PaperReportEN.con_ReportId:
return (a: clsgs_PaperReportEN, b: clsgs_PaperReportEN) => {
return b.reportId.localeCompare(a.reportId);
}
case clsgs_PaperReportEN.con_TopicId:
return (a: clsgs_PaperReportEN, b: clsgs_PaperReportEN) => {
return b.topicId.localeCompare(a.topicId);
}
case clsgs_PaperReportEN.con_PaperId:
return (a: clsgs_PaperReportEN, b: clsgs_PaperReportEN) => {
return b.paperId.localeCompare(a.paperId);
}
case clsgs_PaperReportEN.con_ReportContent:
return (a: clsgs_PaperReportEN, b: clsgs_PaperReportEN) => {
return b.reportContent.localeCompare(a.reportContent);
}
case clsgs_PaperReportEN.con_IsSubmit:
return (a: clsgs_PaperReportEN, b: clsgs_PaperReportEN) => {
if (b.isSubmit == true) return 1;
else return -1
}
case clsgs_PaperReportEN.con_ReportUser:
return (a: clsgs_PaperReportEN, b: clsgs_PaperReportEN) => {
return b.reportUser.localeCompare(a.reportUser);
}
case clsgs_PaperReportEN.con_ReportDate:
return (a: clsgs_PaperReportEN, b: clsgs_PaperReportEN) => {
return b.reportDate.localeCompare(a.reportDate);
}
case clsgs_PaperReportEN.con_VersionCount:
return (a: clsgs_PaperReportEN, b: clsgs_PaperReportEN) => {
return b.versionCount-a.versionCount;
}
case clsgs_PaperReportEN.con_OkCount:
return (a: clsgs_PaperReportEN, b: clsgs_PaperReportEN) => {
return b.okCount-a.okCount;
}
case clsgs_PaperReportEN.con_AppraiseCount:
return (a: clsgs_PaperReportEN, b: clsgs_PaperReportEN) => {
return b.appraiseCount-a.appraiseCount;
}
case clsgs_PaperReportEN.con_score:
return (a: clsgs_PaperReportEN, b: clsgs_PaperReportEN) => {
return b.score-a.score;
}
case clsgs_PaperReportEN.con_StuScore:
return (a: clsgs_PaperReportEN, b: clsgs_PaperReportEN) => {
return b.stuScore-a.stuScore;
}
case clsgs_PaperReportEN.con_TeaScore:
return (a: clsgs_PaperReportEN, b: clsgs_PaperReportEN) => {
return b.teaScore-a.teaScore;
}
case clsgs_PaperReportEN.con_PDFUrl:
return (a: clsgs_PaperReportEN, b: clsgs_PaperReportEN) => {
return b.pdFUrl.localeCompare(a.pdFUrl);
}
case clsgs_PaperReportEN.con_PPTUrl:
return (a: clsgs_PaperReportEN, b: clsgs_PaperReportEN) => {
return b.ppTUrl.localeCompare(a.ppTUrl);
}
case clsgs_PaperReportEN.con_Month:
return (a: clsgs_PaperReportEN, b: clsgs_PaperReportEN) => {
return b.month.localeCompare(a.month);
}
case clsgs_PaperReportEN.con_Week:
return (a: clsgs_PaperReportEN, b: clsgs_PaperReportEN) => {
return b.week-a.week;
}
case clsgs_PaperReportEN.con_Year:
return (a: clsgs_PaperReportEN, b: clsgs_PaperReportEN) => {
return b.year.localeCompare(a.year);
}
case clsgs_PaperReportEN.con_id_CurrEduCls:
return (a: clsgs_PaperReportEN, b: clsgs_PaperReportEN) => {
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
case clsgs_PaperReportEN.con_UpdUser:
return (a: clsgs_PaperReportEN, b: clsgs_PaperReportEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsgs_PaperReportEN.con_UpdDate:
return (a: clsgs_PaperReportEN, b: clsgs_PaperReportEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsgs_PaperReportEN.con_Memo:
return (a: clsgs_PaperReportEN, b: clsgs_PaperReportEN) => {
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_PaperReport]中不存在！(in ${ gs_PaperReport_ConstructorName}.${ strThisFuncName})`;
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
export async function gs_PaperReport_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsgs_PaperReportEN.con_ReportId:
return (obj: clsgs_PaperReportEN) => {
return obj.reportId === value;
}
case clsgs_PaperReportEN.con_TopicId:
return (obj: clsgs_PaperReportEN) => {
return obj.topicId === value;
}
case clsgs_PaperReportEN.con_PaperId:
return (obj: clsgs_PaperReportEN) => {
return obj.paperId === value;
}
case clsgs_PaperReportEN.con_ReportContent:
return (obj: clsgs_PaperReportEN) => {
return obj.reportContent === value;
}
case clsgs_PaperReportEN.con_IsSubmit:
return (obj: clsgs_PaperReportEN) => {
return obj.isSubmit === value;
}
case clsgs_PaperReportEN.con_ReportUser:
return (obj: clsgs_PaperReportEN) => {
return obj.reportUser === value;
}
case clsgs_PaperReportEN.con_ReportDate:
return (obj: clsgs_PaperReportEN) => {
return obj.reportDate === value;
}
case clsgs_PaperReportEN.con_VersionCount:
return (obj: clsgs_PaperReportEN) => {
return obj.versionCount === value;
}
case clsgs_PaperReportEN.con_OkCount:
return (obj: clsgs_PaperReportEN) => {
return obj.okCount === value;
}
case clsgs_PaperReportEN.con_AppraiseCount:
return (obj: clsgs_PaperReportEN) => {
return obj.appraiseCount === value;
}
case clsgs_PaperReportEN.con_score:
return (obj: clsgs_PaperReportEN) => {
return obj.score === value;
}
case clsgs_PaperReportEN.con_StuScore:
return (obj: clsgs_PaperReportEN) => {
return obj.stuScore === value;
}
case clsgs_PaperReportEN.con_TeaScore:
return (obj: clsgs_PaperReportEN) => {
return obj.teaScore === value;
}
case clsgs_PaperReportEN.con_PDFUrl:
return (obj: clsgs_PaperReportEN) => {
return obj.pdFUrl === value;
}
case clsgs_PaperReportEN.con_PPTUrl:
return (obj: clsgs_PaperReportEN) => {
return obj.ppTUrl === value;
}
case clsgs_PaperReportEN.con_Month:
return (obj: clsgs_PaperReportEN) => {
return obj.month === value;
}
case clsgs_PaperReportEN.con_Week:
return (obj: clsgs_PaperReportEN) => {
return obj.week === value;
}
case clsgs_PaperReportEN.con_Year:
return (obj: clsgs_PaperReportEN) => {
return obj.year === value;
}
case clsgs_PaperReportEN.con_id_CurrEduCls:
return (obj: clsgs_PaperReportEN) => {
return obj.id_CurrEduCls === value;
}
case clsgs_PaperReportEN.con_UpdUser:
return (obj: clsgs_PaperReportEN) => {
return obj.updUser === value;
}
case clsgs_PaperReportEN.con_UpdDate:
return (obj: clsgs_PaperReportEN) => {
return obj.updDate === value;
}
case clsgs_PaperReportEN.con_Memo:
return (obj: clsgs_PaperReportEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_PaperReport]中不存在！(in ${ gs_PaperReport_ConstructorName}.${ strThisFuncName})`;
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
export async function gs_PaperReport_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(gs_PaperReport_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperReport_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperReport_ConstructorName, strThisFuncName);
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
export async function gs_PaperReport_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(gs_PaperReport_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperReport_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperReport_ConstructorName, strThisFuncName);
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
export async function gs_PaperReport_GetFirstObjAsync(strWhereCond: string): Promise<clsgs_PaperReportEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(gs_PaperReport_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_PaperReport_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objgs_PaperReport = gs_PaperReport_GetObjFromJsonObj(returnObj);
return objgs_PaperReport;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperReport_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperReport_ConstructorName, strThisFuncName);
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
export async function gs_PaperReport_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsgs_PaperReportEN._CurrTabName;
clsgs_PaperReportEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsgs_PaperReportEN._CurrTabName);
if (IsNullOrEmpty(clsgs_PaperReportEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsgs_PaperReportEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrgs_PaperReportExObjLst_Cache: Array<clsgs_PaperReportEN> = CacheHelper.Get(strKey);
const arrgs_PaperReportObjLst_T = gs_PaperReport_GetObjLstByJSONObjLst(arrgs_PaperReportExObjLst_Cache);
return arrgs_PaperReportObjLst_T;
}
try
{
const arrgs_PaperReportExObjLst = await gs_PaperReport_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrgs_PaperReportExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_PaperReportExObjLst.length);
console.log(strInfo);
return arrgs_PaperReportExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, gs_PaperReport_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_PaperReport_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsgs_PaperReportEN._CurrTabName;
clsgs_PaperReportEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsgs_PaperReportEN._CurrTabName);
if (IsNullOrEmpty(clsgs_PaperReportEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsgs_PaperReportEN.CacheAddiCondition);
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
const arrgs_PaperReportExObjLst_Cache: Array<clsgs_PaperReportEN> = JSON.parse(strTempObjLst);
const arrgs_PaperReportObjLst_T = gs_PaperReport_GetObjLstByJSONObjLst(arrgs_PaperReportExObjLst_Cache);
return arrgs_PaperReportObjLst_T;
}
try
{
const arrgs_PaperReportExObjLst = await gs_PaperReport_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrgs_PaperReportExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_PaperReportExObjLst.length);
console.log(strInfo);
return arrgs_PaperReportExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, gs_PaperReport_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_PaperReport_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsgs_PaperReportEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrgs_PaperReportObjLst_Cache: Array<clsgs_PaperReportEN> = JSON.parse(strTempObjLst);
return arrgs_PaperReportObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function gs_PaperReport_GetObjLstAsync(strWhereCond: string): Promise<Array<clsgs_PaperReportEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(gs_PaperReport_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_PaperReport_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_PaperReport_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperReport_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperReport_ConstructorName, strThisFuncName);
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
export async function gs_PaperReport_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsgs_PaperReportEN._CurrTabName;
clsgs_PaperReportEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsgs_PaperReportEN._CurrTabName);
if (IsNullOrEmpty(clsgs_PaperReportEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsgs_PaperReportEN.CacheAddiCondition);
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
const arrgs_PaperReportExObjLst_Cache: Array<clsgs_PaperReportEN> = JSON.parse(strTempObjLst);
const arrgs_PaperReportObjLst_T = gs_PaperReport_GetObjLstByJSONObjLst(arrgs_PaperReportExObjLst_Cache);
return arrgs_PaperReportObjLst_T;
}
try
{
const arrgs_PaperReportExObjLst = await gs_PaperReport_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrgs_PaperReportExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_PaperReportExObjLst.length);
console.log(strInfo);
return arrgs_PaperReportExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, gs_PaperReport_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_PaperReport_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsgs_PaperReportEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrgs_PaperReportObjLst_Cache: Array<clsgs_PaperReportEN> = JSON.parse(strTempObjLst);
return arrgs_PaperReportObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_PaperReport_GetObjLst_Cache(): Promise<Array<clsgs_PaperReportEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrgs_PaperReportObjLst_Cache;
switch (clsgs_PaperReportEN.CacheModeId)
{
case "04"://sessionStorage
arrgs_PaperReportObjLst_Cache = await gs_PaperReport_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrgs_PaperReportObjLst_Cache = await gs_PaperReport_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrgs_PaperReportObjLst_Cache = await gs_PaperReport_GetObjLst_ClientCache();
break;
default:
arrgs_PaperReportObjLst_Cache = await gs_PaperReport_GetObjLst_ClientCache();
break;
}
const arrgs_PaperReportObjLst = gs_PaperReport_GetObjLstByJSONObjLst(arrgs_PaperReportObjLst_Cache);
return arrgs_PaperReportObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_PaperReport_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrgs_PaperReportObjLst_Cache;
switch (clsgs_PaperReportEN.CacheModeId)
{
case "04"://sessionStorage
arrgs_PaperReportObjLst_Cache = await gs_PaperReport_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrgs_PaperReportObjLst_Cache = await gs_PaperReport_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrgs_PaperReportObjLst_Cache = null;
break;
default:
arrgs_PaperReportObjLst_Cache = null;
break;
}
return arrgs_PaperReportObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrReportId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function gs_PaperReport_GetSubObjLst_Cache(objgs_PaperReport_Cond: clsgs_PaperReportEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrgs_PaperReportObjLst_Cache = await gs_PaperReport_GetObjLst_Cache();
let arrgs_PaperReport_Sel: Array < clsgs_PaperReportEN > = arrgs_PaperReportObjLst_Cache;
if (objgs_PaperReport_Cond.sf_FldComparisonOp == null || objgs_PaperReport_Cond.sf_FldComparisonOp == "") return arrgs_PaperReport_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_PaperReport_Cond.sf_FldComparisonOp);
//console.log("clsgs_PaperReportWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objgs_PaperReport_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrgs_PaperReport_Sel = arrgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_PaperReport_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_PaperReport_Sel = arrgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_PaperReport_Sel = arrgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_PaperReport_Sel = arrgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_PaperReport_Sel = arrgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_PaperReport_Sel = arrgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_PaperReport_Sel = arrgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_PaperReport_Sel = arrgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_PaperReport_Sel = arrgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrgs_PaperReport_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objgs_PaperReport_Cond), gs_PaperReport_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsgs_PaperReportEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrReportId:关键字列表
 * @returns 对象列表
 **/
export async function gs_PaperReport_GetObjLstByReportIdLstAsync(arrReportId: Array<string>): Promise<Array<clsgs_PaperReportEN>>  
{
const strThisFuncName = "GetObjLstByReportIdLstAsync";
const strAction = "GetObjLstByReportIdLst";
const strUrl = GetWebApiUrl(gs_PaperReport_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrReportId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_PaperReport_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_PaperReport_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperReport_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperReport_ConstructorName, strThisFuncName);
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
 * @param arrstrReportIdLst:关键字列表
 * @returns 对象列表
*/
export async function gs_PaperReport_GetObjLstByReportIdLst_Cache(arrReportIdLst: Array<string>) {
const strThisFuncName = "GetObjLstByReportIdLst_Cache";
try
{
const arrgs_PaperReportObjLst_Cache = await gs_PaperReport_GetObjLst_Cache();
const arrgs_PaperReport_Sel: Array <clsgs_PaperReportEN> = arrgs_PaperReportObjLst_Cache.filter(x => arrReportIdLst.indexOf(x.reportId)>-1);
return arrgs_PaperReport_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrReportIdLst.join(","), gs_PaperReport_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsgs_PaperReportEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function gs_PaperReport_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsgs_PaperReportEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(gs_PaperReport_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_PaperReport_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_PaperReport_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperReport_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperReport_ConstructorName, strThisFuncName);
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
export async function gs_PaperReport_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsgs_PaperReportEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(gs_PaperReport_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_PaperReport_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_PaperReport_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperReport_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperReport_ConstructorName, strThisFuncName);
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
export async function gs_PaperReport_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(gs_PaperReport_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperReport_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperReport_ConstructorName, strThisFuncName);
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
export async function gs_PaperReport_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrgs_PaperReportObjLst_Cache = await gs_PaperReport_GetObjLst_Cache();
if (arrgs_PaperReportObjLst_Cache.length == 0) return arrgs_PaperReportObjLst_Cache;
let arrgs_PaperReport_Sel = arrgs_PaperReportObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objgs_PaperReport_Cond = new clsgs_PaperReportEN();
ObjectAssign(objgs_PaperReport_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsgs_PaperReportWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrgs_PaperReport_Sel = arrgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_PaperReport_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_PaperReport_Sel = arrgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_PaperReport_Sel = arrgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrgs_PaperReport_Sel = arrgs_PaperReport_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_PaperReport_Sel = arrgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_PaperReport_Sel = arrgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_PaperReport_Sel = arrgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_PaperReport_Sel = arrgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_PaperReport_Sel = arrgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_PaperReport_Sel = arrgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrgs_PaperReport_Sel.length == 0) return arrgs_PaperReport_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrgs_PaperReport_Sel = arrgs_PaperReport_Sel.sort(gs_PaperReport_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrgs_PaperReport_Sel = arrgs_PaperReport_Sel.sort(objPagerPara.sortFun);
}
arrgs_PaperReport_Sel = arrgs_PaperReport_Sel.slice(intStart, intEnd);     
return arrgs_PaperReport_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, gs_PaperReport_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsgs_PaperReportEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function gs_PaperReport_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsgs_PaperReportEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(gs_PaperReport_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_PaperReport_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_PaperReport_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperReport_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperReport_ConstructorName, strThisFuncName);
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
 * @param strReportId:关键字
 * @returns 获取删除的结果
 **/
export async function gs_PaperReport_DelRecordAsync(strReportId: string): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(gs_PaperReport_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, strReportId);
try
{
const response = await axios.delete(strUrl,
{
params: { "Id": strReportId, }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperReport_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperReport_ConstructorName, strThisFuncName);
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
 * @param arrReportId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function gs_PaperReport_Delgs_PaperReportsAsync(arrReportId: Array<string>): Promise<number> 
{
const strThisFuncName = "Delgs_PaperReportsAsync";
const strAction = "Delgs_PaperReports";
const strUrl = GetWebApiUrl(gs_PaperReport_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrReportId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperReport_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperReport_ConstructorName, strThisFuncName);
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
export async function gs_PaperReport_Delgs_PaperReportsByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "Delgs_PaperReportsByCondAsync";
const strAction = "Delgs_PaperReportsByCond";
const strUrl = GetWebApiUrl(gs_PaperReport_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperReport_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperReport_ConstructorName, strThisFuncName);
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
 * @param objgs_PaperReportEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_PaperReport_AddNewRecordAsync(objgs_PaperReportEN: clsgs_PaperReportEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objgs_PaperReportEN);
const strUrl = GetWebApiUrl(gs_PaperReport_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_PaperReportEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperReport_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperReport_ConstructorName, strThisFuncName);
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
 * @param objgs_PaperReportEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_PaperReport_AddNewRecordWithMaxIdAsync(objgs_PaperReportEN: clsgs_PaperReportEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithMaxIdAsync";
const strAction = "AddNewRecordWithMaxId";
const strUrl = GetWebApiUrl(gs_PaperReport_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_PaperReportEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperReport_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperReport_ConstructorName, strThisFuncName);
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
 * @param objgs_PaperReportEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function gs_PaperReport_AddNewRecordWithReturnKeyAsync(objgs_PaperReportEN: clsgs_PaperReportEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(gs_PaperReport_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_PaperReportEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperReport_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperReport_ConstructorName, strThisFuncName);
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
 * @param objgs_PaperReportEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function gs_PaperReport_AddNewRecordWithReturnKey(objgs_PaperReportEN: clsgs_PaperReportEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objgs_PaperReportEN.reportId === null || objgs_PaperReportEN.reportId === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(gs_PaperReport_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_PaperReportEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperReport_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperReport_ConstructorName, strThisFuncName);
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
 * @param objgs_PaperReportEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function gs_PaperReport_UpdateRecordAsync(objgs_PaperReportEN: clsgs_PaperReportEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objgs_PaperReportEN.sf_UpdFldSetStr === undefined || objgs_PaperReportEN.sf_UpdFldSetStr === null || objgs_PaperReportEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_PaperReportEN.reportId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(gs_PaperReport_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_PaperReportEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperReport_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperReport_ConstructorName, strThisFuncName);
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
 * @param objgs_PaperReportEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function gs_PaperReport_UpdateWithConditionAsync(objgs_PaperReportEN: clsgs_PaperReportEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objgs_PaperReportEN.sf_UpdFldSetStr === undefined || objgs_PaperReportEN.sf_UpdFldSetStr === null || objgs_PaperReportEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_PaperReportEN.reportId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(gs_PaperReport_Controller, strAction);
objgs_PaperReportEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objgs_PaperReportEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperReport_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperReport_ConstructorName, strThisFuncName);
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
 * @param objstrReportId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function gs_PaperReport_IsExistRecord_Cache(objgs_PaperReport_Cond: clsgs_PaperReportEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrgs_PaperReportObjLst_Cache = await gs_PaperReport_GetObjLst_Cache();
if (arrgs_PaperReportObjLst_Cache == null) return false;
let arrgs_PaperReport_Sel: Array < clsgs_PaperReportEN > = arrgs_PaperReportObjLst_Cache;
if (objgs_PaperReport_Cond.sf_FldComparisonOp == null || objgs_PaperReport_Cond.sf_FldComparisonOp == "") return arrgs_PaperReport_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_PaperReport_Cond.sf_FldComparisonOp);
//console.log("clsgs_PaperReportWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objgs_PaperReport_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_PaperReport_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_PaperReport_Sel = arrgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_PaperReport_Sel = arrgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_PaperReport_Sel = arrgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_PaperReport_Sel = arrgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_PaperReport_Sel = arrgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_PaperReport_Sel = arrgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_PaperReport_Sel = arrgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_PaperReport_Sel = arrgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrgs_PaperReport_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objgs_PaperReport_Cond), gs_PaperReport_ConstructorName, strThisFuncName);
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
export async function gs_PaperReport_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(gs_PaperReport_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperReport_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperReport_ConstructorName, strThisFuncName);
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
 * @param strReportId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function gs_PaperReport_IsExist(strReportId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(gs_PaperReport_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"ReportId": strReportId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperReport_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperReport_ConstructorName, strThisFuncName);
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
 * @param strReportId:所给的关键字
 * @returns 对象
*/
export async function gs_PaperReport_IsExist_Cache(strReportId:string) {
const strThisFuncName = "IsExist_Cache";
const arrgs_PaperReportObjLst_Cache = await gs_PaperReport_GetObjLst_Cache();
if (arrgs_PaperReportObjLst_Cache == null) return false;
try
{
const arrgs_PaperReport_Sel: Array <clsgs_PaperReportEN> = arrgs_PaperReportObjLst_Cache.filter(x => x.reportId == strReportId);
if (arrgs_PaperReport_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strReportId, gs_PaperReport_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param strReportId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function gs_PaperReport_IsExistAsync(strReportId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(gs_PaperReport_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strReportId": strReportId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperReport_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperReport_ConstructorName, strThisFuncName);
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
export async function gs_PaperReport_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(gs_PaperReport_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperReport_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperReport_ConstructorName, strThisFuncName);
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
 * @param objgs_PaperReport_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function gs_PaperReport_GetRecCountByCond_Cache(objgs_PaperReport_Cond: clsgs_PaperReportEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrgs_PaperReportObjLst_Cache = await gs_PaperReport_GetObjLst_Cache();
if (arrgs_PaperReportObjLst_Cache == null) return 0;
let arrgs_PaperReport_Sel: Array < clsgs_PaperReportEN > = arrgs_PaperReportObjLst_Cache;
if (objgs_PaperReport_Cond.sf_FldComparisonOp == null || objgs_PaperReport_Cond.sf_FldComparisonOp == "") return arrgs_PaperReport_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_PaperReport_Cond.sf_FldComparisonOp);
//console.log("clsgs_PaperReportWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objgs_PaperReport_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrgs_PaperReport_Sel = arrgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_PaperReport_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_PaperReport_Sel = arrgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_PaperReport_Sel = arrgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrgs_PaperReport_Sel = arrgs_PaperReport_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_PaperReport_Sel = arrgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_PaperReport_Sel = arrgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_PaperReport_Sel = arrgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_PaperReport_Sel = arrgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_PaperReport_Sel = arrgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_PaperReport_Sel = arrgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrgs_PaperReport_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objgs_PaperReport_Cond), gs_PaperReport_ConstructorName, strThisFuncName);
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
export async function gs_PaperReport_GetMaxStrIdAsync(): Promise<string>  
{
const strThisFuncName = "GetMaxStrIdAsync";
const strAction = "GetMaxStrId";
const strUrl = GetWebApiUrl(gs_PaperReport_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperReport_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperReport_ConstructorName, strThisFuncName);
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
export async function gs_PaperReport_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(gs_PaperReport_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperReport_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperReport_ConstructorName, strThisFuncName);
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
export function gs_PaperReport_GetWebApiUrl(strController: string, strAction: string): string {
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
export function gs_PaperReport_ReFreshCache():void
{
const strThisFuncName = "ReFreshCache";

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = clsgs_PaperReportEN._CurrTabName;
switch (clsgs_PaperReportEN.CacheModeId)
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
vgs_PaperReport_ReFreshThisCache();
}

 /**
 * 刷新本类中的缓存.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
 **/
export function gs_PaperReport_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clsgs_PaperReportEN._CurrTabName;
switch (clsgs_PaperReportEN.CacheModeId)
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
export function gs_PaperReport_CheckPropertyNew(pobjgs_PaperReportEN: clsgs_PaperReportEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjgs_PaperReportEN.reportId) == false && GetStrLen(pobjgs_PaperReportEN.reportId) > 10)
{
 throw new Error("(errid:Watl000059)字段[汇报Id(reportId)]的长度不能超过10(In 论文汇报表(gs_PaperReport))!值:$(pobjgs_PaperReportEN.reportId)(clsgs_PaperReportBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperReportEN.topicId) == false && GetStrLen(pobjgs_PaperReportEN.topicId) > 8)
{
 throw new Error("(errid:Watl000059)字段[主题Id(topicId)]的长度不能超过8(In 论文汇报表(gs_PaperReport))!值:$(pobjgs_PaperReportEN.topicId)(clsgs_PaperReportBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperReportEN.paperId) == false && GetStrLen(pobjgs_PaperReportEN.paperId) > 8)
{
 throw new Error("(errid:Watl000059)字段[论文Id(paperId)]的长度不能超过8(In 论文汇报表(gs_PaperReport))!值:$(pobjgs_PaperReportEN.paperId)(clsgs_PaperReportBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperReportEN.reportContent) == false && GetStrLen(pobjgs_PaperReportEN.reportContent) > 5000)
{
 throw new Error("(errid:Watl000059)字段[汇报内容(reportContent)]的长度不能超过5000(In 论文汇报表(gs_PaperReport))!值:$(pobjgs_PaperReportEN.reportContent)(clsgs_PaperReportBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperReportEN.reportUser) == false && GetStrLen(pobjgs_PaperReportEN.reportUser) > 500)
{
 throw new Error("(errid:Watl000059)字段[汇报用户(reportUser)]的长度不能超过500(In 论文汇报表(gs_PaperReport))!值:$(pobjgs_PaperReportEN.reportUser)(clsgs_PaperReportBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperReportEN.reportDate) == false && GetStrLen(pobjgs_PaperReportEN.reportDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[汇报日期(reportDate)]的长度不能超过20(In 论文汇报表(gs_PaperReport))!值:$(pobjgs_PaperReportEN.reportDate)(clsgs_PaperReportBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperReportEN.pdFUrl) == false && GetStrLen(pobjgs_PaperReportEN.pdFUrl) > 500)
{
 throw new Error("(errid:Watl000059)字段[PDFUrl(pdFUrl)]的长度不能超过500(In 论文汇报表(gs_PaperReport))!值:$(pobjgs_PaperReportEN.pdFUrl)(clsgs_PaperReportBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperReportEN.ppTUrl) == false && GetStrLen(pobjgs_PaperReportEN.ppTUrl) > 500)
{
 throw new Error("(errid:Watl000059)字段[PPTUrl(ppTUrl)]的长度不能超过500(In 论文汇报表(gs_PaperReport))!值:$(pobjgs_PaperReportEN.ppTUrl)(clsgs_PaperReportBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperReportEN.month) == false && GetStrLen(pobjgs_PaperReportEN.month) > 2)
{
 throw new Error("(errid:Watl000059)字段[月(month)]的长度不能超过2(In 论文汇报表(gs_PaperReport))!值:$(pobjgs_PaperReportEN.month)(clsgs_PaperReportBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperReportEN.year) == false && GetStrLen(pobjgs_PaperReportEN.year) > 4)
{
 throw new Error("(errid:Watl000059)字段[年(year)]的长度不能超过4(In 论文汇报表(gs_PaperReport))!值:$(pobjgs_PaperReportEN.year)(clsgs_PaperReportBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperReportEN.id_CurrEduCls) == false && GetStrLen(pobjgs_PaperReportEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 论文汇报表(gs_PaperReport))!值:$(pobjgs_PaperReportEN.id_CurrEduCls)(clsgs_PaperReportBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperReportEN.updUser) == false && GetStrLen(pobjgs_PaperReportEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 论文汇报表(gs_PaperReport))!值:$(pobjgs_PaperReportEN.updUser)(clsgs_PaperReportBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperReportEN.updDate) == false && GetStrLen(pobjgs_PaperReportEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 论文汇报表(gs_PaperReport))!值:$(pobjgs_PaperReportEN.updDate)(clsgs_PaperReportBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperReportEN.memo) == false && GetStrLen(pobjgs_PaperReportEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 论文汇报表(gs_PaperReport))!值:$(pobjgs_PaperReportEN.memo)(clsgs_PaperReportBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjgs_PaperReportEN.reportId) == false && undefined !== pobjgs_PaperReportEN.reportId && tzDataType.isString(pobjgs_PaperReportEN.reportId) === false)
{
 throw new Error("(errid:Watl000060)字段[汇报Id(reportId)]的值:[$(pobjgs_PaperReportEN.reportId)], 非法，应该为字符型(In 论文汇报表(gs_PaperReport))!(clsgs_PaperReportBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperReportEN.topicId) == false && undefined !== pobjgs_PaperReportEN.topicId && tzDataType.isString(pobjgs_PaperReportEN.topicId) === false)
{
 throw new Error("(errid:Watl000060)字段[主题Id(topicId)]的值:[$(pobjgs_PaperReportEN.topicId)], 非法，应该为字符型(In 论文汇报表(gs_PaperReport))!(clsgs_PaperReportBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperReportEN.paperId) == false && undefined !== pobjgs_PaperReportEN.paperId && tzDataType.isString(pobjgs_PaperReportEN.paperId) === false)
{
 throw new Error("(errid:Watl000060)字段[论文Id(paperId)]的值:[$(pobjgs_PaperReportEN.paperId)], 非法，应该为字符型(In 论文汇报表(gs_PaperReport))!(clsgs_PaperReportBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperReportEN.reportContent) == false && undefined !== pobjgs_PaperReportEN.reportContent && tzDataType.isString(pobjgs_PaperReportEN.reportContent) === false)
{
 throw new Error("(errid:Watl000060)字段[汇报内容(reportContent)]的值:[$(pobjgs_PaperReportEN.reportContent)], 非法，应该为字符型(In 论文汇报表(gs_PaperReport))!(clsgs_PaperReportBL:CheckPropertyNew)");
}
if (null != pobjgs_PaperReportEN.isSubmit && undefined !== pobjgs_PaperReportEN.isSubmit && tzDataType.isBoolean(pobjgs_PaperReportEN.isSubmit) === false)
{
 throw new Error("(errid:Watl000060)字段[是否提交(isSubmit)]的值:[$(pobjgs_PaperReportEN.isSubmit)], 非法，应该为布尔型(In 论文汇报表(gs_PaperReport))!(clsgs_PaperReportBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperReportEN.reportUser) == false && undefined !== pobjgs_PaperReportEN.reportUser && tzDataType.isString(pobjgs_PaperReportEN.reportUser) === false)
{
 throw new Error("(errid:Watl000060)字段[汇报用户(reportUser)]的值:[$(pobjgs_PaperReportEN.reportUser)], 非法，应该为字符型(In 论文汇报表(gs_PaperReport))!(clsgs_PaperReportBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperReportEN.reportDate) == false && undefined !== pobjgs_PaperReportEN.reportDate && tzDataType.isString(pobjgs_PaperReportEN.reportDate) === false)
{
 throw new Error("(errid:Watl000060)字段[汇报日期(reportDate)]的值:[$(pobjgs_PaperReportEN.reportDate)], 非法，应该为字符型(In 论文汇报表(gs_PaperReport))!(clsgs_PaperReportBL:CheckPropertyNew)");
}
if (null != pobjgs_PaperReportEN.versionCount && undefined !== pobjgs_PaperReportEN.versionCount && tzDataType.isNumber(pobjgs_PaperReportEN.versionCount) === false)
{
 throw new Error("(errid:Watl000060)字段[版本统计(versionCount)]的值:[$(pobjgs_PaperReportEN.versionCount)], 非法，应该为数值型(In 论文汇报表(gs_PaperReport))!(clsgs_PaperReportBL:CheckPropertyNew)");
}
if (null != pobjgs_PaperReportEN.okCount && undefined !== pobjgs_PaperReportEN.okCount && tzDataType.isNumber(pobjgs_PaperReportEN.okCount) === false)
{
 throw new Error("(errid:Watl000060)字段[点赞统计(okCount)]的值:[$(pobjgs_PaperReportEN.okCount)], 非法，应该为数值型(In 论文汇报表(gs_PaperReport))!(clsgs_PaperReportBL:CheckPropertyNew)");
}
if (null != pobjgs_PaperReportEN.appraiseCount && undefined !== pobjgs_PaperReportEN.appraiseCount && tzDataType.isNumber(pobjgs_PaperReportEN.appraiseCount) === false)
{
 throw new Error("(errid:Watl000060)字段[评论数(appraiseCount)]的值:[$(pobjgs_PaperReportEN.appraiseCount)], 非法，应该为数值型(In 论文汇报表(gs_PaperReport))!(clsgs_PaperReportBL:CheckPropertyNew)");
}
if (null != pobjgs_PaperReportEN.score && undefined !== pobjgs_PaperReportEN.score && tzDataType.isNumber(pobjgs_PaperReportEN.score) === false)
{
 throw new Error("(errid:Watl000060)字段[评分(score)]的值:[$(pobjgs_PaperReportEN.score)], 非法，应该为数值型(In 论文汇报表(gs_PaperReport))!(clsgs_PaperReportBL:CheckPropertyNew)");
}
if (null != pobjgs_PaperReportEN.stuScore && undefined !== pobjgs_PaperReportEN.stuScore && tzDataType.isNumber(pobjgs_PaperReportEN.stuScore) === false)
{
 throw new Error("(errid:Watl000060)字段[学生平均分(stuScore)]的值:[$(pobjgs_PaperReportEN.stuScore)], 非法，应该为数值型(In 论文汇报表(gs_PaperReport))!(clsgs_PaperReportBL:CheckPropertyNew)");
}
if (null != pobjgs_PaperReportEN.teaScore && undefined !== pobjgs_PaperReportEN.teaScore && tzDataType.isNumber(pobjgs_PaperReportEN.teaScore) === false)
{
 throw new Error("(errid:Watl000060)字段[教师评分(teaScore)]的值:[$(pobjgs_PaperReportEN.teaScore)], 非法，应该为数值型(In 论文汇报表(gs_PaperReport))!(clsgs_PaperReportBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperReportEN.pdFUrl) == false && undefined !== pobjgs_PaperReportEN.pdFUrl && tzDataType.isString(pobjgs_PaperReportEN.pdFUrl) === false)
{
 throw new Error("(errid:Watl000060)字段[PDFUrl(pdFUrl)]的值:[$(pobjgs_PaperReportEN.pdFUrl)], 非法，应该为字符型(In 论文汇报表(gs_PaperReport))!(clsgs_PaperReportBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperReportEN.ppTUrl) == false && undefined !== pobjgs_PaperReportEN.ppTUrl && tzDataType.isString(pobjgs_PaperReportEN.ppTUrl) === false)
{
 throw new Error("(errid:Watl000060)字段[PPTUrl(ppTUrl)]的值:[$(pobjgs_PaperReportEN.ppTUrl)], 非法，应该为字符型(In 论文汇报表(gs_PaperReport))!(clsgs_PaperReportBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperReportEN.month) == false && undefined !== pobjgs_PaperReportEN.month && tzDataType.isString(pobjgs_PaperReportEN.month) === false)
{
 throw new Error("(errid:Watl000060)字段[月(month)]的值:[$(pobjgs_PaperReportEN.month)], 非法，应该为字符型(In 论文汇报表(gs_PaperReport))!(clsgs_PaperReportBL:CheckPropertyNew)");
}
if (null != pobjgs_PaperReportEN.week && undefined !== pobjgs_PaperReportEN.week && tzDataType.isNumber(pobjgs_PaperReportEN.week) === false)
{
 throw new Error("(errid:Watl000060)字段[周(week)]的值:[$(pobjgs_PaperReportEN.week)], 非法，应该为数值型(In 论文汇报表(gs_PaperReport))!(clsgs_PaperReportBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperReportEN.year) == false && undefined !== pobjgs_PaperReportEN.year && tzDataType.isString(pobjgs_PaperReportEN.year) === false)
{
 throw new Error("(errid:Watl000060)字段[年(year)]的值:[$(pobjgs_PaperReportEN.year)], 非法，应该为字符型(In 论文汇报表(gs_PaperReport))!(clsgs_PaperReportBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperReportEN.id_CurrEduCls) == false && undefined !== pobjgs_PaperReportEN.id_CurrEduCls && tzDataType.isString(pobjgs_PaperReportEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjgs_PaperReportEN.id_CurrEduCls)], 非法，应该为字符型(In 论文汇报表(gs_PaperReport))!(clsgs_PaperReportBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperReportEN.updUser) == false && undefined !== pobjgs_PaperReportEN.updUser && tzDataType.isString(pobjgs_PaperReportEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjgs_PaperReportEN.updUser)], 非法，应该为字符型(In 论文汇报表(gs_PaperReport))!(clsgs_PaperReportBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperReportEN.updDate) == false && undefined !== pobjgs_PaperReportEN.updDate && tzDataType.isString(pobjgs_PaperReportEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjgs_PaperReportEN.updDate)], 非法，应该为字符型(In 论文汇报表(gs_PaperReport))!(clsgs_PaperReportBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperReportEN.memo) == false && undefined !== pobjgs_PaperReportEN.memo && tzDataType.isString(pobjgs_PaperReportEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjgs_PaperReportEN.memo)], 非法，应该为字符型(In 论文汇报表(gs_PaperReport))!(clsgs_PaperReportBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjgs_PaperReportEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function gs_PaperReport_CheckProperty4Update (pobjgs_PaperReportEN: clsgs_PaperReportEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjgs_PaperReportEN.reportId) == false && GetStrLen(pobjgs_PaperReportEN.reportId) > 10)
{
 throw new Error("(errid:Watl000062)字段[汇报Id(reportId)]的长度不能超过10(In 论文汇报表(gs_PaperReport))!值:$(pobjgs_PaperReportEN.reportId)(clsgs_PaperReportBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperReportEN.topicId) == false && GetStrLen(pobjgs_PaperReportEN.topicId) > 8)
{
 throw new Error("(errid:Watl000062)字段[主题Id(topicId)]的长度不能超过8(In 论文汇报表(gs_PaperReport))!值:$(pobjgs_PaperReportEN.topicId)(clsgs_PaperReportBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperReportEN.paperId) == false && GetStrLen(pobjgs_PaperReportEN.paperId) > 8)
{
 throw new Error("(errid:Watl000062)字段[论文Id(paperId)]的长度不能超过8(In 论文汇报表(gs_PaperReport))!值:$(pobjgs_PaperReportEN.paperId)(clsgs_PaperReportBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperReportEN.reportContent) == false && GetStrLen(pobjgs_PaperReportEN.reportContent) > 5000)
{
 throw new Error("(errid:Watl000062)字段[汇报内容(reportContent)]的长度不能超过5000(In 论文汇报表(gs_PaperReport))!值:$(pobjgs_PaperReportEN.reportContent)(clsgs_PaperReportBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperReportEN.reportUser) == false && GetStrLen(pobjgs_PaperReportEN.reportUser) > 500)
{
 throw new Error("(errid:Watl000062)字段[汇报用户(reportUser)]的长度不能超过500(In 论文汇报表(gs_PaperReport))!值:$(pobjgs_PaperReportEN.reportUser)(clsgs_PaperReportBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperReportEN.reportDate) == false && GetStrLen(pobjgs_PaperReportEN.reportDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[汇报日期(reportDate)]的长度不能超过20(In 论文汇报表(gs_PaperReport))!值:$(pobjgs_PaperReportEN.reportDate)(clsgs_PaperReportBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperReportEN.pdFUrl) == false && GetStrLen(pobjgs_PaperReportEN.pdFUrl) > 500)
{
 throw new Error("(errid:Watl000062)字段[PDFUrl(pdFUrl)]的长度不能超过500(In 论文汇报表(gs_PaperReport))!值:$(pobjgs_PaperReportEN.pdFUrl)(clsgs_PaperReportBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperReportEN.ppTUrl) == false && GetStrLen(pobjgs_PaperReportEN.ppTUrl) > 500)
{
 throw new Error("(errid:Watl000062)字段[PPTUrl(ppTUrl)]的长度不能超过500(In 论文汇报表(gs_PaperReport))!值:$(pobjgs_PaperReportEN.ppTUrl)(clsgs_PaperReportBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperReportEN.month) == false && GetStrLen(pobjgs_PaperReportEN.month) > 2)
{
 throw new Error("(errid:Watl000062)字段[月(month)]的长度不能超过2(In 论文汇报表(gs_PaperReport))!值:$(pobjgs_PaperReportEN.month)(clsgs_PaperReportBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperReportEN.year) == false && GetStrLen(pobjgs_PaperReportEN.year) > 4)
{
 throw new Error("(errid:Watl000062)字段[年(year)]的长度不能超过4(In 论文汇报表(gs_PaperReport))!值:$(pobjgs_PaperReportEN.year)(clsgs_PaperReportBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperReportEN.id_CurrEduCls) == false && GetStrLen(pobjgs_PaperReportEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 论文汇报表(gs_PaperReport))!值:$(pobjgs_PaperReportEN.id_CurrEduCls)(clsgs_PaperReportBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperReportEN.updUser) == false && GetStrLen(pobjgs_PaperReportEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 论文汇报表(gs_PaperReport))!值:$(pobjgs_PaperReportEN.updUser)(clsgs_PaperReportBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperReportEN.updDate) == false && GetStrLen(pobjgs_PaperReportEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 论文汇报表(gs_PaperReport))!值:$(pobjgs_PaperReportEN.updDate)(clsgs_PaperReportBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperReportEN.memo) == false && GetStrLen(pobjgs_PaperReportEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 论文汇报表(gs_PaperReport))!值:$(pobjgs_PaperReportEN.memo)(clsgs_PaperReportBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjgs_PaperReportEN.reportId) == false && undefined !== pobjgs_PaperReportEN.reportId && tzDataType.isString(pobjgs_PaperReportEN.reportId) === false)
{
 throw new Error("(errid:Watl000063)字段[汇报Id(reportId)]的值:[$(pobjgs_PaperReportEN.reportId)], 非法，应该为字符型(In 论文汇报表(gs_PaperReport))!(clsgs_PaperReportBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperReportEN.topicId) == false && undefined !== pobjgs_PaperReportEN.topicId && tzDataType.isString(pobjgs_PaperReportEN.topicId) === false)
{
 throw new Error("(errid:Watl000063)字段[主题Id(topicId)]的值:[$(pobjgs_PaperReportEN.topicId)], 非法，应该为字符型(In 论文汇报表(gs_PaperReport))!(clsgs_PaperReportBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperReportEN.paperId) == false && undefined !== pobjgs_PaperReportEN.paperId && tzDataType.isString(pobjgs_PaperReportEN.paperId) === false)
{
 throw new Error("(errid:Watl000063)字段[论文Id(paperId)]的值:[$(pobjgs_PaperReportEN.paperId)], 非法，应该为字符型(In 论文汇报表(gs_PaperReport))!(clsgs_PaperReportBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperReportEN.reportContent) == false && undefined !== pobjgs_PaperReportEN.reportContent && tzDataType.isString(pobjgs_PaperReportEN.reportContent) === false)
{
 throw new Error("(errid:Watl000063)字段[汇报内容(reportContent)]的值:[$(pobjgs_PaperReportEN.reportContent)], 非法，应该为字符型(In 论文汇报表(gs_PaperReport))!(clsgs_PaperReportBL:CheckProperty4Update)");
}
if (null != pobjgs_PaperReportEN.isSubmit && undefined !== pobjgs_PaperReportEN.isSubmit && tzDataType.isBoolean(pobjgs_PaperReportEN.isSubmit) === false)
{
 throw new Error("(errid:Watl000063)字段[是否提交(isSubmit)]的值:[$(pobjgs_PaperReportEN.isSubmit)], 非法，应该为布尔型(In 论文汇报表(gs_PaperReport))!(clsgs_PaperReportBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperReportEN.reportUser) == false && undefined !== pobjgs_PaperReportEN.reportUser && tzDataType.isString(pobjgs_PaperReportEN.reportUser) === false)
{
 throw new Error("(errid:Watl000063)字段[汇报用户(reportUser)]的值:[$(pobjgs_PaperReportEN.reportUser)], 非法，应该为字符型(In 论文汇报表(gs_PaperReport))!(clsgs_PaperReportBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperReportEN.reportDate) == false && undefined !== pobjgs_PaperReportEN.reportDate && tzDataType.isString(pobjgs_PaperReportEN.reportDate) === false)
{
 throw new Error("(errid:Watl000063)字段[汇报日期(reportDate)]的值:[$(pobjgs_PaperReportEN.reportDate)], 非法，应该为字符型(In 论文汇报表(gs_PaperReport))!(clsgs_PaperReportBL:CheckProperty4Update)");
}
if (null != pobjgs_PaperReportEN.versionCount && undefined !== pobjgs_PaperReportEN.versionCount && tzDataType.isNumber(pobjgs_PaperReportEN.versionCount) === false)
{
 throw new Error("(errid:Watl000063)字段[版本统计(versionCount)]的值:[$(pobjgs_PaperReportEN.versionCount)], 非法，应该为数值型(In 论文汇报表(gs_PaperReport))!(clsgs_PaperReportBL:CheckProperty4Update)");
}
if (null != pobjgs_PaperReportEN.okCount && undefined !== pobjgs_PaperReportEN.okCount && tzDataType.isNumber(pobjgs_PaperReportEN.okCount) === false)
{
 throw new Error("(errid:Watl000063)字段[点赞统计(okCount)]的值:[$(pobjgs_PaperReportEN.okCount)], 非法，应该为数值型(In 论文汇报表(gs_PaperReport))!(clsgs_PaperReportBL:CheckProperty4Update)");
}
if (null != pobjgs_PaperReportEN.appraiseCount && undefined !== pobjgs_PaperReportEN.appraiseCount && tzDataType.isNumber(pobjgs_PaperReportEN.appraiseCount) === false)
{
 throw new Error("(errid:Watl000063)字段[评论数(appraiseCount)]的值:[$(pobjgs_PaperReportEN.appraiseCount)], 非法，应该为数值型(In 论文汇报表(gs_PaperReport))!(clsgs_PaperReportBL:CheckProperty4Update)");
}
if (null != pobjgs_PaperReportEN.score && undefined !== pobjgs_PaperReportEN.score && tzDataType.isNumber(pobjgs_PaperReportEN.score) === false)
{
 throw new Error("(errid:Watl000063)字段[评分(score)]的值:[$(pobjgs_PaperReportEN.score)], 非法，应该为数值型(In 论文汇报表(gs_PaperReport))!(clsgs_PaperReportBL:CheckProperty4Update)");
}
if (null != pobjgs_PaperReportEN.stuScore && undefined !== pobjgs_PaperReportEN.stuScore && tzDataType.isNumber(pobjgs_PaperReportEN.stuScore) === false)
{
 throw new Error("(errid:Watl000063)字段[学生平均分(stuScore)]的值:[$(pobjgs_PaperReportEN.stuScore)], 非法，应该为数值型(In 论文汇报表(gs_PaperReport))!(clsgs_PaperReportBL:CheckProperty4Update)");
}
if (null != pobjgs_PaperReportEN.teaScore && undefined !== pobjgs_PaperReportEN.teaScore && tzDataType.isNumber(pobjgs_PaperReportEN.teaScore) === false)
{
 throw new Error("(errid:Watl000063)字段[教师评分(teaScore)]的值:[$(pobjgs_PaperReportEN.teaScore)], 非法，应该为数值型(In 论文汇报表(gs_PaperReport))!(clsgs_PaperReportBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperReportEN.pdFUrl) == false && undefined !== pobjgs_PaperReportEN.pdFUrl && tzDataType.isString(pobjgs_PaperReportEN.pdFUrl) === false)
{
 throw new Error("(errid:Watl000063)字段[PDFUrl(pdFUrl)]的值:[$(pobjgs_PaperReportEN.pdFUrl)], 非法，应该为字符型(In 论文汇报表(gs_PaperReport))!(clsgs_PaperReportBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperReportEN.ppTUrl) == false && undefined !== pobjgs_PaperReportEN.ppTUrl && tzDataType.isString(pobjgs_PaperReportEN.ppTUrl) === false)
{
 throw new Error("(errid:Watl000063)字段[PPTUrl(ppTUrl)]的值:[$(pobjgs_PaperReportEN.ppTUrl)], 非法，应该为字符型(In 论文汇报表(gs_PaperReport))!(clsgs_PaperReportBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperReportEN.month) == false && undefined !== pobjgs_PaperReportEN.month && tzDataType.isString(pobjgs_PaperReportEN.month) === false)
{
 throw new Error("(errid:Watl000063)字段[月(month)]的值:[$(pobjgs_PaperReportEN.month)], 非法，应该为字符型(In 论文汇报表(gs_PaperReport))!(clsgs_PaperReportBL:CheckProperty4Update)");
}
if (null != pobjgs_PaperReportEN.week && undefined !== pobjgs_PaperReportEN.week && tzDataType.isNumber(pobjgs_PaperReportEN.week) === false)
{
 throw new Error("(errid:Watl000063)字段[周(week)]的值:[$(pobjgs_PaperReportEN.week)], 非法，应该为数值型(In 论文汇报表(gs_PaperReport))!(clsgs_PaperReportBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperReportEN.year) == false && undefined !== pobjgs_PaperReportEN.year && tzDataType.isString(pobjgs_PaperReportEN.year) === false)
{
 throw new Error("(errid:Watl000063)字段[年(year)]的值:[$(pobjgs_PaperReportEN.year)], 非法，应该为字符型(In 论文汇报表(gs_PaperReport))!(clsgs_PaperReportBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperReportEN.id_CurrEduCls) == false && undefined !== pobjgs_PaperReportEN.id_CurrEduCls && tzDataType.isString(pobjgs_PaperReportEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjgs_PaperReportEN.id_CurrEduCls)], 非法，应该为字符型(In 论文汇报表(gs_PaperReport))!(clsgs_PaperReportBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperReportEN.updUser) == false && undefined !== pobjgs_PaperReportEN.updUser && tzDataType.isString(pobjgs_PaperReportEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjgs_PaperReportEN.updUser)], 非法，应该为字符型(In 论文汇报表(gs_PaperReport))!(clsgs_PaperReportBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperReportEN.updDate) == false && undefined !== pobjgs_PaperReportEN.updDate && tzDataType.isString(pobjgs_PaperReportEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjgs_PaperReportEN.updDate)], 非法，应该为字符型(In 论文汇报表(gs_PaperReport))!(clsgs_PaperReportBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperReportEN.memo) == false && undefined !== pobjgs_PaperReportEN.memo && tzDataType.isString(pobjgs_PaperReportEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjgs_PaperReportEN.memo)], 非法，应该为字符型(In 论文汇报表(gs_PaperReport))!(clsgs_PaperReportBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (IsNullOrEmpty(pobjgs_PaperReportEN.reportId) === true )
{
 throw new Error("(errid:Watl000064)字段[汇报Id]不能为空(In 论文汇报表)!(clsgs_PaperReportBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjgs_PaperReportEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function gs_PaperReport_GetJSONStrByObj (pobjgs_PaperReportEN: clsgs_PaperReportEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjgs_PaperReportEN.sf_UpdFldSetStr = pobjgs_PaperReportEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjgs_PaperReportEN);
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
export function gs_PaperReport_GetObjLstByJSONStr (strJSON: string): Array<clsgs_PaperReportEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrgs_PaperReportObjLst = new Array<clsgs_PaperReportEN>();
if (strJSON === "")
{
return arrgs_PaperReportObjLst;
}
try
{
arrgs_PaperReportObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrgs_PaperReportObjLst;
}
return arrgs_PaperReportObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrgs_PaperReportObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function gs_PaperReport_GetObjLstByJSONObjLst (arrgs_PaperReportObjLstS: Array<clsgs_PaperReportEN>): Array<clsgs_PaperReportEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrgs_PaperReportObjLst = new Array<clsgs_PaperReportEN>();
for (const objInFor of arrgs_PaperReportObjLstS) {
const obj1 = gs_PaperReport_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrgs_PaperReportObjLst.push(obj1);
}
return arrgs_PaperReportObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function gs_PaperReport_GetObjByJSONStr (strJSON: string): clsgs_PaperReportEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjgs_PaperReportEN = new clsgs_PaperReportEN();
if (strJSON === "")
{
return pobjgs_PaperReportEN;
}
try
{
pobjgs_PaperReportEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjgs_PaperReportEN;
}
return pobjgs_PaperReportEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function gs_PaperReport_GetCombineCondition(objgs_PaperReport_Cond: clsgs_PaperReportEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objgs_PaperReport_Cond.dicFldComparisonOp, clsgs_PaperReportEN.con_ReportId) == true)
{
const strComparisonOp_ReportId:string = objgs_PaperReport_Cond.dicFldComparisonOp[clsgs_PaperReportEN.con_ReportId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperReportEN.con_ReportId, objgs_PaperReport_Cond.reportId, strComparisonOp_ReportId);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperReport_Cond.dicFldComparisonOp, clsgs_PaperReportEN.con_TopicId) == true)
{
const strComparisonOp_TopicId:string = objgs_PaperReport_Cond.dicFldComparisonOp[clsgs_PaperReportEN.con_TopicId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperReportEN.con_TopicId, objgs_PaperReport_Cond.topicId, strComparisonOp_TopicId);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperReport_Cond.dicFldComparisonOp, clsgs_PaperReportEN.con_PaperId) == true)
{
const strComparisonOp_PaperId:string = objgs_PaperReport_Cond.dicFldComparisonOp[clsgs_PaperReportEN.con_PaperId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperReportEN.con_PaperId, objgs_PaperReport_Cond.paperId, strComparisonOp_PaperId);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperReport_Cond.dicFldComparisonOp, clsgs_PaperReportEN.con_ReportContent) == true)
{
const strComparisonOp_ReportContent:string = objgs_PaperReport_Cond.dicFldComparisonOp[clsgs_PaperReportEN.con_ReportContent];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperReportEN.con_ReportContent, objgs_PaperReport_Cond.reportContent, strComparisonOp_ReportContent);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperReport_Cond.dicFldComparisonOp, clsgs_PaperReportEN.con_IsSubmit) == true)
{
if (objgs_PaperReport_Cond.isSubmit == true)
{
strWhereCond += Format(" And {0} = '1'", clsgs_PaperReportEN.con_IsSubmit);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsgs_PaperReportEN.con_IsSubmit);
}
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperReport_Cond.dicFldComparisonOp, clsgs_PaperReportEN.con_ReportUser) == true)
{
const strComparisonOp_ReportUser:string = objgs_PaperReport_Cond.dicFldComparisonOp[clsgs_PaperReportEN.con_ReportUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperReportEN.con_ReportUser, objgs_PaperReport_Cond.reportUser, strComparisonOp_ReportUser);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperReport_Cond.dicFldComparisonOp, clsgs_PaperReportEN.con_ReportDate) == true)
{
const strComparisonOp_ReportDate:string = objgs_PaperReport_Cond.dicFldComparisonOp[clsgs_PaperReportEN.con_ReportDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperReportEN.con_ReportDate, objgs_PaperReport_Cond.reportDate, strComparisonOp_ReportDate);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperReport_Cond.dicFldComparisonOp, clsgs_PaperReportEN.con_VersionCount) == true)
{
const strComparisonOp_VersionCount:string = objgs_PaperReport_Cond.dicFldComparisonOp[clsgs_PaperReportEN.con_VersionCount];
strWhereCond += Format(" And {0} {2} {1}", clsgs_PaperReportEN.con_VersionCount, objgs_PaperReport_Cond.versionCount, strComparisonOp_VersionCount);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperReport_Cond.dicFldComparisonOp, clsgs_PaperReportEN.con_OkCount) == true)
{
const strComparisonOp_OkCount:string = objgs_PaperReport_Cond.dicFldComparisonOp[clsgs_PaperReportEN.con_OkCount];
strWhereCond += Format(" And {0} {2} {1}", clsgs_PaperReportEN.con_OkCount, objgs_PaperReport_Cond.okCount, strComparisonOp_OkCount);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperReport_Cond.dicFldComparisonOp, clsgs_PaperReportEN.con_AppraiseCount) == true)
{
const strComparisonOp_AppraiseCount:string = objgs_PaperReport_Cond.dicFldComparisonOp[clsgs_PaperReportEN.con_AppraiseCount];
strWhereCond += Format(" And {0} {2} {1}", clsgs_PaperReportEN.con_AppraiseCount, objgs_PaperReport_Cond.appraiseCount, strComparisonOp_AppraiseCount);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperReport_Cond.dicFldComparisonOp, clsgs_PaperReportEN.con_score) == true)
{
const strComparisonOp_score:string = objgs_PaperReport_Cond.dicFldComparisonOp[clsgs_PaperReportEN.con_score];
strWhereCond += Format(" And {0} {2} {1}", clsgs_PaperReportEN.con_score, objgs_PaperReport_Cond.score, strComparisonOp_score);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperReport_Cond.dicFldComparisonOp, clsgs_PaperReportEN.con_StuScore) == true)
{
const strComparisonOp_StuScore:string = objgs_PaperReport_Cond.dicFldComparisonOp[clsgs_PaperReportEN.con_StuScore];
strWhereCond += Format(" And {0} {2} {1}", clsgs_PaperReportEN.con_StuScore, objgs_PaperReport_Cond.stuScore, strComparisonOp_StuScore);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperReport_Cond.dicFldComparisonOp, clsgs_PaperReportEN.con_TeaScore) == true)
{
const strComparisonOp_TeaScore:string = objgs_PaperReport_Cond.dicFldComparisonOp[clsgs_PaperReportEN.con_TeaScore];
strWhereCond += Format(" And {0} {2} {1}", clsgs_PaperReportEN.con_TeaScore, objgs_PaperReport_Cond.teaScore, strComparisonOp_TeaScore);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperReport_Cond.dicFldComparisonOp, clsgs_PaperReportEN.con_PDFUrl) == true)
{
const strComparisonOp_PDFUrl:string = objgs_PaperReport_Cond.dicFldComparisonOp[clsgs_PaperReportEN.con_PDFUrl];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperReportEN.con_PDFUrl, objgs_PaperReport_Cond.pdFUrl, strComparisonOp_PDFUrl);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperReport_Cond.dicFldComparisonOp, clsgs_PaperReportEN.con_PPTUrl) == true)
{
const strComparisonOp_PPTUrl:string = objgs_PaperReport_Cond.dicFldComparisonOp[clsgs_PaperReportEN.con_PPTUrl];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperReportEN.con_PPTUrl, objgs_PaperReport_Cond.ppTUrl, strComparisonOp_PPTUrl);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperReport_Cond.dicFldComparisonOp, clsgs_PaperReportEN.con_Month) == true)
{
const strComparisonOp_Month:string = objgs_PaperReport_Cond.dicFldComparisonOp[clsgs_PaperReportEN.con_Month];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperReportEN.con_Month, objgs_PaperReport_Cond.month, strComparisonOp_Month);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperReport_Cond.dicFldComparisonOp, clsgs_PaperReportEN.con_Week) == true)
{
const strComparisonOp_Week:string = objgs_PaperReport_Cond.dicFldComparisonOp[clsgs_PaperReportEN.con_Week];
strWhereCond += Format(" And {0} {2} {1}", clsgs_PaperReportEN.con_Week, objgs_PaperReport_Cond.week, strComparisonOp_Week);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperReport_Cond.dicFldComparisonOp, clsgs_PaperReportEN.con_Year) == true)
{
const strComparisonOp_Year:string = objgs_PaperReport_Cond.dicFldComparisonOp[clsgs_PaperReportEN.con_Year];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperReportEN.con_Year, objgs_PaperReport_Cond.year, strComparisonOp_Year);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperReport_Cond.dicFldComparisonOp, clsgs_PaperReportEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objgs_PaperReport_Cond.dicFldComparisonOp[clsgs_PaperReportEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperReportEN.con_id_CurrEduCls, objgs_PaperReport_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperReport_Cond.dicFldComparisonOp, clsgs_PaperReportEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objgs_PaperReport_Cond.dicFldComparisonOp[clsgs_PaperReportEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperReportEN.con_UpdUser, objgs_PaperReport_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperReport_Cond.dicFldComparisonOp, clsgs_PaperReportEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objgs_PaperReport_Cond.dicFldComparisonOp[clsgs_PaperReportEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperReportEN.con_UpdDate, objgs_PaperReport_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperReport_Cond.dicFldComparisonOp, clsgs_PaperReportEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objgs_PaperReport_Cond.dicFldComparisonOp[clsgs_PaperReportEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperReportEN.con_Memo, objgs_PaperReport_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--gs_PaperReport(论文汇报表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param strTopicId: 主题Id(要求唯一的字段)
 * @param strReportUser: 汇报用户(要求唯一的字段)
 * @param strReportDate: 汇报日期(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function gs_PaperReport_GetUniCondStr_TopicId_ReportUser_ReportDate(objgs_PaperReportEN: clsgs_PaperReportEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and TopicId = '{0}'", objgs_PaperReportEN.topicId);
 strWhereCond +=  Format(" and ReportUser = '{0}'", objgs_PaperReportEN.reportUser);
 strWhereCond +=  Format(" and ReportDate = '{0}'", objgs_PaperReportEN.reportDate);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--gs_PaperReport(论文汇报表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param strTopicId: 主题Id(要求唯一的字段)
 * @param strReportUser: 汇报用户(要求唯一的字段)
 * @param strReportDate: 汇报日期(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function gs_PaperReport_GetUniCondStr4Update_TopicId_ReportUser_ReportDate(objgs_PaperReportEN: clsgs_PaperReportEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and ReportId <> '{0}'", objgs_PaperReportEN.reportId);
 strWhereCond +=  Format(" and TopicId = '{0}'", objgs_PaperReportEN.topicId);
 strWhereCond +=  Format(" and ReportUser = '{0}'", objgs_PaperReportEN.reportUser);
 strWhereCond +=  Format(" and ReportDate = '{0}'", objgs_PaperReportEN.reportDate);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objgs_PaperReportENS:源对象
 * @param objgs_PaperReportENT:目标对象
*/
export function gs_PaperReport_CopyObjTo(objgs_PaperReportENS: clsgs_PaperReportEN , objgs_PaperReportENT: clsgs_PaperReportEN ): void 
{
objgs_PaperReportENT.reportId = objgs_PaperReportENS.reportId; //汇报Id
objgs_PaperReportENT.topicId = objgs_PaperReportENS.topicId; //主题Id
objgs_PaperReportENT.paperId = objgs_PaperReportENS.paperId; //论文Id
objgs_PaperReportENT.reportContent = objgs_PaperReportENS.reportContent; //汇报内容
objgs_PaperReportENT.isSubmit = objgs_PaperReportENS.isSubmit; //是否提交
objgs_PaperReportENT.reportUser = objgs_PaperReportENS.reportUser; //汇报用户
objgs_PaperReportENT.reportDate = objgs_PaperReportENS.reportDate; //汇报日期
objgs_PaperReportENT.versionCount = objgs_PaperReportENS.versionCount; //版本统计
objgs_PaperReportENT.okCount = objgs_PaperReportENS.okCount; //点赞统计
objgs_PaperReportENT.appraiseCount = objgs_PaperReportENS.appraiseCount; //评论数
objgs_PaperReportENT.score = objgs_PaperReportENS.score; //评分
objgs_PaperReportENT.stuScore = objgs_PaperReportENS.stuScore; //学生平均分
objgs_PaperReportENT.teaScore = objgs_PaperReportENS.teaScore; //教师评分
objgs_PaperReportENT.pdFUrl = objgs_PaperReportENS.pdFUrl; //PDFUrl
objgs_PaperReportENT.ppTUrl = objgs_PaperReportENS.ppTUrl; //PPTUrl
objgs_PaperReportENT.month = objgs_PaperReportENS.month; //月
objgs_PaperReportENT.week = objgs_PaperReportENS.week; //周
objgs_PaperReportENT.year = objgs_PaperReportENS.year; //年
objgs_PaperReportENT.id_CurrEduCls = objgs_PaperReportENS.id_CurrEduCls; //教学班流水号
objgs_PaperReportENT.updUser = objgs_PaperReportENS.updUser; //修改人
objgs_PaperReportENT.updDate = objgs_PaperReportENS.updDate; //修改日期
objgs_PaperReportENT.memo = objgs_PaperReportENS.memo; //备注
objgs_PaperReportENT.sf_UpdFldSetStr = objgs_PaperReportENS.updFldString; //sf_UpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objgs_PaperReportENS:源对象
 * @param objgs_PaperReportENT:目标对象
*/
export function gs_PaperReport_GetObjFromJsonObj(objgs_PaperReportENS: clsgs_PaperReportEN): clsgs_PaperReportEN 
{
 const objgs_PaperReportENT: clsgs_PaperReportEN = new clsgs_PaperReportEN();
ObjectAssign(objgs_PaperReportENT, objgs_PaperReportENS);
 return objgs_PaperReportENT;
}