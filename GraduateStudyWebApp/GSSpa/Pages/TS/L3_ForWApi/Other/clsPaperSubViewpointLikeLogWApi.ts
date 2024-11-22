
 /**
 * 类名:clsPaperSubViewpointLikeLogWApi
 * 表名:PaperSubViewpointLikeLog(01120560)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:46:14
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
 * 子观点点赞表(PaperSubViewpointLikeLog)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clsPaperSubViewpointLikeLogEN } from "../../L0_Entity/Other/clsPaperSubViewpointLikeLogEN.js";
import { vPaperSubViewpointLikeLog_ReFreshThisCache } from "../../L3_ForWApi/Other/clsvPaperSubViewpointLikeLogWApi.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { tzDataType } from "../../PubFun/jsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const paperSubViewpointLikeLog_Controller = "PaperSubViewpointLikeLogApi";
 export const paperSubViewpointLikeLog_ConstructorName = "paperSubViewpointLikeLog";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngPaperSubViewpointLikeLogId:关键字
 * @returns 对象
 **/
export async function PaperSubViewpointLikeLog_GetObjByPaperSubViewpointLikeLogIdAsync(lngPaperSubViewpointLikeLogId: number): Promise<clsPaperSubViewpointLikeLogEN>  
{
const strThisFuncName = "GetObjByPaperSubViewpointLikeLogIdAsync";

if (lngPaperSubViewpointLikeLogId == 0)
{
  const strMsg = Format("参数:[lngPaperSubViewpointLikeLogId]不能为空！(In GetObjByPaperSubViewpointLikeLogIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjByPaperSubViewpointLikeLogId";
const strUrl = GetWebApiUrl(paperSubViewpointLikeLog_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", paperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objPaperSubViewpointLikeLog = PaperSubViewpointLikeLog_GetObjFromJsonObj(returnObj);
return objPaperSubViewpointLikeLog;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubViewpointLikeLog_ConstructorName, strThisFuncName);
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
export async function PaperSubViewpointLikeLog_GetObjByPaperSubViewpointLikeLogId_Cache(lngPaperSubViewpointLikeLogId: number, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByPaperSubViewpointLikeLogId_Cache";

if (lngPaperSubViewpointLikeLogId == 0)
{
  const strMsg = Format("参数:[lngPaperSubViewpointLikeLogId]不能为空！(In GetObjByPaperSubViewpointLikeLogId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
const arrPaperSubViewpointLikeLogObjLst_Cache = await PaperSubViewpointLikeLog_GetObjLst_Cache();
try
{
const arrPaperSubViewpointLikeLog_Sel: Array <clsPaperSubViewpointLikeLogEN> = arrPaperSubViewpointLikeLogObjLst_Cache.filter(x => x.paperSubViewpointLikeLogId == lngPaperSubViewpointLikeLogId);
let objPaperSubViewpointLikeLog: clsPaperSubViewpointLikeLogEN;
if (arrPaperSubViewpointLikeLog_Sel.length > 0)
{
objPaperSubViewpointLikeLog = arrPaperSubViewpointLikeLog_Sel[0];
return objPaperSubViewpointLikeLog;
}
else
{
if (bolTryAsyncOnce == true)
{
objPaperSubViewpointLikeLog = await PaperSubViewpointLikeLog_GetObjByPaperSubViewpointLikeLogIdAsync(lngPaperSubViewpointLikeLogId);
if (objPaperSubViewpointLikeLog != null)
{
PaperSubViewpointLikeLog_ReFreshThisCache();
return objPaperSubViewpointLikeLog;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngPaperSubViewpointLikeLogId, paperSubViewpointLikeLog_ConstructorName, strThisFuncName);
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
export async function PaperSubViewpointLikeLog_GetObjByPaperSubViewpointLikeLogId_localStorage(lngPaperSubViewpointLikeLogId: number) {
const strThisFuncName = "GetObjByPaperSubViewpointLikeLogId_localStorage";

if (lngPaperSubViewpointLikeLogId == 0)
{
  const strMsg = Format("参数:[lngPaperSubViewpointLikeLogId]不能为空！(In GetObjByPaperSubViewpointLikeLogId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
const strKey = Format("{0}_{1}", clsPaperSubViewpointLikeLogEN._CurrTabName, lngPaperSubViewpointLikeLogId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objPaperSubViewpointLikeLog_Cache: clsPaperSubViewpointLikeLogEN = JSON.parse(strTempObj);
return objPaperSubViewpointLikeLog_Cache;
}
try
{
const objPaperSubViewpointLikeLog = await PaperSubViewpointLikeLog_GetObjByPaperSubViewpointLikeLogIdAsync(lngPaperSubViewpointLikeLogId);
if (objPaperSubViewpointLikeLog != null)
{
localStorage.setItem(strKey, JSON.stringify(objPaperSubViewpointLikeLog));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objPaperSubViewpointLikeLog;
}
return objPaperSubViewpointLikeLog;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngPaperSubViewpointLikeLogId, paperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objPaperSubViewpointLikeLog:所给的对象
 * @returns 对象
*/
export async function PaperSubViewpointLikeLog_UpdateObjInLst_Cache(objPaperSubViewpointLikeLog: clsPaperSubViewpointLikeLogEN) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrPaperSubViewpointLikeLogObjLst_Cache = await PaperSubViewpointLikeLog_GetObjLst_Cache();
const obj = arrPaperSubViewpointLikeLogObjLst_Cache.find(x => x.paperSubViewpointLikeLogId == objPaperSubViewpointLikeLog.paperSubViewpointLikeLogId && x.subViewpointId == objPaperSubViewpointLikeLog.subViewpointId);
if (obj != null)
{
objPaperSubViewpointLikeLog.paperSubViewpointLikeLogId = obj.paperSubViewpointLikeLogId;
ObjectAssign( obj, objPaperSubViewpointLikeLog);
}
else
{
arrPaperSubViewpointLikeLogObjLst_Cache.push(objPaperSubViewpointLikeLog);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, paperSubViewpointLikeLog_ConstructorName, strThisFuncName);
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
export async function PaperSubViewpointLikeLog_func(strInFldName:string , strOutFldName:string ,  strInValue: string) 
{
//const strThisFuncName = "func";

if (strInFldName != clsPaperSubViewpointLikeLogEN.con_PaperSubViewpointLikeLogId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsPaperSubViewpointLikeLogEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clsPaperSubViewpointLikeLogEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const lngPaperSubViewpointLikeLogId = Number(strInValue);
if (lngPaperSubViewpointLikeLogId == 0)
{
return "";
}
const objPaperSubViewpointLikeLog = await PaperSubViewpointLikeLog_GetObjByPaperSubViewpointLikeLogId_Cache(lngPaperSubViewpointLikeLogId );
if (objPaperSubViewpointLikeLog == null) return "";
return objPaperSubViewpointLikeLog.GetFldValue(strOutFldName).toString();
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
export function PaperSubViewpointLikeLog_SortFun_Defa(a:clsPaperSubViewpointLikeLogEN , b:clsPaperSubViewpointLikeLogEN): number 
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
export function PaperSubViewpointLikeLog_SortFun_Defa_2Fld(a:clsPaperSubViewpointLikeLogEN , b:clsPaperSubViewpointLikeLogEN): number 
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
export function PaperSubViewpointLikeLog_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsPaperSubViewpointLikeLogEN.con_PaperSubViewpointLikeLogId:
return (a: clsPaperSubViewpointLikeLogEN, b: clsPaperSubViewpointLikeLogEN) => {
return a.paperSubViewpointLikeLogId-b.paperSubViewpointLikeLogId;
}
case clsPaperSubViewpointLikeLogEN.con_UpdDate:
return (a: clsPaperSubViewpointLikeLogEN, b: clsPaperSubViewpointLikeLogEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsPaperSubViewpointLikeLogEN.con_Memo:
return (a: clsPaperSubViewpointLikeLogEN, b: clsPaperSubViewpointLikeLogEN) => {
return a.memo.localeCompare(b.memo);
}
case clsPaperSubViewpointLikeLogEN.con_SubViewpointId:
return (a: clsPaperSubViewpointLikeLogEN, b: clsPaperSubViewpointLikeLogEN) => {
return a.subViewpointId-b.subViewpointId;
}
case clsPaperSubViewpointLikeLogEN.con_UpdUser:
return (a: clsPaperSubViewpointLikeLogEN, b: clsPaperSubViewpointLikeLogEN) => {
return a.updUser.localeCompare(b.updUser);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[PaperSubViewpointLikeLog]中不存在！(in ${ paperSubViewpointLikeLog_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsPaperSubViewpointLikeLogEN.con_PaperSubViewpointLikeLogId:
return (a: clsPaperSubViewpointLikeLogEN, b: clsPaperSubViewpointLikeLogEN) => {
return b.paperSubViewpointLikeLogId-a.paperSubViewpointLikeLogId;
}
case clsPaperSubViewpointLikeLogEN.con_UpdDate:
return (a: clsPaperSubViewpointLikeLogEN, b: clsPaperSubViewpointLikeLogEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsPaperSubViewpointLikeLogEN.con_Memo:
return (a: clsPaperSubViewpointLikeLogEN, b: clsPaperSubViewpointLikeLogEN) => {
return b.memo.localeCompare(a.memo);
}
case clsPaperSubViewpointLikeLogEN.con_SubViewpointId:
return (a: clsPaperSubViewpointLikeLogEN, b: clsPaperSubViewpointLikeLogEN) => {
return b.subViewpointId-a.subViewpointId;
}
case clsPaperSubViewpointLikeLogEN.con_UpdUser:
return (a: clsPaperSubViewpointLikeLogEN, b: clsPaperSubViewpointLikeLogEN) => {
return b.updUser.localeCompare(a.updUser);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[PaperSubViewpointLikeLog]中不存在！(in ${ paperSubViewpointLikeLog_ConstructorName}.${ strThisFuncName})`;
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
export async function PaperSubViewpointLikeLog_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsPaperSubViewpointLikeLogEN.con_PaperSubViewpointLikeLogId:
return (obj: clsPaperSubViewpointLikeLogEN) => {
return obj.paperSubViewpointLikeLogId === value;
}
case clsPaperSubViewpointLikeLogEN.con_UpdDate:
return (obj: clsPaperSubViewpointLikeLogEN) => {
return obj.updDate === value;
}
case clsPaperSubViewpointLikeLogEN.con_Memo:
return (obj: clsPaperSubViewpointLikeLogEN) => {
return obj.memo === value;
}
case clsPaperSubViewpointLikeLogEN.con_SubViewpointId:
return (obj: clsPaperSubViewpointLikeLogEN) => {
return obj.subViewpointId === value;
}
case clsPaperSubViewpointLikeLogEN.con_UpdUser:
return (obj: clsPaperSubViewpointLikeLogEN) => {
return obj.updUser === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[PaperSubViewpointLikeLog]中不存在！(in ${ paperSubViewpointLikeLog_ConstructorName}.${ strThisFuncName})`;
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
export async function PaperSubViewpointLikeLog_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(paperSubViewpointLikeLog_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubViewpointLikeLog_ConstructorName, strThisFuncName);
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
export async function PaperSubViewpointLikeLog_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(paperSubViewpointLikeLog_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubViewpointLikeLog_ConstructorName, strThisFuncName);
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
export async function PaperSubViewpointLikeLog_GetFirstObjAsync(strWhereCond: string): Promise<clsPaperSubViewpointLikeLogEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(paperSubViewpointLikeLog_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", paperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objPaperSubViewpointLikeLog = PaperSubViewpointLikeLog_GetObjFromJsonObj(returnObj);
return objPaperSubViewpointLikeLog;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubViewpointLikeLog_ConstructorName, strThisFuncName);
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
export async function PaperSubViewpointLikeLog_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsPaperSubViewpointLikeLogEN._CurrTabName;
clsPaperSubViewpointLikeLogEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsPaperSubViewpointLikeLogEN._CurrTabName);
if (IsNullOrEmpty(clsPaperSubViewpointLikeLogEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsPaperSubViewpointLikeLogEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrPaperSubViewpointLikeLogExObjLst_Cache: Array<clsPaperSubViewpointLikeLogEN> = CacheHelper.Get(strKey);
const arrPaperSubViewpointLikeLogObjLst_T = PaperSubViewpointLikeLog_GetObjLstByJSONObjLst(arrPaperSubViewpointLikeLogExObjLst_Cache);
return arrPaperSubViewpointLikeLogObjLst_T;
}
try
{
const arrPaperSubViewpointLikeLogExObjLst = await PaperSubViewpointLikeLog_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrPaperSubViewpointLikeLogExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrPaperSubViewpointLikeLogExObjLst.length);
console.log(strInfo);
return arrPaperSubViewpointLikeLogExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, paperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function PaperSubViewpointLikeLog_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsPaperSubViewpointLikeLogEN._CurrTabName;
clsPaperSubViewpointLikeLogEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsPaperSubViewpointLikeLogEN._CurrTabName);
if (IsNullOrEmpty(clsPaperSubViewpointLikeLogEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsPaperSubViewpointLikeLogEN.CacheAddiCondition);
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
const arrPaperSubViewpointLikeLogExObjLst_Cache: Array<clsPaperSubViewpointLikeLogEN> = JSON.parse(strTempObjLst);
const arrPaperSubViewpointLikeLogObjLst_T = PaperSubViewpointLikeLog_GetObjLstByJSONObjLst(arrPaperSubViewpointLikeLogExObjLst_Cache);
return arrPaperSubViewpointLikeLogObjLst_T;
}
try
{
const arrPaperSubViewpointLikeLogExObjLst = await PaperSubViewpointLikeLog_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrPaperSubViewpointLikeLogExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrPaperSubViewpointLikeLogExObjLst.length);
console.log(strInfo);
return arrPaperSubViewpointLikeLogExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, paperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function PaperSubViewpointLikeLog_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsPaperSubViewpointLikeLogEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrPaperSubViewpointLikeLogObjLst_Cache: Array<clsPaperSubViewpointLikeLogEN> = JSON.parse(strTempObjLst);
return arrPaperSubViewpointLikeLogObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function PaperSubViewpointLikeLog_GetObjLstAsync(strWhereCond: string): Promise<Array<clsPaperSubViewpointLikeLogEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(paperSubViewpointLikeLog_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", paperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = PaperSubViewpointLikeLog_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubViewpointLikeLog_ConstructorName, strThisFuncName);
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
export async function PaperSubViewpointLikeLog_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsPaperSubViewpointLikeLogEN._CurrTabName;
clsPaperSubViewpointLikeLogEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsPaperSubViewpointLikeLogEN._CurrTabName);
if (IsNullOrEmpty(clsPaperSubViewpointLikeLogEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsPaperSubViewpointLikeLogEN.CacheAddiCondition);
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
const arrPaperSubViewpointLikeLogExObjLst_Cache: Array<clsPaperSubViewpointLikeLogEN> = JSON.parse(strTempObjLst);
const arrPaperSubViewpointLikeLogObjLst_T = PaperSubViewpointLikeLog_GetObjLstByJSONObjLst(arrPaperSubViewpointLikeLogExObjLst_Cache);
return arrPaperSubViewpointLikeLogObjLst_T;
}
try
{
const arrPaperSubViewpointLikeLogExObjLst = await PaperSubViewpointLikeLog_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrPaperSubViewpointLikeLogExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrPaperSubViewpointLikeLogExObjLst.length);
console.log(strInfo);
return arrPaperSubViewpointLikeLogExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, paperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function PaperSubViewpointLikeLog_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsPaperSubViewpointLikeLogEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrPaperSubViewpointLikeLogObjLst_Cache: Array<clsPaperSubViewpointLikeLogEN> = JSON.parse(strTempObjLst);
return arrPaperSubViewpointLikeLogObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function PaperSubViewpointLikeLog_GetObjLst_Cache(): Promise<Array<clsPaperSubViewpointLikeLogEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrPaperSubViewpointLikeLogObjLst_Cache;
switch (clsPaperSubViewpointLikeLogEN.CacheModeId)
{
case "04"://sessionStorage
arrPaperSubViewpointLikeLogObjLst_Cache = await PaperSubViewpointLikeLog_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrPaperSubViewpointLikeLogObjLst_Cache = await PaperSubViewpointLikeLog_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrPaperSubViewpointLikeLogObjLst_Cache = await PaperSubViewpointLikeLog_GetObjLst_ClientCache();
break;
default:
arrPaperSubViewpointLikeLogObjLst_Cache = await PaperSubViewpointLikeLog_GetObjLst_ClientCache();
break;
}
const arrPaperSubViewpointLikeLogObjLst = PaperSubViewpointLikeLog_GetObjLstByJSONObjLst(arrPaperSubViewpointLikeLogObjLst_Cache);
return arrPaperSubViewpointLikeLogObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function PaperSubViewpointLikeLog_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrPaperSubViewpointLikeLogObjLst_Cache;
switch (clsPaperSubViewpointLikeLogEN.CacheModeId)
{
case "04"://sessionStorage
arrPaperSubViewpointLikeLogObjLst_Cache = await PaperSubViewpointLikeLog_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrPaperSubViewpointLikeLogObjLst_Cache = await PaperSubViewpointLikeLog_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrPaperSubViewpointLikeLogObjLst_Cache = null;
break;
default:
arrPaperSubViewpointLikeLogObjLst_Cache = null;
break;
}
return arrPaperSubViewpointLikeLogObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objlngPaperSubViewpointLikeLogId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function PaperSubViewpointLikeLog_GetSubObjLst_Cache(objPaperSubViewpointLikeLog_Cond: clsPaperSubViewpointLikeLogEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrPaperSubViewpointLikeLogObjLst_Cache = await PaperSubViewpointLikeLog_GetObjLst_Cache();
let arrPaperSubViewpointLikeLog_Sel: Array < clsPaperSubViewpointLikeLogEN > = arrPaperSubViewpointLikeLogObjLst_Cache;
if (objPaperSubViewpointLikeLog_Cond.sf_FldComparisonOp == null || objPaperSubViewpointLikeLog_Cond.sf_FldComparisonOp == "") return arrPaperSubViewpointLikeLog_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objPaperSubViewpointLikeLog_Cond.sf_FldComparisonOp);
//console.log("clsPaperSubViewpointLikeLogWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objPaperSubViewpointLikeLog_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrPaperSubViewpointLikeLog_Sel = arrPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objPaperSubViewpointLikeLog_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrPaperSubViewpointLikeLog_Sel = arrPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrPaperSubViewpointLikeLog_Sel = arrPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrPaperSubViewpointLikeLog_Sel = arrPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrPaperSubViewpointLikeLog_Sel = arrPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrPaperSubViewpointLikeLog_Sel = arrPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrPaperSubViewpointLikeLog_Sel = arrPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrPaperSubViewpointLikeLog_Sel = arrPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrPaperSubViewpointLikeLog_Sel = arrPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrPaperSubViewpointLikeLog_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objPaperSubViewpointLikeLog_Cond), paperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsPaperSubViewpointLikeLogEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrPaperSubViewpointLikeLogId:关键字列表
 * @returns 对象列表
 **/
export async function PaperSubViewpointLikeLog_GetObjLstByPaperSubViewpointLikeLogIdLstAsync(arrPaperSubViewpointLikeLogId: Array<string>): Promise<Array<clsPaperSubViewpointLikeLogEN>>  
{
const strThisFuncName = "GetObjLstByPaperSubViewpointLikeLogIdLstAsync";
const strAction = "GetObjLstByPaperSubViewpointLikeLogIdLst";
const strUrl = GetWebApiUrl(paperSubViewpointLikeLog_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrPaperSubViewpointLikeLogId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", paperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = PaperSubViewpointLikeLog_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubViewpointLikeLog_ConstructorName, strThisFuncName);
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
export async function PaperSubViewpointLikeLog_GetObjLstByPaperSubViewpointLikeLogIdLst_Cache(arrPaperSubViewpointLikeLogIdLst: Array<number>) {
const strThisFuncName = "GetObjLstByPaperSubViewpointLikeLogIdLst_Cache";
try
{
const arrPaperSubViewpointLikeLogObjLst_Cache = await PaperSubViewpointLikeLog_GetObjLst_Cache();
const arrPaperSubViewpointLikeLog_Sel: Array <clsPaperSubViewpointLikeLogEN> = arrPaperSubViewpointLikeLogObjLst_Cache.filter(x => arrPaperSubViewpointLikeLogIdLst.indexOf(x.paperSubViewpointLikeLogId)>-1);
return arrPaperSubViewpointLikeLog_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrPaperSubViewpointLikeLogIdLst.join(","), paperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsPaperSubViewpointLikeLogEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function PaperSubViewpointLikeLog_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsPaperSubViewpointLikeLogEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(paperSubViewpointLikeLog_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", paperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = PaperSubViewpointLikeLog_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubViewpointLikeLog_ConstructorName, strThisFuncName);
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
export async function PaperSubViewpointLikeLog_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsPaperSubViewpointLikeLogEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(paperSubViewpointLikeLog_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", paperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = PaperSubViewpointLikeLog_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubViewpointLikeLog_ConstructorName, strThisFuncName);
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
export async function PaperSubViewpointLikeLog_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(paperSubViewpointLikeLog_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubViewpointLikeLog_ConstructorName, strThisFuncName);
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
export async function PaperSubViewpointLikeLog_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrPaperSubViewpointLikeLogObjLst_Cache = await PaperSubViewpointLikeLog_GetObjLst_Cache();
if (arrPaperSubViewpointLikeLogObjLst_Cache.length == 0) return arrPaperSubViewpointLikeLogObjLst_Cache;
let arrPaperSubViewpointLikeLog_Sel = arrPaperSubViewpointLikeLogObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objPaperSubViewpointLikeLog_Cond = new clsPaperSubViewpointLikeLogEN();
ObjectAssign(objPaperSubViewpointLikeLog_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsPaperSubViewpointLikeLogWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrPaperSubViewpointLikeLog_Sel = arrPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objPaperSubViewpointLikeLog_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrPaperSubViewpointLikeLog_Sel = arrPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrPaperSubViewpointLikeLog_Sel = arrPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrPaperSubViewpointLikeLog_Sel = arrPaperSubViewpointLikeLog_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrPaperSubViewpointLikeLog_Sel = arrPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrPaperSubViewpointLikeLog_Sel = arrPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrPaperSubViewpointLikeLog_Sel = arrPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrPaperSubViewpointLikeLog_Sel = arrPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrPaperSubViewpointLikeLog_Sel = arrPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrPaperSubViewpointLikeLog_Sel = arrPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrPaperSubViewpointLikeLog_Sel.length == 0) return arrPaperSubViewpointLikeLog_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrPaperSubViewpointLikeLog_Sel = arrPaperSubViewpointLikeLog_Sel.sort(PaperSubViewpointLikeLog_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrPaperSubViewpointLikeLog_Sel = arrPaperSubViewpointLikeLog_Sel.sort(objPagerPara.sortFun);
}
arrPaperSubViewpointLikeLog_Sel = arrPaperSubViewpointLikeLog_Sel.slice(intStart, intEnd);     
return arrPaperSubViewpointLikeLog_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, paperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsPaperSubViewpointLikeLogEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function PaperSubViewpointLikeLog_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsPaperSubViewpointLikeLogEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(paperSubViewpointLikeLog_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", paperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = PaperSubViewpointLikeLog_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubViewpointLikeLog_ConstructorName, strThisFuncName);
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
 * @param lngPaperSubViewpointLikeLogId:关键字
 * @returns 获取删除的结果
 **/
export async function PaperSubViewpointLikeLog_DelRecordAsync(lngPaperSubViewpointLikeLogId: number): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(paperSubViewpointLikeLog_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, lngPaperSubViewpointLikeLogId);
try
{
const response = await axios.delete(strUrl,
{
params: { "Id": lngPaperSubViewpointLikeLogId, }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubViewpointLikeLog_ConstructorName, strThisFuncName);
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
 * @param arrPaperSubViewpointLikeLogId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function PaperSubViewpointLikeLog_DelPaperSubViewpointLikeLogsAsync(arrPaperSubViewpointLikeLogId: Array<string>): Promise<number> 
{
const strThisFuncName = "DelPaperSubViewpointLikeLogsAsync";
const strAction = "DelPaperSubViewpointLikeLogs";
const strUrl = GetWebApiUrl(paperSubViewpointLikeLog_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrPaperSubViewpointLikeLogId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubViewpointLikeLog_ConstructorName, strThisFuncName);
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
export async function PaperSubViewpointLikeLog_DelPaperSubViewpointLikeLogsByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "DelPaperSubViewpointLikeLogsByCondAsync";
const strAction = "DelPaperSubViewpointLikeLogsByCond";
const strUrl = GetWebApiUrl(paperSubViewpointLikeLog_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubViewpointLikeLog_ConstructorName, strThisFuncName);
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
 * @param objPaperSubViewpointLikeLogEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function PaperSubViewpointLikeLog_AddNewRecordAsync(objPaperSubViewpointLikeLogEN: clsPaperSubViewpointLikeLogEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objPaperSubViewpointLikeLogEN);
const strUrl = GetWebApiUrl(paperSubViewpointLikeLog_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPaperSubViewpointLikeLogEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}
/* 数据类型不是字符型，不可以最大关键字的方式添加记录。*/

 /**
 * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
 * @param objPaperSubViewpointLikeLogEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function PaperSubViewpointLikeLog_AddNewRecordWithReturnKeyAsync(objPaperSubViewpointLikeLogEN: clsPaperSubViewpointLikeLogEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(paperSubViewpointLikeLog_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPaperSubViewpointLikeLogEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubViewpointLikeLog_ConstructorName, strThisFuncName);
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
 * @param objPaperSubViewpointLikeLogEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function PaperSubViewpointLikeLog_AddNewRecordWithReturnKey(objPaperSubViewpointLikeLogEN: clsPaperSubViewpointLikeLogEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objPaperSubViewpointLikeLogEN.paperSubViewpointLikeLogId === null || objPaperSubViewpointLikeLogEN.paperSubViewpointLikeLogId === 0)
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(paperSubViewpointLikeLog_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPaperSubViewpointLikeLogEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubViewpointLikeLog_ConstructorName, strThisFuncName);
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
 * @param objPaperSubViewpointLikeLogEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function PaperSubViewpointLikeLog_UpdateRecordAsync(objPaperSubViewpointLikeLogEN: clsPaperSubViewpointLikeLogEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objPaperSubViewpointLikeLogEN.sf_UpdFldSetStr === undefined || objPaperSubViewpointLikeLogEN.sf_UpdFldSetStr === null || objPaperSubViewpointLikeLogEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objPaperSubViewpointLikeLogEN.paperSubViewpointLikeLogId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(paperSubViewpointLikeLog_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPaperSubViewpointLikeLogEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubViewpointLikeLog_ConstructorName, strThisFuncName);
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
 * @param objPaperSubViewpointLikeLogEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function PaperSubViewpointLikeLog_UpdateWithConditionAsync(objPaperSubViewpointLikeLogEN: clsPaperSubViewpointLikeLogEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objPaperSubViewpointLikeLogEN.sf_UpdFldSetStr === undefined || objPaperSubViewpointLikeLogEN.sf_UpdFldSetStr === null || objPaperSubViewpointLikeLogEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objPaperSubViewpointLikeLogEN.paperSubViewpointLikeLogId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(paperSubViewpointLikeLog_Controller, strAction);
objPaperSubViewpointLikeLogEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objPaperSubViewpointLikeLogEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubViewpointLikeLog_ConstructorName, strThisFuncName);
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
export async function PaperSubViewpointLikeLog_IsExistRecord_Cache(objPaperSubViewpointLikeLog_Cond: clsPaperSubViewpointLikeLogEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrPaperSubViewpointLikeLogObjLst_Cache = await PaperSubViewpointLikeLog_GetObjLst_Cache();
if (arrPaperSubViewpointLikeLogObjLst_Cache == null) return false;
let arrPaperSubViewpointLikeLog_Sel: Array < clsPaperSubViewpointLikeLogEN > = arrPaperSubViewpointLikeLogObjLst_Cache;
if (objPaperSubViewpointLikeLog_Cond.sf_FldComparisonOp == null || objPaperSubViewpointLikeLog_Cond.sf_FldComparisonOp == "") return arrPaperSubViewpointLikeLog_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objPaperSubViewpointLikeLog_Cond.sf_FldComparisonOp);
//console.log("clsPaperSubViewpointLikeLogWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objPaperSubViewpointLikeLog_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objPaperSubViewpointLikeLog_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrPaperSubViewpointLikeLog_Sel = arrPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrPaperSubViewpointLikeLog_Sel = arrPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrPaperSubViewpointLikeLog_Sel = arrPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrPaperSubViewpointLikeLog_Sel = arrPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrPaperSubViewpointLikeLog_Sel = arrPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrPaperSubViewpointLikeLog_Sel = arrPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrPaperSubViewpointLikeLog_Sel = arrPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrPaperSubViewpointLikeLog_Sel = arrPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrPaperSubViewpointLikeLog_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objPaperSubViewpointLikeLog_Cond), paperSubViewpointLikeLog_ConstructorName, strThisFuncName);
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
export async function PaperSubViewpointLikeLog_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(paperSubViewpointLikeLog_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubViewpointLikeLog_ConstructorName, strThisFuncName);
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
export async function PaperSubViewpointLikeLog_IsExist(lngPaperSubViewpointLikeLogId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(paperSubViewpointLikeLog_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubViewpointLikeLog_ConstructorName, strThisFuncName);
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
export async function PaperSubViewpointLikeLog_IsExist_Cache(lngPaperSubViewpointLikeLogId:number) {
const strThisFuncName = "IsExist_Cache";
const arrPaperSubViewpointLikeLogObjLst_Cache = await PaperSubViewpointLikeLog_GetObjLst_Cache();
if (arrPaperSubViewpointLikeLogObjLst_Cache == null) return false;
try
{
const arrPaperSubViewpointLikeLog_Sel: Array <clsPaperSubViewpointLikeLogEN> = arrPaperSubViewpointLikeLogObjLst_Cache.filter(x => x.paperSubViewpointLikeLogId == lngPaperSubViewpointLikeLogId);
if (arrPaperSubViewpointLikeLog_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngPaperSubViewpointLikeLogId, paperSubViewpointLikeLog_ConstructorName, strThisFuncName);
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
export async function PaperSubViewpointLikeLog_IsExistAsync(lngPaperSubViewpointLikeLogId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(paperSubViewpointLikeLog_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubViewpointLikeLog_ConstructorName, strThisFuncName);
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
export async function PaperSubViewpointLikeLog_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(paperSubViewpointLikeLog_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubViewpointLikeLog_ConstructorName, strThisFuncName);
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
 * @param objPaperSubViewpointLikeLog_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function PaperSubViewpointLikeLog_GetRecCountByCond_Cache(objPaperSubViewpointLikeLog_Cond: clsPaperSubViewpointLikeLogEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrPaperSubViewpointLikeLogObjLst_Cache = await PaperSubViewpointLikeLog_GetObjLst_Cache();
if (arrPaperSubViewpointLikeLogObjLst_Cache == null) return 0;
let arrPaperSubViewpointLikeLog_Sel: Array < clsPaperSubViewpointLikeLogEN > = arrPaperSubViewpointLikeLogObjLst_Cache;
if (objPaperSubViewpointLikeLog_Cond.sf_FldComparisonOp == null || objPaperSubViewpointLikeLog_Cond.sf_FldComparisonOp == "") return arrPaperSubViewpointLikeLog_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objPaperSubViewpointLikeLog_Cond.sf_FldComparisonOp);
//console.log("clsPaperSubViewpointLikeLogWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objPaperSubViewpointLikeLog_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrPaperSubViewpointLikeLog_Sel = arrPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objPaperSubViewpointLikeLog_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrPaperSubViewpointLikeLog_Sel = arrPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrPaperSubViewpointLikeLog_Sel = arrPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrPaperSubViewpointLikeLog_Sel = arrPaperSubViewpointLikeLog_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrPaperSubViewpointLikeLog_Sel = arrPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrPaperSubViewpointLikeLog_Sel = arrPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrPaperSubViewpointLikeLog_Sel = arrPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrPaperSubViewpointLikeLog_Sel = arrPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrPaperSubViewpointLikeLog_Sel = arrPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrPaperSubViewpointLikeLog_Sel = arrPaperSubViewpointLikeLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrPaperSubViewpointLikeLog_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objPaperSubViewpointLikeLog_Cond), paperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return 0;
}
/*该表的关键字类型不是字符型自增，不需要生成获取最大关键字函数！*/
/*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/

/**
 * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
 * @param mapParam:参数列表
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 获取当前表关键字值的最大值
*/
export async function PaperSubViewpointLikeLog_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(paperSubViewpointLikeLog_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubViewpointLikeLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubViewpointLikeLog_ConstructorName, strThisFuncName);
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
export function PaperSubViewpointLikeLog_GetWebApiUrl(strController: string, strAction: string): string {
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
export function PaperSubViewpointLikeLog_ReFreshCache():void
{
const strThisFuncName = "ReFreshCache";

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = clsPaperSubViewpointLikeLogEN._CurrTabName;
switch (clsPaperSubViewpointLikeLogEN.CacheModeId)
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
vPaperSubViewpointLikeLog_ReFreshThisCache();
}

 /**
 * 刷新本类中的缓存.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
 **/
export function PaperSubViewpointLikeLog_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clsPaperSubViewpointLikeLogEN._CurrTabName;
switch (clsPaperSubViewpointLikeLogEN.CacheModeId)
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
export function PaperSubViewpointLikeLog_CheckPropertyNew(pobjPaperSubViewpointLikeLogEN: clsPaperSubViewpointLikeLogEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjPaperSubViewpointLikeLogEN.updDate) == false && GetStrLen(pobjPaperSubViewpointLikeLogEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 子观点点赞表(PaperSubViewpointLikeLog))!值:$(pobjPaperSubViewpointLikeLogEN.updDate)(clsPaperSubViewpointLikeLogBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointLikeLogEN.memo) == false && GetStrLen(pobjPaperSubViewpointLikeLogEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 子观点点赞表(PaperSubViewpointLikeLog))!值:$(pobjPaperSubViewpointLikeLogEN.memo)(clsPaperSubViewpointLikeLogBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointLikeLogEN.updUser) == false && GetStrLen(pobjPaperSubViewpointLikeLogEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 子观点点赞表(PaperSubViewpointLikeLog))!值:$(pobjPaperSubViewpointLikeLogEN.updUser)(clsPaperSubViewpointLikeLogBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null != pobjPaperSubViewpointLikeLogEN.paperSubViewpointLikeLogId && undefined !== pobjPaperSubViewpointLikeLogEN.paperSubViewpointLikeLogId && tzDataType.isNumber(pobjPaperSubViewpointLikeLogEN.paperSubViewpointLikeLogId) === false)
{
 throw new Error("(errid:Watl000060)字段[点赞Id(paperSubViewpointLikeLogId)]的值:[$(pobjPaperSubViewpointLikeLogEN.paperSubViewpointLikeLogId)], 非法，应该为数值型(In 子观点点赞表(PaperSubViewpointLikeLog))!(clsPaperSubViewpointLikeLogBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointLikeLogEN.updDate) == false && undefined !== pobjPaperSubViewpointLikeLogEN.updDate && tzDataType.isString(pobjPaperSubViewpointLikeLogEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjPaperSubViewpointLikeLogEN.updDate)], 非法，应该为字符型(In 子观点点赞表(PaperSubViewpointLikeLog))!(clsPaperSubViewpointLikeLogBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointLikeLogEN.memo) == false && undefined !== pobjPaperSubViewpointLikeLogEN.memo && tzDataType.isString(pobjPaperSubViewpointLikeLogEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjPaperSubViewpointLikeLogEN.memo)], 非法，应该为字符型(In 子观点点赞表(PaperSubViewpointLikeLog))!(clsPaperSubViewpointLikeLogBL:CheckPropertyNew)");
}
if (null != pobjPaperSubViewpointLikeLogEN.subViewpointId && undefined !== pobjPaperSubViewpointLikeLogEN.subViewpointId && tzDataType.isNumber(pobjPaperSubViewpointLikeLogEN.subViewpointId) === false)
{
 throw new Error("(errid:Watl000060)字段[子观点Id(subViewpointId)]的值:[$(pobjPaperSubViewpointLikeLogEN.subViewpointId)], 非法，应该为数值型(In 子观点点赞表(PaperSubViewpointLikeLog))!(clsPaperSubViewpointLikeLogBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointLikeLogEN.updUser) == false && undefined !== pobjPaperSubViewpointLikeLogEN.updUser && tzDataType.isString(pobjPaperSubViewpointLikeLogEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjPaperSubViewpointLikeLogEN.updUser)], 非法，应该为字符型(In 子观点点赞表(PaperSubViewpointLikeLog))!(clsPaperSubViewpointLikeLogBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjPaperSubViewpointLikeLogEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function PaperSubViewpointLikeLog_CheckProperty4Update (pobjPaperSubViewpointLikeLogEN: clsPaperSubViewpointLikeLogEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjPaperSubViewpointLikeLogEN.updDate) == false && GetStrLen(pobjPaperSubViewpointLikeLogEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 子观点点赞表(PaperSubViewpointLikeLog))!值:$(pobjPaperSubViewpointLikeLogEN.updDate)(clsPaperSubViewpointLikeLogBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointLikeLogEN.memo) == false && GetStrLen(pobjPaperSubViewpointLikeLogEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 子观点点赞表(PaperSubViewpointLikeLog))!值:$(pobjPaperSubViewpointLikeLogEN.memo)(clsPaperSubViewpointLikeLogBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointLikeLogEN.updUser) == false && GetStrLen(pobjPaperSubViewpointLikeLogEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 子观点点赞表(PaperSubViewpointLikeLog))!值:$(pobjPaperSubViewpointLikeLogEN.updUser)(clsPaperSubViewpointLikeLogBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null != pobjPaperSubViewpointLikeLogEN.paperSubViewpointLikeLogId && undefined !== pobjPaperSubViewpointLikeLogEN.paperSubViewpointLikeLogId && tzDataType.isNumber(pobjPaperSubViewpointLikeLogEN.paperSubViewpointLikeLogId) === false)
{
 throw new Error("(errid:Watl000063)字段[点赞Id(paperSubViewpointLikeLogId)]的值:[$(pobjPaperSubViewpointLikeLogEN.paperSubViewpointLikeLogId)], 非法，应该为数值型(In 子观点点赞表(PaperSubViewpointLikeLog))!(clsPaperSubViewpointLikeLogBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointLikeLogEN.updDate) == false && undefined !== pobjPaperSubViewpointLikeLogEN.updDate && tzDataType.isString(pobjPaperSubViewpointLikeLogEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjPaperSubViewpointLikeLogEN.updDate)], 非法，应该为字符型(In 子观点点赞表(PaperSubViewpointLikeLog))!(clsPaperSubViewpointLikeLogBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointLikeLogEN.memo) == false && undefined !== pobjPaperSubViewpointLikeLogEN.memo && tzDataType.isString(pobjPaperSubViewpointLikeLogEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjPaperSubViewpointLikeLogEN.memo)], 非法，应该为字符型(In 子观点点赞表(PaperSubViewpointLikeLog))!(clsPaperSubViewpointLikeLogBL:CheckProperty4Update)");
}
if (null != pobjPaperSubViewpointLikeLogEN.subViewpointId && undefined !== pobjPaperSubViewpointLikeLogEN.subViewpointId && tzDataType.isNumber(pobjPaperSubViewpointLikeLogEN.subViewpointId) === false)
{
 throw new Error("(errid:Watl000063)字段[子观点Id(subViewpointId)]的值:[$(pobjPaperSubViewpointLikeLogEN.subViewpointId)], 非法，应该为数值型(In 子观点点赞表(PaperSubViewpointLikeLog))!(clsPaperSubViewpointLikeLogBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperSubViewpointLikeLogEN.updUser) == false && undefined !== pobjPaperSubViewpointLikeLogEN.updUser && tzDataType.isString(pobjPaperSubViewpointLikeLogEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjPaperSubViewpointLikeLogEN.updUser)], 非法，应该为字符型(In 子观点点赞表(PaperSubViewpointLikeLog))!(clsPaperSubViewpointLikeLogBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjPaperSubViewpointLikeLogEN.paperSubViewpointLikeLogId 
 || pobjPaperSubViewpointLikeLogEN.paperSubViewpointLikeLogId != null && pobjPaperSubViewpointLikeLogEN.paperSubViewpointLikeLogId.toString()  ===  "")
{
 throw new Error("(errid:Watl000064)字段[点赞Id]不能为空(In 子观点点赞表)!(clsPaperSubViewpointLikeLogBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjPaperSubViewpointLikeLogEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function PaperSubViewpointLikeLog_GetJSONStrByObj (pobjPaperSubViewpointLikeLogEN: clsPaperSubViewpointLikeLogEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjPaperSubViewpointLikeLogEN.sf_UpdFldSetStr = pobjPaperSubViewpointLikeLogEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjPaperSubViewpointLikeLogEN);
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
export function PaperSubViewpointLikeLog_GetObjLstByJSONStr (strJSON: string): Array<clsPaperSubViewpointLikeLogEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrPaperSubViewpointLikeLogObjLst = new Array<clsPaperSubViewpointLikeLogEN>();
if (strJSON === "")
{
return arrPaperSubViewpointLikeLogObjLst;
}
try
{
arrPaperSubViewpointLikeLogObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrPaperSubViewpointLikeLogObjLst;
}
return arrPaperSubViewpointLikeLogObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrPaperSubViewpointLikeLogObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function PaperSubViewpointLikeLog_GetObjLstByJSONObjLst (arrPaperSubViewpointLikeLogObjLstS: Array<clsPaperSubViewpointLikeLogEN>): Array<clsPaperSubViewpointLikeLogEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrPaperSubViewpointLikeLogObjLst = new Array<clsPaperSubViewpointLikeLogEN>();
for (const objInFor of arrPaperSubViewpointLikeLogObjLstS) {
const obj1 = PaperSubViewpointLikeLog_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrPaperSubViewpointLikeLogObjLst.push(obj1);
}
return arrPaperSubViewpointLikeLogObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function PaperSubViewpointLikeLog_GetObjByJSONStr (strJSON: string): clsPaperSubViewpointLikeLogEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjPaperSubViewpointLikeLogEN = new clsPaperSubViewpointLikeLogEN();
if (strJSON === "")
{
return pobjPaperSubViewpointLikeLogEN;
}
try
{
pobjPaperSubViewpointLikeLogEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjPaperSubViewpointLikeLogEN;
}
return pobjPaperSubViewpointLikeLogEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function PaperSubViewpointLikeLog_GetCombineCondition(objPaperSubViewpointLikeLog_Cond: clsPaperSubViewpointLikeLogEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objPaperSubViewpointLikeLog_Cond.dicFldComparisonOp, clsPaperSubViewpointLikeLogEN.con_PaperSubViewpointLikeLogId) == true)
{
const strComparisonOp_PaperSubViewpointLikeLogId:string = objPaperSubViewpointLikeLog_Cond.dicFldComparisonOp[clsPaperSubViewpointLikeLogEN.con_PaperSubViewpointLikeLogId];
strWhereCond += Format(" And {0} {2} {1}", clsPaperSubViewpointLikeLogEN.con_PaperSubViewpointLikeLogId, objPaperSubViewpointLikeLog_Cond.paperSubViewpointLikeLogId, strComparisonOp_PaperSubViewpointLikeLogId);
}
if (Object.prototype.hasOwnProperty.call(objPaperSubViewpointLikeLog_Cond.dicFldComparisonOp, clsPaperSubViewpointLikeLogEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objPaperSubViewpointLikeLog_Cond.dicFldComparisonOp[clsPaperSubViewpointLikeLogEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsPaperSubViewpointLikeLogEN.con_UpdDate, objPaperSubViewpointLikeLog_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objPaperSubViewpointLikeLog_Cond.dicFldComparisonOp, clsPaperSubViewpointLikeLogEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objPaperSubViewpointLikeLog_Cond.dicFldComparisonOp[clsPaperSubViewpointLikeLogEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsPaperSubViewpointLikeLogEN.con_Memo, objPaperSubViewpointLikeLog_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objPaperSubViewpointLikeLog_Cond.dicFldComparisonOp, clsPaperSubViewpointLikeLogEN.con_SubViewpointId) == true)
{
const strComparisonOp_SubViewpointId:string = objPaperSubViewpointLikeLog_Cond.dicFldComparisonOp[clsPaperSubViewpointLikeLogEN.con_SubViewpointId];
strWhereCond += Format(" And {0} {2} {1}", clsPaperSubViewpointLikeLogEN.con_SubViewpointId, objPaperSubViewpointLikeLog_Cond.subViewpointId, strComparisonOp_SubViewpointId);
}
if (Object.prototype.hasOwnProperty.call(objPaperSubViewpointLikeLog_Cond.dicFldComparisonOp, clsPaperSubViewpointLikeLogEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objPaperSubViewpointLikeLog_Cond.dicFldComparisonOp[clsPaperSubViewpointLikeLogEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsPaperSubViewpointLikeLogEN.con_UpdUser, objPaperSubViewpointLikeLog_Cond.updUser, strComparisonOp_UpdUser);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--PaperSubViewpointLikeLog(子观点点赞表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param lngPaperSubViewpointLikeLogId: 点赞Id(要求唯一的字段)
 * @param lngSubViewpointId: 子观点Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function PaperSubViewpointLikeLog_GetUniCondStr_PaperSubViewpointLikeLogId_SubViewpointId(objPaperSubViewpointLikeLogEN: clsPaperSubViewpointLikeLogEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and PaperSubViewpointLikeLogId = '{0}'", objPaperSubViewpointLikeLogEN.paperSubViewpointLikeLogId);
 strWhereCond +=  Format(" and SubViewpointId = '{0}'", objPaperSubViewpointLikeLogEN.subViewpointId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--PaperSubViewpointLikeLog(子观点点赞表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param lngPaperSubViewpointLikeLogId: 点赞Id(要求唯一的字段)
 * @param lngSubViewpointId: 子观点Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function PaperSubViewpointLikeLog_GetUniCondStr4Update_PaperSubViewpointLikeLogId_SubViewpointId(objPaperSubViewpointLikeLogEN: clsPaperSubViewpointLikeLogEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and PaperSubViewpointLikeLogId <> '{0}'", objPaperSubViewpointLikeLogEN.paperSubViewpointLikeLogId);
 strWhereCond +=  Format(" and PaperSubViewpointLikeLogId = '{0}'", objPaperSubViewpointLikeLogEN.paperSubViewpointLikeLogId);
 strWhereCond +=  Format(" and SubViewpointId = '{0}'", objPaperSubViewpointLikeLogEN.subViewpointId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objPaperSubViewpointLikeLogENS:源对象
 * @param objPaperSubViewpointLikeLogENT:目标对象
*/
export function PaperSubViewpointLikeLog_CopyObjTo(objPaperSubViewpointLikeLogENS: clsPaperSubViewpointLikeLogEN , objPaperSubViewpointLikeLogENT: clsPaperSubViewpointLikeLogEN ): void 
{
objPaperSubViewpointLikeLogENT.paperSubViewpointLikeLogId = objPaperSubViewpointLikeLogENS.paperSubViewpointLikeLogId; //点赞Id
objPaperSubViewpointLikeLogENT.updDate = objPaperSubViewpointLikeLogENS.updDate; //修改日期
objPaperSubViewpointLikeLogENT.memo = objPaperSubViewpointLikeLogENS.memo; //备注
objPaperSubViewpointLikeLogENT.subViewpointId = objPaperSubViewpointLikeLogENS.subViewpointId; //子观点Id
objPaperSubViewpointLikeLogENT.updUser = objPaperSubViewpointLikeLogENS.updUser; //修改人
objPaperSubViewpointLikeLogENT.sf_UpdFldSetStr = objPaperSubViewpointLikeLogENS.updFldString; //sf_UpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objPaperSubViewpointLikeLogENS:源对象
 * @param objPaperSubViewpointLikeLogENT:目标对象
*/
export function PaperSubViewpointLikeLog_GetObjFromJsonObj(objPaperSubViewpointLikeLogENS: clsPaperSubViewpointLikeLogEN): clsPaperSubViewpointLikeLogEN 
{
 const objPaperSubViewpointLikeLogENT: clsPaperSubViewpointLikeLogEN = new clsPaperSubViewpointLikeLogEN();
ObjectAssign(objPaperSubViewpointLikeLogENT, objPaperSubViewpointLikeLogENS);
 return objPaperSubViewpointLikeLogENT;
}