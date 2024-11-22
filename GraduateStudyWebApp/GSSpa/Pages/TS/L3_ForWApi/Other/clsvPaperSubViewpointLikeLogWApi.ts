
 /**
 * 类名:clsvPaperSubViewpointLikeLogWApi
 * 表名:vPaperSubViewpointLikeLog(01120563)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 12:02:33
 * 生成者:pyf
 * 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:其他(Other)
 * 框架-层名:WA_访问层(TS)(WA_Access)
 * 编程语言:TypeScript
 * 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
   *      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 **/

/**
 * v子观点点赞表(vPaperSubViewpointLikeLog)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clsvPaperSubViewpointLikeLogEN } from "../../L0_Entity/Other/clsvPaperSubViewpointLikeLogEN.js";
import { BindDdl_ObjLstInDiv_V, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const vPaperSubViewpointLikeLog_Controller = "vPaperSubViewpointLikeLogApi";
 export const vPaperSubViewpointLikeLog_ConstructorName = "vPaperSubViewpointLikeLog";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngPaperSubViewpointLikeLogId:关键字
 * @returns 对象
 **/
export async function vPaperSubViewpointLikeLog_GetObjByPaperSubViewpointLikeLogIdAsync(lngPaperSubViewpointLikeLogId: number): Promise<clsvPaperSubViewpointLikeLogEN>  
{
const strThisFuncName = "GetObjByPaperSubViewpointLikeLogIdAsync";

if (lngPaperSubViewpointLikeLogId == 0)
{
  const strMsg = Format("参数:[lngPaperSubViewpointLikeLogId]不能为空！(In GetObjByPaperSubViewpointLikeLogIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjByPaperSubViewpointLikeLogId";
const strUrl = GetWebApiUrl(vPaperSubViewpointLikeLog_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"lngPaperSubViewpointLikeLogId": lngPaperSubViewpointLikeLogId,
}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObj = data.returnObj;
if (returnObj == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvPaperSubViewpointLikeLog = vPaperSubViewpointLikeLog_GetObjFromJsonObj(returnObj);
return objvPaperSubViewpointLikeLog;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
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
 * @param lngPaperSubViewpointLikeLogId:所给的关键字
 * @returns 对象
*/
export async function vPaperSubViewpointLikeLog_GetObjByPaperSubViewpointLikeLogId_Cache(lngPaperSubViewpointLikeLogId: number, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByPaperSubViewpointLikeLogId_Cache";

if (lngPaperSubViewpointLikeLogId == 0)
{
  const strMsg = Format("参数:[lngPaperSubViewpointLikeLogId]不能为空！(In GetObjByPaperSubViewpointLikeLogId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
const arrvPaperSubViewpointLikeLogObjLst_Cache = await vPaperSubViewpointLikeLog_GetObjLst_Cache();
try
{
const arrvPaperSubViewpointLikeLog_Sel: Array <clsvPaperSubViewpointLikeLogEN> = arrvPaperSubViewpointLikeLogObjLst_Cache.filter(x => x.paperSubViewpointLikeLogId == lngPaperSubViewpointLikeLogId);
let objvPaperSubViewpointLikeLog: clsvPaperSubViewpointLikeLogEN;
if (arrvPaperSubViewpointLikeLog_Sel.length > 0)
{
objvPaperSubViewpointLikeLog = arrvPaperSubViewpointLikeLog_Sel[0];
return objvPaperSubViewpointLikeLog;
}
else
{
if (bolTryAsyncOnce == true)
{
objvPaperSubViewpointLikeLog = await vPaperSubViewpointLikeLog_GetObjByPaperSubViewpointLikeLogIdAsync(lngPaperSubViewpointLikeLogId);
if (objvPaperSubViewpointLikeLog != null)
{
vPaperSubViewpointLikeLog_ReFreshThisCache();
return objvPaperSubViewpointLikeLog;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngPaperSubViewpointLikeLogId, vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param lngPaperSubViewpointLikeLogId:所给的关键字
 * @returns 对象
*/
export async function vPaperSubViewpointLikeLog_GetObjByPaperSubViewpointLikeLogId_localStorage(lngPaperSubViewpointLikeLogId: number) {
const strThisFuncName = "GetObjByPaperSubViewpointLikeLogId_localStorage";

if (lngPaperSubViewpointLikeLogId == 0)
{
  const strMsg = Format("参数:[lngPaperSubViewpointLikeLogId]不能为空！(In GetObjByPaperSubViewpointLikeLogId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
const strKey = Format("{0}_{1}", clsvPaperSubViewpointLikeLogEN._CurrTabName, lngPaperSubViewpointLikeLogId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objvPaperSubViewpointLikeLog_Cache: clsvPaperSubViewpointLikeLogEN = JSON.parse(strTempObj);
return objvPaperSubViewpointLikeLog_Cache;
}
try
{
const objvPaperSubViewpointLikeLog = await vPaperSubViewpointLikeLog_GetObjByPaperSubViewpointLikeLogIdAsync(lngPaperSubViewpointLikeLogId);
if (objvPaperSubViewpointLikeLog != null)
{
localStorage.setItem(strKey, JSON.stringify(objvPaperSubViewpointLikeLog));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objvPaperSubViewpointLikeLog;
}
return objvPaperSubViewpointLikeLog;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngPaperSubViewpointLikeLogId, vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
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
export async function vPaperSubViewpointLikeLog_func(strInFldName:string , strOutFldName:string ,  strInValue: string) 
{
//const strThisFuncName = "func";

if (strInFldName != clsvPaperSubViewpointLikeLogEN.con_PaperSubViewpointLikeLogId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsvPaperSubViewpointLikeLogEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clsvPaperSubViewpointLikeLogEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const lngPaperSubViewpointLikeLogId = Number(strInValue);
if (lngPaperSubViewpointLikeLogId == 0)
{
return "";
}
const objvPaperSubViewpointLikeLog = await vPaperSubViewpointLikeLog_GetObjByPaperSubViewpointLikeLogId_Cache(lngPaperSubViewpointLikeLogId );
if (objvPaperSubViewpointLikeLog == null) return "";
return objvPaperSubViewpointLikeLog.GetFldValue(strOutFldName).toString();
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
export function vPaperSubViewpointLikeLog_SortFun_Defa(a:clsvPaperSubViewpointLikeLogEN , b:clsvPaperSubViewpointLikeLogEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.paperSubViewpointLikeLogId-b.paperSubViewpointLikeLogId;
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
export function vPaperSubViewpointLikeLog_SortFun_Defa_2Fld(a:clsvPaperSubViewpointLikeLogEN , b:clsvPaperSubViewpointLikeLogEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.updDate == b.updDate) return a.memo.localeCompare(b.memo);
else return a.updDate.localeCompare(b.updDate);
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
export function vPaperSubViewpointLikeLog_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsvPaperSubViewpointLikeLogEN.con_PaperSubViewpointLikeLogId:
return (a: clsvPaperSubViewpointLikeLogEN, b: clsvPaperSubViewpointLikeLogEN) => {
return a.paperSubViewpointLikeLogId-b.paperSubViewpointLikeLogId;
}
case clsvPaperSubViewpointLikeLogEN.con_UpdDate:
return (a: clsvPaperSubViewpointLikeLogEN, b: clsvPaperSubViewpointLikeLogEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsvPaperSubViewpointLikeLogEN.con_Memo:
return (a: clsvPaperSubViewpointLikeLogEN, b: clsvPaperSubViewpointLikeLogEN) => {
return a.memo.localeCompare(b.memo);
}
case clsvPaperSubViewpointLikeLogEN.con_RWTitle:
return (a: clsvPaperSubViewpointLikeLogEN, b: clsvPaperSubViewpointLikeLogEN) => {
return a.rwTitle.localeCompare(b.rwTitle);
}
case clsvPaperSubViewpointLikeLogEN.con_SubViewpointContent:
return (a: clsvPaperSubViewpointLikeLogEN, b: clsvPaperSubViewpointLikeLogEN) => {
return a.subViewpointContent.localeCompare(b.subViewpointContent);
}
case clsvPaperSubViewpointLikeLogEN.con_ExplainContent:
return (a: clsvPaperSubViewpointLikeLogEN, b: clsvPaperSubViewpointLikeLogEN) => {
return a.explainContent.localeCompare(b.explainContent);
}
case clsvPaperSubViewpointLikeLogEN.con_PaperRWId:
return (a: clsvPaperSubViewpointLikeLogEN, b: clsvPaperSubViewpointLikeLogEN) => {
return a.paperRWId.localeCompare(b.paperRWId);
}
case clsvPaperSubViewpointLikeLogEN.con_SubViewpointId:
return (a: clsvPaperSubViewpointLikeLogEN, b: clsvPaperSubViewpointLikeLogEN) => {
return a.subViewpointId-b.subViewpointId;
}
case clsvPaperSubViewpointLikeLogEN.con_UpdUser:
return (a: clsvPaperSubViewpointLikeLogEN, b: clsvPaperSubViewpointLikeLogEN) => {
return a.updUser.localeCompare(b.updUser);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vPaperSubViewpointLikeLog]中不存在！(in ${ vPaperSubViewpointLikeLog_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsvPaperSubViewpointLikeLogEN.con_PaperSubViewpointLikeLogId:
return (a: clsvPaperSubViewpointLikeLogEN, b: clsvPaperSubViewpointLikeLogEN) => {
return b.paperSubViewpointLikeLogId-a.paperSubViewpointLikeLogId;
}
case clsvPaperSubViewpointLikeLogEN.con_UpdDate:
return (a: clsvPaperSubViewpointLikeLogEN, b: clsvPaperSubViewpointLikeLogEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsvPaperSubViewpointLikeLogEN.con_Memo:
return (a: clsvPaperSubViewpointLikeLogEN, b: clsvPaperSubViewpointLikeLogEN) => {
return b.memo.localeCompare(a.memo);
}
case clsvPaperSubViewpointLikeLogEN.con_RWTitle:
return (a: clsvPaperSubViewpointLikeLogEN, b: clsvPaperSubViewpointLikeLogEN) => {
return b.rwTitle.localeCompare(a.rwTitle);
}
case clsvPaperSubViewpointLikeLogEN.con_SubViewpointContent:
return (a: clsvPaperSubViewpointLikeLogEN, b: clsvPaperSubViewpointLikeLogEN) => {
return b.subViewpointContent.localeCompare(a.subViewpointContent);
}
case clsvPaperSubViewpointLikeLogEN.con_ExplainContent:
return (a: clsvPaperSubViewpointLikeLogEN, b: clsvPaperSubViewpointLikeLogEN) => {
return b.explainContent.localeCompare(a.explainContent);
}
case clsvPaperSubViewpointLikeLogEN.con_PaperRWId:
return (a: clsvPaperSubViewpointLikeLogEN, b: clsvPaperSubViewpointLikeLogEN) => {
return b.paperRWId.localeCompare(a.paperRWId);
}
case clsvPaperSubViewpointLikeLogEN.con_SubViewpointId:
return (a: clsvPaperSubViewpointLikeLogEN, b: clsvPaperSubViewpointLikeLogEN) => {
return b.subViewpointId-a.subViewpointId;
}
case clsvPaperSubViewpointLikeLogEN.con_UpdUser:
return (a: clsvPaperSubViewpointLikeLogEN, b: clsvPaperSubViewpointLikeLogEN) => {
return b.updUser.localeCompare(a.updUser);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vPaperSubViewpointLikeLog]中不存在！(in ${ vPaperSubViewpointLikeLog_ConstructorName}.${ strThisFuncName})`;
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
export async function vPaperSubViewpointLikeLog_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsvPaperSubViewpointLikeLogEN.con_PaperSubViewpointLikeLogId:
return (obj: clsvPaperSubViewpointLikeLogEN) => {
return obj.paperSubViewpointLikeLogId === value;
}
case clsvPaperSubViewpointLikeLogEN.con_UpdDate:
return (obj: clsvPaperSubViewpointLikeLogEN) => {
return obj.updDate === value;
}
case clsvPaperSubViewpointLikeLogEN.con_Memo:
return (obj: clsvPaperSubViewpointLikeLogEN) => {
return obj.memo === value;
}
case clsvPaperSubViewpointLikeLogEN.con_RWTitle:
return (obj: clsvPaperSubViewpointLikeLogEN) => {
return obj.rwTitle === value;
}
case clsvPaperSubViewpointLikeLogEN.con_SubViewpointContent:
return (obj: clsvPaperSubViewpointLikeLogEN) => {
return obj.subViewpointContent === value;
}
case clsvPaperSubViewpointLikeLogEN.con_ExplainContent:
return (obj: clsvPaperSubViewpointLikeLogEN) => {
return obj.explainContent === value;
}
case clsvPaperSubViewpointLikeLogEN.con_PaperRWId:
return (obj: clsvPaperSubViewpointLikeLogEN) => {
return obj.paperRWId === value;
}
case clsvPaperSubViewpointLikeLogEN.con_SubViewpointId:
return (obj: clsvPaperSubViewpointLikeLogEN) => {
return obj.subViewpointId === value;
}
case clsvPaperSubViewpointLikeLogEN.con_UpdUser:
return (obj: clsvPaperSubViewpointLikeLogEN) => {
return obj.updUser === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vPaperSubViewpointLikeLog]中不存在！(in ${ vPaperSubViewpointLikeLog_ConstructorName}.${ strThisFuncName})`;
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
export async function vPaperSubViewpointLikeLog_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vPaperSubViewpointLikeLog_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
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
export async function vPaperSubViewpointLikeLog_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vPaperSubViewpointLikeLog_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
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
export async function vPaperSubViewpointLikeLog_GetFirstObjAsync(strWhereCond: string): Promise<clsvPaperSubViewpointLikeLogEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(vPaperSubViewpointLikeLog_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvPaperSubViewpointLikeLog = vPaperSubViewpointLikeLog_GetObjFromJsonObj(returnObj);
return objvPaperSubViewpointLikeLog;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
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
export async function vPaperSubViewpointLikeLog_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvPaperSubViewpointLikeLogEN._CurrTabName;
clsvPaperSubViewpointLikeLogEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvPaperSubViewpointLikeLogEN._CurrTabName);
if (IsNullOrEmpty(clsvPaperSubViewpointLikeLogEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvPaperSubViewpointLikeLogEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrvPaperSubViewpointLikeLogExObjLst_Cache: Array<clsvPaperSubViewpointLikeLogEN> = CacheHelper.Get(strKey);
const arrvPaperSubViewpointLikeLogObjLst_T = vPaperSubViewpointLikeLog_GetObjLstByJSONObjLst(arrvPaperSubViewpointLikeLogExObjLst_Cache);
return arrvPaperSubViewpointLikeLogObjLst_T;
}
try
{
const arrvPaperSubViewpointLikeLogExObjLst = await vPaperSubViewpointLikeLog_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrvPaperSubViewpointLikeLogExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvPaperSubViewpointLikeLogExObjLst.length);
console.log(strInfo);
return arrvPaperSubViewpointLikeLogExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vPaperSubViewpointLikeLog_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvPaperSubViewpointLikeLogEN._CurrTabName;
clsvPaperSubViewpointLikeLogEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvPaperSubViewpointLikeLogEN._CurrTabName);
if (IsNullOrEmpty(clsvPaperSubViewpointLikeLogEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvPaperSubViewpointLikeLogEN.CacheAddiCondition);
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
const arrvPaperSubViewpointLikeLogExObjLst_Cache: Array<clsvPaperSubViewpointLikeLogEN> = JSON.parse(strTempObjLst);
const arrvPaperSubViewpointLikeLogObjLst_T = vPaperSubViewpointLikeLog_GetObjLstByJSONObjLst(arrvPaperSubViewpointLikeLogExObjLst_Cache);
return arrvPaperSubViewpointLikeLogObjLst_T;
}
try
{
const arrvPaperSubViewpointLikeLogExObjLst = await vPaperSubViewpointLikeLog_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrvPaperSubViewpointLikeLogExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvPaperSubViewpointLikeLogExObjLst.length);
console.log(strInfo);
return arrvPaperSubViewpointLikeLogExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vPaperSubViewpointLikeLog_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsvPaperSubViewpointLikeLogEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrvPaperSubViewpointLikeLogObjLst_Cache: Array<clsvPaperSubViewpointLikeLogEN> = JSON.parse(strTempObjLst);
return arrvPaperSubViewpointLikeLogObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function vPaperSubViewpointLikeLog_GetObjLstAsync(strWhereCond: string): Promise<Array<clsvPaperSubViewpointLikeLogEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(vPaperSubViewpointLikeLog_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vPaperSubViewpointLikeLog_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
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
export async function vPaperSubViewpointLikeLog_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvPaperSubViewpointLikeLogEN._CurrTabName;
clsvPaperSubViewpointLikeLogEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvPaperSubViewpointLikeLogEN._CurrTabName);
if (IsNullOrEmpty(clsvPaperSubViewpointLikeLogEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvPaperSubViewpointLikeLogEN.CacheAddiCondition);
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
const arrvPaperSubViewpointLikeLogExObjLst_Cache: Array<clsvPaperSubViewpointLikeLogEN> = JSON.parse(strTempObjLst);
const arrvPaperSubViewpointLikeLogObjLst_T = vPaperSubViewpointLikeLog_GetObjLstByJSONObjLst(arrvPaperSubViewpointLikeLogExObjLst_Cache);
return arrvPaperSubViewpointLikeLogObjLst_T;
}
try
{
const arrvPaperSubViewpointLikeLogExObjLst = await vPaperSubViewpointLikeLog_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrvPaperSubViewpointLikeLogExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvPaperSubViewpointLikeLogExObjLst.length);
console.log(strInfo);
return arrvPaperSubViewpointLikeLogExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vPaperSubViewpointLikeLog_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsvPaperSubViewpointLikeLogEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrvPaperSubViewpointLikeLogObjLst_Cache: Array<clsvPaperSubViewpointLikeLogEN> = JSON.parse(strTempObjLst);
return arrvPaperSubViewpointLikeLogObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vPaperSubViewpointLikeLog_GetObjLst_Cache(): Promise<Array<clsvPaperSubViewpointLikeLogEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrvPaperSubViewpointLikeLogObjLst_Cache;
switch (clsvPaperSubViewpointLikeLogEN.CacheModeId)
{
case "04"://sessionStorage
arrvPaperSubViewpointLikeLogObjLst_Cache = await vPaperSubViewpointLikeLog_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrvPaperSubViewpointLikeLogObjLst_Cache = await vPaperSubViewpointLikeLog_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrvPaperSubViewpointLikeLogObjLst_Cache = await vPaperSubViewpointLikeLog_GetObjLst_ClientCache();
break;
default:
arrvPaperSubViewpointLikeLogObjLst_Cache = await vPaperSubViewpointLikeLog_GetObjLst_ClientCache();
break;
}
const arrvPaperSubViewpointLikeLogObjLst = vPaperSubViewpointLikeLog_GetObjLstByJSONObjLst(arrvPaperSubViewpointLikeLogObjLst_Cache);
return arrvPaperSubViewpointLikeLogObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vPaperSubViewpointLikeLog_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrvPaperSubViewpointLikeLogObjLst_Cache;
switch (clsvPaperSubViewpointLikeLogEN.CacheModeId)
{
case "04"://sessionStorage
arrvPaperSubViewpointLikeLogObjLst_Cache = await vPaperSubViewpointLikeLog_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrvPaperSubViewpointLikeLogObjLst_Cache = await vPaperSubViewpointLikeLog_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrvPaperSubViewpointLikeLogObjLst_Cache = null;
break;
default:
arrvPaperSubViewpointLikeLogObjLst_Cache = null;
break;
}
return arrvPaperSubViewpointLikeLogObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objlngPaperSubViewpointLikeLogId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vPaperSubViewpointLikeLog_GetSubObjLst_Cache(objvPaperSubViewpointLikeLog_Cond: clsvPaperSubViewpointLikeLogEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrvPaperSubViewpointLikeLogObjLst_Cache = await vPaperSubViewpointLikeLog_GetObjLst_Cache();
let arrvPaperSubViewpointLikeLog_Sel: Array < clsvPaperSubViewpointLikeLogEN > = arrvPaperSubViewpointLikeLogObjLst_Cache;
if (objvPaperSubViewpointLikeLog_Cond.sf_FldComparisonOp == null || objvPaperSubViewpointLikeLog_Cond.sf_FldComparisonOp == "") return arrvPaperSubViewpointLikeLog_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvPaperSubViewpointLikeLog_Cond.sf_FldComparisonOp);
//console.log("clsvPaperSubViewpointLikeLogWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvPaperSubViewpointLikeLog_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvPaperSubViewpointLikeLog_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvPaperSubViewpointLikeLog_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objvPaperSubViewpointLikeLog_Cond), vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvPaperSubViewpointLikeLogEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrPaperSubViewpointLikeLogId:关键字列表
 * @returns 对象列表
 **/
export async function vPaperSubViewpointLikeLog_GetObjLstByPaperSubViewpointLikeLogIdLstAsync(arrPaperSubViewpointLikeLogId: Array<string>): Promise<Array<clsvPaperSubViewpointLikeLogEN>>  
{
const strThisFuncName = "GetObjLstByPaperSubViewpointLikeLogIdLstAsync";
const strAction = "GetObjLstByPaperSubViewpointLikeLogIdLst";
const strUrl = GetWebApiUrl(vPaperSubViewpointLikeLog_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrPaperSubViewpointLikeLogId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vPaperSubViewpointLikeLog_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
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
 * @param arrlngPaperSubViewpointLikeLogIdLst:关键字列表
 * @returns 对象列表
*/
export async function vPaperSubViewpointLikeLog_GetObjLstByPaperSubViewpointLikeLogIdLst_Cache(arrPaperSubViewpointLikeLogIdLst: Array<number>) {
const strThisFuncName = "GetObjLstByPaperSubViewpointLikeLogIdLst_Cache";
try
{
const arrvPaperSubViewpointLikeLogObjLst_Cache = await vPaperSubViewpointLikeLog_GetObjLst_Cache();
const arrvPaperSubViewpointLikeLog_Sel: Array <clsvPaperSubViewpointLikeLogEN> = arrvPaperSubViewpointLikeLogObjLst_Cache.filter(x => arrPaperSubViewpointLikeLogIdLst.indexOf(x.paperSubViewpointLikeLogId)>-1);
return arrvPaperSubViewpointLikeLog_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrPaperSubViewpointLikeLogIdLst.join(","), vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvPaperSubViewpointLikeLogEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function vPaperSubViewpointLikeLog_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsvPaperSubViewpointLikeLogEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(vPaperSubViewpointLikeLog_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vPaperSubViewpointLikeLog_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
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
export async function vPaperSubViewpointLikeLog_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsvPaperSubViewpointLikeLogEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vPaperSubViewpointLikeLog_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vPaperSubViewpointLikeLog_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
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
export async function vPaperSubViewpointLikeLog_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vPaperSubViewpointLikeLog_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
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
export async function vPaperSubViewpointLikeLog_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrvPaperSubViewpointLikeLogObjLst_Cache = await vPaperSubViewpointLikeLog_GetObjLst_Cache();
if (arrvPaperSubViewpointLikeLogObjLst_Cache.length == 0) return arrvPaperSubViewpointLikeLogObjLst_Cache;
let arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLogObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objvPaperSubViewpointLikeLog_Cond = new clsvPaperSubViewpointLikeLogEN();
ObjectAssign(objvPaperSubViewpointLikeLog_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsvPaperSubViewpointLikeLogWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvPaperSubViewpointLikeLog_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvPaperSubViewpointLikeLog_Sel.length == 0) return arrvPaperSubViewpointLikeLog_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.sort(vPaperSubViewpointLikeLog_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.sort(objPagerPara.sortFun);
}
arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.slice(intStart, intEnd);     
return arrvPaperSubViewpointLikeLog_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvPaperSubViewpointLikeLogEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function vPaperSubViewpointLikeLog_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsvPaperSubViewpointLikeLogEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(vPaperSubViewpointLikeLog_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vPaperSubViewpointLikeLog_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
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
 * @param objlngPaperSubViewpointLikeLogId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vPaperSubViewpointLikeLog_IsExistRecord_Cache(objvPaperSubViewpointLikeLog_Cond: clsvPaperSubViewpointLikeLogEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrvPaperSubViewpointLikeLogObjLst_Cache = await vPaperSubViewpointLikeLog_GetObjLst_Cache();
if (arrvPaperSubViewpointLikeLogObjLst_Cache == null) return false;
let arrvPaperSubViewpointLikeLog_Sel: Array < clsvPaperSubViewpointLikeLogEN > = arrvPaperSubViewpointLikeLogObjLst_Cache;
if (objvPaperSubViewpointLikeLog_Cond.sf_FldComparisonOp == null || objvPaperSubViewpointLikeLog_Cond.sf_FldComparisonOp == "") return arrvPaperSubViewpointLikeLog_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvPaperSubViewpointLikeLog_Cond.sf_FldComparisonOp);
//console.log("clsvPaperSubViewpointLikeLogWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvPaperSubViewpointLikeLog_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvPaperSubViewpointLikeLog_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvPaperSubViewpointLikeLog_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objvPaperSubViewpointLikeLog_Cond), vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
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
export async function vPaperSubViewpointLikeLog_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(vPaperSubViewpointLikeLog_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
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
 * @param lngPaperSubViewpointLikeLogId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function vPaperSubViewpointLikeLog_IsExist(lngPaperSubViewpointLikeLogId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vPaperSubViewpointLikeLog_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"PaperSubViewpointLikeLogId": lngPaperSubViewpointLikeLogId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
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
 * @param lngPaperSubViewpointLikeLogId:所给的关键字
 * @returns 对象
*/
export async function vPaperSubViewpointLikeLog_IsExist_Cache(lngPaperSubViewpointLikeLogId:number) {
const strThisFuncName = "IsExist_Cache";
const arrvPaperSubViewpointLikeLogObjLst_Cache = await vPaperSubViewpointLikeLog_GetObjLst_Cache();
if (arrvPaperSubViewpointLikeLogObjLst_Cache == null) return false;
try
{
const arrvPaperSubViewpointLikeLog_Sel: Array <clsvPaperSubViewpointLikeLogEN> = arrvPaperSubViewpointLikeLogObjLst_Cache.filter(x => x.paperSubViewpointLikeLogId == lngPaperSubViewpointLikeLogId);
if (arrvPaperSubViewpointLikeLog_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngPaperSubViewpointLikeLogId, vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param lngPaperSubViewpointLikeLogId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function vPaperSubViewpointLikeLog_IsExistAsync(lngPaperSubViewpointLikeLogId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vPaperSubViewpointLikeLog_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "lngPaperSubViewpointLikeLogId": lngPaperSubViewpointLikeLogId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
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
export async function vPaperSubViewpointLikeLog_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(vPaperSubViewpointLikeLog_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
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
 * @param objvPaperSubViewpointLikeLog_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function vPaperSubViewpointLikeLog_GetRecCountByCond_Cache(objvPaperSubViewpointLikeLog_Cond: clsvPaperSubViewpointLikeLogEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrvPaperSubViewpointLikeLogObjLst_Cache = await vPaperSubViewpointLikeLog_GetObjLst_Cache();
if (arrvPaperSubViewpointLikeLogObjLst_Cache == null) return 0;
let arrvPaperSubViewpointLikeLog_Sel: Array < clsvPaperSubViewpointLikeLogEN > = arrvPaperSubViewpointLikeLogObjLst_Cache;
if (objvPaperSubViewpointLikeLog_Cond.sf_FldComparisonOp == null || objvPaperSubViewpointLikeLog_Cond.sf_FldComparisonOp == "") return arrvPaperSubViewpointLikeLog_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvPaperSubViewpointLikeLog_Cond.sf_FldComparisonOp);
//console.log("clsvPaperSubViewpointLikeLogWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvPaperSubViewpointLikeLog_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvPaperSubViewpointLikeLog_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvPaperSubViewpointLikeLog_Sel = arrvPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvPaperSubViewpointLikeLog_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objvPaperSubViewpointLikeLog_Cond), vPaperSubViewpointLikeLog_ConstructorName, strThisFuncName);
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
export function vPaperSubViewpointLikeLog_GetWebApiUrl(strController: string, strAction: string): string {
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
export function vPaperSubViewpointLikeLog_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clsvPaperSubViewpointLikeLogEN._CurrTabName;
switch (clsvPaperSubViewpointLikeLogEN.CacheModeId)
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
export function vPaperSubViewpointLikeLog_GetJSONStrByObj (pobjvPaperSubViewpointLikeLogEN: clsvPaperSubViewpointLikeLogEN): string
{
const strThisFuncName = "GetJSONStrByObj";
let strJson = "";
try
{
strJson = JSON.stringify(pobjvPaperSubViewpointLikeLogEN);
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
export function vPaperSubViewpointLikeLog_GetObjLstByJSONStr (strJSON: string): Array<clsvPaperSubViewpointLikeLogEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrvPaperSubViewpointLikeLogObjLst = new Array<clsvPaperSubViewpointLikeLogEN>();
if (strJSON === "")
{
return arrvPaperSubViewpointLikeLogObjLst;
}
try
{
arrvPaperSubViewpointLikeLogObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvPaperSubViewpointLikeLogObjLst;
}
return arrvPaperSubViewpointLikeLogObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrvPaperSubViewpointLikeLogObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function vPaperSubViewpointLikeLog_GetObjLstByJSONObjLst (arrvPaperSubViewpointLikeLogObjLstS: Array<clsvPaperSubViewpointLikeLogEN>): Array<clsvPaperSubViewpointLikeLogEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrvPaperSubViewpointLikeLogObjLst = new Array<clsvPaperSubViewpointLikeLogEN>();
for (const objInFor of arrvPaperSubViewpointLikeLogObjLstS) {
const obj1 = vPaperSubViewpointLikeLog_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrvPaperSubViewpointLikeLogObjLst.push(obj1);
}
return arrvPaperSubViewpointLikeLogObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vPaperSubViewpointLikeLog_GetObjByJSONStr (strJSON: string): clsvPaperSubViewpointLikeLogEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjvPaperSubViewpointLikeLogEN = new clsvPaperSubViewpointLikeLogEN();
if (strJSON === "")
{
return pobjvPaperSubViewpointLikeLogEN;
}
try
{
pobjvPaperSubViewpointLikeLogEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvPaperSubViewpointLikeLogEN;
}
return pobjvPaperSubViewpointLikeLogEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function vPaperSubViewpointLikeLog_GetCombineCondition(objvPaperSubViewpointLikeLog_Cond: clsvPaperSubViewpointLikeLogEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpointLikeLog_Cond.dicFldComparisonOp, clsvPaperSubViewpointLikeLogEN.con_PaperSubViewpointLikeLogId) == true)
{
const strComparisonOp_PaperSubViewpointLikeLogId:string = objvPaperSubViewpointLikeLog_Cond.dicFldComparisonOp[clsvPaperSubViewpointLikeLogEN.con_PaperSubViewpointLikeLogId];
strWhereCond += Format(" And {0} {2} {1}", clsvPaperSubViewpointLikeLogEN.con_PaperSubViewpointLikeLogId, objvPaperSubViewpointLikeLog_Cond.paperSubViewpointLikeLogId, strComparisonOp_PaperSubViewpointLikeLogId);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpointLikeLog_Cond.dicFldComparisonOp, clsvPaperSubViewpointLikeLogEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objvPaperSubViewpointLikeLog_Cond.dicFldComparisonOp[clsvPaperSubViewpointLikeLogEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperSubViewpointLikeLogEN.con_UpdDate, objvPaperSubViewpointLikeLog_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpointLikeLog_Cond.dicFldComparisonOp, clsvPaperSubViewpointLikeLogEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objvPaperSubViewpointLikeLog_Cond.dicFldComparisonOp[clsvPaperSubViewpointLikeLogEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperSubViewpointLikeLogEN.con_Memo, objvPaperSubViewpointLikeLog_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpointLikeLog_Cond.dicFldComparisonOp, clsvPaperSubViewpointLikeLogEN.con_RWTitle) == true)
{
const strComparisonOp_RWTitle:string = objvPaperSubViewpointLikeLog_Cond.dicFldComparisonOp[clsvPaperSubViewpointLikeLogEN.con_RWTitle];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperSubViewpointLikeLogEN.con_RWTitle, objvPaperSubViewpointLikeLog_Cond.rwTitle, strComparisonOp_RWTitle);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpointLikeLog_Cond.dicFldComparisonOp, clsvPaperSubViewpointLikeLogEN.con_ExplainContent) == true)
{
const strComparisonOp_ExplainContent:string = objvPaperSubViewpointLikeLog_Cond.dicFldComparisonOp[clsvPaperSubViewpointLikeLogEN.con_ExplainContent];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperSubViewpointLikeLogEN.con_ExplainContent, objvPaperSubViewpointLikeLog_Cond.explainContent, strComparisonOp_ExplainContent);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpointLikeLog_Cond.dicFldComparisonOp, clsvPaperSubViewpointLikeLogEN.con_PaperRWId) == true)
{
const strComparisonOp_PaperRWId:string = objvPaperSubViewpointLikeLog_Cond.dicFldComparisonOp[clsvPaperSubViewpointLikeLogEN.con_PaperRWId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperSubViewpointLikeLogEN.con_PaperRWId, objvPaperSubViewpointLikeLog_Cond.paperRWId, strComparisonOp_PaperRWId);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpointLikeLog_Cond.dicFldComparisonOp, clsvPaperSubViewpointLikeLogEN.con_SubViewpointId) == true)
{
const strComparisonOp_SubViewpointId:string = objvPaperSubViewpointLikeLog_Cond.dicFldComparisonOp[clsvPaperSubViewpointLikeLogEN.con_SubViewpointId];
strWhereCond += Format(" And {0} {2} {1}", clsvPaperSubViewpointLikeLogEN.con_SubViewpointId, objvPaperSubViewpointLikeLog_Cond.subViewpointId, strComparisonOp_SubViewpointId);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpointLikeLog_Cond.dicFldComparisonOp, clsvPaperSubViewpointLikeLogEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objvPaperSubViewpointLikeLog_Cond.dicFldComparisonOp[clsvPaperSubViewpointLikeLogEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperSubViewpointLikeLogEN.con_UpdUser, objvPaperSubViewpointLikeLog_Cond.updUser, strComparisonOp_UpdUser);
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objvPaperSubViewpointLikeLogENS:源对象
 * @param objvPaperSubViewpointLikeLogENT:目标对象
*/
export function vPaperSubViewpointLikeLog_CopyObjTo(objvPaperSubViewpointLikeLogENS: clsvPaperSubViewpointLikeLogEN , objvPaperSubViewpointLikeLogENT: clsvPaperSubViewpointLikeLogEN ): void 
{
objvPaperSubViewpointLikeLogENT.paperSubViewpointLikeLogId = objvPaperSubViewpointLikeLogENS.paperSubViewpointLikeLogId; //PaperSubViewpointLikeLogId
objvPaperSubViewpointLikeLogENT.updDate = objvPaperSubViewpointLikeLogENS.updDate; //修改日期
objvPaperSubViewpointLikeLogENT.memo = objvPaperSubViewpointLikeLogENS.memo; //备注
objvPaperSubViewpointLikeLogENT.rwTitle = objvPaperSubViewpointLikeLogENS.rwTitle; //读写标题
objvPaperSubViewpointLikeLogENT.subViewpointContent = objvPaperSubViewpointLikeLogENS.subViewpointContent; //详情内容
objvPaperSubViewpointLikeLogENT.explainContent = objvPaperSubViewpointLikeLogENS.explainContent; //说明内容
objvPaperSubViewpointLikeLogENT.paperRWId = objvPaperSubViewpointLikeLogENS.paperRWId; //课文阅读
objvPaperSubViewpointLikeLogENT.subViewpointId = objvPaperSubViewpointLikeLogENS.subViewpointId; //子观点Id
objvPaperSubViewpointLikeLogENT.updUser = objvPaperSubViewpointLikeLogENS.updUser; //修改人
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objvPaperSubViewpointLikeLogENS:源对象
 * @param objvPaperSubViewpointLikeLogENT:目标对象
*/
export function vPaperSubViewpointLikeLog_GetObjFromJsonObj(objvPaperSubViewpointLikeLogENS: clsvPaperSubViewpointLikeLogEN): clsvPaperSubViewpointLikeLogEN 
{
 const objvPaperSubViewpointLikeLogENT: clsvPaperSubViewpointLikeLogEN = new clsvPaperSubViewpointLikeLogEN();
ObjectAssign(objvPaperSubViewpointLikeLogENT, objvPaperSubViewpointLikeLogENS);
 return objvPaperSubViewpointLikeLogENT;
}