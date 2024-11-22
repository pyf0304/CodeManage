
 /**
 * 类名:clsPaperLikeLogWApi
 * 表名:PaperLikeLog(01120566)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:46:15
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
 * 论文点赞表(PaperLikeLog)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clsPaperLikeLogEN } from "../../L0_Entity/Other/clsPaperLikeLogEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { tzDataType } from "../../PubFun/jsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const paperLikeLog_Controller = "PaperLikeLogApi";
 export const paperLikeLog_ConstructorName = "paperLikeLog";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngPaperLikeLogId:关键字
 * @returns 对象
 **/
export async function PaperLikeLog_GetObjByPaperLikeLogIdAsync(lngPaperLikeLogId: number): Promise<clsPaperLikeLogEN>  
{
const strThisFuncName = "GetObjByPaperLikeLogIdAsync";

if (lngPaperLikeLogId == 0)
{
  const strMsg = Format("参数:[lngPaperLikeLogId]不能为空！(In GetObjByPaperLikeLogIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjByPaperLikeLogId";
const strUrl = GetWebApiUrl(paperLikeLog_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"lngPaperLikeLogId": lngPaperLikeLogId,
}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObj = data.returnObj;
if (returnObj == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", paperLikeLog_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objPaperLikeLog = PaperLikeLog_GetObjFromJsonObj(returnObj);
return objPaperLikeLog;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperLikeLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperLikeLog_ConstructorName, strThisFuncName);
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
 * @param lngPaperLikeLogId:所给的关键字
 * @returns 对象
*/
export async function PaperLikeLog_GetObjByPaperLikeLogId_Cache(lngPaperLikeLogId: number, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByPaperLikeLogId_Cache";

if (lngPaperLikeLogId == 0)
{
  const strMsg = Format("参数:[lngPaperLikeLogId]不能为空！(In GetObjByPaperLikeLogId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
const arrPaperLikeLogObjLst_Cache = await PaperLikeLog_GetObjLst_Cache();
try
{
const arrPaperLikeLog_Sel: Array <clsPaperLikeLogEN> = arrPaperLikeLogObjLst_Cache.filter(x => x.paperLikeLogId == lngPaperLikeLogId);
let objPaperLikeLog: clsPaperLikeLogEN;
if (arrPaperLikeLog_Sel.length > 0)
{
objPaperLikeLog = arrPaperLikeLog_Sel[0];
return objPaperLikeLog;
}
else
{
if (bolTryAsyncOnce == true)
{
objPaperLikeLog = await PaperLikeLog_GetObjByPaperLikeLogIdAsync(lngPaperLikeLogId);
if (objPaperLikeLog != null)
{
PaperLikeLog_ReFreshThisCache();
return objPaperLikeLog;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngPaperLikeLogId, paperLikeLog_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param lngPaperLikeLogId:所给的关键字
 * @returns 对象
*/
export async function PaperLikeLog_GetObjByPaperLikeLogId_localStorage(lngPaperLikeLogId: number) {
const strThisFuncName = "GetObjByPaperLikeLogId_localStorage";

if (lngPaperLikeLogId == 0)
{
  const strMsg = Format("参数:[lngPaperLikeLogId]不能为空！(In GetObjByPaperLikeLogId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
const strKey = Format("{0}_{1}", clsPaperLikeLogEN._CurrTabName, lngPaperLikeLogId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objPaperLikeLog_Cache: clsPaperLikeLogEN = JSON.parse(strTempObj);
return objPaperLikeLog_Cache;
}
try
{
const objPaperLikeLog = await PaperLikeLog_GetObjByPaperLikeLogIdAsync(lngPaperLikeLogId);
if (objPaperLikeLog != null)
{
localStorage.setItem(strKey, JSON.stringify(objPaperLikeLog));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objPaperLikeLog;
}
return objPaperLikeLog;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngPaperLikeLogId, paperLikeLog_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objPaperLikeLog:所给的对象
 * @returns 对象
*/
export async function PaperLikeLog_UpdateObjInLst_Cache(objPaperLikeLog: clsPaperLikeLogEN) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrPaperLikeLogObjLst_Cache = await PaperLikeLog_GetObjLst_Cache();
const obj = arrPaperLikeLogObjLst_Cache.find(x => x.paperId == objPaperLikeLog.paperId && x.updUser == objPaperLikeLog.updUser);
if (obj != null)
{
objPaperLikeLog.paperLikeLogId = obj.paperLikeLogId;
ObjectAssign( obj, objPaperLikeLog);
}
else
{
arrPaperLikeLogObjLst_Cache.push(objPaperLikeLog);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, paperLikeLog_ConstructorName, strThisFuncName);
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
export async function PaperLikeLog_func(strInFldName:string , strOutFldName:string ,  strInValue: string) 
{
//const strThisFuncName = "func";

if (strInFldName != clsPaperLikeLogEN.con_PaperLikeLogId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsPaperLikeLogEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clsPaperLikeLogEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const lngPaperLikeLogId = Number(strInValue);
if (lngPaperLikeLogId == 0)
{
return "";
}
const objPaperLikeLog = await PaperLikeLog_GetObjByPaperLikeLogId_Cache(lngPaperLikeLogId );
if (objPaperLikeLog == null) return "";
return objPaperLikeLog.GetFldValue(strOutFldName).toString();
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
export function PaperLikeLog_SortFun_Defa(a:clsPaperLikeLogEN , b:clsPaperLikeLogEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.paperLikeLogId-b.paperLikeLogId;
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
export function PaperLikeLog_SortFun_Defa_2Fld(a:clsPaperLikeLogEN , b:clsPaperLikeLogEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.paperId == b.paperId) return a.updUser.localeCompare(b.updUser);
else return a.paperId.localeCompare(b.paperId);
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
export function PaperLikeLog_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsPaperLikeLogEN.con_PaperLikeLogId:
return (a: clsPaperLikeLogEN, b: clsPaperLikeLogEN) => {
return a.paperLikeLogId-b.paperLikeLogId;
}
case clsPaperLikeLogEN.con_PaperId:
return (a: clsPaperLikeLogEN, b: clsPaperLikeLogEN) => {
return a.paperId.localeCompare(b.paperId);
}
case clsPaperLikeLogEN.con_UpdUser:
return (a: clsPaperLikeLogEN, b: clsPaperLikeLogEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsPaperLikeLogEN.con_UpdDate:
return (a: clsPaperLikeLogEN, b: clsPaperLikeLogEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsPaperLikeLogEN.con_Memo:
return (a: clsPaperLikeLogEN, b: clsPaperLikeLogEN) => {
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[PaperLikeLog]中不存在！(in ${ paperLikeLog_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsPaperLikeLogEN.con_PaperLikeLogId:
return (a: clsPaperLikeLogEN, b: clsPaperLikeLogEN) => {
return b.paperLikeLogId-a.paperLikeLogId;
}
case clsPaperLikeLogEN.con_PaperId:
return (a: clsPaperLikeLogEN, b: clsPaperLikeLogEN) => {
return b.paperId.localeCompare(a.paperId);
}
case clsPaperLikeLogEN.con_UpdUser:
return (a: clsPaperLikeLogEN, b: clsPaperLikeLogEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsPaperLikeLogEN.con_UpdDate:
return (a: clsPaperLikeLogEN, b: clsPaperLikeLogEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsPaperLikeLogEN.con_Memo:
return (a: clsPaperLikeLogEN, b: clsPaperLikeLogEN) => {
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[PaperLikeLog]中不存在！(in ${ paperLikeLog_ConstructorName}.${ strThisFuncName})`;
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
export async function PaperLikeLog_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsPaperLikeLogEN.con_PaperLikeLogId:
return (obj: clsPaperLikeLogEN) => {
return obj.paperLikeLogId === value;
}
case clsPaperLikeLogEN.con_PaperId:
return (obj: clsPaperLikeLogEN) => {
return obj.paperId === value;
}
case clsPaperLikeLogEN.con_UpdUser:
return (obj: clsPaperLikeLogEN) => {
return obj.updUser === value;
}
case clsPaperLikeLogEN.con_UpdDate:
return (obj: clsPaperLikeLogEN) => {
return obj.updDate === value;
}
case clsPaperLikeLogEN.con_Memo:
return (obj: clsPaperLikeLogEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[PaperLikeLog]中不存在！(in ${ paperLikeLog_ConstructorName}.${ strThisFuncName})`;
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
export async function PaperLikeLog_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(paperLikeLog_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperLikeLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperLikeLog_ConstructorName, strThisFuncName);
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
export async function PaperLikeLog_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(paperLikeLog_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperLikeLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperLikeLog_ConstructorName, strThisFuncName);
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
export async function PaperLikeLog_GetFirstObjAsync(strWhereCond: string): Promise<clsPaperLikeLogEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(paperLikeLog_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", paperLikeLog_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objPaperLikeLog = PaperLikeLog_GetObjFromJsonObj(returnObj);
return objPaperLikeLog;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperLikeLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperLikeLog_ConstructorName, strThisFuncName);
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
export async function PaperLikeLog_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsPaperLikeLogEN._CurrTabName;
clsPaperLikeLogEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsPaperLikeLogEN._CurrTabName);
if (IsNullOrEmpty(clsPaperLikeLogEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsPaperLikeLogEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrPaperLikeLogExObjLst_Cache: Array<clsPaperLikeLogEN> = CacheHelper.Get(strKey);
const arrPaperLikeLogObjLst_T = PaperLikeLog_GetObjLstByJSONObjLst(arrPaperLikeLogExObjLst_Cache);
return arrPaperLikeLogObjLst_T;
}
try
{
const arrPaperLikeLogExObjLst = await PaperLikeLog_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrPaperLikeLogExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrPaperLikeLogExObjLst.length);
console.log(strInfo);
return arrPaperLikeLogExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, paperLikeLog_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function PaperLikeLog_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsPaperLikeLogEN._CurrTabName;
clsPaperLikeLogEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsPaperLikeLogEN._CurrTabName);
if (IsNullOrEmpty(clsPaperLikeLogEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsPaperLikeLogEN.CacheAddiCondition);
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
const arrPaperLikeLogExObjLst_Cache: Array<clsPaperLikeLogEN> = JSON.parse(strTempObjLst);
const arrPaperLikeLogObjLst_T = PaperLikeLog_GetObjLstByJSONObjLst(arrPaperLikeLogExObjLst_Cache);
return arrPaperLikeLogObjLst_T;
}
try
{
const arrPaperLikeLogExObjLst = await PaperLikeLog_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrPaperLikeLogExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrPaperLikeLogExObjLst.length);
console.log(strInfo);
return arrPaperLikeLogExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, paperLikeLog_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function PaperLikeLog_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsPaperLikeLogEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrPaperLikeLogObjLst_Cache: Array<clsPaperLikeLogEN> = JSON.parse(strTempObjLst);
return arrPaperLikeLogObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function PaperLikeLog_GetObjLstAsync(strWhereCond: string): Promise<Array<clsPaperLikeLogEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(paperLikeLog_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", paperLikeLog_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = PaperLikeLog_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperLikeLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperLikeLog_ConstructorName, strThisFuncName);
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
export async function PaperLikeLog_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsPaperLikeLogEN._CurrTabName;
clsPaperLikeLogEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsPaperLikeLogEN._CurrTabName);
if (IsNullOrEmpty(clsPaperLikeLogEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsPaperLikeLogEN.CacheAddiCondition);
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
const arrPaperLikeLogExObjLst_Cache: Array<clsPaperLikeLogEN> = JSON.parse(strTempObjLst);
const arrPaperLikeLogObjLst_T = PaperLikeLog_GetObjLstByJSONObjLst(arrPaperLikeLogExObjLst_Cache);
return arrPaperLikeLogObjLst_T;
}
try
{
const arrPaperLikeLogExObjLst = await PaperLikeLog_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrPaperLikeLogExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrPaperLikeLogExObjLst.length);
console.log(strInfo);
return arrPaperLikeLogExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, paperLikeLog_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function PaperLikeLog_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsPaperLikeLogEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrPaperLikeLogObjLst_Cache: Array<clsPaperLikeLogEN> = JSON.parse(strTempObjLst);
return arrPaperLikeLogObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function PaperLikeLog_GetObjLst_Cache(): Promise<Array<clsPaperLikeLogEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrPaperLikeLogObjLst_Cache;
switch (clsPaperLikeLogEN.CacheModeId)
{
case "04"://sessionStorage
arrPaperLikeLogObjLst_Cache = await PaperLikeLog_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrPaperLikeLogObjLst_Cache = await PaperLikeLog_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrPaperLikeLogObjLst_Cache = await PaperLikeLog_GetObjLst_ClientCache();
break;
default:
arrPaperLikeLogObjLst_Cache = await PaperLikeLog_GetObjLst_ClientCache();
break;
}
const arrPaperLikeLogObjLst = PaperLikeLog_GetObjLstByJSONObjLst(arrPaperLikeLogObjLst_Cache);
return arrPaperLikeLogObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function PaperLikeLog_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrPaperLikeLogObjLst_Cache;
switch (clsPaperLikeLogEN.CacheModeId)
{
case "04"://sessionStorage
arrPaperLikeLogObjLst_Cache = await PaperLikeLog_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrPaperLikeLogObjLst_Cache = await PaperLikeLog_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrPaperLikeLogObjLst_Cache = null;
break;
default:
arrPaperLikeLogObjLst_Cache = null;
break;
}
return arrPaperLikeLogObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objlngPaperLikeLogId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function PaperLikeLog_GetSubObjLst_Cache(objPaperLikeLog_Cond: clsPaperLikeLogEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrPaperLikeLogObjLst_Cache = await PaperLikeLog_GetObjLst_Cache();
let arrPaperLikeLog_Sel: Array < clsPaperLikeLogEN > = arrPaperLikeLogObjLst_Cache;
if (objPaperLikeLog_Cond.sf_FldComparisonOp == null || objPaperLikeLog_Cond.sf_FldComparisonOp == "") return arrPaperLikeLog_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objPaperLikeLog_Cond.sf_FldComparisonOp);
//console.log("clsPaperLikeLogWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objPaperLikeLog_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objPaperLikeLog_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrPaperLikeLog_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objPaperLikeLog_Cond), paperLikeLog_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsPaperLikeLogEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrPaperLikeLogId:关键字列表
 * @returns 对象列表
 **/
export async function PaperLikeLog_GetObjLstByPaperLikeLogIdLstAsync(arrPaperLikeLogId: Array<string>): Promise<Array<clsPaperLikeLogEN>>  
{
const strThisFuncName = "GetObjLstByPaperLikeLogIdLstAsync";
const strAction = "GetObjLstByPaperLikeLogIdLst";
const strUrl = GetWebApiUrl(paperLikeLog_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrPaperLikeLogId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", paperLikeLog_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = PaperLikeLog_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperLikeLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperLikeLog_ConstructorName, strThisFuncName);
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
 * @param arrlngPaperLikeLogIdLst:关键字列表
 * @returns 对象列表
*/
export async function PaperLikeLog_GetObjLstByPaperLikeLogIdLst_Cache(arrPaperLikeLogIdLst: Array<number>) {
const strThisFuncName = "GetObjLstByPaperLikeLogIdLst_Cache";
try
{
const arrPaperLikeLogObjLst_Cache = await PaperLikeLog_GetObjLst_Cache();
const arrPaperLikeLog_Sel: Array <clsPaperLikeLogEN> = arrPaperLikeLogObjLst_Cache.filter(x => arrPaperLikeLogIdLst.indexOf(x.paperLikeLogId)>-1);
return arrPaperLikeLog_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrPaperLikeLogIdLst.join(","), paperLikeLog_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsPaperLikeLogEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function PaperLikeLog_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsPaperLikeLogEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(paperLikeLog_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", paperLikeLog_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = PaperLikeLog_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperLikeLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperLikeLog_ConstructorName, strThisFuncName);
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
export async function PaperLikeLog_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsPaperLikeLogEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(paperLikeLog_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", paperLikeLog_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = PaperLikeLog_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperLikeLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperLikeLog_ConstructorName, strThisFuncName);
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
export async function PaperLikeLog_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(paperLikeLog_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperLikeLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperLikeLog_ConstructorName, strThisFuncName);
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
export async function PaperLikeLog_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrPaperLikeLogObjLst_Cache = await PaperLikeLog_GetObjLst_Cache();
if (arrPaperLikeLogObjLst_Cache.length == 0) return arrPaperLikeLogObjLst_Cache;
let arrPaperLikeLog_Sel = arrPaperLikeLogObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objPaperLikeLog_Cond = new clsPaperLikeLogEN();
ObjectAssign(objPaperLikeLog_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsPaperLikeLogWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objPaperLikeLog_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrPaperLikeLog_Sel.length == 0) return arrPaperLikeLog_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.sort(PaperLikeLog_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.sort(objPagerPara.sortFun);
}
arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.slice(intStart, intEnd);     
return arrPaperLikeLog_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, paperLikeLog_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsPaperLikeLogEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function PaperLikeLog_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsPaperLikeLogEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(paperLikeLog_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", paperLikeLog_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = PaperLikeLog_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperLikeLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperLikeLog_ConstructorName, strThisFuncName);
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
 * @param lngPaperLikeLogId:关键字
 * @returns 获取删除的结果
 **/
export async function PaperLikeLog_DelRecordAsync(lngPaperLikeLogId: number): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(paperLikeLog_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, lngPaperLikeLogId);
try
{
const response = await axios.delete(strUrl,
{
params: { "Id": lngPaperLikeLogId, }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperLikeLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperLikeLog_ConstructorName, strThisFuncName);
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
 * @param arrPaperLikeLogId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function PaperLikeLog_DelPaperLikeLogsAsync(arrPaperLikeLogId: Array<string>): Promise<number> 
{
const strThisFuncName = "DelPaperLikeLogsAsync";
const strAction = "DelPaperLikeLogs";
const strUrl = GetWebApiUrl(paperLikeLog_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrPaperLikeLogId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperLikeLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperLikeLog_ConstructorName, strThisFuncName);
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
export async function PaperLikeLog_DelPaperLikeLogsByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "DelPaperLikeLogsByCondAsync";
const strAction = "DelPaperLikeLogsByCond";
const strUrl = GetWebApiUrl(paperLikeLog_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperLikeLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperLikeLog_ConstructorName, strThisFuncName);
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
 * @param objPaperLikeLogEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function PaperLikeLog_AddNewRecordAsync(objPaperLikeLogEN: clsPaperLikeLogEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objPaperLikeLogEN);
const strUrl = GetWebApiUrl(paperLikeLog_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPaperLikeLogEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperLikeLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperLikeLog_ConstructorName, strThisFuncName);
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
 * @param objPaperLikeLogEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function PaperLikeLog_AddNewRecordWithReturnKeyAsync(objPaperLikeLogEN: clsPaperLikeLogEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(paperLikeLog_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPaperLikeLogEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperLikeLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperLikeLog_ConstructorName, strThisFuncName);
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
 * @param objPaperLikeLogEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function PaperLikeLog_AddNewRecordWithReturnKey(objPaperLikeLogEN: clsPaperLikeLogEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objPaperLikeLogEN.paperLikeLogId === null || objPaperLikeLogEN.paperLikeLogId === 0)
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(paperLikeLog_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPaperLikeLogEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperLikeLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperLikeLog_ConstructorName, strThisFuncName);
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
 * @param objPaperLikeLogEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function PaperLikeLog_UpdateRecordAsync(objPaperLikeLogEN: clsPaperLikeLogEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objPaperLikeLogEN.sf_UpdFldSetStr === undefined || objPaperLikeLogEN.sf_UpdFldSetStr === null || objPaperLikeLogEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objPaperLikeLogEN.paperLikeLogId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(paperLikeLog_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPaperLikeLogEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperLikeLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperLikeLog_ConstructorName, strThisFuncName);
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
 * @param objPaperLikeLogEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function PaperLikeLog_UpdateWithConditionAsync(objPaperLikeLogEN: clsPaperLikeLogEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objPaperLikeLogEN.sf_UpdFldSetStr === undefined || objPaperLikeLogEN.sf_UpdFldSetStr === null || objPaperLikeLogEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objPaperLikeLogEN.paperLikeLogId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(paperLikeLog_Controller, strAction);
objPaperLikeLogEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objPaperLikeLogEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperLikeLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperLikeLog_ConstructorName, strThisFuncName);
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
 * @param objlngPaperLikeLogId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function PaperLikeLog_IsExistRecord_Cache(objPaperLikeLog_Cond: clsPaperLikeLogEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrPaperLikeLogObjLst_Cache = await PaperLikeLog_GetObjLst_Cache();
if (arrPaperLikeLogObjLst_Cache == null) return false;
let arrPaperLikeLog_Sel: Array < clsPaperLikeLogEN > = arrPaperLikeLogObjLst_Cache;
if (objPaperLikeLog_Cond.sf_FldComparisonOp == null || objPaperLikeLog_Cond.sf_FldComparisonOp == "") return arrPaperLikeLog_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objPaperLikeLog_Cond.sf_FldComparisonOp);
//console.log("clsPaperLikeLogWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objPaperLikeLog_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objPaperLikeLog_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrPaperLikeLog_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objPaperLikeLog_Cond), paperLikeLog_ConstructorName, strThisFuncName);
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
export async function PaperLikeLog_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(paperLikeLog_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperLikeLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperLikeLog_ConstructorName, strThisFuncName);
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
 * @param lngPaperLikeLogId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function PaperLikeLog_IsExist(lngPaperLikeLogId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(paperLikeLog_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"PaperLikeLogId": lngPaperLikeLogId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperLikeLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperLikeLog_ConstructorName, strThisFuncName);
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
 * @param lngPaperLikeLogId:所给的关键字
 * @returns 对象
*/
export async function PaperLikeLog_IsExist_Cache(lngPaperLikeLogId:number) {
const strThisFuncName = "IsExist_Cache";
const arrPaperLikeLogObjLst_Cache = await PaperLikeLog_GetObjLst_Cache();
if (arrPaperLikeLogObjLst_Cache == null) return false;
try
{
const arrPaperLikeLog_Sel: Array <clsPaperLikeLogEN> = arrPaperLikeLogObjLst_Cache.filter(x => x.paperLikeLogId == lngPaperLikeLogId);
if (arrPaperLikeLog_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngPaperLikeLogId, paperLikeLog_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param lngPaperLikeLogId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function PaperLikeLog_IsExistAsync(lngPaperLikeLogId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(paperLikeLog_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "lngPaperLikeLogId": lngPaperLikeLogId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperLikeLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperLikeLog_ConstructorName, strThisFuncName);
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
export async function PaperLikeLog_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(paperLikeLog_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperLikeLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperLikeLog_ConstructorName, strThisFuncName);
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
 * @param objPaperLikeLog_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function PaperLikeLog_GetRecCountByCond_Cache(objPaperLikeLog_Cond: clsPaperLikeLogEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrPaperLikeLogObjLst_Cache = await PaperLikeLog_GetObjLst_Cache();
if (arrPaperLikeLogObjLst_Cache == null) return 0;
let arrPaperLikeLog_Sel: Array < clsPaperLikeLogEN > = arrPaperLikeLogObjLst_Cache;
if (objPaperLikeLog_Cond.sf_FldComparisonOp == null || objPaperLikeLog_Cond.sf_FldComparisonOp == "") return arrPaperLikeLog_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objPaperLikeLog_Cond.sf_FldComparisonOp);
//console.log("clsPaperLikeLogWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objPaperLikeLog_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objPaperLikeLog_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrPaperLikeLog_Sel = arrPaperLikeLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrPaperLikeLog_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objPaperLikeLog_Cond), paperLikeLog_ConstructorName, strThisFuncName);
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
export async function PaperLikeLog_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(paperLikeLog_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperLikeLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperLikeLog_ConstructorName, strThisFuncName);
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
export function PaperLikeLog_GetWebApiUrl(strController: string, strAction: string): string {
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
export function PaperLikeLog_ReFreshCache():void
{
const strThisFuncName = "ReFreshCache";

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = clsPaperLikeLogEN._CurrTabName;
switch (clsPaperLikeLogEN.CacheModeId)
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
}

 /**
 * 刷新本类中的缓存.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
 **/
export function PaperLikeLog_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clsPaperLikeLogEN._CurrTabName;
switch (clsPaperLikeLogEN.CacheModeId)
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
export function PaperLikeLog_CheckPropertyNew(pobjPaperLikeLogEN: clsPaperLikeLogEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjPaperLikeLogEN.updUser) === true )
{
 throw new Error("(errid:Watl000058)字段[修改人]不能为空(In 论文点赞表)!(clsPaperLikeLogBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjPaperLikeLogEN.paperId) == false && GetStrLen(pobjPaperLikeLogEN.paperId) > 8)
{
 throw new Error("(errid:Watl000059)字段[论文Id(paperId)]的长度不能超过8(In 论文点赞表(PaperLikeLog))!值:$(pobjPaperLikeLogEN.paperId)(clsPaperLikeLogBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperLikeLogEN.updUser) == false && GetStrLen(pobjPaperLikeLogEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 论文点赞表(PaperLikeLog))!值:$(pobjPaperLikeLogEN.updUser)(clsPaperLikeLogBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperLikeLogEN.updDate) == false && GetStrLen(pobjPaperLikeLogEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 论文点赞表(PaperLikeLog))!值:$(pobjPaperLikeLogEN.updDate)(clsPaperLikeLogBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperLikeLogEN.memo) == false && GetStrLen(pobjPaperLikeLogEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 论文点赞表(PaperLikeLog))!值:$(pobjPaperLikeLogEN.memo)(clsPaperLikeLogBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null != pobjPaperLikeLogEN.paperLikeLogId && undefined !== pobjPaperLikeLogEN.paperLikeLogId && tzDataType.isNumber(pobjPaperLikeLogEN.paperLikeLogId) === false)
{
 throw new Error("(errid:Watl000060)字段[论文点赞表Id(paperLikeLogId)]的值:[$(pobjPaperLikeLogEN.paperLikeLogId)], 非法，应该为数值型(In 论文点赞表(PaperLikeLog))!(clsPaperLikeLogBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperLikeLogEN.paperId) == false && undefined !== pobjPaperLikeLogEN.paperId && tzDataType.isString(pobjPaperLikeLogEN.paperId) === false)
{
 throw new Error("(errid:Watl000060)字段[论文Id(paperId)]的值:[$(pobjPaperLikeLogEN.paperId)], 非法，应该为字符型(In 论文点赞表(PaperLikeLog))!(clsPaperLikeLogBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperLikeLogEN.updUser) == false && undefined !== pobjPaperLikeLogEN.updUser && tzDataType.isString(pobjPaperLikeLogEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjPaperLikeLogEN.updUser)], 非法，应该为字符型(In 论文点赞表(PaperLikeLog))!(clsPaperLikeLogBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperLikeLogEN.updDate) == false && undefined !== pobjPaperLikeLogEN.updDate && tzDataType.isString(pobjPaperLikeLogEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjPaperLikeLogEN.updDate)], 非法，应该为字符型(In 论文点赞表(PaperLikeLog))!(clsPaperLikeLogBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperLikeLogEN.memo) == false && undefined !== pobjPaperLikeLogEN.memo && tzDataType.isString(pobjPaperLikeLogEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjPaperLikeLogEN.memo)], 非法，应该为字符型(In 论文点赞表(PaperLikeLog))!(clsPaperLikeLogBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjPaperLikeLogEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function PaperLikeLog_CheckProperty4Update (pobjPaperLikeLogEN: clsPaperLikeLogEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjPaperLikeLogEN.paperId) == false && GetStrLen(pobjPaperLikeLogEN.paperId) > 8)
{
 throw new Error("(errid:Watl000062)字段[论文Id(paperId)]的长度不能超过8(In 论文点赞表(PaperLikeLog))!值:$(pobjPaperLikeLogEN.paperId)(clsPaperLikeLogBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperLikeLogEN.updUser) == false && GetStrLen(pobjPaperLikeLogEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 论文点赞表(PaperLikeLog))!值:$(pobjPaperLikeLogEN.updUser)(clsPaperLikeLogBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperLikeLogEN.updDate) == false && GetStrLen(pobjPaperLikeLogEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 论文点赞表(PaperLikeLog))!值:$(pobjPaperLikeLogEN.updDate)(clsPaperLikeLogBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperLikeLogEN.memo) == false && GetStrLen(pobjPaperLikeLogEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 论文点赞表(PaperLikeLog))!值:$(pobjPaperLikeLogEN.memo)(clsPaperLikeLogBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null != pobjPaperLikeLogEN.paperLikeLogId && undefined !== pobjPaperLikeLogEN.paperLikeLogId && tzDataType.isNumber(pobjPaperLikeLogEN.paperLikeLogId) === false)
{
 throw new Error("(errid:Watl000063)字段[论文点赞表Id(paperLikeLogId)]的值:[$(pobjPaperLikeLogEN.paperLikeLogId)], 非法，应该为数值型(In 论文点赞表(PaperLikeLog))!(clsPaperLikeLogBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperLikeLogEN.paperId) == false && undefined !== pobjPaperLikeLogEN.paperId && tzDataType.isString(pobjPaperLikeLogEN.paperId) === false)
{
 throw new Error("(errid:Watl000063)字段[论文Id(paperId)]的值:[$(pobjPaperLikeLogEN.paperId)], 非法，应该为字符型(In 论文点赞表(PaperLikeLog))!(clsPaperLikeLogBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperLikeLogEN.updUser) == false && undefined !== pobjPaperLikeLogEN.updUser && tzDataType.isString(pobjPaperLikeLogEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjPaperLikeLogEN.updUser)], 非法，应该为字符型(In 论文点赞表(PaperLikeLog))!(clsPaperLikeLogBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperLikeLogEN.updDate) == false && undefined !== pobjPaperLikeLogEN.updDate && tzDataType.isString(pobjPaperLikeLogEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjPaperLikeLogEN.updDate)], 非法，应该为字符型(In 论文点赞表(PaperLikeLog))!(clsPaperLikeLogBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperLikeLogEN.memo) == false && undefined !== pobjPaperLikeLogEN.memo && tzDataType.isString(pobjPaperLikeLogEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjPaperLikeLogEN.memo)], 非法，应该为字符型(In 论文点赞表(PaperLikeLog))!(clsPaperLikeLogBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjPaperLikeLogEN.paperLikeLogId 
 || pobjPaperLikeLogEN.paperLikeLogId != null && pobjPaperLikeLogEN.paperLikeLogId.toString()  ===  "")
{
 throw new Error("(errid:Watl000064)字段[论文点赞表Id]不能为空(In 论文点赞表)!(clsPaperLikeLogBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjPaperLikeLogEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function PaperLikeLog_GetJSONStrByObj (pobjPaperLikeLogEN: clsPaperLikeLogEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjPaperLikeLogEN.sf_UpdFldSetStr = pobjPaperLikeLogEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjPaperLikeLogEN);
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
export function PaperLikeLog_GetObjLstByJSONStr (strJSON: string): Array<clsPaperLikeLogEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrPaperLikeLogObjLst = new Array<clsPaperLikeLogEN>();
if (strJSON === "")
{
return arrPaperLikeLogObjLst;
}
try
{
arrPaperLikeLogObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrPaperLikeLogObjLst;
}
return arrPaperLikeLogObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrPaperLikeLogObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function PaperLikeLog_GetObjLstByJSONObjLst (arrPaperLikeLogObjLstS: Array<clsPaperLikeLogEN>): Array<clsPaperLikeLogEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrPaperLikeLogObjLst = new Array<clsPaperLikeLogEN>();
for (const objInFor of arrPaperLikeLogObjLstS) {
const obj1 = PaperLikeLog_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrPaperLikeLogObjLst.push(obj1);
}
return arrPaperLikeLogObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function PaperLikeLog_GetObjByJSONStr (strJSON: string): clsPaperLikeLogEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjPaperLikeLogEN = new clsPaperLikeLogEN();
if (strJSON === "")
{
return pobjPaperLikeLogEN;
}
try
{
pobjPaperLikeLogEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjPaperLikeLogEN;
}
return pobjPaperLikeLogEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function PaperLikeLog_GetCombineCondition(objPaperLikeLog_Cond: clsPaperLikeLogEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objPaperLikeLog_Cond.dicFldComparisonOp, clsPaperLikeLogEN.con_PaperLikeLogId) == true)
{
const strComparisonOp_PaperLikeLogId:string = objPaperLikeLog_Cond.dicFldComparisonOp[clsPaperLikeLogEN.con_PaperLikeLogId];
strWhereCond += Format(" And {0} {2} {1}", clsPaperLikeLogEN.con_PaperLikeLogId, objPaperLikeLog_Cond.paperLikeLogId, strComparisonOp_PaperLikeLogId);
}
if (Object.prototype.hasOwnProperty.call(objPaperLikeLog_Cond.dicFldComparisonOp, clsPaperLikeLogEN.con_PaperId) == true)
{
const strComparisonOp_PaperId:string = objPaperLikeLog_Cond.dicFldComparisonOp[clsPaperLikeLogEN.con_PaperId];
strWhereCond += Format(" And {0} {2} '{1}'", clsPaperLikeLogEN.con_PaperId, objPaperLikeLog_Cond.paperId, strComparisonOp_PaperId);
}
if (Object.prototype.hasOwnProperty.call(objPaperLikeLog_Cond.dicFldComparisonOp, clsPaperLikeLogEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objPaperLikeLog_Cond.dicFldComparisonOp[clsPaperLikeLogEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsPaperLikeLogEN.con_UpdUser, objPaperLikeLog_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objPaperLikeLog_Cond.dicFldComparisonOp, clsPaperLikeLogEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objPaperLikeLog_Cond.dicFldComparisonOp[clsPaperLikeLogEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsPaperLikeLogEN.con_UpdDate, objPaperLikeLog_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objPaperLikeLog_Cond.dicFldComparisonOp, clsPaperLikeLogEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objPaperLikeLog_Cond.dicFldComparisonOp[clsPaperLikeLogEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsPaperLikeLogEN.con_Memo, objPaperLikeLog_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--PaperLikeLog(论文点赞表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param strPaperId: 论文Id(要求唯一的字段)
 * @param strUpdUser: 修改人(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function PaperLikeLog_GetUniCondStr_PaperId_UpdUser(objPaperLikeLogEN: clsPaperLikeLogEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and PaperId = '{0}'", objPaperLikeLogEN.paperId);
 strWhereCond +=  Format(" and UpdUser = '{0}'", objPaperLikeLogEN.updUser);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--PaperLikeLog(论文点赞表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param strPaperId: 论文Id(要求唯一的字段)
 * @param strUpdUser: 修改人(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function PaperLikeLog_GetUniCondStr4Update_PaperId_UpdUser(objPaperLikeLogEN: clsPaperLikeLogEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and PaperLikeLogId <> '{0}'", objPaperLikeLogEN.paperLikeLogId);
 strWhereCond +=  Format(" and PaperId = '{0}'", objPaperLikeLogEN.paperId);
 strWhereCond +=  Format(" and UpdUser = '{0}'", objPaperLikeLogEN.updUser);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objPaperLikeLogENS:源对象
 * @param objPaperLikeLogENT:目标对象
*/
export function PaperLikeLog_CopyObjTo(objPaperLikeLogENS: clsPaperLikeLogEN , objPaperLikeLogENT: clsPaperLikeLogEN ): void 
{
objPaperLikeLogENT.paperLikeLogId = objPaperLikeLogENS.paperLikeLogId; //论文点赞表Id
objPaperLikeLogENT.paperId = objPaperLikeLogENS.paperId; //论文Id
objPaperLikeLogENT.updUser = objPaperLikeLogENS.updUser; //修改人
objPaperLikeLogENT.updDate = objPaperLikeLogENS.updDate; //修改日期
objPaperLikeLogENT.memo = objPaperLikeLogENS.memo; //备注
objPaperLikeLogENT.sf_UpdFldSetStr = objPaperLikeLogENS.updFldString; //sf_UpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objPaperLikeLogENS:源对象
 * @param objPaperLikeLogENT:目标对象
*/
export function PaperLikeLog_GetObjFromJsonObj(objPaperLikeLogENS: clsPaperLikeLogEN): clsPaperLikeLogEN 
{
 const objPaperLikeLogENT: clsPaperLikeLogEN = new clsPaperLikeLogEN();
ObjectAssign(objPaperLikeLogENT, objPaperLikeLogENS);
 return objPaperLikeLogENT;
}