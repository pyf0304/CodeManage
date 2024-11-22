
 /**
 * 类名:clsvgs_PaperReportWApi
 * 表名:vgs_PaperReport(01120771)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 12:02:57
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
 * 论文汇报视图(vgs_PaperReport)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clsvgs_PaperReportEN } from "../../L0_Entity/GraduateEduTopic/clsvgs_PaperReportEN.js";
import { BindDdl_ObjLstInDiv_V, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const vgs_PaperReport_Controller = "vgs_PaperReportApi";
 export const vgs_PaperReport_ConstructorName = "vgs_PaperReport";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strReportId:关键字
 * @returns 对象
 **/
export async function vgs_PaperReport_GetObjByReportIdAsync(strReportId: string): Promise<clsvgs_PaperReportEN>  
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
const strUrl = GetWebApiUrl(vgs_PaperReport_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_PaperReport_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvgs_PaperReport = vgs_PaperReport_GetObjFromJsonObj(returnObj);
return objvgs_PaperReport;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PaperReport_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PaperReport_ConstructorName, strThisFuncName);
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
export async function vgs_PaperReport_GetObjByReportId_Cache(strReportId: string, bolTryAsyncOnce: boolean = true) {
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
const arrvgs_PaperReportObjLst_Cache = await vgs_PaperReport_GetObjLst_Cache();
try
{
const arrvgs_PaperReport_Sel: Array <clsvgs_PaperReportEN> = arrvgs_PaperReportObjLst_Cache.filter(x => x.reportId == strReportId);
let objvgs_PaperReport: clsvgs_PaperReportEN;
if (arrvgs_PaperReport_Sel.length > 0)
{
objvgs_PaperReport = arrvgs_PaperReport_Sel[0];
return objvgs_PaperReport;
}
else
{
if (bolTryAsyncOnce == true)
{
objvgs_PaperReport = await vgs_PaperReport_GetObjByReportIdAsync(strReportId);
if (objvgs_PaperReport != null)
{
vgs_PaperReport_ReFreshThisCache();
return objvgs_PaperReport;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strReportId, vgs_PaperReport_ConstructorName, strThisFuncName);
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
export async function vgs_PaperReport_GetObjByReportId_localStorage(strReportId: string) {
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
const strKey = Format("{0}_{1}", clsvgs_PaperReportEN._CurrTabName, strReportId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objvgs_PaperReport_Cache: clsvgs_PaperReportEN = JSON.parse(strTempObj);
return objvgs_PaperReport_Cache;
}
try
{
const objvgs_PaperReport = await vgs_PaperReport_GetObjByReportIdAsync(strReportId);
if (objvgs_PaperReport != null)
{
localStorage.setItem(strKey, JSON.stringify(objvgs_PaperReport));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objvgs_PaperReport;
}
return objvgs_PaperReport;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strReportId, vgs_PaperReport_ConstructorName, strThisFuncName);
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
export async function vgs_PaperReport_func(strInFldName:string , strOutFldName:string ,  strInValue: string) 
{
//const strThisFuncName = "func";

if (strInFldName != clsvgs_PaperReportEN.con_ReportId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsvgs_PaperReportEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clsvgs_PaperReportEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strReportId = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objvgs_PaperReport = await vgs_PaperReport_GetObjByReportId_Cache(strReportId );
if (objvgs_PaperReport == null) return "";
return objvgs_PaperReport.GetFldValue(strOutFldName).toString();
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
export function vgs_PaperReport_SortFun_Defa(a:clsvgs_PaperReportEN , b:clsvgs_PaperReportEN): number 
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
export function vgs_PaperReport_SortFun_Defa_2Fld(a:clsvgs_PaperReportEN , b:clsvgs_PaperReportEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.memo == b.memo) return a.updDate.localeCompare(b.updDate);
else return a.memo.localeCompare(b.memo);
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
export function vgs_PaperReport_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsvgs_PaperReportEN.con_Memo:
return (a: clsvgs_PaperReportEN, b: clsvgs_PaperReportEN) => {
return a.memo.localeCompare(b.memo);
}
case clsvgs_PaperReportEN.con_ReportId:
return (a: clsvgs_PaperReportEN, b: clsvgs_PaperReportEN) => {
return a.reportId.localeCompare(b.reportId);
}
case clsvgs_PaperReportEN.con_UpdDate:
return (a: clsvgs_PaperReportEN, b: clsvgs_PaperReportEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsvgs_PaperReportEN.con_TopicName:
return (a: clsvgs_PaperReportEN, b: clsvgs_PaperReportEN) => {
return a.topicName.localeCompare(b.topicName);
}
case clsvgs_PaperReportEN.con_TopicId:
return (a: clsvgs_PaperReportEN, b: clsvgs_PaperReportEN) => {
return a.topicId.localeCompare(b.topicId);
}
case clsvgs_PaperReportEN.con_PaperId:
return (a: clsvgs_PaperReportEN, b: clsvgs_PaperReportEN) => {
return a.paperId.localeCompare(b.paperId);
}
case clsvgs_PaperReportEN.con_PaperTitle:
return (a: clsvgs_PaperReportEN, b: clsvgs_PaperReportEN) => {
return a.paperTitle.localeCompare(b.paperTitle);
}
case clsvgs_PaperReportEN.con_ReportContent:
return (a: clsvgs_PaperReportEN, b: clsvgs_PaperReportEN) => {
return a.reportContent.localeCompare(b.reportContent);
}
case clsvgs_PaperReportEN.con_id_CurrEduCls:
return (a: clsvgs_PaperReportEN, b: clsvgs_PaperReportEN) => {
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
case clsvgs_PaperReportEN.con_IsSubmit:
return (a: clsvgs_PaperReportEN, b: clsvgs_PaperReportEN) => {
if (a.isSubmit == true) return 1;
else return -1
}
case clsvgs_PaperReportEN.con_ReportUser:
return (a: clsvgs_PaperReportEN, b: clsvgs_PaperReportEN) => {
return a.reportUser.localeCompare(b.reportUser);
}
case clsvgs_PaperReportEN.con_ReportDate:
return (a: clsvgs_PaperReportEN, b: clsvgs_PaperReportEN) => {
return a.reportDate.localeCompare(b.reportDate);
}
case clsvgs_PaperReportEN.con_UpdUser:
return (a: clsvgs_PaperReportEN, b: clsvgs_PaperReportEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsvgs_PaperReportEN.con_VersionCount:
return (a: clsvgs_PaperReportEN, b: clsvgs_PaperReportEN) => {
return a.versionCount-b.versionCount;
}
case clsvgs_PaperReportEN.con_OkCount:
return (a: clsvgs_PaperReportEN, b: clsvgs_PaperReportEN) => {
return a.okCount-b.okCount;
}
case clsvgs_PaperReportEN.con_AppraiseCount:
return (a: clsvgs_PaperReportEN, b: clsvgs_PaperReportEN) => {
return a.appraiseCount-b.appraiseCount;
}
case clsvgs_PaperReportEN.con_score:
return (a: clsvgs_PaperReportEN, b: clsvgs_PaperReportEN) => {
return a.score-b.score;
}
case clsvgs_PaperReportEN.con_StuScore:
return (a: clsvgs_PaperReportEN, b: clsvgs_PaperReportEN) => {
return a.stuScore-b.stuScore;
}
case clsvgs_PaperReportEN.con_TeaScore:
return (a: clsvgs_PaperReportEN, b: clsvgs_PaperReportEN) => {
return a.teaScore-b.teaScore;
}
case clsvgs_PaperReportEN.con_PDFUrl:
return (a: clsvgs_PaperReportEN, b: clsvgs_PaperReportEN) => {
return a.pdFUrl.localeCompare(b.pdFUrl);
}
case clsvgs_PaperReportEN.con_PPTUrl:
return (a: clsvgs_PaperReportEN, b: clsvgs_PaperReportEN) => {
return a.ppTUrl.localeCompare(b.ppTUrl);
}
case clsvgs_PaperReportEN.con_Month:
return (a: clsvgs_PaperReportEN, b: clsvgs_PaperReportEN) => {
return a.month.localeCompare(b.month);
}
case clsvgs_PaperReportEN.con_Week:
return (a: clsvgs_PaperReportEN, b: clsvgs_PaperReportEN) => {
return a.week-b.week;
}
case clsvgs_PaperReportEN.con_Year:
return (a: clsvgs_PaperReportEN, b: clsvgs_PaperReportEN) => {
return a.year.localeCompare(b.year);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vgs_PaperReport]中不存在！(in ${ vgs_PaperReport_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsvgs_PaperReportEN.con_Memo:
return (a: clsvgs_PaperReportEN, b: clsvgs_PaperReportEN) => {
return b.memo.localeCompare(a.memo);
}
case clsvgs_PaperReportEN.con_ReportId:
return (a: clsvgs_PaperReportEN, b: clsvgs_PaperReportEN) => {
return b.reportId.localeCompare(a.reportId);
}
case clsvgs_PaperReportEN.con_UpdDate:
return (a: clsvgs_PaperReportEN, b: clsvgs_PaperReportEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsvgs_PaperReportEN.con_TopicName:
return (a: clsvgs_PaperReportEN, b: clsvgs_PaperReportEN) => {
return b.topicName.localeCompare(a.topicName);
}
case clsvgs_PaperReportEN.con_TopicId:
return (a: clsvgs_PaperReportEN, b: clsvgs_PaperReportEN) => {
return b.topicId.localeCompare(a.topicId);
}
case clsvgs_PaperReportEN.con_PaperId:
return (a: clsvgs_PaperReportEN, b: clsvgs_PaperReportEN) => {
return b.paperId.localeCompare(a.paperId);
}
case clsvgs_PaperReportEN.con_PaperTitle:
return (a: clsvgs_PaperReportEN, b: clsvgs_PaperReportEN) => {
return b.paperTitle.localeCompare(a.paperTitle);
}
case clsvgs_PaperReportEN.con_ReportContent:
return (a: clsvgs_PaperReportEN, b: clsvgs_PaperReportEN) => {
return b.reportContent.localeCompare(a.reportContent);
}
case clsvgs_PaperReportEN.con_id_CurrEduCls:
return (a: clsvgs_PaperReportEN, b: clsvgs_PaperReportEN) => {
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
case clsvgs_PaperReportEN.con_IsSubmit:
return (a: clsvgs_PaperReportEN, b: clsvgs_PaperReportEN) => {
if (b.isSubmit == true) return 1;
else return -1
}
case clsvgs_PaperReportEN.con_ReportUser:
return (a: clsvgs_PaperReportEN, b: clsvgs_PaperReportEN) => {
return b.reportUser.localeCompare(a.reportUser);
}
case clsvgs_PaperReportEN.con_ReportDate:
return (a: clsvgs_PaperReportEN, b: clsvgs_PaperReportEN) => {
return b.reportDate.localeCompare(a.reportDate);
}
case clsvgs_PaperReportEN.con_UpdUser:
return (a: clsvgs_PaperReportEN, b: clsvgs_PaperReportEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsvgs_PaperReportEN.con_VersionCount:
return (a: clsvgs_PaperReportEN, b: clsvgs_PaperReportEN) => {
return b.versionCount-a.versionCount;
}
case clsvgs_PaperReportEN.con_OkCount:
return (a: clsvgs_PaperReportEN, b: clsvgs_PaperReportEN) => {
return b.okCount-a.okCount;
}
case clsvgs_PaperReportEN.con_AppraiseCount:
return (a: clsvgs_PaperReportEN, b: clsvgs_PaperReportEN) => {
return b.appraiseCount-a.appraiseCount;
}
case clsvgs_PaperReportEN.con_score:
return (a: clsvgs_PaperReportEN, b: clsvgs_PaperReportEN) => {
return b.score-a.score;
}
case clsvgs_PaperReportEN.con_StuScore:
return (a: clsvgs_PaperReportEN, b: clsvgs_PaperReportEN) => {
return b.stuScore-a.stuScore;
}
case clsvgs_PaperReportEN.con_TeaScore:
return (a: clsvgs_PaperReportEN, b: clsvgs_PaperReportEN) => {
return b.teaScore-a.teaScore;
}
case clsvgs_PaperReportEN.con_PDFUrl:
return (a: clsvgs_PaperReportEN, b: clsvgs_PaperReportEN) => {
return b.pdFUrl.localeCompare(a.pdFUrl);
}
case clsvgs_PaperReportEN.con_PPTUrl:
return (a: clsvgs_PaperReportEN, b: clsvgs_PaperReportEN) => {
return b.ppTUrl.localeCompare(a.ppTUrl);
}
case clsvgs_PaperReportEN.con_Month:
return (a: clsvgs_PaperReportEN, b: clsvgs_PaperReportEN) => {
return b.month.localeCompare(a.month);
}
case clsvgs_PaperReportEN.con_Week:
return (a: clsvgs_PaperReportEN, b: clsvgs_PaperReportEN) => {
return b.week-a.week;
}
case clsvgs_PaperReportEN.con_Year:
return (a: clsvgs_PaperReportEN, b: clsvgs_PaperReportEN) => {
return b.year.localeCompare(a.year);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vgs_PaperReport]中不存在！(in ${ vgs_PaperReport_ConstructorName}.${ strThisFuncName})`;
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
export async function vgs_PaperReport_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsvgs_PaperReportEN.con_Memo:
return (obj: clsvgs_PaperReportEN) => {
return obj.memo === value;
}
case clsvgs_PaperReportEN.con_ReportId:
return (obj: clsvgs_PaperReportEN) => {
return obj.reportId === value;
}
case clsvgs_PaperReportEN.con_UpdDate:
return (obj: clsvgs_PaperReportEN) => {
return obj.updDate === value;
}
case clsvgs_PaperReportEN.con_TopicName:
return (obj: clsvgs_PaperReportEN) => {
return obj.topicName === value;
}
case clsvgs_PaperReportEN.con_TopicId:
return (obj: clsvgs_PaperReportEN) => {
return obj.topicId === value;
}
case clsvgs_PaperReportEN.con_PaperId:
return (obj: clsvgs_PaperReportEN) => {
return obj.paperId === value;
}
case clsvgs_PaperReportEN.con_PaperTitle:
return (obj: clsvgs_PaperReportEN) => {
return obj.paperTitle === value;
}
case clsvgs_PaperReportEN.con_ReportContent:
return (obj: clsvgs_PaperReportEN) => {
return obj.reportContent === value;
}
case clsvgs_PaperReportEN.con_id_CurrEduCls:
return (obj: clsvgs_PaperReportEN) => {
return obj.id_CurrEduCls === value;
}
case clsvgs_PaperReportEN.con_IsSubmit:
return (obj: clsvgs_PaperReportEN) => {
return obj.isSubmit === value;
}
case clsvgs_PaperReportEN.con_ReportUser:
return (obj: clsvgs_PaperReportEN) => {
return obj.reportUser === value;
}
case clsvgs_PaperReportEN.con_ReportDate:
return (obj: clsvgs_PaperReportEN) => {
return obj.reportDate === value;
}
case clsvgs_PaperReportEN.con_UpdUser:
return (obj: clsvgs_PaperReportEN) => {
return obj.updUser === value;
}
case clsvgs_PaperReportEN.con_VersionCount:
return (obj: clsvgs_PaperReportEN) => {
return obj.versionCount === value;
}
case clsvgs_PaperReportEN.con_OkCount:
return (obj: clsvgs_PaperReportEN) => {
return obj.okCount === value;
}
case clsvgs_PaperReportEN.con_AppraiseCount:
return (obj: clsvgs_PaperReportEN) => {
return obj.appraiseCount === value;
}
case clsvgs_PaperReportEN.con_score:
return (obj: clsvgs_PaperReportEN) => {
return obj.score === value;
}
case clsvgs_PaperReportEN.con_StuScore:
return (obj: clsvgs_PaperReportEN) => {
return obj.stuScore === value;
}
case clsvgs_PaperReportEN.con_TeaScore:
return (obj: clsvgs_PaperReportEN) => {
return obj.teaScore === value;
}
case clsvgs_PaperReportEN.con_PDFUrl:
return (obj: clsvgs_PaperReportEN) => {
return obj.pdFUrl === value;
}
case clsvgs_PaperReportEN.con_PPTUrl:
return (obj: clsvgs_PaperReportEN) => {
return obj.ppTUrl === value;
}
case clsvgs_PaperReportEN.con_Month:
return (obj: clsvgs_PaperReportEN) => {
return obj.month === value;
}
case clsvgs_PaperReportEN.con_Week:
return (obj: clsvgs_PaperReportEN) => {
return obj.week === value;
}
case clsvgs_PaperReportEN.con_Year:
return (obj: clsvgs_PaperReportEN) => {
return obj.year === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vgs_PaperReport]中不存在！(in ${ vgs_PaperReport_ConstructorName}.${ strThisFuncName})`;
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
export async function vgs_PaperReport_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vgs_PaperReport_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PaperReport_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PaperReport_ConstructorName, strThisFuncName);
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
export async function vgs_PaperReport_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vgs_PaperReport_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PaperReport_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PaperReport_ConstructorName, strThisFuncName);
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
export async function vgs_PaperReport_GetFirstObjAsync(strWhereCond: string): Promise<clsvgs_PaperReportEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(vgs_PaperReport_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_PaperReport_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvgs_PaperReport = vgs_PaperReport_GetObjFromJsonObj(returnObj);
return objvgs_PaperReport;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PaperReport_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PaperReport_ConstructorName, strThisFuncName);
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
export async function vgs_PaperReport_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvgs_PaperReportEN._CurrTabName;
clsvgs_PaperReportEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvgs_PaperReportEN._CurrTabName);
if (IsNullOrEmpty(clsvgs_PaperReportEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvgs_PaperReportEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrvgs_PaperReportExObjLst_Cache: Array<clsvgs_PaperReportEN> = CacheHelper.Get(strKey);
const arrvgs_PaperReportObjLst_T = vgs_PaperReport_GetObjLstByJSONObjLst(arrvgs_PaperReportExObjLst_Cache);
return arrvgs_PaperReportObjLst_T;
}
try
{
const arrvgs_PaperReportExObjLst = await vgs_PaperReport_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrvgs_PaperReportExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvgs_PaperReportExObjLst.length);
console.log(strInfo);
return arrvgs_PaperReportExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vgs_PaperReport_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vgs_PaperReport_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvgs_PaperReportEN._CurrTabName;
clsvgs_PaperReportEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvgs_PaperReportEN._CurrTabName);
if (IsNullOrEmpty(clsvgs_PaperReportEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvgs_PaperReportEN.CacheAddiCondition);
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
const arrvgs_PaperReportExObjLst_Cache: Array<clsvgs_PaperReportEN> = JSON.parse(strTempObjLst);
const arrvgs_PaperReportObjLst_T = vgs_PaperReport_GetObjLstByJSONObjLst(arrvgs_PaperReportExObjLst_Cache);
return arrvgs_PaperReportObjLst_T;
}
try
{
const arrvgs_PaperReportExObjLst = await vgs_PaperReport_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrvgs_PaperReportExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvgs_PaperReportExObjLst.length);
console.log(strInfo);
return arrvgs_PaperReportExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vgs_PaperReport_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vgs_PaperReport_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsvgs_PaperReportEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrvgs_PaperReportObjLst_Cache: Array<clsvgs_PaperReportEN> = JSON.parse(strTempObjLst);
return arrvgs_PaperReportObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function vgs_PaperReport_GetObjLstAsync(strWhereCond: string): Promise<Array<clsvgs_PaperReportEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(vgs_PaperReport_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_PaperReport_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vgs_PaperReport_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PaperReport_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PaperReport_ConstructorName, strThisFuncName);
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
export async function vgs_PaperReport_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvgs_PaperReportEN._CurrTabName;
clsvgs_PaperReportEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvgs_PaperReportEN._CurrTabName);
if (IsNullOrEmpty(clsvgs_PaperReportEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvgs_PaperReportEN.CacheAddiCondition);
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
const arrvgs_PaperReportExObjLst_Cache: Array<clsvgs_PaperReportEN> = JSON.parse(strTempObjLst);
const arrvgs_PaperReportObjLst_T = vgs_PaperReport_GetObjLstByJSONObjLst(arrvgs_PaperReportExObjLst_Cache);
return arrvgs_PaperReportObjLst_T;
}
try
{
const arrvgs_PaperReportExObjLst = await vgs_PaperReport_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrvgs_PaperReportExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvgs_PaperReportExObjLst.length);
console.log(strInfo);
return arrvgs_PaperReportExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vgs_PaperReport_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vgs_PaperReport_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsvgs_PaperReportEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrvgs_PaperReportObjLst_Cache: Array<clsvgs_PaperReportEN> = JSON.parse(strTempObjLst);
return arrvgs_PaperReportObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vgs_PaperReport_GetObjLst_Cache(): Promise<Array<clsvgs_PaperReportEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrvgs_PaperReportObjLst_Cache;
switch (clsvgs_PaperReportEN.CacheModeId)
{
case "04"://sessionStorage
arrvgs_PaperReportObjLst_Cache = await vgs_PaperReport_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrvgs_PaperReportObjLst_Cache = await vgs_PaperReport_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrvgs_PaperReportObjLst_Cache = await vgs_PaperReport_GetObjLst_ClientCache();
break;
default:
arrvgs_PaperReportObjLst_Cache = await vgs_PaperReport_GetObjLst_ClientCache();
break;
}
const arrvgs_PaperReportObjLst = vgs_PaperReport_GetObjLstByJSONObjLst(arrvgs_PaperReportObjLst_Cache);
return arrvgs_PaperReportObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vgs_PaperReport_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrvgs_PaperReportObjLst_Cache;
switch (clsvgs_PaperReportEN.CacheModeId)
{
case "04"://sessionStorage
arrvgs_PaperReportObjLst_Cache = await vgs_PaperReport_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrvgs_PaperReportObjLst_Cache = await vgs_PaperReport_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrvgs_PaperReportObjLst_Cache = null;
break;
default:
arrvgs_PaperReportObjLst_Cache = null;
break;
}
return arrvgs_PaperReportObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrReportId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vgs_PaperReport_GetSubObjLst_Cache(objvgs_PaperReport_Cond: clsvgs_PaperReportEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrvgs_PaperReportObjLst_Cache = await vgs_PaperReport_GetObjLst_Cache();
let arrvgs_PaperReport_Sel: Array < clsvgs_PaperReportEN > = arrvgs_PaperReportObjLst_Cache;
if (objvgs_PaperReport_Cond.sf_FldComparisonOp == null || objvgs_PaperReport_Cond.sf_FldComparisonOp == "") return arrvgs_PaperReport_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvgs_PaperReport_Cond.sf_FldComparisonOp);
//console.log("clsvgs_PaperReportWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvgs_PaperReport_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvgs_PaperReport_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvgs_PaperReport_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objvgs_PaperReport_Cond), vgs_PaperReport_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvgs_PaperReportEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrReportId:关键字列表
 * @returns 对象列表
 **/
export async function vgs_PaperReport_GetObjLstByReportIdLstAsync(arrReportId: Array<string>): Promise<Array<clsvgs_PaperReportEN>>  
{
const strThisFuncName = "GetObjLstByReportIdLstAsync";
const strAction = "GetObjLstByReportIdLst";
const strUrl = GetWebApiUrl(vgs_PaperReport_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrReportId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_PaperReport_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vgs_PaperReport_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PaperReport_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PaperReport_ConstructorName, strThisFuncName);
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
export async function vgs_PaperReport_GetObjLstByReportIdLst_Cache(arrReportIdLst: Array<string>) {
const strThisFuncName = "GetObjLstByReportIdLst_Cache";
try
{
const arrvgs_PaperReportObjLst_Cache = await vgs_PaperReport_GetObjLst_Cache();
const arrvgs_PaperReport_Sel: Array <clsvgs_PaperReportEN> = arrvgs_PaperReportObjLst_Cache.filter(x => arrReportIdLst.indexOf(x.reportId)>-1);
return arrvgs_PaperReport_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrReportIdLst.join(","), vgs_PaperReport_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvgs_PaperReportEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function vgs_PaperReport_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsvgs_PaperReportEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(vgs_PaperReport_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_PaperReport_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vgs_PaperReport_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PaperReport_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PaperReport_ConstructorName, strThisFuncName);
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
export async function vgs_PaperReport_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsvgs_PaperReportEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vgs_PaperReport_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_PaperReport_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vgs_PaperReport_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PaperReport_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PaperReport_ConstructorName, strThisFuncName);
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
export async function vgs_PaperReport_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vgs_PaperReport_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PaperReport_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PaperReport_ConstructorName, strThisFuncName);
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
export async function vgs_PaperReport_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrvgs_PaperReportObjLst_Cache = await vgs_PaperReport_GetObjLst_Cache();
if (arrvgs_PaperReportObjLst_Cache.length == 0) return arrvgs_PaperReportObjLst_Cache;
let arrvgs_PaperReport_Sel = arrvgs_PaperReportObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objvgs_PaperReport_Cond = new clsvgs_PaperReportEN();
ObjectAssign(objvgs_PaperReport_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsvgs_PaperReportWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvgs_PaperReport_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvgs_PaperReport_Sel.length == 0) return arrvgs_PaperReport_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.sort(vgs_PaperReport_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.sort(objPagerPara.sortFun);
}
arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.slice(intStart, intEnd);     
return arrvgs_PaperReport_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, vgs_PaperReport_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvgs_PaperReportEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function vgs_PaperReport_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsvgs_PaperReportEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(vgs_PaperReport_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_PaperReport_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vgs_PaperReport_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PaperReport_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PaperReport_ConstructorName, strThisFuncName);
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
export async function vgs_PaperReport_IsExistRecord_Cache(objvgs_PaperReport_Cond: clsvgs_PaperReportEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrvgs_PaperReportObjLst_Cache = await vgs_PaperReport_GetObjLst_Cache();
if (arrvgs_PaperReportObjLst_Cache == null) return false;
let arrvgs_PaperReport_Sel: Array < clsvgs_PaperReportEN > = arrvgs_PaperReportObjLst_Cache;
if (objvgs_PaperReport_Cond.sf_FldComparisonOp == null || objvgs_PaperReport_Cond.sf_FldComparisonOp == "") return arrvgs_PaperReport_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvgs_PaperReport_Cond.sf_FldComparisonOp);
//console.log("clsvgs_PaperReportWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvgs_PaperReport_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvgs_PaperReport_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvgs_PaperReport_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objvgs_PaperReport_Cond), vgs_PaperReport_ConstructorName, strThisFuncName);
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
export async function vgs_PaperReport_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(vgs_PaperReport_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PaperReport_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PaperReport_ConstructorName, strThisFuncName);
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
export async function vgs_PaperReport_IsExist(strReportId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vgs_PaperReport_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PaperReport_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PaperReport_ConstructorName, strThisFuncName);
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
export async function vgs_PaperReport_IsExist_Cache(strReportId:string) {
const strThisFuncName = "IsExist_Cache";
const arrvgs_PaperReportObjLst_Cache = await vgs_PaperReport_GetObjLst_Cache();
if (arrvgs_PaperReportObjLst_Cache == null) return false;
try
{
const arrvgs_PaperReport_Sel: Array <clsvgs_PaperReportEN> = arrvgs_PaperReportObjLst_Cache.filter(x => x.reportId == strReportId);
if (arrvgs_PaperReport_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strReportId, vgs_PaperReport_ConstructorName, strThisFuncName);
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
export async function vgs_PaperReport_IsExistAsync(strReportId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vgs_PaperReport_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PaperReport_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PaperReport_ConstructorName, strThisFuncName);
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
export async function vgs_PaperReport_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(vgs_PaperReport_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PaperReport_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PaperReport_ConstructorName, strThisFuncName);
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
 * @param objvgs_PaperReport_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function vgs_PaperReport_GetRecCountByCond_Cache(objvgs_PaperReport_Cond: clsvgs_PaperReportEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrvgs_PaperReportObjLst_Cache = await vgs_PaperReport_GetObjLst_Cache();
if (arrvgs_PaperReportObjLst_Cache == null) return 0;
let arrvgs_PaperReport_Sel: Array < clsvgs_PaperReportEN > = arrvgs_PaperReportObjLst_Cache;
if (objvgs_PaperReport_Cond.sf_FldComparisonOp == null || objvgs_PaperReport_Cond.sf_FldComparisonOp == "") return arrvgs_PaperReport_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvgs_PaperReport_Cond.sf_FldComparisonOp);
//console.log("clsvgs_PaperReportWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvgs_PaperReport_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvgs_PaperReport_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvgs_PaperReport_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objvgs_PaperReport_Cond), vgs_PaperReport_ConstructorName, strThisFuncName);
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
export function vgs_PaperReport_GetWebApiUrl(strController: string, strAction: string): string {
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
export function vgs_PaperReport_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clsvgs_PaperReportEN._CurrTabName;
switch (clsvgs_PaperReportEN.CacheModeId)
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
export function vgs_PaperReport_GetJSONStrByObj (pobjvgs_PaperReportEN: clsvgs_PaperReportEN): string
{
const strThisFuncName = "GetJSONStrByObj";
let strJson = "";
try
{
strJson = JSON.stringify(pobjvgs_PaperReportEN);
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
export function vgs_PaperReport_GetObjLstByJSONStr (strJSON: string): Array<clsvgs_PaperReportEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrvgs_PaperReportObjLst = new Array<clsvgs_PaperReportEN>();
if (strJSON === "")
{
return arrvgs_PaperReportObjLst;
}
try
{
arrvgs_PaperReportObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvgs_PaperReportObjLst;
}
return arrvgs_PaperReportObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrvgs_PaperReportObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function vgs_PaperReport_GetObjLstByJSONObjLst (arrvgs_PaperReportObjLstS: Array<clsvgs_PaperReportEN>): Array<clsvgs_PaperReportEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrvgs_PaperReportObjLst = new Array<clsvgs_PaperReportEN>();
for (const objInFor of arrvgs_PaperReportObjLstS) {
const obj1 = vgs_PaperReport_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrvgs_PaperReportObjLst.push(obj1);
}
return arrvgs_PaperReportObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vgs_PaperReport_GetObjByJSONStr (strJSON: string): clsvgs_PaperReportEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjvgs_PaperReportEN = new clsvgs_PaperReportEN();
if (strJSON === "")
{
return pobjvgs_PaperReportEN;
}
try
{
pobjvgs_PaperReportEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvgs_PaperReportEN;
}
return pobjvgs_PaperReportEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function vgs_PaperReport_GetCombineCondition(objvgs_PaperReport_Cond: clsvgs_PaperReportEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objvgs_PaperReport_Cond.dicFldComparisonOp, clsvgs_PaperReportEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objvgs_PaperReport_Cond.dicFldComparisonOp[clsvgs_PaperReportEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PaperReportEN.con_Memo, objvgs_PaperReport_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperReport_Cond.dicFldComparisonOp, clsvgs_PaperReportEN.con_ReportId) == true)
{
const strComparisonOp_ReportId:string = objvgs_PaperReport_Cond.dicFldComparisonOp[clsvgs_PaperReportEN.con_ReportId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PaperReportEN.con_ReportId, objvgs_PaperReport_Cond.reportId, strComparisonOp_ReportId);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperReport_Cond.dicFldComparisonOp, clsvgs_PaperReportEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objvgs_PaperReport_Cond.dicFldComparisonOp[clsvgs_PaperReportEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PaperReportEN.con_UpdDate, objvgs_PaperReport_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperReport_Cond.dicFldComparisonOp, clsvgs_PaperReportEN.con_TopicName) == true)
{
const strComparisonOp_TopicName:string = objvgs_PaperReport_Cond.dicFldComparisonOp[clsvgs_PaperReportEN.con_TopicName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PaperReportEN.con_TopicName, objvgs_PaperReport_Cond.topicName, strComparisonOp_TopicName);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperReport_Cond.dicFldComparisonOp, clsvgs_PaperReportEN.con_TopicId) == true)
{
const strComparisonOp_TopicId:string = objvgs_PaperReport_Cond.dicFldComparisonOp[clsvgs_PaperReportEN.con_TopicId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PaperReportEN.con_TopicId, objvgs_PaperReport_Cond.topicId, strComparisonOp_TopicId);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperReport_Cond.dicFldComparisonOp, clsvgs_PaperReportEN.con_PaperId) == true)
{
const strComparisonOp_PaperId:string = objvgs_PaperReport_Cond.dicFldComparisonOp[clsvgs_PaperReportEN.con_PaperId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PaperReportEN.con_PaperId, objvgs_PaperReport_Cond.paperId, strComparisonOp_PaperId);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperReport_Cond.dicFldComparisonOp, clsvgs_PaperReportEN.con_PaperTitle) == true)
{
const strComparisonOp_PaperTitle:string = objvgs_PaperReport_Cond.dicFldComparisonOp[clsvgs_PaperReportEN.con_PaperTitle];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PaperReportEN.con_PaperTitle, objvgs_PaperReport_Cond.paperTitle, strComparisonOp_PaperTitle);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperReport_Cond.dicFldComparisonOp, clsvgs_PaperReportEN.con_ReportContent) == true)
{
const strComparisonOp_ReportContent:string = objvgs_PaperReport_Cond.dicFldComparisonOp[clsvgs_PaperReportEN.con_ReportContent];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PaperReportEN.con_ReportContent, objvgs_PaperReport_Cond.reportContent, strComparisonOp_ReportContent);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperReport_Cond.dicFldComparisonOp, clsvgs_PaperReportEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objvgs_PaperReport_Cond.dicFldComparisonOp[clsvgs_PaperReportEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PaperReportEN.con_id_CurrEduCls, objvgs_PaperReport_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperReport_Cond.dicFldComparisonOp, clsvgs_PaperReportEN.con_IsSubmit) == true)
{
if (objvgs_PaperReport_Cond.isSubmit == true)
{
strWhereCond += Format(" And {0} = '1'", clsvgs_PaperReportEN.con_IsSubmit);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvgs_PaperReportEN.con_IsSubmit);
}
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperReport_Cond.dicFldComparisonOp, clsvgs_PaperReportEN.con_ReportUser) == true)
{
const strComparisonOp_ReportUser:string = objvgs_PaperReport_Cond.dicFldComparisonOp[clsvgs_PaperReportEN.con_ReportUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PaperReportEN.con_ReportUser, objvgs_PaperReport_Cond.reportUser, strComparisonOp_ReportUser);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperReport_Cond.dicFldComparisonOp, clsvgs_PaperReportEN.con_ReportDate) == true)
{
const strComparisonOp_ReportDate:string = objvgs_PaperReport_Cond.dicFldComparisonOp[clsvgs_PaperReportEN.con_ReportDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PaperReportEN.con_ReportDate, objvgs_PaperReport_Cond.reportDate, strComparisonOp_ReportDate);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperReport_Cond.dicFldComparisonOp, clsvgs_PaperReportEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objvgs_PaperReport_Cond.dicFldComparisonOp[clsvgs_PaperReportEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PaperReportEN.con_UpdUser, objvgs_PaperReport_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperReport_Cond.dicFldComparisonOp, clsvgs_PaperReportEN.con_VersionCount) == true)
{
const strComparisonOp_VersionCount:string = objvgs_PaperReport_Cond.dicFldComparisonOp[clsvgs_PaperReportEN.con_VersionCount];
strWhereCond += Format(" And {0} {2} {1}", clsvgs_PaperReportEN.con_VersionCount, objvgs_PaperReport_Cond.versionCount, strComparisonOp_VersionCount);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperReport_Cond.dicFldComparisonOp, clsvgs_PaperReportEN.con_OkCount) == true)
{
const strComparisonOp_OkCount:string = objvgs_PaperReport_Cond.dicFldComparisonOp[clsvgs_PaperReportEN.con_OkCount];
strWhereCond += Format(" And {0} {2} {1}", clsvgs_PaperReportEN.con_OkCount, objvgs_PaperReport_Cond.okCount, strComparisonOp_OkCount);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperReport_Cond.dicFldComparisonOp, clsvgs_PaperReportEN.con_AppraiseCount) == true)
{
const strComparisonOp_AppraiseCount:string = objvgs_PaperReport_Cond.dicFldComparisonOp[clsvgs_PaperReportEN.con_AppraiseCount];
strWhereCond += Format(" And {0} {2} {1}", clsvgs_PaperReportEN.con_AppraiseCount, objvgs_PaperReport_Cond.appraiseCount, strComparisonOp_AppraiseCount);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperReport_Cond.dicFldComparisonOp, clsvgs_PaperReportEN.con_score) == true)
{
const strComparisonOp_score:string = objvgs_PaperReport_Cond.dicFldComparisonOp[clsvgs_PaperReportEN.con_score];
strWhereCond += Format(" And {0} {2} {1}", clsvgs_PaperReportEN.con_score, objvgs_PaperReport_Cond.score, strComparisonOp_score);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperReport_Cond.dicFldComparisonOp, clsvgs_PaperReportEN.con_StuScore) == true)
{
const strComparisonOp_StuScore:string = objvgs_PaperReport_Cond.dicFldComparisonOp[clsvgs_PaperReportEN.con_StuScore];
strWhereCond += Format(" And {0} {2} {1}", clsvgs_PaperReportEN.con_StuScore, objvgs_PaperReport_Cond.stuScore, strComparisonOp_StuScore);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperReport_Cond.dicFldComparisonOp, clsvgs_PaperReportEN.con_TeaScore) == true)
{
const strComparisonOp_TeaScore:string = objvgs_PaperReport_Cond.dicFldComparisonOp[clsvgs_PaperReportEN.con_TeaScore];
strWhereCond += Format(" And {0} {2} {1}", clsvgs_PaperReportEN.con_TeaScore, objvgs_PaperReport_Cond.teaScore, strComparisonOp_TeaScore);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperReport_Cond.dicFldComparisonOp, clsvgs_PaperReportEN.con_PDFUrl) == true)
{
const strComparisonOp_PDFUrl:string = objvgs_PaperReport_Cond.dicFldComparisonOp[clsvgs_PaperReportEN.con_PDFUrl];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PaperReportEN.con_PDFUrl, objvgs_PaperReport_Cond.pdFUrl, strComparisonOp_PDFUrl);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperReport_Cond.dicFldComparisonOp, clsvgs_PaperReportEN.con_PPTUrl) == true)
{
const strComparisonOp_PPTUrl:string = objvgs_PaperReport_Cond.dicFldComparisonOp[clsvgs_PaperReportEN.con_PPTUrl];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PaperReportEN.con_PPTUrl, objvgs_PaperReport_Cond.ppTUrl, strComparisonOp_PPTUrl);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperReport_Cond.dicFldComparisonOp, clsvgs_PaperReportEN.con_Month) == true)
{
const strComparisonOp_Month:string = objvgs_PaperReport_Cond.dicFldComparisonOp[clsvgs_PaperReportEN.con_Month];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PaperReportEN.con_Month, objvgs_PaperReport_Cond.month, strComparisonOp_Month);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperReport_Cond.dicFldComparisonOp, clsvgs_PaperReportEN.con_Week) == true)
{
const strComparisonOp_Week:string = objvgs_PaperReport_Cond.dicFldComparisonOp[clsvgs_PaperReportEN.con_Week];
strWhereCond += Format(" And {0} {2} {1}", clsvgs_PaperReportEN.con_Week, objvgs_PaperReport_Cond.week, strComparisonOp_Week);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperReport_Cond.dicFldComparisonOp, clsvgs_PaperReportEN.con_Year) == true)
{
const strComparisonOp_Year:string = objvgs_PaperReport_Cond.dicFldComparisonOp[clsvgs_PaperReportEN.con_Year];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PaperReportEN.con_Year, objvgs_PaperReport_Cond.year, strComparisonOp_Year);
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objvgs_PaperReportENS:源对象
 * @param objvgs_PaperReportENT:目标对象
*/
export function vgs_PaperReport_CopyObjTo(objvgs_PaperReportENS: clsvgs_PaperReportEN , objvgs_PaperReportENT: clsvgs_PaperReportEN ): void 
{
objvgs_PaperReportENT.memo = objvgs_PaperReportENS.memo; //备注
objvgs_PaperReportENT.reportId = objvgs_PaperReportENS.reportId; //汇报Id
objvgs_PaperReportENT.updDate = objvgs_PaperReportENS.updDate; //修改日期
objvgs_PaperReportENT.topicName = objvgs_PaperReportENS.topicName; //栏目主题
objvgs_PaperReportENT.topicId = objvgs_PaperReportENS.topicId; //主题Id
objvgs_PaperReportENT.paperId = objvgs_PaperReportENS.paperId; //论文Id
objvgs_PaperReportENT.paperTitle = objvgs_PaperReportENS.paperTitle; //论文标题
objvgs_PaperReportENT.reportContent = objvgs_PaperReportENS.reportContent; //汇报内容
objvgs_PaperReportENT.id_CurrEduCls = objvgs_PaperReportENS.id_CurrEduCls; //教学班流水号
objvgs_PaperReportENT.isSubmit = objvgs_PaperReportENS.isSubmit; //是否提交
objvgs_PaperReportENT.reportUser = objvgs_PaperReportENS.reportUser; //汇报用户
objvgs_PaperReportENT.reportDate = objvgs_PaperReportENS.reportDate; //汇报日期
objvgs_PaperReportENT.updUser = objvgs_PaperReportENS.updUser; //修改人
objvgs_PaperReportENT.versionCount = objvgs_PaperReportENS.versionCount; //版本统计
objvgs_PaperReportENT.okCount = objvgs_PaperReportENS.okCount; //点赞统计
objvgs_PaperReportENT.appraiseCount = objvgs_PaperReportENS.appraiseCount; //评论数
objvgs_PaperReportENT.score = objvgs_PaperReportENS.score; //评分
objvgs_PaperReportENT.stuScore = objvgs_PaperReportENS.stuScore; //学生平均分
objvgs_PaperReportENT.teaScore = objvgs_PaperReportENS.teaScore; //教师评分
objvgs_PaperReportENT.pdFUrl = objvgs_PaperReportENS.pdFUrl; //PDFUrl
objvgs_PaperReportENT.ppTUrl = objvgs_PaperReportENS.ppTUrl; //PPTUrl
objvgs_PaperReportENT.month = objvgs_PaperReportENS.month; //月
objvgs_PaperReportENT.week = objvgs_PaperReportENS.week; //周
objvgs_PaperReportENT.year = objvgs_PaperReportENS.year; //年
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objvgs_PaperReportENS:源对象
 * @param objvgs_PaperReportENT:目标对象
*/
export function vgs_PaperReport_GetObjFromJsonObj(objvgs_PaperReportENS: clsvgs_PaperReportEN): clsvgs_PaperReportEN 
{
 const objvgs_PaperReportENT: clsvgs_PaperReportEN = new clsvgs_PaperReportEN();
ObjectAssign(objvgs_PaperReportENT, objvgs_PaperReportENS);
 return objvgs_PaperReportENT;
}