
 /**
 * 类名:clsvgs_ResearchResultWApi
 * 表名:vgs_ResearchResult(01120778)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 15:53:08
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
 * 研究成果视图(vgs_ResearchResult)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clsvgs_ResearchResultEN } from "../../L0_Entity/GraduateEduTopic/clsvgs_ResearchResultEN.js";
import { BindDdl_ObjLstInDiv_V, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const vgs_ResearchResult_Controller = "vgs_ResearchResultApi";
 export const vgs_ResearchResult_ConstructorName = "vgs_ResearchResult";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strResultId:关键字
 * @returns 对象
 **/
export async function vgs_ResearchResult_GetObjByResultIdAsync(strResultId: string): Promise<clsvgs_ResearchResultEN>  
{
const strThisFuncName = "GetObjByResultIdAsync";

if (IsNullOrEmpty(strResultId) == true)
{
  const strMsg = Format("参数:[strResultId]不能为空！(In GetObjByResultIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strResultId.length != 10)
{
const strMsg = Format("缓存分类变量:[strResultId]的长度:[{0}]不正确！", strResultId.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByResultId";
const strUrl = GetWebApiUrl(vgs_ResearchResult_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strResultId": strResultId,
}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObj = data.returnObj;
if (returnObj == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_ResearchResult_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvgs_ResearchResult = vgs_ResearchResult_GetObjFromJsonObj(returnObj);
return objvgs_ResearchResult;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_ResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_ResearchResult_ConstructorName, strThisFuncName);
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
 * @param strResultId:所给的关键字
 * @returns 对象
*/
export async function vgs_ResearchResult_GetObjByResultId_Cache(strResultId: string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByResultId_Cache";

if (IsNullOrEmpty(strResultId) == true)
{
  const strMsg = Format("参数:[strResultId]不能为空！(In GetObjByResultId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strResultId.length != 10)
{
const strMsg = Format("缓存分类变量:[strResultId]的长度:[{0}]不正确！", strResultId.length);
console.error(strMsg);
throw (strMsg);
}
const arrvgs_ResearchResultObjLst_Cache = await vgs_ResearchResult_GetObjLst_Cache();
try
{
const arrvgs_ResearchResult_Sel: Array <clsvgs_ResearchResultEN> = arrvgs_ResearchResultObjLst_Cache.filter(x => x.resultId == strResultId);
let objvgs_ResearchResult: clsvgs_ResearchResultEN;
if (arrvgs_ResearchResult_Sel.length > 0)
{
objvgs_ResearchResult = arrvgs_ResearchResult_Sel[0];
return objvgs_ResearchResult;
}
else
{
if (bolTryAsyncOnce == true)
{
objvgs_ResearchResult = await vgs_ResearchResult_GetObjByResultIdAsync(strResultId);
if (objvgs_ResearchResult != null)
{
vgs_ResearchResult_ReFreshThisCache();
return objvgs_ResearchResult;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strResultId, vgs_ResearchResult_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param strResultId:所给的关键字
 * @returns 对象
*/
export async function vgs_ResearchResult_GetObjByResultId_localStorage(strResultId: string) {
const strThisFuncName = "GetObjByResultId_localStorage";

if (IsNullOrEmpty(strResultId) == true)
{
  const strMsg = Format("参数:[strResultId]不能为空！(In GetObjByResultId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
if (strResultId.length != 10)
{
const strMsg = Format("缓存分类变量:[strResultId]的长度:[{0}]不正确！", strResultId.length);
console.error(strMsg);
throw (strMsg);
}
const strKey = Format("{0}_{1}", clsvgs_ResearchResultEN._CurrTabName, strResultId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objvgs_ResearchResult_Cache: clsvgs_ResearchResultEN = JSON.parse(strTempObj);
return objvgs_ResearchResult_Cache;
}
try
{
const objvgs_ResearchResult = await vgs_ResearchResult_GetObjByResultIdAsync(strResultId);
if (objvgs_ResearchResult != null)
{
localStorage.setItem(strKey, JSON.stringify(objvgs_ResearchResult));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objvgs_ResearchResult;
}
return objvgs_ResearchResult;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strResultId, vgs_ResearchResult_ConstructorName, strThisFuncName);
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
export async function vgs_ResearchResult_func(strInFldName:string , strOutFldName:string ,  strInValue: string) 
{
//const strThisFuncName = "func";

if (strInFldName != clsvgs_ResearchResultEN.con_ResultId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsvgs_ResearchResultEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clsvgs_ResearchResultEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strResultId = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objvgs_ResearchResult = await vgs_ResearchResult_GetObjByResultId_Cache(strResultId );
if (objvgs_ResearchResult == null) return "";
return objvgs_ResearchResult.GetFldValue(strOutFldName).toString();
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
export function vgs_ResearchResult_SortFun_Defa(a:clsvgs_ResearchResultEN , b:clsvgs_ResearchResultEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.resultId.localeCompare(b.resultId);
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
export function vgs_ResearchResult_SortFun_Defa_2Fld(a:clsvgs_ResearchResultEN , b:clsvgs_ResearchResultEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.topicId == b.topicId) return a.topicName.localeCompare(b.topicName);
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
export function vgs_ResearchResult_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsvgs_ResearchResultEN.con_ResultId:
return (a: clsvgs_ResearchResultEN, b: clsvgs_ResearchResultEN) => {
return a.resultId.localeCompare(b.resultId);
}
case clsvgs_ResearchResultEN.con_TopicId:
return (a: clsvgs_ResearchResultEN, b: clsvgs_ResearchResultEN) => {
return a.topicId.localeCompare(b.topicId);
}
case clsvgs_ResearchResultEN.con_TopicName:
return (a: clsvgs_ResearchResultEN, b: clsvgs_ResearchResultEN) => {
return a.topicName.localeCompare(b.topicName);
}
case clsvgs_ResearchResultEN.con_PaperId:
return (a: clsvgs_ResearchResultEN, b: clsvgs_ResearchResultEN) => {
return a.paperId.localeCompare(b.paperId);
}
case clsvgs_ResearchResultEN.con_id_CurrEduCls:
return (a: clsvgs_ResearchResultEN, b: clsvgs_ResearchResultEN) => {
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
case clsvgs_ResearchResultEN.con_ResultTypeId:
return (a: clsvgs_ResearchResultEN, b: clsvgs_ResearchResultEN) => {
return a.resultTypeId.localeCompare(b.resultTypeId);
}
case clsvgs_ResearchResultEN.con_ResultName:
return (a: clsvgs_ResearchResultEN, b: clsvgs_ResearchResultEN) => {
return a.resultName.localeCompare(b.resultName);
}
case clsvgs_ResearchResultEN.con_ResultContent:
return (a: clsvgs_ResearchResultEN, b: clsvgs_ResearchResultEN) => {
return a.resultContent.localeCompare(b.resultContent);
}
case clsvgs_ResearchResultEN.con_Author:
return (a: clsvgs_ResearchResultEN, b: clsvgs_ResearchResultEN) => {
return a.author.localeCompare(b.author);
}
case clsvgs_ResearchResultEN.con_Division:
return (a: clsvgs_ResearchResultEN, b: clsvgs_ResearchResultEN) => {
return a.division.localeCompare(b.division);
}
case clsvgs_ResearchResultEN.con_VersionCount:
return (a: clsvgs_ResearchResultEN, b: clsvgs_ResearchResultEN) => {
return a.versionCount-b.versionCount;
}
case clsvgs_ResearchResultEN.con_OkCount:
return (a: clsvgs_ResearchResultEN, b: clsvgs_ResearchResultEN) => {
return a.okCount-b.okCount;
}
case clsvgs_ResearchResultEN.con_AppraiseCount:
return (a: clsvgs_ResearchResultEN, b: clsvgs_ResearchResultEN) => {
return a.appraiseCount-b.appraiseCount;
}
case clsvgs_ResearchResultEN.con_score:
return (a: clsvgs_ResearchResultEN, b: clsvgs_ResearchResultEN) => {
return a.score-b.score;
}
case clsvgs_ResearchResultEN.con_StuScore:
return (a: clsvgs_ResearchResultEN, b: clsvgs_ResearchResultEN) => {
return a.stuScore-b.stuScore;
}
case clsvgs_ResearchResultEN.con_TeaScore:
return (a: clsvgs_ResearchResultEN, b: clsvgs_ResearchResultEN) => {
return a.teaScore-b.teaScore;
}
case clsvgs_ResearchResultEN.con_UpdDate:
return (a: clsvgs_ResearchResultEN, b: clsvgs_ResearchResultEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsvgs_ResearchResultEN.con_UpdUser:
return (a: clsvgs_ResearchResultEN, b: clsvgs_ResearchResultEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsvgs_ResearchResultEN.con_Memo:
return (a: clsvgs_ResearchResultEN, b: clsvgs_ResearchResultEN) => {
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vgs_ResearchResult]中不存在！(in ${ vgs_ResearchResult_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsvgs_ResearchResultEN.con_ResultId:
return (a: clsvgs_ResearchResultEN, b: clsvgs_ResearchResultEN) => {
return b.resultId.localeCompare(a.resultId);
}
case clsvgs_ResearchResultEN.con_TopicId:
return (a: clsvgs_ResearchResultEN, b: clsvgs_ResearchResultEN) => {
return b.topicId.localeCompare(a.topicId);
}
case clsvgs_ResearchResultEN.con_TopicName:
return (a: clsvgs_ResearchResultEN, b: clsvgs_ResearchResultEN) => {
return b.topicName.localeCompare(a.topicName);
}
case clsvgs_ResearchResultEN.con_PaperId:
return (a: clsvgs_ResearchResultEN, b: clsvgs_ResearchResultEN) => {
return b.paperId.localeCompare(a.paperId);
}
case clsvgs_ResearchResultEN.con_id_CurrEduCls:
return (a: clsvgs_ResearchResultEN, b: clsvgs_ResearchResultEN) => {
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
case clsvgs_ResearchResultEN.con_ResultTypeId:
return (a: clsvgs_ResearchResultEN, b: clsvgs_ResearchResultEN) => {
return b.resultTypeId.localeCompare(a.resultTypeId);
}
case clsvgs_ResearchResultEN.con_ResultName:
return (a: clsvgs_ResearchResultEN, b: clsvgs_ResearchResultEN) => {
return b.resultName.localeCompare(a.resultName);
}
case clsvgs_ResearchResultEN.con_ResultContent:
return (a: clsvgs_ResearchResultEN, b: clsvgs_ResearchResultEN) => {
return b.resultContent.localeCompare(a.resultContent);
}
case clsvgs_ResearchResultEN.con_Author:
return (a: clsvgs_ResearchResultEN, b: clsvgs_ResearchResultEN) => {
return b.author.localeCompare(a.author);
}
case clsvgs_ResearchResultEN.con_Division:
return (a: clsvgs_ResearchResultEN, b: clsvgs_ResearchResultEN) => {
return b.division.localeCompare(a.division);
}
case clsvgs_ResearchResultEN.con_VersionCount:
return (a: clsvgs_ResearchResultEN, b: clsvgs_ResearchResultEN) => {
return b.versionCount-a.versionCount;
}
case clsvgs_ResearchResultEN.con_OkCount:
return (a: clsvgs_ResearchResultEN, b: clsvgs_ResearchResultEN) => {
return b.okCount-a.okCount;
}
case clsvgs_ResearchResultEN.con_AppraiseCount:
return (a: clsvgs_ResearchResultEN, b: clsvgs_ResearchResultEN) => {
return b.appraiseCount-a.appraiseCount;
}
case clsvgs_ResearchResultEN.con_score:
return (a: clsvgs_ResearchResultEN, b: clsvgs_ResearchResultEN) => {
return b.score-a.score;
}
case clsvgs_ResearchResultEN.con_StuScore:
return (a: clsvgs_ResearchResultEN, b: clsvgs_ResearchResultEN) => {
return b.stuScore-a.stuScore;
}
case clsvgs_ResearchResultEN.con_TeaScore:
return (a: clsvgs_ResearchResultEN, b: clsvgs_ResearchResultEN) => {
return b.teaScore-a.teaScore;
}
case clsvgs_ResearchResultEN.con_UpdDate:
return (a: clsvgs_ResearchResultEN, b: clsvgs_ResearchResultEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsvgs_ResearchResultEN.con_UpdUser:
return (a: clsvgs_ResearchResultEN, b: clsvgs_ResearchResultEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsvgs_ResearchResultEN.con_Memo:
return (a: clsvgs_ResearchResultEN, b: clsvgs_ResearchResultEN) => {
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vgs_ResearchResult]中不存在！(in ${ vgs_ResearchResult_ConstructorName}.${ strThisFuncName})`;
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
export async function vgs_ResearchResult_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsvgs_ResearchResultEN.con_ResultId:
return (obj: clsvgs_ResearchResultEN) => {
return obj.resultId === value;
}
case clsvgs_ResearchResultEN.con_TopicId:
return (obj: clsvgs_ResearchResultEN) => {
return obj.topicId === value;
}
case clsvgs_ResearchResultEN.con_TopicName:
return (obj: clsvgs_ResearchResultEN) => {
return obj.topicName === value;
}
case clsvgs_ResearchResultEN.con_PaperId:
return (obj: clsvgs_ResearchResultEN) => {
return obj.paperId === value;
}
case clsvgs_ResearchResultEN.con_id_CurrEduCls:
return (obj: clsvgs_ResearchResultEN) => {
return obj.id_CurrEduCls === value;
}
case clsvgs_ResearchResultEN.con_ResultTypeId:
return (obj: clsvgs_ResearchResultEN) => {
return obj.resultTypeId === value;
}
case clsvgs_ResearchResultEN.con_ResultName:
return (obj: clsvgs_ResearchResultEN) => {
return obj.resultName === value;
}
case clsvgs_ResearchResultEN.con_ResultContent:
return (obj: clsvgs_ResearchResultEN) => {
return obj.resultContent === value;
}
case clsvgs_ResearchResultEN.con_Author:
return (obj: clsvgs_ResearchResultEN) => {
return obj.author === value;
}
case clsvgs_ResearchResultEN.con_Division:
return (obj: clsvgs_ResearchResultEN) => {
return obj.division === value;
}
case clsvgs_ResearchResultEN.con_VersionCount:
return (obj: clsvgs_ResearchResultEN) => {
return obj.versionCount === value;
}
case clsvgs_ResearchResultEN.con_OkCount:
return (obj: clsvgs_ResearchResultEN) => {
return obj.okCount === value;
}
case clsvgs_ResearchResultEN.con_AppraiseCount:
return (obj: clsvgs_ResearchResultEN) => {
return obj.appraiseCount === value;
}
case clsvgs_ResearchResultEN.con_score:
return (obj: clsvgs_ResearchResultEN) => {
return obj.score === value;
}
case clsvgs_ResearchResultEN.con_StuScore:
return (obj: clsvgs_ResearchResultEN) => {
return obj.stuScore === value;
}
case clsvgs_ResearchResultEN.con_TeaScore:
return (obj: clsvgs_ResearchResultEN) => {
return obj.teaScore === value;
}
case clsvgs_ResearchResultEN.con_UpdDate:
return (obj: clsvgs_ResearchResultEN) => {
return obj.updDate === value;
}
case clsvgs_ResearchResultEN.con_UpdUser:
return (obj: clsvgs_ResearchResultEN) => {
return obj.updUser === value;
}
case clsvgs_ResearchResultEN.con_Memo:
return (obj: clsvgs_ResearchResultEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vgs_ResearchResult]中不存在！(in ${ vgs_ResearchResult_ConstructorName}.${ strThisFuncName})`;
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
export async function vgs_ResearchResult_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vgs_ResearchResult_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_ResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_ResearchResult_ConstructorName, strThisFuncName);
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
export async function vgs_ResearchResult_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vgs_ResearchResult_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_ResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_ResearchResult_ConstructorName, strThisFuncName);
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
export async function vgs_ResearchResult_GetFirstObjAsync(strWhereCond: string): Promise<clsvgs_ResearchResultEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(vgs_ResearchResult_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_ResearchResult_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvgs_ResearchResult = vgs_ResearchResult_GetObjFromJsonObj(returnObj);
return objvgs_ResearchResult;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_ResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_ResearchResult_ConstructorName, strThisFuncName);
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
export async function vgs_ResearchResult_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvgs_ResearchResultEN._CurrTabName;
clsvgs_ResearchResultEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvgs_ResearchResultEN._CurrTabName);
if (IsNullOrEmpty(clsvgs_ResearchResultEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvgs_ResearchResultEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrvgs_ResearchResultExObjLst_Cache: Array<clsvgs_ResearchResultEN> = CacheHelper.Get(strKey);
const arrvgs_ResearchResultObjLst_T = vgs_ResearchResult_GetObjLstByJSONObjLst(arrvgs_ResearchResultExObjLst_Cache);
return arrvgs_ResearchResultObjLst_T;
}
try
{
const arrvgs_ResearchResultExObjLst = await vgs_ResearchResult_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrvgs_ResearchResultExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvgs_ResearchResultExObjLst.length);
console.log(strInfo);
return arrvgs_ResearchResultExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vgs_ResearchResult_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vgs_ResearchResult_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvgs_ResearchResultEN._CurrTabName;
clsvgs_ResearchResultEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvgs_ResearchResultEN._CurrTabName);
if (IsNullOrEmpty(clsvgs_ResearchResultEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvgs_ResearchResultEN.CacheAddiCondition);
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
const arrvgs_ResearchResultExObjLst_Cache: Array<clsvgs_ResearchResultEN> = JSON.parse(strTempObjLst);
const arrvgs_ResearchResultObjLst_T = vgs_ResearchResult_GetObjLstByJSONObjLst(arrvgs_ResearchResultExObjLst_Cache);
return arrvgs_ResearchResultObjLst_T;
}
try
{
const arrvgs_ResearchResultExObjLst = await vgs_ResearchResult_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrvgs_ResearchResultExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvgs_ResearchResultExObjLst.length);
console.log(strInfo);
return arrvgs_ResearchResultExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vgs_ResearchResult_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vgs_ResearchResult_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsvgs_ResearchResultEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrvgs_ResearchResultObjLst_Cache: Array<clsvgs_ResearchResultEN> = JSON.parse(strTempObjLst);
return arrvgs_ResearchResultObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function vgs_ResearchResult_GetObjLstAsync(strWhereCond: string): Promise<Array<clsvgs_ResearchResultEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(vgs_ResearchResult_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_ResearchResult_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vgs_ResearchResult_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_ResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_ResearchResult_ConstructorName, strThisFuncName);
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
export async function vgs_ResearchResult_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvgs_ResearchResultEN._CurrTabName;
clsvgs_ResearchResultEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvgs_ResearchResultEN._CurrTabName);
if (IsNullOrEmpty(clsvgs_ResearchResultEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvgs_ResearchResultEN.CacheAddiCondition);
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
const arrvgs_ResearchResultExObjLst_Cache: Array<clsvgs_ResearchResultEN> = JSON.parse(strTempObjLst);
const arrvgs_ResearchResultObjLst_T = vgs_ResearchResult_GetObjLstByJSONObjLst(arrvgs_ResearchResultExObjLst_Cache);
return arrvgs_ResearchResultObjLst_T;
}
try
{
const arrvgs_ResearchResultExObjLst = await vgs_ResearchResult_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrvgs_ResearchResultExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvgs_ResearchResultExObjLst.length);
console.log(strInfo);
return arrvgs_ResearchResultExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vgs_ResearchResult_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vgs_ResearchResult_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsvgs_ResearchResultEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrvgs_ResearchResultObjLst_Cache: Array<clsvgs_ResearchResultEN> = JSON.parse(strTempObjLst);
return arrvgs_ResearchResultObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vgs_ResearchResult_GetObjLst_Cache(): Promise<Array<clsvgs_ResearchResultEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrvgs_ResearchResultObjLst_Cache;
switch (clsvgs_ResearchResultEN.CacheModeId)
{
case "04"://sessionStorage
arrvgs_ResearchResultObjLst_Cache = await vgs_ResearchResult_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrvgs_ResearchResultObjLst_Cache = await vgs_ResearchResult_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrvgs_ResearchResultObjLst_Cache = await vgs_ResearchResult_GetObjLst_ClientCache();
break;
default:
arrvgs_ResearchResultObjLst_Cache = await vgs_ResearchResult_GetObjLst_ClientCache();
break;
}
const arrvgs_ResearchResultObjLst = vgs_ResearchResult_GetObjLstByJSONObjLst(arrvgs_ResearchResultObjLst_Cache);
return arrvgs_ResearchResultObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vgs_ResearchResult_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrvgs_ResearchResultObjLst_Cache;
switch (clsvgs_ResearchResultEN.CacheModeId)
{
case "04"://sessionStorage
arrvgs_ResearchResultObjLst_Cache = await vgs_ResearchResult_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrvgs_ResearchResultObjLst_Cache = await vgs_ResearchResult_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrvgs_ResearchResultObjLst_Cache = null;
break;
default:
arrvgs_ResearchResultObjLst_Cache = null;
break;
}
return arrvgs_ResearchResultObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrResultId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vgs_ResearchResult_GetSubObjLst_Cache(objvgs_ResearchResult_Cond: clsvgs_ResearchResultEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrvgs_ResearchResultObjLst_Cache = await vgs_ResearchResult_GetObjLst_Cache();
let arrvgs_ResearchResult_Sel: Array < clsvgs_ResearchResultEN > = arrvgs_ResearchResultObjLst_Cache;
if (objvgs_ResearchResult_Cond.sf_FldComparisonOp == null || objvgs_ResearchResult_Cond.sf_FldComparisonOp == "") return arrvgs_ResearchResult_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvgs_ResearchResult_Cond.sf_FldComparisonOp);
//console.log("clsvgs_ResearchResultWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvgs_ResearchResult_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvgs_ResearchResult_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvgs_ResearchResult_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objvgs_ResearchResult_Cond), vgs_ResearchResult_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvgs_ResearchResultEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrResultId:关键字列表
 * @returns 对象列表
 **/
export async function vgs_ResearchResult_GetObjLstByResultIdLstAsync(arrResultId: Array<string>): Promise<Array<clsvgs_ResearchResultEN>>  
{
const strThisFuncName = "GetObjLstByResultIdLstAsync";
const strAction = "GetObjLstByResultIdLst";
const strUrl = GetWebApiUrl(vgs_ResearchResult_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrResultId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_ResearchResult_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vgs_ResearchResult_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_ResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_ResearchResult_ConstructorName, strThisFuncName);
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
 * @param arrstrResultIdLst:关键字列表
 * @returns 对象列表
*/
export async function vgs_ResearchResult_GetObjLstByResultIdLst_Cache(arrResultIdLst: Array<string>) {
const strThisFuncName = "GetObjLstByResultIdLst_Cache";
try
{
const arrvgs_ResearchResultObjLst_Cache = await vgs_ResearchResult_GetObjLst_Cache();
const arrvgs_ResearchResult_Sel: Array <clsvgs_ResearchResultEN> = arrvgs_ResearchResultObjLst_Cache.filter(x => arrResultIdLst.indexOf(x.resultId)>-1);
return arrvgs_ResearchResult_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrResultIdLst.join(","), vgs_ResearchResult_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvgs_ResearchResultEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function vgs_ResearchResult_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsvgs_ResearchResultEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(vgs_ResearchResult_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_ResearchResult_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vgs_ResearchResult_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_ResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_ResearchResult_ConstructorName, strThisFuncName);
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
export async function vgs_ResearchResult_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsvgs_ResearchResultEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vgs_ResearchResult_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_ResearchResult_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vgs_ResearchResult_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_ResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_ResearchResult_ConstructorName, strThisFuncName);
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
export async function vgs_ResearchResult_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vgs_ResearchResult_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_ResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_ResearchResult_ConstructorName, strThisFuncName);
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
export async function vgs_ResearchResult_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrvgs_ResearchResultObjLst_Cache = await vgs_ResearchResult_GetObjLst_Cache();
if (arrvgs_ResearchResultObjLst_Cache.length == 0) return arrvgs_ResearchResultObjLst_Cache;
let arrvgs_ResearchResult_Sel = arrvgs_ResearchResultObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objvgs_ResearchResult_Cond = new clsvgs_ResearchResultEN();
ObjectAssign(objvgs_ResearchResult_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsvgs_ResearchResultWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvgs_ResearchResult_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvgs_ResearchResult_Sel.length == 0) return arrvgs_ResearchResult_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.sort(vgs_ResearchResult_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.sort(objPagerPara.sortFun);
}
arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.slice(intStart, intEnd);     
return arrvgs_ResearchResult_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, vgs_ResearchResult_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvgs_ResearchResultEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function vgs_ResearchResult_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsvgs_ResearchResultEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(vgs_ResearchResult_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_ResearchResult_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vgs_ResearchResult_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_ResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_ResearchResult_ConstructorName, strThisFuncName);
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
 * @param objstrResultId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vgs_ResearchResult_IsExistRecord_Cache(objvgs_ResearchResult_Cond: clsvgs_ResearchResultEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrvgs_ResearchResultObjLst_Cache = await vgs_ResearchResult_GetObjLst_Cache();
if (arrvgs_ResearchResultObjLst_Cache == null) return false;
let arrvgs_ResearchResult_Sel: Array < clsvgs_ResearchResultEN > = arrvgs_ResearchResultObjLst_Cache;
if (objvgs_ResearchResult_Cond.sf_FldComparisonOp == null || objvgs_ResearchResult_Cond.sf_FldComparisonOp == "") return arrvgs_ResearchResult_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvgs_ResearchResult_Cond.sf_FldComparisonOp);
//console.log("clsvgs_ResearchResultWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvgs_ResearchResult_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvgs_ResearchResult_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvgs_ResearchResult_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objvgs_ResearchResult_Cond), vgs_ResearchResult_ConstructorName, strThisFuncName);
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
export async function vgs_ResearchResult_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(vgs_ResearchResult_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_ResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_ResearchResult_ConstructorName, strThisFuncName);
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
 * @param strResultId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function vgs_ResearchResult_IsExist(strResultId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vgs_ResearchResult_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"ResultId": strResultId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_ResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_ResearchResult_ConstructorName, strThisFuncName);
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
 * @param strResultId:所给的关键字
 * @returns 对象
*/
export async function vgs_ResearchResult_IsExist_Cache(strResultId:string) {
const strThisFuncName = "IsExist_Cache";
const arrvgs_ResearchResultObjLst_Cache = await vgs_ResearchResult_GetObjLst_Cache();
if (arrvgs_ResearchResultObjLst_Cache == null) return false;
try
{
const arrvgs_ResearchResult_Sel: Array <clsvgs_ResearchResultEN> = arrvgs_ResearchResultObjLst_Cache.filter(x => x.resultId == strResultId);
if (arrvgs_ResearchResult_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strResultId, vgs_ResearchResult_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param strResultId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function vgs_ResearchResult_IsExistAsync(strResultId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vgs_ResearchResult_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strResultId": strResultId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_ResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_ResearchResult_ConstructorName, strThisFuncName);
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
export async function vgs_ResearchResult_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(vgs_ResearchResult_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_ResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_ResearchResult_ConstructorName, strThisFuncName);
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
 * @param objvgs_ResearchResult_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function vgs_ResearchResult_GetRecCountByCond_Cache(objvgs_ResearchResult_Cond: clsvgs_ResearchResultEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrvgs_ResearchResultObjLst_Cache = await vgs_ResearchResult_GetObjLst_Cache();
if (arrvgs_ResearchResultObjLst_Cache == null) return 0;
let arrvgs_ResearchResult_Sel: Array < clsvgs_ResearchResultEN > = arrvgs_ResearchResultObjLst_Cache;
if (objvgs_ResearchResult_Cond.sf_FldComparisonOp == null || objvgs_ResearchResult_Cond.sf_FldComparisonOp == "") return arrvgs_ResearchResult_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvgs_ResearchResult_Cond.sf_FldComparisonOp);
//console.log("clsvgs_ResearchResultWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvgs_ResearchResult_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvgs_ResearchResult_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvgs_ResearchResult_Sel = arrvgs_ResearchResult_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvgs_ResearchResult_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objvgs_ResearchResult_Cond), vgs_ResearchResult_ConstructorName, strThisFuncName);
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
export function vgs_ResearchResult_GetWebApiUrl(strController: string, strAction: string): string {
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
export function vgs_ResearchResult_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clsvgs_ResearchResultEN._CurrTabName;
switch (clsvgs_ResearchResultEN.CacheModeId)
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
export function vgs_ResearchResult_GetJSONStrByObj (pobjvgs_ResearchResultEN: clsvgs_ResearchResultEN): string
{
const strThisFuncName = "GetJSONStrByObj";
let strJson = "";
try
{
strJson = JSON.stringify(pobjvgs_ResearchResultEN);
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
export function vgs_ResearchResult_GetObjLstByJSONStr (strJSON: string): Array<clsvgs_ResearchResultEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrvgs_ResearchResultObjLst = new Array<clsvgs_ResearchResultEN>();
if (strJSON === "")
{
return arrvgs_ResearchResultObjLst;
}
try
{
arrvgs_ResearchResultObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvgs_ResearchResultObjLst;
}
return arrvgs_ResearchResultObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrvgs_ResearchResultObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function vgs_ResearchResult_GetObjLstByJSONObjLst (arrvgs_ResearchResultObjLstS: Array<clsvgs_ResearchResultEN>): Array<clsvgs_ResearchResultEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrvgs_ResearchResultObjLst = new Array<clsvgs_ResearchResultEN>();
for (const objInFor of arrvgs_ResearchResultObjLstS) {
const obj1 = vgs_ResearchResult_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrvgs_ResearchResultObjLst.push(obj1);
}
return arrvgs_ResearchResultObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vgs_ResearchResult_GetObjByJSONStr (strJSON: string): clsvgs_ResearchResultEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjvgs_ResearchResultEN = new clsvgs_ResearchResultEN();
if (strJSON === "")
{
return pobjvgs_ResearchResultEN;
}
try
{
pobjvgs_ResearchResultEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvgs_ResearchResultEN;
}
return pobjvgs_ResearchResultEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function vgs_ResearchResult_GetCombineCondition(objvgs_ResearchResult_Cond: clsvgs_ResearchResultEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objvgs_ResearchResult_Cond.dicFldComparisonOp, clsvgs_ResearchResultEN.con_ResultId) == true)
{
const strComparisonOp_ResultId:string = objvgs_ResearchResult_Cond.dicFldComparisonOp[clsvgs_ResearchResultEN.con_ResultId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_ResearchResultEN.con_ResultId, objvgs_ResearchResult_Cond.resultId, strComparisonOp_ResultId);
}
if (Object.prototype.hasOwnProperty.call(objvgs_ResearchResult_Cond.dicFldComparisonOp, clsvgs_ResearchResultEN.con_TopicId) == true)
{
const strComparisonOp_TopicId:string = objvgs_ResearchResult_Cond.dicFldComparisonOp[clsvgs_ResearchResultEN.con_TopicId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_ResearchResultEN.con_TopicId, objvgs_ResearchResult_Cond.topicId, strComparisonOp_TopicId);
}
if (Object.prototype.hasOwnProperty.call(objvgs_ResearchResult_Cond.dicFldComparisonOp, clsvgs_ResearchResultEN.con_TopicName) == true)
{
const strComparisonOp_TopicName:string = objvgs_ResearchResult_Cond.dicFldComparisonOp[clsvgs_ResearchResultEN.con_TopicName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_ResearchResultEN.con_TopicName, objvgs_ResearchResult_Cond.topicName, strComparisonOp_TopicName);
}
if (Object.prototype.hasOwnProperty.call(objvgs_ResearchResult_Cond.dicFldComparisonOp, clsvgs_ResearchResultEN.con_PaperId) == true)
{
const strComparisonOp_PaperId:string = objvgs_ResearchResult_Cond.dicFldComparisonOp[clsvgs_ResearchResultEN.con_PaperId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_ResearchResultEN.con_PaperId, objvgs_ResearchResult_Cond.paperId, strComparisonOp_PaperId);
}
if (Object.prototype.hasOwnProperty.call(objvgs_ResearchResult_Cond.dicFldComparisonOp, clsvgs_ResearchResultEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objvgs_ResearchResult_Cond.dicFldComparisonOp[clsvgs_ResearchResultEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_ResearchResultEN.con_id_CurrEduCls, objvgs_ResearchResult_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (Object.prototype.hasOwnProperty.call(objvgs_ResearchResult_Cond.dicFldComparisonOp, clsvgs_ResearchResultEN.con_ResultTypeId) == true)
{
const strComparisonOp_ResultTypeId:string = objvgs_ResearchResult_Cond.dicFldComparisonOp[clsvgs_ResearchResultEN.con_ResultTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_ResearchResultEN.con_ResultTypeId, objvgs_ResearchResult_Cond.resultTypeId, strComparisonOp_ResultTypeId);
}
if (Object.prototype.hasOwnProperty.call(objvgs_ResearchResult_Cond.dicFldComparisonOp, clsvgs_ResearchResultEN.con_ResultName) == true)
{
const strComparisonOp_ResultName:string = objvgs_ResearchResult_Cond.dicFldComparisonOp[clsvgs_ResearchResultEN.con_ResultName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_ResearchResultEN.con_ResultName, objvgs_ResearchResult_Cond.resultName, strComparisonOp_ResultName);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objvgs_ResearchResult_Cond.dicFldComparisonOp, clsvgs_ResearchResultEN.con_Author) == true)
{
const strComparisonOp_Author:string = objvgs_ResearchResult_Cond.dicFldComparisonOp[clsvgs_ResearchResultEN.con_Author];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_ResearchResultEN.con_Author, objvgs_ResearchResult_Cond.author, strComparisonOp_Author);
}
if (Object.prototype.hasOwnProperty.call(objvgs_ResearchResult_Cond.dicFldComparisonOp, clsvgs_ResearchResultEN.con_Division) == true)
{
const strComparisonOp_Division:string = objvgs_ResearchResult_Cond.dicFldComparisonOp[clsvgs_ResearchResultEN.con_Division];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_ResearchResultEN.con_Division, objvgs_ResearchResult_Cond.division, strComparisonOp_Division);
}
if (Object.prototype.hasOwnProperty.call(objvgs_ResearchResult_Cond.dicFldComparisonOp, clsvgs_ResearchResultEN.con_VersionCount) == true)
{
const strComparisonOp_VersionCount:string = objvgs_ResearchResult_Cond.dicFldComparisonOp[clsvgs_ResearchResultEN.con_VersionCount];
strWhereCond += Format(" And {0} {2} {1}", clsvgs_ResearchResultEN.con_VersionCount, objvgs_ResearchResult_Cond.versionCount, strComparisonOp_VersionCount);
}
if (Object.prototype.hasOwnProperty.call(objvgs_ResearchResult_Cond.dicFldComparisonOp, clsvgs_ResearchResultEN.con_OkCount) == true)
{
const strComparisonOp_OkCount:string = objvgs_ResearchResult_Cond.dicFldComparisonOp[clsvgs_ResearchResultEN.con_OkCount];
strWhereCond += Format(" And {0} {2} {1}", clsvgs_ResearchResultEN.con_OkCount, objvgs_ResearchResult_Cond.okCount, strComparisonOp_OkCount);
}
if (Object.prototype.hasOwnProperty.call(objvgs_ResearchResult_Cond.dicFldComparisonOp, clsvgs_ResearchResultEN.con_AppraiseCount) == true)
{
const strComparisonOp_AppraiseCount:string = objvgs_ResearchResult_Cond.dicFldComparisonOp[clsvgs_ResearchResultEN.con_AppraiseCount];
strWhereCond += Format(" And {0} {2} {1}", clsvgs_ResearchResultEN.con_AppraiseCount, objvgs_ResearchResult_Cond.appraiseCount, strComparisonOp_AppraiseCount);
}
if (Object.prototype.hasOwnProperty.call(objvgs_ResearchResult_Cond.dicFldComparisonOp, clsvgs_ResearchResultEN.con_score) == true)
{
const strComparisonOp_score:string = objvgs_ResearchResult_Cond.dicFldComparisonOp[clsvgs_ResearchResultEN.con_score];
strWhereCond += Format(" And {0} {2} {1}", clsvgs_ResearchResultEN.con_score, objvgs_ResearchResult_Cond.score, strComparisonOp_score);
}
if (Object.prototype.hasOwnProperty.call(objvgs_ResearchResult_Cond.dicFldComparisonOp, clsvgs_ResearchResultEN.con_StuScore) == true)
{
const strComparisonOp_StuScore:string = objvgs_ResearchResult_Cond.dicFldComparisonOp[clsvgs_ResearchResultEN.con_StuScore];
strWhereCond += Format(" And {0} {2} {1}", clsvgs_ResearchResultEN.con_StuScore, objvgs_ResearchResult_Cond.stuScore, strComparisonOp_StuScore);
}
if (Object.prototype.hasOwnProperty.call(objvgs_ResearchResult_Cond.dicFldComparisonOp, clsvgs_ResearchResultEN.con_TeaScore) == true)
{
const strComparisonOp_TeaScore:string = objvgs_ResearchResult_Cond.dicFldComparisonOp[clsvgs_ResearchResultEN.con_TeaScore];
strWhereCond += Format(" And {0} {2} {1}", clsvgs_ResearchResultEN.con_TeaScore, objvgs_ResearchResult_Cond.teaScore, strComparisonOp_TeaScore);
}
if (Object.prototype.hasOwnProperty.call(objvgs_ResearchResult_Cond.dicFldComparisonOp, clsvgs_ResearchResultEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objvgs_ResearchResult_Cond.dicFldComparisonOp[clsvgs_ResearchResultEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_ResearchResultEN.con_UpdDate, objvgs_ResearchResult_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objvgs_ResearchResult_Cond.dicFldComparisonOp, clsvgs_ResearchResultEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objvgs_ResearchResult_Cond.dicFldComparisonOp[clsvgs_ResearchResultEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_ResearchResultEN.con_UpdUser, objvgs_ResearchResult_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objvgs_ResearchResult_Cond.dicFldComparisonOp, clsvgs_ResearchResultEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objvgs_ResearchResult_Cond.dicFldComparisonOp[clsvgs_ResearchResultEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_ResearchResultEN.con_Memo, objvgs_ResearchResult_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objvgs_ResearchResultENS:源对象
 * @param objvgs_ResearchResultENT:目标对象
*/
export function vgs_ResearchResult_CopyObjTo(objvgs_ResearchResultENS: clsvgs_ResearchResultEN , objvgs_ResearchResultENT: clsvgs_ResearchResultEN ): void 
{
objvgs_ResearchResultENT.resultId = objvgs_ResearchResultENS.resultId; //成果Id
objvgs_ResearchResultENT.topicId = objvgs_ResearchResultENS.topicId; //主题Id
objvgs_ResearchResultENT.topicName = objvgs_ResearchResultENS.topicName; //栏目主题
objvgs_ResearchResultENT.paperId = objvgs_ResearchResultENS.paperId; //论文Id
objvgs_ResearchResultENT.id_CurrEduCls = objvgs_ResearchResultENS.id_CurrEduCls; //教学班流水号
objvgs_ResearchResultENT.resultTypeId = objvgs_ResearchResultENS.resultTypeId; //成果类型Id
objvgs_ResearchResultENT.resultName = objvgs_ResearchResultENS.resultName; //成果名称
objvgs_ResearchResultENT.resultContent = objvgs_ResearchResultENS.resultContent; //成果内容
objvgs_ResearchResultENT.author = objvgs_ResearchResultENS.author; //作者
objvgs_ResearchResultENT.division = objvgs_ResearchResultENS.division; //分工
objvgs_ResearchResultENT.versionCount = objvgs_ResearchResultENS.versionCount; //版本统计
objvgs_ResearchResultENT.okCount = objvgs_ResearchResultENS.okCount; //点赞统计
objvgs_ResearchResultENT.appraiseCount = objvgs_ResearchResultENS.appraiseCount; //评论数
objvgs_ResearchResultENT.score = objvgs_ResearchResultENS.score; //评分
objvgs_ResearchResultENT.stuScore = objvgs_ResearchResultENS.stuScore; //学生平均分
objvgs_ResearchResultENT.teaScore = objvgs_ResearchResultENS.teaScore; //教师评分
objvgs_ResearchResultENT.updDate = objvgs_ResearchResultENS.updDate; //修改日期
objvgs_ResearchResultENT.updUser = objvgs_ResearchResultENS.updUser; //修改人
objvgs_ResearchResultENT.memo = objvgs_ResearchResultENS.memo; //备注
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objvgs_ResearchResultENS:源对象
 * @param objvgs_ResearchResultENT:目标对象
*/
export function vgs_ResearchResult_GetObjFromJsonObj(objvgs_ResearchResultENS: clsvgs_ResearchResultEN): clsvgs_ResearchResultEN 
{
 const objvgs_ResearchResultENT: clsvgs_ResearchResultEN = new clsvgs_ResearchResultEN();
ObjectAssign(objvgs_ResearchResultENT, objvgs_ResearchResultENS);
 return objvgs_ResearchResultENT;
}