
 /**
 * 类名:clsgs_ReflectLogWApi
 * 表名:gs_ReflectLog(01120702)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:55:31
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
 * 反思日志(gs_ReflectLog)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2023年03月13日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { enumComparisonOp } from "../../PubFun/enumComparisonOp.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { clsgs_ReflectLogEN } from "../../L0_Entity/GraduateEduTopic/clsgs_ReflectLogEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { tzDataType } from "../../PubFun/clsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const gs_ReflectLog_Controller = "gs_ReflectLogApi";
 export const gs_ReflectLog_ConstructorName = "gs_ReflectLog";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngmId:关键字
 * @returns 对象
 **/
export async function gs_ReflectLog_GetObjBymIdAsync(lngmId: number): Promise<clsgs_ReflectLogEN|null>  
{
const strThisFuncName = "GetObjBymIdAsync";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In clsgs_ReflectLogWApi.GetObjBymIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjBymId";
const strUrl = GetWebApiUrl(gs_ReflectLog_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"lngmId": lngmId,
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
const objgs_ReflectLog = gs_ReflectLog_GetObjFromJsonObj(returnObj);
return objgs_ReflectLog;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ReflectLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ReflectLog_ConstructorName, strThisFuncName);
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
 * @param lngmId:所给的关键字
 * @returns 对象
*/
export async function gs_ReflectLog_GetObjBymId_Cache(lngmId: number, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjBymId_Cache";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In clsgs_ReflectLogWApi.GetObjBymId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
const arrgs_ReflectLogObjLst_Cache = await gs_ReflectLog_GetObjLst_Cache();
try
{
const arrgs_ReflectLog_Sel: Array <clsgs_ReflectLogEN> = arrgs_ReflectLogObjLst_Cache.filter(x => 
 x.mId == lngmId );
let objgs_ReflectLog: clsgs_ReflectLogEN;
if (arrgs_ReflectLog_Sel.length > 0)
{
objgs_ReflectLog = arrgs_ReflectLog_Sel[0];
return objgs_ReflectLog;
}
else
{
if (bolTryAsyncOnce == true)
{
const objgs_ReflectLog_Const = await gs_ReflectLog_GetObjBymIdAsync(lngmId);
if (objgs_ReflectLog_Const != null)
{
gs_ReflectLog_ReFreshThisCache();
return objgs_ReflectLog_Const;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, gs_ReflectLog_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param lngmId:所给的关键字
 * @returns 对象
*/
export async function gs_ReflectLog_GetObjBymId_localStorage(lngmId: number) {
const strThisFuncName = "GetObjBymId_localStorage";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In clsgs_ReflectLogWApi.GetObjBymId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
const strKey = Format("{0}_{1}", clsgs_ReflectLogEN._CurrTabName, lngmId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objgs_ReflectLog_Cache: clsgs_ReflectLogEN = JSON.parse(strTempObj);
return objgs_ReflectLog_Cache;
}
try
{
const objgs_ReflectLog = await gs_ReflectLog_GetObjBymIdAsync(lngmId);
if (objgs_ReflectLog != null)
{
localStorage.setItem(strKey, JSON.stringify(objgs_ReflectLog));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objgs_ReflectLog;
}
return objgs_ReflectLog;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, gs_ReflectLog_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objgs_ReflectLog:所给的对象
 * @returns 对象
*/
export async function gs_ReflectLog_UpdateObjInLst_Cache(objgs_ReflectLog: clsgs_ReflectLogEN) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrgs_ReflectLogObjLst_Cache = await gs_ReflectLog_GetObjLst_Cache();
const obj = arrgs_ReflectLogObjLst_Cache.find(x => x.mId == objgs_ReflectLog.mId);
if (obj != null)
{
objgs_ReflectLog.mId = obj.mId;
ObjectAssign( obj, objgs_ReflectLog);
}
else
{
arrgs_ReflectLogObjLst_Cache.push(objgs_ReflectLog);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, gs_ReflectLog_ConstructorName, strThisFuncName);
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
 * @returns 返回一个输出字段值
*/
export async function gs_ReflectLog_func(strInFldName:string , strOutFldName:string , strInValue:string )
{
//const strThisFuncName = "func";

if (strInFldName != clsgs_ReflectLogEN.con_mId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsgs_ReflectLogEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strOutFldName, clsgs_ReflectLogEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const lngmId = Number(strInValue);
if (lngmId == 0)
{
return "";
}
const objgs_ReflectLog = await gs_ReflectLog_GetObjBymId_Cache(lngmId );
if (objgs_ReflectLog == null) return "";
if (objgs_ReflectLog.GetFldValue(strOutFldName) == null) return "";
return objgs_ReflectLog.GetFldValue(strOutFldName).toString();
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
export function gs_ReflectLog_SortFun_Defa(a:clsgs_ReflectLogEN , b:clsgs_ReflectLogEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.mId-b.mId;
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
export function gs_ReflectLog_SortFun_Defa_2Fld(a:clsgs_ReflectLogEN , b:clsgs_ReflectLogEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.topicId == b.topicId) return a.reflectLogName.localeCompare(b.reflectLogName);
else return a.topicId.localeCompare(b.topicId);
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
export function gs_ReflectLog_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsgs_ReflectLogEN.con_mId:
return (a: clsgs_ReflectLogEN, b: clsgs_ReflectLogEN) => {
return a.mId-b.mId;
}
case clsgs_ReflectLogEN.con_TopicId:
return (a: clsgs_ReflectLogEN, b: clsgs_ReflectLogEN) => {
if (a.topicId == null) return -1;
if (b.topicId == null) return 1;
return a.topicId.localeCompare(b.topicId);
}
case clsgs_ReflectLogEN.con_ReflectLogName:
return (a: clsgs_ReflectLogEN, b: clsgs_ReflectLogEN) => {
if (a.reflectLogName == null) return -1;
if (b.reflectLogName == null) return 1;
return a.reflectLogName.localeCompare(b.reflectLogName);
}
case clsgs_ReflectLogEN.con_ReflectLogContent:
return (a: clsgs_ReflectLogEN, b: clsgs_ReflectLogEN) => {
if (a.reflectLogContent == null) return -1;
if (b.reflectLogContent == null) return 1;
return a.reflectLogContent.localeCompare(b.reflectLogContent);
}
case clsgs_ReflectLogEN.con_UpdUser:
return (a: clsgs_ReflectLogEN, b: clsgs_ReflectLogEN) => {
if (a.updUser == null) return -1;
if (b.updUser == null) return 1;
return a.updUser.localeCompare(b.updUser);
}
case clsgs_ReflectLogEN.con_UpdDate:
return (a: clsgs_ReflectLogEN, b: clsgs_ReflectLogEN) => {
if (a.updDate == null) return -1;
if (b.updDate == null) return 1;
return a.updDate.localeCompare(b.updDate);
}
case clsgs_ReflectLogEN.con_Memo:
return (a: clsgs_ReflectLogEN, b: clsgs_ReflectLogEN) => {
if (a.memo == null) return -1;
if (b.memo == null) return 1;
return a.memo.localeCompare(b.memo);
}
case clsgs_ReflectLogEN.con_id_CurrEduCls:
return (a: clsgs_ReflectLogEN, b: clsgs_ReflectLogEN) => {
if (a.id_CurrEduCls == null) return -1;
if (b.id_CurrEduCls == null) return 1;
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_ReflectLog]中不存在！(in ${ gs_ReflectLog_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsgs_ReflectLogEN.con_mId:
return (a: clsgs_ReflectLogEN, b: clsgs_ReflectLogEN) => {
return b.mId-a.mId;
}
case clsgs_ReflectLogEN.con_TopicId:
return (a: clsgs_ReflectLogEN, b: clsgs_ReflectLogEN) => {
if (b.topicId == null) return -1;
if (a.topicId == null) return 1;
return b.topicId.localeCompare(a.topicId);
}
case clsgs_ReflectLogEN.con_ReflectLogName:
return (a: clsgs_ReflectLogEN, b: clsgs_ReflectLogEN) => {
if (b.reflectLogName == null) return -1;
if (a.reflectLogName == null) return 1;
return b.reflectLogName.localeCompare(a.reflectLogName);
}
case clsgs_ReflectLogEN.con_ReflectLogContent:
return (a: clsgs_ReflectLogEN, b: clsgs_ReflectLogEN) => {
if (b.reflectLogContent == null) return -1;
if (a.reflectLogContent == null) return 1;
return b.reflectLogContent.localeCompare(a.reflectLogContent);
}
case clsgs_ReflectLogEN.con_UpdUser:
return (a: clsgs_ReflectLogEN, b: clsgs_ReflectLogEN) => {
if (b.updUser == null) return -1;
if (a.updUser == null) return 1;
return b.updUser.localeCompare(a.updUser);
}
case clsgs_ReflectLogEN.con_UpdDate:
return (a: clsgs_ReflectLogEN, b: clsgs_ReflectLogEN) => {
if (b.updDate == null) return -1;
if (a.updDate == null) return 1;
return b.updDate.localeCompare(a.updDate);
}
case clsgs_ReflectLogEN.con_Memo:
return (a: clsgs_ReflectLogEN, b: clsgs_ReflectLogEN) => {
if (b.memo == null) return -1;
if (a.memo == null) return 1;
return b.memo.localeCompare(a.memo);
}
case clsgs_ReflectLogEN.con_id_CurrEduCls:
return (a: clsgs_ReflectLogEN, b: clsgs_ReflectLogEN) => {
if (b.id_CurrEduCls == null) return -1;
if (a.id_CurrEduCls == null) return 1;
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_ReflectLog]中不存在！(in ${ gs_ReflectLog_ConstructorName}.${ strThisFuncName})`;
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
export async function gs_ReflectLog_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsgs_ReflectLogEN.con_mId:
return (obj: clsgs_ReflectLogEN) => {
return obj.mId === value;
}
case clsgs_ReflectLogEN.con_TopicId:
return (obj: clsgs_ReflectLogEN) => {
return obj.topicId === value;
}
case clsgs_ReflectLogEN.con_ReflectLogName:
return (obj: clsgs_ReflectLogEN) => {
return obj.reflectLogName === value;
}
case clsgs_ReflectLogEN.con_ReflectLogContent:
return (obj: clsgs_ReflectLogEN) => {
return obj.reflectLogContent === value;
}
case clsgs_ReflectLogEN.con_UpdUser:
return (obj: clsgs_ReflectLogEN) => {
return obj.updUser === value;
}
case clsgs_ReflectLogEN.con_UpdDate:
return (obj: clsgs_ReflectLogEN) => {
return obj.updDate === value;
}
case clsgs_ReflectLogEN.con_Memo:
return (obj: clsgs_ReflectLogEN) => {
return obj.memo === value;
}
case clsgs_ReflectLogEN.con_id_CurrEduCls:
return (obj: clsgs_ReflectLogEN) => {
return obj.id_CurrEduCls === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_ReflectLog]中不存在！(in ${ gs_ReflectLog_ConstructorName}.${ strThisFuncName})`;
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
 * @returns 返回一个关键字值列表
*/
export async function gs_ReflectLog_funcKey(strInFldName:string, strInValue: any, strComparisonOp:string): Promise<Array<number>> 
{
//const strThisFuncName = "funcKey";

if (strInFldName == clsgs_ReflectLogEN.con_mId)
{
const strMsg = Format("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (Number(strInValue) == 0)
{
return [];
}
const arrgs_ReflectLog = await gs_ReflectLog_GetObjLst_Cache();
if (arrgs_ReflectLog == null) return [];
let arrgs_ReflectLog_Sel = arrgs_ReflectLog;
const strType = typeof(strInValue);
switch (strType)
{
case "string":
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01: // " = "
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
break;
case enumComparisonOp.Like_03:
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
break;
case enumComparisonOp.In_04:
const arrValues = strInValue.split(',');
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
break;
}
break;
case "boolean":
if (strInValue == null) return [];
if (strComparisonOp == enumComparisonOp.Equal_01)
{
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
}
break;
case "number":
if (Number(strInValue) == 0) return [];
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01:
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
break;
case enumComparisonOp.NotEqual_02:
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
break;
case enumComparisonOp.NotLessThan_05://" >= ":
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
break;
case enumComparisonOp.NotGreaterThan_06://" <= ":
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
case enumComparisonOp.GreaterThan_07://" > ":
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
break;
case enumComparisonOp.LessThan_08://" < ":
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
}
break;
}
if (arrgs_ReflectLog_Sel.length == 0) return [];
return arrgs_ReflectLog_Sel.map(x=>x.mId);
}

 /**
 * 根据条件获取满足条件的第一条记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
 * @param strWhereCond:条件
 * @returns 返回的第一条记录的关键字值
 **/
export async function gs_ReflectLog_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(gs_ReflectLog_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ReflectLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ReflectLog_ConstructorName, strThisFuncName);
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
export async function gs_ReflectLog_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(gs_ReflectLog_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ReflectLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ReflectLog_ConstructorName, strThisFuncName);
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
export async function gs_ReflectLog_GetFirstObjAsync(strWhereCond: string): Promise<clsgs_ReflectLogEN|null>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(gs_ReflectLog_Controller, strAction);
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
const objgs_ReflectLog = gs_ReflectLog_GetObjFromJsonObj(returnObj);
return objgs_ReflectLog;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ReflectLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ReflectLog_ConstructorName, strThisFuncName);
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
export async function gs_ReflectLog_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsgs_ReflectLogEN._CurrTabName;
if (IsNullOrEmpty(clsgs_ReflectLogEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsgs_ReflectLogEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrgs_ReflectLogExObjLst_Cache: Array<clsgs_ReflectLogEN> = CacheHelper.Get(strKey);
const arrgs_ReflectLogObjLst_T = gs_ReflectLog_GetObjLstByJSONObjLst(arrgs_ReflectLogExObjLst_Cache);
return arrgs_ReflectLogObjLst_T;
}
try
{
const arrgs_ReflectLogExObjLst = await gs_ReflectLog_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrgs_ReflectLogExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_ReflectLogExObjLst.length);
console.log(strInfo);
return arrgs_ReflectLogExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, gs_ReflectLog_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_ReflectLog_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsgs_ReflectLogEN._CurrTabName;
if (IsNullOrEmpty(clsgs_ReflectLogEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsgs_ReflectLogEN.CacheAddiCondition);
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
const arrgs_ReflectLogExObjLst_Cache: Array<clsgs_ReflectLogEN> = JSON.parse(strTempObjLst);
const arrgs_ReflectLogObjLst_T = gs_ReflectLog_GetObjLstByJSONObjLst(arrgs_ReflectLogExObjLst_Cache);
return arrgs_ReflectLogObjLst_T;
}
try
{
const arrgs_ReflectLogExObjLst = await gs_ReflectLog_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrgs_ReflectLogExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_ReflectLogExObjLst.length);
console.log(strInfo);
return arrgs_ReflectLogExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, gs_ReflectLog_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_ReflectLog_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsgs_ReflectLogEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrgs_ReflectLogObjLst_Cache: Array<clsgs_ReflectLogEN> = JSON.parse(strTempObjLst);
return arrgs_ReflectLogObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function gs_ReflectLog_GetObjLstAsync(strWhereCond: string): Promise<Array<clsgs_ReflectLogEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(gs_ReflectLog_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_ReflectLog_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_ReflectLog_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ReflectLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ReflectLog_ConstructorName, strThisFuncName);
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
export async function gs_ReflectLog_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsgs_ReflectLogEN._CurrTabName;
if (IsNullOrEmpty(clsgs_ReflectLogEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsgs_ReflectLogEN.CacheAddiCondition);
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
const arrgs_ReflectLogExObjLst_Cache: Array<clsgs_ReflectLogEN> = JSON.parse(strTempObjLst);
const arrgs_ReflectLogObjLst_T = gs_ReflectLog_GetObjLstByJSONObjLst(arrgs_ReflectLogExObjLst_Cache);
return arrgs_ReflectLogObjLst_T;
}
try
{
const arrgs_ReflectLogExObjLst = await gs_ReflectLog_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrgs_ReflectLogExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_ReflectLogExObjLst.length);
console.log(strInfo);
return arrgs_ReflectLogExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, gs_ReflectLog_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_ReflectLog_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsgs_ReflectLogEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrgs_ReflectLogObjLst_Cache: Array<clsgs_ReflectLogEN> = JSON.parse(strTempObjLst);
return arrgs_ReflectLogObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_ReflectLog_GetObjLst_Cache(): Promise<Array<clsgs_ReflectLogEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrgs_ReflectLogObjLst_Cache;
switch (clsgs_ReflectLogEN.CacheModeId)
{
case "04"://sessionStorage
arrgs_ReflectLogObjLst_Cache = await gs_ReflectLog_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrgs_ReflectLogObjLst_Cache = await gs_ReflectLog_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrgs_ReflectLogObjLst_Cache = await gs_ReflectLog_GetObjLst_ClientCache();
break;
default:
arrgs_ReflectLogObjLst_Cache = await gs_ReflectLog_GetObjLst_ClientCache();
break;
}
const arrgs_ReflectLogObjLst = gs_ReflectLog_GetObjLstByJSONObjLst(arrgs_ReflectLogObjLst_Cache);
return arrgs_ReflectLogObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_ReflectLog_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrgs_ReflectLogObjLst_Cache;
switch (clsgs_ReflectLogEN.CacheModeId)
{
case "04"://sessionStorage
arrgs_ReflectLogObjLst_Cache = await gs_ReflectLog_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrgs_ReflectLogObjLst_Cache = await gs_ReflectLog_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrgs_ReflectLogObjLst_Cache = null;
break;
default:
arrgs_ReflectLogObjLst_Cache = null;
break;
}
return arrgs_ReflectLogObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objlngmId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function gs_ReflectLog_GetSubObjLst_Cache(objgs_ReflectLog_Cond: clsgs_ReflectLogEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrgs_ReflectLogObjLst_Cache = await gs_ReflectLog_GetObjLst_Cache();
let arrgs_ReflectLog_Sel: Array < clsgs_ReflectLogEN > = arrgs_ReflectLogObjLst_Cache;
if (objgs_ReflectLog_Cond.sf_FldComparisonOp == null || objgs_ReflectLog_Cond.sf_FldComparisonOp == "") return arrgs_ReflectLog_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_ReflectLog_Cond.sf_FldComparisonOp);
//console.log("clsgs_ReflectLogWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objgs_ReflectLog_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_ReflectLog_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrgs_ReflectLog_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objgs_ReflectLog_Cond), gs_ReflectLog_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsgs_ReflectLogEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrmId:关键字列表
 * @returns 对象列表
 **/
export async function gs_ReflectLog_GetObjLstBymIdLstAsync(arrmId: Array<string>): Promise<Array<clsgs_ReflectLogEN>>  
{
const strThisFuncName = "GetObjLstBymIdLstAsync";
const strAction = "GetObjLstBymIdLst";
const strUrl = GetWebApiUrl(gs_ReflectLog_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrmId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_ReflectLog_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_ReflectLog_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ReflectLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ReflectLog_ConstructorName, strThisFuncName);
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
 * @param arrlngmIdLst:关键字列表
 * @returns 对象列表
*/
export async function gs_ReflectLog_GetObjLstBymIdLst_Cache(arrmIdLst: Array<number>) {
const strThisFuncName = "GetObjLstBymIdLst_Cache";
try
{
const arrgs_ReflectLogObjLst_Cache = await gs_ReflectLog_GetObjLst_Cache();
const arrgs_ReflectLog_Sel: Array <clsgs_ReflectLogEN> = arrgs_ReflectLogObjLst_Cache.filter(x => arrmIdLst.indexOf(x.mId)>-1);
return arrgs_ReflectLog_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrmIdLst.join(","), gs_ReflectLog_ConstructorName, strThisFuncName);
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
export async function gs_ReflectLog_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsgs_ReflectLogEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(gs_ReflectLog_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_ReflectLog_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_ReflectLog_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ReflectLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ReflectLog_ConstructorName, strThisFuncName);
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
export async function gs_ReflectLog_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsgs_ReflectLogEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(gs_ReflectLog_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_ReflectLog_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_ReflectLog_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ReflectLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ReflectLog_ConstructorName, strThisFuncName);
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
export async function gs_ReflectLog_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(gs_ReflectLog_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ReflectLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ReflectLog_ConstructorName, strThisFuncName);
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
export async function gs_ReflectLog_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
if (objPagerPara.pageIndex == 0) return new Array<clsgs_ReflectLogEN>();
const arrgs_ReflectLogObjLst_Cache = await gs_ReflectLog_GetObjLst_Cache();
if (arrgs_ReflectLogObjLst_Cache.length == 0) return arrgs_ReflectLogObjLst_Cache;
let arrgs_ReflectLog_Sel = arrgs_ReflectLogObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objgs_ReflectLog_Cond = new clsgs_ReflectLogEN();
ObjectAssign(objgs_ReflectLog_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsgs_ReflectLogWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_ReflectLog_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrgs_ReflectLog_Sel.length == 0) return arrgs_ReflectLog_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.sort(gs_ReflectLog_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.sort(objPagerPara.sortFun);
}
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.slice(intStart, intEnd);     
return arrgs_ReflectLog_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, gs_ReflectLog_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsgs_ReflectLogEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function gs_ReflectLog_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsgs_ReflectLogEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
if (objPagerPara.pageIndex == 0) return new Array<clsgs_ReflectLogEN>();
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(gs_ReflectLog_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_ReflectLog_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_ReflectLog_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ReflectLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ReflectLog_ConstructorName, strThisFuncName);
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
 * @param lngmId:关键字
 * @returns 获取删除的结果
 **/
export async function gs_ReflectLog_DelRecordAsync(lngmId: number): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(gs_ReflectLog_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, lngmId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ReflectLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ReflectLog_ConstructorName, strThisFuncName);
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
 * @param arrmId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function gs_ReflectLog_Delgs_ReflectLogsAsync(arrmId: Array<string>): Promise<number> 
{
const strThisFuncName = "Delgs_ReflectLogsAsync";
const strAction = "Delgs_ReflectLogs";
const strUrl = GetWebApiUrl(gs_ReflectLog_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrmId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ReflectLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ReflectLog_ConstructorName, strThisFuncName);
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
export async function gs_ReflectLog_Delgs_ReflectLogsByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "Delgs_ReflectLogsByCondAsync";
const strAction = "Delgs_ReflectLogsByCond";
const strUrl = GetWebApiUrl(gs_ReflectLog_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ReflectLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ReflectLog_ConstructorName, strThisFuncName);
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
 * @param objgs_ReflectLogEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_ReflectLog_AddNewRecordAsync(objgs_ReflectLogEN: clsgs_ReflectLogEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objgs_ReflectLogEN);
const strUrl = GetWebApiUrl(gs_ReflectLog_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_ReflectLogEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ReflectLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ReflectLog_ConstructorName, strThisFuncName);
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
 * @param objgs_ReflectLogEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function gs_ReflectLog_AddNewRecordWithReturnKeyAsync(objgs_ReflectLogEN: clsgs_ReflectLogEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(gs_ReflectLog_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_ReflectLogEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ReflectLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ReflectLog_ConstructorName, strThisFuncName);
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
 * @param objgs_ReflectLogEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function gs_ReflectLog_AddNewRecordWithReturnKey(objgs_ReflectLogEN: clsgs_ReflectLogEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objgs_ReflectLogEN.mId === null || objgs_ReflectLogEN.mId === 0)
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(gs_ReflectLog_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_ReflectLogEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ReflectLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ReflectLog_ConstructorName, strThisFuncName);
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
 * @param objgs_ReflectLogEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function gs_ReflectLog_UpdateRecordAsync(objgs_ReflectLogEN: clsgs_ReflectLogEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objgs_ReflectLogEN.sfUpdFldSetStr === undefined || objgs_ReflectLogEN.sfUpdFldSetStr === null || objgs_ReflectLogEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_ReflectLogEN.mId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(gs_ReflectLog_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_ReflectLogEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ReflectLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ReflectLog_ConstructorName, strThisFuncName);
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
 * @param objgs_ReflectLogEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function gs_ReflectLog_UpdateWithConditionAsync(objgs_ReflectLogEN: clsgs_ReflectLogEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objgs_ReflectLogEN.sfUpdFldSetStr === undefined || objgs_ReflectLogEN.sfUpdFldSetStr === null || objgs_ReflectLogEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_ReflectLogEN.mId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(gs_ReflectLog_Controller, strAction);
objgs_ReflectLogEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objgs_ReflectLogEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ReflectLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ReflectLog_ConstructorName, strThisFuncName);
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
 * @param objlngmId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function gs_ReflectLog_IsExistRecord_Cache(objgs_ReflectLog_Cond: clsgs_ReflectLogEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrgs_ReflectLogObjLst_Cache = await gs_ReflectLog_GetObjLst_Cache();
if (arrgs_ReflectLogObjLst_Cache == null) return false;
let arrgs_ReflectLog_Sel: Array < clsgs_ReflectLogEN > = arrgs_ReflectLogObjLst_Cache;
if (objgs_ReflectLog_Cond.sf_FldComparisonOp == null || objgs_ReflectLog_Cond.sf_FldComparisonOp == "") return arrgs_ReflectLog_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_ReflectLog_Cond.sf_FldComparisonOp);
//console.log("clsgs_ReflectLogWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objgs_ReflectLog_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_ReflectLog_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrgs_ReflectLog_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objgs_ReflectLog_Cond), gs_ReflectLog_ConstructorName, strThisFuncName);
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
export async function gs_ReflectLog_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(gs_ReflectLog_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ReflectLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ReflectLog_ConstructorName, strThisFuncName);
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
 * @param lngmId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function gs_ReflectLog_IsExist(lngmId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(gs_ReflectLog_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"mId": lngmId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ReflectLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ReflectLog_ConstructorName, strThisFuncName);
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
 * @param lngmId:所给的关键字
 * @returns 对象
*/
export async function gs_ReflectLog_IsExist_Cache(lngmId:number) {
const strThisFuncName = "IsExist_Cache";
const arrgs_ReflectLogObjLst_Cache = await gs_ReflectLog_GetObjLst_Cache();
if (arrgs_ReflectLogObjLst_Cache == null) return false;
try
{
const arrgs_ReflectLog_Sel: Array <clsgs_ReflectLogEN> = arrgs_ReflectLogObjLst_Cache.filter(x => x.mId == lngmId);
if (arrgs_ReflectLog_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngmId, gs_ReflectLog_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param lngmId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function gs_ReflectLog_IsExistAsync(lngmId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(gs_ReflectLog_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "lngmId": lngmId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ReflectLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ReflectLog_ConstructorName, strThisFuncName);
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
export async function gs_ReflectLog_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(gs_ReflectLog_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ReflectLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ReflectLog_ConstructorName, strThisFuncName);
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
 * @param objgs_ReflectLog_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function gs_ReflectLog_GetRecCountByCond_Cache(objgs_ReflectLog_Cond: clsgs_ReflectLogEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrgs_ReflectLogObjLst_Cache = await gs_ReflectLog_GetObjLst_Cache();
if (arrgs_ReflectLogObjLst_Cache == null) return 0;
let arrgs_ReflectLog_Sel: Array < clsgs_ReflectLogEN > = arrgs_ReflectLogObjLst_Cache;
if (objgs_ReflectLog_Cond.sf_FldComparisonOp == null || objgs_ReflectLog_Cond.sf_FldComparisonOp == "") return arrgs_ReflectLog_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_ReflectLog_Cond.sf_FldComparisonOp);
//console.log("clsgs_ReflectLogWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objgs_ReflectLog_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_ReflectLog_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrgs_ReflectLog_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objgs_ReflectLog_Cond), gs_ReflectLog_ConstructorName, strThisFuncName);
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
export async function gs_ReflectLog_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(gs_ReflectLog_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ReflectLog_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ReflectLog_ConstructorName, strThisFuncName);
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
export function gs_ReflectLog_GetWebApiUrl(strController: string, strAction: string): string {
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
export function gs_ReflectLog_ReFreshCache():void
{
const strThisFuncName = "ReFreshCache";

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = clsgs_ReflectLogEN._CurrTabName;
switch (clsgs_ReflectLogEN.CacheModeId)
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
export function gs_ReflectLog_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clsgs_ReflectLogEN._CurrTabName;
switch (clsgs_ReflectLogEN.CacheModeId)
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
export function gs_ReflectLog_CheckPropertyNew(pobjgs_ReflectLogEN: clsgs_ReflectLogEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjgs_ReflectLogEN.topicId) == false && GetStrLen(pobjgs_ReflectLogEN.topicId) > 8)
{
 throw new Error("(errid:Watl000059)字段[主题Id(topicId)]的长度不能超过8(In 反思日志(gs_ReflectLog))!值:$(pobjgs_ReflectLogEN.topicId)(clsgs_ReflectLogBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ReflectLogEN.reflectLogName) == false && GetStrLen(pobjgs_ReflectLogEN.reflectLogName) > 1000)
{
 throw new Error("(errid:Watl000059)字段[标题(reflectLogName)]的长度不能超过1000(In 反思日志(gs_ReflectLog))!值:$(pobjgs_ReflectLogEN.reflectLogName)(clsgs_ReflectLogBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ReflectLogEN.reflectLogContent) == false && GetStrLen(pobjgs_ReflectLogEN.reflectLogContent) > 5000)
{
 throw new Error("(errid:Watl000059)字段[内容(reflectLogContent)]的长度不能超过5000(In 反思日志(gs_ReflectLog))!值:$(pobjgs_ReflectLogEN.reflectLogContent)(clsgs_ReflectLogBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ReflectLogEN.updUser) == false && GetStrLen(pobjgs_ReflectLogEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 反思日志(gs_ReflectLog))!值:$(pobjgs_ReflectLogEN.updUser)(clsgs_ReflectLogBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ReflectLogEN.updDate) == false && GetStrLen(pobjgs_ReflectLogEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 反思日志(gs_ReflectLog))!值:$(pobjgs_ReflectLogEN.updDate)(clsgs_ReflectLogBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ReflectLogEN.memo) == false && GetStrLen(pobjgs_ReflectLogEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 反思日志(gs_ReflectLog))!值:$(pobjgs_ReflectLogEN.memo)(clsgs_ReflectLogBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ReflectLogEN.id_CurrEduCls) == false && GetStrLen(pobjgs_ReflectLogEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 反思日志(gs_ReflectLog))!值:$(pobjgs_ReflectLogEN.id_CurrEduCls)(clsgs_ReflectLogBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null != pobjgs_ReflectLogEN.mId && undefined !== pobjgs_ReflectLogEN.mId && tzDataType.isNumber(pobjgs_ReflectLogEN.mId) === false)
{
 throw new Error("(errid:Watl000060)字段[mId(mId)]的值:[$(pobjgs_ReflectLogEN.mId)], 非法，应该为数值型(In 反思日志(gs_ReflectLog))!(clsgs_ReflectLogBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ReflectLogEN.topicId) == false && undefined !== pobjgs_ReflectLogEN.topicId && tzDataType.isString(pobjgs_ReflectLogEN.topicId) === false)
{
 throw new Error("(errid:Watl000060)字段[主题Id(topicId)]的值:[$(pobjgs_ReflectLogEN.topicId)], 非法，应该为字符型(In 反思日志(gs_ReflectLog))!(clsgs_ReflectLogBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ReflectLogEN.reflectLogName) == false && undefined !== pobjgs_ReflectLogEN.reflectLogName && tzDataType.isString(pobjgs_ReflectLogEN.reflectLogName) === false)
{
 throw new Error("(errid:Watl000060)字段[标题(reflectLogName)]的值:[$(pobjgs_ReflectLogEN.reflectLogName)], 非法，应该为字符型(In 反思日志(gs_ReflectLog))!(clsgs_ReflectLogBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ReflectLogEN.reflectLogContent) == false && undefined !== pobjgs_ReflectLogEN.reflectLogContent && tzDataType.isString(pobjgs_ReflectLogEN.reflectLogContent) === false)
{
 throw new Error("(errid:Watl000060)字段[内容(reflectLogContent)]的值:[$(pobjgs_ReflectLogEN.reflectLogContent)], 非法，应该为字符型(In 反思日志(gs_ReflectLog))!(clsgs_ReflectLogBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ReflectLogEN.updUser) == false && undefined !== pobjgs_ReflectLogEN.updUser && tzDataType.isString(pobjgs_ReflectLogEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjgs_ReflectLogEN.updUser)], 非法，应该为字符型(In 反思日志(gs_ReflectLog))!(clsgs_ReflectLogBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ReflectLogEN.updDate) == false && undefined !== pobjgs_ReflectLogEN.updDate && tzDataType.isString(pobjgs_ReflectLogEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjgs_ReflectLogEN.updDate)], 非法，应该为字符型(In 反思日志(gs_ReflectLog))!(clsgs_ReflectLogBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ReflectLogEN.memo) == false && undefined !== pobjgs_ReflectLogEN.memo && tzDataType.isString(pobjgs_ReflectLogEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjgs_ReflectLogEN.memo)], 非法，应该为字符型(In 反思日志(gs_ReflectLog))!(clsgs_ReflectLogBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ReflectLogEN.id_CurrEduCls) == false && undefined !== pobjgs_ReflectLogEN.id_CurrEduCls && tzDataType.isString(pobjgs_ReflectLogEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjgs_ReflectLogEN.id_CurrEduCls)], 非法，应该为字符型(In 反思日志(gs_ReflectLog))!(clsgs_ReflectLogBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjgs_ReflectLogEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function gs_ReflectLog_CheckProperty4Update (pobjgs_ReflectLogEN: clsgs_ReflectLogEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjgs_ReflectLogEN.topicId) == false && GetStrLen(pobjgs_ReflectLogEN.topicId) > 8)
{
 throw new Error("(errid:Watl000062)字段[主题Id(topicId)]的长度不能超过8(In 反思日志(gs_ReflectLog))!值:$(pobjgs_ReflectLogEN.topicId)(clsgs_ReflectLogBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ReflectLogEN.reflectLogName) == false && GetStrLen(pobjgs_ReflectLogEN.reflectLogName) > 1000)
{
 throw new Error("(errid:Watl000062)字段[标题(reflectLogName)]的长度不能超过1000(In 反思日志(gs_ReflectLog))!值:$(pobjgs_ReflectLogEN.reflectLogName)(clsgs_ReflectLogBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ReflectLogEN.reflectLogContent) == false && GetStrLen(pobjgs_ReflectLogEN.reflectLogContent) > 5000)
{
 throw new Error("(errid:Watl000062)字段[内容(reflectLogContent)]的长度不能超过5000(In 反思日志(gs_ReflectLog))!值:$(pobjgs_ReflectLogEN.reflectLogContent)(clsgs_ReflectLogBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ReflectLogEN.updUser) == false && GetStrLen(pobjgs_ReflectLogEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 反思日志(gs_ReflectLog))!值:$(pobjgs_ReflectLogEN.updUser)(clsgs_ReflectLogBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ReflectLogEN.updDate) == false && GetStrLen(pobjgs_ReflectLogEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 反思日志(gs_ReflectLog))!值:$(pobjgs_ReflectLogEN.updDate)(clsgs_ReflectLogBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ReflectLogEN.memo) == false && GetStrLen(pobjgs_ReflectLogEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 反思日志(gs_ReflectLog))!值:$(pobjgs_ReflectLogEN.memo)(clsgs_ReflectLogBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ReflectLogEN.id_CurrEduCls) == false && GetStrLen(pobjgs_ReflectLogEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 反思日志(gs_ReflectLog))!值:$(pobjgs_ReflectLogEN.id_CurrEduCls)(clsgs_ReflectLogBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null != pobjgs_ReflectLogEN.mId && undefined !== pobjgs_ReflectLogEN.mId && tzDataType.isNumber(pobjgs_ReflectLogEN.mId) === false)
{
 throw new Error("(errid:Watl000063)字段[mId(mId)]的值:[$(pobjgs_ReflectLogEN.mId)], 非法，应该为数值型(In 反思日志(gs_ReflectLog))!(clsgs_ReflectLogBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ReflectLogEN.topicId) == false && undefined !== pobjgs_ReflectLogEN.topicId && tzDataType.isString(pobjgs_ReflectLogEN.topicId) === false)
{
 throw new Error("(errid:Watl000063)字段[主题Id(topicId)]的值:[$(pobjgs_ReflectLogEN.topicId)], 非法，应该为字符型(In 反思日志(gs_ReflectLog))!(clsgs_ReflectLogBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ReflectLogEN.reflectLogName) == false && undefined !== pobjgs_ReflectLogEN.reflectLogName && tzDataType.isString(pobjgs_ReflectLogEN.reflectLogName) === false)
{
 throw new Error("(errid:Watl000063)字段[标题(reflectLogName)]的值:[$(pobjgs_ReflectLogEN.reflectLogName)], 非法，应该为字符型(In 反思日志(gs_ReflectLog))!(clsgs_ReflectLogBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ReflectLogEN.reflectLogContent) == false && undefined !== pobjgs_ReflectLogEN.reflectLogContent && tzDataType.isString(pobjgs_ReflectLogEN.reflectLogContent) === false)
{
 throw new Error("(errid:Watl000063)字段[内容(reflectLogContent)]的值:[$(pobjgs_ReflectLogEN.reflectLogContent)], 非法，应该为字符型(In 反思日志(gs_ReflectLog))!(clsgs_ReflectLogBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ReflectLogEN.updUser) == false && undefined !== pobjgs_ReflectLogEN.updUser && tzDataType.isString(pobjgs_ReflectLogEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjgs_ReflectLogEN.updUser)], 非法，应该为字符型(In 反思日志(gs_ReflectLog))!(clsgs_ReflectLogBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ReflectLogEN.updDate) == false && undefined !== pobjgs_ReflectLogEN.updDate && tzDataType.isString(pobjgs_ReflectLogEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjgs_ReflectLogEN.updDate)], 非法，应该为字符型(In 反思日志(gs_ReflectLog))!(clsgs_ReflectLogBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ReflectLogEN.memo) == false && undefined !== pobjgs_ReflectLogEN.memo && tzDataType.isString(pobjgs_ReflectLogEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjgs_ReflectLogEN.memo)], 非法，应该为字符型(In 反思日志(gs_ReflectLog))!(clsgs_ReflectLogBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ReflectLogEN.id_CurrEduCls) == false && undefined !== pobjgs_ReflectLogEN.id_CurrEduCls && tzDataType.isString(pobjgs_ReflectLogEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjgs_ReflectLogEN.id_CurrEduCls)], 非法，应该为字符型(In 反思日志(gs_ReflectLog))!(clsgs_ReflectLogBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjgs_ReflectLogEN.mId 
 || pobjgs_ReflectLogEN.mId != null && pobjgs_ReflectLogEN.mId.toString()  ===  "")
{
 throw new Error("(errid:Watl000064)字段[mId]不能为空(In 反思日志)!(clsgs_ReflectLogBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjgs_ReflectLogEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function gs_ReflectLog_GetJSONStrByObj (pobjgs_ReflectLogEN: clsgs_ReflectLogEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjgs_ReflectLogEN.sfUpdFldSetStr = pobjgs_ReflectLogEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjgs_ReflectLogEN);
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
export function gs_ReflectLog_GetObjLstByJSONStr (strJSON: string): Array<clsgs_ReflectLogEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrgs_ReflectLogObjLst = new Array<clsgs_ReflectLogEN>();
if (strJSON === "")
{
return arrgs_ReflectLogObjLst;
}
try
{
arrgs_ReflectLogObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrgs_ReflectLogObjLst;
}
return arrgs_ReflectLogObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrgs_ReflectLogObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function gs_ReflectLog_GetObjLstByJSONObjLst (arrgs_ReflectLogObjLstS: Array<clsgs_ReflectLogEN>): Array<clsgs_ReflectLogEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrgs_ReflectLogObjLst = new Array<clsgs_ReflectLogEN>();
for (const objInFor of arrgs_ReflectLogObjLstS) {
const obj1 = gs_ReflectLog_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrgs_ReflectLogObjLst.push(obj1);
}
return arrgs_ReflectLogObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function gs_ReflectLog_GetObjByJSONStr (strJSON: string): clsgs_ReflectLogEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjgs_ReflectLogEN = new clsgs_ReflectLogEN();
if (strJSON === "")
{
return pobjgs_ReflectLogEN;
}
try
{
pobjgs_ReflectLogEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjgs_ReflectLogEN;
}
return pobjgs_ReflectLogEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function gs_ReflectLog_GetCombineCondition(objgs_ReflectLog_Cond: clsgs_ReflectLogEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objgs_ReflectLog_Cond.dicFldComparisonOp, clsgs_ReflectLogEN.con_mId) == true)
{
const strComparisonOp_mId:string = objgs_ReflectLog_Cond.dicFldComparisonOp[clsgs_ReflectLogEN.con_mId];
strWhereCond += Format(" And {0} {2} {1}", clsgs_ReflectLogEN.con_mId, objgs_ReflectLog_Cond.mId, strComparisonOp_mId);
}
if (Object.prototype.hasOwnProperty.call(objgs_ReflectLog_Cond.dicFldComparisonOp, clsgs_ReflectLogEN.con_TopicId) == true)
{
const strComparisonOp_TopicId:string = objgs_ReflectLog_Cond.dicFldComparisonOp[clsgs_ReflectLogEN.con_TopicId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_ReflectLogEN.con_TopicId, objgs_ReflectLog_Cond.topicId, strComparisonOp_TopicId);
}
if (Object.prototype.hasOwnProperty.call(objgs_ReflectLog_Cond.dicFldComparisonOp, clsgs_ReflectLogEN.con_ReflectLogName) == true)
{
const strComparisonOp_ReflectLogName:string = objgs_ReflectLog_Cond.dicFldComparisonOp[clsgs_ReflectLogEN.con_ReflectLogName];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_ReflectLogEN.con_ReflectLogName, objgs_ReflectLog_Cond.reflectLogName, strComparisonOp_ReflectLogName);
}
if (Object.prototype.hasOwnProperty.call(objgs_ReflectLog_Cond.dicFldComparisonOp, clsgs_ReflectLogEN.con_ReflectLogContent) == true)
{
const strComparisonOp_ReflectLogContent:string = objgs_ReflectLog_Cond.dicFldComparisonOp[clsgs_ReflectLogEN.con_ReflectLogContent];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_ReflectLogEN.con_ReflectLogContent, objgs_ReflectLog_Cond.reflectLogContent, strComparisonOp_ReflectLogContent);
}
if (Object.prototype.hasOwnProperty.call(objgs_ReflectLog_Cond.dicFldComparisonOp, clsgs_ReflectLogEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objgs_ReflectLog_Cond.dicFldComparisonOp[clsgs_ReflectLogEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_ReflectLogEN.con_UpdUser, objgs_ReflectLog_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objgs_ReflectLog_Cond.dicFldComparisonOp, clsgs_ReflectLogEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objgs_ReflectLog_Cond.dicFldComparisonOp[clsgs_ReflectLogEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_ReflectLogEN.con_UpdDate, objgs_ReflectLog_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objgs_ReflectLog_Cond.dicFldComparisonOp, clsgs_ReflectLogEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objgs_ReflectLog_Cond.dicFldComparisonOp[clsgs_ReflectLogEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_ReflectLogEN.con_Memo, objgs_ReflectLog_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objgs_ReflectLog_Cond.dicFldComparisonOp, clsgs_ReflectLogEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objgs_ReflectLog_Cond.dicFldComparisonOp[clsgs_ReflectLogEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_ReflectLogEN.con_id_CurrEduCls, objgs_ReflectLog_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--gs_ReflectLog(反思日志),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param lngmId: mId(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function gs_ReflectLog_GetUniCondStr_mId(objgs_ReflectLogEN: clsgs_ReflectLogEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and mId = '{0}'", objgs_ReflectLogEN.mId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--gs_ReflectLog(反思日志),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param lngmId: mId(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function gs_ReflectLog_GetUniCondStr4Update_mId(objgs_ReflectLogEN: clsgs_ReflectLogEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and mId <> '{0}'", objgs_ReflectLogEN.mId);
 strWhereCond +=  Format(" and mId = '{0}'", objgs_ReflectLogEN.mId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objgs_ReflectLogENS:源对象
 * @param objgs_ReflectLogENT:目标对象
*/
export function gs_ReflectLog_CopyObjTo(objgs_ReflectLogENS: clsgs_ReflectLogEN , objgs_ReflectLogENT: clsgs_ReflectLogEN ): void 
{
objgs_ReflectLogENT.mId = objgs_ReflectLogENS.mId; //mId
objgs_ReflectLogENT.topicId = objgs_ReflectLogENS.topicId; //主题Id
objgs_ReflectLogENT.reflectLogName = objgs_ReflectLogENS.reflectLogName; //标题
objgs_ReflectLogENT.reflectLogContent = objgs_ReflectLogENS.reflectLogContent; //内容
objgs_ReflectLogENT.updUser = objgs_ReflectLogENS.updUser; //修改人
objgs_ReflectLogENT.updDate = objgs_ReflectLogENS.updDate; //修改日期
objgs_ReflectLogENT.memo = objgs_ReflectLogENS.memo; //备注
objgs_ReflectLogENT.id_CurrEduCls = objgs_ReflectLogENS.id_CurrEduCls; //教学班流水号
objgs_ReflectLogENT.sfUpdFldSetStr = objgs_ReflectLogENS.updFldString; //sfUpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objgs_ReflectLogENS:源对象
 * @param objgs_ReflectLogENT:目标对象
*/
export function gs_ReflectLog_GetObjFromJsonObj(objgs_ReflectLogENS: clsgs_ReflectLogEN): clsgs_ReflectLogEN 
{
 const objgs_ReflectLogENT: clsgs_ReflectLogEN = new clsgs_ReflectLogEN();
ObjectAssign(objgs_ReflectLogENT, objgs_ReflectLogENS);
 return objgs_ReflectLogENT;
}