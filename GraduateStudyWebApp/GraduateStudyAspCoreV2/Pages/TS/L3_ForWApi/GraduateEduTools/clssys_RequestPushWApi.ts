
 /**
 * 类名:clssys_RequestPushWApi
 * 表名:sys_RequestPush(01120726)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:48:34
 * 生成者:pyf
 * 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:研培设置(GraduateEduTools)
 * 框架-层名:WA_访问层(TS)(WA_Access)
 * 编程语言:TypeScript
 * 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
   *      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 **/

/**
 * 请求推送表(sys_RequestPush)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2023年03月13日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { enumComparisonOp } from "../../PubFun/enumComparisonOp.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { clssys_RequestPushEN } from "../../L0_Entity/GraduateEduTools/clssys_RequestPushEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { tzDataType } from "../../PubFun/clsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const sys_RequestPush_Controller = "sys_RequestPushApi";
 export const sys_RequestPush_ConstructorName = "sys_RequestPush";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngRequestId:关键字
 * @returns 对象
 **/
export async function sys_RequestPush_GetObjByRequestIdAsync(lngRequestId: number): Promise<clssys_RequestPushEN|null>  
{
const strThisFuncName = "GetObjByRequestIdAsync";

if (lngRequestId == 0)
{
  const strMsg = Format("参数:[lngRequestId]不能为空！(In clssys_RequestPushWApi.GetObjByRequestIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjByRequestId";
const strUrl = GetWebApiUrl(sys_RequestPush_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"lngRequestId": lngRequestId,
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
const objsys_RequestPush = sys_RequestPush_GetObjFromJsonObj(returnObj);
return objsys_RequestPush;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sys_RequestPush_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sys_RequestPush_ConstructorName, strThisFuncName);
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
 * @param lngRequestId:所给的关键字
 * @returns 对象
*/
export async function sys_RequestPush_GetObjByRequestId_Cache(lngRequestId: number, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByRequestId_Cache";

if (lngRequestId == 0)
{
  const strMsg = Format("参数:[lngRequestId]不能为空！(In clssys_RequestPushWApi.GetObjByRequestId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
const arrsys_RequestPushObjLst_Cache = await sys_RequestPush_GetObjLst_Cache();
try
{
const arrsys_RequestPush_Sel: Array <clssys_RequestPushEN> = arrsys_RequestPushObjLst_Cache.filter(x => 
 x.requestId == lngRequestId );
let objsys_RequestPush: clssys_RequestPushEN;
if (arrsys_RequestPush_Sel.length > 0)
{
objsys_RequestPush = arrsys_RequestPush_Sel[0];
return objsys_RequestPush;
}
else
{
if (bolTryAsyncOnce == true)
{
const objsys_RequestPush_Const = await sys_RequestPush_GetObjByRequestIdAsync(lngRequestId);
if (objsys_RequestPush_Const != null)
{
sys_RequestPush_ReFreshThisCache();
return objsys_RequestPush_Const;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngRequestId, sys_RequestPush_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param lngRequestId:所给的关键字
 * @returns 对象
*/
export async function sys_RequestPush_GetObjByRequestId_localStorage(lngRequestId: number) {
const strThisFuncName = "GetObjByRequestId_localStorage";

if (lngRequestId == 0)
{
  const strMsg = Format("参数:[lngRequestId]不能为空！(In clssys_RequestPushWApi.GetObjByRequestId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
const strKey = Format("{0}_{1}", clssys_RequestPushEN._CurrTabName, lngRequestId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objsys_RequestPush_Cache: clssys_RequestPushEN = JSON.parse(strTempObj);
return objsys_RequestPush_Cache;
}
try
{
const objsys_RequestPush = await sys_RequestPush_GetObjByRequestIdAsync(lngRequestId);
if (objsys_RequestPush != null)
{
localStorage.setItem(strKey, JSON.stringify(objsys_RequestPush));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objsys_RequestPush;
}
return objsys_RequestPush;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngRequestId, sys_RequestPush_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objsys_RequestPush:所给的对象
 * @returns 对象
*/
export async function sys_RequestPush_UpdateObjInLst_Cache(objsys_RequestPush: clssys_RequestPushEN) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrsys_RequestPushObjLst_Cache = await sys_RequestPush_GetObjLst_Cache();
const obj = arrsys_RequestPushObjLst_Cache.find(x => x.requesTypeId == objsys_RequestPush.requesTypeId && x.tableKey == objsys_RequestPush.tableKey);
if (obj != null)
{
objsys_RequestPush.requestId = obj.requestId;
ObjectAssign( obj, objsys_RequestPush);
}
else
{
arrsys_RequestPushObjLst_Cache.push(objsys_RequestPush);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, sys_RequestPush_ConstructorName, strThisFuncName);
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
export async function sys_RequestPush_func(strInFldName:string , strOutFldName:string , strInValue:string )
{
//const strThisFuncName = "func";

if (strInFldName != clssys_RequestPushEN.con_RequestId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clssys_RequestPushEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strOutFldName, clssys_RequestPushEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const lngRequestId = Number(strInValue);
if (lngRequestId == 0)
{
return "";
}
const objsys_RequestPush = await sys_RequestPush_GetObjByRequestId_Cache(lngRequestId );
if (objsys_RequestPush == null) return "";
if (objsys_RequestPush.GetFldValue(strOutFldName) == null) return "";
return objsys_RequestPush.GetFldValue(strOutFldName).toString();
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
export function sys_RequestPush_SortFun_Defa(a:clssys_RequestPushEN , b:clssys_RequestPushEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.requestId-b.requestId;
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
export function sys_RequestPush_SortFun_Defa_2Fld(a:clssys_RequestPushEN , b:clssys_RequestPushEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.requesTypeId == b.requesTypeId) return a.tableKey.localeCompare(b.tableKey);
else return a.requesTypeId.localeCompare(b.requesTypeId);
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
export function sys_RequestPush_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clssys_RequestPushEN.con_RequestId:
return (a: clssys_RequestPushEN, b: clssys_RequestPushEN) => {
return a.requestId-b.requestId;
}
case clssys_RequestPushEN.con_RequesTypeId:
return (a: clssys_RequestPushEN, b: clssys_RequestPushEN) => {
if (a.requesTypeId == null) return -1;
if (b.requesTypeId == null) return 1;
return a.requesTypeId.localeCompare(b.requesTypeId);
}
case clssys_RequestPushEN.con_TableKey:
return (a: clssys_RequestPushEN, b: clssys_RequestPushEN) => {
if (a.tableKey == null) return -1;
if (b.tableKey == null) return 1;
return a.tableKey.localeCompare(b.tableKey);
}
case clssys_RequestPushEN.con_ReceiveUser:
return (a: clssys_RequestPushEN, b: clssys_RequestPushEN) => {
if (a.receiveUser == null) return -1;
if (b.receiveUser == null) return 1;
return a.receiveUser.localeCompare(b.receiveUser);
}
case clssys_RequestPushEN.con_IsReply:
return (a: clssys_RequestPushEN, b: clssys_RequestPushEN) => {
if (a.isReply == true) return 1;
else return -1
}
case clssys_RequestPushEN.con_ReplyDate:
return (a: clssys_RequestPushEN, b: clssys_RequestPushEN) => {
if (a.replyDate == null) return -1;
if (b.replyDate == null) return 1;
return a.replyDate.localeCompare(b.replyDate);
}
case clssys_RequestPushEN.con_RequestUser:
return (a: clssys_RequestPushEN, b: clssys_RequestPushEN) => {
if (a.requestUser == null) return -1;
if (b.requestUser == null) return 1;
return a.requestUser.localeCompare(b.requestUser);
}
case clssys_RequestPushEN.con_RequestDate:
return (a: clssys_RequestPushEN, b: clssys_RequestPushEN) => {
if (a.requestDate == null) return -1;
if (b.requestDate == null) return 1;
return a.requestDate.localeCompare(b.requestDate);
}
case clssys_RequestPushEN.con_RequestStata:
return (a: clssys_RequestPushEN, b: clssys_RequestPushEN) => {
if (a.requestStata == null) return -1;
if (b.requestStata == null) return 1;
return a.requestStata.localeCompare(b.requestStata);
}
case clssys_RequestPushEN.con_Memo:
return (a: clssys_RequestPushEN, b: clssys_RequestPushEN) => {
if (a.memo == null) return -1;
if (b.memo == null) return 1;
return a.memo.localeCompare(b.memo);
}
case clssys_RequestPushEN.con_id_CurrEduCls:
return (a: clssys_RequestPushEN, b: clssys_RequestPushEN) => {
if (a.id_CurrEduCls == null) return -1;
if (b.id_CurrEduCls == null) return 1;
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
case clssys_RequestPushEN.con_PushTypeId:
return (a: clssys_RequestPushEN, b: clssys_RequestPushEN) => {
if (a.pushTypeId == null) return -1;
if (b.pushTypeId == null) return 1;
return a.pushTypeId.localeCompare(b.pushTypeId);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[sys_RequestPush]中不存在！(in ${ sys_RequestPush_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clssys_RequestPushEN.con_RequestId:
return (a: clssys_RequestPushEN, b: clssys_RequestPushEN) => {
return b.requestId-a.requestId;
}
case clssys_RequestPushEN.con_RequesTypeId:
return (a: clssys_RequestPushEN, b: clssys_RequestPushEN) => {
if (b.requesTypeId == null) return -1;
if (a.requesTypeId == null) return 1;
return b.requesTypeId.localeCompare(a.requesTypeId);
}
case clssys_RequestPushEN.con_TableKey:
return (a: clssys_RequestPushEN, b: clssys_RequestPushEN) => {
if (b.tableKey == null) return -1;
if (a.tableKey == null) return 1;
return b.tableKey.localeCompare(a.tableKey);
}
case clssys_RequestPushEN.con_ReceiveUser:
return (a: clssys_RequestPushEN, b: clssys_RequestPushEN) => {
if (b.receiveUser == null) return -1;
if (a.receiveUser == null) return 1;
return b.receiveUser.localeCompare(a.receiveUser);
}
case clssys_RequestPushEN.con_IsReply:
return (a: clssys_RequestPushEN, b: clssys_RequestPushEN) => {
if (b.isReply == true) return 1;
else return -1
}
case clssys_RequestPushEN.con_ReplyDate:
return (a: clssys_RequestPushEN, b: clssys_RequestPushEN) => {
if (b.replyDate == null) return -1;
if (a.replyDate == null) return 1;
return b.replyDate.localeCompare(a.replyDate);
}
case clssys_RequestPushEN.con_RequestUser:
return (a: clssys_RequestPushEN, b: clssys_RequestPushEN) => {
if (b.requestUser == null) return -1;
if (a.requestUser == null) return 1;
return b.requestUser.localeCompare(a.requestUser);
}
case clssys_RequestPushEN.con_RequestDate:
return (a: clssys_RequestPushEN, b: clssys_RequestPushEN) => {
if (b.requestDate == null) return -1;
if (a.requestDate == null) return 1;
return b.requestDate.localeCompare(a.requestDate);
}
case clssys_RequestPushEN.con_RequestStata:
return (a: clssys_RequestPushEN, b: clssys_RequestPushEN) => {
if (b.requestStata == null) return -1;
if (a.requestStata == null) return 1;
return b.requestStata.localeCompare(a.requestStata);
}
case clssys_RequestPushEN.con_Memo:
return (a: clssys_RequestPushEN, b: clssys_RequestPushEN) => {
if (b.memo == null) return -1;
if (a.memo == null) return 1;
return b.memo.localeCompare(a.memo);
}
case clssys_RequestPushEN.con_id_CurrEduCls:
return (a: clssys_RequestPushEN, b: clssys_RequestPushEN) => {
if (b.id_CurrEduCls == null) return -1;
if (a.id_CurrEduCls == null) return 1;
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
case clssys_RequestPushEN.con_PushTypeId:
return (a: clssys_RequestPushEN, b: clssys_RequestPushEN) => {
if (b.pushTypeId == null) return -1;
if (a.pushTypeId == null) return 1;
return b.pushTypeId.localeCompare(a.pushTypeId);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[sys_RequestPush]中不存在！(in ${ sys_RequestPush_ConstructorName}.${ strThisFuncName})`;
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
export async function sys_RequestPush_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clssys_RequestPushEN.con_RequestId:
return (obj: clssys_RequestPushEN) => {
return obj.requestId === value;
}
case clssys_RequestPushEN.con_RequesTypeId:
return (obj: clssys_RequestPushEN) => {
return obj.requesTypeId === value;
}
case clssys_RequestPushEN.con_TableKey:
return (obj: clssys_RequestPushEN) => {
return obj.tableKey === value;
}
case clssys_RequestPushEN.con_ReceiveUser:
return (obj: clssys_RequestPushEN) => {
return obj.receiveUser === value;
}
case clssys_RequestPushEN.con_IsReply:
return (obj: clssys_RequestPushEN) => {
return obj.isReply === value;
}
case clssys_RequestPushEN.con_ReplyDate:
return (obj: clssys_RequestPushEN) => {
return obj.replyDate === value;
}
case clssys_RequestPushEN.con_RequestUser:
return (obj: clssys_RequestPushEN) => {
return obj.requestUser === value;
}
case clssys_RequestPushEN.con_RequestDate:
return (obj: clssys_RequestPushEN) => {
return obj.requestDate === value;
}
case clssys_RequestPushEN.con_RequestStata:
return (obj: clssys_RequestPushEN) => {
return obj.requestStata === value;
}
case clssys_RequestPushEN.con_Memo:
return (obj: clssys_RequestPushEN) => {
return obj.memo === value;
}
case clssys_RequestPushEN.con_id_CurrEduCls:
return (obj: clssys_RequestPushEN) => {
return obj.id_CurrEduCls === value;
}
case clssys_RequestPushEN.con_PushTypeId:
return (obj: clssys_RequestPushEN) => {
return obj.pushTypeId === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[sys_RequestPush]中不存在！(in ${ sys_RequestPush_ConstructorName}.${ strThisFuncName})`;
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
export async function sys_RequestPush_funcKey(strInFldName:string, strInValue: any, strComparisonOp:string): Promise<Array<number>> 
{
//const strThisFuncName = "funcKey";

if (strInFldName == clssys_RequestPushEN.con_RequestId)
{
const strMsg = Format("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (Number(strInValue) == 0)
{
return [];
}
const arrsys_RequestPush = await sys_RequestPush_GetObjLst_Cache();
if (arrsys_RequestPush == null) return [];
let arrsys_RequestPush_Sel = arrsys_RequestPush;
const strType = typeof(strInValue);
switch (strType)
{
case "string":
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01: // " = "
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
break;
case enumComparisonOp.Like_03:
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
break;
case enumComparisonOp.In_04:
const arrValues = strInValue.split(',');
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
break;
}
break;
case "boolean":
if (strInValue == null) return [];
if (strComparisonOp == enumComparisonOp.Equal_01)
{
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
}
break;
case "number":
if (Number(strInValue) == 0) return [];
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01:
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
break;
case enumComparisonOp.NotEqual_02:
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
break;
case enumComparisonOp.NotLessThan_05://" >= ":
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
break;
case enumComparisonOp.NotGreaterThan_06://" <= ":
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
case enumComparisonOp.GreaterThan_07://" > ":
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
break;
case enumComparisonOp.LessThan_08://" < ":
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
}
break;
}
if (arrsys_RequestPush_Sel.length == 0) return [];
return arrsys_RequestPush_Sel.map(x=>x.requestId);
}

 /**
 * 根据条件获取满足条件的第一条记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
 * @param strWhereCond:条件
 * @returns 返回的第一条记录的关键字值
 **/
export async function sys_RequestPush_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(sys_RequestPush_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sys_RequestPush_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sys_RequestPush_ConstructorName, strThisFuncName);
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
export async function sys_RequestPush_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(sys_RequestPush_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sys_RequestPush_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sys_RequestPush_ConstructorName, strThisFuncName);
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
export async function sys_RequestPush_GetFirstObjAsync(strWhereCond: string): Promise<clssys_RequestPushEN|null>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(sys_RequestPush_Controller, strAction);
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
const objsys_RequestPush = sys_RequestPush_GetObjFromJsonObj(returnObj);
return objsys_RequestPush;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sys_RequestPush_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sys_RequestPush_ConstructorName, strThisFuncName);
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
export async function sys_RequestPush_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clssys_RequestPushEN._CurrTabName;
if (IsNullOrEmpty(clssys_RequestPushEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clssys_RequestPushEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrsys_RequestPushExObjLst_Cache: Array<clssys_RequestPushEN> = CacheHelper.Get(strKey);
const arrsys_RequestPushObjLst_T = sys_RequestPush_GetObjLstByJSONObjLst(arrsys_RequestPushExObjLst_Cache);
return arrsys_RequestPushObjLst_T;
}
try
{
const arrsys_RequestPushExObjLst = await sys_RequestPush_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrsys_RequestPushExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrsys_RequestPushExObjLst.length);
console.log(strInfo);
return arrsys_RequestPushExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, sys_RequestPush_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function sys_RequestPush_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clssys_RequestPushEN._CurrTabName;
if (IsNullOrEmpty(clssys_RequestPushEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clssys_RequestPushEN.CacheAddiCondition);
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
const arrsys_RequestPushExObjLst_Cache: Array<clssys_RequestPushEN> = JSON.parse(strTempObjLst);
const arrsys_RequestPushObjLst_T = sys_RequestPush_GetObjLstByJSONObjLst(arrsys_RequestPushExObjLst_Cache);
return arrsys_RequestPushObjLst_T;
}
try
{
const arrsys_RequestPushExObjLst = await sys_RequestPush_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrsys_RequestPushExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrsys_RequestPushExObjLst.length);
console.log(strInfo);
return arrsys_RequestPushExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, sys_RequestPush_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function sys_RequestPush_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clssys_RequestPushEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrsys_RequestPushObjLst_Cache: Array<clssys_RequestPushEN> = JSON.parse(strTempObjLst);
return arrsys_RequestPushObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function sys_RequestPush_GetObjLstAsync(strWhereCond: string): Promise<Array<clssys_RequestPushEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(sys_RequestPush_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sys_RequestPush_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = sys_RequestPush_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sys_RequestPush_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sys_RequestPush_ConstructorName, strThisFuncName);
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
export async function sys_RequestPush_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clssys_RequestPushEN._CurrTabName;
if (IsNullOrEmpty(clssys_RequestPushEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clssys_RequestPushEN.CacheAddiCondition);
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
const arrsys_RequestPushExObjLst_Cache: Array<clssys_RequestPushEN> = JSON.parse(strTempObjLst);
const arrsys_RequestPushObjLst_T = sys_RequestPush_GetObjLstByJSONObjLst(arrsys_RequestPushExObjLst_Cache);
return arrsys_RequestPushObjLst_T;
}
try
{
const arrsys_RequestPushExObjLst = await sys_RequestPush_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrsys_RequestPushExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrsys_RequestPushExObjLst.length);
console.log(strInfo);
return arrsys_RequestPushExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, sys_RequestPush_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function sys_RequestPush_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clssys_RequestPushEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrsys_RequestPushObjLst_Cache: Array<clssys_RequestPushEN> = JSON.parse(strTempObjLst);
return arrsys_RequestPushObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function sys_RequestPush_GetObjLst_Cache(): Promise<Array<clssys_RequestPushEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrsys_RequestPushObjLst_Cache;
switch (clssys_RequestPushEN.CacheModeId)
{
case "04"://sessionStorage
arrsys_RequestPushObjLst_Cache = await sys_RequestPush_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrsys_RequestPushObjLst_Cache = await sys_RequestPush_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrsys_RequestPushObjLst_Cache = await sys_RequestPush_GetObjLst_ClientCache();
break;
default:
arrsys_RequestPushObjLst_Cache = await sys_RequestPush_GetObjLst_ClientCache();
break;
}
const arrsys_RequestPushObjLst = sys_RequestPush_GetObjLstByJSONObjLst(arrsys_RequestPushObjLst_Cache);
return arrsys_RequestPushObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function sys_RequestPush_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrsys_RequestPushObjLst_Cache;
switch (clssys_RequestPushEN.CacheModeId)
{
case "04"://sessionStorage
arrsys_RequestPushObjLst_Cache = await sys_RequestPush_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrsys_RequestPushObjLst_Cache = await sys_RequestPush_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrsys_RequestPushObjLst_Cache = null;
break;
default:
arrsys_RequestPushObjLst_Cache = null;
break;
}
return arrsys_RequestPushObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objlngRequestId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function sys_RequestPush_GetSubObjLst_Cache(objsys_RequestPush_Cond: clssys_RequestPushEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrsys_RequestPushObjLst_Cache = await sys_RequestPush_GetObjLst_Cache();
let arrsys_RequestPush_Sel: Array < clssys_RequestPushEN > = arrsys_RequestPushObjLst_Cache;
if (objsys_RequestPush_Cond.sf_FldComparisonOp == null || objsys_RequestPush_Cond.sf_FldComparisonOp == "") return arrsys_RequestPush_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objsys_RequestPush_Cond.sf_FldComparisonOp);
//console.log("clssys_RequestPushWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objsys_RequestPush_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objsys_RequestPush_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrsys_RequestPush_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objsys_RequestPush_Cond), sys_RequestPush_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clssys_RequestPushEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrRequestId:关键字列表
 * @returns 对象列表
 **/
export async function sys_RequestPush_GetObjLstByRequestIdLstAsync(arrRequestId: Array<string>): Promise<Array<clssys_RequestPushEN>>  
{
const strThisFuncName = "GetObjLstByRequestIdLstAsync";
const strAction = "GetObjLstByRequestIdLst";
const strUrl = GetWebApiUrl(sys_RequestPush_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrRequestId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sys_RequestPush_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = sys_RequestPush_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sys_RequestPush_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sys_RequestPush_ConstructorName, strThisFuncName);
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
 * @param arrlngRequestIdLst:关键字列表
 * @returns 对象列表
*/
export async function sys_RequestPush_GetObjLstByRequestIdLst_Cache(arrRequestIdLst: Array<number>) {
const strThisFuncName = "GetObjLstByRequestIdLst_Cache";
try
{
const arrsys_RequestPushObjLst_Cache = await sys_RequestPush_GetObjLst_Cache();
const arrsys_RequestPush_Sel: Array <clssys_RequestPushEN> = arrsys_RequestPushObjLst_Cache.filter(x => arrRequestIdLst.indexOf(x.requestId)>-1);
return arrsys_RequestPush_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrRequestIdLst.join(","), sys_RequestPush_ConstructorName, strThisFuncName);
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
export async function sys_RequestPush_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clssys_RequestPushEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(sys_RequestPush_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sys_RequestPush_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = sys_RequestPush_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sys_RequestPush_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sys_RequestPush_ConstructorName, strThisFuncName);
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
export async function sys_RequestPush_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clssys_RequestPushEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(sys_RequestPush_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sys_RequestPush_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = sys_RequestPush_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sys_RequestPush_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sys_RequestPush_ConstructorName, strThisFuncName);
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
export async function sys_RequestPush_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(sys_RequestPush_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sys_RequestPush_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sys_RequestPush_ConstructorName, strThisFuncName);
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
export async function sys_RequestPush_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
if (objPagerPara.pageIndex == 0) return new Array<clssys_RequestPushEN>();
const arrsys_RequestPushObjLst_Cache = await sys_RequestPush_GetObjLst_Cache();
if (arrsys_RequestPushObjLst_Cache.length == 0) return arrsys_RequestPushObjLst_Cache;
let arrsys_RequestPush_Sel = arrsys_RequestPushObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objsys_RequestPush_Cond = new clssys_RequestPushEN();
ObjectAssign(objsys_RequestPush_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clssys_RequestPushWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objsys_RequestPush_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrsys_RequestPush_Sel.length == 0) return arrsys_RequestPush_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.sort(sys_RequestPush_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.sort(objPagerPara.sortFun);
}
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.slice(intStart, intEnd);     
return arrsys_RequestPush_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, sys_RequestPush_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clssys_RequestPushEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function sys_RequestPush_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clssys_RequestPushEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
if (objPagerPara.pageIndex == 0) return new Array<clssys_RequestPushEN>();
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(sys_RequestPush_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sys_RequestPush_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = sys_RequestPush_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sys_RequestPush_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sys_RequestPush_ConstructorName, strThisFuncName);
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
 * @param lngRequestId:关键字
 * @returns 获取删除的结果
 **/
export async function sys_RequestPush_DelRecordAsync(lngRequestId: number): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(sys_RequestPush_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, lngRequestId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sys_RequestPush_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sys_RequestPush_ConstructorName, strThisFuncName);
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
 * @param arrRequestId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function sys_RequestPush_Delsys_RequestPushsAsync(arrRequestId: Array<string>): Promise<number> 
{
const strThisFuncName = "Delsys_RequestPushsAsync";
const strAction = "Delsys_RequestPushs";
const strUrl = GetWebApiUrl(sys_RequestPush_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrRequestId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sys_RequestPush_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sys_RequestPush_ConstructorName, strThisFuncName);
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
export async function sys_RequestPush_Delsys_RequestPushsByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "Delsys_RequestPushsByCondAsync";
const strAction = "Delsys_RequestPushsByCond";
const strUrl = GetWebApiUrl(sys_RequestPush_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sys_RequestPush_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sys_RequestPush_ConstructorName, strThisFuncName);
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
 * @param objsys_RequestPushEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function sys_RequestPush_AddNewRecordAsync(objsys_RequestPushEN: clssys_RequestPushEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objsys_RequestPushEN);
const strUrl = GetWebApiUrl(sys_RequestPush_Controller, strAction);
try
{
const response = await axios.post(strUrl, objsys_RequestPushEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sys_RequestPush_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sys_RequestPush_ConstructorName, strThisFuncName);
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
 * @param objsys_RequestPushEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function sys_RequestPush_AddNewRecordWithReturnKeyAsync(objsys_RequestPushEN: clssys_RequestPushEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(sys_RequestPush_Controller, strAction);
try
{
const response = await axios.post(strUrl, objsys_RequestPushEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sys_RequestPush_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sys_RequestPush_ConstructorName, strThisFuncName);
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
 * @param objsys_RequestPushEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function sys_RequestPush_AddNewRecordWithReturnKey(objsys_RequestPushEN: clssys_RequestPushEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objsys_RequestPushEN.requestId === null || objsys_RequestPushEN.requestId === 0)
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(sys_RequestPush_Controller, strAction);
try
{
const response = await axios.post(strUrl, objsys_RequestPushEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sys_RequestPush_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sys_RequestPush_ConstructorName, strThisFuncName);
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
 * @param objsys_RequestPushEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function sys_RequestPush_UpdateRecordAsync(objsys_RequestPushEN: clssys_RequestPushEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objsys_RequestPushEN.sfUpdFldSetStr === undefined || objsys_RequestPushEN.sfUpdFldSetStr === null || objsys_RequestPushEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objsys_RequestPushEN.requestId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(sys_RequestPush_Controller, strAction);
try
{
const response = await axios.post(strUrl, objsys_RequestPushEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sys_RequestPush_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sys_RequestPush_ConstructorName, strThisFuncName);
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
 * @param objsys_RequestPushEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function sys_RequestPush_UpdateWithConditionAsync(objsys_RequestPushEN: clssys_RequestPushEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objsys_RequestPushEN.sfUpdFldSetStr === undefined || objsys_RequestPushEN.sfUpdFldSetStr === null || objsys_RequestPushEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objsys_RequestPushEN.requestId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(sys_RequestPush_Controller, strAction);
objsys_RequestPushEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objsys_RequestPushEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sys_RequestPush_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sys_RequestPush_ConstructorName, strThisFuncName);
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
 * @param objlngRequestId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function sys_RequestPush_IsExistRecord_Cache(objsys_RequestPush_Cond: clssys_RequestPushEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrsys_RequestPushObjLst_Cache = await sys_RequestPush_GetObjLst_Cache();
if (arrsys_RequestPushObjLst_Cache == null) return false;
let arrsys_RequestPush_Sel: Array < clssys_RequestPushEN > = arrsys_RequestPushObjLst_Cache;
if (objsys_RequestPush_Cond.sf_FldComparisonOp == null || objsys_RequestPush_Cond.sf_FldComparisonOp == "") return arrsys_RequestPush_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objsys_RequestPush_Cond.sf_FldComparisonOp);
//console.log("clssys_RequestPushWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objsys_RequestPush_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objsys_RequestPush_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrsys_RequestPush_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objsys_RequestPush_Cond), sys_RequestPush_ConstructorName, strThisFuncName);
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
export async function sys_RequestPush_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(sys_RequestPush_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sys_RequestPush_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sys_RequestPush_ConstructorName, strThisFuncName);
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
 * @param lngRequestId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function sys_RequestPush_IsExist(lngRequestId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(sys_RequestPush_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"RequestId": lngRequestId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sys_RequestPush_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sys_RequestPush_ConstructorName, strThisFuncName);
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
 * @param lngRequestId:所给的关键字
 * @returns 对象
*/
export async function sys_RequestPush_IsExist_Cache(lngRequestId:number) {
const strThisFuncName = "IsExist_Cache";
const arrsys_RequestPushObjLst_Cache = await sys_RequestPush_GetObjLst_Cache();
if (arrsys_RequestPushObjLst_Cache == null) return false;
try
{
const arrsys_RequestPush_Sel: Array <clssys_RequestPushEN> = arrsys_RequestPushObjLst_Cache.filter(x => x.requestId == lngRequestId);
if (arrsys_RequestPush_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngRequestId, sys_RequestPush_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param lngRequestId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function sys_RequestPush_IsExistAsync(lngRequestId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(sys_RequestPush_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "lngRequestId": lngRequestId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sys_RequestPush_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sys_RequestPush_ConstructorName, strThisFuncName);
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
export async function sys_RequestPush_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(sys_RequestPush_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sys_RequestPush_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sys_RequestPush_ConstructorName, strThisFuncName);
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
 * @param objsys_RequestPush_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function sys_RequestPush_GetRecCountByCond_Cache(objsys_RequestPush_Cond: clssys_RequestPushEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrsys_RequestPushObjLst_Cache = await sys_RequestPush_GetObjLst_Cache();
if (arrsys_RequestPushObjLst_Cache == null) return 0;
let arrsys_RequestPush_Sel: Array < clssys_RequestPushEN > = arrsys_RequestPushObjLst_Cache;
if (objsys_RequestPush_Cond.sf_FldComparisonOp == null || objsys_RequestPush_Cond.sf_FldComparisonOp == "") return arrsys_RequestPush_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objsys_RequestPush_Cond.sf_FldComparisonOp);
//console.log("clssys_RequestPushWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objsys_RequestPush_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objsys_RequestPush_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrsys_RequestPush_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objsys_RequestPush_Cond), sys_RequestPush_ConstructorName, strThisFuncName);
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
export async function sys_RequestPush_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(sys_RequestPush_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sys_RequestPush_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sys_RequestPush_ConstructorName, strThisFuncName);
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
export function sys_RequestPush_GetWebApiUrl(strController: string, strAction: string): string {
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
export function sys_RequestPush_ReFreshCache():void
{
const strThisFuncName = "ReFreshCache";

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = clssys_RequestPushEN._CurrTabName;
switch (clssys_RequestPushEN.CacheModeId)
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
export function sys_RequestPush_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clssys_RequestPushEN._CurrTabName;
switch (clssys_RequestPushEN.CacheModeId)
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
export function sys_RequestPush_CheckPropertyNew(pobjsys_RequestPushEN: clssys_RequestPushEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjsys_RequestPushEN.requesTypeId) == false && GetStrLen(pobjsys_RequestPushEN.requesTypeId) > 2)
{
 throw new Error("(errid:Watl000059)字段[请求类型Id(requesTypeId)]的长度不能超过2(In 请求推送表(sys_RequestPush))!值:$(pobjsys_RequestPushEN.requesTypeId)(clssys_RequestPushBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjsys_RequestPushEN.tableKey) == false && GetStrLen(pobjsys_RequestPushEN.tableKey) > 20)
{
 throw new Error("(errid:Watl000059)字段[表主键(tableKey)]的长度不能超过20(In 请求推送表(sys_RequestPush))!值:$(pobjsys_RequestPushEN.tableKey)(clssys_RequestPushBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjsys_RequestPushEN.receiveUser) == false && GetStrLen(pobjsys_RequestPushEN.receiveUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[接收用户(receiveUser)]的长度不能超过20(In 请求推送表(sys_RequestPush))!值:$(pobjsys_RequestPushEN.receiveUser)(clssys_RequestPushBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjsys_RequestPushEN.replyDate) == false && GetStrLen(pobjsys_RequestPushEN.replyDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[回复日期(replyDate)]的长度不能超过20(In 请求推送表(sys_RequestPush))!值:$(pobjsys_RequestPushEN.replyDate)(clssys_RequestPushBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjsys_RequestPushEN.requestUser) == false && GetStrLen(pobjsys_RequestPushEN.requestUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[RequestUser(requestUser)]的长度不能超过20(In 请求推送表(sys_RequestPush))!值:$(pobjsys_RequestPushEN.requestUser)(clssys_RequestPushBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjsys_RequestPushEN.requestDate) == false && GetStrLen(pobjsys_RequestPushEN.requestDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[RequestDate(requestDate)]的长度不能超过20(In 请求推送表(sys_RequestPush))!值:$(pobjsys_RequestPushEN.requestDate)(clssys_RequestPushBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjsys_RequestPushEN.requestStata) == false && GetStrLen(pobjsys_RequestPushEN.requestStata) > 10)
{
 throw new Error("(errid:Watl000059)字段[RequestStata(requestStata)]的长度不能超过10(In 请求推送表(sys_RequestPush))!值:$(pobjsys_RequestPushEN.requestStata)(clssys_RequestPushBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjsys_RequestPushEN.memo) == false && GetStrLen(pobjsys_RequestPushEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 请求推送表(sys_RequestPush))!值:$(pobjsys_RequestPushEN.memo)(clssys_RequestPushBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjsys_RequestPushEN.id_CurrEduCls) == false && GetStrLen(pobjsys_RequestPushEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 请求推送表(sys_RequestPush))!值:$(pobjsys_RequestPushEN.id_CurrEduCls)(clssys_RequestPushBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjsys_RequestPushEN.pushTypeId) == false && GetStrLen(pobjsys_RequestPushEN.pushTypeId) > 2)
{
 throw new Error("(errid:Watl000059)字段[推送类型Id(pushTypeId)]的长度不能超过2(In 请求推送表(sys_RequestPush))!值:$(pobjsys_RequestPushEN.pushTypeId)(clssys_RequestPushBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null != pobjsys_RequestPushEN.requestId && undefined !== pobjsys_RequestPushEN.requestId && tzDataType.isNumber(pobjsys_RequestPushEN.requestId) === false)
{
 throw new Error("(errid:Watl000060)字段[RequestId(requestId)]的值:[$(pobjsys_RequestPushEN.requestId)], 非法，应该为数值型(In 请求推送表(sys_RequestPush))!(clssys_RequestPushBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjsys_RequestPushEN.requesTypeId) == false && undefined !== pobjsys_RequestPushEN.requesTypeId && tzDataType.isString(pobjsys_RequestPushEN.requesTypeId) === false)
{
 throw new Error("(errid:Watl000060)字段[请求类型Id(requesTypeId)]的值:[$(pobjsys_RequestPushEN.requesTypeId)], 非法，应该为字符型(In 请求推送表(sys_RequestPush))!(clssys_RequestPushBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjsys_RequestPushEN.tableKey) == false && undefined !== pobjsys_RequestPushEN.tableKey && tzDataType.isString(pobjsys_RequestPushEN.tableKey) === false)
{
 throw new Error("(errid:Watl000060)字段[表主键(tableKey)]的值:[$(pobjsys_RequestPushEN.tableKey)], 非法，应该为字符型(In 请求推送表(sys_RequestPush))!(clssys_RequestPushBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjsys_RequestPushEN.receiveUser) == false && undefined !== pobjsys_RequestPushEN.receiveUser && tzDataType.isString(pobjsys_RequestPushEN.receiveUser) === false)
{
 throw new Error("(errid:Watl000060)字段[接收用户(receiveUser)]的值:[$(pobjsys_RequestPushEN.receiveUser)], 非法，应该为字符型(In 请求推送表(sys_RequestPush))!(clssys_RequestPushBL:CheckPropertyNew)");
}
if (null != pobjsys_RequestPushEN.isReply && undefined !== pobjsys_RequestPushEN.isReply && tzDataType.isBoolean(pobjsys_RequestPushEN.isReply) === false)
{
 throw new Error("(errid:Watl000060)字段[是否回复(isReply)]的值:[$(pobjsys_RequestPushEN.isReply)], 非法，应该为布尔型(In 请求推送表(sys_RequestPush))!(clssys_RequestPushBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjsys_RequestPushEN.replyDate) == false && undefined !== pobjsys_RequestPushEN.replyDate && tzDataType.isString(pobjsys_RequestPushEN.replyDate) === false)
{
 throw new Error("(errid:Watl000060)字段[回复日期(replyDate)]的值:[$(pobjsys_RequestPushEN.replyDate)], 非法，应该为字符型(In 请求推送表(sys_RequestPush))!(clssys_RequestPushBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjsys_RequestPushEN.requestUser) == false && undefined !== pobjsys_RequestPushEN.requestUser && tzDataType.isString(pobjsys_RequestPushEN.requestUser) === false)
{
 throw new Error("(errid:Watl000060)字段[RequestUser(requestUser)]的值:[$(pobjsys_RequestPushEN.requestUser)], 非法，应该为字符型(In 请求推送表(sys_RequestPush))!(clssys_RequestPushBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjsys_RequestPushEN.requestDate) == false && undefined !== pobjsys_RequestPushEN.requestDate && tzDataType.isString(pobjsys_RequestPushEN.requestDate) === false)
{
 throw new Error("(errid:Watl000060)字段[RequestDate(requestDate)]的值:[$(pobjsys_RequestPushEN.requestDate)], 非法，应该为字符型(In 请求推送表(sys_RequestPush))!(clssys_RequestPushBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjsys_RequestPushEN.requestStata) == false && undefined !== pobjsys_RequestPushEN.requestStata && tzDataType.isString(pobjsys_RequestPushEN.requestStata) === false)
{
 throw new Error("(errid:Watl000060)字段[RequestStata(requestStata)]的值:[$(pobjsys_RequestPushEN.requestStata)], 非法，应该为字符型(In 请求推送表(sys_RequestPush))!(clssys_RequestPushBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjsys_RequestPushEN.memo) == false && undefined !== pobjsys_RequestPushEN.memo && tzDataType.isString(pobjsys_RequestPushEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjsys_RequestPushEN.memo)], 非法，应该为字符型(In 请求推送表(sys_RequestPush))!(clssys_RequestPushBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjsys_RequestPushEN.id_CurrEduCls) == false && undefined !== pobjsys_RequestPushEN.id_CurrEduCls && tzDataType.isString(pobjsys_RequestPushEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjsys_RequestPushEN.id_CurrEduCls)], 非法，应该为字符型(In 请求推送表(sys_RequestPush))!(clssys_RequestPushBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjsys_RequestPushEN.pushTypeId) == false && undefined !== pobjsys_RequestPushEN.pushTypeId && tzDataType.isString(pobjsys_RequestPushEN.pushTypeId) === false)
{
 throw new Error("(errid:Watl000060)字段[推送类型Id(pushTypeId)]的值:[$(pobjsys_RequestPushEN.pushTypeId)], 非法，应该为字符型(In 请求推送表(sys_RequestPush))!(clssys_RequestPushBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjsys_RequestPushEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function sys_RequestPush_CheckProperty4Update (pobjsys_RequestPushEN: clssys_RequestPushEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjsys_RequestPushEN.requesTypeId) == false && GetStrLen(pobjsys_RequestPushEN.requesTypeId) > 2)
{
 throw new Error("(errid:Watl000062)字段[请求类型Id(requesTypeId)]的长度不能超过2(In 请求推送表(sys_RequestPush))!值:$(pobjsys_RequestPushEN.requesTypeId)(clssys_RequestPushBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjsys_RequestPushEN.tableKey) == false && GetStrLen(pobjsys_RequestPushEN.tableKey) > 20)
{
 throw new Error("(errid:Watl000062)字段[表主键(tableKey)]的长度不能超过20(In 请求推送表(sys_RequestPush))!值:$(pobjsys_RequestPushEN.tableKey)(clssys_RequestPushBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjsys_RequestPushEN.receiveUser) == false && GetStrLen(pobjsys_RequestPushEN.receiveUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[接收用户(receiveUser)]的长度不能超过20(In 请求推送表(sys_RequestPush))!值:$(pobjsys_RequestPushEN.receiveUser)(clssys_RequestPushBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjsys_RequestPushEN.replyDate) == false && GetStrLen(pobjsys_RequestPushEN.replyDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[回复日期(replyDate)]的长度不能超过20(In 请求推送表(sys_RequestPush))!值:$(pobjsys_RequestPushEN.replyDate)(clssys_RequestPushBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjsys_RequestPushEN.requestUser) == false && GetStrLen(pobjsys_RequestPushEN.requestUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[RequestUser(requestUser)]的长度不能超过20(In 请求推送表(sys_RequestPush))!值:$(pobjsys_RequestPushEN.requestUser)(clssys_RequestPushBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjsys_RequestPushEN.requestDate) == false && GetStrLen(pobjsys_RequestPushEN.requestDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[RequestDate(requestDate)]的长度不能超过20(In 请求推送表(sys_RequestPush))!值:$(pobjsys_RequestPushEN.requestDate)(clssys_RequestPushBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjsys_RequestPushEN.requestStata) == false && GetStrLen(pobjsys_RequestPushEN.requestStata) > 10)
{
 throw new Error("(errid:Watl000062)字段[RequestStata(requestStata)]的长度不能超过10(In 请求推送表(sys_RequestPush))!值:$(pobjsys_RequestPushEN.requestStata)(clssys_RequestPushBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjsys_RequestPushEN.memo) == false && GetStrLen(pobjsys_RequestPushEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 请求推送表(sys_RequestPush))!值:$(pobjsys_RequestPushEN.memo)(clssys_RequestPushBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjsys_RequestPushEN.id_CurrEduCls) == false && GetStrLen(pobjsys_RequestPushEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 请求推送表(sys_RequestPush))!值:$(pobjsys_RequestPushEN.id_CurrEduCls)(clssys_RequestPushBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjsys_RequestPushEN.pushTypeId) == false && GetStrLen(pobjsys_RequestPushEN.pushTypeId) > 2)
{
 throw new Error("(errid:Watl000062)字段[推送类型Id(pushTypeId)]的长度不能超过2(In 请求推送表(sys_RequestPush))!值:$(pobjsys_RequestPushEN.pushTypeId)(clssys_RequestPushBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null != pobjsys_RequestPushEN.requestId && undefined !== pobjsys_RequestPushEN.requestId && tzDataType.isNumber(pobjsys_RequestPushEN.requestId) === false)
{
 throw new Error("(errid:Watl000063)字段[RequestId(requestId)]的值:[$(pobjsys_RequestPushEN.requestId)], 非法，应该为数值型(In 请求推送表(sys_RequestPush))!(clssys_RequestPushBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjsys_RequestPushEN.requesTypeId) == false && undefined !== pobjsys_RequestPushEN.requesTypeId && tzDataType.isString(pobjsys_RequestPushEN.requesTypeId) === false)
{
 throw new Error("(errid:Watl000063)字段[请求类型Id(requesTypeId)]的值:[$(pobjsys_RequestPushEN.requesTypeId)], 非法，应该为字符型(In 请求推送表(sys_RequestPush))!(clssys_RequestPushBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjsys_RequestPushEN.tableKey) == false && undefined !== pobjsys_RequestPushEN.tableKey && tzDataType.isString(pobjsys_RequestPushEN.tableKey) === false)
{
 throw new Error("(errid:Watl000063)字段[表主键(tableKey)]的值:[$(pobjsys_RequestPushEN.tableKey)], 非法，应该为字符型(In 请求推送表(sys_RequestPush))!(clssys_RequestPushBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjsys_RequestPushEN.receiveUser) == false && undefined !== pobjsys_RequestPushEN.receiveUser && tzDataType.isString(pobjsys_RequestPushEN.receiveUser) === false)
{
 throw new Error("(errid:Watl000063)字段[接收用户(receiveUser)]的值:[$(pobjsys_RequestPushEN.receiveUser)], 非法，应该为字符型(In 请求推送表(sys_RequestPush))!(clssys_RequestPushBL:CheckProperty4Update)");
}
if (null != pobjsys_RequestPushEN.isReply && undefined !== pobjsys_RequestPushEN.isReply && tzDataType.isBoolean(pobjsys_RequestPushEN.isReply) === false)
{
 throw new Error("(errid:Watl000063)字段[是否回复(isReply)]的值:[$(pobjsys_RequestPushEN.isReply)], 非法，应该为布尔型(In 请求推送表(sys_RequestPush))!(clssys_RequestPushBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjsys_RequestPushEN.replyDate) == false && undefined !== pobjsys_RequestPushEN.replyDate && tzDataType.isString(pobjsys_RequestPushEN.replyDate) === false)
{
 throw new Error("(errid:Watl000063)字段[回复日期(replyDate)]的值:[$(pobjsys_RequestPushEN.replyDate)], 非法，应该为字符型(In 请求推送表(sys_RequestPush))!(clssys_RequestPushBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjsys_RequestPushEN.requestUser) == false && undefined !== pobjsys_RequestPushEN.requestUser && tzDataType.isString(pobjsys_RequestPushEN.requestUser) === false)
{
 throw new Error("(errid:Watl000063)字段[RequestUser(requestUser)]的值:[$(pobjsys_RequestPushEN.requestUser)], 非法，应该为字符型(In 请求推送表(sys_RequestPush))!(clssys_RequestPushBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjsys_RequestPushEN.requestDate) == false && undefined !== pobjsys_RequestPushEN.requestDate && tzDataType.isString(pobjsys_RequestPushEN.requestDate) === false)
{
 throw new Error("(errid:Watl000063)字段[RequestDate(requestDate)]的值:[$(pobjsys_RequestPushEN.requestDate)], 非法，应该为字符型(In 请求推送表(sys_RequestPush))!(clssys_RequestPushBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjsys_RequestPushEN.requestStata) == false && undefined !== pobjsys_RequestPushEN.requestStata && tzDataType.isString(pobjsys_RequestPushEN.requestStata) === false)
{
 throw new Error("(errid:Watl000063)字段[RequestStata(requestStata)]的值:[$(pobjsys_RequestPushEN.requestStata)], 非法，应该为字符型(In 请求推送表(sys_RequestPush))!(clssys_RequestPushBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjsys_RequestPushEN.memo) == false && undefined !== pobjsys_RequestPushEN.memo && tzDataType.isString(pobjsys_RequestPushEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjsys_RequestPushEN.memo)], 非法，应该为字符型(In 请求推送表(sys_RequestPush))!(clssys_RequestPushBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjsys_RequestPushEN.id_CurrEduCls) == false && undefined !== pobjsys_RequestPushEN.id_CurrEduCls && tzDataType.isString(pobjsys_RequestPushEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjsys_RequestPushEN.id_CurrEduCls)], 非法，应该为字符型(In 请求推送表(sys_RequestPush))!(clssys_RequestPushBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjsys_RequestPushEN.pushTypeId) == false && undefined !== pobjsys_RequestPushEN.pushTypeId && tzDataType.isString(pobjsys_RequestPushEN.pushTypeId) === false)
{
 throw new Error("(errid:Watl000063)字段[推送类型Id(pushTypeId)]的值:[$(pobjsys_RequestPushEN.pushTypeId)], 非法，应该为字符型(In 请求推送表(sys_RequestPush))!(clssys_RequestPushBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjsys_RequestPushEN.requestId 
 || pobjsys_RequestPushEN.requestId != null && pobjsys_RequestPushEN.requestId.toString()  ===  "")
{
 throw new Error("(errid:Watl000064)字段[RequestId]不能为空(In 请求推送表)!(clssys_RequestPushBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjsys_RequestPushEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function sys_RequestPush_GetJSONStrByObj (pobjsys_RequestPushEN: clssys_RequestPushEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjsys_RequestPushEN.sfUpdFldSetStr = pobjsys_RequestPushEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjsys_RequestPushEN);
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
export function sys_RequestPush_GetObjLstByJSONStr (strJSON: string): Array<clssys_RequestPushEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrsys_RequestPushObjLst = new Array<clssys_RequestPushEN>();
if (strJSON === "")
{
return arrsys_RequestPushObjLst;
}
try
{
arrsys_RequestPushObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrsys_RequestPushObjLst;
}
return arrsys_RequestPushObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrsys_RequestPushObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function sys_RequestPush_GetObjLstByJSONObjLst (arrsys_RequestPushObjLstS: Array<clssys_RequestPushEN>): Array<clssys_RequestPushEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrsys_RequestPushObjLst = new Array<clssys_RequestPushEN>();
for (const objInFor of arrsys_RequestPushObjLstS) {
const obj1 = sys_RequestPush_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrsys_RequestPushObjLst.push(obj1);
}
return arrsys_RequestPushObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function sys_RequestPush_GetObjByJSONStr (strJSON: string): clssys_RequestPushEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjsys_RequestPushEN = new clssys_RequestPushEN();
if (strJSON === "")
{
return pobjsys_RequestPushEN;
}
try
{
pobjsys_RequestPushEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjsys_RequestPushEN;
}
return pobjsys_RequestPushEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function sys_RequestPush_GetCombineCondition(objsys_RequestPush_Cond: clssys_RequestPushEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objsys_RequestPush_Cond.dicFldComparisonOp, clssys_RequestPushEN.con_RequestId) == true)
{
const strComparisonOp_RequestId:string = objsys_RequestPush_Cond.dicFldComparisonOp[clssys_RequestPushEN.con_RequestId];
strWhereCond += Format(" And {0} {2} {1}", clssys_RequestPushEN.con_RequestId, objsys_RequestPush_Cond.requestId, strComparisonOp_RequestId);
}
if (Object.prototype.hasOwnProperty.call(objsys_RequestPush_Cond.dicFldComparisonOp, clssys_RequestPushEN.con_RequesTypeId) == true)
{
const strComparisonOp_RequesTypeId:string = objsys_RequestPush_Cond.dicFldComparisonOp[clssys_RequestPushEN.con_RequesTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clssys_RequestPushEN.con_RequesTypeId, objsys_RequestPush_Cond.requesTypeId, strComparisonOp_RequesTypeId);
}
if (Object.prototype.hasOwnProperty.call(objsys_RequestPush_Cond.dicFldComparisonOp, clssys_RequestPushEN.con_TableKey) == true)
{
const strComparisonOp_TableKey:string = objsys_RequestPush_Cond.dicFldComparisonOp[clssys_RequestPushEN.con_TableKey];
strWhereCond += Format(" And {0} {2} '{1}'", clssys_RequestPushEN.con_TableKey, objsys_RequestPush_Cond.tableKey, strComparisonOp_TableKey);
}
if (Object.prototype.hasOwnProperty.call(objsys_RequestPush_Cond.dicFldComparisonOp, clssys_RequestPushEN.con_ReceiveUser) == true)
{
const strComparisonOp_ReceiveUser:string = objsys_RequestPush_Cond.dicFldComparisonOp[clssys_RequestPushEN.con_ReceiveUser];
strWhereCond += Format(" And {0} {2} '{1}'", clssys_RequestPushEN.con_ReceiveUser, objsys_RequestPush_Cond.receiveUser, strComparisonOp_ReceiveUser);
}
if (Object.prototype.hasOwnProperty.call(objsys_RequestPush_Cond.dicFldComparisonOp, clssys_RequestPushEN.con_IsReply) == true)
{
if (objsys_RequestPush_Cond.isReply == true)
{
strWhereCond += Format(" And {0} = '1'", clssys_RequestPushEN.con_IsReply);
}
else
{
strWhereCond += Format(" And {0} = '0'", clssys_RequestPushEN.con_IsReply);
}
}
if (Object.prototype.hasOwnProperty.call(objsys_RequestPush_Cond.dicFldComparisonOp, clssys_RequestPushEN.con_ReplyDate) == true)
{
const strComparisonOp_ReplyDate:string = objsys_RequestPush_Cond.dicFldComparisonOp[clssys_RequestPushEN.con_ReplyDate];
strWhereCond += Format(" And {0} {2} '{1}'", clssys_RequestPushEN.con_ReplyDate, objsys_RequestPush_Cond.replyDate, strComparisonOp_ReplyDate);
}
if (Object.prototype.hasOwnProperty.call(objsys_RequestPush_Cond.dicFldComparisonOp, clssys_RequestPushEN.con_RequestUser) == true)
{
const strComparisonOp_RequestUser:string = objsys_RequestPush_Cond.dicFldComparisonOp[clssys_RequestPushEN.con_RequestUser];
strWhereCond += Format(" And {0} {2} '{1}'", clssys_RequestPushEN.con_RequestUser, objsys_RequestPush_Cond.requestUser, strComparisonOp_RequestUser);
}
if (Object.prototype.hasOwnProperty.call(objsys_RequestPush_Cond.dicFldComparisonOp, clssys_RequestPushEN.con_RequestDate) == true)
{
const strComparisonOp_RequestDate:string = objsys_RequestPush_Cond.dicFldComparisonOp[clssys_RequestPushEN.con_RequestDate];
strWhereCond += Format(" And {0} {2} '{1}'", clssys_RequestPushEN.con_RequestDate, objsys_RequestPush_Cond.requestDate, strComparisonOp_RequestDate);
}
if (Object.prototype.hasOwnProperty.call(objsys_RequestPush_Cond.dicFldComparisonOp, clssys_RequestPushEN.con_RequestStata) == true)
{
const strComparisonOp_RequestStata:string = objsys_RequestPush_Cond.dicFldComparisonOp[clssys_RequestPushEN.con_RequestStata];
strWhereCond += Format(" And {0} {2} '{1}'", clssys_RequestPushEN.con_RequestStata, objsys_RequestPush_Cond.requestStata, strComparisonOp_RequestStata);
}
if (Object.prototype.hasOwnProperty.call(objsys_RequestPush_Cond.dicFldComparisonOp, clssys_RequestPushEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objsys_RequestPush_Cond.dicFldComparisonOp[clssys_RequestPushEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clssys_RequestPushEN.con_Memo, objsys_RequestPush_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objsys_RequestPush_Cond.dicFldComparisonOp, clssys_RequestPushEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objsys_RequestPush_Cond.dicFldComparisonOp[clssys_RequestPushEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clssys_RequestPushEN.con_id_CurrEduCls, objsys_RequestPush_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (Object.prototype.hasOwnProperty.call(objsys_RequestPush_Cond.dicFldComparisonOp, clssys_RequestPushEN.con_PushTypeId) == true)
{
const strComparisonOp_PushTypeId:string = objsys_RequestPush_Cond.dicFldComparisonOp[clssys_RequestPushEN.con_PushTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clssys_RequestPushEN.con_PushTypeId, objsys_RequestPush_Cond.pushTypeId, strComparisonOp_PushTypeId);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--sys_RequestPush(请求推送表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param strRequesTypeId: 请求类型Id(要求唯一的字段)
 * @param strTableKey: 表主键(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function sys_RequestPush_GetUniCondStr_RequesTypeId_TableKey(objsys_RequestPushEN: clssys_RequestPushEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and RequesTypeId = '{0}'", objsys_RequestPushEN.requesTypeId);
 strWhereCond +=  Format(" and TableKey = '{0}'", objsys_RequestPushEN.tableKey);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--sys_RequestPush(请求推送表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param strRequesTypeId: 请求类型Id(要求唯一的字段)
 * @param strTableKey: 表主键(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function sys_RequestPush_GetUniCondStr4Update_RequesTypeId_TableKey(objsys_RequestPushEN: clssys_RequestPushEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and RequestId <> '{0}'", objsys_RequestPushEN.requestId);
 strWhereCond +=  Format(" and RequesTypeId = '{0}'", objsys_RequestPushEN.requesTypeId);
 strWhereCond +=  Format(" and TableKey = '{0}'", objsys_RequestPushEN.tableKey);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objsys_RequestPushENS:源对象
 * @param objsys_RequestPushENT:目标对象
*/
export function sys_RequestPush_CopyObjTo(objsys_RequestPushENS: clssys_RequestPushEN , objsys_RequestPushENT: clssys_RequestPushEN ): void 
{
objsys_RequestPushENT.requestId = objsys_RequestPushENS.requestId; //RequestId
objsys_RequestPushENT.requesTypeId = objsys_RequestPushENS.requesTypeId; //请求类型Id
objsys_RequestPushENT.tableKey = objsys_RequestPushENS.tableKey; //表主键
objsys_RequestPushENT.receiveUser = objsys_RequestPushENS.receiveUser; //接收用户
objsys_RequestPushENT.isReply = objsys_RequestPushENS.isReply; //是否回复
objsys_RequestPushENT.replyDate = objsys_RequestPushENS.replyDate; //回复日期
objsys_RequestPushENT.requestUser = objsys_RequestPushENS.requestUser; //RequestUser
objsys_RequestPushENT.requestDate = objsys_RequestPushENS.requestDate; //RequestDate
objsys_RequestPushENT.requestStata = objsys_RequestPushENS.requestStata; //RequestStata
objsys_RequestPushENT.memo = objsys_RequestPushENS.memo; //备注
objsys_RequestPushENT.id_CurrEduCls = objsys_RequestPushENS.id_CurrEduCls; //教学班流水号
objsys_RequestPushENT.pushTypeId = objsys_RequestPushENS.pushTypeId; //推送类型Id
objsys_RequestPushENT.sfUpdFldSetStr = objsys_RequestPushENS.updFldString; //sfUpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objsys_RequestPushENS:源对象
 * @param objsys_RequestPushENT:目标对象
*/
export function sys_RequestPush_GetObjFromJsonObj(objsys_RequestPushENS: clssys_RequestPushEN): clssys_RequestPushEN 
{
 const objsys_RequestPushENT: clssys_RequestPushEN = new clssys_RequestPushEN();
ObjectAssign(objsys_RequestPushENT, objsys_RequestPushENS);
 return objsys_RequestPushENT;
}