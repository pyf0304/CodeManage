
 /**
 * 类名:clsvgs_TobeStudiedProblemWApi
 * 表名:vgs_TobeStudiedProblem(01120774)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 15:58:36
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
 * 待研究问题视图(vgs_TobeStudiedProblem)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clsvgs_TobeStudiedProblemEN } from "../../L0_Entity/GraduateEduTopic/clsvgs_TobeStudiedProblemEN.js";
import { BindDdl_ObjLstInDiv_V, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const vgs_TobeStudiedProblem_Controller = "vgs_TobeStudiedProblemApi";
 export const vgs_TobeStudiedProblem_ConstructorName = "vgs_TobeStudiedProblem";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strProblemId:关键字
 * @returns 对象
 **/
export async function vgs_TobeStudiedProblem_GetObjByProblemIdAsync(strProblemId: string): Promise<clsvgs_TobeStudiedProblemEN>  
{
const strThisFuncName = "GetObjByProblemIdAsync";

if (IsNullOrEmpty(strProblemId) == true)
{
  const strMsg = Format("参数:[strProblemId]不能为空！(In GetObjByProblemIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strProblemId.length != 10)
{
const strMsg = Format("缓存分类变量:[strProblemId]的长度:[{0}]不正确！", strProblemId.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByProblemId";
const strUrl = GetWebApiUrl(vgs_TobeStudiedProblem_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strProblemId": strProblemId,
}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObj = data.returnObj;
if (returnObj == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_TobeStudiedProblem_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvgs_TobeStudiedProblem = vgs_TobeStudiedProblem_GetObjFromJsonObj(returnObj);
return objvgs_TobeStudiedProblem;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_TobeStudiedProblem_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_TobeStudiedProblem_ConstructorName, strThisFuncName);
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
 * @param strProblemId:所给的关键字
 * @returns 对象
*/
export async function vgs_TobeStudiedProblem_GetObjByProblemId_Cache(strProblemId: string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByProblemId_Cache";

if (IsNullOrEmpty(strProblemId) == true)
{
  const strMsg = Format("参数:[strProblemId]不能为空！(In GetObjByProblemId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strProblemId.length != 10)
{
const strMsg = Format("缓存分类变量:[strProblemId]的长度:[{0}]不正确！", strProblemId.length);
console.error(strMsg);
throw (strMsg);
}
const arrvgs_TobeStudiedProblemObjLst_Cache = await vgs_TobeStudiedProblem_GetObjLst_Cache();
try
{
const arrvgs_TobeStudiedProblem_Sel: Array <clsvgs_TobeStudiedProblemEN> = arrvgs_TobeStudiedProblemObjLst_Cache.filter(x => x.problemId == strProblemId);
let objvgs_TobeStudiedProblem: clsvgs_TobeStudiedProblemEN;
if (arrvgs_TobeStudiedProblem_Sel.length > 0)
{
objvgs_TobeStudiedProblem = arrvgs_TobeStudiedProblem_Sel[0];
return objvgs_TobeStudiedProblem;
}
else
{
if (bolTryAsyncOnce == true)
{
objvgs_TobeStudiedProblem = await vgs_TobeStudiedProblem_GetObjByProblemIdAsync(strProblemId);
if (objvgs_TobeStudiedProblem != null)
{
vgs_TobeStudiedProblem_ReFreshThisCache();
return objvgs_TobeStudiedProblem;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strProblemId, vgs_TobeStudiedProblem_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param strProblemId:所给的关键字
 * @returns 对象
*/
export async function vgs_TobeStudiedProblem_GetObjByProblemId_localStorage(strProblemId: string) {
const strThisFuncName = "GetObjByProblemId_localStorage";

if (IsNullOrEmpty(strProblemId) == true)
{
  const strMsg = Format("参数:[strProblemId]不能为空！(In GetObjByProblemId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
if (strProblemId.length != 10)
{
const strMsg = Format("缓存分类变量:[strProblemId]的长度:[{0}]不正确！", strProblemId.length);
console.error(strMsg);
throw (strMsg);
}
const strKey = Format("{0}_{1}", clsvgs_TobeStudiedProblemEN._CurrTabName, strProblemId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objvgs_TobeStudiedProblem_Cache: clsvgs_TobeStudiedProblemEN = JSON.parse(strTempObj);
return objvgs_TobeStudiedProblem_Cache;
}
try
{
const objvgs_TobeStudiedProblem = await vgs_TobeStudiedProblem_GetObjByProblemIdAsync(strProblemId);
if (objvgs_TobeStudiedProblem != null)
{
localStorage.setItem(strKey, JSON.stringify(objvgs_TobeStudiedProblem));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objvgs_TobeStudiedProblem;
}
return objvgs_TobeStudiedProblem;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strProblemId, vgs_TobeStudiedProblem_ConstructorName, strThisFuncName);
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
export async function vgs_TobeStudiedProblem_func(strInFldName:string , strOutFldName:string ,  strInValue: string) 
{
//const strThisFuncName = "func";

if (strInFldName != clsvgs_TobeStudiedProblemEN.con_ProblemId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsvgs_TobeStudiedProblemEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clsvgs_TobeStudiedProblemEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strProblemId = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objvgs_TobeStudiedProblem = await vgs_TobeStudiedProblem_GetObjByProblemId_Cache(strProblemId );
if (objvgs_TobeStudiedProblem == null) return "";
return objvgs_TobeStudiedProblem.GetFldValue(strOutFldName).toString();
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
export function vgs_TobeStudiedProblem_SortFun_Defa(a:clsvgs_TobeStudiedProblemEN , b:clsvgs_TobeStudiedProblemEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.problemId.localeCompare(b.problemId);
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
export function vgs_TobeStudiedProblem_SortFun_Defa_2Fld(a:clsvgs_TobeStudiedProblemEN , b:clsvgs_TobeStudiedProblemEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.problemTitle == b.problemTitle) return a.problemContent.localeCompare(b.problemContent);
else return a.problemTitle.localeCompare(b.problemTitle);
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
export function vgs_TobeStudiedProblem_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsvgs_TobeStudiedProblemEN.con_ProblemId:
return (a: clsvgs_TobeStudiedProblemEN, b: clsvgs_TobeStudiedProblemEN) => {
return a.problemId.localeCompare(b.problemId);
}
case clsvgs_TobeStudiedProblemEN.con_ProblemTitle:
return (a: clsvgs_TobeStudiedProblemEN, b: clsvgs_TobeStudiedProblemEN) => {
return a.problemTitle.localeCompare(b.problemTitle);
}
case clsvgs_TobeStudiedProblemEN.con_ProblemContent:
return (a: clsvgs_TobeStudiedProblemEN, b: clsvgs_TobeStudiedProblemEN) => {
return a.problemContent.localeCompare(b.problemContent);
}
case clsvgs_TobeStudiedProblemEN.con_TopicId:
return (a: clsvgs_TobeStudiedProblemEN, b: clsvgs_TobeStudiedProblemEN) => {
return a.topicId.localeCompare(b.topicId);
}
case clsvgs_TobeStudiedProblemEN.con_TopicName:
return (a: clsvgs_TobeStudiedProblemEN, b: clsvgs_TobeStudiedProblemEN) => {
return a.topicName.localeCompare(b.topicName);
}
case clsvgs_TobeStudiedProblemEN.con_id_CurrEduCls:
return (a: clsvgs_TobeStudiedProblemEN, b: clsvgs_TobeStudiedProblemEN) => {
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
case clsvgs_TobeStudiedProblemEN.con_IsSubmit:
return (a: clsvgs_TobeStudiedProblemEN, b: clsvgs_TobeStudiedProblemEN) => {
if (a.isSubmit == true) return 1;
else return -1
}
case clsvgs_TobeStudiedProblemEN.con_ProblemDate:
return (a: clsvgs_TobeStudiedProblemEN, b: clsvgs_TobeStudiedProblemEN) => {
return a.problemDate.localeCompare(b.problemDate);
}
case clsvgs_TobeStudiedProblemEN.con_UpdDate:
return (a: clsvgs_TobeStudiedProblemEN, b: clsvgs_TobeStudiedProblemEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsvgs_TobeStudiedProblemEN.con_UpdUser:
return (a: clsvgs_TobeStudiedProblemEN, b: clsvgs_TobeStudiedProblemEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsvgs_TobeStudiedProblemEN.con_Year:
return (a: clsvgs_TobeStudiedProblemEN, b: clsvgs_TobeStudiedProblemEN) => {
return a.year.localeCompare(b.year);
}
case clsvgs_TobeStudiedProblemEN.con_Month:
return (a: clsvgs_TobeStudiedProblemEN, b: clsvgs_TobeStudiedProblemEN) => {
return a.month.localeCompare(b.month);
}
case clsvgs_TobeStudiedProblemEN.con_VersionCount:
return (a: clsvgs_TobeStudiedProblemEN, b: clsvgs_TobeStudiedProblemEN) => {
return a.versionCount-b.versionCount;
}
case clsvgs_TobeStudiedProblemEN.con_Participant:
return (a: clsvgs_TobeStudiedProblemEN, b: clsvgs_TobeStudiedProblemEN) => {
return a.participant.localeCompare(b.participant);
}
case clsvgs_TobeStudiedProblemEN.con_Memo:
return (a: clsvgs_TobeStudiedProblemEN, b: clsvgs_TobeStudiedProblemEN) => {
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vgs_TobeStudiedProblem]中不存在！(in ${ vgs_TobeStudiedProblem_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsvgs_TobeStudiedProblemEN.con_ProblemId:
return (a: clsvgs_TobeStudiedProblemEN, b: clsvgs_TobeStudiedProblemEN) => {
return b.problemId.localeCompare(a.problemId);
}
case clsvgs_TobeStudiedProblemEN.con_ProblemTitle:
return (a: clsvgs_TobeStudiedProblemEN, b: clsvgs_TobeStudiedProblemEN) => {
return b.problemTitle.localeCompare(a.problemTitle);
}
case clsvgs_TobeStudiedProblemEN.con_ProblemContent:
return (a: clsvgs_TobeStudiedProblemEN, b: clsvgs_TobeStudiedProblemEN) => {
return b.problemContent.localeCompare(a.problemContent);
}
case clsvgs_TobeStudiedProblemEN.con_TopicId:
return (a: clsvgs_TobeStudiedProblemEN, b: clsvgs_TobeStudiedProblemEN) => {
return b.topicId.localeCompare(a.topicId);
}
case clsvgs_TobeStudiedProblemEN.con_TopicName:
return (a: clsvgs_TobeStudiedProblemEN, b: clsvgs_TobeStudiedProblemEN) => {
return b.topicName.localeCompare(a.topicName);
}
case clsvgs_TobeStudiedProblemEN.con_id_CurrEduCls:
return (a: clsvgs_TobeStudiedProblemEN, b: clsvgs_TobeStudiedProblemEN) => {
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
case clsvgs_TobeStudiedProblemEN.con_IsSubmit:
return (a: clsvgs_TobeStudiedProblemEN, b: clsvgs_TobeStudiedProblemEN) => {
if (b.isSubmit == true) return 1;
else return -1
}
case clsvgs_TobeStudiedProblemEN.con_ProblemDate:
return (a: clsvgs_TobeStudiedProblemEN, b: clsvgs_TobeStudiedProblemEN) => {
return b.problemDate.localeCompare(a.problemDate);
}
case clsvgs_TobeStudiedProblemEN.con_UpdDate:
return (a: clsvgs_TobeStudiedProblemEN, b: clsvgs_TobeStudiedProblemEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsvgs_TobeStudiedProblemEN.con_UpdUser:
return (a: clsvgs_TobeStudiedProblemEN, b: clsvgs_TobeStudiedProblemEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsvgs_TobeStudiedProblemEN.con_Year:
return (a: clsvgs_TobeStudiedProblemEN, b: clsvgs_TobeStudiedProblemEN) => {
return b.year.localeCompare(a.year);
}
case clsvgs_TobeStudiedProblemEN.con_Month:
return (a: clsvgs_TobeStudiedProblemEN, b: clsvgs_TobeStudiedProblemEN) => {
return b.month.localeCompare(a.month);
}
case clsvgs_TobeStudiedProblemEN.con_VersionCount:
return (a: clsvgs_TobeStudiedProblemEN, b: clsvgs_TobeStudiedProblemEN) => {
return b.versionCount-a.versionCount;
}
case clsvgs_TobeStudiedProblemEN.con_Participant:
return (a: clsvgs_TobeStudiedProblemEN, b: clsvgs_TobeStudiedProblemEN) => {
return b.participant.localeCompare(a.participant);
}
case clsvgs_TobeStudiedProblemEN.con_Memo:
return (a: clsvgs_TobeStudiedProblemEN, b: clsvgs_TobeStudiedProblemEN) => {
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vgs_TobeStudiedProblem]中不存在！(in ${ vgs_TobeStudiedProblem_ConstructorName}.${ strThisFuncName})`;
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
export async function vgs_TobeStudiedProblem_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsvgs_TobeStudiedProblemEN.con_ProblemId:
return (obj: clsvgs_TobeStudiedProblemEN) => {
return obj.problemId === value;
}
case clsvgs_TobeStudiedProblemEN.con_ProblemTitle:
return (obj: clsvgs_TobeStudiedProblemEN) => {
return obj.problemTitle === value;
}
case clsvgs_TobeStudiedProblemEN.con_ProblemContent:
return (obj: clsvgs_TobeStudiedProblemEN) => {
return obj.problemContent === value;
}
case clsvgs_TobeStudiedProblemEN.con_TopicId:
return (obj: clsvgs_TobeStudiedProblemEN) => {
return obj.topicId === value;
}
case clsvgs_TobeStudiedProblemEN.con_TopicName:
return (obj: clsvgs_TobeStudiedProblemEN) => {
return obj.topicName === value;
}
case clsvgs_TobeStudiedProblemEN.con_id_CurrEduCls:
return (obj: clsvgs_TobeStudiedProblemEN) => {
return obj.id_CurrEduCls === value;
}
case clsvgs_TobeStudiedProblemEN.con_IsSubmit:
return (obj: clsvgs_TobeStudiedProblemEN) => {
return obj.isSubmit === value;
}
case clsvgs_TobeStudiedProblemEN.con_ProblemDate:
return (obj: clsvgs_TobeStudiedProblemEN) => {
return obj.problemDate === value;
}
case clsvgs_TobeStudiedProblemEN.con_UpdDate:
return (obj: clsvgs_TobeStudiedProblemEN) => {
return obj.updDate === value;
}
case clsvgs_TobeStudiedProblemEN.con_UpdUser:
return (obj: clsvgs_TobeStudiedProblemEN) => {
return obj.updUser === value;
}
case clsvgs_TobeStudiedProblemEN.con_Year:
return (obj: clsvgs_TobeStudiedProblemEN) => {
return obj.year === value;
}
case clsvgs_TobeStudiedProblemEN.con_Month:
return (obj: clsvgs_TobeStudiedProblemEN) => {
return obj.month === value;
}
case clsvgs_TobeStudiedProblemEN.con_VersionCount:
return (obj: clsvgs_TobeStudiedProblemEN) => {
return obj.versionCount === value;
}
case clsvgs_TobeStudiedProblemEN.con_Participant:
return (obj: clsvgs_TobeStudiedProblemEN) => {
return obj.participant === value;
}
case clsvgs_TobeStudiedProblemEN.con_Memo:
return (obj: clsvgs_TobeStudiedProblemEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vgs_TobeStudiedProblem]中不存在！(in ${ vgs_TobeStudiedProblem_ConstructorName}.${ strThisFuncName})`;
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
export async function vgs_TobeStudiedProblem_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vgs_TobeStudiedProblem_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_TobeStudiedProblem_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_TobeStudiedProblem_ConstructorName, strThisFuncName);
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
export async function vgs_TobeStudiedProblem_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vgs_TobeStudiedProblem_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_TobeStudiedProblem_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_TobeStudiedProblem_ConstructorName, strThisFuncName);
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
export async function vgs_TobeStudiedProblem_GetFirstObjAsync(strWhereCond: string): Promise<clsvgs_TobeStudiedProblemEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(vgs_TobeStudiedProblem_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_TobeStudiedProblem_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvgs_TobeStudiedProblem = vgs_TobeStudiedProblem_GetObjFromJsonObj(returnObj);
return objvgs_TobeStudiedProblem;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_TobeStudiedProblem_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_TobeStudiedProblem_ConstructorName, strThisFuncName);
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
export async function vgs_TobeStudiedProblem_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvgs_TobeStudiedProblemEN._CurrTabName;
clsvgs_TobeStudiedProblemEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvgs_TobeStudiedProblemEN._CurrTabName);
if (IsNullOrEmpty(clsvgs_TobeStudiedProblemEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvgs_TobeStudiedProblemEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrvgs_TobeStudiedProblemExObjLst_Cache: Array<clsvgs_TobeStudiedProblemEN> = CacheHelper.Get(strKey);
const arrvgs_TobeStudiedProblemObjLst_T = vgs_TobeStudiedProblem_GetObjLstByJSONObjLst(arrvgs_TobeStudiedProblemExObjLst_Cache);
return arrvgs_TobeStudiedProblemObjLst_T;
}
try
{
const arrvgs_TobeStudiedProblemExObjLst = await vgs_TobeStudiedProblem_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrvgs_TobeStudiedProblemExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvgs_TobeStudiedProblemExObjLst.length);
console.log(strInfo);
return arrvgs_TobeStudiedProblemExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vgs_TobeStudiedProblem_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vgs_TobeStudiedProblem_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvgs_TobeStudiedProblemEN._CurrTabName;
clsvgs_TobeStudiedProblemEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvgs_TobeStudiedProblemEN._CurrTabName);
if (IsNullOrEmpty(clsvgs_TobeStudiedProblemEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvgs_TobeStudiedProblemEN.CacheAddiCondition);
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
const arrvgs_TobeStudiedProblemExObjLst_Cache: Array<clsvgs_TobeStudiedProblemEN> = JSON.parse(strTempObjLst);
const arrvgs_TobeStudiedProblemObjLst_T = vgs_TobeStudiedProblem_GetObjLstByJSONObjLst(arrvgs_TobeStudiedProblemExObjLst_Cache);
return arrvgs_TobeStudiedProblemObjLst_T;
}
try
{
const arrvgs_TobeStudiedProblemExObjLst = await vgs_TobeStudiedProblem_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrvgs_TobeStudiedProblemExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvgs_TobeStudiedProblemExObjLst.length);
console.log(strInfo);
return arrvgs_TobeStudiedProblemExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vgs_TobeStudiedProblem_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vgs_TobeStudiedProblem_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsvgs_TobeStudiedProblemEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrvgs_TobeStudiedProblemObjLst_Cache: Array<clsvgs_TobeStudiedProblemEN> = JSON.parse(strTempObjLst);
return arrvgs_TobeStudiedProblemObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function vgs_TobeStudiedProblem_GetObjLstAsync(strWhereCond: string): Promise<Array<clsvgs_TobeStudiedProblemEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(vgs_TobeStudiedProblem_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_TobeStudiedProblem_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vgs_TobeStudiedProblem_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_TobeStudiedProblem_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_TobeStudiedProblem_ConstructorName, strThisFuncName);
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
export async function vgs_TobeStudiedProblem_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvgs_TobeStudiedProblemEN._CurrTabName;
clsvgs_TobeStudiedProblemEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvgs_TobeStudiedProblemEN._CurrTabName);
if (IsNullOrEmpty(clsvgs_TobeStudiedProblemEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvgs_TobeStudiedProblemEN.CacheAddiCondition);
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
const arrvgs_TobeStudiedProblemExObjLst_Cache: Array<clsvgs_TobeStudiedProblemEN> = JSON.parse(strTempObjLst);
const arrvgs_TobeStudiedProblemObjLst_T = vgs_TobeStudiedProblem_GetObjLstByJSONObjLst(arrvgs_TobeStudiedProblemExObjLst_Cache);
return arrvgs_TobeStudiedProblemObjLst_T;
}
try
{
const arrvgs_TobeStudiedProblemExObjLst = await vgs_TobeStudiedProblem_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrvgs_TobeStudiedProblemExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvgs_TobeStudiedProblemExObjLst.length);
console.log(strInfo);
return arrvgs_TobeStudiedProblemExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vgs_TobeStudiedProblem_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vgs_TobeStudiedProblem_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsvgs_TobeStudiedProblemEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrvgs_TobeStudiedProblemObjLst_Cache: Array<clsvgs_TobeStudiedProblemEN> = JSON.parse(strTempObjLst);
return arrvgs_TobeStudiedProblemObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vgs_TobeStudiedProblem_GetObjLst_Cache(): Promise<Array<clsvgs_TobeStudiedProblemEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrvgs_TobeStudiedProblemObjLst_Cache;
switch (clsvgs_TobeStudiedProblemEN.CacheModeId)
{
case "04"://sessionStorage
arrvgs_TobeStudiedProblemObjLst_Cache = await vgs_TobeStudiedProblem_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrvgs_TobeStudiedProblemObjLst_Cache = await vgs_TobeStudiedProblem_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrvgs_TobeStudiedProblemObjLst_Cache = await vgs_TobeStudiedProblem_GetObjLst_ClientCache();
break;
default:
arrvgs_TobeStudiedProblemObjLst_Cache = await vgs_TobeStudiedProblem_GetObjLst_ClientCache();
break;
}
const arrvgs_TobeStudiedProblemObjLst = vgs_TobeStudiedProblem_GetObjLstByJSONObjLst(arrvgs_TobeStudiedProblemObjLst_Cache);
return arrvgs_TobeStudiedProblemObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vgs_TobeStudiedProblem_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrvgs_TobeStudiedProblemObjLst_Cache;
switch (clsvgs_TobeStudiedProblemEN.CacheModeId)
{
case "04"://sessionStorage
arrvgs_TobeStudiedProblemObjLst_Cache = await vgs_TobeStudiedProblem_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrvgs_TobeStudiedProblemObjLst_Cache = await vgs_TobeStudiedProblem_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrvgs_TobeStudiedProblemObjLst_Cache = null;
break;
default:
arrvgs_TobeStudiedProblemObjLst_Cache = null;
break;
}
return arrvgs_TobeStudiedProblemObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrProblemId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vgs_TobeStudiedProblem_GetSubObjLst_Cache(objvgs_TobeStudiedProblem_Cond: clsvgs_TobeStudiedProblemEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrvgs_TobeStudiedProblemObjLst_Cache = await vgs_TobeStudiedProblem_GetObjLst_Cache();
let arrvgs_TobeStudiedProblem_Sel: Array < clsvgs_TobeStudiedProblemEN > = arrvgs_TobeStudiedProblemObjLst_Cache;
if (objvgs_TobeStudiedProblem_Cond.sf_FldComparisonOp == null || objvgs_TobeStudiedProblem_Cond.sf_FldComparisonOp == "") return arrvgs_TobeStudiedProblem_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvgs_TobeStudiedProblem_Cond.sf_FldComparisonOp);
//console.log("clsvgs_TobeStudiedProblemWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvgs_TobeStudiedProblem_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvgs_TobeStudiedProblem_Sel = arrvgs_TobeStudiedProblem_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvgs_TobeStudiedProblem_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvgs_TobeStudiedProblem_Sel = arrvgs_TobeStudiedProblem_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvgs_TobeStudiedProblem_Sel = arrvgs_TobeStudiedProblem_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvgs_TobeStudiedProblem_Sel = arrvgs_TobeStudiedProblem_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvgs_TobeStudiedProblem_Sel = arrvgs_TobeStudiedProblem_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvgs_TobeStudiedProblem_Sel = arrvgs_TobeStudiedProblem_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvgs_TobeStudiedProblem_Sel = arrvgs_TobeStudiedProblem_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvgs_TobeStudiedProblem_Sel = arrvgs_TobeStudiedProblem_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvgs_TobeStudiedProblem_Sel = arrvgs_TobeStudiedProblem_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvgs_TobeStudiedProblem_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objvgs_TobeStudiedProblem_Cond), vgs_TobeStudiedProblem_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvgs_TobeStudiedProblemEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrProblemId:关键字列表
 * @returns 对象列表
 **/
export async function vgs_TobeStudiedProblem_GetObjLstByProblemIdLstAsync(arrProblemId: Array<string>): Promise<Array<clsvgs_TobeStudiedProblemEN>>  
{
const strThisFuncName = "GetObjLstByProblemIdLstAsync";
const strAction = "GetObjLstByProblemIdLst";
const strUrl = GetWebApiUrl(vgs_TobeStudiedProblem_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrProblemId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_TobeStudiedProblem_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vgs_TobeStudiedProblem_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_TobeStudiedProblem_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_TobeStudiedProblem_ConstructorName, strThisFuncName);
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
 * @param arrstrProblemIdLst:关键字列表
 * @returns 对象列表
*/
export async function vgs_TobeStudiedProblem_GetObjLstByProblemIdLst_Cache(arrProblemIdLst: Array<string>) {
const strThisFuncName = "GetObjLstByProblemIdLst_Cache";
try
{
const arrvgs_TobeStudiedProblemObjLst_Cache = await vgs_TobeStudiedProblem_GetObjLst_Cache();
const arrvgs_TobeStudiedProblem_Sel: Array <clsvgs_TobeStudiedProblemEN> = arrvgs_TobeStudiedProblemObjLst_Cache.filter(x => arrProblemIdLst.indexOf(x.problemId)>-1);
return arrvgs_TobeStudiedProblem_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrProblemIdLst.join(","), vgs_TobeStudiedProblem_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvgs_TobeStudiedProblemEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function vgs_TobeStudiedProblem_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsvgs_TobeStudiedProblemEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(vgs_TobeStudiedProblem_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_TobeStudiedProblem_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vgs_TobeStudiedProblem_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_TobeStudiedProblem_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_TobeStudiedProblem_ConstructorName, strThisFuncName);
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
export async function vgs_TobeStudiedProblem_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsvgs_TobeStudiedProblemEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vgs_TobeStudiedProblem_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_TobeStudiedProblem_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vgs_TobeStudiedProblem_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_TobeStudiedProblem_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_TobeStudiedProblem_ConstructorName, strThisFuncName);
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
export async function vgs_TobeStudiedProblem_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vgs_TobeStudiedProblem_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_TobeStudiedProblem_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_TobeStudiedProblem_ConstructorName, strThisFuncName);
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
export async function vgs_TobeStudiedProblem_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrvgs_TobeStudiedProblemObjLst_Cache = await vgs_TobeStudiedProblem_GetObjLst_Cache();
if (arrvgs_TobeStudiedProblemObjLst_Cache.length == 0) return arrvgs_TobeStudiedProblemObjLst_Cache;
let arrvgs_TobeStudiedProblem_Sel = arrvgs_TobeStudiedProblemObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objvgs_TobeStudiedProblem_Cond = new clsvgs_TobeStudiedProblemEN();
ObjectAssign(objvgs_TobeStudiedProblem_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsvgs_TobeStudiedProblemWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvgs_TobeStudiedProblem_Sel = arrvgs_TobeStudiedProblem_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvgs_TobeStudiedProblem_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvgs_TobeStudiedProblem_Sel = arrvgs_TobeStudiedProblem_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvgs_TobeStudiedProblem_Sel = arrvgs_TobeStudiedProblem_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvgs_TobeStudiedProblem_Sel = arrvgs_TobeStudiedProblem_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvgs_TobeStudiedProblem_Sel = arrvgs_TobeStudiedProblem_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvgs_TobeStudiedProblem_Sel = arrvgs_TobeStudiedProblem_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvgs_TobeStudiedProblem_Sel = arrvgs_TobeStudiedProblem_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvgs_TobeStudiedProblem_Sel = arrvgs_TobeStudiedProblem_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvgs_TobeStudiedProblem_Sel = arrvgs_TobeStudiedProblem_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvgs_TobeStudiedProblem_Sel = arrvgs_TobeStudiedProblem_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvgs_TobeStudiedProblem_Sel.length == 0) return arrvgs_TobeStudiedProblem_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrvgs_TobeStudiedProblem_Sel = arrvgs_TobeStudiedProblem_Sel.sort(vgs_TobeStudiedProblem_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrvgs_TobeStudiedProblem_Sel = arrvgs_TobeStudiedProblem_Sel.sort(objPagerPara.sortFun);
}
arrvgs_TobeStudiedProblem_Sel = arrvgs_TobeStudiedProblem_Sel.slice(intStart, intEnd);     
return arrvgs_TobeStudiedProblem_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, vgs_TobeStudiedProblem_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvgs_TobeStudiedProblemEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function vgs_TobeStudiedProblem_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsvgs_TobeStudiedProblemEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(vgs_TobeStudiedProblem_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_TobeStudiedProblem_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vgs_TobeStudiedProblem_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_TobeStudiedProblem_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_TobeStudiedProblem_ConstructorName, strThisFuncName);
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
 * @param objstrProblemId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vgs_TobeStudiedProblem_IsExistRecord_Cache(objvgs_TobeStudiedProblem_Cond: clsvgs_TobeStudiedProblemEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrvgs_TobeStudiedProblemObjLst_Cache = await vgs_TobeStudiedProblem_GetObjLst_Cache();
if (arrvgs_TobeStudiedProblemObjLst_Cache == null) return false;
let arrvgs_TobeStudiedProblem_Sel: Array < clsvgs_TobeStudiedProblemEN > = arrvgs_TobeStudiedProblemObjLst_Cache;
if (objvgs_TobeStudiedProblem_Cond.sf_FldComparisonOp == null || objvgs_TobeStudiedProblem_Cond.sf_FldComparisonOp == "") return arrvgs_TobeStudiedProblem_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvgs_TobeStudiedProblem_Cond.sf_FldComparisonOp);
//console.log("clsvgs_TobeStudiedProblemWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvgs_TobeStudiedProblem_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvgs_TobeStudiedProblem_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvgs_TobeStudiedProblem_Sel = arrvgs_TobeStudiedProblem_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvgs_TobeStudiedProblem_Sel = arrvgs_TobeStudiedProblem_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvgs_TobeStudiedProblem_Sel = arrvgs_TobeStudiedProblem_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvgs_TobeStudiedProblem_Sel = arrvgs_TobeStudiedProblem_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvgs_TobeStudiedProblem_Sel = arrvgs_TobeStudiedProblem_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvgs_TobeStudiedProblem_Sel = arrvgs_TobeStudiedProblem_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvgs_TobeStudiedProblem_Sel = arrvgs_TobeStudiedProblem_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvgs_TobeStudiedProblem_Sel = arrvgs_TobeStudiedProblem_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvgs_TobeStudiedProblem_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objvgs_TobeStudiedProblem_Cond), vgs_TobeStudiedProblem_ConstructorName, strThisFuncName);
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
export async function vgs_TobeStudiedProblem_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(vgs_TobeStudiedProblem_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_TobeStudiedProblem_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_TobeStudiedProblem_ConstructorName, strThisFuncName);
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
 * @param strProblemId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function vgs_TobeStudiedProblem_IsExist(strProblemId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vgs_TobeStudiedProblem_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"ProblemId": strProblemId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_TobeStudiedProblem_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_TobeStudiedProblem_ConstructorName, strThisFuncName);
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
 * @param strProblemId:所给的关键字
 * @returns 对象
*/
export async function vgs_TobeStudiedProblem_IsExist_Cache(strProblemId:string) {
const strThisFuncName = "IsExist_Cache";
const arrvgs_TobeStudiedProblemObjLst_Cache = await vgs_TobeStudiedProblem_GetObjLst_Cache();
if (arrvgs_TobeStudiedProblemObjLst_Cache == null) return false;
try
{
const arrvgs_TobeStudiedProblem_Sel: Array <clsvgs_TobeStudiedProblemEN> = arrvgs_TobeStudiedProblemObjLst_Cache.filter(x => x.problemId == strProblemId);
if (arrvgs_TobeStudiedProblem_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strProblemId, vgs_TobeStudiedProblem_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param strProblemId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function vgs_TobeStudiedProblem_IsExistAsync(strProblemId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vgs_TobeStudiedProblem_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strProblemId": strProblemId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_TobeStudiedProblem_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_TobeStudiedProblem_ConstructorName, strThisFuncName);
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
export async function vgs_TobeStudiedProblem_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(vgs_TobeStudiedProblem_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_TobeStudiedProblem_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_TobeStudiedProblem_ConstructorName, strThisFuncName);
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
 * @param objvgs_TobeStudiedProblem_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function vgs_TobeStudiedProblem_GetRecCountByCond_Cache(objvgs_TobeStudiedProblem_Cond: clsvgs_TobeStudiedProblemEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrvgs_TobeStudiedProblemObjLst_Cache = await vgs_TobeStudiedProblem_GetObjLst_Cache();
if (arrvgs_TobeStudiedProblemObjLst_Cache == null) return 0;
let arrvgs_TobeStudiedProblem_Sel: Array < clsvgs_TobeStudiedProblemEN > = arrvgs_TobeStudiedProblemObjLst_Cache;
if (objvgs_TobeStudiedProblem_Cond.sf_FldComparisonOp == null || objvgs_TobeStudiedProblem_Cond.sf_FldComparisonOp == "") return arrvgs_TobeStudiedProblem_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvgs_TobeStudiedProblem_Cond.sf_FldComparisonOp);
//console.log("clsvgs_TobeStudiedProblemWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvgs_TobeStudiedProblem_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvgs_TobeStudiedProblem_Sel = arrvgs_TobeStudiedProblem_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvgs_TobeStudiedProblem_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvgs_TobeStudiedProblem_Sel = arrvgs_TobeStudiedProblem_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvgs_TobeStudiedProblem_Sel = arrvgs_TobeStudiedProblem_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvgs_TobeStudiedProblem_Sel = arrvgs_TobeStudiedProblem_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvgs_TobeStudiedProblem_Sel = arrvgs_TobeStudiedProblem_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvgs_TobeStudiedProblem_Sel = arrvgs_TobeStudiedProblem_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvgs_TobeStudiedProblem_Sel = arrvgs_TobeStudiedProblem_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvgs_TobeStudiedProblem_Sel = arrvgs_TobeStudiedProblem_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvgs_TobeStudiedProblem_Sel = arrvgs_TobeStudiedProblem_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvgs_TobeStudiedProblem_Sel = arrvgs_TobeStudiedProblem_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvgs_TobeStudiedProblem_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objvgs_TobeStudiedProblem_Cond), vgs_TobeStudiedProblem_ConstructorName, strThisFuncName);
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
export function vgs_TobeStudiedProblem_GetWebApiUrl(strController: string, strAction: string): string {
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
export function vgs_TobeStudiedProblem_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clsvgs_TobeStudiedProblemEN._CurrTabName;
switch (clsvgs_TobeStudiedProblemEN.CacheModeId)
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
export function vgs_TobeStudiedProblem_GetJSONStrByObj (pobjvgs_TobeStudiedProblemEN: clsvgs_TobeStudiedProblemEN): string
{
const strThisFuncName = "GetJSONStrByObj";
let strJson = "";
try
{
strJson = JSON.stringify(pobjvgs_TobeStudiedProblemEN);
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
export function vgs_TobeStudiedProblem_GetObjLstByJSONStr (strJSON: string): Array<clsvgs_TobeStudiedProblemEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrvgs_TobeStudiedProblemObjLst = new Array<clsvgs_TobeStudiedProblemEN>();
if (strJSON === "")
{
return arrvgs_TobeStudiedProblemObjLst;
}
try
{
arrvgs_TobeStudiedProblemObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvgs_TobeStudiedProblemObjLst;
}
return arrvgs_TobeStudiedProblemObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrvgs_TobeStudiedProblemObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function vgs_TobeStudiedProblem_GetObjLstByJSONObjLst (arrvgs_TobeStudiedProblemObjLstS: Array<clsvgs_TobeStudiedProblemEN>): Array<clsvgs_TobeStudiedProblemEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrvgs_TobeStudiedProblemObjLst = new Array<clsvgs_TobeStudiedProblemEN>();
for (const objInFor of arrvgs_TobeStudiedProblemObjLstS) {
const obj1 = vgs_TobeStudiedProblem_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrvgs_TobeStudiedProblemObjLst.push(obj1);
}
return arrvgs_TobeStudiedProblemObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vgs_TobeStudiedProblem_GetObjByJSONStr (strJSON: string): clsvgs_TobeStudiedProblemEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjvgs_TobeStudiedProblemEN = new clsvgs_TobeStudiedProblemEN();
if (strJSON === "")
{
return pobjvgs_TobeStudiedProblemEN;
}
try
{
pobjvgs_TobeStudiedProblemEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvgs_TobeStudiedProblemEN;
}
return pobjvgs_TobeStudiedProblemEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function vgs_TobeStudiedProblem_GetCombineCondition(objvgs_TobeStudiedProblem_Cond: clsvgs_TobeStudiedProblemEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objvgs_TobeStudiedProblem_Cond.dicFldComparisonOp, clsvgs_TobeStudiedProblemEN.con_ProblemId) == true)
{
const strComparisonOp_ProblemId:string = objvgs_TobeStudiedProblem_Cond.dicFldComparisonOp[clsvgs_TobeStudiedProblemEN.con_ProblemId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_TobeStudiedProblemEN.con_ProblemId, objvgs_TobeStudiedProblem_Cond.problemId, strComparisonOp_ProblemId);
}
if (Object.prototype.hasOwnProperty.call(objvgs_TobeStudiedProblem_Cond.dicFldComparisonOp, clsvgs_TobeStudiedProblemEN.con_ProblemTitle) == true)
{
const strComparisonOp_ProblemTitle:string = objvgs_TobeStudiedProblem_Cond.dicFldComparisonOp[clsvgs_TobeStudiedProblemEN.con_ProblemTitle];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_TobeStudiedProblemEN.con_ProblemTitle, objvgs_TobeStudiedProblem_Cond.problemTitle, strComparisonOp_ProblemTitle);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objvgs_TobeStudiedProblem_Cond.dicFldComparisonOp, clsvgs_TobeStudiedProblemEN.con_TopicId) == true)
{
const strComparisonOp_TopicId:string = objvgs_TobeStudiedProblem_Cond.dicFldComparisonOp[clsvgs_TobeStudiedProblemEN.con_TopicId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_TobeStudiedProblemEN.con_TopicId, objvgs_TobeStudiedProblem_Cond.topicId, strComparisonOp_TopicId);
}
if (Object.prototype.hasOwnProperty.call(objvgs_TobeStudiedProblem_Cond.dicFldComparisonOp, clsvgs_TobeStudiedProblemEN.con_TopicName) == true)
{
const strComparisonOp_TopicName:string = objvgs_TobeStudiedProblem_Cond.dicFldComparisonOp[clsvgs_TobeStudiedProblemEN.con_TopicName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_TobeStudiedProblemEN.con_TopicName, objvgs_TobeStudiedProblem_Cond.topicName, strComparisonOp_TopicName);
}
if (Object.prototype.hasOwnProperty.call(objvgs_TobeStudiedProblem_Cond.dicFldComparisonOp, clsvgs_TobeStudiedProblemEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objvgs_TobeStudiedProblem_Cond.dicFldComparisonOp[clsvgs_TobeStudiedProblemEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_TobeStudiedProblemEN.con_id_CurrEduCls, objvgs_TobeStudiedProblem_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (Object.prototype.hasOwnProperty.call(objvgs_TobeStudiedProblem_Cond.dicFldComparisonOp, clsvgs_TobeStudiedProblemEN.con_IsSubmit) == true)
{
if (objvgs_TobeStudiedProblem_Cond.isSubmit == true)
{
strWhereCond += Format(" And {0} = '1'", clsvgs_TobeStudiedProblemEN.con_IsSubmit);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvgs_TobeStudiedProblemEN.con_IsSubmit);
}
}
if (Object.prototype.hasOwnProperty.call(objvgs_TobeStudiedProblem_Cond.dicFldComparisonOp, clsvgs_TobeStudiedProblemEN.con_ProblemDate) == true)
{
const strComparisonOp_ProblemDate:string = objvgs_TobeStudiedProblem_Cond.dicFldComparisonOp[clsvgs_TobeStudiedProblemEN.con_ProblemDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_TobeStudiedProblemEN.con_ProblemDate, objvgs_TobeStudiedProblem_Cond.problemDate, strComparisonOp_ProblemDate);
}
if (Object.prototype.hasOwnProperty.call(objvgs_TobeStudiedProblem_Cond.dicFldComparisonOp, clsvgs_TobeStudiedProblemEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objvgs_TobeStudiedProblem_Cond.dicFldComparisonOp[clsvgs_TobeStudiedProblemEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_TobeStudiedProblemEN.con_UpdDate, objvgs_TobeStudiedProblem_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objvgs_TobeStudiedProblem_Cond.dicFldComparisonOp, clsvgs_TobeStudiedProblemEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objvgs_TobeStudiedProblem_Cond.dicFldComparisonOp[clsvgs_TobeStudiedProblemEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_TobeStudiedProblemEN.con_UpdUser, objvgs_TobeStudiedProblem_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objvgs_TobeStudiedProblem_Cond.dicFldComparisonOp, clsvgs_TobeStudiedProblemEN.con_Year) == true)
{
const strComparisonOp_Year:string = objvgs_TobeStudiedProblem_Cond.dicFldComparisonOp[clsvgs_TobeStudiedProblemEN.con_Year];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_TobeStudiedProblemEN.con_Year, objvgs_TobeStudiedProblem_Cond.year, strComparisonOp_Year);
}
if (Object.prototype.hasOwnProperty.call(objvgs_TobeStudiedProblem_Cond.dicFldComparisonOp, clsvgs_TobeStudiedProblemEN.con_Month) == true)
{
const strComparisonOp_Month:string = objvgs_TobeStudiedProblem_Cond.dicFldComparisonOp[clsvgs_TobeStudiedProblemEN.con_Month];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_TobeStudiedProblemEN.con_Month, objvgs_TobeStudiedProblem_Cond.month, strComparisonOp_Month);
}
if (Object.prototype.hasOwnProperty.call(objvgs_TobeStudiedProblem_Cond.dicFldComparisonOp, clsvgs_TobeStudiedProblemEN.con_VersionCount) == true)
{
const strComparisonOp_VersionCount:string = objvgs_TobeStudiedProblem_Cond.dicFldComparisonOp[clsvgs_TobeStudiedProblemEN.con_VersionCount];
strWhereCond += Format(" And {0} {2} {1}", clsvgs_TobeStudiedProblemEN.con_VersionCount, objvgs_TobeStudiedProblem_Cond.versionCount, strComparisonOp_VersionCount);
}
if (Object.prototype.hasOwnProperty.call(objvgs_TobeStudiedProblem_Cond.dicFldComparisonOp, clsvgs_TobeStudiedProblemEN.con_Participant) == true)
{
const strComparisonOp_Participant:string = objvgs_TobeStudiedProblem_Cond.dicFldComparisonOp[clsvgs_TobeStudiedProblemEN.con_Participant];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_TobeStudiedProblemEN.con_Participant, objvgs_TobeStudiedProblem_Cond.participant, strComparisonOp_Participant);
}
if (Object.prototype.hasOwnProperty.call(objvgs_TobeStudiedProblem_Cond.dicFldComparisonOp, clsvgs_TobeStudiedProblemEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objvgs_TobeStudiedProblem_Cond.dicFldComparisonOp[clsvgs_TobeStudiedProblemEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_TobeStudiedProblemEN.con_Memo, objvgs_TobeStudiedProblem_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--vgs_TobeStudiedProblem(待研究问题视图),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param strProblemId: 问题Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function vgs_TobeStudiedProblem_GetUniCondStr_ProblemId(objvgs_TobeStudiedProblemEN: clsvgs_TobeStudiedProblemEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and ProblemId = '{0}'", objvgs_TobeStudiedProblemEN.problemId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--vgs_TobeStudiedProblem(待研究问题视图),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param strProblemId: 问题Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function vgs_TobeStudiedProblem_GetUniCondStr4Update_ProblemId(objvgs_TobeStudiedProblemEN: clsvgs_TobeStudiedProblemEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and ProblemId <> '{0}'", objvgs_TobeStudiedProblemEN.problemId);
 strWhereCond +=  Format(" and ProblemId = '{0}'", objvgs_TobeStudiedProblemEN.problemId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objvgs_TobeStudiedProblemENS:源对象
 * @param objvgs_TobeStudiedProblemENT:目标对象
*/
export function vgs_TobeStudiedProblem_CopyObjTo(objvgs_TobeStudiedProblemENS: clsvgs_TobeStudiedProblemEN , objvgs_TobeStudiedProblemENT: clsvgs_TobeStudiedProblemEN ): void 
{
objvgs_TobeStudiedProblemENT.problemId = objvgs_TobeStudiedProblemENS.problemId; //问题Id
objvgs_TobeStudiedProblemENT.problemTitle = objvgs_TobeStudiedProblemENS.problemTitle; //问题标题
objvgs_TobeStudiedProblemENT.problemContent = objvgs_TobeStudiedProblemENS.problemContent; //问题内容
objvgs_TobeStudiedProblemENT.topicId = objvgs_TobeStudiedProblemENS.topicId; //主题Id
objvgs_TobeStudiedProblemENT.topicName = objvgs_TobeStudiedProblemENS.topicName; //栏目主题
objvgs_TobeStudiedProblemENT.id_CurrEduCls = objvgs_TobeStudiedProblemENS.id_CurrEduCls; //教学班流水号
objvgs_TobeStudiedProblemENT.isSubmit = objvgs_TobeStudiedProblemENS.isSubmit; //是否提交
objvgs_TobeStudiedProblemENT.problemDate = objvgs_TobeStudiedProblemENS.problemDate; //问题日期
objvgs_TobeStudiedProblemENT.updDate = objvgs_TobeStudiedProblemENS.updDate; //修改日期
objvgs_TobeStudiedProblemENT.updUser = objvgs_TobeStudiedProblemENS.updUser; //修改人
objvgs_TobeStudiedProblemENT.year = objvgs_TobeStudiedProblemENS.year; //年
objvgs_TobeStudiedProblemENT.month = objvgs_TobeStudiedProblemENS.month; //月
objvgs_TobeStudiedProblemENT.versionCount = objvgs_TobeStudiedProblemENS.versionCount; //版本统计
objvgs_TobeStudiedProblemENT.participant = objvgs_TobeStudiedProblemENS.participant; //参与者
objvgs_TobeStudiedProblemENT.memo = objvgs_TobeStudiedProblemENS.memo; //备注
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objvgs_TobeStudiedProblemENS:源对象
 * @param objvgs_TobeStudiedProblemENT:目标对象
*/
export function vgs_TobeStudiedProblem_GetObjFromJsonObj(objvgs_TobeStudiedProblemENS: clsvgs_TobeStudiedProblemEN): clsvgs_TobeStudiedProblemEN 
{
 const objvgs_TobeStudiedProblemENT: clsvgs_TobeStudiedProblemEN = new clsvgs_TobeStudiedProblemEN();
ObjectAssign(objvgs_TobeStudiedProblemENT, objvgs_TobeStudiedProblemENS);
 return objvgs_TobeStudiedProblemENT;
}