
 /**
 * 类名:clsgs_TopicTaskStatusWApi
 * 表名:gs_TopicTaskStatus(01120664)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:46:24
 * 生成者:pyf
 * 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:研培参数(ParameterTable)
 * 框架-层名:WA_访问层(TS)(WA_Access)
 * 编程语言:TypeScript
 * 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
   *      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 **/

/**
 * 主题任务状态(gs_TopicTaskStatus)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clsgs_TopicTaskStatusEN } from "../../L0_Entity/ParameterTable/clsgs_TopicTaskStatusEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { tzDataType } from "../../PubFun/jsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const gs_TopicTaskStatus_Controller = "gs_TopicTaskStatusApi";
 export const gs_TopicTaskStatus_ConstructorName = "gs_TopicTaskStatus";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strStatusId:关键字
 * @returns 对象
 **/
export async function gs_TopicTaskStatus_GetObjByStatusIdAsync(strStatusId: string): Promise<clsgs_TopicTaskStatusEN>  
{
const strThisFuncName = "GetObjByStatusIdAsync";

if (IsNullOrEmpty(strStatusId) == true)
{
  const strMsg = Format("参数:[strStatusId]不能为空！(In GetObjByStatusIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strStatusId.length != 2)
{
const strMsg = Format("缓存分类变量:[strStatusId]的长度:[{0}]不正确！", strStatusId.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByStatusId";
const strUrl = GetWebApiUrl(gs_TopicTaskStatus_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strStatusId": strStatusId,
}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObj = data.returnObj;
if (returnObj == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_TopicTaskStatus_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objgs_TopicTaskStatus = gs_TopicTaskStatus_GetObjFromJsonObj(returnObj);
return objgs_TopicTaskStatus;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TopicTaskStatus_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TopicTaskStatus_ConstructorName, strThisFuncName);
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
 * @param strStatusId:所给的关键字
 * @returns 对象
*/
export async function gs_TopicTaskStatus_GetObjByStatusId_Cache(strStatusId: string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByStatusId_Cache";

if (IsNullOrEmpty(strStatusId) == true)
{
  const strMsg = Format("参数:[strStatusId]不能为空！(In GetObjByStatusId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strStatusId.length != 2)
{
const strMsg = Format("缓存分类变量:[strStatusId]的长度:[{0}]不正确！", strStatusId.length);
console.error(strMsg);
throw (strMsg);
}
const arrgs_TopicTaskStatusObjLst_Cache = await gs_TopicTaskStatus_GetObjLst_Cache();
try
{
const arrgs_TopicTaskStatus_Sel: Array <clsgs_TopicTaskStatusEN> = arrgs_TopicTaskStatusObjLst_Cache.filter(x => x.statusId == strStatusId);
let objgs_TopicTaskStatus: clsgs_TopicTaskStatusEN;
if (arrgs_TopicTaskStatus_Sel.length > 0)
{
objgs_TopicTaskStatus = arrgs_TopicTaskStatus_Sel[0];
return objgs_TopicTaskStatus;
}
else
{
if (bolTryAsyncOnce == true)
{
objgs_TopicTaskStatus = await gs_TopicTaskStatus_GetObjByStatusIdAsync(strStatusId);
if (objgs_TopicTaskStatus != null)
{
gs_TopicTaskStatus_ReFreshThisCache();
return objgs_TopicTaskStatus;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strStatusId, gs_TopicTaskStatus_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param strStatusId:所给的关键字
 * @returns 对象
*/
export async function gs_TopicTaskStatus_GetObjByStatusId_localStorage(strStatusId: string) {
const strThisFuncName = "GetObjByStatusId_localStorage";

if (IsNullOrEmpty(strStatusId) == true)
{
  const strMsg = Format("参数:[strStatusId]不能为空！(In GetObjByStatusId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
if (strStatusId.length != 2)
{
const strMsg = Format("缓存分类变量:[strStatusId]的长度:[{0}]不正确！", strStatusId.length);
console.error(strMsg);
throw (strMsg);
}
const strKey = Format("{0}_{1}", clsgs_TopicTaskStatusEN._CurrTabName, strStatusId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objgs_TopicTaskStatus_Cache: clsgs_TopicTaskStatusEN = JSON.parse(strTempObj);
return objgs_TopicTaskStatus_Cache;
}
try
{
const objgs_TopicTaskStatus = await gs_TopicTaskStatus_GetObjByStatusIdAsync(strStatusId);
if (objgs_TopicTaskStatus != null)
{
localStorage.setItem(strKey, JSON.stringify(objgs_TopicTaskStatus));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objgs_TopicTaskStatus;
}
return objgs_TopicTaskStatus;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strStatusId, gs_TopicTaskStatus_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objgs_TopicTaskStatus:所给的对象
 * @returns 对象
*/
export async function gs_TopicTaskStatus_UpdateObjInLst_Cache(objgs_TopicTaskStatus: clsgs_TopicTaskStatusEN) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrgs_TopicTaskStatusObjLst_Cache = await gs_TopicTaskStatus_GetObjLst_Cache();
const obj = arrgs_TopicTaskStatusObjLst_Cache.find(x => 
x.statusId == objgs_TopicTaskStatus.statusId);
if (obj != null)
{
objgs_TopicTaskStatus.statusId = obj.statusId;
ObjectAssign( obj, objgs_TopicTaskStatus);
}
else
{
arrgs_TopicTaskStatusObjLst_Cache.push(objgs_TopicTaskStatus);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, gs_TopicTaskStatus_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
}

/**
 * 根据关键字获取相关对象的名称属性, 从缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
 * @param strStatusId:所给的关键字
 * @returns 对象
*/
export async function gs_TopicTaskStatus_GetNameByStatusId_Cache(strStatusId: string) {
const strThisFuncName = "GetNameByStatusId_Cache";

if (IsNullOrEmpty(strStatusId) == true)
{
  const strMsg = Format("参数:[strStatusId]不能为空！(In GetNameByStatusId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strStatusId.length != 2)
{
const strMsg = Format("缓存分类变量:[strStatusId]的长度:[{0}]不正确！", strStatusId.length);
console.error(strMsg);
throw (strMsg);
}
const arrgs_TopicTaskStatusObjLst_Cache = await gs_TopicTaskStatus_GetObjLst_Cache();
if (arrgs_TopicTaskStatusObjLst_Cache == null) return "";
try
{
const arrgs_TopicTaskStatus_Sel: Array <clsgs_TopicTaskStatusEN> = arrgs_TopicTaskStatusObjLst_Cache.filter(x => x.statusId == strStatusId);
let objgs_TopicTaskStatus: clsgs_TopicTaskStatusEN;
if (arrgs_TopicTaskStatus_Sel.length > 0)
{
objgs_TopicTaskStatus = arrgs_TopicTaskStatus_Sel[0];
return objgs_TopicTaskStatus.statusName;
}
else
{
return "";
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strStatusId);
console.error(strMsg);
alert(strMsg);
}
return "";
}

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
export async function gs_TopicTaskStatus_func(strInFldName:string , strOutFldName:string ,  strInValue: string) 
{
//const strThisFuncName = "func";

if (strInFldName != clsgs_TopicTaskStatusEN.con_StatusId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsgs_TopicTaskStatusEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clsgs_TopicTaskStatusEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strStatusId = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objgs_TopicTaskStatus = await gs_TopicTaskStatus_GetObjByStatusId_Cache(strStatusId );
if (objgs_TopicTaskStatus == null) return "";
return objgs_TopicTaskStatus.GetFldValue(strOutFldName).toString();
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
export function gs_TopicTaskStatus_SortFun_Defa(a:clsgs_TopicTaskStatusEN , b:clsgs_TopicTaskStatusEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.statusId.localeCompare(b.statusId);
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
export function gs_TopicTaskStatus_SortFun_Defa_2Fld(a:clsgs_TopicTaskStatusEN , b:clsgs_TopicTaskStatusEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.statusName == b.statusName) return a.updUser.localeCompare(b.updUser);
else return a.statusName.localeCompare(b.statusName);
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
export function gs_TopicTaskStatus_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsgs_TopicTaskStatusEN.con_StatusId:
return (a: clsgs_TopicTaskStatusEN, b: clsgs_TopicTaskStatusEN) => {
return a.statusId.localeCompare(b.statusId);
}
case clsgs_TopicTaskStatusEN.con_StatusName:
return (a: clsgs_TopicTaskStatusEN, b: clsgs_TopicTaskStatusEN) => {
return a.statusName.localeCompare(b.statusName);
}
case clsgs_TopicTaskStatusEN.con_UpdUser:
return (a: clsgs_TopicTaskStatusEN, b: clsgs_TopicTaskStatusEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsgs_TopicTaskStatusEN.con_UpdDate:
return (a: clsgs_TopicTaskStatusEN, b: clsgs_TopicTaskStatusEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsgs_TopicTaskStatusEN.con_Memo:
return (a: clsgs_TopicTaskStatusEN, b: clsgs_TopicTaskStatusEN) => {
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_TopicTaskStatus]中不存在！(in ${ gs_TopicTaskStatus_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsgs_TopicTaskStatusEN.con_StatusId:
return (a: clsgs_TopicTaskStatusEN, b: clsgs_TopicTaskStatusEN) => {
return b.statusId.localeCompare(a.statusId);
}
case clsgs_TopicTaskStatusEN.con_StatusName:
return (a: clsgs_TopicTaskStatusEN, b: clsgs_TopicTaskStatusEN) => {
return b.statusName.localeCompare(a.statusName);
}
case clsgs_TopicTaskStatusEN.con_UpdUser:
return (a: clsgs_TopicTaskStatusEN, b: clsgs_TopicTaskStatusEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsgs_TopicTaskStatusEN.con_UpdDate:
return (a: clsgs_TopicTaskStatusEN, b: clsgs_TopicTaskStatusEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsgs_TopicTaskStatusEN.con_Memo:
return (a: clsgs_TopicTaskStatusEN, b: clsgs_TopicTaskStatusEN) => {
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_TopicTaskStatus]中不存在！(in ${ gs_TopicTaskStatus_ConstructorName}.${ strThisFuncName})`;
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
export async function gs_TopicTaskStatus_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsgs_TopicTaskStatusEN.con_StatusId:
return (obj: clsgs_TopicTaskStatusEN) => {
return obj.statusId === value;
}
case clsgs_TopicTaskStatusEN.con_StatusName:
return (obj: clsgs_TopicTaskStatusEN) => {
return obj.statusName === value;
}
case clsgs_TopicTaskStatusEN.con_UpdUser:
return (obj: clsgs_TopicTaskStatusEN) => {
return obj.updUser === value;
}
case clsgs_TopicTaskStatusEN.con_UpdDate:
return (obj: clsgs_TopicTaskStatusEN) => {
return obj.updDate === value;
}
case clsgs_TopicTaskStatusEN.con_Memo:
return (obj: clsgs_TopicTaskStatusEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_TopicTaskStatus]中不存在！(in ${ gs_TopicTaskStatus_ConstructorName}.${ strThisFuncName})`;
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
export async function gs_TopicTaskStatus_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(gs_TopicTaskStatus_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TopicTaskStatus_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TopicTaskStatus_ConstructorName, strThisFuncName);
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
export async function gs_TopicTaskStatus_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(gs_TopicTaskStatus_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TopicTaskStatus_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TopicTaskStatus_ConstructorName, strThisFuncName);
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
export async function gs_TopicTaskStatus_GetFirstObjAsync(strWhereCond: string): Promise<clsgs_TopicTaskStatusEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(gs_TopicTaskStatus_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_TopicTaskStatus_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objgs_TopicTaskStatus = gs_TopicTaskStatus_GetObjFromJsonObj(returnObj);
return objgs_TopicTaskStatus;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TopicTaskStatus_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TopicTaskStatus_ConstructorName, strThisFuncName);
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
export async function gs_TopicTaskStatus_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsgs_TopicTaskStatusEN._CurrTabName;
clsgs_TopicTaskStatusEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsgs_TopicTaskStatusEN._CurrTabName);
if (IsNullOrEmpty(clsgs_TopicTaskStatusEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsgs_TopicTaskStatusEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrgs_TopicTaskStatusExObjLst_Cache: Array<clsgs_TopicTaskStatusEN> = CacheHelper.Get(strKey);
const arrgs_TopicTaskStatusObjLst_T = gs_TopicTaskStatus_GetObjLstByJSONObjLst(arrgs_TopicTaskStatusExObjLst_Cache);
return arrgs_TopicTaskStatusObjLst_T;
}
try
{
const arrgs_TopicTaskStatusExObjLst = await gs_TopicTaskStatus_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrgs_TopicTaskStatusExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_TopicTaskStatusExObjLst.length);
console.log(strInfo);
return arrgs_TopicTaskStatusExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, gs_TopicTaskStatus_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_TopicTaskStatus_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsgs_TopicTaskStatusEN._CurrTabName;
clsgs_TopicTaskStatusEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsgs_TopicTaskStatusEN._CurrTabName);
if (IsNullOrEmpty(clsgs_TopicTaskStatusEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsgs_TopicTaskStatusEN.CacheAddiCondition);
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
const arrgs_TopicTaskStatusExObjLst_Cache: Array<clsgs_TopicTaskStatusEN> = JSON.parse(strTempObjLst);
const arrgs_TopicTaskStatusObjLst_T = gs_TopicTaskStatus_GetObjLstByJSONObjLst(arrgs_TopicTaskStatusExObjLst_Cache);
return arrgs_TopicTaskStatusObjLst_T;
}
try
{
const arrgs_TopicTaskStatusExObjLst = await gs_TopicTaskStatus_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrgs_TopicTaskStatusExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_TopicTaskStatusExObjLst.length);
console.log(strInfo);
return arrgs_TopicTaskStatusExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, gs_TopicTaskStatus_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_TopicTaskStatus_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsgs_TopicTaskStatusEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrgs_TopicTaskStatusObjLst_Cache: Array<clsgs_TopicTaskStatusEN> = JSON.parse(strTempObjLst);
return arrgs_TopicTaskStatusObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function gs_TopicTaskStatus_GetObjLstAsync(strWhereCond: string): Promise<Array<clsgs_TopicTaskStatusEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(gs_TopicTaskStatus_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_TopicTaskStatus_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_TopicTaskStatus_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TopicTaskStatus_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TopicTaskStatus_ConstructorName, strThisFuncName);
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
export async function gs_TopicTaskStatus_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsgs_TopicTaskStatusEN._CurrTabName;
clsgs_TopicTaskStatusEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsgs_TopicTaskStatusEN._CurrTabName);
if (IsNullOrEmpty(clsgs_TopicTaskStatusEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsgs_TopicTaskStatusEN.CacheAddiCondition);
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
const arrgs_TopicTaskStatusExObjLst_Cache: Array<clsgs_TopicTaskStatusEN> = JSON.parse(strTempObjLst);
const arrgs_TopicTaskStatusObjLst_T = gs_TopicTaskStatus_GetObjLstByJSONObjLst(arrgs_TopicTaskStatusExObjLst_Cache);
return arrgs_TopicTaskStatusObjLst_T;
}
try
{
const arrgs_TopicTaskStatusExObjLst = await gs_TopicTaskStatus_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrgs_TopicTaskStatusExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_TopicTaskStatusExObjLst.length);
console.log(strInfo);
return arrgs_TopicTaskStatusExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, gs_TopicTaskStatus_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_TopicTaskStatus_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsgs_TopicTaskStatusEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrgs_TopicTaskStatusObjLst_Cache: Array<clsgs_TopicTaskStatusEN> = JSON.parse(strTempObjLst);
return arrgs_TopicTaskStatusObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_TopicTaskStatus_GetObjLst_Cache(): Promise<Array<clsgs_TopicTaskStatusEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrgs_TopicTaskStatusObjLst_Cache;
switch (clsgs_TopicTaskStatusEN.CacheModeId)
{
case "04"://sessionStorage
arrgs_TopicTaskStatusObjLst_Cache = await gs_TopicTaskStatus_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrgs_TopicTaskStatusObjLst_Cache = await gs_TopicTaskStatus_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrgs_TopicTaskStatusObjLst_Cache = await gs_TopicTaskStatus_GetObjLst_ClientCache();
break;
default:
arrgs_TopicTaskStatusObjLst_Cache = await gs_TopicTaskStatus_GetObjLst_ClientCache();
break;
}
const arrgs_TopicTaskStatusObjLst = gs_TopicTaskStatus_GetObjLstByJSONObjLst(arrgs_TopicTaskStatusObjLst_Cache);
return arrgs_TopicTaskStatusObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_TopicTaskStatus_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrgs_TopicTaskStatusObjLst_Cache;
switch (clsgs_TopicTaskStatusEN.CacheModeId)
{
case "04"://sessionStorage
arrgs_TopicTaskStatusObjLst_Cache = await gs_TopicTaskStatus_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrgs_TopicTaskStatusObjLst_Cache = await gs_TopicTaskStatus_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrgs_TopicTaskStatusObjLst_Cache = null;
break;
default:
arrgs_TopicTaskStatusObjLst_Cache = null;
break;
}
return arrgs_TopicTaskStatusObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrStatusId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function gs_TopicTaskStatus_GetSubObjLst_Cache(objgs_TopicTaskStatus_Cond: clsgs_TopicTaskStatusEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrgs_TopicTaskStatusObjLst_Cache = await gs_TopicTaskStatus_GetObjLst_Cache();
let arrgs_TopicTaskStatus_Sel: Array < clsgs_TopicTaskStatusEN > = arrgs_TopicTaskStatusObjLst_Cache;
if (objgs_TopicTaskStatus_Cond.sf_FldComparisonOp == null || objgs_TopicTaskStatus_Cond.sf_FldComparisonOp == "") return arrgs_TopicTaskStatus_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_TopicTaskStatus_Cond.sf_FldComparisonOp);
//console.log("clsgs_TopicTaskStatusWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objgs_TopicTaskStatus_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_TopicTaskStatus_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrgs_TopicTaskStatus_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objgs_TopicTaskStatus_Cond), gs_TopicTaskStatus_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsgs_TopicTaskStatusEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrStatusId:关键字列表
 * @returns 对象列表
 **/
export async function gs_TopicTaskStatus_GetObjLstByStatusIdLstAsync(arrStatusId: Array<string>): Promise<Array<clsgs_TopicTaskStatusEN>>  
{
const strThisFuncName = "GetObjLstByStatusIdLstAsync";
const strAction = "GetObjLstByStatusIdLst";
const strUrl = GetWebApiUrl(gs_TopicTaskStatus_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrStatusId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_TopicTaskStatus_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_TopicTaskStatus_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TopicTaskStatus_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TopicTaskStatus_ConstructorName, strThisFuncName);
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
 * @param arrstrStatusIdLst:关键字列表
 * @returns 对象列表
*/
export async function gs_TopicTaskStatus_GetObjLstByStatusIdLst_Cache(arrStatusIdLst: Array<string>) {
const strThisFuncName = "GetObjLstByStatusIdLst_Cache";
try
{
const arrgs_TopicTaskStatusObjLst_Cache = await gs_TopicTaskStatus_GetObjLst_Cache();
const arrgs_TopicTaskStatus_Sel: Array <clsgs_TopicTaskStatusEN> = arrgs_TopicTaskStatusObjLst_Cache.filter(x => arrStatusIdLst.indexOf(x.statusId)>-1);
return arrgs_TopicTaskStatus_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrStatusIdLst.join(","), gs_TopicTaskStatus_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsgs_TopicTaskStatusEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function gs_TopicTaskStatus_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsgs_TopicTaskStatusEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(gs_TopicTaskStatus_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_TopicTaskStatus_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_TopicTaskStatus_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TopicTaskStatus_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TopicTaskStatus_ConstructorName, strThisFuncName);
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
export async function gs_TopicTaskStatus_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsgs_TopicTaskStatusEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(gs_TopicTaskStatus_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_TopicTaskStatus_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_TopicTaskStatus_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TopicTaskStatus_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TopicTaskStatus_ConstructorName, strThisFuncName);
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
export async function gs_TopicTaskStatus_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(gs_TopicTaskStatus_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TopicTaskStatus_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TopicTaskStatus_ConstructorName, strThisFuncName);
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
export async function gs_TopicTaskStatus_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrgs_TopicTaskStatusObjLst_Cache = await gs_TopicTaskStatus_GetObjLst_Cache();
if (arrgs_TopicTaskStatusObjLst_Cache.length == 0) return arrgs_TopicTaskStatusObjLst_Cache;
let arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatusObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objgs_TopicTaskStatus_Cond = new clsgs_TopicTaskStatusEN();
ObjectAssign(objgs_TopicTaskStatus_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsgs_TopicTaskStatusWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_TopicTaskStatus_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrgs_TopicTaskStatus_Sel.length == 0) return arrgs_TopicTaskStatus_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.sort(gs_TopicTaskStatus_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.sort(objPagerPara.sortFun);
}
arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.slice(intStart, intEnd);     
return arrgs_TopicTaskStatus_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, gs_TopicTaskStatus_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsgs_TopicTaskStatusEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function gs_TopicTaskStatus_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsgs_TopicTaskStatusEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(gs_TopicTaskStatus_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_TopicTaskStatus_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_TopicTaskStatus_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TopicTaskStatus_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TopicTaskStatus_ConstructorName, strThisFuncName);
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
 * @param strStatusId:关键字
 * @returns 获取删除的结果
 **/
export async function gs_TopicTaskStatus_DelRecordAsync(strStatusId: string): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(gs_TopicTaskStatus_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, strStatusId);
try
{
const response = await axios.delete(strUrl,
{
params: { "Id": strStatusId, }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TopicTaskStatus_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TopicTaskStatus_ConstructorName, strThisFuncName);
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
 * @param arrStatusId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function gs_TopicTaskStatus_Delgs_TopicTaskStatussAsync(arrStatusId: Array<string>): Promise<number> 
{
const strThisFuncName = "Delgs_TopicTaskStatussAsync";
const strAction = "Delgs_TopicTaskStatuss";
const strUrl = GetWebApiUrl(gs_TopicTaskStatus_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrStatusId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TopicTaskStatus_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TopicTaskStatus_ConstructorName, strThisFuncName);
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
export async function gs_TopicTaskStatus_Delgs_TopicTaskStatussByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "Delgs_TopicTaskStatussByCondAsync";
const strAction = "Delgs_TopicTaskStatussByCond";
const strUrl = GetWebApiUrl(gs_TopicTaskStatus_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TopicTaskStatus_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TopicTaskStatus_ConstructorName, strThisFuncName);
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
 * @param objgs_TopicTaskStatusEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_TopicTaskStatus_AddNewRecordAsync(objgs_TopicTaskStatusEN: clsgs_TopicTaskStatusEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
if (objgs_TopicTaskStatusEN.statusId === null || objgs_TopicTaskStatusEN.statusId === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objgs_TopicTaskStatusEN);
const strUrl = GetWebApiUrl(gs_TopicTaskStatus_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_TopicTaskStatusEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TopicTaskStatus_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TopicTaskStatus_ConstructorName, strThisFuncName);
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
 * @param objgs_TopicTaskStatusEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_TopicTaskStatus_AddNewRecordWithMaxIdAsync(objgs_TopicTaskStatusEN: clsgs_TopicTaskStatusEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithMaxIdAsync";
const strAction = "AddNewRecordWithMaxId";
const strUrl = GetWebApiUrl(gs_TopicTaskStatus_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_TopicTaskStatusEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TopicTaskStatus_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TopicTaskStatus_ConstructorName, strThisFuncName);
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
 * @param objgs_TopicTaskStatusEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function gs_TopicTaskStatus_AddNewRecordWithReturnKeyAsync(objgs_TopicTaskStatusEN: clsgs_TopicTaskStatusEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(gs_TopicTaskStatus_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_TopicTaskStatusEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TopicTaskStatus_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TopicTaskStatus_ConstructorName, strThisFuncName);
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
 * @param objgs_TopicTaskStatusEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function gs_TopicTaskStatus_AddNewRecordWithReturnKey(objgs_TopicTaskStatusEN: clsgs_TopicTaskStatusEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objgs_TopicTaskStatusEN.statusId === null || objgs_TopicTaskStatusEN.statusId === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(gs_TopicTaskStatus_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_TopicTaskStatusEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TopicTaskStatus_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TopicTaskStatus_ConstructorName, strThisFuncName);
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
 * @param objgs_TopicTaskStatusEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function gs_TopicTaskStatus_UpdateRecordAsync(objgs_TopicTaskStatusEN: clsgs_TopicTaskStatusEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objgs_TopicTaskStatusEN.sf_UpdFldSetStr === undefined || objgs_TopicTaskStatusEN.sf_UpdFldSetStr === null || objgs_TopicTaskStatusEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_TopicTaskStatusEN.statusId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(gs_TopicTaskStatus_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_TopicTaskStatusEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TopicTaskStatus_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TopicTaskStatus_ConstructorName, strThisFuncName);
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
 * @param objgs_TopicTaskStatusEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function gs_TopicTaskStatus_UpdateWithConditionAsync(objgs_TopicTaskStatusEN: clsgs_TopicTaskStatusEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objgs_TopicTaskStatusEN.sf_UpdFldSetStr === undefined || objgs_TopicTaskStatusEN.sf_UpdFldSetStr === null || objgs_TopicTaskStatusEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_TopicTaskStatusEN.statusId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(gs_TopicTaskStatus_Controller, strAction);
objgs_TopicTaskStatusEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objgs_TopicTaskStatusEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TopicTaskStatus_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TopicTaskStatus_ConstructorName, strThisFuncName);
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
 * @param objstrStatusId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function gs_TopicTaskStatus_IsExistRecord_Cache(objgs_TopicTaskStatus_Cond: clsgs_TopicTaskStatusEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrgs_TopicTaskStatusObjLst_Cache = await gs_TopicTaskStatus_GetObjLst_Cache();
if (arrgs_TopicTaskStatusObjLst_Cache == null) return false;
let arrgs_TopicTaskStatus_Sel: Array < clsgs_TopicTaskStatusEN > = arrgs_TopicTaskStatusObjLst_Cache;
if (objgs_TopicTaskStatus_Cond.sf_FldComparisonOp == null || objgs_TopicTaskStatus_Cond.sf_FldComparisonOp == "") return arrgs_TopicTaskStatus_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_TopicTaskStatus_Cond.sf_FldComparisonOp);
//console.log("clsgs_TopicTaskStatusWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objgs_TopicTaskStatus_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_TopicTaskStatus_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrgs_TopicTaskStatus_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objgs_TopicTaskStatus_Cond), gs_TopicTaskStatus_ConstructorName, strThisFuncName);
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
export async function gs_TopicTaskStatus_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(gs_TopicTaskStatus_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TopicTaskStatus_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TopicTaskStatus_ConstructorName, strThisFuncName);
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
 * @param strStatusId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function gs_TopicTaskStatus_IsExist(strStatusId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(gs_TopicTaskStatus_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"StatusId": strStatusId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TopicTaskStatus_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TopicTaskStatus_ConstructorName, strThisFuncName);
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
 * @param strStatusId:所给的关键字
 * @returns 对象
*/
export async function gs_TopicTaskStatus_IsExist_Cache(strStatusId:string) {
const strThisFuncName = "IsExist_Cache";
const arrgs_TopicTaskStatusObjLst_Cache = await gs_TopicTaskStatus_GetObjLst_Cache();
if (arrgs_TopicTaskStatusObjLst_Cache == null) return false;
try
{
const arrgs_TopicTaskStatus_Sel: Array <clsgs_TopicTaskStatusEN> = arrgs_TopicTaskStatusObjLst_Cache.filter(x => x.statusId == strStatusId);
if (arrgs_TopicTaskStatus_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strStatusId, gs_TopicTaskStatus_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param strStatusId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function gs_TopicTaskStatus_IsExistAsync(strStatusId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(gs_TopicTaskStatus_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strStatusId": strStatusId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TopicTaskStatus_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TopicTaskStatus_ConstructorName, strThisFuncName);
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
export async function gs_TopicTaskStatus_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(gs_TopicTaskStatus_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TopicTaskStatus_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TopicTaskStatus_ConstructorName, strThisFuncName);
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
 * @param objgs_TopicTaskStatus_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function gs_TopicTaskStatus_GetRecCountByCond_Cache(objgs_TopicTaskStatus_Cond: clsgs_TopicTaskStatusEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrgs_TopicTaskStatusObjLst_Cache = await gs_TopicTaskStatus_GetObjLst_Cache();
if (arrgs_TopicTaskStatusObjLst_Cache == null) return 0;
let arrgs_TopicTaskStatus_Sel: Array < clsgs_TopicTaskStatusEN > = arrgs_TopicTaskStatusObjLst_Cache;
if (objgs_TopicTaskStatus_Cond.sf_FldComparisonOp == null || objgs_TopicTaskStatus_Cond.sf_FldComparisonOp == "") return arrgs_TopicTaskStatus_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_TopicTaskStatus_Cond.sf_FldComparisonOp);
//console.log("clsgs_TopicTaskStatusWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objgs_TopicTaskStatus_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_TopicTaskStatus_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrgs_TopicTaskStatus_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objgs_TopicTaskStatus_Cond), gs_TopicTaskStatus_ConstructorName, strThisFuncName);
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
export async function gs_TopicTaskStatus_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(gs_TopicTaskStatus_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TopicTaskStatus_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TopicTaskStatus_ConstructorName, strThisFuncName);
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
export function gs_TopicTaskStatus_GetWebApiUrl(strController: string, strAction: string): string {
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
export function gs_TopicTaskStatus_ReFreshCache():void
{
const strThisFuncName = "ReFreshCache";

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = clsgs_TopicTaskStatusEN._CurrTabName;
switch (clsgs_TopicTaskStatusEN.CacheModeId)
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
export function gs_TopicTaskStatus_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clsgs_TopicTaskStatusEN._CurrTabName;
switch (clsgs_TopicTaskStatusEN.CacheModeId)
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

/**
 * 绑定基于Web的下拉框,在某一层下的下拉框
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
 * @param objDDL:需要绑定当前表的下拉框
*/
export async function gs_TopicTaskStatus_BindDdl_StatusIdInDiv_Cache(strDivName: string, strDdlName: string )
{
const strThisFuncName = "BindDdl_StatusIdInDiv_Cache";

const objDdl = document.getElementById(strDdlName);
if (objDdl == null)
{
const strMsg = Format("下拉框：{0} 不存在！(In BindDdl_StatusIdInDiv)", strDdlName);
alert(strMsg);
console.error(strMsg);
throw (strMsg);
}
//为数据源于表的下拉框设置内容
//console.log("开始：BindDdl_StatusIdInDiv_Cache");
const arrObjLst_Sel = await gs_TopicTaskStatus_GetObjLst_Cache();
if (arrObjLst_Sel == null) return;
BindDdl_ObjLstInDiv(strDivName, strDdlName, arrObjLst_Sel, clsgs_TopicTaskStatusEN.con_StatusId, clsgs_TopicTaskStatusEN.con_StatusName, "主题任务状态");
}

/**
 * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function gs_TopicTaskStatus_CheckPropertyNew(pobjgs_TopicTaskStatusEN: clsgs_TopicTaskStatusEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjgs_TopicTaskStatusEN.statusId) == false && GetStrLen(pobjgs_TopicTaskStatusEN.statusId) > 2)
{
 throw new Error("(errid:Watl000059)字段[状态Id(statusId)]的长度不能超过2(In 主题任务状态(gs_TopicTaskStatus))!值:$(pobjgs_TopicTaskStatusEN.statusId)(clsgs_TopicTaskStatusBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TopicTaskStatusEN.statusName) == false && GetStrLen(pobjgs_TopicTaskStatusEN.statusName) > 100)
{
 throw new Error("(errid:Watl000059)字段[状态名称(statusName)]的长度不能超过100(In 主题任务状态(gs_TopicTaskStatus))!值:$(pobjgs_TopicTaskStatusEN.statusName)(clsgs_TopicTaskStatusBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TopicTaskStatusEN.updUser) == false && GetStrLen(pobjgs_TopicTaskStatusEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 主题任务状态(gs_TopicTaskStatus))!值:$(pobjgs_TopicTaskStatusEN.updUser)(clsgs_TopicTaskStatusBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TopicTaskStatusEN.updDate) == false && GetStrLen(pobjgs_TopicTaskStatusEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 主题任务状态(gs_TopicTaskStatus))!值:$(pobjgs_TopicTaskStatusEN.updDate)(clsgs_TopicTaskStatusBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TopicTaskStatusEN.memo) == false && GetStrLen(pobjgs_TopicTaskStatusEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 主题任务状态(gs_TopicTaskStatus))!值:$(pobjgs_TopicTaskStatusEN.memo)(clsgs_TopicTaskStatusBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjgs_TopicTaskStatusEN.statusId) == false && undefined !== pobjgs_TopicTaskStatusEN.statusId && tzDataType.isString(pobjgs_TopicTaskStatusEN.statusId) === false)
{
 throw new Error("(errid:Watl000060)字段[状态Id(statusId)]的值:[$(pobjgs_TopicTaskStatusEN.statusId)], 非法，应该为字符型(In 主题任务状态(gs_TopicTaskStatus))!(clsgs_TopicTaskStatusBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TopicTaskStatusEN.statusName) == false && undefined !== pobjgs_TopicTaskStatusEN.statusName && tzDataType.isString(pobjgs_TopicTaskStatusEN.statusName) === false)
{
 throw new Error("(errid:Watl000060)字段[状态名称(statusName)]的值:[$(pobjgs_TopicTaskStatusEN.statusName)], 非法，应该为字符型(In 主题任务状态(gs_TopicTaskStatus))!(clsgs_TopicTaskStatusBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TopicTaskStatusEN.updUser) == false && undefined !== pobjgs_TopicTaskStatusEN.updUser && tzDataType.isString(pobjgs_TopicTaskStatusEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjgs_TopicTaskStatusEN.updUser)], 非法，应该为字符型(In 主题任务状态(gs_TopicTaskStatus))!(clsgs_TopicTaskStatusBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TopicTaskStatusEN.updDate) == false && undefined !== pobjgs_TopicTaskStatusEN.updDate && tzDataType.isString(pobjgs_TopicTaskStatusEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjgs_TopicTaskStatusEN.updDate)], 非法，应该为字符型(In 主题任务状态(gs_TopicTaskStatus))!(clsgs_TopicTaskStatusBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TopicTaskStatusEN.memo) == false && undefined !== pobjgs_TopicTaskStatusEN.memo && tzDataType.isString(pobjgs_TopicTaskStatusEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjgs_TopicTaskStatusEN.memo)], 非法，应该为字符型(In 主题任务状态(gs_TopicTaskStatus))!(clsgs_TopicTaskStatusBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjgs_TopicTaskStatusEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function gs_TopicTaskStatus_CheckProperty4Update (pobjgs_TopicTaskStatusEN: clsgs_TopicTaskStatusEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjgs_TopicTaskStatusEN.statusId) == false && GetStrLen(pobjgs_TopicTaskStatusEN.statusId) > 2)
{
 throw new Error("(errid:Watl000062)字段[状态Id(statusId)]的长度不能超过2(In 主题任务状态(gs_TopicTaskStatus))!值:$(pobjgs_TopicTaskStatusEN.statusId)(clsgs_TopicTaskStatusBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TopicTaskStatusEN.statusName) == false && GetStrLen(pobjgs_TopicTaskStatusEN.statusName) > 100)
{
 throw new Error("(errid:Watl000062)字段[状态名称(statusName)]的长度不能超过100(In 主题任务状态(gs_TopicTaskStatus))!值:$(pobjgs_TopicTaskStatusEN.statusName)(clsgs_TopicTaskStatusBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TopicTaskStatusEN.updUser) == false && GetStrLen(pobjgs_TopicTaskStatusEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 主题任务状态(gs_TopicTaskStatus))!值:$(pobjgs_TopicTaskStatusEN.updUser)(clsgs_TopicTaskStatusBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TopicTaskStatusEN.updDate) == false && GetStrLen(pobjgs_TopicTaskStatusEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 主题任务状态(gs_TopicTaskStatus))!值:$(pobjgs_TopicTaskStatusEN.updDate)(clsgs_TopicTaskStatusBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TopicTaskStatusEN.memo) == false && GetStrLen(pobjgs_TopicTaskStatusEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 主题任务状态(gs_TopicTaskStatus))!值:$(pobjgs_TopicTaskStatusEN.memo)(clsgs_TopicTaskStatusBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjgs_TopicTaskStatusEN.statusId) == false && undefined !== pobjgs_TopicTaskStatusEN.statusId && tzDataType.isString(pobjgs_TopicTaskStatusEN.statusId) === false)
{
 throw new Error("(errid:Watl000063)字段[状态Id(statusId)]的值:[$(pobjgs_TopicTaskStatusEN.statusId)], 非法，应该为字符型(In 主题任务状态(gs_TopicTaskStatus))!(clsgs_TopicTaskStatusBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TopicTaskStatusEN.statusName) == false && undefined !== pobjgs_TopicTaskStatusEN.statusName && tzDataType.isString(pobjgs_TopicTaskStatusEN.statusName) === false)
{
 throw new Error("(errid:Watl000063)字段[状态名称(statusName)]的值:[$(pobjgs_TopicTaskStatusEN.statusName)], 非法，应该为字符型(In 主题任务状态(gs_TopicTaskStatus))!(clsgs_TopicTaskStatusBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TopicTaskStatusEN.updUser) == false && undefined !== pobjgs_TopicTaskStatusEN.updUser && tzDataType.isString(pobjgs_TopicTaskStatusEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjgs_TopicTaskStatusEN.updUser)], 非法，应该为字符型(In 主题任务状态(gs_TopicTaskStatus))!(clsgs_TopicTaskStatusBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TopicTaskStatusEN.updDate) == false && undefined !== pobjgs_TopicTaskStatusEN.updDate && tzDataType.isString(pobjgs_TopicTaskStatusEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjgs_TopicTaskStatusEN.updDate)], 非法，应该为字符型(In 主题任务状态(gs_TopicTaskStatus))!(clsgs_TopicTaskStatusBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TopicTaskStatusEN.memo) == false && undefined !== pobjgs_TopicTaskStatusEN.memo && tzDataType.isString(pobjgs_TopicTaskStatusEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjgs_TopicTaskStatusEN.memo)], 非法，应该为字符型(In 主题任务状态(gs_TopicTaskStatus))!(clsgs_TopicTaskStatusBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (IsNullOrEmpty(pobjgs_TopicTaskStatusEN.statusId) === true )
{
 throw new Error("(errid:Watl000064)字段[状态Id]不能为空(In 主题任务状态)!(clsgs_TopicTaskStatusBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjgs_TopicTaskStatusEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function gs_TopicTaskStatus_GetJSONStrByObj (pobjgs_TopicTaskStatusEN: clsgs_TopicTaskStatusEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjgs_TopicTaskStatusEN.sf_UpdFldSetStr = pobjgs_TopicTaskStatusEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjgs_TopicTaskStatusEN);
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
export function gs_TopicTaskStatus_GetObjLstByJSONStr (strJSON: string): Array<clsgs_TopicTaskStatusEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrgs_TopicTaskStatusObjLst = new Array<clsgs_TopicTaskStatusEN>();
if (strJSON === "")
{
return arrgs_TopicTaskStatusObjLst;
}
try
{
arrgs_TopicTaskStatusObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrgs_TopicTaskStatusObjLst;
}
return arrgs_TopicTaskStatusObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrgs_TopicTaskStatusObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function gs_TopicTaskStatus_GetObjLstByJSONObjLst (arrgs_TopicTaskStatusObjLstS: Array<clsgs_TopicTaskStatusEN>): Array<clsgs_TopicTaskStatusEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrgs_TopicTaskStatusObjLst = new Array<clsgs_TopicTaskStatusEN>();
for (const objInFor of arrgs_TopicTaskStatusObjLstS) {
const obj1 = gs_TopicTaskStatus_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrgs_TopicTaskStatusObjLst.push(obj1);
}
return arrgs_TopicTaskStatusObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function gs_TopicTaskStatus_GetObjByJSONStr (strJSON: string): clsgs_TopicTaskStatusEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjgs_TopicTaskStatusEN = new clsgs_TopicTaskStatusEN();
if (strJSON === "")
{
return pobjgs_TopicTaskStatusEN;
}
try
{
pobjgs_TopicTaskStatusEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjgs_TopicTaskStatusEN;
}
return pobjgs_TopicTaskStatusEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function gs_TopicTaskStatus_GetCombineCondition(objgs_TopicTaskStatus_Cond: clsgs_TopicTaskStatusEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objgs_TopicTaskStatus_Cond.dicFldComparisonOp, clsgs_TopicTaskStatusEN.con_StatusId) == true)
{
const strComparisonOp_StatusId:string = objgs_TopicTaskStatus_Cond.dicFldComparisonOp[clsgs_TopicTaskStatusEN.con_StatusId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TopicTaskStatusEN.con_StatusId, objgs_TopicTaskStatus_Cond.statusId, strComparisonOp_StatusId);
}
if (Object.prototype.hasOwnProperty.call(objgs_TopicTaskStatus_Cond.dicFldComparisonOp, clsgs_TopicTaskStatusEN.con_StatusName) == true)
{
const strComparisonOp_StatusName:string = objgs_TopicTaskStatus_Cond.dicFldComparisonOp[clsgs_TopicTaskStatusEN.con_StatusName];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TopicTaskStatusEN.con_StatusName, objgs_TopicTaskStatus_Cond.statusName, strComparisonOp_StatusName);
}
if (Object.prototype.hasOwnProperty.call(objgs_TopicTaskStatus_Cond.dicFldComparisonOp, clsgs_TopicTaskStatusEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objgs_TopicTaskStatus_Cond.dicFldComparisonOp[clsgs_TopicTaskStatusEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TopicTaskStatusEN.con_UpdUser, objgs_TopicTaskStatus_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objgs_TopicTaskStatus_Cond.dicFldComparisonOp, clsgs_TopicTaskStatusEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objgs_TopicTaskStatus_Cond.dicFldComparisonOp[clsgs_TopicTaskStatusEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TopicTaskStatusEN.con_UpdDate, objgs_TopicTaskStatus_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objgs_TopicTaskStatus_Cond.dicFldComparisonOp, clsgs_TopicTaskStatusEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objgs_TopicTaskStatus_Cond.dicFldComparisonOp[clsgs_TopicTaskStatusEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TopicTaskStatusEN.con_Memo, objgs_TopicTaskStatus_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objgs_TopicTaskStatusENS:源对象
 * @param objgs_TopicTaskStatusENT:目标对象
*/
export function gs_TopicTaskStatus_CopyObjTo(objgs_TopicTaskStatusENS: clsgs_TopicTaskStatusEN , objgs_TopicTaskStatusENT: clsgs_TopicTaskStatusEN ): void 
{
objgs_TopicTaskStatusENT.statusId = objgs_TopicTaskStatusENS.statusId; //状态Id
objgs_TopicTaskStatusENT.statusName = objgs_TopicTaskStatusENS.statusName; //状态名称
objgs_TopicTaskStatusENT.updUser = objgs_TopicTaskStatusENS.updUser; //修改人
objgs_TopicTaskStatusENT.updDate = objgs_TopicTaskStatusENS.updDate; //修改日期
objgs_TopicTaskStatusENT.memo = objgs_TopicTaskStatusENS.memo; //备注
objgs_TopicTaskStatusENT.sf_UpdFldSetStr = objgs_TopicTaskStatusENS.updFldString; //sf_UpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objgs_TopicTaskStatusENS:源对象
 * @param objgs_TopicTaskStatusENT:目标对象
*/
export function gs_TopicTaskStatus_GetObjFromJsonObj(objgs_TopicTaskStatusENS: clsgs_TopicTaskStatusEN): clsgs_TopicTaskStatusEN 
{
 const objgs_TopicTaskStatusENT: clsgs_TopicTaskStatusEN = new clsgs_TopicTaskStatusEN();
ObjectAssign(objgs_TopicTaskStatusENT, objgs_TopicTaskStatusENS);
 return objgs_TopicTaskStatusENT;
}